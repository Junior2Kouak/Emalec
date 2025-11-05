using DevExpress.Data.Filtering;
using DevExpress.XtraEditors.Controls;
using DevExpress.XtraEditors.Repository;
using DevExpress.XtraGrid.Columns;
using DevExpress.XtraGrid.Views.Base;
using DevExpress.XtraGrid.Views.Grid;
using DevExpress.XtraRichEdit.Export.Mht;
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
using MZCtrlResources = MozartControls.Properties.Resources;
using MZUtils = MozartControls.Utils;

namespace MozartCS
{
  public partial class frmStockArticleClientExtincteurs : Form
  {
    //' feuille ouverte en création ou modification
    private string mstrStatut;
    private int miNumClient;

    private bool mbDroitPrix0;

    private DataTable mdtArticles;

    public frmStockArticleClientExtincteurs(int piNumClient, string pstrStatut)
    {
      InitializeComponent();

      miNumClient = piNumClient;
      mstrStatut = pstrStatut;
    }

    private void frmStockArticleClientExtincteurs_Load(object sender, EventArgs e)
    {
      try
      {
        Cursor.Current = Cursors.WaitCursor;
        ModuleMain.Initboutons(this);

        mnuAffecterTous.Text = "Affecter à tous";
        mnuDesaffecter.Text = "Désaffecter à tous";
        mnuAffecterContrat.Text = "Affecter à tous";
        mnuDesaffecterContrat.Text = "Désaffecter à tous";

        //'droit permettant de saisir des tarifs à 0
        mbDroitPrix0 = ModuleMain.RechercheDroitMenu(418);

        //' initialisation de la feuille
        if (mstrStatut == "C")
          OuvertureEnCreation();
        else
          OuvertureEnModification();

        FormatGridT();

        apiTGrid.dgv.ValidatingEditor += new BaseContainerValidateEditorEventHandler(apiTGrid_ValidatingEditor);
        apiTGrid.dgv.InvalidValueException += new InvalidValueExceptionEventHandler(apiTGrid_InvalidValueException);
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
      //  ' enregistrement avec le recordset local
      try
      {
        Cursor.Current = Cursors.WaitCursor;

        if (apiTGrid.dgv.ActiveFilterString.ToString() != "")
        {
          MessageBox.Show("Pour enregistrer, il faut effacer les filtres de recherche !", Program.AppTitle, MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
          return;
        }

        if (mstrStatut == "C")
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

    private void cmdSupp_Click(object sender, EventArgs e)
    {
      try
      {
        Cursor.Current = Cursors.WaitCursor;

        DataRow row = apiTGrid.GetFocusedDataRow();
        if (null == row)
          return;

        if (MessageBox.Show(Resources.msg_confirm_supp_article, Program.AppTitle, MessageBoxButtons.YesNo,
                            MessageBoxIcon.Question, MessageBoxDefaultButton.Button2) == DialogResult.No)
          return;

        string sLstDevis = "";
        using (SqlDataReader reader = ModuleData.ExecuteReader($"exec api_sp_VerifFOUExistInDCLEI {row["NumArticle"]} , {miNumClient}"))
        {
          while (reader.Read())
          {
            sLstDevis += $"\r\n{reader["NDCLNUM"]}";
          }
        }
        if (sLstDevis != "")
        {
          MessageBox.Show($"La suppression de cet article est impossible car il est utilisé dans le(s) devis suivant: {sLstDevis}", "",
                          MessageBoxButtons.OK, MessageBoxIcon.Information);
          return;
        }

        //' suppression dans la table des stocks client
        ModuleData.ExecuteNonQuery($"delete from TSTOCKARTCLI WHERE NCLINUM ={miNumClient} AND NFOUNUM = {row["NumArticle"]}");

        //' suppression de la ligne courante
        mdtArticles.Rows.Remove(row);

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

    private void cmdP1_Click(object sender, EventArgs e)
    {
      updateArticleEI(cmdP1.Text, 1);
    }

    private void cmdP2_Click(object sender, EventArgs e)
    {
      updateArticleEI(cmdP2.Text, 2);
    }

    private void cmdP3_Click(object sender, EventArgs e)
    {
      updateArticleEI(cmdP3.Text, 3);
    }

    private void updateArticleEI(string pButtonText, int nType)
    {
      if (mdtArticles.Rows.Count > 0)
      {
        if (MessageBox.Show("Attention, vous allez mettre à jour les données présentes, êtes-vous sûr ?", "",
                            MessageBoxButtons.YesNo, MessageBoxIcon.Question, MessageBoxDefaultButton.Button2) == DialogResult.No)
          return;
      }
      try
      {
        Cursor.Current = Cursors.WaitCursor;

        ModuleData.ExecuteNonQuery($"exec [api_sp_creationBordereauPVExtincteur] {nType},{ miNumClient}");

        MozartUcUtils.SpyLog(MozartDatabase.cnxMozart, Text, pButtonText, "UPDATE", $"NCLINUM:{miNumClient}");

        OuvertureEnModification();
        cmdValider_Click(null, null);
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

    private void cmdSaisieCoeff_Click(object sender, EventArgs e)
    {
            GridView GV = apiTGrid.GridControl.MainView as GridView;
            List<int> rowListSelected = new List<int>();
            for (int i = 0; i < GV.DataRowCount; i++)
                rowListSelected.Add((int)GV.GetDataRow(i)["NumArticle"]);

            new frmSaisieCoefPrix()
      {
        miNumClient = miNumClient,
        mbListeFournitureEI = true,
                listFournitureToRevise = rowListSelected,
                iNbFoTotalPrixCli = mdtArticles.Rows.Count
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
        mdtArticles = mdtArticles
      }.ShowDialog();
    }

    private void OuvertureEnCreation()
    {
      //  ' ouverture du recordset local pour la liste des articles
      InitRecordsetArticle();
      cmdRechercher.Text = Resources.msg_ajout_articles;
    }

    private void OuvertureEnModification()
    {
      //  ' initialisation du recordset local des articles
      InitRecordsetArticle();

      //' recherche des détails fournitures
      using (SqlDataReader reader = ModuleData.ExecuteReader($"select * from api_v_listeArticlesClient where NCLINUM = {miNumClient} AND NCFOCOD = 31 ORDER BY VFOUMAT"))
      {
        //' passage des infos du recordset
        while (reader.Read())
        {
          AjouterEnreg(reader);
        }
      }

      if (mdtArticles != null) { apiTGrid.GridControl.DataSource = mdtArticles; }

      cmdRechercher.Text = Resources.msg_Modifier_liste;
    }

    private void FormatGridT()
    {
      // TODO Resources "Prix Achat" pas de traduction
      apiTGrid.AddColumn(Resources.col_Contrat, "Contrat", 900, "", 2);
      apiTGrid.AddColumn("Affichage web", "Vuewebcli", 900, "", 2);
      apiTGrid.AddColumn(Resources.col_materiel, "Article", 4300, "", 0, true);
      apiTGrid.AddColumn(Resources.col_marque, "Marque", 1300, "", 0, true);
      apiTGrid.AddColumn(MZCtrlResources.col_Type, "Type", 1500, "", 0, true);
      apiTGrid.AddColumn(Resources.col_reference, "Reference", 1300, "", 0, true);
      apiTGrid.AddColumn(Resources.col_pcb, "PCB", 850, "", 2);
      apiTGrid.AddColumn(Resources.col_Conso, "NBUTIL", 800);
      apiTGrid.AddColumn("Prix Achat", "Prix U", 800, "## ##0.00", 1);
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

      apiTGrid.GridControl.DataSource = mdtArticles;

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
          e.Appearance.ForeColor = Color.Red;
        }
        else
        {
          e.Appearance.ForeColor = Color.White;
        }

        e.Appearance.BackColor = MozartColors.colorHCCCCCC;
        e.Appearance.Font = new Font(e.Appearance.Font, FontStyle.Bold);
      }
    }

    private void InitRecordsetArticle()
    {
      mdtArticles = new DataTable();

      mdtArticles.Columns.Add(new DataColumn("Check", Type.GetType("System.Int32")));
      mdtArticles.Columns.Add(new DataColumn("Contrat", System.Type.GetType("System.String")));
      mdtArticles.Columns.Add(new DataColumn("Vuewebcli", System.Type.GetType("System.String")));
      mdtArticles.Columns.Add(new DataColumn("Serie", Type.GetType("System.String")));
      mdtArticles.Columns.Add(new DataColumn("Article", Type.GetType("System.String")));
      mdtArticles.Columns.Add(new DataColumn("Marque", Type.GetType("System.String")));
      mdtArticles.Columns.Add(new DataColumn("Type", Type.GetType("System.String")));
      mdtArticles.Columns.Add(new DataColumn("Reference", Type.GetType("System.String")));
      mdtArticles.Columns.Add(new DataColumn("PCB", Type.GetType("System.Int32")));
      mdtArticles.Columns.Add(new DataColumn("NBUTIL", Type.GetType("System.Int32")));
      mdtArticles.Columns.Add(new DataColumn("Prix U", Type.GetType("System.Double")));
      mdtArticles.Columns.Add(new DataColumn("Quantite", Type.GetType("System.Int32")));
      mdtArticles.Columns.Add(new DataColumn("Coeff", Type.GetType("System.Double")));
      mdtArticles.Columns.Add(new DataColumn("Prix T", Type.GetType("System.Double")));
      mdtArticles.Columns.Add(new DataColumn("Fournisseur", Type.GetType("System.String")));
      mdtArticles.Columns.Add(new DataColumn("NumArticle", Type.GetType("System.Int32")));
      mdtArticles.Columns.Add(new DataColumn("NumFour", Type.GetType("System.Int32")));
      mdtArticles.Columns.Add(new DataColumn("NumSiteFour", Type.GetType("System.Int32")));
      mdtArticles.Columns.Add(new DataColumn("TypeDePrix", Type.GetType("System.String")));
    }

    private void EnregDesArticles()
    {
      try
      {
        Cursor.Current = Cursors.WaitCursor;

        foreach (DataRow row in mdtArticles.Rows)
        {
          EnregistrerLigne(row);
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

    private void EnregistrerLigne(DataRow row)
    {
      try
      {
        Cursor.Current = Cursors.WaitCursor;

        if (row["TypeDePrix"].ToString() == "C")
        {
          //'prix client (on enregistre le prix client)
          try
          {
            ModuleData.ExecuteNonQuery($"insert into TSTOCKARTCLI(NCLINUM, NFOUNUM,  NPUHTCLI, CACTIF, NGESTSTOCKCLI) " +
                                       $" Values ({miNumClient}, {row["NumArticle"]}," +
                                       $" {row["Prix T"].ToString().Replace(",", ".")}, '', 0)");
          }
          catch (Exception)
          {
            //' si erreur en insert, il faut faire l'update pour prendre le prix
            ModuleData.ExecuteNonQuery($"update TSTOCKARTCLI set NPUHTCLI = {row["Prix T"].ToString().Replace(",", ".")}" +
                                       $", NGESTSTOCKCLI = 0 WHERE NCLINUM ={miNumClient} AND NFOUNUM= {row["NumArticle"]}");
          }
        }
        else
        {
          //' prix de la base
          //' si on a modifié le prix, c'est que l'on veut mettre un prix client, sinon on enregistre zero
          if (Utils.ZeroIfNull(row["Prix T"]) == (Utils.ZeroIfNull(row["Prix U"]) * Utils.ZeroIfNull(row["Coeff"])))
          {
            try
            {
              ModuleData.ExecuteNonQuery($"insert into TSTOCKARTCLI(NCLINUM, NFOUNUM,  NPUHTCLI, CACTIF, NGESTSTOCKCLI) " +
                                         $" Values ({miNumClient}, {row["NumArticle"]},0,'', 0)");
            }
            catch (Exception)
            {
              //' si erreur en insert, il faut faire l'update pour prendre le prix
              ModuleData.ExecuteNonQuery($"update TSTOCKARTCLI set NPUHTCLI = 0, NGESTSTOCKCLI = 0" +
                                         $" WHERE NCLINUM = {miNumClient} AND NFOUNUM={row["NumArticle"]}");
            }
          }
          else
          {
            try
            {
              ModuleData.ExecuteNonQuery($"insert into TSTOCKARTCLI(NCLINUM, NFOUNUM,  NPUHTCLI, CACTIF, NGESTSTOCKCLI) " +
                                         $" Values ({miNumClient}, {row["NumArticle"]},{row["Prix T"].ToString().Replace(",", ".")}, '', 0)");

            }
            catch (Exception)
            {
              //' si erreur en insert, il faut faire l'update pour prendre le prix
              ModuleData.ExecuteNonQuery($"update TSTOCKARTCLI set NPUHTCLI = {row["Prix T"].ToString().Replace(",", ".")}, NGESTSTOCKCLI = 0" +
                                         $" WHERE NCLINUM = {miNumClient} AND NFOUNUM= {row["NumArticle"]}");
            }
          }
        }

        try
        {
          //' insertion dans la table des stocks site
          ModuleData.ExecuteNonQuery($"insert into TSTOCKARTCLISIT(NCLINUM, NFOUNUM, NSITNUM, NQTESTOK) " +
                                     $"select {miNumClient}, {row["NumArticle"]}, NSITNUM, 0 from TSIT WHERE NCLINUM = {miNumClient}");
        }
        catch (Exception) { }
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

    private void EnregModificationListe()
    {
      int iNbVacation = 0, iNbAttestation = 0, iNbAttestationQ4 = 0;

      //'parcours du recordset et création des lignes articles
      foreach (DataRow row in mdtArticles.Rows)
      {
        //  'recherche si prix client est inferieur au prix conseille de la FO
        //'parcours du recordset et création des lignes articles
        if (Utils.BlankIfNull(row["Prix T"]) != "" &&
            !Utils.Is_OK_PrixMiniFourniture((long)Utils.ZeroIfNull(row["NumArticle"]), Utils.ZeroIfNull(row["Prix T"]), Utils.BlankIfNull(row["Article"])))
        {
          if (!ModuleMain.RechercheDroitMenu(545))
          {
            return;
          }
          //' on passe et on peut faire la modification
        }

        using (SqlDataReader reader = ModuleData.ExecuteReader($"SELECT ISNULL(NSSCFONUM,0) NSSCFONUM FROM TFOU WITH (NOLOCK) WHERE NFOUNUM = {row["NumArticle"]}"))
        {
          reader.Read();
          //' on ne doit enregistrer qu'un seul article de la ss serie VACATION(10) et ATTESTATION(4)
          int NSSCFONUM = (int)Utils.ZeroIfNull(reader["NSSCFONUM"]);
          switch (NSSCFONUM)
          {
            case 4:
              iNbAttestation += 1; break;
            case 10:
              iNbVacation += 1; break;
            case 63:
              iNbAttestationQ4 += 1; break;
          }
        }
      }

      if (iNbAttestation != 1 || iNbVacation != 1 || iNbAttestationQ4 != 1)
      {
        MessageBox.Show("Vous devez avoir obligatoirement 1 Vacation, 1 Attestation et 1 Attestation avec Q4 par client!", "",
                        MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
        return;
      }

      //'parcours du recordset et création des lignes articles
      foreach (DataRow row in mdtArticles.Rows)
      {
        EnregistrerLigne(row);
      }
    }

    private void AjouterEnreg(SqlDataReader reader)
    {
      DataRow r = mdtArticles.NewRow();
      r["Check"] = 0;
      r["Contrat"] = Utils.BlankIfNull(reader["VCONTRATCLI"]);
      r["Vuewebcli"] = Utils.BlankIfNull(reader["VVUEWEBCLI"]);
      r["Serie"] = Utils.BlankIfNull(reader["VFOUSER"]);
      r["Article"] = Utils.BlankIfNull(reader["VFOUMAT"]);
      r["Marque"] = Utils.BlankIfNull(reader["VFOUMAR"]);
      r["Type"] = Utils.BlankIfNull(reader["VFOUTYP"]);
      r["Reference"] = Utils.BlankIfNull(reader["VFOUREF"]);
      r["PCB"] = (int)Utils.ZeroIfNull(reader["NFOUNBLOT"]);
      r["NBUTIL"] = Utils.ZeroIfNull(reader["NBUTIL"]);
      r["Prix U"] = Utils.ZeroIfNull(reader["FPUHT"]);
      if (Utils.ZeroIfNull(reader["NPUHTCLI"]) == 0)
      {
        r["Coeff"] = Utils.ZeroIfNull(reader["DCCACOE"]);
        r["Prix T"] = (double)r["Coeff"] * (double)r["Prix U"];
        r["TypeDeprix"] = "B";
      }
      else
      {
        r["Prix T"] = Utils.ZeroIfNull(reader["NPUHTCLI"]);
        if (Utils.ZeroIfNull(r["Prix U"]) == 0)
          r["Coeff"] = 0;
        else
          r["Coeff"] = Math.Round((double)r["Prix T"] / (double)r["Prix U"], 2);
        r["TypeDeprix"] = "C";
      }
      r["Quantite"] = 1;
      r["NumArticle"] = (int)Utils.ZeroIfNull(reader["NFOUNUM"]);

      mdtArticles.Rows.Add(r);
    }

    private void cmdImport_Click(object sender, EventArgs e)
    {
      updateArticleEI(cmdImport.Text, 0);
    }

    private void cmdSuppTout_Click(object sender, EventArgs e)
    {
      // TODO
      try
      {
        if (mdtArticles.Rows.Count > 0)
        {
          if (MessageBox.Show(Resources.msg_supprimer_tous_articles_EI_EXTINCTEURS, "",
                              MessageBoxButtons.YesNo, MessageBoxIcon.Question, MessageBoxDefaultButton.Button2) == DialogResult.No)
          {
            return;
          }
          using (SqlDataReader reader = ModuleData.ExecuteReader($"exec api_sp_VerifFOUExistInDCLEI 0, {miNumClient}"))
          {
            string sLstDevis = "";
            while (reader.Read())
            {
              sLstDevis += $"Devis N° { (int)Utils.ZeroIfNull(reader["NDCLNUM"])} : {Utils.BlankIfNull(reader["VFOUMAT"])}\r\n";
            }
            if (sLstDevis != "")
            {
              MessageBox.Show($"La suppression de tous les articles est impossible car il y a des articles utilisés dans le(s) devis suivant :\r\n{sLstDevis}", "",
                              MessageBoxButtons.OK, MessageBoxIcon.Information);
              return;
            }
          }
          // ' suppression dans la table des stock client
          ModuleData.ExecuteNonQuery($"DELETE TSTOCKARTCLI  FROM TSTOCKARTCLI inner join TFOU ON TSTOCKARTCLI.NFOUNUM = TFOU.NFOUNUM " +
                                     $"WHERE TFOU.NCFOCOD = 31 AND TSTOCKARTCLI.NCLINUM = {miNumClient}");
        }
      }
      catch (Exception ex)
      {
        MZUtils.displayError(MethodBase.GetCurrentMethod().Name, ex);
      }

      OuvertureEnModification();

    }

    private void apiTGrid_ValidatingEditor(object sender, BaseContainerValidateEditorEventArgs e)
    {
      ColumnView view = sender as ColumnView;
      GridColumn column = (e as EditFormValidateEditorEventArgs)?.Column ?? view.FocusedColumn;
      if (column.Name != "Prix T") return;

      DataRow row = apiTGrid.GetFocusedDataRow();

      if (Utils.ZeroIfNull(row["Prix T"]) != 0 && Utils.ZeroIfNull(e.Value) == 0 && !mbDroitPrix0)
      {
        MessageBox.Show("Vous n'avez pas les droits pour enregistrer un prix de vente à 0 !", "",
                        MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
        e.Valid = false;
      }
    }

    private void apiTGrid_InvalidValueException(object sender, InvalidValueExceptionEventArgs e)
    {
      ColumnView view = sender as ColumnView;
      if (view == null) return;
      e.ExceptionMode = ExceptionMode.Ignore;
      view.HideEditor();
    }


    private void apiTGrid_RowCellClick(object sender, RowCellClickEventArgs e)
    {

      if ((e.Button == MouseButtons.Right) && (e.Column.Name == "Vuewebcli"))
        mnuAffichageWeb.Show(Cursor.Position);

      if ((e.Button == MouseButtons.Right) && (e.Column.Name == "Contrat"))
        mnuContrat.Show(Cursor.Position);
    }

    private void apiTGrid_CellValueChanged(object sender, DevExpress.XtraGrid.Views.Base.CellValueChangedEventArgs e)
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

    private void mnuAffecterTous_Click(object sender, EventArgs e)
    {
      DataRow currentRowPri = apiTGrid.GetFocusedDataRow();
      if (apiTGrid.GetFocusedDataRow() == null || currentRowPri == null) return;

      IList<int> lListeIDs = mdtArticles.Select(CriteriaToWhereClauseHelper.GetDataSetWhere(apiTGrid.dgv.ActiveFilterCriteria)).ToList().Select(item => Convert.ToInt32(item["NumArticle"])).ToList();
      if (lListeIDs.Count == 0) return;

      string sSQL = $"UPDATE TSTOCKARTCLI SET VVUEWEBCLI='OUI' WHERE NCLINUM = {miNumClient} AND NFOUNUM IN ({string.Join(",", lListeIDs)})";
      ModuleData.CnxExecute(sSQL);

      // Utilisation de LINQ pour mettre à jour les données locales
      var rowsToUpdate = from row in mdtArticles.AsEnumerable()
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

      IList<int> lListeIDs = mdtArticles.Select(CriteriaToWhereClauseHelper.GetDataSetWhere(apiTGrid.dgv.ActiveFilterCriteria)).ToList().Select(item => Convert.ToInt32(item["NumArticle"])).ToList();
      if (lListeIDs.Count == 0) return;

      string sSQL = $"UPDATE TSTOCKARTCLI SET VVUEWEBCLI='NON' WHERE NCLINUM = {miNumClient} AND NFOUNUM IN ({string.Join(",", lListeIDs)})";
      ModuleData.CnxExecute(sSQL);

      // Utilisation de LINQ pour mettre à jour les données locales
      var rowsToUpdate = from row in mdtArticles.AsEnumerable()
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

      IList<int> lListeIDs = mdtArticles.Select(CriteriaToWhereClauseHelper.GetDataSetWhere(apiTGrid.dgv.ActiveFilterCriteria)).ToList().Select(item => Convert.ToInt32(item["NumArticle"])).ToList();
      if (lListeIDs.Count == 0) return;

      string sSQL = $"UPDATE TSTOCKARTCLI SET VCONTRATCLI='OUI' WHERE NCLINUM = {miNumClient} AND NFOUNUM IN ({string.Join(",", lListeIDs)})";
      ModuleData.CnxExecute(sSQL);

      // Utilisation de LINQ pour mettre à jour les données locales
      var rowsToUpdate = from row in mdtArticles.AsEnumerable()
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

      IList<int> lListeIDs = mdtArticles.Select(CriteriaToWhereClauseHelper.GetDataSetWhere(apiTGrid.dgv.ActiveFilterCriteria)).ToList().Select(item => Convert.ToInt32(item["NumArticle"])).ToList();
      if (lListeIDs.Count == 0) return;

      string sSQL = $"UPDATE TSTOCKARTCLI SET VCONTRATCLI='NON' WHERE NCLINUM = {miNumClient} AND NFOUNUM IN ({string.Join(",", lListeIDs)})";
      ModuleData.CnxExecute(sSQL);

      // Utilisation de LINQ pour mettre à jour les données locales
      var rowsToUpdate = from row in mdtArticles.AsEnumerable()
                         where lListeIDs.Contains(row.Field<int>("NumArticle"))
                         select row;

      foreach (DataRow row in rowsToUpdate)
      {
        // Mettre à jour la valeur de la colonne pour les lignes sélectionnées
        row["Contrat"] = "NON";
      }

    }

    private void cmdFermer_Click(object sender, EventArgs e)
    {
      Close();
    }
  }
}


