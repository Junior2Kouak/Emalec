Imports System.Data.SqlClient
Imports DevExpress.XtraGrid.Views.Grid
Imports DevExpress.XtraGrid.Views.Grid.ViewInfo
Imports MozartLib

Public Class frmCauserieDetailResult

  Dim CnxQCMListeDet As New CGestionSQL

  Dim sQCMNOM As String
  Dim iNIDCQMNUM As Integer
  Dim iNIDQCMTYPE As Int16

  Dim iNIDFICQCMNUM As Int32
  Dim Nomtech As String
  Dim bReadOnly As Boolean

  Dim dt As DataTable

  'constructeur de la classe avec 2 paramtres
  Public Sub New(ByVal c_iNIDFICQCMNUM As Object, ByVal c_iNIDCQMNUM As Object, ByVal c_sQCMNOM As Object, ByVal c_NIDQCMTYPE As Object, ByVal c_Nomtech As Object, Optional ByVal c_ReadOnly As Object = False)
    InitializeComponent()
    iNIDCQMNUM = Convert.ToInt32(c_iNIDCQMNUM)
    sQCMNOM = c_sQCMNOM.ToString
    iNIDQCMTYPE = Convert.ToInt16(c_NIDQCMTYPE)
    Nomtech = c_Nomtech.ToString
    iNIDFICQCMNUM = Convert.ToInt32(c_iNIDFICQCMNUM)
    bReadOnly = c_ReadOnly

  End Sub

  Private Sub BtnFermer_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles BtnFermer.Click
    Me.Close()
  End Sub

  Private Sub frmCauserieDetailResult_FormClosing(ByVal sender As Object, ByVal e As System.Windows.Forms.FormClosingEventArgs) Handles Me.FormClosing
    CnxQCMListeDet.CloseConnexionSQL()
  End Sub

  Private Sub frmCauserieDetailResult_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load

    Try

      'init         
      Me.Text = "[" & sQCMNOM & "] - [" & Nomtech & "]"
      LblTitre.Text = "Causerie : " & sQCMNOM
      LblTech.Text = "Technicien : " & Nomtech

      If bReadOnly = True Then
        BtnSaveCorrect.Visible = False

      Else
        BtnSaveCorrect.Visible = True
      End If
      BtnCTRL.Visible = BtnSaveCorrect.Visible

      GColDetailVCORRECTCOM.OptionsColumn.ReadOnly = Not BtnSaveCorrect.Visible
      GColDetailVCORRECTCOM.OptionsColumn.AllowEdit = BtnSaveCorrect.Visible

      If CnxQCMListeDet.ConnexionSQL(MozartParams.NomServeur, MozartParams.NomSociete) = True Then

        'load des donnees
        LoadDataGridView()

      Else

        MessageBox.Show(My.Resources.Global_serveur_EMALEC, My.Resources.Global_Erreur, MessageBoxButtons.OK, MessageBoxIcon.Error)

      End If

    Catch ex As Exception

      MessageBox.Show(My.Resources.TestCompétance_frmCauserieDetailResult_Sub + ex.Message, My.Resources.Global_Erreur, MessageBoxButtons.OK, MessageBoxIcon.Error)

    End Try

  End Sub

  '*************************************************************************************************************************************
  'Cette sub permet de charger les 3 tables de la proc, on les load dans un dataset ou l on definit les relations entre les tables
  ' et permettre l affichage groupe
  '*************************************************************************************************************************************
  Private Sub LoadDataGridView()

    dt = New DataTable

    Dim cmdLoadList As New SqlCommand("api_sp_QCMDetailResult", CnxQCMListeDet.CnxSQLOpen)
    cmdLoadList.CommandType = CommandType.StoredProcedure
    'sqlcmd
    cmdLoadList.Parameters.Add("P_NIDFICQCMNUM", SqlDbType.Int)
    cmdLoadList.Parameters("P_NIDFICQCMNUM").Value = iNIDFICQCMNUM

    dt.Load(cmdLoadList.ExecuteReader)

    GCCauseDetail.DataSource = dt

    GVCauseDetail.ExpandAllGroups()

  End Sub

  Private Sub BtnEditRep_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles BtnEditRep.Click

    If iNIDFICQCMNUM > 0 Then

      Dim oDoc As New CGenDoc("Causerie_Fiche_Edition_Result", iNIDFICQCMNUM.ToString, iNIDCQMNUM)
      If oDoc.p_ERROR = "" Then
        Dim ofrmVisuFic As New frmVisuDoc(oDoc.p_PathFileName)
        ofrmVisuFic.ShowDialog()
      End If

    Else
      MessageBox.Show(My.Resources.TestCompétance_frmCauserieDetailResult_tech, My.Resources.Global_Erreur, MessageBoxButtons.OK, MessageBoxIcon.Error)
    End If

  End Sub

  Private Sub GVCauseDetail_CalcRowHeight(ByVal sender As Object, ByVal e As DevExpress.XtraGrid.Views.Grid.RowHeightEventArgs) Handles GVCauseDetail.CalcRowHeight

    If e.RowHandle >= 0 Then

      Dim view As GridView = CType(sender, GridView)

      'Dim text As String = view.GetRowCellDisplayText(e.RowHandle,  ColGridViewVQCMREPONSELIB)
      Dim text As String = view.GetRowCellValue(e.RowHandle, GColDetailVQCMREPONSELIB)

      Dim nbRetourChariot As Int16 = text.Count(Function(c As Char) c = vbLf) + 1

      e.RowHeight = e.RowHeight * (nbRetourChariot)

    End If
  End Sub

  Private Sub GVCauseDetail_CustomColumnDisplayText(ByVal sender As Object, ByVal e As DevExpress.XtraGrid.Views.Base.CustomColumnDisplayTextEventArgs) Handles GVCauseDetail.CustomColumnDisplayText
    If e.Column.FieldName = "VQCMQUESTIONLIB" Then
      'e.ListSourceRowIndex     
      Dim dtr As DataRow = sender.GetDataRow(e.ListSourceRowIndex)

      'e.DisplayText = String.Format("N° {0}. {1}", DSDetailQCM.Tables(1).Rows(e.RowHandle).Item("NQCMQUESTIONORDER").ToString, e.Value)
      e.DisplayText = String.Format("N° {0}. {1}", dtr.Item("NQCMQUESTIONORDER").ToString, e.Value)

    End If
  End Sub

  Private Sub GVCauseDetail_CustomDrawCell(sender As Object, e As DevExpress.XtraGrid.Views.Base.RowCellCustomDrawEventArgs) Handles GVCauseDetail.CustomDrawCell

    'hauteur de row


  End Sub

  Private Sub GVCauseDetail_CustomDrawGroupRow(ByVal sender As Object, ByVal e As DevExpress.XtraGrid.Views.Base.RowObjectCustomDrawEventArgs) Handles GVCauseDetail.CustomDrawGroupRow

    Dim groupRowInfo As GridGroupRowInfo = CType(e.Info, GridGroupRowInfo)
    Dim rowInfo As GridGroupRowInfo = TryCast(e.Info, GridGroupRowInfo)
    Dim painter As DevExpress.XtraGrid.Drawing.GridGroupRowPainter = TryCast(e.Painter, DevExpress.XtraGrid.Drawing.GridGroupRowPainter)

    rowInfo.GroupText = String.Empty
    painter.ElementsPainter.GroupRow.DrawGroupRowBackground(e.Info)
    painter.DrawObject(rowInfo)

    Dim groupText As String
    If iNIDQCMTYPE <> 2 Then
      groupText = String.Format(groupRowInfo.GroupValueText + " {0}", sender.GetGroupSummaryValue(e.RowHandle, sender.GroupSummary.Item(0)))
    Else
      groupText = groupRowInfo.GroupValueText
    End If
    Dim rect As System.Drawing.Rectangle = e.Bounds
    rect.X = rowInfo.ButtonBounds.Right + 5

    e.Appearance.DrawString(e.Cache, groupText, rect)

    e.Handled = True

  End Sub

  Private Sub SaveCorrect(ByVal p_oDtrCorrect As DataRow)

    Try

      Dim sqlcmd As New SqlCommand("api_sp_QCMSaveCorrection", CnxQCMListeDet.CnxSQLOpen)

      sqlcmd.CommandType = CommandType.StoredProcedure
      sqlcmd.Parameters.Add("@P_NIDREP", SqlDbType.Int)
      sqlcmd.Parameters("@P_NIDREP").Value = p_oDtrCorrect.Item("NIDREP")
      sqlcmd.Parameters.Add("@P_VTYPEREP", SqlDbType.VarChar)
      sqlcmd.Parameters("@P_VTYPEREP").Value = p_oDtrCorrect.Item("VTYPEREP")
      sqlcmd.Parameters.Add("@P_VCORRECTCOM", SqlDbType.VarChar)
      sqlcmd.Parameters("@P_VCORRECTCOM").Value = p_oDtrCorrect.Item("VCORRECTCOM")

      sqlcmd.ExecuteNonQuery()

    Catch ex As Exception

      MessageBox.Show(My.Resources.TestCompétance_frmCauserieDetailResult_Sub2 + ex.Message, My.Resources.Global_Erreur, MessageBoxButtons.OK, MessageBoxIcon.Error)

    End Try

  End Sub

  Private Sub BtnSaveCorrect_Click(sender As System.Object, e As System.EventArgs) Handles BtnSaveCorrect.Click

    Try

      If MessageBox.Show(My.Resources.Global_Enregistrer_Modif, My.Resources.Global_Enregistrer, MessageBoxButtons.YesNoCancel, MessageBoxIcon.Question) = Windows.Forms.DialogResult.Yes Then

        If Not dt Is Nothing AndAlso Not dt.GetChanges Is Nothing Then

          dt.AcceptChanges()
          'sauvegarde des lignes inventaires
          If dt.Rows.Count > 0 Then
            For Each oRowsCont As DataRow In dt.Rows
              SaveCorrect(oRowsCont)
            Next
          End If

        End If

        LoadDataGridView()

      End If

    Catch ex As Exception

      MessageBox.Show(ex.Message)

    End Try

  End Sub

  Private Sub BtnCTRL_Click(sender As System.Object, e As System.EventArgs) Handles BtnCTRL.Click

    'sauvegarde des modif
    'verification s il faut enregistrer
    If Not dt Is Nothing AndAlso Not dt.GetChanges Is Nothing Then

      Select Case MessageBox.Show(My.Resources.Global_Enregistrer_Modif, My.Resources.Global_modification, MessageBoxButtons.YesNoCancel, MessageBoxIcon.Question)

        Case Windows.Forms.DialogResult.Yes

          dt.AcceptChanges()
          'sauvegarde des lignes inventaires
          If dt.Rows.Count > 0 Then
            For Each oRowsCont As DataRow In dt.Rows
              SaveCorrect(oRowsCont)
            Next
          End If




      End Select

    End If

    If VerifQuestionSansCorrectionExists() = True Then

      MessageBox.Show(My.Resources.TestCompétance_frmCauserieDetailResult_validation, My.Resources.Global_erreur_validation, MessageBoxButtons.OK, MessageBoxIcon.Exclamation)

    Else

      Select Case MessageBox.Show(My.Resources.TestCompétance_frmCauserieDetailResult_msg, My.Resources.TestCompétance_frmCauserieDetailResult_envoi, MessageBoxButtons.YesNoCancel, MessageBoxIcon.Question)

        Case Windows.Forms.DialogResult.Yes

          'verification s il faut enregistrer
          If Not dt Is Nothing AndAlso Not dt.GetChanges Is Nothing Then

            dt.AcceptChanges()
            'sauvegarde des lignes inventaires
            If dt.Rows.Count > 0 Then
              For Each oRowsCont As DataRow In dt.Rows
                SaveCorrect(oRowsCont)
              Next
            End If

          End If

          Dim sqlupdate As New SqlCommand("api_sp_QCMValidationCorrection", CnxQCMListeDet.CnxSQLOpen)
          sqlupdate.CommandType = CommandType.StoredProcedure
          sqlupdate.Parameters.Add("@P_NIDFICQCMNUM", SqlDbType.Int)
          sqlupdate.Parameters("@P_NIDFICQCMNUM").Value = iNIDFICQCMNUM

          sqlupdate.ExecuteNonQuery()

      End Select

      LoadDataGridView()

    End If

  End Sub

  Private Function VerifQuestionSansCorrectionExists() As Boolean

    Dim bReponse As Boolean = True

    Try

      Dim sqlcmdVerif As New SqlCommand("api_sp_QCMVerifQuestionCorrection", CnxQCMListeDet.CnxSQLOpen)
      sqlcmdVerif.CommandType = CommandType.StoredProcedure
      sqlcmdVerif.Parameters.Add("@P_NIDFICQCMNUM", SqlDbType.Int)
      sqlcmdVerif.Parameters("@P_NIDFICQCMNUM").Value = iNIDFICQCMNUM
      Dim oDrverif As SqlDataReader = sqlcmdVerif.ExecuteReader

      If oDrverif.HasRows Then

        oDrverif.Read()
        If oDrverif.Item("NB_QUEST_WO_REP") > 0 Then
          bReponse = True
        Else
          bReponse = False
        End If
      Else
        bReponse = False
      End If
      oDrverif.Close()

      Return bReponse

    Catch ex As Exception

      MessageBox.Show(My.Resources.TestCompétance_frmCauserieDetailResult_erreurV & ex.Message)
      Return bReponse

    End Try

  End Function

End Class