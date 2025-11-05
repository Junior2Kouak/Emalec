using MozartCS.Properties;
using MozartLib;
using MozartNet;
using System;
using System.Data;
using System.Data.SqlClient;
using System.IO;
using System.Reflection;
using System.Windows.Forms;
using MZUtils = MozartControls.Utils;

namespace MozartCS
{
  public partial class frmDetailPlanPrevClient : Form
  {
    #region Définition des Variables
    public long mlProc;
    public string msTitre = "";

    public string mstrType = "";
    public int miNumClient;
    public int miNumSite;
    public string mstrRepFichier = "";

    private string sFichier = "";
    private string sFichierOld = "";

    #endregion

    public frmDetailPlanPrevClient()
    {
      InitializeComponent();
    }

    public frmDetailPlanPrevClient(int Proc, string _strType, int NumClient, int NumSite, string RepFichier)
    {
      InitializeComponent();
      mlProc = Proc;
      mstrType = _strType.ToUpper();
      miNumClient = NumClient;
      miNumSite = NumSite;
      mstrRepFichier = RepFichier;
    }

    private void frmDetailPlanPrevClient_Load(object sender, System.EventArgs e)
    {
      try
      {
        ModuleMain.Initboutons(this);
        if (mlProc == 0)
          OuvertureEnCreation();
        else
          OuvertureEnModification();


        Text = msTitre;

      }
      catch (Exception ex)
      {
        MZUtils.displayError(MethodBase.GetCurrentMethod().Name, ex);
      }
    }

    private void cmdFermer_Click(object sender, System.EventArgs e)
    {
      Dispose();
    }

    private void cmdValider_Click(object sender, EventArgs e)
    {
      if (Utils.BlankIfNull(txtTitre.Text) == "")
      {
        MessageBox.Show(Resources.msg_must_type_title, Program.AppTitle, MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
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

      if (TxtDateDebut.Text == "")
      {
        MessageBox.Show(Resources.msg_date_debut_obligatoire, Program.AppTitle, MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
        return;
      }

      if (txtDateEcheance.Text == "")
      {
        MessageBox.Show(Resources.msg_date_fin_obligatoire, Program.AppTitle, MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
        return;
      }

      if (ExistsPlansPrevClient() == 1)
      {
        MessageBox.Show(Resources.msg_plans_prev_multi_client, Program.AppTitle, MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
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
        cmd.Parameters["@iTypeProc"].Value = GetTypeProc(mstrType);
        cmd.Parameters["@ddatvalid"].Value = txtDateValidation.Text == "" ? null : txtDateValidation.Text;
        cmd.Parameters["@di"].Value = MozartParams.NumDi;
        cmd.Parameters["@dprocecheance"].Value = txtDateEcheance.Text == "" ? null : txtDateEcheance.Text;
        cmd.Parameters["@bproctaciterecond"].Value = 0;
        cmd.Parameters["@bpasDeContratEI"].Value = 0;
        cmd.Parameters["@bPDP_Action"].Value = ChkPDP_Action.Checked ? 1 : 0;
        cmd.Parameters["@p_datedebut"].Value = TxtDateDebut.Text == "" ? null : TxtDateDebut.Text;

        cmd.ExecuteNonQuery();
        mlProc = Convert.ToInt64(cmd.Parameters[0].Value);
      }

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

      Dispose();
    }

    private int GetTypeProc(string p_strType)
    {
      switch (p_strType)
      {
        case "PLANPREVCLIENT":
          return 3;

        case "PLANPREVSITE":
          return 12;

        default:
          return 0;
      }
    }

    private int ExistsPlansPrevClient()
    {
      return (int)ModuleData.ExecuteScalarInt($"EXEC [api_sp_PlanPrevClient_Exists] {miNumClient}, {mlProc}");
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

      switch ((sender as Button).Name)
      {
        case "cmdDate":
          txtDate = txtDateValidation.Text;
          Calendar1.Tag = "0";
          Calendar1.Location = txtDateValidation.Location;
          Calendar1.Size = txtDateValidation.Size;
          break;
        case "cmdDateDebut":
          txtDate = TxtDateDebut.Text;
          Calendar1.Tag = "2";
          Calendar1.Location = TxtDateDebut.Location;
          Calendar1.Size = TxtDateDebut.Size;
          break;
        case "cmdDateEche":
          txtDate = txtDateEcheance.Text;
          Calendar1.Tag = "1";
          Calendar1.Location = txtDateEcheance.Location;
          Calendar1.Size = txtDateEcheance.Size;
          break;

      }

      DateTime d;
      if (DateTime.TryParse(txtDate, out d))
        _curDate = Calendar1.Value = d;
      else { _curDate = DateTime.MinValue; Calendar1.Value = DateTime.Now; }

      Calendar1.Visible = true;
      Calendar1.Show();
    }

    private void Calendar1_CloseUp(object sender, EventArgs e)
    {
      Calendar1.Visible = false;
      if (_curDate == DateTime.MinValue) return;

      switch (Calendar1.Tag)
      {
        case "0":
          txtDateValidation.Text = Calendar1.Value.ToShortDateString();
          break;
        case "1":
          txtDateEcheance.Text = Calendar1.Value.ToShortDateString();
          break;
        case "2":
          TxtDateDebut.Text = Calendar1.Value.ToShortDateString();
          break;
      }
    }

    private void Calendar1_ValueChanged(object sender, EventArgs e)
    {
      if (Calendar1.Visible) _curDate = Calendar1.Value;
    }

    private void cmdSuppEcheance_Click(object sender, EventArgs e)
    {
      txtDateEcheance.Text = "";
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
          this.Text = Resources.Plans_de_prévention;
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
                                    + "CONVERT(VARCHAR(15), DPROCDEBUT, 103) AS DPROCDEBUT "
                                    + "FROM TPROCEDURE WITH (NOLOCK) WHERE NIDPROC = " + mlProc))
        {
          if (dr.Read())
          {
            txtTitre.Text = dr["VTITRE"].ToString();
            txtDateValidation.Text = dr["DPROCVALID"].ToString();
            TxtDateDebut.Text = dr["DPROCDEBUT"].ToString();
            sFichierOld = dr["VFICHIER"].ToString();
            txtDateEcheance.Text = Utils.BlankIfNull(dr["DPROCECHEANCE"]);
            ChkPDP_Action.Checked = dr["BPROC_PDP_ACTION"].ToString() == "1";
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

    private void cmdSuppDebut_Click(object sender, EventArgs e)
    {
      TxtDateDebut.Text = "";
    }
  }
}