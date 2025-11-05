using DevExpress.Accessibility;
using DevExpress.CodeParser;
using DevExpress.XtraEditors;
using DevExpress.XtraEditors.Controls;
using MozartCS.Administration.Clients;
using MozartCS.Properties;
using MozartLib;
using MozartNet;
using System;
using System.Data;
using System.Diagnostics;
using System.Drawing;
using System.IO;
using System.Reflection;
using System.Windows.Forms;
using MZUtils = MozartControls.Utils;

namespace MozartCS
{
  public partial class frmClientsContrats_Detail : Form
  {
    CCONTRATCLI_DETAIL oCCONTRATCLI_DETAIL;

    int _NIDCONTRATCLI_DETAIL;
    int _NCLINUM;
    DateTime _curDate = DateTime.MinValue;
    bool bOpenInReadOnly = false;


    public frmClientsContrats_Detail(int C_NIDCONTRATCLI_DETAIL, int C_NCLINUM, bool C_bOpenInReadOnly = false)
    {
      InitializeComponent();
      _NIDCONTRATCLI_DETAIL = C_NIDCONTRATCLI_DETAIL;
      _NCLINUM = C_NCLINUM;
      bOpenInReadOnly = C_bOpenInReadOnly;
    }

    private void frmClientsContrats_Detail_Load(object sender, System.EventArgs e)
    {
      try
      {
        ModuleMain.Initboutons(this);

        //init
        // Utils.RechercheParam("REP_INFO");       
        GLU_Contrat_Avenant.Visible = false;
        CDG.Filter = $"{Resources.lbl_Fichier_PDF} (*.pdf) |*.pdf";  //Fichier PDF

                //string sSql = "select NPERNUM, VPERNOM + ' ' + VPERPRE AS nomPre  from TPER WHERE VSOCIETE = App_Name() AND CPERACTIF='O' order by VPERNOM";
                //cboPer.Init(MozartDatabase.cnxMozart, sSql, "NPERNUM", "nomPre", new List<string>() { Resources.col_Num, Resources.col_Nom }, 150, 550, true);

                LoadData();

        if (bOpenInReadOnly == true)
        {

          cmdEnregistrer.Visible = false;
          ChkCboEditCAN.Enabled = ChkCboEditPays.Enabled = ChkCboEditSites.Enabled = CboTypeDoc.Enabled = Txt_NomDoc.Enabled = false;
          cmdDateDoc.Enabled = cmdDateDebut.Enabled = cmdDateFin.Enabled = Chk_Tacite.Enabled = ChkRemiseAucune.Enabled = false;
          cmdSuppDateDoc.Enabled = cmdSuppDebut.Enabled = cmdSuppFin.Enabled = false;
          CboFormuleRev.Enabled = false;
          CmdDateDerAppli.Enabled = CmdSuppDateDerAppli.Enabled = CmdDateNextAppli.Enabled = CmdSuppDateNextAppli.Enabled = false;
          Txt_PC_Cur.Enabled = Txt_PC_Prev.Enabled = Txt_PC_BPU.Enabled = false;
          Txt_Obs_Manu.ReadOnly = true;
          Txt_Obs.ReadOnly = true;

        }

        Cursor.Current = Cursors.Default;
      }
      catch (Exception ex)
      {
        MZUtils.displayError(MethodBase.GetCurrentMethod().Name, ex);
      }
    }

