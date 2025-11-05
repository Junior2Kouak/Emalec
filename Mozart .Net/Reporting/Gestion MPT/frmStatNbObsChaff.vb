Imports System.Data.SqlClient
Imports DevExpress.XtraPrinting
Imports DevExpress.XtraPrintingLinks
Imports MozartLib

Public Class frmStatNbObsChaff

  Dim dtStatNbrObsByChaff As DataTable

  Private Sub frmStatNbObsChaff_Load(sender As System.Object, e As System.EventArgs) Handles MyBase.Load

    LblTitre.Text = LblTitre.Text & My.Resources.Global_le & Date.Today

    ChargeListe()

  End Sub

  Private Sub ChargeListe()
    Try

      Me.Cursor = Cursors.WaitCursor

      dtStatNbrObsByChaff = New DataTable

      Dim CmdSql As New SqlCommand("[api_sp_StatGraphNbrObsByChaff]", MozartDatabase.cnxMozart)
      CmdSql.CommandType = CommandType.StoredProcedure

        dtStatNbrObsByChaff.Load(CmdSql.ExecuteReader)

        ChartCtrlStatNbrObsByChaff.DataSource = dtStatNbrObsByChaff

        CmdSql.Dispose()

    Catch ex As Exception
            MessageBox.Show(My.Resources.GestionMPT_frmStatNbObsChaff_sub + ex.Message, My.Resources.Global_Erreur)
        Finally
      Me.Cursor = Cursors.Default
    End Try
  End Sub

  Private Sub BtnFermer_Click(sender As System.Object, e As System.EventArgs) Handles BtnFermer.Click
    Me.Close()
  End Sub

  Private Sub BtnPrint_Click(sender As System.Object, e As System.EventArgs) Handles BtnPrint.Click

        If MessageBox.Show(My.Resources.Global_print_graphe, My.Resources.Global_Impression, MessageBoxButtons.YesNoCancel, MessageBoxIcon.Question) = vbYes Then

            Dim AllPageLink As CompositeLink = New CompositeLink(New PrintingSystem())

            Dim pcLinkGraph As PrintableComponentLink = New PrintableComponentLink()

            pcLinkGraph.Component = ChartCtrlStatNbrObsByChaff

            pcLinkGraph.Landscape = True

            AllPageLink.Links.Add(pcLinkGraph)

            AllPageLink.Links(0).Margins.Left = 2
            AllPageLink.Links(0).Margins.Right = 2
            AllPageLink.Links(0).Margins.Top = 2
            AllPageLink.Links(0).Margins.Bottom = 2
            AllPageLink.Links(0).Landscape = True

            AllPageLink.CreatePageForEachLink()

            AllPageLink.PrintDlg()

        End If

    End Sub
End Class