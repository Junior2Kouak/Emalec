Imports System.Data.SqlClient
Imports System.Globalization
Imports DevExpress.Utils
Imports DevExpress.Utils.Drawing
Imports DevExpress.XtraGrid
Imports DevExpress.XtraGrid.Views.BandedGrid
Imports DevExpress.XtraGrid.Views.Base
Imports DevExpress.XtraGrid.Views.Grid
Imports DevExpress.XtraGrid.Views.Grid.ViewInfo
Imports MozartLib

Public Class frmPlanningProjet

  Private Const SEPARATOR As String = "¤¤¤"
  Private Const FIELDNAME_INTER As String = "INTER"
  Private Const CAPTION_INTER As String = "Intervenant"

  ReadOnly ColorRed As Color = Color.Red
  ReadOnly ColorSilver As Color = Color.Silver
  ReadOnly ColorGreen As Color = Color.FromArgb(130, 180, 60)
  ReadOnly ColorBlue As Color = Color.FromArgb(60, 110, 170)

  ReadOnly myFont = New Font("Consolas", 9.0F, FontStyle.Bold)

  Dim TabColorCompte As New List(Of CColor_By_Compte)

  Dim lstJoursFeries As List(Of Date)
  Dim lstSalaries As Hashtable
  Dim lCurrentRow As Integer

  Dim DebutPeriode As DateTime = New DateTime(DateTime.Now.Year, DateTime.Now.Month, 1)
  Dim FinPeriode As DateTime = DebutPeriode.AddMonths(3)

  Public Sub New()
    InitializeComponent()   ' Cet appel est requis par le concepteur.

    ' Ajoutez une initialisation quelconque après l'appel InitializeComponent().
  End Sub

  Private Sub fillJoursFeries()
    Dim sql As String

    lstJoursFeries = New List(Of Date)

    sql = "Select DFERDAT from TFERIE Where VSOCIETE = '" & MozartParams.NomSociete & "' and DFERDAT between DATEADD(d, -200, getdate()) and DATEADD(d, +200, GetDate())"

    Using dr As SqlDataReader = MozartDatabase.ExecuteReader(sql)
      While dr.Read
        lstJoursFeries.Add(dr("DFERDAT"))
      End While
    End Using
  End Sub

  Private Sub drawGridHeader()
    Dim lDate As DateTime
    Dim lBand As GridBand
    Dim lBandedGridColumn As BandedGridColumn
    Dim lWeekNo As Integer
    Dim lNbCol As Integer
    Dim i As Integer
    Dim sql As String
    Dim lCurrentRow As Integer
    Dim lTmpDate As DateTime
    Dim lStrCPerType As String

    bandedGridView.Bands.Clear()
    bandedGridView.Columns.Clear()
    bandedGridView.ColumnPanelRowHeight = 100

    Dim lGridBandFirstCol As New GridBand With {
      .Caption = CAPTION_INTER
    }
    bandedGridView.Bands.Add(lGridBandFirstCol)

    lBandedGridColumn = bandedGridView.Columns.AddField("NPERNUM")
    lBandedGridColumn.Visible = False
    lBandedGridColumn.OptionsColumn.ReadOnly = True
    lBandedGridColumn.OptionsColumn.AllowEdit = False
    lGridBandFirstCol.Columns.Add(lBandedGridColumn)

    lBandedGridColumn = bandedGridView.Columns.AddVisible("VTYPE", "Type")
    lBandedGridColumn.Width = 80
    lBandedGridColumn.OptionsColumn.ReadOnly = True
    lBandedGridColumn.OptionsColumn.AllowEdit = False
    lBandedGridColumn.GroupIndex = 0
    lGridBandFirstCol.Columns.Add(lBandedGridColumn)

    lBandedGridColumn = bandedGridView.Columns.AddVisible(FIELDNAME_INTER, CAPTION_INTER)
    lBandedGridColumn.Width = 200
    lBandedGridColumn.OptionsColumn.ReadOnly = True
    lBandedGridColumn.OptionsColumn.AllowEdit = False
    lGridBandFirstCol.Columns.Add(lBandedGridColumn)

    lBandedGridColumn = bandedGridView.Columns.AddVisible("VNOM_TEAM", "Equipe")
    lBandedGridColumn.Width = 50
    lBandedGridColumn.OptionsColumn.ReadOnly = False
    lBandedGridColumn.ColumnEdit = RepCboTeam
    lGridBandFirstCol.Columns.Add(lBandedGridColumn)


    lNbCol = 0
    lDate = DebutPeriode
    lWeekNo = DateTimeFormatInfo.CurrentInfo.Calendar.GetWeekOfYear(lDate, CalendarWeekRule.FirstFourDayWeek, DayOfWeek.Monday)
    lBand = bandedGridView.Bands.AddBand("S " + lWeekNo.ToString())

    Dim dtCol As DataTable = New DataTable()
    dtCol.Columns.Add("NPERNUM", GetType(Int32))
    dtCol.Columns.Add("VTYPE", GetType(String))
    dtCol.Columns.Add(FIELDNAME_INTER, GetType(String))
    dtCol.Columns.Add("VNOM_TEAM", GetType(String))
    dtCol.Columns("VNOM_TEAM").ReadOnly = False
    lTmpDate = DebutPeriode
    While lTmpDate <= FinPeriode
      dtCol.Columns.Add(lTmpDate.ToString("dd/MM/yy"), GetType(String))

      lTmpDate = lTmpDate.AddDays(1)
    End While
    gridPlanning.DataSource = dtCol

    While lDate <= FinPeriode
      lNbCol += 1

      If lWeekNo <> DateTimeFormatInfo.CurrentInfo.Calendar.GetWeekOfYear(lDate, CalendarWeekRule.FirstFourDayWeek, DayOfWeek.Monday) Then
        With lBand
          .Caption = "S " + lWeekNo.ToString()
          .Visible = True
        End With

        lNbCol = 0
        lWeekNo = DateTimeFormatInfo.CurrentInfo.Calendar.GetWeekOfYear(lDate, CalendarWeekRule.FirstFourDayWeek, DayOfWeek.Monday)
        lBand = bandedGridView.Bands.AddBand("S " + lWeekNo.ToString())
      End If

      lBandedGridColumn = bandedGridView.Columns.AddVisible(lDate.ToString("dd/MM/yy"), lDate.ToString("dd/MM/yy"))
      lBandedGridColumn.Width = 40
      lBandedGridColumn.OptionsColumn.ReadOnly = True
      lBandedGridColumn.OptionsColumn.AllowEdit = False
      lBand.Columns.Add(lBandedGridColumn)

      lDate = lDate.AddDays(1)
    End While

    If (Not chkPersBureau.Checked) And (Not chkPersTerrain.Checked) Then
      Exit Sub
    End If

    ' Type des personnes à récupérer
    lStrCPerType = ""
    If chkPersBureau.Checked Then
      lStrCPerType = "'AS', 'BE', 'CA', 'CO', 'GE', 'FA', 'AA'"
    End If

    ' Si personnel de terrain non checké, on filtre sur CPERTYP
    If chkPersTerrain.Checked Then
      If chkPersBureau.Checked Then
        lStrCPerType += ", "
      End If
      lStrCPerType += "'CT', 'TE'"
    End If

    ' Récupération de la liste des salariés actifs
    lstSalaries = New Hashtable()
    sql = "SELECT CASE WHEN TPER.CPERTYP = 'TE' THEN 'Terrain' ELSE 'Bureau' END AS VTYPE, TPER.VPERNOM + ' ' + TPER.VPERPRE 'NOMCOMPLET', TPER.NPERNUM, ISNULL(TPLAN_TEAM.VNOM_TEAM, '') AS VNOM_TEAM"
    sql += " FROM TPER LEFT OUTER JOIN TPLAN_TEAM ON TPLAN_TEAM.NPERNUM = TPER.NPERNUM"
    sql += " WHERE CPERACTIF='O'"
    sql += " AND CPERTYP IN (" + lStrCPerType + ")"
    sql += "  AND TPER.BUTILISATEUR = 0"
    sql += " AND VSOCIETE = APP_NAME()"
    sql += " ORDER BY VTYPE, VNOM_TEAM, NOMCOMPLET"

    Using dr As SqlDataReader = MozartDatabase.ExecuteReader(sql)
      While dr.Read
        bandedGridView.AddNewRow()
        lCurrentRow = GridControl.NewItemRowHandle

        bandedGridView.SetRowCellValue(lCurrentRow, bandedGridView.Columns("NPERNUM"), dr("NPERNUM"))
        bandedGridView.SetRowCellValue(lCurrentRow, bandedGridView.Columns(FIELDNAME_INTER), dr("NOMCOMPLET"))
        bandedGridView.SetRowCellValue(lCurrentRow, bandedGridView.Columns("VTYPE"), dr("VTYPE"))
        bandedGridView.SetRowCellValue(lCurrentRow, bandedGridView.Columns("VNOM_TEAM"), dr("VNOM_TEAM"))

        'Couleur grise pour les jours fériés
        For i = 0 To bandedGridView.Columns.Count - 1
          If IsDate(bandedGridView.Columns.Item(i).Caption) Then
            lTmpDate = CType(bandedGridView.Columns.Item(i).Caption, Date)

            If lTmpDate.DayOfWeek = DayOfWeek.Saturday Or lTmpDate.DayOfWeek = DayOfWeek.Sunday Or lstJoursFeries.Where(Function(d) d = lTmpDate).Count() > 0 Then
              bandedGridView.SetRowCellValue(lCurrentRow, bandedGridView.Columns.Item(i), "S" + SEPARATOR)
            End If
          End If
        Next

        bandedGridView.UpdateCurrentRow()

        lstSalaries.Add(dr("NPERNUM"), bandedGridView.LocateByValue("NPERNUM", dr("NPERNUM")))

      End While
    End Using

    bandedGridView.OptionsCustomization.AllowChangeColumnParent = False
  End Sub

  Private Sub drawGridContent()
    Dim sql As String
    Dim dt As DataTable
    Dim precInt As String = ""
    Dim lTmpDate As DateTime
    Dim lTxtCell As String
    Dim lCurrentRow As Integer

    lblTitre.Text = Me.Text

    sql = "Exec api_sp_GetPlanningMPM '" & DebutPeriode & "', '" & FinPeriode & "'"
    dt = MozartDatabase.GetDataTable(sql)

    'on charge le nombre de compte différents
    Dim req = From Cpt In dt
              Group Cpt By NCANNUM = Cpt.Field(Of Int32)("NDINCTE") Into NDINCTEGroup = Group Order By NCANNUM Descending
              Select New With {Key NCANNUM}

    For Each oCpt In req
      TabColorCompte.Add(New CColor_By_Compte(oCpt.NCANNUM, GetColor(oCpt.NCANNUM), If(GetColor(oCpt.NCANNUM) = Color.Black, Color.White, Color.Black)))
    Next

    GCLegende.DataSource = TabColorCompte

    Dim rows As DataRow() = dt.Select("DIPLDATJ Is Not Null", "DIPLDATJ DESC")

    For Each row As DataRow In dt.Rows
      ' Si personnel de bureau non checké, on filtre sur CPERTYP
      If Not chkPersBureau.Checked Then
        Select Case row("CPERTYP")
          Case "AS", "BE", "CA", "CO", "GE", "FA", "AA"
            Continue For
          Case Else
        End Select
      End If

      ' Si personnel de terrain non checké, on filtre sur CPERTYP
      If Not chkPersTerrain.Checked Then
        Select Case row("CPERTYP")
          Case "CT", "TE"
            Continue For
          Case Else
        End Select
      End If

      lTxtCell = ""

      If row("DIPLDATJ").ToString() <> "" Then
        lTmpDate = row("DIPLDATJ")

        'en fonction du CETACOD mettre en vert (exécuté), rouge (retard) ou bleu (à venir)
        lTxtCell = row("NDINCTE") & vbCrLf & "||" & IIf(row("CETACOD") <> "E", "R", "G")

        lTxtCell += SEPARATOR + "-- DI " & row("NDINNUM") & vbCrLf & row("VACTDES").ToString()
      End If

      lCurrentRow = lstSalaries.Item(row("NPERNUM"))
      bandedGridView.SetRowCellValue(lCurrentRow, bandedGridView.Columns(lTmpDate.ToString("dd/MM/yy")), lTxtCell)
    Next

    bandedGridView.MoveFirst()
  End Sub

  Private Function GetColor(ByVal NCANNUM As Int32) As Color

    Dim lColor As Color

    If NCANNUM > 900 Then

      lColor = Color.Black

    Else


      Dim cent As Int16 = NCANNUM / 100
      Dim diz As Int16 = Math.Floor((NCANNUM Mod 100) / 10)
      Dim unit As Int16 = NCANNUM Mod 10

      NCANNUM = cent + diz + unit

      While NCANNUM > 10

        cent = NCANNUM / 100
        diz = Math.Floor((NCANNUM Mod 100) / 10)
        unit = NCANNUM Mod 10

        NCANNUM = cent + diz + unit

      End While

      Select Case NCANNUM
        Case 1
          lColor = Color.Yellow
        Case 2
          lColor = Color.GreenYellow
        Case 3
          lColor = Color.LimeGreen
        Case 4
          lColor = Color.PaleTurquoise
        Case 5
          lColor = Color.DodgerBlue
        Case 6
          lColor = Color.Violet
        Case 7
          lColor = Color.Thistle
        Case 8
          lColor = Color.Orange
        Case 9
          lColor = Color.Red
        Case 0
          lColor = Color.Gray
        Case Else
          lColor = Nothing 'bNoCustom = True
      End Select

    End If

    Return lColor

  End Function

  Private Sub draw3DBorder(pCache As GraphicsCache, pRect As Rectangle)
    Dim lPainter As BorderPainter = BorderHelper.GetPainter(DevExpress.XtraEditors.Controls.BorderStyles.Style3D)
    Dim lBorderAppearance As AppearanceObject = New AppearanceObject() With {
      .BorderColor = Color.DarkGray
    }

    lPainter.DrawObject(New BorderObjectInfoArgs(pCache, lBorderAppearance, pRect))
  End Sub

  Private Sub frmPlanningProjet_Load(sender As Object, e As EventArgs) Handles MyBase.Load
    Cursor.Current = Cursors.WaitCursor

    Me.Text = "Planning équipe"

    Initboutons(Me)

    fillJoursFeries()
    drawPlanning()

    ' Couleurs pour la légende
    'lblBlue.BackColor = ColorBlue
    'lblGreen.BackColor = ColorGreen
    'lblRed.BackColor = ColorRed
    'lblSilver.BackColor = ColorSilver

    AddHandler chkPersBureau.CheckedChanged, AddressOf chk_Changed
    AddHandler chkPersTerrain.CheckedChanged, AddressOf chk_Changed

    Cursor.Current = Cursors.Default
  End Sub

  Private Sub drawPlanning()
    drawGridHeader()
    drawGridContent()
  End Sub

  Private Sub cmdPrev_Click(sender As Object, e As EventArgs) Handles cmdPrev.Click
    Cursor.Current = Cursors.WaitCursor

    DebutPeriode = DebutPeriode.AddMonths(-1)
    FinPeriode = FinPeriode.AddMonths(-1)
    drawPlanning()

    Cursor.Current = Cursors.Default
  End Sub

  Private Sub cmdSuiv_Click(sender As Object, e As EventArgs) Handles cmdSuiv.Click
    Cursor.Current = Cursors.WaitCursor

    DebutPeriode = DebutPeriode.AddMonths(+1)
    FinPeriode = FinPeriode.AddMonths(+1)
    drawPlanning()

    Cursor.Current = Cursors.Default
  End Sub

  Private Sub btnLegende_Click(sender As Object, e As EventArgs) Handles btnLegendeFermer.Click, btnLegende.Click
    frame1.Visible = Not frame1.Visible
  End Sub

  Private Sub chk_Changed(sender As Object, e As EventArgs)
    Cursor.Current = Cursors.WaitCursor

    drawPlanning()

    Cursor.Current = Cursors.Default
  End Sub

  Private Sub bandedGridView_CustomDrawBandHeader(sender As Object, e As BandHeaderCustomDrawEventArgs) Handles bandedGridView.CustomDrawBandHeader
    If e.Band Is Nothing Then Exit Sub

    e.Handled = True

    Dim lR As Rectangle = e.Bounds
    draw3DBorder(e.Cache, lR)
    lR.Inflate(-1, -1)

    e.Cache.FillRectangle(Brushes.Yellow, lR)

    If e.Info.Caption = CAPTION_INTER Or e.Info.Caption = "Type" Then Exit Sub

    Dim lSf As New StringFormat With {
        .LineAlignment = StringAlignment.Center,
        .Alignment = StringAlignment.Center
      }
    e.Graphics.DrawString(e.Info.Caption, e.Appearance.Font, e.Appearance.GetForeBrush(e.Cache), lR, lSf)
  End Sub

  Private Sub bandedGridView_CustomDrawColumnHeader(sender As Object, e As ColumnHeaderCustomDrawEventArgs) Handles bandedGridView.CustomDrawColumnHeader
    If e.Column Is Nothing Then Exit Sub

    e.Handled = True

    Dim lR As Rectangle = e.Bounds
    draw3DBorder(e.Cache, lR)
    lR.Inflate(-1, -1)

    If e.Info.Caption = DateTime.Now.ToString("dd/MM/yy") Then
      e.Cache.FillRectangle(Brushes.Lime, lR)
    Else
      If e.Info.Caption = "VNOM_TEAM" Then
        e.Cache.FillRectangle(Brushes.DodgerBlue, lR)
      Else
        e.Cache.FillRectangle(Brushes.Yellow, lR)
      End If
    End If

    Dim lSf As New StringFormat With {
    .LineAlignment = StringAlignment.Center,
    .Alignment = StringAlignment.Center
  }

    If e.Info.Caption <> CAPTION_INTER And e.Info.Caption <> "Type" Then
      lSf.FormatFlags = StringFormatFlags.DirectionVertical Or StringFormatFlags.DirectionRightToLeft
    End If

    e.Graphics.DrawString(e.Info.Caption, e.Appearance.Font, e.Appearance.GetForeBrush(e.Cache), lR, lSf)
  End Sub

  Private Sub bandedGridView_RowCellStyle(sender As Object, e As RowCellStyleEventArgs) Handles bandedGridView.RowCellStyle
    If e.Column Is Nothing Then Exit Sub

    If e.Column.FieldName = FIELDNAME_INTER Or e.Column.FieldName = "VTYPE" Then
      e.Appearance.BackColor = Color.Yellow
    ElseIf e.Column.FieldName = "VNOM_TEAM" Then
      e.Appearance.BackColor = Color.DodgerBlue
    Else
      Dim lTxtColor As String
      Dim lColor As Color
      Dim bNoCustom As Boolean
      Dim NCANNUM As Int32

      If (e.CellValue IsNot Nothing) And (e.CellValue IsNot DBNull.Value) Then

        If e.CellValue.ToString().Contains("||") Then

          NCANNUM = Convert.ToInt32(e.CellValue.ToString().Substring(0, e.CellValue.ToString().IndexOf("||") - 2))

          lColor = GetColor(NCANNUM)
          If lColor = Nothing Then bNoCustom = True

        Else
          lTxtColor = e.CellValue.ToString().Substring(0, 1)
          bNoCustom = False
        End If

        If bNoCustom Then Exit Sub

        e.Appearance.BackColor = lColor
        e.Appearance.ForeColor = If(lColor = Color.Black, Color.White, Color.Black)

      End If
    End If
  End Sub

  Private Sub toolTipCtrl_GetActiveObjectInfo(sender As Object, e As ToolTipControllerGetActiveObjectInfoEventArgs) Handles toolTipCtrl.GetActiveObjectInfo
    If e.SelectedControl IsNot gridPlanning Then Exit Sub

    Dim view As GridView = TryCast(gridPlanning.FocusedView, GridView)
    Dim info As GridHitInfo = view.CalcHitInfo(e.ControlMousePosition)

    If Not info.InRowCell Then Exit Sub

    Dim text_Renamed As String = view.GetRowCellDisplayText(info.RowHandle, info.Column)

    If text_Renamed Is Nothing Then Exit Sub
    If text_Renamed = "" Then Exit Sub

    If Not text_Renamed.Substring(1).StartsWith(SEPARATOR) Then Exit Sub

    text_Renamed = text_Renamed.Substring(SEPARATOR.Length + 1)
    Dim cellKey As String = info.RowHandle.ToString() & " - " & info.Column.ToString()
    e.Info = New ToolTipControlInfo(cellKey, text_Renamed)
  End Sub

  Private Sub bandedGridView_CustomDrawCell(sender As Object, e As DevExpress.XtraGrid.Views.Base.RowCellCustomDrawEventArgs) Handles bandedGridView.CustomDrawCell
    If e.DisplayText Is Nothing Then Exit Sub
    If e.DisplayText = "" Then Exit Sub

    If e.DisplayText.Substring(1).StartsWith(SEPARATOR) Then
      e.DisplayText = ""
    End If
  End Sub

  Private Sub bandedGridView_CellValueChanged(sender As Object, e As CellValueChangedEventArgs) Handles bandedGridView.CellValueChanged
    If (e.Column.FieldName = "VNOM_TEAM") Then
      'e.RepositoryItem = RepCboTeam
      Dim drGet As DataRow = bandedGridView.GetDataRow(e.RowHandle)
      If drGet Is Nothing Then Return
      MozartDatabase.ExecuteNonQuery("EXEC [api_sp_PlanTeam_Save] " & drGet.Item("NPERNUM") & ", '" & e.Value.ToString & "'")
    End If
  End Sub

  Private Sub RepositoryItemColorEdit1_CustomDisplayText(sender As Object, e As DevExpress.XtraEditors.Controls.CustomDisplayTextEventArgs) Handles RepositoryItemColorEdit1.CustomDisplayText

    e.DisplayText = ""

  End Sub

  Private Sub BtnRefresh_Click(sender As Object, e As EventArgs) Handles BtnRefresh.Click
    bandedGridView.BeginDataUpdate()
    Try
      bandedGridView.ClearSorting()
      bandedGridView.Columns("VTYPE").SortOrder = DevExpress.Data.ColumnSortOrder.Ascending
      bandedGridView.Columns("VNOM_TEAM").SortOrder = DevExpress.Data.ColumnSortOrder.Ascending
      bandedGridView.Columns("INTER").SortOrder = DevExpress.Data.ColumnSortOrder.Ascending
    Finally
      bandedGridView.EndDataUpdate()
    End Try
  End Sub

End Class

Public Class CColor_By_Compte

  Dim _NCANNUM As Int32
  Dim _BackColor As Color
  Dim _ForeColor As Color

  Public Property NCANNUM As Int32
    Get
      NCANNUM = _NCANNUM
    End Get
    Set(value As Int32)
      _NCANNUM = value
    End Set
  End Property
  Public Property BackColor As Color
    Get
      BackColor = _BackColor
    End Get
    Set(value As Color)
      _BackColor = value
    End Set
  End Property

  Public Property ForeColor As Color
    Get
      ForeColor = _ForeColor
    End Get
    Set(value As Color)
      _ForeColor = value
    End Set
  End Property

  Public Sub New(ByVal C_NCANNUM As Int32, ByVal C_BackColor As Color, ByVal C_ForeColor As Color)
    _NCANNUM = C_NCANNUM
    _BackColor = C_BackColor
    _ForeColor = C_ForeColor
  End Sub

End Class
