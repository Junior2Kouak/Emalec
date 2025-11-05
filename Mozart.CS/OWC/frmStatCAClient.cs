using DevExpress.Utils.Editors;
using DevExpress.XtraCharts;
using MozartCS.Properties;
using MozartLib;
using MozartNet;
using System;
using System.Collections.Generic;
using System.Data;
using System.Drawing;
using System.Reflection;
using System.Windows.Forms;
using MZUtils = MozartControls.Utils;

namespace MozartCS
{
  public partial class frmStatCAClient : Form
  {
    public string msNomClient;
    public int miNumClient;
    public string strNomSociete;

    private DataTable dt = new DataTable();

    public frmStatCAClient()
    {
      InitializeComponent();
    }

    private void frmStatCAClient_Load(object sender, System.EventArgs e)
    {
      try
      {
        Cursor.Current = Cursors.WaitCursor;

        ModuleMain.Initboutons(this);

        // masquer le graph
        HideGraph();

        FormatGrid();

				txtDateDebut.Text = DateTime.Now.AddYears(-1).ToShortDateString();
				txtDateFin.Text = DateTime.Now.ToShortDateString();

				cboClient.Init(MozartDatabase.cnxMozart, $"SELECT NCLINUM, VCLINOM FROM TCLI WHERE CCLIACTIF = 'O' AND VSOCIETE='{strNomSociete}' order by VCLINOM",
                       "NCLINUM", "VCLINOM", new List<string>() { "", Resources.col_Nom }, 200, 400);

        if (miNumClient > 0)
        {
          cboClient.SetItemData(miNumClient);

          UpdateData();
        }

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
      public string per { get; set; }
      public int THT { get; set; }
      public donneesGraph() { }
    }
    private void HideGraph()
    {
      XYDiagram diagram = ChartSpace1.Diagram as XYDiagram;
      diagram.DefaultPane.Visibility = ChartElementVisibility.Hidden;
    }

    private void ShowGraph()
    {
      XYDiagram diagram = ChartSpace1.Diagram as XYDiagram;
      diagram.DefaultPane.Visibility = ChartElementVisibility.Visible;

    }

    private void UpdateData()
    {
      string sql = $"exec api_sp_StatistiqueCAClient {cboClient.GetItemData()},'{txtDateDebut.Text}','{txtDateFin.Text}'";
      grdDataGrid2.LoadData(dt, MozartDatabase.cnxMozart, sql);
      grdDataGrid2.GridControl.DataSource = dt;

      // graphique 
      HideGraph();
      List<donneesGraph> listDataSource = new List<donneesGraph>();
      int nb = dt.Rows.Count;
      int total = 0;
      foreach (DataRow row in dt.Rows)
      {
        int n = (int)Utils.ZeroIfNull(row["THT"]);
        total += n;
        listDataSource.Add(new donneesGraph() { per = row["per"].ToString(), THT = n });
      }

			ChartSpace1.Titles[0].Text = $"CA sur la période sélectionnée :   {total:C2} HT";

			Series serie1 = ChartSpace1.Series["Serie1"];
      serie1.DataSource = listDataSource;

      ((XYDiagram)ChartSpace1.Diagram).AxisX.QualitativeScaleOptions.AutoGrid = false;

			TrendLine trLine = new TrendLine();
			trLine.Color = Color.Black;
			trLine.LineStyle.Thickness = 3;        // Définir l’épaisseur à 3 pixels
			trLine.LineStyle.DashStyle = DashStyle.Solid;  // Style plein

			SideBySideBarSeriesView view = (SideBySideBarSeriesView)serie1.View;
			view.Indicators.Add(trLine);

			ShowGraph();

    }

    private void cmdValider_Click(object sender, EventArgs e)
    {
      try
      {
        Cursor.Current = Cursors.WaitCursor;

        UpdateData();
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

    private void cmdImprimer_Click(object sender, EventArgs e)
    {
      this.ImprimerDansWord();
    }

    private void FormatGrid()
    {
      grdDataGrid2.AddColumn(Resources.col_Mois, "mois", 1350);
      grdDataGrid2.AddColumn(Resources.col_TotEuroHT, "THT", 1250, "Currency", 2);

      grdDataGrid2.chkColumnsList.Visible = false;
    }

		private void cmdQuitter_Click(object sender, System.EventArgs e)
		{
			Dispose();
		}

	}

}

