using DevExpress.XtraCharts;
using MozartCS.Properties;
using MozartLib;
using MozartNet;
using MozartUC;
using System;
using System.Collections;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Reflection;
using System.Windows.Forms;
using MZCtrlResources = MozartControls.Properties.Resources;

namespace MozartCS
{
  public partial class frmStatComCACliByCom : Form
  {
    DataTable dtCom = new DataTable();
    DataTable dtCliCom = new DataTable();

    public frmStatComCACliByCom()
    {
      InitializeComponent();
    }

    private void frmStatComCACliByCom_Load(object sender, System.EventArgs e)
    {
      List<string> lstCategories = new List<string>();
      List<string> lstvaluesSR = new List<string>();
      List<string> lstvaluesJC = new List<string>();
      List<string> lstvaluesRM = new List<string>();
      List<string> lstvaluesEC = new List<string>();
      List<string> lstvaluesPB = new List<string>();

      try
      {
        Cursor.Current = Cursors.WaitCursor;

        ModuleMain.Initboutons(this);

        //    'intitulé de la form
        Label1.Text += Resources.txt_du + DateTime.Now.AddDays(-12).ToShortDateString() + Resources.txt_au + DateTime.Now.ToShortDateString();

        apiTGridCliCom.LoadData(dtCliCom, MozartDatabase.cnxMozart, "exec api_sp_StatCommCACliByCOM 0");
        apiTGridCliCom.GridControl.DataSource = dtCliCom;
        InitApiGridCliCom();

        apiTGridCom.LoadData(dtCom, MozartDatabase.cnxMozart, "exec api_sp_StatCommCACliByCOM 1");
        apiTGridCom.GridControl.DataSource = dtCom;
        InitApiGridCom();

        // Calcul total grille haut
        CalculTHT(apiTGridCliCom, txtHTCliCom);

        apiTGridCliCom.dgv.ColumnFilterChanged += new EventHandler(apiTGridCliCom_ColumnFilterChanged);

        ArrayList listDataSource = new ArrayList();

        using (SqlDataReader drGraph = ModuleData.ExecuteReader("exec api_sp_StatCommRatio"))
        {
          while (drGraph.Read())
          {
            listDataSource.Add(new Record(drGraph[0].ToString(),
                                          Utils.ZeroIfNull(drGraph["SR"]),
                                          Utils.ZeroIfNull(drGraph["JC"]),
                                          Utils.ZeroIfNull(drGraph["RM"]),
                                          Utils.ZeroIfNull(drGraph["PB"]),
                                          Utils.ZeroIfNull(drGraph["EC"])));
          }
          drGraph.Close();
        }

        ChartSpaceSR.DataSource = listDataSource;

        // Uniquement pour Emalec
        if (MozartParams.NomSociete == "EMALEC")
        {
          Series serie1 = new Series("Montero", ViewType.Bar);
          ChartSpaceSR.Series.Add(serie1);
          serie1.ArgumentDataMember = "Category";
          serie1.ValueDataMembers.AddRange(new string[] { "valueSR" });

          Series serie2 = new Series("Dolso", ViewType.Bar);
          ChartSpaceSR.Series.Add(serie2);
          serie2.ArgumentDataMember = "Category";
          serie2.ValueDataMembers.AddRange(new string[] { "valueJC" });

          Series serie3 = new Series("Gonzales", ViewType.Bar);
          ChartSpaceSR.Series.Add(serie3);
          serie3.ArgumentDataMember = "Category";
          serie3.ValueDataMembers.AddRange(new string[] { "valueRM" });

          Series serie4 = new Series("Marechet", ViewType.Bar);
          ChartSpaceSR.Series.Add(serie4);
          serie4.ArgumentDataMember = "Category";
          serie4.ValueDataMembers.AddRange(new string[] { "valuePB" });

          XYDiagram myDiagram = (XYDiagram)ChartSpaceSR.Diagram;
          myDiagram.AxisX.MinorCount = 1;
          myDiagram.AxisX.Label.Angle = -90;
          myDiagram.AxisX.QualitativeScaleOptions.AutoGrid = false;
        }
        else if (MozartParams.NomSociete == "EMALECMPM")
        {
          Series serie1 = new Series("Veron", ViewType.Bar);
          ChartSpaceSR.Series.Add(serie1);
          serie1.ArgumentDataMember = "Category";
          serie1.ValueDataMembers.AddRange(new string[] { "valueSR" });

          Series serie2 = new Series("Rabeyrin", ViewType.Bar);
          ChartSpaceSR.Series.Add(serie2);
          serie2.ArgumentDataMember = "Category";
          serie2.ValueDataMembers.AddRange(new string[] { "valueJC" });
        }
      }
      catch (Exception ex)
      {
        Utils.ShowException(ex, MethodBase.GetCurrentMethod().Name, ex.StackTrace);
      }
      finally
      {
        Cursor.Current = Cursors.Default;
      }
    }
    
