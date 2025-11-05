Imports System.Data.SqlClient
Imports MozartLib

Public Class frmListeTelephones
  Dim form_charge As Boolean

    Dim bArchives As Boolean

    Private Sub frmListeTelephones_Load(ByVal sender As Object, ByVal e As EventArgs) Handles MyBase.Load


        ModuleMain.Initboutons(Me)

        bArchives = False
        GroupBoxTI.Visible = False
        initSociete()

    chargeListe()
    form_charge = True

  End Sub

  Private Sub initSociete()
    'initialisation de le combobox "Société"
    Dim i As Integer = 0

    If MozartDatabase.cnxMozart.State = ConnectionState.Open Then

      Dim CmdSql As New SqlCommand(String.Format("SELECT DISTINCT VSOCIETE FROM TDROIT D inner join TSOCIETE S ON D.VSOCIETE=S.VSOCIETENOM WHERE VSOCIETEACTIF='O' AND NPERNUM = {0} AND NMENUNUM = {1} AND CDROITVAL = 'O' ORDER BY VSOCIETE", MozartParams.UID, cboSociete.Tag), MozartDatabase.cnxMozart)
      Dim dr As SqlDataReader = CmdSql.ExecuteReader
      While dr.Read() 'While données présentes, stocker les éléments en combobox
        cboSociete.Items.Add(dr("VSOCIETE"))
        i = i + 1
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
      dr = Nothing

    End If

  End Sub

  Private Sub chargeListe()

    Try

      Cursor = Cursors.WaitCursor
      'on ouvre la connexion
      If MozartDatabase.cnxMozart.State = ConnectionState.Open Then

        Dim CmdSql As New SqlCommand("api_sp_ListeTelephones", MozartDatabase.cnxMozart) With {.CommandType = CommandType.StoredProcedure}
        CmdSql.Parameters.Add("@VSOCIETE", SqlDbType.VarChar).Value = cboSociete.SelectedItem
        CmdSql.Parameters.Add("@numMenu", SqlDbType.Int).Value = cboSociete.Tag
        CmdSql.Parameters.Add("@CTELACTIF", SqlDbType.Char).Value = If(bArchives, "N", "O")

        Dim sqlAdpat As SqlDataAdapter = New SqlDataAdapter(CmdSql)
        Dim dtStat As New DataSet
        sqlAdpat.Fill(dtStat)

        GridControl1.DataSource = dtStat.Tables(0)

        CmdSql.Dispose()

        GridControl1.Focus()

      End If

    Catch ex As Exception
      MessageBox.Show(My.Resources.Admin_frmListeTelephone_SubClick + ex.Message, My.Resources.Global_Erreur)
    Finally
      Cursor = Cursors.Default
    End Try

  End Sub

  Private Sub BtnFermer_Click(ByVal sender As Object, ByVal e As EventArgs) Handles BtnFermer.Click
    Close()
  End Sub

  Private Sub ButtonArchiver_Click(ByVal sender As Object, ByVal e As EventArgs) Handles ButtonArchiver.Click

    Try
      ' On récupère le n° unique NTELNUM sélectionné dans la liste
      Dim ligne_selectionnee As Integer() = GridView1.GetSelectedRows()
      Dim ntelnum As String = GridView1.GetRowCellValue(ligne_selectionnee.ElementAt(0), "NTELNUM").ToString

      ' FGA le 04/04/23  (encore des lignes oranges perdues car archivées dans Mozart (Equipage))
      If ExecuteScalarInt("select count(*) from tper where npernum = dbo.getuserid() and nsernum = 14") = 0 Then
        MsgBox("Il ne faut pas archiver les lignes de téléphone dans Mozart sans avoir compris que l'abonnement continue à être actif chez l'opérateur", vbExclamation)
        Exit Sub
      End If

            If (bArchives) Then

                If MsgBox("Voulez-vous restaurer cette ligne ?", My.Resources.Admin_frmListeTelephone_archiverTel, vbYesNo + vbQuestion) = vbYes Then
          Dim CmdSql As New SqlCommand("update TTEL set CTELACTIF = 'O' where nTELnum = " & ntelnum, MozartDatabase.cnxMozart)
          CmdSql.ExecuteNonQuery()
                    CmdSql.Dispose()
                End If

            Else
                If MsgBox(My.Resources.Admin_frmListeTelephone_archiverTel, vbYesNo + vbQuestion) = vbYes Then
          Dim CmdSql As New SqlCommand("update TTEL set CTELACTIF = 'N' where nTELnum = " & ntelnum, MozartDatabase.cnxMozart)
          CmdSql.ExecuteNonQuery()
                    CmdSql.Dispose()
                End If
            End If


            chargeListe()

    Catch ex As Exception
      MessageBox.Show(My.Resources.Global_aucune_ligne, My.Resources.Global_Information)
    End Try

  End Sub

  Private Sub ButtonExporter_Click(ByVal sender As Object, ByVal e As EventArgs) Handles ButtonExporter.Click
    Dim fileName As String = String.Format("{0}\LstTelephones_{1}{2}{3}_{4}{5}.xls", Environment.GetFolderPath(Environment.SpecialFolder.UserProfile), Today.Year, Today.Month, Today.Day, TimeOfDay.Hour, TimeOfDay.Minute)
    GridControl1.ExportToXls(fileName)
    System.Diagnostics.Process.Start(Environment.GetFolderPath(Environment.SpecialFolder.UserProfile))

  End Sub

  Private Sub ButtonDetails_Click(ByVal sender As Object, ByVal e As EventArgs) Handles ButtonDetails.Click

    Try
      ' On récupère le n° unique NTELNUM sélectionné dans la liste
      Dim ligne_selectionnee As Integer() = GridView1.GetSelectedRows()
      Dim ntelnum As String = GridView1.GetRowCellValue(ligne_selectionnee.ElementAt(0), "NTELNUM").ToString
      Dim vsociete As String = GridView1.GetRowCellValue(ligne_selectionnee.ElementAt(0), "VSOCIETE").ToString
      Dim Mat As String = GridView1.GetRowCellValue(ligne_selectionnee.ElementAt(0), "VTELPROFIL").ToString

      ' FGA le 24/05/23 pas de modification de la liste des sim de geoloc (uniquement moi)
      If Mat = "Geolocalisation" And MozartParams.UID <> 30 Then
        MsgBox("Les Sim de géolocalisation ne sont gérées que par le Service Informatique", vbExclamation)
        Exit Sub
      End If


      Dim oForm As New frmDetailsTelephone
      oForm.LabelNTELNUM.Text = ntelnum
      oForm.LabelSociete.Text = vsociete
      oForm.ShowDialog()

      'Nettoyage
      oForm.Dispose()

      chargeListe()

    Catch ex As Exception
      MessageBox.Show(My.Resources.Global_aucune_ligne, My.Resources.Global_Information)
    End Try

  End Sub

  Private Sub BtnAjouter_Click(ByVal sender As Object, ByVal e As EventArgs) Handles BtnAjouter.Click

    Dim oForm As New frmDetailsTelephone
    oForm.LabelSociete.Text = cboSociete.SelectedItem
    oForm.LabelSociete.Visible = False
    oForm.ShowDialog()

    'Nettoyage
    oForm.Dispose()

    chargeListe()

  End Sub

  Private Sub cboSociete_SelectedIndexChanged(ByVal sender As Object, ByVal e As EventArgs) Handles cboSociete.SelectedIndexChanged

    If form_charge = True Then
      chargeListe()

      If cboSociete.SelectedItem = "GROUPE" Then
        BtnAjouter.Enabled = False   ' On interdit l'ajout sur le groupe
      Else
        BtnAjouter.Enabled = True
      End If
    End If

  End Sub

  Private Sub GridControl1_DoubleClick(ByVal sender As Object, ByVal e As EventArgs) Handles GridControl1.DoubleClick
    ButtonDetails_Click(sender, e)
  End Sub

  Private Sub GridView1_EndSorting(ByVal sender As Object, ByVal e As EventArgs) Handles GridView1.EndSorting
    GridView1.MoveFirst()
  End Sub

  Private Sub Button1_Click(ByVal sender As Object, ByVal e As EventArgs) Handles Button1.Click
    GroupBoxTI.Visible = True
  End Sub

  Private Sub Button2_Click(ByVal sender As Object, ByVal e As EventArgs) Handles Button2.Click
    GroupBoxTI.Visible = False
  End Sub

  Private Sub Label36_Click(sender As System.Object, e As System.EventArgs) Handles Label36.Click

  End Sub

    Private Sub BtnArchives_Click(sender As Object, e As EventArgs) Handles BtnArchives.Click
        bArchives = Not bArchives

        If (bArchives) Then

            BtnAjouter.Visible = False
            ButtonArchiver.Text = "Restaurer"
            BtnArchives.Text = "Voir actifs"
            LabelTitre.Text = "Liste des téléphones archivés"

        Else

            BtnAjouter.Visible = True
            ButtonArchiver.Text = "Archiver"
            BtnArchives.Text = "Voir archives"
            LabelTitre.Text = "Liste des téléphones actifs"

        End If
        Me.Text = LabelTitre.Text

        chargeListe()
    End Sub
End Class