    private void LoadData()
    {

      //init
      oCCONTRATCLI_DETAIL = new CCONTRATCLI_DETAIL(_NIDCONTRATCLI_DETAIL, _NCLINUM);

      Txt_NomDoc.Text = oCCONTRATCLI_DETAIL.VNOMDOCUMENT;
      txtDate_Doc.Text = $"{oCCONTRATCLI_DETAIL.DDATE_DOCUMENT:dd/MM/yyyy}";
      txtDateDebut.Text = $"{oCCONTRATCLI_DETAIL.DDATE_DEBUT:dd/MM/yyyy}";
      txtDateFin.Text = $"{oCCONTRATCLI_DETAIL.DDATE_FIN:dd/MM/yyyy}";
      TxtDateDerAppli.Text = $"{oCCONTRATCLI_DETAIL.DLAST_APPLICATION:dd/MM/yyyy}";
      Txt_PC_Cur.EditValue = oCCONTRATCLI_DETAIL.PC_CUR;
      Txt_PC_Prev.EditValue = oCCONTRATCLI_DETAIL.PC_PREV;
      Txt_PC_BPU.EditValue = oCCONTRATCLI_DETAIL.PC_BPU;
      TxtDateNextAppli.Text = $"{oCCONTRATCLI_DETAIL.DNEXT_APPLICATION:dd/MM/yyyy}";
      Txt_Obs_Manu.Text = oCCONTRATCLI_DETAIL.VOBS_MANUEL;
      Txt_Obs.Text = oCCONTRATCLI_DETAIL.VOBS_CONTRAT;

      Chk_Tacite.Checked = oCCONTRATCLI_DETAIL.BCONTRATCLI_TACITE;
      ChkRemiseAucune.Checked = oCCONTRATCLI_DETAIL.BREMISE_AUCUNE;
      chkNoDoc.Checked = oCCONTRATCLI_DETAIL.bNoDoc;

            //load combo
            //compte ana   
            ChkCboEditCAN.Properties.DataSource = oCCONTRATCLI_DETAIL.dtComptes;
      ChkCboEditCAN.Properties.EditValueType = DevExpress.XtraEditors.Repository.EditValueTypeCollection.List;
      ChkCboEditCAN.SetEditValue(oCCONTRATCLI_DETAIL.LstComptesSelected);
            LblNbCptSelected.Text = $"{oCCONTRATCLI_DETAIL.LstComptesSelected.Count} {Resources.txt_compte_s_selectionne_s}";  //compte(s) sélectionné(s)

            //pays      
            ChkCboEditPays.Properties.DataSource = oCCONTRATCLI_DETAIL.dtPays;
      ChkCboEditPays.Properties.EditValueType = DevExpress.XtraEditors.Repository.EditValueTypeCollection.List;
      ChkCboEditPays.SetEditValue(oCCONTRATCLI_DETAIL.LstPaysSelected);
            LblNbPaysSelected.Text = $"{oCCONTRATCLI_DETAIL.LstPaysSelected.Count} {Resources.txt_pays_selectionne_s}";  //pays sélectionné(s)

            //sites selected     
            ChkCboEditSites.Properties.DataSource = oCCONTRATCLI_DETAIL.dtSites;
      ChkCboEditSites.Properties.EditValueType = DevExpress.XtraEditors.Repository.EditValueTypeCollection.List;
      ChkCboEditSites.SetEditValue(oCCONTRATCLI_DETAIL.LstSitesSelected);
            LblNbSitesSelected.Text = $"{oCCONTRATCLI_DETAIL.LstSitesSelected.Count} {Resources.txt_site_s_selectionne_s}"; //site(s) sélectionné(s)

            ////Type document 
            CboTypeDoc.Properties.DataSource = oCCONTRATCLI_DETAIL.dtTypeDocument;
      CboTypeDoc.EditValue = oCCONTRATCLI_DETAIL.NIDCONTRAT_TYPEDOC;

      ////contrat
      GLU_Contrat_Avenant.Properties.DataSource = oCCONTRATCLI_DETAIL.dtContratAvenant;
      GLU_Contrat_Avenant.EditValue = oCCONTRATCLI_DETAIL.NIDCONTRATCLI_DETAIL_AVENANT;

      ////Formule revision
      CboFormuleRev.Properties.DataSource = oCCONTRATCLI_DETAIL.dtFormuleRev;
      CboFormuleRev.EditValue = oCCONTRATCLI_DETAIL.NIDFORMULE_REV;

      ColorBtn();

    }

    private void ColorBtn()
    {

      if (oCCONTRATCLI_DETAIL == null) return;

      BtnObsDoc.BackColor = (oCCONTRATCLI_DETAIL.VOBS_DOC == "" ? DefaultBackColor : Color.Yellow);
      BtnObsRemise.BackColor = (oCCONTRATCLI_DETAIL.VOBS_REMISE == "" ? DefaultBackColor : Color.Yellow);
      BtnObsDerAppli.BackColor = (oCCONTRATCLI_DETAIL.VHISTO_LAST_APPLICATION == "" ? DefaultBackColor : Color.Yellow);
      BtnHisto_PC_Curatif.BackColor = (oCCONTRATCLI_DETAIL.VHISTO_PC_CUR == "" ? DefaultBackColor : Color.Yellow);
      BtnHisto_PC_Prev.BackColor = (oCCONTRATCLI_DETAIL.VHISTO_PC_PREV == "" ? DefaultBackColor : Color.Yellow);
      BtnHisto_PC_BPU.BackColor = (oCCONTRATCLI_DETAIL.VHISTO_PC_BPU == "" ? DefaultBackColor : Color.Yellow);
      BtnObsNextAppli.BackColor = (oCCONTRATCLI_DETAIL.VHISTO_NEXT_APPLICATION == "" ? DefaultBackColor : Color.Yellow);

      if (oCCONTRATCLI_DETAIL.bNewDocument == true)
      {
        BtnVisuDoc.BackColor = oCCONTRATCLI_DETAIL.sPathAndFileNameNewDoc == "" ? DefaultBackColor : Color.Yellow;
      }
      else
      {
        BtnVisuDoc.BackColor = (oCCONTRATCLI_DETAIL.VFILE_DOCUMENT == "" ? DefaultBackColor : Color.Yellow);
      }

    }

