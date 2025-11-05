using MozartCS.Properties;
using MozartNet;
using MozartUC;
using System;
using System.Collections.Generic;
using System.Data;
using System.Drawing;
using System.Globalization;
using System.Linq;
using System.Reflection;
using System.Windows.Forms;
using MZUtils = MozartControls.Utils;

namespace MozartCS
{
  public partial class frmPlanTechVirtuel : Form
  {
    public DateTime DebutSemaine;
    public PictureBox _frmPlanPic0;

    private int iNbrImage = 0;

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

    //Public DebutSemaine As Date
    //Dim iNbrImage As Integer
    //
    //Dim RSlun As ADODB.Recordset
    //Dim RSmar As ADODB.Recordset
    //Dim RSmer As ADODB.Recordset
    //Dim RSjeu As ADODB.Recordset
    //Dim RSven As ADODB.Recordset
    //Dim RSsam As ADODB.Recordset
    //Dim rsDim As ADODB.Recordset

    public frmPlanTechVirtuel() { InitializeComponent(); }

    /* OK --------------------------------------------------------------------------------------- */
    private void frmPlanTechVirtuel_Load(object sender, System.EventArgs e)
    {
      try
      {
        Cursor.Current = Cursors.WaitCursor;
        ModuleMain.Initboutons(this);

        lstJours.Add(lJour0); lstJours.Add(lJour1); lstJours.Add(lJour2); lstJours.Add(lJour3); lstJours.Add(lJour4);
        lstJours.Add(lJour5); lstJours.Add(lJour6); lstJours.Add(lJour7);

        lstHeures.Add(lHeure0); lstHeures.Add(lHeure1); lstHeures.Add(lHeure2); lstHeures.Add(lHeure3); lstHeures.Add(lHeure4);
        lstHeures.Add(lHeure5); lstHeures.Add(lHeure6); lstHeures.Add(lHeure7); lstHeures.Add(lHeure8);

        InitPlanning();
      }
      catch (Exception ex)
      {
        MZUtils.displayError(MethodBase.GetCurrentMethod().Name, ex);
      }
      finally { Cursor.Current = Cursors.Default; }
    }
    //Private Sub Form_Load()
    //  
    //  InitBoutons Me, frmMenu
    //  
    //  InitRs
    //  iNbrImage = 0
    //  InitialiserPlanning RSlun
    //  InitialiserPlanning RSmar
    //  InitialiserPlanning RSmer
    //  InitialiserPlanning RSjeu
    //  InitialiserPlanning RSven
    //  InitialiserPlanning RSsam
    //  InitialiserPlanning rsDim
    //End Sub

    /* OK --------------------------------------------------------------------------------------- */
    private void InitPlanning()
    {
      foreach (PictureBox item in lstPic)
      {
        this.Controls.Remove(item);
        item.Dispose();
      }

      lstPic.Clear();

      InitDataTables();

      InitialiserPlannings();
    }

    /* OK --------------------------------------------------------------------------------------- */
    private void InitialiserPlannings()
    {
      lstPic.Clear();
      iNbrImage = 0;

      InitialiserPlanning(dtLun);
      InitialiserPlanning(dtMar);
      InitialiserPlanning(dtMer);
      InitialiserPlanning(dtJeu);
      InitialiserPlanning(dtVen);
      InitialiserPlanning(dtSam);
      InitialiserPlanning(dtDim);
    }

    /* OK --------------------------------------------------------------------------------------- */
    public void cmdFermer_Click(object sender, System.EventArgs e)
    {
      if (pic0.Visible)
        _frmPlanPic0.Visible = true;
      Dispose();
    }
    //Private Sub cmdFermer_Click()
    //  If pic(0).Visible Then
    //    frmPlan.pic(0).Visible = True
    //  End If
    //  
    //  Unload Me
    //End Sub

    /* Inutile --------------------------------------------------------------------------------------- */
    //Private Sub Form_Unload(Cancel As Integer)
    //  
    //  iNbrImage = 0
    //
    //  RSlun.Close
    //  RSmar.Close
    //  RSmer.Close
    //  RSjeu.Close
    //  RSven.Close
    //  RSsam.Close
    //  rsDim.Close
    //End Sub

