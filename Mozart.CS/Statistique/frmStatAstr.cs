using DevExpress.XtraCharts;
using MozartCS.Properties;
using MozartLib;
using MozartNet;
using System;
using System.Data;
using System.Reflection;
using System.Windows.Forms;
using MZUtils = MozartControls.Utils;

namespace MozartCS
{
  public partial class frmStatAstr : Form
  {

    DataTable dt = new DataTable();
    Series series1 = new Series("Graphique 1", ViewType.Bar);

    //  Option Explicit
    //
    //Dim ado_cmd As New ADODB.Command
    //Dim ado_rs As New ADODB.Recordset
    //
    //Dim iTextBoxDate As Integer

    public frmStatAstr() { InitializeComponent(); }

    /* OK --------------------------------------------------------------*/
    private void frmStatAstr_Load(object sender, System.EventArgs e)
    {
      try
      {
        Cursor.Current = Cursors.WaitCursor;
        ModuleMain.Initboutons(this);

        txtDateA0.Text = "01/01/" + DateTime.Now.Year;
        txtDateA1.Text = DateTime.Now.ToShortDateString();

        ChartTitle title = new ChartTitle();
        title.Text = Resources.txt_nbDi_PlageHor;
	    title.TextColor = System.Drawing.Color.Black;
        MSChart1.Titles.Add(title);

        cmdValider_Click(null, null);

        // mise en page du datagrid
        FormatGrid();

      }
      catch (Exception ex)
      {
        MZUtils.displayError(MethodBase.GetCurrentMethod().Name, ex);
      }
      finally { Cursor.Current = Cursors.Default; }
    }

    //Private Sub Form_Load()
    //    
    //On Error GoTo handler:
    //
    //  InitBoutons Me, frmMenu
    //   
    //  txtDateA(0) = "01/01/" & Year(Date)
    //  txtDateA(1) = Date
    //     
    //  cmdValider_Click
    //  
    //  Screen.MousePointer = vbDefault
    //  
    //Exit Sub
    //handler:
    //  Screen.MousePointer = vbDefault
    //  ShowError "Form_Load de " & Me.Name
    //End Sub
    //

    /* OK --------------------------------------------------------------*/
    private void cmdQuitter_Click(object sender, System.EventArgs e)
    {
      Dispose();
    }

    private void cmdValider_Click(object sender, EventArgs e)
    {

      try
      {
        Cursor = Cursors.WaitCursor;

        Label4.Text = txtDateA0.Text;
        Label6.Text = txtDateA1.Text;

        grdDataGrid2.LoadData(dt, MozartDatabase.cnxMozart, $"api_sp_StatASTR '{txtDateA0.Text}','{txtDateA1.Text}'");
        grdDataGrid2.GridControl.DataSource = dt;

        DataRow currentRow = grdDataGrid2.GetFocusedDataRow();
        Label1.Text = Resources.txt_nbTotalActionCrees + Utils.BlankIfNull(currentRow["ActTot"]);

        //si la série contient déjà des colonnes
        if (series1.Points.Count >= 1)
        {
          MSChart1.Series.Remove(series1);
          series1.Points.Clear();
        }

        foreach (DataRow dr in dt.Rows)
          series1.Points.Add(new SeriesPoint(dr["vCreneau"].ToString(), dr["NbACT"].ToString()));

        series1.LegendTextPattern = "{A}";
        MSChart1.Series.Add(series1);
        MSChart1.Legend.Visibility = DevExpress.Utils.DefaultBoolean.False;

        Cursor = Cursors.Default;
      }
      catch (Exception ex)
      {
        MZUtils.displayError(MethodBase.GetCurrentMethod().Name, ex);
      }
    }

    //Private Sub cmdValider_Click()
    //
    //On Error GoTo handler
    //
    //Dim i
    //' UPGRADE_INFO (#0501): The 'nNbDITot' member isn't used anywhere in current application.
    //' Dim nNbDITot As Long
    //  
    //  Screen.MousePointer = vbHourglass
    //
    //  Label4.Caption = txtDateA(0)
    //  Label6.Caption = txtDateA(1)
    //
    //  ' création d'une commande
    //  Set ado_cmd.ActiveConnection = cnx
    //  
    //  ' passage du nom de la procédure stockée
    //  ado_cmd.CommandText = "api_sp_StatASTR"
    //  ado_cmd.CommandType = adCmdStoredProc
    //  
    //  ' passage des paramètres
    //  ado_cmd.Parameters.Refresh
    //
    //  ' liste des paramètres
    //  ado_cmd.Parameters("@DateDebut").value = txtDateA(0)
    //  ado_cmd.Parameters("@DateFin").value = txtDateA(1)
    //
    // ' exécuter la commande.
    //  Set ado_rs = ado_cmd.Execute()
    // 
    //  'affichage dans un tableau
    //   ' liaison du recordset et du datagrid
    //  Set grdDataGrid2.DataSource = ado_rs
    //  
    //  ' mise en page du datagrid
    //  FormatGrid
    // 
    // ' affichage du graphique
    //  MSChart1.RowLabel = "§Nombre de DI/Plage horaire§"
    //  Label1.Caption = "§Nb Total d'actions créées de 19H à 6H : §" & ado_rs("ActTot")
    //  MSChart1.ColumnCount = ado_rs.RecordCount
    //  For i = 1 To ado_rs.RecordCount
    //
    //   MSChart1.Column = i
    //    MSChart1.ColumnLabel = ado_rs("vCreneau")
    //    MSChart1.data = ado_rs("NbACT")
    //    ado_rs.MoveNext
    //
    //  Next i
    //
    //  
    //
    //  Screen.MousePointer = vbDefault
    //  
    //Exit Sub
    //  
    //handler:
    //  ShowError "cmdValider_Click dans " & Me.Name
    //
    //
    //End Sub
    //

    /* OK --------------------------------------------------------------------------------------- */
    private void cmdImprimer_Click(object sender, EventArgs e)
    {
      Cursor = Cursors.WaitCursor;
      this.ImprimerDansWord();
      Cursor = Cursors.Default;
    }

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


    public void FormatGrid()
    {

      try
      {
        grdDataGrid2.AddColumn(Resources.col_plageHoraire, "vCreneau", 1400);
        grdDataGrid2.AddColumn("", "", 0, "", 1);
        grdDataGrid2.AddColumn(Resources.col_nbDI, "NbACT", 1200);
        grdDataGrid2.AddColumn(Resources.col_enpc, "Pourc", 800);
        grdDataGrid2.AddColumn("", "ActTot", 0);

        grdDataGrid2.InitColumnList();
      }
      catch (Exception ex)
      {
        MZUtils.displayError(MethodBase.GetCurrentMethod().Name, ex);
      }
    }
  }
}

