Imports System.Data.SqlClient
Imports DevExpress.XtraGrid
Imports MozartLib

Public Class frmGestContratCompetByTech

  Dim sqlConnectGestCompet As CGestionSQL

  Dim DSContratByTech As DataSet

  Dim iNPERNUMSelected As Integer

  Private Sub frmGestContratCompetByTech_FormClosed(ByVal sender As Object, ByVal e As System.Windows.Forms.FormClosedEventArgs) Handles Me.FormClosed

    sqlConnectGestCompet.CloseConnexionSQL()
    iNPERNUMSelected = 0

  End Sub

  Private Sub frmGestContratCompetByTech_FormClosing(ByVal sender As Object, ByVal e As System.Windows.Forms.FormClosingEventArgs) Handles Me.FormClosing
    ChangesDetected()
  End Sub

  Private Sub frmGestContratCompetByTech_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load

    Try

      sqlConnectGestCompet = New CGestionSQL
      If sqlConnectGestCompet.ConnexionSQL(MozartParams.NomServeur, MozartParams.NomSociete) = True Then


        GCListTech.DataSource = ModDataGridView.LoadList("api_sp_ListeTechniciensActifs", sqlConnectGestCompet.CnxSQLOpen)
        'remplissage du combo list
        'FormatConditionsColorByService

      End If

      ResizeAllComponents()

    Catch ex As Exception

      MessageBox.Show(ex.Message)

    End Try

  End Sub

  Private Sub FormatConditionsColorByService()

    Dim sqlcmdLoadColor As New SqlCommand("SELECT NSERNUM, VSERCOLOR FROM TSER", sqlConnectGestCompet.CnxSQLOpen)
    Dim drColor As SqlDataReader = sqlcmdLoadColor.ExecuteReader

    Dim oApparenceConditionByServ As StyleFormatCondition

    If drColor.HasRows Then

      While drColor.Read

        oApparenceConditionByServ = New StyleFormatCondition
        oApparenceConditionByServ.ApplyToRow = True
        oApparenceConditionByServ.Column = GVListTech.Columns("NSERNUM")
        oApparenceConditionByServ.Appearance.Options.UseBackColor = True
        oApparenceConditionByServ.Value1 = drColor("NSERNUM")
        oApparenceConditionByServ.Condition = FormatConditionEnum.Equal
        oApparenceConditionByServ.Appearance.BackColor = System.Drawing.ColorTranslator.FromHtml(drColor("VSERCOLOR").ToString)

        GVListTech.FormatConditions.Add(oApparenceConditionByServ)

      End While


    End If

    drColor.Close()

  End Sub

  Private Sub BtnClose_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles BtnClose.Click

    Me.Close()

  End Sub

  Private Sub LoadContratsByTech(ByVal p_npernum As Integer)


    'MessageBox.Show(GCListContByDom)

    'gridView1.ChildGridLevelName = "NIDQCMQUESTION"
    DSContratByTech = New DataSet

    GCListContByDom.ShowOnlyPredefinedDetails = True

    Dim cmdLoadList As New SqlCommand("api_sp_ListeContratByTech", sqlConnectGestCompet.CnxSQLOpen)
    cmdLoadList.CommandType = CommandType.StoredProcedure
    'sqlcmd
    cmdLoadList.Parameters.Add("npernum", SqlDbType.Int)
    cmdLoadList.Parameters("npernum").Value = p_npernum

    Dim dr1 As New DataTable

    dr1.Load(cmdLoadList.ExecuteReader)
    dr1.Columns("NCONTRATEXIST").ReadOnly = False

    DSContratByTech.Tables.Add(dr1)

    GCListContByDom.DataSource = DSContratByTech.Tables(0)
    GVDomaines.Columns.Item(3).Width = 500
    GVDomaines.Columns.Item(2).Width = 500

  End Sub

  Private Sub GVListTech_RowClick(ByVal sender As Object, ByVal e As DevExpress.XtraGrid.Views.Grid.RowClickEventArgs) Handles GVListTech.RowClick

    Try

      ChangesDetected()

      Dim oDataRowTmp As DataRow = GVListTech.GetDataRow(e.RowHandle)

      GrpBoxLstContrat.Text = String.Format(My.Resources.GestionContrat_type_frmGestContratCompetByTech_tech, oDataRowTmp.Item("TECH"))

      iNPERNUMSelected = CType(oDataRowTmp.Item("NPERNUM"), Integer)

      LoadContratsByTech(iNPERNUMSelected)

    Catch ex As Exception
      MessageBox.Show(ex.Message)
      iNPERNUMSelected = 0
    End Try


  End Sub

  Private Function ChangesDetected() As DialogResult

    'on teste si il y eu des modifs questions non enregistrer.
    If Not DSContratByTech Is Nothing AndAlso Not DSContratByTech.Tables(0).GetChanges Is Nothing Then

      If DSContratByTech.Tables(0).GetChanges.Rows.Count > 0 Then

        Select Case MessageBox.Show(My.Resources.Global_Enregistrer_Modif, My.Resources.GestionContrat_type_frmGestContratCompetByTech_mozart, MessageBoxButtons.YesNoCancel, MessageBoxIcon.Exclamation)

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

      If Not DSContratByTech Is Nothing AndAlso Not DSContratByTech.Tables(0).GetChanges Is Nothing Then

        DSContratByTech.Tables(0).AcceptChanges()
        'sauvegarde des lignes inventaires
        If DSContratByTech.Tables(0).Rows.Count > 0 Then
          For Each oRowsCont As DataRow In DSContratByTech.Tables(0).Rows
            SaveLigneContratByTech(oRowsCont)
          Next
        End If

        LoadContratsByTech(iNPERNUMSelected)

      End If

    Catch ex As Exception

      MessageBox.Show(ex.Message)

    End Try

  End Sub

  Private Sub SaveLigneContratByTech(ByVal oRowsSavTemp As DataRow)

    Try

      Dim sqlcmdCreateLigne As New SqlCommand("api_sp_CreationContratByTech", sqlConnectGestCompet.CnxSQLOpen)
      sqlcmdCreateLigne.CommandType = CommandType.StoredProcedure
      sqlcmdCreateLigne.Parameters.Add("@p_npernum", SqlDbType.Int)
      sqlcmdCreateLigne.Parameters("@p_npernum").Value = iNPERNUMSelected
      sqlcmdCreateLigne.Parameters.Add("@p_ntypecontrat", SqlDbType.Int)
      sqlcmdCreateLigne.Parameters("@p_ntypecontrat").Value = oRowsSavTemp.Item("NTYPECONTRAT")
      sqlcmdCreateLigne.Parameters.Add("@p_cocher", SqlDbType.Int)
      sqlcmdCreateLigne.Parameters("@p_cocher").Value = oRowsSavTemp.Item("NCONTRATEXIST")

      sqlcmdCreateLigne.ExecuteNonQuery()

    Catch ex As Exception
      MessageBox.Show(ex.Message)
    End Try

  End Sub

  Private Sub ResizeAllComponents()

    GrpBoxTechs.Height = Me.Height - GrpBoxTechs.Top - 200

    '   GrpBoxLstContrat.Width = Me.Width - GrpBoxLstContrat.Left - 15
    GrpBoxLstContrat.Height = Me.Height - GrpBoxLstContrat.Top - 200

  End Sub

  Private Sub frmGestContratCompetByTech_ResizeEnd(ByVal sender As Object, ByVal e As System.EventArgs) Handles Me.ResizeEnd, Me.SizeChanged

    ResizeAllComponents()

  End Sub

  Private Sub BtnParContrat_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles BtnParContrat.Click

    Dim oGestCompetbyContrat As New frmGestContratCompetByContrat
    oGestCompetbyContrat.ShowDialog()
    Me.Close()
  End Sub

  Private Sub BtnGestModif_Click(sender As System.Object, e As System.EventArgs) Handles BtnGestModif.Click

    Dim oFrmHisto As New frmGestModifContrat_Histo()
    oFrmHisto.ShowDialog()

  End Sub

  Private Sub BtnExportXLS_Click(sender As Object, e As EventArgs) Handles BtnExportXLS.Click
    SFD.Filter = "Fichiers XLSX |*.XLSX"
    SFD.ShowDialog()

    If SFD.FileName <> "" Then
      GCListContByDom.ExportToXlsx(SFD.FileName)
    End If
  End Sub
End Class