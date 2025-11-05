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
using System.Linq;
using System.Reflection;
using System.Windows.Forms;
using MZCtrlResources = MozartControls.Properties.Resources;
using MZUtils = MozartControls.Utils;

namespace MozartCS
{
  public partial class frmPlan : Form
  {
    public DateTime mdSemaine;
    public bool bFax;
    public int miNumIp;
    public int miNumSite;
    public int miNumTech;
    public int miNumAction;
    public string mStrStatutIP;
    public string mstrTypeEdition;
    public string mStrTagIP;
    public double miDuree;

    private int iNb = 0;
    private int iPosPremierTech = 0;
    private int iPosPremierTechSav = 0;// sauvegarde iPosPremierTech de la liste générale. mémorisation lors de l'utilisation de GetTechniciensSpe

    private string sTypeTechAffiche;

    private static int iCurrentTech = 0;

    private DataTable dtTech = new DataTable();

    private List<apiLabel> lstJours = new List<apiLabel>();
    private List<apiLabel> lstHeures = new List<apiLabel>();
    private List<Label> lstLblTech = new List<Label>();
    private List<Label> lstLblTuteur = new List<Label>();
    private List<Label> lstLblPlanif = new List<Label>();
    private List<Label> lstLblTypePoste = new List<Label>();
    private List<Label> lstLblInfo = new List<Label>();
    private List<Label> lstLblH = new List<Label>();
    private List<Label> lstLblPermis = new List<Label>();
    private List<Label> lstLblContremaitre = new List<Label>();
    private List<Label> lstLblClientSitePoste = new List<Label>();
    private List<Button> lstCmdKm = new List<Button>();
    private List<Button> lstCmdMaps = new List<Button>();
    private List<Button> lstCmdOptim = new List<Button>();
    private List<Button> lstCmdPlus = new List<Button>();

    private List<PictureBox> lstPic = new List<PictureBox>();
    //' liste des techniciens selectionnés pour un regroupement
    private string sListeSelectTech = "";
    private DateTime ddatejour;
    // memo position pic0
    Point pic0Locaction;


    public frmPlan() { InitializeComponent(); }

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

