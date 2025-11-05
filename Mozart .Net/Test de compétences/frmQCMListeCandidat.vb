Imports MozartLib

Public Class frmQCMListeCandidat

  Dim oGestConnectSQL As New CGestionSQL
  Dim oListMsg As CQCMListeMsg
  Dim bAffichQCMActif As Boolean

  Dim iNQCMTypeId As Int32 '1 = test de connaissances et 2 : causeries securite
  Dim sTypeQCM As String 'QCM ou Causeries

  Public Sub New(ByVal C_iNQCMTypeId As Object)

    ' Cet appel est requis par le concepteur.
    InitializeComponent()

    ' Ajoutez une initialisation quelconque après l'appel InitializeComponent().
    iNQCMTypeId = CType(C_iNQCMTypeId, Int32)

    'gestion des messages par type de qcm
    oListMsg = New CQCMListeMsg(iNQCMTypeId)

  End Sub

  Private Sub frmQCMListeCandidat_FormClosed(ByVal sender As Object, ByVal e As System.Windows.Forms.FormClosedEventArgs) Handles Me.FormClosed
    oGestConnectSQL.CloseConnexionSQL()
  End Sub

  Private Sub frmQCMListeCandidat_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load

    Try

      Me.Text = oListMsg.ReturnMsg(0)
      BtnResultatsByQCMCandidat.Text = oListMsg.ReturnMsg(48)
      sTypeQCM = oListMsg.ReturnMsg(3)

      'on ouvre la connexion
      If oGestConnectSQL.ConnexionSQL(MozartParams.NomServeur, MozartParams.NomSociete) = True Then

        InitGridView()

        'on charge la liste des QCM existant
        bAffichQCMActif = True
        DGVTestConnaissances.DataSource = ModDataGridView.LoadList("EXEC api_sp_QCMListeRecrutement " + bAffichQCMActif.ToString + ", " + iNQCMTypeId.ToString, oGestConnectSQL.CnxSQLOpen)

      End If

    Catch ex As Exception

      MessageBox.Show(My.Resources.TestCompétance_QCMDetailListeCandidat_sub + ex.Message, My.Resources.Global_Erreur, MessageBoxButtons.OK, MessageBoxIcon.Error)

    End Try

  End Sub

  Private Sub BtnFermer_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles BtnFermer.Click
    Me.Close()
  End Sub

  Private Sub InitGridView()

    'On définit le retour ligne auto dans les cellules
    DGVTestConnaissances.DefaultCellStyle.WrapMode = DataGridViewTriState.True
    DGVTestConnaissances.ColumnHeadersDefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleCenter

    Dim iLargeurDatagridView As Integer = DGVTestConnaissances.Width - DGVTestConnaissances.RowHeadersWidth - 1

    'Ajout de la colonne NIDLGAMTABLET non visible
    Dim ColNIDQCMNUM As New Windows.Forms.DataGridViewTextBoxColumn
    ColNIDQCMNUM.DataPropertyName = "NIDQCMNUM"
    ColNIDQCMNUM.Name = "NIDQCMNUM"
    ColNIDQCMNUM.ReadOnly = True
    ColNIDQCMNUM.Visible = False

    Dim ColVQCMTITRE As New DataGridViewTextBoxColumn
    ColVQCMTITRE.DataPropertyName = "VQCMTITRE"
    ColVQCMTITRE.Name = "VQCMTITRE"
    ColVQCMTITRE.HeaderText = oListMsg.ReturnMsg(7)
    ColVQCMTITRE.HeaderCell.Style.Alignment = DataGridViewContentAlignment.MiddleCenter
    ColVQCMTITRE.FillWeight = CType(iLargeurDatagridView * 0.6, Single)
    ColVQCMTITRE.ReadOnly = True
    ColVQCMTITRE.Visible = True

    Dim ColDQCMCREE As New DataGridViewTextBoxColumn
    ColDQCMCREE.DataPropertyName = "DQCMCREE"
    ColDQCMCREE.Name = "DQCMCREE"
    ColDQCMCREE.HeaderText = oListMsg.ReturnMsg(8)
    ColDQCMCREE.HeaderCell.Style.Alignment = DataGridViewContentAlignment.MiddleCenter
    ColDQCMCREE.FillWeight = CType(iLargeurDatagridView * 0.4, Single)
    ColDQCMCREE.ReadOnly = True
    ColDQCMCREE.Visible = True

    Dim ColDQCMACTIF As New DataGridViewCheckBoxColumn
    ColDQCMACTIF.DataPropertyName = "BQCMACTIF"
    ColDQCMACTIF.Name = "BQCMACTIF"
    ColDQCMACTIF.ReadOnly = True
    ColDQCMACTIF.Visible = False

    DGVTestConnaissances.Columns.Add(ColNIDQCMNUM)
    DGVTestConnaissances.Columns.Add(ColVQCMTITRE)
    DGVTestConnaissances.Columns.Add(ColDQCMCREE)
    DGVTestConnaissances.Columns.Add(ColDQCMACTIF)

  End Sub

  Private Sub BtnResultatsByQCMCandidat_Click(sender As System.Object, e As System.EventArgs) Handles BtnResultatsByQCMCandidat.Click

    If DGVTestConnaissances.SelectedRows.Count > 0 Then

      Select Case iNQCMTypeId

        Case 1

          Dim ofrmQCMResultatsByQCM As New frmQCMListeResultByQCMCandidat(DGVTestConnaissances.SelectedRows.Item(0).Cells("NIDQCMNUM").Value, DGVTestConnaissances.SelectedRows.Item(0).Cells("VQCMTITRE").Value, iNQCMTypeId)
          ofrmQCMResultatsByQCM.ShowDialog()
          ofrmQCMResultatsByQCM.Dispose()

        Case 2

          Dim ofrmCauserieResultatsByQCM As New frmCauserieListeResultByQCM(DGVTestConnaissances.SelectedRows.Item(0).Cells("NIDQCMNUM").Value, DGVTestConnaissances.SelectedRows.Item(0).Cells("VQCMTITRE").Value, iNQCMTypeId)
          ofrmCauserieResultatsByQCM.ShowDialog()
          ofrmCauserieResultatsByQCM.Dispose()

        Case Else

          MessageBox.Show(My.Resources.Global_type_nonreconnu, My.Resources.Global_Erreur, MessageBoxButtons.OK, MessageBoxIcon.Error)

      End Select

    Else
      MessageBox.Show(oListMsg.ReturnMsg(6), My.Resources.Global_Erreur, MessageBoxButtons.OK, MessageBoxIcon.Error)
    End If

  End Sub

End Class
