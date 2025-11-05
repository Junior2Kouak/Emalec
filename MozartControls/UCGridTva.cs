using DevExpress.XtraEditors;
using DevExpress.XtraEditors.Controls;
using DevExpress.XtraEditors.Repository;
using DevExpress.XtraGrid;
using DevExpress.XtraGrid.Columns;
using DevExpress.XtraGrid.Views.Base;
using DevExpress.XtraGrid.Views.Grid;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Reflection;
using System.Windows.Forms;
using MZCtrlResources = MozartControls.Properties.Resources;
using MZUtils = MozartControls.Utils;

namespace MozartControls
{
  public partial class UCGridTva : UserControl
  {
    private SqlConnection mCnx;

    private DataTable dtRsfTVAIntra = new DataTable();
    private SqlDataAdapter daRsfTVAIntra;

    private DataTable dtPays = new DataTable();

    private int miNumRsf;

    public event RowStyleEventHandler RowStyle;

    public UCGridTva()
    {
      InitializeComponent();

      miNumRsf = 0;

      apiTGridTva.CacherCompteur();
      apiTGridTva.CacherBoutonsPrintExcel();
    }

    // Nécessaire pour l'initialisation
    public void initComponent(SqlConnection pCnx)
    {
      mCnx = pCnx;

      string lTmp;

      // Garde en mémoire la liste des pays
      lTmp = $"SELECT 0 AS NPAYSNUM, '' AS VRSFTVAINTRAPAYS, '' AS VUETIERSUE FROM TPAYS";
      lTmp += $" UNION SELECT NPAYSNUM, VPAYSNOM AS VRSFTVAINTRAPAYS, CASE NPAYSUE WHEN 'E' THEN 'UE' ELSE 'Tiers UE' END AS VUETIERSUE FROM TPAYS ORDER BY VRSFTVAINTRAPAYS";
      lTmp = $"SELECT NPAYSNUM, VPAYSNOM AS VRSFTVAINTRAPAYS, CASE NPAYSUE WHEN 'E' THEN 'UE' ELSE 'Tiers UE' END AS VUETIERSUE FROM TPAYS ORDER BY VRSFTVAINTRAPAYS";
      SqlCommand lTmpSqlCmd = new SqlCommand(lTmp, mCnx);
      dtPays.Load(lTmpSqlCmd.ExecuteReader());

      InitApiTGridTva();
    }

    // Charge la grille avec les données de la raison sociale passée en paramètre
    public void loadTVAIntra(int pRSFNUM)
    {
      try
      {
        miNumRsf = pRSFNUM;

        cmdAddTVA.Enabled = cmdSupprTVA.Enabled = (miNumRsf != 0);

        apiTGridTva.GridControl.DataSource = null;
        dtRsfTVAIntra.Rows.Clear();

        daRsfTVAIntra = new SqlDataAdapter($"exec api_sp_ListeTVAIntra {miNumRsf}", mCnx);
        daRsfTVAIntra.Fill(dtRsfTVAIntra);

        apiTGridTva.GridControl.DataSource = dtRsfTVAIntra;

        SqlCommand lDeleteCommand = new SqlCommand($"DELETE TRSFTVAINTRA WHERE NRSFNUM = @nrsfnum AND VRSFTVAINTRAPAYS = @pays", mCnx);
        lDeleteCommand.Parameters.Add("@nrsfnum", SqlDbType.Int, 0, "NRSFNUM");
        lDeleteCommand.Parameters.Add("@pays", SqlDbType.VarChar, 50, "VRSFTVAINTRAPAYS");
        daRsfTVAIntra.DeleteCommand = lDeleteCommand;

        SqlCommand lInsertCommand = new SqlCommand($"INSERT INTO TRSFTVAINTRA(NRSFNUM, VRSFTVAINTRAPAYS, VRSFTVAINTRANUM) VALUES (@nrsfnum, @pays, @tvaintra)", mCnx);
        lInsertCommand.Parameters.Add("@nrsfnum", SqlDbType.Int, 0, "NRSFNUM");
        lInsertCommand.Parameters.Add("@pays", SqlDbType.VarChar, 50, "VRSFTVAINTRAPAYS");
        lInsertCommand.Parameters.Add("@tvaintra", SqlDbType.VarChar, 50, "VRSFTVAINTRANUM");
        daRsfTVAIntra.InsertCommand = lInsertCommand;

        SqlCommand lUpdateCommand = new SqlCommand($"UPDATE TRSFTVAINTRA SET VRSFTVAINTRANUM = @tvaintra WHERE NRSFNUM = @nrsfnum AND VRSFTVAINTRAPAYS = @pays", mCnx);
        lUpdateCommand.Parameters.Add("@nrsfnum", SqlDbType.Int, 0, "NRSFNUM");
        lUpdateCommand.Parameters.Add("@pays", SqlDbType.VarChar, 50, "VRSFTVAINTRAPAYS");
        lUpdateCommand.Parameters.Add("@tvaintra", SqlDbType.VarChar, 50, "VRSFTVAINTRANUM");
        daRsfTVAIntra.UpdateCommand = lUpdateCommand;
      }
      catch (Exception ex)
      {
        MZUtils.displayError(MethodBase.GetCurrentMethod().Name, ex);
      }
    }