    private void cmdFermer_Click(object sender, System.EventArgs e)
    {
      Dispose();
    }

    private void cmdEnregistrer_Click(object sender, EventArgs e)
    {
      try
      {
        Cursor.Current = Cursors.WaitCursor;

        if (oCCONTRATCLI_DETAIL == null) return;

        //comptes selected
        if (ChkCboEditCAN.Properties.GetItems().GetCheckedValues().Count == 0)
        {
                    //Il faut sélectionner au moins 1 compte analytique
                    MessageBox.Show(Resources.msg_Il_faut_selectionner_au_moins_1_compte_analytique, Program.AppTitle, MessageBoxButtons.OK, MessageBoxIcon.Information);
          Cursor.Current = Cursors.Default;
          return;
        }
        //pays selected
        if (ChkCboEditPays.Properties.GetItems().GetCheckedValues().Count == 0)
        {
                    //Il faut sélectionner au moins 1 pays
                    MessageBox.Show(Resources.msg_Il_faut_selectionner_au_moins_1_pays, Program.AppTitle, MessageBoxButtons.OK, MessageBoxIcon.Information);
          Cursor.Current = Cursors.Default;
          return;
        }
        //sites selected
        if (ChkCboEditSites.Properties.GetItems().GetCheckedValues().Count == 0)
        {
                    //Il faut sélectionner au moins 1 site
                    MessageBox.Show(Resources.msg_Il_faut_selectionner_au_moins_1_site, Program.AppTitle, MessageBoxButtons.OK, MessageBoxIcon.Information);
          Cursor.Current = Cursors.Default;
          return;
        }
        //type document
        if (CboTypeDoc.EditValue == null && !chkNoDoc.Checked)
        {
                    //Il faut sélectionner le type de document
                    MessageBox.Show(Resources.msg_Il_faut_selectionner_le_type_de_document, Program.AppTitle, MessageBoxButtons.OK, MessageBoxIcon.Information);
          Cursor.Current = Cursors.Default;
          return;
        }

        //nom du document
        if (Txt_NomDoc.Text == "" && !chkNoDoc.Checked)
        {
                    //Il faut saisir le nom de document
                    MessageBox.Show(Resources.msg_Il_faut_saisir_le_nom_de_document, Program.AppTitle, MessageBoxButtons.OK, MessageBoxIcon.Information);
          Cursor.Current = Cursors.Default;
          return;
        }

        //date du document
        if (txtDate_Doc.Text == "" && !chkNoDoc.Checked)
        {
                    //Il faut saisir la date du document
                    MessageBox.Show(Resources.msg_Il_faut_saisir_la_date_du_document, Program.AppTitle, MessageBoxButtons.OK, MessageBoxIcon.Information);
          Cursor.Current = Cursors.Default;
          return;
        }

        //date début du document
        if (txtDateDebut.Text == "" && !chkNoDoc.Checked)
        {
                    //Il faut saisir la date de début du document
                    MessageBox.Show(Resources.msg_Il_faut_saisir_la_date_de_début_du_document, Program.AppTitle, MessageBoxButtons.OK, MessageBoxIcon.Information);
          Cursor.Current = Cursors.Default;
          return;
        }

        //date fin du document
        if (txtDateFin.Text == "" && !chkNoDoc.Checked)
        {
                    //Il faut saisir la date de fin du document
                    MessageBox.Show(Resources.msg_Il_faut_saisir_la_date_de_fin_du_document, Program.AppTitle, MessageBoxButtons.OK, MessageBoxIcon.Information);
          Cursor.Current = Cursors.Default;
          return;
        }

        //formule de revision
        if (CboFormuleRev.EditValue == null)
        {
                    //Il faut sélectionner une formule de révision
                    MessageBox.Show(Resources.msg_Il_faut_sélectionner_une_formule_de_révision, Program.AppTitle, MessageBoxButtons.OK, MessageBoxIcon.Information);
          Cursor.Current = Cursors.Default;
          return;
        }

        //date de la prochiane application
        if (TxtDateNextAppli.Text == "")
        {
                    //Il faut saisir la date de la prochaine application
                    MessageBox.Show(Resources.msg_Il_faut_saisir_la_date_de_la_prochaine_application, Program.AppTitle, MessageBoxButtons.OK, MessageBoxIcon.Information);
          Cursor.Current = Cursors.Default;
          return;
        }



        oCCONTRATCLI_DETAIL.VNOMDOCUMENT = Txt_NomDoc.Text;
        if (txtDate_Doc.Text == "") { oCCONTRATCLI_DETAIL.DDATE_DOCUMENT = null; } else { oCCONTRATCLI_DETAIL.DDATE_DOCUMENT = Convert.ToDateTime(txtDate_Doc.Text); }
        if (txtDateDebut.Text == "") { oCCONTRATCLI_DETAIL.DDATE_DEBUT = null; } else { oCCONTRATCLI_DETAIL.DDATE_DEBUT = Convert.ToDateTime(txtDateDebut.Text); }
        if (txtDateFin.Text == "") { oCCONTRATCLI_DETAIL.DDATE_FIN = null; } else { oCCONTRATCLI_DETAIL.DDATE_FIN = Convert.ToDateTime(txtDateFin.Text); }
        oCCONTRATCLI_DETAIL.BCONTRATCLI_TACITE = Chk_Tacite.Checked;
        if (CboFormuleRev.EditValue == null) { oCCONTRATCLI_DETAIL.NIDFORMULE_REV = 0; } else { oCCONTRATCLI_DETAIL.NIDFORMULE_REV = (int)CboFormuleRev.EditValue; }
        oCCONTRATCLI_DETAIL.BREMISE_AUCUNE = ChkRemiseAucune.Checked;

        if (TxtDateDerAppli.Text == "") { oCCONTRATCLI_DETAIL.DLAST_APPLICATION = null; } else { oCCONTRATCLI_DETAIL.DLAST_APPLICATION = Convert.ToDateTime(TxtDateDerAppli.Text); }

        if (Txt_PC_Cur.Text == "") { oCCONTRATCLI_DETAIL.PC_CUR = null; } else { oCCONTRATCLI_DETAIL.PC_CUR = Convert.ToDecimal(Txt_PC_Cur.Text); }
        if (Txt_PC_Prev.Text == "") { oCCONTRATCLI_DETAIL.PC_PREV = null; } else { oCCONTRATCLI_DETAIL.PC_PREV = Convert.ToDecimal(Txt_PC_Prev.Text); }
        if (Txt_PC_BPU.Text == "") { oCCONTRATCLI_DETAIL.PC_BPU = null; } else { oCCONTRATCLI_DETAIL.PC_BPU = Convert.ToDecimal(Txt_PC_BPU.Text); }

        if (TxtDateNextAppli.Text == "") { oCCONTRATCLI_DETAIL.DNEXT_APPLICATION = null; } else { oCCONTRATCLI_DETAIL.DNEXT_APPLICATION = Convert.ToDateTime(TxtDateNextAppli.Text); }

        oCCONTRATCLI_DETAIL.LstComptesSelected = ChkCboEditCAN.Properties.GetItems().GetCheckedValues();
        oCCONTRATCLI_DETAIL.LstPaysSelected = ChkCboEditPays.Properties.GetItems().GetCheckedValues();
        oCCONTRATCLI_DETAIL.LstSitesSelected = ChkCboEditSites.Properties.GetItems().GetCheckedValues();

        oCCONTRATCLI_DETAIL.NIDCONTRATCLI_DETAIL_AVENANT = GLU_Contrat_Avenant.EditValue == null ? 0 : (int)GLU_Contrat_Avenant.EditValue;
        oCCONTRATCLI_DETAIL.NIDCONTRAT_TYPEDOC = CboTypeDoc.EditValue == null ? 0 : (int)CboTypeDoc.EditValue;
        oCCONTRATCLI_DETAIL.VOBS_MANUEL = Txt_Obs_Manu.Text;
        oCCONTRATCLI_DETAIL.VOBS_CONTRAT = Txt_Obs.Text;
        oCCONTRATCLI_DETAIL.bNoDoc = chkNoDoc.Checked;

        oCCONTRATCLI_DETAIL.Save();

        //update de la key
        _NIDCONTRATCLI_DETAIL = oCCONTRATCLI_DETAIL.NIDCONTRATCLI_DETAIL;

        //refresh
        LoadData();


        Cursor.Current = Cursors.Default;
      }
      catch (Exception ex)
      {
        MZUtils.displayError(MethodBase.GetCurrentMethod().Name, ex);
      }
    }

