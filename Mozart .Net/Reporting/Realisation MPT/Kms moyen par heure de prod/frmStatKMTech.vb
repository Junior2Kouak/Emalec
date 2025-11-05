Imports DevExpress.XtraCharts
Imports DevExpress.XtraPrinting
Imports MozartLib

Public Class frmStatKMTech

  Dim oGestConnectSQL As New CGestionSQL
  Dim dtStatKMS As DataTable


  Private Sub frmStatKMTech_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load

    Try

      'on ouvre la connexion
      If oGestConnectSQL.ConnexionSQL(MozartParams.NomServeur, MozartParams.NomSociete) = True Then

        dtStatKMS = New DataTable
        dtStatKMS = ModDataGridView.LoadList("api_sp_StatistiqueKmTech", oGestConnectSQL.CnxSQLOpen)

        PGCStatKms.DataSource = dtStatKMS

        Dim DataVi As DataView = dtStatKMS.AsDataView
        ChartCtrl.DataSource = DataVi.ToTable("", False, "MOISANNEE", "KMHR")
        Dim yx As XYDiagram = ChartCtrl.Diagram

        ' droite de la moyenne
        yx.AxisY.ConstantLines(0).AxisValue = 24
        yx.AxisY.ConstantLines(0).Title.Text = My.Resources.Reporting_RealisationMPT_frmStatKMTech_objectif

        lblPerim.Text = My.Resources.Reporting_RealisationMPT_frmStatKMTech_data_maj & vbCrLf _
                        & My.Resources.Reporting_RealisationMPT_frmStatKMTech_data_pas_fiables & vbCrLf _
                        & My.Resources.Reporting_RealisationMPT_frmStatKMTech_prod_hours & vbCrLf _
                        & My.Resources.Reporting_RealisationMPT_frmStatKMTech_analyse & vbCrLf

        lblMoy12.Text = lblMoy12.Text & vbCrLf & FormatNumber(CalculMoyenne12(), 2)

      End If

    Catch ex As Exception
      MessageBox.Show(My.Resources.Reporting_RealisationMPT_frmStatKMTech_sub + ex.Message, My.Resources.Global_Erreur)
    End Try

  End Sub

  Private Sub PGCStatKms_FieldValueDisplayText(ByVal sender As Object, ByVal e As DevExpress.XtraPivotGrid.PivotFieldDisplayTextEventArgs) Handles PGCStatKms.FieldValueDisplayText

    If e.Field.FieldName = "periode" Then

      Dim year As String = e.Value.ToString.Substring(0, 4)

      Dim month As String = MonthName(e.Value.ToString.Substring(4, 2), True)

      e.DisplayText = String.Format("{0} {1}", month, year)

    End If

  End Sub

  Private Sub BtnPrint_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles BtnPrint.Click

    If MessageBox.Show(My.Resources.Global_print_graphe, My.Resources.Global_impression_graphique, MessageBoxButtons.YesNoCancel, MessageBoxIcon.Question) = vbYes Then

      Dim link As New PrintableComponentLink(New PrintingSystem())

      link.Component = ChartCtrl
      link.Landscape = True
      link.Margins.Left = 7
      link.Margins.Right = 7
      link.Margins.Top = 7
      link.Margins.Bottom = 7

      link.CreateDocument()

      link.PrintingSystem.Document.AutoFitToPagesWidth = 1

      link.PrintDlg()

    End If

  End Sub

  Private Function CalculMoyenne12() As Decimal

    Dim j As Integer
    CalculMoyenne12 = 0

    For j = 0 To 11
      CalculMoyenne12 += dtStatKMS.Rows(j).Item(7)
    Next

    Return CalculMoyenne12 / 12
  End Function

  Private Sub BtnFermer_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles BtnFermer.Click
    Me.Close()
  End Sub

  Private Sub frmStatKMTech_FormClosed(ByVal sender As Object, ByVal e As System.Windows.Forms.FormClosedEventArgs) Handles Me.FormClosed
    oGestConnectSQL.CloseConnexionSQL()
  End Sub

End Class