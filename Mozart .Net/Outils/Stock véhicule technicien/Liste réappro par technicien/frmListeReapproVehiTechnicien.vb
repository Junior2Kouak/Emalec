Imports System.Data.SqlClient
Imports DevExpress.XtraPrinting
Imports MozartLib

Public Class frmListeReapproVehiTechnicien

  Private Sub frmListeReapproVehiTechnicien_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load

    chargeListe()

  End Sub

  Private Sub chargeListe()

    Try

      Me.Cursor = Cursors.WaitCursor
      'on ouvre la connexion
      If MozartDatabase.cnxMozart.State = ConnectionState.Open Then

        Dim CmdSql As New SqlCommand("api_sp_SyntListeReapproTech", MozartDatabase.cnxMozart) With {.CommandType = CommandType.StoredProcedure}

        Dim sqlAdpat As SqlDataAdapter = New SqlDataAdapter(CmdSql)
        Dim dtStat As New DataSet
        sqlAdpat.Fill(dtStat)

        GCListeReapproVehiculeTechnicien.DataSource = dtStat.Tables(0)

        CmdSql.Dispose()

        GCListeReapproVehiculeTechnicien.Focus()

      End If

    Catch ex As Exception
      MessageBox.Show(My.Resources.Admin_frmListeReapproVehiTechnicien_SubLoad + ex.Message, My.Resources.Global_Erreur)
    Finally
      Me.Cursor = Cursors.Default
    End Try

  End Sub

  Private Sub BtnFermer_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles BtnFermer.Click
    Me.Close()
  End Sub

  Private Sub BtnExportXLS_Click(sender As Object, e As EventArgs) Handles BtnExportXLS.Click

    SFD.FileName = ""

    Dim options = New XlsxExportOptionsEx()
    options.ExportType = DevExpress.Export.ExportType.WYSIWYG


    SFD.Filter = "Fichiers EXCEL (*.xlsx)|*.xlsx"
    SFD.ShowDialog()

    If SFD.FileName <> "" Then

      GVListereapproVehiculeTech.OptionsPrint.AutoWidth = False
      GVListereapproVehiculeTech.ExportToXlsx(SFD.FileName, options)

    End If
  End Sub
End Class