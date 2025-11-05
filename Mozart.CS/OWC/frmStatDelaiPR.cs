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
  public partial class frmStatDelaiPR : Form
  {
    private DataTable dt = new DataTable();

    public frmStatDelaiPR()
    {
      InitializeComponent();
    }

    private void frmStatDelaiPR_Load(object sender, System.EventArgs e)
    {
      try
      {
        Cursor.Current = Cursors.WaitCursor;

        ModuleMain.Initboutons(this);

        txtDateA0.Text = DateTime.Now.AddYears(-1).ToShortDateString();
        txtDateA1.Text = DateTime.Now.ToShortDateString();

        cboclient.Visible = false;
        cmdModifier.Visible = false;
        lblLabels12.Visible = false;

        FormatGrid();

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
      public int duree { get; set; }
      public int PC { get; set; }
      public int NB { get; set; }
      public donneesGraph() { }
    }

    private void UpdateData()
    {
      string sql = $"exec api_sp_StatDelaiPR '{txtDateA0.Text}', '{txtDateA1.Text}'";
      grdDataGrid2.LoadData(dt, MozartDatabase.cnxMozart, sql);
      grdDataGrid2.GridControl.DataSource = dt;

      // graphique 
      List<donneesGraph> listDataSource = new List<donneesGraph>();
      Series serie1 = Chart.Series["Serie1"];

      int nb = dt.Rows.Count;

      if (0 == dt.Rows.Count)
      {
        Label1.Text = Resources.txt_total_interventions;
        Label2.Text = Resources.txt_delai_intervention;
        serie1.DataSource = listDataSource;
        return;
      }

      int moyenne = 0, total = 0;
      foreach (DataRow row in dt.Rows)
      {
        int d = 0, n = 0, p = 0;
        d = (int)Utils.ZeroIfNull(row["duree"]);
        n = (int)Utils.ZeroIfNull(row["NB"]);
        p = (int)Utils.ZeroIfNull(row["PC"]);

        listDataSource.Add(new donneesGraph() { duree = d, PC = p, NB = n });

        moyenne = moyenne + n * d;
        total = total + n;
      }

      Label1.Text = $"{Resources.txt_total_interventions}  {total:# ###}";
      Label2.Text = $"{Resources.txt_delai_intervention} {(double)moyenne / (double)total:0.00}";

      serie1.DataSource = listDataSource;
      serie1.ArgumentScaleType = ScaleType.Qualitative;

      XYDiagram diagram = Chart.Diagram as XYDiagram;
      diagram.AxisX.WholeRange.SideMarginsValue = 1;
      diagram.AxisX.QualitativeScaleOptions.AutoGrid = false;
    }

    /*
  Option Explicit
    
    Dim ado_rs As New ADODB.Recordset
    Dim ado_cmd As New ADODB.Command
    
    Dim iTextBoxDate As Integer
    
    Private Sub Form_Load()
      
      InitBoutons Me, frmMenu
      
      txtDateA(0) = (Date - 365) '365 pour mettre les 12 derniers mois
      txtDateA(1) = Date
    
      cboclient.Visible = False
      cmdModifier.Visible = False
      lblLabels(12).Visible = False
      
      cmdValider_Click
    
    End Sub
    */

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
    /*
    Private Sub cmdValider_Click()
    
    ' UPGRADE_INFO (#0501): The 'i' member isn't used anywhere in current application.
    ' Dim i As Integer
    Dim Values, Categories
    Dim c
    Dim lTotal As Long
    Dim lMoyenne As Long
    
    On Error GoTo Handler:
      
      Screen.MousePointer = vbHourglass
      
      If cnxRep.State = adStateOpen Then cnxRep.Close
      
      ' ouverture connexion
      'cnxRep.Open gstrConnexionStringReplique
      
      ' TB SAMSIC CITY BASE
      cnxRep.Open gstrConnexion
      ' cnxRep.Open "PROVIDER=SQLOLEDB.1;Initial Catalog=MULTI;Data Source=" & gstrNomServeur & ";trusted_connection=yes;App=" & gstrNomSociete & ";"
      cnxRep.CommandTimeout = 150
    
      ' création d'une commande
      Set ado_cmd.ActiveConnection = cnxRep
      
      ' passage du nom de la procédure stockée
      ado_cmd.CommandText = "api_sp_StatDelaiPR"
      ado_cmd.CommandType = adCmdStoredProc
      
      ' passage des paramètres
      ado_cmd.Parameters.Refresh
    
      ' liste des paramètres
      ado_cmd.Parameters("@DateDebut").value = txtDateA(0)
      ado_cmd.Parameters("@DateFin").value = txtDateA(1)
    
      ' exécuter la commande.
      Set ado_rs = ado_cmd.Execute()
      
      
      If ado_rs.EOF Then
          Screen.MousePointer = vbDefault
          lMoyenne = 0: lTotal = 0
          Label1.Caption = "§Nombre total d'interventions :   §"
          Label2.Caption = "§Délai moyen d'intervention :   §"
    
          Chart.Clear
          Chart.Charts.Add
          Chart.Charts.Item(0).PlotArea.Interior.Color = &H80C0FF
          Chart.Charts.Item(0).Axes.Item(0).NumberFormat = "0#"
          Chart.Charts(0).SeriesCollection.Add
          Chart.Charts(0).SeriesCollection(0).Caption = "§CA par chargé d'affaires§"
          
          
          ' liaison du recordset et du datagrid
          Set grdDataGrid2.DataSource = ado_rs
          ' mise en page du datagrid
          FormatGrid
          Exit Sub
      End If
      
      ' liaison du recordset et du datagrid
      Set grdDataGrid2.DataSource = ado_rs
      
      ' mise en page du datagrid
      FormatGrid
        
      ado_rs.MoveFirst
      
      lMoyenne = 0: lTotal = 0
      While Not ado_rs.EOF
        Categories = Categories & ado_rs.Fields(0).value & Chr(9)
        Values = Values & ado_rs.Fields(1).value & Chr(9)
        lMoyenne = lMoyenne + ado_rs(1) * ado_rs(0)
        lTotal = lTotal + ado_rs.Fields(2).value
        ado_rs.MoveNext
      Wend
     
      
      Label1.Caption = "Nombre total d'interventions :   " & Format(lTotal, " # ###")
      Label2.Caption = "Délai moyen d'intervention :   " & Format(lMoyenne / lTotal, " 0.00")
      
      
      ' Remove the leftover tab character at the end of the strings.
      Categories = Left(Categories, Len(Categories) - 1)
      Values = Left(Values, Len(Values) - 1)
    
      ' on se replace sur le début de l'enregistrement
      ado_rs.MoveFirst
        
      ' Create a chart with one series
      Chart.Clear
      Chart.Charts.Add
      Chart.Charts.Item(0).PlotArea.Interior.Color = &H80C0FF
      Chart.Charts.Item(0).Axes.Item(0).NumberFormat = "0#"
      Chart.Charts(0).SeriesCollection.Add
    
      'Set the series categories and values using the strings created from the recordset.
      Set c = Chart.Constants
      Chart.Charts(0).SeriesCollection(0).SetData c.chDimCategories, c.chDataLiteral, Categories
      Chart.Charts(0).SeriesCollection(0).SetData c.chDimValues, c.chDataLiteral, Values
      Screen.MousePointer = vbDefault
      
    Exit Sub
      
    Handler:
      Screen.MousePointer = vbDefault
      ShowError "Form_Load de " & Me.Name
    End Sub
    */

    private void cmdModifier_Click(object sender, EventArgs e)
    {
      DataRow row = grdDataGrid2.GetFocusedDataRow();
      if (null == row)
        return;

      frmListeDIDelais frm = new frmListeDIDelais();

      frm.miDelais = int.Parse(row["duree"].ToString());

      frm.ShowDialog();
    }
    /*
  Private Sub cmdModifier_Click()
    frmListeDIDelais.miDelais = ado_rs(0)
    frmListeDIDelais.Show vbModal
  End Sub
  */

    private void FormatGrid()
    {
      grdDataGrid2.AddColumn(Resources.txt_delai_j, "duree", 1100);
      grdDataGrid2.AddColumn(Resources.txt_nb_demande, "PC", 1100);
      grdDataGrid2.AddColumn(Resources.txt_nb_demande, "NB", 1100, "", 2);

      grdDataGrid2.FilterBar = false;
      grdDataGrid2.btnExcel.Visible = false;
      grdDataGrid2.btnPrint.Visible = false;
      grdDataGrid2.chkColumnsList.Visible = false;
    }
    /*
  Public Sub FormatGrid()

  On Error GoTo Handler

    grdDataGrid2.Columns(0).Caption = "§Délais(j)§"
    grdDataGrid2.Columns(1).Caption = "§NB demande§"
    grdDataGrid2.Columns(2).Caption = "§NB demande§"

    grdDataGrid2.Columns(0).width = 1100
    grdDataGrid2.Columns(1).width = 0
    grdDataGrid2.Columns(2).width = 1400

    grdDataGrid2.Columns(2).Alignment = dbgCenter

  Exit Sub
  Handler:
    ShowError "FormatGrid dans " & Me.Name
  End Sub

  Private Sub cmdQuitter_Click()
      Unload Me
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

    DateTime _curDate = DateTime.MinValue;
    private void CmdDate_Click(object sender, EventArgs e)
    {
      Button btn = sender as Button;
      Calendar1.Tag = btn.Tag;

      string txtDate = "";
      if ((sender as Button).Name == "cmdDate1")
      {
        txtDate = txtDateA0.Text;
        Calendar1.Tag = 0;
      }
      else
      {
        txtDate = txtDateA1.Text;
        Calendar1.Tag = 1;
      }
      DateTime d;
      if (DateTime.TryParse(txtDate, out d))
        _curDate = Calendar1.Value = d;
      else { _curDate = DateTime.MinValue; Calendar1.Value = DateTime.Now; }

      Calendar1.Visible = true;
      Calendar1.ShowCalendar(new MouseEventArgs(MouseButtons.Left, 1, MousePosition.X - this.Location.X, MousePosition.Y - this.Location.Y, 0));
    }
    private void Calendar1_CloseUp(object sender, EventArgs e)
    {
      Calendar1.Visible = false;
      if (_curDate == DateTime.MinValue) return;
      if ((int)Calendar1.Tag == 0) txtDateA0.Text = Calendar1.Value.ToShortDateString();
      else if ((int)Calendar1.Tag == 1) txtDateA1.Text = Calendar1.Value.ToShortDateString();
    }
    private void Calendar1_ValueChanged(object sender, EventArgs e)
    {
      if (Calendar1.Visible) _curDate = Calendar1.Value;
    }

    /*
  Private Sub cmdDate1_Click()

  On Error GoTo Handler

    iTextBoxDate = 0
    If Calendar1.Visible Then
        Calendar1.Visible = False
    Else
        Calendar1.ZOrder 0
        Calendar1.Visible = True
        Calendar1.value = Now
    End If
    Exit Sub

  Handler:
    ShowError "Form_Load dans " & Me.Name
  End Sub
    */

    /*
Private Sub cmdDate2_Click()

iTextBoxDate = 1
If Calendar1.Visible Then
   Calendar1.Visible = False
Else
   Calendar1.ZOrder 0
   Calendar1.Visible = True
   Calendar1.value = Now
End If
Exit Sub

Handler:
ShowError "Form_Load dans " & Me.Name
End Sub
*/

    /*
    Private Sub Calendar1_Click()

Me.txtDateA(iTextBoxDate) = Calendar1.value
Calendar1.Visible = False
Exit Sub

Handler:
ShowError "Form_Load dans " & Me.Name
End Sub

Private Sub Form_Unload(Cancel As Integer)
If cnxRep.State = adStateOpen Then cnxRep.Close
End Sub

*/
  }
}

