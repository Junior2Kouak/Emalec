Public Class frmStarterContratEI

    Dim NCLINUM As Int32
    Dim NIDPROC As Int32
    Dim sTypeOuverture As String

    Public Sub New(ByVal c_NCLINUM As Object, ByVal c_NIDPROC As Object, ByVal c_TypeOuverture As Object)

        ' Cet appel est requis par le concepteur.
        InitializeComponent()

        ' Ajoutez une initialisation quelconque après l'appel InitializeComponent().
        NCLINUM = c_NCLINUM
        NIDPROC = c_NIDPROC
        sTypeOuverture = c_TypeOuverture

    End Sub

    Private Sub frmStarterContratEI_Load(sender As System.Object, e As System.EventArgs) Handles MyBase.Load

        Dim oContratEI As New C_CONTRATEI(NCLINUM, NIDPROC)

        Select Case sTypeOuverture

            Case "C"

                'on force la création
                oContratEI.NIDDOCCONTEI = 0
                oContratEI.NIDPROC = 0

                Dim oFrmSelectSite As New frmDocContratEISelectSite(oContratEI)
                oFrmSelectSite.ShowDialog()

                If File.Exists(oContratEI.FileContratEI) Then

                    Dim oFrmDetailContratEI As New frmDetailContratEI(oContratEI)
                    oFrmDetailContratEI.ShowDialog()

                End If

            Case "M"

                'Dim oContratEI As New C_CONTRATEI(Main_NCLINUM)
                If oContratEI.NIDDOCCONTEI = 0 Then

                    Dim oFrmSelectSite As New frmDocContratEISelectSite(oContratEI)
                    oFrmSelectSite.ShowDialog()

                    If File.Exists(oContratEI.FileContratEI) Then

                        Dim oFrmDetailContratEI As New frmDetailContratEI(oContratEI)
                        oFrmDetailContratEI.ShowDialog()

                    End If

                Else

                    Dim oFrmDetailContratEi As New frmDetailContratEI(oContratEI)
                    oFrmDetailContratEi.ShowDialog()

                End If

            Case "R"

                'Dim oContratEI As New C_CONTRATEI(Main_NCLINUM)
                If oContratEI.NIDDOCCONTEI = 0 Then

                    oContratEI.NIDPROC = 0

                    Dim oFrmSelectSite As New frmDocContratEISelectSite(oContratEI)
                    oFrmSelectSite.ShowDialog()

                    If File.Exists(oContratEI.FileContratEI) Then

                        Dim oFrmDetailContratEI As New frmDetailContratEI(oContratEI)
                        oFrmDetailContratEI.ShowDialog()

                    End If

                Else

                    Dim oFrmDetailContratEi As New frmDetailContratEI(oContratEI, "R")
                    oFrmDetailContratEi.ShowDialog()

                End If




        End Select

        Me.Close()

    End Sub

End Class