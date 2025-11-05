Imports System.Data.SqlClient
Imports MozartLib

Public Class frmListeTelephone


  Dim CnxGrid As New CGestionSQL

  Dim ds As DataSet


  Private Sub frmListeTelephone_FormClosing(sender As Object, e As System.Windows.Forms.FormClosingEventArgs) Handles Me.FormClosing
    CnxGrid.CloseConnexionSQL()
  End Sub
  Private Sub frmListeTelephone_Load(sender As Object, e As System.EventArgs) Handles Me.Load
    Try


      If CnxGrid.ConnexionSQLTimeOut(MozartParams.NomServeur, MozartParams.NomSociete, 60000) = True Then



        Me.Cursor = Cursors.WaitCursor

        ds = New DataSet

        Dim cmdLoadList As New SqlCommand("api_sp_ListeTelephoneNumComplet", CnxGrid.CnxSQLOpen)
        cmdLoadList.CommandType = CommandType.StoredProcedure
        'sqlcmd
        cmdLoadList.Parameters.Add("@societe", SqlDbType.VarChar)
        cmdLoadList.Parameters("@societe").Value = MozartParams.NomSociete

        Dim sqlAdpat As SqlDataAdapter = New SqlDataAdapter(cmdLoadList)
        sqlAdpat.Fill(ds)

        GCLISTETEL.DataSource = ds.Tables(0)
      End If

    Catch ex As Exception

      MessageBox.Show(My.Resources.Outils_frmListeTelephone_SubLoad + ex.Message, My.Resources.Global_Erreur, MessageBoxButtons.OK, MessageBoxIcon.Error)

    Finally

      Me.Cursor = Cursors.Default

    End Try
  End Sub

  Private Sub BtnFermer_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles BtnFermer.Click
    Me.Close()
  End Sub
End Class