Imports System.Data
Imports System.Data.SqlClient
Imports System.Drawing.Drawing2D
Imports MozartLib

Public Class FrmMainPlanning3S

#Region "Variables et structures"

  Dim tabSpec() As String = {"", "Climaticiens", "Courant faible", "Courant fort", "Multitech", "", "", "Second oeuvre", "Plomberie"}

  Public DebutSemaine As Date
  Public Techs As New Collection
  Public FirstTech As Integer = 1
  Public LastTech As Integer = 0
  'Public giNumDi As Long
  'Public giNumAct As Long 'utiliser pour récupérer le NACTNUM pour l'ouverture d'une Di dans Mozart

  Const cstNbJours As Integer = 21
  Const cstNbTechs As Integer = 5

  Dim mFindString As String = ""
  Dim dr As SqlDataReader = Nothing

  Dim bDropedPave As Boolean = False
  Dim bAffichageCompetences As Boolean = False

  Dim FontPave As New Font(FontFamily.GenericSansSerif, 9.0, FontStyle.Regular, GraphicsUnit.Pixel)
  Dim FontGrosPave As New Font(FontFamily.GenericSansSerif, 14.0, FontStyle.Bold, GraphicsUnit.Pixel)
  Dim FontNomPer As New Font(FontFamily.GenericSansSerif, 12.0, FontStyle.Bold, GraphicsUnit.Pixel)
  Dim FontKM As New Font(FontFamily.GenericSerif, 12.0, FontStyle.Bold, GraphicsUnit.Pixel)

  Dim DtSitSociete As DataTable
  Dim iNumClientSOCIETE As Integer

  Dim iIndicCarte As Integer = 1  'Utiliser pour afficher le N° correspondant sur la carte

