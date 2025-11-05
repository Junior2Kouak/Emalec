Imports System.Runtime.Serialization
Imports System.Runtime.InteropServices

Public Class frmGestionDocSTFCondCom

    Dim oDocSTFCondCom As CDocSTFCondCom

    Dim iNSTFGRPNUM As Int32
    Dim iPos As Int32

    'Cette focntion de DLL est tuilisé pour libérer l'espace alloué dans la mémoire pour un document chargé dans un webbrowser : evéite le message 0x00000014
    <DllImport("ole32.dll")> _
    Public Shared Sub CoFreeUnusedLibraries()
    End Sub

    Public Sub New(ByVal c_STFGRPNUM As Object)

        ' Cet appel est requis par le concepteur.
        InitializeComponent()

        ' Ajoutez une initialisation quelconque après l'appel InitializeComponent().
        iNSTFGRPNUM = Convert.ToInt32(c_STFGRPNUM)

    End Sub

    Private Sub frmGestionDocSTFCondCom_FormClosed(ByVal sender As Object, ByVal e As System.Windows.Forms.FormClosedEventArgs) Handles MyBase.FormClosed

        Try

            'Ce code permet de géré le message d'erreur 0x0000014
            WBApercu.Visible = False
            WBApercu.Navigate("about:blank")
            While (WBApercu.IsBusy = True)
                Application.DoEvents()
            End While
            WBApercu.Dispose()
            CoFreeUnusedLibraries()

        Catch ex As Exception

        End Try

    End Sub

    Private Sub frmGestionDocSTFCondCom_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load

        'init        
        oDocSTFCondCom = New CDocSTFCondCom(iNSTFGRPNUM)

        Me.Text = String.Format(Me.Text, oDocSTFCondCom.p_sSTFGRPNom)

        Label1.Text = String.Format(Label1.Text, oDocSTFCondCom.p_sSTFGRPNom)

        LoadData()

    End Sub

    Private Sub LoadData()

        GCDocSTFCondCom.DataSource = oDocSTFCondCom.ListeDocSTFCondCom

    End Sub

    Private Sub BtnQuit_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles BtnQuit.Click

        Me.Close()

    End Sub

    Private Sub BtnAddLine_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles BtnAddLine.Click

        oDocSTFCondCom.CreateDocSTFCondCom()

        iPos = GVDocSTFCondCom.FocusedRowHandle

        LoadData()

        GVDocSTFCondCom.FocusedRowHandle = iPos
        If GVDocSTFCondCom.FocusedRowHandle < 0 Then
            Exit Sub
        End If

        'prévisualation du document
        If GVDocSTFCondCom.GetDataRow(GVDocSTFCondCom.FocusedRowHandle).Item("VPATHFILE").ToString <> "" Then
            WBApercu.Navigate(PathFilePrevisuTemp(GVDocSTFCondCom.GetDataRow(GVDocSTFCondCom.FocusedRowHandle).Item("VPATHFILE").ToString, If(Not WBApercu.Url Is Nothing, WBApercu.Url.LocalPath.ToString, "")))
        Else
            WBApercu.Navigate("about:blank")
        End If



    End Sub

    Private Sub BtnSupprLine_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles BtnSupprLine.Click

        Try

            If GVDocSTFCondCom.SelectedRowsCount = 0 Then Exit Sub

            If GVDocSTFCondCom.SelectedRowsCount > 0 Then
                'si handle row est inférieur à 0 alors elle ne fait pas partir de la datatable
                If GVDocSTFCondCom.GetSelectedRows(0) < 0 Then
                    MessageBox.Show(My.Resources.Global_selection_doc, My.Resources.Global_suppression_doc, MessageBoxButtons.OK, MessageBoxIcon.Exclamation)
                    Return
                End If
            Else
                MessageBox.Show(My.Resources.Global_selection_doc, My.Resources.Global_suppression_doc, MessageBoxButtons.OK, MessageBoxIcon.Exclamation)
                Return
            End If

            'mise à jour de la datatable
            If MessageBox.Show(My.Resources.Global_msg_suppression_doc, My.Resources.Global_confirmation_suppression, MessageBoxButtons.YesNoCancel, MessageBoxIcon.Question) = vbYes Then

                'on vide le webbrowser
                WBApercu.Navigate("about:blank")

                oDocSTFCondCom.DeleteLigneDocSTFCondCom(GVDocSTFCondCom.GetDataRow(GVDocSTFCondCom.GetSelectedRows(0)))

            End If

        Catch ex As Exception
            MessageBox.Show(ex.Message)
        End Try

    End Sub

    Private Function PathFilePrevisuTemp(ByVal p_sPathFileSource As String, ByVal p_url As String) As String

        Try

            'path du repertoire temp de windows
            Dim sFileTemp As String = System.IO.Path.GetTempPath() + Path.GetFileName(p_sPathFileSource)

            If p_url <> sFileTemp AndAlso File.Exists(p_sPathFileSource) Then

                File.Copy(p_sPathFileSource, sFileTemp, True)

            End If

            Return sFileTemp

        Catch ex As Exception
            'MessageBox.Show(ex.Message)
            Return "about:blank"
        End Try

    End Function


    Private Sub GVDocSTFCondCom_RowClick(sender As Object, e As DevExpress.XtraGrid.Views.Grid.RowClickEventArgs) Handles GVDocSTFCondCom.RowClick

        If e.RowHandle < 0 Then
            Exit Sub
        End If

        'prévisualation du document 
        If GVDocSTFCondCom.GetDataRow(e.RowHandle).Item("VPATHFILE").ToString <> "" Then
            WBApercu.Navigate(PathFilePrevisuTemp(GVDocSTFCondCom.GetDataRow(e.RowHandle).Item("VPATHFILE").ToString, If(Not WBApercu.Url Is Nothing, WBApercu.Url.LocalPath.ToString, "")))
        Else
            WBApercu.Navigate("about:blank")
        End If

    End Sub

    Private Sub BtnModifier_Click(sender As System.Object, e As System.EventArgs) Handles BtnModifier.Click

        If GVDocSTFCondCom.RowCount = 0 Then
            Exit Sub
        End If

        Dim drSelect As DataRow = GVDocSTFCondCom.GetDataRow(GVDocSTFCondCom.GetSelectedRows(0))

        oDocSTFCondCom.ModifDocSTFCondCom(drSelect)

        iPos = GVDocSTFCondCom.FocusedRowHandle

        LoadData()

        GVDocSTFCondCom.FocusedRowHandle = iPos

        If GVDocSTFCondCom.FocusedRowHandle < 0 Then
            Exit Sub
        End If

        'prévisualation du document                
        If GVDocSTFCondCom.GetDataRow(GVDocSTFCondCom.FocusedRowHandle).Item("VPATHFILE").ToString <> "" Then
            WBApercu.Navigate(PathFilePrevisuTemp(GVDocSTFCondCom.GetDataRow(GVDocSTFCondCom.FocusedRowHandle).Item("VPATHFILE").ToString, If(Not WBApercu.Url Is Nothing, WBApercu.Url.LocalPath.ToString, "")))
        Else
            WBApercu.Navigate("about:blank")
        End If

    End Sub

  Private Sub btnVisualiser_Click(sender As System.Object, e As System.EventArgs) Handles btnVisualiser.Click

    Try

      If GVDocSTFCondCom.RowCount = 0 Then
        Exit Sub
      End If

      ' On récupère le n° unique NVEHNUM sélectionné dans la liste
      Dim ligne_selectionnee As Integer() = GVDocSTFCondCom.GetSelectedRows()
      Dim vfichier As String = GVDocSTFCondCom.GetRowCellValue(ligne_selectionnee.ElementAt(0), "VPATHFILE").ToString

      'Dim oFrmVisuDoc As New frmVisuDoc(PathFilePrevisuTemp(vfichier, ""))
      Dim oFrmVisuDoc As New frmVisuDoc(vfichier)

      oFrmVisuDoc.ShowDialog()

      ' Nettoyage
      oFrmVisuDoc = Nothing

    Catch ex As Exception
      MessageBox.Show(My.Resources.Global_aucune_ligne, My.Resources.Global_Information)
        End Try

  End Sub
End Class