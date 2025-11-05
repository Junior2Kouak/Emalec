Imports System.Data.SqlClient
Imports MozartLib

Public Class frmNewTypeFormation

  Dim iNumForm As Integer
  Dim oGestConnectSQL As New CGestionSQL

  Public Sub New(Optional ByVal c_iNumForm As Integer = Nothing)

    ' Cet appel est requis par le concepteur.
    InitializeComponent()

    ' Ajoutez une initialisation quelconque après l'appel InitializeComponent().
    iNumForm = c_iNumForm

  End Sub

  Private Sub frmNewFormation_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load

    'on ouvre la connexion
    oGestConnectSQL.ConnexionSQL(MozartParams.NomServeur, MozartParams.NomSociete)

    ' remplir combo
    RemplirCombo()

    ' on charge la formation si on est en modification
    If iNumForm > 0 Then
      Dim cmd As New SqlCommand("api_sp_ListeTypeFormation", MozartDatabase.cnxMozart)

      cmd.CommandType = CommandType.StoredProcedure
      cmd.Parameters.Add("@p_NFORNUM", SqlDbType.Int)
      cmd.Parameters("@p_NFORNUM").Value = iNumForm.ToString

      Dim dr As SqlDataReader = cmd.ExecuteReader
      If dr.HasRows = True Then
        dr.Read()
        txtNom.Text = dr("VFORLIB").ToString
        txtObs.Text = dr("VFOROBS").ToString
        CboType.Text = dr("VFORTYPE").ToString
        If CboType.Text = "INTERNE" Then
          cboPer.SelectedValue = dr("INTER").ToString
        Else
          CboInter.SelectedValue = dr("INTER").ToString
        End If

      End If
      dr.Close()
    End If

  End Sub

  Private Function IsVerifChampOK() As Boolean
    If CboType.Text = "INTERNE" AndAlso IsNothing(cboPer.SelectedValue) Then
      cboPer.BackColor = Color.Yellow
      Return False
    End If
    If CboType.Text = "EXTERNE" AndAlso IsNothing(CboInter.SelectedValue) Then
      CboInter.BackColor = Color.Yellow
      Return False
    End If
    If txtNom.Text.Trim = "" Then
      If txtNom.Text.Trim = "" Then txtNom.BackColor = Color.Yellow
      Return False
    End If
    Return True
  End Function

  Private Sub BtnCancel_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles BtnCancel.Click

    If MessageBox.Show(My.Resources.Global_annuler_modif, My.Resources.Global_confirmation_annulation, MessageBoxButtons.YesNoCancel, MessageBoxIcon.Question) = DialogResult.Yes Then

      oGestConnectSQL.CloseConnexionSQL()
      Me.Close()

    End If

  End Sub

  Private Sub BtnCreate_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles BtnCreate.Click

    If IsVerifChampOK() = True Then

      Dim sqlcmdCreateForm As New SqlCommand("api_sp_CreationTypeFormation", oGestConnectSQL.CnxSQLOpen)
      sqlcmdCreateForm.CommandType = CommandType.StoredProcedure
      sqlcmdCreateForm.Parameters.Add("@p_NFORNUM", SqlDbType.Int)
      sqlcmdCreateForm.Parameters("@p_NFORNUM").Value = iNumForm
      sqlcmdCreateForm.Parameters.Add("@p_VFORLIB", SqlDbType.VarChar)
      sqlcmdCreateForm.Parameters("@p_VFORLIB").Value = txtNom.Text.ToString
      sqlcmdCreateForm.Parameters.Add("@p_VFOROBS", SqlDbType.VarChar)
      sqlcmdCreateForm.Parameters("@p_VFOROBS").Value = txtObs.Text.ToString
      sqlcmdCreateForm.Parameters.Add("@p_VFORTYPE", SqlDbType.VarChar)
      sqlcmdCreateForm.Parameters("@p_VFORTYPE").Value = CboType.Text.ToString
      sqlcmdCreateForm.Parameters.Add("@p_NINTNUM", SqlDbType.Int)
      sqlcmdCreateForm.Parameters("@p_NINTNUM").Value = IIf(CboType.Text = "INTERNE", cboPer.SelectedValue, CboInter.SelectedValue)

      sqlcmdCreateForm.ExecuteNonQuery()

      oGestConnectSQL.CloseConnexionSQL()
      Me.Close()

    Else

      MessageBox.Show(My.Resources.GestionDesFormation_frmNewTypeFormation_champs_vide, My.Resources.Global_erreur_creation, MessageBoxButtons.OK, MessageBoxIcon.Information)

    End If
  End Sub

  Private Sub txt_TextChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles txtNom.TextChanged, txtObs.TextChanged

    If sender.backcolor = Color.Yellow Then sender.backcolor = Color.White

  End Sub

  Private Sub CboType_SelectedIndexChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles CboType.SelectedIndexChanged
    'lors du changement de type d'intervenant, on change la combo visible
    If CboType.Text = "INTERNE" Then
      CboInter.Visible = False
      cboPer.Visible = True
    Else
      CboInter.Visible = True
      cboPer.Visible = False
    End If
  End Sub

  Private Sub RemplirCombo()

    Try
      Dim dt1 As New DataTable

      CboInter.Items.Clear()
      Dim dsOrg As SqlDataAdapter = New SqlDataAdapter("SELECT 0 NINTNUM, '' VINTNOM UNION SELECT NORGNUM, VORGNOM FROM TREF_ORGFORMATION ORDER BY VINTNOM", oGestConnectSQL.CnxSQLOpen)
      dsOrg.Fill(dt1)
      CboInter.DataSource = dt1

      Dim dt2 As New DataTable

      cboPer.Items.Clear()
      Dim dsPer As SqlDataAdapter = New SqlDataAdapter("SELECT 0 NINTNUM, '' VINTNOM UNION SELECT NPERNUM, VPERNOM + ' ' + VPERPRE FROM TPER WITH (NOLOCK) WHERE (cpertyp <> 'TE' or nperstd is not null) AND CPERACTIF = 'O' AND VSOCIETE = '" & MozartParams.NomSociete & "' ORDER BY VINTNOM", oGestConnectSQL.CnxSQLOpen)
      dsPer.Fill(dt2)
      cboPer.DataSource = dt2

    Catch Ex As Exception
      MessageBox.Show(My.Resources.GestionDesFormation_frmGestFormation_erreur & Ex.Message)
    End Try

  End Sub
End Class


