
Imports System.Data.SqlClient
Imports MozartLib

Public Class frmGestFormation

  Dim iNumForm As Integer

  Dim sFile As String
  Dim bNewFile As Boolean

  Public Sub New(Optional ByVal c_iNumForm As Integer = Nothing)

    ' Cet appel est requis par le concepteur.
    InitializeComponent()

    ' Ajoutez une initialisation quelconque après l'appel InitializeComponent().
    iNumForm = c_iNumForm

  End Sub

  Private Sub frmGestFormation_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load

    'INIT
    Initboutons(Me)

    sFile = ""
    bNewFile = False

    RemplirCombo()

    ' on charge la formation si on est en modification
    If iNumForm > 0 Then
      Dim cmd As New SqlCommand("api_sp_ListeFormation", MozartDatabase.cnxMozart)

      cmd.CommandType = CommandType.StoredProcedure
      cmd.Parameters.Add("@p_NFORMNUM", SqlDbType.Int)
      cmd.Parameters("@p_NFORMNUM").Value = iNumForm.ToString

      Dim dr As SqlDataReader = cmd.ExecuteReader
      If dr.HasRows = True Then
        dr.Read()
        DtForm.Text = dr("DFORMDATE").ToString
        If dr("DFORMDATERECYCLE").ToString = "" Then
          DtRecycle.Format = DateTimePickerFormat.Custom
          DtRecycle.CustomFormat = " "
          DtRecycle.Checked = False
        Else
          DtRecycle.Text = dr("DFORMDATERECYCLE").ToString
        End If
        sFile = dr("VFICHIER")
        TxtVFICHIER.Text = sFile
        txtObs.Text = dr("VFORMOBS").ToString
        chkCarte.Checked = IIf(dr("CFORCARTEPRO") = "O", True, False)
        CboForm.SelectedValue = dr("NFORNUM").ToString
        CboTech.SelectedValue = dr("NPERNUM").ToString
      End If
      dr.Close()
    End If

  End Sub

  Private Sub DtRecycle_CloseUp(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles DtRecycle.CloseUp
    DtRecycle.Format = DateTimePickerFormat.Custom
    DtRecycle.CustomFormat = "dd/MM/yyyy"

  End Sub

  Private Function IsVerifChampOK() As Boolean
    If IsNothing(CboTech.SelectedValue) Then
      CboTech.BackColor = Color.Yellow
      Return False
    End If

    If IsNothing(CboForm.SelectedValue) Then
      CboForm.BackColor = Color.Yellow
      Return False
    End If

    If DtForm.Text.Trim = "" Then
      If DtForm.Text.Trim = "" Then DtForm.BackColor = Color.Yellow
      Return False
    Else
      Return True
    End If

  End Function

  Private Sub BtnCancel_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles BtnCancel.Click

    If MessageBox.Show(My.Resources.Global_annuler_modif, My.Resources.Global_confirmation_annulation, MessageBoxButtons.YesNoCancel, MessageBoxIcon.Question) = DialogResult.Yes Then

      Me.Close()

    End If

  End Sub

  Private Sub BtnCreate_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles BtnCreate.Click


    If IsVerifChampOK() = True Then

      Dim sqlcmdCreateForm As New SqlCommand("api_sp_CreationFormation", MozartDatabase.cnxMozart)
      sqlcmdCreateForm.CommandType = CommandType.StoredProcedure
      sqlcmdCreateForm.Parameters.Add("@p_NFORMNUM", SqlDbType.Int)
      sqlcmdCreateForm.Parameters("@p_NFORMNUM").Direction = ParameterDirection.InputOutput
      sqlcmdCreateForm.Parameters("@p_NFORMNUM").Value = iNumForm
      sqlcmdCreateForm.Parameters.Add("@p_NFORNUM", SqlDbType.Int).Value = CboForm.SelectedValue
      sqlcmdCreateForm.Parameters.Add("@p_VFORMOBS", SqlDbType.VarChar).Value = txtObs.Text.ToString
      sqlcmdCreateForm.Parameters.Add("@p_DATEFORM", SqlDbType.VarChar).Value = DtForm.Text.ToString
      sqlcmdCreateForm.Parameters.Add("@p_DATERECY", SqlDbType.VarChar).Value = If(DtRecycle.Checked, DtRecycle.Text.ToString, DBNull.Value)
      sqlcmdCreateForm.Parameters.Add("@p_NPERNUM", SqlDbType.Int).Value = CboTech.SelectedValue
      sqlcmdCreateForm.Parameters.Add("@p_CFORHAB", SqlDbType.VarChar)
      sqlcmdCreateForm.Parameters("@p_CFORHAB").Value = IIf(chkCarte.Checked = True, "O", "N")

      sqlcmdCreateForm.ExecuteNonQuery()

      Dim NFORNUM As Int32 = sqlcmdCreateForm.Parameters("@p_NFORMNUM").Value

      If bNewFile = True And NFORNUM > 0 Then

        If bNewFile = True Then

          If TxtVFICHIER.Text = "" Then

            Dim lStrTmp As String = ModuleData.RechercheParam("REP_ATTEST_FORMATION", MozartParams.NomSociete) & sFile
            If File.Exists(lStrTmp) Then File.Delete(lStrTmp)
            'update dans la table 
            sqlcmdCreateForm = New SqlCommand("UPDATE TFORMATION SET VFICHIER = '' WHERE NFORMNUM = " & NFORNUM.ToString, MozartDatabase.cnxMozart)
            sqlcmdCreateForm.CommandType = CommandType.Text
              sqlcmdCreateForm.ExecuteNonQuery()

            Else

              If File.Exists(TxtVFICHIER.Text) Then

              Dim FileOut As String = NFORNUM.ToString & ".pdf"

              File.Copy(TxtVFICHIER.Text, ModuleData.RechercheParam("REP_ATTEST_FORMATION", MozartParams.NomSociete) & FileOut, True)

              'update dans la table 
              sqlcmdCreateForm = New SqlCommand("UPDATE TFORMATION SET VFICHIER = '" & FileOut & "' WHERE NFORMNUM = " & NFORNUM.ToString, MozartDatabase.cnxMozart)
              sqlcmdCreateForm.CommandType = CommandType.Text
              sqlcmdCreateForm.ExecuteNonQuery()

            End If

          End If

        End If



      End If

      Me.Close()

    Else

      MessageBox.Show(My.Resources.GestionDesFormation_frmGestFormation_champs_vide, My.Resources.Global_erreur_creation, MessageBoxButtons.OK, MessageBoxIcon.Information)

    End If
  End Sub

  Private Sub txt_TextChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles txtObs.TextChanged

    If sender.backcolor = Color.Yellow Then sender.backcolor = Color.White

  End Sub

  Private Sub RemplirCombo()

    Dim ssql As String = "SELECT 0 NINTNUM, '' VINTNOM UNION SELECT NFORNUM, VFORLIB + ' - ' + VFORTYPE + ' - ' + CASE dbo.TFORLISTE.VFORTYPE WHEN 'INTERNE' THEN TPER.VPERPRE + ' ' + TPER.VPERNOM "
    ssql = ssql + "ELSE dbo.TREF_ORGFORMATION.VORGNOM End FROM	dbo.TFORLISTE  LEFT OUTER JOIN "
    ssql = ssql + "dbo.TREF_ORGFORMATION ON dbo.TFORLISTE.NORGNUM = dbo.TREF_ORGFORMATION.NORGNUM LEFT OUTER JOIN "
    ssql = ssql + "dbo.TPER ON dbo.TFORLISTE.NPERNUM = TPER.NPERNUM ORDER BY VINTNOM"


    Dim dtOrg As New DataTable
    Dim dtPer As New DataTable
    Dim dsOrg As SqlDataAdapter = New SqlDataAdapter(ssql, MozartDatabase.cnxMozart)
    Dim dsPer As SqlDataAdapter = New SqlDataAdapter("SELECT 0 NINTNUM, '' VINTNOM UNION SELECT NPERNUM, VPERNOM + ' ' + VPERPRE FROM TPER WITH (NOLOCK) WHERE CPERACTIF = 'O' AND BUTILISATEUR=0 AND VSOCIETE = '" & MozartParams.NomSociete & "' ORDER BY VINTNOM", MozartDatabase.cnxMozart)

    Try
      CboTech.Items.Clear()
      CboForm.Items.Clear()
      dsPer.Fill(dtPer)
      dsOrg.Fill(dtOrg)
      CboTech.DataSource = dtPer
      CboForm.DataSource = dtOrg

    Catch Ex As Exception
      MessageBox.Show(My.Resources.GestionDesFormation_frmGestFormation_erreur & Ex.Message)
    End Try

  End Sub

  Private Sub BtnOpen_Click(sender As Object, e As EventArgs) Handles BtnOpen.Click

    OFD.ShowDialog()

    If OFD.FileName <> "" Then

      bNewFile = True
      TxtVFICHIER.Text = OFD.FileName

    End If

  End Sub

  Private Sub BtnSupp_Click(sender As Object, e As EventArgs) Handles BtnSupp.Click

    If MessageBox.Show("Vouslez-vous vraiment supprimer ce fichier ?", "", MessageBoxButtons.YesNoCancel, MessageBoxIcon.Question) = DialogResult.Yes Then

      bNewFile = True
      TxtVFICHIER.Text = ""

    End If

  End Sub
End Class