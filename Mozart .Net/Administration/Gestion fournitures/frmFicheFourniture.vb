Imports System.Data.SqlClient

Imports System.Runtime.InteropServices
Imports MozartLib

Public Class frmFicheFourniture

  Dim oSqlConn As New CGestionSQL
  Dim dtListeFouFiche As DataTable

  Dim nfounum As Int32
  Dim ntypedanger As Integer

  'Cette focntion de DLL est tuilisé pour libérer l'espace alloué dans la mémoire pour un document chargé dans un webbrowser : evéite le message 0x00000014
  <DllImport("ole32.dll")>
  Public Shared Sub CoFreeUnusedLibraries()
  End Sub

  Public Sub New(ByVal p_nfounum As Object, ByVal p_ntypedanger As Object) '

    ' Cet appel est requis par le concepteur.
    InitializeComponent()

    ' Ajoutez une initialisation quelconque après l'appel InitializeComponent().
    nfounum = CType(p_nfounum, Int32)
    ntypedanger = CType(p_ntypedanger, Integer)

  End Sub

  Private Sub frmFicheFourniture_FormClosed(ByVal sender As Object, ByVal e As System.Windows.Forms.FormClosedEventArgs) Handles Me.FormClosed

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

  Private Sub frmFicheFourniture_FormClosing(ByVal sender As Object, ByVal e As System.Windows.Forms.FormClosingEventArgs) Handles Me.FormClosing

    ChangesDetected()

  End Sub

  Private Function ChangesDetected() As DialogResult

    Try

      'on teste si il y eu des modifs questions non enregistrer.
      If Not dtListeFouFiche Is Nothing AndAlso Not dtListeFouFiche.GetChanges Is Nothing Then

        If dtListeFouFiche.GetChanges.Rows.Count > 0 Then

          Select Case MessageBox.Show(My.Resources.Global_Enregistrer_Modif, My.Resources.GestionFourniture_frmFicheFourniture_mozart, MessageBoxButtons.YesNoCancel, MessageBoxIcon.Exclamation)

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

  Private Sub frmFicheFourniture_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load

    Select Case ntypedanger
      Case 1
        Me.Text = String.Format(Me.Text, My.Resources.GestionFourniture_frmFicheFourniture_prod_danger)
        GrpListe.Text = String.Format(GrpListe.Text, My.Resources.GestionFourniture_frmFicheFourniture_prod_danger_min)
      Case Else
        Me.Text = String.Format(Me.Text, My.Resources.GestionFourniture_frmFicheFourniture_fich_tech)
        GrpListe.Text = String.Format(GrpListe.Text, My.Resources.GestionFourniture_frmFicheFourniture_fich_tech_min)
    End Select

    If oSqlConn.ConnexionSQL(MozartParams.NomServeur, MozartParams.NomSociete) = True Then
      LoadListeFicheFourniture()
      ResizeAllComponents()
    End If

  End Sub

  Private Sub LoadListeFicheFourniture()

    Try

      Dim sRequete As String = String.Format("api_sp_ListeFouFicheTech {0}, {1}", nfounum.ToString, ntypedanger.ToString)

      dtListeFouFiche = New DataTable
      dtListeFouFiche = ModDataGridView.LoadListWithIncrementAuto(sRequete, oSqlConn.CnxSQLOpen)
      GCFicheFou.DataSource = dtListeFouFiche

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
      OFD.Filter = "Fichiers PDF (.PDF)|*.PDF"
      OFD.ShowDialog()

      If OFD.FileName <> "" Then

        Dim oNewRow As DataRow = dtListeFouFiche.NewRow

        oNewRow.Item("NFOUFICNUM") = 0
        oNewRow.Item("NFOUNUM") = nfounum
        oNewRow.Item("VFOUFICFILE") = Path.GetFileName(OFD.FileName)
        oNewRow.Item("NFOUFICDANGER") = ntypedanger
        oNewRow.Item("DDATECREE") = Now
        oNewRow.Item("FICTMP") = OFD.FileName

        dtListeFouFiche.Rows.Add(oNewRow)

      End If

    Catch ex As Exception
      MessageBox.Show(ex.Message)
    End Try

  End Sub

  Private Sub BtnSupprimer_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles BtnSupprimer.Click

    Try

      If dtListeFouFiche.Rows.Count = 0 Then
        Return
      End If

      If GVFicheFou.GetSelectedRows(0) < 0 Then
        MessageBox.Show(My.Resources.GestionFourniture_frmFicheFourniture_select_fich, My.Resources.Global_suppression_fourniture, MessageBoxButtons.OK, MessageBoxIcon.Exclamation)
        Return
      End If

      ''mise à jour de la datatable
      If MessageBox.Show(My.Resources.Global_suppression_fourniture_message, My.Resources.Global_confirmation_suppression, MessageBoxButtons.YesNoCancel, MessageBoxIcon.Question) = DialogResult.Yes Then

        dtListeFouFiche.Select("IDTMP=" + GVFicheFou.GetDataRow(GVFicheFou.GetSelectedRows(0)).Item("IDTMP").ToString)(0).Delete()
        WBApercu.Navigate("about:blank")

      End If

    Catch ex As Exception

      MessageBox.Show(ex.Message)

    End Try

  End Sub

  Private Sub BtnSave_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles BtnSave.Click

    Try

      Dim ODtSupprLine As DataTable = dtListeFouFiche.GetChanges(DataRowState.Deleted)

      If Not ODtSupprLine Is Nothing Then

        ODtSupprLine.RejectChanges()

        'suppression des lignes supprimer dans la datable
        If ODtSupprLine.Rows.Count > 0 Then

          For Each oRowsInvSupp As DataRow In ODtSupprLine.Rows

            SupprLigneFicheFourniture(oRowsInvSupp)

          Next

        End If

      End If

      dtListeFouFiche.AcceptChanges()

      'sauvegarde des lignes inventaires
      If dtListeFouFiche.Rows.Count > 0 Then

        For Each oRowsInv As DataRow In dtListeFouFiche.Rows

          SaveLigneFicheFourniture(oRowsInv)

        Next

      End If

      'on recharge les données
      LoadListeFicheFourniture()

    Catch ex As Exception
      MessageBox.Show(ex.Message)
    End Try

  End Sub

  Private Sub SaveLigneFicheFourniture(ByVal oRowsSavTemp As DataRow)

    Try

      Dim sFileDest As String = ""

      'avant d'enregistrer on test si le fichier existe toujours
      If CType(oRowsSavTemp.Item("NFOUFICNUM"), Integer) = 0 Then

        If File.Exists(oRowsSavTemp.Item("FICTMP")) = True Then

          Dim sqlcmdCreateLigne As New SqlCommand("api_sp_CreationFicheFourniture", oSqlConn.CnxSQLOpen)
          sqlcmdCreateLigne.CommandType = CommandType.StoredProcedure
          sqlcmdCreateLigne.Parameters.Add("@P_NFOUFICNUM", SqlDbType.Int)
          sqlcmdCreateLigne.Parameters("@P_NFOUFICNUM").Value = oRowsSavTemp.Item("NFOUFICNUM")
          sqlcmdCreateLigne.Parameters.Add("@P_NFOUNUM", SqlDbType.Int)
          sqlcmdCreateLigne.Parameters("@P_NFOUNUM").Value = oRowsSavTemp.Item("NFOUNUM")
          sqlcmdCreateLigne.Parameters.Add("@P_VFOUFICFILE", SqlDbType.VarChar)
          sqlcmdCreateLigne.Parameters("@P_VFOUFICFILE").Value = oRowsSavTemp.Item("VFOUFICFILE")
          sqlcmdCreateLigne.Parameters.Add("@P_DDATECREE", SqlDbType.DateTime)
          sqlcmdCreateLigne.Parameters("@P_DDATECREE").Value = oRowsSavTemp.Item("DDATECREE")
          sqlcmdCreateLigne.Parameters.Add("@P_NFOUFICDANGER", SqlDbType.Int)
          sqlcmdCreateLigne.Parameters("@P_NFOUFICDANGER").Value = oRowsSavTemp.Item("NFOUFICDANGER")

          sFileDest = sqlcmdCreateLigne.ExecuteScalar

          File.Copy(oRowsSavTemp.Item("FICTMP").ToString, gstrCheminFicheFourniture + sFileDest)

        End If

      End If


    Catch ex As Exception
      MessageBox.Show(ex.Message)
    End Try

  End Sub

  Private Sub SupprLigneFicheFourniture(ByVal oRowsSupprTemp As DataRow)

    Try

      If oRowsSupprTemp.Item("NFOUFICNUM") > 0 Then

        Dim sqlcmdSupprLigne As New SqlCommand("api_sp_SuppressionFicheFourniture", oSqlConn.CnxSQLOpen)
        sqlcmdSupprLigne.CommandType = CommandType.StoredProcedure
        sqlcmdSupprLigne.Parameters.Add("@P_NFOUFICNUM", SqlDbType.Int)
        sqlcmdSupprLigne.Parameters("@P_NFOUFICNUM").Value = oRowsSupprTemp.Item("NFOUFICNUM")

        sqlcmdSupprLigne.ExecuteNonQuery()

        If File.Exists(gstrCheminFicheFourniture + oRowsSupprTemp.Item("VFOUFICFILE")) = True Then File.Delete(gstrCheminFicheFourniture + oRowsSupprTemp.Item("VFOUFICFILE"))

      End If

    Catch ex As Exception
      MessageBox.Show(ex.Message)
    End Try

  End Sub

  Private Sub GVFicheFou_RowClick(ByVal sender As Object, ByVal e As DevExpress.XtraGrid.Views.Grid.RowClickEventArgs) Handles GVFicheFou.RowClick

    Try

      Dim oDataRowTmp As DataRow = GVFicheFou.GetDataRow(e.RowHandle)

      Select Case CType(oDataRowTmp.Item("NFOUFICNUM"), Integer)
        Case 0
          'PDFView.src = oDataRowTmp.Item("FICTMP").ToString
          WBApercu.Navigate(oDataRowTmp.Item("FICTMP").ToString)

        Case Else
          'PDFView.src = gstrCheminFicheFourniture + oDataRowTmp.Item("VFOUFICFILE").ToString
          WBApercu.Navigate(gstrCheminFicheFourniture + oDataRowTmp.Item("VFOUFICFILE").ToString)

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

  Private Sub frmFicheFourniture_SizeChanged(ByVal sender As Object, ByVal e As System.EventArgs) Handles Me.ResizeEnd, Me.SizeChanged
    ResizeAllComponents()
  End Sub



End Class
