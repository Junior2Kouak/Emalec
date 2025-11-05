using MozartCS.Properties;
using MozartLib;
using MozartNet;
using MozartUC;
using ReportEmalec.Net;
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
  public partial class frmPlanTech : Form
  {
    public DateTime DebutSemaine;
    public string mlblTech = "";
    public int miNumTech;
    private int miNumAction;
    //private string strTypeEdition;
    int iNbrImage = 0;
    DateTime ddatejour;
    private int iNumIp;
    DataTable dtLun = new DataTable();
    DataTable dtMar = new DataTable();
    DataTable dtMer = new DataTable();
    DataTable dtJeu = new DataTable();
    DataTable dtVen = new DataTable();
    DataTable dtSam = new DataTable();
    DataTable dtDim = new DataTable();

    List<apiLabel> lstJours = new List<apiLabel>();
    List<apiLabel> lstHeures = new List<apiLabel>();
    List<PictureBox> lstPic = new List<PictureBox>();

    public frmPlanTech() { InitializeComponent(); }

    public void frmPlanTech_Load(object sender, System.EventArgs e)
    {
      try
      {
        Cursor.Current = Cursors.WaitCursor;
        ModuleMain.Initboutons(this);

        lstJours.Add(lJour0); lstJours.Add(lJour1); lstJours.Add(lJour2); lstJours.Add(lJour3); lstJours.Add(lJour4); lstJours.Add(lJour5); lstJours.Add(lJour6); lstJours.Add(lJour7);

        lstHeures.Add(lHeure0); lstHeures.Add(lHeure1); lstHeures.Add(lHeure2); lstHeures.Add(lHeure3); lstHeures.Add(lHeure4); lstHeures.Add(lHeure5);
        lstHeures.Add(lHeure6); lstHeures.Add(lHeure7); lstHeures.Add(lHeure8); lstHeures.Add(lHeure9); lstHeures.Add(lHeure10); lstHeures.Add(lHeure11);
        lstHeures.Add(lHeure12); lstHeures.Add(lHeure13); lstHeures.Add(lHeure14); lstHeures.Add(lHeure15); lstHeures.Add(lHeure16);

        lblTech.Text = mlblTech;

        InitPlanning();
      }
      catch (Exception ex)
      {
        MZUtils.displayError(MethodBase.GetCurrentMethod().Name, ex);
      }
      finally { Cursor.Current = Cursors.Default; }
    }

    private void InitPlanning()
    {
      foreach (PictureBox item in lstPic)
      {
        this.Controls.Remove(item);
        item.Dispose();
      }

      lstPic.Clear();

      InitDataTables();

      InitialiserPlanning(dtLun);
      InitialiserPlanning(dtMar);
      InitialiserPlanning(dtMer);
      InitialiserPlanning(dtJeu);
      InitialiserPlanning(dtVen);
      InitialiserPlanning(dtSam);
      InitialiserPlanning(dtDim);
    }
    //Private Sub InitRs()
    //Dim dDate As Date
    //Dim i As Integer
    //Dim j As Integer
    //
    //  For j = 0 To iNbrImage
    //    If j > 0 Then
    //      Unload pic(j)
    //    End If
    //  Next j
    // 
    //' on initialise tous les recordsets
    //  Set RSlun = New ADODB.Recordset
    //  Set RSmar = New ADODB.Recordset
    //  Set RSmer = New ADODB.Recordset
    //  Set RSjeu = New ADODB.Recordset
    //  Set RSven = New ADODB.Recordset
    //  Set RSsam = New ADODB.Recordset
    //  Set rsDim = New ADODB.Recordset
    //
    //  dDate = DebutSemaine
    //  RSlun.Open "api_sp_listeInterventions " & iNumTech & ", '" & dDate & "',0,20", cnx
    //  dDate = DateAdd("d", 1, dDate)
    //  RSmar.Open "api_sp_listeInterventions " & iNumTech & ", '" & dDate & "',0,20", cnx
    //  dDate = DateAdd("d", 1, dDate)
    //  RSmer.Open "api_sp_listeInterventions " & iNumTech & ", '" & dDate & "',0,20", cnx
    //  dDate = DateAdd("d", 1, dDate)
    //  RSjeu.Open "api_sp_listeInterventions " & iNumTech & ", '" & dDate & "',0,20", cnx
    //  dDate = DateAdd("d", 1, dDate)
    //  RSven.Open "api_sp_listeInterventions " & iNumTech & ", '" & dDate & "',0,20", cnx
    //  dDate = DateAdd("d", 1, dDate)
    //  RSsam.Open "api_sp_listeInterventions " & iNumTech & ", '" & dDate & "',0,20", cnx
    //  dDate = DateAdd("d", 1, dDate)
    //  rsDim.Open "api_sp_listeInterventions " & iNumTech & ", '" & dDate & "',0,20", cnx
    //  dDate = DateAdd("d", 1, dDate)
    //  
    //  
    //  'on affiche les jours
    //    ' affichage des jours de la semaine (prise en compte des congés)
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
    //End Sub
    //

    /* OK --------------------------------------------------------------------------------------- */
    private void InitialiserPlanning(DataTable dt)
    {
      try
      {
        int k = iNbrImage;

        DateTime datePla = new DateTime();

        //  Placement des interventions
        foreach (DataRow row in dt.Rows)
        {
          if (k >= 16 + iNbrImage)
            break;

          picTag myTag = new picTag();
          datePla = Convert.ToDateTime(row["DIPLDATJ"]);

          if ((int)row["NIPLIND"] > 4)
          {
            // Création d'une image
            k += 1;

            PictureBox pic = new PictureBox();

            // Coordonnées de l'image (pb avec le dimanche car son weekday = 0)
            pic.Left = lstJours[datePla.DayOfWeek == DayOfWeek.Sunday ? 6 : (int)datePla.DayOfWeek - 1].Left;
            pic.Top = lstHeures[(int)row["NIPLIND"] - 5].Top;
            pic.Size = pic0.Size;

            // Constitution du tag d'une IP (code, NumIP, NumSite, NumAction(null), text, duree, premierJ , tech)
            myTag.sTag = "D#";
            myTag.sTag += $"{row["NIPLNUM"]}#";
            myTag.sTag += $"{row["NSITNUM"]}#0#";
            myTag.sTag += $"{row["VCLINOM"]}\r\n";
            myTag.sTag += $"{row["VSITNOM"]}\r\n#";
            myTag.sTag += $"{Convert.ToInt32(row["NIPLDUR"])}#";
            myTag.sTag += $"{row["CIPLDEB"]}#";
            myTag.sTag += $"{row["NPERNUM"]}#";
            myTag.sTag += $"{Convert.ToDateTime(row["DIPLDATJ"]).ToShortDateString()}#";
            myTag.sTag += $"{row["CIPLMULT"]}#";
            myTag.sTag += $"{row["NIPLIND"]}";

            // Pour les sites emalec spéciaux couleur : jaune
            if (UtilsPlan.GetMozart_Soc_By_Site(Convert.ToInt32(row["NSITNUM"])) > 0)
              pic.BackColor = Color.Yellow;   // &HFFFF
            else
            {
              // couleur standard = bleu clair //&HFFFFC0
              pic.BackColor = Color.FromArgb(192, 255, 255);
              // si c'est la nuit :  rouge
              if (row["CACTNUIT"].ToString() == "O") pic.BackColor = Color.Red;
              // si c'est hors présence public :  rouge clair
              if (row["CACTNUIT"].ToString() == "P") pic.BackColor = Color.FromArgb(255, 192, 192);
              // si date d'execution : orange
              // si attachement (et exécution): vert
              using (SqlDataReader drCode = ModuleData.ExecuteReader($"exec api_sp_ControleDateExec_Attach {row["NIPLNUM"]}"))
              {
                if (drCode.Read())
                {
                  if (Convert.ToInt32(drCode[0]) == 0) pic.BackColor = Color.FromArgb(255, 193, 125); // RGB(255, 193, 125)
                  if (Convert.ToInt32(drCode[1]) == 0) pic.BackColor = Color.FromArgb(192, 255, 192); // &HC0FFC0
                }
              }
            }

            // Affichage des informations dans l'image
            myTag.sInter = $"{row["VCLINOM"]}\r\n{row["VSITNOM"]}\r\n{row["NIPLDURJ"]:0.##}h {row["sCODE"]} {UtilsPlan.ReturnCodePaveBloque(Convert.ToBoolean(row["BACTPAVEBLOCK"]))}";
            if (Convert.ToInt32(row["nbfact"]) > 0) myTag.sInter += $" €";
            if (Utils.ZeroIfNull(row["PrevMag"]) > 0) myTag.sInter += $" #";
            if (row["VACTHRRDV"].ToString() != "") myTag.sInter += $" RV {row["VACTHRRDV"]}";

            pic.Tag = myTag;

            pic.Paint += new PaintEventHandler(pic_Paint);
            pic.MouseUp += new MouseEventHandler(pic_MouseUp);
            pic.AllowDrop = true;
            pic.DragDrop += new DragEventHandler(pic_DragDrop);
            pic.DragOver += new DragEventHandler(pic_DragOver);
            pic.MouseDown += new MouseEventHandler(pic_MouseDown);

            Controls.Add(pic);
            lstPic.Add(pic);
          }
        }
        //  Nombre d'images chargées
        iNbrImage = k;
      }
      catch (Exception ex)
      {
        MessageBox.Show(string.Format("{0}{1}\r\n\r\n{2}{3}", Resources.msg_error_planning + "\r\n",
          ex.Message, MZCtrlResources.Global_dans, MethodBase.GetCurrentMethod().Name), MZCtrlResources.Global_erreur, MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
      }
    }
    //Private Sub InitialiserPlanning(rs As ADODB.Recordset)
    //Dim k As Integer
    //Dim inter As String
    //Dim apisTag As New ApiString
    //Dim dDateCourante As Date
    //Dim rsCode As ADODB.Recordset
    //
    //On Error GoTo handler
    //
    //  ' recherche du numéro de semaine
    //  'lblSemaine.Caption = "Semaine " & IIf(DatePart("yyyy", DebutSemaine) = 2005, DatePart("ww", DebutSemaine) - 1, DatePart("ww", DebutSemaine))
    //  'lblAnnee.Caption = "Année " & DatePart("yyyy", DebutSemaine)
    //  
    //  ' placement des interventions
    //  On Error Resume Next
    //  k = iNbrImage
    //  
    //  If Not rs.EOF Then dDateCourante = CDate(rs("DIPLDATJ"))
    //  
    //  While Not rs.EOF And k < 16 + iNbrImage
    //    If rs("NIPLIND") > 4 Then
    //      k = k + 1
    //      ' création d'une image
    //      Load pic(k)
    //  
    //      ' coordonnées de l'image ( pb avec le dimanche car son weekday = 1)
    //      pic(k).Left = lJour(IIf(Weekday(rs("DIPLDATJ")) = 1, 8, Weekday(rs("DIPLDATJ"))) - 2).X1
    //      pic(k).Top = lHeure(rs("NIPLIND") - 5).Y1
    //  
    //      'constitution du tag d'une IP ( code, NumIP, NumSite, NumAction(null), text, duree, premierJ , tech)
    //      apisTag.Text = ""
    //      apisTag.Cat "D#"
    //      apisTag.Cat rs("NIPLNUM"):      apisTag.Cat "#"
    //      apisTag.Cat rs("NSITNUM"):      apisTag.Cat "#0#"
    //      apisTag.Cat rs("VCLINOM"):      apisTag.Cat vbCrLf
    //      apisTag.Cat rs("VSITNOM"):      apisTag.Cat vbCrLf:      apisTag.Cat "#"
    //      apisTag.Cat rs("NIPLDUR"):      apisTag.Cat "#"
    //      apisTag.Cat rs("CIPLDEB"):      apisTag.Cat "#"
    //      apisTag.Cat rs("NPERNUM"):      apisTag.Cat "#"
    //      apisTag.Cat rs("DIPLDATJ"):     apisTag.Cat "#"
    //      apisTag.Cat rs("CIPLMULT"):     apisTag.Cat "#"
    //      apisTag.Cat rs("NIPLIND")
    //      pic(k).Tag = apisTag.Text
    //  
    //      ' pour les sites emalec spéciaux couleur : jaune
    //      If GetMozart_Soc_By_Site(rs("NSITNUM")) > 0 Then
    //          pic(k).BackColor = &HFFFF&
    //       Else
    //          'couleur standart = bleu clair
    //          pic(k).BackColor = &HFFFFC0
    //          ' si multi-jour : bleu foncé
    //          If rs("CIPLMULT") = "O" Then pic(k).BackColor = &HFFFF00
    //          ' si c'est la nuit :  rouge
    //          If rs("CACTNUIT") = "O" Then pic(k).BackColor = &HFF&
    //          ' si c'est hors présence public :  rouge claire
    //          If rs("CACTNUIT") = "P" Then pic(k).BackColor = &HC0C0FF
    //          ' si date d'execution : orange
    //          ' si attachement (et exécution): Vert
    //          Set rsCode = New ADODB.Recordset
    //          rsCode.Open "exec api_sp_ControleDateExec_Attach " & rs("NIPLNUM"), cnx
    //          If rsCode(0) = 0 Then pic(k).BackColor = RGB(255, 193, 125)
    //          If rsCode(1) = 0 Then pic(k).BackColor = &HC0FFC0
    //          rsCode.Close
    //          ' si facture, et exec, et attach : blanc
    //          If rs("nbfact") > 0 And (pic(k).BackColor = &HC0FFC0) Then pic(k).BackColor = &HFFFFFF
    //      End If
    //      ' affichage des informations dans l'image
    //      inter = rs("VCLINOM") & vbCrLf & rs("VSITNOM") & vbCrLf & " " & rs("NIPLDURJ") & "h  " & rs("sCODE") & " " & ReturnCodePaveBloque(rs("BACTPAVEBLOCK"))
    //    
    //      If rs("nbfact") > 0 Then inter = inter & "  €"
    //      If rs("PrevMag") > 0 Then inter = inter & "  #"
    //  
    //      If rs("VACTHRRDV") <> "" Then inter = inter & " RV " & rs("VACTHRRDV")
    //  
    //      ' si l'IP n'est pas la premiere d'un IP multi, il n'est pas possible de la deplacer
    //       'If rs("CIPLDEB") = "N" Then pic(k).DragMode = vbManual
    //  
    //      pic(k).Print inter
    //      pic(k).Visible = True
    //  
    //      dDateCourante = CDate(rs("DIPLDATJ"))
    //      ' enregistrement suivant
    //    End If
    //    rs.MoveNext
    //    
    //  Wend
    //  
    //  ' nombre d'images chargées
    //  iNbrImage = k
    //
    //  If Err <> 0 Then MsgBox "§Il y a eu une erreur lors de l'affichage du planning. Vous pouvez continuer et signaler ultérieurement cet incident au service informatique.§", vbInformation
    //
    //Exit Sub
    //Resume
    //handler:
    //  ShowError "InitialiserPlanning dans " & Me.Name
    //End Sub
    //

    /* OK --------------------------------------------------------------------------------------- */
    private void InitDataTables()
    {
      try
      {
        DateTime dDate = DebutSemaine;

        dtLun.Clear();
        dtLun.Load(ModuleData.ExecuteReader($"api_sp_listeInterventions {miNumTech}, '{dDate}', 0, 20"));
        UtilsPlan.TexteEtCouleurJour(Label10, dDate);
        dDate = dDate.AddDays(1);

        dtMar.Clear();
        dtMar.Load(ModuleData.ExecuteReader($"api_sp_listeInterventions {miNumTech}, '{dDate}', 0, 20"));
        UtilsPlan.TexteEtCouleurJour(Label11, dDate);
        dDate = dDate.AddDays(1);

        dtMer.Clear();
        dtMer.Load(ModuleData.ExecuteReader($"api_sp_listeInterventions {miNumTech}, '{dDate}', 0, 20"));
        UtilsPlan.TexteEtCouleurJour(Label12, dDate);
        dDate = dDate.AddDays(1);

        dtJeu.Clear();
        dtJeu.Load(ModuleData.ExecuteReader($"api_sp_listeInterventions {miNumTech}, '{dDate}', 0, 20"));
        UtilsPlan.TexteEtCouleurJour(Label13, dDate);
        dDate = dDate.AddDays(1);

        dtVen.Clear();
        dtVen.Load(ModuleData.ExecuteReader($"api_sp_listeInterventions {miNumTech}, '{dDate}', 0, 20"));
        UtilsPlan.TexteEtCouleurJour(Label14, dDate);
        dDate = dDate.AddDays(1);

        dtSam.Clear();
        dtSam.Load(ModuleData.ExecuteReader($"api_sp_listeInterventions {miNumTech}, '{dDate}', 0, 20"));
        UtilsPlan.TexteEtCouleurJour(Label15, dDate);
        dDate = dDate.AddDays(1);

        dtDim.Clear();
        dtDim.Load(ModuleData.ExecuteReader($"api_sp_listeInterventions {miNumTech}, '{dDate}', 0, 20"));
        UtilsPlan.TexteEtCouleurJour(Label16, dDate);
      }
      catch (Exception ex)
      {
        MZUtils.displayError(MethodBase.GetCurrentMethod().Name, ex);
      }
    }

    private void pic_Paint(object sender, PaintEventArgs e)
    {
      using (Font myFont = new Font("MS Sans Serif", 8))
        e.Graphics.DrawString(((sender as PictureBox).Tag as picTag).sInter, myFont, Brushes.Black, new Point(1, 2));
    }

    private void pic_MouseDown(object sender, MouseEventArgs e)
    {
      if (e.Button == MouseButtons.Left && e.Clicks == 1)
      {
        PictureBox pic = sender as PictureBox;
        pic.DoDragDrop(pic, DragDropEffects.Move);
      }
    }

    private void mnuDetails_Click(object sender, EventArgs e)
    {
      UtilsPlan.mnuDetails_Click(iNumIp);
      InitPlanning();
    }
    //Private Sub mnuDetails_Click()
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
    //    rsDroit.Open "SELECT count(*) FROM TDIN WITH (NOLOCK) INNER JOIN TAUT WITH (NOLOCK) ON  TDIN.NDINCTE = TAUT.NCANNUM " & _
    //             " INNER JOIN TPER WITH (NOLOCK) ON TAUT.NPERNUM = TPER.NPERNUM WHERE TPER.NPERNUM = " & gintUID & _
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
    //  Call Form_Load
    //  
    //End Sub

    /* OK --------------------------------------------------------------------------------------- */
    private void mnuEditionOT_Click(object sender, EventArgs e)
    {
      int iTechCourant = miNumTech;
      UtilsPlan.mnuEditionOTJour_Click(miNumTech, ddatejour.ToShortDateString(), iNumIp);
    }
    //Private Sub mnuEditionOT_Click()
    //  Me.MousePointer = vbHourglass
    //    
    //  frmPlan.iNumIp = iNumIp
    //  frmPlan.iNumTech = iNumTech
    //  frmPlan.iSite = iNumSite
    //  frmPlan.ddatejour = ddatejour
    //  frmPlan.strTypeEdition = "IP"
    //  Call frmPlan.mnuEditionOT_Click
    //   
    //  Me.MousePointer = vbDefault
    //  
    //End Sub

    //private void mnuFaxerOT_Click(object sender, EventArgs e)
    //{
    //  if (MyPrinter.SetDefaultPrinter("PDFCreator") == false)
    //  {
    //    MessageBox.Show(Resources.msg_imp_PDF_indispo, Program.AppTitle, MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
    //    return;
    //  }

    //  //  Bug : si pendant la génération des documents on clique sur une pic alors ca change le inumTech et on imprime les OT de qq1 d'autre
    //  int iTechCourant = miNumTech;   // on passe par une variable locale

    //  string[] myTab = (mnuAffichage.Tag as picTag).sTag.Split('#');

    //  // 2 cas :
    //  //  - impression de l'IP courante(OT + Gamme + Stock)
    //  //  - impression de toutes les IP de la semaine pour le tech (OT + Gamme + Stock)

    //  // si on est pas sur une IP on sort
    //  if (iNumIp == 0) return;

    //  UtilsPlan.SuppressionFichiersPDF(MozartParams.strUID);

    //  UtilsPlan.ImpressionOTtech(Convert.ToInt32(myTab[1]), iTechCourant);
    //}

    private void mnuSupprimerIP_Click(object sender, EventArgs e)
    {
      try
      {
        // si on est pas sur une IP on sort
        if (iNumIp == 0) return;

        //  Si l'action est exécutée, on ne peut pas la supprimer
        if (UtilsPlan.VerifAuto(iNumIp) == false) return;
        if (UtilsPlan.VerifDroits(iNumIp) == false) return;
        if (UtilsPlan.VerifBlocage(iNumIp) == false) return;

        // on ne peut pas supprimer si une personne est sur l'action en modification
        if (UtilsPlan.VerifLockAction(iNumIp) == false) return;

        // Confirmation de la suppression
        if (MessageBox.Show(Resources.msg_dde_suppr_planif, Program.AppTitle, MessageBoxButtons.YesNo, MessageBoxIcon.Question,
                            MessageBoxDefaultButton.Button2) == DialogResult.Yes)
          ModuleData.ExecuteNonQuery($"api_sp_SupprimerIP {iNumIp}, '{ddatejour}'");
        else
          return;

        // initialisation du planning
        InitPlanning();
      }
      catch (Exception ex)
      {
        MZUtils.displayError(MethodBase.GetCurrentMethod().Name, ex);
      }
    }

    private void mnuVisu_Click(object sender, EventArgs e)
    {
      try
      {
        // si on est pas sur une IP on sort
        if (iNumIp == 0) return;

        new frmMainReport
        {
          bLaunchByProcessStart = false,
          sTypeReport = ModuleMain.ChoixModelOTDevExpress(iNumIp),
          sIdentifiant = $"{iNumIp}",
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

    private void pic_DragOver(object sender, DragEventArgs e)
    {
      e.Effect = DragDropEffects.Move;
    }
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
        }
        else
        {
          //cas de déplacement d'une intervention (avec plusieurs actions)
          // -  on fait un update dans TACT du num IP et du technicien
          // -  on fait un update dans TIPL avec la somme des durées et création jours supp si nécessaire
          ModuleData.ExecuteNonQuery($"api_sp_ModificationIP_IP {myTabDest[1]}, {myTabSource[1]}, {myTabDest[7]}");
        }

        if (pic0.Visible)
          pic0.Visible = false;

        InitPlanning();   // réinitialisation de l'affichage
      }
      catch (Exception ex)
      {
        MZUtils.displayError(MethodBase.GetCurrentMethod().Name, ex);
      }
    }
    //Private Sub pic_DragDrop(Index As Integer, Source As Control, X As Single, Y As Single)
    //Dim MyTabPic
    //Dim MyTabSource
    //Dim strSQL As String
    //
    //  ' on veut poser sur une IP existante. on recherche les infos dans les tags
    //  MyTabPic = Split(pic(Index).Tag, "#")
    //  MyTabSource = Split(Source.Tag, "#")
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
    //  If Not frmPlan.CompteOK(MyTabPic(1), MyTabSource(1), MyTabSource(3)) Then
    //    MsgBox "§Les comptes analytiques sont différents§", vbInformation
    //    Exit Sub
    //  End If
    //  
    //  ' on fait un contrôle sur les durées des actions
    //  If (CDbl(MyTabPic(5)) + CDbl(MyTabSource(5))) > 10 And MyTabPic(9) = "N" Then
    //    Select Case MsgBox("§Vous allez créer une Intervention sur plusieurs jours§" & vbCrLf & "§Etez vous d'accord ?§", vbYesNo + vbQuestion + vbDefaultButton2)
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
    //  If Not frmPlan.Verifications(MyTabSource(1), MyTabSource(2), iNumTech, MyTabSource(3), IIf(MyTabPic(8) = MyTabSource(8), True, False), MyTabPic(8)) Then
    //    Source.Left = Left
    //    Source.Top = Top
    //    Exit Sub
    //  End If
    //
    //  ' cas de planification d'une nouvelle action
    //  If MyTabSource(0) = "N" Then
    //      '  -  on fait un update dans TACT avec le nouveau numéro d'action
    //      '  -  on fait un update dans TIPL avec la somme des durées et création jours supp si nécessaire
    //     ' modification de l'IP (NumIP,  action, TechDest)
    //      strSQL = MyTabPic(1) & "," & MyTabSource(3) & "," & iNumTech
    //      rs.Open "api_sp_ModificationIP_Action " & strSQL, cnx
    //  Else
    //  ' cas de déplacement d'une intervention ( avec plusieurs actions )
    //        '  -  on fait un update dans TACT du num IP et du technicien
    //        '  -  on fait un update dans TIPL avec la somme des durées et création jours supp si nécessaire
    //        ' modification de l'IP (NumIPpic,  NumIPsource, TechDest)
    //        strSQL = MyTabPic(1) & "," & MyTabSource(1) & "," & iNumTech
    //        rs.Open "api_sp_ModificationIP_IP " & strSQL, cnx
    //        
    //        ' on affiche les info de sorite de stock ou commande fournisseur
    //        ' uniquement si on change de date
    //'        If MyTabPic(8) <> MyTabSource(8) Then
    //'          frmPlan.RechercheInfoCdeFo (MyTabPic(1))
    //'        End If
    //  End If
    //  
    //  ' si c'est la pic(0), on la cache car on va réinitialiser le planning
    //  ' et l'IP serait affichée deux fois
    //  If Source.Index = 0 Then Source.Visible = False
    //
    //  Call Form_Load
    //End Sub
    //

    /* OK --------------------------------------------------------------------------------------- */
    private void form_DragEnter(object sender, DragEventArgs e)
    {
      e.Effect = DragDropEffects.Move;
    }

    /* OK --------------------------------------------------------------------------------------- */
    private void form_DragOver(object sender, DragEventArgs e)
    {
      e.Effect = DragDropEffects.All;
    }

    /* OK --------------------------------------------------------------------------------------- */
    private void form_DragDrop(object sender, DragEventArgs e)
    {
      try
      {
        int Top, Left;
        int indice = 0;
        string DatePla = "";
        int iTech;
        bool Out = true;

        PictureBox picSource = (PictureBox)e.Data.GetData(typeof(PictureBox));

        Point clientPoint = this.PointToClient(new Point(e.X, e.Y));

        //  Conservation de la position initiale
        Left = picSource.Left;
        Top = picSource.Top;

        //  Recherche des info dans le tag de l'image
        string[] myTab = (picSource.Tag as picTag).sTag.Split('#');

        iNumIp = Convert.ToInt32(myTab[1]);
        miNumAction = Convert.ToInt32(myTab[3]);

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
            iTech = miNumTech;
            indice = h + 5;
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
            DatePla = DebutSemaine.AddDays(j).ToShortDateString();
            picSource.Left = lstJours[j].Left;
            break;
          }
        }

        // test sur la date de sortie du technicien : on ne peut pas poser apres la date de sortie
        // date ou on pose : datepla
        // tech sur qui on pose : lblTech(iTech).Tag
        if (!ModMainPlanning3S.TestTechOK(miNumTech, Convert.ToDateTime(DatePla)))
        {
          MessageBox.Show(Resources.msg_planif_impossible_tech_date_sortie, Program.AppTitle, MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
          picSource.Left = Left;
          picSource.Top = Top;
          return;
        }

        //  test sur les 1/2 journées interdites des sites
        if (!ModMainPlanning3S.DemiJournee(Convert.ToInt32(myTab[2]), indice, DatePla))
        {
          MessageBox.Show(Resources.msg_planif_impossible_tech_demi_journee_interdite, Program.AppTitle, MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
          picSource.Left = Left;
          picSource.Top = Top;
          return;
        }

        //  Vérifications (déplacement d'une IP avec information au client, aide sur intervention, IP Emalec, action bloque)
        if (!UtilsPlan.Verifications(iNumIp, Convert.ToInt32(myTab[2]), miNumTech, miNumAction, myTab[8] == DatePla, DatePla))
        {
          picSource.Left = Left;
          picSource.Top = Top;
          return;
        }

        if ((int)ModuleData.ExecuteScalarInt($"SELECT COUNT(*) FROM TACT WITH (NOLOCK), TIPL WITH (NOLOCK) WHERE TACT.NIPLNUM = TIPL.NIPLNUM AND TACT.NPERNUM = {miNumTech} " +
                                             $"AND DIPLDATJ = '{DatePla}' AND NIPLIND = {indice}") > 0)
        {
          MessageBox.Show(Resources.txt_planning_change_refresh, Program.AppTitle, MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
          picSource.Left = Left;
          picSource.Top = Top;
          InitPlanning();
          return;
        }

        try
        {
          if (myTab[0] == "D" && myTab[9] == "O" && myTab[6] == "O")
          {
            // déplacement du premier jour d'une IP multi-jour d'une ip multi-jour
            if (MessageBox.Show(Resources.msg_attn_deplacement_1er_jour_IP + "\r\n" + Resources.msg_IP_deplacee_ok, Program.AppTitle,
                MessageBoxButtons.YesNo, MessageBoxIcon.Question, MessageBoxDefaultButton.Button2) == DialogResult.Yes)
            {
              using (SqlCommand cmd = new SqlCommand("api_sp_CreationIP", MozartDatabase.cnxMozart))
              {
                cmd.CommandType = CommandType.StoredProcedure;
                SqlCommandBuilder.DeriveParameters(cmd);

                cmd.Parameters["@iIP"].Value = iNumIp;
                cmd.Parameters["@iAction"].Value = myTab[3];
                cmd.Parameters["@pDate"].Value = DatePla;
                cmd.Parameters["@indice"].Value = indice;
                cmd.Parameters["@iTech"].Value = miNumTech;
                cmd.Parameters["@iDuree"].Value = myTab[5];
                cmd.Parameters["@AncDate"].Value = "01/01/1900";
                cmd.ExecuteNonQuery();
              }
            }
          }
          else if (myTab[0] == "D" && myTab[9] == "O" && myTab[6] == "N")
          {
            // déplacement d'un jour d'une multi-jour
            // si on change de tech pour une multi-jour : création d'une action
            using (SqlCommand cmd = new SqlCommand("api_sp_DeplacementIP", MozartDatabase.cnxMozart))
            {
              cmd.CommandType = CommandType.StoredProcedure;
              SqlCommandBuilder.DeriveParameters(cmd);

              cmd.Parameters["@iIP"].Value = iNumIp;
              cmd.Parameters["@pDate"].Value = DatePla;
              cmd.Parameters["@indice"].Value = indice;
              cmd.Parameters["@iTech"].Value = miNumTech;
              cmd.Parameters["@AncDate"].Value = myTab[8];
              cmd.ExecuteNonQuery();
            }
          }
          else
          {
            using (SqlCommand cmd = new SqlCommand("api_sp_CreationIP", MozartDatabase.cnxMozart))
            {
              cmd.CommandType = CommandType.StoredProcedure;
              SqlCommandBuilder.DeriveParameters(cmd);

              cmd.Parameters["@iIP"].Value = iNumIp;
              cmd.Parameters["@iAction"].Value = myTab[3];
              cmd.Parameters["@pDate"].Value = DatePla;
              cmd.Parameters["@indice"].Value = indice;
              cmd.Parameters["@iTech"].Value = miNumTech;
              cmd.Parameters["@iDuree"].Value = myTab[5];
              cmd.Parameters["@AncDate"].Value = myTab[8];
              cmd.ExecuteNonQuery();
            }
          }
        }
        catch (Exception ex)
        {
          MZUtils.displayError(MethodBase.GetCurrentMethod().Name, ex);
        }

        if (myTab[0] == "D")
        {
          // si on ne change pas de jour, il ne faut pas réinitialiser
          if (DatePla != myTab[8])
            ModuleData.ExecuteNonQuery($"update TACT set CACTINFOMAG ='N', VACTQUIINFO ='', VACTINFOQUI ='', DACTQUANDINFO = Null where NIPLNUM = {myTab[1]}");
        }

        InitPlanning();   // réinitialisation de l'affichage
      }
      catch (Exception ex)
      {
        MZUtils.displayError(MethodBase.GetCurrentMethod().Name, ex);
      }
    }
    //Private Sub Form_DragDrop(Source As Control, X As Single, Y As Single)
    //
    //Dim ado_cmd As New ADODB.Command
    //Dim j As Integer
    //Dim indice As Integer
    //Dim iTech As Integer
    //Dim datepla As String
    //Dim MyTab
    //Dim Out As Boolean
    //Dim h As Integer
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
    //  ' recherche des info dans le tag de l'image
    //  MyTab = Split(Source.Tag, "#")
    //
    //  ' test pour empecher de sortir du planning
    //  If X > lJour(7).X1 Then Exit Sub
    //  If X < lJour(0).X1 Then Exit Sub
    //  If Y > lHeure(16).Y1 Then Exit Sub
    //  If Y < lHeure(0).Y1 Then Exit Sub
    //    
    //  
    //  ' définition du technicien et de l'indice ou l'on pose
    //  For h = 15 To 0 Step -1
    //    If Y > lHeure(h).Y1 Then
    //      ' determiner le tech et l'indice
    //      iTech = iNumTech
    //      indice = h + 5
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
    //  If Not frmPlan.TestTechOK(iNumTech, datepla) Then
    //    MsgBox "§Impossible de planifier ce technicien à cette date(voir date de sortie de l'entreprise)§", vbInformation
    //    Source.Left = Left
    //    Source.Top = Top
    //    Exit Sub
    //  End If
    //
    //
    //  ' test sur les 1/2 journées interdites des sites
    //  If Not frmPlan.DemiJournee(MyTab(1), indice, datepla) Then
    //    MsgBox "§Impossible de planifier ce technicien à cette date (voir demi-journée interdite du site)§", vbInformation
    //    Source.Left = Left
    //    Source.Top = Top
    //    Exit Sub
    //  End If
    //
    //
    //  ' Vérifications (déplacement d'une IP avec information au client, aide sur intervention, IP Emalec, action bloque)
    //  If Not frmPlan.Verifications(MyTab(1), MyTab(2), iNumTech, MyTab(3), IIf(MyTab(8) = datepla, True, False), datepla) Then
    //    Source.Left = Left
    //    Source.Top = Top
    //    Exit Sub
    //  End If
    //  
    //'  AfficheInfoSite (Mytab(2))
    //  
    //  Dim sSQL As String
    //  Dim vRs As ADODB.Recordset
    //  sSQL = "SELECT COUNT(*) FROM TACT WITH (NOLOCK), TIPL WITH (NOLOCK) WHERE TACT.NIPLNUM = TIPL.NIPLNUM AND TACT.NPERNUM = " & iNumTech & " AND DIPLDATJ = '" & datepla & "' AND NIPLIND = " & indice
    //  Set vRs = cnx.Execute(sSQL)
    //  If vRs(0) > 0 Then
    //    MsgBox "§Le plannning a changé. Cette plage n'est plus disponible. Veuillez raffraichir le planning et recommencer§", vbExclamation
    //    Source.Left = Left
    //    Source.Top = Top
    //    Call Form_Load
    //    Exit Sub
    //  End If
    //  
    //  
    //  If MyTab(0) = "D" And MyTab(9) = "O" And MyTab(6) = "O" Then
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
    //        ado_cmd.Parameters("@iTech").value = iNumTech
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
    //        Set ado_cmd = Nothing
    //      
    //      Case vbNo
    //      
    //    End Select
    //
    //  ' déplacement d'un jour d'une multi-jour
    //  ' si on change de tech pour une multi-jour : création d'une action
    //  ElseIf MyTab(0) = "D" And MyTab(9) = "O" And MyTab(6) = "N" Then
    //      
    //      ' création d'une commande
    //      Set ado_cmd.ActiveConnection = cnx
    //      
    //      ' passage du nom de la procédure stockée
    //      ado_cmd.CommandText = "api_sp_DeplacementIP"
    //      ado_cmd.CommandType = adCmdStoredProc
    //      
    //      ' passage des paramètres
    //      ado_cmd.Parameters.Refresh
    //       
    //       ' liste des paramètres
    //      ado_cmd.Parameters("@iIP").value = MyTab(1)
    //      ado_cmd.Parameters("@pDate").value = datepla
    //      ado_cmd.Parameters("@indice").value = indice
    //      ado_cmd.Parameters("@iTech").value = iNumTech
    //      ado_cmd.Parameters("@AncDate").value = MyTab(8)
    //      
    //      ' exécuter la commande.
    //      ado_cmd.Execute
    //      
    //      If Err.Number <> -2147217873 And Err.Number <> 0 Then
    //        MsgBox "§Erreur : §" & Err.Description
    //      End If
    //      
    //      Set ado_cmd = Nothing
    //        
    //   Else
    //      
    //    On Error Resume Next
    //    
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
    //    ado_cmd.Parameters("@iTech").value = iNumTech
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
    //    Set ado_cmd = Nothing
    //    
    //    If MyTab(0) = "D" Then
    //      ' si on ne change pas de jour, il ne faut pas réinitialiser
    //      If datepla <> MyTab(8) Then
    //        cnx.Execute "update TACT set CACTINFOMAG='N', VACTQUIINFO='', VACTINFOQUI='', DACTQUANDINFO = Null where NIPLNUM = " & MyTab(1)
    //      End If
    //    End If
    //    
    //  End If
    //  
    //  ' si c'est la pic(0), on la cache car on va réinitialiser le planning
    //  ' et l'IP serait affichée deux fois
    //  If Source.Index = 0 Then Source.Visible = False
    //
    //  ' réinitialisation de l'affichage
    //  Call Form_Load
    //End Sub
    //

    /* OK --------------------------------------------------------------------------------------- */
    private void pic_MouseUp(object sender, MouseEventArgs e)
    {
      if (e.Button == MouseButtons.Right)
      {
        PictureBox pic = sender as PictureBox;

        string[] MyTabPic = (pic.Tag as picTag).sTag.Split('#');

        iNumIp = Convert.ToInt32(MyTabPic[1]);
        ddatejour = Convert.ToDateTime(MyTabPic[8]);

        mnuCP.Text = UtilsPlan.GetCodePostal(Convert.ToInt32(MyTabPic[2]));
        mnuCP.Visible = true;
        mnuVisu.Visible = true;
        mnuSupprimerIP.Visible = true;
        mnuDetails.Visible = true;

        // droit sur le bouton de blocage des pavés
        if (ModuleMain.RechercheDroitMenu(335))
        {
          // recherche si blocage ou pas actuellement et selon le cas, affichage de blocage ou déblocage
          mnuBlocagePave.Visible = true;
          UtilsPlan.EtatBlocage(iNumIp, ref mnuBlocagePave);
        }

        mnuAffichage.Tag = pic.Tag;
        mnuAffichage.Show(Cursor.Position);
      }
    }
    //Private Sub pic_MouseUp(Index As Integer, Button As Integer, Shift As Integer, X As Single, Y As Single)
    //Dim MyTabPic
    //
    //  ' recherche de l'IP dans le tag de l'image
    //  MyTabPic = Split(pic(Index).Tag, "#")
    //  
    // If Button = 2 Then
    //    iNumIp = MyTabPic(1)
    //    ddatejour = MyTabPic(8)
    //    iNumSite = MyTabPic(2)
    //    
    //    mnuCP.Caption = frmPlan.GetCodePostal(iNumSite)
    //    mnuCP.Visible = True
    //    mnuVisu.Visible = True
    //    mnuSupprimerIP.Visible = True
    //    mnuDetails.Visible = True
    //    ' droit sur le bouton de blocage des pavés
    //    If RechercheDroitMenu(gintUID, 335) Then
    //      ' recherche si blocage ou pas actuellement et selon le cas, affichage de blocage ou déblocage
    //      mnuBlocagePave.Visible = True
    //      EtatBlocage (iNumIp)
    //    End If
    //    PopupMenu mnuAffichage
    //  End If
    //End Sub
    //

    /* OK --------------------------------------------------------------------------------------- */
    private void mnuBlocagePave_Click(object sender, EventArgs e)
    {
      if (iNumIp == 0) return;

      UtilsPlan.BlocagePave(iNumIp, mnuBlocagePave.Tag.ToString());

      // rafraichissement planning
      InitPlanning();
    }

    private void mnuAffichage_Opening(object sender, System.ComponentModel.CancelEventArgs e)
    {

    }

    /* OK dans UtilsPlan --------------------------------------------------------------------------------------- */
    //Public Sub EtatBlocage(ByVal iNumIp As Long)
    //  Dim lRs As New ADODB.Recordset
    //  
    //On Error Resume Next
    //
    //  Set lRs = cnx.Execute("SELECT BACTPAVEBLOCK, isnull(VBLOCAGEPAVE,'') from TACT inner join TACTCOMP C on c.nactnum=tact.nactnum where NIPLNUM=" & iNumIp)
    //  If lRs.EOF Then
    //    mnuBlocagePave.Caption = "Blocage pavé"
    //    mnuBlocagePave.Tag = "D"
    //  Else
    //    If lRs(0) = True Then
    //      mnuBlocagePave.Caption = "Déblocage pavé : " & lRs(1)
    //      mnuBlocagePave.Tag = "B"
    //    Else
    //      mnuBlocagePave.Caption = "Blocage pavé : " & lRs(1)
    //      mnuBlocagePave.Tag = "D"
    //    End If
    //  End If
    //  lRs.Close
    //End Sub

  }
}