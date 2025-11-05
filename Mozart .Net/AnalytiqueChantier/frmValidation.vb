Imports System.Data.SqlClient
Imports MozartLib

Public Class frmValidation

  Dim cmd As SqlCommand
  Dim dt As DataTable
  Dim iPos As Int32
  Dim iNIDCHIF As Int32

  Public Sub New(ByVal c_NIDCHIF As Int32)

    ' Cet appel est requis par le concepteur.
    InitializeComponent()

    ' Ajoutez une initialisation quelconque après l'appel InitializeComponent().
    iNIDCHIF = c_NIDCHIF

  End Sub

  Private Sub frmValidation_FormClosing(ByVal sender As Object, ByVal e As System.Windows.Forms.FormClosingEventArgs) Handles Me.FormClosing
    dt.Clear()
  End Sub

  Private Sub frmValidation_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load

    RemplirCombo()

    Init()

  End Sub
  Private Sub RemplirCombo()
    Try

      'MODIF du compte que les comptes travaux, demande de PC modif par MC le 09/11/2016
      cmd = New SqlCommand("SELECT 0 AS NCANNUM ,'' AS LIB UNION SELECT TREF_CTEANA.NCANNUM, convert(varchar(4),TREF_CTEANA.NCANNUM) + ' - ' + TREF_CTEANA.VCANLIB AS LIB " _
                                & "FROM TREF_CTEANA WITH (NOLOCK) INNER JOIN " _
                                & "TCAN WITH (NOLOCK) ON TREF_CTEANA.NCANNUM = TCAN.NCANNUM INNER JOIN " _
                                & "TCHANTIERCHIFFRAGE WITH (NOLOCK) ON TCHANTIERCHIFFRAGE.NCLINUM = TCAN.NCLINUM " _
                                & "WHERE TREF_CTEANA.NCANNUM < 899 AND CCANACTIF = 'O' AND  NIDCHIF = " & iNIDCHIF.ToString & " AND TREF_CTEANA.VSOCIETE = '" & MozartParams.NomSociete _
                                & "' AND TREF_CTEANA.CTYPECTE in  ('T','O','R','N') ORDER BY NCANNUM", MozartDatabase.cnxMozart)

      dt = New DataTable
      dt.Load(cmd.ExecuteReader())
      cmbChantier.DataSource = dt

    Catch Ex As Exception
      MessageBox.Show(My.Resources.Admin_frmValidation_ErreurRemplir & Ex.Message, My.Resources.Global_Erreur, MessageBoxButtons.OK, MessageBoxIcon.Error)
    End Try

  End Sub

  Private Sub Init()
    Try

      cmd = New SqlCommand("SELECT NCANNUM FROM TCHANTIERCHIFFRAGE WITH (NOLOCK) INNER JOIN TCHANTIERCAN WITH (NOLOCK) ON TCHANTIERCHIFFRAGE.NIDCHANTIER = TCHANTIERCAN.NIDCHANTIER WHERE NIDCHIF = " & iNIDCHIF, MozartDatabase.cnxMozart)
      cmd.CommandType = CommandType.Text

      Dim dr As SqlDataReader
      dr = cmd.ExecuteReader
      dr.Read()

      If dr.HasRows Then cmbChantier.SelectedValue = dr("NCANNUM")

      dr.Close()

    Catch Ex As Exception
      MessageBox.Show(My.Resources.Admin_frmValidation_ErreurInit & Ex.Message, My.Resources.Global_Erreur, MessageBoxButtons.OK, MessageBoxIcon.Error)
    End Try
  End Sub
  Private Sub btnValider_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnValider.Click

    Try

      Dim nMO As Integer
      Dim nFO As Integer
      Dim nSTT As Integer
      Dim dr As SqlDataReader

      ' verification du compte prorata
      If cmbChantier.SelectedValue <> 0 Then

        If VerifProrata(cmbChantier.SelectedValue, iNIDCHIF) = False Then Exit Sub

        cmd = New SqlCommand("SELECT ISNULL(NMO,0) AS NMO, ISNULL(NFO,0) AS NFO, ISNULL(NSTT,0) AS NSTT FROM TCHANTIERCHIFFRAGE WITH (NOLOCK) WHERE NIDCHIF = " & iNIDCHIF, MozartDatabase.cnxMozart)
        cmd.CommandType = CommandType.Text
        dr = cmd.ExecuteReader
        dr.Read()
        nMO = dr("NMO")
        nFO = dr("NFO")
        nSTT = dr("NSTT")
        dr.Close()

        'test des heures, cst, cmd fo si négatif
        If VerifChiffrage(cmbChantier.SelectedValue, nMO, nFO, nSTT) = False Then
          Exit Sub
        End If

      End If

      cmd = New SqlCommand("api_sp_ChantierValidation", MozartDatabase.cnxMozart)
      cmd.CommandType = CommandType.StoredProcedure

      cmd.Parameters.Add("@iD", SqlDbType.Int)
      cmd.Parameters("@iD").Value = iNIDCHIF

      cmd.Parameters.Add("@nCa", SqlDbType.Int)
      cmd.Parameters("@nCa").Value = IIf(cmbChantier.SelectedValue = Nothing, 0, cmbChantier.SelectedValue)

      cmd.ExecuteNonQuery()

      Me.Close()

    Catch Ex As Exception
      MessageBox.Show(My.Resources.Global_ErreurbtnValider & Ex.Message)
    End Try
  End Sub

  Private Function VerifChiffrage(ByVal NCANNUM As Integer, ByVal nbMO As Integer, ByVal TotCmdFO As Integer, ByVal TotCST As Integer) As Boolean

    Try

      Dim bVerif As Boolean = True

      Dim cmdVerif As New SqlCommand("api_sp_ChantierVerifCreateChifCAN", MozartDatabase.cnxMozart)
      cmdVerif.CommandType = CommandType.StoredProcedure

      cmdVerif.Parameters.Add("@iNCANNUM", SqlDbType.Int)
      cmdVerif.Parameters("@iNCANNUM").Value = NCANNUM

      cmdVerif.Parameters.Add("@mo", SqlDbType.Int)
      cmdVerif.Parameters("@mo").Value = nbMO

      cmdVerif.Parameters.Add("@fo", SqlDbType.Int)
      cmdVerif.Parameters("@fo").Value = TotCmdFO

      cmdVerif.Parameters.Add("@stt", SqlDbType.Int)
      cmdVerif.Parameters("@stt").Value = TotCST

      Dim drVerif As SqlDataReader = cmdVerif.ExecuteReader

      If drVerif.HasRows = True Then

        drVerif.Read()

        If drVerif.Item("TOTMO") < 0 Then
          MessageBox.Show(My.Resources.Global_NbrHeures + drVerif.Item("TOTMO").ToString + ")")
          bVerif = False
        End If

        If drVerif.Item("TOTFO") < 0 Then
          MessageBox.Show(My.Resources.Global_MontantFournitures + drVerif.Item("TOTFO").ToString + ")")
          bVerif = False
        End If

        If drVerif.Item("TOTSTT") < 0 Then
          MessageBox.Show(My.Resources.Global_MontantHeures + drVerif.Item("TOTSTT").ToString + ")")
          bVerif = False
        End If

      End If

      drVerif.Close()

      Return bVerif

    Catch ex As Exception
      MessageBox.Show("VerifChiffrage " + ex.Message, My.Resources.Global_Erreur, MessageBoxButtons.OK, MessageBoxIcon.Error)
      Return False
    End Try

  End Function

  Private Function VerifProrata(ByVal p_ncannum As Integer, ByVal p_iIdChif As Integer) As Boolean

    Try

      Dim dr As SqlDataReader
      Dim bVerifProrata As Boolean = False

      cmd = New SqlCommand("api_sp_ChantierVerifProrataChifBytaux", MozartDatabase.cnxMozart)
      cmd.CommandType = CommandType.StoredProcedure
      cmd.Parameters.Add("@p_NCANNUM", SqlDbType.Int)
      cmd.Parameters("@p_NCANNUM").Value = p_ncannum

      cmd.Parameters.Add("@p_IdChif", SqlDbType.Int)
      cmd.Parameters("@p_IdChif").Value = p_iIdChif

      dr = cmd.ExecuteReader
      If dr.HasRows = True Then

        dr.Read()

        If dr("TESTISOK") = 1 Then

          If dr("TXPRORATACHIFFRAGE") = dr("TXPRORATACHANTIER") Then

            bVerifProrata = True

          Else

            Dim sMsg As String = My.Resources.Admin_frmValidation_AffectationChiffrage + vbCrLf + My.Resources.Admin_frmValidation_Compte_prorata0 + vbCrLf + My.Resources.Admin_frmValidation_Compte_prorata1
            MessageBox.Show(String.Format(sMsg, dr("TXPRORATACHANTIER"), dr("TXPRORATACHIFFRAGE")), "Information", MessageBoxButtons.OK, MessageBoxIcon.Information)
            bVerifProrata = False

          End If

        Else

          bVerifProrata = False

        End If

      Else

        bVerifProrata = False

      End If
      If dr.IsClosed = False Then dr.Close()

      Return bVerifProrata

    Catch ex As Exception

      MessageBox.Show("VerifProrata : " + ex.Message, My.Resources.Global_Erreur, MessageBoxButtons.OK, MessageBoxIcon.Error)
      Return False

    End Try

  End Function

End Class