Public Class frmQCMConsigneDetail

    Dim _sConsigne As String

    Public ReadOnly Property sConsigne As String
        Get
            Return _sConsigne
        End Get
    End Property

    Public Sub New(ByVal c_sConsigne As String)

        ' Cet appel est requis par le concepteur.
        InitializeComponent()

        ' Ajoutez une initialisation quelconque après l'appel InitializeComponent().
        _sConsigne = c_sConsigne

    End Sub

    Private Sub frmQCMConsigneDetail_Load(sender As Object, e As EventArgs) Handles MyBase.Load

        RichEditCtrlConsigne.Text = _sConsigne

    End Sub

    Private Sub BtnFermer_Click(sender As Object, e As EventArgs) Handles BtnFermer.Click

        Me.Close()

    End Sub

    Private Sub BtnValider_Click(sender As Object, e As EventArgs) Handles BtnValider.Click
        _sConsigne = RichEditCtrlConsigne.Text
    End Sub


End Class