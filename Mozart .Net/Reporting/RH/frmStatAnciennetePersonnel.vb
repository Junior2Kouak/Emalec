Imports System.Data.SqlClient
Imports DevExpress.XtraCharts
Imports System.Text
Imports DevExpress.Utils
Imports MozartLib

Public Class frmStatAnciennetePersonnel

  Private toolTipController As New ToolTipController()

  Private dsData_Gen As DataSet
  Private dsData_CA As DataSet
  Private dsData_ASS_CT_BE As DataSet
  Private dsData_TE As DataSet
  Private dsData_GE As DataSet

  Private Sub frmStatAnciennetePersonnel_Load(sender As System.Object, e As System.EventArgs) Handles MyBase.Load
    ' TB SAMSIC CITY RES
    lblGroupeEMALEC.Text += MozartParams.NomGroupe
    lblDateJour.Text = My.Resources.Global_le & " " & Date.Today

    apiSocieteAuto1.Init(MozartDatabase.cnxMozart, MozartParams.NomSociete)

    ChargeListe()
  End Sub

  Private Sub ChargeListe()
    Try
      Me.Cursor = Cursors.WaitCursor

      Dim CmdSql As New SqlCommand("api_sp_StatAnciennetePersonnel", MozartDatabase.cnxMozart) With {
        .CommandType = CommandType.StoredProcedure
      }
      CmdSql.Parameters.Add("@SOCIETE", SqlDbType.VarChar).Value = apiSocieteAuto1.Text
      CmdSql.Parameters.Add("@NMENUNUM", SqlDbType.VarChar).Value = apiSocieteAuto1.IdMenuParent
      CmdSql.Parameters.Add("@NPERNUM", SqlDbType.VarChar).Value = MozartParams.UID


      If apiSocieteAuto1.Text = "GROUPE" Then
        lblGroupeEMALEC.Text = My.Resources.Global_groupe_emalec
      Else
        lblGroupeEMALEC.Text = apiSocieteAuto1.Text
      End If

      Dim sqlAdapt As New SqlDataAdapter(CmdSql)
      dsData_Gen = New DataSet
      sqlAdapt.Fill(dsData_Gen)

      Chart_Anc_Gen.DataSource = dsData_Gen.Tables(0)
      GCStat.DataSource = dsData_Gen.Tables(1)

      dsData_CA = New DataSet
      CmdSql = New SqlCommand("api_sp_StatAnciennetePersonnel", MozartDatabase.cnxMozart) With {
        .CommandType = CommandType.StoredProcedure
      }
      CmdSql.Parameters.Add("@SOCIETE", SqlDbType.VarChar).Value = apiSocieteAuto1.Text
      CmdSql.Parameters.Add("@NMENUNUM", SqlDbType.VarChar).Value = apiSocieteAuto1.IdMenuParent
      CmdSql.Parameters.Add("@NPERNUM", SqlDbType.VarChar).Value = MozartParams.UID
      CmdSql.Parameters.Add("@P_NTYPE_PER", SqlDbType.Int).Value = 1
      sqlAdapt = New SqlDataAdapter(CmdSql)
      sqlAdapt.Fill(dsData_CA)
      Chart_Anc_CA.DataSource = dsData_CA.Tables(0)

      dsData_ASS_CT_BE = New DataSet
      CmdSql = New SqlCommand("api_sp_StatAnciennetePersonnel", MozartDatabase.cnxMozart) With {
        .CommandType = CommandType.StoredProcedure
      }
      CmdSql.Parameters.Add("@SOCIETE", SqlDbType.VarChar).Value = apiSocieteAuto1.Text
      CmdSql.Parameters.Add("@NMENUNUM", SqlDbType.VarChar).Value = apiSocieteAuto1.IdMenuParent
      CmdSql.Parameters.Add("@NPERNUM", SqlDbType.VarChar).Value = MozartParams.UID
      CmdSql.Parameters.Add("@P_NTYPE_PER", SqlDbType.Int).Value = 2
      sqlAdapt = New SqlDataAdapter(CmdSql)
      sqlAdapt.Fill(dsData_ASS_CT_BE)
      Chart_Anc_ASS_CT_BE.DataSource = dsData_ASS_CT_BE.Tables(0)

      dsData_TE = New DataSet
      CmdSql = New SqlCommand("api_sp_StatAnciennetePersonnel", MozartDatabase.cnxMozart) With {
        .CommandType = CommandType.StoredProcedure
      }
      CmdSql.Parameters.Add("@SOCIETE", SqlDbType.VarChar).Value = apiSocieteAuto1.Text
      CmdSql.Parameters.Add("@NMENUNUM", SqlDbType.VarChar).Value = apiSocieteAuto1.IdMenuParent
      CmdSql.Parameters.Add("@NPERNUM", SqlDbType.VarChar).Value = MozartParams.UID
      CmdSql.Parameters.Add("@P_NTYPE_PER", SqlDbType.Int).Value = 3
      sqlAdapt = New SqlDataAdapter(CmdSql)
      sqlAdapt.Fill(dsData_TE)
      Chart_Anc_TE.DataSource = dsData_TE.Tables(0)

      dsData_GE = New DataSet
      CmdSql = New SqlCommand("api_sp_StatAnciennetePersonnel", MozartDatabase.cnxMozart) With {
        .CommandType = CommandType.StoredProcedure
      }
      CmdSql.Parameters.Add("@SOCIETE", SqlDbType.VarChar).Value = apiSocieteAuto1.Text
      CmdSql.Parameters.Add("@NMENUNUM", SqlDbType.VarChar).Value = apiSocieteAuto1.IdMenuParent
      CmdSql.Parameters.Add("@NPERNUM", SqlDbType.VarChar).Value = MozartParams.UID
      CmdSql.Parameters.Add("@P_NTYPE_PER", SqlDbType.Int).Value = 4
      sqlAdapt = New SqlDataAdapter(CmdSql)
      sqlAdapt.Fill(dsData_GE)
      Chart_Anc_Autres.DataSource = dsData_GE.Tables(0)
    Catch ex As Exception
      MessageBox.Show("Sub frmStatAnciennetePersonnel_Load() frmStatAnciennetePersonnel : " + ex.Message, My.Resources.Global_Erreur)
    Finally
      Me.Cursor = Cursors.Default
    End Try
  End Sub

  Private Sub Chart_ObjectSelected(sender As Object, e As HotTrackEventArgs) Handles Chart_Anc_Gen.ObjectSelected, Chart_Anc_CA.ObjectSelected, Chart_Anc_ASS_CT_BE.ObjectSelected, Chart_Anc_TE.ObjectSelected, Chart_Anc_Autres.ObjectSelected
    Dim hitInfo As ChartHitInfo = e.HitInfo
    Dim builder As New StringBuilder()
    Dim sSql As String

    If hitInfo.SeriesPoint IsNot Nothing Then

      Dim P_NTYPE_PER As Int32 = 0

      Select Case sender.name
        Case "Chart_Anc_Gen" : P_NTYPE_PER = 0
        Case "Chart_Anc_CA" : P_NTYPE_PER = 1
        Case "Chart_Anc_ASS_CT_BE" : P_NTYPE_PER = 2
        Case "Chart_Anc_TE" : P_NTYPE_PER = 3
        Case "Chart_Anc_Autres" : P_NTYPE_PER = 4
      End Select

      Dim Param = hitInfo.SeriesPoint.Argument
      sSql = String.Format("exec api_sp_StatAnciennetePersonnelDetail '{0}', {1}, {2}, {3}, {4} ", apiSocieteAuto1.Text, apiSocieteAuto1.IdMenuParent, MozartParams.UID, Param, P_NTYPE_PER)
      Dim cmd As New SqlCommand(sSql, MozartDatabase.cnxMozart) With {
        .CommandType = CommandType.Text
      }
      Dim dr As SqlDataReader = cmd.ExecuteReader
      If dr.HasRows = True Then
        While dr.Read()
          builder.AppendLine(dr("NOM"))
        End While
      End If
      dr.Close()
      cmd.Dispose()
    End If

    If builder.Length > 0 Then
      toolTipController.ShowHint(builder.ToString(), sender.PointToScreen(e.HitInfo.HitPoint))
    Else
      toolTipController.HideHint()
    End If
  End Sub

  Private Sub BtnPrint_Click(sender As System.Object, e As System.EventArgs) Handles BtnPrint.Click
    Dim oScreenShot As New CSreenShot(Me, True)
    oScreenShot.Print_Form()
  End Sub

  Private Sub BtValider_Click(sender As System.Object, e As System.EventArgs) Handles BtValider.Click
    ChargeListe()
  End Sub

End Class
