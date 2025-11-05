Imports System.Data.SqlClient
Imports MozartLib

Public Class frmStatFraisEntretienVehicule

  Dim CnxFraisVeh As New CGestionSQL
  Dim dt As DataTable
  Dim sActif As String

  Private Sub frmStatFraisEntretienVehicule_FormClosed(sender As Object, e As System.Windows.Forms.FormClosedEventArgs) Handles Me.FormClosed
    CnxFraisVeh.CloseConnexionSQL()
  End Sub

  Private Sub frmStatFraisEntretienVehicule_Load(sender As System.Object, e As System.EventArgs) Handles MyBase.Load

    Try
      If CnxFraisVeh.ConnexionSQL(MozartParams.NomServeur, MozartParams.NomSociete) = True Then

        'init des dates
        DTPFin.Value = Now.Date
        DTPDebut.Value = DateAdd(DateInterval.Year, -10, DTPFin.Value)
        sActif = "O"

      Else
        MessageBox.Show(My.Resources.Global_serveur_EMALEC, My.Resources.Global_Erreur, MessageBoxButtons.OK, MessageBoxIcon.Error)
      End If

    Catch ex As Exception
      MessageBox.Show(My.Resources.Reporting_RealisationMPT_frmStatFraisEntretienVehicule_sub + ex.Message, My.Resources.Global_Erreur, MessageBoxButtons.OK, MessageBoxIcon.Error)
    End Try

  End Sub

  Private Sub LoadDataGridView(ByVal p_datedebut As Date, ByVal p_datefin As Date, ByVal p_actif As String)

    Try

      Me.Cursor = Cursors.WaitCursor

      dt = New DataTable

      Dim cmdLoadList As New SqlCommand("api_sp_StatistiqueFraisEntretienVehicule", CnxFraisVeh.CnxSQLOpen)
      cmdLoadList.CommandType = CommandType.StoredProcedure
      'sqlcmd
      cmdLoadList.Parameters.Add("@p_datdebut", SqlDbType.DateTime)
      cmdLoadList.Parameters("@p_datdebut").Value = DTPDebut.Value
      cmdLoadList.Parameters.Add("@p_datfin", SqlDbType.DateTime)
      cmdLoadList.Parameters("@p_datfin").Value = DTPFin.Value
      cmdLoadList.Parameters.Add("@p_cactif", SqlDbType.Char)
      cmdLoadList.Parameters("@p_cactif").Value = p_actif

      Dim sqlAdpat As SqlDataAdapter = New SqlDataAdapter(cmdLoadList)
      sqlAdpat.Fill(dt)

      GCStat.DataSource = dt

    Catch ex As Exception

      MessageBox.Show(My.Resources.Reporting_RealisationMPT_frmStatFraisEntretienVehicule_sub2 + ex.Message, My.Resources.Global_Erreur, MessageBoxButtons.OK, MessageBoxIcon.Error)

    Finally

      Me.Cursor = Cursors.Default

    End Try

  End Sub

  Private Sub btnValid_Click(sender As System.Object, e As System.EventArgs) Handles btnValid.Click

    LoadDataGridView(DTPDebut.Value, DTPFin.Value, sActif)

  End Sub

  Private Sub BtnFermer_Click(sender As System.Object, e As System.EventArgs) Handles BtnFermer.Click
    Me.Close()
  End Sub

  Private Sub BtnArchives_Click(sender As System.Object, e As System.EventArgs) Handles BtnArchives.Click

    Select Case sActif

      Case "O"

        sActif = "N"
        LblTitre.Text = My.Resources.Reporting_RealisationMPT_frmStatFraisEntretienVehicule_frais
        BtnArchives.Text = My.Resources.Global_vehicule_actifs

      Case Else

        sActif = "O"
        LblTitre.Text = My.Resources.Reporting_RealisationMPT_frmStatFraisEntretienVehicule_frai_actifs
        BtnArchives.Text = My.Resources.Global_vehicule_archivé

    End Select

    LoadDataGridView(DTPDebut.Value, DTPFin.Value, sActif)

  End Sub

  Private Sub BtnPrint_Click(sender As System.Object, e As System.EventArgs) Handles BtnPrint.Click

    If GVStat.RowCount = 0 Then Exit Sub

    If MessageBox.Show(My.Resources.Global_imprimer_tab, My.Resources.Global_ConfirmationI, MessageBoxButtons.YesNoCancel, MessageBoxIcon.Question) = Windows.Forms.DialogResult.Yes Then

      CustomizeForExport(0)

      GVStat.OptionsPrint.AutoWidth = True

      Dim ps As New DevExpress.XtraPrinting.PrintingSystemBase()
      Dim link As DevExpress.XtraPrintingLinks.PrintableComponentLinkBase = New DevExpress.XtraPrintingLinks.PrintableComponentLinkBase(ps)
      link.Component = GCStat
      link.Landscape = True
      link.Margins.Left = 1
      link.Margins.Right = 1
      link.Margins.Top = 1
      link.Margins.Bottom = 1
      link.CreateDocument()

      Dim tReportPrintTool As New DevExpress.XtraPrinting.PrintTool(link.PrintingSystemBase)
      tReportPrintTool.ShowPreviewDialog()
      'link.PrintingSystemBase.ExportToPdf(SFDSynCompta.FileName)

      CustomizeForExport(1)

    End If

  End Sub

  '********************************************************************************************************
  'Cette fonction permet de customizer le tableau avnat export
  '********************************************************************************************************
  Private Sub CustomizeForExport(ByVal p_iSensExport As Int32)

    If p_iSensExport = 0 Then

      ColVVEHIMAT.AppearanceCell.Font = New Font(ColVVEHIMAT.AppearanceCell.Font.Name, 6, FontStyle.Bold)

      ColNCOMNUM.AppearanceCell.Font = New Font(ColNCOMNUM.AppearanceCell.Font.Name, 6, FontStyle.Bold)

      ColDCOMDAT.AppearanceCell.Font = New Font(ColDCOMDAT.AppearanceCell.Font.Name, 6, FontStyle.Bold)

      ColNDINNUM.AppearanceCell.Font = New Font(ColNDINNUM.AppearanceCell.Font.Name, 6, FontStyle.Bold)

      ColVFOUMAT.AppearanceCell.Font = New Font(ColVFOUMAT.AppearanceCell.Font.Name, 6, FontStyle.Bold)

      ColNLCOPT.AppearanceCell.Font = New Font(ColNLCOPT.AppearanceCell.Font.Name, 6, FontStyle.Bold)

    Else

      ColVVEHIMAT.AppearanceCell.Font = New Font(ColVVEHIMAT.AppearanceCell.Font.Name, 8.25, FontStyle.Bold)

      ColNCOMNUM.AppearanceCell.Font = New Font(ColNCOMNUM.AppearanceCell.Font.Name, 8.25, FontStyle.Bold)

      ColDCOMDAT.AppearanceCell.Font = New Font(ColDCOMDAT.AppearanceCell.Font.Name, 8.25, FontStyle.Bold)

      ColNDINNUM.AppearanceCell.Font = New Font(ColNDINNUM.AppearanceCell.Font.Name, 8.25, FontStyle.Bold)

      ColVFOUMAT.AppearanceCell.Font = New Font(ColVFOUMAT.AppearanceCell.Font.Name, 8.25, FontStyle.Bold)

      ColNLCOPT.AppearanceCell.Font = New Font(ColNLCOPT.AppearanceCell.Font.Name, 8.25, FontStyle.Bold)

    End If

  End Sub

End Class