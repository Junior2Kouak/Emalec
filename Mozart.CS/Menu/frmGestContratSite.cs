using DevExpress.Data.Filtering;
using DevExpress.XtraEditors.Controls;
using DevExpress.XtraEditors.Repository;
using DevExpress.XtraGrid.Views.Grid;
using MozartCS.Properties;
using MozartLib;
using MozartNet;
using System;
using System.Collections.Generic;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Reflection;
using System.Windows.Forms;
using MZCtrlResources = MozartControls.Properties.Resources;
using MZUtils = MozartControls.Utils;

namespace MozartCS
{
  public partial class frmGestContratSite : Form
  {
    public int miNumClient;
    public string msNomClient;

    DataTable dtPri = new DataTable();
    DataTable dtSec = new DataTable();
    DataTable dtTer = new DataTable();

    private string sNomColDate;

    public frmGestContratSite() { InitializeComponent(); }

    private void frmGestContratSite_Load(object sender, System.EventArgs e)
    {
      string sSQL;

      try
      {
        Cursor.Current = Cursors.WaitCursor;
        ModuleMain.Initboutons(this);

        //textes menus
        mnuNbInter.Text = Resources.mnu_nbInter;
        mnuDuree.Text = Resources.mnu_duree;
        mnuMontant.Text = Resources.col_Montant;
        mnuMontantSTT.Text = "MontantSTT";
        mnuMontantP3.Text = Resources.mnu_montantP3;
        mnuNbEquip.Text = Resources.mnu_nbEquip;
        mnuAffichage.Text = Resources.mnu_affichage;
        mnuDate.Text = Resources.col_Date;
        mnuAffecterTous.Text = Resources.mnu_affecterContratTS;
        mnuAjoutDate.Text = Resources.mnu_affecterDateTS;
        mnuMontant.Text = Resources.mnu_affecterMontantTS;
        mnuAjoutDuree.Text = Resources.nmu_affecterDureeTS;
        mnuAjoutMontant.Text = Resources.mnu_affecterMontantTS;
        mnuAjoutMontantP3.Text = Resources.mnu_affecterMontantTS;
        mnuAjoutMontantSTT.Text = "Affecter ce montant à tous les sites";
        mnuAjoutNbEquip.Text = Resources.mnu_affceterNombreEquipTS;
        mnuAjoutNbInterTous.Text = Resources.nmu_affecterNbInterTS;
        mnuDesaffecter.Text = Resources.mnu_supprContratTS;
        mnuSupDate.Text = Resources.nmu_supprDateTS;
        mnuSupDuree.Text = Resources.nmu_supprDureeTS;
        mnuSupMontant.Text = Resources.mnu_supMontantTousSites;
        mnuSupMontantP3.Text = Resources.mnu_supMontantTousSites;
        mnuSupMontantSTT.Text = "Supprimer le montant de tous les sites";
        mnuSupNbEquip.Text = Resources.mnu_supprNbEquirTS;
        mnuSupNbInterTous.Text = Resources.mnu_supprNbInterTS;

        ApiGridSite.dgv.OptionsView.ColumnAutoWidth = false;

        // affichage du client
        lblClient.Text = msNomClient;

        // liste des contrats
        sSQL = $"SELECT VTYPECONTRAT,TCONTRATCLI.NTYPECONTRAT, ISNULL(NMONTANTCONTRAT, 0) AS NMONTANTCONTRAT, SUM(ISNULL(NNBVISANNUEL, 0) * ISNULL(NMONTANTINTER, 0)) AS NTOTALSAISIE";
        sSQL += $" FROM TCONTRATCLI INNER JOIN TREF_TYPECONTRAT ON TCONTRATCLI.NTYPECONTRAT = TREF_TYPECONTRAT.NTYPECONTRAT";
        sSQL += $" INNER JOIN TCONT ON TCONT.NTYPECONTRAT = TREF_TYPECONTRAT.NTYPECONTRAT";
        sSQL += $" INNER JOIN TSIT ON TCONT.NSITNUM = TSIT.NSITNUM AND TCONTRATCLI.NCLINUM=TSIT.NCLINUM";
        sSQL += $" INNER JOIN TREF_TYPESITE ON TREF_TYPESITE.NTYPESITE = TSIT.NSITTYPE";
        sSQL += $" WHERE TREF_TYPECONTRAT.LANGUE = '{MozartParams.Langue}' AND TREF_TYPESITE.LANGUE = '{MozartParams.Langue}'";
        sSQL += $" AND CSITACTIF = 'O' AND TSIT.NCLINUM = {miNumClient}";
        sSQL += $" GROUP BY TREF_TYPECONTRAT.NTYPECONTRAT,TREF_TYPECONTRAT.VTYPECONTRAT,TCONTRATCLI.NTYPECONTRAT,NMONTANTCONTRAT ORDER BY VTYPECONTRAT";

        ApiGridCtr.LoadData(dtPri, MozartDatabase.cnxMozart, sSQL);
        ApiGridCtr.GridControl.DataSource = dtPri;
        InitApigridCtr();

        if (ApiGridCtr.GetFocusedDataRow() == null) return;

        updateListeSitesParContrat();
        ApiGridSite.GridControl.DataSource = dtSec;
        InitApigridSite();

        DataRow currentRowSec = ApiGridSite.GetFocusedDataRow();
        if (currentRowSec != null)
        {
          // datatable tertiaire : liste des contrats par site
          // première ligne par défaut
          updateListeContratsParSite();
          ApiGrid.GridControl.DataSource = dtTer;
          InitapiGrid();

          // troisieme grid : liste des contrats pour un site
          GridView gridView2 = ApiGrid.GridControl.MainView as GridView;
          RepositoryItemComboBox riComboBox2 = buildRepositoryItemComboBoxOuiNon();
          gridView2.Columns[2].ColumnEdit = riComboBox2;
          ApiGrid.GridControl.RepositoryItems.Add(riComboBox2);
        }

        GridView gridView1 = ApiGridSite.GridControl.MainView as GridView;
        RepositoryItemComboBox riComboBox = buildRepositoryItemComboBoxOuiNon();
        gridView1.Columns["VCONTETAT"].ColumnEdit = riComboBox;
        ApiGridSite.GridControl.RepositoryItems.Add(riComboBox);

      }
      catch (Exception ex)
      {
        MZUtils.displayError(MethodBase.GetCurrentMethod().Name, ex);
      }
      finally { Cursor.Current = Cursors.Default; }
    }

