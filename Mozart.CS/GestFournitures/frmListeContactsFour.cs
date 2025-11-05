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
  public partial class frmListeContactsFour : Form
  {
    public frmListeContactsFour()
    {
      InitializeComponent();
    }

    //Public miNumFourn As Long
    //Private rsInt As ADODB.Recordset
    public long miNumFourn;
    DataTable dt = new DataTable();

    //VB6
    //Private Sub Form_Load()
    //  On Error GoTo Handler
    //  InitBoutons Me, frmMenu
    //  Set rsInt = New Recordset
    //  rsInt.Open "SELECT * FROM api_v_InfoContactFournisseur WHERE NSTFNUM = " & miNumFourn & " ORDER BY VINTNOM ", cnx, adOpenStatic, adLockOptimistic
    //  InitApigrid
    //  Exit Sub
    //  Resume
    //Handler:
    //  ShowError "Form_Load dans " & Me.Name
    //End Sub
    private void frmListeContactsFour_Load(object sender, EventArgs e)
    {
      try
      {
        ModuleMain.Initboutons(this);

        ApiTGrid.LoadData(dt, MozartDatabase.cnxMozart, $"SELECT * FROM api_v_InfoContactFournisseur WHERE NSTFNUM = {miNumFourn} ORDER BY VINTNOM");
        ApiTGrid.GridControl.DataSource = dt;
        InitApiGrid();
        ApiTGrid.lblRowCount.Visible = ApiTGrid.chkColumnsList.Visible = ApiTGrid.btnExcel.Visible = ApiTGrid.btnPrint.Visible = false;
      }
      catch (Exception ex)
      {
        MZUtils.displayError(MethodBase.GetCurrentMethod().Name, ex);
      }
    }

    //Private Sub cmdFermer_Click()
    //  Unload Me
    //End Sub

    //Sub InitApigrid()

    //  apigrid.AddColumn "§Nom§", 1400
    //  apigrid.AddColumn "§Prénom§", 1200
    //  apigrid.AddColumn "§Civ§", 500
    //  apigrid.AddColumn "§Fonction§", 1500
    //  apigrid.AddColumn "§Téléphone§", 1200, , vbCenter
    //  apigrid.AddColumn "§Fax§", 1200, , vbCenter
    //  apigrid.AddColumn "§GSM§", 1200, , vbCenter
    //  apigrid.AddColumn "§E-Mail§", 0
    //  apigrid.AddColumn "§Statut§", 0
    //  apigrid.AddColumn "NumST", 0
    //  apigrid.AddColumn "NumContact", 0
    //  apigrid.DesactiveListe

    //  apigrid.Init rsInt
    //End Sub
    private void InitApiGrid()
    {
      ApiTGrid.AddColumn(Resources.col_Nom, "VINTNOM", 100);
      ApiTGrid.AddColumn(Resources.col_Prenom, "VINTPRE", 80);
      ApiTGrid.AddColumn(Resources.col_Civ, "CINTCIV", 20);
      ApiTGrid.AddColumn(Resources.col_Fonction, "VINTFONC", 100);
      ApiTGrid.AddColumn(Resources.col_Tel, "VINTTEL", 140, "", 2);
      ApiTGrid.AddColumn(Resources.col_Fax, "VINTFAX", 140, "", 2);
      ApiTGrid.AddColumn(Resources.col_GSM, "VINTPOR", 140, "", 2);
      ApiTGrid.AddColumn(Resources.col_Email, "VINTMAIL", 0);
      ApiTGrid.AddColumn(Resources.col_Statut, "CINTACTIF", 0);
      ApiTGrid.AddColumn("NumST", "NumST", 0);
      ApiTGrid.AddColumn("NumContact", "NumContact", 0);

      ApiTGrid.DesactiveListe();
      ApiTGrid.InitColumnList();
    }

    private void cmdFermer_Click(object sender, EventArgs e)
    {
      Dispose();
    }
  }
}
