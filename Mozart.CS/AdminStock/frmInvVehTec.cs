using MozartCS.Properties;
using MozartLib;
using MozartNet;
using System.Collections.Generic;
using System.Data;
using System.Reflection;
using System.Windows.Forms;
using MZUtils = MozartControls.Utils;

namespace MozartCS
{
  public partial class frmInvVehTec : Form
  {
    //Dim bFirstTime As Boolean
    //Dim adoRSInv As Recordset
    //private bool mbFirstTime;

    DataTable dt = new DataTable();

    public frmInvVehTec()
    {
      InitializeComponent();
    }

    //Private Sub Form_Load()
    //  bFirstTime = True
    //  InitBoutons Me, frmMenu
    //  RemplirCombo cmbPerTec, "SELECT NPERNUM,VPERNOM + ' ' + VPERPRE AS VNOMPRE FROM TPER WHERE CPERTYP = 'TE' AND CPERACTIF = 'O' AND VSOCIETE = APP_NAME() ORDER BY VNOMPRE", True
    //  Set adoRSInv = New Recordset
    //  adoRSInv.Open "EXEC api_sp_InvVehTech " & cmbPerTec.ItemData(cmbPerTec.ListIndex), cnx, adOpenStatic, adLockReadOnly
    //  InitApigrid
    //End Sub
    private void frmInvVehTec_Load(object sender, System.EventArgs e)
    {
      ModuleMain.Initboutons(this);

      //mbFirstTime = true;
      string sSql = "SELECT NPERNUM, VPERNOM +' ' + VPERPRE AS VNOMPRE FROM TPER WHERE CPERTYP = 'TE' AND CPERACTIF = 'O' " +
                    "AND VSOCIETE = APP_NAME() ORDER BY VNOMPRE";
      apicboPerTec.Init(MozartDatabase.cnxMozart, sSql, "NPERNUM", "VNOMPRE", new List<string>() { Resources.col_Num, Resources.col_Nom }, 150, 550, bHideFirstColumn: true);

      InitApiGrid();
    }

    //Private Sub InitApigrid()

    //On Error GoTo handler

    //  apiTGrid1.AddColumn "§Article§", "art", 10000
    //  apiTGrid1.AddColumn "§Quantité§", "Qte", 500, , 1

    //  apiTGrid1.Init adoRSInv

    //Exit Sub
    //handler:
    //  ShowError "InitApigrid dans " & Me.Name
    //End Sub
    private void InitApiGrid()
    {
      try
      {
        apiTGrid1.AddColumn(Resources.col_Article, "art", 660);
        apiTGrid1.AddColumn(Resources.col_Qte, "Qte", 35, "", 1);

        apiTGrid1.InitColumnList();
      }
      catch (System.Exception ex)
      {
        MZUtils.displayError(MethodBase.GetCurrentMethod().Name, ex);
      }
    }

    //Private Sub cmdFermer_Click()

    //  If adoRSInv.State = adStateOpen Then
    //    adoRSInv.Close
    //  End If
    //  Set adoRSInv = Nothing

    //  Unload Me

    //End Sub
    private void cmdFermer_Click(object sender, System.EventArgs e)
    {
      Dispose();
    }

    //Private Sub cmbPerTec_Click()
    //Screen.MousePointer = vbHourglass
    //If bFirstTime = True Then bFirstTime = False: Screen.MousePointer = vbDefault: Exit Sub
    //If adoRSInv.State = adStateOpen Then
    //adoRSInv.Close
    //End If
    //adoRSInv.Open "EXEC api_sp_InvVehTech " & cmbPerTec.ItemData(cmbPerTec.ListIndex), cnx, adOpenStatic, adLockReadOnly
    //adoRSInv.Requery
    //apiTGrid1.MajLabel
    //Screen.MousePointer = vbDefault
    //End Sub
    private void cmdChoisir_Click(object sender, System.EventArgs e)
    {
      Cursor.Current = Cursors.WaitCursor;
      apiTGrid1.LoadData(dt, MozartDatabase.cnxMozart, $"EXEC api_sp_InvVehTech {apicboPerTec.GetItemData()}");
      apiTGrid1.GridControl.DataSource = dt;
      Cursor.Current = Cursors.Default;
    }
  }
}

