using MozartCS.Properties;
using MozartLib;
using MozartNet;
using System.Data;
using System.Reflection;
using System.Windows.Forms;
using MZUtils = MozartControls.Utils;

namespace MozartCS
{
  public partial class frmStatSynthese : Form
  {
    //Dim adoRS As ADODB.Recordset
    DataTable dt = new DataTable();

    public frmStatSynthese()
    {
      InitializeComponent();
    }

    //Private Sub Form_Load()
    //On Error GoTo handler:
    //  InitBoutons Me, frmMenu
    //  ' execution des requetes
    //  Set adoRS = New ADODB.Recordset
    //  adoRS.Open "select VINDIC, VVALEUR, VOBJECTIF FROM TINDIC ORDER BY VINDIC", cnx, adOpenStatic, adLockReadOnly
    //  InitTGrid
    //  Screen.MousePointer = vbDefault
    //Exit Sub
    //handler:
    //  ShowError "Form_Load de " & Me.Name
    //End Sub

    private void frmStatSynthese_Load(object sender, System.EventArgs e)
    {
      try
      {
        ModuleMain.Initboutons(this);

        apiTGrid1.LoadData(dt, MozartDatabase.cnxMozart, $"select VINDIC, VVALEUR, VOBJECTIF FROM TINDIC ORDER BY VINDIC");
        apiTGrid1.GridControl.DataSource = dt;
        InitApiGrid();
      }
      catch (System.Exception ex)
      {
        MZUtils.displayError(MethodBase.GetCurrentMethod().Name, ex);
      }
    }

    //Sub InitTGrid()
    //  apiTGrid1.AddColumn "§Indicateur§", "VINDIC", 6000
    //  apiTGrid1.AddColumn "§Valeur§", "VVALEUR", 1300, , 2
    //  apiTGrid1.AddColumn "§Objectif§", "VOBJECTIF", 1000, , 2

    //  apiTGrid1.Init adoRS
    //End Sub

    private void InitApiGrid()
    {
      apiTGrid1.AddColumn(Resources.col_Indicateur, "VINDIC", 400);
      apiTGrid1.AddColumn(Resources.col_Valeur, "VVALEUR", 90, "", 2);
      apiTGrid1.AddColumn(Resources.col_Obj, "VOBJECTIF", 70, "", 2);

      apiTGrid1.InitColumnList();
    }

    //Private Sub cmdQuitter_Click()
    //    Unload Me
    //End Sub
    private void cmdQuitter_Click(object sender, System.EventArgs e)
    {
      Dispose();
    }

  }
}

