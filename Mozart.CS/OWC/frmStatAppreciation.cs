using DevExpress.XtraCharts;
using MozartCS.Properties;
using MozartLib;
using MozartNet;
using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Reflection;
using System.Windows.Forms;
using MZUtils = MozartControls.Utils;

namespace MozartCS
{
  public partial class frmStatAppreciation : Form
  {
    public frmStatAppreciation()
    {
      InitializeComponent();
    }

    private void frmStatAppreciation_Load(object sender, System.EventArgs e)
    {
      try
      {
        Cursor.Current = Cursors.WaitCursor;

        ModuleMain.Initboutons(this);

        // masquer le graph
        HideGraph();

        cboclient.Init(MozartDatabase.cnxMozart, $"SELECT DISTINCT C.NCLINUM, VCLINOM FROM TCLI C INNER JOIN EnqueteClientWeb W ON C.NCLINUM=W.NCLINUM WHERE VSOCIETE = " +
                                       $"'{MozartParams.NomSociete}' order by vclinom", "NCLINUM", "VCLINOM", new List<string>() { "", Resources.col_Nom }, 200, 400);
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

    private void HideGraph()
    {
      XYDiagram diagram = GraphFact.Diagram as XYDiagram;
      diagram.DefaultPane.Visibility = ChartElementVisibility.Hidden;
      GraphFact.Titles[0].Visibility = DevExpress.Utils.DefaultBoolean.False;
      GraphFact.Legend.Visibility = DevExpress.Utils.DefaultBoolean.False;
    }

    private void ShowGraph()
    {
      XYDiagram diagram = GraphFact.Diagram as XYDiagram;
      diagram.DefaultPane.Visibility = ChartElementVisibility.Visible;
      GraphFact.Titles[0].Visibility = DevExpress.Utils.DefaultBoolean.True;
      GraphFact.Legend.Visibility = DevExpress.Utils.DefaultBoolean.True;
    }

    private void cmdQuitter_Click(object sender, System.EventArgs e)
    {
      Dispose();
    }

    private void cboclient_TxtChanged(object sender, EventArgs e)
    {
      InitFeuille();
    }


    /*
  Option Explicit
    
    Dim ado_rs As ADODB.Recordset
    
    
    
    
    Private Sub Form_Load()
    
    
      InitBoutons Me, frmMenu
     
       ' combo des clients
      RemplirCombo cboclient, "SELECT DISTINCT C.NCLINUM, VCLINOM FROM TCLI C INNER JOIN EnqueteClientWeb W ON C.NCLINUM=W.NCLINUM WHERE VSOCIETE = '" & gstrNomSociete & "' order by vclinom"
    
      Screen.MousePointer = vbDefault
    
    End Sub
    */


    /*
  Private Sub cboclient_Click()
    Screen.MousePointer = vbHourglass
    InitFeuille
    Screen.MousePointer = vbDefault
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

    private class donneesGraph
    {
      public string cat { get; set; }
      public decimal val { get; set; }
      public decimal moy { get; set; }
      public donneesGraph() { }
    }

    private void InitFeuille()
    {
      try
      {
        Cursor.Current = Cursors.WaitCursor;

        HideGraph();

        string client = cboclient.GetItemValue();
        if (null == client || "" == client)
        {
          GraphFact.Titles[0].Visibility = DevExpress.Utils.DefaultBoolean.False;
          return;
        }

        int clinum = cboclient.GetItemData();
        List<donneesGraph> listDataSource = new List<donneesGraph>();
        int maxi = 0;

        using (SqlDataReader dr = ModuleData.ExecuteReader($"exec api_sp_StatGraphEvolutionEnquete {clinum}"))
        {
          if (dr.HasRows)
          {
            while (dr.Read())
            {
              Decimal d1 = 0, d2 = 0;
              object val = dr["VAL"];
              if (null != val) d1 = Decimal.Parse(val.ToString().Replace('.', ','));
              val = dr["MOY"];
              if (null != val) d2 = Decimal.Parse(val.ToString().Replace('.', ','));
              listDataSource.Add(new donneesGraph() { cat = dr["CAT"].ToString(), val = d1, moy = d2 });
              if (d1 > maxi) maxi = (int)d1;
            }
          }
          dr.Close();
        }

        // series
        Series serie1 = GraphFact.Series["Series"];
        serie1.DataSource = listDataSource;

        // moyenne
        Series serie2 = GraphFact.Series["Moyenne"];
        serie2.DataSource = listDataSource;

        XYDiagram diagram = GraphFact.Diagram as XYDiagram;
        diagram.AxisX.QualitativeScaleOptions.AutoGrid = false;
        if (maxi <= 10)
          diagram.AxisY.NumericScaleOptions.GridSpacing = 1;
        else
          diagram.AxisY.NumericScaleOptions.GridSpacing = 5;

        ShowGraph();
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

    /*
Private Sub InitFeuille()
Dim Categories, ValuesFact, ValuesMoy
Dim c, trndline
Dim Moy As String

On Error GoTo Handler:


Set ado_rs = New ADODB.Recordset

ado_rs.Open "api_sp_StatGraphEvolutionEnquete " & cboclient.ItemData(cboclient.ListIndex), cnx

If ado_rs.RecordCount > 0 Then
 ' ado_rs.MoveLast
 Categories = ""
 ValuesFact = ""
 ValuesMoy = ""
 Moy = ado_rs("MOY")
' lblMoy.Caption = "Kilométrage moyen par heure de production : " & FormatNumber(Moy, 1)
 While Not ado_rs.EOF
   Categories = Categories & ado_rs("CAT") & Chr(9)
   ValuesFact = ValuesFact & Replace(ado_rs("VAL"), ",", ".") & Chr(9)
   ValuesMoy = ValuesMoy & ado_rs("MOY") & Chr(9)

   ado_rs.MoveNext
 Wend

 ' Remove the leftover tab character at the end of the strings.
 Categories = Left(Categories, Len(Categories) - 1)
 ValuesFact = Left(ValuesFact, Len(ValuesFact) - 1)
 ValuesMoy = Left(ValuesMoy, Len(ValuesMoy) - 1)

 ' Create a chart with one series (called "Sales").
 GraphFact.Clear
 GraphFact.Charts.Add
 GraphFact.Charts(0).SeriesCollection.Add
 'GraphFact.Charts(0).SeriesCollection(0).Caption = "Non satisfaction en %"


 GraphFact.Charts(0).HasTitle = True
 GraphFact.Charts(0).Title.Font.Bold = True
 GraphFact.Charts(0).Title.Font.Size = 15
 GraphFact.Charts(0).Title.Caption = "% de non satisfaction sur le total des sollicitations"

 'Set the series categories and values using the strings created from the recordset.
 Set c = GraphFact.Constants
 GraphFact.Charts(0).SeriesCollection(0).SetData c.chDimCategories, c.chDataLiteral, Categories
 GraphFact.Charts(0).SeriesCollection(0).SetData c.chDimValues, c.chDataLiteral, ValuesFact

   GraphFact.Charts(0).SeriesCollection(0).DataLabelsCollection.Add
   GraphFact.Charts(0).SeriesCollection(0).DataLabelsCollection(0).Font.Color = vbRed
   GraphFact.Charts(0).SeriesCollection(0).DataLabelsCollection(0).Font.Bold = True
'        GraphFact.Charts(0).SeriesCollection(0).DataLabelsCollection(0).Font..Color = vbWhite
   GraphFact.Charts(0).SeriesCollection(0).DataLabelsCollection(0).HasValue = True

 Set trndline = GraphFact.Charts(0).SeriesCollection(0).Trendlines.Add
 trndline.IsDisplayingRSquared = False
 trndline.IsDisplayingEquation = False
 trndline.IsDisplayingEquation = False
 trndline.line.Weight = 3
 trndline.line.Color = RGB(0, 102, 0)
 GraphFact.Charts(0).SeriesCollection(0).Trendlines(0).Caption = "Tendance"

 ' ajout d'une droite de la moyenne
 GraphFact.Charts(0).SeriesCollection.Add
 GraphFact.Charts(0).SeriesCollection(1).Type = chChartTypeLine
 Set c = GraphFact.Constants
 GraphFact.Charts(0).SeriesCollection(1).SetData c.chDimCategories, c.chDataLiteral, Categories
 GraphFact.Charts(0).SeriesCollection(1).SetData c.chDimValues, c.chDataLiteral, ValuesMoy
 GraphFact.Charts(0).SeriesCollection(1).line.Color = vbRed
 GraphFact.Charts(0).SeriesCollection(1).line.Weight = 3



'      GraphFact.Charts(0).SeriesCollection(0).DataLabelsCollection.Add
'      GraphFact.Charts(0).SeriesCollection(0).DataLabelsCollection(0).Font.Color = vbWhite
'      GraphFact.Charts(0).SeriesCollection(0).DataLabelsCollection(0).Font.Bold = True
'      GraphFact.Charts(0).SeriesCollection(0).DataLabelsCollection(0).HasValue = True

 GraphFact.Charts(0).HasLegend = True

  'GraphFact.Charts(0).SeriesCollection(1).DataLabelsCollection(0)

 GraphFact.Charts(0).SeriesCollection(1).Caption = "Moyenne (" + Moy + "%)"
 'GraphFact.Charts(0).SeriesCollection(1)

 ado_rs.Close
Else
 GraphFact.Clear
End If

Exit Sub
Resume
Handler:
Screen.MousePointer = vbDefault
ShowError "InitFeuille dans " & Me.Name
End Sub

Private Sub Form_Unload(Cancel As Integer)
On Error Resume Next
ado_rs.Close
Set ado_rs = Nothing
End Sub

Private Sub cmdQuitter_Click()
Unload Me
End Sub

*/
  }
}

