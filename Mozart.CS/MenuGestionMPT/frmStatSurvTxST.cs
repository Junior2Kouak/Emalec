using MZCtrlResources = MozartControls.Properties.Resources;
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
  public partial class frmStatSurvTxST : Form
  {
    DataTable dt = new DataTable();

    public frmStatSurvTxST()
    {
      InitializeComponent();
    }

    private void frmStatSurvTxST_Load(object sender, System.EventArgs e)
    {
      string sSQL;
      try
      {
        ModuleMain.Initboutons(this);
        Cursor.Current = Cursors.WaitCursor;
        sSQL = $"SELECT * FROM api_v_statsurvtxstt WHERE VSOCIETE = '{MozartParams.NomSociete}'";
        apiGrid.LoadData(dt, MozartDatabase.cnxMozart, sSQL);
        apiGrid.GridControl.DataSource = dt;
        InitApigrid();
        Cursor.Current = Cursors.Default;
      }
      catch (Exception ex)
      {
        Cursor.Current = Cursors.Default;
        MZUtils.displayError(MethodBase.GetCurrentMethod().Name, ex);
      }
    }
    //Private Sub Form_Load()
    //  On Error GoTo Handler
    //  InitBoutons Me, frmMenu
    //  Screen.MousePointer = vbHourglass
    //  If cnxRep.state = adStateOpen Then cnxRep.Close
    //  'ouverture connexion
    //  'cnxRep.Open gstrConnexionStringReplique
    //  ' TB SAMSIC CITY BASE
    //  cnxRep.Open gstrConnexion
    //  ' cnxRep.Open "PROVIDER=SQLOLEDB.1;Initial Catalog=MULTI;Data Source=" & gstrNomServeur & ";trusted_connection=yes;App=" & gstrNomSociete & ";"
    //  cnxRep.CommandTimeout = 150
    //  ado_rs.Open "SELECT * FROM api_v_statsurvtxstt WHERE VSOCIETE = '" & gstrNomSociete & "'", cnxRep, adOpenStatic, adLockReadOnly
    //  InitApigrid
    //  Screen.MousePointer = vbDefault
    //  Exit Sub
    //  Handler:
    //    Screen.MousePointer = vbDefault
    //    ShowError "Form_Load de " & Me.Name
    //  End Sub

    private void InitApigrid()
    {
      try
      {
        apiGrid.AddColumn(Resources.col_ChargeAffaires, "VDINCHAFF", 110);
        apiGrid.AddColumn(MZCtrlResources.col_Client, "VCLINOM", 110);
        apiGrid.AddColumn(Resources.col_Site, "VSITNOM", 110);
        apiGrid.AddColumn(Resources.col_Contrat, "VTYPECONTRAT", 100);
        apiGrid.AddColumn(Resources.col_Num, "NCSTNUM", 50);
        apiGrid.AddColumn(Resources.col_Action, "VACTDES", 170);
        apiGrid.AddColumn(Resources.col_NomSTT, "VSTFGRPNOM", 120);
        apiGrid.AddColumn(Resources.col_MontantDevisSTT, "NACTVALDEVST", 50, "currency", 1);
        apiGrid.AddColumn(Resources.col_Technicien, "VTECLIB", 100);
        apiGrid.AddColumn(Resources.col_CP, "VSITCP", 50);

        apiGrid.InitColumnList();
      }
      catch (Exception ex)
      {
        MZUtils.displayError(MethodBase.GetCurrentMethod().Name, ex);
      }
    }
    //Private Sub InitApigrid()

    //  On Error GoTo Handler
    //  apiGrid.AddColumn "§Chargé d'affaires§", "VDINCHAFF", 1600
    //  apiGrid.AddColumn "§Client§", "VCLINOM", 1600
    //  apiGrid.AddColumn "§Site§", "VSITNOM", 1600
    //  apiGrid.AddColumn "§Contrat§", "VTYPECONTRAT", 1500
    //  apiGrid.AddColumn "§N° Contrat SST§", "NCSTNUM", 800
    //  apiGrid.AddColumn "§Action§", "VACTDES", 2500
    //  apiGrid.AddColumn "§Nom du SST§", "VSTFGRPNOM", 1700
    //  apiGrid.AddColumn "§Montant devis SST§", "NACTVALDEVST", 800, "currency", 1
    //  apiGrid.AddColumn "Technique", "VTECLIB", 1500
    //  apiGrid.AddColumn "CP", "VSITCP", 800

    //  apiGrid.Init ado_rs

    //  Exit Sub
    //  Handler:
    //    ShowError "InitApigrid dans " & Me.Name
    //  End Sub

    private void cmdQuitter_Click(object sender, EventArgs e)
    {
      Dispose();
    }
  }
}

