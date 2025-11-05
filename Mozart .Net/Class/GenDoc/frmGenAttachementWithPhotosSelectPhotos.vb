Imports System.Data.SqlClient
Imports DevExpress.Pdf
Imports DevExpress.XtraEditors.Controls
Imports DevExpress.XtraGrid.Views.Base
Imports DevExpress.XtraPrinting
Imports MozartLib
Imports REPORT = ReportEmalec.Net

Public Class frmGenAttachementWithPhotosSelectPhotos

  Dim _DtListePhotosAct As DataTable
  Dim _NACTNUM As Int32
  Dim _NIMAGE As Int32
  Dim sFileOutPDF As String
  Dim sPathImg As String
  Dim lPathDestDoc As String
  Dim _Origin As Int16  '1= tech, 2 = sous traitant

  Public Sub New(ByVal c_NACTNUM As Object, ByVal sFileName As String, ByVal sPath As String, ByVal C_NIMAGE As Object, ByVal C_Origin As Object)

    ' Cet appel est requis par le concepteur.
    InitializeComponent()

    ' Ajoutez une initialisation quelconque après l'appel InitializeComponent().
    _NACTNUM = c_NACTNUM
    _NIMAGE = C_NIMAGE
    sFileOutPDF = sFileName
    lPathDestDoc = sPath
    _Origin = C_Origin

  End Sub


  Private Sub frmGenAttachementWithPhotosSelectPhotos_Load(sender As Object, e As EventArgs) Handles MyBase.Load

    sPathImg = RechercheParamByLib("REP_PHOTOS_ACT")

    LoadData()

  End Sub

  Private Sub LoadData()

    _DtListePhotosAct = New DataTable

    Dim osqlcmdLoad As New SqlCommand("[api_sp_ListeImagesForAttachement]", MozartDatabase.cnxMozart)
    osqlcmdLoad.CommandType = CommandType.StoredProcedure
    osqlcmdLoad.Parameters.Add("@P_NACTNUM", SqlDbType.Int).Value = _NACTNUM
    _DtListePhotosAct.Load(osqlcmdLoad.ExecuteReader)

    _DtListePhotosAct.Columns("NCOCHE").ReadOnly = False
    _DtListePhotosAct.Columns("NCOCHE_COM").ReadOnly = False

    GridControl2.DataSource = _DtListePhotosAct

  End Sub

  Private Sub BtnQuit_Click(sender As Object, e As EventArgs) Handles BtnQuit.Click

    Me.Close()

  End Sub

  Private Sub GridView1_CustomUnboundColumnData(sender As Object, e As CustomColumnDataEventArgs) Handles GridView1.CustomUnboundColumnData

    If e.Column.FieldName = "IMAGEACT" AndAlso Not e.Row Is Nothing Then

      Dim fileName As String = sPathImg & e.Row.Item("VFICHIER").ToString

      If fileName <> "" Then

        e.Value = Image.FromFile(fileName)

      End If

    End If

  End Sub

  Private Sub BtnGenerer_Click(sender As Object, e As EventArgs) Handles BtnGenerer.Click

    If _DtListePhotosAct.Select("[NCOCHE] = 1").Count = 0 Then
      MessageBox.Show("il faut sélectionner au moins 1 photo !", "Erreur", MessageBoxButtons.OK, MessageBoxIcon.Exclamation)
      Exit Sub
    End If

    If _DtListePhotosAct.Select("[NCOCHE] = 1").Count > 5 Then
      MessageBox.Show("La génération de l'attachement est impossible car vous avez sélectionné plus de 5 photos !", "Erreur", MessageBoxButtons.OK, MessageBoxIcon.Exclamation)
      Exit Sub
    End If
    If _DtListePhotosAct.Select("[NCOCHE_COM] = 1").Count > 5 Then
      MessageBox.Show("La génération de l'attachement est impossible car vous avez sélectionné plus de 5 commentaires !", "Erreur", MessageBoxButtons.OK, MessageBoxIcon.Exclamation)
      Exit Sub
    End If

    Me.Cursor = Cursors.WaitCursor


    Dim sPathOut_Temp As String = MozartParams.CheminUtilisateurMozart & "PDF\"
    Dim sFileOut_Temp As String = $"Attach_{_NACTNUM}.pdf"

    Dim _dtListeAttachement As New DataTable
    Dim sqlcmdloader As New SqlCommand("[api_sp_RetourInfoAttachementWithPhotos]", MozartDatabase.cnxMozart)
    sqlcmdloader.CommandType = CommandType.StoredProcedure
    sqlcmdloader.Parameters.Add("@p_NACTNUM", SqlDbType.Int).Value = _NACTNUM
    _dtListeAttachement.Load(sqlcmdloader.ExecuteReader)

    For Each p_datarow As DataRow In _dtListeAttachement.Rows

      'fichier modele, fichier sortie et requete sql
      If p_datarow.Item("BATTACHMARCHPUBLIC") = True Then

        'init

        'gestion du fihciher de sortie en pdf -> REP_ATTGAM
        'Dim lPathDestDoc As String = RechercheParam("REP_ATTGAM", p_datarow.Item("VSOCIETE"))
        'pour la prod
        'sFileOutPDF = String.Format("{0}Attach{1}.pdf", lPathDestDoc, p_datarow.Item("NACTNUM"))

        Dim oListPhotos As New List(Of CGenAttachPhoto)

        'on génére les photos
        For Each drPhotos As DataRow In _DtListePhotosAct.Select("[NCOCHE] = 1")

          If File.Exists(sPathImg & drPhotos.Item("VFICHIER")) Then

            Dim OGenAttachPhoto As New CGenAttachPhoto(sPathImg & drPhotos.Item("VFICHIER"), sPathOut_Temp & Path.GetFileNameWithoutExtension(drPhotos.Item("VFICHIER")), If(drPhotos.Item("NCOCHE_COM") = 1, drPhotos.Item("VCOMMENT"), ""))
            oListPhotos.Add(OGenAttachPhoto)

          End If

        Next

        Select Case _Origin
          Case 1  'attachement technicien
            Dim oAttachCorrect As New REPORT.rptAttachement(MozartParams.NomSociete, p_datarow.Item("VCLIPAYS"), _NACTNUM, "PHOTOS")
            Dim dtr As New DataTable
            ModuleData.LoadData(dtr, QueryForImpAttachementPhotos(p_datarow, "[api_sp_TabletimpAttachementManual_Report]", oListPhotos))
            oAttachCorrect.DataSource = dtr

            oAttachCorrect.ExportOptions.PrintPreview.DefaultDirectory = MozartParams.CheminUtilisateur
            oAttachCorrect.ExportOptions.PrintPreview.ShowOptionsBeforeExport = False

            oAttachCorrect.CreateDocument()

            Dim ps As PrintingSystemBase = oAttachCorrect.PrintingSystem
            Dim pdfExportOptions As New PdfExportOptions() With {.PdfACompatibility = PdfACompatibility.PdfA1b}
            ps.ExportToPdf(sPathOut_Temp & sFileOut_Temp, pdfExportOptions)

            oAttachCorrect.Dispose()
            ps.Dispose()

            File.Copy(sPathOut_Temp & sFileOut_Temp, lPathDestDoc & sFileOutPDF, True)

            'clear temp
            If File.Exists(sPathOut_Temp & sFileOut_Temp) Then
              File.Delete(sPathOut_Temp & sFileOut_Temp)
            End If

          Case 2  'attachement sous traitant

            Dim oAttachCorrect As New REPORT.rptAttachementOnlyPhotos(MozartParams.NomSociete, p_datarow.Item("VCLIPAYS"), _NACTNUM, oListPhotos.Count, "PHOTOS")
            Dim dtr As New DataTable
            ModuleData.LoadData(dtr, QueryForImpAttachementPhotosOnly(p_datarow, "[api_sp_TabletimpAttachementManual_Report_Only_Photos]", oListPhotos))
            oAttachCorrect.DataSource = dtr

            oAttachCorrect.ExportOptions.PrintPreview.DefaultDirectory = MozartParams.CheminUtilisateur
            oAttachCorrect.ExportOptions.PrintPreview.ShowOptionsBeforeExport = False

            oAttachCorrect.CreateDocument()

            Dim ps As PrintingSystemBase = oAttachCorrect.PrintingSystem
            Dim pdfExportOptions As New PdfExportOptions() With {.PdfACompatibility = PdfACompatibility.PdfA1b}
            ps.ExportToPdf(sPathOut_Temp & sFileOut_Temp, pdfExportOptions)

            oAttachCorrect.Dispose()
            ps.Dispose()

            Dim sTempFileMergePDf As String = Path.GetTempFileName()

            Using pdfDocumentProcessor As New PdfDocumentProcessor()
              pdfDocumentProcessor.CreateEmptyDocument(sTempFileMergePDf)
              pdfDocumentProcessor.AppendDocument(lPathDestDoc & sFileOutPDF)
              pdfDocumentProcessor.AppendDocument(sPathOut_Temp & sFileOut_Temp)
            End Using

            File.Copy(sTempFileMergePDf, lPathDestDoc & sFileOutPDF, True)

            'clear temp
            If File.Exists(sPathOut_Temp & sFileOut_Temp) Then
              File.Delete(sPathOut_Temp & sFileOut_Temp)
            End If


        End Select

        'clear
        For Each drPhotos As CGenAttachPhoto In oListPhotos

          If File.Exists(sPathOut_Temp & drPhotos.sFileOut) Then
            File.Delete(sPathOut_Temp & drPhotos.sFileOut)
          End If

        Next

      End If

    Next

    MessageBox.Show("Attachement avec photos créé avec succès !", "Succès", MessageBoxButtons.OK, MessageBoxIcon.Information)

    Me.Cursor = Cursors.Default

  End Sub

  Public Function QueryForImpAttachementPhotos(ByVal oDataRowAttach As DataRow, ByVal sNomProc As String, ByVal p_ListPhotos As List(Of CGenAttachPhoto)) As String

    Dim ProcStockStruct As New SqlCommand(sNomProc + " @nactnum, @p_img_blank_error, @p_img_1, @p_img_2, @p_img_3, " _
                                                                        & "@p_img_4, @p_img_5, @p_com_img_1, @p_com_img_2, @p_com_img_3, @p_com_img_4, @p_com_img_5")


    ProcStockStruct.CommandType = CommandType.StoredProcedure
    ProcStockStruct.Parameters.Add("@nactnum", SqlDbType.Int).Value = oDataRowAttach.Item("NACTNUM")
    ProcStockStruct.Parameters.Add("@p_img_blank_error", SqlDbType.VarChar).Value = ""
    ProcStockStruct.Parameters.Add("@p_img_1", SqlDbType.VarChar).Value = If(p_ListPhotos.Count > 0, p_ListPhotos.Item(0).sFileOut, DBNull.Value)
    ProcStockStruct.Parameters.Add("@p_img_2", SqlDbType.VarChar).Value = If(p_ListPhotos.Count > 1, p_ListPhotos.Item(1).sFileOut, DBNull.Value)
    ProcStockStruct.Parameters.Add("@p_img_3", SqlDbType.VarChar).Value = If(p_ListPhotos.Count > 2, p_ListPhotos.Item(2).sFileOut, DBNull.Value)
    ProcStockStruct.Parameters.Add("@p_img_4", SqlDbType.VarChar).Value = If(p_ListPhotos.Count > 3, p_ListPhotos.Item(3).sFileOut, DBNull.Value)
    ProcStockStruct.Parameters.Add("@p_img_5", SqlDbType.VarChar).Value = If(p_ListPhotos.Count > 4, p_ListPhotos.Item(4).sFileOut, DBNull.Value)
    ProcStockStruct.Parameters.Add("@p_com_img_1", SqlDbType.VarChar).Value = If(p_ListPhotos.Count > 0 AndAlso p_ListPhotos.Item(0).vcomment <> "", p_ListPhotos.Item(0).vcomment, "")
    ProcStockStruct.Parameters.Add("@p_com_img_2", SqlDbType.VarChar).Value = If(p_ListPhotos.Count > 1 AndAlso p_ListPhotos.Item(1).vcomment <> "", p_ListPhotos.Item(1).vcomment, "")
    ProcStockStruct.Parameters.Add("@p_com_img_3", SqlDbType.VarChar).Value = If(p_ListPhotos.Count > 2 AndAlso p_ListPhotos.Item(2).vcomment <> "", p_ListPhotos.Item(2).vcomment, "")
    ProcStockStruct.Parameters.Add("@p_com_img_4", SqlDbType.VarChar).Value = If(p_ListPhotos.Count > 3 AndAlso p_ListPhotos.Item(3).vcomment <> "", p_ListPhotos.Item(3).vcomment, "")
    ProcStockStruct.Parameters.Add("@p_com_img_5", SqlDbType.VarChar).Value = If(p_ListPhotos.Count > 4 AndAlso p_ListPhotos.Item(4).vcomment <> "", p_ListPhotos.Item(4).vcomment, "")

    Dim QueryProc As String = ProcStockStruct.CommandText

    For Each prm As SqlParameter In ProcStockStruct.Parameters

      Select Case prm.SqlDbType
        Case SqlDbType.DateTime, SqlDbType.Char, SqlDbType.VarChar, SqlDbType.NVarChar, SqlDbType.NText
          QueryProc = QueryProc.Replace(prm.ParameterName, "'" & prm.Value & "'")
        Case Else
          QueryProc = QueryProc.Replace(prm.ParameterName, prm.Value)
      End Select
    Next

    Return QueryProc

  End Function

  Public Function QueryForImpAttachementPhotosOnly(ByVal oDataRowAttach As DataRow, ByVal sNomProc As String, ByVal p_ListPhotos As List(Of CGenAttachPhoto)) As String

    Dim ProcStockStruct As New SqlCommand(sNomProc + " @nactnum, @ncstnum, @p_img_blank_error, @p_img_1, @p_img_2, @p_img_3, " _
                                                                        & "@p_img_4, @p_img_5, @p_com_img_1, @p_com_img_2, @p_com_img_3, @p_com_img_4, @p_com_img_5")


    ProcStockStruct.CommandType = CommandType.StoredProcedure
    ProcStockStruct.Parameters.Add("@nactnum", SqlDbType.Int).Value = oDataRowAttach.Item("NACTNUM")
    ProcStockStruct.Parameters.Add("@ncstnum", SqlDbType.Int).Value = oDataRowAttach.Item("NCSTNUM")
    ProcStockStruct.Parameters.Add("@p_img_blank_error", SqlDbType.VarChar).Value = ""
    ProcStockStruct.Parameters.Add("@p_img_1", SqlDbType.VarChar).Value = If(p_ListPhotos.Count > 0, p_ListPhotos.Item(0).sFileOut, DBNull.Value)
    ProcStockStruct.Parameters.Add("@p_img_2", SqlDbType.VarChar).Value = If(p_ListPhotos.Count > 1, p_ListPhotos.Item(1).sFileOut, DBNull.Value)
    ProcStockStruct.Parameters.Add("@p_img_3", SqlDbType.VarChar).Value = If(p_ListPhotos.Count > 2, p_ListPhotos.Item(2).sFileOut, DBNull.Value)
    ProcStockStruct.Parameters.Add("@p_img_4", SqlDbType.VarChar).Value = If(p_ListPhotos.Count > 3, p_ListPhotos.Item(3).sFileOut, DBNull.Value)
    ProcStockStruct.Parameters.Add("@p_img_5", SqlDbType.VarChar).Value = If(p_ListPhotos.Count > 4, p_ListPhotos.Item(4).sFileOut, DBNull.Value)
    ProcStockStruct.Parameters.Add("@p_com_img_1", SqlDbType.VarChar).Value = If(p_ListPhotos.Count > 0 AndAlso p_ListPhotos.Item(0).vcomment <> "", p_ListPhotos.Item(0).vcomment, "")
    ProcStockStruct.Parameters.Add("@p_com_img_2", SqlDbType.VarChar).Value = If(p_ListPhotos.Count > 1 AndAlso p_ListPhotos.Item(1).vcomment <> "", p_ListPhotos.Item(1).vcomment, "")
    ProcStockStruct.Parameters.Add("@p_com_img_3", SqlDbType.VarChar).Value = If(p_ListPhotos.Count > 2 AndAlso p_ListPhotos.Item(2).vcomment <> "", p_ListPhotos.Item(2).vcomment, "")
    ProcStockStruct.Parameters.Add("@p_com_img_4", SqlDbType.VarChar).Value = If(p_ListPhotos.Count > 3 AndAlso p_ListPhotos.Item(3).vcomment <> "", p_ListPhotos.Item(3).vcomment, "")
    ProcStockStruct.Parameters.Add("@p_com_img_5", SqlDbType.VarChar).Value = If(p_ListPhotos.Count > 4 AndAlso p_ListPhotos.Item(4).vcomment <> "", p_ListPhotos.Item(4).vcomment, "")

    Dim QueryProc As String = ProcStockStruct.CommandText

    For Each prm As SqlParameter In ProcStockStruct.Parameters

      Select Case prm.SqlDbType
        Case SqlDbType.DateTime, SqlDbType.Char, SqlDbType.VarChar, SqlDbType.NVarChar, SqlDbType.NText
          QueryProc = QueryProc.Replace(prm.ParameterName, "'" & prm.Value & "'")
        Case Else
          QueryProc = QueryProc.Replace(prm.ParameterName, prm.Value)
      End Select
    Next

    Return QueryProc

  End Function

  '*******************************************************************************************
  'Permet de creer une image temporaire pour la visu de la signature
  '*******************************************************************************************
  Private Function CreateSignForVisu(ByVal oImgSignature As Object, ByVal iImgWidth As Integer, ByVal iImgHeight As Integer, ByVal vtype As String) As String

    Try

      Dim strnomfic As String
      Dim strnomficOK As String
      Dim sPathTempSign As String = MozartParams.CheminUtilisateurMozart & "PDF\"

      'on test si le dossier temp existe
      If Directory.Exists(sPathTempSign) = False Then Directory.CreateDirectory(sPathTempSign)

      Select Case vtype
        Case "CLI"
          strnomfic = sPathTempSign + "signCliTemp"
          strnomficOK = sPathTempSign + "signCli"
        Case Else
          strnomfic = sPathTempSign + "signTechTemp"
          strnomficOK = sPathTempSign + "signTech"
      End Select

      Dim tab1() As Byte = oImgSignature
      Dim fs As New FileStream(strnomfic, FileMode.Create, FileAccess.Write, FileShare.Write)
      fs.Write(tab1, 0, tab1.Length)
      fs.Flush()
      fs.Close()

      Dim myBitmap As New Bitmap(strnomfic)
      Dim myBitmap2 As New Bitmap(myBitmap, New Size(iImgWidth, iImgHeight))
      myBitmap2.Save(strnomficOK, ImageFormat.Jpeg)

      Return strnomficOK

    Catch ex As Exception

      MessageBox.Show("Erreur dans - CreateSignForVisu : " + ex.Message)
      Return ""

    End Try

  End Function

  Private Sub RepositoryItemCheckEdit2_EditValueChanging(sender As Object, e As ChangingEventArgs) Handles RepositoryItemCheckEdit2.EditValueChanging

    If GridView1.FocusedRowHandle < 0 Then Return

    Dim drSelect As DataRow = GridView1.GetDataRow(GridView1.FocusedRowHandle)

    If drSelect Is Nothing Then Return

    If drSelect.Item("NCOCHE") = 0 Then

      MessageBox.Show("Il faut ajouter la photo pour ajouter son commentaire", "Erreur")
      e.Cancel = True

    End If
  End Sub

  Private Sub RepositoryItemCheckEdit1_CheckedChanged(sender As Object, e As EventArgs) Handles RepositoryItemCheckEdit1.CheckedChanged

    GridView1.CloseEditor()
    Dim RowHdl As Int32 = GridView1.FocusedRowHandle

    If RowHdl < 0 Then Return

    Dim drSelect As DataRow = GridView1.GetDataRow(RowHdl)
    If drSelect Is Nothing Then Return

    If drSelect.Item("NCOCHE") = 0 And drSelect.Item("NCOCHE_COM") = 1 Then
      GridView1.SetRowCellValue(RowHdl, "NCOCHE_COM", 0)
    End If



  End Sub
End Class



