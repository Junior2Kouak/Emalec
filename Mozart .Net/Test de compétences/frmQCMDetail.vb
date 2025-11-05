Imports DevExpress.XtraTreeList
Imports DevExpress.XtraTreeList.Nodes
Imports MozartLib
Imports System.Data.SqlClient

Public Class frmQCMDetail

  Dim bIsLoading As Boolean

  Dim oCnxQCMDet As New CGestionSQL

  Dim iIdQCM As Integer
  Dim sQCMTitre As String
  Dim iNQCMTypeId As Int16

  Dim sVQCMCONSIGNE As String = ""
  Dim bQCMCORRECTAUTO As Boolean = False
  Dim bVideoExists As Boolean = False

  Dim NbQuestions As Integer = 0
  Dim IdQuestOrderSelected As Integer = 0

  Dim oNodeSelected As TreeListNode

  Dim DtQuestion As DataTable
  Dim DtReponse As New DataTable

  Dim FormReadOnly As Boolean

  Dim oListMsg As CQCMListeMsg

  Public Property iIdQCMParam As Integer
    Get
      Return iIdQCM
    End Get
    Set(ByVal value As Integer)
      If iIdQCM = value Then
        Return
      End If
      iIdQCM = value
    End Set
  End Property

  Public Property bReadOnly As Boolean
    Get
      Return FormReadOnly
    End Get
    Set(ByVal value As Boolean)
      If FormReadOnly = value Then
        Return
      End If
      FormReadOnly = value
    End Set
  End Property

  Public Property sSQMTitreParam As String
    Get
      Return sQCMTitre
    End Get
    Set(ByVal value As String)
      If sQCMTitre = value Then
        Return
      End If
      sQCMTitre = value
    End Set
  End Property

  Public Property p_iNQCMTypeId As Integer
    Get
      Return iNQCMTypeId
    End Get
    Set(ByVal value As Integer)
      If iNQCMTypeId = value Then
        Return
      End If
      iNQCMTypeId = value
    End Set
  End Property

  Public Property VQCMCONSIGNE As String
    Get
      Return sVQCMCONSIGNE
    End Get
    Set(ByVal value As String)
      If sVQCMCONSIGNE = value Then
        Return
      End If
      sVQCMCONSIGNE = value
    End Set
  End Property


  Public Property QCMCORRECTAUTO As Boolean
    Get
      Return bQCMCORRECTAUTO
    End Get
    Set(ByVal value As Boolean)
      If bQCMCORRECTAUTO = value Then
        Return
      End If
      bQCMCORRECTAUTO = value
    End Set
  End Property

  Private Sub frmQCMDetail_FormClosed(ByVal sender As Object, ByVal e As System.Windows.Forms.FormClosedEventArgs) Handles Me.FormClosed
    oCnxQCMDet.CloseConnexionSQL()
    Me.Dispose()
  End Sub

  Private Sub frmQCMDetail_FormClosing(ByVal sender As Object, ByVal e As System.Windows.Forms.FormClosingEventArgs) Handles Me.FormClosing

    'on teste si il y eu des modifs questions non enregistrer.
    If Not DtQuestion.GetChanges Is Nothing Then

      If DtQuestion.GetChanges.Rows.Count > 0 Then

        Select Case MessageBox.Show(My.Resources.TestCompétance_QCMDetail_save_questionnaire, My.Resources.TestCompétance_QCMDetail_mozart, MessageBoxButtons.YesNoCancel, MessageBoxIcon.Exclamation)

          Case vbYes
            BtnSaveQuestion.PerformClick()
            Me.Close()
          Case vbCancel
            e.Cancel = True
          Case Else
            e.Cancel = False

        End Select

      End If

    End If

    'on teste si il y eu des modifs réponses non enregistrer.
    If Not DtReponse.GetChanges Is Nothing Then

      If DtReponse.GetChanges.Rows.Count > 0 Then

        Select Case MessageBox.Show(My.Resources.TestCompétance_QCMDetail_save_questionnaire_rep, My.Resources.TestCompétance_QCMDetail_mozart, MessageBoxButtons.YesNoCancel, MessageBoxIcon.Exclamation)

          Case vbYes
            BtnSaveRep.PerformClick()
            Me.Close()
          Case vbCancel
            e.Cancel = True
          Case Else
            e.Cancel = False

        End Select

      End If

    End If

  End Sub

  Private Sub frmQCMDetail_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load

    bIsLoading = True

    Try

      'gestion des messages par type de qcm
      oListMsg = New CQCMListeMsg(iNQCMTypeId)

      LblNomQCM.Text = oListMsg.ReturnMsg(46) + sQCMTitre

      Me.Text = oListMsg.ReturnMsg(47)

      ChkQCMCorrectAuto.Checked = bQCMCORRECTAUTO

      If sVQCMCONSIGNE = "" Then
        BtnConsigne.BackColor = DefaultBackColor
      Else
        BtnConsigne.BackColor = Color.Yellow
      End If

      'on ouvre la connexion
      If oCnxQCMDet.ConnexionSQL(MozartParams.NomServeur, MozartParams.NomSociete) = True Then

        'on charge la liste
        CboTypeQCM.DataSource = ModDataGridView.LoadList("SELECT NQCMTYPEID, VQCMTYPELIB FROM TQCMTYPE ORDER BY VQCMTYPELIB ", oCnxQCMDet.CnxSQLOpen)

        'on charge les columns de la gridreponse 
        DGVReponse.AutoGenerateColumns = False

        'tree
        DtQuestion = New DataTable()

        Dim drsql As SqlDataReader = oCnxQCMDet.CreateSQLDataReader("EXEC api_sp_QCMListeTree " + iIdQCM.ToString)

        DtQuestion.Load(drsql)

        drsql.Close()

        bVideoExists = If(ModuleData.ExecuteScalarInt("SELECT COUNT(*) FROM TQCM_VIDEO WHERE NIDQCMNUM = " + iIdQCM.ToString + " AND ISNULL(VURL_VIDEO, '') <> ''") > 0, True, False)
        BtnVideo.BackColor = If(bVideoExists = True, Color.Yellow, DefaultBackColor)

        AppendNodes(Nothing)
        treeList1.ExpandAll()

        'gestion des modification
        If FormReadOnly = True Then

          BtnSaveQuestion.Visible = False
          BtnNewQuestion.Visible = False
          BtnArchiveQuestion.Visible = False
          BtnRestaureQuestion.Visible = False
          ChkListQuestArchives.Visible = False

          BtnSaveRep.Visible = False
          BtnAjoutRep.Visible = False
          BtnModif.Visible = False
          BtnArchRep.Visible = False
          btnRestoreRep.Visible = False
          ChkListRepArchives.Visible = False

          DGVReponse.ReadOnly = True
          ChkRemarque.Enabled = False
          ChkBoxQCMRecru.Enabled = False

        Else

          GrpBoxQuestion.Text = My.Resources.TestCompétance_QCMDetail_liste

        End If

        'on affiche la data QCM recru
        Dim drQCMRecru As SqlDataReader = oCnxQCMDet.CreateSQLDataReader("SELECT ISNULL(BQCMRECRU, 0)  AS BQCMRECRU, ISNULL(TQCM.NQCMTYPEID, 0) AS NQCMTYPEID FROM TQCM WITH (NOLOCK) WHERE TQCM.NIDQCMNUM = " + iIdQCM.ToString)

        If drQCMRecru.HasRows = True Then

          drQCMRecru.Read()

          ChkBoxQCMRecru.Checked = drQCMRecru.Item("BQCMRECRU")
          CboTypeQCM.SelectedValue = drQCMRecru.Item("NQCMTYPEID")

        End If
        drQCMRecru.Close()

        'gestion pour le cas dun qcm causerie secu
        'If iNQCMTypeId = 2 then

        '    BQCMREPONSEVALID.Visible = False

        'End If

      End If

    Catch ex As Exception

      MessageBox.Show(My.Resources.TestCompétance_QCMDetail_sub + ex.Message, My.Resources.Global_Erreur)

    End Try

    bIsLoading = False

  End Sub

  Private Sub AppendNodes(ByVal aNode As TreeListNode)

    Dim currentCursor As Cursor = Windows.Forms.Cursor.Current
    Windows.Forms.Cursor.Current = Cursors.WaitCursor

    Dim bAfficheQuestionActif As Boolean

    Dim node As TreeListNode

    treeList1.BeginUnboundLoad()

    'INIT
    NbQuestions = 0

    If aNode Is Nothing Then

      node = treeList1.AppendNode(New Object() {sQCMTitre, "", "", "", "", "", "", ""}, aNode)
      node.ImageIndex = 0
      node.SelectImageIndex = 0
      node.HasChildren = True

    Else

      aNode.Nodes.Clear()

      'sAfficheQuestionActif =
      If FormReadOnly = False Then
        bAfficheQuestionActif = Not (ChkListQuestArchives.Checked)
      Else
        bAfficheQuestionActif = False
      End If

      For Each RowDTQuestion As DataRow In DtQuestion.Select("BQCMQUESTIONACTIF = " + bAfficheQuestionActif.ToString)

        node = treeList1.AppendNode(New Object() {"", RowDTQuestion.Item("NIDQCMQUESTION"), RowDTQuestion.Item("NQCMQUESTIONORDER"), RowDTQuestion.Item("VQCMQUESTIONLIB"), RowDTQuestion.Item("NIMG_NB"), RowDTQuestion.Item("BQCMQUESTIONACTIF"), RowDTQuestion.Item("ID"), RowDTQuestion.Item("BQCMQUESTIONREM")}, aNode)

        If RowDTQuestion.Item("BQCMQUESTIONACTIF") = 0 Then
          node.ImageIndex = 1
          node.SelectImageIndex = 1
        Else
          node.ImageIndex = 1
          node.SelectImageIndex = 1
        End If

        node.Tag = True
        NbQuestions = NbQuestions + 1

      Next

    End If
    treeList1.EndUnboundLoad()

    Windows.Forms.Cursor.Current = currentCursor
  End Sub

  Private Sub BtnFermer_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles BtnFermer.Click
    Me.Close()
  End Sub

  Private Sub treeList1_BeforeExpand(ByVal sender As Object, ByVal e As DevExpress.XtraTreeList.BeforeExpandEventArgs) Handles treeList1.BeforeExpand
    AppendNodes(e.Node)
  End Sub

  Private Sub treeList1_BeforeFocusNode(ByVal sender As Object, ByVal e As DevExpress.XtraTreeList.BeforeFocusNodeEventArgs) Handles treeList1.BeforeFocusNode

    If e.Node.Id <= 0 Then oNodeSelected = Nothing

  End Sub

  Private Sub treeList1_CellValueChanged(ByVal sender As Object, ByVal e As DevExpress.XtraTreeList.CellValueChangedEventArgs) Handles treeList1.CellValueChanged

    If e.Column.FieldName = "VQCMQUESTIONLIB" And e.Node.Id <> 0 Then

      Dim DataRowEdit() As DataRow = DtQuestion.Select("ID=" + e.Node.Item("ID").ToString)

      If DataRowEdit.Count = 1 Then
        DtQuestion.Rows(DtQuestion.Rows.IndexOf(DataRowEdit(0))).Item("VQCMQUESTIONLIB") = e.Node.Item("VQCMQUESTIONLIB").ToString
      Else
        MessageBox.Show(My.Resources.TestCompétance_QCMDetail_clé_prim, My.Resources.TestCompétance_QCMDetail_clé_prim_erreur, MessageBoxButtons.OK, MessageBoxIcon.Error)
      End If

    End If


  End Sub

  Private Sub treeList1_DoubleClick(ByVal sender As Object, ByVal e As System.EventArgs) Handles treeList1.DoubleClick

    If Not oNodeSelected Is Nothing Then

      If oNodeSelected.Id > 0 Then

        'on teste si la question est modifiable
        If (oNodeSelected.Item("NIDQCMQUESTION") = 0 Or QuestionIsEditable(oNodeSelected.Item("NIDQCMQUESTION")) = True) And FormReadOnly = False Then
          treeList1.OptionsBehavior.Editable = True
          treeList1.Columns("VQCMTITRE").OptionsColumn.AllowEdit = False
          treeList1.Columns("NIDQCMQUESTION").OptionsColumn.AllowEdit = False
          treeList1.Columns("NQCMQUESTIONORDER").OptionsColumn.AllowEdit = False
          treeList1.Columns("NQCMQUESTIONORDER").OptionsColumn.ReadOnly = True
          treeList1.Columns("VQCMQUESTIONLIB").OptionsColumn.AllowEdit = True
          treeList1.Columns("VQCMQUESTIONLIB").OptionsColumn.ReadOnly = False
          treeList1.Columns("BQCMQUESTIONACTIF").OptionsColumn.AllowEdit = False
          treeList1.Columns("ID").OptionsColumn.AllowEdit = False

          Dim FrmModQuestion As New frmQCMNewQuestion
          FrmModQuestion.p_sLibQuestion = oNodeSelected.Item("VQCMQUESTIONLIB").ToString
          FrmModQuestion.ShowDialog()
          oNodeSelected.Item("VQCMQUESTIONLIB") = FrmModQuestion.p_sLibQuestion

          Dim DataRowEdit() As DataRow = DtQuestion.Select("ID=" + oNodeSelected.Item("ID").ToString)

          If DataRowEdit.Count = 1 Then
            DtQuestion.Rows(DtQuestion.Rows.IndexOf(DataRowEdit(0))).Item("VQCMQUESTIONLIB") = oNodeSelected.Item("VQCMQUESTIONLIB").ToString
          Else
            MessageBox.Show(My.Resources.TestCompétance_QCMDetail_clé_prim, My.Resources.TestCompétance_QCMDetail_clé_prim_erreur, MessageBoxButtons.OK, MessageBoxIcon.Error)
          End If

          'MsgBox(treeList1.Nodes(0).Item(0).ToString)
          'treeList1.RefreshCell(oNodeSelected,oNodeSelected.Item("VQCMQUESTIONLIB")) 

          'MsgBox(treeList1.Nodes(0).Nodes(oNodeSelected.Id - 1).Item("VQCMQUESTIONLIB").ToString)
          'treeList1. = FrmModQuestion.p_sLibQuestion

        Else
          treeList1.OptionsBehavior.Editable = False
          treeList1.Columns("VQCMTITRE").OptionsColumn.AllowEdit = False
          treeList1.Columns("NIDQCMQUESTION").OptionsColumn.AllowEdit = False
          treeList1.Columns("NQCMQUESTIONORDER").OptionsColumn.AllowEdit = False
          treeList1.Columns("NQCMQUESTIONORDER").OptionsColumn.ReadOnly = True
          treeList1.Columns("VQCMQUESTIONLIB").OptionsColumn.AllowEdit = False
          treeList1.Columns("VQCMQUESTIONLIB").OptionsColumn.ReadOnly = True
          treeList1.Columns("BQCMQUESTIONACTIF").OptionsColumn.AllowEdit = False
          treeList1.Columns("ID").OptionsColumn.AllowEdit = False
        End If

      End If

    End If

  End Sub

  Private Sub treeList1_FocusedNodeChanged(ByVal sender As System.Object, ByVal e As DevExpress.XtraTreeList.FocusedNodeChangedEventArgs) Handles treeList1.FocusedNodeChanged

    'init                
    GrpReponseLibre.Visible = False

    If Not e.Node Is Nothing Then

      If e.Node.Id > 0 Then

        'en tete de la treelist
        If e.Node.Item(1).ToString <> "" Then

          If iNQCMTypeId = 2 Then
            GrpReponseLibre.Visible = True
          End If


          If (Not IsDBNull(e.Node.Item("NIMG_NB")) AndAlso e.Node.Item("NIMG_NB") > 0) Then
            BtnAddImage.BackColor = Color.Yellow
          Else
            BtnAddImage.BackColor = DefaultBackColor
          End If




          treeList1.OptionsBehavior.Editable = False
          treeList1.Columns("VQCMTITRE").OptionsColumn.AllowEdit = False
          treeList1.Columns("NIDQCMQUESTION").OptionsColumn.AllowEdit = False
          treeList1.Columns("NQCMQUESTIONORDER").OptionsColumn.AllowEdit = False
          treeList1.Columns("NQCMQUESTIONORDER").OptionsColumn.ReadOnly = True
          treeList1.Columns("VQCMQUESTIONLIB").OptionsColumn.AllowEdit = False
          treeList1.Columns("VQCMQUESTIONLIB").OptionsColumn.ReadOnly = True
          treeList1.Columns("BQCMQUESTIONACTIF").OptionsColumn.AllowEdit = False
          treeList1.Columns("ID").OptionsColumn.AllowEdit = False

          'on teste si il y eu des modifs réponses non enregistrer.
          If Not DtReponse.GetChanges Is Nothing Then

            If DtReponse.GetChanges.Rows.Count > 0 Then

              Select Case MessageBox.Show(My.Resources.TestCompétance_QCMDetail_mozart_save, My.Resources.TestCompétance_QCMDetail_mozart_quiz, MessageBoxButtons.YesNoCancel, MessageBoxIcon.Exclamation)

                Case vbYes
                  BtnSaveRep.PerformClick()

              End Select

            End If

          End If

          'on charge les réponses selon question
          DtReponse = New DataTable
          DtReponse = ModDataGridView.LoadList("EXEC api_sp_QCMListeTreeRep " + e.Node.Item(1).ToString, oCnxQCMDet.CnxSQLOpen)

          If Not DtReponse Is Nothing Then DtReponse.Columns("VQCMREPONSEOBSCORRECT").ReadOnly = False

          oNodeSelected = e.Node

          'ici on charge si la question contient une zone de remarque
          ChkRemarque.Checked = e.Node.Item(6)

          'affichages des données dans un dataview
          If FormReadOnly = False Then
            DGVReponse.DataSource = LoadDataView(DtReponse, Not (ChkListRepArchives.Checked))
          Else
            DGVReponse.DataSource = LoadDataView(DtReponse, Not (FormReadOnly))
          End If


        End If
      Else

        BtnAddImage.BackColor = DefaultBackColor
      End If

    Else

      DGVReponse.DataSource = Nothing
      oNodeSelected = Nothing
      BtnAddImage.BackColor = DefaultBackColor

    End If

  End Sub

  '****************************************************************************************************
  'cette fonction permet de tester si la question doit affiche une zone de remarque
  '****************************************************************************************************
  Private Function ZoneRemInQuestion(ByVal NIDQCMQUESTION As Integer) As Boolean

    Try

      Dim sqlcmd As New SqlCommand("api_sp_QCMTestQuestionRemarque", oCnxQCMDet.CnxSQLOpen)

      sqlcmd.CommandType = CommandType.StoredProcedure

      sqlcmd.Parameters.Add("@p_nidqcmquestion", SqlDbType.Int)
      sqlcmd.Parameters("@p_nidqcmquestion").Value = NIDQCMQUESTION

      Dim drEdit As SqlDataReader = sqlcmd.ExecuteReader
      Dim bZone As Boolean = False

      drEdit.Read()

      If drEdit(0) > 0 Then
        bZone = True
      Else
        bZone = False
      End If

      drEdit.Close()

      Return bZone

    Catch ex As Exception

      MessageBox.Show(My.Resources.TestCompétance_QCMDetail_sub2 + ex.Message, My.Resources.Global_Erreur)
      Return False

    End Try

  End Function

  '****************************************************************************************************
  'cette fonction permet de tester si la question a été utilisé, non = modifiable si oui = non modificable (pour l'historique du questionnaire)
  '****************************************************************************************************
  Private Function QuestionIsEditable(ByVal NIDQCMQUESTION As Integer) As Boolean

    Try

      Dim sqlcmd As New SqlCommand("api_sp_QCMTestQuestionEditable", oCnxQCMDet.CnxSQLOpen)

      sqlcmd.CommandType = CommandType.StoredProcedure

      sqlcmd.Parameters.Add("@p_nidqcmquestion", SqlDbType.Int)
      sqlcmd.Parameters("@p_nidqcmquestion").Value = NIDQCMQUESTION

      Dim drEdit As SqlDataReader = sqlcmd.ExecuteReader
      Dim bEditable As Boolean = False

      drEdit.Read()

      If drEdit(0) = 0 Then
        bEditable = True
      Else
        bEditable = False
      End If

      drEdit.Close()

      Return bEditable

    Catch ex As Exception

      MessageBox.Show(My.Resources.TestCompétance_QCMDetail_sub3 + ex.Message, My.Resources.Global_Erreur)
      Return False

    End Try

  End Function

  Private Sub treeList1_MouseUp(ByVal sender As Object, ByVal e As System.Windows.Forms.MouseEventArgs) Handles treeList1.MouseUp

    Dim MousePos As Point = Control.MousePosition
    Dim hitinfo As TreeListHitInfo = treeList1.CalcHitInfo(New Point(e.X, e.Y))

    If e.Button = Windows.Forms.MouseButtons.Right And treeList1.State = TreeListState.Regular Then

      If hitinfo.HitInfoType = HitInfoType.Cell Then

        If Not hitinfo.Node Is Nothing Then

          hitinfo.Node.Selected = True

          oNodeSelected = hitinfo.Node

          If hitinfo.Node.Level = 0 Then
            IdQuestOrderSelected = 0
            MenuQCM.Show(MousePos)
          Else
            IdQuestOrderSelected = hitinfo.Node.Item(2)
            MenuQuestion.Show(MousePos)
          End If

        End If

      End If

    Else

      If hitinfo.HitInfoType = HitInfoType.Cell Then

        ToolTipTreeList.Show(hitinfo.Node.Item("VQCMQUESTIONLIB").ToString, treeList1)

      End If

    End If

  End Sub

  Private Sub ALaFinDuQuestionnaireToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles ALaFinDuQuestionnaireToolStripMenuItem.Click, ÀLaFinToolStripMenuItem.Click

    Dim frmQCMAddQuest As New frmQCMNewQuestion
    frmQCMAddQuest.ShowDialog()
    Dim sNewQuestion As String = frmQCMAddQuest.p_sLibQuestion

    If sNewQuestion <> "" Then

      'CreateNewQuestion(iIdQCM, sNewQuestion, NbQuestions + 1)
      AddNewQuestionDataTable(sNewQuestion, NbQuestions + 1)
      treeList1.Nodes.Clear()
      AppendNodes(Nothing)
      treeList1.ExpandAll()
      If Not oNodeSelected Is Nothing Then treeList1.FocusedNode = oNodeSelected.NextNode

    End If

  End Sub

  Private Sub CreateNewQuestion(ByVal NIDQCMQUESTION As Integer, ByVal NIDQCMNUM As Integer, ByVal NQCMQUESTIONORDER As Integer, ByVal sLibNewQuestion As String, ByVal bLibQuestionActif As Boolean, ByVal bQuestionRemarque As Boolean)

    Dim Cmd As New SqlCommand("api_sp_QCMCreateQuestion", oCnxQCMDet.CnxSQLOpen)
    Cmd.CommandType = CommandType.StoredProcedure

    Dim P_nidqcmquestion As SqlParameter = Cmd.Parameters.Add("@p_nidqcmquestion", SqlDbType.Int)
    P_nidqcmquestion.Value = NIDQCMQUESTION
    Dim P_nidqcmnum As SqlParameter = Cmd.Parameters.Add("@p_nidqcmnum", SqlDbType.Int)
    P_nidqcmnum.Value = NIDQCMNUM
    Dim P_nqcmquestionorder As SqlParameter = Cmd.Parameters.Add("@p_nqcmquestionorder", SqlDbType.Int)
    P_nqcmquestionorder.Value = NQCMQUESTIONORDER
    Dim P_vqcmquestionlib As SqlParameter = Cmd.Parameters.Add("@p_vqcmquestionlib", SqlDbType.NVarChar)
    P_vqcmquestionlib.Value = sLibNewQuestion
    Dim P_vqcmquestionactif As SqlParameter = Cmd.Parameters.Add("@p_bqcmquestionactif", SqlDbType.Bit)
    P_vqcmquestionactif.Value = bLibQuestionActif
    Dim P_vqcmquestionrem As SqlParameter = Cmd.Parameters.Add("@p_bqcmquestionrem", SqlDbType.Bit)
    P_vqcmquestionrem.Value = bQuestionRemarque

    Cmd.ExecuteNonQuery()

  End Sub

  Private Sub MovePosQuestion(ByVal NQCMQUESTIONORDER As Integer, ByVal sType As String)

    'Dim Cmd As New SqlCommand("api_sp_QCMMoveUpQuestion", oCnxQCMDet.CnxSQLOpen)
    'Cmd.CommandType = CommandType.StoredProcedure

    'Dim P_nidqcmnum As SqlParameter = Cmd.Parameters.Add("@p_nidqcmnum", SqlDbType.Int)
    'P_nidqcmnum.Value = NIDQCMNUM
    'Dim P_nqcmquestionorder As SqlParameter = Cmd.Parameters.Add("@p_nqcmquestionorder", SqlDbType.Int)
    'P_nqcmquestionorder.Value = NQCMQUESTIONORDER
    'Dim P_nqcmquestiontype As SqlParameter = Cmd.Parameters.Add("@p_nqcmquestiontype", SqlDbType.VarChar)
    'P_nqcmquestiontype.Value = sType

    'Cmd.ExecuteNonQuery()
    Select Case sType

      Case "ADD"

        Dim DATAROW() As DataRow = DtQuestion.Select("BQCMQUESTIONACTIF = 1 AND NQCMQUESTIONORDER >= " & NQCMQUESTIONORDER)

        For i = 0 To DATAROW.Count - 1

          DATAROW(i).Item("NQCMQUESTIONORDER") = DATAROW(i).Item("NQCMQUESTIONORDER") + 1

        Next

      Case "DESC"

        Dim DATAROWLast() As DataRow = DtQuestion.Select("BQCMQUESTIONACTIF = 1 AND NQCMQUESTIONORDER = " & NQCMQUESTIONORDER + 1)
        DATAROWLast(0).Item("NQCMQUESTIONORDER") = NQCMQUESTIONORDER

        Dim DATAROWNew() As DataRow = DtQuestion.Select("BQCMQUESTIONACTIF = 1 AND NQCMQUESTIONORDER = " & NQCMQUESTIONORDER)
        DATAROWNew(0).Item("NQCMQUESTIONORDER") = NQCMQUESTIONORDER + 1

      Case "ARCH"

        Dim DATAROW() As DataRow = DtQuestion.Select("BQCMQUESTIONACTIF = 1 AND NQCMQUESTIONORDER > " & NQCMQUESTIONORDER)

        For i = 0 To DATAROW.Count - 1

          DATAROW(i).Item("NQCMQUESTIONORDER") = DATAROW(i).Item("NQCMQUESTIONORDER") - 1

        Next

      Case Else

        Dim DATAROWLast() As DataRow = DtQuestion.Select("NQCMQUESTIONORDER = " & NQCMQUESTIONORDER - 1)
        DATAROWLast(0).Item("NQCMQUESTIONORDER") = NQCMQUESTIONORDER

        Dim DATAROWNew() As DataRow = DtQuestion.Select("NQCMQUESTIONORDER = " & NQCMQUESTIONORDER)
        DATAROWNew(0).Item("NQCMQUESTIONORDER") = NQCMQUESTIONORDER - 1


    End Select



  End Sub

  Private Sub AuDébutDuQuestionnaireToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles AuDébutDuQuestionnaireToolStripMenuItem.Click, AuDébutToolStripMenuItem.Click

    Dim frmQCMAddQuest As New frmQCMNewQuestion
    frmQCMAddQuest.ShowDialog()
    Dim sNewQuestion As String = frmQCMAddQuest.p_sLibQuestion

    If sNewQuestion <> "" Then

      MovePosQuestion(1, "ADD")
      'CreateNewQuestion(iIdQCM, sNewQuestion, 1)
      AddNewQuestionDataTable(sNewQuestion, 1)
      treeList1.Nodes.Clear()
      AppendNodes(Nothing)
      treeList1.ExpandAll()

      If Not oNodeSelected Is Nothing Then treeList1.FocusedNode = oNodeSelected.FirstNode

    End If

  End Sub

  Private Sub ItemUpQuestion_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles ItemUpQuestion.Click

    MovePosQuestion(IdQuestOrderSelected, "ASC")
    treeList1.Nodes.Clear()
    AppendNodes(Nothing)
    treeList1.ExpandAll()
    treeList1.FocusedNode = oNodeSelected.PrevNode

  End Sub

  Private Sub ÀLaLigneDuDessusToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles ÀLaLigneDuDessusToolStripMenuItem.Click

    Dim frmQCMAddQuest As New frmQCMNewQuestion
    frmQCMAddQuest.ShowDialog()
    Dim sNewQuestion As String = frmQCMAddQuest.p_sLibQuestion

    If sNewQuestion <> "" Then

      MovePosQuestion(IdQuestOrderSelected, "ADD")
      'CreateNewQuestion(iIdQCM, sNewQuestion, IdQuestOrderSelected)
      AddNewQuestionDataTable(sNewQuestion, IdQuestOrderSelected)
      treeList1.Nodes.Clear()
      AppendNodes(Nothing)
      treeList1.ExpandAll()

      treeList1.FocusedNode = oNodeSelected

    End If

  End Sub

  Private Sub ÀLaLigneEnDessousToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles ÀLaLigneEnDessousToolStripMenuItem.Click

    Dim frmQCMAddQuest As New frmQCMNewQuestion
    frmQCMAddQuest.ShowDialog()
    Dim sNewQuestion As String = frmQCMAddQuest.p_sLibQuestion

    If sNewQuestion <> "" Then

      MovePosQuestion(IdQuestOrderSelected + 1, "ADD")
      'CreateNewQuestion(iIdQCM, sNewQuestion, IdQuestOrderSelected + 1)
      AddNewQuestionDataTable(sNewQuestion, IdQuestOrderSelected + 1)
      treeList1.Nodes.Clear()
      AppendNodes(Nothing)
      treeList1.ExpandAll()

      treeList1.FocusedNode = oNodeSelected.NextNode

    End If

  End Sub

  Private Sub ItemDownQuestion_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles ItemDownQuestion.Click

    MovePosQuestion(IdQuestOrderSelected, "DESC")
    treeList1.Nodes.Clear()
    AppendNodes(Nothing)
    treeList1.ExpandAll()
    treeList1.FocusedNode = oNodeSelected.NextNode

  End Sub

  Private Sub MenuQuestion_Opening(ByVal sender As Object, ByVal e As System.ComponentModel.CancelEventArgs) Handles MenuQuestion.Opening, MenuQCM.Opening

    If ChkListQuestArchives.Checked = False Then

      If IdQuestOrderSelected = 1 Then

        ItemUpQuestion.Enabled = False
        ÀLaLigneDuDessusToolStripMenuItem.Enabled = False
        ItemDownQuestion.Enabled = True
        ÀLaLigneEnDessousToolStripMenuItem.Enabled = True

      ElseIf IdQuestOrderSelected = NbQuestions Then

        ItemUpQuestion.Enabled = True
        ÀLaLigneDuDessusToolStripMenuItem.Enabled = True
        ItemDownQuestion.Enabled = False
        ÀLaLigneEnDessousToolStripMenuItem.Enabled = False

      Else

        ItemUpQuestion.Enabled = True
        ÀLaLigneDuDessusToolStripMenuItem.Enabled = True
        ItemDownQuestion.Enabled = True
        ÀLaLigneEnDessousToolStripMenuItem.Enabled = True

      End If
      ItemNewQuestionQCM.Enabled = True
      ItemAjoutQuestion.Enabled = True
      ItemArchiveQuestion.Enabled = True
      ItemRestaureQuestion.Enabled = False

    Else
      ItemNewQuestionQCM.Enabled = False
      ItemAjoutQuestion.Enabled = False
      ItemUpQuestion.Enabled = False
      ItemDownQuestion.Enabled = False
      ItemArchiveQuestion.Enabled = False
      ItemRestaureQuestion.Enabled = True
    End If

  End Sub

  Private Sub ItemAfficheQuestArchi_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles ItemAfficheQuestArchi.Click

    If Not oNodeSelected Is Nothing Then
      ChkListQuestArchives.Checked = ItemAfficheQuestArchi.Checked
      treeList1.Nodes.Clear()
      AppendNodes(Nothing)
      treeList1.ExpandAll()
      treeList1.FocusedNode = oNodeSelected
    End If

  End Sub

  Private Sub BtnAjoutRep_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles BtnAjoutRep.Click

    If Not oNodeSelected Is Nothing Then

      If oNodeSelected.Item("NIDQCMQUESTION") = 0 Then
        MessageBox.Show(My.Resources.TestCompétance_QCMDetail_save_quest, My.Resources.TestCompétance_QCMDetail_erreur_save, MessageBoxButtons.OK, MessageBoxIcon.Exclamation)
      Else

        Dim frmNewReponse As New frmQCMNewRep(iNQCMTypeId)
        frmNewReponse.p_strStatut = "C"
        frmNewReponse.P_DataRowRepNew = DtReponse.NewRow
        frmNewReponse.sLibQuestionParam = oNodeSelected.Item(3)
        frmNewReponse.iQCMQuestionIDParam = oNodeSelected.Item(1)
        frmNewReponse.ShowDialog()

        If Not frmNewReponse.P_DataRowRepNew Is Nothing AndAlso IsDBNull(frmNewReponse.P_DataRowRepNew.Item("NIDQCMREPONSE")) = False Then

          DtReponse.Rows.Add(frmNewReponse.P_DataRowRepNew)
          DGVReponse.DataSource = LoadDataView(DtReponse, Not (ChkListRepArchives.Checked))

        End If

      End If

    Else

      MessageBox.Show(My.Resources.TestCompétance_QCMDetail_select_quest, My.Resources.TestCompétance_QCMDetail_erreur_select, MessageBoxButtons.OK, MessageBoxIcon.Exclamation)

    End If

  End Sub

  Private Sub BtnArchRep_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles BtnArchRep.Click

    If DGVReponse.SelectedRows.Count > 0 Then

      Dim DataRowRepArch() As DataRow = DtReponse.Select("ID=" + DGVReponse.SelectedRows.Item(0).Cells(0).Value.ToString)

      If DataRowRepArch.Count = 1 Then

        If DataRowRepArch(0).Item("NIDQCMREPONSE") = 0 Then
          If MessageBox.Show(My.Resources.TestCompétance_QCMDetail_delete_answer, My.Resources.TestCompétance_QCMDetail_sup_conf, MessageBoxButtons.YesNoCancel, MessageBoxIcon.Question) = vbYes Then
            DtReponse.Rows.Remove(DataRowRepArch(0))
          End If
        Else
          If MessageBox.Show(My.Resources.TestCompétance_QCMDetail_archiver_answer, My.Resources.TestCompétance_QCMDetail_archiv_conf, MessageBoxButtons.YesNoCancel, MessageBoxIcon.Question) = vbYes Then
            DataRowRepArch(0).Item("BQCMREPONSEACTIF") = 0
          End If
        End If

      Else

        MessageBox.Show(My.Resources.TestCompétance_QCMDetail_clé_prim, My.Resources.TestCompétance_QCMDetail_clé_prim_erreur, MessageBoxButtons.OK, MessageBoxIcon.Error)

      End If
    Else
      MessageBox.Show(My.Resources.TestCompétance_QCMDetail_select_quest, My.Resources.TestCompétance_QCMDetail_erreur_select, MessageBoxButtons.OK, MessageBoxIcon.Exclamation)
    End If

  End Sub

  Private Sub ChkListRepArchives_CheckedChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles ChkListRepArchives.CheckedChanged

    If ChkListRepArchives.Checked = False Then
      GrpBxReponses.Text = My.Resources.TestCompétance_QCMDetail_rep_active
      btnRestoreRep.Visible = False
      BtnArchRep.Visible = True
      BtnAjoutRep.Visible = True
      BtnModif.Visible = True
    Else
      GrpBxReponses.Text = My.Resources.TestCompétance_QCMDetail_rep_non_active
      btnRestoreRep.Visible = True
      BtnArchRep.Visible = False
      BtnAjoutRep.Visible = False
      BtnModif.Visible = False
    End If

    DGVReponse.DataSource = LoadDataView(DtReponse, Not (ChkListRepArchives.Checked))

  End Sub

  Private Sub btnRestoreRep_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnRestoreRep.Click

    If DGVReponse.SelectedRows.Count > 0 Then

      Dim DataRowRepRestore() As DataRow = DtReponse.Select("ID=" + DGVReponse.SelectedRows.Item(0).Cells(0).Value.ToString)

      If MessageBox.Show(My.Resources.TestCompétance_QCMDetail_restorer_quest, My.Resources.TestCompétance_QCMDetail_restorer_confirm, MessageBoxButtons.YesNoCancel, MessageBoxIcon.Question) = vbYes Then
        If DataRowRepRestore.Count = 1 Then
          DataRowRepRestore(0).Item("BQCMREPONSEACTIF") = True
        Else
          MessageBox.Show(My.Resources.TestCompétance_QCMDetail_clé_prim, My.Resources.TestCompétance_QCMDetail_clé_prim_erreur, MessageBoxButtons.OK, MessageBoxIcon.Error)
        End If
      End If

    Else

      MessageBox.Show(My.Resources.TestCompétance_QCMDetail_select_rep, My.Resources.TestCompétance_QCMDetail_erreur_select_rep, MessageBoxButtons.OK, MessageBoxIcon.Exclamation)

    End If

  End Sub

  Private Sub BtnArchiveQuestion_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles ItemArchiveQuestion.Click

    If Not oNodeSelected Is Nothing Then

      Dim DataRowArch() As DataRow = DtQuestion.Select("NIDQCMQUESTION=" + oNodeSelected.Item("NIDQCMQUESTION").ToString)

      If DataRowArch.Count = 1 Then

        If DataRowArch(0).Item("NIDQCMQUESTION") = 0 Then
          If MessageBox.Show(My.Resources.TestCompétance_QCMDetail_delete_rep, My.Resources.TestCompétance_QCMDetail_sup_quest_conf, MessageBoxButtons.YesNoCancel, MessageBoxIcon.Question) = vbYes Then
            DtQuestion.Rows.Remove(DataRowArch(0))
            MovePosQuestion(DataRowArch(0).Item("NQCMQUESTIONORDER"), "ARCH")
          End If
        Else
          If MessageBox.Show(My.Resources.TestCompétance_QCMDetail_archiver_quest, My.Resources.TestCompétance_QCMDetail_archiv_conf_quest, MessageBoxButtons.YesNoCancel, MessageBoxIcon.Question) = vbYes Then
            DataRowArch(0).Item("BQCMQUESTIONACTIF") = 0
            MovePosQuestion(DataRowArch(0).Item("NQCMQUESTIONORDER"), "ARCH")

            'archives des réponses
            For Each lDataRowRep As DataRow In DtReponse.Rows

              lDataRowRep.Item("BQCMREPONSEACTIF") = False

            Next

          End If
        End If

        treeList1.Nodes.Clear()
        AppendNodes(Nothing)
        treeList1.ExpandAll()
        If Not oNodeSelected Is Nothing Then treeList1.FocusedNode = oNodeSelected

      Else

        MessageBox.Show(My.Resources.TestCompétance_QCMDetail_clé_prim, My.Resources.TestCompétance_QCMDetail_clé_prim_erreur, MessageBoxButtons.OK, MessageBoxIcon.Error)

      End If

    Else

      MessageBox.Show(My.Resources.TestCompétance_QCMDetail_select_quest, My.Resources.TestCompétance_QCMDetail_erreur_select, MessageBoxButtons.OK, MessageBoxIcon.Exclamation)

    End If

  End Sub

  Private Sub BtnNewQuestion_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles BtnNewQuestion.Click

    Dim frmQCMAddQuest As New frmQCMNewQuestion
    frmQCMAddQuest.ShowDialog()
    Dim sNewQuestion As String = frmQCMAddQuest.p_sLibQuestion

    If sNewQuestion <> "" Then

      AddNewQuestionDataTable(sNewQuestion, NbQuestions + 1)
      treeList1.Nodes.Clear()
      AppendNodes(Nothing)
      treeList1.ExpandAll()

      If Not oNodeSelected Is Nothing Then treeList1.FocusedNode = oNodeSelected.LastNode

      DGVReponse.DataSource = Nothing


    End If

  End Sub

  Private Sub AddNewQuestionDataTable(ByVal sLibNewQuestion As String, ByVal NQCMQUESTIONORDER As Integer)

    Dim NewDatarow As DataRow = DtQuestion.NewRow

    NewDatarow("NIDQCMQUESTION") = 0
    NewDatarow("NQCMQUESTIONORDER") = NQCMQUESTIONORDER
    NewDatarow("VQCMQUESTIONLIB") = sLibNewQuestion
    NewDatarow("BQCMQUESTIONACTIF") = True
    NewDatarow("BQCMQUESTIONREM") = False

    DtQuestion.Rows.Add(NewDatarow)

  End Sub

  Private Sub BtnRestaureQuestion_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles ItemRestaureQuestion.Click

    If Not oNodeSelected Is Nothing Then

      'RestaureQuestion(oNodeSelected.Item(1), 1)
      Dim DataRowRestore() As DataRow = DtQuestion.Select("NIDQCMQUESTION=" + oNodeSelected.Item("NIDQCMQUESTION").ToString)

      If MessageBox.Show(My.Resources.TestCompétance_QCMDetail_restorer_quest, My.Resources.TestCompétance_QCMDetail_restorer_confirm, MessageBoxButtons.YesNoCancel, MessageBoxIcon.Question) = vbYes Then
        If DataRowRestore.Count = 1 Then
          DataRowRestore(0).Item("BQCMQUESTIONACTIF") = True
          DataRowRestore(0).Item("NQCMQUESTIONORDER") = DtQuestion.Rows(DtQuestion.Rows.Count - 1).Item("NQCMQUESTIONORDER") + 1
          'restaure des réponses
          For Each lDataRowRep As DataRow In DtReponse.Rows

            lDataRowRep.Item("BQCMREPONSEACTIF") = False

          Next

        Else
          MessageBox.Show(My.Resources.TestCompétance_QCMDetail_clé_prim, My.Resources.TestCompétance_QCMDetail_clé_prim_erreur, MessageBoxButtons.OK, MessageBoxIcon.Error)
        End If
      End If

      treeList1.Nodes.Clear()
      AppendNodes(Nothing)
      treeList1.ExpandAll()
      If Not oNodeSelected Is Nothing Then treeList1.FocusedNode = oNodeSelected

    Else

      MessageBox.Show(My.Resources.TestCompétance_QCMDetail_select_quest, My.Resources.TestCompétance_QCMDetail_erreur_select, MessageBoxButtons.OK, MessageBoxIcon.Exclamation)

    End If

  End Sub

  Private Sub ChkListQuestArchives_CheckedChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles ChkListQuestArchives.CheckedChanged

    If FormReadOnly = True Then

      BtnNewQuestion.Visible = False
      BtnArchiveQuestion.Visible = False
      BtnRestaureQuestion.Visible = False

    Else

      If ChkListQuestArchives.Checked = True Then
        BtnNewQuestion.Visible = False
        BtnArchiveQuestion.Visible = False
        BtnRestaureQuestion.Visible = True

      Else
        BtnNewQuestion.Visible = True
        BtnArchiveQuestion.Visible = True
        BtnRestaureQuestion.Visible = False

      End If

    End If

    ItemAfficheQuestArchi.Checked = ChkListQuestArchives.Checked

    treeList1.Nodes.Clear()
    AppendNodes(Nothing)
    treeList1.ExpandAll()
    If Not oNodeSelected Is Nothing Then treeList1.SetFocusedNode(oNodeSelected)


  End Sub

  Private Sub BtnSaveQuestion_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles BtnSaveQuestion.Click

    If CboTypeQCM.SelectedValue Is Nothing Then

      MessageBox.Show("Il faut sélectionner une type de QCM", "Erreur", MessageBoxButtons.OK, MessageBoxIcon.Exclamation)
      Return

    End If


    'save la case a cocher recru
    If iIdQCM > 0 Then

      Dim sqlSave As New SqlCommand(String.Format("UPDATE TQCM SET BQCMRECRU = {0} WHERE NIDQCMNUM = {1}", If(ChkBoxQCMRecru.Checked = True, 1, 0), iIdQCM), oCnxQCMDet.CnxSQLOpen)
      sqlSave.ExecuteNonQuery()

      'save du type de qcm
      sqlSave = New SqlCommand(String.Format("UPDATE TQCM SET NQCMTYPEID = {0} WHERE NIDQCMNUM = {1}", CboTypeQCM.SelectedValue, iIdQCM), oCnxQCMDet.CnxSQLOpen)
      sqlSave.ExecuteNonQuery()

      'save consigne et qcm auto correction
      sqlSave = New SqlCommand(String.Format("UPDATE TQCM SET VQCMCONSIGNE = '{0}', BQCMCORRECTAUTO = {1} WHERE NIDQCMNUM = {2}", sVQCMCONSIGNE.Replace("'", "''"), If(ChkQCMCorrectAuto.Checked = True, 1, 0), iIdQCM), oCnxQCMDet.CnxSQLOpen)
      sqlSave.ExecuteNonQuery()

    End If

    For Each RowDTQuestion As DataRow In DtQuestion.Rows

      CreateNewQuestion(RowDTQuestion.Item("NIDQCMQUESTION"), iIdQCM, RowDTQuestion.Item("NQCMQUESTIONORDER"), RowDTQuestion.Item("VQCMQUESTIONLIB"), RowDTQuestion.Item("BQCMQUESTIONACTIF"), RowDTQuestion.Item("BQCMQUESTIONREM"))

    Next

    If Not oNodeSelected Is Nothing Then

      'on sauvegarde les réponses
      For Each RowGridRep As DataRow In DtReponse.Rows

        CreateNewReponse(RowGridRep.Item("NIDQCMREPONSE"), oNodeSelected.Item(1), RowGridRep.Item("NQCMREPONSEORDER"), RowGridRep.Item("VQCMREPONSELIB"), RowGridRep.Item("BQCMREPONSEVALID"), RowGridRep.Item("BQCMREPONSEACTIF"), RowGridRep.Item("VQCMREPONSEOBSCORRECT"))

      Next

      'affichage des réponses

      DtReponse = New DataTable
      DtReponse = ModDataGridView.LoadList("EXEC api_sp_QCMListeTreeRep " + oNodeSelected.Item(1).ToString, oCnxQCMDet.CnxSQLOpen)

      'affichages des données dans un dataview
      DGVReponse.DataSource = LoadDataView(DtReponse, Not (ChkListRepArchives.Checked))

    End If

    'For Each NodeQuestSave As TreeListNode In treeList1.Nodes.Item(0).Nodes  

    '    'MsgBox(test.Item("NIDQCMQUESTION").ToString  + " " +test.Item("NQCMQUESTIONORDER").ToString + " " + test.Item("VQCMQUESTIONLIB").ToString + " " + test.Item("CQCMQUESTIONACTIF").ToString)
    '    CreateNewQuestion(NodeQuestSave.Item("NIDQCMQUESTION"), iIdQCM, NodeQuestSave.Item("NQCMQUESTIONORDER"), NodeQuestSave.Item("VQCMQUESTIONLIB"), NodeQuestSave.Item("CQCMQUESTIONACTIF"))

    'Next

    treeList1.ClearNodes()

    'tree
    DtQuestion = New DataTable()

    Dim drsql As SqlDataReader = oCnxQCMDet.CreateSQLDataReader("EXEC api_sp_QCMListeTree " + iIdQCM.ToString)

    DtQuestion.Load(drsql)

    drsql.Close()

    'on affiche la data QCM recru
    Dim drQCMRecru As SqlDataReader = oCnxQCMDet.CreateSQLDataReader("SELECT ISNULL(BQCMRECRU, 0)  AS BQCMRECRU FROM TQCM WITH (NOLOCK) WHERE TQCM.NIDQCMNUM = " + iIdQCM.ToString)

    If drQCMRecru.HasRows = True Then

      drQCMRecru.Read()

      ChkBoxQCMRecru.Checked = drQCMRecru.Item("BQCMRECRU")

    End If
    drQCMRecru.Close()

    AppendNodes(Nothing)
    treeList1.ExpandAll()
    If Not oNodeSelected Is Nothing Then
      treeList1.FocusedNode = oNodeSelected
    Else
      DGVReponse.DataSource = Nothing
    End If

  End Sub

  Private Sub BtnSaveRep_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles BtnSaveRep.Click

    If Not oNodeSelected Is Nothing Then

      If DtReponse.Rows.Count = 0 Then
        MessageBox.Show(My.Resources.TestCompétance_QCMDetail_save_imp, My.Resources.TestCompétance_QCMDetail_erreur_save_rép, MessageBoxButtons.OK, MessageBoxIcon.Exclamation)
      Else
        For Each RowGridRep As DataRow In DtReponse.Rows

          CreateNewReponse(RowGridRep.Item("NIDQCMREPONSE"), oNodeSelected.Item(1), RowGridRep.Item("NQCMREPONSEORDER"), RowGridRep.Item("VQCMREPONSELIB"), RowGridRep.Item("BQCMREPONSEVALID"), RowGridRep.Item("BQCMREPONSEACTIF"), RowGridRep.Item("VQCMREPONSEOBSCORRECT"))

        Next

        MAJQuestionnaireEnCours(iIdQCM)

        DtReponse = New DataTable
        DtReponse = ModDataGridView.LoadList("EXEC api_sp_QCMListeTreeRep " + oNodeSelected.Item(1).ToString, oCnxQCMDet.CnxSQLOpen)

        'affichages des données dans un dataview
        DGVReponse.DataSource = LoadDataView(DtReponse, Not (ChkListRepArchives.Checked))

      End If

    Else

      MessageBox.Show(My.Resources.TestCompétance_QCMDetail_select_quest, My.Resources.TestCompétance_QCMDetail_erreur_save_rép, MessageBoxButtons.OK, MessageBoxIcon.Exclamation)

    End If

  End Sub

  Private Sub CreateNewReponse(ByVal NIDQCMREPONSE As Integer, ByVal NIDQCMQUESTION As Integer, ByVal NQCMREPONSEORDER As Integer, ByVal VQCMREPONSELIB As String, ByVal BQCMREPONSEVALID As Boolean, ByVal BQCMREPONSEACTIF As Boolean, ByVal VQCMREPONSEOBSCORRECT As String)

    Dim Cmd As New SqlCommand("api_sp_QCMCreateReponse", oCnxQCMDet.CnxSQLOpen)
    Cmd.CommandType = CommandType.StoredProcedure

    Dim P_nidqcmreponse As SqlParameter = Cmd.Parameters.Add("@p_nidqcmreponse", SqlDbType.Int)
    P_nidqcmreponse.Value = NIDQCMREPONSE
    Dim P_nidqcmquestion As SqlParameter = Cmd.Parameters.Add("@p_nidqcmquestion", SqlDbType.Int)
    P_nidqcmquestion.Value = NIDQCMQUESTION
    Dim P_nqcmquestionorder As SqlParameter = Cmd.Parameters.Add("@p_nidqcmreponseorder", SqlDbType.Int)
    P_nqcmquestionorder.Value = NQCMREPONSEORDER
    Dim P_vqcmquestionlib As SqlParameter = Cmd.Parameters.Add("@p_vqcmreponselib", SqlDbType.NVarChar)
    P_vqcmquestionlib.Value = VQCMREPONSELIB
    Dim P_vqcmquestionvalid As SqlParameter = Cmd.Parameters.Add("@p_bqcmreponsevalid", SqlDbType.Bit)
    P_vqcmquestionvalid.Value = BQCMREPONSEVALID
    Dim P_vqcmquestionactif As SqlParameter = Cmd.Parameters.Add("@p_bqcmreponseactif", SqlDbType.Bit)
    P_vqcmquestionactif.Value = BQCMREPONSEACTIF
    Dim P_VQCMREPONSEOBSCORRECT As SqlParameter = Cmd.Parameters.Add("@P_VQCMREPONSEOBSCORRECT", SqlDbType.VarChar)
    P_VQCMREPONSEOBSCORRECT.Value = VQCMREPONSEOBSCORRECT


    Cmd.ExecuteNonQuery()

  End Sub

  Private Function LoadDataView(ByVal ODataTable As DataTable, ByVal Actif As Boolean) As DataView

    Try

      Dim DvReponse As DataView

      DvReponse = New DataView
      DvReponse = ODataTable.AsDataView
      DvReponse.RowFilter = "BQCMREPONSEACTIF=" + Actif.ToString

      Return DvReponse

    Catch ex As Exception

      MessageBox.Show(My.Resources.TestCompétance_QCMDetail_sub4 + ex.Message, My.Resources.Global_Erreur)
      Return Nothing

    End Try

  End Function

  Private Sub BtnModif_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles BtnModif.Click

    If DGVReponse.SelectedRows.Count = 1 Then

      If oNodeSelected.Item("NIDQCMQUESTION") = 0 Then
        MessageBox.Show(My.Resources.TestCompétance_QCMDetail_save_quest, My.Resources.TestCompétance_QCMDetail_erreur_save, MessageBoxButtons.OK, MessageBoxIcon.Exclamation)
      Else

        'LblNomQCM.Text = DGVReponse.SelectedRows.Item(0).cells(0).Value.ToString 

        Dim DataRowRepModif() As DataRow = DtReponse.Select("ID=" + DGVReponse.SelectedRows.Item(0).Cells(0).Value.ToString)

        Dim frmNewReponse As New frmQCMNewRep(iNQCMTypeId)

        'Dim DataRowRep() As DataRow = DtReponse.Select("ID=" + DGVReponse.SelectedRows.Item(0).cells(0).Value.ToString)
        frmNewReponse.p_strStatut = "M"
        frmNewReponse.P_DataRowRepNew = DataRowRepModif(0)
        'DtQuestion.Select("NIDQCMQUESTION=" + oNodeSelected.Item("NIDQCMQUESTION").ToString)
        frmNewReponse.sLibQuestionParam = oNodeSelected.Item(3)
        frmNewReponse.iQCMQuestionIDParam = oNodeSelected.Item(1)
        frmNewReponse.ShowDialog()

        ''DtReponse.Rows.Add(frmNewReponse.P_DataRowRepNew)                
        'DtReponse.BeginLoadData()
        '' Add the new row to the rows collection.
        'DtReponse.LoadDataRow(frmNewReponse.P_DataRowRepNew.ItemArray, True)
        'DtReponse.EndLoadData()

        DGVReponse.DataSource = LoadDataView(DtReponse, Not (ChkListRepArchives.Checked))

      End If

    Else

      MessageBox.Show(My.Resources.TestCompétance_QCMDetail_select_rep, My.Resources.TestCompétance_QCMDetail_erreur_modif_rep, MessageBoxButtons.OK, MessageBoxIcon.Exclamation)

    End If

  End Sub

  Private Sub DGVReponse_CellClick(ByVal sender As System.Object, ByVal e As System.Windows.Forms.DataGridViewCellEventArgs) Handles DGVReponse.CellClick

    'LblNomQCM.Text = DGVReponse.Rows(e.RowIndex).Cells(1).Value.ToString 

    If ReponseIsEditable(DGVReponse.Rows(e.RowIndex).Cells(1).Value) = True Then

      DGVReponse.EditMode = DataGridViewEditMode.EditOnEnter

      DGVReponse.BeginEdit(True)

    Else

      DGVReponse.Rows(e.RowIndex).ReadOnly = True

    End If


  End Sub

  Private Function ReponseIsEditable(ByVal NIDREPONSE As Integer) As Boolean

    Try

      Dim sqlcmd As New SqlCommand("api_sp_QCMTestReponseEditable", oCnxQCMDet.CnxSQLOpen)

      sqlcmd.CommandType = CommandType.StoredProcedure

      sqlcmd.Parameters.Add("@p_nidqcmreponse", SqlDbType.Int)
      sqlcmd.Parameters("@p_nidqcmreponse").Value = NIDREPONSE

      Dim drEdit As SqlDataReader = sqlcmd.ExecuteReader
      Dim bEditable As Boolean = False

      drEdit.Read()

      If drEdit(0) = 0 Then
        bEditable = True
      Else
        bEditable = False
      End If

      drEdit.Close()

      Return bEditable

    Catch ex As Exception

      MessageBox.Show(My.Resources.TestCompétance_QCMDetail_sub5 + ex.Message, My.Resources.Global_Erreur)
      Return False

    End Try

  End Function

  Private Sub MAJQuestionnaireEnCours(ByVal NIDQCMNUM As Integer)

    Try

      Dim SQLCmdMAJ As New SqlCommand("api_sp_QCMMajQCMAffect", oCnxQCMDet.CnxSQLOpen)

      SQLCmdMAJ.CommandType = CommandType.StoredProcedure
      SQLCmdMAJ.Parameters.Add("@P_NIDQCMNUM", SqlDbType.Int)
      SQLCmdMAJ.Parameters("@P_NIDQCMNUM").Value = NIDQCMNUM

      'mis en com le 20/08/2020 : révisier son analyse fonctionnel

      'SQLCmdMAJ.ExecuteNonQuery 

    Catch ex As Exception

      MessageBox.Show(My.Resources.TestCompétance_QCMDetail_sub6 + ex.Message, My.Resources.Global_Erreur)

    End Try

  End Sub

  Private Sub SaveQuestionCheckRemarque(ByVal NIDQCMQUESTION As Integer, ByVal bValue As Boolean)

    Try

      Dim SQLCmdSaveRem As New SqlCommand("api_sp_QCMSaveQuestionRemarque", oCnxQCMDet.CnxSQLOpen)

      SQLCmdSaveRem.CommandType = CommandType.StoredProcedure
      SQLCmdSaveRem.Parameters.Add("@p_nidqcmquestion", SqlDbType.Int)
      SQLCmdSaveRem.Parameters("@p_nidqcmquestion").Value = NIDQCMQUESTION
      SQLCmdSaveRem.Parameters.Add("@p_value", SqlDbType.Bit)
      SQLCmdSaveRem.Parameters("@p_value").Value = bValue

      SQLCmdSaveRem.ExecuteNonQuery()

    Catch ex As Exception

      MessageBox.Show(My.Resources.TestCompétance_QCMDetail_sub7 + ex.Message, My.Resources.Global_Erreur)

    End Try

  End Sub

  Private Sub ChkRemarque_CheckedChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles ChkRemarque.CheckedChanged

    If Not oNodeSelected Is Nothing Then

      Dim DataRowEdit() As DataRow = DtQuestion.Select(String.Format("ID = {0}", oNodeSelected.Item("ID")))

      If DataRowEdit.Count = 1 Then

        DtQuestion.Columns("BQCMQUESTIONREM").ReadOnly = False
        oNodeSelected.Item("BQCMQUESTIONREM") = CType(sender, CheckBox).Checked
        DtQuestion.Rows(DtQuestion.Rows.IndexOf(DataRowEdit(0))).Item("BQCMQUESTIONREM") = CType(sender, CheckBox).Checked

      End If

    End If

  End Sub

  Private Sub ChkQCMCorrectAuto_CheckedChanged(sender As Object, e As EventArgs) Handles ChkQCMCorrectAuto.CheckedChanged

    If ChkQCMCorrectAuto.Checked = True Then
      'test si pas de correction
      If bIsLoading = False Then
        MessageBox.Show("IMPORTANT : Avant de valider ce qcm/causerie en correction automatique, assurez-vous d'avoir saisi tous les commentaires de corrections !", "Information", MessageBoxButtons.OK, MessageBoxIcon.Information)
        bQCMCORRECTAUTO = True
      End If
    Else
      bQCMCORRECTAUTO = False
    End If

  End Sub

  Private Sub BtnConsigne_Click(sender As Object, e As EventArgs) Handles BtnConsigne.Click

    Dim oFrmConsigneDetail As New frmQCMConsigneDetail(sVQCMCONSIGNE)
    oFrmConsigneDetail.ShowDialog()

    If oFrmConsigneDetail.sConsigne <> "" Then
      BtnConsigne.BackColor = Color.Yellow
    Else
      BtnConsigne.BackColor = DefaultBackColor
    End If
    sVQCMCONSIGNE = oFrmConsigneDetail.sConsigne

    oFrmConsigneDetail.Dispose()

  End Sub

  Private Sub BtnVideo_Click(sender As Object, e As EventArgs) Handles BtnVideo.Click

    If iIdQCM = 0 Then
      MessageBox.Show("Il faut enregistrer le qcm !", "Erreur", MessageBoxButtons.OK, MessageBoxIcon.Exclamation)
      Return
    End If

    Dim ofrmVideo As New frmQCM_Video(iIdQCM)
    ofrmVideo.ShowDialog()

    If ofrmVideo.VideoExist Then BtnVideo.BackColor = Color.Yellow Else BtnVideo.BackColor = DefaultBackColor

    ofrmVideo.Dispose()

  End Sub

  Private Sub BtnAddImage_Click(sender As Object, e As EventArgs) Handles BtnAddImage.Click
    If iIdQCM = 0 Then
      MessageBox.Show("Il faut enregistrer le qcm !", "Erreur", MessageBoxButtons.OK, MessageBoxIcon.Exclamation)
      Return
    End If

    If DGVReponse.SelectedRows.Count = 1 Then

      If oNodeSelected Is Nothing Then
        MessageBox.Show("Il faut sélectionner une question !", My.Resources.TestCompétance_QCMDetail_erreur_save, MessageBoxButtons.OK, MessageBoxIcon.Exclamation)
        Return
      End If

      If oNodeSelected.Item("NIDQCMQUESTION") = 0 Then
        MessageBox.Show(My.Resources.TestCompétance_QCMDetail_save_quest, My.Resources.TestCompétance_QCMDetail_erreur_save, MessageBoxButtons.OK, MessageBoxIcon.Exclamation)
        Return

      End If

      Dim ofrmImages As New frmQCMImages(iIdQCM, oNodeSelected.Item("NIDQCMQUESTION"))
      ofrmImages.ShowDialog()


      If Not oNodeSelected Is Nothing Then

        Dim DataRowEdit() As DataRow = DtQuestion.Select(String.Format("ID = {0}", oNodeSelected.Item("ID")))

        If DataRowEdit.Count = 1 Then

          DtQuestion.Columns("NIMG_NB").ReadOnly = False
          oNodeSelected.Item("NIMG_NB") = ofrmImages.NbImages
          DtQuestion.Rows(DtQuestion.Rows.IndexOf(DataRowEdit(0))).Item("NIMG_NB") = ofrmImages.NbImages

        End If

        If ofrmImages.NbImages > 0 Then BtnAddImage.BackColor = Color.Yellow Else BtnAddImage.BackColor = DefaultBackColor

      End If
        ofrmImages.Dispose()

    End If


  End Sub
End Class