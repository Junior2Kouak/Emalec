Public Class frmSaisieCoefPrix

    Dim _bValidCoef As Boolean
    Dim _dCoeff As Decimal

    Dim _NbRowSelect As Int32

    Public ReadOnly Property ValidCoef As Boolean
        Get
            Return _bValidCoef
        End Get
    End Property

    Public ReadOnly Property dCoeff As Decimal
        Get
            Return _dCoeff
        End Get
    End Property

    Public Sub New(ByVal c_NbRowSelect As Int32)

        ' Cet appel est requis par le concepteur.
        InitializeComponent()

        ' Ajoutez une initialisation quelconque après l'appel InitializeComponent().
        _NbRowSelect = c_NbRowSelect

    End Sub

    Private Sub frmSaisieCoefPrix_Load(sender As Object, e As EventArgs) Handles MyBase.Load

        _bValidCoef = False

    End Sub

    Private Sub BtnFermer_Click(sender As Object, e As EventArgs) Handles BtnFermer.Click
        _bValidCoef = False
        Me.Close()
    End Sub

    Private Sub BtnValid_Click(sender As Object, e As EventArgs) Handles BtnValid.Click

        If MessageBox.Show(String.Format("Etes-vous certains d'appliquer le {0} coefficient pour les {1} article(s) sélectionné(s)?", TxtCoef.EditValue, _NbRowSelect), "Confirmation", MessageBoxButtons.YesNoCancel, MessageBoxIcon.Exclamation) = DialogResult.Yes Then

            _dCoeff = TxtCoef.EditValue
            _bValidCoef = True
            Me.Close()

        End If

    End Sub
End Class