    private void cmdDate_Click(object sender, EventArgs e)
    {
      string txtDate = "";

      switch ((sender as Button).Name)
      {
        case "cmdDateDoc":
          txtDate = txtDate_Doc.Text;
          Calendar1.Tag = 0;
          break;
        case "cmdDateDebut":
          txtDate = txtDateDebut.Text;
          Calendar1.Tag = 1;
          break;
        case "cmdDateFin":
          txtDate = txtDateFin.Text;
          Calendar1.Tag = 2;
          break;
        case "CmdDateDerAppli":
          txtDate = TxtDateDerAppli.Text;
          Calendar1.Tag = 3;
          break;
        case "CmdDateNextAppli":
          txtDate = TxtDateNextAppli.Text;
          Calendar1.Tag = 4;
          break;
        default:
          return;
      }

      if (txtDate == "")
      {
        txtDate = DateTime.Now.ToShortDateString();
      }

      DateTime d;
      if (DateTime.TryParse(txtDate, out d))
        _curDate = Calendar1.Value = d;
      else { _curDate = DateTime.MinValue; Calendar1.Value = DateTime.Now; }

      Calendar1.Visible = true;
      Calendar1.ShowCalendar(new MouseEventArgs(MouseButtons.Left, 1, MousePosition.X - this.Location.X, MousePosition.Y - this.Location.Y, 0));
    }
    private void Calendar1_CloseUp(object sender, EventArgs e)
    {
      Calendar1.Visible = false;
      if (_curDate == DateTime.MinValue) return;
      switch (Calendar1.Tag)
      {
        case 0:
          txtDate_Doc.Text = Calendar1.Value.ToShortDateString();
          break;
        case 1:
          txtDateDebut.Text = Calendar1.Value.ToShortDateString();
          break;
        case 2:
          txtDateFin.Text = Calendar1.Value.ToShortDateString();
          break;
        case 3:
          TxtDateDerAppli.Text = Calendar1.Value.ToShortDateString();
          break;
        case 4:
          TxtDateNextAppli.Text = Calendar1.Value.ToShortDateString();
          break;
        default:
          break;
      }
    }
    private void Calendar1_ValueChanged(object sender, EventArgs e)
    {
      if (Calendar1.Visible) _curDate = Calendar1.Value;
    }
    private void cmdSupp1_Click(object sender, EventArgs e)
    {
      Button btn = sender as Button;
      string txtDate = "";

      switch ((sender as Button).Name)
      {
        case "cmdSuppDateDoc":
          txtDate_Doc.Text = txtDate;
          Calendar1.Tag = 0;
          break;
        case "cmdSuppDebut":
          txtDateDebut.Text = txtDate;
          Calendar1.Tag = 1;
          break;
        case "cmdSuppFin":
          txtDateFin.Text = txtDate;
          Calendar1.Tag = 2;
          break;
        case "CmdSuppDateDerAppli":
          TxtDateDerAppli.Text = txtDate;
          Calendar1.Tag = 3;
          break;
        case "CmdSuppDateNextAppli":
          TxtDateNextAppli.Text = txtDate;
          Calendar1.Tag = 4;
          break;
        default:
          return;
      }

    }

