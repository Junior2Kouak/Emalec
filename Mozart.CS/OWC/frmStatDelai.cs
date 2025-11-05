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
  public partial class frmStatDelais : Form
  {
    public string mstrStatut;

    private DataTable dt = new DataTable();

    public frmStatDelais()
    {
      InitializeComponent();
    }

    private void frmStatDelais_Load(object sender, System.EventArgs e)
    {
      try
      {
        Cursor.Current = Cursors.WaitCursor;

        ModuleMain.Initboutons(this);

        DateTime dateTmp = DateTime.Now;
        txtDateA0.Text = (dateTmp.AddYears(-1)).AddDays(-dateTmp.Day + 1).ToShortDateString();
        txtDateA1.Text = dateTmp.AddDays(-dateTmp.Day).ToShortDateString();

        if (mstrStatut == "ParClient")
        {
          cboclient.Init(MozartDatabase.cnxMozart, "select * from api_v_comboClient order by VCLINOM", "NCLINUM", "VCLINOM", new List<string>() { Resources.col_Nom }, 500, 500);
          cboclient.SetText("KIABI");
          cboclient.Visible = true;
        }
        else
        {
          cmdModifier.Visible = false;
          cboclient.Visible = false;
          lblLabels12.Visible = false;
          if (mstrStatut == "TousClient")
          {
            Label3.Text = "Objectif Qualité mensuel : 1,8 jours ";
          }
        }

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

    /*
  Option Explicit
    
    Public mstrStatut As String
    
    
    Dim ado_rs As New ADODB.Recordset
    Dim ado_cmd As New ADODB.Command
    
    Dim iTextBoxDate As Integer
    
     
    
    Private Sub Form_Load()
      
      InitBoutons Me, frmMenu
      
      txtDateA(0) = DateAdd("yyyy", -1, DateAdd("d", -(Day(Date) - 1), Date))
      txtDateA(1) = DateAdd("d", -(Day(Date)), Date)
      'txtDateA(0) = (Date - 365)
      'txtDateA(1) = Date
    
      ' combo des clients
      If mstrStatut = "ParClient" Then
        cboclient.SizeCombo 600
        RemplirComboClient cboclient
        cboclient.Visible = True
        cboclient.Text = "KIABI"
      Else
        cboclient.Visible = False
        cmdModifier.Visible = False
        lblLabels(12).Visible = False
        If mstrStatut = "TousClient" Then Label3.Caption = "Objectif Qualité mensuel : 1,8 jours "
      End If
      
      cmdValider_Click
    
    End Sub
*/

    private class donneesGraph
    {
      public int delai { get; set; }
      public int nb { get; set; }
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
      int client = cboclient.GetItemData();
      if (-1 == client) client = 0;
      string sql = $"exec api_sp_StatDureeTraitement {client}, '{txtDateA0.Text}', '{txtDateA1.Text}'";
      grdDataGrid2.LoadData(dt, MozartDatabase.cnxMozart, sql);
      grdDataGrid2.GridControl.DataSource = dt;

      // graphique 
      HideGraph();
      List<donneesGraph> listDataSource = new List<donneesGraph>();
      int nb = dt.Rows.Count;
      if (0 == nb)
      {
        return;
      }
      int moyenne = 0, total = 0;
      foreach (DataRow row in dt.Rows)
      {
        int d = 0, n = 0, c = 0;
        c = (int)Utils.ZeroIfNull(row["PC"]);
        d = (int)Utils.ZeroIfNull(row["duree"]);
        n = (int)Utils.ZeroIfNull(row["NB"]);

        listDataSource.Add(new donneesGraph() { delai = d, nb = c });

        moyenne = moyenne + c * d;
        total = total + n;
      }

      Label1.Text = $"{Resources.txt_total_interventions} {total:# ###}";
      Label2.Text = $"{Resources.txt_delai_intervention} {moyenne / total:0.00}";

      Series serie1 = Chart.Series["Serie1"];
      serie1.DataSource = listDataSource;

      serie1.ArgumentScaleType = ScaleType.Qualitative;

      XYDiagram diagram = Chart.Diagram as XYDiagram;
      diagram.AxisX.WholeRange.SideMarginsValue = 1;
      diagram.AxisX.QualitativeScaleOptions.AutoGrid = false;

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
      ado_cmd.CommandText = "api_sp_StatDureeTraitement"
      ado_cmd.CommandType = adCmdStoredProc
      
      ' passage des paramètres
      ado_cmd.Parameters.Refresh
    
      ' liste des paramètres
      ado_cmd.Parameters("@Client").value = cboclient.ItemData(cboclient.ListIndex)
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
      Chart.Charts(0).SeriesCollection(0).Caption = "§CA par chargé d'affaires§"
    
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

      int client = cboclient.GetItemData();
      if (-1 == client) client = 0;

      new frmListeDIDelais()
      {
        miDelais = int.Parse(row["duree"].ToString()),
        mDateDebut = txtDateA0.Text,
        mDateFin = txtDateA1.Text,
        mClient = client
      }.ShowDialog();
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
      //grdDataGrid2.AddColumn("§taux§", "PC", 0);
      grdDataGrid2.AddColumn(Resources.txt_nb_demande, "NB", 1100, "", 2);
      //grdDataGrid2.AddColumn("NCLINUM", "NCLINUM", 0);

      grdDataGrid2.btnExcel.Visible = false;
      grdDataGrid2.btnPrint.Visible = false;
      grdDataGrid2.chkColumnsList.Visible = false;

      grdDataGrid2.FilterBar = false;
    }
    /*
    Public Sub FormatGrid()
      
    On Error GoTo Handler
    
      grdDataGrid2.Columns(0).Caption = "§Délais(j)§"
      grdDataGrid2.Columns(1).Caption = "§taux§"
      grdDataGrid2.Columns(2).Caption = "§NB demande§"
      grdDataGrid2.Columns(3).Caption = "NCLINUM"
      
      grdDataGrid2.Columns(0).width = 1100
      grdDataGrid2.Columns(1).width = 0
      grdDataGrid2.Columns(2).width = 1400
      grdDataGrid2.Columns(3).width = 0
      
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
Calendar1.Visible = True
Calendar1.value = Now
End If
Exit Sub

Handler:
ShowError "Form_Load dans " & Me.Name
End Sub

Private Sub cmdDate2_Click()

iTextBoxDate = 1
If Calendar1.Visible Then
Calendar1.Visible = False
Else
Calendar1.Visible = True
Calendar1.value = Now
End If
Exit Sub

Handler:
ShowError "Form_Load dans " & Me.Name
End Sub

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

