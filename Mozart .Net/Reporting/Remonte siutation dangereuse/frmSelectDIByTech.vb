Imports System.Data.SqlClient
Imports MozartLib

Public Class frmSelectDIByTech

  Dim Dt As DataTable

  Dim _NACTNUM_SELECTED As Int32
  Dim _NDINNUM_SELECTED As Int32
  Dim _VSITNOM_SELECTED As String

  Dim _NPERNUM As Int32

  Public ReadOnly Property NACTNUM_SELECTED As Int32
    Get
      Return _NACTNUM_SELECTED
    End Get
  End Property

  Public ReadOnly Property NDINNUM_SELECTED As Int32
    Get
      Return _NDINNUM_SELECTED
    End Get
  End Property
  Public ReadOnly Property VSITNOM_SELECTED As String
    Get
      Return _VSITNOM_SELECTED
    End Get
  End Property

  Public Sub New(ByVal c_NPERNUM As Int32)

    ' Cet appel est requis par le concepteur.
    InitializeComponent()

    ' Ajoutez une initialisation quelconque après l'appel InitializeComponent().
    _NPERNUM = c_NPERNUM

  End Sub

  Private Sub frmSelectDIByTech_Load(sender As Object, e As EventArgs) Handles MyBase.Load

    LoadData()

  End Sub

  Private Sub LoadData()

    Dt = New DataTable
    Dim sqlcmd As New SqlCommand("[api_sp_FicSituDanger_ListeAct24MTech]", MozartDatabase.cnxMozart)
    sqlcmd.CommandType = CommandType.StoredProcedure
        sqlcmd.Parameters.Add("@P_NPERNUM", SqlDbType.Int).Value = _NPERNUM
        Dt.Load(sqlcmd.ExecuteReader)

        GCListeActTech24M.DataSource = Dt

    End Sub

    Private Sub BtnFermer_Click(sender As Object, e As EventArgs) Handles BtnFermer.Click
        _NACTNUM_SELECTED = 0
        Me.Close()
    End Sub

    Private Sub BtnValid_Click(sender As Object, e As EventArgs) Handles BtnValid.Click

        If GVListeActTech24M.SelectedRowsCount = 0 Then Exit Sub

        Dim oDataRowSelect As DataRow = GVListeActTech24M.GetDataRow(GVListeActTech24M.FocusedRowHandle)

        _NACTNUM_SELECTED = oDataRowSelect.Item("NACTNUM")
        _NDINNUM_SELECTED = oDataRowSelect.Item("NDINNUM")
        _VSITNOM_SELECTED = oDataRowSelect.Item("VSITNOM")

        Me.Close()

    End Sub
End Class


