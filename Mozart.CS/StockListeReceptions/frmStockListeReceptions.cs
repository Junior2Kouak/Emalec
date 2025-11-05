using MZCtrlResources = MozartControls.Properties.Resources;
using DevExpress.XtraGrid.Views.Grid;
using Microsoft.VisualBasic;
using MozartCS.Properties;
using MozartNet;
using MozartUC;
using MozartLib;
using System;
using System.Data;
using System.Drawing;
using System.Reflection;
using System.Windows.Forms;
using MZUtils = MozartControls.Utils;

namespace MozartCS
{
  public partial class frmStockListeReceptions : Form
  {
    public string mstrType;
    DataTable dt = new DataTable();

    public frmStockListeReceptions()
    {
      InitializeComponent();
    }

    private void frmStockListeReceptions_Load(object sender, System.EventArgs e)
    {
      try
      {
        Cursor = Cursors.WaitCursor;

        if (mstrType == "ALL")
          this.Text = Resources.txt_listCommandes;
        else
          this.Text = Resources.txt_listCommandesReappro;

        Label1.Text = this.Text;

        ModuleMain.Initboutons(this);

        apiTGrid.GridControl.BackColor = Color.FromArgb(192, 255, 255);
        Check2.BackColor = ModuleMain.Couleur(MozartParams.NomSociete);

        LoadApiGrid();
        InitApiTgrid();
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

    private void cmdFermer_Click(object sender, System.EventArgs e)
    {
      Dispose();
    }

    private void LoadApiGrid()
    {
      string sSql = "";

      if (mstrType == "ALL")
        sSql = "SELECT * FROM api_v_ListeCommandesFournitures WHERE NCOMETAT <> 1 AND CCOMACTIF = 'O'";
      else    // "995"
        sSql = "SELECT * FROM api_v_ListeCommandesFournitures WHERE NDINCTE = 995 AND NCOMETAT <> 1 AND CCOMACTIF = 'O'";

      apiTGrid.LoadData(dt, MozartDatabase.cnxMozart, sSql);
      apiTGrid.GridControl.DataSource = dt;
    }

    /* OK ---------------------------------------------------------------------*/
    private void cmdDetail_Click(object sender, EventArgs e)
    {
      DataRow row = apiTGrid.GetFocusedDataRow();
      if (row == null)
        return;

      Cursor = Cursors.WaitCursor;

      int bookmark = apiTGrid.dgv.FocusedRowHandle;
      MozartParams.NumDi = Convert.ToInt32(Strings.Right(row["NDINNUM"].ToString(), row["NDINNUM"].ToString().Length - 2));
      MozartParams.NumAction = (int)row["NACTNUM"];

      frmStockReception f = new frmStockReception
      {
        mstrStatut = "M",
        miNumCommande = Convert.ToInt64(Strings.Mid(row["NCOMNUM"].ToString(), 3))
      };

      f.ShowDialog();

      LoadApiGrid();
      apiTGrid.dgv.FocusedRowHandle = bookmark;

      MozartParams.NumDi = 0;
      MozartParams.NumAction = 0;

      Cursor = Cursors.Default;
    }

    private void cmdArchives_Click(object sender, EventArgs e)
    {
      Cursor = Cursors.WaitCursor;
      frmStockListeReceptionsArch f = new frmStockListeReceptionsArch()
      {
        mstrType = mstrType
      };
      f.ShowDialog();

      LoadApiGrid();

      Cursor = Cursors.Default;
    }

    private void cmdArchiver_Click(object sender, EventArgs e)
    {
      DataRow row = apiTGrid.GetFocusedDataRow();
      if (row == null)
        return;

      if (MessageBox.Show(Resources.msg_ArchiverCommande, Program.AppTitle, MessageBoxButtons.YesNo, MessageBoxIcon.Question,
        MessageBoxDefaultButton.Button2) == DialogResult.Yes)
      {
        int bookmark = apiTGrid.dgv.FocusedRowHandle;
        string nComNum = Strings.Mid(row["NCOMNUM"].ToString(), 3);
        ModuleData.CnxExecute("UPDATE TCOM SET NCOMETAT = 1 WHERE NCOMNUM = " + nComNum);

        ModuleData.CnxExecute($"UPDATE TFOUSTE SET NFOUQTECDE = dbo.TotalEnCde(NFOUNUM) where VSOCIETE = App_Name() AND NFOUNUM in (SELECT NFOUNUM FROM TLCO WHERE NCOMNUM = {nComNum})");

        LoadApiGrid();
        apiTGrid.dgv.FocusedRowHandle = bookmark;
      }

    }

    private void InitApiTgrid()
    {
      try
      {
        apiTGrid.AddColumn(Resources.col_cde, "NCOMNUM", 1100);
        apiTGrid.AddColumn(Resources.col_Fournisseur, "VSTFNOM", 2200, "", 0, true);
        apiTGrid.AddColumn(Resources.col_DateCde, "DCOMDAT", 1200);
        apiTGrid.AddColumn(Resources.col_retard, "JRETARD", 900, "", 2);
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

    private void apiTGrid_DoubleClick(object sender, EventArgs e)
    {
      cmdDetail_Click(null, null);
    }

    private void Check2_CheckedChanged(object sender, EventArgs e)
    {
      if (Check2.Checked)
        apiTGrid.dgv.ActiveFilterString = "NCOMETAT = 0";
      else
        apiTGrid.dgv.ActiveFilterString = "";
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

  }
}