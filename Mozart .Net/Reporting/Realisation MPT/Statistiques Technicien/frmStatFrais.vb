Imports System.Data.SqlClient
Imports DevExpress.Utils
Imports MozartLib

Public Class frmStatFrais

  Dim oGestCnx As CGestionSQL

  Dim DateDebut As Date
  Dim DateFin As Date

  Dim sType As String
  Dim sTypeFrais As String

  Dim dtFrais As DataTable

  Private toolTipController As New ToolTipController()

  Public Sub New(ByVal c_sType As Object, ByVal c_sTypeFrais As Object, ByVal c_datedebut As Object, ByVal c_datefin As Object)

    ' Cet appel est requis par le concepteur.
    InitializeComponent()

    ' Ajoutez une initialisation quelconque après l'appel InitializeComponent().
    sTypeFrais = c_sTypeFrais.ToString
    sType = c_sType.ToString
    DateDebut = Convert.ToDateTime(c_datedebut)
    DateFin = Convert.ToDateTime(c_datefin)

  End Sub

  Private Sub frmStatFrais_FormClosed(sender As Object, e As System.Windows.Forms.FormClosedEventArgs) Handles Me.FormClosed

    oGestCnx.CloseConnexionSQL()
    Me.Cursor = Cursors.Default

  End Sub

  Private Sub frmStatFrais_Load(sender As System.Object, e As System.EventArgs) Handles MyBase.Load

    oGestCnx = New CGestionSQL

    'init
    DTPDebut.Value = DateDebut
    DTPFin.Value = DateFin

    lblDateJour.Text = ", le " & Date.Today

    AffichageByType()

    'on ouvre la connexion
    If oGestCnx.ConnexionSQL(MozartParams.NomServeur, MozartParams.NomSociete) = True Then

      LoadStatTot()

    End If

  End Sub

  Private Sub AffichageByType()

    Select Case sTypeFrais

      Case "KM2"

        GrpBoxMoyAn.Visible = False

        ChartFrais.Titles(0).Text = My.Resources.Reporting_RealisationMPT_frmStatFrais_nbr_personne
        LblTitre.Text = My.Resources.Reporting_RealisationMPT_frmStatFrais_visu

        ChartFrais.Series(0).ArgumentDataMember = "TECH"
        ChartFrais.Series(0).ValueDataMembers.Item(0) = "KM"

        ChartFrais.Series(0).CrosshairLabelPattern = My.Resources.Global_techA & vbCrLf & "Nb Kms : {V:N0}"

      Case "KM3"

        GrpBoxMoyAn.Visible = True

        ChartFrais.Titles(0).Text = My.Resources.Reporting_RealisationMPT_frmStatFrais_nbr_vehicule
        LblTitre.Text = My.Resources.Reporting_RealisationMPT_frmStatFrais_visu

        ChartFrais.Series(0).ArgumentDataMember = "VEH"
        ChartFrais.Series(0).ValueDataMembers.Item(0) = "KM"

        ChartFrais.Series(0).CrosshairLabelPattern = My.Resources.Global_vehiculeA & vbCrLf & "Nb Kms : {V:N0}"

      Case "KM"

        GrpBoxMoyAn.Visible = False

        ChartFrais.Titles(0).Text = My.Resources.Reporting_RealisationMPT_frmStatFrais_nbr_compte
        LblTitre.Text = My.Resources.Reporting_RealisationMPT_frmStatFrais_visu2

        ChartFrais.Series(0).ArgumentDataMember = "TECH"
        ChartFrais.Series(0).ValueDataMembers.Item(0) = "NVEHKMJ"

        ChartFrais.Series(0).CrosshairLabelPattern = My.Resources.Global_techA & vbCrLf & "Nb Kms : {V:N0}"

      Case "GD"

        GrpBoxMoyAn.Visible = False

        ChartFrais.Titles(0).Text = My.Resources.Reporting_RealisationMPT_frmStatFrais_nbr_compte_GD
        LblTitre.Text = My.Resources.Reporting_RealisationMPT_frmStatFrais_visuGD

        ChartFrais.Series(0).ArgumentDataMember = "TECH"
        ChartFrais.Series(0).ValueDataMembers.Item(0) = "NVEHGD"

        ChartFrais.Series(0).CrosshairLabelPattern = My.Resources.Global_techA & vbCrLf & "Nb Kms : {V:N0}"

      Case "RT"

        GrpBoxMoyAn.Visible = False

        ChartFrais.Titles(0).Text = My.Resources.Reporting_RealisationMPT_frmStatFrais_nbr_compte_RT
        LblTitre.Text = My.Resources.Reporting_RealisationMPT_frmStatFrais_visu_RT

        ChartFrais.Series(0).ArgumentDataMember = "TECH"
        ChartFrais.Series(0).ValueDataMembers.Item(0) = "NVEHREPAS"

        ChartFrais.Series(0).CrosshairLabelPattern = My.Resources.Global_techA & vbCrLf & "Nb Kms : {V:N0}"

    End Select

  End Sub

  Private Sub LoadStatTot()

    Me.Cursor = Cursors.WaitCursor

    Select Case sTypeFrais

      Case "KM2"

        dtFrais = New DataTable
        dtFrais = LoadList(String.Format("exec api_sp_StatistiqueFrais2 '{0}', '{1}', '{2}'", DTPDebut.Value, DTPFin.Value, sType), oGestCnx.CnxSQLOpen)
        ChartFrais.DataSource = dtFrais

      Case "KM3"

        Dim oDs As New DataSet
        Dim sqladatp As New SqlDataAdapter(String.Format("exec api_sp_StatistiqueFrais3 '{0}', '{1}'", DTPDebut.Value, DTPFin.Value), oGestCnx.CnxSQLOpen)

        sqladatp.Fill(oDs)

        dtFrais = New DataTable
        dtFrais = oDs.Tables(0)
        ChartFrais.DataSource = dtFrais
        LblKmMoyAn.Text = String.Format(My.Resources.Reporting_RealisationMPT_frmStatFrais_km_moy, oDs.Tables(1).Rows(0).Item(0), oDs.Tables(1).Rows(0).Item(1), (oDs.Tables(1).Rows(0).Item(1) / oDs.Tables(1).Rows(0).Item(0)))

      Case Else

        dtFrais = New DataTable
        dtFrais = LoadList(String.Format("exec api_sp_StatistiqueFrais '{0}', '{1}', '{2}'", DTPDebut.Value, DTPFin.Value, sTypeFrais), oGestCnx.CnxSQLOpen)
        ChartFrais.DataSource = dtFrais

    End Select

    Me.Cursor = Cursors.Default

  End Sub

  Private Sub BtnFermer_Click(sender As System.Object, e As System.EventArgs) Handles BtnFermer.Click
    Me.Close()
  End Sub

  Private Sub BtnPrint_Click(sender As System.Object, e As System.EventArgs) Handles BtnPrint.Click

    Dim oScreenShot As New CSreenShot(Me, True)
    oScreenShot.Print_Form()

  End Sub

  Private Sub BtnValider_Click(sender As System.Object, e As System.EventArgs) Handles BtnValider.Click

    LoadStatTot()

  End Sub

  'Private Sub ChartFrais_MouseMove(sender As Object, e As System.Windows.Forms.MouseEventArgs) Handles ChartFrais.MouseMove
  '    Dim hitInfo As ChartHitInfo = ChartFrais.CalcHitInfo(e.Location)
  '    Dim builder As New StringBuilder()
  '    If hitInfo.SeriesPoint IsNot Nothing Then
  '        Select Case sTypeFrais
  '            Case "KM3" : builder.AppendLine("  Véhicule : " & hitInfo.SeriesPoint.Argument)
  '            Case "KM2" : builder.AppendLine("  Technicien: " & hitInfo.SeriesPoint.Argument)
  '            Case Else : builder.AppendLine("  Technicien: " & hitInfo.SeriesPoint.Argument)
  '        End Select
  '        If (Not hitInfo.SeriesPoint.IsEmpty) Then

  '            Select Case sTypeFrais
  '                Case "KM3" : builder.AppendLine("  Nb kms : " & String.Format("{0:n0}", hitInfo.SeriesPoint.Values(0)))
  '                Case "KM2" : builder.AppendLine("  Nb kms : " & String.Format("{0:n0}", hitInfo.SeriesPoint.Values(0)))
  '                Case "KM" : builder.AppendLine("  Nb kms : " & String.Format("{0:n0}", hitInfo.SeriesPoint.Values(0)))
  '                Case "GD" : builder.AppendLine("  Nb GD : " & String.Format("{0:n0}", hitInfo.SeriesPoint.Values(0)))
  '                Case "RT" : builder.AppendLine("  Nb Repas : " & String.Format("{0:n0}", hitInfo.SeriesPoint.Values(0)))
  '            End Select

  '        End If
  '    End If
  '    If builder.Length > 0 Then
  '        toolTipController.ShowHint(builder.ToString(), ChartFrais.PointToScreen(e.Location))
  '    Else
  '        toolTipController.HideHint()
  '    End If
  'End Sub
End Class