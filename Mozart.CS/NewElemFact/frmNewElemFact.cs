using Microsoft.VisualBasic;
using MozartCS.Properties;
using MozartLib;
using MozartNet;
using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Globalization;
using System.Reflection;
using System.Windows.Forms;
using MZUtils = MozartControls.Utils;
using MZCtrlResources = MozartControls.Properties.Resources;

namespace MozartCS
{
  public partial class frmNewElemFact : Form
  {
    public string mstrSite;
    public string mstrAction;
    public string mstrPrestation;
    public string mstrStatutAction = "";
    public string mstrStatutElemFact;
    public string mstrTypeFacturation;
    public long miNumElemFact;
    public long miNumClient;
    public long miNumSite;
    public bool mbClose = true;
    public bool mbRefresh = false;

    public bool mchkTSite;
    public bool mchkTE;

    private bool bModif = false;
    private bool bInfo = true;
    private int CodeUrgence = 0;
    private bool bTousSites = false;
    private DataTable dtArticles = new DataTable();

    class ItemAction
    {
      public int ID { get; set; }
      public string LIB { get; set; }
    }

    public frmNewElemFact() { InitializeComponent(); }


    private void frmNewElemFact_Load(object sender, System.EventArgs e)
    {
      try
      {
        ModuleMain.Initboutons(this);

        // recherche des taux de TVA autorisés pour cette société (FG le 05/08/2019)
        ModuleData.RemplirCombo(cboTVA, $"SELECT ID, TVA FROM TREF_TVA where VSOCIETE = '{MozartParams.NomSociete}' ORDER BY TVA");
        cboTVA.ValueMember = "ID";
        cboTVA.DisplayMember = "TVA";

        if (MozartParams.NomSociete == "EMALECSUISSE")
          Label2.Text = "CHF";

        // initialisation du tableau de recherche des articles
        InitRecordsetArticle();

        lstAction.ValueMember = "ID";
        lstAction.DisplayMember = "LIB";
        lstCot.ValueMember = "ID";
        lstCot.DisplayMember = "LIB";
        lstDevis.ValueMember = "ID";
        lstDevis.DisplayMember = "LIB";

        if (mstrStatutElemFact == "C")
        {
          OuvertureEnCreation();

          // On affiche le message si il y a des notes de frais sur la DI
          string sMsg = GetMessageNoteFraisDI(MozartParams.NumDi);
          if (sMsg != "")
            MessageBox.Show(sMsg, Program.AppTitle, MessageBoxButtons.OK, MessageBoxIcon.Exclamation);

          //FGA le 11 / 06 / 24
          // si site des JO, on affiche un message
          //DetailstravauxUtils.AffichageMessageJO2024(Convert.ToInt32(miNumSite));

        }
        else
          OuvertureEnModification();

      }
      catch (Exception ex)
      {
        MZUtils.displayError(MethodBase.GetCurrentMethod().Name, ex);
      }
    }

    private void cmdcmd_Click(object sender, EventArgs e)
    {
      new frmListeMatFact { mdtArticles = dtArticles, msNumDI = MozartParams.NumDi.ToString() }.ShowDialog();

      // remplir les montants totaux
      RemplirTxtTotaux();
    }

    private void OuvertureEnCreation()
    {
      try
      {
        //  affectation du recordset à la listbox
        //  recherche de toutes les actions non chiffrées (ne pas prendre si Etude/Devis)
        //  si tous sites, on ne prend que l'action sélectionnée sur le datagrid (si pas déjà chiffré ou plus)
        if (mchkTSite || mchkTE)
        {
          bTousSites = true;
          lstAction.Items.Add(new ItemAction() { LIB = mstrAction, ID = MozartParams.NumAction });
          //lstDevis.Items.Clear();
        }
        else
        {
          bTousSites = false;
          RemplirListeBox(lstAction, "api_sp_ListeActionsChiffrables", MozartParams.NumDi);
          RemplirListeBoxCo(lstCot, "api_sp_CotraitantsLstActionsChif", MozartParams.NumDi);
          RemplirListeBox(lstDevis, "api_sp_DevisLstActionsChif", MozartParams.NumDi);

          // verif de l'affichage fact par avancement
          bool bDevisPrest = VerifDevisPrest(MozartParams.NumDi, 0);
          cmdAvancement.Visible = cmdTotal.Visible = bDevisPrest;
          txtForfait.Enabled = !bDevisPrest;
        }

        //  si tous site et statut incorrect impossible de créer
        if (mchkTSite && (mstrStatutAction == "C" || mstrStatutAction == "F"))
          lstAction.Items.Clear();

        if (lstAction.Items.Count == 1)
          lstAction.SetItemChecked(0, true);

        //  Initialisation des contrôles
        // InitFeuille();

        //  Lier les textbox avec le recordset
        using (SqlDataReader dr = ModuleData.ExecuteReader($"exec api_sp_DetailFacturationDI {MozartParams.NumDi}, {miNumSite}"))
        {
          if (dr.Read())
          {
            txtClient.Text = dr["VCLINOM"].ToString();
            txtNumDI.Text = dr["NDIN"].ToString();
            txtDateDI.Text = Convert.ToDateTime(dr["DDINDAT"]).ToString("dd/MM/yyyy");
            txtHTDevis.Text = dr["DEVIS"].ToString();
            miNumClient = Convert.ToInt64(dr["NCLINUM"]);

            string sSql = $"IF (select count(ID) from TREF_COMPTEPRODUIT WHERE VSOCIETEFACT = '{MozartParams.NomSociete}' And NCLINUM = {miNumClient}) > 0 "
                        + $"select ID, VLIBELLE from TREF_COMPTEPRODUIT WHERE VSOCIETEFACT = '{MozartParams.NomSociete}' And NCLINUM = {miNumClient} order by VLIBELLE "
                        + $"ELSE select ID, VLIBELLE from TREF_COMPTEPRODUIT WHERE VSOCIETEFACT = '{MozartParams.NomSociete}' And NCLINUM = 0";

            //  Spécifique compte 96 (compte produit)
            if (((int)dr["NDINCTE"] == 96 || (int)dr["NDINCTE"] == 999 || (int)dr["NDINCTE"] == 997 || (int)dr["NDINCTE"] == 970 || (int)dr["NDINCTE"] == 994) && MozartParams.NomSociete == "EMALEC")
            {
              cboCompte.Init(MozartDatabase.cnxMozart, sSql, "ID", "VLIBELLE", new List<string>() { Resources.col_ID, MZCtrlResources.col_libelle }, 600, 400);
              lblCompteProduit.Visible = cboCompte.Visible = true;
            }

            //  spécifique compte 96 (compte produit)
            if (MozartParams.NomSociete == "EMALECDEV")
            {
              cboCompte.Init(MozartDatabase.cnxMozart, sSql, "ID", "VLIBELLE", new List<string>() { Resources.col_ID, MZCtrlResources.col_libelle }, 600, 400);
              lblCompteProduit.Visible = cboCompte.Visible = true;
            }

            //  recuperation du site
            //  cas tous sites, préventif, et forfait
            if (mchkTSite && mstrPrestation == "Préventif" && dr["CDINTYF"].ToString() == "FD")
              txtSite.Text = Resources.txt_tousSites;
            else
              txtSite.Text = mstrSite;

            txtPrest.Text = mstrPrestation;

            //  on est en création , donc on prend le type de facturation sur la DI
            //  selon le type de facturation
            if (dr["CDINTYF"].ToString() == "FD")
            {
              // forfait
              txtForfait.Visible = Label2.Visible = lblLabels4.Visible = true;
              lblLabels0.Visible = lblLabels1.Visible = txtNbrDep.Visible = txtNbrHeures.Visible = false;
              txtTauxDep.Visible = txtTauxHeures.Visible = lblA0.Visible = lblA1.Visible = false;

              // pas possible de mettre des fournitures
              fraFour.Visible = false;
            }
            else
            {
              lblLabels0.Visible = lblLabels1.Visible = txtNbrDep.Visible = txtNbrHeures.Visible = true;
              txtTauxDep.Visible = txtTauxHeures.Visible = lblA0.Visible = lblA1.Visible = true;
              txtForfait.Visible = Label2.Visible = lblLabels4.Visible = false;

              // possible de mettre des fournitures
              fraFour.Visible = true;

              // affichage des données MPM
              if (MozartParams.NomSociete == "EMALECMPM")
                fraMPM.Visible = true;
            }

            txtTauxDep.Text = dr["NCLICONTDEP"].ToString();
            txtTauxHeures.Text = dr["NCLICONTHOR"].ToString();
          }

          // initialisation du tableau de recherche des articles
          InitDataTableArticles();
        }
      }
      catch (Exception ex)
      {
        MZUtils.displayError(MethodBase.GetCurrentMethod().Name, ex);
      }
    }

    private void InitRecordsetArticle()
    {
      // La gestion des colonnes est faite par le LoadData
      FormatapiTGrid();
    }

