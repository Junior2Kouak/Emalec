Imports DevExpress.XtraGrid.Views.Base

Public Class FrmGestSeriePrest

    Dim oGestPrestaSerie As CPrestationSerie
    Dim oGestPrestaSousSerie As CPrestationSousSerie

    Dim NPRESTSERID_SELECTED As Int32
    Dim NPREST_SS_SERIE_ID_SELECTED As Int32

    Private Sub FrmGestSeriePrest_Load(sender As Object, e As EventArgs) Handles MyBase.Load

        oGestPrestaSerie = New CPrestationSerie
        oGestPrestaSousSerie = New CPrestationSousSerie

        oGestPrestaSerie.LoadDataListeSerie(False)
        GCListePrestaSerie.DataSource = oGestPrestaSerie.DtListeSerie
        oGestPrestaSousSerie.LoadDataListeSousSerie(False)
        GCListePresta_SS_Serie.DataSource = oGestPrestaSousSerie.dtListeSousSerie

    End Sub

    Private Sub BtnFermer_Click(sender As Object, e As EventArgs) Handles BtnFermer.Click
        Me.Close()
    End Sub

    Private Sub BtnSerieAjouter_Click(sender As Object, e As EventArgs) Handles BtnSerieAjouter.Click

        NPRESTSERID_SELECTED = 0
        TxtSerieLibelle.Text = ""
        Txt_NPRESTSERMOHT.Text = ""

    End Sub

    Private Sub RefreshDataSerie()

        Dim iRowSelect As Int32 = GVListePrestaSerie.GetDataSourceRowIndex(GVListePrestaSerie.FocusedRowHandle)

        oGestPrestaSerie.LoadDataListeSerie()
        GCListePrestaSerie.DataSource = oGestPrestaSerie.DtListeSerie

        GVListePrestaSerie.FocusedRowHandle = iRowSelect

    End Sub

    Private Sub RefreshDataSousSerie()

        Dim iRowSelect As Int32 = GVListePresta_SS_Serie.GetDataSourceRowIndex(GVListePresta_SS_Serie.FocusedRowHandle)

        oGestPrestaSousSerie.LoadDataListeSousSerie()
        GCListePresta_SS_Serie.DataSource = oGestPrestaSousSerie.dtListeSousSerie

        GVListePresta_SS_Serie.FocusedRowHandle = iRowSelect

    End Sub

    Private Sub BtnSerieArchiver_Click(sender As Object, e As EventArgs) Handles BtnSerieArchiver.Click

        If MessageBox.Show("Voulez-vous vraiment archiver cette série ?", "Confirmation", MessageBoxButtons.YesNoCancel, MessageBoxIcon.Question) = DialogResult.Yes Then

            Dim drSelect As DataRow = GVListePrestaSerie.GetDataRow(GVListePrestaSerie.FocusedRowHandle)
            oGestPrestaSerie.ArchiverSerie(drSelect.Item("NPRESTSERID"))

            RefreshDataSerie()

        End If

    End Sub

    Private Sub BtnSaveSerie_Click(sender As Object, e As EventArgs) Handles BtnSaveSerie.Click

        If TxtSerieLibelle.Text = "" Then MessageBox.Show("Il faut saisir un libellé de série", "Erreur", MessageBoxButtons.OK, MessageBoxIcon.Exclamation) : Exit Sub
        If Txt_NPRESTSERMOHT.Text = "" Then MessageBox.Show("Il faut saisir un montant main d'oeuvre", "Erreur", MessageBoxButtons.OK, MessageBoxIcon.Exclamation) : Exit Sub

        oGestPrestaSerie.NPRESTSERID = NPRESTSERID_SELECTED
        oGestPrestaSerie.VPRESTSER = TxtSerieLibelle.Text
        oGestPrestaSerie.NPRESTSERMOHT = Txt_NPRESTSERMOHT.Text
        oGestPrestaSerie.CPRESTSER_ACTIF = oGestPrestaSerie.bPrestaSerieActif
        oGestPrestaSerie.NPRESTSERCOEFNUIT = Txt_NPRESTSERMOHT.Text

        oGestPrestaSerie.SaveSerie()

        RefreshDataSerie()

    End Sub

    Private Sub BtnSerieLstArchives_Click(sender As Object, e As EventArgs) Handles BtnSerieLstArchives.Click

        If oGestPrestaSerie.bPrestaSerieActif = True Then
            oGestPrestaSerie.bPrestaSerieActif = False
            BtnSerieAjouter.Visible = False
            BtnSerieArchiver.Visible = False
            BtnSerieRestaure.Visible = True
            BtnSerieLstArchives.Text = "Liste actifs"

        Else
            oGestPrestaSerie.bPrestaSerieActif = True
            BtnSerieAjouter.Visible = True
            BtnSerieArchiver.Visible = True
            BtnSerieRestaure.Visible = False
            BtnSerieLstArchives.Text = "Liste archives"
        End If
        RefreshDataSerie()

    End Sub

    Private Sub BtnSerieRestaure_Click(sender As Object, e As EventArgs) Handles BtnSerieRestaure.Click

        If MessageBox.Show("Voulez-vous vraiment restaurer cette série ?", "Confirmation", MessageBoxButtons.YesNoCancel, MessageBoxIcon.Question) = DialogResult.Yes Then

            Dim drSelect As DataRow = GVListePrestaSerie.GetDataRow(GVListePrestaSerie.FocusedRowHandle)
            oGestPrestaSerie.RestaurerSerie(drSelect.Item("NPRESTSERID"))

            RefreshDataSerie()

        End If

    End Sub

    Private Sub GVListePrestaSerie_FocusedRowChanged(sender As Object, e As FocusedRowChangedEventArgs) Handles GVListePrestaSerie.FocusedRowChanged

        If e.FocusedRowHandle < -1 Then

            TxtSerieLibelle.Text = ""
            Txt_NPRESTSERMOHT.EditValue = ""
            Exit Sub
        End If

        Dim drSelect As DataRow = GVListePrestaSerie.GetDataRow(e.FocusedRowHandle)
        NPRESTSERID_SELECTED = drSelect.Item("NPRESTSERID")
        TxtSerieLibelle.Text = drSelect.Item("VPRESTSER")
        Txt_NPRESTSERMOHT.EditValue = drSelect.Item("NPRESTSERMOHT")
        TxtEditCoefNuit.EditValue = drSelect.Item("NPRESTSERCOEFNUIT")

    End Sub

    Private Sub BtnSousFermer_Click(sender As Object, e As EventArgs) Handles BtnSousFermer.Click
        Me.Close()
    End Sub

    Private Sub BtnSaveSousSerie_Click(sender As Object, e As EventArgs) Handles BtnSaveSousSerie.Click

        If TxtSousSerieLibelle.Text = "" Then MessageBox.Show("Il faut saisir un libellé de sous-série", "Erreur", MessageBoxButtons.OK, MessageBoxIcon.Exclamation) : Exit Sub

        oGestPrestaSousSerie.NPREST_SS_SERIE_ID = NPREST_SS_SERIE_ID_SELECTED
        oGestPrestaSousSerie.VPREST_TYPE_LIB = TxtSousSerieLibelle.Text
        oGestPrestaSousSerie.BPREST_SS_SERIE_ACTIF = oGestPrestaSousSerie.bPrestaSousSerieActif

        oGestPrestaSousSerie.SaveSousSerie()

        RefreshDataSousSerie()

    End Sub

    Private Sub BtnSousSerieAjouter_Click(sender As Object, e As EventArgs) Handles BtnSousSerieAjouter.Click

        NPREST_SS_SERIE_ID_SELECTED = 0
        TxtSousSerieLibelle.Text = ""

    End Sub

    Private Sub BtnSousSerieArchiver_Click(sender As Object, e As EventArgs) Handles BtnSousSerieArchiver.Click

        If MessageBox.Show("Voulez-vous vraiment archiver cette série ?", "Confirmation", MessageBoxButtons.YesNoCancel, MessageBoxIcon.Question) = DialogResult.Yes Then

            Dim drSelect As DataRow = GVListePresta_SS_Serie.GetDataRow(GVListePresta_SS_Serie.FocusedRowHandle)
            oGestPrestaSousSerie.ArchiverSousSerie(drSelect.Item("NPREST_SS_SERIE_ID"))

            RefreshDataSousSerie()

        End If

    End Sub

    Private Sub BtnSousSerieLstArchives_Click(sender As Object, e As EventArgs) Handles BtnSousSerieLstArchives.Click

        If oGestPrestaSousSerie.bPrestaSousSerieActif = True Then
            oGestPrestaSousSerie.bPrestaSousSerieActif = False
            BtnSousSerieAjouter.Visible = False
            BtnSousSerieArchiver.Visible = False
            BtnSousSerieRestaure.Visible = True
            BtnSousSerieLstArchives.Text = "Liste actifs"

        Else
            oGestPrestaSousSerie.bPrestaSousSerieActif = True
            BtnSousSerieAjouter.Visible = True
            BtnSousSerieArchiver.Visible = True
            BtnSousSerieRestaure.Visible = False
            BtnSousSerieLstArchives.Text = "Liste archives"
        End If

        RefreshDataSousSerie()

    End Sub

    Private Sub BtnSousSerieRestaure_Click(sender As Object, e As EventArgs) Handles BtnSousSerieRestaure.Click

        If MessageBox.Show("Voulez-vous vraiment restaurer cette sous-série ?", "Confirmation", MessageBoxButtons.YesNoCancel, MessageBoxIcon.Question) = DialogResult.Yes Then

            Dim drSelect As DataRow = GVListePresta_SS_Serie.GetDataRow(GVListePresta_SS_Serie.FocusedRowHandle)
            oGestPrestaSousSerie.RestaurerSousSerie(drSelect.Item("NPREST_SS_SERIE_ID"))

            RefreshDataSousSerie()

        End If

    End Sub

    Private Sub GVListePresta_SS_Serie_FocusedRowChanged(sender As Object, e As FocusedRowChangedEventArgs) Handles GVListePresta_SS_Serie.FocusedRowChanged

        If e.FocusedRowHandle < -1 Then
            NPREST_SS_SERIE_ID_SELECTED = 0
            TxtSousSerieLibelle.Text = ""
            Exit Sub
        End If

        Dim drSelect As DataRow = GVListePresta_SS_Serie.GetDataRow(e.FocusedRowHandle)
        NPREST_SS_SERIE_ID_SELECTED = drSelect.Item("NPREST_SS_SERIE_ID")
        TxtSousSerieLibelle.Text = drSelect.Item("VPREST_SS_SERIE_LIB")

    End Sub

End Class