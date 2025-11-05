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
using System.Globalization;
using System.Reflection;
using System.Text;
using System.Windows.Forms;
using MZUtils = MozartControls.Utils;

namespace MozartCS
{
  public partial class frmPlanSimple : Form
  {
    public DateTime mdSemaine;
    public int miNumSite;
    public int miNumTech;
    public int miNumIP;
    public double miDuree;
    public string mstrTagIP;
    public string mstrStatutIP;

    List<apiLabel> lstPic = new List<apiLabel>();

    DateTime debutSemaine;
    int iSite;
    int iNumIp;
    int iNumTech;
    //int nbrTechnicien;
    //string sTypeTechAffiche;
    //int iNbrImage; // nombre d'images chargées dans le planning

    //Public mdSemaine As Date
    //Public mStrStatutIP As String
    //Public miNumSite As Long
    //Public miNumTech As Long
    //Public miNumIP As Long
    //Public miDuree As Double
    //Public mStrTagIP As String
    //
    //Dim rsT As New ADODB.Recordset
    //Dim rs As New ADODB.Recordset
    //
    //Dim DebutSemaine As Date
    //
    //Dim iNumIp As Long
    //Dim iNumTech As Long
    //Dim strTypeEdition As String
    //Dim iSite As Long
    //
    //Dim nbrTechnicien As Integer
    //Dim ddatejour As String
    //Dim sTypeTechAffiche As String
    //
    //Dim iNbrImage As Integer      ' nombre d'images chargées dans le planning

    public frmPlanSimple() { InitializeComponent(); }

