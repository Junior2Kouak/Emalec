using DevExpress.XtraGrid.Views.Grid;
using MozartCS.Properties;
using MozartLib;
using MozartNet;
using MozartUC;
using System;
using System.Collections;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Reflection;
using System.Windows.Forms;
using MZCtrlResources = MozartControls.Properties.Resources;
using MZUtils = MozartControls.Utils;

namespace MozartCS
{
  public partial class frmGestSites : Form
  {
    public int miNumClient;

    DataTable dtPri = new DataTable();

    public frmGestSites() { InitializeComponent(); }

    private void frmGestSites_Load(object sender, System.EventArgs e)
    {
      try
      {
        Cursor.Current = Cursors.WaitCursor;
        ModuleMain.Initboutons(this);

        apiTGrid1.LoadData(dtPri, MozartDatabase.cnxMozart, $"select * from api_v_ListeSites where csitactif= 'O' and NCLINUM = {miNumClient}");
        apiTGrid1.GridControl.DataSource = dtPri;
        InitApiTgrid();
        if (dtPri.Rows.Count != 0) lblNom.Text = Utils.BlankIfNull(dtPri.Rows[0]["VCLINOM"]);

        Cursor.Current = Cursors.Default;
      }
      catch (Exception ex)
      {
        MZUtils.displayError(MethodBase.GetCurrentMethod().Name, ex);
      }
      finally { Cursor.Current = Cursors.Default; }
    }

    private void Command1_Click(object sender, EventArgs e)
    {
      new frmGestionContratSite(miNumClient) { }.ShowDialog();
    }

    private void cmdAjouter_Click(object sender, EventArgs e)
    {
      new frmDetailsSite
      {
        mstrStatut = "C",
        miNumSite = 0,
        miNumClient = miNumClient
      }.ShowDialog();

      //rafraichissement du recordset
      apiTGrid1.Requery(dtPri, MozartDatabase.cnxMozart);
    }

    private void cmdModifier_Click(object sender, EventArgs e)
    {
      // on sort si pas de site
      DataRow currentRow = apiTGrid1.GetFocusedDataRow();
      if (currentRow == null) return;

      new frmDetailsSite
      {
        mstrStatut = "M",
        miNumSite = (int)Utils.ZeroIfNull(currentRow["NSITNUM"]),
        miNumClient = miNumClient
      }.ShowDialog();

      // rafraichissement de la grille
      apiTGrid1.Requery(dtPri, MozartDatabase.cnxMozart);
    }

    private void cmdCont_Click(object sender, EventArgs e)
    {
      try
      {
        // on sort si pas de site
        DataRow currentRow = apiTGrid1.GetFocusedDataRow();
        if (currentRow == null) return;

        Cursor.Current = Cursors.WaitCursor;

        new frmGestContratSite
        {
          msNomClient = Utils.BlankIfNull(currentRow["VCLINOM"]),
          miNumClient = miNumClient
        }.ShowDialog();

        Cursor.Current = Cursors.Default;
      }
      catch (Exception ex)
      {
        MZUtils.displayError(MethodBase.GetCurrentMethod().Name, ex);
      }
    }

    private void cmdST_Click(object sender, EventArgs e)
    {
      //on sort si pas de sites
      DataRow currentRow = apiTGrid1.GetFocusedDataRow();
      if (currentRow == null) return;

      Cursor.Current = Cursors.WaitCursor;

      new frmGestContratSiteST
      {
        msNomClient = Utils.BlankIfNull(currentRow["VCLINOM"]),
        miNumClient = miNumClient,
        msActif = "O"
      }.ShowDialog();

      Cursor.Current = Cursors.Default;
    }

    private void cmdInfo_Click(object sender, EventArgs e)
    {
      try
      {
        //on sort si pas de sites
        DataRow currentRow = apiTGrid1.GetFocusedDataRow();
        if (currentRow == null) return;

        new frmSaisieInfos
        {
          mstrTypeNote = "INFO_SITE",
          miCleTable = (int)Utils.ZeroIfNull(currentRow["NSITNUM"])
        }.ShowDialog();
      }
      catch (Exception ex)
      {
        MZUtils.displayError(MethodBase.GetCurrentMethod().Name, ex);
      }
    }

