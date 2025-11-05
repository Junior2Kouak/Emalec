Imports DevExpress.XtraPrinting
Imports DevExpress.XtraPrintingLinks
Imports DevExpress.XtraGrid
Imports MozartLib

Public Class frmFicheTechRecru

  Dim oGestSQL As New CGestionSQL
  Dim sModeAuto As String
  Dim sFileNameExport As String

  Public Sub New(ByVal sModeAutomatique As String)  '

    ' Cet appel est requis par le concepteur.
    InitializeComponent()

    ' Ajoutez une initialisation quelconque après l'appel InitializeComponent().
    sModeAuto = sModeAutomatique
    sFileNameExport = MozartParams.CheminUtilisateurMozart + "TFicheCompetencesRecruOut.pdf"

  End Sub

  Private Sub frmFicheTechRecru_FormClosed(ByVal sender As Object, ByVal e As System.Windows.Forms.FormClosedEventArgs) Handles Me.FormClosed

    oGestSQL.CloseConnexionSQL()

  End Sub

  Private Sub frmFicheTechRecru_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load

    If oGestSQL.ConnexionSQL(MozartParams.NomServeur, MozartParams.NomSociete) = True Then

      GCFicheTechRecru.DataSource = ModDataGridView.LoadList("api_sp_ImpFicheCompetencesRecrutement", oGestSQL.CnxSQLOpen)
      'permet de faire des regroupement
      BGVFicheTechRecru.OptionsView.AllowCellMerge = True

      If sModeAuto = "O" Then

        CreateExportPDF(GCFicheTechRecru, sFileNameExport)
        Process.Start(sFileNameExport)
        Me.Close()

      End If

    End If

  End Sub

  Private Function CreateExportPDF(ByVal OGCTRL As GridControl, ByVal sFileName As String) As String

    Try

      Dim ps As New PrintingSystemBase

      Dim Link As New PrintableComponentLinkBase(ps)

      Link.Component = OGCTRL
      Link.Margins.Bottom = 39
      Link.Margins.Left = 59
      Link.Margins.Top = 31
      Link.Margins.Right = 40

      Link.CreateDocument()

      Link.PrintingSystemBase.ExportToPdf(sFileName)

      Return sFileName

    Catch ex As Exception

      MessageBox.Show(ex.Message)
      Return ""

    End Try

  End Function

  Private Sub BtnFermer_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles BtnFermer.Click
    Me.Close()
  End Sub

  Private Sub BtnExportPDF_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles BtnExportPDF.Click

    SDF.AddExtension = True
    SDF.Filter = "Fichier PDF (*.PDF)|.PDF"
    SDF.ShowDialog()

    If SDF.FileName <> "" Then

      CreateExportPDF(GCFicheTechRecru, SDF.FileName)

    End If

  End Sub

End Class