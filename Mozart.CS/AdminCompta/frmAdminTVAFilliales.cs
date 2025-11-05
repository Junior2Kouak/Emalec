using DevExpress.XtraEditors.Controls;
using DevExpress.XtraGrid.Columns;
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
using MZCtrlResources = MozartControls.Properties.Resources;
using MZCtrlUtils = MozartControls.Utils;

namespace MozartCS
{
  public partial class frmAdminTVAFilliales : Form
  {
    private DataTable dt = new DataTable();

    private SqlDataAdapter daTVAIntra;

    public frmAdminTVAFilliales()
    {
      InitializeComponent();
    }

    private void frmAdminTVAFilliales_Load(object sender, EventArgs e)
    {
      ModuleMain.Initboutons(this);

      InitApiTGrid();
    }

    private void InitApiTGrid()
    {
      string lSql;

      lSql = $"SELECT VSOCIETE_NOM_USUEL, VPAYSNOM, VTVAINTRA, TPAYS.NPAYSNUM AS NPAYSNUM, TSOCIETE.NSOCIETEID AS NSOCIETEID";
      lSql += $" FROM TTVAFILIALE INNER JOIN TSOCIETE ON TSOCIETE.NSOCIETEID = TTVAFILIALE.NSOCIETEID";
      lSql += $" INNER JOIN TPAYS ON TPAYS.NPAYSNUM = TTVAFILIALE.NPAYSNUM";
      lSql += $" WHERE TSOCIETE.NSOCIETEID IN (9, 1, 15, 7, 19, 6, 3, 16, 14, 17, 18)";
      lSql += $" ORDER BY VSOCIETE_NOM_USUEL, VPAYSNOM";
      //apiTGrid.LoadData(dt, MozartDatabase.cnxMozart, lSql);
      daTVAIntra = new SqlDataAdapter(lSql, MozartDatabase.cnxMozart);
      daTVAIntra.Fill(dt);
      apiTGrid.GridControl.DataSource = dt;

      SqlCommand lUpdateCommand = new SqlCommand($"UPDATE TTVAFILIALE SET VTVAINTRA = @tvaintra WHERE NPAYSNUM = @npaysnum AND NSOCIETEID = @nsocieteid", MozartDatabase.cnxMozart);
      lUpdateCommand.Parameters.Add("@npaysnum", SqlDbType.Int, 0, "NPAYSNUM");
      lUpdateCommand.Parameters.Add("@nsocieteid", SqlDbType.Int, 0, "NSOCIETEID");
      lUpdateCommand.Parameters.Add("@tvaintra", SqlDbType.VarChar, 50, "VTVAINTRA");
      daTVAIntra.UpdateCommand = lUpdateCommand;

      apiTGrid.AddColumn(Resources.col_Societe, "VSOCIETE_NOM_USUEL", 2000);
      apiTGrid.AddColumn(Resources.col_Pays, "VPAYSNOM", 2000);
      apiTGrid.AddColumn("TVA Intra", "VTVAINTRA", 2000);
      apiTGrid.AddColumn("NPAYSNUM", "NPAYSNUM", 0);
      apiTGrid.AddColumn("NSOCIETEID", "NSOCIETEID", 0);

      apiTGrid.InitColumnList();

      apiTGrid.DelockColumn("VTVAINTRA");

      apiTGrid.dgv.ValidateRow += new ValidateRowEventHandler(this.apiTGrid_ValidateRow);
      apiTGrid.dgv.InvalidRowException += new InvalidRowExceptionEventHandler(this.apiTGrid_InvalidRowException);
      apiTGrid.dgv.RowUpdated += new RowObjectEventHandler(this.apiTGrid_RowUpdated);
    }

    private void apiTGrid_RowUpdated(object sender, RowObjectEventArgs e)
    {
      daTVAIntra.Update(dt);
    }

    private void apiTGrid_InvalidRowException(object sender, InvalidRowExceptionEventArgs e)
    {
      //Suppress displaying the error message box
      e.ExceptionMode = ExceptionMode.NoAction;

      MessageBox.Show(e.ErrorText, Assembly.GetExecutingAssembly().GetCustomAttribute<AssemblyTitleAttribute>().Title,
                      MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
    }

    private void apiTGrid_ValidateRow(object sender, ValidateRowEventArgs e)
    {
      // TODOFGB : Voir comment doit être traité la ligne
      GridView view = sender as GridView;
      GridColumn lColTVAIntra = view.Columns["VTVAINTRA"];
      GridColumn lColPays = view.Columns["VPAYSNOM"];

      string lTvaIntra = view.GetRowCellValue(e.RowHandle, lColTVAIntra).ToString().Trim();
      string lPays = view.GetRowCellValue(e.RowHandle, lColPays).ToString();

      if (lTvaIntra == "")
      {
        e.Valid = false;
        //e.ErrorText = Resources.msg_format_tva_incorrect;
        e.ErrorText = MZCtrlResources.msg_enter_TVA;
        return;
      }

      if (!MZCtrlUtils.VerifTVAIntra(lTvaIntra, lPays))
      {
        e.Valid = false;
        e.ErrorText = MZCtrlResources.msg_Code_TVA_intra_invalide;
        return;
      }

    }
  }
}
