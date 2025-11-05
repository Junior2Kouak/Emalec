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
  public partial class frmStockStatsTech : Form
  {
    private DataTable dt = new DataTable();

    public frmStockStatsTech()
    {
      InitializeComponent();
    }

    private void frmStockStatsTech_Load(object sender, System.EventArgs e)
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

    //Private Sub Form_Load()

    //On Error GoTo handler:

    //  InitBoutons Me, frmMenu

    //  Chart.width = Screen.width - Chart.Left - 100
    //  Chart.height = Screen.height - Chart.Top - 1400

    //  txtDateA(0) = "01/01/" & DatePart("yyyy", Date)
    //  txtDateA(1) = Date

    //  cmdValider_Click
    //  InitApiTgrid

    //  Screen.MousePointer = vbDefault
    //  Exit Sub
    //  Resume

    //handler:
    //  Screen.MousePointer = vbDefault
    //  ShowError "Form_Load de " & Me.Name
    //End Sub

    private void cmdQuitter_Click(object sender, System.EventArgs e)
    {
      Dispose();
    }
    //Private Sub cmdQuitter_Click()
    //  Unload Me
    //End Sub

    private void cmdDetails_Click(object sender, EventArgs e)
    {
      DataRow row = apiTGrid.GetFocusedDataRow();
      if (null == row)
      {
        return;
      }

      frmStockMouvements frm = new frmStockMouvements()
      {
        mstrType = "COMPTE",
        miCompte = (int)row["COMPTE"]
      };

      frm.ShowDialog();
    }
    //Private Sub cmdDetails_Click()
    //  frmStockMouvements.mstrType = "COMPTE"
    //  frmStockMouvements.miCompte = lRs!COMPTE
    //  frmStockMouvements.Show vbModal
    //End Sub

    private class donneesGraph
    {
      public string VPERNOM { get; set; }
      public Decimal RESTE { get; set; }
      public donneesGraph() { }
    }

    private void UpdateData()
    {
      string sql = $"exec api_sp_Stat_ValorisationStockTeck '{txtDateA0.Text}', '{txtDateA1.Text} 22:00:00'";
      apiTGrid.LoadData(dt, MozartDatabase.cnxMozart, sql);
      apiTGrid.GridControl.DataSource = dt;

      // graphique 
      List<donneesGraph> listDataSource = new List<donneesGraph>();
      Series serie1 = Chart.Series["Serie1"];

      int nb = dt.Rows.Count;
      object val;
      Decimal credit = 0, debit = 0;
      for (int i = 0; i < nb; i++)
      {
        Decimal r = 0;
        string v = "";
        val = dt.Rows[i]["VPERNOM"];
        if (DBNull.Value != val)
          v = val.ToString();
        val = dt.Rows[i]["RESTE"];
        if (DBNull.Value != val)
          r = (Decimal)val;
        val = dt.Rows[i]["ACHAT"];
        if (DBNull.Value != val)
          credit += (Decimal)val;
        val = dt.Rows[i]["VENTE"];
        if (DBNull.Value != val)
          debit += (Decimal)val;
        listDataSource.Add(new donneesGraph() { VPERNOM = v, RESTE = r });
      }

      txtTotCredit.Text = $"{credit:### ### ###}";
      txtTotDebit.Text = $"{debit:### ### ###}";
      txtSolde.Text = $"{(credit - debit):### ### ###}";

      serie1.DataSource = listDataSource;

      XYDiagram diagram = Chart.Diagram as XYDiagram;
      diagram.AxisX.QualitativeScaleOptions.AutoGrid = false;
      diagram.AxisX.Label.ResolveOverlappingOptions.AllowHide = false;
    }

    private void cmdValider_Click(object sender, EventArgs e)
    {
      try
      {
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
    //Private Sub cmdValider_Click()
    //Dim c
    //Dim Values, Categories


    //  ' création d'une commande
    //  Set cmd.ActiveConnection = cnx

    //  ' passage du nom de la procédure stockée
    //  cmd.CommandText = "api_sp_Stat_ValorisationStockTeck"
    //  cmd.CommandType = adCmdStoredProc

    //  ' passage des paramètres
    //  cmd.Parameters.Refresh

    //  ' liste des paramètres
    //  cmd.Parameters("@DateDebut").value = txtDateA(0)
    //  cmd.Parameters("@DateFin").value = txtDateA(1) & " 22:00:00"

    // ' exécuter la commande.
    //  Set lRs = cmd.Execute()

    //  apiTGrid.Init lRs, True

    //   If lRs.EOF Then
    //    Chart.Clear
    //    Screen.MousePointer = vbDefault
    //    Exit Sub
    //  End If

    //  lRs.MoveLast

    //  While Not lRs.BOF
    //    Categories = Categories & lRs.Fields(1).value & Chr(9)
    //    Values = Values & lRs.Fields(5).value & Chr(9)
    //    txtTotCredit = val(txtTotCredit) + lRs.Fields(3).value
    //    txtTotDebit = val(txtTotDebit) + lRs.Fields(4).value
    //    txtSolde = txtTotCredit - txtTotDebit
    //    lRs.MovePrevious
    //  Wend

    //  If lRs.RecordCount > 0 Then
    //    ' Remove the leftover tab character at the end of the strings.
    //    Categories = Left(Categories, Len(Categories) - 1)
    //    Values = Left(Values, Len(Values) - 1)

    //    ' on se replace sur le début de l'enregistrement
    //    lRs.MoveFirst
    //  End If

    //  Chart.Clear
    //  Chart.ChartLayout = chChartLayoutHorizontal
    //  Chart.Charts.Add
    //  Chart.Charts.Item(0).PlotArea.Interior.Color = &H80C0FF
    //  Chart.Charts(0).Type = chChartTypeBarClustered
    //  Chart.Charts.Item(0).Axes.Item(0).NumberFormat = "## ### ##0 "
    //  Chart.Charts(0).SeriesCollection.Add
    //'  Chart.Charts(0).HasTitle = True
    //'  Chart.Charts(0).Title.Font.Bold = True
    //'  Chart.Charts(0).Title.Caption = "Durée des communications (en minutes)"

    //  Chart.Charts(0).SeriesCollection.Add

    //  Set c = Chart.Constants

    //  'Set the series categories and values using the strings created from the recordset.
    //  Chart.Charts(0).SeriesCollection(0).SetData c.chDimCategories, c.chDataLiteral, Categories
    //  ' nombre d'appel
    //'  Chart.Charts(0).SeriesCollection(0).SetData c.chDimValues, c.chDataLiteral, Values
    //  ' durée
    //  Chart.Charts(0).SeriesCollection(0).SetData c.chDimValues, c.chDataLiteral, Values
    //'  ' Create a chart with one series
    //'  Chart.Clear
    //'  Chart.Charts.Add
    //'  Chart.Charts.Item(0).PlotArea.Interior.Color = &HE5C6A0
    //'  Chart.Charts.Item(0).Axes.Item(0).NumberFormat = "## ### ##0 "
    //'  Chart.Charts(0).SeriesCollection.Add
    //'  Chart.Charts(0).SeriesCollection(0).Caption = "Nombre de dépannages par heure"
    //'
    //'  'Set the series categories and values using the strings created from the recordset.
    //'  Set c = Chart.Constants
    //'  Chart.Charts(0).SeriesCollection(0).SetData c.chDimCategories, c.chDataLiteral, Categories
    //'  Chart.Charts(0).SeriesCollection(0).SetData c.chDimValues, c.chDataLiteral, Values
    //'
    //'  Set lRs2 = lRs.NextRecordset
    //'  txtTotCredit = FormatNumber(ZeroIfNull(lRs2!credit), 0)
    //'  txtTotDebit = FormatNumber(ZeroIfNull(lRs2!DEBIT), 0)
    //'
    //'  Set lRs2 = lRs2.NextRecordset
    //'  txtSolde = FormatNumber(ZeroIfNull(lRs2!SOLDE), 0)

    //'  Set lRs2 = cnx.Execute("EXEC api_sp_CommandesEnCours")
    //'  txtEncours = FormatNumber(ZeroIfNull(lRs2!Total), 0)

    //  Screen.MousePointer = vbDefault

    //End Sub

    private void cmdImprimer_Click(object sender, EventArgs e)
    {
      this.ImprimerDansWord();
    }
    //Private Sub cmdImprimer_Click()
    //  ' fonction d'impression écran
    //  Screen.MousePointer = vbHourglass
    //  ImprimerDansWord
    //  Screen.MousePointer = vbDefault
    //End Sub
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

    //Private Sub cmdDate1_Click()
    //On Error GoTo handler
    //  iTextBoxDate = 0
    //  If Calendar1.Visible Then
    //    Calendar1.Visible = False
    //  Else
    //    Calendar1.Visible = True
    //    Calendar1.value = Now
    //  End If
    //  Exit Sub
    //handler:
    //  ShowError "Form_Load dans " & Me.Name
    //End Sub

    //Private Sub cmdDate2_Click()
    //  iTextBoxDate = 1
    //  If Calendar1.Visible Then
    //    Calendar1.Visible = False
    //  Else
    //    Calendar1.Visible = True
    //    Calendar1.value = Now
    //  End If
    //  Exit Sub
    //handler:
    //  ShowError "Form_Load dans " & Me.Name
    //End Sub

    //Private Sub Calendar1_Click()

    //  Me.txtDateA(iTextBoxDate) = Calendar1.value
    //  Calendar1.Visible = False
    //  Exit Sub
    //handler:
    //  ShowError "Form_Load dans " & Me.Name
    //End Sub

    private void InitApiTgrid()
    {
      apiTGrid.AddColumn(Resources.col_Tech, "QUI", 1000);
      apiTGrid.AddColumn(Resources.col_Tech, "NPERNUM", 0);
      apiTGrid.AddColumn(Resources.col_Achat, "ACHAT", 850, "# ##0 €", 1);
      apiTGrid.AddColumn(Resources.col_Vente, "VENTE", 850, "# ##0 €", 1);
      apiTGrid.AddColumn(Resources.col_Reste, "RESTE", 850, "", 2);

      apiTGrid.FilterBar = false;
      apiTGrid.btnExcel.Visible = false;
      apiTGrid.btnPrint.Visible = false;
      apiTGrid.chkColumnsList.Visible = false;
    }
    //Private Sub InitApiTgrid()
    //  apiTGrid.AddColumn "§Tech§", "QUI", 1000
    //  apiTGrid.AddColumn "§Tech§", "NPERNUM", 0
    //  apiTGrid.AddColumn "§Achat§", "ACHAT", 850, "# ##0 €", 1
    //  apiTGrid.AddColumn "§Vente§", "VENTE", 850, "# ##0 €", 1
    //  apiTGrid.AddColumn "§Reste§", "RESTE", 850, , 2

    //  apiTGrid.AddCellTip "QUI", &HFDF0DA            ' Tip = contenu de la cellule entière   ' Vert pale
    //  apiTGrid.FilterBar = False
    //  apiTGrid.Init lRs
    //End Sub
  }
}

