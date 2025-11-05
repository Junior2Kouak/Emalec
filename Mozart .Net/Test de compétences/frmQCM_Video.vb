Imports System.Data.SqlClient
Imports MozartLib

Public Class frmQCM_Video

  Dim _NIDQCMNUM As Int32
  Dim _NIDQCMVIDEO As Int32
  Dim dtQCMVideo As DataTable
  Dim _VideoExist As Boolean
  ReadOnly Property VideoExist As Boolean
    Get
      Return If(_NIDQCMVIDEO > 0, True, False)
    End Get
  End Property
  Public Sub New(ByVal c_NIDQCMNUM As Int32)

    ' Cet appel est requis par le concepteur.
    InitializeComponent()

    ' Ajoutez une initialisation quelconque après l'appel InitializeComponent().
    _NIDQCMNUM = c_NIDQCMNUM

  End Sub

  Private Sub frmQCM_Video_Load(sender As Object, e As EventArgs) Handles MyBase.Load

    Initboutons(Me)

    LoadData()
  End Sub

  Private Sub LoadData()

    dtQCMVideo = New DataTable

    Dim sql As New SqlCommand("[api_sp_QCM_LoadVideo]", MozartDatabase.cnxMozart)
    sql.CommandType = CommandType.StoredProcedure
    sql.Parameters.Add("@P_NIDQCMNUM", SqlDbType.Int).Value = _NIDQCMNUM
    dtQCMVideo.Load(sql.ExecuteReader)

    If dtQCMVideo.Rows.Count > 0 Then

      _NIDQCMVIDEO = dtQCMVideo.Rows(0).Item("NIDQCMVIDEO")
      TxtTitre.Text = dtQCMVideo.Rows(0).Item("VTITRE")
      TxtLienVideo.Text = dtQCMVideo.Rows(0).Item("VURL_VIDEO")
      TxtNotes.Text = dtQCMVideo.Rows(0).Item("VNOTES")

      If TxtLienVideo.Text <> "" Then BtnLoadVideo.PerformClick()

    End If

  End Sub


  Private Sub BtnFermer_Click(sender As Object, e As EventArgs) Handles BtnFermer.Click
    Me.Close()
  End Sub

  Private Sub BtnLoadVideo_Click(sender As Object, e As EventArgs) Handles BtnLoadVideo.Click
    If TxtLienVideo.Text <> "" Then

      WVVisu.Source = New Uri(TxtLienVideo.Text)
      'WVVisu.CoreWebView2.Navigate(TxtLienVideo.Text)

    Else
      WVVisu.Source = Nothing
    End If
  End Sub

  Private Sub BtnSave_Click(sender As Object, e As EventArgs) Handles BtnSave.Click

    Dim sql As New SqlCommand("[api_sp_QCM_SaveVideo]", MozartDatabase.cnxMozart)
    sql.CommandType = CommandType.StoredProcedure
    sql.Parameters.Add("@P_NIDQCMVIDEO", SqlDbType.Int).Value = _NIDQCMVIDEO
    sql.Parameters.Add("@P_NIDQCMNUM", SqlDbType.Int).Value = _NIDQCMNUM
    sql.Parameters.Add("@P_VTITRE", SqlDbType.VarChar).Value = TxtTitre.Text
    sql.Parameters.Add("@P_VURL_VIDEO", SqlDbType.VarChar).Value = TxtLienVideo.Text
    sql.Parameters.Add("@P_VNOTES", SqlDbType.VarChar).Value = TxtNotes.Text

    sql.ExecuteNonQuery()

    LoadData()

  End Sub

  Private Sub BtnDelVideo_Click_1(sender As Object, e As EventArgs) Handles BtnDelVideo.Click


    If MessageBox.Show("Voulez-vous vraiment supprimer cette vidéo ?", "Suppression", MessageBoxButtons.YesNoCancel) <> DialogResult.Yes Then Return

    If _NIDQCMVIDEO > 0 Then

      Dim sql As New SqlCommand("[api_sp_QCM_DeleteVideo]", MozartDatabase.cnxMozart)
      sql.CommandType = CommandType.StoredProcedure
      sql.Parameters.Add("@P_NIDQCMVIDEO", SqlDbType.Int).Value = _NIDQCMVIDEO

      sql.ExecuteNonQuery()

      _NIDQCMVIDEO = 0
    End If

    LoadData()
    WVVisu.Source = New Uri("about:blank")
  End Sub
End Class