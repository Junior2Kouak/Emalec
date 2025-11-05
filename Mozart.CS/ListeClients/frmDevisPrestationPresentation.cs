using DevExpress.XtraGrid;
using DevExpress.XtraGrid.Views.Base;
using DevExpress.XtraGrid.Views.Grid;
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
  public partial class frmDevisPrestationPresentation : Form
  {
    private int miNumDevisCL;

    private SqlDataAdapter daCat = new SqlDataAdapter();
    private readonly SqlCommandBuilder cbCat = new SqlCommandBuilder();
    DataTable dtCat = new DataTable();

    private SqlDataAdapter daSSCat = new SqlDataAdapter();
    private readonly SqlCommandBuilder cbSSCat = new SqlCommandBuilder();
    DataTable dtSSCat = new DataTable();

    DataTable dtPrestation = new DataTable();

    public frmDevisPrestationPresentation(int piNumDevisCL)
    {
      InitializeComponent();

      miNumDevisCL = piNumDevisCL;
    }

    private void frmDevisPrestationPresentation_Load(object sender, EventArgs e)
    {
      try
      {
        ModuleMain.Initboutons(this);

        CmdVisu.Visible = false;

        InitRs();
        InitGrid();
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
        MajDatabase();
      }
      catch (Exception ex)
      {
        MZUtils.displayError(MethodBase.GetCurrentMethod().Name, ex);
      }
      Dispose();
    }

    private void MajDatabase()
    {
      ColumnView viewCat = apiGridCat.GridControl.FocusedView as ColumnView;
      viewCat.CloseEditor();
      if (viewCat.UpdateCurrentRow())
        daCat.Update(dtCat);

      ColumnView viewSSCat = apiGridSSCat.GridControl.FocusedView as ColumnView;
      viewSSCat.CloseEditor();
      if (viewSSCat.UpdateCurrentRow())
        daSSCat.Update(dtSSCat);
    }

    private void cmdFermer_Click(object sender, EventArgs e)
    {
      try
      {
        MajDatabase();
      }
      catch (Exception ex)
      {
        MZUtils.displayError(MethodBase.GetCurrentMethod().Name, ex);
      }
      Dispose();
    }

    private void InitRs()
    {
      try
      {
        string sSql = $"SELECT TLDCLPREST.NLDCLPRESTID, TLDCLPREST.VPRESTLIB, NCATID, NSSCATID,NSS2CATID, TPREST.NPRESTID, TLDCLPREST.NQTE, CASE WHEN ISNULL(TLDCLPREST.BLDCLPREST_NUIT, 0) = 0 THEN 'N' ELSE 'O' END AS BPRESTNUIT " +
                      $"FROM TPREST INNER JOIN TLDCLPREST ON TPREST.NPRESTID = TLDCLPREST.NPRESTID WHERE TLDCLPREST.NDCLNUM = {miNumDevisCL} ORDER BY NCATID, NSSCATID, NSS2CATID";
        apiGridPrestation.LoadData(dtPrestation, MozartDatabase.cnxMozart, sSql);
        apiGridPrestation.GridControl.DataSource = dtPrestation;

        sSql = $"SELECT NCATID, VCATLIB, NDCLNUM FROM TLDCLPRESTCAT WHERE NDCLNUM = {miNumDevisCL} ORDER BY NCATID";
        daCat = new SqlDataAdapter(sSql, MozartDatabase.cnxMozart);
        daCat.Fill(dtCat);
        apiGridCat.GridControl.DataSource = dtCat;
        cbCat.DataAdapter = daCat;

        sSql = $"SELECT NCATID, NSSCATID, VSSCATLIB, NDCLNUM FROM TLDCLPRESTSCAT WHERE NDCLNUM = {miNumDevisCL} ORDER BY NCATID, NSSCATID";
        daSSCat = new SqlDataAdapter(sSql, MozartDatabase.cnxMozart);
        daSSCat.Fill(dtSSCat);
        apiGridSSCat.GridControl.DataSource = dtSSCat;
        cbSSCat.DataAdapter = daSSCat;
      }
      catch (Exception ex)
      {
        MZUtils.displayError(MethodBase.GetCurrentMethod().Name, ex);
      }
    }

    private void InitGrid()
    {
      // Prestations
      apiGridPrestation.AddColumn(Resources.col_Chapitre, "NCATID", 700, "", 2);
      apiGridPrestation.AddColumn("Index 1", "NSSCATID", 700, "", 2);
      apiGridPrestation.AddColumn("Index 2", "NSS2CATID", 700, "", 2);
      apiGridPrestation.AddColumn(Resources.col_Prestation, "VPRESTLIB", 7000);
      apiGridPrestation.AddColumn(Resources.col_J_N, "BPRESTNUIT", 500, "", 2);
      apiGridPrestation.AddColumn(Resources.col_Qte, "NQTE", 500, "#", 2);
      apiGridPrestation.AddColumn("NPRESTID", "NPRESTID", 0);
      apiGridPrestation.AddColumn("NLDCLPRESTID", "NLDCLPRESTID", 0);

      apiGridPrestation.DelockColumn("NCATID");
      apiGridPrestation.DelockColumn("NSSCATID");
      apiGridPrestation.DelockColumn("NSS2CATID");

      apiGridPrestation.InitColumnList();

      //Chapitre
      apiGridCat.AddColumn("NDCLNUM", "NDCLNUM", 0);
      apiGridCat.AddColumn(Resources.col_Chapitre, "NCATID", 1500, "", 2);
      apiGridCat.AddColumn(Resources.col_Lbl, "VCATLIB", 4000);

      apiGridCat.DelockColumn("NCATID");
      apiGridCat.DelockColumn("VCATLIB");

      apiGridCat.dgv.OptionsView.NewItemRowPosition = NewItemRowPosition.Bottom;
      apiGridCat.dgv.OptionsBehavior.AllowAddRows = DevExpress.Utils.DefaultBoolean.True;
      apiGridCat.dgv.OptionsBehavior.AllowDeleteRows = DevExpress.Utils.DefaultBoolean.True;

      apiGridCat.InitColumnList();

      apiGridCat.GridControl.ProcessGridKey += new KeyEventHandler(GrillesCat_ProcessGridKey);

      //Sous-Chapitre
      apiGridSSCat.AddColumn("NDCLNUM", "NDCLNUM", 0);
      apiGridSSCat.AddColumn(Resources.col_Chapitre, "NCATID", 1200, "", 2);
      apiGridSSCat.AddColumn("Sous Chap", "NSSCATID", 1300, "", 2);
      apiGridSSCat.AddColumn(Resources.col_Lbl, "VSSCATLIB", 4000);

      apiGridSSCat.DelockColumn("NCATID");
      apiGridSSCat.DelockColumn("NSSCATID");
      apiGridSSCat.DelockColumn("VSSCATLIB");

      apiGridSSCat.dgv.OptionsView.NewItemRowPosition = NewItemRowPosition.Bottom;
      apiGridSSCat.dgv.OptionsBehavior.AllowAddRows = DevExpress.Utils.DefaultBoolean.True;
      apiGridSSCat.dgv.OptionsBehavior.AllowDeleteRows = DevExpress.Utils.DefaultBoolean.True;

      apiGridSSCat.InitColumnList();

      apiGridSSCat.GridControl.ProcessGridKey += new KeyEventHandler(GrillesCat_ProcessGridKey);
    }

    private void CmdVisu_Click(object sender, EventArgs e)
    {
    }

    private void apiGridCat_InitNewRowE(object sender, InitNewRowEventArgs e)
    {
      DataRow rowAv = apiGridCat.GetFocusedDataRow();
      (sender as GridView).SetRowCellValue(e.RowHandle, "NDCLNUM", miNumDevisCL);
    }

    private void apiGridSSCat_InitNewRowE(object sender, InitNewRowEventArgs e)
    {
      DataRow rowAv = apiGridCat.GetFocusedDataRow();
      (sender as GridView).SetRowCellValue(e.RowHandle, "NDCLNUM", miNumDevisCL);
    }

    private void apiGridPrestation_ValidateRowE(object sender, ValidateRowEventArgs e)
    {
      DataRow row = apiGridPrestation.GetFocusedDataRow();
      ModuleData.ExecuteNonQuery($"UPDATE TLDCLPREST Set NCATID = {row["NCATID"]}, NSSCATID = {row["NSSCATID"]}, NSS2CATID = {row["NSS2CATID"]} Where NDCLNUM = {miNumDevisCL} AND NLDCLPRESTID = {row["NLDCLPRESTID"]}");
    }

    private void apiGridPrestation_PreviewKeyDownE(object sender, PreviewKeyDownEventArgs e)
    {
      GridView currentView = (sender as GridControl).FocusedView as GridView;
      if (e.KeyCode == Keys.Enter)
        currentView.UpdateCurrentRow();
    }

    private void GrillesCat_ProcessGridKey(object sender, KeyEventArgs e)
    {
      if (e.KeyCode == Keys.Delete)
      {
        GridView currentView = (sender as GridControl).FocusedView as GridView;
        if (GridControl.InvalidRowHandle != currentView.FocusedRowHandle)
          currentView.DeleteRow(currentView.FocusedRowHandle);
      }
    }

    private void apiGridCat_ValidateRowE(object sender, ValidateRowEventArgs e)
    {
      try
      {
        DataRow row = (e.Row as DataRowView).Row;
        for (int i = 0; i < dtCat.Rows.Count; i++)
        {
          DataRow rcat = dtCat.Rows[i];
          int hr = apiGridCat.dgv.GetRowHandle(i);
          if (e.RowHandle != hr && (int)rcat["NCATID"] == (int)row["NCATID"])
          {
            MessageBox.Show($"La valeur {row["NCATID"]} existe déjà", Program.AppTitle, MessageBoxButtons.OK, MessageBoxIcon.Information);
            ColumnView view = (sender as GridControl).FocusedView as ColumnView;
            view.FocusedColumn = view.Columns["NCATID"];
            e.Valid = false;
          }
        }
      }
      catch (Exception ex)
      {
        MZUtils.displayError(MethodBase.GetCurrentMethod().Name, ex);
      }
    }

    private void apiGridSSCat_ValidateRowE(object sender, ValidateRowEventArgs e)
    {
      try
      {
        DataRow row = (e.Row as DataRowView).Row;
        for (int i = 0; i < dtSSCat.Rows.Count; i++)
        {
          DataRow rsscat = dtSSCat.Rows[i];
          int hr = apiGridSSCat.dgv.GetRowHandle(i);
          if (e.RowHandle != hr && (int)rsscat["NCATID"] == (int)row["NCATID"] && (int)rsscat["NSSCATID"] == (int)row["NSSCATID"])
          {
            MessageBox.Show($"La valeur {row["NSSCATID"]} existe déjà", Program.AppTitle, MessageBoxButtons.OK, MessageBoxIcon.Information);
            ColumnView view = (sender as GridControl).FocusedView as ColumnView;
            view.FocusedColumn = view.Columns["NSSCATID"];
            e.Valid = false;
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
