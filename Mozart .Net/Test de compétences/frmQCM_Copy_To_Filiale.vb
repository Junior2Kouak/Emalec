Imports System.Data.SqlClient
Imports MozartLib

Public Class frmQCM_Copy_To_Filiale

  Dim DtListeSociete As DataTable
  Dim _NIDQCMNUM As Int32

  Public Sub New(ByVal c_NIDQCMNUM As Int32)

    ' Cet appel est requis par le concepteur.
    InitializeComponent()

    ' Ajoutez une initialisation quelconque après l'appel InitializeComponent().
    _NIDQCMNUM = c_NIDQCMNUM

  End Sub

  Private Sub frmQCM_Copy_To_Filiale_Load(sender As Object, e As EventArgs) Handles MyBase.Load

    LoadData()

    CheckedListBoxControl1.DataSource = DtListeSociete

  End Sub

  Private Sub LoadData()

    DtListeSociete = New DataTable

    Dim sqlcmd As New SqlCommand("SELECT VSOCIETENOM, VSOCIETE_NOM_USUEL FROM	TSOCIETE WHERE VSOCIETEACTIF = 'O' and NSOCIETEID NOT IN (20, 22) AND VSOCIETENOM <> '" & MozartParams.NomSociete & "' ORDER BY VSOCIETE_NOM_USUEL", MozartDatabase.cnxMozart)
    sqlcmd.CommandType = CommandType.Text
    DtListeSociete.Load(sqlcmd.ExecuteReader)

  End Sub

  Private Sub BtnCancel_Click(sender As Object, e As EventArgs) Handles BtnCancel.Click
    Me.Close()
  End Sub

  Private Sub BtnValid_Click(sender As Object, e As EventArgs) Handles BtnValid.Click

    If CheckedListBoxControl1.CheckedItemsCount = 0 Then
      MessageBox.Show("Il faut sélectionner une filiale", My.Resources.Global_Erreur, MessageBoxButtons.OK, MessageBoxIcon.Error)
      Return
    End If


    For i = 0 To CheckedListBoxControl1.ItemCount - 1

      If CheckedListBoxControl1.GetItemChecked(i) = True Then

        Dim sqlcmdCopy As New SqlCommand("[api_sp_DuplicateQCMCauserie]", MozartDatabase.cnxMozart)
        sqlcmdCopy.CommandType = CommandType.StoredProcedure
        sqlcmdCopy.Parameters.Add("@P_NIDQCMNUM_SRC", SqlDbType.Int).Value = _NIDQCMNUM
        sqlcmdCopy.Parameters.Add("@P_VSOCIETE_DEST", SqlDbType.VarChar).Value = CheckedListBoxControl1.GetItemValue(i)
        sqlcmdCopy.ExecuteNonQuery()

      End If

    Next

    'For Each oItem As CheckedListBoxItem In CheckedListBoxControl1.geti0

    '  If oItem.CheckState = CheckState.Checked Then

    '    'oItem.Value
    '    Dim sqlcmdCopy As New SqlCommand("[api_sp_DuplicateQCMCauserie]", cnx)
    '    sqlcmdCopy.CommandType = CommandType.StoredProcedure
    '    sqlcmdCopy.Parameters.Add("@P_NIDQCMNUM_SRC", SqlDbType.Int).Value = _NIDQCMNUM
    '    sqlcmdCopy.Parameters.Add("@P_VSOCIETE_DEST", SqlDbType.VarChar).Value = oItem.Value
    '    sqlcmdCopy.ExecuteNonQuery()


    '  End If

    'Next

    MessageBox.Show("Le(s) QCM ont été copiés avec succès", My.Resources.Global_Confirmation, MessageBoxButtons.OK, MessageBoxIcon.Information)
    Me.Close()


  End Sub

End Class