using MozartCS.Properties;
using MozartLib;
using MozartNet;
using System;
using System.Data;
using System.Data.SqlClient;
using System.Reflection;
using System.Windows.Forms;
using MZUtils = MozartControls.Utils;
using Aspose.Email;
using System.IO;
using System.Runtime.InteropServices;
using System.Text;

namespace MozartCS
{
  public partial class frmDetailMsgOutlook : Form
  {
    private const string MSTRYPE = "NOTICES";

    public int miProc;
    private string msRepertoireDoc;

    private string msFichier = "";
    private string msFichierOld = "";

    // pRepertoireDoc : Répertoire des documents
    // pIdProc : Id du doc ou 0 si création
    public frmDetailMsgOutlook(string pRepertoireDoc, int pIdProc)
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

    private string ReadFileNameFromDescriptor(byte[] descriptor)
    {
      // Lecture du nom du fichier dans le descripteur (offset 76 pour Unicode)
      // Format FileGroupDescriptorW : voir documentation Microsoft et exemples
      int offset = 76; // pour FileGroupDescriptorW
      StringBuilder sb = new StringBuilder();
      for (int i = offset; i < descriptor.Length; i += 2)
      {
        char c = BitConverter.ToChar(descriptor, i);
        if (c == '\0') break;
        sb.Append(c);
      }
      return sb.ToString();
    }

    private void cmdFichier_DragEnter(object sender, DragEventArgs e)
		{
      e.Effect = DragDropEffects.All;
		}

    private void cmdFichier_DragDrop(object sender, DragEventArgs e)
    {


      // Récupère le descripteur du fichier (nom du message)
      string descriptorFormat = e.Data.GetDataPresent("FileGroupDescriptorW") ?
          "FileGroupDescriptorW" : "FileGroupDescriptor";
      MemoryStream ms = (MemoryStream)e.Data.GetData(descriptorFormat);
      byte[] descriptorBytes = ms.ToArray();
      string fileName = ReadFileNameFromDescriptor(descriptorBytes);

      // Récupère le contenu du message (FileContents)
      MemoryStream fileContents = (MemoryStream)e.Data.GetData("FileContents");
      byte[] fileContentBytes = fileContents.ToArray();

      // Sauvegarde le message au format .msg
      string savePath = Path.Combine(Environment.GetFolderPath(Environment.SpecialFolder.Desktop), fileName);
      File.WriteAllBytes(savePath, fileContentBytes);

      MessageBox.Show($"Message sauvegardé : {savePath}");

      using (var message = MailMessage.Load(savePath))
			{
				// Convertir en HTML et sauvegarder dans un fichier temporaire
				string tempHtmlPath = System.IO.Path.GetTempFileName() + ".html";
				message.Save(tempHtmlPath, SaveOptions.DefaultHtml);

				// Afficher l'image
				WebBrowser1.Navigate(tempHtmlPath);
			}

		}

  


  //  private void cmdFichier_DragDrop(object sender, DragEventArgs e)
		//{

   
  //    string[] files = (string[])e.Data.GetData(DataFormats.FileDrop, false);

  //    if (files.GetLength(0) > 1)
  //    {
  //      MessageBox.Show("Il faut sélectionner un seul fichier", "Drag & drop", MessageBoxButtons.OK, MessageBoxIcon.Information);
  //      return;
  //    }
  //    if (!files[0].Contains(".msg"))
  //    {
  //      MessageBox.Show("Seul les fichiers .msg sont autorisés", "Drag & drop", MessageBoxButtons.OK, MessageBoxIcon.Information);
  //      return;
  //    }

  //    msFichier = files[0];

  //    // Charger le fichier MSG
  //    using (var message = MailMessage.Load(msFichier))
  //    {
  //      // Convertir en HTML et sauvegarder dans un fichier temporaire
  //      string tempHtmlPath = System.IO.Path.GetTempFileName() + ".html";
  //      message.Save(tempHtmlPath, SaveOptions.DefaultHtml);

  //      // Afficher l'image
  //      WebBrowser1.Navigate(tempHtmlPath);
  //    }

  //  }

		private void fileDropTargetPanel1_DragDrop(object sender, DragEventArgs e)
		{
//      var args = new Aspose.Email.Windows.Forms.FileDragEventArgs(e);
      Aspose.Email.Windows.Forms.FileDragEventArgs args;
      args = (Aspose.Email.Windows.Forms.FileDragEventArgs)e;

       foreach (var file in args.Files)
       {
        // file contient le message Outlook
        //    file.Save("message.msg");
          // Convertir en HTML et sauvegarder dans un fichier temporaire
          string tempHtmlPath = System.IO.Path.GetTempFileName() + ".html";
        var message = MailMessage.Load(msFichier);
        message.Save(tempHtmlPath, SaveOptions.DefaultHtml);

          // Afficher l'image
          WebBrowser1.Navigate(tempHtmlPath);

        }

    }

		private void fileDropTargetPanel1_DragEnter(object sender, DragEventArgs e)
		{
      e.Effect = DragDropEffects.Copy;
    }
	}
}