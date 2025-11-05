Imports System.Data.SqlClient
Imports MozartLib

Public Class frmGestionDomaineTech

  Dim sqlConnectGestDom As CGestionSQL

  Dim dtLstGestCont As DataTable
  Dim dtLstlangue As DataTable

  Dim iPosRowHdle As Int32

  Private Sub frmGestionDomaineTech_FormClosed(ByVal sender As Object, ByVal e As System.Windows.Forms.FormClosedEventArgs) Handles Me.FormClosed
    sqlConnectGestDom.CloseConnexionSQL()
  End Sub

  Private Sub frmGestionDomaineTech_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load

    Try

      sqlConnectGestDom = New CGestionSQL

      If sqlConnectGestDom.ConnexionSQL(MozartParams.NomServeur, MozartParams.NomSociete) = True Then

        LoadListeGestDomaine("FR")

      End If

      ResizeComponents()

    Catch ex As Exception

      MessageBox.Show(ex.Message)

    End Try

  End Sub

  Private Sub BtnClose_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles BtnClose.Click

    Me.Close()

  End Sub

  Private Sub LoadListeGestDomaine(ByVal p_Langue As String)

    dtLstGestCont = New DataTable
    dtLstGestCont = ModDataGridView.LoadListWithIncrementAuto(String.Format("api_sp_ListeGestionDomaine {0}", p_Langue), sqlConnectGestDom.CnxSQLOpen)

    dtLstGestCont.Columns("NORDERBY").ReadOnly = False

    Dim keys(1) As DataColumn

    keys(0) = dtLstGestCont.Columns("IDTMP")

    dtLstGestCont.PrimaryKey = keys

    GCDomaine.DataSource = dtLstGestCont

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

    GCDomaine.Width = Me.Width - GCDomaine.Left - 40
    GCDomaine.Height = Me.Height - GCDomaine.Top - 40

  End Sub

  Private Sub frmGestionTypeContrat_SizeChanged(ByVal sender As Object, ByVal e As System.EventArgs) Handles Me.SizeChanged
    ResizeComponents()
  End Sub

  Private Sub BtnNew_Click(sender As System.Object, e As System.EventArgs) Handles BtnNew.Click

    Dim oFrmDetailDomaine As New frmDetailDomaineTech(0, "", "FR")
    oFrmDetailDomaine.ShowDialog()

    iPosRowHdle = GVListeDomaine.FocusedRowHandle

    LoadListeGestDomaine("FR")

    GVListeDomaine.FocusedRowHandle = iPosRowHdle

  End Sub

  Private Sub BtnModif_Click(sender As System.Object, e As System.EventArgs) Handles BtnModif.Click

    If GVListeDomaine.SelectedRowsCount > 0 Then

      Dim oRowSelect As DataRow = GVListeDomaine.GetDataRow(GVListeDomaine.GetSelectedRows(0))

      Dim oFrmDetailDomaine As New frmDetailDomaineTech(oRowSelect("NCONTDOMNUM"), oRowSelect("VCONTDOMLIB"), "FR")
      oFrmDetailDomaine.ShowDialog()

      iPosRowHdle = GVListeDomaine.FocusedRowHandle

      LoadListeGestDomaine("FR")

      GVListeDomaine.FocusedRowHandle = iPosRowHdle

    End If

  End Sub

  'Private Sub LoadLangue()

  '    Dim sqlcmdLangue As New SqlCommand("SELECT DISTINCT LANGUE FROM TREF_CONTDOM ORDER BY LANGUE", cnx)

  '    sqlcmdLangue.CommandType = CommandType.Text

  '    dtLstlangue = New DataTable

  '    dtLstlangue.Load(sqlcmdLangue.ExecuteReader)

  'End Sub

  'Private Sub CboLangue_SelectedValueChanged(sender As Object, e As System.EventArgs) Handles CboLangue.SelectedValueChanged

  '    If Not CboLangue.SelectedValue Is Nothing AndAlso dtLstlangue.Rows.Count > 0 Then LoadListeGestDomaine(CboLangue.SelectedValue.ToString)

  'End Sub

  Private Sub BtnPrint_Click(sender As System.Object, e As System.EventArgs) Handles BtnPrint.Click

    'Dim oFrmGVPrint As New frmGridSelectColumnsForPrint(GVListeDomaine.Columns, GVListeDomaine.DataSource)
    'oFrmGVPrint.ShowDialog()

  End Sub

  Private Sub BtnDown_Click(sender As System.Object, e As System.EventArgs) Handles BtnDown.Click

    If GVListeDomaine.SelectedRowsCount > 0 Then

      Dim oRowSelect As DataRow = GVListeDomaine.GetDataRow(GVListeDomaine.GetSelectedRows(0))

      Dim sqlcmd As New SqlCommand("api_sp_GestionDomaineUpOrder", MozartDatabase.cnxMozart)
      sqlcmd.CommandType = CommandType.StoredProcedure
      sqlcmd.Parameters.Add("@P_NCONTDOMNUM", SqlDbType.Int).Value = oRowSelect("NCONTDOMNUM")
      sqlcmd.Parameters.Add("@P_NORDERBY", SqlDbType.Int).Value = oRowSelect("NORDERBY")

      sqlcmd.ExecuteNonQuery()

      iPosRowHdle = GVListeDomaine.FocusedRowHandle

      LoadListeGestDomaine("FR")

      GVListeDomaine.FocusedRowHandle = iPosRowHdle - 1

    End If

  End Sub

  Private Sub GVListeDomaine_FocusedRowChanged(sender As Object, e As DevExpress.XtraGrid.Views.Base.FocusedRowChangedEventArgs) Handles GVListeDomaine.FocusedRowChanged

    If e.FocusedRowHandle = 0 Then
      BtnDown.Visible = False
      BtnUp.Visible = True
    ElseIf (e.FocusedRowHandle + 1) = GVListeDomaine.RowCount Then
      BtnDown.Visible = True
      BtnUp.Visible = False
    Else
      BtnDown.Visible = True
      BtnUp.Visible = True
    End If

  End Sub

  Private Sub BtnUp_Click(sender As System.Object, e As System.EventArgs) Handles BtnUp.Click

    If GVListeDomaine.SelectedRowsCount > 0 Then

      Dim oRowSelect As DataRow = GVListeDomaine.GetDataRow(GVListeDomaine.GetSelectedRows(0))

      Dim sqlcmd As New SqlCommand("api_sp_GestionDomaineDownOrder", MozartDatabase.cnxMozart)
      sqlcmd.CommandType = CommandType.StoredProcedure
      sqlcmd.Parameters.Add("@P_NCONTDOMNUM", SqlDbType.Int).Value = oRowSelect("NCONTDOMNUM")
      sqlcmd.Parameters.Add("@P_NORDERBY", SqlDbType.Int).Value = oRowSelect("NORDERBY")

      sqlcmd.ExecuteNonQuery()

      iPosRowHdle = GVListeDomaine.FocusedRowHandle
      LoadListeGestDomaine("FR")
      GVListeDomaine.FocusedRowHandle = iPosRowHdle + 1

    End If

  End Sub
End Class