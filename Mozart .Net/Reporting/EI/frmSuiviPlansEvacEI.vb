Imports System.Data.SqlClient
Imports MozartLib

Public Class frmSuiviPlansEvacEI

  Private Sub frmSuiviPlansEvacEI_Load(sender As System.Object, e As System.EventArgs) Handles MyBase.Load
    ' TB SAMSIC CITY RES
    DRECEPTIONPLAN.Caption += MozartParams.NomGroupe
    LblTitre.Text = LblTitre.Text & My.Resources.Global_le & Today.Date

    chargeListe("O")

  End Sub

  Private Sub chargeListe(CPLANACTIF As String)

    Try

      Me.Cursor = Cursors.WaitCursor
      'on ouvre la connexion
      If MozartDatabase.cnxMozart.State = ConnectionState.Open Then

        Dim CmdSql As New SqlCommand("api_sp_SuiviPlanEvacuationEI", MozartDatabase.cnxMozart)
        CmdSql.CommandType = CommandType.StoredProcedure
        CmdSql.Parameters.Add("@CPLANACTIF", SqlDbType.Char).Value = CPLANACTIF

        Dim sqlAdpat As SqlDataAdapter = New SqlDataAdapter(CmdSql)
        Dim dtStat As New DataSet
        sqlAdpat.Fill(dtStat)

        GCStat.DataSource = dtStat.Tables(0)

        CmdSql.Dispose()

        GCStat.Focus()

      End If

    Catch ex As Exception
      MessageBox.Show(My.Resources.Reporting_EI_subcharge + ex.Message, My.Resources.Global_Erreur)
    Finally
      Me.Cursor = Cursors.Default
    End Try

  End Sub

  Private Sub BtnPrint_Click(sender As System.Object, e As System.EventArgs) Handles BtnPrint.Click

    GCStat.Print()

  End Sub

  Private Sub BtnFermer_Click(sender As System.Object, e As System.EventArgs) Handles BtnFermer.Click

    Me.Close()

  End Sub

  Private Sub GVStat_EndSorting(sender As Object, e As System.EventArgs) Handles GVStat.EndSorting
    GVStat.MoveFirst()
  End Sub

  Private Sub Button1_Click(sender As System.Object, e As System.EventArgs) Handles Button1.Click
    Try
      ' On récupère le n° unique NACTNUM sélectionné dans la liste
      Dim ligne_selectionnee As Integer() = GVStat.GetSelectedRows()
      Dim nactnum As String = GVStat.GetRowCellValue(ligne_selectionnee.ElementAt(0), "NACTNUM").ToString
      Dim ndinnumAction As String = GVStat.GetRowCellValue(ligne_selectionnee.ElementAt(0), "DIAction").ToString

      If MsgBox(My.Resources.Reporting_EI_archiver & ndinnumAction & " ?", MsgBoxStyle.YesNo + MsgBoxStyle.Question, My.Resources.Global_confirmation_maj) = vbYes Then

        ' Mise à jour
        Dim o_sql As String = "UPDATE TACTSUIVIPLANEVAC_EI SET CPLANACTIF = 'N' WHERE NACTNUM = " & nactnum
        Dim SqlUpdate As New SqlCommand(o_sql, MozartDatabase.cnxMozart)

        SqlUpdate.ExecuteNonQuery()

        chargeListe("O")

      End If

    Catch ex As Exception
      MessageBox.Show(My.Resources.Global_aucune_ligne, My.Resources.Global_Information)
    End Try
  End Sub

  Private Sub btnConsultArchives_Click(sender As System.Object, e As System.EventArgs) Handles btnConsultArchives.Click

    Button1.Visible = False
    btnConsultArchives.Visible = False
    btnActif.Visible = True
    btnDetails.Visible = False

    chargeListe("N")

  End Sub

  Private Sub btnActif_Click(sender As System.Object, e As System.EventArgs) Handles btnActif.Click

    Button1.Visible = True
    btnConsultArchives.Visible = True
    btnActif.Visible = False
    btnDetails.Visible = True

    chargeListe("O")

  End Sub

  Private Sub btnDetails_Click(sender As System.Object, e As System.EventArgs) Handles btnDetails.Click

    Try
      ' On récupère le n° unique NACTNUM sélectionné dans la liste
      Dim ligne_selectionnee As Integer() = GVStat.GetSelectedRows()
      Dim nactnum As String = GVStat.GetRowCellValue(ligne_selectionnee.ElementAt(0), "NACTNUM").ToString

      Dim oForm As New frmSuiviPlansEvacuation(nactnum)
      oForm.ShowDialog()

      ' Nettoyage
      oForm = Nothing

      btnActif_Click(sender, e)

    Catch ex As Exception
      MessageBox.Show(My.Resources.Global_aucune_ligne, My.Resources.Global_Information)
    End Try

  End Sub

  Private Sub btnAccesDI_Click(sender As System.Object, e As System.EventArgs) Handles btnAccesDI.Click
    Try
      ' On récupère le n° unique NACTNUM et NDINNUM\NACTID sélectionnés dans la liste
      Dim ligne_selectionnee As Integer() = GVStat.GetSelectedRows()
      Dim ndinnumnidnum As String = GVStat.GetRowCellValue(ligne_selectionnee.ElementAt(0), "DIAction").ToString
      Dim nactnum As String = GVStat.GetRowCellValue(ligne_selectionnee.ElementAt(0), "NACTNUM").ToString

      Dim ndinnum = ndinnumnidnum.Substring(0, ndinnumnidnum.IndexOf("\"))

      Shell(MozartParams.CheminProgrammeMozart & "SynchroMozart.exe " & MozartParams.NomServeur & ";" & MozartParams.NomSociete & ";" & ndinnum & ";" & nactnum, vbMaximizedFocus)

    Catch ex As Exception
      MessageBox.Show(My.Resources.Global_aucune_ligne, My.Resources.Global_Information)
    End Try
  End Sub

End Class