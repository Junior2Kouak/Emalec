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
  public partial class frmStatsCompta : Form
  {
    private DataTable dt = new DataTable();

    public frmStatsCompta()
    {
      InitializeComponent();
    }

    private void frmStatsCompta_Load(object sender, System.EventArgs e)
    {
      try
      {
        Cursor.Current = Cursors.WaitCursor;

        ModuleMain.Initboutons(this);

        txtDateA0.Text = DateTime.Now.AddYears(-1).ToShortDateString();
        txtDateA1.Text = DateTime.Now.ToShortDateString();

        InitApigrid();

        UpdateGraph();
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


    private void cmdImprimer_Click(object sender, EventArgs e)
    {
      this.ImprimerDansWord();
    }

    private class donneesGraph
    {
      public int NUMMOIS { get; set; }
      public int NBFOUFAC { get; set; }
      public donneesGraph() { }
    }

    private void UpdateGraph()
    {
      string sql = $"exec api_sp_StatIndicaCompta '{txtDateA0.Text}', '{txtDateA1.Text}'";
      ApiGrid.LoadData(dt, MozartDatabase.cnxMozart, sql);
      ApiGrid.GridControl.DataSource = dt;

      Label4.Text = txtDateA0.Text;
      Label6.Text = txtDateA1.Text;

      // graphique 
      List<donneesGraph> listDataSource = new List<donneesGraph>();
      Series serie1 = ChartSpace1.Series["Serie1"];

      foreach (DataRow row in dt.Rows)
      {
        listDataSource.Add(new donneesGraph() { NUMMOIS = (int)Utils.ZeroIfNull(row["NUMMOIS"]), NBFOUFAC = (int)Utils.ZeroIfNull(row["NBFOUFAC"]) });
      }

      serie1.DataSource = listDataSource;
      serie1.ArgumentScaleType = ScaleType.Qualitative;

      XYDiagram diagram = ChartSpace1.Diagram as XYDiagram;
      diagram.AxisX.WholeRange.SideMarginsValue = 1;
      diagram.AxisX.QualitativeScaleOptions.AutoGrid = false;
    }

    private void cmdValider_Click(object sender, EventArgs e)
    {
      try
      {
        UpdateGraph();
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

    private void InitApigrid()
    {
      ApiGrid.AddColumn(Resources.col_Mois, "NUMMOIS", 800);
      ApiGrid.AddColumn(Resources.col_nb_factures, "NBFOUFAC", 800);
      ApiGrid.AddColumn(Resources.col_enpc, "POURC", 800);

      ApiGrid.FilterBar = false;
      ApiGrid.btnExcel.Visible = false;
      ApiGrid.btnPrint.Visible = false;
      ApiGrid.chkColumnsList.Visible = false;
    }
  }
}