    private void InitApigridCtr()
    {
      try
      {
        ApiGridCtr.AddColumn(Resources.col_Contrat, "VTYPECONTRAT", 2000);
        ApiGridCtr.AddColumn("NumContrat", "", 0);
        ApiGridCtr.AddColumn("€ Contrat papier", "NMONTANTCONTRAT", 1000, "Currency", 1);
        ApiGridCtr.AddColumn("€ Total saisies", "NTOTALSAISIE", 1000, "Currency", 1);

        ApiGridCtr.InitColumnList();
        ApiGridCtr.DesactiveListe();
      }
      catch (Exception ex)
      {
        MZUtils.displayError(MethodBase.GetCurrentMethod().Name, ex);
      }
    }

    private void InitApigridSite()
    {
      try
      {
        ApiGridSite.AddColumn(Resources.col_Contrat, "VTYPECONTRAT", 1100);
        ApiGridSite.AddColumn(MZCtrlResources.col_Site, "VSITNOM", 2200);
        if (MozartParams.NomSociete == "EQUIPAGE")
        {
          ApiGridSite.AddColumn(Resources.col_Adresse1, "VSITAD1", 1000);
          ApiGridSite.AddColumn(MZCtrlResources.col_Ville, "VSITVIL", 1000);
        }
        ApiGridSite.AddColumn(MZCtrlResources.col_Pays, "VSITPAYS", 1000);
        ApiGridSite.AddColumn(Resources.col_Enseigne, "VSITENSEIGNE", 1100);
        ApiGridSite.AddColumn(MZCtrlResources.col_No, "NSITNUE", 500, "", 2);
        ApiGridSite.AddColumn(Resources.col_Reg, "VSITREG", 400, "", 2);
        ApiGridSite.AddColumn(Resources.col_prio, "NSITPRIO", 500, "", 2);
        ApiGridSite.AddColumn(Resources.col_typeSite, "VLIBTYPESITE", 800, "", 2);
        ApiGridSite.AddColumn(Resources.col_surf, "NSITSFV", 400, "", 2);
        ApiGridSite.AddColumn(Resources.col_Gestion, "VCONTETAT", 600, "", 2);
        ApiGridSite.AddColumn("Num", "NSITNUM", 0);
        ApiGridSite.AddColumn(Resources.col_Nacelle, "VCONTNACELLE", 500, "", 2);
        ApiGridSite.AddColumn(Resources.col_nbEquip, "NNBEQUIP", 600, "", 2);
        ApiGridSite.AddColumn(Resources.col_nbIntAn, "NNBVISANNUEL", 600, "", 2);
        ApiGridSite.AddColumn(Resources.col_Hinter, "NDUREEINTER", 700, "0.##", 2);
        ApiGridSite.AddColumn(Resources.col_euroInterP2, "NMONTANTINTER", 900, "0.##", 2);
        ApiGridSite.AddColumn("STT € P2", "NMONTANTSTTP2", 900, "0.##", 2);
        ApiGridSite.AddColumn(Resources.col_dateDebP2, "DDEBP2", 1000, "dd/MM/yyyy", 2);
        ApiGridSite.AddColumn(Resources.col_dateFinP2, "DFINP2", 1000, "dd/MM/yyyy", 2);
        ApiGridSite.AddColumn(Resources.col_euroInterP3, "NMONTANTP3", 900, "0.##", 2);
        ApiGridSite.AddColumn(Resources.col_dateDebP3, "DDEBP3", 1000, "dd/MM/yyyy", 2);
        ApiGridSite.AddColumn(Resources.col_dateFinP3, "DFINP3", 1000, "dd/MM/yyyy", 2);
        ApiGridSite.AddColumn("NumContrat", "NTYPECONTRAT", 0);

        ApiGridSite.InitColumnList();

        // interdir la saisie dans la liste des sites
        ApiGridSite.DelockColumn("VCONTETAT");
        ApiGridSite.DelockColumn("VCONTNACELLE");
        ApiGridSite.DelockColumn("NNBEQUIP");
        ApiGridSite.DelockColumn("NNBVISANNUEL");
        ApiGridSite.DelockColumn("NDUREEINTER");
        ApiGridSite.DelockColumn("NMONTANTINTER");
        ApiGridSite.DelockColumn("NMONTANTSTTP2");
        ApiGridSite.DelockColumn("DDEBP2");
        ApiGridSite.DelockColumn("DFINP2");
        ApiGridSite.DelockColumn("NMONTANTP3");
        ApiGridSite.DelockColumn("DDEBP3");
        ApiGridSite.DelockColumn("DFINP3");

        GridView gridView2 = ApiGridSite.GridControl.MainView as GridView;
        RepositoryItemComboBox riComboBox2 = buildRepositoryItemComboBoxOuiNon();
        gridView2.Columns["VCONTNACELLE"].ColumnEdit = riComboBox2;
        ApiGridSite.GridControl.RepositoryItems.Add(riComboBox2);

      }
      catch (Exception ex)
      {
        MZUtils.displayError(MethodBase.GetCurrentMethod().Name, ex);
      }
    }

