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
  public partial class frmOutillageDocDetail : Form
  {
    public long NOUT_DOC_ID = 0;
    public long NID_OUT = 0;
    public string VTYPE_OUT = "";
    string msPathDocOutillage;
    string msFichierOld;
    string msFichier;


    public frmOutillageDocDetail()
    {
      InitializeComponent();
    }

    private void frmOutillageDocDetail_Load(object sender, System.EventArgs e)
    {
      try
      {
        ModuleMain.Initboutons(this);
        msPathDocOutillage = ModuleData.RechercheParam("REP_OUTILLAGE_DOC", MozartParams.NomSociete);

        OuvertureEnModification();
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

        using (SqlCommand cmd = new SqlCommand("[api_sp_OutillageDoc_Save]", MozartDatabase.cnxMozart))
        {
          cmd.CommandType = CommandType.StoredProcedure;
          SqlCommandBuilder.DeriveParameters(cmd);

          cmd.Parameters["@P_NOUT_DOC_ID"].Value = NOUT_DOC_ID;
          cmd.Parameters["@P_NID_OUT"].Value = NID_OUT;
          cmd.Parameters["@P_VTYPE_OUT"].Value = VTYPE_OUT;
          cmd.Parameters["@P_VOUT_DOC_NOM"].Value = txtTitre.Text.Replace("'", "''");

          cmd.ExecuteNonQuery();
          NOUT_DOC_ID = Convert.ToInt32(cmd.Parameters["@P_NOUT_DOC_ID"].Value);
        }

        if (msFichierOld != msFichier)
        {
          File.Copy(msFichier, msPathDocOutillage + NOUT_DOC_ID + "_OutillageDoc.pdf", overwrite: true);
          ModuleData.ExecuteNonQuery($"UPDATE TOUT_DOC SET NQUICREE = dbo.GetUserId(), DDATMODIF = GetDate(), VFILENAME = '{NOUT_DOC_ID }_OutillageDoc.pdf' WHERE NOUT_DOC_ID = {NOUT_DOC_ID}");
        }
        Close();
      }
      catch (Exception ex)
      {
        Cursor.Current = Cursors.Default;
        MZUtils.displayError(MethodBase.GetCurrentMethod().Name, ex);
      }
    }

    private void cmdFichier_Click(object sender, EventArgs e)
    {
      try
      {
        //  Attribue à CancelError la valeur True
        CommonDialog1.ReadOnlyChecked = true;
        CommonDialog1.Title = Resources.msg_PDF_file_choice;
        CommonDialog1.Filter = "Fichiers PDF (*.PDF)|*.PDF";
        CommonDialog1.FilterIndex = 1;

        //  Affiche la boîte de dialogue Ouverture
        if (CommonDialog1.ShowDialog() == DialogResult.OK)
        {
          msFichier = CommonDialog1.FileName;
          // Afficher l'image
          WebBrowser1.Navigate(msFichier);
        }
      }
      catch (Exception ex)
      {
        Cursor.Current = Cursors.Default;
        MZUtils.displayError(MethodBase.GetCurrentMethod().Name, ex);
      }
    }

    private void OuvertureEnModification()
    {
      try
      {
        using (SqlDataReader dr = ModuleData.ExecuteReader($"EXEC[api_sp_OutillageDoc_Detail] {NOUT_DOC_ID}"))
        {
          if (dr.Read())
          {
            NID_OUT = Convert.ToInt64(dr["NID_OUT"]);
            VTYPE_OUT = dr["VTYPE_OUT"].ToString();
            txtTitre.Text = dr["VOUT_DOC_NOM"].ToString();
            LblCreateur.Text = dr["VNOMCREATEUR"].ToString();
            LblDateDoc.Text = dr["DDATMODIF"].ToString();

            if (Utils.BlankIfNull(dr["VFILENAME"]) != "")
              WebBrowser1.Navigate(msPathDocOutillage + dr["VFILENAME"].ToString());

            msFichierOld = dr["VFILENAME"].ToString(); ;
            msFichier = msFichierOld;
          }
        }

        cmdValider.Visible = cmdFichier.Visible = true;
      }
      catch (Exception ex)
      {
        Cursor.Current = Cursors.Default;
        MZUtils.displayError(MethodBase.GetCurrentMethod().Name, ex);
      }
    }

    private void frmOutillageDocDetail_FormClosed(object sender, FormClosedEventArgs e)
    {
      NOUT_DOC_ID = 0;
      msFichier = "";
    }
  }
}