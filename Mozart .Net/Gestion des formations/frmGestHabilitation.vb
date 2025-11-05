
Imports System.Data.SqlClient
Imports MozartLib
Imports ReportEmalec.Net

Public Class frmGestHabilitation

  Dim iNumForm As Integer
  Dim oGestConnectSQL As New CGestionSQL

  Dim bDateChanging As Boolean
  Dim bLoaded As Boolean

  Public Sub New(Optional ByVal c_iNumForm As Integer = Nothing)

    ' Cet appel est requis par le concepteur.
    InitializeComponent()

    ' Ajoutez une initialisation quelconque après l'appel InitializeComponent().
    iNumForm = c_iNumForm
    bDateChanging = False

  End Sub

  Private Sub frmGestFormation_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load

    'init 
    bLoaded = True

    'on ouvre la connexion
    oGestConnectSQL.ConnexionSQL(MozartParams.NomServeur, MozartParams.NomSociete)

    RemplirCombo()

    If iNumForm <> 0 Then CboTech.SelectedValue = iNumForm
    bLoaded = False

  End Sub

  Private Sub CboTech_SelectedIndexChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles CboTech.SelectedIndexChanged

    'on vide les controles
    For Each D In PanelDate.Controls
      D.Format = DateTimePickerFormat.Custom
      D.CustomFormat = " "
      D.Checked = False
      D.Text = ""
    Next

    For Each C In GroupBox1.Controls
      If TypeOf C Is TextBox Then
        C.Text = ""
      End If
    Next

    ' on charge les donnees si on est en modification
    If CboTech.SelectedValue <> 0 Then
      Dim cmd As New SqlCommand("SELECT	* FROM TPERHABILITE WHERE NPERNUM = " & CboTech.SelectedValue, MozartDatabase.cnxMozart)
      cmd.CommandType = CommandType.Text

      Dim dr As SqlDataReader = cmd.ExecuteReader
      If dr.HasRows = True Then
        dr.Read()
        For Each DT In PanelDate.Controls
          If dr(DT.Name).ToString = "" Then
            DT.Format = DateTimePickerFormat.Custom
            DT.CustomFormat = " "
            DT.Checked = False
          Else
            DT.Text = dr(DT.Name).ToString
            DT.CustomFormat = "dd/MM/yyyy"
          End If
        Next DT

        For Each T In GroupBox1.Controls
          If TypeOf T Is TextBox Then
            T.Text = dr(T.Name).ToString
          End If
        Next T
      End If
      dr.Close()
    End If
  End Sub

  Private Sub Date_CloseUp(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles DATEVALID.CloseUp, DATEREV1.CloseUp, DATEREV2.CloseUp, DATEEMI.CloseUp
    sender.Format = DateTimePickerFormat.Custom
    sender.CustomFormat = "dd/MM/yyyy"
  End Sub

  Private Function IsVerifChampOK() As Boolean
    If CboTech.SelectedValue = 0 Then
      CboTech.BackColor = Color.Yellow
      Return False
    End If
    Return True
  End Function

  Private Sub BtnCreate_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles BtnCreate.Click

    If IsVerifChampOK() = True Then

      Dim sqlcmdCreateForm As New SqlCommand("api_sp_CreationHabilitation", oGestConnectSQL.CnxSQLOpen)
      sqlcmdCreateForm.CommandType = CommandType.StoredProcedure
      sqlcmdCreateForm.Parameters.Add("@p_NPERNUM", SqlDbType.Int)
      sqlcmdCreateForm.Parameters("@p_NPERNUM").Value = CboTech.SelectedValue
      sqlcmdCreateForm.Parameters.Add("@p_DATEEMI", SqlDbType.VarChar)
      sqlcmdCreateForm.Parameters("@p_DATEEMI").Value = IIf(DATEEMI.Checked, DATEEMI.Text.ToString, DBNull.Value)
      sqlcmdCreateForm.Parameters.Add("@p_DATEVALID", SqlDbType.VarChar)
      sqlcmdCreateForm.Parameters("@p_DATEVALID").Value = IIf(DATEVALID.Checked, DATEVALID.Text.ToString, DBNull.Value)
      sqlcmdCreateForm.Parameters.Add("@p_DATEREV1", SqlDbType.VarChar)
      sqlcmdCreateForm.Parameters("@p_DATEREV1").Value = IIf(DATEREV1.Checked, DATEREV1.Text.ToString, DBNull.Value)
      sqlcmdCreateForm.Parameters.Add("@p_DATEREV2", SqlDbType.VarChar)
      sqlcmdCreateForm.Parameters("@p_DATEREV2").Value = IIf(DATEREV2.Checked, DATEREV2.Text.ToString, DBNull.Value)
      For Each C In GroupBox1.Controls
        If TypeOf C Is TextBox Then
          sqlcmdCreateForm.Parameters.Add(C.Name, SqlDbType.VarChar)
          sqlcmdCreateForm.Parameters(C.Name).Value = C.Text
        End If
      Next

      sqlcmdCreateForm.ExecuteNonQuery()

      If TAB1.Modified = True Or TAB2.Modified = True Or TAB4.Modified = True Or TAB5.Modified = True Or TAB7.Modified = True Or TAB8.Modified = True Or
          TAB10.Modified = True Or TAB10.Modified = True Or TAB11.Modified = True Or TAB13.Modified = True Or TAB14.Modified = True Or TAB16.Modified = True Or
          TAB17.Modified = True Or TAB19.Modified = True Or TAB20.Modified = True Or TAB22.Modified = True Or TAB23.Modified = True Or bDateChanging = True Then


        If MessageBox.Show(My.Resources.GestionDesFormation_frmGestHabilitation_modif, "", MessageBoxButtons.YesNo, MessageBoxIcon.Question) = Windows.Forms.DialogResult.Yes Then

          Dim sqlcmdUpdate As New SqlCommand("[api_sp_CarteHabilApprouveMAJ]", MozartDatabase.cnxMozart)
          sqlcmdUpdate.CommandType = CommandType.StoredProcedure
          sqlcmdUpdate.Parameters.Add("@p_NPERNUM", SqlDbType.Int).Value = CboTech.SelectedValue
          sqlcmdUpdate.ExecuteNonQuery()

        End If

      End If

    Else
      MessageBox.Show(My.Resources.GestionDesFormation_frmGestHabilitation_choix_emp, My.Resources.Global_erreur_creation, MessageBoxButtons.OK, MessageBoxIcon.Information)
    End If
  End Sub

  Private Sub RemplirCombo()

    Dim ssql As String = "SELECT 0 NPERNUM, '' VPERNOM UNION SELECT NPERNUM, VPERNOM + ' ' + VPERPRE FROM TPER WITH (NOLOCK) WHERE CPERACTIF = 'O' AND BUTILISATEUR=0 AND VSOCIETE = '" & MozartParams.NomSociete & "' ORDER BY VPERNOM"

    Dim dtPer As New DataTable
    Dim dsper As SqlDataAdapter = New SqlDataAdapter(ssql, oGestConnectSQL.CnxSQLOpen)

    Try
      CboTech.Items.Clear()
      dsper.Fill(dtPer)
      CboTech.DataSource = dtPer

    Catch Ex As Exception
      MessageBox.Show(My.Resources.GestionDesFormation_frmGestFormation_erreur & Ex.Message)
    End Try

  End Sub

  Private Sub BtnCancel_Click_1(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles BtnCancel.Click
    oGestConnectSQL.CloseConnexionSQL()
    Me.Close()
  End Sub

  Private Sub Button1_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button1.Click

    If CboTech.SelectedValue <> 0 Then

      'Shell(System.Environment.GetFolderPath(System.Environment.SpecialFolder.ProgramFilesX86) & "\MOZART\ReportEmalec.Net.exe " & """TCARTE;" & CboTech.SelectedValue.ToString & ";;" & gstrNomSociete & ";FR;PREVIEW""", vbNormalFocus)
      Dim lFrmMainReport As New frmMainReport With {
        .bLaunchByProcessStart = False,
        .sTypeReport = "TCARTE",
        .sIdentifiant = CboTech.SelectedValue.ToString,
        .InfosMail = "",
        .sNomSociete = MozartParams.NomSociete,
        .sLangue = "FR",
        .sOption = "PREVIEW",
        .strType = ""
      }
      lFrmMainReport.ShowDialog()

      'Dim oDoc As New CGenDoc("Carte_Habilitation", String.Format("api_sp_ImpCarteHabilitation {0}, '{1}', '{2}'", CboTech.SelectedValue.ToString, gstrNomSociete, sFileOut_CreateSignTechForVisu()))
      '      If oDoc.p_ERROR = "" Then
      '          Dim ofrmVisuFic As New frmVisuDoc(oDoc.p_PathFileName)
      '          ofrmVisuFic.ShowDialog()
      '      End If

    Else
      MessageBox.Show(My.Resources.GestionDesFormation_frmGestHabilitation_select_emp, My.Resources.Global_Erreur, MessageBoxButtons.OK, MessageBoxIcon.Information)
    End If
  End Sub

  Private Sub DATEVALID_ValueChanged(sender As System.Object, e As System.EventArgs) Handles DATEVALID.ValueChanged, DATEEMI.ValueChanged
    If bLoaded = False Then bDateChanging = True
  End Sub

  Private Sub DATEREV1_ValueChanged(sender As System.Object, e As System.EventArgs) Handles DATEREV1.ValueChanged
    If bLoaded = False Then bDateChanging = True
  End Sub

  Private Sub DATEREV2_ValueChanged(sender As System.Object, e As System.EventArgs) Handles DATEREV2.ValueChanged
    If bLoaded = False Then bDateChanging = True
  End Sub

  '*******************************************************************************************
  'Permet de creer une image temporaire pour la visu de la signature
  '*******************************************************************************************
  Private Function sFileOut_CreateSignTechForVisu() As String

    Dim sFileNameReturn As String = ""

    Try

      Dim sqlcmdLoad As New SqlCommand("api_sp_CarteHabilCreateSignature", MozartDatabase.cnxMozart)
      sqlcmdLoad.CommandType = CommandType.StoredProcedure
      sqlcmdLoad.Parameters.Add("@p_NPERNUM", SqlDbType.Int).Value = CboTech.SelectedValue
      sqlcmdLoad.Parameters.Add("@p_VSOCIETE", SqlDbType.VarChar).Value = MozartParams.NomSociete

      Dim drLoad As SqlDataReader = sqlcmdLoad.ExecuteReader()
      If drLoad.HasRows Then

        drLoad.Read()
        Dim tab1() As Byte = drLoad("ICARTEHABILSIGNIMG")
        Dim fs As New FileStream(drLoad("PATHFILETMP").ToString, FileMode.Create, FileAccess.Write, FileShare.Write)
        fs.Write(tab1, 0, tab1.Length)
        fs.Flush()
        fs.Close()

        Dim myBitmap As New Bitmap(drLoad("PATHFILETMP").ToString)
        Dim myBitmap2 As New Bitmap(myBitmap, New Size(150, 80))
        myBitmap2.Save(drLoad("PATHFILE").ToString, ImageFormat.Jpeg)

        myBitmap.Dispose()
        myBitmap2.Dispose()

        sFileNameReturn = drLoad("PATHFILE").ToString

        If File.Exists(drLoad("PATHFILETMP").ToString) = True Then File.Delete(drLoad("PATHFILETMP").ToString)

      End If
      drLoad.Close()

      If File.Exists(sFileNameReturn) = True Then
        Return sFileNameReturn
      Else
        Return ""
      End If

    Catch ex As Exception
      Return ""
    End Try


  End Function

End Class