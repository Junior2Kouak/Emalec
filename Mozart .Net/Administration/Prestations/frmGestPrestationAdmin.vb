Imports System.ComponentModel
Imports System.Data.SqlClient
Imports DevExpress.XtraEditors
Imports DevExpress.XtraEditors.Controls
Imports DevExpress.XtraGrid.Columns
Imports DevExpress.XtraGrid.Views.Base
Imports MozartLib

Public Class frmGestPrestationAdmin

  Dim _DtListePrest As DataTable
  Dim bActif As Boolean

  Private Sub frmGestPrestationAdmin_Load(sender As Object, e As EventArgs) Handles MyBase.Load

    'INIT
    Initboutons(Me)
    bActif = True
    ChkModifiable.CheckState = CheckState.Unchecked

    LoadDataCbo()

  End Sub

  Private Sub LoadDataCbo()

    Dim oCboSerie As New CPrestationSerie
    Dim ooCboSousSerie As New CPrestationSousSerie()
    Dim oCboType As New CPrestationType
    Dim oCboUnite As New CPrestationUnite

    oCboSerie.LoadDataListeSerie(False)

    GridLookUpSerie.Properties.DataSource = oCboSerie.DtListeSerie()

    RepItemGLU_TPRESTSER.DataSource = oCboSerie.DtListeSerie()
    RepItemGLU_TREF_PREST_TYPE.DataSource = oCboType.DtListeType
    RepItemGLU_TREF_PREST_SS_SERIE.DataSource = ooCboSousSerie.dtListeSousSerie

    RepItemGLU_TUNITE.DataSource = oCboUnite.DtListeUnite

  End Sub

  Private Sub LoadData()

    Me.Cursor = Cursors.WaitCursor

    _DtListePrest = New DataTable

    Dim sFilter As String = ""

    'construction du filter
    If GridLookUpSerie.EditValue.ToString <> "" Then If sFilter = "" Then sFilter = String.Format("WHERE NPRESTSERID = {0}", GridLookUpSerie.EditValue.ToString) Else sFilter = sFilter & String.Format(" AND NPRESTSERID = {0}", GridLookUpSerie.EditValue.ToString)

    If TxtCritPresta.Text <> "" Then If sFilter = "" Then sFilter = String.Format("WHERE VPRESTLIB LIKE '%{0}%'", TxtCritPresta.Text) Else sFilter = sFilter & String.Format(" AND VPRESTLIB LIKE '%{0}%'", TxtCritPresta.Text)
    If TxtCritCreateur.Text <> "" Then If sFilter = "" Then sFilter = String.Format("WHERE CREATEUR LIKE '%{0}%'", TxtCritCreateur.Text) Else sFilter = sFilter & String.Format(" AND CREATEUR LIKE '%{0}%'", TxtCritCreateur.Text)
    If TxtCritCode.Text <> "" Then If sFilter = "" Then sFilter = String.Format("WHERE VPRESTCODE LIKE '%{0}%'", TxtCritCode.Text) Else sFilter = sFilter & String.Format(" AND VPRESTCODE LIKE '%{0}%'", TxtCritCode.Text)
    If TxtCritClients.Text <> "" Then If sFilter = "" Then sFilter = String.Format("WHERE UTIL LIKE '%{0}%'", TxtCritClients.Text) Else sFilter = sFilter & String.Format(" AND UTIL LIKE '%{0}%'", TxtCritClients.Text)

    If sFilter = "" Then sFilter = String.Format("WHERE CPRESTACTIF = '{0}'", If(bActif = True, "O", "N")) Else sFilter = sFilter & String.Format(" AND CPRESTACTIF = '{0}'", If(bActif = True, "O", "N"))

    Dim Requete As String = String.Format("select * from api_v_ListePrestation {0} ORDER BY VPRESTLIB", sFilter)

    Dim sqlcmdread As New SqlCommand(Requete, MozartDatabase.cnxMozart)
    sqlcmdread.CommandType = CommandType.Text
        _DtListePrest.Load(sqlcmdread.ExecuteReader)

        GCListePrest.DataSource = _DtListePrest

        Me.Cursor = Cursors.Default

    End Sub

    Private Sub BtnFind_Click(sender As Object, e As EventArgs) Handles BtnFind.Click

        LoadData()

    End Sub

    Private Sub BtnFermer_Click(sender As Object, e As EventArgs) Handles BtnFermer.Click
        Me.Close()
    End Sub

    Private Sub frmGestPrestationAdmin_ResizeEnd(sender As Object, e As EventArgs) Handles Me.ResizeEnd

        GCListePrest.Size = New Size(Me.Size.Width - GCListePrest.Location.X - 50, Me.Size.Height - GCListePrest.Location.Y - 50)

    End Sub

    Private Sub frmGestPrestationAdmin_SizeChanged(sender As Object, e As EventArgs) Handles Me.SizeChanged
        GCListePrest.Size = New Size(Me.Size.Width - GCListePrest.Location.X - 50, Me.Size.Height - GCListePrest.Location.Y - 50)
    End Sub

    Private Sub BtnListeArchives_Click(sender As Object, e As EventArgs) Handles BtnListeArchives.Click

        If bActif = True Then
            bActif = False
            LabelTitre.Text = "Gestion des prestations tarifées archivées"
            BtnAdd.Visible = False
            BtnArchiver.Visible = False
            BtnGestSerieAndSousSeriePresta.Visible = False
            BtnListeArchives.Text = "Liste actives"

            BtnRestaure.Visible = True

        Else
            bActif = True
            LabelTitre.Text = "Gestion des prestations tarifées"

            BtnAdd.Visible = True
            BtnArchiver.Visible = True
            BtnGestSerieAndSousSeriePresta.Visible = True
            BtnListeArchives.Text = "Liste archives"

            BtnRestaure.Visible = False

        End If
        Me.Text = LabelTitre.Text
        LoadData()

    End Sub

    Private Sub BtnRestaure_Click(sender As Object, e As EventArgs) Handles BtnRestaure.Click

        If GVListePrest.SelectedRowsCount = 0 Then Exit Sub

        If MessageBox.Show("Voulez-vous vraiment restaurer cette prestation ?", "Confirmation", MessageBoxButtons.YesNoCancel, MessageBoxIcon.Question) = DialogResult.Yes Then

            Dim drSelect As DataRow = GVListePrest.GetDataRow(GVListePrest.FocusedRowHandle)
            Dim oPrest As New CPrestation(drSelect.Item("NPRESTID"))
            oPrest.RestaurerPrestation()

            Dim iRowSelect As Int32 = GVListePrest.GetDataSourceRowIndex(GVListePrest.FocusedRowHandle)

            LoadData()

            GVListePrest.FocusedRowHandle = iRowSelect

        End If

    End Sub

    Private Sub BtnArchiver_Click(sender As Object, e As EventArgs) Handles BtnArchiver.Click

        If GVListePrest.SelectedRowsCount = 0 Then Exit Sub

        If MessageBox.Show("Voulez-vous vraiment archiver cette prestation ?", "Confirmation", MessageBoxButtons.YesNoCancel, MessageBoxIcon.Question) = DialogResult.Yes Then

            Dim drSelect As DataRow = GVListePrest.GetDataRow(GVListePrest.FocusedRowHandle)
            Dim oPrest As New CPrestation(drSelect.Item("NPRESTID"))
            oPrest.ArchiverPrestation()

            Dim iRowSelect As Int32 = GVListePrest.GetDataSourceRowIndex(GVListePrest.FocusedRowHandle)

            LoadData()

            GVListePrest.FocusedRowHandle = iRowSelect

        End If

    End Sub

    Private Sub BtnDetail_Click(sender As Object, e As EventArgs) Handles BtnDetail.Click

        If GVListePrest.SelectedRowsCount = 0 Then Exit Sub

        Dim drSelect As DataRow = GVListePrest.GetDataRow(GVListePrest.FocusedRowHandle)
        Dim oFrmDetailPresta As New frmGestPrestationDetail(New CPrestation(drSelect.Item("NPRESTID")))
        oFrmDetailPresta.ShowDialog()

        Dim iRowSelect As Int32 = GVListePrest.GetDataSourceRowIndex(GVListePrest.FocusedRowHandle)

        LoadData()

        GVListePrest.FocusedRowHandle = iRowSelect


    End Sub
    Private Sub BtnGestSerieAndSousSeriePresta_Click(sender As Object, e As EventArgs) Handles BtnGestSerieAndSousSeriePresta.Click

        Dim oFrmGestSerieAndSousSerie As New FrmGestSeriePrest()
        oFrmGestSerieAndSousSerie.ShowDialog()

        LoadDataCbo()

    End Sub

    Private Sub ChkModifiable_CheckedChanged(sender As Object, e As EventArgs) Handles ChkModifiable.CheckedChanged

        If ChkModifiable.CheckState = CheckState.Checked Then
            BtnSave.Visible = True
            GCol_List_NPREST_TYPE_ID.OptionsColumn.AllowEdit = True
            GCol_List_NPREST_TYPE_ID.OptionsColumn.ReadOnly = False
            GCol_NPRESTSERID.OptionsColumn.AllowEdit = True
            GCol_NPRESTSERID.OptionsColumn.ReadOnly = False
            GCol_NPREST_SS_SERIE_ID.OptionsColumn.AllowEdit = True
            GCol_NPREST_SS_SERIE_ID.OptionsColumn.ReadOnly = False
            GCol_VPRESTUNITE.OptionsColumn.AllowEdit = True
            GCol_VPRESTUNITE.OptionsColumn.ReadOnly = False

        Else
            BtnSave.Visible = False
            GCol_List_NPREST_TYPE_ID.OptionsColumn.AllowEdit = False
            GCol_List_NPREST_TYPE_ID.OptionsColumn.ReadOnly = True
            GCol_NPRESTSERID.OptionsColumn.AllowEdit = False
            GCol_NPRESTSERID.OptionsColumn.ReadOnly = True
            GCol_NPREST_SS_SERIE_ID.OptionsColumn.AllowEdit = False
            GCol_NPREST_SS_SERIE_ID.OptionsColumn.ReadOnly = True
            GCol_VPRESTUNITE.OptionsColumn.AllowEdit = False
            GCol_VPRESTUNITE.OptionsColumn.ReadOnly = True

        End If

    End Sub

    Private Sub BtnSave_Click(sender As Object, e As EventArgs) Handles BtnSave.Click

        If MessageBox.Show("Voulez-vous enregistrer les modifications", "Enregistrer", MessageBoxButtons.YesNoCancel, MessageBoxIcon.Question) = DialogResult.Yes Then

            Dim oDtUpdate As DataTable = _DtListePrest.GetChanges(DataRowState.Modified)

            _DtListePrest.AcceptChanges()

            'oDtUpdate.Merge(_DtListePrest, True, MissingSchemaAction.Ignore)

            If Not oDtUpdate Is Nothing Then

                If oDtUpdate.Rows.Count > 0 Then
                    For Each oRowsUpdate As DataRow In oDtUpdate.Rows

                        For Each dr As DataRow In _DtListePrest.Select("[NPRESTID] = " & oRowsUpdate.Item("NPRESTID"))

              Dim sqlcmd As New SqlCommand("[api_sp_UpdatePrestationSerieAndSousSerieAndType]", MozartDatabase.cnxMozart)
              sqlcmd.CommandType = CommandType.StoredProcedure
                            sqlcmd.Parameters.Add("@P_NPRESTID", SqlDbType.Int).Value = oRowsUpdate.Item("NPRESTID")
                            sqlcmd.Parameters.Add("@P_NPRESTSERID", SqlDbType.Int).Value = dr.Item("NPRESTSERID")
                            sqlcmd.Parameters.Add("@P_NPREST_SS_SERIE_ID", SqlDbType.Int).Value = dr.Item("NPREST_SS_SERIE_ID")
                            sqlcmd.Parameters.Add("@P_NPREST_TYPE_ID", SqlDbType.Int).Value = dr.Item("NPREST_TYPE_ID")
                            sqlcmd.Parameters.Add("@P_VPRESTUNITE", SqlDbType.VarChar).Value = dr.Item("VPRESTUNITE")

                            sqlcmd.ExecuteNonQuery()

                        Next

                    Next
                End If
            End If


        End If

    End Sub

    Private Sub TxtCrit_KeyDown(sender As Object, e As KeyEventArgs) Handles TxtCritPresta.KeyDown, TxtCritCode.KeyDown, TxtCritCreateur.KeyDown, TxtCritClients.KeyDown
        If e.KeyCode = Keys.Return Then
            BtnFind.PerformClick()
        End If
    End Sub

    Private Sub BtnCopiePresta_Click(sender As Object, e As EventArgs) Handles BtnCopiePresta.Click

        If GVListePrest.SelectedRowsCount = 0 Then Exit Sub

        Dim drSelect As DataRow = GVListePrest.GetDataRow(GVListePrest.FocusedRowHandle)
        Dim oFrmDetailPrestaCopie As New frmGestPrestationDetail(New CPrestation(drSelect.Item("NPRESTID")), "COPIE")
        oFrmDetailPrestaCopie.ShowDialog()

        Dim iRowSelect As Int32 = GVListePrest.GetDataSourceRowIndex(GVListePrest.FocusedRowHandle)

        LoadData()

        GVListePrest.FocusedRowHandle = iRowSelect

    End Sub

    Private Sub BtnAdd_Click(sender As Object, e As EventArgs) Handles BtnAdd.Click

        Dim oFrmDetailPresta As New frmGestPrestationDetail(New CPrestation(0))
        oFrmDetailPresta.ShowDialog()

        Dim iRowSelect As Int32 = GVListePrest.GetDataSourceRowIndex(GVListePrest.FocusedRowHandle)

        LoadData()

        GVListePrest.FocusedRowHandle = iRowSelect

    End Sub

    Private Sub BtnPrixClients_Click(sender As Object, e As EventArgs) Handles BtnPrixClients.Click

        If GVListePrest.SelectedRowsCount = 0 Then Exit Sub

        Dim drSelect As DataRow = GVListePrest.GetDataRow(GVListePrest.FocusedRowHandle)

        If drSelect.Item("NPRESTID") = 0 Then Exit Sub

        Dim oFrmDetailPrestaCopie As New frmGestPrestationPrixClient(drSelect.Item("NPRESTID"), drSelect.Item("PR"))
        oFrmDetailPrestaCopie.ShowDialog()

        Dim iRowSelect As Int32 = GVListePrest.GetDataSourceRowIndex(GVListePrest.FocusedRowHandle)

        LoadData()

        GVListePrest.FocusedRowHandle = iRowSelect

    End Sub

    Private Sub GVListePrest_CustomDrawFooter(sender As Object, e As RowObjectCustomDrawEventArgs) Handles GVListePrest.CustomDrawFooter

        If _DtListePrest Is Nothing Then Exit Sub

        Dim oPos As Rectangle = e.Bounds
        Dim oFormat As New StringFormat
        Dim iNbLineTotal As Int32 = 0
        Dim iNbLineTotalVisible As Int32 = 0

        oPos.Location = New Point(oPos.Left + 1, oPos.Top + 1)
        oPos.Size = New Size(oPos.Width - 2, oPos.Height - 2)

        oFormat.Alignment = StringAlignment.Center

        e.Appearance.DrawString(e.Cache, String.Format("{0} / {1}", GVListePrest.RowCount, _DtListePrest.Rows.Count), oPos, oFormat)
        e.Handled = True

    End Sub

    Private Sub GridLookUpSerie_EditValueChanged(sender As Object, e As EventArgs) Handles GridLookUpSerie.EditValueChanged

        If GridLookUpSerie.EditValue IsNot Nothing AndAlso GridLookUpSerie.EditValue.ToString <> "" Then
            BtnFind.PerformClick()
        End If

    End Sub


    'Private Sub GVListePrest_ShowingEditor(sender As Object, e As CancelEventArgs) Handles GVListePrest.ShowingEditor

    '    If GVListePrest.FocusedRowHandle < -1 Then Exit Sub

    '    Dim view As ColumnView = DirectCast(sender, ColumnView)
    '    If view.FocusedColumn.FieldName = "NPREST_SS_SERIE_ID" AndAlso TypeOf view.ActiveEditor Is GridLookUpEdit Then
    '        Dim edit As GridLookUpEdit = CType(view.ActiveEditor, GridLookUpEdit)
    '        Dim countryCode As Int32 = Convert.ToInt32(view.GetFocusedRowCellValue("NPRESTSERID"))
    '        Dim ooCboSousSerie As New CPrestationSousSerie(countryCode)
    '        edit.Properties.DataSource = ooCboSousSerie.dtListeSousSerie

    '    End If

    'End Sub

    'Private Sub RepItemGLU_TPRESTSER_EditValueChanged(sender As Object, e As EventArgs) Handles RepItemGLU_TPRESTSER.EditValueChanged

    '    Dim parentLookUp As GridLookUpEdit = TryCast(sender, GridLookUpEdit)
    '    Dim editValue As Object = parentLookUp.EditValue
    '    Dim ooCboSousSerie As New CPrestationSousSerie(editValue)
    '    RepItemGLU_TREF_PREST_SS_SERIE.DataSource = ooCboSousSerie.dtListeSousSerie

    'End Sub

    'Private Sub GVListePrest_HiddenEditor(sender As Object, e As EventArgs) Handles GVListePrest.HiddenEditor

    '    Dim view As ColumnView = DirectCast(sender, ColumnView)
    '    If View.FocusedColumn.FieldName = "NPREST_SS_SERIE_ID" AndAlso TypeOf View.ActiveEditor Is GridLookUpEdit Then
    '        Dim edit As GridLookUpEdit = CType(View.ActiveEditor, GridLookUpEdit)
    '        Dim ooCboSousSerie As New CPrestationSousSerie(0)
    '        edit.Properties.DataSource = ooCboSousSerie.dtListeSousSerie
    '    End If

    'End Sub
End Class