    private void cmdMO_Click(object sender, EventArgs e)
    {
      if (apiTGridCom.GetFocusedDataRow() == null) return;

      if (MozartParams.Droit == "OUI")
      {
        Cursor.Current = Cursors.WaitCursor;
        frmStatAnaCSTByCte f = new frmStatAnaCSTByCte();
        f.miNPERNUM = Convert.ToInt32(apiTGridCom.GetFocusedDataRow()["NPERNUM"]);
        f.msVPERNOM = apiTGridCom.GetFocusedDataRow()["VPERNOM"].ToString(); ;
        f.ShowDialog();
        Cursor.Current = Cursors.Default;
      }
    }

    private void InitApiGridCliCom()
    {
      try
      {
        apiTGridCliCom.AddColumn(MZCtrlResources.col_Client, "VCLINOM", 3500, "", 2);
        apiTGridCliCom.AddColumn(Resources.col_Creation, "DCLIDATECRE", 1100, "dd/mm/yy", 2);
        apiTGridCliCom.AddColumn(Resources.col_CAEuroHT, "MONTANT", 2800, "currency", 1);
        apiTGridCliCom.AddColumn(MZCtrlResources.Commercial, "NOM", 2500, "", 2);

        apiTGridCliCom.FilterBar = true;
        apiTGridCliCom.InitColumnList();
      }
      catch (Exception ex)
      {
        Utils.ShowException(ex, MethodBase.GetCurrentMethod().Name, ex.StackTrace);
      }
    }

    private void InitApiGridCom()
    {
      apiTGridCom.AddColumn(MZCtrlResources.Commercial, "VPERNOM", 2500, "", 2);
      apiTGridCom.AddColumn(Resources.col_CAEuroHT, "MONTANT", 2300, "currency", 1);
      apiTGridCom.AddColumn(Resources.col_CoutGlobalPers, "COUT", 2500, "currency", 1);
      apiTGridCom.AddColumn(Resources.col_TempsAffecMissionComm, "TEMP", 3000, "", 1);
      apiTGridCom.AddColumn(Resources.col_RatioRentabilite, "RATIO", 1000, "0.00", 2);
    }

    private void CalculTHT(apiTGrid grid, TextBox txt)
    {
      double dTot = 0;

      for (int i = 0; i < grid.dgv.RowCount; i++)
      {
        DataRow row = grid.dgv.GetDataRow(i);
        dTot += Convert.ToDouble(row["Montant"]);
      }
      txt.Text = dTot.ToString("### ### ##0.00");
    }

    private void apiTGridCliCom_ColumnFilterChanged(object sender, EventArgs e)
    {
      CalculTHT(apiTGridCliCom, txtHTCliCom);
    }

    private void cmdQuitter_Click(object sender, System.EventArgs e)
    {
      Dispose();
    }
  }
  public class Record
  {
    public string category { get; set; }
    public double valueSR { get; set; }
    public double valueJC { get; set; }
    public double valueRM { get; set; }
    public double valuePB { get; set; }
    public double valueEC { get; set; }
    public Record(string cat, double sr, double jc, double rm, double pb, double ec)
    {
      category = cat;
      valueSR = sr;
      valueJC = jc;
      valueRM = rm;
      valuePB = pb;
      valueEC = ec;
    }
  }
}
