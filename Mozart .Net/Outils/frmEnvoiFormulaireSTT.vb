
Imports System.Data.SqlClient


Public Class frmEnvoiFormulaireSTT

  Dim CnxGrid As New CGestionSQL
  Dim sContact As Integer


  Public Sub New(ByVal c_sType As Integer, ByVal c_datedebut As Date, ByVal c_datefin As Date)

    ' Cet appel est requis par le concepteur.
    InitializeComponent()

    ' Ajoutez une initialisation quelconque après l'appel InitializeComponent().
    sContact = c_sType

  End Sub

  
  Private Sub frmListeTelephone_Load(sender As Object, e As System.EventArgs) Handles Me.Load

    Dim sSQL_Requery As String
    Dim nMO As Integer
    Dim nFO As Integer
    Dim nSTT As Integer
    Dim dr As SqlDataReader
    Dim cmd As SqlCommand

    Try


      If CnxGrid.ConnexionSQLTimeOut(ModuleMain.gstrNomServeur, ModuleMain.gstrNomSociete, 60000) = True Then

        Me.Cursor = Cursors.WaitCursor


        ' recherche du texte du mail dans la langue du contact sous-traitant
        Dim cmdLoadList As New SqlCommand("api_sp_MailFormulaireSTT", CnxGrid.CnxSQLOpen)

        cmd = New SqlCommand("api_sp_MailFormulaireSTT " & sContact, cnx)
        'cmd.CommandType = CommandType.Text
        dr = cmd.ExecuteReader
        dr.Read()
        nMO = dr("NMO")

        sSQL_Requery = "EXEC msdb..sp_send_dbmail "
        sSQL_Requery = sSQL_Requery & "@profile_name = 'Web" & gstrNomSociete & "', "
        sSQL_Requery = sSQL_Requery & "@recipients   = '" & dr("NMO") & "', "
        sSQL_Requery = sSQL_Requery & "@body         = '" & dr("NMO").Replace("'", "''") & "', "
        sSQL_Requery = sSQL_Requery & "@subject      = '" & dr("NMO").Replace("'", "''") & "', "
        sSQL_Requery = sSQL_Requery & "@copy_recipients ='" & dr("NMO") & "', "
        sSQL_Requery = sSQL_Requery & "@blind_copy_recipients ='" & dr("NMO") & "'"

        dr.Close()

        Try
          Dim sqlcmdSend As New SqlCommand(sSQL_Requery, CnxGrid.CnxSQLOpen)
          sqlcmdSend.ExecuteNonQuery()
          MessageBox.Show("Le mail a été envoyé !", "Confirmation envoi", MessageBoxButtons.OK, MessageBoxIcon.Information)
          End
        Catch ex As Exception
          MessageBox.Show("Erreur dans frmEnvoiFormulaireSTT_Load", "Erreur", MessageBoxButtons.OK, MessageBoxIcon.Error)
        End Try

      Else

        MessageBox.Show(String.Format("Le serveur {0} ne répond pas !", ModuleMain.gstrNomServeur), "Erreur", MessageBoxButtons.OK, MessageBoxIcon.Exclamation)

      End If

    Catch ex As Exception
      MessageBox.Show("Sub frmEnvoiFormulaireSTT_Load dans frmListeTelephone : " + ex.Message, "Erreur", MessageBoxButtons.OK, MessageBoxIcon.Error)

    Finally
      Me.Cursor = Cursors.Default
      End
    End Try
  End Sub

  Private Sub frmListeTelephone_FormClosing(sender As Object, e As System.Windows.Forms.FormClosingEventArgs) Handles Me.FormClosing
    CnxGrid.CloseConnexionSQL()
  End Sub

End Class