    private RepositoryItemComboBox buildRepositoryItemComboBoxOuiNon()
    {
      RepositoryItemComboBox riComboBox = new RepositoryItemComboBox();
      riComboBox.Items.Add("NON");
      riComboBox.Items.Add("OUI");
      riComboBox.TextEditStyle = TextEditStyles.DisableTextEditor;

      return riComboBox;
    }

    private void InitapiGrid()
    {
      try
      {
        ApiGrid.AddColumn(MZCtrlResources.col_Site, "VSITNOM", 2000);
        ApiGrid.AddColumn(Resources.col_Contrat, "VTYPECONTRAT", 1900);
        ApiGrid.AddColumn(Resources.col_Gestion, "VCONTETAT", 1200, "", 2);
        ApiGrid.AddColumn(Resources.col_nbInterAn, "NNBVISANNUEL", 900, "", 2);
        ApiGrid.AddColumn(Resources.col_Hinter, "NDUREEINTER", 1200, "0.##", 2);
        ApiGrid.AddColumn(Resources.col_euroInterP2, "NMONTANTINTER", 1200, "0.##", 2);
        ApiGrid.AddColumn("STT € P2", "NMONTANTSTTP2", 1000, "0.##", 2);
        ApiGrid.AddColumn(Resources.col_euroInterP3, "NMONTANTP3", 1200, "0.##", 2);

        ApiGrid.DelockColumn("VCONTETAT");
        ApiGrid.DelockColumn("NNBVISANNUEL");
        ApiGrid.DelockColumn("NDUREEINTER");
        ApiGrid.DelockColumn("NMONTANTINTER");
        ApiGrid.DelockColumn("NMONTANTSTTP2");
        ApiGrid.DelockColumn("NMONTANTP3");

        ApiGrid.InitColumnList();
      }
      catch (Exception ex)
      {
        MZUtils.displayError(MethodBase.GetCurrentMethod().Name, ex);
      }
    }

    // MAJ datatable secondaire : liste des sites par contrat
    private void updateListeSitesParContrat()
    {
      // On sort s'il n'y a pas d'enregistrement maitre
      DataRow currentRow = ApiGridCtr.GetFocusedDataRow();
      if (currentRow == null) return;

      string sSQL;
      sSQL = $"SELECT  VTYPECONTRAT, VSITNOM, VSITPAYS,VSITENSEIGNE, NSITNUE, VSITREG, CASE WHEN NSITPRIO = 1 THEN 'OUI' ELSE 'NON' END AS NSITPRIO, ";
      sSQL += $" VLIBTYPESITE, NSITSFV, VCONTETAT, VCONTNACELLE, TSIT.NSITNUM, NNBEQUIP, NNBVISANNUEL, NDUREEINTER, NMONTANTINTER, ";
      sSQL += $" NMONTANTSTTP2, DDEBP2, DFINP2, NMONTANTP3 , DDEBP3, DFINP3, TCONT.NTYPECONTRAT, VSITVIL, VSITAD1";
      sSQL += $" FROM TCONT, TSIT, TREF_TYPECONTRAT,TREF_TYPESITE";
      sSQL += $" WHERE TCONT.NSITNUM = TSIT.NSITNUM  AND CSITACTIF='O' AND TCONT.NTYPECONTRAT = TREF_TYPECONTRAT.NTYPECONTRAT";
      sSQL += $" AND TREF_TYPECONTRAT.NTYPECONTRAT = {currentRow["NTYPECONTRAT"]}";
      sSQL += $" AND TREF_TYPESITE.NTYPESITE = TSIT.NSITTYPE AND TSIT.NCLINUM = {miNumClient}";
      sSQL += $" AND TREF_TYPECONTRAT.LANGUE = '{MozartParams.Langue}' AND TREF_TYPESITE.LANGUE = '{MozartParams.Langue}' ORDER BY VSITNOM";

      ApiGridSite.LoadData(dtSec, MozartDatabase.cnxMozart, sSQL);
    }

    // MAJ datatable tertiaire : liste des contrats par site
    private void updateListeContratsParSite()
    {
      DataRow currentRowSec = ApiGridSite.GetFocusedDataRow();
      if (currentRowSec == null) return;

      // datatable tertiaire : liste des contrats par site
      // première ligne par défaut
      string sSQL;
      sSQL = $"SELECT VSITNOM, VTYPECONTRAT, VCONTETAT, NNBVISANNUEL, NDUREEINTER, NMONTANTINTER, NMONTANTSTTP2 ,NMONTANTP3, TCONT.NTYPECONTRAT, TSIT.NSITNUM";
      sSQL += $" FROM TCONT, TSIT, TCONTRATCLI, TREF_TYPECONTRAT";
      sSQL += $" WHERE TCONT.NSITNUM = TSIT.NSITNUM  AND TCONT.NSITNUM ={currentRowSec["NSITNUM"]}";
      sSQL += $" AND TCONTRATCLI.NCLINUM = TSIT.NCLINUM";
      sSQL += $" AND TCONTRATCLI.NTYPECONTRAT = TCONT.NTYPECONTRAT";
      sSQL += $" AND TCONT.NTYPECONTRAT = TREF_TYPECONTRAT.NTYPECONTRAT AND LANGUE = '{MozartParams.Langue}'";
      sSQL += $" ORDER BY VCONTETAT DESC";

      ApiGrid.LoadData(dtTer, MozartDatabase.cnxMozart, sSQL);
    }

    private void ApiGridCtr_SelectionChanged(object sender, DevExpress.Data.SelectionChangedEventArgs e)
    {
      updateListeSitesParContrat();
      updateListeContratsParSite();
    }

    private void ApiGridSite_SelectionChanged(object sender, DevExpress.Data.SelectionChangedEventArgs e)
    {
      updateListeContratsParSite();
    }

