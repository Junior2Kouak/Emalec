using MozartCS.Properties;
using MozartLib;
using MozartNet;
using System;
using System.Data;
using System.Data.SqlClient;
using System.Reflection;
using System.Windows.Forms;
using MZUtils = MozartControls.Utils;


namespace MozartCS
{
  public partial class frmGestSitesArch : Form
  {
    public int miNumClient;

    DataTable dtPri = new DataTable();
    //  Option Explicit
    //
    //Dim rsPri As ADODB.Recordset
    //
    //Public miNumClient As Integer
    //

    public frmGestSitesArch() { InitializeComponent(); }

    /* OK --------------------------------------------------------------*/
    private void frmGestSitesArch_Load(object sender, System.EventArgs e)
    {
      try
      {
        Cursor.Current = Cursors.WaitCursor;
        ModuleMain.Initboutons(this);

        apiGrid.LoadData(dtPri, MozartDatabase.cnxMozart, $"select * from api_v_ListeSites where csitactif='N' and NCLINUM = {miNumClient}");
        apiGrid.GridControl.DataSource = dtPri;

        InitApigrid();

        DataRow currentRow = apiGrid.GetFocusedDataRow();
        if (currentRow != null) lblNom.Text = Utils.BlankIfNull(currentRow["VCLINOM"]);
      }
      catch (Exception ex)
      {
        MZUtils.displayError(MethodBase.GetCurrentMethod().Name, ex);
      }
      finally { Cursor.Current = Cursors.Default; }
    }

    private void cmdFermer_Click(object sender, System.EventArgs e)
    {
      Dispose();
    }

    private void cmdModifier_Click(object sender, EventArgs e)
    {
      DataRow currentRow = apiGrid.GetFocusedDataRow();
      if (currentRow == null) return;

      new frmDetailsSite
      {
        mstrStatut = "M",
        miNumSite = (int)Utils.ZeroIfNull(currentRow["NSITNUM"]),
        miNumClient = miNumClient
      }.ShowDialog();
    }

    private void cmdSupprimer_Click(object sender, EventArgs e)
    {
      try
      {
        DataRow currentRow = apiGrid.GetFocusedDataRow();
        if (currentRow == null) return;

        if (MessageBox.Show(Resources.msg_restaurerSite, Program.AppTitle, MessageBoxButtons.YesNo, MessageBoxIcon.Question,
            MessageBoxDefaultButton.Button2) != DialogResult.Yes)
          return;

        ModuleData.CnxExecute($"update tsit set csitactif = 'O' where nsitnum = {Utils.ZeroIfNull(currentRow["NSITNUM"])}");

        //rafraichissement des la grille
        apiGrid.Requery(dtPri, MozartDatabase.cnxMozart);
      }
      catch (Exception ex)
      {
        MZUtils.displayError(MethodBase.GetCurrentMethod().Name, ex);
      }
    }
    //Private Sub cmdSupprimer_Click()
    //
    //On Error GoTo handler
    //
    //  If rsPri.EOF Then Exit Sub
    //        
    //  
    //  Select Case MsgBox("§Voulez-vous vraiment restaurer ce site ?§", vbYesNo + vbQuestion + vbDefaultButton2)
    //    Case vbYes
    //      cnx.Execute "update tsit set csitactif = 'O' where nsitnum = " & rsPri("NSITNUM").value
    //    Case vbNo
    //      Exit Sub
    //  End Select
    //    
    //  ' rafraichissement du recordset
    //  rsPri.Requery
    //
    //  ' mise en page du tableau
    //  apiGrid.MajLabel
    // 
    //Exit Sub
    //handler:
    //  ShowError "cmdSupprimer_click dans " & Me.Name
    //End Sub
    //