    private void BtnInfoDateFin_Click(object sender, EventArgs e)
    {
            //La date de fin est la date de fin du contrat ferme sans les avenants ou reconductions possibles
            //Exemple 3 + 2 = saisir 3
            MessageBox.Show($"{Resources.msg_La_date_de_fin_est_la_date_de_fin_du_contra_ferme_sans_les_avenants_ou_reconductions_possibles}\n\r{Resources.msg_Exemple_3_2_saisir_3}", Resources.msg_information, MessageBoxButtons.OK, MessageBoxIcon.Information);
    }

    private void BtnInfoFormule_Click(object sender, EventArgs e)
    {
            //Si la formule n’existe pas dans la liste, vous rapprochez de la DAF ou de la Direction.
            MessageBox.Show(Resources.msg_Si_la_formule_n_existe_pas_dans_la_liste, Resources.msg_information, MessageBoxButtons.OK, MessageBoxIcon.Information);
    }

    private void BtnObsDoc_Click(object sender, EventArgs e)
    {
      FrmAddMessageManuel ofrmaddMessageManuel = new FrmAddMessageManuel();
      ofrmaddMessageManuel.sLblTitre = Resources.msg_Saisie_Observation_sur_le_document;  //Saisie Observations sur le document
            ofrmaddMessageManuel.sMessage = (oCCONTRATCLI_DETAIL == null ? "" : oCCONTRATCLI_DETAIL.VOBS_DOC);
      ofrmaddMessageManuel.bAddUserInText = !bOpenInReadOnly;
      ofrmaddMessageManuel.bReadOnly = bOpenInReadOnly;
      ofrmaddMessageManuel.ShowDialog();

      if (ofrmaddMessageManuel.bCancel == false)
      {
        oCCONTRATCLI_DETAIL.VOBS_DOC = ofrmaddMessageManuel.sMessage;
      }
      ofrmaddMessageManuel.Dispose();

      ColorBtn();

    }