    private void ApiGridSite_RowCellClick(object sender, RowCellClickEventArgs e)
    {
      if (e.Button != MouseButtons.Right) return;

      switch (e.Column.Name)
      {
        case "NNBVISANNUEL":
          mnuNbInter.Show(Cursor.Position);
          break;
        case "NDUREEINTER":
          mnuDuree.Show(Cursor.Position);
          break;
        case "NMONTANTINTER":
          mnuMontant.Show(Cursor.Position);
          break;
        case "NMONTANTSTTP2":
          mnuMontantSTT.Show(Cursor.Position);
          break;
        case "NMONTANTP3":
          mnuMontantP3.Show(Cursor.Position);
          break;
        case "NNBEQUIP":
          mnuNbEquip.Show(Cursor.Position);
          break;
        case "DDEBP2":
        case "DFINP2":
        case "DDEBP3":
        case "DFINP3":
          sNomColDate = e.Column.Name;
          mnuDate.Show(Cursor.Position);
          break;
        case "VCONTETAT":
          mnuAffichage.Show(Cursor.Position);
          break;
        default:
          break;
      }
    }

    private void ApiGridSite_CellValueChanged(object sender, DevExpress.XtraGrid.Views.Base.CellValueChangedEventArgs e)
    {
      updateValue(ApiGridSite.GetFocusedDataRow(), e);
    }

    private void updateValue(DataRow pRow, DevExpress.XtraGrid.Views.Base.CellValueChangedEventArgs e)
    {
      if (pRow == null) return;

      string sSQL = "";

      switch (e.Column.Name)
      {
        case "VCONTNACELLE":
        case "VCONTETAT":
          sSQL = $"UPDATE TCONT SET {e.Column.Name} = '{e.Value}'" +
                 $" WHERE NSITNUM = {pRow["NSITNUM"]} AND NTYPECONTRAT = {pRow["NTYPECONTRAT"]}";
          break;
        case "NNBEQUIP":
        case "NNBVISANNUEL":
          sSQL = $"UPDATE TCONT SET {e.Column.Name} = {(Convert.IsDBNull(pRow[e.Column.Name]) ? "NULL" : ((int)Utils.ZeroIfNull(pRow[e.Column.Name])).ToString())}" +
                 $" WHERE NSITNUM = {pRow["NSITNUM"]} AND NTYPECONTRAT = {pRow["NTYPECONTRAT"]}";
          break;
        case "NMONTANTINTER":
        case "NMONTANTP3":
        case "NMONTANTSTTP2":
        case "NDUREEINTER":
          sSQL = $"UPDATE TCONT SET {e.Column.Name} = {(Convert.IsDBNull(pRow[e.Column.Name]) ? "NULL" : Utils.ZeroIfNull(pRow[e.Column.Name]).ToString().Replace(',', '.'))}" +
                 $" WHERE NSITNUM = {pRow["NSITNUM"]} AND NTYPECONTRAT = {pRow["NTYPECONTRAT"]}";
          break;
        case "DDEBP2":
        case "DFINP2":
        case "DDEBP3":
        case "DFINP3":
          sSQL = $"UPDATE TCONT SET {e.Column.Name} = {(Convert.IsDBNull(pRow[e.Column.Name]) ? "NULL" : "'" + Utils.DateBlankIfNull(pRow[e.Column.Name]).Replace(',', '.') + "'")}" +
                 $" WHERE NSITNUM = {pRow["NSITNUM"]} AND NTYPECONTRAT = {pRow["NTYPECONTRAT"]}";
          break;
        default:
          break;
      }

      if (sSQL == "") return;

      ModuleData.CnxExecute(sSQL);

      ApiGridCtr.Requery(dtPri, MozartDatabase.cnxMozart);
      ApiGridSite.Requery(dtSec, MozartDatabase.cnxMozart);
      ApiGrid.Requery(dtTer, MozartDatabase.cnxMozart);
    }

    private void ApiGrid_CellValueChanged(object sender, DevExpress.XtraGrid.Views.Base.CellValueChangedEventArgs e)
    {
      updateValue(ApiGrid.GetFocusedDataRow(), e);
    }

    private void mnuAffecterTous_Click(object sender, EventArgs e)
    {
      DataRow currentRowPri = ApiGridCtr.GetFocusedDataRow();
      if (ApiGridSite.GetFocusedDataRow() == null || currentRowPri == null) return;

      IList<int> lListeIDs = dtSec.Select(CriteriaToWhereClauseHelper.GetDataSetWhere(ApiGridSite.dgv.ActiveFilterCriteria)).ToList().Select(item => Convert.ToInt32(item["NSITNUM"])).ToList();
      if (lListeIDs.Count == 0) return;

      string sSQL = $"UPDATE TCONT SET VCONTETAT='OUI' WHERE NSITNUM IN ({string.Join(",", lListeIDs)}) AND NTYPECONTRAT = '{currentRowPri["NTYPECONTRAT"]}'";
      ModuleData.CnxExecute(sSQL);

      ApiGridSite.Requery(dtSec, MozartDatabase.cnxMozart);
      ApiGrid.Requery(dtTer, MozartDatabase.cnxMozart);
    }

    private void mnuAjoutDate_Click(object sender, EventArgs e)
    {
      DateTime dDate;

      DataRow currentRowSec = ApiGridSite.GetFocusedDataRow();
      DataRow currentRowPri = ApiGridCtr.GetFocusedDataRow();
      if (currentRowSec == null || currentRowPri == null) return;

      if (Utils.BlankIfNull(currentRowSec[sNomColDate]) != "")
      {
        dDate = Convert.ToDateTime(currentRowSec[sNomColDate]);

        IList<int> lListeIDs = dtSec.Select(CriteriaToWhereClauseHelper.GetDataSetWhere(ApiGridSite.dgv.ActiveFilterCriteria)).ToList().Select(item => Convert.ToInt32(item["NSITNUM"])).ToList();
        if (lListeIDs.Count == 0) return;

        string sSQL = $"UPDATE TCONT SET {sNomColDate} = '{dDate}' WHERE NSITNUM IN ({string.Join(",", lListeIDs)}) AND NTYPECONTRAT = '{currentRowPri["NTYPECONTRAT"]}'";
        ModuleData.CnxExecute(sSQL);
      }
      else
        MessageBox.Show("Veuillez positionner une date", Program.AppTitle, MessageBoxButtons.OK, MessageBoxIcon.Exclamation);

      // réinitialisation après
      ApiGridSite.Requery(dtSec, MozartDatabase.cnxMozart);
    }

