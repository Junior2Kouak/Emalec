Imports System.Data.SqlClient
Imports DevExpress.XtraPrinting
Imports MozartLib
Imports MZCtrlResources = MozartControls.Properties.Resources

Public Class frmCauserieListeResultByPER

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

  Private Sub frmCauserieListeResultByPER_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load

    Try

      'init 
      bActif = True

      Me.Text = My.Resources.TestCompétance_frmCauserieListeResultByPER_Liste & sVPERNOM
      LblTitre.Text = My.Resources.TestCompétance_frmCauserieListeResultByPER_Liste & sVPERNOM

      Cursor = Cursors.WaitCursor

      'load des donnees
      LoadDataGridView()

    Catch ex As Exception

      MessageBox.Show(My.Resources.TestCompétance_frmCauserieListeResultByPER_sub + ex.Message, MZCtrlResources.Global_erreur, MessageBoxButtons.OK, MessageBoxIcon.Error)

    Finally
      Cursor = Cursors.Default

    End Try

  End Sub

  '*************************************************************************************************************************************
  'Cette sub permet de charger les 3 tables de la proc, on les load dans un dataset ou l on definit les relations entre les tables
  ' et permettre l affichage groupe
  '*************************************************************************************************************************************
  Private Sub LoadDataGridView()
    Try
      Cursor = Cursors.WaitCursor

      Dim RowHdl As Int32 = -1

      If GVCAUSERIE.SelectedRowsCount > 0 And GVCAUSERIE.FocusedRowHandle >= 0 Then RowHdl = GVCAUSERIE.GetSelectedRows(0)
      Dim SvgTopRowIndex As Int32 = GVCAUSERIE.TopRowIndex
      GVCAUSERIE.GetVisibleIndex(RowHdl)

      dt = New DataTable

      Dim cmdLoadList As New SqlCommand("api_sp_ListeQCMByPer", MozartDatabase.cnxMozart) With {
      .CommandType = CommandType.StoredProcedure
    }
      cmdLoadList.CommandTimeout = 0
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

      GCCAUSERIE.DataSource = dt

      GVCAUSERIE.FocusedRowHandle = RowHdl
      GVCAUSERIE.TopRowIndex = SvgTopRowIndex

    Catch ex As Exception
      Throw ex
    Finally
      Cursor = Cursors.Default
    End Try

  End Sub

  Private Sub BtnEditRep_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles BtnEditRep.Click

    If GVCAUSERIE.SelectedRowsCount > 0 And GVCAUSERIE.FocusedRowHandle >= 0 Then

      'Dim drSelect As DataRow = GVCAUSERIE.GetDataRow(GVCAUSERIE.GetSelectedRows(0))

      'Dim oDoc As New CGenDoc("Causerie_Fiche_Edition_Result", drSelect.Item("NIDFICQCM"), drSelect.Item("NIDQCMNUM"))
      'If oDoc.p_ERROR = "" Then
      '    Dim ofrmVisuFic As New frmVisuDoc(oDoc.p_PathFileName)
      '    ofrmVisuFic.ShowDialog()
      'End If

      'pour l edition il faut que la correction soir valider par le tech et signé
      If Not GVCAUSERIE.GetDataRow(GVCAUSERIE.GetSelectedRows(0)).Item("DRETCORRECTSIGNTECH") Is DBNull.Value Then

        Dim drSelect As DataRow = GVCAUSERIE.GetDataRow(GVCAUSERIE.GetSelectedRows(0))

        'si validation pour la première fois alors on sauvegarde la validation
        'If GVCAUSERIE.GetDataRow(GVCAUSERIE.GetSelectedRows(0)).Item("DFICQCMVISACORRECT") Is DBNull.Value Then SaveValidationDirection(GVCAUSERIE.GetDataRow(GVCAUSERIE.GetSelectedRows(0)).Item("NIDFICQCM"))

        Dim oDoc As New CGenDoc("Causerie_Fiche_Edition_Result_Signature", drSelect.Item("NIDFICQCM"), drSelect.Item("NIDQCMNUM"))
        If oDoc.p_ERROR = "" Then
          'Dim ofrmVisuFic As New frmVisuDoc(oDoc.p_PathFileName)
          'ofrmVisuFic.ShowDialog()

          Dim startInfo As New ProcessStartInfo(oDoc.p_PathFileName)
          startInfo.WindowStyle = ProcessWindowStyle.Normal
          Process.Start(startInfo)

        End If

      Else
        MessageBox.Show(My.Resources.Global_retour_auteur, MZCtrlResources.Global_erreur, MessageBoxButtons.OK, MessageBoxIcon.Error)
      End If

    Else
      MessageBox.Show(My.Resources.TestCompétance_frmCauserieListeResultByPER_select_causerie, MZCtrlResources.Global_erreur, MessageBoxButtons.OK, MessageBoxIcon.Error)
    End If

  End Sub

  Private Sub BtnDetail_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles BtnDetail.Click

    If GVCAUSERIE.SelectedRowsCount > 0 And GVCAUSERIE.FocusedRowHandle >= 0 Then

      Dim drSelect As DataRow = GVCAUSERIE.GetDataRow(GVCAUSERIE.GetSelectedRows(0))
      Dim bReadOnly As Boolean = False

      If Not drSelect.Item("DVALIDCORRECTENVOI") Is DBNull.Value Then bReadOnly = True

      Dim ofrmCauserieDetResult As New frmCauserieDetailResult(drSelect.Item("NIDFICQCM"), drSelect.Item("NIDQCMNUM"), drSelect.Item("VQCMTITRE"), iNIDQCMTYPE, sVPERNOM, bReadOnly)
      ofrmCauserieDetResult.ShowDialog()
      ofrmCauserieDetResult.Dispose()

      'on recharge            
      LoadDataGridView()

    Else
      MessageBox.Show(My.Resources.TestCompétance_frmCauserieListeResultByPER_select_causerie, MZCtrlResources.Global_erreur, MessageBoxButtons.OK, MessageBoxIcon.Error)
    End If

  End Sub

  Private Sub BtnArchives_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles BtnArchives.Click

    bActif = Not bActif

    'nom de la fenetre
    If Not bActif Then

      Me.Text = My.Resources.TestCompétance_frmCauserieListeResultByPER_liste_causeries & sVPERNOM
      LblTitre.Text = My.Resources.TestCompétance_frmCauserieListeResultByPER_liste_causeries & sVPERNOM

      BtnArchives.Visible = False

      LoadDataGridView()

    End If

  End Sub

  Private Sub BtnFermer_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles BtnFermer.Click

    If bActif Then
      Me.Close()
    Else
      bActif = Not bActif
      Me.Text = My.Resources.TestCompétance_frmCauserieListeResultByPER_Liste & sVPERNOM
      LblTitre.Text = My.Resources.TestCompétance_frmCauserieListeResultByPER_Liste & sVPERNOM
      BtnArchives.Visible = True
      LoadDataGridView()
    End If

  End Sub

  Private Sub GVCAUSERIE_RowClick(sender As Object, e As DevExpress.XtraGrid.Views.Grid.RowClickEventArgs) Handles GVCAUSERIE.RowClick

    If e.RowHandle >= 0 Then

      BtnEditRep.Visible = (GVCAUSERIE.GetDataRow(e.RowHandle).Item("DRETCORRECTSIGNTECH") IsNot DBNull.Value)
      BtnDetail.Visible = (GVCAUSERIE.GetDataRow(e.RowHandle).Item("DFICQCMTERM") IsNot DBNull.Value)

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
      Dim opt As New XlsxExportOptionsEx With {
        .ExportType = DevExpress.Export.ExportType.WYSIWYG
      }
      GVCAUSERIE.ExportToXlsx(SDF.FileName, opt)

    End If
  End Sub

End Class