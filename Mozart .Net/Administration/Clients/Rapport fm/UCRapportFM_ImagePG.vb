Public Class UCRapportFM_ImagePG

    Dim _oRapportFM As CRapportFM
    Dim DT_Langue As DataTable

    Public Sub New(ByVal c_oRapportFM As CRapportFM)

        ' Cet appel est requis par le concepteur.
        InitializeComponent()

        ' Ajoutez une initialisation quelconque après l'appel InitializeComponent().
        _oRapportFM = c_oRapportFM

    End Sub

    Private Sub UCRapportFM_Periode_Load(sender As Object, e As EventArgs) Handles MyBase.Load

        If Not _oRapportFM.iBandeauClient Is Nothing Then PictureEdit_PG.Image = _oRapportFM.iBandeauClient

    End Sub

    Private Sub BtnLoadIMG_Click(sender As Object, e As EventArgs) Handles BtnLoadIMG.Click

        OFD.Filter = "Tous les fichiers Images |*.jpg;*.bmp;*.png"
        OFD.ShowDialog()

        If OFD.FileName <> "" Then

            PictureEdit_PG.Image = Image.FromFile(OFD.FileName)

        End If

    End Sub

    Private Sub BtnSuppImg_Click(sender As Object, e As EventArgs) Handles BtnSuppImg.Click

        PictureEdit_PG.Image = Nothing

    End Sub
End Class
