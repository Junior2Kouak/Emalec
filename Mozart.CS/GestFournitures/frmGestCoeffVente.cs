using DevExpress.XtraGrid.Views.Base;
using MozartCS.Properties;
using MozartLib;
using MozartNet;
using System;
using System.Data;
using System.Data.SqlClient;
using System.Reflection;
using System.Windows.Forms;
using MZUtils = MozartControls.Utils;

//Bouton Valider inutile, à confirmer
namespace MozartCS
{
  public partial class frmGestCoeffVente : Form
  {
    //Dim rsPri As Recordset
    //Public miNumClient As Integer
    //Public mstrNomClient As String

    public int miNumClient;
    public string mstrNomClient = "";

    DataSet ds = new DataSet();
    SqlDataAdapter da = new SqlDataAdapter();
    SqlCommandBuilder cb = new SqlCommandBuilder();

    public frmGestCoeffVente()
    {
      InitializeComponent();
    }


    private void frmGestCoeffVente_Load(object sender, EventArgs e)
    {
      ModuleMain.Initboutons(this);

      lbl_Nom.Text = mstrNomClient;

      string sSQL = $"select O.CCFOCOD, DCCACOE, O.NCFOCOD from  TCCA A INNER JOIN TREF_CFO O ON O.NCFOCOD=A.NCFOCOD " +
                    $"where A.NCLINUM = {miNumClient} AND LANGUE = '{MozartParams.Langue}' Order by O.CCFOCOD";

      da = new SqlDataAdapter(sSQL, MozartDatabase.cnxMozart);
      da.Fill(ds, "T");
      apiGrid.GridControl.DataSource = ds.Tables["T"];

      cb.DataAdapter = da;

      InitApiGrid();
    }
    //Private Sub Form_Load()
    //Dim sSQL As String
    //  ' initialisation des boutons
    //  InitBoutons Me, frmMenu
    //  Set rsPri = New Recordset
    //  sSQL = "select O.CCFOCOD, DCCACOE from  TCCA A "
    //  sSQL = sSQL & "INNER JOIN TREF_CFO O ON O.NCFOCOD=A.NCFOCOD where A.NCLINUM = " & miNumClient
    //  sSQL = sSQL & " AND LANGUE = '" & gstrLangue & "' Order by O.CCFOCOD"
    //  rsPri.Open sSQL, cnx, adOpenStatic, adLockOptimistic
    //  ', adOpenStatic, adLockOptimistic
    //  lbl.Caption = mstrNomClient
    //  InitApigrid
    //End Sub

    private void InitApiGrid()
    {
      apiGrid.AddColumn(Resources.col_Serie, "CCFOCOD", 2500);
      apiGrid.AddColumn(Resources.col_Coeff, "DCCACOE", 1500);

      apiGrid.InitColumnList();
      apiGrid.DelockColumn("DCCACOE");
    }
    //Private Sub InitApigrid()
    //  ApiGrid.AddColumn "§Serie§", "CCFOCOD", 2500
    //  ApiGrid.AddColumn "§Coeff§", "DCCACOE", 1500
    //  ApiGrid.Init rsPri
    //  ApiGrid.DelockColumn "DCCACOE"
    //  ApiGrid.AllowAddNew = False
    //  ApiGrid.AllowDelete = False
    //End Sub

    private void cmdFermer_Click(object sender, EventArgs e)
    {
      Dispose();
    }
    //Private Sub cmdFermer_Click()
    //  Unload Me
    //End Sub

    //Private Sub Form_Unload(Cancel As Integer)
    //  Screen.MousePointer = vbDefault
    //End Sub

    private void apiGrid_CellValueChanged(object sender, CellValueChangedEventArgs e)
    {
      try
      {
        // Créer la requête dynamique Update
        ColumnView view = apiGrid.GridControl.FocusedView as ColumnView;
        view.CloseEditor();
        DataRow row = apiGrid.GetFocusedDataRow();
        if (null == row) return;
        ModuleData.ExecuteNonQuery($"UPDATE TCCA SET DCCACOE = {row["DCCACOE"].ToString().Replace(',', '.')} WHERE NCLINUM = {miNumClient} AND NCFOCOD = '{row["NCFOCOD"]}'");
      }
      catch (Exception ex)
      {
        MZUtils.displayError(MethodBase.GetCurrentMethod().Name, ex);
      }
    }
  }
}
