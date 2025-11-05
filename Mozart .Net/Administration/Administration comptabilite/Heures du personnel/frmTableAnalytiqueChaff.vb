Imports System.Data.SqlClient
Imports DevExpress.XtraEditors.Controls
Imports DevExpress.XtraPivotGrid
Imports MozartLib

Public Class frmTableAnalytiqueChaff

    Dim sModesaisie As String
    Dim nMois As Int16

    Public Sub New(ByVal c_sModesaisie As Object)

        ' Cet appel est requis par le concepteur.
        InitializeComponent()

        ' Ajoutez une initialisation quelconque après l'appel InitializeComponent().
        sModesaisie = Convert.ToString(c_sModesaisie).ToUpper

    End Sub

    Private Sub BtnFermer_Click(sender As System.Object, e As System.EventArgs) Handles BtnFermer.Click
        Me.Close()
    End Sub

    Private Sub frmTableAnalytiqueChaff_Load(sender As System.Object, e As System.EventArgs) Handles MyBase.Load

        Initboutons(Me)

        If sModesaisie = My.Resources.Global_Utilisateur Then

            LblTitre.Text = My.Resources.Admin_frmTableAnalytiqueChaff_tableauSaisie
            BtnPrint.Visible = False
            CboAnnee.Enabled = False
            CboMois.Enabled = False
            BtnMois.Visible = True

        Else
            BtnMois.Visible = False
            BtnPrint.Visible = True
            CboAnnee.Enabled = True
            CboMois.Enabled = True

            sModesaisie = My.Resources.Global_Superviseur

        End If

        RemplirCombo()

        'select par defaut
        CboMois.EditValue = DateAdd(DateInterval.Month, -1, Now).Month
        CboAnnee.EditValue = DateAdd(DateInterval.Month, -1, Now).Year
        nMois = -1

        BtnMois.Text = TextBoutonMois()

    End Sub
    Private Function TextBoutonMois() As String

        If nMois = -1 Then
            Return My.Resources.Global_mois_precedent
        Else
            Return My.Resources.Global_mois_suivant
        End If

    End Function

    Private Sub RemplirCombo()

        Dim i As Integer

        Dim dtMois As New DataTable
        Dim dtAnnee As New DataTable

        dtMois.Columns.Add("NIDMOIS", Type.GetType("System.Int32"))
        dtMois.Columns.Add("SMOISNAME", Type.GetType("System.String"))

        dtAnnee.Columns.Add("NIDANNEE", Type.GetType("System.Int32"))

        i = 0
        For i = 0 To 11

            'CboMois.Properties.Items.Add(New CDateMonth(i + 1, MonthName(i + 1)))
            Dim drnew As DataRow = dtMois.NewRow
            drnew.Item("NIDMOIS") = i + 1
            drnew.Item("SMOISNAME") = MonthName(i + 1)

            dtMois.Rows.Add(drnew)

        Next

        CboMois.Properties.DataSource = dtMois

        For i = 0 To 5

            Dim drnew As DataRow = dtAnnee.NewRow
            drnew.Item("NIDANNEE") = Year(DateAdd("yyyy", -i, Now))
            dtAnnee.Rows.Add(drnew)

        Next

        CboAnnee.Properties.DataSource = dtAnnee

    End Sub

  Private Sub LoadData()

    Me.Cursor = Cursors.WaitCursor

    Try

      PGCHeures.DataSource = ModDataGridView.LoadList(String.Format("exec [api_sp_CalculHeureChaffNET] {0}, {1}, {2}", CboMois.EditValue, CboAnnee.EditValue, sModesaisie), MozartDatabase.cnxMozart)

      Me.Text = My.Resources.Global_tableauAnalytique & CboMois.Text & " " & CboAnnee.Text
      LblTitre.Text = My.Resources.Global_tableauAnalytique & " " & CboMois.Text & " " & CboAnnee.Text
      LblRef.Text = My.Resources.Global_HeuresRef & RechercheHeureRef(CboMois.EditValue, CboAnnee.EditValue)

    Catch ex As Exception
      MessageBox.Show(My.Resources.Admin_frmTableAnalytiqueChaff_LoadData + ex.Message, My.Resources.Global_Erreur, MessageBoxButtons.OK, MessageBoxIcon.Error)
    Finally
      Me.Cursor = Cursors.Default
    End Try

  End Sub

  Private Sub PGCHeures_CellClick(sender As Object, e As DevExpress.XtraPivotGrid.PivotCellEventArgs) Handles PGCHeures.CellClick

        If e.RowValueType = PivotGridValueType.GrandTotal Then Exit Sub
        If e.ColumnValueType = PivotGridValueType.GrandTotal Then Exit Sub

        If Not e.ColumnField Is Nothing AndAlso e.ColumnField.FieldName = "NCANNUM" Then

            Dim ds As PivotDrillDownDataSource = e.CreateDrillDownDataSource()
            Dim DateSelect As DateTime = Convert.ToDateTime(String.Format("01/{0}/{1}", CboMois.EditValue, CboAnnee.EditValue))

            If ds.RowCount > 0 Then

                Dim oFrmTableDetailH As New frmSaisieHChaff(ds.Item(0)("VPERNOM"), ds.Item(0)("NPERNUM"), ds.Item(0)("NCANNUM"), ds.Item(0)("TOTALHR"), DateSelect)
                oFrmTableDetailH.ShowDialog()

                LoadData()

            Else

                Dim oFrmTableDetailH As New frmSaisieHChaff(e.GetFieldValue(PGF_VPERNOM), e.GetFieldValue(PGF_NPERNUM, e.RowIndex), e.GetFieldValue(PGF_NCANNUM), 0, DateSelect)
                oFrmTableDetailH.ShowDialog()

                LoadData()

            End If

        End If

    End Sub

    Private Sub PGCHeures_CustomCellValue(sender As Object, e As DevExpress.XtraPivotGrid.PivotCellValueEventArgs) Handles PGCHeures.CustomCellValue

        If e.DataField.FieldName = "TOTALHR" AndAlso e.Value = 0 Then e.Value = ""

    End Sub

    Private Sub frmTableAnalytiqueH_SizeChanged(sender As Object, e As System.EventArgs) Handles Me.SizeChanged

        PGCHeures.Size = New Size(Me.Size.Width - PGCHeures.Location.X - 30, Me.Size.Height - PGCHeures.Location.Y - 80)

    End Sub

    Private Sub CboMois_EditValueChanged(sender As System.Object, e As System.EventArgs) Handles CboMois.EditValueChanged

        If Not CboAnnee.EditValue Is Nothing AndAlso CboAnnee.EditValue.ToString <> "" Then

            LoadData()

        End If

    End Sub

    Private Sub CboAnnee_EditValueChanged(sender As System.Object, e As System.EventArgs) Handles CboAnnee.EditValueChanged

        If Not CboMois.EditValue Is Nothing AndAlso CboAnnee.EditValue.ToString <> "" Then

            LoadData()

        End If

    End Sub

    Private Sub BtnPrint_Click(sender As System.Object, e As System.EventArgs) Handles BtnPrint.Click

        PGCHeures.ShowPrintPreview()

    End Sub

    Private Sub BtnMois_Click(sender As System.Object, e As System.EventArgs) Handles BtnMois.Click

        'on convertit la date et on lui retire un mois
        Dim DateSelect As DateTime = Convert.ToDateTime(String.Format("01/{0}/{1}", CboMois.EditValue, CboAnnee.EditValue)).AddMonths(nMois)
        CboMois.EditValue = DateSelect.Month
        CboAnnee.EditValue = DateSelect.Year

        If nMois = -1 Then
            nMois = 1
        Else
            nMois = -1
        End If
        BtnMois.Text = TextBoutonMois()

    End Sub

  Private Sub BtnExportXLS_Click(sender As Object, e As EventArgs) Handles BtnExportXLS.Click
    SFD.Filter = "Fichiers XLSX |*.XLSX"
    SFD.ShowDialog()

    If SFD.FileName <> "" Then
      PGCHeures.ExportToXlsx(SFD.FileName)
    End If
  End Sub
End Class



