Imports System.Data.SqlClient
Imports MozartLib

Public Class FrmListeClientByCompte

  Dim NCANNUM As Int32
  Dim sLIBCOMPTE As String
  Dim dtListCLi As DataTable
  Dim _bCancel As Boolean

  Public ReadOnly Property bCancel As Boolean
    Get
      bCancel = _bCancel
    End Get
  End Property

  Public Sub New(ByVal C_NCANNUM As Int32, ByVal C_LIBCOMPTE As String)

    ' Cet appel est requis par le concepteur.
    InitializeComponent()

    ' Ajoutez une initialisation quelconque après l'appel InitializeComponent().
    NCANNUM = C_NCANNUM
    sLIBCOMPTE = C_LIBCOMPTE
    _bCancel = False

  End Sub

  Private Sub FrmListeClientByCompte_Load(sender As System.Object, e As System.EventArgs) Handles MyBase.Load

    'init
    dtListCLi = New DataTable
    LblTitre.Text = String.Format(My.Resources.admin_frmlisteClientByCompte_listeClient, NCANNUM.ToString + " - " + sLIBCOMPTE)

    Dim sqlcmdListCli As New SqlCommand("api_sp_ListeClientByCompte", MozartDatabase.cnxMozart)
    sqlcmdListCli.CommandType = CommandType.StoredProcedure
        sqlcmdListCli.Parameters.Add("@P_NCANNUM", SqlDbType.Int).Value = NCANNUM
        dtListCLi.Load(sqlcmdListCli.ExecuteReader)

        GCListClient.DataSource = dtListCLi

        LblNbLine.Text = String.Format("Nb lignes : {0}", dtListCLi.Rows.Count)

    End Sub

    Private Sub BtnContinue_Click(sender As System.Object, e As System.EventArgs) Handles BtnContinue.Click

        If MessageBox.Show(My.Resources.Admin_FrmListeClientByCompte_CompteAnalytique, My.Resources.Global_Confirmation, MessageBoxButtons.YesNoCancel, MessageBoxIcon.Information) = Windows.Forms.DialogResult.Yes Then

      Dim sqlcmdArch As New SqlCommand("api_sp_CompteClientArchiverAll", MozartDatabase.cnxMozart)
      sqlcmdArch.CommandType = CommandType.StoredProcedure
            sqlcmdArch.Parameters.Add("@P_NCANNUM", SqlDbType.Int).Value = NCANNUM

            sqlcmdArch.ExecuteNonQuery()

            Me.Close()

        Else

            _bCancel = True

        End If

    End Sub

    Private Sub BtnAnnuler_Click(sender As System.Object, e As System.EventArgs) Handles BtnAnnuler.Click
        _bCancel = True
        Me.Close()
    End Sub

End Class