    private void ChkCboEditCAN_EditValueChanged(object sender, EventArgs e)
    {
      LblNbCptSelected.Text = $"{ChkCboEditCAN.Properties.GetItems().GetCheckedValues().Count} {Resources.txt_compte_s_selectionne_s}";      //compte(s) sélectionné(s)
        }
    private void ChkCboEditPays_EditValueChanged(object sender, EventArgs e)
    {
      LblNbPaysSelected.Text = $"{ChkCboEditPays.Properties.GetItems().GetCheckedValues().Count} {Resources.txt_pays_selectionne_s}"; //pays sélectionné(s)
        }

    private void ChkCboEditSites_EditValueChanged(object sender, EventArgs e)
    {
      LblNbSitesSelected.Text = $"{ChkCboEditSites.Properties.GetItems().GetCheckedValues().Count} {Resources.txt_site_s_selectionne_s}"; //site(s) sélectionné(s)
        }      
    private void CboTypeDoc_EditValueChanged(object sender, EventArgs e)
    {

      switch ((int)CboTypeDoc.EditValue)
      {
        case 1:  //contrat
          apiLabel9.Visible = GLU_Contrat_Avenant.Visible = false;
          ChkCboEditCAN.Enabled = ChkCboEditPays.Enabled = ChkCboEditSites.Enabled = txtDate_Doc.Enabled = cmdDateDoc.Enabled = cmdSuppDateDoc.Enabled = true;
          txtDateDebut.Enabled = cmdDateDebut.Enabled = cmdSuppDebut.Enabled = true;

          break;
        case 2:  //avenant
          apiLabel9.Visible = GLU_Contrat_Avenant.Visible = true;
          ChkCboEditCAN.Enabled = ChkCboEditPays.Enabled = ChkCboEditSites.Enabled = txtDate_Doc.Enabled = cmdDateDoc.Enabled = cmdSuppDateDoc.Enabled = true;
          txtDateDebut.Enabled = cmdDateDebut.Enabled = cmdSuppDebut.Enabled = true;

          break;
        case 3: //résiliation
          apiLabel9.Visible = GLU_Contrat_Avenant.Visible = false;
          ChkCboEditCAN.Enabled = ChkCboEditPays.Enabled = ChkCboEditSites.Enabled = txtDate_Doc.Enabled = cmdDateDoc.Enabled = cmdSuppDateDoc.Enabled = false;
          txtDateDebut.Enabled = cmdDateDebut.Enabled = cmdSuppDebut.Enabled = false;

          break;
      }

    }

    private void Txt_Obs_Manu_MouseClick(object sender, MouseEventArgs e)
    {

      if (bOpenInReadOnly) return;

      FrmAddMessageManuel ofrmaddMessageManuel = new FrmAddMessageManuel();
      ofrmaddMessageManuel.sLblTitre = Resources.msg_Saisie_Observations_de_prix;  //Saisie Observations de prix
            ofrmaddMessageManuel.sMessage = "";
      ofrmaddMessageManuel.bReadOnly = bOpenInReadOnly;
      ofrmaddMessageManuel.ShowDialog();

      if (ofrmaddMessageManuel.sMessage != "")
      {
        Txt_Obs_Manu.Text = $"{MozartLib.MozartParams.strUID} le {DateTime.Now.ToString("dd/MM/yyyy HH:mm")} : {ofrmaddMessageManuel.sMessage}\r\n{Txt_Obs_Manu.Text}";
      }
      ofrmaddMessageManuel.Dispose();
    }

    private void Txt_Obs_MouseClick(object sender, MouseEventArgs e)
    {
      if (bOpenInReadOnly) return;

      FrmAddMessageManuel ofrmaddMessageManuel = new FrmAddMessageManuel();
      ofrmaddMessageManuel.sLblTitre = Resources.msg_Saisie_Observations_contrat;  //Saisie Observations contrat
            ofrmaddMessageManuel.sMessage = "";
      ofrmaddMessageManuel.bReadOnly = bOpenInReadOnly;
      ofrmaddMessageManuel.ShowDialog();

      if (ofrmaddMessageManuel.sMessage != "")
      {
        Txt_Obs.Text = $"{MozartLib.MozartParams.strUID} le {DateTime.Now.ToString("dd/MM/yyyy HH:mm")} : {ofrmaddMessageManuel.sMessage}\r\n{Txt_Obs.Text}";
      }
      ofrmaddMessageManuel.Dispose();

    }

    private void BtnObsRemise_Click(object sender, EventArgs e)
    {
      FrmAddMessageManuel ofrmaddMessageManuel = new FrmAddMessageManuel();
      ofrmaddMessageManuel.sLblTitre = Resources.msg_Remise_contractuelles;  //Remise contractuelles
            ofrmaddMessageManuel.sMessage = (oCCONTRATCLI_DETAIL == null ? "" : oCCONTRATCLI_DETAIL.VOBS_REMISE);
      ofrmaddMessageManuel.bAddUserInText = !bOpenInReadOnly;
      ofrmaddMessageManuel.bReadOnly = bOpenInReadOnly;
      ofrmaddMessageManuel.ShowDialog();

      if (ofrmaddMessageManuel.bCancel == false)
      {
        oCCONTRATCLI_DETAIL.VOBS_REMISE = ofrmaddMessageManuel.sMessage;
      }
      ofrmaddMessageManuel.Dispose();

      ColorBtn();

    }

