using Microsoft.VisualBasic;
using MozartCS.Properties;
using MozartNet;
using System;
using System.Data;
using System.Reflection;
using System.Windows.Forms;
using MZCtrlResources = MozartControls.Properties.Resources;
using MZUtils = MozartControls.Utils;

namespace MozartCS
{
  public partial class frmGESClients : Form
  {

    DataTable dt = new DataTable();
    double dTot = 0;

    public frmGESClients()
    {
      InitializeComponent();
    }


    private void frmGESClient_Load(object sender, EventArgs e)
    {
      try
      {
        DateEdit_Fin.EditValue = DateTime.Now.AddMonths(-1);
        DateEdit_Debut.EditValue = DateTime.Now.AddMonths(-2);
        InitApigrid();
        InitFeuille();
      }
      catch (Exception ex)
      {
        Cursor = Cursors.Default;
        MZUtils.displayError(MethodBase.GetCurrentMethod().Name, ex);
      }
    }

    private void cmdValider_Click(object sender, EventArgs e)
    {
      InitFeuille();
    }

    private void InitFeuille()
    {
      try
      {
        Cursor = Cursors.WaitCursor;

        string sSQL = $"[api_sp_StatCO2] '{DateEdit_Debut.Text}','{DateEdit_Fin.Text}'";

        //création d'une commande 
        ModuleData.LoadData(dt, sSQL);

        apiGrid.GridControl.DataSource = dt;

        //  affichage du total en bas de liste
        calculTHT();

        Cursor = Cursors.Default;
      }
      catch (Exception ex)
      {
        Cursor = Cursors.Default;
        MZUtils.displayError(MethodBase.GetCurrentMethod().Name, ex);
      }
    }

    private void cmdQuitter_Click(object sender, System.EventArgs e)
    {
      Dispose();
    }

    private void InitApigrid()
    {


      try
      {
        apiGrid.AddColumn(MZCtrlResources.col_Client, "VCLINOM", 3300);
        apiGrid.AddColumn(Resources.col_Compte, "NCTEANA", 1100, "", 2);
        apiGrid.AddColumn(Resources.col_Date, "DCO2DAT", 1100, "", 2);
        apiGrid.AddColumn("Type", "TYPECO2", 1600);
        apiGrid.AddColumn("KM", "KM", 1000, "", 1);
        apiGrid.AddColumn("CO2 en Kg", "CO2", 1000, "### ###.00", 1);

        apiGrid.InitColumnList();
      }
      catch (Exception ex)
      {
        MZUtils.displayError(MethodBase.GetCurrentMethod().Name, ex);
      }
    }

    private void calculTHT()
    {
      dTot = 0;

      if (dt.Rows.Count == 0)
        return;

      foreach (DataRow row in dt.Rows)
        dTot += Utils.ZeroIfNull(row["CO2"]);

      lblTHTh.Text = Strings.FormatNumber(dTot, 0);

    }

    private void apiTGrid_ColumnFilterChanged(object sender, EventArgs e)
    {
      double total_filtered = 0;
      //calcul des montant filtred
      DataRow[] dt_filtered;

      DevExpress.Data.Filtering.CriteriaOperator oFilterCrit = apiGrid.dgv.ActiveFilterCriteria;
      dt_filtered = dt.Select(DevExpress.Data.Filtering.CriteriaToWhereClauseHelper.GetDataSetWhere(oFilterCrit));

      total_filtered = 0;
      foreach (DataRow rowbis in dt_filtered)
      {
        total_filtered += Utils.ZeroIfNull(rowbis.Field<decimal>("CO2"));
      }
      lblTHTh.Text = Strings.FormatNumber(total_filtered, 2); //+ " / " + Strings.FormatNumber(dTot, 0);
    }
  }
}

