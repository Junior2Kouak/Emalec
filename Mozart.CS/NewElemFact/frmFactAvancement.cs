using Microsoft.VisualBasic;
using MozartCS.Properties;
using MozartLib;
using MozartNet;
using System;
using System.Data;
using System.Data.SqlClient;
using System.Globalization;
using System.Reflection;
using System.Windows.Forms;
using MZUtils = MozartControls.Utils;

namespace MozartCS
{
  public partial class frmFactAvancement : Form
  {
    public long miDevisNum;
    public long miNumElf;

    private bool bInit;
    private bool bModifPossible;
    private double dRetGar;

    private DataTable dtPrestLocal = new DataTable();
    private DataTable dtPrestLocalAV = new DataTable();
    //Public iDevisNum As Long
    //Public iNumElf As Long
    //Dim rsPrestLocal As ADODB.Recordset
    //Dim rsPrestLocalAv As ADODB.Recordset
    //Dim dRetGar As Double
    //Dim bInit As Boolean
    //Dim sSQL As String
    //Dim ado_cmd As New ADODB.Command
    //Dim bModifPossible As Boolean

    public frmFactAvancement() { InitializeComponent(); }

    /* OK ---------------------------------------------------------------------*/
    private void frmFactAvancement_Load(object sender, System.EventArgs e)
    {
      try
      {
        Cursor.Current = Cursors.WaitCursor;
        ModuleMain.Initboutons(this);
        bInit = true;

        InitRs();
        ModifPossible();
        InitGridHaut();
        InitGridBas();

        bInit = false;

        CalculerHT();
      }
      catch (Exception ex)
      {
        MZUtils.displayError(MethodBase.GetCurrentMethod().Name, ex);
      }
      finally { Cursor.Current = Cursors.Default; }
    }
    //Private Sub Form_Load()
    //
    //  bInit = True
    //
    //  InitBoutons Me, frmMenu
    //  InitRs
    //  ModifPossible
    //  
    //  InitGridHaut
    //  InitGridBas
    //  
    //  bInit = False
    //  
    //  CalculerHT
    //End Sub

    /* OK ---------------------------------------------------------------------*/
    private void cmdFermer_Click(object sender, System.EventArgs e)
    {
      Dispose();
    }
    //Private Sub cmdFermer_Click()
    //
    //  Unload Me
    //
    //End Sub

    /* OK ---------------------------------------------------------------------*/
    private void ModifPossible()
    {
      bModifPossible = true;
      if (miNumElf != 0)
        bModifPossible = (int)ModuleData.ExecuteScalarInt($"SELECT COUNT(*) FROM TAVANCEMENT WHERE NELFNUM > {miNumElf} AND NLDCLPRESTID " +
                                                          $"IN(SELECT NLDCLPRESTID FROM TAVANCEMENT WHERE NELFNUM = {miNumElf})") == 0;
    }
    //Private Sub ModifPossible()
    //Dim rsAvancementPost As ADODB.Recordset
    //
    //  If iNumElf <> 0 Then
    //    Set rsAvancementPost = New ADODB.Recordset
    //    rsAvancementPost.Open "SELECT COUNT(*) FROM TAVANCEMENT WHERE NELFNUM > " & iNumElf & " AND NLDCLPRESTID IN(SELECT NLDCLPRESTID FROM TAVANCEMENT WHERE NELFNUM = " & iNumElf & ")", cnx
    //    If rsAvancementPost(0) = 0 Then
    //      bModifPossible = True
    //    Else
    //      bModifPossible = False
    //    End If
    //  Else
    //    bModifPossible = True
    //  End If
    //
    //End Sub

    /* ---------------------------------------------------------------------*/
    private void InitGridHaut()
    {
      apiGridPrest.AddColumn(Resources.col_ID, "NLDCLPRESTID", 0);
      apiGridPrest.AddColumn(Resources.col_Cat, "CAT", 1000, "", 2);
      apiGridPrest.AddColumn(Resources.col_Code, "VPRESTCODE", 2100, "", 2);
      apiGridPrest.AddColumn(Resources.col_Prestation, "VPRESTLIB", 6500);
      apiGridPrest.AddColumn(Resources.col_Prix_Client, "NPRIXCLITOT", 1500, "Currency", 2);
      apiGridPrest.AddColumn(Resources.col_Avancement_pct, "NAVPOURCENT", 1500, "0.##", 2);
      apiGridPrest.AddColumn(Resources.col_avancement_E, "NAVMONTANT", 1500, "Currency", 2);
      apiGridPrest.AddColumn(Resources.col_pct_N_1, "NAVPRECED", 1000, "", 2);
      apiGridPrest.AddColumn(Resources.col_E_N_1, "NAVMONTPRECED", 1000, "Currency", 2);

      //  si on est en modif, on verifie qu'il n'y ait pas d'avancement postérieur
      if (bModifPossible)
      {
        apiGridPrest.DelockColumn("NAVPOURCENT");
        apiGridPrest.DelockColumn("NAVMONTANT");
      }
      lblAvPost.Visible = !bModifPossible;

      apiGridPrest.InitColumnList();
      apiGridPrest.GridControl.DataSource = dtPrestLocal;
    }
    //Private Sub InitGridHaut()
    //
    //  apiGridPrest.AddColumn "§ID§", "NLDCLPRESTID", 0
    //  apiGridPrest.AddColumn "§Cat§", "CAT", 1000, , 2
    //  apiGridPrest.AddColumn "§Code§", "VPRESTCODE", 1000, , 2
    //  apiGridPrest.AddColumn "§Prestation§", "VPRESTLIB", 8000
    //  apiGridPrest.AddColumn "§Prix client§", "NPRIXCLITOT", 1500, "Currency", 2
    //  apiGridPrest.AddColumn "§Avancement %§", "NAVPOURCENT", 1500, , 2
    //  apiGridPrest.AddColumn "§Avancement €§", "NAVMONTANT", 1500, "Currency", 2
    //  apiGridPrest.AddColumn "§% N-1§", "NAVPRECED", 1500, , 2
    //  apiGridPrest.AddColumn "§€ N-1§", "NAVMONTPRECED", 1500, "Currency", 2
    //  
    //  ' si on est en modif, on verifie qu'il n'y ai pas d'avancement postèrieur
    //  If bModifPossible Then
    //      apiGridPrest.DelockColumn "NAVPOURCENT"
    //      apiGridPrest.DelockColumn "NAVMONTANT"
    //      lblAvPost.Visible = False
    //  Else
    //      lblAvPost.Visible = True
    //  End If
    //    
    //  apiGridPrest.Init rsPrestLocal
    //End Sub

    /* ---------------------------------------------------------------------*/
    private void InitGridBas()
    {
      apiGridAvenantPrest.AddColumn(Resources.col_ID, "NLAVENANTPRESTNUM", 0);
      apiGridAvenantPrest.AddColumn(Resources.col_Avenant, "VAVENANTLIB", 2100);
      apiGridAvenantPrest.AddColumn(Resources.col_Cat, "CAT", 1000);
      apiGridAvenantPrest.AddColumn(Resources.col_Prestation, "VPRESTLIB", 6500);
      apiGridAvenantPrest.AddColumn(Resources.col_Prix_Client, "NPRIXCLITOT", 1500, "Currency", 2);
      apiGridAvenantPrest.AddColumn(Resources.col_Avancement_pct, "NAVPOURCENT", 1500, "0.##", 2);
      apiGridAvenantPrest.AddColumn(Resources.col_avancement_E, "NAVMONTANT", 1500, "Currency", 2);
      apiGridAvenantPrest.AddColumn(Resources.col_E_N_1, "NAVPRECED", 1000, "", 2);
      apiGridAvenantPrest.AddColumn(Resources.col_pct_N_1, "NAVMONTPRECED", 1000, "Currency", 2);

      if (bModifPossible)
      {
        apiGridAvenantPrest.DelockColumn("NAVPOURCENT");
        apiGridAvenantPrest.DelockColumn("NAVMONTANT");
      }

      apiGridAvenantPrest.InitColumnList();
      apiGridAvenantPrest.GridControl.DataSource = dtPrestLocalAV;
    }
    //Private Sub InitGridBas()
    //
    //  apiGridAvenantPrest.AddColumn "§ID§", "NLAVENANTPRESTNUM", 0
    //  apiGridAvenantPrest.AddColumn "§Avenant§", "VAVENANTLIB", 2000
    //  apiGridAvenantPrest.AddColumn "§Cat§", "CAT", 1000
    //  apiGridAvenantPrest.AddColumn "§Prestation§", "VPRESTLIB", 6000
    //  apiGridAvenantPrest.AddColumn "§Prix client§", "NPRIXCLITOT", 1500, "Currency", 2
    //  apiGridAvenantPrest.AddColumn "§Avancement %§", "NAVPOURCENT", 1500, , 2
    //  apiGridAvenantPrest.AddColumn "§Avancement €§", "NAVMONTANT", 1500, "Currency", 2
    //  apiGridAvenantPrest.AddColumn "§% N-1§", "NAVPRECED", 1500, , 2
    //  apiGridAvenantPrest.AddColumn "§€ N-1§", "NAVMONTPRECED", 1500, "Currency", 2
    //  
    //  If bModifPossible Then
    //    apiGridAvenantPrest.DelockColumn "NAVPOURCENT"
    //    apiGridAvenantPrest.DelockColumn "NAVMONTANT"
    //  End If
    //    
    //  apiGridAvenantPrest.Init rsPrestLocalAv
    //End Sub

