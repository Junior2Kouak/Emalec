using MozartCS.Properties;
using MozartLib;
using MozartNet;
using MozartUC;
using System;
using System.Data;
using System.Reflection;
using System.Windows.Forms;
using MZUtils = MozartControls.Utils;

namespace MozartCS
{
  public partial class frmListeCoutsClient : Form
  {
    DataTable dt = new DataTable();
    public long miNumClient;
    //Dim adors As Recordset
    //Public NCLINUM As Long

    public frmListeCoutsClient()
    {
      InitializeComponent();
    }

    private void frmListeCoutsClient_Load(object sender, System.EventArgs e)
    {
      try
      {
        ModuleMain.Initboutons(this);
        apiGrid.Visible = true;
        apiTGridTypCont.Visible = false;

        apiGrid.LoadData(dt, MozartDatabase.cnxMozart, $"EXEC api_sp_ListeCoutsClient {miNumClient}");
        apiGrid.GridControl.DataSource = dt;

        InitApigrid();
        Cursor.Current = Cursors.Default;
      }
      catch (Exception ex)
      {
        MZUtils.displayError(MethodBase.GetCurrentMethod().Name, ex);
      }
    }
    //Private Sub Form_Load()
    //
    //On Error GoTo handler
    //
    //  'init
    //  InitBoutons Me, frmMenu
    //  apiGrid.Visible = True
    //  apiTGridTypCont.Visible = False
    //
    //  Set adors = New Recordset
    //
    //  adors.Open "EXEC api_sp_ListeCoutsClient " & NCLINUM, cnx, adOpenStatic, adLockReadOnly
    //
    //  InitApigrid
    //    
    //  Screen.MousePointer = vbDefault
    //  
    //Exit Sub
    //handler:
    //  Screen.MousePointer = vbDefault
    //  ShowError "Form_load dans " & Me.Name
    //End Sub

    /* OK --------------------------------------------------------------------------------------- */
    private void cmdFermer_Click(object sender, System.EventArgs e)
    {
      Dispose();
    }
    //Private Sub cmdFermer_Click()
    //  Unload Me
    //End Sub

    /* OK --------------------------------------------------------------------------------------- */
    private void cmdModifier_Click(object sender, EventArgs e)
    {
      DataRow row = apiGrid.GetFocusedDataRow();
      if (row == null) return;

      Cursor.Current = Cursors.WaitCursor;

      new frmDetailsClient { mstrStatut = "M", miNumClient = Convert.ToInt32(row["NCLINUM"]) }.ShowDialog();

      apiGrid.Requery(dt, MozartDatabase.cnxMozart);
      Cursor.Current = Cursors.Default;
    }
    //Private Sub cmdModifier_Click()
    //  
    //    frmDetailsClient.mstrStatut = "M"
    //    frmDetailsClient.miNumClient = adors("NCLINUM")
    //    frmDetailsClient.Show vbModal
    //    
    //    adors.Requery
    //
    //    ' mise en page du tableau
    //    apiGrid.MajLabel
    //End Sub

    /* OK --------------------------------------------------------------------------------------- */
    private void frmListeCoutsClient_FormClosed(object sender, FormClosedEventArgs e)
    {
      MozartUcUtils.SpyLog(MozartDatabase.cnxMozart, "", "", "Sortie");
      Cursor.Current = Cursors.Default;
    }
    //Private Sub Form_Unload(Cancel As Integer)
    //  SpyLog "", "", "Sortie"
    //  Screen.MousePointer = vbDefault
    //  If adors.state = adStateOpen Then adors.Close
    //  Set adors = Nothing
    //End Sub

    /* OK --------------------------------------------------------------------------------------- */
    private void InitApigrid()
    {
      try
      {
        apiGrid.AddColumn(Resources.col_Nom, "VCLINOM", 4500);
        apiGrid.AddColumn(Resources.col_Contrat, "VTYPECONTRAT", 2500);
        apiGrid.AddColumn(Resources.col_Pays, "VPAYS", 2500);
        apiGrid.AddColumn(Resources.col_Cout_Hor, "NCLICONTHOR", 800, "", 2);
        apiGrid.AddColumn(Resources.col_Cout_Depl, "NCLICONTDEP", 800, "", 2);
        apiGrid.AddColumn("NCLINUM", "NCLINUM", 0);

        apiGrid.InitColumnList();
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
    //  apiGrid.AddColumn "§Nom§", "VCLINOM", 4500
    //  apiGrid.AddColumn "§Contrat§", "VTYPECONTRAT", 2500
    //  apiGrid.AddColumn "§Pays§", "VPAYS", 2500
    //  apiGrid.AddColumn "§Coût Hor§", "NCLICONTHOR", 800, , 2
    //  apiGrid.AddColumn "§Coût Dépl§", "NCLICONTDEP", 800, , 2
    //  apiGrid.AddColumn "NCLINUM", "NCLINUM", 0
    //  
    //  apiGrid.Init adors
    //  
    //Exit Sub
    //handler:
    //  ShowError "InitApigrid dans " & Me.Name
    //End Sub
  }
}