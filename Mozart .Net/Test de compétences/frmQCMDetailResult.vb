Imports System.Data.SqlClient
Imports DevExpress.XtraGrid.Views.Grid
Imports DevExpress.XtraGrid.Views.Grid.ViewInfo
Imports MozartLib

Public Class frmQCMDetailResult

  Dim CnxQCMListeDet As New CGestionSQL

  Dim sQCMNOM As String
  Dim iNIDCQMNUM As Integer
  Dim iNIDQCMTYPE As Int16

  Dim bCandidat As Boolean

  Dim iBonneReponse As Integer = 0
  Dim iNbReponse As Integer = 0

  Dim iNIDFICQCMNUM As Int32
  Dim Nomtech As String

  Dim dt As DataTable

  Dim iSizeTableau As New Size(1492, 683)
  Dim iSizeForm As New Size(1684, 832)

  'constructeur de la classe avec 2 paramtres
  Public Sub New(ByVal c_iNIDFICQCMNUM As Object, ByVal c_iNIDCQMNUM As Object, ByVal c_sQCMNOM As Object, ByVal c_NIDQCMTYPE As Object, ByVal c_Nomtech As Object, ByVal c_Candidat As Object)
    InitializeComponent()
    iNIDCQMNUM = Convert.ToInt32(c_iNIDCQMNUM)
    sQCMNOM = c_sQCMNOM.ToString
    iNIDQCMTYPE = Convert.ToInt16(c_NIDQCMTYPE)
    Nomtech = c_Nomtech.ToString
    iNIDFICQCMNUM = Convert.ToInt32(c_iNIDFICQCMNUM)
    bCandidat = Convert.ToBoolean(c_Candidat)

  End Sub

  Private Sub frmQCMDetailResult_FormClosing(ByVal sender As Object, ByVal e As System.Windows.Forms.FormClosingEventArgs) Handles Me.FormClosing
    CnxQCMListeDet.CloseConnexionSQL()
  End Sub

  Private Sub frmQCMDetailResult_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load

    Try

      'init   
      GestionAffichage()


      If CnxQCMListeDet.ConnexionSQL(MozartParams.NomServeur, MozartParams.NomSociete) = True Then

        'load des donnees
        LoadDataGridView()

      Else

        MessageBox.Show(My.Resources.Global_serveur_EMALEC, My.Resources.Global_Erreur, MessageBoxButtons.OK, MessageBoxIcon.Error)

      End If

      ResizeGrid()

    Catch ex As Exception

      MessageBox.Show(My.Resources.TestCompétance_QCMDetailResult_sub + ex.Message, My.Resources.Global_Erreur, MessageBoxButtons.OK, MessageBoxIcon.Error)

    End Try

  End Sub

  Private Sub GestionAffichage()

    'init   
    Me.Text = "[" & sQCMNOM & "] - [" & Nomtech & "]"
    LblTitre.Text = "QCM : " & sQCMNOM
    If bCandidat = True Then
      LblTech.Text = My.Resources.TestCompétance_QCMDetailResult_Candidat & Nomtech
      BtnSaveCorrect.Visible = False
      BtnCTRL.Visible = False
      GColDetailVCORRECTCOM.Visible = False

    Else
      LblTech.Text = My.Resources.TestCompétance_QCMDetailResult_Technicien & Nomtech
      BtnSaveCorrect.Visible = True
      BtnCTRL.Visible = True

    End If

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

    GCQCMDetail.DataSource = dt

    GVQCMDetail.ExpandAllGroups()

  End Sub

  Private Sub BtnEditRep_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles BtnEditRep.Click

    If iNIDFICQCMNUM > 0 Then

      Dim oDoc As New CGenDoc("QCM_Fiche_Edition_Result", iNIDFICQCMNUM.ToString, iNIDCQMNUM)
      If oDoc.p_ERROR = "" Then
        Dim ofrmVisuFic As New frmVisuDoc(oDoc.p_PathFileName)
        ofrmVisuFic.ShowDialog()
      End If

    Else
      MessageBox.Show(My.Resources.TestCompétance_QCMDetailResult_Technicien_quest, My.Resources.Global_Erreur, MessageBoxButtons.OK, MessageBoxIcon.Error)
    End If

  End Sub

  Private Sub BtnFermer_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles BtnFermer.Click
    Me.Close()
  End Sub

  Private Sub GVQCMDetail_CalcRowHeight(ByVal sender As Object, ByVal e As DevExpress.XtraGrid.Views.Grid.RowHeightEventArgs) Handles GVQCMDetail.CalcRowHeight

    If e.RowHandle >= 0 Then

      Dim view As GridView = CType(sender, GridView)

      'Dim text As String = view.GetRowCellDisplayText(e.RowHandle,  ColGridViewVQCMREPONSELIB)
      Dim text As String = view.GetRowCellValue(e.RowHandle, GColDetailVQCMREPONSELIB)

      Dim nbRetourChariot As Int16 = text.Count(Function(c As Char) c = vbLf) + 1

      e.RowHeight = e.RowHeight * (nbRetourChariot)

    End If

  End Sub

  Private Sub GVQCMDetail_CustomColumnDisplayText(ByVal sender As Object, ByVal e As DevExpress.XtraGrid.Views.Base.CustomColumnDisplayTextEventArgs) Handles GVQCMDetail.CustomColumnDisplayText
    If e.Column.FieldName = "VQCMQUESTIONLIB" Then
      'e.ListSourceRowIndex     
      Dim dtr As DataRow = sender.GetDataRow(e.ListSourceRowIndex)

      'e.DisplayText = String.Format("N° {0}. {1}", DSDetailQCM.Tables(1).Rows(e.RowHandle).Item("NQCMQUESTIONORDER").ToString, e.Value)
      e.DisplayText = String.Format("N° {0}. {1}", dtr.Item("NQCMQUESTIONORDER").ToString, e.Value)

    End If
  End Sub

  Private Sub GVQCMDetail_CustomDrawGroupRow(ByVal sender As Object, ByVal e As DevExpress.XtraGrid.Views.Base.RowObjectCustomDrawEventArgs) Handles GVQCMDetail.CustomDrawGroupRow

    If sender.GetGroupSummaryValue(e.RowHandle, sender.GroupSummary.Item(0)) = "Mauvaise Réponse" Then
      e.Appearance.BackColor = Color.LightPink
      e.Appearance.BackColor2 = Color.Red
    Else
      e.Appearance.BackColor = Color.LightGreen
      e.Appearance.BackColor2 = Color.Green
    End If

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

  Private Sub GVQCMDetail_CustomSummaryCalculate(ByVal sender As Object, ByVal e As DevExpress.Data.CustomSummaryEventArgs) Handles GVQCMDetail.CustomSummaryCalculate
    Dim View As GridView = CType(sender, GridView)

    If e.SummaryProcess = DevExpress.Data.CustomSummaryProcess.Calculate Then

      Dim test As DataRow = View.GetDataRow(e.RowHandle)

      If test.Item("BFICQCMREPTECH") = test.Item("BQCMREPONSEVALID") Then

        iBonneReponse = iBonneReponse + 1

      End If

      iNbReponse = iNbReponse + 1

    ElseIf e.SummaryProcess = DevExpress.Data.CustomSummaryProcess.Finalize Then

      If iBonneReponse = iNbReponse Then
        e.TotalValue = My.Resources.Global_Rép_Correcte
      Else
        e.TotalValue = My.Resources.Global_mauvaise_Rép
      End If

      iBonneReponse = 0
      iNbReponse = 0

    End If
  End Sub

  Private Sub SaveVisaDO(ByVal p_NIDFICQCMNUM As Int32, ByVal _p_NIDQCMQUESTION As Int32, ByVal p_DVISA_DO As Date)

    Try

      Dim sqlcmd As New SqlCommand("api_sp_QCMSaveVISA_DO", CnxQCMListeDet.CnxSQLOpen)

      sqlcmd.CommandType = CommandType.StoredProcedure
      sqlcmd.Parameters.Add("@P_NIDFICQCMNUM", SqlDbType.Int)
      sqlcmd.Parameters("@P_NIDFICQCMNUM").Value = p_NIDFICQCMNUM
      sqlcmd.Parameters.Add("@P_NIDQCMQUESTION", SqlDbType.Int)
      sqlcmd.Parameters("@P_NIDQCMQUESTION").Value = _p_NIDQCMQUESTION
      sqlcmd.Parameters.Add("@P_DVISA_DO", SqlDbType.DateTime)
      sqlcmd.Parameters("@P_DVISA_DO").Value = p_DVISA_DO

      sqlcmd.ExecuteNonQuery()

    Catch ex As Exception

      MessageBox.Show(My.Resources.TestCompétance_QCMDetailResult_sub2 + ex.Message, My.Resources.Global_Erreur, MessageBoxButtons.OK, MessageBoxIcon.Error)

    End Try

  End Sub

  Private Sub BtnSaveCorrect_Click(sender As System.Object, e As System.EventArgs) Handles BtnSaveCorrect.Click

    Try

      If MessageBox.Show(My.Resources.Global_Enregistrer_Modif, My.Resources.Global_Erreur, MessageBoxButtons.YesNoCancel, MessageBoxIcon.Question) = Windows.Forms.DialogResult.Yes Then

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

      MessageBox.Show(My.Resources.TestCompétance_QCMDetailResult_sub3 + ex.Message, My.Resources.Global_Erreur, MessageBoxButtons.OK, MessageBoxIcon.Error)

    End Try

  End Sub

  Private Sub BtnCTRL_Click(sender As System.Object, e As System.EventArgs) Handles BtnCTRL.Click

    'sauvegarde des modif
    'verification s il faut enregistrer
    If Not dt Is Nothing AndAlso Not dt.GetChanges Is Nothing Then

      Select Case MessageBox.Show(My.Resources.Global_Enregistrer_Modif, My.Resources.Global_Erreur, MessageBoxButtons.YesNoCancel, MessageBoxIcon.Question)

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

      MessageBox.Show(My.Resources.TestCompétance_QCMDetailResult_impossible_validation, My.Resources.Global_erreur_validation, MessageBoxButtons.OK, MessageBoxIcon.Exclamation)

    Else

      Select Case MessageBox.Show(My.Resources.TestCompétance_QCMDetailResult_send_to_author, My.Resources.TestCompétance_QCMDetailResult_validation_envoi, MessageBoxButtons.YesNoCancel, MessageBoxIcon.Question)

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

          'envoi d un mail contenat le resultat du qcm avec ses actions correctives
          'seulement pour une personne du siege
          Dim sqlSendCorrection As New SqlCommand("[api_sp_SendMail_QCM_Correction_To_Siege]", CnxQCMListeDet.CnxSQLOpen)
          sqlSendCorrection.CommandType = CommandType.StoredProcedure
          sqlSendCorrection.Parameters.Add("@P_NIDFICQCMNUM", SqlDbType.Int)
          sqlSendCorrection.Parameters("@P_NIDFICQCMNUM").Value = iNIDFICQCMNUM

          sqlSendCorrection.ExecuteNonQuery()

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

      MessageBox.Show(My.Resources.TestCompétance_QCMDetailResult_erreur & ex.Message)
      Return bReponse

    End Try

  End Function

  Private Sub frmQCMDetailResult_ResizeEnd(sender As Object, e As System.EventArgs) Handles Me.ResizeEnd

    'ResizeGrid

  End Sub

  Private Sub ResizeGrid()

    If Me.Size.Width < iSizeForm.Width Or Me.Size.Height < iSizeForm.Height Then

      GCQCMDetail.Size = New Size(((Me.Size.Width / iSizeForm.Width) * iSizeTableau.Width) - 100, ((Me.Size.Height / iSizeForm.Height) * iSizeTableau.Height) - 100)

    Else

      GCQCMDetail.Size = New Size(iSizeTableau)

    End If

  End Sub

  Private Sub frmQCMDetailResult_SizeChanged(sender As Object, e As System.EventArgs) Handles Me.SizeChanged
    ResizeGrid()
  End Sub

  Private Sub BtnAppliqCorrectAuto_Click(sender As Object, e As EventArgs) Handles BtnAppliqCorrectAuto.Click

    Select Case MessageBox.Show("Voulez-vous appliquer la correction automatique ?", "Correction automatique", MessageBoxButtons.YesNoCancel, MessageBoxIcon.Question)

      Case Windows.Forms.DialogResult.Yes

        'on parcours chaque rows
        For Each drow As DataRow In dt.Rows

          'type réponse
          If drow.Item("VTYPEREP") = "REP" Then

            drow.Item("VCORRECTCOM") = GetReponseCorrectebyNIDFICQCMREP(drow.Item("NIDREP"))

          End If

        Next



    End Select
  End Sub

  Private Function GetReponseCorrectebyNIDFICQCMREP(ByVal p_NIDFICQCMREP As Int32) As String

    Dim sReturn As String = ""

    Dim sqlcmdGet As New SqlCommand("[api_sp_QCMGetObsCorrection]", MozartDatabase.cnxMozart)
    sqlcmdGet.CommandType = CommandType.StoredProcedure
    sqlcmdGet.Parameters.Add("@P_NIDFICQCMREP", SqlDbType.Int).Value = p_NIDFICQCMREP
    Dim sqldrGet As SqlDataReader = sqlcmdGet.ExecuteReader

    If sqldrGet.HasRows Then
      sqldrGet.Read()
      sReturn = sqldrGet.Item("VQCMREPONSEOBSCORRECT")

    End If

    sqldrGet.Close()

    Return sReturn

  End Function

End Class