Imports System.Data.SqlClient
Imports MozartLib

Public Class frmTransfertAttachement

  Dim iNACTNUM As Int32
  Dim oGestConnectSQL As New CGestionSQL
  Dim dtAttachTransfert As DataTable

  Dim sPathFileAttachEMALEC As String

  'constructeur de la classe avec 1 paramtres
  Public Sub New(ByVal p_iNACTNUM As Object, ByVal p_sPathFileAttachEMALEC As String)
    InitializeComponent()
    iNACTNUM = Convert.ToInt32(p_iNACTNUM)
    sPathFileAttachEMALEC = p_sPathFileAttachEMALEC
  End Sub

  Private Sub BtnQuitter_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles BtnQuitter.Click

    Me.Close()

  End Sub

  Private Sub frmTransfertAttachement_FormClosing(ByVal sender As Object, ByVal e As System.Windows.Forms.FormClosingEventArgs) Handles Me.FormClosing

    oGestConnectSQL.CloseConnexionSQL()

  End Sub

  Private Sub frmTransfertAttachement_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
    ' TB SAMSIC CITY RES
    Text = Text.Replace("#gstrNomGroupe#", MozartParams.NomGroupe)
    GrpBoxVisuEMALEC.Text += MozartParams.NomGroupe

    Try

      'on ouvre la connexion
      If oGestConnectSQL.ConnexionSQL(MozartParams.NomServeur, MozartParams.NomSociete) = True Then

        'on charge la liste des QCM existant   
        DGVListeDIEMASOLAR.DataSource = ModDataGridView.LoadList("api_sp_ListeDIFilialeForDuplicateAttach 'EMASOLAR'", oGestConnectSQL.CnxSQLOpen)

        'on charge les données de l'attachement EMALEC
        Dim drsql As SqlDataReader = oGestConnectSQL.CreateSQLDataReader("EXEC api_sp_RetourAttachProvideTablet " + iNACTNUM.ToString)

        dtAttachTransfert = New DataTable

        dtAttachTransfert.Load(drsql)

        If dtAttachTransfert.Rows.Count = 0 Then
          MessageBox.Show(My.Resources.Corretion_frmTransfertAttachement_attach_non_present, My.Resources.Corretion_frmTransfertAttachement_erreur, MessageBoxButtons.OK, MessageBoxIcon.Exclamation)
        End If
        drsql.Close()

      End If

      If sPathFileAttachEMALEC <> "" Then WBVisuAttachEMALEC.Navigate(sPathFileAttachEMALEC)

      ResizeComponent()

    Catch ex As Exception

      MessageBox.Show(My.Resources.Corretion_frmTransfertAttachement_Sub_Load + ex.Message, My.Resources.Global_Erreur)

    End Try

  End Sub

  Private Sub ResizeComponent()

    GrpBoxLstDIEMASOLAR.Height = Me.Height - GrpBoxLstDIEMASOLAR.Top - 10
    GrpBoxVisuEMALEC.Width = Me.Width - GrpBoxVisuEMALEC.Left - 10
    GrpBoxVisuEMALEC.Height = Me.Height - GrpBoxVisuEMALEC.Top - 10

  End Sub

  Private Sub BtnPrevisu_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles BtnPrevisu.Click

    Try

      If DGVListeDIEMASOLAR.SelectedRows.Count = 0 Then

        MessageBox.Show(My.Resources.Corretion_frmTransfertAttachement_Select_action, My.Resources.Corretion_frmTransfertAttachement_erreur_action, MessageBoxButtons.OK, MessageBoxIcon.Error)
        Exit Try

      End If

      'on enregistre les données sans la table en cours de modification
      Dim oRowsDataAttach As DataRow = dtAttachTransfert.Rows(0)

      oRowsDataAttach.Item("NACTNUM") = DGVListeDIEMASOLAR.SelectedRows(0).Cells(0).Value

      Dim oVisuDocTemp As New CGenerateVisuDoc
      Dim oDoc As New CGenDoc("TransfertAttachEMALECTOEMASOLAR", oVisuDocTemp.QueryForImpAttachementCorrect(dtAttachTransfert.Rows(0), "api_sp_TabletimpAttachementForTransfert"))
      If oDoc.p_ERROR = "" Then
        Dim oFrmVisuDoc As New frmVisuDoc(oDoc.p_PathFileName)
        'WBVisuAttachEMASOLAR.Navigate(oFrmVisuDoc.p_PathUrl)
        oFrmVisuDoc.ShowDialog()
      End If

    Catch ex As Exception
      MessageBox.Show(My.Resources.Corretion_frmTransfertAttachement_sub_click + ex.Message, My.Resources.Global_Erreur)
    End Try


  End Sub

  Private Sub BtnTransfertAttachement_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles BtnTransfertAttachement.Click

    Try

      If DGVListeDIEMASOLAR.SelectedRows.Count = 0 Then

        MessageBox.Show(My.Resources.Corretion_frmTransfertAttachement_Select_action, My.Resources.Corretion_frmTransfertAttachement_erreur_action, MessageBoxButtons.OK, MessageBoxIcon.Error)
        Exit Try

      End If

      If MessageBox.Show(String.Format(My.Resources.Corretion_frmTransfertAttachement_dupliquer & vbCrLf & My.Resources.Corretion_frmTransfertAttachement_msg_impo, DGVListeDIEMASOLAR.SelectedRows(0).Cells(1).Value), "Transfert attachement EMASOLAR", MessageBoxButtons.YesNoCancel, MessageBoxIcon.Question) = vbYes Then

        'insert la ligne de la table temporaire pour regénéré l'attachement modifier
        Dim oRowsDataAttach As DataRow = dtAttachTransfert.Rows(0)
        Dim sc As New SqlCommand("api_sp_TabletCreationTAttachTransfert", oGestConnectSQL.CnxSQLOpen)

        sc.CommandType = CommandType.StoredProcedure

        sc.Parameters.Add("@NATTACHID", SqlDbType.Int).Value = oRowsDataAttach.Item("NATTACHID")
        sc.Parameters.Add("@NACTNUM", SqlDbType.Int).Value = DGVListeDIEMASOLAR.SelectedRows(0).Cells(0).Value 'NACTNUM
        sc.Parameters.Add("@NIPLNUM", SqlDbType.Int).Value = oRowsDataAttach.Item("NIPLNUM")
        sc.Parameters.Add("@VATTACHCHAP1", SqlDbType.VarChar).Value = oRowsDataAttach.Item("VATTACHCHAP1")
        sc.Parameters.Add("@VATTACHCHAP2", SqlDbType.VarChar).Value = oRowsDataAttach.Item("VATTACHCHAP2")
        sc.Parameters.Add("@VATTACHCHAP3", SqlDbType.VarChar).Value = oRowsDataAttach.Item("VATTACHCHAP3")
        sc.Parameters.Add("@VATTACHCHAP4", SqlDbType.VarChar).Value = oRowsDataAttach.Item("VATTACHCHAP4")
        sc.Parameters.Add("@VATTACHCHAP5", SqlDbType.VarChar).Value = oRowsDataAttach.Item("VATTACHCHAP5")
        sc.Parameters.Add("@VATTACHCHAP6", SqlDbType.VarChar).Value = oRowsDataAttach.Item("VATTACHCHAP6")
        sc.Parameters.Add("@NATTACHSATISF", SqlDbType.Int).Value = oRowsDataAttach.Item("NATTACHSATISF")
        sc.Parameters.Add("@IATTACHTECH", SqlDbType.Image).Value = oRowsDataAttach.Item("IATTACHTECH")
        sc.Parameters.Add("@IATTACHCLI", SqlDbType.Image).Value = oRowsDataAttach.Item("IATTACHCLI")
        sc.Parameters.Add("@CATTACHETA", SqlDbType.Char).Value = oRowsDataAttach.Item("CATTACHETA")
        sc.Parameters.Add("@DATTACHCRE", SqlDbType.VarChar).Value = oRowsDataAttach.Item("DATTACHCRE")
        sc.Parameters.Add("@DATTACHMOD", SqlDbType.VarChar).Value = oRowsDataAttach.Item("DATTACHMOD")
        sc.Parameters.Add("@VPERNOM", SqlDbType.VarChar).Value = oRowsDataAttach.Item("VPERNOM")
        sc.Parameters.Add("@VCONTACTCLI", SqlDbType.VarChar).Value = oRowsDataAttach.Item("VCONTACTCLI")
        sc.Parameters.Add("@VATTACHHR", SqlDbType.VarChar).Value = oRowsDataAttach.Item("VATTACHHR")
        sc.Parameters.Add("@VATTACHDEPL", SqlDbType.VarChar).Value = oRowsDataAttach.Item("VATTACHDEPL")
        sc.Parameters.Add("@NIDSYNCHROTRANSAT", SqlDbType.Int).Value = oRowsDataAttach.Item("NIDSYNCHROTRANSAT")
        sc.Parameters.Add("@VATTACHHRPREPA", SqlDbType.VarChar).Value = oRowsDataAttach.Item("VATTACHHRPREPA")

        sc.ExecuteNonQuery()

      End If

      'on charge la liste des QCM existant   
      DGVListeDIEMASOLAR.DataSource = ModDataGridView.LoadList("api_sp_ListeDIFilialeForDuplicateAttach 'EMASOLAR'", oGestConnectSQL.CnxSQLOpen)

    Catch ex As Exception
      MessageBox.Show(My.Resources.Corretion_frmTransfertAttachement_sub_Click_btn + ex.Message, My.Resources.Global_Erreur)
    End Try

  End Sub

  Private Sub frmTransfertAttachement_ResizeEnd(ByVal sender As Object, ByVal e As System.EventArgs) Handles Me.ResizeEnd

    ResizeComponent()

  End Sub

End Class