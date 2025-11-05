Imports System.Data.SqlClient
Imports MozartLib

Public Class frmSaisieHChaff

  Dim sNom As String
  Dim NPERNUM As Int32
  Dim NCANNUM As Int32
  Dim iHeuresSaisie As Int32
  Dim DateSaisie As Date

  Dim dtCompteChaff As DataTable

  Public Sub New(ByVal c_NOM As String, ByVal c_NPERNUM As Int32, ByVal c_NCANNUM As Int32, ByVal c_HeuresSaisie As Int32, ByVal c_DateSaisie As Date)

    ' Cet appel est requis par le concepteur.
    InitializeComponent()

    ' Ajoutez une initialisation quelconque après l'appel InitializeComponent().
    sNom = c_NOM
    NPERNUM = c_NPERNUM
    NCANNUM = c_NCANNUM
    iHeuresSaisie = c_HeuresSaisie
    DateSaisie = c_DateSaisie

  End Sub

  Private Sub frmSaisieHChaff_Load(sender As System.Object, e As System.EventArgs) Handles MyBase.Load

    'init
    Initboutons(Me)
    LoadData()

    TxtNom.Text = sNom
    txtHRSaisie.EditValue = iHeuresSaisie
    GLEditNCANNUM.EditValue = NCANNUM

  End Sub

  Private Sub LoadData()

    Dim sqlcmd As SqlCommand

    dtCompteChaff = New DataTable

    sqlcmd = New SqlCommand("SELECT	NCANNUM, CAST(NCANNUM AS VARCHAR) + ' - ' + VCANLIB AS VCANLIB FROM TREF_CTEANA WHERE VSOCIETE = APP_NAME() AND CCTEANAACTIF = 'O'", MozartDatabase.cnxMozart)
    sqlcmd.CommandType = CommandType.Text
        dtCompteChaff.Load(sqlcmd.ExecuteReader)

        GLEditNCANNUM.Properties.DataSource = dtCompteChaff

    End Sub

    Private Sub BtnFermer_Click(sender As System.Object, e As System.EventArgs) Handles BtnFermer.Click
        Me.Close()
    End Sub

    Private Sub BtnOK_Click(sender As System.Object, e As System.EventArgs) Handles BtnOK.Click

        'test si compte sélectionner
        If GLEditNCANNUM.Text = "" Then MessageBox.Show(My.Resources.Admin_frmSaisieHChaff_CompteSelection, My.Resources.Global_Erreur, MessageBoxButtons.OK, MessageBoxIcon.Exclamation) : Exit Sub

        Try

      Dim sqlcmdSave As New SqlCommand("api_sp_SaisieHeureCaff", MozartDatabase.cnxMozart)
      sqlcmdSave.CommandType = CommandType.StoredProcedure
            sqlcmdSave.Parameters.Add("@iPersonne", SqlDbType.Int).Value = NPERNUM
            sqlcmdSave.Parameters.Add("@dDate", SqlDbType.DateTime).Value = DateSaisie
            sqlcmdSave.Parameters.Add("@cte", SqlDbType.Int).Value = GLEditNCANNUM.EditValue
            sqlcmdSave.Parameters.Add("@heure", SqlDbType.Int).Value = txtHRSaisie.Text

            sqlcmdSave.ExecuteNonQuery()

            Me.Close()

        Catch ex As Exception
            MessageBox.Show("BtnOK_Click : " + ex.Message)
        End Try

    End Sub

End Class