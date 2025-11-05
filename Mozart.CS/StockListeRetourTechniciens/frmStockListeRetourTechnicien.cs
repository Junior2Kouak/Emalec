using System;
using System.Data;
using System.Reflection;
using System.Windows.Forms;
using MozartNet;
using MozartCS.Properties;
using MozartUC;
using MZUtils = MozartControls.Utils;
using MozartLib;

namespace MozartCS
{
  public partial class frmStockListeRetourTechniciens : Form
  {
    //Dim adoRS As Recordset

    public frmStockListeRetourTechniciens() { InitializeComponent(); }
    /*--------------------------------------------------------------*/
    DataTable dt = new DataTable();

    private void frmStockListeRetourTechniciens_Load(object sender, System.EventArgs e)
    {
      try
      {
        Cursor.Current = Cursors.WaitCursor;
        ModuleMain.Initboutons(this);

        string sSql = "select distinct NRETNUM, DRETOUR , vpernom + ' ' + vperpre as TECH, vcomment From tstockretour, tper Where tstockretour.nClinum " +
                      "Is Null and tstockretour.npernum = tper.npernum  AND VSOCIETE = App_Name() order by DRETOUR desc";

        apiTGrid.LoadData(dt, MozartDatabase.cnxMozart, sSql);
        apiTGrid.GridControl.DataSource = dt;

        InitApiTGrid();
      }
      catch (Exception ex)
      {
        MZUtils.displayError(MethodBase.GetCurrentMethod().Name, ex);
      }
      finally { Cursor.Current = Cursors.Default; }
    }
    /* --------------------------------------------------------------------------------------- */
    //Private Sub Form_Load()
    //Dim sSQL As String
    //On Error GoTo handler
    //
    //  InitBoutons Me, frmMenu
    //
    //  sSQL = "select distinct NRETNUM, DRETOUR , vpernom + ' ' + vperpre as TECH, vcomment " _
    //      & "From tstockretour, tper " _
    //      & "Where tstockretour.nClinum Is Null " _
    //      & "and tstockretour.npernum = tper.npernum "
    //#If MULTI Then
    //      sSQL = sSQL & " AND VSOCIETE = App_Name() "
    //#End If
    //      sSQL = sSQL & "order by dretour desc"
    //  
    //  Set adoRS = New ADODB.Recordset
    //  adoRS.Open sSQL, cnx
    //  
    //  InitApiTgrid
    //  Screen.MousePointer = vbDefault
    //  Exit Sub
    //  
    //handler:
    //  Screen.MousePointer = vbDefault
    //  ShowError "FormLoad dans " & Me.Name
    //End Sub
    //

    /* --------------------------------------------------------------------------------------- */
    private void apiTGrid_DoubleClickE(object sender, EventArgs e)
    {
      Cursor.Current = Cursors.WaitCursor;
      cmdDetail_Click(sender, e);
    }
    //Private Sub apiTGrid_DblClick()
    //  Screen.MousePointer = vbHourglass
    //  cmdDetail_Click
    //End Sub
    //

    /* --------------------------------------------------------------------------------------- */
    private void cmdAjouter_Click(object sender, EventArgs e)
    {
      Cursor.Current = Cursors.WaitCursor;
      new frmStockRetourTech { iNumRetour = 0 }.ShowDialog();

      apiTGrid.Requery(dt, MozartDatabase.cnxMozart);
    }
    //Private Sub cmdAjouter_Click()
    //  Screen.MousePointer = vbHourglass
    //  frmStockRetourTech.iNumRetour = 0
    //  frmStockRetourTech.Show vbModal
    //End Sub
    //
    /* --------------------------------------------------------------------------------------- */
    private void cmdDetail_Click(object sender, EventArgs e)
    {
      DataRow row = apiTGrid.GetFocusedDataRow();
      if (row == null) return;

      Cursor.Current = Cursors.WaitCursor;
      new frmStockRetourTech { iNumRetour = Convert.ToInt32(row["NRETNUM"]) }.ShowDialog();

      apiTGrid.Requery(dt, MozartDatabase.cnxMozart);

      Cursor.Current = Cursors.Default;
    }
    //Private Sub cmdDetail_Click()
    //Dim BookMark
    //
    //  If adoRS.EOF Then Exit Sub
    //
    //  Screen.MousePointer = vbHourglass
    //  
    //  frmStockRetourTech.iNumRetour = adoRS("NRETNUM")
    //  BookMark = adoRS.BookMark
    //  frmStockRetourTech.Show vbModal
    //  adoRS.Requery
    //  adoRS.BookMark = BookMark
    //
    //  Screen.MousePointer = vbDefault
    //End Sub
    //
    //
    ///* --------------------------------------------------------------------------------------- */
    void InitApiTGrid()
    {
      try
      {
        apiTGrid.AddColumn(Resources.col_nRetour, "NRETNUM", 1000, "", 2);
        apiTGrid.AddColumn(Resources.col_dateRetour, "DRETOUR", 1200, "", 2);
        apiTGrid.AddColumn(Resources.col_Technicien, "TECH", 1200);
        apiTGrid.AddColumn(Resources.col_Commentaire, "vcomment", 2500);

        apiTGrid.GridControl.DataSource = dt;

        apiTGrid.InitColumnList();
      }
      catch (Exception ex)
      {
        MZUtils.displayError(MethodBase.GetCurrentMethod().Name, ex);
      }
    }
    //Sub InitApiTgrid()
    //  
    //  On Error GoTo handler
    //  
    //  apiTGrid.AddColumn "§N° Retour§", "NRETNUM", 1000, , 2
    //  apiTGrid.AddColumn "§Date retour§", "DRETOUR", 1200, , 2
    //  apiTGrid.AddColumn "§Technicien§", "TECH", 2500
    //  apiTGrid.AddColumn "§Commentaire§", "VCOMMENT", 2500
    //
    //  apiTGrid.Init adoRS
    //  Exit Sub
    //  
    //handler:
    //  ShowError "InitapiTGrid dans " & Me.Name
    //End Sub
    //
    /* --------------------------------------------------------------------------------------- */
    private void cmdFermer_Click(object sender, System.EventArgs e)
    {
      Dispose();
    }
    //Private Sub cmdFermer_Click()
    //  Unload Me
    //End Sub

    /* --------------------------------------------------------------------------------------- */
    //Private Sub Form_Unload(Cancel As Integer)
    //  adoRS.Close
    //  Screen.MousePointer = vbDefault
    //End Sub
  }
}