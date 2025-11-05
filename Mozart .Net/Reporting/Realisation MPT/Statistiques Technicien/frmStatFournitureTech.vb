Imports DevExpress.Utils
Imports MozartLib

Public Class frmStatFournitureTech

  Dim oGestCnx As CGestionSQL

  Dim DtTot As DataTable
  Dim DtDet As DataTable
  Dim DtSem As DataTable

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

  Private Sub frmStatFournitureTech_FormClosed(sender As Object, e As System.Windows.Forms.FormClosedEventArgs) Handles Me.FormClosed
    oGestCnx.CloseConnexionSQL()
    Me.Cursor = Cursors.Default
  End Sub

  Private Sub frmStatFournitureTech_Load(sender As System.Object, e As System.EventArgs) Handles MyBase.Load

    oGestCnx = New CGestionSQL

    LblPeriode.Text = String.Format(My.Resources.Global_periode_0_1, datedebut.ToShortDateString, datefin.ToShortDateString)
    If sType = "C" Then
      LblTitre.Text = My.Resources.Reporting_RealisationMPT_frmStatDevisTech_moy
    Else
      LblTitre.Text = My.Resources.Reporting_RealisationMPT_frmStatDevisTech_mont
    End If


    'on ouvre la connexion
    If oGestCnx.ConnexionSQL(MozartParams.NomServeur, MozartParams.NomSociete) = True Then
      Me.Cursor = Cursors.WaitCursor
      LoadStatTot()
      Me.Cursor = Cursors.Default
    End If

  End Sub

  Private Sub LoadStatTot()

    DtTot = New DataTable

    DtTot = LoadList(String.Format("exec api_sp_StatistiqueFournitureTech '{0}', '{1}', '{2}'", datedebut, datefin, sType), oGestCnx.CnxSQLOpen)

    GCStatTot.DataSource = DtTot

    ChartTot.DataSource = GCStatTot.DataSource

    ChartTot.Series(0).CrosshairLabelPattern = My.Resources.Global_techA & vbCrLf & My.Resources.Reporting_RealisationMPT_frmStatDevisTech_montantC

  End Sub

  Private Sub LoadStatDetAndSem(ByVal p_NPERNUM As Int32)
    DtDet = New DataTable
    DtDet = LoadList(String.Format("exec api_sp_StatDetailFournitureTech {0}, '{1}', '{2}', '{3}'", p_NPERNUM, datedebut, datefin, sType), oGestCnx.CnxSQLOpen)
    GCDetail.DataSource = DtDet

    DtSem = New DataTable
    DtSem = LoadList(String.Format("exec api_sp_StatCumulMontantJourTech {0}, '{1}', '{2}', '{3}'", p_NPERNUM, datedebut, datefin, sType), oGestCnx.CnxSQLOpen)
    GCSem.DataSource = DtSem

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

  Private Sub BtnPrint_Click(sender As System.Object, e As System.EventArgs) Handles BtnPrint.Click
    Dim oScreenShot As New CSreenShot(Me, True)
    oScreenShot.Print_Form()
  End Sub
End Class