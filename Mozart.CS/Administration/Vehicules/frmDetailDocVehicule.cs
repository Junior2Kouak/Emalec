using MozartCS.Properties;
using MozartLib;
using MozartNet;
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
  public partial class frmDetailDocVehicule : Form
  {
    //ouverture de la fenetre en création ou modification
    private string mstrStatut = "C";
    private int miDoc;
		private readonly int nvehnum;

		private readonly string mRepertoireDoc;

    bool bModif;
    bool bModFile;
    bool bEnrOK;
		string strFichierOld = "";
		string sTypeFile;

    Point locPdf;
    Size szPdf;
    

    public frmDetailDocVehicule(int NID, int NVEHNUM, string Rep)
    {
      miDoc= NID;
			nvehnum = NVEHNUM;
			mRepertoireDoc = Rep;
			InitializeComponent();
    }

		private void frmDetailDocVehicule_Load(object sender, EventArgs e)
		{
			try
			{
				// Position et taille du browser gardés pour Maxi/Mini
				locPdf = WebBrowser1.Location;
        szPdf = WebBrowser1.Size;

        //  ' initialisation des images des boutons
        ModuleMain.Initboutons(this);

        ModuleData.RemplirCombo(cboDoc, $"select * from api_v_listetypeDocAuto ORDER BY  DOC");
        cboDoc.ValueMember = "DOC";
        cboDoc.DisplayMember = "DOC";

          // On ne peut ajouter que des PDF dans les doc techniciens
          // fGA le 25/0924 ajout gestion des photos
          CommonDialog1.Filter = "Fichiers  |*.PDF;*.JPG;*.PNG;*.GIF;*.JPEG";
        //CommonDialog1.FilterIndex = 1;

        // traitement du cas de modification ou de création
        if (miDoc != 0)
          OuvertureEnModification();
        else
          cboDoc.Text =  "Sinistre - Document déclaratif";

				bModif = false;
        bModFile = false;
        Cursor.Current = Cursors.Default;
      }
      catch (Exception ex)
      {
        MZUtils.displayError(MethodBase.GetCurrentMethod().Name, ex);
      }
    }

    private void cmdFermer_Click(object sender, System.EventArgs e)
    {
      try
      {
        if (bModif)
        {
          switch (MessageBox.Show(Resources.msgConfirm_enregistrerModif, Program.AppTitle, MessageBoxButtons.YesNo, MessageBoxIcon.Question, MessageBoxDefaultButton.Button1))
          {
            case DialogResult.Yes:
              cmdValider_Click(null, null);
              Close();
              break;
            case DialogResult.No:
              Close();
              break;
            case DialogResult.Cancel:
              return;
          }
        }
        else
        {
          Cursor.Current = Cursors.WaitCursor;
          Close();
        }
        return;
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
        if (cboDoc.Text == "")
        {
          MessageBox.Show(Resources.msg_SelectDocType, Program.AppTitle, MessageBoxButtons.OK, MessageBoxIcon.Information);
        return;
        }

				if (txtNom.Text == "")
        {
					MessageBox.Show("Saisir un nom de document", Program.AppTitle, MessageBoxButtons.OK, MessageBoxIcon.Information);
					txtNom.Focus();
          return;
        }

        if (txtFichier.Text == "")
        {
					MessageBox.Show("Choisir un fichier", Program.AppTitle, MessageBoxButtons.OK, MessageBoxIcon.Information);
					txtFichier.Focus();
          return;
        }

        if (cboDoc.Text == "")
        {
          MessageBox.Show(Resources.msg_SelectDocType);
          cboDoc.Focus();
          return;
        }

        // le document a changé ou pas ?
        if ((mstrStatut == "M" && bModFile) || (mstrStatut == "C"))
          txtFichier.Text = $"{MozartParams.NomSociete}_{DateTime.Now.ToString("yyyyMMddHHmmss")}_{nvehnum}{Path.GetExtension(txtFichier.Text)}";

        EnregistrerDocEnBase();

        if (bEnrOK)
        {
          if ((mstrStatut == "M" && bModFile) || (mstrStatut == "C"))
            File.Copy(CommonDialog1.FileName, mRepertoireDoc + txtFichier.Text, overwrite: true);

					// suppression ancien fichier si besoin
					if ((txtFichier.Text != strFichierOld) && strFichierOld !="")
              File.Delete(mRepertoireDoc + strFichierOld);
					
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

 
    private void Command1_Click(object sender, EventArgs e)
    {
      try
      {
        CommonDialog1.ShowReadOnly = false;
        CommonDialog1.Title = Resources.msg_select_image_file;

        CommonDialog1.ShowDialog();

        //test du format de fichier (autoriser pdf,doc,xls,bmp,png,jpg,jpeg,gif,txt,docx,xlsx)
        string sExt = Path.GetExtension(CommonDialog1.FileName).ToLower();
        if (sExt != ".txt" && sExt != ".rtf" && sExt != ".pdf" && sExt != ".doc" && sExt != ".docx" && sExt != ".xls"
            && sExt != ".xlsx" && sExt != ".png" && sExt != ".jpg" && sExt != ".jpeg" && sExt != ".gif")
        {
          MessageBox.Show(Resources.msg_Forbidden_file_type);
          txtFichier.Text = "";
          return;
        }

        //Affiche le nom du fichier sélectionné
        txtFichier.Text = Path.GetFileName(CommonDialog1.FileName).ToLower();

        FileInfo fi = new FileInfo(CommonDialog1.FileName);
        if (fi.Length > 11000000)
        {
          MessageBox.Show(Resources.msg_file_too_big_cannot_insert_action, Program.AppTitle, MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
          txtFichier.Text = "";
          return;
        }

        //   Afficher l'image
        WebBrowser1.Navigate(CommonDialog1.FileName);

        bModif = true;
      }
      catch (Exception ex)
      {
        MZUtils.displayError(MethodBase.GetCurrentMethod().Name, ex);
      }
    }

    private void OuvertureEnModification()
    {
      
      try
      {
        mstrStatut = "M";

        //Donnees générales de l'objet
        using (SqlDataReader rs = ModuleData.ExecuteReader($"select * from TAUTODOC where NID = {miDoc}"))
        {
          if (rs.Read())
          {
            txtNom.Text = rs["VTITRE"].ToString();
            txtFichier.Text = rs["VFICHIER"].ToString();
						cboDoc.Text = rs["VTYPE"].ToString(); 
            txtComment.Text = Utils.BlankIfNull(rs["VCOMMENT"]);
            strFichierOld = txtFichier.Text;

						WebBrowser1.Visible = true;
            WebBrowser1.Navigate(mRepertoireDoc + txtFichier.Text);
          }
        }
      }
      catch (Exception ex)
      {
        MZUtils.displayError(MethodBase.GetCurrentMethod().Name, ex);
      }
    }

    private void EnregistrerDocEnBase()
    {
      try
      {
        using (SqlCommand cmd = new SqlCommand("api_sp_EnregistrerDocVehicule", MozartDatabase.cnxMozart))
        {
          cmd.CommandType = CommandType.StoredProcedure;
          SqlCommandBuilder.DeriveParameters(cmd);

          cmd.Parameters["@nID"].Value = miDoc;
          cmd.Parameters["@nvehnum"].Value = nvehnum;
					cmd.Parameters["@vTitre"].Value = txtNom.Text.Trim();
          cmd.Parameters["@vFichier"].Value = txtFichier.Text.Trim();
          cmd.Parameters["@vComment"].Value = txtComment.Text;
          cmd.Parameters["@nTypeDoc"].Value = cboDoc.Text;

          cmd.ExecuteNonQuery();
          miDoc = (int)cmd.Parameters["@nID"].Value;

          bEnrOK = true;
        }
      }
      catch (Exception ex)
      {
        bEnrOK = false;
        MZUtils.displayError(MethodBase.GetCurrentMethod().Name, ex);
      }
    }



    private void txtFic_TextChanged(object sender, EventArgs e)
    {
      bModFile = true;
    }


	}
}