Imports System.Data.SqlClient
Imports DevExpress.XtraGrid.Views.Base
Imports MozartLib

Public Class frmListeSortiesStockToutesAvecDetFou


  Dim DTListeSS As DataTable

  Private Sub frmListeSortiesStockToutesAvecDetFou_Load(sender As Object, e As EventArgs) Handles MyBase.Load

    LoadData()

  End Sub

  Private Sub LoadData()

    DTListeSS = New DataTable

    Dim sqlcmdLoad As New SqlCommand("[api_sp_ListeToutesSortiesStockAvecDetailFou]", MozartDatabase.cnxMozart)
    sqlcmdLoad.CommandType = CommandType.StoredProcedure
    DTListeSS.Load(sqlcmdLoad.ExecuteReader)

    GCLISTE_SS.DataSource = DTListeSS

  End Sub

  Private Sub GVLISTE_SS_CustomDrawFooter(sender As Object, e As RowObjectCustomDrawEventArgs) Handles GVLISTE_SS.CustomDrawFooter

    If Not DTListeSS Is Nothing AndAlso DTListeSS.Rows.Count > 0 Then

      Dim oPos As Rectangle = e.Bounds
      Dim oFormat As New StringFormat

      oPos.Location = New Point(oPos.Left + 1, oPos.Top + 1)
      oPos.Size = New Size(oPos.Width - 2, oPos.Height - 2)

      oFormat.Alignment = StringAlignment.Center

      Dim dttemp As DataTable = DTListeSS.Copy

      If dttemp.Select(DevExpress.Data.Filtering.CriteriaToWhereClauseHelper.GetDataSetWhere(GVLISTE_SS.ActiveFilterCriteria)).Count = dttemp.Rows.Count Then
        e.Appearance.DrawString(e.Cache, String.Format("total : {0}", dttemp.Rows.Count), oPos, oFormat)
        e.Handled = True
      Else
        e.Appearance.DrawString(e.Cache, String.Format("total filtré : {0} / total : {1}", dttemp.Select(DevExpress.Data.Filtering.CriteriaToWhereClauseHelper.GetDataSetWhere(GVLISTE_SS.ActiveFilterCriteria)).Count, dttemp.Rows.Count), oPos, oFormat)
        e.Handled = True
      End If

    End If

  End Sub

  Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
    SFD.Filter = "Fichiers XLSX |*.XLSX"
    SFD.ShowDialog()

    If SFD.FileName <> "" Then
      GVLISTE_SS.ExportToXlsx(SFD.FileName)
    End If
  End Sub

  Private Sub BtnFermer_Click(sender As Object, e As EventArgs) Handles BtnFermer.Click
    Me.Close()
  End Sub

End Class