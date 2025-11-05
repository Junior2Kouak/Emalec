Imports DevExpress.DataAccess.Sql
Imports DevExpress.DataAccess.ConnectionParameters
Imports DevExpress.XtraReports.UI
Imports System.Drawing.Printing
Imports MozartLib

Public Class XR_Page_Chap_Maintenance_TableauPrev

  Dim _oRapport_Fm_Imp As CRapportFM
  Dim _NomServerSQL As String
  Dim _sNameLastMonth As String

  Public ReadOnly Property ExistsData() As Boolean
    Get
      Return If(DR_Chap_Maintenance_Tab.RowCount > 0, True, False)
    End Get
  End Property

  Public Sub New(ByVal c_Rapport_Fm_Imp As CRapportFM, ByVal c_NomServerSQL As String, ByVal c_NTYPECONTRAT As Int32, ByVal c_VTYPECONTRAT As String, Optional ByVal p_Periode As Int32 = 0)

    ' Cet appel est requis par le concepteur.
    InitializeComponent()

    'Init
    Dim oTrad As New Class_Trad_Report("XR_Page_Chap_Maintenance_TableauPrev")

    ' Ajoutez une initialisation quelconque après l'appel InitializeComponent().
    _oRapport_Fm_Imp = c_Rapport_Fm_Imp
    _NomServerSQL = c_NomServerSQL

    Select Case p_Periode
      Case 0

        P_ANNEE.Value = DateAdd(DateInterval.Day, -DatePart(DateInterval.Day, Now.Date), Now.Date).Year

      Case 1

        P_ANNEE.Value = DateAdd(DateInterval.Day, -DatePart(DateInterval.Day, _oRapport_Fm_Imp.sDateFin_This), _oRapport_Fm_Imp.sDateFin_This).Year

    End Select


    P_NCLINUM.Value = _oRapport_Fm_Imp.NCLINUM

    P_NTYPECONTRAT.Value = c_NTYPECONTRAT

    P_NIDRAPPORT_FM_CLI.Value = _oRapport_Fm_Imp.NIDRAPPORT_FM_CLI

    'set traduction
    oTrad.SetTraductionOnReport(Me, _oRapport_Fm_Imp.sLangue)

    'on mets à jours les expressions :
    XrLblMaintenanceTitle.Text = XrLblMaintenanceTitle.Text + " " + P_ANNEE.Value.ToString
    XrLabel1.Text = XrLabel1.Text & " " & c_VTYPECONTRAT

  End Sub
  Private Sub SDS_CHap_Maintenance_ConfigureDataConnection(sender As Object, e As ConfigureDataConnectionEventArgs) Handles SDS_Chap_Maintenance_TabPrev.ConfigureDataConnection

    Dim oParamSQL As MsSqlConnectionParameters = e.ConnectionParameters

    oParamSQL.ServerName = MozartParams.NomServeur
    oParamSQL.DatabaseName = "MULTI"
    oParamSQL.AuthorizationType = MsSqlAuthorizationType.Windows

  End Sub

    Private Sub XCD_01_Draw(sender As Object, e As DrawEventArgs) Handles XCD_01.Draw

        If e.Brick.Value = "V" Then
            'e.UniGraphics.DrawRectangle(Pens.Green, e.Bounds)
            e.Brick.TextValue = ""
            e.Brick.BackColor = Color.Green
        End If



    End Sub

    Private Sub XCD_01_BeforePrint(sender As Object, e As System.ComponentModel.CancelEventArgs) Handles XCD_01.BeforePrint, XCD_02.BeforePrint, XCD_03.BeforePrint, XCD_04.BeforePrint, XCD_05.BeforePrint,
          XCD_06.BeforePrint, XCD_07.BeforePrint, XCD_08.BeforePrint, XCD_09.BeforePrint, XCD_10.BeforePrint, XCD_11.BeforePrint, XCD_12.BeforePrint, XCD_13.BeforePrint, XCD_14.BeforePrint,
          XCD_15.BeforePrint, XCD_16.BeforePrint, XCD_17.BeforePrint, XCD_18.BeforePrint, XCD_19.BeforePrint, XCD_20.BeforePrint, XCD_21.BeforePrint, XCD_22.BeforePrint, XCD_23.BeforePrint,
          XCD_24.BeforePrint, XCD_25.BeforePrint, XCD_26.BeforePrint, XCD_27.BeforePrint, XCD_28.BeforePrint, XCD_29.BeforePrint, XCD_30.BeforePrint, XCD_31.BeforePrint, XCD_32.BeforePrint,
          XCD_33.BeforePrint, XCD_34.BeforePrint, XCD_35.BeforePrint, XCD_36.BeforePrint, XCD_37.BeforePrint, XCD_38.BeforePrint, XCD_39.BeforePrint, XCD_40.BeforePrint, XCD_41.BeforePrint,
          XCD_42.BeforePrint, XCD_43.BeforePrint, XCD_44.BeforePrint, XCD_45.BeforePrint, XCD_46.BeforePrint, XCD_47.BeforePrint, XCD_48.BeforePrint, XCD_49.BeforePrint, XCD_50.BeforePrint,
          XCD_51.BeforePrint, XCD_52.BeforePrint


        Dim oCell As XRTableCell = TryCast(sender, XRTableCell)

        If Not oCell.Value Is Nothing AndAlso oCell.Value = "V" Then

            oCell.Text = ""
            oCell.BackColor = Color.White

        ElseIf Not oCell.Value Is Nothing AndAlso oCell.Value.ToString <> "" AndAlso oCell.Value.ToString.Substring(0, 1) = "X" Then

            oCell.Text = ""
            oCell.BackColor = Color.LimeGreen

        ElseIf Not oCell.Value Is Nothing AndAlso oCell.Value.ToString <> "" AndAlso oCell.Value.ToString.Substring(0, 1) = "I" Then

            oCell.Text = ""
            oCell.BackColor = Color.Red

        ElseIf Not oCell.Value Is Nothing AndAlso oCell.Value.ToString <> "" AndAlso oCell.Value.ToString.Substring(0, 1) = "P" Then

            oCell.Text = ""
            oCell.BackColor = Color.Orange

        Else

            oCell.Text = ""
            oCell.BackColor = Color.White

        End If

    End Sub

End Class