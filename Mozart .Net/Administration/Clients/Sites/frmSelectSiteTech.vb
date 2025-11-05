Imports System.Data.SqlClient
Imports DevExpress.XtraEditors
Imports MozartLib

Public Class frmSelectSiteTech

  Dim _NCLINUM As Int32
  Dim _npernum_tech As Int32
  Dim _TypeParam As String

  Dim dtSites As DataTable

  Public Sub New(ByVal c_NCLINUM As Object, ByVal c_TypeParam As Object, ByVal c_npernum As Object)

    ' Cet appel est requis par le concepteur.
    InitializeComponent()

    ' Ajoutez une initialisation quelconque après l'appel InitializeComponent().
    _NCLINUM = Convert.ToInt32(c_NCLINUM)
    _npernum_tech = Convert.ToInt32(c_npernum)
    _TypeParam = c_TypeParam

  End Sub
  Private Sub frmSelectSiteTech_Load(sender As Object, e As EventArgs) Handles MyBase.Load

    'init
    Select Case _TypeParam
      Case "IMPOSE"
        Label1.Text = Label1.Text & " imposés"
      Case "INTERDIT"
        Label1.Text = Label1.Text & " interdits"
      Case Else

    End Select

    'load nom du tech
    Dim sqlcmd As New SqlCommand("SELECT TPER.VPERNOM + ' ' + TPER.VPERPRE FROM TPER WITH (NOLOCK) WHERE TPER.NPERNUM = " & _npernum_tech.ToString, MozartDatabase.cnxMozart)
    sqlcmd.CommandType = CommandType.Text
    Dim sqldr As SqlDataReader = sqlcmd.ExecuteReader
    If sqldr.HasRows Then

      sqldr.Read()
      Me.Text = Label1.Text + " " + sqldr.Item(0)

    End If
    sqldr.Close()

    LoadData()

  End Sub

  Private Sub LoadData()

    dtSites = New DataTable

    Dim sqlcmd As New SqlCommand("[api_sp_ListeSitesTechAffecte]", MozartDatabase.cnxMozart)
    sqlcmd.CommandType = CommandType.StoredProcedure
    sqlcmd.Parameters.Add("@nclinum", SqlDbType.Int).Value = _NCLINUM
    sqlcmd.Parameters.Add("@npernum", SqlDbType.Int).Value = _npernum_tech
    dtSites.Load(sqlcmd.ExecuteReader)

    dtSites.Columns("BAFFECTE").ReadOnly = False

    GCSitTech.DataSource = dtSites

  End Sub

  Private Sub BtnQuit_Click(sender As Object, e As EventArgs) Handles BtnQuit.Click

    Me.Close()

  End Sub

  Private Sub BtnCoche_Click(sender As System.Object, e As System.EventArgs) Handles BtnCoche.Click

    CocherAllFilterTous_Or_DecocheAllFilter(dtSites, "BAFFECTE", GVSitTech.ActiveFilterCriteria, True)
    GCSitTech.Refresh()

  End Sub

  Private Sub BtnDecoche_Click(sender As System.Object, e As System.EventArgs) Handles BtnDecoche.Click

    CocherAllFilterTous_Or_DecocheAllFilter(dtSites, "BAFFECTE", GVSitTech.ActiveFilterCriteria, False)
    GCSitTech.Refresh()

  End Sub
  Private Sub RepItemChk_BAFFECTE_CheckStateChanged(sender As Object, e As EventArgs) Handles RepItemChk_BAFFECTE.CheckStateChanged

    Dim odtr As DataRow = GVSitTech.GetDataRow(GVSitTech.GetSelectedRows(0))

    If Not odtr Is Nothing Then

      If odtr.Item("BAFFECTE") = 0 Then

        'sinon on force le check a cocher
        CType(sender, CheckEdit).Checked = True
        odtr.Item("BAFFECTE") = 1

      Else

        'sinon on force le check a cocher
        CType(sender, CheckEdit).Checked = False
        odtr.Item("BAFFECTE") = 0

      End If

    End If
    GVSitTech.PostEditor()
    GCSitTech.Refresh()

  End Sub

  Private Sub BtnSave_Click(sender As Object, e As EventArgs) Handles BtnSave.Click

    'on teste si des sites on été coché
    'If dtSites.Select("[BAFFECTE] = 1").Count = 0 Then Exit Sub

    Dim modifs As DataTable = dtSites.GetChanges(DataRowState.Modified)
    If modifs Is Nothing Then Exit Sub

    If MessageBox.Show("Voulez-vous enregistrer les modifications ?", "Confirmation", MessageBoxButtons.YesNoCancel, MessageBoxIcon.Information) = DialogResult.Yes Then


      For Each oSite As DataRow In modifs.Rows   'Select("[BAFFECTE] = 1") 'GetChanges(DataRowState.Modified).Rows

        'on vide tous les sites du tech
        'Dim sql As String
        'Select Case _TypeParam
        '    Case "IMPOSE"
        '        sql = "DELETE FROM TTECHSITE WHERE NSITNUM = " & oSite.Item("NSITNUM") & " AND CTYPE = 'O' AND NPERNUM = " & _npernum_tech.ToString
        '    Case "INTERDIT"
        '        sql = "DELETE FROM TTECHSITE WHERE NSITNUM = " & oSite.Item("NSITNUM") & " AND CTYPE = 'I' AND NPERNUM = " & _npernum_tech.ToString
        '    Case Else
        '        sql = ""
        'End Select
        'Dim sqlcmddel As New SqlCommand(sql, cnx)
        'sqlcmddel.CommandType = CommandType.Text
        'sqlcmddel.ExecuteNonQuery()




        Dim sqlcmd As New SqlCommand("[api_sp_Savetechsite]", MozartDatabase.cnxMozart)
        sqlcmd.CommandType = CommandType.StoredProcedure
        sqlcmd.Parameters.Add("@P_NPERNUM", SqlDbType.Int).Value = _npernum_tech
        sqlcmd.Parameters.Add("@P_NSITNUM", SqlDbType.Int).Value = oSite.Item("NSITNUM")
        Select Case _TypeParam
          Case "IMPOSE"
            sqlcmd.Parameters.Add("@P_CTYPE", SqlDbType.Char).Value = "O"
          Case "INTERDIT"
            sqlcmd.Parameters.Add("@P_CTYPE", SqlDbType.Char).Value = "I"
          Case Else
        End Select
        sqlcmd.Parameters.Add("@P_BAFFECTE", SqlDbType.Bit).Value = oSite.Item("BAFFECTE")

        sqlcmd.ExecuteNonQuery()

      Next
      dtSites.AcceptChanges()
      MessageBox.Show("Enregistrement terminée avec succès", "Confirmation", MessageBoxButtons.OK, MessageBoxIcon.Information)
    End If

  End Sub
End Class