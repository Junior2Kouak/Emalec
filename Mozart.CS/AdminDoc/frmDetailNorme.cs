using Microsoft.VisualBasic;
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
  public partial class frmDetailNorme : Form
  {
    public long mlIDNORME;
    private string msFichier = "";
    private string msFichierOld = "";
    private string CheminFicheNorme = "";

    public frmDetailNorme()
    {
      InitializeComponent();
    }

    private void frmDetailNorme_Load(object sender, System.EventArgs e)
    {
      try
      {
        ModuleMain.Initboutons(this);

        CheminFicheNorme = Utils.RechercheParam("REP_FICHE_NORME");

        if (mlIDNORME == 0)
          OuvertureEnCreation();
        else
          OuvertureEnModification();
      }
      catch (Exception ex)
      {
        MZUtils.displayError(MethodBase.GetCurrentMethod().Name, ex);
      }
    }

    private void OuvertureEnCreation()
    {
    }

    private void cmdValider_Click(object sender, EventArgs e)
    {
      try
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

        if (txtDateNorme.Text == "")
        {
          MessageBox.Show(Resources.msg_must_type_creation_date, Program.AppTitle, MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
          return;
        }

        string sNomFichier = "";
        if (msFichierOld != msFichier)
          sNomFichier = MozartParams.NomSociete + DateTime.Now.ToString("yyyyMMddHHmmss") + "." + Strings.Right(msFichier, 3);
        else
          sNomFichier = msFichierOld;

        using (SqlCommand cmd = new SqlCommand("api_sp_creationNorme", MozartDatabase.cnxMozart))
        {
          cmd.CommandType = CommandType.StoredProcedure;
          SqlCommandBuilder.DeriveParameters(cmd);

          cmd.Parameters["@iNumNorme"].Value = mlIDNORME;
          cmd.Parameters["@vTitre"].Value = txtTitre.Text;
          cmd.Parameters["@vlibNorme"].Value = txtLib.Text;
          cmd.Parameters["@ddatNorme"].Value = txtDateNorme.Text;
          cmd.Parameters["@vFicNorme"].Value = sNomFichier;
          cmd.Parameters["@vTechNorme"].Value = txtTechNorme.Text;
          cmd.ExecuteNonQuery();
          mlIDNORME = Convert.ToInt32(cmd.Parameters[0].Value);
        }

        if (msFichierOld != msFichier)
        {
          //  copie du nouveau fichier
          // gestion des droits.
          // le user Impersonate n'a pas les droits sur l'ensemble du réseau mais uniquement sur les répertoires de stockage des fichiers listé dans Mozart.
          // donc si l'utilisateur va chercher un fichier sur un répertoire du réseau, la copie en Impersonate plante.
          // Il faut copier en local avec les droits de l'utilisateur, puis dans le répertoire de stockage en Impersonate
          string sTempFile = $@"{Path.GetTempFileName()}";
          File.Copy(msFichier, sTempFile, true);
          string sNewTempFile = $"{sTempFile}.Mozart{Path.GetExtension(msFichier)}";
          File.Move(sTempFile, sNewTempFile);
          CImpersonation.CopyFileImpersonated(sNewTempFile, CheminFicheNorme + sNomFichier);
          File.Delete(sNewTempFile);

          // suppression de l'ancien fichier si remplacement
          if (msFichierOld != "")
          {
            if (CImpersonation.FileExistImpersonated(CheminFicheNorme + msFichierOld))
            {
              CImpersonation.DeleteFileImpersonated(CheminFicheNorme + msFichierOld);
            }
          }
        }

        Dispose();
      }
      catch (Exception ex)
      {
        MZUtils.displayError(MethodBase.GetCurrentMethod().Name, ex);
      }
    }

    private void cmdFichier_Click(object sender, EventArgs e)
    {
      //CommonDialog1.CancelError = true;
      CommonDialog1.ReadOnlyChecked = true;
      CommonDialog1.Title = Resources.msg_PDF_file_choice;
      CommonDialog1.Filter = "Fichiers PDF (*.PDF)|*.PDF";
      CommonDialog1.FilterIndex = 1;

      if (CommonDialog1.ShowDialog() == DialogResult.OK)
      {
        msFichier = CommonDialog1.FileName;
        // Afficher l'image
        WebBrowser1.Navigate(msFichier);
      }
    }

    private void cmdDate_Click(object sender, EventArgs e)
    {
      DateTime d;
      if (DateTime.TryParse(txtDateNorme.Text, out d))
        _curDate = Calendar1.Value = d;
      else { _curDate = DateTime.MinValue; Calendar1.Value = DateTime.Now; }
      Calendar1.Visible = true;
      Calendar1.ShowCalendar(new MouseEventArgs(MouseButtons.Left, 1, MousePosition.X - this.Location.X, MousePosition.Y - this.Location.Y, 0));
    }

    private void cmdSupp_Click(object sender, EventArgs e)
    {
      txtDateNorme.Text = "";
    }

    DateTime _curDate = DateTime.MinValue;
    private void Calendar1_CloseUp(object sender, EventArgs e)
    {
      Calendar1.Visible = false;
      if (_curDate == DateTime.MinValue) return;
      txtDateNorme.Text = Calendar1.Value.ToShortDateString();
    }
    private void Calendar1_ValueChanged(object sender, EventArgs e)
    {
      if (Calendar1.Visible) _curDate = Calendar1.Value;
    }

    private void OuvertureEnModification()
    {
      try
      {
        msFichierOld = "";

        using (SqlDataReader dr = ModuleData.ExecuteReader("SELECT ISNULL(VLIBNORME, '') AS VLIBNORME, ISNULL(VTECHNORME, '') AS VTECHNORME, " +
                                                           "ISNULL(VTITRENORME, '') AS VTITRENORME, CONVERT(VARCHAR(15), DDATENORME, 103) AS DDATENORME, " +
                                                           "VFICNORME  FROM TFICHENORME WHERE NID = " + mlIDNORME))
        {
          //    recherche des informations sur le fichier
          if (dr.Read())
          {
            txtTitre.Text = dr["VTITRENORME"].ToString();
            txtTechNorme.Text = dr["VTECHNORME"].ToString();
            txtLib.Text = dr["VLIBNORME"].ToString();
            txtDateNorme.Text = dr["DDATENORME"].ToString();
            msFichierOld = dr["VFICNORME"].ToString();
            msFichier = msFichierOld;
          }

          //     ouverture du fichier       
          WebBrowser1.Navigate(CImpersonation.OpenFileImpersonated(CheminFicheNorme + dr["VFICNORME"].ToString()));
          dr.Close();
        }
      }
      catch (Exception ex)
      {
        MZUtils.displayError(MethodBase.GetCurrentMethod().Name, ex);
      } finally
      {
        Cursor.Current = Cursors.Default;
      }
    }
  }
}