Imports System.Data.SqlClient
Imports MozartLib

Public Class frmCptAnaAffectSelect

  Private sTypeAffectation As String
  Private drTabSelect() As DataRow
  Private iOldPers As Integer

  Private dtCbo As DataTable
  Private bCancel As Boolean

  Public Sub New(c_sTypeAffectation As String, c_drTabSelect() As DataRow, i_OldPers As Integer)
    InitializeComponent()

    sTypeAffectation = c_sTypeAffectation
    drTabSelect = c_drTabSelect
    iOldPers = i_OldPers
    bCancel = False
  End Sub

  Public ReadOnly Property Cancel As Boolean
    Get
      Cancel = bCancel
    End Get
  End Property

  Private Sub frmCptAnaAffectSelect_Load(sender As Object, e As EventArgs) Handles MyBase.Load
    Dim drOldPers As SqlDataReader
    Dim sNameChamp As String

    Try
      Select Case sTypeAffectation
        Case "ASS"
          Me.Text = My.Resources.Admin_frmCptAnaAffectSelect_choixAssistant
          LblTitre.Text = My.Resources.Admin_frmCptAnaAffectSelect_choixAssistant
          sNameChamp = "NPERNUMASS"

        Case "ASSCHAFF"
          Me.Text = My.Resources.Admin_frmCptAnaAffectSelect_choixAssistant
          LblTitre.Text = My.Resources.Admin_frmCptAnaAffectSelect_choixAssistant
          sNameChamp = "NPERNUMASSCHAFF"

        Case "CHAFF"
          Me.Text = My.Resources.Admin_frmCptAnaAffectSelect_choixAffaire
          LblTitre.Text = My.Resources.Admin_frmCptAnaAffectSelect_choixAffaire
          sNameChamp = "NPERNUM"

        Case "FAC"
          Me.Text = My.Resources.Admin_frmCptAnaAffectSelect_choixFacturière
          LblTitre.Text = My.Resources.Admin_frmCptAnaAffectSelect_choixFacturière
          sNameChamp = "NPERNUMFACT"

        Case Else
          sNameChamp = ""
      End Select

      If iOldPers <> 0 Then
        drOldPers = MozartDatabase.ExecuteReader($"SELECT VPERNOM + ' ' + VPERPRE AS NOM FROM TPER WITH (NOLOCK) WHERE NPERNUM = {iOldPers}")
        drOldPers.Read()
        lblOld.Text = drOldPers.GetValue(0).ToString
        drOldPers.Close()
        drOldPers = Nothing
      Else
        lblOld.Text = My.Resources.Admin_frmCptAnaAffectSelect_enregistrement
      End If
      LoadCombo(sNameChamp)

    Catch ex As Exception
      MessageBox.Show("", My.Resources.Global_Erreur, MessageBoxButtons.OK, MessageBoxIcon.Error)
    End Try
  End Sub

  Private Sub LoadCombo(sNameChamp As String)
    dtCbo = New DataTable

    dtCbo.Load(MozartDatabase.ExecuteReader($"api_sp_ListePersonnelParType '{sTypeAffectation}'"))

    CboAffect.DataSource = dtCbo
    CboAffect.SelectedValue = drTabSelect(0).Item(sNameChamp)
  End Sub

  Private Sub BtnValidate_Click(sender As Object, e As EventArgs) Handles BtnValidate.Click
    Dim sqlcmdUpdate As SqlCommand
    Dim Msg As String

    If CboAffect.SelectedValue IsNot Nothing Then

      Cursor.Current = Cursors.WaitCursor

      Select Case sTypeAffectation

        Case "ASS", "ASSCHAFF"
          Msg = My.Resources.Admin_frmCptAnaAffectSelect_AttentionA & " " & lblOld.Text & " " & My.Resources.Global_Par & " " & CboAffect.Text & " " & My.Resources.Admin_frmCptAnaAffectSelect_SurLesClient
        Case "FAC"
          Msg = My.Resources.Admin_frmCptAnaAffectSelect_AttentionF & " " & lblOld.Text & " " & My.Resources.Global_Par & " " & CboAffect.Text & " " & My.Resources.Admin_frmCptAnaAffectSelect_SurLesClient
        Case Else
          'pour les chaff
          Msg = My.Resources.Admin_frmCptAnaAffectSelect_AttentionAf & " " & lblOld.Text & " " & My.Resources.Global_Par & " " & CboAffect.Text & " " & My.Resources.Admin_frmGestCompteCli_SurLesComptes
      End Select

      If MessageBox.Show(Msg, My.Resources.Global_Affectation, MessageBoxButtons.YesNoCancel, MessageBoxIcon.Question) = Windows.Forms.DialogResult.Yes Then
        sqlcmdUpdate = New SqlCommand("api_sp_CompteAnalytiqueAffectationGenerique", MozartDatabase.cnxMozart) With {
          .CommandType = CommandType.StoredProcedure
        }
        sqlcmdUpdate.Parameters.Clear()
        'declaration des parametres
        sqlcmdUpdate.Parameters.Add("@P_NCLINUM", SqlDbType.Int)
        sqlcmdUpdate.Parameters.Add("@P_NCANNUM", SqlDbType.Int)
        sqlcmdUpdate.Parameters.Add("@P_NPERNUM", SqlDbType.Int)
        sqlcmdUpdate.Parameters.Add("@P_NPERNUM_OLD", SqlDbType.Int)
        sqlcmdUpdate.Parameters.Add("@P_VTYPEAFFECT", SqlDbType.VarChar)
        For i = 0 To drTabSelect.Length - 1
          sqlcmdUpdate.Parameters("@P_NCLINUM").Value = drTabSelect(i).Item("NCLINUM")
          sqlcmdUpdate.Parameters("@P_NCANNUM").Value = drTabSelect(i).Item("NCANNUM")
          sqlcmdUpdate.Parameters("@P_NPERNUM").Value = CboAffect.SelectedValue
          sqlcmdUpdate.Parameters("@P_NPERNUM_OLD").Value = iOldPers
          sqlcmdUpdate.Parameters("@P_VTYPEAFFECT").Value = sTypeAffectation
          sqlcmdUpdate.ExecuteNonQuery()
        Next
      End If

      Cursor.Current = Cursors.Default

      Close()
    End If
  End Sub

  Private Sub BtnCancel_Click(sender As Object, e As EventArgs) Handles BtnCancel.Click
    bCancel = True

    Close()
  End Sub

End Class