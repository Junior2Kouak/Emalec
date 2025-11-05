using DevExpress.XtraGrid.Views.Grid;
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
  public partial class frmGammeSelect : Form
  {
    //Dim oNGAMNUM As Long
    //Dim oNCLINUM As Long
    //Dim oNSITNUM As Long
    //Dim adoRS As ADODB.Recordset

    public int mloNGAMNUM;
    public int mloNCLINUM;
    public int mloNSITNUM;

    DataTable dt = new DataTable();

    public frmGammeSelect()
    {
      InitializeComponent();
    }

    //Private Sub Form_Load()
    //On Error GoTo handler
    //    Dim sSql  As String
    //  InitBoutons Me, frmMenu
    //  sSql = "api_sp_ComboGammeSelect " & oNCLINUM & " , " & oNSITNUM & ", " & oNGAMNUM
    //  Set adoRS = New Recordset
    //  adoRS.Open sSql, cnx, adOpenStatic, adLockOptimistic
    //  InitApigrid
    //  Screen.MousePointer = vbDefault
    //Exit Sub
    //handler:
    //  Screen.MousePointer = vbDefault
    //  ShowError "Form_load dans " & Me.Name
    //End Sub

    private void frmGammeSelect_Load(object sender, System.EventArgs e)
    {
      try
      {
        Cursor.Current = Cursors.WaitCursor;
        ModuleMain.Initboutons(this);

        apiTGridGamme.LoadData(dt, MozartDatabase.cnxMozart, $"api_sp_ComboGammeSelect {mloNCLINUM} , {mloNSITNUM}, {mloNGAMNUM}");
        apiTGridGamme.GridControl.DataSource = dt;

        InitApigrid();
      }
      catch (Exception ex)
      {
        MZUtils.displayError(MethodBase.GetCurrentMethod().Name, ex);
      }
      finally { Cursor.Current = Cursors.Default; }
    }

    //Private Sub InitApigrid()
    //On Error GoTo handler
    //  apiTGridGamme.AddColumn "§Nom§", "NTRACLINUM", 0
    //  apiTGridGamme.AddColumn "N° gamme client", "NGAMCLI", 2200
    //  apiTGridGamme.AddColumn "N° gamme " & gstrNomSociete, "NGAMTRAMENUM", 0
    //  apiTGridGamme.AddColumn "Pays", "VPAYSNOM", 1700
    //  apiTGridGamme.AddColumn "Titre", "VGAMTITRE", 5500
    //  apiTGridGamme.AddColumn "COLOR", "COLOR", 0
    //  apiTGridGamme.AddRowStyle "COLOR", "COLOR", "G", , &H80FF80
    //  apiTGridGamme.BtnPrintVisible = False
    //  apiTGridGamme.Init adoRS
    //Exit Sub
    //handler:
    //  ShowError "InitApigrid dans " & Me.Name
    //End Sub

    private void InitApigrid()
    {
      apiTGridGamme.AddColumn(Resources.col_Nom, "NTRACLINUM", 0);
      apiTGridGamme.AddColumn(Resources.col_NumGammeClient, "NGAMCLI", 2200);
      apiTGridGamme.AddColumn(Resources.col_NumGamme, "NGAMTRAMENUM", 0);
      apiTGridGamme.AddColumn(Resources.col_Pays, "VPAYSNOM", 1700);
      apiTGridGamme.AddColumn(Resources.col_Titre, "VGAMTITRE", 5500);
      apiTGridGamme.AddColumn(Resources.col_COLOR, "COLOR", 0);

      // RowStyle est géré par l'évènement ci dessous
      //apiTGridGamme.AddRowStyle("COLOR", "COLOR", "G", , &H80FF80);

      apiTGridGamme.btnPrint.Visible = false;
      apiTGridGamme.InitColumnList();
    }

    private void apiTGridGamme_RowStyle(object sender, RowStyleEventArgs e)
    {
      GridView View = sender as GridView;
      if (e.RowHandle >= 0)
      {
        if (View.GetDataRow(e.RowHandle)["COLOR"].ToString().ToUpper() == "G")
        {
          e.Appearance.BackColor = lblColorGamme.BackColor;
          e.HighPriority = true;
        }
      }
    }

    //Private Sub apiTGridGamme_DblClick()
    //    If adoRS.RecordCount = 0 Then Exit Sub
    //    oNGAMNUM = adoRS("NTRACLINUM")
    //    Unload Me
    //End Sub

    //Private Sub cmdValider_Click()
    //    If adoRS.RecordCount = 0 Then Exit Sub
    //    oNGAMNUM = adoRS("NTRACLINUM")
    //    Unload Me
    //End Sub

    // Cet évènement gère apiTGridGamme_DblClick() et cmdValider_Click()
    private void apiTGridGamme_DoubleClick_cmdValider_Click(object sender, EventArgs e)
    {
      DataRow row = apiTGridGamme.GetFocusedDataRow();
      if (row == null) return;

      mloNGAMNUM = (int)Utils.ZeroIfBlank(row["NTRACLINUM"]);

      cmdFermer_Click(null, null);
    }

    private void cmdFermer_Click(object sender, EventArgs e)
    {
      Dispose();
    }
  }
}

