Imports System.Data.SqlClient
Imports System.Windows.Forms
Imports MozartLib

Public Class FrmDetailIp

  Dim liNumDI As Long

  Public miNumIP As Long
  Public sNumAct As String
  Property numDI As Long
  Property numACT As Long

  Dim da As New SqlDataAdapter()

  Private Sub btnDetails_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnDetails.Click, grdDataGridAction.DoubleClick
    numDI = CLng(grdDataGridAction.CurrentRow.Cells(0).Value.ToString.Replace("Di", ""))
    numACT = CLng(grdDataGridAction.CurrentRow.Cells(10).Value)
    Me.DialogResult = System.Windows.Forms.DialogResult.OK
    Me.Close()
  End Sub

  Private Sub Button2_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnFermer.Click
    Me.DialogResult = System.Windows.Forms.DialogResult.Cancel
    Me.Close()
  End Sub

  Private Sub Dialog1_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load

    Dim table As New DataTable()

    Try
      ' recherche des actions de cette IP
      Me.da = New SqlDataAdapter("exec api_sp_listeActionIP " & miNumIP, MozartDatabase.cnxMozart)
      Me.da.Fill(table)

            ' liaison du recordset et du datagrid
            grdDataGridAction.DataSource = table
            FormatDataGrid()

        Catch ex As SqlException
            MessageBox.Show(ex.Message)
        End Try

    End Sub

    Private Sub FormatDataGrid()
        grdDataGridAction.Columns(0).HeaderText = "NumDI"

        grdDataGridAction.Columns(1).HeaderText = My.Resources.Planification_FrmDetaillP_date

        grdDataGridAction.Columns(2).HeaderText = My.Resources.Planification_FrmDetaillP_Action
        grdDataGridAction.Columns(3).HeaderText = My.Resources.Planification_FrmDetaillP_DateEx
        grdDataGridAction.Columns(4).HeaderText = My.Resources.Planification_FrmDetaillP_Etat
        grdDataGridAction.Columns(5).HeaderText = My.Resources.Planification_FrmDetaillP_Durée
        grdDataGridAction.Columns(6).HeaderText = "Urg"
        grdDataGridAction.Columns(7).HeaderText = "Pres"
        grdDataGridAction.Columns(8).HeaderText = "Tech"
        grdDataGridAction.Columns(9).HeaderText = "Obs"
        grdDataGridAction.Columns(10).HeaderText = My.Resources.Planification_FrmDetaillP_NumAction

        grdDataGridAction.Columns(0).Width = 54
        grdDataGridAction.Columns(1).Width = 80
        grdDataGridAction.Columns(2).Width = 290
        grdDataGridAction.Columns(3).Width = 80
        grdDataGridAction.Columns(4).Width = 40
        grdDataGridAction.Columns(5).Width = 44
        grdDataGridAction.Columns(6).Width = 35
        grdDataGridAction.Columns(7).Width = 40
        grdDataGridAction.Columns(8).Width = 40
        grdDataGridAction.Columns(9).Width = 70
        grdDataGridAction.Columns(10).Width = 0

    End Sub

    'Private Sub grdDataGridAction_DoubleClick(ByVal sender As Object, ByVal e As System.EventArgs) Handles grdDataGridAction.DoubleClick

    'End Sub
End Class
