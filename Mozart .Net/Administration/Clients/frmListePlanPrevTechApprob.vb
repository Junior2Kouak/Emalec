Imports System.Reflection.MethodBase
Imports MozartLib

Public Class frmListePlanPrevTechApprob

  Dim oPlanPrevention As CPLANPREVENTION
  Dim calendar_open As String
  Private Sub frmListePlanPrevTechApprob_Load(sender As System.Object, e As System.EventArgs) Handles MyBase.Load

    'INIT
    oPlanPrevention = New CPLANPREVENTION(MozartDatabase.cnxMozart, MozartParams.NomSociete)

    txtDtFin.Text = Now.Date.ToShortDateString
    txtDtDebut.Text = Now.Date.AddYears(-1).ToShortDateString

  End Sub

  Private Sub BtnQuit_Click(sender As System.Object, e As System.EventArgs) Handles BtnQuit.Click

    If Not oPlanPrevention Is Nothing Then

      Dim sRetLog As String = oPlanPrevention.ClearFiles()
      If sRetLog <> "" Then MessageBox.Show(String.Format(My.Resources.Admin_frmListePlanPrevTechApprob_Erreur, Me.GetType.Name, GetCurrentMethod().Name, sRetLog), My.Resources.Global_Erreur)

    End If

    Me.Close()
  End Sub

  Private Sub btnVisualiser_Click(sender As System.Object, e As System.EventArgs) Handles btnVisualiser.Click
    Try

      Dim sRetLog As String = ""

      If GVLSTPLANPREV.SelectedRowsCount = 0 Then Exit Sub

      Dim dtrow As DataRow = GVLSTPLANPREV.GetDataRow(GVLSTPLANPREV.FocusedRowHandle)

      'on teste si les dll existe
      sRetLog = oPlanPrevention.DllsNeeded
      If sRetLog <> "" Then MessageBox.Show(String.Format(My.Resources.Admin_frmListePlanPrevTechApprob_Erreur, Me.GetType.Name, GetCurrentMethod().Name, sRetLog), My.Resources.Global_Erreur) : Exit Sub

      sRetLog = oPlanPrevention.GeneratePlanPrevSigne(dtrow)
      If sRetLog <> "" Then MessageBox.Show(String.Format(My.Resources.Admin_frmListePlanPrevTechApprob_Erreur, Me.GetType.Name, GetCurrentMethod().Name, sRetLog), My.Resources.Global_Erreur) : Exit Sub

      Dim oFrmVisuDoc As New frmVisuDoc(oPlanPrevention.FileOut)
      oFrmVisuDoc.ShowDialog()

      ' Nettoyage
      oFrmVisuDoc = Nothing

    Catch ex As Exception
      MessageBox.Show(String.Format(My.Resources.Admin_frmListePlanPrevTechApprob_Erreur, Me.GetType.Name, GetCurrentMethod().Name, ex.Message), My.Resources.Global_Erreur)
    End Try
  End Sub

  Private Sub BtnDate1_Click(sender As Object, e As EventArgs) Handles BtnDate1.Click
    If MonthCalendar1.Visible Then
      calendar_open = ""
      MonthCalendar1.Visible = False
    Else
      calendar_open = "txtDtDebut"
      MonthCalendar1.Visible = True
    End If
    If txtDtDebut.Text <> "" Then
      MonthCalendar1.SetDate(txtDtDebut.Text)
    End If
  End Sub

  Private Sub BtnDate2_Click(sender As Object, e As EventArgs) Handles BtnDate2.Click
    If MonthCalendar1.Visible Then
      calendar_open = ""
      MonthCalendar1.Visible = False
    Else
      calendar_open = "txtDtFin"
      MonthCalendar1.Visible = True
    End If
    If txtDtFin.Text <> "" Then
      MonthCalendar1.SetDate(txtDtFin.Text)
    End If
  End Sub

  Private Sub MonthCalendar1_DateSelected(sender As Object, e As System.Windows.Forms.DateRangeEventArgs) Handles MonthCalendar1.DateSelected
    Select Case calendar_open

      Case "txtDtDebut"
        txtDtDebut.Text = MonthCalendar1.SelectionStart.Date
      Case "txtDtFin"
        txtDtFin.Text = MonthCalendar1.SelectionStart.Date

    End Select

    MonthCalendar1.Visible = False
  End Sub

  Private Sub BtValider_Click(sender As Object, e As EventArgs) Handles BtValider.Click

    Me.Cursor = Cursors.WaitCursor

    oPlanPrevention.LoadData(txtDtDebut.Text, txtDtFin.Text)

    GCLSTPLANPREV.DataSource = oPlanPrevention.DtListePLanPrev
    Me.Cursor = Cursors.Default

  End Sub

  Private Sub BtnExportXLS_Click(sender As Object, e As EventArgs) Handles BtnExportXLS.Click
    SFD.Filter = "Fichiers XLSX |*.XLSX"
    SFD.ShowDialog()

    If SFD.FileName <> "" Then
      GCLSTPLANPREV.ExportToXlsx(SFD.FileName)
    End If
  End Sub
End Class