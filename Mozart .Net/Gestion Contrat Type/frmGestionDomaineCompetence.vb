Imports System.Data.SqlClient
Imports MozartLib

Public Class frmGestionDomaineCompetence

  Dim sqlConnectGestDom As CGestionSQL

  Dim dtLstGestCont As DataTable
  Dim dtLstlangue As DataTable

  Dim bActif As Boolean
  Dim iPosRowHdle As Int32


  Private Sub frmGestionDomaineCompetence_FormClosed(ByVal sender As Object, ByVal e As System.Windows.Forms.FormClosedEventArgs) Handles Me.FormClosed
    sqlConnectGestDom.CloseConnexionSQL()
  End Sub

  Private Sub frmGestionDomaineCompetence_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load

    Try
      'init
      bActif = True

      sqlConnectGestDom = New CGestionSQL

      If sqlConnectGestDom.ConnexionSQL(MozartParams.NomServeur, MozartParams.NomSociete) = True Then

        LoadListeGestDomaineCompetence(bActif)

      End If

      ResizeComponents()

    Catch ex As Exception

      MessageBox.Show(ex.Message)

    End Try

  End Sub

  Private Sub BtnClose_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles BtnClose.Click

    Me.Close()

  End Sub

  Private Sub LoadListeGestDomaineCompetence(ByVal p_actif As Boolean)

    dtLstGestCont = New DataTable
    dtLstGestCont = ModDataGridView.LoadListWithIncrementAuto(String.Format("[api_sp_ListeGestionDomaine_Competence] {0}, {1}", MozartParams.NomSociete, p_actif), sqlConnectGestDom.CnxSQLOpen)

    Dim keys(1) As DataColumn

    keys(0) = dtLstGestCont.Columns("IDTMP")

    dtLstGestCont.PrimaryKey = keys

    GCDomaineCompet.DataSource = dtLstGestCont

  End Sub

  Private Sub SaveLigneDomaine(ByVal oRowsSavTemp As DataRow)

    Try

      Dim sqlcmdCreateLigne As New SqlCommand("api_sp_CreationGestDomaine", sqlConnectGestDom.CnxSQLOpen)
      sqlcmdCreateLigne.CommandType = CommandType.StoredProcedure
      sqlcmdCreateLigne.Parameters.Add("@p_ncontdomnum", SqlDbType.Int)
      sqlcmdCreateLigne.Parameters("@p_ncontdomnum").Value = oRowsSavTemp.Item("NCONTDOMNUM")
      sqlcmdCreateLigne.Parameters.Add("@p_vcontdomlib", SqlDbType.VarChar)
      sqlcmdCreateLigne.Parameters("@p_vcontdomlib").Value = oRowsSavTemp.Item("VCONTDOMLIB")
      sqlcmdCreateLigne.Parameters.Add("@p_norderby", SqlDbType.Int)
      sqlcmdCreateLigne.Parameters("@p_norderby").Value = oRowsSavTemp.Item("NORDERBY")

      sqlcmdCreateLigne.ExecuteNonQuery()

    Catch ex As Exception
      MessageBox.Show(ex.Message)
    End Try

  End Sub

  Private Sub frmGestionTypeContrat_ResizeEnd(ByVal sender As Object, ByVal e As System.EventArgs) Handles Me.ResizeEnd

    ResizeComponents()

  End Sub

  Private Sub ResizeComponents()

    GCDomaineCompet.Width = Me.Width - GCDomaineCompet.Left - 40
    GCDomaineCompet.Height = Me.Height - GCDomaineCompet.Top - 40

  End Sub

  Private Sub frmGestionTypeContrat_SizeChanged(ByVal sender As Object, ByVal e As System.EventArgs) Handles Me.SizeChanged
    ResizeComponents()
  End Sub

  Private Sub BtnNew_Click(sender As System.Object, e As System.EventArgs) Handles BtnNew.Click

    Dim oFrmDetailDomaineCompetence As New frmDetailDomaineCompetence(0, "", bActif)
    oFrmDetailDomaineCompetence.ShowDialog()

    iPosRowHdle = GVListeDomaineCompet.FocusedRowHandle

    LoadListeGestDomaineCompetence(bActif)

    GVListeDomaineCompet.FocusedRowHandle = iPosRowHdle

  End Sub

  Private Sub BtnModif_Click(sender As System.Object, e As System.EventArgs) Handles BtnModif.Click

    If GVListeDomaineCompet.SelectedRowsCount > 0 Then

      Dim oRowSelect As DataRow = GVListeDomaineCompet.GetDataRow(GVListeDomaineCompet.GetSelectedRows(0))

      Dim oFrmDetailDomaine As New frmDetailDomaineCompetence(oRowSelect("NIDDOM_COMPET"), oRowSelect("VLIBDOM_COMPET"), bActif)
      oFrmDetailDomaine.ShowDialog()

      iPosRowHdle = GVListeDomaineCompet.FocusedRowHandle

      LoadListeGestDomaineCompetence(bActif)

      GVListeDomaineCompet.FocusedRowHandle = iPosRowHdle

    End If

  End Sub

  Private Sub BtnArchiver_Click(sender As System.Object, e As System.EventArgs) Handles BtnArchiver.Click

    If GVListeDomaineCompet.SelectedRowsCount > 0 Then

      If MessageBox.Show(My.Resources.GestionContrat_type_frmDetailDomaineCompetence_MsgArch, My.Resources.Global_Confirmation, MessageBoxButtons.YesNoCancel) = Windows.Forms.DialogResult.Yes Then

        Dim oRowSelect As DataRow = GVListeDomaineCompet.GetDataRow(GVListeDomaineCompet.GetSelectedRows(0))

        Dim sqlcmd As New SqlCommand("[api_sp_GestDomaineCompetence_Save]", MozartDatabase.cnxMozart)
        sqlcmd.CommandType = CommandType.StoredProcedure
        sqlcmd.Parameters.Add("@P_NIDDOM_COMPET", SqlDbType.Int).Value = oRowSelect("NIDDOM_COMPET")
        sqlcmd.Parameters.Add("@P_VLIBDOM_COMPET", SqlDbType.VarChar).Value = oRowSelect("VLIBDOM_COMPET")
        sqlcmd.Parameters.Add("@P_ACTIF", SqlDbType.Bit).Value = Not (bActif)
        sqlcmd.Parameters.Add("@P_VSOCIETE", SqlDbType.VarChar).Value = MozartParams.NomSociete

        sqlcmd.ExecuteNonQuery()

      End If

      iPosRowHdle = GVListeDomaineCompet.FocusedRowHandle

      LoadListeGestDomaineCompetence(bActif)

      GVListeDomaineCompet.FocusedRowHandle = iPosRowHdle - 1

    End If

  End Sub

  Private Sub BtnListeArchives_Click(sender As System.Object, e As System.EventArgs) Handles BtnListeArchives.Click

    If bActif = True Then
      bActif = False
      Me.Text = My.Resources.GestionContrat_type_frmDetailDomaineCompetence_TitleArch
      BtnArchiver.Visible = False
      BtnNew.Visible = False
      BtnListeArchives.Text = My.Resources.GestionContrat_type_frmDetailDomaineCompetence_ListeActifs
    Else
      bActif = True
      Me.Text = My.Resources.GestionContrat_type_frmDetailDomaineCompetence_Title
      BtnArchiver.Visible = True
      BtnNew.Visible = True
      BtnListeArchives.Text = My.Resources.GestionContrat_type_frmDetailDomaineCompetence_ListeArchives
    End If
    LoadListeGestDomaineCompetence(bActif)

  End Sub
End Class