Imports System.Data.SqlClient
Imports MozartLib

Public Class UCSiteSTF


  Dim DTVilleInit As DataTable
  Dim DTVilleSearch As DataTable
  Dim DTPays As DataTable
  Dim DTLangue As DataTable
  Dim Sqlcmd As SqlCommand
  Dim oTxtVILLE As TextBox

  Public ReadOnly Property _TxtVILLE As TextBox
    Get
      Return oTxtVILLE
    End Get
  End Property

  Private Sub UCSiteSTF_Load(sender As System.Object, e As System.EventArgs) Handles MyBase.Load

    'Init
    LoadDataCbo()

    'creation d'un champ texte pour le nom de la ville à l étranger
    oTxtVILLE = New TextBox
    oTxtVILLE.Font = GridSITSTFVille.Font
    oTxtVILLE.TextAlign = HorizontalAlignment.Left
    oTxtVILLE.Size = GridSITSTFVille.Size
    oTxtVILLE.Location = GridSITSTFVille.Location
    oTxtVILLE.Visible = False
    oTxtVILLE.Text = ""
    oTxtVILLE.TabIndex = GridSITSTFVille.TabIndex

    AddHandler oTxtVILLE.TextChanged, AddressOf TxtVILLE_TextChanged
    AddHandler oTxtVILLE.LostFocus, AddressOf TxtVILLE_LostFocus

    Me.Controls.Add(oTxtVILLE)

    'focus
    TxtSiteSTFNom.Focus()

  End Sub

  Private Sub LoadDataCbo()

    DTVilleInit = New DataTable
    Sqlcmd = New SqlCommand("SELECT TCOMMUNE.CODEPOSTAL, TCOMMUNE.VILLE FROM TCOMMUNE WITH(NOLOCK) ORDER BY VILLE", MozartDatabase.cnxMozart)
    Sqlcmd.CommandType = CommandType.Text
    DTVilleInit.Load(Sqlcmd.ExecuteReader)

    GridSITSTFVille.Properties.DataSource = DTVilleInit

    DTPays = New DataTable
    Sqlcmd = New SqlCommand("SELECT NPAYSNUM, VPAYSNOM From TPAYS ORDER BY VPAYSNOM", MozartDatabase.cnxMozart)
    Sqlcmd.CommandType = CommandType.Text
    DTPays.Load(Sqlcmd.ExecuteReader)

    GridSITSTFPays.Properties.DataSource = DTPays

    DTLangue = New DataTable
    Sqlcmd = New SqlCommand("SELECT DISTINCT VLANGUEDEFAUT, VLANGUEABR FROM TPAYS ORDER BY VLANGUEDEFAUT", MozartDatabase.cnxMozart)
    Sqlcmd.CommandType = CommandType.Text
    DTLangue.Load(Sqlcmd.ExecuteReader)

    GridSITSTFLangue.Properties.DataSource = DTLangue

  End Sub

  Private Sub TxtVILLE_TextChanged(sender As System.Object, e As System.EventArgs)
    If oTxtVILLE.Text <> "" Then oTxtVILLE.BackColor = Color.White
  End Sub

  Private Sub GridSITSTFPays_EditValueChanged(sender As System.Object, e As System.EventArgs) Handles GridSITSTFPays.EditValueChanged

    If GridSITSTFPays.EditValue = 1 Then

      GridSITSTFVille.Visible = True
      oTxtVILLE.Visible = False

    Else

      GridSITSTFVille.Visible = False
      oTxtVILLE.Visible = True

    End If

  End Sub

  Private Sub TxtVILLE_LostFocus(sender As Object, e As System.EventArgs)
    oTxtVILLE.Text = oTxtVILLE.Text.ToUpper
  End Sub

  Private Sub TxtVSITSTFCPCedex_LostFocus(sender As Object, e As System.EventArgs) Handles TxtVSITSTFCPCedex.LostFocus

    If TxtVSITSTFCPCedex.Text <> "" And TxtVSITSTFCEDEX.Text = "" Then TxtVSITSTFCEDEX.Text = My.Resources.WizardSTF_UCInfoSTF_Expr3 & " "

  End Sub

  Private Sub TxtVSITSTFCP_TextChanged(sender As System.Object, e As System.EventArgs) Handles TxtVSITSTFCP.TextChanged

    If TxtVSITSTFCP.Text <> "" Then TxtVSITSTFCP.BackColor = Color.White

    'PAYS = FRANCE
    If GridSITSTFPays.EditValue = 1 Then

      DTVilleSearch = New DataTable
      If DTVilleInit.Select(String.Format("CODEPOSTAL LIKE '{0}%'", TxtVSITSTFCP.Text.Replace("'", "''")), "VILLE").Count > 0 Then
        DTVilleSearch = DTVilleInit.Select(String.Format("CODEPOSTAL LIKE '{0}%'", TxtVSITSTFCP.Text.Replace("'", "''")), "VILLE").CopyToDataTable()
      Else
        MessageBox.Show(My.Resources.WizardSTF_UCInfoSTF_Expr1, My.Resources.WizardSTF_UCInfoSTF_Expr2, MessageBoxButtons.OK, MessageBoxIcon.Exclamation)
        Exit Sub
      End If

      GridSITSTFVille.Properties.DataSource = DTVilleSearch

      If TxtVSITSTFCP.Text <> "" And DTVilleSearch.Rows.Count > 0 Then GridSITSTFVille.EditValue = GridSITSTFVille.Properties.GetKeyValue(0)
      If TxtVSITSTFCP.Text = "" Then GridSITSTFVille.EditValue = Nothing

    Else

      GridSITSTFVille.Properties.DataSource = Nothing

    End If

  End Sub

  Private Sub TxtSiteSTFNom_EditValueChanged(sender As System.Object, e As System.EventArgs) Handles TxtSiteSTFNom.EditValueChanged
    If TxtSiteSTFNom.Text <> "" Then TxtSiteSTFNom.BackColor = Color.White : TxtSiteSTFNom.Text = TxtSiteSTFNom.Text.ToUpper
  End Sub

  Private Sub GVVille_RowClick(sender As Object, e As DevExpress.XtraGrid.Views.Grid.RowClickEventArgs) Handles GVVille.RowClick
    If e.Button = Windows.Forms.MouseButtons.Left Then

      Dim DRVILLE As DataRow = GVVille.GetDataRow(e.RowHandle)

      TxtVSITSTFCP.Text = DRVILLE.Item("CODEPOSTAL")

    End If
  End Sub

  Private Sub GridSITSTFVille_EditValueChanged(sender As System.Object, e As System.EventArgs) Handles GridSITSTFVille.EditValueChanged
    If GridSITSTFVille.Text <> "" Then GridSITSTFVille.BackColor = Color.White
  End Sub

  Private Sub TxtSiteSTFNom_KeyPress(sender As Object, e As System.Windows.Forms.KeyPressEventArgs) Handles TxtSiteSTFNom.KeyPress

    ' Ajout du 14/12/2016 par NL : On interdit un nom commençant par un espace :
    If TxtSiteSTFNom.Text = "" And e.KeyChar = " " Then e.Handled = True

    ' On interdit également la saisie de ' " - . et _
    If e.KeyChar = "'" Or e.KeyChar = """" Or e.KeyChar = "-" Or e.KeyChar = "." Or e.KeyChar = "_" Then e.Handled = True

  End Sub

  Private Sub TxtSiteSTFNom_Validated(sender As Object, e As System.EventArgs) Handles TxtSiteSTFNom.Validated

    Dim lNewText As String

    lNewText = Regex.Replace(TxtSiteSTFNom.Text, "['"" \-_.]", " ").Trim()
    If lNewText <> TxtSiteSTFNom.Text Then
      TxtSiteSTFNom.Text = lNewText
      TxtSiteSTFNom.Focus()
    End If

    ''  14/12/2016, NL 
    'If TxtSiteSTFNom.Text.StartsWith(" ") Then
    '  TxtSiteSTFNom.Text = Mid(TxtSiteSTFNom.Text, 2)
    '  TxtSiteSTFNom.Focus()
    'End If

    'If TxtSiteSTFNom.Text.Contains("'") Then
    '  TxtSiteSTFNom.Text = TxtSiteSTFNom.Text.Replace("'", " ")
    '  TxtSiteSTFNom.Focus()
    'End If

    'If TxtSiteSTFNom.Text.Contains("""") Then
    '  TxtSiteSTFNom.Text = TxtSiteSTFNom.Text.Replace("""", " ")
    '  TxtSiteSTFNom.Focus()
    'End If

    'If TxtSiteSTFNom.Text.Contains("-") Then
    '  TxtSiteSTFNom.Text = TxtSiteSTFNom.Text.Replace("-", " ")
    '  TxtSiteSTFNom.Focus()
    'End If

    'If TxtSiteSTFNom.Text.Contains("_") Then
    '  TxtSiteSTFNom.Text = TxtSiteSTFNom.Text.Replace("_", " ")
    '  TxtSiteSTFNom.Focus()
    'End If

    'If TxtSiteSTFNom.Text.Contains(".") Then
    '  TxtSiteSTFNom.Text = TxtSiteSTFNom.Text.Replace(".", " ")
    '  TxtSiteSTFNom.Focus()
    'End If

  End Sub

End Class
