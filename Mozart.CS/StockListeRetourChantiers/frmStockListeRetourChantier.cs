using MZCtrlResources = MozartControls.Properties.Resources;
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
  public partial class frmStockListeRetourChantiers : Form
  {
    DataTable dt = new DataTable();

    //Dim adoRS As Recordset

    public frmStockListeRetourChantiers() { InitializeComponent(); }

    /* OK --------------------------------------------------------------*/
    private void frmStockListeRetourChantiers_Load(object sender, System.EventArgs e)
    {
      try
      {
        Cursor.Current = Cursors.WaitCursor;
        ModuleMain.Initboutons(this);

        string SQL = $"SELECT  TSTOCKRETOUR.NRETNUM, CONVERT(DATETIME, CONVERT(VARCHAR(20), MAX( DRETOUR),103)) AS DRETOUR, VCLINOM, VPERNOM + ' ' + VPERPRE AS CHAFF, VCOMMENT" +
                     $" FROM TSTOCKRETOUR, TPER, TCLI" +
                     $" Where TSTOCKRETOUR.NCLINUM Is Not Null" +
                     $" AND TSTOCKRETOUR.NCHAFFNUM = TPER.NPERNUM" +
                     $" AND TCLI.VSOCIETE = APP_NAME()" +
                     $" AND TCLI.NCLINUM = TSTOCKRETOUR.NCLINUM" +
                     $" GROUP BY NRETNUM, VCLINOM, VPERNOM, VPERPRE, VCOMMENT" +
                     $" ORDER BY DRETOUR DESC";

        apiTGrid.LoadData(dt, MozartDatabase.cnxMozart, SQL);
        apiTGrid.GridControl.DataSource = dt;
        InitApiTgrid();

        Cursor = Cursors.Default;
      }
      catch (Exception ex)
      {
        MZUtils.displayError(MethodBase.GetCurrentMethod().Name, ex);
      }
      finally { Cursor.Current = Cursors.Default; }
    }
    //Private Sub Form_Load()
    //Dim sSQL As String
    //On Error GoTo handler
    //
    //  InitBoutons Me, frmMenu
    //
    //  sSQL = "SELECT  TSTOCKRETOUR.NRETNUM, CONVERT(DATETIME,CONVERT(VARCHAR(20),MAX( DRETOUR),103)) AS DRETOUR, VCLINOM, VPERNOM + ' ' + VPERPRE AS CHAFF, VCOMMENT" _
    //            & " FROM TSTOCKRETOUR, TPER, TCLI" _
    //            & " Where TSTOCKRETOUR.NCLINUM Is Not Null" _
    //            & " AND TSTOCKRETOUR.NCHAFFNUM = TPER.NPERNUM" _
    //            & " AND TCLI.VSOCIETE = APP_NAME()" _
    //            & " AND TCLI.NCLINUM = TSTOCKRETOUR.NCLINUM" _
    //            & " GROUP BY NRETNUM, VCLINOM, VPERNOM, VPERPRE, VCOMMENT" _
    //            & " ORDER BY DRETOUR DESC"
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

    /* OK --------------------------------------------------------------*/
    private void cmdFermer_Click(object sender, System.EventArgs e)
    {
      Dispose();
    }
    //Private Sub cmdFermer_Click()
    //  Unload Me
    //End Sub

    /* OK --------------------------------------------------------------------------------------- */
    private void apiTGrid_DoubleClickE(object sender, EventArgs e)
    {
      Cursor = Cursors.WaitCursor;
      cmdDetail_Click(null, null);
    }
    //Private Sub apiTGrid_DblClick()
    //  Screen.MousePointer = vbHourglass
    //  cmdDetail_Click
    //End Sub

    /* OK --------------------------------------------------------------------------------------- */
    private void cmdAjouter_Click(object sender, EventArgs e)
    {
      frmStockRetourChantier f = new frmStockRetourChantier();
      f.miNumRetour = 0;
      f.ShowDialog();
      apiTGrid.Requery(dt, MozartDatabase.cnxMozart);
    }
    //Private Sub cmdAjouter_Click()
    //  frmStockRetourChantier.iNumRetour = 0
    //  frmStockRetourChantier.Show vbModal
    //End Sub

    /* OK --------------------------------------------------------------------------------------- */
    private void cmdDetail_Click(object sender, EventArgs e)
    {
      DataRow currentRow = apiTGrid.GetFocusedDataRow();
      if (currentRow == null) return;

      Cursor = Cursors.WaitCursor;

      frmStockRetourChantier f = new frmStockRetourChantier();
      f.miNumRetour = Convert.ToInt64(currentRow["NRETNUM"]);
      f.ShowDialog();
      apiTGrid.Requery(dt, MozartDatabase.cnxMozart);

      Cursor = Cursors.Default;
    }
    //Private Sub cmdDetail_Click()
    //Dim BookMark
    //
    //  If adoRS.EOF Then Exit Sub
    //
    //  Screen.MousePointer = vbHourglass
    //  
    //  frmStockRetourChantier.iNumRetour = adoRS("NRETNUM")
    //  BookMark = adoRS.BookMark
    //  frmStockRetourChantier.Show vbModal
    //  adoRS.Requery
    //  adoRS.BookMark = BookMark
    //
    //  Screen.MousePointer = vbDefault
    //End Sub

    /* OK --------------------------------------------------------------------------------------- */
    void InitApiTgrid()
    {
      try
      {
        apiTGrid.AddColumn(Resources.col_nRetour, "NRETNUM", 1000, "", 2);
        apiTGrid.AddColumn(Resources.col_dateRetour, "DRETOUR", 1200, "", 2);
        apiTGrid.AddColumn(MZCtrlResources.col_Client, "VCLINOM", 2500);
        apiTGrid.AddColumn(Resources.col_Chaff, "CHAFF", 2500);
        apiTGrid.AddColumn(Resources.col_Commentaire, "VCOMMENT", 2500);

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
    //  apiTGrid.AddColumn "§Client§", "VCLINOM", 2500
    //  apiTGrid.AddColumn "§Chaff§", "chaff", 2500
    //  apiTGrid.AddColumn "§Commentaire§", "VCOMMENT", 2500
    //
    //  apiTGrid.Init adoRS
    //  Exit Sub
    //  
    //handler:
    //  ShowError "InitapiTGrid dans " & Me.Name
    //End Sub

    /* inutile--------------------------------------------------------------------------------------- */
    //Private Sub Form_Unload(Cancel As Integer)
    //  adoRS.Close
    //  Screen.MousePointer = vbDefault
    //End Sub
  }
}