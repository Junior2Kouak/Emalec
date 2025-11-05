Imports System.Data.SqlClient
Imports MozartLib

Public Class frmListeFormation
  Dim oORG As CORGANISME
  Dim oFORMATION As CFORMATION
  Dim strEmploye As String

  Dim bActif As Boolean

  Private dragVisibleIndex As Integer = -1
  Private dragAbsIndex As Integer = -1

  'constructeur de la classe avec 1 paramtres
  Public Sub New(ByVal p_Employe As Object)
    InitializeComponent()
    strEmploye = Convert.ToString(p_Employe)
  End Sub

  Private Sub frmListeFormation_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load

    Try

      bActif = True

      oORG = New CORGANISME
      oFORMATION = New CFORMATION()

      GCFORMATION.DataSource = oFORMATION.ListeFormation

      Label1.Text = Me.Text

      ' si on vient du détail d'une personne, on filtre la liste sur cette personne
      If strEmploye <> "T" Then GVFORMATION.Columns(2).FilterInfo = New DevExpress.XtraGrid.Columns.ColumnFilterInfo("[VPERNOM] = '" & strEmploye & "'")

    Catch ex As Exception

      MessageBox.Show(My.Resources.GestionDesFormation_frmGestHabilitation_subLoad + ex.Message, My.Resources.Global_Erreur)

    End Try

  End Sub

  Private Sub BtnQuit_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles BtnQuit.Click

    Me.Close()

  End Sub

  Private Sub BtnAddLine_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles BtnAddLine.Click
    Try

      Dim oFrmGestForm As New frmGestFormation(0)
      oFrmGestForm.ShowDialog()

      ' rafraichir la liste
      GCFORMATION.DataSource = oFORMATION.ListeFormation()

    Catch ex As Exception
      MessageBox.Show(ex.Message)
    End Try
  End Sub


  Private Sub BtnMod_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles BtnMod.Click
    Try

      Dim oFrmGestForm As New frmGestFormation(GVFORMATION.GetDataRow(GVFORMATION.GetSelectedRows(0)).Item("NFORMNUM"))
      oFrmGestForm.ShowDialog()

      ' rafraichir la liste
      GCFORMATION.DataSource = oFORMATION.ListeFormation()

    Catch ex As Exception
      MessageBox.Show(ex.Message)
    End Try
  End Sub

  Private Sub BtnSupprLine_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles BtnSupprLine.Click

    Try

      If GVFORMATION.SelectedRowsCount > 0 Then
        'si handle row est inférieur à 0 alors elle ne fait pas partir de la datatable
        If GVFORMATION.GetSelectedRows(0) < 0 Then
          MessageBox.Show(My.Resources.Global_selectionner_une_ligne, My.Resources.Global_suppression_formation, MessageBoxButtons.OK, MessageBoxIcon.Exclamation)
          Return
        End If
      Else
        MessageBox.Show(My.Resources.Global_selectionner_une_ligne, My.Resources.Global_suppression_formation, MessageBoxButtons.OK, MessageBoxIcon.Exclamation)
        Return
      End If

      'mise à jour de la datatable
      If MessageBox.Show(My.Resources.Global_supprimer_formation_message, My.Resources.Global_confirmation_suppression, MessageBoxButtons.YesNoCancel, MessageBoxIcon.Question) = vbYes Then

        'suppression du fichier
        Dim sFile As String = GVFORMATION.GetDataRow(GVFORMATION.GetSelectedRows(0)).Item("VFICHIER")
        Dim sPath As String = ModuleData.RechercheParam("REP_ATTEST_FORMATION", MozartParams.NomSociete)
        If sFile <> "" And sPath <> "" AndAlso File.Exists(sPath & sFile) Then File.Delete(sPath & sFile)

        Dim sqlcmdSupprLigne As New SqlCommand("DELETE FROM TFORMATION WHERE NFORMNUM=" + GVFORMATION.GetDataRow(GVFORMATION.GetSelectedRows(0)).Item("NFORMNUM").ToString, MozartDatabase.cnxMozart)
        sqlcmdSupprLigne.CommandType = CommandType.Text
        sqlcmdSupprLigne.ExecuteNonQuery()
        ' rafraichir la liste
        GCFORMATION.DataSource = oFORMATION.ListeFormation
      End If

    Catch ex As Exception
      MessageBox.Show(ex.Message)
    End Try

  End Sub

  Private Sub BtnGestForm_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles BtnGestForm.Click

    Try

      Dim oFrmForm As New frmTypeFormation
      oFrmForm.ShowDialog()

    Catch ex As Exception
      MessageBox.Show(ex.Message)
    End Try

  End Sub

  Private Sub BtnGestOrg_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles BtnGestOrg.Click

    Try

      Dim oFrmOrganisme As New frmOrganisme
      oFrmOrganisme.ShowDialog()

    Catch ex As Exception
      MessageBox.Show(ex.Message)
    End Try

  End Sub

  Private Sub BtnImp_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles BtnImp.Click
    GCFORMATION.Print()
  End Sub

  Private Sub BtnExcel_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles BtnExcel.Click

    Dim SDF = New System.Windows.Forms.SaveFileDialog()
    SDF.AddExtension = True
    SDF.Filter = "Fichier EXCEL (*.XSL)|.XLS"
    SDF.ShowDialog()

    If SDF.FileName <> "" Then

      GCFORMATION.ExportToXls(SDF.FileName)

    End If

  End Sub

  Private Sub cmdHabilitation_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles cmdHabilitation.Click

    Try
      If GVFORMATION.GetSelectedRows(0) < 0 Then
        Dim oFrmHabilitation As New frmGestHabilitation(0)
        oFrmHabilitation.ShowDialog()
      Else
        Dim oFrmHabilitation As New frmGestHabilitation(GVFORMATION.GetDataRow(GVFORMATION.GetSelectedRows(0)).Item("NPERNUM").ToString)
        oFrmHabilitation.ShowDialog()
      End If

    Catch ex As Exception
      MessageBox.Show(ex.Message)
    End Try
  End Sub

  Private Sub BtnPrintAttest_Click(sender As Object, e As EventArgs) Handles BtnPrintAttest.Click

    If GVFORMATION.FocusedRowHandle > -1 Then

      Dim sFile As String = GVFORMATION.GetDataRow(GVFORMATION.GetSelectedRows(0)).Item("VFICHIER")
      Dim sPath As String = ModuleData.RechercheParam("REP_ATTEST_FORMATION", MozartParams.NomSociete)

      If sFile <> "" AndAlso File.Exists(sPath & sFile) Then
        Dim oFileVisu As New frmVisuDoc(sPath & sFile)
        oFileVisu.ShowDialog()
      End If

    End If

  End Sub

  Private Sub BtnArchives_Click(sender As Object, e As EventArgs) Handles BtnArchives.Click

    If bActif = True Then

      bActif = False
      BtnArchives.Text = "Gestion des actifs"

      BtnAddLine.Visible = False
      BtnSupprLine.Visible = False
      cmdHabilitation.Visible = False
      BtnGestForm.Visible = False
      BtnGestOrg.Visible = False

      GCFORMATION.DataSource = oFORMATION.ListeFormation("N")


    Else

      bActif = True
      BtnArchives.Text = "Gestion des archives"
      BtnAddLine.Visible = True
      BtnSupprLine.Visible = True
      cmdHabilitation.Visible = True
      BtnGestForm.Visible = True
      BtnGestOrg.Visible = True
      GCFORMATION.DataSource = oFORMATION.ListeFormation

    End If

  End Sub

  Private Sub btn_Click(sender As Object, e As EventArgs) Handles btn.Click

    ' renvoi vers le formulaire de modification de la carte d'habilitation
    Dim oFrmListe As New frmListeCartesHabilitation()
    oFrmListe.ShowDialog()
  End Sub
End Class