    private void frmPlan_Load(object sender, System.EventArgs e)
    {
      try
      {
        Cursor.Current = Cursors.WaitCursor;
        ModuleMain.Initboutons(this);

        cmdCalculKm.Visible = false;// pas d'action

        lstJours.Add(lJour0); lstJours.Add(lJour1); lstJours.Add(lJour2); lstJours.Add(lJour3); lstJours.Add(lJour4); lstJours.Add(lJour5); lstJours.Add(lJour6); lstJours.Add(lJour7);

        lstHeures.Add(lHeure0); lstHeures.Add(lHeure1); lstHeures.Add(lHeure2); lstHeures.Add(lHeure3); lstHeures.Add(lHeure4); lstHeures.Add(lHeure5);
        lstHeures.Add(lHeure6); lstHeures.Add(lHeure7); lstHeures.Add(lHeure8); lstHeures.Add(lHeure9); lstHeures.Add(lHeure10); lstHeures.Add(lHeure11);
        lstHeures.Add(lHeure12); lstHeures.Add(lHeure13); lstHeures.Add(lHeure14); lstHeures.Add(lHeure15); lstHeures.Add(lHeure16);

        lstLblTech.Add(lblTech0); lstLblTech.Add(lblTech1); lstLblTech.Add(lblTech2); lstLblTech.Add(lblTech3);
        lstLblPlanif.Add(lblPlanif0); lstLblPlanif.Add(lblPlanif1); lstLblPlanif.Add(lblPlanif2); lstLblPlanif.Add(lblPlanif3);
        lstLblTuteur.Add(lblTuteur0); lstLblTuteur.Add(lblTuteur1); lstLblTuteur.Add(lblTuteur2); lstLblTuteur.Add(lblTuteur3);
        lstLblContremaitre.Add(lblContremaitre0); lstLblContremaitre.Add(lblContremaitre1); lstLblContremaitre.Add(lblContremaitre2); lstLblContremaitre.Add(lblContremaitre3);
        lstLblTypePoste.Add(lblTypePoste0); lstLblTypePoste.Add(lblTypePoste1); lstLblTypePoste.Add(lblTypePoste2); lstLblTypePoste.Add(lblTypePoste3);
        lstLblInfo.Add(lblInfo0); lstLblInfo.Add(lblInfo1); lstLblInfo.Add(lblInfo2); lstLblInfo.Add(lblInfo3);
        lstLblH.Add(lblH0); lstLblH.Add(lblH1); lstLblH.Add(lblH2); lstLblH.Add(lblH3);
        lstLblClientSitePoste.Add(lblClientSitePoste0); lstLblClientSitePoste.Add(lblClientSitePoste1); lstLblClientSitePoste.Add(lblClientSitePoste2); lstLblClientSitePoste.Add(lblClientSitePoste3);
        lstLblPermis.Add(lblPermis0); lstLblPermis.Add(lblPermis1); lstLblPermis.Add(lblPermis2); lstLblPermis.Add(lblPermis3);
        lstCmdOptim.Add(cmdOptim0); lstCmdOptim.Add(cmdOptim1); lstCmdOptim.Add(cmdOptim2); lstCmdOptim.Add(cmdOptim3);
        lstCmdKm.Add(CmdKms0); lstCmdKm.Add(CmdKms1); lstCmdKm.Add(CmdKms2); lstCmdKm.Add(CmdKms3);
        lstCmdMaps.Add(CmdMapsDIJour0); lstCmdMaps.Add(CmdMapsDIJour1); lstCmdMaps.Add(CmdMapsDIJour2); lstCmdMaps.Add(CmdMapsDIJour3);

        for (int i = 0; i < 28; i++)
          lstCmdPlus.Add((Button)Controls.Find($"cmdPlus{i}", false)[0]);

        // On garde la couleur jaune pour le planning Fitelec avec un fond vert
        BackColor = MozartColors.ColorHC0FFFF;   // &HC0FFFF   jaune
        //Frame2.BackColor = Frame4.BackColor = MozartColors.ColorHC0FFFF;   // &HC0FFFF   jaune

        sTypeTechAffiche = Resources.txt_Tous;
        apiToolTip1.Visible = false;

        //  combo des tech
        //  modif du 25/05/2018 par MC : accès limité sur chef de site
        // FGA le 29/06/22
        //if (ModuleMain.bAccesBouton("588") > 0)
        //  cboInter.Init(MozartDatabase.cnxMozart, "exec [api_sp_ListeTechsByChefSite]", "NPERNUM", "Column1", new List<string> { Resources.col_Num, Resources.col_Nom }, 150, 550);
        //else
        cboInter.Init(MozartDatabase.cnxMozart, "SELECT NPERNUM, REPLACE(VPERNOM,' ','/') + ' ' + VPERPRE [VPERNOM] FROM TPER WHERE VSOCIETE = App_Name() AND CPERACTIF = 'O' AND BUTILISATEUR = 0 " +
                       "AND BVISUPLANNING = 1 ORDER BY  VPERNOM, VPERPRE", "NPERNUM", "VPERNOM", new List<string> { Resources.col_Num, Resources.col_Nom }, 150, 550);

        picTag myTag = new picTag();

        // Constitution du tag d'une nouvelle IP ( code, NumIP(null), NumSite, NumAction, text, DuréeAction, PremierJ, tech, Jour, Multi)
        if (mStrStatutIP == "C")
        {
          myTag.sTag = "N#0#" + miNumSite + "#" + MozartParams.NumAction + "#" + mStrTagIP + "#" + miDuree + "#N#0##N";
          myTag.sInter = $"{mStrTagIP}{miDuree}heures";
          pic0.Visible = true;
        }
        else if (mStrStatutIP == "IP")
        {
          // Constitution du tag d'une nouvelle IP ( code, NumIP(null), NumSite, NumAction, text, DuréeAction, PremierJ, tech, Jour, Multi)
          myTag.sTag = "D#" + miNumIp + "#" + miNumSite + "#0#" + mStrTagIP + "#" + miDuree + "#O#0#01/01/1900#N";
          myTag.sInter = $"{mStrTagIP}{miDuree}heures";
          pic0.Visible = true;
        }
        else
          pic0.Visible = false;

        pic0.Tag = myTag;
        pic0Locaction = pic0.Location;

        //  recherche des techniciens
        iCurrentTech = 0;
        GetTechniciens(true, "N", true);

        if (dtTech != null && miNumTech > 0 && (int)dtTech.Select($"NPERNUM = {miNumTech}").Count() == 0)
        {
          MessageBox.Show(string.Format("{0}", $"La planification est impossible car le technicien ne fait plus partie du personnel actif ou il n'est pas autorisé à être afficher dans le planning (voirle paramétrage de son profil avec le service RH) !"), MZCtrlResources.Global_erreur, MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
          this.Close();
          return;
        }

        (apiToolTip1.Controls["txtTexte"] as TextBox).ScrollBars = ScrollBars.Vertical;

        //  affichage du planning
        InitialiserPlanning();
        bFax = false;
      }
      catch (Exception ex)
      {
        MZUtils.displayError(MethodBase.GetCurrentMethod().Name, ex);
      }
      finally { Cursor.Current = Cursors.Default; }
    }
    //Private Sub Form_Load()
    //  
    //On Error GoTo handler
    //
    //  InitBoutons Me, frmMenu
    //  
    //  ' on garde la couleur jaune pour le planning fitelec avec un fond vert
    //'  If UCase(gstrNomSociete) = "FITELEC" Then
    //    Me.BackColor = &HC0FFFF  ' jaune
    //'  Else
    //    Frame4.BackColor = &HC0FFFF
    //    Frame3.BackColor = &HC0FFFF
    //'  End If
    //  
    //  sTypeTechAffiche = Resources.txt_Tous
    //  iNbrImage = 0
    //  apiToolTip1.Visible = False
    //  
    //  ' combo des tech
    //  cboInter.SizeCombo 900
    //  cboInter.Clear
    //
    //    
    //    'modif du 25/05/2018 par mc : accès limité sur chef de site
    //    If AccesBouton(588) Then
    //        RemplirCombo cboInter, "exec [api_sp_ListeTechsByChefSite]", False
    //    Else
    //        RemplirCombo cboInter, "select NPERNUM, REPLACE(VPERNOM,' ','/') + ' ' + VPERPRE from TPER where VSOCIETE = App_Name() AND CPERACTIF = 'O' AND BUTILISATEUR=0 AND BVISUPLANNING = 1 ORDER BY  VPERNOM, VPERPRE", False
    //    End If
    //
    //  If Me.mStrStatutIP = "C" Then
    //  
    //    ' constitution du tag d'une nouvelle IP ( code, NumIP(null), NumSite, NumAction, text, DuréeAction, PremierJ, tech, Jour, Multi)
    //    pic(0).Tag = "N#0#" & miNumSite & "#" & glNumAction & "#" & mStrTagIP & "#" & miDuree & "#N#0##N"
    //    pic(0).Print Me.mStrTagIP & miDuree & "heures"
    //    pic(0).Visible = True
    //    
    //    '  recherche des techniciens
    //    GetTechniciens True, "N", True
    //
    //    ' affichage du planning en création
    //    Call InitialiserPlanning
    //  
    //  ElseIf Me.mStrStatutIP = "IP" Then
    //    
    //    '  recherche des techniciens
    //    GetTechniciens True, "N", True
    //
    //    ' constitution du tag d'une nouvelle IP ( code, NumIP(null), NumSite, NumAction, text, DuréeAction, PremierJ, tech, Jour, Multi)
    //    pic(0).Tag = "D#" & miNumIP & "#" & miNumSite & "#0#" & mStrTagIP & "#" & miDuree & "#O#0#01/01/1900#N"
    //    pic(0).Print Me.mStrTagIP & miDuree & "heures"
    //    pic(0).Visible = True
    //    
    //    ' afifchage du planning en modification
    //    Call InitialiserPlanning
    //    
    //  Else
    //  
    //    '  recherche des techniciens
    //    GetTechniciens True, "N", True
    //    pic(0).Visible = False
    //    
    //    ' afifchage du planning en modification
    //    Call InitialiserPlanning
    //  End If
    //  bFax = False
    //  Screen.MousePointer = vbDefault
    //  
    //Exit Sub
    //handler:
    //  Screen.MousePointer = vbDefault
    //  ShowError "Form_Load dans " & Me.Name
    //End Sub

    private void Calendrier_CloseUp(object sender, EventArgs e)
    {
      Timer1.Enabled = false;
      mdSemaine = Calendrier.Value.AddDays(Calendrier.Value.DayOfWeek == DayOfWeek.Sunday ? -6 : 1 - (int)Calendrier.Value.DayOfWeek);
      Calendrier.Visible = false;
      InitialiserPlanning();
    }

    private void cmdTablet_Click(object sender, EventArgs e)
    {
      int iNb = 0;
      apiToolTip1.TexteBox = "";

      using (SqlDataReader dr = ModuleData.ExecuteReader($"SELECT DISTINCT VORDIAFFECTATION FROM DBO.TORDI WHERE VORDIMAT = 'TABLET PC' AND VSOCIETE = '{MozartParams.NomSociete}' AND VORDIAFFECTATION <> '' ORDER BY VORDIAFFECTATION"))
      {
        while (dr.Read())
        {
          iNb++;
          apiToolTip1.Texte += $"{dr["vordiaffectation"]}\r\n";
        }
      }
      apiToolTip1.Titre = $"{iNb} {Resources.txt_tech_tablet}";
      apiToolTip1.BackColor = MozartColors.ColorHFFF0FF;
      apiToolTip1.Top = 10;
      apiToolTip1.Height = Math.Min(Height - 60, iNb * 20);
      apiToolTip1.PrintTexte("");
      apiToolTip1.Visible = true;
      apiToolTip1.BringToFront();
    }

    private void cmdTrajets_Click(object sender, EventArgs e)
    {
      string lUrl = $"https://maps.emalec.com/TrajetSemaineService.asp?BASE=MULTI&APP={MozartParams.NomSociete}&Ser={cmdTrajets.Tag}&Semaine={mdSemaine}";
      Process.Start(lUrl);
    }

    private void cboInter_cboClick(object sender, EventArgs e)
    {
      //if (sCurrent != cboInter.GetText())
      //{
      //  sCurrent = cboInter.GetText();
      //  cmdGoTech_Click(null, null);
      //}
    }

    private void cmdCalendrier_Click(object sender, EventArgs e)
    {
      Calendrier.Value = mdSemaine;
      Calendrier.Visible = !Calendrier.Visible;
      Calendrier.ShowCalendar(new MouseEventArgs(MouseButtons.Left, 1, MousePosition.X, MousePosition.Y, 0));
    }

    private void cmdMultitech_Click(object sender, EventArgs e)
    {
      if (lblMultitech.Text == Resources.txt_Multitech)
      {
        lblMultitech.Text = Resources.txt_Tous;
        lblSecondOeuvre.Text = Resources.txt_Travaux_TCE;
        lblclim.Text = Resources.txt_Climaticiens;
        lblFort.Text = Resources.txt_courant_fort;
        lblFaible.Text = Resources.txt_courant_faible;
        lblTrav.Text = Resources.col_plomberie;
        LblIndusServices.Text = Resources.txt_IndusS;
        LblIndusMac.Text = Resources.txt_IndusM;
        lblMone.Text = Resources.txt_Ext_inc;
        lblSelectionTech.Text = Resources.txt_Selection;
        sTypeTechAffiche = Resources.txt_Multi;

        //  recherche des techniciens Multitech
        GetTechniciensSpe(true, "N", "Multi");
        lblInter.Visible = false;
        cboInter.Visible = false;
        cmdGoTech.Visible = false;
        cmdTrajets.Visible = true;
        cmdTrajets.Tag = 4;
      }
      else
      {
        lblMultitech.Text = Resources.txt_Multitech;
        sTypeTechAffiche = Resources.txt_Tous;
        //  recherche des techniciens
        GetTechniciens(true, "N", true);
        lblInter.Visible = true;
        cboInter.Visible = true;
        cmdGoTech.Visible = true;
        cmdTrajets.Visible = false;
        cmdTrajets.Tag = 0;
      }
      // réinitialisation de l'affichage
      InitialiserPlanning();
    }

    private void cmdSecondOeuvre_Click(object sender, EventArgs e)
    {
      if (lblSecondOeuvre.Text == Resources.txt_Travaux_TCE)
      {
        lblSecondOeuvre.Text = Resources.txt_Tous;
        lblclim.Text = Resources.txt_Climaticiens;
        lblFort.Text = Resources.txt_courant_fort;
        lblFaible.Text = Resources.txt_courant_faible;
        lblTrav.Text = Resources.col_plomberie;
        lblMultitech.Text = Resources.txt_Multitech;
        LblIndusServices.Text = Resources.txt_IndusS;
        LblIndusMac.Text = Resources.txt_IndusM;
        lblMone.Text = Resources.txt_Ext_inc;
        lblSelectionTech.Text = Resources.txt_Selection;
        sTypeTechAffiche = Resources.txt_Second;
        //  recherche des techniciens SecondOeuvre
        GetTechniciensSpe(true, "N", "Second");
        lblInter.Visible = false;
        cboInter.Visible = false;
        cmdGoTech.Visible = false;
        cmdTrajets.Visible = true;
        cmdTrajets.Tag = 7;
      }
      else
      {
        lblSecondOeuvre.Text = Resources.txt_Travaux_TCE;
        sTypeTechAffiche = Resources.txt_Tous;
        //  recherche des techniciens
        GetTechniciens(true, "N", true);
        lblInter.Visible = true;
        cboInter.Visible = true;
        cmdGoTech.Visible = true;
        cmdTrajets.Visible = false;
        cmdTrajets.Tag = 0;
      }
      // réinitialisation de l//affichage
      InitialiserPlanning();
    }

    private void cmdSelectionTech_Click(object sender, EventArgs e)
    {
      sListeSelectTech = "";

      if (lblSelectionTech.Text == Resources.txt_Selection)
      {
        frmPlanSelectTech f = new frmPlanSelectTech();
        f.ShowDialog();
        if (f.sListeSelectTech != "")
        {
          sListeSelectTech = f.sListeSelectTech;
          lblSelectionTech.Text = Resources.txt_Tous;
          lblclim.Text = Resources.txt_Climaticiens;
          lblFort.Text = Resources.txt_courant_fort;
          lblFaible.Text = Resources.txt_courant_faible;
          lblSecondOeuvre.Text = Resources.txt_Travaux_TCE;
          lblTrav.Text = Resources.col_plomberie;
          LblIndusServices.Text = Resources.txt_IndusS;
          LblIndusMac.Text = Resources.txt_IndusM;
          lblMone.Text = Resources.txt_Ext_inc;
          sTypeTechAffiche = Resources.txt_Selection;
          //  recherche des techniciens Sélection
          GetTechniciensSpe(true, "N", "Regroup");
          lblInter.Visible = false;
          cboInter.Visible = false;
          cmdGoTech.Visible = false;
          cmdTrajets.Visible = false;
          cmdTrajets.Tag = 0;
        }
      }
      else
      {
        lblSelectionTech.Text = Resources.txt_Selection;
        sTypeTechAffiche = Resources.txt_Tous;
        //  recherche des techniciens
        GetTechniciens(true, "N", true);
        lblInter.Visible = true;
        cboInter.Visible = true;
        cmdGoTech.Visible = true;
        cmdTrajets.Visible = false;
        cmdTrajets.Tag = 0;
      }
      // réinitialisation de l//affichage
      InitialiserPlanning();

    }

    private void cmdClim_Click(object sender, EventArgs e)
    {
      if (lblclim.Text == Resources.txt_Climaticiens)
      {
        lblclim.Text = Resources.txt_Tous;
        lblFort.Text = Resources.txt_courant_fort;
        lblFaible.Text = Resources.txt_courant_faible;
        lblSecondOeuvre.Text = Resources.txt_Travaux_TCE;
        lblTrav.Text = Resources.col_plomberie;
        lblMultitech.Text = Resources.txt_Multitech;
        LblIndusServices.Text = Resources.txt_IndusS;
        LblIndusMac.Text = Resources.txt_IndusM;
        lblMone.Text = Resources.txt_Ext_inc;
        lblSelectionTech.Text = Resources.txt_Selection;
        LblLegCommerce.Text = MZCtrlResources.Commercial;
        sTypeTechAffiche = Resources.txt_Climaticiens;
        //  recherche des techniciens clim
        GetTechniciensSpe(true, "N", "Clim");
        lblInter.Visible = false;
        cboInter.Visible = false;
        cmdGoTech.Visible = false;
        cmdTrajets.Visible = true;
        cmdTrajets.Tag = 1;
      }
      else
      {
        lblclim.Text = Resources.txt_Climaticiens;
        sTypeTechAffiche = Resources.txt_Tous;
        //  recherche des techniciens
        GetTechniciens(true, "N", true);
        lblInter.Visible = true;
        cboInter.Visible = true;
        cmdGoTech.Visible = true;
        cmdTrajets.Visible = false;
        cmdTrajets.Tag = 0;
      }
      // réinitialisation de l//affichage
      InitialiserPlanning();
    }
    //Private Sub cmdClim_Click()
    //  On Error Resume Next
    //  rsT.Close ' fermeture du recordset des techs
    //  If lblclim.Caption = Resources.txt_Climaticiens Then
    //    lblclim.Caption = Resources.txt_Tous
    //    lblFort.Caption = Resources.txt_courant_fort
    //    lblFaible.Caption = Resources.txt_courant_faible
    //    lblSecondOeuvre.Caption = Resources.txt_Travaux_TCE
    //    lblTrav.Caption = Resources.col_plomberie
    //    lblMultitech.Caption = Resources.txt_Multitech
    //    LblIndusServices.Caption = Resources.txt_IndusS
    //    LblIndusMac.Caption = Resources.txt_IndusM
    //    lblMone.Caption = Resources.txt_Ext_inc
    //    lblSelectionTech.Text = Resources.txt_Selection
    //    sTypeTechAffiche = "Climaticiens"
    //    '  recherche des techniciens clim
    //    GetTechniciensSpe True, "N", "Clim"
    //    lblInter.Visible = False
    //    cboInter.Visible = False
    //    cmdGoTech.Visible = False
    //    cmdTrajets.Visible = True
    //    cmdTrajets.Tag = 1
    //  Else
    //    lblclim.Caption = Resources.txt_Climaticiens
    //    sTypeTechAffiche = Resources.txt_Tous
    //    '  recherche des techniciens
    //    GetTechniciens True, "N", True
    //    lblInter.Visible = True
    //    cboInter.Visible = True
    //    cmdGoTech.Visible = True
    //    cmdTrajets.Visible = False
    //    cmdTrajets.Tag = 0
    //  End If
    //  ' réinitialisation de l'affichage
    //  Call InitialiserPlanning
    //
    //End Sub

    /* OK --------------------------------------------------------------------------------------- */
    private void cmdCFort_Click(object sender, EventArgs e)
    {
      if (lblFort.Text == Resources.txt_courant_fort)
      {
        lblFort.Text = Resources.txt_Tous;
        lblclim.Text = Resources.txt_Climaticiens;
        lblFaible.Text = Resources.txt_courant_faible;
        lblSecondOeuvre.Text = Resources.txt_Travaux_TCE;
        lblTrav.Text = Resources.col_plomberie;
        lblMultitech.Text = Resources.txt_Multitech;
        LblIndusServices.Text = Resources.txt_IndusS;
        LblIndusMac.Text = Resources.txt_IndusM;
        lblMone.Text = Resources.txt_Ext_inc;
        LblLegCommerce.Text = MZCtrlResources.Commercial;
        lblSelectionTech.Text = Resources.txt_Selection;
        sTypeTechAffiche = Resources.txt_CFort;
        //  recherche des techniciens clim
        GetTechniciensSpe(true, "N", "CFort");
        lblInter.Visible = false;
        cboInter.Visible = false;
        cmdGoTech.Visible = false;
        cmdTrajets.Visible = true;
        cmdTrajets.Tag = 2;
      }
      else
      {
        lblFort.Text = Resources.txt_courant_fort;
        sTypeTechAffiche = Resources.txt_Tous;
        //  recherche des techniciens
        GetTechniciens(true, "N", true);
        lblInter.Visible = true;
        cboInter.Visible = true;
        cmdGoTech.Visible = true;
        cmdTrajets.Visible = false;
        cmdTrajets.Tag = 0;
      }
      // réinitialisation de l'affichage
      InitialiserPlanning();
    }
    //Private Sub cmdCfort_Click()
    //  On Error Resume Next
    //  rsT.Close ' fermeture du recordset des techs
    //  If lblFort.Caption = Resources.txt_courant_fort Then
    //    lblFort.Caption = Resources.txt_Tous
    //    lblclim.Caption = Resources.txt_Climaticiens
    //    lblFaible.Caption = Resources.txt_courant_faible
    //    lblSecondOeuvre.Caption = Resources.txt_Travaux_TCE
    //    lblTrav.Caption = Resources.col_plomberie
    //    lblMultitech.Caption = Resources.txt_Multitech
    //    LblIndusServices.Caption = Resources.txt_IndusS
    //    LblIndusMac.Caption = Resources.txt_IndusM
    //    lblMone.Caption = Resources.txt_Ext_inc
    //    lblSelectionTech.Text = Resources.txt_Selection
    //    sTypeTechAffiche = "§CFort§"
    //    '  recherche des techniciens clim
    //    GetTechniciensSpe True, "N", "CFort"
    //    lblInter.Visible = False
    //    cboInter.Visible = False
    //    cmdGoTech.Visible = False
    //    cmdTrajets.Visible = True
    //    cmdTrajets.Tag = 2
    //  Else
    //    lblFort.Caption = Resources.txt_courant_fort
    //    sTypeTechAffiche = Resources.txt_Tous
    //    '  recherche des techniciens
    //    GetTechniciens True, "N", True
    //    lblInter.Visible = True
    //    cboInter.Visible = True
    //    cmdGoTech.Visible = True
    //    cmdTrajets.Visible = False
    //    cmdTrajets.Tag = 0
    //  End If
    //  ' réinitialisation de l'affichage
    //  Call InitialiserPlanning
    //End Sub

    /* OK --------------------------------------------------------------------------------------- */
    private void cmdCFaible_Click(object sender, EventArgs e)
    {
      if (lblFaible.Text == Resources.txt_courant_faible)
      {
        lblFaible.Text = Resources.txt_Tous;
        lblclim.Text = Resources.txt_Climaticiens;
        lblFort.Text = Resources.txt_courant_fort;
        lblSecondOeuvre.Text = Resources.txt_Travaux_TCE;
        lblTrav.Text = Resources.col_plomberie;
        lblMultitech.Text = Resources.txt_Multitech;
        LblIndusServices.Text = Resources.txt_IndusS;
        LblIndusMac.Text = Resources.txt_IndusM;
        lblMone.Text = Resources.txt_Ext_inc;
        LblLegCommerce.Text = MZCtrlResources.Commercial;
        lblSelectionTech.Text = Resources.txt_Selection;
        sTypeTechAffiche = Resources.txt_CFaible;
        //  recherche des techniciens courant faible
        GetTechniciensSpe(true, "N", "CFaible");
        lblInter.Visible = false;
        cboInter.Visible = false;
        cmdGoTech.Visible = false;
        cmdTrajets.Visible = true;
        cmdTrajets.Tag = 3;
      }
      else
      {
        lblFaible.Text = Resources.txt_courant_faible;
        sTypeTechAffiche = Resources.txt_Tous;
        //  recherche des techniciens
        GetTechniciens(true, "N", true);
        lblInter.Visible = true;
        cboInter.Visible = true;
        cmdGoTech.Visible = true;
        cmdTrajets.Visible = false;
        cmdTrajets.Tag = 0;
      }
      // réinitialisation de l affichage
      InitialiserPlanning();

    }
    //Private Sub cmdCfaible_Click()
    //  On Error Resume Next
    //  rsT.Close ' fermeture du recordset des techs
    //  If lblFaible.Caption = Resources.txt_courant_faible Then
    //    lblFaible.Caption = Resources.txt_Tous
    //    lblclim.Caption = Resources.txt_Climaticiens
    //    lblFort.Caption = Resources.txt_courant_fort
    //    lblSecondOeuvre.Caption = Resources.txt_Travaux_TCE
    //    lblTrav.Caption = Resources.col_plomberie
    //    lblMultitech.Caption = Resources.txt_Multitech
    //    LblIndusServices.Caption = Resources.txt_IndusS
    //    LblIndusMac.Caption = Resources.txt_IndusM
    //    lblMone.Caption = Resources.txt_Ext_inc
    //    lblSelectionTech.Text = Resources.txt_Selection
    //    sTypeTechAffiche = "§CFaible§"
    //    '  recherche des techniciens courant faible
    //    GetTechniciensSpe True, "N", "CFaible"
    //    lblInter.Visible = False
    //    cboInter.Visible = False
    //    cmdGoTech.Visible = False
    //    cmdTrajets.Visible = True
    //    cmdTrajets.Tag = 3
    //  Else
    //    lblFaible.Caption = Resources.txt_courant_faible
    //    sTypeTechAffiche = Resources.txt_Tous
    //    '  recherche des techniciens
    //    GetTechniciens True, "N", True
    //    lblInter.Visible = True
    //    cboInter.Visible = True
    //    cmdGoTech.Visible = True
    //    cmdTrajets.Visible = False
    //    cmdTrajets.Tag = 0
    //  End If
    //  ' réinitialisation de l'affichage
    //  Call InitialiserPlanning
    //End Sub

    /* OK --------------------------------------------------------------------------------------- */
    private void cmdTrav_Click(object sender, EventArgs e)
    {
      if (lblTrav.Text == Resources.col_plomberie)
      {
        lblTrav.Text = Resources.txt_Tous;
        lblclim.Text = Resources.txt_Climaticiens;
        lblFort.Text = Resources.txt_courant_fort;
        lblFaible.Text = Resources.txt_courant_faible;
        lblSecondOeuvre.Text = Resources.txt_Travaux_TCE;
        lblMultitech.Text = Resources.txt_Multitech;
        LblIndusServices.Text = Resources.txt_IndusS;
        LblIndusMac.Text = Resources.txt_IndusM;
        lblMone.Text = Resources.txt_Ext_inc;
        LblLegCommerce.Text = MZCtrlResources.Commercial;
        lblSelectionTech.Text = Resources.txt_Selection;
        sTypeTechAffiche = Resources.txt_Plomb;
        //  recherche des techniciens Plomberie
        GetTechniciensSpe(true, "N", "Plomb");
        lblInter.Visible = false;
        cboInter.Visible = false;
        cmdGoTech.Visible = false;
        cmdTrajets.Visible = true;
        cmdTrajets.Tag = 8;
      }
      else
      {
        lblTrav.Text = Resources.col_plomberie;
        sTypeTechAffiche = Resources.txt_Tous;
        //  recherche des techniciens
        GetTechniciens(true, "N", true);
        lblInter.Visible = true;
        cboInter.Visible = true;
        cmdGoTech.Visible = true;
        cmdTrajets.Visible = false;
        cmdTrajets.Tag = 0;
      }
      // réinitialisation de l'affichage
      InitialiserPlanning();
    }
    //Private Sub cmdTrav_Click()
    //  On Error Resume Next
    //  rsT.Close ' fermeture du recordset des techs
    //  If lblTrav.Caption = Resources.col_plomberie Then
    //    lblTrav.Caption = Resources.txt_Tous
    //    lblclim.Caption = Resources.txt_Climaticiens
    //    lblFort.Caption = Resources.txt_courant_fort
    //    lblFaible.Caption = Resources.txt_courant_faible
    //    lblSecondOeuvre.Caption = Resources.txt_Travaux_TCE
    //    lblMultitech.Caption = Resources.txt_Multitech
    //    LblIndusServices.Caption = Resources.txt_IndusS
    //    LblIndusMac.Caption = Resources.txt_IndusM
    //    lblMone.Caption = Resources.txt_Ext_inc
    //    lblSelectionTech.Text = Resources.txt_Selection
    //    sTypeTechAffiche = "§Plomb§"
    //    '  recherche des techniciens courant faible
    //    GetTechniciensSpe True, "N", "Plomb"
    //    lblInter.Visible = False
    //    cboInter.Visible = False
    //    cmdGoTech.Visible = False
    //    cmdTrajets.Visible = True
    //    cmdTrajets.Tag = 8
    //  Else
    //    lblTrav.Caption = Resources.col_plomberie
    //    sTypeTechAffiche = Resources.txt_Tous
    //    '  recherche des techniciens
    //    GetTechniciens True, "N", True
    //    lblInter.Visible = True
    //    cboInter.Visible = True
    //    cmdGoTech.Visible = True
    //    cmdTrajets.Visible = False
    //    cmdTrajets.Tag = 0
    //  End If
    //  ' réinitialisation de l'affichage
    //  Call InitialiserPlanning
    //End Sub

    /* OK --------------------------------------------------------------------------------------- */
    private void cmdOptim_Click(object sender, EventArgs e)
    {
      new frmBrowser
      {
        msStartingAddress = $"https://maps.emalec.com/TrajetTechnicienSemaineSelected.asp?BASE=MULTI&APP={MozartParams.NomSociete}&NumTech={(sender as Control).Tag}&Semaine={mdSemaine.ToShortDateString()}"
      }.ShowDialog();


      //Process.Start("msedge.exe", msStartingAddress.Replace(" ", "%20"));

    }
    //Private Sub cmdOptim_Click(Index As Integer)
    //    'Mise en com le 24/08/2010 suite à la demande de Jean
    //  'If cmdOptim(Index).Caption = "§? km§" Then
    //    'CalculKmSemaine Index
    //  'Else
    //    ' TB SAMSIC CITY SPEC
    //    If gstrNomGroupe = "EMALEC" Then
    //      frmBrowser.StartingAddress = "http://maps.emalec.com/TrajetTechnicienSemaineSelected.asp?BASE=MULTI&APP=" & gstrNomSociete & "&NumTech=" & lblTech(Index).Tag & "&Semaine=" & DebutSemaine
    //    End If ' TB SAMSIC CITY TODO -> else pour samsic
    //    frmBrowser.Show vbModal
    //  'End If
    //End Sub

    /* OK --------------------------------------------------------------------------------------- */
    private void cmdLegende_Click(object sender, EventArgs e)
    {
      new frmLegende().ShowDialog();
    }
    //Private Sub cmdLegende_Click()
    //  frmLegende.Show vbModal
    //End Sub

    /* OK --------------------------------------------------------------------------------------- */
    private void cmdGoTech_Click(object sender, EventArgs e)
    {
      if (iCurrentTech != cboInter.GetItemData())
      {
        miNumTech = iCurrentTech = cboInter.GetItemData();

        GetTechniciens(true, "P", false);
        InitialiserPlanning();
      }
    }
    //Private Sub cmdGoTech_Click()
    //
    //  miNumTech = cboInter.ItemData(cboInter.ListIndex)
    //  GetTechniciens True, "P", False
    //  Call InitialiserPlanning
    //
    //End Sub

    /* OK --------------------------------------------------------------------------------------- */
    private void GetTechniciens(bool bPremierFois, string sDirection, bool bFindTech = false)
    {
      try
      {
        if (bPremierFois && bFindTech)
        {
          iPosPremierTech = iPosPremierTechSav;// cas boutons spéciaux (multi, etc..) => restaure la position

          string sSql = "";
          // Modif du 25/05/2018 par MC : gestion des chefs de site
          // fga le 29/06/22
          //if (ModuleMain.bAccesBouton("588") > 0)
          //  sSql = "select * from [api_v_ListeTechniciensByChefSite] ORDER BY CPERTYP desc, VSERLIB, NREGROUPREG, VREGLIB, NREGCOD";
          //else
          {
            //        ' TB SAMSICK CITY SPEC
            //        ' Condition qui dépend de EMALECMPM
            if (MozartParams.NomSociete == "EMALECMPM")
              sSql = "select * from [api_v_listeTechniciens2] ORDER BY "
                                  + "Case CPERTYP "
                                      + "WHEN 'TE' THEN "
                                          + "Case CPERTYPDETAIL "
                                                  + "WHEN 'CM' THEN 1 "
                                                  + "Else "
                                                      + "Case NSERNUM "
                                                          + "WHEN 21 THEN 2 "
                                                          + "WHEN 20 THEn 3 "
                                                      + "ELSE 4 "
                                                  + "End "
                                              + "End "
                                      + "WHEN 'BE' THEN 5 "
                                      + "WHEN 'GE' THEN "
                                          + "Case NSERNUM "
                                              + "WHEN 19 THEN 6 "
                                              + "ELSE  7 "
                                          + "End "
                                      + "Else "
                                          + "Case NSERNUM "
                                              + "WHEN 6 THEN 8 "
                                              + "ELSE 9 "
                                          + "End "
                                  + "END, "
                                  + "VPERNOM";
            else
              sSql = "select * from api_v_listeTechniciens2 ORDER BY CPERTYP desc, VSERLIB,NREGROUPREG, VREGLIB , NREGCOD";
          }
          ModuleData.LoadData(dtTech, sSql);
        }


        DataColumn[] keys = new DataColumn[1];
        keys[0] = dtTech.Columns["NPERNUM"];
        dtTech.PrimaryKey = keys;

        // On se place sur le bon technicien si c'est la premiere fois
        if (bPremierFois)
        {
          if (miNumTech != 0)
          {

            if ((int)dtTech.Select($"NPERNUM = {miNumTech}").Count() == 0)
            {
              //MessageBox.Show(string.Format("{0}", $"La planification est impossible car le technicien ne fait plus partie du personnel actif !"), MZCtrlResources.Global_erreur, MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
              return;
            }

            DataRow[] rowT = dtTech.Select($"NPERNUM = {miNumTech}");
            iPosPremierTech = dtTech.Rows.IndexOf(rowT[0]);

            // on le place au milieu
            iPosPremierTech -= Math.Min(iPosPremierTech, 2);
          }
        }
        else
        {
          // traitement des cas suivant et précédent
          if (sDirection == "TECHSUIV")
          {
            // rien car on est déja bien placé à moins que l'on soit EOF, alors on sort
            if (iPosPremierTech + 3 >= dtTech.Rows.Count)
              return;
            else
              iPosPremierTech += 4;
          }
          else
            // on remonte de 8 cases
            iPosPremierTech -= Math.Min(iPosPremierTech, 4);
        }

        AfficheInfosTechniciens();
      }
      catch (Exception ex)
      {
        MZUtils.displayError(MethodBase.GetCurrentMethod().Name, ex);
      }
    }

    /* OK --------------------------------------------------------------------------------------- */
    private void AfficheInfosTechniciens()
    {
      // initialisation des 4 techniciens et placement des techniciens
      for (int i = 0; i <= 3; i++)
      {
        Color lblsBackColor = this.BackColor;
        if (iPosPremierTech + i < dtTech.Rows.Count)
        {
          DataRow rowT = dtTech.Rows[iPosPremierTech + i];
          lstLblTech[i].Tag = rowT["NPERNUM"];
          lstCmdOptim[i].Tag = rowT["NPERNUM"];
          lstCmdKm[i].Tag = rowT["NPERNUM"];
          lstCmdMaps[i].Tag = rowT["NPERNUM"];
          lstLblTech[i].Text = rowT["VPERNOM"].ToString();
          lstLblInfo[i].Text = $"{rowT["VSERLIB"]}\r\n{rowT["VREGLIB"]}";
          lstLblPlanif[i].Text = Utils.BlankIfNull(rowT["VPLANIFICATEUR"]);
          lstLblTuteur[i].Text = Utils.BlankIfNull(rowT["VTUTEUR"]);
          lstLblPermis[i].Text = Utils.BlankIfNull(rowT["VPERPERMI"]) == "B" ? "" : $"{Resources.col_Permis} : {Utils.BlankIfNull(rowT["VPERPERMI"]).Replace("B,", "")}";
          lstLblTypePoste[i].Text = Utils.BlankIfNull(rowT["VPERTYPEPOSTE"]);
          lstLblContremaitre[i].Text = Utils.BlankIfNull(rowT["VTYPEDETAILLIB"]);
          lstLblClientSitePoste[i].Text = Utils.BlankIfNull(rowT["VSITNOM_POSTE"]) == "" ? "" : $"{MZCtrlResources.col_Client} : {Utils.BlankIfNull(rowT["VCLINOM_POSTE"])}\r\n{Resources.col_Site} : {Utils.BlankIfNull(rowT["VSITNOM_POSTE"])}";

          // mise en forme : gestion couleur si contremaitre
          lblsBackColor = Utils.BlankIfNull(rowT["CPERTYPDETAIL"]) == "CM" ? MozartColors.ColorHFFC0C0 : MozartColors.ColorHC0FFFF;
          lstLblTech[i].Visible = lstCmdOptim[i].Visible = lstLblH[i].Visible = true;
        }
        else
        {
          lstLblH[i].Text = "";
          lstLblTech[i].Tag = "";
          lstLblInfo[i].Text = "";
          lstCmdKm[i].Tag = "";
          lstCmdMaps[i].Tag = "";
          lstCmdOptim[i].Tag = "";
          lstLblTech[i].Text = "";
          lstLblPlanif[i].Text = "";
          lstLblTuteur[i].Text = "";
          lstLblPermis[i].Text = "";
          lstLblTypePoste[i].Text = "";
          lstLblContremaitre[i].Text = "";
          lstLblClientSitePoste[i].Text = "";
          lstLblTech[i].Visible = lstCmdOptim[i].Visible = lstLblH[i].Visible = false;
        }

        lstLblTech[i].BackColor = lstLblTuteur[i].BackColor = lstLblContremaitre[i].BackColor = lstLblInfo[i].BackColor = lstLblPlanif[i].BackColor =
        lstLblTypePoste[i].BackColor = lstLblClientSitePoste[i].BackColor = lstLblPermis[i].BackColor = lstLblH[i].BackColor = lblsBackColor;
      }
    }

    private void GetTechniciensSpe(bool bPremierFois, string sDirection, string sType)
    {
      if (bPremierFois)
      {
        iPosPremierTechSav = iPosPremierTech;
        iPosPremierTech = 0;

        string sSql = "";
        switch (sType)
        {
          case "Clim":
            sSql = "select * from api_v_listeTechniciens2 where NSERNUM = 1 AND CPERTYP = 'TE' ORDER BY CPERTYP desc, VSERLIB,NREGROUPREG, VREGLIB , NREGCOD ";
            break;
          case "CFort":
            sSql = "select * from api_v_listeTechniciens2 where NSERNUM = 2 AND CPERTYP = 'TE' ORDER BY CPERTYP desc, VSERLIB,NREGROUPREG, VREGLIB , NREGCOD ";
            break;
          case "CFaible":
            sSql = "select * from api_v_listeTechniciens2 where NSERNUM = 3 AND CPERTYP = 'TE' ORDER BY CPERTYP desc, VSERLIB,NREGROUPREG, VREGLIB , NREGCOD ";
            break;
          case "Multi":
            sSql = "select * from api_v_listeTechniciens2 where NSERNUM = 4 AND CPERTYP = 'TE' ORDER BY CPERTYP desc, VSERLIB,NREGROUPREG, VREGLIB , NREGCOD ";
            break;
          case "Second":
            sSql = "select * from api_v_listeTechniciens2 where NSERNUM = 7 AND CPERTYP = 'TE' ORDER BY CPERTYP desc, VSERLIB,NREGROUPREG, VREGLIB , NREGCOD ";
            break;
          case "Plomb":
            sSql = "select * from api_v_listeTechniciens2 where NSERNUM = 8 AND CPERTYP = 'TE' ORDER BY CPERTYP desc, VSERLIB,NREGROUPREG, VREGLIB , NREGCOD ";
            break;
          case "IndusSer":
            sSql = "select * from api_v_listeTechniciens2 where NSERNUM = 20 AND CPERTYP = 'TE' ORDER BY CPERTYP desc, VSERLIB,NREGROUPREG, VREGLIB , NREGCOD ";
            break;
          case "IndusMac":
            sSql = "select * from api_v_listeTechniciens2 where NSERNUM = 21 AND CPERTYP = 'TE' ORDER BY CPERTYP desc, VSERLIB,NREGROUPREG, VREGLIB , NREGCOD ";
            break;
          case "EI":
            sSql = "select * from api_v_listeTechniciens2 where NSERNUM = 11 AND CPERTYP = 'TE' ORDER BY CPERTYP desc, VSERLIB,NREGROUPREG, VREGLIB , NREGCOD ";
            break;
          case "CO":
            sSql = "select * from api_v_listeTechniciens2 where CPERTYP = 'CO' ORDER BY CPERTYP desc, VSERLIB,NREGROUPREG, VREGLIB , NREGCOD ";
            break;
          case "Regroup":
            sSql = "select * from api_v_listeTechniciens2 where NPERNUM in (" + sListeSelectTech + ") ORDER BY CPERTYP desc, VSERLIB,NREGROUPREG, VREGLIB , NREGCOD ";
            break;
        }
        ModuleData.LoadData(dtTech, sSql);
      }
      else
      {
        // traitement des cas suivant et précédent
        if (sDirection == "TECHSUIV")
        {
          // rien car on est déja bien placé à moins que l'on soit EOF, alors on sort
          if (iPosPremierTech + 3 >= dtTech.Rows.Count)
            return;
          else
            iPosPremierTech += 4;
        }
        else
          // on remonte de 4 cases
          iPosPremierTech -= Math.Min(iPosPremierTech, 4);
      }

      AfficheInfosTechniciens();
    }
    
    private void InitialiserPlanning(int iCacherIP = 0)
    {
      try
      {
        int k = 0;
        Double nbH; // nombre d'heure du technicien dans la semaine

        // Fonction qui donne le premier jour de la semaine (lundi)
        mdSemaine = mdSemaine.AddDays(mdSemaine.DayOfWeek == DayOfWeek.Sunday ? -6 : 1 - (int)mdSemaine.DayOfWeek);

        //  Recherche du numéro de semaine
        lblSemaine.Text = Resources.txt_semaine + UtilsPlan.WeekOfDate(mdSemaine);
        lblAnnee.Text = Resources.col_annee + " " + mdSemaine.Year.ToString();

        //  ' affichage des jours de la semaine (prise en compte des congés)
        UtilsPlan.TexteEtCouleurJour(Label10, mdSemaine);
        UtilsPlan.TexteEtCouleurJour(Label11, mdSemaine.AddDays(1));
        UtilsPlan.TexteEtCouleurJour(Label12, mdSemaine.AddDays(2));
        UtilsPlan.TexteEtCouleurJour(Label13, mdSemaine.AddDays(3));
        UtilsPlan.TexteEtCouleurJour(Label14, mdSemaine.AddDays(4));
        UtilsPlan.TexteEtCouleurJour(Label15, mdSemaine.AddDays(5));
        UtilsPlan.TexteEtCouleurJour(Label16, mdSemaine.AddDays(6));

        foreach (PictureBox item in lstPic)
        {
          Controls.Remove(item);
          item.Dispose();
        }

        lstPic.Clear();

        DataTable dt = new DataTable();

        // placement des interventions
        for (int j = 0; j < 4; j++)     // 0,1,2,3 = 4 techniciens sur le planning
        {
          int nbIpJour = 1;
          lstCmdOptim[j].Text = Resources.txt_Trajet;
          lstLblH[j].Text = "? H";
          nbH = 0;

          for (int c = j * 7; c <= (j * 7) + 6; c++)
          {
            cmdPlusTag cmdTag = new cmdPlusTag
            {
              iBtn = c,
              iTech = lstLblTech[j].Tag == null || lstLblTech[j].Tag.ToString() == "" ? 0 : Convert.ToInt32(lstLblTech[j].Tag),
              sDateJour = mdSemaine.AddDays(c % 7).ToShortDateString()
            };
            lstCmdPlus[cmdTag.iBtn].Tag = cmdTag;
          }

          // liste des interventions par techniciens pour la semaine en cours
          if (lstLblTech[j].Tag.ToString() != "")
          {
            dt.Clear();
            dt.Load(ModuleData.ExecuteReader($"api_sp_listeInterventions {lstLblTech[j].Tag}, '{mdSemaine}" + "', 6, 12"));

            foreach (DataRow row in dt.Rows)
            {
              picTag myTag = new picTag();
              // on affiche seulement les 4 premiers pavés
              //  mais on prend tous les pavés pour le calcul du nombre d'heures
              // Permet d'afficher un numero de pavé qui correspond au numéro affiché sur la carte de trajet tech semaine
              // on commence à 2, car le 1 correspond au domicile du tech
              nbIpJour++;

              if (Convert.ToInt32(row["NIPLIND"]) <= 4)
              {
                // Création d'une image
                k += 1;
                DateTime datePla = Convert.ToDateTime(row["DIPLDATJ"]);

                PictureBox pic = new PictureBox();

                pic.Margin = new Padding(-3, 60, 0, 0);

                //      Coordonnées de l'image (pb avec le dimanche car son weekday = 0)
                pic.Left = lstJours[datePla.DayOfWeek == DayOfWeek.Sunday ? 6 : (int)datePla.DayOfWeek - 1].Left;
                pic.Top = lstHeures[(j * 4) + (int)row["NIPLIND"] - 1].Top;
                pic.Size = pic0.Size;

                // Constitution du tag d'une IP (code, NumIP, NumSite, NumAction(0), text, duree, premierJ , tech)
                myTag.sTag = "D#";
                myTag.sTag += $"{row["NIPLNUM"]}#";
                myTag.sTag += $"{row["NSITNUM"]}#0#";
                myTag.sTag += $"{row["VCLINOM"]}\r\n";
                myTag.sTag += $"{row["VSITNOM"]}\r\n#";
                myTag.sTag += $"{row["NIPLDUR"]}#";
                myTag.sTag += $"{row["CIPLDEB"]}#";
                myTag.sTag += $"{lstLblTech[j].Tag}#";
                myTag.sTag += $"{datePla.ToShortDateString()}#";
                myTag.sTag += $"{row["CIPLMULT"]}#";

                // Pour les sites emalec spéciaux couleur : jaune
                if (UtilsPlan.GetMozart_Soc_By_Site(Convert.ToInt32(row["NSITNUM"])) > 0)
                  pic.BackColor = Color.Yellow;   // &HFFFF &
                else
                {
                  // couleur standard = bleu clair
                  pic.BackColor = MozartColors.ColorHFFFFC0;  //&HFFFFC0

                  //  si multi-jour : bleu foncé
                  if (row["CIPLMULT"].ToString() == "O")
                    pic.BackColor = MozartColors.ColorHFFFF00;  // &HFF80FF

                  // si c'est la nuit :  rouge                                                
                  if (row["CACTNUIT"].ToString() == "O") pic.BackColor = Color.Red;

                  // si c'est hors présence public :  rouge clair
                  if (row["CACTNUIT"].ToString() == "P") pic.BackColor = MozartColors.colorHC0C0FF;

                  // si date d'execution : orange
                  // si attachement (et exécution): Vert
                  using (SqlDataReader drCode = ModuleData.ExecuteReader($"exec api_sp_ControleDateExec_Attach {row["NIPLNUM"]}"))
                  {
                    if (drCode.Read())
                    {
                      if (Convert.ToInt32(drCode[0]) == 0) pic.BackColor = Color.FromArgb(255, 193, 125); // RGB(255, 193, 125)
                      if (Convert.ToInt32(drCode[1]) == 0) pic.BackColor = Color.FromArgb(192, 255, 192); // &HC0FFC0
                    }
                  }

                  // si facture, et exec, et attach : blanc
                  if (row["nbfact"].ToString() != "0" && pic.BackColor == Color.FromArgb(192, 255, 192))
                    pic.BackColor = Color.White;

                  // si autre personne sur site au meme moment = bleu violet
                  if (pic.BackColor == MozartColors.ColorHFFFFC0)
                    if (!UtilsPlan.VerifAide(Convert.ToInt32(row["NIPLNUM"]), miNumAction, false))
                      pic.BackColor = MozartColors.ColorHFFC0C0;
                }

                // Affichage des informations dans l'image
                myTag.sInter = (row["CACTNOK"].ToString() == "O" ? "(*)" : "") + $"{row["VCLINOM"]}\r\n{row["VSITNOM"]}\r\n{$"{row["NIPLDURJ"]:0.##}"}h {row["sCODE"]} " + UtilsPlan.ReturnCodePaveBloque(Convert.ToBoolean(row["BACTPAVEBLOCK"]));

                if (Convert.ToInt32(row["nbfact"]) > 0) myTag.sInter += $" €";
                if (Utils.ZeroIfNull(row["PrevMag"]) > 0) myTag.sInter += $" #";

                if (Utils.BlankIfNull(row["VACTHRRDV"]) != "") myTag.sInter += $" RV {row["VACTHRRDV"]} ";

                //  Calage a droite (18 cara / ligne)
                string[] LinesPave = Strings.Split(myTag.sInter, "\r\n");
                int NbLines = LinesPave.Length;
                int LgLine = LinesPave[NbLines - 1].Length;

                if (LgLine >= 4 && LgLine < 8)
                  myTag.sInter += Strings.Space(31 - LinesPave[NbLines - 1].Length);
                else if (LgLine >= 8 && LgLine < 11)
                  myTag.sInter += Strings.Space(28 - LinesPave[NbLines - 1].Length);
                else if (LgLine >= 11 && LgLine < 18)
                  myTag.sInter += Strings.Space(24 - LinesPave[NbLines - 1].Length);

                myTag.sInter += nbIpJour.ToString();
                pic.Tag = myTag;

                pic.AllowDrop = true;
                pic.Paint += new PaintEventHandler(pic_Paint);
                pic.DragDrop += new DragEventHandler(pic_DragDrop);
                pic.MouseUp += new MouseEventHandler(pic_MouseUp);
                pic.MouseDown += new MouseEventHandler(pic_MouseDown);
                pic.DragEnter += new DragEventHandler(allControls_DragEnter);
                pic.DragOver += new DragEventHandler(allControls_DragOver);

                if (iCacherIP != 0)
                  pic.Visible = Convert.ToInt32(row["NIPLNUM"]) != iCacherIP;
                else
                  pic.Visible = true;

                Controls.Add(pic);
                lstPic.Add(pic);
              }
              nbH += Convert.ToDouble(row["NIPLDURJ"]);
            }
            lstLblH[j].Text = $"{nbH:0.##} H";
          }
        }



        TraitementBoutonSupp();

        Timer1.Enabled = Timer2.Enabled = true;
        Timer2.Enabled = lblRefresh.Visible = false;
      }
      catch (Exception ex)
      {
        MessageBox.Show(string.Format("{0}{1}\r\n\r\n{2}{3}", Resources.msg_error_planning + "\r\n",
          ex.Message, MZCtrlResources.Global_dans, MethodBase.GetCurrentMethod().Name), MZCtrlResources.Global_erreur, MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
      }
    }
    //Private Sub InitialiserPlanning(Optional iCacherIP As Long)
    //
    //Dim i As Integer
    //Dim j As Integer
    //Dim k As Integer
    //Dim nbIpJour As Integer
    //Dim inter As String
    //Dim rsCode As ADODB.Recordset
    //Dim apisTag As New ApiString
    //Dim rsPlanAuto As ADODB.Recordset
    //Dim nbH As Double                    ' nombre d'heure du technicien dans la semaine
    //
    //On Error GoTo handler
    //
    //'fonction qui donne le premier jour de la semaine (lundi)
    //DebutSemaine = Format(DateAdd("d", -(Weekday(mdSemaine) - 2), mdSemaine), "dd/mm/yyyy")
    //
    //' on recherche s'il y a des actions à l'état 'M' cette semaine pour afficher le bouton
    //' des actions à planifier manuellement (non-planifiée par la planification automatique
    //  Set rsPlanAuto = New ADODB.Recordset
    //  rsPlanAuto.Open "select tact.nactnum from tact with (nolock) inner join tdin with (nolock) on tdin.ndinnum = tact.ndinnum inner join " _
    //                & " tcli with (nolock) on tcli.nclinum = tdin.nclinum " _
    //                & " where tact.cetacod = 'P' AND tact.npernum = 10 and tcli.vsociete = APP_NAME() " _
    //                & "AND tact.DACTPLA BETWEEN DATEADD(dd,0,'" & DebutSemaine & "') AND DATEADD(dd,6,'" & DebutSemaine & "')", cnx
    //
    //  If rsPlanAuto.RecordCount > 0 And gstrNomSociete = "EMALEC" Then
    //    cmdPlanningTechVirtu.Visible = True
    //  Else
    //    cmdPlanningTechVirtu.Visible = False
    //  End If
    //  
    //  rsPlanAuto.Close
    //
    //  ' recherche du numéro de semaine
    //  lblSemaine.Caption = "§Semaine §" & ISO_WEEK(DebutSemaine) 'DatePart("ww", DebutSemaine) - 1
    //  lblAnnee.Caption = "§Année §" & DatePart("yyyy", DebutSemaine)
    //
    //  ' affichage des jours de la semaine (prise en compte des congés)
    //  For i = 0 To 6
    //    Label1(i).Caption = Format(DateAdd("d", i, DebutSemaine), "dddd d mmm")
    //    If IsFeriee(DateAdd("d", i, DebutSemaine)) Then
    //      Label1(i).BackColor = &HFF&
    //    Else
    //      Select Case i
    //        Case 5, 6
    //          Label1(i).BackColor = &H0&
    //        Case Else
    //          Label1(i).BackColor = &H8000000F
    //        End Select
    //    End If
    //  Next
    //
    //  ' on décharge les images
    //  For i = 1 To iNbrImage
    //    Unload pic(i)
    //  Next
    //
    //' placement des interventions
    //On Error Resume Next
    //k = 0
    //For j = 0 To 3 ' 0,1,2,3 = 4 techniciens sur le planning)
    //  cmdOptim(j).Caption = "§Trajet§" '"§? km§"
    //  lblH(j).Caption = "? H"
    //  nbH = 0
    //  nbIpJour = 1
    //  ' liste des interventions par techniciens pour la semaine en cours
    //  If lblTech(j).Tag <> "" Then
    //    rs.Open "api_sp_listeInterventions " & lblTech(j).Tag & ", '" & DebutSemaine & "',6,12", cnx
    //  
    //    While Not rs.EOF
    //      'on affiche seulement les 4 premiers pavés
    //      ' mais on prend tous les pavés pour le calcul du nombre d'heures
    //      
    //      ' permet d'afficher un numero de pavé qui correspond au numéro affiché sur la carte de trajet tech semaine
    //      ' on commence à 2, car le 1 correspond au domicile du tech
    //      nbIpJour = nbIpJour + 1
    //      
    //      If rs("NIPLIND") <= 4 Then
    //        k = k + 1
    //        ' création d'une image
    //        Load pic(k)
    //        
    //        ' coordonnées de l'image ( pb avec le dimanche car son weekday = 1)
    //        pic(k).Left = lJour(IIf(Weekday(rs("DIPLDATJ")) = 1, 8, Weekday(rs("DIPLDATJ"))) - 2).X1
    //        pic(k).Top = lHeure((j * 4) + rs("NIPLIND") - 1).Y1 + 0
    //
    //        ' constitution du tag d'une IP ( code, NumIP, NumSite, NumAction(null), text, duree, premierJ , tech)
    //        apisTag.Text = ""
    //        apisTag.Cat "D#"
    //        apisTag.Cat rs("NIPLNUM"):      apisTag.Cat "#"
    //        apisTag.Cat rs("NSITNUM"):      apisTag.Cat "#0#"
    //        apisTag.Cat rs("VCLINOM"):      apisTag.Cat vbCrLf
    //        apisTag.Cat rs("VSITNOM"):      apisTag.Cat vbCrLf:      apisTag.Cat "#"
    //        apisTag.Cat rs("NIPLDUR"):      apisTag.Cat "#"
    //        apisTag.Cat rs("CIPLDEB"):      apisTag.Cat "#"
    //        apisTag.Cat lblTech(j).Tag:     apisTag.Cat "#"
    //        apisTag.Cat rs("DIPLDATJ"):     apisTag.Cat "#"
    //        apisTag.Cat rs("CIPLMULT")
    //        
    //        pic(k).Tag = apisTag.Text
    //        
    //        ' pour les sites emalec spéciaux couleur : jaune
    //        If GetMozart_Soc_By_Site(rs("NSITNUM")) > 0 Then 'rs("VCLINOM") = gstrNomSociete Then
    //  '      Select Case RS("NSITNUM")
    //  '        Case 472, 560, 718, 930, 971, 1104, 2527, 3003
    //            pic(k).BackColor = &HFFFF&
    //         Else
    //            'couleur standart = bleu clair
    //            pic(k).BackColor = &HFFFFC0
    //              
    //            ' si multi-jour : bleu foncé
    //            If rs("CIPLMULT") = "O" Then pic(k).BackColor = &HFFFF00
    //            
    //            ' si c'est la nuit :  rouge
    //            If rs("CACTNUIT") = "O" Then pic(k).BackColor = &HFF&
    //            
    //            ' si c'est hors présence public :  rouge claire
    //            If rs("CACTNUIT") = "P" Then pic(k).BackColor = &HC0C0FF
    //            
    //            ' si date d'execution : orange
    //            ' si attachement (et exécution): Vert
    //            Set rsCode = New ADODB.Recordset
    //            rsCode.Open "exec api_sp_ControleDateExec_Attach " & rs("NIPLNUM"), cnx
    //            If rsCode(0) = 0 Then pic(k).BackColor = RGB(255, 193, 125)
    //            If rsCode(1) = 0 Then pic(k).BackColor = &HC0FFC0
    //            rsCode.Close
    //        
    //            ' si facture, et exec, et attach : blanc
    //            If rs("nbfact") > 0 And (pic(k).BackColor = &HC0FFC0) Then pic(k).BackColor = &HFFFFFF
    //            
    //            'si autre personne sur site au meme moment = bleu violet
    //            If pic(k).BackColor = &HFFFFC0 Then
    //              If Not VerifAide(rs("NIPLNUM"), False) Then pic(k).BackColor = &HFFC0C0
    //            End If
    //        End If
    //  
    //        ' affichage des informations dans l'image
    //        inter = IIf(rs("CACTNOK") = "O", "(*)", "") + rs("VCLINOM") & vbCrLf & rs("VSITNOM") & vbCrLf & rs("NIPLDURJ") & "h " & rs("sCODE") & " " & ReturnCodePaveBloque(rs("BACTPAVEBLOCK"))
    //        
    //        If rs("nbfact") > 0 Then inter = inter & " €"
    //        If rs("PrevMag") > 0 Then inter = inter & " #"
    //        
    //        ' ajout rdv
    //        If rs("VACTHRRDV") <> "" Then inter = inter & " RV " & rs("VACTHRRDV")
    //        
    //        'calage a droite (18 cara / ligne)
    //        Dim LinesPave() As String
    //        LinesPave() = Split(inter, vbCrLf)
    //        Select Case Len(LinesPave(UBound(LinesPave)))
    //          Case 4, 5, 6, 7
    //           inter = inter & Space((28 - Len(LinesPave(UBound(LinesPave))))) & CStr(nbIpJour)
    //          Case 8, 9, 10
    //           inter = inter & Space((25 - Len(LinesPave(UBound(LinesPave))))) & CStr(nbIpJour)
    //          Case 11, 12, 13, 14, 15, 16, 17
    //            inter = inter & Space((22 - Len(LinesPave(UBound(LinesPave))))) & CStr(nbIpJour)
    //        End Select
    //        'inter = inter & Space((28 - Len(LinesPave(UBound(LinesPave))))) & CStr(nbIpJour)
    //          
    //        pic(k).Print inter
    //              
    //        ' affichage de l"image
    //        If iCacherIP <> 0 Then
    //          If rs("NIPLNUM") = iCacherIP Then
    //            pic(k).Visible = False
    //          Else
    //            pic(k).Visible = True
    //          End If
    //        Else
    //          pic(k).Visible = True
    //        End If
    //              
    //      End If ' fin si indice <=4
    //               
    //      ' calcul du nombre d'heure de la semaine
    //      nbH = nbH + rs("NIPLDURJ")
    //      
    //      ' enregistrement suivant
    //      rs.MoveNext
    //    Wend
    //    rs.Close
    //  End If
    //  
    //  lblH(j).Caption = nbH & " H"
    //  
    //Next
    //
    //' nombre d'images chargées
    //iNbrImage = k
    //
    //TraitementBoutonSupp
    //
    //If Err <> 0 Then MsgBox "§Il y a eu une erreur lors de l'affichage du planning. Vous pouvez continuer et signaler ultérieurement cet incident au service informatique.§", vbInformation
    //
    //Timer1.Enabled = True
    //Timer2.Enabled = False:  Timer2.Enabled = True: lblRefresh.Visible = False
    //
    //Exit Sub
    //Resume
    //handler:
    //  ShowError "InitialiserPlanning dans " & Me.Name
    //End Sub

    /* OK --------------------------------------------------------------------------------------- */
    private void frmPlan_DragDrop(object sender, DragEventArgs e)
    {
      //'***************************************************************************************************
      // si c'est une nouvelle action que l'on pose alors c'est une création d'IP
      //   dans la table TPLA, création de l'enregistrement
      //   insert into TPLA set DPLADAT = datepla, NPLAIND = indice, TACTNUM = source.tag
      //   dans la table TACT, modification du technicien affecté et renseignement du numero IP
      //   update TACT set TPERNUM = lblTech(itech).Tag where NACTNUM = source.tag
      // sinon c'est une IP que l'on déplace
      //   dans la table TPLA, modification du champs indice et dateplanifié
      //   update TPLA set DPLADAT = datepla, NPLAIND = indice where NPLANUM = source.tag
      //   
      //   dans la table TACT, modification du technicien affecté
      //   update TACT set TPERNUM = lblTech(itech).Tag where NACTNUM = source.tag
      // fin si
      try
      {
        int Top, Left;
        int indice = 0;
        string DatePla = "";
        int iTech = 0;
        bool Out = true;
        int iTechCourant = 0;

        // Pas de move donc pas de Drop
        if (e.Effect != DragDropEffects.All) return;

        PictureBox picSource = (PictureBox)e.Data.GetData(typeof(PictureBox));

        Point clientPoint = this.PointToClient(new Point(e.X, e.Y));

        //  Conservation de la position initiale
        Left = picSource.Left;
        Top = picSource.Top;

        //  Recherche des info dans le tag de l'image
        string[] myTab = (picSource.Tag as picTag).sTag.Split('#');

        miNumIp = Convert.ToInt32(myTab[1]);

        //  Test pour empecher de sortir du planning
        if (clientPoint.X > lstJours[7].Left) return;
        if (clientPoint.X < lstJours[0].Left) return;
        if (clientPoint.Y > lstHeures[16].Top) return;
        if (clientPoint.Y < lstHeures[0].Top) return;

        //  Définition du technicien et de l'indice ou l'on pose
        for (int h = 15; h >= 0; h--)
        {
          if (clientPoint.Y > lstHeures[h].Top)
          {
            // determiner le tech et l'indice
            iTech = h / 4;
            if (lstLblTech[iTech].Tag.ToString() == "")
              break;
            indice = (h + 1) % 4 == 0 ? 4 : (h + 1) % 4;
            iTechCourant = (int)lstLblTech[iTech].Tag;
            picSource.Top = lstHeures[h].Top;
            Out = false;
            break;
          }
        }

        //  On sort si il ny a pas de technicien sur le drop
        if (Out)
          return;

        //  Définition du jour ou on pose
        for (int j = 7; j >= 0; j--)
        {
          if (clientPoint.X > lstJours[j].Left)
          {
            DatePla = mdSemaine.AddDays(j).ToShortDateString();
            picSource.Left = lstJours[j].Left;
            break;
          }
        }

        // test sur la date de sortie du technicien : on ne peut pas poser apres la date de sortie
        // date ou on pose : datepla
        // tech sur qui on pose : lblTech(iTech).Tag
        if (!UtilsPlan.TestTechOK(iTechCourant, Convert.ToDateTime(DatePla)))
        {
          MessageBox.Show(Resources.msg_planif_impossible_tech_date_sortie, Program.AppTitle, MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
          picSource.Left = Left;
          picSource.Top = Top;
          return;
        }

        //  test sur les 1/2 journées interdites des sites
        if (!UtilsPlan.DemiJournee(Convert.ToInt32(myTab[2]), indice, DatePla))
        {
          if (MessageBox.Show(Resources.msg_planif_impossible_tech_demi_journee_interdite, Program.AppTitle, MessageBoxButtons.YesNo, MessageBoxIcon.Exclamation) == DialogResult.No)
          {
            picSource.Left = Left;
            picSource.Top = Top;
            return;
          }
        }

        //  Vérifications (déplacement d'une IP avec information au client, aide sur intervention, IP Emalec, action bloque)
        if (!UtilsPlan.Verifications(miNumIp, Convert.ToInt32(myTab[2]), iTechCourant, Convert.ToInt32(myTab[3]), myTab[8] == DatePla, DatePla))
        {
          picSource.Left = Left;
          picSource.Top = Top;
          return;
        }

        AfficheInfoSite(Convert.ToInt32(myTab[2]));

        if ((int)ModuleData.ExecuteScalarInt($"SELECT COUNT(*) FROM TACT WITH (NOLOCK), TIPL WITH (NOLOCK) WHERE TACT.NIPLNUM = TIPL.NIPLNUM AND TACT.NPERNUM = {iTechCourant} " +
                                             $"AND DIPLDATJ = '{DatePla}' AND NIPLIND = {indice}") > 0)
        {
          MessageBox.Show(Resources.txt_planning_change_refresh, Program.AppTitle, MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
          picSource.Left = Left;
          picSource.Top = Top;
          InitialiserPlanning();
          return;
        }

        try
        {
          if (iTechCourant.ToString() != myTab[7] && myTab[0] == "D" && myTab[9] == "O" && myTab[6] == "O")
          {
            // déplacement du premier jour d'une IP multi-jour d'une ip multi-jour
            if (MessageBox.Show(Resources.msg_attn_deplacement_1er_jour_IP + "\r\n" + Resources.msg_IP_deplacee_ok, Program.AppTitle,
                MessageBoxButtons.YesNo, MessageBoxIcon.Question, MessageBoxDefaultButton.Button2) == DialogResult.Yes)
            {
              using (SqlCommand cmd = new SqlCommand("api_sp_CreationIP", MozartDatabase.cnxMozart))
              {
                cmd.CommandType = CommandType.StoredProcedure;
                SqlCommandBuilder.DeriveParameters(cmd);

                cmd.Parameters["@iIP"].Value = miNumIp;
                cmd.Parameters["@iAction"].Value = myTab[3];
                cmd.Parameters["@pDate"].Value = DatePla;
                cmd.Parameters["@indice"].Value = indice;
                cmd.Parameters["@iTech"].Value = iTechCourant;
                cmd.Parameters["@iDuree"].Value = myTab[5];
                cmd.Parameters["@AncDate"].Value = "01/01/1900";
                cmd.ExecuteNonQuery();
              }

              UtilsPlan.AddLogIPL(miNumIp, "M");
            }
          }
          else if (iTechCourant.ToString() != myTab[7] && myTab[0] == "D" && myTab[9] == "O" && myTab[6] == "N")
          {
            // déplacement d'un jour d'une multi-jour
            // si on change de tech pour une multi-jour : création d'une action
            if ((int)ModuleData.ExecuteScalarInt($"SELECT COUNT(*) FROM TACT WITH (NOLOCK) WHERE NIPLNUM = {myTab[1]}") == 1)
            {
              using (SqlCommand cmd = new SqlCommand("api_sp_DeplacementIP", MozartDatabase.cnxMozart))
              {
                cmd.CommandType = CommandType.StoredProcedure;
                SqlCommandBuilder.DeriveParameters(cmd);

                cmd.Parameters["@iIP"].Value = miNumIp;
                cmd.Parameters["@pDate"].Value = DatePla;
                cmd.Parameters["@indice"].Value = indice;
                cmd.Parameters["@iTech"].Value = iTechCourant;
                cmd.Parameters["@AncDate"].Value = myTab[8];
                cmd.ExecuteNonQuery();
              }
            }
            else
              MessageBox.Show(Resources.msg_deplacer_premier_jour_IP, Program.AppTitle, MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
          }
          else
          {
            using (SqlCommand cmd = new SqlCommand("api_sp_CreationIP", MozartDatabase.cnxMozart))
            {
              cmd.CommandType = CommandType.StoredProcedure;
              SqlCommandBuilder.DeriveParameters(cmd);

              cmd.Parameters["@iIP"].Value = miNumIp;
              cmd.Parameters["@iAction"].Value = myTab[3];
              cmd.Parameters["@pDate"].Value = DatePla;
              cmd.Parameters["@indice"].Value = indice;
              cmd.Parameters["@iTech"].Value = iTechCourant;
              cmd.Parameters["@iDuree"].Value = myTab[5];
              cmd.Parameters["@AncDate"].Value = myTab[8];
              cmd.ExecuteNonQuery();
            }
          }
        }
        catch (Exception ex)
        {
          if (ex.HResult != -2146232060)
            MZUtils.displayError(MethodBase.GetCurrentMethod().Name, ex);
        }

        if (myTab[0] == "D")
        {
          // si on ne change pas de jour, il ne faut pas réinitialiser
          if (DatePla != myTab[8])
          {
            ModuleData.ExecuteNonQuery($"UPDATE TACT set CACTINFOMAG ='N', VACTQUIINFO ='', VACTINFOQUI ='', DACTQUANDINFO = Null where NIPLNUM = {myTab[1]}");
            UtilsPlan.AddLogIPL(miNumIp, "M");
          }
        }
        else
          UtilsPlan.AddLogIPL(miNumIp, "C");

        RechercheInfoCdeFo(miNumIp);

        // si c'est la pic(0), on la cache car on va réinitialiser le planning
        // et l'IP serait affichée deux fois
        if (picSource.Name == "pic0")
          pic0.Visible = false;

        if (picSource.Parent.Name == "frmPlanTech")
          (picSource.Parent as frmPlanTech).frmPlanTech_Load(null, null);

        InitialiserPlanning();   // réinitialisation de l'affichage
      }
      catch (Exception ex)
      {
        MZUtils.displayError(MethodBase.GetCurrentMethod().Name, ex);
      }

    }
    //Private Sub Form_DragDrop(Source As Control, X As Single, Y As Single)
    //'***************************************************************************************************
    //' si c'est une nouvelle action que l'on pose alors c'est une création d'IP
    //'    ' dans la table TPLA, création de l'enregistrement
    //'    ' insert into TPLA set DPLADAT = datepla, NPLAIND = indice, TACTNUM = source.tag
    //'    ' dans la table TACT, modification du technicien affecté et renseignement du numero IP
    //'    ' update TACT set TPERNUM = lblTech(itech).Tag where NACTNUM = source.tag
    //'
    //' sinon c'est une IP que l'on déplace
    //'  ' dans la table TPLA, modification du champs indice et dateplanifié
    //'  ' update TPLA set DPLADAT = datepla, NPLAIND = indice where NPLANUM = source.tag
    //'
    //'  ' dans la table TACT, modification du technicien affecté
    //'  ' update TACT set TPERNUM = lblTech(itech).Tag where NACTNUM = source.tag
    //' fin si
    //'***************************************************************************************************
    //
    //Dim ado_cmd As New ADODB.Command
    //Dim j As Integer
    //Dim indice As Integer
    //Dim iTech As Integer
    //Dim datepla As String
    //Dim MyTab
    //Dim Out As Boolean
    //Dim h As Integer
    //Dim rsNbAction As ADODB.Recordset
    //
    //Dim Top, Left
    //  
    //  ' conservation de la position initiale
    //  Top = Source.Top
    //  Left = Source.Left
    //  
    //  ' initialisation
    //  Out = True
    //
    //  ' recherche des infos dans le tag de l'image
    //  MyTab = Split(Source.Tag, "#")
    //    
    //  ' test pour empecher de sortir du planning
    //  If X > lJour(7).X1 Then Exit Sub
    //  If X < lJour(0).X1 Then Exit Sub
    //  If Y > lHeure(16).Y1 Then Exit Sub
    //  If Y < lHeure(0).Y1 Then Exit Sub
    //  
    //  ' définition du technicien et de l'indice ou l'on pose
    //  For h = 15 To 0 Step -1
    //    If Y > lHeure(h).Y1 Then
    //      ' determiner le tech et l'indice
    //      iTech = h \ 4
    //      If lblTech(iTech).Tag = "" Then Exit For
    //      indice = IIf(((h + 1) Mod 4) = 0, 4, (h + 1) Mod 4)
    //      Source.Top = lHeure(h).Y1
    //      Out = False
    //      Exit For
    //    End If
    //  Next
    //  
    //  ' on sort si il ny a pas de technicien sur le drop
    //  If Out Then Exit Sub
    //  
    //  ' definition du jour ou on pose
    //  For j = 6 To 0 Step -1
    //  
    //'  For j = 5 To 0 Step -1
    //    If X > lJour(j).X1 Then
    //      datepla = DateAdd("d", j, DebutSemaine)
    //      Source.Left = lJour(j).X1
    //      Exit For
    //    End If
    //  Next
    //
    //  ' test sur la date de sortie du technicien : on ne peut pas poser apres la date de sortie
    //  ' date ou on pose : datepla
    //  ' tech sur qui on pose : lblTech(iTech).Tag
    //  If Not TestTechOK(lblTech(iTech).Tag, datepla) Then
    //    MsgBox "§Impossible de planifier ce technicien à cette date(voir date de sortie de l'entreprise)§", vbInformation
    //    Source.Left = Left
    //    Source.Top = Top
    //    Exit Sub
    //  End If
    //
    //  ' test sur les 1/2 journées interdites des sites
    //  If Not DemiJournee(MyTab(2), indice, datepla) Then
    //    If MsgBox("§Demi-journée interdite du site, voulez-vous planifier?§", vbYesNo) = vbNo Then
    //      Source.Left = Left
    //      Source.Top = Top
    //      Exit Sub
    //    End If
    //  End If
    //   
    //  ' Vérifications (déplacement d'une IP avec Information au client, aide sur intervention, IP Emalec, action bloque)
    //  If Not Verifications(MyTab(1), MyTab(2), lblTech(iTech).Tag, MyTab(3), IIf(MyTab(8) = datepla, True, False), datepla) Then
    //    Source.Left = Left
    //    Source.Top = Top
    //    Exit Sub
    //  End If
    //  
    //  AfficheInfoSite (MyTab(2))
    //  
    //  Dim sSQL As String
    //  Dim vRs As ADODB.Recordset
    //  sSQL = "SELECT COUNT(*) FROM TACT WITH (NOLOCK), TIPL WITH (NOLOCK) WHERE TACT.NIPLNUM = TIPL.NIPLNUM AND TACT.NPERNUM = " & lblTech(iTech).Tag & " AND DIPLDATJ = '" & datepla & "' AND NIPLIND = " & indice
    //  Set vRs = cnx.Execute(sSQL)
    //  If vRs(0) > 0 Then
    //    MsgBox "§Le plannning a changé. Cette plage n'est plus disponible. Veuillez raffraichir le planning et recommencer§", vbExclamation
    //    Source.Left = Left
    //    Source.Top = Top
    //    Call InitialiserPlanning
    //    Exit Sub
    //  End If
    //  
    //  If lblTech(iTech).Tag <> MyTab(7) And MyTab(0) = "D" And MyTab(9) = "O" And MyTab(6) = "O" Then
    //    ' déplacement du premier jour d'une IP multi-jour d'une ip multi-jour
    //    Select Case MsgBox("§Attention, vous déplacez le premier jour d'une IP multi-jour.§" & vbCrLf & "§Toute l'IP sera déplacée. OK ?§", vbYesNo + vbQuestion + vbDefaultButton2)
    //      Case vbYes
    //         On Error Resume Next
    //        
    //        ' création d'une commande
    //        Set ado_cmd.ActiveConnection = cnx
    //        
    //        ' passage du nom de la procédure stockée
    //        ado_cmd.CommandText = "api_sp_CreationIP"
    //        ado_cmd.CommandType = adCmdStoredProc
    //        
    //        ' passage des paramètres
    //        ado_cmd.Parameters.Refresh
    //         
    //         ' liste des paramètres
    //        ado_cmd.Parameters("@iIP").value = MyTab(1)
    //        ado_cmd.Parameters("@iAction").value = MyTab(3)
    //        ado_cmd.Parameters("@pDate").value = datepla
    //        ado_cmd.Parameters("@indice").value = indice
    //        ado_cmd.Parameters("@iTech").value = lblTech(iTech).Tag
    //        ado_cmd.Parameters("@iDuree").value = MyTab(5)
    //        ado_cmd.Parameters("@AncDate").value = "01/01/1900"
    //        
    //        ' exécuter la commande.
    //        ado_cmd.Execute
    //        
    //        If Err.Number <> -2147217873 And Err.Number <> 0 Then
    //          MsgBox "§Erreur : §" & Err.Description
    //        End If
    //        
    //        AddLogIPL MyTab(1), "M"
    //        
    //        Set ado_cmd = Nothing
    //      Case vbNo
    //    End Select
    //
    //  ' déplacement d'un jour d'une multi-jour
    //  ' si on change de tech pour une multi-jour : création d'une action
    //  ElseIf lblTech(iTech).Tag <> MyTab(7) And MyTab(0) = "D" And MyTab(9) = "O" And MyTab(6) = "N" Then
    //      
    //      Set rsNbAction = New ADODB.Recordset
    //      rsNbAction.Open "SELECT COUNT(*) FROM TACT WITH (NOLOCK) WHERE NIPLNUM = " & MyTab(1), cnx
    //      If rsNbAction(0) = 1 Then
    //       
    //       ' création d'une commande
    //       Set ado_cmd.ActiveConnection = cnx
    //       
    //       ' passage du nom de la procédure stockée
    //       ado_cmd.CommandText = "api_sp_DeplacementIP"
    //       ado_cmd.CommandType = adCmdStoredProc
    //       
    //       ' passage des paramètres
    //       ado_cmd.Parameters.Refresh
    //        
    //        ' liste des paramètres
    //       ado_cmd.Parameters("@iIP").value = MyTab(1)
    //       ado_cmd.Parameters("@pDate").value = datepla
    //       ado_cmd.Parameters("@indice").value = indice
    //       ado_cmd.Parameters("@iTech").value = lblTech(iTech).Tag
    //       ado_cmd.Parameters("@AncDate").value = MyTab(8)
    //       
    //       ' exécuter la commande.
    //       ado_cmd.Execute
    //       
    //       If Err.Number <> -2147217873 And Err.Number <> 0 Then
    //         MsgBox "§Erreur : §" & Err.Description
    //       End If
    //       
    //       AddLogIPL MyTab(1), "M"
    //      
    //       Set ado_cmd = Nothing
    //    Else
    //      MsgBox "§Il est obligatoire de déplacer le premier jour de cette multi-jour car elle est composée de plusieurs actions!§", vbExclamation
    //    End If
    //    
    //    rsNbAction.Close
    //    Set rsNbAction = Nothing
    //             
    //   Else
    //      
    //    On Error Resume Next
    //    
    //    ' création d'une commande
    //    Set ado_cmd.ActiveConnection = cnx
    //    
    //    ' passage du nom de la procédure stockée
    //    ado_cmd.CommandText = "api_sp_CreationIP"
    //    ado_cmd.CommandType = adCmdStoredProc
    //    
    //    ' passage des paramètres
    //    ado_cmd.Parameters.Refresh
    //     
    //     ' liste des paramètres
    //    ado_cmd.Parameters("@iIP").value = MyTab(1)
    //    ado_cmd.Parameters("@iAction").value = MyTab(3)
    //    ado_cmd.Parameters("@pDate").value = datepla
    //    ado_cmd.Parameters("@indice").value = indice
    //    ado_cmd.Parameters("@iTech").value = lblTech(iTech).Tag
    //    ado_cmd.Parameters("@iDuree").value = MyTab(5)
    //    ado_cmd.Parameters("@AncDate").value = MyTab(8)
    //    
    //    ' exécuter la commande.
    //    ado_cmd.Execute
    //    
    //    If Err.Number <> -2147217873 And Err.Number <> 0 Then
    //      MsgBox "§Erreur : §" & Err.Description
    //    End If
    //    
    //    If MyTab(0) = "D" Then
    //      ' si on ne change pas de jour, il ne faut pas réinitialiser
    //      If datepla <> MyTab(8) Then
    //        cnx.Execute "update TACT set CACTINFOMAG='N', VACTQUIINFO='', VACTINFOQUI='', DACTQUANDINFO = Null where NIPLNUM = " & MyTab(1)
    //        AddLogIPL MyTab(1), "M"
    //      End If
    //    Else
    //      AddLogIPL ado_cmd.Parameters(0), "C"
    //    End If
    //    
    //    Set ado_cmd = Nothing
    //    
    //  End If
    //  
    //  RechercheInfoCdeFo (MyTab(1))
    //  
    //  ' si c'est la pic(0), on la cache car on va réinitialiser le planning
    //  ' et l'IP serait affichée deux fois
    //  If Source.Index = 0 Then Source.Visible = False
    //  
    //  If Source.Parent.Name = "frmPlanTechVirtuel" Then
    //    If Err.Number = 0 Then
    //      ' voir api_sp_creationIp pour la mise à jour de l'etat de l'action (passage à P)
    //      
    //      ' on update tous les ipl pour comblé le "trou" de celui qu'on vien de bouger
    //      cnx.Execute "UPDATE TIPL SET NIPLIND = NIPLIND -1 " _
    //                & " WHERE NIPLNUM IN(SELECT DISTINCT NIPLNUM FROM TACT WHERE NPERNUM = 10 " _
    //                & " AND DACTPLA = '" & MyTab(8) & "') " _
    //                & " AND NIPLIND > " & MyTab(10)
    //      Unload frmPlanTechVirtuel
    //    End If
    //  End If
    //  
    //  If Source.Parent.Name = "frmPlanTech" Then
    //    If Err.Number = 0 Then
    //      Call frmPlanTech.Form_Load
    //    End If
    //  End If
    //
    //  ' réinitialisation de l'affichage
    //  Call InitialiserPlanning
    //
    //End Sub

    /* OK --------------------------------------------------------------------------------------- */
    private void allControls_DragOver(object sender, DragEventArgs e)
    {
      e.Effect = DragDropEffects.All;
    }

    /* OK --------------------------------------------------------------------------------------- */
    private void mnuBlocagePave_Click(object sender, EventArgs e)
    {
      if (miNumIp == 0) return;

      UtilsPlan.BlocagePave(miNumIp, mnuBlocagePave.Tag.ToString());

      // rafraichissement planning
      InitialiserPlanning();
    }
    //Private Sub mnuBlocagePave_Click()
    //  
    //  If iNumIp = 0 Then Exit Sub
    //    
    //  ' mise a jour de toutes les actions du pavé
    //  ' blocage si pas de blocage et  déblocage si blocage
    //  If mnuBlocagePave.Tag = "D" Then cnx.Execute "update TACTCOMP set BACTPAVEBLOCK=1 from TACT inner join TACTCOMP C on c.nactnum=tact.nactnum where NIPLNUM=" & iNumIp
    //  If mnuBlocagePave.Tag = "B" Then cnx.Execute "update TACTCOMP set BACTPAVEBLOCK=0 from TACT inner join TACTCOMP C on c.nactnum=tact.nactnum where NIPLNUM=" & iNumIp
    //  
    //  ' rafraichissement planning
    //  Call InitialiserPlanning
    //
    //End Sub

    /* OK --------------------------------------------------------------------------------------- */
    private void mnuEditionOTJour_Click(object sender, EventArgs e)
    {
      UtilsPlan.mnuEditionOTJour_Click(miNumTech, ddatejour.ToShortDateString(), miNumIp);
    }

    //private void mnuFaxerOT_Click(object sender, EventArgs e)
    //{
    //  string[] myTab = (mnuAffichage.Tag as picTag).sTag.Split('#');
    //  UtilsPlan.mnuFaxerOT_Click(ProgressBar1, miNumTech, myTab, mstrTypeEdition, lstPic, bFax);
    //}

    private void pic_DragDrop(object sender, DragEventArgs e)
    {
      try
      {
        int Top, Left;

        PictureBox picDest = sender as PictureBox;
        PictureBox picSource = (PictureBox)e.Data.GetData(typeof(PictureBox));

        Point clientPoint = this.PointToClient(new Point(e.X, e.Y));

        //  Conservation de la position initiale
        Left = picSource.Left;
        Top = picSource.Top;

        // On veut poser sur une IP existante. on recherche les infos dans les tags
        string[] myTabDest = (picDest.Tag as picTag).sTag.Split('#');
        string[] myTabSource = (picSource.Tag as picTag).sTag.Split('#');

        // Si on click et que l'on relache, on pose sur elle même donc erreur
        if (myTabDest[1] == myTabSource[1]) return;

        // On ne peut pas ajouter une IP multi-jour
        if (myTabSource[9] == "O")
        {
          MessageBox.Show(Resources.msg_impossible_ajout_IP_multijour, Program.AppTitle, MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
          return;
        }

        // Les sites doivent être identiques
        if (myTabDest[2] != myTabSource[2])
        {
          MessageBox.Show(Resources.msg_sites_differents, Program.AppTitle, MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
          return;
        }

        // Les code analytique doivent être identiques
        if (!UtilsPlan.CompteOK(Convert.ToInt32(myTabDest[1]), Convert.ToInt32(myTabSource[1]), Convert.ToInt32(myTabSource[3])))
        {
          MessageBox.Show(Resources.msg_comptes_ana_differents, Program.AppTitle, MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
          return;
        }

        // On fait un contrôle sur les durées des actions
        if (Convert.ToDouble(myTabDest[5]) + Convert.ToDouble(myTabSource[5]) > 10 && myTabDest[9] == "N")
        {
          if (MessageBox.Show(Resources.msg_creation_inter_multijour + "\r\n" + Resources.msg_EtesVousDaccord, Program.AppTitle,
              MessageBoxButtons.YesNo, MessageBoxIcon.Question, MessageBoxDefaultButton.Button2) == DialogResult.No)
            return;
        }

        //  Vérifications (déplacement d'une IP avec information au client, aide sur intervention, IP Emalec, action bloque)
        if (!UtilsPlan.Verifications(Convert.ToInt32(myTabSource[1]), Convert.ToInt32(myTabSource[2]), Convert.ToInt32(myTabDest[7]),
                Convert.ToInt32(myTabSource[3]), myTabDest[8] == myTabSource[8], myTabDest[8]))
        {
          picSource.Left = Left;
          picSource.Top = Top;
          return;
        }

        // cas de planification d'une nouvelle action
        if (myTabSource[0] == "N")
        {
          // -  on fait un update dans TACT avec le nouveau numéro d'action
          // -  on fait un update dans TIPL avec la somme des durées et création jours supp si nécessaire
          ModuleData.ExecuteNonQuery($"api_sp_ModificationIP_Action {myTabDest[1]}, {myTabSource[3]}, {myTabDest[7]}");
          UtilsPlan.AddLogIPL(Convert.ToInt32(myTabDest[1]), "C");
        }
        else
        {
          //cas de déplacement d'une intervention (avec plusieurs actions)
          // -  on fait un update dans TACT du num IP et du technicien
          // -  on fait un update dans TIPL avec la somme des durées et création jours supp si nécessaire
          ModuleData.ExecuteNonQuery($"api_sp_ModificationIP_IP {myTabDest[1]}, {myTabSource[1]}, {myTabDest[7]}");
          UtilsPlan.AddLogIPL(Convert.ToInt32(myTabDest[1]), "M");

          if (myTabDest[9] != myTabSource[8])
            RechercheInfoCdeFo(Convert.ToInt32(myTabDest[1]));
        }

        if (pic0.Visible)
          pic0.Visible = false;

        if (picSource.Parent.Name == "frmPlanTechVirtuel")
        {
          ModuleData.ExecuteNonQuery($"UPDATE TIPL SET NIPLIND = NIPLIND -1 WHERE NIPLNUM IN(SELECT DISTINCT NIPLNUM FROM TACT WHERE NPERNUM = 10 AND DACTPLA = '{myTabSource[8]}') AND NIPLIND > {myTabSource[10]}");
          (picSource.Parent as frmPlanTechVirtuel).cmdFermer_Click(null, null);
        }

        if (picSource.Parent.Name == "frmPlanTech")
          (picSource.Parent as frmPlanTech).frmPlanTech_Load(null, null);

        InitialiserPlanning();   // réinitialisation de l'affichage
      }
      catch (Exception ex)
      {
        MZUtils.displayError(MethodBase.GetCurrentMethod().Name, ex);
      }
    }
    //Private Sub pic_DragDrop(Index As Integer, Source As Control, X As Single, Y As Single)
    // 
    //Dim MyTabPic
    //Dim MyTabSource
    //Dim strSQL As String
    //
    //  ' on veut poser sur une IP existante. on recherche les infos dans les tags
    //  MyTabPic = Split(pic(Index).Tag, "#")
    //  MyTabSource = Split(Source.Tag, "#")
    //   
    //   
    //  ' si on click et que l'on relache, on pose sur elle même donc erreur
    //  If MyTabPic(1) = MyTabSource(1) Then Exit Sub
    //  
    //  ' on ne peut pas ajouter une IP multi-jour
    //  If MyTabSource(9) = "O" Then
    //    MsgBox "§On ne peut pas ajouter une intervention multi-jour§"
    //    Exit Sub
    //  End If
    //  
    //  ' les sites doivent être identiques
    //  If MyTabPic(2) <> MyTabSource(2) Then
    //    MsgBox "§Les sites sont différents§", vbInformation
    //    Exit Sub
    //  End If
    //  
    //  ' FG le 29/01
    //  ' Les code analytique doivent être identique
    //  If Not CompteOK(MyTabPic(1), MyTabSource(1), MyTabSource(3)) Then
    //    MsgBox "§Les comptes analytiques sont différents§", vbInformation
    //    Exit Sub
    //  End If
    //  
    //  ' on fait un contrôle sur les durées des actions
    //  If (CDbl(MyTabPic(5)) + CDbl(MyTabSource(5))) > 10 And MyTabPic(9) = "N" Then
    //    Select Case MsgBox("§Vous allez créer une Intervention sur plusieurs jours§" & vbCrLf & "§Etes vous d'accord ?§", vbYesNo + vbQuestion + vbDefaultButton2)
    //       Case vbYes
    //         ' on passe à la suite
    //       Case vbNo
    //         Exit Sub
    //     End Select
    //  End If
    // 
    //Dim Top, Left
    //  
    //  ' conservation de la position initiale
    //  Top = Source.Top
    //  Left = Source.Left
    //  
    //  ' Vérifications (déplacement d'une IP avec information au client, aide sur intervention, IP Emalec)
    //  If Not Verifications(MyTabSource(1), MyTabSource(2), MyTabPic(7), MyTabSource(3), IIf(MyTabSource(8) = MyTabPic(8), True, False), MyTabPic(8)) Then
    //    Source.Left = Left
    //    Source.Top = Top
    //    Exit Sub
    //  End If
    //  
    //  ' cas de planification d'une nouvelle action
    //  If MyTabSource(0) = "N" Then
    //      '  -  on fait un update dans TACT avec le nouveau numéro d'action
    //      '  -  on fait un update dans TIPL avec la somme des durées et création jours supp si nécessaire
    //      '>>> update TACT set NIPLMUN = pic(index).tag and NunAction=Source.tag
    //      
    //     ' modification de l'IP (NumIP,  action, TechDest)
    //      strSQL = MyTabPic(1) & "," & MyTabSource(3) & "," & MyTabPic(7)
    //      rs.Open "api_sp_ModificationIP_Action " & strSQL, cnx
    //      AddLogIPL MyTabPic(1), "C"
    //  Else
    //  ' cas de déplacement d'une intervention ( avec plusieurs actions )
    //        '  -  on fait un update dans TACT du num IP et du technicien
    //        '  -  on fait un update dans TIPL avec la somme des durées et création jours supp si nécessaire
    //    
    //        ' si on change pas de date, on ne reinitialise pas l'info magasin
    //'        If MyTabPic(8) <> MyTabSource(8) Then
    //'          cnx.Execute "update TACT set CACTINFOMAG='N', VACTQUIINFO='', VACTINFOQUI='', DACTQUANDINFO = Null where NIPLNUM = " & MyTabSource(1)
    //'        End If
    //        ' modification de l'IP (NumIPpic,  NumIPsource, TechDest)
    //        strSQL = MyTabPic(1) & "," & MyTabSource(1) & "," & MyTabPic(7)
    //        rs.Open "api_sp_ModificationIP_IP " & strSQL, cnx
    //        
    //        AddLogIPL MyTabPic(1), "M"
    //        
    //        ' on affiche les infos de sortie de stock ou commande fournisseur
    //        ' uniquement si on change de date
    //        If MyTabPic(8) <> MyTabSource(8) Then
    //          RechercheInfoCdeFo (MyTabPic(1))
    //        End If
    //  End If
    //  
    //  ' si c'est la pic(0), on la cache car on va réinitialiser le planning
    //  ' et l'IP serait affichée deux fois
    //  If Source.Index = 0 Then Source.Visible = False
    //  
    //  On Error Resume Next
    //
    //  If Source.Parent.Name = "frmPlanTechVirtuel" Then
    //    If Err.Number = 0 Then
    //      cnx.Execute "UPDATE TACT SET CETACOD = 'P' WHERE NIPLNUM = " & MyTabPic(1) & " AND CETACOD = 'M'"
    //      
    //      ' on update tous les ipl pour comblé le "trou" de celui qu'on vient de bouger
    //      cnx.Execute "UPDATE TIPL SET NIPLIND = NIPLIND -1 " _
    //                & " WHERE NIPLNUM IN(SELECT DISTINCT NIPLNUM FROM TACT WHERE NPERNUM = 10 " _
    //                & " AND DACTPLA = '" & MyTabSource(8) & "') " _
    //                & " AND NIPLIND > " & MyTabSource(10)
    //                
    //      Unload frmPlanTechVirtuel
    //    End If
    //  End If
    //  
    //  If Source.Parent.Name = "frmPlanTech" Then
    //    If Err.Number = 0 Then
    //      Call frmPlanTech.Form_Load
    //    End If
    //  End If
    //
    //  ' initialisation de l'affichage
    //  Call InitialiserPlanning
    //
    //End Sub

    /* OK --------------------------------------------------------------------------------------- */
    private void cmdAllPrecSuiv_DragDrop(object sender, DragEventArgs e)
    {
      // Passage au technicien précédent
      //
      // si création : - faire passer le numéro de l'action a planifier
      //                - afficher l'image a l'ouverture
      //
      // si déplacement d'une IP : - faire passer le numéro de l'IP
      //                           - afficher l'image a l'ouverture

      int Top, Left;
      PictureBox picSource = (PictureBox)e.Data.GetData(typeof(PictureBox));

      //  Conservation de la position initiale
      Left = picSource.Left;
      Top = picSource.Top;

      //  Recherche des info dans le tag de l'image
      string[] myTab = (picSource.Tag as picTag).sTag.Split('#');
      miNumAction = Convert.ToInt32(myTab[3]);

      //   Vérifications (déplacement d'une IP avec information au client, aide sur intervention, IP Emalec, action bloque)
      if (!UtilsPlan.Verifications(Convert.ToInt32(myTab[1]), Convert.ToInt32(myTab[2])))
      {
        picSource.Left = Left;
        picSource.Top = Top;
        return;
      }

      //  Si on est en création d'une IP, on passe simplement à la semaine suivante 
      if (myTab[0] != "N")
      {
        // on pose l'IP a modifier dans la pic(0)
        pic0.Location = pic0Locaction;
        (pic0.Tag as picTag).sTag = (picSource.Tag as picTag).sTag;

        (pic0.Tag as picTag).sInter = myTab[4] + myTab[5] + "heures";
        pic0.Visible = true;
        pic0.Refresh();
      }

      string sens = (sender as Button).Tag.ToString();
      if (sens.StartsWith("TECH"))
        GetTechniciens(false, sens);
      else
        mdSemaine = mdSemaine.AddDays(sens.Contains("PREC") ? -7 : 7);

      InitialiserPlanning(Convert.ToInt32(myTab[1]));
    }

    /* OK -> cmdAllPrecSuiv_DragDrop --------------------------------------------------------------------------------------- */
    //Private Sub cmdPrec_DragDrop(Source As Control, X As Single, Y As Single)
    //'**************************************************************************************************
    //' passage a la semaine précédente
    //'
    //' si création : - faire passer le numéro de l'action a planifier
    //'                - afficher l'image a l'ouverture
    //'
    //' si déplacement d'une IP : - faire passer le numéro de l'IP
    //'                           - afficher l'image a l'ouverture
    //'**************************************************************************************************
    //  
    // Dim MyTabSource
    // Dim Top, Left
    // 
    //  ' recherche des infos
    //  MyTabSource = Split(Source.Tag, "#")
    //
    //  ' conservation de la position initiale
    //  Top = Source.Top
    //  Left = Source.Left
    //  
    //  ' Vérifications (déplacement d'une IP avec information au client, aide sur intervention, IP Emalec)
    //  If Not Verifications(MyTabSource(1), MyTabSource(2)) Then
    //    Source.Left = Left
    //    Source.Top = Top
    //    Exit Sub
    //  End If
    //
    //  ' si on est en création d'une IP, on passe simplement à la semaine précédente sinon
    //  If MyTabSource(0) <> "N" Then
    //    ' passage a la semaine précédente
    //    pic(0).Left = 240
    //    pic(0).Top = 2640
    //    pic(0).Tag = Source.Tag
    //    pic(0).Cls
    //    pic(0).Print MyTabSource(4) & MyTabSource(5) & "heures"
    //    pic(0).Visible = True
    //  End If
    //  
    //  Me.mdSemaine = DateAdd("d", -7, DebutSemaine)
    //  Call InitialiserPlanning
    //
    //End Sub

    /* OK -> cmdAllPrecSuiv_DragDrop --------------------------------------------------------------------------------------- */
    //Private Sub cmdSuiv_DragDrop(Source As Control, X As Single, Y As Single)
    //'**************************************************************************************************
    //' passage a la semaine suivante
    //'
    //' si création : - faire passer le numéro de l'action a planifier
    //'                - afficher l'image a l'ouverture
    //'
    //' si déplacement d'une IP : - faire passer le numéro de l'IP
    //'                           - afficher l'image a l'ouverture
    //'**************************************************************************************************
    //
    //Dim MyTabSource
    //Dim Top, Left
    //  
    //  ' conservation de la position initiale
    //  Top = Source.Top
    //  Left = Source.Left
    //  
    //  ' recherche des infos
    //  MyTabSource = Split(Source.Tag, "#")
    //  
    //  ' Vérifications (déplacement d'une IP avec information au client, aide sur intervention, IP Emalec)
    //  If Not Verifications(MyTabSource(1), MyTabSource(2)) Then
    //    Source.Left = Left
    //    Source.Top = Top
    //    Exit Sub
    //  End If
    // 
    //  ' si on est en création d'une IP, on passe simplement à la semaine suivante sinon
    //  If MyTabSource(0) <> "N" Then
    //    ' on pose l'IP a modifier dans la pic(0)
    //    pic(0).Left = 240
    //    pic(0).Top = 2640
    //    pic(0).Tag = Source.Tag
    //    pic(0).Cls
    //    pic(0).Print MyTabSource(4) & MyTabSource(5) & "heures"
    //    pic(0).Visible = True
    //  End If
    //  
    //  Me.mdSemaine = DateAdd("d", 7, DebutSemaine)
    //  Call InitialiserPlanning
    //
    //End Sub

    /* OK -> cmdAllPrecSuiv_DragDrop --------------------------------------------------------------------------------------- */
    //Private Sub cmdTechS_DragDrop(Source As Control, X As Single, Y As Single)
    //'**************************************************************************************************
    //' passage au technicien suivant
    //'
    //' si création : - faire passer le numéro de l'action a planifier
    //'                - afficher l'image a l'ouverture
    //'
    //' si déplacement d'une IP : - faire passer le numéro de l'IP
    //'                           - afficher l'image a l'ouverture
    //'**************************************************************************************************
    //
    //Dim MyTabSource
    //Dim Top, Left
    //  
    //  ' conservation de la position initiale
    //  Top = Source.Top
    //  Left = Source.Left
    // 
    //  ' recherche des infos
    //  MyTabSource = Split(Source.Tag, "#")
    //  
    //  ' Vérifications (déplacement d'une IP avec information au client, aide sur intervention, IP Emalec)
    //  If Not Verifications(MyTabSource(1), MyTabSource(2), , , True, "") Then
    //    Source.Left = Left
    //    Source.Top = Top
    //    Exit Sub
    //  End If
    //  
    //  ' si on est en création d'une IP, on passe simplement à la semaine suivante sinon
    //  If MyTabSource(0) <> "N" Then
    //    ' on pose l'IP a modifier dans la pic(0)
    //    pic(0).Left = 240
    //    pic(0).Top = 2640
    //    pic(0).Tag = Source.Tag
    //    pic(0).Cls
    //    pic(0).Print MyTabSource(4) & MyTabSource(5) & "heures"
    //    pic(0).Visible = True
    //  End If
    //  
    //  GetTechniciens False, "S"
    //  Call InitialiserPlanning(val(MyTabSource(1)))
    //
    //End Sub

    /* OK -> cmdAllPrecSuiv_DragDrop --------------------------------------------------------------------------------------- */
    //Private Sub cmdTechP_DragDrop(Source As Control, X As Single, Y As Single)
    //'**************************************************************************************************
    //' passage au technicien précédent
    //'
    //' si création : - faire passer le numéro de l'action a planifier
    //'                - afficher l'image a l'ouverture
    //'
    //' si déplacement d'une IP : - faire passer le numéro de l'IP
    //'                           - afficher l'image a l'ouverture
    //'
    //'**************************************************************************************************
    //  
    //Dim MyTabSource
    //Dim Top, Left
    //  
    //  ' conservation de la position initiale
    //  Top = Source.Top
    //  Left = Source.Left
    //  
    //  ' recherche des infos
    //  MyTabSource = Split(Source.Tag, "#")
    // 
    //  ' Vérifications (déplacement d'une IP avec information au client, aide sur intervention, IP Emalec)
    //  If Not Verifications(MyTabSource(1), MyTabSource(2), , , True, "") Then
    //    Source.Left = Left
    //    Source.Top = Top
    //    Exit Sub
    //  End If
    //
    //  ' si on est en création d'une IP, on passe simplement à la semaine suivante sinon
    //  If MyTabSource(0) <> "N" Then
    //    ' on pose l'IP a modifier dans la pic(0)
    //    pic(0).Left = 240
    //    pic(0).Top = 2640
    //    pic(0).Tag = Source.Tag
    //    pic(0).Cls
    //    pic(0).Print MyTabSource(4) & MyTabSource(5) & "heures"
    //    pic(0).Visible = True
    //  End If
    //  
    //  GetTechniciens False, "P"
    //  Call InitialiserPlanning(val(MyTabSource(1)))
    //
    //End Sub

    /* OK --------------------------------------------------------------------------------------- */
    private void cmdTechPrecSuiv_Click(object sender, EventArgs e)
    {
      if (sListeSelectTech != "") return;
      iCurrentTech = 0;
      // passage aux techniciens suivants ou précédents
      string sDirection = (sender as Button).Tag.ToString();
      switch (sTypeTechAffiche)
      {
        case "Climaticiens":
          GetTechniciensSpe(false, sDirection, "Clim");
          break;
        case "CFort":
          GetTechniciensSpe(false, sDirection, "CFort");
          break;
        case "CFaible":
          GetTechniciensSpe(false, sDirection, "CFaible");
          break;
        default:
          GetTechniciens(false, sDirection);
          break;
      }

      Timer1.Enabled = false;
      InitialiserPlanning();
    }




    /* OK --------------------------------------------------------------------------------------- */
    private void cmdSemainePrecSuiv_Click(object sender, EventArgs e)
    {
      // passage à la semaine précédente ou suivante
      Timer1.Enabled = false;
      mdSemaine = mdSemaine.AddDays((sender as Button).Tag.ToString() == "SEMPREC" ? -7 : 7);
      InitialiserPlanning();
    }



    /* OK --------------------------------------------------------------------------------------- */
    private void frmPlan_KeyDown(object sender, KeyEventArgs e)
    {
      if (e.KeyValue == 116)
        InitialiserPlanning();
    }


    /* OK --------------------------------------------------------------------------------------- */
    private void mnuCompetence_Click(object sender, EventArgs e)
    {
      apiToolTip1.BackColor = MozartColors.ColorHFFF0FF;
      apiToolTip1.Texte = "";
      apiToolTip1.Titre = Resources.txt_Liste_competences;
      using (SqlDataReader dr = ModuleData.ExecuteReader($"SELECT R.VTYPECONTRAT From TPERTYPECONTRAT C INNER JOIN TREF_TYPECONTRAT R ON C.NTYPECONTRAT = R.NTYPECONTRAT  " +
                                        $"WHERE CACTIF = 'O' AND LANGUE='{MozartParams.Langue}' AND NPERNUM={miNumTech} order by R.VTYPECONTRAT"))
      {
        while (dr.Read())
          apiToolTip1.Texte += dr["VTYPECONTRAT"] + "\r\n";
      }
      apiToolTip1.PrintTexte("");

      TextBox txtbox = (apiToolTip1.Controls["txtTexte"] as TextBox);
      Size size = TextRenderer.MeasureText(txtbox.Text, txtbox.Font);
      apiToolTip1.Height = Math.Min(size.Height, this.ClientSize.Height - apiToolTip1.Top - 10);

      apiToolTip1.BringToFront();
      apiToolTip1.Visible = true;
    }

    /* OK --------------------------------------------------------------------------------------- */
    private void mnuHabilitation_Click(object sender, EventArgs e)
    {
      new frmMainReport
      {
        bLaunchByProcessStart = false,
        sTypeReport = "TCARTE",
        sIdentifiant = miNumTech.ToString(),
        InfosMail = $"0|0|0",
        sNomSociete = MozartParams.NomSociete,
        sLangue = MozartParams.Langue,
        sOption = "PREVIEW",
      }.ShowDialog();
    }


    /* OK --------------------------------------------------------------------------------------- */
    private void pic_MouseUp(object sender, MouseEventArgs e)
    {
      try
      {
        if (e.Button == MouseButtons.Right)
        {
          PictureBox pic = sender as PictureBox;

          string[] MyTabPic = (pic.Tag as picTag).sTag.Split('#');
          DateTime.TryParse(MyTabPic[8], out ddatejour);

          if (ddatejour.ToShortDateString() == "01/01/0001")
            ddatejour = new DateTime(1900, 01, 01);


          miNumIp = Convert.ToInt32(MyTabPic[1]);
          miNumTech = Convert.ToInt32(MyTabPic[7]);
          miNumSite = Convert.ToInt32(MyTabPic[2]);
          mstrTypeEdition = "IP";

          mnuCP.Text = UtilsPlan.GetCodePostal(miNumSite);
          mnuCP.Visible = true;
          mnuDP.Text = GetDatePrevByCont(miNumIp, miNumSite, ddatejour.ToString());
          mnuDP.Visible = true;
          mnuVisu.Visible = true;
          mnuEditionOTJour.Visible = true;
          mnuSupprimerIP.Visible = true;
          mnuDetails.Visible = true;
          mnuCompetence.Visible = false;
          mnuHabilitation.Visible = false;
          mnuplanifierUneAbsence.Visible = false;
          informationsUtilesToolStripMenuItem.Visible = false;

          // droit sur le bouton de blocage des pavés
          if (ModuleMain.RechercheDroitMenu(335))
          {
            // Recherche si blocage ou pas actuellement et selon le cas, affichage de blocage ou déblocage
            mnuBlocagePave.Visible = true;
            UtilsPlan.EtatBlocage(miNumIp, ref mnuBlocagePave);
          }

          mnuAffichage.Tag = pic.Tag;
          mnuAffichage.Show(Cursor.Position);
        }
      }
      catch (Exception ex)
      {
        MZUtils.displayError(MethodBase.GetCurrentMethod().Name, ex);
      }
    }

    private void lblTech_MouseUp(object sender, MouseEventArgs e)
    {
      if (e.Button == MouseButtons.Right)
      {
        miNumTech = Convert.ToInt32((sender as Control).Tag);
        miNumIp = 0;
        mstrTypeEdition = Resources.col_Tech;
        mnuCP.Visible = mnuDP.Visible = mnuDatPlaInit.Visible = mnuVisu.Visible = false;
        mnuSupprimerIP.Visible = mnuDetails.Visible = mnuEditionOTJour.Visible = false;
        mnuCompetence.Visible = mnuHabilitation.Visible = true;
        informationsUtilesToolStripMenuItem.Visible = false;

        // droit sur le bouton de création des absences
        if (ModuleMain.RechercheDroitMenu(610))
        {
          mnuplanifierUneAbsence.Visible = true;
        }

        //droit specifique sur informations utiles
        if (ModuleMain.RechercheDroitMenu(Convert.ToInt32(informationsUtilesToolStripMenuItem.AccessibleDescription)))
        {
          informationsUtilesToolStripMenuItem.Visible = true;
        }

        mnuAffichage.Show(Cursor.Position);
      }
    }

    private void mnuEditionOT_Click(object sender, EventArgs e)
    {
      string[] myTab = (mnuAffichage.Tag as picTag).sTag.Split('#');

      UtilsPlan.mnuEditionOT_Click(miNumTech, ddatejour.ToShortDateString(), miNumIp, miNumSite, mstrTypeEdition, ProgressBar1, myTab, lstPic, bFax);
    }

    private void mnuVisu_Click(object sender, EventArgs e)
    {
      try
      {
        // si on est pas sur une IP on sort
        if (miNumIp == 0) return;

        //string[,] TdbGlobal = { { "Date", DateTime.Now.ToShortDateString() } };

        //frmBrowser f = new frmBrowser
        //{
        //  msInfosMail = $"TPER|NPERNUM|{miNumTech}"
        //};
        //f.Preview_Print($"{MozartParams.CheminModeles}{ModuleMain.CodePays(ModuleMain.GetPays("TPER", "VPERPAYS", "NPERNUM", miNumTech.ToString()))}{ModuleMain.ChoixModelOT(miNumIp)}",
        //                @"TOrdreTravailInfoOut.rtf",
        //                TdbGlobal,
        //                $"exec api_sp_OrdreDeTravail {miNumIp}",
        //                " (Imprimer OT dans frmplanBis)",
        //                "PREVIEW");

        new frmMainReport
        {
          bLaunchByProcessStart = false,
          sTypeReport = ModuleMain.ChoixModelOTDevExpress(miNumIp),
          sIdentifiant = $"{miNumIp}",
          InfosMail = $"TPER|NPERNUM|{miNumTech}",
          sNomSociete = MozartParams.NomSociete,
          sLangue = ModuleMain.CodePays(ModuleMain.GetPays("TPER", "VPERPAYS", "NPERNUM", miNumTech.ToString())).Substring(0, 2),
          sOption = "PREVIEW"
        }.ShowDialog();
      }
      catch (Exception ex)
      {
        MZUtils.displayError(MethodBase.GetCurrentMethod().Name, ex);
      }
    }

    private void mnuSupprimerIP_Click(object sender, EventArgs e)
    {
      try
      {
        // si on est pas sur une IP on sort
        if (miNumIp == 0) return;

        //  Si l'action est exécutée, on ne peut pas la supprimer
        if (UtilsPlan.VerifAuto(miNumIp) == false) return;
        if (UtilsPlan.VerifDroits(miNumIp) == false) return;
        if (UtilsPlan.VerifBlocage(miNumIp) == false) return;

        // on ne peut pas supprimer si une personne est sur l'action en modification
        if (UtilsPlan.VerifLockAction(miNumIp) == false) return;

        // Confirmation de la suppression
        if (MessageBox.Show(Resources.msg_dde_suppr_planif, Program.AppTitle, MessageBoxButtons.YesNo, MessageBoxIcon.Question,
                            MessageBoxDefaultButton.Button2) == DialogResult.Yes)
        {
          ModuleData.ExecuteNonQuery($"api_sp_SupprimerIP {miNumIp}, '{ddatejour}'");
          UtilsPlan.AddLogIPL(miNumIp, "S");
        }
        else
          return;

        // initialisation du planning
        InitialiserPlanning();
      }
      catch (Exception ex)
      {
        MZUtils.displayError(MethodBase.GetCurrentMethod().Name, ex);
      }
    }


    //Public Sub mnuSupprimerIP_Click()
    //
    //  On Error GoTo handler
    //  
    //  ' si on est pas sur une IP on sort
    //  If iNumIp = 0 Then Exit Sub
    //  
    //  If VerifAuto(iNumIp) = False Then Exit Sub
    //  If VerifDroits(iNumIp) = False Then Exit Sub
    //  If VerifBlocage(iNumIp) = False Then Exit Sub
    //  
    //  ' on ne peut pas supprimer si une personne est sur l'action en modification
    //  If VerifLockAction(iNumIp) = False Then Exit Sub
    //
    //  ' CONFIRMATION DE LA SUPPRESSION
    //  Select Case MsgBox("§Voulez-vous supprimer la planification ?§", vbYesNo + vbQuestion + vbDefaultButton2)
    //    Case vbYes
    //      cnx.Execute "api_sp_SupprimerIP " & iNumIp & ", '" & ddatejour & "'"
    //      AddLogIPL iNumIp, "S"
    //    Case vbNo
    //      Exit Sub
    //  End Select
    //
    //  ' initialisation du planning
    //  Call InitialiserPlanning
    //  
    //Exit Sub
    //handler:
    //  ShowError "mnuSupprimerIP_Click dans " & Me.Name
    //End Sub

    /* OK --------------------------------------------------------------------------------------- */
    private void mnuDetails_Click(object sender, EventArgs e)
    {
      UtilsPlan.mnuDetails_Click(miNumIp);
      InitialiserPlanning();
    }
    //Private Sub mnuDetails_Click()
    //
    //Dim rsD As New ADODB.Recordset
    //Dim rsa As New ADODB.Recordset
    //Dim rsDroit As New ADODB.Recordset
    //Dim liNumDI, llNumAction
    //
    //  ' si on est pas sur une IP on sort
    //  If iNumIp = 0 Then Exit Sub
    //    
    //  ' affichage d'une fenetre avec detail de l'IP
    //  rsD.Open "select count(*) from TACT WITH (NOLOCK) where NIPLNUM = " & iNumIp, cnx
    //      
    //  If rsD(0) > 1 Then
    //    frmDetailIP.miNumIP = iNumIp
    //    frmDetailIP.Show vbModal
    //  Else
    //    ' on garde les variables globales en mémoire
    //    rsa.Open "select NACTNUM, NDINNUM from TACT WITH (NOLOCK) where NIPLNUM = " & iNumIp, cnx
    //
    //    liNumDI = giNumDi
    //    llNumAction = glNumAction
    //  
    //    ' recherche des droits sur cette DI
    //    
    //    rsDroit.Open "SELECT count(*) FROM TDIN INNER JOIN TAUT ON  TDIN.NDINCTE = TAUT.NCANNUM " & _
    //             " INNER JOIN TPER ON TAUT.NPERNUM = TPER.NPERNUM WHERE TPER.NPERNUM = " & gintUID & _
    //             " AND   TDIN.NDINNUM = " & rsa("NDINNUM"), cnx
    //             
    //    If rsDroit(0) = 0 Then
    //        MsgBox "§Vous n'avez pas les droits d'accès sur cette DI§"
    //        rsDroit.Close
    //        Exit Sub
    //    Else
    //      ' écran de modification de la demande
    //      frmAddAction.mstrStatutDI = "M"
    //      giNumDi = rsa("NDINNUM").value
    //      glNumAction = rsa("NACTNUM").value
    //        
    //      On Error Resume Next
    //      
    //      frmAddAction.Show vbModal
    //        
    //      If Err Then MsgBox "§Impossible d'afficher l'écran de détail de l'action car cet écran et déjà chargé en arrière plan§"
    //      
    //      ' on revient donc on réinitialise les variables globales avec anciennes valeurs
    //      giNumDi = liNumDI
    //      glNumAction = llNumAction
    //      rsDroit.Close
    //      rsa.Close
    //    End If
    //  End If
    //  rsD.Close
    //
    //  ' initialisation du planning pour prendre en compte les modifications
    //  Call InitialiserPlanning      ' VL modif 07/11/03 pour accélerer  ' FG rafraichissement
    //  
    // End Sub

    /* OK --------------------------------------------------------------------------------------- */
    private void mnuMoisTech_Click(object sender, EventArgs e)
    {
      try
      {
        // si on est pas sur une IP on sort
        if (miNumTech == 0) return;

        string[,] TdbGlobal = { { "Date", DateTime.Now.ToShortDateString() } };

        frmBrowser f = new frmBrowser();
        f.msInfosMail = $"TPER|NPERNUM|{miNumTech}";
        f.Preview_Print($"{MozartParams.CheminModeles}{MozartParams.Langue}\\TPlanningTechA4.rtf",
                        @"TPlanningTechA4out.rtf",
                        TdbGlobal,
                        $"exec api_sp_impPlanningTechA4 {miNumTech}, '{mdSemaine}'",
                        " (Imprimer planning A4 dans frmplanBis)",
                        "PREVIEW");
      }
      catch (Exception ex)
      {
        MZUtils.displayError(MethodBase.GetCurrentMethod().Name, ex);
      }
    }
    //Private Sub mnuMoisTech_Click()
    //
    //Dim TdbGlobal(0 To 1, 0 To 1) As Variant
    //    
    //On Error Resume Next
    //
    //  If iNumTech = 0 Then
    //    MsgBox "§cliquez sur le technicien pour avoir son planning§"
    //  Else
    //    
    //    frmBrowser.bPlanningAn = 0
    //    frmBrowser.InfosMail = "TPER|NPERNUM|" & iNumTech
    //    frmBrowser.Preview_Print gstrCheminModeles & gstrLangue & "\" & "TPlanningTechA4.rtf", _
    //                              "\TPlanningTechA4out.rtf", _
    //                              TdbGlobal(), _
    //                              "exec api_sp_impPlanningTechA4 " & iNumTech & ",'" & DebutSemaine & "'", _
    //                              " (Imprimer planning A4 dans frmplanBis)", _
    //                              "PREVIEW"
    //  End If
    //End Sub

    /* OK --------------------------------------------------------------------------------------- */
    private void cmdImprimer_Click(object sender, EventArgs e)
    {
      Cursor.Current = Cursors.WaitCursor;
      this.ImprimerDansWord();
      Cursor.Current = Cursors.Default;
    }
    //Private Sub cmdImprimer_Click()
    //
    //  ' fonction d'impression écran
    //  Screen.MousePointer = vbHourglass
    //  ImprimerDansWord
    //  Screen.MousePointer = vbDefault
    //
    //End Sub

    /* OK --------------------------------------------------------------------------------------- */
    private void cmdRefresh_Click(object sender, EventArgs e)
    {
      InitialiserPlanning();
    }
    //Private Sub cmdRefresh_Click()
    //  Call InitialiserPlanning
    //End Sub

    /* OK --------------------------------------------------------------------------------------- */
    private void Timer2_Tick(object sender, EventArgs e)
    {
      //Static iNb As Integer
      if (iNb >= 3)
      {
        lblRefresh.Visible = true;
        Timer2.Enabled = false;
        iNb = 0;
      }
      else
        iNb += 1;
    }
    //Private Sub Timer2_Timer()
    //Static iNb As Integer
    //  If iNb >= 3 Then
    //    lblRefresh.Visible = True
    //    Timer2.Enabled = False
    //    iNb = 0
    //  Else
    //    iNb = iNb + 1
    //  End If
    //End Sub

    /* OK --------------------------------------------------------------------------------------- */
    private string GetDatePrevByCont(int iNumIp, int iSite, string dDate)
    {
      string sRet = "";
      using (SqlDataReader dr = ModuleData.ExecuteReader($"api_sp_GetDatePrevByCont {iNumIp}, {iSite}, '{dDate}'"))
      {
        while (dr.Read())
        {
          if (sRet == "")
            sRet = $"Dernière prev / contrat : [{dr[0]} : {dr[1]} ]";
          else
            sRet += $" - [{dr[0]} : {dr[1]} ]";
        }
      }
      //  lRs.Open "exec api_sp_GetDatePrevByCont " & iNumIp & "," & iSite & ",'" & dDate & "'", cnx, adOpenStatic, adLockReadOnly
      //   
      //  While lRs.EOF = False
      //    
      //    if (sRet = "")
      //        sRet = "Dernière prev / contrat : [" & lRs(0) & " : " & lRs(1) & " ]"
      //    else
      //        sRet += " - [" & lRs(0) & " : " & lRs(1) & " ]"
      //  Wend
      return sRet;
    }
    //Public Function GetDatePrevByCont(ByVal iNumIp As Long, ByVal iSite As Long, ByVal dDate As String) As String
    //  
    //  Dim sListeContLastDate As String
    //  Dim lRs As New ADODB.Recordset
    //  'Set lRs = cnx.Execute("exec api_sp_GetDatePrevByCont " & iNumIp & "," & iSite & ",'" & dDate & "'")
    //  
    //  lRs.Open "exec api_sp_GetDatePrevByCont " & iNumIp & "," & iSite & ",'" & dDate & "'", cnx, adOpenStatic, adLockReadOnly
    //   
    //  While lRs.EOF = False
    //    
    //    If sListeContLastDate = "" Then
    //        sListeContLastDate = "Dernière prev / contrat : [" & lRs(0) & " : " & lRs(1) & " ]"
    //    Else
    //        sListeContLastDate = sListeContLastDate & " - [" & lRs(0) & " : " & lRs(1) & " ]"
    //    End If
    //        
    //    lRs.MoveNext
    //  
    //  Wend
    //  lRs.Close
    //  GetDatePrevByCont = sListeContLastDate
    //End Function

    /* OK --------------------------------------------------------------------------------------- */
    private void AfficheInfoSite(int NumSite)
    {
      ModuleMain.Infos infos = ModuleMain.RechercheInfos("INFO_SITE", NumSite);

      if (infos.strInfo != "" && infos.DateValDeb < DateTime.Now && infos.DateValFin > DateTime.Now)
      {
        new frmInfosClient()
        {
          msStatut = infos.strInfo,
          msInfo = infos.strInfo
        }.ShowDialog();
      }
    }
    //Private Sub AfficheInfoSite(NumSite As Long)
    //Dim InfoSite As Info
    //
    //  InfoSite = RechercheInfos("INFO_SITE", NumSite)
    //  If InfoSite.strInfo <> "" And InfoSite.DateValDeb < Date And InfoSite.DateValFin > Date Then
    //    frmInfosClient.strStatut = "S"    ' site
    //    frmInfosClient.strInfo = InfoSite.strInfo
    //    frmInfosClient.Show vbModal
    //  End If
    //End Sub

    /* OK --------------------------------------------------------------------------------------- */
    private void RechercheInfoCdeFo(int NumIP)
    {
      // On affiche un message lorsqu'il existe une ou des commande fournisseurs ou sorties
      // de stock sur une action préventive relative à l'Ip
      string sMsg = "";

      using (SqlDataReader dr = ModuleData.ExecuteReader($"api_sp_IpCommandeSortie {NumIP}"))
        while (dr.Read())
          sMsg += $",{dr["DateLivr"]}";

      if (sMsg != "")
      {
        sMsg = sMsg.Substring(0, sMsg.Length - 1);
        MessageBox.Show(Resources.txt_Attention + "\r\n" + Resources.txt_existe_commande_a_date + "\r\n" + sMsg,
                        Program.AppTitle, MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
      }
    }
    //Private Sub RechercheInfoCdeFo(NumIP As Long)
    //Dim sMsgDateLiv As String
    //
    //    ' On affiche un message lorsqu'il existe une ou des commande fournisseurs ou sorties
    //    ' de stock sur une action préventive relative à l'Ip
    //
    //    Set rsDateLiv = cnx.Execute("api_sp_IpCommandeSortie " & NumIP)
    //    
    //    If rsDateLiv.RecordCount > 0 Then
    //      rsDateLiv.MoveFirst
    //      While Not rsDateLiv.EOF
    //        sMsgDateLiv = sMsgDateLiv & "," & rsDateLiv("DateLivr")
    //        
    //      rsDateLiv.MoveNext
    //      Wend
    //      sMsgDateLiv = Right(sMsgDateLiv, Len(sMsgDateLiv) - 1)
    //      MsgBox "§Attention :§" & vbCrLf & "§Il existe une ou des commandes de fournitures ou sorties de stock avec une ou des dates de livraisons suivantes :§" & vbCrLf _
    //            & sMsgDateLiv, vbExclamation
    //    End If
    //
    //End Sub

    /* OK --------------------------------------------------------------------------------------- */
    private void TraitementBoutonSupp()
    {
      try
      {
        foreach (Button cmd in lstCmdPlus)
        {
          cmd.Visible = false;
          cmd.BackColor = Color.FromArgb(255, 128, 0);
        }

        foreach (Button cmd in lstCmdPlus)
        {
          cmdPlusTag cTag = cmd.Tag as cmdPlusTag;
          DataTable dt = new DataTable();

          // Si on a 1 tech et que 1er jour de la semaine on cherche le nb d'inter
          if (cTag.iTech > 0 && (cTag.iBtn == 0 || cTag.iBtn == 7 || cTag.iBtn == 14 || cTag.iBtn == 21))
          {
            dt.Clear();
            ModuleData.LoadData(dt, $"api_sp_NombreInterventions {cTag.iTech}, '{mdSemaine}'");
          }

          foreach (DataRow row in dt.Rows)
          {
            int NbInt = Convert.ToInt32(row[1]);
            if (NbInt >= 4)
            {
              Button btn = lstCmdPlus.Where(b => (b.Tag as cmdPlusTag).iTech == cTag.iTech && Convert.ToDateTime((b.Tag as cmdPlusTag).sDateJour) == Convert.ToDateTime(row["DIPLDATJ"])).FirstOrDefault();

              if (btn != null)
              {
                if (NbInt >= 4)
                  btn.Visible = true;

                if (NbInt == 4)
                  btn.BackColor = Color.White;
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
    //Private Sub TraitementBoutonSupp()
    //Dim rsAct As ADODB.Recordset
    //Dim i, j
    //  
    //  For j = 0 To 3 ' 0,1,2,3 = 4 techniciens sur le planning)
    //    'tous les bouton non visible pour ce technicien
    //    For i = (7 * j) To ((7 * j) + 6)
    //      cmdPlus(i).Visible = False
    //    Next
    //    
    //    ' nombre d'interventions par techniciens, par jour pour la semaine en cours
    //    'If gstrNomSociete = "EMALEC" And (gintUID = 1 Or gintUID = 30 Or gintUID = 339) Then
    //      If lblTech(j).Tag <> "" Then
    //        Set rsAct = New ADODB.Recordset
    //        rsAct.Open "api_sp_NombreInterventions " & lblTech(j).Tag & ", '" & DebutSemaine & "'", cnx
    //        While Not rsAct.EOF
    //          If rsAct(1) > 3 Then
    //            If Weekday(rsAct("DIPLDATJ")) = 1 Then  ' dimanche
    //              cmdPlus((7 * j) + 6).Visible = True
    //              If rsAct(1) = 4 Then
    //                cmdPlus((7 * j) + 6).BackColor = vbWhite
    //              Else
    //                cmdPlus((7 * j) + 6).BackColor = &H80FF&
    //              End If
    //            Else
    //              cmdPlus((7 * j) + Weekday(rsAct("DIPLDATJ")) - 2).Visible = True
    //              If rsAct(1) = 4 Then
    //                cmdPlus((7 * j) + Weekday(rsAct("DIPLDATJ")) - 2).BackColor = vbWhite
    //              Else
    //                cmdPlus((7 * j) + Weekday(rsAct("DIPLDATJ")) - 2).BackColor = &H80FF&
    //              End If
    //            End If
    //          End If
    //          rsAct.MoveNext
    //        Wend
    //        rsAct.Close
    //        Set rsAct = Nothing
    //      End If
    //    'End If
    //  Next
    //End Sub

    /* OK --------------------------------------------------------------------------------------- */
    private void cmdPlus_Click(object sender, EventArgs e)
    {
      int Index = ((cmdPlusTag)(sender as Button).Tag).iBtn;

      frmPlanTech f = new frmPlanTech();
      if (Index <= 6)
      {
        f.miNumTech = Convert.ToInt32(lblTech0.Tag);
        f.mlblTech = lblTech0.Text;
      }
      else if (Index > 6 && Index <= 13)
      {
        f.miNumTech = Convert.ToInt32(lblTech1.Tag);
        f.mlblTech = lblTech1.Text;
      }
      else if (Index > 13 && Index <= 20)
      {
        f.miNumTech = Convert.ToInt32(lblTech2.Tag);
        f.mlblTech = lblTech2.Text;
      }
      else if (Index > 20 && Index <= 27)
      {
        f.miNumTech = Convert.ToInt32(lblTech3.Tag);
        f.mlblTech = lblTech3.Text;
      }
      f.DebutSemaine = mdSemaine;
      f.ShowDialog();

      InitialiserPlanning();

    }
    //Private Sub cmdPlus_Click(Index As Integer)
    //  
    //  frmPlanTech.DebutSemaine = DebutSemaine
    //  
    //  If Index <= 6 Then
    //    frmPlanTech.iNumTech = lblTech(0).Tag
    //    frmPlanTech.lblTech = lblTech(0)
    //  ElseIf Index > 6 And Index <= 13 Then
    //    frmPlanTech.iNumTech = lblTech(1).Tag
    //    frmPlanTech.lblTech = lblTech(1)
    //  ElseIf Index > 13 And Index <= 20 Then
    //    frmPlanTech.iNumTech = lblTech(2).Tag
    //    frmPlanTech.lblTech = lblTech(2)
    //  ElseIf Index > 20 And Index <= 27 Then
    //    frmPlanTech.iNumTech = lblTech(3).Tag
    //    frmPlanTech.lblTech = lblTech(3)
    //  End If
    //  
    //  frmPlanTech.Show vbModal
    //  
    //  Call InitialiserPlanning
    //  
    //End Sub

    /* OK --------------------------------------------------------------------------------------- */
    private void cmdPlus_DragDrop(object sender, DragEventArgs e)
    {
      // On passe l'IP sur le planning du tech virtuel
      int Index = ((cmdPlusTag)(sender as Button).Tag).iBtn;
      PictureBox picSource = (PictureBox)e.Data.GetData(typeof(PictureBox));

      //  Conservation de la position initiale
      int Left = picSource.Left;
      int Top = picSource.Top;

      //  Recherche des info dans le tag de l'image
      string[] myTab = (picSource.Tag as picTag).sTag.Split('#');
      miNumAction = Convert.ToInt32(myTab[3]);

      //   Vérifications (déplacement d'une IP avec information au client, aide sur intervention, IP Emalec, action bloque)
      if (!UtilsPlan.Verifications(Convert.ToInt32(myTab[1]), Convert.ToInt32(myTab[2]), 0, 0, true, ""))
      {
        picSource.Left = Left;
        picSource.Top = Top;
        return;
      }

      frmPlanTech f = new frmPlanTech();
      if (Index <= 6)
      {
        f.miNumTech = Convert.ToInt32(lblTech0.Tag);
        f.mlblTech = lblTech0.Text;
      }
      else if (Index > 6 && Index <= 13)
      {
        f.miNumTech = Convert.ToInt32(lblTech1.Tag);
        f.mlblTech = lblTech1.Text;
      }
      else if (Index > 13 && Index <= 20)
      {
        f.miNumTech = Convert.ToInt32(lblTech2.Tag);
        f.mlblTech = lblTech2.Text;
      }
      else if (Index > 20 && Index <= 27)
      {
        f.miNumTech = Convert.ToInt32(lblTech3.Tag);
        f.mlblTech = lblTech3.Text;
      }

      //  On pose l'IP a modifier dans la pic0
      f.pic0.Tag = picSource.Tag;
      (f.pic0.Tag as picTag).sInter = myTab[4] + myTab[5] + "heures";

      f.pic0.Visible = true;

      picSource.Visible = false;

      f.DebutSemaine = mdSemaine;
      f.ShowDialog();

      InitialiserPlanning();
    }
    //Private Sub cmdPlus_DragDrop(Index As Integer, Source As Control, X As Single, Y As Single)
    //'**************************************************************************************************
    //'on passe l'IP sur le planning du tech virtuel
    //'**************************************************************************************************
    //Dim MyTabSource
    //Dim Top, Left
    //  
    //  ' recherche des Infos
    //  MyTabSource = Split(Source.Tag, "#")
    //
    //  ' conservation de la position initiale
    //  Top = Source.Top
    //  Left = Source.Left
    //  
    //  ' Vérifications (déplacement d'une IP avec Information au client, aide sur intervention, IP Emalec)
    //  If Not Verifications(MyTabSource(1), MyTabSource(2), , , True, "") Then
    //    Source.Left = Left
    //    Source.Top = Top
    //    Exit Sub
    //  End If
    //  
    //  frmPlanTech.DebutSemaine = DebutSemaine
    //  
    //   If Index <= 6 Then
    //     frmPlanTech.iNumTech = lblTech(0).Tag
    //     frmPlanTech.lblTech = lblTech(0)
    //   ElseIf Index > 6 And Index <= 13 Then
    //     frmPlanTech.iNumTech = lblTech(1).Tag
    //     frmPlanTech.lblTech = lblTech(1)
    //   ElseIf Index > 13 And Index <= 20 Then
    //     frmPlanTech.iNumTech = lblTech(2).Tag
    //     frmPlanTech.lblTech = lblTech(2)
    //   ElseIf Index > 20 And Index <= 27 Then
    //     frmPlanTech.iNumTech = lblTech(3).Tag
    //     frmPlanTech.lblTech = lblTech(3)
    //   End If
    //  
    //  ' on pose l'IP a modifier dans la pic(0)
    //  frmPlanTech.pic(0).Tag = Source.Tag
    //  frmPlanTech.pic(0).Cls
    //  frmPlanTech.pic(0).Print MyTabSource(4) & MyTabSource(5) & "heures"
    //  frmPlanTech.pic(0).Visible = True
    //  
    //  Source.Visible = False
    //  
    //  frmPlanTech.Show vbModal
    //  
    //  Call InitialiserPlanning
    //
    //End Sub

    /* OK --------------------------------------------------------------------------------------- */
    private void CmdIndusSer_Click(object sender, EventArgs e)
    {
      if (LblIndusServices.Text == Resources.txt_IndusS)
      {
        LblIndusServices.Text = Resources.txt_Tous;
        LblIndusMac.Text = Resources.txt_IndusM;
        lblSecondOeuvre.Text = Resources.txt_Travaux_TCE;
        lblclim.Text = Resources.txt_Climaticiens;
        lblFort.Text = Resources.txt_courant_fort;
        lblFaible.Text = Resources.txt_courant_faible;
        lblTrav.Text = Resources.col_plomberie;
        lblMultitech.Text = Resources.txt_Multitech;
        lblMone.Text = Resources.txt_Ext_inc;
        LblLegCommerce.Text = MZCtrlResources.Commercial;
        lblSelectionTech.Text = Resources.txt_Selection;
        sTypeTechAffiche = Resources.txt_IndusS;
        //  recherche des techniciens courant faible
        GetTechniciensSpe(true, "N", "IndusSer");
        lblInter.Visible = false;
        cboInter.Visible = false;
        cmdGoTech.Visible = false;
        cmdTrajets.Visible = true;
        cmdTrajets.Tag = 20;
      }
      else
      {
        LblIndusServices.Text = Resources.txt_IndusS;
        sTypeTechAffiche = Resources.txt_Tous;
        //  recherche des techniciens
        GetTechniciens(true, "N", true);
        lblInter.Visible = true;
        cboInter.Visible = true;
        cmdGoTech.Visible = true;
        cmdTrajets.Visible = false;
        cmdTrajets.Tag = 0;
      }
      // réinitialisation de l'affichage
      InitialiserPlanning();
    }
    //Private Sub CmdIndusSer_Click()
    //On Error Resume Next
    //  rsT.Close ' fermeture du recordset des techs
    //  If LblIndusServices.Caption = Resources.txt_IndusS Then
    //    LblIndusServices.Caption = Resources.txt_Tous
    //    LblIndusMac.Caption = Resources.txt_IndusM
    //    lblSecondOeuvre = Resources.txt_Travaux_TCE
    //    lblclim.Caption = Resources.txt_Climaticiens
    //    lblFort.Caption = Resources.txt_courant_fort
    //    lblFaible.Caption = Resources.txt_courant_faible
    //    lblTrav.Caption = Resources.col_plomberie
    //    lblMultitech.Caption = Resources.txt_Multitech
    //    lblMone.Caption = Resources.txt_Ext_inc
    //    lblSelectionTech.Text = Resources.txt_Selection
    //    sTypeTechAffiche = "§IndusSer§"
    //    '  recherche des techniciens courant faible
    //    GetTechniciensSpe True, "N", "IndusSer"
    //    lblInter.Visible = False
    //    cboInter.Visible = False
    //    cmdGoTech.Visible = False
    //    cmdTrajets.Visible = True
    //    cmdTrajets.Tag = 20
    //  Else
    //    LblIndusServices.Caption = Resources.txt_IndusS
    //    sTypeTechAffiche = Resources.txt_Tous
    //    '  recherche des techniciens
    //    GetTechniciens True, "N", True
    //    lblInter.Visible = True
    //    cboInter.Visible = True
    //    cmdGoTech.Visible = True
    //    cmdTrajets.Visible = False
    //    cmdTrajets.Tag = 0
    //  End If
    //  ' réinitialisation de l'affichage
    //  Call InitialiserPlanning
    //
    //End Sub

    /* OK --------------------------------------------------------------------------------------- */
    private void cmdInfo_Click(object sender, EventArgs e)
    {
      if (lblMone.Text == Resources.txt_Ext_inc)
      {
        lblMone.Text = Resources.txt_Tous;
        LblIndusServices.Text = Resources.txt_IndusS;
        LblIndusMac.Text = Resources.txt_IndusM;
        lblSecondOeuvre.Text = Resources.txt_Travaux_TCE;
        lblclim.Text = Resources.txt_Climaticiens;
        lblFort.Text = Resources.txt_courant_fort;
        lblFaible.Text = Resources.txt_courant_faible;
        lblTrav.Text = Resources.col_plomberie;
        lblMultitech.Text = Resources.txt_Multitech;
        lblSelectionTech.Text = Resources.txt_Selection;
        LblLegCommerce.Text = MZCtrlResources.Commercial;
        sTypeTechAffiche = "EI";
        //  recherche des techniciens Monétique
        GetTechniciensSpe(true, "N", "EI");
        lblInter.Visible = false;
        cboInter.Visible = false;
        cmdGoTech.Visible = false;
        cmdTrajets.Visible = true;
        cmdTrajets.Tag = 4;
      }
      else
      {
        lblMone.Text = Resources.txt_Ext_inc;
        sTypeTechAffiche = Resources.txt_Tous;
        //  recherche des techniciens
        GetTechniciens(true, "N", true);
        lblInter.Visible = true;
        cboInter.Visible = true;
        cmdGoTech.Visible = true;
        cmdTrajets.Visible = false;
        cmdTrajets.Tag = 0;
      }
      // réinitialisation de l'affichage
      InitialiserPlanning();
    }
    //Private Sub cmdInfo_Click()
    //
    //On Error Resume Next
    //  rsT.Close ' fermeture du recordset des techs
    //  If lblMone.Caption = Resources.txt_Ext_inc Then
    //    lblMone.Caption = Resources.txt_Tous
    //    LblIndusServices.Caption = Resources.txt_IndusS
    //    LblIndusMac.Caption = Resources.txt_IndusM
    //    lblSecondOeuvre = Resources.txt_Travaux_TCE
    //    lblclim.Caption = Resources.txt_Climaticiens
    //    lblFort.Caption = Resources.txt_courant_fort
    //    lblFaible.Caption = Resources.txt_courant_faible
    //    lblTrav.Caption = Resources.col_plomberie
    //    lblMultitech.Caption = Resources.txt_Multitech
    //    lblSelectionTech.Text = Resources.txt_Selection
    //    sTypeTechAffiche = "EI"
    //    '  recherche des techniciens Monétique
    //    GetTechniciensSpe True, "N", "EI"
    //    lblInter.Visible = False
    //    cboInter.Visible = False
    //    cmdGoTech.Visible = False
    //    cmdTrajets.Visible = True
    //    cmdTrajets.Tag = 4
    //  Else
    //    lblMone.Caption = Resources.txt_Ext_inc
    //    sTypeTechAffiche = Resources.txt_Tous
    //    '  recherche des techniciens
    //    GetTechniciens True, "N", True
    //    lblInter.Visible = True
    //    cboInter.Visible = True
    //    cmdGoTech.Visible = True
    //    cmdTrajets.Visible = False
    //    cmdTrajets.Tag = 0
    //  End If
    //  ' réinitialisation de l'affichage
    //  Call InitialiserPlanning
    //End Sub

    /* OK --------------------------------------------------------------------------------------- */
    private void CmdCommerce_Click(object sender, EventArgs e)
    {
      if (LblLegCommerce.Text == MZCtrlResources.Commercial)
      {
        LblLegCommerce.Text = Resources.txt_Tous;
        LblIndusServices.Text = Resources.txt_IndusS;
        LblIndusMac.Text = Resources.txt_IndusM;
        lblSecondOeuvre.Text = Resources.txt_Travaux_TCE;
        lblclim.Text = Resources.txt_Climaticiens;
        lblFort.Text = Resources.txt_courant_fort;
        lblMone.Text = Resources.txt_Ext_inc;
        lblFaible.Text = Resources.txt_courant_faible;
        lblTrav.Text = Resources.col_plomberie;
        lblMultitech.Text = Resources.txt_Multitech;
        lblSelectionTech.Text = Resources.txt_Selection;
        sTypeTechAffiche = "CO";
        //  recherche des techniciens Monétique
        GetTechniciensSpe(true, "N", "CO");
        lblInter.Visible = false;
        cboInter.Visible = false;
        cmdGoTech.Visible = false;
        cmdTrajets.Visible = true;
        cmdTrajets.Tag = 4;
      }
      else
      {
        LblLegCommerce.Text = MZCtrlResources.Commercial;
        sTypeTechAffiche = Resources.txt_Tous;
        //  recherche des techniciens
        GetTechniciens(true, "N", true);
        lblInter.Visible = true;
        cboInter.Visible = true;
        cmdGoTech.Visible = true;
        cmdTrajets.Visible = false;
        cmdTrajets.Tag = 0;
      }
      // réinitialisation de l'affichage
      InitialiserPlanning();
    }
    //Private Sub CmdCommerce_Click()
    //
    //On Error Resume Next
    //
    //    rsT.Close ' fermeture du recordset des techs
    //    If LblLegCommerce.Caption = Resources.col_Commercial Then
    //      LblLegCommerce.Caption = Resources.txt_Tous
    //      LblIndusServices.Caption = Resources.txt_IndusS
    //      LblIndusMac.Caption = Resources.txt_IndusM
    //      lblSecondOeuvre = Resources.txt_Travaux_TCE
    //      lblclim.Caption = Resources.txt_Climaticiens
    //      lblFort.Caption = Resources.txt_courant_fort
    //      lblFaible.Caption = Resources.txt_courant_faible
    //      lblTrav.Caption = Resources.col_plomberie
    //      lblMultitech.Caption = Resources.txt_Multitech
    //      lblSelectionTech.Text = Resources.txt_Selection
    //      sTypeTechAffiche = "CO"
    //      '  recherche des techniciens Monétique
    //      GetTechniciensSpe True, "N", "CO"
    //      lblInter.Visible = False
    //      cboInter.Visible = False
    //      cmdGoTech.Visible = False
    //      cmdTrajets.Visible = True
    //      cmdTrajets.Tag = 4
    //    Else
    //      LblLegCommerce.Caption = Resources.col_Commercial
    //      sTypeTechAffiche = Resources.txt_Tous
    //      '  recherche des techniciens
    //      GetTechniciens True, "N", True
    //      lblInter.Visible = True
    //      cboInter.Visible = True
    //      cmdGoTech.Visible = True
    //      cmdTrajets.Visible = False
    //      cmdTrajets.Tag = 0
    //    End If
    //    ' réinitialisation de l'affichage
    //    Call InitialiserPlanning
    //    
    //End Sub

    /* OK --------------------------------------------------------------------------------------- */
    private void CmdIndusMac_Click(object sender, EventArgs e)
    {
      if (LblIndusMac.Text == Resources.txt_IndusM)
      {
        LblIndusMac.Text = Resources.txt_Tous;
        lblSecondOeuvre.Text = Resources.txt_Travaux_TCE;
        LblIndusServices.Text = Resources.txt_IndusS;
        lblclim.Text = Resources.txt_Climaticiens;
        lblFort.Text = Resources.txt_courant_fort;
        lblFaible.Text = Resources.txt_courant_faible;
        lblTrav.Text = Resources.col_plomberie;
        lblMultitech.Text = Resources.txt_Multitech;
        lblMone.Text = Resources.txt_Ext_inc;
        lblSelectionTech.Text = Resources.txt_Selection;
        LblLegCommerce.Text = MZCtrlResources.Commercial;
        sTypeTechAffiche = Resources.txt_IndusS;
        // recherche des techniciens indus machine
        GetTechniciensSpe(true, "N", "IndusMac");
        lblInter.Visible = false;
        cboInter.Visible = false;
        cmdGoTech.Visible = false;
        cmdTrajets.Visible = true;
        cmdTrajets.Tag = 21;
      }
      else
      {
        LblIndusMac.Text = Resources.txt_IndusM;
        sTypeTechAffiche = Resources.txt_Tous;
        //  recherche des techniciens
        GetTechniciens(true, "N", true);
        lblInter.Visible = true;
        cboInter.Visible = true;
        cmdGoTech.Visible = true;
        cmdTrajets.Visible = false;
        cmdTrajets.Tag = 0;
      }
      // réinitialisation de l'affichage
      InitialiserPlanning();
    }
    //Private Sub CmdIndusMac_Click()
    //
    //On Error Resume Next
    //  rsT.Close ' fermeture du recordset des techs
    //  If LblIndusMac.Caption = Resources.txt_IndusM Then
    //    LblIndusMac.Caption = Resources.txt_Tous
    //    lblSecondOeuvre = Resources.txt_Travaux_TCE
    //    lblclim.Caption = Resources.txt_Climaticiens
    //    lblFort.Caption = Resources.txt_courant_fort
    //    lblFaible.Caption = Resources.txt_courant_faible
    //    lblTrav.Caption = Resources.col_plomberie
    //    lblMultitech.Caption = Resources.txt_Multitech
    //    lblMone.Caption = Resources.txt_Ext_inc
    //    lblSelectionTech.Text = Resources.txt_Selection
    //    sTypeTechAffiche = "§IndusSer§"
    //    '  recherche des techniciens courant faible
    //    GetTechniciensSpe True, "N", "IndusMac"
    //    lblInter.Visible = False
    //    cboInter.Visible = False
    //    cmdGoTech.Visible = False
    //    cmdTrajets.Visible = True
    //    cmdTrajets.Tag = 21
    //  Else
    //    LblIndusMac.Caption = Resources.txt_IndusM
    //    sTypeTechAffiche = Resources.txt_Tous
    //    '  recherche des techniciens
    //    GetTechniciens True, "N", True
    //    lblInter.Visible = True
    //    cboInter.Visible = True
    //    cmdGoTech.Visible = True
    //    cmdTrajets.Visible = False
    //    cmdTrajets.Tag = 0
    //  End If
    //  ' réinitialisation de l'affichage
    //  Call InitialiserPlanning
    //
    //End Sub

    /* OK --------------------------------------------------------------------------------------- */
    private void CmdMapsDIJour_Click(object sender, EventArgs e)
    {
      string lUrl = $"https://maps.emalec.com/CarteInterRayonByTech.asp?BASE=MULTI&APP={MozartParams.NomSociete}&NPERNUM={(sender as Button).Tag}";
      Process.Start(lUrl);
    }
    //Private Sub CmdMapsDIJour_Click(Index As Integer)
    //
    //    frmBrowser.StartingAddress = "http://maps.emalec.com/CarteInterRayonByTech.asp?BASE=MULTI&APP=" & gstrNomSociete & "&NPERNUM=" & lblTech(Index).Tag
    //    frmBrowser.Show vbModal
    //      
    //End Sub

    /* OK --------------------------------------------------------------------------------------- */
    private void CmdKms_Click(object sender, EventArgs e)
    {
      new frmKmsParcourusByPeriode((sender as Button).Tag, mdSemaine, mdSemaine.AddDays(6)).ShowDialog();
    }

    /* OK --------------------------------------------------------------------------------------- */
    private void allControls_DragEnter(object sender, DragEventArgs e)
    {
      e.Effect = DragDropEffects.Move;
    }

    /* OK --------------------------------------------------------------------------------------- */
    private void pic_Paint(object sender, PaintEventArgs e)
    {
      using (Font myFont = new Font("MS Sans Serif", 8))
        e.Graphics.DrawString(((sender as PictureBox).Tag as picTag).sInter, myFont, Brushes.Black, new Point(-1, 4));
    }

    /* OK --------------------------------------------------------------------------------------- */
    private void pic_MouseDown(object sender, MouseEventArgs e)
    {
      if (e.Button == MouseButtons.Left && e.Clicks == 1)
      {
        PictureBox pic = sender as PictureBox;
        pic.DoDragDrop(pic, DragDropEffects.Move);
      }
    }

    /* OK --------------------------------------------------------------------------------------- */
    private void cmdPlus_Paint(object sender, PaintEventArgs e)
    {
      Button b = sender as Button;
      using (Pen p = new Pen(Color.Black))
      {
        e.Graphics.DrawString("+", b.Font, p.Brush, new PointF((b.Width / 2) - 3, -3));
        //        e.Graphics.DrawRectangle(p, b.Left, b.Top, b.Width, b.Height);
      }
    }

    private void planifierUneAbsenceToolStripMenuItem_Click(object sender, EventArgs e)
    {
      new frmGestionAbsences
      {
        miNumPer = miNumTech,
        dDateDebut = mdSemaine,
      }.ShowDialog();

      // rafraichissement du planning
      InitialiserPlanning();

    }

    private void informationsUtilesToolStripMenuItem_Click(object sender, EventArgs e)
    {

      new frmPlan_Info_Utiles(miNumTech)
      {
      }.ShowDialog();

    }
  }
}