    private void mnuAjoutDuree_Click(object sender, EventArgs e)
    {
      DataRow currentRowSec = ApiGridSite.GetFocusedDataRow();
      DataRow currentRowPri = ApiGridCtr.GetFocusedDataRow();
      if (currentRowSec == null || currentRowPri == null) return;

      if (Utils.ZeroIfNull(currentRowSec["NDUREEINTER"]) > 0)
      {
        double dDuree = Utils.ZeroIfNull(currentRowSec["NDUREEINTER"]);

        // on positionne le nb d'intervention / an tous les sites affichés (on prend en compte le filtre sur la grille)
        IList<int> lListeIDs = dtSec.Select(CriteriaToWhereClauseHelper.GetDataSetWhere(ApiGridSite.dgv.ActiveFilterCriteria)).ToList().Select(item => Convert.ToInt32(item["NSITNUM"])).ToList();
        if (lListeIDs.Count == 0) return;

        string sSQL = $"UPDATE TCONT SET NDUREEINTER = REPLACE('{dDuree}',',','.') WHERE NSITNUM IN ({string.Join(",", lListeIDs)}) AND NTYPECONTRAT = '{currentRowPri["NTYPECONTRAT"]}'";
        ModuleData.CnxExecute(sSQL);
      }
      else
        MessageBox.Show(Resources.msg_positionnerVal0, Program.AppTitle, MessageBoxButtons.OK, MessageBoxIcon.Exclamation);

      //  réinitialisation après
      ApiGridSite.Requery(dtSec, MozartDatabase.cnxMozart);
      ApiGrid.Requery(dtTer, MozartDatabase.cnxMozart);
    }

    private void mnuMontant_Click(object sender, EventArgs e)
    {
      DataRow currentRowSec = ApiGridSite.GetFocusedDataRow();
      DataRow currentRowPri = ApiGridCtr.GetFocusedDataRow();
      if (currentRowSec == null || currentRowPri == null) return;

      if (!Convert.IsDBNull(currentRowSec["NMONTANTINTER"]) && Utils.ZeroIfNull(currentRowSec["NMONTANTINTER"]) > 0)
      {
        double dMontant = Utils.ZeroIfNull(currentRowSec["NMONTANTINTER"]);

        // on positionne le nb d'intervention / an tous les sites affichés (on prend en compte le filtre sur la grille)
        IList<int> lListeIDs = dtSec.Select(CriteriaToWhereClauseHelper.GetDataSetWhere(ApiGridSite.dgv.ActiveFilterCriteria)).ToList().Select(item => Convert.ToInt32(item["NSITNUM"])).ToList();
        if (lListeIDs.Count == 0) return;

        string sSQL = $"UPDATE TCONT SET NMONTANTINTER = REPLACE('{dMontant}',',','.') WHERE NSITNUM IN ({string.Join(",", lListeIDs)}) AND NTYPECONTRAT = '{currentRowPri["NTYPECONTRAT"]}'";
        ModuleData.CnxExecute(sSQL);
      }
      else
        MessageBox.Show(Resources.msg_posiValSupEgal0, Program.AppTitle, MessageBoxButtons.OK, MessageBoxIcon.Exclamation);

      //  réinitialisation après
      ApiGridSite.Requery(dtSec, MozartDatabase.cnxMozart);
      ApiGrid.Requery(dtTer, MozartDatabase.cnxMozart);
    }

    private void mnuAjoutMontantP3_Click(object sender, EventArgs e)
    {
      DataRow currentRowSec = ApiGridSite.GetFocusedDataRow();
      DataRow currentRowPri = ApiGridCtr.GetFocusedDataRow();
      if (currentRowSec == null || currentRowPri == null) return;

      if (!Convert.IsDBNull(currentRowSec["NMONTANTP3"]) && Utils.ZeroIfNull(currentRowSec["NMONTANTP3"]) > 0)
      {
        double dMontant = Utils.ZeroIfNull(currentRowSec["NMONTANTP3"]);

        // on positionne le nb d'intervention / an tous les sites affichés (on prend en compte le filtre sur la grille)
        IList<int> lListeIDs = dtSec.Select(CriteriaToWhereClauseHelper.GetDataSetWhere(ApiGridSite.dgv.ActiveFilterCriteria)).ToList().Select(item => Convert.ToInt32(item["NSITNUM"])).ToList();
        if (lListeIDs.Count == 0) return;

        string sSQL = $"UPDATE TCONT SET NMONTANTP3 = REPLACE('{dMontant}',',','.') WHERE NSITNUM IN ({string.Join(",", lListeIDs)}) AND NTYPECONTRAT = '{currentRowPri["NTYPECONTRAT"]}'";
        ModuleData.CnxExecute(sSQL);
      }
      else
        MessageBox.Show(Resources.msg_posValSup0P3, Program.AppTitle, MessageBoxButtons.OK, MessageBoxIcon.Exclamation);

      //  réinitialisation après
      ApiGridSite.Requery(dtSec, MozartDatabase.cnxMozart);
      ApiGrid.Requery(dtTer, MozartDatabase.cnxMozart);
    }

