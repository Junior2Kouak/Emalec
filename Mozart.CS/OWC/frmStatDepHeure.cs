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
  public partial class frmStatDepHeureJour : Form
  {
    public string mstrTypeStat;

    private DataTable dt = new DataTable();

    public frmStatDepHeureJour()
    {
      InitializeComponent();
    }

    private void frmStatDepHeureJour_Load(object sender, System.EventArgs e)
    {
      try
      {
        Cursor.Current = Cursors.WaitCursor;

        ModuleMain.Initboutons(this);

        DateTime jour = DateTime.Now;
        txtDateA0.Text = jour.AddYears(-1).AddDays(-jour.Day + 1).ToShortDateString();
        txtDateA1.Text = jour.AddDays(-jour.Day).ToShortDateString();

        Label7.Text = $"{Label7.Text}{mstrTypeStat}";

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
    Dim ado_cmd As New ADODB.Command
    Dim ado_rs As New ADODB.Recordset
    Public mstrTypeStat As String
    
    
    Private Sub Form_Load()
    On Error GoTo Handler:
    
      InitBoutons Me, frmMenu
      txtDateA(0) = DateAdd("yyyy", -1, DateAdd("d", -(Day(Date) - 1), Date))
      txtDateA(1) = DateAdd("d", -(Day(Date)), Date)
      'txtDateA(0) = "01/01/" & CStr(Year(Now))
      'txtDateA(1) = Date
      
      Label7 = Label7 & mstrTypeStat
         
      If cnxRep.State = adStateOpen Then cnxRep.Close
      
      ' ouverture connexion
      'cnxRep.Open gstrConnexionStringReplique
      ' TB SAMSIC CITY BASE
      cnxRep.Open gstrConnexion
      ' cnxRep.Open "PROVIDER=SQLOLEDB.1;Initial Catalog=MULTI;Data Source=" & gstrNomServeur & ";trusted_connection=yes;App=" & gstrNomSociete & ";"
      cnxRep.CommandTimeout = 150
       
      cmdValider_Click
      
      Screen.MousePointer = vbDefault
      Exit Sub
      
    Handler:
      Screen.MousePointer = vbDefault
      ShowError "Form_Load de " & Me.Name
    End Sub
    */

    private class donneesGraph
    {
      public string jourheure { get; set; }
      public int NB { get; set; }
      public donneesGraph() { }
    }

    private void UpdateData()
    {
      Label4.Text = txtDateA0.Text;
      Label6.Text = txtDateA1.Text;

      List<donneesGraph> listDataSource = new List<donneesGraph>();
      Series serie1 = Chart.Series["Serie1"];

      using (SqlCommand cmd = new SqlCommand($"api_sp_StatDepannagePar{mstrTypeStat}", MozartDatabase.cnxMozart))
      {
        cmd.CommandType = CommandType.StoredProcedure;
        SqlCommandBuilder.DeriveParameters(cmd);

        cmd.Parameters["@DateDebut"].Value = txtDateA0.Text;
        cmd.Parameters["@DateFin"].Value = txtDateA1.Text;

        using (SqlDataReader dr = cmd.ExecuteReader())
        {
          while (dr.Read())
          {
            listDataSource.Add(new donneesGraph() { jourheure = Utils.BlankIfNull(dr[0]), NB = (int)Utils.ZeroIfNull(dr[1]) });
          }
        }
      }

      serie1.DataSource = listDataSource;

      XYDiagram diagram = Chart.Diagram as XYDiagram;

      if (mstrTypeStat == "Jour")
        diagram.AxisX.Title.Text = Resources.txt_Jours;
      else
        diagram.AxisX.Title.Text = Resources.txt_Heures;
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
    Dim i, c
    Dim Values, Categories
    
    
    On Error GoTo Handler:
    
      Label4.Caption = txtDateA(0)
      Label6.Caption = txtDateA(1)
    
      Set ado_cmd.ActiveConnection = cnxRep
      ado_cmd.CommandText = "api_sp_StatDepannagePar" & mstrTypeStat
      ado_cmd.CommandType = adCmdStoredProc
      ado_cmd.Parameters.Refresh
    
      ' liste des paramètres
      ado_cmd.Parameters("@DateDebut").value = txtDateA(0)
      ado_cmd.Parameters("@DateFin").value = txtDateA(1)
    
      Set ado_rs = ado_cmd.Execute()
     
      While Not ado_rs.EOF
        Categories = Categories & ado_rs.Fields(0).value & Chr(9)
        Values = Values & ado_rs.Fields(1).value & Chr(9)
        ado_rs.MoveNext
      Wend
       
      ' Remove the leftover tab character at the end of the strings.
      Categories = Left(Categories, Len(Categories) - 1)
      Values = Left(Values, Len(Values) - 1)
    
      ' on se replace sur le début de l'enregistrement
      ado_rs.MoveFirst
        
      ' Create a chart with one series
      Chart.Clear
      Chart.Charts.Add
      Chart.Charts.Item(0).PlotArea.Interior.Color = &H80C0FF
      Chart.Charts.Item(0).Axes.Item(0).NumberFormat = "## ### ##0 "
      Chart.Charts(0).SeriesCollection.Add
      Chart.Charts(0).Axes(1).HasTitle = True
      Chart.Charts(0).Axes(1).Title.Caption = mstrTypeStat & "s"
      Chart.Charts(0).Axes(1).Title.Font.Size = 8
      Chart.Charts(0).Axes(1).Title.Font.Bold = True
      Chart.Charts(0).Axes(1).Title.Font.Color = vbBlue
    
      'Set the series categories and values using the strings created from the recordset.
      Set c = Chart.Constants
      Chart.Charts(0).SeriesCollection(0).SetData c.chDimCategories, c.chDataLiteral, Categories
      Chart.Charts(0).SeriesCollection(0).SetData c.chDimValues, c.chDataLiteral, Values
      Screen.MousePointer = vbDefault
    
    Exit Sub
    Resume
    Handler:
      If Err.Number = -2147467259 Then
        cnxRep.Close
        'cnxRep.Open gstrConnexionStringReplique
        
        ' TB SAMSIC CITY BASE
        cnxRep.Open gstrConnexion
        ' cnxRep.Open "PROVIDER=SQLOLEDB.1;Initial Catalog=MULTI;Data Source=" & gstrNomServeur & ";trusted_connection=yes;App=" & gstrNomSociete & ";"
        cnxRep.CommandTimeout = 150
        cmdValider_Click
      Else
        Screen.MousePointer = vbDefault
        ShowError "cmdValider_Click dans " & Me.Name
      End If
    End Sub
    */

    private void cmdImprimer_Click(object sender, EventArgs e)
    {
      this.ImprimerDansWord();
    }
    /*
    Private Sub cmdImprimer_Click()     ' fonction d'impression écran
      Screen.MousePointer = vbHourglass
      ImprimerDansWord
      Screen.MousePointer = vbDefault
    End Sub
    
    Private Sub cmdQuitter_Click()
      Unload Me
    End Sub
    */
    DateTime _curDate = DateTime.MinValue;
    private void CmdDate_Click(object sender, EventArgs e)
    {
      Button btn = sender as Button;
      Calendar1.Tag = btn.Tag;

      string txtDate = "";
      if ((sender as Button).Name == "cmdDate0")
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
    Private Sub cmdDate_Click(Index As Integer)
      Calendar1.Visible = Not Calendar1.Visible
      Calendar1.value = txtDateA(Index)
      Calendar1.Tag = Index
    End Sub
    
    Private Sub Calendar1_Click()
      Me.txtDateA(Calendar1.Tag) = Calendar1.value
      Calendar1.Visible = False
    End Sub
    
    Private Sub Form_Unload(Cancel As Integer)
      If cnxRep.State = adStateOpen Then cnxRep.Close
    End Sub

  */
  }
}