    /* ---------------------------------------------------------------------*/
    private void InitRs()
    {
      //  recherche du coef de retenue de Garantie
      dRetGar = Utils.ZeroIfNull(ModuleData.ExecuteScalarDouble($"SELECT NDCLQUATHT FROM TDCL WHERE NDCLNUM = {miDevisNum}"));

      InitRsLocal();
      InitRsLocalAv();
    }
    //Private Sub InitRs()
    //Dim rsRetGar As ADODB.Recordset
    //
    //  ' recherche du coef de retenue de Garantie
    //  sSQL = "SELECT NDCLQUATHT FROM TDCL WHERE NDCLNUM = " & iDevisNum
    //  Set rsRetGar = New ADODB.Recordset
    //  rsRetGar.Open sSQL, cnx
    //  
    //  dRetGar = ZeroIfNull(rsRetGar("NDCLQUATHT"))
    //  
    //  rsRetGar.Close
    //  
    //  InitRsLocal
    //  InitRsLocalAv
    //End Sub

    /* ---------------------------------------------------------------------*/
    private void InitRsLocal()
    {
      //EXEMPLE
      // On crée la structure du datatable dtPrestLocal
      dtPrestLocal.Columns.Add("NLDCLPRESTID", typeof(int));
      dtPrestLocal.Columns.Add("CAT", typeof(string));
      dtPrestLocal.Columns.Add("VPRESTCODE", typeof(string));
      dtPrestLocal.Columns.Add("VPRESTLIB", typeof(string));
      dtPrestLocal.Columns.Add("NPRIXCLITOT", typeof(double));
      dtPrestLocal.Columns.Add("NAVPOURCENT", typeof(double));
      dtPrestLocal.Columns.Add("NAVMONTANT", typeof(double));
      dtPrestLocal.Columns.Add("NAVPRECED", typeof(double));
      dtPrestLocal.Columns.Add("NAVMONTPRECED", typeof(double));

      DataTable dtPrest = new DataTable();

      dtPrest.Load(ModuleData.ExecuteReader($"exec api_sp_listePrestDevis {miDevisNum}"));
      string sSql;
      // On remplit le datatable dtPrestLocal avec le contenu du datatble dtPrest renvoyé par la base de données
      foreach (DataRow itemPrest in dtPrest.Rows)
      {
        DataRow newrowPrest = dtPrestLocal.NewRow();

        newrowPrest["NLDCLPRESTID"] = itemPrest["NLDCLPRESTID"];
        newrowPrest["CAT"] = itemPrest["CAT"];
        newrowPrest["VPRESTCODE"] = Utils.BlankIfNull(itemPrest["VPRESTCODE"]);
        newrowPrest["VPRESTLIB"] = itemPrest["VPRESTLIB"];
        newrowPrest["NPRIXCLITOT"] = (Utils.ZeroIfNull(itemPrest["NPRIXCLITOT"]) == 0 ? itemPrest["TOTALCOEF"] : itemPrest["NPRIXCLITOT"]);

        //  on recherche un avancement existant
        if (miNumElf != 0)
        {
          sSql = $"SELECT NAVPOURCENT,NAVMONTANT FROM TAVANCEMENT WHERE NLDCLPRESTID = {itemPrest["NLDCLPRESTID"]} AND NACTNUMCRE IN  (SELECT NACTNUM FROM TACT WHERE NELFNUM = {miNumElf})";
          using (SqlDataReader drAvancement = ModuleData.ExecuteReader(sSql))
          {
            if (drAvancement.Read())
            {
              newrowPrest["NAVPOURCENT"] = Utils.ZeroIfNull(drAvancement["NAVPOURCENT"]);
              newrowPrest["NAVMONTANT"] = Utils.ZeroIfNull(drAvancement["NAVMONTANT"]);
            }
            else
            {
              newrowPrest["NAVPOURCENT"] = 0;
              newrowPrest["NAVMONTANT"] = 0;
            }
          }
        }
        else
        {
          newrowPrest["NAVPOURCENT"] = 0;
          newrowPrest["NAVMONTANT"] = 0;
        }

        sSql = $"SELECT max(NAVPOURCENT), max(NAVMONTANT) FROM TAVANCEMENT WHERE NLDCLPRESTID = {itemPrest["NLDCLPRESTID"]}{(miNumElf == 0 ? "" : " AND NELFNUM < " + miNumElf)} " +
               $"AND NACTNUMBASE in (SELECT NACTNUM FROM TDCL WHERE NDCLNUM = {miDevisNum}) GROUP BY NLDCLPRESTID";
        using (SqlDataReader drAvPreced = ModuleData.ExecuteReader(sSql))
        {
          if (drAvPreced.Read())
          {
            newrowPrest["NAVPRECED"] = drAvPreced[0];
            newrowPrest["NAVMONTPRECED"] = drAvPreced[1];
          }
          else
          {
            newrowPrest["NAVPRECED"] = 0;
            newrowPrest["NAVMONTPRECED"] = 0;
          }
        }
        dtPrestLocal.Rows.Add(newrowPrest);
      }
      CalculerHT();
    }
    //Private Sub InitRsLocal()
    //Dim rsAvancement As ADODB.Recordset
    //Dim rsAvPreced As ADODB.Recordset
    //Dim rsPrest As ADODB.Recordset
    //
    //  Set rsPrest = New ADODB.Recordset
    //  sSQL = "exec api_sp_listePrestDevis " & iDevisNum
    //
    //  rsPrest.Open sSQL, cnx
    //  
    //  Set rsPrestLocal = New ADODB.Recordset
    //  
    //  rsPrestLocal.Fields.Append "NLDCLPRESTID", adInteger
    //  rsPrestLocal.Fields.Append "CAT", adVarChar, 100
    //  rsPrestLocal.Fields.Append "VPRESTCODE", adVarChar, 100
    //  rsPrestLocal.Fields.Append "VPRESTLIB", adVarChar, 8000
    //  rsPrestLocal.Fields.Append "NPRIXCLITOT", adDouble
    //  rsPrestLocal.Fields.Append "NAVPOURCENT", adDouble
    //  rsPrestLocal.Fields.Append "NAVMONTANT", adDouble
    //  rsPrestLocal.Fields.Append "NAVPRECED", adDouble
    //  rsPrestLocal.Fields.Append "NAVMONTPRECED", adDouble
    //  
    //  rsPrestLocal.Open , , adOpenDynamic, adLockOptimistic
    //  
    //  While Not rsPrest.EOF
    //    rsPrestLocal.AddNew
    //    
    //    rsPrestLocal("NLDCLPRESTID").value = rsPrest("NLDCLPRESTID")
    //    rsPrestLocal("CAT").value = rsPrest("CAT")
    //    rsPrestLocal("VPRESTCODE").value = BlankIfNull(rsPrest("VPRESTCODE"))
    //    rsPrestLocal("VPRESTLIB").value = rsPrest("VPRESTLIB")
    //    rsPrestLocal("NPRIXCLITOT").value = IIf(ZeroIfNull(rsPrest("NPRIXCLITOT")) = 0, rsPrest("TOTALCOEF"), rsPrest("NPRIXCLITOT"))
    //    ' on recherche un avancement existant
    //    If iNumElf <> 0 Then
    //      Set rsAvancement = New ADODB.Recordset
    //      sSQL = "SELECT NAVPOURCENT,NAVMONTANT FROM TAVANCEMENT WHERE NLDCLPRESTID = " & rsPrest("NLDCLPRESTID") & " AND NACTNUMCRE IN " _
    //          & " (SELECT NACTNUM FROM TACT WHERE NELFNUM = " & iNumElf & ")"
    //      rsAvancement.Open sSQL, cnx
    //      
    //      rsPrestLocal("NAVPOURCENT").value = ZeroIfNull(rsAvancement("NAVPOURCENT"))
    //      rsPrestLocal("NAVMONTANT").value = ZeroIfNull(rsAvancement("NAVMONTANT"))
    //    End If
    //  
    //    sSQL = "SELECT max(NAVPOURCENT), max(NAVMONTANT) FROM TAVANCEMENT WHERE NLDCLPRESTID = " & rsPrest("NLDCLPRESTID") & IIf(iNumElf = 0, "", " AND NELFNUM < " & iNumElf) _
    //           & " AND NACTNUMBASE in (SELECT NACTNUM FROM TDCL WHERE NDCLNUM = " & iDevisNum & ") GROUP BY NLDCLPRESTID"
    //
    //    Set rsAvPreced = New ADODB.Recordset
    //    rsAvPreced.Open sSQL, cnx
    //    
    //    rsPrestLocal("NAVPRECED").value = IIf(rsAvPreced.RecordCount = 0, 0, rsAvPreced(0))
    //    rsPrestLocal("NAVMONTPRECED").value = IIf(rsAvPreced.RecordCount = 0, 0, rsAvPreced(1))
    //    
    //    
    //    If rsPrestLocal("NAVPOURCENT").value = 0 Then rsPrestLocal("NAVPOURCENT").value = IIf(rsAvPreced.RecordCount = 0, 0, rsAvPreced(0))
    //    If rsPrestLocal("NAVMONTANT").value = 0 Then rsPrestLocal("NAVMONTANT").value = IIf(rsAvPreced.RecordCount = 0, 0, rsAvPreced(1))
    //    
    //    rsPrestLocal.Update
    //    rsPrest.MoveNext
    //  Wend
    //  
    //  CalculerHT
    //  
    //  If rsPrestLocal.RecordCount > 0 Then rsPrestLocal.MoveFirst
    //
    //End Sub
    //

