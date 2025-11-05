using DevExpress.XtraGrid.Views.Grid;
using MozartCS.Properties;
using MozartLib;
using MozartNet;
using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Reflection;
using System.Windows.Forms;
using MZCtrlResources = MozartControls.Properties.Resources;
using MZUtils = MozartControls.Utils;

namespace MozartCS
{
  public partial class frmRechercheArticles : Form
  {
    public int miNumAction;     // <-- MozartParams.NumAction
    public int miNumDi;     // <-- MozartParams.NumDI
    public int miNumClient;
    public string msNomClient;
    public DataTable mdtArticles = new DataTable();

    private int miNumSiteFournisseur;
    private string msNomSiteFournisseur;

    private DataTable dt = new DataTable();

    private int iIndexFouTabHaut = 0;
    private int iIndexFouTabBas = 0;
    private List<string> tabLstImgFouH = new List<string>();
    private List<string> tabLstImgFouB = new List<string>();


    public frmRechercheArticles() { InitializeComponent(); }

    private void frmRechercheArticles_Load(object sender, System.EventArgs e)
    {
      try
      {
        Cursor.Current = Cursors.WaitCursor;
        ModuleMain.Initboutons(this);

        ucSelectArticle.init(MozartDatabase.cnxMozart, miNumDi);

        InitApiTgrid();
        InitApiTgrid2();

        //  ' mise a jour du total
        txtHT.Text = CalculerTHT();

        string sActFou = ModuleData.ExecuteScalarString($"SELECT VACTFOU FROM TACT WHERE VACTFOU is not null and VACTFOU <> '' AND NACTNUM = {miNumAction}");
        if (sActFou != "")
        {
          apiToolTip1.Width = 500;
          apiToolTip1.Texte = sActFou;
          apiToolTip1.Titre = Resources.lbl_Demande_technicien;
          apiToolTip1.PrintTexte("");
          apiToolTip1.Visible = true;
        }

        chkStock.Enabled = false;
        ChkStockOut.Enabled = false;
        chkPrixClient.Enabled = false;
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

    private void cmdAjouter_Click(object sender, EventArgs e)
    {
      try
      {
        DataRow row = apiTGrid1.GetFocusedDataRow();
        if (row == null) return;

        //  test si l'enregistrement n'est pas déja selectionné
        //  on a le numArticle on regarde si il existe
        bool bOK = false;

        //  Information sur le fournisseur interdit ou pas
        if (ModuleData.ExecuteScalarString($"SELECT CNOTINTERDIT FROM TNOTES WHERE VNOTTYPE = 'INFO_STF' AND NNOTCLE = {row["NSTFGRPNUM"]}") == "O")
        {
          MessageBox.Show(Resources.msg_Fournisseur_interdit, Program.AppTitle, MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
          return;
        }

        DataRow[] rowArts = mdtArticles.Select($"NumArticle = {row["NFOUNUM"]}");
        DataRow rowArt = null;
        if (rowArts.Length > 0)
          rowArt = rowArts[0];

        if (rowArt != null)
        {
          bOK = true;
          if (mdtArticles.Select($"NumFour = {row["NSTFGRPNUM"]}").Length != 0)
          {
            miNumSiteFournisseur = Convert.ToInt32(rowArt["NumSiteFour"]);
            msNomSiteFournisseur = rowArt["Fournisseur"].ToString();
          }
        }

        //  si H&M, on peut ajouter plusierus fois le meme articles
        //  ' TB SAMSIC CITY SPEC
        if (MozartParams.NomGroupe == "EMALEC" && miNumClient == 494)
          bOK = false;

        if (!bOK)
        {
          // Recherche des sites du fournisseur
          DataTable dtFou = new DataTable();
          dtFou.Load(ModuleData.ExecuteReader("SELECT DISTINCT NSTFNUM, VSTFNOM from TSTF WHERE NSTFGRPNUM = " + row["NSTFGRPNUM"] + " AND CSTFACTIF='O' "));
          // si count = 0 alors le fournisseur n existe plus sur cette fourniture
          if (dtFou.Rows.Count == 0)
          {
            MessageBox.Show(Resources.msg_site_fournisseur_inactif, Program.AppTitle, MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
            dtFou.Dispose();
            return;
          }
          // Fournisseur = site
          miNumSiteFournisseur = Convert.ToInt32(dtFou.Rows[0]["NSTFNUM"]);
          msNomSiteFournisseur = dtFou.Rows[0]["VSTFNOM"].ToString();

          AjouterEnreg(row);
        }
        else
        {
          MessageBox.Show(Resources.msg_article_already_in_list, Program.AppTitle, MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
        }

        apiTGrid2.GridControl.DataSource = mdtArticles;
        txtHT.Text = CalculerTHT();
      }
      catch (Exception ex)
      {
        MZUtils.displayError(MethodBase.GetCurrentMethod().Name, ex);
      }
    }

    private void AjouterEnreg(DataRow row)
    {
      try
      {
        DataRow newRow = mdtArticles.NewRow();

        newRow["Serie"] = row["VFOUSER"];
        newRow["Article"] = row["VFOUMAT"];
        newRow["Marque"] = Utils.BlankIfNull(row["VFOUMAR"]);
        newRow["VFOUTYP"] = Utils.BlankIfNull(row["VFOUTYP"]);
        newRow["VFOUREF"] = Utils.BlankIfNull(row["VFOUREF"]);
        newRow["NFOUNBLOT"] = Utils.ZeroIfNull(row["NFOUNBLOT"]);
        newRow["Prix U"] = Utils.ZeroIfNull(row["FPUHT"]);
        newRow["Quantite"] = 1;
        newRow["Prix T"] = 1 * Utils.ZeroIfNull(row["FPUHT"]);
        newRow["NumArticle"] = row["NFOUNUM"];
        newRow["Prix Client"] = Utils.ZeroIfNull(row["NPUHTCLI"]);
        newRow["Fournisseur"] = msNomSiteFournisseur;
        newRow["NumFour"] = row["NSTFGRPNUM"];
        newRow["NumSiteFour"] = miNumSiteFournisseur;
        newRow["Date prix"] = Utils.BlankIfNull(row["Date prix"]);
        newRow["NFOUCOEFF"] = Utils.ZeroIfNull(row["NFOUCOEFF"]);
        newRow["NCFOCOD"] = row["NCFOCOD"];

        mdtArticles.Rows.Add(newRow);
      }
      catch (Exception ex)
      {
        MZUtils.displayError(MethodBase.GetCurrentMethod().Name, ex);
      }
    }

    private void chkStock_CheckedChanged(object sender, EventArgs e)
    {
      if (ChkStockOut.Checked && chkStock.Checked)
        ChkStockOut.Checked = false;

      updateApiTGrid1Filter();
    }

    private void ChkStockOut_CheckedChanged(object sender, EventArgs e)
    {
      if (chkStock.Checked && ChkStockOut.Checked)
        chkStock.Checked = false;

      updateApiTGrid1Filter();
    }

    private void chkPrixClient_CheckedChanged(object sender, EventArgs e)
    {
      updateApiTGrid1Filter();
    }

    private void updateApiTGrid1Filter()
    {
      List<string> lFilters = new List<string>();

      if (chkStock.Checked)
      {
        lFilters.Add("CCODEG = 'O'");
      }

      if (ChkStockOut.Checked)
      {
        lFilters.Add("CCODEG != 'O'");
      }

      if (chkPrixClient.Checked)
      {
        lFilters.Add($"VFOUCLI LIKE '%{msNomClient}%'");
      }

      apiTGrid1.dgv.ActiveFilterString = String.Join(" AND ", lFilters);
    }

    private void cmdSupp_Click(object sender, EventArgs e)
    {
      try
      {
        DataRow rowD = apiTGrid2.GetFocusedDataRow();
        if (rowD == null) return;

        // Suppression du record selectionné
        mdtArticles.Rows.Remove(mdtArticles.Select($"NumArticle = {rowD["NumArticle"]}")[0]);

        txtHT.Text = CalculerTHT();
      }
      catch (Exception ex)
      {
        MZUtils.displayError(MethodBase.GetCurrentMethod().Name, ex);
      }
    }

    private void cmdValider_Click(object sender, EventArgs e)
    {
      try
      {
        DataRow rowD = apiTGrid2.GetFocusedDataRow();
        if (rowD == null) return;

        // Parcours du recordset et mise à jour
        foreach (DataRow dr in mdtArticles.Rows)
        {
          dr["PRIXVENTE2MOIS"] = RecherchePrixV2Mois(Convert.ToInt32(dr["NumArticle"]));

          if (Utils.ZeroIfNull(dr["Prix Client"]) > 0)
          {
            dr["Prix T"] = Utils.ZeroIfNull(dr["Prix Client"]) * Utils.ZeroIfNull(dr["Quantite"]);
            dr["NFOUCOEFF"] = 0;
          }
          //mise ne com le 24/05/2024 par mc a la demande de VIGUIER
          //else if (Utils.ZeroIfNull(dr["Prix Client"]) == 0 && Convert.ToInt32(dr["NCFOCOD"]) == 31)
          //{
          //  dr["Prix T"] = 0;
          //  dr["NFOUCOEFF"] = 0;
          //}
          else
          {
            dr["Prix T"] = Utils.ZeroIfNull(dr["Prix U"]) * Utils.ZeroIfNull(dr["Quantite"]) * Convert.ToDouble(dr["NFOUCOEFF"]);
          }
        }

        Dispose();
      }
      catch (Exception ex)
      {
        MZUtils.displayError(MethodBase.GetCurrentMethod().Name, ex);
      }
    }

    private void apiTGrid1_DoubleClickE(object sender, EventArgs e)
    {
      cmdAjouter_Click(null, null);
    }

    private void apiTGrid1_SelectionChanged(object sender, DevExpress.Data.SelectionChangedEventArgs e)
    {
      DataRow row = apiTGrid1.GetFocusedDataRow();
      if (row == null) return;

      lblQteStock.Text = $"{Resources.msg_qte_en_stock}{Utils.ZeroIfNull(row["NFOUQTESTOCK"])}";

      iIndexFouTabHaut = 0;
      ImageFournitureH.Image = null;

      tabLstImgFouH.Clear();
      using (SqlDataReader dr = ModuleData.ExecuteReader($"api_sp_ListeFileFourniture {row["NFOUNUM"]}"))
      {
        while (dr.Read())
          tabLstImgFouH.Add(dr["FILEIMGFOU"].ToString());
      }
      if (tabLstImgFouH.Count > 0)
      {
        FrameImgFouHaut.Visible = true;
        ImageFournitureH.Load(tabLstImgFouH[0]);
        if (tabLstImgFouH.Count > 1)
        {
          CmdImgHautLast.Visible = false;
          CmdImgHautNext.Visible = true;
        }
        else
        {
          CmdImgHautLast.Visible = false;
          CmdImgHautNext.Visible = false;
        }
      }
      else
        FrameImgFouHaut.Visible = false;
    }

    private string CalculerTHT()
    {
      double total = 0;

      foreach (DataRow row in mdtArticles.Rows)
      {
        if (Utils.BlankIfNull(row["Prix Client"]) != "")
          total += Utils.ZeroIfNull(row["Prix Client"]) * Utils.ZeroIfNull(row["Quantite"]);
        else
          total += Utils.ZeroIfNull(row["Prix U"]) * Utils.ZeroIfNull(row["Quantite"]);
      }

      return total.ToString("0.00 €");
    }

    private void InitApiTgrid()
    {
      try
      {
        apiTGrid1.AddColumn(MZCtrlResources.col_Serie, "VFOUSER", 700);
        apiTGrid1.AddColumn(MZCtrlResources.col_Materiel, "VFOUMAT", 4000);
        apiTGrid1.AddColumn(Resources.col_marque, "VFOUMAR", 1100);
        apiTGrid1.AddColumn(Resources.col_Type, "VFOUTYP", 1300);
        apiTGrid1.AddColumn(Resources.col_reference, "VFOUREF", 1100);
        apiTGrid1.AddColumn(Resources.col_pcb, "NFOUNBLOT", 600, "", 2);
        apiTGrid1.AddColumn(Resources.col_stock, "NFOUQTESTOCK", 700, "", 2);
        apiTGrid1.AddColumn(Resources.col_prixU, "FPUHT", 1000, "0.000", 1);
        apiTGrid1.AddColumn(Resources.col_Ref_Fou, "VSTFFOUREFCLI", 1200);
        apiTGrid1.AddColumn(Resources.col_Fournisseur, "VSTFGRPNOM", 1700);
        apiTGrid1.AddColumn(MZCtrlResources.col_Client, "VFOUCLI", 1000);
        apiTGrid1.AddColumn(Resources.col_prix_C, "NPUHTCLI", 1000, "0.000", 1);
        apiTGrid1.AddColumn(Resources.col_dateprix, "Date prix", 1000);
        apiTGrid1.AddColumn(Resources.col_Coeff, "NFOUCOEFF", 0);
        apiTGrid1.AddColumn(Resources.col_NumFourn, "NSTFGRPNUM", 0);
        apiTGrid1.AddColumn("NumArt", "NFOUNUM", 0);

        apiTGrid1.InitColumnList();
      }
      catch (Exception ex)
      {
        MZUtils.displayError(MethodBase.GetCurrentMethod().Name, ex);
      }
    }

    private void InitApiTgrid2()
    {
      apiTGrid2.FilterBar = false;

      apiTGrid2.AddColumn(MZCtrlResources.col_Serie, "Serie", 1200);
      apiTGrid2.AddColumn(MZCtrlResources.col_Materiel, "Article", 3500);
      apiTGrid2.AddColumn(Resources.col_marque, "Marque", 1100);
      apiTGrid2.AddColumn(Resources.col_Type, "VFOUTYP", 1300);    // equivaut a 3cm"
      apiTGrid2.AddColumn(Resources.col_reference, "VFOUREF", 1100);
      apiTGrid2.AddColumn(Resources.col_pcb, "PCB", 350, "", 2);
      apiTGrid2.AddColumn(Resources.col_Prix + MozartParams.NomSociete, "Prix U", 700, "0.000", 1);
      apiTGrid2.AddColumn(Resources.col_qte2, "Quantite", 350, "", 2);
      apiTGrid2.AddColumn(Resources.col_prixT, "Prix T", 700, "0.000", 1);
      apiTGrid2.AddColumn(Resources.col_dateprix, "Date prix", 0);
      apiTGrid2.AddColumn(Resources.col_Coeff, "coeff", 0);
      apiTGrid2.AddColumn(Resources.col_Prix_Client, "Prix Client", 700, "0.000", 1);
      apiTGrid2.AddColumn(Resources.col_Fournisseur, "Fournisseur", 1500);
      apiTGrid2.AddColumn(Resources.col_Num_Fournisseur, "NumFour", 0);
      apiTGrid2.AddColumn(Resources.col_NumSiteFour, "NumSiteFour", 0);

      apiTGrid2.AddColumn("NumArt", "NumArticle", 0);

      apiTGrid2.DelockColumn("Quantite");
      apiTGrid2.InitColumnList();

      apiTGrid2.GridControl.DataSource = mdtArticles;

    }

    private void apiTGrid2_CellValueChanged(object sender, DevExpress.XtraGrid.Views.Base.CellValueChangedEventArgs e)
    {
      txtHT.Text = CalculerTHT();
    }

    private void CmdImgHautLast_Click(object sender, EventArgs e)
    {
      if (iIndexFouTabHaut - 1 == 0)
      {
        iIndexFouTabHaut = 0;
        CmdImgHautLast.Visible = false;
        CmdImgHautNext.Visible = true;
      }
      else
      {
        iIndexFouTabHaut -= 1;
        CmdImgHautLast.Visible = CmdImgHautNext.Visible = true;
      }

      ImageFournitureH.Load(tabLstImgFouH[iIndexFouTabHaut]);
    }

    private void CmdImgHautNext_Click(object sender, EventArgs e)
    {
      if (iIndexFouTabHaut + 1 >= tabLstImgFouH.Count)
      {
        iIndexFouTabHaut = tabLstImgFouH.Count;
        CmdImgHautNext.Visible = false;
        CmdImgHautLast.Visible = true;
      }
      else
      {
        iIndexFouTabHaut += 1;
        CmdImgHautLast.Visible = CmdImgHautNext.Visible = true;
      }

      ImageFournitureH.Load(tabLstImgFouH[iIndexFouTabHaut]);
    }

    private void apiTGrid2_SelectionChanged(object sender, DevExpress.Data.SelectionChangedEventArgs e)
    {
      DataRow row = apiTGrid2.GetFocusedDataRow();
      iIndexFouTabBas = 0;

      ImageFournitureB.Image = null;

      tabLstImgFouB.Clear();
      if (row == null) { return; }
      using (SqlDataReader dr = ModuleData.ExecuteReader($"api_sp_ListeFileFourniture {row["NumArticle"]}"))
      {
        while (dr.Read())
          tabLstImgFouB.Add(dr["FILEIMGFOU"].ToString());
      }

      if (tabLstImgFouB.Count > 0)
      {
        FrameImgFouBas.Visible = true;
        ImageFournitureB.Load(tabLstImgFouB[0]);
        if (tabLstImgFouB.Count > 1)
        {
          CmdImgBasLast.Visible = false;
          CmdImgBasNext.Visible = true;
        }
        else
        {
          CmdImgBasLast.Visible = false;
          CmdImgBasNext.Visible = false;
        }
      }
      else
        FrameImgFouBas.Visible = false;
    }

    private void CmdImgBasLast_Click(object sender, EventArgs e)
    {
      if (iIndexFouTabBas - 1 == 0)
      {
        iIndexFouTabBas = 0;
        CmdImgBasLast.Visible = false;
        CmdImgBasNext.Visible = true;
      }
      else
      {
        iIndexFouTabBas -= 1;
        CmdImgBasLast.Visible = CmdImgBasNext.Visible = true;
      }

      ImageFournitureH.Load(tabLstImgFouB[iIndexFouTabBas]);
    }

    private void CmdImgBasNext_Click(object sender, EventArgs e)
    {
      if (iIndexFouTabBas + 1 >= tabLstImgFouB.Count)
      {
        iIndexFouTabBas = tabLstImgFouB.Count;
        CmdImgBasNext.Visible = false;
        CmdImgBasLast.Visible = true;
      }
      else
      {
        iIndexFouTabBas += 1;
        CmdImgBasLast.Visible = CmdImgBasNext.Visible = true;
      }

      ImageFournitureB.Load(tabLstImgFouB[iIndexFouTabBas]);
    }

    private double RecherchePrixV2Mois(int NumArticle)
    {
      return (double)ModuleData.ExecuteScalarDouble($"api_sp_TrouvePrixVenteFouCli {miNumClient}, {NumArticle}");
    }

    private void apiTGrid1_RowStyle(object sender, DevExpress.XtraGrid.Views.Grid.RowStyleEventArgs e)
    {
      if (e.RowHandle < 0) return;

      GridView View = sender as GridView;

      if (View.GetDataRow(e.RowHandle)["CCODEG"].ToString() == "O")
      {
        e.Appearance.Font = new Font(e.Appearance.Font, FontStyle.Bold);
      }

      switch (View.GetDataRow(e.RowHandle)["CCODE"].ToString())
      {
        case "R":
          e.Appearance.ForeColor = Color.Black;
          e.Appearance.BackColor = MozartColors.colorHDBE6FD;
          break;
        case "V":
          e.Appearance.ForeColor = Color.Black;
          e.Appearance.BackColor = MozartColors.colorHEEFFE3;
          break;
        default:
          break;
      }
    }

    private void cmdDetails_Click(object sender, EventArgs e)
    {
      DataRow row = apiTGrid1.GetFocusedDataRow();
      if (null == row)
        return;

      new frmDetailsFourniture()
      {
        mstrStatut = "M",
        mbStatutValidation = true,
        miNumFour = (int)Utils.ZeroIfNull(row["NFOUNUM"])
      }.ShowDialog();

      Cursor.Current = Cursors.WaitCursor;
      apiTGrid1.Requery(dt, MozartDatabase.cnxMozart);
      Cursor.Current = Cursors.Default;
    }

    private void frmRechercheArticles_KeyUp(object sender, KeyEventArgs e)
    {
      if (e.KeyCode == Keys.F2 || e.KeyCode == Keys.Enter)
      {
        ucSelectArticle.launchSearch();
      }
    }

    private void ucSelectArticle_SearchResult(DataTable result)
    {
      dt = result;
      apiTGrid1.GridControl.DataSource = dt;

      chkStock.Enabled = true;
      ChkStockOut.Enabled = true;
      chkPrixClient.Enabled = true;
    }

  }
}