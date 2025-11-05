Imports System.Data.SqlClient
Imports MozartLib

Public Class frmListeInformatique

  Private Const TITRE As String = "Liste du matériel informatique"

  Dim form_charge As Boolean
  Dim bModeArchives As Boolean

  Private Sub frmListeInformatique_Load(ByVal sender As Object, ByVal e As EventArgs) Handles MyBase.Load
    bModeArchives = False

    initSociete()

    chargeListe()

    form_charge = True
  End Sub

  Private Sub chargeListe()
    Try
      Cursor = Cursors.WaitCursor
      'on ouvre la connexion
      If MozartDatabase.cnxMozart.State = ConnectionState.Open Then

        Dim CmdSql As New SqlCommand("api_sp_listeOrdinateurs2", MozartDatabase.cnxMozart) With {.CommandType = CommandType.StoredProcedure}
        CmdSql.Parameters.Add("@VSOCIETE", SqlDbType.VarChar).Value = cboSociete.SelectedItem
        CmdSql.Parameters.Add("@numMenu", SqlDbType.Int).Value = cboSociete.Tag

        Dim sqlAdpat As New SqlDataAdapter(CmdSql)
        Dim dtStat As New DataSet
        sqlAdpat.Fill(dtStat)

        GCListeOrdi.DataSource = dtStat.Tables(0)

        CmdSql.Dispose()

        GCListeOrdi.Focus()

      End If

    Catch ex As Exception
      MessageBox.Show(My.Resources.Admin_frmListeInformatique_SubLoad + ex.Message, My.Resources.Global_Erreur)
    Finally
      Cursor = Cursors.Default
    End Try
  End Sub

  Private Sub chargeListeArchives()
    Try
      Cursor = Cursors.WaitCursor
      'on ouvre la connexion
      If MozartDatabase.cnxMozart.State = ConnectionState.Open Then

        Dim CmdSql As New SqlCommand("select * from api_v_listeOrdinateurs2 WHERE CORDIACTIF = 'N'", MozartDatabase.cnxMozart)
        Dim sqlAdpat As SqlDataAdapter = New SqlDataAdapter(CmdSql)
        Dim dtStat As New DataSet
        sqlAdpat.Fill(dtStat)

        GCListeOrdi.DataSource = dtStat.Tables(0)

        CmdSql.Dispose()

        GCListeOrdi.Focus()

      End If

    Catch ex As Exception
      MessageBox.Show(My.Resources.Admin_frmListeInformatique_SubArchive + ex.Message, My.Resources.Global_Erreur)
    Finally
      Cursor = Cursors.Default
    End Try
  End Sub

  Private Sub initSociete()
    'initialisation de la combobox "Société"
    Dim i As Integer = 0

    If MozartDatabase.cnxMozart.State = ConnectionState.Open Then
      Dim CmdSql As New SqlCommand(String.Format("SELECT DISTINCT VSOCIETE FROM TDROIT INNER JOIN TSOCIETE ON TSOCIETE.VSOCIETENOM = TDROIT.VSOCIETE 
							                        WHERE CDROITVAL = 'O' AND VSOCIETEACTIF='O' AND NPERNUM = {0} AND NMENUNUM = {1} AND CDROITVAL = 'O' 
                                      ORDER BY VSOCIETE", MozartParams.UID, cboSociete.Tag), MozartDatabase.cnxMozart)
      Dim dr As SqlDataReader = CmdSql.ExecuteReader
      While dr.Read() 'While données présentes, stocker les éléments en combobox
        cboSociete.Items.Add(dr("VSOCIETE"))
        i += 1
      End While

      If i > 1 Then
        ' Plusieurs société : on peut gérer le "groupe"
        cboSociete.Items.Add("GROUPE")
        cboSociete.SelectedItem = MozartParams.NomSociete
        LabelSte.Visible = True
        cboSociete.Visible = True
      Else
        cboSociete.SelectedIndex = 0
      End If

      dr.Close()
      CmdSql.Dispose()
    End If
  End Sub

  Private Sub ButtonImprimer_Click(ByVal sender As Object, ByVal e As EventArgs) Handles ButtonImprimer.Click
    Dim fileName As String = String.Format("{0}\LstInformatique_{1}{2}{3}_{4}{5}.xls", Environment.GetFolderPath(Environment.SpecialFolder.UserProfile), Today.Year, Today.Month, Today.Day, TimeOfDay.Hour, TimeOfDay.Minute)
    GCListeOrdi.ExportToXls(fileName)
    Process.Start(Environment.GetFolderPath(Environment.SpecialFolder.UserProfile))
  End Sub

  Private Sub ButtonLstArchives_Click(ByVal sender As Object, ByVal e As EventArgs) Handles ButtonLstArchives.Click
    Cursor = Cursors.WaitCursor

    If bModeArchives Then
      ' Passage à la liste des actifs
      LabelTitre.Text = TITRE
      ButtonLstArchives.Text = "Liste archives"

      chargeListe()
    Else
      ' Passage à la liste des archives
      LabelTitre.Text = TITRE & My.Resources.Global_archivé
      ButtonLstArchives.Text = "Liste matériels actifs"

      chargeListeArchives()
    End If

    bModeArchives = Not bModeArchives

    BtnAjouter.Visible = Not bModeArchives
    ButtonArchiver.Visible = Not bModeArchives
    LabelSte.Visible = Not bModeArchives
    cboSociete.Visible = Not bModeArchives
    ButtonRestaurer.Visible = bModeArchives

    Cursor = Cursors.Default
  End Sub

  Private Sub ButtonRestaurer_Click(ByVal sender As Object, ByVal e As EventArgs) Handles ButtonRestaurer.Click
    Try
      ' On récupère le n° unique NORDINUM sélectionné dans la liste
      Dim ligne_selectionnee As Integer() = GVListeOrdi.GetSelectedRows()
      Dim nordinum As String = GVListeOrdi.GetRowCellValue(ligne_selectionnee.ElementAt(0), "NORDINUM").ToString

      If MsgBox(My.Resources.Admin_frmListeInformatique_Restaurer_Materiel, vbYesNo + vbQuestion) = vbYes Then
        Dim CmdSql As New SqlCommand("update TORDI set CORDIACTIF  = 'O' where NORDINUM = " & nordinum, MozartDatabase.cnxMozart)
        CmdSql.ExecuteNonQuery()
        CmdSql.Dispose()
      End If

      chargeListeArchives()

    Catch ex As Exception
      MessageBox.Show("Aucune ligne sélectionnée", "Information")
    End Try
  End Sub

  Private Sub ButtonDetails_Click(ByVal sender As Object, ByVal e As EventArgs) Handles ButtonDetails.Click, GCListeOrdi.DoubleClick
    Try
      ' On récupère le n° unique NORDINUM sélectionné dans la liste
      Dim ligne_selectionnee As Integer() = GVListeOrdi.GetSelectedRows()
      Dim nordinum As String = GVListeOrdi.GetRowCellValue(ligne_selectionnee.ElementAt(0), "NORDINUM").ToString
      Dim vsociete As String = GVListeOrdi.GetRowCellValue(ligne_selectionnee.ElementAt(0), "VSOCIETE").ToString

      Dim oForm As New frmDetailsInformatique
      oForm.LabelNORDINUM.Text = nordinum
      If bModeArchives Then
        oForm.LabelTitre.Text += My.Resources.Global_archivé  'Ca ca marche pas mais bon...
        oForm.BtnEnreg.Visible = False
        oForm.BtnAjout.Visible = False
        oForm.BtnSuppr.Visible = False
        oForm.BtnModifier.Visible = False
      End If
      oForm.LabelSociete.Text = vsociete
      oForm.ShowDialog()

      If Not bModeArchives Then
        chargeListe()
      Else
        chargeListeArchives()
      End If

    Catch ex As Exception
      MessageBox.Show(My.Resources.Global_aucune_ligne, My.Resources.Global_Information)
    End Try
  End Sub

  Private Sub BtnAjouter_Click(ByVal sender As Object, ByVal e As EventArgs) Handles BtnAjouter.Click
    Dim oForm As New frmDetailsInformatique
    oForm.LabelSociete.Text = cboSociete.SelectedItem
    oForm.LabelSociete.Visible = False
    oForm.GroupBoxDetailsUC.Visible = False
    oForm.ShowDialog()

    chargeListe()
  End Sub

  Private Sub cboSociete_SelectedIndexChanged(ByVal sender As Object, ByVal e As EventArgs) Handles cboSociete.SelectedIndexChanged
    If Not form_charge Then
      Exit Sub
    End If

    If Not bModeArchives Then
      chargeListe()
    Else
      chargeListeArchives()
    End If

    If cboSociete.SelectedItem = "GROUPE" Then
      BtnAjouter.Enabled = False   ' On interdit l'ajout sur le groupe
    Else
      BtnAjouter.Enabled = True
    End If
  End Sub

  Private Sub ButtonArchiver_Click(ByVal sender As Object, ByVal e As EventArgs) Handles ButtonArchiver.Click
    Try
      ' On récupère le n° unique NORDINUM sélectionné dans la liste
      Dim ligne_selectionnee As Integer() = GVListeOrdi.GetSelectedRows()
      Dim nordinum As String = GVListeOrdi.GetRowCellValue(ligne_selectionnee.ElementAt(0), "NORDINUM").ToString

      If MsgBox("Voulez-vous vraiment archiver ce matériel ?", vbYesNo + vbQuestion) = vbYes Then
        Dim CmdSql As New SqlCommand("update TORDI set CORDIACTIF  = 'N' where NORDINUM = " & nordinum, MozartDatabase.cnxMozart)
        CmdSql.ExecuteNonQuery()
      End If

      chargeListe()

    Catch ex As Exception
      MessageBox.Show(My.Resources.Global_aucune_ligne, My.Resources.Global_Information)
    End Try
  End Sub

  Private Sub BtnLicences_Click(ByVal sender As Object, ByVal e As EventArgs) Handles BtnLicences.Click
    frmListeLicences.ShowDialog()
  End Sub

  Private Sub GridView1_EndSorting(ByVal sender As Object, ByVal e As EventArgs) Handles GVListeOrdi.EndSorting
    GVListeOrdi.MoveFirst()
  End Sub

  Private Sub BtnInfoTablet_Click(sender As Object, e As EventArgs) Handles BtnInfoTablet.Click
    frmListeInfoTablet.ShowDialog()
  End Sub
End Class