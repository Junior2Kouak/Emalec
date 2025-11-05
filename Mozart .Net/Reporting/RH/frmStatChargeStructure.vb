Imports DevExpress.XtraCharts
Imports DevExpress.XtraPrinting
Imports MozartLib

'****************************************************************************************************************************************
'Date création : 27/06/2013
'Date de modification : 
'Auteur : MC
'Description : Pour ajouter une année dans cette stats, voir proc stock (MULTI) : api_sp_Job_AjoutAnneeStatChargeStructure @annee, @vsociete
'
'
'
'****************************************************************************************************************************************
Public Class frmStatChargeStructure

  Dim oGestConnectSQL As New CGestionSQL

  Dim dtStatChargeStruct As DataTable
  Dim dtStatChargeTx As DataTable

  Private Sub frmStatChargeStructure_FormClosed(ByVal sender As Object, ByVal e As System.Windows.Forms.FormClosedEventArgs) Handles Me.FormClosed

    oGestConnectSQL.CloseConnexionSQL()

  End Sub

  Private Sub frmStatChargeStructure_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load

    Try

      lblDateJour.Text = My.Resources.Global_le & Date.Today

      lblPerim.Text = "Nb Personnes fonctionnelles = Commercial, Généraux" & vbCrLf & vbCrLf & "Nb Personnes opérationnelles = Assistant(e), Bureau d'étude, Chargé d'affaire, Conducteur de travaux, Facturière, Assistant(e) sénior"

      'on ouvre la connexion
      If oGestConnectSQL.ConnexionSQL(MozartParams.NomServeur, MozartParams.NomSociete) = True Then

        dtStatChargeStruct = New DataTable
        dtStatChargeStruct = ModDataGridView.LoadList("api_sp_StatRHChargeStructure '" + MozartParams.NomSociete + "', 0", oGestConnectSQL.CnxSQLOpen)

        'PGCStatRHChargeStructCA.DataSource = dtStatChargeStruct

        ChartCtrlStatRHChargeStruct.DataSource = dtStatChargeStruct
        'PGCStatRHChargeStructPers.DataSource = dtStatChargeStruct
        ChartCtrlPers.DataSource = dtStatChargeStruct

        dtStatChargeTx = New DataTable
        dtStatChargeTx = ModDataGridView.LoadList("api_sp_StatRHChargeStructure '" + MozartParams.NomSociete + "', 1", oGestConnectSQL.CnxSQLOpen)

        'PGCTaux.DataSource = dtStatChargeTx
        ChartCtrlTaux.DataSource = dtStatChargeTx

      End If

    Catch ex As Exception

      MessageBox.Show(My.Resources.Reporting_RH_frmStatChargeStructure_sub + ex.Message, My.Resources.Global_Erreur)

    End Try

  End Sub

  Private Sub BtnFermer_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles BtnFermer.Click

    Me.Close()

  End Sub

  Private Sub BtnPrintGraph1_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles BtnPrintGraph1.Click, BtnPrintGraph2.Click, BtnPrintGraph3.Click

    If MessageBox.Show(My.Resources.Global_print_graphe, My.Resources.Global_impression_graphique, MessageBoxButtons.YesNoCancel, MessageBoxIcon.Question) = vbYes Then

      Dim link As New PrintableComponentLink(New PrintingSystem())

      Dim oChart As ChartControl

      Select Case sender.name
        Case "BtnPrintGraph1"
          oChart = ChartCtrlStatRHChargeStruct
        Case "BtnPrintGraph2"
          oChart = ChartCtrlPers
        Case Else
          oChart = ChartCtrlTaux
      End Select

      link.Component = oChart
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

  Private Sub ChartCtrlStatRHChargeStruct_ObjectSelected(sender As Object, e As HotTrackEventArgs) Handles ChartCtrlStatRHChargeStruct.ObjectSelected

    ' Détails
    Dim hitInfo As ChartHitInfo = e.HitInfo
    If hitInfo.SeriesPoint IsNot Nothing Then
      Using oFrmDetailStat As New frmStatRHChargeStruct_Details_CA(hitInfo.SeriesPoint.Tag.Row.ItemArray(1), hitInfo.SeriesPoint.Tag.Row.ItemArray(8))
        oFrmDetailStat.ShowDialog()
      End Using
    End If

  End Sub

  Private Sub ChartCtrlPers_ObjectSelected(sender As Object, e As HotTrackEventArgs) Handles ChartCtrlPers.ObjectSelected

    ' Détails
    Dim hitInfo As ChartHitInfo = e.HitInfo
    If hitInfo.SeriesPoint IsNot Nothing Then
      Using oFrmDetailStat As New frmStatRHChargeStruct_Details_Pers(hitInfo.SeriesPoint.Tag.Row.ItemArray(1), hitInfo.SeriesPoint.Tag.Row.ItemArray(8))
        oFrmDetailStat.ShowDialog()
      End Using
    End If

  End Sub

  Private Sub ChartCtrlTaux_ObjectSelected(sender As Object, e As HotTrackEventArgs) Handles ChartCtrlTaux.ObjectSelected

    ' Détails
    Dim hitInfo As ChartHitInfo = e.HitInfo
    If hitInfo.SeriesPoint IsNot Nothing Then
      Using oFrmDetailStat As New frmStatRHChargeStruct_Details_Taux(hitInfo.SeriesPoint.Tag.Row.ItemArray(0), hitInfo.SeriesPoint.Tag.Row.ItemArray(4))
        oFrmDetailStat.ShowDialog()
      End Using
    End If

  End Sub
End Class