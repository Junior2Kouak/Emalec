Imports DevExpress.XtraPrinting
Imports MozartLib

Public Class frmTableHDetail

  Dim miCompte As Int32
  Dim mstrPersonne As String
  Dim miPersonne As Int32
  Dim miMois As Int32
  Dim miAnnee As Int32
  Dim mstrType As String

  Public Sub New(ByVal c_miCompte As Int32, ByVal c_mstrPersonne As String, ByVal c_miPersonne As Int32, ByVal c_miMois As Int32, ByVal c_miAnnee As Int32, ByVal c_mstrType As String)

    ' Cet appel est requis par le concepteur.
    InitializeComponent()

    ' Ajoutez une initialisation quelconque après l'appel InitializeComponent().
    miCompte = c_miCompte
    mstrPersonne = c_mstrPersonne
    miPersonne = c_miPersonne
    miMois = c_miMois
    miAnnee = c_miAnnee
    mstrType = c_mstrType

  End Sub

  Private Sub frmTableHDetail_Load(sender As System.Object, e As System.EventArgs) Handles MyBase.Load
    Initboutons(Me)

    LblTitre.Text = String.Format(My.Resources.Global_SurLeCompte, LblTitre.Tag, mstrPersonne, miCompte)

    LoadData()

    If mstrType.ToUpper <> "COUT" Then
      GColCout.Visible = False
    End If
  End Sub

  Private Sub LoadData()
    GCDetailH.DataSource = ModDataGridView.LoadList(String.Format("exec api_sp_DetailHeuresTech {0}, {1}, {2}, {3}", miPersonne, miCompte, miMois, miAnnee), MozartDatabase.cnxMozart)
  End Sub

  Private Sub BtnFermer_Click(sender As System.Object, e As System.EventArgs) Handles BtnFermer.Click
    Me.Close()
  End Sub

  Private Sub BtnPrint_Click(sender As System.Object, e As System.EventArgs) Handles BtnPrint.Click
    Dim link As New PrintableComponentLink(New PrintingSystem()) With {
      .Component = GCDetailH,
      .Landscape = True
    }
    link.ShowPreview()
  End Sub

  Private Sub BtnDetail_Click(sender As System.Object, e As System.EventArgs) Handles BtnDetail.Click
    If GVDetailH.SelectedRowsCount = 0 Then Exit Sub

    Dim drSelect As DataRow = GVDetailH.GetDataRow(GVDetailH.GetSelectedRows(0))

    Dim Startcmd As New ProcessStartInfo With {
      .UseShellExecute = False,
      .FileName = MozartParams.CheminProgrammeMozart & "MozartCS.exe",
      .Arguments = String.Format("{0};{1};{2};{3}", MozartParams.NomServeur, MozartParams.NomSociete, drSelect.Item("NUM_NDINNUM"), drSelect.Item("NACTNUM")) 'drSelect.Item("NDINNUM"), 0)
      }

    Dim oIDProcessus As New Process
    oIDProcessus.StartInfo = Startcmd
    oIDProcessus.Start()
    oIDProcessus.WaitForExit()
  End Sub

End Class