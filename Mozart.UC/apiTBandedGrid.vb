Imports System.ComponentModel
Imports System.Data.SqlClient
Imports System.Drawing
Imports System.Globalization
Imports System.Windows.Forms
Imports DevExpress.Data
Imports DevExpress.Export
Imports DevExpress.Utils
Imports DevExpress.XtraEditors
Imports DevExpress.XtraEditors.Controls
Imports DevExpress.XtraEditors.Repository
Imports DevExpress.XtraGrid
Imports DevExpress.XtraGrid.Columns
Imports DevExpress.XtraGrid.Views.BandedGrid
Imports DevExpress.XtraGrid.Views.Base
Imports DevExpress.XtraGrid.Views.Grid
Imports DevExpress.XtraGrid.Views.Grid.ViewInfo
Imports DevExpress.XtraPrinting
Imports MozartLib


Public Class apiTBandedGrid

    Public Const COL_ALIGN_LEFT As Integer = 0
    Public Const COL_ALIGN_CENTER As Integer = 2
    Public Const COL_ALIGN_RIGHT As Integer = 1

    <Description("Custum Click event"), Category("Appearance")>
    Public Event ClickE(sender As Object, e As EventArgs)
    <Description("Custum DoubleClick event"), Category("Appearance")>
    Public Event DoubleClickE(sender As Object, e As EventArgs)
    Public Event InitNewRowE(sender As Object, e As InitNewRowEventArgs)
    Public Event PreviewKeyDownE(sender As Object, e As PreviewKeyDownEventArgs)
    Public Event RowCellStyle(sender As Object, e As RowCellStyleEventArgs)
    Public Event RowStyle(sender As Object, e As RowStyleEventArgs)
    Public Event SelectionChanged(sender As Object, e As DevExpress.Data.SelectionChangedEventArgs)
    Public Event RowCellClick(sender As Object, e As RowCellClickEventArgs)
    Public Event CellValueChanging(sender As Object, e As CellValueChangedEventArgs)
    Public Event CellValueChanged(sender As Object, e As CellValueChangedEventArgs)
    Public Event ColumnFilterChanged(sender As Object, e As EventArgs)
    Public Event ValidateRowE(sender As Object, e As ValidateRowEventArgs)
    Public Event EditorKeyPressE(sender As Object, e As KeyPressEventArgs)
    Public Event FocusedRowChanged(sender As Object, e As FocusedRowChangedEventArgs)
    Public Event ShowingEditor(sender As Object, e As CancelEventArgs)

    Public FontBold As New Font("Arial", 8.0F, FontStyle.Bold)
    Public FontSimple As New Font("Arial", 8.0F, FontStyle.Regular)

    Public dicCellsAlignment As New Dictionary(Of String, HorzAlignment)
    Public dicCellTips As New Dictionary(Of String, Dictionary(Of String, String))

    Public sSqlDataSource As String
    Dim isFiltering = False
    Private iDataTableRowCount As Integer
    Private sNumToDial As String

    ' Retourne l'indice dans la collection de 'Bands'
    Public Function AddBand(sCaption As String, Optional iAlign As Integer = COL_ALIGN_CENTER) As Integer
        Dim lNewBand As New GridBand With {
          .Caption = sCaption
        }
        lNewBand.AppearanceHeader.Options.UseTextOptions = True

        Select Case iAlign
            Case COL_ALIGN_LEFT
                lNewBand.AppearanceHeader.TextOptions.HAlignment = HorzAlignment.Near
            Case COL_ALIGN_RIGHT
                lNewBand.AppearanceHeader.TextOptions.HAlignment = HorzAlignment.Far
            Case COL_ALIGN_CENTER
                lNewBand.AppearanceHeader.TextOptions.HAlignment = HorzAlignment.Center
            Case Else
                lNewBand.AppearanceHeader.TextOptions.HAlignment = HorzAlignment.Default
        End Select

        dgv.Bands.Add(lNewBand)

        Return dgv.Bands.Count - 1
    End Function

    ' Positionne la première band fixe quand on utilise la scrollbar horizontale
    Public Sub SetFirstBandFixed()
        Try
            dgv.OptionsView.ColumnAutoWidth = False
            dgv.Bands(0).Fixed = FixedStyle.Left
        Catch ex As Exception
        End Try
    End Sub

  Public Sub AddCalculatedColumn(lBandNo As Integer, sNom As String, sField As String, sFormula As String, pType As UnboundColumnType, iLarg As Integer,
                                   Optional sFormat As String = "")
    Dim c As New BandedGridColumn()
    With c
      .Visible = IIf(iLarg = 0, False, True)
      .Caption = sNom
      .Name = sField
      .FieldName = sField
      .UnboundExpression = sFormula
      .UnboundType = pType
      .Width = iLarg / 10
      .OptionsColumn.AllowEdit = False
      .OptionsColumn.ReadOnly = True

      If sFormat = "N2" Then
        .DisplayFormat.FormatType = FormatType.Numeric
        .DisplayFormat.FormatString = "N2"
      Else
        '.DisplayFormat.FormatString = ""
      End If
    End With

    Me.dgv.Columns.Add(c)
    Me.dgv.Bands(lBandNo).Columns.Add(c)
  End Sub

  ' Ajoute une colonne non sélectionnable par l'utilisateur
  Public Sub AddHiddenColumn(lBandNo As Integer, sField As String)
        AddColumn(lBandNo, sField, sField, 0)

        Me.dgv.Columns(Me.dgv.Columns.Count - 1).OptionsColumn.ShowInCustomizationForm = False
    End Sub

    Public Sub AddColumn(lBandNo As Integer, sNom As String, sField As String, iLarg As Integer, Optional sFormat As String = "",
                         Optional iAlign As Integer = 0,
                         Optional Ellipsis As Boolean = False,
                         Optional Bouton As Boolean = False, Optional Check As Boolean = False)


        ' Ajout et formattage d'une nouvelle colonne
        Dim c As New BandedGridColumn()
        With c
            .Visible = IIf(iLarg = 0, False, True)
            .Caption = sNom
            .Name = sField
            .FieldName = sField
            .Width = iLarg / 10
            .MinWidth = iLarg / 10
            .OptionsColumn.AllowEdit = False
            .OptionsColumn.ReadOnly = True
        End With

        If Check Then
            dgv.OptionsSelection.MultiSelect = True
            dgv.OptionsSelection.MultiSelectMode = GridMultiSelectMode.RowSelect
        End If

        If sFormat = "Date" Then
            c.DisplayFormat.FormatType = FormatType.DateTime
            c.DisplayFormat.FormatString = "dd/MM/yyyy HH:mm:ss"
        ElseIf sFormat.ToLower() = "dd/mm/yy" Then
            c.DisplayFormat.FormatType = FormatType.DateTime
            c.DisplayFormat.FormatString = "dd/MM/yy"
        ElseIf sFormat.StartsWith("dd/MM/yy") Then
            c.DisplayFormat.FormatType = FormatType.DateTime
            c.DisplayFormat.FormatString = sFormat
        ElseIf sFormat.ToLower() = "hh:mm:ss" Then
            c.DisplayFormat.FormatType = FormatType.DateTime
            c.DisplayFormat.FormatString = " HH:mm:ss"
        ElseIf sFormat = "Currency" Or sFormat.Contains("$") Then
            c.DisplayFormat.FormatType = FormatType.Numeric
            c.DisplayFormat.FormatString = "c2"
        ElseIf sFormat.Contains("#") Or sFormat.StartsWith("N") _
               Or sFormat.StartsWith("D") Or sFormat.StartsWith("0.0") Then
            c.DisplayFormat.FormatType = FormatType.Numeric
            c.DisplayFormat.FormatString = sFormat
        End If

        Select Case iAlign
            Case COL_ALIGN_LEFT
                dicCellsAlignment.Add(sField, HorzAlignment.Near)
            Case COL_ALIGN_RIGHT
                dicCellsAlignment.Add(sField, HorzAlignment.Far)
            Case COL_ALIGN_CENTER
                dicCellsAlignment.Add(sField, HorzAlignment.Center)
            Case Else
                dicCellsAlignment.Add(sField, HorzAlignment.Default)
        End Select

        Me.dgv.Columns.Add(c)
        Me.dgv.Bands(lBandNo).Columns.Add(c)

    End Sub

    Dim editorForEditing As RepositoryItemComboBox

    Public Sub DesactiveListe()
        Me.dgv.OptionsBehavior.AllowAddRows = False
        Me.dgv.OptionsBehavior.AllowDeleteRows = False
        Me.dgv.OptionsBehavior.Editable = False
    End Sub

    Public Function GetFocusedDataRow() As DataRow
        Return CType(Me.GridControl.DefaultView, GridView).GetFocusedDataRow()
    End Function

    Public Function FocusedColumn() As BandedGridColumn
        Return CType(Me.GridControl.DefaultView, GridView).FocusedColumn()
    End Function

    Public Sub ClearColumns()
        dgv.Columns.Clear()
        dicCellsAlignment.Clear()
        chkColumnsList.Properties.Items.Clear()
    End Sub

    Public Sub DelockColumn(colName As String, Optional dt As DataTable = Nothing)
        dgv.Columns(colName).OptionsColumn.AllowEdit = True
        dgv.Columns(colName).OptionsColumn.ReadOnly = False
    End Sub

    Public Sub btnPrint_Click(ByVal sender As Object, ByVal e As EventArgs) Handles btnPrint.Click
        UpdateColumnPrintVisibility(chkColumnsList)
        GridControl.ShowPrintPreview()
    End Sub

    Public Sub btnExcel_Click(sender As Object, e As EventArgs) Handles btnExcel.Click
        Dim fileName As String

        fileName = $"{Environment.GetFolderPath(Environment.SpecialFolder.UserProfile)}\ExportExcel{DateTime.Now:yyyyMMddHHmmss}.xlsx"

        UpdateColumnPrintVisibility(chkColumnsList)

        Dim lXlsxExportOptions As New XlsxExportOptionsEx With {
          .ExportType = ExportType.WYSIWYG
        }
        dgv.OptionsPrint.AutoWidth = False
        GridControl.ExportToXlsx(fileName, lXlsxExportOptions)
        Try
            Process.Start(fileName)
        Catch ex As Exception
        End Try
    End Sub

    Public Sub InitColumnList()
        For Each column As BandedGridColumn In dgv.Columns
            chkColumnsList.Properties.Items.Add(column, column.Caption, CheckState.Checked, True)
        Next column
    End Sub

    Private Sub UpdateColumnPrintVisibility(ByVal cb As CheckedComboBoxEdit)
        For Each item As CheckedListBoxItem In cb.Properties.Items
            TryCast(item.Value, BandedGridColumn).OptionsColumn.Printable = If(item.CheckState = CheckState.Checked, DefaultBoolean.True, DefaultBoolean.False)
        Next item
    End Sub

    Private Sub GridView1_CustomDrawFooter(ByVal sender As Object, ByVal e As DevExpress.XtraGrid.Views.Base.RowObjectCustomDrawEventArgs) Handles dgv.CustomDrawFooter
        e.Appearance.DrawBackground(e.Cache, e.Bounds)

        If (iDataTableRowCount = 0 Or iDataTableRowCount = dgv.DataRowCount) Then
            lblRowCount.Text = $"Nb enreg : {dgv.DataRowCount}"
        Else
            lblRowCount.Text = $"Nb enreg : {dgv.DataRowCount} / {iDataTableRowCount}"
        End If

        lblRowCount.Top = e.Bounds.Top + 7
        chkColumnsList.Top = e.Bounds.Top + 3
        btnPrint.Top = e.Bounds.Top + 3
        btnExcel.Top = e.Bounds.Top + 3
        cmdTelAuto.Top = e.Bounds.Top + 3

        e.Handled = True
    End Sub

    Private Sub apiTBandedGrid_RowCellStyle(sender As Object, e As DevExpress.XtraGrid.Views.Grid.RowCellStyleEventArgs) Handles dgv.RowCellStyle
        If dicCellsAlignment.ContainsKey(e.Column.FieldName) Then e.Appearance.TextOptions.HAlignment = dicCellsAlignment(e.Column.FieldName)
        RaiseEvent RowCellStyle(dgv, e)
    End Sub

    Private Sub apiTBandedGrid_RowStyle(sender As Object, e As DevExpress.XtraGrid.Views.Grid.RowStyleEventArgs) Handles dgv.RowStyle
        RaiseEvent RowStyle(dgv, e)
    End Sub

    Private Sub dgv_DoubleClick(sender As Object, e As EventArgs) Handles dgv.DoubleClick
        RaiseEvent DoubleClickE(dgv, e)
    End Sub

    Private Sub dgv_Click(sender As Object, e As EventArgs) Handles dgv.Click
        RaiseEvent ClickE(dgv, e)
    End Sub

    Public Property FilterBar() As Boolean
        Get
            Return dgv.OptionsView.ShowAutoFilterRow
        End Get
        Set(ByVal FilterBar As Boolean)
            dgv.OptionsView.ShowAutoFilterRow = FilterBar
        End Set
    End Property

    Public Property FooterBar() As Boolean
        Get
            Return dgv.OptionsView.ShowFooter
        End Get
        Set(ByVal FooterBar As Boolean)
            dgv.OptionsView.ShowFooter = FooterBar
        End Set
    End Property

    Private Sub dgv_SelectionChanged(sender As Object, e As DevExpress.Data.SelectionChangedEventArgs) Handles dgv.SelectionChanged
        RaiseEvent SelectionChanged(dgv, e)
    End Sub

    Public Sub FocusOnFilterBar()
        dgv.FocusedRowHandle = GridControl.AutoFilterRowHandle
        dgv.FocusedColumn = dgv.Columns(0)
        dgv.ShowEditor()
    End Sub

    Private Sub dgv_EndSorting(ByVal sender As Object, ByVal e As EventArgs) Handles dgv.EndSorting
        dgv.MoveFirst()
    End Sub

    Private Sub dgv_RowCellClick(sender As Object, e As RowCellClickEventArgs) Handles dgv.RowCellClick

        If e.CellValue IsNot Nothing AndAlso e.CellValue IsNot DBNull.Value Then
            ' VL 05/05/2021 - Ajout bouton cmdTelAuto
            sNumToDial = Replace(Replace(e.CellValue.ToString(), ".", ""), " ", "")
            If sNumToDial <> Nothing Then
                If IsNumeric(sNumToDial) And Len(sNumToDial) > 8 And Not sNumToDial.EndsWith("€") And Not sNumToDial.Contains(",") Then
                    Dim xPos = 0
                    For index = 0 To dgv.Columns.Count - 1
                        If dgv.Columns(index).ColumnHandle = e.Column.ColumnHandle Then Exit For
                        ' TODO : dgv.VisibleColumns
                        xPos += dgv.Columns(index).VisibleWidth
                    Next
                    cmdTelAuto.Left = xPos + 30
                    cmdTelAuto.Visible = True
                Else
                    cmdTelAuto.Visible = False
                    sNumToDial = ""
                End If
            End If
        End If

        RaiseEvent RowCellClick(dgv, e)
    End Sub

    Private Sub dgv_CellValueChanged(sender As Object, e As CellValueChangedEventArgs) Handles dgv.CellValueChanged
        RaiseEvent CellValueChanged(dgv, e)
    End Sub

    Private Sub dgv_CellValueChanging(sender As Object, e As CellValueChangedEventArgs) Handles dgv.CellValueChanging
        RaiseEvent CellValueChanging(dgv, e)
    End Sub

    Private Sub dgv_ColumnFilterChanged(sender As Object, e As EventArgs) Handles dgv.ColumnFilterChanged
        RaiseEvent ColumnFilterChanged(dgv, e)
    End Sub

    Public Sub LoadData(dt As DataTable, cnx As SqlConnection, sQuery As String, Optional cmdTimeout As Int16 = 30)
        Dim CmdSql As New SqlCommand(sQuery, cnx) With {
          .CommandTimeout = cmdTimeout
        }
        sSqlDataSource = sQuery
        dt.Rows.Clear()
        dt.Clear()
        dt.Load(CmdSql.ExecuteReader)
        iDataTableRowCount = dt.Rows.Count

        RepositoryItemTextEdit.MaxToolTipTextLength = 2000

    End Sub

    Public Sub Requery(dt As DataTable, cnx As SqlConnection)

        If (sSqlDataSource Is Nothing) Then Exit Sub

        Dim focusedRow As Int32 = dgv.FocusedRowHandle

        LoadData(dt, cnx, sSqlDataSource)

        If (focusedRow <> Int32.MinValue) Then
            dgv.FocusedRowHandle = Math.Max(0, Math.Min(dt.Rows.Count - 1, focusedRow))
            dgv.SelectRow(focusedRow)
            dgv.Focus()
        End If

    End Sub

    Private Sub apiTBandedGrid_Resize(sender As Object, e As EventArgs) Handles MyBase.Resize
        btnPrint.Left = Me.Width - btnPrint.Width - 5
        btnExcel.Left = btnPrint.Left - btnExcel.Width - 3
        chkColumnsList.Left = btnExcel.Left - chkColumnsList.Width - 8
    End Sub

    Private Sub ToolTipController1_GetActiveObjectInfo(sender As Object, e As ToolTipControllerGetActiveObjectInfoEventArgs) Handles ToolTipController1.GetActiveObjectInfo
        If e.SelectedControl IsNot GridControl Then Return

        Dim info As ToolTipControlInfo = Nothing
        'Get the view at the current mouse position

        Dim View As GridView = GridControl.GetViewAt(e.ControlMousePosition)
        If (View Is Nothing) Then Return

        'Get the view's element information that resides at the current position
        Dim hi As GridHitInfo = View.CalcHitInfo(e.ControlMousePosition)

        'Display a hint for row indicator cells
        If hi.HitTest = GridHitTest.RowCell Then
            If dicCellTips.Keys.Contains(hi.Column.Name) Then

                Dim DataRow As DataRowView = Me.dgv.GetRow(hi.RowHandle)
                Try
                    Dim sValue = DataRow.Row.ItemArray(hi.Column.ColumnHandle)
                    ', System.Data.DataRowView).Row.ItemArray(12)
                    Dim sInfo = dicCellTips(hi.Column.Name)(sValue)
                    'An object that uniquely identifies a row indicator cell
                    Dim o As Object = hi.HitTest.ToString() + hi.RowHandle.ToString()

                    info = New ToolTipControlInfo(o, sInfo)
                Catch ex As Exception

                End Try
            End If
        End If
        'Supply tooltip information if applicable, otherwise preserve default tooltip (if any)
        If info IsNot Nothing Then e.Info = info
    End Sub

    Private Sub GridControl_EditorKeyPress(sender As Object, e As KeyPressEventArgs) Handles GridControl.EditorKeyPress
        Dim GC As GridControl = sender
        Dim View As GridView = GC.FocusedView

        If View.FocusedColumn.ColumnType = GetType(Decimal) Or View.FocusedColumn.ColumnType = GetType(Double) Then
            If (e.KeyChar = ".") Or (e.KeyChar = ",") Then
                e.KeyChar = CultureInfo.CurrentCulture.NumberFormat.NumberDecimalSeparator
            End If
        End If
        RaiseEvent EditorKeyPressE(GridControl, e)
    End Sub

    Private Sub dgv_InitNewRow(sender As Object, e As InitNewRowEventArgs) Handles dgv.InitNewRow
        RaiseEvent InitNewRowE(dgv, e)
    End Sub

    Private Sub GridControl_PreviewKeyDown(sender As Object, e As PreviewKeyDownEventArgs) Handles GridControl.PreviewKeyDown
        RaiseEvent PreviewKeyDownE(GridControl, e)
    End Sub

    Private Async Sub cmdTelAuto_Click(sender As Object, e As EventArgs) Handles cmdTelAuto.Click
        Using apiTel As New ApiTelAuto()
            apiTel.TelDial(sNumToDial)
            If (apiTel.bDialOK = False) Then
                Dim response As String = Await MozartLib.CNumerotationAuto.MakeCallByAvaya(MozartParams.UserTelInt, sNumToDial, Environment.MachineName)
                If (response <> "OK") Then
                    MessageBox.Show(response, "Erreur Avaya", MessageBoxButtons.OK, MessageBoxIcon.Error)
                End If
            End If
        End Using
        cmdTelAuto.Visible = False
        sNumToDial = ""
    End Sub

    Private Sub dgv_ValidateRow(sender As Object, e As ValidateRowEventArgs) Handles dgv.ValidateRow
    RaiseEvent ValidateRowE(GridControl, e)
  End Sub

  Private Sub dgv_InvalidRowException(sender As Object, e As InvalidRowExceptionEventArgs) Handles dgv.InvalidRowException
    e.ExceptionMode = ExceptionMode.NoAction
  End Sub

  Public Sub CacherCompteur()
    lblRowCount.Visible = False
  End Sub

  Public Sub CacherBoutonsPrintExcel()
    btnExcel.Visible = False
    btnPrint.Visible = False
    chkColumnsList.Visible = False
  End Sub

  Private Sub dgv_FocusedRowChanged(sender As Object, e As FocusedRowChangedEventArgs) Handles dgv.FocusedRowChanged
    RaiseEvent FocusedRowChanged(dgv, e)
  End Sub

End Class