    private void OuvertureEnModification()
    {
      try
      {
        // affectation du recordset aux ChecdListboxes
        RemplirListeBox(lstAction, "api_sp_RetourListeActionElemFact", miNumElemFact);
        RemplirListeBox(lstDevis, "api_sp_RetourDevisLstActionElemFact", miNumElemFact);
        RemplirListeBoxCo(lstCot, "api_sp_RetourCotraitantsLstActionsChif", miNumElemFact);

        bool bDevisPrest = VerifDevisPrest(0, miNumElemFact);
        cmdAvancement.Visible = cmdTotal.Visible = bDevisPrest;

        // Sélectionner la 1ère ligne
        if (lstAction.Items.Count > 0)
          lstAction.SetSelected(0, true);

        // Cocher toutes les lignes
        for (int i = 0; i < lstAction.Items.Count; i++)
          lstAction.SetItemChecked(i, true);

        // ouverture du recordset
        using (SqlDataReader dr = ModuleData.ExecuteReader($"api_sp_RetourInfoElemFact {miNumElemFact}"))
        {
          if (dr.Read())
          {
            txtClient.Text = dr["VCLINOM"].ToString();
            txtNumDI.Text = dr["NDIN"].ToString();
            txtDateDI.Text = Convert.ToDateTime(dr["DDINDAT"]).ToString();
            txtHTDevis.Text = dr["DEVIS"].ToString();

            miNumClient = (int)dr["NCLINUM"];

            // recuperation du site et de la prestation
            if (dr["CDINTS"].ToString() == "O" && dr["VPRELIB"].ToString() == Resources.col_preventif)
            {
              bTousSites = true;
              txtSite.Text = Resources.txt_tousSites;
            }
            else
            {
              bTousSites = false;
              txtSite.Text = dr["VSITNOM"].ToString();
            }
            txtPrest.Text = dr["VPRELIB"].ToString();

            // mise à jour des contrôles
            txtNbrDep.Text = Utils.ZeroIfNull(dr["NELFDEP"]).ToString();
            txtNbrHeures.Text = Utils.ZeroIfNull(dr["NELFHEU"]).ToString();
            txtTauxDep.Text = Strings.Format(Utils.BlankIfNull(dr["NELFTDE"]), "currency");
            txtTauxHeures.Text = Strings.Format(Utils.BlankIfNull(dr["NELFTHO"]), "currency");
            txtObserv.Text = Utils.BlankIfNull(dr["TELFOBS"]);
            txtFour.Text = Strings.Format(Utils.BlankIfNull(dr["NELFFOU"]), "currency");
            txtForfait.Text = Strings.Format(Utils.BlankIfNull(dr["NELFFOR"]), "currency");
            txtTauxTVA.Text = Utils.ZeroIfNull(dr["NELFTVA"]).ToString();
            // MPM
            txtNbrNuit.Text = Utils.BlankIfNull(dr["NELFNUIT"]);
            txtNbrRepas.Text = Utils.BlankIfNull(dr["NELFREPAS"]);
            txtNbrKm.Text = Utils.BlankIfNull(dr["NELFKM"]);
            txtTNuit.Text = Utils.BlankIfNull(dr["NELFTNUIT"]);
            txtTRepas.Text = Utils.BlankIfNull(dr["NELFTREPAS"]);
            txtTKm.Text = Utils.BlankIfNull(dr["NELFTKM"]);

            string sSql = $"select ID, VLIBELLE from TREF_COMPTEPRODUIT WHERE VSOCIETEFACT = '{MozartParams.NomSociete}' AND NCLINUM = {miNumClient} order by VLIBELLE";

            // spécifique compte 96 (compte produit)
            if (((int)dr["NDINCTE"] == 96 || (int)dr["NDINCTE"] == 999 || (int)dr["NDINCTE"] == 997 || (int)dr["NDINCTE"] == 970 || (int)dr["NDINCTE"] == 994) && MozartParams.NomSociete == "EMALEC")
            {
              cboCompte.Init(MozartDatabase.cnxMozart, sSql, "ID", "VLIBELLE", new List<string>() { Resources.col_ID, MZCtrlResources.col_libelle }, 600, 400, bHideFirstColumn: true);
              lblCompteProduit.Visible = cboCompte.Visible = true;
              cboCompte.SetItemData(Convert.ToInt32(Utils.ZeroIfNull(dr["IDCOMPTEPRODUIT"])));
            }

            // spécifique compte 96 (compte produit)
            if (MozartParams.NomSociete == "EMALECDEV")
            {
              cboCompte.Init(MozartDatabase.cnxMozart, sSql, "ID", "VLIBELLE", new List<string>() { Resources.col_ID, MZCtrlResources.col_libelle }, 600, 400, bHideFirstColumn: true);
              lblCompteProduit.Visible = cboCompte.Visible = true;
            }

            // on est en modification, donc on prend le type de facturation sur l'element de facturation : type de facture
            if (dr["CELFTYP"].ToString() == "DC")
            {
              txtNbrDep.Visible = txtNbrHeures.Visible = txtTauxDep.Visible = txtTauxHeures.Visible = lblA0.Visible = true;
              lblA1.Visible = lblLabels0.Visible = lblLabels1.Visible = true;
              txtForfait.Visible = Label2.Visible = lblLabels4.Visible = false;

              // possible de mettre des fournitures
              fraFour.Visible = true;

              // affichage des données MPM
              if (MozartParams.NomSociete == "EMALECMPM")
                fraMPM.Visible = true;
            }
            else
            {
              txtNbrDep.Visible = txtNbrHeures.Visible = txtTauxDep.Visible = txtTauxHeures.Visible = false;
              lblA0.Visible = lblA1.Visible = lblLabels0.Visible = lblLabels1.Visible = false;
              txtForfait.Visible = Label2.Visible = lblLabels4.Visible = true;
              // pas de fournitures
              fraFour.Visible = false;
            }

            if (dr["CELFTYP"].ToString() == "AV")
            {
              if (lstDevis.Items.Count > 0)
                lstDevis.SetItemChecked(0, true);
              cmdAvancement.BackColor = MozartColors.ColorH80FFFF;
              txtForfait.Enabled = false;
            }
            else
            {
              cmdAvancement.BackColor = MozartColors.ColorH8000000F;
              txtForfait.Enabled = true;
              txtForfait.Enabled = !bDevisPrest;
            }

            // initialisation du recordset local des articles
            //InitRecordsetArticle();
            InitDataTableArticles();

            // type de fourniture
            if (dr["CELFTFO"].ToString() == "D")
            {
              optFour0.Checked = true;

              // remplir les montants totaux
              RemplirTxtTotaux();

              lblEuro.Visible = txtFour.Visible = false;
              frameSearch.Visible = true;
            }
            else
            {
              optFour1.Checked = lblEuro.Visible = txtFour.Visible = true;
              frameSearch.Visible = false;
            }
          }
        }
      }
      catch (Exception ex)
      {
        MZUtils.displayError(MethodBase.GetCurrentMethod().Name, ex);
      }
    }

    private void InitDataTableArticles()
    {
      ModuleData.LoadData(dtArticles, $"api_sp_RetourArticlesElemFact {miNumElemFact}", MozartDatabase.cnxMozart);

      // Ajout de 2 colonnes pour les checkboxes + initialisation à leur bonne valeur
      dtArticles.Columns.Add("colImmo", typeof(bool));
      dtArticles.Columns.Add("colStock", typeof(bool));
      dtArticles.Columns.Add("oldPrix", typeof(double));
      foreach (DataRow item in dtArticles.Rows)
      {
        item["colStock"] = Convert.ToInt32(item["NSTOCKNUM"]) > 0;
        item["colImmo"] = item["BIMMO"];
        item["oldPrix"] = item["Prix"];
      }

      apiTGridB.GridControl.DataSource = dtArticles;
    }


    /* OK ----------------------------------------------------------------------------------------------*/
    // Le champ Quantite n'est pas modifiable !!!
    //Private Sub apiTGridB_AfterColUpdate(ColIndex As Integer)
    //  If rsarticle!Quantite.OriginalValue <> rsarticle!Quantite.value Then rsarticle!Status = "MOD"
    //End Sub

    /* OK ----------------------------------------------------------------------------------------------*/
    private void lstAction_ItemCheck(object sender, ItemCheckEventArgs e)
    {
      cmdFluides.BackColor = MozartColors.ColorH8000000F;

      if (lstDevis.Items.Count > e.Index)
        lstDevis.SetItemChecked(e.Index, e.NewValue == CheckState.Checked);

      if (mstrStatutElemFact == "C")
      {
        lstAction.SelectedIndex = 0;
        txtTauxTVA.Text = RechercheTauxDeTVA((int)((ItemAction)lstAction.SelectedItem).ID).ToString();
      }

      // Pour déclencher le timer de recherche de cotraitant imposé et des certificats fluides frigo
      if (e.NewValue == CheckState.Checked)
        bInfo = true;
    }

    private void optFournitures_Forfait_Click(object sender, EventArgs e)
    {
      if ((sender as Control).Name == "optFour0")
      {
        frameSearch.Visible = true;
        lblEuro.Visible = txtFour.Visible = false;
      }
      else
      {
        frameSearch.Visible = false;
        lblEuro.Visible = txtFour.Visible = true;
      }
    }

    private void Timer1_Tick(object sender, EventArgs e)
    {
      if (!bInfo) return;
      bInfo = false;

      // ' recherche si on a un cotraitant imposé
      foreach (ItemAction item in lstAction.CheckedItems)
      {
        if (Utils.RechercheCotraitantAct((int)item.ID))
        {
          MessageBox.Show(Resources.msg_cotraitant_impose + "\r\n\r\n" + RechercheInfoClient(), Program.AppTitle, MessageBoxButtons.OK, MessageBoxIcon.Warning);
          break;
        }

        // recherche si certifcat fluide exists
        if (Utils.RechercheCertificatFluideFrigoExists((int)item.ID) == true)
        {
          cmdFluides.BackColor = MozartColors.ColorH80FFFF;
          break;
        }
        else
          cmdFluides.BackColor = MozartColors.ColorH8000000F;
      }
    }
    
