Imports System.Data.SqlClient
Imports DevExpress.XtraCharts
Imports System.Text
Imports DevExpress.Utils
Imports MozartLib

Public Class frmStatComGenerale

  Dim oGestConnectSQL As New CGestionSQL
  Dim dtStat As DataSet
  Private toolTipController As New ToolTipController()
  Dim strTypeStat As String


  Public Sub New(ByVal p_Param As Object)
    InitializeComponent()
    strTypeStat = p_Param
  End Sub

  Private Sub frmStatcomGenerale_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load

    Try
      'on ouvre la connexion
      If oGestConnectSQL.ConnexionSQL(MozartParams.NomServeur, MozartParams.NomSociete) = True Then
        LoadMoyenne()
        LoadStat()
        If strTypeStat = "EXT" Then
          lblClient.Text = My.Resources.Reporting_Commercial_frmListeClients_nbr_new_client
          lblRDV.Text = My.Resources.Reporting_Commercial_frmListeClients_nbr_rdv
          lblProp.Text = My.Resources.Reporting_Commercial_frmListeClients_nbr_proposition
          GrpCli.Text = My.Resources.Reporting_Commercial_frmListeClients_new_client
          GrpRDV.Text = My.Resources.Reporting_Commercial_frmListeClients_nbr_rdv_EI
          GrpPROP.Text = My.Resources.Reporting_Commercial_frmListeClients_nbr_prop_EI
          lblCli.Text = My.Resources.Reporting_Commercial_frmListeClients_objectif_mensuel_70
          lblordv.Text = My.Resources.Reporting_Commercial_frmListeClients_objectif_mensuel_90
          lbloprop.Text = My.Resources.Reporting_Commercial_frmListeClients_objectif_mensuel_100
          Label3.Text = My.Resources.Reporting_Commercial_frmListeClients_indicateurs
          Dim ConstHaut As XYDiagram = ChartCtrlCli.Diagram
          ConstHaut.AxisY.ConstantLines(0).AxisValue = 70
          Dim ConstMid As XYDiagram = ChartCtrlRDV.Diagram
          ConstMid.AxisY.ConstantLines(0).AxisValue = 90
          Dim ConstBas As XYDiagram = ChartCtrlPROP.Diagram
          ConstBas.AxisY.ConstantLines(0).AxisValue = 100

        End If
      End If

    Catch ex As Exception
      MessageBox.Show(My.Resources.Reporting_Commercial_frmListeClients_SubLoadGenCom + ex.Message, My.Resources.Global_Erreur)
    End Try
  End Sub

  Private Sub LoadStat()

    Try

      Dim CmdSql As New SqlCommand(String.Format("exec api_sp_StatComGenerale '{0}'", strTypeStat), oGestConnectSQL.CnxSQLOpen)
      CmdSql.CommandType = CommandType.Text

      Dim dr As SqlDataAdapter = New SqlDataAdapter(CmdSql)
      dtStat = New DataSet
      dr.Fill(dtStat)

      ChartCtrlCli.DataSource = dtStat.Tables(0)
      ChartCtrlPROP.DataSource = dtStat.Tables(1)
      ChartCtrlRDV.DataSource = dtStat.Tables(2)

    Catch ex As Exception
      MessageBox.Show(My.Resources.Reporting_Commercial_frmListeClients_SubLoadCom + ex.Message, My.Resources.Global_Erreur)
    End Try
  End Sub

  Private Sub LoadMoyenne()

    Try

      Dim CmdSql As New SqlCommand(String.Format("exec api_sp_StatComGeneraleMoy '{0}'", strTypeStat), oGestConnectSQL.CnxSQLOpen)
      CmdSql.CommandType = CommandType.Text

      Dim dr As SqlDataReader = CmdSql.ExecuteReader
      If dr.HasRows = True Then
        While dr.Read()
          lblMoyCli.Text = lblMoyCli.Text & dr("AVCLI").ToString
          lblMoyRDV.Text = lblMoyRDV.Text & dr("AVRDV").ToString
          lblMoyPROP.Text = lblMoyPROP.Text & dr("AVPROP").ToString
        End While
      End If
      dr.Close()
      CmdSql.Dispose()

    Catch ex As Exception
      MessageBox.Show(My.Resources.Reporting_Commercial_frmListeClients_SubLoadCom + ex.Message, My.Resources.Global_Erreur)
    End Try
  End Sub

  Private Sub ChartCtrlCli_ObjectSelected(sender As Object, e As HotTrackEventArgs) Handles ChartCtrlCli.ObjectSelected
    Dim hitInfo As ChartHitInfo = e.HitInfo
    Dim builder As New StringBuilder()
    Dim sSql As String = ""

    If hitInfo.SeriesPoint IsNot Nothing Then
      Dim Param = Split(hitInfo.SeriesPoint.Argument, "/")
      ' client avec 10 sites ou 100k€ de CA sur 12 mois)!
      If strTypeStat = "EXT" Then
        sSql = String.Format("SELECT VCLINOM FROM TCLI WHERE	VSOCIETE='{2}' AND	DATEPART([YY], DCLIDATECRE) = {0} AND DATEPART([MM], DCLIDATECRE) = {1}  AND	NCLINUM IN (SELECT NCLINUM	FROM TCONTRATCLI T1 WHERE exists (SELECT * FROM TCONTRATCLI T2 WHERE T2.NCLINUM = T1.NCLINUM AND NTYPECONTRAT = 247) GROUP BY NCLINUM	having count(*) = 1) ", Param(0), Param(1), MozartParams.NomSociete)
        sSql = sSql & " ORDER BY VCLINOM"
      Else
        sSql = String.Format("SELECT VCLINOM FROM TCLI WHERE	VSOCIETE='{2}' AND	DATEPART([YY], DCLIDATECRE) = {0} AND DATEPART([MM], DCLIDATECRE) = {1}  AND	NCLINUM NOT IN (SELECT NCLINUM	FROM TCONTRATCLI T1 WHERE exists (SELECT * FROM TCONTRATCLI T2 WHERE T2.NCLINUM = T1.NCLINUM AND NTYPECONTRAT = 247) GROUP BY NCLINUM	having count(*) = 1) ", Param(0), Param(1), MozartParams.NomSociete)
        sSql = sSql & " AND	((select count(nsitnum) from tsit where nclinum=TCLI.Nclinum) >= 10 OR (SELECT	ISNULL(SUM(TELF.NELFTHT),0) FROM	TELF INNER JOIN TDIN ON TELF.NDINNUM = TDIN.NDINNUM WHERE TELF.DELFDPR BETWEEN DATEADD([MONTH],-12,GETDATE()) AND GETDATE() AND	TDIN.NCLINUM = TCLI.NCLINUM) > 100000) ORDER BY VCLINOM"
      End If
      Dim cmd As New SqlCommand(sSql, MozartDatabase.cnxMozart)
      cmd.CommandType = CommandType.Text
      Dim dr As SqlDataReader = cmd.ExecuteReader
      If dr.HasRows = True Then
        While dr.Read()
          builder.AppendLine(dr("VCLINOM"))
        End While
      End If
      dr.Close()
      cmd.Dispose()
    End If
    If builder.Length > 0 Then
      toolTipController.ShowHint(builder.ToString(), ChartCtrlCli.PointToScreen(e.HitInfo.HitPoint))
    Else
      toolTipController.HideHint()
    End If
  End Sub

  Private Sub ChartCtrlPROP_ObjectSelected(sender As Object, e As HotTrackEventArgs) Handles ChartCtrlPROP.ObjectSelected
    Dim hitInfo As ChartHitInfo = e.HitInfo
    Dim builder As New StringBuilder()
    Dim sSql As String = ""

    If hitInfo.SeriesPoint IsNot Nothing Then
      Dim Param = Split(hitInfo.SeriesPoint.Argument, "/")
      If strTypeStat = "EXT" Then
        sSql = String.Format("SELECT VPROSNOM FROM TPROSP WHERE	VSOCIETE='{2}' AND	DATEPART([YY], DOFFRE) = {0} AND DATEPART([MM], DOFFRE) = {1}  AND	NQUIOFFR in (select npernum from tper where nsernum=11) ", Param(0), Param(1), MozartParams.NomSociete)
      Else
        sSql = String.Format("SELECT VPROSNOM FROM TPROSP WHERE	VSOCIETE='{2}' AND	DATEPART([YY], DOFFRE) = {0} AND DATEPART([MM], DOFFRE) = {1}  AND	NQUIOFFR not in (select npernum from tper where nsernum=11) ", Param(0), Param(1), MozartParams.NomSociete)
      End If
      Dim cmd As New SqlCommand(sSql, MozartDatabase.cnxMozart)
      cmd.CommandType = CommandType.Text
      Dim dr As SqlDataReader = cmd.ExecuteReader
      If dr.HasRows = True Then
        While dr.Read()
          builder.AppendLine(dr("VPROSNOM"))
        End While
      End If
      dr.Close()
      cmd.Dispose()
    End If
    If builder.Length > 0 Then
      toolTipController.ShowHint(builder.ToString(), ChartCtrlPROP.PointToScreen(e.HitInfo.HitPoint))
    Else
      toolTipController.HideHint()
    End If
  End Sub


  Private Sub ChartCtrlRDV_ObjectSelected(sender As Object, e As HotTrackEventArgs) Handles ChartCtrlRDV.ObjectSelected
    Dim hitInfo As ChartHitInfo = e.HitInfo
    Dim builder As New StringBuilder()
    Dim sSql As String = ""

    If hitInfo.SeriesPoint IsNot Nothing Then
      Dim Param = Split(hitInfo.SeriesPoint.Argument, "/")
      If strTypeStat = "EXT" Then
        sSql = String.Format("SELECT VPROSNOM FROM TPROSP WHERE	VSOCIETE='{2}' AND	DATEPART([YY], DRDV) = {0} AND DATEPART([MM], DRDV) = {1}  AND	NQUIRDV in (select npernum from tper where nsernum=11) ", Param(0), Param(1), MozartParams.NomSociete)
      Else
        sSql = String.Format("SELECT VPROSNOM FROM TPROSP WHERE	VSOCIETE='{2}' AND	DATEPART([YY], DRDV) = {0} AND DATEPART([MM], DRDV) = {1}  AND	NQUIRDV not in (select npernum from tper where nsernum=11) ", Param(0), Param(1), MozartParams.NomSociete)
      End If
      Dim cmd As New SqlCommand(sSql, MozartDatabase.cnxMozart)
      cmd.CommandType = CommandType.Text
      Dim dr As SqlDataReader = cmd.ExecuteReader
      If dr.HasRows = True Then
        While dr.Read()
          builder.AppendLine(dr("VPROSNOM"))
        End While
      End If
      dr.Close()
      cmd.Dispose()
    End If
    If builder.Length > 0 Then
      toolTipController.ShowHint(builder.ToString(), ChartCtrlRDV.PointToScreen(e.HitInfo.HitPoint))
    Else
      toolTipController.HideHint()
    End If
  End Sub

  Private Sub BtnFermer_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles BtnFermer.Click
    Me.Close()
  End Sub

  Private Sub BtnPrint_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles BtnPrint.Click
    Dim oScreenShot As New CSreenShot(Me, True)
    oScreenShot.Print_Form()
  End Sub

End Class