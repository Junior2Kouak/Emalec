Imports System.Data.SqlClient
Imports MozartLib

Public Class frmQCMImages

  Dim _NIDQCMNUM As Int32
  Dim _NIDQCMQUESTION As Int32

  ReadOnly Property NbImages As Int32
    Get
      Return GetNbImages()
    End Get
  End Property

  Public Sub New(ByVal c_NIDQCMNUM As Int32, ByVal c_NIDQCMQUESTION As Int32)

    ' Cet appel est requis par le concepteur.
    InitializeComponent()

    ' Ajoutez une initialisation quelconque après l'appel InitializeComponent().
    _NIDQCMNUM = c_NIDQCMNUM
    _NIDQCMQUESTION = c_NIDQCMQUESTION

  End Sub
  Private Sub frmQCMImages_Load(sender As Object, e As EventArgs) Handles MyBase.Load

    LoadData()

  End Sub

  Private Sub LoadData()

    'init
    Image1.Image = Nothing
    Image1.Tag = "0"
    Image2.Image = Nothing
    Image2.Tag = "0"
    Image3.Image = Nothing
    Image3.Tag = "0"
    Image4.Image = Nothing
    Image4.Tag = "0"

    Dim sql As New SqlCommand("[api_sp_QCM_GetImagesByQuestion]", MozartDatabase.cnxMozart)
    sql.CommandType = CommandType.StoredProcedure
    sql.Parameters.Add("@P_NIDQCMQUESTION", SqlDbType.Int).Value = _NIDQCMQUESTION

    Dim sqlrd As SqlDataReader = sql.ExecuteReader()

    Dim i As Int32 = 0

    If sqlrd.HasRows Then

      While sqlrd.Read()

        Dim tab As Byte() = sqlrd.Item("IMG_DATA")
        Dim ms As New MemoryStream(tab)

        Select Case i
          Case 0
            Image1.Image = Image.FromStream(ms)
            Image1.Tag = sqlrd.Item("NIDQCM_IMAGE")
            txtImg1.Text = sqlrd.Item("VLIBELLE")
          Case 1
            Image2.Image = Image.FromStream(ms)
            Image2.Tag = sqlrd.Item("NIDQCM_IMAGE")
            txtImg2.Text = sqlrd.Item("VLIBELLE")
          Case 2
            Image3.Image = Image.FromStream(ms)
            Image3.Tag = sqlrd.Item("NIDQCM_IMAGE")
            txtImg3.Text = sqlrd.Item("VLIBELLE")
          Case 3
            Image4.Image = Image.FromStream(ms)
            Image4.Tag = sqlrd.Item("NIDQCM_IMAGE")
            txtImg4.Text = sqlrd.Item("VLIBELLE")
        End Select

        i = i + 1

      End While

    End If
    sqlrd.Close()

  End Sub

  Private Sub BtnSave_Click(sender As Object, e As EventArgs) Handles BtnSave.Click

    'Pour chaque image

    If (Image1.Image IsNot Nothing) Then

      Dim img As Image = Image1.Image
      Dim MS As New MemoryStream
      img.Save(MS, ImageFormat.Png)

      Dim sql As New SqlCommand("[api_sp_QCM_SaveImagesByQuestion]", MozartDatabase.cnxMozart)
      sql.CommandType = CommandType.StoredProcedure
      sql.Parameters.Add("@P_NIDQCM_IMAGE", SqlDbType.Int).Value = Convert.ToInt32(Image1.Tag)
      sql.Parameters.Add("@P_NIDQCMQUESTION", SqlDbType.Int).Value = _NIDQCMQUESTION
      sql.Parameters.Add("@P_IMG_DATA", SqlDbType.VarBinary).Value = MS.ToArray()
      sql.Parameters.Add("@P_VLIBELLE", SqlDbType.VarChar).Value = txtImg1.Text

      sql.ExecuteNonQuery()

    Else

      If Convert.ToInt32(Image1.Tag) > 0 And Image1.Image Is Nothing Then

        'delete
        Dim sql As New SqlCommand("[api_sp_QCM_DeleteImageByQuestion]", MozartDatabase.cnxMozart)
        sql.CommandType = CommandType.StoredProcedure
        sql.Parameters.Add("@P_NIDQCM_IMAGE", SqlDbType.Int).Value = Convert.ToInt32(Image1.Tag)
        sql.ExecuteNonQuery()

      End If

    End If

    If (Image2.Image IsNot Nothing) Then

      Dim img As Image = Image2.Image
      Dim MS As New MemoryStream
      img.Save(MS, ImageFormat.Png)

      Dim sql As New SqlCommand("[api_sp_QCM_SaveImagesByQuestion]", MozartDatabase.cnxMozart)
      sql.CommandType = CommandType.StoredProcedure
      sql.Parameters.Add("@P_NIDQCM_IMAGE", SqlDbType.Int).Value = Convert.ToInt32(Image2.Tag)
      sql.Parameters.Add("@P_NIDQCMQUESTION", SqlDbType.Int).Value = _NIDQCMQUESTION
      sql.Parameters.Add("@P_IMG_DATA", SqlDbType.VarBinary).Value = MS.ToArray()
      sql.Parameters.Add("@P_VLIBELLE", SqlDbType.VarChar).Value = txtImg2.Text

      sql.ExecuteNonQuery()

    Else

      If Convert.ToInt32(Image2.Tag) > 0 And Image2.Image Is Nothing Then

        'delete
        Dim sql As New SqlCommand("[api_sp_QCM_DeleteImageByQuestion]", MozartDatabase.cnxMozart)
        sql.CommandType = CommandType.StoredProcedure
        sql.Parameters.Add("@P_NIDQCM_IMAGE", SqlDbType.Int).Value = Convert.ToInt32(Image2.Tag)
        sql.ExecuteNonQuery()

      End If

    End If

    If (Image3.Image IsNot Nothing) Then

      Dim img As Image = Image3.Image
      Dim MS As New MemoryStream
      img.Save(MS, ImageFormat.Png)

      Dim sql As New SqlCommand("[api_sp_QCM_SaveImagesByQuestion]", MozartDatabase.cnxMozart)
      sql.CommandType = CommandType.StoredProcedure
      sql.Parameters.Add("@P_NIDQCM_IMAGE", SqlDbType.Int).Value = Convert.ToInt32(Image3.Tag)
      sql.Parameters.Add("@P_NIDQCMQUESTION", SqlDbType.Int).Value = _NIDQCMQUESTION
      sql.Parameters.Add("@P_IMG_DATA", SqlDbType.VarBinary).Value = MS.ToArray()
      sql.Parameters.Add("@P_VLIBELLE", SqlDbType.VarChar).Value = txtImg3.Text

      sql.ExecuteNonQuery()

    Else

      If Convert.ToInt32(Image3.Tag) > 0 And Image3.Image Is Nothing Then

        'delete
        Dim sql As New SqlCommand("[api_sp_QCM_DeleteImageByQuestion]", MozartDatabase.cnxMozart)
        sql.CommandType = CommandType.StoredProcedure
        sql.Parameters.Add("@P_NIDQCM_IMAGE", SqlDbType.Int).Value = Convert.ToInt32(Image3.Tag)
        sql.ExecuteNonQuery()

      End If

    End If

    If (Image4.Image IsNot Nothing) Then

      Dim img As Image = Image4.Image
      Dim MS As New MemoryStream
      img.Save(MS, ImageFormat.Png)

      Dim sql As New SqlCommand("[api_sp_QCM_SaveImagesByQuestion]", MozartDatabase.cnxMozart)
      sql.CommandType = CommandType.StoredProcedure
      sql.Parameters.Add("@P_NIDQCM_IMAGE", SqlDbType.Int).Value = Convert.ToInt32(Image4.Tag)
      sql.Parameters.Add("@P_NIDQCMQUESTION", SqlDbType.Int).Value = _NIDQCMQUESTION
      sql.Parameters.Add("@P_IMG_DATA", SqlDbType.VarBinary).Value = MS.ToArray()
      sql.Parameters.Add("@P_VLIBELLE", SqlDbType.VarChar).Value = txtImg4.Text

      sql.ExecuteNonQuery()

    Else

      If Convert.ToInt32(Image4.Tag) > 0 And Image4.Image Is Nothing Then

        'delete
        Dim sql As New SqlCommand("[api_sp_QCM_DeleteImageByQuestion]", MozartDatabase.cnxMozart)
        sql.CommandType = CommandType.StoredProcedure
        sql.Parameters.Add("@P_NIDQCM_IMAGE", SqlDbType.Int).Value = Convert.ToInt32(Image4.Tag)
        sql.ExecuteNonQuery()

      End If

    End If

    LoadData()

  End Sub

  Private Sub BtnAddImg1_Click(sender As Object, e As EventArgs) Handles BtnAddImg1.Click, BtnAddImg2.Click, BtnAddImg3.Click, BtnAddImg4.Click
    OFD.ShowDialog()
    If OFD.FileName <> "" Then
      Select Case CType(sender, Button).Name
        Case "BtnAddImg1"
          Image1.Image = Image.FromFile(OFD.FileName)
        Case "BtnAddImg2"
          Image2.Image = Image.FromFile(OFD.FileName)
        Case "BtnAddImg3"
          Image3.Image = Image.FromFile(OFD.FileName)
        Case "BtnAddImg4"
          Image4.Image = Image.FromFile(OFD.FileName)

      End Select

    End If

  End Sub

  Private Sub BtnDelImg1_Click(sender As Object, e As EventArgs) Handles BtnDelImg1.Click, BtnDelImg2.Click, BtnDelImg3.Click, BtnDelImg4.Click

    Select Case CType(sender, Button).Name
      Case "BtnDelImg1"
        Image1.Image = Nothing
      Case "BtnDelImg2"
        Image2.Image = Nothing
      Case "BtnDelImg3"
        Image3.Image = Nothing
      Case "BtnDelImg4"
        Image4.Image = Nothing

    End Select

  End Sub

  Private Sub BtnFermer_Click(sender As Object, e As EventArgs) Handles BtnFermer.Click
    Me.Close()
  End Sub

  Private Function GetNbImages() As Int32

    Dim _NbImages As Int32 = 0

    If Image1.Image IsNot Nothing Then _NbImages = _NbImages + 1
    If Image2.Image IsNot Nothing Then _NbImages = _NbImages + 1
    If Image3.Image IsNot Nothing Then _NbImages = _NbImages + 1
    If Image4.Image IsNot Nothing Then _NbImages = _NbImages + 1

    Return _NbImages

  End Function

  Private Sub BtnRotateP90_Click(sender As Object, e As EventArgs) Handles BtnRotateP90.Click
    Image1.Image.RotateFlip(RotateFlipType.Rotate90FlipNone)
    Image1.Refresh()
  End Sub

  Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
    Image2.Image.RotateFlip(RotateFlipType.Rotate90FlipNone)
    Image2.Refresh()
  End Sub

  Private Sub Button3_Click(sender As Object, e As EventArgs) Handles Button3.Click
    Image3.Image.RotateFlip(RotateFlipType.Rotate90FlipNone)
    Image3.Refresh()
  End Sub

  Private Sub Button2_Click(sender As Object, e As EventArgs) Handles Button2.Click
    Image4.Image.RotateFlip(RotateFlipType.Rotate90FlipNone)
    Image4.Refresh()
  End Sub
End Class