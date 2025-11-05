Imports System.Data.SqlClient
Imports MozartLib

Public Class frmGestModifContrat_Histo

  Dim dtLstGestModif_Histo As DataTable

  Private Sub frmGestModifContrat_Histo_Load(sender As System.Object, e As System.EventArgs) Handles MyBase.Load

    Try

      LoadListeGestContrat()

    Catch ex As Exception

      MessageBox.Show(ex.Message)

    End Try

  End Sub

  Private Sub LoadListeGestContrat()

    dtLstGestModif_Histo = New DataTable
    dtLstGestModif_Histo = ModDataGridView.LoadList("[api_sp_ListeGestionModifCompetence_Histo]", MozartDatabase.cnxMozart)

    GCHisto_Modif.DataSource = dtLstGestModif_Histo

    End Sub

    Private Sub BtnClose_Click(sender As System.Object, e As System.EventArgs) Handles BtnClose.Click
        Me.Close()
    End Sub

End Class