Imports System.Data.SqlClient
Imports System.IO
Imports MozartLib

Public Class frmSignaturePersonnel


  Dim _NPERNUM As Int32
  Public Sub New(ByVal C_NPERNUM As Object)

    ' Cet appel est requis par le concepteur.
    InitializeComponent()

    ' Ajoutez une initialisation quelconque après l'appel InitializeComponent().
    _NPERNUM = Convert.ToInt32(C_NPERNUM)

  End Sub

  Private Sub frmSignaturePersonnel_Load(sender As Object, e As EventArgs) Handles MyBase.Load

    loadata()

  End Sub

  Private Sub loadata()

    Dim sqlcmdread As New SqlCommand("[api_sp_GetSignaturePersonnel]", MozartDatabase.cnxMozart)
    sqlcmdread.CommandType = CommandType.StoredProcedure
        sqlcmdread.Parameters.Add("@NPERNUM", SqlDbType.Int).Value = _NPERNUM
        Dim dr As SqlDataReader = sqlcmdread.ExecuteReader

        If dr.HasRows Then

            dr.Read()

            If IsDBNull(dr.Item("OPERSIGNATURE")) = False Then

                Using mStream As New MemoryStream(TryCast(dr.Item("OPERSIGNATURE"), Byte()).ToArray)
                    PictSignature.Image = Image.FromStream(mStream)
                End Using

            Else

                PictSignature.Image = Nothing

            End If

        End If

        dr.Close()

    End Sub
    
    Private Sub BtnFermer_Click(sender As Object, e As EventArgs) Handles BtnFermer.Click
        Me.Close()
    End Sub

    Private Sub BtnSave_Click(sender As Object, e As EventArgs) Handles BtnSave.Click


        If MessageBox.Show("Voulez-vous enregistrer cette signature ?", "Confirmation", MessageBoxButtons.YesNoCancel, MessageBoxIcon.Question) = DialogResult.Yes Then

      Dim sqlcmdsave As New SqlCommand("[api_sp_SaveSignaturePersonnel]", MozartDatabase.cnxMozart)
      sqlcmdsave.CommandType = CommandType.StoredProcedure
            sqlcmdsave.Parameters.Add("@NPERNUM", SqlDbType.Int).Value = _NPERNUM
            sqlcmdsave.Parameters.Add("@OFILESIGNATURE", SqlDbType.VarBinary)
            If Not PictSignature.Image Is Nothing Then
                Dim oImgConverter As New ImageConverter
                sqlcmdsave.Parameters("@OFILESIGNATURE").Value = oImgConverter.ConvertTo(PictSignature.Image, GetType(Byte()))
            Else
                sqlcmdsave.Parameters("@OFILESIGNATURE").Value = DBNull.Value
            End If

            sqlcmdsave.ExecuteNonQuery()

        End If

    End Sub

    Private Sub BtnLoadImage_Click(sender As Object, e As EventArgs) Handles BtnLoadImage.Click

        OFD.Filter = "Fichiers PNG (*.png) |*.png"
        OFD.ShowDialog()

        If OFD.FileName <> "" Then

            PictSignature.Image = Image.FromFile(OFD.FileName)

        End If

    End Sub

    Private Sub BtmClear_Click(sender As Object, e As EventArgs) Handles BtmClear.Click

        If MessageBox.Show("Voulez-vous vraiment supprimer cette signature ?", "Confirmation suppression", MessageBoxButtons.YesNoCancel, MessageBoxIcon.Question) = DialogResult.Yes Then

            PictSignature.Image = Nothing

        End If

    End Sub
End Class