    private void cmdBudget_Click(object sender, EventArgs e)
    {
      DataRow currentRow = apiTGrid1.GetFocusedDataRow();
      if (currentRow == null) return;

      Cursor.Current = Cursors.WaitCursor;

      new frmGestBudget
      {
        miNumClient = miNumClient,
        msNomClient = Utils.BlankIfNull(currentRow["VCLINOM"]),
        msActif = "O"
      }.ShowDialog();

      Cursor.Current = Cursors.Default;
    }

    private void cmdSupprimer_Click(object sender, EventArgs e)
    {
      try
      {
        DataRow currentRow = apiTGrid1.GetFocusedDataRow();
        if (currentRow == null) return;

        // il faut regarder si le site n'a pas des planifications
        int iTemp = (int)ModuleData.ExecuteScalarInt($"select count(*) from TACT WITH (NOLOCK) WHERE NSITNUM={Utils.ZeroIfNull(currentRow["NSITNUM"])} and cetacod='P'");
        if (iTemp > 0)
        {
          MessageBox.Show(Resources.msg_actionPlanSurSite, Program.AppTitle, MessageBoxButtons.OK, MessageBoxIcon.Information);
          return;
        }

        if (MessageBox.Show(Resources.msg_archiverSite, Program.AppTitle, MessageBoxButtons.YesNo, MessageBoxIcon.Question,
          MessageBoxDefaultButton.Button2) == DialogResult.Yes)
        {
          // test si le site possède une arborescence GIDT
          int iTemp2 = (int)ModuleData.ExecuteScalarInt($"select count(*) from TGIDTOBJ WHERE NSITNUM={Utils.ZeroIfNull(currentRow["NSITNUM"])}");
          if (iTemp2 > 0)
          {
            if (MessageBox.Show(Resources.msg_sitePossedeGIDT, Program.AppTitle, MessageBoxButtons.YesNo, MessageBoxIcon.Question,
              MessageBoxDefaultButton.Button2) == DialogResult.No) return;
          }
          ModuleData.CnxExecute($"update tsit set csitactif = 'N' where nsitnum = {Utils.ZeroIfNull(currentRow["NSITNUM"])}");
          ModuleData.CnxExecute($"delete from tuti where  CUTICAT='C' and nusitnum = {Utils.ZeroIfNull(currentRow["NSITNUM"])}"); // suppression dans les acces web

          apiTGrid1.Requery(dtPri, MozartDatabase.cnxMozart);
        }

      }
      catch (Exception ex)
      {
        MZUtils.displayError(MethodBase.GetCurrentMethod().Name, ex);
      }
    }

    private void cmdArchive_Click(object sender, EventArgs e)
    {
      new frmGestSitesArch { miNumClient = miNumClient }.ShowDialog();
    }

    private void cmdHoraires_Click(object sender, EventArgs e)
    {
      DataRow currentRow = apiTGrid1.GetFocusedDataRow();
      if (currentRow == null) return;

      frmSaisieHoraire f = new frmSaisieHoraire();
      f.miNumCli = miNumClient;
      f.miNumSit = (int)Utils.ZeroIfNull(currentRow["NSITNUM"]);
      f.Text += Utils.BlankIfNull(currentRow["VSITNOM"]);
      f.ShowDialog();
    }

    private void cmdBudg_Click(object sender, EventArgs e)
    {
      DataRow currentRow = apiTGrid1.GetFocusedDataRow();
      if (currentRow == null) return;

      new frmListeBudgPrest
      {
        miNumClient = miNumClient,
        msNomClient = Utils.BlankIfNull(currentRow["VCLINOM"])
      }.ShowDialog();
    }

