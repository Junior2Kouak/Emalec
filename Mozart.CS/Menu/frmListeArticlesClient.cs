using MZCtrlResources = MozartControls.Properties.Resources;
using DevExpress.XtraGrid.Views.Grid;
using MozartCS.Properties;
using MozartLib;
using MozartNet;
using MozartUC;
using System;
using System.Data;
using System.Drawing;
using System.Reflection;
using System.Windows.Forms;
using MZUtils = MozartControls.Utils;

namespace MozartCS
{
  public partial class frmListeArticlesClient : Form
  {
    public int miNumClient;

    DataTable dt_Pri = new DataTable();
    DataTable dt_Sec = new DataTable();

    public frmListeArticlesClient() { InitializeComponent(); }


    private void frmListeArticlesClient_Load(object sender, System.EventArgs e)
    {
      try
      {
        Cursor.Current = Cursors.WaitCursor;
        ModuleMain.Initboutons(this);

        apiTGridC.LoadData(dt_Pri, MozartDatabase.cnxMozart, "api_sp_ListeClientGestStock");
        apiTGridC.GridControl.DataSource = dt_Pri;
        InitApigrid();

        DataRow currentRow = apiTGridC.GetFocusedDataRow();
        if (currentRow == null) return;

        //datatable secondaire: liste des sites de la première ligne par défaut
        string sSQL = $"SELECT  VSITNOM, NSITNUE, VSITVIL, NSITNUM, " +
                      $"(select count(NFOUNUM) from TSTOCKARTCLISIT where ISNULL(NQTESTOK, 0) > 0 AND NCLINUM=TSIT.NCLINUM and NSITNUM=TSIT.NSITNUM) 'CODE'" +
                      $" From TSIT WHERE NCLINUM = {Utils.ZeroIfNull(currentRow["NCLINUM"])} AND CSITACTIF='O' ORDER BY VSITNOM";

        apiTGrid.LoadData(dt_Sec, MozartDatabase.cnxMozart, sSQL);
        apiTGrid.GridControl.DataSource = dt_Sec;
        InitApiTgrid();
        if (miNumClient != 0) apiTGridC.dgv.ActiveFilterString = $"NCLINUM = {miNumClient}";
      }
      catch (Exception ex)
      {
        MZUtils.displayError(MethodBase.GetCurrentMethod().Name, ex);
      }
      finally { Cursor.Current = Cursors.Default; }
    }


    private void cmdNouvelle_Click(object sender, EventArgs e)
    {
      new frmStockArticleClient
      {
        mstrStatut = "C",
        miNumClient = 0,
        mstrActif = "N"
      }.ShowDialog();

      //rafraichissement de la grille
      apiTGridC.Requery(dt_Pri, MozartDatabase.cnxMozart);
    }

    private void cmdValider_Click(object sender, EventArgs e)
    {
      DataRow currentRow = apiTGridC.GetFocusedDataRow();
      if (currentRow == null) return;

      Cursor.Current = Cursors.WaitCursor;

      new frmStockArticleClient
      {
        mstrStatut = "M",
        miNumClient = (int)Utils.ZeroIfNull(currentRow["NCLINUM"]),
        mstrActif = Utils.BlankIfNull(currentRow["CACTIF"])
      }.ShowDialog();

      apiTGridC.Requery(dt_Pri, MozartDatabase.cnxMozart);

      Cursor.Current = Cursors.Default;
    }

    private void cmdCopyStock_Click(object sender, EventArgs e)
    {
      new frmCopyStock().ShowDialog();

      //rafraichissement du la grille
      apiTGridC.Requery(dt_Pri, MozartDatabase.cnxMozart);
    }

    private void cmdActiver_Click(object sender, EventArgs e)
    {
      DataRow currentRow = apiTGridC.GetFocusedDataRow();
      if (currentRow == null) return;

      if (MessageBox.Show(Resources.msg_activerGestStockCli, Program.AppTitle, MessageBoxButtons.YesNo, MessageBoxIcon.Question,
                          MessageBoxDefaultButton.Button2) != DialogResult.Yes) return;

      ModuleData.CnxExecute($"update TSTOCKARTCLI set CACTIF = 'O' FROM TSTOCKARTCLI INNER JOIN TFOU ON TSTOCKARTCLI.NFOUNUM = TFOU.NFOUNUM WHERE NCFOCOD <> 31 AND TSTOCKARTCLI.NCLINUM = {Utils.ZeroIfNull(currentRow["NCLINUM"])}");

      //rafraichissement de la grille
      apiTGridC.Requery(dt_Pri, MozartDatabase.cnxMozart);
    }

    private void cmdDesactiver_Click(object sender, EventArgs e)
    {
      DataRow currentRow = apiTGridC.GetFocusedDataRow();
      if (currentRow == null) return;

      if (MessageBox.Show(Resources.msg_desactiverFestStockCli, Program.AppTitle, MessageBoxButtons.YesNo, MessageBoxIcon.Question,
                          MessageBoxDefaultButton.Button2) != DialogResult.Yes) return;

      ModuleData.CnxExecute($"update TSTOCKARTCLI set CACTIF = 'N' FROM TSTOCKARTCLI INNER JOIN TFOU ON TSTOCKARTCLI.NFOUNUM = TFOU.NFOUNUM WHERE NCFOCOD <> 31 AND TSTOCKARTCLI.NCLINUM =  {Utils.ZeroIfNull(currentRow["NCLINUM"])}");

      //rafraichissement de la grille
      apiTGridC.Requery(dt_Pri, MozartDatabase.cnxMozart);
    }