    private void txtNbrHeures_txtNbrDep_KeyPress(object sender, KeyPressEventArgs e)
    {
      KeyValidator.KeyPress_SaisieNombre(e);
    }

    private void txtTauxHeures_txtFour_txtForfait_txtTauxDep_KeyPress(object sender, KeyPressEventArgs e)
    {
      KeyValidator.KeyPress_SaisieMontant(e);
    }

    /* OK ----------------------------------------------------------------------------------------------*/
    private void EnregistrerElemFact()
    {
      //  On verifie s'il n'existe pas de facturation par avancement sur cette action
      //  si c'est le cas, obligation de facture par avancement
      string sSql = $"SELECT COUNT(*) FROM TAVANCEMENT WITH (NOLOCK) WHERE NACTNUMBASE = {(lstAction.CheckedItems[0] as ItemAction).ID}";
      if ((int)ModuleData.ExecuteScalarInt(sSql) > 0)
      {
        MessageBox.Show(Resources.msg_avancement_existant_action, Program.AppTitle, MessageBoxButtons.OK);
        return;
      }

      //  Si astreinte, on recherche le jour d'exec
      if (CodeUrgence == 4 && miNumElemFact == 0)
      {
        DateTime dDateAct;
        foreach (ItemAction item in lstAction.CheckedItems)
        {
          string sDateAct = ModuleData.ExecuteScalarString($"select DACTDEX from TACT WITH (NOLOCK) where NACTNUM = {item.ID}");
          if (sDateAct == "")
          {
            MessageBox.Show("Vous devez saisir la date d'éxecution de l'action avant de la chiffrer", Program.AppTitle, MessageBoxButtons.OK);
            return;
          }
          else
            dDateAct = Convert.ToDateTime(sDateAct);

          sSql = $"Select C.NCLINUM, C.NCLICONTHORNUIDIM, C.NCLICONTHORSAM, C.NCLICONTHOR from TCLIPRIXTYPCONT C WITH (NOLOCK), TDIN D WITH (NOLOCK)," +
                 $" TACT A WITH (NOLOCK), TSIT S WITH (NOLOCK) where C.NCLINUM = D.NCLINUM and A.NDINNUM= D.NDINNUM and S.NSITNUM=A.NSITNUM" +
                 $" and C.VPAYS = S.VSITPAYS and A.NACTNUM = {item.ID} AND C.NTYPECONTRAT = D.NTYPECONTRAT";

          using (SqlDataReader dr = ModuleData.ExecuteReader(sSql))
          {
            // si le jour d'execution est un samedi et heure exécution comprise entre 8h et 18h
            dr.Read();
            if (dDateAct.DayOfWeek == DayOfWeek.Saturday && Testif_8h_At_18h(dDateAct))
              txtTauxHeures.Text = (Utils.ZeroIfNull(dr["NCLICONTHOR"]) * Utils.ZeroIfNull(dr["NCLICONTHORSAM"])).ToString();
            // Sinon on prend dans tous les cas le taux horaire nuit/dimanche
            else
              txtTauxHeures.Text = (Utils.ZeroIfNull(dr["NCLICONTHOR"]) * Utils.ZeroIfNull(dr["NCLICONTHORNUIDIM"])).ToString();
            // Pour APPLE taux horaires pour nuit/dimanche et Samedi entre 8h et 18h = 135 € HT
            // TB SAMSIC CITY SPEC
            if (Utils.ZeroIfNull(dr["NCLINUM"]) == 6859 && MozartParams.NomGroupe == "EMALEC")
              txtTauxHeures.Text = "135";
          }
        }
      }

      // création d'une commande
      using (SqlCommand cmd = new SqlCommand("api_sp_creationElemFact", MozartDatabase.cnxMozart))
      {
        cmd.CommandType = CommandType.StoredProcedure;
        SqlCommandBuilder.DeriveParameters(cmd);    // liste des paramètres

        cmd.Parameters["@iNumElemFact"].Value = miNumElemFact;
        cmd.Parameters["@iDI"].Value = MozartParams.NumDi;
        cmd.Parameters["@nForfait"].Value = (txtForfait.Text == "") ? 0 : Double.Parse(txtForfait.Text, NumberStyles.Currency);
        cmd.Parameters["@nDepl"].Value = txtNbrDep.Text == "" ? 0 : Convert.ToInt32(txtNbrDep.Text);
        cmd.Parameters["@iHeures"].Value = txtNbrHeures.Text == "" ? 0 : Convert.ToInt32(txtNbrHeures.Text);
        cmd.Parameters["@TauxDepl"].Value = (txtTauxDep.Text == "") ? 0 : Double.Parse(txtTauxDep.Text, NumberStyles.Currency);
        cmd.Parameters["@TauxHeures"].Value = (txtTauxHeures.Text == "") ? DBNull.Value : (object)Double.Parse(txtTauxHeures.Text, NumberStyles.Currency);
        cmd.Parameters["@vObserv"].Value = txtObserv.Text == "" ? DBNull.Value : (object)txtObserv.Text;
        cmd.Parameters["@cTypeFour"].Value = optFour0.Checked ? "D" : "F";
        // pour les fournitures, selon le cas forfait ou detail
        if (optFour1.Checked)
          cmd.Parameters["@nFour"].Value = (txtFour.Text == "") ? 0 : Double.Parse(txtFour.Text, NumberStyles.Currency);
        else
          cmd.Parameters["@nFour"].Value = (txtHT.Text == "") ? 0 : Double.Parse(txtHT.Text, NumberStyles.Currency);
        cmd.Parameters["@TVA"].Value = Convert.ToDouble(txtTauxTVA.Text);

        //  Spécifique MPM
        cmd.Parameters["@nNuitee"].Value = txtNbrNuit.Text == "" ? DBNull.Value : (object)txtNbrNuit.Text;
        cmd.Parameters["@nRepas"].Value = txtNbrRepas.Text == "" ? DBNull.Value : (object)txtNbrRepas.Text;
        cmd.Parameters["@nKM"].Value = txtNbrKm.Text == "" ? DBNull.Value : (object)txtNbrKm.Text;
        cmd.Parameters["@nTRepas"].Value = txtTNuit.Text == "" ? DBNull.Value : (object)txtTNuit.Text;
        cmd.Parameters["@nTNuitee"].Value = txtTRepas.Text == "" ? DBNull.Value : (object)txtTRepas.Text;
        cmd.Parameters["@nTKM"].Value = txtTKm.Text == "" ? DBNull.Value : (object)txtTKm.Text;
        cmd.Parameters["@nCompteProduit"].Value = cboCompte.GetItemData();

        cmd.ExecuteNonQuery();
        // récupération du numéro crée
        miNumElemFact = (int)cmd.Parameters[0].Value;

        //  Mise à jour des lignes Actions concernées avec le numéro d'élément de facture
        for (int i = 0; i < lstAction.Items.Count; i++)
          ModuleData.ExecuteNonQuery($"api_sp_UpdateActionElemFact {miNumElemFact}, {((ItemAction)lstAction.Items[i]).ID}, {(lstAction.GetItemChecked(i) ? 1 : 0)}");

        //  traitement des articles sélectionnés - on supprime tous les articles de la table
        ModuleData.ExecuteNonQuery($"Delete from TFFA where NELFNUM = {miNumElemFact}");
        if (optFour0.Checked)
        {
          // on parcourt le recordset des articles si il y en a
          foreach (DataRow row in dtArticles.Rows)
            EnregistrerArticle(row);
        }

        //  Affichage du coef de la DI
        Cursor.Current = Cursors.WaitCursor;
        frmAlerteCoef f = new frmAlerteCoef();
        f.ShowDialog();
        mbClose = f.frmNewElemFactbClose;
        Cursor.Current = Cursors.Default;

        mstrStatutElemFact = "M";
      }
    }

