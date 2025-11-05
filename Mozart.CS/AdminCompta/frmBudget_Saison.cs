using DevExpress.XtraGrid.Views.Grid;
using DevExpress.XtraPivotGrid;
using MozartLib;
using MozartNet;
using MozartUC;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Globalization;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace MozartCS.AdminCompta
{
  public partial class frmBudget_Saison : Form
  {

    private DataTable dt = new DataTable();

    public frmBudget_Saison()
    {
      InitializeComponent();
    }

    private void frmBudget_Gestion_Load(object sender, EventArgs e)
    {
      ModuleMain.Initboutons(this);
    }

    private void BtnQuit_Click(object sender, EventArgs e)
    {
      this.Dispose();
    }

    private void LoadData()
    {
      if (DateEditAnnee.EditValue != null)
      {
        ModuleData.LoadData(dt, $"EXEC [api_sp_Budget_Saison_Liste] {((DateTime)DateEditAnnee.EditValue).Year}");
        dt.Columns["NVAL"].ReadOnly = false;       

        PVT_BudgetSaison.DataSource = dt;
      }
    }

    private void BtnValid_Click(object sender, EventArgs e)
    {
      LoadData();
    }
    private void BtnSave_Click(object sender, EventArgs e)
    {

      SqlCommand sqlcmd;

      foreach (DataRow DrSave in dt.Rows)
      {

        sqlcmd = new SqlCommand("[api_sp_Budget_Saison_Save]", MozartDatabase.cnxMozart);
        sqlcmd.CommandType = CommandType.StoredProcedure;
        SqlCommandBuilder.DeriveParameters(sqlcmd);
        sqlcmd.Parameters["@P_NIDBUDGET_SAISON"].Value = DrSave["NIDBUDGET_SAISON"];
        sqlcmd.Parameters["@P_NANNEE"].Value = ((DateTime)DateEditAnnee.EditValue).Year;
        sqlcmd.Parameters["@P_NMOIS"].Value = DrSave["NMOIS"];
        sqlcmd.Parameters["@P_NVAL"].Value = DrSave["NVAL"];
        sqlcmd.Parameters["@P_VSOCIETE"].Value = MozartLib.MozartParams.NomSociete;

        sqlcmd.ExecuteNonQuery();

      }

      //reload
      dt = new DataTable();
      LoadData();
    }

    private void PVT_BudgetSaison_FieldValueDisplayText(object sender, DevExpress.XtraPivotGrid.PivotFieldDisplayTextEventArgs e)
    {
      if (e.Field == null) return;
      if (e.Field.FieldName == "NMOIS")
      {
        e.DisplayText = CultureInfo.CurrentCulture.DateTimeFormat.GetMonthName((int)e.Value);
      }
    }

    private void PVT_BudgetSaison_EditValueChanged(object sender, DevExpress.XtraPivotGrid.EditValueChangedEventArgs e)
    {
      ChangeCellValue(e, Convert.ToDecimal(e.Value), Convert.ToDecimal(e.Editor.EditValue));
    }
        private void ChangeCellValue(EditValueChangedEventArgs e, decimal oldValue, decimal newValue)
    {
      PivotDrillDownDataSource ds = e.CreateDrillDownDataSource();
      for (int i = 0; i < ds.RowCount; i++)
      {
        ds.SetValue(i, e.DataField, newValue);
      }
    }

  }
 }
