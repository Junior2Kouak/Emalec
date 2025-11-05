Imports System.Data.SqlClient
Imports DevExpress.XtraEditors
Imports DevExpress.XtraGrid.Views.Base
Imports DevExpress.XtraGrid.Views.Grid
Imports MozartLib

Public Class frmGestionDroitFournituresBySerie

  Dim _DtListeMenuDroit As DataTable
  Dim _DtListePersByMenu As DataTable

  Private Sub frmGestionDroitFournituresBySerie_Load(sender As Object, e As EventArgs) Handles MyBase.Load

    LoadData()

  End Sub

  Private Sub LoadData()

    _DtListeMenuDroit = New DataTable

    Dim sqlcmd As New SqlCommand("[api_sp_ListeSerieFOMOZART]", MozartDatabase.cnxMozart)
    sqlcmd.CommandType = CommandType.StoredProcedure
    sqlcmd.Parameters.Add("@P_VLANGUE", SqlDbType.VarChar).Value = MozartParams.Langue
    sqlcmd.Parameters.Add("@P_BCFOACTIF", SqlDbType.Bit).Value = If(ChkBoxArchives.Checked = True, 0, 1)

    _DtListeMenuDroit.Load(sqlcmd.ExecuteReader)

    GCSERIEFO.DataSource = _DtListeMenuDroit

  End Sub

  Private Sub GVSERIEFO_FocusedRowChanged(sender As Object, e As FocusedRowChangedEventArgs) Handles GVSERIEFO.FocusedRowChanged

    If GVSERIEFO.FocusedRowHandle > -1 Then

      Dim dr As DataRow = GVSERIEFO.GetDataRow(e.FocusedRowHandle)

      LoadDroitBySerie(dr.Item("NCFOCOD"))

    End If

  End Sub

  Private Sub BtnFermer_Click(sender As Object, e As EventArgs) Handles BtnFermer.Click
    Me.Close()
  End Sub

  Private Sub LoadDroitBySerie(ByVal p_NCFOCOD As Int32)

    _DtListePersByMenu = New DataTable

    Dim sqlcmd As New SqlCommand("[api_sp_ListeDroitPersBySerieFO]", MozartDatabase.cnxMozart)
    sqlcmd.CommandType = CommandType.StoredProcedure
    sqlcmd.Parameters.Add("@P_NCFOCOD", SqlDbType.Int).Value = p_NCFOCOD
    sqlcmd.Parameters.Add("@P_VSOCIETE", SqlDbType.VarChar).Value = MozartParams.NomSociete
    _DtListePersByMenu.Load(sqlcmd.ExecuteReader)

    _DtListePersByMenu.Columns("CDROITVAL_EMALEC").ReadOnly = False
    _DtListePersByMenu.Columns("CDROITVAL_EQUIPAGE").ReadOnly = False
    _DtListePersByMenu.Columns("CDROITVAL_SCS").ReadOnly = False
    _DtListePersByMenu.Columns("CDROITVAL_MAGESTIME").ReadOnly = False
    _DtListePersByMenu.Columns("CDROITVAL_EMALECDEV").ReadOnly = False
    _DtListePersByMenu.Columns("CDROITVAL_EMALECESPAGNE").ReadOnly = False
    _DtListePersByMenu.Columns("CDROITVAL_EMALECIDF").ReadOnly = False
    _DtListePersByMenu.Columns("CDROITVAL_EMALECLUXEMBOURG").ReadOnly = False
    _DtListePersByMenu.Columns("CDROITVAL_EMALECFACILITEAM").ReadOnly = False
    _DtListePersByMenu.Columns("CDROITVAL_EMALECSUISSE").ReadOnly = False
    _DtListePersByMenu.Columns("CDROITVAL_EMALECMPM").ReadOnly = False
    _DtListePersByMenu.Columns("CDROITVAL_SAMSICROMANIA").ReadOnly = False
    _DtListePersByMenu.Columns("CDROITVAL_EMAFI").ReadOnly = False

    GCPersGroupe.DataSource = _DtListePersByMenu

  End Sub

  Private Sub GVPersGroupe_CustomRowCellEdit(sender As Object, e As CustomRowCellEditEventArgs) Handles GVPersGroupe.CustomRowCellEdit

    Dim dr As DataRow = GVPersGroupe.GetDataRow(e.RowHandle)

    If Not dr Is Nothing Then
      Select Case e.Column.FieldName
        Case "CDROITVAL_EMALEC"
          If IsDBNull(dr.Item("CDROITVAL_EMALEC")) Then
            e.RepositoryItem = Nothing
          Else
            e.RepositoryItem = RepositoryItemCheckEditEMALEC
          End If
        Case "CDROITVAL_EQUIPAGE"
          If IsDBNull(dr.Item("CDROITVAL_EQUIPAGE")) Then
            e.RepositoryItem = Nothing
          Else
            e.RepositoryItem = RepositoryItemCheckEditEQUIPAGE
          End If
        Case "CDROITVAL_SCS"
          If IsDBNull(dr.Item("CDROITVAL_SCS")) Then
            e.RepositoryItem = Nothing
          Else
            e.RepositoryItem = RepositoryItemCheckEditSCS
          End If
        Case "CDROITVAL_MAGESTIME"
          If IsDBNull(dr.Item("CDROITVAL_MAGESTIME")) Then
            e.RepositoryItem = Nothing
          Else
            e.RepositoryItem = RepositoryItemCheckEditMAGESTIME
          End If
        Case "CDROITVAL_EMALECDEV"
          If IsDBNull(dr.Item("CDROITVAL_EMALECDEV")) Then
            e.RepositoryItem = Nothing
          Else
            e.RepositoryItem = RepositoryItemCheckEditEMALECDEV
          End If
        Case "CDROITVAL_EMALECESPAGNE"
          If IsDBNull(dr.Item("CDROITVAL_EMALECESPAGNE")) Then
            e.RepositoryItem = Nothing
          Else
            e.RepositoryItem = RepositoryItemCheckEditEMALECESPAGNE
          End If
        Case "CDROITVAL_EMALECIDF"
          If IsDBNull(dr.Item("CDROITVAL_EMALECIDF")) Then
            e.RepositoryItem = Nothing
          Else
            e.RepositoryItem = RepositoryItemCheckEditEMALECIDF
          End If
        Case "CDROITVAL_EMALECLUXEMBOURG"
          If IsDBNull(dr.Item("CDROITVAL_EMALECLUXEMBOURG")) Then
            e.RepositoryItem = Nothing
          Else
            e.RepositoryItem = RepositoryItemCheckEditEMALECLUXEMBOURG
          End If
        Case "CDROITVAL_EMALECFACILITEAM"
          If IsDBNull(dr.Item("CDROITVAL_EMALECFACILITEAM")) Then
            e.RepositoryItem = Nothing
          Else
            e.RepositoryItem = RepositoryItemCheckEditEMALECFACILITEAM
          End If
        Case "CDROITVAL_EMALECSUISSE"
          If IsDBNull(dr.Item("CDROITVAL_EMALECSUISSE")) Then
            e.RepositoryItem = Nothing
          Else
            e.RepositoryItem = RepositoryItemCheckEditEMALECSUISSE
          End If
        Case "CDROITVAL_EMALECMPM"
          If IsDBNull(dr.Item("CDROITVAL_EMALECMPM")) Then
            e.RepositoryItem = Nothing
          Else
            e.RepositoryItem = RepositoryItemCheckEditEMALECMPM
          End If
        Case "CDROITVAL_SAMSICROMANIA"
          If IsDBNull(dr.Item("CDROITVAL_SAMSICROMANIA")) Then
            e.RepositoryItem = Nothing
          Else
            e.RepositoryItem = RepositoryItemCheckEditSAMSICROMANIA
          End If
        Case "CDROITVAL_EMAFI"
          If IsDBNull(dr.Item("CDROITVAL_EMAFI")) Then
            e.RepositoryItem = Nothing
          Else
            e.RepositoryItem = RepositoryItemCheckEditSAMSICITALIA
          End If
      End Select

    End If

  End Sub

  Private Sub RepositoryItemCheckEditEMALEC_CheckedChanged(sender As Object, e As EventArgs) Handles RepositoryItemCheckEditEMALEC.CheckedChanged
    UpdateDroit(sender, "EMALEC")
  End Sub

  Private Sub RepositoryItemCheckEditEMALECDEV_CheckedChanged(sender As Object, e As EventArgs) Handles RepositoryItemCheckEditEMALECDEV.CheckedChanged
    UpdateDroit(sender, "EMALECDEV")
  End Sub

  Private Sub RepositoryItemCheckEditEMALECESPAGNE_CheckedChanged(sender As Object, e As EventArgs) Handles RepositoryItemCheckEditEMALECESPAGNE.CheckedChanged
    UpdateDroit(sender, "EMALECESPAGNE")
  End Sub

  Private Sub RepositoryItemCheckEditEMALECFACILITEAM_CheckedChanged(sender As Object, e As EventArgs) Handles RepositoryItemCheckEditEMALECFACILITEAM.CheckedChanged
    UpdateDroit(sender, "EMALECFACILITEAM")
  End Sub

  Private Sub RepositoryItemCheckEditEMALECIDF_CheckedChanged(sender As Object, e As EventArgs) Handles RepositoryItemCheckEditEMALECIDF.CheckedChanged
    UpdateDroit(sender, "EMALECIDF")
  End Sub

  Private Sub RepositoryItemCheckEditEMALECLUXEMBOURG_CheckedChanged(sender As Object, e As EventArgs) Handles RepositoryItemCheckEditEMALECLUXEMBOURG.CheckedChanged
    UpdateDroit(sender, "EMALECLUXEMBOURG")
  End Sub

  Private Sub RepositoryItemCheckEditEMALECMPM_CheckedChanged(sender As Object, e As EventArgs) Handles RepositoryItemCheckEditEMALECMPM.CheckedChanged
    UpdateDroit(sender, "EMALECMPM")
  End Sub

  Private Sub RepositoryItemCheckEditEMALECSUISSE_CheckedChanged(sender As Object, e As EventArgs) Handles RepositoryItemCheckEditEMALECSUISSE.CheckedChanged
    UpdateDroit(sender, "EMALECSUISSE")
  End Sub

  Private Sub RepositoryItemCheckEditEQUIPAGE_CheckedChanged(sender As Object, e As EventArgs) Handles RepositoryItemCheckEditEQUIPAGE.CheckedChanged
    UpdateDroit(sender, "EMALECEQUIPAGE")
  End Sub

  Private Sub RepositoryItemCheckEditMAGESTIME_CheckedChanged(sender As Object, e As EventArgs) Handles RepositoryItemCheckEditMAGESTIME.CheckedChanged
    UpdateDroit(sender, "MAGESTIME")
  End Sub

  Private Sub RepositoryItemCheckEditSAMSICROMANIA_CheckedChanged(sender As Object, e As EventArgs) Handles RepositoryItemCheckEditSAMSICROMANIA.CheckedChanged
    UpdateDroit(sender, "SAMSICROMANIA")
  End Sub

  Private Sub RepositoryItemCheckEditSCS_CheckedChanged(sender As Object, e As EventArgs) Handles RepositoryItemCheckEditSCS.CheckedChanged
    UpdateDroit(sender, "SCS")
  End Sub

  Private Sub RepositoryItemCheckEditSAMSICITALIA_CheckedChanged(sender As Object, e As EventArgs) Handles RepositoryItemCheckEditSAMSICITALIA.CheckedChanged
    UpdateDroit(sender, "EMAFI")
  End Sub

  Private Sub UpdateDroit(ByVal sender As Object, ByVal p_vsociete As String)

    Dim dr As DataRow = GVPersGroupe.GetDataRow(GVPersGroupe.FocusedRowHandle)

    Dim drSerie As DataRow = GVSERIEFO.GetDataRow(GVSERIEFO.FocusedRowHandle)

    If Not dr Is Nothing And Not drSerie Is Nothing Then

      Dim check As CheckEdit = TryCast(sender, CheckEdit)

      Dim sqlcmdUpdate As New SqlCommand("[api_sp_UpdateDroitSerieFOMOZART]", MozartDatabase.cnxMozart)
      sqlcmdUpdate.CommandType = CommandType.StoredProcedure
      sqlcmdUpdate.Parameters.Add("@P_VPERADSI", SqlDbType.VarChar).Value = dr.Item("VPERADSI").ToString
      sqlcmdUpdate.Parameters.Add("@P_NCFOCOD", SqlDbType.Int).Value = drSerie.Item("NCFOCOD")
      sqlcmdUpdate.Parameters.Add("@P_VSOCIETE_SRC", SqlDbType.VarChar).Value = p_vsociete
      If check.CheckState = CheckState.Checked Then
        sqlcmdUpdate.Parameters.Add("@P_VALUE", SqlDbType.Char).Value = "O"
      Else
        sqlcmdUpdate.Parameters.Add("@P_VALUE", SqlDbType.Char).Value = "N"
      End If
      sqlcmdUpdate.ExecuteNonQuery()

    End If

  End Sub

  Private Sub frmGestionDroitFournituresBySerie_ResizeEnd(sender As Object, e As EventArgs) Handles Me.ResizeEnd

    GCPersGroupe.Size = New Size(Me.Size.Width - GCPersGroupe.Location.X - 50, Me.Size.Height - GCPersGroupe.Location.Y - 50)

  End Sub

  Private Sub frmGestionDroitFournituresBySerie_SizeChanged(sender As Object, e As EventArgs) Handles Me.SizeChanged
    GCPersGroupe.Size = New Size(Me.Size.Width - GCPersGroupe.Location.X - 50, Me.Size.Height - GCPersGroupe.Location.Y - 50)
  End Sub

  Private Sub ChkBoxArchives_CheckedChanged(sender As Object, e As EventArgs) Handles ChkBoxArchives.Click

    LoadData()

  End Sub
End Class