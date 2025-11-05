using MozartCS.Properties;
using MozartLib;
using MozartNet;
using System;
using System.Data;
using System.Data.SqlClient;
using System.Reflection;
using System.Windows.Forms;
using MZUtils = MozartControls.Utils;

namespace MozartCS
{
  public partial class frmDetailDoc : Form
  {
    private const string MSTRYPE = "NOTICES";

    public int miProc;
    private string msRepertoireDoc;

    private string msFichier = "";
    private string msFichierOld = "";

    // pRepertoireDoc : Répertoire des documents
    // pIdProc : Id du doc ou 0 si création
    public frmDetailDoc(string pRepertoireDoc, int pIdProc)
    {
      InitializeComponent();

      msRepertoireDoc = pRepertoireDoc;
      miProc = pIdProc;
    }

    private void frmDetailDoc_Load(object sender, EventArgs e)
    {
      try
      {
        ModuleMain.Initboutons(this);
        if (miProc > 0)
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

      if (Utils.BlankIfNull(msFichier) == "")
      {
        MessageBox.Show(Resources.msg_must_select_file, Program.AppTitle, MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
        return;
      }

      SqlCommand cmd = new SqlCommand("api_sp_creationDoc", MozartDatabase.cnxMozart);
      cmd.CommandType = CommandType.StoredProcedure;
      SqlCommandBuilder.DeriveParameters(cmd);

      cmd.Parameters["@iDoc"].Value = miProc;
      cmd.Parameters["@vTitre"].Value = txtTitre.Text;
      cmd.Parameters["@vFichier"].Value = msFichierOld != msFichier ? "temp" : msFichier;
      cmd.Parameters["@vType"].Value = MSTRYPE;
      cmd.ExecuteNonQuery();
      miProc = Convert.ToInt32(cmd.Parameters[0].Value);

      if (msFichierOld != msFichier)
      {
        CImpersonation.CopyFileImpersonated(msFichier, msRepertoireDoc + MSTRYPE + miProc + ".pdf");
        ModuleData.ExecuteNonQuery("UPDATE TDOCEMALEC SET VFICHIER = '" + MSTRYPE + miProc + ".pdf" + "' WHERE NIDDOC = " + miProc);
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

      CommonDialog1.ShowDialog();

      msFichier = CommonDialog1.FileName;

      // Afficher l'image
      WebBrowser1.Navigate(msFichier);
    }

    private void OuvertureEnModification()
    {
      using (SqlDataReader dr = ModuleData.ExecuteReader("SELECT * FROM TDOCEMALEC WHERE NIDDOC = " + miProc))
      {
        if (dr.Read())
        {
          txtTitre.Text = dr["VTITRE"].ToString();
          WebBrowser1.Navigate(CImpersonation.OpenFileImpersonated(msRepertoireDoc + dr["VFICHIER"].ToString()));

          msFichierOld = dr["VFICHIER"].ToString();
          msFichier = msFichierOld;
        }
        dr.Close();
      }

      cmdValider.Visible = true;
      cmdFichier.Visible = true;
    }

		private void cmdFichier_DragEnter(object sender, DragEventArgs e)
		{
      e.Effect = DragDropEffects.All;
		}

		private void cmdFichier_DragDrop(object sender, DragEventArgs e)
		{
      string[] files = (string[])e.Data.GetData(DataFormats.FileDrop, false);

      if (files.GetLength(0) > 1)
      {
        MessageBox.Show("Il faut sélectionner un seul fichier", "Drag & drop", MessageBoxButtons.OK, MessageBoxIcon.Information);
        return;
      }
      if (!files[0].Contains(".pdf"))
      {
        MessageBox.Show("Seul les fichiers pdf sont autorisés", "Drag & drop", MessageBoxButtons.OK, MessageBoxIcon.Information);
        return;
      }

      msFichier = files[0];

      // Afficher l'image
      WebBrowser1.Navigate(msFichier);
    }
  }
}