using MozartCS.Properties;
using MozartLib;
using MozartNet;
using System;
using System.Data;
using System.Windows.Forms;
using MZCtrlResources = MozartControls.Properties.Resources;

namespace MozartCS
{
  public partial class frmGestComptePer : Form
  {
    //Public sLibNomSoc As String
    //Dim rsPri As Recordset
    //Public miNumPersonne As Integer
    //Public mstrPersonne As String
    public int miNumPersonne;
    public string msLibNomSoc;
    public string mstrPersonne;
    DataTable dt = new DataTable();

    public frmGestComptePer()
    {
      InitializeComponent();
    }

    //Private Sub Form_Load()
    //  ' initialisation des boutons
    //  InitBoutons Me, frmMenu
    //  Set rsPri = New Recordset
    //  rsPri.Open "select VCLINOM, NCANNUM  from TCAN, TCLI WHERE TCAN.NCLINUM = TCLI.NCLINUM and TCAN.NPERNUM = " & miNumPersonne & " Order by VCLINOM ", cnx, adOpenStatic, adLockOptimistic
    //  lblTitre.Caption = lblTitre.Caption & mstrPersonne & " - " & IIf(gstrNomSocieteTemp = "GROUPE", sLibNomSoc, gstrNomSocieteTemp)
    //  InitApigrid
    //End Sub
    private void frmGestComptePer_Load(object sender, EventArgs e)
    {
      ModuleMain.Initboutons(this);

      apiGrid.LoadData(dt, MozartDatabase.cnxMozart, $"select VCLINOM, NCANNUM  from TCAN, TCLI WHERE TCAN.NCLINUM = TCLI.NCLINUM and TCAN.NPERNUM = {miNumPersonne} Order by VCLINOM ");
      apiGrid.GridControl.DataSource = dt;
      string strNomSocieteTemp = MozartParams.NomSocieteTemp;
      string stemp = strNomSocieteTemp == "GROUPE" ? msLibNomSoc : strNomSocieteTemp;
      lblTitre.Text = lblTitre.Text + mstrPersonne + " - " + stemp;
      InitApiGrid();
    }

    //Sub InitApigrid()
    //  apigrid.AddColumn "§Client§", "VCLINOM", 3500
    //  apigrid.AddColumn "§Compte§", "NCANNUM", 1500
    //  apigrid.Init rsPri
    //  'ApiGrid.DesactiveListe
    //End Sub
    private void InitApiGrid()
    {
      apiGrid.AddColumn(MZCtrlResources.col_Client, "VCLINOM", 500);
      apiGrid.AddColumn(Resources.col_Compte, "NCANNUM", 200);

      apiGrid.InitColumnList();
    }

    private void cmdFermer_Click(object sender, EventArgs e)
    {
      Dispose();
    }
  }
}
