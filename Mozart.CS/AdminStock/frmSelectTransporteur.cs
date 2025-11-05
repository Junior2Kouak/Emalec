using DevExpress.XtraGrid.Views.Grid;
using MozartCS.Properties;
using MozartLib;
using MozartNet;
using System;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Reflection;
using System.Windows.Forms;
using MZUtils = MozartControls.Utils;


namespace MozartCS
{
  public partial class frmSelectTransporteur : Form
  {
    public int miNumFournisseur;
    public string mstrClient;
    public int miNumClient;
    public int mNumAction;
    public string mTypeLivr;

    private DataTable dtRS;
    private DataTable mdtArticles;

    public frmSelectTransporteur()
    {
      InitializeComponent();
    }

    private void frmSelectTransporteur_Load(object sender, System.EventArgs e)
    {
      try
      {
        string lSql;

        Cursor.Current = Cursors.WaitCursor;

        ModuleMain.Initboutons(this);

        initDtArticles();

        dtRS = new DataTable();
        apiTGrid1.GridControl.DataSource = dtRS;
        InitApiTgrid();
        lSql = $"exec api_sp_ListeDesFournituresCmd {miNumFournisseur}, 0, 'T$', 'T$', 'T$', 'T$', 'T$', 'T$'";
        apiTGrid1.LoadData(dtRS, MozartDatabase.cnxMozart, lSql);

        lSql = $"SELECT VSTFGRPNOM + ' - ' + COALESCE(VSTFGRPVIL, '') [VSTFGRPNOM]";
        lSql += $" FROM TSTFGRP WHERE  CSTFGRPACTIF = 'O' AND (CSTFTYP = 'FO' OR CSTFTYP = 'FT') AND NSTFGRPNUM = {miNumFournisseur}";
        txtCritFour.Text = ModuleData.ExecuteScalarString(lSql);

        FormatGridArticle();
        grdDataGrid2.GridControl.DataSource = mdtArticles;
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

    private void initDtArticles()
    {
      mdtArticles = new DataTable();
      // ajout des champs 
      mdtArticles.Columns.Add("Serie", typeof(string));
      mdtArticles.Columns.Add("Article", typeof(string));
      mdtArticles.Columns.Add("Marque", typeof(string));
      mdtArticles.Columns.Add("Type", typeof(string));
      mdtArticles.Columns.Add("Reference", typeof(string));
      mdtArticles.Columns.Add("PCB", typeof(int));
      mdtArticles.Columns.Add("Prix U", typeof(double));
      mdtArticles.Columns.Add("Quantite", typeof(long));
      mdtArticles.Columns.Add("Prix T", typeof(double));
      mdtArticles.Columns.Add("Fournisseur", typeof(string));
      mdtArticles.Columns.Add("NumArticle", typeof(int));
      mdtArticles.Columns.Add("NumFour", typeof(int));
      mdtArticles.Columns.Add("NumSiteFour", typeof(int));
    }
    private void FormatGridArticle()
    {
      grdDataGrid2.AddColumn(Resources.col_série, "Serie", 1500);
      grdDataGrid2.AddColumn(Resources.col_materiel, "Article", 4300);
      grdDataGrid2.AddColumn(Resources.col_marque, "Marque", 1500, "", 0, true);
      grdDataGrid2.AddColumn(Resources.col_Type, "Type", 1500, "", 0, true);
      grdDataGrid2.AddColumn(Resources.col_reference, "Reference", 1500, "", 0, true);
      grdDataGrid2.AddColumn(Resources.col_pcb, "PCB", 850, "", 2);
      grdDataGrid2.AddColumn(Resources.col_Prix, "Prix U", 800, "## ##0.00", 1);
      grdDataGrid2.AddColumn(Resources.col_Qte, "Quantite", 1000, "", 2);
      grdDataGrid2.AddColumn(Resources.col_Prix_Client, "Prix T", 1000, "## ##0.00", 1);
      grdDataGrid2.AddColumn(Resources.col_four, "Four", 0);
      grdDataGrid2.AddColumn(Resources.col_NumFourn, "NumFour", 0);
      grdDataGrid2.AddColumn(Resources.col_NumArticle, "NumArticle", 0);
      grdDataGrid2.AddColumn(Resources.col_NumSiteFour, "NumSiteFour", 0);

      //'locked des cellules sauf la quantité
      grdDataGrid2.DelockColumn("Quantite");

      grdDataGrid2.InitColumnList();
    }

    private void cmdFermer_Click(object sender, System.EventArgs e)
    {
      Close();
    }

    private void cmdValider_Click(object sender, EventArgs e)
    {
      try
      {
        if (mdtArticles.Rows.Count == 0)
        {
          MessageBox.Show("Vous devez sélectionner au moins une fourniture", Program.AppTitle, MessageBoxButtons.OK, MessageBoxIcon.Exclamation);

          return;
        }

        CreationDesCommandes();

        Dispose();
      }
      catch (Exception ex)
      {
        MZUtils.displayError(MethodBase.GetCurrentMethod().Name, ex);
      }
    }

    private void CreationDesCommandes()
    {
      mdtArticles.DefaultView.Sort = "NumFour";

      int miNumCom = 0;
      //parcours de la table et gestion des ruptures
      foreach (DataRow row in mdtArticles.Rows)
      {
        //création d'une nouvelle commande
        EnregCommande(ref miNumCom, row);
      }

      //  traitement de la derniere commande (si plusieurs) ou de la premiere commande (si une seule)
      //  mise a jour dans l'obs de TACT
      ModuleData.CnxExecute($"api_sp_UpdateActionCom {miNumCom}, 'N',''");

      MessageBox.Show($"La commande CF{miNumCom} a été créée", Program.AppTitle, MessageBoxButtons.OK, MessageBoxIcon.Information);
    }

    private void getInfos(ref string pAdr1, ref string pAdr2, ref string pCP, ref string pVille, ref string pAttention, ref string pLieuLivr)
    {
      switch (mTypeLivr)
      {
        case "E":
          using (SqlDataReader sdr2 = ModuleData.ExecuteReader($"api_sp_getInfosSociete {mNumAction}"))
          {
            if (sdr2.Read())
            {
              pAdr1 = Utils.BlankIfNull(sdr2["VSITAD1"]);
              pAdr2 = Utils.BlankIfNull(sdr2["VSITAD2"]);
              pCP = Utils.BlankIfNull(sdr2["VSITCP"]);
              pVille = Utils.BlankIfNull(sdr2["VSITVIL"]);

              pAttention = Utils.BlankIfNull(sdr2["VPERNOM"]);
              pLieuLivr = MozartParams.GetNomSociete();
            }
          }
          break;

        case "S":
          using (SqlDataReader sdr2 = ModuleData.ExecuteReader($"api_sp_getSITE {mNumAction}"))
          {
            if (sdr2.Read())
            {
              pAdr1 = Utils.BlankIfNull(sdr2["VSITAD1"]);
              pAdr2 = Utils.BlankIfNull(sdr2["VSITAD2"]);
              pCP = Utils.BlankIfNull(sdr2["VSITCP"]);
              pVille = Utils.BlankIfNull(sdr2["VSITVIL"]);

              pAttention = "Technicien " + MozartParams.GetNomSociete();
              pLieuLivr = Utils.BlankIfNull(sdr2["VSITNOM"]);
            }
          }
          break;

        case "T":
          using (SqlDataReader sdr2 = ModuleData.ExecuteReader($"api_sp_getTECH {mNumAction}, 0"))
          {
            if (sdr2.Read())
            {
              pAdr1 = Utils.BlankIfNull(sdr2["VPERAD1"]);
              pAdr2 = Utils.BlankIfNull(sdr2["VPERAD2"]);
              pCP = Utils.BlankIfNull(sdr2["VPERCP"]);
              pVille = Utils.BlankIfNull(sdr2["VPERVIL"]);

              pAttention = Utils.BlankIfNull(sdr2["VPERNOM"]);
              pLieuLivr = Utils.BlankIfNull(sdr2["VPERNOM"]);
            }
            else
            {
              // si pas de tech sur l'action, erreur
              MessageBox.Show(Resources.msg_erreurPasTechnicienAction, Program.AppTitle, MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
          }
          break;

        default:
          break;
      }
    }

    public void EnregCommande(ref int numCom, DataRow row)
    {
      string lAdr1 = "";
      string lAdr2 = "";
      string lCP = "";
      string lVille = "";
      string lAttention = "";
      string lLieuLivr = "";
      string lDateLivr;
      int nbJrsOuvres;

      getInfos(ref lAdr1, ref lAdr2, ref lCP, ref lVille, ref lAttention, ref lLieuLivr);

      // TNT : 1 jour ouvré
      // Autres (Pour l'instant DPD et Schenker) : 2 jours ouvrés
      nbJrsOuvres = (miNumFournisseur == 5352) ? 1 : 2;
      lDateLivr = ModuleData.ExecuteScalarString($"select dbo.ReturnDateAddJoursOuvre(getdate(),{nbJrsOuvres})");

      using (SqlCommand cmd = new SqlCommand("api_sp_CreationCommande", MozartDatabase.cnxMozart))
      {
        cmd.CommandType = CommandType.StoredProcedure;
        SqlCommandBuilder.DeriveParameters(cmd);    // liste des paramètres

        //  liste des paramètres
        cmd.Parameters["@iNumCommande"].Value = numCom;
        cmd.Parameters["@iNumFour"].Value = (int)Utils.ZeroIfNull(row["NumSiteFour"]);
        cmd.Parameters["@iAction"].Value = mNumAction;
        cmd.Parameters["@nPrixHT"].Value = 0; // n'est pas utilisé dans la proc stock
        cmd.Parameters["@nPrixTVA"].Value = 0; // n'est pas utilisé dans la proc stock

        cmd.Parameters["@dDateLiv"].Value = lDateLivr;

        cmd.Parameters["@typeL"].Value = mTypeLivr;
        cmd.Parameters["@vRmq"].Value = "";

        cmd.Parameters["@adresse1"].Value = lAdr1;
        cmd.Parameters["@adresse2"].Value = lAdr2;
        cmd.Parameters["@cp"].Value = lCP;
        cmd.Parameters["@ville"].Value = lVille;
        cmd.Parameters["@aattention"].Value = lAttention;
        cmd.Parameters["@lieulivr"].Value = lLieuLivr;

        cmd.Parameters["@numArticle"].Value = (int)Utils.ZeroIfNull(row["NumArticle"]);
        cmd.Parameters["@qte"].Value = (int)Utils.ZeroIfNull(row["Quantite"]);

        cmd.Parameters["@pu"].Value = Convert.ToDouble(row["Prix U"]);
        cmd.Parameters["@pt"].Value = Convert.ToDouble(row["Prix T"]);

        cmd.Parameters["@dDatePlanif"].Value = DBNull.Value;

        cmd.Parameters["@nidfiche"].Value = DBNull.Value;
        cmd.Parameters["@vComplInterim"].Value = "";

        // Commentaire pour la création depuis cette fenêtre
        cmd.Parameters["@vRemInterne"].Value = $"Création d'un CF de transport le {DateTime.Now}";

        cmd.ExecuteNonQuery();

        // récupération du numéro crée
        numCom = (int)cmd.Parameters[0].Value;
      }
    }

    private void apiTGrid1_RowStyle(object sender, RowStyleEventArgs e)
    {
      if (e.RowHandle >= 0)
      {
        GridView View = sender as GridView;
        //  ' Style sur la ligne entière uniquement si fourniture gérée en stock magasin
        if (View.GetDataRow(e.RowHandle)["CCODEG"].ToString() == "O")
        {
          e.Appearance.Font = new Font(e.Appearance.Font, FontStyle.Bold);
          e.HighPriority = true;
        }
      }
    }

    private void InitApiTgrid()
    {
      apiTGrid1.AddColumn(Resources.col_série, "VFOUSER", 2000);
      apiTGrid1.AddColumn(Resources.col_materiel, "VFOUMAT", 4000, "", 0, true);
      apiTGrid1.AddColumn(Resources.col_marque, "VFOUMAR", 1100, "", 0, true);
      apiTGrid1.AddColumn(Resources.col_Type, "VFOUTYP", 1300, "", 0, true);
      apiTGrid1.AddColumn(Resources.col_Ref, "VFOUREF", 1100, "", 0, true);
      apiTGrid1.AddColumn(Resources.col_pcb, "NFOUNBLOT", 600, "", 2);
      apiTGrid1.AddColumn(Resources.col_prixU, "FPUHT", 1300, "0.000", 1);
      apiTGrid1.AddColumn(Resources.col_dateprix, "DFOUDPR", 1200);
      apiTGrid1.AddColumn(Resources.col_stock, "NFOUQTESTOCK", 700);
      apiTGrid1.AddColumn(Resources.col_stk_emalec, "BGESTSTOCKEMALEC", 1000, "", 2);
      //apiTGrid1.AddColumn(Resources.col_Fournisseur, "VSTFGRPNOM", 1700);
      apiTGrid1.AddColumn(Resources.col_Ref_Fou, "VSTFFOUREFCLI", 1200);
      apiTGrid1.AddColumn(Resources.col_clients, "VFOUCLI", 1000, "", 0, true);
      apiTGrid1.AddColumn(Resources.col_ID, "NFOUNUM", 600);
      apiTGrid1.AddColumn(Resources.col_NumFourn, "NSTFGRPNUM", 0);
      apiTGrid1.AddColumn("CCODTEC", "CCODTEC", 0);

      apiTGrid1.InitColumnList();
    }

    private void cmdSupp_Click(object sender, EventArgs e)
    {
      DataRow row = grdDataGrid2.GetFocusedDataRow();
      if (null == row)
        return;

      //' suppression de la ligne courante
      row.Delete();

      //' mise a jour du total
      txtHT.Text = CalculerTHT().ToString();
    }

    private double CalculerTHT()
    {
      double ht = 0;

      foreach (DataRow row in mdtArticles.Rows)
      {
        ht += Utils.ZeroIfNull(row["Prix U"]) * Utils.ZeroIfNull(row["Quantite"]);
      }

      return ht;
    }

    private void grdDataGrid2_RowCellStyle(object sender, RowCellStyleEventArgs e)
    {
      if (e.RowHandle >= 0 && e.Column.Name == "Quantite")
      {
        e.Appearance.BackColor = Color.LightGray;
        e.Appearance.Font = new Font(e.Appearance.Font, FontStyle.Bold);
      }
    }

    private void grdDataGrid2_CellValueChanged(object sender, DevExpress.XtraGrid.Views.Base.CellValueChangedEventArgs e)
    {
      // Mise a jour du total
      txtHT.Text = CalculerTHT().ToString();
    }

    private void cmdAjouter_Click(object sender, EventArgs e)
    {
      try
      {
        DataRow row = apiTGrid1.GetFocusedDataRow();
        if (null == row)
          return;

        // Teste si la fourniture sélectionnée est en stock magasin emalec
        if (Utils.ZeroIfNull(row["NFOUQTESTOCK"]) > 0)
        {
          if (MessageBox.Show($"{Utils.ZeroIfNull(row["NFOUQTESTOCK"])}{Resources.msg_stock_magasin}", "",
                              MessageBoxButtons.YesNo, MessageBoxIcon.Question, MessageBoxDefaultButton.Button2) == DialogResult.Yes)
          {
            return;
          }
        }

        // Information sur le fournisseur interdit ou pas
        using (SqlDataReader reader = ModuleData.ExecuteReader($"SELECT CNOTINTERDIT FROM TNOTES WITH(NOLOCK) WHERE VNOTTYPE = 'INFO_STF' AND NNOTCLE = {row["NSTFGRPNUM"]}"))
        {
          if (reader.Read() && Utils.BlankIfNull(reader[0]) == "O")
          {
            MessageBox.Show(Resources.msg_Fournisseur_interdit, Program.AppTitle, MessageBoxButtons.OK, MessageBoxIcon.Information);
            return;
          }
        }

        // Ouverture d'une fenetre d'information si information
        ModuleMain.Infos infos = new ModuleMain.Infos();
        infos = ModuleMain.RechercheInfos("INFO_STF", (long)Utils.ZeroIfNull(row["NSTFGRPNUM"]));
        if (infos.strInfo != "" && infos.DateValDeb < DateTime.Now && infos.DateValFin > DateTime.Now)
        {
          new frmInfosClient()
          {
            msStatut = infos.strInfo,
            msInfo = infos.strInfo
          }.ShowDialog();
        }

        // On recherche si plusieurs fournisseurs ont cet article
        // On recherche s'il existe un prix inférieur pour cet article
        if (row["CCODE"].ToString() == "R" || row["CCODE"].ToString() == "V")
        {
          DataTable dtTemp = dtRS.Clone();
          DataRow[] rows = dtTemp.Select($"FPUHT <> 0 AND NFOUNUM = {row["NFOUNUM"]}");
          if (rows.Length > 0 &&
              rows[0]["FPUHT"] != row["FPUHT"])
          {
            if (MessageBox.Show($"{Resources.msg_Lefournisseur}{rows[0]["VSTFGRPNOM"]}{Resources.msg_propose_prix_inferieur}\r\n{Resources.msg_continuer}",
                                Resources.msg_Confirmation, MessageBoxButtons.OKCancel, MessageBoxIcon.Question, MessageBoxDefaultButton.Button2) == DialogResult.Cancel)
            {
              return;
            }
          }
        }

        // Teste si l'enregistrement n'est pas déja selectionné
        int iNumSiteFournisseur = 0;
        string sNomSiteFournisseur = "";
        // On a le numArticle on regarde si il existe
        bool bOK = false;
        // Teste si le même fournisseur est déja selectionné
        bool bSelect = true;
        foreach (DataRow r in mdtArticles.Rows)
        {
          if (r["NumArticle"].ToString() == row["NFOUNUM"].ToString()) bOK = true;
          if (r["NumFour"].ToString() == row["NSTFGRPNUM"].ToString())
          {
            bSelect = false;
            iNumSiteFournisseur = (int)Utils.ZeroIfNull(r["NumSiteFour"]);
            sNomSiteFournisseur = Utils.BlankIfNull(r["Fournisseur"]);
          }
        }

        if (!bOK)
        {
          using (SqlDataReader reader = ModuleData.ExecuteReader($"select distinct NSTFNUM, VSTFNOM from TSTF WITH (NOLOCK) WHERE NSTFGRPNUM = {(int)Utils.ZeroIfNull(row["NSTFGRPNUM"])}"))
          {
            int NSTFNUM = 0;
            string VSTFNOM = "";

            if (reader.Read())
            {
              NSTFNUM = (int)Utils.ZeroIfNull(reader["NSTFNUM"]);
              VSTFNOM = Utils.BlankIfNull(reader["VSTFNOM"]);
            }
            if (reader.Read())
            {
              if (bSelect)
              {
                // Si on a plusieurs sites, il faut choisir sur un écran
                frmSelectionSiteFour frm = new frmSelectionSiteFour()
                {
                  miFournisseur = (int)Utils.ZeroIfNull(row["NSTFGRPNUM"])
                };
                frm.ShowDialog();
                iNumSiteFournisseur = frm.miNumSiteFournisseur;
                sNomSiteFournisseur = frm.msNomSiteFournisseur;
                // Mise a jour de iNumSiteFournisseur dans la page frmselectionSiteFour
                // Si on ne choisit pas, il ne faut pas prendre la fourniture
                if (iNumSiteFournisseur == 0)
                  return;
              }
            }
            else
            {
              if ((int)Utils.ZeroIfNull(row["NSTFGRPNUM"]) == 0)
              {
                iNumSiteFournisseur = 0;
                sNomSiteFournisseur = "";
              }
              else
              {
                iNumSiteFournisseur = NSTFNUM;
                sNomSiteFournisseur = VSTFNOM;
              }
            }
          }

          // Ajoute l'enregistrement
          DataRow r = mdtArticles.NewRow();
          r["Serie"] = Utils.BlankIfNull(row["VFOUSER"]);
          r["Article"] = Utils.BlankIfNull(row["VFOUMAT"]);
          r["Marque"] = Utils.BlankIfNull(row["VFOUMAR"]);
          r["Type"] = Utils.BlankIfNull(row["VFOUTYP"]);
          r["Reference"] = Utils.BlankIfNull(row["VFOUREF"]);
          r["PCB"] = (int)Utils.ZeroIfNull(row["NFOUNBLOT"]);
          r["Prix U"] = Utils.ZeroIfNull(row["FPUHT"]);
          r["Fournisseur"] = sNomSiteFournisseur;
          r["Quantite"] = 1;
          r["Prix T"] = Utils.ZeroIfNull(row["FPUHT"]);
          r["NumFour"] = (int)Utils.ZeroIfNull(row["NSTFGRPNUM"]);
          r["NumArticle"] = (int)Utils.ZeroIfNull(row["NFOUNUM"]);
          r["NumSiteFour"] = iNumSiteFournisseur;

          mdtArticles.Rows.Add(r);

          grdDataGrid2.dgv.MoveLast();
        }
        else
        {
          MessageBox.Show(Resources.msg_article_already_in_list, Program.AppTitle, MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
        }

        txtHT.Text = CalculerTHT().ToString();
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
  }
}
