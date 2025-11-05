Public Class frmMenuIndicGMPT_Poste
    Private Sub frmMenuIndicGMPT_Poste_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Initboutons(Me)
    End Sub

    Private Sub BtnFermer_Click(sender As Object, e As EventArgs) Handles BtnFermer.Click
        Me.Close()
    End Sub

    Private Sub BtnTauxDevis_Click(sender As Object, e As EventArgs) Handles BtnTauxDevis.Click

        Dim ofrmTauxConformiteTauxDevisPoste As New frmTauxConformite("D_POSTE")
        ofrmTauxConformiteTauxDevisPoste.ShowDialog()

    End Sub

    Private Sub BtnDelaisMoyen_Click(sender As Object, e As EventArgs) Handles BtnDelaisMoyen.Click

        Dim ofrmTauxConformiteDelaiMoyenPoste As New frmTauxConformite("P_POSTE")
        ofrmTauxConformiteDelaiMoyenPoste.ShowDialog()

    End Sub




End Class