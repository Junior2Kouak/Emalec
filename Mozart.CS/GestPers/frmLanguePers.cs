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
  public partial class frmLanguePers : Form
  {
    public string msLibNomSoc;

    string sSQL;
    string Btype;

    DataTable dtPers = new DataTable();
    DataTable dtLang = new DataTable();

    //  Option Explicit
    //
    //Public sLibNomSoc As String
    //
    //Dim rsPers As ADODB.Recordset
    //Dim rsLang As ADODB.Recordset
    //Dim sSql As String
    //
    //Dim Btype As String
    //

    public frmLanguePers() { InitializeComponent(); }

    /* OK --------------------------------------------------------------*/
    private void frmLanguePers_Load(object sender, System.EventArgs e)
    {
      try
      {
        Btype = "LANGUE";

        Cursor.Current = Cursors.WaitCursor;
        ModuleMain.Initboutons(this);

        InitRs();
        InitTGridPer();
        InitTGridLangue();
        apiTGrid1_ClickE(null, null);
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
    //Private Sub Form_Load()
    //  
    //  
    //  Btype = "LANGUE"
    //  
    //  InitBoutons Me, frmMenu
    //    
    //  InitRs
    //  InitTGridPer
    //  InitTGridLangue
    //  apiTGrid1_Click
    //  
    //End Sub
    //

    /* OK --------------------------------------------------------------*/
    private void cmdFermer_Click(object sender, System.EventArgs e)
    {
      Dispose();
    }
    //Private Sub cmdFermer_Click()
    //  Unload Me
    //End Sub
    //

    /* OK --------------------------------------------------------------------------------------- */
    private void apiTGrid1_SelectionChanged(object sender, DevExpress.Data.SelectionChangedEventArgs e)
    {
      DataRow currentRow = apiTGrid1.GetFocusedDataRow();

      if (Btype == "PERSONNE" || currentRow == null || dtPers.Rows.Count == 0) return;

      //recherche des langues de la personne
      sSQL = $"select tperlang.NLANGID,TREF_LANG.VLANGUE from TPERLANG, TREF_LANG WHERE NPERNUM = {currentRow["NPERNUM"]} and TPERLANG.NLANGID = TREF_LANG.NLANGID ORDER BY VLANGUE";

      apiTGrid2.LoadData(dtLang, MozartDatabase.cnxMozart, sSQL);
      apiTGrid2.GridControl.DataSource = dtLang;
    }
    //Private Sub apiTGrid1_RowColChange()
    //
    //  If Btype = "PERSONNE" Then Exit Sub
    //  If rsPers.EOF Then Exit Sub
    //  
    //  ' recherche des langues de la personne
    //  sSql = "select tperlang.NLANGID,TREF_LANG.VLANGUE from TPERLANG, TREF_LANG WHERE NPERNUM = " & rsPers("NPERNUM") & " and TPERLANG.NLANGID = TREF_LANG.NLANGID ORDER BY VLANGUE"
    //  Set rsLang = New ADODB.Recordset
    //  rsLang.Open sSql, cnx
    //  apiTGrid2.Init rsLang
    //
    //End Sub
    //

    /* OK --------------------------------------------------------------------------------------- */
    private void apiTGrid1_ClickE(object sender, EventArgs e)
    {
      DataRow currentRow = apiTGrid1.GetFocusedDataRow();

      if (currentRow == null || dtPers.Rows.Count == 0) return;

      //recherche des langues de la personne
      sSQL = $"select tperlang.NLANGID,TREF_LANG.VLANGUE from TPERLANG, TREF_LANG WHERE NPERNUM = {currentRow["NPERNUM"]} and TPERLANG.NLANGID = TREF_LANG.NLANGID ORDER BY VLANGUE";

      apiTGrid2.LoadData(dtLang, MozartDatabase.cnxMozart, sSQL);
      apiTGrid2.GridControl.DataSource = dtLang;
    }
    //Private Sub apiTGrid1_Click()
    //   
    //  If Btype = "PESONNE" Then Exit Sub
    //  If rsPers.EOF Then Exit Sub
    //  
    //  ' recherche des langues de la personne
    //  sSql = "select tperlang.NLANGID,TREF_LANG.VLANGUE from TPERLANG, TREF_LANG WHERE NPERNUM = " & rsPers("NPERNUM") & " and TPERLANG.NLANGID = TREF_LANG.NLANGID ORDER BY VLANGUE"
    //  Set rsLang = New ADODB.Recordset
    //  rsLang.Open sSql, cnx
    //  apiTGrid2.Init rsLang
    //
    //End Sub
    //

    /* OK --------------------------------------------------------------------------------------- */
    private void apiTGrid2_SelectionChanged(object sender, DevExpress.Data.SelectionChangedEventArgs e)
    {
      DataRow currentRow = apiTGrid2.GetFocusedDataRow();

      if (Btype == "LANGUE" || dtLang.Rows.Count == 0 || currentRow == null) return;

      string temp = "";
      if (MozartParams.NomSocieteTemp == "GROUPE") temp = msLibNomSoc;
      else temp = MozartParams.NomSocieteTemp;

      //recherche des langues de la personne
      sSQL = $"select tper.npernum, VPERNOM + ' ' + VPERPRE as PERS, VTYPEDETAILLIB from TPER INNER JOIN   TREF_TYPEPERDETAIL ON TREF_TYPEPERDETAIL.CPERTYPDETAIL = TPER.CPERTYPDETAIL " +
        $" INNER JOIN TPERLANG ON TPERLANG.npernum = tper.npernum AND NLANGID = '{currentRow["NLANGID"]}'" +
        $" where VSOCIETE = '{temp}'" +
        $" AND cperactif = 'O' AND Butilisateur=0 order by VPERNOM";

      apiTGrid1.LoadData(dtPers, MozartDatabase.cnxMozart, sSQL);
      apiTGrid1.GridControl.DataSource = dtPers;
    }
    //Private Sub apiTGrid2_RowColChange()
    //
    //  If Btype = "LANGUE" Then Exit Sub
    //  If rsLang.EOF Then Exit Sub
    //  
    //  ' recherche des langues de la personne
    //  sSql = "select tper.npernum, VPERNOM + ' ' + VPERPRE as PERS, VTYPEDETAILLIB from TPER INNER JOIN   TREF_TYPEPERDETAIL ON TREF_TYPEPERDETAIL.CPERTYPDETAIL = TPER.CPERTYPDETAIL "
    //  sSql = sSql & " INNER JOIN TPERLANG ON TPERLANG.npernum = tper.npernum AND NLANGID = '" & rsLang("NLANGID") & "'"
    //  sSql = sSql & " where VSOCIETE = '" & IIf(gstrNomSocieteTemp = "GROUPE", sLibNomSoc, gstrNomSocieteTemp) & "'"
    //  sSql = sSql & " AND cperactif = 'O' AND Butilisateur=0 order by VPERNOM"
    //  Set rsPers = New ADODB.Recordset
    //  rsPers.Open sSql, cnx
    //  apiTGrid1.Init rsPers
    //
    //End Sub
    //

    /* OK --------------------------------------------------------------------------------------- */
    private void apiTGrid2_ClickE(object sender, EventArgs e)
    {
      DataRow currentRow = apiTGrid2.GetFocusedDataRow();

      if (Btype == "LANGUE" || dtLang.Rows.Count == 0 || currentRow == null) return;

      string temp = "";
      if (MozartParams.NomSocieteTemp == "GROUPE") temp = msLibNomSoc;
      else temp = MozartParams.NomSocieteTemp;

      //recherche des langues de la personne
      sSQL = $"select tper.npernum, VPERNOM + ' ' + VPERPRE as PERS, VTYPEDETAILLIB from TPER INNER JOIN   TREF_TYPEPERDETAIL ON TREF_TYPEPERDETAIL.CPERTYPDETAIL = TPER.CPERTYPDETAIL " +
        $" INNER JOIN TPERLANG ON TPERLANG.npernum = tper.npernum AND NLANGID = '{currentRow["NLANGID"]}'" +
        $" where VSOCIETE = '{temp}'" +
        $" AND cperactif = 'O' AND Butilisateur=0 order by VPERNOM";

      apiTGrid1.LoadData(dtPers, MozartDatabase.cnxMozart, sSQL);
      apiTGrid1.GridControl.DataSource = dtPers;
    }
    //Private Sub apiTGrid2_Click()
    //   
    //  If Btype = "LANGUE" Then Exit Sub
    //  If rsLang.EOF Then Exit Sub
    //  
    //  ' recherche des langues de la personne
    //  sSql = "select tper.npernum, VPERNOM + ' ' + VPERPRE as PERS, VTYPEDETAILLIB from TPER INNER JOIN   TREF_TYPEPERDETAIL ON TREF_TYPEPERDETAIL.CPERTYPDETAIL = TPER.CPERTYPDETAIL "
    //  sSql = sSql & " INNER JOIN TPERLANG ON TPERLANG.npernum = tper.npernum AND NLANGID = '" & rsLang("NLANGID") & "'"
    //  sSql = sSql & " where VSOCIETE = '" & IIf(gstrNomSocieteTemp = "GROUPE", sLibNomSoc, gstrNomSocieteTemp) & "'"
    //  sSql = sSql & " AND cperactif = 'O' AND Butilisateur=0 order by VPERNOM"
    //  Set rsPers = New ADODB.Recordset
    //  rsPers.Open sSql, cnx
    //  apiTGrid1.Init rsPers
    //
    //End Sub
    //

    /* OK --------------------------------------------------------------------------------------- */
    void InitTGridPer()
    {
      apiTGrid1.AddColumn("Nom", "PERS", 2500);
      apiTGrid1.AddColumn("Fonction", "VTYPEDETAILLIB", 1000);
      apiTGrid1.InitColumnList();
    }
    //Sub InitTGridPer()
    //  
    //  apiTGrid1.AddColumn "Nom", "PERS", 2500
    //  apiTGrid1.AddColumn "Fonction", "VTYPEDETAILLIB", 1000
    //      
    //  apiTGrid1.Init rsPers
    //
    //End Sub
    //

    /*OK --------------------------------------------------------------------------------------- */
    void InitTGridLangue()
    {
      apiTGrid2.AddColumn("Langue", "VLANGUE", 2500);
      apiTGrid2.InitColumnList();
    }
    //Sub InitTGridLangue()
    //  
    //  apiTGrid2.AddColumn "Langue", "VLANGUE", 2500
    //      
    //  apiTGrid2.Init rsLang
    //
    //End Sub
    //

    /* OK --------------------------------------------------------------------------------------- */
    private void InitRs()
    {

      string temp = "";
      if (MozartParams.NomSocieteTemp == "GROUPE") temp = msLibNomSoc;
      else temp = MozartParams.NomSocieteTemp;

      sSQL = $"select tper.npernum, VPERNOM + ' ' + VPERPRE as PERS, VTYPEDETAILLIB from TPER INNER JOIN   TREF_TYPEPERDETAIL ON TREF_TYPEPERDETAIL.CPERTYPDETAIL = TPER.CPERTYPDETAIL where VSOCIETE = '{temp}'" +
      $" AND cperactif = 'O' AND Butilisateur=0 order by VPERNOM";

      apiTGrid1.LoadData(dtPers, MozartDatabase.cnxMozart, sSQL);
      apiTGrid1.GridControl.DataSource = dtPers;

      /*sSQL = "SELECT VLANGUE, NLANGID FROM TREF_LANG ORDER BY VLANGUE";

      apiTGrid2.LoadData(dtLang, MozartDatabase.cnxMozart, sSQL);
      apiTGrid2.GridControl.DataSource = dtLang;*/
    }
    //Private Sub InitRs()
    //
    //  'on charge le recordset des employés
    //  sSql = "select tper.npernum, VPERNOM + ' ' + VPERPRE as PERS, VTYPEDETAILLIB from TPER INNER JOIN   TREF_TYPEPERDETAIL ON TREF_TYPEPERDETAIL.CPERTYPDETAIL = TPER.CPERTYPDETAIL where VSOCIETE = '" & IIf(gstrNomSocieteTemp = "GROUPE", sLibNomSoc, gstrNomSocieteTemp) & "'"
    //  sSql = sSql & " AND cperactif = 'O' AND Butilisateur=0 order by VPERNOM"
    //  Set rsPers = New ADODB.Recordset
    //  
    //  rsPers.Open sSql, cnx
    //  rsPers.MoveFirst
    //  
    //  'on charge le recordset des langues (pour initialiser la liste)
    //  sSql = "SELECT VLANGUE, NLANGID FROM TREF_LANG ORDER BY VLANGUE"
    //  Set rsLang = New ADODB.Recordset
    //  rsLang.Open sSql, cnx
    //    
    //End Sub
    //
    //

    /* OK --------------------------------------------------------------------------------------- */
    private void cmdPAR_Click(object sender, EventArgs e)
    {
      if (Btype == "PERSONNE")
      {
        cmdPAR.Text = Resources.txt_parLangue;
        Btype = "LANGUE";

        string temp = "";
        if (MozartParams.NomSocieteTemp == "GROUPE") temp = msLibNomSoc;
        else temp = MozartParams.NomSocieteTemp;

        sSQL = $"select tper.npernum, VPERNOM + ' ' + VPERPRE as PERS, VTYPEDETAILLIB from TPER INNER JOIN   TREF_TYPEPERDETAIL ON TREF_TYPEPERDETAIL.CPERTYPDETAIL = TPER.CPERTYPDETAIL where VSOCIETE = '{temp}'" +
        $" AND cperactif = 'O' AND Butilisateur=0 order by VPERNOM";

        apiTGrid1.LoadData(dtPers, MozartDatabase.cnxMozart, sSQL);
        apiTGrid1.GridControl.DataSource = dtPers;

      }
      else if (Btype == "LANGUE")
      {
        cmdPAR.Text = Resources.txt_parEmploye;
        Btype = "PERSONNE";
        sSQL = "SELECT VLANGUE, NLANGID FROM TREF_LANG ORDER BY VLANGUE";

        apiTGrid2.LoadData(dtLang, MozartDatabase.cnxMozart, sSQL);
        apiTGrid2.GridControl.DataSource = dtLang;

        apiTGrid2_ClickE(null, null);
      }
    }
    //Private Sub cmdPAR_Click()
    //
    //  If Btype = "PERSONNE" Then
    //    cmdPAR.Caption = "§Par langue§"
    //    Btype = "LANGUE"
    //    sSql = "select tper.npernum, VPERNOM + ' ' + VPERPRE as PERS, VTYPEDETAILLIB from TPER INNER JOIN   TREF_TYPEPERDETAIL ON TREF_TYPEPERDETAIL.CPERTYPDETAIL = TPER.CPERTYPDETAIL where VSOCIETE = '" & IIf(gstrNomSocieteTemp = "GROUPE", sLibNomSoc, gstrNomSocieteTemp) & "'"
    //    sSql = sSql & " AND cperactif = 'O' AND Butilisateur=0 order by VPERNOM"
    //    Set rsPers = New ADODB.Recordset
    //    rsPers.Open sSql, cnx
    //    apiTGrid1.Init rsPers
    //    apiTGrid2_Click
    //  ElseIf Btype = "LANGUE" Then
    //    cmdPAR.Caption = "§Par employé§"
    //    Btype = "PERSONNE"
    //    'on charge le recordset des langues
    //    sSql = "SELECT VLANGUE, NLANGID FROM TREF_LANG ORDER BY VLANGUE"
    //    Set rsLang = New ADODB.Recordset
    //    rsLang.Open sSql, cnx
    //    apiTGrid2.Init rsLang
    //    apiTGrid2_Click
    //  End If
    //
    //End Sub
    //

    /* inutile--------------------------------------------------------------------------------------- */
    //Private Sub Form_Unload(Cancel As Integer)
    //
    //  On Error Resume Next
    //  rsPers.Close
    //  rsLang.Close
    //
    //End Sub
    //
  }
}

