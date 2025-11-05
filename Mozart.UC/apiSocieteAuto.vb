Imports System.Data.SqlClient
Imports System.Drawing
Imports MozartLib

Public Class apiSocieteAuto

  Private nIdMenuDroit As Short 'id du menu parent
  Private bCacheOneSociete As Short 'True = si une societe alors combo caché

  Public bFirstTime As Boolean ' Utilisé par le controle util. api_societeauto

  Public Shadows Event KeyDown(sender As Object, e As EventArgs)
  Public Shadows Event KeyPress(sender As Object, e As EventArgs)
  Public Shadows Event KeyUp(sender As Object, e As EventArgs)
  Public Shadows Event Click(sender As Object, e As EventArgs)
  Public Event Change(sender As Object, e As EventArgs)

  Private Sub Combo1_Change(sender As Object, e As EventArgs) Handles Combo1.TextChanged
    RaiseEvent Change(Me, e)
  End Sub

  Private Sub Combo1_Click(sender As Object, e As EventArgs) Handles Combo1.Click
    If bFirstTime = True Then Exit Sub
    RaiseEvent Click(Me, e)
  End Sub

  Private Sub Combo1_KeyDown(sender As Object, e As EventArgs) Handles Combo1.KeyDown
    RaiseEvent KeyDown(Me, e)
  End Sub

  Private Sub Combo1_KeyPress(sender As Object, e As EventArgs) Handles Combo1.KeyPress
    RaiseEvent KeyPress(Me, e)
  End Sub

  Private Sub Combo1_KeyUp(sender As Object, e As EventArgs) Handles Combo1.KeyUp
    RaiseEvent KeyUp(Me, e)
  End Sub

  Public Shadows Sub Refresh()
    Combo1.Refresh()
  End Sub

  Public Sub Clear()
    Combo1.ResetText()
  End Sub

  Public Sub Init(cnx As SqlConnection, Optional sNomSocDefault As String = "", Optional bGroupe As Boolean = True, Optional bOnlyFiliale As Boolean = False)

    If nIdMenuDroit = 0 Then Exit Sub

    Dim idef As Short
    Dim i As Short

    Dim lSqlReq = $"SELECT DISTINCT VSOCIETE FROM TDROIT INNER JOIN TSOCIETE ON TSOCIETE.VSOCIETENOM = TDROIT.VSOCIETE"
    lSqlReq += $" WHERE NPERNUM = {MozartParams.UID} AND NMENUNUM = {nIdMenuDroit} AND CDROITVAL = 'O' AND VSOCIETEACTIF='O'"
    If bOnlyFiliale Then
      lSqlReq += "   AND BISFILIALEEMALEC='O'"
    End If
    lSqlReq += $" ORDER BY VSOCIETE"

    Dim cmdSql As New SqlCommand(lSqlReq, cnx)
    Dim resSql As SqlDataReader = cmdSql.ExecuteReader()

    i = 0
    While resSql.Read()
      ' Le Paramètre 'sNomSocDefault' n'est jamais renseigné
      'test société par défaut
      If sNomSocDefault = resSql.Item("VSOCIETE").ToString() Then idef = i
      'remplissage combo
      Combo1.Items.Add(resSql.Item("VSOCIETE").ToString())
      i += 1
    End While

    resSql.Close()

    If i > 1 And bGroupe Then
      Combo1.Items.Add("GROUPE")
    End If

    'ici on rend la combo visible ou pas selon le nombre de société affecté
    If i = 1 And bCacheOneSociete Then
      Visible = False
    Else
      Visible = True
      ' Le Paramètre 'sBackColorForm' n'est jamais renseigné
      'LblSociete.BackColor = Drawing.ColorTranslator.FromOle(sBackColorForm)
      LblSociete.ForeColor = SystemColors.ControlText
    End If

    'sélection par défaut de la société
    If Combo1.Items.Count > 0 Then
      Combo1.SelectedIndex = idef
    End If

    Locked = True
  End Sub

  Private Sub apiSocieteAuto_Resize(sender As Object, e As EventArgs) Handles MyBase.Resize
    Combo1.Left = LblSociete.Width
    Combo1.Width = Width - LblSociete.Width
    Height = Combo1.Height
  End Sub

  Public Property List(ByVal Index As Short) As String
    Get
      Return Combo1.Items(Index)
    End Get
    Set(ByVal New_List As String)
      Combo1.Items(Index) = New_List
    End Set
  End Property

  Public ReadOnly Property ListCount() As Short
    Get
      Return Combo1.Items.Count
    End Get
  End Property

  Public Property ListIndex() As Short
    Get
      Return Combo1.SelectedIndex

    End Get
    Set(ByVal New_ListIndex As Short)
      Combo1.SelectedIndex = New_ListIndex
    End Set
  End Property

  Public ReadOnly Property NewIndex() As Short
    Get
      Return Combo1.Items.Count - 1
    End Get
  End Property

  Public Shadows Property Text() As String
    Get
      Return Combo1.Text
    End Get
    Set(ByVal New_Text As String)
      On Error Resume Next
      Combo1.Text = New_Text
    End Set
  End Property

  Public Property IdMenuParent() As Short
    Get
      Return nIdMenuDroit
    End Get
    Set(ByVal New_nIdMenuDroit As Short)
      nIdMenuDroit = New_nIdMenuDroit
    End Set
  End Property

  Public Shadows ReadOnly Property hwnd() As Integer
    Get
      Return Combo1.Handle
    End Get
  End Property

  Public Shadows Property BackColor() As Color
    Get
      Return Combo1.BackColor
    End Get
    Set(ByVal New_BackColor As Color)
      Combo1.BackColor = New_BackColor
    End Set
  End Property

  Public Shadows Property ForeColor() As Color
    Get
      Return Combo1.ForeColor
    End Get
    Set(ByVal New_ForeColor As Color)
      Combo1.ForeColor = New_ForeColor
    End Set
  End Property

  Public Shadows Property Enabled() As Boolean
    Get
      Return Combo1.Enabled
    End Get
    Set(ByVal New_Enabled As Boolean)
      Combo1.Enabled = New_Enabled
    End Set
  End Property

  Public Property Locked() As Boolean
    Get
      If Combo1.DropDownStyle = Windows.Forms.ComboBoxStyle.DropDownList Then Return True
      Return False
    End Get
    Set(ByVal New_Locked As Boolean)
      If New_Locked Then
        Combo1.DropDownStyle = Windows.Forms.ComboBoxStyle.DropDownList
      Else
        Combo1.DropDownStyle = Windows.Forms.ComboBoxStyle.DropDown
      End If
    End Set
  End Property

  Private _TheFont As Font
  Public Overrides Property Font() As Font
    Get
      Return MyBase.Font
    End Get
    Set(ByVal New_Font As Font)
      MyBase.Font = New_Font
      Combo1.Font = New_Font
      LblSociete.Font = New_Font
      Refresh()
    End Set
  End Property

  Public Property CacheOneSoc() As Boolean
    Get
      Return bCacheOneSociete
    End Get
    Set(ByVal New_CacheOneSoc As Boolean)
      bCacheOneSociete = CShort(New_CacheOneSoc)
    End Set
  End Property

End Class

