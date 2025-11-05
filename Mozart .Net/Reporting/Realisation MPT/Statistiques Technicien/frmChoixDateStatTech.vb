Public Class frmChoixDateStatTech

    Dim sType As String

    Public Sub New(ByVal c_sType As Object)

        ' Cet appel est requis par le concepteur.
        InitializeComponent()

        ' Ajoutez une initialisation quelconque après l'appel InitializeComponent().
        sType = c_sType.ToString

    End Sub

    Private Sub frmChoixDateStatTech_Load(sender As System.Object, e As System.EventArgs) Handles MyBase.Load

        Initboutons(Me)

        'init
        If sType = "C" Then
            RBSYNTHTECH.Visible = True
        Else
            RBSYNTHTECH.Visible = False
        End If

        DTPFin.Value = Now.Date
        DTPDebut.Value = DTPFin.Value.AddYears(-1)

    End Sub

    Private Sub BtnValid_Click(sender As System.Object, e As System.EventArgs) Handles BtnValid.Click

        If RBHREXE.Checked Then

            Dim ofrmstatHREXE As New frmStatHeureTech(sType, DTPDebut.Value, DTPFin.Value)
            ofrmstatHREXE.ShowDialog()

        ElseIf RBFOFAC.Checked Then

            Dim ofrmstatFOFAC As New frmStatFournitureTech(sType, DTPDebut.Value, DTPFin.Value)
            ofrmstatFOFAC.ShowDialog()

        ElseIf RBKMPER.Checked Then

            ' si stat techniciens alors on va vers frmStatTechniciens sinon stat contremaitre vers StatContremaitre
            If sType = "T" Then
                Dim ofrmStatKMPER As New frmStatTechniciens("KM", DTPDebut.Value, DTPFin.Value)
                ofrmStatKMPER.ShowDialog()
            Else
                Dim ofrmStatKMPER As New frmStatContremaitre("KM", DTPDebut.Value, DTPFin.Value)
                ofrmStatKMPER.ShowDialog()
            End If

        ElseIf RBDEVTECH.Checked Then

            ' si stat techniciens alors on va vers frmStatTechniciens sinon stat contremaitre vers StatContremaitre
            If sType = "T" Then
                Dim ofrmStatDEVTECH As New frmStatTechniciens("DEVWEB", DTPDebut.Value, DTPFin.Value)
                ofrmStatDEVTECH.ShowDialog()
            Else
                Dim ofrmStatDEVTECH As New frmStatContremaitre("DEVWEB", DTPDebut.Value, DTPFin.Value)
                ofrmStatDEVTECH.ShowDialog()
            End If

        ElseIf RBFACTECH.Checked Then

            ' si stat techniciens alors on va vers frmStatTechniciens sinon stat contremaitre vers StatContremaitre
            If sType = "T" Then
                Dim ofrmStatFACTECH As New frmStatTechniciens("FACT", DTPDebut.Value, DTPFin.Value)
                ofrmStatFACTECH.ShowDialog()
            Else
                Dim ofrmStatFACTECH As New frmStatContremaitre("FACT", DTPDebut.Value, DTPFin.Value)
                ofrmStatFACTECH.ShowDialog()
            End If

        ElseIf RBSYNTHTECH.Checked Then

            Dim ofrmStatSYNTHTECH As New frmStatSyntContreMaitre(DTPDebut.Value, DTPFin.Value)
            ofrmStatSYNTHTECH.ShowDialog()

        ElseIf RBEVOLTECH.Checked Then

            Dim ofrmstatEvolTech As New frmStatTechEvolIndic()
            ofrmstatEvolTech.sDateDebut = DTPFin.Value.AddMonths(-12)
            ofrmstatEvolTech.sDateFin = DTPFin.Value
            ofrmstatEvolTech.ShowDialog()

        End If

    End Sub

    Private Sub cmdfermer_Click(sender As System.Object, e As System.EventArgs) Handles cmdfermer.Click
        Me.Close()
    End Sub

    Private Sub RBEVOLTECH_CheckedChanged(sender As Object, e As EventArgs) Handles RBEVOLTECH.CheckedChanged

        DTPDebut.Visible = Not RBEVOLTECH.Checked
        LblDateDeb.Visible = Not RBEVOLTECH.Checked

    End Sub
End Class