Imports System.Data.SqlClient
Imports MozartLib

Public Class frmDetailsCle

  Dim calendar_open As String = ""

  Public miNumCle As Int32

  Private Sub frmDetailsCle_Load(sender As System.Object, e As System.EventArgs) Handles MyBase.Load

    If miNumCle > 0 Then
      ' Mode modification
      chargeListe()
    Else

    End If

  End Sub

  Private Sub chargeListe()

    Dim dr As SqlDataReader
    Dim CmdSql

    Try

      Me.Cursor = Cursors.WaitCursor
      'on ouvre la connexion
      If MozartDatabase.cnxMozart.State = ConnectionState.Open Then

        ' Données générales
        CmdSql = New SqlCommand("select * from api_v_Listecles where NCLENUM= " & miNumCle, MozartDatabase.cnxMozart)
        CmdSql.CommandType = CommandType.Text
        dr = CmdSql.ExecuteReader
        If dr.HasRows = True Then
          dr.Read()
          ApiRadioButtonYes.Checked = IIf(dr("CLEORGA").ToString = "OUI", True, False)
          txtNumCleOrga.Text = dr("VCLENUMORGA").ToString
          txtRef.Text = dr("VCLEREF").ToString
          txtDesign.Text = dr("VCLELIB").ToString
          txtAffect.Text = dr("VCLEAFFECTATION").ToString
          txtDetenteurs.Text = dr("VCLEDETENU").ToString
          If dr("DCLEDATE") IsNot DBNull.Value Then txtDateHabilitation.DateTime = dr("DCLEDATE")
          txtObs.Text = dr("VCLEOBS").ToString
        End If
        dr.Close()
        CmdSql.Dispose()
      End If

    Catch ex As Exception
      MessageBox.Show(My.Resources.Admin_frmDetailsCles_Load + ex.Message, My.Resources.Global_Erreur)
    Finally
      Me.Cursor = Cursors.Default
      dr = Nothing
      CmdSql = Nothing
    End Try

  End Sub

  Private Function formateDate(ByVal chaine As String) As String
    Dim newChaine As String = ""

    If chaine.Trim().Equals("") Then
      Return ""
    Else
      newChaine = chaine.Substring(0, 10)
    End If

    Return newChaine
  End Function

  Private Sub BtnFermer_Click(sender As System.Object, e As System.EventArgs) Handles BtnFermer.Click
    Me.Close()
  End Sub

  Private Sub BtnEnreg_Click(sender As System.Object, e As System.EventArgs) Handles BtnEnreg.Click

    ' Enregistrement
    Try
      If (ApiRadioButtonYes.Checked And txtNumCleOrga.Text = "") Then
        MsgBox("Vous avez noté que cette clé est sous organigramme, vous devez inscrire le n° de clé", MsgBoxStyle.Information + vbOKOnly, "INFO")
        Exit Sub
      End If
      If (ApiRadioButtonNon.Checked And txtNumCleOrga.Text <> "") Then
        MsgBox("Vous avez noté un n° de clé sous organigramme, veuillez passer le choix à OUI pour permettre l’enregistrement", MsgBoxStyle.Information + vbOKOnly, "INFO")
        Exit Sub
      End If

      Me.Cursor = Cursors.WaitCursor
      'on ouvre la connexion
      If MozartDatabase.cnxMozart.State = ConnectionState.Open Then

        Dim CmdSql As New SqlCommand("api_sp_creationCle", MozartDatabase.cnxMozart)
        CmdSql.CommandType = CommandType.StoredProcedure

        CmdSql.Parameters.Add("@iNum", SqlDbType.Int).Value = miNumCle
        CmdSql.Parameters.Add("@ref", SqlDbType.VarChar).Value = txtRef.Text
        CmdSql.Parameters.Add("@Libelle", SqlDbType.VarChar).Value = txtDesign.Text
        CmdSql.Parameters.Add("@Affectation", SqlDbType.VarChar).Value = txtAffect.Text
        CmdSql.Parameters.Add("@dDateE", SqlDbType.VarChar).Value = IIf(txtDateHabilitation.Text = "", DBNull.Value, txtDateHabilitation.Text)
        CmdSql.Parameters.Add("@detenteur", SqlDbType.VarChar).Value = txtDetenteurs.Text
        CmdSql.Parameters.Add("@vObserv", SqlDbType.VarChar).Value = txtObs.Text
        CmdSql.Parameters.Add("@cOrga", SqlDbType.VarChar).Value = IIf(ApiRadioButtonYes.Checked, "O", "N")
        CmdSql.Parameters.Add("@vNumOrga", SqlDbType.VarChar).Value = txtNumCleOrga.Text

        CmdSql.ExecuteNonQuery()
        CmdSql.Dispose()
        CmdSql = Nothing

        Me.Cursor = Cursors.Default
        MsgBox(My.Resources.Global_EnregistrementOK, MsgBoxStyle.Information + vbOKOnly, "INFO")
        Me.Close()
      End If

    Catch ex As Exception
      MessageBox.Show(My.Resources.Admin_frmDetailsCles_btnenreg + ex.Message, My.Resources.Global_Erreur)
    Finally
      Me.Cursor = Cursors.Default
    End Try
  End Sub

  Private Sub txtObs_GotFocus(sender As Object, e As System.EventArgs) Handles txtObs.GotFocus
    Dim aux As String = MozartParams.strUID & " le " & DateTime.Now.ToString("dd/MM/yyyy HH:mm") & " : "
    txtObs.Text = aux & vbCrLf & txtObs.Text
  End Sub
End Class