using DevExpress.XtraCharts;
using MozartCS.Properties;
using MozartLib;
using MozartNet;
using System;
using System.Collections.Generic;
using System.Data;
using System.Reflection;
using System.Windows.Forms;
using MZUtils = MozartControls.Utils;

namespace MozartCS
{
  public partial class frmStatPrestation : Form
  {
    public string sType;

    private DataTable dt = new DataTable();

    public frmStatPrestation()
    {
      InitializeComponent();
    }

    private void frmStatPrestation_Load(object sender, System.EventArgs e)
    {
      try
      {
        Cursor.Current = Cursors.WaitCursor;

        ModuleMain.Initboutons(this);

        InitCombos();

        InitGrid();
      }
      catch (Exception ex)
      {
        MZUtils.displayError(MethodBase.GetCurrentMethod().Name, ex);
      }
      finally
      {
        Cursor.Current = Cursors.Default;
      }
    }

    private void cmdQuitter_Click(object sender, System.EventArgs e)
    {
      Dispose();
    }


    private void InitCombos()
    {
      string langue = MozartParams.Langue;

      if (sType == "P")
      {
        cboChoix.Init(MozartDatabase.cnxMozart, $"SELECT CPRECOD, VPRELIB FROM TREF_PRE where LANGUE='{langue}' ORDER BY VPRELIB",
                      "CPRECOD", "VPRELIB", new List<string>() { "", Resources.col_Nom }, 200, 400, true);
      }
      else if (sType == "T")
      {
        this.Text.Replace("prestation", "technique");
        lblChoix.Text = Resources.txt_choix_tech;
        cboChoix.Init(MozartDatabase.cnxMozart, $"SELECT CTECCOD, VTECLIB FROM TREF_TEC where LANGUE='{langue}' ORDER BY VTECLIB",
                      "CTECCOD", "VTECLIB", new List<string>() { "", Resources.col_Nom }, 200, 400, true);
      }

      cboCli.Init(MozartDatabase.cnxMozart, "SELECT NCLINUM,VCLINOM FROM TCLI WHERE VSOCIETE = App_Name() AND CCLIACTIF = 'O' " +
                                  "UNION SELECT 0 AS NCLINUM,' - TOUS - ' AS VCLINOM ORDER BY VCLINOM",
                                  "NCLINUM", "VCLINOM", new List<string>() { "", Resources.col_Nom }, 200, 400, true);

      DataTable dt = cboChoix.DataSource() as DataTable;
      cboChoix.SetText(dt.Rows[0][1].ToString());
      dt = cboCli.DataSource() as DataTable;
      cboCli.SetText(dt.Rows[0][1].ToString());
    }
    private void InitGrid()
    {
      apiGrid.AddColumn(Resources.periode, "Periode", 1000, "", 2);
      apiGrid.AddColumn(Resources.col_montant_ht, "Montant", 1500, "Currency", 1);
      apiGrid.AddColumn(Resources.col_Nb_Intervention, "Cpt", 1200, "", 1);

      apiGrid.btnExcel.Visible = false;
      apiGrid.chkColumnsList.Visible = false;
    }

    private void cboChoix_TxtChanged(object sender, EventArgs e)
    {
      try
      {
        Cursor.Current = Cursors.WaitCursor;

        InitFeuille();
      }
      catch (Exception ex)
      {
        MZUtils.displayError(MethodBase.GetCurrentMethod().Name, ex);
      }
      finally
      {
        Cursor.Current = Cursors.Default;
      }
    }

    private void cboCli_TxtChanged(object sender, EventArgs e)
    {
      try
      {
        Cursor.Current = Cursors.WaitCursor;

        InitFeuille();
      }
      catch (Exception ex)
      {
        MZUtils.displayError(MethodBase.GetCurrentMethod().Name, ex);
      }
      finally
      {
        Cursor.Current = Cursors.Default;
      }
    }

    private class donneesGraph
    {
      public string periode { get; set; }
      public decimal Montant { get; set; }
      public int Cpt { get; set; }
      public donneesGraph() { }
    }

    private void InitFeuille()
    {
      List<donneesGraph> listDataSource = new List<donneesGraph>();
      string choix = cboChoix.GetItemDataString();// (oc as DataRowView).Row[0].ToString();
      string cli = cboCli.GetItemData().ToString();
      if ("" == choix || "-1" == cli)
        return;

      string sql;
      if (sType == "P")
      {
        lbltitre.Text = Resources.txt_stat_prestation_date;
        sql = $"exec api_sp_StatPrestTech 'P', '{choix}', {cli}";
      }
      else if (sType == "T")
      {
        lbltitre.Text = Resources.txt_stat_technique_date;
        sql = $"exec api_sp_StatPrestTech 'T','{choix}', {cli}";
      }
      else { return; }

      apiGrid.LoadData(dt, MozartDatabase.cnxMozart, sql);
      apiGrid.GridControl.DataSource = dt;

      int nb = dt.Rows.Count;
      if (0 < nb)
      {
        lbltitre.Text += $" {dt.Rows[nb - 1]["Periode"]} à {dt.Rows[0]["Periode"]}";
      }

      foreach (DataRow row in dt.Rows)
      {
        listDataSource.Add(new donneesGraph()
        {
          periode = $"{Utils.BlankIfNull(row[3])}/{Utils.BlankIfNull(row[4]).Substring(2)}",
          Montant = (decimal)Utils.ZeroIfBlank(row["Montant"]),
          Cpt = (int)Utils.ZeroIfBlank(row["Cpt"])
        });
      }

      // serie fact
      Series serie1 = GraphFact.Series["Serie1"];
      serie1.DataSource = listDataSource;
      ((XYDiagram)GraphFact.Diagram).AxisX.QualitativeScaleOptions.AutoGrid = false;

      // serie NB
      Series serie2 = GraphNb.Series["Serie1"];
      serie2.DataSource = listDataSource;
      ((XYDiagram)GraphNb.Diagram).AxisX.QualitativeScaleOptions.AutoGrid = false;
    }
  }
}

