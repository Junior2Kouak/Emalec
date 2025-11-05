Imports System.Data.SqlClient
Imports DevExpress.XtraPivotGrid
Imports MozartLib

Public Class frmGestionCompetencePer

  Dim dtLstGestCompetence As DataTable

  Dim bActif As Boolean
  Dim iPosRowHdle As Int32

  Private Sub frmGestionCompetencePer_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load

    Try
      'init
      bActif = True
      LoadListeGestCompetence(bActif)

      ResizeComponents()

    Catch ex As Exception

      MessageBox.Show(ex.Message)

    End Try

  End Sub

  Private Sub BtnClose_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles BtnClose.Click

    Me.Close()

  End Sub

  Private Sub LoadListeGestCompetence(ByVal p_actif As Boolean)

    dtLstGestCompetence = New DataTable
    dtLstGestCompetence = ModDataGridView.LoadList(String.Format("[api_sp_ListeGestion_Competence_Per] {0}, {1}", MozartParams.NomSociete, p_actif), MozartDatabase.cnxMozart)

    'GCCompetence.DataSource = dtLstGestCompetence
    dtLstGestCompetence.Columns("BAFFECTE").ReadOnly = False

    PvtGridCompetence.DataSource = dtLstGestCompetence

  End Sub

  Private Sub SaveLigneDomaine(ByVal oRowsSavTemp As DataRow)

    Try

      Dim sqlcmdCreateLigne As New SqlCommand("api_sp_CreationGestDomaine", MozartDatabase.cnxMozart)
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

    PvtGridCompetence.Width = Me.Width - PvtGridCompetence.Left - 40
    PvtGridCompetence.Height = Me.Height - PvtGridCompetence.Top - 40

  End Sub

  Private Sub frmGestionTypeContrat_SizeChanged(ByVal sender As Object, ByVal e As System.EventArgs) Handles Me.SizeChanged
    ResizeComponents()
  End Sub

  Private Sub BtnNew_Click(sender As System.Object, e As System.EventArgs) Handles BtnNew.Click

    Dim oFrmDetailCompetence As New frmDetailCompetencePer(0, 0, "", bActif)
    oFrmDetailCompetence.ShowDialog()

    'iPosRowHdle = PvtGridCompetence.FocusedRowHandle

    LoadListeGestCompetence(bActif)

    'PvtGridCompetence.FocusedRowHandle = iPosRowHdle

  End Sub

  Private Sub BtnModif_Click(sender As System.Object, e As System.EventArgs) Handles BtnModif.Click

    Dim cells As PivotGridCells = PvtGridCompetence.Cells

    If Not cells Is Nothing Then

      Dim ds As PivotDrillDownDataSource = cells.GetFocusedCellInfo.CreateDrillDownDataSource()
      For i As Int32 = 0 To ds.RowCount - 1 Step 1
        Dim row As PivotDrillDownDataRow = ds(i)

        Dim oFrmDetailCompetence As New frmDetailCompetencePer(row("NIDCOMPET"), row("NIDDOM_COMPET"), row("VLIBCOMPET"), bActif)
        oFrmDetailCompetence.ShowDialog()

        LoadListeGestCompetence(bActif)

      Next

    End If

  End Sub

  Private Sub BtnArchiver_Click(sender As System.Object, e As System.EventArgs) Handles BtnArchiver.Click

    Dim cells As PivotGridCells = PvtGridCompetence.Cells

    If Not cells Is Nothing Then

      Dim ds As PivotDrillDownDataSource = cells.GetFocusedCellInfo.CreateDrillDownDataSource()
      For i As Int32 = 0 To ds.RowCount - 1 Step 1
        Dim row As PivotDrillDownDataRow = ds(i)

        If MessageBox.Show(My.Resources.GestionContrat_type_frmDetailCompetence_MsgArch & " " & row("VLIBCOMPET").ToString, My.Resources.Global_Confirmation, MessageBoxButtons.YesNoCancel) = Windows.Forms.DialogResult.Yes Then

          Dim sqlcmd As New SqlCommand("[api_sp_GestCompetence_Save]", MozartDatabase.cnxMozart)
          sqlcmd.CommandType = CommandType.StoredProcedure
          sqlcmd.Parameters.Add("@P_NIDCOMPET", SqlDbType.Int).Value = row("NIDCOMPET")
          sqlcmd.Parameters.Add("@P_NIDDOM_COMPET", SqlDbType.Int).Value = row("NIDDOM_COMPET")
          sqlcmd.Parameters.Add("@P_VLIBCOMPET", SqlDbType.VarChar).Value = row("VLIBCOMPET")
          sqlcmd.Parameters.Add("@P_ACTIF", SqlDbType.Bit).Value = Not (bActif)
          sqlcmd.Parameters.Add("@P_VSOCIETE", SqlDbType.VarChar).Value = MozartParams.NomSociete

          sqlcmd.ExecuteNonQuery()

          LoadListeGestCompetence(bActif)

          Exit Sub

        End If
      Next
    End If

  End Sub

  Private Sub BtnListeArchives_Click(sender As System.Object, e As System.EventArgs) Handles BtnListeArchives.Click

    If bActif = True Then
      bActif = False
      Me.Text = My.Resources.GestionContrat_type_frmDetailCompetence_TitleArch
      BtnArchiver.Visible = False
      BtnNew.Visible = False
      BtnListeArchives.Text = My.Resources.GestionContrat_type_frmDetailCompetence_ListeActifs
    Else
      bActif = True
      Me.Text = My.Resources.GestionContrat_type_frmDetailCompetence_Title
      BtnArchiver.Visible = True
      BtnNew.Visible = True
      BtnListeArchives.Text = My.Resources.GestionContrat_type_frmDetailCompetence_ListeArchives
    End If
    LoadListeGestCompetence(bActif)

  End Sub

  Private Sub RepItemChkBAFFECTE_CheckedChanged(sender As Object, e As System.EventArgs) Handles RepItemChkBAFFECTE.CheckedChanged

    'Dim ChkEdit As RepositoryItemCheckEdit = sender
    Dim cells As PivotGridCells = PvtGridCompetence.Cells

    If Not cells Is Nothing Then
      Dim ds As PivotDrillDownDataSource = cells.GetFocusedCellInfo.CreateDrillDownDataSource()

      For i As Int32 = 0 To ds.RowCount - 1 Step 1
        Dim row As PivotDrillDownDataRow = ds(i)

        Dim sqlcmdExec As New SqlCommand("[api_sp_GestCompetenceByFonc_Save]", MozartDatabase.cnxMozart)
        sqlcmdExec.CommandType = CommandType.StoredProcedure
        sqlcmdExec.Parameters.Add("@P_NIDCOMPETBYFONC", SqlDbType.Int).Value = row("NIDCOMPETBYFONC")
        sqlcmdExec.Parameters.Add("@P_BAFFECTE", SqlDbType.Bit).Value = If(sender.Checked = True, 1, 0)

        Debug.Print(row("NIDCOMPETBYFONC") & " - " & sender.Checked.ToString & " : " & If(sender.Checked = True, 1, 0))

        sqlcmdExec.ExecuteNonQuery()

        If sender.Checked = True Then

          row("BAFFECTE") = 1

        Else

          row("BAFFECTE") = 0

        End If



      Next

    End If

    PvtGridCompetence.Refresh()

  End Sub

End Class