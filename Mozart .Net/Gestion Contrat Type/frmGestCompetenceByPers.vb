Imports System.Data.SqlClient
Imports MozartLib

Public Class frmGestCompetenceByPers

  Dim DSCompetByPer As DataSet

  Dim iNPERNUMSelected As Int32
  Dim sCPERTYP As String

  Private Sub frmGestCompetenceByPers_FormClosed(ByVal sender As Object, ByVal e As System.Windows.Forms.FormClosedEventArgs) Handles Me.FormClosed

    iNPERNUMSelected = 0
    sCPERTYP = ""

  End Sub

  Private Sub frmGestCompetenceByPers_FormClosing(ByVal sender As Object, ByVal e As System.Windows.Forms.FormClosingEventArgs) Handles Me.FormClosing
    ChangesDetected()
  End Sub

  Private Sub frmGestCompetenceByPers_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load

    Try

      'INIT
      sCPERTYP = ""

      GCListPer.DataSource = ModDataGridView.LoadList(String.Format("[api_sp_ListePerWithType] {0}", MozartParams.NomSociete), MozartDatabase.cnxMozart)

      ResizeAllComponents()

    Catch ex As Exception

      MessageBox.Show(ex.Message)

    End Try

  End Sub


  Private Sub BtnClose_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles BtnClose.Click

    Me.Close()

  End Sub

  Private Sub LoadComptenceByPer(ByVal p_npernum As Int32, ByVal p_certyp As String)

    DSCompetByPer = New DataSet

    GCListCompetenceByPer.ShowOnlyPredefinedDetails = True

    Dim cmdLoadList As New SqlCommand("[api_sp_ListeCompetenceByPer]", MozartDatabase.cnxMozart)
    cmdLoadList.CommandType = CommandType.StoredProcedure
    'sqlcmd
    cmdLoadList.Parameters.Add("@p_npernum", SqlDbType.Int).Value = p_npernum
    cmdLoadList.Parameters.Add("@p_cpertyp", SqlDbType.Char).Value = p_certyp

    Dim dr1 As New DataTable

    dr1.Load(cmdLoadList.ExecuteReader)
    dr1.Columns("BAFFECTE").ReadOnly = False

    DSCompetByPer.Tables.Add(dr1)

    GCListCompetenceByPer.DataSource = DSCompetByPer.Tables(0)

  End Sub

  Private Sub GVListPer_RowClick(ByVal sender As Object, ByVal e As DevExpress.XtraGrid.Views.Grid.RowClickEventArgs) Handles GVListPer.RowClick

    Try

      ChangesDetected()

      Dim oDataRowTmp As DataRow = GVListPer.GetDataRow(e.RowHandle)

      GrpBoxLstCompetence.Text = String.Format(My.Resources.GestionContrat_type_frmGestCompetenceByPers_Pers, oDataRowTmp.Item("NOM"))

      iNPERNUMSelected = CType(oDataRowTmp.Item("NPERNUM"), Int32)
      sCPERTYP = CType(oDataRowTmp.Item("CPERTYP"), String)

      LoadComptenceByPer(iNPERNUMSelected, sCPERTYP)

    Catch ex As Exception
      MessageBox.Show(ex.Message)
      iNPERNUMSelected = 0
    End Try


  End Sub

  Private Function ChangesDetected() As DialogResult

    'on teste si il y eu des modifs questions non enregistrer.
    If Not DSCompetByPer Is Nothing AndAlso Not DSCompetByPer.Tables(0).GetChanges Is Nothing Then

      If DSCompetByPer.Tables(0).GetChanges.Rows.Count > 0 Then

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

      If Not DSCompetByPer Is Nothing AndAlso Not DSCompetByPer.Tables(0).GetChanges Is Nothing Then

        DSCompetByPer.Tables(0).AcceptChanges()
        'sauvegarde des lignes inventaires
        If DSCompetByPer.Tables(0).Rows.Count > 0 Then
          For Each oRowsCont As DataRow In DSCompetByPer.Tables(0).Rows
            SaveLigneContratByPers(oRowsCont)
          Next
        End If

        LoadComptenceByPer(iNPERNUMSelected, sCPERTYP)

      End If

    Catch ex As Exception

      MessageBox.Show(ex.Message)

    End Try

  End Sub

  Private Sub SaveLigneContratByPers(ByVal oRowsSavTemp As DataRow)

    Try

      Dim sqlcmdCreateLigne As New SqlCommand("[api_sp_CreationContratByPers]", MozartDatabase.cnxMozart)
      sqlcmdCreateLigne.CommandType = CommandType.StoredProcedure
      sqlcmdCreateLigne.Parameters.Add("@P_NIDCOMPETENCEPER", SqlDbType.Int).Value = oRowsSavTemp.Item("NIDCOMPETENCEPER")
      sqlcmdCreateLigne.Parameters.Add("@P_NPERNUM", SqlDbType.Int).Value = iNPERNUMSelected
      sqlcmdCreateLigne.Parameters.Add("@p_NIDCOMPET", SqlDbType.Int).Value = oRowsSavTemp.Item("NIDCOMPET")
      sqlcmdCreateLigne.Parameters.Add("@P_COCHER", SqlDbType.Int).Value = oRowsSavTemp.Item("BAFFECTE")

      sqlcmdCreateLigne.ExecuteNonQuery()

    Catch ex As Exception
      MessageBox.Show(ex.Message)
    End Try

  End Sub

  Private Sub ResizeAllComponents()

    GrpBoxPers.Height = Me.Height - GrpBoxPers.Top - 200

    '   GrpBoxLstContrat.Width = Me.Width - GrpBoxLstContrat.Left - 15
    GrpBoxLstCompetence.Height = Me.Height - GrpBoxLstCompetence.Top - 200

  End Sub

  Private Sub frmGestCompetenceByPers_ResizeEnd(ByVal sender As Object, ByVal e As System.EventArgs) Handles Me.ResizeEnd, Me.SizeChanged

    ResizeAllComponents()

  End Sub

  Private Sub BtnParCompetence_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles BtnParCompetence.Click

    Dim oGestCompetPersbyCompetence As New frmGestCompetPersByCompet
    oGestCompetPersbyCompetence.ShowDialog()
    Me.Close()

  End Sub

  Private Sub BtnGestDomCompetence_Click(sender As System.Object, e As System.EventArgs) Handles BtnGestDomCompetence.Click

    Dim oFrmGestDomCompetence As New frmGestionDomaineCompetence()
    oFrmGestDomCompetence.ShowDialog()

    LoadComptenceByPer(iNPERNUMSelected, sCPERTYP)

  End Sub

  Private Sub BtnGestCompetence_Click(sender As System.Object, e As System.EventArgs) Handles BtnGestCompetence.Click

    Dim oFrmGestCompetencePer As New frmGestionCompetencePer()
    oFrmGestCompetencePer.ShowDialog()

    LoadComptenceByPer(iNPERNUMSelected, sCPERTYP)

  End Sub

End Class