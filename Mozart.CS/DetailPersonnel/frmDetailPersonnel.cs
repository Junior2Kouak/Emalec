using DevExpress.CodeParser;
using DevExpress.XtraGrid;
using DevExpress.XtraGrid.Views.Grid;
using Microsoft.VisualBasic;
using MozartCS.DetailPersonnel;
using MozartCS.Properties;
using MozartLib;
using MozartNet;
using MozartUC;
using ReportEmalec.Net;
using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.IO;
using System.Reflection;
using System.Windows.Forms;
using MZUtils = MozartControls.Utils;
using MZCtrlResources = MozartControls.Properties.Resources;

namespace MozartCS
{
  public partial class frmDetailPersonnel : Form
  {
    public int miNumPer;
    public string mstrLibNomSoc;
    public string mstrStatut;
    public string mFormParent;

    OpenFileDialog CommonDialog1 = new OpenFileDialog();

    DataTable dtHisto = new DataTable();
    DataTable dtEnf = new DataTable();
    SqlDataAdapter daEnf;
    SqlCommandBuilder cbEnf;
    DataTable dtAutreAvtg = new DataTable();
    SqlDataAdapter daAutreAvtg;
    SqlCommandBuilder cbAutreAvtg;

    bool bPrem;
    string[] tFormat = {"ImageBitmap","Document WORD (doc)","Plan Autocad","Image GIF","Document HTML","Image Jpeg", "Image JPG crypté",
                          "Fichier PDF","Image PNG", "Docment WORD (rtf)","Image TIF","Fichier texte", "Classeur EXCEL"  };

    string[] tFormatImg = { "BMP", "DOC", "DWF", "GIF", "HTM", "JPEG", "JPGX", "PDF", "PNG", "RTF", "TIF", "TXT", "XLS" };
    string strImage;

    string sDateSortie_Loaded;
    bool bNonConcurrenceLoaded;

    bool bGridOk = false;

    private double dTauxAna;

    public frmDetailPersonnel() { InitializeComponent(); }

    /* OK ------------------------------------------------------------------------------------*/
    private void frmDetailPersonnel_Load(object sender, System.EventArgs e)
    {
      try
      {
        ModuleMain.Initboutons(this);
        cmdCourrier.Visible = false;
        grdEnf.btnExcel.Visible = grdEnf.btnPrint.Visible = false;
        grdHisto.btnExcel.Visible = grdHisto.btnPrint.Visible = false;
        Label550.Visible = Label551.Visible = CboClientPoste.Visible = CboSitePoste.Visible = false;
        grdAutreAvtg.btnExcel.Visible = grdAutreAvtg.btnPrint.Visible = false;

        bPrem = true;

        // Chargement du taux analytique
        string sQuery = $"SELECT NTAUX_ANA_VAL FROM TTAUX_ANA WHERE VSOCIETE = APP_NAME()";
        sQuery += " AND VTAUX_ANA_LIB = 'Taux horaire' AND NTAUX_ANA_ANNEE = YEAR(GETDATE())";
        dTauxAna = 0.0d;
        using (SqlDataReader dr = ModuleData.ExecuteReader(sQuery))
        {
          if (dr.Read())
          {
            dTauxAna = Convert.ToDouble(dr["NTAUX_ANA_VAL"]);
          }

          dr.Close();
        }

        //remplissage cboImgFormat
        for (int i = 0; i < tFormat.Length; i++)
          cboImgFormat.Items.Add(tFormat[i]);
        cboImgFormat.SelectedIndex = 5;

        apiComboService.Init(MozartDatabase.cnxMozart, "select NSERNUM, VSERLIB from TSER WHERE NSERACTIF = 1 ORDER BY VSERLIB",
                             "NSERNUM", "VSERLIB", new List<string>() { Resources.col_Num, Resources.col_Nom }, 150, 500, bHideFirstColumn: true);

        ModuleData.RemplirCombo(cboPays, "select NPAYSNUM, VPAYSNOM from TPAYS order by VPAYSNOM");
        cboPays.ValueMember = "NPAYSNUM";
        cboPays.DisplayMember = "VPAYSNOM";

        RemplirComboLangues();

        apiComboType.Init(MozartDatabase.cnxMozart, "select ID, VTYPEDETAILLIB from TREF_TYPEPERDETAIL order by VTYPEDETAILLIB",
                          "ID", "VTYPEDETAILLIB", new List<string>() { Resources.col_ID, Resources.col_Type }, 150, 500, bHideFirstColumn: true);

        ModuleData.RemplirCombo(CboPaysNaiss, "SELECT NPAYSNUM, VPAYSNOM FROM TPAYS ORDER BY VPAYSNOM");
        CboPaysNaiss.ValueMember = "NPAYSNUM";
        CboPaysNaiss.DisplayMember = "VPAYSNOM";

        ModuleData.RemplirCombo(CboClientPoste, "select TCLI.NCLINUM, TCLI.VCLINOM from TCLI WITH (NOLOCK) WHERE TCLI.CCLIACTIF = 'O' AND TCLI.VSOCIETE = APP_NAME() ORDER BY TCLI.VCLINOM");
        CboClientPoste.ValueMember = "NCLINUM";
        CboClientPoste.DisplayMember = "VCLINOM";

        cboTypeVeh.Init(MozartDatabase.cnxMozart, "SELECT NIDTYPEVEH, VLIBTYPEVEH FROM TREF_TYPEVEH order by VLIBTYPEVEH",
                        "NIDTYPEVEH", "VLIBTYPEVEH", new List<string>() { Resources.col_Num, Resources.col_Type }, 150, 500, bHideFirstColumn: true);

        // affiche le nom de la société selectionné
        Label1.Text = $"{Resources.txt_detailEmploye} {GetNomSocieteTemp()}";

        cboContrat.Init(MozartDatabase.cnxMozart, $"SELECT NTYPECONTRATSAL, VTYPECONTRATSAL FROM TREF_TYPECONTRATSAL WHERE LANGUE='{MozartParams.Langue}' ORDER BY VTYPECONTRATSAL",
                        "NTYPECONTRATSAL", "VTYPECONTRATSAL", new List<string>() { Resources.col_Num, Resources.col_Contrat }, 200, 200);

        ModuleData.RemplirCombo(cboTypeTrav, $"select NTYPTRAV, VTYPETRAV from TREF_TYPTRAV WHERE LANGUE='{MozartParams.Langue}'order by NTYPTRAV", true);
        cboTypeTrav.ValueMember = "NTYPTRAV";
        cboTypeTrav.DisplayMember = "VTYPETRAV";

        ModuleData.RemplirCombo(cboSituation, $"select NSITUFAM, VSITUFAM from TREF_SITUFAM WHERE LANGUE='{MozartParams.Langue}'order by NSITUFAM", true);
        cboSituation.ValueMember = "NSITUFAM";
        cboSituation.DisplayMember = "VSITUFAM";

        // traitement du cas de modification ou de création
        if (mstrStatut == "C")
          OuvertureEnCreation();
        else
          OuvertureEnModification();

        bPrem = false;

        Cursor = Cursors.Default;
      }
      catch (Exception ex)
      {
        MZUtils.displayError(MethodBase.GetCurrentMethod().Name, ex);
      }
    }
    private string GetNomSocieteTemp()
    {
      return (MozartParams.NomSocieteTemp == "GROUPE" ? mstrLibNomSoc : MozartParams.NomSocieteTemp);
    }

    private void cmdFermer_Click(object sender, System.EventArgs e)
    {
      Dispose();
    }

    private void apiComboType_TxtChanged(object sender, EventArgs e)
    {
      if (apiComboType.GetText() == "Technicien" || apiComboType.GetText() == "Contremaitre" || apiComboType.GetText() == "Ouvrier")
      {
        lblContremaitre.Visible = cboMaitre.Visible = lblPlanificateur.Visible = cboPlanificateur.Visible = cmdContrat.Enabled = true;

        if (null == cboMaitre.DataSource())
          cboMaitre.Init(MozartDatabase.cnxMozart, "[api_sp_ListeCMAndChefGRP]", "NPERNUM", "Column1", new List<string>() { Resources.col_Num, Resources.col_Nom }, 150, 500, bHideFirstColumn: true);

        if (null == cboPlanificateur.DataSource())
          cboPlanificateur.Init(MozartDatabase.cnxMozart, $"select NPERNUM, (VPERNOM + ' ' + VPERPRE) AS NOMPRE from TPER where NSERNUM=12 and VSOCIETE = '{GetNomSocieteTemp()}' AND CPERACTIF = 'O' " +
                                                $"ORDER BY NOMPRE", "NPERNUM", "NOMPRE", new List<string>() { Resources.col_Num, Resources.col_Nom }, 150, 50, bHideFirstColumn: true);
      }
      else
        lblContremaitre.Visible = cboMaitre.Visible = lblPlanificateur.Visible = cboPlanificateur.Visible = cmdContrat.Enabled = false;

      if (apiComboType.GetText() == "Bureau d'étude" || apiComboType.GetText() == "Conducteur de travaux" || apiComboType.GetText() == "Chargé(e) d’affaires adjoint")
        cmdHelpChantier.Visible = CmdAffectChaffChantier.Visible = true;
      else
        cmdHelpChantier.Visible = CmdAffectChaffChantier.Visible = false;
    }

    private void cmdCarte_Click(object sender, EventArgs e)
    {
      Cursor.Current = Cursors.WaitCursor;
      frmBrowser f = new frmBrowser();
      f.msStartingAddress = "https://maps.emalec.com/SiteParAdresse.asp?NOM=" + txtNom.Text + "&AD1=" + txtAD1.Text + "&VILLE=" + txtCP.Text + " " + txtVille.Text + "&PAYS=" + cboPays.Text;
      f.ShowDialog();
      Cursor.Current = Cursors.Default;
    }

