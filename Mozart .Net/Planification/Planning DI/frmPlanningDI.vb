Imports System.Data.SqlClient
Imports System.Globalization
Imports DevExpress.Utils
Imports DevExpress.Utils.Drawing
Imports DevExpress.XtraGrid
Imports DevExpress.XtraGrid.Views.BandedGrid
Imports DevExpress.XtraGrid.Views.Grid
Imports DevExpress.XtraGrid.Views.Grid.ViewInfo
Imports MozartLib

Public Class frmPlanningDI

  Private Const SEPARATOR As String = "¤¤¤"
  Private Const FIELDNAME_INTER As String = "INTER"
  Private Const CAPTION_INTER As String = "Intervenant"

  ReadOnly ColorRed As Color = Color.Red
  ReadOnly ColorSilver As Color = Color.Silver
  ReadOnly ColorGreen As Color = Color.FromArgb(130, 180, 60)
  ReadOnly ColorBlue As Color = Color.FromArgb(60, 110, 170)

  ReadOnly myFont = New Font("Consolas", 9.0F, FontStyle.Bold)

  Dim _ndinnum As Integer = 0

  Dim lstJoursFeries As List(Of Date)

  Dim DebutPeriode As DateTime = New DateTime(DateTime.Now.Year, DateTime.Now.Month, 1)
  Dim FinPeriode As DateTime = DebutPeriode.AddMonths(3)

  Public Sub New(ByVal param As Object)
    InitializeComponent()   ' Cet appel est requis par le concepteur.

    ' Ajoutez une initialisation quelconque après l'appel InitializeComponent().
    Integer.TryParse(param, _ndinnum)
  End Sub

  Private Sub fillJoursFeries()
    Dim sql As String

    lstJoursFeries = New List(Of Date)

    sql = "Select DFERDAT from TFERIE Where VSOCIETE = '" & MozartParams.NomSociete & "' and DFERDAT between DATEADD(d, -200, getdate()) and DATEADD(d, +200, GetDate())"

    Using cmd As New SqlCommand(sql, MozartDatabase.cnxMozart)
      Using dr As SqlDataReader = cmd.ExecuteReader()
        While dr.Read
          lstJoursFeries.Add(dr("DFERDAT"))
        End While
      End Using
    End Using
  End Sub

  Private Sub drawGridHeader()
    Dim lDate As DateTime
    Dim lBand As GridBand
    Dim lBandedGridColumn As BandedGridColumn
    Dim lWeekNo As Integer
    Dim lNbCol As Integer
    Dim i As Integer

    bandedGridView.Bands.Clear()
    bandedGridView.Columns.Clear()
    bandedGridView.ColumnPanelRowHeight = 100

    Dim lGridBandFirstCol As New GridBand With {
      .Caption = CAPTION_INTER
    }
    bandedGridView.Bands.Add(lGridBandFirstCol)

    lBandedGridColumn = bandedGridView.Columns.AddVisible(FIELDNAME_INTER, CAPTION_INTER)
    lBandedGridColumn.Width = 200
    lGridBandFirstCol.Columns.Add(lBandedGridColumn)

    lNbCol = 0
    lDate = DebutPeriode
    lWeekNo = DateTimeFormatInfo.CurrentInfo.Calendar.GetWeekOfYear(lDate, CalendarWeekRule.FirstFourDayWeek, DayOfWeek.Monday)
    lBand = bandedGridView.Bands.AddBand("S " + lWeekNo.ToString())

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
      lBand.Columns.Add(lBandedGridColumn)

      lDate = lDate.AddDays(1)
    End While

    ' Resize des colonnes : Sauf les noms
    For i = 1 To bandedGridView.Bands.Count - 1
      bandedGridView.Bands.Item(i).Width = bandedGridView.Bands.Item(i).Columns.Count * 25
    Next

    bandedGridView.OptionsCustomization.AllowChangeColumnParent = False
  End Sub

  Private Sub drawGridContent()
    Dim sql As String
    Dim dt As DataTable = New DataTable()
    Dim precInt As String = ""
    Dim lTmpDate As DateTime
    Dim lTxtCell As String
    Dim i As Integer

    sql = "Exec api_sp_GetPlanningDI " & _ndinnum

    lblTitre.Text = Me.Text

    ' Jours fériés..
    Using cmd As New SqlCommand(sql, MozartDatabase.cnxMozart)
      dt.Load(cmd.ExecuteReader())
    End Using

    If (dt.Rows.Count <= 0) Then
      lblTitre.Text += "  : aucune donnée"
      Return
    End If

    Dim rows As DataRow() = dt.Select("DIPLDATJ Is Not Null", "DIPLDATJ DESC")

    Dim minDate As DateTime = rows(rows.Count - 1)("DIPLDATJ")
    Dim maxDate As DateTime = rows(0)("DIPLDATJ")

    Dim dtCol As DataTable = New DataTable()
    dtCol.Columns.Add(FIELDNAME_INTER, GetType(String))
    lTmpDate = minDate
    While lTmpDate <= maxDate
      dtCol.Columns.Add(lTmpDate.ToString("dd/MM/yy"), GetType(String))

      lTmpDate = lTmpDate.AddDays(1)
    End While
    gridPlanning.DataSource = dtCol

    Dim lCurrentName As String

    For Each row As DataRow In dt.Rows
      Dim lCurrentRow As Integer

      lCurrentName = row("NOMCOMPLET").ToString()
      ' Afficher les intervenants dans la 1ère cellule
      If lCurrentName <> precInt Then
        bandedGridView.AddNewRow()
        lCurrentRow = GridControl.NewItemRowHandle
        bandedGridView.SetRowCellValue(lCurrentRow, bandedGridView.Columns(FIELDNAME_INTER), lCurrentName)

        'Couleur grise pour les jours fériés
        For i = 0 To bandedGridView.Columns.Count - 1
          If IsDate(bandedGridView.Columns.Item(i).Caption) Then
            lTmpDate = CType(bandedGridView.Columns.Item(i).Caption, Date)

            If lTmpDate.DayOfWeek = DayOfWeek.Saturday Or lTmpDate.DayOfWeek = DayOfWeek.Sunday Or lstJoursFeries.Where(Function(d) d = lTmpDate).Count() > 0 Then
              bandedGridView.SetRowCellValue(lCurrentRow, bandedGridView.Columns.Item(i), "S" + SEPARATOR)
            End If
          End If
        Next
      End If
      precInt = lCurrentName

      lTxtCell = ""

      If row("DIPLDATJ").ToString() <> "" Then
        lTmpDate = row("DIPLDATJ")

        'en fonction du CETACOD mettre en vert (exécuté), rouge (retard) ou bleu (à venir)
        If lTmpDate < DateTime.Now Then
          lTxtCell = IIf(row("CETACOD") <> "E", "R", "G")
        Else
          lTxtCell = "B"
        End If

        lTxtCell += SEPARATOR + "-- DI " & row("NDINNUM") & vbCrLf & row("VACTDES").ToString()
      End If

      bandedGridView.SetRowCellValue(lCurrentRow, bandedGridView.Columns(lTmpDate.ToString("dd/MM/yy")), lTxtCell)
    Next

    bandedGridView.MoveFirst()
  End Sub

  Private Sub draw3DBorder(pCache As GraphicsCache, pRect As Rectangle)
    Dim lPainter As BorderPainter = BorderHelper.GetPainter(DevExpress.XtraEditors.Controls.BorderStyles.Style3D)
    Dim lBorderAppearance As AppearanceObject = New AppearanceObject() With {
      .BorderColor = Color.DarkGray
    }

    lPainter.DrawObject(New BorderObjectInfoArgs(pCache, lBorderAppearance, pRect))
  End Sub

  Private Sub frmPlanningDI_Load(sender As Object, e As EventArgs) Handles MyBase.Load
    Me.Text = "Planning projet"

    Initboutons(Me)

    fillJoursFeries()
    drawPlanning()

    ' Couleurs pour la légende
    lblBlue.BackColor = ColorBlue
    lblGreen.BackColor = ColorGreen
    lblRed.BackColor = ColorRed
    lblSilver.BackColor = ColorSilver
  End Sub

  Private Sub drawPlanning()
    Cursor.Current = Cursors.WaitCursor

    drawGridHeader()
    drawGridContent()

    Cursor.Current = Cursors.Default
  End Sub

  Private Sub BtnFermer_Click(sender As Object, e As EventArgs) Handles BtnFermer.Click
    Me.Close()
  End Sub

  Private Sub btnLegende_Click(sender As Object, e As EventArgs) Handles btnLegendeFermer.Click, btnLegende.Click
    frame1.Visible = Not frame1.Visible
  End Sub

  Private Sub bandedGridView_CustomDrawBandHeader(sender As Object, e As BandHeaderCustomDrawEventArgs) Handles bandedGridView.CustomDrawBandHeader
    If e.Band Is Nothing Then Exit Sub

    e.Handled = True

    Dim lR As Rectangle = e.Bounds
    draw3DBorder(e.Cache, lR)
    lR.Inflate(-1, -1)

    e.Cache.FillRectangle(Brushes.Yellow, lR)

    If e.Info.Caption = CAPTION_INTER Then Exit Sub

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
      e.Cache.FillRectangle(Brushes.Yellow, lR)
    End If

    Dim lSf As New StringFormat With {
      .LineAlignment = StringAlignment.Center,
      .Alignment = StringAlignment.Center
    }

    If e.Info.Caption <> CAPTION_INTER Then
      lSf.FormatFlags = StringFormatFlags.DirectionVertical Or StringFormatFlags.DirectionRightToLeft
    End If

    e.Graphics.DrawString(e.Info.Caption, e.Appearance.Font, e.Appearance.GetForeBrush(e.Cache), lR, lSf)
  End Sub

  Private Sub bandedGridView_RowCellStyle(sender As Object, e As RowCellStyleEventArgs) Handles bandedGridView.RowCellStyle
    If e.Column Is Nothing Then Exit Sub

    If e.Column.FieldName = FIELDNAME_INTER Then
      e.Appearance.BackColor = Color.Yellow
    Else
      Dim lTxtColor As String
      Dim lColor As Color
      Dim bNoCustom As Boolean

      If (e.CellValue IsNot Nothing) And (e.CellValue IsNot DBNull.Value) Then
        lTxtColor = e.CellValue.ToString().Substring(0, 1)

        bNoCustom = False

        Select Case lTxtColor
          Case "R"
            lColor = ColorRed
          Case "G"
            lColor = ColorGreen
          Case "B"
            lColor = ColorBlue
          Case "S"
            lColor = ColorSilver
          Case "W"
            lColor = Color.White
          Case Else
            bNoCustom = True
        End Select

        If bNoCustom Then Exit Sub

        e.Appearance.BackColor = lColor
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
End Class