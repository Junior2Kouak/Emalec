Imports System.Data.SqlClient
Imports DevExpress.XtraEditors.Controls
Imports MozartLib

Public Class frmNotationSTT


  Dim _NACTNUM As Int32

  Public Sub New(ByVal NACTNUM As Object)

    ' Cet appel est requis par le concepteur.
    InitializeComponent()

    ' Ajoutez une initialisation quelconque après l'appel InitializeComponent().
    _NACTNUM = NACTNUM

  End Sub

  Private Sub frmNotationSTT_Load(sender As Object, e As EventArgs) Handles MyBase.Load
    If _NACTNUM = 0 Then Me.Close()
  End Sub

  Private Sub BtnValider_Click(sender As Object, e As EventArgs) Handles BtnValider.Click

    Dim TesteCocheBefore As Boolean
    Dim TesteCocheAfter As Boolean

    ' Enregistrement
    Try

      Cursor = Cursors.WaitCursor
      'on ouvre la connexion
      If MozartDatabase.cnxMozart.State = ConnectionState.Open Then

        TesteCocheBefore = TesterCoche(chkBefore)
        TesteCocheAfter = TesterCoche(chkAfter)

        ' vérifier si les choix sont cochés (au moins 1 choix)
        If Not TesteCocheBefore And Not TesteCocheAfter Then
          MsgBox(My.Resources.Admin_FOSTT_NotationSTT_CocherCase, MsgBoxStyle.Information + vbOKOnly, "INFO")
          Exit Sub
        End If

        Dim CmdSql As New SqlCommand("api_sp_creationNotationSTT", MozartDatabase.cnxMozart) With {.CommandType = CommandType.StoredProcedure}
        CmdSql.Parameters.Add("@nactnum", SqlDbType.Int).Value = _NACTNUM
        CmdSql.Parameters.Add("@Qui", SqlDbType.Int).Value = MozartParams.UID

        ' si coche alors création des paramètres et enregistrement
        If TesteCocheBefore Then
          CmdSql.Parameters.Add("@categorie", SqlDbType.VarChar).Value = "MB"
          CmdSql.Parameters.Add("@note", SqlDbType.Int).Value = ValeurCoche(chkBefore)
          CmdSql.ExecuteScalar()
        End If

        ' enregistrement des infos après
        ' si coche avant, les paramètres existe déjà, il suffit de les changer, sinon, il faut les créer
        If TesteCocheAfter Then
          If TesteCocheBefore Then
            CmdSql.Parameters("@categorie").Value = "MA"
            CmdSql.Parameters("@note").Value = ValeurCoche(chkAfter)
            CmdSql.ExecuteScalar()
          Else
            CmdSql.Parameters.Add("@categorie", SqlDbType.VarChar).Value = "MA"
            CmdSql.Parameters.Add("@note", SqlDbType.Int).Value = ValeurCoche(chkAfter)
            CmdSql.ExecuteScalar()
          End If
        End If

        CmdSql.Dispose()
        CmdSql = Nothing

        MsgBox(My.Resources.Global_EnregistrementOK, MsgBoxStyle.Information + vbOKOnly, "INFO")
        Close()
      End If

    Catch ex As Exception
      MessageBox.Show("BtnValider_Click dans " + Me.Name + " : " + ex.Message, My.Resources.Global_Erreur)
    Finally
      Cursor = Cursors.Default
    End Try

  End Sub

  Public Function TesterCoche(ByVal chk As DevExpress.XtraEditors.CheckedListBoxControl)

    For i = 0 To chk.Items.Count - 1
      If chk.GetItemChecked(i) = True Then
        Return True
      End If
    Next

    Return False
  End Function

  Public Function ValeurCoche(ByVal chk As DevExpress.XtraEditors.CheckedListBoxControl)

    For i = 0 To chk.ItemCount - 1
      If chk.GetItemChecked(i) = True Then
        Return chk.Items(i).Tag
      End If
    Next

    Return False
  End Function

  Private Sub BtnFermer_Click(sender As Object, e As EventArgs) Handles BtnFermer.Click
    Me.Close()
  End Sub

  Private Sub chk_ItemCheck(sender As Object, e As ItemCheckEventArgs) Handles chkAfter.ItemCheck, chkBefore.ItemCheck

    For i = 0 To sender.ItemCount - 1
      If sender.GetItemChecked(i) = True And i <> e.Index Then
        sender.SetItemChecked(i, False)
      End If
    Next
  End Sub
End Class