Imports System.Data.SqlClient
Imports MozartLib

Public Class FrmDetailSerieFO

  Dim _NCFOCOD As String
  Dim _Langue As String
  Dim _sNameSerie As String

  Public Sub New(ByVal c_NCFOCOD As String, c_Langue As String, Optional ByVal c_sNameSerie As String = "")

    ' Cet appel est requis par le concepteur.
    InitializeComponent()

    ' Ajoutez une initialisation quelconque après l'appel InitializeComponent().
    _NCFOCOD = c_NCFOCOD
    _Langue = c_Langue
    _sNameSerie = c_sNameSerie

  End Sub

  Private Sub FrmDetailSerieFO_Load(sender As Object, e As EventArgs) Handles MyBase.Load

    TxtNomSerie.Text = _sNameSerie

  End Sub

  Private Sub BtnCancel_Click(sender As Object, e As EventArgs) Handles BtnCancel.Click
    Me.Close()
  End Sub

  Private Sub BtnOK_Click(sender As Object, e As EventArgs) Handles BtnOK.Click

    If TxtNomSerie.Text = "" Then MessageBox.Show("Il faut saisir un libellé", "Erreur", MessageBoxButtons.OK, MessageBoxIcon.Exclamation) : Exit Sub

    Dim sqlcmdupdate As New SqlCommand("[api_sp_SerieFo_Create]", MozartDatabase.cnxMozart)
    sqlcmdupdate.CommandType = CommandType.StoredProcedure
        sqlcmdupdate.Parameters.Add("@p_NCFOCOD", SqlDbType.Int).Value = _NCFOCOD
        sqlcmdupdate.Parameters.Add("@p_CCFOCOD", SqlDbType.VarChar).Value = TxtNomSerie.Text
        sqlcmdupdate.Parameters.Add("@p_LANGUE", SqlDbType.VarChar).Value = _Langue
        sqlcmdupdate.ExecuteNonQuery()

        Me.Close()

    End Sub
End Class