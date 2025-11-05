using MozartCS.Properties;
using MozartLib;
using MozartNet;
using MozartUC;
using System;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.IO;
using System.Reflection;
using System.Runtime.InteropServices;
using System.Windows.Forms;
using Excel = Microsoft.Office.Interop.Excel;
using MZUtils = MozartControls.Utils;

namespace MozartCS
{
  public partial class frmStockAjout : Form
  {
    private DataTable dtFou;
    private int miFouNum;

    public frmStockAjout() { InitializeComponent(); }

    private void frmStockAjout_Load(object sender, System.EventArgs e)
    {
      try
      {
        Cursor.Current = Cursors.WaitCursor;
        ModuleMain.Initboutons(this);
        dtFou = new DataTable();

        /*
        cboTech.Init(MozartDatabase.cnxMozart, "select 0, ' MAGASIN' as VPERNOM UNION SELECT NPERNUM, VPERNOM + ' ' + VPERPRE from TPER where VSOCIETE = App_Name() " +
                     "AND CPERTYP='TE' AND CPERACTIF = 'O' ORDER BY  VPERNOM", "Column1", "VPERNOM", new List<string>() { Resources.col_Num, Resources.col_Nom }, 150, 550, true);
        cboTech.SetText(" MAGASIN");
        */

        InitApigrid();
        // on affiche que les fournitures gérées en stock par défaut à l'ouverture de la page pour que ce soit plus rapide
        chkStock.Checked = true;
        //cboTech_TxtChanged(null, null);
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


    private void chkStockCli_CheckedChanged(object sender, EventArgs e)
    {
      if (chkStockCli.Checked)
        apiTGrid.dgv.ActiveFilterString = "[GESTION] = 1";
      else
        apiTGrid.dgv.ActiveFilterString = "[GESTION] LIKE '%%'";
      apiTGrid.dgv.MoveFirst();
    }

    private void cmdDetailFou_Click(object sender, EventArgs e)
    {
      if (null != worker) return;

      DataRow row = apiTGrid.GetFocusedDataRow();
      if (null == row) return;
      new frmDetailsFourniture()
      {
        mstrStatut = "M",
        mbStatutValidation = true,
        miNumFour = (int)Utils.ZeroIfNull(row["NFOUNUM"])
      }.ShowDialog();
    }

    private void cmdInv_Click(object sender, EventArgs e)
    {
      if (null != worker) return;

      DataRow row = apiTGrid.GetFocusedDataRow();
      if (null == row) return;
      new frmStockSaisieInventaire()
      {
        mlNFOUNUM = (int)Utils.ZeroIfNull(row["NFOUNUM"])
      }.ShowDialog();
    }

    BackgroundWorker worker = null;
    DataTable dt = null;
    Excel.Application xlApp = null;
    Excel.Workbook xlBook = null;
    Excel.Worksheet xlSheet = null; // Feuille Excel
    bool EditFicheInvCompleted = false;
    private void CmdEditFicheInv_Click(object sender, EventArgs e)
    {
      if (null != worker)
        return;
      try
      {
        Cursor.Current = Cursors.WaitCursor;
        EditFicheInvCompleted = false;

        dt = new DataTable();
        ModuleData.LoadData(dt, "SELECT VFOUSER, VFOUMAT, VFOUMAR, VFOUTYP, VFOUREF, NFOUQTESTOCK, '' AS  NFOUQTEINV " +
                                "FROM api_v_ListeFournituresStockMagasin_v2 WHERE NFOUQTESTOCK > 0 AND MINI > 0 ORDER BY VFOUSER, VFOUMAT");
        if (0 == dt.Rows.Count)
          return;

        worker = new BackgroundWorker();
        int rowscount = dt.Rows.Count;
        PBCreateFile.Minimum = 0;
        PBCreateFile.Maximum = rowscount;
        PBCreateFile.Value = 0;
        FrameProgressBar.Visible = true;
        LblNbLignes.Text = $"{FrameProgressBar.Text} - 0 / {rowscount}";

        worker.DoWork += this.worker_DoWork;
        worker.ProgressChanged += this.worker_ProgressChanged;
        worker.RunWorkerCompleted += this.worker_RunWorkerCompleted;
        worker.WorkerReportsProgress = true;
        worker.WorkerSupportsCancellation = true;
        worker.RunWorkerAsync();
        this.Cursor = Cursors.WaitCursor;
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

    private void worker_DoWork(object sender, DoWorkEventArgs e)
    {
      try
      {
        BackgroundWorker worker = sender as BackgroundWorker;

        string cheminUtil = $@"{MozartParams.CheminUtilisateurMozart}FicheRelInvStock.xls";
        File.Copy($@"{MozartParams.CheminModeles}{MozartParams.Langue}\FicheRelInvStock.xls",
                  cheminUtil, true);
        //  ouverture du fichier   utilisation de l'objet feuille d'Excel
        xlApp = new Microsoft.Office.Interop.Excel.Application();
        xlBook = xlApp.Workbooks.Open(cheminUtil, Missing.Value, false);
        xlSheet = (Microsoft.Office.Interop.Excel.Worksheet)xlBook.ActiveSheet;
        int i = 2;
        int rowscount = dt.Rows.Count;
        string lib_generation_fichier = Resources.lib_generation_fichier;
        foreach (DataRow row in dt.Rows)
        {
          xlSheet.Cells[i, 1] = Utils.BlankIfNull(row["VFOUSER"]);
          xlSheet.Cells[i, 2] = Utils.BlankIfNull(row["VFOUMAT"]);
          xlSheet.Cells[i, 3] = Utils.BlankIfNull(row["VFOUMAR"]);
          xlSheet.Cells[i, 4] = Utils.BlankIfNull(row["VFOUTYP"]);
          xlSheet.Cells[i, 5] = Utils.BlankIfNull(row["VFOUREF"]);
          xlSheet.Cells[i, 6] = Utils.ZeroIfNull(row["NFOUQTESTOCK"]);
          xlSheet.Cells[i, 7] = Utils.ZeroIfNull(row["NFOUQTEINV"]);
          worker.ReportProgress(i - 2 / rowscount, lib_generation_fichier + " - " + i.ToString() + " / " + rowscount.ToString());
          i++;
          //tests
          //if (100 == i) break;
          if (worker.CancellationPending)
            break;
        }

        if (!worker.CancellationPending)
        {
          Utils.Quadrillage(xlSheet.Range[xlSheet.Cells[1, 1], xlSheet.Cells[i - 1, 7]]);
          xlBook.Close(true, Type.Missing, Type.Missing);
          EditFicheInvCompleted = true;
        }
        else xlBook.Close(false, Type.Missing, Type.Missing);
        xlApp.Quit();
      }
      catch (Exception ex)
      {
        if (null != worker)
        {
          worker.Dispose();
          worker = null;
        }
        MZUtils.displayError(MethodBase.GetCurrentMethod().Name, ex);
      }
      finally
      {
        if (null != xlSheet) Marshal.ReleaseComObject(xlSheet);
        if (null != xlBook) Marshal.ReleaseComObject(xlBook);
        if (null != xlApp) Marshal.ReleaseComObject(xlApp);
      }
    }

    private void worker_RunWorkerCompleted(object sender, RunWorkerCompletedEventArgs e)
    {
      this.Cursor = Cursors.Default;
      if (null != worker)
        worker.Dispose();
      worker = null;
      FrameProgressBar.Visible = false;
      Cursor.Current = Cursors.Default;
      if (!EditFicheInvCompleted)
        return;
      new frmBrowser()
      {
        msStartingAddress = $@"{MozartParams.CheminUtilisateurMozart}FicheRelInvStock.xls"
      }.ShowDialog();
    }
    private void worker_ProgressChanged(object sender, ProgressChangedEventArgs e)
    {
      LblNbLignes.Text = e.UserState.ToString();
      PBCreateFile.Value++;
    }

    private void cboTech_TxtChanged(object sender, EventArgs e)
    {
      try
      {
        Cursor.Current = Cursors.WaitCursor;
        string sql;
        if (cboTech.GetText() != " MAGASIN")
          sql = $"SELECT* FROM api_v_ListeFournituresStockTech WHERE NSTOCKLIEU = {cboTech.GetItemData()} ORDER BY VPERNOM desc, VFOUSER, VFOUMAT";
        else
          sql = $"SELECT * FROM api_v_ListeFournituresStockMagasin_v2 ORDER BY VPERNOM desc, VFOUSER, VFOUMAT";

        apiTGrid.LoadData(dtFou, MozartDatabase.cnxMozart, sql);

        apiTGrid_ClickE(null, null);
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

    /* --------------------------------------------------------------------------------------- */
    private void chkStock_CheckedChanged(object sender, EventArgs e)
    {
      lblLabels2.Visible = false;
      if (chkStock.Checked)
      {
        try
        {
          Cursor.Current = Cursors.WaitCursor;
          apiTGrid.LoadData(dtFou, MozartDatabase.cnxMozart, "SELECT * FROM api_v_ListeFournituresStockMagasin_v2 WHERE MINI > 0 ORDER BY VPERNOM desc, VFOUSER, VFOUMAT");
          apiTGrid_ClickE(null, null);
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
      else
      {
        try
        {
          Cursor.Current = Cursors.WaitCursor;
          apiTGrid.LoadData(dtFou, MozartDatabase.cnxMozart, "SELECT * FROM api_v_ListeFournituresStockMagasin_v2 ORDER BY VPERNOM desc, VFOUSER, VFOUMAT");
          apiTGrid_ClickE(null, null);
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
      //apiTGrid.dgv.ActiveFilterString = "";//ne pas faire sinon impacte filtre chkStockCli_CheckedChanged
    }

    private void cmdMouvements_Click(object sender, EventArgs e)
    {
      if (null != worker) return;

      DataRow row = apiTGrid.GetFocusedDataRow();
      if (null == row) return;
      if (row["NSTOCKLIEU"] == DBNull.Value)
      {
        MessageBox.Show(Resources.msg_aucun_mouv_article, Program.AppTitle, MessageBoxButtons.OK, MessageBoxIcon.Information);
        return;
      }
      new frmStockMouvements()
      {
        miFouNum = (int)Utils.ZeroIfNull(row["NFOUNUM"]),
        miNumStock = (int)Utils.ZeroIfNull(row["NSTOCKLIEU"]),
        mstrType = "FOURNITURE",
        miVFOUMAT = Utils.BlankIfNull(row["VFOUMAT"]),
        miNQTEACTUEL = (int)Utils.ZeroIfNull(row["NFOUQTESTOCK"]),
        miNQTECDE = (int)Utils.ZeroIfNull(row["QteAttendue"])
      }.ShowDialog();
    }

    private void cmdCommandes_Click(object sender, EventArgs e)
    {
      if (null != worker) return;

      DataRow row = apiTGrid.GetFocusedDataRow();
      if (null == row) return;
      new frmListeCommandesFour()
      {
        miFouNum = (int)Utils.ZeroIfNull(row["NFOUNUM"]),
        miCompte = 995,   //(cboTech.GetItemData() == 0) ? 995 : cboTech.GetItemData(),
        mstrStatutCom = "S"
      }.ShowDialog();
    }

    private void apiTGrid_ClickE(object sender, EventArgs e)
    {
      DataRow row = apiTGrid.GetFocusedDataRow();
      if (null == row) return;
      cmdCommandes.Visible = Utils.ZeroIfNull(row["QteAttendue"]) > 0;
      miFouNum = (int)Utils.ZeroIfNull(row["NFOUNUM"]);
      txtArticle.Text = Utils.BlankIfNull(row["VFOUMAT"]);
      txtDateEntree.Text = DateTime.Now.ToShortDateString();
      double prix = Utils.ZeroIfNull(row["Prix"]);
      txtPrix.Text = (prix == 0) ? "" : prix.ToString("#.##");
      if (row["DatePrix"] == DBNull.Value) lblDatePrix.Text = "";
      else lblDatePrix.Text = $"{Resources.lib_au}{Utils.BlankIfNull(row["DatePrix"])})";
      if (Utils.ZeroIfNull(row["NFOUQTESTOCK"]) > 0)
      {
        txtQte.Text = Utils.ZeroIfNull(row["NFOUQTESTOCK"]).ToString();
        lblStock.Text = $"{Resources.lib_stock_actuel}{Utils.ZeroIfNull(row["NFOUQTESTOCK"])})";
      }
      else
      {
        txtQte.Text = "";
        lblStock.Text = Resources.lib_pas_de_stock;
      }
      txtStockMini.Text = (Utils.ZeroIfNull(row["MINI"]) > 0) ? Utils.ZeroIfNull(row["MINI"]).ToString() : "";
      txtStockMaxi.Text = (Utils.ZeroIfNull(row["MAXI"]) > 0) ? Utils.ZeroIfNull(row["MAXI"]).ToString() : "";
      cboLieu.Text = "MAGASIN PRINCIPAL";
    }

    private void cmdFermer_Click(object sender, System.EventArgs e)
    {
      if (null != worker)
      {
        worker.CancelAsync();
      }
      Dispose();
    }

    private void cmdValider_Click(object sender, EventArgs e)
    {
      if (null != worker) return;

      DataRow row = apiTGrid.GetFocusedDataRow();
      if (null == row) return;
      try
      {
        Cursor.Current = Cursors.WaitCursor;

        using (SqlCommand cmd = new SqlCommand("api_sp_MAJ_StockArticle", MozartDatabase.cnxMozart))
        {
          cmd.CommandType = CommandType.StoredProcedure;
          SqlCommandBuilder.DeriveParameters(cmd);    // liste des paramètres

          //  liste des paramètres
          cmd.Parameters["@FouNum"].Value = (int)Utils.ZeroIfNull(row["NFOUNUM"]);
          cmd.Parameters["@Qte"].Value = (txtQte.Text != "") ? txtQte.Text : null;
          cmd.Parameters["@Prix"].Value = txtPrix.Text;
          cmd.Parameters["@DateEntree"].Value = txtDateEntree.Text;

          cmd.ExecuteNonQuery();
        }
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


    private void apiTGrid_CellValueChanged(object sender, DevExpress.XtraGrid.Views.Base.CellValueChangedEventArgs e)
    {
      DataRow CurrentRow = apiTGrid.GetFocusedDataRow();
      if (null == CurrentRow) return;
      // colonne stock
      if (e.Column.AbsoluteIndex == 9)
      {
        try
        {
          //txtQte.Text = Utils.BlankIfNull(CurrentRow["NFOUQTESTOCK"]).ToString();
          //cmdValider_Click(null, null);
          using (SqlCommand cmd = new SqlCommand("api_sp_MAJ_StockArticle", MozartDatabase.cnxMozart))
          {
            cmd.CommandType = CommandType.StoredProcedure;
            SqlCommandBuilder.DeriveParameters(cmd);    // liste des paramètres

            //  liste des paramètres
            cmd.Parameters["@FouNum"].Value = (int)Utils.ZeroIfNull(CurrentRow["NFOUNUM"]);
            cmd.Parameters["@Qte"].Value = (int)Utils.ZeroIfNull(CurrentRow["NFOUQTESTOCK"]);
            cmd.Parameters["@Prix"].Value = txtPrix.Text;
            cmd.Parameters["@DateEntree"].Value = txtDateEntree.Text;

            cmd.ExecuteNonQuery();
            cmd.Dispose();
          }
        }
        catch (Exception ex)
        {
          MZUtils.displayError(MethodBase.GetCurrentMethod().Name, ex);
        }
      }
      //colonne maxi
      if (e.Column.AbsoluteIndex == 11 || e.Column.AbsoluteIndex == 12)
      {
        try
        {

          txtStockMaxi.Text = Utils.BlankIfNull(CurrentRow["MAXI"]);
          txtStockMini.Text = Utils.BlankIfNull(CurrentRow["MINI"]);

          using (SqlCommand cmd = new SqlCommand("api_sp_MAJ_StockMinMax", MozartDatabase.cnxMozart))
          {
            cmd.CommandType = CommandType.StoredProcedure;
            SqlCommandBuilder.DeriveParameters(cmd);    // liste des paramètres

            //  liste des paramètres
            cmd.Parameters["@FouNum"].Value = (int)Utils.ZeroIfNull(CurrentRow["NFOUNUM"]);
            cmd.Parameters["@Mini"].Value = (txtStockMini.Text != "") ? txtStockMini.Text : "NULL";
            cmd.Parameters["@Maxi"].Value = (txtStockMaxi.Text != "") ? txtStockMaxi.Text : "NULL";

            cmd.ExecuteNonQuery();
            cmd.Dispose();
          }
        }
        catch (Exception ex)
        {
          MZUtils.displayError(MethodBase.GetCurrentMethod().Name, ex);
        }
      }

    }

    private void apiTGrid_CellValueChanging(object sender, DevExpress.XtraGrid.Views.Base.CellValueChangedEventArgs e)
    {
      //int v;
      //if (!int.TryParse(e.Value.ToString(), out v))
      //{
      //  MessageBox.Show(Resources.lib_saisie_numerique, Program.AppTitle, MessageBoxButtons.OK, MessageBoxIcon.Information);
      //  (sender as GridView).CancelUpdateCurrentRow();
      // }
    }

    private void cmdDate_Click(object sender, EventArgs e)
    {
      Cal.Visible = true;
      DateTime d;
      if (DateTime.TryParse(txtDateEntree.Text, out d))
        Cal.Value = d;
      else Cal.Value = DateTime.Now;
    }

    private void Cal_CloseUp(object sender, EventArgs e)
    {
      txtDateEntree.Text = Cal.Value.ToShortDateString();
      Cal.Visible = false;
    }

    private void cmdSupp_Click(object sender, EventArgs e)
    {
      txtDateEntree.Text = "";
    }

    private void InitApigrid()
    {
      apiTGrid.AddColumn(Resources.col_FouNum, "NFOUNUM", 0);
      apiTGrid.AddColumn(Resources.col_Lieu, "VPERNOM", 1000);
      apiTGrid.AddColumn(Resources.col_série, "VFOUSER", 1000);
      apiTGrid.AddColumn(Resources.col_Article, "VFOUMAT", 3100);
      apiTGrid.AddColumn(Resources.col_marque, "VFOUMAR", 1200);
      apiTGrid.AddColumn(Resources.col_Type, "VFOUTYP", 1200);
      apiTGrid.AddColumn(Resources.col_reference, "VFOUREF", 1200);
      apiTGrid.AddColumn(Resources.col_Emplacement, "VFOUEMPLACEMENT", 1000);
      apiTGrid.AddColumn(Resources.col_pcb, "NFOUNBLOT", 700, "", 2);
      apiTGrid.AddColumn(Resources.col_qte3, "NFOUQTESTOCK", 700, "", 2);
      apiTGrid.AddColumn(Resources.col_qcdee, "QteAttendue", 700, "", 2);
      apiTGrid.AddColumn(Resources.col_mini, "MINI", 600, "", 2);
      apiTGrid.AddColumn(Resources.col_maxi, "MAXI", 600, "", 2);
      apiTGrid.AddColumn("Conso 12 mois", "CONSOMMATION", 900, "", 2);
      apiTGrid.AddColumn("Autonomie", "AUTONOMIE", 900, "", 2);
      //  'apiTGrid.AddColumn "§Util§", "NFOUNBUTIL", 600, , 2
      apiTGrid.AddColumn("N", "UTILN", 600, "", 2);
      apiTGrid.AddColumn("N-1", "UTILNLAST", 600, "", 2);
      apiTGrid.AddColumn(Resources.col_Gestion, "GESTION", 0);
      apiTGrid.AddColumn(Resources.col_dernier_inventaire, "DINV", 1000, "dd/mm/yy", 2);

      apiTGrid.InitColumnList();

      if (ModuleMain.RechercheDroitMenu(614))
        apiTGrid.DelockColumn("NFOUQTESTOCK");
      apiTGrid.DelockColumn("MINI");
      apiTGrid.DelockColumn("MAXI");

      apiTGrid.GridControl.DataSource = dtFou;
    }

    private void apiTGrid_RowCellStyle(object sender, DevExpress.XtraGrid.Views.Grid.RowCellStyleEventArgs e)
    {
      if (e.CellValue == null) return;
      double val = 0;
      bool b = Double.TryParse(e.CellValue.ToString(), out val);
      if (!b) return;
      if (e.Column.Name == "AUTONOMIE")
      {
        if (val > 4)
        {
          e.Appearance.ForeColor = Color.Red;
          e.Appearance.BackColor = MozartColors.colorHCCCCCC;
          e.Appearance.Font = new Font(e.Appearance.Font, FontStyle.Bold);
        }
        else if (val == 0)
        {
          e.Appearance.ForeColor = MozartColors.colorHCCCCCC;
          e.Appearance.BackColor = Color.White;
        }
      }
      else if (e.Column.Name == "NFOUQTESTOCK")
      {
        if (val > 0)
        {
          e.Appearance.ForeColor = Color.Red;
          e.Appearance.BackColor = MozartColors.colorHCCCCCC;
          e.Appearance.Font = new Font(e.Appearance.Font, FontStyle.Bold);
        }
        else if (val == 0)
        {
          e.Appearance.ForeColor = MozartColors.colorHCCCCCC;
          e.Appearance.BackColor = Color.White;
        }
      }
    }
  }
}

