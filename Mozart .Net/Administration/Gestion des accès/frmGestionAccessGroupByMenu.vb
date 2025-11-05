Imports System.Data.SqlClient
Imports System.Drawing
Imports System.Drawing.Drawing2D
Imports DevExpress.XtraEditors
Imports DevExpress.XtraEditors.Repository
Imports DevExpress.XtraGrid.Columns
Imports DevExpress.XtraGrid.Views.Base
Imports DevExpress.XtraGrid.Views.Grid
Imports DevExpress.XtraTreeList
Imports MozartLib

Public Class frmGestionAccessGroupByMenu

  Dim _DtListeMenuDroit As DataTable
  Dim _DtListePersByMenu As DataTable

  Private Sub frmGestionAccessGroupByMenu_Load(sender As Object, e As EventArgs) Handles MyBase.Load

    LoadData()

  End Sub

  Private Sub LoadData()

    _DtListeMenuDroit = New DataTable

    Dim sqlcmd As New SqlCommand("[api_sp_ListeMenuMOZART]", MozartDatabase.cnxMozart)
    sqlcmd.CommandType = CommandType.StoredProcedure
    _DtListeMenuDroit.Load(sqlcmd.ExecuteReader)

    TreeList_Menu.DataSource = _DtListeMenuDroit

  End Sub

  Private Sub BtnFermer_Click(sender As Object, e As EventArgs) Handles BtnFermer.Click
    Me.Close()
  End Sub

  Private Sub TreeList_Menu_CustomDrawNodeButton(sender As Object, e As CustomDrawNodeButtonEventArgs) Handles TreeList_Menu.CustomDrawNodeButton
    Dim rect As Rectangle = Rectangle.Inflate(e.Bounds, 0, -2)
    ' painting background
    Dim BackBrush = e.Cache.GetGradientBrush(rect, Color.Blue, Color.LightSkyBlue,
                                             LinearGradientMode.ForwardDiagonal)
    e.Cache.FillRectangle(BackBrush, rect)
    ' painting borders
    e.Cache.DrawRectangle(e.Cache.GetPen(Color.LightGray), rect)


    ' determining the character to display
    Dim DisplayCharacter As String = "+"
    If e.Expanded Then DisplayCharacter = "-"
    ' formatting the output character
    Dim OutCharacterFormat = e.Appearance.GetStringFormat()
    OutCharacterFormat.Alignment = StringAlignment.Center
    OutCharacterFormat.LineAlignment = StringAlignment.Center

    ' painting the character
    e.Appearance.FontSizeDelta = -2
    e.Appearance.FontStyleDelta = FontStyle.Bold
    e.Cache.DrawString(DisplayCharacter, e.Appearance.Font,
                          e.Cache.GetSolidBrush(Color.White), rect, OutCharacterFormat)

    ' prohibiting default painting
    e.Handled = True
  End Sub

  Private Sub TreeList_Menu_FocusedNodeChanged(sender As Object, e As FocusedNodeChangedEventArgs) Handles TreeList_Menu.FocusedNodeChanged

    'on save le employés sélectionner
    Dim dtSelected As New DataTable
    dtSelected.Columns.Add("NPERNUM", Type.GetType("System.Int32"))

    Dim dr_New As DataRow

    Dim SelectedRowHandle As Int32() = GVPersGroupe.GetSelectedRows()

    Dim view As ColumnView = CType(GCPersGroupe.MainView, ColumnView)

    If SelectedRowHandle.Length > 0 Then
      For i As Integer = 0 To SelectedRowHandle.Length - 1
        dr_New = dtSelected.NewRow
        dr_New.Item("NPERNUM") = view.GetDataRow(SelectedRowHandle(i)).Item("NPERNUM")
        dtSelected.Rows.Add(dr_New)
      Next
    End If

    LoadDroitByMenu(e.Node.Item("NMENUNUM"))

    'on réaffecte les employés sélectionner
    'Console.WriteLine("person affecte : " & dtSelected.Rows.Count.ToString)

    If dtSelected.Rows.Count > 0 Then

      For Each dr As DataRow In dtSelected.Rows

        Dim introw As Int32 = GVPersGroupe.LocateByValue("NPERNUM", dr.Item("NPERNUM"))
        If introw <> DevExpress.XtraGrid.GridControl.InvalidRowHandle Then

          GVPersGroupe.SelectRow(introw)

        End If

      Next

    End If

  End Sub

  Private Sub LoadDroitByMenu(ByVal p_NMENUNUM As Int32)

    _DtListePersByMenu = New DataTable

    Dim sqlcmd As New SqlCommand("[api_sp_ListeDroitPersByMenu]", MozartDatabase.cnxMozart)
    sqlcmd.CommandType = CommandType.StoredProcedure
    sqlcmd.Parameters.Add("@P_NMENUNUM", SqlDbType.Int).Value = p_NMENUNUM
    _DtListePersByMenu.Load(sqlcmd.ExecuteReader)


    _DtListePersByMenu.Columns("CDROITVAL_EMALEC").ReadOnly = False
    _DtListePersByMenu.Columns("CDROITVAL_EQUIPAGE").ReadOnly = False
    _DtListePersByMenu.Columns("CDROITVAL_SCS").ReadOnly = False
    _DtListePersByMenu.Columns("CDROITVAL_MAGESTIME").ReadOnly = False
    _DtListePersByMenu.Columns("CDROITVAL_EMALECDEV").ReadOnly = False
    _DtListePersByMenu.Columns("CDROITVAL_EMALECESPAGNE").ReadOnly = False
    _DtListePersByMenu.Columns("CDROITVAL_EMALECIDF").ReadOnly = False
    _DtListePersByMenu.Columns("CDROITVAL_EMALECLUXEMBOURG").ReadOnly = False
    _DtListePersByMenu.Columns("CDROITVAL_EMALECMPM").ReadOnly = False
    _DtListePersByMenu.Columns("CDROITVAL_EMAFI").ReadOnly = False

    GCPersGroupe.DataSource = _DtListePersByMenu

  End Sub

  Private Sub GVPersGroupe_CustomRowCellEdit(sender As Object, e As CustomRowCellEditEventArgs) Handles GVPersGroupe.CustomRowCellEdit

    Dim dr As DataRow = GVPersGroupe.GetDataRow(e.RowHandle)

    If Not dr Is Nothing Then
      Select Case e.Column.FieldName
        Case "CDROITVAL_EMALEC"
          If IsDBNull(dr.Item("CDROITVAL_EMALEC")) Then
            e.RepositoryItem = Nothing
          Else
            e.RepositoryItem = RepositoryItemCheckEditEMALEC
          End If
        Case "CDROITVAL_EQUIPAGE"
          If IsDBNull(dr.Item("CDROITVAL_EQUIPAGE")) Then
            e.RepositoryItem = Nothing
          Else
            e.RepositoryItem = RepositoryItemCheckEditEQUIPAGE
          End If
        Case "CDROITVAL_SCS"
          If IsDBNull(dr.Item("CDROITVAL_SCS")) Then
            e.RepositoryItem = Nothing
          Else
            e.RepositoryItem = RepositoryItemCheckEditSCS
          End If
        Case "CDROITVAL_MAGESTIME"
          If IsDBNull(dr.Item("CDROITVAL_MAGESTIME")) Then
            e.RepositoryItem = Nothing
          Else
            e.RepositoryItem = RepositoryItemCheckEditMAGESTIME
          End If
        Case "CDROITVAL_EMALECDEV"
          If IsDBNull(dr.Item("CDROITVAL_EMALECDEV")) Then
            e.RepositoryItem = Nothing
          Else
            e.RepositoryItem = RepositoryItemCheckEditEMALECDEV
          End If
        Case "CDROITVAL_EMALECESPAGNE"
          If IsDBNull(dr.Item("CDROITVAL_EMALECESPAGNE")) Then
            e.RepositoryItem = Nothing
          Else
            e.RepositoryItem = RepositoryItemCheckEditEMALECESPAGNE
          End If
        Case "CDROITVAL_EMALECIDF"
          If IsDBNull(dr.Item("CDROITVAL_EMALECIDF")) Then
            e.RepositoryItem = Nothing
          Else
            e.RepositoryItem = RepositoryItemCheckEditEMALECIDF
          End If
        Case "CDROITVAL_EMALECLUXEMBOURG"
          If IsDBNull(dr.Item("CDROITVAL_EMALECLUXEMBOURG")) Then
            e.RepositoryItem = Nothing
          Else
            e.RepositoryItem = RepositoryItemCheckEditEMALECLUXEMBOURG
          End If
        Case "CDROITVAL_EMALECMPM"
          If IsDBNull(dr.Item("CDROITVAL_EMALECMPM")) Then
            e.RepositoryItem = Nothing
          Else
            e.RepositoryItem = RepositoryItemCheckEditEMALECMPM
          End If
        Case "CDROITVAL_EMAFI"
          If IsDBNull(dr.Item("CDROITVAL_EMAFI")) Then
            e.RepositoryItem = Nothing
          Else
            e.RepositoryItem = RepositoryItemCheckEditSAMSICROMANIA
          End If
      End Select

    End If

  End Sub

  Private Sub RepositoryItemCheckEditEMALEC_CheckedChanged(sender As Object, e As EventArgs) Handles RepositoryItemCheckEditEMALEC.CheckedChanged
    UpdateDroit(sender, "EMALEC")
  End Sub

  Private Sub RepositoryItemCheckEditEMALECDEV_CheckedChanged(sender As Object, e As EventArgs) Handles RepositoryItemCheckEditEMALECDEV.CheckedChanged
    UpdateDroit(sender, "EMALECDEV")
  End Sub

  Private Sub RepositoryItemCheckEditEMALECESPAGNE_CheckedChanged(sender As Object, e As EventArgs) Handles RepositoryItemCheckEditEMALECESPAGNE.CheckedChanged
    UpdateDroit(sender, "EMALECESPAGNE")
  End Sub

  Private Sub RepositoryItemCheckEditEMALECIDF_CheckedChanged(sender As Object, e As EventArgs) Handles RepositoryItemCheckEditEMALECIDF.CheckedChanged
    UpdateDroit(sender, "EMALECIDF")
  End Sub

  Private Sub RepositoryItemCheckEditEMALECLUXEMBOURG_CheckedChanged(sender As Object, e As EventArgs) Handles RepositoryItemCheckEditEMALECLUXEMBOURG.CheckedChanged
    UpdateDroit(sender, "EMALECLUXEMBOURG")
  End Sub

  Private Sub RepositoryItemCheckEditEMALECMPM_CheckedChanged(sender As Object, e As EventArgs) Handles RepositoryItemCheckEditEMALECMPM.CheckedChanged
    UpdateDroit(sender, "EMALECMPM")
  End Sub

  Private Sub RepositoryItemCheckEditEQUIPAGE_CheckedChanged(sender As Object, e As EventArgs) Handles RepositoryItemCheckEditEQUIPAGE.CheckedChanged
    UpdateDroit(sender, "EMALECEQUIPAGE")
  End Sub

  Private Sub RepositoryItemCheckEditMAGESTIME_CheckedChanged(sender As Object, e As EventArgs) Handles RepositoryItemCheckEditMAGESTIME.CheckedChanged
    UpdateDroit(sender, "MAGESTIME")
  End Sub

  Private Sub RepositoryItemCheckEditSAMSICROMANIA_CheckedChanged(sender As Object, e As EventArgs) Handles RepositoryItemCheckEditSAMSICROMANIA.CheckedChanged
    UpdateDroit(sender, "EMAFI")
  End Sub

  Private Sub RepositoryItemCheckEditSCS_CheckedChanged(sender As Object, e As EventArgs) Handles RepositoryItemCheckEditSCS.CheckedChanged
    UpdateDroit(sender, "SCS")
  End Sub

  Private Sub UpdateDroit(ByVal sender As Object, ByVal p_vsociete As String)

    Dim dr As DataRow = GVPersGroupe.GetDataRow(GVPersGroupe.FocusedRowHandle)
    If Not dr Is Nothing Then

      Dim check As CheckEdit = TryCast(sender, CheckEdit)

      Dim sqlcmdUpdate As New SqlCommand("[api_sp_UpdateDroitMOZART]", MozartDatabase.cnxMozart)
      sqlcmdUpdate.CommandType = CommandType.StoredProcedure
      sqlcmdUpdate.Parameters.Add("@P_VPERADSI", SqlDbType.VarChar).Value = dr.Item("VPERADSI").ToString
      sqlcmdUpdate.Parameters.Add("@P_NMENUNUM", SqlDbType.Int).Value = TreeList_Menu.FocusedNode.Item("NMENUNUM")
      sqlcmdUpdate.Parameters.Add("@P_VSOCIETE_SRC", SqlDbType.VarChar).Value = p_vsociete
      If check.CheckState = CheckState.Checked Then
        sqlcmdUpdate.Parameters.Add("@P_VALUE", SqlDbType.Char).Value = "O"
      Else
        sqlcmdUpdate.Parameters.Add("@P_VALUE", SqlDbType.Char).Value = "N"
      End If
      sqlcmdUpdate.ExecuteNonQuery()

    End If

  End Sub

  Private Sub frmGestionAccessGroupByMenu_ResizeEnd(sender As Object, e As EventArgs) Handles Me.ResizeEnd

    GCPersGroupe.Size = New Size(Me.Size.Width - GCPersGroupe.Location.X - 50, Me.Size.Height - GCPersGroupe.Location.Y - 50)

  End Sub

  Private Sub frmGestionAccessGroupByMenu_SizeChanged(sender As Object, e As EventArgs) Handles Me.SizeChanged
    GCPersGroupe.Size = New Size(Me.Size.Width - GCPersGroupe.Location.X - 50, Me.Size.Height - GCPersGroupe.Location.Y - 50)
  End Sub

  Private Sub BtnAffecter_Click(sender As Object, e As EventArgs) Handles BtnAffecter.Click

    If GVPersGroupe.SelectedRowsCount = 0 Then
      MessageBox.Show("Il faut sélectionner un ou des personnes", "Message", MessageBoxButtons.OK, MessageBoxIcon.Exclamation)
      Exit Sub
    End If

    If MessageBox.Show("Voulez-vous affecter les droits à ce menu aux personnnes sélectionnées ?", "Confirmation", MessageBoxButtons.YesNoCancel, MessageBoxIcon.Question) = DialogResult.Yes Then

      Dim SelectedRowHandle As Int32() = GVPersGroupe.GetSelectedRows()

      Dim view As ColumnView = CType(GCPersGroupe.MainView, ColumnView)

      If SelectedRowHandle.Length > 0 Then
        For i As Integer = 0 To SelectedRowHandle.Length - 1

          Dim dr_view As DataRow = view.GetDataRow(SelectedRowHandle(i))

          'recherche par filiale
          For Each oColFiliale As GridColumn In view.Columns

            Select Case oColFiliale.FieldName
              Case "CDROITVAL_EMALEC"
                If Not IsDBNull(dr_view.Item("CDROITVAL_EMALEC")) Then
                  UpdateDroit_BySelect(dr_view, TreeList_Menu.FocusedNode.Item("NMENUNUM"), "EMALEC", "O")
                  dr_view.Item("CDROITVAL_EMALEC") = "O"
                End If
              Case "CDROITVAL_EQUIPAGE"
                If Not IsDBNull(dr_view.Item("CDROITVAL_EQUIPAGE")) Then
                  UpdateDroit_BySelect(dr_view, TreeList_Menu.FocusedNode.Item("NMENUNUM"), "EQUIPAGE", "O")
                  dr_view.Item("CDROITVAL_EQUIPAGE") = "O"
                End If
              Case "CDROITVAL_SCS"
                If Not IsDBNull(dr_view.Item("CDROITVAL_SCS")) Then
                  UpdateDroit_BySelect(dr_view, TreeList_Menu.FocusedNode.Item("NMENUNUM"), "SCS", "O")
                  dr_view.Item("CDROITVAL_SCS") = "O"
                End If
              Case "CDROITVAL_MAGESTIME"
                If Not IsDBNull(dr_view.Item("CDROITVAL_MAGESTIME")) Then
                  UpdateDroit_BySelect(dr_view, TreeList_Menu.FocusedNode.Item("NMENUNUM"), "MAGESTIME", "O")
                  dr_view.Item("CDROITVAL_MAGESTIME") = "O"
                End If
              Case "CDROITVAL_EMALECDEV"
                If Not IsDBNull(dr_view.Item("CDROITVAL_EMALECDEV")) Then
                  UpdateDroit_BySelect(dr_view, TreeList_Menu.FocusedNode.Item("NMENUNUM"), "EMALECDEV", "O")
                  dr_view.Item("CDROITVAL_EMALECDEV") = "O"
                End If
              Case "CDROITVAL_EMALECESPAGNE"
                If Not IsDBNull(dr_view.Item("CDROITVAL_EMALECESPAGNE")) Then
                  UpdateDroit_BySelect(dr_view, TreeList_Menu.FocusedNode.Item("NMENUNUM"), "EMALECESPAGNE", "O")
                  dr_view.Item("CDROITVAL_EMALECESPAGNE") = "O"
                End If
              Case "CDROITVAL_EMALECIDF"
                If Not IsDBNull(dr_view.Item("CDROITVAL_EMALECIDF")) Then
                  UpdateDroit_BySelect(dr_view, TreeList_Menu.FocusedNode.Item("NMENUNUM"), "EMALECIDF", "O")
                  dr_view.Item("CDROITVAL_EMALECIDF") = "O"
                End If
              Case "CDROITVAL_EMALECLUXEMBOURG"
                If Not IsDBNull(dr_view.Item("CDROITVAL_EMALECLUXEMBOURG")) Then
                  UpdateDroit_BySelect(dr_view, TreeList_Menu.FocusedNode.Item("NMENUNUM"), "EMALECLUXEMBOURG", "O")
                  dr_view.Item("CDROITVAL_EMALECLUXEMBOURG") = "O"
                End If
              Case "CDROITVAL_EMALECMPM"
                If Not IsDBNull(dr_view.Item("CDROITVAL_EMALECMPM")) Then
                  UpdateDroit_BySelect(dr_view, TreeList_Menu.FocusedNode.Item("NMENUNUM"), "EMALECMPM", "O")
                  dr_view.Item("CDROITVAL_EMALECMPM") = "O"
                End If
              Case "CDROITVAL_EMAFI"
                If Not IsDBNull(dr_view.Item("CDROITVAL_EMAFI")) Then
                  UpdateDroit_BySelect(dr_view, TreeList_Menu.FocusedNode.Item("NMENUNUM"), "EMAFI", "O")
                  dr_view.Item("CDROITVAL_EMAFI") = "O"
                End If
            End Select



          Next

        Next
      End If

      GVPersGroupe.RefreshData()

      MessageBox.Show("Affectation du menu terminée avec succès", "Message", MessageBoxButtons.OK, MessageBoxIcon.Information)

    End If

  End Sub

  Private Sub BtnDesaffect_Click(sender As Object, e As EventArgs) Handles BtnDesaffect.Click

    If GVPersGroupe.SelectedRowsCount = 0 Then
      MessageBox.Show("Il faut sélectionner un ou des personnes", "Message", MessageBoxButtons.OK, MessageBoxIcon.Exclamation)
      Exit Sub
    End If

    If MessageBox.Show("Voulez-vous désaffecter les droits à ce menu aux personnnes sélectionnées ?", "Confirmation", MessageBoxButtons.YesNoCancel, MessageBoxIcon.Question) = DialogResult.Yes Then

      Dim SelectedRowHandle As Int32() = GVPersGroupe.GetSelectedRows()

      Dim view As ColumnView = CType(GCPersGroupe.MainView, ColumnView)

      If SelectedRowHandle.Length > 0 Then
        For i As Integer = 0 To SelectedRowHandle.Length - 1

          Dim dr_view As DataRow = view.GetDataRow(SelectedRowHandle(i))

          'recherhce par filiale
          For Each oColFiliale As GridColumn In view.Columns

            Select Case oColFiliale.FieldName
              Case "CDROITVAL_EMALEC"
                If Not IsDBNull(dr_view.Item("CDROITVAL_EMALEC")) Then
                  UpdateDroit_BySelect(dr_view, TreeList_Menu.FocusedNode.Item("NMENUNUM"), "EMALEC", "N")
                  dr_view.Item("CDROITVAL_EMALEC") = "N"
                End If
              Case "CDROITVAL_EQUIPAGE"
                If Not IsDBNull(dr_view.Item("CDROITVAL_EQUIPAGE")) Then
                  UpdateDroit_BySelect(dr_view, TreeList_Menu.FocusedNode.Item("NMENUNUM"), "EQUIPAGE", "N")
                  dr_view.Item("CDROITVAL_EQUIPAGE") = "N"
                End If
              Case "CDROITVAL_SCS"
                If Not IsDBNull(dr_view.Item("CDROITVAL_SCS")) Then
                  UpdateDroit_BySelect(dr_view, TreeList_Menu.FocusedNode.Item("NMENUNUM"), "SCS", "N")
                  dr_view.Item("CDROITVAL_SCS") = "N"
                End If
              Case "CDROITVAL_MAGESTIME"
                If Not IsDBNull(dr_view.Item("CDROITVAL_MAGESTIME")) Then
                  UpdateDroit_BySelect(dr_view, TreeList_Menu.FocusedNode.Item("NMENUNUM"), "MAGESTIME", "N")
                  dr_view.Item("CDROITVAL_MAGESTIME") = "N"
                End If
              Case "CDROITVAL_EMALECDEV"
                If Not IsDBNull(dr_view.Item("CDROITVAL_EMALECDEV")) Then
                  UpdateDroit_BySelect(dr_view, TreeList_Menu.FocusedNode.Item("NMENUNUM"), "EMALECDEV", "N")
                  dr_view.Item("CDROITVAL_EMALECDEV") = "N"
                End If
              Case "CDROITVAL_EMALECESPAGNE"
                If Not IsDBNull(dr_view.Item("CDROITVAL_EMALECESPAGNE")) Then
                  UpdateDroit_BySelect(dr_view, TreeList_Menu.FocusedNode.Item("NMENUNUM"), "EMALECESPAGNE", "N")
                  dr_view.Item("CDROITVAL_EMALECESPAGNE") = "N"
                End If
              Case "CDROITVAL_EMALECIDF"
                If Not IsDBNull(dr_view.Item("CDROITVAL_EMALECIDF")) Then
                  UpdateDroit_BySelect(dr_view, TreeList_Menu.FocusedNode.Item("NMENUNUM"), "EMALECIDF", "N")
                  dr_view.Item("CDROITVAL_EMALECIDF") = "N"
                End If
              Case "CDROITVAL_EMALECLUXEMBOURG"
                If Not IsDBNull(dr_view.Item("CDROITVAL_EMALECLUXEMBOURG")) Then
                  UpdateDroit_BySelect(dr_view, TreeList_Menu.FocusedNode.Item("NMENUNUM"), "EMALECLUXEMBOURG", "N")
                  dr_view.Item("CDROITVAL_EMALECLUXEMBOURG") = "N"
                End If
              Case "CDROITVAL_EMALECMPM"
                If Not IsDBNull(dr_view.Item("CDROITVAL_EMALECMPM")) Then
                  UpdateDroit_BySelect(dr_view, TreeList_Menu.FocusedNode.Item("NMENUNUM"), "EMALECMPM", "N")
                  dr_view.Item("CDROITVAL_EMALECMPM") = "N"
                End If
              Case "CDROITVAL_EMAFI"
                If Not IsDBNull(dr_view.Item("CDROITVAL_EMAFI")) Then
                  UpdateDroit_BySelect(dr_view, TreeList_Menu.FocusedNode.Item("NMENUNUM"), "EMAFI", "N")
                  dr_view.Item("CDROITVAL_EMAFI") = "N"
                End If
            End Select

            Dim oRepChk As RepositoryItemCheckEdit = CType(oColFiliale.ColumnEdit, RepositoryItemCheckEdit)
            If oRepChk IsNot Nothing Then oRepChk.ValueChecked = False

          Next

        Next
      End If

      GVPersGroupe.RefreshData()

      MessageBox.Show("Désaffectation du menu terminée avec succès", "Message", MessageBoxButtons.OK, MessageBoxIcon.Information)

    End If

  End Sub

  Private Sub UpdateDroit_BySelect(ByVal DR_Selected As DataRow, ByVal p_NMENUNUM As Int32, ByVal p_vsociete As String, ByVal p_Value As String)

    If Not DR_Selected Is Nothing Then

      Dim sqlcmdUpdate As New SqlCommand("[api_sp_UpdateDroitMOZART]", MozartDatabase.cnxMozart)
      sqlcmdUpdate.CommandType = CommandType.StoredProcedure
      sqlcmdUpdate.Parameters.Add("@P_VPERADSI", SqlDbType.VarChar).Value = DR_Selected.Item("VPERADSI").ToString
      sqlcmdUpdate.Parameters.Add("@P_NMENUNUM", SqlDbType.Int).Value = p_NMENUNUM
      sqlcmdUpdate.Parameters.Add("@P_VSOCIETE_SRC", SqlDbType.VarChar).Value = p_vsociete
      sqlcmdUpdate.Parameters.Add("@P_VALUE", SqlDbType.Char).Value = p_Value
      sqlcmdUpdate.ExecuteNonQuery()


    End If

  End Sub

End Class