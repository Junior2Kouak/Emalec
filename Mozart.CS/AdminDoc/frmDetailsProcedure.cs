using MozartCS.Properties;
using MozartLib;
using MozartNet;
using MozartUC;
using System;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.IO;
using System.Reflection;
using System.Windows.Forms;
using MZUtils = MozartControls.Utils;

namespace MozartCS
{
  public partial class frmDetailsProcedure : Form
  {
    public long mlProc;
    public string msTitre = "";

    public string mstrType = "";
    public int miNumClient;
    public int miNumSite;
    public string mstrRepFichier = "";

    private string sFichier = "";
    private string sFichierOld = "";

    private readonly Color COLOR_GREY = Color.FromArgb(224, 224, 224);

    public frmDetailsProcedure()
    {
      InitializeComponent();
    }

    public frmDetailsProcedure(int Proc, string _strType, int NumClient, int NumSite, string RepFichier)
    {
      InitializeComponent();
      mlProc = Proc;
      mstrType = _strType.ToUpper();
      miNumClient = NumClient;
      miNumSite = NumSite;
      mstrRepFichier = RepFichier;
    }

    private void frmDetailsProcedure_Load(object sender, System.EventArgs e)
    {
      try
      {
        ModuleMain.Initboutons(this);

        ChkPDP_Action.Visible = false;
        cmdSelectContEiCliSigne.Visible = false;
        cmdDelSignContEI.Visible = false;

        lblTitre.Text = "Gestion des documents " + msTitre;

        switch (mstrType)
        {
          case "PROCEDURE":
            ModuleData.RemplirCombo(cboTypProc, "SELECT NIDTYPPROC, VTYPPROCLIB FROM TREF_TYPPROC WHERE LANGUE = '" + MozartParams.Langue
                                              + "' AND NTYPPROCFAMILLE = 6 AND CTYPPROCACTIF = 'O' ORDER BY VTYPPROCLIB");
            lblLabels0.Text = Resources.txt_type_procedure;
            lblLabels1.Text = Resources.col_Date_Document;

            lblLabels2.Visible = txtDateEcheance.Visible = cmdDateEche.Visible = cmdSuppEche.Visible = lblLabels4.Visible = false;
            chkTaciteRecond.Visible = lblLabels5.Visible = lblLabels6.Visible = chkPasDeContratEI.Visible = false;
            break;

          case "PROCEDURESITE":
            ModuleData.RemplirCombo(cboTypProc, "SELECT NIDTYPPROC, VTYPPROCLIB FROM TREF_TYPPROC WHERE LANGUE = '" + MozartParams.Langue
                                              + "' AND NTYPPROCFAMILLE = 1 AND CTYPPROCACTIF = 'O' ORDER BY VTYPPROCLIB");
            lblLabels0.Text = Resources.txt_type_procedure;
            lblLabels1.Text = Resources.col_Date_Document;
            lblLabels2.Visible = txtDateEcheance.Visible = cmdDateEche.Visible = cmdSuppEche.Visible = false;
            lblLabels4.Visible = chkTaciteRecond.Visible = lblLabels5.Visible = lblLabels6.Visible = chkPasDeContratEI.Visible = false;
            break;

          case "ADMINISTRATIF":
            ModuleData.RemplirCombo(cboTypProc, "SELECT NIDTYPPROC, VTYPPROCLIB FROM TREF_TYPPROC WHERE LANGUE = '" + MozartParams.Langue
                                         + "' AND NTYPPROCFAMILLE = 3 AND CTYPPROCACTIF = 'O' ORDER BY VTYPPROCLIB");
            lblLabels0.Text = Resources.txt_type_doc;
            lblLabels1.Text = Resources.txt_date_validite;
            lblLabels2.Visible = txtDateEcheance.Visible = cmdDateEche.Visible = cmdSuppEche.Visible = lblLabels4.Visible = false;
            chkTaciteRecond.Visible = lblLabels5.Visible = lblLabels6.Visible = chkPasDeContratEI.Visible = false;
            apiLabel1.Visible = cboLangue.Visible = true;
            RemplirComboLangues();

            break;

          case "PREVENTIONCONTRAT":
            ModuleData.RemplirCombo(cboTypProc, "SELECT NIDTYPPROC, VTYPPROCLIB FROM TREF_TYPPROC WHERE LANGUE = '" + MozartParams.Langue
                                              + "' AND NTYPPROCFAMILLE = 2 AND CTYPPROCACTIF = 'O' ORDER BY VTYPPROCLIB");
            lblLabels0.Text = Resources.txt_type_doc;
            lblLabels1.Text = Resources.col_Date_Document;
            lblLabels2.Visible = txtDateEcheance.Visible = cmdDateEche.Visible = cmdSuppEche.Visible = true;
            lblLabels4.Visible = chkTaciteRecond.Visible = lblLabels5.Visible = true;
            break;

          case "PLANPREVDI":
            ModuleData.RemplirCombo(cboTypProc, "SELECT NIDTYPPROC, VTYPPROCLIB FROM TREF_TYPPROC WHERE LANGUE = '" + MozartParams.Langue
                                              + "' AND NTYPPROCFAMILLE = 5 AND CTYPPROCACTIF = 'O' ORDER BY VTYPPROCLIB");
            lblLabels0.Text = Resources.txt_type_doc;
            lblLabels1.Text = Resources.col_Date_Document;
            lblLabels2.Visible = txtDateEcheance.Visible = cmdDateEche.Visible = cmdSuppEche.Visible = lblLabels4.Visible = false;
            chkTaciteRecond.Visible = lblLabels5.Visible = lblLabels6.Visible = chkPasDeContratEI.Visible = false;
            break;

          default:
            break;
        }

        cboTypProc.ValueMember = "NIDTYPPROC";
        cboTypProc.DisplayMember = "VTYPPROCLIB";

        if (mlProc == 0)
          OuvertureEnCreation();
        else
          OuvertureEnModification();
      }
      catch (Exception ex)
      {
        MZUtils.displayError(MethodBase.GetCurrentMethod().Name, ex);
      }
    }

