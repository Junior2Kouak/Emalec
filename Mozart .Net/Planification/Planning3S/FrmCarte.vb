Imports System.Xml

Public Class FrmCarte

    Public Infos As String

    Dim ptsTrajets() As PointF
    Dim apiPtsTrajets() As PointF
    Dim posLat As Integer = 50
    Dim posLon As Integer = 400
    Dim iZoom As Integer = 800
    Dim bMouseMove As Boolean = False
    Dim iNivZoom As Integer = 5

    Dim prevX As Integer = 0
    Dim prevY As Integer = 0

    Dim XmlDoc As XmlDocument = New XmlDocument()

    Private Sub frmCarte_FormClosing(ByVal sender As Object, ByVal e As System.Windows.Forms.FormClosingEventArgs) Handles Me.FormClosing
        While Me.Controls.Count > 0
            Me.Controls.Clear()
        End While
    End Sub

    Private Sub frmCarte_Load(ByVal sender As Object, ByVal e As System.EventArgs) Handles Me.Load

        ptsTrajets = Nothing

        If Infos = "" Then      ' Carte collective avec tous les techs et toutes les semaines
            Dim cpt As Integer = 0
            For t As Integer = FrmMainPlanning3S.FirstTech To FrmMainPlanning3S.LastTech
                Dim l As New Label()
                l.Text = FrmMainPlanning3S.Techs(t).VPERNOM
                l.Height = 15
                l.Font = New Font(Me.Font, FontStyle.Bold)
                l.Width = 180
                l.Left = 200 * cpt
                Me.Controls.Add(l)

                AjoutBtnSemaine(l.Left, t)

                cpt += 1
            Next

            posLat = 80
            posLon = 400
            iZoom = 800
            iNivZoom = 5
            Me.Location = New Point(0, 0)
            Me.Size = Screen.PrimaryScreen.WorkingArea.Size
        Else

            posLat = 40
            posLon = 180
            iZoom = 400
            iNivZoom = 7

            Dim ptLoc As New Point()

            Dim DebutSemaine As Date = Date.Today.AddDays(-Date.Today.DayOfWeek + 1)
            Select Case CInt(Infos.Split("|")(1)) - DatePart(DateInterval.WeekOfYear, DebutSemaine)
                Case 0
                    ptLoc.X = 800
                Case Else
                    ptLoc.X = 100
            End Select

            Select Case CInt(Infos.Split("|")(2))
                Case 0 To 3
                    ptLoc.Y = 600
                Case Else
                    ptLoc.Y = 100
            End Select

            Me.Location = ptLoc
            Me.Size = New Size(500, 500)

            btnSemaineTech_Click(Nothing, Nothing)
        End If

        AjoutBtnZoom()

        'XmlDoc.Load(Application.StartupPath & "\FondCarte.xml")
        'XmlDoc.LoadXml(My.Resources.FondCarte)

    End Sub

    Private Sub AjoutBtnSemaine(ByVal pos As Integer, ByVal Tech As Integer)

        For i As Integer = 0 To 2
            Dim b As New Button()
            b.Text = "S" & (i + 1).ToString()
            b.Width = 35
            b.Top = 20
            b.Left = pos + ((b.Width + 2) * i)
            b.BackColor = Color.PowderBlue
            b.Tag = FrmMainPlanning3S.Techs(Tech).NPERNUM & "|" & (DatePart(DateInterval.WeekOfYear, FrmMainPlanning3S.DebutSemaine) + i).ToString() & "|" & Tech.ToString()
            AddHandler b.Click, AddressOf btnSemaineTech_Click
            Me.Controls.Add(b)
        Next

    End Sub

    Private Sub AjoutBtnZoom()
        Dim zP As New Button()
        zP.Text = "Zoom +"
        zP.Height = 20
        zP.Tag = "P"
        zP.Width = 52
        zP.BackColor = Color.Coral
        zP.Left = 10
        zP.Top = 60
        AddHandler zP.Click, AddressOf btnZoom_Click
        Me.Controls.Add(zP)

        Dim zM As New Button()
        zM.Text = "Zoom -"
        zM.Tag = "M"
        zM.Height = 20
        zM.Width = 52
        zM.BackColor = Color.Chartreuse
        zM.Left = 70
        zM.Top = 60
        AddHandler zM.Click, AddressOf btnZoom_Click
        Me.Controls.Add(zM)

    End Sub

    Private Sub btnSemaineTech_Click(ByVal sender As Object, ByVal e As System.EventArgs)

        ptsTrajets = Nothing

        Dim i As Integer = 0
        Dim nPernum As Integer
        Dim nSemaine As Integer
        Dim TechNum As Integer

        If Infos <> "" Then
            nPernum = Infos.Split("|")(0)
            nSemaine = Infos.Split("|")(1)
            TechNum = Infos.Split("|")(2)
        Else
            nPernum = sender.tag.Split("|")(0)
            nSemaine = sender.tag.Split("|")(1)
            TechNum = sender.tag.Split("|")(2)
        End If

        For Each c As Control In Me.Controls
            If TypeOf (c) Is Button Then c.BackColor = Color.PowderBlue
        Next

        ' Ajout du home technicien en début de semaine
        Dim Tech As ClsTechnicien = FrmMainPlanning3S.Techs(TechNum)
        ReDim Preserve ptsTrajets(i)
        ptsTrajets(0) = New PointF(Tech.LON, Tech.LAT)
        i += 1

        For Each Pave As Control In FrmMainPlanning3S.grdvPlanning.Controls
            If TypeOf (Pave) Is Panel AndAlso Not Pave.Tag Is Nothing Then
                Dim IP As New structIP()
                IP = CType(Pave.Tag, structIP)

                ' Si c'est le bon technicien et la bonne semaine
                If IP.NPERNUM = nPernum AndAlso DatePart(DateInterval.WeekOfYear, IP.DIPLDATJ, FirstDayOfWeek.Monday) = nSemaine Then
                    If IP.VCLINOM <> "EMALEC" And IP.VSITNOM <> "MALADIE" And IP.VSITNOM <> "CONGES" Then
                        ReDim Preserve ptsTrajets(i)
                        ptsTrajets(i) = New PointF(IP.SITLON, IP.SITLAT)
                        i += 1
                    End If
                End If

            End If
        Next
        If Infos = "" Then sender.backcolor = Color.DodgerBlue
        Me.Refresh()
    End Sub

    Private Sub frmCarte_MouseDown(ByVal sender As Object, ByVal e As System.Windows.Forms.MouseEventArgs) Handles Me.MouseDown
        bMouseMove = True
    End Sub

    Private Sub frmCarte_MouseMove(ByVal sender As Object, ByVal e As System.Windows.Forms.MouseEventArgs) Handles Me.MouseMove

        If bMouseMove Then
            If prevX <> 0 Then
                posLat = posLat + (e.Y - prevY)
                posLon = posLon + (e.X - prevX)
            End If
            prevX = e.X
            prevY = e.Y
            Me.Refresh()
        End If

    End Sub

    Private Sub frmCarte_MouseUp(ByVal sender As Object, ByVal e As System.Windows.Forms.MouseEventArgs) Handles Me.MouseUp
        bMouseMove = False
        prevX = 0
        prevY = 0
    End Sub

    Private Sub Form1_Paint(ByVal sender As Object, ByVal e As System.Windows.Forms.PaintEventArgs) Handles Me.Paint

        Me.DoubleBuffered = True    ' to prevent flickering
        DrawFranceXml(e.Graphics)

        If Not ptsTrajets Is Nothing Then
            ReDim apiPtsTrajets(ptsTrajets.GetLength(0) - 1)
            For p As Integer = 0 To ptsTrajets.GetLength(0) - 1
                apiPtsTrajets(p) = New PointF(apiLON(ptsTrajets(p).X), apiLAT(ptsTrajets(p).Y))
                e.Graphics.FillRectangle(Brushes.Black, apiPtsTrajets(p).X, apiPtsTrajets(p).Y, 4, 4)
            Next
            If ptsTrajets.GetLength(0) > 1 Then
                e.Graphics.DrawPolygon(Pens.Blue, apiPtsTrajets)
            End If

            ' Affichage du numéro des points
            For j As Integer = 0 To ptsTrajets.GetLength(0) - 1
                e.Graphics.DrawString(If(j = 0, " T", " " & j.ToString()), Me.Font, Brushes.Black, apiPtsTrajets(j))
            Next

        End If

        ' FRANCE NORD-SUD  de 51.08929163224908  à 42.332661601815104
        ' FRANCE OUEST-EST de -4.794158935546875 à 8.20129394531249

        Dim LYON As New PointF(45.751152564512502, 4.8762494647869898)
        Dim PARIS As New PointF(48.858334059662262, 2.342362403869632)
        e.Graphics.FillEllipse(Brushes.Gray, apiRect(LYON))
        e.Graphics.DrawString("LYON", Me.Font, Brushes.Gray, apiLON(LYON.Y) + (2 * iNivZoom), apiLAT(LYON.X))
        e.Graphics.FillEllipse(Brushes.Gray, apiRect(PARIS))
        e.Graphics.DrawString("PARIS", Me.Font, Brushes.Gray, apiLON(PARIS.Y) + (2 * iNivZoom), apiLAT(PARIS.X))
        'Me.Text = "X: " & apiRect(LYON).Y.ToString() & "  Y: " & apiRect(LYON).X.ToString()

    End Sub

    Function apiRect(ByVal pt As PointF) As Rectangle
        Return New Rectangle(apiLON(pt.Y), apiLAT(pt.X), 2 * iNivZoom, 2 * iNivZoom)
    End Function

    Function apiLAT(ByVal lat As Double) As Double
        Dim MaxLat As Double = 51.089291632249079   '50.960373
        Return posLat + ((MaxLat - lat) * (iZoom / 8.7566300304339748))
    End Function

    Function apiLON(ByVal lon As Double) As Double
        Dim MaxLon As Double = 4.7941589349999996 '4.486542
        Return posLon + (MaxLon + lon * (iZoom / 12.995452880859364))
    End Function

    Public Sub DrawFranceXml(ByVal g As Graphics)


        Dim j As Long = 0

        For Each no As XmlNode In XmlDoc.ChildNodes
            Debug.Print(no.Name)
            For Each no2 As XmlNode In no.ChildNodes
                'Debug.Print(no2.Name)
                If no2.Name = "rte" Then

                    Dim i As Integer = 0
                    Dim ptsPays() As Point

                    ReDim ptsPays(no2.ChildNodes.Count - 3)
                    For Each no3 As XmlNode In no2.ChildNodes

                        If no3.Name = "rtept" Then
                            ptsPays(i) = New Point(apiLON(CDbl(no3.Attributes("lon").Value.Replace(".", ","))), apiLAT(CDbl(no3.Attributes("lat").Value.Replace(".", ","))))
                            i += 1

                        End If
                    Next
                    g.DrawPolygon(New Pen(Color.DimGray, 2.0), ptsPays)
                    'g.FillPolygon(Brushes.PeachPuff, ptsPays, Drawing2D.FillMode.Alternate)
                    g.FillPolygon(New SolidBrush(Color.FromArgb(255, 255, 255 - 4 * j, 210 - (j * 6))), ptsPays, Drawing2D.FillMode.Alternate)
                    j += 1
                End If
            Next
        Next

    End Sub

    Private Sub btnZoom_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Me.DoubleClick
        If sender.tag = "M" Then
            If iNivZoom > 1 Then
                iZoom /= 1.3999999999999999
                iNivZoom -= 1
                posLat += 33 * 1.3999999999999999 ^ (iNivZoom - 4)
                posLon += 53 * 1.3999999999999999 ^ (iNivZoom - 4)
            End If
        Else
            If iNivZoom < 10 Then
                Dim diff As Integer = iZoom * 0.40000000000000002
                iZoom *= 1.3999999999999999
                posLat -= 135 * 1.3999999999999999 ^ (iNivZoom - 4)
                posLon -= 85 * 1.3999999999999999 ^ (iNivZoom - 4)
                iNivZoom += 1
            End If
        End If
        Me.Refresh()
    End Sub

End Class