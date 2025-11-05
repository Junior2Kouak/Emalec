Imports System.Data.SqlClient
Imports DevExpress.XtraEditors
Imports DevExpress.XtraPrinting
Imports MozartLib

Public Class frmGestCompteAna

  Dim oGestAna As CCompteAna
  Dim sEtatActif As String

  Private Sub frmGestCompteAna_Load(sender As System.Object, e As System.EventArgs) Handles MyBase.Load

    'init
    Initboutons(Me)

    GColCTYPECTE.Caption = "Type"
    sEtatActif = "O"

    oGestAna = New CCompteAna(MozartParams.NomSociete)

    LoadData()

  End Sub

  Private Sub BtnFermer_Click(sender As System.Object, e As System.EventArgs) Handles BtnFermer.Click

    Me.Close()

  End Sub

  Private Sub BtnAjouter_Click(sender As System.Object, e As System.EventArgs) Handles BtnAjouter.Click

    Dim iPos As Int32 = GVCompteAna.FocusedRowHandle

    Dim drCompteAnaNew As DataRow = oGestAna.dtCptAna.NewRow

    ' recherche du premier compte disponible
    Dim sSQL As String = $"SELECT MIN(NCANNUM) + 1 FROM TREF_CTEANA A WHERE VSOCIETE = '{MozartParams.NomSociete}' 
                AND (NCANNUM + 1) NOT IN (SELECT B.NCANNUM FROM TREF_CTEANA B WHERE VSOCIETE = '{MozartParams.NomSociete}')"

    Dim sqlVerif As New SqlCommand(sSQL, MozartDatabase.cnxMozart)
    sqlVerif.CommandType = CommandType.Text
    Dim iNbCompte As Int32 = sqlVerif.ExecuteScalar
    sqlVerif.Dispose()

    drCompteAnaNew.Item("NCANNUM") = iNbCompte

    'If oGestAna.dtCptAna.Select("NCANNUM < 890", "NCANNUM DESC")(0).Item("NCANNUM").ToString <> "" Then
    'drCompteAnaNew.Item("NCANNUM") = oGestAna.dtCptAna.Select("NCANNUM < 890", "NCANNUM DESC")(0).Item("NCANNUM") + 1
    'Else
    'drCompteAnaNew.Item("NCANNUM") = 1
    'End If

    Dim oFrmDetailCompteAna As New frmGestCompteAnaCreate(drCompteAnaNew, oGestAna, 0)
    oFrmDetailCompteAna.ShowDialog()

    LoadData()

    'selection auto de la ligne créée
    GVCompteAna.FocusedRowHandle = iPos


  End Sub

  Private Sub BtnModifier_Click(sender As System.Object, e As System.EventArgs) Handles BtnModifier.Click


    If GVCompteAna.RowCount > 0 Then
      Dim drComtpeAnaSelect As DataRow = GVCompteAna.GetFocusedDataRow
      Dim iPos As Int32 = GVCompteAna.FocusedRowHandle

      If iPos < 0 Then
        MessageBox.Show("Il faut sélectionner une ligne", My.Resources.Global_Erreur, MessageBoxButtons.OK, MessageBoxIcon.Exclamation)
        Return
      End If
      Dim oFrmDetailCompteAna As New frmGestCompteAnaCreate(drComtpeAnaSelect, oGestAna, 1)
      oFrmDetailCompteAna.ShowDialog()

      LoadData()

      GVCompteAna.FocusedRowHandle = iPos
    End If
  End Sub

  Private Sub LoadData()

    If Not oGestAna Is Nothing Then

      oGestAna.LoadComptesAna(sEtatActif)

      oGestAna.dtCptAna.Columns("NRFAPOURC").ReadOnly = False

      GCCompteAna.DataSource = oGestAna.dtCptAna
      GestionAffichageBouton()

    End If

  End Sub

  Private Sub BtnArchiver_Click(sender As System.Object, e As System.EventArgs) Handles BtnArchiver.Click

    If GVCompteAna.RowCount > 0 Then

      Dim iPos As Int32 = GVCompteAna.FocusedRowHandle

      Dim drComtpeAnaSelect As DataRow = GVCompteAna.GetFocusedDataRow

      If MessageBox.Show(My.Resources.Global_archiver_compte_analytique, My.Resources.Global_archiver_compte, MessageBoxButtons.YesNoCancel, MessageBoxIcon.Question) = DialogResult.Yes Then

        oGestAna.ModifEtatCompteAna(drComtpeAnaSelect.Item("NCANNUM"), "N")

      End If
      LoadData()
      GVCompteAna.FocusedRowHandle = iPos

    End If

    'retirer les com le jour de mise en prod
    'If GVCompteAna.RowCount > 0 Then

    '    Dim iPos As Int32 = GVCompteAna.FocusedRowHandle

    '    Dim drComtpeAnaSelect As DataRow = GVCompteAna.GetFocusedDataRow

    '    'on affiche les clients 
    '    Dim ofrmListCliByCompte As New FrmListeClientByCompte(drComtpeAnaSelect.Item("NCANNUM"), drComtpeAnaSelect.Item("VCANLIB"))
    '    ofrmListCliByCompte.ShowDialog()

    '    If ofrmListCliByCompte.bCancel = False Then oGestAna.ModifEtatCompteAna(drComtpeAnaSelect.Item("NCANNUM"), "N") : LoadData()

    '    GVCompteAna.FocusedRowHandle = iPos

    'End If

  End Sub

  Private Sub ChkArchives_CheckedChanged(sender As System.Object, e As System.EventArgs) Handles ChkArchives.CheckedChanged

    If sEtatActif = "O" Then
      sEtatActif = "N"
      LblTitre.Text = My.Resources.Global_Gestion_compte_archivés
    ElseIf sEtatActif = "N" Then
      sEtatActif = "O"
      LblTitre.Text = My.Resources.Global_Gestion_compte_analytiques
    End If

    LoadData()

  End Sub

  Private Sub GestionAffichageBouton()

    Select Case sEtatActif

      Case "O"
        BtnAjouter.Visible = True
        BtnModifier.Visible = True
        BtnArchiver.Visible = True
        BtnRestaurer.Visible = False
      Case "N"
        BtnAjouter.Visible = False
        BtnModifier.Visible = False
        BtnArchiver.Visible = False
        BtnRestaurer.Visible = True
    End Select

  End Sub

  Private Sub BtnRestaurer_Click(sender As System.Object, e As System.EventArgs) Handles BtnRestaurer.Click

    If GVCompteAna.RowCount > 0 Then

      Dim iPos As Int32 = GVCompteAna.FocusedRowHandle

      If MessageBox.Show(My.Resources.Global_Restaurer_Compte_analytique, My.Resources.Global_Restaurer_Compte, MessageBoxButtons.YesNoCancel, MessageBoxIcon.Question) = DialogResult.Yes Then

        Dim drComtpeAnaSelect As DataRow = GVCompteAna.GetFocusedDataRow
        oGestAna.ModifEtatCompteAna(drComtpeAnaSelect.Item("NCANNUM"), "O")

      End If

      GVCompteAna.FocusedRowHandle = iPos

      LoadData()

    End If

  End Sub

  Private Sub BtnAffectByPers_Click(sender As System.Object, e As System.EventArgs) Handles BtnAffectByPers.Click

    If GVCompteAna.RowCount > 0 Then
      Dim iPos As Int32 = GVCompteAna.FocusedRowHandle

      Dim drComtpeAnaSelect As DataRow = GVCompteAna.GetFocusedDataRow

      Dim oFrmGestCompteAnaAffectByPer As New frmGestCompteAnaAffectation(oGestAna, drComtpeAnaSelect.Item("NCANNUM"), drComtpeAnaSelect.Item("VCANLIB").ToString)
      oFrmGestCompteAnaAffectByPer.ShowDialog()

      GVCompteAna.FocusedRowHandle = iPos

    End If

  End Sub

  Private Sub BtnPrint_Click(sender As System.Object, e As System.EventArgs) Handles BtnPrint.Click

    If GVCompteAna.RowCount > 300 Then
      If MessageBox.Show(My.Resources.admin_frmGestCompteAna_Attention, My.Resources.Global_ConfirmationI, MessageBoxButtons.YesNoCancel, MessageBoxIcon.Exclamation) <> Windows.Forms.DialogResult.Yes Then Exit Sub
    End If

    Dim pcl As PrintableComponentLink = New PrintableComponentLink(New PrintingSystem())
    pcl.Component = GCCompteAna
    pcl.CreateDocument()
    pcl.PrintDlg()

  End Sub

  Private Sub GVCompteAna_CustomDrawFooter(sender As Object, e As DevExpress.XtraGrid.Views.Base.RowObjectCustomDrawEventArgs) Handles GVCompteAna.CustomDrawFooter
    Dim oPos As Rectangle = e.Bounds
    Dim oFormat As New StringFormat
    oPos.Location = New Point(oPos.Left + 1, oPos.Top + 1)
    oPos.Size = New Size(oPos.Width - 2, oPos.Height - 2)
    oFormat.Alignment = StringAlignment.Center
    e.Appearance.DrawString(e.Cache, String.Format("Sélection : {0} / {1}", GVCompteAna.RowCount, GCCompteAna.DataSource.Rows.Count), oPos, oFormat)
    e.Handled = True
  End Sub

  Private Sub btnExtraire_Click(sender As System.Object, e As System.EventArgs) Handles btnExtraire.Click
    Dim fileName As String = Environment.GetFolderPath(Environment.SpecialFolder.UserProfile) & "\ListeComptesAnalytiques_" & Today.Year & Today.Month & Today.Day & "_" & TimeOfDay.Hour & TimeOfDay.Minute & ".xls"
    GCCompteAna.ExportToXls(fileName)
    System.Diagnostics.Process.Start(Environment.GetFolderPath(Environment.SpecialFolder.UserProfile))
  End Sub

  Private Sub RepositoryItemTextEdit1_EditValueChanged(sender As Object, e As EventArgs) Handles RepositoryItemTextEdit1.EditValueChanged

    If GVCompteAna.FocusedRowHandle < 0 Then Return

    Dim drSelect As DataRow = GVCompteAna.GetDataRow(GVCompteAna.FocusedRowHandle)

    If drSelect Is Nothing Then Return

    Dim textEditor As TextEdit = CType(sender, TextEdit)

    If textEditor Is Nothing Then Return

    If textEditor.EditValue > 1 Then
      MessageBox.Show("Le taux RFA ne peut pas excéder 100 %", My.Resources.Global_Erreur, MessageBoxButtons.OK, MessageBoxIcon.Exclamation)
      textEditor.EditValue = 1
      Return
    End If

    Dim sqlcmdupdate As New SqlCommand("[api_sp_CompteAnalytiqueUpdateRFA]", MozartDatabase.cnxMozart)
    sqlcmdupdate.CommandType = CommandType.StoredProcedure
    sqlcmdupdate.Parameters.Add("@P_NCANNUM", SqlDbType.Int).Value = drSelect.Item("NCANNUM")
    sqlcmdupdate.Parameters.Add("@P_VSOCIETE", SqlDbType.VarChar).Value = drSelect.Item("VSOCIETE")
    sqlcmdupdate.Parameters.Add("@P_NRFAPOURC", SqlDbType.Decimal).Value = If(textEditor.EditValue.ToString = "", DBNull.Value, textEditor.EditValue)

    sqlcmdupdate.ExecuteNonQuery()


  End Sub
End Class
