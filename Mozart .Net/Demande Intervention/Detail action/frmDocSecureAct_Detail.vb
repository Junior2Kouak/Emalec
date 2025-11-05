Imports System.IO
Imports System.Runtime.InteropServices

Public Class frmDocSecureAct_Detail

    Dim _oDetailDocSecure As CACT_DOC_SECURE

    'Cette focntion de DLL est tuilisé pour libérer l'espace alloué dans la mémoire pour un document chargé dans un webbrowser : evéite le message 0x00000014
    <DllImport("ole32.dll")>
    Public Shared Sub CoFreeUnusedLibraries()
    End Sub

    Public Sub New(ByVal c_oDetailDocSecure As CACT_DOC_SECURE)

        ' Cet appel est requis par le concepteur.
        InitializeComponent()

        ' Ajoutez une initialisation quelconque après l'appel InitializeComponent().
        _oDetailDocSecure = c_oDetailDocSecure

    End Sub

    Private Sub frmDocSecureAct_Detail_Load(sender As Object, e As EventArgs) Handles MyBase.Load

        'init
        WebBrowserApercu.Navigate("about:blank")

        loaddata()

    End Sub

    Private Sub loaddata()

        TxtVFILENAME.Text = _oDetailDocSecure.VFILENAME
        TxtVFILEDESCRIPT.Text = _oDetailDocSecure.VFILEDESCRIPT
        TxtVFILE.Text = _oDetailDocSecure.PathActDocSecure & _oDetailDocSecure.VFILE

        If File.Exists(_oDetailDocSecure.PathActDocSecure & _oDetailDocSecure.VFILE) Then
            WebBrowserApercu.Navigate(_oDetailDocSecure.PathActDocSecure & _oDetailDocSecure.VFILE)
        End If

    End Sub

    Private Sub BtnSave_Click(sender As Object, e As EventArgs) Handles BtnSave.Click

        'on libere le web browser
        WebBrowserApercu.Navigate("about:blank")

        _oDetailDocSecure.VFILENAME = TxtVFILENAME.Text
        _oDetailDocSecure.VFILEDESCRIPT = TxtVFILEDESCRIPT.Text

        _oDetailDocSecure.SaveActDocSecure(TxtVFILE.Text)

        'refresh
        _oDetailDocSecure.LoadData()
        loaddata()

    End Sub

    Private Sub CmdOpen_Click(sender As Object, e As EventArgs) Handles CmdOpen.Click

        OFD.ShowDialog()

        If OFD.FileName <> "" Then
            TxtVFILE.Text = OFD.FileName
            WebBrowserApercu.Navigate(OFD.FileName)
        End If

    End Sub

    Private Sub frmDocSecureAct_Detail_FormClosed(sender As Object, e As FormClosedEventArgs) Handles Me.FormClosed

        'Ce code permet de géré le message d'erreur 0x0000014
        WebBrowserApercu.Visible = False
        WebBrowserApercu.Navigate("about:blank")
        While (WebBrowserApercu.IsBusy = True)
            Application.DoEvents()
        End While
        WebBrowserApercu.Dispose()
        CoFreeUnusedLibraries()

    End Sub

    Private Sub BtnFermer_Click(sender As Object, e As EventArgs) Handles BtnFermer.Click
        Me.Close()
    End Sub
End Class