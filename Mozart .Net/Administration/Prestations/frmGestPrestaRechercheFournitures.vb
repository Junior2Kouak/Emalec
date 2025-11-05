Imports DevExpress.XtraGrid.Views.Base
Imports DevExpress.XtraGrid.Views.Grid
Imports MozartLib

Public Class frmGestPrestaRechercheFournitures

  Dim dtListeFoSRC As DataTable

  Dim _mStrType As String
  Dim _bQteVisible As Boolean

  Dim _dtListFoOut As DataTable


  Public Sub New(ByVal c_oPrestation As CPrestation, ByVal c_mStrType As String, ByVal c_bQteVisible As Boolean)
    ' Cet appel est requis par le concepteur.
    InitializeComponent()

    _mStrType = c_mStrType
    _bQteVisible = c_bQteVisible
    _dtListFoOut = c_oPrestation.dtDetailPrestaFou
  End Sub

  Private Sub frmGestPrestaRechercheFournitures_Load(sender As Object, e As EventArgs) Handles MyBase.Load
    Me.Cursor = Cursors.WaitCursor

    'init affichage
    Select Case _mStrType
      Case "Prestation"
        GroupBox1.Text = GroupBox1.Text & " (Le prix unitaire tient compte du cout de recyclage)"
    End Select

    ucSelectArticle.init(MozartDatabase.cnxMozart, 0)

    LoadDataOut()

    Me.Cursor = Cursors.Default
  End Sub

  ' Returns the total amount for a specific row. 
  Private Function getTotalValue(view As GridView, listSourceRowIndex As Int32) As Decimal
    Dim unitPrice As Decimal = Convert.ToDecimal(view.GetListSourceRowCellValue(listSourceRowIndex, "Prix U"))
    Dim quantity As Decimal = Convert.ToDecimal(view.GetListSourceRowCellValue(listSourceRowIndex, "Quantite"))

    Return unitPrice * quantity
  End Function

  Private Sub GV_FO_DEST_CustomUnboundColumnData(sender As Object, e As CustomColumnDataEventArgs) Handles GV_FO_DEST.CustomUnboundColumnData
    Dim view As GridView = TryCast(sender, GridView)

    If e.Column.FieldName = "Prix Total" AndAlso e.IsGetData Then
      e.Value = getTotalValue(view, e.ListSourceRowIndex)
    End If
  End Sub

  Public Sub LoadDataOut()
    If _dtListFoOut IsNot Nothing Then GC_FO_DEST.DataSource = _dtListFoOut
  End Sub

  Private Sub GV_FO_DEST_CellValueChanged(sender As Object, e As CellValueChangedEventArgs) Handles GV_FO_DEST.CellValueChanged
    If e.Column.FieldName = "Quantite" Then
      GV_FO_DEST.UpdateCurrentRow()
      GV_FO_DEST.UpdateTotalSummary()
    End If
  End Sub

  Private Sub BtnAddFo_Click(sender As Object, e As EventArgs) Handles BtnAddFo.Click
    If GVListeFoToPresta.SelectedRowsCount = 0 Then Exit Sub

    AddFournituresPrestation(GVListeFoToPresta.GetDataRow(GVListeFoToPresta.FocusedRowHandle))
  End Sub

  Private Sub AddFournituresPrestation(ByVal p_drselect As DataRow)
    'test si artcile deja present dans la liste
    If _dtListFoOut.Select("[NumArticle] = " & p_drselect.Item("NFOUNUM").ToString).Count > 0 Then
      MessageBox.Show("Article déjà présent dans la liste", "Erreur", MessageBoxButtons.OK, MessageBoxIcon.Exclamation)
      Exit Sub
    End If

    Dim drNewRow As DataRow
    drNewRow = _dtListFoOut.NewRow()
    drNewRow.Item("NumArticle") = p_drselect.Item("NFOUNUM")
    drNewRow.Item("Serie") = p_drselect.Item("VFOUSER")
    drNewRow.Item("Article") = p_drselect.Item("VFOUMAT")
    drNewRow.Item("Marque") = p_drselect.Item("VFOUMAR")
    drNewRow.Item("VFOUTYP") = p_drselect.Item("VFOUTYP")
    drNewRow.Item("VFOUREF") = p_drselect.Item("VFOUREF")
    drNewRow.Item("Prix U") = p_drselect.Item("FPUHT")
    drNewRow.Item("Quantite") = 1

    _dtListFoOut.Rows.Add(drNewRow)
  End Sub

  Private Sub GVListeFoToPresta_DoubleClick(sender As Object, e As EventArgs) Handles GVListeFoToPresta.DoubleClick
    If GVListeFoToPresta.FocusedRowHandle < -1 Then Exit Sub

    AddFournituresPrestation(GVListeFoToPresta.GetDataRow(GVListeFoToPresta.FocusedRowHandle))
  End Sub
  Private Sub BtnSuppFO_Click(sender As Object, e As EventArgs) Handles BtnSuppFO.Click
    If GV_FO_DEST.SelectedRowsCount = 0 Then Exit Sub

    If MessageBox.Show("Voulez-vous vraiment supprimer cette fourniture ?", "Confirmer", MessageBoxButtons.YesNoCancel, MessageBoxIcon.Question) = DialogResult.Yes Then
      Dim drSelect As DataRow = GV_FO_DEST.GetDataRow(GV_FO_DEST.FocusedRowHandle)

      drSelect.Delete()
      GV_FO_DEST.UpdateCurrentRow()
      GV_FO_DEST.UpdateTotalSummary()
    End If
  End Sub

  Private Sub GV_FO_DEST_CustomDrawFooter(sender As Object, e As RowObjectCustomDrawEventArgs) Handles GV_FO_DEST.CustomDrawFooter
    If dtListeFoSRC Is Nothing Then Exit Sub
    If _dtListFoOut Is Nothing Then Exit Sub

    Dim oPos As Rectangle = e.Bounds
    Dim oFormat As New StringFormat

    oPos.Location = New Point(oPos.Left + 1, oPos.Top + 1)
    oPos.Size = New Size(oPos.Width - 2, oPos.Height - 2)

    oFormat.Alignment = StringAlignment.Center

    e.Appearance.DrawString(e.Cache, String.Format("{0} / {1}", GV_FO_DEST.RowCount, _dtListFoOut.Rows.Count), oPos, oFormat)
    e.Handled = True
  End Sub

  Private Sub GVListeFoToPresta_CustomDrawFooter(sender As Object, e As RowObjectCustomDrawEventArgs) Handles GVListeFoToPresta.CustomDrawFooter
    If _dtListFoOut Is Nothing Then Exit Sub
    If dtListeFoSRC Is Nothing Then Exit Sub

    Dim oPos As Rectangle = e.Bounds
    Dim oFormat As New StringFormat

    oPos.Location = New Point(oPos.Left + 1, oPos.Top + 1)
    oPos.Size = New Size(oPos.Width - 2, oPos.Height - 2)

    oFormat.Alignment = StringAlignment.Center

    e.Appearance.DrawString(e.Cache, String.Format("{0} / {1}", GVListeFoToPresta.RowCount, dtListeFoSRC.Rows.Count), oPos, oFormat)
    e.Handled = True
  End Sub

  Private Sub ChkGereStock_CheckedChanged(sender As Object, e As EventArgs) Handles ChkGereStock.CheckedChanged
    If ChkGereStock.CheckState = CheckState.Checked Then
      GVListeFoToPresta.ActiveFilterString = "[CCODEG] = 'O'"
    Else
      GVListeFoToPresta.ActiveFilterString = ""
    End If
  End Sub

  Private Sub ChkNoGereStock_CheckedChanged(sender As Object, e As EventArgs) Handles ChkNoGereStock.CheckedChanged
    If ChkGereStock.CheckState = CheckState.Checked Then
      GVListeFoToPresta.ActiveFilterString = "[CCODEG] <> 'O'"
    Else
      GVListeFoToPresta.ActiveFilterString = ""
    End If
  End Sub

  Private Sub ucSelectArticle1_SearchResult(result As DataTable) Handles ucSelectArticle.SearchResult
    dtListeFoSRC = result

    GCListeFoToPresta.DataSource = dtListeFoSRC
  End Sub

  Private Sub frmGestPrestaRechercheFournitures_KeyUp(sender As Object, e As KeyEventArgs) Handles MyBase.KeyUp
    If (e.KeyCode = Keys.F2) Or (e.KeyCode = Keys.Enter) Then
      ucSelectArticle.launchSearch()
    End If
  End Sub

End Class