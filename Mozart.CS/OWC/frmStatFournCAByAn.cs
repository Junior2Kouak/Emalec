using DevExpress.XtraCharts;
using MozartCS.Properties;
using MozartLib;
using MozartNet;
using MozartUC;
using System;
using System.Collections.Generic;
using System.Data;
using System.Reflection;
using System.Windows.Forms;
using MZUtils = MozartControls.Utils;


namespace MozartCS
{
  public partial class frmStatFournCAByAn : Form
  {
    public int iNumFour;
    public string sNomFour;
    public string sNomSocieteSelected;

    private DataTable dt = new DataTable();

    public frmStatFournCAByAn()
    {
      InitializeComponent();
    }

    private class donneesGraph
    {
      public int Annee { get; set; }
      public int TotalHT { get; set; }
      public donneesGraph() { }
    }

    private void frmStatFournCAByAn_Load(object sender, System.EventArgs e)
    {
      try
      {
        Cursor.Current = Cursors.WaitCursor;

        ModuleMain.Initboutons(this);

        InitApigrid();

        string sql = $"exec api_sp_StatistiqueFournCAByAn {iNumFour}, '{sNomSocieteSelected}'";
        apiTGrid.LoadData(dt, MozartDatabase.cnxMozart, sql);
        apiTGrid.GridControl.DataSource = dt;

        // graphique 
        List<donneesGraph> listDataSource = new List<donneesGraph>();
        int total = 0;
        foreach (DataRow row in dt.Rows)
        {
          int n = (int)Utils.ZeroIfBlank(row["TotalHT"]);
          total += n;
          listDataSource.Add(new donneesGraph() { Annee = (int)Utils.ZeroIfBlank(row["Annee"]), TotalHT = n });
        }

        Label1.Text = $"CA de '{sNomFour}' : {total:### ### ###}  €HT";

        Label7.Text = $"{Label7.Text} {sNomFour}";

        Series serie1 = Chart.Series["Serie1"];
        serie1.DataSource = listDataSource;
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

    /*
    Option Explicit

      Public iNumFour As Long
      Public sNomFour As String
      Public sNomSocieteSelected As String

      Dim ado_rs As ADODB.Recordset


      Private Sub Form_Load()

      Dim Values, Categories
      Dim c
      Dim lTotal As Long

      On Error GoTo Handler

        If cnxRep.state = adStateClosed Then
          ' ouverture connexion
          'cnxRep.Open gstrConnexionStringReplique

          ' TB SAMSIC CITY BASE
          cnxRep.Open gstrConnexion
          ' cnxRep.Open "PROVIDER=SQLOLEDB.1;Initial Catalog=MULTI;Data Source=" & gstrNomServeur & ";trusted_connection=yes;App=" & gstrNomSociete & ";"
          cnxRep.CommandTimeout = 150
        End If


        Set ado_rs = New ADODB.Recordset

        InitBoutons Me, frmMenu

        ado_rs.Open "exec api_sp_StatistiqueFournCAByAn " & iNumFour & ", '" & sNomSocieteSelected & "'", cnxRep

        Screen.MousePointer = vbDefault

        InitApigrid

        Chart.Clear
        Chart.Charts.Add
        Chart.Charts.Item(0).PlotArea.Interior.Color = &H80C0FF
        Chart.Charts.Item(0).Axes.Item(0).NumberFormat = "## ### ##0 €"
        Chart.Charts(0).SeriesCollection.Add
        Chart.Charts(0).SeriesCollection(0).Caption = "§CA par fournisseur§"

        If ado_rs.EOF Then Label1.Caption = "": Exit Sub

        While Not ado_rs.EOF
          Categories = Categories & Format(ado_rs.Fields(0).value, "0#") & Chr(9)
          Values = Values & ado_rs.Fields(1).value & Chr(9)
          lTotal = lTotal + ado_rs.Fields(1).value
          ado_rs.MoveNext
        Wend

        Label1.Caption = "CA de '" & sNomFour & "' : " & Format(lTotal, "### ### ###") & "  €HT"

        Label7.Caption = Label7.Caption & " " & sNomFour

        ' Remove the leftover tab character at the end of the strings.
        Categories = Left(Categories, Len(Categories) - 1)
        Values = Left(Values, Len(Values) - 1)

        ' on se replace sur le début de l'enregistrement
        ado_rs.MoveFirst

        ' Create a chart with one series

        'Set the series categories and values using the strings created from the recordset.
        Set c = Chart.Constants
        Chart.Charts(0).SeriesCollection(0).SetData c.chDimCategories, c.chDataLiteral, Categories
        Chart.Charts(0).SeriesCollection(0).SetData c.chDimValues, c.chDataLiteral, Values

        Screen.MousePointer = vbDefault

      Exit Sub
      Resume
      Handler:
        ShowError "Form_Load dans " & Me.Name
      End Sub

      Private Sub cmdQuitter_Click()
        Unload Me
      End Sub
      */

    private void InitApigrid()
    {
      apiTGrid.AddColumn(Resources.col_annee, "Annee", 600);
      apiTGrid.AddColumn(Resources.txt_Tot_HT, "TotalHT", 1400, "Currency", 1);
      apiTGrid.AddColumn(Resources.txt_Nb_Fact, "NbFact", 700, "", 2);
      apiTGrid.AddColumn(Resources.col_Moyenne, "FactMoy", 400, "### ##0", 1);

      apiTGrid.btnExcel.Visible = false;
      //apiTGrid.btnPrint.Visible = false;
      apiTGrid.chkColumnsList.Visible = false;
    }
    /*
  Private Sub InitApigrid()

  On Error GoTo Handler

    apiTGrid.AddColumn "§Année§", "Annee", 600
    apiTGrid.AddColumn "§Tot HT§", "TotalHT", 1400, "currency", 1
    apiTGrid.AddColumn "§Nb Fact§", "NbFact", 700, , 2
    apiTGrid.AddColumn "§Moy§", "FactMoy", 400, "### ##0", 1

    apiTGrid.Init ado_rs
    Exit Sub

  Handler:
    ShowError "FormatGrid dans " & Me.Name
  End Sub
  */

    private void cmdImprimer_Click(object sender, EventArgs e)
    {
      this.ImprimerDansWord();
    }
    /*
    Private Sub cmdImprimer_Click()
    
      ' fonction d'impression écran
      Screen.MousePointer = vbHourglass
      ImprimerDansWord
      Screen.MousePointer = vbDefault
    
    End Sub
  */
  }
}

