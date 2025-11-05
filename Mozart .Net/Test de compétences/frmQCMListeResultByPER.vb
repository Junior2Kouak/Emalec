Imports System.Data.SqlClient
Imports DevExpress.XtraPrinting
Imports MozartLib

Public Class frmQCMListeResultByPER

  Dim CnxQCMListeDet As New CGestionSQL

  Dim sVPERNOM As String
  Dim iNPERNUM As Integer
  Dim iNIDQCMTYPE As Int16

  Dim bActif As Boolean
  Dim dt As DataTable

  'constructeur de la classe avec 2 paramtres
  Public Sub New(ByVal c_iNPERNUM As Object, ByVal c_sVPERNOM As Object, ByVal c_NIDQCMTYPE As Object)
    InitializeComponent()
    iNPERNUM = Convert.ToInt32(c_iNPERNUM)
    sVPERNOM = c_sVPERNOM.ToString
    iNIDQCMTYPE = Convert.ToInt16(c_NIDQCMTYPE)
  End Sub

  Private Sub frmQCMListeResultByPER_FormClosing(ByVal sender As Object, ByVal e As System.Windows.Forms.FormClosingEventArgs) Handles Me.FormClosing
    CnxQCMListeDet.CloseConnexionSQL()
  End Sub

  Private Sub frmQCMListeResultByPER_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load

    Try

      'init 
      bActif = True
      BtnEditRep.Visible = False
      BtnDetail.Visible = False

      Me.Text = My.Resources.TestCompétance_QCMListeResultByPers_Liste & sVPERNOM
      LblTitre.Text = My.Resources.TestCompétance_QCMListeResultByPers_Liste & sVPERNOM

      If CnxQCMListeDet.ConnexionSQL(MozartParams.NomServeur, MozartParams.NomSociete) = True Then

        Cursor = Cursors.WaitCursor
        'load des donnees
        LoadDataGridView()
        Cursor = Cursors.Default

      Else

        MessageBox.Show(My.Resources.Global_serveur_EMALEC, My.Resources.Global_Erreur, MessageBoxButtons.OK, MessageBoxIcon.Error)

      End If

    Catch ex As Exception
      Cursor = Cursors.Default
      MessageBox.Show(My.Resources.TestCompétance_QCMListeResultByPers_sub + ex.Message, My.Resources.Global_Erreur, MessageBoxButtons.OK, MessageBoxIcon.Error)

    End Try


  End Sub

  '*************************************************************************************************************************************
  'Cette sub permet de charger les 3 tables de la proc, on les load dans un dataset ou l on definit les relations entre les tables
  ' et permettre l affichage groupe
  '*************************************************************************************************************************************
  Private Sub LoadDataGridView(Optional ByVal p_RowFocusedHandle As Int32 = -1)

    dt = New DataTable

    Dim cmdLoadList As New SqlCommand("api_sp_ListeQCMByPer", CnxQCMListeDet.CnxSQLOpen)
    cmdLoadList.CommandType = CommandType.StoredProcedure
    'sqlcmd        
    cmdLoadList.Parameters.Add("npernum", SqlDbType.Int)
    cmdLoadList.Parameters("npernum").Value = iNPERNUM
    cmdLoadList.Parameters.Add("@NQCMTYPEID", SqlDbType.Int)
    cmdLoadList.Parameters("@NQCMTYPEID").Value = iNIDQCMTYPE
    cmdLoadList.Parameters.Add("iStep", SqlDbType.Int)
    cmdLoadList.Parameters("iStep").Value = 2
    cmdLoadList.Parameters.Add("@c_BQCMACTIF", SqlDbType.Bit)
    cmdLoadList.Parameters("@c_BQCMACTIF").Value = bActif

    dt.Load(cmdLoadList.ExecuteReader)

    GCQCM.DataSource = dt

    If p_RowFocusedHandle >= 0 Then GVQCM.FocusedRowHandle = p_RowFocusedHandle

  End Sub

  Private Sub BtnEditRep_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles BtnEditRep.Click

    If GVQCM.SelectedRowsCount > 0 Then

      Dim drSelect As DataRow = GVQCM.GetDataRow(GVQCM.GetSelectedRows(0))

      Dim oDoc As New CGenDoc("QCM_Fiche_Edition_Result_Signature", drSelect.Item("NIDFICQCM").ToString, drSelect.Item("NIDQCMNUM"))
      If oDoc.p_ERROR = "" Then
        Dim startInfo As New ProcessStartInfo(oDoc.p_PathFileName)
        startInfo.WindowStyle = ProcessWindowStyle.Normal
        Process.Start(startInfo)

        '        Dim ofrmVisuFic As New frmVisuDoc(oDoc.p_PathFileName)
        '       ofrmVisuFic.ShowDialog()
      End If

    Else
      MessageBox.Show(My.Resources.TestCompétance_QCMListeResultByPers_select_QCM, My.Resources.Global_Erreur, MessageBoxButtons.OK, MessageBoxIcon.Error)
    End If

  End Sub

  Private Sub BtnDetail_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles BtnDetail.Click

    If GVQCM.SelectedRowsCount > 0 Then

      Dim drSelect As DataRow = GVQCM.GetDataRow(GVQCM.GetSelectedRows(0))

      Dim ofrmQCMDetResult As New frmQCMDetailResult(drSelect.Item("NIDFICQCM"), drSelect.Item("NIDQCMNUM"), drSelect.Item("VQCMTITRE"), iNIDQCMTYPE, sVPERNOM, False)
      ofrmQCMDetResult.ShowDialog()
      ofrmQCMDetResult.Dispose()

      'on recharge            
      LoadDataGridView(GVQCM.FocusedRowHandle)

    Else
      MessageBox.Show(My.Resources.TestCompétance_QCMListeResultByPers_select_QCM, My.Resources.Global_Erreur, MessageBoxButtons.OK, MessageBoxIcon.Error)
    End If

  End Sub

  Private Sub BtnArchives_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles BtnArchives.Click

    bActif = Not bActif

    'nom de la fenetre
    If bActif = False Then

      Me.Text = My.Resources.TestCompétance_QCMListeResultByPers_liste_QCM & sVPERNOM
      LblTitre.Text = My.Resources.TestCompétance_QCMListeResultByPers_liste_QCM & sVPERNOM

      BtnArchives.Visible = False

      LoadDataGridView(GVQCM.FocusedRowHandle)

    End If

  End Sub

  Private Sub BtnFermer_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles BtnFermer.Click

    If bActif = True Then
      Me.Close()
    Else
      bActif = Not bActif
      Me.Text = My.Resources.TestCompétance_QCMListeResultByPers_liste_QCM & sVPERNOM
      LblTitre.Text = My.Resources.TestCompétance_QCMListeResultByPers_liste_QCM & sVPERNOM
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