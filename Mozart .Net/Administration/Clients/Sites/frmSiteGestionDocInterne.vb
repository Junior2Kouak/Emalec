Imports System.Runtime.Serialization
Imports System.Runtime.InteropServices    

Public Class frmSiteGestionDocInterne

    Dim oSiteDocInt As CSITDOCINT
    
    Dim iNSITNUM As int32

    'Cette focntion de DLL est tuilisé pour libérer l'espace alloué dans la mémoire pour un document chargé dans un webbrowser : evéite le message 0x00000014
    <DllImport("ole32.dll")> _
    Public Shared Sub CoFreeUnusedLibraries()
    End Sub

    Public Sub new(ByVal c_NSITNUM As string)

        ' Cet appel est requis par le concepteur.
        InitializeComponent()
        
        ' Ajoutez une initialisation quelconque après l'appel InitializeComponent().
        iNSITNUM = Convert.ToInt32(c_NSITNUM)                

    End Sub

    Private Sub frmSiteGestionDocInterne_FormClosed(ByVal sender As Object, ByVal e As System.Windows.Forms.FormClosedEventArgs) Handles MyBase.FormClosed 

        Try

            'vidage du dossier tempo
            For Each oDRDelTemp As DataRow In oSiteDocInt.ListeDocInterneSite.Rows 

                if File.Exists(System.IO.Path.GetTempPath() + Path.GetFileName(oDRDelTemp.Item("VFILENAME"))) then
                    File.Delete(System.IO.Path.GetTempPath() + Path.GetFileName(oDRDelTemp.Item("VFILENAME")))
                End If

            Next

            'Ce code permet de géré le message d'erreur 0x0000014
            WBApercu.Visible = false
            WBApercu.Navigate("about:blank")
            while (WBApercu.IsBusy = True)
                Application.DoEvents()
            End While        
            WBApercu.Dispose()
            CoFreeUnusedLibraries

        Catch ex As Exception

        End Try        

    End Sub

    Private Sub frmSiteGestionDocInterne_FormClosing(ByVal sender As Object, ByVal e As System.Windows.Forms.FormClosingEventArgs) Handles MyBase.FormClosing  

        Try
            WBApercu.Navigate("about:blank")

            If (Not oSiteDocInt.p_dtSiteDocInterne.GetChanges Is Nothing AndAlso oSiteDocInt.p_dtSiteDocInterne.GetChanges.Rows.Count > 0) Then

                Select Case MessageBox.Show(My.Resources.Global_Enregistrer_Modif, My.Resources.Global_modif_confirmation, MessageBoxButtons.YesNoCancel, MessageBoxIcon.Exclamation)

                    Case vbYes
                        BtnSave.PerformClick()
                        Me.Close()
                    Case vbCancel
                        e.Cancel = True
                    Case Else
                        e.Cancel = False

                End Select

            End If

        Catch ex As Exception

            MessageBox.Show(ex.Message)

        End Try

    End Sub

    Private Sub frmSiteGestionDocInterne_Load( ByVal sender As System.Object,  ByVal e As System.EventArgs) Handles MyBase.Load 

        'init        
        oSiteDocInt = New CSITDOCINT(iNSITNUM)
        
        Me.Text = String.Format(Me.Text, oSiteDocInt.p_sSiteNom)
        Label1.Text = String.Format(Label1.Text, oSiteDocInt.p_sSiteNom)  

        GCSitDocInt.DataSource = oSiteDocInt.ListeDocInterneSite

    End Sub

    Private Sub BtnQuit_Click( ByVal sender As System.Object,  ByVal e As System.EventArgs) Handles BtnQuit.Click

        Me.Close 

    End Sub

    Private Sub BtnAddLine_Click( ByVal sender As System.Object,  ByVal e As System.EventArgs) Handles BtnAddLine.Click

        oSiteDocInt.CreateDocInterne 

    End Sub

    Private Sub GVSitDocInt_FocusedRowChanged(ByVal sender As Object, ByVal e As DevExpress.XtraGrid.Views.Base.FocusedRowChangedEventArgs) Handles GVSitDocInt.FocusedRowChanged

         If e.FocusedRowHandle < 0 Then
            Exit sub
        End If

        'prévisualation du document                
        If GVSitDocInt.GetDataRow(e.FocusedRowHandle).Item("VFILENAME").ToString  <> "" Then
            WBApercu.Navigate(PathFilePrevisuTemp(GVSitDocInt.GetDataRow(e.FocusedRowHandle).Item("VFILENAME").ToString))
        Else
            WBApercu.Navigate("about:blank")
        End If

    End Sub
            
    Private Sub BtnModifier_Click( ByVal sender As System.Object,  ByVal e As System.EventArgs) Handles BtnModifier.Click

        If GVSitDocInt.SelectedRowsCount = 0 Then Exit sub

        Dim HandleRowSelect As Int32 = GVSitDocInt.GetSelectedRows(0)

        oSiteDocInt.ModifDocInterne(GVSitDocInt.GetDataRow(GVSitDocInt.GetSelectedRows(0)))

        ''prévisualation du document
        If GVSitDocInt.GetDataRow(HandleRowSelect).Item("VFILENAME").ToString  <> "" Then
            WBApercu.Navigate(PathFilePrevisuTemp(GVSitDocInt.GetDataRow(HandleRowSelect).Item("VFILENAME").ToString))
        Else
            WBApercu.Navigate("about:blank")
        End If      

    End Sub

    Private Sub BtnSupprLine_Click( ByVal sender As System.Object,  ByVal e As System.EventArgs) Handles BtnSupprLine.Click

        Try

            If GVSitDocInt.SelectedRowsCount = 0 Then Exit sub

            If GVSitDocInt.SelectedRowsCount > 0 Then
                'si handle row est inférieur à 0 alors elle ne fait pas partir de la datatable
                If GVSitDocInt.GetSelectedRows(0) < 0 Then
                    MessageBox.Show(My.Resources.Global_selection_doc, My.Resources.Global_suppression_doc, MessageBoxButtons.OK, MessageBoxIcon.Exclamation)
                    Return
                End If
            Else
                MessageBox.Show(My.Resources.Global_selection_doc, My.Resources.Global_suppression_doc, MessageBoxButtons.OK, MessageBoxIcon.Exclamation)
                Return
            End If

            'mise à jour de la datatable
            If MessageBox.Show(My.Resources.Global_msg_suppression_doc, My.Resources.Global_confirmation_suppression, MessageBoxButtons.YesNoCancel, MessageBoxIcon.Question) = vbYes Then

                oSiteDocInt.SuppLineSiteDocInterne(GVSitDocInt.GetDataRow(GVSitDocInt.GetSelectedRows(0)).Item("IDTMP"))

                'on vide le webbrowser
                WBApercu.Navigate("about:blank")

            End If

        Catch ex As Exception
            MessageBox.Show(ex.Message)
        End Try

    End Sub

    Private Sub BtnSave_Click( ByVal sender As System.Object,  ByVal e As System.EventArgs) Handles BtnSave.Click

        oSiteDocInt.SaveDocInterne 

        'on recharge la liste
        GCSitDocInt.DataSource = oSiteDocInt.ListeDocInterneSite

    End Sub

    Private Function PathFilePrevisuTemp(ByVal p_sPathFileSource As String, Optional ByVal CreateFileTemp As Boolean = False) As String

        Try

            'path du repertoire temp de windows
            Dim sFileTemp As String

            If (CreateFileTemp = False) Then
                sFileTemp = System.IO.Path.GetTempPath() + Path.GetFileName(p_sPathFileSource)
            Else
                sFileTemp = System.IO.Path.GetTempPath() + Path.GetRandomFileName()
                sFileTemp = Path.ChangeExtension(sFileTemp, Path.GetExtension(p_sPathFileSource))
                'sFileTemp = "C:\temp\test.pdf"
            End If

            If File.Exists(p_sPathFileSource) Then

                File.Copy(p_sPathFileSource, sFileTemp, True)

            End If

            Return sFileTemp

        Catch ex As Exception
            'MessageBox.Show(ex.Message)
            Return "about:blank"
        End Try

    End Function

    Private Sub BtnOpen_Click(sender As Object, e As EventArgs) Handles BtnOpen.Click
        If GVSitDocInt.FocusedRowHandle < 0 Then
            Exit Sub
        End If

        'prévisualation du document                
        If GVSitDocInt.GetDataRow(GVSitDocInt.FocusedRowHandle).Item("VFILENAME").ToString <> "" Then
            Process.Start(PathFilePrevisuTemp(GVSitDocInt.GetDataRow(GVSitDocInt.FocusedRowHandle).Item("VFILENAME").ToString, True))
        End If
    End Sub
End Class