    private void cmdContrat_Click(object sender, EventArgs e)
    {
      Cursor.Current = Cursors.WaitCursor;
      frmSaisieContratTech f = new frmSaisieContratTech();
      f.mstrType = "PER";
      f.miNumTech = miNumPer;
      f.Text += " (" + txtNom.Text + " " + txtprenom.Text + ")";
      f.ShowDialog();
      Cursor.Current = Cursors.Default;
    }

    private void cmdFichePerso_Click(object sender, EventArgs e)
    {
      new frmGestionDocFichePerso(miNumPer).ShowDialog();
    }

    private void cmdHabilitation_Click(object sender, EventArgs e)
    {
      if (miNumPer == 0)
      {
        MessageBox.Show(Resources.msg_print_not_possible_must_save_fiche, Program.AppTitle, MessageBoxButtons.OK, MessageBoxIcon.Information);
        return;
      }

      new frmMainReport
      {
        bLaunchByProcessStart = false,
        sTypeReport = "TCARTE",
        sIdentifiant = miNumPer.ToString(),
        InfosMail = $"0|0|0",
        sNomSociete = MozartParams.NomSocieteTemp,
        sLangue = MozartParams.Langue,
        sOption = "PREVIEW",
      }.ShowDialog();
    }

    private void cmdEnregistrer_Click(object sender, EventArgs e)
    {
      try
      {
        //champs obligatoires
        if (txtNom.Text == "")
        {
          MessageBox.Show(Resources.msg_must_type_nom_personne, Program.AppTitle, MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
          txtNom.Focus();
          return;
        }
        if (txtprenom.Text == "")
        {
          MessageBox.Show(Resources.msg_must_type_prenom_personne, Program.AppTitle, MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
          txtprenom.Focus();
          return;
        }
        if (null == cboCiv.SelectedItem || cboCiv.SelectedItem.ToString() == "")
        {
          MessageBox.Show("Saisissez la civilité de la personne", Program.AppTitle, MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
          cboCiv.Focus();
          return;
        }
        if (apiComboRegion.GetText() == "")
        {
          MessageBox.Show("Saisissez la région de la personne", Program.AppTitle, MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
          apiComboRegion.Focus();
          return;
        }
        if (apiComboService.GetText() == "")
        {
          MessageBox.Show("Saisissez le service de la personne", Program.AppTitle, MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
          apiComboService.Focus();
          return;
        }
        if (apiComboType.GetText() == "")
        {
          MessageBox.Show("Saisissez le type de la personne", Program.AppTitle, MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
          apiComboType.Focus();
          return;
        }
        if (txtDateEntree.Text == "")
        {
          MessageBox.Show(Resources.msg_saisirDateEntree, Program.AppTitle, MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
          txtDateEntree.Focus();
          return;
        }
        if (null == cboPays.SelectedItem || cboPays.SelectedItem.ToString() == "")
        {
          MessageBox.Show(Resources.msg_SaisirPaysPersonne, Program.AppTitle, MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
          cboPays.Focus();
          return;
        }

        // Champs numériques
        if (txtNumStd.Text != "" && !Utils.IsNumeric(txtNumStd.Text))
        {
          MessageBox.Show(Resources.msg_champ_numerique, Program.AppTitle, MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
          txtNumStd.Focus();
          return;
        }
        if (txtNbEnf.Text != "" && !Utils.IsNumeric(txtNbEnf.Text))
        {
          MessageBox.Show(Resources.msg_champ_numerique, Program.AppTitle, MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
          txtNbEnf.Focus();
          return;
        }

        // seulement pour emalec pour le moment : le 20/02/2017 MC
        if (apiComboType.GetText() == "Technicien" && cboMaitre.GetText() == "" && GetNomSocieteTemp() == "EMALEC")
        {
          MessageBox.Show(Resources.msg_ChoisirContremaitre, Program.AppTitle, MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
          cboMaitre.Focus();
          return;
        }

        // Si droits modif salaire, on fait les tests nécessaires
        if (Frame6.Visible)
        {
          // Si pas intérim, on teste pour avoir des valeurs non nulles
          if (cboContrat.GetItemData() != 5)
          {
            // Nb heures
            if ((txtNbHeures.EditValue == null) || (txtNbHeures.EditValue.ToString() == "") || (Convert.ToDecimal(txtNbHeures.EditValue) == 0))
            {
              MessageBox.Show("Il faut renseigner un nb d'heures de travail mensuel supérieur à 0", Program.AppTitle, MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
              txtNbHeures.Focus();
              return;
            }

            // Salaire
            if (Convert.ToDecimal(txtSalaire.Text) == 0)
            {
              MessageBox.Show("Il faut renseigner une rémunération mensuelle brute supérieure à 0", Program.AppTitle, MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
              txtSalaire.Focus();
              return;
            }

            // Nb de mois contractuel
            if (Convert.ToDecimal(txtNbMoisContractuel.Text) == 0)
            {
              MessageBox.Show("Il faut renseigner un nb de mois contractuel supérieur à 0", Program.AppTitle, MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
              txtNbMoisContractuel.Focus();
              return;
            }
          }
        }

        // si technicien posté
        if (ChkTypePoste0.Checked)
        {
          if (CboClientPoste.GetItemData() == 0 || CboSitePoste.GetItemData() == 0)
          {
            MessageBox.Show(Resources.msg_techPosteSelectSite, Program.AppTitle, MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
            return;
          }
        }

        // on verifie qu'au moins un contrat soit saisi dans les compétences du tech
        // si on est en creation
        if (mstrStatut == "C")
        {
          if (apiComboType.GetText() == "Technicien")
          {
            int count = 0;
            using (SqlDataReader sdr = ModuleData.ExecuteReader("SELECT * FROM TPERTYPECONTRAT WHERE NPERNUM = " + miNumPer))
            {
              while (sdr.Read())
              {
                count++;
              }
            }
            if (count == 0)
            {
              MessageBox.Show(Resources.msg_saisirContratCompTech, Program.AppTitle, MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
              return;
            }
          }
        }

        if (txtDateSortie.Text != "" && ChkNonCuccuren.Checked == true)
        {
          if ((sDateSortie_Loaded != txtDateSortie.Text) || (bNonConcurrenceLoaded != ChkNonCuccuren.Checked))
          {
            new frmMessageBox
            {
              msMessage = $"Cet employé a signé une clause de non-concurrence.{Environment.NewLine}{Environment.NewLine} Contactez la Direction pour décider de sa levée ou non.",
              msTitle = Resources.msg_information,
              mbOK = true
            }.ShowDialog();
          }
        }

        Enregistrer();

                //on met à jour dans taccesweb l object id du user
                if(miNumPer != 0 & txtMailPro.Text != "") UpdateEntraObjectId(txtMailPro.Text, miNumPer);

                // on passe la feuille en statut modifier
                mstrStatut = "M";
        OuvertureEnModification(false); //on ne recharge pas emasset grace ce false
            }
      catch (Exception ex)
      {
        MZUtils.displayError(MethodBase.GetCurrentMethod().Name, ex);
      }
    }

    private void cmdVisualiser_Click(object sender, EventArgs e)
    {
      if (miNumPer == 0)
      {
        MessageBox.Show(Resources.msg_print_not_possible_must_save_fiche, Program.AppTitle, MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
        return;
      }
      string[,] TdbGlobal = { { "Date", DateTime.Now.ToShortDateString() } };
      string CheminModelesTemp = ModuleData.RechercheParam("REP_MODELES", GetNomSocieteTemp());

      frmBrowser f = new frmBrowser();
      f.miPlanningAn = 0;
      f.Preview_Print(CheminModelesTemp + MozartParams.Langue + @"\TFichePersonnelPhoto2.rtf",
                      @"TFichePersonnel.Out.rtf",
                      TdbGlobal,
                      "exec api_sp_InfoPersonnelRtf " + miNumPer.ToString() + ",'" + GetNomSocieteTemp() + "'",
                      " (Visualisation fiche personnel)",
                      "PREVIEW");
    }

    private void chkGrp_CheckedChanged(object sender, EventArgs e)
    {
      if (bPrem) return;
      MessageBox.Show(Resources.msg_person_visible_if_checked, Program.AppTitle, MessageBoxButtons.OK, MessageBoxIcon.Information);
    }

    private void cmdRecherche_Click(object sender, EventArgs e)
    {
      new frmRechCodePostal
      {
        ControlCible1 = txtCP,
        ControlCible2 = cboVille
      }.ShowDialog();
    }

    private void OuvertureEnCreation()
    {
      try
      {
        sDateSortie_Loaded = "";
        bNonConcurrenceLoaded = false;

        strImage = "";

        //temps complet
        cboTypeTrav.SetItemData("1");
        //non connu
        cboSituation.SetItemData("8");

        apiComboRegion.Init(MozartDatabase.cnxMozart, "select NREGCOD, VDEPLIB from TREF_REG where npaysnum = 1 order by VDEPLIB",
                              "NREGCOD", "VDEPLIB", new List<string>() { Resources.col_Num, Resources.col_Dep }, 150, 500, true);

        cboPays.SetItemData("1");
        cboAutorisation.SelectedItem = "NON";

        CboPaysNaiss.SetItemData("0");

        cboContrat.SetItemData(3);
      }
      catch (Exception ex)
      {
        MZUtils.displayError(MethodBase.GetCurrentMethod().Name, ex);
      }
    }

    private void CmdTestCompetAll_Click(object sender, EventArgs e)
    {
      if (txtNom.Text == "" || miNumPer == 0)
      {
        MessageBox.Show(Resources.msg_SaisirNom, Program.AppTitle, MessageBoxButtons.OK, MessageBoxIcon.Information);
        return;
      }
      switch (Convert.ToInt32((sender as Button).Tag))
      {
        case 0:
          new frmQCMListeResultByPER(miNumPer, txtNom.Text.Replace(" ", "_"), "1").ShowDialog();
          break;
        case 1:
          new frmCauserieListeResultByPER(miNumPer, txtNom.Text.Replace(" ", "_"), "2").ShowDialog();
          break;
      }
    }

    private void OuvertureEnModification(bool ReloadEMASSET = true)
    {
      try
      {
        using (SqlDataReader sdr = ModuleData.ExecuteReader($"exec api_sp_InfoPersonnel2 {miNumPer},'{GetNomSocieteTemp()}'"))
        {
          if (sdr.Read())
          {
            txtNom.Text = Utils.BlankIfNull(sdr["VPERNOM"]);
            txtprenom.Text = Utils.BlankIfNull(sdr["VPERPRE"]);
            cboCiv.SelectedItem = Strings.Trim(Utils.BlankIfNull(sdr["CPERCIV"]));
            txtSignature.Text = Utils.BlankIfNull(sdr["VPERSIGN"]);

            txtAD1.Text = Utils.BlankIfNull(sdr["VPERAD1"]);
            txtAD2.Text = Utils.BlankIfNull(sdr["VPERAD2"]);
            txtCP.Text = Utils.BlankIfNull(sdr["VPERCP"]);
            txtVille.Text = Utils.BlankIfNull(sdr["VPERVIL"]);

            txtTel.Text = Utils.BlankIfNull(sdr["VPERTEL"]);
            txtFax.Text = Utils.BlankIfNull(sdr["VPERFAX"]);
            txtMail.Text = Utils.BlankIfNull(sdr["VPERMAI"]);
            txtMailPro.Text = Utils.BlankIfNull(sdr["VPERMAILPRO"]);
            txtPort.Text = Utils.BlankIfNull(sdr["VPERPOR"]);
            txtNumStd.Text = Utils.BlankIfNull(sdr["NPERSTD"]);
            txtTelContact.Text = Utils.BlankIfNull(sdr["VPERTELCONTACT"]);
            txtContact.Text = Utils.BlankIfNull(sdr["VPERCONTACT"]);
            txtCategoriePer.Text = Utils.BlankIfNull(sdr["NPERCATEGORIE"]);
            txtSupHierarchique.Text = Utils.BlankIfNull(sdr["VPERSUPHIERARCHIQUE"]);
            txtNumPersonne.Text = sdr["NPERNUM"].ToString();

            apiComboService.SetText(sdr["VSERLIB"].ToString());

            cboContrat.SetItemData(Convert.ToInt32(sdr["NPERCONTRAT"]));
            if (sdr["DPERENT"] != DBNull.Value) txtDateEntree.DateTime = (DateTime)sdr["DPERENT"];
            if (sdr["DPERENTINT"] != DBNull.Value) txtDateEntreeInt.DateTime = (DateTime)sdr["DPERENTINT"];
            if (sdr["DPERSOR"] != DBNull.Value)
            {
              txtDateSortie.DateTime = (DateTime)sdr["DPERSOR"];
              sDateSortie_Loaded = txtDateSortie.DateTime.ToShortDateString();
            }
            else
            {
              sDateSortie_Loaded = "";
            }
            if (sdr["DPERNAI"] != DBNull.Value) txtDateNaissance.DateTime = (DateTime)sdr["DPERNAI"];
            txtAnciennete.Text = Convert.ToDouble(sdr["ANC"]).ToString();
            txtAncienneteInt.Text = Utils.BlankIfNull(sdr["ANCINT"]);
            txtAge.Text = Utils.BlankIfNull(sdr["Age"]);
            cboCollege.SelectedItem = Utils.BlankIfNull(sdr["VPERCOL"]);
            txtCategorie.Text = Utils.BlankIfNull(sdr["VPERCAT"]);
            txtEchelon.Text = Utils.BlankIfNull(sdr["VPERECH"]);
            txtNiveau.Text = Utils.BlankIfNull(sdr["VPERNIV"]);
            txtCoef.Text = Utils.BlankIfNull(sdr["VPERCOE"]);
            txtNbHeures.EditValue = Utils.BlankIfNull(sdr["NPERHEU"]);
            txtSalaire.Text = Utils.BlankIfNull(sdr["NPERSAL"]);
            if (sdr["DPERAVF"] != DBNull.Value) txtDateAvance.DateTime = (DateTime)sdr["DPERAVF"];
            if (sdr["DPERHAB"] != DBNull.Value) txtDateRQTH.DateTime = (DateTime)sdr["DPERHAB"];
            if (sdr["DPERVIS"] != DBNull.Value) txtDateVisite.DateTime = (DateTime)sdr["DPERVIS"];
            if (sdr["DPERINF"] != DBNull.Value) txtDateInfirmier.DateTime = (DateTime)sdr["DPERINF"];
            if (sdr["DPERRAPPEL"] != DBNull.Value) txtDateRestriction.DateTime = (DateTime)sdr["DPERRAPPEL"];
            if (sdr["NPERMAV"] != DBNull.Value) txtAvance.Text = Utils.BlankIfNull(sdr["NPERMAV"]);
            if (sdr["DPERPERMIS"] != DBNull.Value) txtDatePret.DateTime = (DateTime)sdr["DPERPERMIS"];

            txtNbMoisContractuel.Text = Utils.BlankIfNull(sdr["NPERNBMOIS"]);

            // type de personnel
            apiComboType.SetItemData(Convert.ToInt32(sdr["ID"]));

            if (sdr["NPERSITUFAM"] != DBNull.Value)
              cboSituation.SetItemData(sdr["NPERSITUFAM"].ToString());
            else
              cboSituation.SetItemData("8");

            // combo de la langue (18/06/2020)
            cboLangueAbrev.SelectedItem = sdr["VLANGUESYS"].ToString();
            cboLangue.SelectedIndex = cboLangueAbrev.SelectedIndex;
            cboAutorisation.SelectedItem = sdr["CAUTORISATION"] == null ? "NON" : sdr["CAUTORISATION"].ToString();

            if (sdr["VPERPERMI"].ToString().Contains("B")) chkB.Checked = true;
            if (sdr["VPERPERMI"].ToString().Contains("C")) chkC.Checked = true;
            if (sdr["VPERPERMI"].ToString().Contains("E")) chkE.Checked = true;

            chkGrp.Checked = Convert.ToBoolean(sdr["BGROUPE"]) == false ? false : true;

            // gestion des différents mode de plannification (35h/5J(O) ou 40h/5J(L) ou 39h/5J(N) ou 35h/4J)
            chkPoste35.Checked = sdr["CPERPOSTE"].ToString() == "O" ? true : false;
            chkPoste40.Checked = sdr["CPERPOSTE"].ToString() == "L" ? true : false;
            chkPoste354.Checked = sdr["CPERPOSTE"].ToString() == "A" ? true : false;
            chkVisuPlanning.Checked = !Convert.ToBoolean(sdr["BVISUPLANNING"]);

            bNonConcurrenceLoaded = ChkNonCuccuren.Checked = Convert.ToBoolean(sdr["BPERNONCONCU"]);

            ChkObj.Checked = Convert.ToBoolean(sdr["BPEROBJ"]);

            // Ajout d info pour la logiciel de paye Pegase
            TxtNomJF.Text = Utils.BlankIfNull(sdr["VPERNOMJEUNF"]);
            TxtSectSal.Text = Utils.BlankIfNull(sdr["VPERSECTSAL"]);
            TxtNSecu.Text = Utils.BlankIfNull(sdr["VPERNUMSECU"]);
            TxtComNaiss.Text = Utils.BlankIfNull(sdr["VPERCOMNAISS"]);

            if (sdr["NPERPAYSNAISS"] != DBNull.Value)
              CboPaysNaiss.SetItemData(sdr["NPERPAYSNAISS"].ToString());

            TxtNational.Text = Utils.BlankIfNull(sdr["VPERNATIONAL"]);
            txtNCartSej.Text = Utils.BlankIfNull(sdr["VPERNCARDSEJ"]);
            if (sdr["DPEREXPCARDSEJ"] != DBNull.Value) txtDateCarteSejour.DateTime = (DateTime)sdr["DPEREXPCARDSEJ"];
            txtMontantPret.Text = Utils.BlankIfNull(sdr["VPERDELCARDSEJ"]);

            if (sdr["NTYPTRAV"] != DBNull.Value)
              cboTypeTrav.SetItemData(sdr["NTYPTRAV"].ToString());
            else
              cboTypeTrav.SetItemData("1");

            txtLibEmploi.Text = Utils.BlankIfNull(sdr["VPERLIBEMPLOI"]);
            TxtCINSEE.Text = Utils.BlankIfNull(sdr["VPERCODINSEE"]);
            TxtCConvColl.Text = Utils.BlankIfNull(sdr["VPERCODCONVCOLL"]);
            TxtCConvCollDAD.Text = Utils.BlankIfNull(sdr["VPERCODCONVDADS"]);
            TxtCBTP.Text = Utils.BlankIfNull(sdr["VPERCODBTP"]);
            txtTxAT.Text = Utils.BlankIfNull(sdr["VPERTXAT"]);
            txtTxTrans.Text = Utils.BlankIfNull(sdr["VPERTXTRANSP"]);
            txtcptDIF.Text = Utils.BlankIfNull(sdr["VPERCPTDIF"]);
            txtNbEnf.Text = Utils.BlankIfNull(sdr["VPERNBENF"]);

                        if(sdr["DPERENTRETANNUELLAST"] != DBNull.Value) DT_DPERENTRETANNUELLAST.DateTime = (DateTime)sdr["DPERENTRETANNUELLAST"];
                        if(sdr["DPERENTRETANNUELPRO"] != DBNull.Value) DT_DPERENTRETANNUELPRO.DateTime = (DateTime)sdr["DPERENTRETANNUELPRO"];
                        if(sdr["DPERBILANENTRETANNUELPRO"] != DBNull.Value) DT_DPERBILANENTRETANNUELPRO.DateTime = (DateTime)sdr["DPERBILANENTRETANNUELPRO"];

                        // type vehicule
                        cboTypeVeh.SetItemData(Convert.ToInt32(Utils.ZeroIfNull(sdr["NIDTYPEVEH"])));
            chkDemandeAutoSaisieKMs.Checked = (Utils.ZeroIfNull(sdr["BPERDEMANDEAUTOKMS"]) == 1);

            int index = Convert.ToInt32(ModuleData.ExecuteScalarInt($"select NPAYSNUM from TPAYS where VPAYSNOM = '{sdr["VPERPAYS"]}'"));
            cboPays.SetItemData(index.ToString());

            cboVille.SelectedItem = Utils.BlankIfNull(sdr["VPERVIL"]);

            if (cboVille.SelectedIndex == -1)
            {
              cboVille.Items.Add(sdr["VPERVIL"]);
              cboVille.SelectedItem = sdr["VPERVIL"].ToString();

              //cboPays.Items.Add(sdr["VPERPAYS"]);
              index = Convert.ToInt32(ModuleData.ExecuteScalarInt($"select NPAYSNUM from TPAYS where VPAYSNOM = '{sdr["VPERPAYS"]}'"));
              cboPays.SetItemData(index.ToString());
            }

            apiComboRegion.Init(MozartDatabase.cnxMozart, $"select NREGCOD, VDEPLIB from TREF_REG where npaysnum = {cboPays.GetItemData()} order by VDEPLIB", "NREGCOD", "VDEPLIB", new List<string>() { Resources.col_Num, Resources.col_Nom }, 150, 500, true);
            apiComboRegion.SetItemData(Convert.ToInt32(sdr["NREGCOD"]));

            if (sdr["VPERIMAGE"].ToString() != "" && sdr["VPERIMAGE"] != null)
            {
              strImage = ModuleData.RechercheParam("REP_PHOTOS_PER", GetNomSocieteTemp()) + sdr["VPERIMAGE"].ToString();
              ImageEnModification(sdr["VPERIMAGE"].ToString());
            }
            else
              strImage = "";

            switch (Convert.ToInt32(sdr["NPERTYPPOSTE"]))
            {
              case 0:
                ChkTypePoste0.Checked = false;
                ChkTypePoste1.Checked = false;
                break;
              case 1:
                ChkTypePoste0.Checked = true;
                ChkTypePoste1.Checked = false;
                break;
              case 2:
                ChkTypePoste0.Checked = false;
                ChkTypePoste1.Checked = true;
                break;
              case 3:
                ChkTypePoste0.Checked = true;
                ChkTypePoste1.Checked = true;
                break;
              default:
                break;
            }

            // POSTE
            if (ChkTypePoste0.Checked == true)
            {
              CboClientPoste.SetItemData(sdr["TPERPOSTE_NCLINUM"].ToString());
              ModuleData.RemplirCombo(CboSitePoste, $"SELECT TSIT.NSITNUM, TSIT.VSITNOM FROM TSIT WITH (NOLOCK) WHERE TSIT.CSITACTIF = 'O' AND TSIT.NCLINUM = {sdr["TPERPOSTE_NCLINUM"]}");
              CboSitePoste.ValueMember = "NSITNUM";
              CboSitePoste.DisplayMember = "VSITNOM";
              CboSitePoste.SetItemData(sdr["TPERPOSTE_NSITNUM"].ToString());
            }
            Label550.Visible = Label551.Visible = CboClientPoste.Visible = CboSitePoste.Visible = ChkTypePoste0.Checked;

            ChkManipFluide.Checked = Convert.ToBoolean(sdr["BPERMANIPFLUIDE"]);
            ChkTick_Rest.Checked = Convert.ToBoolean(sdr["BPER_TICK_REST"]);

            Chk_Restri.Checked = Convert.ToBoolean(sdr["BPER_RESTRICTION"]);
            ChkVerifBalPes.Checked = Convert.ToBoolean(sdr["BPERBALANCE"]);

                        ChkEMASSET.Checked = Convert.ToBoolean(sdr["BAPPLIEMASSET"]);

                        // Remplir la grille d'historique
                        string sSQL = $"SELECT NPERNUM, DPERHDAT, VPERHQUI, VPERHOBJET, VPERHLIB FROM TPERHISTO WHERE NPERNUM = {miNumPer} ORDER BY DPERHDAT DESC";
            grdHisto.LoadData(dtHisto, MozartDatabase.cnxMozart, sSQL);
            grdHisto.GridControl.DataSource = dtHisto;

            //Remplir la grille des avantages en nature
            sSQL = $"SELECT NPRIMNUM, NPERNUM, VPRIMDESC, NPRIMMONTANT, BPRIMECC, VPRIMREFTPS FROM TPRIMES WHERE NPERNUM = {miNumPer} AND BPRIMECC = 'A'";
            daAutreAvtg = new SqlDataAdapter(sSQL, MozartDatabase.cnxMozart);
            dtAutreAvtg.Clear();
            daAutreAvtg.Fill(dtAutreAvtg);
            grdAutreAvtg.GridControl.DataSource = dtAutreAvtg;

            calcPrimes();

            daEnf = new SqlDataAdapter($"SELECT NENFNUM, NPERNUM, VENFNOM, VENFPRE, DENFDAT, VENFGENR FROM TPERENF WHERE NPERNUM = {miNumPer}", MozartDatabase.cnxMozart);
            dtEnf.Clear();
            daEnf.Fill(dtEnf);
            grdEnf.GridControl.DataSource = dtEnf;

            if (bGridOk == false)
            {
              FormatGridHisto();
              FormatGridEnfants();
              FormatGridAutreAvtg();
              bGridOk = true;
            }

            // si la personne est un technicien, la saisie des compétences preventives est possible
            // ainsi que la saisie du contremaitre
            if (null == cboMaitre.DataSource())
              cboMaitre.Init(MozartDatabase.cnxMozart, "[api_sp_ListeCMAndChefGRP]", "NPERNUM", "Column1", new List<string>() { Resources.col_Num, Resources.col_Nom }, 150, 500, bHideFirstColumn: true);

            if (apiComboType.GetText() != "Technicien")
              cmdContrat.Enabled = lblContremaitre.Visible = cboMaitre.Visible = CmdDepConMait.Enabled = false;
            else
            {
              try
              {
                CmdDepConMait.Enabled = false;
                cboMaitre.SetItemData(Convert.ToInt32(sdr["NPERCONTREMAITRE"]));
                if (Convert.ToInt32(sdr["NPERCONTREMAITRE"]) == miNumPer)
                  CmdDepConMait.Enabled = true;
              }
              catch (Exception)
              {
                if ((cboMaitre.GetText() == "" || cboMaitre.GetText() == null) && mFormParent != "frmGestPersArch")
                  MessageBox.Show(Resources.msg_AffecterContremaitreTechnicien, Program.AppTitle, MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
              }
            }

            cboTuteur.Init(MozartDatabase.cnxMozart, $"SELECT NPERNUM, (VPERNOM + ' ' + VPERPRE) AS NOMPRE FROM TPER WHERE VSOCIETE = '{GetNomSocieteTemp()}' AND CPERACTIF = 'O' ORDER BY NOMPRE",
                                           "NPERNUM", "NOMPRE", new List<string>() { Resources.col_Num, Resources.col_Nom }, 150, 500, bHideFirstColumn: true);
            cboTuteur.SetItemData((int)Utils.ZeroIfNull(sdr["NPERTUTEUR"]));

            cboPlanificateur.Init(MozartDatabase.cnxMozart, $"SELECT NPERNUM, (VPERNOM + ' ' + VPERPRE) AS NOMPRE FROM TPER WHERE NSERNUM=12 AND VSOCIETE = '{GetNomSocieteTemp()}' AND CPERACTIF = 'O' " +
                                                  $"ORDER BY NOMPRE", "NPERNUM", "NOMPRE", new List<string>() { Resources.col_Num, Resources.col_Nom }, 150, 50, bHideFirstColumn: true);

            cboPlanificateur.SetItemData((int)Utils.ZeroIfNull(sdr["NPERPLANIFICATEUR"]));

            cboRRET.Init(MozartDatabase.cnxMozart, $"SELECT NPERNUM, VPERNOM + ' ' + VPERPRE as NOMPRE FROM TPER WHERE VSOCIETE = '{MozartParams.NomSociete}' AND CPERACTIF = 'O' " +
                                                  $"ORDER BY NOMPRE", "NPERNUM", "NOMPRE", new List<string>() { Resources.col_Num, Resources.col_Nom }, 150, 50, bHideFirstColumn: true);

            cboRRET.SetItemData(Convert.ToInt32(Utils.ZeroIfBlank(sdr["NPERRRET"])));
            // Gestion couleur bouton
            int i = Convert.ToInt32(ModuleData.ExecuteScalarInt($"exec api_sp_NbCourPers {miNumPer},'{GetNomSocieteTemp()}'"));

            cmdCourrier.BackColor = i > 0 ? MozartColors.ColorH80FFFF : MozartColors.ColorH8000000F;

            // gestion des droits sur les données restreintes
            // on affiche pas les informations de salaires
            Frame6.Visible = Frame11.Visible = cmdVisualiser.Visible = cmdFichePerso.Visible = cmdCourrier.Visible = Convert.ToBoolean(sdr["DROITSAL"]);
                                                
                        if (ReloadEMASSET) GetCheckedEMASSET(txtMailPro.Text);
                    }
        }
      }
      catch (Exception ex)
      {
        MZUtils.displayError(MethodBase.GetCurrentMethod().Name, ex);
      }
    }

        private async void GetCheckedEMASSET(string UserMailPro)
        {

            if(UserMailPro == "" & ChkEMASSET.Checked)
            {
                MessageBox.Show("Il faut saisir une adresse mail pro pour effectuer l'affectation à EMASSET"); 
                ChkEMASSET.Checked = false;
                return;
            }

            string baseUrl = $"https://{MozartParams.urlApiMozaris}/EntraId/isAssigned";            

            var parameters = new Dictionary<string, string>
                            {
                                { "userName", UserMailPro},
                                { "applicationName", "EMASSET" }
                            };

            string response = await CApiMozarisEntraID.GetFromApiWithBasicAuthAndParams(baseUrl, parameters, MozartParams.userNameApiMozaris, MozartParams.pwdApiMozaris);

            if(bool.TryParse(response, out bool isAssigned))
                {
                // If the response is a valid boolean, set the checkbox accordingly
                ChkEMASSET.Checked = isAssigned;
            }
            else
            {
                // If the response is not a valid boolean, handle the error accordingly
                //MessageBox.Show("Erreur sur l'accès EMASSET : " + response, Program.AppTitle, MessageBoxButtons.OK, MessageBoxIcon.Error);
            }    

        }

        private async void SetCheckedEMASSET(bool bChecked, string UserMailPro)
        {

            if (UserMailPro == "")
            {
                ChkEMASSET.Checked = false;
                return;
            }
           
            //on teste si le user est déjà affecté à l'application EMASSET         
            string baseUrlGet = $"https://{MozartParams.urlApiMozaris}/EntraId/isAssigned";
            var parameters = new Dictionary<string, string>
                            {
                                { "userName", UserMailPro},
                                { "applicationName", "EMASSET" }
                            };
            string response = await CApiMozarisEntraID.GetFromApiWithBasicAuthAndParams(baseUrlGet, parameters, MozartParams.userNameApiMozaris, MozartParams.pwdApiMozaris);
            bool isAssigned;
            switch (bChecked)
            {
                case true:                                                    

                    if (bool.TryParse(response, out isAssigned))
                    {
                        // If the response is a valid boolean, set the checkbox accordingly
                        if (isAssigned) return;
                        //continue to assign the user to the application
                        string urlPost = $"https://{MozartParams.urlApiMozaris}/EntraId/assign";                        
                        string jsonBody = $"{{\"userName\": \"{UserMailPro}\",  \"applicationName\": \"EMASSET\"}}";
                        string result = await CApiMozarisEntraID.PostToApiWithBasicAuth(urlPost, jsonBody, MozartParams.userNameApiMozaris, MozartParams.pwdApiMozaris);
                        //MessageBox.Show(result);
                        if (result != "OK")
                        {
                            ChkEMASSET.Checked = bChecked;
                        }
                    }
                    break;
                case false:                   

                    if (bool.TryParse(response, out isAssigned))
                    {
                        // If the response is a valid boolean, set the checkbox accordingly
                        if (isAssigned == false) return;
                        //continue to assign the user to the application
                        string urlPost = $"https://{MozartParams.urlApiMozaris}/EntraId/remove";
                        string jsonBody = $"{{\"userName\": \"{UserMailPro}\",  \"applicationName\": \"EMASSET\"}}";
                        string result = await CApiMozarisEntraID.DeleteToApiWithBasicAuth(urlPost, jsonBody, MozartParams.userNameApiMozaris, MozartParams.pwdApiMozaris);
                        //MessageBox.Show(result);
                        if(result != "OK")
                        {
                            ChkEMASSET.Checked = bChecked;
                        }
                    }
                    break;
                default:
                    break;
            }
        }

        private async void UpdateEntraObjectId(string UserMailPro, int npernum)
        {
            try
            {
                if (UserMailPro != "")
                {
                    string baseUrl = $"https://{MozartParams.urlApiMozaris}/EntraId/GetPrincipalId";

                    var parameters = new Dictionary<string, string>
                            {
                                { "userName", UserMailPro}
                            };

                    string response = await CApiMozarisEntraID.GetFromApiWithBasicAuthAndParams(baseUrl, parameters, MozartParams.userNameApiMozaris, MozartParams.pwdApiMozaris);

                    if (response!="")
                    {
                        // If the response is a valid boolean, set the checkbox accordingly
                        //MessageBox.Show("update objectId : " + response, Program.AppTitle, MessageBoxButtons.OK, MessageBoxIcon.Information);

                        SqlCommand sqlCommand = new SqlCommand("[api_sp_Personnel_UpdateAccessApplications]", MozartDatabase.cnxMozart)
                        {
                            CommandType = CommandType.StoredProcedure,
                            Parameters =
                            {
                                new SqlParameter("@P_NPERNUM", npernum),
                                new SqlParameter("@P_ENTRA_ID_PRINCIPAL_ID", response)
                            }
                        };
                        sqlCommand.ExecuteNonQuery();

                    }
                    else
                    {
                        // If the response is not a valid boolean, handle the error accordingly
                        //MessageBox.Show("Erreur sur l'accès EMASSET : " + response, Program.AppTitle, MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }
                }
            }
            catch (Exception ex)
            {
                MZUtils.displayError(MethodBase.GetCurrentMethod().Name, ex);
            }
        }

        public void Enregistrer()
    {
      try
      {
        // Création ou la modification, c'est la proc stock qui gère
        // création d'une commande
        using (SqlCommand cmd = new SqlCommand("api_sp_CreationPersonnel2", MozartDatabase.cnxMozart))
        {
          cmd.CommandType = CommandType.StoredProcedure;

          // liste des paramètres
          SqlCommandBuilder.DeriveParameters(cmd);

          cmd.Parameters["@iNum"].Value = miNumPer; //0 si création
          cmd.Parameters["@vNom"].Value = txtNom.Text;
          cmd.Parameters["@vPrenom"].Value = txtprenom.Text;
          cmd.Parameters["@vCiv"].Value = cboCiv.SelectedItem.ToString();
          cmd.Parameters["@vSignature"].Value = txtSignature.Text;
          cmd.Parameters["@vAd1"].Value = txtAD1.Text;
          cmd.Parameters["@vAd2"].Value = txtAD2.Text;
          cmd.Parameters["@vCp"].Value = txtCP.Text;
          cmd.Parameters["@vVille"].Value = cboPays.SelectedItem.ToString() == "FRANCE" ? cboVille.SelectedItem.ToString() : txtVille.Text;
          cmd.Parameters["@vPays"].Value = ((DataRowView)cboPays.SelectedItem).Row.ItemArray[1].ToString();
          cmd.Parameters["@vTel"].Value = txtTel.Text;
          if (txtNumStd.Text != "") cmd.Parameters["@nTelStd"].Value = txtNumStd.Text;
          cmd.Parameters["@vFax"].Value = txtFax.Text;
          cmd.Parameters["@vPort"].Value = txtPort.Text;
          cmd.Parameters["@vMail"].Value = txtMail.Text;
          cmd.Parameters["@vMailpro"].Value = txtMailPro.Text;
          cmd.Parameters["@vType"].Value = apiComboType.GetItemData();
          cmd.Parameters["@nService"].Value = apiComboService.GetItemData(); //Code service
          cmd.Parameters["@nRegion"].Value = apiComboRegion.GetItemData(); //Code région
          cmd.Parameters["@nContrat"].Value = cboContrat.GetItemData();
          cmd.Parameters["@vCollege"].Value = (null == cboCollege.SelectedItem) ? "" : cboCollege.SelectedItem.ToString();
          cmd.Parameters["@vNiveau"].Value = txtNiveau.Text;
          cmd.Parameters["@vEchelon"].Value = txtEchelon.Text;
          cmd.Parameters["@vCategorie"].Value = txtCategorie.Text;
          cmd.Parameters["@vCoef"].Value = txtCoef.Text;
          cmd.Parameters["@vSociete"].Value = GetNomSocieteTemp();
          cmd.Parameters["@dEntree"].Value = txtDateEntree.Text; //champ obligatoire
          if (txtDateEntreeInt.Text != "") cmd.Parameters["@dEntreeInt"].Value = txtDateEntreeInt.Text;

          // Champs numériques
          if (txtNbHeures.EditValue != null)
          {
            if (txtNbHeures.EditValue.ToString() != "") cmd.Parameters["@nHeures"].Value = txtNbHeures.EditValue;
          }
          if (txtSalaire.Text != "") cmd.Parameters["@fSalaire"].Value = txtSalaire.Text;
          if (txtAvance.Text != "") cmd.Parameters["@fAvance"].Value = txtAvance.Text;
          if (txtNbMoisContractuel.Text != "") cmd.Parameters["@nbMoisCC"].Value = txtNbMoisContractuel.Text;
          if (txtSalaireAnnuel.Text != "") cmd.Parameters["@fSalaireAnnuel"].Value = txtSalaireAnnuel.Text;
          if (txtCoutHor.Text != "") cmd.Parameters["@fCoutHor"].Value = txtCoutHor.Text;

          // Champs dates
          if (txtDateNaissance.Text != "") cmd.Parameters["@dNaissance"].Value = txtDateNaissance.Text;
          if (txtDateSortie.Text != "") cmd.Parameters["@dSortie"].Value = txtDateSortie.Text;
          if (txtDateVisite.Text != "") cmd.Parameters["@dVisiteMed"].Value = txtDateVisite.Text;
          if (txtDateInfirmier.Text != "") cmd.Parameters["@dInfirmier"].Value = txtDateInfirmier.Text;
          if (txtDateAvance.Text != "") cmd.Parameters["@dAvance"].Value = txtDateAvance.Text;
          if (txtDateRQTH.Text != "") cmd.Parameters["@dHabilitation"].Value = txtDateRQTH.Text;
          if (txtDateRestriction.Text != "") cmd.Parameters["@dRappel"].Value = txtDateRestriction.Text;
          if (txtDatePret.Text != "") cmd.Parameters["@dPermis"].Value = txtDatePret.Text;
          if (cboSituation.SelectedIndex.ToString() != "") cmd.Parameters["@NSitFam"].Value = cboSituation.GetItemData();

          //  gestion des permissions
          string permi = "";
          if (chkB.Checked) permi = "B,";
          if (chkC.Checked) permi += "C,";
          if (chkE.Checked) permi += "E,";
          if (Strings.Right(permi, 1) == ",") permi = Strings.Left(permi, permi.Length - 1);
          cmd.Parameters["@vPermi"].Value = permi;
          cmd.Parameters["@vGroupe"].Value = chkGrp.Checked;
          // gestion des différents types de plannification des personnes (35h/5J(O) ou 40h/5J(L) ou 39h/5J(N) ou 35h/4J))
          cmd.Parameters["@vPoste"].Value = chkPoste35.Checked == true ? "O" : (chkPoste40.Checked == true ? "L" : (chkPoste354.Checked == true ? "A" : "N"));
          cmd.Parameters["@bVisuPlanning"].Value = !chkVisuPlanning.Checked;
          cmd.Parameters["@iMaitre"].Value = cboMaitre.GetItemData();
          cmd.Parameters["@iTuteur"].Value = cboTuteur.GetItemData();
          cmd.Parameters["@iPlanificateur"].Value = cboPlanificateur.GetItemData();
          cmd.Parameters["@irret"].Value = cboRRET.GetItemData();
          cmd.Parameters["@bpernoncurren"].Value = ChkNonCuccuren.Checked;
          cmd.Parameters["@bperobj"].Value = ChkObj.Checked;

          // modif mco$
          if (TxtSectSal.Text != "") cmd.Parameters["@vSectSal"].Value = TxtSectSal.Text;
          if (TxtNSecu.Text != "") cmd.Parameters["@vNumSecu"].Value = TxtNSecu.Text;
          if (TxtNomJF.Text != "") cmd.Parameters["@vNomJeunF"].Value = TxtNomJF.Text;
          if (TxtComNaiss.Text != "") cmd.Parameters["@vComNaiss"].Value = TxtComNaiss.Text;
          if (CboPaysNaiss.SelectedIndex.ToString() != "") cmd.Parameters["@nPaysNaiss"].Value = CboPaysNaiss.GetItemData();
          if (TxtNational.Text != "") cmd.Parameters["@vNational"].Value = TxtNational.Text;
          if (txtNCartSej.Text != "") cmd.Parameters["@vCardSej"].Value = txtNCartSej.Text;
          if (txtDateCarteSejour.Text != "") cmd.Parameters["@dExpSEJ"].Value = txtDateCarteSejour.Text;
          if (txtMontantPret.Text != "") cmd.Parameters["@vDelCardSej"].Value = txtMontantPret.Text;
          cmd.Parameters["@nTypTrav"].Value = cboTypeTrav.GetItemData();
          if (txtLibEmploi.Text != "") cmd.Parameters["@vLibEmploi"].Value = txtLibEmploi.Text;
          if (TxtCINSEE.Text != "") cmd.Parameters["@vCodINSEE"].Value = TxtCINSEE.Text;
          if (TxtCConvColl.Text != "") cmd.Parameters["@vCodConvColl"].Value = TxtCINSEE.Text;
          if (TxtCConvCollDAD.Text != "") cmd.Parameters["@vCodConDADS"].Value = TxtCConvCollDAD.Text;
          if (txtTxAT.Text != "") cmd.Parameters["@vTxAT"].Value = txtTxAT.Text;
          if (txtTxTrans.Text != "") cmd.Parameters["@vTxTransp"].Value = txtTxTrans.Text;
          if (txtcptDIF.Text != "") cmd.Parameters["@vCptDIF"].Value = txtcptDIF.Text;
          if (TxtCBTP.Text != "") cmd.Parameters["@vCodBTP"].Value = TxtCBTP.Text;
          if (txtNbEnf.Text != "") cmd.Parameters["@vNbEnf"].Value = txtNbEnf.Text;
          if (strImage != (ModuleData.RechercheParam("REP_PHOTOS_PER", MozartParams.NomSociete) + txtImgFichier.Text)) EnregistrerImage();
          cmd.Parameters["@vimage"].Value = txtImgFichier.Text;
          cmd.Parameters["@vtypeposte"].Value = ReturnNPERTYPEPOSTE();

          if (ChkTypePoste0.Checked)
          {
            if (CboClientPoste.GetItemData() != 0)
              cmd.Parameters["@perclientposte"].Value = CboClientPoste.GetItemData();

            if (CboSitePoste.GetItemData() != 0)
              cmd.Parameters["@persiteposte"].Value = CboSitePoste.GetItemData();
          }
          else
          {
            cmd.Parameters["@perclientposte"].Value = null;
            cmd.Parameters["@persiteposte"].Value = null;
          }

          cmd.Parameters["@NIDTYPEVEH"].Value = cboTypeVeh.GetItemData();
          cmd.Parameters["@BPERDEMANDEAUTOKMS"].Value = chkDemandeAutoSaisieKMs.Checked ? 1 : 0;
          cmd.Parameters["@BPERMANIPFLUIDE"].Value = ChkManipFluide.Checked;

          // langue
          cmd.Parameters["@vlangueabr"].Value = (null == cboLangueAbrev.SelectedItem || cboLangueAbrev.SelectedItem.ToString() == "") ? "FR" : cboLangueAbrev.Text;
          cmd.Parameters["@vAutorisation"].Value = cboAutorisation.SelectedItem?.ToString();
          cmd.Parameters["@BPER_TICK_REST"].Value = ChkTick_Rest.Checked ? 1 : 0;
          cmd.Parameters["@BPER_RESTRICTION"].Value = Chk_Restri.Checked ? 1 : 0;
          cmd.Parameters["@BPER_BALPES"].Value = ChkVerifBalPes.Checked ? 1 : 0;
                    cmd.Parameters["@BPER_EMASSET"].Value = ChkEMASSET.Checked ? 1 : 0;

                    cmd.Parameters["@vcontact"].Value = txtContact.Text;
          cmd.Parameters["@vtelcontact"].Value = txtTelContact.Text;

                    if (DT_DPERENTRETANNUELLAST.Text != "") cmd.Parameters["@DPERENTRETANNUELLAST"].Value = DT_DPERENTRETANNUELLAST.Text;
                    if (DT_DPERBILANENTRETANNUELPRO.Text != "") cmd.Parameters["@DPERENTRETANNUELPRO"].Value = DT_DPERBILANENTRETANNUELPRO.Text;
                    if (DT_DPERBILANENTRETANNUELPRO.Text != "") cmd.Parameters["@DPERBILANENTRETANNUELPRO"].Value = DT_DPERBILANENTRETANNUELPRO.Text;

                    cmd.ExecuteNonQuery();
          miNumPer = (int)cmd.Parameters[0].Value;

                    SetCheckedEMASSET(ChkEMASSET.Checked, txtMailPro.Text);

                    // grille grdEnf
                    if (null != daEnf && null != daEnf.SelectCommand)
          {
            cbEnf = new SqlCommandBuilder(daEnf);
            daEnf.InsertCommand = cbEnf.GetInsertCommand();
            daEnf.UpdateCommand = cbEnf.GetUpdateCommand();
            daEnf.DeleteCommand = cbEnf.GetDeleteCommand();
            foreach (DataRow row in dtEnf.Rows)
            {
              if (row.RowState == DataRowState.Added)
                row["NPERNUM"] = miNumPer;
            }
            int res = daEnf.Update(dtEnf);
          }

          // grille autre avantages
          if (null != daAutreAvtg && null != daAutreAvtg.SelectCommand)
          {
            cbAutreAvtg = new SqlCommandBuilder(daAutreAvtg);
            daAutreAvtg.InsertCommand = cbAutreAvtg.GetInsertCommand();
            daAutreAvtg.UpdateCommand = cbAutreAvtg.GetUpdateCommand();
            daAutreAvtg.DeleteCommand = cbAutreAvtg.GetDeleteCommand();
            foreach (DataRow row in dtAutreAvtg.Select(null, null, DataViewRowState.Added))
            {
              row["NPERNUM"] = miNumPer;
              row["BPRIMECC"] = "A";
            }
            int res = daAutreAvtg.Update(dtAutreAvtg);
          }
        }
      }
      catch (Exception ex)
      {
        MZUtils.displayError(MethodBase.GetCurrentMethod().Name, ex);
      }
    }

    private int ReturnNPERTYPEPOSTE()
    {
      if (!ChkTypePoste0.Checked && !ChkTypePoste1.Checked) return 0;
      if (ChkTypePoste0.Checked && !ChkTypePoste1.Checked) return 1;
      if (!ChkTypePoste0.Checked && ChkTypePoste1.Checked) return 2;
      if (ChkTypePoste0.Checked && ChkTypePoste1.Checked) return 3;
      return 0;
    }

    private void txtCP_TextChanged(object sender, EventArgs e)
    {
      if ((txtCP.Text.Length == 5) && ((DataRowView)cboPays.SelectedItem).Row.ItemArray[1].ToString() == "FRANCE")
        ModuleMain.RechercheCommune(txtCP.Text, cboVille);
    }

    private void cboPays_SelectedIndexChanged(object sender, EventArgs e)
    {
      cboVille.Visible = cmdRecherche.Visible = ((System.Data.DataRowView)cboPays.SelectedItem).Row.ItemArray[1].ToString() == "FRANCE";
      txtVille.Visible = ((DataRowView)cboPays.SelectedItem).Row.ItemArray[1].ToString() != "FRANCE";
    }

    private void cboVille_SelectedIndexChanged(object sender, EventArgs e)
    {
      txtVille.Text = cboVille.SelectedItem.ToString();
    }

    private void txtFax_Leave(object sender, EventArgs e)
    {
      txtFax.Text = ModuleMain.FormatTel(txtFax.Text);
    }

    private void txtMail_Leave(object sender, EventArgs e)
    {
      txtMail.Text = ModuleMain.FormatMail(txtMail).ToString();
    }

    private void txtNom_Leave(object sender, EventArgs e)
    {
      txtNom.Text = txtNom.Text.ToUpper();
    }

    private void txtPort_Leave(object sender, EventArgs e)
    {
      txtPort.Text = ModuleMain.FormatTel(txtPort.Text);
    }

    private void txtTel_Leave(object sender, EventArgs e)
    {
      txtTel.Text = ModuleMain.FormatTel(txtTel.Text);
    }

    private void txtVille_Leave(object sender, EventArgs e)
    {
      txtVille.Text = txtVille.Text.ToUpper();
    }

    public void FormatGridHisto()
    {
      try
      {
        grdHisto.AddColumn("nPerNum", "NPERNUM", 0);
        grdHisto.AddColumn(Resources.col_Date, "DPERHDAT", 1000, "Date");
        grdHisto.AddColumn("Qui", "VPERHQUI", 900);
        grdHisto.AddColumn(Resources.col_Objet, "VPERHOBJET", 1500);
        grdHisto.AddColumn(MZCtrlResources.col_libelle, "VPERHLIB", 2400);

        grdHisto.InitColumnList();
      }
      catch (Exception ex)
      {
        MZUtils.displayError(MethodBase.GetCurrentMethod().Name, ex);
      }
    }

    private void FormatGridAutreAvtg()
    {
      try
      {
        grdAutreAvtg.AddColumn("nPrimNum", "NPRIMNUM", 0);
        grdAutreAvtg.AddColumn("nPerNum", "NPERNUM", 0);
        grdAutreAvtg.AddColumn(Resources.col_Description, "VPRIMDESC", 800);
        grdAutreAvtg.AddColumn(Resources.col_Montant, "NPRIMMONTANT", 300, "Currrency", 2);
        grdAutreAvtg.AddColumn(Resources.col_ReferenceDeTemps, "VPRIMREFTPS", 800);
        grdAutreAvtg.AddColumn("bPrimeCC", "BPRIMECC", 0);
        grdAutreAvtg.InitColumnList();

        grdAutreAvtg.DelockColumn("VPRIMDESC");
        grdAutreAvtg.DelockColumn("NPRIMMONTANT");
        grdAutreAvtg.DelockColumn("VPRIMREFTPS");
        grdAutreAvtg.dgv.OptionsView.NewItemRowPosition = NewItemRowPosition.Bottom;
        grdAutreAvtg.dgv.OptionsBehavior.AllowAddRows = DevExpress.Utils.DefaultBoolean.True;
        grdAutreAvtg.dgv.OptionsBehavior.AllowDeleteRows = DevExpress.Utils.DefaultBoolean.True;
      }
      catch (Exception ex)
      {
        MZUtils.displayError(MethodBase.GetCurrentMethod().Name, ex);
      }
    }

    public void FormatGridEnfants()
    {
      try
      {
        grdEnf.AddColumn("nEnfNum", "NENFNUM", 0);
        grdEnf.AddColumn("nPerNum", "NPERNUM", 0);
        grdEnf.AddColumn(Resources.col_Nom, "VENFNOM", 400);
        grdEnf.AddColumn(Resources.col_Prenom, "VENFPRE", 400);
        grdEnf.AddColumn(Resources.col_naissance, "DENFDAT", 300);
        grdEnf.AddColumn(Resources.col_genre, "VENFGENR", 50);
        grdEnf.InitColumnList();

        grdEnf.DelockColumn("VENFNOM");
        grdEnf.DelockColumn("VENFPRE");
        grdEnf.DelockColumn("DENFDAT");
        grdEnf.DelockColumn("VENFGENR");
        grdEnf.dgv.OptionsView.NewItemRowPosition = NewItemRowPosition.Bottom;
        grdEnf.dgv.OptionsBehavior.AllowAddRows = DevExpress.Utils.DefaultBoolean.True;
        grdEnf.dgv.OptionsBehavior.AllowDeleteRows = DevExpress.Utils.DefaultBoolean.True;
      }
      catch (Exception ex)
      {
        MZUtils.displayError(MethodBase.GetCurrentMethod().Name, ex);
      }
    }

    private void EnregistrerImage()
    {
      try
      {
        if (CommonDialog1.FileName == "") return;

        long lcount = 0;

        // Récupération compteur et mise à jour dans la table
        using (SqlCommand cmd = new SqlCommand("api_sp_GetCpt", MozartDatabase.cnxMozart))
        {
          cmd.CommandType = CommandType.StoredProcedure;

          // liste des paramètres
          SqlCommandBuilder.DeriveParameters(cmd);

          cmd.Parameters["@cElt"].Value = "IMGPER";
          cmd.Parameters["@iCpt"].Value = 0;
          cmd.ExecuteNonQuery();
          lcount = (int)cmd.Parameters["@iCpt"].Value;
        }

        string[] ts = txtImgFichier.Text.Split('.');
        txtImgFichier.Text = $"PER_{miNumPer}_{ts[0].Replace(" ", "_")}_{lcount}.{ts[1]}";

        // Recopier le fichier sélectionné sur le serveur
        File.Copy(CommonDialog1.FileName, ModuleData.RechercheParam("REP_PHOTOS_PER", MozartParams.NomSocieteTemp) + txtImgFichier.Text, true);

        // suppression de l'ancienne image si elle existe !  VL 11/06/04)
        if (strImage != "") File.Delete(strImage);

        strImage = ModuleData.RechercheParam("REP_PHOTOS_PER", MozartParams.NomSocieteTemp) + txtImgFichier;
      }
      catch (Exception ex)
      {
        MZUtils.displayError(MethodBase.GetCurrentMethod().Name, ex);
      }
    }

    private void Image1_DoubleClick(object sender, EventArgs e)
    {
      if (Utils.BlankIfNull(Image1.Tag).ToString() == "OK")
      {
        frmxVisuImg f = new frmxVisuImg();
        f.msImage = strImage;
        f.ShowDialog();
      }
    }

    private void cmdImgOpen_Click(object sender, EventArgs e)
    {
      try
      {
        // Attribue à CancelError la valeur True
        CommonDialog1.ShowDialog();
        CommonDialog1.Title = Resources.msg_select_image_file;

        if (Strings.InStr(CommonDialog1.FileName, "'") > 0)
        {
          MessageBox.Show("Le nom du fichier n'est pas conforme. Les simples côtes sont interdites.", Program.AppTitle, MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
          return;
        }

        // Afficher l'image
        Image1.Load(CommonDialog1.FileName);

        //  Affiche le nom du fichier sélectionné
        string[] ts = Strings.Split(CommonDialog1.FileName, @"\");
        txtImgFichier.Text = ts[ts.Length - 1];

        txtImgFichier.Text = Path.GetFileName(CommonDialog1.FileName);
        Image resized = ModuleMain.ScaleImage(Image1.Image, new Size(Image1.Width, Image1.Height));
        Image1.Image = resized;

        for (int i = 0; i < tFormatImg.Length; i++)
          if (tFormatImg[i] == Strings.Right(txtImgFichier.Text, 3).ToUpper())
            cboImgFormat.SelectedIndex = i;

        if (Strings.Right(txtImgFichier.Text, 3).ToUpper() == "JPG") cboImgFormat.SelectedIndex = 5;
      }
      catch (Exception ex)
      {
        MZUtils.displayError(MethodBase.GetCurrentMethod().Name, ex);
      }
    }

    private void ImageEnModification(string sFichier)
    {
      try
      {
        for (int i = 0; i < tFormatImg.Length; i++)
          if (tFormatImg[i] == Strings.Right(sFichier, 3).ToUpper()) cboImgFormat.SelectedIndex = i;

        if (Strings.Right(sFichier, 3).ToUpper() == "JPG") cboImgFormat.SelectedIndex = 5;
        txtImgFichier.Text = sFichier;
        Image1.Load(strImage);
      }
      catch (Exception ex)
      {
        MZUtils.displayError(MethodBase.GetCurrentMethod().Name, ex);
      }
    }

    private void cmdImgDel_Click(object sender, EventArgs e)
    {
      try
      {
        if (strImage == "") return;

        if (MessageBox.Show("Voulez-vous vraiment supprimer cette image ?", Program.AppTitle, MessageBoxButtons.YesNo, MessageBoxIcon.Question, MessageBoxDefaultButton.Button2) == DialogResult.Yes)
        {
          //suppression en base
          string strSQL = "UPDATE TPER SET VPERIMAGE='' WHERE NPERNUM=" + miNumPer;
          ModuleData.ExecuteNonQuery(strSQL);
        }

        //suppression physique du ficher
        if (strImage != "")
          File.Delete(strImage);

        //Init des var
        strImage = "";
        txtImgFichier.Text = "";
        Image1 = null;

      }
      catch (Exception ex)
      {
        MZUtils.displayError(MethodBase.GetCurrentMethod().Name, ex);
      }
    }

    private void cmdLangues_Click(object sender, EventArgs e)
    {
      frmSaisieLangPers f = new frmSaisieLangPers();
      f.miNumTech = miNumPer;
      f.Text += $"({txtNom.Text} {txtprenom.Text})";
      f.ShowDialog();
    }

    private void cmdFormation_Click(object sender, EventArgs e)
    {
      new frmListeFormation($"{txtNom.Text} {txtprenom.Text}").ShowDialog();
    }

    private void CmdDepConMait_Click(object sender, EventArgs e)
    {
      new frmSaisieDepContMait
      {
        miNumTech = miNumPer
      }.ShowDialog();
    }

    private void cmdCourrier_Click(object sender, EventArgs e)
    {
      Cursor = Cursors.WaitCursor;
      new frmListeCourrier
      {
        msNomPersonne = txtNom.Text
      }.ShowDialog();
      Cursor = Cursors.Default;
    }

    private void ChkTypePoste0_Click(object sender, EventArgs e)
    {
      apiCheckBox lTmpChkBox = (sender as apiCheckBox).Equals(ChkTypePoste0) ? ChkTypePoste1 : ChkTypePoste0;

      if (lTmpChkBox.Checked) lTmpChkBox.Checked = false;

      Label550.Visible = ChkTypePoste0.Checked;
      Label551.Visible = ChkTypePoste0.Checked;
      CboClientPoste.Visible = ChkTypePoste0.Checked;
      CboSitePoste.Visible = ChkTypePoste0.Checked;
    }

    private void CboClientPoste_Click(object sender, EventArgs e)
    {
      ModuleData.RemplirCombo(CboSitePoste, $"SELECT NSITNUM, VSITNOM FROM TSIT WITH(NOLOCK) WHERE CSITACTIF = 'O' AND NCLINUM = {CboClientPoste.GetItemData()}");
      CboSitePoste.ValueMember = "NSITNUM";
      CboSitePoste.DisplayMember = "VSITNOM";
    }

    private void CmdAffectChaffChantier_Click(object sender, EventArgs e)
    {
      if (miNumPer == 0) return;

      new frmSelectChaffChantier(miNumPer, txtNom.Text, txtprenom.Text).ShowDialog();
    }

    private void chkVisuPlanning_Click(object sender, EventArgs e)
    {
      if (!bPrem && chkVisuPlanning.Checked)
      {
        if ((int)ModuleData.ExecuteScalarInt($"api_sp_OKArchivage {miNumPer} ") > 0)
        {
          chkVisuPlanning.Checked = false;
          MessageBox.Show(Resources.msg_ArchPersonneActionNonSoldee + "\r\n"
                        + Resources.msg_chargeAffaire, Program.AppTitle, MessageBoxButtons.OK, MessageBoxIcon.Information);
        }
      }
    }

    private void Cmd_DetVeh_Click(object sender, EventArgs e)
    {
      if (miNumPer == 0) return;

      string sVeh = (string)ModuleData.ExecuteScalarString($"SELECT NVEHNUM FROM TVEHICULES WHERE NPERNUM = {miNumPer}");
      if (sVeh == "")
        MessageBox.Show(Resources.msg_pasVehiculeAffect, Program.AppTitle, MessageBoxButtons.OK, MessageBoxIcon.Information);
      else
      {
        int iNum = Convert.ToInt32(sVeh);
        new frmDetailVehicule(iNum, MozartParams.NomSociete).ShowDialog();

      }
    }

    private void CmdSignature_Click(object sender, EventArgs e)
    {
      if (miNumPer == 0) return;
      new frmSignaturePersonnel(miNumPer).ShowDialog();
    }

    private void chkPoste40_Click(object sender, EventArgs e)
    {
      apiCheckBox lTmpChkBox = (sender as apiCheckBox);

      switch (lTmpChkBox.Name)
      {
        case "chkPoste35":
          chkPoste40.Checked = false;
          chkPoste354.Checked = false;
          break;
        case "chkPoste40":
          chkPoste35.Checked = false;
          chkPoste354.Checked = false;
          break;
        case "chkPoste354":
          chkPoste40.Checked = false;
          chkPoste35.Checked = false;
          break;
        default:
          break;
      }
    }

    private void cboLangue_Validated(object sender, EventArgs e)
    {
      cboLangueAbrev.SelectedIndex = cboLangue.SelectedIndex;
    }

    private void RemplirComboLangues()
    {
      DataTable dt = new DataTable();
      try
      {
        var dataReader = ModuleData.ExecuteReader("SELECT DISTINCT VLANGUEDEFAUT, VLANGUEABR FROM TPAYS WHERE VLANGUEABR in ('FR','RO','EN','ES','IT','NL') ORDER BY VLANGUEDEFAUT");
        dt.Load(dataReader);
        dataReader.Close();

        foreach (DataRow row in dt.Rows)
        {
          cboLangue.Items.Add((string)row[0]);
          cboLangueAbrev.Items.Add((string)row[1]);
        }
      }
      catch (Exception ex) { Utils.ShowException(ex, MethodBase.GetCurrentMethod().Name, ex.StackTrace); }
    }

    private void grdEnf_PreviewKeyDownE(object sender, PreviewKeyDownEventArgs e)
    {
      GridControl gridControl = (GridControl)sender;
      GridView currentView = (GridView)gridControl.FocusedView;
      if (e.KeyCode == Keys.Delete)
        currentView.DeleteRow(currentView.FocusedRowHandle);
    }

    // Event textchanged sur les champs de saisie des coûts
    private void calcRemunerationBruteAnnuelle(object sender, EventArgs e)
    {
      double lNbHTravMensuel = 0.0;
      double lRemuBrutMens = 0.0;
      double lNbMoisContractuel = 0.0;
      double lPrimeCC = 0.0;
      double lPrimeNonCC = 0.0;

      try { lNbHTravMensuel = Utils.ZeroIfBlank(txtNbHeures.EditValue); } catch (Exception) { };
      try { lRemuBrutMens = Utils.ZeroIfBlank(txtSalaire.Text); } catch (Exception) { };
      try { lNbMoisContractuel = Utils.ZeroIfBlank(txtNbMoisContractuel.Text); } catch (Exception) { };
      try { lPrimeCC = Utils.ZeroIfBlank(txtPrimeCC.Text); } catch (Exception) { };
      try { lPrimeNonCC = Utils.ZeroIfBlank(txtPrimeNonCC.Text); } catch (Exception) { };

      double lSalaireAnnuel = lRemuBrutMens * lNbMoisContractuel + lPrimeCC + lPrimeNonCC;
      txtSalaireAnnuel.Text = lSalaireAnnuel.ToString();

      double lCoutHor = (lNbHTravMensuel == 0.0) ? 0.0 : lSalaireAnnuel * dTauxAna / (12 * lNbHTravMensuel);
      txtCoutHor.Text = lCoutHor.ToString();
    }

    private void btnPrimeCC_Click(object sender, EventArgs e)
    {
      frmSaisiePrimes lFrmPrime = new frmSaisiePrimes(true, miNumPer);
      lFrmPrime.ShowDialog();

      calcPrimes();
    }

    private void btnPrimeNonCC_Click(object sender, EventArgs e)
    {
      frmSaisiePrimes lFrmPrime = new frmSaisiePrimes(false, miNumPer);
      lFrmPrime.ShowDialog();

      calcPrimes();
    }

    private void calcPrimes()
    {
      string lReq;

      txtPrimeCC.Text = "0";
      txtPrimeNonCC.Text = "0";

      try
      {
        lReq = $"SELECT BPRIMECC, SUM(CASE WHEN BPRIMECC = 'C' THEN NPRIMMONTANT ELSE 0 END) AS PRIMECC, SUM(CASE WHEN BPRIMECC = 'H' THEN NPRIMMONTANT ELSE 0 END) as PRIMENONCC";
        lReq += $" FROM TPRIMES WHERE NPERNUM = {miNumPer} GROUP BY BPRIMECC";
        var dataReader = ModuleData.ExecuteReader(lReq);
        while (dataReader.Read())
        {
          switch (dataReader["BPRIMECC"])
          {
            case "C":
              // Prime CC
              txtPrimeCC.Text = Strings.FormatNumber(dataReader["PRIMECC"], 2);
              break;
            case "H":
              // Prime non CC
              txtPrimeNonCC.Text = Strings.FormatNumber(dataReader["PRIMENONCC"], 2);
              break;
            default:
              break;
          }
        }
        dataReader.Close();
      }
      catch (Exception ex) { Utils.ShowException(ex, MethodBase.GetCurrentMethod().Name, ex.StackTrace); }
    }

    private void cboContrat_TxtChanged(object sender, EventArgs e)
    {
      // 5 = Contrat Intérim
      txtPrimeCC.Enabled = txtPrimeNonCC.Enabled = (cboContrat.GetItemData() != 5);
      if (cboContrat.GetItemData() == 5)
      {
        txtPrimeCC.Text = txtPrimeNonCC.Text = 0.ToString();
      }
    }

    private void Chk_Restri_CheckedChanged(object sender, EventArgs e)
    {
      Btn_Restri.Enabled = Chk_Restri.Checked;
    }

    private void Btn_Restri_Click(object sender, EventArgs e)
    {
      Cursor.Current = Cursors.WaitCursor;
      frmPer_Restri_Detail f = new frmPer_Restri_Detail(miNumPer);
      f.Text += " (" + txtNom.Text + " " + txtprenom.Text + ")";
      f.ShowDialog();
      Cursor.Current = Cursors.Default;
    }

    private void BtnDepartement_Click(object sender, EventArgs e)
    {

      frmDepartementsPlanif f = new frmDepartementsPlanif(miNumPer, txtNom.Text + " " + txtprenom.Text);
      f.ShowDialog();

    }

    private void apiButton1_Click(object sender, EventArgs e)
    {
      apiTooltip1.Texte = "Ce bouton permet l’affectation d’un chargé d’affaires adjoint ou d’un BE à un ou plusieurs chargés d’affaires " +
        "et donc à la visualisation des projets qu’ils pilotent dans le module ANALYTIQUE PROJET.";


      //apiTooltip1.Top = 5000 / 15;
      //apiTooltip1.Left = 3000 / 15;
      apiTooltip1.Titre = "Explication";
      apiTooltip1.PrintTexte("");
      apiTooltip1.Visible = true;

    }

        private void ChkEMASSET_CheckedChanged(object sender, EventArgs e)
        {
            if(ChkEMASSET.Checked)
            {
                //on vérifie si la personne a déjà une accès dans TACCESWEB
                SqlCommand sqlCmdVerif = new SqlCommand("[api_sp_GetAccesWeb]", MozartDatabase.cnxMozart)
                {
                    CommandType = CommandType.StoredProcedure,
                    Parameters =
                    {
                        new SqlParameter("@P_NPERNUM", miNumPer)
                    }

                };
                object result = sqlCmdVerif.ExecuteScalar();
                int NbAccesWeb = Convert.ToInt32(result); // conversion en int
                if (NbAccesWeb == 0)
                {
                    ChkEMASSET.Text = ChkEMASSET.Text + " (Pas d'accès Web)";
                    ChkEMASSET.ForeColor = Color.Red;
                    MessageBox.Show("Cette personne n'a pas d'accès à EMASSET car son accès Web Personnel n'existe pas.\r\nVeuillez contacter votre administrateur afin qu'il créait son accès web.", Program.AppTitle, MessageBoxButtons.OK, MessageBoxIcon.Warning);
                }
                else
                {
                    ChkEMASSET.Text = "Accès EMASSET";
                    ChkEMASSET.ForeColor = Color.Black;
                }

            }


        }
    }
}