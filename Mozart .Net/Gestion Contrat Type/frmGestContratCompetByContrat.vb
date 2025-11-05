Imports System.Data.SqlClient
Imports DevExpress.XtraGrid
Imports MozartLib

Public Class frmGestContratCompetByContrat

  Dim sqlConnectGestCompet As CGestionSQL

  Dim DSTechByCont As DataSet

  Dim iNTYPECONTRATSelected As Integer

  Private Sub frmGestContratCompetByContrat_FormClosed(ByVal sender As Object, ByVal e As System.Windows.Forms.FormClosedEventArgs) Handles Me.FormClosed

    sqlConnectGestCompet.CloseConnexionSQL()
    iNTYPECONTRATSelected = 0

  End Sub

  Private Sub frmGestContratCompetByContrat_FormClosing(ByVal sender As Object, ByVal e As System.Windows.Forms.FormClosingEventArgs) Handles Me.FormClosing
    ChangesDetected()
  End Sub

  Private Sub frmGestContratCompetByContrat_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load

    Try

      sqlConnectGestCompet = New CGestionSQL
      If sqlConnectGestCompet.ConnexionSQL(MozartParams.NomServeur, MozartParams.NomSociete) = True Then

        GCListContrat.DataSource = ModDataGridView.LoadList("api_sp_ListeContratActif", sqlConnectGestCompet.CnxSQLOpen)
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
        oApparenceConditionByServ.Column = GVListContrat.Columns("NSERNUM")
        oApparenceConditionByServ.Appearance.Options.UseBackColor = True
        oApparenceConditionByServ.Value1 = drColor("NSERNUM")
        oApparenceConditionByServ.Condition = FormatConditionEnum.Equal
        oApparenceConditionByServ.Appearance.BackColor = System.Drawing.ColorTranslator.FromHtml(drColor("VSERCOLOR").ToString)

        GVListContrat.FormatConditions.Add(oApparenceConditionByServ)

      End While


    End If

    drColor.Close()

  End Sub

  Private Sub BtnClose_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles BtnClose.Click

    Me.Close()

  End Sub

  Private Sub LoadTechByContrat(ByVal p_ntypecontrat As Integer)


    'MessageBox.Show(GCListContByDom)

    'gridView1.ChildGridLevelName = "NIDQCMQUESTION"
    DSTechByCont = New DataSet

    GCListTechByCont.ShowOnlyPredefinedDetails = True

    Dim cmdLoadList As New SqlCommand("api_sp_ListeTechByCont", sqlConnectGestCompet.CnxSQLOpen)
    cmdLoadList.CommandType = CommandType.StoredProcedure
    'sqlcmd
    cmdLoadList.Parameters.Add("p_ntypecontrat", SqlDbType.Int)
    cmdLoadList.Parameters("p_ntypecontrat").Value = p_ntypecontrat

    Dim dr1 As New DataTable

    dr1.Load(cmdLoadList.ExecuteReader)
    dr1.Columns("NCONTRATEXIST").ReadOnly = False

    DSTechByCont.Tables.Add(dr1)

    GCListTechByCont.DataSource = DSTechByCont.Tables(0)

  End Sub

  Private Sub GVListContrat_RowClick(ByVal sender As Object, ByVal e As DevExpress.XtraGrid.Views.Grid.RowClickEventArgs) Handles GVListContrat.RowClick

    Try

      ChangesDetected()

      Dim oDataRowTmp As DataRow = GVListContrat.GetDataRow(e.RowHandle)

      GrpBoxLstContrat.Text = String.Format(My.Resources.GestionContrat_type_frmGestContratCompetByContrat_tech, oDataRowTmp.Item("VTYPECONTRAT"))

      iNTYPECONTRATSelected = CType(oDataRowTmp.Item("NTYPECONTRAT"), Integer)

      LoadTechByContrat(iNTYPECONTRATSelected)

    Catch ex As Exception
      MessageBox.Show(ex.Message)
      iNTYPECONTRATSelected = 0
    End Try


  End Sub

  Private Function ChangesDetected() As DialogResult

    'on teste si il y eu des modifs questions non enregistrer.
    If Not DSTechByCont Is Nothing AndAlso Not DSTechByCont.Tables(0).GetChanges Is Nothing Then

      If DSTechByCont.Tables(0).GetChanges.Rows.Count > 0 Then

        Select Case MessageBox.Show(My.Resources.Global_Enregistrer_Modif, My.Resources.GestionContrat_type_frmGestContratCompetByContrat_mozart, MessageBoxButtons.YesNoCancel, MessageBoxIcon.Exclamation)

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

      If Not DSTechByCont Is Nothing AndAlso Not DSTechByCont.Tables(0).GetChanges Is Nothing Then

        DSTechByCont.Tables(0).AcceptChanges()
        'sauvegarde des lignes inventaires
        If DSTechByCont.Tables(0).Rows.Count > 0 Then
          For Each oRowsCont As DataRow In DSTechByCont.Tables(0).Rows
            SaveLigneContratByTech(oRowsCont)
          Next
        End If

        LoadTechByContrat(iNTYPECONTRATSelected)

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
      sqlcmdCreateLigne.Parameters("@p_npernum").Value = oRowsSavTemp.Item("NPERNUM")
      sqlcmdCreateLigne.Parameters.Add("@p_ntypecontrat", SqlDbType.Int)
      sqlcmdCreateLigne.Parameters("@p_ntypecontrat").Value = iNTYPECONTRATSelected
      sqlcmdCreateLigne.Parameters.Add("@p_cocher", SqlDbType.Int)
      sqlcmdCreateLigne.Parameters("@p_cocher").Value = oRowsSavTemp.Item("NCONTRATEXIST")

      sqlcmdCreateLigne.ExecuteNonQuery()

    Catch ex As Exception
      MessageBox.Show(ex.Message)
    End Try

  End Sub

  Private Sub ResizeAllComponents()

    GrpBoxContrats.Height = Me.Height - GrpBoxContrats.Top - 40

    '  GrpBoxLstContrat.Width = Me.Width - GrpBoxLstContrat.Left - 15
    GrpBoxLstContrat.Height = Me.Height - GrpBoxLstContrat.Top - 40

  End Sub

  Private Sub frmGestContratCompetByContrat_ResizeEnd(ByVal sender As Object, ByVal e As System.EventArgs) Handles Me.ResizeEnd, Me.SizeChanged

    ResizeAllComponents()

  End Sub

  Private Sub BtnParTech_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles BtnParTech.Click

    Dim oGestCompetbyTech As New frmGestContratCompetByTech
    oGestCompetbyTech.ShowDialog()
    Me.Close()

  End Sub

  Private Sub BtnExportXLS_Click(sender As Object, e As EventArgs) Handles BtnExportXLS.Click
    SFD.Filter = "Fichiers XLSX |*.XLSX"
    SFD.ShowDialog()

    If SFD.FileName <> "" Then
      GCListTechByCont.ExportToXlsx(SFD.FileName)
    End If
  End Sub
End Class