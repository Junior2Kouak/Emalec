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
using MZCtrlResources = MozartControls.Properties.Resources;
using MZUtils = MozartControls.Utils;

namespace MozartCS
{
  public partial class frmStatNonConformite : Form
  {
    //Public sTypeStat As String  'Client ou Chaff
    //  Dim ado_rs As ADODB.Recordset
    public string msTypeStat; //Client ou Chaff
    DataTable dt = new DataTable();

    public frmStatNonConformite()
    {
      InitializeComponent();
    }

    private void frmStatNonConformite_Load(object sender, System.EventArgs e)
    {
      try
      {
        Cursor.Current = Cursors.WaitCursor;
        ModuleMain.Initboutons(this);
        if (msTypeStat == "Client")
        {
          lblTitre.Text = "Actions non-conformes par clients";
          apiTGrid.LoadData(dt, MozartDatabase.cnxMozart, "exec api_sp_StatNonConforme 'Client'");
        }
        else
          apiTGrid.LoadData(dt, MozartDatabase.cnxMozart, "exec api_sp_StatNonConforme 'Chaff'");

        apiTGrid.GridControl.DataSource = dt;
        InitTGrid();
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

    //    Screen.MousePointer = vbHourglass
    //    On Error GoTo handler:
    //    Set ado_rs = New ADODB.Recordset
    //    InitBoutons Me, frmMenu
    //    Set ado_rs = New ADODB.Recordset

    //    If sTypeStat = "Client" Then
    //      lblTitre.Caption = "Actions non-conformes par clients"
    //      ado_rs.Open "exec api_sp_StatNonConforme 'Client'", cnx
    //    Else
    //      lblTitre.Caption = "Actions non-conformes par Chaff"
    //      ado_rs.Open "exec api_sp_StatNonConforme 'Chaff'", cnx
    //    End If

    //    InitTGrid
    //    Screen.MousePointer = vbDefault

    //  Exit Sub
    //  Resume
    //  handler:
    //    Screen.MousePointer = vbDefault
    //    ShowError "Form_Load dans " & Me.Name
    //  End Sub

    private void InitTGrid()
    {
      if (msTypeStat == "Client")
        apiTGrid.AddColumn(MZCtrlResources.col_Client, "Client", 3000);

      apiTGrid.AddColumn(Resources.col_Chaff, "Chaff", 2000);

      if (msTypeStat == "Client")
        apiTGrid.AddColumn(Resources.col_Compte, "Cpt", 1200, "", 2);

      apiTGrid.AddColumn(Resources.col_NbrTotalAction, "NBTOT", 1800, "", 2);
      apiTGrid.AddColumn(Resources.col_ActionsNonConforme, "NBNONCONF", 2500, "", 2);
      apiTGrid.AddColumn(Resources.col_RatioFournituresSurCA, "RATIO", 2600, "0#.00", 2);
      apiTGrid.AddColumn(Resources.col_ValorisationEuroht, "VALO", 1800, "Currency", 1);
      apiTGrid.AddColumn(Resources.col_PourcentSousTraitance, "TAUXSTT", 1500, "0.00", 2);
      apiTGrid.AddColumn(Resources.col_Moyenne, "MOY", 0, "0.00");

      //apiTGrid.AddCellStyle("RATIO", "", &H0, &HFF)

      apiTGrid.InitColumnList();
    }
    //Private Sub InitTGrid()

    //    If sTypeStat = "Client" Then apiTGrid.AddColumn "Client", "CLIENT", 3000
    //    apiTGrid.AddColumn "Chaff", "CHAFF", 2000
    //    If sTypeStat = "Client" Then apiTGrid.AddColumn "Compte", "CPT", 1200, , 2
    //    apiTGrid.AddColumn "Nbr Total action", "NBTOT", 1800, , 2
    //    apiTGrid.AddColumn "Actions non conforme", "NBNONCONF", 2500, , 2
    //    apiTGrid.AddColumn "Ratio non conformité", "RATIO", 2600, "00.00", 2
    //    apiTGrid.AddColumn "Valorisation €ht", "VALO", 1800, "currency", 1
    //    apiTGrid.AddColumn "% Sous traitance", "TAUXSTT", 1500, "00.00", 2
    //    apiTGrid.AddColumn "Moyenne", "MOY", 0

    //    apiTGrid.AddCellStyle "RATIO", "", &H0, &HFF

    //    apiTGrid.Init ado_rs

    //  End Sub

    private void cmdQuitter_Click(object sender, EventArgs e)
    {
      Dispose();
    }
    //Private Sub cmdQuitter_Click()
    //    Unload Me
    //  End Sub

    private void apiTGrid_RowCellStyle(object sender, RowCellStyleEventArgs e)
    {
      // Cols("Ratio Fournitures / CA").CellText(BookMark) & " " & Cols("Moyenne").CellText(BookMark)
      if (e.RowHandle >= 0 && e.Column.Name == "RATIO")
      {
        GridView View = sender as GridView;

        if (Convert.ToDouble(View.GetDataRow(e.RowHandle)["RATIO"]) > Convert.ToDouble(View.GetDataRow(e.RowHandle)["MOY"]))
          e.Appearance.BackColor = Color.LightGreen;
        else
          e.Appearance.BackColor = Color.Pink;

        lblinfo.Text = $"Période : 12 mois glissants\r\nRatio moyen du nombre d’actions non-conformes / nombre total des actions : {Math.Round((decimal)View.GetDataRow(e.RowHandle)["MOY"], 1)}%\r\n Les données sont mises à jour une fois par semaine le dimanche à 12h00";
      }
    }
    //Private Sub apiTGrid_FetchCellStyle(Cols As TrueOleDBGrid80.Columns, BookMark As Variant, col As Integer, DataField As String, CellText As String, CellStyle As TrueOleDBGrid80.StyleDisp)
    //' Gestion spécifique des couleurs

    //  On Error Resume Next

    //  If CDbl(CellText) > CDbl(Cols(col + 3).CellText(BookMark)) Then CellStyle.BackColor = &HC0FFC0
    //  If CDbl(CellText) < CDbl(Cols(col + 3).CellText(BookMark)) Then CellStyle.BackColor = &HC0C0FF

    //  lblinfo.Caption = "Période : 12 derniers mois glissants" & vbCrLf & "Ratio moyen du nombre d’actions non-conformes / nombre total des actions :  " & FormatNumber(Cols(col + 3).CellText(BookMark), 1) & " %"
    //  lblinfo.Caption = lblinfo.Caption & vbCrLf & "Les données sont mises à jour une fois par semaine le dimanche à 12h00"

    //End Sub
  }
}

