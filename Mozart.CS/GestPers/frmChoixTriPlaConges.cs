using MozartLib;
using MozartNet;
using System;
using System.Data.SqlClient;
using System.IO;
using System.Reflection;
using System.Text;
using System.Windows.Forms;
using MZUtils = MozartControls.Utils;

namespace MozartCS
{
  public partial class frmChoixTriPlaConges : Form
  {
    public string msLibNomSoc;
    public int miIdMenuParent;

    //initialisation de la date pour le planning des congés
    DateTime dtDate;

    //Public sLibNomSoc As String
    //Public nIdMenuParent As Integer
    //
    //  ' initialisation de la date pour le planning des conges
    // Dim dtDate As Date

    public frmChoixTriPlaConges() { InitializeComponent(); }

    /* OK --------------------------------------------------------------*/
    private void frmChoixTriPlaConges_Load(object sender, System.EventArgs e)
    {
      try
      {
        Cursor.Current = Cursors.WaitCursor;
        ModuleMain.Initboutons(this);

        MozartParams.CodeRetour = "";
        dtDate = DateTime.Now;

        optri0.Checked = true;
        optri0.BackColor = optri1.BackColor = optri2.BackColor = ModuleMain.Couleur(MozartParams.NomSociete);

        ToolTip tt1 = new ToolTip();
        tt1.SetToolTip(cmdPrint, MozartParams.Printer);
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
    //  gsCodeRetour = ""
    //  dtDate = Date
    //
    //  optri(0).BackColor = Couleur(gstrNomSociete)
    //  optri(1).BackColor = Couleur(gstrNomSociete)
    //  optri(2).BackColor = Couleur(gstrNomSociete)
    //
    //  cmdPrint.ToolTipText = gstrPrinter
    //
    //End Sub

    /* OK --------------------------------------------------------------*/
    private void cmdPrint_Click(object sender, System.EventArgs e)
    {
      Cursor = Cursors.WaitCursor;
      brwWebBrowser.Print();

      Cursor = Cursors.Default;
    }
    //Private Sub cmdPrint_Click()
    //
    //Dim eQuery As OLECMDF       'return value type for QueryStatusWB
    //
    //  On Error Resume Next
    //  
    //  brwWebBrowser.SetFocus
    //
    //  eQuery = brwWebBrowser.QueryStatusWB(OLECMDID_PRINT)  'get print command status
    //  
    //  If Err.Number = 0 Then
    //    If eQuery And OLECMDF_ENABLED Then
    //      brwWebBrowser.ExecWB OLECMDID_PRINT, OLECMDEXECOPT_DONTPROMPTUSER, 0, 0     'Ok to Print?
    //    Else
    //      MsgBox "L'impression Internet Explorer n'est pas disponible."
    //    End If
    //  End If
    //  
    //  Me.MousePointer = vbDefault
    //  If Err.Number <> 0 And Err.Number <> -2147221248 Then MsgBox "Erreur d'impression : " & Err.Description
    //  
    //
    //End Sub

    /* OK --------------------------------------------------------------------------------------- */
    private void cmdPrec_Click(object sender, EventArgs e)
    {
      //mois précédent
      dtDate = dtDate.AddMonths(-1);
      cmdValider_Click(null, null);
    }
    //Private Sub cmdPrec_Click()
    //    'mois précédente
    //    dtDate = DateAdd("m", -1, dtDate)
    //    cmdValider_Click
    //
    //End Sub

    /* OK --------------------------------------------------------------------------------------- */
    private void cmdSuiv_Click(object sender, EventArgs e)
    {
      // mois suivant
      dtDate = dtDate.AddMonths(1);
      cmdValider_Click(null, null);
    }
    //Private Sub cmdSuiv_Click()
    //    ' mois suivante
    //    dtDate = DateAdd("m", 1, dtDate)
    //    cmdValider_Click
    //
    //End Sub

    /* Inutile --------------------------------------------------------------------------------------- */
    //private void frmChoixTriPlaConges_Resize(object sender, EventArgs e)
    //{
    //  brwWebBrowser.Height = this.Height - 1100;
    //  brwWebBrowser.Focus();
    //}
    //Private Sub Form_Resize()
    //  On Error Resume Next    'dans le cas du WindowState = minimize
    //  brwWebBrowser.height = Me.ScaleHeight - 1100
    //  brwWebBrowser.SetFocus
    //End Sub

    /* OK --------------------------------------------------------------------------------------- */
    private void cmdValider_Click(object sender, EventArgs e)
    {
      try
      {
        // affichage curseur
        Cursor = Cursors.WaitCursor;

        // choix du tri
        if (optri0.Checked)
          // preview avec tri sur site et region client
          GeneratePlanningConges(dtDate, 1);
        else if (optri1.Checked)
          // preview avec tri sur région client et num site
          GeneratePlanningConges(dtDate, 2);
        else
          //preview avec tri sur région client et site
          GeneratePlanningConges(dtDate, 3);

        brwWebBrowser.Navigate($@"{MozartParams.CheminUtilisateurMozart}t.html");

        Cursor = Cursors.Default;
      }
      catch (Exception ex)
      {
        MZUtils.displayError(MethodBase.GetCurrentMethod().Name, ex);
      }
    }
    //Private Sub cmdValider_Click()
    //  
    //  On Error GoTo handler
    //      
    //  ' affichage curseur
    //  Me.MousePointer = vbHourglass
    //  
    //  'choix du tri
    //  If optri(0) Then
    //    'Preview avec tri sur site et region client
    //    GeneratePlanningConges dtDate, 1
    //  ElseIf optri(1) Then
    //    'Preview avec tri sur région client et num site
    //    GeneratePlanningConges dtDate, 2
    //  Else
    //    'Preview avec tri sur région client et site
    //    GeneratePlanningConges dtDate, 3
    //  End If
    //  
    //  brwWebBrowser.Navigate gstrCheminUtilisateur & "\Mozart\t.html"
    //    
    //  Me.MousePointer = vbDefault
    //  
    //Exit Sub
    //handler:
    // Me.MousePointer = vbDefault
    // ShowError "cmdConges_Click dans " & Me.Name
    //End Sub

    /* OK --------------------------------------------------------------------------------------- */
    private void cmdFermer_Click(object sender, EventArgs e)
    {
      Dispose();
    }
    //Private Sub cmdFermer_Click()
    //  Unload Me
    //End Sub

    /* OK --------------------------------------------------------------------------------------- */
    public void GeneratePlanningConges(DateTime date, int iTri)
    {
      try
      {
        string sColor = "";
        DateTime dateCourant;

        StringBuilder strHtml = new StringBuilder();

        int nbJour = renDernierJour(dtDate.Month, dtDate.Year);

        strHtml.Append(@"<html><head> <meta charset =""utf-8"" /> <title> Planning mensuel des absences</title></head><body>");
        strHtml.AppendLine();

        string stemp = "";
        if (MozartParams.NomSocieteTemp == "GROUPE") stemp = msLibNomSoc;
        else stemp = MozartParams.NomSocieteTemp;

        using (SqlDataReader sdr = ModuleData.ExecuteReader($"api_sp_PlanningMensuelConges '{dtDate}', {iTri},'{stemp}',{miIdMenuParent}"))
        {
          // titre du document
          strHtml.Append($@"<TABLE width=100%><TR><TD width=20% """"style=font-face=tahoma; font-size=24pt;""""><H2>{MozartParams.NomSociete} </H2></TD>");
          strHtml.Append($"<TD width=65% style=font-face=arial; font-size=18pt;><H3><Center>Planning Mensuel des absences : {Utils.Mois(dtDate.Month)} {dtDate.Year}</CENTER></H3></TD>");
          strHtml.Append($"<TD width=15%><H3>le {DateTime.Now.ToShortDateString()}</H3></TD></TR></TABLE>");

          // legende
          strHtml.Append($"<table border=1 cellpadding=0 cellspacing=0 width=75%>");
          strHtml.AppendLine();
          strHtml.Append($"<tr> <FONT FACE=arial size=2><td><FONT FACE=arial size=2><b>Légende</b></td>");
          strHtml.AppendLine();
          strHtml.Append($"<td bgcolor=#FFFF33><FONT FACE=arial size=2>&nbsp;&nbsp;</td><td><FONT FACE=arial size=2>Congés</td>");
          strHtml.Append($"<td bgcolor=#7733FF><FONT FACE=arial size=2>&nbsp;&nbsp;</td><td><FONT FACE=arial size=2>Activité partielle</td>");
          strHtml.Append($"<td bgcolor=#FF0000><FONT FACE=arial size=2>&nbsp;&nbsp;</td><td><FONT FACE=arial size=2>Repos compensateur</td>");
          strHtml.Append($"<td bgcolor=#FF9900><FONT FACE=arial size=2>&nbsp;&nbsp;</td><td><FONT FACE=arial size=2>Absence</td>");
          strHtml.Append($"<td bgcolor=#3399FF><FONT FACE=arial size=2>&nbsp;&nbsp;</td><td><FONT FACE=arial size=2>Maladie</td>");
          strHtml.Append($"<td bgcolor=#33CC00><FONT FACE=arial size=2>&nbsp;&nbsp;</td><td><FONT FACE=arial size=2>Accident</td>");
          strHtml.Append($"<td bgcolor=#FF00FF><FONT FACE=arial size=2>&nbsp;&nbsp;</td><td><FONT FACE=arial size=2>Planif cli > 6H</td>");
          strHtml.Append($"<td bgcolor=#FFE1FF><FONT FACE=arial size=2>&nbsp;&nbsp;</td><td><FONT FACE=arial size=2>Planif cli < 6H</td>");
          strHtml.Append($"</tr></table>");
          strHtml.AppendLine();

          // Tableau des jours du mois
          strHtml.Append($"<table border=1 cellpadding=0 cellspacing =0 width=100%><tr>");
          strHtml.AppendLine();
          strHtml.Append($"<td width=18% bgcolor=#B0C0CC><font face=Arial size=1><b>Personnel</b></FONT></td>");
          if (MozartParams.NomSocieteTemp == "GROUPE")
            strHtml.Append($"<td width=10% bgcolor=#B0C0CC><font face=Arial size=1><b>Société</b></FONT></td>");
          strHtml.Append($"<td width=10% bgcolor=#B0C0CC><font face=Arial size=1><b>Région</b></FONT></td>");
          strHtml.Append($"<td width=10% bgcolor=#B0C0CC><font face=Arial size=1><b>Service</b></FONT></td>");

          for (int i = 1; i <= nbJour; i++)
            strHtml.Append($"<td bgcolor=#B0C0CC><FONT size=1> {i.ToString("00")}</td>");

          strHtml.Append($"</tr>");
          strHtml.AppendLine();

          while (sdr.Read())
          {
            // personne et planning de cette personne
            strHtml.Append($"<tr><td bgcolor=white><font face=Arial size=1>{ sdr["TECH"] }</FONT></td> ");
            if (MozartParams.NomSocieteTemp == "GROUPE")
              strHtml.Append($"<td bgcolor=white><font face=Arial size=1>{ sdr["VSOCIETE"] }</FONT></td> ");
            strHtml.Append($"<td bgcolor=white><font face=Arial size=1>{sdr["VREGLIB"]}</FONT></td> ");
            strHtml.Append($"<td bgcolor=white><font face=Arial size=1>{sdr["VSERLIB"]}</FONT></td> ");

            for (int i = 4; i <= nbJour + 3; i++)
            {
              sColor = "";
              dateCourant = Convert.ToDateTime($"{(i - 3).ToString("00")}/{dtDate.Month}/{dtDate.Year}");
              //si weekend on grise
              if (dateCourant.DayOfWeek == DayOfWeek.Saturday || dateCourant.DayOfWeek == DayOfWeek.Sunday) sColor = "#D3E0FE";

              switch (sdr[i].ToString().ToUpper())
              {
                case "C":
                  sColor = "#FFFF33";
                  break;
                case "P":
                  sColor = "#7733FF";
                  break;
                case "R":
                  sColor = "#FF0000";
                  break;
                case "A":
                  sColor = "#FF9900";
                  break;
                case "M":
                  sColor = "#33CC00";
                  break;
                case "I":
                  sColor = "#3399FF"; 
                  break;
                case "X":
                  sColor = "#FF00FF";
                  break;
                case "Y":
                  sColor = "#FFE1FF";
                  break;
                default:
                  break;
              }

              if (sColor == "") sColor = "white";

              strHtml.Append($"<td bgcolor={sColor}>&nbsp;</td>");
              strHtml.AppendLine();
            }
            strHtml.Append("</tr>");

          }
          strHtml.Append($"</table>");
          strHtml.AppendLine();
          strHtml.Append($"</body></html>");


          File.WriteAllText(MozartParams.CheminUtilisateurMozart + @"t.html", strHtml.ToString());
        }
      }
      catch (Exception ex)
      {
        MZUtils.displayError(MethodBase.GetCurrentMethod().Name, ex);
      }
    }
    //Public Sub GeneratePlanningConges(ByVal dtDate As Date, iTri As Integer)
    //
    //Dim strHtml As String
    //Dim i As Integer
    //Dim sColor As String
    //Dim rs As New Recordset
    //Dim NbJour As Integer
    //Dim DateCourant As Date
    //
    //  On Error GoTo handler
    //
    //  ccOffset = 0
    //  strHtml = ""
    //  
    //  NbJour = renDernierJour(Month(dtDate), Year(dtDate))
    //  
    //  Concat strHtml, "<html><head><title> Planning mensuel des absences</title></head><body>" & vbCrLf
    //  
    //  rs.Open "api_sp_PlanningMensuelConges '" & dtDate & "', " & iTri & ",'" & IIf(gstrNomSocieteTemp = "GROUPE", sLibNomSoc, gstrNomSocieteTemp) & "'," & nIdMenuParent, cnx
    //
    //  If Not rs.EOF Then
    //    
    //    ' titre du document
    //    Concat strHtml, "<TABLE width=100%><TR><TD width=20% """"style=font-face=tahoma; font-size=24pt;""""><H2>" & gstrNomSociete & " </H2></TD>"
    //    Concat strHtml, "<TD width=65% style=font-face=arial; font-size=18pt;><H3><Center>Planning Mensuel des absences : " & Mois(Month(dtDate)) & "  " & Year(dtDate) & "</CENTER></H3></TD>"
    //    Concat strHtml, "<TD width=15%><H3>le " & Date & "</H3></TD></TR></TABLE>"
    // 
    //    ' legende
    //    Concat strHtml, "<table border=1 cellpadding=0 cellspacing=0 width=75%>" & vbCrLf
    //    Concat strHtml, "<tr> <FONT FACE=arial size=2><td><FONT FACE=arial size=2><b>Légende</b></td>" & vbCrLf
    //    Concat strHtml, "<td bgcolor=#FFFF33><FONT FACE=arial size=2>&nbsp;&nbsp;</td><td><FONT FACE=arial size=2>Congés</td>"
    //    Concat strHtml, "<td bgcolor=#7733FF><FONT FACE=arial size=2>&nbsp;&nbsp;</td><td><FONT FACE=arial size=2>Activité partielle</td>"
    //    Concat strHtml, "<td bgcolor=#FF0000><FONT FACE=arial size=2>&nbsp;&nbsp;</td><td><FONT FACE=arial size=2>Repos compensateur</td>"
    //    Concat strHtml, "<td bgcolor=#FF9900><FONT FACE=arial size=2>&nbsp;&nbsp;</td><td><FONT FACE=arial size=2>Absence</td>"
    //    Concat strHtml, "<td bgcolor=#33CC00><FONT FACE=arial size=2>&nbsp;&nbsp;</td><td><FONT FACE=arial size=2>Maladie</td>"
    //    Concat strHtml, "<td bgcolor=#3399FF><FONT FACE=arial size=2>&nbsp;&nbsp;</td><td><FONT FACE=arial size=2>Accident</td>"
    //    Concat strHtml, "<td bgcolor=#FF00FF><FONT FACE=arial size=2>&nbsp;&nbsp;</td><td><FONT FACE=arial size=2>Planif cli > 6H</td>"
    //    Concat strHtml, "<td bgcolor=#FFE1FF><FONT FACE=arial size=2>&nbsp;&nbsp;</td><td><FONT FACE=arial size=2>Planif cli < 6H</td>"
    //    Concat strHtml, "</tr></table>" & vbCrLf
    //
    //    ' Tableau des jours du mois
    //    Concat strHtml, "<table border=1 cellpadding=0 cellspacing =0 widht=100%><tr>" & vbCrLf
    //    Concat strHtml, "<td width=18% bgcolor=#B0C0CC><font face=Arial size=1><b>Personnel</b></FONT></td>"
    //    If (gstrNomSocieteTemp = "GROUPE") Then Concat strHtml, "<td width=10% bgcolor=#B0C0CC><font face=Arial size=1><b>Société</b></FONT></td>"
    //    Concat strHtml, "<td width=10% bgcolor=#B0C0CC><font face=Arial size=1><b>Région</b></FONT></td>"
    //    Concat strHtml, "<td width=10% bgcolor=#B0C0CC><font face=Arial size=1><b>Service</b></FONT></td>"
    //    
    //    For i = 1 To NbJour
    //      Concat strHtml, "<td bgcolor=#B0C0CC><FONT size=1>" & Format(i, "00") & "</td>"
    //    Next
    //    Concat strHtml, "</tr>" & vbCrLf
    //    
    //    While Not rs.EOF
    //      ' personne  et planning de cette personne
    //      Concat strHtml, "<tr><td bgcolor=white><font face=Arial size=1>" & rs("TECH") & "</FONT></td> "
    //      If (gstrNomSocieteTemp = "GROUPE") Then Concat strHtml, "<td bgcolor=white><font face=Arial size=1>" & rs("VSOCIETE") & "</FONT></td> "
    //      Concat strHtml, "<td bgcolor=white><font face=Arial size=1>" & rs("VREGLIB") & "</FONT></td> "
    //      Concat strHtml, "<td bgcolor=white><font face=Arial size=1>" & rs("VSERLIB") & "</FONT></td> "
    //      'i = 4 car 4 correspond au 4eme champ de la requete  où démarre les case.
    //      For i = 4 To NbJour + 3
    //        sColor = ""
    //        DateCourant = CDate(Format(i - 3, "00") & "/" & Month(dtDate) & "/" & Year(dtDate))
    //        ' si weekend on grise
    //        If Weekday(DateCourant) = 1 Or Weekday(DateCourant) = 7 Then sColor = "#D3E0FE"
    //        Select Case Majuscule(rs(i))
    //          Case "C": sColor = "#FFFF33"
    //          Case "P": sColor = "#7733FF"
    //          Case "R": sColor = "#FF0000"
    //          Case "A": sColor = "#FF9900"
    //          Case "M": sColor = "#33CC00"
    //          Case "I": sColor = "#3399FF"
    //          Case "X": sColor = "#FF00FF"
    //          Case "Y": sColor = "#FFE1FF"
    //          Case Else: If sColor = "" Then sColor = "white"
    //        End Select
    //        Concat strHtml, "<td bgcolor=" & sColor & ">&nbsp;</td>" & vbCrLf
    //      Next
    //      Concat strHtml, "</tr>"
    //      rs.MoveNext
    //    Wend
    //  
    //   Concat strHtml, "</table>" & vbCrLf
    // 
    //  End If
    //  
    //  rs.Close
    //
    //  Concat strHtml, "</body></html>"
    //  strHtml = left$(strHtml, ccOffset)
    //  
    //  Dim fs As New Scripting.FileSystemObject
    //  Dim ts As TextStream
    //  Set ts = fs.OpenTextFile(gstrCheminUtilisateur & "\Mozart\t.html", ForWriting, True)
    //  ts.Write strHtml
    //  ts.Close
    //
    //Exit Sub
    //handler:
    //  ShowError " GeneratePlanningConges dans " & Me.Name
    //End Sub

    public int renDernierJour(int nuMois, int nuAnnee)
    {
      int iRenDernierJour = 0;

      if (nuMois == 12)
        iRenDernierJour = 31;
      else
      {
        string temp = $"{nuMois + 1}/{nuAnnee}";
        DateTime dDate = Convert.ToDateTime(temp);
        iRenDernierJour = dDate.AddDays(-1).Day;
      }

      return iRenDernierJour;
    }
    // Public Function renDernierJour(nuMois As Integer, nuAnnee As Integer) As Integer

    //  If nuMois = 12 Then
    //    renDernierJour = 31
    //  Else
    //    renDernierJour = Day(DateAdd("d", -1, DateSerial(nuAnnee, nuMois + 1, 1)))
    //  End If

    // End Function
  }
}