using DevExpress.XtraGrid.Views.Grid;
using Microsoft.VisualBasic;
using MozartCS.Properties;
using MozartNet;
using MozartLib;
using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.IO;
using System.Reflection;
using System.Windows.Forms;
using MZUtils = MozartControls.Utils;
using MozartCS.DetailIP;


namespace MozartCS
{
  public partial class frmAddAction : Form
  {
    // ouverture de la fenetre en création ou modification
    public string mstrStatutDI;
    public int miNumClient;
    public int miNumSite;
    public int miNumContrat;// contrat sur la di
    public static int iNumCanMulti; // compte analytique multi en cas de CESSION - static => utilisée par frmChoixCompteAna

    public string mstrDemandeur;
    public string mstrRefCli;

    public int miNumOBJgidt;// objet gidt

    public int miNumDIWeb;
    public string BrowseText;
    public int miNumDIMail;// Action venant de mail
    public int miNumDIGDM;// Action venant de GDM
    public string mTypeDemandeGDM;// "DD" ou "DI", venant de GDM
    public int miNumDISynergee;// Action venant de Synergee
    public string msNumDIKimoce;// Action venant de Kimoce
    public string msNumDIGeronimmo;// Action venant de geronimmo

    public int miNumDevisWeb;// action venant des devis tech sur le web
    public DateTime dDevisWebDate;// date de création du devis web du technicien
    public string sChaff;// chaff du client pour les devis web tech


    /*--------------------------------------------------------------*/
    private bool bModif;
    private DataTable dtRS = new DataTable();
    bool AlertSITE;
    bool AlertCte;
    bool ModCte;
    bool BChoixRaisonSoc;
    int iNumVEH;
    string cClientInterdit;
    bool bClientGIDT;
    bool bActionFacAstreinte = false; // si c'est une action astreinte

    // FGA gestion de la modification du contrat depuis la form Detailtravaux
    private void SetContrat(int s)
    {
      this.cboTypeContrat.SelectedValue = s;
    }

    /*---------------------parametres pour C_CANCOMP-----------------------------------------*/
    string sDateFinTrav;
    bool BCANTRAV;
    //Dim oCANCOMP As C_CANCOMP

    private class CompteItem
    {
      int _ACTIF;
      string _LIB;
      public int ACTIF
      {
        get { return _ACTIF; }
      }
      public string LIB
      {
        get { return _LIB; }
      }
      public CompteItem(int actif, string lib) { _ACTIF = actif; _LIB = lib; }
    }

    public frmAddAction() { InitializeComponent(); iNumCanMulti = 0; }

    public new DialogResult ShowDialog()
    {
      foreach (Form frm in Application.OpenForms)
      {
        if (this.Name == frm.Name)
        {
          MessageBox.Show(Resources.msg_impossible_affiche_planning, Program.AppTitle, MessageBoxButtons.OK, MessageBoxIcon.Information);
          this.Dispose();
          return DialogResult.Ignore;
        }
      }

      return base.ShowDialog();
    }

    /* OK --------------------------------------------------------------*/
    private void frmAddAction_Load(object sender, System.EventArgs e)
    {
      string chemin;

      try
      {
        Cursor.Current = Cursors.WaitCursor;
        ModuleMain.Initboutons(this);

        //  ' gestion de la combo enseigne
        //  bPrem = 0 
        //  If Me.mstrStatutDI = "C" Then bPrem = 2
        // => bPrem plus utilisé

        BChoixRaisonSoc = AlertCte = AlertSITE = false;
        ModCte = true;
        cmdPJ.Visible = false;

        //on chache le bouton par défaut
        BtnMajTrameInventaire.Visible = false;

        cboCond.Init(MozartDatabase.cnxMozart, "select NPERNUM, VPERNOM + ' ' + VPERPRE as VNOM from TPER where (cpertyp = 'CT' or cpertyp = 'CA' or cpertyp = 'BE')" +
                     " AND VSOCIETE = App_Name() AND CPERACTIF = 'O' AND BUTILISATEUR = 0 ORDER BY VPERNOM + ' ' + VPERPRE", "NPERNUM", "VNOM",
                     new List<string>() { Resources.col_Num, Resources.col_Nom }, 250, 550, true);

        switch (mstrStatutDI)
        {
          case "C":
            // creation
            OuvertureEnCreation();
            break;

          case "DIMail":
            // DI reçues par Mail
            OuvertureEnCreation();
            MozartParams.Action = BrowseText;
            chemin = Path.GetTempPath() + "Preview.html";
            File.WriteAllText(chemin, BrowseText.Replace("\r", "<br>"));
            Browser.Navigate(chemin);
            Browser.Visible = true;
            Browser.BringToFront();
            BrowseText = "";
            using (SqlDataReader reader = ModuleData.ExecuteReader($"select VDIMPJ FROM TDIMAIL WHERE NDIMNUM = {miNumDIMail}"))
            {
              cmdPJ.Visible = reader.Read() && Utils.BlankIfNull(reader["VDIMPJ"]) != "";
            }
            chkTSite.Enabled = false;
            break;

          case "DevWeb":
          case "DevWebSTT":
            // Devis reçues par web
            OuvertureEnCreation();
            // position sur le bon client
            cboclient.SetItemData(miNumClient);
            cboclient_Update(); //mise à jour des composants dépendants de cboclient
                                // recherche du compte du client selon le chaff
            using (SqlDataReader reader = ModuleData.ExecuteReader($"SELECT LTRIM(STR(TCAN.NCANNUM)) + ' - ' + vcanlib FROM TCAN WITH (NOLOCK) INNER JOIN TPER WITH (NOLOCK) ON TCAN.NPERNUM=TPER.NPERNUM INNER JOIN " +
                                          $" TREF_CTEANA ON TCAN.NCANNUM=TREF_CTEANA.NCANNUM WHERE TPER.VPERNOM='{sChaff}" +
                                          $"' AND TCAN.NCLINUM ={miNumClient} AND TCAN.CCANACTIF='O' AND TREF_CTEANA.VSOCIETE = App_Name()"))
            {
              if (reader.Read())
                _compte = cboCompte.Text = Utils.BlankIfNull(reader[0]);
            }

            //cboDemandeur.Items.Add(MozartParams.NomSociete);
            cboDemandeur.Text = MozartParams.GetNomSociete();

            txtRefCli.Text = $"{Resources.txt_suiteInter}{dDevisWebDate}";

            // position sur le bon site
            cboSite.SetItemData(miNumSite);
            cboSite_Update(); //mise à jour des composants dépendants de cboSite
                              // si un seul contrat, position sur le contrat
            if (cboTypeContrat.Items.Count == 2) cboTypeContrat.SelectedIndex = 1;

            chemin = Path.GetTempPath() + "Preview.html";
            File.WriteAllText(chemin, BrowseText);
            Browser.Navigate(chemin);
            Browser.Visible = true;
            Browser.BringToFront();
            BrowseText = "";
            break;

          case "I":
            // création a partir d'internet
            OuvertureEnCreationInternet();
            chkTSite.Enabled = false;
            break;

          case "GDM":
            // création a partir de GDM  13/07/2016
            OuvertureEnCreationGDM_SYNERGEE("GDM");
            using (SqlDataReader reader = ModuleData.ExecuteReader($"select VNOM FROM TGDM_LSTDOC WHERE NGDMNUM = {miNumDIGDM}"))
            {
              cmdPJ.Visible = reader.Read() && Utils.BlankIfNull(reader["VNOM"]) != "";
            }
            chkTSite.Enabled = false;
            break;

          case "DécisionGDM":
            // on passe directement à l'action
            // Pose des PJ sur l'action si elles existent
            EnregistrerPJ_GDM();
            OuvertureEnModification();
            cmdModifier.PerformClick();
            break;

          case "SYNERGEE":
          case "KIMOCE":
          case "GERONIMMO":
            // création a partir de SYNERGEE 13/01/2021
            // création a partir de KIMOCE 20/10/2021
            OuvertureEnCreationGDM_SYNERGEE(mstrStatutDI);
            chkTSite.Enabled = false;
            break;

          case "SuiviSYNERGEE":
          case "SuiviKIMOCE":
          case "SuiviGERONIMMO":
          case "DécisionWeb":
          case "MessageSTF":
          case "Tablet":
          case "TabletSTF":
            // on passe directement à l'action
            OuvertureEnModification();
            cmdModifier.PerformClick();
            break;

          default:
            // modification
            OuvertureEnModification();
            break;
        }

        bModif = false;

        (cboSite.Controls["lookup1"] as DevExpress.XtraEditors.LookUpEdit).CloseUp += new DevExpress.XtraEditors.Controls.CloseUpEventHandler(this.cboSite_CloseUp);
        (cboEnseigne.Controls["lookup1"] as DevExpress.XtraEditors.LookUpEdit).CloseUp += new DevExpress.XtraEditors.Controls.CloseUpEventHandler(this.cboEnseigne_CloseUp);
        (cboclient.Controls["lookup1"] as DevExpress.XtraEditors.LookUpEdit).CloseUp += new DevExpress.XtraEditors.Controls.CloseUpEventHandler(this.cboclient_CloseUp);
      }
      //catch (Exception ex) { MessageBox.Show($"{ex.Message}\r\n\r\n{Resources.Global_dans}{MethodBase.GetCurrentMethod().Name}", Resources.Global_Erreur, MessageBoxButtons.OK, MessageBoxIcon.Exclamation); }
      catch (Exception ex) { Utils.ShowError(ex, $"{MethodBase.GetCurrentMethod().Name} dans {this.Name}"); }
      finally { Cursor.Current = Cursors.Default; }
    }

    private long _lEnseigne = 0;
    private void cboEnseigne_CloseUp(object sender, DevExpress.XtraEditors.Controls.CloseUpEventArgs e)
    {
      if (e.CloseMode == DevExpress.XtraEditors.PopupCloseMode.Normal && (long)e.Value != _lEnseigne)
      {
        cboEnseigne_Update();
        _lEnseigne = (long)e.Value;
      }
    }
    private void cboEnseigne_Update()
    {
      // pour l'instant, cela ne fonctionne que lors de la creation d'une nouvelle DI.
      // lors de la modification, c'est compliqué de filtrer la combo des sites.

      if (mstrStatutDI == "C" || mstrStatutDI == "DIMail")
      {
        // on rempli les combo site et num site
        RemplirComboSite(cboEnseigne.GetText());

        // si un seul site, position sur le site
        if ((cboSite.DataSource() as DataTable).Rows.Count == 2)
        {
          AlertSITE = false;
          cboSite.SetItemData((int)(cboSite.DataSource() as DataTable).Rows[1][0]);
          cboSite_Update(); //mise à jour des composants dépendants de cboSite
        }
      }
    }
    //Private Sub cboEnseigne_Click()
    //
    //' pour l'instant, cela ne fonctionne que lors de la creation d'une nouvelle DI.
    //' lors de la modification, c'est compliqué de filtrer la combo des sites.
    //
    //
    //'  If bPrem < 2 Then
    //'    bPrem = bPrem + 1
    //'  Else
    //   If (Me.mstrStatutDI = "C" Or Me.mstrStatutDI = "DIMail") Then
    //     ' on rempli les combo site et num site
    //     RemplirComboSite cboSite, cboNumSite, cboclient.ItemData(cboclient.ListIndex), mstrStatutDI, cboEnseigne.Text
    //     
    //     ' si un seul site, position sur le site
    //     If cboSite.ListCount = 2 Then
    //       AlertSITE = False
    //       cboSite.ListIndex = 1
    //     End If
    //   End If
    //'  End If
    //End Sub
    //

    /* --------------------------------------------------------------------------------------- */
    private void cmdCanMulti_Click(object sender, EventArgs e)
    {
      new frmChoixCompteAna { miNumCli = cboclient.GetItemData() }.ShowDialog();
      cmdCanMulti.BackColor = iNumCanMulti != 0 ? MozartColors.ColorH80FFFF : MozartColors.ColorH8000000F;
    }
    //Private Sub cmdCanMulti_Click()
    //
    //   frmChoixCompteAna.iNumCli = cboclient.ItemData(cboclient.ListIndex)
    //   frmChoixCompteAna.Show vbModal
    //   If iNumCanMulti <> 0 Then cmdCanMulti.BackColor = &H80FFFF Else cmdCanMulti.BackColor = &H8000000F
    //End Sub
    //

