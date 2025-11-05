Imports MozartLib

Public Class FrmGestDocSupportTech

  Dim _oGestionDoc As CGestionDoc
  Dim _sTypeFiche As String
  Dim bArchives As Boolean = False

  Dim sTitreForm As String

  Public Sub New(ByVal c_sTypeFiche As Object)

    ' Cet appel est requis par le concepteur.
    InitializeComponent()

    ' Ajoutez une initialisation quelconque après l'appel InitializeComponent().
    _sTypeFiche = c_sTypeFiche

    Select Case _sTypeFiche

      Case "SP"

        sTitreForm = "Support Formation (Web technicien)"

      Case Else

        sTitreForm = ""

    End Select

  End Sub

  Private Sub FrmGestDocSupportTech_Load(sender As System.Object, e As System.EventArgs) Handles MyBase.Load

    'Init
    Me.Text = sTitreForm

    _oGestionDoc = New CGestionDoc(_sTypeFiche)

    GCGESTDOC.DataSource = _oGestionDoc.DtListGestDoc

  End Sub

  Private Sub BtnQuit_Click(sender As System.Object, e As System.EventArgs) Handles BtnQuit.Click
    Me.Close()
  End Sub

  Private Sub BtnListeArchives_Click(sender As System.Object, e As System.EventArgs) Handles BtnListeArchives.Click

    If bArchives = False Then
      _oGestionDoc.RefreshData("N")
      GCGESTDOC.DataSource = _oGestionDoc.DtListGestDoc
      bArchives = True
      BtnListeArchives.Text = "Liste des actifs"
      BtnArchiver.Visible = False
      BtnAddLine.Visible = False
      BtnMod.Visible = False
      LblTitre.Text = String.Format("{0} - Archivés", sTitreForm)

    Else

      _oGestionDoc.RefreshData("O")
      GCGESTDOC.DataSource = _oGestionDoc.DtListGestDoc
      bArchives = False
      BtnListeArchives.Text = "Liste des archives"
      BtnArchiver.Visible = True
      BtnAddLine.Visible = True
      BtnMod.Visible = True
      LblTitre.Text = sTitreForm

    End If

  End Sub

  Private Sub BtnVisualiser_Click(sender As System.Object, e As System.EventArgs) Handles BtnVisualiser.Click

    If GVGESTDOC.SelectedRowsCount = 0 Then

      MessageBox.Show("Il faut sélectionner une ligne", "Erreur", MessageBoxButtons.OK, MessageBoxIcon.Information)
      Exit Sub

    End If

    Dim oDocDetail As New CGestDocDetail(_sTypeFiche, GVGESTDOC.GetDataRow(GVGESTDOC.GetSelectedRows(0)).Item("ID"))
    Dim sFile As String = MozartParams.CheminFicheTech & oDocDetail.VFICTECH

    If File.Exists(sFile) = False Then
      MessageBox.Show(String.Format("Le fichier {0} n'existe pas.", sFile), "Erreur", MessageBoxButtons.OK, MessageBoxIcon.Exclamation)
    Else
      Dim oFrmVisu As New frmVisuDoc(sFile)
      oFrmVisu.ShowDialog()

    End If
    oDocDetail = Nothing

  End Sub

  Private Sub BtnAddLine_Click(sender As System.Object, e As System.EventArgs) Handles BtnAddLine.Click

    Dim oDocDetail As New CGestDocDetail(_sTypeFiche)
    Dim oFrmDocDetail As New FrmGestDocDetail(oDocDetail)
    oFrmDocDetail.ShowDialog()

    _oGestionDoc.RefreshData("O")
    GCGESTDOC.DataSource = _oGestionDoc.DtListGestDoc

  End Sub

  Private Sub BtnMod_Click(sender As System.Object, e As System.EventArgs) Handles BtnMod.Click

    If GVGESTDOC.SelectedRowsCount = 0 Then

      MessageBox.Show("Il faut sélectionner une ligne", "Erreur", MessageBoxButtons.OK, MessageBoxIcon.Information)
      Exit Sub

    End If

    Dim oDocDetail As New CGestDocDetail(_sTypeFiche, GVGESTDOC.GetDataRow(GVGESTDOC.GetSelectedRows(0)).Item("ID"))
    Dim oFrmDocDetail As New FrmGestDocDetail(oDocDetail)
    oFrmDocDetail.ShowDialog()

    _oGestionDoc.RefreshData("O")
    GCGESTDOC.DataSource = _oGestionDoc.DtListGestDoc

  End Sub

  Private Sub BtnArchiver_Click(sender As System.Object, e As System.EventArgs) Handles BtnArchiver.Click

    If GVGESTDOC.SelectedRowsCount = 0 Then

      MessageBox.Show("Il faut sélectionner une ligne", "Erreur", MessageBoxButtons.OK, MessageBoxIcon.Information)
      Exit Sub

    End If

    If MessageBox.Show("Voulez-vous archiver cette fiche ?", "Archiver fiche", MessageBoxButtons.YesNoCancel, MessageBoxIcon.Question) = Windows.Forms.DialogResult.Yes Then

      _oGestionDoc.ArchiverDocument(GVGESTDOC.GetDataRow(GVGESTDOC.GetSelectedRows(0)).Item("ID"))

    End If

    _oGestionDoc.RefreshData("O")
    GCGESTDOC.DataSource = _oGestionDoc.DtListGestDoc

  End Sub

End Class