Imports System.Data.SqlClient
Imports MozartLib

Public Class frmCtrlEtanchPeriodicite

  Dim _DtClient As DataTable
  Dim dtAnnee As DataTable
  Dim strFile As String

  Private Sub frmCtrlEtanchPeriodicite_Load(sender As Object, e As EventArgs) Handles MyBase.Load

    strFile = MozartParams.CheminUtilisateurMozart & "FilePlanningCertEtanch.html"

    LoadDataAnnee()
    LoadataClient()

    GridLookUpEdit1.EditValue = Now.Date.Year

  End Sub

  Private Sub LoadDataAnnee()

    dtAnnee = New DataTable
    dtAnnee.Columns.Add("NIDANNEE", Type.GetType("System.Int32"))

    For i = 2100 To 1999 Step -1

      Dim drnew As DataRow = dtAnnee.NewRow
      drnew.Item("NIDANNEE") = i
      dtAnnee.Rows.Add(drnew)

    Next

    GridLookUpEdit1.Properties.DataSource = dtAnnee

  End Sub

  Private Sub LoadataClient()

    _DtClient = New DataTable

    Dim sqlcmdread As New SqlCommand("api_sp_ListeClientsWithCertFluid", MozartDatabase.cnxMozart)
    sqlcmdread.CommandType = CommandType.StoredProcedure
    sqlcmdread.Parameters.Add("@p_vsociete", SqlDbType.VarChar).Value = MozartParams.NomSociete

    _DtClient.Load(sqlcmdread.ExecuteReader)

    GlookUpClient.Properties.DataSource = _DtClient

  End Sub

  Private Sub BtnFermer_Click(sender As Object, e As EventArgs) Handles BtnFermer.Click
    Me.Close()
  End Sub

  Private Sub BtnRechercher_Click(sender As Object, e As EventArgs) Handles BtnRechercher.Click

    CreatePlanning(GlookUpClient.Text, GlookUpClient.EditValue)

    WB.Navigate(strFile)

  End Sub

  Private Sub frmCtrlEtanchPeriodicite_ResizeEnd(sender As Object, e As EventArgs) Handles Me.ResizeEnd

    WB.Size = New Size(Me.Size.Width - WB.Location.X - 50, Me.Size.Height - WB.Location.Y - 50)

  End Sub

  Private Sub frmCtrlEtanchPeriodicite_SizeChanged(sender As Object, e As EventArgs) Handles Me.SizeChanged
    WB.Size = New Size(Me.Size.Width - WB.Location.X - 50, Me.Size.Height - WB.Location.Y - 50)
  End Sub

  Private Sub CreatePlanning(ByVal p_VCLINOM As String, ByVal p_NCLINUM As Int32)

    Dim dt_data As New DataTable
    Dim sqlcmdRD As New SqlCommand("[api_sp_PlanningAnnuelCtrlEtancheite]", MozartDatabase.cnxMozart)
    sqlcmdRD.CommandType = CommandType.StoredProcedure
    sqlcmdRD.Parameters.Add("@P_NCLINUM", SqlDbType.Int).Value = p_NCLINUM
    sqlcmdRD.Parameters.Add("@iAnnee", SqlDbType.Int).Value = GridLookUpEdit1.EditValue
    dt_data.Load(sqlcmdRD.ExecuteReader)

    If File.Exists(strFile) Then File.Delete(strFile)

    Using sw As New StreamWriter(File.Open(strFile, FileMode.CreateNew))

      sw.WriteLine("<html><head><meta http-equiv=""Content-Type"" content=""text/html; charset=UTF-8"" /><title> Planning annuel des certificats d' étanchéité</title></head><body>")
      sw.WriteLine("<BR>")

      sw.WriteLine("<TABLE width=100%><TR><TD width=15% """"style=font-face=tahoma; font-size=24pt;""""><H2>" & p_VCLINOM & " </H2></TD>")
      sw.WriteLine("<TD width=75% ><font style=""FONT-FAMILY:Arial;FONT-SIZE:12pt;""><Center><B>Planning annuel des certificats d'étanchéité</CENTER></H3></TD>")
      sw.WriteLine("<TD width=10%><H3></H3></TD></TR></font></TABLE>")

      sw.WriteLine("<table border=1 cellpadding=1 cellspacing =0 widht=100%><tr>")
      sw.WriteLine("<td width=17% bgcolor=#B0C0CC><FONT face=arial size=2pt;><b>Site (" & dt_data.Rows.Count.ToString & " sites)" & "</b></font></td>")
      sw.WriteLine("<td width=4% bgcolor=#B0C0CC style=font-face=arial; font-size=8pt;><b>N°</b></td>")
      sw.WriteLine("<td width=7% bgcolor=#B0C0CC style=font-face=arial; font-size=8pt;><b>Région</b></td>")

      ' cas standart ou décalé
      ' pb de numéro de semaine en 2005 et 2006 la fonction n'est pas bonne
      ' k = DatePart("ww", D)-1

      Dim i, k As Int32
      Dim D As Date
      Dim sColor As String

      D = "01/01/" & GridLookUpEdit1.Text

      k = DatePart("ww", D)
      If k = 53 Or k = 0 Then k = 1

      ' écriture des numéro de semaine
      For i = k To 52
        '      If i = DatePart("ww", Date) - 1 Then
        If i = DatePart("ww", Now.Date) Then
          sw.WriteLine("<td bgcolor=#EAEAFF><FONT size=1>" & Format(i, "00") & "</td>")
        Else
          sw.WriteLine("<td bgcolor=#B0C0CC><FONT size=1>" & Format(i, "00") & "</td>")
        End If
      Next

      ' si décalage
      If k <> 1 Then
        For i = 1 To (k - 1)
          sw.WriteLine("<td bgcolor=#B0C0CC><FONT size=1>" & Format(i, "00") & "</td>")
        Next
      End If

      ' total
      sw.WriteLine("<td bgcolor=#B0C0CC><FONT size=1>Tot</td>")
      sw.WriteLine("</tr>")

      For Each drData As DataRow In dt_data.Rows

        'INIT
        sColor = "white"

        ' Site client et planning de ce site
        sw.WriteLine("<tr><td bgcolor=white ><font face=Arial size=1>" & drData("VSITNOM") & "</FONT></td> ")
        sw.WriteLine("<td bgcolor=white><font face=Arial size=1>" & drData("NSITNUE") & "</FONT></td> ")
        sw.WriteLine("<td bgcolor=white><font face=Arial size=1>" & If(drData("VSITREG") = "" Or IsDBNull(drData("VSITREG")), "&nbsp;", drData("VSITREG")) & "</FONT></td> ")

        For i = 6 + (k - 1) To 57
          Select Case UCase(drData(i)).ToString().Substring(0, 1)
            Case "V", " "
              Select Case i
                Case 6, 32, 33, 34, 35, 36, 37, 38, 39, 40, 57
                  sColor = "#FEFFE6"
                Case Else
                  sColor = "white"
              End Select
              ' pb de la fonction N° semaine en 2005
              If i = DatePart("ww", Now.Date) + 5 Then sColor = "#EAEAFF"  'pour colorer la semaine en cour

            Case "I" : sColor = "#FF0000"
            Case "P" : sColor = "#FF9900"
            Case "X" : sColor = "#33CC00"

          End Select
          sw.WriteLine("<td bgcolor=" & sColor & " onClick=""alert('DI" & UCase(drData(i)).ToString().Substring(1, drData(i).ToString().Length - 1) & "');""><font style=""CURSOR:Hand;FONT-FAMILY:Arial;FONT-SIZE:4pt;"">&nbsp;</font></td>")
        Next

        'traitement si décalage
        If k <> 1 Then
          For i = 6 To 6 + (k - 2)
            Select Case UCase(drData(i)).ToString().Substring(0, 1)
              Case "V", " "
                Select Case i
                  Case 6, 32, 33, 34, 35, 36, 37, 38, 39, 40, 57
                    sColor = "#FEFFE6"
                  Case Else
                    sColor = "white"
                End Select
                If i = DatePart("ww", Now.Date) + 5 Then sColor = "#EAEAFF"  'pour colorer la semaine en cour
              Case "I" : sColor = "#FF0000"
              Case "P" : sColor = "#FF9900"
              Case "X" : sColor = "#33CC00"
            End Select
            sw.WriteLine("<td bgcolor=" & sColor & " onClick=""alert('DI" & UCase(drData(i)).ToString().Substring(1, drData(i).ToString().Length - 1) & "');"">&nbsp;</td>")
          Next
        End If

        ' total
        sw.WriteLine("<td bgcolor=white style=""font-face=arial; font-size=7pt;""><NOBR>" & drData(58) & "</NOBR></td>")
        sw.WriteLine("</tr>")

      Next

      sw.WriteLine("</table>")

      sw.WriteLine("</body></html>")

    End Using

  End Sub

  Private Sub GlookUpClient_EditValueChanged(sender As Object, e As EventArgs) Handles GlookUpClient.EditValueChanged

    WB.Navigate("about:blank")

  End Sub
End Class