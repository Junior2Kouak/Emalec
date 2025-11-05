Imports System.Data.SqlClient
Imports DevExpress.XtraPrinting
Imports DevExpress.XtraPrintingLinks
Imports DevExpress.XtraGrid
Imports MozartLib

Public Class frmListeStockFiliales

  Private Sub frmListeStockFiliales_Load(ByVal sender As Object, ByVal e As EventArgs) Handles MyBase.Load

    LblSociete.Text = MozartParams.NomSociete
    ChargeListe()

  End Sub

  Private Sub ChargeListe()
    Try

      Cursor = Cursors.WaitCursor
      'on ouvre la connexion
      If MozartDatabase.cnxMozart.State = ConnectionState.Open Then

        Dim CmdSql As New SqlCommand("api_sp_ListeFournituresStockVisu", MozartDatabase.cnxMozart) With {.CommandType = CommandType.StoredProcedure}
        CmdSql.Parameters.Add("@vsociete", SqlDbType.VarChar).Value = MozartParams.NomSociete
        CmdSql.Parameters.Add("@npernum", SqlDbType.VarChar).Value = MozartParams.UID

        Dim sqlAdpat As SqlDataAdapter = New SqlDataAdapter(CmdSql)
        Dim dtStat As New DataSet
        sqlAdpat.Fill(dtStat)

        GCListeFournitures.DataSource = dtStat.Tables(0)

        CmdSql.Dispose()

      End If

    Catch ex As Exception
      MessageBox.Show(My.Resources.Admin_frmListeStockFiliales_SubLoad + ex.Message, My.Resources.Global_Erreur)
    Finally
      Cursor = Cursors.Default
    End Try
  End Sub


  Private Sub BtnFermer_Click(ByVal sender As Object, ByVal e As EventArgs) Handles BtnFermer.Click
    Close()
  End Sub

  Private Sub BtnImprimer_Click(ByVal sender As Object, ByVal e As EventArgs) Handles BtnImprimer.Click
    SDF.AddExtension = True
    SDF.Filter = "Fichier PDF (*.PDF)|.PDF"
    SDF.ShowDialog()

    If SDF.FileName <> "" Then

      CreateExportPDF(GCListeFournitures, SDF.FileName)

    End If
  End Sub

  Private Shared Function CreateExportPDF(ByVal OGCTRL As GridControl, ByVal sFileName As String) As String

    Try

      Dim ps As New PrintingSystemBase

      Dim Link As New PrintableComponentLinkBase(ps) With {.Component = OGCTRL}
      Link.Margins.Bottom = 10
      Link.Margins.Left = 10
      Link.Margins.Top = 10
      Link.Margins.Right = 10

      Link.CreateDocument()

      Link.PrintingSystemBase.ExportToPdf(sFileName)

      Return sFileName

    Catch ex As Exception

      MessageBox.Show(ex.Message)
      Return ""

    End Try

  End Function
End Class

