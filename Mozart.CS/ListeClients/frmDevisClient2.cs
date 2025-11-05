using DevExpress.XtraEditors;
using MozartCS.ListeClients;
using MozartCS.Properties;
using MozartLib;
using MozartNet;
using MozartUC;
using ReportEmalec.Net;
using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Diagnostics;
using System.Drawing;
using System.Globalization;
using System.Reflection;
using System.Windows.Forms;
using MZCtrlResources = MozartControls.Properties.Resources;
using MZUtils = MozartControls.Utils;

namespace MozartCS
{
  public partial class frmDevisClient2 : Form
  {
    private const string COL_QUANTITE = "Quantite";
    private const string COL_NFOUCOEFF = "NFOUCOEFF";

    public int miNumDI;
    public int miNumAction;
    public int miNumDevisCL;
    public string mstrStatutAlerte = "";

    private int NCLINUM;
    private int NSITNUM;
    private double mdecTva;
    //private bool bMail;
    private string cEnvMail;
    private string mTypeDevis;

    private double mTauxFraisGeneraux;
    private double dValRFA;

    private DataTable mdtArticles;

    private string mStrStatutValidationDevis = "";

    public frmDevisClient2() { InitializeComponent(); }

    private void frmDevisClient2_Load(object sender, System.EventArgs e)
    {
      try
      {
        string sSql;

        Cursor.Current = Cursors.WaitCursor;
        ModuleMain.Initboutons(this);

        txtInfoInterne.Visible = ModuleMain.RechercheDroitMenu(txtInfoInterne.HelpContextID);

        //init du 16/05/2024
        txtMtDevisSTT.Visible = ModuleMain.RechercheDroitMenu(txtMtDevisSTT.HelpContextID);
        txtMarge.Visible = ModuleMain.RechercheDroitMenu(txtMarge.HelpContextID);

        optqui1.Text = optqui1.Text.Replace("$ste", MozartParams.NomSociete);

        // Taux de frais généraux
        sSql = "SELECT NTAUX_ANA_VAL FROM TTAUX_ANA WHERE VSOCIETE = App_Name() AND NTAUX_ANA_ANNEE = YEAR(GetDate()) AND VTAUX_ANA_LIB = 'Taux frais généraux'";
        mTauxFraisGeneraux = ((double)ModuleData.ExecuteScalarDouble(sSql)) / 100;

        // Taux RFA
        dValRFA = UtilsDevis.GetTauxRFA(miNumAction);
        if (dValRFA == -2) { dValRFA = 0; }

        sSql = "select NPERNUM, VPERNOM + ' ' + VPERPRE [VPERNOM] from TPER where CPERACTIF = 'O' AND VSOCIETE = App_Name() ORDER BY VPERNOM, VPERPRE";
        cbotech.Init(MozartDatabase.cnxMozart, sSql, "NPERNUM", "VPERNOM", new List<string>() { Resources.col_Num, Resources.col_Nom }, 150, 550, true);  // apiCombo

        ModuleData.RemplirCombo(cboUrg, $"select CURGCOD, VURGLIB from api_v_comboUrg where CURGCOD <> 4 AND langue = '{MozartParams.Langue}'", true); // combo
        cboUrg.ValueMember = "CURGCOD";
        cboUrg.DisplayMember = "VURGLIB";

        DataTable dtUrg = cboUrg.DataSource as DataTable;
        DataRow r = dtUrg.NewRow();
        r[0] = "0"; r[1] = "";
        dtUrg.Rows.InsertAt(r, 0);

        ModuleData.RemplirCombo(cboTheme, $"select NTHEME, VTHEME from TREF_THEMES where langue = '{MozartParams.Langue}' ORDER BY  VTHEME"); // combo
        cboTheme.ValueMember = "NTHEME";
        cboTheme.DisplayMember = "VTHEME";

        InitApiTGridFour();

        InitialiserFeuille();

        this.uCtrlValidation1.DevisStatusUpdated += new EventHandler(MyEventHandlerFunction_DevisStatusUpdated);
        this.uCtrlValidation1.DevisRemarqueEnter += new EventHandler(MyEventHandlerFunction_DevisRemarqueEnter);
        this.uCtrlValidation1.DevisEnablePrintAndVisu += new EventHandler(MyEventHandlerFunction_DevisEnablePrintAndVisu);
      }
      catch (Exception ex)
      {
        MZUtils.displayError(MethodBase.GetCurrentMethod().Name, ex);
      }
      finally
      {
        Cursor.Current = Cursors.Default;
      }
    }

    // Evènement déclenché par UCtrlValidation pour activer le bouton Visualier/Imprimer
    public void MyEventHandlerFunction_DevisStatusUpdated(object sender, EventArgs e)
    {
      setReadOnly();
    }

    // Evènement déclenché par UCtrlValidation pour la saisie de remarques
    public void MyEventHandlerFunction_DevisRemarqueEnter(object sender, EventArgs e)
    {
      framObs.Visible = true;
      TxtObs.Focus();
    }

    public void MyEventHandlerFunction_DevisEnablePrintAndVisu(object sender, EventArgs e)
    {
      uCtrlValidation1.Visible = false;
      cmdVisualiser.Enabled = true;
    }

    private void cmdValider_Click(object sender, EventArgs e)
    {
      try
      {
        // Le devis passe en type 'G'
        EnregistrerDevisCL(false);
      }
      catch (Exception ex)
      {
        MZUtils.displayError(MethodBase.GetCurrentMethod().Name, ex);
      }
    }

    private void cmdVisualiser_Click(object sender, EventArgs e)
    {
      visualiser(false);
    }

    private void visualiser(bool pModeBrouillon)
    {
      string sDest;

      Cursor.Current = Cursors.WaitCursor;

      //  type de destinataire (site, raison sociale ou contact)
      switch (cboDemandeur.SelectedIndex)
      {
        case 0:
          sDest = "TCSIT|NSITNUM|" + NSITNUM;
          break;

        case 1:
          sDest = "TRSF|NRSFNUM|" + cboDemandeur.GetItemData();
          break;

        default:
          sDest = "TCCL|NCCLCODE|" + cboDemandeur.GetItemData();
          break;

      }

      // recherche de la langue d'affichage du devis
      string sLgMod = cboDemandeur.GetItemData() == 0 ? ModuleMain.CodePays(txtPaysSite.Text) : txtPaysCli.Tag.ToString();
      sLgMod = sLgMod.Substring(0, 2);

      new frmMainReport
      {
        bLaunchByProcessStart = false,
        sTypeReport = (pModeBrouillon ? "DEVIS_V2_B" : "DEVIS_V2"),
        sIdentifiant = miNumDevisCL.ToString(),
        InfosMail = sDest,
        sNomSociete = MozartParams.NomSociete,
        sLangue = sLgMod,
        sOption = "PREVIEW",
        strType = "DC", // A Voir, c'est pour les infos mails
        numAction = miNumAction
      }.ShowDialog();

      Cursor.Current = Cursors.Default;
    }

