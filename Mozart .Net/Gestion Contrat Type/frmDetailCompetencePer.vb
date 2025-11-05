Imports System.Data.SqlClient
Imports MozartLib

Public Class frmDetailCompetencePer

  Dim NIDDOM_COMPET As Int32
  Dim NIDCOMPET As Int32
  Dim bActif As Boolean

  Dim dtLstDomCompetence As DataTable
  Dim dtLstFonction As DataTable

  Public Sub New(ByVal o_NIDCOMPET As Int32, ByVal o_NIDDOM_COMPET As Int32, ByVal o_VLIB_COMPET As String, ByVal o_bActif As Boolean)

    ' Cet appel est requis par le concepteur.
    InitializeComponent()

    ' Ajoutez une initialisation quelconque après l'appel InitializeComponent().
    NIDCOMPET = o_NIDCOMPET
    NIDDOM_COMPET = o_NIDDOM_COMPET

    TxtLibelleCompetence.Text = o_VLIB_COMPET
    bActif = o_bActif

  End Sub


  Private Sub frmDetailCompetencePer_Load(sender As System.Object, e As System.EventArgs) Handles MyBase.Load

    'load combo
    dtLstDomCompetence = New DataTable
    dtLstDomCompetence = ModDataGridView.LoadList(String.Format("[api_sp_ListeGestionDomaine_Competence] {0}, {1}", MozartParams.NomSociete, 1), MozartDatabase.cnxMozart)

    GLUEditDomaineCompetence.Properties.DataSource = dtLstDomCompetence

    'selection auto a l ouverture
    GLUEditDomaineCompetence.EditValue = NIDDOM_COMPET

  End Sub

  Private Sub BtnFermer_Click(sender As System.Object, e As System.EventArgs) Handles BtnFermer.Click

    Me.Close()

  End Sub

  Private Sub BtnEnregistrer_Click(sender As System.Object, e As System.EventArgs) Handles BtnEnregistrer.Click

    If TxtLibelleCompetence.Text = "" Then

      MessageBox.Show(My.Resources.GestionContrat_type_frmDetailTech_nomCompetence, My.Resources.GestionContrat_type_frmDetailTech_nomCompetence_erreur, MessageBoxButtons.OK, MessageBoxIcon.Exclamation)
      Exit Sub

    End If

    If GLUEditDomaineCompetence.EditValue Is Nothing OrElse (GLUEditDomaineCompetence.EditValue.ToString = "" Or GLUEditDomaineCompetence.EditValue = 0) Then

      MessageBox.Show(My.Resources.GestionContrat_type_frmDetailTech_SelectDomaine, My.Resources.GestionContrat_type_frmDetailTech_nomCompetence_erreur, MessageBoxButtons.OK, MessageBoxIcon.Exclamation)
      Exit Sub

    End If

    Dim sqlcmdSave As New SqlCommand("[api_sp_GestCompetence_Save]", MozartDatabase.cnxMozart)
    sqlcmdSave.CommandType = CommandType.StoredProcedure
    sqlcmdSave.Parameters.Add("@P_NIDCOMPET", SqlDbType.Int).Value = NIDCOMPET
    sqlcmdSave.Parameters.Add("@P_NIDDOM_COMPET", SqlDbType.Int).Value = GLUEditDomaineCompetence.EditValue
    sqlcmdSave.Parameters.Add("@P_VLIBCOMPET", SqlDbType.VarChar).Value = TxtLibelleCompetence.Text
    sqlcmdSave.Parameters.Add("@P_ACTIF", SqlDbType.Bit).Value = bActif
    sqlcmdSave.Parameters.Add("@P_VSOCIETE", SqlDbType.VarChar).Value = MozartParams.NomSociete

    sqlcmdSave.ExecuteNonQuery()

    Me.Close()

  End Sub

End Class