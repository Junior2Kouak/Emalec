Imports System.Data.SqlClient
Imports System.Runtime.InteropServices
Imports MozartLib

Public Class frmGestionDocChantier

  Dim oSqlConn As New CGestionSQL
  Dim dtListeDocChantier As DataTable

  Dim nidchantier As Int32
  Dim sNomChantier As String
  Dim bReadOnly As Boolean

  'Cette focntion de DLL est tuilisé pour libérer l'espace alloué dans la mémoire pour un document chargé dans un webbrowser : evéite le message 0x00000014
  <DllImport("ole32.dll")>
  Public Shared Sub CoFreeUnusedLibraries()
  End Sub

  Public Sub New(ByVal c_nidchantier As Int32, ByVal c_NomChantier As String, ByVal c_bReadOnly As Boolean) '

    ' Cet appel est requis par le concepteur.
    InitializeComponent()

    ' Ajoutez une initialisation quelconque après l'appel InitializeComponent().
    nidchantier = c_nidchantier
    sNomChantier = c_NomChantier
    bReadOnly = c_bReadOnly

  End Sub

  Private Sub frmGestionDocChantier_FormClosed(ByVal sender As Object, ByVal e As System.Windows.Forms.FormClosedEventArgs) Handles Me.FormClosed

    oSqlConn.CloseConnexionSQL()

    'Ce code permet de géré le message d'erreur 0x0000014
    WBApercu.Visible = False
    WBApercu.Navigate("about:blank")
    While (WBApercu.IsBusy = True)
      Application.DoEvents()
    End While
    WBApercu.Dispose()
    CoFreeUnusedLibraries()
  End Sub

  Private Function ChangesDetected() As DialogResult

    Try

      'on teste si il y eu des modifs questions non enregistrer.
      If Not dtListeDocChantier Is Nothing AndAlso Not dtListeDocChantier.GetChanges Is Nothing Then

        If dtListeDocChantier.GetChanges.Rows.Count > 0 Then

          Select Case MessageBox.Show(My.Resources.Global_Enregistrer_Modif, My.Resources.Admin_frmGestionDocChantier_document_chantier, MessageBoxButtons.YesNoCancel, MessageBoxIcon.Exclamation)

            Case DialogResult.Yes
              BtnSave.PerformClick()
              Return DialogResult.Yes
            Case DialogResult.Cancel
              Return DialogResult.Cancel
            Case Else
              Return DialogResult.No
          End Select

        Else

          Return DialogResult.No

        End If

      Else

        Return DialogResult.No

      End If

    Catch ex As Exception

      MessageBox.Show(ex.Message)
      Return DialogResult.Cancel

    End Try

  End Function

  Private Sub frmGestionDocChantier_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load

    If oSqlConn.ConnexionSQL(MozartParams.NomServeur, MozartParams.NomSociete) = True Then
      LoadListeDocChantier()
      ResizeAllComponents()
    End If

    Me.Text = String.Format(Me.Text, sNomChantier)
    GrpListe.Text = String.Format(GrpListe.Text, sNomChantier)

    If bReadOnly = True Then
      BtnAjouter.Visible = False
      BtnSupprimer.Visible = False
      BtnSave.Visible = False
    Else
      BtnAjouter.Visible = True
      BtnSupprimer.Visible = True
      BtnSave.Visible = True
    End If

  End Sub

  Private Sub LoadListeDocChantier()

    Try

      Dim sRequete As String = String.Format("api_sp_ListeChantierDoc {0}", nidchantier)

      dtListeDocChantier = New DataTable
      dtListeDocChantier = ModDataGridView.LoadListWithIncrementAuto(sRequete, oSqlConn.CnxSQLOpen)
      GCChantierDoc.DataSource = dtListeDocChantier

    Catch ex As Exception
      MessageBox.Show(ex.Message)
    End Try

  End Sub

  Private Sub BtnFermer_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles BtnFermer.Click

    Me.Close()

  End Sub

  Private Sub BtnAjouter_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles BtnAjouter.Click

    Try

      OFD.FileName = ""
      OFD.Filter = "Fichiers PDF (.PDF)|*.PDF|Document Word (*.doc)|*.doc|Document EXCEL (*.xls)|*.xls|Document Word 2007 (*.docx)|*.docx|Document EXCEL 2007 (*.xlsx)|*.xlsx|All Files (*.*)|*.*"
      OFD.ShowDialog()

      If OFD.FileName <> "" Then

        Dim oNewRow As DataRow = dtListeDocChantier.NewRow

        oNewRow.Item("NIDCHANTIERDOC") = 0
        oNewRow.Item("NIDCHANTIER") = nidchantier
        oNewRow.Item("VFILE") = Path.GetFileName(OFD.FileName)
        oNewRow.Item("DQUICREE") = Now
        oNewRow.Item("FICTMP") = OFD.FileName

        dtListeDocChantier.Rows.Add(oNewRow)

      End If

    Catch ex As Exception
      MessageBox.Show(ex.Message)
    End Try

  End Sub

  Private Sub BtnSupprimer_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles BtnSupprimer.Click

    Try

      If dtListeDocChantier.Rows.Count = 0 Then
        Return
      End If

      If GVChantierDoc.GetSelectedRows(0) < 0 Then
        MessageBox.Show(My.Resources.Global_selection_doc, My.Resources.Global_suppression_doc, MessageBoxButtons.OK, MessageBoxIcon.Exclamation)
        Return
      End If

      ''mise à jour de la datatable
      If MessageBox.Show(My.Resources.Global_msg_suppression_doc, My.Resources.Global_confirmation_suppression, MessageBoxButtons.YesNoCancel, MessageBoxIcon.Question) = DialogResult.Yes Then

        dtListeDocChantier.Select("IDTMP=" + GVChantierDoc.GetDataRow(GVChantierDoc.GetSelectedRows(0)).Item("IDTMP").ToString)(0).Delete()
        WBApercu.Navigate("about:blank")

      End If

    Catch ex As Exception

      MessageBox.Show(ex.Message)

    End Try

  End Sub

  Private Sub BtnSave_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles BtnSave.Click

    Try

      Dim ODtSupprLine As DataTable = dtListeDocChantier.GetChanges(DataRowState.Deleted)

      If Not ODtSupprLine Is Nothing Then

        ODtSupprLine.RejectChanges()

        'suppression des lignes supprimer dans la datable
        If ODtSupprLine.Rows.Count > 0 Then

          For Each oRowsInvSupp As DataRow In ODtSupprLine.Rows

            SupprLigneDocChantier(oRowsInvSupp)

          Next

        End If

      End If

      dtListeDocChantier.AcceptChanges()

      'sauvegarde des lignes inventaires
      If dtListeDocChantier.Rows.Count > 0 Then

        For Each oRowsInv As DataRow In dtListeDocChantier.Rows

          SaveLigneDocChantier(oRowsInv)

        Next

      End If

      'on recharge les données
      LoadListeDocChantier()

    Catch ex As Exception
      MessageBox.Show(ex.Message)
    End Try

  End Sub

  Private Sub SaveLigneDocChantier(ByVal oRowsSavTemp As DataRow)

    Try

      Dim sFileDest As String = ""

      'avant d'enregistrer on test si le fichier existe toujours
      If CType(oRowsSavTemp.Item("NIDCHANTIERDOC"), Integer) = 0 Then

        If File.Exists(oRowsSavTemp.Item("FICTMP")) = True Then

          Dim sqlcmdCreateLigne As New SqlCommand("api_sp_CreationChantierDoc", oSqlConn.CnxSQLOpen)
          sqlcmdCreateLigne.CommandType = CommandType.StoredProcedure
          sqlcmdCreateLigne.Parameters.Add("@P_NIDCHANTIERDOC", SqlDbType.Int)
          sqlcmdCreateLigne.Parameters("@P_NIDCHANTIERDOC").Value = oRowsSavTemp.Item("NIDCHANTIERDOC")
          sqlcmdCreateLigne.Parameters.Add("@P_NIDCHANTIER", SqlDbType.Int)
          sqlcmdCreateLigne.Parameters("@P_NIDCHANTIER").Value = oRowsSavTemp.Item("NIDCHANTIER")
          sqlcmdCreateLigne.Parameters.Add("@P_VFILE", SqlDbType.VarChar)
          sqlcmdCreateLigne.Parameters("@P_VFILE").Value = oRowsSavTemp.Item("VFILE")
          sqlcmdCreateLigne.Parameters.Add("@P_DQUICREE", SqlDbType.DateTime)
          sqlcmdCreateLigne.Parameters("@P_DQUICREE").Value = oRowsSavTemp.Item("DQUICREE")

          sFileDest = sqlcmdCreateLigne.ExecuteScalar

          File.Copy(oRowsSavTemp.Item("FICTMP").ToString, gstrCheminChantierDoc + sFileDest)

        End If

      End If


    Catch ex As Exception
      MessageBox.Show(ex.Message)
    End Try

  End Sub

  Private Sub SupprLigneDocChantier(ByVal oRowsSupprTemp As DataRow)

    Try

      If oRowsSupprTemp.Item("NIDCHANTIERDOC") > 0 Then

        Dim sqlcmdSupprLigne As New SqlCommand("api_sp_SuppressionChantierDoc", oSqlConn.CnxSQLOpen)
        sqlcmdSupprLigne.CommandType = CommandType.StoredProcedure
        sqlcmdSupprLigne.Parameters.Add("@P_NIDCHANTIERDOC", SqlDbType.Int)
        sqlcmdSupprLigne.Parameters("@P_NIDCHANTIERDOC").Value = oRowsSupprTemp.Item("NIDCHANTIERDOC")

        sqlcmdSupprLigne.ExecuteNonQuery()

        If File.Exists(gstrCheminChantierDoc + oRowsSupprTemp.Item("VFILE")) = True Then File.Delete(gstrCheminChantierDoc + oRowsSupprTemp.Item("VFILE"))

      End If

    Catch ex As Exception
      MessageBox.Show(ex.Message)
    End Try

  End Sub

  Private Sub GVFicheFou_RowClick(ByVal sender As Object, ByVal e As DevExpress.XtraGrid.Views.Grid.RowClickEventArgs) Handles GVChantierDoc.RowClick

    Try

      Dim oDataRowTmp As DataRow = GVChantierDoc.GetDataRow(e.RowHandle)

      Select Case CType(oDataRowTmp.Item("NIDCHANTIERDOC"), Integer)
        Case 0
          'PDFView.src = oDataRowTmp.Item("FICTMP").ToString
          WBApercu.Navigate(oDataRowTmp.Item("FICTMP").ToString)

        Case Else
          'PDFView.src = gstrCheminFicheFourniture + oDataRowTmp.Item("VFOUFICFILE").ToString
          WBApercu.Navigate(gstrCheminChantierDoc + oDataRowTmp.Item("VFILE").ToString)

      End Select

    Catch ex As Exception
      MessageBox.Show(ex.Message)
    End Try
  End Sub

  Private Sub ResizeAllComponents()

    GrpListe.Width = Me.Width - GrpListe.Left - 15

    GrpApercu.Width = Me.Width - GrpApercu.Left - 15
    GrpApercu.Height = Me.Height - GrpApercu.Top - 40

    'AxWebBrowser1.Width = GrpApercu.Width - (AxWebBrowser1.Location.X * 2)
    ' AxWebBrowser1.Height = GrpApercu.Height - (AxWebBrowser1.Location.Y* 1.5)

  End Sub

  Private Sub frmGestionDocChantier_SizeChanged(ByVal sender As Object, ByVal e As System.EventArgs) Handles Me.ResizeEnd, Me.SizeChanged
    ResizeAllComponents()
  End Sub

  Private Sub BtnPrint_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles BtnPrint.Click

    WBApercu.ShowPrintDialog()

  End Sub
End Class
