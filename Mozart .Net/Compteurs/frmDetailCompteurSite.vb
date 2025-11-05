
Imports System.Data.SqlClient
Imports System.Reflection.MethodBase
Imports MozartLib

Public Class frmDetailCompteurSite

  Private dtL As DataTable = New DataTable()
  Dim dtCbo As DataTable
  Dim iNSITNUM As Int32
  Dim iNCOMPTNUM As Int32


  Public Sub New(ByVal c_iNSITNUM As Object, ByVal c_iNCOMPTNUM As Object)

    ' Cet appel est requis par le concepteur.
    InitializeComponent()

    ' Ajoutez une initialisation quelconque après l'appel InitializeComponent().
    iNSITNUM = Convert.ToInt32(c_iNSITNUM)
    iNCOMPTNUM = Convert.ToInt32(c_iNCOMPTNUM)

  End Sub

  Private Sub frmDetailCompteurSite_Load(sender As Object, e As EventArgs) Handles MyBase.Load


    ModuleMain.Initboutons(Me)

    LblTitre.Text = LblTitre.Text & RechercheNomDuSite()

    ' chargement de la combo type
    LoadComboType()

    ' ouverture en modification ou en création
    If iNCOMPTNUM = 0 Then
      txtNom.Text = ""
      txtRemarque.Text = ""
      txtNumero.Text = ""
      txtEmplacement.Text = ""
      txtDate.Text = Now.ToString("dd/MM/yyyy")

    Else
      OuvertureEnModification()
    End If

  End Sub

  Private Sub OuvertureEnModification()


    Dim dr As SqlDataReader
    Dim CmdSql

    Try

      Cursor = Cursors.WaitCursor

      ' Données générales
      CmdSql = New SqlCommand("SELECT * FROM	TCOMPTEURSITE WHERE	NCOMPTID = " & iNCOMPTNUM.ToString, MozartDatabase.cnxMozart)

      dr = CmdSql.ExecuteReader

      If dr.HasRows = True Then
        dr.Read()
        cboType.SelectedIndex = dr("NINFONUM").ToString
        txtNom.Text = dr("VCOMPTNOM").ToString
        txtRemarque.Text = dr("VCOMPTOBS").ToString
        txtNumero.Text = dr("VCOMPTNUM").ToString
        txtEmplacement.Text = dr("VCOMPTLIEU").ToString
        txtDate.Text = Convert.ToDateTime(dr("DCOMPTDATE")).ToString("dd/MM/yyyy")
        ChkCO2.Checked = (dr("CCOMPTCO2").ToString = "O")

        dr.Close()
        CmdSql.Dispose()

      End If

    Catch ex As Exception
      MessageBox.Show($"{My.Resources.Global_Erreur} : {ex.Message} {My.Resources.Global_dans} {GetCurrentMethod().Name} ({Me.GetType.Name})",
                        My.Resources.Global_Erreur, MessageBoxButtons.OK, MessageBoxIcon.Exclamation)
    Finally
      Cursor = Cursors.Default
      dr = Nothing
      CmdSql = Nothing
    End Try


  End Sub

  Private Sub LoadComboType()

    Dim sqlcmdCbo As SqlCommand
    dtCbo = New DataTable

    Try

      ' Type de compteur
      Dim sSQL As String = "SELECT NINFONUM, VINFOLIB FROM dbo.TREF_INFOTECH WHERE LANGUE='" & MozartParams.Langue & "'"

      sqlcmdCbo = New SqlCommand(sSQL, MozartDatabase.cnxMozart)
      sqlcmdCbo.CommandType = CommandType.Text
      dtCbo.Load(sqlcmdCbo.ExecuteReader)
      cboType.DataSource = dtCbo


    Catch ex As Exception
      MessageBox.Show($"{My.Resources.Global_Erreur} : {ex.Message} {My.Resources.Global_dans} {GetCurrentMethod().Name} ({Me.GetType.Name})",
                          My.Resources.Global_Erreur, MessageBoxButtons.OK, MessageBoxIcon.Exclamation)
    End Try
  End Sub


  Private Function RechercheNomDuSite() As String

    Dim sqlcmd As SqlCommand
    Dim dr As SqlDataReader

    Try
      RechercheNomDuSite = ""
      ' 
      ' recherche si le client est lié a un client pour cette société
      Dim SSQL As String = "SELECT VSITNOM FROM TSIT WHERE NSITNUM=" & iNSITNUM

      sqlcmd = New SqlCommand(SSQL, MozartDatabase.cnxMozart)
      sqlcmd.CommandType = CommandType.Text
      dr = sqlcmd.ExecuteReader()

      If dr.HasRows Then
        dr.Read()
        RechercheNomDuSite = dr("VSITNOM")
      End If

      dr.Close()
      sqlcmd.Dispose()

    Catch ex As Exception
      RechercheNomDuSite = ""
      MessageBox.Show($"{My.Resources.Global_Erreur} : {ex.Message} {My.Resources.Global_dans} {GetCurrentMethod().Name} ({Me.GetType.Name})",
                          My.Resources.Global_Erreur, MessageBoxButtons.OK, MessageBoxIcon.Exclamation)

    End Try
  End Function

  Private Sub cmdFermer_Click(sender As Object, e As EventArgs) Handles cmdFermer.Click
    Me.Close()
  End Sub

  Private Sub cmdValider_Click(sender As Object, e As EventArgs) Handles cmdValider.Click
    Dim Msg As String


    If txtNom.Text = "" Then
      Msg = "Il faut saisir un nom de compteur"
      MessageBox.Show(Msg, My.Resources.Global_Information, MessageBoxButtons.OK, MessageBoxIcon.Information)
      txtNom.Focus()
      Exit Sub
    End If

    ' Enregistrement
    Try

      Dim CmdSql As New SqlCommand("api_sp_CreationCompteur", MozartDatabase.cnxMozart) With {.CommandType = CommandType.StoredProcedure}

      CmdSql.Parameters.Add("@iNum", SqlDbType.Int).Value = iNCOMPTNUM
      CmdSql.Parameters.Add("@NumSite", SqlDbType.Int).Value = iNSITNUM
      CmdSql.Parameters.Add("@Nom", SqlDbType.VarChar).Value = txtNom.Text
      CmdSql.Parameters.Add("@Numero", SqlDbType.VarChar).Value = txtNumero.Text
      CmdSql.Parameters.Add("@Emplacement", SqlDbType.VarChar).Value = txtEmplacement.Text
      CmdSql.Parameters.Add("@Type", SqlDbType.Int).Value = cboType.SelectedValue
      CmdSql.Parameters.Add("@Rmq", SqlDbType.VarChar).Value = txtRemarque.Text
      CmdSql.Parameters.Add("@IDliaison", SqlDbType.VarChar).Value = txtIDliaison.Text
      CmdSql.Parameters.Add("@CO2", SqlDbType.VarChar).Value = IIf(ChkCO2.Checked, "O", "N")

      iNCOMPTNUM = CmdSql.ExecuteScalar
      CmdSql.Dispose()


    Catch ex As Exception
      MessageBox.Show($"{My.Resources.Global_Erreur} : {ex.Message} {My.Resources.Global_dans} {GetCurrentMethod().Name} ({Me.GetType.Name})",
                          My.Resources.Global_Erreur, MessageBoxButtons.OK, MessageBoxIcon.Exclamation)
    End Try

  End Sub
End Class