    /* OK --------------------------------------------------------------*/
    private void frmPlanSimple_Load(object sender, System.EventArgs e)
    {
      try
      {
        Cursor.Current = Cursors.WaitCursor;
        ModuleMain.Initboutons(this);

        //menu avec traduction
        mnuDetails.Text = Resources.txt_detailsInter;
        mnuVisu.Text = Resources.txt_visuOT;
        mnuMoisTech.Text = Resources.txt_planningTech;

        //sTypeTechAffiche = Resources.cboCteAna;
        //iNbrImage = 0;
        mdSemaine = DateTime.Today;

        if (mstrStatutIP == "C")
        {
          //constitution du tag d'une nouvelle IP (Code, NumIP(null), NumSite, NumAction, text, DuréeAction, PremierJ , tech, Jour, Multi)
          pic0.Tag = $"N#0#{miNumSite}#{MozartParams.NumAction}#{mstrTagIP}#{miDuree}#N#0##N";
          pic0.Text = $"{mstrTagIP}{miDuree}heures";
          pic0.Visible = true;

          //affichage du planning en création
          InitialiserPlanning();
        }
        else if (mstrStatutIP == "IP")
        {
          //constitution du tag d'une nouvelle IP (Code, NumIP(null), NumSite, NumAction, text, DuréeAction, PremierJ , tech, Jour, Multi)
          pic0.Tag = $"D#{miNumIP}#{miNumSite}#0#{mstrTagIP}#{miDuree}#O#0#01/01/1900#N";
          pic0.Text = $"{mstrTagIP}{miDuree}heures";
          pic0.Visible = true;

          InitialiserPlanning();
        }
        else
        {
          pic0.Visible = false;
          GetTechniciens(true, "N", true);

          // affichage du planning en modification
          InitialiserPlanning();
        }

        Cursor = Cursors.Default;
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
    //  sTypeTechAffiche = "§Tous§"
    //  iNbrImage = 0
    //  
    //  If Me.mStrStatutIP = "C" Then
    //  
    //    ' constitution du tag d'une nouvelle IP ( code, NumIP(null), NumSite, NumAction, text, DuréeAction, PremierJ , tech, Jour, Multi)
    //    pic(0).Tag = "N#0#" & miNumSite & "#" & glNumAction & "#" & mStrTagIP & "#" & miDuree & "#N#0##N"
    //    pic(0).Print Me.mStrTagIP & miDuree & "heures"
    //    pic(0).Visible = True
    //    
    //    ' affichage du planning en création
    //    Call InitialiserPlanning
    //  
    //  ElseIf Me.mStrStatutIP = "IP" Then
    //    
    //    ' constitution du tag d'une nouvelle IP ( code, NumIP(null), NumSite, NumAction, text, DuréeAction, PremierJ , tech, Jour, Multi)
    //    pic(0).Tag = "D#" & miNumIP & "#" & miNumSite & "#0#" & mStrTagIP & "#" & miDuree & "#O#0#01/01/1900#N"
    //    pic(0).Print Me.mStrTagIP & miDuree & "heures"
    //    pic(0).Visible = True
    //    
    //    ' afifchage du planning en modification
    //    Call InitialiserPlanning
    //    
    //  Else
    //    pic(0).Visible = False
    //    GetTechniciens True, "N", True
    //    
    //    ' affichage du planning en modification
    //    Call InitialiserPlanning
    //  End If
    //  Screen.MousePointer = vbDefault
    //  
    //Exit Sub
    //handler:
    //  Screen.MousePointer = vbDefault
    //  ShowError "Form_Load dans " & Me.Name
    //End Sub


    /* OK --------------------------------------------------------------*/
    private void cmdFermer_Click(object sender, System.EventArgs e)
    {
      Dispose();
    }
    //Private Sub cmdFermer_Click()
    //  Unload Me
    //End Sub


    /* OK --------------------------------------------------------------------------------------- */
    private void Calendrier_CloseUp(object sender, EventArgs e)
    {
      int iTemp = (int)Calendrier.Value.DayOfWeek == 1 ? 8 : (int)Calendrier.Value.DayOfWeek - 2;
      mdSemaine = Calendrier.Value.AddDays(-iTemp);
      Calendrier.Visible = false;
      InitialiserPlanning();
    }
    //Private Sub Calendrier_Click()
    //
    //  Me.mdSemaine = Format(DateAdd("d", -(IIf(Weekday(CDate(Calendrier)) = 1, 8, Weekday(CDate(Calendrier))) - 2), CDate(Calendrier)), "dd/mm/yyyy")
    //  Calendrier.Visible = False
    //  Call InitialiserPlanning
    //  
    //End Sub

    /* OK --------------------------------------------------------------------------------------- */
    private void cmdCalendrier_Click(object sender, EventArgs e)
    {
      Calendrier.Value = debutSemaine;
      Calendrier.Visible = !Calendrier.Visible;
      Calendrier.ShowCalendar(new MouseEventArgs(MouseButtons.Left, 1, MousePosition.X, MousePosition.Y, 0));
    }

    private void GetTechniciens(bool bPremierFois, string sDirection, bool bFindTech)
    {
      //recherche du technicien
      using (SqlDataReader sdr = ModuleData.ExecuteReader($"select * from api_v_listeTechniciensArch where npernum = {miNumTech}"))
      {
        DataTable dt = new DataTable();
        dt.Load(sdr);
        //nbrTechnicien = dt.Rows.Count;

        if (dt.Rows.Count > 0)
        {
          lblTech.Text = dt.Rows[0]["VPERNOM"].ToString();
          lblTech.Tag = dt.Rows[0]["NPERNUM"].ToString();
          lblInfo0.Text = $"{dt.Rows[0]["VSERLIB"]}\n\r{dt.Rows[0]["VREGLIB"]}";
        }
      }
    }

    private void cmdLegende_Click(object sender, EventArgs e)
    {
      new frmLegende().ShowDialog();
    }

    private void InitialiserPlanning(long iCacherIP = 0)
    {
      StringBuilder sb = new StringBuilder("");

      try
      {
        // fonction qui donne le premier jour de la semaine (lundi)
        DateTime dateTmp = mdSemaine.AddDays(-((int)DateTime.Now.DayOfWeek) + 1);
        debutSemaine = mdSemaine.AddDays(-((int)mdSemaine.DayOfWeek) + 1);

        //recherche du numéro de semaine
        lblSemaine.Text = $"{Resources.col_Semaine} {ModuleMain.WeekNumber(debutSemaine)}";
        lblAnnee.Text = $"{Resources.col_annee} {debutSemaine.Year}";

        // affichage des jours de la semaine (prise en compte des congés)
        lblLundi.Text = debutSemaine.AddDays(0).ToString("dddd d MMMM", CultureInfo.CurrentUICulture);
        lblMardi.Text = debutSemaine.AddDays(1).ToString("dddd d MMMM", CultureInfo.CurrentUICulture);
        lblMercredi.Text = debutSemaine.AddDays(2).ToString("dddd d MMMM", CultureInfo.CurrentUICulture);
        lblJeudi.Text = debutSemaine.AddDays(3).ToString("dddd d MMMM", CultureInfo.CurrentUICulture);
        lblVendredi.Text = debutSemaine.AddDays(4).ToString("dddd d MMMM", CultureInfo.CurrentUICulture);
        lblSamedi.Text = debutSemaine.AddDays(5).ToString("dddd d MMMM", CultureInfo.CurrentUICulture);
        lblDimanche.Text = debutSemaine.AddDays(6).ToString("dddd d MMMM", CultureInfo.CurrentUICulture);

        for (int i = 0; i <= 6; i++)
        {
          switch (i)
          {
            case 0:
              if (ModuleMain.IsFeriee(debutSemaine.AddDays(i)))
                lblLundi.BackColor = Color.Red;
              else
                lblLundi.BackColor = Color.White;
              break;

            case 1:
              if (ModuleMain.IsFeriee(debutSemaine.AddDays(i)))
                lblMardi.BackColor = Color.Red;
              else
                lblMardi.BackColor = Color.White;
              break;

            case 2:
              if (ModuleMain.IsFeriee(debutSemaine.AddDays(i)))
                lblMercredi.BackColor = Color.Red;
              else
                lblMercredi.BackColor = Color.White;
              break;

            case 3:
              if (ModuleMain.IsFeriee(debutSemaine.AddDays(i)))
                lblJeudi.BackColor = Color.Red;
              else
                lblJeudi.BackColor = Color.White;
              break;
            case 4:
              if (ModuleMain.IsFeriee(debutSemaine.AddDays(i)))
                lblVendredi.BackColor = Color.Red;
              else
                lblVendredi.BackColor = Color.White;
              break;
            case 5:
              if (ModuleMain.IsFeriee(debutSemaine.AddDays(i)))
                lblSamedi.BackColor = Color.Red;
              else
                lblSamedi.BackColor = Color.Black;
              break;
            case 6:
              if (ModuleMain.IsFeriee(debutSemaine.AddDays(i)))
                lblDimanche.BackColor = Color.Red;
              else
                lblDimanche.BackColor = Color.Black;
              break;
            default:
              return;
          }
        }

        //  on décharge les images
        foreach (apiLabel item in lstPic)
          this.Controls.Remove(item);

        lstPic.Clear();

        // placement des informations
        // création des tableaux de label heures et jours
        int k = 0;
        Label[] tLabelJour = { lblLundi, lblMardi, lblMercredi, lblJeudi, lblVendredi, lblSamedi, lblDimanche };
        Label[] tLabelHeure = { lHeure0, lHeure1, lHeure2, lHeure3 };


        // liste des interventions par techiciens pour la semaine en cours
        if (lblTech.Tag != null && lblTech.Tag.ToString() != "")
        {
          using (SqlDataReader sdr = ModuleData.ExecuteReader($"api_sp_listeInterventions {lblTech.Tag}, '{debutSemaine.ToShortDateString()}'"))
          {
            while (sdr.Read())
            {
              k++;
              apiLabel pic = new apiLabel();
              pic.BorderStyle = BorderStyle.FixedSingle;
              pic.Size = pic0.Size;

              pic.Left = tLabelJour[(int)Convert.ToDateTime(sdr["DIPLDATJ"]).DayOfWeek - 1].Location.X;
              pic.Top = tLabelHeure[Convert.ToInt32(sdr["NIPLIND"]) - 1].Location.Y;

              //constition du tag d'une IP (code, NumIP, NumSite, NumAction(null), text, duree, premierJ, tech)
              sb.Clear();
              sb.Append("D#");
              sb.Append(sdr["NIPLNUM"].ToString()); sb.Append("#");
              sb.Append(sdr["NSITNUM"].ToString()); sb.Append("#0#");
              sb.Append(sdr["VCLINOM"].ToString()); sb.Append("\r\n");
              sb.Append(sdr["VSITNOM"].ToString()); sb.Append("\r\n"); sb.Append("#");
              sb.Append(sdr["NIPLDUR"].ToString()); sb.Append("#");
              sb.Append(sdr["CIPLDEB"].ToString()); sb.Append("#");
              sb.Append(lblTech.Tag.ToString()); sb.Append("#");
              sb.Append(Convert.ToDateTime(sdr["DIPLDATJ"]).ToShortDateString()); sb.Append("#");
              sb.Append(sdr["CIPLMULT"].ToString());

              pic.Tag = sb.ToString();

              if (Utils.GetMozart_Soc_By_Site(Convert.ToInt32(sdr["NSITNUM"])) > 0)
              {
                pic.ForeColor = Color.Black;
                pic.BackColor = Color.Yellow;
              }
              else
              {
                pic.ForeColor = Color.Black;
                pic.BackColor = Color.LightBlue;

                if (sdr["CIPLMULT"].ToString() == "O")
                {
                  pic.ForeColor = Color.White;
                  pic.BackColor = Color.DarkBlue;
                }

                if (sdr["CACTNUIT"].ToString() == "O")
                {
                  pic.ForeColor = Color.Black;
                  pic.BackColor = Color.Red;
                }

                using (SqlDataReader sdrCode = ModuleData.ExecuteReader($"exec api_sp_ControleDateExec_Attach {sdr["NIPLNUM"]}"))
                {
                  if (sdrCode.Read())
                  {
                    if (Convert.ToInt32(sdrCode[0]) == 0)
                    {
                      pic.ForeColor = Color.Black;
                      pic.BackColor = Color.Orange;
                    }

                    if (Convert.ToInt32(sdrCode[1]) == 0)
                    {
                      pic.ForeColor = Color.White;
                      pic.BackColor = Color.Green;
                    }
                  }
                }

                //si facture et exec, et attech : blanc
                if (Convert.ToInt32(sdr["nbfact"]) > 0 && pic.BackColor == Color.Green)
                {
                  pic.ForeColor = Color.Black;
                  pic.BackColor = Color.White;
                }
              }

              // affichage des informations dans l'image
              string inter = $"{sdr["VCLINOM"]}\n\r{sdr["VSITNOM"]}\n\r {sdr["NIPLDURJ"]}h {sdr["sCODE"]}";

              if (Convert.ToInt32(sdr["nbfact"]) > 0) inter += " €";
              if (Convert.ToInt32(sdr["PrevMag"]) > 0) inter += " #";

              pic.Text = inter;

              //affichage de l'image
              if (iCacherIP != 0)
              {
                if (Convert.ToInt32(sdr["NIPLNUM"]) == iCacherIP) pic.Visible = false;
                else pic.Visible = true;
              }
              else
                pic.Visible = true;

              pic.MouseUp += new System.Windows.Forms.MouseEventHandler(this.picALL_MouseUp);
              this.Controls.Add(pic);
              lstPic.Add(pic);
              pic.BringToFront();
            }
          }
        }
        //iNbrImage = k;
      }
      catch (Exception ex)
      {
        MZUtils.displayError(MethodBase.GetCurrentMethod().Name, ex);
      }
    }
    //Private Sub InitialiserPlanning(Optional iCacherIP As Long)
    //
    //Dim i As Integer
    //Dim k As Integer
    //Dim inter As String
    //Dim rsCode As ADODB.Recordset
    //Dim apisTag As New ApiString
    //
    //  On Error GoTo handler
    //  
    //  'fonction qui donne le premier jour de la semaine (lundi)
    //  DebutSemaine = Format(DateAdd("d", -(Weekday(mdSemaine) - 2), mdSemaine), "dd/mm/yyyy")
    //  
    //  ' recherche du numéro de semaine
    //  lblSemaine.Caption = "§Semaine §" & ISO_WEEK(DebutSemaine) 'DatePart("ww", DebutSemaine)
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
    //  ' placement des interventions
    //  On Error Resume Next
    //  k = 0
    //    
    //  ' liste des interventions par techniciens pour la semaine en cours
    //  If lblTech(0).Tag <> "" Then
    //    rs.Open "api_sp_listeInterventions " & lblTech(0).Tag & ", '" & DebutSemaine & "'", cnx
    //  
    //    While Not rs.EOF
    //      k = k + 1
    //      ' création d'une image
    //      Load pic(k)
    //      
    //      ' coordonnées de l'image (pb avec le dimanche car son weekday = 1)
    //      pic(k).Left = lJour(IIf(Weekday(rs("DIPLDATJ")) = 1, 8, Weekday(rs("DIPLDATJ"))) - 2).X1
    //      pic(k).Top = lHeure((0) + rs("NIPLIND") - 1).Y1 + 0
    //       
    //      ' constitution du tag d'une IP ( code, NumIP, NumSite, NumAction(null), text, duree, premierJ , tech)
    //      apisTag.Text = ""
    //      apisTag.Cat "D#"
    //      apisTag.Cat rs("NIPLNUM"):      apisTag.Cat "#"
    //      apisTag.Cat rs("NSITNUM"):      apisTag.Cat "#0#"
    //      apisTag.Cat rs("VCLINOM"):      apisTag.Cat vbCrLf
    //      apisTag.Cat rs("VSITNOM"):      apisTag.Cat vbCrLf:      apisTag.Cat "#"
    //      apisTag.Cat rs("NIPLDUR"):      apisTag.Cat "#"
    //      apisTag.Cat rs("CIPLDEB"):      apisTag.Cat "#"
    //      apisTag.Cat lblTech(0).Tag:     apisTag.Cat "#"
    //      apisTag.Cat rs("DIPLDATJ"):     apisTag.Cat "#"
    //      apisTag.Cat rs("CIPLMULT")
    //      pic(k).Tag = apisTag.Text
    //      
    //      If GetMozart_Soc_By_Site(rs("NSITNUM")) > 0 Then       ' pour les sites emalec spéciaux couleur : jaune
    //          pic(k).BackColor = &HFFFF&
    //      Else
    //        pic(k).BackColor = &HFFFFC0         'couleur standard = bleu clair
    //        
    //        If rs("CIPLMULT") = "O" Then pic(k).BackColor = &HFFFF00      ' si multi-jour : bleu foncé
    //        If rs("CACTNUIT") = "O" Then pic(k).BackColor = &HFF&       ' si c'est la nuit :  rouge
    //        
    //        Set rsCode = New ADODB.Recordset
    //        rsCode.Open "exec api_sp_ControleDateExec_Attach " & rs("NIPLNUM"), cnx
    //        If rsCode(0) = 0 Then pic(k).BackColor = RGB(255, 193, 125)       ' si date d'execution : orange
    //        If rsCode(1) = 0 Then pic(k).BackColor = &HC0FFC0                 ' si attachement (et exécution): Vert
    //        rsCode.Close
    //        
    //        ' si facture, et exec, et attach : blanc
    //        If rs("nbfact") > 0 And (pic(k).BackColor = &HC0FFC0) Then pic(k).BackColor = &HFFFFFF
    //      
    //      End If
    //
    //      ' affichage des informations dans l'image
    //      inter = rs("VCLINOM") & vbCrLf & rs("VSITNOM") & vbCrLf & " " & rs("NIPLDURJ") & "h  " & rs("sCODE")
    //        
    //      If rs("nbfact") > 0 Then inter = inter & "  €"
    //      If rs("PrevMag") > 0 Then inter = inter & "  #"
    //        
    //      pic(k).Print inter
    //            
    //      ' affichage de l"image
    //      If iCacherIP <> 0 Then
    //        If rs("NIPLNUM") = iCacherIP Then
    //          pic(k).Visible = False
    //        Else
    //          pic(k).Visible = True
    //        End If
    //      Else
    //        pic(k).Visible = True
    //      End If
    //            
    //      rs.MoveNext ' enregistrement suivant
    //    Wend
    //    rs.Close
    //  End If
    //    
    //  iNbrImage = k   ' nombre d'images chargées
    //  
    //  If Err <> 0 Then MsgBox "§Il y a eu une erreur lors de l'affichage du planning. Vous pouvez continuer et signaler ultérieurement cet incident au service informatique.§", vbInformation
    //  
    //  Exit Sub
    //  Resume
    //
    //handler:
    //  ShowError "InitialiserPlanning dans " & Me.Name
    //End Sub

    /* inutile --------------------------------------------------------------------------------------- */
    //Private Sub Form_QueryUnload(Cancel As Integer, UnloadMode As Integer)
    //Select Case UnloadMode
    //  Case 0
    //    Cancel = 1
    //End Select
    //End Sub

    /* OK --------------------------------------------------------------------------------------- */
    private void cmdPrec_Click(object sender, EventArgs e)
    {
      mdSemaine = debutSemaine.AddDays(-7);
      InitialiserPlanning();
    }
    //Private Sub cmdPrec_Click()
    //  
    //  Me.mdSemaine = DateAdd("d", -7, DebutSemaine)
    //  Call InitialiserPlanning
    //
    //End Sub

    /* OK --------------------------------------------------------------------------------------- */
    private void cmdSuiv_Click(object sender, EventArgs e)
    {
      mdSemaine = debutSemaine.AddDays(7);
      InitialiserPlanning();
    }
    //Private Sub cmdSuiv_Click()
    //  
    //  Me.mdSemaine = DateAdd("d", 7, DebutSemaine)
    //  Call InitialiserPlanning
    //  
    //End Sub

    /* OK --------------------------------------------------------------------------------------- */
    private void picALL_MouseUp(object sender, MouseEventArgs e)
    {
      var MyTabPic = (sender as apiLabel).Tag.ToString().Split('#');

      if (e.Button == MouseButtons.Right)
      {
        iNumIp = Convert.ToInt32(MyTabPic[1]);
        iNumTech = Convert.ToInt32(MyTabPic[7]);
        iSite = Convert.ToInt32(MyTabPic[2]);
        //strTypeEdition = "IP";
        mnuAffichage.Show(Cursor.Position);
      }
    }
    //Private Sub pic_MouseUp(Index As Integer, Button As Integer, Shift As Integer, X As Single, Y As Single)
    //
    //Dim MyTabPic
    //
    //  ' recherche de l'IP dans le tag de l'image
    //  MyTabPic = Split(pic(Index).Tag, "#")
    //  ddatejour = MyTabPic(8)
    //  
    // If Button = 2 Then
    //    iNumIp = MyTabPic(1)
    //    iNumTech = MyTabPic(7)
    //    iSite = MyTabPic(2)
    //    strTypeEdition = "IP"
    //    PopupMenu mnuAffichage
    //  End If
    //
    //End Sub

    /* OK --------------------------------------------------------------------------------------- */
    private void lblTech0_MouseUp(object sender, MouseEventArgs e)
    {
      if (e.Button == MouseButtons.Right)
      {
        iNumTech = Convert.ToInt32(lblTech.Tag);
        iNumIp = 0;
        //strTypeEdition = Resources.col_Tech;
        mnuAffichage.Show(Cursor.Position);
      }
    }
    //Private Sub lblTech_MouseUp(Index As Integer, Button As Integer, Shift As Integer, X As Single, Y As Single)
    // 
    // If Button = 2 Then
    //    iNumTech = lblTech(Index).Tag
    //    iNumIp = 0
    //    strTypeEdition = "§TECH§"
    //    PopupMenu mnuAffichage
    //  End If
    //
    //End Sub

    /* OK --------------------------------------------------------------------------------------- */
    private void lblInfo0_MouseUp(object sender, MouseEventArgs e)
    {
      apiLabel label = sender as apiLabel;

      if (e.Button == MouseButtons.Right)
      {
        iNumTech = Convert.ToInt32(label.Tag);
        iNumIp = 0;
        //strTypeEdition = Resources.col_Tech;
        mnuAffichage.Show(Cursor.Position);
      }
    }
    //Private Sub lblinfo_MouseUp(Index As Integer, Button As Integer, Shift As Integer, X As Single, Y As Single)
    // 
    // If Button = 2 Then
    //    iNumTech = lblTech(Index).Tag
    //    iNumIp = 0
    //    strTypeEdition = "§TECH§"
    //    PopupMenu mnuAffichage
    //  End If
    //
    //End Sub

    private void mnuVisu_Click(object sender, EventArgs e)
    {
      //si on est pas sur une IP on sort
      if (iNumIp == 0) return;

      //string[,] TdbGlobal = { { "NOW", DateTime.Now.ToShortDateString() } };

      //frmBrowser f = new frmBrowser();
      //f.Preview_Print($@"{MozartParams.CheminModeles}{ModuleMain.CodePays(ModuleMain.GetPays("TSIT", "VSITPAYS", "NSITNUM", iSite.ToString()))}{ModuleMain.ChoixModelOT(iNumIp)}",
      //                @"TOrdreTravailInfoOut.rtf",
      //                TdbGlobal,
      //                $"exec api_sp_OrdreDeTravail {iNumIp}",
      //                " (Imprimer OT dans frmPlan)",
      //                "PREVIEW");
      new frmMainReport
      {
        bLaunchByProcessStart = false,
        sTypeReport = "TOrdreTravailInfo",
        sIdentifiant = $"{iNumIp}",
        InfosMail = $"TPER|NPERNUM|{miNumTech}",
        sNomSociete = MozartParams.NomSociete,
        sLangue = ModuleMain.CodePays(ModuleMain.GetPays("TPER", "VPERPAYS", "NPERNUM", miNumTech.ToString())).Substring(0, 2),
        sOption = "PREVIEW"
      }.ShowDialog();
    }

    private void mnuDetails_Click(object sender, EventArgs e)
    {
      int liNumDi, llNumAction = 0;

      // si on est pas sur une IP on sort
      if (iNumIp == 0) return;

      // affichage d'une fenetre avec detail de l'IP
      using (SqlDataReader sdr = ModuleData.ExecuteReader($"select count(*) from TACT WITH (NOLOCK) where NIPLNUM = {iNumIp}"))
      {
        if (sdr.Read())
        {
          if (Convert.ToInt32(sdr[0]) > 1)
          {
            frmDetailIP f = new frmDetailIP();
            f.miNumIP = Convert.ToInt32(iNumIp);
            f.ShowDialog();
          }
          else
          {
            using (SqlDataReader sdrA = ModuleData.ExecuteReader($"select NACTNUM, NDINNUM from TACT WITH (NOLOCK) where NIPLNUM = {iNumIp}"))
            {
              if (sdrA.Read())
              {
                liNumDi = MozartParams.NumDi;
                llNumAction = MozartParams.NumAction;

                // recherche des droits sur cette DI
                using (SqlDataReader sdrDroit = ModuleData.ExecuteReader($"SELECT count(*) FROM TDIN WITH (NOLOCK) INNER JOIN TAUT WITH (NOLOCK) ON  TDIN.NDINCTE = TAUT.NCANNUM " +
                    $" INNER JOIN TPER WITH (NOLOCK) ON TAUT.NPERNUM = TPER.NPERNUM WHERE TPER.NPERNUM = {MozartParams.UID}" +
                    $" AND   TDIN.NDINNUM = {sdrA["NDINNUM"]}"))
                {
                  if (sdrDroit.Read())
                  {
                    if (Convert.ToInt32(sdrDroit[0]) == 0)
                    {
                      MessageBox.Show(Resources.msg_pasDroitsAccesDI, Program.AppTitle, MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                      return;
                    }
                  }
                }

                //écran de modification
                frmAddAction f = new frmAddAction();
                f.mstrStatutDI = "M";
                MozartParams.NumDi = Convert.ToInt32(sdrA["NDINNUM"]);
                MozartParams.NumAction = Convert.ToInt32(sdrA["NACTNUM"]);

                f.ShowDialog();

                // on revient donc on réinitialise les variables globales avec anciennes valeurs
                MozartParams.NumDi = liNumDi;
                MozartParams.NumAction = llNumAction;
              }
            }
          }
        }
      }
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
    //      If Err Then MsgBox "§Impossible d'afficher l'écran de détail de l'action car cet écran est déjà chargé en arrière plan§"
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
      string[,] TdbGlobal = { { "", "" } };

      //si on est pas sur une IP on sort
      if (iNumTech == 0)
        MessageBox.Show(Resources.msg_clickOnTechForPlanning, Program.AppTitle, MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
      else
      {
        frmBrowser f = new frmBrowser();
        f.Preview_Print($@"{MozartParams.CheminModeles}{MozartParams.Langue}\TPlanningTechA4.rtf",
                          @"TPlanningTechA4out.rtf",
                          TdbGlobal,
                          $"exec api_sp_impPlanningTechA4 {iNumTech}, '{mdSemaine.ToString("dd/MM/yyyy")}'",
                          " (Imprimer planning A4 dans frmPlan)",
                          "PREVIEW");
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
    //    frmBrowser.bPlanningAn = 0
    //    frmBrowser.Preview_Print gstrCheminModeles & gstrLangue & "\" & "TPlanningTechA4.rtf", _
    //                              "\TPlanningTechA4out.rtf", _
    //                              TdbGlobal(), _
    //                              "exec api_sp_impPlanningTechA4 " & iNumTech & ", '" & mdSemaine & "'", _
    //                              " (Imprimer planning A4 dans frmPlan)", _
    //                              "PREVIEW"
    //  End If
    // End Sub

    /* OK --------------------------------------------------------------------------------------- */
    private void cmdImprimer_Click(object sender, EventArgs e)
    {
      Cursor = Cursors.WaitCursor;
      this.ImprimerDansWord();
      Cursor = Cursors.Default;
    }
    //Private Sub cmdImprimer_Click()
    //  ' fonction d'impression écran
    //  Screen.MousePointer = vbHourglass
    //  ImprimerDansWord
    //  Screen.MousePointer = vbDefault
    //End Sub
  }
}