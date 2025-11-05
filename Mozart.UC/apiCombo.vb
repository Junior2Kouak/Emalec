Imports DevExpress.XtraEditors
Imports DevExpress.XtraEditors.Controls
Imports MozartLib
Imports System.Data.SqlClient
Imports System.Windows.Forms

Public Class apiCombo

  Dim _newValues As Boolean = False
  Public Property NewValues()
    Get
      Return _newValues
    End Get
    Set(value)
      _newValues = value
      lookup1.autocomplete = Not _newValues
    End Set
  End Property

  Public Event TxtChanged(sender As Object, e As EventArgs)
  Public Event cboClick(sender As Object, e As EventArgs)
  Public Event cboKeyPress(sender As Object, e As KeyPressEventArgs)

  Public Shadows Function CurrentRow() As Object
    Return lookup1.GetSelectedDataRow()
  End Function

  Public Function DataSource() As Object
    Return lookup1.Properties.DataSource
  End Function

  Public Sub SetColumnVisible(pColumnName As String, pVisible As Boolean)
    Try
      lookup1.Properties.Columns(pColumnName).Visible = pVisible
    Catch ex As Exception

    End Try
  End Sub
  Public Function GetText() As String
    Return lookup1.Text                     ' CODE + LIBELLE
  End Function

  Public Function GetItemData() As Integer
    If (lookup1.ItemIndex >= 0) Then
      Return lookup1.GetSelectedDataRow(0)    ' CODE
    Else
      Return -1
    End If
  End Function

  Public Function GetItemDataString() As String
    If (lookup1.ItemIndex >= 0) Then
      Return lookup1.GetSelectedDataRow(0)    ' CODE
    Else
      Return ""
    End If
  End Function

  Public Function GetValue() As String
    Return lookup1.EditValue.ToString  ' Valeur saisie
  End Function

  Public Function GetItemValue() As String
    If (lookup1.ItemIndex >= 0) Then
      Return lookup1.GetSelectedDataRow(1)    ' LIBELLE
    Else Return ""
    End If
  End Function

  Public Sub SetText(sValue As String)
    lookup1.Text = sValue
  End Sub

  Public Sub SetItemIndex(iValue As Integer)
    lookup1.ItemIndex = iValue
  End Sub

  Public Sub SetItemData(sValue As Integer)
    lookup1.EditValue = sValue
  End Sub

  Public Overrides Sub ResetText()
    lookup1.Reset()
  End Sub

  Public Sub Init(cnx As SqlConnection, sSql As String, sValueMember As String, sDisplayMember As String, lstCaptions As List(Of String),
                  iLargeur As Integer, iHauteur As Integer, Optional bHideFirstColumn As Boolean = True)

    Dim dtCrit As New DataTable()
    LoadData(dtCrit, cnx, sSql)

    Init(dtCrit, sSql, sValueMember, sDisplayMember, lstCaptions, iLargeur, iHauteur, bHideFirstColumn)

  End Sub

  Public Sub Init(dtCrit As DataTable, sSql As String, sValueMember As String, sDisplayMember As String, lstCaptions As List(Of String),
                  iLargeur As Integer, iHauteur As Integer, Optional bHideFirstColumn As Boolean = False)

    lookup1.Properties.DataSource = dtCrit
    lookup1.Properties.ForceInitialize()          ' Utile si le contrôle n'est pas encore visible
    lookup1.Properties.ValueMember = sValueMember
    lookup1.Properties.DisplayMember = sDisplayMember

    lookup1.Properties.PopulateColumns()

    For i As Integer = 0 To lstCaptions.Count - 1
      lookup1.Properties.Columns(i).Caption = lstCaptions(i)
    Next
    lookup1.Properties.PopupFormSize = New System.Drawing.Size(iLargeur, iHauteur)

    If (bHideFirstColumn) Then lookup1.Properties.Columns(0).Visible = False

  End Sub

  Public Sub Init(listeValeurs As IEnumerable, sValueMember As String, sDisplayMember As String, lstCaptions As List(Of String),
                  iLargeur As Integer, iHauteur As Integer, Optional bHideFirstColumn As Boolean = False)
    lookup1.Properties.DataSource = listeValeurs
    lookup1.Properties.ForceInitialize()          ' Utile si le contrôle n'est pas encore visible
    lookup1.Properties.ValueMember = sValueMember
    lookup1.Properties.DisplayMember = sDisplayMember

    lookup1.Properties.PopulateColumns()

    For i As Integer = 0 To lstCaptions.Count - 1
      lookup1.Properties.Columns(i).Caption = lstCaptions(i)
    Next
    lookup1.Properties.PopupFormSize = New System.Drawing.Size(iLargeur, iHauteur)

    If (bHideFirstColumn) Then lookup1.Properties.Columns(0).Visible = False
  End Sub

  Private Sub lookup1_EditValueChanged(sender As Object, e As EventArgs) Handles lookup1.EditValueChanged
    RaiseEvent TxtChanged(Me, e)
  End Sub

  Private Sub lookup1_KeyPress(sender As Object, e As KeyPressEventArgs) Handles lookup1.KeyPress
    RaiseEvent cboKeyPress(Me, e)
  End Sub

  Private Sub lookup1_ProcessNewValue(sender As Object, e As ProcessNewValueEventArgs) Handles lookup1.ProcessNewValue
    If (e.DisplayValue = String.Empty) Then
      lookup1.EditValue = -1
    Else
      If NewValues Then
        'e.DisplayValue = e.DisplayValue.ToString().ToUpper()
        Dim i As Int32 = lookup1.Properties.GetDataSourceRowIndex(lookup1.Properties.DisplayMember, e.DisplayValue)
        If i = -1 Then
          Dim dt As DataTable = TryCast(lookup1.Properties.DataSource, DataTable)
          Dim r As DataRow = dt.NewRow
          If Not dt.Columns(0).AllowDBNull Then
            If dt.Columns(0).DataType = GetType(Integer) Then
              Dim id As Int32 = -2
              If dt.Rows.Count > 0 AndAlso dt.Rows(dt.Rows.Count - 1)(lookup1.Properties.ValueMember) < 0 Then
                id = dt.Rows(dt.Rows.Count - 1)(lookup1.Properties.ValueMember) - 1
              End If
              r(lookup1.Properties.ValueMember) = id
            ElseIf dt.Columns(0).DataType = GetType(String) Then
              r(lookup1.Properties.ValueMember) = ""
            End If
          End If
          r(lookup1.Properties.DisplayMember) = e.DisplayValue
          dt.Rows.Add(r)
        End If
        e.Handled = True
      End If
    End If
  End Sub

  Private Sub LoadData(dt As DataTable, cnx As SqlConnection, sQuery As String)

    Dim CmdSql As New SqlClient.SqlCommand(sQuery, cnx)
    dt.Rows.Clear()
    dt.Clear()
    dt.Load(CmdSql.ExecuteReader)

  End Sub

  Private Sub lookup1_Click(sender As Object, e As EventArgs) Handles lookup1.Click
    RaiseEvent cboClick(Me, e)
  End Sub

  Private Sub lookup1_KeyUp(sender As Object, e As KeyEventArgs) Handles lookup1.KeyUp
    If e.KeyCode = Keys.Delete Then
      lookup1.ClosePopup()
      lookup1.EditValue = -1
    End If
    e.Handled = True
  End Sub

End Class
