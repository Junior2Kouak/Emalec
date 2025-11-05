Imports System.Data.SqlClient
Imports DevExpress.XtraPrinting
Imports MozartLib
Imports REPORT = ReportEmalec.Net

Public Class FrmCorrectAttach

  Dim iNACTNUM As Int32
  Dim iNIMAGE As Int32
  Dim _BCLI_ATTACH_HR_ARR_EXE As Int16
  Dim sNomFichierAttachement As String

  Dim oCnxAttachModif As New CGestionSQL
  Dim dtAttachModif As DataTable

  Dim _Path_SignCli As String = ""
  Dim _Path_SignTech As String = ""

  'constructeur de la classe avec 2 paramtres
  Public Sub New(ByVal p_iNACTNUM As Object, ByVal c_NIMAGE As Object)
    InitializeComponent()
    iNACTNUM = Convert.ToInt32(p_iNACTNUM)
    iNIMAGE = c_NIMAGE
    _BCLI_ATTACH_HR_ARR_EXE = 0
  End Sub

  Private Sub FrmCorrectAttach_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
    TabPageChap5.Text += MozartParams.NomGroupe

    _Path_SignCli = ""
    _Path_SignTech = ""

    'on recherche les informations pour cette attachement
    If oCnxAttachModif.ConnexionSQL(MozartParams.NomServeur, MozartParams.NomSociete) = True Then

      'tree
      Dim drsql As SqlDataReader = oCnxAttachModif.CreateSQLDataReader("EXEC api_sp_RetourAttachProvideTablet " + iNACTNUM.ToString + ", " + iNIMAGE.ToString)

      dtAttachModif = New DataTable

      dtAttachModif.Load(drsql)

      If dtAttachModif.Rows.Count > 0 Then

        Dim oRowsDataAttach As DataRow = dtAttachModif.Rows(0)
        TxtNbDep.Text = oRowsDataAttach.Item("VATTACHDEPL").ToString
        TxtNbHrExe.Text = oRowsDataAttach.Item("VATTACHHR").ToString
        TxtNbHrPrepa.Text = oRowsDataAttach.Item("VATTACHHRPREPA").ToString
        TxtBoxChap1.Text = oRowsDataAttach.Item("VATTACHCHAP1").ToString
        TxtBoxChap2.Text = oRowsDataAttach.Item("VATTACHCHAP2").ToString
        TxtBoxChap3.Text = oRowsDataAttach.Item("VATTACHCHAP3").ToString
        TxtBoxChap4.Text = oRowsDataAttach.Item("VATTACHCHAP4").ToString
        TxtBoxChap5.Text = oRowsDataAttach.Item("VATTACHCHAP5").ToString
        TxtBoxChap6.Text = oRowsDataAttach.Item("VATTACHCHAP6").ToString

        sNomFichierAttachement = oRowsDataAttach.Item("VFICHIER").ToString

        _BCLI_ATTACH_HR_ARR_EXE = oRowsDataAttach.Item("BCLI_ATTACH_HR_ARR_EXE")

      End If
      drsql.Close()

    End If

    If _BCLI_ATTACH_HR_ARR_EXE = 1 Then GrpAffichageHeure.Visible = True Else GrpAffichageHeure.Visible = False

    ResizeAllComponent()

  End Sub

  Private Sub FrmCorrectAttach_FormClosed(ByVal sender As Object, ByVal e As System.Windows.Forms.FormClosedEventArgs) Handles Me.FormClosed
    If File.Exists(MozartParams.CheminUtilisateurMozart & "PDF\signCli") Then File.Delete(MozartParams.CheminUtilisateurMozart & "PDF\signCli")
    If File.Exists(MozartParams.CheminUtilisateurMozart & "PDF\signCliTemp") Then File.Delete(MozartParams.CheminUtilisateurMozart & "PDF\signCliTemp")

    If File.Exists(MozartParams.CheminUtilisateurMozart & "PDF\signTechTemp") Then File.Delete(MozartParams.CheminUtilisateurMozart & "PDF\signTechTemp")
    If File.Exists(MozartParams.CheminUtilisateurMozart & "PDF\signTech") Then File.Delete(MozartParams.CheminUtilisateurMozart & "PDF\signTech")

    oCnxAttachModif.CloseConnexionSQL()
    Me.Dispose()
  End Sub

  Private Sub BtnEnregistrer_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles BtnEnregistrer.Click, BtnVisu.Click

    Dim oRowsDataAttach As DataRow = dtAttachModif.Rows(0)

    _Path_SignTech = ""
    _Path_SignCli = ""

    If sender.name = "BtnVisu" Then
      GoTo btnvisu_step1
    End If

    'message pour save
    If MessageBox.Show("Voulez-vous enregistrer les modifications ?", "Confirmation", MessageBoxButtons.YesNoCancel, MessageBoxIcon.Question) = vbYes Then

      'on vérifie s'il y a eu des modifications 
      If isAttachementModifier() = True Then