    // Renvoit le nb de TVA dans le tableau
    public int Count()
    {

      return dtRsfTVAIntra.Rows.Count;
    }

    private void InitApiTGridTva()
    {
      apiTGridTva.AddColumn(MZCtrlResources.col_Pays, "VRSFTVAINTRAPAYS", 1200);
      apiTGridTva.AddColumn(MZCtrlResources.col_UETiersUE, "VUETIERSUE", 1200);
      apiTGridTva.AddColumn(MZCtrlResources.col_TVAIntra, "VRSFTVAINTRANUM", 1200);
      apiTGridTva.AddColumn("NPAYSNUM", "NPAYSNUM", 0);
      apiTGridTva.AddColumn("NRSFNUM", "NRSFNUM", 0);

      RepositoryItemLookUpEdit lRICb = new RepositoryItemLookUpEdit();
      var listeTvaDansGrid = dtRsfTVAIntra.AsEnumerable().ToDictionary(p => p["VRSFTVAINTRAPAYS"]);
      IEnumerable<DataRow> query = from imp in dtPays.AsEnumerable()
                                   select imp;
      lRICb.DataSource = query.CopyToDataTable<DataRow>();
      lRICb.DisplayMember = "VRSFTVAINTRAPAYS";
      lRICb.ValueMember = "VRSFTVAINTRAPAYS";
      apiTGridTva.GridControl.RepositoryItems.Add(lRICb);
      apiTGridTva.dgv.Columns["VRSFTVAINTRAPAYS"].ColumnEdit = lRICb;

      apiTGridTva.InitColumnList();

      apiTGridTva.DelockColumn("VRSFTVAINTRAPAYS");
      apiTGridTva.DelockColumn("VRSFTVAINTRANUM");

      apiTGridTva.dgv.ShownEditor += new EventHandler(this.apiTGridTva_ShownEditor);
      apiTGridTva.dgv.ValidateRow += new ValidateRowEventHandler(this.apiTGridTva_ValidateRow);
      apiTGridTva.dgv.InvalidRowException += new InvalidRowExceptionEventHandler(this.apiTGridTva_InvalidRowException);
      apiTGridTva.dgv.RowUpdated += new RowObjectEventHandler(this.apiTGridTva_RowUpdated);
      apiTGridTva.dgv.ShowingEditor += new CancelEventHandler(this.apiTGridTva_ShowingEditor);
    }

    private void cmdAddTVA_Click(object sender, EventArgs e)
    {
      apiTGridTva.dgv.AddNewRow();
    }

    private void cmdSupprTVA_Click(object sender, EventArgs e)
    {
      DataRow lCurrentRow = apiTGridTva.GetFocusedDataRow();
      if (lCurrentRow == null) return;

      apiTGridTva.dgv.DeleteRow(apiTGridTva.dgv.FocusedRowHandle);
      daRsfTVAIntra.Update(dtRsfTVAIntra);
    }

    private void apiTGridTva_RowUpdated(object sender, RowObjectEventArgs e)
    {
      daRsfTVAIntra.Update(dtRsfTVAIntra);
    }