    private void InitApiTgrid()
    {
      apiTGrid1.AddColumn(Resources.col_Nom, "VSITNOM", 1900);
      apiTGrid1.AddColumn(Resources.col_Enseigne, "VSITENSEIGNE", 1400);
      apiTGrid1.AddColumn(Resources.col_Number, "NSITNUE", 800);
      apiTGrid1.AddColumn(Resources.col_Type, "VSITTYPE", 1000);
      apiTGrid1.AddColumn(Resources.col_Adresse1, "VSITAD1", 500);
      apiTGrid1.AddColumn(Resources.col_Adresse2, "VSITAD2", 500);
      apiTGrid1.AddColumn(Resources.col_CP, "VSITCP", 700);
      apiTGrid1.AddColumn(Resources.col_Ville, "VSITVIL", 1200);
      apiTGrid1.AddColumn(Resources.col_VilleCible, "VILLECIBLE", 1500);
      apiTGrid1.AddColumn(MZCtrlResources.col_Pays, "VSITPAYS", 1000);
      apiTGrid1.AddColumn(Resources.col_Telephone, "VSITTEL", 1400);
      apiTGrid1.AddColumn(Resources.col_interdit, "interdit", 800, "", 2);
      apiTGrid1.AddColumn("Inventaire", "INV_EXISTS", 800, "", 2);
            apiTGrid1.AddColumn(Resources.col_Email, "VSITMAI", 500);
      apiTGrid1.AddColumn(Resources.col_surface, "NSITSFV", 500, "", 3);
      apiTGrid1.AddColumn(Resources.txt_facturation, "VRSFRSF", 1500);
      apiTGrid1.AddColumn(Resources.col_region_client, "VSITREG", 1500);
      apiTGrid1.AddColumn(Resources.col_departmt, "VREGLIB", 1600);
      apiTGrid1.AddColumn(MZCtrlResources.date_creation, "DSITDCREMAG", 1200);
      apiTGrid1.AddColumn(Resources.txt_respSite, "VSITRES", 1300);
      apiTGrid1.AddColumn(Resources.col_Prenom, "VSITPRENOM", 1000);
      apiTGrid1.AddColumn(Resources.col_resp_reg, "reg", 1400);
      apiTGrid1.AddColumn(Resources.col_respMaint, "maint", 1400);
      apiTGrid1.AddColumn("Resp Sect", "secteur", 1400);
      apiTGrid1.AddColumn("Code SAP", "VCODIMPL", 0);
      apiTGrid1.AddColumn("NumSite", "NSITNUM", 0);
      apiTGrid1.AddColumn("NumCli", "NCLINUM", 0);
      apiTGrid1.AddColumn("VCLINOM", "VCLINOM", 0);
      apiTGrid1.AddColumn(MZCtrlResources.col_Actif, "CSITACTIF", 0);
      apiTGrid1.AddColumn("NCCLNUM", "NCCLNUM", 0);
      apiTGrid1.AddColumn("Concept", "VSITCONCEPT", 0);

      apiTGrid1.InitColumnList();
    }
    private void apiTGrid1_RowStyle(object sender, DevExpress.XtraGrid.Views.Grid.RowStyleEventArgs e)
    {
      GridView View = sender as GridView;
      if (e.RowHandle >= 0)
      {
        if (View.GetDataRow(e.RowHandle)["interdit"].ToString().ToUpper() == "O")
        {
          e.Appearance.BackColor = MozartColors.ColorH8080FF;
          e.HighPriority = true;
        }

        if (View.GetDataRow(e.RowHandle)["Info"].ToString().ToUpper() == "O")
        {
          e.Appearance.Font = new Font(e.Appearance.Font, FontStyle.Bold);
          e.HighPriority = true;
        }
      }
    }

    private void frmGestSites_FormClosed(object sender, FormClosedEventArgs e)
    {
      MozartUcUtils.SpyLog(MozartDatabase.cnxMozart, "", "", "Sortie");
    }

    private void cmdCarte_Click(object sender, EventArgs e)
    {
      try
      {
        DataRow currentRow = apiTGrid1.GetFocusedDataRow();
        if (currentRow == null) return;

        Cursor.Current = Cursors.WaitCursor;

        using (SqlDataReader sdrLatLon = ModuleData.ExecuteReader($"SELECT VSITNOM + ' - ' + Isnull(VSITAD1, '') + ' ' + Isnull(VSITAD2, '') + ' - ' + Isnull(VSITCP, '') + ' ' + Isnull(VSITVIL, '') + ' - ' + Isnull(VSITPAYS, '') as ADR, FSITLAT LAT, FSITLON LON FROM TSIT WHERE NSITNUM = {Utils.ZeroIfNull(currentRow["NSITNUM"])}"))
        {
          if (sdrLatLon.Read())
          {
            new frmBrowser
            {
              msStartingAddress = $@"https://maps.emalec.com/SiteParPoint.asp?NOM={sdrLatLon["adr"]}&LAT={sdrLatLon["lat"]}&LON={sdrLatLon["lon"]}"
            }.ShowDialog();
          }
        }

        Cursor.Current = Cursors.Default;
      }
      catch (Exception ex)
      {
        MZUtils.displayError(MethodBase.GetCurrentMethod().Name, ex);
      }
    }