    /* OK --------------------------------------------------------------------------------------- */
    private void InitDataTables()
    {
      try
      {
        DateTime dDate = DebutSemaine;

        dtLun.Clear();
        // TESTS_ONLY
        dtLun.Load(ModuleData.ExecuteReader("[api_sp_listeInterventions] 1096, '01/07/2019', 6, 12"));
        //dtLun.Load(ModuleData.ExecuteReader($"api_sp_listeInterventions 8, '{dDate}', 0, 8"));
        TexteEtCouleurJour(Label10, dDate);
        dDate = dDate.AddDays(1);

        dtMar.Clear();
        dtMar.Load(ModuleData.ExecuteReader("[api_sp_listeInterventions] 1096, '01/07/2019', 6, 12"));
        //dtMar.Load(ModuleData.ExecuteReader($"api_sp_listeInterventions 8, '{dDate}', 0, 8"));
        TexteEtCouleurJour(Label11, dDate);
        dDate = dDate.AddDays(1);

        dtMer.Clear();
        dtMer.Load(ModuleData.ExecuteReader("[api_sp_listeInterventions] 1096, '01/07/2019', 6, 12"));
        //dtMer.Load(ModuleData.ExecuteReader($"api_sp_listeInterventions 8, '{dDate}', 0, 8"));
        TexteEtCouleurJour(Label12, dDate);
        dDate = dDate.AddDays(1);

        dtJeu.Clear();
        dtJeu.Load(ModuleData.ExecuteReader("[api_sp_listeInterventions] 1096, '01/07/2019', 6, 12"));
        //dtJeu.Load(ModuleData.ExecuteReader($"api_sp_listeInterventions 8, '{dDate}', 0, 8"));
        TexteEtCouleurJour(Label13, dDate);
        dDate = dDate.AddDays(1);

        dtVen.Clear();
        dtVen.Load(ModuleData.ExecuteReader($"api_sp_listeInterventions 8, '{dDate}', 0, 20"));
        TexteEtCouleurJour(Label14, dDate);
        dDate = dDate.AddDays(1);

        dtSam.Clear();
        dtSam.Load(ModuleData.ExecuteReader($"api_sp_listeInterventions 8, '{dDate}', 0, 8"));
        TexteEtCouleurJour(Label15, dDate);
        dDate = dDate.AddDays(1);

        dtDim.Clear();
        dtDim.Load(ModuleData.ExecuteReader($"api_sp_listeInterventionsST 8, '{dDate}', 0, 8"));
        TexteEtCouleurJour(Label16, dDate);
      }
      catch (Exception ex)
      {
        MZUtils.displayError(MethodBase.GetCurrentMethod().Name, ex);
      }
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
    //  RSlun.Open "api_sp_listeInterventions 10, '" & dDate & "',0,8", cnx
    //  dDate = DateAdd("d", 1, dDate)
    //  RSmar.Open "api_sp_listeInterventions 10, '" & dDate & "',0,8", cnx
    //  dDate = DateAdd("d", 1, dDate)
    //  RSmer.Open "api_sp_listeInterventions 10, '" & dDate & "',0,8", cnx
    //  dDate = DateAdd("d", 1, dDate)
    //  RSjeu.Open "api_sp_listeInterventions 10, '" & dDate & "',0,8", cnx
    //  dDate = DateAdd("d", 1, dDate)
    //  RSven.Open "api_sp_listeInterventions 10, '" & dDate & "',0,8", cnx
    //  dDate = DateAdd("d", 1, dDate)
    //  RSsam.Open "api_sp_listeInterventions 10, '" & dDate & "',0,8", cnx
    //  dDate = DateAdd("d", 1, dDate)
    //  rsDim.Open "api_sp_listeInterventions 10, '" & dDate & "',0,8", cnx
    //  dDate = DateAdd("d", 1, dDate)
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

    /* OK --------------------------------------------------------------------------------------- */
    private void TexteEtCouleurJour(apiLabel label, DateTime dDate)
    {
      //  Affichage des jours de la semaine (prise en compte des congés)
      //  For i = 0 To 6
      label.Text = dDate.ToString("dddd d MMM", CultureInfo.CurrentUICulture);
      if (ModuleMain.IsFeriee(dDate))
        label.BackColor = Color.Red;
      else
      {
        if (dDate.DayOfWeek == DayOfWeek.Saturday || dDate.DayOfWeek == DayOfWeek.Sunday)
          label.BackColor = Color.White;
        else
          label.BackColor = Color.LightBlue;
      }
    }

    /* OK --------------------------------------------------------------------------------------- */
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
                Convert.ToInt32(myTabSource[3]), myTabDest[8] == myTabSource[8] ? true : false))
        {
          picSource.Left = Left;
          picSource.Top = Top;
          return;
        }

