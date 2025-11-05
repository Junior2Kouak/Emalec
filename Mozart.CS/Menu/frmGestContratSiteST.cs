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
  public partial class frmGestContratSiteST : Form
  {
    DataTable dt1 = new DataTable();
    DataTable dt2 = new DataTable();
    DataTable dt3 = new DataTable();
    //Dim rs1 As ADODB.Recordset
    //Dim rs2 As ADODB.Recordset
    //Dim rs3 As ADODB.Recordset

    public int miNumClient;
    public string msNomClient;
    public string msActif;
    //Public miNumClient As Integer
    //Public msNomClient As String
    //Public sActif As String

    public int miSousTraitant;
    public int miContact;
    //Public miSoustraitant As Long
    //Public miContact As Long

    string sSQL;
    //Dim sSQL As String

    public frmGestContratSiteST() { InitializeComponent(); }
    /*--------------------------------------------------------------*/
    private void frmGestContratSiteST_Load(object sender, System.EventArgs e)
    {
      try
      {
        Cursor.Current = Cursors.WaitCursor;
        ModuleMain.Initboutons(this);

        //Affichage du client
        lblClient.Text = msNomClient;

        mnuSTun.Text = Resources.txt_Affecter_ST_Site;
        mnuSTtous.Text = Resources.txt_Affecter_ST_Tous_Sites;
        mnuSupUn.Text = Resources.txt_Supp_ST_Site;
        mnuSupTous.Text = Resources.txt_Supp_ST_Tous_Sites;

        //recordset primaire : liste des contrats actifs
        ApiGridCtr.LoadData(dt1, MozartDatabase.cnxMozart, $"api_sp_ListeContratClient {miNumClient}");
        ApiGridCtr.GridControl.DataSource = dt1;
        InitApigridCtr();

        DataRow row1 = ApiGridCtr.GetFocusedDataRow();
        if (row1 == null) return;

        //recordset secondaire : liste des sites par contrat
        //première ligne par défaut
        //modif le 06/04/2007 Greg : Pour Fitelec, remplacement du VSITCP par VSITTYPE
        sSQL = "SELECT  VTYPECONTRAT, VSITNOM, NSITNUE, VLIBTYPESITE, VSITPAYS, VSITREG, VSTFNOM, VSTIMPOSE, VCOTRAITANT, TSIT.NSITNUM, TCONT.NINTNUM, TCONT.NTYPECONTRAT FROM" +
               " TSTF INNER JOIN TINT ON TSTF.NSTFNUM = TINT.NSTFNUM RIGHT OUTER JOIN TCONT" +
               " INNER JOIN TSIT ON TCONT.NSITNUM = TSIT.NSITNUM ON TINT.NINTNUM = TCONT.NINTNUM INNER JOIN TREF_TYPECONTRAT ON TCONT.NTYPECONTRAT = TREF_TYPECONTRAT.NTYPECONTRAT" +
               " INNER JOIN TREF_TYPESITE ON TREF_TYPESITE.NTYPESITE = TSIT.NSITTYPE" +
               $" WHERE TCONT.NSITNUM = TSIT.NSITNUM  and csitactif='{msActif}' and TCONT.NTYPECONTRAT ={Utils.ZeroIfNull(row1["NTYPECONTRAT"])}" +
               $" AND TSIT.NCLINUM = {miNumClient} AND (dbo.TCONT.VCONTETAT = 'OUI')" +
               $" AND TREF_TYPECONTRAT.LANGUE = '{MozartParams.Langue}' AND TREF_TYPESITE.LANGUE = '{MozartParams.Langue}' ORDER BY VSITNOM";

        ApiGridSite.LoadData(dt2, MozartDatabase.cnxMozart, sSQL);
        ApiGridSite.GridControl.DataSource = dt2;
        InitApigridSite();

        //recordset tertiaire : liste des contrats par site
        //première ligne par défaut
        DataRow row2 = ApiGridSite.GetFocusedDataRow();
        if (row2 != null)
        {
          sSQL = "select VSITNOM, VTYPECONTRAT, VSTFNOM, VSTIMPOSE, TSIT.NSITNUM, TCONT.NINTNUM, TCONT.NTYPECONTRAT FROM TSTF INNER JOIN" +
                 " TINT ON TSTF.NSTFNUM = TINT.NSTFNUM RIGHT OUTER JOIN TCONT INNER JOIN TREF_TYPECONTRAT ON TCONT.NTYPECONTRAT = TREF_TYPECONTRAT.NTYPECONTRAT" +
                 " INNER JOIN TSIT ON TCONT.NSITNUM = TSIT.NSITNUM ON TINT.NINTNUM = TCONT.NINTNUM" +
                $" WHERE TCONT.NSITNUM = {Utils.ZeroIfNull(row2["NSITNUM"])}" +
                $" AND NCLINUM = {miNumClient} AND (dbo.TCONT.VCONTETAT = 'OUI')" +
                $" AND LANGUE = '{MozartParams.Langue}' ORDER BY VTYPECONTRAT";

          ApiGrid.LoadData(dt3, MozartDatabase.cnxMozart, sSQL);
          ApiGrid.GridControl.DataSource = dt3;
          InitApigrid();
        }
      }
      catch (Exception ex)
      {
        MZUtils.displayError(MethodBase.GetCurrentMethod().Name, ex);
      }
      finally { Cursor.Current = Cursors.Default; }
    }
    /* --------------------------------------------------------------------------------------- */
    //Private Sub Form_Load()
    //' UPGRADE_INFO (#0501): The 'i' member isn't used anywhere in current application.
    //' Dim i As Integer
    //
    //On Error GoTo handler
    //
    //  ' initialisation des boutons
    //  InitBoutons Me, frmMenu
    //
    //  'Affichage du client
    //  lblClient = msNomClient
    //     
    //  ' recordset primaire : liste des contrats actifs
    //  Set rs1 = New ADODB.Recordset
    //  rs1.Open "api_sp_ListeContratClient " & miNumClient, cnx
    //
    //  ' recordset secondaire : liste des sites par contrat
    //  ' première ligne par défaut
    //  ' modif le 06/04/2007 Greg : Pour Fitelec, remplacement du VSITCP par VSITTYPE
    //  sSQL = "SELECT  VTYPECONTRAT, VSITNOM, NSITNUE, VLIBTYPESITE, VSITPAYS, VSITREG, VSTFNOM, VSTIMPOSE, VCOTRAITANT, TSIT.NSITNUM, TCONT.NINTNUM, TCONT.NTYPECONTRAT FROM "
    //  sSQL = sSQL & "TSTF INNER JOIN TINT ON TSTF.NSTFNUM = TINT.NSTFNUM RIGHT OUTER JOIN TCONT "
    //  sSQL = sSQL & "INNER JOIN TSIT ON TCONT.NSITNUM = TSIT.NSITNUM ON TINT.NINTNUM = TCONT.NINTNUM INNER JOIN TREF_TYPECONTRAT ON TCONT.NTYPECONTRAT = TREF_TYPECONTRAT.NTYPECONTRAT "
    //  sSQL = sSQL & " INNER JOIN TREF_TYPESITE ON TREF_TYPESITE.NTYPESITE = TSIT.NSITTYPE "
    //  sSQL = sSQL & " WHERE TCONT.NSITNUM = TSIT.NSITNUM  and csitactif='" & sActif & "' and TCONT.NTYPECONTRAT =" & rs1("NTYPECONTRAT")
    //  sSQL = sSQL & " AND TSIT.NCLINUM = " & miNumClient & " AND (dbo.TCONT.VCONTETAT = 'OUI') "
    //  sSQL = sSQL & " AND TREF_TYPECONTRAT.LANGUE = '" & gstrLangue & "' AND TREF_TYPESITE.LANGUE = '" & gstrLangue & "'  ORDER BY VSITNOM"
    //  
    //  Set rs2 = New ADODB.Recordset
    //  rs2.Open sSQL, cnx, adOpenStatic, adLockOptimistic
    //          
    //  ' recordset tertiaire : liste des contrats par site
    //  ' première ligne par défaut
    //  If Not rs2.EOF Then
    //    sSQL = "select VSITNOM, VTYPECONTRAT, VSTFNOM, VSTIMPOSE, TSIT.NSITNUM, TCONT.NINTNUM, TCONT.NTYPECONTRAT FROM TSTF INNER JOIN"
    //    sSQL = sSQL & " TINT ON TSTF.NSTFNUM = TINT.NSTFNUM RIGHT OUTER JOIN TCONT INNER JOIN TREF_TYPECONTRAT ON TCONT.NTYPECONTRAT = TREF_TYPECONTRAT.NTYPECONTRAT "
    //    sSQL = sSQL & "INNER JOIN TSIT ON TCONT.NSITNUM = TSIT.NSITNUM ON TINT.NINTNUM = TCONT.NINTNUM "
    //    sSQL = sSQL & " WHERE TCONT.NSITNUM =" & rs2("NSITNUM")
    //    sSQL = sSQL & " AND NCLINUM = " & miNumClient & " AND (dbo.TCONT.VCONTETAT = 'OUI') "
    //    sSQL = sSQL & " AND LANGUE = '" & gstrLangue & "' ORDER BY VTYPECONTRAT"
    //    
    //    Set rs3 = New ADODB.Recordset
    //    rs3.Open sSQL, cnx, adOpenStatic, adLockOptimistic
    //  End If
    //  
    //  
    //  InitApigridSite
    //  InitApigrid
    //  InitApigridCtr
    //     
    //  Screen.MousePointer = vbDefault
    //  
    //Exit Sub
    //Resume
    //handler:
    //  Screen.MousePointer = vbDefault
    //  ShowError "Form_Load dans " & Me.Name
    //End Sub
    //
    /* --------------------------------------------------------------------------------------- */
    private void InitApigridCtr()
    {
      ApiGridCtr.AddColumn(Resources.col_Contrat, "CONTRAT", 1600);
      ApiGridCtr.AddColumn("NumContrat", "NTYPECONTRAT", 0);

      ApiGridCtr.InitColumnList();
      ApiGridCtr.DesactiveListe();
    }
    //Private Sub InitApigridCtr()
    //  
    //On Error GoTo handler
    //
    //  ApiGridCtr.AddColumn "§Contrat§", 1600
    //  ApiGridCtr.AddColumn "NumContrat", 0
    //  
    //  ApiGridCtr.Init rs1
    //   
    //  ApiGridCtr.DesactiveListe
    //
    //Exit Sub
    //
    //handler:
    //  ShowError "InitApigridCtr dans " & Me.Name
    //End Sub
    //
    /* --------------------------------------------------------------------------------------- */
    private void InitApigridSite()
    {
      ApiGridSite.AddColumn(Resources.col_Contrat, "VTYPECONTRAT", 1100);
      ApiGridSite.AddColumn(Resources.col_Site, "VSITNOM", 1870);
      ApiGridSite.AddColumn("N°", "NSITNUE", 650, "", 2);
      ApiGridSite.AddColumn(Resources.col_Type, "VLIBTYPESITE", 1000, "", 2);
      ApiGridSite.AddColumn(Resources.col_Pays, "VSITPAYS", 1000, "", 2);
      ApiGridSite.AddColumn(Resources.col_Reg, "VSITREG", 1000);
      ApiGridSite.AddColumn(Resources.col_ST, "VSTFNOM", 1200);
      ApiGridSite.AddColumn("Imposé", "VSTIMPOSE", 900);
      ApiGridSite.AddColumn("Cotraitant", "VCOTRAITANT", 900);
      ApiGridSite.AddColumn("NSITNUM", "NSITNUM", 0);
      ApiGridSite.AddColumn("NINTNUM", "NINTNUM", 0);
      ApiGridSite.AddColumn("NumContrat", "NTYPECONTRAT", 0);

      ApiGridSite.InitColumnList();
      ApiGridSite.DesactiveListe();
    }
    //Private Sub InitApigridSite()
    //  
    //On Error GoTo handler
    //
    //  ApiGridSite.AddColumn "§Contrat§", 1100
    //  ApiGridSite.AddColumn "§Site§", 1870
    //  ApiGridSite.AddColumn "N°", 450, , 2
    //  ApiGridSite.AddColumn "§TYPE§", 1000, , 2
    //  ApiGridSite.AddColumn "§PAYS§", 1000, , 2
    //  ApiGridSite.AddColumn "§REG§", 1000
    //  ApiGridSite.AddColumn "§ST§", 1200
    //  ApiGridSite.AddColumn "Imposé", 700
    //  ApiGridSite.AddColumn "Cotraitant", 900
    //  ApiGridSite.AddColumn "NSITNUM", 0
    //  ApiGridSite.AddColumn "NINTNUM", 0
    //  ApiGridSite.AddColumn "NumContrat", 0
    //  
    //  ApiGridSite.Init rs2
    //  ApiGridSite.DesactiveListe
    //
    //Exit Sub
    //
    //handler:
    //  ShowError "InitApiGridSite dans " & Me.Name
    //End Sub
    //
    /* --------------------------------------------------------------------------------------- */
    private void InitApigrid()
    {
      ApiGrid.AddColumn(Resources.col_Site, "VSITNOM", 1800);
      ApiGrid.AddColumn(Resources.col_Contrat, "VTYPECONTRAT", 1300);
      ApiGrid.AddColumn(Resources.col_ST, "VSTFNOM", 1500);
      ApiGrid.AddColumn("Imposé", "VSTIMPOSE", 700);
      ApiGrid.AddColumn("NSITNUM", "NSITNUM", 0);
      ApiGrid.AddColumn("NINTNUM", "NINTNUM", 0);

      ApiGrid.InitColumnList();
      ApiGrid.DesactiveListe();
    }
    //Private Sub InitApigrid()
    //  
    //On Error GoTo handler
    //
    //  ApiGrid.AddColumn "§Site§", 1800
    //  ApiGrid.AddColumn "§Contrat§", 1300
    //  ApiGrid.AddColumn "§ST§", 1500
    //  ApiGrid.AddColumn "Imposé", 700
    //  ApiGrid.AddColumn "NSITNUM", 0
    //  ApiGrid.AddColumn "NINTNUM", 0
    //  ApiGrid.AddColumn "NumContrat", 0
    //  
    //  ApiGrid.Init rs3
    //  ApiGrid.DesactiveListe
    //  
    //Exit Sub
    //
    //handler:
    //  ShowError "InitApigrid dans " & Me.Name
    //End Sub
    //
    /* --------------------------------------------------------------------------------------- */
    private void ApiGridCtr_SelectionChanged(object sender, DevExpress.Data.SelectionChangedEventArgs e)
    {
      //on sort si il n'y a pas d'enregistrement maitre
      DataRow row1 = ApiGridCtr.GetFocusedDataRow();
      if (row1 == null) return;

      sSQL = "SELECT  VTYPECONTRAT, VSITNOM, NSITNUE, VLIBTYPESITE, VSITPAYS, VSITREG, VSTFNOM, VSTIMPOSE, VCOTRAITANT, TSIT.NSITNUM, TCONT.NINTNUM, TCONT.NTYPECONTRAT FROM" +
             " TSTF INNER JOIN TINT ON TSTF.NSTFNUM = TINT.NSTFNUM RIGHT OUTER JOIN TCONT" +
             " INNER JOIN TSIT ON TCONT.NSITNUM = TSIT.NSITNUM ON TINT.NINTNUM = TCONT.NINTNUM INNER JOIN TREF_TYPECONTRAT ON TCONT.NTYPECONTRAT = TREF_TYPECONTRAT.NTYPECONTRAT" +
             " INNER JOIN TREF_TYPESITE ON TREF_TYPESITE.NTYPESITE = TSIT.NSITTYPE" +
            $" WHERE TCONT.NSITNUM = TSIT.NSITNUM  and csitactif='{msActif}' and TCONT.NTYPECONTRAT ={Utils.ZeroIfNull(row1["NTYPECONTRAT"])}" +
            $" AND TSIT.NCLINUM = {miNumClient} AND (dbo.TCONT.VCONTETAT = 'OUI')" +
            $" AND TREF_TYPECONTRAT.LANGUE = '{MozartParams.Langue}' AND TREF_TYPESITE.LANGUE = '{MozartParams.Langue}' ORDER BY VSITNOM";

      ApiGridSite.LoadData(dt2, MozartDatabase.cnxMozart, sSQL);

      //recordset tertiaire : liste des contrats par site
      //première ligne par défaut
      DataRow row2 = ApiGridSite.GetFocusedDataRow();
      if (row2 != null)
      {
        sSQL = "select VSITNOM, VTYPECONTRAT, VSTFNOM, VSTIMPOSE, TSIT.NSITNUM, TCONT.NINTNUM, TCONT.NTYPECONTRAT FROM TSTF INNER JOIN " +
               " TINT ON TSTF.NSTFNUM = TINT.NSTFNUM RIGHT OUTER JOIN TCONT INNER JOIN TREF_TYPECONTRAT ON TCONT.NTYPECONTRAT = TREF_TYPECONTRAT.NTYPECONTRAT " +
               " INNER JOIN TSIT ON TCONT.NSITNUM = TSIT.NSITNUM ON TINT.NINTNUM = TCONT.NINTNUM " +
              $" WHERE TCONT.NSITNUM = {Utils.ZeroIfNull(row2["NSITNUM"])} " +
              $" AND NCLINUM = {miNumClient} AND (dbo.TCONT.VCONTETAT = 'OUI')" +
              $" AND LANGUE = '{MozartParams.Langue}' ORDER BY VTYPECONTRAT";

        ApiGrid.LoadData(dt3, MozartDatabase.cnxMozart, sSQL);
      }
    }
    //Private Sub ApiGridCtr_Click()
    //
    //On Error GoTo handler
    //  
    //  ' on sort si il n'y a pas d'enregistrement maitre
    //  If rs1.EOF Then Exit Sub
    //  sSQL = "SELECT  VTYPECONTRAT, VSITNOM, NSITNUE, VLIBTYPESITE, VSITPAYS, VSITREG, VSTFNOM, VSTIMPOSE, VCOTRAITANT, TSIT.NSITNUM, TCONT.NINTNUM, TCONT.NTYPECONTRAT FROM "
    //  sSQL = sSQL & "TSTF INNER JOIN TINT ON TSTF.NSTFNUM = TINT.NSTFNUM RIGHT OUTER JOIN TCONT "
    //  sSQL = sSQL & "INNER JOIN TSIT ON TCONT.NSITNUM = TSIT.NSITNUM ON TINT.NINTNUM = TCONT.NINTNUM INNER JOIN TREF_TYPECONTRAT ON TCONT.NTYPECONTRAT = TREF_TYPECONTRAT.NTYPECONTRAT "
    //  sSQL = sSQL & " INNER JOIN TREF_TYPESITE ON TREF_TYPESITE.NTYPESITE = TSIT.NSITTYPE "
    //  sSQL = sSQL & " WHERE TCONT.NSITNUM = TSIT.NSITNUM  and csitactif='" & sActif & "' and TCONT.NTYPECONTRAT =" & rs1("NTYPECONTRAT")
    //  sSQL = sSQL & " AND TSIT.NCLINUM = " & miNumClient & " AND (dbo.TCONT.VCONTETAT = 'OUI') "
    //  sSQL = sSQL & " AND TREF_TYPECONTRAT.LANGUE = '" & gstrLangue & "' AND TREF_TYPESITE.LANGUE = '" & gstrLangue & "' ORDER BY VSITNOM"
    //  
    //  Set rs2 = New ADODB.Recordset
    //  rs2.Open sSQL, cnx, adOpenStatic, adLockOptimistic
    //          
    //  ' recordset tertiaire : liste des contrats par site
    //  ' première ligne par défaut
    //  If Not rs2.EOF Then
    //    sSQL = "select VSITNOM, VTYPECONTRAT, VSTFNOM, VSTIMPOSE, TSIT.NSITNUM, TCONT.NINTNUM, TCONT.NTYPECONTRAT FROM TSTF INNER JOIN"
    //    sSQL = sSQL & " TINT ON TSTF.NSTFNUM = TINT.NSTFNUM RIGHT OUTER JOIN TCONT INNER JOIN TREF_TYPECONTRAT ON TCONT.NTYPECONTRAT = TREF_TYPECONTRAT.NTYPECONTRAT "
    //    sSQL = sSQL & "INNER JOIN TSIT ON TCONT.NSITNUM = TSIT.NSITNUM ON TINT.NINTNUM = TCONT.NINTNUM "
    //    sSQL = sSQL & " WHERE TCONT.NSITNUM =" & rs2("NSITNUM")
    //    sSQL = sSQL & " AND NCLINUM = " & miNumClient & " AND (dbo.TCONT.VCONTETAT = 'OUI') "
    //    sSQL = sSQL & " AND LANGUE = '" & gstrLangue & "' ORDER BY VTYPECONTRAT"
    //    
    //    Set rs3 = New ADODB.Recordset
    //    rs3.Open sSQL, cnx, adOpenStatic, adLockOptimistic
    //  End If
    //  
    //  InitApigrid
    //  InitApigridSite
    //
    //Exit Sub
    //
    //handler:
    //  ShowError "Form_Load dans " & Me.Name
    //End Sub
    //

    private void cmdFermer_Click(object sender, System.EventArgs e)
    {
      Dispose();
    }

    private void ApiGridSite_RowCellClick(object sender, DevExpress.XtraGrid.Views.Grid.RowCellClickEventArgs e)
    {
      DataRow row = ApiGridSite.GetFocusedDataRow();
      if (row == null) return;

      if (e.Button == MouseButtons.Right)
      {
        mnuAffichage.Show(Cursor.Position);
        return;
      }

      if (e.Column.Name == "VSTIMPOSE" || e.Column.Name == "VCOTRAITANT")
      {
        string colName = e.Column.Name;
        string val = "'NON'";
        if (Convert.IsDBNull(row[colName]) || (string)row[colName] == "")
          val = "'NON'";
        else if ((string)row[colName] == "OUI")
          val = "NULL";
        ModuleData.ExecuteNonQuery($"UPDATE TCONT SET {colName} = {val} WHERE NSITNUM={row["NSITNUM"]} AND NTYPECONTRAT={row["NTYPECONTRAT"]}");

        if (val == "NULL") row[colName] = DBNull.Value;
        else row[colName] = val.Replace("'", "");

        if (colName == "VSTIMPOSE") ApiGrid.Requery(dt3, MozartDatabase.cnxMozart);
      }
    }

    private void ApiGridSite_SelectionChanged(object sender, DevExpress.Data.SelectionChangedEventArgs e)
    {
      DataRow row2 = ApiGridSite.GetFocusedDataRow();
      if (row2 == null) return;

      //  recordset tertiaire : liste des contrats par site
      //  première ligne par défaut
      sSQL = "select VSITNOM, VTYPECONTRAT, VSTFNOM, VSTIMPOSE, TSIT.NSITNUM, TCONT.NINTNUM, TCONT.NTYPECONTRAT FROM TSTF INNER JOIN " +
             " TINT ON TSTF.NSTFNUM = TINT.NSTFNUM RIGHT OUTER JOIN TCONT INNER JOIN TREF_TYPECONTRAT ON TCONT.NTYPECONTRAT = TREF_TYPECONTRAT.NTYPECONTRAT " +
             " INNER JOIN TSIT ON TCONT.NSITNUM = TSIT.NSITNUM ON TINT.NINTNUM = TCONT.NINTNUM " +
            $" WHERE TCONT.NSITNUM = {Utils.ZeroIfNull(row2["NSITNUM"])} " +
            $" AND NCLINUM = {miNumClient} AND (dbo.TCONT.VCONTETAT = 'OUI') " +
            $" AND LANGUE = '{MozartParams.Langue}' ORDER BY VTYPECONTRAT";

      ApiGrid.LoadData(dt3, MozartDatabase.cnxMozart, sSQL);
    }

    private void ApiGrid_RowCellClick(object sender, DevExpress.XtraGrid.Views.Grid.RowCellClickEventArgs e)
    {
      DataRow row = ApiGrid.GetFocusedDataRow();
      if (row == null) return;

      if (e.Button == MouseButtons.Right)
        return;

      if (e.Column.Name == "VSTFNOM")
      {
        //ouverture du recordset
        //affichage de l'écran de recherche du ST
        frmRechercheST f = new frmRechercheST();
        f.miContact = (int)Utils.ZeroIfNull(row["NINTNUM"]);
        f.mstrStatut = "T";
        f.mstrType = "ST";
        f.ShowDialog();

        miContact = f.miContact;
        miSousTraitant = f.miSousTraitant;

        //retour avec numéro ST
        if (miSousTraitant != 0)
        {
          //enregistrement du ST dans la table TCONT
          sSQL = $"update TCONT set NINTNUM={miContact} , NSTFNUM={miSousTraitant} " +
                 $"WHERE NSITNUM ={Utils.ZeroIfNull(row["NSITNUM"])} " +
                 $"AND NTYPECONTRAT = '{Utils.ZeroIfNull(row["NTYPECONTRAT"])}'";

          //exécution de la requête
          ModuleData.CnxExecute(sSQL);

          //réinitialisation après
          ApiGridSite.Requery(dt2, MozartDatabase.cnxMozart);
        }
      }
      else if (e.Column.Name == "VSTIMPOSE")
      {
        string VSTIMPOSE = "'NON'";
        if (Convert.IsDBNull(row["VSTIMPOSE"]) || (string)row["VSTIMPOSE"] == "")
          VSTIMPOSE = "'NON'";
        else if ((string)row["VSTIMPOSE"] == "OUI")
          VSTIMPOSE = "NULL";

        ModuleData.ExecuteNonQuery($"UPDATE TCONT SET VSTIMPOSE = {VSTIMPOSE} WHERE NSITNUM={row["NSITNUM"]} AND NTYPECONTRAT={row["NTYPECONTRAT"]}");
        if (VSTIMPOSE == "NULL") row["VSTIMPOSE"] = DBNull.Value;
        else row["VSTIMPOSE"] = VSTIMPOSE.Replace("'", "");

      }
    }

    private void mnuSTtous_Click(object sender, EventArgs e)
    {
      DataRow row = ApiGridSite.GetFocusedDataRow();
      if (row == null) return;

      //ouverture du recordset
      //affichage de l'écran de recherche du ST
      frmRechercheST f = new frmRechercheST();
      f.miContact = (int)Utils.ZeroIfNull(row["NINTNUM"]);
      f.mstrStatut = "T";
      f.mstrType = "ST";
      f.ShowDialog();

      miContact = f.miContact;
      miSousTraitant = f.miSousTraitant;

      //retour avec un numéro de ST
      if (miSousTraitant != 0)
      {
        if (MessageBox.Show(Resources.msg_Demande_Affectation_ST_Tous_Sites, Program.AppTitle, MessageBoxButtons.YesNo, MessageBoxIcon.Question, MessageBoxDefaultButton.Button2) == DialogResult.No)
          return;

        int nb = ApiGridSite.dgv.DataRowCount;
        for (int i = 0; i < nb; i++)
        {
          int h = ApiGridSite.dgv.GetVisibleRowHandle(i);
          DataRow r = ApiGridSite.dgv.GetDataRow(h);
          //enregistrement du ST dans la table TCONT
          sSQL = $"update TCONT set VSTIMPOSE='OUI' , NINTNUM={miContact} , NSTFNUM={miSousTraitant}" +
                 $" WHERE NSITNUM ={r["NSITNUM"]} AND NTYPECONTRAT = '{r["NTYPECONTRAT"]}'";
          ModuleData.CnxExecute(sSQL);
        }

        //réinitialisation après
        ApiGridSite.Requery(dt2, MozartDatabase.cnxMozart);
      }
    }
    private void mnuSTun_Click(object sender, EventArgs e)
    {
      DataRow row = ApiGridSite.GetFocusedDataRow();
      if (row == null) return;

      //ouverture du recordset
      //affichage de l'écran de recherche du ST
      frmRechercheST f = new frmRechercheST();
      f.miContact = (int)Utils.ZeroIfNull(row["NINTNUM"]);
      f.mstrStatut = "T";
      f.mstrType = "ST";
      f.ShowDialog();

      miContact = f.miContact;
      miSousTraitant = f.miSousTraitant;

      //retour avec un numéro de ST
      if (miSousTraitant != 0)
      {
        //enregistrement du ST dans la table TCONT
        sSQL = $"UPDATE TCONT set NINTNUM={miContact} , NSTFNUM={miSousTraitant} " +
               $" WHERE NSITNUM = {row["NSITNUM"]} " +
               $" AND NTYPECONTRAT = '{row["NTYPECONTRAT"]}'";

        //execution de la requête
        ModuleData.CnxExecute(sSQL);

        //réinitialisation après
        ApiGridSite.Requery(dt2, MozartDatabase.cnxMozart);
      }
    }

    private void mnuSupTous_Click(object sender, EventArgs e)
    {
      DataRow row = ApiGridSite.GetFocusedDataRow();
      if (row == null) return;

      if (MessageBox.Show(Resources.msg_Demande_Suppression_Affectation_ST_Tous_Sites, Program.AppTitle, MessageBoxButtons.YesNo, MessageBoxIcon.Question, MessageBoxDefaultButton.Button2) == DialogResult.No)
        return;

      sSQL = "update TCONT set NINTNUM= NULL, VSTIMPOSE=NULL, NSTFNUM=NULL" +
             $" WHERE NSITNUM in (select nsitnum from tsit where nclinum = {miNumClient})" +
             $" AND NTYPECONTRAT = '{row["NTYPECONTRAT"]}'";
      //execution de la requête
      ModuleData.CnxExecute(sSQL);

      //réinitialisation après
      ApiGridSite.Requery(dt2, MozartDatabase.cnxMozart);
    }

    private void mnuSupUn_Click(object sender, EventArgs e)
    {
      DataRow row = ApiGridSite.GetFocusedDataRow();
      if (row == null) return;

      //enregistrement du ST dans la table TCONT
      sSQL = "update TCONT set NINTNUM= NULL, VSTIMPOSE=NULL, NSTFNUM=NULL" +
             $" WHERE NSITNUM ={row["NSITNUM"]}" +
             $" AND NTYPECONTRAT = '{row["NTYPECONTRAT"]}'";

      //execution de la requête
      ModuleData.CnxExecute(sSQL);

      //réinitialisation après
      ApiGridSite.Requery(dt2, MozartDatabase.cnxMozart);
    }
  }
}

