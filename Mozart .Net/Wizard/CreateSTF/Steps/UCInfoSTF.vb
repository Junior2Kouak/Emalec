Imports System.Data.SqlClient
Imports MozartLib

Public Class UCInfoSTF

  Dim DTVilleInit As DataTable
  Dim DTVilleSearch As DataTable
  Dim DTPays As DataTable

  Dim DTStatutSoc As DataTable

  Dim Sqlcmd As SqlCommand
  Dim oTxtVILLE As TextBox

  Public ReadOnly Property _TxtVILLE As TextBox
    Get
      Return oTxtVILLE
    End Get
  End Property

  Private Sub UCInfoSTF_Load(sender As System.Object, e As System.EventArgs) Handles MyBase.Load

    'Init
    LoadDataCbo()

    'creation d'un champ texte pour le nom de la ville à l étranger
    oTxtVILLE = New TextBox
    oTxtVILLE.Font = GridSTFVille.Font
    oTxtVILLE.TextAlign = HorizontalAlignment.Left
    oTxtVILLE.Size = GridSTFVille.Size
    oTxtVILLE.Location = GridSTFVille.Location
    oTxtVILLE.Visible = False
    oTxtVILLE.Text = ""
    oTxtVILLE.TabIndex = GridSTFVille.TabIndex

    AddHandler oTxtVILLE.TextChanged, AddressOf TxtVILLE_TextChanged
    AddHandler oTxtVILLE.LostFocus, AddressOf TxtVILLE_LostFocus

    Me.Controls.Add(oTxtVILLE)

    'par défaut sélection pays france
    If MozartParams.NomSociete = "EMALECESPAGNE" Then
      If DTPays.Rows.Count > 0 Then GridSTFPays.EditValue = 3
    Else
      If DTPays.Rows.Count > 0 Then GridSTFPays.EditValue = 1
    End If

    'focus
    TxtSTFNom.Focus()

  End Sub

  Private Sub LoadDataCbo()

    DTVilleInit = New DataTable
    Sqlcmd = New SqlCommand("SELECT TCOMMUNE.CODEPOSTAL, TCOMMUNE.VILLE FROM TCOMMUNE WITH(NOLOCK) ORDER BY VILLE", MozartDatabase.cnxMozart)
    Sqlcmd.CommandType = CommandType.Text
    DTVilleInit.Load(Sqlcmd.ExecuteReader)

    GridSTFVille.Properties.DataSource = DTVilleInit

    DTPays = New DataTable
    Sqlcmd = New SqlCommand("SELECT NPAYSNUM, VPAYSNOM From TPAYS ORDER BY VPAYSNOM", MozartDatabase.cnxMozart)
    Sqlcmd.CommandType = CommandType.Text
    DTPays.Load(Sqlcmd.ExecuteReader)

    GridSTFPays.Properties.DataSource = DTPays

    DTStatutSoc = New DataTable

    Sqlcmd = New SqlCommand("SELECT ID, VLIBSTATUT FROM TREF_STATUT ORDER BY VLIBSTATUT", MozartDatabase.cnxMozart)
    Sqlcmd.CommandType = CommandType.Text
    DTStatutSoc.Load(Sqlcmd.ExecuteReader)

    GridSTFStatutSoc.Properties.DataSource = DTStatutSoc

  End Sub

  Private Sub TxtVILLE_LostFocus(sender As Object, e As System.EventArgs)
    oTxtVILLE.Text = oTxtVILLE.Text.ToUpper
  End Sub

  Private Sub TxtVILLE_TextChanged(sender As System.Object, e As System.EventArgs)
    If oTxtVILLE.Text <> "" Then oTxtVILLE.BackColor = Color.White
  End Sub

  Private Sub TxtVSTFCP_TextChanged(sender As System.Object, e As System.EventArgs) Handles TxtVSTFCP.TextChanged

    If TxtVSTFCP.Text <> "" Then TxtVSTFCP.BackColor = Color.White

    'PAYS = FRANCE
    If GridSTFPays.EditValue = 1 Then

      DTVilleSearch = New DataTable
      If DTVilleInit.Select(String.Format("CODEPOSTAL LIKE '{0}%'", TxtVSTFCP.Text.Replace("'", "''")), "VILLE").Count > 0 Then
        DTVilleSearch = DTVilleInit.Select(String.Format("CODEPOSTAL LIKE '{0}%'", TxtVSTFCP.Text.Replace("'", "''")), "VILLE").CopyToDataTable()
      Else
        MessageBox.Show(My.Resources.WizardSTF_UCInfoSTF_Expr1, My.Resources.WizardSTF_UCInfoSTF_Expr2, MessageBoxButtons.OK, MessageBoxIcon.Exclamation)
        Exit Sub
      End If

      GridSTFVille.Properties.DataSource = DTVilleSearch

      If TxtVSTFCP.Text <> "" And DTVilleSearch.Rows.Count > 0 Then GridSTFVille.EditValue = GridSTFVille.Properties.GetKeyValue(0)
      If TxtVSTFCP.Text = "" Then GridSTFVille.EditValue = Nothing

    Else

      GridSTFVille.Properties.DataSource = Nothing

    End If

  End Sub

  Private Sub TxtSTFNom_EditValueChanged(sender As System.Object, e As System.EventArgs) Handles TxtSTFNom.EditValueChanged

    If TxtSTFNom.Text <> "" Then TxtSTFNom.BackColor = Color.White : TxtSTFNom.Text = TxtSTFNom.Text.ToUpper

  End Sub

  Private Sub GVVille_RowClick(sender As Object, e As DevExpress.XtraGrid.Views.Grid.RowClickEventArgs) Handles GVVille.RowClick
    If e.Button = Windows.Forms.MouseButtons.Left Then

      Dim DRVILLE As DataRow = GVVille.GetDataRow(e.RowHandle)

      TxtVSTFCP.Text = DRVILLE.Item("CODEPOSTAL")

    End If
  End Sub

  Private Sub GridSTFVille_EditValueChanged(sender As System.Object, e As System.EventArgs) Handles GridSTFVille.EditValueChanged
    If GridSTFVille.Text <> "" Then GridSTFVille.BackColor = Color.White
  End Sub

  Private Sub GridSTFPays_EditValueChanged(sender As System.Object, e As System.EventArgs) Handles GridSTFPays.EditValueChanged

    If GridSTFPays.EditValue = 1 Then

      GridSTFVille.Visible = True
      oTxtVILLE.Visible = False

    Else

      GridSTFVille.Visible = False
      oTxtVILLE.Visible = True

    End If

  End Sub

  Private Sub GridSTFStatutSoc_EditValueChanged(sender As System.Object, e As System.EventArgs) Handles GridSTFStatutSoc.EditValueChanged

    GridSTFStatutSoc.BackColor = Color.White

    'si auto entrepreneur = 36500  modif du  04/03/2021 mail barbosa de 70000 à 36500
    If GridSTFStatutSoc.EditValue = 2 Then
      TxtSTFCA.Text = "36500"
      TxtSTFCA.Enabled = False
    Else

      TxtSTFCA.Enabled = True
      If TxtSTFCA.Text = "36500" Then
        TxtSTFCA.Text = ""
      End If

    End If

  End Sub

  Private Sub TxtVSTFCPCedex_LostFocus(sender As Object, e As System.EventArgs) Handles TxtVSTFCPCedex.LostFocus

    If TxtVSTFCPCedex.Text <> "" And TxtVSTFCEDEX.Text = "" Then TxtVSTFCEDEX.Text = My.Resources.WizardSTF_UCInfoSTF_Expr3 & " "

  End Sub

  Private Sub TxtSTFCA_EditValueChanged(sender As System.Object, e As System.EventArgs) Handles TxtSTFCA.EditValueChanged
    If TxtSTFCA.Text <> "" Then TxtSTFCA.BackColor = Color.White
  End Sub

  Private Sub TxtSTFSIRET_TextChanged(sender As System.Object, e As System.EventArgs) Handles TxtSTFSIRET.TextChanged
    If TxtSTFSIRET.Text <> "" Then TxtSTFSIRET.BackColor = Color.White
  End Sub

  Private Sub TxtSTFNom_KeyPress(sender As Object, e As System.Windows.Forms.KeyPressEventArgs) Handles TxtSTFNom.KeyPress

    ' Ajout du 14/12/2016 par NL : On interdit un nom commençant par un espace :
    If TxtSTFNom.Text = "" And e.KeyChar = " " Then e.Handled = True

    ' On interdit également la saisie de ' " - . et _
    If e.KeyChar = "'" Or e.KeyChar = """" Or e.KeyChar = "-" Or e.KeyChar = "." Or e.KeyChar = "_" Then e.Handled = True

  End Sub

  Private Sub TxtSTFNom_Validated(sender As Object, e As System.EventArgs) Handles TxtSTFNom.Validated

    Dim lNewText As String

    lNewText = Regex.Replace(TxtSTFNom.Text, "['"" \-_.]", " ").Trim()
    If lNewText <> TxtSTFNom.Text Then
      TxtSTFNom.Text = lNewText
      TxtSTFNom.Focus()
    End If

    ''  14/12/2016, NL 
    'If TxtSTFNom.Text.StartsWith(" ") Then
    '  TxtSTFNom.Text = Mid(TxtSTFNom.Text, 2)
    '  TxtSTFNom.Focus()
    'End If

    'If TxtSTFNom.Text.Contains("'") Then
    '  TxtSTFNom.Text = TxtSTFNom.Text.Replace("'", " ")
    '  TxtSTFNom.Focus()
    'End If

    'If TxtSTFNom.Text.Contains("""") Then
    '  TxtSTFNom.Text = TxtSTFNom.Text.Replace("""", " ")
    '  TxtSTFNom.Focus()
    'End If

    'If TxtSTFNom.Text.Contains("-") Then
    '  TxtSTFNom.Text = TxtSTFNom.Text.Replace("-", " ")
    '  TxtSTFNom.Focus()
    'End If

    'If TxtSTFNom.Text.Contains("_") Then
    '  TxtSTFNom.Text = TxtSTFNom.Text.Replace("_", " ")
    '  TxtSTFNom.Focus()
    'End If

    'If TxtSTFNom.Text.Contains(".") Then
    '  TxtSTFNom.Text = TxtSTFNom.Text.Replace(".", " ")
    '  TxtSTFNom.Focus()
    'End If

  End Sub
End Class
