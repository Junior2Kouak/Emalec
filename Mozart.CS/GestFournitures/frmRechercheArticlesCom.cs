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
using System.IO;
using System.Reflection;
using System.Windows.Forms;
using MZCtrlResources = MozartControls.Properties.Resources;
using MZUtils = MozartControls.Utils;


namespace MozartCS
{
  public partial class frmRechercheArticlesCom : Form
  {
    public int miNumFournisseur;
    public int miNumSiteFournisseur;
    public string msNomSiteFournisseur;
    public string mstrStatut;
    public string mstrClient;
    public int miNumClient;

    public bool m_brechercheSite;
    public bool m_bSaisieQte;
    public bool m_bAfficheInfoFou;

    // parametre d'appel : liste des articles (equivalent rsArticle)
    public DataTable mdtArticles;

    // frmCommandeFournisseur.bStock
    public bool m_bStock;

    DataTable dtRS;
    int iIndexFouTabHaut;
    List<string> tabLstImgFouH = new List<string>();

    public frmRechercheArticlesCom()
    {
      InitializeComponent();
    }

    private void frmRechercheArticlesCom_Load(object sender, System.EventArgs e)
    {
      try
      {
        Cursor.Current = Cursors.WaitCursor;

        ModuleMain.Initboutons(this);

        dtRS = new DataTable();
        apiTGrid1.GridControl.DataSource = dtRS;

        InitApiTgrid();

        string sql = $"EXEC api_sp_ListeSerieFOMOZART {MozartParams.Langue}";
        txtCritFouSer.Init(MozartDatabase.cnxMozart, sql, "NCFOCOD", "CCFOCOD",
                          new List<string>() { Resources.col_Num, MZCtrlResources.col_Serie }, 250, 550, true);

        FormatGridArticle();

        // Combo des fournisseurs
        txtCritFour.Init(MozartDatabase.cnxMozart, "SELECT NSTFGRPNUM, VSTFGRPNOM + ' - ' + COALESCE(VSTFGRPVIL, '') [VSTFGRPNOM]" +
                     "FROM TSTFGRP WHERE  CSTFGRPACTIF = 'O' AND (CSTFTYP = 'FO' OR CSTFTYP = 'FT') ORDER BY VSTFGRPNOM  + ' - ' + COALESCE(VSTFGRPVIL, '') ",
                     "NSTFGRPNUM", "VSTFGRPNOM", new List<string>() { Resources.col_Num, Resources.col_Nom }, 150, 550, true);

        grdDataGrid2.GridControl.DataSource = mdtArticles;

        Label2.Visible = m_bSaisieQte;

        // affichage de la liste des fournitures du fournisseur lorsqu'on est en modification de commande
        if (miNumFournisseur > 0)
        {
          apiLabel5.Enabled = false;
          txtCritFour.Enabled = false;
          txtCritFour.SetItemData(miNumFournisseur);

          cmdFind_Click(null, null);
        }

        // ' mise a jour du total
        txtHT.Text = CalculerTHT().ToString();

        apiTGrid1_SelectionChanged(null, null);

        if (m_bAfficheInfoFou)
        {
          using (SqlDataReader reader = ModuleData.ExecuteReader($"SELECT VACTFOU FROM TACT WITH(NOLOCK) WHERE  NACTNUM ={MozartParams.NumAction} " +
                                                                 $"AND VACTFOU is not null and VACTFOU <> ''"))
          {
            if (reader.Read())
            {
              apiToolTip1.Width = 5000 / 15;
              apiToolTip1.Left = FrameImgFouHaut.Left;
              apiToolTip1.Texte = $"{Utils.BlankIfNull(reader["VACTFOU"])}\r\n\r\n\r\n\r\n\r\n\r\n\r\n\r\n\r\n\r\n\r\n\r\n\r\n\r\n\r\n\r\n";
              apiToolTip1.Titre = Resources.lbl_Demande_technicien;
              apiToolTip1.PrintTexte("");
              apiToolTip1.Visible = true;
            }
          }
        }

        // Traitement spécial si on vient de StockListeBL
        // On supprime tout çà : TODO : Virer la gestion avec le paramètre m_bStock
        //if (m_bStock)
        //{
        //  //FGB : (Remplacé par un filtre sur la série) apiTGrid1.dgv.ActiveFilterString = "VSTFGRPNOM LIKE '%TNT%'";
        //  txtCritFouSer.SetText("Transport");
        //  cmdFind_Click(null, null);
        //}
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
        if (null == row)
          return;

        //' test si la fournitures sélectionnées est en stock magasin emalec
        if (mstrStatut == "CDE" && Utils.ZeroIfNull(row["NFOUQTESTOCK"]) > 0)
        {
          if (MessageBox.Show($"{Utils.ZeroIfNull(row["NFOUQTESTOCK"])}{Resources.msg_stock_magasin}", "",
                              MessageBoxButtons.YesNo, MessageBoxIcon.Question, MessageBoxDefaultButton.Button2) == DialogResult.Yes)
          {
            return;
          }
        }
        //'Test si fournitures géré
        //'Si client Yves Rocher et fournitures yves rocher
        if (row["VFOUSER"].ToString() == "Yves Rocher")
        {
          switch (mstrStatut)
          {
            case "CDE":
              if (mstrClient != "YVES ROCHER")
              {
                MessageBox.Show(Resources.msg_article_peut_pas_être_ajoute_serie, Program.AppTitle, MessageBoxButtons.OK, MessageBoxIcon.Information);
                return;
              }
              break;
            case "STOCK-CLI":
              break;
            default:
              MessageBox.Show(Resources.msg_article_peut_pas_être_ajoute_serie, Program.AppTitle, MessageBoxButtons.OK, MessageBoxIcon.Information);
              return;
          }
        }
        //' information sur le fournisseur interdit ou pas
        if (mstrStatut == "CDE")
        {
          using (SqlDataReader reader = ModuleData.ExecuteReader($"SELECT CNOTINTERDIT FROM TNOTES WITH(NOLOCK) WHERE VNOTTYPE = 'INFO_STF' AND NNOTCLE = {row["NSTFGRPNUM"]}"))
          {
            if (reader.Read() && Utils.BlankIfNull(reader[0]) == "O")
            {
              MessageBox.Show(Resources.msg_Fournisseur_interdit, Program.AppTitle, MessageBoxButtons.OK, MessageBoxIcon.Information);
              return;
            }
          }
        }
        //' ouverture d'une fenetre d'information si information
        ModuleMain.Infos infos = new ModuleMain.Infos();
        if (mstrStatut != "CDE")
        {
          infos.strInfo = "";
        }
        else
        {
          infos = ModuleMain.RechercheInfos("INFO_STF", (long)Utils.ZeroIfNull(row["NSTFGRPNUM"]));
        }
        if (infos.strInfo != "" && infos.DateValDeb < DateTime.Now && infos.DateValFin > DateTime.Now)
        {
          new frmInfosClient()
          {
            msStatut = infos.strInfo,
            msInfo = infos.strInfo
          }.ShowDialog();
        }

        //' on recherche si plusieurs fournisseurs ont cet article
        //' on recherche s'il existe un prix inférieur pour cet article
        if (mstrStatut == "CDE" && (row["CCODE"].ToString() == "R" || row["CCODE"].ToString() == "V"))
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
        //' test si l'enregistrement n'est pas déja selectionné
        //' on a le numArticle on regarde si il existe
        bool bOK = false;
        //' test si le même fournisseur est déja selectionné
        bool bSelect = true;
        foreach (DataRow r in mdtArticles.Rows)
        {
          if (r["NumArticle"].ToString() == row["NFOUNUM"].ToString()) bOK = true;
          if (r["NumFour"].ToString() == row["NSTFGRPNUM"].ToString())
          {
            bSelect = false;
            miNumSiteFournisseur = (int)Utils.ZeroIfNull(r["NumSiteFour"]);
            msNomSiteFournisseur = Utils.BlankIfNull(r["Fournisseur"]);
          }
        }

        if (!bOK)
        {
          using (SqlDataReader reader = ModuleData.ExecuteReader($"select distinct NSTFNUM, VSTFNOM from TSTF WHERE NSTFGRPNUM = {(int)Utils.ZeroIfNull(row["NSTFGRPNUM"])}"))
          {
            int NSTFNUM = 0;
            string VSTFNOM = "";
            int nSTFGPNUM = 0;

            if (reader.Read())
            {
              NSTFNUM = (int)Utils.ZeroIfNull(reader["NSTFNUM"]);
              VSTFNOM = Utils.BlankIfNull(reader["VSTFNOM"]);
              nSTFGPNUM = (int)Utils.ZeroIfNull(row["NSTFGRPNUM"]);
            }
            if (reader.Read() && m_brechercheSite)
            {
              if (bSelect)
              {
                //' si on a plusieurs sites, il faut choisir sur un écran
                frmSelectionSiteFour frm = new frmSelectionSiteFour()
                {
                  miFournisseur = (int)Utils.ZeroIfNull(row["NSTFGRPNUM"])
                };
                frm.ShowDialog();
                miNumSiteFournisseur = frm.miNumSiteFournisseur;
                msNomSiteFournisseur = frm.msNomSiteFournisseur;
                //'mise a jour de miNumSiteFournisseur dans la page frmselectionSiteFour
                //' si on ne choisit pas, il ne faut pas prendre la fourniture
                if (miNumSiteFournisseur == 0)
                  return;
              }
            }
            else
            {
              if (nSTFGPNUM == 0)
              {
                miNumSiteFournisseur = 0;
                msNomSiteFournisseur = "";
              }
              else
              {
                miNumSiteFournisseur = NSTFNUM;
                msNomSiteFournisseur = VSTFNOM;
              }
            }
          }

          AjouterEnreg(row);
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

    private void AjouterEnreg(DataRow row)
    {
      DataRow r = mdtArticles.NewRow();
      r["Serie"] = Utils.BlankIfNull(row["VFOUSER"]);
      r["Article"] = Utils.BlankIfNull(row["VFOUMAT"]);
      r["Marque"] = Utils.BlankIfNull(row["VFOUMAR"]);
      r["Type"] = Utils.BlankIfNull(row["VFOUTYP"]);
      r["Reference"] = Utils.BlankIfNull(row["VFOUREF"]);
      r["PCB"] = (int)Utils.ZeroIfNull(row["NFOUNBLOT"]);
      r["Prix U"] = Utils.ZeroIfNull(row["FPUHT"]);
      try
      {
        // FGb : Try catch pour éviter les erreurs car cette colonne n'est gérée que dans frmStockRetourTech
        //       et il y a des appels à frmRechercheArticlesCom de partout ...... c'est la galère .....
        r["VFOUEMPLACEMENT"] = Utils.BlankIfNull(row["VFOUEMPLACEMENT"]);
      }
      catch (Exception) { };
      r["Fournisseur"] = msNomSiteFournisseur;
      r["Quantite"] = 1;
      if (mstrStatut == "STOCK-CLI")
      {
        //' dans le cas de la gamme stock, on met le prix a zero
        r["Prix T"] = 0;
      }
      else if (mstrStatut == "STOCK-CLIEXT")
      {
        //' pour extincteur, le PV est le PVC
        r["Prix T"] = Utils.ZeroIfNull(row["NFOUPVCONS"]);
      }
      else
      {
        r["Prix T"] = Utils.ZeroIfNull(row["FPUHT"]);
      }
      if (mstrStatut == "STOCK-CLI" || mstrStatut == "STOCK-CLIEXT")
      {
        r["NumFour"] = 0;
      }
      else
      {
        r["NumFour"] = (int)Utils.ZeroIfNull(row["NSTFGRPNUM"]);
      }
      r["NumArticle"] = (int)Utils.ZeroIfNull(row["NFOUNUM"]);
      r["NumSiteFour"] = miNumSiteFournisseur;

      mdtArticles.Rows.Add(r);

      grdDataGrid2.dgv.MoveLast();
    }

    private void cmdFermer_Click(object sender, System.EventArgs e)
    {
      Close();
    }

    private void cmdSupp_Click(object sender, EventArgs e)
    {
      DataRow row = grdDataGrid2.GetFocusedDataRow();
      if (null == row)
        return;

      //  'on test si la supression est possible pour "STOCK-CLIEXT" voir si la fourniture est présente dans un devis enc orus
      if (mstrStatut == "STOCK-CLIEXT")
      {
        using (SqlDataReader reader = ModuleData.ExecuteReader($"exec api_sp_VerifFOUExistInDCLEI {row["NumArticle"]},{miNumClient}"))
        {
          string sLstDevis = "";
          while (reader.Read())
          {
            sLstDevis += $"\r\n{(int)Utils.ZeroIfNull(reader["NDCLNUM"])}";
          }
          if (sLstDevis != "")
          {
            MessageBox.Show($"La suppression de cet article est impossible car il est utilisé dans le(s) devis suivant: {sLstDevis}", Program.AppTitle, MessageBoxButtons.OK, MessageBoxIcon.Information);
          }
        }
      }

      //' suppression de la ligne courante
      row.Delete();
      mdtArticles.AcceptChanges();

      //' mise a jour du total
      txtHT.Text = CalculerTHT().ToString();
    }

    private void cmdValider_Click(object sender, EventArgs e)
    {
      //' mise à jour du total par article
      DataRow row = grdDataGrid2.GetFocusedDataRow();
      if (null == row)
        return;
      //'on clone le recordset pour verifier si le franco port est respecter
      if (mstrStatut == "CDE" && VerifMontantFrancoPortSTFGRP() == false)
        return;
      //' parcours du recordset et mise à jour
      if (mstrStatut != "STOCK-CLI" && mstrStatut != "STOCK-CLIEXT")
      {
        foreach (DataRow r in mdtArticles.Rows)
        {
          r["Prix T"] = Utils.ZeroIfNull(r["Prix U"]) * Utils.ZeroIfNull(r["Quantite"]);
          // TODO
          // rsarticle.Update ?
        }

        MozartUcUtils.SpyLog(MozartDatabase.cnxMozart, this.Text, cmdValider.Text, "Modification", $"NCLINUM:{miNumClient}", $"NSTFGRPNUM:{mdtArticles.Rows[0]["NumSiteFour"]}");
      }
      Dispose();
    }

    private void FormatGridArticle()
    {
      if (mstrStatut == "STOCK-CLI" || mstrStatut == "STOCK-CLIEXT")
      {
        grdDataGrid2.AddColumn(Resources.col_Gestion, "CHECK", 0, "", 0, true);
        grdDataGrid2.AddColumn(MZCtrlResources.col_Serie, "Serie", 1500);
        grdDataGrid2.AddColumn(Resources.col_materiel, "Article", 4300);
        grdDataGrid2.AddColumn(Resources.col_marque, "Marque", 1500, "", 0, true);
        grdDataGrid2.AddColumn(Resources.col_Type, "Type", 1500, "", 0, true);
        grdDataGrid2.AddColumn(Resources.col_reference, "Reference", 1500, "", 0, true);
        grdDataGrid2.AddColumn(Resources.col_pcb, "PCB", 850, "", 2);
        grdDataGrid2.AddColumn(Resources.col_Condit, "Condi", 900);
        grdDataGrid2.AddColumn(Resources.col_Prix, "Prix U", 800, "## ##0.00", 1);
        if (m_bSaisieQte)
          grdDataGrid2.AddColumn(Resources.col_Qte, "Quantite", 1000, "", 2);
        else
          grdDataGrid2.AddColumn(Resources.col_Qte, "Quantite", 0, "", 2);
        grdDataGrid2.AddColumn(Resources.col_Coeff, "Coeff", 0, "## ##0.00", 2);
        if (mstrStatut == "STOCK-CLIEXT")
          grdDataGrid2.AddColumn(Resources.col_Prix_Client, "Prix T", 1000, "## ##0.00", 1);//' dans le cas de la gamme stock, on n'affiche pas le fournisseur
        else
          grdDataGrid2.AddColumn(Resources.col_Prix_Client, "Prix T", 0, "## ##0.00", 1);
        grdDataGrid2.AddColumn(Resources.col_NumFourn, "NumFour", 0);
        grdDataGrid2.AddColumn(Resources.col_NumArticle, "NumArticle", 0);
        grdDataGrid2.AddColumn(Resources.col_NumSiteFour, "NumSiteFour", 0);
      }
      else
      {
        grdDataGrid2.AddColumn(MZCtrlResources.col_Serie, "Serie", 1500);
        grdDataGrid2.AddColumn(Resources.col_materiel, "Article", 4300);
        grdDataGrid2.AddColumn(Resources.col_marque, "Marque", 1500, "", 0, true);
        grdDataGrid2.AddColumn(Resources.col_Type, "Type", 1500, "", 0, true);
        grdDataGrid2.AddColumn(Resources.col_reference, "Reference", 1500, "", 0, true);
        grdDataGrid2.AddColumn(Resources.col_pcb, "PCB", 850, "", 2);
        grdDataGrid2.AddColumn(Resources.col_Prix, "Prix U", 800, "## ##0.00", 1);
        if (m_bSaisieQte)
          grdDataGrid2.AddColumn(Resources.col_Qte, "Quantite", 1000, "", 2);
        else
          grdDataGrid2.AddColumn(Resources.col_Qte, "Quantite", 0, "", 2);
        grdDataGrid2.AddColumn(Resources.col_Prix_Client, "Prix T", 1000, "## ##0.00", 1);
        grdDataGrid2.AddColumn(Resources.col_four, "Four", 0);
        grdDataGrid2.AddColumn(Resources.col_NumFourn, "NumFour", 0);
        grdDataGrid2.AddColumn(Resources.col_NumArticle, "NumArticle", 0);
        grdDataGrid2.AddColumn(Resources.col_NumSiteFour, "NumSiteFour", 0);
      }
      //'locked des cellules sauf la quantité
      if (m_bSaisieQte)
        grdDataGrid2.DelockColumn("Quantite");

      grdDataGrid2.InitColumnList();
    }

    private void apiTGrid1_DoubleClickE(object sender, EventArgs e)
    {
      cmdAjouter_Click(null, null);
    }

    private void apiTGrid1_SelectionChanged(object sender, DevExpress.Data.SelectionChangedEventArgs e)
    {
      DataRow row = apiTGrid1.GetFocusedDataRow();
      if (null == row)
      {
        lblQteStock.Text = Resources.lbl_quantite_stock;
        return;
      }
      lblQteStock.Text = $"{Resources.lbl_quantite_stock} : {(int)Utils.ZeroIfNull(row["NFOUQTESTOCK"])}";

      iIndexFouTabHaut = 0;
      ImageFournitureH.Image = null;
      tabLstImgFouH.Clear();

      using (SqlDataReader reader = ModuleData.ExecuteReader($"exec api_sp_ListeFileFourniture {row["NFOUNUM"]}"))
      {
        while (reader.Read())
        {
          tabLstImgFouH.Add(reader["FILEIMGFOU"].ToString());
        }
      }

      if (tabLstImgFouH.Count > 0)
      {
        FrameImgFouHaut.Visible = true;
        ImageFournitureH.Image = File.Exists(tabLstImgFouH[0]) ? Image.FromFile(tabLstImgFouH[0]) : null;
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
      {
        FrameImgFouHaut.Visible = false;
      }
    }

    private void grdDataGrid2_CellValueChanged(object sender, DevExpress.XtraGrid.Views.Base.CellValueChangedEventArgs e)
    {
      //  ' mise a jour du total
      txtHT.Text = CalculerTHT().ToString();
    }

    private void grdDataGrid2_EditorKeyPressE(object sender, KeyPressEventArgs e)
    {
      KeyValidator.KeyPress_SaisieNombre(e);
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
        if (miNumFournisseur == 0)
        {
          if (View.GetDataRow(e.RowHandle)["CCODE"].ToString() == "R")
          {
            // Plusieurs prix
            e.Appearance.ForeColor = Color.Black;
            e.Appearance.BackColor = lblColorPlusieursPrix.BackColor;
            e.HighPriority = true;
          }
          else if (View.GetDataRow(e.RowHandle)["CCODE"].ToString() == "V")
          {
            // Plusieurs fournisseurs
            e.Appearance.ForeColor = Color.Black;
            e.Appearance.BackColor = lblColorPlusieursFour.BackColor;
            e.HighPriority = true;
          }
        }
      }
    }

    private void InitApiTgrid()
    {
      apiTGrid1.AddColumn(MZCtrlResources.col_Serie, "VFOUSER", 2000);
      apiTGrid1.AddColumn(Resources.col_materiel, "VFOUMAT", 4000, "", 0, true);
      apiTGrid1.AddColumn(Resources.col_marque, "VFOUMAR", 1100, "", 0, true);
      apiTGrid1.AddColumn(Resources.col_Type, "VFOUTYP", 1300, "", 0, true);

      //apiTGrid1.AddColumn(Resources.col_RefFab, "VFOUREF", 1100, "", 0, true);
      apiTGrid1.AddColumn(Resources.col_RefFab, "VFOUREF", 1100, "", 0, true);

      apiTGrid1.AddColumn(Resources.col_pcb, "NFOUNBLOT", 600, "", 2);
      apiTGrid1.AddColumn(Resources.col_prixU, "FPUHT", 1300, "0.000", 1);
      apiTGrid1.AddColumn(Resources.col_dateprix, "DFOUDPR", 1200);
      apiTGrid1.AddColumn(Resources.col_stock, "NFOUQTESTOCK", 700);
      apiTGrid1.AddColumn(Resources.col_stk_emalec, "BGESTSTOCKEMALEC", 1000, "", 2);
      if (mstrStatut == "STOCK-CLI")
      {
        apiTGrid1.AddColumn(Resources.col_Fournisseur, "VSTFGRPNOM", 0, "", 0, true);
        //apiTGrid1.AddColumn(Resources.col_Ref_Fou, "VSTFFOUREFCLI", 0, "", 0, true);
        apiTGrid1.AddColumn(Resources.col_Ref_Fou, "VSTFFOUREFCLI", 0, "", 0, true);
      }
      else if (mstrStatut == "STOCK-CLIEXT")
      {
        apiTGrid1.AddColumn(Resources.col_Fournisseur, "VSTFGRPNOM", 0, "", 0, true);
        //apiTGrid1.AddColumn(Resources.col_Ref_Fou, "VSTFFOUREFCLI", 0, "", 0, true);
        apiTGrid1.AddColumn(Resources.col_Ref_Fou, "VSTFFOUREFCLI", 0, "", 0, true);
        //apiTGrid1.AddColumn(Resources.col_Prix_vente_conseille, "NFOUPVCONS", 1700, "0.000", 1);
      }
      else
      {
        apiTGrid1.AddColumn(Resources.col_Fournisseur, "VSTFGRPNOM", 1700);
        //apiTGrid1.AddColumn(Resources.col_Ref_Fou, "VSTFFOUREFCLI", 1200);
        apiTGrid1.AddColumn(Resources.col_Ref_Fou, "VSTFFOUREFCLI", 1200);
      }
      apiTGrid1.AddColumn(Resources.col_clients, "VFOUCLI", 1000, "", 0, true);
      apiTGrid1.AddColumn(Resources.col_ID, "NFOUNUM", 600);
      apiTGrid1.AddColumn(Resources.col_NumFourn, "NSTFGRPNUM", 0);
      apiTGrid1.AddColumn("CCODTEC", "CCODTEC", 0);

      apiTGrid1.InitColumnList();
    }
    private void apiTGrid1_RowCellStyle(object sender, RowCellStyleEventArgs e)
    {
      //' Gestion spécifique des couleurs
      if (e.RowHandle >= 0 && (e.Column.Name == "VFOUMAT") &&
          (((sender as GridView).GetDataRow(e.RowHandle)["CCODTEC"]).ToString() == "O"))
      {
        // Matériel en vert si dans réappro tech multi
        e.Appearance.BackColor = lblColorFourEnStockVecTechMulti.BackColor;
      }
    }
    private void cmdLegende_Click(object sender, EventArgs e)
    {
      Frame3.Visible = !Frame3.Visible;
      if (Frame3.Visible)
      {
        Frame3.BringToFront();
      }
    }

    private void Command1_Click(object sender, EventArgs e)
    {
      Frame3.Visible = false;
    }

    //'Permet de tester si dans cette liste article il y a des fournisseurs avec un fran port
    private bool VerifMontantFrancoPortSTFGRP()
    {
      bool bContinue = true;
      int iNumSTFGRPSelectLast = 0;
      int iNumSTFGRPSelect = 0;
      foreach (DataRow row in mdtArticles.Rows)
      {
        iNumSTFGRPSelect = (int)Utils.ZeroIfNull(row["NumFour"]);
        if (iNumSTFGRPSelectLast != iNumSTFGRPSelect)
        {
          long iMontantTotCommande = TotalComByFournisseur(iNumSTFGRPSelect);
          long iMontantFranPort = FindMontantFrancoPort(iNumSTFGRPSelect);
          if (iMontantTotCommande < iMontantFranPort)
          {
            if (MessageBox.Show($"Vous allez valider une commande pour laquelle des frais de port seront appliqués en supplément.\r\nVoulez-vous toutefois valider ?",
                                Program.AppTitle, MessageBoxButtons.YesNo, MessageBoxIcon.Exclamation) == DialogResult.Yes)
            {
              bContinue = true;
            }
            else
            {
              bContinue = false;
              break;
            }
          }
          iNumSTFGRPSelectLast = iNumSTFGRPSelect;
        }
      }
      return bContinue;
    }

    private long TotalComByFournisseur(long p_NUMSTFGRP)
    {
      long iTOTCOM = 0;
      foreach (DataRow row in mdtArticles.Rows)
      {
        if (p_NUMSTFGRP == (long)Utils.ZeroIfNull(row["NumFour"]))
        {
          iTOTCOM += (long)(Utils.ZeroIfNull(row["Prix U"]) * Utils.ZeroIfNull(row["Quantite"]));
        }
      }
      return iTOTCOM;
    }

    private long FindMontantFrancoPort(long p_NUMSTFGRP)
    {
      using (SqlDataReader reader = ModuleData.ExecuteReader($"exec api_sp_ReturnMontantFrancoPort {p_NUMSTFGRP}"))
      {
        if (reader.Read())
        {
          return (long)Utils.ZeroIfNull(reader["NSTFGRPMTTPORT"]);
        }
      }
      return 0;
    }

    private void CmdImgHautLast_Click(object sender, EventArgs e)
    {
      if (iIndexFouTabHaut == 1)
      {
        iIndexFouTabHaut = 0;
        CmdImgHautLast.Visible = false;
        CmdImgHautNext.Visible = true;
      }
      else
      {
        iIndexFouTabHaut--;
        CmdImgHautLast.Visible = true;
        CmdImgHautNext.Visible = true;
      }

      ImageFournitureH.Image = Image.FromFile(tabLstImgFouH[iIndexFouTabHaut]);
    }

    private void CmdImgHautNext_Click(object sender, EventArgs e)
    {
      if (iIndexFouTabHaut >= (tabLstImgFouH.Count - 2))
      {
        iIndexFouTabHaut = tabLstImgFouH.Count - 1;
        CmdImgHautNext.Visible = false;
        CmdImgHautLast.Visible = true;
      }
      else
      {
        iIndexFouTabHaut++;
        CmdImgHautNext.Visible = true;
        CmdImgHautLast.Visible = true;
      }

      ImageFournitureH.Image = Image.FromFile(tabLstImgFouH[iIndexFouTabHaut]);
    }

    private void grdDataGrid2_RowCellStyle(object sender, RowCellStyleEventArgs e)
    {
      if (e.RowHandle >= 0 && e.Column.Name == "Quantite")
      {
        e.Appearance.BackColor = Color.LightGray;
        e.Appearance.Font = new Font(e.Appearance.Font, FontStyle.Bold);
      }
    }

    private void cmdFind_Click(object sender, EventArgs e)
    {
      int nCfoCod;
      string sFouSer;
      string sFouMat;
      string sFouMar;
      string sFouRef;
      string sUniquementStock;
      string sFouPrixClient;
      string lReq;
      string sFouRefCli;

      Cursor.Current = Cursors.WaitCursor;

      sFouSer = (txtCritFouSer.GetText() == "") ? "T$" : txtCritFouSer.GetText();
      sFouMat = (txtCritFouMat.Text == "") ? "T$" : txtCritFouMat.Text;
      sFouMar = (txtCritFouMar.Text == "") ? "T$" : txtCritFouMar.Text;
      sFouRef = (txtCritFouRef.Text == "") ? "T$" : txtCritFouRef.Text;
      sFouRefCli = (txtCritFabRef.Text == "") ? "T$" : txtCritFabRef.Text;

      // traitement des '
      sFouMat = sFouMat.Replace("'", "''");
      sFouMar = sFouMar.Replace("'", "''");
      sFouRef = sFouRef.Replace("'", "''");
      sFouRefCli = sFouRefCli.Replace("'", "''");


      sUniquementStock = chkStock.Checked ? "O" : "T$";
      sFouPrixClient = chkClient.Checked ? mstrClient : "T$";
      miNumFournisseur = txtCritFour.GetItemData();
      if (miNumFournisseur == -1) miNumFournisseur = 0;

      // Au moins un filtre doit être renseigné
      if ((sFouSer == "T$") && (sFouMat == "T$") && (sFouMar == "T$") && (sFouRef == "T$") && (sUniquementStock == "T$") &&
          (sFouPrixClient == "T$") && (miNumFournisseur == 0) && (sFouRefCli == "T$"))
      {
        MessageBox.Show(Resources.msg_must_type_filter, Program.AppTitle, MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
        return;
      }

      nCfoCod = (mstrStatut == "STOCK-CLIEXT") ? 31 : 0;
      lReq = $"exec api_sp_ListeDesFournituresCmd {miNumFournisseur}, {nCfoCod}, '{sFouSer}', '{sFouMat}', '{sFouMar}', '{sFouRef}', '{sUniquementStock}', '{sFouPrixClient}', '{sFouRefCli}'";
      apiTGrid1.LoadData(dtRS, MozartDatabase.cnxMozart, lReq);

      Cursor.Current = Cursors.Default;
    }

    private void frmRechercheArticlesCom_KeyUp(object sender, KeyEventArgs e)
    {
      if (e.KeyCode == Keys.F2 || e.KeyCode == Keys.Enter)
        cmdFind_Click(null, null);
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

      apiTGrid1.Requery(dtRS, MozartDatabase.cnxMozart);
    }
  }
}

