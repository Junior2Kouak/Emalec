using MozartCS.Properties;
using MozartLib;
using MozartNet;
using System;
using System.Data;
using System.Reflection;
using System.Windows.Forms;
using MZUtils = MozartControls.Utils;

namespace MozartCS
{
  public partial class frmSousTenCours : Form
  {
    DataTable dt = new DataTable();

    string CheminDocAdminSTFATraiter = "";

    public frmSousTenCours() { InitializeComponent(); }

    private void frmSousTenCours_Load(object sender, System.EventArgs e)
    {
      try
      {
        Cursor.Current = Cursors.WaitCursor;
        ModuleMain.Initboutons(this);

        CheminDocAdminSTFATraiter = ModuleData.RechercheParam("REP_DOC_STF_ATRAITER", MozartParams.NomSociete);

        //ouverture du recordset
        apiTGrid1.LoadData(dt, MozartDatabase.cnxMozart, "exec api_sp_ListeDocSTTavalider");
        apiTGrid1.GridControl.DataSource = dt;

        InitApigrid();
      }
      catch (Exception ex)
      {
        MZUtils.displayError(MethodBase.GetCurrentMethod().Name, ex);
      }
      finally { Cursor.Current = Cursors.Default; }
    }

    private void InitApigrid()
    {
      apiTGrid1.AddColumn(Resources.col_NomSTT, "VSTFGRPNOM", 5500);
      apiTGrid1.AddColumn("Date transfert", "DDOCSTFCRE", 2000, "", 2);
      apiTGrid1.AddColumn(Resources.col_Fichier, "VDOCSTFNOM", 2000, "", 2);
      apiTGrid1.AddColumn(Resources.col_Rmq, "VDOCSTFCOM", 3000);

      apiTGrid1.InitColumnList();
    }

    private void Command1_Click(object sender, EventArgs e)
    {
      DataRow row = apiTGrid1.GetFocusedDataRow();
      if (row == null) return;

      //enregistrement du document dans la bonne table
      new frmDocSTT()
      {
        iDocAdminSTFNum = (int)Utils.ZeroIfNull(row["NDOCSTFNUM"]),
        iSTFGRPNUM = (int)Utils.ZeroIfNull(row["NSTFGRPNUM"]),
        strNom = Utils.BlankIfNull(row["VSTFGRPNOM"]),
        CheminDocAdminSTFATraiter = CheminDocAdminSTFATraiter,
      }.ShowDialog();

      apiTGrid1.Requery(dt, MozartDatabase.cnxMozart);
    }

    private void Command2_Click(object sender, EventArgs e)
    {
      try
      {
        DataRow row = apiTGrid1.GetFocusedDataRow();
        if (row == null) return;

        new frmBrowserSimple()
        {
          StartingAddress = CImpersonation.OpenFileImpersonated(CheminDocAdminSTFATraiter + row["VDOCSTFNOM"].ToString())
        }.ShowDialog();
      }
      catch (Exception ex)
      {
        MZUtils.displayError(MethodBase.GetCurrentMethod().Name, ex);
      }
    }

    private void cmdSupprimer_Click(object sender, EventArgs e)
    {
      try
      {
        DataRow row = apiTGrid1.GetFocusedDataRow();
        if (row == null) return;

        if (MessageBox.Show(Resources.msg_confirm_del_ligne, Program.AppTitle, MessageBoxButtons.YesNo, MessageBoxIcon.Question,
                      MessageBoxDefaultButton.Button2) != DialogResult.Yes)
          return;

        // suppression de la ligne dans la base
        ModuleData.CnxExecute($"DELETE FROM TW2DOCSTF WHERE NDOCSTFNUM = {Convert.ToInt32(row["NDOCSTFNUM"])}");

        // suppression du fichier 
        CImpersonation.DeleteFileImpersonated(CheminDocAdminSTFATraiter + row["VDOCSTFNOM"].ToString());

        apiTGrid1.Requery(dt, MozartDatabase.cnxMozart);
      }
      catch (Exception ex)
      {
        MZUtils.displayError(MethodBase.GetCurrentMethod().Name, ex);
      }
    }
  }
}

