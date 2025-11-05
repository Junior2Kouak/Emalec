using MZCtrlResources = MozartControls.Properties.Resources;
using DevExpress.XtraGrid.Views.Grid;
using MozartCS.Properties;
using MozartLib;
using MozartNet;
using MozartUC;
using System;
using System.Data;
using System.Drawing;
using System.Reflection;
using System.Windows.Forms;
using MZUtils = MozartControls.Utils;

namespace MozartCS
{
  public partial class frmStatFourniture : Form
  {
    //Public sTypeStat As String  'Client ou Chaff
    //Dim ado_rs As ADODB.Recordset
    public string sTypeStat = "";
    DataTable dt = new DataTable();

    public frmStatFourniture()
    {
      InitializeComponent();
    }

    /* OK ---------------------------------------------------------------------*/
    private void frmStatFourniture_Load(object sender, System.EventArgs e)
    {
      try
      {
        Cursor.Current = Cursors.WaitCursor;
        ModuleMain.Initboutons(this);

        if (sTypeStat == "Client")
        {
          lblTitre.Text = "Fournitures vendues par client (€HT)";
          apiTGrid.LoadData(dt, MozartDatabase.cnxMozart, "exec api_sp_StatFourniture 'Client'");
        }
        else
        {
          lblTitre.Text = "Fournitures vendues par CHAFF (€HT) :";
          apiTGrid.LoadData(dt, MozartDatabase.cnxMozart, "exec api_sp_StatFourniture 'Chaff'");
        }

        apiTGrid.GridControl.DataSource = dt;
        InitTGrid();
        Cursor.Current = Cursors.Default;
      }
      catch (Exception ex)
      {
        Cursor.Current = Cursors.Default;
        MZUtils.displayError(MethodBase.GetCurrentMethod().Name, ex);
      }
    }
    //Private Sub Form_Load()

    //On Error GoTo handler

    //  Screen.MousePointer = vbHourglass

    //  Set ado_rs = New ADODB.Recordset

    //  InitBoutons Me, frmMenu
    //  Set ado_rs = New ADODB.Recordset

    //  If sTypeStat = "Client" Then
    //    lblTitre.Caption = "Fournitures vendues par clients (€ht)"
    //    ado_rs.Open "exec api_sp_StatFourniture 'Client'", cnx
    //  Else
    //    lblTitre.Caption = "Fournitures vendues par CHAFF (€ht) :"
    //    ado_rs.Open "exec api_sp_StatFourniture 'Chaff'", cnx
    //  End If

    //  InitTGrid

    //  Screen.MousePointer = vbDefault

    //Exit Sub
    //handler:
    //  Screen.MousePointer = vbDefault
    //  ShowError "Form_Load dans " & Me.Name
    //End Sub

    /* OK ---------------------------------------------------------------------*/
    private void InitTGrid()
    {
      if (sTypeStat == "Client")
        apiTGrid.AddColumn(MZCtrlResources.col_Client, "Client", 200);

      apiTGrid.AddColumn(Resources.col_Chaff, "Chaff", 150);

      if (sTypeStat == "Client")
        apiTGrid.AddColumn(Resources.col_Compte, "cpt", 110, "", 2);

      apiTGrid.AddColumn(Resources.col_CATotal, "CA", 115, "Currency", 1);
      apiTGrid.AddColumn(Resources.col_FournituresFacturées, "MOFO", 170, "Currency", 1);
      apiTGrid.AddColumn(Resources.col_RatioFournituresSurCA, "RATIO", 170, "00.00", 2, true);  // CellStyle
      apiTGrid.AddColumn(Resources.col_Moyenne, "MOY", 0);
      apiTGrid.AddColumn(Resources.col_PourcentSousTraitance, "TAUXSTT", 100, "00.00", 2);

      apiTGrid.InitColumnList();
    }
    //Private Sub InitTGrid()

    //  If sTypeStat = "Client" Then 
    //  apiTGrid.AddColumn "Client", "CLIENT", 3000
    //  apiTGrid.AddColumn "Chaff", "CHAFF", 2200
    //  If sTypeStat = "Client" Then 
    //  apiTGrid.AddColumn "Compte", "CPT", 1200, , 2
    //  apiTGrid.AddColumn "CA total", "CA", 1700, "Currency", 1
    //  apiTGrid.AddColumn "Fournitures facturées", "MOFO", 2500, "Currency", 1
    //  apiTGrid.AddColumn "Ratio Fournitures / CA", "RATIO", 2600, "00.00", 2
    //  apiTGrid.AddColumn "Moyenne", "MOY", 0
    //  apiTGrid.AddColumn "% Sous traitance", "TAUXSTT", 1500, "00.00", 2

    //  apiTGrid.AddCellStyle "RATIO", "", &H0, &HFF

    //  apiTGrid.Init ado_rs

    //End Sub

    /* OK ---------------------------------------------------------------------*/
    private void cmdQuitter_Click(object sender, EventArgs e)
    {
      Dispose();
    }

    //Private Sub cmdQuitter_Click()
    //  Unload Me
    //End Sub

    /* OK ---------------------------------------------------------------------*/
    private void apiTGrid_RowCellStyle(object sender, RowCellStyleEventArgs e)
    {
      // Cols("Ratio Fournitures / CA").CellText(BookMark) & " " & Cols("Moyenne").CellText(BookMark)
      GridView View = sender as GridView;
      if (e.RowHandle >= 0 && e.Column.Name == "RATIO")
      {
        if (Convert.ToDouble(View.GetDataRow(e.RowHandle)["RATIO"]) > Convert.ToDouble(View.GetDataRow(e.RowHandle)["MOY"]))
          e.Appearance.BackColor = Color.LightGreen;
        else
          e.Appearance.BackColor = Color.Pink;

        if (e.RowHandle == 0 && e.Column.Name == "RATIO")
          lblinfo.Text = $"Période : 12 mois glissants\r\nRatio moyen Fournitures / Chiffre d'affaires : {Math.Round((decimal)View.GetDataRow(e.RowHandle)["MOY"], 1)}%";
      }
    }

    //Private Sub apiTGrid_FetchCellStyle(Cols As TrueOleDBGrid80.Columns, BookMark As Variant, col As Integer, DataField As String, CellText As String, CellStyle As TrueOleDBGrid80.StyleDisp)
    // ' Gestion spécifique des couleurs
    //   On Error Resume Next
    //   If CDbl(CellText) > CDbl(Cols(col + 1).CellText(BookMark)) Then CellStyle.BackColor = &HC0FFC0
    //   If CDbl(CellText) < CDbl(Cols(col + 1).CellText(BookMark)) Then CellStyle.BackColor = &HC0C0FF
    //   lblinfo.Caption = "Période : 12 mois glissants" & vbCrLf & "Ratio moyen Fournitures / Chiffre d'affaire :  " & FormatNumber(Cols(col + 1).CellText(BookMark), 1) & "%"
    // End Sub
  }
}
