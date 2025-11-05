Imports System.Data.SqlClient
Imports MozartLib

Public Class frmSelectChaffChantier

  Dim DtChaffAffecte As DataTable

  Dim _NPERNUM As Int32 = 0
  Dim _VPERNOM As String = ""
  Dim _VPERPRE As String = ""

  Public Sub New(ByVal c_NPERNUM As Object, Optional ByVal c_VPERNOM As Object = "", Optional ByVal c_VPERPRE As Object = "")

    ' Cet appel est requis par le concepteur.
    InitializeComponent()

    ' Ajoutez une initialisation quelconque après l'appel InitializeComponent().
    _NPERNUM = c_NPERNUM
    _VPERNOM = c_VPERNOM
    _VPERPRE = c_VPERPRE

  End Sub

  Private Sub frmSelectChaffChantier_Load(sender As System.Object, e As System.EventArgs) Handles MyBase.Load

    LabelTitre.Text = String.Format("Affectation des chargés d'affaires pour {0}", _VPERNOM & " " & _VPERPRE)
    Me.Text = String.Format("Affectation des chargés d'affaires {0}", _VPERNOM & " " & _VPERPRE)

    LoadData()

  End Sub

  Private Sub LoadData()

    DtChaffAffecte = New DataTable

    Dim sql_loader As New SqlCommand("[api_sp_ChaffAffecteListe]", MozartDatabase.cnxMozart)
    sql_loader.CommandType = CommandType.StoredProcedure
    sql_loader.Parameters.Add("@P_NPERNUM", SqlDbType.Int).Value = _NPERNUM
    DtChaffAffecte.Load(sql_loader.ExecuteReader)

    DtChaffAffecte.Columns("BAFFECTE").ReadOnly = False

    GCPers.DataSource = DtChaffAffecte

  End Sub

  Private Sub BtnQuit_Click(sender As System.Object, e As System.EventArgs) Handles BtnQuit.Click
    Me.Close()
  End Sub

  Private Sub BtnSave_Click(sender As System.Object, e As System.EventArgs) Handles BtnSave.Click
    If _NPERNUM = 0 Then Exit Sub
    Me.Cursor = Cursors.WaitCursor
    SaveChaffAffecte()
    Me.Cursor = Cursors.Default
  End Sub

  Public Sub SaveChaffAffecte()

    Try

      If Not DtChaffAffecte Is Nothing AndAlso Not DtChaffAffecte.GetChanges(DataRowState.Modified) Is Nothing Then

        For Each oDtrSave As DataRow In DtChaffAffecte.GetChanges(DataRowState.Modified).Rows

          Dim dtQCMInit As New DataTable

          Dim sql_loader As New SqlCommand("[api_sp_ChaffAffecteListe]", MozartDatabase.cnxMozart)
          sql_loader.CommandType = CommandType.StoredProcedure
          sql_loader.Parameters.Add("@P_NPERNUM", SqlDbType.Int).Value = _NPERNUM
          dtQCMInit.Load(sql_loader.ExecuteReader)

          If oDtrSave.Item("BAFFECTE") = 1 And oDtrSave.Item("BAFFECTE") <> dtQCMInit.Select(String.Format("NPERCHAFF = {0}", oDtrSave.Item("NPERCHAFF")))(0).Item("BAFFECTE") Then

            AffecterChaff(_NPERNUM, oDtrSave.Item("NPERCHAFF"))

          ElseIf oDtrSave.Item("BAFFECTE") = 0 And oDtrSave.Item("BAFFECTE") <> dtQCMInit.Select(String.Format("NPERCHAFF = {0}", oDtrSave.Item("NPERCHAFF")))(0).Item("BAFFECTE") Then

            NotAffecterChaff(_NPERNUM, oDtrSave.Item("NPERCHAFF"))

          End If

        Next

      End If

    Catch ex As Exception

      MessageBox.Show("frmSelectChaffChantier dans SaveChaffAffecte : " + ex.Message)

    End Try

  End Sub

  Private Sub AffecterChaff(ByVal P_NPERNUM As Int32, ByVal P_NPERNUMCHAFF As Int32)

    Try

      Dim sqlcmdAffectChaff As New SqlCommand("[api_sp_ChaffAffecteSave]", MozartDatabase.cnxMozart)
      sqlcmdAffectChaff.CommandType = CommandType.StoredProcedure

      sqlcmdAffectChaff.Parameters.Add("@P_NPERNUM", SqlDbType.Int).Value = P_NPERNUM
      sqlcmdAffectChaff.Parameters.Add("@P_NPERCHAFF", SqlDbType.Int).Value = P_NPERNUMCHAFF

      sqlcmdAffectChaff.ExecuteNonQuery()

    Catch ex As Exception

      MessageBox.Show("frmSelectChaffChantier dans AffecterChaff : " + ex.Message)

    End Try

  End Sub

  Private Sub NotAffecterChaff(ByVal P_NPERNUM As Int32, ByVal P_NPERNUMCHAFF As Int32)

    Try

      Dim sqlcmdAffectChaff As New SqlCommand("[api_sp_ChaffAffecteDel]", MozartDatabase.cnxMozart)
      sqlcmdAffectChaff.CommandType = CommandType.StoredProcedure

      sqlcmdAffectChaff.Parameters.Add("@P_NPERNUM", SqlDbType.Int).Value = P_NPERNUM
      sqlcmdAffectChaff.Parameters.Add("@P_NPERCHAFF", SqlDbType.Int).Value = P_NPERNUMCHAFF

      sqlcmdAffectChaff.ExecuteNonQuery()

    Catch ex As Exception

      MessageBox.Show("frmSelectChaffChantier dans NotAffecterChaff : " + ex.Message)

    End Try

  End Sub

  Private Sub GVPers_CustomDrawFooter(sender As Object, e As DevExpress.XtraGrid.Views.Base.RowObjectCustomDrawEventArgs) Handles GVPers.CustomDrawFooter

    If DtChaffAffecte Is Nothing Then Exit Sub

    Dim oPos As Rectangle = e.Bounds
    Dim oFormat As New StringFormat
    Dim iNbPerSelected As Int32 = 0

    oPos.Location = New Point(oPos.Left + 1, oPos.Top + 1)
    oPos.Size = New Size(oPos.Width - 2, oPos.Height - 2)

    oFormat.Alignment = StringAlignment.Center

    Dim dttemp As DataTable = GCPers.DataSource

    For Each odrtemp As DataRow In dttemp.Rows

      If odrtemp.Item("BAFFECTE") = 1 Then
        iNbPerSelected = iNbPerSelected + 1
      End If

    Next

    e.Appearance.DrawString(e.Cache, String.Format(My.Resources.Global_NbrPersonne, iNbPerSelected, DtChaffAffecte.Rows.Count), oPos, oFormat)
    e.Handled = True
  End Sub
End Class