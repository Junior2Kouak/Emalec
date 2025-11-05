using MZCtrlResources = MozartControls.Properties.Resources;
using DevExpress.Data.Filtering;
using DevExpress.XtraEditors.Controls;
using DevExpress.XtraEditors.Repository;
using DevExpress.XtraGrid.Localization;
using DevExpress.XtraGrid.Views.Grid;
using MozartCS.Properties;
using MozartLib;
using MozartNet;
using MozartUC;
using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Reflection;
using System.Windows.Forms;
using MZUtils = MozartControls.Utils;

namespace MozartCS
{
  public partial class frmStockArticleClient : Form
  {
    public string mstrStatut;
    public int miNumClient;
    public string mstrActif;

    private DataTable mdtArt;

    public frmStockArticleClient()
    {
      InitializeComponent();
      GridLocalizer.Active = new CustomGridLocalizer();
    }
    class CustomGridLocalizer : GridLocalizer
    {
      public override string GetLocalizedString(GridStringId id)
      {
        if (id == GridStringId.CheckboxSelectorColumnCaption)
        {
          return Resources.col_Gestion;
        }
        return base.GetLocalizedString(id);
      }
    }

    private void frmStockArticleClient_Load(object sender, System.EventArgs e)
    {
      try
      {
        Cursor.Current = Cursors.WaitCursor;
        ModuleMain.Initboutons(this);

        mnuAffecterTous.Text = "Affecter à tous";
        mnuDesaffecter.Text = "Désaffecter à tous";
        mnuAffecterContrat.Text = "Affecter à tous";
        mnuDesaffecterContrat.Text = "Désaffecter à tous";

        if (mstrStatut == "C")
        {
          cboClient.Init(MozartDatabase.cnxMozart, "select * from api_v_comboClient where NCLINUM not in (select distinct TSTOCKARTCLI.NCLINUM from TSTOCKARTCLI with (nolock)" +
                                         " inner join tfou with (nolock) on tfou.nfounum = TSTOCKARTCLI.nfounum where NCFOCOD <> 31) order by VCLINOM",
                                         "NCLINUM", "VCLINOM", new List<string>() { Resources.col_Nom, MZCtrlResources.col_Client }, 150, 500, true);
          OuvertureEnCreation();
        }
        else
        {
          cboClient.Init(MozartDatabase.cnxMozart, $"select * from api_v_comboClient where nclinum= {miNumClient} order by VCLINOM",
                                         "NCLINUM", "VCLINOM", new List<string>() { Resources.col_Nom, MZCtrlResources.col_Client }, 500, 500, true);
          OuvertureEnModification();
        }

        FormatGridT();

        apiTGrid.GridControl.DataSource = mdtArt;
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


    private void cmdValider_Click(object sender, EventArgs e)
    {
      if (apiTGrid.dgv.ActiveFilterString.ToString() != "")
      {
        MessageBox.Show("Pour enregistrer, il faut effacer les filtres de recherche !", Program.AppTitle, MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
        return;
      }

      if (cboClient.GetText() == "")
      {
        MessageBox.Show(Resources.msg_selectClient, Program.AppTitle, MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
        return;
      }

      //if (null == apiTGrid.GetFocusedDataRow())
      //{
      //  MessageBox.Show(Resources.msg_selection_article, Program.AppTitle, MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
      //  return;
      //}

      try
      {
        Cursor.Current = Cursors.WaitCursor;

        if (mstrStatut == "C)")
          EnregDesArticles();
        else
          EnregModificationListe();

        OuvertureEnModification();
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


    private void cmdVisu_Click(object sender, EventArgs e)
    {
      string[,] TdbGlobal = { { "copie", "1/2   Original" } };

      new frmBrowser()
      {
        miPlanningAn = 0
      }.Preview_Print($@"{MozartParams.CheminModeles}{MozartParams.Langue}\TStockSurSite.rtf",
                        @"TStockSiteOut.rtf",
                        TdbGlobal,
                        $"select * from api_v_impStockClient WHERE NCLINUM={miNumClient} order by VLIBART",
                        " (Visualisation)",
                        "PREVIEW");
    }


    private void cmdSupp_Click(object sender, EventArgs e)
    {
      DataRow row = apiTGrid.GetFocusedDataRow();
      if (null == row)
        return;

      if (MessageBox.Show("Voulez-vous vraiment supprimer cet article ?", Program.AppTitle, MessageBoxButtons.YesNo,
                          MessageBoxIcon.Question, MessageBoxDefaultButton.Button2) == DialogResult.Yes)
      {
        int NumArticle = (int)Utils.ZeroIfNull(row["NumArticle"]);
        //SqlDataReader reader = ModuleData.ExecuteReader($"select NFOUNUM from TFOU where NFOUNUM = {NumArticle}" +
        //                         $" AND NCLINUM <> 0 AND NCLINUM IS NOT NULL");

        //if (reader.HasRows)
        //{
        //  MessageBox.Show(Resources.msg_sup_article_mag, Program.AppTitle, MessageBoxButtons.OK, MessageBoxIcon.Information);
        //  return;
        //}
        //else
        //{
          int client = cboClient.GetItemData();
          // ' suppression dans la table des stock sites
          ModuleData.ExecuteNonQuery($"delete from TSTOCKARTCLISIT WHERE NCLINUM ={client} AND NFOUNUM ={NumArticle}");
          // ' suppression dans la table des stock client
          ModuleData.ExecuteNonQuery($"delete from TSTOCKARTCLI WHERE NCLINUM ={client} AND NFOUNUM ={NumArticle}");
          // ' suppression de la ligne courante
          mdtArt.Rows.Remove(row);
       // }
      }
    }

    private void cmdSuppTout_Click(object sender, EventArgs e)
    {
      if (mdtArt.Rows.Count == 0)
        return;

      if (MessageBox.Show(Resources.msg_sup_articles_tous, Program.AppTitle, MessageBoxButtons.YesNo,
                          MessageBoxIcon.Question, MessageBoxDefaultButton.Button2) == DialogResult.Yes)
      {
        int client = cboClient.GetItemData();
        // ' suppression dans la table des stock sites
        ModuleData.ExecuteNonQuery($"delete from TSTOCKARTCLISIT WHERE NCLINUM ={client}");
        // ' suppression dans la table des stock client
        ModuleData.ExecuteNonQuery($"delete from TSTOCKARTCLI WHERE NCLINUM ={client}");
        // ' suppression de la ligne courante ?
        mdtArt.Rows.Clear();

        OuvertureEnModification();
      }
    }

    private void cmdFournisseur_Click(object sender, EventArgs e)
    {
      DataRow row = apiTGrid.GetFocusedDataRow();
      if (null == row)
        return;

      new frmSelectionFournisseur()
      {
        mlFournitures = (long)Utils.ZeroIfNull(row["NumArticle"]),
        mlNumClient = miNumClient,
        mstrArticle = Utils.BlankIfNull(row["Article"])
      }.ShowDialog();

      OuvertureEnModification();
    }

    private void cmdCoef_Click(object sender, EventArgs e)
    {
      new frmGestCoeffVente()
      {
        miNumClient = miNumClient,
        mstrNomClient = cboClient.GetText()
      }.ShowDialog();
    }

    private void cmdSaisieCoeff_Click(object sender, EventArgs e)
    {
        GridView GV = apiTGrid.GridControl.MainView as GridView;
        List<int> rowListSelected = new List<int>();
        for (int i = 0; i < GV.DataRowCount; i++)
                rowListSelected.Add((int)GV.GetDataRow(i)["NumArticle"]);

            new frmSaisieCoefPrix()
            {
            miNumClient = miNumClient,
            mbListeFournitureEI = false,
            listFournitureToRevise = rowListSelected,
            iNbFoTotalPrixCli = mdtArt.Rows.Count
            }.ShowDialog();

      OuvertureEnModification();
    }


    private void cmdRechercher_Click(object sender, EventArgs e)
    {
      new frmRechercheArticlesCom()
      {
        miNumFournisseur = 0,
        m_brechercheSite = false,
        m_bSaisieQte = false,
        mstrStatut = "STOCK-CLI",
        mstrClient = "",
        m_bAfficheInfoFou = false,
        mdtArticles = mdtArt
      }.ShowDialog();
    }

    private void OuvertureEnCreation()
    {
      InitDataTableArticle();

      cboClient.SetItemData(-1);

      cmdRechercher.Text = Resources.msg_ajout_articles;
    }

    private void OuvertureEnModification()
    {
      //  ' position sur le bon client
      cboClient.SetItemData(miNumClient);
      //  ' initialisation du recordset local des articles
      InitDataTableArticle();
      //  ' recherche des détails fournitures
      using (SqlDataReader reader = ModuleData.ExecuteReader($"select * from api_v_listeArticlesClient where NCLINUM = {miNumClient} AND NCFOCOD <> 31 ORDER BY VFOUMAT"))
      {
        //  ' passage des infos du recordset
        while (reader.Read())
        {
          AjouterEnreg(reader);
        }
      }
      if (mdtArt != null) { apiTGrid.GridControl.DataSource = mdtArt; }
      cboClient.Enabled = false;
      cmdRechercher.Text = Resources.msg_Modifier_liste;
    }

    private void FormatGridT()
    {
      //apiTGrid.AddColumn(Resources.col_Gestion, "CHECK", 1000, "", 2, true);
      apiTGrid.AddColumn(Resources.col_Serie, "Serie", 0);
      apiTGrid.AddColumn(Resources.col_Contrat, "Contrat", 900, "", 2);
      apiTGrid.AddColumn("Affichage web", "Vuewebcli", 900, "", 2);
      apiTGrid.AddColumn(Resources.col_materiel, "Article", 4300, "", 0, true);
      apiTGrid.AddColumn(Resources.col_marque, "Marque", 1300, "", 0, true);
      apiTGrid.AddColumn(Resources.col_Type, "Type", 1500, "", 0, true);
      apiTGrid.AddColumn(Resources.col_reference, "Reference", 1300, "", 0, true);
      apiTGrid.AddColumn(Resources.col_pcb, "PCB", 850, "", 2);
      apiTGrid.AddColumn(Resources.col_Conso, "NBUTIL", 800);
      apiTGrid.AddColumn($"{Resources.col_Prix} {MozartParams.NomSociete}", "Prix U", 800, "## ##0.00", 1);
      apiTGrid.AddColumn(Resources.col_Qte, "Quantite", 0, "", 2);
      apiTGrid.AddColumn(Resources.col_Coeff, "Coeff", 800, "## ##0.00", 2);
      apiTGrid.AddColumn(Resources.col_Prix_Client, "Prix T", 1000, "## ##0.00", 1);
      apiTGrid.AddColumn(Resources.col_NumArticle, "NumArticle", 0);
      apiTGrid.AddColumn(Resources.col_NumFourn, "NumFour", 0);
      apiTGrid.AddColumn(Resources.col_TypeDeprix, "TypeDePrix", 0);

      apiTGrid.DelockColumn("Prix T");
      apiTGrid.DelockColumn("Contrat");
      apiTGrid.DelockColumn("Vuewebcli");


      apiTGrid.InitColumnList();

      apiTGrid.dgv.OptionsSelection.MultiSelect = true;
      apiTGrid.dgv.OptionsSelection.MultiSelectMode = GridMultiSelectMode.CheckBoxRowSelect;
      apiTGrid.dgv.OptionsSelection.ShowCheckBoxSelectorInColumnHeader = DevExpress.Utils.DefaultBoolean.False;
      apiTGrid.dgv.OptionsSelection.CheckBoxSelectorField = "Check";

      GridView gridView1 = apiTGrid.GridControl.MainView as GridView;
      RepositoryItemComboBox riComboBox = new RepositoryItemComboBox();
      riComboBox.Items.Add("NON");
      riComboBox.Items.Add("OUI");
      riComboBox.TextEditStyle = TextEditStyles.DisableTextEditor;
      gridView1.Columns["Contrat"].ColumnEdit = riComboBox;
      gridView1.Columns["Vuewebcli"].ColumnEdit = riComboBox;
      apiTGrid.GridControl.RepositoryItems.Add(riComboBox);

    }


    private void apiTGrid_RowCellStyle(object sender, RowCellStyleEventArgs e)
    {
      if (e.RowHandle >= 0 && (e.Column.Name == "Coeff" || e.Column.Name == "Prix T"))
      {

        if (((sender as GridView).GetDataRow(e.RowHandle)["TypeDeprix"]).ToString() != "B")
        {
          e.Appearance.ForeColor = System.Drawing.Color.Red;
          e.Appearance.BackColor = MozartColors.colorHCCCCCC;
          e.Appearance.Font = new Font(e.Appearance.Font, FontStyle.Bold);
        }
        else
        {
          e.Appearance.ForeColor = System.Drawing.Color.White;
          e.Appearance.BackColor = MozartColors.colorHCCCCCC;
          e.Appearance.Font = new Font(e.Appearance.Font, FontStyle.Bold);
        }
      }
    }

    private void InitDataTableArticle()
    {
      mdtArt = new DataTable();

      mdtArt.Columns.Add(new DataColumn("Check", System.Type.GetType("System.Int32")));
      mdtArt.Columns.Add(new DataColumn("Contrat", System.Type.GetType("System.String")));
      mdtArt.Columns.Add(new DataColumn("Vuewebcli", System.Type.GetType("System.String")));
      mdtArt.Columns.Add(new DataColumn("Serie", System.Type.GetType("System.String")));
      mdtArt.Columns.Add(new DataColumn("Article", System.Type.GetType("System.String")));
      mdtArt.Columns.Add(new DataColumn("Marque", System.Type.GetType("System.String")));
      mdtArt.Columns.Add(new DataColumn("Type", System.Type.GetType("System.String")));
      mdtArt.Columns.Add(new DataColumn("Reference", System.Type.GetType("System.String")));
      mdtArt.Columns.Add(new DataColumn("PCB", System.Type.GetType("System.Int32")));
      mdtArt.Columns.Add(new DataColumn("NBUTIL", System.Type.GetType("System.Int32")));
      mdtArt.Columns.Add(new DataColumn("Prix U", System.Type.GetType("System.Double")));
      mdtArt.Columns.Add(new DataColumn("Quantite", System.Type.GetType("System.Int32")));
      mdtArt.Columns.Add(new DataColumn("Coeff", System.Type.GetType("System.Double")));
      mdtArt.Columns.Add(new DataColumn("Prix T", System.Type.GetType("System.Double")));
      mdtArt.Columns.Add(new DataColumn("Fournisseur", System.Type.GetType("System.String")));
      mdtArt.Columns.Add(new DataColumn("NumArticle", System.Type.GetType("System.Int32")));
      mdtArt.Columns.Add(new DataColumn("NumFour", System.Type.GetType("System.Int32")));
      mdtArt.Columns.Add(new DataColumn("NumSiteFour", System.Type.GetType("System.Int32")));
      mdtArt.Columns.Add(new DataColumn("TypeDePrix", System.Type.GetType("System.String")));
    }

    private void EnregDesArticles()
    {
      try
      {
        Cursor.Current = Cursors.WaitCursor;

        foreach (DataRow row in mdtArt.Rows)
          EnregistreLigne(row);
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

    private void EnregistreLigne(DataRow row)
    {
      Cursor.Current = Cursors.WaitCursor;

      miNumClient = cboClient.GetItemData();

      if (row["TypeDePrix"].ToString() == "C")
      {
        //'prix client (on enregistre le rpix client)
        try
        {
          ModuleData.ExecuteNonQuery($"insert into TSTOCKARTCLI(NCLINUM, NFOUNUM,  NPUHTCLI, CACTIF, NGESTSTOCKCLI)" +
                                     $" Values ({miNumClient},{row["NumArticle"]}, {row["Prix T"].ToString().Replace(",", ".")}" +
                                     $",'{mstrActif}', {(row["Check"].ToString() == "1" ? 1 : 0)})");
        }
        catch (Exception)
        {
          //' si erreur en insert, il faut faire l'update pour prendre le prix
          ModuleData.ExecuteNonQuery($"update TSTOCKARTCLI set NPUHTCLI = {row["Prix T"].ToString().Replace(",", ".")}" +
                                     $", NGESTSTOCKCLI = {(row["Check"].ToString() == "1" ? 1 : 0)}" +
                                     $" WHERE NCLINUM = {miNumClient} AND NFOUNUM={row["NumArticle"]}");
        }
      }
      else
      {
        //' prix de la base
        // ' si on a modifié le prix, c'est que l'on veut mettre un prix client, sinon on enregistre zero
        if (Utils.ZeroIfNull(row["Prix T"]) == (Utils.ZeroIfNull(row["Prix U"]) * Utils.ZeroIfNull(row["Coeff"])))
        {
          try
          {
            ModuleData.ExecuteNonQuery($"insert into TSTOCKARTCLI(NCLINUM, NFOUNUM,  NPUHTCLI, CACTIF, NGESTSTOCKCLI)" +
                                       $"  Values ({miNumClient}, {row["NumArticle"]},0," +
                                       $"'{mstrActif}', {(row["Check"].ToString() == "1" ? 1 : 0)})");
          }
          catch (Exception)
          {
            //' si erreur en insert, il faut faire l'update pour prendre le prix
            ModuleData.ExecuteNonQuery($"update TSTOCKARTCLI set NPUHTCLI = 0" +
                                       $", NGESTSTOCKCLI = {(row["Check"].ToString() == "1" ? 1 : 0)}" +
                                       $" WHERE NCLINUM = {miNumClient} AND NFOUNUM={row["NumArticle"]}");
          }
        }
        else
        {
          try
          {
            ModuleData.ExecuteNonQuery($"insert into TSTOCKARTCLI(NCLINUM, NFOUNUM,  NPUHTCLI, CACTIF, NGESTSTOCKCLI)" +
                                       $"  Values ({miNumClient}, {row["NumArticle"]}, {row["Prix T"].ToString().Replace(",", ".")}" +
                                       $", '{mstrActif}', {(row["Check"].ToString() == "1" ? 1 : 0)})");
          }
          catch (Exception)
          {
            //' si erreur en insert, il faut faire l'update pour prendre le prix
            ModuleData.ExecuteNonQuery($"update TSTOCKARTCLI set NPUHTCLI ={row["Prix T"].ToString().Replace(",", ".")}" +
                                       $", NGESTSTOCKCLI = {(row["Check"].ToString() == "1" ? 1 : 0)}" +
                                       $" WHERE NCLINUM = {miNumClient} AND NFOUNUM={row["NumArticle"]}");
          }
        }
      }

      //' insertion dans la table des stocks site
      try
      {
        ModuleData.ExecuteNonQuery($"insert into TSTOCKARTCLISIT(NCLINUM, NFOUNUM, NSITNUM, NQTESTOK) " +
                                   $" select {miNumClient}, {row["NumArticle"]}, NSITNUM, 0 from TSIT WHERE NCLINUM ={miNumClient}");
      }
      catch (Exception) { }
    }

    private void EnregModificationListe()
    {
      try
      {
        Cursor.Current = Cursors.WaitCursor;
        foreach (DataRow row in mdtArt.Rows)
          EnregistreLigne(row);
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

    private void AjouterEnreg(SqlDataReader reader)
    {
      DataRow row = mdtArt.NewRow();

      row["Check"] = (int)Utils.ZeroIfNull(reader["CHECK"]);
      row["Contrat"] = Utils.BlankIfNull(reader["VCONTRATCLI"]);
      row["Vuewebcli"] = Utils.BlankIfNull(reader["VVUEWEBCLI"]);
      row["Serie"] = Utils.BlankIfNull(reader["VFOUSER"]);
      row["Article"] = Utils.BlankIfNull(reader["VFOUMAT"]);
      row["Marque"] = Utils.BlankIfNull(reader["VFOUMAR"]);
      row["Type"] = Utils.BlankIfNull(reader["VFOUTYP"]);
      row["Reference"] = Utils.BlankIfNull(reader["VFOUREF"]);
      row["PCB"] = (int)Utils.ZeroIfNull(reader["NFOUNBLOT"]);
      row["NBUTIL"] = (int)Utils.ZeroIfNull(reader["NBUTIL"]);
      row["Prix U"] = Utils.ZeroIfNull(reader["FPUHT"]);
      if (Utils.ZeroIfNull(reader["NPUHTCLI"]) == 0)
      {
        row["Coeff"] = Utils.ZeroIfNull(reader["DCCACOE"]);
        row["Prix T"] = ((double)row["Coeff"]) * ((double)row["Prix U"]);
        row["TypeDeprix"] = "B";
      }
      else
      {
        row["Prix T"] = Utils.ZeroIfNull(reader["NPUHTCLI"]);
        if ((double)row["Prix U"] == 0)
        {
          row["Coeff"] = 0;
        }
        else
        {
          row["Coeff"] = Math.Round((double)row["Prix T"] / (double)row["Prix U"], 2);
        }
        row["TypeDeprix"] = "C";
      }
      row["Quantite"] = 0;
      row["NumArticle"] = (int)Utils.ZeroIfNull(reader["NFOUNUM"]);

      mdtArt.Rows.Add(row);
    }

    private void apiTGrid_RowCellClick(object sender, RowCellClickEventArgs e)
    {
      if (e.Column.Name == "Check")
      {
        DataRow row = apiTGrid.GetFocusedDataRow();
        if (null == row || row["CHECK"].ToString() == "1")
          return;

        if (MessageBox.Show($"ATTENTION : En cochant cette case, vous allez déclencher la procédure souhaitée suivante : \r\n" +
                            $" - La fourniture cochée sera gérée en stock sur chaque site de ce client,\r\n" +
                            $" - Lors de l'édition de l'ordre de travail par le technicien, une liste d'inventaire sera émise,\r\n" +
                            $" - Nous demandons au technicien de faire l'inventaire des fournitures en stock sur site, avant son départ du site,\r\n" +
                            $" - Nous saisissons l'inventaire fait par le technicien après chaque préventive,\r\n" +
                            $" - La saisie génère un envoi de réapprovisionnement automatique du stock sur site,\r\n" +
                            $" - Une facture de réapprovisionnement est créée.\r\n" +
                            $"Est-ce bien ce que vous souhaitez faire ?",
                            Program.AppTitle, MessageBoxButtons.YesNo, MessageBoxIcon.Question, MessageBoxDefaultButton.Button2) == DialogResult.Yes)
        {
          row["CHECK"] = 1;
        }
        else
          row["CHECK"] = 0;
      }

      if ((e.Button == MouseButtons.Right) && (e.Column.Name == "Vuewebcli"))
        mnuAffichage.Show(Cursor.Position);
      if ((e.Button == MouseButtons.Right) && (e.Column.Name == "Contrat"))
        mnuContrat.Show(Cursor.Position);

    }

    private void ApiGrid_CellValueChanged(object sender, DevExpress.XtraGrid.Views.Base.CellValueChangedEventArgs e)
    {
      string sSQL = "";

      DataRow row = apiTGrid.GetFocusedDataRow();
      if (null == row) return;

      if (e.Column.Name == "Contrat")
      {
        sSQL = $"update TSTOCKARTCLI set VCONTRATCLI='{e.Value}' WHERE NCLINUM = {miNumClient} AND NFOUNUM={row["NumArticle"]}";
        ModuleData.CnxExecute(sSQL);
      }
      if (e.Column.Name == "Vuewebcli")
      {
        sSQL = $"update TSTOCKARTCLI set VVUEWEBCLI='{e.Value}' WHERE NCLINUM = {miNumClient} AND NFOUNUM={row["NumArticle"]}";
        ModuleData.CnxExecute(sSQL);
      }

    }


    private void CmdCoeffTousCli_Click(object sender, EventArgs e)
    {
      new frmGestionRevisionPrixCFoClients().ShowDialog();
    }

    private void mnuAffecterTous_Click(object sender, EventArgs e)
    {
      DataRow currentRowPri = apiTGrid.GetFocusedDataRow();
      if (apiTGrid.GetFocusedDataRow() == null || currentRowPri == null) return;

      IList<int> lListeIDs = mdtArt.Select(CriteriaToWhereClauseHelper.GetDataSetWhere(apiTGrid.dgv.ActiveFilterCriteria)).ToList().Select(item => Convert.ToInt32(item["NumArticle"])).ToList();
      if (lListeIDs.Count == 0) return;

      string sSQL = $"UPDATE TSTOCKARTCLI SET VVUEWEBCLI='OUI' WHERE NCLINUM = {miNumClient} AND NFOUNUM IN ({string.Join(",", lListeIDs)})";
      ModuleData.CnxExecute(sSQL);

      // Utilisation de LINQ pour mettre à jour les données locales
      var rowsToUpdate = from row in mdtArt.AsEnumerable()
                         where lListeIDs.Contains(row.Field<int>("NumArticle"))
                         select row;

      foreach (DataRow row in rowsToUpdate)
      {
        // Mettre à jour la valeur de la colonne pour les lignes sélectionnées
        row["Vuewebcli"] = "OUI";
      }

    }

    private void mnuDesaffecter_Click(object sender, EventArgs e)
    {
      DataRow currentRowPri = apiTGrid.GetFocusedDataRow();
      if (apiTGrid.GetFocusedDataRow() == null || currentRowPri == null) return;

      IList<int> lListeIDs = mdtArt.Select(CriteriaToWhereClauseHelper.GetDataSetWhere(apiTGrid.dgv.ActiveFilterCriteria)).ToList().Select(item => Convert.ToInt32(item["NumArticle"])).ToList();
      if (lListeIDs.Count == 0) return;

      string sSQL = $"UPDATE TSTOCKARTCLI SET VVUEWEBCLI='NON' WHERE NCLINUM = {miNumClient} AND NFOUNUM IN ({string.Join(",", lListeIDs)})";
      ModuleData.CnxExecute(sSQL);

      // Utilisation de LINQ pour mettre à jour les données locales
      var rowsToUpdate = from row in mdtArt.AsEnumerable()
                         where lListeIDs.Contains(row.Field<int>("NumArticle"))
                         select row;

      foreach (DataRow row in rowsToUpdate)
      {
        // Mettre à jour la valeur de la colonne pour les lignes sélectionnées
        row["Vuewebcli"] = "NON";
      }

    }


    private void mnuAffecterContrat_Click(object sender, EventArgs e)
    {
      DataRow currentRowPri = apiTGrid.GetFocusedDataRow();
      if (apiTGrid.GetFocusedDataRow() == null || currentRowPri == null) return;

      IList<int> lListeIDs = mdtArt.Select(CriteriaToWhereClauseHelper.GetDataSetWhere(apiTGrid.dgv.ActiveFilterCriteria)).ToList().Select(item => Convert.ToInt32(item["NumArticle"])).ToList();
      if (lListeIDs.Count == 0) return;

      string sSQL = $"UPDATE TSTOCKARTCLI SET VCONTRATCLI='OUI' WHERE NCLINUM = {miNumClient} AND NFOUNUM IN ({string.Join(",", lListeIDs)})";
      ModuleData.CnxExecute(sSQL);

      // Utilisation de LINQ pour mettre à jour les données locales
      var rowsToUpdate = from row in mdtArt.AsEnumerable()
                         where lListeIDs.Contains(row.Field<int>("NumArticle"))
                         select row;

      foreach (DataRow row in rowsToUpdate)
      {
        // Mettre à jour la valeur de la colonne pour les lignes sélectionnées
        row["Contrat"] = "OUI";
      }

    }

    private void mnuDesaffecterContrat_Click(object sender, EventArgs e)
    {
      DataRow currentRowPri = apiTGrid.GetFocusedDataRow();
      if (apiTGrid.GetFocusedDataRow() == null || currentRowPri == null) return;

      IList<int> lListeIDs = mdtArt.Select(CriteriaToWhereClauseHelper.GetDataSetWhere(apiTGrid.dgv.ActiveFilterCriteria)).ToList().Select(item => Convert.ToInt32(item["NumArticle"])).ToList();
      if (lListeIDs.Count == 0) return;

      string sSQL = $"UPDATE TSTOCKARTCLI SET VCONTRATCLI='NON' WHERE NCLINUM = {miNumClient} AND NFOUNUM IN ({string.Join(",", lListeIDs)})";
      ModuleData.CnxExecute(sSQL);

      // Utilisation de LINQ pour mettre à jour les données locales
      var rowsToUpdate = from row in mdtArt.AsEnumerable()
                         where lListeIDs.Contains(row.Field<int>("NumArticle"))
                         select row;

      foreach (DataRow row in rowsToUpdate)
      {
        // Mettre à jour la valeur de la colonne pour les lignes sélectionnées
        row["Contrat"] = "NON";
      }

    }

    private void cmdFermer_Click(object sender, System.EventArgs e)
    {
      Close();
    }

  }
}

