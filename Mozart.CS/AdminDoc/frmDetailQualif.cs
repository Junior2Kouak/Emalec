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
  public partial class frmDetailQualif : Form
  {

    public int miIdQualif;
    public string CheminFicQualif;   // gestion en variable local plutôt qu'en variable globale du projet

    private string sSourceFicQualif = ""; // contient le chemin + nom du fichier du fichier source 

    public frmDetailQualif()
    {
      InitializeComponent();
    }

    private void frmDetailQualif_Load(object sender, System.EventArgs e)
    {
      try
      {
        ModuleMain.Initboutons(this);

        // on affiche le nom de la société en question
        Label1.Text += " " + MozartParams.NomSociete;

        RemplirComboLangues();

        if (miIdQualif > 0)
        {
          //ouverture en modification
          using (SqlDataReader dr = ModuleData.ExecuteReader("exec api_sp_RetourInfoQualif " + miIdQualif + ", '" + MozartParams.NomSociete + "'"))
          {
            if (dr.Read())
            {
              txtLibQualif.Text = Utils.BlankIfNull(dr["VQUALIFLIB"].ToString());
              txtNumCertif.Text = Utils.BlankIfNull(dr["VQUALIFNUMCERT"].ToString());
              DateObtention.Text = Utils.BlankIfNull(dr["DQUALIFOBTEN"].ToString());
              DateRenouvellement.Text = Utils.BlankIfNull(dr["DAQUALIFRENOUV"].ToString());
              txtNomFic.Text = Utils.BlankIfNull(dr["VQUALIFNOMFIC"].ToString());
              cboLangue.Text = Utils.BlankIfNull(dr["VLANGUE"].ToString());

              //charge le fichier PDF
              if (dr["VQUALIFNOMFIC"].ToString() != "")
              {
                WebBrowser1.Navigate(CImpersonation.OpenFileImpersonated(CheminFicQualif + dr["VQUALIFNOMFIC"].ToString()));
              }

            }
            dr.Close();
          }
        }
      }
      catch (Exception ex)
      {
        MZUtils.displayError(MethodBase.GetCurrentMethod().Name, ex);
      }
    }


    private void cmdEnregistrer_Click(object sender, EventArgs e)
    {
      if (txtLibQualif.Text == "")
      {
        MessageBox.Show(Resources.msg_must_type_qualification, Program.AppTitle, MessageBoxButtons.OK, MessageBoxIcon.Stop);
        return;
      }

      using (SqlCommand cmd = new SqlCommand("api_sp_CreationQualif", MozartDatabase.cnxMozart))
      {
        cmd.CommandType = CommandType.StoredProcedure;
        SqlCommandBuilder.DeriveParameters(cmd);

        cmd.Parameters["@iIdQualif"].Value = miIdQualif;  // 0 si création
        cmd.Parameters["@vQualifLib"].Value = Utils.BlankIfNull(txtLibQualif.Text);
        cmd.Parameters["@vQualifNumCert"].Value = Utils.BlankIfNull(txtNumCertif.Text);
        cmd.Parameters["@dQualifObten"].Value = DateObtention.Text == "" ? null : DateObtention.Text;
        cmd.Parameters["@dQualifRenouv"].Value = DateRenouvellement.Text == "" ? null : DateRenouvellement.Text;
        cmd.Parameters["@vQualifNomFic"].Value = Utils.BlankIfNull(txtNomFic.Text);
        cmd.Parameters["@vNomSociete"].Value = MozartParams.NomSociete;
        cmd.Parameters["@vLangue"].Value = cboLangue.Text;

        cmd.ExecuteNonQuery();
        miIdQualif = Convert.ToInt32(cmd.Parameters[0].Value);
      }

      //  copie du fichier PDF uniquement si il a changé
      if (sSourceFicQualif != "" && File.Exists(sSourceFicQualif))
      {
        // gestion des droits.
        // le user Impersonate n'a pas les droits sur l'ensemble du réseau mais uniquement sur les répertoires de stockage des fichiers listé dans Mozart.
        // donc si l'utilisateur va chercher un fichier sur un répertoire du réseau, la copie en Impersonate plante.
        // Il faut copier en local avec les droits de l'utilisateur, puis dans le répertoire de stockage en Impersonate
        string sTempFile = $@"{Path.GetTempFileName()}";
        File.Copy(sSourceFicQualif, sTempFile, true);
        string sNewTempFile = $"{sTempFile}.Mozart{Path.GetExtension(sSourceFicQualif)}";
        File.Move(sTempFile, sNewTempFile);

        CImpersonation.CopyFileImpersonated(sNewTempFile, CheminFicQualif + txtNomFic.Text);
        File.Delete(sNewTempFile);

        //Thread.Sleep(1000);
      }
    }

    private void cmdFicOpen_Click(object sender, EventArgs e)
    {
      // gestion de la modification du fichier : il faut supprimer d'abord le fichier existant
      if (txtNomFic.Text != "")
      {
        MessageBox.Show("Pour changer le fichier, il faut d'abord supprimer l'ancien", Program.AppTitle, MessageBoxButtons.OK, MessageBoxIcon.Stop);
        return;
      }

      OpenFileDlg.Filter = "Fichiers PDF (*.PDF)|*.PDF";
      OpenFileDlg.ShowDialog();

      txtNomFic.Text = OpenFileDlg.SafeFileName;
      sSourceFicQualif = OpenFileDlg.FileName;

      // charge le fichier PDF
      WebBrowser1.Navigate(sSourceFicQualif);
    }

    private void cmdFicDel_Click(object sender, EventArgs e)
    {
      try
      {
        if (MessageBox.Show("Voulez-vous supprimer ce fichier ? ", Program.AppTitle, MessageBoxButtons.YesNo, MessageBoxIcon.Question, MessageBoxDefaultButton.Button2) != DialogResult.Yes)
        {
          return;
        }

        //  suppression du fichier
        sSourceFicQualif = "";

        if (CImpersonation.FileExistImpersonated(CheminFicQualif + txtNomFic.Text))
        {
          CImpersonation.DeleteFileImpersonated(CheminFicQualif + txtNomFic.Text);
        }

        txtNomFic.Text = "";
      }
      catch (Exception ex)
      {
        MZUtils.displayError(MethodBase.GetCurrentMethod().Name, ex);
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
  }
}