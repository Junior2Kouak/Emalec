Imports System.Data.SqlClient
Imports MozartLib

Public Class frmGestCompteAnaCreate

  Dim _oDrCompteAna As DataRow
  Dim _CCompteAna As CCompteAna

  Dim dtTypeCompte As DataTable
  Dim dtMBEHMBE As DataTable
  Dim iMode As Byte 'mode 0 = creation, mode 1 = modification

  Public Sub New(ByVal c_drCompteAna As DataRow, ByRef c_CCompteAna As CCompteAna, ByVal c_iMode As Byte)

    ' Cet appel est requis par le concepteur.
    InitializeComponent()

    ' Ajoutez une initialisation quelconque après l'appel InitializeComponent().
    _oDrCompteAna = c_drCompteAna
    _CCompteAna = c_CCompteAna
    iMode = c_iMode

  End Sub

  Private Sub frmGestCompteAnaCreate_Load(sender As System.Object, e As System.EventArgs) Handles MyBase.Load

    'init
    'Type compte
    dtTypeCompte = New DataTable
    Dim lStrReq As String = "SELECT CTYPECTE, VTYPECTE FROM TREF_TYPECTE INNER JOIN "
    lStrReq += " TCPT_TYPECTE WITH (NOLOCK) ON TREF_TYPECTE.IDTYPECTE=TCPT_TYPECTE.IDTYPECTE INNER JOIN "
    lStrReq += " TSOCIETE WITH (NOLOCK) ON TSOCIETE.NSOCIETEID=TCPT_TYPECTE.NSOCIETEID "
    lStrReq += String.Format("WHERE TSOCIETE.VSOCIETENOM = '{0}' ORDER BY VTYPECTE", MozartParams.NomSociete)
    Dim sqlcmdLoad As SqlCommand = New SqlCommand(lStrReq, MozartDatabase.cnxMozart) With {
      .CommandType = CommandType.Text
    }
    dtTypeCompte.Load(sqlcmdLoad.ExecuteReader)

    GridLookUpTypeCompteAna.Properties.DataSource = dtTypeCompte

    dtMBEHMBE = New DataTable
    dtMBEHMBE.Columns.Add("VLIBMBEHMBE", Type.GetType("System.String"))

    Dim DrRowMBE As DataRow = dtMBEHMBE.NewRow
    DrRowMBE.Item("VLIBMBEHMBE") = "MBE"
    dtMBEHMBE.Rows.Add(DrRowMBE)

    DrRowMBE = dtMBEHMBE.NewRow
    DrRowMBE.Item("VLIBMBEHMBE") = "HMBE"
    dtMBEHMBE.Rows.Add(DrRowMBE)

    GridLookUpEdit1.Properties.DataSource = dtMBEHMBE

    If iMode = 1 Then

      txtNCANNUM.Text = _oDrCompteAna.Item("NCANNUM")
      txtNCANNUM.Enabled = False
      TxtVCANLIB.Text = _oDrCompteAna.Item("VCANLIB")
      GridLookUpTypeCompteAna.EditValue = _oDrCompteAna("CTYPECTE")
      txtRFA.EditValue = If(_oDrCompteAna.Item("NRFAPOURC") Is DBNull.Value, "", _oDrCompteAna.Item("NRFAPOURC"))

      GridLookUpEdit1.Text = If(IsDBNull(_oDrCompteAna.Item("VTYPEMBE")), "", _oDrCompteAna.Item("VTYPEMBE"))

    ElseIf iMode = 0 Then

      txtNCANNUM.Text = _oDrCompteAna.Item("NCANNUM")
      GridLookUpEdit1.Text = "MBE"

    End If

  End Sub


  Private Sub BtnSave_Click(sender As System.Object, e As System.EventArgs) Handles BtnSave.Click

    If txtNCANNUM.EditValue.ToString = "" Then MessageBox.Show(My.Resources.admin_frmGestCompteAnaAffectation_SaisirN, My.Resources.Global_Erreur, MessageBoxButtons.OK, MessageBoxIcon.Exclamation) : Exit Sub

    If TxtVCANLIB.Text = "" Then MessageBox.Show(My.Resources.admin_frmGestCompteAnaAffectation_SaisirL, My.Resources.Global_Erreur, MessageBoxButtons.OK, MessageBoxIcon.Exclamation) : Exit Sub

    If GridLookUpTypeCompteAna.EditValue = "" Then MessageBox.Show(My.Resources.admin_frmGestCompteAnaAffectation_SelectionnerCompte, My.Resources.Global_Erreur, MessageBoxButtons.OK, MessageBoxIcon.Exclamation) : Exit Sub

    If GridLookUpEdit1.Text = "" Then MessageBox.Show("Il faut sélectionner un type de compte MBE/HMBE", My.Resources.Global_Erreur, MessageBoxButtons.OK, MessageBoxIcon.Exclamation) : Exit Sub

    ' FGA le 21/10/2024
    ' Gestion des droits sur les comptes de frais généraux (> 890)
    ' La direction et Maxime Lefort
    If CInt(txtNCANNUM.EditValue) > 889 Then
      If MozartParams.strUID <> "LEFORT" And MozartParams.strUID <> "CHEVALIER" And MozartParams.strUID <> "LAZZAROTTO" Then
        MessageBox.Show("Vous avez sélectionné un compte analytique correspondant à des frais généraux." + vbCrLf +
                  "Vous n'avez pas les droits pour le créer." + vbCrLf + "Veuillez-vous rapprocher de Maxime LEFORT.",
                          My.Resources.Global_Erreur, MessageBoxButtons.OK, MessageBoxIcon.Exclamation)
        Exit Sub
      End If
    End If

    'on enregistre le compte
    _CCompteAna.SaveCompteAna(iMode, txtNCANNUM.EditValue, TxtVCANLIB.Text, GridLookUpTypeCompteAna.EditValue, If(txtRFA.EditValue Is Nothing, "", txtRFA.EditValue.ToString), GridLookUpEdit1.Text)

    'si creation alors on ouvre automatiquement les droits
    If iMode = 0 Then

      Dim oFrmGestCptAnaAffect As New frmGestCompteAnaAffectation(_CCompteAna, txtNCANNUM.EditValue, TxtVCANLIB.Text)
      oFrmGestCptAnaAffect.ShowDialog()
      Me.Close()

    End If

    'on passe en modification
    iMode = 1

    End Sub

  Private Sub BtnQuit_Click(sender As System.Object, e As System.EventArgs) Handles BtnQuit.Click
    Me.Close()
  End Sub

End Class