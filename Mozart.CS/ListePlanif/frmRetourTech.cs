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
  public partial class frmRetourTech : Form
  {
    DataTable dt = new DataTable();

    public frmRetourTech() { InitializeComponent(); }

    //VB6
    //Private Sub Form_Load()
    //  InitBoutons Me, frmMenu
    //  InitRs
    //  InitGrid
    //End Sub
    private void frmRetourTech_Load(object sender, EventArgs e)
    {
      try
      {
        Cursor.Current = Cursors.WaitCursor;
        ModuleMain.Initboutons(this);

        InitRs();
        InitApiGrid();
      }
      catch (Exception ex)
      {
        MZUtils.displayError(MethodBase.GetCurrentMethod().Name, ex);
      }
      finally
      {
        Cursor.Current = Cursors.Default;
      }
    }

    private void cmdQuitter_Click(object sender, EventArgs e)
    {
      Dispose();
    }

    //VB6
    //Private Sub InitGrid()
    //  apiTGridTech.AddColumn "§Technicien§", "TECH", 5000
    //  apiTGridTech.AddColumn "§Date de retour§", "DACTPLA", 2000, , 2
    //  apiTGridTech.Init rsTech
    //End Sub

    private void InitApiGrid()
    {
      apiTGridTech.AddColumn(Resources.col_Technicien, "TECH", 5000);
      apiTGridTech.AddColumn(Resources.col_ReturnDate, "DACTPLA", 2000, "", 2);

      apiTGridTech.InitColumnList();
    }

    //VB6
    //Private Sub InitRs()
    //#If MULTI Then
    //  sSQL = "SELECT DISTINCT DACTPLA, VPERNOM + ' ' + VPERPRE AS TECH " _
    //      & " FROM TACT, TSIT, TDIN, TPER, TCLI " _
    //      & " WHERE CETACOD = 'P' " _
    //      & " AND TACT.NPERNUM in (SELECT NPERNUM FROM TPER WHERE VSOCIETE = App_Name() AND CPERACTIF = 'O' AND CPERTYP = 'TE') " _
    //      & " AND TACT.NSITNUM = TSIT.NSITNUM " _
    //      & " AND TACT.NDINNUM = TDIN.NDINNUM " _
    //      & " AND TACT.NPERNUM = TPER.NPERNUM " _
    //      & " AND TSIT.NCLINUM = TCLI.NCLINUM AND TCLI.VCLINOM = App_NAME() " _
    //      & " AND DACTPLA >= CONVERT(CHAR(10), GETDATE(),103) " _
    //      & " AND TDIN.NDINCTE <> 996 " _
    //      & " AND CPERACTIF = 'O' AND CPERTYP = 'TE' " _
    //      & " ORDER BY DACTPLA, VPERNOM + ' ' + VPERPRE"
    //#Else
    //  sSQL = "SELECT DISTINCT DACTPLA, VPERNOM + ' ' + VPERPRE AS TECH " _
    //      & " FROM TACT, TSIT, TDIN, TPER, TCLI " _
    //      & " WHERE CETACOD = 'P' " _
    //      & " AND TACT.NPERNUM in (SELECT NPERNUM FROM TPER WHERE CPERACTIF = 'O' AND CPERTYP = 'TE') " _
    //      & " AND TACT.NSITNUM = TSIT.NSITNUM " _
    //      & " AND TACT.NDINNUM = TDIN.NDINNUM " _
    //      & " AND TACT.NPERNUM = TPER.NPERNUM " _
    //      & " AND TSIT.NCLINUM = TCLI.NCLINUM AND TCLI.VCLINOM = DB_NAME() " _
    //      & " AND DACTPLA >= CONVERT(CHAR(10), GETDATE(),103) " _
    //      & " AND TDIN.NDINCTE <> 996 " _
    //      & " AND CPERACTIF = 'O' AND CPERTYP = 'TE' " _
    //      & " ORDER BY DACTPLA, VPERNOM + ' ' + VPERPRE"
    //#End If

    //  Set rsTech = New ADODB.Recordset
    //  rsTech.Open sSQL, cnx

    //End Sub
    private void InitRs()
    {
      //#if MULTI
      apiTGridTech.LoadData(dt, MozartDatabase.cnxMozart, "SELECT DISTINCT DACTPLA, VPERNOM + ' ' + VPERPRE AS TECH "
        + " FROM TACT, TSIT, TDIN, TPER, TCLI "
        + " WHERE CETACOD = 'P' "
        + " AND TACT.NPERNUM in (SELECT NPERNUM FROM TPER WHERE VSOCIETE = App_Name() AND CPERACTIF = 'O' AND CPERTYP = 'TE') "
        + " AND TACT.NSITNUM = TSIT.NSITNUM "
        + " AND TACT.NDINNUM = TDIN.NDINNUM "
        + " AND TACT.NPERNUM = TPER.NPERNUM "
        + " AND TSIT.NCLINUM = TCLI.NCLINUM AND TCLI.VCLINOM = App_NAME() "
        + " AND DACTPLA >= CONVERT(CHAR(10), GETDATE(),103) "
        + " AND TDIN.NDINCTE <> 996 "
        + " AND CPERACTIF = 'O' AND CPERTYP = 'TE' "
        + " ORDER BY DACTPLA, VPERNOM + ' ' + VPERPRE");
      //#else
      //apiTGridTech.LoadData(dt, MozartDatabase.cnxMozart,"SELECT DISTINCT DACTPLA, VPERNOM + ' ' + VPERPRE AS TECH "
      //  + " FROM TACT, TSIT, TDIN, TPER, TCLI "
      //  + " WHERE CETACOD = 'P' "
      //  + " AND TACT.NPERNUM in (SELECT NPERNUM FROM TPER WHERE CPERACTIF = 'O' AND CPERTYP = 'TE') "
      //  + " AND TACT.NSITNUM = TSIT.NSITNUM "
      //  + " AND TACT.NDINNUM = TDIN.NDINNUM "
      //  + " AND TACT.NPERNUM = TPER.NPERNUM "
      //  + " AND TSIT.NCLINUM = TCLI.NCLINUM AND TCLI.VCLINOM = DB_NAME() "
      //  + " AND DACTPLA >= CONVERT(CHAR(10), GETDATE(),103) "
      //  + " AND TDIN.NDINCTE <> 996 "
      //  + " AND CPERACTIF = 'O' AND CPERTYP = 'TE' "
      //  + " ORDER BY DACTPLA, VPERNOM + ' ' + VPERPRE");
      //#endif

      apiTGridTech.GridControl.DataSource = dt;
    }
  }
}