    /* ---------------------------------------------------------------------*/
    private void InitRsLocalAv()
    {
      dtPrestLocalAV.Columns.Add("NLAVENANTPRESTNUM", typeof(int));
      dtPrestLocalAV.Columns.Add("VAVENANTLIB", typeof(string));
      dtPrestLocalAV.Columns.Add("CAT", typeof(string));
      dtPrestLocalAV.Columns.Add("VPRESTLIB", typeof(string));
      dtPrestLocalAV.Columns.Add("NPRIXCLITOT", typeof(double));
      dtPrestLocalAV.Columns.Add("NAVPOURCENT", typeof(double));
      dtPrestLocalAV.Columns.Add("NAVMONTANT", typeof(double));
      dtPrestLocalAV.Columns.Add("NAVPRECED", typeof(double));
      dtPrestLocalAV.Columns.Add("NAVMONTPRECED", typeof(double));

      DataTable dtPrestAV = new DataTable();
      dtPrestAV.Load(ModuleData.ExecuteReader($"exec api_sp_listeAvenantDevis {miDevisNum}, {miNumElf}"));
      foreach (DataRow itemPrest in dtPrestAV.Rows)
      {
        DataRow newrowPrestAV = dtPrestLocalAV.NewRow();

        newrowPrestAV["NLAVENANTPRESTNUM"] = itemPrest["NLAVENANTPRESTNUM"];
        newrowPrestAV["VAVENANTLIB"] = itemPrest["VAVENANTLIB"];
        newrowPrestAV["CAT"] = itemPrest["NCLASSID"];
        newrowPrestAV["VPRESTLIB"] = itemPrest["VPRESTLIB"];
        newrowPrestAV["NPRIXCLITOT"] = Utils.ZeroIfNull(itemPrest["NPRIXCLITOT"]);

        //  initialise à 0 puis modif ensuite
        newrowPrestAV["NAVPOURCENT"] = 0;
        newrowPrestAV["NAVMONTANT"] = 0;
        //  on recherche un avancement existant
        string sSql;
        if (miNumElf != 0)
        {
          sSql = $"SELECT NAVPOURCENT,NAVMONTANT FROM TAVANCEMENT WHERE NLAVENANTPRESTNUM = {itemPrest["NLAVENANTPRESTNUM"]} " +
                 $"AND NACTNUMCRE IN  (SELECT NACTNUM FROM TACT WHERE NELFNUM = {miNumElf})";
          using (SqlDataReader drAvancement = ModuleData.ExecuteReader(sSql))
          {
            if (drAvancement.Read())
            {
              newrowPrestAV["NAVPOURCENT"] = Utils.ZeroIfNull(drAvancement["NAVPOURCENT"]);
              newrowPrestAV["NAVMONTANT"] = Utils.ZeroIfNull(drAvancement["NAVMONTANT"]);
            }
            else
            {
              newrowPrestAV["NAVPOURCENT"] = 0;
              newrowPrestAV["NAVMONTANT"] = 0;
            }
          }
        }
        else
        {
          newrowPrestAV["NAVPOURCENT"] = 0;
          newrowPrestAV["NAVMONTANT"] = 0;
        }
        sSql = "SELECT max(NAVPOURCENT), max(NAVMONTANT) FROM TAVANCEMENT WHERE NLAVENANTPRESTNUM = " + itemPrest["NLAVENANTPRESTNUM"] + (miNumElf == 0 ? "" : " " +
               "AND NELFNUM < " + miNumElf) + " AND NACTNUMBASE in (SELECT NACTNUM FROM TDCL WHERE NDCLNUM = " + miDevisNum + ") GROUP BY NLAVENANTPRESTNUM";
        using (SqlDataReader drAvPreced = ModuleData.ExecuteReader(sSql))
        {
          if (drAvPreced.Read())
          {
            newrowPrestAV["NAVPRECED"] = drAvPreced[0];
            newrowPrestAV["NAVMONTPRECED"] = drAvPreced[1];
            if ((int)newrowPrestAV["NAVPOURCENT"] == 0)
              newrowPrestAV["NAVPOURCENT"] = drAvPreced[0];
            if ((int)newrowPrestAV["NAVMONTANT"] == 0)
              newrowPrestAV["NAVMONTANT"] = drAvPreced[1];
          }
          else
          {
            newrowPrestAV["NAVPRECED"] = 0;
            newrowPrestAV["NAVMONTPRECED"] = 0;
            // Les lignes suivantes sont nécessaires en VB6, mais ici, elles sont inutiles :  newrowPrestAV["NAVPOURCENT"] et newrowPrestAV["NAVMONTANT"] valent déjà 0
            //if ((int)newrowPrestAV["NAVPOURCENT"] == 0)
            //  newrowPrestAV["NAVPOURCENT"] = 0;
            //if ((int)newrowPrestAV["NAVMONTANT"] == 0)
            //  newrowPrestAV["NAVMONTANT"] = 0;
          }
        }
        dtPrestLocalAV.Rows.Add(newrowPrestAV);
      }
      CalculerHT();
    }
    //Private Sub InitRsLocalAv()
    //Dim rsAvancement As ADODB.Recordset
    //Dim rsAvPreced As ADODB.Recordset
    //Dim rsPrest As ADODB.Recordset
    //
    //  Set rsPrest = New ADODB.Recordset
    //  sSQL = "exec api_sp_listeAvenantDevis " & iDevisNum & "," & iNumElf
    //
    //  rsPrest.Open sSQL, cnx
    //  
    //  Set rsPrestLocalAv = New ADODB.Recordset
    //  
    //  rsPrestLocalAv.Fields.Append "NLAVENANTPRESTNUM", adInteger
    //  rsPrestLocalAv.Fields.Append "VAVENANTLIB", adVarChar, 2000
    //  rsPrestLocalAv.Fields.Append "CAT", adVarChar, 100
    //  rsPrestLocalAv.Fields.Append "VPRESTLIB", adVarChar, 8000
    //  rsPrestLocalAv.Fields.Append "NPRIXCLITOT", adDouble
    //  rsPrestLocalAv.Fields.Append "NAVPOURCENT", adDouble
    //  rsPrestLocalAv.Fields.Append "NAVMONTANT", adDouble
    //  rsPrestLocalAv.Fields.Append "NAVPRECED", adDouble
    //  rsPrestLocalAv.Fields.Append "NAVMONTPRECED", adDouble
    //  
    //  rsPrestLocalAv.Open , , adOpenDynamic, adLockOptimistic
    //  
    //  While Not rsPrest.EOF
    //    rsPrestLocalAv.AddNew
    //    
    //    rsPrestLocalAv("NLAVENANTPRESTNUM").value = rsPrest("NLAVENANTPRESTNUM")
    //    rsPrestLocalAv("VAVENANTLIB").value = rsPrest("VAVENANTLIB")
    //    rsPrestLocalAv("CAT").value = rsPrest("NCLASSID")
    //    rsPrestLocalAv("VPRESTLIB").value = rsPrest("VPRESTLIB")
    //    rsPrestLocalAv("VPRESTLIB").value = ZeroIfNull(rsPrest("NPRIXCLITOT"))
    //    
    //    'initialise à 0 puis modif ensuite
    //    rsPrestLocalAv("NAVPOURCENT").value = 0
    //    rsPrestLocalAv("NAVMONTANT").value = 0
    //    ' on recherche un avancement existant
    //    If iNumElf <> 0 Then
    //      Set rsAvancement = New ADODB.Recordset
    //      sSQL = "SELECT NAVPOURCENT,NAVMONTANT FROM TAVANCEMENT WHERE NLAVENANTPRESTNUM = " & rsPrest("NLAVENANTPRESTNUM") & " AND NACTNUMCRE IN " _
    //          & " (SELECT NACTNUM FROM TACT WHERE NELFNUM = " & iNumElf & ")"
    //      rsAvancement.Open sSQL, cnx
    //
    //      If rsAvancement.RecordCount > 0 Then
    //        rsPrestLocalAv("NAVPOURCENT").value = ZeroIfNull(rsAvancement("NAVPOURCENT"))
    //        rsPrestLocalAv("NAVMONTANT").value = ZeroIfNull(rsAvancement("NAVMONTANT"))
    //      End If
    //    End If
    //  
    //    sSQL = "SELECT max(NAVPOURCENT), max(NAVMONTANT) FROM TAVANCEMENT WHERE NLAVENANTPRESTNUM = " & rsPrest("NLAVENANTPRESTNUM") & IIf(iNumElf = 0, "", " AND NELFNUM < " & iNumElf) _
    //           & " AND NACTNUMBASE in (SELECT NACTNUM FROM TDCL WHERE NDCLNUM = " & iDevisNum & ") GROUP BY NLAVENANTPRESTNUM"
    //
    //    Set rsAvPreced = New ADODB.Recordset
    //    rsAvPreced.Open sSQL, cnx
    //    
    //    rsPrestLocalAv("NAVPRECED").value = IIf(rsAvPreced.RecordCount = 0, 0, rsAvPreced(0))
    //    rsPrestLocalAv("NAVMONTPRECED").value = IIf(rsAvPreced.RecordCount = 0, 0, rsAvPreced(1))
    //        
    //    If rsPrestLocalAv("NAVPOURCENT").value = 0 Then rsPrestLocalAv("NAVPOURCENT").value = IIf(rsAvPreced.RecordCount = 0, 0, rsAvPreced(0))
    //    If rsPrestLocalAv("NAVMONTANT").value = 0 Then rsPrestLocalAv("NAVMONTANT").value = IIf(rsAvPreced.RecordCount = 0, 0, rsAvPreced(1))
    //
    //    rsPrestLocalAv.Update
    //    rsPrest.MoveNext
    //  Wend
    //  
    //  CalculerHT
    //  
    //  If rsPrestLocalAv.RecordCount > 0 Then rsPrestLocalAv.MoveFirst
    //
    //End Sub

