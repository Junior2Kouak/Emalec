using MZCtrlResources = MozartControls.Properties.Resources;
using MozartCS.Properties;
using MozartLib;
using MozartNet;
using MozartUC;
using System;
using System.Data;
using System.Reflection;
using System.Windows.Forms;
using MZUtils = MozartControls.Utils;


namespace MozartCS
{
  public partial class frmListeDevisWebSTArch : Form
  {
    DataTable dt = new DataTable();
    //Dim rs As ADODB.Recordset

    public frmListeDevisWebSTArch() { InitializeComponent(); }
    /*--------------------------------------------------------------*/
    private void frmListeDevisWebSTArch_Load(object sender, System.EventArgs e)
    {
      try
      {
        Cursor.Current = Cursors.WaitCursor;
        ModuleMain.Initboutons(this);

        //ouverture du recordset
        apiTGrid.LoadData(dt, MozartDatabase.cnxMozart, $"select * from api_v_ListeDevisWebSTT WHERE bwdevlock=1 AND DWDEVDTRAITE is not null");
        apiTGrid.GridControl.DataSource = dt;

        InitApigrid();
      }
      catch (Exception ex)
      {
        MZUtils.displayError(MethodBase.GetCurrentMethod().Name, ex);
      }
      finally { Cursor.Current = Cursors.Default; }
    }
    //Private Sub Form_Load()
    //
    //On Error GoTo handler:
    //
    //  InitBoutons Me, frmMenu
    //  
    //  ' ouverture du recordset
    //  Set rs = New ADODB.Recordset
    //  rs.Open "select * from api_v_ListeDevisWebSTT WHERE bwdevlock=1 AND DWDEVDTRAITE is not null ", cnx
    //  InitApigrid
    //  
    //  Screen.MousePointer = vbDefault
    //Exit Sub
    //handler:
    //  Screen.MousePointer = vbDefault
    //  ShowError "Form_Load de " & Me.Name
    //End Sub
    //
    /* --------------------------------------------------------------------------------------- */
    private void cmdRestaurer_Click(object sender, EventArgs e)
    {
      DataRow row = apiTGrid.GetFocusedDataRow();
      if (row == null) return;

      if (MessageBox.Show(Resources.msg_devis_restaur_confirm, Program.AppTitle, MessageBoxButtons.YesNo, MessageBoxIcon.Question, MessageBoxDefaultButton.Button2) != DialogResult.Yes) return;

      ModuleData.ExecuteNonQuery($"update TWDEVISSTT set DWDEVDTRAITE = null where NWDEVNUM = {row["NWDEVNUM"]}");

      Cursor.Current = Cursors.WaitCursor;
      apiTGrid.Requery(dt, MozartDatabase.cnxMozart);
      Cursor.Current = Cursors.Default;
    }
    //Private Sub cmdRestaurer_Click()
    //  
    //  If rs.EOF Then Exit Sub
    //  
    //  Select Case MsgBox("§Voulez-vous vraiment restaurer ce devis ?§", vbYesNo + vbQuestion + vbDefaultButton2)
    //    Case vbYes
    //       cnx.Execute "update TWDEVISSTT set DWDEVDTRAITE = null where NWDEVNUM = " & rs("NWDEVNUM")
    //    Case vbNo
    //      Exit Sub
    //  End Select
    //  
    //  rs.Requery
    //End Sub
    //
    /* --------------------------------------------------------------------------------------- */
    private void cmdVisu_Click(object sender, EventArgs e)
    {
      DataRow row = apiTGrid.GetFocusedDataRow();
      if (row == null) return;

      string[,] TdbGlobal = { { "", "" } };

      new frmBrowser()
      {
        miPlanningAn = 0
      }.Preview_Print($@"{MozartParams.CheminModeles}{MozartParams.Langue}\TDevisSTTWeb.html",
                      @"TDevisSTTWeb.out.html",
                      TdbGlobal,
                      $"select * from api_v_ListeDevisWebSTT where NWDEVNUM= {row["NWDEVNUM"]}",
                      " (Visualisation devis)",
                      "PREVIEW");
    }
    //Private Sub cmdVisu_Click()
    //Dim TdbGlobal(0 To 1, 0 To 1) As Variant
    //' UPGRADE_INFO (#0501): The 'sFichier' member isn't used anywhere in current application.
    //' Dim sFichier
    //
    //  If rs.EOF Then Exit Sub
    //
    //  On Error Resume Next
    //  
    //  frmBrowser.bPlanningAn = 0
    //  frmBrowser.Preview_Print gstrCheminModeles & gstrLangue & "\" & "TDevisSTTWeb.html", _
    //                              "\TDevisSTTWeb.out.html", _
    //                              TdbGlobal(), _
    //                              "select * from api_v_ListeDevisWebSTT where NWDEVNUM=" & rs("NWDEVNUM"), _
    //                              " (Visualisation devis)", _
    //                              "PREVIEW"
    //End Sub
    //
    /* --------------------------------------------------------------------------------------- */
    private void InitApigrid()
    {
      apiTGrid.AddColumn("Num", "NWDEVNUM", 0);
      apiTGrid.AddColumn("N°", "VWDEVSTTREF", 1000);
      apiTGrid.AddColumn(Resources.col_SousTraitant, "VPERNOM", 1300);
      apiTGrid.AddColumn(Resources.col_DateArrivee, "DWDEVDATE", 850, "Date");
      apiTGrid.AddColumn(MZCtrlResources.col_Client, "VCLINOM", 1400);
      apiTGrid.AddColumn(Resources.col_Site, "VSITNOM", 1500);
      apiTGrid.AddColumn(Resources.col_Titre, "VWDEVTITRE", 1700);
      apiTGrid.AddColumn(Resources.col_Montant, "NDEVSTTPRIX", 900, "", 2);
      apiTGrid.AddColumn(Resources.col_Chaff, "CHAFF", 1000);
      apiTGrid.AddColumn(Resources.col_Description, "LIB", 2500);
      apiTGrid.AddColumn(Resources.col_fournitures, "VWDEVFOU", 1700);
      apiTGrid.AddColumn("numcli", "NCLINUM", 0);
      apiTGrid.AddColumn("numsite", "NSITNUM", 0);
      apiTGrid.AddColumn(Resources.col_heure, "NHEUREJ", 0);
      apiTGrid.AddColumn(Resources.col_heuren, "NHEUREN", 0);
      apiTGrid.AddColumn(Resources.col_Tech, "NBTECH", 0);
      apiTGrid.AddColumn(Resources.col_DevTraite, "DevTraite", 0);

      apiTGrid.InitColumnList();
    }
    //Private Sub InitApigrid()
    //  
    //  apiTGrid.AddColumn "Num", "NWDEVNUM", 0
    //  apiTGrid.AddColumn "N°", "VWDEVSTTREF", 1000
    //  apiTGrid.AddColumn "§SousTraitant§", "VPERNOM", 1300
    //  apiTGrid.AddColumn "§Date arrivée §", "DWDEVDATE", 850, "dd/mm/yyyy hh:mm:ss"
    //  apiTGrid.AddColumn "§Client§", "VCLINOM", 1400
    //  apiTGrid.AddColumn "§Site§", "VSITNOM", 1500
    //  apiTGrid.AddColumn "§Titre§", "VWDEVTITRE", 1700
    //  apiTGrid.AddColumn "§Montant§", "NDEVSTTPRIX", 900, , 2
    //  apiTGrid.AddColumn "§Chaff§", "CHAFF", 1000
    //  apiTGrid.AddColumn "§Description§", "LIB", 2500
    //  apiTGrid.AddColumn "§Fournitures§", "VWDEVFOU", 1500
    //  apiTGrid.AddColumn "numcli", "NCLINUM", 0
    //  apiTGrid.AddColumn "numsite", "NSITNUM", 0
    //  apiTGrid.AddColumn "§heure§", "NHEUREJ", 0
    //  apiTGrid.AddColumn "§heuren§", "NHEUREN", 0
    //  apiTGrid.AddColumn "§tech§", "NBTECH", 0
    //  apiTGrid.AddColumn "§DevTraite§", "DevTraite", 0
    //  
    //  ' Tooltip sur des cellules
    //  apiTGrid.AddCellTip "VPERNOM", &HFDF0DA            ' Tip = contenu de la cellule entière   ' Vert pale
    //  apiTGrid.AddCellTip "DWDEVDATE", &HFDF0DA
    //  apiTGrid.AddCellTip "VCLINOM", &HFDF0DA
    //  apiTGrid.AddCellTip "VSITNOM", &HFDF0DA
    //  apiTGrid.AddCellTip "VWDEVTITRE", &HFDF0DA
    //  apiTGrid.AddCellTip "VWDEVFOU", &HFDF0DA
    //  apiTGrid.AddCellTip "LIB", &HFDF0DA
    //  apiTGrid.AddCellTip "CHAFF", &HFDF0DA
    //  
    //  apiTGrid.Init rs
    //End Sub
    //
    /* --------------------------------------------------------------------------------------- */
    //Private Sub Form_Unload(Cancel As Integer)
    //  Screen.MousePointer = vbDefault
    //End Sub
    //
    /* --------------------------------------------------------------------------------------- */
    private void cmdQuitter_Click(object sender, System.EventArgs e)
    {
      Dispose();
    }
    //Private Sub cmdQuitter_Click()
    //  Unload Me
    //End Sub
    //
    //

  }
}