    /* OK --------------------------------------------------------------------------------------- */
    private void InitApigrid()
    {
      apiGrid.AddColumn(Resources.col_Nom, "VSITNOM", 1900);
      apiGrid.AddColumn(Resources.col_Enseigne, "VSITENSEIGNE", 1400);
      apiGrid.AddColumn(Resources.col_Number, "NSITNUE", 800);
      apiGrid.AddColumn(Resources.col_Type, "VSITTYPE", 1000);
      apiGrid.AddColumn(Resources.col_Adresse1, "VSITAD1", 500);
      apiGrid.AddColumn(Resources.col_Adresse2, "VSITAD2", 500);
      apiGrid.AddColumn(Resources.col_CP, "VSITCP", 700);
      apiGrid.AddColumn(Resources.col_Ville, "VSITVIL", 1200);
      apiGrid.AddColumn(Resources.col_Pays, "VSITPAYS", 1000);
      apiGrid.AddColumn(Resources.col_Telephone, "VSITTEL", 1400);
      apiGrid.AddColumn(Resources.col_Fax, "VSITFAX", 1400);
      apiGrid.AddColumn(Resources.col_Email, "VSITMAI", 500);
      apiGrid.AddColumn(Resources.txt_facturation, "VRSFRSF", 1500);
      apiGrid.AddColumn(Resources.col_region_client, "VSITREG", 1500);
      apiGrid.AddColumn(Resources.col_Region + " " + MozartParams.NomSociete, "VREGLIB", 1600);
      apiGrid.AddColumn(Resources.txt_respSite, "VSITRES", 1300);
      apiGrid.AddColumn(Resources.col_Prenom, "VSITPRENOM", 1000);
      apiGrid.AddColumn(Resources.col_resp_reg, "reg", 1400);
      apiGrid.AddColumn(Resources.col_resp_tech, "maint", 1400);
      apiGrid.AddColumn("NumSite", "NSITNUM", 0);
      apiGrid.AddColumn("VCLINOM", "NCLINUM", 0);
      apiGrid.AddColumn("NumCli", "VCLINOM", 0);
      apiGrid.AddColumn(Resources.col_Actif, "CSITACTIF", 600);
      apiGrid.AddColumn("Info", "Info", 600);

      apiGrid.InitColumnList();

      apiGrid.dgv.OptionsView.ColumnAutoWidth = false;
    }
    //Private Sub InitApigrid()
    //    
    //  apiGrid.AddColumn "§Nom§", "VSITNOM", 1900
    //  apiGrid.AddColumn "§Enseigne§", "VSITENSEIGNE", 1400
    //  apiGrid.AddColumn "§Numéro§", "NSITNUE", 800
    //  apiGrid.AddColumn "§Type§", "VSITTYPE", 1000
    //  apiGrid.AddColumn "§Adresse 1§", "VSITAD1", 500
    //  apiGrid.AddColumn "§Adresse 2§", "VSITAD2", 500
    //  apiGrid.AddColumn "§CP§", "VSITCP", 700
    //  apiGrid.AddColumn "§Ville§", "VSITVIL", 1200
    //  apiGrid.AddColumn "§Pays§", "VSITPAYS", 1000
    //  apiGrid.AddColumn "§Téléphone§", "VSITTEL", 1400
    //  apiGrid.AddColumn "§Fax§", "VSITFAX", 1400
    //  apiGrid.AddColumn "§E-Mail§", "VSITMAI", 500
    //  apiGrid.AddColumn "§Facturation§", "VRSFRSF", 1500
    //  apiGrid.AddColumn "§Région client§", "VSITREG", 1500
    //  apiGrid.AddColumn "§Région §" & gstrNomSociete, "VREGLIB", 1600
    //  apiGrid.AddColumn "§Resp Site§", "VSITRES", 1300
    //  apiGrid.AddColumn "§Prénom§", "VSITPRENOM", 1000
    //  apiGrid.AddColumn "§Resp Reg§", "reg", 1400
    //  apiGrid.AddColumn "§Resp Tech§", "maint", 1400
    //  apiGrid.AddColumn "NumSite", "NSITNUM", 0
    //  apiGrid.AddColumn "NumCli", "VCLINOM", 0
    //  apiGrid.AddColumn "VCLINOM", "NCLINUM", 0
    //  apiGrid.AddColumn "§actif§", "CSITACTIF", 600
    //  apiGrid.AddColumn "Info", "Info", 600
    //    
    //  apiGrid.Init rsPri
    //  
    //End Sub
    //
    //

    /* inutile --------------------------------------------------------------------------------------- */
    //Private Sub Form_Unload(Cancel As Integer)
    //  
    //  Screen.MousePointer = vbDefault
    //End Sub
    //

    /* OK --------------------------------------------------------------------------------------- */
    private void cmdCarte_Click(object sender, EventArgs e)
    {
      DataRow currentRow = apiGrid.GetFocusedDataRow();
      if (currentRow == null) return;

      Cursor.Current = Cursors.WaitCursor;

      using (SqlDataReader sdrLatLon = ModuleData.ExecuteReader($"SELECT VSITNOM + ' - ' + Isnull(VSITAD1, '') + ' ' + Isnull(VSITAD2, '') + ' - ' + Isnull(VSITCP, '') + ' ' + Isnull(VSITVIL, '') + ' - ' + Isnull(VSITPAYS, '') as ADR, FSITLAT LAT, FSITLON LON FROM TSIT WHERE NSITNUM = {Utils.ZeroIfNull(currentRow["NSITNUM"])}"))
      {
        if (sdrLatLon.Read())
        {
          if (MozartParams.NomGroupe == "EMALEC")
            new frmBrowser
            {
              msStartingAddress = $@"https://maps.emalec.com/SiteParPoint.asp?NOM={sdrLatLon["adr"]}&LAT={sdrLatLon["lat"]}&LON={sdrLatLon["lon"]}"
            }.ShowDialog();
          else new frmBrowser().ShowDialog(); //TB SAMSIC CITY TODO -> Prévoir alternative pour Samsic
        }
      }

      Cursor.Current = Cursors.Default;
    }
    //Private Sub cmdCarte_Click()
    //
    //On Error GoTo handler
    //
    //  If rsPri.EOF Then Exit Sub
    //  
    //  Screen.MousePointer = vbHourglass
    //  
    //  ' Modif VL 14/01/2008
    //  Dim rsLatLon As New Recordset
    //  rsLatLon.Open "SELECT VSITNOM + ' - ' + Isnull(VSITAD1, '') + ' ' + Isnull(VSITAD2, '') + ' - ' + Isnull(VSITCP, '') + ' ' + Isnull(VSITVIL, '') + ' - ' + Isnull(VSITPAYS, '') as ADR, FSITLAT LAT, FSITLON LON FROM TSIT WHERE NSITNUM = " & rsPri!NSITNUM, cnx, adOpenForwardOnly, adLockOptimistic
    //  ' TB SAMSIC CITY SPEC
    //  If gstrNomGroupe = "EMALEC" Then
    //    frmBrowser.StartingAddress = "http://maps.emalec.com/SiteParPoint.asp?NOM=" & rsLatLon!adr & "&LAT=" & rsLatLon!lat & "&LON=" & rsLatLon!lon
    //  End If ' TB SAMSIC CITY TODO -> Prévoir alternative pour Samsic
    //  frmBrowser.Show vbModal
    //  rsLatLon.Close
    //  ' Modif VL 14/01/2008
    //
    //  Screen.MousePointer = vbDefault
    //   
    //Exit Sub
    //handler:
    //  Screen.MousePointer = vbDefault
    //End Sub
    //

  }
}

