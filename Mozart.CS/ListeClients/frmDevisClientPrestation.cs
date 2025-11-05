using DevExpress.XtraEditors;
using DevExpress.XtraGrid.Views.Grid;
using MozartCS.ListeClients;
using MozartCS.Properties;
using MozartLib;
using MozartNet;
using ReportEmalec.Net;
using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Reflection;
using System.Windows.Forms;
using MZUtils = MozartControls.Utils;

namespace MozartCS
{
  public partial class frmDevisClientPrestation : Form
  {
    private const string COL_COEF = "COEF";

    public int miNumAction;
    public DataTable mdtPrestSaisie = new DataTable();
    public string mstrStatutAlerte = "";

    private int NSITNUM = 0;
    private int miNumDevisCL;
    private bool bModifPossible = true;

    private double mdecTva;
    private double dRetGar;

    List<RadioButton> lstOptImp = new List<RadioButton>();
    private int iTypeDevisPrest;

    private string mStrStatutValidationDevis = "";

    public frmDevisClientPrestation() { InitializeComponent(); }

    /* TODO Tooltip --------------------------------------------------------------------------------------- */
    private void frmDevisClientPrestation_Load(object sender, System.EventArgs e)
    {
      try
      {
        Cursor.Current = Cursors.WaitCursor;
        ModuleMain.Initboutons(this);

        lstOptImp.Add(optImp0); lstOptImp.Add(optImp1); lstOptImp.Add(optImp2); lstOptImp.Add(optImp3);

        optqui1.Text = optqui1.Text.Replace("$ste", MozartParams.NomSociete);

        string lTmpStr = "SELECT '' AS VALPOURC, '' AS TAUX UNION SELECT '0', '0' AS TAUX UNION SELECT '25', '25' UNION SELECT '50', '50' UNION SELECT '75', '75'";
        ModuleData.RemplirCombo(CboTauxReussite, lTmpStr, true); // combo
        CboTauxReussite.ValueMember = "VALPOURC";
        CboTauxReussite.DisplayMember = "TAUX";

        ModuleData.RemplirCombo(cboTVA, $"SELECT ID, TVA FROM TREF_TVA where VSOCIETE = '{MozartParams.NomSociete}' ORDER BY TVA", bSupprSpace: true); // combo
        cboTVA.ValueMember = "ID";
        cboTVA.DisplayMember = "TVA";

        string sSql = "select NPERNUM, VPERNOM + ' ' + VPERPRE [VPERNOM] from TPER where CPERACTIF = 'O' AND VSOCIETE = App_Name() ORDER BY VPERNOM, VPERPRE";
        cbotech.Init(MozartDatabase.cnxMozart, sSql, "NPERNUM", "VPERNOM", new List<string>() { Resources.col_Num, Resources.col_Nom }, 150, 550, bHideFirstColumn: true);  // apiCombo

        ModuleData.RemplirCombo(cboUrg, $"select CURGCOD, VURGLIB from api_v_comboUrg where CURGCOD <> 4 AND langue = '{MozartParams.Langue}'", true); // combo
        cboUrg.ValueMember = "CURGCOD";
        cboUrg.DisplayMember = "VURGLIB";
        DataTable dtUrg = cboUrg.DataSource as DataTable;
        DataRow r = dtUrg.NewRow();
        r[0] = "0"; r[1] = "";
        dtUrg.Rows.InsertAt(r, 0);

        InitgridPrest();

        this.uCtrlValidation1.DevisStatusUpdated += new EventHandler(MyEventHandlerFunction_DevisStatusUpdated);
        this.uCtrlValidation1.DevisRemarqueEnter += new EventHandler(MyEventHandlerFunction_DevisRemarqueEnter);
        this.uCtrlValidation1.DevisEnablePrintAndVisu += new EventHandler(MyEventHandlerFunction_DevisEnablePrintAndVisu);

        InitialiserFeuille();
      }
      catch (Exception ex)
      {
        MZUtils.displayError(MethodBase.GetCurrentMethod().Name, ex);
      }
      finally { Cursor.Current = Cursors.Default; }
    }

    // Evènement déclenché par UCtrlValidation pour activer le bouton Visualier/Imprimer
    public void MyEventHandlerFunction_DevisStatusUpdated(object sender, EventArgs e)
    {
      setReadOnly();

      cmdVisualiser.Enabled = (((DevisStatusEventArgs)e).StatutValidation == "I");
      cmdImprimer.Enabled = cmdVisualiser.Enabled;
    }

