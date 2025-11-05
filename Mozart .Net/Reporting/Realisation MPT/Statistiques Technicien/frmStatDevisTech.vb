Imports System.Data.SqlClient
Imports DevExpress.XtraCharts
Imports DevExpress.XtraPrinting
Imports System.Text
Imports DevExpress.Utils
Imports MozartLib

Public Class frmStatDevisTech

  Dim oGestCnx As CGestionSQL

  Dim DtTot As DataTable
  Dim DtDet As DataTable

  Dim sType As String
  Dim datedebut As Date
  Dim datefin As Date

  Private toolTipController As New ToolTipController()

  Public Sub New(ByVal c_sType As String, ByVal c_datedebut As Date, ByVal c_datefin As Date)

    ' Cet appel est requis par le concepteur.
    InitializeComponent()

    ' Ajoutez une initialisation quelconque après l'appel InitializeComponent().
    sType = c_sType
    datedebut = c_datedebut
    datefin = c_datefin

  End Sub

  Private Sub frmStatDevisTech_FormClosed(sender As Object, e As System.Windows.Forms.FormClosedEventArgs) Handles Me.FormClosed
    oGestCnx.CloseConnexionSQL()
    Me.Cursor = Cursors.Default
  End Sub

  Private Sub frmStatDevisTech_Load(sender As System.Object, e As System.EventArgs) Handles MyBase.Load

    oGestCnx = New CGestionSQL

    LblPeriode.Text = String.Format(My.Resources.Global_periode_0_1, datedebut.ToShortDateString, datefin.ToShortDateString)

    'on ouvre la connexion
    If oGestCnx.ConnexionSQL(MozartParams.NomServeur, MozartParams.NomSociete) = True Then
      Me.Cursor = Cursors.WaitCursor
      LoadStatTot()
      Me.Cursor = Cursors.Default
    End If

  End Sub

  Private Sub LoadStatTot()

    DtTot = New DataTable

    DtTot = LoadList(String.Format("exec api_sp_StatistiqueDevisTech '{0}', '{1}', '{2}'", datedebut, datefin, sType), oGestCnx.CnxSQLOpen)

    GCStatTot.DataSource = DtTot

    ChartTot.DataSource = GCStatTot.DataSource

  End Sub

  Private Sub LoadStatDetAndSem(ByVal p_NPERNUM As Int32)
    DtDet = New DataTable
    DtDet = LoadList(String.Format("exec api_sp_StatDetailDevisTech {0}, '{1}', '{2}', '{3}'", p_NPERNUM, datedebut, datefin, sType), oGestCnx.CnxSQLOpen)
    GCDetail.DataSource = DtDet

  End Sub

  Private Sub GVStatTot_FocusedRowChanged(sender As Object, e As DevExpress.XtraGrid.Views.Base.FocusedRowChangedEventArgs) Handles GVStatTot.FocusedRowChanged

    'e.FocusedRowHandle
    Dim odr As DataRow = GVStatTot.GetDataRow(e.FocusedRowHandle)

    If Not odr Is Nothing Then

      LoadStatDetAndSem(odr.Item("NPERNUM"))

    End If

  End Sub

  Private Sub BtnFermer_Click(sender As System.Object, e As System.EventArgs) Handles BtnFermer.Click

    Me.Close()

  End Sub

  Private Sub ChartTot_MouseMove(sender As Object, e As System.Windows.Forms.MouseEventArgs) Handles ChartTot.MouseMove
    Dim hitInfo As ChartHitInfo = ChartTot.CalcHitInfo(e.Location)
    Dim builder As New StringBuilder()
    If hitInfo.SeriesPoint IsNot Nothing Then
      builder.AppendLine(My.Resources.Global_technicien_space & hitInfo.SeriesPoint.Argument)
      If (Not hitInfo.SeriesPoint.IsEmpty) Then
        builder.AppendLine(My.Resources.Global_montant_with_space & FormatCurrency(hitInfo.SeriesPoint.Values(0)))
      End If
    End If
    If builder.Length > 0 Then
      toolTipController.ShowHint(builder.ToString(), ChartTot.PointToScreen(e.Location))
    Else
      toolTipController.HideHint()
    End If
  End Sub

  Private Sub BtnPrint_Click(sender As System.Object, e As System.EventArgs) Handles BtnPrint.Click
    Dim oScreenShot As New CSreenShot(Me, True)
    oScreenShot.Print_Form()
  End Sub
End Class