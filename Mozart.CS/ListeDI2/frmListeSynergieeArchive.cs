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
  public partial class frmListeSynergieeArchive : Form
  {
    DataTable dtNew = new DataTable();

    public frmListeSynergieeArchive() { InitializeComponent(); }

    private void frmListeSynergieeArchive_Load(object sender, EventArgs e)
    {

      try
      {
        Cursor.Current = Cursors.WaitCursor;
        ModuleMain.Initboutons(this);

        //ouverture du recordset
        apiTGridNew.LoadData(dtNew, MozartDatabase.cnxMozart, $"exec api_sp_listeDISynergeeArchive");
        apiTGridNew.GridControl.DataSource = dtNew;
        InitApiTgridNew();

      }
      catch (Exception ex)
      {
        MZUtils.displayError(MethodBase.GetCurrentMethod().Name, ex);
      }
      finally { Cursor.Current = Cursors.Default; }
    }

    private void InitApiTgridNew()
    {

      apiTGridNew.AddColumn("DI Syn", "NSYNNUM", 800);
      apiTGridNew.AddColumn("DI Emalec", "NDINNUM", 1000);
      apiTGridNew.AddColumn("Date Synergee", "DSYNDAT", 1200, "Date");
      apiTGridNew.AddColumn("Client", "VSYNCLIENT", 1000);
      apiTGridNew.AddColumn("Site", "VSYNSITE", 1800);
      apiTGridNew.AddColumn("Équipement", "VSYNEQPT", 1200);
      apiTGridNew.AddColumn("Statut", "VLIBELLE", 3000);
      apiTGridNew.AddColumn("Description", "VSYNDESC", 5000);
      apiTGridNew.AddColumn("NACTNUM", "NACTNUM", 0);

      apiTGridNew.InitColumnList();
    }

    private void cmdQuitter_Click(object sender, EventArgs e)
    {
      Dispose();
    }

    private void cmdRestaurer_Click(object sender, EventArgs e)
    {
      DataRow row = apiTGridNew.GetFocusedDataRow();
      if (null == row) return;

      if (MessageBox.Show(Resources.msg_ConfirmRestaurerDemande, Program.AppTitle, MessageBoxButtons.YesNo) != DialogResult.Yes) return;

      ModuleData.ExecuteScalarInt($"Update TDISYNERGEE Set NSYNSTATUS = (NSYNSTATUS - 99) where NSYNNUM = {row["NSYNNUM"]} and NACTNUM = {row["NACTNUM"]}");

      Cursor.Current = Cursors.WaitCursor;
      apiTGridNew.Requery(dtNew, MozartDatabase.cnxMozart);
      Cursor.Current = Cursors.Default;

    }
  }
}
