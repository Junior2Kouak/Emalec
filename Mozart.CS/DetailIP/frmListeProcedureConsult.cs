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
  public partial class frmListeProcedureConsult : Form
  {
    //Public iNumCli As Long
    //Public iNumSite As Long
    public int iNumCli;
    public int iNumSite;

    //Dim rsProc As New ADODB.Recordset
    //Dim bActif As Byte
    DataTable dt = new DataTable();
    byte bActif;

    //Dim sSQL As String
    string sSQL;

    public frmListeProcedureConsult() { InitializeComponent(); }

    private void frmListeProcedureConsult_Load(object sender, System.EventArgs e)
    {
      try
      {
        Cursor.Current = Cursors.WaitCursor;
        ModuleMain.Initboutons(this);

        bActif = 1;

        LoadData();

        InitGrig();
      }
      catch (Exception ex)
      {
        MZUtils.displayError(MethodBase.GetCurrentMethod().Name, ex);
      }
      finally { Cursor.Current = Cursors.Default; }
    }
    /* --------------------------------------------------------------------------------------- */
    //Private Sub Form_Load()
    //  
    //  InitBoutons Me, frmMenu
    //  
    //  bActif = 1
    //  
    //  LoadData
    //  
    //  InitGrig
    //  
    //  apiTGrid1_RowColChange
    //  
    //End Sub
    //
    /* --------------------------------------------------------------------------------------- */
    private void LoadData()
    {
      sSQL = $"SELECT NIDPROC, VTITRE, 'Tous sites' AS VSITNOM, VFICHIER From TPROCEDURE WHERE BPROCACTIF = {bActif} AND NIDTYPPROC = 14 AND NCLINUM = {iNumCli}" +
             $" UNION SELECT NIDPROC, VTITRE, VSITNOM, VFICHIER FROM TPROCEDURE WITH (NOLOCK) INNER JOIN TSIT WITH (NOLOCK)" +
             $" ON TPROCEDURE.NSITNUM = TSIT.NSITNUM INNER JOIN TREF_TYPPROC WITH (NOLOCK) ON TREF_TYPPROC.NIDTYPPROC = TPROCEDURE.NIDTYPPROC" +
             $" WHERE BPROCACTIF = 1  AND TREF_TYPPROC.NTYPPROCFAMILLE = {bActif} AND TPROCEDURE.NSITNUM = {iNumSite} ORDER BY NIDPROC";

      apiTGrid1.LoadData(dt, MozartDatabase.cnxMozart, sSQL);
      apiTGrid1.GridControl.DataSource = dt;
    }
    //Private Sub LoadData()
    //    
    //    WebBrowser1.Navigate "about:blank"
    //    
    //    If rsProc.state = adStateOpen Then rsProc.Close
    //    
    //    Set rsProc = New ADODB.Recordset
    //    
    //    sSQL = "SELECT NIDPROC, VTITRE, 'Tous sites' AS VSITNOM, VFICHIER From TPROCEDURE WHERE BPROCACTIF = " & bActif & " AND NIDTYPPROC = 14 AND NCLINUM = " & iNumCli _
    //      & " UNION " _
    //      & " SELECT NIDPROC, VTITRE, VSITNOM, VFICHIER FROM TPROCEDURE WITH (NOLOCK) INNER JOIN TSIT WITH (NOLOCK) ON TPROCEDURE.NSITNUM = TSIT.NSITNUM INNER JOIN TREF_TYPPROC WITH (NOLOCK) ON TREF_TYPPROC.NIDTYPPROC = TPROCEDURE.NIDTYPPROC WHERE BPROCACTIF = 1  AND TREF_TYPPROC.NTYPPROCFAMILLE = " & bActif & "  AND TPROCEDURE.NSITNUM = " & iNumSite _
    //      & " ORDER BY NIDPROC"
    //  
    //    rsProc.Open sSQL, cnx
    //  
    //    apiTGrid1.Init rsProc
    //    
    //End Sub
    //
    /* --------------------------------------------------------------------------------------- */
    private void InitGrig()
    {
      apiTGrid1.AddColumn(Resources.col_Num, "NIDPROC", 800);
      apiTGrid1.AddColumn(Resources.col_Site, "VSITNOM", 1500);
      apiTGrid1.AddColumn(Resources.col_Titre, "VTITRE", 3000);

      apiTGrid1.InitColumnList();
    }
    //Private Sub InitGrig()
    //  
    //  apiTGrid1.AddColumn "§N°§", "NIDPROC", 1000
    //  apiTGrid1.AddColumn "§Site", "VSITNOM", 3000
    //  apiTGrid1.AddColumn "§Titre§", "VTITRE", 3000
    //   
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
    //
    /* --------------------------------------------------------------------------------------- */
    private void frmListeProcedureConsult_FormClosing(object sender, FormClosingEventArgs e)
    {
      iNumCli = 0;
      iNumSite = 0;
    }
    //Private Sub Form_Unload(Cancel As Integer)
    //  iNumCli = 0
    //  iNumSite = 0
    //  rsProc.Close
    //  Set rsProc = Nothing
    //End Sub
    //
    /* --------------------------------------------------------------------------------------- */
    private void apiTGrid1_FocusedRowChanged(object sender, DevExpress.XtraGrid.Views.Base.FocusedRowChangedEventArgs e)
    {
      DataRow row = apiTGrid1.GetFocusedDataRow();
      if (row == null)
        WebBrowser1.Navigate("about:blank");
      else
        WebBrowser1.Navigate(Utils.RechercheParam("REP_INFO") + Utils.BlankIfNull(row["VFICHIER"]));
    }
    //Private Sub apiTGrid1_RowColChange()
    //  WebBrowser1.Navigate "about:blank"
    //  If rsProc.EOF = False Then WebBrowser1.Navigate RechercheParam("REP_INFO") & rsProc("VFICHIER")
    //  
    //End Sub
    //
    /* --------------------------------------------------------------------------------------- */
    private void CmdListeArch_Click(object sender, EventArgs e)
    {
      if (bActif == 1)
      {
        bActif = 0;
        CmdListeArch.Text = "Liste actifs";
      }
      else if (bActif == 0)
      {
        bActif = 1;
        CmdListeArch.Text = "Liste archives";
      }

      LoadData();
    }
    //Private Sub CmdListeArch_Click()
    //
    //    If bActif = 1 Then
    //        bActif = 0
    //        CmdListeArch.Caption = "Liste actifs"
    //    ElseIf bActif = 0 Then
    //        bActif = 1
    //        CmdListeArch.Caption = "Liste archives"
    //    End If
    //
    //    LoadData
    //
    //End Sub

  }
}