        ModuleData.ExecuteNonQuery($"api_sp_ModificationIP_Action {myTabDest[1]},{myTabSource[3]},{myTabDest[7]}");

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
    //  If Not frmPlan.Verifications(MyTabSource(1), MyTabSource(2), MyTabPic(7), MyTabSource(3), IIf(MyTabSource(8) = MyTabPic(8), True, False)) Then
    //    Source.Left = Left
    //    Source.Top = Top
    //    Exit Sub
    //  End If
    //
    //  strSQL = MyTabPic(1) & "," & MyTabSource(3) & "," & MyTabPic(7)
    //  rs.Open "api_sp_ModificationIP_Action " & strSQL, cnx
    //  
    //  ' si c'est la pic(0), on la cache car on va réinitialiser le planning
    //  ' et l'IP serait affichée deux fois
    //  If Source.Index = 0 Then Source.Visible = False
    //
    //  ' initialisation de l'affichage
    //  Call Form_Load
    //
    //End Sub

    private void pic_MouseDown(object sender, MouseEventArgs e)
    {
      if (e.Button == MouseButtons.Left && e.Clicks == 1)
      {
        PictureBox pic = sender as PictureBox;
        pic.DoDragDrop(pic, DragDropEffects.Move);
      }
    }

    /* OK --------------------------------------------------------------------------------------- */
    private void InitialiserPlanning(DataTable dt)
    {
      try
      {
        int k = iNbrImage;
        int iNbIpJour = 0;
        DateTime datePla = new DateTime();

        if (dt.Rows.Count > 0)
          datePla = Convert.ToDateTime(dt.Rows[0]["DIPLDATJ"]);

        //  Placement des interventions
        foreach (DataRow row in dt.AsEnumerable().Skip(iNbrImage).Take(8))
        {
          //if (k < 8 + iNbrImage)
          //  break;

          if (datePla != Convert.ToDateTime(row["DIPLDATJ"]))
            iNbIpJour = 1;
          else
            iNbIpJour += 1;

          // Création d'une image
          k += 1;

          PictureBox pic = new PictureBox();

          //      Coordonnées de l'image (pb avec le dimanche car son weekday = 0)
          pic.Left = lstJours[datePla.DayOfWeek == DayOfWeek.Sunday ? 6 : (int)datePla.DayOfWeek - 1].Left;
          pic.Top = lstHeures[iNbIpJour - 1].Top;
          pic.Size = pic0.Size;

          // Constitution du tag d'une IP (code, NumIP, NumSite, NumAction(null), text, duree, premierJ , tech)
          picTag myTag = new picTag();
          myTag.sTag = "D#";
          myTag.sTag += $"{row["NIPLNUM"]}#";
          myTag.sTag += $"{row["NSITNUM"]}#0#";
          myTag.sTag += $"{row["VCLINOM"]}\r\n";
          myTag.sTag += $"{row["VSITNOM"]}\r\n#";
          myTag.sTag += $"{row["NIPLDUR"]}#";
          myTag.sTag += $"{row["CIPLDEB"]}#";
          myTag.sTag += $"10#";
          myTag.sTag += $"{datePla.ToShortDateString()}#";
          myTag.sTag += $"{row["CIPLMULT"]}#";
          myTag.sTag += $"{row["NIPLIND"]}";

          // Pour les sites emalec spéciaux couleur : jaune
          if (Utils.GetMozart_Soc_By_Site(Convert.ToInt32(row["NSITNUM"])) > 0)
            pic.BackColor = Color.Yellow;   // &HFFFF &
          else
          {
            // couleur standard = bleu clair
            pic.BackColor = Color.FromArgb(192, 255, 255);  //&HFFFFC0

            // si multi-jour : bleu foncé
            if (row["CIPLMULT"].ToString() == "O") pic.BackColor = Color.DarkBlue;

            //  si c'est la nuit :  rouge
            if (row["CACTNUIT"].ToString() == "O") pic.BackColor = Color.Red;

            // si c'est hors présence public :  rouge claire
            if (row["CACTNUIT"].ToString() == "P") pic.BackColor = Color.FromArgb(255, 192, 192);
            // si date d'execution : orange
          }

          // Affichage des informations dans l'image
          myTag.sInter = $"{row["VCLINOM"]}\r\n{row["VSITNOM"]}\r\n {Convert.ToInt32(row["NIPLDURJ"])}h  {row["sCODE"]}";

          if (Convert.ToInt32(row["nbfact"]) > 0) myTag.sInter += "  €";
          if (Convert.ToInt32(row["PrevMag"]) > 0) myTag.sInter += "  #";

          pic.Tag = myTag;

          pic.Paint += new PaintEventHandler(pic_Paint);

          // si l'IP n'est pas la premiere d'un IP multi, il n'est pas possible de la deplacer
          if (row["CIPLDEB"].ToString() != "N")
          {
            pic.DragDrop += new DragEventHandler(pic_DragDrop);
            pic.MouseDown += new MouseEventHandler(pic_MouseDown);
          }

          Controls.Add(pic);
          lstPic.Add(pic);

          datePla = Convert.ToDateTime(row["DIPLDATJ"]);

        }
        //  Nombre d'images chargées
        iNbrImage = k;
      }
      catch (Exception ex)
      {
        MessageBox.Show(string.Format("{0}{1}\r\n\r\n{2}{3}", Resources.msg_error_planning + "\r\n",
          ex.Message, Resources.Global_dans, MethodBase.GetCurrentMethod().Name), Resources.Global_Erreur, MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
      }
    }
    //Private Sub InitialiserPlanning(rs As ADODB.Recordset)
    //Dim k As Integer
    //Dim iNbIpJour As Integer
    //Dim inter As String
    //Dim apisTag As New ApiString
    //Dim dDateCourante As Date
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
    //  While Not rs.EOF And k < 8 + iNbrImage
    //    
    //    k = k + 1
    //    ' création d'une image
    //    Load pic(k)
    //    
    //    If CDate(rs("DIPLDATJ")) <> dDateCourante Then
    //      iNbIpJour = 1
    //    Else
    //      iNbIpJour = iNbIpJour + 1
    //    End If
    //
    //    ' coordonnées de l'image ( pb avec le dimanche car son weekday = 1)
    //    pic(k).Left = lJour(IIf(Weekday(rs("DIPLDATJ")) = 1, 8, Weekday(rs("DIPLDATJ"))) - 2).X1
    //    pic(k).Top = lHeure(iNbIpJour - 1).Y1
    //    'pic(k).Top = lHeure(IIf(k > 8, k - (8 * IIf((rs.AbsolutePosition Mod 8) = 0, (rs.AbsolutePosition \ 8) - 1, (rs.AbsolutePosition \ 8))), CInt(rs("NIPLIND"))) - 1).Y1
    //'CInt(rs("NIPLIND"))
    //    ' constitution du tag d'une IP ( code, NumIP, NumSite, NumAction(null), text, duree, premierJ , tech)
    //    apisTag.Text = ""
    //    apisTag.Cat "D#"
    //    apisTag.Cat rs("NIPLNUM"):      apisTag.Cat "#"
    //    apisTag.Cat rs("NSITNUM"):      apisTag.Cat "#0#"
    //    apisTag.Cat rs("VCLINOM"):      apisTag.Cat vbCrLf
    //    apisTag.Cat rs("VSITNOM"):      apisTag.Cat vbCrLf:      apisTag.Cat "#"
    //    apisTag.Cat rs("NIPLDUR"):      apisTag.Cat "#"
    //    apisTag.Cat rs("CIPLDEB"):      apisTag.Cat "#"
    //    apisTag.Cat "10":     apisTag.Cat "#"
    //    apisTag.Cat rs("DIPLDATJ"):     apisTag.Cat "#"
    //    apisTag.Cat rs("CIPLMULT"):     apisTag.Cat "#"
    //    apisTag.Cat rs("NIPLIND")
    //    pic(k).Tag = apisTag.Text
    //
    //    ' pour les sites emalec spéciaux couleur : jaune
    //    If GetMozart_Soc_By_Site(rs("NSITNUM")) > 0 Then
    //        pic(k).BackColor = &HFFFF&
    //     Else
    //        'couleur standart = bleu clair
    //        pic(k).BackColor = &HFFFFC0
    //
    //        ' si multi-jour : bleu foncé
    //        If rs("CIPLMULT") = "O" Then pic(k).BackColor = &HFFFF00
    //
    //        ' si c'est la nuit :  rouge
    //        If rs("CACTNUIT") = "O" Then pic(k).BackColor = &HFF&
    //
    //        ' si c'est hors présence public :  rouge claire
    //        If rs("CACTNUIT") = "P" Then pic(k).BackColor = &HC0C0FF
    //
    //    End If
    //
    //    ' affichage des informations dans l'image
    //    inter = rs("VCLINOM") & vbCrLf & rs("VSITNOM") & vbCrLf & " " & rs("NIPLDURJ") & "h  " & rs("sCODE")
    //    '& " " & rs("VTYPECONTRAT")
    //
    //    If rs("nbfact") > 0 Then inter = inter & "  €"
    //    If rs("PrevMag") > 0 Then inter = inter & "  #"
    //
    //    ' si l'IP n'est pas la premiere d'un IP multi, il n'est pas possible de la deplacer
    //    
    //    If rs("CIPLDEB") = "N" Then pic(k).DragMode = vbManual
    //
    //    pic(k).Print inter
    //    pic(k).Visible = True
    //
    //    dDateCourante = CDate(rs("DIPLDATJ"))
    //
    //    ' enregistrement suivant
    //    rs.MoveNext
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

    private void pic_Paint(object sender, PaintEventArgs e)
    {
      using (Font myFont = new Font("MS Sans Serif", 8))
        e.Graphics.DrawString(((sender as PictureBox).Tag as picTag).sInter, myFont, Brushes.Black, new Point(1, 2));
    }

    /* OK --------------------------------------------------------------------------------------- */
    private void cmdPrecedent_Click(object sender, EventArgs e)
    {
      InitialiserPlannings();
    }
    //Private Sub cmdPrecedent_Click()
    //Dim i As Integer
    //  
    //  ' on décharge les images
    //  For i = 1 To iNbrImage
    //    Unload pic(i)
    //  Next
    //  iNbrImage = 0
    //  
    //  If RSlun.RecordCount > 0 Then RSlun.MoveFirst
    //  If RSmar.RecordCount > 0 Then RSmar.MoveFirst
    //  If RSmer.RecordCount > 0 Then RSmer.MoveFirst
    //  If RSjeu.RecordCount > 0 Then RSjeu.MoveFirst
    //  If RSven.RecordCount > 0 Then RSven.MoveFirst
    //  If RSsam.RecordCount > 0 Then RSsam.MoveFirst
    //  If rsDim.RecordCount > 0 Then rsDim.MoveFirst
    //        
    //  InitialiserPlanning RSlun
    //  InitialiserPlanning RSmar
    //  InitialiserPlanning RSmer
    //  InitialiserPlanning RSjeu
    //  InitialiserPlanning RSven
    //  InitialiserPlanning RSsam
    //  InitialiserPlanning rsDim
    //End Sub

    /* OK --------------------------------------------------------------------------------------- */
    private void cmdSuivant_Click(object sender, EventArgs e)
    {
      InitialiserPlannings();
    }
    //Private Sub cmdSuivant_Click()
    //Dim i As Integer
    //
    //  ' on décharge les images
    //  For i = 1 To iNbrImage
    //    Unload pic(i)
    //  Next
    //  iNbrImage = 0
    //    
    //  InitialiserPlanning RSlun
    //  InitialiserPlanning RSmar
    //  InitialiserPlanning RSmer
    //  InitialiserPlanning RSjeu
    //  InitialiserPlanning RSven
    //  InitialiserPlanning RSsam
    //  InitialiserPlanning rsDim
    //End Sub
  }
}