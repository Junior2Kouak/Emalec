Imports System.Data.SqlClient
Imports DevExpress.XtraPrinting
Imports MozartLib

Public Class frmListeChiffrages

  Dim drMain As New SqlDataAdapter
  Dim drTemp As SqlDataReader
  Dim ds As New DataSet
  Dim cmd As New SqlCommand("", MozartDatabase.cnxMozart)
  Dim cmdGrid As New SqlCommand("", MozartDatabase.cnxMozart)

  Dim dtChiffrages As DataTable
  Dim iPos As Integer
  Dim iNIDCHIF As Int32

  Private Sub frmListeChiffrages_Load(sender As System.Object, e As System.EventArgs) Handles MyBase.Load

    'Init
    Initboutons(Me)

    LoadData()

  End Sub

  Private Sub LoadData()

    Dim sqlcmd As New SqlCommand("api_sp_ChantierListeChiffrage", MozartDatabase.cnxMozart)
    sqlcmd.CommandType = CommandType.StoredProcedure
    sqlcmd.Parameters.Add("@actif", SqlDbType.VarChar).Value = "O"
    sqlcmd.Parameters.Add("@soc", SqlDbType.VarChar).Value = MozartParams.NomSociete
    sqlcmd.Parameters.Add("@iall", SqlDbType.Int).Value = 2

    dtChiffrages = New DataTable
    dtChiffrages.Load(sqlcmd.ExecuteReader)

    GCListe.DataSource = dtChiffrages

  End Sub

  Private Sub btnFermer_Click(sender As System.Object, e As System.EventArgs) Handles btnFermer.Click
    Me.Close()
  End Sub

  Private Sub btnModif_Click(sender As System.Object, e As System.EventArgs) Handles btnModif.Click

    Try

      If GVListeChantier.RowCount = 0 Then Exit Sub

      iNIDCHIF = Convert.ToInt32(GVListeChantier.GetDataRow(GVListeChantier.FocusedRowHandle).Item("NIDCHIF"))
      iPos = GVListeChantier.FocusedRowHandle

      ' modification
      Dim ofrmChiff As New frmChiffrage(iNIDCHIF)
      ofrmChiff.ShowDialog()

      LoadData()
      GVListeChantier.FocusedRowHandle = iPos

    Catch Ex As Exception
      MessageBox.Show(My.Resources.Admin_frmListeChiffrages_btnModif & Ex.Message, My.Resources.Global_Erreur)
    End Try
  End Sub

  Private Sub btnAjout_Click(sender As System.Object, e As System.EventArgs) Handles btnAjout.Click

    ' creation
    Dim oFrmChiff As New frmChiffrage(0)
    oFrmChiff.ShowDialog()

    iPos = GVListeChantier.FocusedRowHandle
    LoadData()
    GVListeChantier.FocusedRowHandle = iPos

  End Sub

  Private Sub btnValidation_Click(sender As System.Object, e As System.EventArgs) Handles btnValidation.Click

    If GVListeChantier.RowCount = 0 Then Exit Sub

    iNIDCHIF = Convert.ToInt32(GVListeChantier.GetDataRow(GVListeChantier.FocusedRowHandle).Item("NIDCHIF"))

    Dim oFrmValidationChif As New frmValidation(iNIDCHIF)
    oFrmValidationChif.ShowDialog()

    iPos = GVListeChantier.FocusedRowHandle

    LoadData()

    GVListeChantier.FocusedRowHandle = iPos


  End Sub

  Private Sub btnSup_Click(sender As System.Object, e As System.EventArgs) Handles btnSup.Click

    If GVListeChantier.RowCount = 0 Then Exit Sub

    If MessageBox.Show(My.Resources.Admin_frmListeChiffrages_archiver_chiffrage, My.Resources.Global_confirmerArchivage, MessageBoxButtons.YesNo, MessageBoxIcon.Question) = Windows.Forms.DialogResult.Yes Then

      iNIDCHIF = CLng(GVListeChantier.GetDataRow(GVListeChantier.FocusedRowHandle).Item("NIDCHIF").ToString)

      Dim sqlcmdSupp As New SqlCommand("api_sp_ChantierSupprimerChiffrage", MozartDatabase.cnxMozart)
      sqlcmdSupp.CommandType = CommandType.StoredProcedure
      sqlcmdSupp.Parameters.Add("@iD", SqlDbType.Int).Value = iNIDCHIF
      sqlcmdSupp.ExecuteNonQuery()

    End If

    LoadData()

  End Sub

  Private Sub btnImprimer_Click(sender As System.Object, e As System.EventArgs) Handles btnImprimer.Click

    Dim ps As PrintingSystem = New PrintingSystem
    Dim link As PrintableComponentLink = New PrintableComponentLink(ps)

    link.Component = GCListe
    link.Landscape = True
    link.CreateDocument()
    link.PrintingSystemBase.ExportToPdf(MozartParams.CheminUtilisateurMozart & "PDF\ChantierExport.pdf")

    Dim oDoc As New CGenDoc("ChantierExport", MozartParams.CheminUtilisateurMozart & "PDF\ChantierExport.pdf")
    If oDoc.p_ERROR = "" Then
      Dim oFrmVisuDoc As New frmVisuDoc(oDoc.p_PathFileName)
      oFrmVisuDoc.ShowDialog()
    End If

  End Sub

  Private Sub btnListeArchive_Click(sender As System.Object, e As System.EventArgs) Handles btnListeArchive.Click

    Dim oFrmListArchives As New frmListeArch()
    oFrmListArchives.ShowDialog()

    LoadData()

  End Sub

  Private Sub ResizeMe()

    Dim btnPos As New Point
    GCListe.Height = Me.Height - GCListe.Location.Y - 50
    GCListe.Width = Me.Width - GCListe.Location.X - 50
    btnPos.Y = GCListe.Height - btnFermer.Height - 10
    btnPos.X = btnFermer.Location.X
    btnFermer.Location = btnPos
    'GrpActions.Height = GCListe.Height

  End Sub

End Class