    /* ---------------------------------------------------------------------*/
    private void cmdEnregistrer_Click(object sender, EventArgs e)
    {
      CalculerHT();
      CreationActionFacturation();
    }
    //Private Sub cmdEnregistrer_Click()
    //  
    //  CalculerHT
    //  CreationActionFacturation
    //  
    //End Sub

    /* ---------------------------------------------------------------------*/
    private void CreationActionFacturation()
    {
      long iActCre;

      try
      {
        // Creation
        if (miNumElf == 0)
        {
          if (MessageBox.Show(Resources.msg_confirm_create_action_facturation, Program.AppTitle, MessageBoxButtons.YesNo, MessageBoxIcon.Question, MessageBoxDefaultButton.Button2) != DialogResult.Yes)
            return;

          // recherche des infos de la DI en cours
          using (SqlDataReader drInfo = ModuleData.ExecuteReader($"SELECT NDINNUM, NACTNUM, NSITNUM, CPRECOD, CTECCOD, CTYPECOD, CACTTYPCONT, CURGCOD " +
                                                                 $"FROM TACT WHERE NACTNUM in (SELECT NACTNUM FROM TDCL WHERE NDCLNUM = {miDevisNum})"))
          {
            drInfo.Read();
            // pour la création ou la modification, c'est la proc stock qui gère
            // création d'une commande
            using (SqlCommand cmd = new SqlCommand("api_sp_creationAction", MozartDatabase.cnxMozart))
            {
              cmd.CommandType = CommandType.StoredProcedure;
              // passage des paramètres
              SqlCommandBuilder.DeriveParameters(cmd);
              // liste des paramètres
              cmd.Parameters["@iDI"].Value = drInfo["NDINNUM"];
              cmd.Parameters["@iAction"].Value = 0;
              cmd.Parameters["@LibAction"].Value = "Facturation par avancement du " + DateTime.Today.ToShortDateString();
              cmd.Parameters["@dDateS"].Value = DateTime.Today.ToShortDateString();
              cmd.Parameters["@iSite"].Value = drInfo["NSITNUM"];
              cmd.Parameters["@cUrg"].Value = drInfo["CURGCOD"];
              cmd.Parameters["@cprest"].Value = drInfo["CPRECOD"];
              cmd.Parameters["@cTech"].Value = drInfo["CTECCOD"];
              cmd.Parameters["@cTypeAct"].Value = drInfo["CTYPECOD"];
              cmd.Parameters["@iDuree"].Value = 0;
              cmd.Parameters["@iValeur"].Value = 0;
              cmd.Parameters["@dDateEx"].Value = DateTime.Today.ToShortDateString();
              cmd.Parameters["@cTypeInter"].Value = "T";
              cmd.Parameters["@iTech"].Value = DBNull.Value;
              cmd.Parameters["@iST"].Value = DBNull.Value;
              cmd.Parameters["@cAttach"].Value = "";
              cmd.Parameters["@vObserv"].Value = "";
              cmd.Parameters["@vOutil"].Value = "";
              cmd.Parameters["@vFour"].Value = "";
              cmd.Parameters["@dDatePla"].Value = DBNull.Value;
              cmd.Parameters["@cEtat"].Value = "E";
              cmd.Parameters["@cNuit"].Value = "N";
              cmd.Parameters["@cCMD"].Value = "N";
              cmd.Parameters["@vDevis"].Value = "";
              cmd.Parameters["@mDevis"].Value = "";
              cmd.Parameters["@vRelFactST"].Value = 0;
              cmd.Parameters["@vFactBudg"].Value = "";
              cmd.Parameters["@vRDV"].Value = "";
              cmd.Parameters["@vNumCde"].Value = "";
              cmd.Parameters["@nGam"].Value = 0;
              cmd.Parameters["@cNacelle"].Value = "N";
              cmd.Parameters["@vMotCle"].Value = "";
              cmd.Parameters["@cTypCont"].Value = drInfo["CACTTYPCONT"];

              // exécuter la commande
              cmd.ExecuteNonQuery();
              // récupération du numéro crée
              iActCre = Convert.ToInt64(cmd.Parameters[0].Value);

              int iActID = (int)ModuleData.ExecuteScalarInt($"SELECT NACTID FROM TACT WHERE NACTNUM = {iActCre}");
              MessageBox.Show(string.Format(Resources.msg_action_created, iActID), Program.AppTitle, MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
            }

            // création du chiffrage correspondant
            using (SqlCommand cmd = new SqlCommand("api_sp_creationElemFact", MozartDatabase.cnxMozart))
            {
              cmd.CommandType = CommandType.StoredProcedure;
              SqlCommandBuilder.DeriveParameters(cmd);

              cmd.Parameters["@iNumElemFact"].Value = miNumElf;
              cmd.Parameters["@iDI"].Value = drInfo["NDINNUM"];
              cmd.Parameters["@nForfait"].Value = Utils.ZeroIfBlank(txtHT.Text.Substring(0, txtHT.Text.Length - 2));  // Pour supprimer le € de la fin
              cmd.Parameters["@nDepl"].Value = 0;
              cmd.Parameters["@iHeures"].Value = 0;
              cmd.Parameters["@TauxDepl"].Value = 0;
              cmd.Parameters["@TauxHeures"].Value = 0;
              cmd.Parameters["@vObserv"].Value = DBNull.Value;
              cmd.Parameters["@cTypeFour"].Value = "F";
              cmd.Parameters["@nFour"].Value = 0;
              cmd.Parameters["@cType"].Value = "AV";

              cmd.ExecuteNonQuery();
              miNumElf = Convert.ToInt64(cmd.Parameters[0].Value);
            }

            ModuleData.CnxExecute($"api_sp_UpdateActionElemFact {miNumElf},{iActCre}, 1");

            // Enregistrement de l'avancement
            foreach (DataRow item in dtPrestLocal.Rows)
              ModuleData.CnxExecute($"INSERT INTO TAVANCEMENT VALUES ({item["NLDCLPRESTID"]}, {iActCre}, {drInfo["NACTNUM"]}, " +
                                    $"{Utils.ZeroIfNull(item["NAVPOURCENT"]).ToString().Replace(",", ".")}, {Utils.ZeroIfNull(item["NAVMONTANT"]).ToString().Replace(",", ".")}, {miNumElf}, 0)");
            // Enregistrement de l'avancement avenant
            foreach (DataRow item in dtPrestLocalAV.Rows)
              ModuleData.CnxExecute($"INSERT INTO TAVANCEMENT VALUES (0,{iActCre},{drInfo["NACTNUM"]},{Utils.ZeroIfNull(item["NAVPOURCENT"]).ToString().Replace(",", ".")}," +
                                    $"{Utils.ZeroIfNull(item["NAVMONTANT"]).ToString().Replace(",", ".")},{miNumElf},{item["NLAVENANTPRESTNUM"]})");
          }
        }
        // Modification
        else
        {
          using (SqlDataReader drInfo = ModuleData.ExecuteReader($"SELECT NACTNUM, NDINNUM FROM TACT WHERE NELFNUM = {miNumElf}"))
          {
            drInfo.Read();

            // modif du chiffrage
            using (SqlCommand cmd = new SqlCommand("api_sp_creationElemFact", MozartDatabase.cnxMozart))
            {
              cmd.CommandType = CommandType.StoredProcedure;
              SqlCommandBuilder.DeriveParameters(cmd);

              cmd.Parameters["@iNumElemFact"].Value = miNumElf;
              cmd.Parameters["@iDI"].Value = drInfo["NDINNUM"];
              cmd.Parameters["@nForfait"].Value = Utils.ZeroIfBlank(txtHT.Text.Substring(0, txtHT.Text.Length - 2));  // Pour supprimer le € de la fin
              cmd.Parameters["@nDepl"].Value = 0;
              cmd.Parameters["@iHeures"].Value = 0;
              cmd.Parameters["@TauxDepl"].Value = 0;
              cmd.Parameters["@TauxHeures"].Value = 0;
              cmd.Parameters["@vObserv"].Value = DBNull.Value;
              cmd.Parameters["@cTypeFour"].Value = "F";
              cmd.Parameters["@nFour"].Value = 0;
              cmd.Parameters["@cType"].Value = "AV";

              cmd.ExecuteNonQuery();
              miNumElf = Convert.ToInt64(cmd.Parameters[0].Value);
            }

            // modif de l'avancement
            // suppression de l'ancien avancement et création du nouveau suppression de l'ancien avancement et création du nouveau car il est possible
            // que le devis prestation ait ete modifié
            using (SqlDataReader drAv = ModuleData.ExecuteReader($"SELECT TOP 1 NACTNUMBASE, NACTNUMCRE FROM TAVANCEMENT WHERE NELFNUM = {miNumElf}"))
            {
              if (drAv.Read())
              {
                // on supprime uniquement les ligne d'avancement
                ModuleData.CnxExecute($"DELETE TAVANCEMENT WHERE NELFNUM = {miNumElf}");

                foreach (DataRow item in dtPrestLocal.Rows)
                  ModuleData.CnxExecute($"INSERT INTO TAVANCEMENT VALUES ({item["NLDCLPRESTID"]}, {drAv["NACTNUMCRE"]}, {drAv["NACTNUMBASE"]}, " +
                                        $"{Utils.ZeroIfNull(item["NAVPOURCENT"]).ToString().Replace(",", ".")}, {Utils.ZeroIfNull(item["NAVMONTANT"]).ToString().Replace(",", ".")}, {miNumElf}, 0)");
                // Enregistrement de l'avancement avenant
                foreach (DataRow item in dtPrestLocalAV.Rows)
                  ModuleData.CnxExecute($"INSERT INTO TAVANCEMENT VALUES (0, {drAv["NACTNUMCRE"]}, {drAv["NACTNUMBASE"]}, {Utils.ZeroIfNull(item["NAVPOURCENT"]).ToString().Replace(",", ".")}, " +
                                        $"{Utils.ZeroIfNull(item["NAVMONTANT"]).ToString().Replace(",", ".")}, {miNumElf}, {item["NLAVENANTPRESTNUM"]})");

                // Mise à jour du NACTVAL sur l'action de facturation
                ModuleData.CnxExecute($"UPDATE TACT SET NACTVAL = {double.Parse(txtHT.Text, NumberStyles.Currency).ToString().Replace(",", ".")} WHERE NACTNUM = {drAv["NACTNUMCRE"]}");
              }
            }
          }
        }
      }
      catch (Exception ex)
      {
        MZUtils.displayError(MethodBase.GetCurrentMethod().Name, ex);
      }
    }
    //Private Sub CreationActionFacturation()
    //
    //Dim rsAction As New ADODB.Recordset
    //Dim rsElf As New ADODB.Recordset
    //Dim rsInfo As New ADODB.Recordset
    //Dim iActCre As Long
    //
    //  On Error GoTo Handler
    //
    //  ' Creation
    //  If iNumElf = 0 Then
    //  
    //    If MsgBox("§Etes-vous sûre de vouloir créer cette action de facturation?§", vbYesNo) = vbNo Then Exit Sub
    //  
    //    'recherche des infos de la DI en cours
    //    sSQL = "SELECT NDINNUM, NACTNUM, NSITNUM, CPRECOD, CTECCOD, CTYPECOD, CACTTYPCONT, CURGCOD FROM TACT WHERE NACTNUM in (SELECT NACTNUM FROM TDCL WHERE NDCLNUM = " & iDevisNum & ")"
    //    rsInfo.Open sSQL, cnx
    //  
    //    ' pour la création ou la modification, c'est la proc stock qui gère
    //    ' création d'une commande
    //    Set ado_cmd.ActiveConnection = cnx
    //   
    //     ' passage du nom de la procédure stockée
    //    ado_cmd.CommandText = "api_sp_creationAction"
    //    ado_cmd.CommandType = adCmdStoredProc
    //  
    //    ' passage des paramètres
    //    ado_cmd.Parameters.Refresh
    //  
    //     ' liste des paramètres
    //    ado_cmd.Parameters("@iDI").value = rsInfo("NDINNUM")
    //    ado_cmd.Parameters("@iAction").value = 0
    //    ado_cmd.Parameters("@LibAction").value = "Facturation par avancement du " & Date
    //    ado_cmd.Parameters("@dDateS").value = Date
    //    ado_cmd.Parameters("@iSite").value = rsInfo("NSITNUM")
    //    ado_cmd.Parameters("@cUrg").value = rsInfo("CURGCOD")
    //    ado_cmd.Parameters("@cprest").value = rsInfo("CPRECOD")
    //    ado_cmd.Parameters("@cTech").value = rsInfo("CTECCOD")
    //    ado_cmd.Parameters("@cTypeAct").value = rsInfo("CTYPECOD")
    //    ado_cmd.Parameters("@iDuree").value = 0
    //    ado_cmd.Parameters("@iValeur").value = 0
    //    ado_cmd.Parameters("@dDateEx").value = Date
    //    ado_cmd.Parameters("@cTypeInter").value = "T"
    //    ado_cmd.Parameters("@iTech").value = Null
    //    ado_cmd.Parameters("@iST").value = Null
    //    ado_cmd.Parameters("@cAttach").value = ""
    //    ado_cmd.Parameters("@vObserv").value = ""
    //    ado_cmd.Parameters("@vOutil").value = ""
    //    ado_cmd.Parameters("@vFour").value = ""
    //    ado_cmd.Parameters("@dDatePla").value = Null
    //    ado_cmd.Parameters("@cEtat").value = "E"
    //    ado_cmd.Parameters("@cNuit").value = "N"
    //    ado_cmd.Parameters("@cCMD").value = "N"
    //    ado_cmd.Parameters("@vDevis").value = ""
    //    ado_cmd.Parameters("@mDevis").value = ""
    //    ado_cmd.Parameters("@vRelFactST").value = 0
    //    ado_cmd.Parameters("@vFactBudg").value = ""
    //    ado_cmd.Parameters("@vRDV").value = ""
    //    ado_cmd.Parameters("@vNumCde").value = ""
    //    ado_cmd.Parameters("@nGam").value = 0
    //    ado_cmd.Parameters("@cNacelle").value = "N"
    //    ado_cmd.Parameters("@vMotCle").value = ""
    //    ado_cmd.Parameters("@cTypCont").value = rsInfo("CACTTYPCONT")
    //  
    //    ' exécuter la commande
    //    ado_cmd.Execute
    //  
    //    ' récupération du numéro crée
    //    iActCre = ado_cmd.Parameters(0).value
    //  
    //    Set rsAction = New ADODB.Recordset
    //    rsAction.Open "SELECT NACTID FROM TACT WHERE NACTNUM = " & iActCre, cnx
    //    MsgBox "§L'action n°§" & rsAction("NACTID") & "§ a été créée dans cette DI§"
    //    rsAction.Close
    //    Set rsAction = Nothing
    //    
    //    ' création du chiffrage correspondant
    //  
    //    ' création d'une commande
    //    Set ado_cmd.ActiveConnection = cnx
    //  
    //    ' passage du nom de la procédure stockée
    //    ado_cmd.CommandText = "api_sp_creationElemFact"
    //    ado_cmd.CommandType = adCmdStoredProc
    //  
    //    ' passage des paramètres
    //    ado_cmd.Parameters.Refresh
    //  
    //    ' liste des paramètres
    //    ado_cmd.Parameters("@iNumElemFact").value = iNumElf
    //    ado_cmd.Parameters("@iDI").value = rsInfo("NDINNUM")
    //    ado_cmd.Parameters("@nForfait").value = txtHT
    //    ado_cmd.Parameters("@nDepl").value = 0
    //    ado_cmd.Parameters("@iHeures").value = 0
    //    ado_cmd.Parameters("@TauxDepl").value = 0
    //    ado_cmd.Parameters("@TauxHeures").value = 0
    //    ado_cmd.Parameters("@vObserv").value = Null
    //    ado_cmd.Parameters("@cTypeFour").value = "F"
    //    ado_cmd.Parameters("@nFour").value = 0
    //    ado_cmd.Parameters("@cType").value = "AV"
    //    
    //    ' exécuter la commande.
    //    Set rsElf = ado_cmd.Execute()
    //  
    //    ' récupération du numéro crée
    //    iNumElf = ado_cmd.Parameters(0).value
    //  
    //    ' libération de la commande
    //    Set ado_cmd = Nothing
    //  
    //    cnx.Execute "api_sp_UpdateActionElemFact " & iNumElf & "," & iActCre & ", 1"
    //  
    //    ' libération de la commande
    //    Set ado_cmd = Nothing
    //    
    //    ' Enregistrement de l'avancement
    //    If rsPrestLocal.RecordCount > 0 Then
    //      rsPrestLocal.MoveFirst
    //      While Not rsPrestLocal.EOF
    //        sSQL = "INSERT INTO TAVANCEMENT VALUES (" & rsPrestLocal("NLDCLPRESTID") & "," & iActCre & "," & rsInfo("NACTNUM") & "," _
    //             & Replace(rsPrestLocal("NAVPOURCENT"), ",", ".") & "," & Replace(rsPrestLocal("NAVMONTANT"), ",", ".") & "," & iNumElf & ",0)"
    //        
    //        cnx.Execute sSQL
    //        
    //        rsPrestLocal.MoveNext
    //      Wend
    //    End If
    //  
    //    ' Enregistrement de l'avancement avenant
    //    If rsPrestLocalAv.RecordCount > 0 Then
    //      rsPrestLocalAv.MoveFirst
    //      While Not rsPrestLocalAv.EOF
    //        sSQL = "INSERT INTO TAVANCEMENT VALUES (0," & iActCre & "," & rsInfo("NACTNUM") & "," _
    //             & Replace(rsPrestLocalAv("NAVPOURCENT"), ",", ".") & "," & Replace(rsPrestLocalAv("NAVMONTANT"), ",", ".") & "," & iNumElf & "," & rsPrestLocalAv("NLAVENANTPRESTNUM") & ")"
    //        
    //        cnx.Execute sSQL
    //        
    //        rsPrestLocalAv.MoveNext
    //      Wend
    //    End If
    //  
    //  ' Modification
    //  Else
    //  
    //    sSQL = "SELECT NACTNUM, NDINNUM FROM TACT WHERE NELFNUM = " & iNumElf
    //    rsInfo.Open sSQL, cnx
    //  
    //    ' modif du chiffrage
    //    ' création d'une commande
    //    Set ado_cmd.ActiveConnection = cnx
    //  
    //    ' passage du nom de la procédure stockée
    //    ado_cmd.CommandText = "api_sp_creationElemFact"
    //    ado_cmd.CommandType = adCmdStoredProc
    //  
    //    ' passage des paramètres
    //    ado_cmd.Parameters.Refresh
    //  
    //    ' liste des paramètres
    //    ado_cmd.Parameters("@iNumElemFact").value = iNumElf
    //    ado_cmd.Parameters("@iDI").value = rsInfo("NDINNUM")
    //    ado_cmd.Parameters("@nForfait").value = txtHT
    //    ado_cmd.Parameters("@nDepl").value = 0
    //    ado_cmd.Parameters("@iHeures").value = 0
    //    ado_cmd.Parameters("@TauxDepl").value = 0
    //    ado_cmd.Parameters("@TauxHeures").value = 0
    //    ado_cmd.Parameters("@vObserv").value = Null
    //    ado_cmd.Parameters("@cTypeFour").value = "F"
    //    ado_cmd.Parameters("@nFour").value = 0
    //    ado_cmd.Parameters("@cType").value = "AV"
    //    
    //    ' exécuter la commande.
    //    Set rsElf = ado_cmd.Execute()
    //  
    //    ' récupération du numéro crée
    //    iNumElf = ado_cmd.Parameters(0).value
    //  
    //    ' libération de la commande
    //    Set ado_cmd = Nothing
    //    
    //    ' modif de l'avancement
    //    ' suppression de l'ancien avancement et création du nouveau
    //    ' car il est possible que le devis prestation ait ete modifié
    //    rsInfo.Close
    //    sSQL = "SELECT TOP 1 NACTNUMBASE, NACTNUMCRE FROM TAVANCEMENT WHERE NELFNUM = " & iNumElf
    //    rsInfo.Open sSQL, cnx
    //    
    //    ' on supprime uniquement les ligne d'avancement
    //    sSQL = "DELETE TAVANCEMENT WHERE NELFNUM = " & iNumElf
    //    cnx.Execute sSQL
    //    
    //    If rsPrestLocal.RecordCount > 0 Then
    //      rsPrestLocal.MoveFirst
    //      While Not rsPrestLocal.EOF
    //        sSQL = "INSERT INTO TAVANCEMENT VALUES (" & rsPrestLocal("NLDCLPRESTID") & "," & rsInfo("NACTNUMCRE") & "," & rsInfo("NACTNUMBASE") & "," _
    //             & Replace(rsPrestLocal("NAVPOURCENT"), ",", ".") & "," & Replace(rsPrestLocal("NAVMONTANT"), ",", ".") & "," & iNumElf & ",0)"
    //        
    //        cnx.Execute sSQL
    //        
    //        rsPrestLocal.MoveNext
    //      Wend
    //    End If
    //    
    //          ' Enregistrement de l'avancement avenant
    //    If rsPrestLocalAv.RecordCount > 0 Then
    //      rsPrestLocalAv.MoveFirst
    //      While Not rsPrestLocalAv.EOF
    //        sSQL = "INSERT INTO TAVANCEMENT VALUES (0," & rsInfo("NACTNUMCRE") & "," & rsInfo("NACTNUMBASE") & "," _
    //             & Replace(rsPrestLocalAv("NAVPOURCENT"), ",", ".") & "," & Replace(rsPrestLocalAv("NAVMONTANT"), ",", ".") & "," & iNumElf & "," & rsPrestLocalAv("NLAVENANTPRESTNUM") & ")"
    //        
    //        cnx.Execute sSQL
    //        
    //        rsPrestLocalAv.MoveNext
    //      Wend
    //    End If
    //    
    //    ' mise à jour du NACTVAl sur l'action de facturation
    //    sSQL = "UPDATE TACT SET NACTVAL = " & Replace(txtHT, ",", ".") & " WHERE NACTNUM = " & rsInfo("NACTNUMCRE")
    //    cnx.Execute sSQL
    //    
    //  End If
    //  
    //Exit Sub
    //Resume
    //Handler:
    //  ShowError "CreationActionFacturation dans " & Me.Name
    //End Sub

    /* ---------------------------------------------------------------------*/
    private void CalculerHT()
    {
      double TotalPrixCli = 0;
      foreach (DataRow item in dtPrestLocal.Rows)
      {
        if (Utils.ZeroIfNull(item["NAVMONTANT"]) != 0)
        {
          string sSql;
          //  on soustrait le montant total déjà chiffré
          if (Utils.ZeroIfNull(item["NAVMONTANT"]) >= 0)
            sSql = $"SELECT max(NAVMONTANT) AS SOM FROM TAVANCEMENT WHERE NLDCLPRESTID = {item["NLDCLPRESTID"]}{(miNumElf != 0 ? " AND NELFNUM < " + miNumElf : "")}";
          else
            sSql = $"SELECT min(NAVMONTANT) AS SOM FROM TAVANCEMENT WHERE NLDCLPRESTID = {item["NLDCLPRESTID"]}{(miNumElf != 0 ? " AND NELFNUM < " + miNumElf : "")}";

          double? dSomme = ModuleData.ExecuteScalarDouble(sSql);
          TotalPrixCli += Utils.ZeroIfNull(item["NAVMONTANT"]) - (null == dSomme ? 0 : (double)dSomme);
        }
      }

      //  on ne prend pas en compte la retenue de garantie
      //  on ajoute les avenants
      if (!bInit)
      {
        foreach (DataRow item in dtPrestLocalAV.Rows)
        {
          if (Utils.ZeroIfNull(item["NAVMONTANT"]) != 0)
            TotalPrixCli += Utils.ZeroIfNull(item["NAVMONTANT"]) - Utils.ZeroIfNull(item["NAVMONTPRECED"]);
        }
      }

      txtHT.Text = TotalPrixCli.ToString("C2");
    }
    //Private Sub CalculerHT()
    //Dim TotalPrixCli As Double
    //Dim iPosition As Integer
    //Dim rsPreced As ADODB.Recordset
    //
    //  iPosition = rsPrestLocal.AbsolutePosition
    //  
    //  If rsPrestLocal.RecordCount > 0 Then
    //    rsPrestLocal.MoveFirst
    //    While Not rsPrestLocal.EOF
    //      If ZeroIfNull(rsPrestLocal("NAVMONTANT")) <> 0 Then
    //        ' on soustrait le montant total déjà chiffré
    //        If ZeroIfNull(rsPrestLocal("NAVMONTANT")) >= 0 Then
    //          sSQL = "SELECT max(NAVMONTANT) AS SOM FROM TAVANCEMENT WHERE NLDCLPRESTID = " & rsPrestLocal("NLDCLPRESTID") _
    //              & IIf(iNumElf <> 0, " AND NELFNUM < " & iNumElf, "")
    //        Else
    //          sSQL = "SELECT min(NAVMONTANT) AS SOM FROM TAVANCEMENT WHERE NLDCLPRESTID = " & rsPrestLocal("NLDCLPRESTID") _
    //              & IIf(iNumElf <> 0, " AND NELFNUM < " & iNumElf, "")
    //        End If
    //        Set rsPreced = New ADODB.Recordset
    //        
    //        rsPreced.Open sSQL, cnx
    //        
    //        TotalPrixCli = TotalPrixCli + CDbl(ZeroIfNull(rsPrestLocal("NAVMONTANT"))) - CDbl(ZeroIfNull(rsPreced("SOM")))
    //        rsPreced.Close
    //      End If
    //      rsPrestLocal.MoveNext
    //    Wend
    //    rsPrestLocal.MoveFirst
    //  End If
    //  
    //  rsPrestLocal.AbsolutePosition = IIf(iPosition < 0, 1, iPosition)
    //  
    //  ' on ne prend pas en compte la retenue de garantie
    //  'txtHT = Round(TotalPrixCli - (TotalPrixCli * (dRetGar / 100)), 2)
    //  
    //  ' on ajoute les avenants
    //  If Not bInit Then
    //    If rsPrestLocalAv.RecordCount > 0 Then
    //      iPosition = rsPrestLocalAv.AbsolutePosition
    //      
    //      rsPrestLocalAv.MoveFirst
    //      While Not rsPrestLocalAv.EOF
    //        If ZeroIfNull(rsPrestLocalAv("NAVMONTANT")) <> 0 Then
    //          TotalPrixCli = TotalPrixCli + CDbl(rsPrestLocalAv("NAVMONTANT")) - CDbl(rsPrestLocalAv("NAVMONTPRECED"))
    //        End If
    //          rsPrestLocalAv.MoveNext
    //      Wend
    //      
    //      rsPrestLocalAv.AbsolutePosition = IIf(iPosition < 0, 1, iPosition)
    //    End If
    //  End If
    //  
    //  txtHT = Round(TotalPrixCli, 2)
    //End Sub

    //0 références, et mentionné nulle part dans le fichier, même en commentaires --> ?

    /* ---------------------------------------------------------------------*/
    private void apiGridPrest_CellValueChanged(object sender, DevExpress.XtraGrid.Views.Base.CellValueChangedEventArgs e)
    {
      int ColIndex = e.Column.ColumnHandle;
      DataRow row = apiGridPrest.GetFocusedDataRow();
      if (null == row) return;

      // verification de saisie avancement
      if (ColIndex == 5)
      {
        if (Utils.ZeroIfNull(row["NAVPOURCENT"]) <= Utils.ZeroIfNull(row["NAVPRECED"]) && Utils.ZeroIfNull(row["NAVPRECED"]) != 0)
        {
          MessageBox.Show(Resources.msg_avancement_sup_avancement_precedent, Program.AppTitle, MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
          row["NAVPOURCENT"] = 0;
          row["NAVMONTANT"] = 0;
        }
        if (row["NAVPOURCENT"] == DBNull.Value)
        {
          row["NAVPOURCENT"] = 0;
          row["NAVMONTANT"] = 0;
        }
      }
      else if (ColIndex == 6)
      {
        if (Utils.ZeroIfNull(row["NAVMONTANT"]) <= Utils.ZeroIfNull(row["NAVMONTPRECED"]) && Utils.ZeroIfNull(row["NAVMONTPRECED"]) != 0)
        {
          MessageBox.Show(Resources.msg_avancement_sup_avancement_precedent, Program.AppTitle, MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
          row["NAVPOURCENT"] = 0;
          row["NAVMONTANT"] = 0;
        }
        else if (row["NAVMONTANT"] == DBNull.Value)
        {
          row["NAVPOURCENT"] = 0;
          row["NAVMONTANT"] = 0;
        }
      }
      if (miNumElf == 0)
      {
        if (Utils.ZeroIfNull(row["NAVPOURCENT"]) > 100)
        {
          MessageBox.Show(Resources.msg_total_fac_non_dep_100, Program.AppTitle, MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
          row["NAVPOURCENT"] = 100 - Utils.ZeroIfNull(row["NAVPRECED"]);
        }
        else if (Utils.ZeroIfNull(row["NAVMONTANT"]) > Utils.ZeroIfNull(row["NPRIXCLITOT"]))
        {
          MessageBox.Show(Resources.msg_total_fac_non_dep_100, Program.AppTitle, MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
          row["NAVMONTANT"] = Utils.ZeroIfNull(row["NPRIXCLITOT"]) - Utils.ZeroIfNull(row["NAVMONTPRECED"]);
        }
      }
      else
      {
        if (Utils.ZeroIfNull(row["NAVPOURCENT"]) > 100)
        {
          MessageBox.Show(Resources.msg_total_fac_non_dep_100, Program.AppTitle, MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
          row["NAVPOURCENT"] = 100 - Utils.ZeroIfNull(row["NAVPRECED"]);
        }
        else if (Utils.ZeroIfNull(row["NAVMONTANT"]) > Utils.ZeroIfNull(row["NPRIXCLITOT"]))
        {
          MessageBox.Show(Resources.msg_total_fac_non_dep_100, Program.AppTitle, MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
          row["NAVMONTANT"] = Utils.ZeroIfNull(row["NPRIXCLITOT"]) - Utils.ZeroIfNull(row["NAVMONTPRECED"]);
        }
      }

      // Saisie pourcentage
      if (ColIndex == 5)
      {
        if (Information.IsNumeric(row["NAVPOURCENT"]))
        {
          row["NAVMONTANT"] = (Utils.ZeroIfNull(row["NPRIXCLITOT"]) * Utils.ZeroIfNull(row["NAVPOURCENT"]) / 100).ToString("0.00");
          CalculerHT();
        }
      }

      // Saisie montant
      else if (ColIndex == 6)
      {
        if (Information.IsNumeric(row["NAVMONTANT"]))
        {
          row["NAVPOURCENT"] = (Utils.ZeroIfNull(row["NAVMONTANT"]) * 100 / Utils.ZeroIfNull(row["NPRIXCLITOT"])).ToString("0.00");
          CalculerHT();
        }
      }
    }
    //Private Sub apiGridPrest_AfterColUpdate(ColIndex As Integer)
    //Dim iPos As Long
    //
    //  iPos = rsPrestLocal.AbsolutePosition
    //
    //  ' verification de saisie avancement
    //  If rsPrestLocal.RecordCount > 0 Then
    //    If ColIndex = 5 Then
    //      If rsPrestLocal("NAVPOURCENT") <= rsPrestLocal("NAVPRECED") And rsPrestLocal("NAVPRECED") <> 0 Then
    //        MsgBox ("§L'avancement doit être supèrieur à l'avancement précédent§")
    //        rsPrestLocal("NAVPOURCENT") = 0
    //        rsPrestLocal("NAVMONTANT") = 0
    //      End If
    //    ElseIf ColIndex = 6 Then
    //      If rsPrestLocal("NAVMONTANT") <= rsPrestLocal("NAVMONTPRECED") And rsPrestLocal("NAVMONTPRECED") <> 0 Then
    //        MsgBox ("§L'avancement doit être supèrieur à l'avancement précédent§")
    //        rsPrestLocal("NAVPOURCENT") = 0
    //        rsPrestLocal("NAVMONTANT") = 0
    //      End If
    //    End If
    //    If iNumElf = 0 Then
    //        If rsPrestLocal("NAVPOURCENT") > 100 Then
    //          MsgBox ("§Le total de facturation ne doit pas dépasser 100%§")
    //          rsPrestLocal("NAVPOURCENT") = 100 - rsPrestLocal("NAVPRECED")
    //        End If
    //    Else
    //      If rsPrestLocal("NAVPOURCENT") > 100 Then
    //        MsgBox ("§Le total de facturation ne doit pas dépasser 100%§")
    //        rsPrestLocal("NAVPOURCENT") = 100 - rsPrestLocal("NAVPRECED")
    //      End If
    //    End If
    //  End If
    // 
    // ' Saisie pourcentage
    // If ColIndex = 5 Then
    //  If IsNumeric(rsPrestLocal("NAVPOURCENT")) Then
    //    rsPrestLocal("NAVMONTANT") = CDbl(FormatNumber(CDbl(rsPrestLocal("NPRIXCLITOT")) * (CDbl(rsPrestLocal("NAVPOURCENT")) / 100), 2))
    //    CalculerHT
    //  End If
    // 
    // ' Saisie montant
    // ElseIf ColIndex = 6 Then
    //  If IsNumeric(rsPrestLocal("NAVMONTANT")) Then
    //    rsPrestLocal("NAVPOURCENT") = CDbl(FormatNumber(((CDbl(rsPrestLocal("NAVMONTANT")) * 100) / CDbl(rsPrestLocal("NPRIXCLITOT"))), 2))
    //    CalculerHT
    //  End If
    // End If
    // 
    // rsPrestLocal.AbsolutePosition = iPos
    //End Sub

    /* ---------------------------------------------------------------------*/
    private void apiGridAvenantPrest_CellValueChanged(object sender, DevExpress.XtraGrid.Views.Base.CellValueChangedEventArgs e)
    {
      int ColIndex = e.Column.ColumnHandle;
      DataRow row = apiGridAvenantPrest.GetFocusedDataRow();
      if (null == row) return;

      // verification de saisie avancement
      if (ColIndex == 5)
      {
        if (Utils.ZeroIfNull(row["NAVPOURCENT"]) <= Utils.ZeroIfNull(row["NAVPRECED"])
          && Utils.ZeroIfNull(row["NAVPRECED"]) != 0)
        {
          MessageBox.Show(Resources.msg_avancement_sup_avancement_precedent, Program.AppTitle, MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
          row["NAVPOURCENT"] = 0;
          row["NAVMONTANT"] = 0;
        }
        else if (row["NAVPOURCENT"] == DBNull.Value)
        {
          row["NAVPOURCENT"] = 0;
          row["NAVMONTANT"] = 0;
        }
      }
      else if (ColIndex == 6)
      {
        if (Utils.ZeroIfNull(row["NAVMONTANT"]) <= Utils.ZeroIfNull(row["NAVMONTPRECED"])
          && Utils.ZeroIfNull(row["NAVMONTPRECED"]) != 0)
        {
          MessageBox.Show(Resources.msg_avancement_sup_avancement_precedent, Program.AppTitle, MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
          row["NAVPOURCENT"] = 0;
          row["NAVMONTANT"] = 0;
        }
        else if (row["NAVMONTANT"] == DBNull.Value)
        {
          row["NAVPOURCENT"] = 0;
          row["NAVMONTANT"] = 0;
        }
      }

      if (miNumElf == 0)
      {
        if (Utils.ZeroIfNull(row["NAVPOURCENT"]) > 100)
        {
          MessageBox.Show(Resources.msg_total_fac_non_dep_100, Program.AppTitle, MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
          row["NAVPOURCENT"] = 100 - Utils.ZeroIfNull(row["NAVPRECED"]);
        }
        else if (Utils.ZeroIfNull(row["NAVMONTANT"]) > Utils.ZeroIfNull(row["NPRIXCLITOT"]))
        {
          MessageBox.Show(Resources.msg_total_fac_non_dep_100, Program.AppTitle, MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
          row["NAVMONTANT"] = Utils.ZeroIfNull(row["NPRIXCLITOT"]);
          row["NAVPOURCENT"] = 100;
        }
      }
      else
      {
        if (Utils.ZeroIfNull(row["NAVPOURCENT"]) > 100)
        {

          MessageBox.Show(Resources.msg_total_fac_non_dep_100, Program.AppTitle, MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
          row["NAVPOURCENT"] = 100 - Utils.ZeroIfNull(row["NAVPRECED"]);
        }
        else if (Utils.ZeroIfNull(row["NAVMONTANT"]) > Utils.ZeroIfNull(row["NPRIXCLITOT"]))
        {
          MessageBox.Show(Resources.msg_total_fac_non_dep_100, Program.AppTitle, MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
          row["NAVMONTANT"] = Utils.ZeroIfNull(row["NPRIXCLITOT"]);
          row["NAVPOURCENT"] = 100;
        }
      }

      // Saisie pourcentage
      if (ColIndex == 5)
      {
        if (Information.IsNumeric(Utils.ZeroIfNull(row["NAVPOURCENT"])))
        {
          row["NAVMONTANT"] = (Utils.ZeroIfNull(row["NPRIXCLITOT"]) * Utils.ZeroIfNull(row["NAVPOURCENT"]) / 100).ToString("0.00");
          CalculerHT();
        }
      }

      // Saisie montant
      else if (ColIndex == 6)
      {
        if (Information.IsNumeric(row["NAVMONTANT"]))
        {
          row["NAVPOURCENT"] = (Utils.ZeroIfNull(row["NAVMONTANT"]) * 100 / Utils.ZeroIfNull(row["NPRIXCLITOT"])).ToString("0.00");
          CalculerHT();
        }
      }
    }
    //Private Sub apiGridAvenantPrest_AfterColUpdate(ColIndex As Integer)
    //Dim iPos As Long
    //
    //  iPos = rsPrestLocalAv.AbsolutePosition
    //
    //  ' verification de saisie avancement
    //  If rsPrestLocalAv.RecordCount > 0 Then
    //    If ColIndex = 5 Then
    //      If rsPrestLocalAv("NAVPOURCENT") <= rsPrestLocalAv("NAVPRECED") And rsPrestLocalAv("NAVPRECED") <> 0 Then
    //        MsgBox ("§L'avancement doit être supèrieur à l'avancement précédent§")
    //        rsPrestLocalAv("NAVPOURCENT") = 0
    //        rsPrestLocalAv("NAVMONTANT") = 0
    //      End If
    //    ElseIf ColIndex = 6 Then
    //      If rsPrestLocalAv("NAVMONTANT") <= rsPrestLocalAv("NAVMONTPRECED") And rsPrestLocalAv("NAVMONTPRECED") <> 0 Then
    //        MsgBox ("§L'avancement doit être supèrieur à l'avancement précédent§")
    //        rsPrestLocalAv("NAVPOURCENT") = 0
    //        rsPrestLocalAv("NAVMONTANT") = 0
    //      End If
    //    End If
    //    If iNumElf = 0 Then
    //        If rsPrestLocalAv("NAVPOURCENT") > 100 Then
    //          MsgBox ("§Le total de facturation ne doit pas dépasser 100%§")
    //          rsPrestLocalAv("NAVPOURCENT") = 100 - rsPrestLocalAv("NAVPRECED")
    //        End If
    //    Else
    //      If rsPrestLocalAv("NAVPOURCENT") > 100 Then
    //        MsgBox ("§Le total de facturation ne doit pas dépasser 100%§")
    //        rsPrestLocalAv("NAVPOURCENT") = 100 - rsPrestLocalAv("NAVPRECED")
    //      End If
    //    End If
    //  End If
    // 
    // ' Saisie pourcentage
    // If ColIndex = 5 Then
    //  If IsNumeric(rsPrestLocalAv("NAVPOURCENT")) Then
    //    rsPrestLocalAv("NAVMONTANT") = CDbl(FormatNumber(CDbl(rsPrestLocalAv("NPRIXCLITOT")) * (CDbl(rsPrestLocalAv("NAVPOURCENT")) / 100), 2))
    //    CalculerHT
    //  End If
    // 
    // ' Saisie montant
    // ElseIf ColIndex = 6 Then
    //  If IsNumeric(rsPrestLocalAv("NAVMONTANT")) Then
    //    rsPrestLocalAv("NAVPOURCENT") = CDbl(FormatNumber(((CDbl(rsPrestLocalAv("NAVMONTANT")) * 100) / CDbl(rsPrestLocalAv("NPRIXCLITOT"))), 2))
    //    CalculerHT
    //  End If
    // End If
    // 
    // rsPrestLocalAv.AbsolutePosition = iPos
    //End Sub
  }
}