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
  public partial class frmAjoutDocPerso : Form
  {

    public long mlDoc = 0;
    public long mlIdPerso = 0;
    public string mstrStatut = "";
    public string mstrNomPerso = "";
    public string mstrPrenomPerso = "";
    public string mstrTypePerso = "";
    public string msLibNomSoc = "";
    public string mstrRepDocPerso = "";

    private bool bModif = false;
    private bool bModFile = false;
    private bool bEnrOK = false;

    private string strFormatFic = "";

    private int imgX;
    private int ImgY;
    private int ImgH;
    private int ImgW;

    OpenFileDialog CommonDialog1 = new OpenFileDialog();

    public frmAjoutDocPerso() { InitializeComponent(); }

    private void frmAjoutDocPerso_Load(object sender, System.EventArgs e)
    {
      try
      {
        Cursor.Current = Cursors.WaitCursor;

        imgX = WebBrowser1.Left;
        ImgY = WebBrowser1.Top;
        ImgH = WebBrowser1.Height;
        ImgW = WebBrowser1.Width;

        WebBrowser1.Visible = true;

        ModuleMain.Initboutons(this);

        Text = Resources.tlt_AjoutDocPersoDe + mstrNomPerso + " " + mstrPrenomPerso;

        ModuleData.RemplirCombo(cboFormatFichier, "exec api_sp_ComboFormat", true);

        // traitement du cas de modification ou de création
        if (mstrStatut == "M")
          OuvertureEnModification();

        bModif = false;
        bModFile = false;
      }
      catch (Exception ex)
      {
        MZUtils.displayError(MethodBase.GetCurrentMethod().Name, ex);
      } finally
      {
        Cursor.Current = Cursors.Default;
      }
    }

    private void cboFormatFichier_SelectedIndexChanged(object sender, EventArgs e)
    {
      if (cboFormatFichier.SelectedIndex > -1)
      {
        CommonDialog1.Filter = cboFormatFichier.Text + "|*." + ((DataRowView)cboFormatFichier.SelectedItem).Row["CFORMAT"].ToString();
        CommonDialog1.FilterIndex = 1;
      }
    }

    private void OuvertureEnModification()
    {
      try
      {
        string strImg = "";
        Text = Resources.txt_DetailImg;
        SqlDataReader rs = MozartDatabase.ExecuteReader("api_sp_RetourDocPerso " + mlDoc);
        if (rs.Read())
        {
          // Donnees générales de l'objet
          cboFormatFichier.SetItemData(rs["CFORMAT"].ToString());

          TextLib.Text = rs["VIMAGE"].ToString();
          TextFic.Text = rs["VFICHIER"].ToString();
          TextComment.Text = rs["VCOMMENT"].ToString();

          strFormatFic = rs["CFORMAT"].ToString();

          if (rs["VFICHIER"].ToString() != "")
            strImg = mstrRepDocPerso + rs["VFICHIER"].ToString();
        }
        rs.Close();

        WebBrowser1.Visible = true;

        if (CImpersonation.FileExistImpersonated(strImg))
        {
          WebBrowser1.Navigate(CImpersonation.OpenFileImpersonated(strImg));
        }
      }
      catch (Exception ex)
      {
        MZUtils.displayError(MethodBase.GetCurrentMethod().Name, ex);
      }
    }

    private void cmdValider_Click(object sender, EventArgs e)
    {
      try
      {
        if (TextLib.Text == "")
        {
          MessageBox.Show(Resources.msg_DecrireImg);
          TextLib.Focus();
          return;
        }

        if (TextFic.Text == "")
        {
          MessageBox.Show(Resources.msg_PreciserFichImg);
          TextFic.Focus();
          return;
        }

        if ((mstrStatut == "M" && bModFile) || mstrStatut == "C")
        {
          // Récupération compteur
          int lCount = MozartDatabase.ExecuteScalarInt("api_sp_GetCpt2 'DOCPER'");

          string[] ts = TextFic.Text.Split('.');

          if (mstrTypePerso == "PERSO")
            TextFic.Text = mlIdPerso + "_" + ts[0].Replace(" ", "_") + "_" + lCount + "." + ts[1];
          else
            TextFic.Text = mlIdPerso + "_" + mstrTypePerso + "_" + ts[0].Replace(" ", "_") + "_" + lCount + "." + ts[1];
        }

        enregistrerImg();

        if (bEnrOK)
        {
          if ((mstrStatut == "M" && bModFile) || mstrStatut == "C")
          {
            // Recopier le fichier sélectionné sur le serveur (en impersonation)
            CImpersonation.CopyFileImpersonated(CommonDialog1.FileName, mstrRepDocPerso + TextFic.Text);
          }

          mstrStatut = "M";
          bModif = false;
          bModFile = false;
        }

        Dispose();
      }
      catch (Exception ex)
      {
        MZUtils.displayError(MethodBase.GetCurrentMethod().Name, ex);
      }
    }

    private void cmdFermer_Click(object sender, System.EventArgs e)
    {
      if (!bModif)
      {
        Dispose();
        return;
      }

      switch (MessageBox.Show(Resources.msgConfirm_enregistrerModif, Program.AppTitle, MessageBoxButtons.YesNoCancel, MessageBoxIcon.Question, MessageBoxDefaultButton.Button2))
      {
        case DialogResult.Yes:
          cmdValider_Click(null, null);
          break;
        case DialogResult.No:
          Dispose();
          break;
        case DialogResult.Cancel:
          break;
      }
    }

    public void enregistrerImg()
    {
      try
      {
        // Création/mise à jour de l'objet
        SqlCommand cmd = new SqlCommand("api_sp_EnregDocPerso", MozartDatabase.cnxMozart)
        {
          CommandType = CommandType.StoredProcedure
        };

        //  ' liste des paramètres
        SqlCommandBuilder.DeriveParameters(cmd);

        cmd.Parameters["@iIDFICPERSO"].Value = mlDoc;
        cmd.Parameters["@iIDPERSO"].Value = mlIdPerso;
        cmd.Parameters["@vVIMAGE"].Value = TextLib.Text.Trim();
        cmd.Parameters["@vVFICHIER"].Value = TextFic.Text.Trim();
        cmd.Parameters["@cCFORMAT"].Value = ((DataRowView)cboFormatFichier.SelectedItem).Row.ItemArray[0];
        cmd.Parameters["@vVCOMMENT"].Value = TextComment.Text;
        cmd.Parameters["@vVTYPE"].Value = mstrTypePerso;
        cmd.ExecuteNonQuery();

        mlDoc = Convert.ToInt32(cmd.Parameters[0].Value);
        bEnrOK = true;
      }
      catch (Exception ex)
      {
        MZUtils.displayError(MethodBase.GetCurrentMethod().Name, ex);
        bEnrOK = false;
      }
    }

    private void TextFic_TextChanged(object sender, EventArgs e)
    {
      bModFile = true;
    }

    private void TextLib_TextChanged(object sender, EventArgs e)
    {
      bModFile = true;
    }

    private void cmdParcourir_Click(object sender, EventArgs e)
    {
      try
      {
        CommonDialog1.ShowReadOnly = false;
        CommonDialog1.Title = Resources.msg_select_image_file;

        if (CommonDialog1.ShowDialog() == DialogResult.OK)
        {
          if (strFormatFic.ToUpper() == "XLS")
            ModuleMain.EndAllEXCELProcess();

          WebBrowser1.Navigate(CommonDialog1.FileName);

          //  Affiche le nom du fichier sélectionné
          string[] ts = CommonDialog1.FileName.Split('\\');

          TextFic.Text = ts[ts.Length - 1];
          bModif = true;
        }
      }
      catch (Exception ex)
      {
        MZUtils.displayError(MethodBase.GetCurrentMethod().Name, ex);
      }
    }

    private void CmdMax_Click(object sender, EventArgs e)
    {
      if (cmdMax.Text == Resources.txt_Maxi)
      {
        WebBrowser1.Width = this.Width - 120;
        WebBrowser1.Height = this.Height - 90;
        WebBrowser1.Top = 40;
        WebBrowser1.Left = 100;
        WebBrowser1.BringToFront();
        cmdMax.Text = Resources.txt_Mini;
      }
      else
      {
        WebBrowser1.Width = ImgW;
        WebBrowser1.Height = ImgH;
        WebBrowser1.Top = ImgY;
        WebBrowser1.Left = imgX;
        cmdMax.Text = Resources.txt_Maxi;
      }
    }
  }
}
