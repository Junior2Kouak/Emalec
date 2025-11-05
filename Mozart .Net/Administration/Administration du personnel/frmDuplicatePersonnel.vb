Imports System.Data.SqlClient
Imports DevExpress.XtraEditors
Imports DevExpress.XtraEditors.Controls
Imports MozartLib

Public Class frmDuplicatePersonnel

  Dim dtFiliales As DataTable

  Dim DtMenus As DataTable
  Dim _NPERNUM_ORI As Int32
  Public Sub New(ByVal c_NPERNUM_ORI As Object)

    ' Cet appel est requis par le concepteur.
    InitializeComponent()

    ' Ajoutez une initialisation quelconque après l'appel InitializeComponent().
    _NPERNUM_ORI = c_NPERNUM_ORI

  End Sub

  Private Sub frmDuplicatePersonnel_Load(sender As Object, e As EventArgs) Handles MyBase.Load

    Initboutons(Me)

    loaddata()

  End Sub

  Private Sub loaddata()


    DtMenus = New DataTable
    Dim sqlcmdLoad As New SqlCommand("select NMENUNUM, VMENULIB, NMENUPARENT from TMENU ORDER BY NMENUNUM", MozartDatabase.cnxMozart)
    sqlcmdLoad.CommandType = CommandType.Text
    DtMenus.Load(sqlcmdLoad.ExecuteReader)

    TreeList1.DataSource = DtMenus

  End Sub

  Private Sub BtnQuit_Click(sender As Object, e As EventArgs) Handles BtnQuit.Click
    Me.Close()
  End Sub

  Private Sub TreeList1_FocusedNodeChanged(sender As Object, e As DevExpress.XtraTreeList.FocusedNodeChangedEventArgs) Handles TreeList1.FocusedNodeChanged

    Console.WriteLine(e.Node.GetValue(1))

    If e.Node.GetValue(1) > 0 Then

      LoadDataByMenu(e.Node.GetValue(1), _NPERNUM_ORI)

    Else

      TreeList2.DataSource = Nothing

    End If

  End Sub

  Private Sub LoadDataByMenu(ByVal p_NMENUNUM As Int32, ByVal p_NPERNUM As Int32)

    dtFiliales = New DataTable
    Dim sqlcmdLoad As New SqlCommand("[api_sp_ListeDroitsMenuBySoc]", MozartDatabase.cnxMozart)
    sqlcmdLoad.CommandType = CommandType.StoredProcedure
    sqlcmdLoad.Parameters.Add("@P_NMENUNUM", SqlDbType.Int).Value = p_NMENUNUM
    sqlcmdLoad.Parameters.Add("@P_NPERNUM", SqlDbType.Int).Value = p_NPERNUM
    dtFiliales.Load(sqlcmdLoad.ExecuteReader)

    TreeList2.DataSource = dtFiliales

  End Sub

End Class