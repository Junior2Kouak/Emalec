using MZCtrlResources = MozartControls.Properties.Resources;
using DevExpress.XtraGrid.Views.Grid;
using Microsoft.VisualBasic;
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
  public partial class frmStockListeReceptionsArch : Form
  {
    public string mstrType;
    DataTable dt = new DataTable();


    public frmStockListeReceptionsArch()
    {
      InitializeComponent();
    }


    private void frmStockListeReceptionsArch_Load(object sender, System.EventArgs e)
    {
      try
      {
        Cursor = Cursors.WaitCursor;

        if (mstrType == "ALL")
          this.Text = Resources.txt_listCommandes;
        else    // "995"
          this.Text = Resources.txt_listCommandesReappro;

        ModuleMain.Initboutons(this);

        apiTGrid.GridControl.BackColor = Color.FromArgb(192, 255, 255);

        LoadGrid();
        InitApiTGrid();
      }
      catch (Exception ex)
      {
        MZUtils.displayError(MethodBase.GetCurrentMethod().Name, ex);
      }
      finally
      {
        Cursor = Cursors.Default;
      }
    }


    private void LoadGrid()
    {
      string sSql = "";
      if (mstrType == "ALL")
        sSql = "SELECT * FROM api_v_ListeCommandesFournitures WHERE NCOMETAT = 1";
      else
        sSql = "SELECT * FROM api_v_ListeCommandesFournitures WHERE NDINCTE = 995 AND NCOMETAT = 1";

      apiTGrid.LoadData(dt, MozartDatabase.cnxMozart, sSql);
      apiTGrid.GridControl.DataSource = dt;
    }

    /* OK ---------------------------------------------------------------------*/
    private void InitApiTGrid()
    {
      try
      {
        apiTGrid.AddColumn(Resources.col_cde, "NCOMNUM", 1100);
        apiTGrid.AddColumn(Resources.col_Fournisseur, "VSTFNOM", 2200, "", 0, true);
        apiTGrid.AddColumn(Resources.col_DateCde, "DCOMDAT", 1200);
        apiTGrid.AddColumn(Resources.col_DI, "NDINNUM", 1000);
        apiTGrid.AddColumn(Resources.col_livraison, "VCOMLLI", 1700, "", 0, true);
        apiTGrid.AddColumn(MZCtrlResources.col_Client, "VCLINOM", 1800, "", 0, true);
        apiTGrid.AddColumn(Resources.col_Site, "VSITNOM", 1800, "", 0, true);
        apiTGrid.AddColumn(Resources.col_Action, "NACTNUM", 0);
        apiTGrid.AddColumn("StfNum", "NSTFNUM", 0);
        apiTGrid.AddColumn(Resources.col_Montant, "Montant", 1000, "# ###.00 € ", 1);
        apiTGrid.AddColumn(Resources.col_etat, "NCOMETAT", 0);

        apiTGrid.InitColumnList();
      }
      catch (Exception ex)
      {
        MZUtils.displayError(MethodBase.GetCurrentMethod().Name, ex);
      }
    }

    private void apiTGrid_RowStyle(object sender, RowStyleEventArgs e)
    {
      GridView View = sender as GridView;
      if (e.RowHandle >= 0)
      {
        if (View.GetDataRow(e.RowHandle)["NCOMETAT"].ToString() == "0")
        {
          e.Appearance.BackColor = Color.FromArgb(255, 192, 192);
          e.HighPriority = true;
        }
      }
    }

    private void apiTGrid_DoubleClickE(object sender, EventArgs e)
    {
      Cursor = Cursors.WaitCursor;
      cmdDetail_Click(null, null);
    }
    private void cmdDetail_Click(object sender, EventArgs e)
    {
      if (apiTGrid.GetFocusedDataRow() == null) return;

      Cursor = Cursors.WaitCursor;
      frmStockReception f = new frmStockReception()
      {
        miNumCommande = Convert.ToInt64(Strings.Mid(apiTGrid.GetFocusedDataRow()["NCOMNUM"].ToString(), 3)),
        mstrStatut = "V"
      };
      f.ShowDialog();

      Cursor = Cursors.Default;
    }
    private void cmdRestaurer_Click(object sender, EventArgs e)
    {
      try
      {
        if (apiTGrid.GetFocusedDataRow() == null)
          return;
        Cursor.Current = Cursors.WaitCursor;
        ModuleData.CnxExecute("UPDATE TCOM SET NCOMETAT = 0 WHERE NCOMNUM = " + Strings.Mid(apiTGrid.GetFocusedDataRow()["NCOMNUM"].ToString(), 3));
        LoadGrid();
        Cursor.Current = Cursors.Default;
      }
      catch (Exception ex)
      {
        MZUtils.displayError(MethodBase.GetCurrentMethod().Name, ex);
      }
    }

    private void cmdFermer_Click(object sender, System.EventArgs e)
    {
      Dispose();
    }

  }
}