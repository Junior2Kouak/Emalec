Imports System.Data.SqlClient
Imports MozartLib

Public Class frmDevisTechnicienPhotos

  Dim _NDEVISTECHNUM As Int32

  Dim oDataTabIMG As DataTable

  Dim pPosInitApercu As Point
  Dim sSizeInitApercu As Size

  Public Sub New(ByVal c_NDEVISTECHNUM As Int32)

    ' Cet appel est requis par le concepteur.
    InitializeComponent()

    ' Ajoutez une initialisation quelconque après l'appel InitializeComponent().
    _NDEVISTECHNUM = c_NDEVISTECHNUM

  End Sub

  Private Sub frmDevisTechnicienPhotos_Load(sender As System.Object, e As System.EventArgs) Handles MyBase.Load

    'Init
    LstVPhotos.LargeImageList = ImgListPhotosDevis
    sSizeInitApercu = GrpBoxPictApercu.Size
    pPosInitApercu = GrpBoxPictApercu.Location

    InitDataGridView()

    OuvertureEnModification()

  End Sub

  Private Sub InitDataGridView()

    'Ajout colonne Libelle
    Dim ColNDEVISTECHPHOTONUM As New Windows.Forms.DataGridViewTextBoxColumn
    ColNDEVISTECHPHOTONUM.DataPropertyName = "NDEVISTECHPHOTONUM"
    ColNDEVISTECHPHOTONUM.Name = "NDEVISTECHPHOTONUM"
    ColNDEVISTECHPHOTONUM.Visible = False

    'Ajout colonne Libelle
    Dim ColNDEVISTECHNUM As New Windows.Forms.DataGridViewTextBoxColumn
    ColNDEVISTECHNUM.DataPropertyName = "NDEVISTECHNUM"
    ColNDEVISTECHNUM.Name = "NDEVISTECHNUM"
    ColNDEVISTECHNUM.Visible = False

    'Ajout colonne Libelle
    Dim ColVDEVISTECHPHOTONOM As New Windows.Forms.DataGridViewTextBoxColumn
    ColVDEVISTECHPHOTONOM.DataPropertyName = "VDEVISTECHPHOTONOM"
    ColVDEVISTECHPHOTONOM.Name = "VDEVISTECHPHOTONOM"
    ColVDEVISTECHPHOTONOM.Visible = True

    'Ajout colonne Libelle
    Dim ColIDEVISTECHIMG As New Windows.Forms.DataGridViewImageColumn
    ColIDEVISTECHIMG.DataPropertyName = "IDEVISTECHIMG"
    ColIDEVISTECHIMG.Name = "IDEVISTECHIMG"
    ColIDEVISTECHIMG.ImageLayout = DataGridViewImageCellLayout.Stretch
    ColIDEVISTECHIMG.Width = DGVPhotosDevis.Width - DGVPhotosDevis.RowHeadersWidth
    ColIDEVISTECHIMG.Visible = True

    DGVPhotosDevis.Columns.Add(ColNDEVISTECHPHOTONUM)
    DGVPhotosDevis.Columns.Add(ColNDEVISTECHNUM)
    DGVPhotosDevis.Columns.Add(ColIDEVISTECHIMG)
    DGVPhotosDevis.Columns.Add(ColVDEVISTECHPHOTONOM)

    DGVPhotosDevis.AllowUserToAddRows = False
    DGVPhotosDevis.AllowUserToDeleteRows = False

  End Sub

  Private Sub btnAjouter_Click(sender As System.Object, e As System.EventArgs) Handles btnAjouter.Click
    Try

      'limitation à 5 photos par devis
      If oDataTabIMG.Rows.Count = 5 Then
        MessageBox.Show(My.Resources.DemandeIntervention_frmDevisTechnicienPhotos_NbMaxImg, My.Resources.Global_Erreur, MessageBoxButtons.OK, MessageBoxIcon.Warning)
        Exit Sub
      End If

      ODF.FileName = ""
      ODF.Multiselect = False
      ODF.Filter = My.Resources.DemandeIntervention_frmDevisTechnicienPhotos_FileImg + " (*.jpg, *.jpeg, *.png, *.gif, *.bmp)|*.jpg|*.jpeg|*.png|*.gif|*.bmp"
      ODF.ShowDialog()

      If ODF.FileName <> "" Then

        Dim NewRowPhotosDevis As DataRow = oDataTabIMG.NewRow

        NewRowPhotosDevis.Item(0) = 0
        NewRowPhotosDevis.Item(1) = _NDEVISTECHNUM
        NewRowPhotosDevis.Item(2) = ConvertImagetoSQL(ImageResizeForImageSQL(ODF.FileName))
        NewRowPhotosDevis.Item(3) = String.Format("Photo_{0}_{1}", _NDEVISTECHNUM, oDataTabIMG.Rows.Count)

        oDataTabIMG.Rows.Add(NewRowPhotosDevis)

        Enregistrer()

        GenerateListeImages()

      End If

    Catch ex As Exception

      MessageBox.Show(ex.Message, My.Resources.Global_Erreur & " - btnAjouter_Click")

    End Try
  End Sub

  Private Function ConvertImagetoSQL(ByVal sNomFicTemp As String) As Byte()

    Try
      Dim fiImage As New FileInfo(sNomFicTemp)

      Dim ILenImg As Long = fiImage.Length
      ReDim ConvertImagetoSQL(ILenImg)

      Dim fs As New FileStream(sNomFicTemp, FileMode.Open, FileAccess.Read, FileShare.Read)
      fs.Read(ConvertImagetoSQL, 0, ILenImg)
      fs.Flush()
      fs.Close()

      Return ConvertImagetoSQL

    Catch ex As Exception

      MessageBox.Show(ex.Message, My.Resources.Global_Erreur & " - ConvertImagetoSQL()")
      Return Nothing

    End Try

  End Function

  Private Function ImageResizeForImageSQL(ByVal sFilename As String) As String

    Try

      Dim sFileTemp As String = Path.GetTempFileName

      Dim myBitmap As New Bitmap(sFilename)

      Dim ratio As Double = myBitmap.Height / myBitmap.Width

      Dim myBitmap2 As New Bitmap(myBitmap, New Size(1024, 1024 * ratio))
      myBitmap2.Save(sFileTemp, System.Drawing.Imaging.ImageFormat.Jpeg)

      Return sFileTemp

    Catch ex As Exception
      MessageBox.Show(ex.Message, My.Resources.Global_Erreur & " - ImageResizeForImageSQL")
      Return Nothing
    End Try

  End Function

  Private Sub BtnDelete_Click(sender As System.Object, e As System.EventArgs) Handles BtnDelete.Click
    If LstVPhotos.SelectedItems.Count = 0 Then

      MessageBox.Show(My.Resources.DemandeIntervention_frmDevisTechnicienPhotos_NoImg, My.Resources.Global_Erreur, MessageBoxButtons.OK, MessageBoxIcon.Exclamation)
      Exit Sub

    End If

    If MessageBox.Show(My.Resources.DemandeIntervention_frmDevisTechnicienPhotos_MsgDel, My.Resources.DemandeIntervention_frmDevisTechnicienPhotos_MsgConfDel, MessageBoxButtons.YesNo) = Windows.Forms.DialogResult.Yes Then

      If LstVPhotos.SelectedItems.Item(0).ImageKey <> 0 Then

        Dim cmddel As New SqlCommand("DELETE FROM TDEVISTECHPHOTO WHERE NDEVISTECHPHOTONUM = " + LstVPhotos.SelectedItems.Item(0).ImageKey.ToString, MozartDatabase.cnxMozart)
        cmddel.ExecuteNonQuery()

                ImgListPhotosDevis.Images.Keys.Remove(LstVPhotos.SelectedItems.Item(0).ImageKey)

                Dim rowDel() As DataRow = oDataTabIMG.Select("NDEVISTECHPHOTONUM = " + LstVPhotos.SelectedItems.Item(0).ImageKey.ToString + " AND NDEVISTECHNUM = " + _NDEVISTECHNUM.ToString)
                oDataTabIMG.Rows.Remove(rowDel(0))

                LstVPhotos.SelectedItems.Item(0).Remove()

                PictureBoxApercu.Image = Nothing

                Enregistrer()

            End If

        End If
    End Sub

    Private Sub BtnRotateP90_Click(sender As System.Object, e As System.EventArgs) Handles BtnRotateP90.Click
        If LstVPhotos.SelectedItems.Count = 0 Then

            MessageBox.Show(My.Resources.DemandeIntervention_frmDevisTechnicienPhotos_NoImg, My.Resources.Global_Erreur, MessageBoxButtons.OK, MessageBoxIcon.Exclamation)
            Exit Sub

        End If

        Dim sSavePostList As Integer = LstVPhotos.SelectedItems.Item(0).Index

        If LstVPhotos.SelectedItems.Item(0).ImageKey <> 0 Then

            Dim SFilenameTemp As String = Path.GetTempFileName()
            Dim rowUpdate() As DataRow = oDataTabIMG.Select("NDEVISTECHPHOTONUM = " + LstVPhotos.SelectedItems.Item(0).ImageKey.ToString + " AND NDEVISTECHNUM = " + _NDEVISTECHNUM.ToString)

            If sender.name = "BtnRotateP90" Then
                PictureBoxApercu.Image.RotateFlip(RotateFlipType.Rotate90FlipNone)
            Else
                PictureBoxApercu.Image.RotateFlip(RotateFlipType.Rotate270FlipNone)
            End If
            PictureBoxApercu.Refresh()
            PictureBoxApercu.Image.Save(SFilenameTemp)

            rowUpdate(0).Item(2) = ConvertImagetoSQL(ImageResizeForImageSQL(SFilenameTemp))
            Enregistrer()

            OuvertureEnModification()

            LstVPhotos.Items(sSavePostList).Selected = True

        End If
    End Sub

    Private Sub btnRotateM90_Click(sender As System.Object, e As System.EventArgs) Handles btnRotateM90.Click
        If LstVPhotos.SelectedItems.Count = 0 Then

            MessageBox.Show(My.Resources.DemandeIntervention_frmDevisTechnicienPhotos_NoImg, My.Resources.Global_Erreur, MessageBoxButtons.OK, MessageBoxIcon.Exclamation)
            Exit Sub

        End If

        Dim sSavePostList As Integer = LstVPhotos.SelectedItems.Item(0).Index

        If LstVPhotos.SelectedItems.Item(0).ImageKey <> 0 Then

            Dim SFilenameTemp As String = Path.GetTempFileName()
            Dim rowUpdate() As DataRow = oDataTabIMG.Select("NDEVISTECHPHOTONUM = " + LstVPhotos.SelectedItems.Item(0).ImageKey.ToString + " AND NDEVISTECHNUM = " + _NDEVISTECHNUM.ToString)

            If sender.name = "BtnRotateP90" Then
                PictureBoxApercu.Image.RotateFlip(RotateFlipType.Rotate90FlipNone)
            Else
                PictureBoxApercu.Image.RotateFlip(RotateFlipType.Rotate270FlipNone)
            End If
            PictureBoxApercu.Refresh()
            PictureBoxApercu.Image.Save(SFilenameTemp)

            rowUpdate(0).Item(2) = ConvertImagetoSQL(ImageResizeForImageSQL(SFilenameTemp))
            Enregistrer()

            OuvertureEnModification()

            LstVPhotos.Items(sSavePostList).Selected = True

        End If
    End Sub

    Private Sub BtnQuit_Click(sender As System.Object, e As System.EventArgs) Handles BtnQuit.Click
        Me.Close()
    End Sub

    Private Sub OuvertureEnModification()

        LoadImagePhotosDevis()

        GenerateListeImages()

    End Sub

    Private Sub LoadImagePhotosDevis()

    Dim cmdPhotosDevis As New SqlCommand("SELECT NDEVISTECHPHOTONUM, NDEVISTECHNUM, IDEVISTECHIMG, VDEVISTECHPHOTONOM FROM TDEVISTECHPHOTO WHERE NDEVISTECHNUM = " + _NDEVISTECHNUM.ToString, MozartDatabase.cnxMozart)
    Dim sqlDataPhotosDevis As SqlDataReader = cmdPhotosDevis.ExecuteReader

        oDataTabIMG = New DataTable

        oDataTabIMG.Load(sqlDataPhotosDevis)

        sqlDataPhotosDevis.Close()

        DGVPhotosDevis.DataSource = oDataTabIMG

    End Sub

    Private Sub GenerateListeImages()

        Try

            LstVPhotos.Items.Clear()
            ImgListPhotosDevis.Images.Clear()

            For Each oRowsLstIMG As DataRow In oDataTabIMG.Rows

                ImgListPhotosDevis.Images.Add(oRowsLstIMG.Item(0).ToString, ConvertSQLToImage(oRowsLstIMG.Item(2)))
                LstVPhotos.Items.Add(oRowsLstIMG.Item(3).ToString, oRowsLstIMG.Item(0).ToString)

            Next

        Catch ex As Exception

            MessageBox.Show(ex.Message, My.Resources.Global_Erreur & " - GenerateListeImages")

        End Try

    End Sub

    Private Function ConvertSQLToImage(ByVal tDataSQLImg As Byte()) As Image

        Dim strnomficcli As String = System.IO.Path.GetTempFileName

        Try

            Dim fscli As New FileStream(strnomficcli, FileMode.Create, FileAccess.Write, FileShare.Write)
            fscli.Write(tDataSQLImg, 0, tDataSQLImg.Length)
            fscli.Flush()
            fscli.Close()
            fscli.Dispose()

            Return Image.FromFile(strnomficcli)

        Catch ex As Exception

            MessageBox.Show(ex.Message, My.Resources.DemandeIntervention_frmDevisTechnicienPhotos_NbMaxImg & " - ConvertSQLToImage")
            Return Nothing

        Finally

            'If File.Exists(strnomficcli) = True Then File.Delete(strnomficcli)

        End Try

    End Function

    Private Sub Enregistrer()

        Try

            For Each oRowsSaveIMG As DataRow In oDataTabIMG.Rows

        'définir la proc stock de sauvegarde
        Dim Cmd As New SqlCommand("api_sp_creationDevisClientPhotos", MozartDatabase.cnxMozart)
        Cmd.CommandType = CommandType.StoredProcedure

                Dim ParamDevisTechPhotoID As SqlParameter = Cmd.Parameters.Add("@ndevistechphotonum", SqlDbType.Int)
                ParamDevisTechPhotoID.Value = oRowsSaveIMG.Item(0)
                Dim ParamDevisTechPhotosDevNum As SqlParameter = Cmd.Parameters.Add("@ndevistechnum", SqlDbType.Int)
                ParamDevisTechPhotosDevNum.Value = oRowsSaveIMG.Item(1)
                Dim ParamDevisTechPhotosIMG As SqlParameter = Cmd.Parameters.Add("@idevistechphoto", SqlDbType.Image)
                ParamDevisTechPhotosIMG.Value = oRowsSaveIMG.Item(2)
                Dim ParamDevisTechPhotosNom As SqlParameter = Cmd.Parameters.Add("@vdevistechphotonom", SqlDbType.VarChar)
                ParamDevisTechPhotosNom.Value = oRowsSaveIMG.Item(3)

                Cmd.ExecuteNonQuery()

            Next

            OuvertureEnModification()

        Catch ex As Exception

            MessageBox.Show(ex.Message, My.Resources.Global_Erreur & " - BtnValider_Click")

        End Try

    End Sub

    Private Sub LstVPhotos_ItemSelectionChanged(ByVal sender As Object, ByVal e As System.Windows.Forms.ListViewItemSelectionChangedEventArgs) Handles LstVPhotos.ItemSelectionChanged

        Dim oApercuRow() As DataRow

        oApercuRow = oDataTabIMG.Select("NDEVISTECHPHOTONUM = " + e.Item.ImageKey.ToString + " AND NDEVISTECHNUM = " + _NDEVISTECHNUM.ToString)

        Dim i As Integer

        For i = 0 To oApercuRow.Length - 1

            PictureBoxApercu.Image = ConvertSQLToImage(oApercuRow(i).Item(2))

        Next

    End Sub

    Private Sub LstVPhotos_MouseDoubleClick(ByVal sender As Object, ByVal e As System.Windows.Forms.MouseEventArgs) Handles LstVPhotos.MouseDoubleClick

        If LstVPhotos.SelectedItems.Count <> 1 Then Return

        Dim sNewName As String = InputBox("Saisir un nom", "Nom de la photo", LstVPhotos.SelectedItems(0).Text)

        If sNewName <> "" Then

            LstVPhotos.SelectedItems(0).Text = sNewName

            oDataTabIMG.Select(String.Format("NDEVISTECHPHOTONUM = {0}", LstVPhotos.SelectedItems(0).ImageKey))(0).Item(3) = sNewName

            LstVPhotos.Focus()

            Enregistrer()

            GenerateListeImages()

        End If

    End Sub

    Private Sub PictureBoxApercu_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles PictureBoxApercu.Click

        If PictureBoxApercu.Image Is Nothing Then Exit Sub

        If PictureBoxApercu.Tag = "ALL" Then
            If btnAjouter.Visible = False Then
                BtnRotateP90.Visible = False
                btnRotateM90.Visible = False
                Label1.Visible = False
            Else
                BtnRotateP90.Visible = True
                BtnRotateM90.Visible = True
                Label1.Visible = True
            End If
            GrpBoxPictApercu.location = pPosInitApercu
            GrpBoxPictApercu.Size = sSizeInitApercu
            PictureBoxApercu.Tag = ""
        Else
            BtnRotateP90.Visible = False
            btnRotateM90.Visible = False
            Label1.Visible = False
            GrpBoxPictApercu.Location = New Point(0, 0)
            GrpBoxPictApercu.Size = New Size(Me.ClientSize.Width, Me.ClientSize.Height)
            PictureBoxApercu.Tag = "ALL"
        End If

    End Sub



End Class