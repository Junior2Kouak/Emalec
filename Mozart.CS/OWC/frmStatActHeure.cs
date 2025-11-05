using DevExpress.XtraCharts;
using MozartLib;
using MozartNet;
using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Reflection;
using System.Windows.Forms;
using MZUtils = MozartControls.Utils;


namespace MozartCS
{
  public partial class frmStatActHeure : Form
  {
    public frmStatActHeure()
    {
      InitializeComponent();
    }

    private void frmStatActHeure_Load(object sender, System.EventArgs e)
    {
      try
      {
        Cursor.Current = Cursors.WaitCursor;

        ModuleMain.Initboutons(this);

        txtDateA0.Text = $"01/01/{DateTime.Now.Year.ToString()}";
        txtDateA1.Text = DateTime.Now.ToShortDateString();

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

    private void cmdQuitter_Click(object sender, System.EventArgs e)
    {
      Dispose();
    }

    private class donneesGraph
    {
      public string heure { get; set; }
      public int valeur { get; set; }
      public donneesGraph() { }
    }
    private void HideGraph()
    {
      XYDiagram diagram = Chart.Diagram as XYDiagram;
      diagram.DefaultPane.Visibility = ChartElementVisibility.Hidden;
    }

    private void ShowGraph()
    {
      XYDiagram diagram = Chart.Diagram as XYDiagram;
      diagram.DefaultPane.Visibility = ChartElementVisibility.Visible;
    }

    private void UpdateData()
    {
      Label4.Text = txtDateA0.Text;
      Label6.Text = txtDateA1.Text;

      List<donneesGraph> listDataSource = new List<donneesGraph>();

      HideGraph();

      using (SqlCommand cmd = new SqlCommand("api_sp_StatActParHeure", MozartDatabase.cnxMozart))
      {
        cmd.CommandType = CommandType.StoredProcedure;
        SqlCommandBuilder.DeriveParameters(cmd);

        cmd.Parameters["@DateDebut"].Value = txtDateA0.Text;
        cmd.Parameters["@DateFin"].Value = txtDateA1.Text;

        using (SqlDataReader reader = cmd.ExecuteReader())
        {
          while (reader.Read())
          {
            listDataSource.Add(new donneesGraph() { heure = reader[0].ToString(), valeur = (int)Utils.ZeroIfNull(reader[1]) });
          }
        }
      }

      Series serie1 = Chart.Series["Serie1"];
      serie1.DataSource = listDataSource;

      (Chart.Diagram as XYDiagram).AxisX.QualitativeScaleOptions.AutoGrid = false;

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


  }
}

