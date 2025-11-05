Public Class frmConvertTimeToCentieme


    Dim oValCentieme As Decimal
    Dim oValTime As DateTime

    Dim _OutNQTEMO As Decimal
    Dim _bValid As Boolean = False

    Public ReadOnly Property bValid As Boolean
        Get
            Return _bValid
        End Get
    End Property

    Public ReadOnly Property NQTEMO As Decimal
        Get
            Return _OutNQTEMO
        End Get
    End Property

    Public Sub New(ByVal c_ValCentieme As Decimal)

        ' Cet appel est requis par le concepteur.
        InitializeComponent()

        ' Ajoutez une initialisation quelconque après l'appel InitializeComponent().
        oValCentieme = c_ValCentieme

    End Sub

    Private Sub frmConvertTimeToCentieme_Load(sender As Object, e As EventArgs) Handles MyBase.Load

        Txt_Qte.Text = oValCentieme

    End Sub

    Private Sub BtnQuit_Click(sender As Object, e As EventArgs) Handles BtnQuit.Click
        Me.Close()
    End Sub

    Private Sub TxtCentieme_TextChanged(sender As Object, e As EventArgs) Handles Txt_Qte.EditValueChanged

        If Txt_Qte.Text <> "" Then TimeEdit1.Time = CalculCentiemeToTime()

    End Sub

    Private Function CalculCentiemeToTime() As DateTime

        Dim nb_Hr As Int32
        Dim Minute As Int32
        Dim centieme As Int32

        If Txt_Qte.Text.ToString.IndexOf(",") < 2 Then
            nb_Hr = Txt_Qte.Text.ToString.Substring(0, 1)
        Else
            nb_Hr = Txt_Qte.Text.ToString.Substring(0, Txt_Qte.Text.ToString.IndexOf(","))
        End If

        If Txt_Qte.Text.ToString.IndexOf(",") = 0 Then
            Minute = 0
        Else
            centieme = Txt_Qte.Text.ToString.Substring(Txt_Qte.Text.ToString.IndexOf(",") + 1, Txt_Qte.Text.ToString.Length - Txt_Qte.Text.ToString.IndexOf(",") - 1)

            Minute = (60 / 100) * centieme

        End If

        Dim dur As New TimeSpan(nb_Hr, Minute, 0)

        Return Convert.ToDateTime(DateTime.Now.Date + dur)

    End Function

    Private Function CalculTimeToCentieme() As Decimal

        Dim nb_Hr As Int32
        Dim Minute As Int32

        nb_Hr = TimeEdit1.Time.Hour

        Minute = TimeEdit1.Time.Minute

        Return nb_Hr + (((100 / 60) * Minute) * 0.01)

    End Function

    Private Sub TimeEdit1_EditValueChanged(sender As Object, e As EventArgs) Handles TimeEdit1.EditValueChanged

        Txt_Qte.Text = CalculTimeToCentieme()

    End Sub

    Private Sub BtnValid_Click(sender As Object, e As EventArgs) Handles BtnValid.Click

        If Txt_Qte.Text = "" Then
            MessageBox.Show("Validation impossible car la quantité n'est pas renseignée !", "Erreur", MessageBoxButtons.OK, MessageBoxIcon.Exclamation)
            Exit Sub
        End If

        _bValid = True

        _OutNQTEMO = Convert.ToDecimal(Txt_Qte.Text)

        Me.Close()

    End Sub
End Class