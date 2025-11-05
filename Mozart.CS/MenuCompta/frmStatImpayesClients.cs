using Microsoft.VisualBasic;
using MozartCS.Properties;
using MozartLib;
using MozartNet;
using MozartUC;
using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Reflection;
using System.Windows.Forms;
using MZUtils = MozartControls.Utils;
using MZCtrlResources = MozartControls.Properties.Resources;
using DevExpress.XtraGrid.Columns;
using DevExpress.XtraGrid;

namespace MozartCS
{
  public partial class frmStatImpayesClient : Form
  {
    private const string COL_NELFTTC = "NELFTTC";
    private const string COL_NELFHT = "NELFTHT";

    private DataTable dt = new DataTable();

    public frmStatImpayesClient()
    {
      InitializeComponent();
    }

    private void frmStatImpayesClient_Load(object sender, System.EventArgs e)
    {
      try
      {
        Cursor.Current = Cursors.WaitCursor;
        ModuleMain.Initboutons(this);

        cboClient.Init(MozartDatabase.cnxMozart, "api_sp_comboClientChaff", "NCLINUM", "VCLINOM", new List<string>() { Resources.col_Num, MZCtrlResources.col_Client }, 500, 500, true);

        InitTGrid();
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

    private void cmdDetail_Click(object sender, EventArgs e)
    {
      DataRow currentRow = apiTGrid.GetFocusedDataRow();
      if (currentRow == null) return;

      int iFacNum = Convert.ToInt32(Utils.ZeroIfNull(currentRow["NFACNUM"]));

      string sSQL = $"SELECT TFAC.DFACDAT, VCLITYPEFAC" +
              $" FROM TCLI WITH(NOLOCK) INNER JOIN TRSF WITH(NOLOCK) ON TCLI.NCLINUM=TRSF.NCLINUM INNER JOIN TFAC WITH(NOLOCK) ON TRSF.NRSFNUM=TFAC.NRSFNUM" +
              $" WHERE NFACNUM={iFacNum}" +
              $" AND TFAC.VSOCIETE = '{MozartParams.NomSociete}'";

      using (SqlDataReader sdrF = ModuleData.ExecuteReader(sSQL))
      {
        if (sdrF.Read())
        {
          new frmModFacture(iFacNum).ShowDialog();
        }
      }
    }

    private void initStat(string pProcStockTotal, string sProcStockListe)
    {
      Cursor = Cursors.WaitCursor;
      
      using (SqlDataReader sdr = ModuleData.ExecuteReader(pProcStockTotal))
      {
        if (!sdr.Read())
        {
          Cursor = Cursors.Default;

          return;
        }

        // Il faut réinitialiser le datatable
        dt = new DataTable();

        apiLabel[] tabLblTab = { lblTab5, lblTab6, lblTab7, lblTab8, lblTab9, lblTab10 };
        string[] lFieldName = { "NBFACT", "MTFACT", "MTRESTE" };
        int i = 0;
        while (i < 5)
        {
          tabLblTab[i].Text = Utils.ZeroIfNull(sdr[lFieldName[i % 3]]).ToString();
          i++;
          tabLblTab[i].Text = Utils.ZeroIfNull(sdr[lFieldName[i % 3]]).ToString();
          i++;
          tabLblTab[i].Text = Utils.ZeroIfNull(sdr[lFieldName[i % 3]]).ToString();
          i++;
          sdr.Read();
        }
      }

      apiTGrid.LoadData(dt, MozartDatabase.cnxMozart, sProcStockListe);
      apiTGrid.GridControl.DataSource = dt;

      Cursor = Cursors.Default;
    }

    private void InitStat()
    {
      initStat($"EXEC api_sp_ListeFactRetardTot {cboClient.GetItemData()}", $"EXEC api_sp_listeFactRetard '{cboClient.GetItemData()}'");
    }

    private void InitStatAllClient()
    {
      initStat($"EXEC [api_sp_listeFactRetardTotAllClient] '{MozartParams.NomSociete}'", $"EXEC api_sp_listeFactRetardAllClient '{MozartParams.NomSociete}'");
    }

    private void InitStatClientGroupe()
    {
      initStat($"EXEC [api_sp_listeFactRetardTotClientByGroupe]", $"EXEC api_sp_listeFactRetardClientByGroupe");
    }

    private void InitTGrid()
    {
      apiTGrid.AddColumn(Resources.col_Compte, "NCANNUM", 1000, "", 2);
      apiTGrid.AddColumn(MZCtrlResources.col_Client, "VCLINOM", 1000);
      apiTGrid.AddColumn(Resources.col_Chaff, "VPERNOM", 1200);
      apiTGrid.AddColumn(Resources.col_groupe, "LIBGROUPE", 1200);
      apiTGrid.AddColumn(Resources.col_NumFacture, "NFACNUM", 1000);
      apiTGrid.AddColumn(Resources.col_DateFact, "DFACDAT", 1000, "dd/mm/yy", 1);
      apiTGrid.AddColumn(Resources.col_Raison_sociale, "VRSFRSF", 3500, "", 0, true);
      apiTGrid.AddColumn(Resources.col_dateEch, "DDATEECH", 1000, "dd/mm/yy", 1);
      apiTGrid.AddColumn(Resources.col_retardJ, "DFACNBJ", 1000, "", 1);
      apiTGrid.AddColumn(Resources.col_totalHT, COL_NELFHT, 1800, "Currency", 1);
      apiTGrid.AddColumn(Resources.col_TotalTTC, COL_NELFTTC, 1800, "Currency", 1);
      //apiTGrid.AddColumn(Resources.col_resteDuTTC, "NRESTEDU", 1800, "Currency", 1);
      apiTGrid.AddColumn(Resources.col_Num_CDE, "VACTNUMCDE", 1500);
      apiTGrid.AddColumn(MZCtrlResources.col_Site, "VSITNOM", 1500);
      apiTGrid.AddColumn(Resources.col_obsrvationsImpaye, "VOBS_TEXT", 1600);
      apiTGrid.AddColumn("NCLINUM", "NCLINUM", 0);
      apiTGrid.AddColumn("CODERETARD", "CODERETARD", 0);

      addSumTo(COL_NELFTTC);
      addSumTo(COL_NELFHT);

      apiTGrid.InitColumnList();
    }

    // Ajoute un total pour la colonne dont le nom est passé en paramètre
    private void addSumTo(string pColumnName)
    {
      GridColumn lColumn = apiTGrid.dgv.Columns[pColumnName];

      lColumn.Summary.Add(new GridColumnSummaryItem
      {
        FieldName = pColumnName,
        SummaryType = DevExpress.Data.SummaryItemType.Sum,
        DisplayFormat = "{0:c2}"
      });
    }

    private void ChkAllClient_CheckedChanged(object sender, EventArgs e)
    {
      if (ChkAllClient.Checked)
      {
        cboClient.SetItemData(-1);
        if (ChkGroupe.Checked) ChkGroupe.Checked = false;
      }
    }

    private void ChkGroupe_CheckedChanged(object sender, EventArgs e)
    {
      if (ChkGroupe.Checked)
      {
        cboClient.SetItemData(-1);
        if (ChkAllClient.Checked) ChkAllClient.Checked = false;
      }
    }

    private void cmdValider_Click(object sender, EventArgs e)
    {
      if (ChkAllClient.Checked) InitStatAllClient();
      else if (ChkGroupe.Checked) InitStatClientGroupe();
      else InitStat();
    }

    private void chkRetard_CheckedChanged(object sender, EventArgs e)
    {
      GridColumn lColumn = apiTGrid.dgv.Columns["CODERETARD"];
      apiTGrid.dgv.ActiveFilter.Remove(lColumn);

      if (chkRetard.Checked)
      {
        apiTGrid.dgv.ActiveFilter.Add(lColumn, new ColumnFilterInfo("CODERETARD = 'O'"));
      }
    }

    private void cmdObsFermer_Click(object sender, EventArgs e)
    {
      FrameObs.Visible = false;
    }

    private void CmdObsMsgFermer_Click(object sender, EventArgs e)
    {
      FrameMsg.Visible = false;
    }

    private void CmdValiderMsg_Click(object sender, EventArgs e)
    {
      if (txtMsg.Text != "")
      {
        txtObs.Text = $"{MozartParams.strUID} - {DateTime.Now:dd/MM/yy HH:mm} : {txtMsg.Text}{Environment.NewLine}{txtObs.Text}";

        DataRow currentRow = apiTGrid.GetFocusedDataRow();
        if (currentRow == null) return;

        if (Utils.ZeroIfNull(currentRow["NCLINUM"]) != 0)
          ModuleData.CnxExecute($"UPDATE TFACTURES SET VOBS_TEXT = '{txtObs.Text.Replace("'", "''")}' WHERE TFACTURES.NFACNUM = {currentRow["nfacnum"]} AND NCLINUM = {currentRow["NCLINUM"]}");

        apiTGrid.Requery(dt, MozartDatabase.cnxMozart);
      }
      FrameMsg.Visible = false;
      FrameObs.Visible = false;
    }

    private void txtObs_KeyPress(object sender, KeyPressEventArgs e)
    {
      e.KeyChar = '\0';
    }

    private void CmdObs_Click(object sender, EventArgs e)
    {
      try
      {
        DataRow currentRow = apiTGrid.GetFocusedDataRow();
        if (currentRow == null) return;

        txtMsg.Text = "";
        txtObs.Text = "";
        FrameObs.Visible = false;

        if (Utils.ZeroIfNull(currentRow["NCLINUM"]) == 0) return;

        txtObs.Text = Utils.BlankIfNull(currentRow["VOBS_TEXT"]);
        FrameMsg.Visible = true;
      }
      catch (Exception ex)
      {
        MZUtils.displayError(MethodBase.GetCurrentMethod().Name, ex);
      }
    }

    private void apiTGrid_RowCellClick(object sender, DevExpress.XtraGrid.Views.Grid.RowCellClickEventArgs e)
    {
      try
      {
        DataRow currentRow = apiTGrid.GetFocusedDataRow();
        if (currentRow == null) return;

        if (e.Column.Name == "VOBS_TEXT")
        {
          txtMsg.Text = "";
          txtObs.Text = "";

          if (currentRow["VOBS_TEXT"].ToString() != "")
          {
            txtObs.Text = currentRow["VOBS_TEXT"].ToString();
            FrameObs.Visible = true;
          }
        }
      }
      catch (Exception ex)
      {
        MZUtils.displayError(MethodBase.GetCurrentMethod().Name, ex);
      }
    }
  }
}