    private void mnuAjoutMontantSTT_Click(object sender, EventArgs e)
    {
      DataRow currentRowSec = ApiGridSite.GetFocusedDataRow();
      DataRow currentRowPri = ApiGridCtr.GetFocusedDataRow();
      if (currentRowSec == null || currentRowPri == null) return;

      if (!Convert.IsDBNull(currentRowSec["NMONTANTSTTP2"]) && Utils.ZeroIfNull(currentRowSec["NMONTANTSTTP2"]) > 0)
      {
        double dMontant = Utils.ZeroIfNull(currentRowSec["NMONTANTSTTP2"]);

        // on positionne le nb d'intervention / an tous les sites affichés (on prend en compte le filtre sur la grille)
        IList<int> lListeIDs = dtSec.Select(CriteriaToWhereClauseHelper.GetDataSetWhere(ApiGridSite.dgv.ActiveFilterCriteria)).ToList().Select(item => Convert.ToInt32(item["NSITNUM"])).ToList();
        if (lListeIDs.Count == 0) return;

        string sSQL = $"UPDATE TCONT SET NMONTANTSTTP2 = REPLACE('{dMontant}',',','.') WHERE NSITNUM IN ({string.Join(",", lListeIDs)}) AND NTYPECONTRAT = '{currentRowPri["NTYPECONTRAT"]}'";
        ModuleData.CnxExecute(sSQL);
      }
      else
        MessageBox.Show("Veuillez positionner une valeur > 0 à zéro pour le montant STT P2", Program.AppTitle, MessageBoxButtons.OK, MessageBoxIcon.Exclamation);

      //  réinitialisation après
      ApiGridSite.Requery(dtSec, MozartDatabase.cnxMozart);
      ApiGrid.Requery(dtTer, MozartDatabase.cnxMozart);
    }

    private void mnuAjoutNbEquip_Click(object sender, EventArgs e)
    {
      DataRow currentRowSec = ApiGridSite.GetFocusedDataRow();
      DataRow currentRowPri = ApiGridCtr.GetFocusedDataRow();
      if (currentRowSec == null || currentRowPri == null) return;

      if (!Convert.IsDBNull(currentRowSec["NNBEQUIP"]))
      {
        int iNbEquip = (int)Utils.ZeroIfNull(currentRowSec["NNBEQUIP"]);

        // on positionne le nb d'équipements tous les sites affichés (on prend en compte le filtre sur la grille)
        IList<int> lListeIDs = dtSec.Select(CriteriaToWhereClauseHelper.GetDataSetWhere(ApiGridSite.dgv.ActiveFilterCriteria)).ToList().Select(item => Convert.ToInt32(item["NSITNUM"])).ToList();
        if (lListeIDs.Count == 0) return;

        string sSQL = $"UPDATE TCONT SET NNBEQUIP = {iNbEquip} WHERE NSITNUM IN ({string.Join(",", lListeIDs)}) AND NTYPECONTRAT = '{currentRowPri["NTYPECONTRAT"]}'";
        ModuleData.CnxExecute(sSQL);
      }
      else
        MessageBox.Show(Resources.msg_posValNbEqui, Program.AppTitle, MessageBoxButtons.OK, MessageBoxIcon.Exclamation);

      //  réinitialisation après
      ApiGridSite.Requery(dtSec, MozartDatabase.cnxMozart);
    }

    private void mnuAjoutNbInterTous_Click(object sender, EventArgs e)
    {
      DataRow currentRowSec = ApiGridSite.GetFocusedDataRow();
      DataRow currentRowPri = ApiGridCtr.GetFocusedDataRow();
      if (currentRowSec == null || currentRowPri == null) return;

      if (!Convert.IsDBNull(currentRowSec["NNBVISANNUEL"]))
      {
        int iNbInter = (int)Utils.ZeroIfNull(currentRowSec["NNBVISANNUEL"]);

        // on positionne le nb d'équipements tous les sites affichés (on prend en compte le filtre sur la grille)
        IList<int> lListeIDs = dtSec.Select(CriteriaToWhereClauseHelper.GetDataSetWhere(ApiGridSite.dgv.ActiveFilterCriteria)).ToList().Select(item => Convert.ToInt32(item["NSITNUM"])).ToList();
        if (lListeIDs.Count == 0) return;

        string sSQL = $"UPDATE TCONT SET NNBVISANNUEL = {iNbInter} WHERE NSITNUM IN ({string.Join(",", lListeIDs)}) AND NTYPECONTRAT = '{currentRowPri["NTYPECONTRAT"]}'";
        ModuleData.CnxExecute(sSQL);
      }
      else
        MessageBox.Show("Veuillez positionner une valeur pour le nb d'interventions/an", Program.AppTitle, MessageBoxButtons.OK, MessageBoxIcon.Exclamation);

      //  réinitialisation après
      ApiGridCtr.Requery(dtPri, MozartDatabase.cnxMozart);
      ApiGridSite.Requery(dtSec, MozartDatabase.cnxMozart);
      ApiGrid.Requery(dtTer, MozartDatabase.cnxMozart);
    }

    private void mnuDesaffecter_Click(object sender, EventArgs e)
    {
      DataRow currentRowPri = ApiGridCtr.GetFocusedDataRow();
      if (currentRowPri == null) return;

      IList<int> lListeIDs = dtSec.Select(CriteriaToWhereClauseHelper.GetDataSetWhere(ApiGridSite.dgv.ActiveFilterCriteria)).ToList().Select(item => Convert.ToInt32(item["NSITNUM"])).ToList();
      if (lListeIDs.Count == 0) return;

      string sSQL = $"UPDATE TCONT SET VCONTETAT='NON' WHERE NSITNUM IN ({string.Join(",", lListeIDs)}) AND NTYPECONTRAT = '{currentRowPri["NTYPECONTRAT"]}'";
      ModuleData.CnxExecute(sSQL);

      //  réinitialisation après
      ApiGridSite.Requery(dtSec, MozartDatabase.cnxMozart);
      ApiGrid.Requery(dtTer, MozartDatabase.cnxMozart);
    }

