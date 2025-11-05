Imports MozartLib

Public Class FrmGestDocDetail

  Dim _oDocDetail As CGestDocDetail
  Dim sFileJoin As String

  Public Sub New(ByVal c_oDocDetail As CGestDocDetail)

    ' Cet appel est requis par le concepteur.
    InitializeComponent()

    ' Ajoutez une initialisation quelconque après l'appel InitializeComponent().
    _oDocDetail = c_oDocDetail

  End Sub

  Private Sub FrmGestDocDetail_Load(sender As System.Object, e As System.EventArgs) Handles MyBase.Load

    'affichage selon le type
    Select Case _oDocDetail.sType

      Case "SP"

        Me.Text = "Détails Fiche Support Formation (Web technicien)"
        LabelTitre.Text = "Détails Fiche Support Formation (Web technicien)"
        LblTitreDetailNom.Text = "Titre de la fiche"
        LblTitreDatePubli.Text = "Date publication"

      Case Else
        Me.Text = ""
        LabelTitre.Text = ""
        LblTitreDetailNom.Text = ""
        LblTitreDatePubli.Text = ""

    End Select

    If _oDocDetail.ID > 0 Then

      TxtTitreFiche.Text = _oDocDetail.TITRE
      DatePublication.DateTime = Now

      sFileJoin = MozartParams.CheminFicheTech & _oDocDetail.VFICTECH

      If File.Exists(sFileJoin) Then
        WBFile.Navigate(sFileJoin)
      Else
        MessageBox.Show(String.Format("Le fichier {0} n'existe pas.", sFileJoin), "Erreur", MessageBoxButtons.OK, MessageBoxIcon.Exclamation)
        WBFile.Navigate("about:blank")
      End If

    Else

      TxtTitreFiche.Text = ""
      DatePublication.DateTime = Now.Date
      sFileJoin = ""
      WBFile.Navigate("about:blank")

    End If

  End Sub

  Private Sub BtnFermer_Click(sender As System.Object, e As System.EventArgs) Handles BtnFermer.Click
    Me.Close()
  End Sub

  Private Sub BtnFile_Click(sender As System.Object, e As System.EventArgs) Handles BtnFile.Click

    OFD.FileName = ""
    OFD.Filter = "Fichier PDF (*.pdf)|*.pdf"
    OFD.ShowDialog()

    If OFD.FileName <> "" Then
      sFileJoin = OFD.FileName
      WBFile.Navigate(OFD.FileName)
    End If

  End Sub

  Private Sub ButtonEnreg_Click(sender As System.Object, e As System.EventArgs) Handles ButtonEnreg.Click

    'titre obligatoire
    If TxtTitreFiche.Text = "" Then MessageBox.Show("Vous devez saisir un titre", "Erreur", MessageBoxButtons.OK, MessageBoxIcon.Exclamation) : Exit Sub

    'fichier obligatoire
    If sFileJoin = "" Then MessageBox.Show("Vous devez sélectionner un fichier", "Erreur", MessageBoxButtons.OK, MessageBoxIcon.Exclamation) : Exit Sub

    'ByVal p_TITRE As String, ByVal p_VFICTECH As String, ByVal p_DDATEPUB As Date
    _oDocDetail.AddDocument(TxtTitreFiche.Text, sFileJoin, DatePublication.DateTime)

  End Sub

End Class