    private void cmdProcSite_Click(object sender, EventArgs e)
    {
      DataRow currentRow = apiTGrid1.GetFocusedDataRow();
      if (currentRow == null) return;

      new frmGestProcedure
      {
        mstrType = "PROCEDURESITE",
        miNumSite = (int)Utils.ZeroIfNull(currentRow["NSITNUM"]),
        miNumClient = 0,
        msTitre = $" du Site : {Utils.BlankIfNull(currentRow["VSITNOM"])}"
      }.ShowDialog();
    }


    private void frmGestSites_KeyDown(object sender, KeyEventArgs e)
    {
      if ((e.KeyCode == Keys.Add) && (e.Modifiers == (Keys.Control | Keys.Shift | Keys.Alt)))
      {
        apiTGrid1.dgv.OptionsSelection.MultiSelectMode = GridMultiSelectMode.CheckBoxRowSelect;
        cmdModifResp.Visible = true;
      }
    }

    private void cmdModifResp_Click(object sender, EventArgs e)
    {
      int lTmpNCCLNUM;
      int lNCCLNUM = -1;
      ArrayList lSiteIDs = new ArrayList();

      for (int i = 0; i < apiTGrid1.dgv.DataRowCount; i++)
      {
        if (apiTGrid1.dgv.IsRowSelected(i))
        {
          // Récupère l'ID du resp maintenance eet le garde si tous ont le même
          // Sinon, on met et reste à 0 car plusieurs resp maint sont définis pour les différentes lignes
          lTmpNCCLNUM = Convert.ToInt32(apiTGrid1.dgv.GetRowCellValue(i, apiTGrid1.dgv.Columns["NCCLNUM"]));
          if (lNCCLNUM != 0)
          {
            if (lNCCLNUM == -1)
            {
              lNCCLNUM = lTmpNCCLNUM;
            }
            else if (lNCCLNUM != lTmpNCCLNUM)
            {
              lNCCLNUM = 0;
            }
          }

          lSiteIDs.Add(Convert.ToInt32(apiTGrid1.dgv.GetRowCellValue(i, apiTGrid1.dgv.Columns["NSITNUM"])));
        }
      }

      if (lSiteIDs.Count == 0) return;

      new frmModifRespSite(miNumClient, lSiteIDs, lNCCLNUM).ShowDialog();
      apiTGrid1.Requery(dtPri, MozartDatabase.cnxMozart);
    }

    private void BtnPlanPrevSite_Click(object sender, EventArgs e)
    {
      DataRow currentRow = apiTGrid1.GetFocusedDataRow();
      if (currentRow == null) return;

      new frmGestProcedure
      {
        mstrType = "PLANPREVSITE",
        miNumSite = (int)Utils.ZeroIfNull(currentRow["NSITNUM"]),
        miNumClient = 0,
        msTitre = Resources.Plans_de_prévention + $" du site : {Utils.BlankIfNull(currentRow["VSITNOM"])}"
      }.ShowDialog();
    }

        private void BtnInvSite_Click(object sender, EventArgs e)
        {
            DataRow currentRow = apiTGrid1.GetFocusedDataRow();
            if (currentRow == null) return;

            new frmInventaireEquipementSite
            {
                nsitnum = (int)Utils.ZeroIfNull(currentRow["NSITNUM"]),
                vsitnom = (string)Utils.BlankIfNull(currentRow["VSITNOM"]),
                vclinom = Utils.BlankIfNull(currentRow["VCLINOM"])
            }.ShowDialog();
        }

        private void apiTGrid1_SelectionChanged(object sender, DevExpress.Data.SelectionChangedEventArgs e)
        {
            DataRow currentRow = apiTGrid1.GetFocusedDataRow();
            if (currentRow != null)
            {
                BtnInvSite.BackColor = Utils.BlankIfNull(currentRow["INV_EXISTS"]) == "O" ? Color.Yellow : DefaultBackColor;
                
            }
            
        }
    }
}