    private void mnuSupDate_Click(object sender, EventArgs e)
    {
      DataRow currentRowPri = ApiGridCtr.GetFocusedDataRow();
      if (ApiGridSite.GetFocusedDataRow() == null || currentRowPri == null) return;

      // on positionne le nb d'intervention / an à 0 pour tous les sites affichés (on prend en compte le filtre sur la grille)
      IList<int> lListeIDs = dtSec.Select(CriteriaToWhereClauseHelper.GetDataSetWhere(ApiGridSite.dgv.ActiveFilterCriteria)).ToList().Select(item => Convert.ToInt32(item["NSITNUM"])).ToList();
      if (lListeIDs.Count == 0) return;

      string sSQL = $"UPDATE TCONT SET {sNomColDate} = NULL WHERE NSITNUM IN ({string.Join(",", lListeIDs)}) AND NTYPECONTRAT = '{currentRowPri["NTYPECONTRAT"]}'";
      ModuleData.CnxExecute(sSQL);

      // réinitialisation après
      ApiGridSite.Requery(dtSec, MozartDatabase.cnxMozart);
    }

    private void mnuSupDuree_Click(object sender, EventArgs e)
    {
      DataRow currentRowPri = ApiGridCtr.GetFocusedDataRow();
      if (ApiGridSite.GetFocusedDataRow() == null || currentRowPri == null) return;

      // on positionne le nb d'intervention / an à 0 pour tous les sites affichés (on prend en compte le filtre sur la grille)
      IList<int> lListeIDs = dtSec.Select(CriteriaToWhereClauseHelper.GetDataSetWhere(ApiGridSite.dgv.ActiveFilterCriteria)).ToList().Select(item => Convert.ToInt32(item["NSITNUM"])).ToList();
      if (lListeIDs.Count == 0) return;

      string sSQL = $"UPDATE TCONT SET NDUREEINTER = NULL WHERE NSITNUM IN ({string.Join(",", lListeIDs)}) AND NTYPECONTRAT = '{currentRowPri["NTYPECONTRAT"]}'";
      ModuleData.CnxExecute(sSQL);

      // réinitialisation après
      ApiGridSite.Requery(dtSec, MozartDatabase.cnxMozart);
      ApiGrid.Requery(dtTer, MozartDatabase.cnxMozart);
    }

    private void mnuSupMontant_Click(object sender, EventArgs e)
    {
      DataRow currentRowPri = ApiGridCtr.GetFocusedDataRow();
      if (ApiGridSite.GetFocusedDataRow() == null || currentRowPri == null) return;

      // on positionne le nb d'intervention / an à 0 pour tous les sites affichés (on prend en compte le filtre sur la grille)
      IList<int> lListeIDs = dtSec.Select(CriteriaToWhereClauseHelper.GetDataSetWhere(ApiGridSite.dgv.ActiveFilterCriteria)).ToList().Select(item => Convert.ToInt32(item["NSITNUM"])).ToList();
      if (lListeIDs.Count == 0) return;

      string sSQL = $"UPDATE TCONT SET NMONTANTINTER = NULL WHERE NSITNUM IN ({string.Join(",", lListeIDs)}) AND NTYPECONTRAT = '{currentRowPri["NTYPECONTRAT"]}'";
      ModuleData.CnxExecute(sSQL);

      // réinitialisation après
      ApiGridSite.Requery(dtSec, MozartDatabase.cnxMozart);
      ApiGrid.Requery(dtTer, MozartDatabase.cnxMozart);
    }

    private void mnuSupMontantP3_Click(object sender, EventArgs e)
    {
      DataRow currentRowPri = ApiGridCtr.GetFocusedDataRow();
      if (ApiGridSite.GetFocusedDataRow() == null || currentRowPri == null) return;

      // on positionne le nb d'intervention / an à 0 pour tous les sites affichés (on prend en compte le filtre sur la grille)
      IList<int> lListeIDs = dtSec.Select(CriteriaToWhereClauseHelper.GetDataSetWhere(ApiGridSite.dgv.ActiveFilterCriteria)).ToList().Select(item => Convert.ToInt32(item["NSITNUM"])).ToList();
      if (lListeIDs.Count == 0) return;

      string sSQL = $"UPDATE TCONT SET NMONTANTP3 = NULL WHERE NSITNUM IN ({string.Join(",", lListeIDs)}) AND NTYPECONTRAT = '{currentRowPri["NTYPECONTRAT"]}'";
      ModuleData.CnxExecute(sSQL);

      // réinitialisation après
      ApiGridSite.Requery(dtSec, MozartDatabase.cnxMozart);
      ApiGrid.Requery(dtTer, MozartDatabase.cnxMozart);
    }

    private void mnuSupMontantSTT_Click(object sender, EventArgs e)
    {
      DataRow currentRowPri = ApiGridCtr.GetFocusedDataRow();
      if (ApiGridSite.GetFocusedDataRow() == null || currentRowPri == null) return;

      // on positionne le nb d'intervention / an à 0 pour tous les sites affichés (on prend en compte le filtre sur la grille)
      IList<int> lListeIDs = dtSec.Select(CriteriaToWhereClauseHelper.GetDataSetWhere(ApiGridSite.dgv.ActiveFilterCriteria)).ToList().Select(item => Convert.ToInt32(item["NSITNUM"])).ToList();
      if (lListeIDs.Count == 0) return;

      string sSQL = $"UPDATE TCONT SET NMONTANTSTTP2 = NULL WHERE NSITNUM IN ({string.Join(",", lListeIDs)}) AND NTYPECONTRAT = '{currentRowPri["NTYPECONTRAT"]}'";
      ModuleData.CnxExecute(sSQL);

      ApiGridSite.Requery(dtSec, MozartDatabase.cnxMozart);
      ApiGrid.Requery(dtTer, MozartDatabase.cnxMozart);
    }