    /* OK --------------------------------------------------------------------------------------- */
    private string _compte = "";
    private void cboCompte_SelectionChangeCommitted(object sender, EventArgs e)
    {
      bModif = true;

      //impossible de changer le compte si une action de la DI est facturée
      if (AlertCte && ModCte)
      {
        int iF = (int)ModuleData.ExecuteScalarInt($"select count(NACTNUM) from tact WITH (NOLOCK) where CACTSTA = 'F' and NDINNUM ={MozartParams.NumDi}");
        if (iF > 0)
        {
          if (!ModuleMain.RechercheDroitMenu(398))
          {
            MessageBox.Show(Resources.msg_impossibleChangerCompte, Program.AppTitle, MessageBoxButtons.OK, MessageBoxIcon.Information);
            cboCompte.Text = _compte;
            return;
          }
          else
          {
            //affichage message si on modifie le compte
            MessageBox.Show("Attention, assurez-vous qu’il n’y ait pas de dépenses ou factures de vente à modifier également en comptabilité. Le cas échéant, faire part de ce changement de compte analytique à la DAF. Merci. ", Program.AppTitle, MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
          }
        }
      }
      _compte = cboCompte.Text;

      // gestion compte de cession
      if (cboCompte.Text != "" && (Convert.ToInt32(Strings.Left(cboCompte.Text, Strings.InStr(cboCompte.Text, "-") - 1)) == 263 || Convert.ToInt32(Strings.Left(cboCompte.Text, Strings.InStr(cboCompte.Text, "-") - 1)) == 264) && MozartParams.NomSociete == "EMALEC")
      {
        cmdCanMulti.Visible = true;
        if (iNumCanMulti != 0) cmdCanMulti.BackColor = Color.Yellow;
        else cmdCanMulti.BackColor = MozartColors.ColorH8000000F;
      }
      else cmdCanMulti.Visible = false;

      // si 997, on affiche la combo vehicule
      if (cboCompte.Text != "" && Convert.ToInt32(Strings.Left(cboCompte.Text, Strings.InStr(cboCompte.Text, "-") - 1)) == 997)
      {
        lblLabels32.Visible = CboVehicule.Visible = true;

        Utils.InitComboBox(CboVehicule, "SELECT TVEHICULES.NVEHNUM, TVEHICULES.VVEHIMAT " +
                                        "FROM TVEHICULES WITH (NOLOCK) " +
                                        "WHERE TVEHICULES.CVEHACTIF = 'O' " +
                                        "AND TVEHICULES.VSOCIETE = APP_NAME() " +
                                        "UNION " +
                                        "SELECT TVEHICULES.NVEHNUM, TVEHICULES.VVEHIMAT " +
                                        "FROM TVEHICULES WITH (NOLOCK) " +
                                        $"WHERE TVEHICULES.NVEHNUM = {iNumVEH} AND TVEHICULES.NVEHNUM > 0 " +
                                        "AND TVEHICULES.VSOCIETE = APP_NAME() " +
                                        "ORDER BY VVEHIMAT");

        CboVehicule.SetItemData(iNumVEH.ToString());
      }
      else
        lblLabels32.Visible = CboVehicule.Visible = false;

      ModCte = true;

      // gestion des donnees CANCOMP
      // C_CANCOMP appelé que ici => création des fonctions ci-dessous 
      BCANTRAV = false;
      sDateFinTrav = "";
      BCANTRAV = TestCanTravC_CANCOMP();
      if (BCANTRAV) //CANTRAV = BCANTRAV
      {
        loadDataC_CANCOMP();
        Label3.Visible = txtDateFinTrav.Visible = cmdDateFinTrav.Visible = cmdSuppFinTrav.Visible = true;
        CalendarFinTrav.Visible = false;

        txtDateFinTrav.Text = sDateFinTrav;
      }
      else
      {
        Label3.Visible = txtDateFinTrav.Visible = cmdDateFinTrav.Visible = cmdSuppFinTrav.Visible = CalendarFinTrav.Visible = false;
        txtDateFinTrav.Text = "";
      }
    }

    private void loadDataC_CANCOMP()
    {
      using (SqlDataReader sdrLoad = ModuleData.ExecuteReader($"SELECT CONVERT(VARCHAR(20), TCANCOMP.DCANCOMPDFINTRAV, 103) AS DCANCOMPDFINTRAV FROM TCANCOMP WITH(NOLOCK) WHERE TCANCOMP.NCANNUM = {Strings.Left(cboCompte.Text, Strings.InStr(cboCompte.Text, "-") - 1)} AND TCANCOMP.VSOCIETE = '{MozartParams.NomSociete}'"))
      {
        if (sdrLoad.Read()) sDateFinTrav = Utils.BlankIfNull(sdrLoad["DCANCOMPDFINTRAV"]);
      }
    }

    private bool TestCanTravC_CANCOMP()
    {
      int iTemp = 0;
      if (Strings.Left(cboCompte.Text, 3) != "") iTemp = Convert.ToInt32(Strings.Left(cboCompte.Text, Strings.InStr(cboCompte.Text, "-") - 1));
      using (SqlDataReader sdrTest = ModuleData.ExecuteReader($"SELECT TREF_CTEANA.NCANNUM FROM TREF_CTEANA WITH(NOLOCK) WHERE TREF_CTEANA.CTYPECTE = 'T' AND TREF_CTEANA.NCANNUM = {iTemp} AND TREF_CTEANA.VSOCIETE = '{MozartParams.NomSociete}'"))
      {
        if (sdrTest.Read())
        {
          return true;
        }
      }
      return false;
    }
    /*Private Function TestCanTrav() As Boolean

    Dim breturn As Boolean
    Dim AdoRsTest As New ADODB.Recordset
    AdoRsTest.Open "SELECT TREF_CTEANA.NCANNUM FROM TREF_CTEANA WITH(NOLOCK) WHERE TREF_CTEANA.CTYPECTE = 'T' AND TREF_CTEANA.NCANNUM = " & NCANNUM & " AND TREF_CTEANA.VSOCIETE = '" & sSociete & "'", cnx, adOpenStatic, adLockReadOnly
    
    If AdoRsTest.RecordCount > 0 Then
        breturn = True
    Else
        breturn = False
    End If

    AdoRsTest.Close
    
    TestCanTrav = breturn

End Function*/

    /* OK --------------------------------------------------------------------------------------- */
    private void cmdValider_Click(object sender, EventArgs e)
    {
      try
      {
        // test de la sélection d'un client 
        if (cboclient.GetText() == "")
        {
          MessageBox.Show(Resources.msg_select_client, Program.AppTitle, MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
          return;
        }

        //test de la sélection d'un compte client
        if (cboCompte.Text == "")
        {
          MessageBox.Show(Resources.msg_clientPasCompteValideImpDI, Program.AppTitle, MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
          return;
        }

        //test de la sélection d'un site
        if (cboSite.GetText() == "" && !chkTSite.Checked)
        {
          MessageBox.Show(Resources.msg_select_site, Program.AppTitle, MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
          return;
        }

        // si le demandeur responsable site on doit saisir obligatoirement son nom
        if (cboDemandeur.Text == Resources.txt_respSite && txtdemAutre.Text == "")
        {
          MessageBox.Show(Resources.msg_specifierNomRespSite, Program.AppTitle, MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
          txtdemAutre.Focus();
          return;
        }

        // si le demandeur est autre on doit saisir obligatoirement son nom
        if (cboDemandeur.Text == Resources.txt_autre && txtdemAutre.Text == "")
        {
          MessageBox.Show(Resources.msg_speciferNomDemandeur, Program.AppTitle, MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
          txtdemAutre.Focus();
          return;
        }

        if (cboTypeContrat.Text == "")
        {
          MessageBox.Show(Resources.msg_must_select_contrat, Program.AppTitle, MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
          return;

        }

        // si on est en tous sites mais que le type de contrat choisi ne contient pas de site
        if (chkTSite.Checked)
        {
          if (NbSiteContrat(cboTypeContrat.Text, cboclient.GetItemData()) == 0)
          {
            MessageBox.Show(Resources.msg_aucunSiteContratSelect, Program.AppTitle, MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
            return;
          }
        }

        // test de la sélection d'un type de facturation
        if (!optFact0.Checked && !optFact1.Checked)
        {
          MessageBox.Show(Resources.msg_selectTypeFact, Program.AppTitle, MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
          return;
        }

        // Test si Conducteur de travaux sélectionné (si membre du groupe Morineau)
        if (cboCond.Visible && cboCond.GetText() == "")
        {
          MessageBox.Show("Sélectionnez un conducteur de travaux", Program.AppTitle, MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
          return;
        }

        // choix d'une raison sociale de facturation
        if (BChoixRaisonSoc && cboRais.Text == "")
        {
          MessageBox.Show(Resources.msg_select_raison_sociale_facturation, Program.AppTitle, MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
          return;
        }

        // si compte travaux, alors date envisage obligatoire
        if (txtDateFinTrav.Visible && txtDateFinTrav.Text == "")
        {
          MessageBox.Show(Resources.msg_dateReceptObligatoireTravaux, Program.AppTitle, MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
          return;
        }

        // si on est sur le compte 263 ou 264, on doit choisir un compte de cession
        if ((Convert.ToInt32(Strings.Left(cboCompte.Text, Strings.InStr(cboCompte.Text, "-") - 1)) == 263 || Convert.ToInt32(Strings.Left(cboCompte.Text, Strings.InStr(cboCompte.Text, "-") - 1)) == 264) && MozartParams.NomSociete == "EMALEC")
        {
          if (iNumCanMulti == 0)
          {
            MessageBox.Show(Resources.msg_selectCompteAnalytiqueCESSION, Program.AppTitle, MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
            cmdCanMulti.Focus();
            return;
          }
          // FGA le 26/10/22 demande de Sylvie il faut autoriser le contrat truc et le contrat machin et le contrat bidulle
          // alors j'enlève le controle et j'autorise tous les contrats et on vera ce que ça fait.
          // personne ne sais vraiment...
          //if (Convert.ToInt32(cboTypeContrat.SelectedValue) != 247)

          //{
          //  MessageBox.Show(Resources.msg_cessionAnalytiqueExtinctionInce, Program.AppTitle, MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
          //  cboTypeContrat.Focus();
          //  return;
          //}
        }

        // test si client interdit
        if (mstrStatutDI == "C" || mstrStatutDI == "DIMail")
        {
          // recherche si client interdit
          string strSQL = $"select isnull((SELECT CNOTINTERDIT FROM TNOTES WITH (NOLOCK) WHERE VNOTTYPE='INFO_CLIENT' " +
                          $"AND NNOTCLE={cboclient.GetItemData()}),'N')";
          using (SqlDataReader sdr = ModuleData.ExecuteReader(strSQL))
          {
            if (sdr.Read())
            {
              if (Utils.BlankIfNull(sdr[0]) == "O")
              {
                MessageBox.Show(Resources.msg_clientInterdit, Program.AppTitle, MessageBoxButtons.OK, MessageBoxIcon.Information);
                return;
              }
            }
          }
          // test si site interdit
          strSQL = $"select isnull((SELECT TOP 1 CNOTINTERDIT FROM TNOTES WITH (NOLOCK) WHERE VNOTTYPE='INFO_SITE' " +
                   $"AND NNOTCLE={cboSite.GetItemData()}),'N')";
          using (SqlDataReader sdr = ModuleData.ExecuteReader(strSQL))
          {
            if (sdr.Read())
            {
              if (Utils.BlankIfNull(sdr[0]) == "O")
              {
                MessageBox.Show("Site interdit !", Program.AppTitle, MessageBoxButtons.OK, MessageBoxIcon.Information);
                return;
              }
            }
          }
        }
        else if (mstrStatutDI == "M")
        {
          // si on est en modif, on fait les verifications sur le contrat EI
          if (Convert.ToInt32(cboTypeContrat.SelectedValue) == 247)
          {
            if (VerifBordereauExt(cboclient.GetItemData()) == 247)
            {
              MessageBox.Show(Resources.msg_creaInterventionExtincteur, Program.AppTitle, MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
              cboTypeContrat.Focus();
              return;
            }
          }
        }

        bool bEnrOK = enregistrerDI();

        // test d'un code retour ok ou pas
        if (bEnrOK)
        {
          // traitement des devis web
          if (mstrStatutDI == "DevWeb")
          {
            // enregistrement de la date de création
            ModuleData.CnxExecute($"update TWDEVIS set DWDEVDTRAITE = GetDate() where NWDEVNUM = {miNumDevisWeb}");
            //enregistrement de l'action
            enregistrerActionDevis();
            //pose des photos sur l'action si elles existent
            EnregistrerPhotos("DevWeb");

            //ouverture de la fenetre de modification d'une action
            new frmDetailstravaux
            {
              mstrDevisWeb = "OUI",
              mstrStatutAction = "M"
            }.ShowDialog();
          }
          else if (mstrStatutDI == "DevWebSTT")
          {
            // traitement des devis web
            //enreistrement de la date de création
            ModuleData.CnxExecute($"update TWDEVISSTT set DWDEVDTRAITE = GetDate() where NWDEVNUM = {miNumDevisWeb}");
            //enregistrement de l'action
            enregistrerActionDevis();
            //pose des photos sur l'action si elles existent
            EnregistrerPhotos("DevWebSTT");

            //ouverture de la fenetre de modification d'une action
            new frmDetailstravaux
            {
              mstrDevisWeb = "OUI",
              mstrStatutAction = "M"
            }.ShowDialog();
          }
          else if (mstrStatutDI == "I")
          {//DI qui arrivent par internet

            //enregistrement de l'action
            EnregistrerAction();

            // pose des photos sur l'action si elles existent
            EnregistrerDocs();
            //ouverture de la fenetre de modification d'une action
            new frmDetailstravaux
            {
              mstrStatutAction = "M",
              bWeb = true,
              bCreaWeb = true
            }.ShowDialog();
          }
          else if (mstrStatutDI == "GDM")
          {// DI ou DD qui arrivent par GDM 26/08/2016
            // enregistrement de l'action
            EnregistrerAction();
            ModuleData.CnxExecute($@"update TGDM set CGDMDILOCK = 'N', CSTATUT = 'I', NACTNUM = {MozartParams.NumAction}, 
                                  VDIEMALEC = '{MozartParams.NumDi}/{MozartParams.NumAction}', 
                                  VCONTACT = (select VPERMAILPRO FROM TPER INNER JOIN TDIN ON TDIN.VDINCHAFF = TPER.VPERADSI WHERE VSOCIETE = '{MozartParams.NomSociete}' AND NDINNUM = {MozartParams.NumDi}) 
                                  WHERE NGDMNUM = {miNumDIGDM}");

            // Pose des PJ sur l'action si elles existent
            EnregistrerPJ_GDM();

            frmDetailstravaux f = new frmDetailstravaux();
            f.mstrStatutAction = "M";
            f.bGDM = true;
            if (mTypeDemandeGDM == "DD") f.mstrPrest = "E";
            else if (mTypeDemandeGDM == "DI") f.mstrPrest = "D";
            f.ShowDialog();

            DetailstravauxUtils.ECRIRE_LOG_GDM(miNumDIGDM, $"{mTypeDemandeGDM} intégrée dans Mozart: Di n°{MozartParams.NumDi}/{MozartParams.NumAction}");
          }
          else if (mstrStatutDI == "SYNERGEE")
          {//Di qui arrivent par Synergee 20/01/2021
            //enregistrement de l'action
            EnregistrerAction();

            ModuleData.CnxExecute($"update TDISYNERGEE set CSYNDILOCK = 'N', CSTATUT = 'I', NACTNUM = {MozartParams.NumAction}, VDIEMALEC = '" +
                                  $"{MozartParams.NumDi}/{MozartParams.NumAction}', VCONTACT = (select VPERMAILPRO FROM TPER INNER JOIN TDIN ON TDIN.VDINCHAFF " +
                                  $" = TPER.VPERADSI WHERE VSOCIETE = '{MozartParams.NomSociete}' AND NDINNUM = {MozartParams.NumDi}) where NSYNNUM = {miNumDISynergee} and NSYNCLINUM = {cboclient.GetItemData()}");

            new frmDetailstravaux { mstrStatutAction = "M" }.ShowDialog();
          }
          else if (mstrStatutDI == "GERONIMMO")
          {//DI qui arrivent par Geronimmo 11/12/2024
            // enregistrement de l'action
            EnregistrerAction();

            //ModuleData.CnxExecute($"UPDATE TDIKIMOCE set CKIMDILOCK = 'N', CSTATUT = 'I', NACTNUM = {MozartParams.NumAction}, NDINNUM = {MozartParams.NumDi}, VDIEMALEC = '" +
            //                      $"{MozartParams.NumDi}/{MozartParams.NumAction}', VCONTACT = (select VPERMAILPRO FROM TPER INNER JOIN TDIN ON TDIN.VDINCHAFF " +
            //                      $" = TPER.VPERADSI WHERE VSOCIETE = '{MozartParams.NomSociete}' AND NDINNUM = {MozartParams.NumDi}) where NACTNUM = 0 AND NKIMNUM = '{msNumDIKimoce}'");

            ModuleData.CnxExecute($"UPDATE TDIGERONIMMO set CDILOCK = 'N', VSTATUT = 'E', NACTNUM = {MozartParams.NumAction}, NDINNUM = {MozartParams.NumDi}, " +
                                  //   $"VGERO_UExternalReference = '{MozartParams.NumDi}/{MozartParams.NumAction}', " +
                                  $"NQUIVALIDE = {MozartParams.UID} where NACTNUM = 0 AND VGERO_Number = '{msNumDIGeronimmo}'");

            new frmDetailstravaux { mstrStatutAction = "M" }.ShowDialog();
          }
          else if (mstrStatutDI == "KIMOCE")
          {//DI qui arrivent par KIMOCE
            // enregistrement de l'action
            EnregistrerAction();

            ModuleData.CnxExecute($"UPDATE TDIKIMOCE set CKIMDILOCK = 'N', CSTATUT = 'I', NACTNUM = {MozartParams.NumAction}, NDINNUM = {MozartParams.NumDi}, VDIEMALEC = '" +
                                  $"{MozartParams.NumDi}/{MozartParams.NumAction}', VCONTACT = (select VPERMAILPRO FROM TPER INNER JOIN TDIN ON TDIN.VDINCHAFF " +
                                  $" = TPER.VPERADSI WHERE VSOCIETE = '{MozartParams.NomSociete}' AND NDINNUM = {MozartParams.NumDi}) where NACTNUM = 0 AND NKIMNUM = '{msNumDIKimoce}'");


            new frmDetailstravaux { mstrStatutAction = "M" }.ShowDialog();
          }
          else if (mstrStatutDI == "DIMail")
          {//traitement des DI qui arrivent par mail
            // enregistrement de la date de création
            ModuleData.CnxExecute($"update TDIMAIL set NDINNUM = {MozartParams.NumDi}, DDIMTRAITE = GetDate(), NQUITRAITE = {MozartParams.UID} where NDIMNUM = {miNumDIMail}");
            // enregistrement de l'action
            EnregistrerAction();
            //Pose des PJ sur l'action si elles existent
            EnregistrerPJ();

            new frmDetailstravaux
            {
              mstrStatutAction = "M",
              bMail = true
            }.ShowDialog();
          }
          // on cache le browse
          Browser.Visible = false;

          // passage en statut modification
          mstrStatutDI = "M";

          AlertSITE = false;

          //Activation des boutons actions
          cmdAjouter.Enabled = cmdModifier.Enabled = cmdFact.Enabled = cmdSupprimer.Enabled = cmdCopier.Enabled = true;
        }

        OuvertureEnModification();

        bModif = false;
      }
      catch (Exception ex)
      {
        MZUtils.displayError(MethodBase.GetCurrentMethod().Name, ex);
      }
    }

    public int NbSiteContrat(string scontrat, int iclient)
    {
      try
      {
        using (SqlDataReader sdr = ModuleData.ExecuteReader($"api_sp_NbSitesParContrat '{scontrat.Replace("'", "''")}', {iclient}"))
        {
          //renvoi du type de contrat
          if (sdr.Read())
            return (int)Utils.ZeroIfNull(sdr["NBCONTRAT"]);
        }
      }
      catch (Exception ex)
      {
        MZUtils.displayError(MethodBase.GetCurrentMethod().Name, ex);
      }
      return 0;
    }

    /*Public Function NbSiteContrat(ByVal scontrat As String, ByVal iclient As Integer) As Integer

Dim srs As ADODB.Recordset


On Error GoTo handler

  Set srs = New ADODB.Recordset
  srs.Open "api_sp_NbSitesParContrat '" & scontrat & "', " & iclient, cnx

  ' renvoi du type de contrat
  ' renvoi du type de contrat
  If srs.EOF Then
    NbSiteContrat = 0
    Exit Function
  End If


  If IsNull(srs("NBCONTRAT")) Then
    NbSiteContrat = 0
  Else
    NbSiteContrat = srs("NBCONTRAT")
  End If


  srs.Close

Exit Function
handler:
  ShowError "RechercheContrat"
End Function*/

    public int VerifBordereauExt(int iNumCli)
    {
      return (int)ModuleData.ExecuteScalarInt($"SELECT COUNT(*) CPT FROM TSTOCKARTCLI WITH (NOLOCK) INNER JOIN TFOU WITH (NOLOCK) ON TFOU.NFOUNUM = TSTOCKARTCLI.NFOUNUM " +
                                              $"WHERE TSTOCKARTCLI.NCLINUM = {iNumCli} AND TFOU.NCFOCOD = 31");
    }

    /*Public Function VerifBordereauExt(ByVal iNumCli As Integer) As Integer
Dim sSQL As String
Dim rsverif As New ADODB.Recordset
    
    sSQL = "SELECT COUNT(*) CPT FROM TSTOCKARTCLI WITH (NOLOCK) INNER JOIN TFOU WITH (NOLOCK) ON TFOU.NFOUNUM = TSTOCKARTCLI.NFOUNUM " _
        & "WHERE TSTOCKARTCLI.NCLINUM = " & iNumCli & " AND TFOU.NCFOCOD = 31"
    rsverif.Open sSQL, cnx
    
    VerifBordereauExt = CInt(rsverif("CPT"))
  
    rsverif.Close
    
    Set rsverif = Nothing
  
End Function*/

    public int VerifMailRSF(int iNumCli)
    {
      int iTemp = (int)ModuleData.ExecuteScalarInt($"SELECT COUNT(*) CPT FROM TSIT WITH (NOLOCK) WHERE NCLINUM = {iNumCli} AND CSITACTIF = 'O'");
      if (iTemp > 10) return iTemp;

      return (int)ModuleData.ExecuteScalarInt($"SELECT COUNT(*) CPT FROM TRSF WITH (NOLOCK) WHERE NCLINUM = {iNumCli} AND CRSFACTIF = 'O' AND VRSFMAI IS NULL AND NRSFSITNUM IS NULL");
    }

    /*Public Function VerifMailRSF(ByVal iNumCli As Integer) As Integer
Dim sSQL As String
Dim rsverif As New ADODB.Recordset
    
    sSQL = "SELECT COUNT(*) CPT FROM TSIT WITH (NOLOCK) WHERE NCLINUM = " & iNumCli & " AND CSITACTIF = 'O'"
    rsverif.Open sSQL, cnx
    If CInt(rsverif("CPT")) > 10 Then
      VerifMailRSF = 0
      GoTo Fin
    End If
    
    rsverif.Close
    
    sSQL = "SELECT COUNT(*) CPT FROM TRSF WITH (NOLOCK) WHERE NCLINUM = " & iNumCli & " AND CRSFACTIF = 'O' AND VRSFMAI IS NULL AND NRSFSITNUM IS NULL"
    rsverif.Open sSQL, cnx
    
    VerifMailRSF = CInt(rsverif("CPT"))
  
Fin:
    rsverif.Close
    
    Set rsverif = Nothing
  
End Function*/

    /* --------------------------------------------------------------------------------------- */
    private void cmdInfoClientFacturation_Click(object sender, EventArgs e)
    {
      if (cboclient.GetItemData() <= 0) return;
      using (SqlDataReader reader = ModuleData.ExecuteReader($"select VCLIOBS from TCLI WITH (NOLOCK) WHERE NCLINUM = {cboclient.GetItemData()}"))
      {
        if (reader.Read())
          new frmInfo { msInfo = Utils.BlankIfNull(reader["VCLIOBS"]) }.ShowDialog();
      }
    }

    private void cmdFact_Click(object sender, EventArgs e)
    {
      try
      {
        DataRow row = ApiGrid.GetFocusedDataRow();
        if (null == row) return;

        MozartParams.NumAction = (int)Utils.ZeroIfNull(row["NACTNUM"]);

        // test de facturation pour les ldr
        // il faut que l'attestation soit faite
        if (Utils.BlankIfNull(row["VPRELIB"]) == Resources.col_leveeDeReserves)
        {
          int nb = (int)ModuleData.ExecuteScalarInt($"select count(*) from tact WITH (NOLOCK),TCOUR WITH (NOLOCK)where CCOURTYPCOUR='A' " +
                                                    $"and tact.NACTNUM=TCOUR.NACTNUM and ndinnum = {MozartParams.NumDi}");
          if (nb == 0)
          {
            MessageBox.Show(Resources.msg_attestLDR, Program.AppTitle, MessageBoxButtons.OK, MessageBoxIcon.Information);
            return;
          }
        }

        new frmElemFact
        {
          mchkTE = chkTE.Checked,
          mchkTSite = chkTSite.Checked,
          mstrAction = Utils.BlankIfNull(row["VACTDES"]),
          mstrStatutAction = Utils.BlankIfNull(row["CACTSTA"]),
          mstrSite = Utils.BlankIfNull(row["VSITNOM"]),
          mstrPrestation = Utils.BlankIfNull(row["VPRELIB"]),
          //prise en compte de la modification
          miNumSite = miNumSite == 0 ? (int)Utils.ZeroIfNull(row["NSITNUM"]) : miNumSite
        }.ShowDialog();

        // rafraichissement des données
        ApiGrid.Requery(dtRS, MozartDatabase.cnxMozart);

        // mise en page du tableau 
        InitApigrid();
      }
      //catch (Exception ex) { MessageBox.Show($"{ex.Message}\r\n\r\n{Resources.Global_dans}{MethodBase.GetCurrentMethod().Name}", Resources.Global_Erreur, MessageBoxButtons.OK, MessageBoxIcon.Exclamation); }
      catch (Exception ex) { Utils.ShowError(ex, $"{MethodBase.GetCurrentMethod().Name} dans {this.Name}"); }
    }
    //Private Sub cmdFact_Click()
    //    
    //Dim rsD As New ADODB.Recordset
    //' UPGRADE_INFO (#0501): The 'rsTva' member isn't used anywhere in current application.
    //' Dim rsTva As New ADODB.Recordset
    //Dim aux
    //
    //
    //On Error GoTo Handler
    //
    //  If adoRS.EOF Then Exit Sub
    //  
    //  glNumAction = adoRS("NACTNUM").value
    //  
    //  ' test de facturation pour les ldr
    //  ' il faut que l'attestation soit faite
    //  If adoRS("VPRELIB") = "§Levée de réserves§" Then
    //    rsD.Open "select count(*) from tact WITH (NOLOCK),TCOUR WITH (NOLOCK)where CCOURTYPCOUR='A' and tact.NACTNUM=TCOUR.NACTNUM and ndinnum = " & giNumDi, cnx
    //    If rsD(0) = 0 Then
    //      MsgBox "§Il faut faire l'attestation LDR avant de pouvoir chiffrer.§", vbInformation
    //      Exit Sub
    //    End If
    //    rsD.Close
    //    Set rsD = Nothing
    //  End If
    //    
    //  ' utile dans le cas de tous sites
    //  ' mauvaise gestion, on passe cela dans frmElemFact pour aider lors de la migration(FGA le 09/03/22)
    //'  frmNewElemFact.mstrAction = adoRs("VACTDES").value
    //'  frmNewElemFact.mstrStatutAction = adoRs("CACTSTA").value
    //'  frmNewElemFact.mstrSite = adoRs("VSITNOM").value
    //'  frmNewElemFact.mstrPrestation = adoRs("VPRELIB").value
    //'  frmNewElemFact.miNumSite = miNumSite
    //  
    //  frmElemFact.mchkTE = chkTE
    //  frmElemFact.mchkTSite = chkTSite
    //  
    //  frmElemFact.mstrAction = adoRS("VACTDES").value
    //  frmElemFact.mstrStatutAction = adoRS("CACTSTA").value
    //  frmElemFact.mstrSite = adoRS("VSITNOM").value
    //  frmElemFact.mstrPrestation = adoRS("VPRELIB").value
    //  frmElemFact.miNumSite = IIf(miNumSite = 0, adoRS("NSITNUM").value, miNumSite)
    //  frmElemFact.Show vbModal
    //  
    //  ' rafraichissement des données
    //  On Error Resume Next
    //  aux = adoRS.AbsolutePosition
    //  adoRS.Requery
    //  adoRS.AbsolutePosition = aux
    //    
    //  InitApigrid
    //     
    //Exit Sub
    //Handler:
    //  ShowError "cmdFact_click dans " & Me.Name
    //End Sub
    //

    /* --------------------------------------------------------------------------------------- */
    private void cmdSuivi_Click(object sender, EventArgs e)
    {
      new frmSuiviAnalytiqueDI(txtNumDI.Text).ShowDialog();
    }

    /* OK --------------------------------------------------------------------------------------- */
    //private void cmdListeFourNF_Click(object sender, EventArgs e)
    //{
    //  DataRow currentRow = ApiGrid.GetFocusedDataRow();
    //  if (currentRow == null) return;

    //  new frmListeChiffrageNF
    //  {
    //    miNumDI = Convert.ToInt32(txtNumDI.Text)
    //  }.ShowDialog();

    //  if (ExistFourNonFacturees(MozartParams.NumAction))
    //    cmdListeFourNF.BackColor = Color.Yellow;
    //  else
    //    cmdListeFourNF.BackColor = MozartColors.ColorH8000000F;
    //}


    /* OK --------------------------------------------------------------------------------------- */
    private void cmdAjouter_Click(object sender, EventArgs e)
    {
      try
      {
        // ouverture d'une fenetre d'information
        DetailstravauxUtils.Info InfoClient = DetailstravauxUtils.RechercheInfos("INFO_CLIENT", cboclient.GetItemData());
        if (InfoClient.strInfo != "" && InfoClient.DateValDeb < DateTime.Now && InfoClient.DateValFin > DateTime.Now)
        {
          new frmInfosClient
          {
            msStatut = "C", //client
            msInfo = InfoClient.strInfo
          }.ShowDialog();
        }


        // test si client interdit
        if (cClientInterdit == "O")
        {
          MessageBox.Show(Resources.msg_cliInter, Program.AppTitle, MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
          return;
        }

        // si contrat Extincteur : on doit avoir un bordereaux de prix
        if (Convert.ToInt32(cboTypeContrat.SelectedValue) == 247)
        {
          if (VerifBordereauExt(cboclient.GetItemData()) == 0)
          {
            MessageBox.Show(Resources.msg_creaInterventionExtincteur, Program.AppTitle, MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
            return;
          }

          //recherche des comptes ana incendie
          if (!IsCompteIncendie(Convert.ToInt32(Strings.Left(cboCompte.Text, Strings.InStr(cboCompte.Text, "-") - 1))))
          {
            MessageBox.Show(Resources.msg_extincIncendieCompteSpecifiquesEI + @"\r\n" + Resources.msg_fonctionsInfo,
                            Program.AppTitle, MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
            return;
          }
        }

        // test facture retard sur client EI
        ClientEIretard();

        // écran de création de l' action
        MozartParams.NumAction = 0;
        Cursor.Current = Cursors.WaitCursor;

        frmDetailstravaux frm = new frmDetailstravaux();

        // ajout d'un évennement sur frmDetailTravaux pour récupérer une modification du contrat
        frm.ModificationContrat += this.SetContrat;

        frm.mstrStatutAction = "C";
        frm.bWeb = false;
        frm.bMail = false;
        frm.ShowDialog();

        // rafraichissement du recordset
        ApiGrid.Requery(dtRS, MozartDatabase.cnxMozart);

        // mise en page du tableau
        InitApigrid();

        // init du boutons des fournitures non facturées
        cmdNF.Enabled = dtRS.Rows.Count != 0;
      }
      //catch (Exception ex) { MessageBox.Show($"{ex.Message}\r\n\r\n{Resources.Global_dans}{MethodBase.GetCurrentMethod().Name}", Resources.Global_Erreur, MessageBoxButtons.OK, MessageBoxIcon.Exclamation); }
      catch (Exception ex) { Utils.ShowError(ex, $"{MethodBase.GetCurrentMethod().Name} dans {this.Name}"); }
      finally { Cursor.Current = Cursors.Default; }
    }

    public bool IsCompteIncendie(int iCpte)
    {
      try
      {
        return (int)ModuleData.ExecuteScalarInt($"select count(*) from TREF_CTEANA where ctypecte = 'I' and NCANNUM = {iCpte} " +
                                                $"AND VSOCIETE = '{MozartParams.NomSociete}'") > 0;
      }
      catch (Exception ex)
      {
        MZUtils.displayError(MethodBase.GetCurrentMethod().Name, ex);
      }
      return false;
    }

    private void cmdModifier_Click(object sender, EventArgs e)
    {
      try
      {
        DataRow currentRow = ApiGrid.GetFocusedDataRow();
        if (currentRow == null) return;
        if (Convert.IsDBNull(currentRow["NACTNUM"]) || Utils.BlankIfNull(currentRow["NACTNUM"]) == "") return;

        // si le client est interdit on affiche un messgae
        if (cClientInterdit == "O") MessageBox.Show(Resources.msg_cliInter, Program.AppTitle, MessageBoxButtons.OK, MessageBoxIcon.Exclamation);

        // si client EI avec factures en retard afficher message
        // test facture retard sur client EI
        ClientEIretard();

        frmDetailstravaux frm = new frmDetailstravaux();
        // ajout d'un évennement sur frmDetailTravaux pour récupérer une modification du contrat
        frm.ModificationContrat += this.SetContrat;
        if (Utils.BlankIfNull(currentRow["CPRECOD"]) == "K")
        {
          // on affiche un message information que ce type d'action ne peut être modifiable qu'a partir de la liste des retours qualité
          MessageBox.Show($@"{Resources.msg_actionGestRetourQuali}{Environment.NewLine}{Resources.msg_traitementImpMenu}{Environment.NewLine}{Resources.msg_chargProcessActionListeAction}",
                          Program.AppTitle, MessageBoxButtons.OK, MessageBoxIcon.Exclamation);

          // écran de modification de l' action
          frm.sModeReadOnly = "1";
        }
        else
          frm.sModeReadOnly = "2";

        MozartParams.NumAction = (int)Utils.ZeroIfNull(currentRow["NACTNUM"]);
        Cursor.Current = Cursors.WaitCursor;

        frm.mstrStatutAction = "M";
        frm.ShowDialog();

        // rafraichissement du recordset
        ApiGrid.Requery(dtRS, MozartDatabase.cnxMozart);

        InitApigrid();
      }
      catch (Exception ex)
      {
        MZUtils.displayError(MethodBase.GetCurrentMethod().Name, ex);
      }
      finally { Cursor.Current = Cursors.Default; }
    }

    private void cmdSupprimer_Click(object sender, EventArgs e)
    {
      try
      {
        // suppression de l'action selectionnée
        DataRow currentRow = ApiGrid.GetFocusedDataRow();
        if (currentRow == null) return;

        // si l'état est P,C,T,E impossible de supprimer
        if (Utils.BlankIfNull(currentRow["CETACOD"]) == "P" || Utils.BlankIfNull(currentRow["CETACOD"]) == "E" ||
            Utils.BlankIfNull(currentRow["CACTSTA"]) == "C" || Utils.BlankIfNull(currentRow["CACTSTA"]) == "F")
        {
          MessageBox.Show($"{Resources.msg_impSuppAction}\r\n{Resources.msg_statutPermetPas}", Program.AppTitle, MessageBoxButtons.OK, MessageBoxIcon.Information);
          return;
        }

        // test si fournitures non facturées présentes sur cette action
        if (ExistFourNonFacturees((int)Utils.ZeroIfNull(currentRow["NACTNUM"])))
        {
          MessageBox.Show($"{Resources.msg_impSuppCetteAction}\r\n{Resources.msg_existeFournNonFact}", Program.AppTitle, MessageBoxButtons.OK, MessageBoxIcon.Information);
          return;
        }

        if (MessageBox.Show(Resources.msg_ConfirmDelAction, Program.AppTitle, MessageBoxButtons.YesNo, MessageBoxIcon.Question,
                            MessageBoxDefaultButton.Button2) != DialogResult.Yes)
          return;

        ModuleData.SupprimerEnreg((long)Utils.ZeroIfNull(currentRow["NACTNUM"]), "api_sp_SupprimerAction", "@iNumAction");

        //rafraichissement du recordset
        ApiGrid.Requery(dtRS, MozartDatabase.cnxMozart);

        //mise en page du tableau
        InitApigrid();

        // init du bouton des fournitures non facturées
        if (dtRS.Rows.Count == 0) cmdNF.Enabled = false;
      }
      catch (Exception ex)
      {
        MZUtils.displayError(MethodBase.GetCurrentMethod().Name, ex);
      }
    }

    private void cmdCopier_Click(object sender, EventArgs e)
    {
      try
      {
        DataRow row = ApiGrid.GetFocusedDataRow();
        if (null == row) return;

        if (MessageBox.Show($"§Voulez-vous vraiment copier cette action ?§", Program.AppTitle, MessageBoxButtons.YesNo,
                            MessageBoxIcon.Question, MessageBoxDefaultButton.Button2) != DialogResult.Yes) return;

        CopierAction((int)Utils.ZeroIfNull(row["NACTNUM"]));

        ApiGrid.Requery(dtRS, MozartDatabase.cnxMozart);

        // mise en page du tableau 
        InitApigrid();

        //  gbRefresh = True
      }
      //catch (Exception ex) { MessageBox.Show($"{ex.Message}\r\n\r\n{Resources.Global_dans}{MethodBase.GetCurrentMethod().Name}", Resources.Global_Erreur, MessageBoxButtons.OK, MessageBoxIcon.Exclamation); }
      catch (Exception ex) { Utils.ShowError(ex, $"{MethodBase.GetCurrentMethod().Name} dans {this.Name}"); }
    }

    private void cmdDec_Click(object sender, EventArgs e)
    {
      try
      {
        DataRow row = ApiGrid.GetFocusedDataRow();
        if (null == row) return;
        if (dtRS.Rows.Count < 2)
        {
          MessageBox.Show("§impossible car une seule action§", Program.AppTitle, MessageBoxButtons.OK, MessageBoxIcon.Information);
          return;
        }

        // si l'etat admin est  C ou F impossible de séparer
        if (Utils.BlankIfNull(row["CACTSTA"]) == "C" || Utils.BlankIfNull(row["CACTSTA"]) == "F")
        {
          MessageBox.Show($"§Impossible de séparer cette action : §{Environment.NewLine}§le statut ne le permet pas !§", Program.AppTitle, MessageBoxButtons.OK, MessageBoxIcon.Information);
          return;
        }

        if (MessageBox.Show($"§Voulez-vous vraiment séparer cette action ?§", Program.AppTitle, MessageBoxButtons.YesNo,
                            MessageBoxIcon.Question, MessageBoxDefaultButton.Button2) != DialogResult.Yes) return;

        int num = (int)ModuleData.ExecuteScalarInt($"api_sp_SéparerActionDeDI {row["NACTNUM"]}");

        MessageBox.Show($"§La DI : §{num}§ a été créée§", Program.AppTitle, MessageBoxButtons.OK, MessageBoxIcon.Information);

        ApiGrid.Requery(dtRS, MozartDatabase.cnxMozart);

        // mise en page du tableau 
        InitApigrid();

        //  gbRefresh = True
      }
      //catch (Exception ex) { MessageBox.Show($"{ex.Message}\r\n\r\n{Resources.Global_dans}{MethodBase.GetCurrentMethod().Name}", Resources.Global_Erreur, MessageBoxButtons.OK, MessageBoxIcon.Exclamation); }
      catch (Exception ex) { Utils.ShowError(ex, $"{MethodBase.GetCurrentMethod().Name} dans {this.Name}"); }
    }

    private void cmdFermer_Click(object sender, System.EventArgs e) { }

    private void frmAddAction_FormClosing(object sender, FormClosingEventArgs e)
    {
      // si il y a des modification
      if (bModif)
      {
        DialogResult res = MessageBox.Show(Resources.msgConfirm_enregistrerModif, Program.AppTitle,
                                           MessageBoxButtons.YesNoCancel, MessageBoxIcon.Question, MessageBoxDefaultButton.Button2);
        if (res == DialogResult.Cancel)
        {
          e.Cancel = true;
          return;
        }
        else if (res == DialogResult.Yes)
          cmdValider.PerformClick();
        Dispose();
      }
      else
        Cursor.Current = Cursors.WaitCursor;
    }

    /* ApiTelAuto1 à ApiTelAuto3 --------------------------------------------------------------------------------------- */
    private async void ApiTelAuto_Click(object sender, EventArgs e)
    {
      switch ((sender as Control).Name)
      {
        case "ApiTelAuto1":
          if (txtTelDem.Text == "")
          {
            MessageBox.Show("Numéro de téléphone non renseigné !", Program.AppTitle, MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
            return;
          }
          //ApiTelAuto1.TelDial(txtTelDem.Text);
          if (txtTelDem.Text != "")
          {
            string reponse = await CNumerotationAuto.MakeCallByAvaya(MozartParams.UserTelInt, txtTelDem.Text, Environment.MachineName);
            if (reponse != "OK")
            {
              MessageBox.Show(reponse, Program.AppTitle, MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
          }
          break;
        case "ApiTelAuto2":
          if (txtTelephone.Text == "")
          {
            MessageBox.Show("Numéro de téléphone non renseigné !", Program.AppTitle, MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
            return;
          }
          //ApiTelAuto2.TelDial(txtTelephone.Text);
          if (txtTelephone.Text != "")
          {
            string reponse = await CNumerotationAuto.MakeCallByAvaya(MozartParams.UserTelInt, txtTelephone.Text, Environment.MachineName);
            if (reponse != "OK")
            {
              MessageBox.Show(reponse, Program.AppTitle, MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
          }
          break;
        case "ApiTelAuto3":
          if (txtPortable.Text == "")
          {
            MessageBox.Show("Numéro de téléphone non renseigné !", Program.AppTitle, MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
            return;
          }
          //ApiTelAuto3.TelDial(txtPortable.Text);
          if (txtPortable.Text != "")
          {
            string reponse = await CNumerotationAuto.MakeCallByAvaya(MozartParams.UserTelInt, txtPortable.Text, Environment.MachineName);
            if (reponse != "OK")
            {
              MessageBox.Show(reponse, Program.AppTitle, MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
          }
          break;
      }
    }

    private void OuvertureEnCreation()
    {
      try
      {
        // date du jour
        TxtDate.Text = DateTime.Now.ToString();
        TxtCreateur.Text = "";
        iNumCanMulti = 0;
        // type de facturation
        optFact1.Checked = optFact0.Checked = false;
        // combo des clients
        cboclient.Init(MozartDatabase.cnxMozart, "select 0 as NCLINUM, '' as VCLINOM union select NCLINUM, VCLINOM from api_v_comboClient order by VCLINOM", "NCLINUM", "VCLINOM",
                      new List<string>() { Resources.col_Num, Resources.col_Nom }, 250, 550, true);

        cboclient_Update(); //mise à jour des composants dépendants de cboclient

        ApiGrid.LoadData(dtRS, MozartDatabase.cnxMozart, "select null as NACTID, null as NACTNUM,null,null,null,null,null,null,null,null,null");
        ApiGrid.GridControl.DataSource = dtRS;
        // initialisation de la liste
        InitApigrid();

        // desactivation des boutons actions
        cmdNF.Enabled = cmdSupprimer.Enabled = cmdCopier.Enabled = cmdFact.Enabled = cmdModifier.Enabled = cmdAjouter.Enabled = false;

        lblRais.Visible = cboRais.Visible = Frame8.Visible = false;

        chkPlanningWeb.Visible = true;
      }
      //catch (Exception ex) { MessageBox.Show($"{ex.Message}\r\n\r\n{Resources.Global_dans}{MethodBase.GetCurrentMethod().Name}", Resources.Global_Erreur, MessageBoxButtons.OK, MessageBoxIcon.Exclamation); }
      catch (Exception ex) { Utils.ShowError(ex, $"{MethodBase.GetCurrentMethod().Name} dans {this.Name}"); }
    }


    // les noms des colonnes sontles mêmes dans les 2 cas 
    // si mêmes champs => les créer 1 seule fois et modifer aspect selon chkTSite
    private void InitApigrid()
    {
      if (ApiGrid.dgv.Columns.Count == 0)
      {
        ApiGrid.AddColumn("N°", "NACTID", 400);
        ApiGrid.AddColumn(Resources.col_NumAction, "NACTNUM", 0);
        ApiGrid.AddColumn(Resources.col_Date_souhaitee, "DACTDAT", 900, "dd/mm/yy");
        ApiGrid.AddColumn("GMAO", "VACTNUMGMAO", 600);
        ApiGrid.AddColumn(Resources.col_Action, "VACTDES", 3000);
        ApiGrid.AddColumn(Resources.col_Date, "DACTDEX", 900, "dd/mm/yy");
        ApiGrid.AddColumn(Resources.col_Site, "VSITNOM", 1700);
        ApiGrid.AddColumn(Resources.col_Inter, "VACTINT", 600);
        ApiGrid.AddColumn(Resources.col_Prest, "CPRECOD", 500);
        ApiGrid.AddColumn(Resources.col_etat, "CETACOD", 500);
        ApiGrid.AddColumn(Resources.col_Administratif, "CACTSTA", 500);
        if (!chkTSite.Checked)
          ApiGrid.AddColumn(Resources.col_Observation, "VACTOBS", 3650);
        else
          ApiGrid.AddColumn(Resources.col_Observation, "VACTOBS", 2200);
        ApiGrid.AddColumn(Resources.col_Prestation, "VPRELIB", 0);
        ApiGrid.AddColumn("NSITNUM", "NSITNUM", 0);

        ApiGrid.InitColumnList();
        ApiGrid.DesactiveListe();
        ApiGrid.dgv.OptionsView.ColumnAutoWidth = false;
      }

      ApiGrid.dgv.Columns["VSITNOM"].Visible = chkTSite.Checked;
      ApiGrid.dgv.Columns["VACTOBS"].Width = chkTSite.Checked ? 220 : 365;

      if (!bActionFacAstreinte)
      {
        //  adoRS.Find ("NACTNUM = " & glNumAction)
        for (int i = 0; i < dtRS.Rows.Count; i++)
        {
          if ((int)Utils.ZeroIfNull(dtRS.Rows[i]["NACTNUM"]) == MozartParams.NumAction)
          {
            (ApiGrid.GridControl.DefaultView as GridView).FocusedRowHandle = i;
            ApiGrid_SelectionChanged(null, null);
          }
        }
      }
    }
    //Private Sub InitApigrid()
    //  
    //On Error GoTo Handler
    //
    //    apigrid.ReInitGrid
    //    
    //  If Me.chkTSite.value = 0 Then
    //    apigrid.AddColumn "N°", 400
    //    apigrid.AddColumn "§NumAction§", 0
    //    apigrid.AddColumn "§Date souhaitée§", 900, "dd/mm/yy"
    //    apigrid.AddColumn "GMAO", 600
    //    apigrid.AddColumn "§Action§", 5500
    //    apigrid.AddColumn "§Date §", 900, "dd/mm/yy"
    //    apigrid.AddColumn "§Site§", 0
    //    apigrid.AddColumn "§Inter§", 500
    //    apigrid.AddColumn "§Prest§", 300
    //    apigrid.AddColumn "§Etat§", 300
    //    apigrid.AddColumn "§Administratif§", 300
    //    apigrid.AddColumn "§Observation§", 3650
    //    apigrid.AddColumn "§Prestation§", 0
    //    apigrid.AddColumn "NSITNUM", 0
    //  Else
    //    apigrid.AddColumn "N°", 400
    //    apigrid.AddColumn "§NumAction§", 0
    //    apigrid.AddColumn "§Date souhaitée§", 900, "dd/mm/yy"
    //    apigrid.AddColumn "GMAO", 600
    //    apigrid.AddColumn "§Action§", 5500
    //    apigrid.AddColumn "§Date §", 900, "dd/mm/yy"
    //    apigrid.AddColumn "§Site§", 1700
    //    apigrid.AddColumn "§Inter§", 500
    //    apigrid.AddColumn "§Prest§", 300
    //    apigrid.AddColumn "§Etat§", 300
    //    apigrid.AddColumn "§Administratif§", 300
    //    apigrid.AddColumn "§Observation§", 2200
    //    apigrid.AddColumn "§Prestation§", 0
    //    apigrid.AddColumn "NSITNUM", 0
    //  End If
    //  
    //  apigrid.Init adoRS
    //  apigrid.DesactiveListe
    //  
    //Exit Sub
    //
    //Handler:
    //  ShowError "InitApigrid dans " & Me.Name
    //End Sub
    //

    /* OK --------------------------------------------------------------------------------------- */
    private void OuvertureEnCreationInternet()
    {
      try
      {
        // date du jour
        TxtDate.Text = $"{DateTime.Now.ToShortDateString()} {DateTime.Now.ToLongTimeString()}";
        TxtCreateur.Text = "";
        iNumCanMulti = 0;
        // permet de rajouter les tirets et de mettre en forme le constat client
        string action = "";
        if (MozartParams.Action != null) action = MozartParams.Action;
        string[] tab = action.Split('\n');
        if (tab.Length > 0)
        {
          action = " - " + tab[0] + Environment.NewLine;
          int i = 1;
          for (; i < tab.Length - 1; i++)
            action += " - " + tab[i] + Environment.NewLine;
          if (i < tab.Length)
            action += tab[i];
        }

        MozartParams.Action = $"{Resources.txt_constatClient} :{Environment.NewLine}" +
                              $"{action}{Environment.NewLine}" +
                              $"{Resources.txt_constatTech} :{Environment.NewLine}{Environment.NewLine}" +
                              $"{Resources.txt_presta} :";

        lblWeb.Text = MozartParams.Action;

        // type de facturation
        optFact0.Checked = false;
        optFact1.Checked = false;

        // combo des clients
        RemplirComboClient();

        // se positionner sur le bon client
        cboclient.SetItemData(miNumClient);
        cboclient_Update(); //mise à jour des composants dépendants de cboclient

        // se positionner sur le bon site
        cboSite.SetItemData(miNumSite);
        cboSite_Update(); //mise à jour des composants dépendants de cbosite

        // se positionner sur le bon demandeur (vutilog du createur internet)
        // on regarde s'il existe dans la liste des contacts
        cboDemandeur.Text = mstrDemandeur;

        // sinon, on regarde dans la liste des contacts avec la gestion des raison sociale
        // si pas bon, on met autre et txtautre
        if (cboDemandeur.SelectedIndex == 0)
        {
          cboDemandeur.Text = Resources.txt_autre;
          txtdemAutre.Text = mstrDemandeur;
        }

        try
        {
          // on met le contrat si on l'a (client auchan)
          if (miNumContrat != 0) cboTypeContrat.SelectedValue = miNumContrat;

          // ref cli
          txtRefCli.Text = (mstrRefCli == null || mstrRefCli == "") ? $"DI web - {DateTime.Today.ToShortDateString()}" : mstrRefCli;

          // interdir la modification du client ou du site
          cboclient.Font = new Font(cboclient.Font, FontStyle.Bold);
          cboclient.Enabled = cboEnseigne.Enabled = cboSite.Enabled = cboNumSite.Enabled = false;
          cboSite.Font = new Font(cboSite.Font, FontStyle.Bold);
          cboNumSite.Font = new Font(cboNumSite.Font, FontStyle.Bold);

          // ouverture du recordset
          ApiGrid.LoadData(dtRS, MozartDatabase.cnxMozart, "select null as NACTID, null as NACTNUM,null,null,null,null,null,null,null,null,null, null");
          ApiGrid.GridControl.DataSource = dtRS;

          // initialisation de la liste
          InitApigrid();

          //desactivation des boutons actions
          cmdAjouter.Enabled = cmdModifier.Enabled = cmdFact.Enabled = cmdSupprimer.Enabled = cmdCopier.Enabled = cmdCopier.Enabled = cmdNF.Enabled = false;
          Frame2.Visible = false;
          Frame8.Visible = true;
        }
        catch (Exception ex)
        {
          MZUtils.displayError(MethodBase.GetCurrentMethod().Name, ex);
        }
      }
      catch (Exception ex)
      {
        MZUtils.displayError(MethodBase.GetCurrentMethod().Name, ex);
      }
    }

    public void RemplirComboClient(string sChaine = "")
    {
      try
      {
        if (sChaine == "")
          cboclient.Init(MozartDatabase.cnxMozart, "select NCLINUM, VCLINOM from api_v_comboClient order by VCLINOM", "NCLINUM", "VCLINOM",
                        new List<string>() { Resources.col_Num, Resources.col_Nom }, 250, 550, true);
        else
          cboclient.Init(MozartDatabase.cnxMozart, sChaine, "NCLINUM", "VCLINOM",
                      new List<string>() { Resources.col_Num, Resources.col_Nom }, 250, 550, true);

        DataTable dt = cboclient.DataSource() as DataTable;
        DataRow row = dt.NewRow();
        row[0] = 0;
        row[1] = "";
        dt.Rows.InsertAt(row, 0);
      }
      catch (Exception ex)
      {
        MZUtils.displayError(MethodBase.GetCurrentMethod().Name, ex);
      }
    }

    /*Public Sub RemplirComboClient(combo As Object, Optional sChaine As String)

    Dim i As Integer

    On Error GoTo handler
    Set rs = New ADODB.Recordset
    If sChaine <> "" Then
    rs.Open sChaine, cnx
    Else
    rs.Open "select * from api_v_comboClient order by VCLINOM", cnx
    End If

    combo.Clear
    combo.AddItem ""
    combo.ItemData(0) = 0

    For i = 1 To rs.RecordCount
    combo.List(i) = rs!vClinom
    combo.ItemData(i) = rs!NCLINUM
    rs.MoveNext
    Next

    rs.Close
    combo.ListIndex = 0
    Exit Sub
    handler:
    ShowError "RemplirComboClient"
    End Sub*/

    /* OK --------------------------------------------------------------------------------------- */
    private void OuvertureEnCreationGDM_SYNERGEE(string sOrigine)
    {

      try
      {
        // date du jour
        TxtDate.Text = DateTime.Now.ToShortDateString() + " " + DateTime.Now.ToShortTimeString();
        TxtCreateur.Text = "";
        iNumCanMulti = 0;
        // permet de rajouter les tirets et de mettre en forme le constat client
        string action = "";
        if (MozartParams.Action != null) action = MozartParams.Action;
        string[] tab = action.Split('\n');
        if (tab.Length > 0)
        {
          action = " - " + tab[0] + Environment.NewLine;
          int i = 1;
          for (; i < tab.Length - 1; i++)
            action += " - " + tab[i] + Environment.NewLine;
          if (i < tab.Length)
            action += tab[i];
        }

        MozartParams.Action = $"{Resources.txt_constatClient} :{Environment.NewLine}" +
                              $"{action}{Environment.NewLine}" +
                              $"{Resources.txt_constatTech} :{Environment.NewLine}{Environment.NewLine}" +
                              $"{Resources.txt_presta} :";

        lblWeb.Text = MozartParams.Action;

        // type de facturation
        optFact0.Checked = optFact1.Checked = false;

        //combo des clients
        RemplirComboClient();
        // se positionner sur le bon client
        cboclient.SetItemData(miNumClient);
        cboclient_Update(); //mise à jour des composants dépendants de cboclient

        // se positionner sur le bon site
        cboSite.SetItemData(miNumSite);
        cboSite_Update(); //mise à jour des composants dépendants de cboSite

        // se positionner sur le bon demandeur (vutilog du createur internet)
        //on regarde s'il existe dans la liste des contacts
        cboDemandeur.Text = mstrDemandeur;
        //sinon, on regarde dans la liste des contacts avec la gestion des raison sociale
        //si pas bon, on met autre et txtautre
        if (cboDemandeur.SelectedIndex == 0)
        {
          cboDemandeur.Text = Resources.txt_autre;
          txtdemAutre.Text = sOrigine;
        }

        // on met le contrat si on l'a
        if (miNumContrat != 0) cboTypeContrat.SelectedValue = miNumContrat;
        // ref cli
        txtRefCli.Text = (mstrRefCli == null || mstrRefCli == "") ? $"DI {sOrigine} - " : mstrRefCli;
        // interdir la modification du client ou du site
        cboclient.Font = new Font(cboclient.Font, FontStyle.Bold);
        cboclient.Enabled = cboSite.Enabled = cboNumSite.Enabled = false;
        cboSite.Font = new Font(cboSite.Font, FontStyle.Bold);
        cboNumSite.Font = new Font(cboNumSite.Font, FontStyle.Bold);

        // ouverture du recordset
        ApiGrid.LoadData(dtRS, MozartDatabase.cnxMozart, "select null as NACTID, null as NACTNUM,null,null,null,null,null,null,null,null,null, null");
        ApiGrid.GridControl.DataSource = dtRS;

        // initialisation de la liste
        InitApigrid();

        // desactivation des boutons actions
        cmdAjouter.Enabled = cmdModifier.Enabled = cmdFact.Enabled = cmdSupprimer.Enabled = cmdCopier.Enabled = cmdNF.Enabled = false;
        Frame2.Visible = false;
        Frame8.Visible = true;
      }
      catch (Exception ex)
      {
        MZUtils.displayError(MethodBase.GetCurrentMethod().Name, ex);
      }
    }

    private void OuvertureEnModification()
    {
      try
      {
        AlertCte = false;

        // ouverture du recordset des ACTIONS de cette demande
        ApiGrid.LoadData(dtRS, MozartDatabase.cnxMozart, $"api_sp_RetourAction {MozartParams.NumDi}");
        ApiGrid.GridControl.DataSource = dtRS;

        //initialisation de la liste
        InitApigrid();

        // recherche des données générales sur la demande
        using (SqlDataReader sdr = ModuleData.ExecuteReader($"api_sp_RetourDI {MozartParams.NumDi}"))
        {
          if (sdr.Read())
          {
            //retour info demande
            txtNumDI.Text = Utils.BlankIfNull(sdr["NDINNUM"]); // numéro de la demande
            txtRefCli.Text = Utils.BlankIfNull(sdr["VDINREFCLI"]); // ref client
            TxtDate.Text = Utils.BlankIfNull(sdr["DDINDATHEUR"]); // date de la demande
            txtTelDem.Text = Utils.BlankIfNull(sdr["VCCLTEL"]); // tel demandeur
            txtDirReg.Text = Utils.BlankIfNull(sdr["VDIRREG"]);
            txtTelReg.Text = Utils.BlankIfNull(sdr["VTELREG"]);
            txtdemAutre.Text = Utils.BlankIfNull(sdr["VDINDEMAUTRE"]);
            cClientInterdit = Utils.BlankIfNull(sdr["INTERDIT"]);
            iNumCanMulti = (int)Utils.ZeroIfNull(sdr["NCANNUMMULTI"]);
            cmdCanMulti.BackColor = iNumCanMulti != 0 ? Color.Yellow : MozartColors.ColorH8000000F;

            // traitement de la vue du planning sur le web
            chkPlanningWeb.Checked = (Utils.BlankIfNull(sdr["CDINPLAWEB"]) != "N");
            chkPlanningWeb.Visible = true;

            // action reccurente di
            ChkDi_Reccurente.Checked = Convert.ToBoolean(sdr["NDINACTRECCUR"]);

            // di a exclure des stats rapport FM
            ChkHorsRapportFM.Checked = Convert.ToBoolean(sdr["BDIN_EX_RPTFM"]);

            // client GIDT (type auchan)
            bClientGIDT = Convert.ToBoolean(sdr["BCLIGESTNUM"]);
            chkTE.Visible = bClientGIDT; // visible si client GIDT

            // tous site
            chkTSite.Checked = (Utils.BlankIfNull(sdr["CDINTS"]) == "O");
            //tous équipement
            chkTE.Checked = Convert.ToBoolean(sdr["BDINTE"]);

            //DI inventaire
            ChkInvEquip.Checked = Convert.ToBoolean(sdr["BDININVEQUIP"]);

            // type de facturation
            if (Utils.BlankIfNull(sdr["CDINTYF"]) == "DC")
              optFact1.Checked = true;
            else
              optFact0.Checked = true;

            // type de tva
            string NDINTVA = Utils.BlankIfNull(sdr["NDINTVA"]);
            if (NDINTVA == "19,6" || NDINTVA == "18" || NDINTVA == "16" || NDINTVA == "20")
              optTva0.Checked = true;
            else if (NDINTVA == "5,5" || NDINTVA == "10")
              optTva1.Checked = true;
            else
              optTva2.Checked = true;

            // créateur de demande
            TxtCreateur.Text = Utils.BlankIfNull(sdr["VCAFF"]);

            iNumVEH = (int)Utils.ZeroIfNull(sdr["NVEHNUM"]);

            // les infos du site
            txtEnseigne.Text = Utils.BlankIfNull(sdr["VSITENSEIGNE"]);
            txtTypeSite.Text = Utils.BlankIfNull(sdr["VSITTYPE"]);
            txtRespSite.Text = Utils.BlankIfNull(sdr["VSITRES"]);
            txtPrenom.Text = Utils.BlankIfNull(sdr["VSITPRENOM"]);
            txtAdresse1.Text = Utils.BlankIfNull(sdr["VSITAD1"]);
            txtAdresse2.Text = Utils.BlankIfNull(sdr["VSITAD2"]);
            txtCp.Text = Utils.BlankIfNull(sdr["VSITCP"]);
            txtVille.Text = Utils.BlankIfNull(sdr["VSITVIL"]);
            txtTelephone.Text = Utils.BlankIfNull(sdr["VSITTEL"]);
            txtFax.Text = Utils.BlankIfNull(sdr["VSITFAX"]);
            txtPortable.Text = Utils.BlankIfNull(sdr["VSITPORT"]);

            Image1.Tag = Utils.BlankIfNull(sdr["VSITHOR"]);

            // conducteur de travaux
            cboCond.SetItemData((int)Utils.ZeroIfNull(sdr["NDINCONDTRAV"]));

            // combo des clients
            DataTable dtcl = new DataTable();
            dtcl.Columns.Add("NCLINUM", Type.GetType("System.Int32"));
            dtcl.Columns.Add("VCLINOM", Type.GetType("System.String"));
            DataRow rcl = dtcl.NewRow();
            rcl["NCLINUM"] = (int)Utils.ZeroIfNull(sdr["NCLINUM"]);
            rcl["VCLINOM"] = Utils.BlankIfNull(sdr["VCLINOM"]);
            dtcl.Rows.Add(rcl);
            cboclient.Init(dtcl, "", "NCLINUM", "VCLINOM", new List<string>() { Resources.col_Num, Resources.col_Nom }, 250, 550, true);
            cboclient.SetItemData((int)Utils.ZeroIfNull(sdr["NCLINUM"]));
            cboclient_Update(); //mise à jour des composants dépendants de cboclient

            cboPerCont.SelectedValue = (int)Utils.ZeroIfNull(sdr["NCONTRATPERNUM"]);
            // Read only sur la combo "Date période contractuelle" selon les droits de l'utilisateur
            cboPerCont.Enabled = ModuleMain.RechercheDroitMenu(701);

            // combo site si tous sites
            AlertSITE = false;
            if (Utils.BlankIfNull(sdr["CDINTS"]) == "N")
            {
              cboSite.SetItemData((int)Utils.ZeroIfNull(sdr["NSITNUM"]));
              cboSite_Update();
              cboEnseigne.SetText(Utils.BlankIfNull(sdr["VSITENSEIGNE"]).Trim());
              miNumSite = cboSite.GetItemData();
            }
            else
            {
              cboSite.Init(MozartDatabase.cnxMozart, "select 0 as NSITNUM, '' as VSITNOM", "NSITNUM", "VSITNOM",
                           new List<string>() { Resources.col_Num, Resources.col_Nom }, 250, 550);
              Utils.InitComboBox(cboNumSite, "select 0 as NSITNUM, '' as NSITNUE");
              miNumSite = 0;
              InitialiserInfoSite();
              //combo des types de contrat
              RemplirComboTypeContratCli(cboclient.GetItemData());
            }

            // FGB : Fait en-dessous
            //if (cboTypeContrat.SelectedIndex == 0)
            //{
            //  // on ne trouve pas le contrat
            //  // ajouter ce contrat à la combo
            //  using (SqlDataReader sdrAux = ModuleData.ExecuteReader($"select VTYPECONTRAT FROM TREF_TYPECONTRAT WHERE LANGUE = '{MozartParams.Langue}' AND NTYPECONTRAT = {sdr["NTYPECONTRAT"]}"))
            //  {
            //    if (sdrAux.Read())
            //    {
            //      DataRow row = (cboTypeContrat.DataSource as DataTable).NewRow();
            //      row[0] = Utils.BlankIfNull(sdrAux["VTYPECONTRAT"]);
            //      row[1] = (int)Utils.ZeroIfNull(sdr["NTYPECONTRAT"]);
            //      (cboTypeContrat.DataSource as DataTable).Rows.Add(row);
            //      cboTypeContrat.SelectedValue = row[1];
            //    }
            //  }
            //}

            // combo du compte
            _compte = cboCompte.Text = Utils.BlankIfNull(sdr["NDINCTE"]);

            // si le compte n'est pas trouvé, on l'ajoute
            if (cboCompte.Text != _compte)
            {
              cboCompte.Items.Add(new CompteItem(0, Utils.BlankIfNull(sdr["NDINCTE"])));
              _compte = cboCompte.Text = Utils.BlankIfNull(sdr["NDINCTE"]);
            }

            // FGA : plus nécessaire car on ne charge que les comptes actifs dans la combo
            //
            //// supprimer les comptes non actifs si on est pas sur un compte non actif 
            //if (null != cboCompte.SelectedItem && (cboCompte.SelectedItem as CompteItem).ACTIF == 1)
            //  for (int i = 0; i < cboCompte.Items.Count; i++)
            //    if ((cboCompte.Items[i] as CompteItem).ACTIF == 0)
            //      cboCompte.Items.Remove(cboCompte.Items[i]);

            cboCompte_SelectionChangeCommitted(null, null); //mise à jour des composants dépendants de cboCompte

            // combo demandeur 
            string VDINNOM = Utils.BlankIfNull(sdr["VDINNOM"]);
            int pos = 0;
            for (; pos < cboDemandeur.Items.Count; pos++)
              if (cboDemandeur.Items[pos].ToString().ToUpper() == VDINNOM.ToUpper())
                break;
            if (pos == cboDemandeur.Items.Count)
            {
              // parcours de la combo et on teste si on est dans le cas avec des " -- " de raison sociale
              for (int i = 0; i < cboDemandeur.Items.Count; i++)
              {
                if (((string)cboDemandeur.Items[i]).IndexOf(" -- ") != -1)
                {
                  if (Strings.Left((string)cboDemandeur.Items[i], ((string)cboDemandeur.Items[i]).IndexOf(" -- ")) == Utils.BlankIfNull(sdr["VDINNOM"]))
                  {
                    cboDemandeur.SelectedIndex = i;
                    break;
                  }
                }
              }

              // si pas OK alors ajouter à la combo
              if (cboDemandeur.SelectedIndex == 0)
                cboDemandeur.Items.Add(Utils.BlankIfNull(sdr["VDINNOM"]));
            }

            cboDemandeur.Text = VDINNOM;
            cboDemandeur_SelectionChangeCommitted(null, null); //mise à jour des composants dépendants de cboDemandeur

            // raison sociale : se positionner sur la bonne 
            if (BChoixRaisonSoc) cboRais.SelectedValue = Utils.ZeroIfNull(sdr["NRSFNUM"]);

            // FG le 19/05/24
            // ce code ajoute le contrat dans la liste des contrats si il n'est pas dans la liste des contrats
            // 

            cboTypeContrat.SelectedValue = (int)Utils.ZeroIfNull(sdr["NTYPECONTRAT"]);
            //if (cboTypeContrat.SelectedIndex == 0)
            if (cboTypeContrat.Text == "")
            {
              // on ne trouve pas de contrat
              // on ajoute ce contrat à la combo 
              using (SqlDataReader sdrAux = ModuleData.ExecuteReader($"select VTYPECONTRAT FROM TREF_TYPECONTRAT WITH (NOLOCK) WHERE LANGUE='{MozartParams.Langue}' AND NTYPECONTRAT={sdr["NTYPECONTRAT"]}"))
              {
                if (sdrAux.Read())
                {
                  DataRow row = (cboTypeContrat.DataSource as DataTable).NewRow();
                  row[0] = Utils.BlankIfNull(sdrAux["VTYPECONTRAT"]);
                  row[1] = (int)Utils.ZeroIfNull(sdr["NTYPECONTRAT"]);
                  (cboTypeContrat.DataSource as DataTable).Rows.Add(row);
                  cboTypeContrat.SelectedValue = row[1];
                }
              }
            }

            // blocage pour non modification
            cboclient.Enabled = cboEnseigne.Enabled = chkTSite.Enabled = chkTE.Enabled = false;

            cboTypeContrat.Enabled = !bClientGIDT;

            //possible modification du site
            cboSite.Enabled = cboNumSite.Enabled = true;
            Frame8.Visible = false;

            if (ExistFourNonFactureesDI(MozartParams.NumDi)) cmdNF.BackColor = Color.Yellow;


            AlertCte = true;
          }
        }
      }
      catch (Exception ex)
      {
        MZUtils.displayError(MethodBase.GetCurrentMethod().Name, ex);
      }
    }
    //Private Sub OuvertureEnModification()
    // 
    //Dim otext As TextBox
    //Dim RsAux, rs As ADODB.Recordset
    //Dim i As Integer
    //' UPGRADE_INFO (#0501): The 'j' member isn't used anywhere in current application.
    //' Dim j As Integer
    //' UPGRADE_INFO (#0501): The 'aux' member isn't used anywhere in current application.
    //' Dim aux
    //
    //On Error GoTo Handler
    //
    //  AlertCte = False
    //
    //  ' ouverture du recordset des ACTIONS de cette demande
    //  Set adoRS = New ADODB.Recordset
    //  adoRS.Open "api_sp_RetourAction " & giNumDi, cnx, adOpenStatic, adLockOptimistic
    //  
    //  ' positionnement sur la bonne action
    //  adoRS.Find ("NACTNUM = " & glNumAction)
    //   
    //  ' initialisation de la liste
    //  InitApigrid
    // 
    //  ' recherche des donnees générales sur la demande
    //  Set rs = New ADODB.Recordset
    //  rs.Open "api_sp_RetourDI " & giNumDi, cnx
    //  
    //  ' retour info demande
    //  Me.txtNumDI = rs("NDINNUM")          ' numéro de la demande
    //  Me.txtRefCli = BlankIfNull(rs("VDINREFCLI"))    ' ref client
    //'  Me.txtNumcde = BlankIfNull(rs("VDINNUMCDE"))    ' N° cde client
    //  txtDate = BlankIfNull(rs("DDINDATHEUR"))       ' date de la demande
    //  Me.txtTelDem = BlankIfNull(rs("VCCLTEL"))          ' tel demandeur
    //  txtDirReg = BlankIfNull(rs("VDIRREG"))
    //  txtTelReg = BlankIfNull(rs("VTELREG"))
    //  txtdemAutre = BlankIfNull(rs("VDINDEMAUTRE"))
    //  cClientInterdit = BlankIfNull(rs("INTERDIT"))
    //  iNumCanMulti = ZeroIfNull(rs("NCANNUMMULTI"))
    //  cmdCanMulti.BackColor = IIf(iNumCanMulti <> 0, &H80FFFF, &H8000000F)
    //
    //  ' traitement de la vue du planning sur le web
    //  Me.chkPlanningWeb.value = IIf(rs("CDINPLAWEB") = "N", 0, 1)
    //  'If RechercheDroitLocal(gintUID, 2) Then chkPlanningWeb.Visible = True
    //  chkPlanningWeb.Visible = True
    //
    //  'action reccurente di
    //  ChkDi_Reccurente.value = IIf(rs("NDINACTRECCUR") = True, Checked, Unchecked)
    // 
    //  'di a exclure des stats rapport FM
    //  ChkHorsRapportFM.value = IIf(rs("BDIN_EX_RPTFM") = True, Checked, Unchecked)
    // 
    //  ' client GIDT  (type auchan)
    //  BClientGIDT = rs("BCLIGESTNUM")
    //  chkTE.Visible = BClientGIDT             ' visible si client GIDT
    //  
    //  ' tous site
    //  Me.chkTSite.value = IIf(rs("CDINTS") = "O", 1, 0)
    //  
    //  ' tout équipement
    //  Me.chkTE.value = IIf(rs("BDINTE"), 1, 0)
    //  
    //  ' type de facturation
    //  If rs("CDINTYF") = "DC" Then
    //    Me.optFact(1).value = True
    //  Else
    //    Me.optFact(0).value = True
    //  End If
    //    
    //  ' type de tva
    //  If rs("NDINTVA") = "19,6" Or rs("NDINTVA") = "18" Or rs("NDINTVA") = "16" Or rs("NDINTVA") = "20" Then
    //    Me.optTva(0).value = True
    //  ElseIf rs("NDINTVA") = "5,5" Or rs("NDINTVA") = "10" Then
    //    Me.optTva(1).value = True
    //  Else
    //    Me.optTva(2).value = True
    //  End If
    //
    //  'créateur de la demande
    //  TxtCreateur = BlankIfNull(rs("VCAFF"))
    //  
    //  iNumVEH = ZeroIfNull(rs("NVEHNUM"))
    //  
    //  'les info du site
    //  For Each otext In Me.txtFields
    //    Set otext.DataSource = rs
    //  Next
    //    
    //  Image1.Tag = BlankIfNull(rs("VSITHOR"))
    //
    //  ' conducteur de travaux
    //  SelectLB cboCond, ZeroIfNull(rs("NDINCONDTRAV"))
    //
    //
    //  ' combo des clients
    //  cboclient.Clear
    //  cboclient.AddItem ""
    //  cboclient.ItemData(0) = 0
    //  cboclient.AddItem rs("VCLINOM")
    //  cboclient.ItemData(1) = rs("NCLINUM")
    //  cboclient.ListIndex = 1
    //                    
    //  ' combo site si tous sites
    //  AlertSITE = False
    //  If rs("CDINTS") = "N" Then
    //    cboSite.Text = rs("VSITNOM")
    //    cboEnseigne.Text = Trim(rs("VSITENSEIGNE"))
    //   miNumSite = cboSite.ItemData(cboSite.ListIndex)
    //  Else
    //    cboSite.Clear
    //    cboNumSite.Clear
    //    miNumSite = 0
    //    InitialiserInfoSite
    //    ' combo des types de contrat
    //    RemplirComboTypeContratCli cboTypeContrat, cboclient.ItemData(cboclient.ListIndex)
    //  End If
    //  
    //  'cboTypeContrat.Text = rs("VTYPECONTRAT")
    //  cboTypeContrat.ListIndex = 0
    //  SelectLB cboTypeContrat, rs("NTYPECONTRAT")
    //  
    //  If cboTypeContrat.ListIndex = 0 Then  ' on ne trouve pas le contrat
    //    ' ajouter ce contrat a la combo
    //    Set RsAux = New ADODB.Recordset
    //    RsAux.Open "select VTYPECONTRAT FROM TREF_TYPECONTRAT WITH (NOLOCK) WHERE LANGUE='" & gstrLangue & "' AND NTYPECONTRAT=" & rs("NTYPECONTRAT"), cnx, adOpenStatic, adLockOptimistic
    //
    //    cboTypeContrat.AddItem CStr(RsAux("VTYPECONTRAT"))
    //    cboTypeContrat.ItemData(cboTypeContrat.ListCount - 1) = rs("NTYPECONTRAT")
    //    SelectLB cboTypeContrat, rs("NTYPECONTRAT")
    //    RsAux.Close
    //    Set RsAux = Nothing
    //  End If
    //
    //  ' combo du compte
    //  On Error Resume Next
    //  cboCompte.Text = rs("NDINCTE")
    //  If Err Then
    //    ' ajouter ce contrat a la combo
    //    cboCompte.AddItem CStr(rs("NDINCTE")), 0
    //    cboCompte.Text = rs("NDINCTE")
    //    Err.Clear
    //  End If
    //  
    //  ' supprimer les comptes non actifs si on est pas sur un compte non actif
    //  If cboCompte.ItemData(cboCompte.ListIndex) = 1 Then
    //    For i = 0 To cboCompte.ListCount - 1
    //      If cboCompte.ItemData(i) = 0 Then cboCompte.RemoveItem (i)
    //    Next
    //  End If
    //  Err.Clear
    //  
    //
    //  ' raison sociale : se positionner sur la bonne
    //  If BChoixRaisonSoc Then SelectLB cboRais, rs("NRSFNUM")
    //  
    //  On Error GoTo Handler
    //  
    //  ' FG le 19/05/14
    //  ' ce code ajoute le contrat dans la liste des contrats mais il y est déjà, donc doublon ?
    //  ' je rajoute un test pour ne le faire que si pas de contrat selectionné
    //  
    //   If cboTypeContrat.ListIndex = 0 Then  ' on ne trouve pas le contrat
    //    ' ajouter ce contrat a la combo
    //    Set RsAux = New ADODB.Recordset
    //    RsAux.Open "select VTYPECONTRAT FROM TREF_TYPECONTRAT WITH (NOLOCK) WHERE LANGUE='" & gstrLangue & "' AND NTYPECONTRAT=" & rs("NTYPECONTRAT"), cnx, adOpenStatic, adLockOptimistic
    //  
    //    cboTypeContrat.AddItem CStr(RsAux("VTYPECONTRAT"))
    //    cboTypeContrat.ItemData(cboTypeContrat.ListCount - 1) = rs("NTYPECONTRAT")
    //    SelectLB cboTypeContrat, rs("NTYPECONTRAT")
    //    RsAux.Close
    //    Set RsAux = Nothing
    //  End If
    //
    //  ' blocage pour non modification
    //  cboclient.Enabled = False
    //  cboEnseigne.Enabled = False
    //  Me.chkTSite.Enabled = False
    //  Me.chkTE.Enabled = False
    //  
    //  cboTypeContrat.Enabled = Not BClientGIDT  '(ZeroIfNull(rs("BCLIGESTNUM")) = 0)
    //
    //  ' possible modification du site
    //  Me.cboSite.Enabled = True
    //  Me.cboNumSite.Enabled = True
    //  Frame8.Visible = False
    //
    //  cmdListeFourNF.BackColor = IIf(ExistFourNonFacturees(glNumAction), &H80FFFF, &H8000000F)
    //
    //  AlertCte = True
    //  
    //  ' fermeture du recordset
    //  rs.Close
    //  Set rs = Nothing
    //  
    //  Exit Sub
    //  Resume
    //Handler:
    //  ShowError "OuvertureEnModification dans " & Me.Name
    //End Sub
    //
    //

    private void frmAddAction_KeyPress(object sender, KeyPressEventArgs e)
    {
      bModif = true;
    }

    private int _NCLINUM = 0;
    private void cboclient_CloseUp(object sender, DevExpress.XtraEditors.Controls.CloseUpEventArgs e)
    {


      try
      {
        if (e.CloseMode == DevExpress.XtraEditors.PopupCloseMode.Normal && (int)e.Value != _NCLINUM)
        {
          cboclient.SetItemData((int)e.Value);
          cboclient_Update();
          _NCLINUM = (int)e.Value;
        }
      }
      catch
      {
        //MessageBox.Show(string.Format("{0}\r\n\r\n{1}{2}", ex.Message, Resources.Global_dans, MethodBase.GetCurrentMethod().Name), Resources.Global_Erreur, MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
      }
    }
    private void cboclient_Update()
    {
      int iNumClient;

      bModif = true;

      try
      {
        // on vide les combo
        Utils.InitComboBox(cboTypeContrat, "SELECT '' as CONTRAT, 0 as NTYPECONTRAT");
        cboSite.Init(MozartDatabase.cnxMozart, "select 0 as NSITNUM, '' as VSITNOM", "NSITNUM", "VSITNOM",
                     new List<string>() { Resources.col_Num, Resources.col_Nom }, 250, 550);
        Utils.InitComboBox(cboNumSite, "select 0 as NSITNUM, '' as NSITNUE");
        cboDemandeur.Items.Clear();
        if (cboRais.DataSource != null) { cboRais.DataSource = null; }
        cboRais.Items.Clear();

        iNumClient = cboclient.GetItemData();
        if (iNumClient > 0)
        {
          // recherche si choix de la raison sociale ou pas et si client GIDT
          using (SqlDataReader sdr = ModuleData.ExecuteReader($"select CCLICHOIXRES, BCLIGESTNUM, CCLITYPE from TCLI WITH (NOLOCK) WHERE NCLINUM={iNumClient}"))
          {
            if (sdr.Read())
            {
              BChoixRaisonSoc = (Utils.BlankIfNull(sdr[0]) == "D");
              lblRais.Visible = cboRais.Visible = BChoixRaisonSoc;
              bClientGIDT = Convert.ToBoolean(sdr[1]);
              chkTE.Visible = bClientGIDT;
              ChkInvEquip.Visible = (Utils.BlankIfNull(sdr["CCLITYPE"]) == "I") && ModuleMain.RechercheDroitMenu(ChkInvEquip.HelpContextID);

            }
            else
              bClientGIDT = BChoixRaisonSoc = false;
          }

          // traitement du numero de compte
          // recherche les numéros de compte de ce client (actif ou pas)
          // en création , uniquement les actifs et en modification les inactifs aussi
          cboCompte.Items.Clear();
          cboCompte.ValueMember = "ACTIF";
          cboCompte.DisplayMember = "LIB";
          using (SqlDataReader sdr = ModuleData.ExecuteReader($"api_sp_ComptesClient {iNumClient}"))
          {
            cboCompte.Items.Add(new CompteItem(0, ""));
            while (sdr.Read())
            {
              cboCompte.Items.Add(new CompteItem((int)Utils.ZeroIfNull(sdr[1]), Utils.BlankIfNull(sdr[0])));
            }
          }
          // s'il y a un seul compte, on le selectionne. si plusieurs comptes, il faut le choisir donc on positionne a rien
          if (cboCompte.Items.Count == 2)
          {
            cboCompte.SelectedIndex = 1;
          }
          cboCompte_SelectionChangeCommitted(null, null); //mise à jour des composants dépendants de cboCompte
          cboCompte.Visible = cmdValider.Enabled = true;

          // on rempli les combo site et num site
          RemplirComboEnseigne(iNumClient);

          // on rempli les combo site et num site
          if (mstrStatutDI != "C" && mstrStatutDI != "DIMail")
            RemplirComboSite(cboEnseigne.GetText());

          // si un seul site, position sur le site
          if ((cboSite.DataSource() as DataTable).Rows.Count == 2)
          {
            AlertSITE = false;
            cboSite.SetItemData((int)(cboSite.DataSource() as DataTable).Rows[1][0]);
            cboSite_Update(); //mise à jour des composants dépendants de cboSite
          }

          // on rempli le combo contact client
          RemplirComboContact(iNumClient);

          // Date période contractuelle
          string sSql = $"SELECT NCONTRATPERNUM, 'N° ' + LTRIM(STR(NNUMPER)) + ' - de ' + CONVERT(VARCHAR(10),DDATEDEBUT,103) + ' au ' + CONVERT(VARCHAR(10),DDATEFIN,103) AS LIBELLE";
          sSql += $" FROM TCONTRATPER WHERE NCLINUM = {iNumClient} ORDER BY NNUMPER";
          Utils.InitComboBox(cboPerCont, sSql, "NCONTRATPERNUM", "LIBELLE", true);
          cboPerCont.Visible = (cboPerCont.Items.Count > 1);
          lblDatePerCont.Visible = cboPerCont.Visible;

          // on affiche le bouton procedure si il y en a
          int iTempCboClient = (iNumClient != 0) ? iNumClient : -1;
          int iTempCboSite = -1;
          if (cboSite.GetItemData() != 0) iTempCboSite = cboSite.GetItemData();
          int iCount = (int)ModuleData.ExecuteScalarInt($"SELECT COUNT(*) FROM TPROCEDURE  WHERE BPROCACTIF = 1 AND ((NIDTYPPROC = 14 AND NCLINUM = {iTempCboClient}) OR (NIDTYPPROC = 1 AND NSITNUM = {iTempCboSite}))");

          cmdProc.Visible = (iCount > 0);

          // on affiche le bouton procedure si il y en a
          iCount = 0;
          iTempCboClient = (iNumClient != 0) ? iNumClient : -1;
          iCount = (int)ModuleData.ExecuteScalarInt($"SELECT COUNT(*) FROM TPROCEDURE  WHERE BPROCACTIF = 1 AND NIDTYPPROC = 3 AND NCLINUM = {iTempCboClient}");

          BtnPDP.BackColor = iCount > 0 ? Color.Yellow : Color.LightGray;

        }
        else
          InitialiserInfoSite();
      }
      catch (Exception ex)
      {
        MZUtils.displayError(MethodBase.GetCurrentMethod().Name, ex);
      }
    }


    public void RemplirComboContact(int iclient)
    {
      //vider  la combo 
      cboDemandeur.Items.Clear();

      // ajout dans la liste de deux cas particuliers
      cboDemandeur.Items.Add(Resources.txt_respSite);
      //      cboDemandeur.Items.Add(MozartParams.NomSociete);
      cboDemandeur.Items.Add(MozartParams.GetNomSociete());
      cboDemandeur.Items.Add(Resources.txt_autre);

      using (SqlDataReader sdr = ModuleData.ExecuteReader($"api_sp_comboContact_client {iclient}"))
      {
        while (sdr.Read())
        {
          cboDemandeur.Items.Add(sdr["VCCLNOM"]);
        }
      }

      cboDemandeur.SelectedIndex = 0;
      txtdemAutre.Visible = (cboDemandeur.Text == Resources.txt_autre || cboDemandeur.Text == Resources.txt_respSite) ? true : false;
    }

    private void cboDemandeur_SelectionChangeCommitted(object sender, EventArgs e)
    {
      bModif = true;
      try
      {
        txtdemAutre.Visible = (cboDemandeur.Text == Resources.txt_autre || cboDemandeur.Text == Resources.txt_respSite) ? true : false;
        LblCivDemand.Visible = txtdemAutre.Visible ? false : true;

        // remplir l'écran d'information du site
        // dans cette fonction on récupère le tél du demandeur et sa civilité
        TelephoneDemandeur();
      }
      catch (Exception ex)
      {
        MZUtils.displayError(MethodBase.GetCurrentMethod().Name, ex);
      }
    }

    private void cboNumSite_SelectionChangeCommitted(object sender, EventArgs e)
    {
      try
      {
        // on accorde les deux combo
        if (cboSite.GetItemData() != cboNumSite.GetItemData())
        {
          cboSite.SetItemData(cboNumSite.GetItemData());
          cboSite_Update();
          bModif = true;
        }

        // combo des types de contrat
        RemplirComboTypeContrat(Convert.ToInt32(cboNumSite.SelectedValue));

        // si un seul contrat, position sur le contrat
        if (cboTypeContrat.Items.Count == 2) cboTypeContrat.SelectedIndex = 1;

        // si necessaire, combo de choix de la raison sociale
        if (BChoixRaisonSoc)
        {
          Utils.InitComboBox(cboRais, $"select NRSFNUM, VRSFRSF AS VRSFRSF FROM TRSF WITH (NOLOCK) WHERE NRSFSITNUM is null AND NCLINUM = {cboclient.GetItemData()} AND CRSFACTIF = 'O' UNION SELECT NRSFNUM, CASE WHEN CRSFACTIF = 'N' THEN '(Archive) - ' + VRSFRSF ELSE VRSFRSF END AS VRSFRSF FROM TRSF WHERE NRSFSITNUM={cboNumSite.SelectedValue} ORDER BY VRSFRSF", "", "", true);
        }
      }
      catch (Exception ex)
      {
        MZUtils.displayError(MethodBase.GetCurrentMethod().Name, ex);
      }
    }
    //Private Sub cboNumSite_DropDown()
    //  bModif = True
    //End Sub
    //Private Sub cboNumSite_Click()
    //    
    //On Error GoTo Handler
    //     
    //  ' on accorde les deux combo
    //  SelectLB cboSite, cboNumSite.ItemData(cboNumSite.ListIndex)
    //
    //  ' combo des types de contrat
    //  RemplirComboTypeContrat cboTypeContrat, cboNumSite.ItemData(cboNumSite.ListIndex)
    //  
    //  ' si un seul contrat, position sur le contrat
    //  If cboTypeContrat.ListCount = 2 Then cboTypeContrat.ListIndex = 1
    //    
    //  ' si necessaire, combo  de choix de la raison sociale
    //  If BChoixRaisonSoc Then
    //    RemplirCombo cboRais, "select NRSFNUM, VRSFRSF AS VRSFRSF FROM TRSF WITH (NOLOCK) WHERE NRSFSITNUM is null AND NCLINUM = " & cboclient.ItemData(cboclient.ListIndex) & " AND CRSFACTIF = 'O' UNION SELECT NRSFNUM, CASE WHEN CRSFACTIF = 'N' THEN '(Archive) - ' + VRSFRSF ELSE VRSFRSF END AS VRSFRSF FROM TRSF WHERE NRSFSITNUM=" & cboNumSite.ItemData(cboNumSite.ListIndex) & " ORDER BY VRSFRSF"
    //  End If
    //  
    //  ' remplir l'écran d'information du site
    //'  Call InformationSite
    //
    //Exit Sub
    //  
    //Handler:
    //  ShowError "cboNumSite_Click dans " & Me.Name
    //End Sub
    //
    //

    /* OK  --------------------------------------------------------------------------------------- */
    private int _NSITNUM = 0;
    private void cboSite_CloseUp(object sender, DevExpress.XtraEditors.Controls.CloseUpEventArgs e)
    {
      if (e.CloseMode == DevExpress.XtraEditors.PopupCloseMode.Normal && (int)e.Value != _NSITNUM)
      {
        // gestion du changement de site : message d'avertissement si changement de site
        if (mstrStatutDI == "M" && AlertSITE)
        {
          //test si actions planifiées, exécutées, facturées ou chiffrées
          int iTemp = (int)ModuleData.ExecuteScalarInt($"select count(*) from tact WITH (NOLOCK) where ndinnum={MozartParams.NumDi} and (cetacod='E' or cetacod='P' or cactsta='F')");
          if (iTemp > 0)
          {
            MessageBox.Show(Resources.msg_impChangerSiteDI, Program.AppTitle, MessageBoxButtons.OK, MessageBoxIcon.Information);
            e.AcceptValue = false;
            e.Value = _NSITNUM;
            return;
          }
        }
        cboSite.SetItemData((int)e.Value);
        cboSite_Update();
        _NSITNUM = (int)e.Value;
      }
    }

    private void cboSite_Leave(object sender, EventArgs e)
    {

      if ((int)cboSite.GetItemData() != miNumSite)
      {
        // gestion du changement de site : message d'avertissement si changement de site
        if (mstrStatutDI == "M" && AlertSITE)
        {
          //test si actions planifiées, exécutées, facturées ou chiffrées
          int iTemp = (int)ModuleData.ExecuteScalarInt($"select count(*) from tact WITH (NOLOCK) where ndinnum={MozartParams.NumDi} and (cetacod='E' or cetacod='P' or cactsta='F')");
          if (iTemp > 0)
          {
            MessageBox.Show(Resources.msg_impChangerSiteDI, Program.AppTitle, MessageBoxButtons.OK, MessageBoxIcon.Information);
            cboSite.SetItemData((int)miNumSite);
            return;
          }
        }
        cboSite_Update();
      }


    }

    private void cboSite_Update()
    {
      bModif = true;
      bool bSiteGIDT;
      try
      {
        // gestion du changement de site : message d'avertissement si changement de site
        if (mstrStatutDI == "M" && AlertSITE)
        {
          //test si actions planifiées, exécutées, facturées ou chiffrées
          int iTemp = (int)ModuleData.ExecuteScalarInt($"select count(*) from tact WITH (NOLOCK) where ndinnum={MozartParams.NumDi} and (cetacod='E' or cetacod='P' or cactsta='F')");
          if (iTemp > 0)
          {
            MessageBox.Show(Resources.msg_impChangerSiteDI, Program.AppTitle, MessageBoxButtons.OK, MessageBoxIcon.Information);
            cboSite.SetItemData(miNumSite);
            cboNumSite.SetItemData(cboSite.GetItemData().ToString());
            return;
          }
          MessageBox.Show($"{Resources.msg_attentionChangementSite}\r\n{Resources.msg_actionSimplGenerationErreur}", Program.AppTitle, MessageBoxButtons.OK, MessageBoxIcon.Information);
        }

        AlertSITE = true;

        // on accorde les deux combo
        // se positionner sur le bon site
        cboNumSite.SetItemData(cboSite.GetItemData().ToString());

        // combo des types de contrat
        RemplirComboTypeContrat(Convert.ToInt32(cboSite.GetItemData()));

        // si un seul contrat, position sur le contrat
        if (cboTypeContrat.Items.Count == 2) cboTypeContrat.SelectedIndex = 1;

        // remplir l'écran d'information du site
        InformationSite();

        // on affiche si le sites et un site prioritaire MC le 04/01/12
        using (SqlDataReader sdr = ModuleData.ExecuteReader($"SELECT ISNULL(NSITPRIO, 0) AS NSITPRIO, VSITCONCEPT FROM TSIT WITH (NOLOCK) WHERE NSITNUM = {cboSite.GetItemData()}"))
        {
          if (sdr.Read())
          {
            bSiteGIDT = Utils.BlankIfNull(sdr["VSITCONCEPT"]) == "GIDT";
            if (Convert.ToInt32(sdr[0]) > 0)
              MessageBox.Show(Resources.msg_siteClasséPrioritaire, Program.AppTitle, MessageBoxButtons.OK, MessageBoxIcon.Information);
          }
        }

        // on affiche le bouton procedure si il y en a
        cmdProc.Visible = (int)ModuleData.ExecuteScalarInt($"SELECT COUNT(*) FROM TPROCEDURE  WHERE BPROCACTIF = 1 AND ((NIDTYPPROC = 14" +
                                                          $" AND NCLINUM = {(cboclient.GetItemData() == 0 ? -1 : cboclient.GetItemData())})" +
                                                          $" OR (NIDTYPPROC = 1 AND NSITNUM = {(Convert.ToInt32(cboSite.GetItemData()) == 0 ? -1 : Convert.ToInt32(cboSite.GetItemData()))}))") > 0;
      }
      catch (Exception ex)
      {
        MZUtils.displayError(MethodBase.GetCurrentMethod().Name, ex);
      }
    }

    private void chkTSite_CheckedChanged(object sender, EventArgs e)
    {
      try
      {
        if (chkTSite.Checked)
        {
          cboSite.Init(MozartDatabase.cnxMozart, "select 0 as NSITNUM, '' as VSITNOM", "NSITNUM", "VSITNOM",
                       new List<string>() { Resources.col_Num, Resources.col_Nom }, 250, 550);
          Utils.InitComboBox(cboNumSite, "select 0 as NSITNUM, '' as NSITNUE");
          chkTE.Checked = false;

          InitialiserInfoSite();
          // combo des types de contrat
          RemplirComboTypeContratCli(cboclient.GetItemData());
        }
        else cboclient_Update();

        InitApigrid();
      }
      //catch (Exception ex) { MessageBox.Show($"{ex.Message}\r\n\r\n{Resources.Global_dans}{MethodBase.GetCurrentMethod().Name}", Resources.Global_Erreur, MessageBoxButtons.OK, MessageBoxIcon.Exclamation); }
      catch (Exception ex) { Utils.ShowError(ex, $"{MethodBase.GetCurrentMethod().Name} dans {this.Name}"); }
    }

    private void chkTE_CheckedChanged(object sender, EventArgs e)
    {
      if (chkTE.Checked) chkTSite.Checked = false;
    }

    private void InformationSite()
    {
      try
      {
        if (cboSite.GetItemData() == 0) return;

        using (SqlDataReader sdr = ModuleData.ExecuteReader($"api_sp_InfoSite {cboSite.GetItemData()}"))
        {
          if (sdr.Read())
          {
            txtEnseigne.Text = Utils.BlankIfNull(sdr["VSITENSEIGNE"]);
            txtTypeSite.Text = Utils.BlankIfNull(sdr["VSITTYPE"]);
            txtRespSite.Text = Utils.BlankIfNull(sdr["VSITRES"]);
            txtPrenom.Text = Utils.BlankIfNull(sdr["VSITPRENOM"]);
            txtAdresse1.Text = Utils.BlankIfNull(sdr["VSITAD1"]);
            txtAdresse2.Text = Utils.BlankIfNull(sdr["VSITAD2"]);
            txtCp.Text = Utils.BlankIfNull(sdr["VSITCP"]);
            txtVille.Text = Utils.BlankIfNull(sdr["VSITVIL"]);
            txtTelephone.Text = Utils.BlankIfNull(sdr["VSITTEL"]);
            txtFax.Text = Utils.BlankIfNull(sdr["VSITFAX"]);
            txtPortable.Text = Utils.BlankIfNull(sdr["VSITPORT"]);

            txtPays.Text = Utils.BlankIfNull(sdr["VSITPAYS"]);
            txtDirReg.Text = Utils.BlankIfNull(sdr["VDIRREG"]);
            txtTelReg.Text = Utils.BlankIfNull(sdr["VTELREG"]);

            Image1.Tag = Utils.BlankIfNull(sdr["VSITHOR"]);
          }
        }
      }
      catch (Exception ex)
      {
        MZUtils.displayError(MethodBase.GetCurrentMethod().Name, ex);
      }
    }

    private void TelephoneDemandeur()
    {
      try
      {
        txtTelDem.Text = "";
        LblCivDemand.Text = "";

        if (cboDemandeur.Text == Resources.txt_respSite || cboDemandeur.Text == Resources.txt_autre)
          txtTelDem.Text = txtTelephone.Text;
        else
        {
          string sSQL = "";
          if (cboDemandeur.Text.IndexOf(" -- ") == -1)
            sSQL = $"api_sp_TelDemandeur '{cboDemandeur.Text.Replace("'", "''")}', {cboclient.GetItemData()}";
          else sSQL = $"api_sp_TelDemandeur {Strings.Left(cboDemandeur.Text, cboDemandeur.Text.IndexOf(" -- ")).Replace("'", "''")}', {cboclient.GetItemData()}";

          using (SqlDataReader sdrT = ModuleData.ExecuteReader(sSQL))
          {
            if (sdrT.Read())
            {
              txtTelDem.Text = Utils.BlankIfNull(sdrT[0]);
              LblCivDemand.Text = Utils.BlankIfNull(sdrT[1]);
            }
          }
        }
      }
      catch (Exception ex)
      {
        MZUtils.displayError(MethodBase.GetCurrentMethod().Name, ex);
      }
    }

    private void InitialiserInfoSite()
    {
      txtEnseigne.Text = "";
      txtTypeSite.Text = "";
      txtRespSite.Text = "";
      txtPrenom.Text = "";
      txtAdresse1.Text = "";
      txtAdresse2.Text = "";
      txtCp.Text = "";
      txtVille.Text = "";
      txtTelephone.Text = "";
      txtFax.Text = "";
      txtPortable.Text = "";

      Image1.Tag = "";
    }

    private bool enregistrerDI()
    {
      try
      {
        using (SqlCommand cmd = new SqlCommand("api_sp_creationDI", MozartDatabase.cnxMozart))
        {
          cmd.CommandType = CommandType.StoredProcedure;
          SqlCommandBuilder.DeriveParameters(cmd);    // liste des paramètres

          //  liste des paramètres
          cmd.Parameters["@iDI"].Value = MozartParams.NumDi;
          cmd.Parameters["@dDate"].Value = DateTime.Now;
          cmd.Parameters["@vDemAutre"].Value = txtdemAutre.Text;
          cmd.Parameters["@vRefClient"].Value = txtRefCli.Text;
          cmd.Parameters["@iClient"].Value = cboclient.GetItemData();
          cmd.Parameters["@iSite"].Value = chkTSite.Checked ? DBNull.Value : (object)cboSite.GetItemData();// pour le site
          cmd.Parameters["@ntypeContrat"].Value = Convert.ToInt32(cboTypeContrat.SelectedValue);
          cmd.Parameters["@cTS"].Value = chkTSite.Checked ? "O" : "N";
          cmd.Parameters["@bTE"].Value = chkTE.Checked;
          cmd.Parameters["@cTypeF"].Value = optFact0.Checked ? "FD" : "DC";
          if (optTva0.Checked) cmd.Parameters["@nTVA"].Value = 20;
          else if (optTva1.Checked) cmd.Parameters["@nTVA"].Value = 10;
          else if (optTva2.Checked) cmd.Parameters["@nTVA"].Value = 0.0;
          cmd.Parameters["@iCompte"].Value = Convert.ToInt32(Strings.Left(cboCompte.Text, Strings.InStr(cboCompte.Text, "-") - 1));
          cmd.Parameters["@cPlaWeb"].Value = chkPlanningWeb.Checked ? 'O' : 'N';
          cmd.Parameters["@iWeb"].Value = mstrStatutDI == "I" ? miNumDIWeb : 0;
          cmd.Parameters["@iCondTrav"].Value = cboCond.GetItemData();
          if (ChkDi_Reccurente.Checked) cmd.Parameters["@bNDINACTRECCUR"].Value = true;
          else cmd.Parameters["@bNDINACTRECCUR"].Value = false;
          if (ChkHorsRapportFM.Checked) cmd.Parameters["@bBDIN_EX_RPTFM"].Value = true;
          else cmd.Parameters["@bBDIN_EX_RPTFM"].Value = false;

          cmd.Parameters["@nRaisSoc"].Value = BChoixRaisonSoc ? (object)Convert.ToInt32(cboRais.SelectedValue) : DBNull.Value;
          if (Strings.InStr(cboDemandeur.Text, " -- ", Constants.vbTextCompare) == 0)
            cmd.Parameters["@vDemandeur"].Value = cboDemandeur.Text;
          else
            cmd.Parameters["@vDemandeur"].Value = Strings.Left(cboDemandeur.Text, Strings.InStr(cboDemandeur.Text, " -- ", Constants.vbTextCompare));

          // pour le client Emalec et pour certains sites, on passe en 996 par default
          // FGA le 13/01/25 on supprime
          //         if (cboclient.GetItemData() == 108 && cboSite.GetItemData() == 718 || cboSite.GetItemData() == 1104 || cboSite.GetItemData() == 3003)
          //         cmd.Parameters["@iCompte"].Value = 996;

          if (iNumCanMulti != 0)
            cmd.Parameters["@iCanMulti"].Value = iNumCanMulti;

          if (Convert.ToInt32(Strings.Left(cboCompte.Text, Strings.InStr(cboCompte.Text, "-") - 1)) == 997)
            cmd.Parameters["@iVehicule"].Value = Convert.ToInt32(CboVehicule.SelectedValue);

          if (Convert.ToInt32(cboPerCont.SelectedValue) != 0)
          {
            cmd.Parameters["@iContratPerNum"].Value = Convert.ToInt32(cboPerCont.SelectedValue);
          }
          if (ChkInvEquip.Checked) cmd.Parameters["@BDININVEQUIP"].Value = true;
          else cmd.Parameters["@BDININVEQUIP"].Value = false;

          cmd.ExecuteNonQuery();
          // retour du paramètre
          if (Convert.ToInt32(cmd.Parameters[0].Value) == 0)
          {
            MessageBox.Show($"{Resources.msg_creerModifDI}\r\n{Resources.msg_pasDroitCompte}", Program.AppTitle, MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
            return false;
          }
          MozartParams.NumDi = Convert.ToInt32(cmd.Parameters[0].Value);
        }
        // sauvegarde de la date envisagée

        //  oCANCOMP.SaveDateFinTrav txtDateFinTrav.Text
        ModuleData.CnxExecute($"EXEC [api_sp_CreationCANCOMP] {Strings.Left(cboCompte.Text, Strings.InStr(cboCompte.Text, "-") - 1)}, '{MozartParams.NomSociete}', '{txtDateFinTrav.Text}'");
        loadDataC_CANCOMP();

        return true;
      }
      catch (Exception ex)
      {
        MZUtils.displayError(MethodBase.GetCurrentMethod().Name, ex);
      }
      return false;
    }

    private void ApiGrid_DoubleClickE(object sender, EventArgs e)
    {
      cmdModifier.PerformClick();
    }

    private void Image1_Click(object sender, EventArgs e)
    {
      if (cboNumSite.SelectedIndex > 0)
      {
        //on affiche la fenetre de saisie des horaires sans possibilité de modification
        new frmSaisieHoraire
        {
          miNumCli = cboclient.GetItemData(),
          miNumSit = Convert.ToInt32(cboNumSite.SelectedValue)
        }.ShowDialog();
      }
    }

    private void Image2_Click(object sender, EventArgs e)
    {
      try
      {
        if (chkTSite.Checked || cboSite.GetText() == "" || txtCp.Text == "" || txtVille.Text == "")
          return;

        Cursor.Current = Cursors.WaitCursor;

        // Modif VL 14/01/2008
        using (SqlDataReader sdr = ModuleData.ExecuteReader($"SELECT VSITNOM + ' - ' + Isnull(VSITAD1, '') + ' ' + Isnull(VSITAD2, '') + ' - ' + Isnull(VSITCP, '') + ' ' + Isnull(VSITVIL, '') + ' - ' + Isnull(VSITPAYS, '') as ADR, FSITLAT LAT, FSITLON LON FROM TSIT WITH (NOLOCK) WHERE NSITNUM = {miNumSite}"))
        {
          if (sdr.Read())
          {
            new frmBrowser
            {
              msStartingAddress = "https://maps.emalec.com/SiteParPoint.asp?NOM=" + sdr["adr"].ToString() + "&LAT=" + sdr["lat"].ToString() + "&LON=" + sdr["lon"].ToString()
            }.ShowDialog();
          }
        }
      }
      catch (Exception ex)
      {
        MZUtils.displayError(MethodBase.GetCurrentMethod().Name, ex);
      }
      finally { Cursor.Current = Cursors.Default; }
    }

    private void imgInfoClient_Click(object sender, EventArgs e)
    {
      if (cboclient.GetItemData() <= 0) return;
      using (SqlDataReader sdrI = ModuleData.ExecuteReader($"select VCLIMESS from TCLI WITH (NOLOCK) WHERE NCLINUM = {cboclient.GetItemData()}"))
      {
        if (sdrI.Read())
        {
          new frmInfo { msInfo = Utils.BlankIfNull(sdrI[0]) }.ShowDialog();
        }
      }
    }

    //Private Sub imgInfoClient_Click()
    //Dim rsI As New ADODB.Recordset
    //
    //  If cboclient.ListIndex <= 0 Then Exit Sub
    //  Set rsI = cnx.Execute("select VCLIMESS from TCLI WITH (NOLOCK) WHERE NCLINUM = " & cboclient.ItemData(cboclient.ListIndex))
    //'  apiToolTip2.Texte = BlankIfNull(rsI(0))
    //'  apiToolTip2.Titre = "Informations client"
    //'  apiToolTip2.PrintTexte
    //'  apiToolTip2.Visible = True
    //  frmInfo.strInfo = BlankIfNull(rsI(0))
    //  frmInfo.Show vbModal
    //  
    //End Sub
    //

    /* OK --------------------------------------------------------------------------------------- */
    private void EnregistrerAction(string TypePrest = "T")
    {
      try
      {
        int ST = 0;

        // pour les clients, recherche du cotraitant s'il existe
        if (miNumOBJgidt > 0) ST = rechercheCotraitantGidt(miNumOBJgidt);
        else ST = rechercheCotraitant(MozartParams.NumDi, cboSite.GetItemData());

        using (SqlCommand cmd = new SqlCommand("api_sp_creationAction", MozartDatabase.cnxMozart))
        {
          cmd.CommandType = CommandType.StoredProcedure;
          SqlCommandBuilder.DeriveParameters(cmd);    // liste des paramètres

          //  liste des paramètres
          cmd.Parameters["@iDI"].Value = MozartParams.NumDi;
          cmd.Parameters["@iAction"].Value = 0;
          cmd.Parameters["@LibAction"].Value = Strings.LTrim(MozartParams.Action);
          cmd.Parameters["@dDateS"].Value = (MozartParams.DateAction == "" || MozartParams.DateAction == null) ? DateTime.Now : Convert.ToDateTime(MozartParams.DateAction);
          cmd.Parameters["@iSite"].Value = cboSite.GetItemData();
          cmd.Parameters["@cUrg"].Value = '1';
          cmd.Parameters["@cprest"].Value = 'D';
          cmd.Parameters["@cTech"].Value = 'M';
          cmd.Parameters["@cTypeAct"].Value = 'A';
          cmd.Parameters["@iDuree"].Value = 0;
          cmd.Parameters["@iValeur"].Value = 0;
          cmd.Parameters["@dDateEx"].Value = DBNull.Value;
          cmd.Parameters["@iTech"].Value = DBNull.Value;
          if (ST > 0)
          {
            cmd.Parameters["@cTypeInter"].Value = 'S';
            cmd.Parameters["@iST"].Value = ST;
          }
          else
          {
            cmd.Parameters["@cTypeInter"].Value = 'T';
            cmd.Parameters["@iST"].Value = DBNull.Value;
          }
          cmd.Parameters["@cAttach"].Value = "";
          cmd.Parameters["@vObserv"].Value = "";
          cmd.Parameters["@vOutil"].Value = "";
          cmd.Parameters["@vFour"].Value = "";
          cmd.Parameters["@dDatePla"].Value = DBNull.Value;
          cmd.Parameters["@cEtat"].Value = 'A';
          cmd.Parameters["@cNuit"].Value = 'N';
          cmd.Parameters["@cCMD"].Value = 'N';
          cmd.Parameters["@vDevis"].Value = "";
          cmd.Parameters["@mDevis"].Value = DBNull.Value;
          cmd.Parameters["@vFactBudg"].Value = DBNull.Value;
          cmd.Parameters["@vRDV"].Value = "";
          cmd.Parameters["@idEquipement"].Value = miNumOBJgidt;
          if (mstrStatutDI == "SYNERGEE")
          {
            cmd.Parameters["@vActNumGMAO"].Value = miNumDISynergee.ToString();
          }
          else if (mstrStatutDI == "GDM")
          {
            cmd.Parameters["@vActNumGMAO"].Value = mstrRefCli.ToString();
          }
          else
            cmd.Parameters["@vActNumGMAO"].Value = "";

          cmd.ExecuteNonQuery();

          // récupération du numéro créé
          MozartParams.NumAction = Convert.ToInt32(cmd.Parameters[0].Value);
        }
      }
      catch (Exception ex)
      {
        MZUtils.displayError(MethodBase.GetCurrentMethod().Name, ex);
      }
    }

    public int rechercheCotraitantGidt(int iObj)
    {
      using (SqlDataReader sdrAdo = ModuleData.ExecuteReader($"api_sp_InfoSTGidt {iObj}"))
      {
        if (sdrAdo.Read())
        {
          if (Utils.BlankIfNull(sdrAdo["NINTNUM"]) == "") return 0;
          else return Convert.ToInt32(sdrAdo["NINTNUM"]);
        }
      }
      return 0;
    }

    public int rechercheCotraitant(int iDi, int iSite)
    {
      using (SqlDataReader sdrAdo = ModuleData.ExecuteReader($"api_sp_InfoST {iDi}, {iSite}"))
      {
        if (sdrAdo.Read())
        {
          if (Utils.BlankIfNull(sdrAdo["inter"]) == "") return 0;
          else return Convert.ToInt32(sdrAdo["inter"]);
        }
      }
      return 0;
    }

    private void enregistrerActionDevis()
    {
      try
      {
        string sSqlDEV = "";
        if (mstrStatutDI == "DevWeb")
          sSqlDEV = $"select TWDEVIS.*, TPER.VPERNOM + ' ' + TPER.VPERPRE as VPERNOM from TWDEVIS WITH (NOLOCK), TPER WITH (NOLOCK) WHERE TPER.NPERNUM=TWDEVIS.NPERNUM AND NWDEVNUM={miNumDevisWeb}";
        else if (mstrStatutDI == "DevWebSTT")
          sSqlDEV = $"select TWDEVISSTT.* from TWDEVISSTT WHERE NWDEVNUM={miNumDevisWeb}";
        int ST = 0;

        // composition de la designation
        using (SqlDataReader sdrDEV = ModuleData.ExecuteReader(sSqlDEV))
        {
          if (sdrDEV.Read())
          {
            string sDescription = $"{sdrDEV["VWDEVTITRE"]}: {Utils.BlankIfNull(sdrDEV["VWDEVSUJET"])}\r\nCONSTAT:\r\n" +
                                  $"{Utils.BlankIfNull(sdrDEV["VWDEVCONSTAT"])}\r\nPRESTATION:\r\n{Utils.BlankIfNull(sdrDEV["VWDEVDESC"])}";

            // si c'est un devis Sous traitant, il fauut rechercher le contact sous traitant
            // recherche nintnum
            if (mstrStatutDI == "DevWebSTT")
              ST = RechercheIntervenant((int)Utils.ZeroIfNull(sdrDEV["NSTTNUM"]), cboclient.GetItemData());

            using (SqlCommand cmd = new SqlCommand("api_sp_creationAction", MozartDatabase.cnxMozart))
            {
              cmd.CommandType = CommandType.StoredProcedure;
              SqlCommandBuilder.DeriveParameters(cmd);    // liste des paramètres

              //  liste des paramètres
              cmd.Parameters["@iDI"].Value = MozartParams.NumDi;
              cmd.Parameters["@iAction"].Value = 0;
              cmd.Parameters["@LibAction"].Value = sDescription;
              cmd.Parameters["@dDateS"].Value = DateTime.Now;
              cmd.Parameters["@iSite"].Value = cboSite.GetItemData();
              cmd.Parameters["@cUrg"].Value = 1;

              // pour mediapost, ia prestation Travaux nexiste pas
              // TB SAMSIC CITY SPEC
              cmd.Parameters["@cprest"].Value = miNumClient == 12015 ? 'G' : 'T';
              cmd.Parameters["@cTech"].Value = 'M';
              cmd.Parameters["@cTypeAct"].Value = 'A';
              cmd.Parameters["@iDuree"].Value = Utils.ZeroIfNull(sdrDEV["NWDEVHJ"]) + Utils.ZeroIfNull(sdrDEV["NWDEVHN"]) + Utils.ZeroIfNull(sdrDEV["NWDEVHH"]);
              cmd.Parameters["@iValeur"].Value = DBNull.Value;
              cmd.Parameters["@dDateEx"].Value = DBNull.Value;
              cmd.Parameters["@iTech"].Value = DBNull.Value;
              if (ST > 0)
              {
                cmd.Parameters["@cTypeInter"].Value = 'S';
                cmd.Parameters["@iST"].Value = ST;
              }
              else
              {
                cmd.Parameters["@cTypeInter"].Value = 'T';
                cmd.Parameters["@iST"].Value = DBNull.Value;
              }
              cmd.Parameters["@cAttach"].Value = "";

              string sTemp = "";
              if (Convert.ToInt32(sdrDEV["NWDEVHN"]) > 0) sTemp = Convert.ToInt32(sdrDEV["NWDEVHN"]).ToString() + " heures hors ouverture";
              if (mstrStatutDI == "DevWeb")
                cmd.Parameters["@vObserv"].Value = $"Devis web de : {sdrDEV["VPERNOM"]} le {(Convert.IsDBNull(sdrDEV["DWDEVDATE"]) ? DBNull.Value : (object)Convert.ToDateTime(sdrDEV["DWDEVDATE"]).ToShortDateString())}\r\n" +
                                                   $"{Utils.ZeroIfNull(sdrDEV["NWDEVTECH"])}techniciens.{sTemp}";
              else if (mstrStatutDI == "DevWebSTT") cmd.Parameters["@vObserv"].Value = "Devis WEB STT";

              cmd.Parameters["@vOutil"].Value = Utils.BlankIfNull(sdrDEV["VWDEV_SECU"]);
              cmd.Parameters["@vFour"].Value = Strings.Left(Utils.BlankIfNull(sdrDEV["VWDEVFOU"]), 5000);
              cmd.Parameters["@dDatePla"].Value = DBNull.Value;
              cmd.Parameters["@cEtat"].Value = 'D';
              if (Utils.ZeroIfNull(sdrDEV["NWDEVHH"]) > 0) cmd.Parameters["@cNuit"].Value = 'P';
              else if (Utils.ZeroIfNull(sdrDEV["NWDEVHN"]) > 0) cmd.Parameters["@cNuit"].Value = 'O';
              else cmd.Parameters["@cNuit"].Value = 'N';
              cmd.Parameters["@cCMD"].Value = 'N';
              cmd.Parameters["@vDevis"].Value = "";
              cmd.Parameters["@mDevis"].Value = Utils.ZeroIfNull(sdrDEV["NDEVSTTPRIX"]); // montant du devis
              cmd.Parameters["@vFactBudg"].Value = Utils.ZeroIfNull(sdrDEV["NWDEVNUM"]); // on utilise un champ existant dans tact pour mettre le numero de devis
              cmd.Parameters["@vRDV"].Value = "";
              cmd.Parameters["@cVueWeb"].Value = 'N';
              if (Utils.ZeroIfNull(sdrDEV["NWDEVHH"]) > 0) cmd.Parameters["@nNbHPart"].Value = Convert.ToInt32(sdrDEV["NWDEVHH"]);
              else if (Utils.ZeroIfNull(sdrDEV["NWDEVHN"]) > 0) cmd.Parameters["@nNbHPart"].Value = Convert.ToInt32(sdrDEV["NWDEVHN"]);
              else cmd.Parameters["@nNbHPart"].Value = 0;

              cmd.ExecuteNonQuery();
              // récupération du numéro créé
              MozartParams.NumAction = Convert.ToInt32(cmd.Parameters[0].Value);

              // liaison entre l'action et le devis web
              if (mstrStatutDI == "DevWeb")
                ModuleData.CnxExecute($"Update TWDEVIS set NACTNUM = {MozartParams.NumAction} WHERE  NWDEVNUM={miNumDevisWeb}");
              else if (mstrStatutDI == "DevWebSTT")
                ModuleData.CnxExecute($"Update TWDEVISSTT set NACTNUM = {MozartParams.NumAction} WHERE  NWDEVNUM={miNumDevisWeb}");
            }
          }
        }
      }
      catch (Exception ex)
      {
        MZUtils.displayError(MethodBase.GetCurrentMethod().Name, ex);
      }
    }


    public int RechercheIntervenant(int iSTT, int iclient)
    {
      using (SqlDataReader sdrAdo = ModuleData.ExecuteReader($"SELECT TOP 1 TINT.NINTNUM FROM TACT WITH (NOLOCK) INNER JOIN TINT WITH (NOLOCK) ON TACT.NINTNUM = TINT.NINTNUM INNER JOIN " +
                                    $" TSTTECH WITH (NOLOCK) ON TINT.NSTFNUM = TSTTECH.NSTFNUM INNER JOIN TSIT WITH (NOLOCK) ON TACT.NSITNUM = TSIT.NSITNUM " +
                                    $" WHERE TSTTECH.NSTTNUM = {iSTT} AND TSIT.NCLINUM = {iclient}"))
      {
        if (sdrAdo.Read()) return Convert.ToInt32(sdrAdo[0]);
      }

      return 0;
    }


    /* --------------------------------------------------------------------------------------- */
    //Private Sub Timer1_Timer()
    //
    //Dim InfoClient As Info
    //
    //  On Error Resume Next
    //  If cboclient.ListIndex > 0 Then
    //    ' ouverture d'une fenetre d'information
    //    If (mstrStatutDI = "C" Or mstrStatutDI = "I" Or mstrStatutDI = "DIMail") Then
    //      InfoClient = RechercheInfos("INFO_CLIENT", cboclient.ItemData(cboclient.ListIndex))
    //      If InfoClient.strInfo <> "" And InfoClient.DateValDeb < Date And InfoClient.DateValFin > Date Then
    //        frmInfosClient.strStatut = "C"  ' client
    //        frmInfosClient.strInfo = InfoClient.strInfo
    //        frmInfosClient.Show vbModal
    //      End If
    //    End If
    //
    //  End If
    //  Timer1.Enabled = False
    //End Sub
    //

    /* OK --------------------------------------------------------------------------------------- */
    private void EnregistrerPhotos(string sType)
    {
      try
      {
        // on recherche s'il y a des phtos sur ce devis
        string sSQL = "";
        string aux;

        if (sType == "DevWebSTT")
        {
          sSQL = $"select VWDEVPHOTO1, VWDEVPHOTO2, VWDEVPHOTO3, VWDEVPHOTO4, VWDEVPHOTO5 FROM TWDEVISSTT WITH (NOLOCK) WHERE NWDEVNUM = {miNumDevisWeb}";
          aux = "DEVSTT";
        }
        else
        {
          sSQL = $"select VWDEVPHOTO1, VWDEVPHOTO2, VWDEVPHOTO3, VWDEVPHOTO4, VWDEVPHOTO5 FROM TWDEVIS WITH (NOLOCK) WHERE NWDEVNUM = {miNumDevisWeb}";
          aux = "DEVTEC";
        }
        using (SqlDataReader sdrD = ModuleData.ExecuteReader(sSQL))
        {
          if (sdrD.Read())
          {
            if (Utils.BlankIfNull(sdrD["VWDEVPHOTO1"]) != "") EnregDocument(sdrD["VWDEVPHOTO1"].ToString(), aux);
            if (Utils.BlankIfNull(sdrD["VWDEVPHOTO2"]) != "") EnregDocument(sdrD["VWDEVPHOTO2"].ToString(), aux);
            if (Utils.BlankIfNull(sdrD["VWDEVPHOTO3"]) != "") EnregDocument(sdrD["VWDEVPHOTO3"].ToString(), aux);
            if (Utils.BlankIfNull(sdrD["VWDEVPHOTO4"]) != "") EnregDocument(sdrD["VWDEVPHOTO4"].ToString(), aux);
            if (Utils.BlankIfNull(sdrD["VWDEVPHOTO5"]) != "") EnregDocument(sdrD["VWDEVPHOTO5"].ToString(), aux);
          }
        }
      }
      catch (Exception ex)
      {
        MZUtils.displayError(MethodBase.GetCurrentMethod().Name, ex);
      }
    }

    private void EnregistrerDocs()
    {
      try
      {
        // on recherche si il y a des photos sur cette demande
        using (SqlDataReader sdrD = ModuleData.ExecuteReader($"select VWDEVPHOTO1, VWDEVPHOTO2, VWDEVPHOTO3, VWDEVPHOTO4, VWDEVPHOTO5, isnull(VSTAT, '') as VSTAT FROM TDIW W WITH(NOLOCK), TWDEVISPHOTO S WITH(NOLOCK) WHERE W.NDOCNUM = S.NWDEVPHONUM AND NDIWNUM ={miNumDIWeb}"))
        {
          if (sdrD.Read())
          {
            if (Utils.BlankIfNull(sdrD["VWDEVPHOTO1"]) != "") EnregDocument(sdrD["VWDEVPHOTO1"].ToString(), "PJW", sdrD["VSTAT"].ToString());
            if (Utils.BlankIfNull(sdrD["VWDEVPHOTO2"]) != "") EnregDocument(sdrD["VWDEVPHOTO2"].ToString(), "PJW", sdrD["VSTAT"].ToString());
            if (Utils.BlankIfNull(sdrD["VWDEVPHOTO3"]) != "") EnregDocument(sdrD["VWDEVPHOTO3"].ToString(), "PJW", sdrD["VSTAT"].ToString());
            if (Utils.BlankIfNull(sdrD["VWDEVPHOTO4"]) != "") EnregDocument(sdrD["VWDEVPHOTO4"].ToString(), "PJW", sdrD["VSTAT"].ToString());
            if (Utils.BlankIfNull(sdrD["VWDEVPHOTO5"]) != "") EnregDocument(sdrD["VWDEVPHOTO5"].ToString(), "PJW", sdrD["VSTAT"].ToString());
          }
        }
      }
      catch (Exception ex)
      {
        MZUtils.displayError(MethodBase.GetCurrentMethod().Name, ex);
      }
    }

    private void EnregDocument(string strNomImage, string sDocType, string SiteWeb = "")
    {
      try
      {
        string strRepSource = "";
        // si photos, il faut les copier sur l'action
        // recherche du répertoire de sauvegarde des images sur le serveur Web
        if (sDocType == "DEVSTT" || sDocType == "DEVTEC" || sDocType == "PJW")
        {
          // cas spécifique du site web mobile
          // le répertoire des photos n'est pas le même
          if (SiteWeb == "M") strRepSource = Utils.RechercheParam("REP_PHOTOS_WEBMOBILE");
          else strRepSource = Utils.RechercheParam("REP_PHOTOS_DEVIS");
        }
        else strRepSource = Utils.RechercheParam("REP_PJ_ACT"); // sDocType = "PJ"

        // repertoire de destination
        string strRepDest = Utils.RechercheParam("REP_PHOTOS_ACT");
        int iCount = 0;
        // recherche du numéro d'image
        using (SqlCommand cmd = new SqlCommand("api_sp_GetCpt", MozartDatabase.cnxMozart))
        {
          cmd.CommandType = CommandType.StoredProcedure;
          SqlCommandBuilder.DeriveParameters(cmd);    // liste des paramètres

          //  liste des paramètres
          cmd.Parameters["@cElt"].Value = "IMGACT";
          cmd.Parameters["@iCpt"].Value = 0;
          cmd.ExecuteNonQuery();
          iCount = Convert.ToInt32(cmd.Parameters["@iCpt"].Value);
        }

        // composition du nom de l'image
        // problème si on a un document sans extension (plantage dans la base car relation sur la table des format (TFICFMT)
        // on enregistre pas le document si pas d'extension
        if (Strings.InStr(strNomImage, ".") == 0)
        {
          return;
        }


        string sExtension = Strings.Right(strNomImage, 4);
        if (Strings.InStr(sExtension, ".") != 0) sExtension = Strings.Right(strNomImage, 3);

        string textFic = "";
        if (sDocType == "PJW") textFic = $"{MozartParams.NumAction}_web_{iCount}.{sExtension}";
        else textFic = $"{MozartParams.NumAction}_{iCount}.{sExtension}";


        // enregistrement de l'image dans la table
        using (SqlCommand cmd = new SqlCommand("api_sp_EnregImgAct", MozartDatabase.cnxMozart))
        {
          cmd.CommandType = CommandType.StoredProcedure;
          SqlCommandBuilder.DeriveParameters(cmd);    // liste des paramètres

          //  liste des paramètres
          cmd.Parameters["@iNIMAGE"].Value = 0;
          cmd.Parameters["@iNACTNUM"].Value = MozartParams.NumAction;
          if (sDocType == "PJ") cmd.Parameters["@vVIMAGE"].Value = "Piece Jointe";
          else if (sDocType == "PJW") cmd.Parameters["@vVIMAGE"].Value = "Piece Jointe client web";
          else if (sDocType == "DEVTEC") cmd.Parameters["@vVIMAGE"].Value = "Photo de devis tech";
          else if (sDocType == "DEVSTT") cmd.Parameters["@vVIMAGE"].Value = "Photo de devis sous traitant";
          cmd.Parameters["@vVFICHIER"].Value = textFic.Trim();
          cmd.Parameters["@cCFORMAT"].Value = sExtension;
          cmd.Parameters["@vVCOMMENT"].Value = "";
          cmd.Parameters["@vVTYPE"].Value = sDocType;
          if (mstrStatutDI == "DIMail" || mstrStatutDI == "I" || mstrStatutDI == "GDM") cmd.Parameters["@vWEB"].Value = "O";
          else cmd.Parameters["@vWEB"].Value = "N";
          if (mstrStatutDI == "DIMail" || mstrStatutDI == "I" || mstrStatutDI == "GDM") cmd.Parameters["@vTypeDest"].Value = "C";
          else cmd.Parameters["@vTypeDest"].Value = "I";
          switch (sDocType)
          {
            case "PJ":
              cmd.Parameters["@nTypeDoc"].Value = 4;
              break;
            case "PJW":
              cmd.Parameters["@nTypeDoc"].Value = 21;
              break;
            case "DEVTEC":
              cmd.Parameters["@nTypeDoc"].Value = 18;
              break;
            case "DEVSTT":
              cmd.Parameters["@nTypeDoc"].Value = 18;
              break;
            default:
              break;
          }
          cmd.ExecuteNonQuery();
        }

        // copy physique de l'image
        File.Copy(strRepSource + strNomImage, strRepDest + textFic, true);
      }
      catch (Exception ex)
      {
        MZUtils.displayError(MethodBase.GetCurrentMethod().Name, ex);
      }
    }

    private void CopierAction(int iAction)
    {
      try
      {
        // on veut copier l'action et avoir une nouvelle action en travaux, lent avec date à 15 jours et etat Devis
        // recherche des infos de l'action a copier
        using (SqlDataReader sdrDev = ModuleData.ExecuteReader($"select * from tact WITH (NOLOCK) inner join tactcomp WITH (NOLOCK) ON TACTCOMP.NACTNUM=TACT.NACTNUM where TACT.NACTNUM = {iAction}"))
        {
          if (sdrDev.Read())
          {
            using (SqlCommand cmd = new SqlCommand("api_sp_creationAction", MozartDatabase.cnxMozart))
            {
              cmd.CommandType = CommandType.StoredProcedure;
              SqlCommandBuilder.DeriveParameters(cmd);    // liste des paramètres

              //  liste des paramètres
              cmd.Parameters["@iDI"].Value = MozartParams.NumDi;
              cmd.Parameters["@iAction"].Value = 0;
              cmd.Parameters["@LibAction"].Value = Utils.BlankIfNull(sdrDev["VACTDES"]);
              cmd.Parameters["@dDateS"].Value = DateTime.Now.AddDays(15);
              cmd.Parameters["@iSite"].Value = (int)Utils.ZeroIfNull(sdrDev["NSITNUM"]);
              cmd.Parameters["@cUrg"].Value = '3';
              cmd.Parameters["@cprest"].Value = miNumClient == 12015 ? sdrDev["CPRECOD"] : 'T';
              cmd.Parameters["@cTech"].Value = Utils.BlankIfNull(sdrDev["CTECCOD"]);
              cmd.Parameters["@cTypeAct"].Value = Utils.BlankIfNull(sdrDev["CTYPECOD"]);
              cmd.Parameters["@iDuree"].Value = (int)Utils.ZeroIfNull(sdrDev["NACTDUR"]);
              cmd.Parameters["@iValeur"].Value = 0;
              cmd.Parameters["@dDateEx"].Value = DBNull.Value;
              cmd.Parameters["@iTech"].Value = (int)Utils.ZeroIfNull(sdrDev["NPERNUM"]) == 0 ? DBNull.Value : sdrDev["NPERNUM"];
              cmd.Parameters["@cTypeInter"].Value = Utils.BlankIfNull(sdrDev["CACTTYT"]);
              cmd.Parameters["@iST"].Value = (int)Utils.ZeroIfNull(sdrDev["NINTNUM"]) == 0 ? DBNull.Value : sdrDev["NINTNUM"];
              cmd.Parameters["@cAttach"].Value = "";
              cmd.Parameters["@vObserv"].Value = "";
              cmd.Parameters["@vOutil"].Value = "";
              cmd.Parameters["@vFour"].Value = "";
              cmd.Parameters["@dDatePla"].Value = DBNull.Value;
              cmd.Parameters["@cEtat"].Value = 'D';
              cmd.Parameters["@cNuit"].Value = Utils.BlankIfNull(sdrDev["CACTNUIT"]);
              cmd.Parameters["@cCMD"].Value = 'N';
              cmd.Parameters["@vDevis"].Value = "";
              cmd.Parameters["@mDevis"].Value = DBNull.Value;
              cmd.Parameters["@vFactBudg"].Value = DBNull.Value;
              cmd.Parameters["@vRDV"].Value = Utils.BlankIfNull(sdrDev["VACTRDV"]);
              cmd.Parameters["@cVueWeb"].Value = Utils.BlankIfNull(sdrDev["CACTVUEWEB"]);
              cmd.Parameters["@vactHrMinRDV"].Value = Utils.BlankIfNull(sdrDev["VACTHRRDV"]);

              cmd.ExecuteNonQuery();

              MozartParams.NumAction = Convert.ToInt32(cmd.Parameters[0].Value);
            }
          }
        }
        // copie des documents
        RechercheEtEnregDocument(iAction, MozartParams.NumAction);
      }
      catch (Exception ex)
      {
        MZUtils.displayError(MethodBase.GetCurrentMethod().Name, ex);
      }
    }
    //Public Sub CopierAction(ByVal iAction As Long)
    //
    //Dim cmd As New ADODB.Command
    //Dim rsDev As New ADODB.Recordset
    //
    //On Error GoTo Handler
    //
    //
    //  ' on veut copier l'action et avoir une nouvelle action en travaux, lent avec date à 15 jours et etat Devis
    //  ' recherche des infos de l'action a copier
    //  rsDev.Open "select * from tact WITH (NOLOCK) inner join tactcomp WITH (NOLOCK) ON TACTCOMP.NACTNUM=TACT.NACTNUM where TACT.NACTNUM = " & iAction, cnx
    //
    //  ' création d'une commande
    //  Set cmd.ActiveConnection = cnx
    //  
    //  ' passage du nom de la procédure stockée
    //  cmd.CommandText = "api_sp_creationAction"
    //  cmd.CommandType = adCmdStoredProc
    //  
    //  ' passage des paramètres
    //  cmd.Parameters.Refresh
    //    
    //   ' liste des paramètres
    //  cmd.Parameters("@iDI").value = giNumDi
    //  cmd.Parameters("@iAction").value = 0
    //  cmd.Parameters("@LibAction").value = rsDev("VACTDES")
    //  cmd.Parameters("@dDateS").value = DateAdd("d", 15, Date)
    //  cmd.Parameters("@iSite").value = rsDev("NSITNUM")
    //  cmd.Parameters("@cUrg").value = 3
    //  ' TB SAMSIC CITY SPEC
    //  cmd.Parameters("@cprest").value = IIf(miNumClient = 12015 And gstrNomGroupe = "EMALEC", rsDev("CPRECOD"), "T")
    //  cmd.Parameters("@cTech").value = rsDev("CTECCOD")
    //  cmd.Parameters("@cTypeAct").value = rsDev("CTYPECOD")
    //  cmd.Parameters("@iDuree").value = ZeroIfNull(rsDev("NACTDUR"))
    //  cmd.Parameters("@iValeur").value = 0  'rsDev("NACTVAL")
    //  cmd.Parameters("@dDateEx").value = Null
    //  cmd.Parameters("@iTech").value = rsDev("NPERNUM")
    //  cmd.Parameters("@cTypeInter").value = rsDev("CACTTYT")
    //  cmd.Parameters("@iST").value = rsDev("NINTNUM")
    //  cmd.Parameters("@cAttach").value = ""
    //  cmd.Parameters("@vObserv").value = ""
    //  cmd.Parameters("@vOutil").value = ""
    //  cmd.Parameters("@vFour").value = ""
    //  cmd.Parameters("@dDatePla").value = Null
    //  cmd.Parameters("@cEtat").value = "D"
    //  cmd.Parameters("@cNuit").value = rsDev("CACTNUIT")
    //  cmd.Parameters("@cCMD").value = "N"
    //  cmd.Parameters("@vDevis").value = ""
    //  cmd.Parameters("@mDevis").value = Null
    //  cmd.Parameters("@vFactBudg").value = Null
    //  cmd.Parameters("@vRDV").value = rsDev("VACTRDV")
    //  cmd.Parameters("@cVueWeb").value = rsDev("CACTVUEWEB")
    //  cmd.Parameters("@vactHrMinRDV").value = rsDev("VACTHRRDV")
    //
    //  ' exécuter la commande.
    //  cmd.Execute
    //  
    //  ' récupération du numéro créé
    //  glNumAction = cmd.Parameters(0).value
    //    
    //  ' libération de la commande
    //  Set cmd = Nothing
    //  
    //  'fermeture du recordset
    //  rsDev.Close
    //  
    //  ' copie des documents
    //  RechercheEtEnregDocument iAction, glNumAction
    //  
    //  
    //Exit Sub
    //Handler:
    //  ShowError "CopierAction dans " & Me.Name
    //End Sub


    //'*********************************************************************************************************************************************************
    //'Création action aide au technicien :
    //'Pas de technicien sélectionné, il restera à le sélectionner.
    //'L’action est mise hors Web automatiquement.
    //'Le reste est rempli comme pour l’action de base
    //'*********************************************************************************************************************************************************

    /* OK --------------------------------------------------------------------------------------- */
    private void CreationActionAideTech(int iAction)
    {
      try
      {
        // recherche des infos de l'action a copier
        using (SqlDataReader sdrDev = ModuleData.ExecuteReader($"select * from tact WITH (NOLOCK) inner join TACTCOMP WITH (NOLOCK) on TACT.NACTNUM = TACTCOMP.NACTNUM  where TACT.NACTNUM = {iAction}"))
        {
          if (sdrDev.Read())
          {
            using (SqlCommand cmd = new SqlCommand("api_sp_creationAction", MozartDatabase.cnxMozart))
            {
              cmd.CommandType = CommandType.StoredProcedure;
              SqlCommandBuilder.DeriveParameters(cmd);    // liste des paramètres

              //  liste des paramètres
              cmd.Parameters["@iDI"].Value = MozartParams.NumDi;
              cmd.Parameters["@iAction"].Value = 0;
              cmd.Parameters["@LibAction"].Value = $"{Resources.txt_aideTech}\r\n\r\n{Utils.BlankIfNull(sdrDev["VACTDES"])}";
              cmd.Parameters["@dDateS"].Value = Utils.DateBlankIfNull(sdrDev["DACTDAT"]);
              cmd.Parameters["@iSite"].Value = (int)Utils.ZeroIfNull(sdrDev["NSITNUM"]);
              cmd.Parameters["@cUrg"].Value = Utils.BlankIfNull(sdrDev["CURGCOD"]);
              cmd.Parameters["@cprest"].Value = Utils.BlankIfNull(sdrDev["CPRECOD"]);
              cmd.Parameters["@cTech"].Value = Utils.BlankIfNull(sdrDev["CTECCOD"]);
              cmd.Parameters["@cTypeAct"].Value = Utils.BlankIfNull(sdrDev["CTYPECOD"]);
              cmd.Parameters["@iDuree"].Value = (int)Utils.ZeroIfNull(sdrDev["NACTDUR"]);
              cmd.Parameters["@iValeur"].Value = 0;
              cmd.Parameters["@dDateEx"].Value = DBNull.Value;
              cmd.Parameters["@iTech"].Value = DBNull.Value;
              cmd.Parameters["@cTypeInter"].Value = Utils.BlankIfNull(sdrDev["CACTTYT"]);
              cmd.Parameters["@iST"].Value = (int)Utils.ZeroIfNull(sdrDev["NINTNUM"]) == 0 ? DBNull.Value : sdrDev["NINTNUM"];
              cmd.Parameters["@cAttach"].Value = "";
              cmd.Parameters["@vObserv"].Value = $"Création action AIDE AU TECHNICIEN le {DateTime.Now.ToShortDateString()} par {MozartParams.strUID}";
              cmd.Parameters["@vOutil"].Value = "";
              cmd.Parameters["@vFour"].Value = "";
              cmd.Parameters["@dDatePla"].Value = DBNull.Value;
              cmd.Parameters["@cEtat"].Value = 'A';
              cmd.Parameters["@cNuit"].Value = Utils.BlankIfNull(sdrDev["CACTNUIT"]);
              cmd.Parameters["@cCMD"].Value = 'N';
              cmd.Parameters["@vDevis"].Value = "";
              cmd.Parameters["@mDevis"].Value = DBNull.Value;
              cmd.Parameters["@vFactBudg"].Value = DBNull.Value;
              cmd.Parameters["@vRDV"].Value = Utils.BlankIfNull(sdrDev["VACTRDV"]);
              cmd.Parameters["@cVueWeb"].Value = 'N';
              cmd.Parameters["@nDeciWeb"].Value = DBNull.Value;
              cmd.Parameters["@vRelFactST"].Value = DBNull.Value;
              cmd.Parameters["@vNumCde"].Value = DBNull.Value;
              cmd.Parameters["@nGam"].Value = DBNull.Value;
              cmd.Parameters["@nNbHPart"].Value = DBNull.Value;
              cmd.Parameters["@ObsFac"].Value = DBNull.Value;
              cmd.Parameters["@factureCotraitant"].Value = DBNull.Value;
              cmd.Parameters["@cNacelle"].Value = DBNull.Value;
              cmd.Parameters["@vMotCle"].Value = DBNull.Value;
              cmd.Parameters["@cTypCont"].Value = DBNull.Value;
              cmd.Parameters["@cReclamation"].Value = DBNull.Value;
              cmd.Parameters["@dDateArr"].Value = DBNull.Value;
              cmd.Parameters["@nIdProcess"].Value = DBNull.Value;
              cmd.Parameters["@cPlanifAuto"].Value = DBNull.Value;
              cmd.Parameters["@nPPs"].Value = DBNull.Value;
              cmd.Parameters["@dDateCde"].Value = DBNull.Value;
              cmd.Parameters["@idEquipement"].Value = (int)Utils.ZeroIfNull(sdrDev["NOBJNUM"]);
              cmd.Parameters["@vactHrMinRDV"].Value = Utils.BlankIfNull(sdrDev["VACTHRRDV"]);

              // exécuter la commande.
              cmd.ExecuteNonQuery();

              // récupération du numéro créé
              MozartParams.NumAction = (int)cmd.Parameters[0].Value;
            }
          }
        }
      }
      catch (Exception ex)
      {
        MZUtils.displayError(MethodBase.GetCurrentMethod().Name, ex);
      }
    }

    private void CreationActionAstreinte(int iAction)
    {
      try
      {
        using (SqlCommand cmd = new SqlCommand("api_sp_creationActionAstreinte", MozartDatabase.cnxMozart))
        {
          cmd.CommandType = CommandType.StoredProcedure;
          SqlCommandBuilder.DeriveParameters(cmd);    // liste des paramètres

          //  liste des paramètres
          cmd.Parameters["@p_iAction"].Value = iAction;

          cmd.ExecuteNonQuery();
        }
      }
      catch (Exception ex)
      {
        MZUtils.displayError(MethodBase.GetCurrentMethod().Name, ex);
      }
    }

    private void EnregistrerPJ_GDM()
    {
      try
      {
        string NGDMNUM = "";

        // on recherche s'il y a des documents liés à la demande GDM
        using (SqlDataReader sdr = ModuleData.ExecuteReader($"select TGDM.NGDMNUM, VNOM FROM TGDM_LSTDOC INNER JOIN TGDM ON TGDM_LSTDOC.NGDMNUM = TGDM.NGDMNUM " +
                                                            $"  WHERE VPROVENANCE = 'GDM' and TYPEPJ is null and TGDM.NGDMNUM = {miNumDIGDM}"))
        {
          if (sdr.Read())
          {
            NGDMNUM = Utils.BlankIfNull(sdr["NGDMNUM"]);
            while (sdr.Read())
              if (Utils.BlankIfNull(sdr["VNOM"]) != "") EnregDocument(Utils.BlankIfNull(sdr["VNOM"]), "PJ");

            ModuleData.CnxExecute($"update TGDM_LSTDOC set TYPEPJ = 'PJ' WHERE TYPEPJ is null and NGDMNUM = {NGDMNUM}");

            DetailstravauxUtils.ECRIRE_LOG_GDM(miNumDIGDM, $"Enregistrement PJ sur Action : Di n°{MozartParams.NumDi}/{MozartParams.NumAction}");
          }
        }


      }
      catch (Exception ex)
      {
        MZUtils.displayError(MethodBase.GetCurrentMethod().Name, ex);
      }
    }

    private void EnregistrerPJ()
    {
      try
      {
        // on recherche s'il y a des documents sur le mail
        using (SqlDataReader sdr = ModuleData.ExecuteReader($"select VDIMPJ FROM TDIMAIL WITH (NOLOCK) WHERE NDIMNUM = {miNumDIMail}"))
        {
          if (sdr.Read())
          {
            if (Utils.BlankIfNull(sdr["VDIMPJ"]) != "")
            {
              string[] files = sdr["VDIMPJ"].ToString().Split('|');
              foreach (string f in files)
                EnregDocument(f, "PJ");
            }
          }
        }
      }
      catch (Exception ex)
      {
        MZUtils.displayError(MethodBase.GetCurrentMethod().Name, ex);
      }
    }

    // recherche si il existe un chiffrage NF sur une action
    private bool ExistFourNonFacturees(int iNActNum)
    {
      return (int)MozartDatabase.ExecuteScalarInt($"select (SELECT COUNT(NACTNUM) FROM TNF WITH(NOLOCK) WHERE NACTNUM = {iNActNum}) " +
                                                  $"+ (SELECT COUNT(NACTNUM) FROM TELFNF WITH(NOLOCK) WHERE NACTNUM = {iNActNum})") > 0;
    }

    // recherche si il existe un chiffrage NF sur la DI
    private bool ExistFourNonFactureesDI(int iNumDI)
    {
      return (int)MozartDatabase.ExecuteScalarInt($"select (SELECT COUNT(NACTNUM) FROM TNF WITH(NOLOCK) WHERE NACTNUM IN " +
                                                                            $"(SELECT NACTNUM FROM TACT WHERE NDINNUM={iNumDI})) " +
                                                  $"+ (SELECT COUNT(NACTNUM) FROM TELFNF WITH(NOLOCK) WHERE NDINNUM = {iNumDI})") > 0;
    }

    private void ApiGrid_SelectionChanged(object sender, DevExpress.Data.SelectionChangedEventArgs e)
    {
      try
      {
        DataRow currentRow = ApiGrid.GetFocusedDataRow();

        if (dtRS.Rows.Count > 0 && currentRow != null)
        {
          if (Utils.ZeroIfNull(currentRow["NACTNUM"]) != 0)
          {
            if (chkTSite.Checked)
            {
              using (SqlDataReader sdr = ModuleData.ExecuteReader($"api_sp_InfoSite {currentRow["NSITNUM"]}"))
              {
                if (sdr.Read())
                {
                  txtEnseigne.Text = Utils.BlankIfNull(sdr["VSITENSEIGNE"]);
                  txtTypeSite.Text = Utils.BlankIfNull(sdr["VSITTYPE"]);
                  txtRespSite.Text = Utils.BlankIfNull(sdr["VSITRES"]);
                  txtPrenom.Text = Utils.BlankIfNull(sdr["VSITPRENOM"]);
                  txtAdresse1.Text = Utils.BlankIfNull(sdr["VSITAD1"]);
                  txtAdresse2.Text = Utils.BlankIfNull(sdr["VSITAD2"]);
                  txtCp.Text = Utils.BlankIfNull(sdr["VSITCP"]);
                  txtVille.Text = Utils.BlankIfNull(sdr["VSITVIL"]);
                  txtTelephone.Text = Utils.BlankIfNull(sdr["VSITTEL"]);
                  txtFax.Text = Utils.BlankIfNull(sdr["VSITFAX"]);
                  txtPortable.Text = Utils.BlankIfNull(sdr["VSITPORT"]);

                  txtPays.Text = Utils.BlankIfNull(sdr["VSITPAYS"]);
                  txtDirReg.Text = Utils.BlankIfNull(sdr["VDIRREG"]);
                  txtTelReg.Text = Utils.BlankIfNull(sdr["VTELREG"]);
                  Image1.Tag = Utils.BlankIfNull(sdr["VSITHOR"]);
                }
              }
            }
          }
        }
      }
      catch (Exception ex)
      {
        MZUtils.displayError(MethodBase.GetCurrentMethod().Name, ex);
      }
    }

    //Private Sub apigrid_RowColChange()
    //Dim otext As TextBox
    //Dim rsT As ADODB.Recordset
    //  
    //  On Error GoTo Handler
    //
    //  If adoRS.RecordCount > 0 Then
    //  
    //    If ZeroIfNull(adoRS("NACTNUM")) <> 0 Then
    //      'cmdListeFourNF.BackColor = IIf(ExistFourNonFacturees(adors("NACTNUM").value), &H80FFFF, &H8000000F)
    //      If chkTSite Then
    //        Set rsT = New ADODB.Recordset
    //        rsT.Open "api_sp_InfoSite " & adoRS("NSITNUM"), cnx
    //  
    //        'lier les textbox avec le recordset
    //        For Each otext In Me.txtFields
    //          Set otext.DataSource = rsT
    //        Next
    //  
    //        txtPays = BlankIfNull(rsT("VSITPAYS"))
    //        txtDirReg = BlankIfNull(rsT("VDIRREG"))
    //        txtTelReg = BlankIfNull(rsT("VTELREG"))
    //        Image1.Tag = BlankIfNull(rsT("VSITHOR"))
    //      End If
    //      
    //    End If
    //  
    //  End If
    //
    //Exit Sub
    //Resume
    //Handler:
    //  ShowError "apigrid_RowColChange dans " & Me.Name
    //End Sub

    /* --------------------------------------------------------------------------------------- */
    private void cmdPJ_Click(object sender, EventArgs e)
    {
      frmChoixImage frm = new frmChoixImage();
      frm.mstrDirPDFFiles = Utils.RechercheParam("REP_PJ_ACT");
      if (mstrStatutDI == "DIMail") frm.miNumMail = miNumDIMail;
      else if (mstrStatutDI == "GDM") frm.miNumGDM = miNumDIGDM;
      frm.ShowDialog();
    }


    private void cmdProc_Click(object sender, EventArgs e)
    {
      new frmListeProcedureConsult
      {
        iNumCli = cboclient.GetItemData(),
        iNumSite = cboSite.GetItemData() == 0 ? -1 : cboSite.GetItemData()
      }.ShowDialog();
    }

    private void cmdActFac_Click(object sender, EventArgs e)
    {
      // Création action astreinte pour Faciliteam
      DataRow row = ApiGrid.GetFocusedDataRow();
      if (null == row) return;

      if (MessageBox.Show("Voulez-vous vraiment créer une action de facturation d'astreinte cette action ?", Program.AppTitle, MessageBoxButtons.YesNo,
                          MessageBoxIcon.Question, MessageBoxDefaultButton.Button2) != DialogResult.Yes) return;

      if (row["NACTNUM"].ToString() != "")
        CreationActionAstreinte(Convert.ToInt32(row["NACTNUM"]));

      // rafraichissement du recordset
      ApiGrid.Requery(dtRS, MozartDatabase.cnxMozart);

      bActionFacAstreinte = true;
      //initialisation de la liste
      InitApigrid();
    }

    private void CmdActAide_Click(object sender, EventArgs e)
    {
      // Création action ai techcien pour l' action selectionnée
      DataRow row = ApiGrid.GetFocusedDataRow();
      if (null == row) return;

      if (MessageBox.Show(Resources.msg_creerActionAideTech, Program.AppTitle, MessageBoxButtons.YesNo,
                          MessageBoxIcon.Question, MessageBoxDefaultButton.Button2) != DialogResult.Yes) return;

      CreationActionAideTech(Convert.ToInt32(Utils.ZeroIfNull(row["NACTNUM"])));

      // rafraichissement du recordset
      ApiGrid.Requery(dtRS, MozartDatabase.cnxMozart);

      // mise en page du tableau  
      InitApigrid();
    }

    private void RechercheEtEnregDocument(int inumactionSource, int inumactionDest)
    {
      try
      {
        // recherche des docs a copier
        using (SqlDataReader reader = ModuleData.ExecuteReader($"select * from timac WITH (NOLOCK) where NACTNUM = {inumactionSource}"))
        {
          while (reader.Read())
          //mise en com le 06/02/2023 demande de BARBOSA
          {
            if (Utils.BlankIfNull(reader["VTYPE"]) == "IMAGE" /*||
                Utils.BlankIfNull(reader["VTYPE"]) == "ATTACH" ||
                Utils.BlankIfNull(reader["VTYPE"]) == "GAMME"*/)
            {
              // modification du nom du fichier
              string TextFic = Utils.BlankIfNull(reader["VFICHIER"]).Replace(inumactionSource.ToString(), inumactionDest.ToString());
              // insertion de la ligne dans la table des images
              ModuleData.ExecuteNonQuery($"insert into timac (NACTNUM, VIMAGE,VFICHIER,CFORMAT,VCOMMENT,VTYPE,CVUEWEB,DDATETRAITE,VTYPEDEST,NTYPEDOC) select " +
                                         $"{inumactionDest},VIMAGE, '{TextFic}' ,CFORMAT,VCOMMENT,VTYPE,CVUEWEB,DDATETRAITE,VTYPEDEST,NTYPEDOC" +
                                         $" from timac where nimage={reader["NIMAGE"]}");
              // copy physique de l'image
              string strRep = Utils.BlankIfNull(reader["VTYPE"]) == "IMAGE" ? Utils.RechercheParam("REP_PHOTOS_ACT") : Utils.RechercheParam("REP_ATTGAM");
              File.Copy($"{strRep}{reader["VFICHIER"]}", $"{strRep}{TextFic}", true);
            }
          }
        }
      }
      //catch (Exception ex) { MessageBox.Show($"{ex.Message}\r\n\r\n{Resources.Global_dans}{MethodBase.GetCurrentMethod().Name}", Resources.Global_Erreur, MessageBoxButtons.OK, MessageBoxIcon.Exclamation); }
      catch (Exception ex) { Utils.ShowError(ex, $"{MethodBase.GetCurrentMethod().Name} dans {this.Name}"); }
    }

    private void RemplirComboEnseigne(int iclient)
    {
      //cboEnseigne.Init(MozartDatabase.cnxMozart, $"select 0 as NCLINUM, '' as VSITENSEIGNE union select Distinct NCLINUM, VSITENSEIGNE from tsit where nclinum= {iclient} and csitactif='O' and VSITENSEIGNE<>'' and VSITENSEIGNE is not null order by VSITENSEIGNE",
      //                 "NCLINUM", "VSITENSEIGNE", new List<string>() { Resources.col_Num, Resources.col_Nom }, 250, 550, true);
      cboEnseigne.Init(MozartDatabase.cnxMozart, $"select 0 as N, '' as VSITENSEIGNE union select ROW_NUMBER() OVER(ORDER BY VSITENSEIGNE ASC) AS N, VSITENSEIGNE" +
                                       $" from(select Distinct NCLINUM, VSITENSEIGNE from tsit where nclinum = {iclient}" +
                                       $" and csitactif = 'O' and VSITENSEIGNE<>'' and VSITENSEIGNE is not null) as ENSEIGNE order by VSITENSEIGNE",
                                       "N", "VSITENSEIGNE", new List<string>() { Resources.col_Num, Resources.col_Nom }, 250, 550, true);

      cboEnseigne_Update(); //mise à jour des composants dépendants de cboEnseigne
    }

    private void cmdProcSite_Click(object sender, EventArgs e)
    {
      if (MozartParams.NumDi == 0) return;
      new frmGestProcedure
      {
        mstrType = "PlanPrevDI",
        miNumSite = 0,
        miNumClient = 0,
        msTitre = $" du client {cboclient.GetText()} pour la DI {MozartParams.NumDi}"
      }.ShowDialog();
    }

    private void ClientEIretard()
    {
      try
      {
        // on regarde si le compte est 240, 216, 223  pour client EI (compte 263 pour cession sur gros clients multitech donc on prend pas)
        string cpt3 = Strings.Left(cboCompte.Text, 3);
        if (cpt3 != "240") return;

        bool bMsg = false;
        string msg = "";
        // on ne teste que les clients ayant moins de 10 sites
        using (SqlDataReader sdr = ModuleData.ExecuteReader($"exec api_sp_FactRetardClient {cboclient.GetItemData()}"))
        {
          msg = "ALERTE IMPAYES\r\n";
          msg += Resources.txt_infoClientImpayeEchuSuiv + "\r\n";

          while (sdr.Read())
          {
            msg += $" - Facture N° {sdr["NFACNUM"]} du {sdr["DFACDAT"]} de {sdr["NELFTTC"]} €TTC{Environment.NewLine}";
            bMsg = true;
          }
        }
        msg += $"{Resources.msg_engagerAutreDep}{Environment.NewLine}";
        if (bMsg) MessageBox.Show(msg, Program.AppTitle, MessageBoxButtons.OK, MessageBoxIcon.Information);
      }
      catch (Exception ex)
      {
        MZUtils.displayError(MethodBase.GetCurrentMethod().Name, ex);
      }
    }

    DateTime _curDate = DateTime.MinValue;
    private void CalendarFinTrav_CloseUp(object sender, EventArgs e)
    {
      if (_curDate == DateTime.MinValue) { CalendarFinTrav.Visible = false; return; }
      txtDateFinTrav.Text = CalendarFinTrav.Value.ToShortDateString();
      CalendarFinTrav.Visible = false;
    }
    private void CalendarFinTrav_ValueChanged(object sender, EventArgs e)
    {
      if (CalendarFinTrav.Visible) _curDate = CalendarFinTrav.Value;
    }

    private void cmdDateFinTrav_Click(object sender, EventArgs e)
    {
      DateTime d;
      if (DateTime.TryParse(txtDateFinTrav.Text, out d)) _curDate = CalendarFinTrav.Value = d;
      else { _curDate = DateTime.MinValue; CalendarFinTrav.Value = DateTime.Now; }
      CalendarFinTrav.Visible = true;
      CalendarFinTrav.ShowCalendar(new MouseEventArgs(MouseButtons.Left, 1, MousePosition.X, MousePosition.Y, 0));
    }

    private void cmdSuppFinTrav_Click(object sender, EventArgs e)
    {
      txtDateFinTrav.Text = "";
    }


    private void CmdLanguePer_Click(object sender, EventArgs e)
    {
      new frmTableauLanguePer().ShowDialog();
    }

    private void cmdPlanningProjet_Click(object sender, EventArgs e)
    {
      new frmPlanningDI(MozartParams.NumDi).ShowDialog();
    }

    // depuis modMain

    private void RemplirComboSite(string Enseigne)
    {
      string sqlS, sqlN;
      int iClient = cboclient.GetItemData();

      try
      {
        if (Enseigne != "")
        {
          if (mstrStatutDI == "C" || mstrStatutDI == "DIMail")
          {
            sqlS = $"SELECT 0 as NSITNUM, '' as VSITNOM union select NSITNUM, VSITNOM FROM TSIT WHERE CSITACTIF='O' AND TSIT.NCLINUM = {iClient} AND VSITENSEIGNE='{Enseigne.Replace("'", "''")}' order by VSITNOM";
            sqlN = $"SELECT NSITNUM, NSITNUE FROM TSIT WHERE CSITACTIF='O' AND TSIT.NCLINUM = {iClient} AND VSITENSEIGNE='{Enseigne.Replace("'", "''")}' order by NSITNUE";
          }
          else
          {
            sqlS = $"SELECT 0 as NSITNUM, '' as VSITNOM union select NSITNUM, VSITNOM FROM TSIT WHERE TSIT.NCLINUM = {iClient} AND VSITENSEIGNE='{Enseigne.Replace("'", "''")}' order by VSITNOM";
            sqlN = $"SELECT NSITNUM, NSITNUE FROM TSIT WHERE TSIT.NCLINUM = {iClient} AND VSITENSEIGNE='{Enseigne.Replace("'", "''")}' order by NSITNUE";
          }
        }
        else
        {
          if (mstrStatutDI == "C" || mstrStatutDI == "DIMail")
          {
            sqlS = $"SELECT 0 as NSITNUM, '' as VSITNOM union select NSITNUM, VSITNOM FROM TSIT WHERE CSITACTIF='O' AND TSIT.NCLINUM = {iClient} order by VSITNOM";
            sqlN = $"SELECT NSITNUM, NSITNUE FROM TSIT WHERE CSITACTIF='O' AND TSIT.NCLINUM = {iClient} order by NSITNUE";
          }
          else
          {
            sqlS = $"Select 0 as NSITNUM, '' as VSITNOM union select NSITNUM, VSITNOM FROM TSIT WHERE TSIT.NCLINUM = {iClient} order by VSITNOM";
            sqlN = $"SELECT NSITNUM, NSITNUE FROM TSIT WHERE TSIT.NCLINUM = {iClient} order by NSITNUE";
          }
        }

        cboSite.Init(MozartDatabase.cnxMozart, sqlS, "NSITNUM", "VSITNOM",
                      new List<string>() { Resources.col_Num, Resources.col_Nom }, 250, 550, true);
        cboSite.SetItemData(0);

        cboSite_Update(); //mise à jour des composants dépendants de cboSite

        Utils.InitComboBox(cboNumSite, sqlN, "", "", true);

        cboNumSite_SelectionChangeCommitted(null, null); //mise à jour des composants dépendants de cboNumSite
      }
      //catch (Exception ex) { MessageBox.Show($"{ex.Message}\r\n\r\n{Resources.Global_dans}{MethodBase.GetCurrentMethod().Name}", Resources.Global_Erreur, MessageBoxButtons.OK, MessageBoxIcon.Exclamation); }
      catch (Exception ex) { Utils.ShowError(ex, $"{MethodBase.GetCurrentMethod().Name} dans {this.Name}"); }
    }


    public void RemplirComboTypeContrat(int iSite)
    {
      try
      {
        Utils.InitComboBox(cboTypeContrat, $"api_sp_ListeContratSite {iSite}", "NTYPECONTRAT", "CONTRAT", true);
      }
      catch (Exception ex)
      {
        MZUtils.displayError(MethodBase.GetCurrentMethod().Name, ex);
      }
    }

    public void RemplirComboTypeContratCli(int iCli)
    {
      try
      {
        Utils.InitComboBox(cboTypeContrat, $"api_sp_ListeContratClient {iCli}", "NTYPECONTRAT", "CONTRAT", true);
      }
      catch (Exception ex)
      {
        MZUtils.displayError(MethodBase.GetCurrentMethod().Name, ex);
      }
    }

    private void cmdNF_Click(object sender, EventArgs e)
    {
      frameCNF.Left = 120;
      frameCNF.Top = 260;
      frameCNF.Visible = true;
    }

    private void BtnPDP_Click(object sender, EventArgs e)
    {
      new frmGestProcedure
      {
        miNumSite = 0,
        mstrType = "PreventionContrat",
        miNumClient = cboclient.GetItemData(),
        msTitre = $" du client : {cboclient.GetText()}"
      }.ShowDialog();
    }

    private void cmdAchatsDI_Click(object sender, EventArgs e)
    {
      new frmListeAchatsDI().ShowDialog();
    }

    private void cmdNFFermer_Click(object sender, EventArgs e)
    {
      frameCNF.Visible = false;
    }

    private void cmdCNF_Click(object sender, EventArgs e)
    {
      DataRow currentRow = ApiGrid.GetFocusedDataRow();
      if (currentRow == null) return;

      new frmListeNF
      {
        miNumDI = Convert.ToInt32(txtNumDI.Text),
        miNumClient = miNumClient
      }.ShowDialog();

      if (ExistFourNonFactureesDI(Convert.ToInt32(txtNumDI.Text)))
        cmdNF.BackColor = Color.Yellow;
      else
        cmdNF.BackColor = MozartColors.ColorH8000000F;

    }

    private void cmdCP3_Click(object sender, EventArgs e)
    {
      DataRow currentRow = ApiGrid.GetFocusedDataRow();
      if (currentRow == null) return;

      new frmListeChiffrageNF
      {
        miNumDI = Convert.ToInt32(txtNumDI.Text),
        miNumClient = miNumClient
      }.ShowDialog();

      if (ExistFourNonFactureesDI(Convert.ToInt32(txtNumDI.Text)))
        cmdNF.BackColor = Color.Yellow;
      else
        cmdNF.BackColor = MozartColors.ColorH8000000F;

    }

    private void BtnMajTrameInventaire_Click(object sender, EventArgs e)
    {
      if (!ChkInvEquip.Checked) return;
      if (MozartParams.NumDi == 0 & ChkInvEquip.Checked) return;

      //on affiche la liste des inventaires à mettre à jour selon la DI
      new frmDI_Inventaire_Equipement_ListeActionsToUpdate()
      {
        ndinnum = MozartParams.NumDi

      }.ShowDialog();

    }

    private void ChkInvEquip_CheckedChanged(object sender, EventArgs e)
    {
      BtnMajTrameInventaire.Visible = ChkInvEquip.Checked && ModuleMain.RechercheDroitMenu(BtnMajTrameInventaire.HelpContextID) && mstrStatutDI == "M";
    }
  }

}
