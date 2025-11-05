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
  public partial class frmListeTxChange : Form
  {
    DataTable dt = new DataTable();

    public frmListeTxChange() { InitializeComponent(); }
    /*--------------------------------------------------------------*/
    private void frmListeTxChange_Load(object sender, System.EventArgs e)
    {
      try
      {
        Cursor.Current = Cursors.WaitCursor;
        ModuleMain.Initboutons(this);

        string stest = "select DTAUXDATE,VTAUXUNITE, NTAUX, vpaysnom from tpays p inner join TTAUXCHG t ON t.npaysnum=p.npaysnum order by DTAUXDATE";

        apiGrid.LoadData(dt, MozartDatabase.cnxMozart, stest);
        apiGrid.GridControl.DataSource = dt;

        InitApigrid();
      }
      catch (Exception ex)
      {
        MZUtils.displayError(MethodBase.GetCurrentMethod().Name, ex);
      }
      finally { Cursor.Current = Cursors.Default; }
    }


    //  Option Explicit
    //
    //Dim adoRS As ADODB.Recordset
    //
    //
    /* --------------------------------------------------------------------------------------- */
    //Private Sub Form_Load()
    //
    //Dim stest As String
    //
    //On Error GoTo handler:
    //
    //  InitBoutons Me, frmMenu
    //   
    //  Set adoRS = New ADODB.Recordset
    // 
    //  stest = "select DTAUXDATE,VTAUXUNITE, NTAUX, vpaysnom from tpays p inner join TTAUXCHG t ON t.npaysnum=p.npaysnum order by DTAUXDATE"
    //   
    //  adoRS.Open stest, cnx
    //
    //  InitApigrid
    //    
    //  Screen.MousePointer = vbDefault
    //  Exit Sub
    //  
    //handler:
    //  Screen.MousePointer = vbDefault
    //  ShowError "Form_Load dans " & Me.Name
    //End Sub
    //
    //
    //
    /* --------------------------------------------------------------------------------------- */
    private void InitApigrid()
    {
      apiGrid.AddColumn(Resources.col_Date, "DTAUXDATE", 1500);
      apiGrid.AddColumn(Resources.col_Unite_Monetaire, "VTAUXUNITE", 2000);
      apiGrid.AddColumn(Resources.col_Pays, "vpaysnom", 2000);
      apiGrid.AddColumn(Resources.col_Taux_Change, "NTAUX", 2000, "0.####", 2);

      apiGrid.InitColumnList();
    }
    //Private Sub InitApigrid()
    //  
    //On Error GoTo handler
    //  
    //  apiGrid.AddColumn "§Date§", "DTAUXDATE", 1500
    //  apiGrid.AddColumn "§Unité monétaire§", "VTAUXUNITE", 2000
    //  apiGrid.AddColumn "§Pays§", "vpaysnom", 2000
    //  apiGrid.AddColumn "§Taux de change§", "NTAUX", 2000, , 2
    //
    //  apiGrid.Init adoRS
    //  
    //Exit Sub
    //handler:
    //  ShowError "InitApigrid dans " & Me.Name
    //End Sub
    //
    /* --------------------------------------------------------------------------------------- */
    //Private Sub apiGrid_DblClick()
    //  Call cmdModifier_Click
    //End Sub
    //
    /* --------------------------------------------------------------------------------------- */
    //Private Sub cmdModifier_Click()
    //
    //'  frmDetailstxChange.mintTxChange = adoRS("NTCHANGE").Value
    //'  frmDetailstxChange.mstrStatut = "M"
    //'  frmDetailstxChange.Show vbModal
    //
    //End Sub
    //
    //' UPGRADE_INFO (#0501): The 'cmdNouvelle_Click' member isn't used anywhere in current application.
    //'Private Sub cmdNouvelle_Click()
    //'
    //'  Screen.MousePointer = vbHourglass
    //'  ' écran de création de la demande
    //'  frmDetailstxChange.mstrStatut = "C"
    //'  frmDetailstxChange.Show vbModal
    //'
    //'  Screen.MousePointer = vbDefault
    //'
    //'End Sub
    //
    /* --------------------------------------------------------------------------------------- */
    //Private Sub Form_Unload(Cancel As Integer)
    //
    //  On Error Resume Next
    //  Screen.MousePointer = vbDefault
    //  adoRS.Close
    //  Set adoRS = Nothing
    //
    //End Sub
    //
    /* --------------------------------------------------------------------------------------- */
    private void cmdQuitter_Click(object sender, System.EventArgs e)
    {
      Dispose();
    }
    //Private Sub cmdQuitter_Click()
    //  Unload Me
    //End Sub

  }
}

