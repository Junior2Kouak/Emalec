Imports System.Drawing

Public Class apiTooltip
  Private Structure ApiCol
    Dim Caption As String
    Dim width As Integer
    Dim Format As String
    Dim Align As Integer
  End Structure

  Private tCol() As ApiCol
  Private miNbCol As Integer

  Private bBeginMove As Boolean
  Private mTexte As String
  Public ProcInfo As String

  ' VB6 Private Const EM_GETLINECOUNT = &HBA
  ' VB6 
  ' VB6 Private Type ApiCol
  ' VB6   Caption As String
  ' VB6   width As Integer
  ' VB6   Format As String
  ' VB6   Align As Integer
  ' VB6 End Type

  ' VB6 Private tCol() As ApiCol
  ' VB6 Private miNbCol As Integer
  ' VB6 

  ' VB6 Private bBeginMove As Boolean
  ' VB6 Private mTitre As String
  ' VB6 Private mTexte As String
  ' VB6 Public ProcInfo As String

  Public Sub AddColumn(sNom As String, iLarg As Integer, Optional sFormat As String = "", Optional iAlign As Integer = 0)

    ReDim Preserve tCol(miNbCol)
    tCol(miNbCol).Caption = sNom
    If miNbCol = 0 Then
      tCol(miNbCol).width = iLarg
    Else
      tCol(miNbCol).width = iLarg + tCol(miNbCol - 1).width
    End If
    tCol(miNbCol).Format = sFormat
    tCol(miNbCol).Align = iAlign
    miNbCol = miNbCol + 1

  End Sub

  ' VB6 Public Sub AddColumn(sNom As String, iLarg As Integer, Optional sFormat As String = "", Optional iAlign As Integer = 0)
  ' VB6 
  ' VB6   ReDim Preserve tCol(miNbCol)
  ' VB6   tCol(miNbCol).Caption = sNom
  ' VB6   If miNbCol = 0 Then
  ' VB6     tCol(miNbCol).width = iLarg
  ' VB6   Else
  ' VB6     tCol(miNbCol).width = iLarg + tCol(miNbCol - 1).width
  ' VB6   End If
  ' VB6   tCol(miNbCol).Format = sFormat
  ' VB6   tCol(miNbCol).Align = iAlign
  ' VB6   miNbCol = miNbCol + 1
  ' VB6 
  ' VB6 End Sub

  Private Sub cmdInfo_Click(sender As Object, e As EventArgs) Handles cmdInfo.Click
    If ProcInfo <> "" Then
      CallByName(sender.Parent.Parent, ProcInfo, CallType.Method)
    End If
  End Sub

  ' VB6 Private Sub imgInfo_Click()
  ' VB6   If ProcInfo <> "" Then
  ' VB6     CallByName UserControl.Parent, ProcInfo, vbMethod
  ' VB6   End If
  ' VB6 End Sub

  Private Sub cmdClose_Click(sender As Object, e As EventArgs) Handles cmdClose.Click
    Me.Visible = False
  End Sub


  ' VB6 Private Sub imgClose_Click()
  ' VB6   UserControl.Parent.ActiveControl.Visible = False
  ' VB6 End Sub

  Private Sub lblTitre_MouseDown(sender As Object, e As Windows.Forms.MouseEventArgs) Handles lblTitre.MouseDown
    bBeginMove = True
  End Sub

  ' VB6 Private Sub picTitre_MouseDown(Button As Integer, Shift As Integer, X As Single, Y As Single)
  ' VB6   bBeginMove = True
  ' VB6 End Sub

  Private Sub lblTitre_MouseUp(sender As Object, e As Windows.Forms.MouseEventArgs) Handles lblTitre.MouseUp
    bBeginMove = False
  End Sub

  ' VB6 Private Sub picTitre_MouseUp(Button As Integer, Shift As Integer, X As Single, Y As Single)
  ' VB6   bBeginMove = False
  ' VB6 End Sub

  Private Sub lblTitre_MouseMove(sender As Object, e As Windows.Forms.MouseEventArgs) Handles lblTitre.MouseMove
    Static oldX As Integer
    Static oldY As Integer

    If bBeginMove = False Then Exit Sub

    If oldX = 0 Then
      oldX = e.X
      oldY = e.Y
    Else
      Me.Left = Me.Left + (e.X - oldX)
      Me.Top = Me.Top + (e.Y - oldY)
    End If
  End Sub

  ' VB6 Public Property Get Titre() As String
  ' VB6   Titre = mTitre
  ' VB6 End Property

  ' VB6 Public Property Let Titre(ByVal value As String)
  ' VB6   mTitre = value
  ' VB6 End Property


  Public Property NbLignes() As Integer

  ' VB6 Public Property Get NbLignes() As Integer
  ' VB6 End Property

  Public Property hwnd() As Long

  ' VB6 Public Property Get hwnd() As Long
  ' VB6   hwnd = UserControl.hwnd
  ' VB6 End Property

  Public Property Titre() As String
  Public Property Texte() As String

  ' VB6 Public Property Get Texte() As String
  ' VB6   Texte = mTexte
  ' VB6 End Property

  ' VB6 Public Property Let Texte(ByVal value As String)
  ' VB6   mTexte = value
  ' VB6 End Property

  Private Sub apiTooltip_Resize(sender As Object, e As EventArgs) Handles MyBase.Resize
    lblTitre.Top = 0 : lblTitre.Left = 0
    cmdClose.Top = 0 : cmdInfo.Top = 0
    cmdClose.Left = Me.Width - cmdClose.Width
    cmdInfo.Left = Me.Width - cmdInfo.Width - cmdClose.Width
    txtTexte.Left = 0 : txtTexte.Top = cmdClose.Height
    txtTexte.Width = Me.Width
    txtTexte.Height = Me.Height - cmdClose.Height
    lblTitre.Width = cmdInfo.Left
  End Sub

  ' VB6 Public Sub Resize()
  ' VB6 
  ' VB6   Const EM_GETLINECOUNT = &HBA
  ' VB6   Dim NbLines As Integer
  ' VB6 
  ' VB6   NbLines = SendMessage(Text1.hwnd, EM_GETLINECOUNT, 0, 0)
  ' VB6   'Text1.height = LineCount * 200
  ' VB6   UserControl.Height = picTitre.height + NbLines * 240
  ' VB6 End Sub

  Public Property TexteBox() As String

  ' VB6 Public Property Get TexteBox() As String
  ' VB6   TexteBox = Text1.Text
  ' VB6 End Property

  ' VB6 Public Property Let TexteBox(ByVal value As String)
  ' VB6   Text1.Text = value
  ' VB6   Text1.Visible = True
  ' VB6 UserControl.height = picTitre.height + 50 + SendMessage(Text1.hwnd, EM_GETLINECOUNT, 0, 0) * 200
  ' VB6 UserControl.Refresh
  ' VB6 End Property

  Public Sub PrintTexte(sFormat As String)

    txtTexte.Clear()
    lblTitre.Text = ""

    If miNbCol = 0 Then
      txtTexte.Text = Texte
      lblTitre.Text = Titre
    Else
      For j = 0 To miNbCol - 1
        lblTitre.Text += tCol(j).Caption + "      "
      Next
      For Each item As String In Split(Texte & vbCrLf, vbCrLf)
        Dim tabItem() As String = Split(item, "||")
        If tabItem.Length = 2 Then ' frmListeMargeDi !
          txtTexte.Text += String.Format(sFormat, tabItem(0), tabItem(1)) + vbCrLf
        Else
          For Each txt In tabItem
            txtTexte.Text += txt + vbTab
          Next
          txtTexte.Text += vbCrLf
        End If
      Next
      miNbCol = 0
    End If

    'lblTitre.Text = Titre
    'For Each item As String In Split(Texte & vbCrLf, vbCrLf)
    '  Dim tabCol() As String = Split(item, "||")
    '  If (tabCol.Count = 2) Then
    '    txtTexte.Text += String.Format(sFormat, tabCol(0), tabCol(1))
    '  Else
    '    txtTexte.Text += item
    '  End If
    '  txtTexte.Text += vbCrLf
    'Next

  End Sub

  Private Sub apiTooltip_Load(sender As Object, e As EventArgs) Handles MyBase.Load
    apiTooltip_Resize(Nothing, Nothing)
  End Sub

  ' VB6 Public Sub PrintTexte()
  ' VB6   Dim tabTexte, tabCol
  ' VB6   Dim i As Integer, j As Integer

  ' VB6   On Error Resume Next
  ' VB6   picTexte.Cls
  ' VB6   picTitre.Cls
  ' VB6   picTexte.CurrentY = 250     ' Se positionner en dessous de la barre de titre
  ' VB6   If miNbCol = 0 Then
  ' VB6     picTitre.Print mTitre
  ' VB6     picTexte.Print mTexte
  ' VB6   Else
  ' VB6     For j = 0 To miNbCol - 1
  ' VB6       picTitre.Print tCol(j).Caption,
  ' VB6       picTitre.CurrentX = tCol(j).width
  ' VB6     Next
  ' VB6 
  ' VB6     tabTexte = Split(mTexte & vbCrLf, vbCrLf)
  ' VB6     For i = 0 To UBound(tabTexte) - 1
  ' VB6       tabCol = Split(tabTexte(i), "||")
  ' VB6       For j = 0 To UBound(tabCol)
  ' VB6         picTexte.Print tabCol(j),
  ' VB6         picTexte.CurrentX = tCol(j).width
  ' VB6       Next
  ' VB6       picTexte.Print
  ' VB6     Next
  ' VB6   End If
  ' VB6   miNbCol = 0
  ' VB6 End Sub
  ' VB6 
  ' VB6 Public Property Let Font(ByVal value As String)
  ' VB6   picTexte.Font = value
  ' VB6 End Property
  ' VB6 
  ' VB6 'ATTENTION! NE SUPPRIMEZ PAS OU NE MODIFIEZ PAS LES LIGNES COMMENTÉES SUIVANTES!
  ' VB6 'MappingInfo=picTexte,picTexte,-1,BackColor
  ' VB6 Public Property Get BackColor() As OLE_COLOR
  ' VB6   BackColor = picTexte.BackColor
  ' VB6 End Property
  ' VB6 
  ' VB6 Public Property Let BackColor(ByVal New_BackColor As OLE_COLOR)
  ' VB6   picTexte.BackColor() = New_BackColor
  ' VB6   Text1.BackColor = New_BackColor
  ' VB6 PropertyChanged "BackColor"
  ' VB6 End Property
  ' VB6 
  ' VB6 'Charger les valeurs des propriétés à partir du stockage
  ' VB6 Private Sub UserControl_ReadProperties(PropBag As PropertyBag)
  ' VB6   picTexte.BackColor = PropBag.ReadProperty("BackColor", &HC0FFFF)
  ' VB6 End Sub
  ' VB6 
  ' VB6 'Écrire les valeurs des propriétés dans le stockage
  ' VB6 Private Sub UserControl_WriteProperties(PropBag As PropertyBag)
  ' VB6   Call PropBag.WriteProperty("BackColor", picTexte.BackColor, &HC0FFFF)
  ' VB6 End Sub
  ' VB6 
  ' VB6 Public Sub Sizable(b As Boolean)
  ' VB6   Dim lngStyle As Long
  ' VB6   Dim X As Long
  ' VB6 
  ' VB6   lngStyle = GetWindowLong(hwnd, GWL_STYLE)
  ' VB6   If b Then
  ' VB6     lngStyle = lngStyle Or WS_THICKFRAME
  ' VB6   Else
  ' VB6     lngStyle = lngStyle Xor WS_THICKFRAME
  ' VB6   End If
  ' VB6   X = SetWindowLong(hwnd, GWL_STYLE, lngStyle)
  ' VB6   X = SetWindowPos(hwnd, UserControl.Parent.hwnd, 0, 0, 0, 0, SWP_FLAGS)
  ' VB6 End Sub


End Class
