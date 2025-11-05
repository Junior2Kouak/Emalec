Imports System.Data.SqlClient
Imports MozartLib

Public Class frmSuiviTabletFiliales

  Private Sub frmSuiviTabletFiliales_Load(sender As System.Object, e As System.EventArgs) Handles MyBase.Load

    chargeListe("O")

  End Sub

  Private Sub chargeListe(ACTIF As String)

    Try

      Me.Cursor = Cursors.WaitCursor
      'on ouvre la connexion
      If MozartDatabase.cnxMozart.State = ConnectionState.Open Then

        Dim CmdSql As New SqlCommand("api_sp_ListeSuiviTabletFiliales", MozartDatabase.cnxMozart)
        CmdSql.CommandType = CommandType.StoredProcedure
        CmdSql.Parameters.Add("@ACTIF", SqlDbType.Char).Value = ACTIF

        Dim sqlAdpat As SqlDataAdapter = New SqlDataAdapter(CmdSql)
        Dim dtStat As New DataSet
        sqlAdpat.Fill(dtStat)

        GCStat.DataSource = dtStat.Tables(0)

        CmdSql.Dispose()

        GCStat.Focus()

      End If

    Catch ex As Exception
      MessageBox.Show(My.Resources.DemandeIntervention_frmSuiviTableFiliales_erreur_chargeliste + ex.Message, My.Resources.Global_Erreur)
    Finally
      Me.Cursor = Cursors.Default
    End Try

  End Sub

  Private Sub BtnFermer_Click(sender As System.Object, e As System.EventArgs) Handles BtnFermer.Click
    Me.Close()
  End Sub

  Private Sub btnValider_Click(sender As System.Object, e As System.EventArgs) Handles btnValider.Click

    Try
      ' On récupère le n° unique NACTNUM et NDINNUM sélectionnés dans la liste
      Dim ligne_selectionnee As Integer() = GVStat.GetSelectedRows()
      Dim ndinnum As String = GVStat.GetRowCellValue(ligne_selectionnee.ElementAt(0), "NDINNUM").ToString
      Dim nactnum As String = GVStat.GetRowCellValue(ligne_selectionnee.ElementAt(0), "NACTNUM").ToString

      Dim CmdTest As New SqlCommand("select CDIWLOCK from TACTTABLETFILIALE where NACTNUM = " & nactnum, MozartDatabase.cnxMozart)
      Dim sqlRead As SqlClient.SqlDataReader = CmdTest.ExecuteReader()
      sqlRead.Read()

      If IsDBNull(sqlRead("CDIWLOCK")) Then
        ' On la bloque
        sqlRead.Close()
        Dim CmdBloque As New SqlCommand("update TACTTABLETFILIALE set CDIWLOCK = 'O' where NACTNUM = " & nactnum, MozartDatabase.cnxMozart)
        CmdBloque.ExecuteScalar()
      Else
        sqlRead.Close()
        MsgBox(My.Resources.DemandeIntervention_frmSuiviTableFiliales_DI_deja_traitement)
        Exit Sub
      End If

      Shell(Environment.GetFolderPath(Environment.SpecialFolder.ProgramFilesX86) & "\mozart\SynchroMozart.exe " & MozartParams.NomServeur & ";" & MozartParams.NomSociete & ";" & ndinnum & ";" & nactnum, vbMaximizedFocus)
      Me.Close()

    Catch ex As Exception
      MessageBox.Show(My.Resources.DemandeIntervention_frmSuiviTableFiliales_aucune_ligne_selectionnee, My.Resources.Global_Information)
    End Try
  End Sub

  Private Sub btnConsultArchives_Click(sender As System.Object, e As System.EventArgs) Handles btnConsultArchives.Click
    chargeListe("N")
    btnActif.Visible = True
    btnConsultArchives.Visible = False
    Button1.Visible = False
    btnValider.Visible = False
  End Sub

  Private Sub btnActif_Click(sender As System.Object, e As System.EventArgs) Handles btnActif.Click
    chargeListe("O")
    btnActif.Visible = False
    btnConsultArchives.Visible = True
    Button1.Visible = True
    btnValider.Visible = True

  End Sub

  Private Sub Button1_Click(sender As System.Object, e As System.EventArgs) Handles Button1.Click
    Try
      ' On récupère le n° unique NACTNUM sélectionné dans la liste
      Dim ligne_selectionnee As Integer() = GVStat.GetSelectedRows()
      Dim nactnum As String = GVStat.GetRowCellValue(ligne_selectionnee.ElementAt(0), "NACTNUM").ToString

      Dim CmdBloque As New SqlCommand("update TACTTABLETFILIALE set CDIWLOCK = 'O' where NACTNUM = " & nactnum, MozartDatabase.cnxMozart)
      CmdBloque.ExecuteScalar()

      btnActif_Click(sender, e)

    Catch ex As Exception
      MessageBox.Show(My.Resources.DemandeIntervention_frmSuiviTableFiliales_aucune_ligne_selectionnee, My.Resources.Global_Information)
    End Try
  End Sub
End Class