    private void EnregistrerElemFactTousSites()
    {
      string sSql = "";
      double? TxHoraires = null;

      try
      {
        //on récupère le taux horaires en astreinte
        if (CodeUrgence == 4 && miNumElemFact == 0)
        {
          DateTime dDateAct;
          foreach (ItemAction item in lstAction.CheckedItems)
          {
            string sDateAct = ModuleData.ExecuteScalarString($"select DACTDEX from TACT WITH (NOLOCK) where NACTNUM = {item.ID}");
            if (sDateAct == "")
            {
              MessageBox.Show("Vous devez saisir la date d'éxecution de l'action avant de la chiffrer", Program.AppTitle, MessageBoxButtons.OK);
              return;
            }
            else
              dDateAct = Convert.ToDateTime(sDateAct);

            sSql = $"Select C.NCLINUM, C.NCLICONTHORNUIDIM, C.NCLICONTHORSAM, C.NCLICONTHOR from TCLIPRIXTYPCONT C WITH (NOLOCK), TDIN D WITH (NOLOCK)," +
                   $" TACT A WITH (NOLOCK), TSIT S WITH (NOLOCK) where C.NCLINUM = D.NCLINUM and A.NDINNUM= D.NDINNUM and S.NSITNUM=A.NSITNUM" +
                   $" and C.VPAYS = S.VSITPAYS and A.NACTNUM = {item.ID} AND C.NTYPECONTRAT = D.NTYPECONTRAT";

            using (SqlDataReader dr = ModuleData.ExecuteReader(sSql))
            {
              // si le jour d'execution est un samedi et heure exécution comprise entre 8h et 18h
              dr.Read();
              if (dDateAct.DayOfWeek == DayOfWeek.Saturday && Testif_8h_At_18h(dDateAct))
                TxHoraires = (Utils.ZeroIfNull(dr["NCLICONTHOR"]) * Utils.ZeroIfNull(dr["NCLICONTHORSAM"]));
              // Sinon on prend dans tous les cas le taux horaire nuit/dimanche
              else
                TxHoraires = (Utils.ZeroIfNull(dr["NCLICONTHOR"]) * Utils.ZeroIfNull(dr["NCLICONTHORNUIDIM"]));
              // Pour APPLE taux horaires pour nuit/dimanche et Samedi entre 8h et 18h = 135 € HT
              // TB SAMSIC CITY SPEC
              if (Utils.ZeroIfNull(dr["NCLINUM"]) == 6859 && MozartParams.NomGroupe == "EMALEC")
                TxHoraires = 135;
            }
          }
        }
        else
        {
          //TxHoraires = double.Parse(Utils.ZeroIfNull(txtTauxHeures.Text), NumberStyles.Currency);
          TxHoraires = (txtTauxHeures.Text == "") ? 0 : Double.Parse(txtTauxHeures.Text, NumberStyles.Currency);
        }


        using (SqlCommand cmd = new SqlCommand("api_sp_creationElemFactTousSites", MozartDatabase.cnxMozart))
        {
          cmd.CommandType = CommandType.StoredProcedure;
          SqlCommandBuilder.DeriveParameters(cmd);    // liste des paramètres

          //  liste des paramètres
          cmd.Parameters["@iNumElemFact"].Value = miNumElemFact;
          cmd.Parameters["@iDI"].Value = MozartParams.NumDi;
          cmd.Parameters["@iAction"].Value = MozartParams.NumAction;
          cmd.Parameters["@nForfait"].Value = (txtForfait.Text == "") ? 0 : Double.Parse(txtForfait.Text, NumberStyles.Currency);
          cmd.Parameters["@nDepl"].Value = txtNbrDep.Text == "" ? 0 : Convert.ToInt32(txtNbrDep.Text);
          cmd.Parameters["@iHeures"].Value = txtNbrHeures.Text == "" ? 0 : Convert.ToInt32(txtNbrHeures.Text);
          cmd.Parameters["@TauxDepl"].Value = (txtTauxDep.Text == "") ? 0 : Double.Parse(txtTauxDep.Text, NumberStyles.Currency);
          cmd.Parameters["@TauxHeures"].Value = (txtTauxHeures.Text == "") ? DBNull.Value : (object)TxHoraires;
          cmd.Parameters["@vObserv"].Value = txtObserv.Text;
          cmd.Parameters["@cTypeFour"].Value = optFour0.Checked ? "D" : "F";
          // pour les fournitures, cas forfait ou detail
          if (optFour1.Checked)
            cmd.Parameters["@nFour"].Value = (txtFour.Text == "") ? 0 : (object)Double.Parse(txtFour.Text, NumberStyles.Currency);
          else
            cmd.Parameters["@nFour"].Value = (txtHT.Text == "") ? 0 : (object)Double.Parse(txtHT.Text, NumberStyles.Currency);
          cmd.Parameters["@TVA"].Value = txtTauxTVA.Text;

          cmd.ExecuteNonQuery();
          // récupération du numéro crée
          miNumElemFact = (int)cmd.Parameters[0].Value;

          //  ' traitement des articles sélectionnés
          if (optFour0.Checked)
          {
            // On supprime tous les articles de la table
            ModuleData.ExecuteNonQuery($"delete from TFFA where NELFNUM = {miNumElemFact}");

            // On parcourt le recordset des articles si il y en a
            foreach (DataRow item in dtArticles.Rows)
              EnregistrerArticle(item);
          }

          // On passe la feuille en statut Modifié
          mstrStatutElemFact = "M";
        }
      }
      catch (Exception ex)
      {
        MZUtils.displayError(MethodBase.GetCurrentMethod().Name, ex);
      }

    }

    private void EnregistrerArticle(DataRow rowArt)
    {
      using (SqlCommand cmd = new SqlCommand("api_sp_creationLigneArtElemFact", MozartDatabase.cnxMozart))
      {
        cmd.CommandType = CommandType.StoredProcedure;
        SqlCommandBuilder.DeriveParameters(cmd);    // liste des paramètres

        //  liste des paramètres
        cmd.Parameters["@iNumElemFact"].Value = miNumElemFact;
        cmd.Parameters["@iNumArticle"].Value = rowArt["NumArticle"];
        cmd.Parameters["@iQte"].Value = rowArt["Quantite"];
        cmd.Parameters["@nMontant"].Value = Convert.ToDouble(rowArt["prix"]) * Convert.ToDouble(rowArt["Quantite"]);
        cmd.Parameters["@nRecyclage"].Value = Convert.ToDouble(rowArt["recyclage"]);
        cmd.Parameters["@nCoeff"].Value = Convert.ToDouble(rowArt["CoefClient"]);
        cmd.Parameters["@bStock"].Value = (bool)rowArt["colStock"] ? 1 : 0;
        cmd.Parameters["@bImmo"].Value = (bool)rowArt["colImmo"] ? 1 : 0;

        cmd.ExecuteNonQuery();
      }
    }

    public void FormatapiTGrid()
    {
      apiTGridB.AddColumn(Resources.col_stock, "colStock", 400);
      apiTGridB.AddColumn("Immo", "colImmo", 400);

      apiTGridB.AddColumn(Resources.col_Serie, "Serie", 1200);
      apiTGridB.AddColumn(Resources.col_materiel, "Article", 1900);
      apiTGridB.AddColumn(Resources.col_marque, "Marque", 1200);
      apiTGridB.AddColumn(Resources.col_recyclage, "Recyclage", 500, "Currency", 1);
      apiTGridB.AddColumn(Resources.col_prixU, "Prix", 500, "Currency", 1);
      apiTGridB.AddColumn(Resources.col_Fournisseur, "Fournisseurs", 0);
      apiTGridB.AddColumn(Resources.col_Qte, "Quantite", 500, "", 2);
      apiTGridB.AddColumn(Resources.col_num_four, "NumFour", 0);
      apiTGridB.AddColumn(Resources.col_NumArticle, "NumArticle", 0);

      apiTGridB.DelockColumn("colStock");
      apiTGridB.DelockColumn("colImmo");

      apiTGridB.FilterBar = false;
      apiTGridB.InitColumnList();
    }

    private void cmdEnregistrer_Click(object sender, EventArgs e)
    {
      int bOK = 0;

      // ' on ne peut cliquer que sur une seule action
      // ' traitement des actions
      foreach (ItemAction item in lstAction.CheckedItems)
      {
        bOK++;
        CodeUrgence = RechercheCode(Convert.ToInt64(item.ID));
      }

      if (bOK == 0)
      {
        MessageBox.Show(Resources.msg_cocher_une_coche, Program.AppTitle, MessageBoxButtons.OK, MessageBoxIcon.Information);
        return;
      }
      else if (bOK > 1)
      {
        MessageBox.Show(Resources.msg_cocher_une_seule_coche, Program.AppTitle, MessageBoxButtons.OK, MessageBoxIcon.Information);
        return;
      }

      //  'vérification si une personne bloque l'action
      if (VerifIfPerBlock(bTousSites))
        return;

      // FG le  30/06/20 spécifique compte 96 (compte produit)
      if (lblCompteProduit.Visible && (MozartParams.NomSociete == "EMALEC" || MozartParams.NomSociete == "EMALECDEV") && cboCompte.GetText() == "")
      {
        MessageBox.Show("Il faut choisir un compte de produit sur ce chiffrage", Program.AppTitle, MessageBoxButtons.OK, MessageBoxIcon.Information);
        return;
      }

      if (txtForfait.Visible)
      {
        if (txtForfait.Text == "")
        {
          MessageBox.Show(Resources.msg_montant_forfait_obligatoire, Program.AppTitle, MessageBoxButtons.OK, MessageBoxIcon.Information);
          return;
        }
      }
      else
      {
        if (txtNbrHeures.Text == "")
        {
          MessageBox.Show(Resources.msg_nombre_heures_facturation_obligatoire, Program.AppTitle, MessageBoxButtons.OK, MessageBoxIcon.Information);
          return;
        }
      }

      //  Test tva à zero
      if (txtTauxTVA.Text == "0")
      {
        if (MessageBox.Show("Vous souhaitez créer un chiffrage pour lequel la TVA est égale à zéro.\r\nCette situation est exceptionnelle.\r\n"
              + "Souhaitez-vous réellement créer ce chiffrage avec une TVA à zéro ?", Program.AppTitle, MessageBoxButtons.YesNo, MessageBoxIcon.Question, MessageBoxDefaultButton.Button2) == DialogResult.No)
          return;
      }

      // Si on arrive jusque là, on enregistre les informations
      //  ' cas de tous sites, préventif, forfait la gestion est dans la proc stock
      if (bTousSites)
        EnregistrerElemFactTousSites();
      else
        EnregistrerElemFact();

      mbRefresh = true;
      bModif = false;
      if (mbClose)
        Dispose();
    }
    //Private Sub cmdEnregistrer_Click()
    //    
    // Dim bOK As Integer
    // Dim i As Integer
    //   
    // ' on ne peut cliquer que sur une seule action
    //  ' traitement des actions
    //  bOK = 0
    //  For i = 0 To lstAction.ListCount - 1
    //   If lstAction.Selected(i) = True Then
    //     bOK = bOK + 1
    //     CodeUrgence = rechercheCode(lstAction.ItemData(i))
    //'     Exit For
    //   End If
    //  Next
    //  If bOK = 0 Then
    //   MsgBox "§Il faut cocher UNE action§", vbInformation
    //   Exit Sub
    //  ElseIf bOK > 1 Then
    //   MsgBox "§Il faut cocher UNE SEULE action§", vbInformation
    //   Exit Sub
    //  End If
    //  
    //  'vérification si une personne bloque l'action
    //  If VerifIfPerBlock(bTousSites) = True Then Exit Sub
    //  
    //  ' FG le 30/11/2012 : CodeUrgence au dessus
    //  ' controle la compatibilité des actions selectionnées
    //''  If Not ControleUrgence Then Exit Sub
    // 
    // ' FG le  30/06/20 spécifique compte 96 (compte produit)
    //  If lblCompteProduit.Visible = True And gstrNomSociete = "EMALEC" And cboCompte.Text = "" Then
    //      MsgBox "Il faut choisir un compte de produit sur ce chiffrage", vbInformation
    //      Exit Sub
    //  End If
    // ' FG le  28/09/20 spécifique compte 96 (compte produit)
    //  If lblCompteProduit.Visible = True And gstrNomSociete = "EMALECDEV" And cboCompte.Text = "" Then
    //      MsgBox "Il faut choisir un compte de produit sur ce chiffrage", vbInformation
    //      Exit Sub
    //  End If
    //  
    //  If txtForfait.Visible Then
    //    If txtForfait = "" Then
    //      MsgBox "§Il faut donner un montant pour le forfait§", vbInformation
    //      Exit Sub
    //    End If
    //  Else
    //    If txtNbrHeures = "" Then
    //      MsgBox "§Il faut donner un nombre d'heures pour la facturation§", vbInformation
    //      Exit Sub
    //    End If
    //  End If
    //  
    //  ' test tva à zero
    //  If txtTauxTVA = 0 Then
    //    If MsgBox("Vous souhaitez créer un chiffrage pour lequel la TVA est égale à zéro. " & vbCrLf & "Cette situation est exceptionnelle. " & vbCrLf & "Souhaitez-vous réellement créer ce chiffrage avec une TVA à zéro ? ", vbYesNo + vbQuestion + vbDefaultButton2) = vbNo Then Exit Sub
    //  End If
    //  
    //  ' si on arrive jusque là, on enregistre les informations
    //  ' cas de tous sites, préventif, forfait la gestion est dans la proc stock
    //  If bTousSites Then
    //    
    //'    'client kiko, droite exclu cavallaro (voir a qui l'attribué par la suite)
    //'    ' TB SAMSIC CITY SPEC
    //'    If txtDI(0).Text = "KIKO" And gintUID = 612 And gstrNomGroupe = "Emalec" Then
    //'
    //'        If MsgBox("Attention, vous allez créer des chiffrages à 0 ! Voulez-vous continuer ?", vbYesNoCancel, "") = vbYes Then
    //'            Call EnregistrerElemFactTousSites_a_ZERO
    //'        Else
    //'            Call EnregistrerElemFactTousSites
    //'        End If
    //'
    //'    Else
    //        Call EnregistrerElemFactTousSites
    //'    End If
    //      
    //  Else
    //    Call EnregistrerElemFact
    //  End If
    //    
    //  gbRefresh = True
    //  bModif = False
    //  If bClose Then Unload Me
    //  
    //End Sub

