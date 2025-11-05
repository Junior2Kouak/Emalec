Imports System.Data.SqlClient
Imports MozartLib

Public Class frmDetailsCase

  Dim pMousePosition As Point

  Dim iNIDCHANTIER As Int32
  Dim sType As String
  Dim TabInfo As ArrayList

  Public Sub New(ByVal c_sType As String, ByVal c_NIDCHANTIER As Int32, ByVal c_oPosMouse As Point, ByVal c_TabInfo As ArrayList)

    ' Cet appel est requis par le concepteur.
    InitializeComponent()

    ' Ajoutez une initialisation quelconque après l'appel InitializeComponent().        
    sType = c_sType
    pMousePosition = c_oPosMouse
    iNIDCHANTIER = c_NIDCHANTIER
    TabInfo = c_TabInfo

  End Sub

  Private Sub frmDetailsCase_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
    ' on recherche les infos en fonction du case d'affichage
    Me.Location = pMousePosition
    RechercheInfo()
  End Sub

  Private Sub RechercheInfo()

    Dim cmd As New SqlCommand("api_sp_ChantierDetailsInfo " & iNIDCHANTIER & ",'" & sType & "'", MozartDatabase.cnxMozart)
    Dim iNbCar As Integer = 0
        Dim iNbEnreg As Integer = 0

        Dim daCur As New SqlDataAdapter
        Dim dtCur As New DataTable

        'on charge les données
        Dim bExist As Boolean = False
        Dim iInfo As New Info
        For Each iInfo In TabInfo
            If iInfo.sType = sType Then
                grdMain.DataSource = iInfo.dTable
            End If
        Next

        If Not bExist Then
            Dim CurInfo As New Info()
            daCur.SelectCommand = cmd
            daCur.Fill(dtCur)
            grdMain.DataSource = dtCur
            CurInfo.sType = sType
            CurInfo.dTable = dtCur
            TabInfo.Add(CurInfo)
        End If

        'Resize:
        '        ResizeForm(dtCur.Rows.Count)

    End Sub

    Private Sub ResizeForm(ByVal inbEnreg As Integer)
        'txtInfo.Height = iNbenreg * 16
        'txtInfo.Width = iLargeur * 8.7
        'Me.Height = txtInfo.Height + 58
        'Me.Width = txtInfo.Width + 32
        'Dim i As Integer
        'grdMain.Width = 0

        'For i = 0 To grdMain.ColumnCount - 1
        '    grdMain.Width = grdMain.Width + grdMain.Columns(i).Width
        'Next
        'grdMain.Width = grdMain.Width + 100

        grdMain.Height = inbEnreg * 21
        Me.Height = grdMain.Height + 50

    End Sub
    Private Sub frmDetailsCase_Click(ByVal sender As Object, ByVal e As System.EventArgs) Handles Me.Click
        Me.Close()
    End Sub

End Class