using DevExpress.Pdf.Native;
using DevExpress.XtraEditors;
using Microsoft.VisualBasic;
using MozartCS.Properties;
using MozartLib;
using MozartNet;
using MozartUC;
using ReportEmalec.Net;
using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Diagnostics;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Reflection;
using System.Text;
using System.Windows.Forms;

namespace MozartCS
{
  public partial class frmDetailstravaux : Form
  {
    public string mstrStatutAction;
    public int miSoustraitant;
    public int miContact;
    public string mstrTel;
    public string mstrPor;
    public string mstrTelAstr;
    public int iSiteNum;
    public string mstrDevisWeb;
    public string mstrPrest;
    public bool bWeb;           // pour savoir que l'on vient d'une DI web  en création
    public bool bMail;          // pour savoir que l'on vient d'une DI mail en création
    public bool bGDM;           // pour savoir que l'on vient d'une DI GDM en création
    public int iClientNum;
    //public bool MultiDI; // pour la gestion des créations de multi-DI => frmChoixMultiSites.mbMultiDi
    public bool bCreaWeb;
    public int miLocTech;
    public int iTypContrat;
    public bool AnnulerChoix;//=> frmChoixMultiSites.mbAnnulerChoix
                             // 3 modes de fonctionnment pour ce mode
                             // si "" alors par défaut donc on bascule en mode 2
                             // si "0" = tout est enabled (sauf si prestation = retour qualité et pas de message à la sélection d'un retour qualité)
                             // si "1" : tout est bloque
                             // si "2" : tout est enabled = true mais message si sélection retour qualité dans prestation
    public string sModeReadOnly;


    int iTextBoxDate;
    int iLockPage;
    bool bTousSites;
    int bDIInvEquip;
    bool bTousEquipements;
    bool binitcombo;
    //bool bAffInfo; // gestion de l'affichage des messages soustraitant // plus utilisé
    bool bAffEtatModif; // gestion de l'affichage des messages soustraitant
    bool bDroitVisa; // droit sur la coche visa arr et exec
    bool bModif;
    bool bDevisCL;
    bool bMsgDevisCL;
    bool bInit;
    bool bCrea;
    int iCodeCotraitance;
    bool bReclam;
    bool bFirst;
    bool bPrem;
    bool bActReccur;
    string strSiteGIDT = "";
    int NbEvenement = 0;

    // FGA  déclaration d'un évenement pour la gestion de la modification du contrat dans frmAddAction
    public event Action<int> ModificationContrat;

    bool bKPIGest_DatePrev;
    // gestion d'un statut indiquant si on est entrain de valider une date d'exécution sur l'action
    string statutExecution = "";
    // gestion d'un statut indiquant si on est entrain de valider une date de planification sur l'action
    string statutPlanification = "";
    // Utiliser pour stocker les secondes de la date d execution
    string nSecondTempDatArr = "";
    string nSecondTempDatExe = "";
    // test si can est un chantier
    bool bNCANChantier;
    // pour la liste des libelles HR Chantier
    DataTable dtHRChantier = new DataTable();
    // variable utiliser pour le changement de prestations
    bool bChangeprest;

    int iContratPerNum;
    int iTypeFact;

    DataTable dtLettre = new DataTable();

    List<CACT_LOG_ETAT_DETAIL> oTabAct_Log_Etat;

    private string _dateCreation;

    private bool bManageDelaiContKPI;

    class cboFactRavelItem
    {
      private int _NFOUFACNUM;
      private string _CDE;
      public cboFactRavelItem(int NFOUFACNUM, string CDE) { _CDE = CDE; _NFOUFACNUM = NFOUFACNUM; }
      public string CDE
      {
        get { return _CDE; }
      }
      public int NFOUFACNUM
      {
        get { return _NFOUFACNUM; }
      }
      public override string ToString()
      {
        return CDE;
      }
    }

    public frmDetailstravaux() { InitializeComponent(); }

    private void frmDetailstravaux_Load(object sender, System.EventArgs e)
    {
      try
      {
        Cursor.Current = Cursors.WaitCursor;
        ModuleMain.Initboutons(this);

        //init du 16/05/2024
        cboFactRavel.Visible = ModuleMain.RechercheDroitMenu(727);
        lblLabels11.Visible = txtFour.Visible = ModuleMain.RechercheDroitMenu(txtFour.HelpContextID);

        //pavé exe
        lblLabels23.Visible = txtDateA3.Visible = lblLabels26.Visible = cboH.Visible =
        lblLabels31.Visible = cboM.Visible = cmdDate4.Visible = cmdSupp4.Visible =
        lblQuiArr.Visible = chkVisaArr.Visible = ModuleMain.RechercheDroitMenu(735);

        lblLabels8.Visible = txtDateA2.Visible = lblLabels36.Visible = cboHE.Visible = lblLabels35.Visible = cboME.Visible =
        cmdDate3.Visible = cmdSupp3.Visible = lblQuiExec.Visible = chkVisaExec.Visible = ModuleMain.RechercheDroitMenu(735);

        lblLabels5.Visible = txtAttach.Visible = lblQuiAttach.Visible = ModuleMain.RechercheDroitMenu(735);

        // evite couleur modifiée si bouton disable
        foreach (Control c in Frame4.Controls)
        {
          if (c is Button)
          {
            c.BackColor = SystemColors.Control;
            c.ForeColor = SystemColors.ControlText;
          }
        }

        // modMain.bas InitRecordset
        dtLettre.Columns.Add(new DataColumn("IDdest", Type.GetType("System.Int64")));
        dtLettre.Columns.Add(new DataColumn("TypeDest", Type.GetType("System.String")));

        bChangeprest = false;
        bFirst = true;
        bPrem = true;
        bActReccur = false;

        CmdDetailAttachHeures.Visible = false;
        oTabAct_Log_Etat = new List<CACT_LOG_ETAT_DETAIL>();

        if (MozartParams.NomSociete == "EMALECMPM") CmdDetailAttachHeures.Visible = true;

        // on positionne le label et loptionbuttons sur la meme position que sous traitant de maintenance
        lblLabels40.Top = lblLabels19.Top;
        lblLabels40.Left = lblLabels19.Left;
        optInter3.Top = lblLabels40.Top;
        optInter3.Left = lblLabels40.Left + lblLabels40.Width + 20;

        lblLabels48.Visible = false;
        TxtHeuresDevis.Visible = false;

        bAffEtatModif = true;
        bMsgDevisCL = true;
        bKPIGest_DatePrev = false;

        nSecondTempDatArr = "00";
        nSecondTempDatExe = "00";

        Timer1.Enabled = false;
        Timer2.Enabled = false;

        //  on initialise à Locké
        iLockPage = 1;
        bNCANChantier = false;
        InitRecordsetArticle();

        bInit = true;

        DetailstravauxUtils.RemplirComboHM(cboHrRDV, "H");
        cboHrRDV.Items.Insert(0, "");
        cboHrRDV.SelectedIndex = 0;

        cboMinRDV.Items.Add("");
        cboMinRDV.Items.Add("00");
        cboMinRDV.Items.Add("15");
        cboMinRDV.Items.Add("30");
        cboMinRDV.Items.Add("45");

        DetailstravauxUtils.RemplirComboHM(cboH, "H");
        DetailstravauxUtils.RemplirComboHM(cboM, "M");
        DetailstravauxUtils.RemplirComboHM(cboHE, "H");
        DetailstravauxUtils.RemplirComboHM(cboME, "M");

        RemplirComboSemaines();
        Utils.InitComboBox(cboEtatCO, $"select CETACPL, VETACPLLIB from TREF_ETACPL where langue = '{MozartParams.Langue}'");
        Utils.InitComboBox(cboEtatAdminCpl, $"select CETATADMINCPL, VETATADMINCPLLIB from TREF_ETATADMINCPL where langue = '{MozartParams.Langue}'");

        cboInter1.Init(MozartDatabase.cnxMozart, "select NPERNUM, left(VPERNOM, 10) + ' ' + left(VPERPRE,10) as VPERNOM from TPER where VSOCIETE = App_Name() AND CPERACTIF = 'O' and (cpertyp <> 'TE' or nperstd is not null) ORDER BY  left(VPERNOM, 10) + ' ' + left(VPERPRE,10)", "NPERNUM", "VPERNOM", new List<string> { Resources.col_Num, Resources.col_Nom }, 150, 550);

        // Greg 12/12/2013
        // possibilité de selection la génération d'une declaration N4
        cboN4.Init(MozartDatabase.cnxMozart, "SELECT 1 AS NTYPEN4ID, 'Installation Initiale' AS VTYPEN4LIB UNION SELECT 2 AS NTYPEN4ID,'Modification'  AS VTYPEN4LIB UNION SELECT 3 AS NTYPEN4ID,'Validation'  AS VTYPEN4LIB",
                                   "NTYPEN4ID", "VTYPEN4LIB", new List<string>() { Resources.col_Num, Resources.col_Nom }, 150, 550);

        bDroitVisa = ModuleMain.RechercheDroitMenu( 408);

        InitApiTgridHrChantier();

        // traitement du cas de modification ou de création
        if (mstrStatutAction == "C")
        {
          OuvertureEnCreation();
          bCrea = true;
        }
        else
        {
          OuvertureEnModification();
          bCrea = false;
        }
        bInit = false;

        // fg le 10/03/2015
        // il faut le faire après le chargement de tous les controles et combo pour avoir les bonnes valeurs
        // si préventive et exécutées, on libère le champs durée
        if ((string)cboPrest.SelectedValue == "P" && (string)cboEtat.SelectedValue == "E") txtduree.Enabled = true;

        // init affichage selon le NDINCTE, si 996 salaires alors on change le libellé de certains label
        if (txtCompte.Text == "996")
        {
          // ancienne le label N° cmd client
          lblLabels32.Text = Resources.lib_nb_jour_CP;
          // ancienne le label Montant estimé (€) :
          lblLabels24.Text = Resources.lib_temps_partiel;
        }

        // si contrat EI, possibilité de declaration N4
        if (iTypContrat == 247)
        {
          chkN4.Visible = true;
          cmdSuiviPlanEvacEI.Visible = ModuleMain.RechercheDroitMenu(574);
        }
        else
        {
          chkN4.Visible = false;
          cmdSuiviPlanEvacEI.Visible = false;
        }

        // droit sur le bouton blocage pavé
        // si droit, on enable le txtWhy de raison
        // sinon, on met le bouton visible mais enable et le txtwhy enable
        if (ModuleMain.RechercheDroitMenu(335))
        {
          txtWhyBlocage.Enabled = cmdBlockPave.Enabled = true;
        }
        else
        {
          cmdBlockPave.Visible = true;
          txtWhyBlocage.Enabled = cmdBlockPave.Enabled = false;
        }
        // droit sur la combo de choix des semaines de replanification
        cboSemaines.Enabled = ModuleMain.RechercheDroitMenu(550);

        // test si form en read only
        if (sModeReadOnly == "1") FormReadOnly();

        // --------------------------------------------------------
        // Trt spécifique GDM
        if (bGDM)
        {
          // En création uniquement, on positionne la prestation par défaut
          cboPrest.SelectedValue = mstrPrest;
        }

        //  a la demande de JJ le 05/03/2019, on naffiche le chkbox que pour MPM
        //if (MozartParams.NomSociete != "EMALECMPM") ChkR_AND_D.Visible = false;
        ChkR_AND_D.Visible = false;

        // spécifique ARGEDIS
        strSiteGIDT = SiteGIDT();

        //FGA le 11 / 06 / 24
        // si site des JO, on affiche un message
        //DetailstravauxUtils.AffichageMessageJO2024(iSiteNum);

        if (iClientNum == 19678)
        { chkP5.Visible = true; }

      }
      catch (Exception ex) { Utils.ShowError(ex, $"{MethodBase.GetCurrentMethod().Name} dans {this.Name}"); }
      finally { Cursor.Current = Cursors.Default; }
    }

    private void cmdEnvoiSynergee_Click(object sender, System.EventArgs e)
    {
      // Recherche de la plateforme pour ce client
      string sEditeur = getEditeurGMAO();

      switch (sEditeur)
      {
        case "":
          MessageBox.Show("Ce client n'est paramétré sur aucune plateforme d'échange !", Program.AppTitle, MessageBoxButtons.OK, MessageBoxIcon.Information);
          break;

        case "GDM":
          //envoiGDM();

          frmMenuGDM frmD = new frmMenuGDM(MozartParams.NumAction, txtNumGMAO.Text);
          frmD.ShowDialog();
          if (frmD.strObservation != "")
          {
            txtObserv.Text = $"{MozartParams.strUID} {DateTime.Now.ToString("dd/MM/yy HH:mm")} : {frmD.strObservation} {Environment.NewLine}{txtObserv.Text}";
            // c'est déjà fait dans frmMenuGDM
            //ModuleData.ExecuteNonQuery($"update TACT set VACTOBS = '{txtObserv.Text.Replace("'", "''")}'  Where NACTNUM = {MozartParams.NumAction}");
          }

          break;

        case "SYNERGEE":
          frmMenuSynergee frmS = new frmMenuSynergee(MozartParams.NumAction);
          frmS.ShowDialog();
          if (frmS.strObservation != "")
          {
            txtObserv.Text = $"{MozartParams.strUID} {DateTime.Now.ToString("dd/MM/yy HH:mm")} : {frmS.strObservation} {Environment.NewLine}{txtObserv.Text}";
            ModuleData.ExecuteNonQuery($"update TACT set VACTOBS = '{txtObserv.Text.Replace("'", "''")}'  Where NACTNUM = {MozartParams.NumAction}");
          }
          break;

        //case "KIMOCE":
        //  new frmMenuKimoce(MozartParams.NumAction, MozartParams.Action).ShowDialog();
        //  break;

        case "PLANON":
          frmMenuPlanon frmP = new frmMenuPlanon(MozartParams.NumAction, txtNumGMAO.Text, txtduree.Text);
          frmP.ShowDialog();
          if (frmP.strObservation != "")
          {
            txtObserv.Text = $"{MozartParams.strUID} {DateTime.Now.ToString("dd/MM/yy HH:mm")} : {frmP.strObservation} {Environment.NewLine}{txtObserv.Text}";
            ModuleData.ExecuteNonQuery($"update TACT set VACTOBS = '{txtObserv.Text.Replace("'", "''")}'  Where NACTNUM = {MozartParams.NumAction}");
          }
          if (frmP.strGMAO != "")
          {
            txtNumGMAO.Text = frmP.strGMAO;
            ModuleData.ExecuteNonQuery($"update TACTCOMP set VACTNUMGMAO = '{frmP.strGMAO}' Where NACTNUM = {MozartParams.NumAction}");
          }

          break;

        case "GERONIMMO":
          frmMenuGeronimmo frmG = new frmMenuGeronimmo(MozartParams.NumAction, _dateCreation, txtDateA1.Text, txtDateA2.Text);
          frmG.ShowDialog();
          if (frmG.strObservation != "")
          {
            txtObserv.Text = $"{MozartParams.strUID} {DateTime.Now.ToString("dd/MM/yy HH:mm")} : {frmG.strObservation} {Environment.NewLine}{txtObserv.Text}";
            ModuleData.ExecuteNonQuery($"update TACT set VACTOBS = '{txtObserv.Text.Replace("'", "''")}'  Where NACTNUM = {MozartParams.NumAction}");
          }
          break;

        case "EMPLUS":
          if (txtNumGMAO.Text == "")
          {
            MessageBox.Show("Il faut un numéro de GMAO pour continuer", Program.AppTitle, MessageBoxButtons.OK, MessageBoxIcon.Information);
            return;
          }

          frmMenuEmPlus frm = new frmMenuEmPlus(MozartParams.NumAction, txtNumGMAO.Text, _dateCreation, txtDateA1.Text, txtDateA2.Text, txtQui.Text);
          frm.ShowDialog();
          if (frm.strObservation != "")
          {
            txtObserv.Text = $"{MozartParams.strUID} {DateTime.Now.ToString("dd/MM/yy HH:mm")} : {frm.strObservation} {Environment.NewLine}{txtObserv.Text}";
            ModuleData.ExecuteNonQuery($"update TACT set VACTOBS = '{txtObserv.Text.Replace("'", "''")}'  Where NACTNUM = {MozartParams.NumAction}");
          }
          break;

        case "DAISY":
          if (txtNumGMAO.Text == "")
          {
            MessageBox.Show("Il faut un numéro de GMAO pour continuer", Program.AppTitle, MessageBoxButtons.OK, MessageBoxIcon.Information);
            return;
          }

          frmTotalDaisy lFrmDaisy = new frmTotalDaisy(MozartParams.NumAction, txtNumGMAO.Text);
          lFrmDaisy.ShowDialog();
          if (lFrmDaisy.strObservation != "")
          {
            txtObserv.Text = $"{MozartParams.strUID} {DateTime.Now:dd/MM/yy HH:mm} : {lFrmDaisy.strObservation} {Environment.NewLine}{txtObserv.Text}";
            ModuleData.ExecuteNonQuery($"UPDATE TACT SET VACTOBS = '{txtObserv.Text.Replace("'", "''")}'  WHERE NACTNUM = {MozartParams.NumAction}");
          }
          break;

        default:
          // Autre éditeur : Non géré
          break;
      }
    }

    private void cmdDureeP2_Click(object sender, System.EventArgs e)
    {
      new frmGestContSite
      {
        msDuree = txtduree.Text,
        miNumSite = iSiteNum
      }.ShowDialog();
    }

    private void cmdStt_Click(object sender, System.EventArgs e)
    {
      if (txtInter.Text == "") return;
      try
      {
        using (SqlDataReader reader = ModuleData.ExecuteReader($"SELECT F.NSTFGRPNUM, VSTFGRPNOM from TSTF F INNER JOIN TSTFGRP G ON F.NSTFGRPNUM=G.NSTFGRPNUM WHERE NSTFNUM = {txtInter.Tag}"))
        {
          if (reader.Read())
          {
            // FG le 26/05/14 lien vers le groupe et pas vers le site
            // MODIF MC le 19/09/2014 CAR RECORDSET NON INIT
            new frmGestFournisseurs
            {
              miNumSTF = (int)Utils.ZeroIfNull(reader["NSTFGRPNUM"]),
              mstrNomSTF = Utils.BlankIfNull(reader["VSTFGRPNOM"])
            }.ShowDialog();
          }
        }
      }
      catch (Exception ex) { Utils.ShowError(ex, $"{MethodBase.GetCurrentMethod().Name} dans {this.Name}"); }
    }
    //Private Sub cmdStt_Click()
    //Dim pRST As ADODB.Recordset
    //
    //On Error GoTo handler
    //
    //    If txtInter = "" Then Exit Sub
    //    
    //    Set pRST = New ADODB.Recordset
    //    pRST.Open "SELECT F.NSTFGRPNUM, VSTFGRPNOM from TSTF F INNER JOIN TSTFGRP G ON F.NSTFGRPNUM=G.NSTFGRPNUM WHERE NSTFNUM = " & txtInter.Tag, cnx
    //    If pRST.EOF Then Exit Sub
    //      
    //    
    //    'FG le 26/05/14 lien vers le groupe et pas vers le site
    //    'MODIF MC le 19/09/2014 CAR RECORDSET NON INIT
    //    Dim oGestFoDetail As New frmGestFournisseurs
    //    
    //    oGestFoDetail.miNumSTF = pRST("NSTFGRPNUM")
    //    oGestFoDetail.mstrNomSTF = pRST("VSTFGRPNOM")
    //    oGestFoDetail.Show vbModal
    //       
    //    Set oGestFoDetail = Nothing
    //   
    //'    frmDetailsSiteSTF.mstrStatut = "M"
    //'    frmDetailsSiteSTF.miNumSTFGRP = pRST("NSTFGRPNUM")
    //'    frmDetailsSiteSTF.miNumSTF = txtInter.Tag
    //'    frmDetailsSiteSTF.Show vbModal
    //    pRST.Close
    //
    //Exit Sub
    //Resume
    //handler:
    //  ShowError "cmdStt_Click dans " & Me.Name
    //End Sub
    //
    /* --------------------------------------------------------------------------------------- */
    private void cmdActionFR_Click(object sender, System.EventArgs e)
    {
      framActionFR.Visible = !framActionFR.Visible;
      framActionFR.Top = 5400 / 15;
      framActionFR.Width = 14055 / 15;
      framActionFR.Height = 4215 / 15;
      framActionFR.Left = 1680 / 15;
    }
    //Private Sub cmdActionFR_Click()
    //  If framActionFR.Visible = True Then
    //    framActionFR.Visible = False
    //  Else
    //    framActionFR.Visible = True
    //  End If
    //  framActionFR.Top = 5400
    //  framActionFR.width = 14055
    //  framActionFR.height = 4215
    //  framActionFR.Left = 1680
    //End Sub
    //
    /* --------------------------------------------------------------------------------------- */
    private void cmdCloseFR_Click(object sender, System.EventArgs e)
    {
      framActionFR.Visible = false;
    }
    //Private Sub cmdCloseFR_Click()
    //  framActionFR.Visible = False
    //End Sub
    //
    /* --------------------------------------------------------------------------------------- */
    private void cmdBlockPave_Click(object sender, System.EventArgs e)
    {
      if (MozartParams.NumAction == 0) return;
      if (cmdBlockPave.Tag != null && (int)cmdBlockPave.Tag == 1)
      {
        cmdBlockPave.Tag = 0;
        cmdBlockPave.BackColor = MozartColors.ColorH8000000F;
      }
      else
      {
        cmdBlockPave.Tag = 1;
        cmdBlockPave.BackColor = MozartColors.ColorH8080FF;// red
      }
      // mise à jour de la base
      ModuleData.ExecuteNonQuery($"update  TACTCOMP set BACTPAVEBLOCK = {cmdBlockPave.Tag} where NACTNUM={MozartParams.NumAction}");
    }
    //Private Sub cmdBlockPave_Click()
    //  
    //If glNumAction = 0 Then Exit Sub
    //
    //  If cmdBlockPave.Tag = 1 Then
    //    cmdBlockPave.Tag = 0
    //    cmdBlockPave.BackColor = &H8000000F
    //  Else
    //    cmdBlockPave.Tag = 1
    //    cmdBlockPave.BackColor = &H8080FF 'red
    //  End If
    //  ' mise à jour de la base
    //  cnx.Execute "update  TACTCOMP set BACTPAVEBLOCK = " & cmdBlockPave.Tag & " where NACTNUM=" & glNumAction
    //End Sub
    //
    /* --------------------------------------------------------------------------------------- */
    private void cmdEnregistrer_Click(object sender, System.EventArgs e)
    {
      try
      {
        if (txtDateA1.Text == "" && txtDateA2.Text == "" && txtDateA0.Text == "")
        {
          MessageBox.Show(Resources.msg_date_souhaitee_obligatoire, Program.AppTitle, MessageBoxButtons.OK, MessageBoxIcon.Information);
          cmdDate1_Click(sender, e);
          return;
        }
        if (txtAction.Text == "")
        {
          MessageBox.Show(Resources.msg_action_obligatoire, Program.AppTitle, MessageBoxButtons.OK, MessageBoxIcon.Information);
          txtAction.Focus();
          return;
        }

        //  NL le 29/12/2016 : accolades interdites, fait planter le RTF!!!
        txtAction.Text = txtAction.Text.Replace("{", "(").Replace("}", ")");

        // la durée et le montant viennent du contrat lorsqu'on fait une prev
        if (txtduree.Text == "" && txtduree.Enabled)
        {
          MessageBox.Show(Resources.msg_indiquer_duree_action, Program.AppTitle, MessageBoxButtons.OK, MessageBoxIcon.Information);
          txtduree.Focus();
          return;
        }
        else
        {
          // test du format correct de la durée
          try
          {
            if (txtduree.Text != "") Convert.ToDouble(txtduree.Text);
          }
          catch
          {
            MessageBox.Show("Format incorrect de la durée", Program.AppTitle, MessageBoxButtons.OK, MessageBoxIcon.Information);
            txtduree.Focus();
            return;
          }
        }

        if (txtValeur.Text == "" && txtValeur.Enabled)
        {
          MessageBox.Show(Resources.msg_montant_estime_action, Program.AppTitle, MessageBoxButtons.OK, MessageBoxIcon.Information);
          txtValeur.Focus();
          return;
        }

        // Test pour les congés en temps Partiel
        if (txtCompte.Text == "996" && TestIfTpsPartiel((int)Utils.ZeroIfNull(txtInter.Tag)) && (txtValeur.Text == "" || txtValeur.Text == "0"))
          MessageBox.Show(Resources.msg_duree_temps_partiel_0, Program.AppTitle, MessageBoxButtons.OK, MessageBoxIcon.Information);

        // on vérifie les combo
        if (null == cboPrest.SelectedValue || (string)cboPrest.SelectedValue == "0")
        {
          MessageBox.Show(Resources.msg_select_prestation, Program.AppTitle, MessageBoxButtons.OK, MessageBoxIcon.Information);
          cboPrest.Focus();
          return;
        }

        string lTypePrestation = (string)cboPrest.SelectedValue;

        if (null == cboUrg.SelectedValue || (string)cboUrg.SelectedValue == "0")
        {
          MessageBox.Show(Resources.msg_select_urgence, Program.AppTitle, MessageBoxButtons.OK, MessageBoxIcon.Information);
          cboUrg.Focus();
          return;
        }

        if (null == cboTech.SelectedValue || (string)cboTech.SelectedValue == "0")
        {
          MessageBox.Show(Resources.msg_select_technique, Program.AppTitle, MessageBoxButtons.OK, MessageBoxIcon.Information);
          cboTech.Focus();
          return;
        }

        // si préventif, il faut une gamme
        if (lTypePrestation == "P" && cboGamme.Text == "")
        {
          if (!((iTypContrat == 475) && (iContratPerNum != 0) && ((iTypeFact != 0) || (iTypeFact != 1))))
          {
            MessageBox.Show(Resources.msg_action_prev_gamme_obligatoire, Program.AppTitle, MessageBoxButtons.OK, MessageBoxIcon.Information);
            cboGamme.Focus();
            return;
          }
        }

        // Si Exécuté, on vérifie que la date d'arrivée est saisie
        if ((lTypePrestation == "D") && (bManageDelaiContKPI) && ((txtDateA2.Text != "") && ((txtDateA3.Text == "") || ((cboH.Text == "00") && (cboM.Text == "00")))))
        {
          MessageBox.Show("L'heure et la date d'arrivée sont obligatoires pour cette action", Program.AppTitle, MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
          txtDateA3.Focus();
          return;
        }

        // si saisie des heures analytique en cours alors if faut obligatoirement cliquer sur valider
        if (FrameFicheHRSuivi.Visible)
        {
          MessageBox.Show(Resources.msg_valider_heures_analytiques, Program.AppTitle, MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
          return;
        }

        if (frameGidtCli.Visible && Utils.BlankIfNull(txtNumero.Tag) == "" && !bTousEquipements && strSiteGIDT == "GIDT")
        {
          MessageBox.Show(Resources.msg_select_materiel, Program.AppTitle, MessageBoxButtons.OK, MessageBoxIcon.Information);
          cmdRechEquipement.Focus();
          return;
        }

        // test du format de l'heure de rdv
        if ((cboHrRDV.Text != "" && cboMinRDV.Text == "") || (cboHrRDV.Text == "" && cboMinRDV.Text != ""))
        {
          MessageBox.Show(Resources.msg_heure_rdv_incorrecte, Program.AppTitle, MessageBoxButtons.OK, MessageBoxIcon.Information);
          return;
        }

        // test si plage horaire alors il faut un debut et une fin
        if (TxtRDVPlageHR0.Text != "" && TxtRDVPlageHR1.Text == "" || (TxtRDVPlageHR0.Text == "" && TxtRDVPlageHR1.Text != ""))
        {
          MessageBox.Show(Resources.msg_plage_heure_incorrecte, Program.AppTitle, MessageBoxButtons.OK, MessageBoxIcon.Information);
          return;
        }

        if (!verifDevisValide())
        {
          MessageBox.Show($"{Resources.err_action_non_visible_car_devis_pas_valide}", Program.AppTitle, MessageBoxButtons.OK, MessageBoxIcon.Error);
          return;
        }

        // Verif heure de rdv : une seule heure de rdv identique pour un tech dans la meme journee
        if (!VerifHrRdv())
        {
          MessageBox.Show(Resources.msg_2rdv_meme_jour_heure, Program.AppTitle, MessageBoxButtons.OK, MessageBoxIcon.Information);
          return;
        }

        // Test si reclamation client cochée, alors sélection obligatoire du type de process
        if (chkReclam.Checked && (int)cboProcess.SelectedValue == 0)
        {
          MessageBox.Show(Resources.msg_select_processus, Program.AppTitle, MessageBoxButtons.OK, MessageBoxIcon.Information);
          return;
        }

        // Test si reclamation client cochée, alors sélection obligatoire de la cause racine
        if (chkReclam.Checked && (int)cboCauseRacine.SelectedValue == 0)
        {
          MessageBox.Show(Resources.msg_select_cause_racine_nonconform, Program.AppTitle, MessageBoxButtons.OK, MessageBoxIcon.Information);
          return;
        }

        // Test format du montant de devis (cas récurrent avec ",,")  MC le 08/03/2016
        if (txtMontantDevis.Text.Split(',').Length > 2)
        {
          MessageBox.Show(Resources.msg_format_montant_devis, Program.AppTitle, MessageBoxButtons.OK, MessageBoxIcon.Information);
          return;
        }

        // En plus, il ne doit pas y avoir d'euros, de point, d'espace, etc... NL, le 27/05/2016 (Cas du copier/coller dans le champ!!!)
        for (int i = 0; i < txtMontantDevis.Text.Length; i++)
        {
          char c = txtMontantDevis.Text[i];
          if (!Char.IsNumber(c) && c != ',')
          {
            MessageBox.Show(Resources.msg_format_montant_devis_symboles, Program.AppTitle, MessageBoxButtons.OK, MessageBoxIcon.Information);
            return;
          }
        }

        // cas particulier de tous sites en création
        if (bTousSites && mstrStatutAction == "C")
        {

          //test si di inventaire
          // si oui, alors on affiche 
          if (bDIInvEquip == 1)
          {
            EnregistrerTousSitesBySelectionEquipement();

          }
          else
          { // création pour tous les sites du client
            EnregistrerTousSites();
          }
          //


          // fermeture de la fenetre
          //        gbRefresh = True
          //        If Not AnnulerChoix Then Unload Me
          bModif = false;
          if (!AnnulerChoix)
            this.Close();
          return;
        }

        if (bTousEquipements && mstrStatutAction == "C")
        {
          // création pour tous les équipements sélectionnés
          EnregistrerTousEquipements();
          // fermeture de la fenetre
          //        gbRefresh = True
          //        If Not AnnulerChoix Then Unload Me
          bModif = false;
          if (!AnnulerChoix)
            this.Close();
          return;
        }

        // Vérif et message si période de garantie (pour les travaux et depannage)
        if (lTypePrestation == "D" || lTypePrestation == "T")
        {
          using (SqlDataReader reader = ModuleData.ExecuteReader($"select DSITDCREMAG,COALESCE(NSITGARANTIE,1) FROM TSIT WITH (NOLOCK) WHERE NSITNUM = {iSiteNum}"))
          {
            if (reader.Read() && !Convert.IsDBNull(reader["DSITDCREMAG"])
              && Convert.ToDateTime(reader["DSITDCREMAG"]).AddYears((int)Utils.ZeroIfNull(reader[1])) >= DateTime.Today)
              MessageBox.Show($"{Resources.msg_date_renovation_site}{Utils.DateBlankIfNull(reader["DSITDCREMAG"])}.{Environment.NewLine}{Environment.NewLine}" +
                              $"{Resources.msg_depannage_susceptible_garantie}{Environment.NewLine}" +
                              $"{Resources.msg_prendre_decisions_consequences}", Resources.msg_periode_garantie, MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
          }
        }

        // test si stt en garantie sur le site
        if (mstrStatutAction == "C" && lTypePrestation != "P" && ExisteSTTgarantie(iSiteNum))
        {
          MessageBox.Show($"{Resources.msg_alerte_installations_garanties}{Environment.NewLine}" +
                          $"{Resources.msg_verif_prestation_pas_sous_garantie}{Environment.NewLine}" +
                          $"{Resources.msg_voir_detail_site_entreprise}{Environment.NewLine}" +
                          $"{Resources.msg_install_garantie_alert_charge}{Environment.NewLine}" +
                          $"{Resources.msg_hesite_voir_charge}{Environment.NewLine}",
                          Program.AppTitle, MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
        }

        //  test si c'est un devis web d'un technicien
        //  alors il faut tester la vision web
        if (mstrDevisWeb == "OUI" && chkWeb.Checked)
          MessageBox.Show(Resources.msg_action_hors_web, Program.AppTitle, MessageBoxButtons.OK, MessageBoxIcon.Exclamation);

        if (MozartParams.NumMsgSTWeb != 0)
        {
          ModuleData.ExecuteNonQuery($"UPDATE TWMESSTF SET DMESSSTFTRAITE = GETDATE() WHERE ID = {MozartParams.NumMsgSTWeb}");
          MozartParams.NumMsgSTWeb = 0;
        }

        EnregistrerAction();

        if (MozartParams.NumActTablet != 0)
        {
          if (MozartParams.NumCSTTablet != 0)
            ModuleData.ExecuteNonQuery($"UPDATE TACTTABLETSTF SET DDATVALIDATION = GETDATE(), NPERNUM = {MozartParams.UID} WHERE NACTNUM = {MozartParams.NumActTablet} AND NCSTNUM = {MozartParams.NumCSTTablet}");
          else
            ModuleData.ExecuteNonQuery($"UPDATE TACTTABLET SET DDATVALIDATION = GETDATE(), NPERNUM = {MozartParams.UID} WHERE NACTNUM = {MozartParams.NumActTablet}");
          MozartParams.NumActTablet = 0;
          MozartParams.NumCSTTablet = 0;
        }


        //on sauvegade les events sur combo etat (pour stats planning) MC le //05/09/2023       
        if (oTabAct_Log_Etat.Count > 0)
        {

          foreach (CACT_LOG_ETAT_DETAIL drsave in oTabAct_Log_Etat)
          {
            SqlCommand sqlcmd = new SqlCommand("[api_sp_CreationActLogEtat]", MozartDatabase.cnxMozart);
            sqlcmd.CommandType = CommandType.StoredProcedure;
            SqlCommandBuilder.DeriveParameters(sqlcmd);    // liste des paramètres
            sqlcmd.Parameters["@P_NID_ACT_LOG_ETAT"].Value = drsave.NID_ACT_LOG_ETAT;
            sqlcmd.Parameters["@P_NACTNUM"].Value = drsave.NACTNUM == 0 ? MozartParams.NumAction : drsave.NACTNUM;
            sqlcmd.Parameters["@P_NQUICREE"].Value = drsave.NQUICREE;
            sqlcmd.Parameters["@P_DQUICREE"].Value = drsave.DQUICREE;
            sqlcmd.Parameters["@P_CETACOD"].Value = drsave.CETACOD;
            sqlcmd.ExecuteNonQuery();
          }
          //reinit
          oTabAct_Log_Etat.Clear();

        }

        // envoi de l'attachement et de la gamme si exe
        // TB SAMSIC CITY SPEC
        if ((iClientNum == 908 || iClientNum == 12277) && MozartParams.NomGroupe == "EMALEC")
        {
          // exe et prev
          if (txtDateA2.Text != "" && lTypePrestation == "P" && !chkWeb.Checked)
            DetailstravauxUtils.SendMailAttachementAndGamme(MozartParams.NumAction, iClientNum);
        }
        else if (iClientNum == 13488 && MozartParams.NomGroupe == "EMALEC")
        { // TB SAMSIC CITY SPEC
          // Condition qui dépend d'un client spécifique
          // exe et prev
          if (txtDateA2.Text != "" && lTypePrestation == "P" && !chkWeb.Checked)
            ModuleData.ExecuteNonQuery($"EXEC [api_sp_SaveActionExeEndOfDay] {MozartParams.NumAction}, {iClientNum}");
        }
        else if (iClientNum == 17368 && MozartParams.NomGroupe == "EMALEC")
        { // client TOTAL (uniquement compte 599 et prève
          // exe
          if (txtDateA2.Text != "" && !chkWeb.Checked && txtCompte.Text == "599")
            DetailstravauxUtils.SendMailAttachementAndGamme(MozartParams.NumAction, iClientNum);
        }
        else if (iClientNum == 13894 && MozartParams.NomGroupe == "EMALEC")
        { //CLAIRES seulement pour le compte 511
          // exe
          if (txtDateA2.Text != "" && !chkWeb.Checked && txtCompte.Text == "511")
            DetailstravauxUtils.SendMailAttachementAndGamme(MozartParams.NumAction, iClientNum);
        }
        else if (iClientNum == 91 && MozartParams.NomGroupe == "EMALEC") // SPIR
        {// TB SAMSIC CITY SPEC
         // Condition qui dépend d'un client spécifique
         // exe
          if (txtDateA2.Text != "" && !chkWeb.Checked)
            DetailstravauxUtils.SendMailAttachementAndGamme(MozartParams.NumAction, iClientNum);
        }
        else if (iClientNum == 20171 && MozartParams.NomGroupe == "EMALEC") // electra
        {// exe
          if (txtDateA2.Text != "" && lTypePrestation == "P" && !chkWeb.Checked)
            DetailstravauxUtils.SendMailAttachementAndGamme(MozartParams.NumAction, iClientNum);
        }
        else if ((iClientNum == 13424) && MozartParams.NomGroupe == "EMALEC")
        { //CARGLASS
          // exe
          if (txtDateA2.Text != "" && !chkWeb.Checked && txtCompte.Text == "593")
            DetailstravauxUtils.SendMailAttachementAndGamme(MozartParams.NumAction, iClientNum);
        }
        else if ((iClientNum == 20268) && MozartParams.NomGroupe == "EMALEC")
        { //HERTZ FRANCE
          // exe
          if (txtDateA2.Text != "" && !chkWeb.Checked)
            DetailstravauxUtils.SendMailAttachementAndGamme(MozartParams.NumAction, iClientNum);
        }
        else if (((iClientNum == 17833) || (iClientNum == 20358)) && MozartParams.NomGroupe == "EMALEC")
        {
          // FNAC DARTY et MOBILIZE

          // ENVOI DE LA GAMME exe et prev
          if (txtDateA2.Text != "" && lTypePrestation == "P" && !chkWeb.Checked)
            DetailstravauxUtils.SendMailGamme(MozartParams.NumAction, iClientNum);
        }

        // creation d'une action chiffrée si urgence = astreinte ou rapide pour les dépannages
        if (mstrStatutAction == "C" && lTypePrestation == "D" && ((string)cboUrg.SelectedValue == "4" || (string)cboUrg.SelectedValue == "1"))
        {
          // Conditions qui dépendent de clients spécifiques
          int chiffreAuto = 0;
          switch (iClientNum)
          {
            case 19732:
              // 15 euros pour le client MAISON DU MONDE 
              chiffreAuto = 15;
              break;
            case 251:
              // 150 euros pour le client NOCIBE
              chiffreAuto = 150;
              break;
            case 1751:
              chiffreAuto = 100;
              break;
          }
          if (chiffreAuto != 0)
          {
            MessageBox.Show("Une action chiffrée a été créée pour les frais de gestion de l'intervention", Program.AppTitle, MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
            ModuleData.ExecuteNonQuery($"EXEC api_sp_creationActionChiffreAuto {MozartParams.NumAction}, {chiffreAuto}");
          }
        }

        // traitement du cas de création et passage en NF pour les actions EMALEC
        // FGA 08/09/22 je traite cela dans la prock stock
        //if (mstrStatutAction == "C" && iClientNum == MozartParams.SOCIETE)
        //ModuleData.ExecuteNonQuery($"UPDATE TACT SET CACTSTA = 'N' WHERE NACTNUM = {MozartParams.NumAction}"); 

        // envoi d'un mail au responsable du process
        if ((mstrStatutAction == "C" && chkReclam.Checked && (int)cboProcess.SelectedValue > 0) ||
            (mstrStatutAction == "M" && bReclam == false && chkReclam.Checked && (int)cboProcess.SelectedValue > 0))
        {
          ModuleData.ExecuteNonQuery($"EXEC api_sp_EnvoiMsgNewReclamation {cboProcess.SelectedValue},{MozartParams.NumAction}");
        }

        mstrDevisWeb = "";

        // GESTION DE L'OUVERTURE AUTOMATIQUE DE LA NOTATION DES STT
        // ouverture de la notation STT si STT et si enregistrement d'une date d'exec
        // FGA 18/11/2021
        if (IsSTF((string)lblInter.Tag) && txtDateA2.Text != "" && statutExecution == "")
          cmdNotation_Click(sender, null);
        else if (IsSTF((string)lblInter.Tag) && txtDateA1.Text != "" && statutPlanification == "" && lTypePrestation != "P")
          // ouverture de la notation STT si STT et si enregistrement d'une date de planification et si pas préventif (Sylvie le 26/10/22)
          cmdNotation_Click(sender, null);

        //envoi mail si creation pavé malade ou abscence
        List<int> SitesRH = new List<int> { 3003, 1104 };
        if (iClientNum == 108 && SitesRH.Contains(iSiteNum) && mstrStatutAction == "C")
        {
          if (optInter0.Checked && txtInter.Tag != null)
          {
            ModuleData.ExecuteNonQuery($"EXEC [api_sp_EnvoiMsgAjoutMaladieAbs] {MozartParams.NumAction}");
          }
        }

        // FGA le 18/09 : message pour Primark
        if (txtNumGMAO.Text != "" && mstrStatutAction == "C" && iClientNum == 17571)
        {
          string m = $"Vous venez de créer une nouvelle demande Primark avec un N° de ticket.\nAvez-vous bien validé sur " +
            $"la GMAO du client cette prise en charge par EMALEC ? \n\n" +
            $"Le délai contractuel pour confirmer cette prise en charge est de 10 minutes.";
          MessageBox.Show(m, Program.AppTitle, MessageBoxButtons.OK, MessageBoxIcon.Information);
        }

        // on passe la feuille en statut modifier
        mstrStatutAction = "M";

        OuvertureEnModification();

        //  gbRefresh = True
        bModif = false;
      }
      //catch (Exception ex) { MessageBox.Show($"{ex.Message}\r\n\r\n{Resources.Global_dans}{MethodBase.GetCurrentMethod().Name}", Resources.Global_Erreur, MessageBoxButtons.OK, MessageBoxIcon.Exclamation); }
      catch (Exception ex) { Utils.ShowError(ex, $"{MethodBase.GetCurrentMethod().Name} dans {this.Name}"); }
    }

    private void cmdvaliderFicHRSuivi_Click(object sender, System.EventArgs e)
    {
      txtduree.Text = TotHrChantier().ToString();
      FrameFicheHRSuivi.Visible = false;

    }

    private void cmdDevis_Click(object sender, System.EventArgs e)
    {
      try
      {
        // test si prestation appel en garantie
        if ((string)cboPrest.SelectedValue == "B")
        {
          MessageBox.Show(Resources.msg_pas_creer_devis_prestation_garantie, Program.AppTitle, MessageBoxButtons.OK, MessageBoxIcon.Information);
          return;
        }

        //  test si on a un sous traitant ou pas
        if (IsSTF((string)lblInter.Tag))
        {
          // test des documents administratifs
          string sVerifDocs = DetailstravauxUtils.VerificationDocStt(MozartParams.NumAction);
          if (sVerifDocs != "")
            MessageBox.Show($"{Resources.msg_doc_manquants}{sVerifDocs.Replace("#", $"{Environment.NewLine} . ")}{Environment.NewLine}{Environment.NewLine}" +
                            $"{Resources.msg_demander_STT}", Program.AppTitle, MessageBoxButtons.OK, MessageBoxIcon.Information);

          //    test si on a deja un devis pour cette action : si oui, on affiche un écran avec la liste des devis pour cette action avec les boutons modifier, nouveau, supprimer
          int nb = (int)ModuleData.ExecuteScalarInt($"select count(NACTNUM) from api_v_devisST where NACTNUM = {MozartParams.NumAction}");
          if (nb > 0)
          {
            new frmListeDevisST
            {
              mstrStatutDevis = "A",
              mstrPPS = 0, //'chkPPSdem 'on passe à 0 car on gere les pps différemment depuis le 14 / 09 / 2017 MC
              bAsPrest = DetailstravauxUtils.DiAsDevisClientPrest(MozartParams.NumAction)
            }.ShowDialog();
          }
          else
          {
            // on a pas de devis, alors on passe directement en création si pas de devis client prestation
            // et si devis prestation existe on affiche la liste vide avec chois de faire un devis simple ou un devis prestation
            if (DetailstravauxUtils.DiAsDevisClientPrest(MozartParams.NumAction))
            {
              new frmListeDevisST
              {
                mstrStatutDevis = "A",
                mstrPPS = 0, // 'chkPPSdem 'on passe à 0 car on gere les pps différemment depuis le 14 / 09 / 2017 MC
                bAsPrest = true
              }.ShowDialog();
            }
            else
            {
              new frmDevisAutoST
              {
                miNumDevisST = 0,
                mstrPPS = 0 //'chkPPSdem 'on passe à 0 car on gere les pps différemment depuis le 14 / 09 / 2017 MC
              }.ShowDialog();
            }
          }

          //   rafraichir l'affichage
          OuvertureEnModification();
        }
        else
        {
          // FGA le 13/07/22  ; pouvoir afficher la liste des demandes de devis même si on a plus de STT sur l'action
          // on a pu en avoir  à un moment, puis repasser sur un tech, mais on veut quand même consulter les demandes de devis
          // test des documents administratifs
          string sVerifDocs = DetailstravauxUtils.VerificationDocStt(MozartParams.NumAction);
          if (sVerifDocs != "")
            MessageBox.Show($"{Resources.msg_doc_manquants}{sVerifDocs.Replace("#", $"{Environment.NewLine} . ")}{Environment.NewLine}{Environment.NewLine}" +
                            $"{Resources.msg_demander_STT}", Program.AppTitle, MessageBoxButtons.OK, MessageBoxIcon.Information);

          //    test si on a deja un devis pour cette action si oui, on affiche un écran avec la liste des devis pour cette action avec les boutons modifier, nouveau, supprimer
          int nb = (int)ModuleData.ExecuteScalarInt($"select count(NACTNUM) from api_v_devisST where NACTNUM = {MozartParams.NumAction}");
          if (nb > 0)
          {
            new frmListeDevisST
            {
              mstrStatutDevis = "A",
              mstrPPS = 0, //'chkPPSdem 'on passe à 0 car on gere les pps différemment depuis le 14 / 09 / 2017 MC
              bAsPrest = DetailstravauxUtils.DiAsDevisClientPrest(MozartParams.NumAction)
            }.ShowDialog();
          }
          else
            MessageBox.Show(Resources.msg_si_intervenant_stt, Program.AppTitle, MessageBoxButtons.OK, MessageBoxIcon.Information);
        }
      }
      //catch (Exception ex) { MessageBox.Show($"{ex.Message}\r\n\r\n{Resources.Global_dans}{MethodBase.GetCurrentMethod().Name}", Resources.Global_Erreur, MessageBoxButtons.OK, MessageBoxIcon.Exclamation); }
      catch (Exception ex) { Utils.ShowError(ex, $"{MethodBase.GetCurrentMethod().Name} dans {this.Name}"); }
    }

    private void cmdCST_Click(object sender, System.EventArgs e)
    {
      try
      {
        if ((string)cboPrest.SelectedValue == "B")
        {
          MessageBox.Show(Resources.msg_pas_creer_contrat_st_prest_garantie, Program.AppTitle, MessageBoxButtons.OK, MessageBoxIcon.Information);
          return;
        }

        // test si on a un sous traitant ou pas
        if (IsSTF((string)lblInter.Tag))
        {
          // si c'est un cotraitant
          if (iCodeCotraitance > 1)
          {
            MessageBox.Show(Resources.msg_cotraitant_ordre_mission, Program.AppTitle, MessageBoxButtons.OK, MessageBoxIcon.Information);
            return;
          }

          // test si on a deja un contrat pour cette action
          // si oui, on affiche un écran avec la liste des contrats pour cette action
          // avec les boutons modifier, nouveau, supprimer
          int nb = (int)ModuleData.ExecuteScalarInt($"select count(NACTNUM) FROM dbo.TCST WITH (NOLOCK) where CCSTTYPE='P' AND NACTNUM = {MozartParams.NumAction}");

          if (nb > 0)
          {
            // si la DI n'est pas planifiée ou à planifier on ne peut pas créer de contrat
            frmListeContratsST frm = new frmListeContratsST();
            string etat = (string)cboEtat.SelectedValue;
            frm.bFacture = etat != "O" && etat != "P" && etat != "W";
            frm.mstrStatutContrat = "CST";
            frm.miNumST = (int)txtInter.Tag;
            frm.sDatePlanif = txtDateA1.Text;
            frm.ShowDialog();
          }
          else
          { //on a pas de contrat, alors on passe directement en création
            // si le PPS est non reçu, on ne peut pas passer de contrat
            if (CboPPS.SelectedIndex == 2)
            {
              MessageBox.Show(Resources.msg_pps_non_recu_pas_contrat, Program.AppTitle, MessageBoxButtons.OK, MessageBoxIcon.Information);
              return;
            }

            // pour faire un contrat, il faut une date de planification
            if (txtDateA1.Text == "")
            {
              MessageBox.Show(Resources.msg_date_planif_pour_contrat_stt, Program.AppTitle, MessageBoxButtons.OK, MessageBoxIcon.Information);
              cmdDate2_Click(null, null);
              return;
            }
            else if (txtDateA1.Text != "" && (string)txtDateA1.Tag == "")
            {
              MessageBox.Show(Resources.msg_enreg_date_planif, Program.AppTitle, MessageBoxButtons.OK, MessageBoxIcon.Information);
              return;
            }

            string sVerifDocs = DetailstravauxUtils.VerificationDocStt(MozartParams.NumAction);
            // pour les STT travaux (installation) impossible de passer contrat si documents manquent
            if (sVerifDocs != "")
            {
              if ((string)lblInter.Tag == "I")
              {
                MessageBox.Show($"{Resources.msg_doc_manquants}{sVerifDocs.Replace("#", $"{Environment.NewLine} . ")}{Environment.NewLine}" +
                                $"{Resources.msg_pas_passer_contrat}", Program.AppTitle, MessageBoxButtons.OK, MessageBoxIcon.Information);
                return;
              }
              else if ((string)lblInter.Tag == "S")
              {
                // pour les STT maintenance , avertissement
                MessageBox.Show($"{Resources.msg_doc_manquants}{sVerifDocs.Replace("#", $"{Environment.NewLine} . ")}{Environment.NewLine}" +
                                $"{Resources.msg_demander_STT}", Program.AppTitle, MessageBoxButtons.OK, MessageBoxIcon.Information);
              }
            }

            // test du CA et du statut social
            if (VerifStatutSTT(MozartParams.NumAction) == "KO")
            {
              MessageBox.Show($"Alerte:{Environment.NewLine}" +
                              $"{Resources.msg_select_stt_pour_lequel}{Environment.NewLine}" +
                              $"     {Resources.msg_le_CA_annuel_entreprise}{Environment.NewLine}" +
                              $"    {Resources.msg_et_ou}{Environment.NewLine}" +
                              $"     {Resources.msg_statut_social_non_renseigne}{Environment.NewLine}" +
                              $"{Resources.msg_verif_situation_dep_finance}{Environment.NewLine}" +
                              $"{Resources.msg_detail_stt_appel_stt_renseigne_champs}{Environment.NewLine}" +
                              $"{Resources.msg_creer_contrat_stt_si_renseigne}{Environment.NewLine}" +
                              $"{Resources.msg_pas_saisie_nimporte_quoi}{Environment.NewLine}" +
                              $"{Resources.msg_merci}{Environment.NewLine}",
                              Program.AppTitle, MessageBoxButtons.OK, MessageBoxIcon.Information);
              return;
            }

            // test si on a un devis client prestation sur la DI
            // dans ce cas on oblige de faire un contrat avec prestations
            if (DetailstravauxUtils.DiAsDevisClientPrest(MozartParams.NumAction))
            {
              new frmContratPrest
              {
                msTypeContrat = "P",
                miNumContratST = 0,
                msMontantDevis = txtMontantDevis.Text,
                msDatePlanif = txtDateA1.Text,
                bDesactive = false // on ne desactive pas les autres contrats de l'action
              }.ShowDialog();
            }
            else
            {
              MessageBox.Show(Resources.msg_pas_devis_di_pas_contrat_prest, Program.AppTitle, MessageBoxButtons.OK, MessageBoxIcon.Information);
              return;
            }
          }

          // rafraichir l'affichage
          OuvertureEnModification();
        }
        else
        {
          MessageBox.Show(Resources.msg_si_intervenant_stt, Program.AppTitle, MessageBoxButtons.OK, MessageBoxIcon.Information);
        }
      }
      //catch (Exception ex) { MessageBox.Show($"{ex.Message}\r\n\r\n{Resources.Global_dans}{MethodBase.GetCurrentMethod().Name}", Resources.Global_Erreur, MessageBoxButtons.OK, MessageBoxIcon.Exclamation); }
      catch (Exception ex) { Utils.ShowError(ex, $"{MethodBase.GetCurrentMethod().Name} dans {this.Name}"); }
    }


    private void cmdOMT_Click(object sender, EventArgs e)
    {
      try
      {
        if ((string)cboPrest.SelectedValue == "B")
        {
          MessageBox.Show(Resources.msg_pas_creer_contrat_st_prest_garantie, Program.AppTitle, MessageBoxButtons.OK, MessageBoxIcon.Information);
          return;
        }

        // pour faire un contrat, il faut une date de planification
        if (txtDateA1.Text == "")
        {
          MessageBox.Show(Resources.msg_date_planif_pour_contrat_stt, Program.AppTitle, MessageBoxButtons.OK, MessageBoxIcon.Information);
          cmdDate2_Click(sender, e);
          return;
        }
        else if (txtDateA1.Text != "" && (string)txtDateA1.Tag == "")
        {
          MessageBox.Show(Resources.msg_enreg_date_planif, Program.AppTitle, MessageBoxButtons.OK, MessageBoxIcon.Information);
          return;
        }

        // test si on a un sous traitant ou pas
        if (IsSTF((string)lblInter.Tag))
        {

          // test si on a deja un contrat OTM pour cette action
          // si oui, on affiche un écran avec la liste avec les boutons modifier, nouveau, supprimer
          int nb = (int)ModuleData.ExecuteScalarInt($"select count(NACTNUM) FROM dbo.TCST WITH (NOLOCK) where CCSTTYPE='M' AND NACTNUM = {MozartParams.NumAction}");
          if (nb > 0)
          {
            // si la DI n'est pas planifiée ou à planifier on ne peut pas créer de contrat
            string etat = (string)cboEtat.SelectedValue;
            frmListeOTM frm = new frmListeOTM();
            if (etat != "O" && etat != "P" && etat != "W") frm.mbFacture = true;
            frm.mstrStatut = "A";
            frm.sDatePlanif = txtDateA1.Text;
            frm.ShowDialog();
          }
          else
            // ouverture pr creation !!!!
            new frmOTM
            {
              msTypeContrat = "M",
              mNumContratOMT = 0,
              msDatePlanif = txtDateA1.Text,
            }.ShowDialog();

          // rafraichir l'affichage
          OuvertureEnModification();
        }
        else
        {
          MessageBox.Show(Resources.msg_si_intervenant_stt, Program.AppTitle, MessageBoxButtons.OK, MessageBoxIcon.Information);
        }
      }

      catch (Exception ex) { Utils.ShowError(ex, $"{MethodBase.GetCurrentMethod().Name} dans {this.Name}"); }
    }

    private void cmdContrat_Click(object sender, System.EventArgs e)
    {
      try
      {
        if ((string)cboPrest.SelectedValue == "B")
        {
          MessageBox.Show(Resources.msg_pas_creer_contrat_st_prest_garantie, Program.AppTitle, MessageBoxButtons.OK, MessageBoxIcon.Information);
          return;
        }

        // test si on a un sous traitant ou pas
        if (IsSTF((string)lblInter.Tag))
        {
          // si c'est un cotraitant
          if (iCodeCotraitance > 1)
          {
            MessageBox.Show(Resources.msg_cotraitant_ordre_mission, Program.AppTitle, MessageBoxButtons.OK, MessageBoxIcon.Information);
            return;
          }
          // test si on a deja un contrat pour cette action
          // si oui, on affiche un écran avec la liste des contrats pour cette action
          // avec les boutons modifier, nouveau, supprimer
          int nb = (int)ModuleData.ExecuteScalarInt($"select count(NACTNUM) FROM dbo.TCST WITH (NOLOCK) where CCSTTYPE='S' AND NACTNUM = {MozartParams.NumAction}");
          if (nb > 0)
          {
            // si la DI n'est pas planifiée ou à planifier on ne peut pas créer de contrat
            string etat = (string)cboEtat.SelectedValue;
            frmListeContratsST frm = new frmListeContratsST();
            if (etat != "O" && etat != "P" && etat != "W") frm.bFacture = true;
            frm.mstrStatutContrat = "CS";
            frm.miNumST = (int)txtInter.Tag;
            frm.sDatePlanif = txtDateA1.Text;
            frm.ShowDialog();
          }
          else
          {
            // on a pas de contrat, alors on passe directement en création
            // si le PPS est non reçu, on ne peut pas passer de contrat
            if (CboPPS.SelectedIndex > 0 && (int)CboPPS.Tag != CboPPS.SelectedIndex)
            {
              MessageBox.Show(Resources.msg_enregistrer_action, Program.AppTitle, MessageBoxButtons.OK, MessageBoxIcon.Information);
              return;
            }

            if (CboPPS.SelectedIndex == 2)
            {
              MessageBox.Show(Resources.msg_pps_non_recu_pas_contrat, Program.AppTitle, MessageBoxButtons.OK, MessageBoxIcon.Information);
              return;
            }

            // pour faire un contrat, il faut une date de planification
            if (txtDateA1.Text == "")
            {
              MessageBox.Show(Resources.msg_date_planif_pour_contrat_stt, Program.AppTitle, MessageBoxButtons.OK, MessageBoxIcon.Information);
              cmdDate2_Click(sender, e);
              return;
            }
            else if (txtDateA1.Text != "" && (string)txtDateA1.Tag == "")
            {
              MessageBox.Show(Resources.msg_enreg_date_planif, Program.AppTitle, MessageBoxButtons.OK, MessageBoxIcon.Information);
              return;
            }

            string sVerifDocs = DetailstravauxUtils.VerificationDocStt(MozartParams.NumAction);
            // pour les STT travaux (installation) impossible de passer contrat si documents manquent
            if (sVerifDocs != "")
            {
              if ((string)lblInter.Tag == "I")
              {
                MessageBox.Show($"{Resources.msg_doc_manquants}{sVerifDocs.Replace("#", $"{Environment.NewLine} . ")}{Environment.NewLine}" +
                                $"{Resources.msg_pas_passer_contrat}", Program.AppTitle, MessageBoxButtons.OK, MessageBoxIcon.Information);
                return;
              }
              else if ((string)lblInter.Tag == "S")
              {// pour les STT maintenance , avertissement
                MessageBox.Show($"{Resources.msg_doc_manquants}{sVerifDocs.Replace("#", $"{Environment.NewLine} . ")}{Environment.NewLine}{Environment.NewLine}" +
                                $"{Resources.msg_demander_STT}", Program.AppTitle, MessageBoxButtons.OK, MessageBoxIcon.Information);
              }
            }

            // test du CA et du statut social
            if (VerifStatutSTT(MozartParams.NumAction) == "KO")
            {
              MessageBox.Show($"Alerte:{Environment.NewLine}" +
                              $"{Resources.msg_select_stt_pour_lequel}{Environment.NewLine}" +
                              $"     {Resources.msg_le_CA_annuel_entreprise}{Environment.NewLine}" +
                              $"    {Resources.msg_et_ou}{Environment.NewLine}" +
                              $"     {Resources.msg_statut_social_non_renseigne}{Environment.NewLine}" +
                              $"{Resources.msg_verif_situation_dep_finance}{Environment.NewLine}" +
                              $"{Resources.msg_detail_stt_appel_stt_renseigne_champs}{Environment.NewLine}" +
                              $"{Resources.msg_creer_contrat_stt_si_renseigne}{Environment.NewLine}" +
                              $"{Resources.msg_pas_saisie_nimporte_quoi}{Environment.NewLine}" +
                              $"{Resources.msg_merci}{Environment.NewLine}",
                              Program.AppTitle, MessageBoxButtons.OK, MessageBoxIcon.Information);
              return;
            }

            // test si om actif est présent
            if (DetailstravauxUtils.TestIfOMActif() > 0)
            {
              MessageBox.Show(Resources.msg_creation_contrat_stt_impossible_ordre_mission_existe, Program.AppTitle, MessageBoxButtons.OK, MessageBoxIcon.Information);
              return;
            }

            // ouverture pr creation !!!!
            new frmContratAutoST
            {
              msTypeContrat = "S",
              mNumContratST = 0,
              msMontantDevis = txtMontantDevis.Text,
              msDatePlanif = txtDateA1.Text,
              mbDesactive = false //on ne desactive pas les autres contrats de l'action
            }.ShowDialog();
          }

          // rafraichir l'affichage
          OuvertureEnModification();
        }
        else
          MessageBox.Show(Resources.msg_si_intervenant_stt, Program.AppTitle, MessageBoxButtons.OK, MessageBoxIcon.Information);
      }
      //catch (Exception ex) { MessageBox.Show($"{ex.Message}\r\n\r\n{Resources.Global_dans}{MethodBase.GetCurrentMethod().Name}", Resources.Global_Erreur, MessageBoxButtons.OK, MessageBoxIcon.Exclamation); }
      catch (Exception ex) { Utils.ShowError(ex, $"{MethodBase.GetCurrentMethod().Name} dans {this.Name}"); }
    }

    private void cmdCSP_Click(object sender, System.EventArgs e)
    {
      try
      {
        if ((string)cboPrest.SelectedValue == "B")
        {
          MessageBox.Show(Resources.msg_pas_creer_contrat_st_prest_garantie, Program.AppTitle, MessageBoxButtons.OK, MessageBoxIcon.Information);
          return;
        }

        // test si on a un sous traitant ou pas
        if (IsSTF((string)lblInter.Tag))
        {
          // si c'est un cotraitant
          if (iCodeCotraitance > 1)
          {
            MessageBox.Show(Resources.msg_cotraitant_ordre_mission, Program.AppTitle, MessageBoxButtons.OK, MessageBoxIcon.Information);
            return;
          }

          // test si on a deja un contrat pour cette action
          // si oui, on affiche un écran avec la liste des contrats pour cette action
          // avec les boutons modifier, nouveau, supprimer
          int nb = (int)ModuleData.ExecuteScalarInt($"select count(NACTNUM) FROM dbo.TCST WITH (NOLOCK) where CCSTTYPE='D' AND NACTNUM = {MozartParams.NumAction}");
          if (nb > 0)
          {
            // si la DI n'est pas planifiée ou à planifier on ne peut pas créer de contrat
            frmListeContratsST frm = new frmListeContratsST();
            string etat = (string)cboEtat.SelectedValue;
            frm.bFacture = etat != "O" && etat != "P" && etat != "W";
            frm.mstrStatutContrat = "CSP";
            frm.miNumST = (int)txtInter.Tag;
            frm.sDatePlanif = txtDateA1.Text;
            frm.ShowDialog();
          }
          else
          { //on a pas de contrat, alors on passe directement en création
            // si le PPS est non reçu, on ne peut pas passer de contrat
            if (CboPPS.SelectedIndex == 2)
            {
              MessageBox.Show(Resources.msg_pps_non_recu_pas_contrat, Program.AppTitle, MessageBoxButtons.OK, MessageBoxIcon.Information);
              return;
            }

            // pour faire un contrat, il faut une date de planification
            if (txtDateA1.Text == "")
            {
              MessageBox.Show(Resources.msg_date_planif_pour_contrat_stt, Program.AppTitle, MessageBoxButtons.OK, MessageBoxIcon.Information);
              cmdDate2_Click(null, null);
              return;
            }
            else if (txtDateA1.Text != "" && (string)txtDateA1.Tag == "")
            {
              MessageBox.Show(Resources.msg_enreg_date_planif, Program.AppTitle, MessageBoxButtons.OK, MessageBoxIcon.Information);
              return;
            }

            string sVerifDocs = DetailstravauxUtils.VerificationDocStt(MozartParams.NumAction);
            // pour les STT travaux (installation) impossible de passer contrat si documents manquent
            if (sVerifDocs != "")
            {
              if ((string)lblInter.Tag == "I")
              {
                MessageBox.Show($"{Resources.msg_doc_manquants}{sVerifDocs.Replace("#", $"{Environment.NewLine} . ")}{Environment.NewLine}" +
                                $"{Resources.msg_pas_passer_contrat}", Program.AppTitle, MessageBoxButtons.OK, MessageBoxIcon.Information);
                return;
              }
              else if ((string)lblInter.Tag == "S")
              {
                // pour les STT maintenance , avertissement
                MessageBox.Show($"{Resources.msg_doc_manquants}{sVerifDocs.Replace("#", $"{Environment.NewLine} . ")}{Environment.NewLine}" +
                                $"{Resources.msg_demander_STT}", Program.AppTitle, MessageBoxButtons.OK, MessageBoxIcon.Information);
              }
            }

            // test du CA et du statut social
            if (VerifStatutSTT(MozartParams.NumAction) == "KO")
            {
              MessageBox.Show($"Alerte:{Environment.NewLine}" +
                              $"{Resources.msg_select_stt_pour_lequel}{Environment.NewLine}" +
                              $"     {Resources.msg_le_CA_annuel_entreprise}{Environment.NewLine}" +
                              $"    {Resources.msg_et_ou}{Environment.NewLine}" +
                              $"     {Resources.msg_statut_social_non_renseigne}{Environment.NewLine}" +
                              $"{Resources.msg_verif_situation_dep_finance}{Environment.NewLine}" +
                              $"{Resources.msg_detail_stt_appel_stt_renseigne_champs}{Environment.NewLine}" +
                              $"{Resources.msg_creer_contrat_stt_si_renseigne}{Environment.NewLine}" +
                              $"{Resources.msg_pas_saisie_nimporte_quoi}{Environment.NewLine}" +
                              $"{Resources.msg_merci}{Environment.NewLine}",
                              Program.AppTitle, MessageBoxButtons.OK, MessageBoxIcon.Information);
              return;
            }

            // test si om actif est présent
            if (DetailstravauxUtils.TestIfOMActif() > 0)
            {
              MessageBox.Show(Resources.msg_creation_contrat_stt_impossible_ordre_mission_existe, Program.AppTitle, MessageBoxButtons.OK, MessageBoxIcon.Information);
              return;
            }

            // ouverture pr creation !!!!
            new frmContratAutoST
            {
              msTypeContrat = "D",
              mNumContratST = 0,
              msMontantDevis = txtMontantDevis.Text,
              msDatePlanif = txtDateA1.Text,
              mbDesactive = false // on ne desactive pas les autres contrats de l'action
            }.ShowDialog();
          }
          // rafraichir l'affichage
          OuvertureEnModification();
        }
        else
        {
          MessageBox.Show(Resources.msg_si_intervenant_stt, Program.AppTitle, MessageBoxButtons.OK, MessageBoxIcon.Information);
        }
      }
      catch (Exception ex) { Utils.ShowError(ex, $"{MethodBase.GetCurrentMethod().Name} dans {this.Name}"); }
    }

    private void cmdPrepaCde_Click(object sender, System.EventArgs e)
    {
      if ((string)cboPrest.SelectedValue == "B")
      {
        MessageBox.Show(Resources.msg_pas_creer_prep_cde_sur_prest_garantie, Program.AppTitle, MessageBoxButtons.OK, MessageBoxIcon.Information);
        return;
      }

      // si la DI n'est pas planifiée ou à planifier on ne peut pas créer de commande
      string etat = (string)cboEtat.SelectedValue;
      if (etat != "O" && etat != "P" && etat != "W" && etat != "M")
      {
        MessageBox.Show(Resources.msg_engagerDepenseActPlanifier, Program.AppTitle, MessageBoxButtons.OK, MessageBoxIcon.Information);
        return;
      }

      Cursor.Current = Cursors.WaitCursor;
      using (SqlDataReader reader = ModuleData.ExecuteReader($"SELECT CDEVISTYPE FROM TDCL WITH (NOLOCK) WHERE NACTNUM = {MozartParams.NumAction}"))
      {
        if (reader.Read())
        {
          frmPrepaCommandePrest frm = new frmPrepaCommandePrest();
          if (Utils.BlankIfNull(reader["CDEVISTYPE"]) == "P")
            frm.msTypeDevis = "P";
          else
            frm.msTypeDevis = "F";
          frm.mstrTech = txtInter.Text;
          frm.miTypContrat = iTypContrat;
          frm.ShowDialog();
        }
      }
      Cursor.Current = Cursors.Default;

      // rafraichir l'affichage
      OuvertureEnModification();
    }

    private void cmdCommande_Click(object sender, System.EventArgs e)
    {
      try
      {
        if ((string)cboPrest.SelectedValue == "B")
        {
          MessageBox.Show(Resources.msg_pas_acces_bouton_prest_garantie, Program.AppTitle, MessageBoxButtons.OK, MessageBoxIcon.Information);
          return;
        }

        if (txtEtatAdmin.Text == Resources.lib_facturee)
          MessageBox.Show(Resources.msg_attention_action_deja_facturee, Program.AppTitle, MessageBoxButtons.OK, MessageBoxIcon.Stop);

        // test si on a deja une commande pour cette action
        // si oui, on affiche un écran avec la liste des commandes pour cette action
        // avec les boutons modifier, nouveau, supprimer
        int nb = (int)ModuleData.ExecuteScalarInt($"select count(*) from api_v_CommandesFO where  NACTNUM = {MozartParams.NumAction}");
        if (nb > 0)
        {
          // si la DI n'est pas planifiée ou à planifier on ne peut pas créer de commande
          frmListeCommandesFour frm = new frmListeCommandesFour();
          string etat = (string)cboEtat.SelectedValue;
          if (etat != "O" && etat != "P" && etat != "W" && etat != "M")
            frm.mbFacture = true;
          frm.mstrStatutCom = "A";// commande standard
          frm.ShowDialog();
        }
        else
        {
          // on a pas de commande, alors on passe directement en création
          // si la DI n'est pas planifiée ou à planifier on ne peut pas créer de commande
          string etat = (string)cboEtat.SelectedValue;
          if (etat != "O" && etat != "P" && etat != "W" && etat != "M")
          {
            MessageBox.Show(Resources.msg_engagerDepenseActPlanifier, Program.AppTitle, MessageBoxButtons.OK, MessageBoxIcon.Information);
            return;
          }
          new frmCommandeFournisseur
          {
            mstrStatutCommande = "C",
            miNumCommande = 0
          }.ShowDialog();

          // retour de la création de la commande
          // on repart sur la liste des commandes
          new frmListeCommandesFour
          {
            mstrStatutCom = "A" // commande standard
          }.ShowDialog();
        }

        // rafraichir l'affichage
        OuvertureEnModification();
      }
      //catch (Exception ex) { MessageBox.Show($"{ex.Message}\r\n\r\n{Resources.Global_dans}{MethodBase.GetCurrentMethod().Name}", Resources.Global_Erreur, MessageBoxButtons.OK, MessageBoxIcon.Exclamation); }
      catch (Exception ex) { Utils.ShowError(ex, $"{MethodBase.GetCurrentMethod().Name} dans {this.Name}"); }
    }

    private void cmdDevisClt_Click(object sender, System.EventArgs e)
    {
      int nb;

      if (bModif)
      {
        MessageBox.Show(Resources.msg_enreg_modifs_avant_devis_client, Program.AppTitle, MessageBoxButtons.OK, MessageBoxIcon.Information);
        return;
      }

      if ((string)cboPrest.SelectedValue == "B")
      {
        MessageBox.Show(Resources.msg_pas_creer_devis_sur_prest_garantie, Program.AppTitle, MessageBoxButtons.OK, MessageBoxIcon.Information);
        return;
      }

      if ((string)txtCompte.Text == "263")
      {
        MessageBox.Show("Vous ne pouvez pas créer de devis sur le compte 263", Program.AppTitle, MessageBoxButtons.OK, MessageBoxIcon.Information);
        return;
      }

      try
      {
        // on recherche les devis existants s'il y en a
        if (devisExiste())
        {
          // recherche si c'est un devis standard
          // si devis standard, on bascule sur la bonne fenetre
          nb = (int)ModuleData.ExecuteScalarInt($"SELECT COUNT(NACTNUM) AS NB FROM TDCL WHERE NACTNUM = {MozartParams.NumAction} AND CDEVISTYPE IN ('F', 'B', 'G')");
          if (nb != 0)
          {
            nb = (int)ModuleData.ExecuteScalarInt($"SELECT COUNT(NACTNUM) AS NB FROM TDCL WHERE NACTNUM = {MozartParams.NumAction} AND CDEVISTYPE = 'F'");
            if (nb != 0)
            {
              // Ancien devis (type 'F')
              new frmDevisClient
              {
                miNumDI = MozartParams.NumDi,
                miNumAction = MozartParams.NumAction
              }.ShowDialog();
            }
            else
            {
              // Nouveau Devis (type 'B' ou 'G')
              new frmDevisClient2
              {
                miNumDI = MozartParams.NumDi,
                miNumAction = MozartParams.NumAction
              }.ShowDialog();
            }
          }
          else
          {
            // c'est un devis prestation
            new frmDevisClientPrestation
            {
              miNumAction = MozartParams.NumAction
            }.ShowDialog();
          }
        }
        else
        {
          new frmChoixDevisClient().ShowDialog();
        }

        bMsgDevisCL = false;
        //rafraichir l'affichage
        OuvertureEnModification();
      }
      catch (Exception ex) { Utils.ShowError(ex, $"{MethodBase.GetCurrentMethod().Name} dans {this.Name}"); }
    }

    private void cmdStock_Click(object sender, System.EventArgs e)
    {
      try
      {
        if ((string)cboPrest.SelectedValue == "B")
        {
          MessageBox.Show(Resources.msg_pas_creer_BL_sur_prest_garantie, Program.AppTitle, MessageBoxButtons.OK, MessageBoxIcon.Information);
          return;
        }
        if (txtEtatAdmin.Text == Resources.lib_facturee)
          MessageBox.Show(Resources.msg_attention_action_deja_facturee, Program.AppTitle, MessageBoxButtons.OK, MessageBoxIcon.Stop);

        MessageBox.Show(Resources.msg_att_fonction_que_pour_articles_stock, Program.AppTitle, MessageBoxButtons.OK, MessageBoxIcon.Information);

        // test si on a deja un BL libre
        // si oui, on affiche un écran avec la liste avec les boutons modifier, nouveau, supprimer
        int nb = (int)ModuleData.ExecuteScalarInt($"select count(*) from TLBLlibre WITH (NOLOCK)  where NACTNUM = {MozartParams.NumAction}");
        if (nb > 0)
          new frmListeBL().ShowDialog();
        else// on a pas de sortie de stock,  alors on passe directement en création
          new frmSaisieStock
          {
            mstrTech = txtInter.Text,// tech ou sous traitant
            mstrSite = txtSite.Text,
            bModif = true,
            iNumBL = 0
          }.ShowDialog();

        OuvertureEnModification();

        //  gbRefresh = True
      }
      //catch (Exception ex) { MessageBox.Show($"{ex.Message}\r\n\r\n{Resources.Global_dans}{MethodBase.GetCurrentMethod().Name}", Resources.Global_Erreur, MessageBoxButtons.OK, MessageBoxIcon.Exclamation); }
      catch (Exception ex) { Utils.ShowError(ex, $"{MethodBase.GetCurrentMethod().Name} dans {this.Name}"); }
    }

    private void cmdDdeStock_Click(object sender, System.EventArgs e)
    {
      try
      {
        if ((string)cboPrest.SelectedValue == "B")
        {
          MessageBox.Show(Resources.msg_pas_creer_sortie_stock_sur_prest_garantie, Program.AppTitle, MessageBoxButtons.OK, MessageBoxIcon.Information);
          return;
        }
        if (txtEtatAdmin.Text == Resources.lib_facturee)
          MessageBox.Show(Resources.msg_attention_action_deja_facturee, Program.AppTitle, MessageBoxButtons.OK, MessageBoxIcon.Stop);

        Cursor.Current = Cursors.WaitCursor;
        // test si on a deja une sortie de stock
        // si oui, on affiche un écran avec la liste
        if (cmdDdeStock.BackColor == MozartColors.ColorH80FFFF)
        {
          // si la DI n'est pas planifiée ou à planifier on ne peut pas créer de sortie
          string etat = (string)cboEtat.SelectedValue;
          if (etat != "O" && etat != "P" && etat != "W" && etat != "M")
            new frmStockListeDdeSortie
            {
              mbFacture = true,
              miNumAction = MozartParams.NumAction
            }.ShowDialog();
          else
            new frmStockListeDdeSortie { miNumAction = MozartParams.NumAction }.ShowDialog();
        }
        else
        {
          // si la DI n'est pas planifiée ou à planifier on ne peut pas créer de sortie
          string etat = (string)cboEtat.SelectedValue;
          if (etat != "O" && etat != "P" && etat != "W" && etat != "M")
          {
            MessageBox.Show(Resources.msg_engagerDepenseActPlanifier, Program.AppTitle, MessageBoxButtons.OK, MessageBoxIcon.Information);
            return;
          }
          new frmStockDdeSortie
          {
            miNumDdeSortie = 0,// mode ajout
            mstrStatutStock = "C",
            mstrTech = txtInter.Text,
            mstrSite = txtSite.Text
          }.ShowDialog();
        }

        OuvertureEnModification();
        //  gbRefresh = True
      }
      //catch (Exception ex) { MessageBox.Show($"{ex.Message}\r\n\r\n{Resources.Global_dans}{MethodBase.GetCurrentMethod().Name}", Resources.Global_Erreur, MessageBoxButtons.OK, MessageBoxIcon.Exclamation); }
      catch (Exception ex) { Utils.ShowError(ex, $"{MethodBase.GetCurrentMethod().Name} dans {this.Name}"); }
      finally { Cursor.Current = Cursors.Default; }
    }

    private void cmdPlanifier_Click(object sender, System.EventArgs e)
    {
      try
      {
        if (txtduree.Text == "")
        {
          MessageBox.Show(Resources.msg_enreg_duree_non_nulle, Program.AppTitle, MessageBoxButtons.OK, MessageBoxIcon.Information);
          return;
        }

        // si statut <> 'O'
        string etat = (string)cboEtat.SelectedValue;
        if (etat == "A" || etat == "D")
        {
          MessageBox.Show(Resources.msg_planifier_statut_O, Program.AppTitle, MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
          return;
        }
        if (etat == "B")
        {
          MessageBox.Show(Resources.msg_pas_planfi_action_sur_prest_garantie, Program.AppTitle, MessageBoxButtons.OK, MessageBoxIcon.Information);
          return;
        }

        using (SqlDataReader reader = ModuleData.ExecuteReader($"exec api_sp_Infoplanif {MozartParams.NumAction}"))
        {
          // si pas d"enregistrement courant
          if (!reader.Read())
          {
            MessageBox.Show(Resources.msg_enreg_action_avant_planif, Program.AppTitle, MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
            txtDateA1.Text = "";
            return;
          }

          //  FG le 11/05/2017 (anomalie sur une action avec date de planif et statut 'A planifier'
          //  test si non cohérence entre les données enregistrées et les données cliquées sur l'écran.
          //  si on passe de sous-traitant à technicien sans enregistrer les modifications, les infos de la base nous remontent STT et les infos de la pages nous disent TECH
          //  alors on peut avoir un problème de lien vers le bon fonctionnement et le bon planning.
          //  il faut mieux demander à l'utilisateur d'enregistrer ces modifications avant de planifier
          if ((Utils.BlankIfNull(reader["CACTTYT"]) == "T" && !optInter0.Checked) || (Utils.BlankIfNull(reader["CACTTYT"]) == "S" && optInter0.Checked))
          {
            MessageBox.Show(Resources.msg_enreg_action_avant_planif, Program.AppTitle, MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
            txtDateA1.Text = "";
            return;
          }

          // si technicien ou sous traitant
          if (Utils.BlankIfNull(reader["CACTTYT"]) != "T")
          {
            // cas ST , on recherche les oinfos ST
            using (SqlDataReader readerST = ModuleData.ExecuteReader($"exec api_sp_InfoplanifST {MozartParams.NumAction}"))
            {
              // si pas d"enregistrement courant
              if (!readerST.Read())
              {

                MessageBox.Show(Resources.msg_enreg_stt_sur_action, Program.AppTitle, MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                return;
              }
              if (Convert.IsDBNull(readerST["NINTNUM"]))
              {
                MessageBox.Show(Resources.msg_enreg_stt_sur_action, Program.AppTitle, MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                return;
              }

              // test de la validité du sous traitant
              int nb = (int)ModuleData.ExecuteScalarInt($"SELECT count(CSTFPREV) from TSTF WITH (NOLOCK) , TINT WITH (NOLOCK)  WHERE TSTF.NSTFNUM = TINT.NSTFNUM AND CSTFPREV='O' AND NINTNUM = {(int)Utils.ZeroIfNull(readerST["NINTNUM"])}");
              if (nb == 0)
              {
                MessageBox.Show(Resources.msg_stt_pas_parametre_exec_preventives, Program.AppTitle, MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                return;
              }

              // test si un technicien preventif existe
              nb = (int)ModuleData.ExecuteScalarInt($"SELECT count(NSTTNUM) from TSTTECH WITH (NOLOCK) WHERE TSTTECH.NSTFNUM = {(int)Utils.ZeroIfNull(readerST["NSTFNUM"])}");
              if (nb == 0)
              {
                MessageBox.Show(Resources.msg_creer_tech_preventif_dans_detail_stt + " !", Program.AppTitle, MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                return;
              }

              // selon les parametres, on passe en modification ou en création
              if (!Convert.IsDBNull(readerST["NIPLSTNUM"]))
              {
                // on passe au planning avec la bonne date et le bon tech
                frmPlanSTT frmP = new frmPlanSTT();
                frmP.mdSemaine = Convert.IsDBNull(readerST["DACTPLA"]) ? Convert.ToDateTime(txtDateA1.Text) : Convert.ToDateTime(readerST["DACTPLA"]);
                frmP.miNumTech = (int)Utils.ZeroIfNull(readerST["NSTTNUM"]);
                frmP.miNumIp = (int)Utils.ZeroIfNull(readerST["NIPLSTNUM"]);
                frmP.mStrStatutIP = "M";
                try
                {
                  frmP.ShowDialog();
                }
                catch { MessageBox.Show(Resources.msg_impossible_affiche_planning, Program.AppTitle, MessageBoxButtons.OK, MessageBoxIcon.Information); }
              }
              else
              {
                // affichage de l'info site avant de planifier
                DetailstravauxUtils.Info InfoSite = DetailstravauxUtils.RechercheInfos("INFO_SITE", (int)Utils.ZeroIfNull(readerST["NSITNUM"]));
                if (InfoSite.strInfo != "" && InfoSite.DateValDeb < DateTime.Now && InfoSite.DateValFin > DateTime.Now)
                  new frmInfosClient
                  {
                    msStatut = "S",// site
                    msInfo = InfoSite.strInfo
                  }.ShowDialog();

                //FGA le 11 / 06 / 24
                // si site des JO, on affiche un message
                DetailstravauxUtils.AffichageMessageJO2024(Convert.ToInt32(iSiteNum));


                // création d'une nouvelle IP avec l'action sélectionnée
                frmPlanSTT frm = new frmPlanSTT();
                frm.miNumIp = 0;
                frm.miNumST = (int)Utils.ZeroIfNull(readerST["NSTFNUM"]); // ' passage du STFNUM pour filtrer
                frm.miNumSite = (int)Utils.ZeroIfNull(readerST["NSITNUM"]);
                if (txtDateA1.Text == "")
                  frm.mdSemaine = DateTime.Now;
                else
                  frm.mdSemaine = Convert.ToDateTime(txtDateA1.Text);
                frm.miNumTech = (int)Utils.ZeroIfNull(readerST["NSTTNUM"]);
                frm.miDuree = txtduree.Text;
                frm.mStrStatutIP = "C";
                //  ( client / site )
                frm.mStrTagIP = $"{Utils.BlankIfNull(readerST["VCLINOM"])}{Environment.NewLine}{Utils.BlankIfNull(readerST["VSITNOM"])}{Environment.NewLine}";
                try
                {
                  frm.ShowDialog();
                }
                catch (Exception)
                {
                  MessageBox.Show(Resources.msg_impossible_affiche_planning, Program.AppTitle, MessageBoxButtons.OK, MessageBoxIcon.Information);
                  txtDateA1.Text = "";
                }
              }
            }
          }
          else
          {
            // technicien
            // cas standard

            // modif du 08/03/2019 par MC : correction du bug duree entre planif et nactdur
            // on enregistre à présent la durée de l'action dans tact avant de la planifier, ce qui permet d'avoir une durée identique lorsqu'on rafraichi l action
            // pas fait
            //    
            // selon les parametres, on passe en modification ou en création

            if (!Convert.IsDBNull(reader["NIPLNUM"]))
            {
              // on passe au planning avec la bonne date et le bon tech
              frmPlan frm = new frmPlan();
              frm.mdSemaine = miLocTech != 0 ? Convert.ToDateTime(txtDateA1.Text) : Convert.ToDateTime(reader["DIPLDAT"]);
              frm.miNumTech = miLocTech != 0 ? miLocTech : (int)Utils.ZeroIfNull(reader["NPERNUM"]);
              frm.miNumIp = (int)Utils.ZeroIfNull(reader["NIPLNUM"]);
              frm.mStrStatutIP = "M";
              try
              {
                frm.ShowDialog();
              }
              catch (Exception)
              {
                MessageBox.Show(Resources.msg_impossible_affiche_planning, Program.AppTitle, MessageBoxButtons.OK, MessageBoxIcon.Information);
                txtDateA1.Text = "";
              }
            }
            else
            {
              // affichage de l'info site avant de planifier
              DetailstravauxUtils.Info InfoSite = DetailstravauxUtils.RechercheInfos("INFO_SITE", (int)Utils.ZeroIfNull(reader["NSITNUM"]));
              if (InfoSite.strInfo != "" && InfoSite.DateValDeb < DateTime.Now && InfoSite.DateValFin > DateTime.Now)
                new frmInfosClient
                {
                  msStatut = "S",// site
                  msInfo = InfoSite.strInfo
                }.ShowDialog();

              // création d'une nouvelle IP avec l'action sélectionnée
              frmPlan frm = new frmPlan();
              frm.miNumIp = 0;
              frm.miNumSite = (int)Utils.ZeroIfNull(reader["NSITNUM"]);
              if (txtDateA1.Text == "")
                frm.mdSemaine = Convert.ToDateTime(txtDateA0.Text);
              else
                frm.mdSemaine = Convert.ToDateTime(txtDateA1.Text);
              frm.miNumTech = miLocTech != 0 ? miLocTech : (int)Utils.ZeroIfNull(reader["NPERNUM"]);
              frm.miDuree = Utils.ZeroIfBlank(txtduree.Text);
              frm.mStrStatutIP = "C";
              //  ( client / site )
              frm.mStrTagIP = $"{Utils.BlankIfNull(reader["VCLINOM"])}{Environment.NewLine}{Utils.BlankIfNull(reader["VSITNOM"])}{Environment.NewLine}";
              try
              {
                frm.ShowDialog();
              }
              catch (Exception)
              {
                MessageBox.Show(Resources.msg_impossible_affiche_planning, Program.AppTitle, MessageBoxButtons.OK, MessageBoxIcon.Information);
                txtDateA1.Text = "";
              }
            }
          }

          OuvertureEnModification();
          statutPlanification = "";
          //  gbRefresh = True
        }
      }
      //catch (Exception ex) { MessageBox.Show($"{ex.Message}\r\n\r\n{Resources.Global_dans}{MethodBase.GetCurrentMethod().Name}", Resources.Global_Erreur, MessageBoxButtons.OK, MessageBoxIcon.Exclamation); }
      catch (Exception ex) { Utils.ShowError(ex, $"{MethodBase.GetCurrentMethod().Name} dans {this.Name}"); }
    }

    private void cmdImages_Click(object sender, System.EventArgs e)
    {
      MessageBox.Show(Resources.msg_Att_enreg_docs_visibles_par_client_sur_wav, Program.AppTitle, MessageBoxButtons.OK, MessageBoxIcon.Information);

      // passage des paramètres
      new frmListActDoc
      {
        Owner = this,
        mbInterditDepose = false,
        mstrVueWeb = "O",
        mstrTypeDoc = "Client",
        mstrClient = txtClient.Text,
        mstrSite = txtSite.Text,
        mstrNumDI = txtDI.Text,
        mstrAction = txtAction.Text,
        mlAction = MozartParams.NumAction
      }.ShowDialog();

      using (SqlDataReader reader = ModuleData.ExecuteReader($"EXEC api_sp_CouleurBoutonAction {MozartParams.NumAction}"))
      {
        if (reader.Read())
        {
          if (Utils.ZeroIfNull(reader["IMAGE"]) > 0)
          {
            cmdImages.Text = $"{Resources.lib_images_web_client}{Utils.ZeroIfNull(reader["IMAGE"])}";
            cmdImages.BackColor = MozartColors.ColorH80FFFF;//Jaune pale
          }
          else
          {
            cmdImages.Text = Resources.lib_images_web_client;
            cmdImages.BackColor = MozartColors.ColorH8000000F;
          }
          if (Utils.ZeroIfNull(reader["DOC"]) > 0)
          {
            cmdDoc.Text = $"{Resources.Documents_internes}{Utils.ZeroIfNull(reader["DOC"])}";
            cmdDoc.BackColor = MozartColors.ColorH80FFFF;//Jaune pale
          }
          else
          {
            cmdDoc.Text = Resources.Documents_internes;
            cmdDoc.BackColor = MozartColors.ColorH8000000F;
          }
        }
      }

      //rafraichir l'affichage
      OuvertureEnModification();
    }


    private void cmdDoc_Click(object sender, System.EventArgs e)
    {
      new frmListActDoc
      {
        mbInterditDepose = false,
        mstrVueWeb = "N",
        mstrTypeDoc = "Interne",
        mstrClient = txtClient.Text,
        mstrSite = txtSite.Text,
        mstrNumDI = txtDI.Text,
        mstrAction = txtAction.Text,
        mlAction = MozartParams.NumAction
      }.ShowDialog();

      using (SqlDataReader reader = ModuleData.ExecuteReader($"EXEC api_sp_CouleurBoutonAction {MozartParams.NumAction}"))
      {
        if (reader.Read())
        {
          if (Utils.ZeroIfNull(reader["IMAGE"]) > 0)
          {
            cmdImages.Text = $"{Resources.lib_images_web_client}{Utils.ZeroIfNull(reader["IMAGE"])}";
            cmdImages.BackColor = MozartColors.ColorH80FFFF;//Jaune pale
          }
          else
          {
            cmdImages.Text = Resources.lib_images_web_client;
            cmdImages.BackColor = MozartColors.ColorH8000000F;
          }
          if (Utils.ZeroIfNull(reader["DOC"]) > 0)
          {
            cmdDoc.Text = $"{Resources.Documents_internes}{Utils.ZeroIfNull(reader["DOC"])}";
            cmdDoc.BackColor = MozartColors.ColorH80FFFF;//Jaune pale
          }
          else
          {
            cmdDoc.Text = Resources.Documents_internes;
            cmdDoc.BackColor = MozartColors.ColorH8000000F;
          }
        }
      }
      //rafraichir l'affichage
      OuvertureEnModification();
    }

    private void cmdOM_Click(object sender, System.EventArgs e)
    {
      if ((string)cboPrest.SelectedValue == "B")
      {
        MessageBox.Show(Resources.msg_pas_acces_bouton_prest_garantie, Program.AppTitle, MessageBoxButtons.OK, MessageBoxIcon.Information);
        return;
      }

      // test si on a un sous traitant ou pas
      if (IsSTF((string)lblInter.Tag))
      {
        // test si mediapost
        if (MozartParams.NomSociete == "EMALEC" && iClientNum == 12015)
        {
          MessageBox.Show(Resources.msg_OM_interdit_client, Program.AppTitle, MessageBoxButtons.OK, MessageBoxIcon.Information);
          return;
        }

        // test si on a deja fait un OM pour cette action
        int nb = (int)ModuleData.ExecuteScalarInt($"select count(NACTNUM) from TOM WITH (NOLOCK) where NACTNUM = {MozartParams.NumAction}");
        if (nb > 0)
        {
          // si la DI n'est pas planifiée ou à planifier on ne peut pas créer d'OM
          string etat = (string)cboEtat.SelectedValue;
          frmListeOM frm = new frmListeOM();
          if (etat != "O" && etat != "P" && etat != "W")
            frm.mbFacture = true;
          frm.mstrStatut = "A";
          frm.ShowDialog();
        }
        else
        {
          // pour faire un OM, il faut une date de planification
          if (txtDateA1.Text == "")
          {
            MessageBox.Show(Resources.msg_date_planfi_pour_faire_ordre_mission, Program.AppTitle, MessageBoxButtons.OK, MessageBoxIcon.Information);
            cmdDate2_Click(sender, e);
            return;
          }

          new frmSaisieOM
          {
            miNumOM = 0,
            miST = (int)txtInter.Tag,
            mstrStatut = "C",
            miAction = MozartParams.NumAction
          }.ShowDialog();
        }

        //rafraichir l'affichage
        OuvertureEnModification();
      }
      else
      {
        MessageBox.Show(Resources.msg_si_intervenant_stt, Program.AppTitle, MessageBoxButtons.OK, MessageBoxIcon.Information);
      }
    }

    private void cmdOGar_Click(object sender, System.EventArgs e)
    {
      if ((string)cboPrest.SelectedValue == "B")
      {
        MessageBox.Show(Resources.msg_pas_acces_bouton_prest_garantie, Program.AppTitle, MessageBoxButtons.OK, MessageBoxIcon.Information);
        return;
      }

      // test si on a un sous traitant ou pas
      if (IsSTF((string)lblInter.Tag))
      {
        // test si on a deja fait un OG
        int nb = (int)ModuleData.ExecuteScalarInt($"select count(NACTNUM) from TOGS WITH (NOLOCK) where NACTNUM = {MozartParams.NumAction}");
        if (nb > 0)
        {
          // si la DI n'est pas planifiée ou à planifier on ne peut pas créer d'OG
          string etat = (string)cboEtat.SelectedValue;
          frmListeOGS frm = new frmListeOGS();
          if (etat != "O" && etat != "P" && etat != "W")
            frm.mbFacture = true;
          frm.mstrStatut = "A";
          frm.ShowDialog();
        }
        else
        {
          // on a pas de OG, alors on passe directement en création
          // pour faire un OG, il faut une date de planification
          if (txtDateA1.Text == "")
          {
            MessageBox.Show(Resources.msg_date_planif_pour_faire_ordre_garantie, Program.AppTitle, MessageBoxButtons.OK, MessageBoxIcon.Information);
            cmdDate2_Click(sender, e);
            return;
          }
          else if (txtDateA1.Text != "" && txtDateA1.Tag == null)
          {
            MessageBox.Show(Resources.msg_enreg_date_planif, Program.AppTitle, MessageBoxButtons.OK, MessageBoxIcon.Information);
            return;
          }
          new frmSaisieOGS
          {
            miNumOG = 0,
            mstrStatut = "C",
            miAction = MozartParams.NumAction
          }.ShowDialog();
        }

        // rafraichir l'affichage
        OuvertureEnModification();
      }
      else
      {
        MessageBox.Show(Resources.msg_si_intervenant_stt, Program.AppTitle, MessageBoxButtons.OK, MessageBoxIcon.Information);
      }
    }

    private void cmdLDR_Click(object sender, System.EventArgs e)
    {
      if ((string)cboPrest.SelectedValue == "B")
      {
        MessageBox.Show(Resources.msg_pas_acces_bouton_prest_garantie, Program.AppTitle, MessageBoxButtons.OK, MessageBoxIcon.Information);
        return;
      }

      // attestation possible uniquement si toutes les actions sont exécutées
      int nb = (int)ModuleData.ExecuteScalarInt($"select count(*) from tact WITH (NOLOCK) where cetacod <> 'E' and cetacod <> 'S' and cetacod <> 'I'  and ndinnum ={MozartParams.NumDi}");
      // TB SAMSIC CITY SPEC
      if (nb > 0 && iClientNum != 1419 && iClientNum != 1748 && iClientNum != 1597 && MozartParams.NomGroupe == "EMALEC")
      {
        MessageBox.Show(Resources.msg_actions_doit_exec_avant_attestation, Program.AppTitle, MessageBoxButtons.OK, MessageBoxIcon.Information);
        return;
      }

      // mise à jour nomsocietetemp
      MozartParams.NomSocieteTemp = MozartParams.NomSociete;

      // test si on a deja fait l'attestation pour cette action
      using (SqlDataReader reader = ModuleData.ExecuteReader($"select NCOURID, NCOURIDDEST, NCOURNUM from TCOUR WITH (NOLOCK) where (CCOURTYPCOUR='A' or CCOURTYPCOUR='C') AND NACTNUM ={MozartParams.NumAction}"))
      {
        frmSaisieAttestation frm = new frmSaisieAttestation();

        if (!reader.Read())
        {// création
          DataRow row = dtLettre.NewRow();
          row["TypeDest"] = "Site";
          row["IDdest"] = iSiteNum;
          dtLettre.Rows.Add(row);

          frm.mstrTypeDest = "Site";
          frm.mstrTypeCour = "A";
          frm.mstrTypeAR = "";
          frm.miNumCourrier = 0;
          frm.mstrStatutCourrier = "C";
          frm.miAction = MozartParams.NumAction;
          frm.txtCompte.Text = txtCompte.Text;
          frm.dtLettre = this.dtLettre;
          frm.ShowDialog();
        }
        else
        {// on est en modification
          frm.mstrTypeDest = "Site";
          frm.mstrTypeCour = "A";
          frm.mstrTypeAR = "";
          frm.miNumCourrier = (int)Utils.ZeroIfNull(reader["NCOURID"]);
          frm.mstrStatutCourrier = "M";
          frm.miAction = MozartParams.NumAction;
        }
        frm.ShowDialog();
      }

      // rafraichir l'affichage
      OuvertureEnModification();
    }

    private void cmdInventaire_Click(object sender, System.EventArgs e)
    {
      if ((string)cboPrest.SelectedValue == "B")
      {
        MessageBox.Show(Resources.msg_pas_acces_bouton_prest_garantie, Program.AppTitle, MessageBoxButtons.OK, MessageBoxIcon.Information);
        return;
      }

      // recherche si inventaire sur cette action
      int nb = (int)ModuleData.ExecuteScalarInt($"select count(*) from TINV WITH (NOLOCK) where NACTNUMPREV = {MozartParams.NumAction}");
      if (nb > 0)
      {
        if (MessageBox.Show(Resources.msg_inventaire_existe_sur_action_continuer, Program.AppTitle, MessageBoxButtons.YesNo,
                            MessageBoxIcon.Question, MessageBoxDefaultButton.Button2) != DialogResult.Yes) return;
      }

      new frmStockArticleClientSite
      {
        mstrStatut = "INV",
        mstrStatutInv = "C",
        miNumSite = iSiteNum,
        miNumClient = iClientNum
      }.ShowDialog();

      //  ' pour rafraichir la liste des DI afin de voir l'action de fourniture
      //  gbRefresh = True
    }

    private void cmdCot_Click(object sender, System.EventArgs e)
    {
      DialogResult res = new MsgBoxPerso(Resources.msg_creer_action_cotraitant_ou_action_garantie,
                                          Program.AppTitle, MessageBoxIcon.Question, "Gestion cotraitant", "Gestion Garantie", true).ShowDialog();
      string sType = "";
      switch (res)
      {
        case DialogResult.Cancel: //ici le traitement (éventuel) si Annulation 
          return;
        case DialogResult.Yes://Cotraitant 
          sType = "C"; break;
        case DialogResult.No://Garantie 
          sType = "G"; break;
      }

      // création d'une commande
      try
      {
        using (SqlCommand cmd = new SqlCommand("Api_sp_CreationActionFacCotrait", MozartDatabase.cnxMozart))
        {
          cmd.CommandType = CommandType.StoredProcedure;
          SqlCommandBuilder.DeriveParameters(cmd);    // liste des paramètres

          // liste des paramètres
          cmd.Parameters["@iAction"].Value = MozartParams.NumAction;
          cmd.Parameters["@Type"].Value = sType;

          // exécuter la commande.
          cmd.ExecuteNonQuery();

          // récupération du numéro crée
          int iAction = Convert.ToInt32(cmd.Parameters[0].Value);

          int iOldAction = MozartParams.NumAction;
          MozartParams.NumAction = iAction;

          new frmDetailstravaux { iSiteNum = iSiteNum, mstrStatutAction = "M" }.ShowDialog();

          MozartParams.NumAction = iOldAction;
          bModif = false;

          Close();
        }
      }
      catch (Exception ex) { Utils.ShowError(ex, $"{MethodBase.GetCurrentMethod().Name} dans {this.Name}"); }
    }

    private void cmdAct_Click(object sender, System.EventArgs e)
    {
      if ((string)cboPrest.SelectedValue == "B")
      {
        MessageBox.Show(Resources.msg_pas_acces_bouton_prest_garantie, Program.AppTitle, MessageBoxButtons.OK, MessageBoxIcon.Information);
        return;
      }

      // recherche de l'action de fourniture de cette action préventive (ce site et cette DI)
      using (SqlDataReader reader = ModuleData.ExecuteReader($"select NACTNUM from TACT WITH (NOLOCK) where NDINNUM = {MozartParams.NumDi} AND NSITNUM = {iSiteNum} AND VACTDES Like 'FOURNITURE%'"))
      {
        if (!reader.Read())
        {
          if (MessageBox.Show(Resources.msg_creer_actio_fournitures_pour_action, Program.AppTitle, MessageBoxButtons.YesNo,
                              MessageBoxIcon.Question, MessageBoxDefaultButton.Button2) != DialogResult.Yes) return;
        }
        else
        {
          if (MessageBox.Show(Resources.msg_action_fournitures_site_existe_creer, Program.AppTitle, MessageBoxButtons.YesNo,
                              MessageBoxIcon.Question, MessageBoxDefaultButton.Button2) != DialogResult.Yes) return;
        }

        // création d'une commande
        using (SqlCommand cmd = new SqlCommand("Api_sp_CreationActionFourniture", MozartDatabase.cnxMozart))
        {
          cmd.CommandType = CommandType.StoredProcedure;
          SqlCommandBuilder.DeriveParameters(cmd);    // liste des paramètres

          // liste des paramètres
          cmd.Parameters["@iAction"].Value = MozartParams.NumAction;

          // exécuter la commande.
          cmd.ExecuteNonQuery();

          // récupération du numéro crée
          int iAction = Convert.ToInt32(cmd.Parameters[0].Value);

          int iOldAction = MozartParams.NumAction;
          MozartParams.NumAction = iAction;

          new frmDetailstravaux { iSiteNum = iSiteNum, mstrStatutAction = "M" }.ShowDialog();

          MozartParams.NumAction = iOldAction;
          bModif = false;

          Close();
        }
      }
    }

    private void cmdCourrier_Click(object sender, System.EventArgs e)
    {
      // mise à jour nomsocietetemp
      MozartParams.NomSocieteTemp = MozartParams.NomSociete;

      new frmListeCourrierAction
      {
        miClient = iClientNum,
        miSite = iSiteNum,
        //  si stf alors on prend le contact
        miSTFcontact = (optInter1.Checked || optInter2.Checked || optInter3.Checked) && txtContact.Tag != null ? (int)txtContact.Tag : 0,
        mstrClient = txtClient.Text,
        mstrSite = txtSite.Text,
        mstrCompte = txtCompte.Text
      }.ShowDialog();

      //  rafraichir l'affichage
      OuvertureEnModification();
    }

    private void cmdCopie_Click(object sender, System.EventArgs e)
    {
      if ((string)cboPrest.SelectedValue == "B")
      {
        MessageBox.Show(Resources.msg_pas_acces_bouton_prest_garantie, Program.AppTitle, MessageBoxButtons.OK, MessageBoxIcon.Information);
        return;
      }

      frmListeDevisPourCopie frm = new frmListeDevisPourCopie
      {
        mNumSite = iSiteNum
      };
      frm.ShowDialog();

      if (frm.msStatutAction != null && frm.msStatutAction != "")
      {
        mstrStatutAction = frm.msStatutAction;
      }

      // rafraichir l'affichage
      OuvertureEnModification();
    }

    private void cmdAttGam_Click(object sender, System.EventArgs e)
    {
      Cursor.Current = Cursors.WaitCursor;
      new frmVisuAttGamme().ShowDialog();
      Cursor.Current = Cursors.Default;
    }

    private void cmdImgFact_Click(object sender, System.EventArgs e)
    {
      if (cboFactRavel.SelectedIndex == -1) return;
      cboFactRavelItem item = cboFactRavel.SelectedItem as cboFactRavelItem;
      if (item.NFOUFACNUM > 0)
      {
        using (SqlDataReader reader = ModuleData.ExecuteReader($"SELECT VFACFILE, NFACCDE, year(DDATCREE) 'ANNEE' FROM TFOUFAC F WITH (NOLOCK) INNER JOIN " +
                                                               $"TFOUFACCDE E WITH (NOLOCK) ON F.NFOUFACNUM = E.NFOUFACNUM " +
                                                          $"WHERE F.NFOUFACNUM = {item.NFOUFACNUM} AND NACTNUM = {MozartParams.NumAction}"))
        {
          if (reader.Read())
          {
            string VFACFILE = Utils.BlankIfNull(reader["VFACFILE"]);
            if (VFACFILE == "")
            {
              MessageBox.Show("§Le fichier saisi dans RAVEL n'existe pas§", Program.AppTitle, MessageBoxButtons.OK, MessageBoxIcon.Error);
              return;
            }
            else
            {
              if ((int)reader["ANNEE"] < 2018 && MozartParams.NomSociete == "EMALEC")
              {
                VFACFILE = Utils.RechercheParam("REP_FACT_RAVEL") + "Archive.pdf";
              }
              else
              {
                VFACFILE = Utils.RechercheParam("REP_FACT_RAVEL") + Utils.BlankIfNull(reader["VFACFILE"]);
              }
            }

            new frmBrowser
            {
              mlNumRavel = (long)Utils.ZeroIfNull(reader["NFACCDE"]),
              msStartingAddress = VFACFILE //Utils.RechercheParam("REP_FACT_RAVEL") + Utils.BlankIfNull(reader["VFACFILE"])
            }.ShowDialog();
          }
        }
      }
    }

    private void cmdDI_Click(object sender, System.EventArgs e)
    {
      new frmDIsite
      {
        miNumSite = iSiteNum
      }.ShowDialog();
    }

    private void cmdMess_Click(object sender, System.EventArgs e)
    {
      if ((string)cboPrest.SelectedValue == "B")
      {
        MessageBox.Show(Resources.msg_pas_acces_bouton_prest_garantie, Program.AppTitle, MessageBoxButtons.OK, MessageBoxIcon.Information);
        return;
      }
      int nb = (int)ModuleData.ExecuteScalarInt($"SELECT COUNT(NSTTNUM) FROM TACT WITH (NOLOCK) INNER JOIN" +
                                                $" TINT WITH (NOLOCK) ON TINT.NINTNUM = TACT.NINTNUM INNER JOIN" +
                                                $" TSTF WITH (NOLOCK) ON TSTF.NSTFNUM = TINT.NSTFNUM INNER JOIN" +
                                                $" TSTTECH WITH (NOLOCK) ON TSTTECH.NSTFGRPNUM = TSTF.NSTFGRPNUM" +
                                                $" WHERE NACTNUM = {MozartParams.NumAction}");
      if (nb == 0)
      {
        MessageBox.Show(Resources.msg_pas_acces_web_pour_stt, Program.AppTitle, MessageBoxButtons.OK, MessageBoxIcon.Information);
        return;
      }
      new frmGestMessageWebSTT
      {
        sNumDI = txtDI.Text,
        sNumCS = txtClient.Text,
        sNomCLient = txtClient.Text,
        sNomSite = txtSite.Text
      }.ShowDialog();
    }

    private void CmdDateCde_Click(object sender, System.EventArgs e)
    {
      iTextBoxDate = 4;
      _curDate = DateTime.MinValue; Calendar1.Value = DateTime.Now;
      Calendar1.Visible = true;
      Calendar1.ShowCalendar(new MouseEventArgs(MouseButtons.Left, 1, MousePosition.X, MousePosition.Y, 0));
      CmdDateCde.Visible = false;
      CmdSuppCde.Visible = true;
    }

    private void CmdSuppCde_Click(object sender, System.EventArgs e)
    {
      txtDateA4.Text = "";
      bModif = true;
      CmdDateCde.Visible = true;
      CmdSuppCde.Visible = false;
    }

    private void CmdVoiratt_Click(object sender, System.EventArgs e)
    {
      if (!Pdf1.Visible)
      {
        string[] strRepFic = new[] { Utils.RechercheParam("REP_ATTGAM"), Utils.RechercheParam("REP_PHOTOS_ACT") };


        // recherche des attachements
        using (SqlDataReader reader = ModuleData.ExecuteReader($"select TOp 1 NTYPEDOC, VFICHIER from TIMAC WITH (NOLOCK) where (VTYPE = 'ATTACH' OR NTYPEDOC = 37) AND NACTNUM = {MozartParams.NumAction} ORDER BY NTYPEDOC DESC"))
        {
          if (reader.Read())
          {
            Pdf1.Navigate($"{((int)Utils.ZeroIfNull(reader["NTYPEDOC"]) == 37 ? strRepFic[1] : strRepFic[0])}{Utils.BlankIfNull(reader["VFICHIER"])}");
            using (Process p = new Process())
            {
              p.StartInfo.FileName = $"{((int)Utils.ZeroIfNull(reader["NTYPEDOC"]) == 37 ? strRepFic[1] : strRepFic[0])}{Utils.BlankIfNull(reader["VFICHIER"])}";
              p.StartInfo.UseShellExecute = true;
              p.Start();
            }
          }
          else
            Pdf1.Navigate("about:blank");
        }
        Pdf1.Visible = true;
        lblTitre.Visible = true;
      }
      else
      {
        Pdf1.Visible = false;
        lblTitre.Visible = false;
      }
    }

    private void CmdData_Click(object sender, System.EventArgs e)
    {
      if ((string)cboPrest.SelectedValue == "B")
      {
        MessageBox.Show(Resources.msg_pas_acces_bouton_prest_garantie, Program.AppTitle, MessageBoxButtons.OK, MessageBoxIcon.Information);
        return;
      }
      new frmListeData
      {
        miNumSite = iSiteNum,
        mstrSite = txtSite.Text
      }.ShowDialog();
    }

    private void cmdRechEquipement_Click(object sender, System.EventArgs e)
    {
      // Ouvrir une liste de recherche des équipements
      frmApiRecherche frm = new frmApiRecherche(MozartDatabase.cnxMozart);
      frm.msSql = $"SELECT NOBJNUM, VOBJNUMEQUIP Numéro, VTYPECONTRAT Contrat, VNIV1 Famille, VOBJNUMSERIE [N° Série], VOBJLIB Objet from TGIDTOBJCLI WITH (NOLOCK) INNER JOIN " +
                  $" TGIDTARBOCLI WITH (NOLOCK) ON TGIDTOBJCLI.NARBONUM=TGIDTARBOCLI.NARBONUM INNER JOIN " +
                  $" TREF_TYPECONTRAT WITH (NOLOCK) ON TGIDTARBOCLI.NTYPECONTRAT = TREF_TYPECONTRAT.NTYPECONTRAT " +
                  $" WHERE {(iSiteNum != 0 ? $"NSITNUM={iSiteNum}" : $"NCLINUM={iClientNum}")} AND LANGUE ='{MozartParams.Langue}'" +
                  $" ORDER BY VNIV1, VNIV2, VOBJLIB";
      frm.msType = "OBJET";
      frm.miTypContrat = iTypContrat;
      frm.mTxtDI = txtDI.Text;
      frm.ShowDialog();

      if (frm.mlItemData > 0)
      {
        txtNumero.Text = frm.msRetour;
        txtNumero.Tag = frm.mlItemData;
        txtObjGidt.Text = frm.m_txtObjGidt;
        txtObjGidt.Tag = frm.m_txtObjGidt_Tag;

        // recherche du sous-traitant imposé
        using (SqlDataReader reader = ModuleData.ExecuteReader($"api_sp_InfoSTGidt {txtNumero.Tag}"))
        {
          if (reader.Read())
          {
            // on sélectionne un sous traitant de maintenance car dans la liste des ST imposé dans le GIDT ceux sont des ST de maintenance
            lblInter.Tag = "S";
            optInter1.Checked = true;
            txtFixe.Text = Utils.BlankIfNull(reader["VINTTEL"]);
            txtPort.Text = Utils.BlankIfNull(reader["VINTPOR"]);
            txtContact.Tag = Convert.IsDBNull(reader["NINTNUM"]) ? null : reader["NINTNUM"];
            txtContact.Text = Utils.BlankIfNull(reader["VINTNOM"]);
            txtInter.Tag = Convert.IsDBNull(reader["NSTFNUM"]) ? null : reader["NSTFNUM"];
            txtInter.Text = Utils.BlankIfNull(reader["VSTFNOM"]);
          }
        }
      }
    }

    private void cmdComSecu_Click(object sender, System.EventArgs e)
    {
      new frmInventaireEquipementSite
      {
        nsitnum = iSiteNum,
        vsitnom = txtClient.Text,
        vclinom = txtSite.Text
      }.ShowDialog();

      //new frmCommissionSec
      //{
      //  iNumsite = iSiteNum
      //}.ShowDialog();
    }

    private void chkInfoSite_MouseDown(object sender, MouseEventArgs e)
    {
      if (mstrStatutAction == "C") return;

      //test si heure rendez-vous existe deja dans une des acions du pavé
      if (e.Button == MouseButtons.Left && chkInfoSite.CheckState == CheckState.Unchecked && bInit == false)
      {
        if (ModuleData.ExecuteScalarInt($"EXEC [api_sp_GetRdv_By_Pave] {MozartParams.NumAction}") > 1)
        {
          MessageBox.Show("Vous ne pouvez pas valider ce RDV car il existe plusieurs heures dans la case « Rendez-vous »", Program.AppTitle, MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
          chkInfoSite.CheckState = CheckState.Unchecked;
          return;
        }
      }

      if (e.Button == MouseButtons.Left) MiseAjourInfoMag(chkInfoSite.Checked ? 0 : 1);

      // APRIA
      // TB SAMSIC CITY SPEC
      //if (!chkInfoSite.Checked && iClientNum == 1832 && MozartParams.NomGroupe == "EMALEC")
      //{
      // on envoi un mail au client
      //ModuleData.ExecuteNonQuery($"api_sp_SendMailAPRIASiteInfo {MozartParams.NumAction}");
      //}

      //  ' on envoi un mail au client lorsque le site est informé d'une action planifiée et informée
      if (!chkInfoSite.Checked)
      {
        ModuleData.ExecuteNonQuery($"api_sp_SendMailClientSiteInfo {MozartParams.NumAction}, {iClientNum}");
      }

      //  FGA le 14112023 ' on ajoute un message sur les plateforme d'echange
      if (!chkInfoSite.Checked)
      {
        // Recherche de la plateforme pour ce client
        string sEditeur = getEditeurGMAO();
        if ((sEditeur != "") && (sEditeur != "DAISY"))
        {
          MessageBox.Show("Une passerelle GMAO est paramétrée sur ce client, pensez à transmettre la date de planification", Program.AppTitle, MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
        }
      }

      // affichage de l'info site
      if (!chkInfoSite.Checked)
      {
        DetailstravauxUtils.Info InfoSite = DetailstravauxUtils.RechercheInfos("INFO_SITE", iSiteNum);
        if (InfoSite.strInfo != "" && InfoSite.DateValDeb < DateTime.Now && InfoSite.DateValFin > DateTime.Now)
        {
          new frmInfosClient
          {
            msStatut = "S",//site
            msInfo = InfoSite.strInfo
          }.ShowDialog();
          chkInfoSite.Checked = true;
        }
      }


      bModif = true;
    }

    private string getEditeurGMAO()
    {
      string sResult = "";

      try
      {
        using (SqlDataReader reader = ModuleData.ExecuteReader($"select * FROM api_v_listePlateforme Where NCLINUM = {iClientNum}"))
        {
          if (reader.Read())
          {
            sResult = Utils.BlankIfNull(reader["EDITEUR"]);
          }
        }
      }
      catch (Exception ex)
      {
        Utils.ShowError(ex, $"{MethodBase.GetCurrentMethod().Name} dans {this.Name}");
      }

      return sResult;
    }

    void MiseAjourInfoMag(int info)
    {
      try
      {
        using (SqlDataReader reader = ModuleData.ExecuteReader($"exec api_sp_UpdateInfoMag {info}, {MozartParams.NumAction},'{txtQui.Text.Replace("'", "''")}'"))
        {
          if (reader.Read() && Utils.BlankIfNull(reader["CACTINFOMAG"]) == "O")
          {
            lblQuiInfo.Text = $"{Resources.lib_par}{Utils.BlankIfNull(reader["VACTQUIINFO"])}{Resources.lib_le}{Utils.DateBlankIfNull(reader["DACTQUANDINFO"])}";
            txtQui.Text = Utils.BlankIfNull(reader["VACTINFOQUI"]);
            txtQui.Visible = true;
            lblLabels30.Visible = true;
            txtObserv.Text = $"{MozartParams.strUID} : Site informé le {DateTime.Now.ToString("dd/MM/yy HH:mm")}{Environment.NewLine}{txtObserv.Text}";

            //pour le client action, on fait un cas spécifique le 24/04/2024 validé par Philippe Viguier
            if (iClientNum == 19678)
            {
              ModuleData.ExecuteNonQuery($"exec [api_sp_SendMailClientSiteInfo_By_IPL_ACTION] {MozartParams.NumAction}, {iClientNum}");
            }

          }
          else
          {
            lblQuiInfo.Text = "";
            txtQui.Text = "";
            txtQui.Visible = false;
            lblLabels30.Visible = false;
            txtObserv.Text = $"{MozartParams.strUID} : Suppression Site informé le {DateTime.Now.ToString("dd/MM/yy HH:mm")}{Environment.NewLine}{txtObserv.Text}";
          }
        }
      }
      catch (Exception ex) { Utils.ShowError(ex, $"{MethodBase.GetCurrentMethod().Name} dans {this.Name}"); }
    }
    //Private Sub MiseAjourInfoMag(sValue As Integer)
    //
    //Dim pRS As ADODB.Recordset
    //
    //On Error GoTo handler
    //      
    //      
    //  Set pRS = New ADODB.Recordset
    //  pRS.Open "exec api_sp_UpdateInfoMag " & sValue & ", " & glNumAction & ",'" & Replace(txtQui, "'", "''") & "'", cnx
    //  
    //  If pRS("CACTINFOMAG") = "O" Then
    //    lblQuiInfo.Caption = "§Par: §" & pRS("VACTQUIINFO") & "§ le §" & pRS("DACTQUANDINFO")
    //    txtQui = pRS("VACTINFOQUI")
    //    lblLabels(30).Visible = True
    //    txtQui.Visible = True
    //    txtObserv = gstrUID & " : Site informé le " & Format(Now, "dd/MM/YY HH:MM") & vbCrLf & txtObserv
    //  Else
    //    lblQuiInfo.Caption = ""
    //    txtQui = ""
    //    lblLabels(30).Visible = False
    //    txtQui.Visible = False
    //    txtObserv = gstrUID & " : Suppression Site informé le " & Format(Now, "dd/MM/YY HH:MM") & vbCrLf & txtObserv
    //  End If
    //Exit Sub
    //Resume
    //handler:
    //  ShowError "MiseAjourInfoMag dans " & Me.Name
    //End Sub
    //
    /* --------------------------------------------------------------------------------------- */
    private void cmdFact_Click(object sender, System.EventArgs e)
    {
      try
      {
        if (txtEtatAdmin.Text == Resources.lib_facturee)
        {
          MessageBox.Show(Resources.msg_impossible_modif_statut_action_facturee, Program.AppTitle, MessageBoxButtons.OK, MessageBoxIcon.Information);
          return;
        }
        if (txtEtatAdmin.Text == Resources.lib_chiffree)
        {
          MessageBox.Show(Resources.msg_supp_chiffrage_action_pour_statut_N, Program.AppTitle, MessageBoxButtons.OK, MessageBoxIcon.Information);
          return;
        }

        // si le statut est deja NF
        if (txtEtatAdmin.Text == Resources.lib_non_facture)
        {
          if (MessageBox.Show(Resources.msg_repasser_statut_action_A, Program.AppTitle, MessageBoxButtons.YesNoCancel,
                              MessageBoxIcon.Question, MessageBoxDefaultButton.Button2) != DialogResult.Yes) return;
          // procedure qui passe à A
          PasserStatutAdminA();
          //           gbRefresh = True
          // rafraichissement
          OuvertureEnModification();
        }
        else
        {
          // Test si document interne present
          // si oui alors msg
          if (TestIfDocInterne())
          {
            if (MessageBox.Show($"{Resources.msg_docs_internes_pouvant_etre_facture_client_presents_dans_action_code_NF}{Environment.NewLine}" +
                                $"{Resources.msg_verif_rien_avant_action_en_NF_sinon_facturer_oubli}{Environment.NewLine}" +
                                $"{Resources.msg_confirm_passer_action_NF}", Program.AppTitle, MessageBoxButtons.YesNoCancel,
                                MessageBoxIcon.Question, MessageBoxDefaultButton.Button2) != DialogResult.Yes) return;
          }

          if (MessageBox.Show(Resources.msg_passer_statut_action_N, Program.AppTitle, MessageBoxButtons.YesNoCancel,
                              MessageBoxIcon.Question, MessageBoxDefaultButton.Button2) != DialogResult.Yes) return;
          // procedure qui passe à F
          PasserStatutAdminF();
          //           gbRefresh = True
          // rafraichissement
          OuvertureEnModification();
        }
      }
      //catch (Exception ex) { MessageBox.Show($"{ex.Message}\r\n\r\n{Resources.Global_dans}{MethodBase.GetCurrentMethod().Name}", Resources.Global_Erreur, MessageBoxButtons.OK, MessageBoxIcon.Exclamation); }
      catch (Exception ex) { Utils.ShowError(ex, $"{MethodBase.GetCurrentMethod().Name} dans {this.Name}"); }
    }
    //Private Sub cmdFact_Click()
    //
    //On Error GoTo handler
    //
    //  If txtEtatAdmin = "§Facturé§" Then
    //      MsgBox "§Impossible de modifier le statut de l'action car elle est facturée !§", vbInformation
    //      Exit Sub
    //  End If
    //
    //
    //  If txtEtatAdmin = "§Chiffré§" Then
    //      MsgBox "§Il faut supprimer le chiffrage sur l'action pour pouvoir passer le statut de l'action à 'N' !§", vbInformation
    //      Exit Sub
    //  End If
    //      
    //
    //  ' si le statut est deja NF
    //  If txtEtatAdmin = "§Non Facturé§" Then
    //   
    //      Select Case MsgBox("§Voulez-vous repasser le statut de l'action à 'A' ?§", vbYesNoCancel + vbQuestion + vbDefaultButton2)
    //        Case vbYes
    //          ' procedure qui passe à A
    //           PasserStatutAdminA
    //           gbRefresh = True
    //           ' rafraichissement
    //           'OuvertureEnModification
    //        Case vbNo
    //          Exit Sub
    //        Case vbCancel
    //          Exit Sub
    //      End Select
    //   
    //  Else
    //  
    //      'Test si document interne present
    //      'si oui alors msg
    //      If TestIfDocInterne = True Then
    //        If MsgBox("§Des documents internes pouvant être facturés au client sont présents dans l’action que vous souhaitez codifiée en NF.§" & vbCrLf & _
    //                    "§Vérifier qu’il en est rien avant de passer cette action en NF, sinon ces éléments à facturer seront oubliés.§" & vbCrLf & _
    //                    "§Confirmez-vous vouloir passer cette action en NF ?§", vbYesNoCancel + vbQuestion + vbDefaultButton2) <> vbYes Then
    //            Exit Sub
    //        End If
    //      End If
    //  
    //      Select Case MsgBox("§Voulez-vous passer le statut de l'action à 'N' ?§", vbYesNoCancel + vbQuestion + vbDefaultButton2)
    //        Case vbYes
    //          ' procedure qui passe à F
    //           PasserStatutAdminF
    //           gbRefresh = True
    //           ' rafraichissement
    //           OuvertureEnModification
    //        Case vbNo
    //          Exit Sub
    //        Case vbCancel
    //          Exit Sub
    //      End Select
    //
    //  End If
    //
    //Exit Sub
    //
    //handler:
    //  ShowError "cmdFact_Click dans " & Me.Name
    //End Sub
    //
    /* --------------------------------------------------------------------------------------- */
    private void cmdLier_Click(object sender, System.EventArgs e)
    {
      try
      {
        if (txtduree.Text == "")
        {
          MessageBox.Show(Resources.msg_enreg_duree_non_nulle, Program.AppTitle, MessageBoxButtons.OK, MessageBoxIcon.Information);
          return;
        }

        // si statut <> 'O' et tech
        if ((string)cboEtat.SelectedValue == "A" || (string)cboEtat.SelectedValue == "D")
        {
          MessageBox.Show(Resources.msg_planifier_statut_O, Program.AppTitle, MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
          return;
        }

        using (SqlDataReader reader = ModuleData.ExecuteReader($"exec api_sp_InfoplanifLier {MozartParams.NumAction}"))
        {
          if (reader.Read())
          {
            if (Utils.ZeroIfNull(reader["NPERNUM"]) == 10)
            {
              MessageBox.Show(Resources.msg_pouvez_pas_lier_preventive_car_etat_Aplanifier, Program.AppTitle, MessageBoxButtons.OK, MessageBoxIcon.Information);
              return;
            }

            // création d'une nouvelle IP avec l'action sélectionnée
            new frmPlan
            {
              miNumIp = 0,
              miNumSite = iSiteNum,
              mdSemaine = Convert.ToDateTime(reader["DatePla"]),
              miNumTech = (int)Utils.ZeroIfNull(reader["NPERNUM"]),
              miDuree = Utils.ZeroIfBlank(txtduree.Text),
              mStrStatutIP = "C",
              // ( client / site )
              mStrTagIP = $"{txtClient.Text}{Environment.NewLine}{txtSite.Text}{Environment.NewLine}"
            }.ShowDialog();

            // après la planification, on met une info dans l'observation pour savoir que cette action
            // est liée à la préventive
            ModuleData.ExecuteNonQuery($"update TACT set VACTOBS = ' Lié à la Prev le {DateTime.Now.ToString("dd/MM/yy HH:mm")} par {MozartParams.strUID}.'" +
                                      $"  + char(13) + char(10) +  coalesce(VACTOBS,'')  Where NACTNUM = {MozartParams.NumAction}");

            OuvertureEnModification();
          }
        }
      }
      //catch (Exception ex) { MessageBox.Show($"{ex.Message}\r\n\r\n{Resources.Global_dans}{MethodBase.GetCurrentMethod().Name}", Resources.Global_Erreur, MessageBoxButtons.OK, MessageBoxIcon.Exclamation); }
      catch (Exception ex) { Utils.ShowError(ex, $"{MethodBase.GetCurrentMethod().Name} dans {this.Name}"); }
    }

    private void cmdVoir_Click(object sender, System.EventArgs e)
    {
      try
      {
        using (SqlDataReader reader = ModuleData.ExecuteReader($"exec api_sp_InfoplanifLier {MozartParams.NumAction}"))
        {
          if (reader.Read())
          {
            // visualisation du planing
            new frmPlan
            {
              miNumIp = 0,
              miNumSite = 0,
              mdSemaine = Convert.ToDateTime(reader["DatePla"]),
              miNumTech = (int)Utils.ZeroIfNull(reader["NPERNUM"]),
              mStrStatutIP = "M"
            }.ShowDialog();
          }
        }
      }
      //catch (Exception ex) { MessageBox.Show($"{ex.Message}\r\n\r\n{Resources.Global_dans}{MethodBase.GetCurrentMethod().Name}", Resources.Global_Erreur, MessageBoxButtons.OK, MessageBoxIcon.Exclamation); }
      catch (Exception ex) { Utils.ShowError(ex, $"{MethodBase.GetCurrentMethod().Name} dans {this.Name}"); }
    }
    //Private Sub cmdVoir_Click()
    //
    //Dim pRS As ADODB.Recordset
    //
    //On Error GoTo handler
    //    
    //  Set pRS = New ADODB.Recordset
    //  pRS.Open "exec api_sp_InfoplanifLier " & glNumAction, cnx
    //                            
    //  ' visualisation du planing
    //  frmPlan.miNumIP = 0
    //  frmPlan.miNumSite = 0
    //  frmPlan.mdSemaine = pRS("DatePla").value
    //  frmPlan.miNumTech = ZeroIfNull(pRS("NPERNUM").value)
    //  frmPlan.mStrStatutIP = "M"
    //  frmPlan.Show vbModal
    //
    //Exit Sub
    //handler:
    //  ShowError "cmdVoir_Click dans " & Me.Name
    //End Sub
    //
    /* --------------------------------------------------------------------------------------- */
    private void cmdVoirVille_Click(object sender, System.EventArgs e)
    {
      try
      {
        using (SqlDataReader reader = ModuleData.ExecuteReader($"exec api_sp_InfoplanifLierVille {MozartParams.NumAction}"))
        {
          if (reader.Read())
          {
            // visualisation du planing
            new frmPlan
            {
              miNumIp = 0,
              miNumSite = 0,
              mdSemaine = Convert.ToDateTime(reader["DatePla"]),
              miNumTech = (int)Utils.ZeroIfNull(reader["NPERNUM"]),
              mStrStatutIP = "M"
            }.ShowDialog();
          }
        }
      }
      //catch (Exception ex) { MessageBox.Show($"{ex.Message}\r\n\r\n{Resources.Global_dans}{MethodBase.GetCurrentMethod().Name}", Resources.Global_Erreur, MessageBoxButtons.OK, MessageBoxIcon.Exclamation); }
      catch (Exception ex) { Utils.ShowError(ex, $"{MethodBase.GetCurrentMethod().Name} dans {this.Name}"); }

    }
    //Private Sub cmdVoirVille_Click()
    //
    //Dim pRS As ADODB.Recordset
    //
    //On Error GoTo handler
    //    
    //  Set pRS = New ADODB.Recordset
    //  pRS.Open "exec api_sp_InfoplanifLierVille " & glNumAction, cnx
    //             
    //  ' visualisation du planning
    //  frmPlan.miNumIP = 0
    //  frmPlan.miNumSite = 0
    //  frmPlan.mdSemaine = pRS("DatePla").value
    //  frmPlan.miNumTech = ZeroIfNull(pRS("NPERNUM").value)
    //  frmPlan.mStrStatutIP = "M"
    //  frmPlan.Show vbModal
    //Exit Sub
    //
    //handler:
    //  ShowError "cmdVoirVille_Click dans " & Me.Name
    //End Sub
    //
    /* --------------------------------------------------------------------------------------- */
    private void cmdLierVille_Click(object sender, System.EventArgs e)
    {
      try
      {
        if (txtduree.Text == "")
        {
          MessageBox.Show(Resources.msg_enreg_duree_non_nulle, Program.AppTitle, MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
          return;
        }

        // si statut <> 'O' et tech
        if ((string)cboEtat.SelectedValue == "A" || (string)cboEtat.SelectedValue == "D")
        {
          MessageBox.Show(Resources.msg_planifier_statut_O, Program.AppTitle, MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
          return;
        }

        using (SqlDataReader reader = ModuleData.ExecuteReader($"exec api_sp_InfoplanifLierVille {MozartParams.NumAction}"))
        {
          if (reader.Read())
          {
            // création d'une nouvelle IP avec l'action sélectionnée
            new frmPlan
            {
              miNumIp = 0,
              miNumSite = iSiteNum,
              mdSemaine = Convert.ToDateTime(reader["DatePla"]),
              miNumTech = (int)Utils.ZeroIfNull(reader["NPERNUM"]),
              miDuree = Utils.ZeroIfBlank(txtduree.Text),
              mStrStatutIP = "C",
              // ( client / site )
              mStrTagIP = $"{txtClient.Text}{Environment.NewLine}{txtSite.Text}{Environment.NewLine}"
            }.ShowDialog();

            // rafraichir l'affichage
            OuvertureEnModification();
          }
        }
      }
      //catch (Exception ex) { MessageBox.Show($"{ex.Message}\r\n\r\n{Resources.Global_dans}{MethodBase.GetCurrentMethod().Name}", Resources.Global_Erreur, MessageBoxButtons.OK, MessageBoxIcon.Exclamation); }
      catch (Exception ex) { Utils.ShowError(ex, $"{MethodBase.GetCurrentMethod().Name} dans {this.Name}"); }
      finally { Cursor.Current = Cursors.Default; }
    }
    private void cmdDetFact_Click(object sender, System.EventArgs e)
    {
      try
      {
        if (txtNumFact.Text == "") return;
        Cursor.Current = Cursors.WaitCursor;

        // gestion des droits pour savoir si la personne peut accéder ou pas à la facture
        if (!DroitFacture(Convert.ToInt32(Strings.Mid(txtNumFact.Text, 3))))
        {
          MessageBox.Show("Vous n'avez pas les droits pour voir cette facture", Program.AppTitle, MessageBoxButtons.OK, MessageBoxIcon.Information);
          return;
        }

        if ((string)txtNumFact.Tag == "F")
        {
          new frmModFacture(Convert.ToInt32(Strings.Mid(txtNumFact.Text, 3))).ShowDialog();
        }
        else
        {
          MessageBox.Show(Resources.msg_avoir_modif_impossible, Program.AppTitle, MessageBoxButtons.OK, MessageBoxIcon.Information);
        }
      }
      //catch (Exception ex) { MessageBox.Show($"{ex.Message}\r\n\r\n{Resources.Global_dans}{MethodBase.GetCurrentMethod().Name}", Resources.Global_Erreur, MessageBoxButtons.OK, MessageBoxIcon.Exclamation); }
      catch (Exception ex) { Utils.ShowError(ex, $"{MethodBase.GetCurrentMethod().Name} dans {this.Name}"); }
      finally { Cursor.Current = Cursors.Default; }
    }

    private void frmDetailstravaux_KeyPress(object sender, KeyPressEventArgs e)
    {
      bModif = true;
    }

    private void cmdIC_Click(object sender, System.EventArgs e)
    {
      using (SqlDataReader reader = ModuleData.ExecuteReader($"select VCLIMESS from TCLI WHERE NCLINUM = {iClientNum}"))
      {
        if (!reader.Read() || Utils.BlankIfNull(reader["VCLIMESS"]) == "")
        {
          cmdIC.Enabled = false;
          return;
        }

        new frmInfo
        {
          msType = "Client",
          msInfo = Utils.BlankIfNull(reader["VCLIMESS"])
        }.ShowDialog();
      }
    }

    private void cmdIS_Click(object sender, System.EventArgs e)
    {
      if (iSiteNum == 0) return;
      new frmSiteGestionDocInterne(iSiteNum.ToString()).ShowDialog();

      //using (SqlDataReader reader = ModuleData.ExecuteReader($"SELECT VNOTMESS FROM TNOTES WITH (NOLOCK) WHERE VNOTTYPE = 'INFO_SITE' AND NNOTCLE = {iSiteNum}"))
      //{
      //  if (!reader.Read())
      //  {
      //    cmdIS.Enabled = false;
      //    return;
      //  }

      //  new frmInfo
      //  {
      //    msType = "Site",
      //    msInfo = Utils.BlankIfNull(reader["VNOTMESS"])
      //  }.ShowDialog();
      //}
    }

    private void cmdSupp1_Click(object sender, System.EventArgs e)
    {
      if ((string)cboPrest.SelectedValue == "P" && bKPIGest_DatePrev && !GetDroitModifDateSouhaitee())
      {
        MessageBox.Show($"{Resources.msg_non_autorise_modif_date}.{Environment.NewLine}" +
                        Resources.msg_demande_resp_hierachique + ".", Program.AppTitle, MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
        return;
      }

      // ajout dans l'observation de l'action
      txtObserv.Text = $"{MozartParams.strUID} {DateTime.Now.ToString("dd / MM / YY HH: MM")} : La date souhaitée supprimée est le  {txtDateA0.Text.Replace("'", "''")}" +
                       $"{Environment.NewLine}{txtObserv.Text}";
      txtDateA0.Text = "";
      bModif = true;
    }

    private void CmdSupp3_Click(object sender, System.EventArgs e)
    {
      try
      {
        if (!bDroitVisa && chkVisaExec.Checked)
        {
          MessageBox.Show(Resources.msg_date_exec_verifiee_non_modifiable, Program.AppTitle, MessageBoxButtons.OK, MessageBoxIcon.Information);
          return;
        }

        // si il n'y a, pas de date, on sort
        if (txtDateA2.Text == "") return;

        // si il y a des modifications
        if (MessageBox.Show(Resources.msg_supprimer_date_exec, Program.AppTitle, MessageBoxButtons.YesNoCancel,
                            MessageBoxIcon.Question, MessageBoxDefaultButton.Button2) != DialogResult.Yes) return;
        // procedure qui supprime l'action de l'IP et qui remet les données cohérentes dans l'action
        SupprimerExec();
        //       gbRefresh = True
        // rafraichissement
        OuvertureEnModification();
      }
      //catch (Exception ex) { MessageBox.Show($"{ex.Message}\r\n\r\n{Resources.Global_dans}{MethodBase.GetCurrentMethod().Name}", Resources.Global_Erreur, MessageBoxButtons.OK, MessageBoxIcon.Exclamation); }
      catch (Exception ex) { Utils.ShowError(ex, $"{MethodBase.GetCurrentMethod().Name} dans {this.Name}"); }
    }

    private void cmdSupp2_Click(object sender, System.EventArgs e)
    {
      try
      {
        // si il n'y a, pas de date, on sort
        if (txtDateA1.Text == "") return;

        // suppression de la date de planification donc suppression de la planification
        // si le statut est exécuté ou plus, pas de modification possible
        if ((string)cboEtat.SelectedValue == "E")
        {
          MessageBox.Show($"{Resources.msg_impossible_supp_planif_action}{Environment.NewLine}{Resources.msg_statut_permet_pas}", Program.AppTitle, MessageBoxButtons.OK, MessageBoxIcon.Information);
          return;
        }

        if (chkInfoSite.Checked)
        {
          MessageBox.Show(Resources.msg_site_informe_pouvez_pas_modif_date_planif, Program.AppTitle, MessageBoxButtons.OK, MessageBoxIcon.Information);
          return;
        }

        // droit de suppression
        if (cmdBlockPave.Tag != null && (int)cmdBlockPave.Tag == 1)
        {
          MessageBox.Show($"{Resources.msg_action_bloquee_service_planif}{Environment.NewLine}{Resources.msg_sup_planif_impossible}", Program.AppTitle, MessageBoxButtons.OK, MessageBoxIcon.Information);
          return;
        }

        // si il y a des modifications
        if (MessageBox.Show(Resources.msg_dde_suppr_planif, Program.AppTitle, MessageBoxButtons.YesNoCancel,
                            MessageBoxIcon.Question, MessageBoxDefaultButton.Button2) != DialogResult.Yes) return;
        // procedure qui supprime l'action de l'IP et qui remet les données cohérentes dans l'action
        SupprimerIP();
        //       gbRefresh = True
        // rafraichissement
        OuvertureEnModification();
      }
      //catch (Exception ex) { MessageBox.Show($"{ex.Message}\r\n\r\n{Resources.Global_dans}{MethodBase.GetCurrentMethod().Name}", Resources.Global_Erreur, MessageBoxButtons.OK, MessageBoxIcon.Exclamation); }
      catch (Exception ex) { Utils.ShowError(ex, $"{MethodBase.GetCurrentMethod().Name} dans {this.Name}"); }

    }
    private void cmdDate4_Click(object sender, System.EventArgs e)
    {
      if (!bDroitVisa && chkVisaArr.Checked)
      {
        MessageBox.Show(Resources.msg_date_arrivee_verif_plus_modifiable, Program.AppTitle, MessageBoxButtons.OK, MessageBoxIcon.Information);
        return;
      }
      iTextBoxDate = 3;
      _curDate = DateTime.MinValue; Calendar1.Value = DateTime.Now;
      Calendar1.Visible = true;
      Calendar1.ShowCalendar(new MouseEventArgs(MouseButtons.Left, 1, MousePosition.X, MousePosition.Y, 0));
    }

    private void cmdSupp4_Click(object sender, System.EventArgs e)
    {
      if (!bDroitVisa && chkVisaArr.Checked)
      {
        MessageBox.Show(Resources.msg_date_arrivee_verif_plus_modifiable, Program.AppTitle, MessageBoxButtons.OK, MessageBoxIcon.Information);
        return;
      }
      txtDateA3.Text = "";
      bModif = true;
    }


    private void cmdDate5_Click(object sender, System.EventArgs e)
    {
      iTextBoxDate = 5;
      _curDate = DateTime.MinValue; Calendar1.Value = DateTime.Now;
      Calendar1.Visible = true;
      Calendar1.ShowCalendar(new MouseEventArgs(MouseButtons.Left, 1, MousePosition.X, MousePosition.Y, 0));
    }
    //Private Sub cmdDate5_Click()
    //  iTextBoxDate = 5
    //  If Calendar1.Visible Then
    //    Calendar1.Visible = False
    //  Else
    //    Calendar1.Visible = True
    //    Calendar1.value = Now
    //  End If
    //End Sub
    //
    /* --------------------------------------------------------------------------------------- */
    private void cmdSupp5_Click(object sender, System.EventArgs e)
    {
      txtDateA5.Text = "";
      bModif = true;
    }
    //Private Sub cmdSupp5_Click()
    //  txtDateA(5) = ""
    //  bModif = True
    //End Sub
    //
    /* --------------------------------------------------------------------------------------- */
    private void PasserStatutAdminF()
    {
      try
      {
        // passage code facture a N
        ModuleData.ExecuteNonQuery($"api_sp_PasserStatutAdminF {MozartParams.NumAction}");
      }
      //catch (Exception ex) { MessageBox.Show($"{ex.Message}\r\n\r\n{Resources.Global_dans}{MethodBase.GetCurrentMethod().Name}", Resources.Global_Erreur, MessageBoxButtons.OK, MessageBoxIcon.Exclamation); }
      catch (Exception ex) { Utils.ShowError(ex, $"{MethodBase.GetCurrentMethod().Name} dans {this.Name}"); }
    }
    //Private Sub PasserStatutAdminF()
    //
    //Dim srs As ADODB.Recordset
    //
    //On Error GoTo handler
    //    
    //  ' passage code facture a N
    //  Set srs = New ADODB.Recordset
    //  srs.Open "api_sp_PasserStatutAdminF " & glNumAction, cnx
    //
    //Exit Sub
    //handler:
    // ShowError "PasserStatutAdminF dans " & Me.Name
    //End Sub
    //
    /* --------------------------------------------------------------------------------------- */
    private void PasserStatutAdminA()
    {
      try
      {
        //    'GREG 20/11/2013
        //    ' SI une action de cession a été créer, l'action de base doit rester NF
        //    ' C'est l'action de facturation qui sera facturée
        int nb = (int)ModuleData.ExecuteScalarInt($"SELECT COUNT(*) FROM TACTCOMP WITH (NOLOCK) WHERE ISNULL(NACTNUMCESSION, 0) <> 0 AND NACTNUM = {MozartParams.NumAction}");
        if (nb > 0)
        {
          MessageBox.Show(Resources.msg_pouvez_pas_facturer_action_en_cession_analytique, Program.AppTitle, MessageBoxButtons.OK, MessageBoxIcon.Information);
          return;
        }

        // passage code facture a N
        ModuleData.ExecuteNonQuery($"api_sp_PasserStatutAdminA {MozartParams.NumAction}");
      }
      //catch (Exception ex) { MessageBox.Show($"{ex.Message}\r\n\r\n{Resources.Global_dans}{MethodBase.GetCurrentMethod().Name}", Resources.Global_Erreur, MessageBoxButtons.OK, MessageBoxIcon.Exclamation); }
      catch (Exception ex) { Utils.ShowError(ex, $"{MethodBase.GetCurrentMethod().Name} dans {this.Name}"); }
    }
    //Private Sub PasserStatutAdminA()
    //
    //Dim srs As ADODB.Recordset
    //Dim rsActComp As ADODB.Recordset
    //On Error GoTo handler
    //    
    //    'GREG 20/11/2013
    //    ' SI une action de cession a été créer, l'action de base doit rester NF
    //    ' C'est l'action de facturation qui sera facturée
    //    Set rsActComp = New ADODB.Recordset
    //    rsActComp.Open "SELECT COUNT(*) FROM TACTCOMP WITH (NOLOCK) " _
    //                & "WHERE ISNULL(NACTNUMCESSION, 0) <> 0 AND NACTNUM = " & glNumAction, cnx
    //    If rsActComp(0) > 0 Then
    //        MsgBox "§Vous ne pouvez pas facturer une action en Cession Analytique !§"
    //        rsActComp.Close
    //        Exit Sub
    //    End If
    //    rsActComp.Close
    //    
    //  ' passage code facture a N
    //  Set srs = New ADODB.Recordset
    //  srs.Open "api_sp_PasserStatutAdminA " & glNumAction, cnx
    //
    //Exit Sub
    //handler:
    // ShowError "PasserStatutAdminA dans " & Me.Name
    //End Sub
    //
    /* --------------------------------------------------------------------------------------- */
    private void SupprimerIP()
    {
      try
      {
        // Suppression de l'action de l'IP
        using (SqlDataReader reader = ModuleData.ExecuteReader($"SELECT NIPLNUM FROM TACT WITH (NOLOCK) WHERE NACTNUM = {MozartParams.NumAction}"))
        {
          if (reader.Read())
            UtilsPlan.AddLogIPL((int)Utils.ZeroIfNull(reader["NIPLNUM"]), "S");
        }

        ModuleData.ExecuteNonQuery($"api_sp_SupprimerActionDeIP {MozartParams.NumAction}");
      }
      //catch (Exception ex) { MessageBox.Show($"{ex.Message}\r\n\r\n{Resources.Global_dans}{MethodBase.GetCurrentMethod().Name}", Resources.Global_Erreur, MessageBoxButtons.OK, MessageBoxIcon.Exclamation); }
      catch (Exception ex) { Utils.ShowError(ex, $"{MethodBase.GetCurrentMethod().Name} dans {this.Name}"); }
    }
    //Private Sub SupprimerIP()
    //
    //Dim srs As ADODB.Recordset
    //
    //On Error GoTo handler
    //  
    //  ' Suppression de l'action de l'IP
    //  Set srs = New ADODB.Recordset
    //  srs.Open "SELECT NIPLNUM FROM TACT WITH (NOLOCK) WHERE NACTNUM = " & glNumAction, cnx
    //  If srs.RecordCount > 0 Then
    //    AddLogIPL ZeroIfNull(srs("NIPLNUM")), "S"
    //  End If
    //  cnx.Execute "api_sp_SupprimerActionDeIP " & glNumAction
    //  
    //Exit Sub
    //handler:
    // ShowError "SupprimerIP dans " & Me.Name
    //End Sub
    //
    /* --------------------------------------------------------------------------------------- */
    private void SupprimerExec()
    {
      try
      {
        // Suppression de l'action de l'IP
        ModuleData.ExecuteNonQuery($"api_sp_SupprimerDateExec {MozartParams.NumAction}");
      }
      //catch (Exception ex) { MessageBox.Show($"{ex.Message}\r\n\r\n{Resources.Global_dans}{MethodBase.GetCurrentMethod().Name}", Resources.Global_Erreur, MessageBoxButtons.OK, MessageBoxIcon.Exclamation); }
      catch (Exception ex) { Utils.ShowError(ex, $"{MethodBase.GetCurrentMethod().Name} dans {this.Name}"); }
    }
    //Private Sub SupprimerExec()
    //
    //Dim srs As ADODB.Recordset
    //
    //On Error GoTo handler
    //
    //  ' Suppression de l'action de l'IP
    //  Set srs = New ADODB.Recordset
    //  srs.Open "api_sp_SupprimerDateExec " & glNumAction, cnx
    //
    //Exit Sub
    //handler:
    // ShowError "SupprimerExec dans " & Me.Name
    //End Sub
    //
    /* --------------------------------------------------------------------------------------- */
    DateTime _curDate = DateTime.MinValue;
    private void Calendar1_CloseUp(object sender, EventArgs e)
    {
      Calendar1.Visible = false;
      if (_curDate == DateTime.MinValue) return;
      try
      {
        // TB SAMSIC CITY SPEC
        if (iTextBoxDate == 0 && iClientNum == 4031 && MozartParams.NomGroupe == "EMALEC" && txtDateA0.Text != Calendar1.Value.ToLongDateString())
        {
          MessageBox.Show($"ATTENTION : vous allez créer ou modifier une date souhaitée sur le client ARGEDIS{Environment.NewLine}" +
                          $"Cette date doit être celle vue avec le site pour la limite d'intervention acceptée par le Directeur du Site.{Environment.NewLine}" +
                          $"Une fois validée avec le site elle ne doit plus être modifiée (calcul de délais). {Environment.NewLine}{Environment.NewLine}" +
                          $"LA DATE SOUHAITEE APPARAIT SUR LE PORTAIL WEB CLIENT", Program.AppTitle, MessageBoxButtons.OK, MessageBoxIcon.Information);
        }
        if (iTextBoxDate == 1 && (chkInfoSite.Checked || txtQui.Text != "") && txtDateA1.Text != Calendar1.Value.ToShortDateString())
        {
          MessageBox.Show(Resources.msg_site_informe_pouvez_pas_modif_date_planif, Program.AppTitle, MessageBoxButtons.OK, MessageBoxIcon.Information);
          return;
        }
        if (iTextBoxDate == 5 && Calendar1.Value < DateTime.Today)
        {
          MessageBox.Show(Resources.msg_choix_date_anterieure_impossible, Program.AppTitle, MessageBoxButtons.OK, MessageBoxIcon.Information);
          return;
        }
        // svg obs si modif date souhaitée
        // ajout dans l'observation de l'action
        if (iTextBoxDate == 0)
        {
          // ajout 11/10/2021 par MC a la demande de SB
          // si en mode creation+ client total => ajout complement facture
          if (iClientNum == 17368 && mstrStatutAction == "C")
          {
            txtObsFac.Text = $"CAMPAGNE ANNEE {DateTime.Now.Year.ToString()}{Environment.NewLine}{txtObsFac.Text}";
          }


          if (txtDateA0.Text != "")
            txtObserv.Text = $"{MozartParams.strUID} {DateTime.Now.ToString("dd/MM/yy HH:mm")} Modification date souhaitée : De " +
                             $"{txtDateA0.Text.Replace("'", "''")} au {Calendar1.Value.ToString().Replace("'", "''")}" +
                             $"{Environment.NewLine}{txtObserv.Text}";
          else
            txtObserv.Text = $"{MozartParams.strUID} {DateTime.Now.ToString("dd/MM/yy HH:mm")} Ajout date souhaitée : La date souhaitée est le " +
                             $"{Calendar1.Value.ToString().Replace("'", "''")}{Environment.NewLine}{txtObserv.Text}";
        }

        ((apiTextBox)this.Controls.Find("txtDateA" + iTextBoxDate, true)[0]).Text = Calendar1.Value.ToShortDateString();

        bModif = true;

        if (iTextBoxDate == 3)
        {
          txtDateA3.Text += $" {DateTime.Now.ToShortTimeString()}";
        }

        //  'test si client KPI, prev
        //  'si date planif > date souhaitée alors message informatif
        if (iTextBoxDate == 1 && bKPIGest_DatePrev && (string)cboPrest.SelectedValue == "P" && Convert.ToDateTime(txtDateA1.Text) > Convert.ToDateTime(txtDateA0.Text))
        {
          MessageBox.Show(Resources.msg_planif_depasse_date_contractuelle, Program.AppTitle, MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
        }

        // dans le cas de la planification, on ouvre le planning ( si c'est la premiere fois)
        // et si c'est un technicien et si on a le droit
        if (iTextBoxDate == 1 && optInter0.Checked)
        {
          bModif = false;
          cmdPlanifier_Click(sender, e);

          ////on ajoute l event de planif
          //CACT_LOG_ETAT_DETAIL oAct_Log_Etat_Adding = new CACT_LOG_ETAT_DETAIL();

          //oAct_Log_Etat_Adding.NID_ACT_LOG_ETAT = 0;
          //oAct_Log_Etat_Adding.NACTNUM = MozartParams.NumAction;
          //oAct_Log_Etat_Adding.CETACOD = "P";
          //oAct_Log_Etat_Adding.NQUICREE = MozartParams.UID;
          //oAct_Log_Etat_Adding.DQUICREE = DateTime.Now;
          //oAct_Log_Etat_Adding.VQUICREE = MozartParams.strUID;

          //oTabAct_Log_Etat.Add(oAct_Log_Etat_Adding);

          //txtObserv.Text = $"{MozartParams.strUID} : Planifiée {DateTime.Now.ToString("dd/MM/yy HH:mm")}{Environment.NewLine}{txtObserv.Text}";
        }

        // dans le cas d'un STT qui a un accès web ou si c'est une prèv
        bool bAux = DetailstravauxUtils.IntervantWithTabletSTF(Utils.BlankIfNull(txtContact.Tag));
        if (iTextBoxDate == 1 && optInter1.Checked && ((string)cboPrest.SelectedValue == "P" || bAux))
        {
          bModif = false;
          cmdPlanifier_Click(sender, e);
          if (bAux && DetailstravauxUtils.ExistsContratOnIntervenant(txtContact.Tag.ToString(), MozartParams.NumAction))
          {
            MessageBox.Show(Resources.msg_stt_equipe_tablet_penser_creer_contrat_stt, Program.AppTitle, MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
          }
        }

        if (iTextBoxDate == 2)
        {
          txtDateA2.Text += $" {DateTime.Now.ToShortTimeString()}";
          txtObserv.Text = $"{MozartParams.strUID} : {Resources.msg_date_exec_saisie_le} {DateTime.Now.ToString("dd/MM/yy HH:mm")}{Environment.NewLine}{txtObserv.Text}";

          // si prestation retour qualité alors on coche automatiquement validation facture
          if ((string)cboPrest.SelectedValue == "K") chkValidFac.Checked = true;
        }

        if (iTextBoxDate == 4 || iTextBoxDate == 5)
          ((apiTextBox)this.Controls.Find("txtDateA" + iTextBoxDate, true)[0]).Text = Calendar1.Value.ToShortDateString();
      }
      //catch (Exception ex) { MessageBox.Show($"{ex.Message}\r\n\r\n{Resources.Global_dans}{MethodBase.GetCurrentMethod().Name}", Resources.Global_Erreur, MessageBoxButtons.OK, MessageBoxIcon.Exclamation); }
      catch (Exception ex) { Utils.ShowError(ex, $"{MethodBase.GetCurrentMethod().Name} dans {this.Name}"); }
    }

    private void Calendar1_ValueChanged(object sender, EventArgs e)
    {
      if (Calendar1.Visible) _curDate = Calendar1.Value;
    }

    private void cmdBor_Click(object sender, System.EventArgs e)
    {
      new frmBordereauPrix
      {
        Numclient = iClientNum
      }.ShowDialog();

      // rafraichir l'affichage
      OuvertureEnModification();
    }

    private void cmdALC_Click(object sender, System.EventArgs e)
    {
      // remplir combo filiale
      Utils.InitComboBox(cboFiliale, $"SELECT NSOCIETEID, VSOCIETENOM  FROM TSOCIETE WHERE VSOCIETEACTIF='O' and VSOCIETENOM <> '{MozartParams.NomSociete}'" +
                                     $" and  VSOCIETENOM not in ('FITELEC','ALC','EMALECBELGIQUE', 'SAMSICROMANIA', 'EMALECDEV','SAMSICITALIA') ORDER BY VSOCIETENOM", "", "", true);
      frameFiliale.Visible = true;
      cboFiliale.Visible = true;
      //  ' elle n'est pas dans la frame car sinon problème
    }

    private void cmdCopieFiliale_Click(object sender, System.EventArgs e)
    {
      try
      {
        switch ((sender as Button).Name)
        {
          case "cmdCopieFiliale0": // nouveau cas de gestion :  nouveau programme copie action
            if (cboFiliale.Text == "")
            {
              MessageBox.Show("Vous devez sélectionner une filiale de destination", Program.AppTitle, MessageBoxButtons.OK, MessageBoxIcon.Information);
              return;
            }
            cmdCopieActionFiliale(cboFiliale.Text);
            break;
          case "cmdCopieFiliale6": // gestion du bouton fermer
            cboFiliale.Visible = frameFiliale.Visible = false;
            return;
        }

        cboFiliale.Visible = frameFiliale.Visible = false;
      }
      //catch (Exception ex) { MessageBox.Show($"{ex.Message}\r\n\r\n{Resources.Global_dans}{MethodBase.GetCurrentMethod().Name}", Resources.Global_Erreur, MessageBoxButtons.OK, MessageBoxIcon.Exclamation); }
      catch (Exception ex) { Utils.ShowError(ex, $"{MethodBase.GetCurrentMethod().Name} dans {this.Name}"); }
    }
    //Private Sub cmdCopieFiliale_Click(Index As Integer)
    //
    //  On Error GoTo handler
    //
    //  
    //  
    //  Select Case Index
    //    Case 0
    //      ' nouveau cas de gestion :  nouveau programme copie action
    //'      cmdCopieActionFiliale ("EQUIPAGE")
    //      If cboFiliale.Text = "" Then
    //        MsgBox "Vous devez sélectionner une filiale de destination", vbInformation
    //        Exit Sub
    //      End If
    //      cmdCopieActionFiliale (cboFiliale.Text)
    //
    //
    //'    Case 1
    //'      ' création de la demande dans la filiale ' sens EMALEC >> Filiale
    //'      If gstrNomSociete <> "EMALEC" Then
    //'        MsgBox "Vous devez être sur un Mozart EMALEC pour pouvoir copier une action sur une filiale", vbInformation
    //'        Exit Sub
    //'      End If
    //'      cnx.Execute "Api_sp_CreationDIActionEmalecESPAGNE " & glNumAction
    //'    Case 2
    //'      ' création de la demande dans la filiale ' sens EMALEC >> Filiale
    //'      If gstrNomSociete <> "EMALEC" Then
    //'        MsgBox "Vous devez être sur un Mozart EMALEC pour pouvoir copier une action sur une filiale", vbInformation
    //'        Exit Sub
    //'      End If
    //'      cnx.Execute "Api_sp_CreationDIActionEmalecIDF " & glNumAction
    //'    Case 3
    //'      ' création de la demande dans la filiale ' sens EMALEC >> Filiale
    //'      If gstrNomSociete <> "EMALEC" Then
    //'        MsgBox "Vous devez être sur un Mozart EMALEC pour pouvoir copier une action sur une filiale", vbInformation
    //'        Exit Sub
    //'      End If
    //'      cnx.Execute "Api_sp_CreationDIActionEmalecLuxembourg " & glNumAction
    //'    Case 4
    //'      ' création de la demande dans la filiale ' sens EMALEC >> Filiale
    //'      If gstrNomSociete <> "EMALEC" Then
    //'        MsgBox "Vous devez être sur un Mozart EMALEC pour pouvoir copier une action sur une filiale", vbInformation
    //'        Exit Sub
    //'      End If
    //'      cnx.Execute "Api_sp_CreationDIActionEmalecFaciliteam " & glNumAction
    //'    Case 5
    //'      ' création d'une demande d'une filiale chez EMALEC      ' sens FILIALE >> EMALEC
    //'      If gstrNomSociete = "EMALEC" Then Exit Sub
    //'
    //'      ' Modification ou création de l'action et de la Di si necessaire
    //'      cnx.Execute "Api_sp_CreationDIActionFilialeVersEmalec " & glNumAction
    //    Case 6
    //      ' gestion du bouton fermer
    //      frameFiliale.Visible = False
    //      cboFiliale.Visible = False
    //      Exit Sub
    //  End Select
    //  
    //  frameFiliale.Visible = False
    //  cboFiliale.Visible = False
    //  
    //  ' rafraichir l'affichage
    //  'OuvertureEnModification
    //
    //Exit Sub
    //Resume
    //handler:
    //  Screen.MousePointer = vbDefault
    //  ShowError "cmdCopieFiliale_Click dans " & Me.Name
    //End Sub
    //
    /* --------------------------------------------------------------------------------------- */
    private void cmdCopieActionFiliale(string sFilialeDest)
    {
      try
      {
        // lien entre les sociétés
        // création d'une demande d'une filiale vers une filiale
        //
        // recherche si action déjà copié sur la filiale
        if (ActionLie())
        {
          MessageBox.Show($"Action déjà copiée.{Environment.NewLine}Copie impossible.", Program.AppTitle, MessageBoxButtons.OK, MessageBoxIcon.Information);
          return;
        }

        // recherche si un contrat sous-traitant existe sur l'action (obligatoire) ou une demande de devis Sous-traitant
        // ou un OG
        if (cmdContrat.BackColor != MozartColors.ColorH80FFFF && cmdCST.BackColor != MozartColors.ColorH80FFFF && cmdCSP.BackColor != MozartColors.ColorH80FFFF
            && cmdDevis.BackColor != MozartColors.ColorH80FFFF && cmdOGar.BackColor != MozartColors.ColorH80FFFF)
        {
          MessageBox.Show($"Pas de contrat ou de demande de devis Sous-traitant sur l'action en cours{Environment.NewLine}Copie impossible.{Environment.NewLine}(Voir le paramétrage avec votre responsable)", Program.AppTitle, MessageBoxButtons.OK, MessageBoxIcon.Information);
          return;
        }

        // recherche si le client en cours est lié dans la filiale sélectionnée
        if (!ClientLie(sFilialeDest))
        {
          MessageBox.Show($"Pas de client lié pour ce client dans la filiale {sFilialeDest}{Environment.NewLine}Copie impossible.{Environment.NewLine}(Voir le paramétrage avec votre responsable)", Program.AppTitle, MessageBoxButtons.OK, MessageBoxIcon.Information);
          return;
        }

        // recherche si le site en cours est lié dans la filiale sélectionnée
        if (!SiteLie(sFilialeDest))
        {
          MessageBox.Show($"Pas de site lié pour ce site sur le client lié dans la filiale {sFilialeDest}{Environment.NewLine}Copie impossible.{Environment.NewLine}(Voir le paramétrage avec votre responsable)", Program.AppTitle, MessageBoxButtons.OK, MessageBoxIcon.Information);
          return;
        }

        // si gamme présente dans l'action d'origine, recherche si gamme lié existe sur le client dans la filiale
        if (cboGamme.Text != "" && !RechercheGammeLie(sFilialeDest))
        {
          MessageBox.Show($"Pas de gamme liée pour la gamme encours sur le client lié dans la filiale {sFilialeDest}{Environment.NewLine}Copie impossible.{Environment.NewLine}(Voir le paramétrage avec votre responsable)", Program.AppTitle, MessageBoxButtons.OK, MessageBoxIcon.Information);
          return;
        }

        // Modification ou création de l'action et de la Di si necessaire
        int NumActionDestination;
        using (SqlDataReader reader = ModuleData.ExecuteReader($"Api_sp_CreationDIActionFiliale {MozartParams.NumAction},'{sFilialeDest}'"))
        {
          reader.Read();
          NumActionDestination = (int)Utils.ZeroIfNull(reader[0]);
        }

        // copie du contrat en pdf sur l'action liée
        if (cmdContrat.BackColor == MozartColors.ColorH80FFFF || cmdCST.BackColor == MozartColors.ColorH80FFFF || cmdCSP.BackColor == MozartColors.ColorH80FFFF)
          copierContratSurDocFiliale(sFilialeDest, NumActionDestination);

        if (cmdDevis.BackColor == MozartColors.ColorH80FFFF)
          // copie du contrat en pdf sur l'action liée
          copierDemandeDevisSurDocFiliale(sFilialeDest, NumActionDestination);

        // rafraichir l'affichage
        OuvertureEnModification();
      }
      //catch (Exception ex) { MessageBox.Show($"{ex.Message}\r\n\r\n{Resources.Global_dans}{MethodBase.GetCurrentMethod().Name}", Resources.Global_Erreur, MessageBoxButtons.OK, MessageBoxIcon.Exclamation); }
      catch (Exception ex) { Utils.ShowError(ex, $"{MethodBase.GetCurrentMethod().Name} dans {this.Name}"); }
    }
    //Private Sub cmdCopieActionFiliale(ByVal sFilialeDest As String)
    //
    //  Dim NumActionDestination As Long
    //  Dim rsa As New ADODB.Recordset
    //
    //  On Error GoTo handler
    //
    //  ' lien entre les sociétés
    //  ' création d'une demande d'une filiale vers une filiale
    //
    //  ' recherche si action déjà copié sur la filiale
    //  If ActionLie Then
    //    MsgBox "Action déjà copiée." & vbCrLf & "Copie impossible."
    //    Exit Sub
    //  End If
    //
    //  ' recherche si un contrat sous-traitant existe sur l'action (obligatoire) ou une demande de devis Sous-traitant
    //  ' ou un OG
    //  If cmdContrat.BackColor <> &H80FFFF And cmdCST.BackColor <> &H80FFFF And cmdCSP.BackColor <> &H80FFFF And cmdDevis.BackColor <> &H80FFFF And cmdOGar.BackColor <> &H80FFFF Then
    //    MsgBox "Pas de contrat ou de demande de devis Sous-traitant sur l'action en cours" & vbCrLf & "Copie impossible." & vbCrLf & "(Voir le paramétrage avec votre responsable)"
    //    Exit Sub
    //  End If
    //  
    //  ' recherche si le client en cours est lié dans la filiale sélectionnée
    //  If Not ClientLie(sFilialeDest) Then
    //    MsgBox "Pas de client lié pour ce client dans la filiale " & sFilialeDest & vbCrLf & "Copie impossible." & vbCrLf & "(Voir le paramétrage avec votre responsable)"
    //    Exit Sub
    //  End If
    //  
    //  ' recherche si le site en cours est lié dans la filiale sélectionnée
    //  If Not SiteLie(sFilialeDest) Then
    //    MsgBox "Pas de site lié pour ce site sur le client lié dans la filiale " & sFilialeDest & vbCrLf & "Copie impossible." & vbCrLf & "(Voir le paramétrage avec votre responsable)"
    //    Exit Sub
    //  End If
    //  
    //  ' si gamme présente dans l'action d'origine, recherche si gamme lié existe sur le client dans la filiale
    //  If cboGamme.Text <> "" Then
    //    If Not RechercheGammeLie() Then
    //      MsgBox "Pas de gamme liée pour la gamme encours sur le client lié dans la filiale " & sFilialeDest & vbCrLf & "Copie impossible." & vbCrLf & "(Voir le paramétrage avec votre responsable)"
    //      Exit Sub
    //    End If
    //  End If
    //
    //  ' Modification ou création de l'action et de la Di si necessaire
    //  rsa.Open "Api_sp_CreationDIActionFiliale " & glNumAction & ",'" & sFilialeDest & "'", cnx
    //  NumActionDestination = rsa(0)
    //  rsa.Close
    //
    //  ' copie du contrat en pdf sur l'action liée
    //  If cmdContrat.BackColor = &H80FFFF Or cmdCST.BackColor = &H80FFFF Or cmdCSP.BackColor = &H80FFFF Then
    //    copierContratSurDocFiliale sFilialeDest, NumActionDestination
    //  End If
    //  
    //  If cmdDevis.BackColor = &H80FFFF Then
    //    ' copie du contrat en pdf sur l'action liée
    //    copierDemandeDevisSurDocFiliale sFilialeDest, NumActionDestination
    //  End If
    //  
    //  If cmdOGar.BackColor = &H80FFFF Then
    //    ' copie du contrat en pdf sur l'action liée
    //  '  copierOGSurDocFiliale sFilialeDest, NumActionDestination
    //  End If
    //  
    //  ' rafraichir l'affichage
    //  OuvertureEnModification
    //
    //Exit Sub
    //Resume
    //handler:
    //  Screen.MousePointer = vbDefault
    //  ShowError "cmdEmalec_Click dans " & Me.Name
    //End Sub
    //
    /* --------------------------------------------------------------------------------------- */
    private void copierContratSurDocFiliale(string sFilialeDest, int NumActionDestination)
    {
      try
      {
        // recherche des infos
        using (SqlDataReader reader = ModuleData.ExecuteReader($"select NCSTNUM from TCST WHERE NACTNUM = {MozartParams.NumAction}"))
        {
          if (!reader.Read()) return;

          new frmMainReport
          {
            bLaunchByProcessStart = false,
            sTypeReport = "TContratSousTraitance",
            sIdentifiant = $"{MozartParams.NumAction}|{Utils.ZeroIfNull(reader["NCSTNUM"])}",
            InfosMail = $"TINT|NINTNUM|0",
            sNomSociete = MozartParams.NomSociete,
            sLangue = "FR",
            sOption = "PDF",
            strType = "CS",
            numAction = MozartParams.NumAction
          }.ShowDialog();

          // Mettre le PDF dans le répertoire des docs de la filiale
          string Nomfichier = $"{NumActionDestination}_{DateTime.Now.ToString("yyyyddMMHHmmss")}.pdf";
          File.Copy($@"{MozartParams.CheminUtilisateurMozart}PDF\{MozartParams.NumAction}.pdf", $"{DetailstravauxUtils.RechercheParamBySociete("REP_PHOTOS_ACT", sFilialeDest)}{Nomfichier}", true);

          // enregistrement dans la table des documents
          ModuleData.ExecuteNonQuery($"INSERT INTO dbo.TIMAC (NACTNUM, VIMAGE, VFICHIER, CFORMAT, VTYPE, CVUEWEB, VTYPEDEST, NTYPEDOC) " +
                                     $" VALUES ({NumActionDestination},'Contrat','{Nomfichier}','PDF','IMAGE','N','I',6)");
        }
      }
      //catch (Exception ex) { MessageBox.Show($"{ex.Message}\r\n\r\n{Resources.Global_dans}{MethodBase.GetCurrentMethod().Name}", Resources.Global_Erreur, MessageBoxButtons.OK, MessageBoxIcon.Exclamation); }
      catch (Exception ex) { Utils.ShowError(ex, $"{MethodBase.GetCurrentMethod().Name} dans {this.Name}"); }
    }
    //Private Sub copierContratSurDocFiliale(ByVal sFilialeDest As String, ByVal NumActionDestination As Long)
    //
    //Dim rsa As New ADODB.Recordset
    //Dim fs As New FileSystemObject
    //Dim sSQL As String
    //
    //  ' recherche des infos
    //  rsa.Open "select NCSTNUM from TCST WHERE NACTNUM = " & glNumAction, cnx
    //  If rsa.EOF Then Exit Sub
    //
    //  On Error GoTo handler
    //  
    //  ShellAndWait gstrRepertoireReports & "ReportEmalec.Net.exe " & """TContratSousTraitance;" & glNumAction & "|" & rsa("NCSTNUM") & ";TINT|NINTNUM|0;" & gstrNomSociete & ";FR;PDF;CS;" & glNumAction & "", vbNormalFocus
    //
    //  ' Mettre le PDF dans le répertoire des docs de la filiale
    //  Dim Nomfichier As String ' Nom du fichier à
    //  Nomfichier = NumActionDestination & "_" & Format(Now, "yyyyddmmhhmmss") & ".pdf"
    //  
    //  fs.CopyFile gstrCheminUtilisateur & "\Mozart\PDF\" & glNumAction & ".pdf", RechercheParamBySociete("REP_PHOTOS_ACT", sFilialeDest) & Nomfichier, True
    //
    //  ' enregistrement dans la table des documents
    //  sSQL = "INSERT INTO dbo.TIMAC (NACTNUM, VIMAGE, VFICHIER, CFORMAT, VTYPE, CVUEWEB, VTYPEDEST, NTYPEDOC) "
    //  sSQL = sSQL & "VALUES (" & NumActionDestination & ",'Contrat','" & Nomfichier & "','PDF','IMAGE','N','I',6)"
    //  cnx.Execute sSQL
    //  
    //Exit Sub
    //Resume
    //handler:
    //  Screen.MousePointer = vbDefault
    //  ShowError "copierContratSurDocFiliale dans " & Me.Name
    //End Sub
    //
    /* --------------------------------------------------------------------------------------- */
    private void copierDemandeDevisSurDocFiliale(string sFilialeDest, int NumActionDestination)
    {
      try
      {
        // recherche des infos
        using (SqlDataReader reader = ModuleData.ExecuteReader($"select NDSTNUM from TDST WHERE NACTNUM = {MozartParams.NumAction}"))
        {
          if (!reader.Read()) return;

          new frmMainReport
          {
            bLaunchByProcessStart = false,
            sTypeReport = "TDemandeDevisST",
            sIdentifiant = $"{MozartParams.NumAction}|{Utils.ZeroIfNull(reader["NDSTNUM"])}",
            InfosMail = $"TINT|NINTNUM|0",
            sNomSociete = MozartParams.NomSociete,
            sLangue = "FR",
            sOption = "PDF",
            strType = "DS",
            numAction = MozartParams.NumAction
          }.ShowDialog();

          // Mettre le PDF dans le répertoire des docs de la filiale
          string Nomfichier = $"{NumActionDestination}_{DateTime.Now.ToString("yyyyddMMHHmmss")}.pdf";
          File.Copy($@"{MozartParams.CheminUtilisateurMozart}PDF\{MozartParams.NumAction}.pdf", $"{DetailstravauxUtils.RechercheParamBySociete("REP_PHOTOS_ACT", sFilialeDest)}{Nomfichier}", true);

          // enregistrement dans la table des documents
          ModuleData.ExecuteNonQuery($"INSERT INTO dbo.TIMAC (NACTNUM, VIMAGE, VFICHIER, CFORMAT, VTYPE, CVUEWEB, VTYPEDEST, NTYPEDOC) " +
                                     $" VALUES ({NumActionDestination},'Contrat','{Nomfichier}','PDF','IMAGE','N','I',6)");
        }
      }
      //catch (Exception ex) { MessageBox.Show($"{ex.Message}\r\n\r\n{Resources.Global_dans}{MethodBase.GetCurrentMethod().Name}", Resources.Global_Erreur, MessageBoxButtons.OK, MessageBoxIcon.Exclamation); }
      catch (Exception ex) { Utils.ShowError(ex, $"{MethodBase.GetCurrentMethod().Name} dans {this.Name}"); }
    }
    //Private Sub copierDemandeDevisSurDocFiliale(ByVal sFilialeDest As String, ByVal NumActionDestination As Long)
    //
    //Dim rsa As New ADODB.Recordset
    //Dim fs As New FileSystemObject
    //Dim sSQL As String
    //
    //  ' recherche des infos
    //  rsa.Open "select NDSTNUM from TDST WHERE NACTNUM = " & glNumAction, cnx
    //  If rsa.EOF Then Exit Sub
    //
    //  On Error GoTo handler
    //  
    // ' ShellAndWait gstrRepertoireReports & "ReportEmalec.Net.exe " & """TContratSousTraitance;" & glNumAction & "|" & rsa("NCSTNUM") & ";TINT|NINTNUM|0;" & gstrNomSociete & ";FR;PDF;CS;" & glNumAction & "", vbNormalFocus
    //  ShellAndWait gstrRepertoireReports & "ReportEmalec.Net.exe " & """TDemandeDevisST;" & glNumAction & "|" & rsa("NDSTNUM") & ";TINT|NINTNUM|0;" & gstrNomSociete & ";FR;PDF;DS;" & glNumAction & "", vbNormalFocus
    // '  OpenNetForm gstrRepertoireReports & "ReportEmalec.Net.exe " & "TDemandeDevisST;" & glNumAction & "|" & rsa("NDSTNUM") & ";TINT|NINTNUM|0;" & gstrNomSociete & ";FR;PDF;DS;" & glNumAction, vbNormalFocus
    //
    //  ' Mettre le PDF dans le répertoire des docs de la filiale
    //  Dim Nomfichier As String ' Nom du fichier à
    //  Nomfichier = NumActionDestination & "_" & Format(Now, "yyyyddmmhhmmss") & ".pdf"
    //  
    //  fs.CopyFile gstrCheminUtilisateur & "\Mozart\PDF\" & glNumAction & ".pdf", RechercheParamBySociete("REP_PHOTOS_ACT", sFilialeDest) & Nomfichier, True
    //
    //  ' enregistrement dans la table des documents
    //  sSQL = "INSERT INTO dbo.TIMAC (NACTNUM, VIMAGE, VFICHIER, CFORMAT, VTYPE, CVUEWEB, VTYPEDEST, NTYPEDOC) "
    //  sSQL = sSQL & "VALUES (" & NumActionDestination & ",'Contrat','" & Nomfichier & "','PDF','IMAGE','N','I',6)"
    //  cnx.Execute sSQL
    //  
    //Exit Sub
    //Resume
    //handler:
    //  Screen.MousePointer = vbDefault
    //  ShowError "copierDemandeDevisSurDocFiliale dans " & Me.Name
    //End Sub
    //
    /* --------------------------------------------------------------------------------------- */
    private void cmdInfoSite_Click(object sender, System.EventArgs e)
    {
      new frmSaisieInfos
      {
        mstrTypeNote = "INFO_SITE",
        miCleTable = iSiteNum
      }.ShowDialog();
    }

    private void CmdDS_Click(object sender, System.EventArgs e)
    {
      new frmDetailsSite
      {
        mstrStatut = "M",
        miNumSite = iSiteNum,
        miNumClient = iClientNum
      }.ShowDialog();
    }

    private void CmdAnnule_Click(object sender, System.EventArgs e)
    {
      txtWeb.Text = "";
      FrameWeb.Visible = false;
    }

    private void cmdValide_Click(object sender, System.EventArgs e)
    {
      // enregistrement dans la table des réponses web
      ModuleData.ExecuteNonQuery($"insert into TWREP (DWREPDAT,NACTNUM,NPERNUM,VWREPMESS) values( getdate(), {MozartParams.NumAction},{MozartParams.UID},'{txtWeb.Text.Replace("'", "''")}')");

      // ajout dans l'observation de l'action
      txtObserv.Text = $"{MozartParams.strUID} réponse web le {DateTime.Now.ToString("dd/MM/yy HH:mm")} : {txtWeb.Text.Replace("'", "''")}" +
                       $"{Environment.NewLine}{txtObserv.Text}";

      // enregistrement de la date de suivi client
      // demande Bouyssi le 21/10/24
      ModuleData.ExecuteNonQuery($"Update tactcomp set dactmailcli = GetDate() where nactnum={MozartParams.NumAction}");

      // on envoi une copie de l a réponse par mail par mail au client.
      ModuleData.ExecuteNonQuery($"exec api_sp_SendMailRepWeb {MozartParams.NumAction}");

      FrameWeb.Visible = false;
    }

    private void cmdWeb_Click(object sender, System.EventArgs e)
    {
      if (MessageBox.Show(Resources.msg_Att_allez_rediger_message_sur_web_sur_action_continuer, Program.AppTitle, MessageBoxButtons.YesNo,
                          MessageBoxIcon.Question, MessageBoxDefaultButton.Button2) != DialogResult.Yes) return;

      // test si on est en train de valider un message web
      if (txtDeciWeb.Visible)
      {
        MessageBox.Show(Resources.msg_enreg_msg_avant_repondre, Program.AppTitle, MessageBoxButtons.OK, MessageBoxIcon.Information);
        return;
      }

      txtWeb.Text = "";
      FrameWeb.Top = 8000 / 15;
      FrameWeb.Left = 3600 / 15;
      FrameWeb.Visible = true;
    }

    private void cmdFermer_Click(object sender, System.EventArgs e)
    {
      Close();
    }
    private void frmDetailstravaux_FormClosing(object sender, FormClosingEventArgs e)
    {
      // si il y a des modification
      if (bModif && cmdEnregistrer.Enabled)
      {
        DialogResult res = MessageBox.Show(Resources.msgConfirm_enregistrerModif, Program.AppTitle, MessageBoxButtons.YesNoCancel,
                                           MessageBoxIcon.Question, MessageBoxDefaultButton.Button2);
        if (DialogResult.Cancel == res) { e.Cancel = true; return; }
        if (DialogResult.Yes == res)
          cmdEnregistrer_Click(sender, e);
      }
    }

    private void cmdRechercher_Click(object sender, System.EventArgs e)
    {
      try
      {
        // si le technicien est l'administrateur
        // alors on bloque l'accès à la modif car on est en etat a planifier manuellement
        if (optInter0.Checked && Utils.BlankIfNull(txtInter.Tag) == "10")
        {
          MessageBox.Show(Resources.msg_pour_modif_intervenant_passer_par_planning, Program.AppTitle, MessageBoxButtons.OK, MessageBoxIcon.Information);
          return;
        }

        // selon le cas, affichage de la liste des techs ou de la liste des ST
        // si le statut est 'exécuté' ou plus, pas de modification possible
        if ((string)cboEtat.SelectedValue == "E")
        {
          MessageBox.Show($"{Resources.msg_modif_intervenant_impossible}{Environment.NewLine}{Resources.msg_statut_permet_pas}", Program.AppTitle, MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
          return;
        }

        // si le statut est 'Planifié', pas de modification possible
        if ((string)cboEtat.SelectedValue == "P")
        {
          MessageBox.Show(Resources.msg_sup_planif_avant_change_intervenant, Program.AppTitle, MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
          return;
        }

        if (Utils.BlankIfNull(cmdDdeStock.Tag) == "Personnel")
        {
          MessageBox.Show($"{Resources.msg_demande_stock_dest_existe}'{txtInter.Text}'.{Environment.NewLine}" +
                          $"{Resources.msg_verifier_consequences_cas_changement_tech}", Program.AppTitle, MessageBoxButtons.OK, MessageBoxIcon.Information);
        }

        if (optInter1.Checked || optInter2.Checked)
        {// ST
          if ((optInter1.Checked && ModuleMain.bAccesBouton(optInter1.HelpContextID.ToString()) == 0) ||
              (optInter2.Checked && ModuleMain.bAccesBouton(optInter2.HelpContextID.ToString()) == 0))
          {
            MessageBox.Show(Resources.msg_pas_acces_aux_stt, Program.AppTitle, MessageBoxButtons.OK, MessageBoxIcon.Information);
            return;
          }

          // affichage de l'écran de recherche du ST
          // si preventif, uniquement les st qualifiés
          //    
          // 23/03/2016 : Récupérer le pays pour la recherche STT
          frmRechercheST frm = new frmRechercheST();
          using (SqlDataReader reader = ModuleData.ExecuteReader($"select VSITPAYS from TSIT where NSITNUM={iSiteNum}"))
          {
            if (reader.Read())
              frm.mstrPays = Utils.BlankIfNull(reader["VSITPAYS"]);
          }
          frm.mstrStatut = (string)cboPrest.SelectedValue == "P" ? "PREV" : "SDR";// preventif ou standard
          frm.mstrType = optInter2.Checked ? "INS" : "ST";// INS : Installateur et ST : Sous traitant Maintenance

          frm.ShowDialog();

          miSoustraitant = frm.miSousTraitant;
          miContact = frm.miContact;
          mstrTel = frm.mstrTel;
          mstrPor = frm.mstrPor;
          mstrTelAstr = frm.mstrTelAstr;

          // retour avec un numéro de ST
          if (miSoustraitant != 0)
          {
            txtInter.Tag = miSoustraitant;
            txtContact.Tag = miContact;
            txtInter.Text = frm.msST;
            txtContact.Text = frm.msContact;
            txtFixe.Text = mstrTel;
            txtPort.Text = mstrPor;
            txtTelAstr.Text = mstrTelAstr;
          }
        }
        else if (optInter3.Checked)
        {// sous traitant installation sous garantie / concurrent
          if (optInter3.Checked && ModuleMain.bAccesBouton(optInter3.HelpContextID.ToString()) == 0)
          {
            MessageBox.Show(Resources.msg_pas_acces_aux_stt, Program.AppTitle, MessageBoxButtons.OK, MessageBoxIcon.Information);
            return;
          }

          // 23/03/2016 : Récupérer le pays pour la recherche STT
          frmRechercheST frm = new frmRechercheST();
          using (SqlDataReader reader = ModuleData.ExecuteReader($"select VSITPAYS from TSIT where NSITNUM={iSiteNum}"))
          {
            if (reader.Read())
              frm.mstrPays = Utils.BlankIfNull(reader["VSITPAYS"]);
          }
          frm.mstrStatut = "SDR";
          frm.mstrType = "GAR";
          frm.miNumSiteSTGAR = iSiteNum;

          frm.ShowDialog();

          miSoustraitant = frm.miSousTraitant;
          miContact = frm.miContact;
          mstrTel = frm.mstrTel;
          mstrPor = frm.mstrPor;
          mstrTelAstr = frm.mstrTelAstr;

          // retour avec un numéro de ST
          if (miSoustraitant != 0)
          {
            txtInter.Tag = miSoustraitant;
            txtContact.Tag = miContact;
            txtInter.Text = frm.msST;
            txtContact.Text = frm.msContact;
            txtFixe.Text = mstrTel;
            txtPort.Text = mstrPor;
            txtTelAstr.Text = mstrTelAstr;
          }
        }
        else
        {
          // Ouvrir une liste de recherche du tech
          // si coche acces liste tech sur site
          // modif mc le 25/05/2018
          frmApiRecherche frm = new frmApiRecherche(MozartDatabase.cnxMozart);
          //if (ModuleMain.bAccesBouton("588") == 1)
          //  frm.msSql = $"select TPERPOSTE.NPERNUM, TPER.VPERNOM + ' ' + TPER.VPERPRE Personnel, TPER.VPERVIL Ville from TPERPOSTE inner join" +
          //              $" tper on tper.npernum = tperposte.npernum and tper.cperactif = 'O' and   (DPERSOR IS NULL OR DPERSOR > getdate()) and tper.vsociete = APP_NAME()" +
          //              $" Where tperposte.NSITNUM = {iSiteNum}";
          //else
          frm.msSql = "SELECT NPERNUM, VPERNOM + ' ' + VPERPRE Personnel, VPERVIL Ville from TPER WITH (NOLOCK) WHERE CPERACTIF='O'" +
                      " AND BUTILISATEUR=0 AND VSOCIETE = App_Name() ORDER BY VPERNOM, VPERPRE";
          frm.msType = "TECH";
          frm.ShowDialog();

          if (frm.msRetour != "")
          {
            txtInter.Text = frm.msRetour;
            txtInter.Tag = (int)frm.mlItemData;
          }

          // si personne = CA ou BE ou CT ou AA et chantier alors on selectionne la fiche CHAFF ou BE automatiquement
          if (bNCANChantier)
          {
            string sTypePer = DetailstravauxUtils.RechercheFonctionByPers(optInter0.Checked && txtInter.Tag != null ? (int)txtInter.Tag : 0);
            if (sTypePer == "AS" || sTypePer == "FA")
            {
              txtduree.Text = "";
              txtduree.BackColor = Color.White;
              txtduree.ReadOnly = false;
            }
            else
            {
              txtduree.Text = "";
              txtduree.BackColor = Color.Yellow;
              txtduree.ReadOnly = true;
            }

            LoadHRChantier();
          }

          //on coche en auto attente si etude devis exists
          SetVisibleChkDevisAttenteCheckBox();

        }
      }
      //catch (Exception ex) { MessageBox.Show($"{ex.Message}\r\n\r\n{Resources.Global_dans}{MethodBase.GetCurrentMethod().Name}", Resources.Global_Erreur, MessageBoxButtons.OK, MessageBoxIcon.Exclamation); }
      catch (Exception ex) { Utils.ShowError(ex, $"{MethodBase.GetCurrentMethod().Name} dans {this.Name}"); }
    }

    private void cmddocSTT_Click(object sender, System.EventArgs e)
    {
      try
      {
        if (txtInter.Text == "") return;

        if (Utils.BlankIfNull(lblInter.Tag) == "T")
        {
          new frmStockVehTech
          {
            miTech = (long)(int)txtInter.Tag,
            mvTech = txtInter.Text
          }.ShowDialog();
        }
        else
        {
          using (SqlDataReader reader = ModuleData.ExecuteReader($"SELECT NSTFGRPNUM from TSTF WHERE NSTFNUM = {txtInter.Tag}"))
          {
            if (reader.Read())
            {
              new frmGestDocAdminSTF
              {
                miStfGrpNnum = (long)Utils.ZeroIfNull(reader[0]),
                mstrNom = txtInter.Text
              }.ShowDialog();
            }
          }
        }
      }
      //catch (Exception ex) { MessageBox.Show($"{ex.Message}\r\n\r\n{Resources.Global_dans}{MethodBase.GetCurrentMethod().Name}", Resources.Global_Erreur, MessageBoxButtons.OK, MessageBoxIcon.Exclamation); }
      catch (Exception ex) { Utils.ShowError(ex, $"{MethodBase.GetCurrentMethod().Name} dans {this.Name}"); }
    }

    private void cmdDate1_Click(object sender, System.EventArgs e)
    {
      // uniqument en modification
      if (mstrStatutAction != "C")
      {
        if ((string)cboPrest.SelectedValue == "P" && bKPIGest_DatePrev && !GetDroitModifDateSouhaitee())
        {
          MessageBox.Show($"{Resources.msg_non_autorise_modif_date}.{Environment.NewLine}{Resources.msg_demande_resp_hierachique}.", Program.AppTitle, MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
          return;
        }
      }

      iTextBoxDate = 0;
      _curDate = DateTime.MinValue; Calendar1.Value = DateTime.Now;
      Calendar1.Visible = true;
      Calendar1.ShowCalendar(new MouseEventArgs(MouseButtons.Left, 1, MousePosition.X, MousePosition.Y, 0));
    }

    private bool GetDroitModifDateSouhaitee()
    {
      // -          chargé d'affaires adjoints et  leurs supérieurs hiérarchiques :
      // charge D 'affaire adjoint défini sur le compte analytique du client  ou tous les chargés d affaires adjoint ? ' tous les chaffs adjoints
      // supérieurs hiérarchique = Chaff, chef de groupe et chef de service ? ' oui
      using (SqlDataReader reader = ModuleData.ExecuteReader($"EXEC [api_sp_GetDroitModifDateSouhaiteeKPI]"))
      {
        while (reader.Read())
        {
          if (Utils.ZeroIfNull(reader["NB_RESULT"]) > 0) return true;
        }
      }

      return false;
    }

    private void cmdDate2_Click(object sender, System.EventArgs e)
    {
      try
      {
        // si on a deja une date de planif
        if (chkInfoSite.Checked || txtDateA1.Text != "")
        {
          // si tech, impossible de passer par là
          if (optInter0.Checked)
          {
            MessageBox.Show($"{Resources.msg_pour_modif_date_planif}{Environment.NewLine}{Resources.msg_passer_par_planning}",
                            Program.AppTitle, MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
            return;
          }
        }
        // si statut <> 'O' et tech
        if ((string)cboEtat.SelectedValue != "O" && optInter0.Checked)
        {
          MessageBox.Show(Resources.msg_planifier_statut_O, Program.AppTitle, MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
          return;
        }
        // pour les STT, on a le cas des STT qui peuvent faire des prev et les autres qui ne font pas de prèv
        // si on a déjà une date de planif, il faut passer par le planning des stt pour la modifier  
        // si on a deja une date de planif et préventive, impossible de passer par là, il faut passer par le planning des STT
        if ((chkInfoSite.Checked || txtDateA1.Text != "") && !optInter0.Checked && (string)cboPrest.SelectedValue == "P")
        {
          MessageBox.Show($"{Resources.msg_pour_modif_date_planif}{Environment.NewLine}{Resources.msg_passer_par_planning}",
                            Program.AppTitle, MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
          return;
        }
        // si on a deja une date de planif et stt avec accès web impossible de passer par là, il faut passer par le planning des STT
        if ((chkInfoSite.Checked || txtDateA1.Text != "") && !optInter0.Checked && DetailstravauxUtils.IntervantWithTabletSTF(Utils.BlankIfNull(txtContact.Tag)))
        {
          MessageBox.Show($"{Resources.msg_pour_modif_date_planif}{Environment.NewLine}{Resources.msg_passer_par_planning}",
                            Program.AppTitle, MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
          return;
        }
        // si stt
        if ((string)cboEtat.SelectedValue != "O" && !optInter0.Checked && txtDateA1.Text == "")
        {
          MessageBox.Show(Resources.msg_planifier_statut_O, Program.AppTitle, MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
          return;
        }
        // si stt en prèv
        if ((string)cboEtat.SelectedValue != "O" && !optInter0.Checked && (string)cboPrest.SelectedValue == "P")
        {
          MessageBox.Show(Resources.msg_planifier_statut_O, Program.AppTitle, MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
          return;
        }
        // si statut = 'S'
        if ((string)cboEtat.SelectedValue == "S")
        {
          MessageBox.Show(Resources.msg_planif_action_infoarchive_impossible, Program.AppTitle, MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
          return;
        }

        iTextBoxDate = 1;
        DateTime d;
        if (DateTime.TryParse(txtDateA0.Text, out d))
          _curDate = Calendar1.Value = d;
        else { _curDate = DateTime.MinValue; Calendar1.Value = DateTime.Now; }
        Calendar1.Visible = true;
        Calendar1.ShowCalendar(new MouseEventArgs(MouseButtons.Left, 1, MousePosition.X, MousePosition.Y, 0));
      }
      //catch (Exception ex) { MessageBox.Show($"{ex.Message}\r\n\r\n{Resources.Global_dans}{MethodBase.GetCurrentMethod().Name}", Resources.Global_Erreur, MessageBoxButtons.OK, MessageBoxIcon.Exclamation); }
      catch (Exception ex) { Utils.ShowError(ex, $"{MethodBase.GetCurrentMethod().Name} dans {this.Name}"); }
    }

    private void cmdDate3_Click(object sender, System.EventArgs e)
    {
      try
      {
        if (!bDroitVisa && chkVisaExec.Checked)
        {
          MessageBox.Show(Resources.msg_date_exec_verifiee_non_modifiable, Program.AppTitle, MessageBoxButtons.OK, MessageBoxIcon.Information);
          return;
        }
        iTextBoxDate = 2;
        DateTime d;
        if (DateTime.TryParse(txtDateA1.Text, out d))
          _curDate = Calendar1.Value = d;
        else { _curDate = DateTime.MinValue; Calendar1.Value = DateTime.Now; }
        Calendar1.Visible = true;
        Calendar1.ShowCalendar(new MouseEventArgs(MouseButtons.Left, 1, MousePosition.X, MousePosition.Y, 0));
      }
      //catch (Exception ex) { MessageBox.Show($"{ex.Message}\r\n\r\n{Resources.Global_dans}{MethodBase.GetCurrentMethod().Name}", Resources.Global_Erreur, MessageBoxButtons.OK, MessageBoxIcon.Exclamation); }
      catch (Exception ex) { Utils.ShowError(ex, $"{MethodBase.GetCurrentMethod().Name} dans {this.Name}"); }
    }

    private void chkNonPublic_CheckedChanged(object sender, EventArgs e)
    {
      if (devisExiste() && bMsgDevisCL)
        MessageBox.Show(Resources.msg_Att_modif_parametres_devis_deja_envoye_client_sera_pas_modifie, Program.AppTitle, MessageBoxButtons.OK, MessageBoxIcon.Information);
      if (chkNonPublic.Checked)
      {
        bMsgDevisCL = false;
        chkNuit.Checked = false;
        txtNbHeurPart.Visible = lblNbHeurPart.Visible = true;
        txtNbHeurPart.Text = "0";
        txtObserv.Text = $"{MozartParams.strUID} : Présence hors public coché le {DateTime.Now.ToString("dd/MM/yy HH:mm")}{Environment.NewLine}{txtObserv.Text}";
      }
      else
      {
        txtObserv.Text = $"{MozartParams.strUID} : Présence hors public décoché le {DateTime.Now.ToString("dd/MM/yy HH:mm")}{Environment.NewLine}{txtObserv.Text}";
        if (!chkNuit.Checked)
        {
          txtNbHeurPart.Visible = lblNbHeurPart.Visible = false;
          txtNbHeurPart.Text = "0";
        }
      }

      bMsgDevisCL = true;
    }

    private void chkNuit_CheckedChanged(object sender, EventArgs e)
    {
      // si devis client existe, il faut avertir des modifications
      if (devisExiste() && bMsgDevisCL)
        MessageBox.Show(Resources.msg_Att_modif_parametres_devis_deja_envoye_client_sera_pas_modifie, Program.AppTitle, MessageBoxButtons.OK, MessageBoxIcon.Information);
      if (chkNuit.Checked)
      {
        bMsgDevisCL = false;
        chkNonPublic.Checked = false;
        txtNbHeurPart.Visible = lblNbHeurPart.Visible = true;
        txtNbHeurPart.Text = "0";
        txtObserv.Text = $"{MozartParams.strUID} : Nuit ou Dimanche coché le {DateTime.Now.ToString("dd/MM/yy HH:mm")}{Environment.NewLine}{txtObserv.Text}";
      }
      else
      {
        txtObserv.Text = $"{MozartParams.strUID} : Nuit ou Dimanche coché décoché le {DateTime.Now.ToString("dd/MM/yy HH:mm")}{Environment.NewLine}{txtObserv.Text}";
        if (!chkNonPublic.Checked)
        {
          txtNbHeurPart.Visible = lblNbHeurPart.Visible = false;
          txtNbHeurPart.Text = "0";
        }
      }
      bMsgDevisCL = true;
    }

    //
    //'Private Sub cmdRelanceDatePla_Click()
    //'Dim rsIntervenant As ADODB.Recordset
    //'Dim sObs As String
    //'Dim TdbGlobal(0 To 1, 0 To 1) As Variant
    //'
    //'  If MsgBox("§Vous allez envoyer une demande de date de planification§" & vbCrLf & "§Etes-vous sûre?§", vbYesNo + vbQuestion + vbDefaultButton2) = vbYes Then
    //'
    //'    ' on recherche une adresse mail, sinon un numero de fax
    //'    If txtContact.Tag = "" Then
    //'        MsgBox "§Aucun sous-traitant n'est sélectionné sur l'action§", vbOKOnly
    //'    Else
    //'        Set rsIntervenant = New ADODB.Recordset
    //'        rsIntervenant.Open "SELECT VINTFAX,VINTMAIL, VSTFPAYS FROM TINT WITH (NOLOCK) INNER JOIN TSTF WITH (NOLOCK) ON TINT.NSTFNUM = TSTF.NSTFNUM WHERE NINTNUM = " & txtContact.Tag, cnx
    //'        If BlankIfNull(rsIntervenant("VINTMAIL")) <> "" Then
    //'            cnx.Execute "exec api_sp_SendMailRelanceDateInter " & glNumAction
    //'            MsgBox "§Un mail de relance a été envoyé au sous-traitant§", vbOKOnly
    //'            sObs = txtObserv
    //'            txtObserv = gstrUID & "§ le §" & Format(Now, "dd/MM/YY HH:MM") & " : §Relance date intervention par mail§" & vbCrLf & sObs
    //'        ElseIf BlankIfNull(rsIntervenant("VINTFAX")) <> "" Then
    //'            If FaxerFichier(CodePays(rsIntervenant("VSTFPAYS")) & "TRelanceDateInter.rtf", "TRelanceDateInterOut.rtf", TdbGlobal(), "Exec api_sp_RelanceDateInter " & CStr(glNumAction)) = False Then
    //'                Exit Sub
    //'            Else
    //'                MsgBox "§Un fax de relance a été envoyé au sous-traitant§", vbOKOnly
    //'                sObs = txtObserv
    //'                txtObserv = gstrUID & "§ le §" & Format(Now, "dd/MM/YY HH:MM") & ": §Relance date intervention par fax§" & vbCrLf & sObs
    //'                cmdEnregistrer_Click
    //'            End If
    //'        Else
    //'            MsgBox "§L'intervenant n'a ni adresse mail ni numéro de fax.§" & vbCrLf & "§La relance n'a pas été envoyée.§", vbOKOnly
    //'        End If
    //'    End If
    //'  End If
    //'
    //'End Sub
    //
    /* --------------------------------------------------------------------------------------- */
    private void OuvertureEnCreation()
    {
      try
      {
        binitcombo = true;
        //bAffInfo = true;
        lblLastTech.Visible = false;
        MozartParams.NumAction = 0;

        // recherche des informations de l'action
        using (SqlDataReader readerDI = ModuleData.ExecuteReader($"exec api_sp_RetourInfoDI {MozartParams.NumDi}"))
        {
          if (readerDI.Read())
          {
            // renseignement de la partie client
            txtClient.Text = Utils.BlankIfNull(readerDI["VCLINOM"]);

            // FG réutilisation de cette gidt pour SAMSIC ROMANIA
            if (!Convert.IsDBNull(readerDI["BCLIGESTNUM"]) && Convert.ToBoolean(readerDI["BCLIGESTNUM"]))
            {
              frameGidtCli.Visible = true;
              txtNumero.Tag = "";
            }

            if (Utils.BlankIfNull(readerDI["CDINTS"]) == "O")
            {
              bTousSites = true;
              txtSite.Text = Resources.lib_tous_sites_client;
              LblVilleCible.Text = "-";
              txtNumSite.Text = "";
              txtTel.Text = "";
              iSiteNum = 0;
            }
            else
            {
              bTousSites = false;
              txtTel.Text = Utils.BlankIfNull(readerDI["VSITTEL"]);
              txtSite.Text = Utils.BlankIfNull(readerDI["VSITNOM"]);

              string villeCible = "";
              int NVILLECIBLE = (int)Utils.ZeroIfNull(readerDI["NVILLECIBLE"]);// Ajout NL le 22/04/2016
              if (NVILLECIBLE != 0)
              {
                using (SqlDataReader rVille = ModuleData.ExecuteReader($"select ville from tvilles where id = {NVILLECIBLE}"))
                {
                  if (rVille.Read())
                  {
                    villeCible = Utils.BlankIfNull(rVille["VILLE"]);
                  }
                }
              }
              LblVilleCible.Text = villeCible;

              iSiteNum = (int)Utils.ZeroIfNull(readerDI["NSITNUM"]);
              txtNumSite.Text = Utils.BlankIfNull(readerDI["NSITNUE"]);
            }

            bTousEquipements = Convert.IsDBNull(readerDI["BDINTE"]) ? false : Convert.ToBoolean(readerDI["BDINTE"]);

            bDIInvEquip = (int)Utils.ZeroIfNull(readerDI["BDININVEQUIP"]);

            // on cache le bouton si on est en tous equipement et création
            cmdRechEquipement.Visible = !bTousEquipements;
            txtDate.Text = Utils.DateLongBlankIfNull(readerDI["DDINDATHEUR"]);
            txtDI.Text = Utils.BlankIfNull(readerDI["NDINNUM"]);
            iClientNum = (int)Utils.ZeroIfNull(readerDI["NCLINUM"]);
            iTypContrat = (int)Utils.ZeroIfNull(readerDI["NTYPECONTRAT"]);
            txtCompte.Text = Utils.BlankIfNull(readerDI["NDINCTE"]);// retourne le numéro de compte ana
                                                                    // on teste si CAN sur chantier
            if (txtCompte.Text != "" && TestIfCANChantier(txtCompte.Text == "" ? 0 : Convert.ToInt32(txtCompte.Text)))
            {
              bNCANChantier = true;
              txtduree.ReadOnly = true;
              txtduree.BackColor = Color.Yellow;
              // charge le recordset de la liste des fiches chantier
              LoadHRChantier();
            }

            bActReccur = Convert.IsDBNull(readerDI["NDINACTRECCUR"]) ? false : Convert.ToBoolean(readerDI["NDINACTRECCUR"]);

            // gestion du bouton duplication recurrente action
            if (ModuleMain.RechercheDroitMenu(608))
              CmdDuplicateAct.Visible = bActReccur;
            else
              CmdDuplicateAct.Visible = false;
            // Désactivé car en mode création
            CmdDuplicateAct.Enabled = false;

            // si compte chantier (magestime)
            if (txtCompte.Text == "896" || DetailstravauxUtils.RechercheServiceByPers() == 5) chkWeb.Checked = true;
            bPrem = false;

            // retour info Action ( création via internet )
            if (MozartParams.Action != "")
            {
              txtAction.Text = MozartParams.Action;
              bModif = true;
            }
            else txtAction.Text = "";

            txtDateA0.Text = MozartParams.DateAction;// retour info Action ( création via internet )

            txtDateA1.Text = "";// date planifiée
            txtDateA2.Text = "";// date exec
            txtAttach.Text = "";// attachement
            txtduree.Text = "";// durée estimée
            txtValeur.Text = "";// valeur estimée
            statutExecution = "";
            statutPlanification = "";

            // par défaut, on pose le sous traitant affecté a ce client et ce contrat si il existe
            // si il n'y en a pas, on met le dernier tech passé sur ce site en préventive
            // recherche des informations sur le ST
            if (bTousSites)
            {
              // si tous sites, on ne met rien et tech par default
              optInter0.Checked = true;
            }
            else
            {
              // recherche du ST imposé et du technicien deja passé en préventive
              using (SqlDataReader readerST = ModuleData.ExecuteReader($"api_sp_InfoST {MozartParams.NumDi}, {iSiteNum}"))
              {
                if (!readerST.Read())
                {
                  // si pas de st et pas de tech, on met tech par default
                  optInter0.Checked = true;
                }
                else
                {
                  if (Convert.IsDBNull(readerST["ST"]))
                  {
                    optInter0.Checked = true;
                    if (!Convert.IsDBNull(readerST["tech"]))
                    {
                      // on indique le tech trouvé dans le label prévu, mais on ne l'affecte pas à l'action
                      lblLastTech.Text = Resources.lib_dernier_tech_sur_site + Utils.BlankIfNull(readerST["techs"]);
                      lblLastTech.Visible = true;
                    }

                    // 11/04/2018 : Récupérer le pays pour le msg
                    using (SqlDataReader reader2 = ModuleData.ExecuteReader($"select VSITPAYS from TSIT where NSITNUM={iSiteNum}"))
                    {
                      if (reader2.Read() && Utils.BlankIfNull(reader2["VSITPAYS"]) != "FRANCE")
                        MessageBox.Show($"{Resources.msg_pas_partenaire_dans_base_pour_tech_dans_ville}.{Environment.NewLine}{Resources.msg_rechercher_STT}", Program.AppTitle, MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                    }
                  }
                  else
                  {
                    // par défaut on sélectionne sous traitant de maintenance car dans la sélection d'un sous traitant imposé on n'utilise que les st de maintenance
                    lblInter.Tag = "S";    // on garde l'info pour la suite
                    optInter1.Checked = true;
                    txtFixe.Text = Utils.BlankIfNull(readerST["tel"]);
                    txtPort.Text = Utils.BlankIfNull(readerST["por"]);
                    txtContact.Tag = Convert.IsDBNull(readerST["inter"]) ? null : readerST["inter"];
                    txtContact.Text = Utils.BlankIfNull(readerST["VINTNOM"]);
                    txtInter.Tag = Convert.IsDBNull(readerST["st"]) ? null : readerST["st"];
                    txtInter.Text = Utils.BlankIfNull(readerST["VSTFNOM"]);
                  }
                }
              }
            }

            //InitComboUrg($"select CURGCOD,VURGLIB from api_v_comboUrg where langue = '{MozartParams.Langue}'");
            Utils.InitComboBox(cboUrg, $"select CURGCOD,VURGLIB from api_v_comboUrg where langue = '{MozartParams.Langue}'", "", "");

            //InitComboTech($"select CTECCOD, VTECLIB from api_v_comboTech where langue = '{MozartParams.Langue}'");
            Utils.InitComboBox(cboTech, $"select CTECCOD, VTECLIB from api_v_comboTech where langue = '{MozartParams.Langue}'", "", "");

            // TB SAMSIC CITY SPEC
            //string sql = "";
            //if (MozartParams.NomGroupe == "EMALEC" && iClientNum == 12015)
            //    sql = $"select  CPRECOD, VPRELIB from api_v_comboPrest where CPRECOD in ('D','W','L','P','S','J','V','.','4','7','8','9') AND langue = '{MozartParams.Langue}' ORDER BY VPRELIB";
            //else
            //    sql = $"select  CPRECOD, VPRELIB from api_v_comboPrest where CPRECOD not in ('K','J','V','.','4','7','8','9') and langue = '{MozartParams.Langue}' ORDER BY VPRELIB";
            Utils.InitComboBox(cboPrest, $"api_sp_ComboPrest {iClientNum}", "", "");

            // gestion de la combo des gammes
            Utils.InitComboBox(cboGamme, $"api_sp_ComboGamme {iClientNum}, {iSiteNum}", "", "", true);
            cboGamme.SelectedValue = 200;
            if (cboGamme.SelectedValue == null) cboGamme.SelectedValue = 0;

            // combo processus
            Utils.InitComboBox(cboProcess, $"api_sp_GetLstProcess {MozartParams.NumDi}, {iClientNum} , '{MozartParams.Langue}'", "", "", true);

            // Combo Cause racine
            Utils.InitComboBox(cboCauseRacine, $"SELECT NIDCAUSERACINE, VLIBCAUSERACINE FROM TREF_CAUSERACINE WITH (NOLOCK) WHERE LANGUE = '{MozartParams.Langue}' order by VLIBCAUSERACINE", "", "", true);

            // initialisation vide par defaut sauf pour SCS
            if (MozartParams.NomSociete == "SCS")
            {
              cboPrest.SelectedValue = "T";
              cboTech.SelectedValue = "P";
              cboUrg.SelectedValue = "3";
            }
            else
            {
              cboPrest.SelectedValue = "0";
              cboTech.SelectedValue = "0";
              cboUrg.SelectedValue = "0";
            }

            Utils.InitComboBox(cboEtat, $"select CETACOD, VETALIB from api_v_comboEtat where CETACOD in ('A','D','O','S','B','W','M','N') and langue = '{MozartParams.Langue}'");

            // création de l'action avec statut ouverte
            cboEtat.SelectedValue = "A";
            // on mémorise le statut dans le tag
            cboEtat.Tag = cboEtat.SelectedIndex;

            // création de l'action avec statut admin Attente sauf si Société = EMALEC sur compte 9 alors NF
            // FGA le 08/09/22
            if (iClientNum == MozartParams.SOCIETE)
            {
              txtEtatAdmin.Text = Resources.lib_non_facture;
              txtEtatAdmin.Tag = "N";
            }
            else
            {
              txtEtatAdmin.Text = Resources.lib_attente;
              txtEtatAdmin.Tag = "A";
            }
            // blocaqe des boutons
            cmdDevis.Enabled = false;
            cmdContrat.Enabled = false;
            cmdCSP.Enabled = false;
            cmdCST.Enabled = false;
            cmdDevisClt.Enabled = false;
            cmdCommande.Enabled = false;
            cmdPlanifier.Enabled = false;
            cmdStock.Enabled = false;
            cmdImages.Enabled = false;
            cmdDoc.Enabled = false;
            cmdOM.Visible = false;
            cmdOMT.Visible = false;
            lblSTI.Visible = false;
            cmdAct.Enabled = false;
            cmdInventaire.Visible = false;
            cmdCourrier.Enabled = false;
            cmdConsult.Enabled = false;
            cmdDdeStock.Enabled = false;
            cmdAttGam.Enabled = false;
            cmdDate2.Enabled = false;
            cmdDate3.Enabled = false;
            cmdFact.Enabled = false;
            cmdPrepaCde.Enabled = false;
            cmdCopie.Enabled = !bTousSites;
            CmdDocTech.Enabled = false;
            cmdOGar.Enabled = false;
            CmdPPS.Enabled = false;

            cmdLDR.Enabled = false;
            cmdWeb.Enabled = false;
            cmdALC.Enabled = false;
            cmdCot.Enabled = false;
            CmdData.Enabled = false;
            cmdEnvoiSynergee.Enabled = false;
            cmdMess.Enabled = false;
            cmdVisuDevisSTT.Enabled = false;

            bDevisCL = false;
            bModif = false;
            bReclam = false;


            // affichage du champs obsfac si facturation ou direction ou chaff
            // on reprend les droits inscrits sur un bouton fictif pour l'affichage du champs
            if (ModuleMain.RechercheDroitMenu(213))
            {
              lblLabels9.Visible = txtObsFac.Visible = true;
            }
            else
            {
              lblLabels9.Visible = txtObsFac.Visible = false;
              txtOutils.Height = 2300 / 15;
            }

            // bouton commission de sécurité
            //if (iTypContrat == 131 || iTypContrat == 132)
            //{
            //  CmdComSecu.Visible = ModuleMain.bAccesBouton("582") == 1;
            //}
            //else
            //{
            //  CmdComSecu.Visible = false;
            //}

            bKPIGest_DatePrev = Convert.IsDBNull(readerDI["NCLI_KPI_PLA_PREV"]) ? false : Convert.ToBoolean(readerDI["NCLI_KPI_PLA_PREV"]);

            iContratPerNum = Convert.ToInt32(readerDI["NCONTRATPERNUM"]);
            iTypeFact = Convert.ToInt32(readerDI["NTYPFACT"]);

            bManageDelaiContKPI = (Convert.ToInt32(readerDI["NCLI_KPI_DELAI_CONT"]) == 1);
          }
        }
      }
      catch (Exception ex) { Utils.ShowError(ex, $"{MethodBase.GetCurrentMethod().Name} dans {this.Name}"); }
    }

    private void OuvertureEnModification()
    {
      int EtapeDEBUG = 0;
      try
      {
        if (MozartParams.NumAction == 0) return;

        binitcombo = true;
        //bAffInfo = false;  // pas de message sur l'ouverture de l'action
        lblLastTech.Visible = lblSTI.Visible = false;

        // si sModeReadOnly is nothing alors par défaut on le passe en mode 2
        if (sModeReadOnly == "") sModeReadOnly = "2";

        // traitement du blockage des actions
        using (SqlDataReader reader = ModuleData.ExecuteReader($"api_sp_LockAction {MozartParams.NumAction}, {MozartParams.UID}"))
        {
          if (reader.Read() && Convert.ToInt32(reader["LOCK"]) == 0 && iLockPage == 1)
          {// action locké par quelqu'un
            iLockPage = 1;
            lblLock.Text = Resources.lib_action_en_cours_modif_par + Utils.BlankIfNull(reader["QUI"]);
          }
          else iLockPage = 0;
        }

        EtapeDEBUG = 1;

        // recherche des informations de l'action
        using (SqlDataReader readerInfoA = ModuleData.ExecuteReader($"api_sp_InfoAction2 {MozartParams.NumDi},{MozartParams.NumAction}"))
        {
          if (readerInfoA.Read())
          {
            bManageDelaiContKPI = (Convert.ToInt32(readerInfoA["NCLI_KPI_DELAI_CONT"]) == 1);

            iContratPerNum = Convert.ToInt32(readerInfoA["NCONTRATPERNUM"]);
            iTypeFact = Convert.ToInt32(readerInfoA["NTYPFACT"]);

            // renseignement de la partie client
            txtClient.Text = Utils.BlankIfNull(readerInfoA["VCLINOM"]);
            txtSite.Text = Utils.BlankIfNull(readerInfoA["VSITNOM"]);

            string villeCible = "";
            int NVILLECIBLE = (int)Utils.ZeroIfNull(readerInfoA["NVILLECIBLE"]);// Ajout NL le 22/04/2016
            if (NVILLECIBLE != 0)
            {
              using (SqlDataReader rVille = ModuleData.ExecuteReader($"select ville from tvilles where id = {NVILLECIBLE}"))
              {
                if (rVille.Read())
                {
                  villeCible = Utils.BlankIfNull(rVille["VILLE"]);
                }
              }
            }
            LblVilleCible.Text = villeCible;

            txtCodComptaCli.Text = Utils.BlankIfNull(readerInfoA["VCODEFACT"]);

            txtTel.Text = Utils.BlankIfNull(readerInfoA["VSITTEL"]);
            txtNumSite.Text = Utils.BlankIfNull(readerInfoA["NSITNUE"]);
            txtDate.Text = Utils.DateLongBlankIfNull(readerInfoA["DDINDATHEUR"]);
            txtDI.Text = Utils.BlankIfNull(readerInfoA["NDIN"]);
            txtNumFact.Text = Utils.BlankIfNull(readerInfoA["NFACTNUM"]);
            txtNumFact.Tag = Utils.BlankIfNull(readerInfoA["VFACTYP"]);
            txtCompte.Text = Utils.BlankIfNull(readerInfoA["NDINCTE"]);
            txtActionFR.Text = Utils.BlankIfNull(readerInfoA["VACTDESFR"]);
            if (txtActionFR.Text != "") cmdActionFR.BackColor = Color.Yellow;

            bDIInvEquip = (int)Utils.ZeroIfNull(readerInfoA["BDININVEQUIP"]);


            BtnInventaireEquip.Visible = ((Utils.BlankIfNull(readerInfoA["CCLITYPE"]) == "I") & (bDIInvEquip == 1) & ModuleMain.RechercheDroitMenu(BtnInventaireEquip.HelpContextID));

            //BtnInventaireEquip.Visible =  ((Utils.BlankIfNull(sdr["CCLITYPE"]) == "I") 




            // FG réutilisation de cette gidt pour SAMSIC
            // Gestion equipement si Auchan (ou client gidt)
            if (!Convert.IsDBNull(readerInfoA["BCLIGESTNUM"]) && Convert.ToBoolean(readerInfoA["BCLIGESTNUM"]))
            {
              txtNumero.Tag = (int)Utils.ZeroIfNull(readerInfoA["NOBJNUM"]);
              if ((int)txtNumero.Tag != 0)
              {
                frameGidtCli.Visible = true;
                using (SqlDataReader readerEq = ModuleData.ExecuteReader($"api_sp_infoEquipement {txtNumero.Tag}"))
                {
                  if (readerEq.Read())
                  {
                    txtNumero.Text = Utils.BlankIfNull(readerEq["VOBJNUMEQUIP"]);
                    txtObjGidt.Text = Utils.BlankIfNull(readerEq["VOBJLIB"]);
                    toolTip1.SetToolTip(this.cmdRechEquipement, Utils.BlankIfNull(readerEq["VOBJLIB"]));
                  }
                }
              }
            }

            EtapeDEBUG = 2;

            txtNumCde.Text = Utils.BlankIfNull(readerInfoA["VACTNUMCDE"]);
            txtNumGMAO.Text = Utils.BlankIfNull(readerInfoA["VACTNUMGMAO"]);
            Image4.Tag = Utils.BlankIfNull(readerInfoA["VSITHOR"]);
            iTypContrat = (int)Utils.ZeroIfNull(readerInfoA["NTYPECONTRAT"]);

            //affichage du crvp sur bouton att.
            if (iTypContrat == 247) CmdVoiratt.Text = "CRVP/Att.";

            txtMontantFact.Text = "";

            _dateCreation = Utils.DateLongBlankIfNull(readerInfoA["DACTDATCRE"]);

            Frame1.Text = $"Créa :{Utils.BlankIfNull(readerInfoA["VACTIDCRE"])}{Resources.lib_le}{Utils.DateLongBlankIfNull(readerInfoA["DACTDATCRE"])}" +
                          $"     Chaff: {Utils.BlankIfNull(readerInfoA["VDINCHAFF"])}     Ass: {Utils.BlankIfNull(readerInfoA["ASS"])}" +
                          $"     AssChaff: {Utils.BlankIfNull(readerInfoA["ASSCHAFF"])}";

            EtapeDEBUG = 3;

            // statut admin
            // si le client est Emalec, on passe en Non facturé automatiquement
            // modification FGA le 01/09/22  : passage en création de l'action uniquement mais plus en modification pour pouvoir changer si besoin
            //if (Utils.ZeroIfNull(readerInfoA["NCLINUM"]) == MozartParams.SOCIETE && Utils.BlankIfNull(readerInfoA["CACTSTA"]) == "A")
            //{
            //  PasserStatutAdminF();
            //  txtEtatAdmin.Text = Resources.lib_non_facture;
            //}
            //else
            //{
            switch (Utils.BlankIfNull(readerInfoA["CACTSTA"]))
            {
              case "A":
                txtEtatAdmin.Text = Resources.lib_attente;
                txtEtatAdmin.Tag = "A";
                break;
              case "C":
                txtEtatAdmin.Text = Resources.lib_chiffree;
                txtEtatAdmin.Tag = "C";
                break;
              case "F":
                txtEtatAdmin.Text = Resources.lib_facturee;
                txtEtatAdmin.Tag = "F";
                break;
              case "N":
                txtEtatAdmin.Text = Resources.lib_non_facture;
                txtEtatAdmin.Tag = "N";
                break;
            }
            //}

            // on conserve le numéro du site et le client
            iSiteNum = (int)Utils.ZeroIfNull(readerInfoA["NSITNUM"]);
            iClientNum = (int)Utils.ZeroIfNull(readerInfoA["NCLINUM"]);

            cmdBlockPave.Tag = Convert.IsDBNull(readerInfoA["BACTPAVEBLOCK"]) ? 0 : Convert.ToBoolean(readerInfoA["BACTPAVEBLOCK"]) ? 1 : 0;
            if ((int)cmdBlockPave.Tag == 0) cmdBlockPave.BackColor = MozartColors.ColorH8000000F;
            else cmdBlockPave.BackColor = MozartColors.ColorH8080FF;

            bActReccur = Utils.ZeroIfNull(readerInfoA["NDINACTRECCUR"]) == 1;

            // gestion du bouton duplication recuurente action
            if (ModuleMain.RechercheDroitMenu(608))
            {
              CmdDuplicateAct.Visible = bActReccur;
            }
            else CmdDuplicateAct.Visible = false;
            // Bouton actif car numaction != 0
            CmdDuplicateAct.Enabled = true;

            // tous sites ?
            bTousSites = Utils.BlankIfNull(readerInfoA["CDINTS"]) == "O";
            // Tous equipements
            bTousEquipements = Convert.IsDBNull(readerInfoA["BDINTE"]) ? false : Convert.ToBoolean(readerInfoA["BDINTE"]);
            // nuit ou  pas
            chkNuit.Checked = Utils.BlankIfNull(readerInfoA["CACTNUIT"]) == "O";
            // hors présence public
            chkNonPublic.Checked = Utils.BlankIfNull(readerInfoA["CACTNUIT"]) == "P";
            //facturation séparée
            chkFact.Checked = Utils.BlankIfNull(readerInfoA["CACTFACUN"]) == "O";
            //suivi client
            chkSuiviClient.Checked = Utils.BlankIfNull(readerInfoA["CACTSUIVICLI"]) == "O";

            if (Utils.BlankIfNull(readerInfoA["CCLIP3"]) == "O")
            {
              // type contrat P3
              chkP3.Checked = Utils.BlankIfNull(readerInfoA["CACTTYPCONT"]) == "O";
              chkP3.Visible = true;
            }

            // si nuit ou hors présence public --> affichage du nombre d'heures
            if (chkNuit.Checked || chkNonPublic.Checked)
            {
              txtNbHeurPart.Visible = lblNbHeurPart.Visible = true;
              txtNbHeurPart.Text = Utils.BlankIfNull(readerInfoA["NACTNBHPART"]);
            }

            // reclamation ou pas
            bReclam = chkReclam.Checked = Utils.BlankIfNull(readerInfoA["CACTRECLAM"]) == "O";

            chkNCPriseEnCompte.Checked = Utils.BlankIfNull(readerInfoA["CNCPCOMPTE"]) == "O";

            // VUE web ou pas
            chkWeb.Checked = Utils.BlankIfNull(readerInfoA["CACTVUEWEB"]) != "O";
            bPrem = false;
            chkCMD.Checked = Utils.BlankIfNull(readerInfoA["CACTCMD"]) == "O";
            // utilisation nacelle
            chkNacelle.Checked = Utils.BlankIfNull(readerInfoA["CACTNACEL"]) == "O";
            // matériel sur site
            chkMat.Checked = Utils.BlankIfNull(readerInfoA["CACTFOU"]) == "O";
            chkP5.Checked = Utils.BlankIfNull(readerInfoA["CACTP5"]) == "O";
            //chkNOK.Checked = Utils.BlankIfNull(readerInfoA["CACTNOK"]) == "O";
            // hors présence public
            ChkR_AND_D.Checked = Utils.ZeroIfNull(readerInfoA["CACT_R_AND_D"]) == 1;
            // KPI GEST DATE PREV
            bKPIGest_DatePrev = Utils.ZeroIfNull(readerInfoA["NCLI_KPI_PLA_PREV"]) == 1;
            if (Utils.BlankIfNull(readerInfoA["CPRECOD"]) == "P") lblLabels50.Visible = bKPIGest_DatePrev;

            // combo PPS
            CboPPS.SelectedIndex = Utils.ZeroIfNull(readerInfoA["NACTPPS"]) == 3 ? 1 : (int)Utils.ZeroIfNull(readerInfoA["NACTPPS"]);
            if (Utils.ZeroIfNull(readerInfoA["NACTPPS"]) != 2)
            {
              LblPPS.Visible = CboPPS.Visible = true;
            }
            CboPPS.Tag = CboPPS.SelectedIndex;

            chkVisaArr.Checked = Utils.ZeroIfNull(readerInfoA["NPERNUMVISAARR"]) > 0;
            chkVisaArr.Tag = (int)Utils.ZeroIfNull(readerInfoA["NPERNUMVISAARR"]);
            chkVisaArr.Text = Utils.BlankIfNull(readerInfoA["VVISAARR"]) + Utils.BlankIfNull(readerInfoA["DVISAARR"]);
            chkVisaExec.Checked = Utils.ZeroIfNull(readerInfoA["NPERNUMVISAEXEC"]) > 0;
            chkVisaExec.Tag = (int)Utils.ZeroIfNull(readerInfoA["NPERNUMVISAEXEC"]);
            chkVisaExec.Text = Utils.BlankIfNull(readerInfoA["VVISAEXEC"]) + Utils.BlankIfNull(readerInfoA["DVISAEXEC"]);

            // qui saisie la date d'exec
            lblQuiExec.Text = Utils.BlankIfNull(readerInfoA["VACTQUIEXEC"]);
            // qui saisie la date arrivée
            lblQuiArr.Text = Utils.BlankIfNull(readerInfoA["VACTQUIDARR"]);
            // qui saisie l'attachement
            lblQuiAttach.Text = Utils.BlankIfNull(readerInfoA["VACTQUIATTACH"]);
            // qui visa facture
            lblCotraitant.Text = Utils.BlankIfNull(readerInfoA["NACTQUIVISA"]);
            TxtFactBudg.Text = Utils.BlankIfNull(readerInfoA["NACTMTFACTCOT"]);

            // Info site ou pas
            if (Utils.BlankIfNull(readerInfoA["CACTINFOMAG"]) == "O")
            {
              chkInfoSite.Checked = true;
              lblQuiInfo.Text = $"{Utils.BlankIfNull(readerInfoA["VACTQUIINFO"])}{Resources.lib_le}{Utils.BlankIfNull(readerInfoA["DACTQUANDINFO"])}";
              txtQui.Text = Utils.BlankIfNull(readerInfoA["VACTINFOQUI"]);
              txtQui.Visible = lblLabels30.Visible = true;
            }
            else
            {
              chkInfoSite.Checked = false;
              txtQui.Text = lblQuiInfo.Text = "";
            }

            // validation de la facturation
            if (Utils.BlankIfNull(readerInfoA["CACTVALIDFAC"]) == "O")
            {
              chkValidFac.Checked = true;
              chkValidFac.Text = $"{Resources.lib_traite_facturiere}: {Utils.BlankIfNull(readerInfoA["VACTQUIVALIDFAC"])} le {Utils.BlankIfNull(readerInfoA["DACTDVALIDFAC"])}";
            }
            else
            {
              chkValidFac.Checked = false;
              chkValidFac.Text = Resources.lib_traite_facturiere;
            }

            // retour info Action
            txtAction.Text = Utils.BlankIfNull(readerInfoA["VACTDES"]);         // désignation action
            txtDateA0.Text = Utils.DateBlankIfNull(readerInfoA["DACTDAT"]);       // date souhaitée
            txtDateA1.Text = Utils.DateBlankIfNull(readerInfoA["DACTPLA"]);      // date planification
            txtDateA1.Tag = Utils.DateBlankIfNull(readerInfoA["DACTPLA"]);
            txtDateA2.Text = Utils.DateLongIfHMBlankIfNull(readerInfoA["DACTDEX"]);       // date exécution
            txtDateA5.Text = Utils.DateBlankIfNull(readerInfoA["DACTDRELANCE"]);  // date relance

            statutExecution = txtDateA2.Text;
            statutPlanification = txtDateA1.Text;

            // qui relance
            if (txtDateA5.Text == "")
            {
              //cboInter.SelectedValue = MozartParams.UID;
              cboInter1.SetItemData(MozartParams.UID);
              lblRelance.Text = "";
              chkRelanceUrgente.Checked = false;
            }
            else
            {
              lblRelance.Text = Utils.BlankIfNull(readerInfoA["VACTQUIRELANCE"]);
              // si on a une relance, on affiche qui est relance, sinon on affiche la personne par défaut
              if (lblRelance.Text == "")
              {
                //cboInter.SelectedValue = MozartParams.UID;
                cboInter1.SetItemData(MozartParams.UID);
              }
              else
              {
                lblRelance.Text += " pour ";
                //cboInter.SelectedValue = (int)Utils.ZeroIfNull(readerInfoA["NACTQUIESTRELANCER"]);
                cboInter1.SetItemData((int)Utils.ZeroIfNull(readerInfoA["NACTQUIESTRELANCER"]));
              }
              chkRelanceUrgente.Checked = Utils.ZeroIfNull(readerInfoA["NRELANCEURGENTE"]) == 1;
            }

            // heure et minute
            if (txtDateA2.Text != "")
            {
              cboHE.Text = Convert.ToDateTime(txtDateA2.Text).Hour.ToString("00");
              cboHE.Tag = Convert.ToDateTime(txtDateA2.Text).Hour;
              cboME.Text = Convert.ToDateTime(txtDateA2.Text).Minute.ToString("00");
              cboME.Tag = Convert.ToDateTime(txtDateA2.Text).Minute;
            }
            txtDateA3.Text = Utils.DateLongIfHMBlankIfNull(readerInfoA["DACTARR"]);// date d'arrivée sur site
                                                                                   // heure et minute
            if (txtDateA3.Text != "")
            {
              cboH.Text = Convert.ToDateTime(txtDateA3.Text).Hour.ToString("00");
              cboH.Tag = Convert.ToDateTime(txtDateA3.Text).Hour;
              cboM.Text = Convert.ToDateTime(txtDateA3.Text).Minute.ToString("00");
              cboM.Tag = Convert.ToDateTime(txtDateA3.Text).Minute;
            }

            txtAttach.Text = Utils.BlankIfNull(readerInfoA["VACTATT"]);// attachement
            txtduree.Text = Utils.ZeroIfNull(readerInfoA["NACTDUR"]).ToString("0.##");// durée estimée
            txtOutils.Text = Utils.BlankIfNull(readerInfoA["VACTOUT"]);// outils
            txtFour.Text = Utils.BlankIfNull(readerInfoA["VACTFOU"]);// fournitures
            txtObserv.Text = Utils.BlankIfNull(readerInfoA["VACTOBS"]);//observations
            txtObservM.Text = Utils.BlankIfNull(readerInfoA["VACTOBSM"]);//observations
            txtDevWeb.Text = Utils.BlankIfNull(readerInfoA["VACTFACTBUDG"]);// numero de devis du soustraitant web ou saisie manuel              
            TxtHeuresDevis.Text = Utils.BlankIfNull(readerInfoA["NNBHEURESDEVIS"]);// numero de devis du soustraitant web ou saisie manuel
            txtWhyBlocage.Text = Utils.BlankIfNull(readerInfoA["VBLOCAGEPAVE"]);// raison du blocage du pavé

            // gestion pour rdv sur plage horaire
            if (Utils.BlankIfNull(readerInfoA["VACTRDVPLAGEHR"]) == "")
            {
              txtRDV.Text = Utils.BlankIfNull(readerInfoA["VACTRDV"]);// rdv
              if (Utils.BlankIfNull(readerInfoA["VACTHRRDV"]) != "" && Utils.BlankIfNull(readerInfoA["VACTHRRDV"]) != ":")
              {
                string[] tab = Utils.BlankIfNull(readerInfoA["VACTHRRDV"]).Split(':');
                cboHrRDV.Text = Convert.ToInt16(tab[0]).ToString("00");
                cboMinRDV.Text = Convert.ToInt16(tab[1]).ToString("00");
              }
              else
              {
                cboMinRDV.SelectedIndex = cboHrRDV.SelectedIndex = 0;
              }
            }
            else
            {
              string[] tab = Utils.BlankIfNull(readerInfoA["VACTRDVPLAGEHR"]).Split(';');
              TxtRDVPlageHR0.Text = tab[0];
              TxtRDVPlageHR1.Text = tab[1];
            }

            txtObsFac.Text = Utils.BlankIfNull(readerInfoA["VACTOBSFAC"]);  // observation sur la facture
            txtDateA4.Text = Utils.DateBlankIfNull(readerInfoA["DACTDCDE"], "dd/MM/yy"); // date commande client
            if (txtDateA4.Text == "")
            {
              CmdDateCde.Visible = true;
              CmdSuppCde.Visible = false;
            }
            else
            {
              CmdDateCde.Visible = false;
              CmdSuppCde.Visible = true;
            }

            // traitement EI, declaration N4
            chkN4.Tag = (int)Utils.ZeroIfNull(readerInfoA["NACTN4"]);
            chkN4.Checked = (int)chkN4.Tag > 0;

            // traitement spécifique de cette zone
            // si il existe un devis client , on met cette valeur
            // si on a un chiffrage on met le chiffrage
            txtValeur.Text = Utils.ZeroIfNull(readerInfoA["NACTVAL"]).ToString("0.##");// Montant estimée

            // si facture on met facture, sinon si Elf on met ELF, sinon si devis on met devis sinon on met estimation
            if (txtCompte.Text != "996")
            {
              if (Convert.IsDBNull(readerInfoA["NFACTNUM"]))
              {
                if (Convert.IsDBNull(readerInfoA["NUMELF"]))
                {
                  if (!Convert.IsDBNull(readerInfoA["NACTNUMCESSION"]))
                  {
                    lblLabels24.Text = "Montant Cession €HT";
                    txtValeur.Enabled = false;
                    txtValeur.ForeColor = Color.Black;
                  }
                  else if (Convert.IsDBNull(readerInfoA["NBDEVISCL"]) || Utils.ZeroIfNull(readerInfoA["NBDEVISCL"]) == 0)
                  {
                    if (MozartParams.NomSociete == "EMALECSUISSE")
                      lblLabels24.Text = Resources.lib_montant_estime_CHF;
                    else
                      lblLabels24.Text = Resources.lib_montant_estime_euroHT;
                    txtValeur.ForeColor = Color.Black;
                  }
                  else
                  {//  il y a un devis donc on bloque
                    if (MozartParams.NomSociete == "EMALECSUISSE")
                      lblLabels24.Text = Resources.lib_montant_devis_CHF_HT;
                    else
                      lblLabels24.Text = Resources.lib_montant_devis_euro_HT;
                    txtValeur.ForeColor = Color.Red;
                    txtValeur.ReadOnly = txtValeur.Enabled = true;
                  }
                }
                else
                {// il y a un chiffrage donc on bloque
                  if (MozartParams.NomSociete == "EMALECSUISSE")
                    lblLabels24.Text = Resources.lib_montant_chiffre_CHF_HT;
                  else
                    lblLabels24.Text = Resources.lib_montant_chiffre_euro_HT;
                  txtValeur.Enabled = false;
                  txtValeur.ForeColor = Color.Black;
                }
              }
              else
              {// il y a une facture donc on bloque
                if (MozartParams.NomSociete == "EMALECSUISSE")
                  lblLabels24.Text = Resources.lib_montant_facture_CHF_HT;
                else
                  lblLabels24.Text = Resources.lib_montant_facture_euro_HT;
                txtValeur.Enabled = false;
                txtValeur.ForeColor = Color.Black;
              }
            }

            // on conserve l'info de savoir si on a un devis client ou pas
            bDevisCL = !(Convert.IsDBNull(readerInfoA["NBDEVISCL"]) || Utils.ZeroIfNull(readerInfoA["NBDEVISCL"]) == 0);

            EtapeDEBUG = 4;

            // les combo
            Utils.InitComboBox(cboUrg, $"select CURGCOD,VURGLIB from api_v_comboUrg where langue = '{MozartParams.Langue}'", "", "");
            EtapeDEBUG = 5;
            Utils.InitComboBox(cboTech, $"select CTECCOD, VTECLIB from api_v_comboTech where langue = '{MozartParams.Langue}'", "", "");
            EtapeDEBUG = 6;
            // TB SAMSIC CITY SPEC
            //string sql = "";
            //if (MozartParams.NomGroupe == "EMALEC" && iClientNum == 12015)
            //    sql = $"select  CPRECOD, VPRELIB from api_v_comboPrest where CPRECOD in ('D','W','L','P','S','J','V','K','F','.','4','7','8','9') AND langue = '{MozartParams.Langue}' ORDER BY VPRELIB";
            //else
            //    sql = $"select  CPRECOD, VPRELIB from api_v_comboPrest where CPRECOD not in ('J','V','.','4','7','8','9') and langue = '{MozartParams.Langue}' ORDER BY VPRELIB"; //{MozartParams.Langue}
            //Utils.InitComboBox(cboPrest, sql, "", "");
            Utils.InitComboBox(cboPrest, $"api_sp_ComboPrest {iClientNum}", "", "");


            EtapeDEBUG = 7;

            // combo processus
            Utils.InitComboBox(cboProcess, $"api_sp_GetLstProcess {MozartParams.NumDi}, {iClientNum} , '{MozartParams.Langue}'", "", "", true);
            cboProcess.SelectedValue = Utils.ZeroIfNull(readerInfoA["NIDPROCESS"]);

            Utils.InitComboBox(cboCauseRacine, $"SELECT NIDCAUSERACINE, VLIBCAUSERACINE FROM TREF_CAUSERACINE WITH (NOLOCK) WHERE LANGUE = '{MozartParams.Langue}' order by VLIBCAUSERACINE", "", "", true);
            cboCauseRacine.SelectedValue = Utils.ZeroIfNull(readerInfoA["NIDCAUSERACINE"]);

            EtapeDEBUG = 8;
            // gestion de la combo des gammes (a la fois gamme site et client (+1000 pour les gammes sites))
            Utils.InitComboBox(cboGamme, $"api_sp_ComboGamme {iClientNum}, {iSiteNum}", "", "", true);
            cboGamme.SelectedValue = Utils.ZeroIfNull(readerInfoA["NGAMNUM"]);

            EtapeDEBUG = 9;
            // combo statut :
            // pas de modification possible si statut autre que A O S D B W
            string code = Utils.BlankIfNull(readerInfoA["CETACOD"]);
            if (code == "A" || code == "O" || code == "S" || code == "D" || code == "B" || code == "W" || code == "M" || code == "N")
            {
              Utils.InitComboBox(cboEtat, $"select CETACOD, VETALIB from api_v_comboEtat where CETACOD in ('A','D','O','S','B','W','M','N') and langue = '{MozartParams.Langue}'");
              cboEtat.Enabled = true;
            }
            else
            {
              Utils.InitComboBox(cboEtat, $"select CETACOD, VETALIB from api_v_comboEtat where langue = '{MozartParams.Langue}'");
              cboEtat.Enabled = false;
            }

            // on mets à jours le CACTTYT
            lblInter.Tag = Utils.BlankIfNull(readerInfoA["CACTTYT"]);

            // on utilise le SelectLB FG le 02/02/15
            // se placer sur le bon libellé
            cboUrg.SelectedValue = Utils.BlankIfNull(readerInfoA["CURGCOD"]);
            cboTech.SelectedValue = Utils.BlankIfNull(readerInfoA["CTECCOD"]);
            cboPrest.SelectedValue = Utils.BlankIfNull(readerInfoA["CPRECOD"]);
            cboEtat.SelectedValue = Utils.BlankIfNull(readerInfoA["CETACOD"]);

            // test si la prestation existe bien dans la liste
            if (cboPrest.SelectedIndex == -1)
            {
              //  // on ne trouve pas la prestation, on l'ajoute à la combo
              using (SqlDataReader sdrAux = ModuleData.ExecuteReader($"select VPRELIB, CPRECOD FROM TREF_PRE WHERE LANGUE = '{MozartParams.Langue}' AND CPRECOD = '{readerInfoA["CPRECOD"]}'"))
              {
                if (sdrAux.Read())
                {
                  DataRow row = (cboPrest.DataSource as DataTable).NewRow();
                  row[0] = Utils.BlankIfNull(sdrAux["CPRECOD"]);
                  row[1] = Utils.BlankIfNull(sdrAux["VPRELIB"]);
                  (cboPrest.DataSource as DataTable).Rows.Add(row);
                  cboPrest.SelectedValue = row[0];
                }
              }

            }

            // on mémorise le statut dans le tag
            cboEtat.Tag = cboEtat.SelectedIndex;
            cboPrest.Tag = cboPrest.SelectedIndex;

            if (Utils.BlankIfNull(readerInfoA["CPRECOD"]) == "K") cboPrest.Enabled = false;

            // gestion de droit sur une valeur de la combo FG le 02/02/15
            // seul la direction peut changer la prestation visite de sécurité
            if (Utils.BlankIfNull(readerInfoA["CPRECOD"]) == "Y")
            {
              cboPrest.Enabled = ModuleMain.RechercheDroitMenu(546);
            }

            EtapeDEBUG = 10;
            // gestion des statuts compléments
            cboEtatCO.SelectedValue = Utils.BlankIfNull(readerInfoA["CETATCPL"]);
            cboSemaines.Text = Utils.ZeroIfNull(readerInfoA["NNUMSEM"]) == 0 ? "" : Convert.ToString(Utils.ZeroIfNull(readerInfoA["NNUMSEM"]));
            if ((string)cboEtatCO.SelectedValue == "2" || (string)cboEtatCO.SelectedValue == "4") { cboSemaines.Visible = true; }

            cboEtatAdminCpl.SelectedValue = Utils.BlankIfNull(readerInfoA["CETATADMINCPL"]);

            EtapeDEBUG = 12;

            // gestion affichage des boutons et combo selon la prestation
            string CACTTYT = Utils.BlankIfNull(readerInfoA["CACTTYT"]);
            OptionAfficheTypeIntervenant(CACTTYT);

            // Intervenant
            if (CACTTYT == "S" || CACTTYT == "I" || CACTTYT == "G")
            {
              using (SqlDataReader readerSn = ModuleData.ExecuteReader($"api_sp_infoSTTaction {MozartParams.NumAction}"))
              {
                if (readerSn.Read())
                {
                  // relance facture ST
                  chkRel.Checked = Utils.ZeroIfNull(readerSn["NACTVALDEVISST"]) == 1;
                  // MC_OG
                  switch (CACTTYT)
                  {
                    case "S": // sous traitant maintenance
                      optInter1.Checked = true;
                      break;
                    case "I": // 'sous traitant installation
                      optInter2.Checked = true;
                      break;
                    case "G": // 'sous traitant garantie
                      optInter3.Checked = true;
                      break;
                  }

                  cmdDocSTT.Text = "Doc";
                  txtFixe.Visible = txtPort.Visible = lbltel.Visible = lblpor.Visible = true;

                  // recherche si il y a un contact
                  if (Convert.IsDBNull(readerSn["VINTNOM"]))
                  {
                    if ((string)lblInter.Tag != "G") lblInter.Tag = "R"; // on garde l'info pour la suite
                    txtFixe.Text = txtPort.Text = txtInter.Text = txtContact.Text = "";
                    txtInter.Tag = txtContact.Tag = null;
                  }
                  else
                  {
                    txtInter.Tag = (int)Utils.ZeroIfNull(readerSn["NSTFNUM"]);
                    txtInter.Text = Utils.BlankIfNull(readerSn["VSTFNOM"]);
                    txtContact.Tag = (int)Utils.ZeroIfNull(readerSn["NINTNUM"]);
                    txtContact.Text = Utils.BlankIfNull(readerSn["VINTNOM"]);
                    txtFixe.Text = Utils.BlankIfNull(readerSn["VINTTEL"]);
                    txtPort.Text = Utils.BlankIfNull(readerSn["VINTPOR"]);
                    lblInter.Tag = CACTTYT;// on garde l'info pour la suite
                                           // gestion de la couleur du bouton doc
                    using (SqlDataReader reader = ModuleData.ExecuteReader($"exec api_sp_CouleurBoutonDocAction {MozartParams.NumAction}"))
                    {
                      if (reader.Read())
                      {
                        cmdDocSTT.BackColor = Utils.BlankIfNull(reader[0]) == "RED" ? MozartColors.colorHC0C0FF : MozartColors.ColorHC0FFC0;
                      }
                    }
                  }

                  // recherche si il y a une demande de devis ST
                  cboDevis.Text = Utils.BlankIfNull(readerSn["DEVIS"]);
                  Timer1.Enabled = cboDevis.Text == "Relance";

                  txtMontantDevis.Text = Utils.BlankIfNull(readerSn["VALDEVIS"]);
                  // telephone astreinte st
                  txtTelAstr.Visible = true;
                  lblAstr.Visible = true;
                  txtTelAstr.Text = Utils.BlankIfNull(readerSn["VSTFTEL"]);
                  ApiTelAuto3.Visible = true;

                  iCodeCotraitance = DetailstravauxUtils.RechercheCotraitantAct(MozartParams.NumAction);
                  if (iCodeCotraitance == 0)
                  {
                    TxtFactBudg.Visible = lblLabels27.Visible = lblCotraitant.Visible = lblSTI.Visible = false;
                  }
                  else
                  {
                    // If iCodeCotraitance = 1 alors on laisse le libellé par défaut
                    if (iCodeCotraitance == 3) lblSTI.Text = "Cotraitant";
                    else if (iCodeCotraitance == 2) lblSTI.Text = "Cotraitant imposé";
                    TxtFactBudg.Visible = lblLabels27.Visible = lblCotraitant.Visible = lblSTI.Visible = true;
                  }

                  chkVisaExec.Visible = chkVisaArr.Visible = false;

                  // bouton de gestion des prestations sur action (invisible pour les STT)
                  cmdPrest.Visible = false;

                  // Acompte sur le contrat du sous traitant
                  Frame7.Text = Resources.col_Intervenant;
                  using (SqlDataReader readerSr = ModuleData.ExecuteReader($"SELECT CCSTACOMPTE, NCSTNUM FROM TCST WITH (NOLOCK) Where CCSTACOMPTE='O' AND NACTNUM = {MozartParams.NumAction}"))
                  {
                    if (readerSr.Read())
                    {
                      Frame7.Text = Utils.BlankIfNull(readerSr[0]) == "O" ? $"Intervenant  (ATTENTION ! : ACOMPTE versé sur le contrat CS{Utils.ZeroIfNull(readerSr[1])})" : "Intervenant";
                    }
                  }
                }
              }
            }
            else
            {// tech emalec
              using (SqlDataReader readerSn = ModuleData.ExecuteReader($"api_sp_infoTechaction {MozartParams.NumAction}"))
              {
                if (readerSn.Read())
                {
                  optInter0.Checked = true;

                  if (Convert.IsDBNull(readerSn["VPERNOM"]))
                  {
                    txtInter.Tag = null;
                    txtInter.Text = "";
                    SetVisibleChkDevisAttenteCheckBox();
                  }
                  else
                  {
                    txtInter.Tag = (int)Utils.ZeroIfNull(readerSn["NPERNUM"]);
                    txtInter.Text = Utils.BlankIfNull(readerSn["VPERNOM"]);

                    SetVisibleChkDevisAttenteCheckBox();
                    if ((int)Utils.ZeroIfNull(readerInfoA["BACT_DEV_ATT"]) > 0)
                    {
                      ChkAttenteDevisTech.Checked = true;
                      //ajout le 19/05/2025 par MC : on affiche la case à cocher "attente devis" s'il est est coché et malgré l"état de l'action (problème car bcp de users ne décochait pas cette relance manuellement
                      ChkAttenteDevisTech.Visible = LblAtttenteDevisTech.Visible = true;

                    }


                    if (bNCANChantier)
                    {
                      string sTypePer = DetailstravauxUtils.RechercheFonctionByPers((int)Utils.ZeroIfNull(readerSn["NPERNUM"]));
                      if (sTypePer == "AS" || sTypePer == "FA")
                      {
                        txtduree.BackColor = Color.White;
                        txtduree.ReadOnly = false;
                      }
                      else
                      {
                        txtduree.BackColor = Color.Yellow;
                        txtduree.ReadOnly = true;
                      }
                    }
                  }
                  txtFixe.Text = Utils.BlankIfNull(readerSn["NPERCOD"]);
                  txtPort.Text = Utils.BlankIfNull(readerSn["VPERPOR"]);
                  txtPort.Tag = Utils.BlankIfNull(readerSn["VPERPOR"]);// on utilise le tag pour pouvoir envoyer des sms avec le numero

                  // pas de demande de devis
                  txtMontantDevis.Visible = lblMontantdevis.Visible = cboDevis.Visible = lblDevis.Visible = cmdVisuDevisSTT.Visible = false;
                  ApiTelAuto3.Visible = lblRelFac.Visible = txtTelAstr.Visible = lblAstr.Visible = txtDevWeb.Visible = lblDevWeb.Visible = false;
                  CboPPS.Visible = LblPPS.Visible = lblLabels27.Visible = TxtFactBudg.Visible = chkRel.Visible = lblCotraitant.Visible = false;
                  cmdDocSTT.Text = "Stock V";
                  cmdDocSTT.BackColor = MozartColors.ColorH8000000F;
                }
              }

              chkVisaExec.Visible = chkVisaArr.Visible = bDroitVisa && ModuleMain.RechercheDroitMenu(735);
              // bouton de gestion des prestations sur action(visible pour les tech)
              cmdPrest.Visible = true;
            }

            // on teste si CAN sur chantier
            if (txtCompte.Text != "" && TestIfCANChantier(Convert.ToInt32(txtCompte.Text)))
            {
              // remplir combo
              bNCANChantier = true;
              string sTypePer = DetailstravauxUtils.RechercheFonctionByPers(!optInter0.Checked ? 0 : txtInter.Tag == null ? 0 : (int)txtInter.Tag);
              if (sTypePer == "AS" || sTypePer == "FA")
              {
                txtduree.BackColor = Color.White;
                txtduree.ReadOnly = false;
              }
              else
              {
                //string CACTTYT = Utils.BlankIfNull(readerInfoA["CACTTYT"]);
                if ((CACTTYT == "S" || CACTTYT == "I" || CACTTYT == "G") && MozartParams.NomSociete != "EMALECMPM")
                {
                  txtduree.BackColor = Color.White;
                  txtduree.ReadOnly = false;
                }
                else
                {
                  if (txtInter.Tag != null && optInter0.Checked)
                  {
                    txtduree.BackColor = Color.Yellow;
                    txtduree.ReadOnly = true;
                  }
                  else
                  {
                    txtduree.BackColor = Color.White;
                    txtduree.ReadOnly = false;
                  }
                }
              }

              // charge le recordset de la liste des fiches chantier
              LoadHRChantier();
            }

            //attente deivs tech
            //ChkAttenteDevisTech.Checked = (int)Utils.ZeroIfNull(readerInfoA["BACT_DEV_ATT"]) > 0;

            EtapeDEBUG = 13;
            // faire aparaitre les boutons
            cmdCST.Enabled = cmdCSP.Enabled = cmdContrat.Enabled = cmdConsult.Enabled = cmdCourrier.Enabled = cmdOMT.Enabled = cmdDevis.Enabled = true;
            cmdDdeStock.Enabled = cmdAct.Enabled = cmdImages.Enabled = cmdStock.Enabled = cmdPlanifier.Enabled = cmdCommande.Enabled = cmdDevisClt.Enabled = true;
            cmdOM.Visible = ModuleMain.RechercheDroitMenu(567);
            cmdInventaire.Visible = false;

            //  ? on cache un bouton et on en met un autre dessus, mais pourquoi ?
            cmdCopie.Visible = false;
            CmdData.Top = cmdCopie.Top;
            CmdData.Left = cmdCopie.Left;
            //CmdData.Height = cmdCopie.Height;
            CmdData.Visible = ModuleMain.RechercheDroitMenu(247);

            cmdMess.Enabled = cmdEnvoiSynergee.Enabled = cmdALC.Enabled = cmdWeb.Enabled = cmdLDR.Enabled = CmdPPS.Enabled = cmdOGar.Enabled = true;

            cmdDoc.Enabled = CmdDocTech.Enabled = cmdPrepaCde.Enabled = cmdFact.Enabled = cmdDate3.Enabled = cmdDate2.Enabled = cmdAttGam.Enabled = true;

            EtapeDEBUG = 14;

            // bouton ldr attestation  si c'est la premiere action d'une di LDR (sauf pour petit casino et ed carrefour)
            // TB SAMSIC CITY SPEC
            if (MozartParams.NomSociete == "EMALEC" && (iClientNum == 1419 || iClientNum == 1748 || iClientNum == 1597))
            {
              cmdLDR.Visible = ModuleMain.RechercheDroitMenu(575);
            }
            else
            {
              // uniquement si on est sur une ldr
              if ((string)cboPrest.SelectedValue == "L")
              {
                using (SqlDataReader reader2 = ModuleData.ExecuteReader($"select min(NACTNUM) from TACT WITH (NOLOCK) where CPRECOD='L' and NDINNUM={MozartParams.NumDi}"))
                {
                  cmdLDR.Visible = reader2.Read() && Utils.ZeroIfNull(reader2[0]) == MozartParams.NumAction && ModuleMain.RechercheDroitMenu(575);
                }
              }
              else
                cmdLDR.Visible = false;
            }

            EtapeDEBUG = 15;

            // libelle facture ravel et montant ravel( si rien dans ravel, on prend le c
            using (SqlDataReader readerR = ModuleData.ExecuteReader($"select * from api_v_FactureRavel where  NACTNUM = {MozartParams.NumAction} ORDER BY NFOUFACNUM DESC"))
            {
              cboFactRavel.Items.Clear();
              while (readerR.Read() && !Convert.IsDBNull(readerR["FFACHT"]))
              {
                string CDE = $"{readerR["CDE"]} - Réf: {readerR["Reference"]} de {readerR["FFACHT"]}{(MozartParams.NomSociete == "EMALECSUISSE" ? " CHF HT" : " €HT")}";
                cboFactRavel.Items.Add(new cboFactRavelItem((int)Utils.ZeroIfNull(readerR["NFOUFACNUM"]), CDE));
              }
              if (cboFactRavel.Items.Count != 0) cboFactRavel.SelectedIndex = 0;
            }

            // info prev
            // info ville
            EtapeDEBUG = 16;

            // recherche du technicien deja passé en préventive
            if (txtInter.Text == "")
            {
              using (SqlDataReader readerInfoST = ModuleData.ExecuteReader($"api_sp_InfoST {MozartParams.NumDi}, {iSiteNum}"))
              {
                if (readerInfoST.Read())
                {
                  lblLastTech.Text = Resources.lib_dernier_tech_sur_site2 + Utils.BlankIfNull(readerInfoST["techs"]);
                  lblLastTech.Visible = true;
                }
              }
            }

            EtapeDEBUG = 17;

            // Gestion de la couleur de fond des boutons
            using (SqlDataReader readerC = ModuleData.ExecuteReader($"EXEC api_sp_CouleurBoutonAction {MozartParams.NumAction}"))
            {
              if (readerC.Read())
              {
                if (Utils.ZeroIfNull(readerC["IMAGE"]) > 0)
                {
                  cmdImages.Text = $"{Resources.lib_images_web_client}{Utils.ZeroIfNull(readerC["IMAGE"])}";
                  cmdImages.BackColor = MozartColors.ColorH80FFFF;//Jaune pale
                }
                else
                {
                  cmdImages.Text = Resources.lib_images_web_client;
                  cmdImages.BackColor = MozartColors.ColorH8000000F;
                }
                if (Utils.ZeroIfNull(readerC["DOC"]) > 0)
                {
                  cmdDoc.Text = $"{Resources.Documents_internes}{Utils.ZeroIfNull(readerC["DOC"])}";
                  cmdDoc.BackColor = MozartColors.ColorH80FFFF;//Jaune pale
                }
                else
                {
                  cmdDoc.Text = Resources.Documents_internes;
                  cmdDoc.BackColor = MozartColors.ColorH8000000F;
                }
                // gestion couleur doc confidentiel
                //if (Utils.ZeroIfNull(readerC["DOCSECURE"]) > 0)
                //{
                //  CmdDocSecure.Text = $"{Resources.lib_docs_confidentiels}{Utils.ZeroIfNull(readerC["DOCSECURE"])}";
                //  CmdDocSecure.BackColor = MozartColors.ColorH80FFFF;//Jaune pale
                //}
                //else
                //{
                //  CmdDocSecure.Text = Resources.lib_docs_confidentiels;
                //  CmdDocSecure.BackColor = MozartColors.ColorH8000000F;
                //}

                cmdDevis.BackColor = Utils.ZeroIfNull(readerC["DEVISST"]) > 0 ? MozartColors.ColorH80FFFF : MozartColors.ColorH8000000F;
                cmdContrat.BackColor = Utils.ZeroIfNull(readerC["CONTRATST"]) > 0 ? MozartColors.ColorH80FFFF : MozartColors.ColorH8000000F;
                cmdCSP.BackColor = Utils.ZeroIfNull(readerC["CSP"]) > 0 ? MozartColors.ColorH80FFFF : MozartColors.ColorH8000000F;
                cmdCST.BackColor = Utils.ZeroIfNull(readerC["CONTRATSTP"]) > 0 ? MozartColors.ColorH80FFFF : MozartColors.ColorH8000000F;
                cmdCommande.BackColor = Utils.ZeroIfNull(readerC["COMMANDE"]) > 0 ? MozartColors.ColorH80FFFF : MozartColors.ColorH8000000F;
                cmdDevisClt.BackColor = Utils.ZeroIfNull(readerC["DEVISCL"]) > 0 ? MozartColors.ColorH80FFFF : MozartColors.ColorH8000000F;
                cmdStock.BackColor = Utils.ZeroIfNull(readerC["STOCK"]) > 0 ? MozartColors.ColorH80FFFF : MozartColors.ColorH8000000F;
                cmdOM.BackColor = Utils.ZeroIfNull(readerC["OM"]) > 0 ? MozartColors.ColorH80FFFF : MozartColors.ColorH8000000F;
                CmdOG.BackColor = Utils.ZeroIfNull(readerC["OG"]) > 0 ? MozartColors.ColorH80FFFF : MozartColors.ColorH8000000F;
                cmdLDR.BackColor = Utils.ZeroIfNull(readerC["ATTEST"]) > 0 ? MozartColors.ColorH80FFFF : MozartColors.ColorH8000000F;
                cmdInventaire.BackColor = Utils.ZeroIfNull(readerC["INV"]) > 0 ? MozartColors.ColorH80FFFF : MozartColors.ColorH8000000F;
                cmdAct.BackColor = Utils.ZeroIfNull(readerC["ACTFOURN"]) > 0 ? MozartColors.ColorH80FFFF : MozartColors.ColorH8000000F;
                cmdCourrier.BackColor = Utils.ZeroIfNull(readerC["COURRIER"]) > 0 ? MozartColors.ColorH80FFFF : MozartColors.ColorH8000000F;
                cmdConsult.BackColor = Utils.ZeroIfNull(readerC["Consult"]) > 0 ? MozartColors.ColorH80FFFF : MozartColors.ColorH8000000F;
                cmdDdeStock.BackColor = Utils.ZeroIfNull(readerC["DDESTOCK"]) > 0 ? MozartColors.ColorH80FFFF : MozartColors.ColorH8000000F;
                cmdDdeStock.Tag = Utils.ZeroIfNull(readerC["DDESTOCK"]) > 0 ? Utils.BlankIfNull(readerC["DDESTOCK"]) : null;
                cmdAttGam.BackColor = Utils.ZeroIfNull(readerC["ATTACH"]) > 0 ? MozartColors.ColorH80FFFF : MozartColors.ColorH8000000F;
                cmdWeb.BackColor = Utils.ZeroIfNull(readerC["RWEB"]) > 0 ? MozartColors.ColorH80FFFF : MozartColors.ColorH8000000F;
                cmdMess.BackColor = Utils.ZeroIfNull(readerC["MESSFACT"]) > 0 ? MozartColors.ColorH80FFFF : MozartColors.ColorH8000000F;
                CmdDocTech.BackColor = Utils.ZeroIfNull(readerC["DocTech"]) > 0 ? MozartColors.ColorH80FFFF : MozartColors.ColorH8000000F;
                cmdOGar.BackColor = Utils.ZeroIfNull(readerC["OGS"]) > 0 ? MozartColors.ColorH80FFFF : MozartColors.ColorH8000000F;
                cmdPrest.BackColor = Utils.ZeroIfNull(readerC["APREST"]) > 0 ? MozartColors.ColorH80FFFF : MozartColors.ColorH8000000F;
                cmdBor.BackColor = Utils.ZeroIfNull(readerC["BOR"]) > 0 ? MozartColors.ColorH80FFFF : MozartColors.ColorH8000000F;
                CmdPPS.BackColor = Utils.ZeroIfNull(readerC["PPS"]) > 0 ? MozartColors.ColorH80FFFF : MozartColors.ColorH8000000F;
                cmdSite.BackColor = Utils.ZeroIfNull(readerC["ENQQUAL"]) > 0 ? MozartColors.ColorH80FFFF : MozartColors.ColorH8000000F;
                cmdIS.BackColor = Utils.ZeroIfNull(readerC["DIS"]) > 0 ? MozartColors.ColorH80FFFF : MozartColors.ColorH8000000F;
                cmdOMT.BackColor = Utils.ZeroIfNull(readerC["OMT"]) > 0 ? MozartColors.ColorH80FFFF : MozartColors.ColorH8000000F;
                switch (Utils.BlankIfNull(readerC["RSD"]))
                {
                  case "RED":
                    BtnRSD.BackColor = MozartColors.ColorFF00000;
                    break;
                  case "YELLOW":
                    BtnRSD.BackColor = MozartColors.ColorH80FFFF;
                    break;
                  case "":
                    BtnRSD.BackColor = MozartColors.ColorH8000000F;
                    break;
                  default:
                    BtnRSD.BackColor = MozartColors.ColorH8000000F;
                    break;
                }

                // si AKZO NOBEL et 1 devis =
                // TB SAMSIC CITY SPEC
                if (MozartParams.NomGroupe == "EMALEC" && iClientNum == 11739 && devisExiste() && ModuleMain.RechercheDroitMenu(TxtHeuresDevis.HelpContextID))
                  TxtHeuresDevis.Visible = lblLabels48.Visible = true;
                else
                  TxtHeuresDevis.Visible = lblLabels48.Visible = false;
              }
            }

            EtapeDEBUG = 18;

            // affichage du champs obsfac si facturation ou direction ou chaff
            // on reprend les droits inscrits sur un bouton fictif pour l'affichage du champs
            if (ModuleMain.RechercheDroitMenu(213))
            {
              lblLabels9.Visible = txtObsFac.Visible = true;
            }
            else
            {
              lblLabels9.Visible = txtObsFac.Visible = false;
              txtOutils.Height = 2300 / 15;
            }

            // FG 30/04/14  droit de modification sur la date souhaitée
            if (ModuleMain.bAccesBouton("420") != 1)
              cmdSupp1.Visible = cmdDate1.Visible = false;

            EtapeDEBUG = 19;

            // si préventif, ne pas afficher les boutons de commande  sauf celui de création d'une action
            // de fourniture et celui d'inventaire si nécessaire
            if ((string)cboPrest.SelectedValue == "P")
            {
              cmdDdeStock.Enabled = cmdCommande.Enabled = false;
              // si on a une gestion de stock site pour ce client, il faut afficher le bouton
              using (SqlDataReader reader = ModuleData.ExecuteReader($"select top 1 cactif  from dbo.TSTOCKARTCLI WITH(NOLOCK) where nclinum={iClientNum}"))
              {
                if (reader.Read())
                {
                  cmdInventaire.Visible = Utils.BlankIfNull(reader["CACTIF"]) == "O";
                }
              }
            }
            else
            {
              cmdDdeStock.Enabled = cmdCommande.Enabled = true;
              cmdInventaire.Visible = false;
            }

            // on tient compte du lock de l'action
            if (lblLock.Visible)
            {
              cmdInventaire.Enabled = cmdAct.Enabled = cmdDdeStock.Enabled = cmdCommande.Enabled = false;
            }

            // bouton commission de sécurité
            //if (iTypContrat == 131 || iTypContrat == 132)
            //  CmdComSecu.Visible = ModuleMain.bAccesBouton("582") == 1;
            //else CmdComSecu.Visible = false;

            // bouton changement duree prev EI
            cmdDureeP2.Visible = iTypContrat == 247 && (string)cboPrest.SelectedValue == "P";

            EtapeDEBUG = 20;

            // gestion de la decison client
            AffichageDecisionWeb();

            EtapeDEBUG = 21;

            //gestion des messages ST du Web
            AffichageMessageSTWeb();

            EtapeDEBUG = 22;

            //bAffInfo = true;// activation des messages sous traitant

            EtapeDEBUG = 23;

            // traitement du TABLET PC
            if (MozartParams.NumActTablet != 0)
            {
              if (MozartParams.NumCSTTablet != 0)
                TabletInfoSTF();
              else
                TabletInfo();
            }

            if (ModuleMain.RechercheDroitMenu(525)) chkValidFac.Visible = true;

            // fred le 4/7/11
            // traitement du blockage des actions
            if (iLockPage == 1)
            {
              LockButtons(this.Controls);
              chkInfoSite.Enabled = false;
              txtAction.ReadOnly = true;
              optInter0.Enabled = optInter1.Enabled = optInter2.Enabled = false;
              lblLock.Visible = true;
              cmdFermer.Enabled = true;
            }
          }
        }
      }


      //catch (Exception ex) { MessageBox.Show($"{ex.Message}\r\n\r\nOuvertureEnModification ID : {EtapeDEBUG} { Resources.Global_dans}{MethodBase.GetCurrentMethod().Name}", Resources.Global_Erreur, MessageBoxButtons.OK, MessageBoxIcon.Exclamation); }
      catch (Exception ex) { Utils.ShowError(ex, $"{MethodBase.GetCurrentMethod().Name} - EtapeDEBUG : {EtapeDEBUG} dans {this.Name}"); }
    }

    private void frmDetailstravaux_FormClosed(object sender, FormClosedEventArgs e)
    {
      try
      {
        Cursor.Current = Cursors.WaitCursor;
        dtHRChantier.Dispose();

        if (cmdEnregistrer.Enabled || (!cmdEnregistrer.Enabled && !lblLock.Visible && (string)cboPrest.SelectedValue == "K"))
          ModuleData.ExecuteNonQuery($"api_sp_unlockAction {MozartParams.NumAction}");

        // envoi mail nouvelle di pour certain client (uniquement à la création de l'action)
        if ((bMail || bWeb || bCrea) && MozartParams.NumAction != 0)
          ModuleData.ExecuteNonQuery($"api_sp_SendMailNewDi {MozartParams.NumAction}");

        // TB SAMSIC CITY SPEC
        if (MozartParams.NomGroupe == "EMALEC" && iClientNum == 12544 && (bMail || bWeb))
        {
          ModuleData.ExecuteNonQuery($"api_sp_SendMailNewDiMailWeb {MozartParams.NumAction}");
          bWeb = bMail = false;
        }

        // envoi mail mediapost si validation d'une demande web d'un site (uniquement à la création)
        // TB SAMSIC CITY SPEC
        //if (bWeb && MozartParams.NomGroupe == "EMALEC" && iClientNum == 12015)
        //  ModuleData.ExecuteNonQuery($"api_sp_SendMailNewDiMediaPost {MozartParams.NumAction}");
        bWeb = false;

        // envoi mail la poste
        // TB SAMSIC CITY SPEC
        if (bMail && MozartParams.NomGroupe == "EMALEC" && (iClientNum == 11977 || iClientNum == 11338))
          ModuleData.ExecuteNonQuery($"api_sp_SendMailNewDiMail {MozartParams.NumAction}");
        bMail = false;

        // TODO automatique avec anchor?
        //    'Positionnement sur serveur TS et société EMALEC des boutons, pour le poste de Jean, on teste selon la resolution de l'ecran
        //    If ((gstrNomPoste = "SRV-VMTS03" Or gstrNomPoste = "SRV-VMTS02" Or gstrNomPoste = "FRLYVS-TS03" Or gstrNomPoste = "FRLYVS-TS02" Or gstrNomPoste = "FRLYVS-TS01" Or gstrNomPoste = "SRV-VMTS01" Or gstrNomPoste = "FRLY3VS-TS04") And Screen.height < 15360) Then 'And gstrNomSociete = "EMALEC"
        //    
        //      Erase largeurbouton(), hauteurbouton(), leftbouton(), topbouton(), tcaractere()
        //      Set ctrl = Nothing
        //      Set maform = Nothing
        //    
        //    End If

        sModeReadOnly = "";
        MozartParams.NumActTablet = 0;
        MozartParams.NumCSTTablet = 0;
        bCreaWeb = false;
      }
      //catch (Exception ex) { MessageBox.Show($"{ex.Message}\r\n\r\n{Resources.Global_dans}{MethodBase.GetCurrentMethod().Name}", Resources.Global_Erreur, MessageBoxButtons.OK, MessageBoxIcon.Exclamation); }
      catch (Exception ex) { Utils.ShowError(ex, $"{MethodBase.GetCurrentMethod().Name} dans {this.Name}"); }
      finally { Cursor.Current = Cursors.Default; }
    }

    private void cmdAidePlanif_Click(object sender, System.EventArgs e)
    {
      if (txtDateA0.Text == "") return;
      // si statut <> 'O' et tech
      if ((string)cboEtat.SelectedValue != "O")
      {
        MessageBox.Show(Resources.msg_planifier_statut_O, Program.AppTitle, MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
        return;
      }

      // il faut que l'on puisse planifier
      Cursor.Current = Cursors.WaitCursor;
      miLocTech = 0;
      frmAidePlanif frm = new frmAidePlanif();
      frm.msClient = txtClient.Text;
      frm.msSite = txtSite.Text;
      frm.mdDate = Convert.ToDateTime(txtDateA0.Text).Date;
      frm.msTypeAction = cboPrest.Text;
      frm.msAction = txtAction.Text;
      frm.msStatut = txtDateA1.Text == "" ? "Select" : "Visu";
      frm.miSite = iSiteNum;
      // recherche des infos à afficher
      using (SqlDataReader reader = ModuleData.ExecuteReader($"select VSITCP, VSITVIL from TSIT where NSITNUM={iSiteNum}"))
      {
        if (reader.Read())
        {
          frm.msVille = Utils.BlankIfNull(reader["VSITVIL"]);
          frm.msCP = Utils.BlankIfNull(reader["VSITCP"]);
        }
      }
      frm.ShowDialog();

      // retour avec un numéro de tech
      if (frm.miLocTech != 0)
      {
        miLocTech = frm.miLocTech;
        txtInter.Tag = miLocTech;
        txtPort.Text = "";
        txtFixe.Text = "";
        optInter0.Checked = frm.mbOptInter0;
        optInter1.Checked = frm.mbOptInter1;
        optInter2.Checked = frm.mbOptInter2;
        txtDateA1.Text = frm.msTxtDate1;
        // On va directos au planning dans le cas du techos
        if (optInter0.Checked)
        {
          if ((string)cboEtat.SelectedValue == "A")
            cboEtat.SelectedValue = 'O';// 'cboEtat.Text = "§A planifier§"   FG le 03/02/15
          cmdPlanifier_Click(sender, e);
        }
      }
    }

    private void Image1_Click(object sender, EventArgs e)
    {
      new frmBrowser { msStartingAddress = $"https://maps.emalec.com/TechniciensEtSite.asp?BASE=MULTI&APP={MozartParams.NomSociete}&NSITNUM={iSiteNum}" }.ShowDialog();
    }
    //Private Sub Image1_Click()
    //  
    //  frmBrowser.StartingAddress = "http://maps.emalec.com/TechniciensEtSite.asp?BASE=MULTI&APP=" & gstrNomSociete & "&NSITNUM=" & iSiteNum
    //  frmBrowser.Show vbModal
    //
    //End Sub
    //
    /* --------------------------------------------------------------------------------------- */
    private void Image2_Click(object sender, EventArgs e)
    {
      try
      {
        Cursor.Current = Cursors.WaitCursor;
        using (SqlDataReader reader = ModuleData.ExecuteReader($"SELECT VSITNOM + ' - ' + Isnull(VSITAD1, '') + ' ' + Isnull(VSITAD2, '') + ' - ' + Isnull(VSITCP, '') + ' ' + Isnull(VSITVIL, '') + ' - ' + Isnull(VSITPAYS, '') as ADR, FSITLAT LAT, FSITLON LON FROM TSIT WHERE NSITNUM = {iSiteNum}"))
        {
          if (reader.Read())
            new frmBrowser { msStartingAddress = $"https://maps.emalec.com/SiteParPoint.asp?NOM={Utils.BlankIfNull(reader["ADR"])}&LAT={Utils.BlankIfNull(reader["LAT"])}&LON={Utils.BlankIfNull(reader["LON"])}" }.ShowDialog();
        }
      }
      //catch (Exception ex) { MessageBox.Show($"{ex.Message}\r\n\r\n{Resources.Global_dans}{MethodBase.GetCurrentMethod().Name}", Resources.Global_Erreur, MessageBoxButtons.OK, MessageBoxIcon.Exclamation); }
      catch (Exception ex) { Utils.ShowError(ex, $"{MethodBase.GetCurrentMethod().Name} dans {this.Name}"); }
      finally { Cursor.Current = Cursors.Default; }
    }
    //Private Sub Image2_Click()
    //
    //On Error GoTo handler
    //  
    //  If iSiteNum = 0 Or IsNull(iSiteNum) Then Exit Sub
    //  
    //  Screen.MousePointer = vbHourglass
    //  
    //  Dim rsLatLon As New Recordset
    //  rsLatLon.Open "SELECT VSITNOM + ' - ' + Isnull(VSITAD1, '') + ' ' + Isnull(VSITAD2, '') + ' - ' + Isnull(VSITCP, '') + ' ' + Isnull(VSITVIL, '') + ' - ' + Isnull(VSITPAYS, '') as ADR, FSITLAT LAT, FSITLON LON FROM TSIT WHERE NSITNUM = " & iSiteNum, cnx, adOpenForwardOnly, adLockOptimistic
    //  frmBrowser.StartingAddress = "http://maps.emalec.com/SiteParPoint.asp?NOM=" & rsLatLon!adr & "&LAT=" & rsLatLon!lat & "&LON=" & rsLatLon!lon
    //  frmBrowser.Show vbModal
    //  rsLatLon.Close
    //  
    //  Screen.MousePointer = vbDefault
    //   
    //Exit Sub
    //handler:
    //  Screen.MousePointer = vbDefault
    //End Sub
    //
    /* --------------------------------------------------------------------------------------- */
    private void Image4_Click(object sender, EventArgs e)
    {
      if (txtSite.Text == "Tous sites du client") return;

      // on affiche la fenetre de saisie des horaires
      new frmSaisieHoraire { miNumCli = iClientNum, miNumSit = iSiteNum }.ShowDialog();
    }

    //End Sub
    //
    //'Private Sub chkPPSdem_Click()
    //'  If chkPPSdem Then
    //'    chkPPSrec.Visible = True
    //'  Else
    //'    chkPPSrec.Visible = False
    //'  End If
    //'End Sub
    //
    /* --------------------------------------------------------------------------------------- */
    private void lblLabels_Click(object sender, EventArgs e)
    {
      switch ((sender as Label).Name)
      {
        case "lblLabels9":
          new frmZoomText { msChamp = "VACTOBSFAC", NumAction = MozartParams.NumAction }.ShowDialog();
          break;
        case "lblLabels10":
          new frmZoomText { msChamp = "VACTOUT", NumAction = MozartParams.NumAction }.ShowDialog();
          break;
        case "lblLabels11":
          new frmZoomText { msChamp = "VACTFOU", NumAction = MozartParams.NumAction }.ShowDialog();
          break;
        case "lblLabels13":
          new frmZoomText { msChamp = "VACTDES", NumAction = MozartParams.NumAction }.ShowDialog();
          break;
        case "lblLabels16":
          new frmZoomText { msChamp = "VACTOBS", NumAction = MozartParams.NumAction }.ShowDialog();
          break;
        case "lblLabelObsM":
          new frmZoomText { msChamp = "VACTOBSM", NumAction = MozartParams.NumAction }.ShowDialog();
          break;
      }
    }

    /* --------------------------------------------------------------------------------------- */
    private void optInter_CheckedChanged(object sender, EventArgs e)
    {
      try
      {
        // on vide la liste
        if (!bChangeprest)
        {
          txtContact.Text = txtInter.Text = "";
          txtContact.Tag = txtInter.Tag = null;
        }

        // on recharge la bonne liste
        if ((sender as RadioButton).Name == "optInter0")// technicien
        {
          txtMontantDevis.Visible = lblMontantdevis.Visible = cboDevis.Visible = lblDevis.Visible = lblContact.Visible = txtContact.Visible = cmdVisuDevisSTT.Visible = false;
          ApiTelAuto3.Visible = lblRelFac.Visible = txtTelAstr.Visible = lblAstr.Visible = txtDevWeb.Visible = lblDevWeb.Visible = false;
          cmdStt.Visible = cmdNotation.Visible = CboPPS.Visible = LblPPS.Visible = chkRel.Visible = CmdCtct.Visible = false;
          cmdComp.Visible = cmdHabilitation.Visible = true;

          SetVisibleChkDevisAttenteCheckBox();

          // gestion si action chantier
          if (bNCANChantier)
          {
            // recalcul des heures fiches sauf pour BE ou CT
            // si ca ou be sur compte chantier
            string sTypePer = DetailstravauxUtils.RechercheFonctionByPers(!optInter0.Checked ? 0 : txtInter.Tag == null ? 0 : (int)txtInter.Tag);
            if (sTypePer == "AS" || sTypePer == "FA")
            {
              txtduree.BackColor = Color.White;
              txtduree.ReadOnly = false;
            }
            else
            {
              if (txtInter.Tag == null)
              {
                txtduree.BackColor = Color.White;
                txtduree.ReadOnly = false;
              }
              else
              {
                if (bModif && txtduree.Text != "")
                {
                  if (dtHRChantier.Rows.Count == 0)
                    txtduree.Text = "0";
                  else
                    txtduree.Text = TotHrChantier().ToString();
                }
                txtduree.BackColor = Color.Yellow;
                txtduree.ReadOnly = true;
              }
            }
          }
        }
        else
        {// sous traitant
         // modif du 24/05/2018 par MC : gestion des droits
         // si optionbutton not visible alors on passe les bouton en non visible
          if (ModuleMain.bAccesBouton((sender as apiRadioButton).HelpContextID.ToString()) == 0)
          {
            txtDevWeb.Visible = lblDevWeb.Visible = txtMontantDevis.Visible = lblMontantdevis.Visible = cboDevis.Visible = lblDevis.Visible = false;
            ApiTelAuto3.Visible = txtTelAstr.Visible = lblAstr.Visible = true;
            CboPPS.Visible = LblPPS.Visible = cmdStt.Visible = cmdNotation.Visible = chkRel.Visible = CmdCtct.Visible = lblRelFac.Visible = false;
            cmdComp.Visible = cmdHabilitation.Visible = cmdDocSTT.Visible = false;

          }
          else
          {
            lblContact.Visible = txtContact.Visible = true;
            ApiTelAuto3.Visible = txtTelAstr.Visible = lblAstr.Visible = true;
            cmdDocSTT.Visible = CboPPS.Visible = LblPPS.Visible = cmdStt.Visible = cmdNotation.Visible = CmdCtct.Visible = true;
            cmdComp.Visible = cmdHabilitation.Visible = false;

            //modif du 13/05/2024 par PC fait pas MC
            lblDevWeb.Visible = txtDevWeb.Visible = ModuleMain.RechercheDroitMenu(txtDevWeb.HelpContextID);
            chkRel.Visible = lblRelFac.Visible = ModuleMain.RechercheDroitMenu(lblRelFac.HelpContextID);
            lblDevis.Visible = cboDevis.Visible = ModuleMain.RechercheDroitMenu(lblDevis.HelpContextID);
            cmdVisuDevisSTT.Visible = lblMontantdevis.Visible = txtMontantDevis.Visible = ModuleMain.RechercheDroitMenu(lblDevis.HelpContextID);

          }
          SetVisibleChkDevisAttenteCheckBox();
          // gestion si action chantier
          if (bNCANChantier)
          {
            // recalcul des heures fiches
            if (dtHRChantier.Rows.Count == 0)
              txtduree.Text = "0";
            else
              txtduree.Text = TotHrChantier().ToString();

            if (MozartParams.NomSociete != "EMALECMPM")
            {
              txtduree.BackColor = Color.White;
              txtduree.ReadOnly = false;
            }
            else
            {
              txtduree.BackColor = Color.Yellow;
              txtduree.ReadOnly = true;
            }
          }
        }
      }
      //catch (Exception ex) { MessageBox.Show($"{ex.Message}\r\n\r\n{Resources.Global_dans}{MethodBase.GetCurrentMethod().Name}", Resources.Global_Erreur, MessageBoxButtons.OK, MessageBoxIcon.Exclamation); }
      catch (Exception ex) { Utils.ShowError(ex, $"{MethodBase.GetCurrentMethod().Name} dans {this.Name}"); }
    }

    /* --------------------------------------------------------------------------------------- */
    private void optInter_MouseDown(object sender, MouseEventArgs e)
    {
      try
      {
        // si le technicien est l'administrateur
        // alors on bloque l'accès à la modif car on est en etat a planifier manuellement
        if (txtInter.Tag != null && (int)txtInter.Tag == 10)
        {
          MessageBox.Show(Resources.msg_pour_modif_intervenant_passer_par_planning, Program.AppTitle, MessageBoxButtons.OK, MessageBoxIcon.Information);
          return;
        }

        // si le statut est 'exécuté' ou plus, pas de modification possible
        if ((string)cboEtat.SelectedValue == "E")
        {
          MessageBox.Show($"{Resources.msg_modif_intervenant_impossible}{Environment.NewLine}{Resources.msg_statut_permet_pas}", Program.AppTitle, MessageBoxButtons.OK, MessageBoxIcon.Information);
          return;
        }

        // si le statut est 'Planifier', pas de modification possible
        if ((string)cboEtat.SelectedValue == "P")
        {
          MessageBox.Show(Resources.msg_sup_planif_avant_change_intervenant, Program.AppTitle, MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
          return;
        }
        else txtDateA1.Text = "";
      }
      //catch (Exception ex) { MessageBox.Show($"{ex.Message}\r\n\r\n{Resources.Global_dans}{MethodBase.GetCurrentMethod().Name}", Resources.Global_Erreur, MessageBoxButtons.OK, MessageBoxIcon.Exclamation); }
      catch (Exception ex) { Utils.ShowError(ex, $"{MethodBase.GetCurrentMethod().Name} dans {this.Name}"); }
    }
    //Private Sub optInter_MouseDown(Index As Integer, Button As Integer, Shift As Integer, X As Single, Y As Single)
    //
    //On Error GoTo handler
    //
    //
    //  ' si le technicien est l'administrateur
    //  ' alors on bloque l'accès à la modif car on est en etat a planifier manuellement
    //  If txtInter.Tag = "10" Then
    //    MsgBox "§Pour modifier l'intervenant passer par le planning§"
    //    Exit Sub
    //  End If
    //
    //  ' si le statut est 'exécuté' ou plus, pas de modification possible
    //  If Chr(Me.cboEtat.ItemData(cboEtat.ListIndex)) = "E" Then
    //    MsgBox "§Impossible de modifier l'intervenant :§" & vbCrLf & "§Le statut ne le permet pas§", vbInformation
    //    Exit Sub
    //  End If
    // 
    //  ' si le statut est 'Planifier', pas de modification possible
    //  If Chr(Me.cboEtat.ItemData(cboEtat.ListIndex)) = "P" Then
    //    MsgBox "§Il faut supprimer la planification avant de changer l'intervenant !§", vbInformation
    //    Exit Sub
    //  Else
    //    txtDateA(1) = ""
    //  End If
    //
    //
    //Exit Sub
    //handler:
    //  ShowError "optInter_MouseDown dans " & Me.Name
    //End Sub
    //
    /* --------------------------------------------------------------------------------------- */
    private void Timer1_Tick(object sender, EventArgs e)
    {
      // Changement de contrôle car ne focntionne pas en mode ActiveX
      if (lblDevis.BackColor == MozartColors.ColorHC0E0FF)
        lblDevis.BackColor = Color.Red;// &HFF&
      else
        lblDevis.BackColor = MozartColors.ColorHC0E0FF;
    }
    //Private Sub Timer1_Timer()
    //
    //  ' clignotement du text relance
    //  'If cboDevis.BackColor = &HC0FFC0 Then
    //  '  cboDevis.BackColor = &HFF&
    //  'Else
    //  '  cboDevis.BackColor = &HC0FFC0
    //  'End If
    //  ' Changement de contrôle car ne focntionne pas en mode ActiveX
    //  If lblDevis.BackColor = &HC0E0FF Then
    //    lblDevis.BackColor = &HFF&
    //  Else
    //    lblDevis.BackColor = &HC0E0FF
    //  End If
    //  
    //End Sub
    //
    /* --------------------------------------------------------------------------------------- */
    private void Timer3_Tick(object sender, EventArgs e)
    {
      // ouverture d'une fenetre d'information
      DetailstravauxUtils.Info InfoSite = DetailstravauxUtils.RechercheInfos("INFO_SITE", iSiteNum);
      if (InfoSite.strInfo != "" && InfoSite.DateValDeb < DateTime.Now && InfoSite.DateValFin > DateTime.Now)
      {
        new frmInfosClient
        {
          msStatut = "S",// site
          msInfo = InfoSite.strInfo
        }.ShowDialog();
      }
      Timer3.Enabled = false;
    }
    //Private Sub Timer3_Timer()
    //Dim InfoSite As Info
    //  
    //  ' ouverture d'une fenetre d'information
    //  InfoSite = RechercheInfos("INFO_SITE", iSiteNum)
    //  If InfoSite.strInfo <> "" And InfoSite.DateValDeb < Date And InfoSite.DateValFin > Date Then
    //    frmInfosClient.strStatut = "S"    ' site
    //    frmInfosClient.strInfo = InfoSite.strInfo
    //    frmInfosClient.Show vbModal
    //  End If
    //
    //  Timer3.Enabled = False
    //
    //End Sub
    //
    //
    //
    /* --------------------------------------------------------------------------------------- */
    private void txtAction_MouseDown(object sender, MouseEventArgs e)
    {
      if (e.Button == MouseButtons.Right)
      {
        txtAction.SuspendLayout();
        txtAction.Enabled = false;

        MnuLibAction.Show(Cursor.Position);

        // Enable the control again
        txtAction.Enabled = true;
        txtAction.Focus();
        txtAction.ResumeLayout();
      }
    }
    //Private Sub txtAction_MouseDown(Button As Integer, Shift As Integer, X As Single, Y As Single)
    //
    //    If Button = vbRightButton Then
    //
    //        LockWindowUpdate txtAction.hwnd
    //
    //        ' Enable the control again
    //        txtAction.Enabled = False
    //
    //        ' Give the previous line time to complete
    //        DoEvents
    //
    //        'La méthode PopUpMenu permet de faire apparaître des menus contextuels.
    //        PopupMenu MnuLibAction, vbPopupMenuCenterAlign
    //
    //        ' Enable the control again
    //        txtAction.Enabled = True
    //
    //        txtAction.SetFocus
    //
    //        ' Unlock updates
    //        LockWindowUpdate 0&
    //
    //    End If
    //
    //End Sub
    //
    //
    /* --------------------------------------------------------------------------------------- */
    private void txtduree_Click(object sender, EventArgs e)
    {
      FrameFicheHRSuivi.Top = 1000 / 15;
      FrameFicheHRSuivi.Left = 6000 / 15;

      FrameFicheHRSuivi.Height = 10000 / 15;
      FrameFicheHRSuivi.Width = 9035 / 15;
      apiTGridHrChantier.Height = FrameFicheHRSuivi.Height - 960 / 15;
      apiTGridHrChantier.Width = FrameFicheHRSuivi.Width - apiTGridHrChantier.Left - 180 / 15;

      cmdvaliderFicHRSuivi.Top = FrameFicheHRSuivi.Height - cmdvaliderFicHRSuivi.Height - 180 / 15;
      cmdvaliderFicHRSuivi.Left = FrameFicheHRSuivi.Width - cmdvaliderFicHRSuivi.Width - 255 / 15;

      if (bNCANChantier)
      {
        if (!bDroitVisa && (chkVisaArr.Checked || chkVisaExec.Checked))
        {
          MessageBox.Show(Resources.msg_date_arrive_exec_verif_duree_non_modifiable, Program.AppTitle, MessageBoxButtons.OK, MessageBoxIcon.Information);
          return;
        }

        // si ca ou be sur compte chantier
        string sTypePer = DetailstravauxUtils.RechercheFonctionByPers(optInter0.Checked && txtInter.Tag != null ? (int)txtInter.Tag : 0);

        // si stf selectionner et hors mpm, alors on mais ne fait pas de test
        if ((optInter1.Checked || optInter3.Checked || optInter3.Checked) && MozartParams.NomSociete != "EMALECMPM") return;

        if (txtInter.Tag == null && optInter0.Checked) return;

        // si aucune fiche heure n'existe pas alors message
        if (dtHRChantier.Rows.Count == 0 && sTypePer != "AS" && sTypePer != "FA")
        {
          MessageBox.Show("Il n'y a pas de fiche Heures sur ce compte analytique", Program.AppTitle, MessageBoxButtons.OK, MessageBoxIcon.Information);
          LoadHRChantier();
          return;
        }

        FrameFicheHRSuivi.Visible = !(sTypePer == "AS" && sTypePer == "FA");
      }
      else FrameFicheHRSuivi.Visible = false;
    }
    //Private Sub txtduree_Click()
    //
    //  FrameFicheHRSuivi.Top = 1000
    //  FrameFicheHRSuivi.Left = 6000
    //
    //  FrameFicheHRSuivi.height = 10000
    //  FrameFicheHRSuivi.width = 9035
    //  apiTGridHrChantier.height = FrameFicheHRSuivi.height - 960
    //  apiTGridHrChantier.width = FrameFicheHRSuivi.width - apiTGridHrChantier.Left - 180
    //  
    //  cmdvaliderFicHRSuivi.Top = FrameFicheHRSuivi.height - cmdvaliderFicHRSuivi.height - 180
    //  cmdvaliderFicHRSuivi.Left = FrameFicheHRSuivi.width - cmdvaliderFicHRSuivi.width - 255
    //  
    //  If bNCANChantier = True Then
    //      If Not bDroitVisa And (chkVisaArr Or chkVisaExec) Then
    //        MsgBox "§La date d'arrivée ou date d'exécution ont été vérifiées, la durée n'est plus modifiable!§", vbInformation
    //        Exit Sub
    //      End If
    //     
    //      'si ca ou be sur compte chantier
    //      Dim sTypePer As String
    //      sTypePer = RechercheFonctionByPers(IIf(Me.optInter(0).value = 0, 0, IIf(txtInter.Tag = "", 0, txtInter.Tag)))
    //      
    //      
    //      'si stf selectionner et hors mpm, alors on mais ne fait pas de test
    //      If ((optInter(1).value = True Or optInter(2).value = True Or optInter(3).value = True) And gstrNomSociete <> "EMALECMPM") Then
    //            Exit Sub
    //      End If
    //            
    //      If txtInter.Tag = "" And optInter(0).value = True Then Exit Sub
    //      
    //       'si aucune fiche heure n'existe pas alors message
    //      If adorsHRChantier.RecordCount = 0 And sTypePer <> "AS" And sTypePer <> "FA" Then
    //        MsgBox "Il n'y a pas de fiche Heures sur ce compte analytique", vbInformation
    //        LoadHRChantier
    //        Exit Sub
    //      End If
    //          
    //      If sTypePer = "AS" Or sTypePer = "FA" Then
    //        FrameFicheHRSuivi.Visible = False
    //      Else
    //        
    //        FrameFicheHRSuivi.Visible = True
    //        
    //        'MISE EN COM LE 18/03/2019 PAR MAIL DE THOMAS BAUX SCS, ON LAISSE COMME AVANT
    //        'si action planifié ou execute alors on ne peut aps modifier les fiches ehures
    //'        If txtDateA(1).Text <> "" Or txtDateA(2).Text <> "" Then
    //'            apiTGridHrChantier.Columns.Item("NACTCHANTIERVAL").Locked = True
    //'        Else
    //'            apiTGridHrChantier.Columns.Item("NACTCHANTIERVAL").Locked = False
    //'        End If
    //'
    //        
    //      End If
    //  
    //      
    //  Else
    //      FrameFicheHRSuivi.Visible = False
    //  End If
    //End Sub
    //
    /* --------------------------------------------------------------------------------------- */
    private void txtduree_KeyPress(object sender, KeyPressEventArgs e)
    {
      if (!bDroitVisa && (chkVisaArr.Checked || chkVisaExec.Checked))
      {
        MessageBox.Show(Resources.msg_date_arrive_exec_verif_duree_non_modifiable, Program.AppTitle, MessageBoxButtons.OK, MessageBoxIcon.Information);
        e.Handled = true;
        return;
      }
      // Contrôle de numéricité avec virgule
      KeyValidator.KeyPress_SaisieMontant(e);
    }
    //Private Sub txtduree_KeyPress(KeyAscii As Integer)
    //  
    //  If Not bDroitVisa And (chkVisaArr Or chkVisaExec) Then
    //    MsgBox "§La date d'arrivée ou date d'exécution ont été vérifiées, la durée n'est plus modifiable!§", vbInformation
    //    KeyAscii = 0
    //    Exit Sub
    //  End If
    //  
    //  ' Contrôle de numéricité
    //  If KeyAscii = 8 Then Exit Sub
    //  If KeyAscii = 46 Then KeyAscii = 44
    //  If KeyAscii = 44 Then Exit Sub  'pour la virgule
    //  If KeyAscii < 48 Or KeyAscii > 57 Then KeyAscii = 0
    //End Sub
    //
    //
    /* --------------------------------------------------------------------------------------- */
    private void txtMontantDevis_KeyPress(object sender, KeyPressEventArgs e)
    {
      KeyValidator.KeyPress_SaisieMontant(e);
    }
    //Private Sub txtMontantDevis_KeyPress(KeyAscii As Integer)
    //' Contrôle de numéricité
    //  If KeyAscii = 8 Then Exit Sub
    //  If KeyAscii = 46 Then KeyAscii = 44
    //  If KeyAscii = 44 Then Exit Sub  'pour la virgule
    //  If KeyAscii < 48 Or KeyAscii > 57 Then KeyAscii = 0
    //
    //End Sub
    //
    /* --------------------------------------------------------------------------------------- */
    private void txtNbHeurPart_KeyPress(object sender, KeyPressEventArgs e)
    {
      KeyValidator.KeyPress_SaisieNombre(e);
    }

    //'certains caracteres sont interdit pour le rtf
    /* --------------------------------------------------------------------------------------- */
    private void txtNumCde_KeyPress(object sender, KeyPressEventArgs e)
    {
      // interdir les caractères : {}\
      if ((int)e.KeyChar == 123 || (int)e.KeyChar == 125 || (int)e.KeyChar == 92) e.Handled = true;
    }

    private void txtObserv_Enter(object sender, EventArgs e)
    {
      // traitement spécifique car l'évennement est déclenché 2 fois de suite
      // cela pose problème car soit on a pas le focus dans TxtObs, soit on ne peut plus selectionner le texte dans TxtObserv (car on va directement dans TxtObs)
      NbEvenement = NbEvenement + 1;
      if (NbEvenement > 2) return;

      framObs.Top = 8000 / 15;
      framObs.Left = 3600 / 15;
      framObs.Visible = true;
      TxtObs.Focus();

    }

    private void txtValeur_KeyPress(object sender, KeyPressEventArgs e)
    {
      // Contrôle de numéricité
      KeyValidator.KeyPress_SaisieMontant(e);// avec virgule
    }
    //Private Sub txtValeur_KeyPress(KeyAscii As Integer)
    //  ' Contrôle de numéricité
    //  If KeyAscii = 8 Then Exit Sub
    //  If KeyAscii = 46 Then KeyAscii = 44
    //  If KeyAscii = 44 Then Exit Sub  'pour la virgule
    //  If KeyAscii < 48 Or KeyAscii > 57 Then KeyAscii = 0
    //End Sub
    //
    /* --------------------------------------------------------------------------------------- */
    private void EnregistrerAction()
    {
      int EtapeDEBUG = 0;
      try
      {
        // pour la création ou la modification, c'est la proc stock qui gère
        // création d'une commande
        using (SqlCommand cmd = new SqlCommand("api_sp_creationAction", MozartDatabase.cnxMozart))
        {
          cmd.CommandType = CommandType.StoredProcedure;
          SqlCommandBuilder.DeriveParameters(cmd);    // liste des paramètres

          // liste des paramètres
          cmd.Parameters["@iDI"].Value = MozartParams.NumDi;
          cmd.Parameters["@iAction"].Value = MozartParams.NumAction;
          cmd.Parameters["@LibAction"].Value = txtAction.Text.Trim();
          cmd.Parameters["@dDateS"].Value = txtDateA0.Text == "" ? DBNull.Value : (object)Convert.ToDateTime(txtDateA0.Text);
          cmd.Parameters["@iSite"].Value = iSiteNum;
          cmd.Parameters["@cUrg"].Value = (string)cboUrg.SelectedValue;
          cmd.Parameters["@cprest"].Value = (string)cboPrest.SelectedValue;
          cmd.Parameters["@cTech"].Value = (string)cboTech.SelectedValue;
          cmd.Parameters["@cTypeAct"].Value = "A";
          cmd.Parameters["@iDuree"].Value = txtduree.Text == "" ? DBNull.Value : (object)Convert.ToDouble(txtduree.Text);
          cmd.Parameters["@iValeur"].Value = txtValeur.Text == "" ? DBNull.Value : (object)Convert.ToDouble(txtValeur.Text);
          if (txtDateA2.Text == "")
            cmd.Parameters["@dDateEx"].Value = DBNull.Value;
          else
            cmd.Parameters["@dDateEx"].Value = Convert.ToDateTime($"{Convert.ToDateTime(txtDateA2.Text).ToShortDateString()} {cboHE.Text}:{cboME.Text}:{nSecondTempDatExe}").ToString("dd-MM-yyyy HH:mm:ss");
          cmd.Parameters["@cTypeInter"].Value = CodeTypeSTF();
          cmd.Parameters["@iTech"].Value = optInter0.Checked && txtInter.Tag != null ? txtInter.Tag : DBNull.Value;
          cmd.Parameters["@iST"].Value = !optInter0.Checked && txtContact.Tag != null ? txtContact.Tag : DBNull.Value;
          cmd.Parameters["@cAttach"].Value = txtAttach.Text;
          cmd.Parameters["@vObserv"].Value = txtObserv.Text;
          cmd.Parameters["@vObservM"].Value = txtObservM.Text;
          cmd.Parameters["@vOutil"].Value = txtOutils.Text;
          cmd.Parameters["@vFour"].Value = txtFour.Text;
          cmd.Parameters["@dDatePla"].Value = txtDateA1.Text == "" ? DBNull.Value : (object)Convert.ToDateTime(txtDateA1.Text);
          cmd.Parameters["@cEtat"].Value = (string)cboEtat.SelectedValue;
          cmd.Parameters["@cNuit"].Value = chkNuit.Checked ? "O" : chkNonPublic.Checked ? "P" : "N";
          cmd.Parameters["@cCMD"].Value = chkCMD.Checked ? 'O' : 'N';
          cmd.Parameters["@vDevis"].Value = cboDevis.Text;
          cmd.Parameters["@mDevis"].Value = txtMontantDevis.Text;
          cmd.Parameters["@vRelFactST"].Value = chkRel.Checked ? 1 : 0;// ancien numero de facture utilisé maintenant pour la gestion des relances
          cmd.Parameters["@vFactBudg"].Value = txtDevWeb.Text;
          cmd.Parameters["@vRDV"].Value = txtRDV.Text;
          cmd.Parameters["@vNumCde"].Value = txtNumCde.Text;
          cmd.Parameters["@vInfoQui"].Value = txtQui.Text;
          cmd.Parameters["@nNbHPart"].Value = Utils.ZeroIfBlank(txtNbHeurPart.Text);
          cmd.Parameters["@ObsFac"].Value = txtObsFac.Text;
          cmd.Parameters["@BlocagePave"].Value = txtWhyBlocage.Text;
          cmd.Parameters["@nPPs"].Value = CboPPS.SelectedIndex == -1 ? 0 : CboPPS.SelectedIndex;
          cmd.Parameters["@dDateCde"].Value = txtDateA4.Text == "" ? DBNull.Value : (object)Convert.ToDateTime(txtDateA4.Text);
          cmd.Parameters["@factureCotraitant"].Value = TxtFactBudg.Text == "" ? DBNull.Value : (object)Utils.ZeroIfBlank(TxtFactBudg.Text);
          // passage des etudes devis en hors web
          if (Strings.Left(Strings.LTrim(txtAction.Text), 4).ToUpper() == "AIDE")
            cmd.Parameters["@cVueWeb"].Value = "N";
          else if (((string)cboPrest.SelectedValue == "E" || Strings.Left(Strings.LTrim(txtAction.Text), 10).ToUpper() == "FOURNITURE") &&
                    mstrStatutAction == "C")
            cmd.Parameters["@cVueWeb"].Value = "N";
          else
            cmd.Parameters["@cVueWeb"].Value = chkWeb.Checked ? "N" : "O";

          // si accord web de "je passe commande, il faut passer en "A planifier"
          // si le statut n'est pas au dela (P ou E)
          if (MozartParams.NumDeciWeb > 0 && null != txtDeciWeb.Tag && (char)txtDeciWeb.Tag == 'C')
          {
            // test statut
            if ((string)cboEtat.SelectedValue == "A")
              cmd.Parameters["@cEtat"].Value = "W";
          }

          cmd.Parameters["@nDeciWeb"].Value = MozartParams.NumDeciWeb;
          cmd.Parameters["@nGam"].Value = (int)cboGamme.SelectedValue;
          cmd.Parameters["@cNacelle"].Value = chkNacelle.Checked ? 'O' : 'N';
          cmd.Parameters["@cMatsurSite"].Value = chkMat.Checked ? 'O' : 'N';
          cmd.Parameters["@cP5"].Value = chkP5.Checked ? 'O' : 'N';
          if (cboSemaines.Text == "")
            cmd.Parameters["@iNumSem"].Value = DBNull.Value;
          else
            cmd.Parameters["@iNumSem"].Value = cboSemaines.Text;
          cmd.Parameters["@cETATCPL"].Value = cboEtatCO.SelectedValue;
          // gestion statut admin complément uniquement sur statut "E" et Attente ou Chiffré
          // sinon on repasse le statut complémentaire à null
          if ((string)cboEtat.SelectedValue != "E")
          { cmd.Parameters["@cETATADMINCPL"].Value = DBNull.Value; }
          else
          {
            if ((string)txtEtatAdmin.Tag == "A" || (string)txtEtatAdmin.Tag == "C")
              cmd.Parameters["@cETATADMINCPL"].Value = cboEtatAdminCpl.SelectedValue;
            else
              cmd.Parameters["@cETATADMINCPL"].Value = DBNull.Value;
          }
          cmd.Parameters["@vMotCle"].Value = "";
          cmd.Parameters["@cTypCont"].Value = chkP3.Checked ? 'O' : 'N';
          cmd.Parameters["@cReclamation"].Value = chkReclam.Checked ? 'O' : 'N';
          if (txtDateA3.Text == "")
            cmd.Parameters["@dDateArr"].Value = DBNull.Value;
          else
            cmd.Parameters["@dDateArr"].Value = Convert.ToDateTime($"{Convert.ToDateTime(txtDateA3.Text).ToShortDateString()} {cboH.Text}:{cboM.Text}:{nSecondTempDatArr}").ToString("dd-MM-yyyy HH:mm:ss");
          cmd.Parameters["@nIdProcess"].Value = cboProcess.Visible ? cboProcess.SelectedValue : DBNull.Value;
          cmd.Parameters["@nIdCauseRacine"].Value = cboCauseRacine.Visible ? cboCauseRacine.SelectedValue : DBNull.Value;
          cmd.Parameters["@idEquipement"].Value = Convert.ToString(txtNumero.Tag) != "" ? txtNumero.Tag : DBNull.Value;
          cmd.Parameters["@vactHrMinRDV"].Value = cboHrRDV.Text != "" && cboMinRDV.Text != "" ? $"{cboHrRDV.Text}:{cboMinRDV.Text}" : "";
          cmd.Parameters["@cValidFac"].Value = chkValidFac.Checked ? 'O' : 'N';
          cmd.Parameters["@dDateRelance"].Value = txtDateA5.Text == "" ? DBNull.Value : (object)Convert.ToDateTime(txtDateA5.Text);
          cmd.Parameters["@ActionFR"].Value = txtActionFR.Text.Trim();
          cmd.Parameters["@cFacun"].Value = chkFact.Checked ? 'O' : 'N';
          cmd.Parameters["@cSuiviCli"].Value = chkSuiviClient.Checked ? 'O' : 'N';
          cmd.Parameters["@nQuiEstRelancer"].Value = cboInter1.GetItemData();
          cmd.Parameters["@nactn4"].Value = Utils.ZeroIfNull(chkN4.Tag);
          cmd.Parameters["@npervisaarr"].Value = Utils.ZeroIfNull(chkVisaArr.Tag);
          cmd.Parameters["@npervisaexec"].Value = Utils.ZeroIfNull(chkVisaExec.Tag);
          cmd.Parameters["@vActNumGMAO"].Value = txtNumGMAO.Text;
          cmd.Parameters["@nRelanceUrgente"].Value = chkRelanceUrgente.Checked ? 1 : 0;
          cmd.Parameters["@vactrdvplagehr"].Value = TxtRDVPlageHR0.Text != "" ? TxtRDVPlageHR0.Text + ";" + TxtRDVPlageHR1.Text : "";
          cmd.Parameters["@nNBHeuresDevis"].Value = TxtHeuresDevis.Text != "" ? (object)Convert.ToInt32(TxtHeuresDevis.Text) : DBNull.Value;
          cmd.Parameters["@CNCPCOMPTE"].Value = chkNCPriseEnCompte.Checked ? 'O' : 'N';
          cmd.Parameters["@bR_AND_D"].Value = ChkR_AND_D.Checked ? 1 : 0;
          cmd.Parameters["@vCodeFact"].Value = txtCodComptaCli.Text;
          cmd.Parameters["@BACT_DEV_ATT"].Value = ((ChkAttenteDevisTech.Checked & ChkAttenteDevisTech.Visible) ? 1 : 0);

          // exécuter la commande.
          cmd.ExecuteNonQuery();

          // récupération du numéro crée (si erreur dans la requete du trigger, retour avec 0 et risque de creation d'une nouvelle action)
          if ((int)cmd.Parameters[0].Value > 0)
            MozartParams.NumAction = (int)cmd.Parameters[0].Value;
          else
          {
            MessageBox.Show("erreur lors de l'enregistrement de l'action dans le trigger de TACT", Program.AppTitle, MessageBoxButtons.OK, MessageBoxIcon.Error);
            return;
          }
        }
        EtapeDEBUG = 1;

        // si chantier
        if (bNCANChantier)
        {
          // on vide la table de cette nactnum
          ModuleData.ExecuteNonQuery($"DELETE FROM TACTCHANTIER WHERE NACTNUM = {MozartParams.NumAction}");

          // traitement auto si chaff ou be
          if (dtHRChantier.Rows.Count > 0)
          {
            foreach (DataRow row in dtHRChantier.Rows)
              ModuleData.ExecuteNonQuery($"INSERT INTO TACTCHANTIER (NACTNUM, NIDFICHE, NACTCHANTIERVAL) VALUES ({MozartParams.NumAction},{Utils.ZeroIfNull(row["NIDFICHE"])},{Utils.ZeroIfNull(row["NACTCHANTIERVAL"])})");
          }
        }

        EtapeDEBUG = 2;
        // Test si update pour message web ST
        if (MozartParams.NumMsgSTWeb != 0)
        {
          ModuleData.ExecuteNonQuery($"UPDATE TWMESSTF SET DMESSSTFTRAITE = GETDATE() WHERE ID = {MozartParams.NumMsgSTWeb}");
          MozartParams.NumMsgSTWeb = 0;
        }

        // si on enregistre, on peut remettre la decision a vide
        MozartParams.NumDeciWeb = 0;
        EtapeDEBUG = 3;

        // si on a un matériel, on update la DI avec le contrat correspondant
        if (txtObjGidt.Tag != null)
        {
          ModuleData.ExecuteNonQuery($"UPDATE TDIN SET NTYPECONTRAT = {txtObjGidt.Tag} WHERE NDINNUM ={MozartParams.NumDi}");
          this.ModificationContrat(Convert.ToInt32(txtObjGidt.Tag));
          txtObjGidt.Tag = null;

          //Assembly assemblyExe = Assembly.GetExecutingAssembly();
          //Type objectType = assemblyExe.GetType("MozartCS.frmAddAction", false);
          //if (null != objectType)   // && objectType.GetMember("txtObjGidt_Tag").Length != 0)
          //{
          //frmAddActionVB6.txtObjGidt_Tag = txtObjGidt.Tag;
          //}
        }
        EtapeDEBUG = 4;

      }
      //catch (Exception ex) { MessageBox.Show($"{ex.Message}\r\n\r\nEnregistrerAction ID : {EtapeDEBUG} { Resources.Global_dans}{MethodBase.GetCurrentMethod().Name}", Resources.Global_Erreur, MessageBoxButtons.OK, MessageBoxIcon.Exclamation); }
      catch (Exception ex) { Utils.ShowError(ex, $"{MethodBase.GetCurrentMethod().Name} - EtapeDEBUG : {EtapeDEBUG} dans {this.Name}"); }
    }

    private void EnregistrerTousSites()
    {
      try
      {
        string sql = "";
        int numAct;
        bool bNacelle = false;

        // fenetre de choix des sites
        // mise a jour du recordset rs global (aie !)
        frmChoixMultiSites frm = new frmChoixMultiSites();
        frm.miNumClient = iClientNum;
        frm.miNumContrat = iTypContrat;
        frm.mcItemCboPrest = ((string)cboPrest.SelectedValue)[0];
        frm.mbOptInter0IsChecked = optInter0.Checked;
        frm.ShowDialog();

        AnnulerChoix = frm.mbAnnulerChoix;
        if (frm.mbAnnulerChoix) return;

        if (frm.miCboGamme != -1) cboGamme.SelectedValue = frm.miCboGamme;

        // si on reviens de choixMultiSite avec le code de création de DI par site, on fait un traitement différent
        if (frm.mbMultiDi)
        {
          EnregistrerMultiDI(frm.dtRS);
          MessageBox.Show("Les DI ont été créées pour chaque site, vous pouvez fermer la DI en cours", Program.AppTitle, MessageBoxButtons.OK, MessageBoxIcon.Information);
          return;
        }

        // boucle sur le nombre de site du client
        foreach (DataRow row in frm.dtRS.Rows)
        {
          // recherche du sous traitant imposé pour le site et le contrat
          using (SqlDataReader reader = ModuleData.ExecuteReader($"SELECT NINTNUM  FROM TCONT WITH (NOLOCK) WHERE NSITNUM = {row["Num"]} AND NTYPECONTRAT = {iTypContrat}"))
          {
            if (reader.Read())
            {
              txtContact.Tag = Convert.IsDBNull(reader[0]) ? null : (object)Convert.ToInt32(reader[0]);
            }
          }

          // création d'une commande
          using (SqlCommand cmd = new SqlCommand("api_sp_creationAction", MozartDatabase.cnxMozart))
          {
            cmd.CommandType = CommandType.StoredProcedure;
            SqlCommandBuilder.DeriveParameters(cmd);    // liste des paramètres

            // liste des paramètres
            cmd.Parameters["@iDI"].Value = MozartParams.NumDi;
            cmd.Parameters["@iAction"].Value = MozartParams.NumAction;
            cmd.Parameters["@LibAction"].Value = txtAction.Text.Trim();
            cmd.Parameters["@dDateS"].Value = txtDateA0.Text == "" ? DBNull.Value : (object)Convert.ToDateTime(txtDateA0.Text);
            cmd.Parameters["@iSite"].Value = Utils.ZeroIfNull(row["Num"]);
            cmd.Parameters["@cUrg"].Value = (string)cboUrg.SelectedValue;
            cmd.Parameters["@cprest"].Value = (string)cboPrest.SelectedValue;
            cmd.Parameters["@cTech"].Value = (string)cboTech.SelectedValue;
            cmd.Parameters["@cTypeAct"].Value = "A";
            cmd.Parameters["@mDevis"].Value = txtMontantDevis.Text;

            // cas des prèv : on recherche la durée et le montant de la prev et l'info nacelle
            if ((string)cboPrest.SelectedValue == "P")
            {
              // toujour le cas P2
              sql = $"SELECT NMONTANTINTER, NDUREEINTER, VCONTNACELLE FROM TCONT WITH (NOLOCK) WHERE NSITNUM = {row["Num"]} AND NTYPECONTRAT = {iTypContrat}";
              using (SqlDataReader readerMD = ModuleData.ExecuteReader(sql))
              {
                if (readerMD.Read())
                {
                  cmd.Parameters["@iDuree"].Value = Utils.ZeroIfNull(readerMD["NDUREEINTER"]);
                  cmd.Parameters["@iValeur"].Value = Utils.ZeroIfNull(readerMD["NMONTANTINTER"]);
                  cmd.Parameters["@cNacelle"].Value = Utils.BlankIfNull(readerMD["VCONTNACELLE"]) == "OUI" ? 'O' : 'N';
                  // on garde l'info de nacelle nécessaire
                  if (Utils.BlankIfNull(readerMD["VCONTNACELLE"]) == "OUI") bNacelle = true;
                }
              }

              // cas du montant pour les STT
              if (!optInter0.Checked)
              {
                sql = $"SELECT NMONTANTSTTP2 FROM TCONT WITH (NOLOCK) WHERE NMONTANTSTTP2 is not null  and NSITNUM = {row["Num"]} AND NTYPECONTRAT = {iTypContrat}";

                using (SqlDataReader readerMD = ModuleData.ExecuteReader(sql))
                {
                  if (readerMD.Read())
                    cmd.Parameters["@mDevis"].Value = Utils.ZeroIfNull(readerMD[0]);
                }
              }

            }
            else
            {
              cmd.Parameters["@iDuree"].Value = txtduree.Text == "" ? DBNull.Value : (object)Convert.ToDouble(txtduree.Text);
              cmd.Parameters["@iValeur"].Value = txtValeur.Text == "" ? DBNull.Value : (object)Convert.ToDouble(txtValeur.Text);
              cmd.Parameters["@cNacelle"].Value = chkNacelle.Checked ? 'O' : 'N';
            }

            cmd.Parameters["@dDateEx"].Value = txtDateA2.Text == "" ? DBNull.Value : (object)Convert.ToDateTime(txtDateA2.Text);
            cmd.Parameters["@cTypeInter"].Value = optInter0.Checked ? "T" : "S";
            cmd.Parameters["@iTech"].Value = optInter0.Checked && txtInter.Tag != null ? txtInter.Tag : DBNull.Value;
            cmd.Parameters["@iST"].Value = !optInter0.Checked && txtContact.Tag != null ? txtContact.Tag : DBNull.Value;
            cmd.Parameters["@cAttach"].Value = txtAttach.Text;
            cmd.Parameters["@vObserv"].Value = txtObserv.Text;
            cmd.Parameters["@vObservM"].Value = txtObservM.Text;
            cmd.Parameters["@vOutil"].Value = txtOutils.Text;
            cmd.Parameters["@vFour"].Value = txtFour.Text;
            cmd.Parameters["@dDatePla"].Value = txtDateA1.Text == "" ? DBNull.Value : (object)Convert.ToDateTime(txtDateA1.Text);
            cmd.Parameters["@cEtat"].Value = ((string)cboEtat.SelectedValue)[0];
            cmd.Parameters["@cNuit"].Value = chkNuit.Checked ? "O" : chkNonPublic.Checked ? "P" : "N";
            cmd.Parameters["@cCMD"].Value = chkCMD.Checked ? 'O' : 'N';
            cmd.Parameters["@vDevis"].Value = cboDevis.Text;
            cmd.Parameters["@vRelFactST"].Value = chkRel.Checked ? 1 : 0;// ancien numero de facture utilisé maintenant pour la gestion des relances
            cmd.Parameters["@vFactBudg"].Value = txtDevWeb.Text;
            cmd.Parameters["@vNumCde"].Value = txtNumCde.Text;
            cmd.Parameters["@vRDV"].Value = txtRDV.Text;
            cmd.Parameters["@nNbHPart"].Value = Utils.ZeroIfBlank(txtNbHeurPart.Text);
            cmd.Parameters["@ObsFac"].Value = txtObsFac.Text;
            cmd.Parameters["@factureCotraitant"].Value = TxtFactBudg.Text == "" ? DBNull.Value : (object)Convert.ToDouble(TxtFactBudg.Text);
            if (Strings.Left(Strings.LTrim(txtAction.Text), 4).ToUpper() == "AIDE" || (string)cboPrest.SelectedValue == "E" ||
                Strings.Left(Strings.LTrim(txtAction.Text), 10).ToUpper() == "FOURNITURE")
              cmd.Parameters["@cVueWeb"].Value = "N";
            else cmd.Parameters["@cVueWeb"].Value = chkWeb.Checked ? "N" : "O";
            cmd.Parameters["@nGam"].Value = (int)cboGamme.SelectedValue;
            cmd.Parameters["@cMatsurSite"].Value = chkMat.Checked ? 'O' : 'N';
            cmd.Parameters["@cP5"].Value = chkP5.Checked ? 'O' : 'N';
            cmd.Parameters["@cNOKplanning"].Value = chkNOK.Checked ? 'O' : 'N';
            cmd.Parameters["@vMotCle"].Value = "";
            cmd.Parameters["@cTypCont"].Value = chkP3.Checked ? 'O' : 'N';
            cmd.Parameters["@cReclamation"].Value = chkReclam.Checked ? 'O' : 'N';
            cmd.Parameters["@dDateArr"].Value = txtDateA3.Text == "" ? DBNull.Value : (object)Convert.ToDateTime(txtDateA3.Text);
            cmd.Parameters["@vactHrMinRDV"].Value = cboHrRDV.Text != "" && cboMinRDV.Text != "" ? $"{cboHrRDV.Text}:{cboMinRDV.Text}" : "";
            cmd.Parameters["@vactrdvplagehr"].Value = TxtRDVPlageHR0.Text != "" ? TxtRDVPlageHR0.Text + ";" + TxtRDVPlageHR1.Text : "";

            // exécuter la commande.
            cmd.ExecuteNonQuery();

            numAct = (int)cmd.Parameters[0].Value;// inutilisé!
          }
        }

        // FGA traitement des Nacelles
        // si  besoin, on crée automatiquement une action d'aide au tech pour les sites cochés en Nacelle
        if (bNacelle)
        {
          if (MessageBox.Show($"Vous avez coché des sites avec utilisation nacelle.\r\n" +
                  $"Souhaitez - vous créer les actions d’aide au technicien correspondantes ?", Program.AppTitle, MessageBoxButtons.YesNo,
                    MessageBoxIcon.Question, MessageBoxDefaultButton.Button2) != DialogResult.Yes)
          {
            return;
          }

          // boucle sur le nombre de site du client
          foreach (DataRow row in frm.dtRS.Rows)
          {
            // création d'une commande
            using (SqlCommand cmd = new SqlCommand("api_sp_creationAction", MozartDatabase.cnxMozart))
            {
              cmd.CommandType = CommandType.StoredProcedure;
              SqlCommandBuilder.DeriveParameters(cmd);    // liste des paramètres


              // recherche infos sur le site
              sql = $"SELECT NDUREEINTER, VCONTNACELLE FROM TCONT WITH (NOLOCK) WHERE NSITNUM = {row["Num"]} AND NTYPECONTRAT = {iTypContrat}";
              using (SqlDataReader readerMD = ModuleData.ExecuteReader(sql))
              {
                if (readerMD.Read())
                {

                  // si ce site n'est pas coché Nacelle, on passe au suivant sans création de l'action d'aide
                  if (Utils.BlankIfNull(readerMD["VCONTNACELLE"]) == "NON") continue;

                  cmd.Parameters["@iDuree"].Value = Utils.ZeroIfNull(readerMD["NDUREEINTER"]);

                }
              }

              // liste des paramètres
              cmd.Parameters["@iDI"].Value = MozartParams.NumDi;
              cmd.Parameters["@iAction"].Value = MozartParams.NumAction;
              cmd.Parameters["@LibAction"].Value = $"AIDE AU TECHNICIEN \r\n\r\n {txtAction.Text.Trim()}";
              cmd.Parameters["@dDateS"].Value = txtDateA0.Text == "" ? DBNull.Value : (object)Convert.ToDateTime(txtDateA0.Text);
              cmd.Parameters["@iSite"].Value = Utils.ZeroIfNull(row["Num"]);
              cmd.Parameters["@cUrg"].Value = (string)cboUrg.SelectedValue;
              cmd.Parameters["@cprest"].Value = (string)cboPrest.SelectedValue;
              cmd.Parameters["@cTech"].Value = (string)cboTech.SelectedValue;
              cmd.Parameters["@cTypeAct"].Value = "A";
              cmd.Parameters["@mDevis"].Value = txtMontantDevis.Text;
              cmd.Parameters["@iValeur"].Value = DBNull.Value;
              cmd.Parameters["@cNacelle"].Value = 'O';
              cmd.Parameters["@dDateEx"].Value = txtDateA2.Text == "" ? DBNull.Value : (object)Convert.ToDateTime(txtDateA2.Text);
              cmd.Parameters["@cTypeInter"].Value = optInter0.Checked ? "T" : "S";
              cmd.Parameters["@iTech"].Value = optInter0.Checked && txtInter.Tag != null ? txtInter.Tag : DBNull.Value;
              cmd.Parameters["@iST"].Value = !optInter0.Checked && txtContact.Tag != null ? txtContact.Tag : DBNull.Value;
              cmd.Parameters["@cAttach"].Value = txtAttach.Text;
              cmd.Parameters["@vObserv"].Value = txtObserv.Text;
              cmd.Parameters["@vObservM"].Value = txtObservM.Text;
              cmd.Parameters["@vOutil"].Value = txtOutils.Text;
              cmd.Parameters["@vFour"].Value = txtFour.Text;
              cmd.Parameters["@dDatePla"].Value = txtDateA1.Text == "" ? DBNull.Value : (object)Convert.ToDateTime(txtDateA1.Text);
              cmd.Parameters["@cEtat"].Value = ((string)cboEtat.SelectedValue)[0];
              cmd.Parameters["@cNuit"].Value = chkNuit.Checked ? "O" : chkNonPublic.Checked ? "P" : "N";
              cmd.Parameters["@cCMD"].Value = chkCMD.Checked ? 'O' : 'N';
              cmd.Parameters["@vDevis"].Value = cboDevis.Text;
              cmd.Parameters["@vRelFactST"].Value = 0;
              cmd.Parameters["@vFactBudg"].Value = txtDevWeb.Text;
              cmd.Parameters["@vNumCde"].Value = txtNumCde.Text;
              cmd.Parameters["@vRDV"].Value = txtRDV.Text;
              cmd.Parameters["@nNbHPart"].Value = Utils.ZeroIfBlank(txtNbHeurPart.Text);
              cmd.Parameters["@ObsFac"].Value = txtObsFac.Text;
              cmd.Parameters["@factureCotraitant"].Value = DBNull.Value;
              cmd.Parameters["@cVueWeb"].Value = "N";
              cmd.Parameters["@nGam"].Value = (int)cboGamme.SelectedValue;
              cmd.Parameters["@cMatsurSite"].Value = chkMat.Checked ? 'O' : 'N';
              cmd.Parameters["@cP5"].Value = chkP5.Checked ? 'O' : 'N';
              cmd.Parameters["@cNOKplanning"].Value = chkNOK.Checked ? 'O' : 'N';
              cmd.Parameters["@vMotCle"].Value = "";
              cmd.Parameters["@cTypCont"].Value = chkP3.Checked ? 'O' : 'N';
              cmd.Parameters["@cReclamation"].Value = chkReclam.Checked ? 'O' : 'N';
              cmd.Parameters["@dDateArr"].Value = txtDateA3.Text == "" ? DBNull.Value : (object)Convert.ToDateTime(txtDateA3.Text);
              cmd.Parameters["@vactHrMinRDV"].Value = cboHrRDV.Text != "" && cboMinRDV.Text != "" ? $"{cboHrRDV.Text}:{cboMinRDV.Text}" : "";
              cmd.Parameters["@vactrdvplagehr"].Value = TxtRDVPlageHR0.Text != "" ? TxtRDVPlageHR0.Text + ";" + TxtRDVPlageHR1.Text : "";

              // exécuter la commande.
              cmd.ExecuteNonQuery();

            }
          }
        }

      }
      catch (Exception ex) { Utils.ShowError(ex, $"{MethodBase.GetCurrentMethod().Name} dans {this.Name}"); }
    }

    private void EnregistrerTousSitesBySelectionEquipement()
    {
      try
      {

        this.Cursor = Cursors.WaitCursor;

        //tous sites avec inventaire equipement en mode création
        //sélection des contrat, site et type équipement à inventorier
        frmSelectionMultiSiteContratEquipement_Di_Inventaire ofrmSelectionMultiSiteContratEquipement_Di_Inventaire = new frmSelectionMultiSiteContratEquipement_Di_Inventaire();
        ofrmSelectionMultiSiteContratEquipement_Di_Inventaire.nclinum = iClientNum;
        ofrmSelectionMultiSiteContratEquipement_Di_Inventaire.ShowDialog();

        if (ofrmSelectionMultiSiteContratEquipement_Di_Inventaire.Dt_Affect_Equip == null)
        {
          MessageBox.Show("Il n'y a pas d'équipements affectés sur les sites du client", "Erreur", MessageBoxButtons.OK, MessageBoxIcon.Exclamation); return;
        }
        AnnulerChoix = ofrmSelectionMultiSiteContratEquipement_Di_Inventaire.mbAnnulerChoix;
        if (ofrmSelectionMultiSiteContratEquipement_Di_Inventaire.mbAnnulerChoix) return;

        // boucle sur le nombre de site du client
        //on créer une datatable des sites sélectionnés
        //ofrmSelectionMultiSiteContratEquipement_Di_Inventaire.Dt_Affect_Equip.Select("[BSELECTED] = 1").Distinct();

        //CSelectedMultiSitesInvEquip oLstSites = new CSelectedMultiSitesInvEquip();


        var distinctSites = ofrmSelectionMultiSiteContratEquipement_Di_Inventaire.Dt_Affect_Equip.AsEnumerable().Where(x => x.Field<bool>("BSELECTED") == true)
    .Select(row => new
    {
      nsitnum = row.Field<int>("nsitnum")
    })
    .Distinct().ToList();


        foreach (var row in distinctSites)
        {


          //MessageBox.Show(row.nsitnum.ToString());



          // création d'une commande
          using (SqlCommand cmd = new SqlCommand("api_sp_creationAction", MozartDatabase.cnxMozart))
          {
            cmd.CommandType = CommandType.StoredProcedure;
            SqlCommandBuilder.DeriveParameters(cmd);    // liste des paramètres

            // liste des paramètres
            cmd.Parameters["@iDI"].Value = MozartParams.NumDi;
            cmd.Parameters["@iAction"].Value = MozartParams.NumAction;
            cmd.Parameters["@LibAction"].Value = txtAction.Text.Trim();
            cmd.Parameters["@dDateS"].Value = txtDateA0.Text == "" ? DBNull.Value : (object)Convert.ToDateTime(txtDateA0.Text);
            cmd.Parameters["@iSite"].Value = Utils.ZeroIfNull(row.nsitnum);
            cmd.Parameters["@cUrg"].Value = (string)cboUrg.SelectedValue;
            cmd.Parameters["@cprest"].Value = (string)cboPrest.SelectedValue;
            cmd.Parameters["@cTech"].Value = (string)cboTech.SelectedValue;
            cmd.Parameters["@cTypeAct"].Value = "A";
            cmd.Parameters["@mDevis"].Value = txtMontantDevis.Text;

            cmd.Parameters["@iDuree"].Value = txtduree.Text == "" ? DBNull.Value : (object)Convert.ToDouble(txtduree.Text);
            cmd.Parameters["@iValeur"].Value = txtValeur.Text == "" ? DBNull.Value : (object)Convert.ToDouble(txtValeur.Text);
            cmd.Parameters["@cNacelle"].Value = chkNacelle.Checked ? 'O' : 'N';

            cmd.Parameters["@dDateEx"].Value = txtDateA2.Text == "" ? DBNull.Value : (object)Convert.ToDateTime(txtDateA2.Text);
            cmd.Parameters["@cTypeInter"].Value = optInter0.Checked ? "T" : "S";
            cmd.Parameters["@iTech"].Value = optInter0.Checked && txtInter.Tag != null ? txtInter.Tag : DBNull.Value;
            cmd.Parameters["@iST"].Value = !optInter0.Checked && txtContact.Tag != null ? txtContact.Tag : DBNull.Value;
            cmd.Parameters["@cAttach"].Value = txtAttach.Text;
            cmd.Parameters["@vObserv"].Value = txtObserv.Text;
            cmd.Parameters["@vObservM"].Value = txtObservM.Text;
            cmd.Parameters["@vOutil"].Value = txtOutils.Text;
            cmd.Parameters["@vFour"].Value = txtFour.Text;
            cmd.Parameters["@dDatePla"].Value = txtDateA1.Text == "" ? DBNull.Value : (object)Convert.ToDateTime(txtDateA1.Text);
            cmd.Parameters["@cEtat"].Value = ((string)cboEtat.SelectedValue)[0];
            cmd.Parameters["@cNuit"].Value = chkNuit.Checked ? "O" : chkNonPublic.Checked ? "P" : "N";
            cmd.Parameters["@cCMD"].Value = chkCMD.Checked ? 'O' : 'N';
            cmd.Parameters["@vDevis"].Value = cboDevis.Text;
            cmd.Parameters["@vRelFactST"].Value = chkRel.Checked ? 1 : 0;// ancien numero de facture utilisé maintenant pour la gestion des relances
            cmd.Parameters["@vFactBudg"].Value = txtDevWeb.Text;
            cmd.Parameters["@vNumCde"].Value = txtNumCde.Text;
            cmd.Parameters["@vRDV"].Value = txtRDV.Text;
            cmd.Parameters["@nNbHPart"].Value = Utils.ZeroIfBlank(txtNbHeurPart.Text);
            cmd.Parameters["@ObsFac"].Value = txtObsFac.Text;
            cmd.Parameters["@factureCotraitant"].Value = TxtFactBudg.Text == "" ? DBNull.Value : (object)Convert.ToDouble(TxtFactBudg.Text);
            if (Strings.Left(Strings.LTrim(txtAction.Text), 4).ToUpper() == "AIDE" || (string)cboPrest.SelectedValue == "E" ||
                    Strings.Left(Strings.LTrim(txtAction.Text), 10).ToUpper() == "FOURNITURE")
              cmd.Parameters["@cVueWeb"].Value = "N";
            else cmd.Parameters["@cVueWeb"].Value = chkWeb.Checked ? "N" : "O";
            cmd.Parameters["@nGam"].Value = (int)cboGamme.SelectedValue;
            cmd.Parameters["@cMatsurSite"].Value = chkMat.Checked ? 'O' : 'N';
            cmd.Parameters["@cP5"].Value = chkP5.Checked ? 'O' : 'N';
            cmd.Parameters["@cNOKplanning"].Value = chkNOK.Checked ? 'O' : 'N';
            cmd.Parameters["@vMotCle"].Value = "";
            cmd.Parameters["@cTypCont"].Value = chkP3.Checked ? 'O' : 'N';
            cmd.Parameters["@cReclamation"].Value = chkReclam.Checked ? 'O' : 'N';
            cmd.Parameters["@dDateArr"].Value = txtDateA3.Text == "" ? DBNull.Value : (object)Convert.ToDateTime(txtDateA3.Text);
            cmd.Parameters["@vactHrMinRDV"].Value = cboHrRDV.Text != "" && cboMinRDV.Text != "" ? $"{cboHrRDV.Text}:{cboMinRDV.Text}" : "";
            cmd.Parameters["@vactrdvplagehr"].Value = TxtRDVPlageHR0.Text != "" ? TxtRDVPlageHR0.Text + ";" + TxtRDVPlageHR1.Text : "";

            // exécuter la commande.
            cmd.ExecuteNonQuery();


            int NACT_INV_ID = 0;

            int numAct = (int)cmd.Parameters[0].Value;

            //on créer linventaire equipement sélectionné pour ce site et pour cette action

            //on test si un id d inventaire exists, si non on en crée un et on recupère son id
            using (SqlCommand sqlSave_Ing = new SqlCommand("[api_sp_Action_Inventaire_Equipement_Save]", MozartDatabase.cnxMozart))
            {
              sqlSave_Ing.CommandType = CommandType.StoredProcedure;
              SqlCommandBuilder.DeriveParameters(sqlSave_Ing);    // liste des paramètres

              // liste des paramètres
              sqlSave_Ing.Parameters["@P_NACT_INV_ID"].Value = NACT_INV_ID;
              sqlSave_Ing.Parameters["@P_NACTNUM"].Value = numAct;

              // exécuter la commande.
              sqlSave_Ing.ExecuteNonQuery();

              // récupération du numéro crée
              NACT_INV_ID = Convert.ToInt32(sqlSave_Ing.Parameters[0].Value);

            }

            var equipementSelected = ofrmSelectionMultiSiteContratEquipement_Di_Inventaire.Dt_Affect_Equip.AsEnumerable()
                .Where(x => x.Field<bool>("BSELECTED") == true & x.Field<int>("NSITNUM") == row.nsitnum)
                .Select(row_equip => new
                {
                  NIDEQUIPEMENT = row_equip.Field<int>("NIDEQUIPEMENT")
                })
                .Distinct().ToList();


            foreach (var rowEquipement in equipementSelected)
            {
              MozartDatabase.ExecuteNonQuery($"EXEC [api_sp_Action_Inventaire_Equipement_Element_Save] {iClientNum}, {row.nsitnum}, {rowEquipement.NIDEQUIPEMENT}, {NACT_INV_ID}, 1");
            }

            //EXEC[api_sp_Action_Inventaire_Equipement_Element_Save] iClientNum, row.nsitnum, "NIDEQUIPEMENT", 1

            //on mets à jour les heures et le montant de l'action créé selon les equipements affectés
            decimal? totalDuree = null;
            decimal? totalMontant = null;

            SqlDataReader dr = MozartDatabase.ExecuteReader($"EXEC [api_sp_GetDureeAndMontantInventaireAction] {numAct}");
            while (dr.Read())
            {
              if (dr["TOTAL_DUREE"] != DBNull.Value) totalDuree = (decimal)dr["TOTAL_DUREE"];
              if (dr["TOTAL_MONTANT"] != DBNull.Value) totalMontant = (decimal)dr["TOTAL_MONTANT"];
            }

            dr.Close();

            //update dans l'action
            List<SqlParameter> parameters = new List<SqlParameter>()
            {
                        new SqlParameter() { ParameterName = "@NumAction", SqlDbType = SqlDbType.Int, Value = numAct},
                        new SqlParameter() { ParameterName = "@totalDuree", SqlDbType = SqlDbType.Decimal, Value =  totalDuree},
                        new SqlParameter() { ParameterName = "@totalontant", SqlDbType = SqlDbType.Decimal, Value = totalMontant}
            };

            MozartDatabase.ExecuteNonQuery($"[api_sp_UpdateActionDureeAndMontant]", parameters.ToArray());

          }
        }

      }
      catch (Exception ex) { Utils.ShowError(ex, $"{MethodBase.GetCurrentMethod().Name} dans {this.Name}"); }
      finally { this.Cursor = Cursors.Default; }
    }

    private void EnregistrerTousEquipements()
    {
      try
      {
        string sql = "";
        int numAct;
        bool bSTImpose;

        // fenetre de choix des équipements pour le contrat sélectionné sur la DI
        // A FAIRE
        frmChoixMultiEquipements frm = new frmChoixMultiEquipements();
        frm.miNumClient = iClientNum;
        frm.miNumGamme = (int)cboGamme.SelectedValue;
        frm.mcCboPrest = ((string)cboPrest.SelectedValue)[0];
        frm.ShowDialog();

        if (frm.mbAnnulerChoix) return;

        if (frm.msCboGammeText != null) cboGamme.Text = frm.msCboGammeText;

        // boucle sur les équipements client pour ce contrat et ce site
        foreach (DataRow row in frm.dtRS.Rows)
        {
          // recherche du sous traitant imposé pour l'équipement, le site et le contrat
          using (SqlDataReader reader = ModuleData.ExecuteReader($"SELECT NOBJINTNUM FROM TGIDTOBJCLI WITH (NOLOCK) WHERE (VOBJSTFIMPOSE='OUI' OR VOBJSTFCOTRAITANT='OUI') AND NOBJNUM= {row["NumEquip"]}"))
          {
            if (reader.Read())
            {
              txtContact.Tag = Convert.IsDBNull(reader["NOBJINTNUM"]) ? null : (object)Convert.ToInt32(reader["NOBJINTNUM"]);
              bSTImpose = true;
            }
            else bSTImpose = false;
          }

          // création d'une commande
          using (SqlCommand cmd = new SqlCommand("api_sp_creationAction", MozartDatabase.cnxMozart))
          {
            cmd.CommandType = CommandType.StoredProcedure;
            SqlCommandBuilder.DeriveParameters(cmd);    // liste des paramètres

            // liste des paramètres
            cmd.Parameters["@iDI"].Value = MozartParams.NumDi;
            cmd.Parameters["@iAction"].Value = MozartParams.NumAction;
            cmd.Parameters["@LibAction"].Value = txtAction.Text.Trim();
            cmd.Parameters["@dDateS"].Value = txtDateA0.Text == "" ? DBNull.Value : (object)Convert.ToDateTime(txtDateA0.Text);
            cmd.Parameters["@iSite"].Value = iSiteNum;
            cmd.Parameters["@cUrg"].Value = (string)cboUrg.SelectedValue;
            cmd.Parameters["@cprest"].Value = (string)cboPrest.SelectedValue;
            cmd.Parameters["@cTech"].Value = (string)cboTech.SelectedValue;
            cmd.Parameters["@cTypeAct"].Value = "A";
            cmd.Parameters["@dDateEx"].Value = txtDateA2.Text == "" ? DBNull.Value : (object)Convert.ToDateTime(txtDateA2.Text);
            cmd.Parameters["@cTypeInter"].Value = bSTImpose ? "S" : "T";
            cmd.Parameters["@iTech"].Value = !bSTImpose && txtInter.Tag != null ? txtInter.Tag : DBNull.Value;
            cmd.Parameters["@iST"].Value = bSTImpose && txtContact.Tag != null ? txtContact.Tag : DBNull.Value;
            cmd.Parameters["@cAttach"].Value = txtAttach.Text;
            cmd.Parameters["@vObserv"].Value = txtObserv.Text;
            cmd.Parameters["@vObservM"].Value = txtObservM.Text;
            cmd.Parameters["@vOutil"].Value = txtOutils.Text;
            cmd.Parameters["@vFour"].Value = txtFour.Text;
            cmd.Parameters["@dDatePla"].Value = txtDateA1.Text == "" ? DBNull.Value : (object)Convert.ToDateTime(txtDateA1.Text);
            cmd.Parameters["@cEtat"].Value = (string)cboEtat.SelectedValue;
            cmd.Parameters["@cNuit"].Value = chkNuit.Checked ? "O" : chkNonPublic.Checked ? "P" : "N";
            cmd.Parameters["@cCMD"].Value = chkCMD.Checked ? 'O' : 'N';
            cmd.Parameters["@vDevis"].Value = cboDevis.Text;
            cmd.Parameters["@mDevis"].Value = txtMontantDevis.Text;
            cmd.Parameters["@vRelFactST"].Value = chkRel.Checked ? 1 : 0;// ancien numero de facture utilisé maintenant pour la gestion des relances
            cmd.Parameters["@vFactBudg"].Value = txtDevWeb.Text;
            cmd.Parameters["@vNumCde"].Value = txtNumCde.Text;
            cmd.Parameters["@vRDV"].Value = txtRDV.Text;
            cmd.Parameters["@nNbHPart"].Value = Utils.ZeroIfBlank(txtNbHeurPart.Text);
            cmd.Parameters["@ObsFac"].Value = txtObsFac.Text;
            cmd.Parameters["@factureCotraitant"].Value = TxtFactBudg.Text == "" ? DBNull.Value : (object)Convert.ToDouble(TxtFactBudg.Text);
            cmd.Parameters["@nGam"].Value = (int)cboGamme.SelectedValue;
            cmd.Parameters["@cNacelle"].Value = chkNacelle.Checked ? 'O' : 'N';
            cmd.Parameters["@cMatsurSite"].Value = chkMat.Checked ? 'O' : 'N';
            cmd.Parameters["@cP5"].Value = chkP5.Checked ? 'O' : 'N';
            cmd.Parameters["@cNOKplanning"].Value = chkNOK.Checked ? 'O' : 'N';
            cmd.Parameters["@vMotCle"].Value = "";
            cmd.Parameters["@cTypCont"].Value = chkP3.Checked ? 'O' : 'N';
            cmd.Parameters["@cReclamation"].Value = chkReclam.Checked ? 'O' : 'N';
            cmd.Parameters["@dDateArr"].Value = txtDateA3.Text == "" ? DBNull.Value : (object)Convert.ToDateTime(txtDateA3.Text);
            cmd.Parameters["@vactHrMinRDV"].Value = cboHrRDV.Text != "" && cboMinRDV.Text != "" ? $"{cboHrRDV.Text}:{cboMinRDV.Text}" : "";

            if (Strings.Left(Strings.LTrim(txtAction.Text), 4).ToUpper() == "AIDE" || (string)cboPrest.SelectedValue == "E" ||
                Strings.Left(Strings.LTrim(txtAction.Text), 10).ToUpper() == "FOURNITURE")
              cmd.Parameters["@cVueWeb"].Value = "N";
            else cmd.Parameters["@cVueWeb"].Value = chkWeb.Checked ? "N" : "O";

            // on recherche la durée et le montant de la prev dans la GIDTOBJCLI
            if ((string)cboPrest.SelectedValue == "P")
            {
              sql = $"SELECT NOBJMONTANTINTER, NOBJDUREEINTER FROM TGIDTOBJCLI WITH (NOLOCK) WHERE NOBJNUM =  {row["NumEquip"]}";
              using (SqlDataReader readerMD = ModuleData.ExecuteReader(sql))
              {
                if (readerMD.Read())
                {
                  cmd.Parameters["@iDuree"].Value = Utils.ZeroIfNull(readerMD["NOBJDUREEINTER"]);
                  cmd.Parameters["@iValeur"].Value = Utils.ZeroIfNull(readerMD["NOBJMONTANTINTER"]);
                }
              }
            }
            else
            {
              cmd.Parameters["@iDuree"].Value = txtduree.Text == "" ? DBNull.Value : (object)Convert.ToDouble(txtduree.Text);
              cmd.Parameters["@iValeur"].Value = txtValeur.Text == "" ? DBNull.Value : (object)Convert.ToDouble(txtValeur.Text);
            }
            cmd.Parameters["@idEquipement"].Value = (int)row["NumEquip"];

            // exécuter la commande.
            cmd.ExecuteNonQuery();

            numAct = (int)cmd.Parameters[0].Value;// inutilisé!
          }
        }
      }
      catch (Exception ex) { Utils.ShowError(ex, $"{MethodBase.GetCurrentMethod().Name} dans {this.Name}"); }
    }

    /* --------------------------------------------------------------------------------------- */
    private void EnregistrerMultiDI(DataTable dtRs)
    {
      try
      {
        int localNumDI;

        // la liste des sites à traiter est dans un rs global
        // boucle sur le nombre de site du client
        foreach (DataRow row in dtRs.Rows)
        {
          // création d'une nouvelle DI (avecc les infos de la DI en cours)
          using (SqlCommand cmd = new SqlCommand("api_sp_CopieDI", MozartDatabase.cnxMozart))
          {
            cmd.CommandType = CommandType.StoredProcedure;
            SqlCommandBuilder.DeriveParameters(cmd);    // liste des paramètres

            // liste des paramètres
            cmd.Parameters["@iNumDI"].Value = MozartParams.NumDi;
            cmd.Parameters["@site"].Value = (int)row["Num"];

            // exécuter la commande.
            cmd.ExecuteNonQuery();

            // récupération du numéro de DI créé
            localNumDI = (int)cmd.Parameters[0].Value;

            // création d'une action sur cette DI
            // recherche du sous traitant imposé pour le site et le contrat
            using (SqlDataReader readerST = ModuleData.ExecuteReader($"SELECT NINTNUM  FROM TCONT WITH (NOLOCK) WHERE NSITNUM = {row["Num"]} AND NTYPECONTRAT = {iTypContrat}"))
            {
              if (readerST.Read())
              {
                txtContact.Tag = Convert.IsDBNull(readerST["NINTNUM"]) ? null : (object)Convert.ToInt32(readerST["NINTNUM"]);
              }
            }

            using (SqlCommand cmdDI = new SqlCommand("api_sp_creationAction", MozartDatabase.cnxMozart))
            {
              cmdDI.CommandType = CommandType.StoredProcedure;
              SqlCommandBuilder.DeriveParameters(cmdDI);    // liste des paramètres

              // liste des paramètres
              cmdDI.Parameters["@iDI"].Value = localNumDI;
              cmdDI.Parameters["@iAction"].Value = 0;
              cmdDI.Parameters["@LibAction"].Value = txtAction.Text.Trim();
              cmdDI.Parameters["@dDateS"].Value = txtDateA0.Text == "" ? DBNull.Value : (object)Convert.ToDateTime(txtDateA0.Text);
              cmdDI.Parameters["@iSite"].Value = (int)row["Num"];
              cmdDI.Parameters["@cUrg"].Value = (string)cboUrg.SelectedValue;
              cmdDI.Parameters["@cprest"].Value = (string)cboPrest.SelectedValue;
              cmdDI.Parameters["@cTech"].Value = (string)cboTech.SelectedValue;
              cmdDI.Parameters["@cTypeAct"].Value = "A";
              cmdDI.Parameters["@dDateEx"].Value = txtDateA2.Text == "" ? DBNull.Value : (object)Convert.ToDateTime(txtDateA2.Text);
              cmdDI.Parameters["@cTypeInter"].Value = optInter0.Checked ? "T" : "S";
              cmdDI.Parameters["@iTech"].Value = optInter0.Checked && txtInter.Tag != null ? txtInter.Tag : DBNull.Value;
              cmdDI.Parameters["@iST"].Value = !optInter0.Checked && txtContact.Tag != null ? txtContact.Tag : DBNull.Value;
              cmdDI.Parameters["@cAttach"].Value = txtAttach.Text;
              cmdDI.Parameters["@vObserv"].Value = txtObserv.Text;
              cmdDI.Parameters["@vObservM"].Value = txtObservM.Text;
              cmdDI.Parameters["@vOutil"].Value = txtOutils.Text;
              cmdDI.Parameters["@vFour"].Value = txtFour.Text;
              cmdDI.Parameters["@dDatePla"].Value = txtDateA1.Text == "" ? DBNull.Value : (object)Convert.ToDateTime(txtDateA1.Text);
              cmdDI.Parameters["@cEtat"].Value = ((string)cboEtat.SelectedValue)[0];
              cmdDI.Parameters["@cNuit"].Value = chkNuit.Checked ? "O" : chkNonPublic.Checked ? "P" : "N";
              cmdDI.Parameters["@cCMD"].Value = chkCMD.Checked ? 'O' : 'N';
              cmdDI.Parameters["@vDevis"].Value = cboDevis.Text;

              // on recherche la durée et le montant de la prev
              if ((string)cboPrest.SelectedValue == "P")
              {
                using (SqlDataReader readerMD = ModuleData.ExecuteReader($"SELECT NMONTANTINTER, NDUREEINTER, VCONTNACELLE FROM TCONT WITH (NOLOCK) WHERE NSITNUM = {row["Num"]} AND NTYPECONTRAT = {iTypContrat}"))
                {
                  if (readerMD.Read())
                  {
                    cmdDI.Parameters["@iDuree"].Value = Utils.ZeroIfNull(readerMD["NDUREEINTER"]);
                    cmdDI.Parameters["@iValeur"].Value = Utils.ZeroIfNull(readerMD["NMONTANTINTER"]);
                    cmdDI.Parameters["@cNacelle"].Value = Utils.BlankIfNull(readerMD["VCONTNACELLE"]) == "OUI" ? 'O' : 'N';

                    // pour les STT
                    if (!optInter0.Checked)
                      cmdDI.Parameters["@mDevis"].Value = Utils.ZeroIfNull(readerMD["NMONTANTSTTP2"]);
                    else cmdDI.Parameters["@mDevis"].Value = txtMontantDevis.Text;
                  }
                }
              }
              else
              {
                cmdDI.Parameters["@iDuree"].Value = txtduree.Text == "" ? DBNull.Value : (object)Convert.ToDouble(txtduree.Text);
                cmdDI.Parameters["@iValeur"].Value = txtValeur.Text == "" ? DBNull.Value : (object)Convert.ToDouble(txtValeur.Text);
                cmdDI.Parameters["@mDevis"].Value = txtMontantDevis.Text;
                cmdDI.Parameters["@cNacelle"].Value = chkNacelle.Checked ? 'O' : 'N';
              }

              cmdDI.Parameters["@vRelFactST"].Value = chkRel.Checked ? 1 : 0;// ancien numero de facture utilisé maintenant pour la gestion des relances
              cmdDI.Parameters["@vFactBudg"].Value = txtDevWeb.Text;
              cmdDI.Parameters["@vNumCde"].Value = txtNumCde.Text;
              cmdDI.Parameters["@vRDV"].Value = txtRDV.Text;
              cmdDI.Parameters["@nNbHPart"].Value = Utils.ZeroIfBlank(txtNbHeurPart.Text);
              cmdDI.Parameters["@ObsFac"].Value = txtObsFac.Text;
              cmdDI.Parameters["@factureCotraitant"].Value = TxtFactBudg.Text == "" ? DBNull.Value : (object)Convert.ToDouble(TxtFactBudg.Text);

              if (Strings.Left(Strings.LTrim(txtAction.Text), 4).ToUpper() == "AIDE" || (string)cboPrest.SelectedValue == "E" ||
                Strings.Left(Strings.LTrim(txtAction.Text), 10).ToUpper() == "FOURNITURE")
                cmdDI.Parameters["@cVueWeb"].Value = "N";
              else cmdDI.Parameters["@cVueWeb"].Value = chkWeb.Checked ? "N" : "O";

              cmdDI.Parameters["@nGam"].Value = (int)cboGamme.SelectedValue;
              cmdDI.Parameters["@cMatsurSite"].Value = chkMat.Checked ? 'O' : 'N';
              cmdDI.Parameters["@cP5"].Value = chkP5.Checked ? 'O' : 'N';
              cmdDI.Parameters["@cNOKplanning"].Value = chkNOK.Checked ? 'O' : 'N';
              cmdDI.Parameters["@vMotCle"].Value = "";
              cmdDI.Parameters["@cTypCont"].Value = chkP3.Checked ? 'O' : 'N';
              cmdDI.Parameters["@cReclamation"].Value = chkReclam.Checked ? 'O' : 'N';
              cmdDI.Parameters["@dDateArr"].Value = txtDateA3.Text == "" ? DBNull.Value : (object)Convert.ToDateTime(txtDateA3.Text);
              cmdDI.Parameters["@vactHrMinRDV"].Value = cboHrRDV.Text != "" && cboMinRDV.Text != "" ? $"{cboHrRDV.Text}:{cboMinRDV.Text}" : "";
              cmdDI.Parameters["@vactrdvplagehr"].Value = TxtRDVPlageHR0.Text != "" ? TxtRDVPlageHR0.Text + ";" + TxtRDVPlageHR1.Text : "";

              // exécuter la commande.
              cmdDI.ExecuteNonQuery();
            }
          }
        }
      }
      //catch (Exception ex) { MessageBox.Show($"{ex.Message}\r\n\r\n{Resources.Global_dans}{MethodBase.GetCurrentMethod().Name}", Resources.Global_Erreur, MessageBoxButtons.OK, MessageBoxIcon.Exclamation); }
      catch (Exception ex) { Utils.ShowError(ex, $"{MethodBase.GetCurrentMethod().Name} dans {this.Name}"); }
    }

    private void cboEtat_SelectedValueChanged(object sender, EventArgs e)
    {
      try
      {
        if (cboEtat.SelectedValue == null || cboEtat.SelectedValue.GetType() != Type.GetType("System.String")) return;
        // confirmation pour archivage
        if ((string)cboEtat.SelectedValue == "S")
        {
          if (cboEtat.Tag != null && (int)cboEtat.Tag != 6)
          {// on était pas déja dans ce statut
            if (cboEtat.Tag != null)
            {// lors du chargement de la feuille
              if (txtDateA1.Text != "")
              {// il y a une date de planif
               // impossible d'archiver
                MessageBox.Show(Resources.msg_pouvez_pas_passer_infoarchive_planif_existe, Program.AppTitle, MessageBoxButtons.OK, MessageBoxIcon.Information);
              }
              else if (txtEtatAdmin.Text == Resources.lib_facturee)
              {
                MessageBox.Show(Resources.msg_pouvez_pas_passer_info_archive_facture_existe, Program.AppTitle, MessageBoxButtons.OK, MessageBoxIcon.Information);
                cboEtat.SelectedIndex = (int)cboEtat.Tag;
                return;
              }
              else if (txtEtatAdmin.Text == Resources.lib_chiffree)
              {
                MessageBox.Show(Resources.msg_pouvez_pas_passer_info_archive_chiffrage_existe, Program.AppTitle, MessageBoxButtons.OK, MessageBoxIcon.Information);
                cboEtat.SelectedIndex = (int)cboEtat.Tag;
                return;
              }
              else if (txtEtatAdmin.Text == Resources.lib_attente && cmdDdeStock.BackColor == MozartColors.ColorH80FFFF)
              {
                MessageBox.Show(Resources.msg_pouvez_pas_passer_info_archive_sortie_stock_existe, Program.AppTitle, MessageBoxButtons.OK, MessageBoxIcon.Information);
                cboEtat.SelectedIndex = (int)cboEtat.Tag;
                return;
              }
              else if (txtEtatAdmin.Text == Resources.lib_attente && cmdCommande.BackColor == MozartColors.ColorH80FFFF)
              {
                MessageBox.Show(Resources.msg_pouvez_pas_passer_info_archive_commande_existe, Program.AppTitle, MessageBoxButtons.OK, MessageBoxIcon.Information);
                cboEtat.SelectedIndex = (int)cboEtat.Tag;
                return;
              }
              else if (txtEtatAdmin.Text == Resources.lib_attente && cmdContrat.BackColor == MozartColors.ColorH80FFFF)
              {
                MessageBox.Show(Resources.msg_pouvez_pas_passer_info_archive_contrat_existe, Program.AppTitle, MessageBoxButtons.OK, MessageBoxIcon.Information);
                cboEtat.SelectedIndex = (int)cboEtat.Tag;
                return;
              }
              else if (txtEtatAdmin.Text == Resources.lib_attente && cmdCST.BackColor == MozartColors.ColorH80FFFF)
              {
                MessageBox.Show(Resources.msg_pouvez_pas_passer_info_archive_contrat_existe, Program.AppTitle, MessageBoxButtons.OK, MessageBoxIcon.Information);
                cboEtat.SelectedIndex = (int)cboEtat.Tag;
                return;
              }
              else if (txtEtatAdmin.Text == Resources.lib_attente && cmdCSP.BackColor == MozartColors.ColorH80FFFF)
              {
                MessageBox.Show(Resources.msg_pouvez_pas_passer_info_archive_contrat_existe, Program.AppTitle, MessageBoxButtons.OK, MessageBoxIcon.Information);
                cboEtat.SelectedIndex = (int)cboEtat.Tag;
                return;
              }
              else if (txtEtatAdmin.Text == Resources.lib_attente && cboFactRavel.BackColor == MozartColors.ColorH80FFFF)
              {
                MessageBox.Show(Resources.msg_pouvez_pas_passer_info_archive_facture_ravel_existe, Program.AppTitle, MessageBoxButtons.OK, MessageBoxIcon.Information);
                cboEtat.SelectedIndex = (int)cboEtat.Tag;
                return;
              }
              else
              {
                if (bAffEtatModif)
                {// on affiche ou pas la confirmation d'archivage
                  if (MessageBox.Show(Resources.msg_archiver_action, Program.AppTitle, MessageBoxButtons.YesNo,
                                      MessageBoxIcon.Question, MessageBoxDefaultButton.Button2) != DialogResult.Yes)
                  {
                    cboEtat.SelectedIndex = (int)cboEtat.Tag;
                    bAffEtatModif = true;
                    return;
                  }

                  //modif du 31/0/2017 par mc suite demande mail pierre chevalier
                  if (bNCANChantier)
                  {
                    MessageBox.Show(Resources.msg_decoupage_heures_passera_a_0 + ".", Program.AppTitle, MessageBoxButtons.OK, MessageBoxIcon.Information);
                    ModuleData.ExecuteNonQuery($"exec [api_sp_Chantier_RAS_Heures] {MozartParams.NumAction}");

                    // on recharge
                    LoadHRChantier();
                    txtduree.Text = "0";
                  }
                  cboEtat.Tag = 6;
                }
                else
                  cboEtat.Tag = 6;
              }
            }
          }
        }

        bAffEtatModif = true;

        // impossible de mettre en "D" si il y a un devis client
        if ((string)cboEtat.SelectedValue == "D" && cboEtat.Tag != null && bDevisCL)
        {
          MessageBox.Show(Resources.msg_pouvez_pas_passer_endevis_car_devisclient_existe, Program.AppTitle, MessageBoxButtons.OK, MessageBoxIcon.Information);
          cboEtat.SelectedIndex = (int)cboEtat.Tag;
        }

        // gestion statut complément uniquement sur "N"
        if ((string)cboEtat.SelectedValue == "N")
        {
          cboEtatCO.SelectedIndex = -1;
          cboEtatCO.Visible = true;

          //CACT_LOG_ETAT_DETAIL oAct_Log_Etat_Adding = new CACT_LOG_ETAT_DETAIL();
          //oAct_Log_Etat_Adding.NID_ACT_LOG_ETAT = 0;
          //oAct_Log_Etat_Adding.NACTNUM = MozartParams.NumAction;
          //oAct_Log_Etat_Adding.CETACOD = (string)cboEtat.SelectedValue;
          //oAct_Log_Etat_Adding.NQUICREE = MozartParams.UID;
          //oAct_Log_Etat_Adding.DQUICREE = DateTime.Now;
          //oAct_Log_Etat_Adding.VQUICREE = MozartParams.strUID;

          //oTabAct_Log_Etat.Add(oAct_Log_Etat_Adding);
        }
        else
        {  // il faut remettre les combo à zéro
          cboEtatCO.SelectedIndex = -1;
          cboSemaines.SelectedIndex = -1;
          cboEtatCO.Visible = false;
          cboSemaines.Visible = false;
        }

        // gestion statut admin complément uniquement sur statut "E"
        if ((string)cboEtat.SelectedValue == "E" && ((string)txtEtatAdmin.Tag == "A" || (string)txtEtatAdmin.Tag == "C"))
        {
          cboEtatAdminCpl.SelectedIndex = -1;
          cboEtatAdminCpl.Visible = true;
        }
        else
        {  // il faut remettre les combo à zéro
          cboEtatAdminCpl.SelectedIndex = -1;
          cboEtatAdminCpl.Visible = false;
        }


        SetVisibleChkDevisAttenteCheckBox();

      }
      //catch (Exception ex) { MessageBox.Show($"{ex.Message}\r\n\r\n{Resources.Global_dans}{MethodBase.GetCurrentMethod().Name}", Resources.Global_Erreur, MessageBoxButtons.OK, MessageBoxIcon.Exclamation); }
      catch (Exception ex) { Utils.ShowError(ex, $"{MethodBase.GetCurrentMethod().Name} dans {this.Name}"); }
    }
    //Private Sub cboEtat_Click()
    //
    //On Error Resume Next
    //
    //' confirmation pour archivage
    //If Chr(cboEtat.ItemData(cboEtat.ListIndex)) = "S" Then
    //  If cboEtat.Tag <> 4 Then  ' on été pas déja dans ce statut
    //    If cboEtat.Tag <> "" Then ' lors du chargement de la feuille
    //      If txtDateA(1) <> "" Then   ' il y a une date de plannif
    //        'impossible d'archiver
    //        MsgBox "§Vous ne pouvez pas passer en 'Info Archivé' car il existe une planification§", vbInformation
    //      ElseIf txtEtatAdmin = "§Facturé§" Then
    //        MsgBox "§Vous ne pouvez pas passer en 'Info Archivé' car il existe une facture!§", vbInformation
    //        cboEtat.ListIndex = CInt(cboEtat.Tag)
    //        Exit Sub
    //      ElseIf txtEtatAdmin = "§Chiffré§" Then
    //        MsgBox "§Vous ne pouvez pas passer en 'Info Archivé' car il existe un chiffrage. Supprimez le chiffrage!§", vbInformation
    //        cboEtat.ListIndex = CInt(cboEtat.Tag)
    //        Exit Sub
    //      ElseIf txtEtatAdmin = "§Attente§" And cmdDdeStock.BackColor = &H80FFFF Then
    //        MsgBox "§Vous ne pouvez pas passer en 'Info Archivé' car il existe une sortie de stock susceptible d'être facturée au client.§", vbInformation
    //        cboEtat.ListIndex = CInt(cboEtat.Tag)
    //        Exit Sub
    //      ElseIf txtEtatAdmin = "§Attente§" And cmdCommande.BackColor = &H80FFFF Then
    //        MsgBox "§Vous ne pouvez pas passer en 'Info Archivé' car il existe une commande susceptible d'être facturée au client.§", vbInformation
    //        cboEtat.ListIndex = CInt(cboEtat.Tag)
    //        Exit Sub
    //      ElseIf txtEtatAdmin = "§Attente§" And cmdContrat.BackColor = &H80FFFF Then
    //        MsgBox "§Vous ne pouvez pas passer en 'Info Archivé' car il existe un contrat susceptible d'être facturé au client.§", vbInformation
    //        cboEtat.ListIndex = CInt(cboEtat.Tag)
    //        Exit Sub
    //      ElseIf txtEtatAdmin = "§Attente§" And cmdCST.BackColor = &H80FFFF Then
    //        MsgBox "§Vous ne pouvez pas passer en 'Info Archivé' car il existe un contrat susceptible d'être facturé au client.§", vbInformation
    //        cboEtat.ListIndex = CInt(cboEtat.Tag)
    //        Exit Sub
    //      ElseIf txtEtatAdmin = "§Attente§" And cmdCSP.BackColor = &H80FFFF Then
    //        MsgBox "§Vous ne pouvez pas passer en 'Info Archivé' car il existe un contrat susceptible d'être facturé au client.§", vbInformation
    //        cboEtat.ListIndex = CInt(cboEtat.Tag)
    //        Exit Sub
    //      ElseIf txtEtatAdmin = "§Attente§" And cboFactRavel.Text <> "" Then
    //        MsgBox "§Vous ne pouvez pas passer en 'Info Archivé' car il existe une facture dans ravel susceptible d'être facturée au client.§", vbInformation
    //        cboEtat.ListIndex = CInt(cboEtat.Tag)
    //        Exit Sub
    //        
    //      Else
    //        If bAffEtatModif Then  'on affiche ou pas la confirmation d'archivage
    //          Select Case MsgBox("§Voulez-vous vraiment archiver cette action ?§", vbYesNo + vbQuestion + vbDefaultButton2)
    //            Case vbYes
    //                'modif du 31/0/2017 par mc suite demande mail pierre chevalier
    //                If bNCANChantier = True Then
    //                    MsgBox "§A noter : Le découpage des heures par fiche passera automatiquement à 0§.", vbInformation
    //                    cnx.Execute ("exec [api_sp_Chantier_RAS_Heures] " & glNumAction)
    //                    
    //                    'on recharge
    //                    LoadHRChantier
    //                    txtduree.Text = "0"
    //            
    //                End If
    //            
    //            
    //                cboEtat.Tag = 4
    //            Case vbNo
    //              cboEtat.ListIndex = CInt(cboEtat.Tag)
    //              bAffEtatModif = True
    //              Exit Sub
    //          End Select
    //        Else
    //          cboEtat.Tag = 4
    //        End If
    //      End If
    //    End If
    //  End If
    //End If
    //bAffEtatModif = True
    //
    //'' impossible de mettre en info client si il y a un devis client
    //'If cboEtat =  "Info client" Then
    //'  If cboEtat.Tag <> "" Then
    //'    If bDevisCL Then
    //'      MsgBox "§Vous ne pouvez pas passer en 'Info client' car il existe un devis client sur cette action.§", vbInformation
    //'      cboEtat.ListIndex = CInt(cboEtat.Tag)
    //'    End If
    //'  End If
    //'End If
    //
    //' impossible de mettre en "D" si il y a un devis client
    //If Chr(cboEtat.ItemData(cboEtat.ListIndex)) = "D" Then
    //  If cboEtat.Tag <> "" Then
    //    If bDevisCL Then
    //      MsgBox "§Vous ne pouvez pas passer en 'Devis' car il existe un devis client sur cette action.§", vbInformation
    //      cboEtat.ListIndex = CInt(cboEtat.Tag)
    //    End If
    //  End If
    //End If
    //
    //End Sub
    //
    /* --------------------------------------------------------------------------------------- */
    private void cboPrest_SelectedValueChanged(object sender, EventArgs e)
    {
      try
      {
        if (cboPrest.SelectedValue == null || cboPrest.SelectedValue.GetType() != Type.GetType("System.String")) return;

        if ((string)cboPrest.SelectedValue == "K" && sModeReadOnly == "2" && !binitcombo)
        {
          MessageBox.Show(Resources.msg_select_type_prestation_non_autorisee, Program.AppTitle, MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
          cboPrest.SelectedIndex = (int)cboPrest.Tag;
          return;
        }

        if (bTousSites && !binitcombo)
        {
          if ((string)cboPrest.SelectedValue == "D" || (string)cboPrest.SelectedValue == "S")
          {
            MessageBox.Show(Resources.msg_DI_multisite_choix_prev_travaux_etude_devis_ldr, Program.AppTitle, MessageBoxButtons.OK, MessageBoxIcon.Information);
            cboPrest.SelectedIndex = 3;
          }
        }
        binitcombo = false;
        if (bTousEquipements && !binitcombo)
        {
          if ((string)cboPrest.SelectedValue == "D" || (string)cboPrest.SelectedValue == "S")
          {
            MessageBox.Show(Resources.msg_DI_multisite_choix_prev_travaux_etude_devis_ldr, Program.AppTitle, MessageBoxButtons.OK, MessageBoxIcon.Information);
            cboPrest.SelectedIndex = 3;
          }
        }

        // KPI
        lblLabels50.Visible = (string)cboPrest.SelectedValue == "P" && bKPIGest_DatePrev;

        // en creation
        // si on selectionne preventive et que l'on est pas sur une multisite
        // on recherche le montant et la duree au niveau du contrat, et l'info nacelle
        // si l'on a pas de données, impossible de créer la prev
        if (!binitcombo && mstrStatutAction == "C")
        {
          if ((string)cboPrest.SelectedValue == "P" && !bActReccur)
          {
            // si ce n'est pas une multisite, on ramene le montant et la duree
            if (!bTousSites && !bTousEquipements)
            {
              using (SqlDataReader reader = ModuleData.ExecuteReader($"SELECT NMONTANTINTER,NDUREEINTER,NMONTANTSTTP2,VCONTNACELLE FROM TCONT WITH (NOLOCK) " +
                                                                     $"WHERE NSITNUM = {iSiteNum} AND NTYPECONTRAT ={iTypContrat}"))
              {
                if (reader.Read())
                {
                  chkNacelle.Checked = Utils.BlankIfNull(reader["VCONTNACELLE"]) == "OUI";
                  if (Utils.ZeroIfNull(reader["NDUREEINTER"]) > 0)
                  {
                    txtValeur.Text = Utils.ZeroIfNull(reader["NMONTANTINTER"]).ToString("0.##");
                    txtduree.Text = Utils.ZeroIfNull(reader["NDUREEINTER"]).ToString("0.##");
                    // modif du 22/08/2018 pour gestion du posté
                    txtduree.Enabled = bActReccur;
                    txtValeur.Enabled = false;
                    if (!optInter0.Checked)
                      txtMontantDevis.Text = Utils.BlankIfNull(reader["NMONTANTSTTP2"]);
                  }
                  else
                  {
                    MessageBox.Show($"{Resources.msg_duree_preventive_non_renseignee_niveau_contrat}{Environment.NewLine}" +
                                    "{Resources.msg_saisir_donnees_admin_client_sites_affectation_contrat}",
                                    Program.AppTitle, MessageBoxButtons.OK, MessageBoxIcon.Information);
                    cboPrest.Text = Resources.col_travaux;
                  }
                }
              }
            }
            else
            {
              // multisite le montant et la duree seront positionné à la creation des actions
              txtduree.Enabled = bActReccur;
              txtValeur.Enabled = false;
            }
          }
          else
          {
            if ((string)cboPrest.SelectedValue == "K")
            {
              MessageBox.Show(Resources.msg_select_type_prestation_non_autorisee, Program.AppTitle, MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
              cboPrest.SelectedIndex = 1;
              return;
            }
            txtValeur.Enabled = txtduree.Enabled = true;
          }
        }
        else if (!binitcombo && mstrStatutAction == "M")
        {
          // si on est en modif, si prev alors grisé sinon modifiable
          if ((string)cboPrest.SelectedValue == "P")
          {
            // la durée n'est pas grisé si l'action est "exécutée"  'ça ne fonctionne pas lors de l'ouverture de la page car la combo cboetat n'est pas chargée
            // donc j'ai ajouté un test dans le load de la page. mais il faut le laisser ici dans le cas ou on fait des modif de statut apres le load de la page
            if ((string)cboEtat.SelectedValue == "E")
              txtduree.Enabled = true;
            else
            {
              if (bTousEquipements)
              {
                txtValeur.Enabled = txtduree.Enabled = true;
              }
              else
              {
                txtduree.Enabled = bActReccur;
                txtValeur.Enabled = false;
              }
            }
          }
          else
          {
            // on ne laisse modifiable le montant que si :
            // on a pas de facture et pas de chiffrage
            // test de la couleur pour savoir si on a un devis
            if (txtValeur.ForeColor == Color.Red)//&HFF&
            {
              txtValeur.ReadOnly = txtValeur.Enabled = true;
            }
            // si on a un chiffrage ou une facture --> pas possible de modifier
            else if (lblLabels24.Text != Resources.lib_montant_chiffre_euro_HT && lblLabels24.Text != Resources.lib_montant_facture_euro_HT &&
                     MozartParams.NomSociete != "EMALECSUISSE")
              txtValeur.Enabled = true;
            else if (lblLabels24.Text != Resources.lib_montant_chiffre_CHF_HT && lblLabels24.Text != Resources.lib_montant_facture_CHF_HT && MozartParams.NomSociete == "EMALECSUISSE")
              txtValeur.Enabled = true;

            txtduree.Enabled = true;
          }
        }

        if ((string)cboPrest.SelectedValue == "P")
          cboUrg.SelectedIndex = 2;

        // V 2
        if (null != lblInter.Tag &&
            (((string)cboPrest.SelectedValue == "B" && (string)lblInter.Tag != "G") ||
            ((string)cboPrest.SelectedValue != "B" && (string)lblInter.Tag == "G")))
        {
          if (PrestModifiable())
          {// modifiable
            if ((string)cboPrest.SelectedValue == "B")
            {
              OptionAfficheTypeIntervenant("G");
              optInter3.Checked = true;
              InitialiseIntervenant();
              lblInter.Tag = "G";
            }
            else
            {
              OptionAfficheTypeIntervenant("S");
              optInter0.Checked = true;// par défaut on sélectionne le technicien
              InitialiseIntervenant();
              lblInter.Tag = "T";
            }
            cboPrest.Tag = cboPrest.SelectedValue;
          }
          else
          {// Non modifiable
           // on recharge les données de l'action initale
            MessageBox.Show(Resources.msg_modif_prestation_garantie_interdite + " !!!", Program.AppTitle, MessageBoxButtons.OK, MessageBoxIcon.Stop);

            if ((string)lblInter.Tag == "G")
            {
              OptionAfficheTypeIntervenant("G");
              bChangeprest = true;
              optInter3.Checked = true;
              bChangeprest = false;
            }
            else
            {
              OptionAfficheTypeIntervenant("S");
              // on recharge les infos de l'action pour récupérer le type de le nom et le contact
              bChangeprest = true;
              switch ((string)lblInter.Tag)
              {
                case "T":
                  optInter0.Checked = true; break;
                case "S":
                  optInter1.Checked = true; break;
                case "I":
                  optInter2.Checked = true; break;
              }
              bChangeprest = false;
            }

            // si on a un sous traitant alors on recharge les données
            if (optInter1.Checked || optInter2.Checked || optInter3.Checked)
            {
              using (SqlDataReader reader = ModuleData.ExecuteReader($"api_sp_infoSTTaction {MozartParams.NumAction}"))
              {
                if (reader.Read())
                {
                  // relance facture ST
                  chkRel.Checked = Utils.ZeroIfNull(reader["NACTVALDEVISST"]) == 1;

                  txtFixe.Visible = txtPort.Visible = lbltel.Visible = lblpor.Visible = true;

                  // recherche si il y a un contact
                  if (Convert.IsDBNull(reader["VINTNOM"]))
                  {
                    if ((string)lblInter.Tag != "G") lblInter.Tag = "R";// on garde l'info pour la suite
                    txtFixe.Text = txtPort.Text = txtInter.Text = txtContact.Text = "";
                    txtInter.Tag = txtContact.Tag = null;
                  }
                  else
                  {
                    txtInter.Tag = Convert.IsDBNull(reader["NSTFNUM"]) ? null : reader["NSTFNUM"];
                    txtInter.Text = Utils.BlankIfNull(reader["VSTFNOM"]);
                    txtContact.Tag = Convert.IsDBNull(reader["NINTNUM"]) ? null : reader["NINTNUM"];
                    txtContact.Text = Utils.BlankIfNull(reader["VINTNOM"]);
                    txtFixe.Text = Utils.BlankIfNull(reader["VINTTEL"]);
                    txtPort.Text = Utils.BlankIfNull(reader["VINTPOR"]);
                  }

                  // recherche si il y a une demande de devis ST
                  // cboDevis.Visible = True:  lblDevis.Visible = True:   cboDevis.Text = pRSnPrest("DEVIS")
                  // clignotement si relance
                  Timer1.Enabled = Utils.BlankIfNull(reader["VINTPOR"]) == "Relance";

                  // montant du devis
                  // modif mc le 24/05/2018 :  affichage selon droit
                  if (optInter1.Visible || optInter2.Visible || optInter3.Visible)
                  {
                    lblContact.Visible = txtContact.Visible = true;
                    ApiTelAuto3.Visible = txtTelAstr.Visible = lblAstr.Visible = true;
                    cmdDocSTT.Visible = CboPPS.Visible = LblPPS.Visible = cmdStt.Visible = cmdNotation.Visible = CmdCtct.Visible = true;

                    //modif du 13/05/2024 par PC fait pas MC
                    lblDevWeb.Visible = txtDevWeb.Visible = ModuleMain.RechercheDroitMenu(txtDevWeb.HelpContextID);
                    chkRel.Visible = lblRelFac.Visible = ModuleMain.RechercheDroitMenu(lblRelFac.HelpContextID);
                    lblDevis.Visible = cboDevis.Visible = ModuleMain.RechercheDroitMenu(lblDevis.HelpContextID);
                    cmdVisuDevisSTT.Visible = lblMontantdevis.Visible = txtMontantDevis.Visible = ModuleMain.RechercheDroitMenu(lblDevis.HelpContextID);

                  }
                  else
                  {
                    txtDevWeb.Visible = lblDevWeb.Visible = txtMontantDevis.Visible = lblMontantdevis.Visible = cboDevis.Visible = lblDevis.Visible = cmdVisuDevisSTT.Visible = false;
                    ApiTelAuto3.Visible = txtTelAstr.Visible = lblAstr.Visible = true;
                    cmdDocSTT.Visible = LblPPS.Visible = CboPPS.Visible = cmdNotation.Visible = cmdStt.Visible = CmdCtct.Visible = chkRel.Visible = lblRelFac.Visible = false;
                  }

                  txtMontantDevis.Text = Utils.BlankIfNull(reader["VALDEVIS"]);

                  // telephone astreinte st
                  lblAstr.Visible = txtTelAstr.Visible = true;
                  txtTelAstr.Text = Utils.BlankIfNull(reader["VSTFTEL"]);
                  ApiTelAuto3.Visible = true;

                  iCodeCotraitance = DetailstravauxUtils.RechercheCotraitantAct(MozartParams.NumAction);
                  if (iCodeCotraitance == 0)
                  {
                    TxtFactBudg.Visible = lblLabels27.Visible = lblCotraitant.Visible = lblSTI.Visible = false;
                  }
                  else
                  {
                    //  If iCodeCotraitance = 1 alors on laisse le libellé par défaut
                    if (iCodeCotraitance == 3) lblSTI.Text = "Cotraitant";
                    else if (iCodeCotraitance == 2) lblSTI.Text = "Cotraitant imposé";
                    TxtFactBudg.Visible = lblLabels27.Visible = lblCotraitant.Visible = lblSTI.Visible = true;
                  }
                }
              }
            }
            else
            {
              // TECHNICIEN
              using (SqlDataReader reader = ModuleData.ExecuteReader($"api_sp_infoTechaction {MozartParams.NumAction}"))
              {
                if (reader.Read())
                {
                  lblInter.Tag = "T";// on garde l'info pour la suite
                  if (Convert.IsDBNull(reader["VPERNOM"]))
                  {
                    txtInter.Tag = null;
                    txtInter.Text = "";
                  }
                  else
                  {
                    txtInter.Tag = (int)Utils.ZeroIfNull(reader["NPERNUM"]);
                    txtInter.Text = Utils.BlankIfNull(reader["VPERNOM"]);
                  }
                  txtFixe.Text = Utils.BlankIfNull(reader["NPERCOD"]);
                  txtPort.Text = "";
                  txtPort.Tag = Utils.BlankIfNull(reader["VPERPOR"]);// on utilise le tag pour pouvoir envoyer des sms avec le numero
                                                                     // pas de demande de devis
                  txtDevWeb.Visible = lblDevWeb.Visible = txtMontantDevis.Visible = lblMontantdevis.Visible = cboDevis.Visible = lblDevis.Visible = cmdVisuDevisSTT.Visible = false;
                  chkRel.Visible = lblCotraitant.Visible = ApiTelAuto3.Visible = lblRelFac.Visible = txtTelAstr.Visible = lblAstr.Visible = false;
                  CboPPS.Visible = LblPPS.Visible = lblLabels27.Visible = TxtFactBudg.Visible = false;
                }
              }
            }
            // on recale la combo sur la prestation précédente
            cboPrest.SelectedIndex = (int)cboPrest.Tag;
          }
        }
        else if ((string)cboPrest.SelectedValue != "B" && lblInter.Tag != null && (string)lblInter.Tag != "G")
        {
          OptionAfficheTypeIntervenant("S");
          optInter3.Checked = false;
        }
        else if ((string)cboPrest.SelectedValue == "B" && (lblInter.Tag == null || (string)lblInter.Tag == "G"))
        {
          OptionAfficheTypeIntervenant("G");
          optInter3.Checked = true;
        }

        updateTextKPI();
      }
      catch (Exception ex) { Utils.ShowError(ex, $"{MethodBase.GetCurrentMethod().Name} dans {this.Name}"); }
    }

    private void updateTextKPI()
    {
      try
      {
        // Nom du champ où récupérer le délai
        string lValueField;
        // Permet d'indiquer si il faut afficher la deadline ou pas ...
        bool lDisplayDeadLine;

        lblKPI.Text = "";

        if (((string)cboPrest.SelectedValue != "D") || (null == cboUrg.SelectedValue) || !bManageDelaiContKPI)
        {
          return;
        }

        lDisplayDeadLine = false;

        switch ((string)cboUrg.SelectedValue)
        {
          case "1":
            lValueField = "NDEPRAP";
            break;
          case "2":
            lValueField = "NDEPMOY";
            lDisplayDeadLine = true;
            break;
          case "3":
            lValueField = "NDEPLEN";
            lDisplayDeadLine = true;
            break;
          case "4":
            lValueField = "NDEPAST";
            break;
          default:
            return;
        }

        using (SqlDataReader reader = MozartDatabase.ExecuteReader($"select {lValueField} as DELAI from TDELAICONT where NCLINUM={iClientNum} AND NTYPECONTRAT={iTypContrat} AND CGESTION='OUI'"))
        {
          if (reader.Read())
          {
            lblKPI.Text = $"KPI : {reader["DELAI"]} h";

            if (lDisplayDeadLine)
            {
              try
              {
                Double lDelai;

                Double.TryParse(reader["DELAI"].ToString(), out lDelai);
                int iDelay = ((int)lDelai) * 60;

                string lSql = $"select dbo.CalcDateLimiteKPI({iClientNum}, '{txtDate.Text}', {iDelay}) AS DATEKPI";
                using (SqlDataReader reader2 = MozartDatabase.ExecuteReader(lSql))
                {
                  if (reader2.Read())
                  {
                    lblKPI.Text += $" - Intervention avant le {reader2["DATEKPI"]}";
                  }
                }
              }
              catch (Exception)
              {
              }
            }
          }
        }

      }
      catch (Exception)
      {
        lblKPI.Text = "";
      }
    }

    private void AffichageDecisionWeb()
    {
      // traitement des décisions web : si la variable est non nulle , il y a une décision a traiter
      if (MozartParams.NumDeciWeb != 0)
      {
        // recherche des infos à afficher
        using (SqlDataReader reader = ModuleData.ExecuteReader($"select * from api_v_DeciWeb where NWDECNUM={MozartParams.NumDeciWeb}"))
        {
          if (reader.Read())
          {
            txtDeciWeb.Text = Utils.BlankIfNull(reader[0]);
            // recherche si il passe commande ou pas
            if (Utils.BlankIfNull(reader["CWDECCODE"]) == "C")
              txtDeciWeb.Tag = 'C';
            else if (Utils.BlankIfNull(reader["CWDECCODE"]) == "A")
            {
              // recherche si ne passe pas commande et alors, passage action archiver
              bAffEtatModif = false;
              cboEtat.SelectedValue = "S";
            }

            // affichage de la fenetre
            txtDeciWeb.Visible = true;
          }
        }
      }
      else
      {
        txtDeciWeb.Tag = null;
        txtDeciWeb.Text = "";
        txtDeciWeb.Visible = false;
      }
    }
    //Private Sub AffichageDecisionWeb()
    // 
    //Dim adoInfoDeciWeb As New ADODB.Recordset
    //  
    //  ' traitement des décisions web : si la variable est non nulle , il y a une décision a traiter
    //  If giNumDeciWeb <> 0 Then
    //    ' recherche des infos à afficher
    //    adoInfoDeciWeb.Open "select * from api_v_DeciWeb where NWDECNUM=" & giNumDeciWeb, cnx
    //    txtDeciWeb = adoInfoDeciWeb(0)
    //    ' recherche si il passe commande ou pas
    //    If adoInfoDeciWeb("CWDECCODE") = "C" Then txtDeciWeb.Tag = "C"
    //    ' recherche si ne passe pas commande et alors, passage action archiver
    //    If adoInfoDeciWeb("CWDECCODE") = "A" Then
    //      bAffEtatModif = False
    //      SelectLB cboEtat, Asc("S")
    //    End If
    //    
    //    ' affichage de la fenetre
    //    txtDeciWeb.Visible = True
    //    ' fermeture du recordset
    //    adoInfoDeciWeb.Close
    //    Set adoInfoDeciWeb = Nothing
    //  Else
    //    txtDeciWeb.Tag = ""
    //    txtDeciWeb = ""
    //    txtDeciWeb.Visible = False
    //  End If
    //  
    //End Sub
    //
    /* --------------------------------------------------------------------------------------- */
    private void AffichageMessageSTWeb()
    {
      // traitement des message ST web : si la variable est non nulle , il y a une décision a traiter
      if (MozartParams.NumMsgSTWeb != 0)
      {
        // recherche des infos à afficher
        using (SqlDataReader reader = ModuleData.ExecuteReader($"SELECT VMESSAGE, DDATEEXEC, DACTARR From TWMESSTF WITH (NOLOCK) WHERE ID={MozartParams.NumMsgSTWeb}"))
        {
          if (reader.Read())
          {
            TxtMsgSTWeb.Text = Utils.BlankIfNull(reader["VMESSAGE"]);
            TxtMsgSTWeb.Visible = true;

            // date d'arrivée sur site
            // heure et minute
            if (txtDateA3.Text == "")
            {
              txtDateA3.Text = Utils.DateLongIfHMBlankIfNull(reader["DACTARR"]);
              if (txtDateA3.Text != "")
              {
                DateTime d3 = Convert.ToDateTime(txtDateA3.Text); ;
                cboH.Text = d3.Hour.ToString("00");
                cboH.Tag = d3.Hour;
                cboM.Text = d3.Minute.ToString("00");
                cboM.Tag = d3.Minute;
                nSecondTempDatArr = d3.Second.ToString("00");
              }
            }

            // si pas de date d'exec
            if (txtDateA2.Text == "")
            {
              txtDateA2.Text = Utils.DateLongIfHMBlankIfNull(reader["DDATEEXEC"]);
              if (txtDateA2.Text != "")
              {
                DateTime d2 = Convert.ToDateTime(txtDateA2.Text); ;
                cboHE.Text = d2.Hour.ToString("00");
                cboHE.Tag = d2.Hour;
                cboME.Text = d2.Minute.ToString("00");
                cboME.Tag = d2.Minute;
                nSecondTempDatExe = d2.Second.ToString("00");
              }
            }

            // si cotraitant, mettre le message dans l'action sinon dans observation
            if (lblSTI.Visible)
              txtAction.Text += $"{Environment.NewLine}{Environment.NewLine} Message web STT le {DateTime.Now} : {Environment.NewLine}{TxtMsgSTWeb.Text}";
            else
              txtObserv.Text = $"Message web STT le {DateTime.Now} : {TxtMsgSTWeb.Text}.{Environment.NewLine}{txtObserv.Text}";
          }
        }
      }
      else
      {
        TxtMsgSTWeb.Text = "";
        TxtMsgSTWeb.Visible = false;
      }
    }

    private async void ApiTelAuto_Click(object sender, EventArgs e)
    {
      ApiTelAuto tel = (sender as ApiTelAuto);
      switch (tel.Name)
      {
        case "ApiTelAuto1":
          if (txtFixe.Text == "") return;
          tel.TelDial(txtFixe.Text);
          if (tel.bDialOK == false)
          {
            string reponse = await CNumerotationAuto.MakeCallByAvaya(MozartParams.UserTelInt, txtFixe.Text, Environment.MachineName);
            if (reponse != "OK")
            {
              MessageBox.Show(reponse, Program.AppTitle, MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
          }
          break;
        case "ApiTelAuto2":
          if (txtPort.Text == "") return;
          tel.TelDial(txtPort.Text);
          if (tel.bDialOK == false)
          {
            string reponse = await CNumerotationAuto.MakeCallByAvaya(MozartParams.UserTelInt, txtPort.Text, Environment.MachineName);
            if (reponse != "OK")
            {
              MessageBox.Show(reponse, Program.AppTitle, MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
          }
          break;
        case "ApiTelAuto3":
          if (txtTelAstr.Text == "") return;
          tel.TelDial(txtTelAstr.Text);
          if (tel.bDialOK == false)
          {
            string reponse = await CNumerotationAuto.MakeCallByAvaya(MozartParams.UserTelInt, txtTelAstr.Text, Environment.MachineName);
            if (reponse != "OK")
            {
              MessageBox.Show(reponse, Program.AppTitle, MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
          }
          break;
        case "ApiTelAuto4":
          if (txtTel.Text == "") return;
          tel.TelDial(txtTel.Text);
          if (tel.bDialOK == false)
          {
            string reponse = await CNumerotationAuto.MakeCallByAvaya(MozartParams.UserTelInt, txtTel.Text, Environment.MachineName);
            if (reponse != "OK")
            {
              MessageBox.Show(reponse, Program.AppTitle, MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
          }
          break;
      }
    }

    private void CmdEsc_Click(object sender, System.EventArgs e)
    {
      txtSMS.Visible = false;
      cmdEsc.Visible = false;
      cmdSMS.Text = "SMS";
    }

    private void cmdsms_Click(object sender, System.EventArgs e)
    {
      try
      {
        txtSMS.Top = 3300 / 15;
        txtSMS.Left = 8200 / 15;

        if (cmdSMS.Text == "SMS")
        {
          if (optInter0.Checked)
          {
            if (txtPort.Tag == null || (string)txtPort.Tag == "")
            {
              MessageBox.Show(Resources.msg_pas_num_portable, Program.AppTitle, MessageBoxButtons.OK, MessageBoxIcon.Information);
              return;
            }
          }
          else
          {// ST
            if (txtPort.Text == "")
            {
              MessageBox.Show(Resources.msg_pas_num_portable, Program.AppTitle, MessageBoxButtons.OK, MessageBoxIcon.Information);
              return;
            }
          }
          txtSMS.Visible = true;
          cmdEsc.Visible = true;
          cmdSMS.Text = Resources.lib_envoi;
          txtSMS.Text = "";
        }
        else
        {
          if (txtSMS.Text != "")
          {
            if (optInter0.Checked)
            {
              // tech
              ModuleData.ExecuteNonQuery($"exec api_sp_AjoutSMS '{txtPort.Tag}', '{txtSMS.Text.Replace("'", "''")}', '{txtInter.Text.Replace("'", "''")}'");
            }
            else
            {
              // st
              ModuleData.ExecuteNonQuery($"exec api_sp_AjoutSMS '{txtPort.Text}', '{txtSMS.Text.Replace("'", "''")}', '{txtContact.Tag.ToString().Replace("'", "''")}'");
            }
          }
          txtSMS.Visible = false;
          cmdEsc.Visible = false;
          cmdSMS.Text = "SMS";
        }
      }
      //catch (Exception ex) { MessageBox.Show($"{ex.Message}\r\n\r\n{Resources.Global_dans}{MethodBase.GetCurrentMethod().Name}", Resources.Global_Erreur, MessageBoxButtons.OK, MessageBoxIcon.Exclamation); }
      catch (Exception ex) { Utils.ShowError(ex, $"{MethodBase.GetCurrentMethod().Name} dans {this.Name}"); }
    }
    //Private Sub cmdsms_Click()
    //
    //On Error GoTo handler
    //
    //  txtSMS.Top = 3300
    //  txtSMS.Left = 8200
    //  If cmdSMS.Caption = "SMS" Then
    //    If optInter(0) Then
    //      If txtPort.Tag = "" Then
    //        MsgBox "§Pas de numéro de portable !§", vbInformation
    //        Exit Sub
    //      End If
    //    Else ' ST
    //      If txtPort = "" Then
    //        MsgBox "§Pas de numéro de portable !§", vbInformation
    //        Exit Sub
    //      End If
    //    End If
    //    txtSMS.Visible = True
    //    cmdEsc.Visible = True
    //    cmdSMS.Caption = "§Envoi§"
    //    txtSMS = ""
    //  Else
    //    If txtSMS <> "" Then
    //      If optInter(0) Then
    //        ' tech
    //        cnx.Execute "exec api_sp_AjoutSMS '" & txtPort.Tag & "', '" & Replace(txtSMS, "'", "''") & "', '" & Replace(txtInter.Text, "'", "''") & "'"
    //      Else
    //        ' st
    //        cnx.Execute "exec api_sp_AjoutSMS '" & txtPort & "', '" & Replace(txtSMS, "'", "''") & "', '" & Replace(txtContact.Tag, "'", "''") & "'"
    //      End If
    //      txtSMS.Visible = False
    //      cmdEsc.Visible = False
    //      cmdSMS.Caption = "SMS"
    //    End If
    //  End If
    //
    //Exit Sub
    //Resume
    //handler:
    //  ShowError "cmdsms_Click() dans " & Me.Name
    //End Sub
    //
    /* --------------------------------------------------------------------------------------- */
    private void Timer2_Tick(object sender, EventArgs e)
    {
      // cas du technicien : exit
      if (optInter0.Checked || txtInter.Tag == null)
      {
        Timer2.Enabled = false;   // pas de message soustraitant
        return;
      }
      // information sur le st interdit ou pas
      using (SqlDataReader reader = ModuleData.ExecuteReader($"SELECT CNOTINTERDIT, VNOTMESS FROM TNOTES WITH (NOLOCK) WHERE VNOTTYPE='INFO_STF' AND NNOTCLE = {txtInter.Tag}"))
      {
        if (reader.Read() && Utils.BlankIfNull(reader["CNOTINTERDIT"]) == "O")
        {
          MessageBox.Show($"{Resources.msg_ST_Interdit}{Environment.NewLine}{Utils.BlankIfNull(reader["VNOTMESS"])}", Program.AppTitle, MessageBoxButtons.OK, MessageBoxIcon.Information);
          return;
        }
      }

      // ouverture d'une fenetre d'information
      // information sur le groupe, recherche du groupe
      using (SqlDataReader reader = ModuleData.ExecuteReader($"SELECT NSTFGRPNUM FROM TSTF WITH (NOLOCK) WHERE NSTFNUM = {txtInter.Tag}"))
      {
        if (!reader.Read())
          return;

        DetailstravauxUtils.Info infoSTF = DetailstravauxUtils.RechercheInfos("INFO_STF", (int)Utils.ZeroIfNull(reader["NSTFGRPNUM"]));

        if (infoSTF.strInfo != "" && infoSTF.DateValDeb < DateTime.Now && infoSTF.DateValFin > DateTime.Now)
          new frmInfosClient
          {
            msStatut = "F",// sous-traitant
            msInfo = infoSTF.strInfo
          }.ShowDialog();
      }

      Timer2.Enabled = false;// pas de message
    }
    //Private Sub Timer2_Timer()
    //Dim infoSTF As Info
    //
    //'On Error Resume Next
    //Dim lRs As ADODB.Recordset
    //  
    //     
    //
    //  ' cas du technicien : exit
    //  If (Me.optInter(0)) Or (txtInter.Tag = "") Then
    //    Timer2.Enabled = False    ' pas de message soustraitant
    //    Exit Sub
    //  End If
    //
    //  ' information sur le st interdit ou pas
    //  Set lRs = New ADODB.Recordset
    //  lRs.Open "SELECT CNOTINTERDIT, VNOTMESS FROM TNOTES WITH (NOLOCK) WHERE VNOTTYPE='INFO_STF' AND NNOTCLE = " & txtInter.Tag, cnx
    //  If Not lRs.EOF Then
    //    If lRs(0) = "O" Then
    //      MsgBox "§Sous traitant interdit : §" & vbCrLf & lRs!VNOTMESS, vbInformation
    //      Exit Sub
    //    End If
    //  End If
    //
    //
    //  ' ouverture d'une fenetre d'information
    //  ' information sur le groupe, recherche du groupe
    //  Set lRs = New ADODB.Recordset
    //  lRs.Open "SELECT NSTFGRPNUM FROM TSTF WITH (NOLOCK) WHERE NSTFNUM = " & txtInter.Tag, cnx
    //  If lRs.EOF Then Exit Sub
    //  
    //  
    //  infoSTF = RechercheInfos("INFO_STF", lRs(0))
    //  
    //  If infoSTF.strInfo <> "" And infoSTF.DateValDeb < Date And infoSTF.DateValFin > Date Then
    //    frmInfosClient.strStatut = "F"  ' sous-traitant
    //    frmInfosClient.strInfo = infoSTF.strInfo
    //    frmInfosClient.Show vbModal
    //  End If
    //
    //  lRs.Close
    //  Set lRs = Nothing
    //
    //  Timer2.Enabled = False    ' pas de message
    //
    //End Sub
    //
    /* --------------------------------------------------------------------------------------- */
    private void TxtFactBudg_KeyPress(object sender, KeyPressEventArgs e)
    {
      // Contrôle de numéricité avec virgule
      KeyValidator.KeyPress_SaisieMontant(e);
    }

    //class cboTypeContratItem
    //{
    //  private int _id;
    //  private string _lib;
    //  public cboTypeContratItem(int id, string lib) { _id = id; _lib = lib; }
    //  public int ID
    //  {
    //    get { return _id; }
    //  }
    //  public string LIB
    //  {
    //    get { return _lib; }
    //  }
    //}
    //private void RemplirComboTypeContrat()
    //{
    //  if (!bInit) return;
    //  cboTypeContrat.ValueMember = "ID";
    //  cboTypeContrat.DisplayMember = "LIB";
    //  cboTypeContrat.Items.Add(new cboTypeContratItem(0, " "));
    //  cboTypeContrat.Items.Add(new cboTypeContratItem(2, Resources.lib_P2_afacturer));

    //  if ((int)ModuleData.ExecuteScalarInt($"SELECT COUNT(*) FROM TCONT WITH (NOLOCK) WHERE NSITNUM = {iSiteNum} AND NTYPECONTRAT = {iTypContrat}" +
    //                                       $" AND NMONTANTP3 IS NOT NULL") > 0)
    //  {
    //    cboTypeContrat.Items.Add(new cboTypeContratItem(3, Resources.lib_P3_non_facture));
    //  }
    //  else
    //  {
    //    cboTypeContrat.SelectedValue = 2;
    //    cboTypeContrat.Visible = lblTypeContrat.Visible = false;
    //  }
    //}

    private void RemplirComboSemaines()
    {
      //if (!bInit) return;
      cboSemaines.ValueMember = "ID";
      cboSemaines.DisplayMember = "LIB";
      for (int i = 1; i < 54; i++)
      {
        cboSemaines.Items.Add(i);
      }
    }


    class lstCatItem
    {
      private int _id;
      private string _lib;
      public lstCatItem(int NTYPECONTRAT, string VTYPECONTRAT) { _id = NTYPECONTRAT; _lib = VTYPECONTRAT; }
      public int NTYPECONTRAT
      {
        get { return _id; }
      }
      public string VTYPECONTRAT
      {
        get { return _lib; }
      }
    }
    private void cmdComp_Click(object sender, System.EventArgs e)
    {
      try
      {
        if (txtInter.Text == "") return;

        // si fenetre déjà affichée, on ferme
        if (framCompTech.Visible)
        {
          framCompTech.Visible = false;
          return;
        }

        // vider la listeBox
        lstCat.Items.Clear();
        lstCat.DisplayMember = "VTYPECONTRAT";

        using (SqlDataReader reader = ModuleData.ExecuteReader($"select T.NTYPECONTRAT, R.VTYPECONTRAT from tpertypecontrat T, TREF_TYPECONTRAT R WHERE NPERNUM = {txtInter.Tag} and T.ntypecontrat = R.ntypecontrat AND LANGUE = 'FR' ORDER BY VTYPECONTRAT"))
        {
          while (reader.Read())
            lstCat.SetItemChecked(lstCat.Items.Add(new lstCatItem((int)Utils.ZeroIfNull(reader["NTYPECONTRAT"]), Utils.BlankIfNull(reader["VTYPECONTRAT"]))), true);
        }

        framCompTech.Top = 1000 / 15;
        framCompTech.Left = 6500 / 15;
        framCompTech.Visible = true;
      }
      //catch (Exception ex) { MessageBox.Show($"{ex.Message}\r\n\r\n{Resources.Global_dans}{MethodBase.GetCurrentMethod().Name}", Resources.Global_Erreur, MessageBoxButtons.OK, MessageBoxIcon.Exclamation); }
      catch (Exception ex) { Utils.ShowError(ex, $"{MethodBase.GetCurrentMethod().Name} dans {this.Name}"); }
    }

    private void framCompTech_Click(object sender, EventArgs e)
    {
      framCompTech.Visible = false;
    }

    private void lstCat_Click(object sender, EventArgs e)
    {
      framCompTech.Visible = false;
    }

    private void cmdSite_Click(object sender, System.EventArgs e)
    {
      // type enquete  = Mozart téléphone (N) ou mail au client (O)
      new frmEnqueteQual()
      {
        NACTNUM = MozartParams.NumAction,
        TYPE_ENQUETE = "N",
        DROIT_REPONSE = "NON"
      }.ShowDialog();
      OuvertureEnModification();
    }

    //
    //' UPGRADE_INFO (#0501): The 'VerifAuto' member isn't used anywhere in current application.
    //'Private Function VerifAuto() As Boolean
    //'
    //'  VerifAuto = True
    //'
    //'  ' si c'est un sous traitant ne pas tester
    //'  If optInter(1) Or optInter(2) Or optInter(3) Then Exit Function
    //'
    //'  ' droit sur le planning
    //'  If Not RechercheDroitMenu(gintUID, 535) Then
    //'    MsgBox "§Vous n'avez pas les droits pour supprimer les planifications.§", vbExclamation + vbOKOnly
    //'    VerifAuto = False
    //'  End If
    //'End Function
    //
    /* --------------------------------------------------------------------------------------- */
    private void CmdCtct_Click(object sender, System.EventArgs e)
    {
      try
      {
        if (txtInter.Text == "") return;
        apiToolTip1.Texte = "";

        // test si on a un sous traitant ou pas
        StringBuilder txt = new StringBuilder(250);
        using (SqlDataReader reader = ModuleData.ExecuteReader($"select VINTNOM, VINTPRE, VINTTEL, VINTPOR, VINTMAIL from TINT WITH (NOLOCK) where CINTACTIF='O' AND NSTFNUM = {txtInter.Tag}"))
        {
          while (reader.Read())
          {
            txt.Append($"{Utils.BlankIfNull(reader["VINTNOM"])} {Utils.BlankIfNull(reader["VINTPRE"])} - {Utils.BlankIfNull(reader["VINTTEL"])} - " +
                       $"{Utils.BlankIfNull(reader["VINTPOR"])} - {Utils.BlankIfNull(reader["VINTMAIL"])}{Environment.NewLine}");
          }

          apiToolTip1.Top = 5000 / 15;
          apiToolTip1.Left = 3000 / 15;
          apiToolTip1.Texte = txt.ToString();
          apiToolTip1.Titre = Resources.msg_liste_contacts_STT;
          apiToolTip1.PrintTexte("");
          apiToolTip1.Visible = true;
        }
      }
      //catch (Exception ex) { MessageBox.Show($"{ex.Message}\r\n\r\n{Resources.Global_dans}{MethodBase.GetCurrentMethod().Name}", Resources.Global_Erreur, MessageBoxButtons.OK, MessageBoxIcon.Exclamation); }
      catch (Exception ex) { Utils.ShowError(ex, $"{MethodBase.GetCurrentMethod().Name} dans {this.Name}"); }
    }
    //Private Sub CmdCtct_Click()
    //
    //Dim rsD As New ADODB.Recordset
    //Dim txt As String
    //
    //On Error GoTo handler
    //  
    //  If txtInter = "" Then Exit Sub
    //  apiToolTip1.Texte = ""
    //
    //  ' test si on a un sous traitant ou pas
    //  rsD.Open "select VINTNOM, VINTPRE, VINTTEL, VINTPOR, VINTMAIL from TINT WITH (NOLOCK) where CINTACTIF='O' AND NSTFNUM = " & txtInter.Tag, cnx
    //  
    //  While Not rsD.EOF
    //    txt = txt & rsD(0) & " " & rsD(1) & " - " & rsD(2) & " - " & rsD(3) & " - " & rsD(4) & vbCrLf
    //    rsD.MoveNext
    //  Wend
    //  
    //  rsD.Close
    //  Set rsD = Nothing
    //  
    //  apiToolTip1.Top = 5000
    //  apiToolTip1.Left = 3000
    //  apiToolTip1.Texte = txt
    //  apiToolTip1.Titre = "§Liste des contacts du sous-traitant§"
    //  apiToolTip1.PrintTexte
    //  apiToolTip1.Visible = True
    //  
    //Exit Sub
    //Resume
    //handler:
    //  ShowError "CmdCtct_Click dans " & Me.Name
    //End Sub
    //
    //

    private void chkReclam_CheckedChanged(object sender, EventArgs e)
    {
      chkNCPriseEnCompte.Visible = cboCauseRacine.Visible = lblCauseRacine.Visible = cboProcess.Visible = lblProcess.Visible = chkReclam.Checked;
      chkNCPriseEnCompte.Enabled = ModuleMain.RechercheDroitMenu(chkNCPriseEnCompte.HelpContextID);
    }

    private void cmdConsult_Click(object sender, System.EventArgs e)
    {
      if (cboPrest.SelectedValue.ToString() == "B")
      {
        MessageBox.Show(Resources.msg_pouvez_pas_creer_consult_fournitures_prestation_garantie, Program.AppTitle, MessageBoxButtons.OK, MessageBoxIcon.Information);
        return;
      }
      new frmListeConsult
      {
        miAction = MozartParams.NumAction
      }.ShowDialog();
    }

    //'***************************************************************************************
    //'Test permettant de savoir si la personne est en temps partiel
    //'***************************************************************************************
    /* --------------------------------------------------------------------------------------- */
    private bool TestIfTpsPartiel(int idperson)
    {
      using (SqlDataReader reader = ModuleData.ExecuteReader($"SELECT NTYPTRAV FROM TPER WITH (NOLOCK) WHERE NPERNUM = {idperson}"))
      {
        if (reader.Read() && Utils.ZeroIfNull(reader["NTYPTRAV"]) == 2) return true;
      }
      return false;
    }

    //'***************************************************************************************
    //'Test permettant de savoir si la personne est en temps partiel
    //'***************************************************************************************
    /* --------------------------------------------------------------------------------------- */
    private bool TestIfCANChantier(int icannum)
    {
      using (SqlDataReader reader = ModuleData.ExecuteReader($"EXEC api_sp_TestIfCANChantier {icannum}"))
      {
        if (reader.Read() && Utils.ZeroIfNull(reader["FICCHANT"]) > 0) return true;
      }
      return false;
    }

    private void LoadHRChantier()
    {
      try
      {
        apiTGridHrChantier.LoadData(dtHRChantier, MozartDatabase.cnxMozart, $"EXEC api_sp_ListeFicheHRChantier {txtCompte.Text},{MozartParams.NumAction}, {Utils.ZeroIfNull(txtInter.Tag)}");
        apiTGridHrChantier.GridControl.DataSource = dtHRChantier;
      }
      //catch (Exception ex) { MessageBox.Show($"{ex.Message}\r\n\r\n{Resources.Global_dans}{MethodBase.GetCurrentMethod().Name}", Resources.Global_Erreur, MessageBoxButtons.OK, MessageBoxIcon.Exclamation); }
      catch (Exception ex) { Utils.ShowError(ex, $"{MethodBase.GetCurrentMethod().Name} dans {this.Name}"); }
    }

    private void InitApiTgridHrChantier()
    {
      apiTGridHrChantier.AddColumn(Resources.col_NIDFICHE, "NIDFICHE", 0);
      apiTGridHrChantier.AddColumn(Resources.col_libelle_lot, "VLIB", 4000);
      apiTGridHrChantier.AddColumn(Resources.col_nombre_heure, "NACTCHANTIERVAL", 1500, "", 1);

      apiTGridHrChantier.DelockColumn("NACTCHANTIERVAL");

      apiTGridHrChantier.InitColumnList();
    }

    private void InitRecordsetArticle()
    {
      try
      {
        dtHRChantier.Columns.Add(new DataColumn("NIDFICHE", Type.GetType("System.Int64")));
        dtHRChantier.Columns.Add(new DataColumn("VLIB", Type.GetType("System.String")));
        dtHRChantier.Columns.Add(new DataColumn("NACTCHANTIERVAL", Type.GetType("System.Int64")));
      }
      //catch (Exception ex) { MessageBox.Show($"{ex.Message}\r\n\r\n{Resources.Global_dans}{MethodBase.GetCurrentMethod().Name}", Resources.Global_Erreur, MessageBoxButtons.OK, MessageBoxIcon.Exclamation); }
      catch (Exception ex) { Utils.ShowError(ex, $"{MethodBase.GetCurrentMethod().Name} dans {this.Name}"); }
    }

    /* pas nécessaire car pas de table temporaire --------------------------------------------------------------------------------------- */
    //Private Sub AjouterEnreg(ByVal rs As ADODB.Recordset)
    //
    //On Error GoTo handler
    //
    //  ' ajout de l'enregistrement
    //  adorsHRChantier.AddNew
    //  
    //  adorsHRChantier("NIDFICHE").value = ZeroIfNull(rs("NIDFICHE"))
    //  adorsHRChantier("VLIB").value = BlankIfNull(rs("VLIB"))
    //  adorsHRChantier("NACTCHANTIERVAL").value = ZeroIfNull(rs("NACTCHANTIERVAL"))
    //  
    //  adorsHRChantier.Update
    //Exit Sub
    //Resume
    //handler:
    //  ShowError "AjouterEnreg dans " & Me.Name
    //End Sub

    //'**************************************************************************************************************
    //'Calcul le total en Heure chantier de tous les libelles de l'action
    //'**************************************************************************************************************
    /* --------------------------------------------------------------------------------------- */
    private int TotHrChantier()
    {
      int total = 0;
      foreach (DataRow r in dtHRChantier.Rows)
        total += (int)Utils.ZeroIfNull(r["NACTCHANTIERVAL"]);
      return total;
    }

    //'*************************************************************************************************************
    //'Test si document interne présent au passage de la ction en NF
    //'*************************************************************************************************************
    /* --------------------------------------------------------------------------------------- */
    private bool TestIfDocInterne()
    {
      if (MozartParams.NumAction == 0) return false;
      return (int)ModuleData.ExecuteScalarInt($"SELECT COUNT(*) FROM TIMAC WITH (NOLOCK) WHERE NACTNUM = {MozartParams.NumAction}" +
                                              $" AND CVUEWEB = 'N' AND CVUEWEB='N' AND VTYPE <> 'FACTURE' AND VTYPE <> 'AVOIR'") > 0;
    }

    private void CmdGIDT_Click(object sender, System.EventArgs e)
    {
      if (DetailstravauxUtils.VerifTypeClientGidt(iClientNum))
      {
        new frmListeCliGIDTObj
        {
          miNumClient = iClientNum,
          miNumSite = iSiteNum,
          mstrNomClient = txtClient.Text,
        }.ShowDialog();
      }
      else
      {
        new frmListeGIDTobj
        {
          miNumClient = iClientNum,
          miNumSite = iSiteNum,
          mstrNomClient = txtClient.Text
        }.ShowDialog();
      }
    }

    private void CmdDocTech_Click(object sender, System.EventArgs e)
    {
      new frmListDocOTTech()
      {
        mstrClient = txtClient.Text,
        mstrSite = txtSite.Text,
        mstrNumDI = txtDI.Text,
        mlAction = MozartParams.NumAction

      }.ShowDialog();


      // remise de la couleur du bouton
      if ((int)ModuleData.ExecuteScalarInt($"SELECT COUNT(NACTNUM) from TIMAC WITH (NOLOCK) where NACTNUM = {MozartParams.NumAction} AND VTYPE = 'DOCTECH'") > 0)
        CmdDocTech.BackColor = MozartColors.ColorH80FFFF;//Jaune pale
      else
        CmdDocTech.BackColor = MozartColors.ColorH8000000F;
    }

    private void cmdRecherchePrev_Click(object sender, System.EventArgs e)
    {
      // echerche des informations sur la prochaine prév
      using (SqlDataReader reader = ModuleData.ExecuteReader($"api_sp_DatePrev {MozartParams.NumDi},{MozartParams.NumAction}"))
      {
        if (reader.Read())
        {
          LblDatePrev.Text = Resources.lib_date_prochaine_preventive + Utils.DateLongBlankIfNull(reader[0]);
          if (Utils.BlankIfNull(reader["couleur"]) == "ROUGE")
          {
            LblDatePrev.ForeColor = Color.Red;// &HFF&
            cmdVoir.Visible = cmdLier.Visible = false;
          }
          else
          {
            LblDatePrev.ForeColor = Color.Orange;// &H80FF&
                                                 // si pas de date de planif, on peut afficher le bouton de liaison directe          
            cmdVoir.Visible = cmdLier.Visible = txtDateA1.Text == "";
          }
        }
      }
      cmdRecherchePrev.Visible = false;
    }

    private void cmdRechercheVille_Click(object sender, System.EventArgs e)
    {
      // recherche des informations sur la prochaine visite en ville
      using (SqlDataReader reader = ModuleData.ExecuteReader($"api_sp_DateVille {MozartParams.NumAction}"))
      {
        if (reader.Read() && Utils.DateLongBlankIfNull(reader[0]) != "")
        {
          lblVille.Text = Resources.lib_meme_ville + Utils.DateLongBlankIfNull(reader[0]);
          cmdVoirVille.Visible = cmdLierVille.Visible = txtDateA1.Text == "";
        }
      }
      cmdRechercheVille.Visible = false;
    }

    private void TabletInfo()
    {
      // on remonte les dates ARR et EXEC si dispo + ajout info de saisie dans observation
      // on ne saisie les champs dates que s'ils sont vides
      int iDataOK = 0;

      if (MozartParams.NumActTablet != 0)
      {
        using (SqlDataReader reader = ModuleData.ExecuteReader($"SELECT DACTARR, DACTDEX, convert(decimal(9,1),datediff(mi,DACTARR,DACTDEX)/60.0) AS DUREE" +
                                      $" FROM TACTTABLET WITH(NOLOCK) WHERE DDATVALIDATION IS NULL AND NACTNUM = {MozartParams.NumActTablet}"))
        {
          if (reader.Read())
          {
            if (txtDateA3.Text == "")
            {
              txtDateA3.Text = Utils.DateLongIfHMBlankIfNull(reader["DACTARR"]);
              if (txtDateA3.Text != "")
              {
                DateTime d3 = Convert.ToDateTime(reader["DACTARR"]);
                // heure et minute
                cboH.Text = d3.Hour.ToString("00");
                cboM.Text = d3.Minute.ToString("00");
                nSecondTempDatArr = d3.Second.ToString("00");
              }
            }
            else iDataOK++;

            if (txtDateA2.Text == "")
            {
              txtDateA2.Text = Utils.DateLongIfHMBlankIfNull(reader["DACTDEX"]);// date exécution
              if (txtDateA2.Text != "")
              {
                DateTime d2 = Convert.ToDateTime(reader["DACTDEX"]);
                // heure et minute
                cboHE.Text = d2.Hour.ToString("00");
                cboME.Text = d2.Minute.ToString("00");
                nSecondTempDatExe = d2.Second.ToString("00");
              }
            }
            else iDataOK++;

            // si iDataOK = 2, on est dans le cas ou date exec et arr etaient deja saisies donc pas d'observation
            if (iDataOK < 2)
              txtObserv.Text = $"{MozartParams.strUID} le {DateTime.Now.ToString("dd/MM/yy HH:mm")} : info Tablet de {txtInter.Text}" +
                               $" (la durée a pu être modifiée){Environment.NewLine}{txtObserv.Text}";
          }
        }

        // on ajoute les info attachement à la description de l intervention
        using (SqlDataReader reader = ModuleData.ExecuteReader($"exec api_sp_ReturnInfoAttachTablet {MozartParams.NumActTablet}"))
        {
          if (reader.Read())
          {
            StringBuilder sAttach = new StringBuilder();
            sAttach.Append($"{txtAction.Text}{Environment.NewLine}{Environment.NewLine}{Resources.lib_info_attach_tech}{Environment.NewLine}");
            if (Utils.BlankIfNull(reader["VATTACHCHAP1"]) != "")
              sAttach.Append($"{Resources.msg_detail_prestation_realisee}{Environment.NewLine}{Utils.BlankIfNull(reader["VATTACHCHAP1"])}{Environment.NewLine}{Environment.NewLine}");
            if (Utils.BlankIfNull(reader["VATTACHCHAP2"]) != "")
              sAttach.Append($"{Resources.msg_demande_complement_resp_site}{Environment.NewLine}{Utils.BlankIfNull(reader["VATTACHCHAP2"])}{Environment.NewLine}{Environment.NewLine}");
            if (Utils.BlankIfNull(reader["VATTACHCHAP3"]) != "")
              sAttach.Append($"{Resources.msg_remarques_tech}{Environment.NewLine}{Utils.BlankIfNull(reader["VATTACHCHAP3"])}{Environment.NewLine}{Environment.NewLine}");
            if (Utils.BlankIfNull(reader["VATTACHCHAP4"]) != "")
              sAttach.Append($"{Resources.msg_fournitures_prises_stock_client}{Environment.NewLine}{Utils.BlankIfNull(reader["VATTACHCHAP4"])}{Environment.NewLine}{Environment.NewLine}");
            if (Utils.BlankIfNull(reader["VATTACHCHAP5"]) != "")
              sAttach.Append($"{Resources.msg_fournitures_livrees_par}{MozartParams.GetNomSociete()}{Environment.NewLine}{Resources.msg_fournies_par_tech}{Utils.BlankIfNull(reader["VATTACHCHAP5"])}{Environment.NewLine}{Environment.NewLine}");
            if (Utils.BlankIfNull(reader["VATTACHCHAP6"]) != "")
              sAttach.Append($"{Resources.msmg_etat_demande_fin_intervention}{Environment.NewLine}{Utils.BlankIfNull(reader["VATTACHCHAP6"])}{Environment.NewLine}{Environment.NewLine}");

            txtAction.Text = sAttach.ToString();

            // remplir le champs N° attach si contrat EI avec le nom du tech (Fred le 03/09/13)
            if (iTypContrat == 247) txtAttach.Text = Strings.Left(txtInter.Text, 30);
          }
        }
      }
    }

    private void TabletInfoSTF()
    {
      int iDataOK = 0;

      if (MozartParams.NumActTablet != 0)
      {
        using (SqlDataReader reader = ModuleData.ExecuteReader($"SELECT DACTARR, DACTDEX, convert(decimal(9,1),datediff(mi,DACTARR,DACTDEX)/60.0) AS DUREE" +
                                                               $" FROM TACTTABLETSTF WITH(NOLOCK) WHERE DDATVALIDATION IS NULL AND" +
                                                               $" NACTNUM = {MozartParams.NumActTablet} AND NCSTNUM ={MozartParams.NumCSTTablet}"))
        {
          if (reader.Read())
          {
            if (txtDateA3.Text == "")
            {
              txtDateA3.Text = Utils.DateLongIfHMBlankIfNull(reader["DACTARR"]);
              if (txtDateA3.Text != "")
              {
                DateTime d3 = Convert.ToDateTime(reader["DACTARR"]);
                // heure et minute
                cboH.Text = d3.Hour.ToString("00");
                cboM.Text = d3.Minute.ToString("00");
                nSecondTempDatArr = d3.Second.ToString("00");
              }
            }
            else iDataOK++;

            if (txtDateA2.Text == "")
            {
              txtDateA2.Text = Utils.DateLongIfHMBlankIfNull(reader["DACTDEX"]);// date exécution
              if (txtDateA2.Text != "")
              {
                DateTime d2 = Convert.ToDateTime(reader["DACTDEX"]);
                // heure et minute
                cboHE.Text = d2.Hour.ToString("00");
                cboME.Text = d2.Minute.ToString("00");
                nSecondTempDatExe = d2.Second.ToString("00");
              }
            }
            else iDataOK++;

            // si iDataOK = 2, on est dans le cas ou date exec et arr etaient deja saisies donc pas d'observation
            if (iDataOK < 2)
              txtObserv.Text = $"{MozartParams.strUID} le {DateTime.Now.ToString("dd/MM/yy HH:mm")} : info Tablet STF de {txtInter.Text}" +
                               $" (la durée a pu être modifiée){Environment.NewLine}{txtObserv.Text}";
          }
        }

        using (SqlDataReader reader = ModuleData.ExecuteReader($"exec api_sp_ReturnInfoAttachTabletSTF {MozartParams.NumActTablet}, {MozartParams.NumCSTTablet}"))
        {
          if (reader.Read())
          {
            StringBuilder sAttach = new StringBuilder();
            sAttach.Append($"{txtAction.Text}{Environment.NewLine}{Environment.NewLine}{Resources.lib_info_attach_tech}{Environment.NewLine}");
            if (Utils.BlankIfNull(reader["VATTACHCHAP1"]) != "")
              sAttach.Append($"{Resources.msg_detail_prestation_realisee}{Environment.NewLine}{Utils.BlankIfNull(reader["VATTACHCHAP1"])}{Environment.NewLine}{Environment.NewLine}");
            if (Utils.BlankIfNull(reader["VATTACHCHAP2"]) != "")
              sAttach.Append($"{Resources.msg_demande_complement_resp_site}{Environment.NewLine}{Utils.BlankIfNull(reader["VATTACHCHAP2"])}{Environment.NewLine}{Environment.NewLine}");
            if (Utils.BlankIfNull(reader["VATTACHCHAP3"]) != "")
              sAttach.Append($"{Resources.msg_remarques_tech}{Environment.NewLine}{Utils.BlankIfNull(reader["VATTACHCHAP3"])}{Environment.NewLine}{Environment.NewLine}");
            if (Utils.BlankIfNull(reader["VATTACHCHAP4"]) != "")
              sAttach.Append($"{Resources.msg_fournitures_prises_stock_client}{Environment.NewLine}{Utils.BlankIfNull(reader["VATTACHCHAP4"])}{Environment.NewLine}{Environment.NewLine}");
            if (Utils.BlankIfNull(reader["VATTACHCHAP5"]) != "")
              sAttach.Append($"{Resources.msg_fournitures_livrees_emalec_fournies_par_tech}{Environment.NewLine}{Utils.BlankIfNull(reader["VATTACHCHAP5"])}{Environment.NewLine}{Environment.NewLine}");
            if (Utils.BlankIfNull(reader["VATTACHCHAP6"]) != "")
              sAttach.Append($"{Resources.msmg_etat_demande_fin_intervention}{Environment.NewLine}{Utils.BlankIfNull(reader["VATTACHCHAP6"])}{Environment.NewLine}{Environment.NewLine}");

            txtAction.Text = sAttach.ToString();
          }
        }
      }
    }

    private void cmdAnObs_Click(object sender, System.EventArgs e)
    {
      TxtObs.Text = "";
      framObs.Visible = false;
      NbEvenement = 0;
    }

    private void CmdOG_Click(object sender, System.EventArgs e)
    {
      if (cboPrest.SelectedValue.ToString() != "B")
      {
        MessageBox.Show(Resources.msg_pouvez_par_creer_ordre_intervention_garantie_prestation_hors_garantie, Program.AppTitle, MessageBoxButtons.OK, MessageBoxIcon.Information);
        return;
      }
      if (MozartParams.NumAction == 0)
      {
        MessageBox.Show(Resources.msg_enregistrer_action, Program.AppTitle, MessageBoxButtons.OK, MessageBoxIcon.Information);
        return;
      }
      if (txtInter.Text == "" || !IsSTFGarantie(MozartParams.NumAction))
      {
        MessageBox.Show(Resources.msg_select_STT_garantie, Program.AppTitle, MessageBoxButtons.OK, MessageBoxIcon.Information);
        return;
      }

      // test si on a un sous traitant ou pas
      if (IsSTF((string)lblInter.Tag) && optInter3.Checked)
      {
        // test si le ntinnum est bien enregistré
        if (!IsNINTNUMExist(MozartParams.NumAction))
        {
          MessageBox.Show(Resources.msg_enreg_action_pour_creer_ordre_intervention_garantie, Program.AppTitle, MessageBoxButtons.OK, MessageBoxIcon.Information);
          return;
        }

        // test si on a deja fait un OG pour cette action
        int nb = (int)ModuleData.ExecuteScalarInt($"select count(NACTNUM) from TOG WITH (NOLOCK) where NACTNUM ={MozartParams.NumAction}");
        if (nb > 0)
        {
          // si la DI n'est pas planifiée ou à planifier on ne peut pas créer d'OM
          new frmListeOG
          {
            iNumAct = MozartParams.NumAction
          }.ShowDialog();
        }
        else
        {
          new frmSaisieOG
          {
            miNumOG = 0,
            mstrStatut = "C",
            miAction = MozartParams.NumAction
          }.ShowDialog();
        }
        // rafraichir l'affichage
        OuvertureEnModification();
      }
      else
      {
        MessageBox.Show(Resources.msg_si_intervenant_STT_garantie_concurrent, Program.AppTitle, MessageBoxButtons.OK, MessageBoxIcon.Information);
      }
    }

    private void cmdValObs_Click(object sender, System.EventArgs e)
    {
      if (TxtObs.Text == "") return;
      // position en début de text quand focus et avec saut de ligne
      string temp = $"{MozartParams.strUID} le {DateTime.Now.ToString("dd/MM/yy HH:mm")} : ";
      string msg = TxtObs.Text.Replace("'", "''");
      if (txtObservM.Text == "")
        txtObservM.Text = temp + msg;
      else
        txtObservM.Text = temp + msg + Environment.NewLine + txtObservM.Text;

      framObs.Visible = false;
      NbEvenement = 0;
    }

    //'*********************************************************************************************************
    //'permet d afficher le option button selon le type de stf désiré : G = sous traitant en garantie
    //'*********************************************************************************************************
    /* --------------------------------------------------------------------------------------- */
    private void OptionAfficheTypeIntervenant(string sType)
    {
      if (sType == "G")
      {
        lblLabels19.Visible = false;
        optInter0.Visible = false;
        lblLabels25.Visible = false;
        optInter1.Visible = false;
        lblLabels38.Visible = false;
        optInter2.Visible = false;
        lblLabels40.Visible = ModuleMain.RechercheDroitMenu(586);
        optInter3.Visible = ModuleMain.RechercheDroitMenu(586);
        CmdOG.Visible = ModuleMain.RechercheDroitMenu(563);
      }
      else
      {
        lblLabels19.Visible = true;
        optInter0.Visible = true;
        lblLabels25.Visible = ModuleMain.RechercheDroitMenu(584);
        lblLabels25.Visible = ModuleMain.RechercheDroitMenu(584);
        optInter1.Visible = ModuleMain.RechercheDroitMenu(584);
        lblLabels38.Visible = ModuleMain.RechercheDroitMenu(585);
        optInter2.Visible = ModuleMain.RechercheDroitMenu(585);
        lblLabels40.Visible = false;
        optInter3.Visible = false;
        CmdOG.Visible = false;
      }
    }

    //
    //'************************************************************************************************************
    //'gestion des codes CACTTYT : T = tech, G = Garantie, I = Installation, S = maintenance selon le type sélectionné dans frmdetailstravaux
    //'************************************************************************************************************
    /* --------------------------------------------------------------------------------------- */
    private string CodeTypeSTF()
    {
      //  MC_OG
      if (optInter0.Checked) return "T";
      else if (optInter1.Checked) return "S";
      else if (optInter2.Checked) return "I";
      else if (optInter3.Checked) return "G";
      // Par défaut on coche S
      return "S";
    }

    //'*************************************************************************************************************
    //'Initialise l'intervenant
    //'*************************************************************************************************************
    /* --------------------------------------------------------------------------------------- */
    private void InitialiseIntervenant()
    {
      miSoustraitant = 0;
      miContact = 0;
      mstrTel = "";
      mstrPor = "";
      mstrTelAstr = "";

      txtInter.Tag = null;
      txtContact.Tag = null;
      txtInter.Text = "";
      txtContact.Text = "";
      txtFixe.Text = mstrTel;
      txtPort.Text = mstrPor;
      txtTelAstr.Text = mstrTelAstr;
    }

    //'************************************************************************************************************
    //'Teste si c'est un sous traitant (peu importe son type)
    //'************************************************************************************************************

    private bool IsSTF(string sInterTag)
    {
      switch (sInterTag)
      {
        case "S":
        case "I":
        case "G": return true;
        case "T": return false;
        default: return false;
      }
    }

    private bool IsNINTNUMExist(int inumAction)
    {
      using (SqlDataReader reader = ModuleData.ExecuteReader($"exec api_sp_RechercheIntSTFByAct {MozartParams.NumAction}"))
      {
        if (reader.Read() && Utils.ZeroIfNull(reader["NINTNUM"]) != 0) return true;
      }
      return false;
    }

    private bool IsSTFGarantie(int inumAction)
    {
      using (SqlDataReader reader = ModuleData.ExecuteReader($"exec api_sp_RechercheTypeSTFByAct {MozartParams.NumAction}"))
      {
        if (reader.Read() && Utils.BlankIfNull(reader["CACTTYT"]) == "G") return true;
      }
      return false;
    }

    //'**************************************************************************************************************
    //'permet de bloquer les boutons si on sélectionne une prestation appel en garantie
    //'**************************************************************************************************************
    //'Private Sub ButtonBlocageByPrest(ByVal bBlocked As Boolean)
    //'
    //'    If bBlocked = True Then
    //'
    //''        cmdDevis.Enabled = False
    //''        cmdContrat.Enabled = False
    //''        cmdOM.Enabled = False
    //'        CmdOG.Enabled = True        'OG
    //''        cmdDevisClt.Enabled = False
    //''        cmdPrepaCde.Enabled = False
    //''        cmdDdeStock.Enabled = False
    //''        cmdCommande.Enabled = False
    //''        cmdStock.Enabled = False
    //''        cmdPlanifier.Enabled = False
    //'        'cmdCourrier.Enabled = False
    //''        cmdConsult.Enabled = False
    //''        cmdLDR.Enabled = False
    //''        cmdInventaire.Enabled = False
    //'
    //''        cmdAct.Enabled = False
    //''        cmdCopie.Enabled = False
    //'        'cmdWeb.Enabled = False
    //'        'cmdImages.Enabled = False
    //'        'cmdDoc.Enabled = False
    //''        CmdDocTech.Enabled = False
    //''        CmdData.Enabled = False
    //''        cmdAttGam.Enabled = False
    //''        cmdCot.Enabled = False
    //''        cmdDI.Enabled = False
    //''        cmdMess.Enabled = False
    //'
    //'    Else
    //'
    //''        cmdDevis.Enabled = True
    //''        cmdContrat.Enabled = True
    //''        cmdOM.Enabled = True
    //'        CmdOG.Enabled = False        'OG
    //''        cmdDevisClt.Enabled = True
    //''        cmdPrepaCde.Enabled = True
    //''        cmdDdeStock.Enabled = True
    //''        cmdCommande.Enabled = True
    //''        cmdStock.Enabled = True
    //''        cmdPlanifier.Enabled = True
    //''        'cmdCourrier.Enabled = True
    //''        cmdConsult.Enabled = True
    //''        cmdLDR.Enabled = True
    //''        cmdInventaire.Enabled = True
    //''
    //''        cmdAct.Enabled = True
    //''        cmdCopie.Enabled = True
    //''        'cmdWeb.Enabled = True
    //''        'cmdImages.Enabled = True
    //''        'cmdDoc.Enabled = True
    //''        CmdDocTech.Enabled = True
    //''        CmdData.Enabled = True
    //''        cmdAttGam.Enabled = True
    //''        cmdCot.Enabled = True
    //''        cmdDI.Enabled = True
    //''        cmdMess.Enabled = True
    //'
    //'    End If
    //'
    //'End Sub
    //
    /* --------------------------------------------------------------------------------------- */
    private bool PrestModifiable()
    {

      // si on a une demande de devis si on a un devis, un cst, sortie de stock, ....
      // on bloque la sélection d'un appel en garantie.
      //    
      // si on a un ordre intervention en garantie de créer, on bloque la modification de la combo
      if (CmdOG.BackColor == MozartColors.ColorH80FFFF)
        return false;
      // si on a un devis, un cst, une sortie de stock, une commande, .... on bloque la sélection d'une prestation Appel en garantie
      else if (cmdDevis.BackColor == MozartColors.ColorH80FFFF || cmdContrat.BackColor == MozartColors.ColorH80FFFF || cmdOM.BackColor == MozartColors.ColorH80FFFF
              || cmdStock.BackColor == MozartColors.ColorH80FFFF || cmdCommande.BackColor == MozartColors.ColorH80FFFF || cmdLDR.BackColor == MozartColors.ColorH80FFFF
              || cmdInventaire.BackColor == MozartColors.ColorH80FFFF || cmdAct.BackColor == MozartColors.ColorH80FFFF || cmdConsult.BackColor == MozartColors.ColorH80FFFF
              || cmdDdeStock.BackColor == MozartColors.ColorH80FFFF || cmdAttGam.BackColor == MozartColors.ColorH80FFFF || cmdMess.BackColor == MozartColors.ColorH80FFFF
              || CmdDocTech.BackColor == MozartColors.ColorH80FFFF || cmdImages.BackColor == MozartColors.ColorH80FFFF || cmdOMT.BackColor == MozartColors.ColorH80FFFF
              || cmdCST.BackColor == MozartColors.ColorH80FFFF || cmdCSP.BackColor == MozartColors.ColorH80FFFF)
        return false;
      else
      {
        //  selon l'état de l'action on bloque la sélection d'une prestation Appel en garantie 
        string etat = (string)cboEtat.SelectedValue;
        if (etat == "E" || etat == "P" || etat == "D" || etat == "S" || etat == "B" || etat == "M")
          return false;
        // selon l'état de l'action on bloque la sélection d'une prestation Appel en garantie
        else if (txtEtatAdmin.Text == Resources.lib_chiffree || txtEtatAdmin.Text == Resources.lib_facturee)
          return false;
      }

      return true;
    }
    //Private Function PrestModifiable() As Boolean
    //
    //    'si on a une demande de devis si on a un devis, un cst, sortie de stock, ....
    //    'on bloque la sélection d'un appel en garantie.
    //    
    //    'si on a un ordre intervention en garantie de créer, on bloque la modification de la combo
    //    If CmdOG.BackColor = &H80FFFF Then
    //        
    //        PrestModifiable = False
    //   
    //    'si on a un devis, un cst, une sortie de stock, une commande, .... on bloque la sélection d'une prestation Appel en garantie
    //    ElseIf (cmdDevis.BackColor = &H80FFFF Or cmdContrat.BackColor = &H80FFFF Or cmdOM.BackColor = &H80FFFF Or cmdStock.BackColor = &H80FFFF Or cmdCommande.BackColor = &H80FFFF Or cmdLDR.BackColor = &H80FFFF Or _
    //            cmdInventaire.BackColor = &H80FFFF Or cmdAct.BackColor = &H80FFFF Or cmdConsult.BackColor = &H80FFFF Or cmdDdeStock.BackColor = &H80FFFF Or _
    //            cmdAttGam.BackColor = &H80FFFF Or cmdMess.BackColor = &H80FFFF Or CmdDocTech.BackColor = &H80FFFF Or _
    //            cmdImages.BackColor = &H80FFFF Or cmdCST.BackColor = &H80FFFF Or cmdCSP.BackColor = &H80FFFF) Then
    //        
    //        PrestModifiable = False
    //    
    //    'selon l'état de l'action on bloque la sélection d'une prestation Appel en garantie
    //    ElseIf (Chr(cboEtat.ItemData(cboEtat.ListIndex)) = "E" Or Chr(cboEtat.ItemData(cboEtat.ListIndex)) = "P" Or Chr(cboEtat.ItemData(cboEtat.ListIndex)) = "D" _
    //            Or Chr(cboEtat.ItemData(cboEtat.ListIndex)) = "S" Or Chr(cboEtat.ItemData(cboEtat.ListIndex)) = "B" Or Chr(cboEtat.ItemData(cboEtat.ListIndex)) = "M") Then
    //        
    //        PrestModifiable = False
    //    
    //     'selon l'état de l'action on bloque la sélection d'une prestation Appel en garantie
    //    ElseIf (txtEtatAdmin = "§Chiffré§" Or txtEtatAdmin = "§Facturé§") Then
    //        
    //        PrestModifiable = False
    //    
    //    Else
    //    
    //        PrestModifiable = True
    //                              
    //    End If
    //
    //End Function
    //
    /* --------------------------------------------------------------------------------------- */
    private bool VerifHrRdv()
    {
      if (txtInter.Tag == null || txtDateA1.Text == "" || !chkInfoSite.Checked || cboHrRDV.Text == "") return true;

      int nb = (int)ModuleData.ExecuteScalarInt($"SELECT count(*) FROM TACT INNER JOIN TACTCOMP ON TACT.NACTNUM = TACTCOMP.NACTNUM" +
                                                $" WHERE CACTINFOMAG = 'O' AND NPERNUM = {txtInter.Tag} AND DACTPLA = '{txtDateA1.Text}' " +
                                                $" AND left(VACTHRRDV,2) = '{cboHrRDV.Text}' " +
                                                $" AND right(VACTHRRDV,2) = '{cboMinRDV.Text}' AND TACT.NACTNUM <> {MozartParams.NumAction}");
      return nb == 0;
    }

    private void FormReadOnly()
    {
      cmdEnregistrer.Enabled = false;

      cmdDevis.Enabled = false;
      cmdContrat.Enabled = false;
      cmdCSP.Enabled = false;
      cmdCST.Enabled = false;
      cmdOM.Enabled = false;
      CmdOG.Enabled = false;
      cmdDevisClt.Enabled = false;
      cmdPrepaCde.Enabled = false;
      cmdDdeStock.Enabled = false;
      cmdCommande.Enabled = false;
      cmdStock.Enabled = false;
      cmdPlanifier.Enabled = false;
      cmdCourrier.Enabled = false;
      cmdConsult.Enabled = false;
      cmdLDR.Enabled = false;
      cmdInventaire.Enabled = false;
      cmdAct.Enabled = false;
      cmdCopie.Enabled = false;
      cmdWeb.Enabled = false;
      cmdBor.Enabled = false;
      cmdImages.Enabled = false;
      cmdDoc.Enabled = false;
      CmdDocTech.Enabled = false;
      CmdData.Enabled = false;
      cmdAttGam.Enabled = false;
      cmdCot.Enabled = false;
      cmdDI.Enabled = false;
      cmdMess.Enabled = false;
      cmdALC.Enabled = false;
      cmdEnvoiSynergee.Enabled = false;

      CboPPS.Enabled = false;
      CmdPPS.Enabled = false;

      chkWeb.Enabled = false;
      chkReclam.Enabled = false;
      chkP3.Enabled = false;
      cboPrest.Enabled = false;
      cboUrg.Enabled = false;
      cboTech.Enabled = false;
      txtduree.Enabled = false;
      txtValeur.Enabled = false;
      chkCMD.Enabled = false;
      cboGamme.Enabled = false;

      cboEtat.Enabled = false;

      cmdDate2.Enabled = false;
      cmdSupp2.Enabled = false;
      cmdBlockPave.Enabled = false;
      cmdVisuDevisSTT.Enabled = false;
      //cmdRelanceDatePla.Enabled = false;

      chkInfoSite.Enabled = false;
      txtQui.Enabled = false;

      cmdDate4.Enabled = false;
      cmdSupp4.Enabled = false;
      cmdDate3.Enabled = false;
      cmdSupp3.Enabled = false;

      ChkAttenteDevisTech.Enabled = false;

    }

    private bool ExisteSTTgarantie(int iNumsite)
    {
      int nb = (int)ModuleData.ExecuteScalarInt($"select count(nsitnum) from TSITLOTGAR where DDATFINGARANT > getdate() and NSITNUM ={iNumsite}");
      return nb > 0;
    }

    private void cboN4_Leave(object sender, EventArgs e)
    {
      if (cboN4.GetItemData() != 1 || cboN4.GetItemData() != 2)
        chkN4.Tag = cboN4.GetItemData();
      else
      {
        chkN4.Tag = 0;
        chkN4.Checked = false;
      }
    }

    private void chkN4_CheckedChanged(object sender, EventArgs e)
    {
      if (chkN4.Checked)
      {
        if (!DetailstravauxUtils.VerifExtN4(iSiteNum, MozartParams.NumAction) || MozartParams.NumAction == 0)
        {
          chkN4.Checked = false;
          return;
        }
        frmN4.Visible = true;
        cboN4.SetItemData((int)chkN4.Tag);
        frmN4.Top = 7800 / 14;
        frmN4.Left = 3000 / 15;
      }
      else
      {
        chkN4.Tag = 0;
        cboN4.SetItemData((int)chkN4.Tag);
        frmN4.Visible = false;
      }
    }

    private void chkVisaArr_CheckedChanged(object sender, EventArgs e)
    {
      if (bInit) return;
      if (!bDroitVisa)
      {
        chkVisaArr.Checked = !chkVisaArr.Checked;
        return;
      }
      if (chkVisaArr.Checked)
        chkVisaArr.Tag = MozartParams.UID;
      else
        chkVisaArr.Tag = 0;

      chkVisaArr.Text = "";
    }

    private void chkVisaExec_CheckedChanged(object sender, EventArgs e)
    {
      if (bInit) return;
      if (!bDroitVisa)
      {
        chkVisaExec.Checked = !chkVisaExec.Checked;
        return;
      }
      if (chkVisaExec.Checked)
        chkVisaExec.Tag = MozartParams.UID;
      else
        chkVisaExec.Tag = 0;

      chkVisaExec.Text = "";
    }

    private void cboH_SelectedValueChanged(object sender, EventArgs e)
    {
      if (!bInit && !bDroitVisa && chkVisaArr.Checked && cboH.Text != ((int)cboH.Tag).ToString("00"))
      {
        MessageBox.Show(Resources.msg_date_arrivee_verif_plus_modifiable, Program.AppTitle, MessageBoxButtons.OK, MessageBoxIcon.Information);
        cboH.Text = ((int)cboH.Tag).ToString("00");
        return;
      }
    }

    private void cboHE_SelectedValueChanged(object sender, EventArgs e)
    {
      if (!bInit && !bDroitVisa && chkVisaExec.Checked && cboHE.Text != ((int)cboHE.Tag).ToString("00"))
      {
        MessageBox.Show(Resources.msg_date_arrivee_verif_plus_modifiable, Program.AppTitle, MessageBoxButtons.OK, MessageBoxIcon.Information);
        cboHE.Text = ((int)cboHE.Tag).ToString("00");
        return;
      }
    }

    private void cboM_SelectedValueChanged(object sender, EventArgs e)
    {
      if (!bInit && !bDroitVisa && chkVisaArr.Checked && cboM.Text != ((int)cboM.Tag).ToString("00"))
      {
        MessageBox.Show(Resources.msg_date_arrivee_verif_plus_modifiable, Program.AppTitle, MessageBoxButtons.OK, MessageBoxIcon.Information);
        cboM.Text = ((int)cboM.Tag).ToString("00");
        return;
      }
    }

    private void cboME_SelectedValueChanged(object sender, EventArgs e)
    {
      if (!bInit && !bDroitVisa && chkVisaExec.Checked && cboME.Text != ((int)cboME.Tag).ToString("00"))
      {
        MessageBox.Show(Resources.msg_date_arrivee_verif_plus_modifiable, Program.AppTitle, MessageBoxButtons.OK, MessageBoxIcon.Information);
        cboME.Text = ((int)cboME.Tag).ToString("00");
        return;
      }
    }

    private void cboDevis_SelectedValueChanged(object sender, EventArgs e)
    {
      if (bFirst && cboDevis.Text != "Reçu")
        bFirst = false;
      else
      {
        if (cboDevis.Text == "Reçu" && !bFirst)
        {
          MessageBox.Show(Resources.msg_verifiez_prix_heure_deplace_dans_devis_STT, Program.AppTitle, MessageBoxButtons.OK, MessageBoxIcon.Information);
          bFirst = true;

          txtObserv.Text = $"Réception du devis du STT par {MozartParams.strUID} le {DateTime.Now.ToString("dd/MM/yy HH:mm")}" +
                           $"{Environment.NewLine}{txtObserv.Text}";

          // enregistrement de la date de retour dans la table des demande de devis
          // insertion de la notation automatique concernant le respect du délai de devis
          // note en fonction du delta entre date souhaitée du devis et date reçu du devis
          if (txtInter.Text == "") return;
          ModuleData.ExecuteNonQuery($"api_sp_creationNotationSTTautoDevis {MozartParams.NumAction},{txtContact.Tag},{txtInter.Tag}");
        }
      }
    }

    private string VerifStatutSTT(int iNACTNUM)
    {
      using (SqlDataReader reader = ModuleData.ExecuteReader($"api_sp_VerifStatutSTT {iNACTNUM}"))
      {
        if (reader.Read()) return Utils.BlankIfNull(reader["CODE"]);
      }
      return "N";
    }

    private void chkWeb_CheckedChanged(object sender, EventArgs e)
    {
      if (!bMsgDevisCL)
      {
        return;
      }

      if (!bPrem && !chkWeb.Checked)
      {
        if (!verifDevisValide())
        {
          MessageBox.Show($"{Resources.err_action_non_visible_car_devis_pas_valide}", Program.AppTitle, MessageBoxButtons.OK, MessageBoxIcon.Error);

          chkWeb.Checked = true;
          return;
        }

        if (MessageBox.Show($"{Resources.msg_souhaitez_passer_action_visible_par_client_sur_web}{Environment.NewLine}{Resources.msg_confirm_choix}", Program.AppTitle, MessageBoxButtons.YesNo,
                            MessageBoxIcon.Question, MessageBoxDefaultButton.Button2) != DialogResult.Yes)
          chkWeb.Checked = true;
      }
    }

    private bool devisExiste()
    {
      return (cmdDevisClt.BackColor == MozartColors.ColorH80FFFF);
    }

    // Retourne vrai si un devis pour l'action a été validé
    private bool verifDevisValide()
    {
      // Le devis est forcément valide s'il n'y en a pas
      if (!devisExiste())
      {
        return true;
      }

      // Hors web coché : Pas de contrainte pour le devis 
      if (chkWeb.Checked)
      {
        return true;
      }

      int nb = (int)ModuleData.ExecuteScalarInt($"SELECT count(*) FROM TDCL WHERE NACTNUM = {MozartParams.NumAction} AND (CDEVISTYPE = 'F' OR CDCLVALID = 'I' OR CDCLVALID = 'P')");

      return (nb > 0);
    }

    private void MnuLibAction_ItemClicked(object sender, ToolStripItemClickedEventArgs e)
    {
      try
      {
        switch (e.ClickedItem.Name)
        {
          case "toolStripMenuItem1":// Annuler
            return;
          case "toolStripMenuItem2":// Couper
            if (txtAction.SelectionLength > 0)
            {
              Clipboard.Clear();
              Clipboard.SetText(txtAction.SelectedText);
              txtAction.SelectedText = "";
            }
            break;
          case "toolStripMenuItem3":// Copier
            if (txtAction.SelectionLength > 0)
            {
              Clipboard.Clear();
              Clipboard.SetText(txtAction.SelectedText);
            }
            break;
          case "toolStripMenuItem4":// Coller
            txtAction.SelectedText = Clipboard.GetText();
            break;
          case "toolStripMenuItem5":// supprimer
            txtAction.SelectedText = "";
            break;
          case "toolStripMenuItem6":// sélectionner tout
            txtAction.SelectAll();
            break;
          case "toolStripMenuItem7":// Choisir modèle texte type
            frmModelTextTypeListe frm = new frmModelTextTypeListe();
            frm.ShowDialog();
            txtAction.SelectedText = frm.sTexteTypeReturn;
            break;
        }
      }
      //catch (Exception ex) { MessageBox.Show($"{ex.Message}\r\n\r\n{Resources.Global_dans}{MethodBase.GetCurrentMethod().Name}", Resources.Global_Erreur, MessageBoxButtons.OK, MessageBoxIcon.Exclamation); }
      catch (Exception ex) { Utils.ShowError(ex, $"{MethodBase.GetCurrentMethod().Name} dans {this.Name}"); }
    }
    //Private Sub MnuChoix_Click(Index As Integer)
    //
    //    On Error GoTo handler
    //
    //        Select Case Index
    //
    //            Case 0  'Annuler
    //                Exit Sub
    //            Case 1  'Couper
    //                If txtAction.SelLength > 0 Then
    //                    Clipboard.Clear
    //                    Clipboard.SetText txtAction.SelText
    //                    txtAction.SelText = ""
    //                End If
    //
    //            Case 2 'Copier
    //
    //                If txtAction.SelLength > 0 Then
    //                    Clipboard.Clear
    //                    Clipboard.SetText txtAction.SelText
    //                End If
    //            Case 3 'Coller
    //                txtAction.SelText = Clipboard.GetText
    //            Case 4 'supprimer
    //                txtAction.SelText = ""
    //            Case 5 'sélectionner tout
    //                txtAction.SelStart = 0
    //                txtAction.SelLength = Len(txtAction.Text)
    //            Case 6
    //
    //                Dim frm As New frmModelTextTypeListe
    //                frm.Show vbModal
    //
    //                txtAction.SelText = frm.sTexteTypeReturn
    //
    //                Set frm = Nothing
    //
    //        End Select
    //
    //Exit Sub
    //handler:
    //  ShowError "MnuChoix_Click dans frmDetailsTravaux"
    //End Sub
    //
    /* --------------------------------------------------------------------------------------- */
    private void cmdPrest_Click(object sender, System.EventArgs e)
    {
      if (DetailstravauxUtils.DiAsDevisClientPrest(MozartParams.NumAction))
      {
        new frmOTprestation
        {
          mstrStatutAction = (string)cboEtat.SelectedValue,
          msClient = txtClient.Text,
          msSite = txtSite.Text,
          msNumSite = txtNumSite.Text,
          msAction = txtAction.Text
        }.ShowDialog();
      }
      else
        MessageBox.Show(Resources.msg_pas_devis_di_pas_contrat_prest, Program.AppTitle, MessageBoxButtons.OK, MessageBoxIcon.Information);
    }

    //'Private Sub cmdSolar_Click()
    //'Dim count As Long
    //'Dim rs As ADODB.Recordset
    //'
    //'  On Error GoTo Handler
    //'
    //'' lien entre Emasolar et Emalec
    //'' création de la demande chez Emalec ou chez emasolar
    //'' sens EMALEC >= EMASOLAR
    //'
    //'  ' Update de l'action Emalec ou bien création de l'action et de la Di si necessaire ' sens EMALEC >= EMASOLAR
    //'  If gstrNomSociete = "EMALEC" Then
    //'    Select Case MsgBox("Vous allez créer ou modifier la DI sur EMASOLAR", vbYesNo + vbQuestion + vbDefaultButton2)
    //'      Case vbYes
    //'        cnx.Execute "Api_sp_CreationModifDIActionEmalecVersEmasolar " & glNumAction
    //'      Case vbNo
    //'        Exit Sub
    //'    End Select
    //'  End If
    //'
    //'  ' sens EMASOLARC >= EMALEC
    //'  If gstrNomSociete = "EMASOLAR" Then
    //'    Select Case MsgBox("Vous allez créer ou modifier la DI sur EMALEC", vbYesNo + vbQuestion + vbDefaultButton2)
    //'      Case vbYes
    //'        cnx.Execute "Api_sp_CreationDIActionEmalecEmasolar " & glNumAction
    //'      Case vbNo
    //'        Exit Sub
    //'    End Select
    //'  End If
    //'
    //'
    //''Set rs = New ADODB.Recordset
    //''rs.Open " select * from TLSOLAR where NACTEMASOLAR = " & glNumAction, cnx, adOpenStatic, adLockOptimistic
    //'
    //'  ' rafraichir l'affichage
    //'  OuvertureEnModification
    //'
    //'
    //'Exit Sub
    //'Handler:
    //'  Screen.MousePointer = vbDefault
    //'  ShowError "cmdSolar_Click dans " & Me.Name
    //'End Sub
    //
    /* --------------------------------------------------------------------------------------- */
    private void CmdGammeSelect_Click(object sender, System.EventArgs e)
    {

      int NGAMSelected;

      if (cboGamme.SelectedValue == null)
      {
        NGAMSelected = 0;
      }
      else
      {
        NGAMSelected = (int)cboGamme.SelectedValue;
      }

      frmGammeSelect frm = new frmGammeSelect()
      {
        mloNGAMNUM = NGAMSelected,
        mloNCLINUM = iClientNum,
        mloNSITNUM = iSiteNum
      };
      frm.ShowDialog();

      if (frm.mloNGAMNUM > 0)
        cboGamme.SelectedValue = frm.mloNGAMNUM;
    }

    private void CmdSuppGamme_Click(object sender, System.EventArgs e)
    {
      cboGamme.SelectedValue = 0;
    }

    private void TxtRDVPlageHR_KeyPress(object sender, KeyPressEventArgs e)
    {
      // Contrôle de numéricité
      KeyValidator.KeyPress_SaisieMontant(e);// test avec virgule
      if (txtRDV.Text != "" || cboHrRDV.Text != "" || cboMinRDV.Text != "")
      {
        MessageBox.Show($"{Resources.msg_saisie_plage_heure_impossible}{Environment.NewLine}{Resources.msg_definir_heure_rdv_ou_plage}", Program.AppTitle, MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
        e.Handled = true;
      }

    }

    private void txtRDV_KeyPress(object sender, KeyPressEventArgs e)
    {
      if (TxtRDVPlageHR0.Text != "" || TxtRDVPlageHR1.Text != "")
      {
        MessageBox.Show($"{Resources.msg_saisie_heure_rdv_impossible}{Environment.NewLine}{Resources.msg_definir_heure_rdv_ou_plage}", Program.AppTitle, MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
        e.Handled = true;
      }
    }

    private void cboHrRDV_Enter(object sender, EventArgs e)
    {
      if (TxtRDVPlageHR0.Text != "" || TxtRDVPlageHR1.Text != "")
      {
        MessageBox.Show($"{Resources.msg_saisie_heure_rdv_impossible}{Environment.NewLine}{Resources.msg_definir_heure_rdv_ou_plage}", Program.AppTitle, MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
        cboHrRDV.SelectedIndex = 0;
        TxtRDVPlageHR0.Focus();
      }
    }

    private void cboMinRDV_Enter(object sender, EventArgs e)
    {
      if (TxtRDVPlageHR0.Text != "" || TxtRDVPlageHR1.Text != "")
      {
        MessageBox.Show($"{Resources.msg_saisie_heure_rdv_impossible}{Environment.NewLine}{Resources.msg_definir_heure_rdv_ou_plage}", Program.AppTitle, MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
        cboHrRDV.SelectedIndex = 0;
        TxtRDVPlageHR0.Focus();
      }
    }

    private void CmdMailClient_Click(object sender, System.EventArgs e)
    {
      if (MozartParams.NumAction == 0)
      {
        MessageBox.Show(Resources.msg_enregistrer_action, Program.AppTitle, MessageBoxButtons.OK, MessageBoxIcon.Information);
        return;
      }

      // si hors web alors interdiction
      if (chkWeb.Checked)
      {
        MessageBox.Show($"{Resources.msg_envoi_mail_client_interdit}{Environment.NewLine}{Resources.msg_action_cochee_hors_web}", Program.AppTitle, MessageBoxButtons.OK, MessageBoxIcon.Information);
        return;
      }

      if (bModif)
      {
        MessageBox.Show(Resources.msg_enreg_modifs_pour_envoi_mail, Program.AppTitle, MessageBoxButtons.OK, MessageBoxIcon.Information);
        return;
      }

      new frmChoixDestMailByAction(MozartParams.NumAction, iClientNum).ShowDialog();

      // rafraichir l'affichage
      OuvertureEnModification();
    }
    //Private Sub CmdMailClient_Click()
    //    ' UPGRADE_INFO (#0501): The 'oShell' member isn't used anywhere in current application.
    //    ' Dim oShell As Object
    //    
    //    If glNumAction = 0 Then MsgBox "§Il faut enregistrer l'action§", vbInformation:: Exit Sub
    //        
    //    'si hors web alors interdiction
    //    If chkWeb.value = 1 Then
    //      MsgBox "§Envoi du mail au client interdit.§" & vbCrLf & "§L'action est cochée en hors web.§", vbExclamation
    //      Exit Sub
    //    End If
    //    
    //    If bModif Then
    //      MsgBox "§Enregistrez les modifications avant de pouvoir envoyer ce mail !§", vbInformation
    //      Exit Sub
    //    End If
    //    
    //    'utilisation de exec and wait, différent des autres mozart net
    //    If Not gModeActiveX Then
    //      ExecuteAndWait (gstrCheminProgramme & "\mozart\MozartNet.exe " & gstrNomServeur & " " & gstrNomSociete & " " & "frmChoixDestMailByAction " & glNumAction & "|" & iClientNum)
    //    Else
    //      OpenNetFormAndWait gstrCheminProgramme & "\mozart\MozartNet.exe " & gstrNomServeur & " " & gstrNomSociete & " " & "frmChoixDestMailByAction " & glNumAction & "|" & iClientNum, vbHide
    //    End If
    //
    //    'Shell gstrCheminProgramme & "\mozart\MozartNet.exe " & gstrNomServeur & " " & gstrNomSociete & " " & "frmChoixDestMailByAction " & glNumAction & "|" & iClientNum, vbNormalFocus, True
    //    
    //    ' rafraichir l'affichage
    //    OuvertureEnModification
    //    
    //End Sub
    //
    /* --------------------------------------------------------------------------------------- */
    private void envoiGDM()
    {
      // Préparation à l'envoi du fichier XML + pièces jointes par FTP à GDM
      // confirmation de l'envoi des données à GDM
      if (MessageBox.Show("Etes-vous sûr de vouloir envoyer les éléments à GDM ?", Program.AppTitle, MessageBoxButtons.YesNo,
                          MessageBoxIcon.Question, MessageBoxDefaultButton.Button2) != DialogResult.Yes)
      {
        return;
      }

      // si il y a un devis sur l'action, on demande à l'utilisateur si il veut l'envoyer
      bool bEnvoyerDevis = false;
      if (devisExiste())
      {
        if (MessageBox.Show("Voulez-vous joindre le devis à l'envoi ?", Program.AppTitle, MessageBoxButtons.YesNo,
                            MessageBoxIcon.Question, MessageBoxDefaultButton.Button2) == DialogResult.Yes)
        {

          // recherche si le devis est validé / édité
          int nb = (int)ModuleData.ExecuteScalarInt($"SELECT count(*) FROM TDCL WHERE NACTNUM = {MozartParams.NumAction} AND (CDEVISTYPE = 'F' OR CDCLVALID = 'I' OR CDCLVALID = 'P')");  //CDCLVALID = 'I'

          if (nb > 0)
            bEnvoyerDevis = true;
          else
          {
            MessageBox.Show($"Le devis pour cette action n'a pas été validé et édité, il ne peut pas être joint à l'envoi.", Program.AppTitle, MessageBoxButtons.OK, MessageBoxIcon.Error);
            return;
          }

        }
      }

      // recherche si cette action est déjà gérée dans la table GDM
      // FG le 24/11/20
      // on souhaite maintenant gérer une seule demande GDM par DI
      // on va donc vérifier si on a un numéro de demande GDM sur une action de la DI
      // on peut également être dans le cas ou on a déjà envoyé une DDSR ou une DISR sur une autre action de la DI
      // alors, sans numéro GDM, on peut renvoyer une nouvelle DDSR ou DISR sur cette action

      // FGA le 26/06/25
      // tenir compte du numéro GDM qui est saisi à la main sur les actions.
      // le rattacher à la demande GDM si elle existe dans la base.
      //  sinon, ajouter un enregistrement dans la base.
      // int NGDMNUM = DetailstravauxUtils.getNumGDM(MozartParams.NumDi);

      string obs = txtObserv.Text;
      DetailstravauxUtils.PrepaEnvoiGDM2(MozartParams.NumAction, MozartParams.NumDi, txtClient.Text, bEnvoyerDevis, txtNumGMAO.Text, ref obs);
      txtObserv.Text = obs;
    }

    private void cmdSuiviPlanEvacEI_Click(object sender, System.EventArgs e)
    {
      new frmSuiviPlansEvacuation(MozartParams.NumAction).ShowDialog();
    }

    private void cmdPPS_Click(object sender, System.EventArgs e)
    {
      // test si on a un sous traitant ou pas
      if (IsSTF((string)lblInter.Tag))
      {
        new frmGestPPS().ShowDialog();

        // rafraichir l'affichage
        OuvertureEnModification();
      }
    }

    private void chkMat_CheckedChanged(object sender, EventArgs e)
    {
      if (MozartParams.NumAction == 0 && chkMat.Checked)
      {
        // ajout dans l'observation de l'action
        txtObserv.Text = $" Coché matériel reçu le {DateTime.Now.ToString("dd/MM/yy HH:mm")} par {MozartParams.strUID}" +
                         $"{Environment.NewLine}{txtObserv.Text}";
      }
      else
      {
        if (!bInit && chkMat.Checked)
        {
          ModuleData.ExecuteNonQuery($"EXEC [api_sp_UpdateActionRecuSite] {MozartParams.NumAction},{(chkMat.Checked ? 'O' : 'N')}");

          LoadOnlyObservations();

          ModuleData.ExecuteNonQuery($"EXEC [api_sp_SendMailMaterielRecuSurSite] {MozartParams.NumAction},{iClientNum}");
        }
      }
    }

    private string SiteGIDT()
    {
      string ret = "";
      using (SqlDataReader reader = ModuleData.ExecuteReader($"select VSITCONCEPT from TSIT where NSITNUM={iSiteNum}"))
      {
        if (reader.Read()) ret = Utils.BlankIfNull(reader["VSITCONCEPT"]);
        reader.Close();
      }

      return ret;
    }

    private void LoadOnlyObservations()
    {
      // observations
      txtObserv.Text = ModuleData.ExecuteScalarString($"SELECT ISNULL(TACT.VACTOBS, '') AS VACTOBS FROM TACT WITH (NOLOCK) WHERE TACT.NACTNUM = {MozartParams.NumAction}");
    }

    private void cmdVisuGamme_Click(object sender, System.EventArgs e)
    {
      if (cboGamme.Text == "") return;

      // gestion gamme site ou gamme client
      if (Strings.Left(cboGamme.Text, 2) == "GC")
      {
        // si client GIDT par equipement
        string sTypeReport = frameGidtCli.Visible ? "TGAMMEEQUIP" : "TGAMME";

        new frmMainReport
        {
          bLaunchByProcessStart = false,
          sTypeReport = sTypeReport,
          sIdentifiant = $"{cboGamme.GetItemData()}",
          InfosMail = $"TINT|NSTFNUM|1",
          sNomSociete = MozartParams.NomSociete,
          sLangue = "FR",
          sOption = "PREVIEW"
        }.ShowDialog();
      }
      else
      {
        new frmMainReport
        {
          bLaunchByProcessStart = false,
          sTypeReport = "TGAMMESITE",
          sIdentifiant = $"{cboGamme.GetItemData() - 1000}",
          InfosMail = $"TINT|NSTFNUM|1",
          sNomSociete = MozartParams.NomSociete,
          sLangue = "FR",
          sOption = "PREVIEW"
        }.ShowDialog();
      }
    }

    private void CmdDuplicateAct_Click(object sender, System.EventArgs e)
    {
      // Pas d'action en cours, pas de possibilité de dupliquer
      if (MozartParams.NumAction == 0)
      {
        return;
      }

      string d = DateTime.Parse(txtDateA0.Text).AddDays(1).ToShortDateString();
      new frmChoixDuplPeriode(d, MozartParams.NumAction).ShowDialog();
    }

    private void cmdSpell_Click(object sender, System.EventArgs e)
    {
      Utils.SpellCheck(txtAction);
    }

    private void cmdTraduction_Click(object sender, System.EventArgs e)
    {
      txtAction.Text = Utils.Traduction(txtAction.Text);
    }

    private void CmdDetailAttachHeures_Click(object sender, System.EventArgs e)
    {
      new frmAttachDetailHr().ShowDialog();
    }

    private void cmdNotation_Click(object sender, System.EventArgs e)
    {
      new frmNotationSTT(MozartParams.NumAction).ShowDialog();
    }

    private bool ClientLie(string filiale)
    {
      int res = (int)ModuleData.ExecuteScalarInt($"SELECT COUNT(NCLIORIGINE) FROM TCLILIAISON L INNER JOIN TCLI C ON C.NCLINUM=L.NCLIDEST" +
                                                 $" WHERE NCLIORIGINE = {iClientNum} AND C.VSOCIETE = '{filiale}'");
      return res != 0;
    }

    private bool SiteLie(string filiale)
    {
      int res = (int)ModuleData.ExecuteScalarInt($"SELECT COUNT(NSITORIGINE) FROM TSITLIAISON L INNER JOIN TSIT S ON S.NSITNUM=L.NSITDEST" +
                                                 $" INNER JOIN TCLI C ON C.NCLINUM=S.NCLINUM" +
                                                 $" WHERE NSITORIGINE = {iSiteNum} AND C.VSOCIETE = '{filiale}'");
      return res != 0;
    }

    private bool ActionLie()
    {
      int res = (int)ModuleData.ExecuteScalarInt($"SELECT COUNT(NACTORIGINE) FROM TACTLIAISON WHERE NACTORIGINE = {MozartParams.NumAction}");
      return res != 0;
    }

    private bool RechercheGammeLie(string sGamme)
    {
      int res = (int)ModuleData.ExecuteScalarInt($"SELECT COUNT(NGAMORIGINE) FROM TGAMLIAISON G INNER JOIN TGAMCLIENT O ON G.NGAMORIGINE = O.NTRACLINUM" +
                                                 $" INNER JOIN TGAMCLIENT D ON G.NGAMDEST = D.NTRACLINUM INNER JOIN TCLI C ON C.NCLINUM = D.NCLINUM " +
                                                 $" WHERE O.NCLINUM = {iClientNum} AND G.NGAMORIGINE ={cboGamme.SelectedValue}" +
                                                 $" AND C.VSOCIETE = '{sGamme}'");
      return res != 0;
    }
    // version vb6 modifiée 29/04/22
    //Private Function RechercheGammeLie(ByVal sGamme As String) As Boolean
    //Dim sSQL As String

    //    RechercheGammeLie = False

    //    Dim adors_obs As New ADODB.Recordset


    //    sSQL = "SELECT COUNT(NGAMORIGINE) FROM TGAMLIAISON G INNER JOIN TGAMCLIENT O ON G.NGAMORIGINE = O.NTRACLINUM "
    //    sSQL = sSQL & "INNER JOIN TGAMCLIENT D ON G.NGAMDEST = D.NTRACLINUM INNER JOIN TCLI C ON C.NCLINUM = D.NCLINUM "
    //    sSQL = sSQL & " WHERE O.NCLINUM = " & iClientNum & " AND G.NGAMORIGINE = " & cboGamme.ItemData(cboGamme.ListIndex)
    //    sSQL = sSQL & " AND C.VSOCIETE = '" & sGamme & "'"

    //    adors_obs.Open sSQL, cnx, adOpenStatic, adLockReadOnly
    //    RechercheGammeLie = adors_obs(0)

    //    adors_obs.Close

    //End Function
    //Private Function RechercheGammeLie() As Boolean
    //Dim sSQL As String
    //
    //    RechercheGammeLie = False
    //
    //    Dim adors_obs As New ADODB.Recordset
    //    
    //    sSQL = "SELECT COUNT(NGAMORIGINE) FROM TGAMLIAISON G INNER JOIN TGAMCLIENT O ON G.NGAMORIGINE = O.NTRACLINUM"
    //    sSQL = sSQL & " WHERE O.NCLINUM = " & iClientNum & " AND G.NGAMORIGINE =" & cboGamme.ItemData(cboGamme.ListIndex)
    //
    //    adors_obs.Open sSQL, cnx, adOpenStatic, adLockReadOnly
    //    RechercheGammeLie = adors_obs(0)
    //
    //    adors_obs.Close
    //
    //End Function
    //
    /* --------------------------------------------------------------------------------------- */
    private void cmdHabilitation_Click(object sender, System.EventArgs e)
    {
      if (txtInter.Text == "") return;
      new frmMainReport
      {
        bLaunchByProcessStart = false,
        sTypeReport = "TCARTE",
        sIdentifiant = Utils.BlankIfNull(txtInter.Tag),
        InfosMail = "",
        sNomSociete = MozartParams.NomSociete,
        sLangue = "FR",
        sOption = "PREVIEW",
        strType = "PREVIEW"
      }.ShowDialog();
    }

    private bool DroitFacture(int numFac)
    {
      using (SqlDataReader reader = ModuleData.ExecuteReader($"api_sp_GetDroitUtilisateurSurFacture {numFac}"))
      {
        if (reader.Read() && Utils.BlankIfNull(reader["DROIT"]) == "O") return true;
      }
      return false;
    }

    private void cboInter_cboClick(object sender, EventArgs e)
    {
      foreach (Control item in (sender as apiCombo).Controls)
      {
        if (item is TextEdit)
          (item as TextEdit).SelectAll();
      }
    }

    private void LockButtons(Control.ControlCollection ctrls)
    {
      foreach (Control c in ctrls)
        if (c is Button) c.Enabled = false;
        else LockButtons(c.Controls);
    }

    private void cmdVisuDevisSTT_Click(object sender, EventArgs e)
    {
      if (!Pdf1.Visible)
      {
        string strRepFic = Utils.RechercheParam("REP_PHOTOS_ACT");
        // recherche des devis STT en doc interne
        using (SqlDataReader reader = ModuleData.ExecuteReader($"select * from TIMAC WITH (NOLOCK) where VTYPEDEST='I' AND NTYPEDOC=6 AND NACTNUM={MozartParams.NumAction}"))
        {
          if (reader.Read())
          {
            Pdf1.Navigate($"{strRepFic}{Utils.BlankIfNull(reader["VFICHIER"])}");
            using (Process p = new Process())
            {
              p.StartInfo.FileName = $"{strRepFic}{Utils.BlankIfNull(reader["VFICHIER"])}";
              p.StartInfo.UseShellExecute = true;
              p.Start();
            }
          }
          else
            Pdf1.Navigate("about:blank");
        }
        Pdf1.Visible = true;
        lblTitre.Visible = true;
      }
      else
      {
        Pdf1.Visible = false;
        lblTitre.Visible = false;
      }
    }

    private void CboPPS_SelectedValueChanged(object sender, EventArgs e)
    {

      //Aucun
      //Reçu
      //En cours

      if (bInit != true && CboPPS.Text == "Reçu")
      {
        txtObserv.Text = $"Réception du PPS par {MozartParams.strUID} le {DateTime.Now.ToString("dd/MM/yy HH:mm")}" +
                         $"{Environment.NewLine}{txtObserv.Text}";

      }
    }

    private void cboEtatCO_SelectionChangeCommitted(object sender, EventArgs e)
    {
      try
      {
        if (cboEtatCO.SelectedValue == null || cboEtatCO.SelectedValue.GetType() != Type.GetType("System.String")) return;

        // gestion statut complément uniquement sur "N"
        if ((string)cboEtatCO.SelectedValue == "2" || (string)cboEtatCO.SelectedValue == "4")
        { cboSemaines.Visible = true; }
        else
        {
          cboSemaines.SelectedIndex = -1;
          cboSemaines.Visible = false;
        }

        if ((string)cboEtatCO.SelectedValue == "1")
        { txtObserv.Text = $"{MozartParams.strUID} le {DateTime.Now.ToString("dd/MM/yy HH:mm")}: A STT" + $"{Environment.NewLine}{txtObserv.Text}"; }
        else if ((string)cboEtatCO.SelectedValue == "2")
        { txtObserv.Text = $"{MozartParams.strUID} le {DateTime.Now.ToString("dd/MM/yy HH:mm")}: Nok planning" + $"{Environment.NewLine}{txtObserv.Text}"; }
        else if ((string)cboEtatCO.SelectedValue == "3")
        { txtObserv.Text = $"{MozartParams.strUID} le {DateTime.Now.ToString("dd/MM/yy HH:mm")}: Anomalie action" + $"{Environment.NewLine}{txtObserv.Text}"; }
        else if ((string)cboEtatCO.SelectedValue == "4")
        { txtObserv.Text = $"{MozartParams.strUID} le {DateTime.Now.ToString("dd/MM/yy HH:mm")}: ABS TECH – Replanif en S" + $"{Environment.NewLine}{txtObserv.Text}"; }
      }
      catch (Exception ex) { Utils.ShowError(ex, $"{MethodBase.GetCurrentMethod().Name} dans {this.Name}"); }
    }

    private void cboSemaines_SelectionChangeCommitted(object sender, EventArgs e)
    {
      try
      {
        if (cboSemaines.SelectedItem == null) return;

        txtObserv.Text = $"{MozartParams.strUID} le {DateTime.Now.ToString("dd/MM/yy HH:mm")} : Nok planning S{(string)cboSemaines.Text}" +
           $"{Environment.NewLine}{txtObserv.Text}";
      }

      catch (Exception ex) { Utils.ShowError(ex, $"{MethodBase.GetCurrentMethod().Name} dans {this.Name}"); }

    }

    private void cboEtatAdminCpl_SelectionChangeCommitted(object sender, EventArgs e)
    {
      try
      {
        if (cboEtatAdminCpl.SelectedValue == null || cboEtatAdminCpl.SelectedValue.GetType() != Type.GetType("System.String")) return;

        // insertion d'une observation automatique en fonction du choix de la combo
        txtObserv.Text = $"{MozartParams.strUID} le {DateTime.Now.ToString("dd/MM/yy HH:mm")}: {txtEtatAdmin.Text} {cboEtatAdminCpl.Text}{Environment.NewLine}{txtObserv.Text}";

      }
      catch (Exception ex) { Utils.ShowError(ex, $"{MethodBase.GetCurrentMethod().Name} dans {this.Name}"); }
    }

    private void chkNCPriseEnCompte_CheckedChanged(object sender, EventArgs e)
    {
      // insertion d'une observation automatique en fonction du clic sur la coche
      if (chkNCPriseEnCompte.Checked == true)
        txtObserv.Text = $"{MozartParams.strUID} le {DateTime.Now.ToString("dd/MM/yy HH:mm")}: NC prise en compte.{Environment.NewLine}{txtObserv.Text}";
    }


    private void cboCauseRacine_SelectionChangeCommitted(object sender, EventArgs e)
    {
      if (cboCauseRacine.SelectedValue == null) return;

      // insertion d'une observation automatique en fonction du choix de la combo
      txtObserv.Text = $"{MozartParams.strUID} le {DateTime.Now.ToString("dd/MM/yy HH:mm")}: Saisie d'une non-conformité : {cboProcess.Text} - {cboCauseRacine.Text}{Environment.NewLine}{txtObserv.Text}";

    }

    private void chkP3_CheckedChanged(object sender, EventArgs e)
    {
      // insertion d'une observation automatique en fonction du clic sur la coche
      if (chkP3.Checked == true)
        txtObserv.Text = $"{MozartParams.strUID} le {DateTime.Now.ToString("dd/MM/yy HH:mm")}: Passage en type contrat P3.{Environment.NewLine}{txtObserv.Text}";
      else
        txtObserv.Text = $"{MozartParams.strUID} le {DateTime.Now.ToString("dd/MM/yy HH:mm")}: Suppression du type contrat P3.{Environment.NewLine}{txtObserv.Text}";
    }

    private void chkInfoSite_CheckedChanged(object sender, EventArgs e)
    {

      //if (bInit == true) return;      

      ////test si heure rendez-vous existe deja dans une des acions du pavé
      //if (chkInfoSite.CheckState == CheckState.Checked)
      //{
      //  if (ModuleData.ExecuteScalarInt($"EXEC [api_sp_GetRdv_By_Pave] {MozartParams.NumAction}") > 0)
      //  {
      //    MessageBox.Show("Vous ne pouvez pas valider ce RDV car il existe plusieurs heures dans la case « Rendez-vous »", Program.AppTitle, MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
      //    chkInfoSite.CheckState = CheckState.Unchecked;          
      //  }
      //}

    }

    private void Frame1_Enter(object sender, EventArgs e)
    {

    }

    private void cboEtat_SelectionChangeCommitted(object sender, EventArgs e)
    {

      //sauvegarde observations si passage en etat : a planifier
      if ((string)cboEtat.SelectedValue == "O") //&& cboEtat.Tag.ToString() != cboEtat.FindStringExact("A planifier").ToString())
      {
        txtObserv.Text = $"{MozartParams.strUID} le {DateTime.Now.ToString("dd/MM/yy HH:mm")} : Etat de l'action en 'A planifier'{Environment.NewLine}{txtObserv.Text}";
        CACT_LOG_ETAT_DETAIL oAct_Log_Etat_Adding = new CACT_LOG_ETAT_DETAIL();

        oAct_Log_Etat_Adding.NID_ACT_LOG_ETAT = 0;
        oAct_Log_Etat_Adding.NACTNUM = MozartParams.NumAction;
        oAct_Log_Etat_Adding.CETACOD = (string)cboEtat.SelectedValue;
        oAct_Log_Etat_Adding.NQUICREE = MozartParams.UID;
        oAct_Log_Etat_Adding.DQUICREE = DateTime.Now;
        oAct_Log_Etat_Adding.VQUICREE = MozartParams.strUID;

        oTabAct_Log_Etat.Add(oAct_Log_Etat_Adding);
        return;
      }

      // gestion statut complément uniquement sur "N"
      if ((string)cboEtat.SelectedValue == "N")
      {

        CACT_LOG_ETAT_DETAIL oAct_Log_Etat_Adding = new CACT_LOG_ETAT_DETAIL();
        oAct_Log_Etat_Adding.NID_ACT_LOG_ETAT = 0;
        oAct_Log_Etat_Adding.NACTNUM = MozartParams.NumAction;
        oAct_Log_Etat_Adding.CETACOD = (string)cboEtat.SelectedValue;
        oAct_Log_Etat_Adding.NQUICREE = MozartParams.UID;
        oAct_Log_Etat_Adding.DQUICREE = DateTime.Now;
        oAct_Log_Etat_Adding.VQUICREE = MozartParams.strUID;

        oTabAct_Log_Etat.Add(oAct_Log_Etat_Adding);
        return;
      }

    }

    private void ChkAttenteDevisTech_CheckedChanged(object sender, EventArgs e)
    {

      if (ChkAttenteDevisTech.Visible == false) return;
      if (bInit == true) return;

      if (!ChkAttenteDevisTech.Checked) return;

      //test si technicien sélectionnée
      if (ChkAttenteDevisTech.Checked && ((int)Utils.ZeroIfNull(txtInter.Tag) == 0 || Utils.BlankIfNull(txtInter.Tag).ToString() == ""))
      {
        MessageBox.Show($"Il faut sélectionner un technicien", Program.AppTitle, MessageBoxButtons.OK, MessageBoxIcon.Error);
        ChkAttenteDevisTech.Checked = false;
        return;
      }

      //on teste s'il faut cocher automatiquement le rappel
      //désactivé à la demande de bouyssi le 08/07/2024
      //if (GetDevisRappelExistsInDI() && ChkAttenteDevisTech.Checked == false)
      //{
      //    MessageBox.Show($"Vous ne pouvez pas décocher cette case à cocher. \r\nElle est automatiquement cochée car il y a déjà un rappel de devis technicien sur une des actions de cette DI !", Program.AppTitle, MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
      //    ChkAttenteDevisTech.Checked = true;
      //    return;
      //}

      if (ChkAttenteDevisTech.Checked)
      {
        txtObserv.Text = $"{MozartParams.strUID} {DateTime.Now.ToString("dd/MM/yy HH:mm")} : Coche relance devis tech à {txtInter.Text} {Environment.NewLine}{txtObserv.Text}";
      }

    }

    private void SetVisibleChkDevisAttenteCheckBox()
    {

      //si etat devis alors on affiche la case à cocher
      if ((string)cboEtat.SelectedValue == "D" && ((int)Utils.ZeroIfNull(txtInter.Tag) != 0 || Utils.BlankIfNull(txtInter.Tag).ToString() != "") && optInter0.Checked)
      {
        ChkAttenteDevisTech.Visible = LblAtttenteDevisTech.Visible = true;

        //on teste s'il faut cocher automatiquement le rappel
        //désactivé à la demande de bouyssi le 08/07/2024
        if (mstrStatutAction == "C" && GetDevisRappelExistsInDI() && ChkAttenteDevisTech.Checked == false && ((int)Utils.ZeroIfNull(txtInter.Tag) != 0 || Utils.BlankIfNull(txtInter.Tag).ToString() != ""))
        {
          ChkAttenteDevisTech.Checked = true;
          if (bInit == false) MessageBox.Show($"Cette case à cocher est automatiquement cochée car il y a déjà un rappel de devis technicien sur une des actions de cette DI !", Program.AppTitle, MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
        }

      }
      else
      {

        //modif du 19/05/2025 par mc : on force l'affichage la case a cocher attente devis tech si elle est coché
        ChkAttenteDevisTech.Visible = LblAtttenteDevisTech.Visible = ChkAttenteDevisTech.Checked;
        //ChkAttenteDevisTech.Visible = LblAtttenteDevisTech.Visible = false;
      }

    }

    private bool GetDevisRappelExistsInDI()
    {

      int iNBDevisRappel = 0;

      using (SqlDataReader reader = ModuleData.ExecuteReader($"EXEC [api_sp_GetExistsDevisRappelInDI] {MozartParams.NumDi}, {MozartParams.NumAction}"))
      {
        if (reader.Read())
        {
          iNBDevisRappel = (int)Utils.ZeroIfNull(reader["NB_DEVIS_RAPPEL"]);
        }
      }
      return iNBDevisRappel > 0 ? true : false;
    }

    private void cboUrg_SelectedValueChanged(object sender, EventArgs e)
    {
      updateTextKPI();
    }

    private void cmdAnnulerAstr_Click(object sender, EventArgs e)
    {
      txtObsAstr.Text = "";
      frameObsAstr.Visible = false;
    }

    private void cmdValiderAstr_Click(object sender, EventArgs e)
    {
      if (txtObsAstr.Text == "") return;

      // enregistrement de l'observation
      //  nactnum, InsertKeyMode int
      string sql = $"insert into tactchaffastr select {MozartParams.NumAction},{MozartParams.UID},'{DateTime.Now.ToString("dd/MM/yy HH:mm")}','{txtObsAstr.Text.Replace("'", "''")}'";
      ModuleData.ExecuteNonQuery(sql);

      // position en début de text quand focus et avec saut de ligne
      string temp = $"Observations Chargé d’astreinte {MozartParams.strUID} le {DateTime.Now.ToString("dd/MM/yy HH:mm")} : ";
      string msg = txtObsAstr.Text.Replace("'", "''");

      if (txtObservM.Text == "")
        txtObservM.Text = temp + msg;
      else
        txtObservM.Text = temp + msg + Environment.NewLine + txtObservM.Text;

      frameObsAstr.Visible = false;
    }

    private void cmdObsAstr_Click(object sender, EventArgs e)
    {
      frameObsAstr.Top = 8000 / 15;
      frameObsAstr.Left = 3600 / 15;
      txtObsAstr.Focus();
      frameObsAstr.Visible = true;
    }

    private void BtnInventaireEquip_Click(object sender, EventArgs e)
    {

      if (MozartParams.NumAction == 0)
      {

        if (bTousSites)
        {
          MessageBox.Show("Lors de la création d'une DI inventaire multisites, la sélection des équipements à inventorier par site est effectuée à l'enregistrement de l'action Master.", "Erreur", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
        }
        else
        {
          MessageBox.Show("Il faut enregistrer l'action avant de pouvoir affecter des équipements à inventorier", "Erreur", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
        }
        return;
      }

      List<string> listEtatToReadOnly = new List<string>() { "E", "P", "S" };

      string sNactINvId = MozartDatabase.ExecuteScalarString($"EXEC [api_sp_Action_Inventaire_Equipement_Get_Id] {MozartParams.NumAction}");

      bool readOnly = listEtatToReadOnly.Contains((string)cboEtat.SelectedValue);

      new frmListeSitesAndEquipementInventaireSelectedByAction((sNactINvId == "" ? 0 : Convert.ToInt32(sNactINvId)), MozartParams.NumAction, iSiteNum, iClientNum, ref readOnly)
      {
        //NACTNUM = MozartParams.NumAction,
        //NACT_INV_ID = sNactINvId == "" ? 0 : Convert.ToInt32(sNactINvId),
        //NSITNUM = iSiteNum,
        //NCLINUM = iClientNum,
        //readOnly = readOnly
      }.ShowDialog();

      //on mets à jour la durée et le montant
      if (!readOnly)
      {

        //on compare les montant et la durée
        //si différent alors on affiche un message informant que la durée et le montant vont être mis à jour

        decimal? totalDuree = null;
        decimal? totalMontant = null;

        SqlDataReader dr = MozartDatabase.ExecuteReader($"EXEC [api_sp_GetDureeAndMontantInventaireAction] {MozartParams.NumAction}");
        while (dr.Read())
        {
          if (dr["TOTAL_DUREE"] != DBNull.Value) totalDuree = (decimal)dr["TOTAL_DUREE"];
          if (dr["TOTAL_MONTANT"] != DBNull.Value) totalMontant = (decimal)dr["TOTAL_MONTANT"];
        }

        dr.Close();

        if (totalDuree != null)
        {
          if (txtduree.Text == "" || Convert.ToDecimal(txtduree.Text) != totalDuree)
          {
            MessageBox.Show($"Le nombre d'heures de l'action a été modifié selon le nombre d'heures total des équipements sélectionnés dans cet inventaire", $"Information", MessageBoxButtons.OK, MessageBoxIcon.Information);
            txtduree.Text = totalDuree.ToString();
          }

        }
        if (totalMontant != null)
        {
          if (txtValeur.Text == "" || Convert.ToDecimal(txtValeur.Text) != totalMontant)
          {
            MessageBox.Show($"Le montant de l'action a été modifié selon le montant total des équipements sélectionnés dans cet inventaire", $"Information", MessageBoxButtons.OK, MessageBoxIcon.Information);
            txtValeur.Text = totalMontant.ToString();

          }

        }

      }
      //ofrmListeSitesAndEquipementInventaireSelectedByAction.Dispose();



    }

    private void BtnRSD_Click(object sender, EventArgs e)
    {

      frmFicheSituDanger_Liste frmFicheSituDanger_Liste = new frmFicheSituDanger_Liste(iSiteNum);
      frmFicheSituDanger_Liste.ShowDialog();

    }
  }
}