    private void mnuSupNbEquip_Click(object sender, EventArgs e)
    {
      DataRow currentRowPri = ApiGridCtr.GetFocusedDataRow();
      if (ApiGridSite.GetFocusedDataRow() == null || currentRowPri == null) return;

      // on positionne le nb d'équipements à 0 pour tous les sites affichés (on prend en compte le filtre sur la grille)
      IList<int> lListeIDs = dtSec.Select(CriteriaToWhereClauseHelper.GetDataSetWhere(ApiGridSite.dgv.ActiveFilterCriteria)).ToList().Select(item => Convert.ToInt32(item["NSITNUM"])).ToList();
      if (lListeIDs.Count == 0) return;

      string sSQL = $"UPDATE TCONT SET NNBEQUIP = 0 WHERE NSITNUM IN ({string.Join(",", lListeIDs)}) AND NTYPECONTRAT = '{currentRowPri["NTYPECONTRAT"]}'";
      ModuleData.CnxExecute(sSQL);

      ApiGridSite.Requery(dtSec, MozartDatabase.cnxMozart);
    }

    private void mnuSupNbInterTous_Click(object sender, EventArgs e)
    {
      DataRow currentRowPri = ApiGridCtr.GetFocusedDataRow();
      if (ApiGridSite.GetFocusedDataRow() == null || currentRowPri == null) return;

      // On positionne le nb d'interventions / an à 0 pour tous les sites affichés (on prend en compte le filtre sur la grille)
      IList<int> lListeIDs = dtSec.Select(CriteriaToWhereClauseHelper.GetDataSetWhere(ApiGridSite.dgv.ActiveFilterCriteria)).ToList().Select(item => Convert.ToInt32(item["NSITNUM"])).ToList();
      if (lListeIDs.Count == 0) return;

      string sSQL = $"UPDATE TCONT SET NNBVISANNUEL = 0 WHERE NSITNUM IN ({string.Join(",", lListeIDs)}) AND NTYPECONTRAT = '{currentRowPri["NTYPECONTRAT"]}'";
      ModuleData.CnxExecute(sSQL);

      // réinitialisation après
      ApiGridCtr.Requery(dtPri, MozartDatabase.cnxMozart);
      ApiGridSite.Requery(dtSec, MozartDatabase.cnxMozart);
      ApiGrid.Requery(dtTer, MozartDatabase.cnxMozart);
    }

    private void cmdImplantation_Click(object sender, EventArgs e)
    {
      DataRow currentRowPri = ApiGridCtr.GetFocusedDataRow();
      if (currentRowPri == null) return;

      new frmBrowser
      {
        msStartingAddress = $"https://maps.emalec.com/SitesContratClient.asp?BASE=MULTI&NOM={msNomClient.Replace("&", "-")}&NUM={miNumClient}&Contrat={ currentRowPri["NTYPECONTRAT"]} &vContrat={currentRowPri["VTYPECONTRAT"]}&APP={MozartParams.NomSociete}"
      }.ShowDialog();
    }

    private void cmdPrix_Click(object sender, EventArgs e)
    {
      framePrix.Visible = !framePrix.Visible;
    }

    private void cmdCopieFiliale6_Click(object sender, EventArgs e)
    {
      framePrix.Visible = false;
    }

    private void cmdCopieFiliale0_Click(object sender, EventArgs e)
    {
      DataRow currentRowPri = ApiGridCtr.GetFocusedDataRow();
      if (currentRowPri == null) return;

      if (MessageBox.Show(this, "Attention, vous allez appliquer le coefficient saisi ci-dessous, à tous les éléments affichés dans la grille !\r\nEtes-vous sûr ?",
                          Program.AppTitle, MessageBoxButtons.YesNo) != DialogResult.Yes) return;

      // on positionne le montant de l'inter P2 pour tous les sites affichés (on prend en compte le filtre sur la grille)
      IList<int> lListeIDs = dtSec.Select(CriteriaToWhereClauseHelper.GetDataSetWhere(ApiGridSite.dgv.ActiveFilterCriteria)).ToList().Select(item => Convert.ToInt32(item["NSITNUM"])).ToList();
      if (lListeIDs.Count == 0) return;

      string sSQL = $"UPDATE TCONT SET NMONTANTINTER = NMONTANTINTER * CONVERT(DECIMAL(9,4), REPLACE('{txtCoef.Text}' ,',','.'))" +
                    $"WHERE NSITNUM IN ({string.Join(",", lListeIDs)}) AND NTYPECONTRAT = '{currentRowPri["NTYPECONTRAT"]}'";
      ModuleData.CnxExecute(sSQL);

      // réinitialisation après
      ApiGridSite.Requery(dtSec, MozartDatabase.cnxMozart);
      ApiGrid.Requery(dtTer, MozartDatabase.cnxMozart);

      framePrix.Visible = false;
    }

    private void txtCoef_KeyPress(object sender, KeyPressEventArgs e)
    {
      KeyValidator.KeyPress_SaisieMontant(e);
    }

    private void ApiGridCtr_RowCellStyle(object sender, RowCellStyleEventArgs e)
    {
      if ((e.Column.FieldName == "NTOTALSAISIE") || (e.Column.FieldName == "NMONTANTCONTRAT"))
      {
        GridView view = sender as GridView;

        double lTotalSaisie = Utils.ZeroIfNull(view.GetRowCellValue(e.RowHandle, "NTOTALSAISIE"));
        double lContratPapier = Utils.ZeroIfNull(view.GetRowCellValue(e.RowHandle, "NMONTANTCONTRAT"));
        if (lTotalSaisie != lContratPapier)
        {
          e.Appearance.BackColor = Color.Red;
        }
      }
    }
  }
}

