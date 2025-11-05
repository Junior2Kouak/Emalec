Imports System.Runtime.Serialization
Imports System.Runtime.InteropServices

Public Class frmProspectGestionDocInterne

  Dim oProspDocInt As CPROSPDOCINT

  Dim iNPROSNUM As Integer

  'Cette focntion de DLL est tuilisé pour libérer l'espace alloué dans la mémoire pour un document chargé dans un webbrowser : evéite le message 0x00000014
  <DllImport("ole32.dll")>
  Public Shared Sub CoFreeUnusedLibraries()
  End Sub

  Public Sub New(c_NPROSNUM As Integer)

    ' Cet appel est requis par le concepteur.
    InitializeComponent()

    ' Ajoutez une initialisation quelconque après l'appel InitializeComponent().
    iNPROSNUM = c_NPROSNUM

  End Sub

  Private Sub frmProspectGestionDocInterne_FormClosed(sender As Object, e As FormClosedEventArgs) Handles Me.FormClosed

    Try

      'vidage du dossier tempo
      For Each oDRDelTemp As DataRow In oProspDocInt.ListeDocInterneProsp.Rows

        If File.Exists(Path.GetTempPath() + Path.GetFileName(oDRDelTemp.Item("VFILENAME"))) Then
          File.Delete(Path.GetTempPath() + Path.GetFileName(oDRDelTemp.Item("VFILENAME")))
        End If

      Next

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

  Private Sub frmProspectGestionDocInterne_FormClosing(sender As Object, e As FormClosingEventArgs) Handles Me.FormClosing

    Try
      WBApercu.Navigate("about:blank")

      If (Not oProspDocInt.p_dtProspDocInterne.GetChanges Is Nothing AndAlso oProspDocInt.p_dtProspDocInterne.GetChanges.Rows.Count > 0) Then

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

  Private Sub frmProspectGestionDocInterne_Load(sender As Object, e As EventArgs) Handles MyBase.Load

    'init        
    oProspDocInt = New CPROSPDOCINT(iNPROSNUM)

    Me.Text = String.Format(Me.Text, oProspDocInt.p_sProspectNom)
    Label1.Text = String.Format(Label1.Text, oProspDocInt.p_sProspectNom)

    GCProspDocInt.DataSource = oProspDocInt.ListeDocInterneProsp

  End Sub

  Private Sub BtnQuit_Click(sender As Object, e As EventArgs) Handles BtnQuit.Click

    Me.Close()

  End Sub

  Private Sub BtnAddLine_Click(sender As Object, e As EventArgs) Handles BtnAddLine.Click

    oProspDocInt.CreateDocInterne()

  End Sub

  Private Sub GVProspDocInt_FocusedRowChanged(sender As Object, e As DevExpress.XtraGrid.Views.Base.FocusedRowChangedEventArgs) Handles GVProspDocInt.FocusedRowChanged

    If e.FocusedRowHandle < 0 Then
      Exit Sub
    End If

    'prévisualation du document                
    If GVProspDocInt.GetDataRow(e.FocusedRowHandle).Item("VFILENAME").ToString <> "" Then
      WBApercu.Navigate(PathFilePrevisuTemp(GVProspDocInt.GetDataRow(e.FocusedRowHandle).Item("VFILENAME").ToString))
    Else
      WBApercu.Navigate("about:blank")
    End If

  End Sub

  Private Sub BtnModifier_Click(sender As Object, e As EventArgs) Handles BtnModifier.Click

    If GVProspDocInt.SelectedRowsCount = 0 Then Exit Sub

    Dim HandleRowSelect As Integer = GVProspDocInt.GetSelectedRows(0)

    oProspDocInt.ModifDocInterne(GVProspDocInt.GetDataRow(GVProspDocInt.GetSelectedRows(0)))

    ''prévisualation du document
    If GVProspDocInt.GetDataRow(HandleRowSelect).Item("VFILENAME").ToString <> "" Then
      WBApercu.Navigate(PathFilePrevisuTemp(GVProspDocInt.GetDataRow(HandleRowSelect).Item("VFILENAME").ToString))
    Else
      WBApercu.Navigate("about:blank")
    End If

  End Sub

  Private Sub BtnSupprLine_Click(sender As Object, e As EventArgs) Handles BtnSupprLine.Click

    Try

      If GVProspDocInt.SelectedRowsCount = 0 Then Exit Sub

      If GVProspDocInt.SelectedRowsCount > 0 Then
        'si handle row est inférieur à 0 alors elle ne fait pas partir de la datatable
        If GVProspDocInt.GetSelectedRows(0) < 0 Then
          MessageBox.Show(My.Resources.Global_selection_doc, My.Resources.Global_suppression_doc, MessageBoxButtons.OK, MessageBoxIcon.Exclamation)
          Return
        End If
      Else
        MessageBox.Show(My.Resources.Global_selection_doc, My.Resources.Global_suppression_doc, MessageBoxButtons.OK, MessageBoxIcon.Exclamation)
        Return
      End If

      'mise à jour de la datatable
      If MessageBox.Show(My.Resources.Global_msg_suppression_doc, My.Resources.Global_confirmation_suppression, MessageBoxButtons.YesNoCancel, MessageBoxIcon.Question) = vbYes Then

        oProspDocInt.SuppLineProspDocInterne(GVProspDocInt.GetDataRow(GVProspDocInt.GetSelectedRows(0)).Item("IDTMP"))

        'on vide le webbrowser
        WBApercu.Navigate("about:blank")

      End If

    Catch ex As Exception
      MessageBox.Show(ex.Message)
    End Try


  End Sub

  Private Sub BtnSave_Click(sender As Object, e As EventArgs) Handles BtnSave.Click

    oProspDocInt.SaveDocInterne()

    'on recharge la liste
    GCProspDocInt.DataSource = oProspDocInt.ListeDocInterneProsp

  End Sub

  Private Function PathFilePrevisuTemp(p_sPathFileSource As String) As String

    Try

      'path du repertoire temp de windows
      Dim sFileTemp As String = Path.GetTempPath() + Path.GetFileName(p_sPathFileSource)

      If File.Exists(p_sPathFileSource) Then

        File.Copy(p_sPathFileSource, sFileTemp, True)

      End If

      Return sFileTemp

    Catch ex As Exception
      'MessageBox.Show(ex.Message)
      Return "about:blank"
    End Try

  End Function

End Class