    /* OK ----------------------------------------------------------------------------------------------*/
    private void cmdRechercher_Click(object sender, EventArgs e)
    {
      Cursor.Current = Cursors.WaitCursor;
      int iNumCli = (int)ModuleData.ExecuteScalarInt($"SELECT NCLINUM from TDIN WITH (NOLOCK) where TDIN.NDINNUM = {Strings.Mid(txtNumDI.Text, 3)}");
      frmRechercheFournitures f = new frmRechercheFournitures
      {
        mdtArticle = dtArticles,
        miNumClient = iNumCli
      };
      f.ShowDialog();

      if (f.DialogResult == DialogResult.OK) bModif = true;
      dtArticles = f.mdtArticle;
      apiTGridB.GridControl.DataSource = dtArticles;

      RemplirTxtTotaux();
      Cursor.Current = Cursors.Default;
    }

    private void RemplirTxtTotaux()
    {
      double dTotal = 0;
      foreach (DataRow item in dtArticles.Rows)
        dTotal += (Convert.ToDouble(item["Prix"]) * Convert.ToDouble(item["Quantite"])) + (Convert.ToDouble(item["Recyclage"]) * Convert.ToDouble(item["Quantite"]));

      txtHT.Text = Strings.Format(dTotal, "currency");
      txtTVA.Text = Strings.Format(dTotal * (MozartParams.TVA1 / 100), "currency");
      txtTTC.Text = Strings.Format(dTotal + (dTotal * (MozartParams.TVA1 / 100)), "currency");
    }

    private void frmNewElemFact_KeyPress(object sender, KeyPressEventArgs e)
    {
      bModif = true;
    }

    private void cmdFermer_Click(object sender, System.EventArgs e)
    {
      if (bModif)
      {
        switch (MessageBox.Show(Resources.msgConfirm_enregistrerModif, Program.AppTitle, MessageBoxButtons.YesNoCancel, MessageBoxIcon.Question, MessageBoxDefaultButton.Button2))
        {
          case DialogResult.Yes:
            cmdEnregistrer_Click(null, null);
            Dispose();
            break;
          case DialogResult.No:
            Dispose();
            break;
          case DialogResult.Cancel:
            return;
        }
      }
      else
        Dispose();
    }

    private int RechercheCode(long iAction)
    {
      return (int)ModuleData.ExecuteScalarInt($"select CURGCOD from TACT WITH (NOLOCK) WHERE NACTNUM = {iAction}");
    }

    private string RechercheInfoClient()
    {
      string sRet = "";
      ModuleMain.Infos infoClient = ModuleMain.RechercheInfos("INFO_CLIENT", miNumClient);
      if (infoClient.DateValDeb < DateTime.Now && infoClient.DateValFin > DateTime.Now)
        sRet = infoClient.strInfo;
      return sRet;
    }

    public void RemplirListeBox(ListBox lstBox, string sVue, long NumDI)
    {
      using (SqlDataReader dr = ModuleData.ExecuteReader($"{sVue} {NumDI}"))
      {
        while (dr.Read())
          lstBox.Items.Add(new ItemAction() { ID = Convert.ToInt32(dr[0]), LIB = dr[1].ToString().Replace("\r\n", " ") });
      }
    }

    public void RemplirListeBoxCo(ListBox lstbox, string sVue, long NumDI)
    {
      using (SqlDataReader dr = ModuleData.ExecuteReader(sVue + " " + NumDI.ToString()))
      {
        while (dr.Read())
        {
          if (dr["VSTIMPOSE"].ToString() == "OUI")
            lstbox.Items.Add(new ItemAction() { ID = Convert.ToInt32(dr[0]), LIB = dr[1].ToString() });
          else
            lstbox.Items.Add(new ItemAction() { ID = 0, LIB = " " });
        }
      }
    }

