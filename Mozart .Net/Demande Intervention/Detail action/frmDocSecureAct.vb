Imports System.Data.SqlClient
Imports System.IO
Imports System.Runtime.InteropServices
Imports DevExpress.XtraGrid.Views.Base
Imports MozartLib


' Plus utilisé

Public Class frmDocSecureAct

  Dim _NACTNUM As Int32

  Dim DtListeDocSecure As DataTable

  'Cette focntion de DLL est tuilisé pour libérer l'espace alloué dans la mémoire pour un document chargé dans un webbrowser : evéite le message 0x00000014
  <DllImport("ole32.dll")>
  Public Shared Sub CoFreeUnusedLibraries()
  End Sub

  Public Sub New(ByVal c_NACTNUM As Object)

    ' Cet appel est requis par le concepteur.
    InitializeComponent()

    ' Ajoutez une initialisation quelconque après l'appel InitializeComponent().
    _NACTNUM = Convert.ToInt32(c_NACTNUM)

  End Sub

  Private Sub frmDocSecureAct_Load(sender As Object, e As EventArgs) Handles MyBase.Load

    'test si les accès au dossier partagé est ok
    Dim indo As DirectoryInfo = New DirectoryInfo(gstrCheminActDocSecure)
    Try
      indo.GetAccessControl()
    Catch ex As Exception
      MessageBox.Show(String.Format("Vous n'avez pas accès au dossier {0}", gstrCheminActDocSecure), "Erreur", MessageBoxButtons.OK, MessageBoxIcon.Exclamation)
      Me.Close()
    End Try

    LoadData()

  End Sub

  Private Sub LoadData()

    'init
    GCListeDocSecure.DataSource = Nothing

    DtListeDocSecure = New DataTable

    Dim sqlcmd As New SqlCommand("[api_sp_actDocSecure_Liste]", MozartDatabase.cnxMozart)
    sqlcmd.CommandType = CommandType.StoredProcedure
        sqlcmd.Parameters.Add("@P_NACTNUM", SqlDbType.Int).Value = _NACTNUM
        DtListeDocSecure.Load(sqlcmd.ExecuteReader())

        GCListeDocSecure.DataSource = DtListeDocSecure

    End Sub

    Private Sub ButtonDetails_Click(sender As Object, e As EventArgs) Handles ButtonDetails.Click

        If GVListeDocSecure.FocusedRowHandle < 0 Then Exit Sub

        Dim drSelectPDoc As DataRow = GVListeDocSecure.GetDataRow(GVListeDocSecure.FocusedRowHandle)

        'init pour libéré le fihcier
        WebBrowser.Navigate("about:blank")

        Dim oFrmDocSecureActDetail As New frmDocSecureAct_Detail(New CACT_DOC_SECURE(drSelectPDoc.Item("NIDACTDOCSECURE"), drSelectPDoc.Item("NACTNUM")))
        oFrmDocSecureActDetail.ShowDialog()

        'resfresh
        WebBrowser.Navigate("about:blank")
        LoadData()

    End Sub

    Private Sub ButtonSupp_Click(sender As Object, e As EventArgs) Handles ButtonSupp.Click

        If GVListeDocSecure.FocusedRowHandle < 0 Then Exit Sub

        Dim drSelectPDoc As DataRow = GVListeDocSecure.GetDataRow(GVListeDocSecure.FocusedRowHandle)
        'init pour libéré le fihcier
        WebBrowser.Navigate("about:blank")
        If MessageBox.Show("Voulez-vous supprimer ce document ?", "Confirmation", MessageBoxButtons.YesNoCancel, MessageBoxIcon.Question) = DialogResult.Yes Then



            Dim oDocSecureAct As CACT_DOC_SECURE = New CACT_DOC_SECURE(drSelectPDoc.Item("NIDACTDOCSECURE"), drSelectPDoc.Item("NACTNUM"))
            oDocSecureAct.DeleteActDocSecure()

        End If

        'refresh
        WebBrowser.Navigate("about:blank")
        LoadData()

    End Sub

    Private Sub BtnAjouter_Click(sender As Object, e As EventArgs) Handles BtnAjouter.Click

        'init pour libéré le fihcier
        WebBrowser.Navigate("about:blank")

        Dim oFrmDocSecureActNew As New frmDocSecureAct_Detail(New CACT_DOC_SECURE(0, _NACTNUM))
        oFrmDocSecureActNew.ShowDialog()

        'refresh
        WebBrowser.Navigate("about:blank")
        LoadData()

    End Sub

    Private Sub GVListeDocSecure_FocusedRowChanged(sender As Object, e As FocusedRowChangedEventArgs) Handles GVListeDocSecure.FocusedRowChanged

        'init
        WebBrowser.Navigate("about:blank")

        If e.FocusedRowHandle > -1 Then

            Dim drSelect As DataRow = GVListeDocSecure.GetDataRow(e.FocusedRowHandle)

            If File.Exists(drSelect.Item("PATH_ACT_DOC_SECURE") & drSelect.Item("VFILE")) Then

                WebBrowser.Navigate(drSelect.Item("PATH_ACT_DOC_SECURE") & drSelect.Item("VFILE"))

            End If
        End If

    End Sub

    Private Sub frmDocSecureAct_FormClosed(sender As Object, e As FormClosedEventArgs) Handles Me.FormClosed

        'Ce code permet de géré le message d'erreur 0x0000014
        WebBrowser.Visible = False
        WebBrowser.Navigate("about:blank")
        While (WebBrowser.IsBusy = True)
            Application.DoEvents()
        End While
        WebBrowser.Dispose()
        CoFreeUnusedLibraries()

    End Sub

    Private Sub BtnFermer_Click(sender As Object, e As EventArgs) Handles BtnFermer.Click
        Me.Close()
    End Sub

End Class