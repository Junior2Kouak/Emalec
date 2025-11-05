Imports System.Data.SqlClient
Imports DevExpress.XtraEditors.Controls
Imports DevExpress.XtraEditors.Repository
Imports DevExpress.XtraEditors
Imports DevExpress.XtraGrid.Columns
Imports DevExpress.XtraGrid.Views.Base
Imports DevExpress.XtraPrinting
Imports MozartLib
Imports REPORT = ReportEmalec.Net
Imports ReportEmalec.Net
Imports DevExpress.XtraReports.UI
Imports DevExpress.Utils.Internal
Public Class frmCorrectionCRVP

    Dim iNACTNUM As Int32
    Dim iNTYPECONTRAT As Int32

    Dim pCExtInvEquip As CExtInvEquip
    Dim pCExtBordereau As CExtBordereau
    Dim pCExtActCR As CExtActCR
    Dim IsDevisEIExists As Boolean

    Public Sub New(ByVal c_iNACTNUM As Int32)

        ' Cet appel est requis par le concepteur.
        InitializeComponent()

        ' Ajoutez une initialisation quelconque après l'appel InitializeComponent().

        iNACTNUM = c_iNACTNUM
        'iNTYPECONTRAT = c_iNTYPECONTRAT

    End Sub

    Private Sub frmCorrectionCRVP_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Try


            LoadAllInfoExt()


        Catch ex As Exception

            MessageBox.Show(ex.Message)

        End Try
    End Sub

    Private Sub LoadAllInfoExt()

        'INIT
        pCExtInvEquip = New CExtInvEquip(iNACTNUM)
        pCExtBordereau = New CExtBordereau(iNACTNUM)
        pCExtActCR = New CExtActCR(iNACTNUM)

        If (pCExtBordereau.p_iNEXTBORDID = 0) Or pCExtInvEquip.p_iNEXTINVID = 0 Or pCExtActCR.p_oDataRowEXTACTCR Is Nothing Then
            MessageBox.Show("La correction du CRVP est impossible car les données n'existe plus (trop anciennes)", "Erreur", MessageBoxButtons.OK, MessageBoxIcon.Exclamation)
            Me.Close()
        End If

        '-------------------------------------------------------------------------------------------
        RepItemGLEditLstFou.DataSource = pCExtInvEquip.LoadListeFournituresExtinctCombo
        RepItemGridLstInvAnnee.DataSource = pCExtInvEquip.LoadListeAnneeExtinctCombo
        RepItemGridLookUpMarque.DataSource = pCExtInvEquip.LoadListeMarqueExtinctCombo
        RepItemGridLookUpAction.DataSource = pCExtInvEquip.LoadListeActionsExtinctCombo

        If pCExtInvEquip.LoadListeMarqueExtinctCombo.Select("[BOLD]=1").Count > 0 Then RepItemGViewMarque.OptionsView.ShowFooter = True

        GCExtInv.DataSource = pCExtInvEquip.p_dtExtInv

        If pCExtBordereau.p_iNDCLNUM > 0 And pCExtBordereau.p_iNBLINEDCL > 0 Then

            RepItemGLEditLstFouBord.DataSource = pCExtBordereau.LoadListeFournituresExtinctBordCombo

            GVExtBord.OptionsBehavior.ReadOnly = True

        Else

            RepItemGLEditLstFouBord.DataSource = pCExtBordereau.LoadListeFournituresExtinctBordCombo

        End If

        GCExtBord.DataSource = pCExtBordereau.p_dtExtBord

        LoadEXTACTCRInfo(pCExtActCR.p_oDataRowEXTACTCR)

    End Sub

    Private Sub LoadEXTACTCRInfo(ByVal oDataRowInfo As DataRow)

        Try
            If oDataRowInfo Is Nothing Then
                TxtExtActCR.Text = ""
                TxtVEXTACT_OBS.Text = ""
            Else
                TxtExtActCR.Text = oDataRowInfo.Item("VEXTACTCR").ToString
                TxtVEXTACT_OBS.Text = oDataRowInfo.Item("VEXTACT_OBS").ToString

            End If

        Catch ex As Exception
            MessageBox.Show(ex.Message)
        End Try

    End Sub

    Private Sub BtnQuit_Click(sender As Object, e As EventArgs) Handles BtnQuit.Click
        Me.Close()
    End Sub

    Private Sub BtnExtInvEquipNewLine_Click(sender As Object, e As EventArgs) Handles BtnExtInvEquipNewLine.Click
        Try

            pCExtInvEquip.AddNewLineExtInvEquip()

            ShowComboNewRow(GCExtInv.FocusedView, "NFOUNUM")

        Catch ex As Exception
            MessageBox.Show(ex.Message)
        End Try
    End Sub

    Private Sub ShowComboNewRow(ByVal RowFocused As ColumnView, ByVal sNameColumn As String)

        'Dim RowFocused As ColumnView = GCExtInv.FocusedView
        Dim ColFocused As GridColumn = RowFocused.Columns(sNameColumn)

        If Not ColFocused Is Nothing Then
            ' locating the new row 
            Dim rhFound As Integer = RowFocused.RowCount - 1
            ' focusing the cell 
            If (rhFound <> DevExpress.XtraGrid.GridControl.InvalidRowHandle) Then
                RowFocused.FocusedRowHandle = rhFound
                RowFocused.FocusedColumn = ColFocused
            End If
        End If
        RowFocused.ShowEditor()
        If TypeOf RowFocused.ActiveEditor Is GridLookUpEdit Then
            TryCast(RowFocused.ActiveEditor, GridLookUpEdit).ShowPopup()
        End If

    End Sub

    '*******************************************************************************************************************************************
    'on verifie si il y a au moins une coche sur chaque équipement (une coche sur oui ou sur non)
    '*******************************************************************************************************************************************
    Private Function CaseAllCocheOUI_NON() As Boolean

        If pCExtInvEquip.p_dtExtInv.Select("[BEXTVERIFOUI] = 0 AND [BEXTVERIFNON] = 0").Count() > 0 Then
            Return False
        Else
            Return True
        End If

    End Function

    Private Sub RepItemCheckVERIFOUI_EditValueChanging(sender As Object, e As Controls.ChangingEventArgs) Handles RepItemCheckVERIFOUI.EditValueChanging

        'Dim GV As GridView = GV.GetFocusedDataRow
        Dim oDRSelected As DataRow = GVExtInv.GetFocusedDataRow()

        If IsNothing(oDRSelected) = False Then

            If (e.NewValue = True) Then
                'on teste si non vérifié est cocher
                If (IsDBNull((oDRSelected.Item("BEXTVERIFNON"))) = False AndAlso oDRSelected.Item("BEXTVERIFNON") = True) Then
                    MessageBox.Show("On ne peut pas cocher les cases à cocher 'Vérifier' et 'Non vérifié' sur une même fourniture." & vbCrLf & "Soit vous cochez 'Vérifier', soit vous cochez 'Non vérifié'", "Erreur", MessageBoxButtons.OK, MessageBoxIcon.Error)
                    e.Cancel = True
                End If

            End If

        End If
    End Sub

    Private Sub RepItemCheckVERIFNON_EditValueChanging(sender As Object, e As ChangingEventArgs) Handles RepItemCheckVERIFNON.EditValueChanging
        Dim oDRSelected As DataRow = GVExtInv.GetFocusedDataRow()

        If IsNothing(oDRSelected) = False Then

            If (e.NewValue = True) Then
                'on teste si non vérifié est cocher
                If (IsDBNull((oDRSelected.Item("BEXTVERIFOUI"))) = False AndAlso oDRSelected.Item("BEXTVERIFOUI") = True) Then
                    MessageBox.Show("On ne peut pas cocher les cases à cocher 'Vérifier' et 'Non vérifié' sur une même fourniture." & vbCrLf & "Soit vous cochez 'Vérifier', soit vous cochez 'Non vérifié'", "Erreur", MessageBoxButtons.OK, MessageBoxIcon.Error)
                    e.Cancel = True
                End If

            End If


        End If
    End Sub

    Private Sub BtnEnregistrer_Click(sender As Object, e As EventArgs) Handles BtnEnregistrer.Click
        If CaseAllCocheOUI_NON() = False Then
            MessageBox.Show("Pour regénérer le CRVP, il faut vérifier l'ensemble des équipements (coche vérifié ou non vérifié).", "Erreur", MessageBoxButtons.OK, MessageBoxIcon.Exclamation)
            Return
        End If

        'message pour generation document
        If MessageBox.Show("Voulez-vous générer le CRVP ?", "Confirmation", MessageBoxButtons.YesNoCancel, MessageBoxIcon.Question) = vbYes Then


            'on clear les lignes de la datatable table tampon
            MozartDatabase.ExecuteNonQuery($"EXEC [api_sp_CorrectionCRVP_ClearTableTampon_Tempo] {iNACTNUM}")

            pCExtInvEquip.SaveExtInvEquip()
            pCExtBordereau.SaveExtBordereau()

            pCExtActCR.SaveInfoEXTACTCR(TxtExtActCR.Text, TxtVEXTACT_OBS.Text)

            Dim _Path_SignCli As String = ""
            Dim _Path_SignTech As String = ""

            Dim sFileOutPDF As String
            Dim sPathOut_Temp As String = MozartParams.CheminUtilisateurMozart & "PDF\"
            Dim sFileOut_Temp As String = $"CRVP_{iNACTNUM}.pdf"
            Dim sLangue As String = ""
            Dim detailReport As XtraReport = Nothing
            Dim dtr As DataTable   ' DataTables pour les reports
            Dim dts As DataTable   ' DataTables pour les subreports
            Dim sNomFichierCRVP As String = MozartDatabase.ExecuteScalarString($"EXEC [api_sp_GetFileNameCRVPByAction] {iNACTNUM}")
            Dim sqldrinfoclient As SqlDataReader = MozartDatabase.ExecuteReader($"EXEC [api_sp_GetLangueClientByAction] {iNACTNUM}")
            Dim iNUMCLIENT As Int32 = 0

            If (sqldrinfoclient.HasRows) Then

                sqldrinfoclient.Read()
                sLangue = sqldrinfoclient.Item("VCLILANGUE").ToString()
                iNUMCLIENT = sqldrinfoclient.Item("NCLINUM")
                sqldrinfoclient.Close()
            Else
                MessageBox.Show("Erreur lors de la récupération de la langue du client", "Erreur", MessageBoxButtons.OK, MessageBoxIcon.Error)
                sqldrinfoclient.Close()
                Return
            End If

            'init
            Dim lPathDestDoc As String = RechercheParam("REP_PHOTOS_ACT", MozartParams.NomSociete)
            sFileOutPDF = String.Format("{0}{1}", lPathDestDoc, sNomFichierCRVP)

            'on teste si le fichier est encours d'utilisation
            If (IsFileLocked(sFileOutPDF)) Then
                MessageBox.Show($"Le fichier {sNomFichierCRVP} est en cours d'utilisation, veuillez le fermer avant de continuer.", "Erreur", MessageBoxButtons.OK, MessageBoxIcon.Error)
                Return
            End If

            If (IsFileLocked(sPathOut_Temp & sFileOut_Temp)) Then
                MessageBox.Show($"Le fichier {sFileOut_Temp} est en cours d'utilisation, veuillez le fermer avant de continuer.", "Erreur", MessageBoxButtons.OK, MessageBoxIcon.Error)
                Return
            End If

            Try
                'clear temp
                If File.Exists(sPathOut_Temp & sFileOut_Temp) Then
                    File.Delete(sPathOut_Temp & sFileOut_Temp)
                End If
            Catch ex As Exception
                MessageBox.Show($"Impossible de supprimer le fichier {sFileOut_Temp} dans le dossier temporaire. Veuillez fermer le fichier s'il est ouvert.", "Erreur", MessageBoxButtons.OK, MessageBoxIcon.Error)
                Return
            End Try



            Dim oCRVPCorrect As New REPORT.rptCRVP(MozartParams.NomSociete, sLangue, iNUMCLIENT)
            oCRVPCorrect.ExportOptions.PrintPreview.DefaultDirectory = MozartParams.CheminUtilisateur
            oCRVPCorrect.ExportOptions.PrintPreview.ShowOptionsBeforeExport = False

            detailReport = New subrptCRVP1(MozartParams.NomSociete, sLangue)
            dtr = Database.GetData($"exec [api_sp_TabletImpExtCRVPreport_Correction] {iNACTNUM},1")
            dts = Database.GetData($"exec [api_sp_TabletImpExtCRVPreport_Correction] {iNACTNUM},2")
            oCRVPCorrect.DataSource = dtr
            detailReport.DataSource = dts           ' Reprendre le DataTable du tour précédent
            REPORT.PrepareReport.AddInGROUPFooter(oCRVPCorrect, detailReport)

            detailReport = New subrptCRVP2(MozartParams.NomSociete, sLangue)
            dts = Database.GetData($"exec [api_sp_TabletImpExtCRVPreport_Correction] {iNACTNUM},3")
            detailReport.DataSource = dts           ' Reprendre le DataTable du tour précédent
            REPORT.PrepareReport.AddInGROUPFooter(oCRVPCorrect, detailReport)

            oCRVPCorrect.CreateDocument()

            Dim ps As PrintingSystemBase = oCRVPCorrect.PrintingSystem
            Dim pdfExportOptions As New PdfExportOptions() With {.PdfACompatibility = PdfACompatibility.PdfA1b}
            ps.ExportToPdf(sPathOut_Temp & sFileOut_Temp, pdfExportOptions)

            oCRVPCorrect.Dispose()
            ps.Dispose()


            'copie attachment de temp vers att gam
            Try
                File.Copy(sPathOut_Temp & sFileOut_Temp, sFileOutPDF, True)
            Catch ex As Exception
                MessageBox.Show($"Erreur lors de la copie du fichier {sFileOutPDF}. Veuillez effectuer une nouvelle tentative de correction." & vbCrLf & "Si le problème persiste, fermer votre mozart car le fichier de destination est déjà ouvert.", "Erreur", MessageBoxButtons.OK, MessageBoxIcon.Error)
            End Try


            If MessageBox.Show("Voulez-vous visualiser le CRVP ?", "Confirmation", MessageBoxButtons.YesNoCancel, MessageBoxIcon.Question) = vbYes Then

                Dim oDocVisu As New frmVisuDoc(sPathOut_Temp & sFileOut_Temp, False)
                oDocVisu.ShowDialog()
                oDocVisu.Dispose()

            End If

            'clear des signature et du fichie doc
            If File.Exists(_Path_SignCli) = True Then File.Delete(_Path_SignCli)
            If File.Exists(_Path_SignTech) = True Then File.Delete(_Path_SignTech)
            _Path_SignTech = ""
            _Path_SignCli = ""

            If File.Exists(sPathOut_Temp & sFileOut_Temp) = True Then File.Delete(sPathOut_Temp & sFileOut_Temp)

            'vidage des tables et save dans histo
            MozartDatabase.ExecuteNonQuery($"EXEC api_sp_CorrectionCRVP_ClearTableTampon {iNACTNUM}")

            'messgae de creation OK
            MessageBox.Show("CRVP créé avec succès !", "Succès", MessageBoxButtons.OK, MessageBoxIcon.Information)


        End If


    End Sub

    Private Sub BtnExtInvEquipSuppLine_Click(sender As Object, e As EventArgs) Handles BtnExtInvEquipSuppLine.Click
        Try

            If GVExtInv.SelectedRowsCount > 0 Then
                'si handle row est inférieur à 0 alors elle ne fait pas partir de la datatable
                If GVExtInv.GetSelectedRows(0) < 0 Then
                    MessageBox.Show("Il faut sélectionner une fourniture", "Erreur", MessageBoxButtons.OK, MessageBoxIcon.Exclamation)
                    Return
                End If
            Else
                MessageBox.Show("Il faut sélectionner une fourniture", "Erreur", MessageBoxButtons.OK, MessageBoxIcon.Exclamation)
                Return
            End If

            'mise à jour de la datatable
            If MessageBox.Show("Voulez-vous vraiment supprimer cette founrniture ?", "Confirmation", MessageBoxButtons.YesNoCancel, MessageBoxIcon.Question) = vbYes Then

                pCExtInvEquip.SuppLineExtInvEquip(GVExtInv.GetDataRow(GVExtInv.GetSelectedRows(0)).Item("IDTMP"))

            End If

        Catch ex As Exception
            MessageBox.Show(ex.Message)
        End Try
    End Sub

    Private Sub BtnExtBordNewLine_Click(sender As Object, e As EventArgs) Handles BtnExtBordNewLine.Click
        Try

            pCExtBordereau.AddNewLineExtBordereau()

            ShowComboNewRow(GCExtBord.FocusedView, "NFOUNUM")

        Catch ex As Exception
            MessageBox.Show(ex.Message)
        End Try
    End Sub

    Private Sub BtnExtBordSuppLine_Click(sender As Object, e As EventArgs) Handles BtnExtBordSuppLine.Click
        Try

            If GVExtBord.SelectedRowsCount > 0 Then
                'si handle row est inférieur à 0 alors elle ne fait pas partir de la datatable
                If GVExtBord.GetSelectedRows(0) < 0 Then
                    MessageBox.Show("Il faut sélectionner une fourniture", "Erreur", MessageBoxButtons.OK, MessageBoxIcon.Exclamation)
                    Return
                End If
            Else
                MessageBox.Show("Il faut sélectionner une fourniture", "Erreur", MessageBoxButtons.OK, MessageBoxIcon.Exclamation)
                Return
            End If

            'mise à jour de la datatable
            If MessageBox.Show("Voulez-vous vraiment supprimer cette founrniture ?", "Confirmation", MessageBoxButtons.YesNoCancel, MessageBoxIcon.Question) = vbYes Then

                pCExtBordereau.SuppLineExtBordereau(GVExtBord.GetDataRow(GVExtBord.GetSelectedRows(0)).Item("IDTMP"))

            End If

        Catch ex As Exception
            MessageBox.Show(ex.Message)
        End Try
    End Sub

    Private Sub BtnVisu_Click(sender As Object, e As EventArgs)

    End Sub

    Public Function IsFileLocked(filePath As String) As Boolean

        Dim fileStream As System.IO.FileStream = Nothing
        If File.Exists(filePath) = False Then
            Return False ' Le fichier n'existe pas, donc il n'est pas verrouillé
        End If

        Try
            ' Tente d’ouvrir le fichier en lecture/écriture exclusive
            fileStream = System.IO.File.Open(filePath, System.IO.FileMode.Open, System.IO.FileAccess.ReadWrite, System.IO.FileShare.None)
        Catch ex As System.IO.IOException
            ' Si une exception est levée, le fichier est probablement verrouillé
            Return True
        Finally
            ' Fermer le flux si le fichier a été ouvert
            If fileStream IsNot Nothing Then
                fileStream.Close()
            End If
        End Try
        ' Aucun verrou détecté
        Return False

    End Function

End Class