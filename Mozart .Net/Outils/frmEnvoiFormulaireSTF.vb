
Imports System.Data.SqlClient
Imports System.Web.HttpUtility
Imports MozartLib

Public Class frmEnvoiFormulaireSTF

  Dim sContact As Integer


  Public Sub New(ByVal c_iType As Object)

    ' Cet appel est requis par le concepteur.
    InitializeComponent()

    ' Ajoutez une initialisation quelconque après l'appel InitializeComponent().
    sContact = Convert.ToInt32(c_iType)

  End Sub


  Private Sub frmEnvoiFormulaireSTF_Load(sender As Object, e As System.EventArgs) Handles Me.Load

    Dim sSQL_Requery As String
    Dim sMessage As String
    Dim dr As SqlDataReader
    Dim cmd As SqlCommand

    Try

      Cursor = Cursors.WaitCursor

      cmd = New SqlCommand("api_sp_MailFormulaireSTT " & sContact & "," & MozartParams.UID, MozartDatabase.cnxMozart)
      dr = cmd.ExecuteReader
      dr.Read()
      sMessage = dr("MESSAGE")
      sMessage = sMessage.Replace("#NINTNUM#", sContact)
      sMessage = sMessage.Replace("#LANGUE#", dr("LANGUE"))
      Dim oGenCrypt As New C_CRYPTAGE("apitech")
      sMessage = sMessage.Replace("#NSTFNUM#", UrlEncode(oGenCrypt.AES_Encrypt(dr("NSTFNUM"))))

      sSQL_Requery = "EXEC msdb..sp_send_dbmail "
      sSQL_Requery = sSQL_Requery & "@profile_name = 'Web" & MozartParams.NomSociete & "', "
      sSQL_Requery = sSQL_Requery & "@recipients   = '" & dr("VINTMAIL") & "', "
      ' TB SAMSIC CITY SPEC
      ' Email spécifique au domaine de Emalec
      sSQL_Requery = sSQL_Requery & "@copy_recipients = 'stt@emalec.com', " '& dr("VPERMAILPRO") & "', "            NL, le 16/04/17
      sSQL_Requery = sSQL_Requery & "@body         = '" & sMessage.Replace("'", "''") & "', "
      sSQL_Requery = sSQL_Requery & "@body_format  = 'HTML', "
      sSQL_Requery = sSQL_Requery & "@subject      = '" & dr("SUBJECT").ToString.Replace("'", "''") & "', " 'EMALEC', "         NL, le 16/04/17
      ' TB SAMSIC CITY SPEC
      ' Email avec le nom de domaine de Emalec
      sSQL_Requery = sSQL_Requery & "@blind_copy_recipients ='info@emalec.com'"

      dr.Close()

      Try
        Dim sqlcmdSend As New SqlCommand(sSQL_Requery, MozartDatabase.cnxMozart)
        sqlcmdSend.ExecuteNonQuery()
        MessageBox.Show(My.Resources.Global_mail_envoyé, My.Resources.Global_confirmation_envoi, MessageBoxButtons.OK, MessageBoxIcon.Information)
        Me.Close()
      Catch ex As Exception
        MessageBox.Show(My.Resources.Outils_frmEnvoiFormulaireSTF_erreur, My.Resources.Global_Erreur, MessageBoxButtons.OK, MessageBoxIcon.Error)
      End Try

    Catch ex As Exception
      MessageBox.Show(My.Resources.Outils_frmEnvoiFormulaireSTF_SubLoad + ex.Message, My.Resources.Global_Erreur, MessageBoxButtons.OK, MessageBoxIcon.Error)

    Finally
      Me.Cursor = Cursors.Default
      Me.Close()
    End Try
  End Sub

End Class