Imports System.Data.SqlClient
Imports MozartLib

Public Class frmThumbFournitures

  Dim DtThumbFou As DataTable
  Dim NFOUNUM As Int32

  Public Sub New(ByVal c_NFOUNUM As Object)

    ' Cet appel est requis par le concepteur.
    InitializeComponent()

    ' Ajoutez une initialisation quelconque après l'appel InitializeComponent().
    NFOUNUM = Convert.ToInt32(c_NFOUNUM)

  End Sub

  Private Sub frmThumbFournitures_Load(sender As System.Object, e As System.EventArgs) Handles MyBase.Load

    DtThumbFou = New DataTable

    Dim sqlcmd As New SqlCommand("api_sp_ListeFileFourniture", MozartDatabase.cnxMozart)

    sqlcmd.CommandType = CommandType.StoredProcedure
        sqlcmd.Parameters.Add("@P_NFOUNUM", SqlDbType.Int).Value = NFOUNUM

        DtThumbFou.Load(sqlcmd.ExecuteReader)

        If DtThumbFou.Rows.Count > 0 Then
            LoadImage()
            Me.Text = String.Format("{0} - Nb Photos : {1}", DtThumbFou.Rows(0).Item("VFOUMAT"), DtThumbFou.Rows.Count)
            Me.TopMost = True
        Else
            'MessageBox.Show("Il n'y a pas d'image pour cette fourniture")
            Me.Close()
        End If

    End Sub

    Private Sub LoadImage()

        For Each DrImgFou As DataRow In DtThumbFou.Rows

            ImageSliderFou.Images.Add(Image.FromFile(DrImgFou("FILEIMGFOU")))

        Next

    End Sub

    Private Sub ImageSliderFou_LostFocus(sender As Object, e As System.EventArgs) Handles ImageSliderFou.LostFocus
        Me.Close()
    End Sub
End Class