    private void apiTGridTva_InvalidRowException(object sender, InvalidRowExceptionEventArgs e)
    {
      //Suppress displaying the error message box
      e.ExceptionMode = ExceptionMode.NoAction;

      MessageBox.Show(e.ErrorText, Assembly.GetExecutingAssembly().GetCustomAttribute<AssemblyTitleAttribute>().Title,
                      MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
    }

    private void apiTGridTva_ShowingEditor(object sender, CancelEventArgs e)
    {
      GridView view = sender as GridView;

      if ((view.FocusedColumn.FieldName == "VRSFTVAINTRAPAYS") && (view.FocusedRowHandle != GridControl.NewItemRowHandle))
      {
        e.Cancel = true;
      }
    }

    private void apiTGridTva_ShownEditor(object sender, EventArgs e)
    {
      GridView view = sender as GridView;
      if (view.FocusedColumn.FieldName == "VRSFTVAINTRAPAYS")
      {
        DataRow lCurrentRow = apiTGridTva.GetFocusedDataRow();

        LookUpEdit edit = (LookUpEdit)view.ActiveEditor;
        edit.EditValueChanged += new EventHandler(cbo_EditValueChanged);
        edit.Properties.ShowHeader = false;

        var listeTvaDansGrid = dtRsfTVAIntra.AsEnumerable().ToDictionary(p => p["VRSFTVAINTRAPAYS"]);

        IEnumerable<DataRow> query = from imp in dtPays.DefaultView.ToTable(false, "VRSFTVAINTRAPAYS").AsEnumerable()
                                     where !listeTvaDansGrid.ContainsKey(imp["VRSFTVAINTRAPAYS"]) || (imp["VRSFTVAINTRAPAYS"].Equals(lCurrentRow["VRSFTVAINTRAPAYS"]))
                                     select imp;
        edit.Properties.DataSource = query.CopyToDataTable<DataRow>();
      }
    }

    private void cbo_EditValueChanged(object sender, EventArgs e)
    {
      DataRow lCurrentRow = apiTGridTva.GetFocusedDataRow();

      String lPays = (sender as TextEdit).EditValue.ToString();

      IEnumerable<string> query = from imp in dtPays.AsEnumerable()
                                  where lPays == imp["VRSFTVAINTRAPAYS"].ToString()
                                  select imp.Field<string>("VUETIERSUE");
      apiTGridTva.dgv.SetRowCellValue(apiTGridTva.dgv.FocusedRowHandle, apiTGridTva.dgv.Columns["VUETIERSUE"], query.First());
    }

    private void apiTGridTva_InitNewRowE(object sender, InitNewRowEventArgs e)
    {
      GridView lDgv = sender as GridView;

      lDgv.SetRowCellValue(e.RowHandle, lDgv.Columns["VRSFTVAINTRAPAYS"], "");
      lDgv.SetRowCellValue(e.RowHandle, lDgv.Columns["NRSFNUM"], miNumRsf);
    }

    private void apiTGridTva_ValidateRow(object sender, ValidateRowEventArgs e)
    {
      GridView view = sender as GridView;
      GridColumn lColTVAIntra = view.Columns["VRSFTVAINTRANUM"];
      GridColumn lColPays = view.Columns["VRSFTVAINTRAPAYS"];

      String lPays = view.GetRowCellValue(e.RowHandle, lColPays).ToString();
      if (lPays.Trim() == "")
      {
        e.Valid = false;
        e.ErrorText = MZCtrlResources.msg_Select_Pays;
        return;
      }

      String lTvaIntra = view.GetRowCellValue(e.RowHandle, lColTVAIntra).ToString();
      if (lTvaIntra.Trim() == "")
      {
        e.Valid = false;
        e.ErrorText = MZCtrlResources.msg_enter_TVA;
        return;
      }
      if (!Utils.VerifTVAIntra(lTvaIntra, lPays))
      {
        e.Valid = false;
        e.ErrorText = MZCtrlResources.msg_Code_TVA_intra_invalide;
        return;
      }
    }

    private void UCGridTva_Resize(object sender, EventArgs e)
    {
      if (this.Parent == null)
      {
        return;
      }

      cmdAddTVA.Left = cmdSupprTVA.Left = this.Parent.Width - cmdAddTVA.Width - 12;

      apiTGridTva.Width = cmdAddTVA.Left - 6;
      apiTGridTva.Height = this.Parent.Height - apiTGridTva.Top - 50;
    }

    private void apiTGridTva_RowStyle(object sender, RowStyleEventArgs e)
    {
      RowStyle?.Invoke(sender, e);
    }
  }
}
