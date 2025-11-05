Public Class frmStatComptaStructureDetail

    Dim _DtListedata As DataTable

    Public Sub New(ByVal c_dttable As DataTable)

        ' Cet appel est requis par le concepteur.
        InitializeComponent()

        ' Ajoutez une initialisation quelconque après l'appel InitializeComponent().
        _DtListedata = c_dttable

    End Sub

    Private Sub frmStatComptaStructureDetail_Load(sender As System.Object, e As System.EventArgs) Handles MyBase.Load

        GCStatDetail.DataSource = _DtListedata

    End Sub

    Private Sub BtnFermer_Click(sender As System.Object, e As System.EventArgs) Handles BtnFermer.Click

        Me.Close()

    End Sub

 
End Class