    private void cmdInv_Click(object sender, EventArgs e)
    {
      DataRow currentRowPri = apiTGridC.GetFocusedDataRow();
      DataRow currentRowSec = apiTGrid.GetFocusedDataRow();
      if (currentRowPri == null || currentRowSec == null) return;

      new frmStockArticleClientSite
      {
        mstrStatut = "INV",
        mstrStatutInv = "V", //visu uniquement
        miNumSite = (int)Utils.ZeroIfNull(currentRowSec["NSITNUM"]),
        miNumClient = (int)Utils.ZeroIfNull(currentRowPri["NCLINUM"]),
      }.ShowDialog();
    }

    private void cmdStock_Click(object sender, EventArgs e)
    {
      DataRow currentRowPri = apiTGridC.GetFocusedDataRow();
      DataRow currentRowSec = apiTGrid.GetFocusedDataRow();
      if (currentRowPri == null || currentRowSec == null) return;

      new frmStockArticleClientSite
      {
        mstrStatut = "STOCK",
        mstrStatutInv = "V",// visu uniquement
        miNumSite = (int)Utils.ZeroIfNull(currentRowSec["NSITNUM"]),
        miNumClient = (int)Utils.ZeroIfNull(currentRowPri["NCLINUM"])
      }.ShowDialog();
    }

    private void cmdStockTS_Click(object sender, EventArgs e)
    {
      DataRow currentRowPri = apiTGridC.GetFocusedDataRow();
      DataRow currentRowSec = apiTGrid.GetFocusedDataRow();
      if (currentRowPri == null || currentRowSec == null) return;

      new frmStockArticleClientSite
      {
        mstrStatut = "STOCK_TS",
        mstrStatutInv = "V", //visu uniquement
        miNumSite = (int)Utils.ZeroIfNull(currentRowSec["NSITNUM"]),
        miNumClient = (int)Utils.ZeroIfNull(currentRowPri["NCLINUM"])
      }.ShowDialog();
    }

    private void cmdListeInv_Click(object sender, EventArgs e)
    {
      DataRow currentRowPri = apiTGridC.GetFocusedDataRow();
      if (currentRowPri == null) return;

      new frmListeInventaires
      {
        miNumClient = (int)Utils.ZeroIfNull(currentRowPri["NCLINUM"])
      }.ShowDialog();
    }

    private void InitApigrid()
    {
      apiTGridC.AddColumn(MZCtrlResources.col_Client, "VCLINOM", 2500, "", 0, true);
      apiTGridC.AddColumn(Resources.col_Actif, "CACTIF", 400);
      apiTGridC.AddColumn("NCLINUM", "NCLINUM", 0);

      apiTGridC.InitColumnList();
    }

    private void InitApiTgrid()
    {
      apiTGrid.AddColumn(Resources.col_Site, "VSITNOM", 3600, "", 0, true);
      apiTGrid.AddColumn("N°", "NSITNUE", 900, "", 2);
      apiTGrid.AddColumn(Resources.col_Ville, "VSITVIL", 1800);
      apiTGrid.AddColumn("Num", "NSITNUM", 0);
      apiTGrid.AddColumn(Resources.col_Code, "CODE", 0);

      apiTGrid.InitColumnList();
    }

    private void apiTGrid_RowStyle(object sender, DevExpress.XtraGrid.Views.Grid.RowStyleEventArgs e)
    {
      if (e.RowHandle >= 0)
      {
        if ((sender as GridView).GetDataRow(e.RowHandle)["CODE"].ToString().ToUpper() == "0")
        {
          e.Appearance.Font = new Font(e.Appearance.Font, FontStyle.Bold);
          e.HighPriority = true;
        }
      }
    }
    //Private Sub InitApiTgrid()
    //
    //On Error GoTo handler
    //  
    //  Screen.MousePointer = vbHourglass
    //  
    //  apiTGrid.AddColumn "§Site§", "VSITNOM", 3600
    //  apiTGrid.AddColumn "N°", "NSITNUE", 900, , 2
    //  apiTGrid.AddColumn "§Ville§", "VSITVIL", 1800
    //  apiTGrid.AddColumn "Num", "NSITNUM", 0
    //  apiTGrid.AddColumn "§CODE§", "CODE", 0
    //  
    //  apiTGrid.AddCellTip "VSITNOM", &HFDF0DA
    //    
    //  ' Style sur la ligne entière gras si pas de stock definie
    //  apiTGrid.AddRowStyle "CODE", "CODE", "0", , , True
    //
    //  apiTGrid.Init adoRS_Sec
    //  
    //  Screen.MousePointer = vbDefault
    // 
    //  Exit Sub
    //  
    //handler:
    //  ShowError "InitapiTGrid dans " & Me.Name
    //End Sub
    //

    /* OK --------------------------------------------------------------------------------------- */
    private void apiTGridC_SelectionChanged(object sender, DevExpress.Data.SelectionChangedEventArgs e)
    {
      //on sort s'il n'y a pas d'enregistrement maitre
      DataRow currentRow = apiTGridC.GetFocusedDataRow();
      if (currentRow == null) return;

      //datatable secondaire : liste des sites
      // première ligne par défaut 
      string sSQL = $"SELECT  VSITNOM, NSITNUE, VSITVIL, NSITNUM, " +
                    $"(select count(NFOUNUM) from TSTOCKARTCLISIT where ISNULL(NQTESTOK, 0) > 0 AND NCLINUM=TSIT.NCLINUM and NSITNUM=TSIT.NSITNUM) 'CODE'" +
                    $" From TSIT WHERE NCLINUM = {Utils.ZeroIfNull(currentRow["NCLINUM"])} AND CSITACTIF='O' ORDER BY VSITNOM";

      apiTGrid.LoadData(dt_Sec, MozartDatabase.cnxMozart, sSQL);
    }

    private void cmdFermer_Click(object sender, System.EventArgs e)
    {
      Dispose();
    }

  }
}

