Imports DevExpress.Utils
Imports MozartLib

Public Class frmStatContremaitre

  Dim oGestCnx As CGestionSQL

  Dim sType As String
  Dim datedebut As Date
  Dim datefin As Date

  Dim dtDevTech As DataTable

  Private toolTipController As New ToolTipController()

  Public Sub New(ByVal c_sType As String, ByVal c_datedebut As Date, ByVal c_datefin As Date)

    ' Cet appel est requis par le concepteur.
    InitializeComponent()

    ' Ajoutez une initialisation quelconque après l'appel InitializeComponent().
    sType = c_sType
    datedebut = c_datedebut
    datefin = c_datefin

  End Sub

  Private Sub frmStatDevisWebTech_FormClosed(sender As Object, e As System.Windows.Forms.FormClosedEventArgs) Handles Me.FormClosed
    oGestCnx.CloseConnexionSQL()
  End Sub

  Private Sub frmStatDevisWebTech_Load(sender As System.Object, e As System.EventArgs) Handles MyBase.Load

    'Init
    AffichageByType()

    oGestCnx = New CGestionSQL

    'on ouvre la connexion
    If oGestCnx.ConnexionSQL(MozartParams.NomServeur, MozartParams.NomSociete) = True Then
      Me.Cursor = Cursors.WaitCursor
      LoadStatTot()
      Me.Cursor = Cursors.Default
    End If

  End Sub

  Private Sub AffichageByType()

    Select Case sType

      Case "KM"
        LblPeriode.Text = String.Format(My.Resources.Global_periode_0_1, datedebut.ToShortDateString, datefin.ToShortDateString)
        LblTitre.Text = My.Resources.Reporting_RealisationMPT_frmStatContremaitre_moy
        ChartTot.Titles(0).Text = My.Resources.Reporting_RealisationMPT_frmStatContremaitre_moy_tech

        ChartTot.Series(0).CrosshairLabelPattern = My.Resources.Reporting_RealisationMPT_frmStatContremaitre_tech & vbCrLf & My.Resources.Global_valeurN0

      Case "DEVWEB"
        LblPeriode.Text = String.Format(My.Resources.Global_periode_0_1, datedebut.ToShortDateString, datefin.ToShortDateString)
        LblTitre.Text = My.Resources.Reporting_RealisationMPT_frmStatContremaitre_moy_web
        ChartTot.Titles(0).Text = My.Resources.Reporting_RealisationMPT_frmStatContremaitre_moy_web_créé

        ChartTot.Series(0).CrosshairLabelPattern = My.Resources.Reporting_RealisationMPT_frmStatContremaitre_tech & vbCrLf & My.Resources.Global_valeurN0

      Case "FACT"
        LblPeriode.Text = String.Format(My.Resources.Global_periode_0_1, datedebut.ToShortDateString, datefin.ToShortDateString)
        LblTitre.Text = My.Resources.Reporting_RealisationMPT_frmStatContremaitre_moy_client
        ChartTot.Titles(0).Text = My.Resources.Reporting_RealisationMPT_frmStatContremaitre_moy_client

        ChartTot.Series(0).CrosshairLabelPattern = My.Resources.Reporting_RealisationMPT_frmStatContremaitre_tech & vbCrLf & My.Resources.Global_valeurC0

    End Select

  End Sub

  Private Sub LoadStatTot()

    dtDevTech = New DataTable

    Select Case sType
      Case "KM"
        dtDevTech = LoadList(String.Format("exec api_sp_StatistiqueFrais2 '{0}', '{1}', 'C'", datedebut, datefin), oGestCnx.CnxSQLOpen)
        GColValeur.Caption = "Nbr KM"
        GColValeur.DisplayFormat.FormatString = "{0:n0}"
        GColValeur.DisplayFormat.FormatType = FormatType.Numeric
      Case "DEVWEB"
        dtDevTech = LoadList(String.Format("exec api_sp_ListeNbDevisWebtech '{0}', '{1}', 'C'", datedebut, datefin), oGestCnx.CnxSQLOpen)
        GColValeur.Caption = "Nbr Devis"
        GColValeur.DisplayFormat.FormatType = FormatType.Numeric
      Case "FACT"
        dtDevTech = LoadList(String.Format("exec api_sp_StatFacturationTech '{0}', '{1}', 'C'", datedebut, datefin), oGestCnx.CnxSQLOpen)
        GColValeur.Caption = "Mnt facturation"
        GColValeur.DisplayFormat.FormatString = "{0:c0}"
        GColValeur.DisplayFormat.FormatType = FormatType.Numeric
    End Select

    GCStatTot.DataSource = dtDevTech
    ChartTot.DataSource = GCStatTot.DataSource

  End Sub

  Private Sub BtnFermer_Click(sender As System.Object, e As System.EventArgs) Handles BtnFermer.Click
    Me.Close()
  End Sub

  Private Sub BtnPrint_Click(sender As System.Object, e As System.EventArgs) Handles BtnPrint.Click
    Dim oScreenShot As New CSreenShot(Me, True)
    oScreenShot.Print_Form()
  End Sub

  'Private Sub ChartTot_MouseMove(sender As Object, e As System.Windows.Forms.MouseEventArgs) Handles ChartTot.MouseMove
  '    Dim hitInfo As ChartHitInfo = ChartTot.CalcHitInfo(e.Location)
  '    Dim builder As New StringBuilder()
  '    If hitInfo.SeriesPoint IsNot Nothing Then
  '        builder.AppendLine("  Technicien: " & hitInfo.SeriesPoint.Argument)
  '        If (Not hitInfo.SeriesPoint.IsEmpty) Then
  '            builder.AppendLine("  Valeur : " & FormatNumber((hitInfo.SeriesPoint.Values(0)), 0) & IIf(sType = "FACT", " €", ""))
  '        End If
  '    End If
  '    If builder.Length > 0 Then
  '        ToolTipController.ShowHint(builder.ToString(), ChartTot.PointToScreen(e.Location))
  '    Else
  '        toolTipController.HideHint()
  '    End If
  'End Sub
End Class