    private void BtnObsDerAppli_Click(object sender, EventArgs e)
    {
      FrmAddMessageManuel ofrmaddMessageManuel = new FrmAddMessageManuel();
      ofrmaddMessageManuel.sLblTitre = Resources.msg_Historique_date_de_la_derniere_application;  //Historique date de la dernière application
            ofrmaddMessageManuel.sMessage = (oCCONTRATCLI_DETAIL == null ? "" : oCCONTRATCLI_DETAIL.VHISTO_LAST_APPLICATION);
      ofrmaddMessageManuel.bReadOnly = true;
      ofrmaddMessageManuel.ShowDialog();
    }

    private void BtnHisto_PC_Curatif_Click(object sender, EventArgs e)
    {
      FrmAddMessageManuel ofrmaddMessageManuel = new FrmAddMessageManuel();
      ofrmaddMessageManuel.sLblTitre = Resources.msg_Historique_Curatif_Pourcentage_applique; //Historique Curatif : Pourcentage appliqué
            ofrmaddMessageManuel.sMessage = (oCCONTRATCLI_DETAIL == null ? "" : oCCONTRATCLI_DETAIL.VHISTO_PC_CUR);
      ofrmaddMessageManuel.bReadOnly = true;
      ofrmaddMessageManuel.ShowDialog();
    }

    private void BtnHisto_PC_Prev_Click(object sender, EventArgs e)
    {
      FrmAddMessageManuel ofrmaddMessageManuel = new FrmAddMessageManuel();
      ofrmaddMessageManuel.sLblTitre = Resources.msg_Historique_Preventif_Pourcentage_applique; //Historique Préventif : Pourcentage appliqué
            ofrmaddMessageManuel.sMessage = (oCCONTRATCLI_DETAIL == null ? "" : oCCONTRATCLI_DETAIL.VHISTO_PC_PREV);
      ofrmaddMessageManuel.bReadOnly = true;
      ofrmaddMessageManuel.ShowDialog();
    }

    private void BtnHisto_PC_BPU_Click(object sender, EventArgs e)
    {
      FrmAddMessageManuel ofrmaddMessageManuel = new FrmAddMessageManuel();
      ofrmaddMessageManuel.sLblTitre = Resources.msg_Historique_BPU_Pourcentage_applique; //Historique BPU : Pourcentage appliqué
            ofrmaddMessageManuel.sMessage = (oCCONTRATCLI_DETAIL == null ? "" : oCCONTRATCLI_DETAIL.VHISTO_PC_BPU);
      ofrmaddMessageManuel.bReadOnly = true;
      ofrmaddMessageManuel.ShowDialog();
    }

    private void BtnObsNextAppli_Click(object sender, EventArgs e)
    {
      FrmAddMessageManuel ofrmaddMessageManuel = new FrmAddMessageManuel();
      ofrmaddMessageManuel.sLblTitre = Resources.msg_Historique_date_de_la_prochaine_application; //Historique date de la prochaine application
            ofrmaddMessageManuel.sMessage = (oCCONTRATCLI_DETAIL == null ? "" : oCCONTRATCLI_DETAIL.VHISTO_NEXT_APPLICATION);
      ofrmaddMessageManuel.bReadOnly = true;
      ofrmaddMessageManuel.ShowDialog();
    }

    private void BtnAddDoc_Click(object sender, EventArgs e)
    {

      if (oCCONTRATCLI_DETAIL == null) return;

      //test si contrat déjà existant
      if ((oCCONTRATCLI_DETAIL.bNewDocument == true & oCCONTRATCLI_DETAIL.sPathAndFileNameNewDoc != "") || (oCCONTRATCLI_DETAIL.bNewDocument == false & oCCONTRATCLI_DETAIL.VFILE_DOCUMENT != ""))
      {
                //Un document existe déjà.
                //Voulez-vous continuer ?
                //A noter : Si vous continuez, le document sera ecrasé.
                if (MessageBox.Show($"{Resources.msg_Un_document_existe_deja}\r\n{Resources.msg_Voulez_vous_continuer}\r\n{Resources.msg_A_noter_Si_vous_continuez_le_document_sera_ecrase}", Resources.msg_information, MessageBoxButtons.YesNoCancel, MessageBoxIcon.Exclamation) != DialogResult.Yes) return;
      }
      CDG.ReadOnlyChecked = true;
      CDG.Title = Resources.msg_select_image_file;
      CDG.Filter = $"{Resources.lbl_Fichier_PDF} (*.PDF)|*.PDF"; //Fichiers PDF
            CDG.FilterIndex = 1;

      if (CDG.ShowDialog() == DialogResult.OK)
      {
        oCCONTRATCLI_DETAIL.bNewDocument = true;
        oCCONTRATCLI_DETAIL.sPathAndFileNameNewDoc = CDG.FileName;
        if (oCCONTRATCLI_DETAIL.sPathAndFileNameNewDoc != "")
        {
          BtnVisuDoc.BackColor = Color.Yellow;
        }
        else { BtnVisuDoc.BackColor = DefaultBackColor; }

      }
    }