    private void cmdAvancement_Click(object sender, EventArgs e)
    {
      //  On ne peut faire une facturation par avancement que s'il existe un devis prestation ou  si un avancement a déjà été saisi
      if (lstDevis.CheckedItems.Count != 1)
      {
        MessageBox.Show(Resources.msg_must_select_devis, Program.AppTitle, MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
        return;
      }

      //  En creation, on ne peut créer un avancement que si le dernier est facturé ou si il n'y en a jamais eu
      int iNumActbase = (lstDevis.CheckedItems[0] as ItemAction).ID;

      string sSql = $"SELECT COUNT(*) FROM TFAC WITH (NOLOCK) WHERE NELFNUM in (SELECT TOP 1 MAX(NELFNUM) FROM TAVANCEMENT WITH (NOLOCK) WHERE NACTNUMBASE = " +
                    $"{iNumActbase} AND NELFNUM <> {miNumElemFact})";

      if ((int)ModuleData.ExecuteScalarInt(sSql) == 0)
      {
        // On verifie qu'il y a bien un avancement
        sSql = $"SELECT NELFNUM FROM TAVANCEMENT WITH (NOLOCK) WHERE NACTNUMBASE = {iNumActbase} AND NELFNUM <> {miNumElemFact} ORDER BY NELFNUM DESC";
        object o = ModuleData.ExecuteScalarObject(sSql);
        if (null != o)
        {
          int nElfNum = Convert.ToInt32(o);
          if (nElfNum > miNumElemFact)
            MessageBox.Show(Resources.msg_avancement_cree_modif_impossible, Program.AppTitle, MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
          else if (nElfNum < miNumElemFact)
            MessageBox.Show(Resources.msg_avancement_doit_etre_facturee_avant_nouveau, Program.AppTitle, MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
          return;
        }
      }

      bool bClose = false;
      foreach (ItemAction item in lstDevis.CheckedItems)
      {
        sSql = $"SELECT ISNULL(NDCLNUM, 0) FROM TDCL WITH (NOLOCK) WHERE (NACTNUM = {item.ID} OR NACTNUM IN (" +
               $"SELECT DISTINCT NACTNUMBASE FROM TAVANCEMENT WITH (NOLOCK) WHERE NACTNUMCRE = {item.ID} )) AND CDEVISTYPE = 'P'";

        object oNumDevis = ModuleData.ExecuteScalarObject(sSql);
        if (oNumDevis != null)
        {
          if (Convert.ToInt32(oNumDevis) > 0)
          {
            frmFactAvancement f = new frmFactAvancement();
            f.miDevisNum = Convert.ToInt32(oNumDevis);
            f.miNumElf = miNumElemFact;
            f.ShowDialog();
            bClose = true;
            break;
          }
          else
            MessageBox.Show(Resources.msg_devis_doit_etre_type_prestation, Program.AppTitle, MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
        }
        else
          MessageBox.Show(Resources.msg_aucun_devis_prestation_selectionne, Program.AppTitle, MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
      }
      if (bClose) Dispose();
    }
    //Private Sub cmdAvancement_Click()
    //Dim rsDevisPrest As ADODB.Recordset
    //Dim rsFact As ADODB.Recordset
    //Dim sSQL As String
    //Dim i As Integer
    //
    //  ' on ne peut faire une facturation par avancement que s'il existe un devis prestation ou  si un avancement a déjà été saisi
    //  If lstDevis.SelCount > 1 Or lstDevis.SelCount = 0 Then
    //    MsgBox "§Vous devez sélectionner un devis§"
    //    Exit Sub
    //  End If
    //  
    //  ' en creation, on ne peut creer un avancement que si le dernier est facturé
    //  ' ou si il n'y en a jamais eu
    //  sSQL = "SELECT COUNT(*) FROM TFAC WITH (NOLOCK) WHERE NELFNUM in (SELECT TOP 1 MAX(NELFNUM) FROM TAVANCEMENT WITH (NOLOCK) WHERE NACTNUMBASE = " & lstDevis.ItemData(lstDevis.ListIndex) & " AND NELFNUM <> " & miNumElemFact & ")"
    //  Set rsFact = New ADODB.Recordset
    //  rsFact.Open sSQL, cnx
    //  If rsFact(0) = 0 Then
    //    ' on verifie quil y a bien un avancement
    //    sSQL = "SELECT NELFNUM FROM TAVANCEMENT WITH (NOLOCK) WHERE NACTNUMBASE = " & lstDevis.ItemData(lstDevis.ListIndex) & " AND NELFNUM <> " & miNumElemFact & " ORDER BY NELFNUM DESC"
    //    rsFact.Close
    //    rsFact.Open sSQL, cnx
    //    If rsFact.RecordCount > 0 Then
    //      If rsFact("NELFNUM") > miNumElemFact Then
    //        MsgBox "§L'avancement suivant a déjà été crée, modification impossible.§"
    //      ElseIf rsFact("NELFNUM") < miNumElemFact Then
    //        MsgBox "§Le dernier avancement doit être facturé pour en créer un nouveau.§"
    //      End If
    //      rsFact.Close
    //      Exit Sub
    //    End If
    //  End If
    //  rsFact.Close
    //  
    //  For i = 0 To lstDevis.ListCount - 1
    //    If lstDevis.Selected(i) Then
    //      sSQL = "SELECT ISNULL(NDCLNUM,0) FROM TDCL WITH (NOLOCK) WHERE (NACTNUM = " & lstDevis.ItemData(i) & " OR NACTNUM IN (SELECT DISTINCT NACTNUMBASE FROM TAVANCEMENT WITH (NOLOCK) WHERE NACTNUMCRE = " & lstDevis.ItemData(i) & " )) AND CDEVISTYPE = 'P'"
    //      Set rsDevisPrest = New ADODB.Recordset
    //      rsDevisPrest.Open sSQL, cnx
    //      If rsDevisPrest.RecordCount > 0 Then
    //        If rsDevisPrest(0) > 0 Then
    //          frmFactAvancement.iDevisNum = rsDevisPrest(0)
    //          frmFactAvancement.iNumELF = miNumElemFact
    //          frmFactAvancement.Show vbModal
    //          
    //          Unload Me
    //        Else
    //          MsgBox "§Le devis client sélectionné doit être un devis par prestation!§"
    //        End If
    //      Else
    //        MsgBox "§Aucun devis prestation sélectionné§"
    //      End If
    //      rsDevisPrest.Close
    //    End If
    //  Next i
    //End Sub

    /* OK ----------------------------------------------------------------------------------------------*/
    private bool VerifDevisPrest(long iNumDi, long iNumELF)
    {
      string sSql = "";
      if (iNumDi != 0)
        // Modif Greg 10/02/2009 : on ne gere par avancement que si il n'y a pas deja des chiffrages autre que avancement
        // Pour gérer l'historique des DI en chiffrage classique avec devis par prestation ---------------------------
        sSql = $"SELECT CASE WHEN (SELECT COUNT(NACTNUM) FROM TACT WITH (NOLOCK) WHERE TACT.NDINNUM = {iNumDi} AND TACT.NELFNUM IS NOT NULL AND NELFNUM NOT IN (SELECT NELFNUM FROM TAVANCEMENT))> 0"
             + $" THEN CASE  WHEN (SELECT COUNT(NELFNUM) FROM TACT WITH (NOLOCK) WHERE TACT.NDINNUM = {iNumDi} AND NELFNUM IN (SELECT NELFNUM FROM TAVANCEMENT))> 0 THEN 1"
             + $" ELSE 0 END"
             + $" ELSE (SELECT COUNT(*) FROM TDCL WITH (NOLOCK) WHERE CDEVISTYPE = 'P' AND NACTNUM IN ("
             + $" SELECT TACT.NACTNUM FROM TACT WITH (NOLOCK) WHERE TACT.NDINNUM = {iNumDi} AND TACT.NELFNUM IS NULL "
             + $" AND CPRECOD <> 'E' AND CETACOD <> 'S')) END;";

      if (iNumELF != 0)
        sSql = $"SELECT COUNT(*) FROM TDCL WITH (NOLOCK) WHERE CDEVISTYPE = 'P' AND NACTNUM IN ("
             + $"SELECT TACT.NACTNUM FROM TACT WITH (NOLOCK) "
             + $" WHERE (TACT.NACTNUM in (SELECT TOP 1 NACTNUMBASE FROM TAVANCEMENT WITH (NOLOCK) WHERE NELFNUM = {iNumELF} ) "
             + $" OR TACT.NELFNUM = {iNumELF}))";

      return (int)ModuleData.ExecuteScalarInt(sSql) > 0;
    }
    //Private Function VerifDevisPrest(iNumDi As Long, iNumELF As Long) As Boolean
    //Dim rsverif As ADODB.Recordset
    //Dim sSQL As String
    //  
    //  VerifDevisPrest = False
    //  Set rsverif = New ADODB.Recordset
    //  
    //  If iNumDi <> 0 Then
    //    
    //'
    //'    sSQL = "SELECT COUNT(*) FROM TDCL WHERE CDEVISTYPE = 'P' AND NACTNUM IN (" _
    //'        & " SELECT TACT.NACTNUM FROM TACT WHERE TACT.NDINNUM = " & iNumDi & " AND TACT.NELFNUM IS NULL " _
    //'        & " AND CPRECOD <> 'E' AND CACTSTA <> 'N' AND CETACOD <> 'S')"
    //      
    //' Modif Greg 10/02/2009 : on ne gere par avancement que si il n'y a pas deja des chiffrages autre que avancement
    //' -------------------------------Pour gérer l'historique des DI en chiffrage classique avec devis par prestation ---------------------------
    //      
    //    sSQL = "SElECT CASE WHEN (SELECT COUNT(NACTNUM) FROM TACT WITH (NOLOCK) WHERE TACT.NDINNUM = " & iNumDi & " AND TACT.NELFNUM IS NOT NULL AND NELFNUM NOT IN (SELECT NELFNUM FROM TAVANCEMENT))> 0" _
    //        & " THEN CASE  WHEN (SELECT COUNT(NELFNUM) FROM TACT WITH (NOLOCK) WHERE TACT.NDINNUM = " & iNumDi & " AND NELFNUM IN (SELECT NELFNUM FROM TAVANCEMENT))> 0 THEN 1" _
    //        & " ELSE 0 END" _
    //        & " ELSE (SELECT COUNT(*) FROM TDCL WITH (NOLOCK) WHERE CDEVISTYPE = 'P' AND NACTNUM IN (" _
    //        & " SELECT TACT.NACTNUM FROM TACT WITH (NOLOCK) WHERE TACT.NDINNUM = " & iNumDi & " AND TACT.NELFNUM IS NULL " _
    //        & " AND CPRECOD <> 'E' AND CETACOD <> 'S')) END;"
    //      
    //  End If
    //  
    //  If iNumELF <> 0 Then
    //
    //    sSQL = "SELECT COUNT(*) FROM TDCL WITH (NOLOCK) WHERE CDEVISTYPE = 'P' AND NACTNUM IN (" _
    //        & "SELECT TACT.NACTNUM FROM TACT WITH (NOLOCK) " _
    //        & " WHERE (TACT.NACTNUM in (SELECT TOP 1 NACTNUMBASE FROM TAVANCEMENT WITH (NOLOCK) WHERE NELFNUM = " & iNumELF & " ) " _
    //        & " OR TACT.NELFNUM = " & iNumELF & "))"
    //        
    //  End If
    //    
    //  rsverif.Open sSQL, cnx
    //    
    //  If rsverif(0) > 0 Then VerifDevisPrest = True
    //    
    //  rsverif.Close
    //    
    //End Function

    /* OK ----------------------------------------------------------------------------------------------*/
    private void cmdTotal_Click(object sender, EventArgs e)
    {
      if (lstDevis.CheckedItems.Count == 1)
      {
        // impossible si un avancement est deja saisie sur action de base
        if ((int)ModuleData.ExecuteScalarInt($"SELECT COUNT(*) FROM TAVANCEMENT WITH (NOLOCK) WHERE NACTNUMBASE = {(lstDevis.CheckedItems[0] as ItemAction).ID}") == 0)
          txtForfait.Text = (lstDevis.CheckedItems[0] as ItemAction).LIB;
        else
          MessageBox.Show(Resources.msg_facturation_devis_impossible_car_avancement_saisi, Program.AppTitle, MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
      }
      else
      {
        MessageBox.Show(Resources.msg_must_select_devis, Program.AppTitle, MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
        return;
      }
    }
    //Private Sub cmdTotal_Click()
    //Dim sSQL As String
    //Dim rsAv As ADODB.Recordset
    //
    //  If lstDevis.SelCount > 1 Or lstDevis.SelCount = 0 Then
    //    MsgBox "§Vous devez sélectionner un devis§"
    //    Exit Sub
    //  End If
    //  
    //  ' impossible si un avancement est deja saisie sur action de base
    //  sSQL = "SELECT COUNT(*) FROM TAVANCEMENT WITH (NOLOCK) WHERE NACTNUMBASE = " & lstDevis.ItemData(lstDevis.ListIndex)
    //  Set rsAv = New ADODB.Recordset
    //  rsAv.Open sSQL, cnx
    //  
    //  If rsAv(0) = 0 Then
    //    txtForfait = lstDevis.Text
    //  Else
    //    MsgBox "§La facturation totale du devis est impossible, car un avancement est déjà saisi pour ce devis§"
    //  End If
    //  
    //  rsAv.Close
    //  Set rsAv = Nothing
    //  
    //End Sub

    /* OK ----------------------------------------------------------------------------------------------*/
    private bool VerifIfPerBlock(bool bTousSites)
    {
      // Permet de connaitre la personne qui bloque une action
      if (bTousSites == false)
      {
        foreach (ItemAction item in lstAction.CheckedItems)
        {
          string sQui = ModuleData.ExecuteScalarString($"api_sp_ListeLockActionChiffrage {item.ID}, 0");
          if (sQui != "")
          {
            MessageBox.Show($"Cette action est en cours de modification par : {sQui}\r\nVous ne pouvez pas chiffrer actuellement !", Program.AppTitle, MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
            return true;
          }
        }
      }
      return false;
    }
    //Private Function VerifIfPerBlock(ByVal bTousSites As Boolean) As Boolean
    //
    //    Dim i As Integer
    //    Dim adoverif As New ADODB.Recordset
    //
    //    'init
    //    VerifIfPerBlock = False
    //    
    //    ' traitement des actions
    //    If bTousSites = False Then
    //        For i = 0 To lstAction.ListCount - 1
    //            If lstAction.Selected(i) = True Then
    //                 adoverif.Open "exec api_sp_ListeLockActionChiffrage " & lstAction.ItemData(0) & "," & CInt(bTousSites), cnx
    //                 If adoverif.RecordCount > 0 Then
    //                    MsgBox "Cette action est en cours de modification par : " & adoverif("VPERNOM") & vbCrLf & "Vous ne pouvez pas chiffrer actuellement !", vbExclamation + vbOKOnly
    //                    VerifIfPerBlock = True
    //                    Exit For
    //                 End If
    //            End If
    //        Next
    //'    Else
    //'        adoverif.Open "exec api_sp_ListeLockActionChiffrage " & lstAction.ItemData(0) & "," & CInt(bTousSites), cnx
    //'        If adoverif.RecordCount > 0 Then
    //'           MsgBox "§Une action de cette intervention est en cours de modification par : §" & adoverif(1) & "§ (DI§" & adoverif(0) & " / " & adoverif(2) & ")" & vbCrLf & "§Vous ne pouvez pas chiffrée cette intervention actuellement !§", vbExclamation + vbOKOnly
    //'           VerifIfPerBlock = True
    //'        End If
    //    adoverif.Close
    //    End If
    //    
    //    Set adoverif = Nothing
    //
    //End Function

    /* OK ----------------------------------------------------------------------------------------------*/
    private bool Testif_8h_At_18h(DateTime dActdex)
    {
      // Cette fonction permet de connaitre l'heure d'exécution de l'action si c'est entre 8h et 18h
      return (dActdex.Hour >= 8 && dActdex.Hour < 18);
    }
    //Private Function Testif_8h_At_18h(ByVal dActdex As Date) As Boolean
    //
    //    If DatePart("h", dActdex) >= 8 And DatePart("h", dActdex) < 18 Then
    //        Testif_8h_At_18h = True
    //    Else
    //        Testif_8h_At_18h = False
    //    End If
    //
    //End Function

    /* OK ----------------------------------------------------------------------------------------------*/
    private double RechercheTauxDeTVA(int numAction)
    {
      double dTaux = 0;
      using (SqlDataReader dr = ModuleData.ExecuteReader($"exec api_sp_RechercheTauxTVA {numAction}"))
      {
        //  gestion des cas
        //  si devis client avec tva sur l'action alors on reprend ce taux de tva (99=pas de devis)
        //  si lieu execution et facturation identiques et en France alors 19.6 (ou 7.0 si site de particulier)
        //  si lieu execution et facturation identiques et à l'etranger alors 0
        //  si lieu execution et facturation différents alors tva du pays d'exécution si N°TVA intra Emalec existe sur ce pays, sinon 0
        //    TSIT.VSITPAYS, TRSF.VRSFPAYS, TPAYS.NPAYSTVA, TPAYS.VPAYSNUMTVA

        if (dr.Read())
        {
          if (dr["TVADEVIS"].ToString() != "99,00")
          {
            if (MozartParams.NomSociete == "EMALECBELGIQUE" || MozartParams.NomSociete == "EMALECESPAGNE" || MozartParams.NomSociete == "EMALECLUXEMBOURG"
                || MozartParams.NomSociete == "EMALECFACILITEAM")
              // pour Emalec belgique, on prend la tva du devis (si devis)
              dTaux = Convert.ToDouble(dr["TVADEVIS"]);
            else
            {
              // Si pays etranger avec tva intra EMALEC on prend cette tva, sinon on prend la tva du devis
              if (dr["VSITPAYS"].ToString() != dr["VRSFPAYS"].ToString() && dr["VSITPAYS"].ToString() != "FRANCE" && dr["VPAYSNUMTVA"].ToString() != "")
                dTaux = Convert.ToDouble(dr["NPAYSTVA"]);
              else
                dTaux = Convert.ToDouble(dr["TVADEVIS"]);
            }
          }
          else
          {
            //    ' pas de devis
            if (MozartParams.NomSociete == "EMALECBELGIQUE" || MozartParams.NomSociete == "EMALECESPAGNE" || MozartParams.NomSociete == "EMALECLUXEMBOURG"
              || MozartParams.NomSociete == "EMALECFACILITEAM")
              dTaux = Convert.ToDouble(dr["NPAYSTVA"]);
            else
            {
              if (dr["VSITPAYS"].ToString() == dr["VRSFPAYS"].ToString() && dr["VSITPAYS"].ToString() == "FRANCE" && dr["CSITPART"].ToString() == "O")
                dTaux = 10;
              if (dr["VSITPAYS"].ToString() == dr["VRSFPAYS"].ToString() && dr["VSITPAYS"].ToString() == "FRANCE" && dr["CSITPART"].ToString() == "N")
                dTaux = 20;
              if (dr["VSITPAYS"].ToString() == dr["VRSFPAYS"].ToString() && dr["VSITPAYS"].ToString() != "FRANCE" && dr["VSITPAYS"].ToString() != "ESPAGNE")
                dTaux = 0;
              if (dr["VSITPAYS"].ToString() == dr["VRSFPAYS"].ToString() && dr["VSITPAYS"].ToString() == "ESPAGNE")
                dTaux = 21;
              if (dr["VSITPAYS"].ToString() != dr["VRSFPAYS"].ToString() && dr["VPAYSNUMTVA"].ToString() != "")
                dTaux = Convert.ToDouble(dr["NPAYSTVA"]);
            }
          }
        }
      }
      return dTaux;
    }
    //Private Function rechercheTauxDeTVA(ByVal numAction As Long) As Double
    // 
    //Dim rs As ADODB.Recordset
    //On Error GoTo Handler
    //  rechercheTauxDeTVA = 0
    //  
    //  Set rs = New ADODB.Recordset
    //  rs.Open "exec api_sp_RechercheTauxTVA " & numAction, cnx, adOpenStatic, adLockOptimistic
    //  
    //  ' gestion des cas
    //  ' si devis client avec tva sur l'action alors on reprent ce taux de tva (99=pas de devis)
    //  ' si lieu execution et facturation identiques et en france alors 19.6 (ou 7.0 si site de particulier)
    //  ' si lieu execution et facturation identiques et à l'etranger alors 0
    //  ' si lieu execution et facturation différents alors tva du pays d'exécution si N°TVA intra Emalec existe sur ce pays, sinon 0
    //  'TSIT.VSITPAYS , TRSF.VRSFPAYS, TPAYS.NPAYSTVA, TPAYS.VPAYSNUMTVA
    //  
    //  If rs("TVADEVIS") <> 99 Then
    //    If gstrNomSociete = "EMALECBELGIQUE" Or gstrNomSociete = "EMALECESPAGNE" Or gstrNomSociete = "EMALECLUXEMBOURG" Or gstrNomSociete = "EMALECFACILITEAM" Or gstrNomSociete = "EMALECESPAGNE" Then
    //      ' pour Emalec belgique, on prend la tva du devis (si devis)
    //      rechercheTauxDeTVA = rs("TVADEVIS")
    //    Else
    //      ' si pays etranger avec tva intra EMALEC on prend cette tva, sinon on prend la tva du devis
    //      If (rs("VSITPAYS") <> rs("VRSFPAYS") And rs("VSITPAYS") <> "FRANCE" And rs("VPAYSNUMTVA") <> "") Then
    //        rechercheTauxDeTVA = rs("NPAYSTVA")
    //      Else
    //        rechercheTauxDeTVA = rs("TVADEVIS")
    //     End If
    //    End If
    //  Else
    //    ' pas de devis
    //    If gstrNomSociete = "EMALECBELGIQUE" Or gstrNomSociete = "EMALECESPAGNE" Or gstrNomSociete = "EMALECLUXEMBOURG" Or gstrNomSociete = "EMALECFACILITEAM" Or gstrNomSociete = "EMALECSUISSE" Then
    //      rechercheTauxDeTVA = rs("NPAYSTVA")
    //    Else
    //      If (rs("VSITPAYS") = rs("VRSFPAYS") And rs("VSITPAYS") = "FRANCE" And rs("CSITPART") = "O") Then rechercheTauxDeTVA = 10
    //      If (rs("VSITPAYS") = rs("VRSFPAYS") And rs("VSITPAYS") = "FRANCE" And rs("CSITPART") = "N") Then rechercheTauxDeTVA = 20
    //      If (rs("VSITPAYS") = rs("VRSFPAYS") And rs("VSITPAYS") <> "FRANCE" And rs("VSITPAYS") <> "ESPAGNE") Then rechercheTauxDeTVA = 0
    //      If (rs("VSITPAYS") = rs("VRSFPAYS") And rs("VSITPAYS") = "ESPAGNE") Then rechercheTauxDeTVA = 21
    //      If (rs("VSITPAYS") <> rs("VRSFPAYS") And rs("VPAYSNUMTVA") <> "") Then rechercheTauxDeTVA = rs("NPAYSTVA")
    //    End If
    //  End If
    //  
    //  ' mise a jour du bouton pour la tva particuliere des pays étrangers ou on a une TVA intra
    //'  cmdTVA4.Tag = rechercheTauxDeTVA
    //'  cmdTVA4.Caption = CStr(rechercheTauxDeTVA) + "%"
    //  
    //'  ' cas special belgique (il faut le taux 6 et 21
    //'  If gstrNomSociete = "EMALECBELGIQUE" Or gstrNomSociete = "EMALECFACILITEAM" Then
    //'    If rechercheTauxDeTVA = 21 Then
    //'      cmdTVA4.Tag = "6"
    //'      cmdTVA4.Caption = "6%"
    //'    Else
    //'      cmdTVA4.Tag = "21"
    //'      cmdTVA4.Caption = "21%"
    //'    End If
    //'    Exit Function
    //'  End If
    //'  ' cas special espagne (il faut le taux 10 et 21
    //'  If gstrNomSociete = "EMALECESPAGNE" Then
    //'    If rechercheTauxDeTVA = 21 Then
    //'      cmdTVA4.Tag = "10"
    //'      cmdTVA4.Caption = "10%"
    //'    Else
    //'      cmdTVA4.Tag = "21"
    //'      cmdTVA4.Caption = "21%"
    //'    End If
    //'    Exit Function
    //'  End If
    //
    //'  ' ce bouton n'est pas utilise dans les cas standard donc on le cache
    //'  If rechercheTauxDeTVA = 0 Then cmdTVA4.Visible = False
    //'  If rechercheTauxDeTVA = 19.6 Then cmdTVA4.Visible = False
    //'  If rechercheTauxDeTVA = 7 Then cmdTVA4.Visible = False
    //'  If rechercheTauxDeTVA = 5.5 Then cmdTVA4.Visible = False
    //'  If rechercheTauxDeTVA = 20 Then cmdTVA4.Visible = False
    //'  If rechercheTauxDeTVA = 10 Then cmdTVA4.Visible = False
    //'
    //  
    //Exit Function
    //Resume
    //Handler:
    //  ShowError "rechercheTauxDeTVA " & Me.Name
    //End Function

    /* OK ----------------------------------------------------------------------------------------------*/
    private void cmdTVA1_Click(object sender, EventArgs e)
    {
      if (MozartParams.NomSociete == "EMALECBELGIQUE" || MozartParams.NomSociete == "EMALECESPAGNE" || MozartParams.NomSociete == "EMALECFACILITEAM")
        txtTauxTVA.Text = "21";
      else if (MozartParams.NomSociete == "EMALECLUXEMBOURG")
        txtTauxTVA.Text = "17";
      else
        txtTauxTVA.Text = "20";
    }

    private void cmdTVA2_Click(object sender, EventArgs e)
    {
      if (MozartParams.NomSociete == "EMALECBELGIQUE" || MozartParams.NomSociete == "EMALECFACILITEAM")
        txtTauxTVA.Text = "6";
      else if (MozartParams.NomSociete == "EMALECESPAGNE")
        txtTauxTVA.Text = "10";
      else if (MozartParams.NomSociete == "EMALECLUXEMBOURG")
        txtTauxTVA.Text = "8";
      else
        txtTauxTVA.Text = "5.5";
    }

    private void cmdTVAs_Click(object sender, EventArgs e)
    {
      txtTauxTVA.Text = (sender as Button).Tag.ToString();
    }

    private string GetMessageNoteFraisDI(long p_NDINNUM)
    {
      string sRet = "";
      using (SqlDataReader dr = ModuleData.ExecuteReader($"api_sp_GetListeNACTID_With_NotesFrais {p_NDINNUM}"))
      {
        if (dr.HasRows)
        {
          sRet = "Vous avez des dépenses notes de frais à prendre en comptes dans les actions ";
          while (dr.Read())
            sRet += dr["NACTID"].ToString() + ", ";
        }
      }

      if (sRet != "")
        sRet = sRet.Substring(0, sRet.Length - 1);
      return sRet;
    }
    //Private Function GetMessageNoteFraisDI(ByVal p_NDINNUM As Long) As String
    //    
    //    Dim sMsgReturn As String
    //    
    //    'INIT
    //    sMsgReturn = ""
    //    
    //    Dim adoRD As New ADODB.Recordset
    //    adoRD.Open "EXEC api_sp_GetListeNACTID_With_NotesFrais " & p_NDINNUM, cnx, adOpenStatic, adLockReadOnly
    //    
    //    If adoRD.RecordCount > 0 Then
    //        sMsgReturn = "Vous avez des dépenses notes de frais à prendre en comptes dans les actions "
    //        While adoRD.EOF = False
    //                    
    //            sMsgReturn = sMsgReturn & adoRD("NACTID") & ", "
    //            adoRD.MoveNext
    //        Wend
    //        If sMsgReturn <> "" Then sMsgReturn = Left(sMsgReturn, Len(sMsgReturn) - Len(", "))
    //    Else
    //        sMsgReturn = ""
    //    End If
    //    adoRD.Close
    //
    //    GetMessageNoteFraisDI = sMsgReturn
    //
    //End Function

    /* OK ----------------------------------------------------------------------------------------------*/
    private void cboTVA_SelectedIndexChanged(object sender, EventArgs e)
    {
      txtTauxTVA.Text = cboTVA.Text;
    }
    //Private Sub cboTVA_Click()
    //  txtTauxTVA = cboTVA.Text
    //End Sub

    /* OK ----------------------------------------------------------------------------------------------*/
    private void cmdFluides_Click(object sender, EventArgs e)
    {
      if (lstAction.CheckedItems.Count == 0)
      {
        MessageBox.Show(Resources.msg_cocher_une_coche, Program.AppTitle, MessageBoxButtons.OK, MessageBoxIcon.Information);
        return;
      }
      else if (lstAction.CheckedItems.Count > 1)
      {
        MessageBox.Show(Resources.msg_cocher_une_seule_coche, Program.AppTitle, MessageBoxButtons.OK, MessageBoxIcon.Information);
        return;
      }

      frmListeCertFluidForChiff f = new frmListeCertFluidForChiff();
      f.mlNumActionSelect = (Int64)(lstAction.SelectedItem as ItemAction).ID;
      f.mdtArticle = dtArticles;
      f.ShowDialog();

      // remplir les montants totaux
      RemplirTxtTotaux();
    }
    //Private Sub CmdFluides_Click()
    //    
    //  Dim bOK As Integer
    //  Dim i As Integer
    //  Dim NumActionSelected As Long
    //   
    //  NumActionSelected = 0
    //   
    // ' on ne peut cliquer que sur une seule action
    //  ' traitement des actions
    //  bOK = 0
    //  For i = 0 To lstAction.ListCount - 1
    //   If lstAction.Selected(i) = True Then
    //     bOK = bOK + 1
    //     NumActionSelected = lstAction.ItemData(i)
    //'     Exit For
    //   End If
    //  Next
    //  If bOK = 0 Then
    //   MsgBox "§Il faut cocher UNE action§", vbInformation
    //   Exit Sub
    //  ElseIf bOK > 1 Then
    //   MsgBox "§Il faut cocher UNE SEULE action§", vbInformation
    //   Exit Sub
    //  End If
    //  
    //  Dim ofrm As New frmListeCertFluidForChiff
    //  ofrm.NumActionSelected = NumActionSelected
    //  ofrm.Show vbModal
    //      
    //    ' remplir les montants totaux
    //  Call RemplirTxtTotaux
    //    
    //    'recherche si certifcat fluide exists
    //'      If REchercheCertiticatFLuideFrigoExists(lstAction.ItemData(i)) Then
    //'        CmdFluides.BackColor = &H80FFFF
    //'        Exit For
    //'      Else
    //'        CmdFluides.BackColor = &H8000000F
    //'      End If
    //
    //End Sub
  }
}