btnvisu_step1:

        'on enregistre les données sans la table en cours de modification
        oRowsDataAttach.Item("VATTACHCHAP1") = TxtBoxChap1.Text
        oRowsDataAttach.Item("VATTACHCHAP2") = TxtBoxChap2.Text
        oRowsDataAttach.Item("VATTACHCHAP3") = TxtBoxChap3.Text
        oRowsDataAttach.Item("VATTACHCHAP4") = TxtBoxChap4.Text
        oRowsDataAttach.Item("VATTACHCHAP5") = TxtBoxChap5.Text
        oRowsDataAttach.Item("VATTACHCHAP6") = TxtBoxChap6.Text

        oRowsDataAttach.Item("VATTACHDEPL") = TxtNbDep.Text
        oRowsDataAttach.Item("VATTACHHR") = TxtNbHrExe.Text
        oRowsDataAttach.Item("VATTACHHRPREPA") = TxtNbHrPrepa.Text

        If sender.name = "BtnVisu" Then
          GoTo btnvisu_step2
        End If

        SaveCorrectAttach(dtAttachModif.Rows(0))

        'message pour generation document
        If MessageBox.Show("Voulez-vous générer l'attachement ?", My.Resources.Corretion_frmCorrectAttach_correct_attach, MessageBoxButtons.YesNoCancel, MessageBoxIcon.Question) = vbYes Then

