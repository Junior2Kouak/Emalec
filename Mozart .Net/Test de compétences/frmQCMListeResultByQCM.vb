Imports System.Data.SqlClient
Imports DevExpress.XtraPrinting
Imports MozartLib

Public Class frmQCMListeResultByQCM

  Dim CnxQCMListeDet As New CGestionSQL

  Dim sQCMNOM As String
  Dim iNIDCQMNUM As Integer
  Dim iNIDQCMTYPE As Int16
  Dim _STF As Boolean

  Dim bArchives As Boolean
  Dim dt As DataTable

  'constructeur de la classe avec 2 paramtres
  Public Sub New(ByVal c_iNIDCQMNUM As Object, ByVal c_sQCMNOM As Object, ByVal c_NIDQCMTYPE As Object, Optional ByVal c_STF As Boolean = False)
    InitializeComponent()
    iNIDCQMNUM = Convert.ToInt32(c_iNIDCQMNUM)
    sQCMNOM = c_sQCMNOM.ToString
    iNIDQCMTYPE = Convert.ToInt16(c_NIDQCMTYPE)
    _STF = c_STF
  End Sub

  Private Sub frmQCMListeResultByQCM_FormClosing(ByVal sender As Object, ByVal e As System.Windows.Forms.FormClosingEventArgs) Handles Me.FormClosing
    CnxQCMListeDet.CloseConnexionSQL()
  End Sub

  Private Sub frmQCMListeResultByQCM_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load

    Try

      'init 
      Initboutons(Me)
      bArchives = False
      BtnEditRep.Visible = False
      BtnDetail.Visible = False


      Me.Text = My.Resources.TestCompétance_QCMListeResultByQCM_liste & " " & sQCMNOM
      LblTitre.Text = My.Resources.TestCompétance_QCMListeResultByQCM_liste & " " & sQCMNOM

      If CnxQCMListeDet.ConnexionSQL(MozartParams.NomServeur, MozartParams.NomSociete) = True Then

        'load des donnees
        LoadDataGridView()
        Cursor = Cursors.Default
      Else

        MessageBox.Show(My.Resources.Global_serveur_EMALEC, My.Resources.Global_Erreur, MessageBoxButtons.OK, MessageBoxIcon.Error)

      End If

    Catch ex As Exception

      MessageBox.Show(My.Resources.TestCompétance_QCMListeResultByQCM_sub + ex.Message, My.Resources.Global_Erreur, MessageBoxButtons.OK, MessageBoxIcon.Error)
      Cursor = Cursors.Default
    End Try

  End Sub
  '*************************************************************************************************************************************
  'Cette sub permet de charger les 3 tables de la proc, on les load dans un dataset ou l on definit les relations entre les tables
  ' et permettre l affichage groupe
  '*************************************************************************************************************************************
  Private Sub LoadDataGridView(Optional ByVal p_RowFocusedHandle As Int32 = -1)

    dt = New DataTable

    Dim cmdLoadList As New SqlCommand("api_sp_ListeQCMByQCM", CnxQCMListeDet.CnxSQLOpen)
    cmdLoadList.CommandType = CommandType.StoredProcedure
    cmdLoadList.CommandTimeout = 150
    'sqlcmd
    cmdLoadList.Parameters.Add("P_NIDQCMNUM", SqlDbType.Int)
    cmdLoadList.Parameters("P_NIDQCMNUM").Value = iNIDCQMNUM
    cmdLoadList.Parameters.Add("iStep", SqlDbType.Int)
    cmdLoadList.Parameters("iStep").Value = 2
    cmdLoadList.Parameters.Add("c_CPERACTIF", SqlDbType.VarChar)
    cmdLoadList.Parameters("c_CPERACTIF").Value = ReturnPerInActif(bArchives)
    cmdLoadList.Parameters.Add("@P_STF", SqlDbType.Bit).Value = _STF

    dt.Load(cmdLoadList.ExecuteReader)

      GCQCM.DataSource = dt

    GCOL_VSTFNOM.Visible = _STF

    If p_RowFocusedHandle >= 0 Then GVQCM.FocusedRowHandle = p_RowFocusedHandle

  End Sub

  Private Function ReturnPerInActif(ByVal sValue As Boolean) As String

    Select Case sValue
      Case True
        Return "N"
      Case Else
        Return "O"
    End Select

  End Function

  Private Sub BtnEditRep_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles BtnEditRep.Click

    'If GVQCM.SelectedRowsCount > 0 And GVQCM.FocusedRowHandle >= 0 Then

    '    'pour l edition il faut que la correction soir valider par le tech et signé
    '    If Not GVQCM.GetDataRow(GVQCM.GetSelectedRows(0)).Item("DRETCORRECTSIGNTECH") Is DBNull.Value Then

    '        'si validation pour la première fois alors on sauvegarde la validation
    '        'If GVCAUSERIE.GetDataRow(GVCAUSERIE.GetSelectedRows(0)).Item("DFICQCMVISACORRECT") Is DBNull.Value Then SaveValidationDirection(GVCAUSERIE.GetDataRow(GVCAUSERIE.GetSelectedRows(0)).Item("NIDFICQCM"))

    '        'Dim oDoc As New CGenDoc("Causerie_Fiche_Edition_Result_Signature", GVQCM.GetDataRow(GVQCM.GetSelectedRows(0)).Item("NIDFICQCM"), iNIDCQMNUM)
    '        'If oDoc.p_ERROR = "" Then
    '        '    Dim ofrmVisuFic As New frmVisuDoc(oDoc.p_PathFileName)
    '        '    ofrmVisuFic.ShowDialog()
    '        'End If

    '        LoadDataGridView()

    '    Else
    '        MessageBox.Show("En attente du retour de l'auteur de la réponse !", "Erreur", MessageBoxButtons.OK, MessageBoxIcon.Error)
    '    End If

    'Else
    '    MessageBox.Show("Il faut sélectionner un technicien !", "Erreur", MessageBoxButtons.OK, MessageBoxIcon.Error)
    'End If

    If GVQCM.SelectedRowsCount > 0 Then

      Dim oDoc As New CGenDoc("QCM_Fiche_Edition_Result_Signature", GVQCM.GetDataRow(GVQCM.GetSelectedRows(0)).Item("NIDFICQCM").ToString, iNIDCQMNUM)
      If oDoc.p_ERROR = "" Then
        Dim startInfo As New ProcessStartInfo(oDoc.p_PathFileName)
        startInfo.WindowStyle = ProcessWindowStyle.Normal
        Process.Start(startInfo)
        'Dim ofrmVisuFic As New frmVisuDoc(oDoc.p_PathFileName)
        'ofrmVisuFic.ShowDialog()
      End If

    Else
      MessageBox.Show(My.Resources.Global_select_tech, My.Resources.Global_Erreur, MessageBoxButtons.OK, MessageBoxIcon.Error)
    End If

  End Sub

  Private Sub BtnDetail_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles BtnDetail.Click

    If GVQCM.SelectedRowsCount > 0 Then

      Dim drSelect As DataRow = GVQCM.GetDataRow(GVQCM.GetSelectedRows(0))

      Dim ofrmQCMDetResult As New frmQCMDetailResult(drSelect.Item("NIDFICQCM"), drSelect.Item("NIDQCMNUM"), sQCMNOM, iNIDQCMTYPE, drSelect.Item("VNOMTECH"), False)
      ofrmQCMDetResult.ShowDialog()
      ofrmQCMDetResult.Dispose()

      'on recharge            
      LoadDataGridView(GVQCM.FocusedRowHandle)

    Else
      MessageBox.Show(My.Resources.Global_select_tech, My.Resources.Global_Erreur, MessageBoxButtons.OK, MessageBoxIcon.Error)
    End If

  End Sub

  Private Sub BtnArchives_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles BtnArchives.Click

    bArchives = Not bArchives

    'nom de la fenetre
    If bArchives = True Then
      Me.Text = My.Resources.Global_list_tech_archivé & sQCMNOM
      LblTitre.Text = My.Resources.Global_list_tech_archivé & sQCMNOM
      BtnArchives.Visible = False

      LoadDataGridView(GVQCM.FocusedRowHandle)

    End If

  End Sub

  Private Sub BtnFermer_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles BtnFermer.Click

    If bArchives = False Then
      Me.Close()
    Else
      bArchives = Not bArchives
      Me.Text = My.Resources.TestCompétance_QCMListeResultByQCM_liste & sQCMNOM
      LblTitre.Text = My.Resources.TestCompétance_QCMListeResultByQCM_liste & sQCMNOM
      BtnArchives.Visible = True
      LoadDataGridView(GVQCM.FocusedRowHandle)
    End If

  End Sub

  Private Sub BtnCTRL_Click(ByVal sender As System.Object, ByVal e As System.EventArgs)

    'If GVQCM.SelectedRowsCount > 0 Then

    '    Dim RowHdl As int32 = GVQCM.GetSelectedRows(0)
    '    Dim SvgTopRowIndex As Int32 = GVQCM.TopRowIndex 
    '    GVQCM.GetVisibleIndex(RowHdl) 

    '    Dim drSelect As DataRow = GVQCM.GetDataRow(RowHdl)

    '    Dim sqlupdate As New SqlCommand("api_sp_QCMSaveAllVISA_DO", CnxQCMListeDet.CnxSQLOpen)
    '    sqlupdate.CommandType = CommandType.StoredProcedure 
    '    sqlupdate.Parameters.Add("@P_NIDFICQCMNUM", SqlDbType.Int) 
    '    sqlupdate.Parameters.Add("@P_DVISA_DO", SqlDbType.DateTime)
    '    sqlupdate.Parameters("@P_NIDFICQCMNUM").Value = drSelect.Item("NIDFICQCM")
    '    sqlupdate.Parameters("@P_DVISA_DO").Value = Now

    '    sqlupdate.ExecuteNonQuery 

    '    LoadDataGridView 

    '    'on reselectionne la ligne            
    '    GVQCM.FocusedRowHandle = RowHdl
    '    GVQCM.TopRowIndex = SvgTopRowIndex

    'Else

    '    MessageBox.Show("Il faut sélectionner un qcm !", "Erreur", MessageBoxButtons.OK, MessageBoxIcon.Error)   

    'End If

  End Sub

  Private Sub GVQCM_RowClick(sender As Object, e As DevExpress.XtraGrid.Views.Grid.RowClickEventArgs) Handles GVQCM.RowClick

    If e.RowHandle >= 0 Then
      'If Not GVQCM.GetDataRow(e.RowHandle).Item("DRETCORRECTSIGNTECH") Is DBNull.Value Then
      '    BtnEditRep.Visible = True
      'Else
      '    BtnEditRep.Visible = True
      'End If

      If Not GVQCM.GetDataRow(e.RowHandle).Item("DFICQCMTERM") Is DBNull.Value Then
        BtnDetail.Visible = True
        BtnEditRep.Visible = True
      Else
        BtnDetail.Visible = False
        BtnEditRep.Visible = False
      End If

    Else

      BtnEditRep.Visible = False
      BtnDetail.Visible = False

    End If

  End Sub
  Private Sub BtnExportXLSX_Click(sender As Object, e As EventArgs) Handles BtnExportXLSX.Click

    SDF.FileName = ""
    SDF.Filter = "Fichiers EXCEL (*.xlsx)|*.xlsx"
    SDF.ShowDialog()

    If SDF.FileName <> "" Then

      GVQCM.OptionsPrint.ExpandAllDetails = True
      GVQCM.OptionsPrint.PrintDetails = True
      Dim opt As XlsxExportOptionsEx = New XlsxExportOptionsEx()
      opt.ExportType = DevExpress.Export.ExportType.WYSIWYG
      GVQCM.ExportToXlsx(SDF.FileName, opt)

    End If

  End Sub
End Class