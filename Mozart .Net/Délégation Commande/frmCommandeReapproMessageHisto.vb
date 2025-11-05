Imports System.Data.SqlClient
Imports MozartLib

Public Class frmCommandeReapproMessageHisto

  Dim _NCMDWEBTECH As Int32
  Dim _VMSG As String

  Public Sub New(ByVal c_NCMDWEBTECH As Int32, ByVal c_VMSG As String)

    ' Cet appel est requis par le concepteur.
    InitializeComponent()

    ' Ajoutez une initialisation quelconque après l'appel InitializeComponent().
    _NCMDWEBTECH = c_NCMDWEBTECH
    _VMSG = c_VMSG

  End Sub

  Private Sub frmCommandeReapproMessageHisto_Load(sender As Object, e As EventArgs) Handles MyBase.Load

    'INIT
    TxtMessages.Text = _VMSG

  End Sub

  Private Sub BtnFermer_Click(sender As Object, e As EventArgs) Handles BtnFermer.Click

    Me.Close()

  End Sub

  Private Sub BtnMessageAdd_Click(sender As Object, e As EventArgs) Handles BtnMessageAdd.Click

    Using ofrmCommandeReapproMessageAdd As New frmCommandeReapproMessageAdd

      ofrmCommandeReapproMessageAdd.ShowDialog()

      If ofrmCommandeReapproMessageAdd.TxtMessage.Text <> "" Then

        TxtMessages.Text = "Le valideur " & MozartParams.strUID & " a apporté le " & Now.ToShortDateString & " les commentaires suivants sur votre demande de réappro Dd" & _NCMDWEBTECH.ToString & " : " & ofrmCommandeReapproMessageAdd.TxtMessage.Text & vbCrLf & TxtMessages.Text
        SaveMessageCmdWebTech()

      End If

    End Using

  End Sub

  Private Sub SaveMessageCmdWebTech()

    Dim sqlcmdSave As New SqlCommand("[api_sp_CommandeReapproTechDetailSaveMessage]", MozartDatabase.cnxMozart)
    sqlcmdSave.CommandType = CommandType.StoredProcedure
    sqlcmdSave.Parameters.Add("@P_NCMDWEBTECH", SqlDbType.Int).Value = _NCMDWEBTECH
    sqlcmdSave.Parameters.Add("@P_VMSG", SqlDbType.VarChar).Value = TxtMessages.Text

    sqlcmdSave.ExecuteNonQuery()

  End Sub

End Class