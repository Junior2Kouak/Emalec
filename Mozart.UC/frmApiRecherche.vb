Imports System.Data.SqlClient
Imports System.Windows.Forms
Imports MozartLib

Public Class frmApiRecherche

  Public msTag As String
  Public msRetour As String
  Public mlItemData As Long
  Public msType As String   ' type d'écran ou est utilisé cette fonction
  Public miTypContrat As Int32 ' depuis frmDetailstravaux
  Public mTxtDI As String ' depuis frmDetailstravaux

  Private m_intUID As Long = 0
  Private m_iNumDi As Integer = 0

  Public m_txtObjGidt As String
  Public m_txtObjGidt_Tag As Object

  Public msSql As String
  Public m_cnx As SqlConnection
  Private m_dataTable As DataTable


  Public Sub New(ByVal cnx As SqlConnection)
    InitializeComponent()
    m_cnx = cnx
  End Sub

  Private Sub frmApiRecherche_Load(sender As Object, e As EventArgs) Handles MyBase.Load

    msRetour = ""
    mlItemData = 0

    m_iNumDi = MozartParams.NumDi
    Dim str As String = MozartParams.UID
    If (str <> "") Then
      m_intUID = str
    End If

    Dim cmdSql As New SqlCommand(msSql, m_cnx)

    m_dataTable = New DataTable()

    m_dataTable.Load(cmdSql.ExecuteReader())

    If m_dataTable.Rows.Count > 0 Then mlItemData = m_dataTable.Rows(0)(0)

    InitGrid()

    Grid.btnPrint.Visible = False
    Grid.btnExcel.Visible = False
    Grid.chkColumnsList.Visible = False

    Me.Width = m_dataTable.Columns.Count * 130

    ' pour donner le focus sur la deuxieme colonne du filterbar du datagrid
    'Grid.FilterBarFocus = True
    My.Computer.Keyboard.SendKeys("{TAB}")

    If msType = "GAM" Then
      Me.Width = 11000 / 15
      Grid.Width = 10000 / 15
      Grid.dgv.Columns(1).Width = 8000 / 15
      Grid.dgv.Columns(2).Width = 1000 / 15
      Grid.dgv.Columns(3).Width = 1500 / 15
    End If

  End Sub

  Private Sub cmdEsc_Click(sender As Object, e As EventArgs) Handles cmdEsc.Click
    Dispose()
  End Sub

  Private Sub cmdVal_Click(sender As Object, e As EventArgs) Handles cmdVal.Click

    If m_dataTable.Rows.Count = 0 Then Exit Sub

    If (Grid.GetFocusedDataRow() Is Nothing) Then Exit Sub

    If msType = "TECH" Then
      If Not VerifTechInterdit() Then Exit Sub
    End If

    Dim lSelectedRow As DataRow = Grid.GetFocusedDataRow()

    Dim cmdSql As SqlCommand

    If msType = "OBJET" Then

      ' on verifie les contrat des objets sur la DI
      If Not VerifContratGidtCli() Then

        ' si Pelletier alors remplacement du contrat et de tous les équipements de la DI possible
        If RechercheDroitMenu(m_cnx, m_intUID, 539) Then

          If MessageBox.Show("Attention, vous allez remplacer le contrat et tous les équipements de la DI !" + vbCrLf + "Etes-vous sûr ?", "",
                              MessageBoxButtons.YesNo) = DialogResult.Yes Then

            mlItemData = lSelectedRow(0)

            cmdSql = New SqlCommand($"SELECT NTYPECONTRAT FROM TGIDTARBOCLI WITH (NOLOCK) INNER JOIN TGIDTOBJCLI WITH (NOLOCK)  ON TGIDTARBOCLI.NARBONUM = TGIDTOBJCLI.NARBONUM WHERE NOBJNUM = {mlItemData}", m_cnx)
            m_txtObjGidt_Tag = CStr(cmdSql.ExecuteScalar())

            cmdSql.CommandText = $"UPDATE TACTCOMP SET NOBJNUM = {mlItemData} WHERE NACTNUM IN (SELECT NACTNUM FROM TACT WITH (NOLOCK) WHERE NDINNUM = {m_iNumDi})"
            cmdSql.ExecuteNonQuery()
          Else
            Exit Sub
          End If
        Else
          MessageBox.Show("Vous ne pouvez pas sélectionner un matériel d'un contrat différent !", "", MessageBoxButtons.OK, MessageBoxIcon.Exclamation)
          Exit Sub
        End If

        ' la verification des contrats est OK
      Else
        mlItemData = lSelectedRow(0)
        cmdSql = New SqlCommand($"SELECT NTYPECONTRAT FROM TGIDTARBOCLI INNER JOIN TGIDTOBJCLI ON TGIDTARBOCLI.NARBONUM = TGIDTOBJCLI.NARBONUM WHERE NOBJNUM = {mlItemData}", m_cnx)
        m_txtObjGidt_Tag = CStr(cmdSql.ExecuteScalar())
      End If

      m_txtObjGidt = lSelectedRow("Objet")
    End If

    mlItemData = lSelectedRow(0)
    msRetour = lSelectedRow(1)

    Close()

  End Sub

  Private Sub InitGrid()

    Dim c As DataColumn

    For Each c In m_dataTable.Columns
      Grid.AddColumn(c.ColumnName, c.ColumnName, Math.Min(c.MaxLength * 100, 2500))
    Next
    Grid.dgv.Columns(0).Visible = False

    Grid.GridControl.DataSource = m_dataTable

    If msType = "OBJET" Then

      Dim strLangue = MozartParams.Langue
      Dim cmdSql As New SqlCommand($"SELECT VTYPECONTRAT FROM TREF_TYPECONTRAT WHERE NTYPECONTRAT = {miTypContrat} AND LANGUE = '{strLangue}'", m_cnx)

      Dim vtypecontrat = CStr(cmdSql.ExecuteScalar())

      Grid.dgv.ActiveFilterString = $"Contrat like '%{vtypecontrat}%'"

    End If

  End Sub

  'Private Sub frmApiRecherche_Resize(sender As Object, e As EventArgs) Handles MyBase.Resize
  '  Grid.Width = Me.Width - 6
  '  Grid.Height = Me.Height - 40
  '  cmdEsc.Top = Grid.Height + 3
  '  cmdVal.Top = Grid.Height + 3
  'End Sub

  Private Sub Grid_DoubleClick(sender As Object, e As EventArgs) Handles Grid.DoubleClick
    cmdVal_Click(sender, e)
  End Sub

  Private Function VerifTechInterdit() As Boolean

    Dim nTech As Integer
    Dim nSitNum As Integer

    If nTech = 0 Or nSitNum = 0 Then Return True

    Try
      ' vérification interdiction et obligation tech sur site

      ' TECH EN COURS INTERDIT
      Dim cmdVerifInt As New SqlCommand($"SELECT COUNT(*) FROM TTECHSITE WITH (NOLOCK) WHERE NSITNUM = {nSitNum} AND NPERNUM = {nTech} AND CTYPE = 'I'", m_cnx)

      ' AUTRES TECH OBLIGATOIRE?
      Dim cmdVerifObl As New SqlCommand($"SELECT COUNT(*) FROM TTECHSITE WITH (NOLOCK) WHERE NSITNUM = {nSitNum} And NPERNUM <> {nTech} And CType = 'O' AND NPERNUM NOT IN (SELECT NPERNUM FROM TPER WHERE CPERACTIF = 'N')", m_cnx)

      ' TECH EN COURS OBLIGATOIRE
      Dim cmdVerifOblTech As New SqlCommand($"SELECT COUNT(*) From TTECHSITE WITH (NOLOCK) WHERE NSITNUM = {nSitNum} And NPERNUM = {nTech} And CType = 'O'", m_cnx)

      'Dim cmdIP As New SqlCommand("SELECT COUNT(*) From TACT WITH (NOLOCK) WHERE NIPLNUM = " & nIp & " AND CPRECOD = 'P'", cnx)

      If cmdVerifInt.ExecuteScalar() > 0 Then
        MessageBox.Show("Ce technicien est interdit sur ce site !", "", MessageBoxButtons.OK, MessageBoxIcon.Stop)
        Return False
        ' on ne teste les tech obligatoires que sur les PREV (modif FG le 10/11/16 maintenant on fait pour toutes actions)
        'ElseIf cmdVerifOblTech.ExecuteScalar() = 0 And cmdIP.ExecuteScalar() <> 0 Then
      ElseIf cmdVerifOblTech.ExecuteScalar() = 0 Then
        If cmdVerifObl.ExecuteScalar() > 0 Then
          MessageBox.Show("Il y a des techniciens obligatoires sur ce site !", "", MessageBoxButtons.OK, MessageBoxIcon.Stop)
          Return False
        End If
      End If
      Return True

    Catch ex As Exception
      MessageBox.Show(ex.Message & vbCrLf & vbCrLf & "dans : " & System.Reflection.MethodBase.GetCurrentMethod.Name)
      Return False
    End Try
  End Function

  Private Function VerifContratGidtCli() As Boolean

    ' on recherche le nb d'actions sur la DI qui sont affectées a des objet sur un contrat different
    ' si on a 0 ou 1 : on est en création ou l action en cours est la seule = OK pour enreg
    ' si > 1 : il y a d autres actions donc on ne peut pas faire la modif
    'VerifContratGidtCli = False

    Dim ItemData As Int32 = Grid.GetFocusedDataRow()(0)

    Dim cmdSql As New SqlCommand("SELECT count(*) FROM TACT WITH (NOLOCK) INNER JOIN  " _
                & " TACTCOMP WITH (NOLOCK) ON TACT.NACTNUM = TACTCOMP.NACTNUM INNER JOIN" _
                & " TGIDTOBJCLI WITH (NOLOCK) ON TGIDTOBJCLI.NOBJNUM = TACTCOMP.NOBJNUM INNER JOIN" _
                & " TGIDTARBOCLI WITH (NOLOCK) ON TGIDTARBOCLI.NARBONUM = TGIDTOBJCLI.NARBONUM" _
                & " WHERE NDINNUM = " & mTxtDI & " AND NTYPECONTRAT not in" _
                & " (SELECT NTYPECONTRAT FROM TGIDTARBOCLI WITH (NOLOCK) INNER JOIN TGIDTOBJCLI WITH (NOLOCK)" _
                & " ON TGIDTARBOCLI.NARBONUM = TGIDTOBJCLI.NARBONUM WHERE NOBJNUM = " & mlItemData & ")", m_cnx)

    'If cmdSql.ExecuteScalar() < 1 Then VerifContratGidtCli = True
    Return cmdSql.ExecuteScalar() <= 1

  End Function

End Class