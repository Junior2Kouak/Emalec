Imports System.Data.SqlClient
Imports DevExpress.XtraPrinting
Imports MozartLib

Public Class frmCauserieListeResultByQCM

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
      bArchives = False
      BtnEditRep.Visible = False
      BtnDetail.Visible = False

      Me.Text = My.Resources.TestCompétance_frmCauserieListeResultByQCM_list_tech & sQCMNOM
      LblTitre.Text = My.Resources.TestCompétance_frmCauserieListeResultByQCM_list_tech & vbCrLf & sQCMNOM

      If CnxQCMListeDet.ConnexionSQL(MozartParams.NomServeur, MozartParams.NomSociete) = True Then

        'load des donnees
        LoadDataGridView()

      Else

        MessageBox.Show(My.Resources.Global_serveur_EMALEC, My.Resources.Global_Erreur, MessageBoxButtons.OK, MessageBoxIcon.Error)

      End If

    Catch ex As Exception

      MessageBox.Show(My.Resources.TestCompétance_frmCauserieListeResultByQCM_sub + ex.Message, My.Resources.Global_Erreur, MessageBoxButtons.OK, MessageBoxIcon.Error)

    End Try

  End Sub

  '*************************************************************************************************************************************
  'Cette sub permet de charger les 3 tables de la proc, on les load dans un dataset ou l on definit les relations entre les tables
  ' et permettre l affichage groupe
  '*************************************************************************************************************************************
  Private Sub LoadDataGridView()

    Dim RowHdl As Int32 = -1

    If GVCAUSERIE.SelectedRowsCount > 0 And GVCAUSERIE.FocusedRowHandle >= 0 Then RowHdl = GVCAUSERIE.GetSelectedRows(0)
    Dim SvgTopRowIndex As Int32 = GVCAUSERIE.TopRowIndex
    GVCAUSERIE.GetVisibleIndex(RowHdl)

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

    GCol_VSTFNOM.Visible = _STF

    GCCAUSERIE.DataSource = dt

    GVCAUSERIE.FocusedRowHandle = RowHdl
    GVCAUSERIE.TopRowIndex = SvgTopRowIndex

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

    If GVCAUSERIE.SelectedRowsCount > 0 And GVCAUSERIE.FocusedRowHandle >= 0 Then

      'pour l edition il faut que la correction soir valider par le tech et signé
      If Not GVCAUSERIE.GetDataRow(GVCAUSERIE.GetSelectedRows(0)).Item("DRETCORRECTSIGNTECH") Is DBNull.Value Then

        'si validation pour la première fois alors on sauvegarde la validation
        'If GVCAUSERIE.GetDataRow(GVCAUSERIE.GetSelectedRows(0)).Item("DFICQCMVISACORRECT") Is DBNull.Value Then SaveValidationDirection(GVCAUSERIE.GetDataRow(GVCAUSERIE.GetSelectedRows(0)).Item("NIDFICQCM"))

        Dim oDoc As New CGenDoc("Causerie_Fiche_Edition_Result_Signature", GVCAUSERIE.GetDataRow(GVCAUSERIE.GetSelectedRows(0)).Item("NIDFICQCM"), iNIDCQMNUM)
        If oDoc.p_ERROR = "" Then
          'Dim ofrmVisuFic As New frmVisuDoc(oDoc.p_PathFileName)
          '    ofrmVisuFic.ShowDialog()

          Dim startInfo As New ProcessStartInfo(oDoc.p_PathFileName)
          startInfo.WindowStyle = ProcessWindowStyle.Normal
          Process.Start(startInfo)

        End If

        'LoadDataGridView()

      Else
        MessageBox.Show(My.Resources.Global_retour_auteur, My.Resources.Global_Erreur, MessageBoxButtons.OK, MessageBoxIcon.Error)
      End If

    Else
      MessageBox.Show("Il faut sélectionner un technicien !", My.Resources.Global_Erreur, MessageBoxButtons.OK, MessageBoxIcon.Error)
    End If

  End Sub

  Private Sub SaveValidationDirection(ByVal p_NIDFICQCMNUM As Int32)

    Dim sqlcmdupdate As New SqlCommand("api_sp_QCMSaveValidationDirection", CnxQCMListeDet.CnxSQLOpen)

    sqlcmdupdate.CommandType = CommandType.StoredProcedure
    sqlcmdupdate.Parameters.Add("@P_NIDFICQCMNUM", SqlDbType.Int)
    sqlcmdupdate.Parameters("@P_NIDFICQCMNUM").Value = p_NIDFICQCMNUM

    sqlcmdupdate.ExecuteNonQuery()

  End Sub

  Private Sub BtnDetail_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles BtnDetail.Click

    If GVCAUSERIE.SelectedRowsCount > 0 And GVCAUSERIE.FocusedRowHandle >= 0 Then

      Dim drSelect As DataRow = GVCAUSERIE.GetDataRow(GVCAUSERIE.GetSelectedRows(0))
      Dim bReadOnly As Boolean = False

      If Not drSelect.Item("DVALIDCORRECTENVOI") Is DBNull.Value Then bReadOnly = True

      Dim ofrmCauserieDetResult As New frmCauserieDetailResult(drSelect.Item("NIDFICQCM"), drSelect.Item("NIDQCMNUM"), sQCMNOM, iNIDQCMTYPE, drSelect.Item("VNOMTECH"), bReadOnly)
      ofrmCauserieDetResult.ShowDialog()
      ofrmCauserieDetResult.Dispose()

      'on recharge            
      LoadDataGridView()

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
      LoadDataGridView()

    End If

  End Sub

  Private Sub BtnFermer_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles BtnFermer.Click

    If bArchives = False Then
      Me.Close()
    Else
      bArchives = Not bArchives
      Me.Text = My.Resources.TestCompétance_frmCauserieListeResultByQCM_list_tech & sQCMNOM
      LblTitre.Text = My.Resources.TestCompétance_frmCauserieListeResultByQCM_list_tech & sQCMNOM
      BtnArchives.Visible = True
      LoadDataGridView()
    End If

  End Sub

  'Private Sub BtnCTRL_Click(ByVal sender As System.Object, ByVal e As System.EventArgs)

  '    If GVCAUSERIE.SelectedRowsCount > 0 And GVCAUSERIE.FocusedRowHandle >= 0 Then

  '        Dim RowHdl As Int32 = GVCAUSERIE.GetSelectedRows(0)
  '        Dim drSelect As DataRow = GVCAUSERIE.GetDataRow(RowHdl)

  '        If drSelect.Item("NBREPNOVERIF") > 0 Or Not drSelect.Item("DVALIDCORRECTENVOI") Is DBNull.Value Then

  '            If drSelect.Item("NBREPNOVERIF") > 0 Then
  '                MessageBox.Show("La validation pour envoi est impossible. Il reste des réponses à contrôler !", "Erreur - Validation", MessageBoxButtons.OK, MessageBoxIcon.Exclamation)
  '                Exit Sub
  '            End If

  '            If Not drSelect.Item("DVALIDCORRECTENVOI") Is DBNull.Value Then
  '                MessageBox.Show("La correction a déjà été envoyée !", "Erreur - Validation", MessageBoxButtons.OK, MessageBoxIcon.Exclamation)
  '                Exit Sub
  '            End If

  '        Else

  '            'SaveVisaDO(iNIDFICQCMNUM, drSelect.Item("NIDQCMQUESTION"), Now)
  '            Dim sqlupdate As New SqlCommand("api_sp_QCMValidationCorrection", CnxQCMListeDet.CnxSQLOpen)
  '            sqlupdate.CommandType = CommandType.StoredProcedure
  '            sqlupdate.Parameters.Add("@P_NIDFICQCMNUM", SqlDbType.Int)
  '            sqlupdate.Parameters("@P_NIDFICQCMNUM").Value = drSelect.Item("NIDFICQCM")

  '            sqlupdate.ExecuteNonQuery()

  '            LoadDataGridView()

  '        End If

  '    Else

  '        MessageBox.Show("Il faut sélectionner une causerie !", "Erreur", MessageBoxButtons.OK, MessageBoxIcon.Error)

  '    End If

  'End Sub

  Private Sub GVCAUSERIE_RowClick(sender As Object, e As DevExpress.XtraGrid.Views.Grid.RowClickEventArgs) Handles GVCAUSERIE.RowClick

    If e.RowHandle >= 0 Then
      If Not GVCAUSERIE.GetDataRow(e.RowHandle).Item("DRETCORRECTSIGNTECH") Is DBNull.Value Then
        BtnEditRep.Visible = True
      Else
        BtnEditRep.Visible = False
      End If

      If Not GVCAUSERIE.GetDataRow(e.RowHandle).Item("DFICQCMTERM") Is DBNull.Value Then
        BtnDetail.Visible = True
      Else
        BtnDetail.Visible = False
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

      GVCAUSERIE.OptionsPrint.ExpandAllDetails = True
      GVCAUSERIE.OptionsPrint.PrintDetails = True
      Dim opt As XlsxExportOptionsEx = New XlsxExportOptionsEx()
      opt.ExportType = DevExpress.Export.ExportType.WYSIWYG
      GVCAUSERIE.ExportToXlsx(SDF.FileName, opt)

    End If
  End Sub
End Class