#End Region

  Private Sub FrmMainPlanning3S_Load(ByVal sender As Object, ByVal e As System.EventArgs) Handles Me.Load

    DebutSemaine = Date.Today.AddDays(-Date.Today.DayOfWeek + 1)

    Select Case MozartParams.NomSociete
      Case "EMALEC"
        iNumClientSOCIETE = 108
      Case "EQUIPAGE"
        iNumClientSOCIETE = 3001
      Case "EMALECMPM"
        iNumClientSOCIETE = 16194
      Case "SCS"
        iNumClientSOCIETE = 4030
      Case "MAGESTIME"
        iNumClientSOCIETE = 8396
      Case "EMALECESPAGNE"
        iNumClientSOCIETE = 13945
      Case "EMALECIDF"
        iNumClientSOCIETE = 14274
      Case "EMALECLUXEMBOURG"
        iNumClientSOCIETE = 14863
      Case "EMALECFACILITEAM"
        iNumClientSOCIETE = 15015
      Case Else
        iNumClientSOCIETE = 108
    End Select

    ' cnx2.ConnectionString = cnx.ConnectionString
    ' cnx2.Open()

    Techs = GetTechniciens(cboTechs, "Combo", "TOUS")

    'on charge les listes des sites de la societe (gestion de la couleur jaune)
    DtSitSociete = New DataTable
    DtSitSociete = GetMozart_Soc_By_NomSociete(MozartParams.NomSociete)

    For i As Integer = 1 To cstNbTechs
      For s As Integer = 0 To 2
        DrawBtnCarte("T" & i & "S" & s, s, ((i - 1) * 180) + 2 * 100.0)
      Next
    Next

    DrawPlanning()

  End Sub

  Private Sub DrawBtnCarte(ByVal sName As String, ByVal iPos As Integer, ByVal yPos As Integer)
    Dim b As New Button()
    b.Name = sName
    b.Text = "S" & iPos + 1
    b.Top = yPos
    b.Left = 5 + (iPos * 45)
    b.Width = 42
    pnlTechs.Controls.Add(b)
    AddHandler b.Click, AddressOf bCarte_click
  End Sub


  Private Sub FrmMainPlanning3S_KeyDown(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyEventArgs) Handles Me.KeyDown
    If e.KeyValue = Keys.F5 Then
      DrawPlanning()
    ElseIf e.KeyData.ToString.Length = 1 Or e.KeyData = Keys.Enter Or e.KeyData = Keys.Back Then
      cboTechs_KeyDown(sender, e)
    End If
  End Sub

  Private Sub btnTechsSpecialistes_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) _
  Handles btnTechsClim.Click, btnTechsCFaible.Click, btnTechsCFort.Click, btnTechsMultitech.Click, btnTechsPlomb.Click, btnTechsSecOeuvre.Click, btnTechsCouvreur.Click, BtnTechEI.Click, BtnCommerce.Click
    Techs.Clear()
    cboTechs.Items.Clear()
    FirstTech = 1

    Dim sSender As String = sender.text

    btnTechsClim.Text = My.Resources.Planification_FrmMainPlanning3S_Climaticiens
    btnTechsCFaible.Text = My.Resources.Planification_FrmMainPlanning3S_Courant_faible
    btnTechsCFort.Text = My.Resources.Planification_FrmMainPlanning3S_Courant_fort
    btnTechsMultitech.Text = My.Resources.Planification_FrmMainPlanning3S_Multitech
    btnTechsSecOeuvre.Text = My.Resources.Planification_FrmMainPlanning3S_SeconOeuvre
    btnTechsPlomb.Text = My.Resources.Planification_FrmMainPlanning3S_Plomberie
    btnTechsCouvreur.Text = My.Resources.Planification_FrmMainPlanning3S_Couvreur
    BtnTechEI.Text = "Ext inc."
    BtnCommerce.Text = My.Resources.Planification_FrmMainPlanning3S_Commercial

    If sSender = "TOUS" Then
      Techs = GetTechniciens(cboTechs, "Combo", "TOUS")
      btnMaps.Visible = False
    Else
      Techs = GetTechniciens(cboTechs, "Combo", sender.tag)
      btnMaps.Visible = True
      sender.text = "TOUS"
    End If
    btnMaps.Tag = sender.tag

    DrawPlanning()

  End Sub

  Private Sub btnSelectTech_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnSelectTech.Click
    Dim oFrmListeTechs As New frmListeTechs
    oFrmListeTechs.NbTechsMax = cstNbTechs

    If oFrmListeTechs.ShowDialog() = Windows.Forms.DialogResult.OK Then
      FirstTech = 1
      Techs = oFrmListeTechs.returnTechs
      DrawPlanning()
    End If

  End Sub

  Private Sub btnMaps_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnMaps.Click
    FrmBrowser.StartingAddress = "https://maps.emalec.com/TrajetSemaineService.asp?Base=" & MozartParams.NomSociete & "&Ser=" & btnMaps.Tag & "&Semaine=" & DebutSemaine
    FrmBrowser.ShowDialog()
  End Sub

  Private Sub btnRefresh_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnRefresh.Click
    DrawPlanning()
  End Sub

  Private Sub Pave_Paint(ByVal sender As System.Object, ByVal e As System.Windows.Forms.PaintEventArgs)
    PaintPave(e.Graphics, e.ClipRectangle, sender.tag, Brushes.BurlyWood)
  End Sub

  Private Sub Pave_MouseDown(ByVal sender As Object, ByVal e As System.Windows.Forms.MouseEventArgs)
    If e.Button = Windows.Forms.MouseButtons.Left Then

      Dim pave As New Panel()
      pave = CType(sender, Panel)
      pave.BorderStyle = BorderStyle.Fixed3D
      pave.DoDragDrop(pave, DragDropEffects.Copy)
      bDropedPave = True
    Else
      Dim p As New Panel()
      p.Location = sender.location
      ' Repositionnement si ça déborde à droite ou en bas
      If p.Location.X > Me.Width - (sender.width * 4.2) - 120 Then
        p.Location -= New Point(50, 0)
      End If
      If p.Location.Y > Me.Height - (sender.height * 2.7) - 100 Then
        p.Location -= New Point(0, 50)
      End If

      p.Width = sender.width * 4.2
      p.Height = sender.height * 2.7
      p.BackColor = Color.LightGray
      p.BorderStyle = BorderStyle.Fixed3D
      p.Tag = sender.tag
      grdvPlanning.Controls.Add(p)
      AddHandler p.Paint, AddressOf MagnifyPave_Paint
      AddHandler p.Click, AddressOf MagnifyPave_Click

      ' bouton pour détail DI
      Dim b As New Button
      b.Width = 30
      b.Height = 20
      b.Left = p.Width - b.Width - 5
      b.Top = p.Height - b.Height - 3
      b.Text = "DI"
      b.Tag = CType(sender.tag, structIP).NIPLNUM
      p.Controls.Add(b)
      AddHandler b.Click, AddressOf DI_Click

      ' bouton pour supprimer IP
      Dim b2 As New Button
      b2.Width = 70
      b2.Height = 20
      b2.Left = p.Width - b2.Width - 5
      b2.Top = p.Height - b2.Height - 26
      b2.Text = "Supprimer IP"
      b2.Tag = sender.tag
      p.Controls.Add(b2)
      AddHandler b2.Click, AddressOf SUP_Click

      'visualiser OT
      ' FGB 25/01/2024 : Voir si ils s'aperçoivent que ce bouton a disparu :)
      'Dim btnVisuOT As New Button With {
      '  .Width = 70,
      '  .Height = 20
      '}
      'btnVisuOT.Left = p.Width - btnVisuOT.Width - b2.Width - 5
      'btnVisuOT.Top = p.Height - btnVisuOT.Height - 26
      'btnVisuOT.Text = "Visu OT"
      'btnVisuOT.Tag = sender.tag
      'p.Controls.Add(btnVisuOT)
      'AddHandler btnVisuOT.Click, AddressOf BtnVisuOT_Click

      ' labelle de cp
      Dim b3 As New Label
      b3.BackColor = Color.Aqua
      b3.Width = 70
      b3.Height = 16
      b3.Left = p.Width - b3.Width - 5
      b3.Top = p.Height - b3.Height - 48
      Dim cmd As New SqlCommand("SELECT VSITCP FROM TACT A WITH (NOLOCK) , TSIT S WITH (NOLOCK) WHERE A.NSITNUM=S.NSITNUM AND NIPLNUM = " & CType(sender.tag, structIP).NIPLNUM, MozartDatabase.cnxMozart)
      dr = cmd.ExecuteReader()
      dr.Read()
      b3.Text = "CP : " & dr("VSITCP")
      dr.Close()
      p.Controls.Add(b3)
      p.BringToFront()

      Dim oLblBlock As New Label
      oLblBlock.Width = 25
      oLblBlock.Height = 25
      oLblBlock.Left = p.Width - oLblBlock.Width - 50
      oLblBlock.Top = p.Height - oLblBlock.Height - 10
      oLblBlock.Font = New Font(FontFamily.GenericSansSerif, 16, FontStyle.Bold)
      oLblBlock.ForeColor = Color.Red
      oLblBlock.BackColor = Color.Transparent
      oLblBlock.Text = ReturnChampPaveBlock(CType(sender.tag, structIP).BACTPAVEBLOCK)
      p.Controls.Add(oLblBlock)
      p.BringToFront()

    End If
  End Sub

  Private Sub DI_Click(ByVal sender As Object, ByVal e As System.EventArgs)
    Dim btnRet As DialogResult = DialogResult.OK

    ' affichage(d) 'une fenetre avec detail de l'IP
    Dim cmd As New SqlCommand("select count(NACTNUM) from TACT where NIPLNUM = " & sender.tag, MozartDatabase.cnxMozart)
    Dim iNbDi As Integer = cmd.ExecuteScalar()

    If iNbDi > 1 Then
      Dim oForm As New FrmDetailIp
      oForm.miNumIP = sender.tag
      If oForm.ShowDialog() = Windows.Forms.DialogResult.OK Then
        Shell(Environment.GetFolderPath(Environment.SpecialFolder.ProgramFilesX86) & "\mozart\SynchroMozart.exe " & MozartParams.NomServeur & ";" & MozartParams.NomSociete & ";" & oForm.numDI & ";" & oForm.numACT, vbMaximizedFocus)
      End If
      ' Nettoyage
      oForm = Nothing
    Else
      cmd = New SqlCommand("select NDINNUM, NACTNUM FROM TACT WHERE NIPLNUM = " & sender.tag, MozartDatabase.cnxMozart)
      Dim SDRDiMozart As SqlClient.SqlDataReader = cmd.ExecuteReader()
      SDRDiMozart.Read()
      If SDRDiMozart.HasRows = True Then
        Dim iNumDi As Integer = SDRDiMozart("NDINNUM")
        Dim iNumAct As Integer = SDRDiMozart("NACTNUM")
        Shell(Environment.GetFolderPath(Environment.SpecialFolder.ProgramFilesX86) & "\mozart\SynchroMozart.exe " & MozartParams.NomServeur & ";" & MozartParams.NomSociete & ";" & iNumDi.ToString & ";" & iNumAct.ToString, vbMaximizedFocus)
      End If
      SDRDiMozart.Close()
      cmd.Dispose()
    End If

  End Sub

  Private Sub SUP_Click(ByVal sender As Object, ByVal e As System.EventArgs)

    ' Dim btnRet As DialogResult = DialogResult.OK

    ' Vérifications (déplacement d'une IP avec information au client, aide sur intervention, IP Emalec, action bloque)
    Dim IPSource As structIP = sender.Tag
    Try
      If Not Verifications(IPSource.NIPLNUM, IPSource.DIPLDATJ, IPSource.NSITNUM, iNumClientSOCIETE, , , True) Then
        Exit Sub
      Else
        ' CONFIRMATION DE LA SUPPRESSION
        Select Case MsgBox(My.Resources.Planification_FrmMainPlanning3S_SupPlanif, vbYesNo + vbQuestion + vbDefaultButton2)
          Case vbYes
            Dim cmd As New SqlCommand("api_sp_SupprimerIP " & IPSource.NIPLNUM & ", '" & IPSource.DIPLDATJ & "'", MozartDatabase.cnxMozart)
            Dim lbCP As String = cmd.ExecuteScalar()
            'MsgBox("date: " & IPSource.DIPLDATJ)
            AddLogIPL(IPSource.NIPLNUM, "S")
          Case vbNo
            Exit Sub
        End Select

        ' initialisation du planning
        DrawPlanning()

      End If
    Catch ex As Exception
      MessageBox.Show(ex.Message & vbCrLf & vbCrLf & My.Resources.Global_dans & System.Reflection.MethodBase.GetCurrentMethod.Name & " (2)")
    End Try

  End Sub

  Private Sub Pave_DragDrop(ByVal sender As Object, ByVal e As System.Windows.Forms.DragEventArgs)
    Dim pave As New Panel()
    pave = e.Data.GetData(e.Data.GetFormats()(0))
    PaveDragDrop(sender, pave)
  End Sub

  Private Sub pnlCommandes_DragDrop(ByVal sender As Object, ByVal e As System.Windows.Forms.DragEventArgs) Handles pnlCommandes.DragDrop
    Dim pave As New Panel()
    pave = e.Data.GetData(e.Data.GetFormats()(0))

    ' Vérifications (déplacement d'une IP avec information au client, aide sur intervention, IP Emalec, action bloque)
    Dim IPSource As structIP = pave.Tag

    If Not Verifications(IPSource.NIPLNUM, IPSource.DIPLDATJ, IPSource.NSITNUM, iNumClientSOCIETE, , , True) Then
      Exit Sub
    Else
      pave.Left = 90 : pave.Top = 25
      pave.Name = "DropPave"
      pnlCommandes.Controls.Add(pave)
      pnlCommandes.BackColor = Color.Red
      Timer1.Enabled = True
    End If

  End Sub

  Private Sub Pave_DragEnter(ByVal sender As Object, ByVal e As System.Windows.Forms.DragEventArgs)
    e.Effect = DragDropEffects.Copy ' Allow drop.
  End Sub

  Private Sub pnlCommandes_DragEnter(ByVal sender As Object, ByVal e As System.Windows.Forms.DragEventArgs) Handles pnlCommandes.DragEnter
    e.Effect = DragDropEffects.Copy ' Allow drop.
  End Sub

  Private Sub grdvPlanning_DragDrop(sender As Object, e As System.Windows.Forms.DragEventArgs) Handles grdvPlanning.DragDrop

    ' Récupérer le pavé bougé
    Dim pave As Panel = e.Data.GetData(e.Data.GetFormats()(0))

    ' Position de la souris au DragDrop par rapport au DataGridView
    Dim pt As Point = Me.PointToClient(MousePosition)
    pt -= grdvPlanning.Location

    ' Retrouver la ligne et la colonne du Drop
    Dim hti As DataGridView.HitTestInfo = grdvPlanning.HitTest(pt.X, pt.Y)
    Dim rcDest As Rectangle = grdvPlanning.GetCellDisplayRectangle(hti.ColumnIndex, hti.RowIndex, True)

    Dim LocCtrl As Control = grdvPlanning.GetChildAtPoint(rcDest.Location, GetChildAtPointSkip.None)

    ' On le bouge si on n'est pas sur un autre pavé
    If LocCtrl Is Nothing Then
      GridDragDrop(pave.Tag, hti.RowIndex, hti.ColumnIndex)
    End If

    pave.BorderStyle = BorderStyle.FixedSingle

    sender.Refresh()

  End Sub

  Private Sub grdvPlanning_DragEnter(sender As Object, e As System.Windows.Forms.DragEventArgs) Handles grdvPlanning.DragEnter
    e.Effect = DragDropEffects.Copy ' Allow drop.
  End Sub

  Private Sub DrawGrille()
    grdvPlanning.SuspendLayout()

    grdvPlanning.Rows.Clear()
    grdvPlanning.Columns.Clear()

    grdvPlanning.EnableHeadersVisualStyles = False 'passage à false pour la gestion couleur des entete des collones

    While grdvPlanning.Controls.Count > 2
      grdvPlanning.Controls.Clear()
    End While

    ' recherche du numéro de semaine
    Me.Text = My.Resources.Planification_FrmMainPlanning3S_Planning_week & WeekNumber(DebutSemaine).ToString() & " / " & DebutSemaine.Year.ToString()

    Dim HeaderDate As Date
    Dim iCol As Integer = 0
    Dim iLgCol As Integer = (grdvPlanning.Width - 18) / cstNbJours

    ' affichage des jours de la semaine (prise en compte des congés)
    For iJour As Integer = 1 To cstNbJours + 2
      iCol = iJour - 1
      HeaderDate = DebutSemaine.AddDays(iCol - (iJour \ 8))

      grdvPlanning.Columns.Add(HeaderDate.ToShortDateString(), Format(HeaderDate, "d MMM"))

      If iJour Mod 8 = 0 Then
        grdvPlanning.Columns(iCol).Width = 4
        grdvPlanning.Columns(iCol).DefaultCellStyle.BackColor = Color.Lime
      Else
        grdvPlanning.Columns(iCol).Width = iLgCol

        If IsFeriee(HeaderDate) Then
          grdvPlanning.Columns(iCol).HeaderCell.Style.BackColor = Color.Red
        Else
          Select Case HeaderDate.DayOfWeek
            Case DayOfWeek.Saturday, DayOfWeek.Sunday
              grdvPlanning.Columns(iCol).HeaderCell.Style.BackColor = Color.Black
            Case Else
              grdvPlanning.Columns(iCol).HeaderCell.Style.BackColor = Color.Blue
          End Select
        End If
      End If
    Next

    ' Création des lignes du DataGrid
    For i As Integer = 1 To cstNbTechs * 6
      grdvPlanning.Rows.Add()
      If i Mod 6 = 0 Then
        grdvPlanning.Rows(i - 1).Height = 4
        grdvPlanning.Rows(i - 1).DefaultCellStyle.BackColor = Color.Lime
      Else
        grdvPlanning.Rows(i - 1).Height = 36
      End If
    Next

    grdvPlanning.ResumeLayout()
  End Sub

  Private Sub CreatePave(ByVal IP As structIP, ByVal iC As Integer, ByVal iR As Integer)
    Dim c As DataGridViewCell = grdvPlanning.Rows(iR).Cells(iC)
    Dim p As New Panel

    p.BorderStyle = BorderStyle.FixedSingle
    p.Name = "P" & iR.ToString() & iC.ToString()

    p.Tag = IP
    p.Location = grdvPlanning.GetCellDisplayRectangle(iC, iR, True).Location
    p.Size = c.Size


    ' pour les sites emalec spéciaux couleur : jaune
    If DtSitSociete.Select("NSITNUM = " & IP.NSITNUM).Count > 0 Then 'IP.VCLINOM = "EMALEC" Then
      p.BackColor = Color.Yellow
    Else
      'couleur standard = bleu clair
      p.BackColor = Color.LightBlue

      If IP.CIPLMULT = "O" Then p.BackColor = Color.DeepSkyBlue ' si multi-jour : bleu foncé
      If IP.CACTNUIT = "O" Then p.BackColor = Color.Red ' si c'est la nuit :  rouge
      If IP.CACTNUIT = "P" Then p.BackColor = Color.Thistle ' nuit + hors présence public : rouge clair

      ' si date d'execution : orange,  si attachement (et exécution): Vert
      p.BackColor = CouleurExecution(IP.NIPLNUM, p.BackColor)

      ' si facture, et exec, et attach : blanc
      If IP.NBFACT > 0 And p.BackColor = Color.LightGreen Then p.BackColor = Color.White

      'si  si autre personne sur site au meme moment = bleu clair
      If p.BackColor = Color.LightBlue Then
        If Not VerifAide(IP.NIPLNUM, False) Then p.BackColor = Color.Violet
      End If

    End If

    p.AllowDrop = True
    AddHandler p.Paint, AddressOf Pave_Paint
    AddHandler p.MouseDown, AddressOf Pave_MouseDown
    AddHandler p.DragEnter, AddressOf Pave_DragEnter
    AddHandler p.DragDrop, AddressOf Pave_DragDrop

    grdvPlanning.Controls.Add(p)
  End Sub

  Private Sub PaintPave(ByVal G As Graphics, ByVal Rect As Rectangle, ByVal InfosIP As structIP, ByVal br As Brush)

    Try

      ' Dessin de la barre de distance en haut du pavé
      G.FillRectangle(Brushes.Lime, New Rectangle(0, 0, InfosIP.Dist / 300 * Rect.Width, (Rect.Height / 3) + 1))

      'If InfosIP.bContratOK = 0 Then
      If bAffichageCompetences AndAlso InfosIP.bCOMPETENT < 0 Then
        G.DrawLine(New Pen(Color.Black, 2), 0, 0, Rect.Width, Rect.Height)
        G.DrawLine(New Pen(Color.Black, 2), 0, Rect.Height, Rect.Width, 0)
        'G.FillRectangle(Brushes.Orange, New Rectangle(0, (Rect.Height / 3), Rect.Width, (Rect.Height / 3)))
      End If

      ' affichage des informations dans l'image
      Dim sInter As String = InfosIP.VCLINOM & vbCrLf & InfosIP.VSITNOM & vbCrLf & " " & InfosIP.NIPLDURJ.ToString() & "h  " & InfosIP.SCODE

      G.DrawString(ReturnChampPaveBlock(InfosIP.BACTPAVEBLOCK), New Font(FontFamily.GenericSansSerif, 8, FontStyle.Bold), Brushes.Red, 70.0, 20.0)

      If InfosIP.NBFACT > 0 Then sInter = sInter & "  €"
      If InfosIP.PREVMAG > 0 Then sInter = sInter & "  #"

      sInter = sInter + Space(10) + InfosIP.NIPLIND.ToString

      G.DrawString(sInter, FontPave, Brushes.Black, 2.0, 1.0)

    Catch ex As Exception
      MessageBox.Show(ex.Message & vbCrLf & vbCrLf & My.Resources.Planification_FrmMainPlanning3S_dansPaintPave)
    End Try

  End Sub

  Private Function ReturnChampPaveBlock(ByVal p_BPACTPACTPAVEBLOCK As Boolean) As String

    Try

      Select Case p_BPACTPACTPAVEBLOCK
        Case True
          Return "B"
        Case Else
          Return ""
      End Select

    Catch ex As Exception

      MessageBox.Show(ex.Message & vbCrLf & vbCrLf & My.Resources.Global_dans & System.Reflection.MethodBase.GetCurrentMethod.Name, My.Resources.Global_Erreur)
      Return ""

    End Try

  End Function

  Private Sub PaintGrosPave(ByVal G As Graphics, ByVal InfosIP As structIP, ByVal br As Brush)

    Dim GrdBrush As New LinearGradientBrush(New Point(0, 0), New Point(300, 100), Color.Azure, Color.Yellow)
    G.FillRectangle(GrdBrush, G.ClipBounds())

    ' affichage des informations dans l'image
    Dim inter As String = InfosIP.VCLINOM & vbCrLf & InfosIP.VSITNOM & vbCrLf & " " & InfosIP.NIPLDURJ.ToString() & "h  " & InfosIP.SCODE.ToString()
    If InfosIP.NBFACT > 0 Then inter &= vbCrLf & My.Resources.Planification_FrmMainPlanning3S_Facturé
    If InfosIP.PREVMAG = True Then inter &= vbCrLf & My.Resources.Planification_FrmMainPlanning3S_Site_info
    If InfosIP.CIPLMULT = "O" Then inter &= vbCrLf & My.Resources.Planification_FrmMainPlanning3S_inter_multi_jours
    If InfosIP.CACTNUIT = "O" Then inter &= vbCrLf & My.Resources.Planification_FrmMainPlanning3S_inter_nuits
    If InfosIP.CACTNUIT = "P" Then inter &= vbCrLf & My.Resources.Planification_FrmMainPlanning3S_hors_pub

    If InfosIP.PREVMAG > 0 Then inter = inter & "  #"

    G.DrawString(inter, FontGrosPave, Brushes.Blue, 2.0, 2.0)

  End Sub

  Private Sub MagnifyPave_Paint(ByVal sender As System.Object, ByVal e As System.Windows.Forms.PaintEventArgs)
    PaintGrosPave(e.Graphics, sender.tag, Brushes.LightGray)
  End Sub

  Private Sub MagnifyPave_Click(ByVal sender As Object, ByVal e As System.EventArgs)
    grdvPlanning.Controls.Remove(sender)
  End Sub

  Private Sub DrawPlanning(Optional ByVal iCacherIP As Long = 0)

    Dim IP As New structIP()
    Dim nbH As Double = 0                                        ' nombre d'heure du technicien dans la semaine
    Dim CurrentTech As Integer = 0
    Dim PosX As Integer = 0
    Dim PosY As Integer = 0
    Dim iSem As Integer = 0
    Dim cmd As New SqlCommand("", MozartDatabase.cnxMozart)

    Try

      Cursor.Current = Cursors.WaitCursor
      Me.SuspendLayout()
      grdvPlanning.SuspendLayout()

      LastTech = Math.Min(FirstTech + cstNbTechs - 1, Techs.Count)

      Me.pnlTechs.BackColor = Color.DimGray

      DrawGrille()
      pnlTechs.Refresh()


      ' placement des interventions
      For cptTech As Integer = FirstTech To LastTech
        CurrentTech += 1
        iIndicCarte = 1
        nbH = 0

        ' liste des interventions par techniciens pour la semaine en cours
        Dim UnTech As ClsTechnicien = CType(Techs(cptTech), ClsTechnicien)

        If UnTech.NPERNUM <> 0 Then

          UnTech.NBH_SEM1 = 0.0 : UnTech.NBH_SEM2 = 0.0 : UnTech.NBH_SEM3 = 0.0
          UnTech.bCalculDist = False : UnTech.NKM_SEM1 = 0 : UnTech.NKM_SEM2 = 0 : UnTech.NKM_SEM3 = 0

          'cmd = New SqlCommand("api_sp_listeInterventions " & UnTech.NPERNUM & ", '" & DebutSemaine & "', 20, 12", cnx)
          cmd.CommandText = "api_sp_listeInterventions3S " & UnTech.NPERNUM & ", '" & DebutSemaine & "', 20, 12"
          Try
            dr = cmd.ExecuteReader()

            While dr.Read()
              'on affiche seulement les 5 premiers pavés mais on prend tous les pavés pour le calcul du nombre d'heures
              If dr("NIPLIND") <= 5 Then

                iIndicCarte += 1

                ' Position du panel dans la GridView
                PosX = DateDiff(DateInterval.Day, DebutSemaine, dr("DIPLDATJ"))
                PosX += PosX \ 7
                PosY = ((CurrentTech - 1) * 6) + dr("NIPLIND") - 1

                ' Constitution d'une IP ( code, NumIP, NumSite, NumAction(null), text, duree, premierJ , tech)
                IP.TYPEIP = "D"
                IP.NIPLNUM = dr("NIPLNUM")
                IP.NSITNUM = dr("NSITNUM")
                IP.NACTNUM = 0
                IP.NPERNUM = dr("NPERNUM")
                IP.VCLINOM = dr("VCLINOM")
                IP.VSITNOM = dr("VSITNOM")
                IP.NIPLDUR = dr("NIPLDUR")
                IP.NIPLDURJ = dr("NIPLDURJ")
                IP.CIPLDEB = dr("CIPLDEB")
                IP.DIPLDATJ = dr("DIPLDATJ")
                IP.CIPLMULT = dr("CIPLMULT")
                IP.CACTNUIT = dr("CACTNUIT")
                IP.PREVMAG = dr("PREVMAG")
                IP.NBFACT = dr("NBFACT")
                IP.SCODE = dr("SCODE")
                IP.PERLAT = If(dr("FPERLAT").ToString = "", 0, dr("FPERLAT"))
                IP.PERLON = If(dr("FPERLON").ToString = "", 0, dr("FPERLON"))
                IP.SITLAT = dr("FSITLAT")
                IP.SITLON = dr("FSITLON")
                IP.bCOMPETENT = dr("BCOMPETENT")
                IP.NIPLIND = iIndicCarte
                IP.bContratOK = -1
                IP.Dist = -1
                IP.BACTPAVEBLOCK = dr("BACTPAVEBLOCK")

                CreatePave(IP, PosX, PosY) ' création d'une IP

              End If
              Try
                Select Case PosX ' calcul du nombre d'heure par semaine
                  Case 0 To 6
                    UnTech.NBH_SEM1 += dr("NIPLDURJ")
                    iSem = 0
                    iIndicCarte = 1
                  Case 8 To 14
                    UnTech.NBH_SEM2 += dr("NIPLDURJ")
                    iSem = 1
                    iIndicCarte = 1
                  Case 16 To 22
                    UnTech.NBH_SEM3 += dr("NIPLDURJ")
                    iSem = 2
                    iIndicCarte = 1
                End Select
              Catch
                MsgBox("Erreur détectée :" & vbCrLf & " - PosX=" & PosX & vbCrLf & " - iSem=" & iSem & vbCrLf & " - iIndicCarte=" & iIndicCarte, MsgBoxStyle.Critical + MsgBoxStyle.OkOnly, "TEST ERREUR")
              End Try

              Dim b As Button = pnlTechs.Controls("T" & CurrentTech & "S" & iSem)
              b.Tag = Techs(cptTech).NPERNUM & "|" & (DatePart(DateInterval.WeekOfYear, DebutSemaine) + iSem).ToString() & "|" & cptTech.ToString()

            End While
          Catch ex As Exception
            MessageBox.Show(ex.Message & vbCrLf & vbCrLf & "dans : " & System.Reflection.MethodBase.GetCurrentMethod.Name & " (1)")
          Finally
            If Not dr Is Nothing Then dr.Close()
          End Try

        End If

      Next

    Catch ex As Exception
      MessageBox.Show(ex.Message & vbCrLf & vbCrLf & My.Resources.Global_dans & System.Reflection.MethodBase.GetCurrentMethod.Name & " (2)")
    Finally
      grdvPlanning.ResumeLayout()
      Me.ResumeLayout()

      Me.pnlTechs.BackColor = Color.Silver
      Cursor.Current = Cursors.Default
    End Try
  End Sub

  Private Sub pnlTechs_Paint(ByVal sender As System.Object, ByVal e As System.Windows.Forms.PaintEventArgs) Handles pnlTechs.Paint

    ' Ecrire les informations techniciens dans le panel de gauche
    For i As Integer = 0 To Math.Min(cstNbTechs - 1, LastTech - FirstTech)
      Dim Per As ClsTechnicien = Techs(FirstTech + i)

      'fond si contre maitre
      If Per.CPERTYPDETAIL = "CM" Then e.Graphics.FillRectangle(Brushes.CornflowerBlue, New Rectangle(0, (i * 181) + 55, 214, 170))

      e.Graphics.DrawString(Per.VPERNOM, FontNomPer, Brushes.Blue, 5.0, (i * 180) + 2 * 30.0)
      e.Graphics.DrawString(Per.VSERLIB & vbCrLf & Per.VREGLIB, FontNomPer, Brushes.BlueViolet, 5.0, (i * 180) + 2 * 36.0)

      If Per.VTUTEUR <> "" Then e.Graphics.DrawString(My.Resources.Planification_FrmMainPlanning3S_Tuteur + " : " + Per.VTUTEUR, FontNomPer, Brushes.Black, 5.0, (i * 180) + 2 * 49.0)

      e.Graphics.DrawString(Per.VTYPEDETAILLIB, FontNomPer, Brushes.Black, 5.0, (i * 180) + 2 * 55.0)
      e.Graphics.DrawString(Per.VPERTYPEPOSTE, FontNomPer, Brushes.Black, 5.0, (i * 180) + 2 * 61.0)

      If Per.VSITNOM_POSTE <> "" Then
        e.Graphics.DrawString(String.Format("{0} : {1}" & vbCrLf & "{2} : {3}", My.Resources.Planification_FrmMainPlanning3S_Client, Per.VCLINOM_POSTE, My.Resources.Planification_FrmMainPlanning3S_Site, Per.VSITNOM_POSTE), FontNomPer, Brushes.Black, 5.0, (i * 180) + 2 * 67.0)
      End If

      If Per.VPERPERMI <> "B" Or Per.VPERPERMI = "" Then
        e.Graphics.DrawString(String.Format("{0} : {1}", My.Resources.Planification_FrmMainPlanning3S_Permis, Per.VPERPERMI.Replace("B,", "")), FontNomPer, Brushes.Black, 5.0, (i * 180) + 2 * 81.0)

      End If

      e.Graphics.DrawString(Format(Per.NBH_SEM1, "#0 h"), FontKM, Brushes.Blue, 5.0, (i * 180) + 2 * 92.0)
      e.Graphics.DrawString(Format(Per.NBH_SEM2, "#0 h"), FontKM, Brushes.Blue, 50.0, (i * 180) + 2 * 92.0)
      e.Graphics.DrawString(Format(Per.NBH_SEM3, "#0 h"), FontKM, Brushes.Blue, 95.0, (i * 180) + 2 * 92.0)

      If Per.bCalculDist Then
        e.Graphics.DrawString(Format(Per.NKM_SEM1, "#0 k"), FontKM, If(Per.NKM_SEM1 >= 500, Brushes.Red, Brushes.Blue), 5.0, (i * 180) + 2 * 92.0)
        e.Graphics.DrawString(Format(Per.NKM_SEM2, "#0 k"), FontKM, If(Per.NKM_SEM2 >= 500, Brushes.Red, Brushes.Blue), 50.0, (i * 180) + 2 * 92.0)
        e.Graphics.DrawString(Format(Per.NKM_SEM3, "#0 k"), FontKM, If(Per.NKM_SEM3 >= 500, Brushes.Red, Brushes.Blue), 95.0, (i * 180) + 2 * 92.0)
      End If

    Next
  End Sub

  Private Sub btnSemPrec_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnSemPrec.Click
    DebutSemaine = DebutSemaine.AddDays(-7)
    DrawPlanning()
  End Sub

  Private Sub btnSemSuiv_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnSemSuiv.Click
    DebutSemaine = DebutSemaine.AddDays(+7)
    DrawPlanning()
  End Sub

  Private Sub btnTechPrec_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnTechPrec.Click
    If FirstTech <> Math.Max(1, FirstTech - cstNbTechs) Then
      FirstTech = Math.Max(1, FirstTech - cstNbTechs)
      DrawPlanning()
    End If
  End Sub

  Private Sub btnTechSuiv_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnTechSuiv.Click
    If FirstTech < Techs.Count - cstNbTechs Then
      FirstTech = Math.Min(FirstTech + cstNbTechs, Techs.Count)
      DrawPlanning()
    End If
  End Sub

  Private Sub cboTechs_KeyDown(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyEventArgs) Handles cboTechs.KeyDown

    ' Ne pas envoyer la touche au controle
    e.SuppressKeyPress = True

    ' Si touche RETURN on déclenche le positionnement sur le bon technicien
    If e.KeyValue = Keys.Return Then
      mFindString = ""
      cboTechs_SelectedIndexChanged(Nothing, Nothing)
      Exit Sub
    End If

    ' Si touche BACK on efface
    If e.KeyValue = Keys.Back Then
      mFindString = mFindString.Substring(0, Math.Max(0, mFindString.Length - 1))
    Else
      mFindString &= e.KeyData.ToString()
    End If
    ' Autres touches
    Dim index As Integer = cboTechs.FindString(mFindString)
    If index > 0 Then cboTechs.SelectedIndex = index
    Me.Text = My.Resources.Planification_FrmMainPlanning3S_Recherche_tech & mFindString

  End Sub

  Private Sub cboTechs_SelectedIndexChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles cboTechs.SelectedIndexChanged
    ' Position du 1er technicien à afficher (au milieu si possible)
    If mFindString = "" And cboTechs.SelectedIndex > 0 Then
      FirstTech = Math.Max(1, Math.Min(cboTechs.SelectedItem.INDEX - CInt(cstNbTechs / 2), cboTechs.Items.Count - cstNbTechs))
      '			LastTech = Math.Min(FirstTech + cstNbTechs - 1, Techs.Count)
      DrawPlanning()
    End If
  End Sub

  Private Sub PaveDragDrop(ByVal PaveSource As Panel, ByVal PaveDest As Panel) ', Optional ByVal Index As Integer, optional ByVal Source As Control, optional ByVal X As Single, optional ByVal Y As Single)
    Try

      Dim IPSource As structIP = PaveSource.Tag
      Dim IPDest As structIP = PaveDest.Tag

      ' Si on click et que l'on relache, on pose sur elle même donc erreur
      If IPDest.NIPLNUM = IPSource.NIPLNUM Then Exit Sub

      ' On ne peut pas ajouter une IP multi-jour
      If IPSource.CIPLMULT = "O" Then
        MsgBox(My.Resources.Planification_FrmMainPlanning3S_inerv_multi_jour)
        Exit Sub
      End If

      ' les sites doivent être identiques
      If IPDest.NSITNUM <> IPSource.NSITNUM Then
        MsgBox(My.Resources.Planification_FrmMainPlanning3S_site_dif, vbInformation)
        Exit Sub
      End If

      ' Les code analytique doivent être identique
      If Not CompteOK(IPDest.NIPLNUM, IPSource.NIPLNUM, IPSource.NACTNUM) Then
        MsgBox(My.Resources.Planification_FrmMainPlanning3S_compte_analy_dif, vbInformation)
        Exit Sub
      End If

      ' on fait un contrôle sur les durées des actions
      If IPDest.NIPLDUR + IPSource.NIPLDUR > 10 And IPDest.CIPLMULT = "N" Then
        If MsgBox(My.Resources.Planification_FrmMainPlanning3S_creer_intervention & vbCrLf & My.Resources.Planification_FrmMainPlanning3S_etes_vous_dacc, vbYesNo + vbQuestion + vbDefaultButton2) = MsgBoxResult.No Then
          Exit Sub
        End If
      End If

      ' Vérifications (déplacement d'une IP avec information au client, aide sur intervention, IP Emalec)
      If Not Verifications(IPSource.NIPLNUM, IPSource.DIPLDATJ, IPSource.NSITNUM, iNumClientSOCIETE, IPDest.NPERNUM, IPSource.NACTNUM, IIf(IPSource.DIPLDATJ = IPDest.DIPLDATJ, True, False)) Then
        Exit Sub
      End If

      Dim cmd As SqlCommand

      '' cas de planification d'une nouvelle action
      'If IPSource.TYPEIP = "N" Then
      '	' modification de l'IP (NumIP,  action, TechDest)
      '	cmd = New SqlCommand("api_sp_ModificationIP_Action " + IPDest.NIPLNUM & ", " + IPSource.NACTNUM + ", " + IPDest.NPERNUM, cnx)
      '	AddLogIPL(IPDest.NIPLNUM, "C")
      'Else

      ' modification de l'IP (NumIPpic,  NumIPsource, TechDest)
      cmd = New SqlCommand("api_sp_ModificationIP_IP " & IPSource.NIPLNUM & ", " & IPDest.NIPLNUM & ", " & IPSource.NPERNUM, MozartDatabase.cnxMozart)
      cmd.ExecuteNonQuery()
      AddLogIPL(IPDest.NIPLNUM, "M")

      ' on affiche les info de sortie de stock ou commande fournisseur
      ' uniquement si on change de date
      If IPDest.DIPLDATJ <> IPSource.DIPLDATJ Then
        RechercheInfoCdeFo(IPDest.NIPLNUM)
      End If
      'End If

      ReinitCommandesPanel()

      ' Renitialisation de l'affichage
      DrawPlanning()

    Catch ex As Exception
      MessageBox.Show(ex.Message & vbCrLf & vbCrLf & My.Resources.Global_dans & System.Reflection.MethodBase.GetCurrentMethod.Name)
    End Try

  End Sub

  Public Function CompteOK(ByVal numIpD As Long, ByVal numIPS As Long, ByVal numAct As Long) As Boolean

    Dim rsD As New SqlCommand("select NDINCTE FROM TDIN,TACT WHERE TDIN.NDINNUM=TACT.NDINNUM AND NIPLNUM=" & numIpD, MozartDatabase.cnxMozart)
    ' si l'ip source est en création alors on recherche le compte par le nactnum
    Dim iCompteD As Integer = rsD.ExecuteScalar()

    Dim rsS As SqlCommand
    If numIPS = 0 Then
      rsS = New SqlCommand("select NDINCTE FROM TDIN,TACT WHERE TDIN.NDINNUM=TACT.NDINNUM AND NACTNUM=" & numAct, MozartDatabase.cnxMozart)
    Else
      rsS = New SqlCommand("select NDINCTE FROM TDIN,TACT WHERE TDIN.NDINNUM=TACT.NDINNUM AND NIPLNUM=" & numIPS, MozartDatabase.cnxMozart)
    End If
    Dim iCompteS As Integer = rsS.ExecuteScalar()

    Return iCompteD = iCompteS

  End Function

  Public Sub GridDragDrop(ByVal IPSource As structIP, ByVal row As Integer, ByVal col As Integer)

    Try
      Dim indice As Integer
      Dim DatePla As String
      Dim sSQL As String = ""

      ' Définition du technicien et de l'indice ou l'on pose
      Dim Per As ClsTechnicien = Techs(FirstTech + row \ 6)
      indice = (row Mod 6) + 1

      ' Définition du jour ou on pose
      DatePla = grdvPlanning.Columns(col).Name

      ' Si technicien avec date de sortie du technicien : on ne peut pas poser apres la date de sortie
      If Not TestTechOK(Per.NPERNUM, CDate(DatePla)) Then
        MsgBox(My.Resources.Planification_FrmMainPlanning3S_msg_impo, vbInformation)
        Exit Sub
      End If

      ' Si 1/2 journées interdites des sites
      If Not DemiJournee(IPSource.NSITNUM, indice, DatePla) Then
        'MsgBox("Impossible de planifier ce technicien à cette date (voir demi-journée interdite du site)", vbInformation)
        If MsgBox(My.Resources.Planification_FrmMainPlanning3S_journée_interdite, vbYesNo) = vbNo Then
          Exit Sub
        End If
      End If

      ' Vérifications (déplacement d'une IP avec information au client, aide sur intervention, IP Emalec, action bloque)
      If Not Verifications(IPSource.NIPLNUM, DatePla, IPSource.NSITNUM, iNumClientSOCIETE, Per.NPERNUM, IPSource.NACTNUM, IIf(IPSource.DIPLDATJ = DatePla, True, False)) Then
        Exit Sub
      End If

      ' Affichage des infos site si il y en a
      AfficheInfoSite(IPSource.NSITNUM)

      ' Si le planning a changé
      Dim cmd As New SqlCommand("SELECT COUNT(*) FROM TACT, TIPL WHERE TACT.NIPLNUM = TIPL.NIPLNUM AND TACT.NPERNUM = " & Per.NPERNUM & " AND DIPLDATJ = '" & DatePla & "' AND NIPLIND = " & indice, MozartDatabase.cnxMozart)
      If cmd.ExecuteScalar() > 0 Then
        MsgBox(My.Resources.Planification_FrmMainPlanning3S_planning_changé, vbExclamation)
        DrawPlanning()
        Exit Sub
      End If

      ' Si déplacement du premier jour d'une IP multi-jour 
      If Per.NPERNUM <> IPSource.NPERNUM And IPSource.TYPEIP = "D" And IPSource.CIPLMULT = "O" And IPSource.CIPLDEB = "O" Then
        If MsgBox(My.Resources.Planification_FrmMainPlanning3S_attention_ip & vbCrLf & My.Resources.Planification_FrmMainPlanning3S_ip_deplacé, vbYesNo + vbQuestion + vbDefaultButton2) = MsgBoxResult.Yes Then

          sSQL = String.Format("api_sp_CreationIP {0}, {1}, {2}, {3}, '{4}', {5}, '{6}'",
 IPSource.NIPLNUM, IPSource.NACTNUM, Per.NPERNUM, indice, CDate(DatePla), IPSource.NIPLDUR, "01/01/1900")
          cmd = New SqlCommand(sSQL, MozartDatabase.cnxMozart)
          cmd.ExecuteNonQuery()
          AddLogIPL(IPSource.NIPLNUM, "M")

        End If

        ' Si déplacement d'un jour d'une multi-jour
        ' Si on change de tech pour une multi-jour : création d'une action
      ElseIf Per.NPERNUM <> IPSource.NPERNUM And IPSource.TYPEIP = "D" And IPSource.CIPLMULT = "O" And IPSource.CIPLDEB = "N" Then

        cmd = New SqlCommand("SELECT COUNT(*) FROM TACT WHERE NIPLNUM = " & IPSource.NIPLNUM, MozartDatabase.cnxMozart)
        If cmd.ExecuteScalar() = 1 Then

          sSQL = String.Format("api_sp_DeplacementIP {0}, {1}, {2}, '{3}', '{4}'", IPSource.NIPLNUM, Per.NPERNUM, indice, CDate(DatePla), IPSource.DIPLDATJ)
          cmd = New SqlCommand(sSQL, MozartDatabase.cnxMozart)
          cmd.ExecuteNonQuery()

          AddLogIPL(IPSource.NIPLNUM, "M")
        Else
          MsgBox(My.Resources.Planification_FrmMainPlanning3S_deplacement_obli, vbExclamation)
        End If

      Else

        sSQL = String.Format("api_sp_CreationIP {0}, {1}, {2}, {3}, '{4}', {5}, '{6}'",
         IPSource.NIPLNUM, IPSource.NACTNUM, Per.NPERNUM, indice, CDate(DatePla), IPSource.NIPLDUR, IPSource.DIPLDATJ)
        cmd = New SqlCommand(sSQL, MozartDatabase.cnxMozart)
        cmd.ExecuteNonQuery()

        If IPSource.TYPEIP = "D" Then
          If DatePla <> IPSource.DIPLDATJ Then
            cmd = New SqlCommand("UPDATE TACT set CACTINFOMAG='N', VACTQUIINFO='', VACTINFOQUI='', DACTQUANDINFO = Null where NIPLNUM = " & IPSource.NIPLNUM.ToString(), MozartDatabase.cnxMozart)
            cmd.ExecuteNonQuery()
            AddLogIPL(IPSource.NIPLNUM, "M")
          End If
        Else
          AddLogIPL(IPSource.NIPLNUM, "C")
        End If

      End If

      RechercheInfoCdeFo(IPSource.NIPLNUM)

      ReinitCommandesPanel()

      ' Réinitialisation de l'affichage
      DrawPlanning()

    Catch ex As Exception
      MessageBox.Show(ex.Message & vbCrLf & vbCrLf & My.Resources.Global_dans & System.Reflection.MethodBase.GetCurrentMethod.Name)
    End Try

  End Sub

  Public Sub ReinitCommandesPanel()
    If bDropedPave Then
      If pnlCommandes.Controls.ContainsKey("DropPave") Then pnlCommandes.Controls.RemoveByKey("DropPave")
      pnlCommandes.BackColor = Color.Peru
      bDropedPave = False
      Timer1.Enabled = False
    End If

  End Sub

  Private Sub Timer1_Tick(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Timer1.Tick
    If bDropedPave Then
      If pnlCommandes.BackColor = Color.Peru Or pnlCommandes.BackColor = Color.Yellow Then
        pnlCommandes.BackColor = Color.Red
      Else
        pnlCommandes.BackColor = Color.Yellow
      End If
    End If
  End Sub

  Private Sub btnQuit_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnQuit.Click
    Me.Close()
  End Sub

  Private Sub btnDistance_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnDistance.Click

    Dim CurPerNum As Integer = 0
    Dim CurTech As Integer = FirstTech - 1
    Dim PrecIP As New structIP()
    Dim CurSem As Integer = 0
    Dim bCalculFromHomeTech As Boolean = False
    Dim Tech As ClsTechnicien = Nothing


    For Each Pave As Control In grdvPlanning.Controls
      If TypeOf (Pave) Is Panel AndAlso Not Pave.Tag Is Nothing Then
        Dim IP As New structIP()
        IP = CType(Pave.Tag, structIP)

        If IP.Dist = -1 Then
          bCalculFromHomeTech = False

          ' Si changement de semaine
          If CurSem <> DatePart(DateInterval.WeekOfYear, IP.DIPLDATJ) Then
            CurSem = DatePart(DateInterval.WeekOfYear, IP.DIPLDATJ)
            bCalculFromHomeTech = True
          End If

          ' Si changement de technicien
          If CurPerNum <> IP.NPERNUM Then
            If CurTech > 0 And Not Tech Is Nothing Then Tech.bCalculDist = True
            CurPerNum = IP.NPERNUM
            CurTech += 1
            Tech = Techs(CurTech)
            bCalculFromHomeTech = True
          End If

          ' Selon le mode de calcul (Home -> 1er site ou SitePrec -> site)
          If bCalculFromHomeTech Then
            IP.Dist = CalculDistance(Techs(CurTech), IP)
          Else
            IP.Dist = CalculDistance(PrecIP, IP)
          End If

          If Tech.bCalculDist = False Then
            Select Case DateDiff(DateInterval.WeekOfYear, DebutSemaine, IP.DIPLDATJ)
              Case 0
                Tech.NKM_SEM1 += IP.Dist
              Case 1
                Tech.NKM_SEM2 += IP.Dist
              Case 2
                Tech.NKM_SEM3 += IP.Dist
            End Select
          End If

        Else
          IP.Dist = -1
        End If

        PrecIP = IP
        Pave.Tag = IP
        Pave.Refresh()
      End If
    Next
    pnlTechs.Refresh()
  End Sub

  Function CalculDistance(ByVal IP1 As structIP, ByVal IP2 As structIP) As Integer
    Return Math.Sqrt(((IP1.SITLAT - IP2.SITLAT) ^ 2) + ((IP1.SITLON - IP2.SITLON) ^ 2)) * 110
  End Function

  Function CalculDistance(ByVal Per As ClsTechnicien, ByVal IP As structIP) As Integer
    Return Math.Sqrt(((Per.LAT - IP.SITLAT) ^ 2) + ((Per.LON - IP.SITLON) ^ 2)) * 110
  End Function

  Private Sub btnCompetences_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnCompetences.Click

    bAffichageCompetences = Not bAffichageCompetences

    'Dim CurPerNum As Integer = 0
    'Dim CurTech As Integer = FirstTech - 1
    'Dim tabComp() As String

    For Each Pave As Control In grdvPlanning.Controls
      If TypeOf (Pave) Is Panel Then
        If Not Pave.Tag Is Nothing Then
          '			Dim IP As New structIP()
          '			IP = CType(Pave.Tag, structIP)

          '			If IP.bContratOK = -1 Then

          '				If CurPerNum <> IP.NPERNUM Then
          '					CurPerNum = IP.NPERNUM
          '					CurTech += 1
          '				End If

          '				IP.bContratOK = 0

          '				' Si Hors contrat ou Formation -> OK
          '				If IP.bCOMPETENT = "48" Or IP.bCOMPETENT = "64" Then
          '					IP.bContratOK = 1
          '				Else
          '					tabComp = Techs(CurTech).TCOMPETENCES.split(",")
          '					For Each c As String In tabComp
          '						If c = IP.bCOMPETENT Then
          '							IP.bContratOK = 1
          '							Exit For
          '						End If
          '					Next
          '				End If
          '			Else
          '				IP.bContratOK = -1
          '			End If

          '			Pave.Tag = IP
          Pave.Refresh()
        End If
      End If

    Next
  End Sub

  Private Sub btnCarte_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnCarte.Click

    'Dim pt(200) As PointF
    'Dim i As Integer = 0


    'For Each Pave As Control In grdvPlanning.Controls
    '	If TypeOf (Pave) Is Panel Then
    '		If Not Pave.Tag Is Nothing Then
    '			Dim IP As New structIP()
    '			IP = CType(Pave.Tag, structIP)
    '			pt(i) = New PointF(IP.SITLAT, IP.SITLON)
    '			i += 1
    '		End If
    '	End If

    'Next

    'ReDim Preserve pt(i - 1)
    FrmCarte.Infos = ""
    FrmCarte.ShowDialog()

  End Sub

  Private Sub bCarte_click(ByVal sender As System.Object, ByVal e As System.EventArgs)
    If sender.tag Is Nothing Then Exit Sub
    'FrmCarte.Infos = sender.tag
    'FrmCarte.ShowDialog()

    Dim sDebutSemForCarte As String = ""

    Select Case sender.Text.ToString
      Case "S1"
        sDebutSemForCarte = DebutSemaine
      Case "S2"
        sDebutSemForCarte = DebutSemaine.AddDays(7)
      Case "S3"
        sDebutSemForCarte = DebutSemaine.AddDays(14)
    End Select

    If sDebutSemForCarte <> "" Then
      ' TB SAMSIC CITY SPEC
      If MozartParams.NomGroupe = "EMALEC" Then
        Dim oTrajetTechs As New frmVisuDoc("https://maps.emalec.com/TrajetTechnicienSemaineSelected.asp?BASE=MULTI&APP=" & MozartParams.NomSociete & "&NumTech=" & sender.tag.ToString.Split("|")(0) & "&Semaine=" & sDebutSemForCarte)
        oTrajetTechs.ShowDialog()
      End If ' TODO_TB SAMSIC CITY -> else pour samsic
    End If

  End Sub

  Private Sub Button1_Click(ByVal sender As System.Object, ByVal e As System.EventArgs)
    FrmCarte.Infos = sender.text
    FrmCarte.ShowDialog()
  End Sub

  'Private Sub BtnVisuOT_Click(ByVal sender As System.Object, ByVal e As System.EventArgs)

  '  Dim oStructTag As structIP = CType(sender.Tag, structIP)

  '  Dim ListDocOT As New Collection()
  '  Dim ODocOT As New CGenDocMOZART()
  '  Dim sFileOT As String

  '  Dim sPathDirectoryOut As String = MozartParams.CheminUtilisateurMozart & oStructTag.NIPLNUM.ToString & "\"

  '  Me.Cursor = Cursors.WaitCursor

  '  If Directory.Exists(sPathDirectoryOut) = True Then Directory.Delete(sPathDirectoryOut, True)
  '  Directory.CreateDirectory(sPathDirectoryOut)

  '  'OT
  '  sFileOT = ODocOT.ImpressionOT_Tech("exec api_sp_OrdreDeTravail " & oStructTag.NIPLNUM.ToString, oStructTag.NIPLNUM, oStructTag.NPERNUM, ListDocOT.Count, sPathDirectoryOut)
  '  If ODocOT.p_ERROR = "" And sFileOT <> "" Then ListDocOT.Add(sFileOT, "OT")
  '  'GAMMES ET STOCK CLI/SIT
  '  ODocOT.ImpressionComplementsOT(oStructTag, ListDocOT, sPathDirectoryOut)
  '  'GIDT
  '  sFileOT = ODocOT.ImpressionEquiptSite(oStructTag.NIPLNUM, oStructTag.NPERNUM, sPathDirectoryOut, ListDocOT.Count)
  '  If ODocOT.p_ERROR = "" And sFileOT <> "" Then ListDocOT.Add(sFileOT, "GIDT")
  '  'DECTECTION INCENDIE
  '  ODocOT.ImpressionDetectionIncendie(oStructTag.NIPLNUM, oStructTag.NPERNUM, ListDocOT, sPathDirectoryOut)
  '  'FLUIDE FRIGO
  '  ODocOT.ImpressionAttestationClim(oStructTag.NIPLNUM, oStructTag.NPERNUM, ListDocOT, sPathDirectoryOut)
  '  'DOC Techs
  '  ODocOT.ImpressionDocTech(oStructTag.NIPLNUM, ListDocOT, sPathDirectoryOut)

  '  Dim PDF As New CGenPDF

  '  For Each oDoc In ListDocOT

  '    'transformation en pdf
  '    PDF.ImpressionEnPDF(sPathDirectoryOut & Path.GetFileNameWithoutExtension(oDoc.ToString()))
  '    System.Threading.Thread.Sleep(300)

  '  Next

  '  'concatenation en pdf
  '  Dim sFilePDFOut As String = PDF.ConcatPDF(String.Format("{0}_{1}_", MozartParams.UID, oStructTag.NIPLNUM), String.Format("{0}_{1}_FINAL", MozartParams.UID, oStructTag.NIPLNUM))

  '  'mouse normal
  '  Me.Cursor = Cursors.Default

  '  If sFilePDFOut <> "" Then

  '    Dim oVisuOTPDF As New frmVisuDoc(sFilePDFOut)
  '    oVisuOTPDF.ShowDialog()
  '    oVisuOTPDF.Dispose()

  '  End If

  '  'nettoyage
  '  Try

  '    If Directory.Exists(sPathDirectoryOut) = True Then Directory.Delete(sPathDirectoryOut, True)

  '    For Each oFileFind As String In Directory.GetFiles(MozartParams.CheminUtilisateurMozart & "PDF\", String.Format("{0}_{1}_*", MozartParams.UID, oStructTag.NIPLNUM), SearchOption.TopDirectoryOnly)

  '      File.Delete(oFileFind)

  '    Next

  '  Catch ex As Exception

  '    MessageBox.Show(My.Resources.Planification_FrmMainPlanning3S_erreur & ex.Message, My.Resources.Global_Erreur, MessageBoxButtons.OK, MessageBoxIcon.Error)

  '  End Try

  'End Sub

  'Function Ecrire_LOG(ByVal type As String, ByVal texte As String)
  ' type peut prendre, par exemple, la valeur "ERREUR", "EXCEPTION" ou "INFORMATION"
  ' texte contient le message à stocker dans le LOG

  'Dim FileName As String = Environment.GetFolderPath(Environment.SpecialFolder.UserProfile) & "\LogPlanning3S.txt"

  ' Vérif taille du fichier LOG, pour archivage (en octets)
  'Dim mon_fichier As New FileInfo(FileName)
  'Dim taille As Long = 0
  '  Try
  '    taille = mon_fichier.Length
  '  Catch ex As Exception
  ' Fichier n'existe pas
  '  End Try

  '  If taille > 400000 Then
  ' Archivage
  'Dim chaine As String = Date.Today.Year.ToString + "_" + Date.Today.Month.ToString + "_" + Date.Today.Day.ToString + "_" + TimeOfDay.Hour.ToString + "_" + TimeOfDay.Minute.ToString
  '    My.Computer.FileSystem.RenameFile(FileName, "LogPlanning3S" + chaine + ".txt")
  '  End If

  ' Ecriture dans le LOG
  'Dim objWriter As New System.IO.StreamWriter(FileName, True)
  '  If (type = "" And texte = "") Then
  '    objWriter.WriteLine("")
  '  Else
  '    objWriter.WriteLine(Date.Today.ToShortDateString() + " " + TimeOfDay.ToLongTimeString() + " - " + type + " - " + texte)
  '  End If

  '  objWriter.Close()

  '  Return 0

  'End Function

End Class
