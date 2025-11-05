Imports System.Data.SqlClient
Imports DevExpress.XtraCharts
Imports MozartLib

Public Class frmFraisGeneraux

  Dim oGestConnectSQL As New CGestionSQL
  Dim dtStat As DataSet

  Private Sub frmFraisGeneraux_FormClosed(sender As Object, e As System.Windows.Forms.FormClosedEventArgs) Handles Me.FormClosed
    oGestConnectSQL.CloseConnexionSQL()
  End Sub

  Private Sub frmFraisGeneraux_Load(sender As System.Object, e As System.EventArgs) Handles MyBase.Load
    Try


      'on ouvre la connexion
      If oGestConnectSQL.ConnexionSQL(MozartParams.NomServeur, MozartParams.NomSociete) = True Then
        LoadStat()
      End If

    Catch ex As Exception
      MessageBox.Show(My.Resources.TabSyntheseCompta_frmGraisGeneraux_sub + ex.Message, My.Resources.Global_Erreur)
    End Try
  End Sub


  Private Sub LoadStat()

    Try
      Dim CmdSql As New SqlCommand("api_sp_IndicateurFraisGeneraux", oGestConnectSQL.CnxSQLOpen)

      CmdSql.CommandType = CommandType.StoredProcedure
      Dim dr As SqlDataAdapter = New SqlDataAdapter(CmdSql)
      dtStat = New DataSet

      dr.Fill(dtStat)

      ' EDF /GDF :
      ChartCtrlPer.DataSource = dtStat.Tables(0)

      Dim dtc As System.Data.DataTable = dtStat.Tables(1)
      Dim s As String = dtc.DataSet.Tables(1).Rows(0).ItemArray.GetValue(0)
      lblMoy1.Text = lblMoy1.Text & vbCrLf & s & " €"

      ' Gaz de France :
      ChartControl1.DataSource = dtStat.Tables(2)

      dtc = dtStat.Tables(3)
      s = dtc.DataSet.Tables(3).Rows(0).ItemArray.GetValue(0)
      lblMoy2.Text = lblMoy2.Text & vbCrLf & s & " €"

      ' Téléphonie :
      ChartControl2.DataSource = dtStat.Tables(4)

      dtc = dtStat.Tables(5)
      s = dtc.DataSet.Tables(5).Rows(0).ItemArray.GetValue(0)
      lblMoy3.Text = lblMoy3.Text & vbCrLf & s & " €"

      ' Carburant :
      ChartControl3.DataSource = dtStat.Tables(6)

      dtc = dtStat.Tables(7)
      s = dtc.DataSet.Tables(7).Rows(0).ItemArray.GetValue(0)
      lblMoy4.Text = lblMoy4.Text & vbCrLf & s & " €"


      Dim oAxis As XYDiagram = ChartCtrlPer.Diagram
      oAxis.AxisY.Title.Text = My.Resources.Global_MONTANT_euro
      oAxis.AxisY.Title.Visibility = DevExpress.Utils.DefaultBoolean.True

      oAxis = ChartControl1.Diagram
      oAxis.AxisY.Title.Text = My.Resources.Global_MONTANT_euro
      oAxis.AxisY.Title.Visibility = DevExpress.Utils.DefaultBoolean.True

      oAxis = ChartControl2.Diagram
      oAxis.AxisY.Title.Text = My.Resources.Global_MONTANT_euro
      oAxis.AxisY.Title.Visibility = DevExpress.Utils.DefaultBoolean.True


      oAxis = ChartControl3.Diagram
      oAxis.AxisY.Title.Text = My.Resources.Global_MONTANT_euro
      oAxis.AxisY.Title.Visibility = DevExpress.Utils.DefaultBoolean.True

    Catch ex As Exception
      MessageBox.Show(My.Resources.TabSyntheseCompta_frmGraisGeneraux_sub2 + ex.Message, My.Resources.Global_Erreur)
    End Try
  End Sub

  Private Sub BtnFermer_Click(sender As System.Object, e As System.EventArgs) Handles BtnFermer.Click
    Me.Close()
  End Sub

  Private Sub BtnPrint_Click(sender As System.Object, e As System.EventArgs) Handles BtnPrint.Click
    Dim oScreenShot As New CSreenShot(Me, True)
    oScreenShot.Print_Form()
  End Sub

End Class