    private void cmdValider_Click(object sender, EventArgs e)
    {
      if (Utils.BlankIfNull(txtTitre.Text) == "")
      {
        MessageBox.Show(Resources.msg_must_type_title, Program.AppTitle, MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
        return;
      }

      if ((int)cboTypProc.SelectedValue == 0)
      {
        MessageBox.Show(Resources.msg_must_type_procedure_type, Program.AppTitle, MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
        return;
      }

      if (Utils.BlankIfNull(sFichier) == "")
      {
        MessageBox.Show(Resources.msg_must_select_file, Program.AppTitle, MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
        return;
      }

      if (txtDateValidation.Text == "")
      {
        MessageBox.Show(Resources.msg_must_type_creation_date, Program.AppTitle, MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
        return;
      }

      using (SqlCommand cmd = new SqlCommand("api_sp_creationProcedure", MozartDatabase.cnxMozart))
      {
        cmd.CommandType = CommandType.StoredProcedure;
        // liste des paramètres
        SqlCommandBuilder.DeriveParameters(cmd);

        cmd.Parameters["@inumProc"].Value = mlProc;
        cmd.Parameters["@iCliNum"].Value = miNumClient;
        cmd.Parameters["@iSitNum"].Value = miNumSite;
        cmd.Parameters["@vTitre"].Value = txtTitre.Text;
        cmd.Parameters["@vFichier"].Value = sFichierOld != sFichier ? "temp" : sFichier;
        cmd.Parameters["@iTypeProc"].Value = (int)cboTypProc.SelectedValue;
        cmd.Parameters["@ddatvalid"].Value = txtDateValidation.Text == "" ? null : txtDateValidation.Text;
        cmd.Parameters["@di"].Value = MozartParams.NumDi;
        cmd.Parameters["@dprocecheance"].Value = txtDateEcheance.Text == "" ? null : txtDateEcheance.Text;
        cmd.Parameters["@bproctaciterecond"].Value = chkTaciteRecond.Checked ? 1 : 0;
        cmd.Parameters["@bpasDeContratEI"].Value = chkPasDeContratEI.Checked ? 1 : 0;
        cmd.Parameters["@bPDP_Action"].Value = ChkPDP_Action.Checked ? 1 : 0;
        cmd.Parameters["@vLangue"].Value = cboLangue.Text;

        cmd.ExecuteNonQuery();
        mlProc = Convert.ToInt64(cmd.Parameters[0].Value);
      }

      MozartUcUtils.SpyLog(MozartDatabase.cnxMozart, "", cmdValider.Text, (mlProc == 0 ? "Ajout" : "Modification"), "NCLINUM:" + miNumClient, "NNUMSITE:" + miNumSite, "NNUMDI:" + MozartParams.NumDi);

      if (sFichierOld != sFichier)
      {

        // gestion des droits.
        // le user Impersonate n'a pas les droits sur l'ensemble du réseau mais uniquement sur les répertoires de stockage des fichiers listé dans Mozart.
        // donc si l'utilisateur va chercher un fichier sur un répertoire du réseau, la copie en Impersonate plante.
        // Il faut copier en local avec les droits de l'utilisateur, puis dans le répertoire de stockage en Impersonate
        string sTempFile = $@"{Path.GetTempFileName()}";
        File.Copy(sFichier, sTempFile, true);
        string sNewTempFile = $"{sTempFile}.Mozart{Path.GetExtension(sFichier)}";
        File.Move(sTempFile, sNewTempFile);

        CImpersonation.CopyFileImpersonated(sNewTempFile, mstrRepFichier + mstrType + mlProc + ".pdf");
        File.Delete(sNewTempFile);

        ModuleData.ExecuteNonQuery("UPDATE TPROCEDURE SET VFICHIER = '" + mstrType + mlProc + ".pdf" + "' WHERE NIDPROC = " + mlProc);


      }

      // confirmation si modification engendre une nouvelle approbation de chaque technicien
      if ((int)cboTypProc.SelectedValue == 3 || (int)cboTypProc.SelectedValue == 12 || (int)cboTypProc.SelectedValue == 13)
      {
        if (MessageBox.Show(Resources.msg_validation_technicien_needed, Program.AppTitle, MessageBoxButtons.YesNo, MessageBoxIcon.Question, MessageBoxDefaultButton.Button2) == DialogResult.Yes)
          ModuleData.ExecuteNonQuery("EXEC api_sp_InitialisationProcedure " + mlProc);
      }

      Dispose();
    }

    private void cmdFichier_Click(object sender, EventArgs e)
    {
      //CommonDialog1.CancelError = true;
      CommonDialog1.ReadOnlyChecked = true;
      CommonDialog1.Title = Resources.msg_select_image_file;
      CommonDialog1.Filter = "Fichiers PDF (*.PDF)|*.PDF";
      CommonDialog1.FilterIndex = 1;

      if (CommonDialog1.ShowDialog() == DialogResult.OK)
      {
        sFichier = CommonDialog1.FileName;
        // Afficher l'image
        WebBrowser1.Navigate(sFichier);
      }
    }
    private void cmdSuppValidation_Click(object sender, EventArgs e)
    {
      txtDateValidation.Text = "";
    }

    DateTime _curDate = DateTime.MinValue;
    private void cmdDate1_2_Click(object sender, EventArgs e)
    {
      Button btn = sender as Button;
      Calendar1.Tag = btn.Tag;

      string txtDate = "";
      if ((sender as Button).Name == "cmdDate")
      {
        txtDate = txtDateValidation.Text;
        Calendar1.Tag = 0;
      }
      else
      {
        txtDate = txtDateEcheance.Text;
        Calendar1.Tag = 1;
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
      if ((int)Calendar1.Tag == 0) txtDateValidation.Text = Calendar1.Value.ToShortDateString();
      else if ((int)Calendar1.Tag == 1) txtDateEcheance.Text = Calendar1.Value.ToShortDateString();
    }
    private void Calendar1_ValueChanged(object sender, EventArgs e)
    {
      if (Calendar1.Visible) _curDate = Calendar1.Value;
    }

    private void cmdSuppEcheance_Click(object sender, EventArgs e)
    {
      txtDateEcheance.Text = "";
    }

    private void CmdSelectContEiCliSigne_Click(object sender, EventArgs e)
    {
      if (mlProc == 0)
      {
        MessageBox.Show(Resources.msg_must_save_contratEI, Program.AppTitle, MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
        return;
      }

      if (SignatureClientContratiEIExists(mlProc))
      {
        if (MessageBox.Show(Resources.msg_inform_contrat_signe, Program.AppTitle, MessageBoxButtons.YesNo, MessageBoxIcon.Exclamation) == DialogResult.No)
          return;
      }

      //    'on affiche la boite de dialogue
      CommonDialog1.ReadOnlyChecked = true;
      CommonDialog1.Title = Resources.msg_PDF_file_choice;
      CommonDialog1.Filter = "Fichiers PDF (*.PDF)|*.PDF";
      CommonDialog1.FilterIndex = 1;

      CommonDialog1.ShowDialog();

      sFichier = CommonDialog1.FileName;

      MozartUcUtils.SpyLog(MozartDatabase.cnxMozart, "", cmdSelectContEiCliSigne.Tag.ToString(), "Entrée", "FICHIER:" + sFichier);

      WebBrowser1.Navigate(sFichier);             //    Afficher l'image

      SignatureClientContratiEISave(mlProc);      //    Save dans la BD

      cmdSelectContEiCliSigne.BackColor = Color.Yellow;
    }

    private void CmdDelSignContEI_Click(object sender, EventArgs e)
    {
      if (mlProc == 0) return;

      if (SignatureClientContratiEIExists(mlProc) == false) return;

      if (MessageBox.Show(Resources.msg_confirm_contrat_signed_deletion, Program.AppTitle, MessageBoxButtons.YesNo, MessageBoxIcon.Question,
                          MessageBoxDefaultButton.Button2) == DialogResult.Yes)
      {
        MozartUcUtils.SpyLog(MozartDatabase.cnxMozart, "", cmdDelSignContEI.Tag.ToString(), "Suppression", "NCLINUM:" + miNumClient, "NIDPROC:" + mlProc);
        SignatureClientContratiEIDelete(mlProc);

      }
    }

    private void OuvertureEnCreation()
    {
      switch (mstrType)
      {
        case "PROCEDURE":
          this.Text = Resources.text_Add_procedure_Client;
          break;
        case "PROCEDURESITE":
          this.Text = Resources.text_add_procedure_site;
          break;
        case "ADMINISTRATIF":
          this.Text = Resources.text_add_docs_admin + MozartParams.NomSociete;
          break;
        case "PREVENTIONCONTRAT":
          this.Text = Resources.text_add_docs_admin_web;
          Calendar1.Value = DateTime.Now;
          break;
        case "PLANPREVDI":
          this.Text = Resources.text_add_docs_DI;
          break;
        default:
          break;
      }
    }

    private void OuvertureEnModification()
    {
      try
      {
        using (SqlDataReader dr = ModuleData.ExecuteReader("SELECT VTITRE, VFICHIER, NIDTYPPROC, CONVERT(VARCHAR(15), DPROCVALID, 103) AS DPROCVALID, "
                         + "CONVERT(VARCHAR(15), DPROCECHEANCE, 103) AS DPROCECHEANCE, CONVERT(INT, ISNULL(BPROCTACITERECOND, 0)) AS BPROCTACITERECOND, "
                         + "CONVERT(INT, ISNULL(BPASDECONTRATEI, 0)) AS BPASDECONTRATEI, CONVERT(INT, ISNULL(BPROC_PDP_ACTION, 0)) AS BPROC_PDP_ACTION, "
                         + "VLANGUE FROM TPROCEDURE WITH (NOLOCK) WHERE NIDPROC = " + mlProc))
        {
          if (dr.Read())
          {
            txtTitre.Text = dr["VTITRE"].ToString();
            cboTypProc.SelectedValue = dr["NIDTYPPROC"].ToString();
            txtDateValidation.Text = dr["DPROCVALID"].ToString();
            sFichierOld = dr["VFICHIER"].ToString();
            txtDateEcheance.Text = Utils.BlankIfNull(dr["DPROCECHEANCE"]);
            chkTaciteRecond.Checked = dr["BPROCTACITERECOND"].ToString() == "1";
            chkPasDeContratEI.Checked = dr["BPASDECONTRATEI"].ToString() == "1";
            ChkPDP_Action.Checked = dr["BPROC_PDP_ACTION"].ToString() == "1";
            cboLangue.Text = Utils.BlankIfNull(dr["VLANGUE"].ToString());
            sFichier = sFichierOld;
          }
          dr.Close();
        }

        WebBrowser1.Navigate(CImpersonation.OpenFileImpersonated(mstrRepFichier + sFichier));
        cmdValider.Visible = cmdFichier.Visible = true;
      }
      catch (Exception ex)
      {
        MZUtils.displayError(MethodBase.GetCurrentMethod().Name, ex);
      }
    }

    private void frmDetailsProcedure_FormClosed(object sender, FormClosedEventArgs e)
    {
      MozartUcUtils.SpyLog(MozartDatabase.cnxMozart, "", "", "Sortie");
    }

    private void ChkTaciteRecond_CheckedChanged(object sender, EventArgs e)
    {
      // on teste si il y a une date d echeance
      if (txtDateEcheance.Text != "")
      {
        if (chkTaciteRecond.Checked)
        {
          MessageBox.Show(Resources.text_tacite_reconduction_interdite, Program.AppTitle, MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
          chkTaciteRecond.Checked = false;
        }
      }
    }

    private void cboTypProc_SelectedIndexChanged(object sender, EventArgs e)
    {
      if (int.TryParse(cboTypProc.SelectedValue.ToString(), out int i) && (int)cboTypProc.SelectedValue == 15)
      {
        ChkPDP_Action.Visible = false;

        //on teste si procedure existe
        if (mlProc > 0)
        {
          // on teste si signature exists
          if (SignatureClientContratiEIExists(mlProc))
          {
            cmdSelectContEiCliSigne.BackColor = Color.Yellow;
            cmdSelectContEiCliSigne.Visible = cmdDelSignContEI.Visible = true;
          }
          else
          {
            cmdSelectContEiCliSigne.BackColor = COLOR_GREY;
            cmdSelectContEiCliSigne.Visible = cmdDelSignContEI.Visible = true;
          }
        }
        else
        {
          cmdSelectContEiCliSigne.BackColor = COLOR_GREY;
          cmdSelectContEiCliSigne.Visible = cmdDelSignContEI.Visible = true;
        }
      }
      else
      {
        cmdSelectContEiCliSigne.Visible = cmdDelSignContEI.Visible = false;
        if (int.TryParse(cboTypProc.SelectedValue.ToString(), out int j) && ((int)cboTypProc.SelectedValue == 3 || (int)cboTypProc.SelectedValue == 13 || (int)cboTypProc.SelectedValue == 12))
        {
          ChkPDP_Action.Visible = true;
        }
        else
        {
          ChkPDP_Action.Visible = false;
        }
      }
    }

    private void RemplirComboLangues()
    {
      try
      {
        using (SqlDataReader dr = ModuleData.ExecuteReader("SELECT DISTINCT VLANGUEDEFAUT FROM TPAYS ORDER BY VLANGUEDEFAUT"))
        {
          while (dr.Read())
          {
            cboLangue.Items.Add(dr["VLANGUEDEFAUT"].ToString());
          }
        }
      }
      catch (Exception ex)
      {
        MZUtils.displayError(MethodBase.GetCurrentMethod().Name, ex);
      }
    }

    private void SignatureClientContratiEIDelete(long p_iproc)
    {
      ModuleData.ExecuteNonQuery("api_sp_ContEISignClientDelete " + p_iproc);

      MozartUcUtils.SpyLog(MozartDatabase.cnxMozart, Text, "Signature Client Contrat Delete", "Suppression", "NCLINUM:" + miNumClient, "NSITNUM:" + miNumSite, "NIDPROC:" + p_iproc);

      cmdSelectContEiCliSigne.BackColor = COLOR_GREY;
      cmdSelectContEiCliSigne.Visible = cmdDelSignContEI.Visible = true;
    }

    private void SignatureClientContratiEISave(long p_iproc)
    {
      ModuleData.ExecuteNonQuery("api_sp_ContEISignClientSave " + p_iproc);
      MozartUcUtils.SpyLog(MozartDatabase.cnxMozart, this.Text, "Signature Client Contrat Save", "Modification", "NCLINUM:" + miNumClient, "NSITNUM:" + miNumSite, "NIDPROC:" + p_iproc);

      cmdSelectContEiCliSigne.BackColor = COLOR_GREY;
      cmdSelectContEiCliSigne.Visible = cmdDelSignContEI.Visible = true;
    }

    private bool SignatureClientContratiEIExists(long p_iproc)
    {
      return (int)ModuleData.ExecuteScalarInt("api_sp_ContEISignClientExist " + p_iproc) > 0;
    }
  }
}