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
  public partial class frmStockStatsCan : Form
  {
    private DataSet ds = new DataSet();

    public string DateA0 { get => txtDateA0.Text; }
    public string DateA1 { get => txtDateA1.Text; }

    public frmStockStatsCan()
    {
      InitializeComponent();
    }

    private void frmStockStatsCan_Load(object sender, System.EventArgs e)
    {
      try
      {
        Cursor.Current = Cursors.WaitCursor;

        ModuleMain.Initboutons(this);

        txtDateA0.Text = $"01/01/{DateTime.Now.Year}";
        txtDateA1.Text = DateTime.Now.ToShortDateString();

        InitApiTgrid();

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

    private void cmdDetails_Click(object sender, EventArgs e)
    {
      DataRow row = apiTGrid.GetFocusedDataRow();
      if (null == row)
      {
        return;
      }
      frmStockMouvements frm = new frmStockMouvements();
      frm.mstrType = "COMPTE";
      frm.miCompte = (int)Utils.ZeroIfNull(row["COMPTE"]);
      frm.mDateDebut = txtDateA0.Text;
      frm.mDateFin = txtDateA1.Text;

      frm.ShowDialog();
    }
    /*
  Option Explicit
    
    Dim cmd As New ADODB.Command
    Dim lRs As New ADODB.Recordset
    Dim lRs2 As New ADODB.Recordset
    ' UPGRADE_INFO (#0501): The 'lRsEncours' member isn't used anywhere in current application.
    ' Dim lRsEncours As New ADODB.Recordset
    
    Dim iTextBoxDate As Integer
    
    Private Sub cmdDetails_Click()
      frmStockMouvements.mstrType = "COMPTE"
      frmStockMouvements.miCompte = lRs!COMPTE
      frmStockMouvements.Show vbModal
    End Sub
    
    Private Sub Form_Load()
        
    On Error GoTo handler:
    
      InitBoutons Me, frmMenu
       
      txtDateA(0) = "01/01/" & DatePart("yyyy", Date)
      txtDateA(1) = Date
         
      cmdValider_Click
      InitApiTgrid
      
      Screen.MousePointer = vbDefault
      Exit Sub
      Resume
      
    handler:
      Screen.MousePointer = vbDefault
      ShowError "Form_Load de " & Me.Name
    End Sub
    */
    private class donneesGraph
    {
      public int COMPTE { get; set; }
      public Decimal solde { get; set; }
      public donneesGraph() { }
    }

    private void UpdateData()
    {
      using (SqlCommand cmd = new SqlCommand($"exec api_sp_Stat_ValorisationStock '{txtDateA0.Text}', '{txtDateA1.Text}'", MozartDatabase.cnxMozart))
      {
        using (SqlDataAdapter da = new SqlDataAdapter(cmd))
        {
          ds.Clear();
          da.Fill(ds);
        }
      }

      apiTGrid.GridControl.DataSource = ds.Tables[0];

      // graphique 
      List<donneesGraph> listDataSource = new List<donneesGraph>();
      Series serie1 = Chart.Series["Serie1"];
      DataTable dt = ds.Tables[0];

      foreach (DataRow row in ds.Tables[0].Rows)
      {
        listDataSource.Add(new donneesGraph()
        {
          COMPTE = (int)Utils.ZeroIfNull(row["COMPTE"]),
          solde = (decimal)(Utils.ZeroIfNull(row["CREDIT"]) + Utils.ZeroIfNull(row["DEBIT"]))
        });
      }

      serie1.DataSource = listDataSource;
      serie1.ArgumentScaleType = ScaleType.Qualitative;

      XYDiagram diagram = Chart.Diagram as XYDiagram;
      diagram.AxisX.WholeRange.SideMarginsValue = 1;
      diagram.AxisX.QualitativeScaleOptions.AutoGrid = false;

      txtTotCredit.Text = Utils.ZeroIfNull(ds.Tables[1].Rows[0]["CREDIT"]).ToString();
      txtTotDebit.Text = Utils.ZeroIfNull(ds.Tables[1].Rows[0]["DEBIT"]).ToString();
      txtSolde.Text = Utils.ZeroIfNull(ds.Tables[2].Rows[0]["Solde"]).ToString();
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
    
    
      ' création d'une commande
      Set cmd.ActiveConnection = cnx
      
      ' passage du nom de la procédure stockée
      cmd.CommandText = "api_sp_Stat_ValorisationStock"
      cmd.CommandType = adCmdStoredProc
      
      ' passage des paramètres
      cmd.Parameters.Refresh
    
      ' liste des paramètres
      cmd.Parameters("@DateDebut").value = txtDateA(0)
      cmd.Parameters("@DateFin").value = txtDateA(1) & " 22:00:00"
    
     ' exécuter la commande.
      Set lRs = cmd.Execute()
      
      apiTGrid.Init lRs, True
     
      While Not lRs.EOF
        If Not IsNull(lRs!CREDIT) Then
          Categories = Categories & lRs.Fields(0).value & Chr(9)
          Values = Values & -lRs.Fields(1).value & Chr(9)
        End If
        lRs.MoveNext
      Wend
       
      If lRs.RecordCount > 0 Then
        ' Remove the leftover tab character at the end of the strings.
        Categories = Left(Categories, Len(Categories) - 1)
        Values = Left(Values, Len(Values) - 1)
      
        ' on se replace sur le début de l'enregistrement
        lRs.MoveFirst
      End If
        
      ' Create a chart with one series
      Chart.Clear
      Chart.Charts.Add
      Chart.Charts.Item(0).PlotArea.Interior.Color = &HE5C6A0
      Chart.Charts.Item(0).Axes.Item(0).NumberFormat = "## ### ##0 "
      Chart.Charts(0).SeriesCollection.Add
      Chart.Charts(0).SeriesCollection(0).Caption = "§Nombre de dépannages par heure§"
    
      'Set the series categories and values using the strings created from the recordset.
      Set c = Chart.Constants
      Chart.Charts(0).SeriesCollection(0).SetData c.chDimCategories, c.chDataLiteral, Categories
      Chart.Charts(0).SeriesCollection(0).SetData c.chDimValues, c.chDataLiteral, Values
      
      Set lRs2 = lRs.NextRecordset
      txtTotCredit = FormatNumber(ZeroIfNull(lRs2!CREDIT), 0)
      txtTotDebit = FormatNumber(ZeroIfNull(lRs2!DEBIT), 0)
    
      Set lRs2 = lRs2.NextRecordset
      txtSolde = FormatNumber(ZeroIfNull(lRs2!SOLDE), 0)
      
    '  Set lRs2 = cnx.Execute("EXEC api_sp_CommandesEnCours")
    '  txtEncours = FormatNumber(ZeroIfNull(lRs2!Total), 0)
      
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

On Error GoTo handler

 iTextBoxDate = 0
 If Calendar1.Visible Then
   Calendar1.Visible = False
 Else
   Calendar1.Visible = True
   Calendar1.value = Now
 End If
 Exit Sub

handler:
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

handler:
 ShowError "Form_Load dans " & Me.Name
End Sub
*/

    /*
    Private Sub Calendar1_Click()

 Me.txtDateA(iTextBoxDate) = Calendar1.value
 Calendar1.Visible = False
 Exit Sub

handler:
 ShowError "Form_Load dans " & Me.Name
End Sub
*/

    private void InitApiTgrid()
    {
      apiTGrid.AddColumn(Resources.col_Compte, "COMPTE", 950, "", 2);
      apiTGrid.AddColumn(Resources.col_credit, "CREDIT", 1000, "# ##0 €", 1);
      apiTGrid.AddColumn(Resources.col_debit, "DEBIT", 1000, "# ##0 €", 1);

      apiTGrid.FilterBar = false;
      apiTGrid.btnExcel.Visible = false;
      apiTGrid.chkColumnsList.Visible = false;
    }
    /*
Private Sub InitApiTgrid()
apiTGrid.AddColumn "§Compte§", "COMPTE", 950, , 2
apiTGrid.AddColumn "§Crédit§", "CREDIT", 1000, "# ##0 €", 1
apiTGrid.AddColumn "§Débit§", "DEBIT", 1000, "# ##0 €", 1
apiTGrid.FilterBar = False
apiTGrid.Init lRs
End Sub


*/
  }
}

