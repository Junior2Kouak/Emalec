Imports System.Data.SqlClient
Imports System.IO
Imports MozartLib


Public Class frmGestContratsSites

  Dim dsContrat As New DataSet
  Dim dsSite As New DataSet
  Dim dsMain As New DataSet

  Dim cmdGrid As New SqlCommand("", MozartDatabase.cnxMozart)
  Dim drGrid As New SqlDataAdapter

  Dim cmdContrat As New SqlCommand("", MozartDatabase.cnxMozart)
  Dim cmdSite As New SqlCommand("", MozartDatabase.cnxMozart)
  Dim cmdMain As New SqlCommand("", MozartDatabase.cnxMozart)

  Dim drContrat As New SqlDataAdapter
    Dim drSite As New SqlDataAdapter
    Dim drMain As New SqlDataAdapter

    Dim iSite As Long

    Private Sub frmGestContratsSites_Load(ByVal sender As Object, ByVal e As System.EventArgs) Handles Me.Load

        cmdContrat.CommandText = "SELECT TCONTRATCLI.NTYPECONTRAT,VTYPECONTRAT " _
            & " FROM TCONTRATCLI WITH (NOLOCK),TREF_TYPECONTRAT WITH (NOLOCK) WHERE NCLINUM=1812 AND TCONTRATCLI.NTYPECONTRAT = TREF_TYPECONTRAT.NTYPECONTRAT " _
            & " AND LANGUE = 'FR' ORDER BY VTYPECONTRAT "
        drContrat.SelectCommand = cmdContrat
        dsContrat.Clear()
        drContrat.Fill(dsContrat)

        GridContrat.DataSource = dsContrat.Tables(0)



    End Sub

  Private Sub GridContrat_MouseUp(ByVal sender As Object, ByVal e As System.Windows.Forms.MouseEventArgs) Handles GridContrat.MouseUp
    If e.Button = Windows.Forms.MouseButtons.Right Then
      MenuForm.Show()
    End If
  End Sub

  Private Sub GridViewContrat_FocusedRowChanged(ByVal sender As Object, ByVal e As DevExpress.XtraGrid.Views.Base.FocusedRowChangedEventArgs) Handles GridViewContrat.FocusedRowChanged
    ' TB SAMSIC CITY SPEC
    ' NCLINUM spécifique dans la requête (1812) à la cinquième ligne
    cmdMain.CommandText = "SELECT TSIT.NSITNUM, VTYPECONTRAT, VSITNOM, VSITPAYS,VSITENSEIGNE, NSITNUE, VSITREG, CASE WHEN NSITPRIO = 1 THEN 'OUI' ELSE 'NON' END AS NSITPRIO, VLIBTYPESITE,NSITSFV, VCONTETAT,  NNBEQUIP, NNBVISANNUEL, NDUREEINTER, NMONTANTINTER, DDEBP2, DFINP2, NMONTANTP3 , DDEBP3, DFINP3, TCONT.NTYPECONTRAT " _
            & "From TCONT WITH (NOLOCK), TSIT WITH (NOLOCK), TREF_TYPECONTRAT WITH (NOLOCK),TREF_TYPESITE WITH (NOLOCK)" _
            & " WHERE TCONT.NSITNUM = TSIT.NSITNUM   and csitactif='O' and TCONT.NTYPECONTRAT = TREF_TYPECONTRAT.NTYPECONTRAT" _
            & " AND TREF_TYPECONTRAT.NTYPECONTRAT = " & GridViewContrat.GetDataRow(e.FocusedRowHandle).Item(0).ToString _
            & " AND  TREF_TYPESITE.NTYPESITE = TSIT.NSITTYPE AND TSIT.NCLINUM = 1812" _
            & " AND TREF_TYPECONTRAT.LANGUE = 'FR' AND TREF_TYPESITE.LANGUE = 'FR' ORDER BY VSITNOM"

    drMain.SelectCommand = cmdMain
    dsMain.Clear()
    drMain.Fill(dsMain)

    GridMain.DataSource = dsMain.Tables(0)

  End Sub

  Private Sub Button1_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button1.Click
        cmdSite.CommandText = "select VSITNOM, VTYPECONTRAT, VCONTETAT, NNBVISANNUEL, NDUREEINTER, NMONTANTINTER, NMONTANTP3, TCONT.NTYPECONTRAT " _
            & "from TCONT WITH (NOLOCK), TSIT WITH (NOLOCK), TCONTRATCLI WITH (NOLOCK), TREF_TYPECONTRAT WITH (NOLOCK) " _
            & "WHERE TCONT.NSITNUM = TSIT.NSITNUM  and TCONT.NSITNUM = " & GridViewMain.GetDataRow(GridViewMain.FocusedRowHandle).Item(0).ToString _
            & " AND TCONTRATCLI.NCLINUM = TSIT.NCLINUM " _
            & " AND TCONTRATCLI.NTYPECONTRAT = TCONT.NTYPECONTRAT " _
            & " AND TCONT.NTYPECONTRAT = TREF_TYPECONTRAT.NTYPECONTRAT AND LANGUE = 'FR'" _
            & " ORDER BY VCONTETAT desc"

        drSite.SelectCommand = cmdSite
        dsSite.Clear()
        drSite.Fill(dsSite)

        GridSite.DataSource = dsSite.Tables(0)

    End Sub


    Private Sub GridViewMain_FocusedRowChanged(ByVal sender As Object, ByVal e As DevExpress.XtraGrid.Views.Base.FocusedRowChangedEventArgs) Handles GridViewMain.FocusedRowChanged
        'If GridViewMain.FocusedRowHandle >= 0 Then
        '    If iSite <> CLng(GridViewMain.GetDataRow(GridViewMain.FocusedRowHandle).Item(0).ToString) Then
        '        iSite = CLng(GridViewMain.GetDataRow(GridViewMain.FocusedRowHandle).Item(0).ToString)
        '        'MsgBox("focuschange")
        '    End If
        'End If
    End Sub

    Private Sub GridViewMain_SelectionChanged(ByVal sender As Object, ByVal e As DevExpress.Data.SelectionChangedEventArgs) Handles GridViewMain.SelectionChanged
        MsgBox("Selection changed")
    End Sub
End Class
