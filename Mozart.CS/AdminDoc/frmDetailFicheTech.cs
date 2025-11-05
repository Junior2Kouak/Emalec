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
  public partial class frmDetailFicheTech : Form
  {
    public string msTypeFiche = "";
    public long miIDFICTECH;

    private string msCheminFicheTech = "";
    private string msFichier = "";
    private string msFichierOld = "";

    public frmDetailFicheTech()
    {
      InitializeComponent();
    }

    private void frmDetailFicheTech_Load(object sender, System.EventArgs e)
    {
      try
      {
        ModuleMain.Initboutons(this);

        msCheminFicheTech = Utils.RechercheParam("REP_FICHETECH");

        switch (msTypeFiche)
        {
          case "FP":
            Frame1.Text = "Titre de la fiche HSE";
            break;

          case "AD":
            Frame1.Text = "Titre de la fiche Procédure et Réglement";
            break;

          case "FT":
            Frame1.Text = "Titre de la fiche technique";
            ModuleData.RemplirCombo(cboSerie, "select 0, LIB 'VCLASSEMENT' from TREF_TYPEFICHE");
            cboSerie.ValueMember = "VCLASSEMENT";
            cboSerie.DisplayMember = "VCLASSEMENT";

            lblSerie.Visible = true;
            cboSerie.Visible = true;
            break;
        }

        if (miIDFICTECH == 0)
          OuvertureEnCreation();
        else
          OuvertureEnModification();
      }
      catch (Exception ex)
      {
        MZUtils.displayError(MethodBase.GetCurrentMethod().Name, ex);
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

        if (cboSerie.Text == "" && msTypeFiche == "FT")
        {
          MessageBox.Show(Resources.msg_must_select_serie, Program.AppTitle, MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
          return;
        }

        //  ' si on change le fichier, génération d'un numéro unique pour le nom physique
        string sNomFichier;
        if (msFichierOld != msFichier)
          sNomFichier = MozartParams.NomSociete + Strings.Format(DateTime.Now, "yyyyddmmhhmmss") + "." + Strings.Right(msFichier, 3);
        else
          sNomFichier = msFichierOld;

        using (SqlCommand cmd = new SqlCommand("api_sp_creationFicheTech", MozartDatabase.cnxMozart))
        {
          cmd.CommandType = CommandType.StoredProcedure;
          SqlCommandBuilder.DeriveParameters(cmd);

          cmd.Parameters["@iNumFicheTech"].Value = miIDFICTECH;
          cmd.Parameters["@vTitre"].Value = txtTitre.Text.Replace("'", "''");
          cmd.Parameters["@date"].Value = DateTime.Now;
          cmd.Parameters["@vtype"].Value = msTypeFiche;
          cmd.Parameters["@vformat"].Value = Strings.Right(msFichier, 3);
          cmd.Parameters["@vserie"].Value = cboSerie.Text;
          cmd.Parameters["@vFicTech"].Value = sNomFichier;
          cmd.ExecuteNonQuery();
          miIDFICTECH = Convert.ToInt32(cmd.Parameters[0].Value);
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

          CImpersonation.CopyFileImpersonated(sNewTempFile, msCheminFicheTech + sNomFichier);
          File.Delete(sNewTempFile);

          // suppression de l'ancien fichier si remplacement
          if (msFichierOld != "")
            if (CImpersonation.FileExistImpersonated(msCheminFicheTech + msFichierOld))
            {
              CImpersonation.DeleteFileImpersonated(msCheminFicheTech + msFichierOld);
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

      if (msTypeFiche == "FP" || msTypeFiche == "FT")
      {
        CommonDialog1.Title = Resources.msg_PDF_file_choice;
        CommonDialog1.Filter = "Fichiers PDF (*.PDF)|*.PDF";
        CommonDialog1.FilterIndex = 1;
      }
      else
      {
        CommonDialog1.Title = "Choix d'un fichier ";
        CommonDialog1.Filter = "Fichiers PDF OU EXCEL |*.PDF;*.XLS";
        CommonDialog1.FilterIndex = 1;
      }

      if (CommonDialog1.ShowDialog() == DialogResult.OK)
      {
        msFichier = CommonDialog1.FileName;
        // Afficher l'image
        WebBrowser1.Navigate(msFichier);
      }
    }

    private void OuvertureEnCreation()
    {
    }

    private void OuvertureEnModification()
    {
      try
      {
        msFichierOld = "";

        using (SqlDataReader dr = ModuleData.ExecuteReader("SELECT TITRE, VFICTECH, DDATEPUB, VCLASSEMENT FROM TFICHETECH WHERE ID = " + miIDFICTECH))
        {
          if (dr.Read())
          {
            txtTitre.Text = dr["TITRE"].ToString();
            txtDateNorme.Text = Utils.DateBlankIfNull(dr["DDATEPUB"]);
            if (msTypeFiche == "FT") cboSerie.Text = dr["VCLASSEMENT"].ToString();
            msFichierOld = dr["VFICTECH"].ToString();
            msFichier = msFichierOld;
          }

          // test si le fichier existe
          if (CImpersonation.FileExistImpersonated(msCheminFicheTech + dr["VFICTECH"].ToString()))
          {
            WebBrowser1.Navigate(CImpersonation.OpenFileImpersonated(msCheminFicheTech + dr["VFICTECH"].ToString()));
          }

          dr.Close();
        }
      }
      catch (Exception ex)
      {
        MZUtils.displayError(MethodBase.GetCurrentMethod().Name, ex);
      }
    }
  }
}

