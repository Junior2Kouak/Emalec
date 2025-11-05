Imports System.Data.SqlClient
Imports DevExpress.XtraPrinting
Imports MozartLib

Public Class frmQCMListeResultByQCMCandidat

  Dim CnxQCMListeDet As New CGestionSQL

  Dim sQCMNOM As String
  Dim iNIDCQMNUM As Integer
  Dim iNIDQCMTYPE As Int16

  Dim bArchives As Boolean
  Dim dt As DataTable

  'constructeur de la classe avec 2 paramtres
  Public Sub New(ByVal c_iNIDCQMNUM As Object, ByVal c_sQCMNOM As Object, ByVal c_NIDQCMTYPE As Object)
    InitializeComponent()
    iNIDCQMNUM = Convert.ToInt32(c_iNIDCQMNUM)
    sQCMNOM = c_sQCMNOM.ToString
    iNIDQCMTYPE = Convert.ToInt16(c_NIDQCMTYPE)
  End Sub

  Private Sub frmQCMListeResultByQCMCandidat_FormClosing(ByVal sender As Object, ByVal e As System.Windows.Forms.FormClosingEventArgs) Handles Me.FormClosing
    CnxQCMListeDet.CloseConnexionSQL()
  End Sub

  Private Sub frmQCMListeResultByQCMCandidat_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load

    Try

      'init 
      Initboutons(Me)
      bArchives = False
      BtnEditRep.Visible = False
      BtnDetail.Visible = False


      Me.Text = My.Resources.TestCompétance_QCMListeResultByQCMCandidat_liste & sQCMNOM
      LblTitre.Text = My.Resources.TestCompétance_QCMListeResultByQCMCandidat_liste & sQCMNOM

      If CnxQCMListeDet.ConnexionSQL(MozartParams.NomServeur, MozartParams.NomSociete) = True Then

        'load des donnees
        LoadDataGridView()

      Else

        MessageBox.Show(My.Resources.Global_serveur_EMALEC, My.Resources.Global_Erreur, MessageBoxButtons.OK, MessageBoxIcon.Error)

      End If

    Catch ex As Exception

      MessageBox.Show(My.Resources.TestCompétance_QCMListeResultByQCMCandidat_sub + ex.Message, My.Resources.Global_Erreur, MessageBoxButtons.OK, MessageBoxIcon.Error)

    End Try

  End Sub
  '*************************************************************************************************************************************
  'Cette sub permet de charger les 3 tables de la proc, on les load dans un dataset ou l on definit les relations entre les tables
  ' et permettre l affichage groupe
  '*************************************************************************************************************************************
  Private Sub LoadDataGridView(Optional ByVal p_RowFocusedHandle As Int32 = -1)

    dt = New DataTable

    Dim cmdLoadList As New SqlCommand("[api_sp_ListeQCMByQCMCandidat]", CnxQCMListeDet.CnxSQLOpen)
    cmdLoadList.CommandType = CommandType.StoredProcedure
    'sqlcmd
    cmdLoadList.Parameters.Add("P_NIDQCMNUM", SqlDbType.Int)
    cmdLoadList.Parameters("P_NIDQCMNUM").Value = iNIDCQMNUM
    cmdLoadList.Parameters.Add("iStep", SqlDbType.Int)
    cmdLoadList.Parameters("iStep").Value = 2

    dt.Load(cmdLoadList.ExecuteReader)

    GCQCM.DataSource = dt

    If p_RowFocusedHandle >= 0 Then GVQCM.FocusedRowHandle = p_RowFocusedHandle

  End Sub

  Private Sub BtnEditRep_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles BtnEditRep.Click

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

      Dim ofrmQCMDetResult As New frmQCMDetailResult(drSelect.Item("NIDFICQCM"), drSelect.Item("NIDQCMNUM"), sQCMNOM, iNIDQCMTYPE, drSelect.Item("VNOMTECH"), True)
      ofrmQCMDetResult.ShowDialog()
      ofrmQCMDetResult.Dispose()

      'on recharge            
      LoadDataGridView(GVQCM.FocusedRowHandle)

    Else
      MessageBox.Show(My.Resources.Global_select_tech, My.Resources.Global_Erreur, MessageBoxButtons.OK, MessageBoxIcon.Error)
    End If

  End Sub

  Private Sub BtnFermer_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles BtnFermer.Click

    Me.Close()

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