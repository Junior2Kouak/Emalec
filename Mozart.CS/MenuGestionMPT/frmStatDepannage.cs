using MZCtrlResources = MozartControls.Properties.Resources;
using DevExpress.XtraCharts;
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
  public partial class frmStatDepannage : Form
  {

    public string mstrDateTxt0;
    public string mstrDateTxt1;

    DataTable dt1 = new DataTable();
    DataTable dt2 = new DataTable();
    DataTable dt3 = new DataTable();

    //Dim ado_rs As New ADODB.Recordset
    //Dim ado_rsSec As New ADODB.Recordset
    //Dim ado_rsTer As New ADODB.Recordset

    public frmStatDepannage()
    {
      InitializeComponent();
    }

    /* OK -------------------------------------------------------------------------------------*/
    private void frmStatDepannage_Load(object sender, System.EventArgs e)
    {
      string sSQL = "";
      try
      {
        ModuleMain.Initboutons(this);
        Label4.Text = mstrDateTxt0;
        Label6.Text = mstrDateTxt1;

        // détail pour le technicien sur tableau à coté
        // écriture de la requête pour la liste des sites
        sSQL = $"exec api_sp_StatDepannagePers " +
        $" '{mstrDateTxt0}'" +
        $", '{mstrDateTxt1}'";

        // exécuter la commande.
        ApiGrid.LoadData(dt1, MozartDatabase.cnxMozart, sSQL);
        ApiGrid.GridControl.DataSource = dt1;

        // mise en page du datagrid
        InitApigrid();

        if (dt1.Rows.Count <= 0)
        {
          MSChart1.Visible = false;
          Cursor = Cursors.Default;
          return;
        }
        // graphique
        Series series1 = new Series("Dépannage Chart", ViewType.Bar);

        foreach (DataRow dr in dt1.Rows)
        {
          series1.Points.Add(new SeriesPoint(dr[0].ToString(), dr[1].ToString()));
        }

        series1.LegendTextPattern = "{A}";
        MSChart1.Series.Add(series1);

        ChartTitle title = new ChartTitle();
        title.Text = Resources.title_DepannageParPersonnage;
		title.TextColor = System.Drawing.Color.Black;
        MSChart1.Titles.Add(title);

        MSChart1.Legend.Visibility = DevExpress.Utils.DefaultBoolean.False;

        //détail pour le technicien sur tableau à coté
        //création d'une commande
        //écriture de la requête pour la liste des sites
        DataRow currentRow = ApiGrid.GetFocusedDataRow();
        sSQL = $"exec api_sp_StatDetailDepPer '{currentRow[0]}'" +
        $", '{mstrDateTxt0}'" +
        $", '{mstrDateTxt1}'";

        //exécuter la commande.
        ApiGrid2.LoadData(dt2, MozartDatabase.cnxMozart, sSQL);
        ApiGrid2.GridControl.DataSource = dt2;

        //mise en page du datagrid
        InitApigridSec();

        //cumul par jour
        sSQL = $"exec api_sp_StatCumulDepJourPer '{currentRow[0]}'" +
        $", '{mstrDateTxt0}'" +
        $", '{mstrDateTxt1}'";

        //exécuter la commande.
        ApiGrid3.LoadData(dt3, MozartDatabase.cnxMozart, sSQL);
        ApiGrid3.GridControl.DataSource = dt3;

        //mise en page du datagrid
        InitApigridTer();

        Cursor = Cursors.Default;
      }
      catch (Exception ex)
      {
        Cursor = Cursors.Default;
        MZUtils.displayError(MethodBase.GetCurrentMethod().Name, ex);
      }
    }

    //Private Sub Form_Load()
    //    
    //Dim i
    //Dim sSQL
    //
    //On Error GoTo Handler:
    //
    //  InitBoutons Me, frmMenu
    //
    //  If cnxRep.State = adStateOpen Then cnxRep.Close
    //  
    //  ' ouverture connexion
    //  ' cnxRep.Open gstrConnexionStringReplique      NL le 02/06/2016
    //  
    //  ' TB SAMSIC CITY BASE
    //  cnxRep.Open gstrConnexion
    //  ' cnxRep.Open "PROVIDER=SQLOLEDB.1;Initial Catalog=MULTI;Data Source=" & gstrNomServeur & ";trusted_connection=yes;App=" & gstrNomSociete & ";"
    //  cnxRep.CommandTimeout = 150
    //   
    //  Label4.Caption = frmChoixdateDep.txtDateA(0)
    //  Label6.Caption = frmChoixdateDep.txtDateA(1)
    //     
    //  ' détail pour le technicien sur tableau à coté
    //  ' écriture de la requête pour la liste des sites
    //  sSQL = "exec api_sp_StatDepannagePers "
    //  sSQL = sSQL & " '" & frmChoixdateDep.txtDateA(0) & "'"
    //  sSQL = sSQL & ", '" & frmChoixdateDep.txtDateA(1) & "'"
    //
    // ' exécuter la commande.
    //  Set ado_rs = cnxRep.Execute(sSQL)
    // 
    //  ' mise en page du datagrid
    //  InitApigrid
    //    
    //  If ado_rs.EOF Then
    //    MSChart1.Visible = False
    //    Screen.MousePointer = vbDefault
    //    Exit Sub
    //  End If
    //  
    //  ' graphique
    //  ado_rs.MoveFirst
    // 
    // ' affichage du graphique
    //  MSChart1.RowLabel = "§Dépannage par personne§"
    //  
    //  MSChart1.ColumnCount = ado_rs.RecordCount
    //  For i = 1 To ado_rs.RecordCount
    //  
    //    MSChart1.Column = i
    //    MSChart1.ColumnLabel = ado_rs(0)
    //    MSChart1.data = ado_rs(1)
    //    ado_rs.MoveNext
    //    
    //  Next i
    //  
    //  ' on se replace sur le début de l'enregistrement
    //  ado_rs.MoveFirst
    //
    //  ' détail pour le technicien sur tableau à coté
    //  ' création d'une commande
    //  ' écriture de la requête pour la liste des sites
    //  sSQL = "exec api_sp_StatDetailDepPer '" & ado_rs(0) & "'"
    //  sSQL = sSQL & ", '" & frmChoixdateDep.txtDateA(0) & "'"
    //  sSQL = sSQL & ", '" & frmChoixdateDep.txtDateA(1) & "'"
    //
    //  ' exécuter la commande.
    //  Set ado_rsSec = cnxRep.Execute(sSQL)
    //
    //  ' mise en page du datagrid
    //  InitApigridSec
    //
    // ' cumul par jour
    //  sSQL = "exec api_sp_StatCumulDepJourPer '" & ado_rs(0)
    //  sSQL = sSQL & "', '" & frmChoixdateDep.txtDateA(0) & "'"
    //  sSQL = sSQL & ", '" & frmChoixdateDep.txtDateA(1) & "'"
    //
    // ' exécuter la commande.
    //  Set ado_rsTer = cnxRep.Execute(sSQL)
    //
    //  ' mise en page du datagrid
    //  InitApigridTer
    //
    //  Screen.MousePointer = vbDefault
    //  
    //Exit Sub
    //Resume
    //Handler:
    //  Screen.MousePointer = vbDefault
    //  ShowError "Form_Load de " & Me.Name
    //End Sub

    /* OK -------------------------------------------------------------------------------------*/
    private void cmdQuitter_Click(object sender, System.EventArgs e)
    {
      Dispose();
    }

    //Private Sub cmdQuitter_Click()
    //    Unload Me
    //End Sub

    /* OK -------------------------------------------------------------------------------------*/
    private void cmdImprimer_Click(object sender, EventArgs e)
    {
      //affichage curseur
      Cursor = Cursors.WaitCursor;
      this.ImprimerDansWord();
      Cursor = Cursors.Default;
    }

    //Private Sub cmdImprimer_Click()
    //      
    //  ' affichage curseur
    //  Me.MousePointer = vbHourglass
    //  ImprimerDansWord
    //  Me.MousePointer = vbDefault
    //End Sub

    /* jamais appelé -------------------------------------------------------------------------------------*/
    private void cmdStatClient_Click(object sender, EventArgs e)
    {

    }

    //Private Sub cmdStatClient_Click()
    //  
    //  frmStatGraphTech.sNomTech = ado_rs(0)
    //  frmStatGraphTech.miNumTech = ado_rs(2)
    //  frmStatGraphTech.sHeureref = Label8.Caption
    //  frmStatGraphTech.Show vbModal
    //
    //End Sub

    /* OK -------------------------------------------------------------------------------------*/
    private void InitApigrid()
    {
      try
      {
        ApiGrid.AddColumn(Resources.col_Personne, "Expr1", 1200);
        ApiGrid.AddColumn(Resources.col_nbDep, "Expr2", 700, "### ##0", 2);

        ApiGrid.InitColumnList();
      }
      catch (Exception ex)
      {
        MZUtils.displayError(MethodBase.GetCurrentMethod().Name, ex);
      }
    }

    //Private Sub InitApigrid()
    //  
    //On Error GoTo Handler
    //
    //  ApiGrid.AddColumn "§Personne§", 1200
    //  ApiGrid.AddColumn "§Nb dép§", 700, "### ##0", 2
    //    
    //  ApiGrid.Init ado_rs
    //  
    //Exit Sub
    //Handler:
    //  ShowError "InitApigrid dans " & Me.Name
    //End Sub

    /* OK -------------------------------------------------------------------------------------*/
    private void InitApigridSec()
    {
      try
      {
        ApiGrid2.AddColumn(Resources.col_DI, "NDINNUM", 750);
        ApiGrid2.AddColumn(MZCtrlResources.col_Client, "VCLINOM", 1450);
        ApiGrid2.AddColumn(Resources.col_Site, "VSITNOM", 1600);
        ApiGrid2.AddColumn(Resources.col_Action, "VactDES", 3500);

        ApiGrid2.InitColumnList();
      }
      catch (Exception ex)
      {
        MZUtils.displayError(MethodBase.GetCurrentMethod().Name, ex);
      }
    }

    //Private Sub InitApigridSec()
    //  
    //On Error GoTo Handler
    //
    //  ApiGrid2.AddColumn "§DI§", 750
    //  ApiGrid2.AddColumn "§Client§", 1450
    //  ApiGrid2.AddColumn "§Site§", 1600
    //  ApiGrid2.AddColumn "§Action§", 3500
    //  
    //  ApiGrid2.Init ado_rsSec
    //  
    //Exit Sub
    //Handler:
    //  ShowError "InitApigridSec dans " & Me.Name
    //End Sub

    /* OK -------------------------------------------------------------------------------------*/
    private void InitApigridTer()
    {

      try
      {
        ApiGrid3.AddColumn(Resources.col_Date, "jj", 800, "dd/mm/yy");
        ApiGrid3.AddColumn(Resources.col_Jour, "jour", 750);
        ApiGrid3.AddColumn(Resources.col_Nb, "nb", 700, "### ##0", 2);

        ApiGrid3.InitColumnList();
      }
      catch (Exception ex)
      {
        MZUtils.displayError(MethodBase.GetCurrentMethod().Name, ex);
      }
    }

    //Private Sub InitApigridTer()
    //  
    //On Error GoTo Handler
    //
    //  ApiGrid3.AddColumn "§Date§", 800, "dd/mm/yy"
    //  ApiGrid3.AddColumn "§Jour§", 750
    //  ApiGrid3.AddColumn "§Nb§", 700, "### ##0", 2
    //    
    //  ApiGrid3.Init ado_rsTer
    //  
    //Exit Sub
    //Handler:
    //  ShowError "InitApigridTer dans " & Me.Name
    //End Sub

    /* OK -------------------------------------------------------------------------------------*/
    private void ApiGrid_SelectionChanged(object sender, DevExpress.Data.SelectionChangedEventArgs e)
    {
      try
      {
        Cursor.Current = Cursors.WaitCursor;
        string sSQL = "";
        //écriture de la requête pour la liste des sites
        DataRow currentRow = ApiGrid.GetFocusedDataRow();
        sSQL = $"exec api_sp_StatDetailDepPer '{currentRow[0]}'" +
        $", '{mstrDateTxt0}'" +
        $", '{mstrDateTxt1}'";

        //exécuter la commande.
        ApiGrid2.LoadData(dt2, MozartDatabase.cnxMozart, sSQL);
        ApiGrid2.GridControl.DataSource = dt2;

        //cumul par jour
        sSQL = $"exec api_sp_StatCumulDepJourPer '{currentRow[0]}'" +
        $", '{mstrDateTxt0}'" +
        $", '{mstrDateTxt1}'";

        //exécuter la commande.
        ApiGrid3.LoadData(dt3, MozartDatabase.cnxMozart, sSQL);
        ApiGrid3.GridControl.DataSource = dt3;

        Cursor.Current = Cursors.Default;
      }
      catch (Exception ex)
      {
        Cursor = Cursors.Default;
        MZUtils.displayError(MethodBase.GetCurrentMethod().Name, ex);
      }
    }

    //Private Sub ApiGrid_Click()
    //
    //Dim sSQL
    //
    //On Error GoTo Handler:
    //
    //  ' écriture de la requête pour la liste des sites
    //  sSQL = "exec api_sp_StatDetailDepPer " & ado_rs(0)
    //  sSQL = sSQL & ", '" & frmChoixdateDep.txtDateA(0) & "'"
    //  sSQL = sSQL & ", '" & frmChoixdateDep.txtDateA(1) & "'"
    //
    // ' exécuter la commande.
    //  Set ado_rsSec = cnxRep.Execute(sSQL)
    //
    //  ' mise en page du datagrid
    //  InitApigridSec
    //
    //  ' cumul par jour
    //  sSQL = "exec api_sp_StatCumulDepJourPer '" & ado_rs(0)
    //  sSQL = sSQL & "', '" & frmChoixdateDep.txtDateA(0) & "'"
    //  sSQL = sSQL & ", '" & frmChoixdateDep.txtDateA(1) & "'"
    //
    // ' exécuter la commande.
    //  Set ado_rsTer = cnxRep.Execute(sSQL)
    //
    //  ' mise en page du datagrid
    //  InitApigridTer
    //
    //Exit Sub
    //Resume
    //Handler:
    //  If Err.Number = -2147467259 Then
    //    Unload Me
    //  Else
    //    Screen.MousePointer = vbDefault
    //    ShowError "ApiGrid_Click dans " & Me.Name
    //  End If
    //End Sub
  }
}