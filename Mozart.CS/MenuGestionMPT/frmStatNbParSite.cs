using Microsoft.VisualBasic;
using MozartCS.Properties;
using MozartLib;
using MozartNet;
using System;
using System.Data;
using System.Data.SqlClient;
using System.IO;
using System.Reflection;
using System.Windows.Forms;
using MZUtils = MozartControls.Utils;

namespace MozartCS
{
  public partial class frmStatNbParSite : Form
  {
    public string mstrTypeStat;
    public string mstrInfoRetour;
    public int miNumClient;

    public string mstrClient;
    public string mstrTxtDate0;
    public string mstrTxtDate1;

    DataTable dt = new DataTable();
    DataTable dtTOT = new DataTable();
    //
    //Public mstrTypeStat As String
    //Public mstrInfoRetour As String
    //Public miNumClient As Integer
    //Dim ado_rs As ADODB.Recordset
    //Dim ado_rsTot As ADODB.Recordset

    public frmStatNbParSite()
    {
      InitializeComponent();
    }

    /* OK ---------------------------------------------------------------------*/
    private void frmStatNbParSite_Load(object sender, System.EventArgs e)
    {
      string sSQL = "";
      try
      {
        ModuleMain.Initboutons(this);

        Label3.Text = Resources.txt_statDuClient + mstrClient;
        Label4.Text = String.Format(Resources.txt_periodeEtude, mstrTxtDate0, mstrTxtDate1);

        //titre
        switch (mstrTypeStat + mstrInfoRetour)
        {
          case "UN":
            Label6.Text = Resources.txt_nbInterParSiteParUrgence;
            break;
          case "PN":
            Label6.Text = Resources.txt_nbInterParSiteParPresta;
            break;
          case "TN":
            Label6.Text = Resources.txt_nbInterParSiteParTech;
            break;
          case "CN":
            Label6.Text = Resources.txt_nbInterParSiteParContrat;
            break;
          case "UF":
            Label6.Text = Resources.txt_coutInterParSiteParUrgence;
            break;
          case "PF":
            Label6.Text = Resources.txt_coutInterParSiteParPresta;
            break;
          case "TF":
            Label6.Text = Resources.txt_coutInterParSiteParPresta;
            break;
          case "CF":
            Label6.Text = Resources.txt_coutInterParSiteParPresta;
            break;
          default:
            break;
        }

        // écriture de la requête pour la liste des sites
        sSQL = $"exec api_sp_StatistiqueNbInter {miNumClient}" +
        $", '{mstrTxtDate0}'" +
        $", '{mstrTxtDate1}'" +
        $", '{mstrTypeStat}'" +
        $", '{mstrInfoRetour}'" +
        $", 'SITE'";

        // execution des requetes
        apiTGridDet.LoadData(dt, MozartDatabase.cnxMozart, sSQL);
        apiTGridDet.GridControl.DataSource = dt;

        // écriture de la requête pour les totaux
        sSQL = $"exec api_sp_StatistiqueNbInter {miNumClient}" +
        $", '{mstrTxtDate0}'" +
        $", '{mstrTxtDate1}'" +
        $", '{mstrTypeStat}'" +
        $", '{mstrInfoRetour}'" +
        $", 'TOTAL'";

        // execution des requetes
        apiTGridTot.LoadData(dtTOT, MozartDatabase.cnxMozart, sSQL);
        apiTGridTot.GridControl.DataSource = dtTOT;

        InitApigrid();
        InitApigridTot();

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
    //Dim sSql As String
    //On Error GoTo handler:
    //
    //  InitBoutons Me, frmMenu
    //   
    //  Label3.Caption = "§Statistique du client : §" & frmChoixDate.cboclient.Text
    //  Label4.Caption = "§Période d'étude : du §" & frmChoixDate.txtDateA(0) & "§ au §" & frmChoixDate.txtDateA(1)
    //  
    //  'titre
    //  Select Case mstrTypeStat & mstrInfoRetour
    //    Case "UN"
    //        Label6.Caption = "§Nombre d'interventions par site et par urgence§"
    //    Case "PN"
    //        Label6.Caption = "§Nombre d'interventions par site et par prestation§"
    //    Case "TN"
    //        Label6.Caption = "§Nombre d'interventions par site et par technique§"
    //    Case "CN"
    //        Label6.Caption = "§Nombre d'interventions par site et par contrat§"
    //    Case "UF"
    //        Label6.Caption = "§Coût des interventions par site et par urgence§"
    //    Case "PF"
    //        Label6.Caption = "§Coût des interventions par site et par prestation§"
    //    Case "TF"
    //        Label6.Caption = "§Coût des interventions par site et par technique§"
    //    Case "CF"
    //        Label6.Caption = "§Coût des interventions par site et par contrat§"
    //  End Select
    //
    //  ' écriture de la requête pour la liste des sites
    //  sSql = "exec api_sp_StatistiqueNbInter " & miNumClient
    //  sSql = sSql & ", '" & frmChoixDate.txtDateA(0) & "'"
    //  sSql = sSql & ", '" & frmChoixDate.txtDateA(1) & "'"
    //  sSql = sSql & ", '" & mstrTypeStat & "'"
    //  sSql = sSql & ", '" & mstrInfoRetour & "'"
    //  sSql = sSql & ", 'SITE'"
    //  
    //  ' execution des requetes
    //  Set ado_rs = New ADODB.Recordset
    //  ado_rs.Open sSql, cnx, adOpenStatic, adLockReadOnly 'cnxRep
    //
    //  ' écriture de la requête pour les totaux
    //  sSql = "exec api_sp_StatistiqueNbInter " & miNumClient
    //  sSql = sSql & ", '" & frmChoixDate.txtDateA(0) & "'"
    //  sSql = sSql & ", '" & frmChoixDate.txtDateA(1) & "'"
    //  sSql = sSql & ", '" & mstrTypeStat & "'"
    //  sSql = sSql & ", '" & mstrInfoRetour & "'"
    //  sSql = sSql & ", 'TOTAL'"
    //
    //  ' execution des requetes
    //  Set ado_rsTot = New ADODB.Recordset
    //  ado_rsTot.Open sSql, cnx
    //
    //  InitApigrid
    //  InitApigridTot
    //  
    //  Screen.MousePointer = vbDefault
    //Exit Sub
    //handler:
    //  Screen.MousePointer = vbDefault
    //  ShowError "Form_Load de " & Me.Name
    //End Sub

    /* OK ---------------------------------------------------------------------*/
    private void cmdQuitter_Click(object sender, System.EventArgs e)
    {
      Dispose();
    }

    //Private Sub cmdQuitter_Click()
    //    Unload Me
    //End Sub

    /* OK ---------------------------------------------------------------------*/
    private void InitApigrid()
    {
      try
      {
        apiTGridDet.AddColumn(Resources.col_Site, "Site", 2000);

        switch (mstrTypeStat)
        {
          case "U":// lent, moyen, rapide
            apiTGridDet.AddColumn(Resources.col_lent, "Lent", 1000, "", 2);
            apiTGridDet.AddColumn(Resources.col_moyen, "Moyen", 1000, "", 2);
            apiTGridDet.AddColumn(Resources.col_rapide, "Rapide", 2000);
            break;
          case "P":// Dep, Prev, Trav; LR, Sini
            apiTGridDet.AddColumn(Resources.col_depannage, "Dep", 1200, "", 2);
            apiTGridDet.AddColumn(Resources.col_preventif, "Prev", 1200, "", 2);
            apiTGridDet.AddColumn(Resources.col_travaux, "Trav", 1000, "", 2);
            apiTGridDet.AddColumn(Resources.col_leveeDeReserves, "LR", 1800, "", 2);
            apiTGridDet.AddColumn(Resources.col_sinistre, "Sini", 1000, "", 2);
            apiTGridDet.AddColumn(Resources.col_fournitures, "CF", 1000, "", 2);
            break;
          case "T":// Clim, Elec, CF, Mult, Plomb, Serr
            apiTGridDet.AddColumn(Resources.col_clim, "Clim", 1300, "", 2);
            apiTGridDet.AddColumn(Resources.col_electricite, "Elec", 1100, "", 2);
            apiTGridDet.AddColumn(Resources.col_courantsFaibles, "CF", 1600, "", 2);
            apiTGridDet.AddColumn(Resources.col_multitech, "Mult", 1500, "", 2);
            apiTGridDet.AddColumn(Resources.col_plomberie, "Plomb", 1000, "", 2);
            apiTGridDet.AddColumn(Resources.col_serrurerie, "Serr", 1000, "", 2);
            break;
          case "C": // HC, Mult, Clim, DI, THT, CA, Aut, Dint, Inter, Video, PTI, OC, GE, Info, Des
            //gestion dynamique des contrats du client
            using (SqlDataReader sdr = ModuleData.ExecuteReader($"select left(VTYPECONTRAT,30) LIB from TCONTRATCLI C INNER JOIN TREF_TYPECONTRAT R WITH (NOLOCK) ON R.NTYPECONTRAT=C.NTYPECONTRAT WHERE NCLINUM = {miNumClient} and langue = 'FR' order by r.NTYPECONTRAT"))
            {

              int i = 1;

              while (sdr.Read())
              {
                apiTGridDet.AddColumn(sdr["Lib"].ToString(), "CTE" + i.ToString(), 700, "", 2);
                i++;
              }
            }
            break;

          default:
            break;
        }

        apiTGridDet.AddColumn(Resources.col_Total, "Total", 800, "", 2);
        apiTGridDet.AddColumn(Resources.col_NumSit, "Numsite", 0);

        apiTGridDet.InitColumnList();
      }
      catch (Exception ex)
      {
        MZUtils.displayError(MethodBase.GetCurrentMethod().Name, ex);
      }
    }

    //Private Sub InitApigrid()
    //  
    //On Error GoTo handler
    //Dim rsx As New Recordset
    //Dim i As Integer
    //
    // apiTGridDet.AddColumn "§Site§", "Site", 2000
    // 
    // Select Case mstrTypeStat
    //    Case "U" 'Lent, Moyen, Rapide
    //      apiTGridDet.AddColumn "§Lent§", "Lent", 1000, , 2
    //      apiTGridDet.AddColumn "§Moyen§", "Moyen", 1000, , 2
    //      apiTGridDet.AddColumn "§Rapide§", "Rapide", 1000, , 2
    //    Case "P" 'Dep, Prev, Trav, LR, Sini
    //      apiTGridDet.AddColumn "§Dépannage§", "Dep", 1200, , 2
    //      apiTGridDet.AddColumn "§Préventif§", "Prev", 1200, , 2
    //      apiTGridDet.AddColumn "§Travaux§", "Trav", 1000, , 2
    //      apiTGridDet.AddColumn "§Levée de réserves§", "LR", 1800, , 2
    //      apiTGridDet.AddColumn "§Sinistre§", "Sini", 1000, , 2
    //      apiTGridDet.AddColumn "§Fournitures§", "CF", 1000, , 2
    //     Case "T" 'Clim, Elec, CF, Mult, Plomb, Serr
    //      apiTGridDet.AddColumn "§Climatisation§", "Clim", 1300, , 2
    //      apiTGridDet.AddColumn "§Electricité§", "Elec", 1100, , 2
    //      apiTGridDet.AddColumn "§Courants faibles§", "CF", 1600, , 2
    //      apiTGridDet.AddColumn "§Multitechnique§", "Mult", 1500, , 2
    //      apiTGridDet.AddColumn "§Plomberie§", "Plomb", 1000, , 2
    //      apiTGridDet.AddColumn "§Serrurerie§", "Serr", 1000, , 2
    //     Case "C" 'HC , Mult , Clim, DI ,THT ,CA ,Aut ,Dint ,Inter ,Video ,PTI ,OC ,GE ,Info ,Des
    //     
    //       ' gestion dynamique des contrats du client
    //       rsx.Open "select left(VTYPECONTRAT,30) LIB from TCONTRATCLI C INNER JOIN TREF_TYPECONTRAT R WITH (NOLOCK) ON R.NTYPECONTRAT=C.NTYPECONTRAT WHERE NCLINUM = " & miNumClient & " and langue = 'FR' order by r.NTYPECONTRAT", cnx
    //       i = 1
    //       While Not rsx.EOF
    //          apiTGridDet.AddColumn rsx!Lib, "CTE" & CStr(i), 700, , 2
    //          i = i + 1
    //          rsx.MoveNext
    //       Wend
    //       rsx.Close
    //  End Select
    //
    //  apiTGridDet.AddColumn "§Total§", "Total", 800, , 2
    //    
    //  apiTGridDet.AddColumn "NumSite", "Numsite", 0
    //    
    //  apiTGridDet.Init ado_rs
    //  
    //Exit Sub
    //handler:
    //  ShowError "InitApigrid dans " & Me.Name
    //End Sub

    /* OK ---------------------------------------------------------------------*/
    private void InitApigridTot()
    {
      try
      {
        apiTGridTot.AddColumn(Resources.col_totauxRatio, "Site", 2000);

        switch (mstrTypeStat)
        {
          case "U":// lent, moyen, rapide
            apiTGridTot.AddColumn(Resources.col_lent, "Lent", 1000, "", 2);
            apiTGridTot.AddColumn(Resources.col_moyen, "Moyen", 1000, "", 2);
            apiTGridTot.AddColumn(Resources.col_rapide, "Rapide", 2000);
            break;
          case "P":// Dep, Prev, Trav; LR, Sini
            apiTGridTot.AddColumn(Resources.col_depannage, "Dep", 1200, "", 2);
            apiTGridTot.AddColumn(Resources.col_preventif, "Prev", 1200, "", 2);
            apiTGridTot.AddColumn(Resources.col_travaux, "Trav", 1000, "", 2);
            apiTGridTot.AddColumn(Resources.col_leveeDeReserves, "LR", 1800, "", 2);
            apiTGridTot.AddColumn(Resources.col_sinistre, "Sini", 1000, "", 2);
            apiTGridTot.AddColumn(Resources.col_fournitures, "CF", 1000, "", 2);
            break;
          case "T":// Clim, Elec, CF, Mult, Plomb, Serr
            apiTGridTot.AddColumn(Resources.col_clim, "Clim", 1300, "", 2);
            apiTGridTot.AddColumn(Resources.col_electricite, "Elec", 1100, "", 2);
            apiTGridTot.AddColumn(Resources.col_courantsFaibles, "CF", 1600, "", 2);
            apiTGridTot.AddColumn(Resources.col_multitech, "Mult", 1500, "", 2);
            apiTGridTot.AddColumn(Resources.col_plomberie, "Plomb", 1000, "", 2);
            apiTGridTot.AddColumn(Resources.col_serrurerie, "Serr", 1000, "", 2);
            break;
          case "C": // HC, Mult, Clim, DI, THT, CA, Aut, Dint, Inter, Video, PTI, OC, GE, Info, Des
            //gestion dynamique des contrats du client
            using (SqlDataReader sdr = ModuleData.ExecuteReader($"select left(VTYPECONTRAT,30) LIB from TCONTRATCLI C INNER JOIN TREF_TYPECONTRAT R WITH (NOLOCK) ON R.NTYPECONTRAT=C.NTYPECONTRAT WHERE NCLINUM = {miNumClient}  and langue = 'FR' order by r.NTYPECONTRAT"))
            {

              int i = 1;

              while (sdr.Read())
              {
                apiTGridTot.AddColumn(sdr["Lib"].ToString(), "CTE" + i.ToString(), 700, "", 2);
                i++;
              }
            }
            break;

          default:
            break;
        }

        apiTGridTot.AddColumn(Resources.col_Total, "Total", 700, "", 2);
        apiTGridTot.AddColumn(Resources.col_NumSit, "Numsite", 0);

        apiTGridTot.InitColumnList();
      }
      catch (Exception ex)
      {
        MZUtils.displayError(MethodBase.GetCurrentMethod().Name, ex);
      }
    }

    //Private Sub InitApigridTot()
    //  
    //On Error GoTo handler
    //Dim rsx As New Recordset
    //Dim i As Integer
    //
    // apiTGridTot.AddColumn "§Totaux et ratio§", "Site", 2000
    // 
    // Select Case mstrTypeStat
    //    Case "U" 'Lent, Moyen, Rapide
    //      apiTGridTot.AddColumn "§Lent§", "Lent", 1000, , 2
    //      apiTGridTot.AddColumn "§Moyen§", "Moyen", 1000, , 2
    //      apiTGridTot.AddColumn "§Rapide§", "Rapide", 1000, , 2
    //    Case "P"  'Dep, Prev, Trav, LR, Sini
    //      apiTGridTot.AddColumn "§Dépannage§", "Dep", 1200, , 2
    //      apiTGridTot.AddColumn "§Préventif§", "Prev", 1200, , 2
    //      apiTGridTot.AddColumn "§Travaux§", "Trav", 1000, , 2
    //      apiTGridTot.AddColumn "§Levée de réserves§", "LR", 1800, , 2
    //      apiTGridTot.AddColumn "§Sinistre§", "Sini", 1000, , 2
    //      apiTGridTot.AddColumn "§Fournitures§", "CF", 1000, , 2
    //     Case "T" 'Clim, Elec, CF, Mult, Plomb, Serr
    //      apiTGridTot.AddColumn "§Climatisation§", "Clim", 1300, , 2
    //      apiTGridTot.AddColumn "§Electricité§", "Elec", 1100, , 2
    //      apiTGridTot.AddColumn "§Courants faibles§", "CF", 1600, , 2
    //      apiTGridTot.AddColumn "§Multitechnique§", "Mult", 1500, , 2
    //      apiTGridTot.AddColumn "§Plomberie§", "Plomb", 1000, , 2
    //      apiTGridTot.AddColumn "§Serrurerie§", "Serr", 1000, , 2
    //     Case "C" 'HC , Mult , Clim, DI ,THT ,CA ,Aut ,Dint ,Inter ,Video ,PTI ,OC ,GE ,Info ,Des
    //    
    //       ' gestion dynamique des contrats du client
    //       rsx.Open "select left(VTYPECONTRAT,30) LIB from TCONTRATCLI C INNER JOIN TREF_TYPECONTRAT R WITH (NOLOCK) ON R.NTYPECONTRAT=C.NTYPECONTRAT WHERE NCLINUM = " & miNumClient & " and langue = 'FR' order by r.NTYPECONTRAT", cnx
    //        
    //       i = 1
    //       While Not rsx.EOF
    //         apiTGridTot.AddColumn rsx!Lib, "CTE" & CStr(i), 700, , 2
    //         i = i + 1
    //         rsx.MoveNext
    //       Wend
    //       rsx.Close
    //  End Select
    //
    //  apiTGridTot.AddColumn "§Total§", "Total", 700, , 2
    //  apiTGridTot.AddColumn "NumSite", "Numsite", 0
    //    
    //  apiTGridTot.Init ado_rsTot
    //  
    //Exit Sub
    //handler:
    //  ShowError "InitApigridTot dans " & Me.Name
    //End Sub

    /* OK ---------------------------------------------------------------------*/
    private void Imprimer_Click(object sender, EventArgs e)
    {
      //affichage curseur
      Cursor = Cursors.WaitCursor;

      //Preview avec tri sur site et region client
      GenerateStat();

      frmBrowser f = new frmBrowser();
      f.msStartingAddress = MozartParams.CheminUtilisateurMozart + @"s.html";
      f.miPlanningAn = 0;
      f.ShowDialog();

      Cursor = Cursors.Default;
    }

    //Private Sub Imprimer_Click()
    //
    //Dim Ret%
    //  On Error Resume Next
    //      
    //  ' affichage curseur
    //  Me.MousePointer = vbHourglass
    //  
    //  'Preview avec tri sur site et region client
    //  GenerateStat
    //  
    //  frmBrowser.StartingAddress = gstrCheminUtilisateur & "\Mozart\s.html"
    //  frmBrowser.bPlanningAn = 0
    //  frmBrowser.Show vbModal
    //    
    //  If Ret% Then MsgBox Err.Description & " cmdVisualiser dans " & Me.Name
    //  Me.MousePointer = vbDefault
    //End Sub

    /* OK ---------------------------------------------------------------------*/
    private void GenerateStat()
    {
      string strHTML = "";
      try
      {
        //recherche des informations

        if (dt.Rows.Count <= 0)
        {
          strHTML += $"<H3>Statistique de {mstrClient} </H3>" +
          $"aucune statistique";
        }
        else
        {
          strHTML += "<html><head><title> Statistique client</title></head><body>\r\n\r\n";

          //nom du client
          strHTML += $"<table border=0 widht=100%><tr>" +
          $"<TD width=10%><b><font face=tahoma size=4>{MozartParams.NomSociete} </font></TD>" +
          $"<TD width=10%>&nbsp;</TD>" +
          $"<TD width=80% align=right><b><font face=tahoma size=3>Statistique de : {mstrClient} </Font></TD>" +
          $"</TR></table>";

          //titre
          switch (mstrTypeStat + mstrInfoRetour)
          {
            case "UN":
              strHTML += "<H3>Nombre d'interventions par site et par urgence</H3>";
              break;
            case "PN":
              strHTML += "<H3>Nombre d'interventions par site et par prestation</H3>";
              break;
            case "TN":
              strHTML += "<H3>Nombre d'interventions par site et par technique</H3>";
              break;
            case "CN":
              strHTML += "<H3>Coût des interventions par site et par contrat</H3>";
              break;
            case "UF":
              strHTML += "<H3>Coût des interventions par site et par urgence</H3>";
              break;
            case "PF":
              strHTML += "<H3>Coût des interventions par site et par prestation</H3>";
              break;
            case "TF":
              strHTML += "<H3>Coût des interventions par site et par technique</H3>";
              break;
            case "CF":
              strHTML += "<H3>Coût des interventions par site et par contrat</H3>";
              break;
            default:
              break;
          }

          strHTML += $"<H3>Periode du {mstrTxtDate0} au {mstrTxtDate1} </H3><br>";

          //Tableau des numéros de semaine
          strHTML += "<table border=1 cellpadding=2 cellspacing =0 widht=100%><tr>\r\n\r\n";

          switch (mstrTypeStat)
          {
            case "U":
              strHTML += "<td width=40% bgcolor=#FCFECF><font face=tahoma size=3><b>Site</b></FONT></td>" +
              "<td width=15% bgcolor=#FCFECF align=center><font face=Arial size=3><b>Lent</b></FONT></td>" +
              "<td width=15% bgcolor=#FCFECF align=center><font face=Arial size=3><b>Moyen</b></FONT></td>" +
              "<td width=15% bgcolor=#FCFECF align=center><font face=Arial size=3><b>Rapide</b></FONT></td>" +
              "<td width=15% bgcolor=#FCFECF align=center><font face=Arial size=3><b>Total </b></FONT></td>";
              break;
            case "P":
              strHTML += "<td width=30% bgcolor=#FCFECF><font face=tahoma size=3><b>Site</b></FONT></td>" +
              "<td width=11% bgcolor=#FCFECF align=center><font face=Arial size=3><b>Dépannage</b></FONT></td>" +
              "<td width=11% bgcolor=#FCFECF align=center><font face=Arial size=3><b>Préventif</b></FONT></td>" +
              "<td width=11% bgcolor=#FCFECF align=center><font face=Arial size=3><b>Travaux</b></FONT></td>" +
              "<td width=15% bgcolor=#FCFECF align=center><font face=Arial size=3><b>Levée de réserves</b></FONT></td>" +
              "<td width=11% bgcolor=#FCFECF align=center><font face=Arial size=3><b>Sinistre</b></FONT></td>" +
              "<td width=12% bgcolor=#FCFECF align=center><font face=Arial size=3><b>Total </b></FONT></td>";
              break;
            case "T":
              strHTML += "<td width=30% bgcolor=#FCFECF><font face=tahoma size=3><b>Site</b></FONT></td>" +
              "<td width=10% bgcolor=#FCFECF align=center><font face=Arial size=3><b>Clim</b></FONT></td>" +
              "<td width=10% bgcolor=#FCFECF align=center><font face=Arial size=3><b>Elec</b></FONT></td>" +
              "<td width=10% bgcolor=#FCFECF align=center><font face=Arial size=3><b>Courants faibles</b></FONT></td>" +
              "<td width=10% bgcolor=#FCFECF align=center><font face=Arial size=3><b>Multitech</b></FONT></td>" +
              "<td width=10% bgcolor=#FCFECF align=center><font face=Arial size=3><b>Plomberie</b></FONT></td>" +
              "<td width=10% bgcolor=#FCFECF align=center><font face=Arial size=3><b>Serrurerie</b></FONT></td>" +
              "<td width=8% bgcolor=#FCFECF align=center><font face=Arial size=3><b>Total </b></FONT></td>";
              break;
            case "C":
              strHTML += "<td width=20% bgcolor=#FCFECF><font face=tahoma size=3><b>Site</b></FONT></td>" +
              "<td width=5% bgcolor=#FCFECF align=center><font face=Arial size=3><b>Hors C</b></FONT></td>" +
              "<td width=5% bgcolor=#FCFECF align=center><font face=Arial size=3><b>Multi</b></FONT></td>" +
              "<td width=5% bgcolor=#FCFECF align=center><font face=Arial size=3><b>Clim</b></FONT></td>" +
              "<td width=5% bgcolor=#FCFECF align=center><font face=Arial size=3><b>DI</b></FONT></td>" +
              "<td width=5% bgcolor=#FCFECF align=center><font face=Arial size=3><b>Transfo</b></FONT></td>" +
              "<td width=5% bgcolor=#FCFECF align=center><font face=Arial size=3><b>Accès</b></FONT></td>" +
              "<td width=5% bgcolor=#FCFECF align=center><font face=Arial size=3><b>Auto</b></FONT></td>" +
              "<td width=5% bgcolor=#FCFECF align=center><font face=Arial size=3><b>Intru</b></FONT></td>" +
              "<td width=5% bgcolor=#FCFECF align=center><font face=Arial size=3><b>Interph</b></FONT></td>" +
              "<td width=5% bgcolor=#FCFECF align=center><font face=Arial size=3><b>Video</b></FONT></td>" +
              "<td width=5% bgcolor=#FCFECF align=center><font face=Arial size=3><b>PTI</b></FONT></td>" +
              "<td width=5% bgcolor=#FCFECF align=center><font face=Arial size=3><b>Ond</b></FONT></td>" +
              "<td width=5% bgcolor=#FCFECF align=center><font face=Arial size=3><b>GrpEle</b></FONT></td>" +
              "<td width=5% bgcolor=#FCFECF align=center><font face=Arial size=3><b>Info</b></FONT></td>" +
              "<td width=5% bgcolor=#FCFECF align=center><font face=Arial size=3><b>Desenf</b></FONT></td>" +
              "<td width=8% bgcolor=#FCFECF align=center><font face=Arial size=3><b>Total </b></FONT></td>";
              break;
            default:
              break;
          }

          strHTML += "</tr>\r\n\r\n";

          foreach (DataRow dr in dt.Rows)
          {
            //site client
            switch (mstrTypeStat)
            {
              case "U":
                strHTML += $"<tr><td bgcolor=white><font face=tahoma size=2>{dr[0]}</FONT></td> " +
                $"<td bgcolor=white align=center><font face=Arial size=2>&nbsp{Strings.Format(dr[1], "### ### ###")}</FONT></td> " +
                $"<td bgcolor=white align=center><font face=Arial size=2>&nbsp{Strings.Format(dr[2], "### ### ###")}</FONT></td> " +
                $"<td bgcolor=white align=center><font face=Arial size=2>&nbsp{Strings.Format(dr[3], "### ### ###")}</FONT></td> " +
                $"<td bgcolor=white align=center><font face=Arial size=2>&nbsp{Strings.Format(dr[4], "### ### ###")}</FONT></td> ";
                break;
              case "P":
                strHTML += $"<tr><td bgcolor=white><font face=tahoma size=3>{dr[0]}</FONT></td> " +
                $"<td bgcolor=white align=center><font face=Arial size=2>&nbsp{Strings.Format(dr[1], "### ### ###")}</FONT></td> " +
                $"<td bgcolor=white align=center><font face=Arial size=2>&nbsp{Strings.Format(dr[2], "### ### ###")}</FONT></td> " +
                $"<td bgcolor=white align=center><font face=Arial size=2>&nbsp{Strings.Format(dr[3], "### ### ###")}</FONT></td> " +
                $"<td bgcolor=white align=center><font face=Arial size=2>&nbsp{Strings.Format(dr[4], "### ### ###")}</FONT></td> " +
                $"<td bgcolor=white align=center><font face=Arial size=2>&nbsp{Strings.Format(dr[5], "### ### ###")}</FONT></td> " +
                $"<td bgcolor=white align=center><font face=Arial size=2>&nbsp{Strings.Format(dr[6], "### ### ###")}</FONT></td> ";
                break;
              case "T":
                strHTML += $"<tr><td bgcolor=white><font face=tahoma size=2>{dr[0]}</FONT></td> " +
                $"<td bgcolor=white align=center><font face=Arial size=2>&nbsp{Strings.Format(dr[1], "### ### ###")}</FONT></td> " +
                $"<td bgcolor=white align=center><font face=Arial size=2>&nbsp{Strings.Format(dr[2], "### ### ###")}</FONT></td> " +
                $"<td bgcolor=white align=center><font face=Arial size=2>&nbsp{Strings.Format(dr[3], "### ### ###")}</FONT></td> " +
                $"<td bgcolor=white align=center><font face=Arial size=2>&nbsp{Strings.Format(dr[4], "### ### ###")}</FONT></td> " +
                $"<td bgcolor=white align=center><font face=Arial size=2>&nbsp{Strings.Format(dr[5], "### ### ###")}</FONT></td> " +
                $"<td bgcolor=white align=center><font face=Arial size=2>&nbsp{Strings.Format(dr[6], "### ### ###")}</FONT></td> " +
                $"<td bgcolor=white align=center><font face=Arial size=2>&nbsp{Strings.Format(dr[7], "### ### ###")}</FONT></td> ";
                break;
              case "C":
                strHTML += $"<tr><td bgcolor=white><font face=tahoma size=2>{dr[0]}</FONT></td> " +
                $"<td bgcolor=white align=center><font face=Arial size=2>&nbsp{Strings.Format(dr[1], "### ### ###")}</FONT></td> " +
                $"<td bgcolor=white align=center><font face=Arial size=2>&nbsp{Strings.Format(dr[2], "### ### ###")}</FONT></td> " +
                $"<td bgcolor=white align=center><font face=Arial size=2>&nbsp{Strings.Format(dr[3], "### ### ###")}</FONT></td> " +
                $"<td bgcolor=white align=center><font face=Arial size=2>&nbsp{Strings.Format(dr[4], "### ### ###")}</FONT></td> " +
                $"<td bgcolor=white align=center><font face=Arial size=2>&nbsp{Strings.Format(dr[5], "### ### ###")}</FONT></td> " +
                $"<td bgcolor=white align=center><font face=Arial size=2>&nbsp{Strings.Format(dr[6], "### ### ###")}</FONT></td> " +
                $"<td bgcolor=white align=center><font face=Arial size=2>&nbsp{Strings.Format(dr[7], "### ### ###")}</FONT></td> " +
                $"<td bgcolor=white align=center><font face=Arial size=2>&nbsp{Strings.Format(dr[8], "### ### ###")}</FONT></td> " +
                $"<td bgcolor=white align=center><font face=Arial size=2>&nbsp{Strings.Format(dr[9], "### ### ###")}</FONT></td> " +
                $"<td bgcolor=white align=center><font face=Arial size=2>&nbsp{Strings.Format(dr[10], "### ### ###")}</FONT></td> " +
                $"<td bgcolor=white align=center><font face=Arial size=2>&nbsp{Strings.Format(dr[11], "### ### ###")}</FONT></td> " +
                $"<td bgcolor=white align=center><font face=Arial size=2>&nbsp{Strings.Format(dr[12], "### ### ###")}</FONT></td> " +
                $"<td bgcolor=white align=center><font face=Arial size=2>&nbsp{Strings.Format(dr[13], "### ### ###")}</FONT></td> " +
                $"<td bgcolor=white align=center><font face=Arial size=2>&nbsp{Strings.Format(dr[14], "### ### ###")}</FONT></td> " +
                $"<td bgcolor=white align=center><font face=Arial size=2>&nbsp{Strings.Format(dr[15], "### ### ###")}</FONT></td> " +
                $"<td bgcolor=white align=center><font face=Arial size=2>&nbsp{Strings.Format(dr[16], "### ### ###")}</FONT></td> ";
                break;
              default:
                break;
            }

            strHTML += "</tr>";
          }
        }
        // recherche des informations sur les totaux

        // Tableau des numéros de semaine

        switch (mstrTypeStat)
        {
          case "U":
            strHTML += $"<td width=40% bgcolor=#FFCC99><font face=tahoma size=3><b>Totaux et ratio</b></FONT></td>" +
            $"<td width=15% bgcolor=#FFCC99 align=center><font face=Arial size=3><b>Lent</b></FONT></td>" +
            $"<td width = 15 % bgcolor =#FFCC99 align=center><font face=Arial size=3><b>Moyen</b></FONT></td>" +
            $"<td width=15% bgcolor=#FFCC99 align=center><font face=Arial size=3><b>Rapide</b></FONT></td>" +
            $"<td width=15% bgcolor=#FFCC99 align=center><font face=Arial size=3><b>Total </b></FONT></td>";
            break;
          case "P":
            strHTML += $"<td width=30% bgcolor=#FFCC99><font face=tahoma size=3><b>Totaux et ratio</b></FONT></td>" +
            $"<td width=11% bgcolor=#FFCC99 align=center><font face=Arial size=3><b>Dépannage</b></FONT></td>" +
            $"<td width=11% bgcolor=#FFCC99 align=center><font face=Arial size=3><b>Préventif</b></FONT></td>" +
            $"<td width=11% bgcolor=#FFCC99 align=center><font face=Arial size=3><b>Travaux</b></FONT></td>" +
            $"<td width=15% bgcolor=#FFCC99 align=center><font face=Arial size=3><b>Levée de réserves</b></FONT></td>" +
            $"<td width=11% bgcolor=#FFCC99 align=center><font face=Arial size=3><b>Sinistre</b></FONT></td>" +
            $"<td width=12% bgcolor=#FFCC99 align=center><font face=Arial size=3><b>Total </b></FONT></td>";
            break;
          case "T":
            strHTML += $"<td width=30% bgcolor=#FFCC99><font face=tahoma size=3><b>Totaux et ratio</b></FONT></td>" +
              $"<td width=10% bgcolor=#FFCC99 align=center><font face=Arial size=3><b>Clim</b></FONT></td>" +
              $"<td width=10% bgcolor=#FFCC99 align=center><font face=Arial size=3><b>Elec</b></FONT></td>" +
              $"<td width=10% bgcolor=#FFCC99 align=center><font face=Arial size=3><b>Courants faibles</b></FONT></td>" +
              $"<td width=10% bgcolor=#FFCC99 align=center><font face=Arial size=3><b>Multitech</b></FONT></td>" +
              $"<td width=10% bgcolor=#FFCC99 align=center><font face=Arial size=3><b>Plomberie</b></FONT></td>" +
              $"<td width=10% bgcolor=#FFCC99 align=center><font face=Arial size=3><b>Serrurerie</b></FONT></td>" +
              $"<td width=8% bgcolor=#FFCC99 align=center><font face=Arial size=3><b>Total </b></FONT></td>";
            break;
          case "C":
            strHTML += $"<td width=20% bgcolor=#FCFECF><font face=tahoma size=3><b>Site</b></FONT></td>" +
              $"<td width=5% bgcolor=#FCFECF align=center><font face=Arial size=3><b>Hors C</b></FONT></td>" +
              $"<td width=5% bgcolor=#FCFECF align=center><font face=Arial size=3><b>Multi</b></FONT></td>" +
              $"<td width=5% bgcolor=#FCFECF align=center><font face=Arial size=3><b>Clim</b></FONT></td>" +
              $"<td width=5% bgcolor=#FCFECF align=center><font face=Arial size=3><b>DI</b></FONT></td>" +
              $"<td width=5% bgcolor=#FCFECF align=center><font face=Arial size=3><b>Transfo</b></FONT></td>" +
              $"<td width=10% bgcolor=#FFCC99 align=center><font face=Arial size=3><b>Serrurerie</b></FONT></td>" +
              $"<td width=5% bgcolor=#FCFECF align=center><font face=Arial size=3><b>Accès</b></FONT></td>" +
              $"<td width=5% bgcolor=#FCFECF align=center><font face=Arial size=3><b>Auto</b></FONT></td>" +
              $"<td width=5% bgcolor=#FCFECF align=center><font face=Arial size=3><b>Intru</b></FONT></td>" +
              $"<td width=5% bgcolor=#FCFECF align=center><font face=Arial size=3><b>Interph</b></FONT></td>" +
              $"<td width=5% bgcolor=#FCFECF align=center><font face=Arial size=3><b>Video</b></FONT></td>" +
              $"<td width=5% bgcolor=#FCFECF align=center><font face=Arial size=3><b>PTI</b></FONT></td>" +
              $"<td width=5% bgcolor=#FCFECF align=center><font face=Arial size=3><b>Ond</b></FONT></td>" +
              $"<td width=5% bgcolor=#FCFECF align=center><font face=Arial size=3><b>GrpEle</b></FONT></td>" +
              $"<td width=5% bgcolor=#FCFECF align=center><font face=Arial size=3><b>Info</b></FONT></td>" +
              $"<td width=5% bgcolor=#FCFECF align=center><font face=Arial size=3><b>Desenf</b></FONT></td>" +
              $"<td width=8% bgcolor=#FCFECF align=center><font face=Arial size=3><b>Total </b></FONT></td>";
            break;
          default:
            break;
        }

        strHTML += "</tr>\r\n\r\n";

        foreach (DataRow dr in dtTOT.Rows)
        {
          //site client
          switch (mstrTypeStat)
          {
            case "U":
              strHTML += $"<tr><td bgcolor=white><font face=tahoma size=2>{dr[0]}</FONT></td> " +
              $"<td bgcolor=white align=center><font face=Arial size=2>&nbsp{Strings.Format(dr[1], "### ### ###")}</FONT></td> " +
              $"<td bgcolor=white align=center><font face=Arial size=2>&nbsp{Strings.Format(dr[2], "### ### ###")}</FONT></td> " +
              $"<td bgcolor=white align=center><font face=Arial size=2>&nbsp{Strings.Format(dr[3], "### ### ###")}</FONT></td> " +
              $"<td bgcolor=white align=center><font face=Arial size=2>&nbsp{Strings.Format(dr[4], "### ### ###")}</FONT></td> ";
              break;
            case "P":
              strHTML += $"<tr><td bgcolor=white><font face=tahoma size=3>{dr[0]}</FONT></td> " +
              $"<td bgcolor=white align=center><font face=Arial size=2>&nbsp{Strings.Format(dr[1], "### ### ###")}</FONT></td> " +
              $"<td bgcolor=white align=center><font face=Arial size=2>&nbsp{Strings.Format(dr[2], "### ### ###")}</FONT></td> " +
              $"<td bgcolor=white align=center><font face=Arial size=2>&nbsp{Strings.Format(dr[3], "### ### ###")}</FONT></td> " +
              $"<td bgcolor=white align=center><font face=Arial size=2>&nbsp{Strings.Format(dr[4], "### ### ###")}</FONT></td> " +
              $"<td bgcolor=white align=center><font face=Arial size=2>&nbsp{Strings.Format(dr[5], "### ### ###")}</FONT></td> " +
              $"<td bgcolor=white align=center><font face=Arial size=2>&nbsp{Strings.Format(dr[6], "### ### ###")}</FONT></td> ";
              break;
            case "T":
              strHTML += $"<tr><td bgcolor=white><font face=tahoma size=2>{dr[0]}</FONT></td> " +
              $"<td bgcolor=white align=center><font face=Arial size=2>&nbsp{Strings.Format(dr[1], "### ### ###")}</FONT></td> " +
              $"<td bgcolor=white align=center><font face=Arial size=2>&nbsp{Strings.Format(dr[2], "### ### ###")}</FONT></td> " +
              $"<td bgcolor=white align=center><font face=Arial size=2>&nbsp{Strings.Format(dr[3], "### ### ###")}</FONT></td> " +
              $"<td bgcolor=white align=center><font face=Arial size=2>&nbsp{Strings.Format(dr[4], "### ### ###")}</FONT></td> " +
              $"<td bgcolor=white align=center><font face=Arial size=2>&nbsp{Strings.Format(dr[5], "### ### ###")}</FONT></td> " +
              $"<td bgcolor=white align=center><font face=Arial size=2>&nbsp{Strings.Format(dr[6], "### ### ###")}</FONT></td> ";
              break;
            case "C":
              strHTML += $"<tr><td bgcolor=white><font face=tahoma size=2>{dr[0]}</FONT></td> " +
              $"<td bgcolor=white align=center><font face=Arial size=2>&nbsp{Strings.Format(dr[1], "### ### ###")}</FONT></td> " +
              $"<td bgcolor=white align=center><font face=Arial size=2>&nbsp{Strings.Format(dr[2], "### ### ###")}</FONT></td> " +
              $"<td bgcolor=white align=center><font face=Arial size=2>&nbsp{Strings.Format(dr[3], "### ### ###")}</FONT></td> " +
              $"<td bgcolor=white align=center><font face=Arial size=2>&nbsp{Strings.Format(dr[4], "### ### ###")}</FONT></td> " +
              $"<td bgcolor=white align=center><font face=Arial size=2>&nbsp{Strings.Format(dr[5], "### ### ###")}</FONT></td> " +
              $"<td bgcolor=white align=center><font face=Arial size=2>&nbsp{Strings.Format(dr[6], "### ### ###")}</FONT></td> " +
              $"<td bgcolor=white align=center><font face=Arial size=2>&nbsp{Strings.Format(dr[7], "### ### ###")}</FONT></td> " +
              $"<td bgcolor=white align=center><font face=Arial size=2>&nbsp{Strings.Format(dr[8], "### ### ###")}</FONT></td> " +
              $"<td bgcolor=white align=center><font face=Arial size=2>&nbsp{Strings.Format(dr[9], "### ### ###")}</FONT></td> " +
              $"<td bgcolor=white align=center><font face=Arial size=2>&nbsp{Strings.Format(dr[10], "### ### ###")}</FONT></td> " +
              $"<td bgcolor=white align=center><font face=Arial size=2>&nbsp{Strings.Format(dr[11], "### ### ###")}</FONT></td> " +
              $"<td bgcolor=white align=center><font face=Arial size=2>&nbsp{Strings.Format(dr[12], "### ### ###")}</FONT></td> " +
              $"<td bgcolor=white align=center><font face=Arial size=2>&nbsp{Strings.Format(dr[13], "### ### ###")}</FONT></td> " +
              $"<td bgcolor=white align=center><font face=Arial size=2>&nbsp{Strings.Format(dr[14], "### ### ###")}</FONT></td> " +
              $"<td bgcolor=white align=center><font face=Arial size=2>&nbsp{Strings.Format(dr[15], "### ### ###")}</FONT></td> " +
              $"<td bgcolor=white align=center><font face=Arial size=2>&nbsp{Strings.Format(dr[16], "### ### ###")}</FONT></td> " +
              $"";
              break;
            default:
              break;
          }

          strHTML += "</tr>";
        }

        strHTML += "</table>";
        strHTML += "</body></html>";

        File.WriteAllText(MozartParams.CheminUtilisateurMozart + @"s.html", strHTML);
      }
      catch (Exception ex)
      {
        MZUtils.displayError(MethodBase.GetCurrentMethod().Name, ex);
      }
    }

    //Private Sub GenerateStat()
    //
    //Dim strHtml As String
    //  On Error GoTo handler
    //  
    //  ' recherche des informations
    //  ado_rs.MoveFirst
    //  
    //  If ado_rs.EOF Then
    //    strHtml = strHtml & "<H3>Statistique de " & frmChoixDate.cboclient.Text & " </H3>"
    //    strHtml = strHtml & "aucune statistique"
    //  Else
    //    strHtml = "<html><head><title> Statistique client</title></head><body>" & vbCrLf
    //    ' nom du client
    //    strHtml = strHtml & "<table border=0 widht=100%><tr>"
    //    strHtml = strHtml & "<TD width=10%><B><font face=tahoma size=4>" & gstrNomSociete & " </font></TD>"
    //    strHtml = strHtml & "<TD width=10%>&nbsp;</TD>"
    //    strHtml = strHtml & "<TD width=80% align=right><B><font face=tahoma size=3>Statistique de : " & frmChoixDate.cboclient.Text & "</Font></TD>"
    //    strHtml = strHtml & "</TR></table>"
    //    
    //    'titre
    //    Select Case mstrTypeStat & mstrInfoRetour
    //      Case "UN"
    //          strHtml = strHtml & "<H3>Nombre d'interventions par site et par urgence</H3>"
    //      Case "PN"
    //          strHtml = strHtml & "<H3>Nombre d'interventions par site et par prestation</H3>"
    //      Case "TN"
    //          strHtml = strHtml & "<H3>Nombre d'interventions par site et par technique</H3>"
    //      Case "CN"
    //          strHtml = strHtml & "<H3>Nombre d'interventions par site et par contrat</H3>"
    //      Case "UF"
    //          strHtml = strHtml & "<H3>Coût des interventions par site et par urgence</H3>"
    //      Case "PF"
    //          strHtml = strHtml & "<H3>Coût des interventions par site et par prestation</H3>"
    //      Case "TF"
    //          strHtml = strHtml & "<H3>Coût des interventions par site et par technique</H3>"
    //      Case "CF"
    //          strHtml = strHtml & "<H3>Coût des interventions par site et par contrat</H3>"
    //    End Select
    //    
    //    strHtml = strHtml & "<H3>Période du " & frmChoixDate.txtDateA(0) & " au " & frmChoixDate.txtDateA(1) & " </H3><br>"
    //    
    //    ' Tableau des numéros de semaine
    //    strHtml = strHtml & "<table border=1 cellpadding=2 cellspacing =0 widht=100%><tr>" & vbCrLf
    //
    //    Select Case mstrTypeStat
    //       Case "U"
    //         strHtml = strHtml & "<td width=40% bgcolor=#FCFECF><font face=tahoma size=3><b>Site</b></FONT></td>"
    //         strHtml = strHtml & "<td width=15% bgcolor=#FCFECF align=center><font face=Arial size=3><b>Lent</b></FONT></td>"
    //         strHtml = strHtml & "<td width=15% bgcolor=#FCFECF align=center><font face=Arial size=3><b>Moyen</b></FONT></td>"
    //         strHtml = strHtml & "<td width=15% bgcolor=#FCFECF align=center><font face=Arial size=3><b>Rapide</b></FONT></td>"
    //         strHtml = strHtml & "<td width=15% bgcolor=#FCFECF align=center><font face=Arial size=3><b>Total </b></FONT></td>"
    //       Case "P"
    //         strHtml = strHtml & "<td width=30% bgcolor=#FCFECF><font face=tahoma size=3><b>Site</b></FONT></td>"
    //         strHtml = strHtml & "<td width=11% bgcolor=#FCFECF align=center><font face=Arial size=3><b>Dépannage</b></FONT></td>"
    //         strHtml = strHtml & "<td width=11% bgcolor=#FCFECF align=center><font face=Arial size=3><b>Préventif</b></FONT></td>"
    //         strHtml = strHtml & "<td width=11% bgcolor=#FCFECF align=center><font face=Arial size=3><b>Travaux</b></FONT></td>"
    //         strHtml = strHtml & "<td width=15% bgcolor=#FCFECF align=center><font face=Arial size=3><b>Levée de réserves</b></FONT></td>"
    //         strHtml = strHtml & "<td width=11% bgcolor=#FCFECF align=center><font face=Arial size=3><b>Sinistre</b></FONT></td>"
    //         strHtml = strHtml & "<td width=12% bgcolor=#FCFECF align=center><font face=Arial size=3><b>Total </b></FONT></td>"
    //       Case "T"
    //         strHtml = strHtml & "<td width=30% bgcolor=#FCFECF><font face=tahoma size=3><b>Site</b></FONT></td>"
    //         strHtml = strHtml & "<td width=10% bgcolor=#FCFECF align=center><font face=Arial size=3><b>Clim</b></FONT></td>"
    //         strHtml = strHtml & "<td width=10% bgcolor=#FCFECF align=center><font face=Arial size=3><b>Elec</b></FONT></td>"
    //         strHtml = strHtml & "<td width=10% bgcolor=#FCFECF align=center><font face=Arial size=3><b>Courants faibles</b></FONT></td>"
    //         strHtml = strHtml & "<td width=10% bgcolor=#FCFECF align=center><font face=Arial size=3><b>Multitech</b></FONT></td>"
    //         strHtml = strHtml & "<td width=10% bgcolor=#FCFECF align=center><font face=Arial size=3><b>Plomberie</b></FONT></td>"
    //         strHtml = strHtml & "<td width=10% bgcolor=#FCFECF align=center><font face=Arial size=3><b>Serrurerie</b></FONT></td>"
    //         strHtml = strHtml & "<td width=8% bgcolor=#FCFECF align=center><font face=Arial size=3><b>Total </b></FONT></td>"
    //        Case "C"
    //         strHtml = strHtml & "<td width=20% bgcolor=#FCFECF><font face=tahoma size=3><b>Site</b></FONT></td>"
    //         strHtml = strHtml & "<td width=5% bgcolor=#FCFECF align=center><font face=Arial size=3><b>Hors C</b></FONT></td>"
    //         strHtml = strHtml & "<td width=5% bgcolor=#FCFECF align=center><font face=Arial size=3><b>Multi</b></FONT></td>"
    //         strHtml = strHtml & "<td width=5% bgcolor=#FCFECF align=center><font face=Arial size=3><b>Clim</b></FONT></td>"
    //         strHtml = strHtml & "<td width=5% bgcolor=#FCFECF align=center><font face=Arial size=3><b>DI</b></FONT></td>"
    //         strHtml = strHtml & "<td width=5% bgcolor=#FCFECF align=center><font face=Arial size=3><b>Transfo</b></FONT></td>"
    //         strHtml = strHtml & "<td width=5% bgcolor=#FCFECF align=center><font face=Arial size=3><b>Accès</b></FONT></td>"
    //         strHtml = strHtml & "<td width=5% bgcolor=#FCFECF align=center><font face=Arial size=3><b>Auto</b></FONT></td>"
    //         strHtml = strHtml & "<td width=5% bgcolor=#FCFECF align=center><font face=Arial size=3><b>Intru</b></FONT></td>"
    //         strHtml = strHtml & "<td width=5% bgcolor=#FCFECF align=center><font face=Arial size=3><b>Interph</b></FONT></td>"
    //         strHtml = strHtml & "<td width=5% bgcolor=#FCFECF align=center><font face=Arial size=3><b>Video</b></FONT></td>"
    //         strHtml = strHtml & "<td width=5% bgcolor=#FCFECF align=center><font face=Arial size=3><b>PTI</b></FONT></td>"
    //         strHtml = strHtml & "<td width=5% bgcolor=#FCFECF align=center><font face=Arial size=3><b>Ond</b></FONT></td>"
    //         strHtml = strHtml & "<td width=5% bgcolor=#FCFECF align=center><font face=Arial size=3><b>GrpEle</b></FONT></td>"
    //         strHtml = strHtml & "<td width=5% bgcolor=#FCFECF align=center><font face=Arial size=3><b>Info</b></FONT></td>"
    //         strHtml = strHtml & "<td width=5% bgcolor=#FCFECF align=center><font face=Arial size=3><b>Desenf</b></FONT></td>"
    //         strHtml = strHtml & "<td width=8% bgcolor=#FCFECF align=center><font face=Arial size=3><b>Total </b></FONT></td>"
    //    End Select
    //   
    //    
    //    strHtml = strHtml & "</tr>" & vbCrLf
    //    
    //    While Not ado_rs.EOF
    //       ' Site client
    //      Select Case mstrTypeStat
    //       Case "U"
    //        strHtml = strHtml & "<tr><td bgcolor=white><font face=tahoma size=2>" & ado_rs(0) & "</FONT></td> "
    //        strHtml = strHtml & "<td bgcolor=white align=center><font face=Arial size=2>&nbsp" & Format(ado_rs(1), "### ### ###") & "</FONT></td> "
    //        strHtml = strHtml & "<td bgcolor=white align=center><font face=Arial size=2>&nbsp" & Format(ado_rs(2), "### ### ###") & "</FONT></td> "
    //        strHtml = strHtml & "<td bgcolor=white align=center><font face=Arial size=2>&nbsp" & Format(ado_rs(3), "### ### ###") & "</FONT></td> "
    //        strHtml = strHtml & "<td bgcolor=white align=center><font face=Arial size=2>&nbsp" & Format(ado_rs(4), "### ### ###") & "</FONT></td> "
    //       Case "P"
    //        strHtml = strHtml & "<tr><td bgcolor=white><font face=tahoma size=3>" & ado_rs(0) & "</FONT></td> "
    //        strHtml = strHtml & "<td bgcolor=white align=center><font face=Arial size=2>&nbsp" & Format(ado_rs(1), "### ### ###") & "</FONT></td> "
    //        strHtml = strHtml & "<td bgcolor=white align=center><font face=Arial size=2>&nbsp" & Format(ado_rs(2), "### ### ###") & "</FONT></td> "
    //        strHtml = strHtml & "<td bgcolor=white align=center><font face=Arial size=2>&nbsp" & Format(ado_rs(3), "### ### ###") & "</FONT></td> "
    //        strHtml = strHtml & "<td bgcolor=white align=center><font face=Arial size=2>&nbsp" & Format(ado_rs(4), "### ### ###") & "</FONT></td> "
    //        strHtml = strHtml & "<td bgcolor=white align=center><font face=Arial size=2>&nbsp" & Format(ado_rs(5), "### ### ###") & "</FONT></td> "
    //        strHtml = strHtml & "<td bgcolor=white align=center><font face=Arial size=2>&nbsp" & Format(ado_rs(6), "### ### ###") & "</FONT></td> "
    //       Case "T"
    //        strHtml = strHtml & "<tr><td bgcolor=white><font face=tahoma size=2>" & ado_rs(0) & "</FONT></td> "
    //        strHtml = strHtml & "<td bgcolor=white align=center><font face=Arial size=2>&nbsp" & Format(ado_rs(1), "### ### ###") & "</FONT></td> "
    //        strHtml = strHtml & "<td bgcolor=white align=center><font face=Arial size=2>&nbsp" & Format(ado_rs(2), "### ### ###") & "</FONT></td> "
    //        strHtml = strHtml & "<td bgcolor=white align=center><font face=Arial size=2>&nbsp" & Format(ado_rs(3), "### ### ###") & "</FONT></td> "
    //        strHtml = strHtml & "<td bgcolor=white align=center><font face=Arial size=2>&nbsp" & Format(ado_rs(4), "### ### ###") & "</FONT></td> "
    //        strHtml = strHtml & "<td bgcolor=white align=center><font face=Arial size=2>&nbsp" & Format(ado_rs(5), "### ### ###") & "</FONT></td> "
    //        strHtml = strHtml & "<td bgcolor=white align=center><font face=Arial size=2>&nbsp" & Format(ado_rs(6), "### ### ###") & "</FONT></td> "
    //        strHtml = strHtml & "<td bgcolor=white align=center><font face=Arial size=2>&nbsp" & Format(ado_rs(7), "### ### ###") & "</FONT></td> "
    //       Case "C"
    //        strHtml = strHtml & "<tr><td bgcolor=white><font face=tahoma size=2>" & ado_rs(0) & "</FONT></td> "
    //        strHtml = strHtml & "<td bgcolor=white align=center><font face=Arial size=2>&nbsp" & Format(ado_rs(1), "### ### ###") & "</FONT></td> "
    //        strHtml = strHtml & "<td bgcolor=white align=center><font face=Arial size=2>&nbsp" & Format(ado_rs(2), "### ### ###") & "</FONT></td> "
    //        strHtml = strHtml & "<td bgcolor=white align=center><font face=Arial size=2>&nbsp" & Format(ado_rs(3), "### ### ###") & "</FONT></td> "
    //        strHtml = strHtml & "<td bgcolor=white align=center><font face=Arial size=2>&nbsp" & Format(ado_rs(4), "### ### ###") & "</FONT></td> "
    //        strHtml = strHtml & "<td bgcolor=white align=center><font face=Arial size=2>&nbsp" & Format(ado_rs(5), "### ### ###") & "</FONT></td> "
    //        strHtml = strHtml & "<td bgcolor=white align=center><font face=Arial size=2>&nbsp" & Format(ado_rs(6), "### ### ###") & "</FONT></td> "
    //        strHtml = strHtml & "<td bgcolor=white align=center><font face=Arial size=2>&nbsp" & Format(ado_rs(7), "### ### ###") & "</FONT></td> "
    //        strHtml = strHtml & "<td bgcolor=white align=center><font face=Arial size=2>&nbsp" & Format(ado_rs(8), "### ### ###") & "</FONT></td> "
    //        strHtml = strHtml & "<td bgcolor=white align=center><font face=Arial size=2>&nbsp" & Format(ado_rs(9), "### ### ###") & "</FONT></td> "
    //        strHtml = strHtml & "<td bgcolor=white align=center><font face=Arial size=2>&nbsp" & Format(ado_rs(10), "### ### ###") & "</FONT></td> "
    //        strHtml = strHtml & "<td bgcolor=white align=center><font face=Arial size=2>&nbsp" & Format(ado_rs(11), "### ### ###") & "</FONT></td> "
    //        strHtml = strHtml & "<td bgcolor=white align=center><font face=Arial size=2>&nbsp" & Format(ado_rs(12), "### ### ###") & "</FONT></td> "
    //        strHtml = strHtml & "<td bgcolor=white align=center><font face=Arial size=2>&nbsp" & Format(ado_rs(13), "### ### ###") & "</FONT></td> "
    //        strHtml = strHtml & "<td bgcolor=white align=center><font face=Arial size=2>&nbsp" & Format(ado_rs(14), "### ### ###") & "</FONT></td> "
    //        strHtml = strHtml & "<td bgcolor=white align=center><font face=Arial size=2>&nbsp" & Format(ado_rs(15), "### ### ###") & "</FONT></td> "
    //        strHtml = strHtml & "<td bgcolor=white align=center><font face=Arial size=2>&nbsp" & Format(ado_rs(16), "### ### ###") & "</FONT></td> "
    //        
    //     End Select
    //      
    //      strHtml = strHtml & "</tr>"
    //      ado_rs.MoveNext
    //    Wend
    //  End If
    //  
    //   ' recherche des informations sur les totaux
    //  ado_rsTot.MoveFirst
    //        
    //    ' Tableau des numéros de semaine
    //
    //    Select Case mstrTypeStat
    //       Case "U"
    //         strHtml = strHtml & "<td width=40% bgcolor=#FFCC99><font face=tahoma size=3><b>Totaux et ratio</b></FONT></td>"
    //         strHtml = strHtml & "<td width=15% bgcolor=#FFCC99 align=center><font face=Arial size=3><b>Lent</b></FONT></td>"
    //         strHtml = strHtml & "<td width=15% bgcolor=#FFCC99 align=center><font face=Arial size=3><b>Moyen</b></FONT></td>"
    //         strHtml = strHtml & "<td width=15% bgcolor=#FFCC99 align=center><font face=Arial size=3><b>Rapide</b></FONT></td>"
    //         strHtml = strHtml & "<td width=15% bgcolor=#FFCC99 align=center><font face=Arial size=3><b>Total </b></FONT></td>"
    //       Case "P"
    //         strHtml = strHtml & "<td width=30% bgcolor=#FFCC99><font face=tahoma size=3><b>Totaux et ratio</b></FONT></td>"
    //         strHtml = strHtml & "<td width=11% bgcolor=#FFCC99 align=center><font face=Arial size=3><b>Dépannage</b></FONT></td>"
    //         strHtml = strHtml & "<td width=11% bgcolor=#FFCC99 align=center><font face=Arial size=3><b>Préventif</b></FONT></td>"
    //         strHtml = strHtml & "<td width=11% bgcolor=#FFCC99 align=center><font face=Arial size=3><b>Travaux</b></FONT></td>"
    //         strHtml = strHtml & "<td width=15% bgcolor=#FFCC99 align=center><font face=Arial size=3><b>Levée de réserves</b></FONT></td>"
    //         strHtml = strHtml & "<td width=11% bgcolor=#FFCC99 align=center><font face=Arial size=3><b>Sinistre</b></FONT></td>"
    //         strHtml = strHtml & "<td width=12% bgcolor=#FFCC99 align=center><font face=Arial size=3><b>Total </b></FONT></td>"
    //       Case "T"
    //         strHtml = strHtml & "<td width=30% bgcolor=#FFCC99><font face=tahoma size=3><b>Totaux et ratio</b></FONT></td>"
    //         strHtml = strHtml & "<td width=10% bgcolor=#FFCC99 align=center><font face=Arial size=3><b>Clim</b></FONT></td>"
    //         strHtml = strHtml & "<td width=10% bgcolor=#FFCC99 align=center><font face=Arial size=3><b>Elec</b></FONT></td>"
    //         strHtml = strHtml & "<td width=10% bgcolor=#FFCC99 align=center><font face=Arial size=3><b>Courants faibles</b></FONT></td>"
    //         strHtml = strHtml & "<td width=10% bgcolor=#FFCC99 align=center><font face=Arial size=3><b>Multitech</b></FONT></td>"
    //         strHtml = strHtml & "<td width=10% bgcolor=#FFCC99 align=center><font face=Arial size=3><b>Plomberie</b></FONT></td>"
    //         strHtml = strHtml & "<td width=10% bgcolor=#FFCC99 align=center><font face=Arial size=3><b>Serrurerie</b></FONT></td>"
    //         strHtml = strHtml & "<td width=8% bgcolor=#FFCC99 align=center><font face=Arial size=3><b>Total </b></FONT></td>"
    //       Case "C"
    //         strHtml = strHtml & "<td width=20% bgcolor=#FCFECF><font face=tahoma size=3><b>Site</b></FONT></td>"
    //         strHtml = strHtml & "<td width=5% bgcolor=#FCFECF align=center><font face=Arial size=3><b>Hors C</b></FONT></td>"
    //         strHtml = strHtml & "<td width=5% bgcolor=#FCFECF align=center><font face=Arial size=3><b>Multi</b></FONT></td>"
    //         strHtml = strHtml & "<td width=5% bgcolor=#FCFECF align=center><font face=Arial size=3><b>Clim</b></FONT></td>"
    //         strHtml = strHtml & "<td width=5% bgcolor=#FCFECF align=center><font face=Arial size=3><b>DI</b></FONT></td>"
    //         strHtml = strHtml & "<td width=5% bgcolor=#FCFECF align=center><font face=Arial size=3><b>Transfo</b></FONT></td>"
    //         strHtml = strHtml & "<td width=5% bgcolor=#FCFECF align=center><font face=Arial size=3><b>Accès</b></FONT></td>"
    //         strHtml = strHtml & "<td width=5% bgcolor=#FCFECF align=center><font face=Arial size=3><b>Auto</b></FONT></td>"
    //         strHtml = strHtml & "<td width=5% bgcolor=#FCFECF align=center><font face=Arial size=3><b>Intru</b></FONT></td>"
    //         strHtml = strHtml & "<td width=5% bgcolor=#FCFECF align=center><font face=Arial size=3><b>Interph</b></FONT></td>"
    //         strHtml = strHtml & "<td width=5% bgcolor=#FCFECF align=center><font face=Arial size=3><b>Video</b></FONT></td>"
    //         strHtml = strHtml & "<td width=5% bgcolor=#FCFECF align=center><font face=Arial size=3><b>PTI</b></FONT></td>"
    //         strHtml = strHtml & "<td width=5% bgcolor=#FCFECF align=center><font face=Arial size=3><b>Ond</b></FONT></td>"
    //         strHtml = strHtml & "<td width=5% bgcolor=#FCFECF align=center><font face=Arial size=3><b>GrpEle</b></FONT></td>"
    //         strHtml = strHtml & "<td width=5% bgcolor=#FCFECF align=center><font face=Arial size=3><b>Info</b></FONT></td>"
    //         strHtml = strHtml & "<td width=5% bgcolor=#FCFECF align=center><font face=Arial size=3><b>Desenf</b></FONT></td>"
    //         strHtml = strHtml & "<td width=8% bgcolor=#FCFECF align=center><font face=Arial size=3><b>Total </b></FONT></td>"
    //  End Select
    //    
    //    strHtml = strHtml & "</tr>" & vbCrLf
    //    
    //    While Not ado_rsTot.EOF
    //       ' Site client
    //      Select Case mstrTypeStat
    //       Case "U"
    //        strHtml = strHtml & "<tr><td bgcolor=white><font face=tahoma size=2>" & ado_rsTot(0) & "</FONT></td> "
    //        strHtml = strHtml & "<td bgcolor=white align=center><font face=Arial size=2>&nbsp" & Format(ado_rsTot(1), "### ### ###") & "</FONT></td> "
    //        strHtml = strHtml & "<td bgcolor=white align=center><font face=Arial size=2>&nbsp" & Format(ado_rsTot(2), "### ### ###") & "</FONT></td> "
    //        strHtml = strHtml & "<td bgcolor=white align=center><font face=Arial size=2>&nbsp" & Format(ado_rsTot(3), "### ### ###") & "</FONT></td> "
    //        strHtml = strHtml & "<td bgcolor=white align=center><font face=Arial size=2>&nbsp" & Format(ado_rsTot(4), "### ### ###") & "</FONT></td> "
    //       Case "P"
    //        strHtml = strHtml & "<tr><td bgcolor=white><font face=tahoma size=3>" & ado_rsTot(0) & "</FONT></td> "
    //        strHtml = strHtml & "<td bgcolor=white align=center><font face=Arial size=2>&nbsp" & Format(ado_rsTot(1), "### ### ###") & "</FONT></td> "
    //        strHtml = strHtml & "<td bgcolor=white align=center><font face=Arial size=2>&nbsp" & Format(ado_rsTot(2), "### ### ###") & "</FONT></td> "
    //        strHtml = strHtml & "<td bgcolor=white align=center><font face=Arial size=2>&nbsp" & Format(ado_rsTot(3), "### ### ###") & "</FONT></td> "
    //        strHtml = strHtml & "<td bgcolor=white align=center><font face=Arial size=2>&nbsp" & Format(ado_rsTot(4), "### ### ###") & "</FONT></td> "
    //        strHtml = strHtml & "<td bgcolor=white align=center><font face=Arial size=2>&nbsp" & Format(ado_rsTot(5), "### ### ###") & "</FONT></td> "
    //        strHtml = strHtml & "<td bgcolor=white align=center><font face=Arial size=2>&nbsp" & Format(ado_rsTot(6), "### ### ###") & "</FONT></td> "
    //       Case "T"
    //        strHtml = strHtml & "<tr><td bgcolor=white><font face=tahoma size=2>" & ado_rsTot(0) & "</FONT></td> "
    //        strHtml = strHtml & "<td bgcolor=white align=center><font face=Arial size=2>&nbsp" & Format(ado_rsTot(1), "### ### ###") & "</FONT></td> "
    //        strHtml = strHtml & "<td bgcolor=white align=center><font face=Arial size=2>&nbsp" & Format(ado_rsTot(2), "### ### ###") & "</FONT></td> "
    //        strHtml = strHtml & "<td bgcolor=white align=center><font face=Arial size=2>&nbsp" & Format(ado_rsTot(3), "### ### ###") & "</FONT></td> "
    //        strHtml = strHtml & "<td bgcolor=white align=center><font face=Arial size=2>&nbsp" & Format(ado_rsTot(4), "### ### ###") & "</FONT></td> "
    //        strHtml = strHtml & "<td bgcolor=white align=center><font face=Arial size=2>&nbsp" & Format(ado_rsTot(5), "### ### ###") & "</FONT></td> "
    //        strHtml = strHtml & "<td bgcolor=white align=center><font face=Arial size=2>&nbsp" & Format(ado_rsTot(6), "### ### ###") & "</FONT></td> "
    //        strHtml = strHtml & "<td bgcolor=white align=center><font face=Arial size=2>&nbsp" & Format(ado_rsTot(7), "### ### ###") & "</FONT></td> "
    //       Case "C"
    //        strHtml = strHtml & "<tr><td bgcolor=white><font face=tahoma size=2>" & ado_rs(0) & "</FONT></td> "
    //        strHtml = strHtml & "<td bgcolor=white align=center><font face=Arial size=2>&nbsp" & Format(ado_rs(1), "### ### ###") & "</FONT></td> "
    //        strHtml = strHtml & "<td bgcolor=white align=center><font face=Arial size=2>&nbsp" & Format(ado_rs(2), "### ### ###") & "</FONT></td> "
    //        strHtml = strHtml & "<td bgcolor=white align=center><font face=Arial size=2>&nbsp" & Format(ado_rs(3), "### ### ###") & "</FONT></td> "
    //        strHtml = strHtml & "<td bgcolor=white align=center><font face=Arial size=2>&nbsp" & Format(ado_rs(4), "### ### ###") & "</FONT></td> "
    //        strHtml = strHtml & "<td bgcolor=white align=center><font face=Arial size=2>&nbsp" & Format(ado_rs(5), "### ### ###") & "</FONT></td> "
    //        strHtml = strHtml & "<td bgcolor=white align=center><font face=Arial size=2>&nbsp" & Format(ado_rs(6), "### ### ###") & "</FONT></td> "
    //        strHtml = strHtml & "<td bgcolor=white align=center><font face=Arial size=2>&nbsp" & Format(ado_rs(7), "### ### ###") & "</FONT></td> "
    //        strHtml = strHtml & "<td bgcolor=white align=center><font face=Arial size=2>&nbsp" & Format(ado_rs(8), "### ### ###") & "</FONT></td> "
    //        strHtml = strHtml & "<td bgcolor=white align=center><font face=Arial size=2>&nbsp" & Format(ado_rs(9), "### ### ###") & "</FONT></td> "
    //        strHtml = strHtml & "<td bgcolor=white align=center><font face=Arial size=2>&nbsp" & Format(ado_rs(10), "### ### ###") & "</FONT></td> "
    //        strHtml = strHtml & "<td bgcolor=white align=center><font face=Arial size=2>&nbsp" & Format(ado_rs(11), "### ### ###") & "</FONT></td> "
    //        strHtml = strHtml & "<td bgcolor=white align=center><font face=Arial size=2>&nbsp" & Format(ado_rs(12), "### ### ###") & "</FONT></td> "
    //        strHtml = strHtml & "<td bgcolor=white align=center><font face=Arial size=2>&nbsp" & Format(ado_rs(13), "### ### ###") & "</FONT></td> "
    //        strHtml = strHtml & "<td bgcolor=white align=center><font face=Arial size=2>&nbsp" & Format(ado_rs(14), "### ### ###") & "</FONT></td> "
    //        strHtml = strHtml & "<td bgcolor=white align=center><font face=Arial size=2>&nbsp" & Format(ado_rs(15), "### ### ###") & "</FONT></td> "
    //        strHtml = strHtml & "<td bgcolor=white align=center><font face=Arial size=2>&nbsp" & Format(ado_rs(16), "### ### ###") & "</FONT></td> "
    //     End Select
    // 
    //      strHtml = strHtml & "</tr>"
    //      ado_rsTot.MoveNext
    //    Wend
    //    strHtml = strHtml & "</table>"
    //  
    //  strHtml = strHtml & "</body></html>"
    //  
    //  Dim fs As New Scripting.FileSystemObject
    //  Dim ts As TextStream
    //  Set ts = fs.OpenTextFile(gstrCheminUtilisateur & "\Mozart\s.html", ForWriting, True)
    //  ts.Write strHtml
    //  ts.Close
    //
    //Exit Sub
    //handler:
    //  ShowError " GenenrateStat dans " & Me.Name
    //End Sub

    /* Inutile ---------------------------------------------------------------------*/
    //Private Sub Form_Unload(Cancel As Integer)
    //
    //    On Error Resume Next
    //    If ado_rs.State = adStateOpen Then ado_rs.Close
    //    If ado_rsTot.State = adStateOpen Then ado_rsTot.Close
    //    Set ado_rs = Nothing
    //    Set ado_rsTot = Nothing
    //
    //End Sub

  }
}