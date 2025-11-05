Imports DevExpress.XtraCharts
Imports MozartLib

Public Class frmStatMagasin

  Dim oGestConnectSQL As New CGestionSQL
  Dim dtStatMag1 As DataTable
  Dim dtStatMag2 As DataTable


  Private Sub frmStatMagasin_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load

    Timer1.Enabled = True

  End Sub

  Private Sub BtnPrint_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles BtnPrint.Click
    Dim oScreenShot As New CSreenShot(Me, True)
    oScreenShot.Print_Form()
  End Sub

  Private Sub GVhaut_CustomColumnDisplayText(sender As Object, e As DevExpress.XtraGrid.Views.Base.CustomColumnDisplayTextEventArgs)
    If e.Column.FieldName = "LIB" Then
      Dim year As String = e.Value.ToString.Substring(0, 4)
      Dim month As String = MonthName(e.Value.ToString.Substring(5, 2), True)
      e.DisplayText = String.Format("{0} {1}", month, year)
    End If
  End Sub

  Private Sub GVbas_CustomColumnDisplayText(sender As Object, e As DevExpress.XtraGrid.Views.Base.CustomColumnDisplayTextEventArgs)
    If e.Column.FieldName = "LIB" Then
      Dim year As String = e.Value.ToString.Substring(0, 4)
      Dim month As String = MonthName(e.Value.ToString.Substring(5, 2), True)
      e.DisplayText = String.Format("{0} {1}", month, year)
    End If
  End Sub

  Private Function CalculMoyenne12(dt As DataTable) As Decimal

    Dim j As Integer
    CalculMoyenne12 = 0

    For j = 24 To 35
      CalculMoyenne12 += dt.Rows(j).Item(7)
    Next

    Return CalculMoyenne12 / 12
  End Function

  Private Function CalculMoyenne12_2(dt As DataTable) As Decimal

    Dim j As Integer
    CalculMoyenne12_2 = 0

    For j = 24 To 35
      CalculMoyenne12_2 += dt.Rows(j).Item(3)
    Next

    Return CalculMoyenne12_2 / 12
  End Function

  Private Sub BtnFermer_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles BtnFermer.Click
    Me.Close()
  End Sub

  Private Sub frmStatMagasin_FormClosed(ByVal sender As Object, ByVal e As System.Windows.Forms.FormClosedEventArgs) Handles Me.FormClosed
    oGestConnectSQL.CloseConnexionSQL()
  End Sub

  Private Sub Timer1_Tick(sender As System.Object, e As System.EventArgs) Handles Timer1.Tick

    Timer1.Enabled = False

    Try

      Me.Cursor = Cursors.WaitCursor
      'on ouvre la connexion
      If oGestConnectSQL.ConnexionSQL(MozartParams.NomServeur, MozartParams.NomSociete) = True Then

        ' ---------------- traitement graph haut --------------------------------------------
        dtStatMag1 = New DataTable
        dtStatMag1 = ModDataGridView.LoadList("api_sp_StatQualDelaiExp_v2", oGestConnectSQL.CnxSQLOpen)
        lblPerim.Text = My.Resources.Reporting_Magasin_frmStatMagasin_compare & vbCrLf _
        & My.Resources.Reporting_Magasin_frmStatMagasin_msg & vbCrLf

        ' moyenne sur les 12 dernier mois
        Dim Moy1 As Decimal = CalculMoyenne12(dtStatMag1)
        lblMoy12.Text = lblMoy12.Text & vbCrLf & FormatNumber(Moy1, 1) & "%"
        Dim ConstHaut As XYDiagram = ChartHaut.Diagram
        ConstHaut.AxisY.ConstantLines(0).AxisValue = 98
        ConstHaut.AxisY.ConstantLines(0).Title.Text = My.Resources.Global_objectif
        GCStatHaut.DataSource = dtStatMag1
        ChartHaut.DataSource = dtStatMag1

        ' ---------------- traitement graph bas --------------------------------------------
        dtStatMag2 = New DataTable
        dtStatMag2 = ModDataGridView.LoadList("api_sp_StatQualCmdStock_v2", oGestConnectSQL.CnxSQLOpen)
        lblPerim2.Text = My.Resources.Reporting_Magasin_frmStatMagasin_nbr_expé & vbCrLf
        'LblTitre.Text = "Nombre d'expéditions"
        ' moyenne sur les 12 dernier mois
        Dim Moy2 As Decimal = CalculMoyenne12_2(dtStatMag2)
        lblMoy2.Text = lblMoy2.Text & vbCrLf & FormatNumber(Moy2, 0)
        Dim Constbas As XYDiagram = ChartBas.Diagram
        Constbas.AxisY.ConstantLines(0).AxisValue = lblMoy2.Text

        'Constbas.AxisY.ConstantLines(0).Visible = False
        GCstatBas.DataSource = dtStatMag2
        ChartBas.DataSource = dtStatMag2

      End If

    Catch ex As Exception
      MessageBox.Show(My.Resources.Reporting_Magsin_frmStatMagasin_sub + ex.Message, My.Resources.Global_Erreur)
    Finally
      Me.Cursor = Cursors.Default
    End Try
  End Sub
End Class
