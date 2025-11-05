using DevExpress.XtraGrid.Views.Grid;
using Microsoft.VisualBasic;
using MozartCS.Properties;
using MozartLib;
using MozartNet;
using MozartUC;
using ReportEmalec.Net;
using System;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Reflection;
using System.Windows.Forms;
using MZUtils = MozartControls.Utils;

namespace MozartCS
{
  public partial class frmContratPrest : Form
  {
    public string mstrStatutContrat;
    public int miNumContratST;
    public string msDatePlanif;
    public string msMontantDevis;
    public bool bDesactive;
    public string mstrStatutAlerte = "NON";
    public string msTypeContrat;
    public bool mbFacture = false;

    private string strStatutValidationCmd;
    private bool bModif;
    private bool bInit;

    DataTable dtD = new DataTable();
    DataTable dtCsth = new DataTable();
    DataTable dtCstb = new DataTable();
    DataTable dtDoc = new DataTable();

    apiLabel[] tlblPer;
    apiLabel[] tlblSign;

    public frmContratPrest()
    {
      InitializeComponent();
    }

    private void frmContratPrest_Load(object sender, EventArgs e)
    {
      try
      {
        Cursor.Current = Cursors.WaitCursor;
        ModuleMain.Initboutons(this);

        bInit = true;

        lblInfo.Text = "Il existe un devis client de prestation sur cette DI.\r\n";
        lblInfo.Text += "Donc le contrat de sous-traitance doit reprendre ces prestations.\r\n";
        lblInfo.Text += "Vous devez sélectionner les prestations confiées à ce sous-traitant et indiquer le prix d'achat pour chaque prestation.\r\n";
        lblInfo.Text += "Le total des prestations doit correspondre au montant du contrat de sous-traitance.\r\n";

        //initialisation des tableaux d'apilabel
        tlblPer = new apiLabel[] { lblPer0, lblPer1, lblPer2, lblPer3, lblPer4, lblPer5, lblPer6 };
        tlblSign = new apiLabel[] { lblSign0, lblSign1, lblSign2, lblSign3, lblSign4, lblSign5, lblSign6 };

        InitialiserFeuille();
        msMontantDevis = "";

        bInit = false;
        apiTGridH.btnExcel.Visible = apiTGridH.btnPrint.Visible = apiTGridH.chkColumnsList.Visible = false;
        apiTGridB.btnExcel.Visible = apiTGridB.btnPrint.Visible = apiTGridB.chkColumnsList.Visible = false;
        apiTGrid2.btnExcel.Visible = apiTGrid2.btnPrint.Visible = apiTGrid2.chkColumnsList.Visible = false;

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
      try
      {
        // on teste si le stt est interdit
        if (STFGRPInterdit(Convert.ToInt32(txtNomSTT.Tag)))
        {
          MessageBox.Show("Sous traitant Interdit, vous ne pouvez pas lui passer de commande", Program.AppTitle, MessageBoxButtons.OK, MessageBoxIcon.Exclamation); // La traduction de ce message n'a jamais été faite
          return;
        }

        // si la DI est facturée on ne peut pas créer de contrat
        //  If frmListeContratsST.bFacture Then
        if (mbFacture)
        {
          MessageBox.Show("Vous ne pouvez engager une dépense que sur une action 'A planifier' ou 'Planifiée'", Program.AppTitle, MessageBoxButtons.OK, MessageBoxIcon.Exclamation); // La traduction de ce message n'a jamais été faite
          return;
        }

        if (txtRem.Text == "")
        {
          MessageBox.Show("Entrez une action dans la zone prestation", Program.AppTitle, MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
          txtRem.Focus();
          return;
        }

        if (txtDelais.Text == "")
        {
          MessageBox.Show("Saisie de la date d'exécution obligatoire", Program.AppTitle, MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
          return;
        }

        if (FrameLibChantierSTT.Visible && cboLibChantierSTT.Text == "")
        {
          MessageBox.Show("Il faut sélectionner un libellé sous traitant !", Program.AppTitle, MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
          return;
        }

        // message si modification d'une commande déjà validée ou en cours de validation (E,V,I)
        if (strStatutValidationCmd != "P" && mstrStatutContrat == "M")
        {
          if (MessageBox.Show("Attention, si vous réenregistrez ce contrat, les validations hiérarchiques seront supprimées !", Program.AppTitle,
                              MessageBoxButtons.OKCancel, MessageBoxIcon.Question, MessageBoxDefaultButton.Button2) == DialogResult.Cancel)
            return;
        }
      }
      catch (Exception ex)
      {
        MZUtils.displayError(MethodBase.GetCurrentMethod().Name, ex);
      }

      // test si autre contrat sur cette DI pour ce STT
      using (SqlDataReader drContrat = ModuleData.ExecuteReader($"exec api_sp_RechercheContratDI {txtContactSTT.Tag},{MozartParams.NumAction},{MozartParams.NumDi}"))
      {
        if (drContrat.Read())
        {
          if (Convert.ToDouble(drContrat[0]) > 0)
          {
            string sMsg = $"Vous souhaitez créer un contrat pour le sous traitant {txtNomSTT.Text}\r\n" +
                          $"Au moins un autre contrat de STT a déjà été fait pour ce STT.\r\n" +
                          $"Vérifier que le contrat que vous êtes en train de créer ne fait pas double emploi.\r\n" +
                          $"Si vous souhaitez modifier un contrat existant, annuler le premier contrat et informer le STT par courrier RAR avant de créer le nouveau contrat.\r\n" +
                          $"\r\nSouhaitez-vous confirmer la création de ce nouveau contrat ?";
            if (MessageBox.Show(sMsg, Program.AppTitle, MessageBoxButtons.YesNo, MessageBoxIcon.Question, MessageBoxDefaultButton.Button2) == DialogResult.No)
              return;
          }
        }
      }

      // test si il y a des prestations
      if (dtD.Rows.Count == 0)
      {
        MessageBox.Show("Il faut sélectionner des prestations pour ce contrat", Program.AppTitle, MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
        return;
      }

      // On teste son taux de dépendance
      // test taux de dépendance, si taux de dependance => 30 % alors message + exit
      if (!ModuleMain.IsOKTauxDependanceSTF(Convert.ToInt64(txtNomSTT.Tag), MozartParams.NumAction, MozartParams.UID, MozartParams.NomSociete))
        return;

      EnregistrerContratST();
      bModif = false;
    }

    private void cmdImprimer_Click(object sender, EventArgs e)
    {
      try
      {
        if (miNumContratST == 0)
        {
          MessageBox.Show("Impression impossible, il faut enregistrer le contrat", Program.AppTitle, MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
          return;
        }

        // test si ST est un ST avzec Accès Web
        if (ModuleMain.TestIfSTWithAccessWEB("CST", miNumContratST))
        {
          if (MessageBox.Show("Attention, l'impression de ce document n'est pas obligatoire car ce sous traitant possède un accès web pour les consulter ?", Program.AppTitle,
                              MessageBoxButtons.YesNo, MessageBoxIcon.Question, MessageBoxDefaultButton.Button2) == DialogResult.No)
            return;
        }

        lauchReport(true);

        // s'il existe une planification préventif, rechercher la gamme
        if ((int)ModuleData.ExecuteScalarInt($"select count(NIPLSTNUM) from TIPLST WHERE NACTNUM = {MozartParams.NumAction}") > 0)
        {
          // recherche de la gamme sur l'action
          
          int iNumGamme = MozartDatabase.ExecuteScalarInt($"SELECT NGAMNUM from TACT WITH (NOLOCK) where NGAMNUM <> 0 AND NACTNUM = {MozartParams.NumAction}");
          if (iNumGamme > 0)
            Utils.ImpressionGammeST(iNumGamme, txtLangue.Text);
        }
      }
      catch (Exception ex)
      {
        MZUtils.displayError(MethodBase.GetCurrentMethod().Name, ex);
      }
    }

    // pForPrinting = TRUE pour PRINT, FALSE pour PREVIEW
    private void lauchReport(bool pForPrinting)
    {
      string lOption = pForPrinting ? "PRINT" : "PREVIEW";

      new frmMainReport
      {
        bLaunchByProcessStart = false,
        sTypeReport = "TContratSTprestation",
        sIdentifiant = $"{miNumContratST}",
        InfosMail = $"TINT|NINTNUM|{txtContactSTT.Tag}",
        sNomSociete = MozartParams.NomSociete,
        sLangue = txtLangue.Text,
        sOption = lOption,
        strType = "CST",
        numAction = MozartParams.NumAction
      }.ShowDialog();
    }

    private void cmdVisu_Click(object sender, EventArgs e)
    {
      if (miNumContratST == 0)
      {
        MessageBox.Show(Resources.msg_Impression_impossible_enregistrer_contrat, Program.AppTitle, MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
        return;
      }

      lauchReport(false);
    }
    
    private void cmdAlert_Click(object sender, EventArgs e)
    {
      if (mstrStatutContrat == "C") return;

      new frmSaisieAlertRavel { mstrType = "SOUS-TRAITANT", miNumObjet = miNumContratST }.ShowDialog();
    }

    private void cmdNBDLCP_Click(object sender, EventArgs e)
    {
      Cursor.Current = Cursors.WaitCursor;
      new frmPrestationsContrat { miNumContratST = miNumContratST, dtArticle = dtD }.ShowDialog();
      txtFor.Text = TotalPrest().ToString();
    }

    private void EnregistrerContratST()
    {
      try
      {
        using (SqlCommand ado_cmd = new SqlCommand("api_sp_creationContratST", MozartDatabase.cnxMozart))
        {
          ado_cmd.CommandType = CommandType.StoredProcedure;
          SqlCommandBuilder.DeriveParameters(ado_cmd);

          ado_cmd.Parameters["@iContrat"].Value = miNumContratST;
          ado_cmd.Parameters["@iAction"].Value = MozartParams.NumAction;
          ado_cmd.Parameters["@tRem"].Value = ModuleMain.ReplaceCharToBD(txtRem.Text, "RTF");
          ado_cmd.Parameters["@dDelai"].Value = txtDelais.Text == "" ? DBNull.Value : (object)txtDelais.Text;
          ado_cmd.Parameters["@iNFor"].Value = Convert.ToDouble(txtFor.Text.Replace(".", ","));
          ado_cmd.Parameters["@iNTaux"].Value = 0;
          ado_cmd.Parameters["@iNDepl"].Value = 0;
          ado_cmd.Parameters["@iContact"].Value = txtContactSTT.Tag;
          
          if (FrameLibChantierSTT.Visible)
            ado_cmd.Parameters["@nidstt"].Value = (-1 == cboLibChantierSTT.GetItemData()) ? 0 : cboLibChantierSTT.GetItemData();
          else
            ado_cmd.Parameters["@nidstt"].Value = DBNull.Value;

          ado_cmd.Parameters["@iNForEtr"].Value = 0;
          ado_cmd.Parameters["@iNTauxEtr"].Value = 0;
          ado_cmd.Parameters["@iNDeplEtr"].Value = 0;
          ado_cmd.Parameters["@cType"].Value = msTypeContrat;

          ado_cmd.ExecuteNonQuery();
          miNumContratST = Convert.ToInt32(ado_cmd.Parameters[0].Value);

          // Traitement des prestations du contrat
          EnregPrest();

          // Désactivation des autres contrats de l'action si nécessaire
          if (bDesactive)
            DesactiverContratAction();

          // Traitement de la délégation
          TraitementDelegation(miNumContratST);

          // Passage en modification
          mstrStatutContrat = "M";

          // Mise à jour de l'affichage
          InitialiserFeuille();
        }
      }
      catch (Exception ex)
      {
        MZUtils.displayError(MethodBase.GetCurrentMethod().Name, ex);
      }
    }

    private void DesactiverContratAction()
    {
      try
      {
        // Recherche des contrats de l'action sauf celui que l'on vien de créer
        using (SqlDataReader drCT = ModuleData.ExecuteReader($"select NCSTNUM FROM TCST WHERE NCSTNUM != {miNumContratST} AND NACTNUM = {MozartParams.NumAction}"))
        {
          // Si on est en création ou en modification
          while (drCT.Read())
            ModuleData.SupprimerEnreg(Convert.ToInt32(drCT["NCSTNUM"]), "api_sp_SupprimerContratST", "@iNumContratST");
        }
      }
      catch (Exception ex)
      {
        MZUtils.displayError(MethodBase.GetCurrentMethod().Name, ex);
      }
    }

    private void InitialiserFeuille()
    {
      // Recherche des infos du contact
      using (SqlDataReader drC = ModuleData.ExecuteReader($"api_sp_RetourInfoContratST {miNumContratST},{MozartParams.NumAction},'{MozartParams.NomSociete}'"))
      {
        // Les infos de la feuille
        if (drC.Read())
        {
          txtNomClient.Text = Utils.BlankIfNull(drC["VCLINOM"]);
          txtSiteClient.Text = Utils.BlankIfNull(drC["VSITNOM"]);
          txtNumSiteClient.Text = Utils.BlankIfNull(drC["NSITNUE"]);
          txtDateCreation.Text = Convert.ToDateTime(Utils.BlankIfNull(drC["DCSTDAT"])).ToString("dd/MM/yyyy");
          txtNumContrat.Text = Utils.BlankIfNull(drC["NCSTNUM"]);
          txtPortSTT.Text = Utils.BlankIfNull(drC["VINTPOR"]);
          txtAdr1Client.Text = Utils.BlankIfNull(drC["VSITAD1"]);
          txtCpClient.Text = Utils.BlankIfNull(drC["VSITCP"]);
          txtVilleClient.Text = Utils.BlankIfNull(drC["VSITVIL"]);
          txtTelClient.Text = Utils.BlankIfNull(drC["VSITTEL"]);
          txtNomSTT.Text = Utils.BlankIfNull(drC["VSTFNOM"]);
          txtContactSTT.Text = Utils.BlankIfNull(drC["VINTNOM"]);
          txtPaysSTT.Text = Utils.BlankIfNull(drC["VSTFPAYS"]);
          txtTelSTT.Text = Utils.BlankIfNull(drC["VINTTEL"]);

          // id sous-traitant et contact
          txtNomSTT.Tag = drC["NSTFNUM"];
          txtContactSTT.Tag = drC["NINTNUM"];
          txtLangue.Text = drC["VLANGUEABR"].ToString();

          InitRecordsetArticle();

          // Si on est en modification ou en création
          if (Utils.BlankIfNull(drC["NCSTNUM"]) == "0")
          {
            mstrStatutContrat = "C";
            miNumContratST = 0;
            txtRem.Text = drC["VACTDES"].ToString();
            txtDelais.Text = msDatePlanif;

            if (Convert.ToInt32(Utils.ZeroIfNull(drC["CHANTIER"])) != 0)
            {
              FrameLibChantierSTT.Visible = true;
              // On charge la combo des libellés fiche chantier
              ModuleData.RemplirCombo(cboLibChantierSTT, $"SELECT NIDFICHE, VLIB FROM TCHANTIERFICHE INNER JOIN TCHANTIERCAN ON TCHANTIERFICHE.NIDCHANTIER = TCHANTIERCAN.NIDCHANTIER " +
                                                         $"WHERE NCANNUM = {drC["NDINCTE"]} AND VTYPE = 'S' ORDER BY TCHANTIERFICHE.NCLASS");
              cboLibChantierSTT.ValueMember = "NIDFICHE";
              cboLibChantierSTT.DisplayMember = "VLIB";
            }

            // Les champs modifiables
            txtFor.Text = Utils.ZeroIfNull(drC["NCSTFOR"]).ToString();
          }
          else
          {
            mstrStatutContrat = "M";
            txtRem.Text = ModuleMain.ReplaceCharFromBD(Utils.BlankIfNull(drC["TCSTPRE"]).ToString(), "RTF");
            txtDelais.Text = $"{Convert.ToDateTime(drC["DCSTDEL"]).ToString("dd/MM/yyyy")}";
            if (Convert.ToInt32(Utils.ZeroIfNull(drC["CHANTIER"])) != 0)
            {
              FrameLibChantierSTT.Visible = true;
              // On charge la combo des libellés fiche chantier
              ModuleData.RemplirCombo(cboLibChantierSTT, $"SELECT NIDFICHE, VLIB FROM TCHANTIERFICHE INNER JOIN TCHANTIERCAN ON TCHANTIERFICHE.NIDCHANTIER = TCHANTIERCAN.NIDCHANTIER " +
                                                         $"WHERE NCANNUM = {drC["NDINCTE"]} AND VTYPE = 'S' ORDER BY TCHANTIERFICHE.NCLASS");
              cboLibChantierSTT.ValueMember = "NIDFICHE";
              cboLibChantierSTT.DisplayMember = "VLIB";
              cboLibChantierSTT.SetItemData(Utils.ZeroIfNull(drC["NIDSTT"]).ToString());
            }
            // Les champs modifiables
            txtFor.Text = Utils.ZeroIfNull(drC["NCSTFOR"]).ToString();

            // Recherche liste prestations du contrat
            // On ramène les prestations du contrat
            ModuleData.LoadData(dtD, $"exec api_sp_listePrestContratST {miNumContratST}");
          }

          InitgridPrest();
          txtFor.Text = TotalPrest().ToString();

          // COULEUR DU BOUTON ALERT : jaune si une alerte a ete saisie
          if (drC["VCSTALERT"].ToString() != "N" && drC["VCSTALERT"].ToString() != "")
            cmdAlert.BackColor = MozartColors.ColorH80FFFF; // Jaune

          // On affiche les informations d'historique du stt
          ModuleData.LoadData(dtCsth, $"api_sp_ContratEnCoursSTT {txtNomSTT.Tag}, '{MozartParams.NomSociete}', 'E'");
          ModuleData.LoadData(dtCstb, $"api_sp_ContratEnCoursSTT {txtNomSTT.Tag}, '{MozartParams.NomSociete}', 'H'");

          InitGrid();
          frmSTT.Visible = true;

          ModuleData.LoadData(dtDoc, $"EXEC api_sp_StatutDocSTF 0, {txtNomSTT.Tag}");
          InitApigridDoc();

          // Pas encore de modification
          bModif = false;

          // Traitement délégation
          strStatutValidationCmd = drC["CCSTVALID"].ToString();
          AfficheDelegation(miNumContratST);
        }
        // On désactive le bouton de validation si on vient de l'alerte pour éviter les ambiguités de validation
        cmdValider.Enabled = mstrStatutAlerte != "OUI";
      }
    }

    public void InitRecordsetArticle()
    {
      try
      {
        if (bInit)
        {
          dtD.Columns.Add("NLDCLPRESTID", typeof(int));
          dtD.Columns.Add("CAT", typeof(string));
          dtD.Columns.Add("VPRESTLIB", typeof(string));
          dtD.Columns.Add("VPRESTUNITE", typeof(string));
          dtD.Columns.Add("NQTE", typeof(double));
          dtD.Columns.Add("DEBOURSE", typeof(double));
          dtD.Columns.Add("DEBOURSUNIT", typeof(double));
          dtD.Columns.Add("NPACHAT", typeof(double));
          dtD.Columns.Add("NPUNITAIRE", typeof(double));
          dtD.Columns.Add("CMATFOURNI", typeof(string));
        }
      }
      catch (Exception ex)
      {
        MZUtils.displayError(MethodBase.GetCurrentMethod().Name, ex);
      }
    }

    private void InitgridPrest()
    {
      if (bInit)
      {
        apiTGridPrestSaisie.AddColumn("ID", "NLDCLPRESTID", 0);
        apiTGridPrestSaisie.AddColumn("Cat", "CAT", 500);
        apiTGridPrestSaisie.AddColumn("Prestation", "VPRESTLIB", 8000);
        apiTGridPrestSaisie.AddColumn("Uté", "VPRESTUNITE", 400, "", 2);
        apiTGridPrestSaisie.AddColumn("Qté", "NQTE", 500, "", 2);
        apiTGridPrestSaisie.AddColumn("Déboursé HT", "DEBOURSE", 1400, "Currency", 2);
        apiTGridPrestSaisie.AddColumn("Prix d'achat", "NPACHAT", 1200, "Currency", 2);

        apiTGridPrestSaisie.GridControl.DataSource = dtD;
      }
      apiTGridPrestSaisie.InitColumnList();
    }

    private void apiTGridPrestSaisie_RowCellStyle(object sender, RowCellStyleEventArgs e)
    {
      if (e.RowHandle < 0) return;
      if (e.Column.Name == "NPACHAT")
      {
        e.Appearance.BackColor = Color.Orange;
        e.Appearance.Font = new Font(e.Appearance.Font, FontStyle.Bold);
      }
    }

    public void TraitementDelegation(int numCom)
    {
      double montantValidation;
      try
      {
        int iCreateur;
        DateTime dCree;
        int N2, N3, N4, N6;

        switch (MozartParams.NomSociete)
        {
          case "EMALECFACILITEAM":
          case "EMALECSUISSE":
          case "SAMSICROMANIA":
          case "EMALECDEV":
            return;
          default:
            break;
        }

        // Recherche du total de la commande
        double montantContrat = Convert.ToDouble(txtFor.Text);

        // Recherche du créateur du contrat et de la date de création
        using (SqlDataReader dr = ModuleData.ExecuteReader($"SELECT NCSTCREA, DCSTDAT FROM TCST WHERE NCSTNUM = {numCom}"))
        {
          dr.Read();
          iCreateur = Convert.ToInt32(dr["NCSTCREA"]);
          dCree = Convert.ToDateTime(dr["DCSTDAT"]);
        }

        // Recherche du montant de validation du créateur
        using (SqlDataReader drV = ModuleData.ExecuteReader($"SELECT MTVALIDATION FROM TPER WHERE NPERNUM = {iCreateur}"))
        {
          if (drV.Read())
            montantValidation = Convert.ToDouble(Utils.ZeroIfNull(drV[0]));
          else
            montantValidation = 0;
        }

        // En modification, on supprime toute les données de validation (sauf le créateur) et on repart de zéro
        if (mstrStatutContrat == "M")
        {
          ModuleData.ExecuteNonQuery($"delete from TCOMVALID where ctype = 'CS' and ncomnum = {numCom}");
          // Mise a jour du statut de la commande
          ModuleData.ExecuteNonQuery($"update TCST set CCSTVALID ='P' where NCSTNUM = {numCom}");
        }

        // Si montant supérieur, on sort sans création de délégation de dépense
        if (montantContrat < montantValidation)
        {
          if (mstrStatutContrat == "C")
          {
            // 26/04/2016, NL : Envoi d'un mail d'avertissement pour une nouvelle demande d'intervention
            ModuleData.ExecuteNonQuery($"exec api_sp_EnvoiMailNouvelleDemandeInterv {numCom}");
          }
          return;
        }

        // CASE 1
        // On insère une ligne dans la table de validation avec le createur de la commande en case 1
        ModuleData.ExecuteNonQuery($"insert into TCOMVALID (NCOMNUM, CTYPE, QN1, DN1, VRMQ) select {numCom}, 'CS', {iCreateur}, '{dCree}', '{txtRmEng.Text.Replace("'", "''")}'");
        //ModuleData.ExecuteNonQuery($"insert into TCOMVALID (NCOMNUM, QN1, DN1) select {numCom}, {MozartParams.UID}, Getdate()");

        // CASE 2 et 6
        // Recherche du responsable du compte et de son assistant pour cette commande
        using (SqlDataReader drV = ModuleData.ExecuteReader($"SELECT TCAN.NPERNUM AS NPERNUM_RESP, TCAN.NPERNUMASSCHAFF AS NPERNUM_ASS FROM TCAN WITH(NOLOCK), TACT WITH(NOLOCK), TDIN WITH(NOLOCK), TCST WITH(NOLOCK) WHERE TCAN.NCLINUM=TDIN.NCLINUM " +
                                                           $"AND TACT. NDINNUM = TDIN.NDINNUM AND TCAN.NCANNUM = TDIN.NDINCTE AND TACT.NACTNUM = TCST.NACTNUM AND NCSTNUM = {numCom}"))
        {
          drV.Read();
          N2 = Convert.ToInt32(drV["NPERNUM_RESP"]);
          N6 = (int)Utils.ZeroIfNull(drV["NPERNUM_ASS"]);
        }
        ModuleData.ExecuteNonQuery($"update TCOMVALID set QN2 = {N2}, QN6={N6} where CTYPE = 'CS' AND NCOMNUM = {numCom}");

        // CASE 3 et 4
        // Recherche du groupe et du service
        using (SqlDataReader drV = ModuleData.ExecuteReader($"SELECT G.NPERNUM as GNPERNUM, S.NPERNUM [SNPERNUM] FROM TREF_GROUPE G, TREF_SERVICE S, TPER P WHERE P.IDGROUPE = G.IDGROUPE " +
                                                            $"AND G.IDSERVICE=S.IDSERVICE AND P.NPERNUM = {N2}"))
        {
          drV.Read();
          N3 = Convert.ToInt32(drV["GNPERNUM"]);
          N4 = Convert.ToInt32(drV["SNPERNUM"]);
        }
        ModuleData.ExecuteNonQuery($"update TCOMVALID set QN3 = {N3}, QN4 = {N4} where CTYPE = 'CS' AND NCOMNUM = {numCom}");

        // Mise a jour du statut de la commande
        ModuleData.ExecuteNonQuery($"update TCST set CCSTVALID = 'E' where NCSTNUM = {numCom}");
      }
      catch (Exception ex)
      {
        MZUtils.displayError(MethodBase.GetCurrentMethod().Name, ex);
      }
    }

    public void AfficheDelegation(int numCST)
    {
      try
      {
        // Recherche s'il y a des données de délégation
        using (SqlDataReader sdr = ModuleData.ExecuteReader($"exec api_sp_AfficheDelegation 'CS', {numCST}"))
        {
          if (!sdr.Read())
          {
            // Si pas de données de validation, rien
            cmdVisu.Enabled = true;
            cmdImprimer.Enabled = true;
            frameValidation.Visible = false;
            CmdAnaChantier.Visible = false;
            return;
          }

          for (int i = 1; i <= 6; i++)
          {
            // affichage de la personne
            if (i == 5)
            {
              // cas direction
              if (Utils.BlankIfNull(sdr["QUI" + i]) == "")
                tlblPer[i].Text = $"Direction {Environment.NewLine} (illimité)";
              else
                tlblPer[i].Text = $"{Utils.BlankIfNull(sdr["QUI" + i])}\r\n(illimité)";
            }
            else
            {
              // Autres cas
              tlblPer[i].Text = $"{Utils.BlankIfNull(sdr["QUI" + i])}\r\n(<{Utils.ZeroIfNull(sdr["MT" + i])} €)";
              if (tlblPer[i].Text == $"{Environment.NewLine}(<0 €)") tlblPer[i].Text = "";
            }

            // on garde l'info du montant de validation
            tlblPer[i].Tag = Utils.ZeroIfNull(sdr["MT" + i]);
            // affichage de l'info de signature quand
            tlblSign[i].Text = $"{Utils.DateBlankIfNull(sdr["DN" + i], "dd/MM/yyyy")}\r\n{Utils.DateBlankIfNull(sdr["DN" + i], "HH:mm:ss")}";
            if (tlblSign[i].Text == "\r\n") tlblSign[i].Text = "";
            // on garde l'info de qui a validé
            tlblSign[i].Tag = Utils.BlankIfNull(sdr["QN" + i]);
          }

          // Mise à jour des couleurs
          for (int i = 1; i <= 6; i++)
          {
            // case grise si validation nécessaire
            if (tlblPer[i].Text != "")
            {
              switch (i)
              {
                case 1:
                  tlblSign[i].BackColor = MozartColors.ColorH8000000F;
                  break;
                case 6:
                  // si deleg 1 >= deleg 6
                  if (Convert.ToInt32(tlblPer[1].Tag) >= Convert.ToInt32(tlblPer[i].Tag))
                    tlblSign[i].BackColor = Color.White;
                  else
                    tlblSign[i].BackColor = MozartColors.ColorH8000000F;
                  break;
                case 2:
                  // si deleg 1 >= deleg 2
                  if (Convert.ToInt32(tlblPer[1].Tag) >= Convert.ToInt32(tlblPer[i].Tag))
                    tlblSign[i].BackColor = Color.White;
                  else
                  {
                    // si cde > deleg 6
                    if (Utils.ZeroIfNull(txtFor.Text) > Convert.ToDouble(tlblPer[6].Tag)) tlblSign[i].BackColor = MozartColors.ColorH8000000F;
                  }
                  break;
                case 3:
                  // si deleg 1 >= deleg 3
                  if (Convert.ToInt32(tlblPer[1].Tag) >= Convert.ToInt32(tlblPer[i].Tag))
                    tlblSign[i].BackColor = Color.White;
                  else
                  {
                    // si cde > deleg 2
                    if (Utils.ZeroIfNull(txtFor.Text) > Convert.ToDouble(tlblPer[2].Tag)) tlblSign[i].BackColor = MozartColors.ColorH8000000F;
                  }
                  break;
                case 4:
                  // si deleg 1 >= deleg 4
                  if (Convert.ToInt32(tlblPer[1].Tag) >= Convert.ToInt32(tlblPer[i].Tag))
                    tlblSign[i].BackColor = Color.White;
                  else
                  {
                    // si cde > deleg 3
                    if (Utils.ZeroIfNull(txtFor.Text) > Convert.ToDouble(tlblPer[3].Tag)) tlblSign[i].BackColor = MozartColors.ColorH8000000F;
                  }
                  break;
                case 5:
                  // Direction
                  // case grise si validation nécessaire (si montant sup à validation du responsable de service)
                  if (Utils.ZeroIfNull(txtFor.Text) > Convert.ToDouble(tlblPer[i - 1].Tag))
                    tlblSign[i].BackColor = MozartColors.ColorH8000000F;
                  else
                    tlblSign[i].BackColor = Color.White;
                  break;
                default:
                  break;
              }
            }
          }

          // gestion de l'édition des commandes
          lblPer0.Text = Utils.BlankIfNull(sdr["QUIEDIT"]);
          lblSign0.Text = $"{Utils.DateBlankIfNull(sdr["DEDIT"], "dd/MM/yyyy")}\r\n{Utils.DateBlankIfNull(sdr["DEDIT"], "HH:mm:ss")}";
          if (lblSign0.Text == "\r\n") lblSign0.Text = "";
          lblSign0.Tag = Utils.BlankIfNull(sdr["QEDIT"]);

          // remarque sur délégation
          txtRmEng.Text = Utils.BlankIfNull(sdr["VRMQ"]);

          // titre du tableau
          if (strStatutValidationCmd == "E")
          {
            frameValidation.Text = "Autorisation des engagements de dépenses en attente de signature";
            frameValidation.ForeColor = Color.Red;
            cmdVisu.Enabled = false;
            cmdImprimer.Enabled = false;
          }
          else if (strStatutValidationCmd == "V")
          {
            frameValidation.Text = "Autorisation des engagements de dépenses validées, contrat à éditer et envoyer";
            frameValidation.ForeColor = Color.Orange;
            cmdVisu.Enabled = false;
            cmdImprimer.Enabled = false;
          }
          else if (strStatutValidationCmd == "I")
          {
            frameValidation.Text = "Autorisation des engagements de dépenses validées, éditées et envoyées";
            frameValidation.ForeColor = Color.Green;
            cmdVisu.Enabled = true;
            cmdImprimer.Enabled = true;
          }

          // tableau visible
          frameValidation.Visible = true;
          // test si affichage bouton analytique chantier
          if (cboLibChantierSTT.SelectedIndex != -1) CmdAnaChantier.Visible = true;

        }
      }
      catch (Exception ex)
      {
        MZUtils.displayError(MethodBase.GetCurrentMethod().Name, ex);
      }
    }

    private void lblSign_all_Click(object sender, EventArgs e)
    {
      try
      {
        int index = Convert.ToInt32((sender as apiLabel).HelpContextID);

        // Case 1 pas de validation possible car si créateur, déjà validé
        if (index == 1) return;

        //  Case 1 pas de validation possible car si créateur, deja validé
        //  Si déjà validé, pas utile de revalider
        if (tlblSign[index].Text != "") return;

        //  Si pas de hierarchique sortir (sauf si edition)
        if (tlblPer[index].Text == "" && index != 0) return;

        //  On teste si le stt est interdit
        if (STFGRPInterdit(Convert.ToInt32(txtNomSTT.Tag)) == true)
        {
          MessageBox.Show("Sous traitant Interdit, vous ne pouvez pas lui passer de commande", Program.AppTitle, MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
          return;
        }
        //  On teste son taux de depandance
        //  Test taux de dependance, si taux de dependance => 30 % alors message + exit
        if (ModuleMain.IsOKTauxDependanceSTF(Convert.ToInt32(txtNomSTT.Tag), MozartParams.NumAction, MozartParams.UID, MozartParams.NomSociete) == false) return;
        //
        //  Si index=5 (direction), c'est un cas particulier (jullien, chevalier, bozzarelli)
        if (index == 5)
        {
          //  FGA le 260923 gestion par societe de l'utilisateur
          int iDirOk = (int)ModuleData.ExecuteScalarInt($"SELECT COUNT(P.NPERNUM) FROM TDIRECTION D INNER JOIN TPER P ON D.NPERNUM = P.NPERNUM " +
                                                      $"WHERE P.NPERNUM = {MozartParams.UID}");
          if (iDirOk == 1)
          {
            //  On enregistre la validation et on valide la commande
            if (txtRmEng.Text != "")
            {
              if (MessageBox.Show("Vous allez valider cet engagement de dépenses. Avez-vous pris connaissance de l'information ci-dessous en rouge ?\r\nVoulez-vous toutefois valider ? ",
                                  Program.AppTitle, MessageBoxButtons.OKCancel, MessageBoxIcon.Question, MessageBoxDefaultButton.Button2) != DialogResult.OK) return;
            }
            else
            {
              if (MessageBox.Show("Vous allez valider cet engagement de dépenses.\r\nConfirmer votre validation :", Program.AppTitle, MessageBoxButtons.OKCancel, MessageBoxIcon.Question,
                                  MessageBoxDefaultButton.Button2) != DialogResult.OK) return;
            }
            ModuleData.ExecuteNonQuery($"update TCOMVALID set QN{index}={MozartParams.UID}, DN{index}=GetDate() where CTYPE='CS' AND NCOMNUM = {miNumContratST}");
            ModuleData.ExecuteNonQuery($"update TCST set CCSTVALID='V' where CCSTVALID!='I' And NCSTNUM = {miNumContratST}");
            strStatutValidationCmd = "V";
            frameValidation.Text = "Autorisation des engagements de dépenses validées, contrat à éditer et envoyer";
            frameValidation.ForeColor = Color.Orange; // Orange
            tlblPer[index].Text = MozartParams.strUID;
            tlblSign[index].Text = $"{DateTime.Now.ToShortDateString()}\r\n{DateTime.Now.ToLongTimeString()}";
          }
          return;
        }

        // Cas de l'edition de la commande
        if (index == 0)
        {
          if (strStatutValidationCmd != "V")
            MessageBox.Show("Le contrat doit être validé avant de pouvoir l'éditer", Program.AppTitle, MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
          else
          {
            // On enregistre l'édition de commande
            if (MessageBox.Show("Vous allez valider l'édition du contrat.\r\nConfirmer votre validation :", Program.AppTitle, MessageBoxButtons.OKCancel,
                                 MessageBoxIcon.Question, MessageBoxDefaultButton.Button2) != DialogResult.OK) return;
            ModuleData.ExecuteNonQuery($"update TCOMVALID set QEDIT={MozartParams.UID}, DEDIT=GetDate() where CTYPE='CS' AND NCOMNUM = {miNumContratST}");
            ModuleData.ExecuteNonQuery($"update TCST set CCSTVALID='I' where NCSTNUM = {miNumContratST}");
            strStatutValidationCmd = "I";
            tlblPer[index].Text = MozartParams.strUID;
            tlblSign[index].Text = $"{DateTime.Now.ToShortDateString()}\r\n{DateTime.Now.ToLongTimeString()}";
            frameValidation.Text = "Autorisation des engagements de dépenses validées, éditées et envoyées";
            frameValidation.ForeColor = Color.FromArgb(0, 128, 0); // Vert
            cmdVisu.Enabled = true;
            cmdImprimer.Enabled = true;
          }
          return;
        }

        // Cas 2,3,4,6
        if (Convert.ToInt32(tlblSign[index].Tag) == MozartParams.UID)
        {
          if (txtRmEng.Text != "")
          {
            if (MessageBox.Show("Vous allez valider cet engagement de dépenses. Avez-vous pris connaissance de l'information ci-dessous en rouge ?\r\nVoulez-vous toutefois valider ? ",
                                 Program.AppTitle, MessageBoxButtons.OKCancel, MessageBoxIcon.Question, MessageBoxDefaultButton.Button2) != DialogResult.OK) return;
          }
          else if (MessageBox.Show("Vous allez valider cet engagement de dépenses.\r\nConfirmer votre validation :", Program.AppTitle, MessageBoxButtons.OKCancel,
                                    MessageBoxIcon.Question, MessageBoxDefaultButton.Button2) != DialogResult.OK) return;
          // Mise à jour de la validation
          ModuleData.ExecuteNonQuery($"update TCOMVALID set DN{index}=GetDate() where CTYPE='CS' AND NCOMNUM = {miNumContratST}");
          tlblSign[index].Text = $"{DateTime.Now.ToShortDateString()}\r\n{DateTime.Now.ToLongTimeString()}";
          // si cela valide le contrat, changer le statut dans le contrat
          if ((double)tlblPer[index].Tag >= Convert.ToDouble(txtFor.Text))
          {
            ModuleData.ExecuteNonQuery($"update TCST set CCSTVALID='V' where CCSTVALID<>'I' And NCSTNUM = {miNumContratST}");
            frameValidation.Text = "Autorisation des engagements de dépenses validées, commande à éditer et envoyer";
            frameValidation.ForeColor = Color.Orange; // Orange
          }
        }
      }
      catch (Exception ex)
      {
        MZUtils.displayError(MethodBase.GetCurrentMethod().Name, ex);
      }
    }

    private void txtRmEng_Enter(object sender, EventArgs e)
    {
      Frame1.Visible = true;
      txtObs.Focus();
    }

    private void cmdValObs_Click(object sender, EventArgs e)
    {
      // Position en début de text quand focus et avec saut de ligne
      string temp = $"{MozartParams.strUID} le {DateAndTime.DateString} : ";
      string msg = txtObs.Text;

      if (msg != "")
      {
        if (txtRmEng.Text == "")
          txtRmEng.Text = temp + msg;
        else
          txtRmEng.Text = $"{temp}{msg}\r\n{txtRmEng.Text}";
        // Enregistrement dans la base
        ModuleData.ExecuteNonQuery($"update TCOMVALID set VRMQ='{txtRmEng.Text.Replace("'", "''")}' where CTYPE='CS' AND NCOMNUM = {miNumContratST}");
      }
      Frame1.Visible = true;
      bModif = false;
    }

    private void cmdAnObs_Click(object sender, EventArgs e)
    {
      txtObs.Text = "";
      Frame1.Visible = false;
    }

    private bool STFGRPInterdit(int c_nstfnum)
    {
      try
      {
        return ModuleData.ExecuteScalarString($"exec api_sp_RetourInfoSttInterdit {c_nstfnum}") == "O";
      }
      catch (Exception ex)
      {
        MZUtils.displayError(MethodBase.GetCurrentMethod().Name, ex);
      }
      return false;
    }

    private void cboLibChantierSTT_SelectedIndexChanged(object sender, EventArgs e)
    {
      //****************************************************************************************************************
      //On peut changer la fiche chantier meme si l'action est exécutée
      //****************************************************************************************************************
      if (miNumContratST != 0 && FrameLibChantierSTT.Visible == true)
        ModuleData.ExecuteNonQuery($"exec api_sp_UpdateCSTFicheChantier {miNumContratST}, {cboLibChantierSTT.GetItemData()}");
    }

    private async void ApiTelAuto1_Click(object sender, EventArgs e)
    {
      //ApiTelAuto1.TelDial(txtTelClient.Text);
            if (txtTelClient.Text != "")
            {
                string reponse = await CNumerotationAuto.MakeCallByAvaya(MozartParams.UserTelInt, txtTelClient.Text, Environment.MachineName);
                if (reponse != "OK")
                {
                    MessageBox.Show(reponse, Program.AppTitle, MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
        }

    private async void ApiTelAuto2_Click(object sender, EventArgs e)
    {
            //ApiTelAuto1.TelDial(txtTelSTT.Text);
            if (txtTelSTT.Text != "")
            {
                string reponse = await CNumerotationAuto.MakeCallByAvaya(MozartParams.UserTelInt, txtTelSTT.Text, Environment.MachineName);
                if (reponse != "OK")
                {
                    MessageBox.Show(reponse, Program.AppTitle, MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
        }

    private async void ApiTelAuto3_Click(object sender, EventArgs e)
    {
            //ApiTelAuto1.TelDial(txtPortSTT.Text);
            if (txtPortSTT.Text != "")
            {
                string reponse = await CNumerotationAuto.MakeCallByAvaya(MozartParams.UserTelInt, txtPortSTT.Text, Environment.MachineName);
                if (reponse != "OK")
                {
                    MessageBox.Show(reponse, Program.AppTitle, MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
        }

    private void frmContratPrest_KeyPress(object sender, KeyPressEventArgs e)
    {
      bModif = true;
    }

    private void cmdFermer_Click(object sender, EventArgs e)
    {
      try
      {
        string response;
        // Si il y a des modification
        if (bModif)
        {
          response = MessageBox.Show("Voulez-vous enregistrer les modifications ?", Program.AppTitle, MessageBoxButtons.YesNoCancel, MessageBoxIcon.Question, MessageBoxDefaultButton.Button2).ToString();
          switch (response)
          {
            case "Yes":
              EnregistrerContratST();
              Dispose();
              break;
            case "No":
              Dispose();
              break;
            case "Cancel":
              return;
          }
        }
        else Dispose();
      }
      catch (Exception ex)
      {
        MZUtils.displayError(MethodBase.GetCurrentMethod().Name, ex);
      }
    }

    private void EnregPrest()
    {
      try
      {
        // Delete puis Insert des prestations
        ModuleData.ExecuteNonQuery($"delete from TCSTPREST WHERE NCSTNUM = {miNumContratST}");
        foreach (DataRow item in dtD.Rows)
        {
          if (item["NPUNITAIRE"] == DBNull.Value)
            // NL le 30/12/2015 : Cas uniquement pour reprise des contrats déjà existants, ne servira plus ensuite...
            ModuleData.ExecuteNonQuery($"insert into TCSTPREST (NCSTNUM, NLDCLPRESTID, NPACHAT, NQTE) VALUES ({miNumContratST}, {item["NLDCLPRESTID"]}, " +
                                       $"{item["NPACHAT"].ToString().Replace(",", ".")}, {item["NQTE"].ToString().Replace(",", ".")})");
          else
            ModuleData.ExecuteNonQuery($"insert into TCSTPREST select {miNumContratST}, {item["NLDCLPRESTID"]}, {item["NPACHAT"].ToString().Replace(",", ".")}, " +
                                       $"{item["NQTE"].ToString().Replace(",", ".")}, {item["NPUNITAIRE"].ToString().Replace(",", ".")}, '{item["CMATFOURNI"]}'");
        }
      }
      catch (Exception ex)
      {
        MZUtils.displayError(MethodBase.GetCurrentMethod().Name, ex);
      }
    }

    private double TotalPrest()
    {
      if (dtD.Rows.Count == 0) return 0;

      double dTotal = 0;
      try
      {
        foreach (DataRow item in dtD.Rows)
          dTotal += Convert.ToDouble(item["NPACHAT"]);
      }
      catch (Exception ex)
      {
        MZUtils.displayError(MethodBase.GetCurrentMethod().Name, ex);
      }
      return dTotal;
    }

    private void InitGrid()
    {
      try
      {
        if (bInit)
        {
          // Liste contrat en cours
          apiTGridH.AddColumn(Resources.col_Filiale, "VSOCIETE", 1000); //5
          apiTGridH.AddColumn("Client", "VCLINOM", 1900, "", 0, true); //5
          apiTGridH.AddColumn(Resources.col_Site, "VSITNOM", 1900, "", 0, true);
          apiTGridH.AddColumn(Resources.col_Chaff, "VDINCHAFF", 1200);
          apiTGridH.AddColumn("N° Ctr", "NCSTNUM", 1000);
          apiTGridH.AddColumn("Date contrat", "DCSTDAT", 900, "dd/MM/yy");
          apiTGridH.AddColumn("Contrat HT", "NCSTFOR", 1200, "Currency", 2);
          apiTGridH.AddColumn("Facture HT", "FHT", 1200, "Currency", 2);

          apiTGridH.InitColumnList();
          apiTGridH.GridControl.DataSource = dtCsth;

          // Liste historique contrat sur 12 mois
          apiTGridB.AddColumn(Resources.col_Filiale, "VSOCIETE", 1000); //5
          apiTGridB.AddColumn("Client", "VCLINOM", 1900, "", 0, true); //5
          apiTGridB.AddColumn(Resources.col_Site, "VSITNOM", 1900, "", 0, true);
          apiTGridB.AddColumn(Resources.col_Chaff, "VDINCHAFF", 1200);
          apiTGridB.AddColumn("N° Ctr", "NCSTNUM", 1000);
          apiTGridB.AddColumn("Date contrat", "DCSTDAT", 900, "dd/MM/yy");
          apiTGridB.AddColumn("Contrat HT", "NCSTFOR", 1200, "Currency", 2);
          apiTGridB.AddColumn("Facture HT", "FHT", 1200, "Currency", 2);

          apiTGridB.InitColumnList();
          apiTGridB.GridControl.DataSource = dtCstb;
        }
      }
      catch (Exception ex)
      {
        MZUtils.displayError(MethodBase.GetCurrentMethod().Name, ex);
      }
    }

    private void InitApigridDoc()
    {
      try
      {
        if (bInit)
        {
          apiTGrid2.AddColumn("NSTFGRPNUM", "NSTFGRPNUM", 0);
          apiTGrid2.AddColumn("Statut", "VLIBSTATUT", 1100);
          apiTGrid2.AddColumn("Nb ctrts", "NBCST", 1000, "", 1);
          apiTGrid2.AddColumn("CA STT", "NSTFGRPCA", 1300, "# ### ##0 €", 1);
          apiTGrid2.AddColumn("CA emalec 12 mois", "NSTFGRPFA", 1300, "# ### ##0 €", 1);
          apiTGrid2.AddColumn("Dépendance %", "TAUX", 800, "#00%", 1);
          apiTGrid2.AddColumn("Kbis", "DOC1", 1100, "", 0, true);
          apiTGrid2.AddColumn("RC", "DOC2", 1100, "", 0, true);
          apiTGrid2.AddColumn("Décennale", "DOC3", 1100, "", 0, true);
          apiTGrid2.AddColumn("Sociale", "DOC4", 1100, "", 0, true);
          apiTGrid2.AddColumn("Fiscale", "DOC5", 1100, "", 0, true);
          apiTGrid2.AddColumn("Autres docs", "DOC9", 1250, "", 0, true);
          apiTGrid2.AddColumn("Conf & NC", "DOC10", 1200, "", 0, true);
          apiTGrid2.AddColumn("CSTFGRPSANSDOC", "CSTFGRPSANSDOC", 0);  // pas de gestion des docs adm du STT

          apiTGrid2.GridControl.DataSource = dtDoc;
          apiTGrid2.InitColumnList();
        }
      }
      catch (Exception ex)
      {
        MZUtils.displayError(MethodBase.GetCurrentMethod().Name, ex);
      }
    }

    private void apiTGrid2_RowCellStyle(object sender, RowCellStyleEventArgs e)
    {
      if (e.RowHandle < 0) return;

      // pas de gestion des couleurs si STT sans gestion des docs Admin
      if (e.RowHandle >= 0 && (sender as GridView).GetDataRow(e.RowHandle)["CSTFGRPSANSDOC"].ToString() == "O")
        return;


      try
      {
        if (e.Column.Name == "DOC1" || e.Column.Name == "DOC2" || e.Column.Name == "DOC3" || e.Column.Name == "DOC4" || e.Column.Name == "DOC5" || e.Column.Name == "DOC10")
        {
          if (e.CellValue != DBNull.Value)
          {
            if (Convert.ToDateTime(e.CellValue) < DateTime.Now)
              e.Appearance.BackColor = MozartColors.ColorH80FFFF; //'Périmé
            if (Convert.ToDateTime(e.CellValue) >= DateTime.Now)
              e.Appearance.BackColor = MozartColors.ColorH80FF80; //OK
          }
          else
            e.Appearance.BackColor = MozartColors.colorHFFC0FF; // Non conforme
        }
      }
      catch (Exception ex)
      {
        MZUtils.displayError(MethodBase.GetCurrentMethod().Name, ex);
      }
    }

    private void CmdAnaChantier_Click(object sender, EventArgs e)
    {
      int i = (int)ModuleData.ExecuteScalarInt($"SELECT TCHANTIERFICHE.NIDCHANTIER FROM TCHANTIERFICHE WITH (NOLOCK) WHERE NIDFICHE = {cboLibChantierSTT.SelectedValue}");

      if (i > 0)
        new frmXListeWithChiffrage("CHANTIER", i).ShowDialog();

    }
  }
}