btnvisu_step2:
          Dim DtdataAttach As DataTable = LoadDataTableAttach(iNACTNUM)

          If DtdataAttach IsNot Nothing AndAlso DtdataAttach.Rows.Count > 0 Then

            Dim sFileOutPDF As String
            Dim sPathOut_Temp As String = MozartParams.CheminUtilisateurMozart & "PDF\"
            Dim sFileOut_Temp As String = $"Attach_{iNACTNUM}.pdf"


            'init
            Dim lPathDestDoc As String = RechercheParam("REP_ATTGAM", DtdataAttach.Rows(0).Item("VSOCIETE"))
            sFileOutPDF = String.Format("{0}{1}", lPathDestDoc, sNomFichierAttachement)

            'clear temp
            If File.Exists(sPathOut_Temp & sFileOut_Temp) Then
              File.Delete(sPathOut_Temp & sFileOut_Temp)
            End If

            Dim oAttachCorrect As New REPORT.rptAttachement(DtdataAttach.Rows(0).Item("VSOCIETE"), DtdataAttach.Rows(0).Item("VCLIPAYS"), iNACTNUM, "CORRECTION")
            Dim dtr As New DataTable
            ModuleData.LoadData(dtr, QueryForImpAttachementCorrect(oRowsDataAttach, "[api_sp_TabletimpAttachementCorrection_Report]"))
            oAttachCorrect.DataSource = dtr

            oAttachCorrect.ExportOptions.PrintPreview.DefaultDirectory = MozartParams.CheminUtilisateur
            oAttachCorrect.ExportOptions.PrintPreview.ShowOptionsBeforeExport = False

            If ChkMaskHRArr.Checked = True Then
              Dim oCtrlLblArr As Object = oAttachCorrect.Report.FindControl("XrLabel14", True)
              If oCtrlLblArr IsNot Nothing Then oCtrlLblArr.Visible = False
            End If

            If ChkMaskHREXE.Checked = True Then
              Dim oCtrlLblArr As Object = oAttachCorrect.Report.FindControl("XrLabel16", True)
              If oCtrlLblArr IsNot Nothing Then oCtrlLblArr.Visible = False
            End If

            oAttachCorrect.CreateDocument()

            Dim ps As PrintingSystemBase = oAttachCorrect.PrintingSystem
            Dim pdfExportOptions As New PdfExportOptions() With {.PdfACompatibility = PdfACompatibility.PdfA1b}
            ps.ExportToPdf(sPathOut_Temp & sFileOut_Temp, pdfExportOptions)

            oAttachCorrect.Dispose()
            ps.Dispose()

            If sender.name <> "BtnVisu" Then

              'copie attachment de temp vers att gam
              File.Copy(sPathOut_Temp & sFileOut_Temp, sFileOutPDF, True)

            Else

              Dim oDocVisu As New frmVisuDoc(sPathOut_Temp & sFileOut_Temp, False)
              oDocVisu.ShowDialog()

            End If

            'clear des signature et du fichie doc
            If File.Exists(_Path_SignCli) = True Then File.Delete(_Path_SignCli) : 
            If File.Exists(_Path_SignTech) = True Then File.Delete(_Path_SignTech)
            _Path_SignTech = ""
            _Path_SignCli = ""

            If File.Exists(sPathOut_Temp & sFileOut_Temp) = True Then File.Delete(sPathOut_Temp & sFileOut_Temp)

            'messgae de creation OK
            If sender.name <> "BtnVisu" Then MessageBox.Show("Attachement créé avec succès !", "Succès", MessageBoxButtons.OK, MessageBoxIcon.Information)

          End If

        End If
      Else
        MessageBox.Show(My.Resources.Corretion_frmCorrectAttach_attach_non_modif, My.Resources.Corretion_frmCorrectAttach_erreur, MessageBoxButtons.OK, MessageBoxIcon.Exclamation)
      End If

    End If

  End Sub

  Public Function QueryForImpAttachementCorrect(ByVal oDataRowAttach As DataRow, ByVal sNomProc As String) As String

    Dim ProcStockStruct As New SqlCommand(sNomProc + " @VATTACHCHAP1, @VATTACHCHAP2, @VATTACHCHAP3, @VATTACHCHAP4, @VATTACHCHAP5, " _
                                                                        & "@VATTACHCHAP6, @NATTACHSATISF, @VCONTACTCLI, @VPERNOM, @VATTACHHR, @VATTACHDEPL, " _
                                                                        & "@PATH_IMGSIGNCLI, @PATH_IMGSIGNTECH, @VPREPA, @NACTNUM, @VACTDES")


    _Path_SignCli = CreateSignForVisu(oDataRowAttach.Item("IATTACHCLI"), 250, 100, "CLI").ToString
    _Path_SignTech = CreateSignForVisu(oDataRowAttach.Item("IATTACHTECH"), 200, 70, "TECH").ToString

    ProcStockStruct.CommandType = CommandType.StoredProcedure
    ProcStockStruct.Parameters.Add("@VATTACHCHAP1", SqlDbType.VarChar).Value = oDataRowAttach.Item("VATTACHCHAP1").ToString.Replace("'", "''")
    ProcStockStruct.Parameters.Add("@VATTACHCHAP2", SqlDbType.VarChar).Value = oDataRowAttach.Item("VATTACHCHAP2").ToString.Replace("'", "''")
    ProcStockStruct.Parameters.Add("@VATTACHCHAP3", SqlDbType.VarChar).Value = oDataRowAttach.Item("VATTACHCHAP3").ToString.Replace("'", "''")
    ProcStockStruct.Parameters.Add("@VATTACHCHAP4", SqlDbType.VarChar).Value = oDataRowAttach.Item("VATTACHCHAP4").ToString.Replace("'", "''")
    ProcStockStruct.Parameters.Add("@VATTACHCHAP5", SqlDbType.VarChar).Value = oDataRowAttach.Item("VATTACHCHAP5").ToString.Replace("'", "''")
    ProcStockStruct.Parameters.Add("@VATTACHCHAP6", SqlDbType.VarChar).Value = oDataRowAttach.Item("VATTACHCHAP6").ToString.Replace("'", "''")
    ProcStockStruct.Parameters.Add("@NATTACHSATISF", SqlDbType.Int).Value = oDataRowAttach.Item("NATTACHSATISF")
    ProcStockStruct.Parameters.Add("@VCONTACTCLI", SqlDbType.VarChar).Value = oDataRowAttach.Item("VCONTACTCLI").ToString.Replace("'", "''")
    ProcStockStruct.Parameters.Add("@VPERNOM", SqlDbType.VarChar).Value = oDataRowAttach.Item("VPERNOM").ToString.Replace("'", "''")
    ProcStockStruct.Parameters.Add("@VATTACHHR", SqlDbType.VarChar).Value = oDataRowAttach.Item("VATTACHHR").ToString.Replace("'", "''")
    ProcStockStruct.Parameters.Add("@VATTACHDEPL", SqlDbType.VarChar).Value = oDataRowAttach.Item("VATTACHDEPL").ToString.Replace("'", "''")
    ProcStockStruct.Parameters.Add("@PATH_IMGSIGNCLI", SqlDbType.VarChar).Value = _Path_SignCli
    ProcStockStruct.Parameters.Add("@PATH_IMGSIGNTECH", SqlDbType.VarChar).Value = _Path_SignTech
    ProcStockStruct.Parameters.Add("@VPREPA", SqlDbType.VarChar).Value = oDataRowAttach.Item("VATTACHHRPREPA").ToString.Replace("'", "''")
    ProcStockStruct.Parameters.Add("@NACTNUM", SqlDbType.Int).Value = oDataRowAttach.Item("NACTNUM")
    ProcStockStruct.Parameters.Add("@VACTDES", SqlDbType.VarChar).Value = oDataRowAttach.Item("VACTDES").ToString.Replace("'", "''")

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
  Public Function LoadDataTableAttach(ByVal P_NACTNUM As Int32) As DataTable

    Dim dtListeAttachement As New DataTable

    Dim sqlcmdloader As New SqlCommand("[api_sp_GetInfoForGenerateAttachCorrect]", MozartDatabase.cnxMozart)
    sqlcmdloader.CommandType = CommandType.StoredProcedure
    sqlcmdloader.Parameters.Add("@P_NACTNUM", SqlDbType.Int).Value = P_NACTNUM
    dtListeAttachement.Load(sqlcmdloader.ExecuteReader)

    Return dtListeAttachement

  End Function

  Private Function isAttachementModifier() As Boolean

    Dim oRowsDataAttachVerif As DataRow = dtAttachModif.Rows(0)

    If (oRowsDataAttachVerif.Item("VATTACHCHAP1").ToString = TxtBoxChap1.Text _
          And oRowsDataAttachVerif.Item("VATTACHCHAP2").ToString = TxtBoxChap2.Text _
          And oRowsDataAttachVerif.Item("VATTACHCHAP3").ToString = TxtBoxChap3.Text _
          And oRowsDataAttachVerif.Item("VATTACHCHAP4").ToString = TxtBoxChap4.Text _
          And oRowsDataAttachVerif.Item("VATTACHCHAP5").ToString = TxtBoxChap5.Text _
          And oRowsDataAttachVerif.Item("VATTACHHR").ToString = TxtNbHrExe.Text _
          And oRowsDataAttachVerif.Item("VATTACHDEPL").ToString = TxtNbDep.Text _
          And oRowsDataAttachVerif.Item("VATTACHHRPREPA").ToString = TxtNbHrPrepa.Text And ChkMaskHRArr.Checked = False And ChkMaskHREXE.Checked = False) Then
      Return False
    Else

      Return True

    End If

  End Function

  Private Sub SaveCorrectAttach(ByVal oRowsDataAttach As DataRow)

    'insert la ligne de la table temporaire pour regénéré l'attachement modifier
    Dim sc As New SqlCommand("[api_sp_TabletCreationTAttachArchiveCorrection]", oCnxAttachModif.CnxSQLOpen)

    sc.CommandType = CommandType.StoredProcedure

    sc.Parameters.Add("@NATTACHID", SqlDbType.Int).Value = oRowsDataAttach.Item("NATTACHID")
    sc.Parameters.Add("@NACTNUM", SqlDbType.Int).Value = oRowsDataAttach.Item("NACTNUM")
    sc.Parameters.Add("@NIPLNUM", SqlDbType.Int).Value = oRowsDataAttach.Item("NIPLNUM")
    sc.Parameters.Add("@VATTACHCHAP1", SqlDbType.VarChar).Value = oRowsDataAttach.Item("VATTACHCHAP1")
    sc.Parameters.Add("@VATTACHCHAP2", SqlDbType.VarChar).Value = oRowsDataAttach.Item("VATTACHCHAP2")
    sc.Parameters.Add("@VATTACHCHAP3", SqlDbType.VarChar).Value = oRowsDataAttach.Item("VATTACHCHAP3")
    sc.Parameters.Add("@VATTACHCHAP4", SqlDbType.VarChar).Value = oRowsDataAttach.Item("VATTACHCHAP4")
    sc.Parameters.Add("@VATTACHCHAP5", SqlDbType.VarChar).Value = oRowsDataAttach.Item("VATTACHCHAP5")
    sc.Parameters.Add("@VATTACHCHAP6", SqlDbType.VarChar).Value = oRowsDataAttach.Item("VATTACHCHAP6")
    sc.Parameters.Add("@NATTACHSATISF", SqlDbType.Int).Value = oRowsDataAttach.Item("NATTACHSATISF")
    sc.Parameters.Add("@IATTACHTECH", SqlDbType.Image).Value = oRowsDataAttach.Item("IATTACHTECH")
    sc.Parameters.Add("@IATTACHCLI", SqlDbType.Image).Value = oRowsDataAttach.Item("IATTACHCLI")
    sc.Parameters.Add("@CATTACHETA", SqlDbType.Char).Value = oRowsDataAttach.Item("CATTACHETA")
    sc.Parameters.Add("@DATTACHCRE", SqlDbType.VarChar).Value = oRowsDataAttach.Item("DATTACHCRE")
    sc.Parameters.Add("@DATTACHMOD", SqlDbType.VarChar).Value = oRowsDataAttach.Item("DATTACHMOD")
    sc.Parameters.Add("@VPERNOM", SqlDbType.VarChar).Value = oRowsDataAttach.Item("VPERNOM")
    sc.Parameters.Add("@VCONTACTCLI", SqlDbType.VarChar).Value = oRowsDataAttach.Item("VCONTACTCLI")
    sc.Parameters.Add("@VATTACHHR", SqlDbType.VarChar).Value = oRowsDataAttach.Item("VATTACHHR")
    sc.Parameters.Add("@VATTACHDEPL", SqlDbType.VarChar).Value = oRowsDataAttach.Item("VATTACHDEPL")
    sc.Parameters.Add("@NIDSYNCHROTRANSAT", SqlDbType.Int).Value = oRowsDataAttach.Item("NIDSYNCHROTRANSAT")
    sc.Parameters.Add("@VATTACHHRPREPA", SqlDbType.VarChar).Value = oRowsDataAttach.Item("VATTACHHRPREPA")
    sc.Parameters.Add("@VACTDES", SqlDbType.VarChar).Value = oRowsDataAttach.Item("VACTDES")

    sc.ExecuteNonQuery()

  End Sub

  Private Sub FrmCorrectAttach_ResizeEnd(ByVal sender As Object, ByVal e As System.EventArgs) Handles Me.ResizeEnd

    ResizeAllComponent()

  End Sub

  Private Sub BtnQuit_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles BtnQuit.Click

    Me.Close()

  End Sub

  Private Sub ResizeAllComponent()

    TabCtrlChapitres.Height = Me.Height - TabCtrlChapitres.Top - 50
    TabCtrlChapitres.Width = Me.Width - TabCtrlChapitres.Left - 10

    'on définit la taille des champs texte par défaut en fonction de la taille de l'ecran
    'Dim sizeTxtboxDefault As New Size (TabPageChap1.Size.Width - TxtBoxChap1.Left, TabPageChap1.Size.height - TxtBoxChap1.top)

    TxtBoxChap1.Size = New Size(TabPageChap1.Size.Width - (TxtBoxChap1.Left * 2), TabPageChap1.Size.Height - (TxtBoxChap1.Top * 2))
    TxtBoxChap2.Size = New Size(TabPageChap1.Size.Width - (TxtBoxChap2.Left * 2), TabPageChap1.Size.Height - (TxtBoxChap2.Top * 2))
    TxtBoxChap3.Size = New Size(TabPageChap1.Size.Width - (TxtBoxChap3.Left * 2), TabPageChap1.Size.Height - (TxtBoxChap3.Top * 2))
    TxtBoxChap4.Size = New Size(TabPageChap1.Size.Width - (TxtBoxChap4.Left * 2), TabPageChap1.Size.Height - (TxtBoxChap4.Top * 2))
    TxtBoxChap5.Size = New Size(TabPageChap1.Size.Width - (TxtBoxChap5.Left * 2), TabPageChap1.Size.Height - (TxtBoxChap5.Top * 2))

  End Sub

  'Private Sub BtnVisu_Click(sender As Object, e As EventArgs) Handles BtnVisu.Click
  '  '  Dim oVisuDocTemp As New CGenerateVisuDoc
  '  '  Dim oDoc As New CGenDoc("CorrectAttach", oVisuDocTemp.QueryForImpAttachementCorrect(dtAttachModif.Rows(0), "api_sp_TabletimpAttachementCorrection"))
  '  '  If oDoc.p_ERROR = "" Then
  '  '    Dim oFrmVisuDoc As New frmVisuDoc(oDoc.p_PathFileName)
  '  '    oFrmVisuDoc.ShowDialog()
  '  '  End If

  'End Sub

End Class