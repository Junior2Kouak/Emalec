Imports System.Data.SqlClient
Imports DevExpress.XtraPivotGrid
Imports MozartLib

Public Class frmGestCompetPersByCompet

  Dim DSPersByCompetence As DataSet

  Dim dtLstGestCompetence As DataTable

  Dim iNTYPECONTRATSelected As Integer

  Private Sub frmGestCompetPersByCompet_FormClosed(ByVal sender As Object, ByVal e As System.Windows.Forms.FormClosedEventArgs) Handles Me.FormClosed

    iNTYPECONTRATSelected = 0

  End Sub

  Private Sub frmGestCompetPersByCompet_FormClosing(ByVal sender As Object, ByVal e As System.Windows.Forms.FormClosingEventArgs) Handles Me.FormClosing
    ChangesDetected()
  End Sub

  Private Sub frmGestCompetPersByCompet_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load

    Try

      LoadListeGestCompetence(True)

      ResizeAllComponents()

    Catch ex As Exception

      MessageBox.Show(ex.Message)

    End Try

  End Sub

  Private Sub LoadListeGestCompetence(ByVal p_actif As Boolean)

    dtLstGestCompetence = New DataTable
    dtLstGestCompetence = ModDataGridView.LoadList(String.Format("[api_sp_ListeGestion_Competence_Per] {0}, {1}", MozartParams.NomSociete, p_actif), MozartDatabase.cnxMozart)

    PvtGridCompetence.DataSource = dtLstGestCompetence

  End Sub

  Private Sub BtnClose_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles BtnClose.Click

    Me.Close()

  End Sub

  Private Sub LoadPersByCompetence(ByVal p_CPERTYPE As String, ByVal p_NIDCOMPET As Int32)

    DSPersByCompetence = New DataSet

    GCListPersByCompet.ShowOnlyPredefinedDetails = True

    Dim cmdLoadList As New SqlCommand("[api_sp_ListePersByCompetence]", MozartDatabase.cnxMozart)
    cmdLoadList.CommandType = CommandType.StoredProcedure
    'sqlcmd
    cmdLoadList.Parameters.Add("@p_NIDCOMPET", SqlDbType.Int).Value = p_NIDCOMPET
    cmdLoadList.Parameters.Add("@P_CPERTYP", SqlDbType.Char).Value = p_CPERTYPE
    cmdLoadList.Parameters.Add("@P_VSOCIETE", SqlDbType.VarChar).Value = MozartParams.NomSociete

    Dim dr1 As New DataTable

    dr1.Load(cmdLoadList.ExecuteReader)
    dr1.Columns("baffecte").ReadOnly = False

    DSPersByCompetence.Tables.Add(dr1)

    GCListPersByCompet.DataSource = DSPersByCompetence.Tables(0)

  End Sub

  Private Function ChangesDetected() As DialogResult

    'on teste si il y eu des modifs questions non enregistrer.
    If Not DSPersByCompetence Is Nothing AndAlso Not DSPersByCompetence.Tables(0).GetChanges Is Nothing Then

      If DSPersByCompetence.Tables(0).GetChanges.Rows.Count > 0 Then

        Select Case MessageBox.Show(My.Resources.Global_Enregistrer_Modif, My.Resources.Global_Confirmation, MessageBoxButtons.YesNoCancel, MessageBoxIcon.Exclamation)

          Case DialogResult.Yes
            BtnSave.PerformClick()
            Return DialogResult.Yes
          Case DialogResult.Cancel
            Return DialogResult.Cancel
          Case Else
            Return DialogResult.No
        End Select

      Else

        Return DialogResult.No

      End If

    Else

      Return DialogResult.No

    End If

  End Function

  Private Sub BtnSave_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles BtnSave.Click

    Try

      If Not DSPersByCompetence Is Nothing AndAlso Not DSPersByCompetence.Tables(0).GetChanges Is Nothing Then

        DSPersByCompetence.Tables(0).AcceptChanges()
        'sauvegarde des lignes inventaires
        If DSPersByCompetence.Tables(0).Rows.Count > 0 Then
          For Each oRowsCont As DataRow In DSPersByCompetence.Tables(0).Rows
            SaveLigneCompetenceByPers(oRowsCont)
          Next
        End If

        GVPersByCompet.RefreshData()

      End If

    Catch ex As Exception

      MessageBox.Show(ex.Message)

    End Try

  End Sub

  Private Sub SaveLigneCompetenceByPers(ByVal oRowsSavTemp As DataRow)

    Try

      Dim sqlcmdCreateLigne As New SqlCommand("[api_sp_CreationContratByPers]", MozartDatabase.cnxMozart)
      sqlcmdCreateLigne.CommandType = CommandType.StoredProcedure
      sqlcmdCreateLigne.Parameters.Add("@P_NIDCOMPETENCEPER", SqlDbType.Int).Value = oRowsSavTemp.Item("NIDCOMPETENCEPER")
      sqlcmdCreateLigne.Parameters.Add("@P_NPERNUM", SqlDbType.Int).Value = oRowsSavTemp.Item("NPERNUM")
      sqlcmdCreateLigne.Parameters.Add("@p_NIDCOMPET", SqlDbType.Int).Value = oRowsSavTemp.Item("NIDCOMPET")
      sqlcmdCreateLigne.Parameters.Add("@P_COCHER", SqlDbType.Int).Value = oRowsSavTemp.Item("BAFFECTE")

      sqlcmdCreateLigne.ExecuteNonQuery()

    Catch ex As Exception
      MessageBox.Show(ex.Message)
    End Try

  End Sub

  Private Sub ResizeAllComponents()

    'GrpBoxCompetence.Height = Me.Height - GrpBoxCompetence.top - 40

    '  GrpBoxLstContrat.Width = Me.Width - GrpBoxLstContrat.Left - 15
    GrpBoxLstCompetenceByPer.Height = Me.Height - GrpBoxLstCompetenceByPer.Top - 40

  End Sub

  Private Sub frmGestCompetPersByCompet_ResizeEnd(ByVal sender As Object, ByVal e As System.EventArgs) Handles Me.ResizeEnd, Me.SizeChanged

    ResizeAllComponents()

  End Sub

  Private Sub BtnParPers_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles BtnParPers.Click

    Dim ofrmGestCompetenceByPers As New frmGestCompetenceByPers
    ofrmGestCompetenceByPers.ShowDialog()
    Me.Close()

  End Sub

  Private Sub PvtGridCompetence_MouseClick(sender As Object, e As System.Windows.Forms.MouseEventArgs) Handles PvtGridCompetence.MouseClick

    Dim cells As PivotGridCells = PvtGridCompetence.Cells

    ChangesDetected()

    If Not cells Is Nothing Then

      Dim ds As PivotDrillDownDataSource = cells.GetFocusedCellInfo.CreateDrillDownDataSource()
      For i As Int32 = 0 To ds.RowCount - 1 Step 1
        Dim row As PivotDrillDownDataRow = ds(i)

        'titre
        GrpBoxLstCompetenceByPer.Text = String.Format(My.Resources.GestContratType_frmGestCompetPersByCompet_ListGrpPers & " {0}", row("VLIBCOMPET"))

        'load du personnel selon le type
        LoadPersByCompetence(row("CPERTYPE"), row("NIDCOMPET"))

      Next i

    End If

  End Sub

  Private Sub RepItemChkPersBAFFECTE_CheckedChanged(sender As Object, e As System.EventArgs) Handles RepItemChkPersBAFFECTE.CheckedChanged

    Dim odtr As DataRow = GVPersByCompet.GetDataRow(GVPersByCompet.GetSelectedRows(0))

    If Not odtr Is Nothing AndAlso odtr.Item("BAFFECTE") = True Then
      CType(sender, DevExpress.XtraEditors.CheckEdit).Checked = False
      odtr.Item("BAFFECTE") = 0
    Else
      CType(sender, DevExpress.XtraEditors.CheckEdit).Checked = True
      odtr.Item("BAFFECTE") = 1
    End If

    GVPersByCompet.PostEditor()
    GCListPersByCompet.Refresh()

  End Sub

  Private Sub BtnCocheAll_Click(sender As System.Object, e As System.EventArgs) Handles BtnCocheAll.Click

    CocherAllFilterTous_Or_DecocheAllFilter(DSPersByCompetence.Tables(0), "BAFFECTE", GVPersByCompet.ActiveFilterCriteria, True)

  End Sub

  Private Sub BtnDeCocheAll_Click(sender As System.Object, e As System.EventArgs) Handles BtnDeCocheAll.Click

    CocherAllFilterTous_Or_DecocheAllFilter(DSPersByCompetence.Tables(0), "BAFFECTE", GVPersByCompet.ActiveFilterCriteria, False)

  End Sub
End Class