    // Evènement déclenché par UCtrlValidation pour la saisie de remarques
    public void MyEventHandlerFunction_DevisRemarqueEnter(object sender, EventArgs e)
    {
      framObs.Visible = true;
      // Marche pas ! on verra plus tard ... ou pas !!! TxtObs.Focus();
    }
    public void MyEventHandlerFunction_DevisEnablePrintAndVisu(object sender, EventArgs e)
    {
      cmdVisualiser.Enabled = true;
      cmdImprimer.Enabled = true;
      // Pas de visu/impression si pas de lignes prestation
      if (apiTGridPrestSaisie.dgv.RowCount == 0)
      {
        cmdVisualiser.Enabled = false;
        cmdImprimer.Enabled = false;
      }

      uCtrlValidation1.Visible = false;
    }

    private void cmdValider_Click(object sender, EventArgs e)
    {
      if (!bModifPossible)
      {
        MessageBox.Show(Resources.msg_impossible_avancement_existe, Program.AppTitle, MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
        return;
      }

      //  test si prestation de nuit alors affichage pop up
      bool bPrestNuitExists = false;
      foreach (DataRow row in mdtPrestSaisie.Rows)
      {
        if (Utils.ZeroIfNull(row["BLDCLPREST_NUIT"]) == 1)
        {
          bPrestNuitExists = true;
          break;
        }
      }

      if (bPrestNuitExists)
        MessageBox.Show(Resources.msg_devis_avec_prestations_nuit, Program.AppTitle, MessageBoxButtons.OK, MessageBoxIcon.Exclamation);

      ValiditeDateLastModifPrestation();

      EnregistrerDevisCL();
    }

    private void Command1_Click(object sender, EventArgs e)
    {
      // réservé au UID == 30  -> Galotti
    }

    private void cmdVisualiser_Click(object sender, EventArgs e)
    {
      viewReport(false, false);
    }

    private void cmdImprimer_Click(object sender, EventArgs e)
    {
      if (miNumDevisCL == 0)
      {
        MessageBox.Show(Resources.msg_Impression_impossible_enregistrer_devis, Program.AppTitle, MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
        return;
      }

      viewReport(true, false);
    }

    private void viewReport(bool bImprimer, bool bIsBrouillon)
    {
      try
      {
        string sDest;
        string sTypeReport;

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

        if (optImp0.Checked)
          sTypeReport = "TDevisClientPrestation";
        else if (optImp1.Checked)
          sTypeReport = "TDevisClientPrestationSansDetails";
        else if (optImp3.Checked)   // 3: forfaitaire avec totaux
          sTypeReport = "TDEVISCLIENTPRESTATIONFORFAITAIRETOTAUX";
        else  // 2: forfaitaire
          sTypeReport = "TDevisClientPrestationForfaitaire";

        if (bIsBrouillon)
        {
          sTypeReport += "BROUILLON";
        }

        // recherche de la langue d'affichage du devis
        // la langue par défaut du client est dans le tag du pays du client
        // si on sélectionnne une langue dans la combo, on prend cette langue, sinon, on prend la langue du pays du client ou du site selon le destinataire
        string sLgMod = cboDemandeur.GetItemData() == 0 ? ModuleMain.CodePays(txtFields13.Text) : txtFields14.Tag.ToString();
        sLgMod = sLgMod.Substring(0, 2);

        new frmMainReport
        {
          bLaunchByProcessStart = false,
          sTypeReport = sTypeReport,
          sIdentifiant = miNumDevisCL.ToString(),
          InfosMail = sDest,
          sNomSociete = MozartParams.NomSociete,
          sLangue = sLgMod,
          sOption = (bImprimer ? "PRINT" : "PREVIEW"),
          strType = "DC",
          numAction = miNumAction
        }.ShowDialog();
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

    private void CmdVisu_Click(object sender, EventArgs e)
    {
      if (miNumDevisCL == 0)
      {
        MessageBox.Show(Resources.msg_enreg_pr_visualiser, Program.AppTitle, MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
        return;
      }

      viewReport(false, true);
    }

    private void InitialiserFeuille()
    {
      try
      {
        bModifPossible = true;

        //  recherche des info du devis (que le devis existe ou pas)
        using (SqlDataReader drD = MozartDatabase.ExecuteReader($"api_sp_RetourInfoDevisCLPrestation {miNumAction}"))
        {
          if (drD.Read())
          {
            txtFields0.Text = drD["VCLINOM"].ToString();
            txtFields1.Text = drD["VDINNOM"].ToString();
            txtFields2.Text = drD["DDCLDAT"].ToString();
            txtFields3.Text = drD["NDINCTE"].ToString();
            txtFields4.Text = drD["VSITNOM"].ToString();
            txtFields5.Text = drD["VSITRES"].ToString();
            txtFields6.Text = drD["VSITAD1"].ToString();
            txtFields7.Text = drD["VSITAD2"].ToString();
            txtFields8.Text = drD["VSITCP"].ToString();
            txtFields9.Text = drD["VSITVIL"].ToString();
            txtFields10.Text = drD["NDINNUM"].ToString();
            txtFields11.Text = drD["NDCLNUM"].ToString();
            txtFields13.Text = drD["VSITPAYS"].ToString();
            txtFields14.Text = drD["VCLIPAYS"].ToString();

            // langue du client
            txtFields14.Tag = Utils.BlankIfNull(drD["VCLILANGUE"]);

            // on rempli la combo contact client
            UtilsDevis.RemplirCboContact(cboDemandeur, Convert.ToInt32(drD["NCLINUM"]), miNumAction);

            if (drD["NDCLDESTNUM"].ToString() != "")
              cboDemandeur.SetItemData(drD["NDCLDESTNUM"].ToString());

            // urgence
            cboUrg.SelectedValue = Utils.ZeroIfNull(drD["CDCLURGENCE"]);

            //  'gestion RFA
            double dValRFA = UtilsDevis.GetTauxRFA(miNumAction);
            if (dValRFA < -1)
            {
              lblRFA.Visible = false;
              lblRFA.Text = "";
            }
            else
            {
              lblRFA.Visible = true;
              lblRFA.Text = Resources.msg_contrat_inclut + " " + (dValRFA * 100).ToString() + " % " + Resources.msg_remise_fin_annee + Environment.NewLine + Resources.msg_majorer_devis;
            }

            // Si on est en modification ou en création
            if (drD["NDCLNUM"].ToString().Substring(0, 1) == "0")
            {
              // Création
              mdecTva = UtilsDevis.RechercheTauxDeTVA(miNumAction);
              miNumDevisCL = 0;
              txtObjet.Text = drD["VACTDES"].ToString();

              txtCoefMO.Text = "2,00";
              txtCoefFOU.Text = "2,00";
            }
            else
            {
              // Modification
              mdecTva = Convert.ToDouble(drD["NDCLTTVA"]);
              miNumDevisCL = Convert.ToInt32(drD["NDCLNUM"].ToString().Substring(2));

              txtObjet.Text = drD["VACTDES"].ToString();
              uCtrlValidation1.Remarque = "";
              txtCoefMO.Text = Utils.ZeroIfNull(drD["NDCLMOE"]).ToString("# ##0.00");
              txtCoefFOU.Text = Utils.ZeroIfNull(drD["NDCLFOU"]).ToString("# ##0.00");

              txtTotHT.EditValue = Utils.ZeroIfNull(drD["NDCLHT"]);

              txtTVA.EditValue = Utils.ZeroIfNull(drD["NDCLTVA"]);

              txtDap.Text = Utils.BlankIfNull(drD["NDCLDAP"]);
              txtDre.Text = Utils.BlankIfNull(drD["NDCLDRE"]);

              txtTotHeure.Text = Utils.ZeroIfNull(drD["TOTHEURE"]).ToString("# ##0.00");

              txtTotFO.Text = Utils.ZeroIfNull(drD["TOTFOU"]).ToString("# ##0.00");
              txtCoefPVDevis.Text = Utils.ZeroIfNull(drD["COEFPVDEVIS"]).ToString("# ##0.00");

              // Taux de reussite
              if (Utils.BlankIfNull(drD["NDCLREUSSITEPOURC"]) != "")
                CboTauxReussite.SelectedValue = drD["NDCLREUSSITEPOURC"];

              NSITNUM = Convert.ToInt32(drD["NSITNUM"]);

              if (drD["CTYPEMODELE"].ToString() == "O")
                iTypeDevisPrest = 2;
              else if (drD["CTYPEMODELE"].ToString() == "S")
                iTypeDevisPrest = 0;
              else if (drD["CTYPEMODELE"].ToString() == "T")
                iTypeDevisPrest = 3;
              else
                iTypeDevisPrest = 1;
              lstOptImp[iTypeDevisPrest].Checked = true;

              // on se positionne sur le bon tech
              if (Convert.ToInt32(drD["NDCLTECH"]) != 0)
              {
                cbotech.SetItemData(Convert.ToInt32(drD["NDCLTECH"]));
                optqui1.Checked = true;
              }
              else
              {
                optqui0.Checked = true;
                cbotech.Visible = false;
              }

              txtRetGar.Text = Utils.BlankIfNull(drD["NDCLQUATHT"]);
              dRetGar = Utils.ZeroIfNull(drD["NDCLQUATHT"]);

              // Si il existe un avancement sur ce devis, modif impossible
              bModifPossible = (int)ModuleData.ExecuteScalarObject($"SELECT COUNT(*) FROM TAVANCEMENT WHERE NACTNUMBASE = {miNumAction}") == 0;

              // si il existe un chiffrage sur ce devis, modif impossible
              if ((int)ModuleData.ExecuteScalarObject($"SELECT COUNT(*) FROM TACT WITH (NOLOCK) WHERE NELFNUM IS NOT NULL AND NACTNUM = {miNumAction}") > 0)
                bModifPossible = false;
            }
            Frame7.Text = $"{Resources.msg_saisie_infos_par} {Utils.BlankIfNull(drD["QUI"])} {Resources.lib_le} {Utils.BlankIfNull(drD["DDCLDCRE"])})";

            mStrStatutValidationDevis = drD["CDCLVALID"].ToString();

            // on ramène les prestations du devis
            InitRsPrest();

            CalculerHT();

            //cboTVA.Text = mdecTva.ToString();
            cboTVA.Text = mdecTva.ToString("#.00");

            GestColorBtn();

          }
          cboTVA.SelectedIndexChanged += new EventHandler(cboTVA_SelectedIndexChanged);

          if (miNumDevisCL == 0)
          {
            CmdVisu.Enabled = cmdVisualiser.Enabled = cmdImprimer.Enabled = false;
            uCtrlValidation1.Visible = false;
          }
          else
          {
            CmdVisu.Enabled = true;

            uCtrlValidation1.Visible = true;
            afficheDelegation();
          }

          setReadOnly();

          if ((uCtrlValidation1.StatutValidation != "I") && (mstrStatutAlerte == "OUI"))
          {
            cmdValider.Enabled = false;
          }

          chkRegularisation.Checked = (Utils.BlankIfNull(drD["CDCLVALIDITE"]) == "R");
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
        apiTGridPrestSaisie.CellValueChanged -= apiTGridPrestSaisie_CellValueChanged;
        apiTGridPrestSaisie.CellValueChanged -= apiTGridPrestSaisie_CellValueChanging;

        apiTGridPrestSaisie.dgv.Columns[COL_COEF].OptionsColumn.AllowEdit = false;

        CboTauxReussite.Enabled = true;
        lblPourcReussite.Enabled = true;
      }
    }

    // pPrimaryControl est la Form parent depuis lequel l'appel se fait (ici donc this, la fenêtre)
    private void recurseBrowseInControl(Form pPrimaryControl, Control pControl)
    {
      foreach (Control lCtrl in pControl.Controls)
      {
        // La grille est rendue readonly par un autre moyen ... yala !!
        if (lCtrl.Name == "apiTGridPrestSaisie")
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
            if ((lCtrl != pPrimaryControl.CancelButton) && (new string[] { "cmdValider", "cmdPrestation", "cmdPresentation", "cmdConsult", "cmdAvenant" }.Contains(lCtrl.Name)))
            {
              lCtrl.Enabled = false;
            }
          }
          else
          {
            if (lCtrl is BaseEdit)
            {
              (lCtrl as BaseEdit).Properties.ReadOnly = true;
            }
            else
            {
              PropertyInfo _propertyInfo = lCtrl.GetType().GetProperty("Enabled", BindingFlags.FlattenHierarchy | BindingFlags.Instance | BindingFlags.NonPublic | BindingFlags.Public);
              if (_propertyInfo != null)
              {
                _propertyInfo.SetValue(lCtrl, false);
              }
              else
              {
                _propertyInfo = lCtrl.GetType().GetProperty("ReadOnly", BindingFlags.FlattenHierarchy | BindingFlags.Instance | BindingFlags.NonPublic | BindingFlags.Public);
                if (_propertyInfo != null)
                {
                  _propertyInfo.SetValue(lCtrl, true);
                }
              }
            }
          }
        }
      }
    }

    private void afficheDelegation()
    {
      double lTxtTotHT;
      try { lTxtTotHT = Utils.ZeroIfBlank(txtTotHT.Text); } catch { lTxtTotHT = 0.0; };
      uCtrlValidation1.fill(miNumDevisCL, mStrStatutValidationDevis, lTxtTotHT);
    }

    private void EnregistrerDevisCL()
    {
      try
      {
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

        if (txtDap.Text == "")
        {
          MessageBox.Show(Resources.msg_definir_delai_prep, Program.AppTitle, MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
          txtDap.Focus();
          return;
        }

        if (txtDre.Text == "")
        {
          MessageBox.Show(Resources.msg_definir_delai_real, Program.AppTitle, MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
          txtDre.Focus();
          return;
        }

        if (txtRetGar.Text == "")
        {
          MessageBox.Show(Resources.msg_saisir_retenue_garantie, Program.AppTitle, MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
          txtRetGar.Focus();
          return;
        }

        if (CboTauxReussite.SelectedIndex == 0)
        {
          MessageBox.Show(Resources.msg_prc_reuss_obligatoire, Program.AppTitle, MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
          return;
        }

        //  ' on ne peut saisir ou modifier une retenue sur garantie, que s'il n'existe pas encore d'avancement
        if (miNumDevisCL != 0 && dRetGar != Convert.ToDouble(txtRetGar.Text))
        {
          if (MozartDatabase.ExecuteScalarInt($"SELECT COUNT(*) FROM TAVANCEMENT WHERE NLDCLPRESTID in (SELECT NLDCLPRESTID FROM TLDCLPREST WHERE NDCLNUM = {miNumDevisCL})") > 0)
          {
            MessageBox.Show(Resources.msg_impossible_car_avancement_devis_existant, Program.AppTitle, MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
            return;
          }
        }

        using (SqlCommand cmd = new SqlCommand("api_sp_CreationDevisCLPrestation", MozartDatabase.cnxMozart))
        {
          cmd.CommandType = CommandType.StoredProcedure;
          SqlCommandBuilder.DeriveParameters(cmd);

          cmd.Parameters["@iNumDevisCL"].Value = miNumDevisCL;
          cmd.Parameters["@iDevis"].Value = miNumDevisCL;
          cmd.Parameters["@iAction"].Value = miNumAction;
          cmd.Parameters["@nFou"].Value = txtCoefFOU.Text == "" ? "0" : txtCoefFOU.Text.Replace(" ", "").Replace(".", ",");
          cmd.Parameters["@nMoe"].Value = txtCoefMO.Text == "" ? "0" : txtCoefMO.Text.Replace(" ", "").Replace(".", ",");
          cmd.Parameters["@nHt"].Value = Utils.ZeroIfNull(txtTotHT.EditValue);
          cmd.Parameters["@nTva"].Value = Utils.ZeroIfNull(txtTVA.EditValue);
          cmd.Parameters["@nDap"].Value = txtDap.Text == "" ? null : txtDap.Text;
          cmd.Parameters["@nDre"].Value = txtDre.Text == "" ? null : txtDre.Text;

          // Destinataire site (S) ou raison sociale (R) ou contact(C)
          int aux = cboDemandeur.SelectedIndex;
          cmd.Parameters["@envSite"].Value = (aux == 0 ? "S" : aux == 1 ? "R" : aux > 1 ? "C" : "");
          cmd.Parameters["@iDest"].Value = cboDemandeur.GetItemData();
          cmd.Parameters["@iTech"].Value = optqui1.Checked ? cbotech.GetItemData() : 0;
          cmd.Parameters["@bDetailFou"].Value = optImp1.Checked;  //'  FG a quoi cela sert ?  mystère
          cmd.Parameters["@nRetGar"].Value = Utils.ZeroIfBlank(txtRetGar.Text);
          cmd.Parameters["@nTauxTva"].Value = mdecTva;
          cmd.Parameters["@cTypemodele"].Value = optImp0.Checked ? "S" : optImp1.Checked ? "X" : optImp2.Checked ? "O" : optImp3.Checked ? "T" : "";
          cmd.Parameters["@ndclreussitepourc"].Value = CboTauxReussite.Text == "" ? null : CboTauxReussite.Text;
          cmd.Parameters["@cDclValidite"].Value = chkRegularisation.Checked ? "R" : null;
          cmd.Parameters["@curgence"].Value = cboUrg.GetItemData();

          cmd.ExecuteNonQuery();
          miNumDevisCL = Convert.ToInt32(cmd.Parameters[0].Value);
        }

        traitementDelegation();

        // On réinitialise le devis
        InitialiserFeuille();
      }
      catch (Exception ex)
      {
        MZUtils.displayError(MethodBase.GetCurrentMethod().Name, ex);
      }
    }

    private void traitementDelegation()
    {
      double lTxtTotHT;
      try { lTxtTotHT = Utils.ZeroIfBlank(txtTotHT.Text); } catch (Exception) { lTxtTotHT = 0.0; };

      uCtrlValidation1.traitementDelegation(miNumDevisCL, mStrStatutValidationDevis, lTxtTotHT);
    }

    /* TODO Tooltip --------------------------------------------------------------------------------------- */
    private void Label7_MouseDown(object sender, MouseEventArgs e)
    {
      //if (e.Button == MouseButtons.Left)
      //  MessageBox.Show(txtCoefPVDevis.ToolTipText, Program.AppTitle, MessageBoxButtons.OK, MessageBoxIcon.Information);
    }

    private void optImp0_CheckedChanged(object sender, EventArgs e)
    {
      if (optImp0.Checked)
      {
        foreach (DataRow row in mdtPrestSaisie.Rows)
        {
          if (Utils.ZeroIfNull(row["NPRIXCLI"]) > 0)
          {
            MessageBox.Show(Resources.msg_impossible_affiche_detail_car_prestations_avec_prix, Program.AppTitle, MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
            lstOptImp[iTypeDevisPrest].Checked = true;
            break;
          }
        }
      }
      var checkedButton = Frame9.Controls.OfType<RadioButton>().FirstOrDefault(r => r.Checked);
      iTypeDevisPrest = Convert.ToInt32(checkedButton.Name.Substring(6));
    }

    private void optQui_CheckedChanged(object sender, EventArgs e)
    {
      int index = Convert.ToInt32((sender as RadioButton).Name.Substring(6));
      cbotech.Visible = index != 0;
    }

    private void txtCoefFOU_MO_RetFar_KeyPress(object sender, KeyPressEventArgs e)
    {
      KeyValidator.KeyPress_SaisieMontant(e);
    }

    private void txtTotHT2_TextChanged(object sender, EventArgs e)
    {
      updateTxtTVA();
    }

    private void txtTVA2_TextChanged(object sender, EventArgs e)
    {
      txtTTC.EditValue = Utils.ZeroIfNull(txtTVA.EditValue) + Utils.ZeroIfNull(txtTotHT.EditValue);
    }

    private void cboTVA_SelectedIndexChanged(object sender, EventArgs e)
    {
      mdecTva = Convert.ToDouble(cboTVA.Text.Replace(" ", "").Replace(".", ","));
      updateTxtTVA();
    }

    private void updateTxtTVA()
    {
      txtTVA.EditValue = Utils.ZeroIfNull(txtTotHT.EditValue) * mdecTva / 100.0;
    }

    private void InitgridPrest()
    {
      apiTGridPrestSaisie.AddColumn(Resources.col_ID, "NLDCLPRESTID", 0);                                             // 1
      apiTGridPrestSaisie.AddColumn(Resources.col_Cat, "CAT", 500);                                                   // 2
      apiTGridPrestSaisie.AddColumn(Resources.col_Code, "VPRESTCODE", 750);
      apiTGridPrestSaisie.AddColumn(Resources.col_Prestation, "VPRESTLIB", 4000);                                     // 3
      apiTGridPrestSaisie.AddColumn(Resources.col_unite, "VPRESTUNITE", 400, "", 2);                                  // 4
      apiTGridPrestSaisie.AddColumn(Resources.col_Qte, "NQTE", 500, "0.##", 2);                                       // 5
      apiTGridPrestSaisie.AddColumn(Resources.col_J_N, "BLDCLPREST_NUIT", 750, "", 2);                                // 6
      apiTGridPrestSaisie.AddColumn(Resources.col_MO_HT, "NPRESTSERMOHT", 900, "Currency", 2);                        // 7
      apiTGridPrestSaisie.AddColumn(Resources.col_Nb_H, "NPRESTQTEMO", 650, "0.##", 2);                               // 8
      apiTGridPrestSaisie.AddColumn(Resources.col_total_nb_H, "NTOTPRESTQTEMO", 650, "0.##", 2);                      // 9
      apiTGridPrestSaisie.AddColumn(Resources.col_total_MO_HT, "NTOTPRESTSERMOHT", 650, "0.##", 2);                   // 10
      apiTGridPrestSaisie.AddColumn(Resources.col_FO_unitaire, "NPRESTFOHT", 1300, "Currency", 2);                    // 11
      apiTGridPrestSaisie.AddColumn(Resources.col_total_FO_HT, "NTOTPRESTFOHT", 1300, "Currency", 2);                 // 12
      apiTGridPrestSaisie.AddColumn(Resources.col_debourse_HT, "TOTAL", 1200, "Currency", 2);                         // 14
      apiTGridPrestSaisie.AddColumn(Resources.col_Coeff, COL_COEF, 800, "0.00", 2);                                     // 15
      apiTGridPrestSaisie.AddColumn(Resources.col_PrixDeVente, "TOTALCOEF", 1300, "Currency", 2);                     // 16
      apiTGridPrestSaisie.AddColumn(Resources.col_Prix_Client, "NPRIXCLITOT", 1000, "Currency", 2);                   // 17
      apiTGridPrestSaisie.AddColumn("NIDFICHEFO", "NIDFICHEFO", 0);                                                   // 18
      apiTGridPrestSaisie.AddColumn("Fiche FO", "VLIBFO", 1000);                                                      // 19
      apiTGridPrestSaisie.AddColumn("NIDFICHEMO", "NIDFICHEMO", 0);                                                   // 20
      apiTGridPrestSaisie.AddColumn(Resources.col_fiche_MO, "VLIBMO", 1000);                                          // 21
      apiTGridPrestSaisie.AddColumn(Resources.col_dateprix, "DPRESTMOD", 1000);                                       // 22
      apiTGridPrestSaisie.AddColumn("NPRESTSERCOEFNUIT", "NPRESTSERCOEFNUIT", 0);                                     // 23
      apiTGridPrestSaisie.AddColumn("NPRESTSERMOHT_BASE", "NPRESTSERMOHT_BASE", 0);                                   // 24
      apiTGridPrestSaisie.AddColumn("NCOEFFPRIX", "NCOEFFPRIX", 0);                                                   // 25

      apiTGridPrestSaisie.DelockColumn(COL_COEF);

      apiTGridPrestSaisie.InitColumnList();
      apiTGridPrestSaisie.GridControl.DataSource = mdtPrestSaisie;
    }

    private void InitRsPrest()
    {
      apiTGridPrestSaisie.LoadData(mdtPrestSaisie, MozartDatabase.cnxMozart, $"exec api_sp_listePrestDevis {miNumDevisCL}");
      mdtPrestSaisie.Columns[COL_COEF].ReadOnly = false;
      mdtPrestSaisie.Columns["TOTALCOEF"].ReadOnly = false;
    }

    private void CalculerHT()
    {
      if (mdtPrestSaisie.Rows.Count <= 0)
      {
        txtTotHT.EditValue = 0.0;
        return;
      }

      using (SqlDataReader dr = MozartDatabase.ExecuteReader($"[api_sp_CalculTotalDevisPrestation] {miNumDevisCL}"))
      {
        if (dr.Read())
        {
          txtTotHT.EditValue = Utils.ZeroIfNull(dr["VAL"]);
          txtCoefPVDevis.Text = Utils.ZeroIfNull(dr["COEFPVDEV"]).ToString("# ##0.00");
        }
      }
    }

    private void cmdPrestation_Click(object sender, EventArgs e)
    {
      if (!bModifPossible)
      {
        MessageBox.Show(Resources.msg_impossible_avancement_chiffrage_existe, Program.AppTitle, MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
        return;
      }

      if (miNumDevisCL == 0)
      {
        MessageBox.Show(Resources.msg_enregistrer_devis, Program.AppTitle, MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
        return;
      }

      new frmRecherchePrestation
      {
        miDclNum = miNumDevisCL,
        mbAfficheInfoFou = true,
        mdtPrestSaisie = mdtPrestSaisie,
        miNumAction = miNumAction
      }.ShowDialog();

      //  retour de la page des prestations
      InitRsPrest();

      CalculerHT();

      cmdValider_Click(null, null);
    }

    private void ValiditeDateLastModifPrestation()
    {
      try
      {
        foreach (DataRow row in mdtPrestSaisie.Rows)
          if (Utils.BlankIfNull(row["DPRESTMOD"]) != "")
            if (Convert.ToDateTime(row["DPRESTMOD"]) < DateTime.Now.AddYears(-2))
            {
              MessageBox.Show(Resources.msg_update_prix_before, Program.AppTitle, MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
              break;
            }
      }
      catch (Exception ex)
      {
        MZUtils.displayError(MethodBase.GetCurrentMethod().Name, ex);
      }
    }

    private void cmdPresentation_Click(object sender, EventArgs e)
    {
      new frmDevisPrestationPresentation(miNumDevisCL).ShowDialog();
    }

    private void cmdFicheHeuretech_Click(object sender, EventArgs e)
    {
      if (miNumDevisCL == 0)
      {
        MessageBox.Show(Resources.msg_Impression_impossible_enregistrer_devis, Program.AppTitle, MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
        return;
      }

      string[,] TdbGlobal = { { "Copie", "ORIGINAL" } };

      frmBrowser f = new frmBrowser();
      f.Preview_Print(MozartParams.CheminModeles + MozartParams.Langue + @"\TDevisClientPrestationSuiviHeure.rtf",
                      $@"TSuiviHeure_{miNumDevisCL}.rtf",
                      TdbGlobal,
                      $"api_sp_ImpDevisCLPrestSuiviHeure {miNumDevisCL}",
                      " (Visualisation devis client)",
                      "PREVIEW");
    }

    private void cmdConsult_Click(object sender, EventArgs e)
    {
      if (miNumDevisCL == 0)
      {
        return;
      }

      Cursor.Current = Cursors.WaitCursor;
      new frmConsultationFour
      {
        miNumPrest = 0,
        miNumDevisPrest = miNumDevisCL
      }.ShowDialog();
      Cursor.Current = Cursors.Default;
    }

    private void cmdAvenant_Click(object sender, EventArgs e)
    {
      if (miNumDevisCL == 0)
      {
        MessageBox.Show(Resources.msg_enregistrer_devis, Program.AppTitle, MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
        return;
      }

      new frmDevisClientAvenant()
      {
        miNumDCLPrest = miNumDevisCL,
        miNumDemandeur = cboDemandeur.GetItemData()
      }.ShowDialog();

      InitialiserFeuille();
      GestColorBtn();
    }

    private void GestColorBtn()
    {
      if (MozartDatabase.ExecuteScalarInt("SELECT COUNT(*) FROM TAVENANT WHERE NDCLNUM = " + miNumDevisCL) > 0)
        cmdAvenant.BackColor = MozartColors.ColorH80FFFF;
      else
        cmdAvenant.BackColor = MozartColors.ColorH8000000F;
    }

    private void cmdDecoupage_Click(object sender, EventArgs e)
    {
      new FrmDevPrestAffectFiche(miNumDevisCL).ShowDialog();
    }

    private void apiTGridPrestSaisie_RowCellStyle(object sender, RowCellStyleEventArgs e)
    {
      // PRIXCLIENTS en rouge
      if (e.RowHandle >= 0 && e.Column.Name == COL_COEF)
      {
        GridView gv = sender as GridView;

        DataRow row = gv.GetDataRow(e.RowHandle);
        if (row["NPRIXCLITOT"].ToString() != "")
        {
          e.Appearance.ForeColor = Color.Red;
          e.Appearance.Font = new Font(e.Appearance.Font, FontStyle.Bold);
        }
      }
    }

    private void apiTGridPrestSaisie_CellValueChanging(object sender, DevExpress.XtraGrid.Views.Base.CellValueChangedEventArgs e)
    {
      // Si NCOEFFPRIX is null alors modification du coeff impossible, utiliser car problématique davec l'historique
      GridView gv = sender as GridView;

      DataRow row = gv.GetDataRow(e.RowHandle);
      if (row == null) return;

      if (e.Column.Name == COL_COEF)
      {
        if (Utils.ZeroIfNull(row["NPRIXCLITOT"]) != 0)
        {
          MessageBox.Show(Resources.msg_impossible_prix_client_existe, Program.AppTitle, MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
          gv.SetFocusedValue(row[COL_COEF]);
          return;
        }

        if (Utils.ZeroIfNull(row["NCOEFFPRIX"]) == 0)
        {
          MessageBox.Show(Resources.msg_impossible_coef_base_devis, Program.AppTitle, MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
          gv.SetFocusedValue(row[COL_COEF]);
          return;
        }
      }

      if (e.Column.Name == "BLDCLPREST_NUIT")
        gv.SetFocusedValue(row["BLDCLPREST_NUIT"]);
    }

    private void apiTGridPrestSaisie_CellValueChanged(object sender, DevExpress.XtraGrid.Views.Base.CellValueChangedEventArgs e)
    {
      GridView gv = sender as GridView;
      if (e.Column.Name == COL_COEF)
      {
        DataRow row = gv.GetDataRow(e.RowHandle);
        if (Utils.BlankIfNull(row[COL_COEF]) == "")
        {
          MessageBox.Show(Resources.msg_saisir_coef, Program.AppTitle, MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
          return;
        }
        if (Utils.IsNumeric(row[COL_COEF].ToString()) == false)
        {
          MessageBox.Show(Resources.msg_format_coef_numerique, Program.AppTitle, MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
          return;
        }
        if (Convert.ToDouble(row[COL_COEF].ToString()) < 1)
        {
          MessageBox.Show(Resources.msg_coeff_inf_1_coef_defaut, Program.AppTitle, MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
          row[COL_COEF] = 1.7;
          return;
        }

        if (Utils.ZeroIfNull(row["NPRIXCLITOT"]) == 0 && Utils.ZeroIfNull(row["NCOEFFPRIX"]) != 0)
        {
          row["TOTALCOEF"] = Convert.ToDouble(row[COL_COEF]) * Convert.ToDouble(row["TOTAL"]);

          MozartDatabase.ExecuteNonQuery($"UPDATE TLDCLPREST SET NCOEFFPRIX = {row[COL_COEF].ToString().Replace(",", ".")} WHERE NLDCLPRESTID = {row["NLDCLPRESTID"]}");

          CalculerHT();
        }
      }
    }

    private void optImp123_CheckedChanged(object sender, EventArgs e)
    {
      iTypeDevisPrest = Convert.ToInt32((sender as RadioButton).Tag);
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

    private void cmdAnObs_Click(object sender, EventArgs e)
    {
      TxtObs.Text = "";
      framObs.Visible = false;
    }

    private void CboTauxReussite_SelectionChangeCommitted(object sender, EventArgs e)
    {
      if ((miNumDevisCL != 0) && (!CboTauxReussite.SelectedValue.Equals("")))
      {
        MozartDatabase.ExecuteNonQuery($"UPDATE TDCL SET NDCLREUSSITEPOURC = {CboTauxReussite.SelectedValue} WHERE NDCLNUM = {miNumDevisCL}");
      }
    }
  }
}