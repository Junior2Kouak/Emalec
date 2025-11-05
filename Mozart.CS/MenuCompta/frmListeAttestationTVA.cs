using MZCtrlResources = MozartControls.Properties.Resources;
using DevExpress.XtraGrid.Views.Grid;
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
  public partial class frmListeAttestationTVA : Form
  {
    private DataTable dt = new DataTable();
    private string RepertoireDoc;

    public frmListeAttestationTVA() { InitializeComponent(); }

    private void frmListeAttestationTVA_Load(object sender, System.EventArgs e)
    {
      try
      {
        Cursor.Current = Cursors.WaitCursor;
        ModuleMain.Initboutons(this);

        apiTGrid1.LoadData(dt, MozartDatabase.cnxMozart, "exec api_sp_ListeAttestationTVAreduit");
        apiTGrid1.GridControl.DataSource = dt;

        RepertoireDoc = Utils.RechercheParam("REP_PHOTOS_ACT");

        InitGrid();
      }
      catch (Exception ex)
      {
        MZUtils.displayError(MethodBase.GetCurrentMethod().Name, ex);
      }
      finally { Cursor.Current = Cursors.Default; }
    }

    private void InitGrid()
    {
      apiTGrid1.AddColumn(MZCtrlResources.col_Client, "VCLINOM", 5800);
      apiTGrid1.AddColumn(Resources.col_NumFacture, "FACTURE", 1500);
      apiTGrid1.AddColumn(Resources.col_Montant, "TOTALHT", 1300, "##.##", 1);
      apiTGrid1.AddColumn(Resources.col_Date, "DFACDAT", 1300, "dd/MM/yy", 2);
      apiTGrid1.AddColumn(Resources.col_traite, "CODE", 1200, "", 2);

      apiTGrid1.InitColumnList();
    }

    //Style sur une colonne
    private void apiTGrid1_RowCellStyle(object sender, RowCellStyleEventArgs e)
    {
      if (e.RowHandle >= 0)
      {
        GridView view = sender as GridView;
        if (e.Column.Name == "CODE")
        {
          if ((string)view.GetDataRow(e.RowHandle)["CODE"] == "NON")
            e.Appearance.BackColor = MozartColors.ColorH8080FF;
        }
      }
    }

    private void cmdFacture_Click(object sender, EventArgs e)
    {
      DataRow row = apiTGrid1.GetFocusedDataRow();
      if (row == null) return;

      new frmModFacture((int)Utils.ZeroIfNull(row["NFACNUM"])).ShowDialog();
    }

    private void cmdVisu_Click(object sender, EventArgs e)
    {
      DataRow row = apiTGrid1.GetFocusedDataRow();
      if (row == null) return;

      if ((string)row["CODE"] == "NON") return;

      new frmBrowser
      {
        msStartingAddress = RepertoireDoc + Utils.BlankIfNull(row["VFICHIER"]),
      }.ShowDialog();
    }
  }
}