    private void BtnVisuDoc_Click(object sender, EventArgs e)
    {
      if (oCCONTRATCLI_DETAIL == null) return;

      if (oCCONTRATCLI_DETAIL.VFILE_DOCUMENT == "" && oCCONTRATCLI_DETAIL.sPathAndFileNameNewDoc == "")
      {
                //Il n'y a aucun document
                MessageBox.Show(Resources.msg_Il_n_y_a_aucun_document, Resources.msg_information, MessageBoxButtons.OK, MessageBoxIcon.Information);
        return;
      }

      if (oCCONTRATCLI_DETAIL.sPathAndFileNameNewDoc == "" & oCCONTRATCLI_DETAIL.VFILE_DOCUMENT != "")
      {

            if(CImpersonation.FileExistImpersonated(oCCONTRATCLI_DETAIL.RepertoireDoc + oCCONTRATCLI_DETAIL.VFILE_DOCUMENT))
            {
                    //new FrmBrowser(){.Navigate(CImpersonation.OpenFileImpersonated(oCCONTRATCLI_DETAIL.RepertoireDoc + oCCONTRATCLI_DETAIL.VFILE_DOCUMENT));

                    MozartCS.frmBrowser o = new MozartCS.frmBrowser();
                    o.msStartingAddress = CImpersonation.OpenFileImpersonated(oCCONTRATCLI_DETAIL.RepertoireDoc + oCCONTRATCLI_DETAIL.VFILE_DOCUMENT);
                    o.ShowDialog();
            }

        //        MozartCS.Modules.CGest_FileTemp_MOZARIS oCFileTMP = new MozartCS.Modules.CGest_FileTemp_MOZARIS();
        //if (File.Exists(oCCONTRATCLI_DETAIL.RepertoireDoc + oCCONTRATCLI_DETAIL.VFILE_DOCUMENT)) Process.Start(oCFileTMP.PathFilePrevisuTemp(oCCONTRATCLI_DETAIL.RepertoireDoc + oCCONTRATCLI_DETAIL.VFILE_DOCUMENT));
        return;
      }

      if (oCCONTRATCLI_DETAIL.sPathAndFileNameNewDoc != "")
      {
                MozartCS.frmBrowser o = new MozartCS.frmBrowser();
                o.msStartingAddress = oCCONTRATCLI_DETAIL.sPathAndFileNameNewDoc;

                //MozartCS.Modules.CGest_FileTemp_MOZARIS oCFileTMP = new MozartCS.Modules.CGest_FileTemp_MOZARIS();
                //Process.Start(oCFileTMP.PathFilePrevisuTemp(oCCONTRATCLI_DETAIL.sPathAndFileNameNewDoc));
                return;
      }

    }



    private void BtnContratDocDel_Click(object sender, EventArgs e)
    {
      if (oCCONTRATCLI_DETAIL == null) return;
            //Voulez-vous vraiment supprimer ce document ?
            ////Confirmation
            if (MessageBox.Show(Resources.msg_Voulez_vous_vraiment_supprimer_ce_document, Resources.msg_Confirmation, MessageBoxButtons.YesNoCancel) == DialogResult.Yes)
      {
        oCCONTRATCLI_DETAIL.bNewDocument = true;
        oCCONTRATCLI_DETAIL.sPathAndFileNameNewDoc = "";
        //oCCONTRATCLI_DETAIL.VFILE_DOCUMENT = "";

      }
      ColorBtn();

    }

        private void chkNoDoc_CheckedChanged(object sender, EventArgs e)
        {

            CboTypeDoc.Enabled = Txt_NomDoc.Enabled= txtDate_Doc.Enabled = cmdDateDoc.Visible = cmdSuppDateDoc.Visible = txtDateDebut.Enabled = txtDateFin.Enabled
                = cmdDateFin.Visible = cmdSuppFin.Visible = cmdDateDebut.Visible = cmdSuppDebut.Visible = !chkNoDoc.Checked;

        }

	  }

}