    private void cmdBrouillon_Click(object sender, EventArgs e)
    {
      visualiser(true);
    }

    private void frmDevisClient2_FormClosing(object sender, FormClosingEventArgs e)
    {
      // envoi du devis si nécessaire
      //if (bMail && miNumDevisCL > 0)
      //  ModuleData.ExecuteNonQuery($"exec api_sp_SendMailNewDevis {miNumAction}");
    }

    private void optQui_CheckedChanged(object sender, EventArgs e)
    {
      int index = Convert.ToInt32((sender as RadioButton).Name.Substring(6));
      cbotech.Visible = index != 0;
    }

    private void InitApiTGridFour()
    {
      try
      {
        apiTGridFour.AddColumn(MZCtrlResources.col_Serie, "Serie", 1400);
        apiTGridFour.AddColumn(MZCtrlResources.col_Materiel, "Article", 3600);
        apiTGridFour.AddColumn(Resources.col_marque, "Marque", 850);
        apiTGridFour.AddColumn(MZCtrlResources.col_Type, "VFOUTYP", 1400);     // equivaut a 3cm"
        apiTGridFour.AddColumn(Resources.col_Ref, "VFOUREF", 1400);
        apiTGridFour.AddColumn(Resources.col_pcb, "NFOUNBLOT", 700, "", 2);
        apiTGridFour.AddColumn(Resources.col_Prix + MozartParams.NomSociete, "Prix U", 1200, "0.000", 1);
        apiTGridFour.AddColumn(Resources.col_dateprix, "Date prix", 1300, "", 2);
        apiTGridFour.AddColumn("PV 2mois", "PRIXVENTE2MOIS", 1100, "", 2);
        apiTGridFour.AddColumn(Resources.col_Coeff, COL_NFOUCOEFF, 700, "0.00", 2);
        apiTGridFour.AddColumn(Resources.col_Prix_Client, "Prix Client", 1000, "0.000", 1);
        apiTGridFour.AddColumn(Resources.col_qte2, COL_QUANTITE, 600, "", 2);

        apiTGridFour.AddColumn(Resources.col_Total, "Prix T", 800, "0.000", 1);
        apiTGridFour.AddColumn(Resources.col_Fournisseur, "Fournisseur", 0);
        apiTGridFour.AddColumn(Resources.col_NumFourn, "NumFour", 0);
        apiTGridFour.AddColumn(Resources.col_numArt, "NumArticle", 0);
        apiTGridFour.AddColumn(Resources.col_NumSiteFour, "NumSiteFour", 0);

        // H&M : Colonne en plus
        if (NCLINUM == 494 && MozartParams.NomGroupe == "EMALEC")
          apiTGridFour.AddColumn("Code HM", "VCODECPT", 1000);

        apiTGridFour.DelockColumn(COL_QUANTITE);
        apiTGridFour.DelockColumn(COL_NFOUCOEFF);

        apiTGridFour.InitColumnList();
        mdtArticles = new DataTable();
        apiTGridFour.GridControl.DataSource = mdtArticles;
      }
      catch (Exception ex)
      {
        MZUtils.displayError(MethodBase.GetCurrentMethod().Name, ex);
      }
    }

    private double RecherchePrixV2Mois(int NumArticle)
    {
      return (double)ModuleData.ExecuteScalarDouble($"api_sp_TrouvePrixVenteFouCli {NCLINUM}, {NumArticle}");
    }

    private void ChargesArticles()
    {
      try
      {
        apiTGridFour.LoadData(mdtArticles, MozartDatabase.cnxMozart, $"api_sp_RetourArticlesDevis2 {miNumDevisCL}");
        apiTGridFour.GridControl.DataSource = mdtArticles;

        mdtArticles.Columns[COL_QUANTITE].ReadOnly = false;
        mdtArticles.Columns[COL_NFOUCOEFF].ReadOnly = false;
        mdtArticles.Columns["Prix Client"].ReadOnly = false;
        mdtArticles.Columns["Prix T"].ReadOnly = false;
        mdtArticles.Columns["PRIXVENTE2MOIS"].ReadOnly = false;
        mdtArticles.Columns["PRIXVENTE2MOIS"].AllowDBNull = true;

        foreach (DataRow row in mdtArticles.Rows)
        {
          row["PRIXVENTE2MOIS"] = RecherchePrixV2Mois(Convert.ToInt32(row["NumArticle"]));
          row[COL_QUANTITE] = row["QuantiteDevis"];
        }
      }
      catch (Exception ex)
      {
        MZUtils.displayError(MethodBase.GetCurrentMethod().Name, ex);
      }
    }

