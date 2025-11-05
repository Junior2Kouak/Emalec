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
  public partial class frmPointageTel : Form
  {
    DataTable dt = new DataTable();
    public frmPointageTel() { InitializeComponent(); }

    /* OK --------------------------------------------------------------*/
    private void frmPointageTel_Load(object sender, System.EventArgs e)
    {
      try
      {
        Cursor.Current = Cursors.WaitCursor;
        ModuleMain.Initboutons(this);

        apigrid.LoadData(dt, MozartDatabase.cnxMozart, "exec api_sp_ListePointageTel");
        apigrid.GridControl.DataSource = dt;

        InitApigrid();

      }
      catch (Exception ex)
      {
        MZUtils.displayError(MethodBase.GetCurrentMethod().Name, ex);
      }
      finally { Cursor.Current = Cursors.Default; }
    }

    //Private Sub Form_Load()
    //    
    //On Error GoTo handler:
    //
    //  InitBoutons Me, frmMenu
    //  
    //  ' ouverture du recordset
    //  Set adoRS = New ADODB.Recordset
    //  adoRS.Open "exec api_sp_ListePointageTel", cnx
    //
    //  InitApigrid
    //    
    //  Screen.MousePointer = vbDefault
    //  Exit Sub
    //  
    //handler:
    //  Screen.MousePointer = vbDefault
    //  ShowError "Form_Load de " & Me.Name
    //    
    //End Sub
    //

    /* OK --------------------------------------------------------------*/
    private void cmdQuitter_Click(object sender, System.EventArgs e)
    {
      Dispose();
    }

    //Private Sub cmdQuitter_Click()
    //  Unload Me
    //End Sub
    //
    //

    /* OK --------------------------------------------------------------------------------------- */
    private void InitApigrid()
    {

      try
      {
        apigrid.AddColumn(Resources.col_Enseigne, "VSITENSEIGNE", 3000);
        apigrid.AddColumn(Resources.col_Site, "VSITNOM", 3000);
        apigrid.AddColumn("Tel", "NUMTEL", 1500);
        apigrid.AddColumn("Agent", "VPERNOM", 2000);
        apigrid.AddColumn(Resources.col_Action, "VACTION", 3000);
        apigrid.AddColumn(Resources.col_Date, "DDATE", 1500);
        apigrid.AddColumn("Heure", "HHEURE", 1500);

        apigrid.InitColumnList();
      }
      catch (Exception ex)
      {
        MZUtils.displayError(MethodBase.GetCurrentMethod().Name, ex);
      }
    }

    //Private Sub InitApigrid()
    //  
    //On Error GoTo handler
    //
    //  apigrid.AddColumn "§Enseigne§", "VSITENSEIGNE", 3000
    //  apigrid.AddColumn "§Site§", "VSITNOM", 3000
    //  apigrid.AddColumn "Tel", "NUMTEL", 1500
    //  apigrid.AddColumn "Agent", "VPERNOM", 2000
    //  apigrid.AddColumn "§Action§", "VACTION", 3000
    //  apigrid.AddColumn "§Date§", "DDATE", 1500
    //  apigrid.AddColumn "Heure", "HHEURE", 1500
    //  
    //  apigrid.Init adoRS
    //  
    //Exit Sub
    //
    //handler:
    //  ShowError "InitApigrid dans " & Me.Name
    //End Sub
    //

    /* inutile --------------------------------------------------------------------------------------- */
    //Private Sub Form_Unload(Cancel As Integer)
    //  Screen.MousePointer = vbDefault
    //End Sub
    //


  }
}

