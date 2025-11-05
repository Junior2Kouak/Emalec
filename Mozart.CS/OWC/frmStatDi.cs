using DevExpress.XtraCharts;
using MozartCS.Properties;
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
  public partial class frmStatDi : Form
  {
    public string sTypeStat;

    private DataTable dtStatDi = new DataTable();

    public frmStatDi()
    {
      InitializeComponent();
    }

    private void frmStatDi_Load(object sender, System.EventArgs e)
    {
      try
      {
        Cursor.Current = Cursors.WaitCursor;

        ModuleMain.Initboutons(this);

        switch (sTypeStat)
        {
          case "NbAction":
            lblTitre.Text = Resources.lbl_NbAction;
            break;
          case "NbDep":
            lblTitre.Text = Resources.lbl_NbDep;
            break;
          case "NbDevis":
            lblTitre.Text = Resources.lbl_NbDevis;
            break;
        }

        RemplirCbo();

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

    //Option Explicit

    //  Dim rsStat As ADODB.Recordset
    //  Public sTypeStat As String

    //  Private Sub Form_Load()
    //    Screen.MousePointer = vbHourglass
    //    InitBoutons Me, frmMenu
    //    RemplirCbo
    //    LoadRs
    //    InitGrid
    //    InitGraph
    //    Screen.MousePointer = vbDefault
    //  End Sub

    private class donneesGraph
    {
      public string moisannee { get; set; }
      public int nombre { get; set; }
      public donneesGraph() { }
    }

    private void InitGraph()
    {
      List<donneesGraph> listDataSource = new List<donneesGraph>();

      ChartSpace1.Series.Clear();

      if (dtStatDi.Rows.Count > 0)
      {
        lblPeriode.Text = $"{Resources.lblPeriode}{dtStatDi.Rows[0]["PERIODE"]} --> ";

        foreach (DataRow row in dtStatDi.Rows)
        {
          listDataSource.Add(new donneesGraph()
          {
            moisannee = $"{Utils.BlankIfNull(row["mois"]).ToString()}/{Utils.BlankIfNull(row["annee"]).ToString().Substring(2)}",
            nombre = (int)Utils.ZeroIfNull(row["CPT"])
          });
        }

        lblPeriode.Text += dtStatDi.Rows[dtStatDi.Rows.Count - 1]["PERIODE"].ToString();

        Series serie1 = new Series("", ViewType.Bar);
        serie1.DataSource = listDataSource;
        serie1.ArgumentDataMember = "moisannee";
        serie1.ValueDataMembers.AddRange(new string[] { "nombre" });
        serie1.View.Color = System.Drawing.Color.FromArgb(((int)(((byte)(127)))), ((int)(((byte)(127)))), ((int)(((byte)(255)))));

        ChartSpace1.Series.Add(serie1);

        XYDiagram2DSeriesViewBase myView = ((XYDiagram2DSeriesViewBase)serie1.View);
        RegressionLine regLine = new RegressionLine();
        regLine.Color = System.Drawing.Color.Black;
        regLine.LineStyle.Thickness = 3;
        myView.Indicators.Add(regLine);

        XYDiagram diagram = ChartSpace1.Diagram as XYDiagram;
        diagram.AxisX.QualitativeScaleOptions.AutoGrid = false;
        diagram.DefaultPane.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(227)))), ((int)(((byte)(227)))), ((int)(((byte)(227)))));
      }
    }
    /*
  Private Sub InitGraph()
  Dim Categories, Values
  Dim c, trndline
  Dim total

    If rsStat.RecordCount > 0 Then
      rsStat.MoveFirst
      lblPeriode = "§Période d'étude : §" & rsStat("PERIODE") & " --> "

      total = 0
      While Not rsStat.EOF
        Categories = Categories & rsStat("mois") & "/ " & Right(rsStat("annee"), 2) & Chr(9)
        Values = Values & rsStat("CPT") & Chr(9)
        rsStat.MoveNext
      Wend

      rsStat.MoveLast
      lblPeriode = lblPeriode & rsStat("PERIODE")

      ' Remove the leftover tab character at the end of the strings.
      Categories = Left(Categories, Len(Categories) - 1)
      Values = Left(Values, Len(Values) - 1)

      ' Create a chart with one series (called "Sales").
      ChartSpace1.Clear
      ChartSpace1.Charts.Add
      ChartSpace1.Charts(0).SeriesCollection.Add
      ChartSpace1.Charts(0).SeriesCollection(0).Caption = " "

      'Set the series categories and values using the strings created from the recordset.
      Set c = ChartSpace1.Constants
      ChartSpace1.Charts(0).SeriesCollection(0).SetData c.chDimCategories, c.chDataLiteral, Categories
      ChartSpace1.Charts(0).SeriesCollection(0).SetData c.chDimValues, c.chDataLiteral, Values
      Set trndline = ChartSpace1.Charts(0).SeriesCollection(0).Trendlines.Add
      trndline.IsDisplayingRSquared = False
      trndline.IsDisplayingEquation = False
    Else
      ChartSpace1.Clear
    End If


  End Sub
  */

    private void InitGrid()
    {
      apiTGrid1.AddColumn(Resources.periode, "periode", 1300 / 15, "", 2);
      apiTGrid1.AddColumn(Resources.Cpt, "Cpt", 1000 / 15, "", 2);

      //apiTGrid1.FilterBar = false;
      apiTGrid1.InitColumnList();

      apiTGrid1.btnExcel.Visible = false;
      //apiTGrid1.btnPrint.Visible = false;
      apiTGrid1.chkColumnsList.Visible = false;
    }

    //Private Sub InitGrid()
    //  apiTGrid1.AddColumn "§Période§", "Periode", 1300, , 2
    //  apiTGrid1.AddColumn "§Nb actions§", "Cpt", 1000, , 2
    //End Sub

    //Private Sub LoadRs()
    //' UPGRADE_INFO (#0501): The 'sSql' member isn't used anywhere in current application.
    //' Dim sSql As String

    //  Set rsStat = New ADODB.Recordset
    //  rsStat.Open "api_sp_StatistiqueDi '" & sTypeStat & "'," & cboCteAna.ItemData(cboCteAna.ListIndex), cnx
    //  Select Case sTypeStat
    //    Case "NbAction"
    //      lblTitre = "§Evolution du nombre d'actions saisies sur 48 mois (hors préventives)§"
    //    Case "NbDep"
    //      lblTitre = "Evolution du nombre de dépannages saisis sur 36 mois glissants"
    //    Case "NbDevis"
    //      lblTitre = "§Evolution du nombre de devis saisis sur 48 mois§"
    //  End Select

    //End Sub

    class cboCteAnaItem
    {
      public string NCANNUM;
      public string VCANLIB;

      public override string ToString()
      {
        return $"{NCANNUM} - {VCANLIB}";
      }
    }
    private void RemplirCbo()
    {
      string strSQL = $"SELECT NCANNUM, VCANLIB FROM TREF_CTEANA WHERE VSOCIETE = '{MozartParams.NomSociete}'  ORDER BY NCANNUM";

      cboCteAna.Items.Clear();

      cboCteAna.Items.Add(new cboCteAnaItem() { NCANNUM = "0", VCANLIB = Resources.cboCteAna });

      cboCteAna.SetItemData("0");

      using (SqlDataReader dr = ModuleData.ExecuteReader(strSQL))
      {
        while (dr.Read())
        {
          cboCteAna.Items.Add(new cboCteAnaItem() { NCANNUM = Utils.BlankIfNull(dr["NCANNUM"]), VCANLIB = Utils.BlankIfNull(dr["VCANLIB"]) });
        }

        dr.Close();
      }

      if (cboCteAna.Items.Count > 0)
        cboCteAna.SelectedIndex = 0;
    }

    //Private Sub RemplirCbo()
    //Dim rsCte As ADODB.Recordset
    //Dim i As Integer

    //  Set rsCte = New ADODB.Recordset
    //  rsCte.Open "SELECT NCANNUM,VCANLIB FROM TREF_CTEANA WHERE VSOCIETE = '" & gstrNomSociete & "' ORDER BY NCANNUM", cnx

    //  cboCteAna.Clear

    //  cboCteAna.AddItem "§Tous§"
    //  cboCteAna.ItemData(0) = 0

    //  i = 1
    //  While Not rsCte.EOF
    //    cboCteAna.AddItem rsCte!NCANNUM & " - " & rsCte!VCANLIB
    //    cboCteAna.ItemData(i) = rsCte!NCANNUM
    //    rsCte.MoveNext
    //    i = i + 1
    //  Wend
    //  rsCte.Close
    //  cboCteAna.ListIndex = 0

    //End Sub


    private void cboCteAna_SelectedIndexChanged(object sender, EventArgs e)
    {
      try
      {
        Cursor = Cursors.WaitCursor;

        apiTGrid1.LoadData(dtStatDi, MozartDatabase.cnxMozart, $"exec api_sp_StatistiqueDi '{sTypeStat}', {(cboCteAna.SelectedItem as cboCteAnaItem).NCANNUM}");
        apiTGrid1.GridControl.DataSource = dtStatDi;

        InitGraph();
      }
      catch (Exception ex)
      {
        Utils.ShowException(ex, MethodBase.GetCurrentMethod().Name, ex.StackTrace);
      }
      finally
      {
        Cursor = Cursors.Default;
      }
    }

    //Private Sub cboCteAna_Click()
    //  LoadRs
    //  apiTGrid1.Init rsStat
    //  InitGraph
    //End Sub


    //Private Sub Form_Unload(Cancel As Integer)
    //  rsStat.Close
    //End Sub

    private void cmdQuitter_Click(object sender, System.EventArgs e)
    {
      Dispose();
    }

    //Private Sub cmdQuitter_Click()
    // Unload Me
    //End Sub
  }
}
