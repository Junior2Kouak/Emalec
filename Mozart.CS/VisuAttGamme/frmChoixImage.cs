using MozartCS.Properties;
using MozartNet;
using System;
using System.Drawing;
using System.IO;
using System.Reflection;
using System.Windows.Forms;
using MZUtils = MozartControls.Utils;

namespace MozartCS
{
  public partial class frmChoixImage : Form
  {
    public frmChoixImage() { InitializeComponent(); }

    /*OK --------------------------------------------------------------*/
    public Form mForm;
    public string[] tFiles = new string[0];
    public string mstrDirPDFFiles;
    public long miNumMail;
    public long miNumGDM;
    public int i = 0;
    public string mstrNewFichier = ""; // Retour pour frmVisuAttGamme

    int NbImages;
    string mstrFileType;

    private void frmChoixImage_Load(object sender, System.EventArgs e)
    {
      try
      {
        Cursor.Current = Cursors.WaitCursor;
        ModuleMain.Initboutons(this);

        if (miNumMail > 0)
        {
          cmdOK.Visible = cmdDel.Visible = cmdChgDir.Visible = false;
          InitPJFiles();
        }
        else
        {
          if (miNumGDM > 0)
          {
            cmdOK.Visible = cmdDel.Visible = cmdChgDir.Visible = false;
            InitPJFilesGDM();
          }
          else
          {
            mstrFileType = "PDF";
            cmdChgDir.Visible = (mForm != null && mForm.Name == "frmVisuPDF") ? true : false;
            InitPdfFiles(0);
          }
        }
        if (tFiles.Length == 0)
          cmdOK.Enabled = cmdFirst.Enabled = cmdNext.Enabled = cmdPrev.Enabled = cmdDernier.Enabled = cmdDel.Enabled = false;
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

    private void cmdFermer_Click(object sender, System.EventArgs e)
    {
      mstrNewFichier = "";
      Close();
    }

    private void cmdOK_Click(object sender, EventArgs e)
    {
      mstrNewFichier = tFiles.Length > 0 ? tFiles[i] : "";
      Close();
    }

    private void cmdFirst_Click(object sender, EventArgs e)
    {
      i = 0;
      if (tFiles.Length > 0)
      {
        Pdf1.Navigate(tFiles[0]);
        Text = $"{Resources.txt_Choix_une_image}{NbImages}{Resources.txt_Images_tirets}{tFiles[0]}";
      }
      else
        Pdf1.Navigate("about:blank");

      cmdPrev.Enabled = false;
      cmdNext.Enabled = true;
    }

    private void cmdPrev_Click(object sender, EventArgs e)
    {
      if (i > 0)
      {
        i--;
        Pdf1.Navigate(tFiles[i]);
        cmdNext.Enabled = true;
      }
      cmdPrev.Enabled = i <= 0 ? false : true;
      Text = $"{Resources.txt_Choix_une_image}{NbImages}{Resources.txt_Images_tirets}{tFiles[i]}";

    }

    private void cmdNext_Click(object sender, EventArgs e)
    {
      if (i < NbImages - 1)
      {
        i++;
        Pdf1.Navigate(tFiles[i]);
        Text = $"{Resources.txt_Choix_une_image}{NbImages}{Resources.txt_Images_tirets}{tFiles[i]}";
        cmdPrev.Enabled = true;
      }
      cmdNext.Enabled = i >= NbImages - 1 ? false : true;
    }

    private void cmdDernier_Click(object sender, EventArgs e)
    {
      if (i == NbImages - 1) return;

      i = NbImages - 1;
      if (i >= 0)
      {
        Pdf1.Navigate(tFiles[NbImages - 1]);

        cmdPrev.Enabled = true;
        cmdNext.Enabled = false;
        Text = $"{Resources.txt_Choix_une_image}{NbImages}{Resources.txt_Images_tirets}{tFiles[NbImages - 1]}";
      }
    }

    private void cmdDel_Click(object sender, EventArgs e)
    {
      if (MessageBox.Show(Resources.msg_ConfirmDelImg, Program.AppTitle, MessageBoxButtons.YesNo, MessageBoxIcon.Question, MessageBoxDefaultButton.Button2) == DialogResult.Yes)
      {
        try
        {
          //    il faut fermer le fichier avant de le supprimer
          Pdf1.Navigate("about:blank");
          Size pdfSize = Pdf1.Size;
          Point pdfLocation = Pdf1.Location;
          AnchorStyles pdfAnchor = Pdf1.Anchor;
          //Pdf1.Stop();
          Pdf1.Dispose();
          Pdf1 = null;
          Pdf1 = new WebBrowser();
          Pdf1.Size = pdfSize;
          Pdf1.Location = pdfLocation;
          Pdf1.Anchor = pdfAnchor;
          this.Controls.Add(Pdf1);

          File.Delete(tFiles[i]);
          InitPdfFiles(i);
        }
        catch (Exception ex)
        {
          MZUtils.displayError(MethodBase.GetCurrentMethod().Name, ex);
        }
      }
    }

    private void CmdChgDir_Click(object sender, EventArgs e)
    {
      OpenFileDialog ofd = new OpenFileDialog();
      ofd.Filter = "Fichier PDF (*.PDF)|*.PDF";
      ofd.Multiselect = true;
      ofd.ShowDialog();
      mstrFileType = "PDF";

      if (ofd.FileName != "")
      {
        mstrDirPDFFiles = Path.GetDirectoryName(ofd.FileName);
        InitPdfFiles(0);

        if (tFiles.Length == 0)
          cmdOK.Enabled = cmdFirst.Enabled = cmdNext.Enabled = cmdPrev.Enabled = cmdDernier.Enabled = cmdDel.Enabled = false;
        else if (tFiles.Length == 1)
        {
          cmdOK.Enabled = cmdFirst.Enabled = true;
          cmdNext.Enabled = cmdPrev.Enabled = cmdDernier.Enabled = cmdDel.Enabled = false;
        }
        else if (tFiles.Length >= 1)
          cmdOK.Enabled = cmdFirst.Enabled = cmdNext.Enabled = cmdPrev.Enabled = cmdDernier.Enabled = cmdDel.Enabled = true;
      }
    }

    private void InitPdfFiles(int iPosInitiale)
    {
      tFiles = Directory.GetFiles(mstrDirPDFFiles, $"*.{mstrFileType}");

      NbImages = i = tFiles.Length;

      if (i == 1) cmdNext.Enabled = false;

      if (iPosInitiale == 0)
        i = 0;
      else
        i = iPosInitiale - 1;

      if (tFiles.Length > 0)
      {
        Pdf1.Navigate(tFiles[i]);
        Text = $"{Resources.txt_Choix_une_image}{NbImages}{Resources.txt_Images_tirets}{tFiles[i]}";
      }
      else
        Pdf1.Navigate("about:blank");
    }

    private void InitPJFiles()
    {
      string[] myTab = ModuleData.ExecuteScalarString($"select VDIMPJ FROM TDIMAIL WHERE NDIMNUM = {miNumMail}").Split(new char[] { '|' }, StringSplitOptions.RemoveEmptyEntries);

      NbImages = myTab.Length;
      tFiles = new string[NbImages];

      for (int j = 0; j < myTab.Length; j++)
        tFiles[j] = mstrDirPDFFiles + myTab[j];

      if (i == 1)
        cmdNext.Enabled = false;

      i = 0;

      if (tFiles.Length > 0)
      {
        Pdf1.Navigate(tFiles[0]);
        Text = $"{NbImages} fichier(s) -- {tFiles[i]}";
      }
      else
        Pdf1.Navigate("about:blank");
    }

    private void InitPJFilesGDM()
    {
      string[] myTab = ModuleData.ExecuteScalarString($"select DISTINCT VNOM FROM TGDM_LSTDOC WHERE NGDMNUM = {miNumGDM}").Split(new char[] { '|' }, StringSplitOptions.RemoveEmptyEntries);

      NbImages = myTab.Length;
      tFiles = new string[NbImages];

      for (int j = 0; j < myTab.Length; j++)
        tFiles[j] = mstrDirPDFFiles + myTab[j];

      if (i == 1)
        cmdNext.Enabled = false;

      if (tFiles.Length > 0)
      {
        Pdf1.Navigate(tFiles[i]);
        Text = $"{NbImages} fichier(s) -- {tFiles[i]}";
      }
      else
        Pdf1.Navigate("about:blank");
    }
  }
}