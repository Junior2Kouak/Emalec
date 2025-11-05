Imports System.Data.SqlClient
Imports DevExpress.Data
Imports DevExpress.Utils
Imports DevExpress.XtraGrid.Views.Base
Imports DevExpress.XtraGrid.Views.Grid
Imports DevExpress.XtraGrid.Views.Grid.ViewInfo
Imports MozartLib
Imports MozartNet.CGestionSQL

Public Class frmQCMListe

  'Dim oListMsg As CQCMListeMsg
  Dim bAffichQCMActif As Boolean

  'Dim iNQCMTypeId As Int32 '1 = test de connaissances et 2 : causeries securite
  'Dim sTypeQCM As String 'QCM ou Causeries

  Dim DTListeQCM As DataTable

  Public Sub New(ByVal C_iNQCMTypeId As Object)

    ' Cet appel est requis par le concepteur.
    InitializeComponent()

    ' Ajoutez une initialisation quelconque après l'appel InitializeComponent().
    'iNQCMTypeId = CType(C_iNQCMTypeId, Int32)

    'gestion des messages par type de qcm
    ' oListMsg = New CQCMListeMsg(1)

  End Sub

  Private Sub FrmGestTestConnaissance_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load

    Try

      'init
      Initboutons(Me)

      'on charge la liste des QCM existant
      bAffichQCMActif = Not (ChkListArchives.Checked)

      LoadData()

    Catch ex As Exception

      MessageBox.Show(My.Resources.TestCompétance_QCMDetailListe_sub + ex.Message, My.Resources.Global_Erreur, MessageBoxButtons.OK, MessageBoxIcon.Error)

    End Try

  End Sub

  Private Sub LoadData()

    DTListeQCM = New DataTable

    Dim sqlcmd As New SqlCommand("api_sp_QCMListe", MozartDatabase.cnxMozart)
    sqlcmd.CommandType = CommandType.StoredProcedure
        sqlcmd.Parameters.Add("@P_CQCMACTIF", SqlDbType.Bit).Value = bAffichQCMActif
        DTListeQCM.Load(sqlcmd.ExecuteReader())

        GCListeQCM.DataSource = DTListeQCM

    End Sub

    Private Sub BtnFermer_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles BtnFermer.Click

        Me.Close()

    End Sub

    Private Sub BtnCreerTest_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles BtnCreerTest.Click

        Dim sNomNNewQCM As String = InputBox("Entrer le libellé du QCM", "Création d'un QCM")

        If String.IsNullOrWhiteSpace(sNomNNewQCM) = False Then

            Dim frmDetail As New frmQCMDetail

            frmDetail.iIdQCMParam = CreateQCM(0, sNomNNewQCM, 0)
            frmDetail.sSQMTitreParam = sNomNNewQCM
            frmDetail.p_iNQCMTypeId = 0
            frmDetail.ShowDialog()
            frmDetail.Dispose()

            LoadData()

        End If

    End Sub

    Private Function CreateQCM(ByVal NIDQCMNUM As Integer, ByVal sNomQCM As String, ByVal iNQCMTypeId As Int32) As Integer

        Try

      Dim Cmd As New SqlCommand("api_sp_QCMCreate", MozartDatabase.cnxMozart)
      Cmd.CommandType = CommandType.StoredProcedure

            Dim ParamNIDQCMNUM As SqlParameter = Cmd.Parameters.Add("@P_NIDQCMNUM", SqlDbType.VarChar)
            ParamNIDQCMNUM.Value = NIDQCMNUM

            Dim ParamVQCMTITRE As SqlParameter = Cmd.Parameters.Add("@P_VQCMTITRE", SqlDbType.VarChar)
            ParamVQCMTITRE.Value = sNomQCM

            Dim ParamNQCMTYPEID As SqlParameter = Cmd.Parameters.Add("@P_NQCMTYPEID", SqlDbType.Int)
            ParamNQCMTYPEID.Value = iNQCMTypeId

            Return Convert.ToInt32(Cmd.ExecuteScalar)

        Catch ex As Exception

            MessageBox.Show(My.Resources.TestCompétance_QCMDetailListe_sub2 + ex.Message, My.Resources.Global_Erreur, MessageBoxButtons.OK, MessageBoxIcon.Error)
            Return 0

        End Try

    End Function

    Private Sub BtnModifier_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles BtnModifier.Click

    If GVListeQCM.SelectedRowsCount = 0 Then Exit Sub

    Dim dtrow As DataRow = GVListeQCM.GetDataRow(GVListeQCM.FocusedRowHandle)

        Dim frmQCMDetail As New frmQCMDetail
        frmQCMDetail.bReadOnly = False 'not CType((DGVTestConnaissances.SelectedRows.Item(0).Cells("BQCMACTIF").Value), Boolean)
        frmQCMDetail.iIdQCMParam = dtrow.Item("NIDQCMNUM")
        frmQCMDetail.sSQMTitreParam = dtrow.Item("VQCMTITRE")
        frmQCMDetail.p_iNQCMTypeId = dtrow.Item("NQCMTYPEID")

        frmQCMDetail.VQCMCONSIGNE = dtrow.Item("VQCMCONSIGNE")
        frmQCMDetail.QCMCORRECTAUTO = dtrow.Item("BQCMCORRECTAUTO")


        frmQCMDetail.ShowDialog()
        frmQCMDetail.Dispose()

        LoadData()

    End Sub

    Private Sub ChkListArchives_CheckedChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles ChkListArchives.CheckedChanged

        If ChkListArchives.Checked = False Then
            Me.Text = "Liste des QCM actifs"   '"Liste des tests de connaissances actifs"
            BtnRestore.Visible = False
            BtnArchiver.Visible = True
            BtnCreerTest.Visible = True
        Else
            Me.Text = "Liste des QCM non actifs"  '"Liste des tests de connaissances non actifs"
            BtnRestore.Visible = True
            BtnArchiver.Visible = False
            BtnCreerTest.Visible = False
        End If
        bAffichQCMActif = Not (ChkListArchives.Checked)
        'DGVTestConnaissances.DataSource = ModDataGridView.LoadList("EXEC api_sp_QCMListe " + bAffichQCMActif.ToString, oGestConnectSQL.CnxSQLOpen)

        LoadData()

    End Sub

    Private Sub BtnArchiver_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles BtnArchiver.Click


    If GVListeQCM.SelectedRowsCount = 0 Then Exit Sub

        Dim dtrow As DataRow = GVListeQCM.GetDataRow(GVListeQCM.FocusedRowHandle)
        ArchiverQCM(dtrow.Item("NIDQCMNUM"))

        LoadData()


    End Sub

    Private Sub ArchiverQCM(ByVal NIDQCMNUM As Integer)

        Try

            If MessageBox.Show("Voulez-vous vraiment archiver ce QCM ?", "Confirmation archivage QCM", MessageBoxButtons.YesNoCancel, MessageBoxIcon.Question) = vbYes Then

        Dim Cmd As New SqlCommand("api_sp_QCMArchiver", MozartDatabase.cnxMozart)
        Cmd.CommandType = CommandType.StoredProcedure

                Dim PNIDQCMNUM As SqlParameter = Cmd.Parameters.Add("@P_NIDQCMNUM", SqlDbType.Int)
                PNIDQCMNUM.Value = NIDQCMNUM

                Cmd.ExecuteNonQuery()
            End If

        Catch ex As Exception

            MessageBox.Show(My.Resources.TestCompétance_QCMDetailListe_sub3 + ex.Message, My.Resources.Global_Erreur, MessageBoxButtons.OK, MessageBoxIcon.Error)

        End Try

    End Sub

    Private Sub RestaureQCM(ByVal NIDQCMNUM As Integer)

        Try

            If MessageBox.Show("Voulez-vous vraiment restaurer ce QCM ?", "Confirmation restauration QCM", MessageBoxButtons.YesNoCancel, MessageBoxIcon.Question) = vbYes Then

        Dim Cmd As New SqlCommand("api_sp_QCMRestaure", MozartDatabase.cnxMozart)
        Cmd.CommandType = CommandType.StoredProcedure

                Dim PNIDQCMNUM As SqlParameter = Cmd.Parameters.Add("@P_NIDQCMNUM", SqlDbType.Int)
                PNIDQCMNUM.Value = NIDQCMNUM

                Cmd.ExecuteNonQuery()

            End If

        Catch ex As Exception

            MessageBox.Show(My.Resources.TestCompétance_QCMDetailListe_sub4 + ex.Message, My.Resources.Global_Erreur, MessageBoxButtons.OK, MessageBoxIcon.Error)

        End Try

    End Sub
    Private Function QCMIsEditable(ByVal NIDQCM As Integer) As Boolean

        Try

      Dim sqlcmd As New SqlCommand("api_sp_QCMTestQCMEditable", MozartDatabase.cnxMozart)

      sqlcmd.CommandType = CommandType.StoredProcedure

            sqlcmd.Parameters.Add("@p_nidqcmnum", SqlDbType.Int)
            sqlcmd.Parameters("@p_nidqcmnum").Value = NIDQCM

            Dim drEdit As SqlDataReader = sqlcmd.ExecuteReader
            Dim bEditable As Boolean = False

            drEdit.Read()
            If drEdit(0) = 0 Then
                bEditable = True
            Else
                bEditable = False
            End If

            drEdit.Close()

            'Return bEditable
            'on retourne la valeur a true pour autoriser la modif de nom du qcm 
            'Vu avec JJ le 14/01/2014 par MC
            Return True

        Catch ex As Exception

            MessageBox.Show(My.Resources.TestCompétance_QCMDetailListe_sub5 + ex.Message, My.Resources.Global_Erreur, MessageBoxButtons.OK, MessageBoxIcon.Error)
            Return False

        End Try

    End Function

    Private Sub GVListeQCM_DoubleClick(sender As Object, e As EventArgs) Handles GVListeQCM.DoubleClick

        Dim ea As DXMouseEventArgs = TryCast(e, DXMouseEventArgs)
        Dim view As GridView = TryCast(sender, GridView)
        Dim info As GridHitInfo = view.CalcHitInfo(ea.Location)
        If info.InRow OrElse info.InRowCell Then

            Dim dtrow As DataRow = GVListeQCM.GetDataRow(info.RowHandle)

            If QCMIsEditable(dtrow.Item("NIDQCMNUM")) = True Then

                Dim sReturn As String = InputBox("Nouveau libellé QCM : ", "Titre QCM", dtrow.Item("VQCMTITRE"))

                If sReturn <> "" Then
                    dtrow.Item("VQCMTITRE") = sReturn
          'update
          Dim sqlcmdupdate As New SqlCommand("UPDATE TQCM SET VQCMTITRE = '" & sReturn.Replace("'", "''") & "' WHERE NIDQCMNUM = " & dtrow.Item("NIDQCMNUM"), MozartDatabase.cnxMozart)
          sqlcmdupdate.CommandType = CommandType.Text
                    sqlcmdupdate.ExecuteNonQuery()

                End If

            End If

        End If

    End Sub

    Private Sub GVListeQCM_CellValueChanged(sender As Object, e As CellValueChangedEventArgs) Handles GVListeQCM.CellValueChanged


        If e.Column.FieldName = "VQCMTITRE" Then

            Dim dtrow As DataRow = GVListeQCM.GetDataRow(e.RowHandle)

            If dtrow.Item("NIDQCMNUM").ToString = "" Or dtrow.Item("NIDQCMNUM").Value Is Nothing Then
                MessageBox.Show("Attention !! Il faut saisir un nom pour ce QCM !!", "Erreur - Nom QCM", MessageBoxButtons.OK, MessageBoxIcon.Exclamation)
                Return
            End If
            CreateQCM(dtrow.Item("NIDQCMNUM"), dtrow.Item("VQCMTITRE"), dtrow.Item("NIDQCMNUM"))

        End If

    End Sub

    Private Sub BtnRestore_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles BtnRestore.Click

        'If DGVTestConnaissances.SelectedRows.Count > 0 then
        '    RestaureQCM(CType(DGVTestConnaissances.SelectedRows.Item(0).Cells("NIDQCMNUM").Value, integer))
        '    DGVTestConnaissances.DataSource = ModDataGridView.LoadList("EXEC api_sp_QCMListe " + bAffichQCMActif.ToString, oGestConnectSQL.CnxSQLOpen)
        'Else
        '    MessageBox.Show(oListMsg.ReturnMsg(6), My.Resources.Global_Erreur, MessageBoxButtons.OK, MessageBoxIcon.Error)
        'End If

        If GVListeQCM.SelectedRowsCount = 0 Then Exit Sub

        Dim dtrow As DataRow = GVListeQCM.GetDataRow(GVListeQCM.FocusedRowHandle)
        RestaureQCM(dtrow.Item("NIDQCMNUM"))
        LoadData()

    End Sub

    Private Sub BtnResultatsByQCM_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles BtnResultatsByQCM.Click


    If GVListeQCM.SelectedRowsCount = 0 Then MessageBox.Show("Il faut sélectionner un QCM", My.Resources.Global_Erreur, MessageBoxButtons.OK, MessageBoxIcon.Error) : Exit Sub

        Dim dtrow As DataRow = GVListeQCM.GetDataRow(GVListeQCM.FocusedRowHandle)

        Select Case dtrow.Item("NQCMTYPEID")

            Case 1

        Cursor = Cursors.WaitCursor
        Dim ofrmQCMResultatsByQCM As New frmQCMListeResultByQCM(dtrow.Item("NIDQCMNUM"), dtrow.Item("VQCMTITRE"), dtrow.Item("NQCMTYPEID"))
                ofrmQCMResultatsByQCM.ShowDialog()
                ofrmQCMResultatsByQCM.Dispose()

            Case 2
        Cursor = Cursors.WaitCursor
        Dim ofrmCauserieResultatsByQCM As New frmCauserieListeResultByQCM(dtrow.Item("NIDQCMNUM"), dtrow.Item("VQCMTITRE"), dtrow.Item("NQCMTYPEID"))
                ofrmCauserieResultatsByQCM.ShowDialog()
                ofrmCauserieResultatsByQCM.Dispose()

            Case Else

                MessageBox.Show(My.Resources.Global_type_nonreconnu, My.Resources.Global_Erreur, MessageBoxButtons.OK, MessageBoxIcon.Error)

        End Select

    Cursor = Cursors.Default

  End Sub

    Private Sub BtnEdit_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles BtnEdit.Click

        'If DGVTestConnaissances.SelectedRows.Count > 0 then

        '    Dim oDoc As New CGenDoc("QCM_Fiche_Edition", "exec api_sp_ImpQCMFiche " + DGVTestConnaissances.SelectedRows.Item(0).Cells("NIDQCMNUM").Value.ToString )
        '    If oDoc.p_ERROR = "" Then
        '        Dim ofrmVisuFic As new frmVisuDoc (oDoc.p_PathFileName)
        '        ofrmVisuFic.ShowDialog()
        '    End If

        'Else
        '    MessageBox.Show(oListMsg.ReturnMsg(6), My.Resources.Global_Erreur, MessageBoxButtons.OK, MessageBoxIcon.Error)
        'End If

        If GVListeQCM.SelectedRowsCount = 0 Then MessageBox.Show("Il faut sélectionner un QCM", My.Resources.Global_Erreur, MessageBoxButtons.OK, MessageBoxIcon.Error) : Exit Sub

        Dim dtrow As DataRow = GVListeQCM.GetDataRow(GVListeQCM.FocusedRowHandle)

        Dim oDoc As New CGenDoc("QCM_Fiche_Edition", "exec api_sp_ImpQCMFiche " + dtrow.Item("NIDQCMNUM").ToString)
        If oDoc.p_ERROR = "" Then
            Dim ofrmVisuFic As New frmVisuDoc(oDoc.p_PathFileName)
            ofrmVisuFic.ShowDialog()
        End If

    End Sub

    Private Sub BtnResultatsByQCMCandidat_Click(sender As System.Object, e As System.EventArgs) Handles BtnResultatsByQCMCandidat.Click

        'If DGVTestConnaissances.SelectedRows.Count > 0 Then

        '    Select Case DGVTestConnaissances.SelectedRows.Item(0).Cells("NQCMTYPEID").Value

        '        Case 1

        '            Dim ofrmQCMResultatsByQCM As New frmQCMListeResultByQCMCandidat(DGVTestConnaissances.SelectedRows.Item(0).Cells("NIDQCMNUM").Value, DGVTestConnaissances.SelectedRows.Item(0).Cells("VQCMTITRE").Value, DGVTestConnaissances.SelectedRows.Item(0).Cells("NQCMTYPEID").Value)
        '            ofrmQCMResultatsByQCM.ShowDialog()
        '            ofrmQCMResultatsByQCM.Dispose()

        '        Case 2

        '            Dim ofrmCauserieResultatsByQCM As New frmCauserieListeResultByQCM(DGVTestConnaissances.SelectedRows.Item(0).Cells("NIDQCMNUM").Value, DGVTestConnaissances.SelectedRows.Item(0).Cells("VQCMTITRE").Value, DGVTestConnaissances.SelectedRows.Item(0).Cells("NQCMTYPEID").Value)
        '            ofrmCauserieResultatsByQCM.ShowDialog()
        '            ofrmCauserieResultatsByQCM.Dispose()

        '        Case Else

        '            MessageBox.Show(My.Resources.Global_type_nonreconnu, My.Resources.Global_Erreur, MessageBoxButtons.OK, MessageBoxIcon.Error)

        '    End Select

        'Else
        '    MessageBox.Show(oListMsg.ReturnMsg(6), My.Resources.Global_Erreur, MessageBoxButtons.OK, MessageBoxIcon.Error)
        'End If

        If GVListeQCM.SelectedRowsCount = 0 Then MessageBox.Show("Il faut sélectionner un QCM", My.Resources.Global_Erreur, MessageBoxButtons.OK, MessageBoxIcon.Error) : Exit Sub

        Dim dtrow As DataRow = GVListeQCM.GetDataRow(GVListeQCM.FocusedRowHandle)

        Select Case dtrow.Item("NQCMTYPEID")

            Case 1

                Dim ofrmQCMResultatsByQCM As New frmQCMListeResultByQCMCandidat(dtrow.Item("NIDQCMNUM"), dtrow.Item("VQCMTITRE"), dtrow.Item("NQCMTYPEID"))
                ofrmQCMResultatsByQCM.ShowDialog()
                ofrmQCMResultatsByQCM.Dispose()

            Case 2

                Dim ofrmCauserieResultatsByQCM As New frmCauserieListeResultByQCM(dtrow.Item("NIDQCMNUM"), dtrow.Item("VQCMTITRE"), dtrow.Item("NQCMTYPEID"))
                ofrmCauserieResultatsByQCM.ShowDialog()
                ofrmCauserieResultatsByQCM.Dispose()

            Case Else

                MessageBox.Show(My.Resources.Global_type_nonreconnu, My.Resources.Global_Erreur, MessageBoxButtons.OK, MessageBoxIcon.Error)

        End Select



    End Sub

    'Private Sub DGVTestConnaissances_SelectionChanged(sender As Object, e As System.EventArgs) Handles DGVTestConnaissances.SelectionChanged

    '    'on cache le bouton si qcm non present pour les candidats
    '    If DGVTestConnaissances.SelectedRows.Count > 0 Then

    '        If DGVTestConnaissances.SelectedRows.Item(0).Cells("BQCMRECRU").Value = True Then

    '            BtnResultatsByQCMCandidat.Visible = True

    '        Else

    '            BtnResultatsByQCMCandidat.Visible = False

    '        End If

    '    Else

    '        BtnResultatsByQCMCandidat.Visible = True

    '    End If

    'End Sub
    Private Sub GVListeQCM_FocusedRowChanged(sender As Object, e As FocusedRowChangedEventArgs) Handles GVListeQCM.FocusedRowChanged

        'on cache le bouton si qcm non present pour les candidats
        If GVListeQCM.SelectedRowsCount > 0 Then

            Dim dtrow As DataRow = GVListeQCM.GetDataRow(GVListeQCM.FocusedRowHandle)

            If dtrow Is Nothing Then Return

            If dtrow.Item("BQCMRECRU") = True Then

                BtnResultatsByQCMCandidat.Visible = True

            Else

                BtnResultatsByQCMCandidat.Visible = False

            End If

        Else

            BtnResultatsByQCMCandidat.Visible = True

        End If

    End Sub

    Private Sub BtnDupliqQCM_Click(sender As Object, e As EventArgs) Handles BtnDupliqQCM.Click

        'on cache le bouton si qcm non present pour les candidats
        If GVListeQCM.SelectedRowsCount > 0 Then

            Dim dtrow As DataRow = GVListeQCM.GetDataRow(GVListeQCM.FocusedRowHandle)

            If MessageBox.Show("Voulez-vous dupliquer ce QCM ?", "Confirmation duplication", MessageBoxButtons.YesNoCancel, MessageBoxIcon.Question) = DialogResult.Yes Then

                Dim sNewQCMNOM As String = InputBox("Nouveau libellé QCM : ", "Titre QCM", dtrow.Item("VQCMTITRE"))

                If sNewQCMNOM = "" Then Return

        Dim sqlcmddupliq As New SqlCommand("[api_sp_QCM_Duplication]", MozartDatabase.cnxMozart)
        sqlcmddupliq.CommandType = CommandType.StoredProcedure
                sqlcmddupliq.Parameters.Add("@IDQCMNUM_SRC", SqlDbType.Int).Value = dtrow.Item("NIDQCMNUM")
                sqlcmddupliq.Parameters.Add("@NEW_LIBELLEQCM", SqlDbType.VarChar).Value = sNewQCMNOM
                sqlcmddupliq.ExecuteNonQuery()

                LoadData()

                MessageBox.Show("Duplication effectuée avec succès")

            End If

        End If

    End Sub

    Private Sub BtnAnalyse_Click(sender As Object, e As EventArgs) Handles BtnAnalyse.Click

        If GVListeQCM.SelectedRowsCount = 0 Then MessageBox.Show("Il faut sélectionner un QCM", My.Resources.Global_Erreur, MessageBoxButtons.OK, MessageBoxIcon.Error) : Exit Sub

        Dim dtrow As DataRow = GVListeQCM.GetDataRow(GVListeQCM.FocusedRowHandle)

        Dim ofrmQCMAnalyseResultat As New frmQCMAnalyseResultat(dtrow.Item("NIDQCMNUM"), dtrow.Item("VQCMTITRE"), dtrow.Item("NQCMTYPEID"))
        ofrmQCMAnalyseResultat.ShowDialog()

    End Sub

    Private Sub BtnAffectPers_Click(sender As Object, e As EventArgs) Handles BtnAffectPers.Click

        Dim oFrmAffectPers As New frmQCMAffectPers
        oFrmAffectPers.ShowDialog()

    End Sub

  Private Sub BtnCopyToFiliale_Click(sender As Object, e As EventArgs) Handles BtnCopyToFiliale.Click

    If GVListeQCM.SelectedRowsCount = 0 Then MessageBox.Show("Il faut sélectionner un QCM", My.Resources.Global_Erreur, MessageBoxButtons.OK, MessageBoxIcon.Error) : Exit Sub

    Dim dtrow As DataRow = GVListeQCM.GetDataRow(GVListeQCM.FocusedRowHandle)

    Dim ofrmQCM_Copy_To_Filiale As New frmQCM_Copy_To_Filiale(dtrow.Item("NIDQCMNUM"))
    ofrmQCM_Copy_To_Filiale.ShowDialog()

  End Sub

  Private Sub BtnResultSTF_Click(sender As Object, e As EventArgs) Handles BtnResultSTF.Click

    If GVListeQCM.SelectedRowsCount = 0 Then MessageBox.Show("Il faut sélectionner un QCM", My.Resources.Global_Erreur, MessageBoxButtons.OK, MessageBoxIcon.Error) : Exit Sub

    Dim dtrow As DataRow = GVListeQCM.GetDataRow(GVListeQCM.FocusedRowHandle)

    Select Case dtrow.Item("NQCMTYPEID")

      Case 1

        Dim ofrmQCMResultatsByQCM As New frmQCMListeResultByQCM(dtrow.Item("NIDQCMNUM"), dtrow.Item("VQCMTITRE"), dtrow.Item("NQCMTYPEID"), True)
        ofrmQCMResultatsByQCM.ShowDialog()
        ofrmQCMResultatsByQCM.Dispose()

      Case 2

        Dim ofrmCauserieResultatsByQCM As New frmCauserieListeResultByQCM(dtrow.Item("NIDQCMNUM"), dtrow.Item("VQCMTITRE"), dtrow.Item("NQCMTYPEID"), True)
        ofrmCauserieResultatsByQCM.ShowDialog()
        ofrmCauserieResultatsByQCM.Dispose()

      Case Else

        MessageBox.Show(My.Resources.Global_type_nonreconnu, My.Resources.Global_Erreur, MessageBoxButtons.OK, MessageBoxIcon.Error)

    End Select

  End Sub
End Class