    private void InitialiserFeuille()
    {
      string lTmpStr;

      try
      {
        // on verifie si le contrat existe toujours pour ce client
        if ((miNumDevisCL == 0) && (VerifIfContratActif() == false))
        {
          MessageBox.Show(Resources.msg_pas_de_contrat, Program.AppTitle, MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
          Dispose();
          return;
        }

        // Combo Tx de réussite
        lTmpStr = "SELECT '' AS VALPOURC, '' AS TAUX UNION SELECT '0', '0' AS TAUX UNION SELECT '25', '25' UNION SELECT '50', '50' UNION SELECT '75', '75' UNION SELECT '100', '100'";
        ModuleData.RemplirCombo(cboReussite, lTmpStr, true);
        cboReussite.ValueMember = "VALPOURC";
        cboReussite.DisplayMember = "TAUX";

        // Combo TVA
        ModuleData.RemplirCombo(cboTVA, $"SELECT ID, TVA FROM TREF_TVA where VSOCIETE = '{MozartParams.NomSociete}' ORDER BY TVA", true); // combo
        cboTVA.ValueMember = "ID";
        cboTVA.DisplayMember = "TVA";

        //  recherche des info du devis (que le devis existe ou pas)
        using (SqlDataReader drD = MozartDatabase.ExecuteReader($"api_sp_RetourInfoDevisCL2 {miNumAction}"))
        {
          if (!drD.Read()) return;

          miNumDevisCL = Convert.ToInt32(drD["NDCLNUM"].ToString().Substring(2));
          mTypeDevis = drD["CDEVISTYPE"].ToString();

          NCLINUM = Convert.ToInt32(drD["NCLINUM"]);

          txtNomCli.Text = drD["VCLINOM"].ToString();
          txtDate.Text = drD["DDCLDAT"].ToString();
          txtPaysCli.Text = drD["VCLIPAYS"].ToString();
          // langue du client
          txtPaysCli.Tag = Utils.BlankIfNull(drD["VCLILANGUE"]);
          txtDemandeur.Text = drD["VDINNOM"].ToString();
          txtCompte.Text = drD["NDINCTE"].ToString();
          txtNumDI.Text = drD["NDINNUM"].ToString();

          txtSite.Text = drD["VSITNOM"].ToString();
          txtAdr1.Text = drD["VSITAD1"].ToString();
          txtAdr2.Text = drD["VSITAD2"].ToString();
          txtRespSite.Text = drD["VSITRES"].ToString();
          txtCP.Text = drD["VSITCP"].ToString();
          txtVille.Text = drD["VSITVIL"].ToString();
          txtPaysSite.Text = drD["VSITPAYS"].ToString();

          //  on rempli la combo contact client
          UtilsDevis.RemplirCboContact(cboDemandeur, NCLINUM, miNumAction);

          if (drD["NDCLDESTNUM"].ToString() != "")
            cboDemandeur.SetItemData(drD["NDCLDESTNUM"].ToString());

          if (cboDemandeur.SelectedIndex == -1) cboDemandeur.SelectedIndex = 0;

          txtDap.Text = Utils.BlankIfNull(drD["NDCLDAP"]);
          txtDre.Text = Utils.BlankIfNull(drD["NDCLDRE"]);

          // on se positionne sur le bon tech
          int iNumTech = Convert.ToInt32(drD["NDCLTECH"]);
          if (iNumTech != 0)
          {
            cbotech.SetItemData(iNumTech);
            optqui1.Checked = true;
          }
          else
            optqui0.Checked = true;

          // theme
          cboTheme.SelectedValue = drD["NDCLTHEME"];

          // urgence
          cboUrg.SelectedValue = drD["CDCLURGENCE"];

          txtPJ.Text = Utils.BlankIfNull(drD["VDCLPJ"]);

          txtObjet.Text = drD["VACTDES"].ToString();

          txtPrest.Text = Utils.BlankIfNull(drD["TDCLPRE"]);

          txtPVAutres.EditValue = Utils.ZeroIfNull(drD["NDCLFOR"]);
          txtPVSST.EditValue = Utils.ZeroIfNull(drD["NDCLSST"]);

          txtCtTotalAutres.EditValue = Utils.ZeroIfNull(drD["NDCLCRFOR"]);
          txtCtTotalSST.EditValue = Utils.ZeroIfNull(drD["NDCLCRSST"]);

          txtQteMOJour.EditValue = Utils.ZeroIfNull(drD["NHEURESNB"]);
          txtQteMOSamedi.EditValue = Utils.ZeroIfNull(drD["NHEURESNBSAM"]);
          txtQteMONuitDimFerie.EditValue = Utils.ZeroIfNull(drD["NHEURESNBDIM"]);
          txtQteDepl.EditValue = Utils.ZeroIfNull(drD["NDEPNB"]);

          txtQteMOJourCR.EditValue = Utils.ZeroIfNull(drD["NHEURESNBCR"]);
          txtQteMOSamediCR.EditValue = Utils.ZeroIfNull(drD["NHEURESNBSAMCR"]);
          txtQteMONuitDimFerieCR.EditValue = Utils.ZeroIfNull(drD["NHEURESNBDIMCR"]);
          txtQteDeplCR.EditValue = Utils.ZeroIfNull(drD["NDEPNBCR"]);

          ChargesArticles();

          calcFournitures();

          //bMail = false;

          NSITNUM = Convert.ToInt32(drD["NSITNUM"]);

          lTmpStr = Utils.BlankIfNull(drD["CACTTYT"]);
          switch (lTmpStr)
          {
            case "I":
            case "G":
            case "S":
              txtMtDevisSTT.Text = Utils.BlankIfNull(drD["NACTVALDEVST"]);
              //cmdVoirDevisSTT.Visible = true;
              ////modif du 13/05/2024 par mc a la demande PC
              cmdVoirDevisSTT.Visible = ModuleMain.RechercheDroitMenu(cmdVoirDevisSTT.HelpContextID);

              break;

            default:
              txtMtDevisSTT.Text = "";
              cmdVoirDevisSTT.Visible = false;
              break;
          }

          lTmpStr = Utils.BlankIfNull(drD["CDCLVALIDITE"]);
          switch (lTmpStr)
          {
            case "S": // 1 semaine
              optValid0.Checked = true;
              break;

            case "Q": // 1 quinzaine
              optValid1.Checked = true;
              break;

            case "M": // 1 mois
              optValid2.Checked = true;
              break;

            case "R": // Régularisation
              optValid3.Checked = true;
              break;

            default:
              break;
          }

          //  'gestion RFA
          if (dValRFA < -1)
          {
            lblRFA.Visible = false;
            lblRFA.Text = "";
          }
          else
          {
            lblRFA.Visible = true;
            lblRFA.Text = Resources.msg_contrat_inclut + " " + (dValRFA * 100).ToString() + " % " + Resources.msg_remise_fin_annee + " " + Resources.msg_majorer_devis;
          }

          lTmpStr = Utils.BlankIfNull(drD["QUI"]);
          if (lTmpStr != "")
          {
            Frame7.Text = $"{Resources.msg_saisie_infos_par} {lTmpStr} {Resources.lib_le} {Utils.BlankIfNull(drD["DDCLDCRE"])})";
          }

          chkObs1.Checked = (drD["CASTREINTE"].ToString() == "P");

          //  En creation, on est en detail par default
          switch (drD["CTYPEMODELE"].ToString())
          {
            case "F":  // Affichage sans détail (forfait)
              optMod0.Checked = true;
              break;
            case "D": // Affichage avec détail (MO + Dépl + Fournitures)
              optMod1.Checked = true;
              break;
            case "A": // Affichage avec détail et liste de fournitures sans prix
              optMod2.Checked = true;
              break;
            case "P": // Affichage avec détail et liste de fournitures avec prix
              optMod3.Checked = true;
              break;
            case "M": // Affichage avec détail (MO/Depl + Fournitures)
              optMod4.Checked = true;
              break;
            case "H": // Affichage avec détail (MO/Depl + Four) et tableau avec prix
              optMod5.Checked = true;
              break;
          }

          //  Choix des charges ou immo
          OptChargImmo1.Checked = drD["CDCLIMMO"].ToString() == "O";
          //OptChargImmo0.Checked = !OptChargImmo1.Checked;

          txtPVUnitMOJour.EditValue = Utils.ZeroIfNull(drD["NCLICONTHOR"]);
          txtPVUnitMOSam.EditValue = Utils.ZeroIfNull(drD["NCLICONTHORSAM"]);
          txtPVUnitMONuitDimFerie.EditValue = Utils.ZeroIfNull(drD["NCLICONTHORNUIDIM"]);
          txtPVUnitMODepl.EditValue = Utils.ZeroIfNull(drD["NCLICONTDEP"]);


          chkPlanPrevAEtablir.Checked = (Convert.ToInt32(drD["BPLANPREVAETABLIR"]) == 1);
          chkTrav2Tech.Checked = (Convert.ToInt32(drD["BTRAVDEUXTECH"]) == 1);
          chkMatSpecSecuPrevu.Checked = (Convert.ToInt32(drD["BMATSPECSECUPREVU"]) == 1);

          cboReussite.SetItemData(drD["NDCLREUSSITEPOURC"].ToString());

          txtInfoInterne.Text = drD["VINFOINTERNE"].ToString();

          if (miNumDevisCL == 0)
          {
            // Création
            mdecTva = UtilsDevis.RechercheTauxDeTVA(miNumAction);
            //bMail = true;
          }
          else
          {
            // Modification
            mdecTva = Convert.ToDouble(drD["NDCLTTVA"]);

            txtNumero.Text = drD["NDCLNUM"].ToString();
          }

          cboTVA.Text = mdecTva.ToString("#.00");

          mStrStatutValidationDevis = drD["CDCLVALID"].ToString();

          cmdVisualiser.Enabled = false;

          if (mTypeDevis == "G")
          {
            switch (mStrStatutValidationDevis)
            {
              case "P":
                uCtrlValidation1.Visible = false;
                cmdVisualiser.Enabled = true;
                break;

              case "E":
              case "V":
              case "I":
                afficheDelegation();
                
                uCtrlValidation1.Visible = true;
                //cmdVisualiser.Enabled = (uCtrlValidation1.StatutValidation == "I");

                setReadOnly();
                break;

              default:
                break;
            }

            // Devis validé
            cmdEnreg.Enabled = false;
          }
          else
          {
            // Brouillon
            cmdEnreg.Enabled = true;

            uCtrlValidation1.Visible = false;
          }

          txtMOJour_TextChanged(null, null);
          txtMOSam_TextChanged(null, null);
          txtMONuitDimFerie_TextChanged(null, null);
          txtDepl_TextChanged(null, null);

          txtQteMOJourCR_TextChanged(null, null);
          txtQteMOSamediCR_TextChanged(null, null);
          txtQteMONuitDimFerieCR_TextChanged(null, null);
          txtQteDeplCR_TextChanged(null, null);

          if ((uCtrlValidation1.StatutValidation != "I") && (mstrStatutAlerte == "OUI"))
          {
            cmdValider.Enabled = false;
          }
        }
      }
      catch (Exception ex)
      {
        MZUtils.displayError(MethodBase.GetCurrentMethod().Name, ex);
      }
    }

    // Permet de mettre les champs de la fenêtre en lecture seule
    private void setReadOnly()
    {
      if (uCtrlValidation1.StatutValidation == "I")
      {
        //cmdValider.Enabled = false;
        recurseBrowseInControl(this, this);

        // Traitement spécifique pour la grille
        apiTGridFour.CellValueChanged -= apiTGridFour_CellValueChanged;

        apiTGridFour.dgv.Columns[COL_QUANTITE].OptionsColumn.AllowEdit = false;
        apiTGridFour.dgv.Columns[COL_NFOUCOEFF].OptionsColumn.AllowEdit = false;

        cboReussite.Enabled = true;
        lblPourcReussite.Enabled = true;
      }

      cmdVisualiser.Enabled = (uCtrlValidation1.StatutValidation == "I");
    }

    // pPrimaryControl est la Form parent depuis lequel l'appel se fait (ici donc this, la fenêtre)
    private void recurseBrowseInControl(Form pPrimaryControl, Control pControl)
    {
      foreach (Control lCtrl in pControl.Controls)
      {
        // La grille est rendue readonly par un autre moyen ... yala !!
        if (lCtrl.Name == "apiTGridFour")
        {
          continue;
        }

        if (lCtrl is GroupBox)
        {
          recurseBrowseInControl(pPrimaryControl, lCtrl);
        }
        else
        {
          if (lCtrl is Button)
          {
            if ((lCtrl != pPrimaryControl.CancelButton) && (lCtrl.Name != "cmdVisualiser"))
            {
              lCtrl.Enabled = false;
            }
          } else
          {
            if (lCtrl is BaseEdit)
            {
              (lCtrl as BaseEdit).Properties.ReadOnly = true;
            } else
            {
              PropertyInfo _propertyInfo = lCtrl.GetType().GetProperty("ReadOnly", BindingFlags.FlattenHierarchy | BindingFlags.Instance | BindingFlags.NonPublic | BindingFlags.Public);
              if (_propertyInfo != null)
              {
                _propertyInfo.SetValue(lCtrl, true);
              } else
              {
                _propertyInfo = lCtrl.GetType().GetProperty("Enabled", BindingFlags.FlattenHierarchy | BindingFlags.Instance | BindingFlags.NonPublic | BindingFlags.Public);
                if (_propertyInfo != null)
                {
                  _propertyInfo.SetValue(lCtrl, false);
                }
              }
            }
          }
        }
      }
    }

    private void EnregistrerDevisCL(bool bIsBrouillon)
    {
      try
      {
        //  GREG 13/07/2010 si on est en modif, on verifie l'état de l'action
        // on propose à l'utilisateur d'enregistrer ou non les modifications si O,P,E,W ou F
        if (miNumDevisCL != 0)
        {
          if (ModuleData.ExecuteScalarObject($"SELECT NACTNUM FROM TACT WHERE NACTNUM = {miNumAction} AND (CETACOD in ('O','P','E','W') OR CACTSTA = 'F')") != null)
          {
            if (MessageBox.Show(Resources.msg_devis_deja_valide, Program.AppTitle, MessageBoxButtons.YesNo, MessageBoxIcon.Question,
                                MessageBoxDefaultButton.Button2) == DialogResult.No)
            {
              InitialiserFeuille();
              return;
            }
          }

          // message si modification d'un devis déjà validé ou en cours de validation (E,V,I)
          if ((mStrStatutValidationDevis != "P") && (mTypeDevis != "B"))
          {
            if (MessageBox.Show(Resources.msg_attention_valid_hier_suppr, Program.AppTitle, MessageBoxButtons.YesNo, MessageBoxIcon.Question,
                  MessageBoxDefaultButton.Button2) != DialogResult.Yes)
              return;
          }
        }

        // Emalec -> il faut choisir un tech
        if (optqui1.Checked && cbotech.GetText() == "")
        {
          MessageBox.Show(Resources.msg_choisir_tech_devis, Program.AppTitle, MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
          return;
        }

        if (cboUrg.Text == "")
        {
          MessageBox.Show(Resources.msg_definir_urgence, Program.AppTitle, MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
          return;
        }

        if (cboTheme.Text == "")
        {
          MessageBox.Show(Resources.msg_definir_theme, Program.AppTitle, MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
          return;
        }

        if (txtDap.Text == "")
        {
          MessageBox.Show(Resources.msg_definir_delai_prep, Program.AppTitle, MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
          return;
        }

        if (txtDre.Text == "")
        {
          MessageBox.Show(Resources.msg_definir_delai_real, Program.AppTitle, MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
          return;
        }

        if (cboReussite.SelectedIndex == 0)
        {
          MessageBox.Show(Resources.msg_definir_pourc_reussite, Program.AppTitle, MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
          return;
        }

        // uniquement traitement lors de la creation du devis. L'utilisateur choisi
        cEnvMail = "N"; // valeur par defaut

        // pour les clients avec envoi de mail le soir
        //  TB SAMSIC CITY SPEC
        //if (txtNomCli.Text == "HABITAT") && miNumDevisCL == 0 && MozartParams.NomGroupe == "EMALEC")
        //{
        //  if (MessageBox.Show(Resources.msg_realiser_devis + txtNomCli.Text + ". " + "\r\n"
        //                    + Resources.msg_rappel_envoi_auto_19h + "\r\n"
        //                    + Resources.msg_dde_validation_envoi, Program.AppTitle, MessageBoxButtons.YesNo, MessageBoxIcon.Question,
        //                      MessageBoxDefaultButton.Button2) == DialogResult.Yes)
        //    cEnvMail = "N";
        //  else
        //    cEnvMail = "B";   // ne pas envoyer de mail car blocage de l'utilisateur
        //}

        int iNumDevisAvant = miNumDevisCL;

        double lQteMONuitDimFerie = Utils.ZeroIfNull(txtQteMONuitDimFerie.EditValue);
        double lPVUnitMONuitDimFerie = Utils.ZeroIfNull(txtPVUnitMONuitDimFerie.EditValue);

        using (SqlCommand cmd = new SqlCommand("api_sp_CreationDevisCL2", MozartDatabase.cnxMozart))
        {
          cmd.CommandType = CommandType.StoredProcedure;
          SqlCommandBuilder.DeriveParameters(cmd);

          cmd.Parameters["@iDevis"].Value = miNumDevisCL;
          cmd.Parameters["@cDevisType"].Value = bIsBrouillon ? 'B' : 'G';
          cmd.Parameters["@iAction"].Value = miNumAction;
          cmd.Parameters["@tObj"].Value = txtObjet.Text;
          cmd.Parameters["@tPre"].Value = txtPrest.Text;
          cmd.Parameters["@vPj"].Value = txtPJ.Text;
          cmd.Parameters["@nFor"].Value = Utils.ZeroIfNull(txtPVAutres.EditValue);
          cmd.Parameters["@nFou"].Value = Utils.ZeroIfNull(txtPrixVenteFour.Text);
          cmd.Parameters["@nMoe"].Value = Utils.ZeroIfNull(txtPrixVenteMOJour.Text);
          cmd.Parameters["@nNbHeures"].Value = Utils.ZeroIfNull(txtQteMOJour.EditValue);
          cmd.Parameters["@nTxHeures"].Value = Utils.ZeroIfNull(txtPVUnitMOJour.EditValue);
          cmd.Parameters["@nMoeSam"].Value = Utils.ZeroIfNull(txtPVUnitMOSam.EditValue);
          cmd.Parameters["@nNbHeuresSam"].Value = Utils.ZeroIfNull(txtQteMOSamedi.EditValue);
          cmd.Parameters["@nTxHeuresSam"].Value = Utils.ZeroIfNull(txtPVUnitMOSam.EditValue);
          cmd.Parameters["@nMoeDim"].Value = lPVUnitMONuitDimFerie;
          cmd.Parameters["@nNbHeuresDim"].Value = lQteMONuitDimFerie;
          cmd.Parameters["@nTxHeuresDim"].Value = lPVUnitMONuitDimFerie;
          cmd.Parameters["@nDep"].Value = Utils.ZeroIfNull(txtPrixVenteMODepl.Text);
          cmd.Parameters["@nNbDep"].Value = Utils.ZeroIfNull(txtQteDepl.EditValue);
          cmd.Parameters["@nTxDep"].Value = Utils.ZeroIfNull(txtPVUnitMODepl.Text);
          cmd.Parameters["@nHt"].Value = Utils.ZeroIfNull(txtHT.Text);
          cmd.Parameters["@nTva"].Value = Utils.ZeroIfNull(txtTVA.Text);
          cmd.Parameters["@nDap"].Value = txtDap.Text == "" ? DBNull.Value : (object)txtDap.Text;
          cmd.Parameters["@nDre"].Value = txtDre.Text == "" ? DBNull.Value : (object)txtDre.Text;
          // Destinataire site (S) ou raison sociale (R) ou contact(C)
          int aux = cboDemandeur.SelectedIndex;
          cmd.Parameters["@envSite"].Value = (aux == 0 ? "S" : aux == 1 ? "R" : aux > 1 ? "C" : "");
          cmd.Parameters["@iDest"].Value = cboDemandeur.GetItemData();
          cmd.Parameters["@bPlanPrevAEtablir"].Value = chkPlanPrevAEtablir.Checked ? 1 : 0;
          cmd.Parameters["@bTravDeuxTech"].Value = chkTrav2Tech.Checked ? 1 : 0;
          cmd.Parameters["@bMatSpecSecuPrevu"].Value = chkMatSpecSecuPrevu.Checked ? 1 : 0;
          cmd.Parameters["@iTech"].Value = optqui1.Checked ? cbotech.GetItemData() : 0;
          cmd.Parameters["@vobsTrav"].Value = chkObs1.Checked ? chkObs1.Tag : "";
          cmd.Parameters["@curgence"].Value = cboUrg.GetItemData();
          cmd.Parameters["@vtheme"].Value = cboTheme.SelectedValue;
          //// F:forfait-D:Detail-A:Article sans prix-P:Article avec prix
          cmd.Parameters["@cModele"].Value = optMod0.Checked ? "F" : optMod1.Checked ? "D" : optMod2.Checked ? "A" : optMod3.Checked ? "P" : optMod4.Checked ? "M" : optMod5.Checked ? "H" : "";
          cmd.Parameters["@cEnvMail"].Value = cEnvMail;
          cmd.Parameters["@ntheme"].Value = cboTheme.GetItemData();
          cmd.Parameters["@cDclImmo"].Value = OptChargImmo0.Checked ? "N" : OptChargImmo1.Checked ? "O" : "";
          cmd.Parameters["@nTauxTva"].Value = getTauxTVA();
          cmd.Parameters["@cValidDevis"].Value = optValid0.Checked ? "S" : optValid1.Checked ? "Q" : optValid2.Checked ? "M" : optValid3.Checked ? "R" : "";
          cmd.Parameters["@nPourcentReussite"].Value = (cboReussite.SelectedValue.ToString() == "") ? DBNull.Value : cboReussite.SelectedValue;
          cmd.Parameters["@nCRFor"].Value = Utils.ZeroIfNull(txtCtTotalAutres.EditValue);
          cmd.Parameters["@nSST"].Value = Utils.ZeroIfNull(txtPVSST.EditValue);
          cmd.Parameters["@nCRSST"].Value = Utils.ZeroIfNull(txtCtTotalSST.EditValue);
          cmd.Parameters["@tInfoInterne"].Value = txtInfoInterne.Text;
          cmd.Parameters["@nNbHeuresCR"].Value = Utils.ZeroIfNull(txtQteMOJourCR.EditValue);
          cmd.Parameters["@nNbHeuresSamCR"].Value = Utils.ZeroIfNull(txtQteMOSamediCR.EditValue);
          cmd.Parameters["@nNbHeuresDimCR"].Value = Utils.ZeroIfNull(txtQteMONuitDimFerieCR.EditValue);
          cmd.Parameters["@nNbDepCR"].Value = Utils.ZeroIfNull(txtQteDeplCR.EditValue);

          cmd.Parameters["@iNumDevisCL"].Value = 0;

          cmd.ExecuteNonQuery();
          miNumDevisCL = Convert.ToInt32(cmd.Parameters[0].Value);

          if (bIsBrouillon)
          {
            string lActNuit = ((lQteMONuitDimFerie != 0) && (lPVUnitMONuitDimFerie != 0)) ? "O" : "N";
            MozartDatabase.ExecuteNonQuery($"UPDATE TACT SET CACTNUIT = '{lActNuit}' WHERE NACTNUM={miNumAction} AND CACTNUIT<>'P'");
          }

          CreationLignesArticlesDevis();
        }

        traitementDelegation();

        //  on réinitialise le devis
        InitialiserFeuille();

        //  Si on était en création mail a envoyer
        //if (iNumDevisAvant == 0 && miNumDevisCL != iNumDevisAvant)
        //  bMail = true;
      }
      catch (Exception ex)
      {
        MZUtils.displayError(MethodBase.GetCurrentMethod().Name, ex);
      }
    }

    private void traitementDelegation()
    {
      uCtrlValidation1.traitementDelegation(miNumDevisCL, mStrStatutValidationDevis, double.Parse(txtHT.Text, NumberStyles.Currency));
    }

    public void afficheDelegation()
    {
      uCtrlValidation1.fill(miNumDevisCL, mStrStatutValidationDevis, double.Parse(txtHT.Text, NumberStyles.Currency));
    }

    private void CreationLignesArticlesDevis()
    {
      try
      {
        //  delete des lignes d'articles pour ce devis
        MozartDatabase.ExecuteNonQuery($"DELETE from TLDCL where NDCLNUM = {miNumDevisCL}");

        //parcours du recordset et création des lignes dans TDCL
        foreach (DataRow row in mdtArticles.Rows)
        {
          using (SqlCommand cmd = new SqlCommand("api_sp_CreationLigneDevis", MozartDatabase.cnxMozart))
          {
            cmd.CommandType = CommandType.StoredProcedure;
            SqlCommandBuilder.DeriveParameters(cmd);

            cmd.Parameters["@iDclNum"].Value = miNumDevisCL;
            cmd.Parameters["@iFouNum"].Value = Utils.ZeroIfNull(row["NumArticle"]);
            cmd.Parameters["@iFourSite"].Value = Utils.ZeroIfNull(row["NumSiteFour"]);
            cmd.Parameters["@nQte"].Value = Utils.ZeroIfNull(row[COL_QUANTITE]);
            cmd.Parameters["@nPU"].Value = Utils.ZeroIfNull(row["Prix U"]);
            cmd.Parameters["@nPC"].Value = Utils.ZeroIfNull(row["Prix Client"]);

            // si prix client, alors on ne peut pas modifier le coeff de fourniture donc on le passe à zero
            if (Utils.ZeroIfNull(row["Prix Client"]) > 0)
            {
              cmd.Parameters["@nPT"].Value = Utils.ZeroIfNull(row["Prix Client"]) * Utils.ZeroIfNull(row[COL_QUANTITE]);
              cmd.Parameters["@nCoeff"].Value = 0;
            }
            else
            {
              cmd.Parameters["@nPT"].Value = Utils.ZeroIfNull(row["Prix U"]) * Utils.ZeroIfNull(row[COL_QUANTITE]);
              cmd.Parameters["@nCoeff"].Value = Utils.ZeroIfNull(row[COL_NFOUCOEFF]);
            }
            // H&M : Colonne en plus
            if (miNumDevisCL == 494 && MozartParams.NomGroupe == "EMALEC")
              cmd.Parameters["@vCode"].Value = Utils.BlankIfNull(row["VCODECPT"]);

            cmd.ExecuteNonQuery();
          }
        }
      }
      catch (Exception ex)
      {
        MZUtils.displayError(MethodBase.GetCurrentMethod().Name, ex);
      }
    }

    private void cmdArticlesDevis_Click(object sender, EventArgs e)
    {
      if (miNumDevisCL == 0)
      {
        MessageBox.Show(Resources.msg_impossible_enregistrer_devis, Program.AppTitle, MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
        return;
      }

      try
      {
        Cursor.Current = Cursors.WaitCursor;

        new frmRechercheArticles
        {
          miNumDi = miNumDI,
          miNumAction = miNumAction,
          miNumClient = NCLINUM,
          mdtArticles = mdtArticles,
          msNomClient = txtNomCli.Text
        }.ShowDialog();

        calcFournitures();
        EnregistrerDevisCL(mTypeDevis == "B");
      }
      catch (Exception ex)
      {
        MZUtils.displayError(MethodBase.GetCurrentMethod().Name, ex);
      }
      finally
      {
        Cursor.Current = Cursors.Default;
      }
    }

    private void txtNbr_KeyPress(object sender, KeyPressEventArgs e)
    {
      KeyValidator.KeyPress_SaisieNombre(e);
    }

    private bool VerifIfContratActif()
    {
      // Recherche des info du devis (que le devis existe ou pas)
      return MozartDatabase.ExecuteScalarInt($"exec api_sp_VerifContratExistAction {miNumAction}") != 0;
    }

    private void cmdEnreg_Click(object sender, EventArgs e)
    {
      EnregistrerDevisCL(true);
    }

    private void apiTGridFour_RowCellStyle(object sender, DevExpress.XtraGrid.Views.Grid.RowCellStyleEventArgs e)
    {
      if (e.RowHandle < 0) return;

      if (e.Column.Name == COL_QUANTITE)
        e.Appearance.BackColor = Color.Orange;

      if (e.Column.Name == COL_NFOUCOEFF && Convert.ToDouble(e.CellValue) > 0)
      {
        e.Appearance.Font = new Font(e.Appearance.Font, FontStyle.Bold);
        e.Appearance.BackColor = Color.FromArgb(255, 160, 0);
      }

      if (e.Column.Name == "Date prix" && e.CellValue.ToString() != "" && Convert.ToDateTime(e.CellValue) < DateTime.Now.AddYears(-2))
      {
        e.Appearance.Font = new Font(e.Appearance.Font, FontStyle.Bold);
        e.Appearance.ForeColor = Color.Red;
      }
    }

    private void apiTGridFour_CellValueChanged(object sender, DevExpress.XtraGrid.Views.Base.CellValueChangedEventArgs e)
    {
      //  mise a jour du total
      //  pas de changement du coeff pour les articles avec prix client
      DataRow row = apiTGridFour.GetFocusedDataRow();
      if (row == null) return;

      switch (e.Column.FieldName)
      {
        case COL_NFOUCOEFF:
          if (Convert.ToDouble(row["Prix Client"]) > 0)
          {
            MessageBox.Show(Resources.msg_impossible_saisir_coeff_car_prix_client, Program.AppTitle, MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
            row[COL_NFOUCOEFF] = 0;
          }
          else
          {
            if (Convert.ToDouble(row[COL_NFOUCOEFF]) < 1)
            {
              MessageBox.Show(Resources.msg_coef_sup_1, Program.AppTitle, MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
              row[COL_NFOUCOEFF] = 4;
            }
            row["Prix T"] = Convert.ToDouble(row["Prix U"]) * Convert.ToDouble(row[COL_NFOUCOEFF]) * Convert.ToDouble(row[COL_QUANTITE]);
          }
          break;

        case COL_QUANTITE:
          if (Convert.ToDouble(row["Prix Client"]) > 0)
            row["Prix T"] = Convert.ToDouble(row["Prix Client"]) * Convert.ToDouble(row[COL_QUANTITE]);
          else
            row["Prix T"] = Convert.ToDouble(row["Prix U"]) * Convert.ToDouble(row[COL_NFOUCOEFF]) * Convert.ToDouble(row[COL_QUANTITE]);
          break;
      }

      calcFournitures();
      EnregistrerDevisCL(mTypeDevis == "B");
    }

    private void calcCtRevientTotal(TextEdit pTxtQte, apiTextBox pTxtCoutRevientU, apiTextBox pTxtCoutRevientTot)
    {
      double lQte = 0.0;
      double lCout = 0.0;

      try { lQte = Utils.ZeroIfBlank(pTxtQte.EditValue); } catch (Exception) { };
      try { lCout = Utils.ZeroIfBlank(pTxtCoutRevientU.Text); } catch (Exception) { };

      pTxtCoutRevientTot.Text = (lQte * lCout).ToString();

      calcTotaux();
    }

    private void calcPrixVenteTotal(TextEdit pTxtQte, TextEdit pTxtPrxVentU, apiTextBox pTxtPrxVent)
    {
      double lQte = 0.0;
      double lPrixDeVente = 0.0;

      try { lQte = Utils.ZeroIfBlank(pTxtQte.EditValue); } catch (Exception) { };
      try { lPrixDeVente = Utils.ZeroIfBlank(pTxtPrxVentU.Text); } catch (Exception) { };

      pTxtPrxVent.Text = (lQte * lPrixDeVente).ToString();

      calcTotaux();
    }

    private void calcTotaux()
    {
      double lPV;
      double lCR;

      // Total Cout de revient total
      lCR = 0;
      try { lCR += Utils.ZeroIfBlank(txtCtRevTotMOJour.Text); } catch (Exception) { };
      try { lCR += Utils.ZeroIfBlank(txtCtRevTotMOSam.Text); } catch (Exception) { };
      try { lCR += Utils.ZeroIfBlank(txtCtRevTotMONuitDimFerie.Text); } catch (Exception) { };
      try { lCR += Utils.ZeroIfBlank(txtCtRevTotMODepl.Text); } catch (Exception) { };
      try { lCR += Utils.ZeroIfBlank(txtCtRevTotFour.Text); } catch (Exception) { };
      try { lCR += Utils.ZeroIfBlank(txtCtTotalAutres.Text); } catch (Exception) { };
      try { lCR += Utils.ZeroIfBlank(txtCtTotalSST.Text); } catch (Exception) { };
      txtTotRev.Text = lCR.ToString("# ##0.00");

      // Total Prix de vente
      lPV = 0;
      try { lPV += Utils.ZeroIfBlank(txtPrixVenteMOJour.Text); } catch (Exception) { };
      try { lPV += Utils.ZeroIfBlank(txtPrixVenteMOSam.Text); } catch (Exception) { };
      try { lPV += Utils.ZeroIfBlank(txtPrixVenteMONuitDimFerie.Text); } catch (Exception) { };
      try { lPV += Utils.ZeroIfBlank(txtPrixVenteMODepl.Text); } catch (Exception) { };
      //try { lPV += Utils.ZeroIfBlank(txtPrixVenteFour.EditValue); } catch (Exception) { };
      lPV += Utils.ZeroIfNull(txtPrixVenteFour.Text);
      try { lPV += Utils.ZeroIfBlank(txtPVAutres.Text); } catch (Exception) { };
      try { lPV += Utils.ZeroIfBlank(txtPVSST.Text); } catch (Exception) { };
      txtTotPrixVente.Text = lPV.ToString("# ##0.00");
      txtHT.EditValue = lPV;

      calcTVA();

      // Calcul de la marge analytique estimée
      double lMarge;
      double lTxFS = 0.1;
      try
      {
        lMarge = 100.0 * (lPV * (1 - mTauxFraisGeneraux - lTxFS - dValRFA) - lCR) / lPV;
        if (double.IsNaN(lMarge)) lMarge = 0;
      }
      catch (Exception) { lMarge = 0; };
      txtMarge.Text = $"{Resources.txt_marge_ana_est} {String.Format("{0:N}", lMarge)} %";
      // Couleur
      txtMarge.BackColor = (lMarge < 20) ? Color.Red : Color.LimeGreen;
    }

    private void txtCtTotalAutres_TextChanged(object sender, EventArgs e)
    {
      calcTotaux();
    }

    private void calcFournitures()
    {
      double lPrixEmalec;
      double lQte;
      double lTotal;
      double lTotalCtRevient = 0;
      double lTotalPrixVente = 0;

      foreach (DataRow lCurRow in mdtArticles.Rows)
      {
        try { lPrixEmalec = Utils.ZeroIfBlank(lCurRow["Prix U"]); } catch (Exception) { lPrixEmalec = 0; };
        try { lQte = Utils.ZeroIfBlank(lCurRow[COL_QUANTITE]); } catch (Exception) { lQte = 0; };
        try { lTotal = Utils.ZeroIfBlank(lCurRow["Prix T"]); } catch (Exception) { lTotal = 0; };

        lTotalCtRevient += lPrixEmalec * lQte;
        lTotalPrixVente += lTotal;
      }

      txtCtRevTotFour.EditValue = lTotalCtRevient;
      txtPrixVenteFour.EditValue = lTotalPrixVente;

      calcTotaux();
    }

    private double getTauxTVA()
    {
      double lTxTVA;

      try { lTxTVA = Utils.ZeroIfBlank(cboTVA.Text.Replace(" ", "").Replace(".", ",")); } catch (Exception) { lTxTVA = 0; };

      return lTxTVA;
    }

    private void calcTVA()
    {
      double lTotHT;
      double lTVA;

      //try { lTotHT = Utils.ZeroIfBlank(txtHT2.EditValue); } catch (Exception) { lTotHT = 0; };
      lTotHT = Utils.ZeroIfNull(txtHT.EditValue);

      lTVA = getTauxTVA() * lTotHT / 100;

      txtTVA.EditValue = lTVA;
      txtTTC.Text = (lTotHT + lTVA).ToString("# ##0.00");
    }

    private void cboTVA_SelectedIndexChanged(object sender, EventArgs e)
    {
      calcTVA();
    }

    private void cmdVoirDevisSTT_Click(object sender, EventArgs e)
    {
      WebBrowser lPdf = new WebBrowser();

      string strRepFic = Utils.RechercheParam("REP_PHOTOS_ACT");
      // recherche des devis STT en doc interne
      using (SqlDataReader reader = MozartDatabase.ExecuteReader($"select * from TIMAC WHERE VTYPEDEST='I' AND NTYPEDOC=6 AND NACTNUM={MozartParams.NumAction}"))
      {
        if (reader.Read())
        {
          lPdf.Navigate($"{strRepFic}{Utils.BlankIfNull(reader["VFICHIER"])}");
          using (Process p = new Process())
          {
            p.StartInfo.FileName = $"{strRepFic}{Utils.BlankIfNull(reader["VFICHIER"])}";
            p.StartInfo.UseShellExecute = true;
            p.Start();
          }
        }
        else
          lPdf.Navigate("about:blank");
      }
    }

    private void chk_CheckedChanged(object sender, EventArgs e)
    {
      CheckBox lCheckBox = (CheckBox)sender;

      if (lCheckBox.Checked && !txtPrest.Text.Contains(lCheckBox.Text))
      {
        txtPrest.Text = lCheckBox.Text + Environment.NewLine + txtPrest.Text;
      }
    }

    private void cmdAnObs_Click(object sender, EventArgs e)
    {
      TxtObs.Text = "";
      framObs.Visible = false;
    }

    private void cmdValObs_Click(object sender, EventArgs e)
    {
      string msg = TxtObs.Text;
      if (msg == "") return;

      // position en début de text quand focus et avec saut de ligne
      string temp = $"{MozartParams.strUID} {Resources.lib_le} {DateTime.Now:dd/MM/yyyy HH:mm:ss} : {msg}";

      uCtrlValidation1.addRemarque(miNumDevisCL, temp);

      cmdAnObs_Click(sender, e);
    }

    private void txtMOJour_TextChanged(object sender, EventArgs e)
    {
      calcPrixVenteTotal(txtQteMOJour, txtPVUnitMOJour, txtPrixVenteMOJour);
    }

    private void txtMOSam_TextChanged(object sender, EventArgs e)
    {
      calcPrixVenteTotal(txtQteMOSamedi, txtPVUnitMOSam, txtPrixVenteMOSam);
    }

    private void txtMONuitDimFerie_TextChanged(object sender, EventArgs e)
    {
      calcPrixVenteTotal(txtQteMONuitDimFerie, txtPVUnitMONuitDimFerie, txtPrixVenteMONuitDimFerie);
    }

    private void txtDepl_TextChanged(object sender, EventArgs e)
    {
      calcPrixVenteTotal(txtQteDepl, txtPVUnitMODepl, txtPrixVenteMODepl);
    }

    private void txtQteMOJourCR_TextChanged(object sender, EventArgs e)
    {
      calcCtRevientTotal(txtQteMOJourCR, txtCtRevUnitMOJour, txtCtRevTotMOJour);
    }

    private void txtQteMOSamediCR_TextChanged(object sender, EventArgs e)
    {
      calcCtRevientTotal(txtQteMOSamediCR, txtCtRevUnitMOJour, txtCtRevTotMOSam);
    }

    private void txtQteMONuitDimFerieCR_TextChanged(object sender, EventArgs e)
    {
      calcCtRevientTotal(txtQteMONuitDimFerieCR, txtCtRevUnitMONuitDimFerie, txtCtRevTotMONuitDimFerie);
    }

    private void txtQteDeplCR_TextChanged(object sender, EventArgs e)
    {
      calcCtRevientTotal(txtQteDeplCR, txtCtRevUnitMODepl, txtCtRevTotMODepl);
    }

    private void cboReussite_SelectionChangeCommitted(object sender, EventArgs e)
    {
      if ((miNumDevisCL != 0) && (!cboReussite.SelectedValue.Equals("")))
      {
        MozartDatabase.ExecuteNonQuery($"UPDATE TDCL SET NDCLREUSSITEPOURC = {cboReussite.SelectedValue} WHERE NDCLNUM = {miNumDevisCL}");
      }
    }
  }
}
