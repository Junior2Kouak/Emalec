Imports System.Data.SqlClient
Imports DevExpress.XtraGrid.Views.BandedGrid
Imports MozartLib

Public Class frmValidationGDReceive

  Dim oFraisJourSyntheseGD As CFraisGDValidation

  Dim bArchives As Boolean
  Dim DateDebut As DateTime
  Dim DateFin As DateTime
  Dim iNPERNUM As Int32
  Dim sVPERNOM As String

  Dim dtListeTech As DataTable

  Public Sub New()

    ' Cet appel est requis par le concepteur.
    InitializeComponent()

    ' Ajoutez une initialisation quelconque après l'appel InitializeComponent().
    'iNPERNUM = Convert.ToInt32(c_NPERNUM)

  End Sub

  Private Sub frmValidationGDReceive_Load(sender As System.Object, e As System.EventArgs) Handles MyBase.Load
    oFraisJourSyntheseGD = New CFraisGDValidation

    'ouverture sur la semaine en cours en archives
    DateEditChoixSem.EditValue = Now.Date
    bArchives = False

    LoadWindow()

    LoadCboTech()

  End Sub
  Private Sub LoadCboTech()
    Dim sSql As String
    'on charge la combo tech
    dtListeTech = New DataTable

    sSql = "[api_sp_FraisJourCboListeTech]"

    Dim sqlcmdListTech As New SqlCommand(sSql, MozartDatabase.cnxMozart)
    sqlcmdListTech.CommandType = CommandType.StoredProcedure
        sqlcmdListTech.Parameters.Add("@p_bArchives", SqlDbType.Bit).Value = bArchives
		dtListeTech.Load(sqlcmdListTech.ExecuteReader)

		GLookUpTech.Properties.DataSource = dtListeTech
	End Sub

    Private Sub LoadWindow()

        If oFraisJourSyntheseGD Is Nothing Then Exit Sub

        Select Case bArchives

            Case True

                Me.Text = My.Resources.SaisieFrais_frmValidationGDReceive_liste
                Label1.Text = My.Resources.SaisieFrais_frmValidationGDReceive_liste

                BtnArchives.Text = My.Resources.Global_en_attente

                lblSem.Visible = True
				DateEditChoixSem.Visible = True


                oFraisJourSyntheseGD.bArchives = bArchives

                DateDebut = getFirstDayOfWeek(DateEditChoixSem.EditValue)
                DateFin = DateDebut.AddDays(6)

                oFraisJourSyntheseGD.dDateDebut = DateDebut
                oFraisJourSyntheseGD.dDateFin = DateFin
				oFraisJourSyntheseGD.npernum = If(GLookUpTech.EditValue.ToString = "", 0, GLookUpTech.EditValue)

                oFraisJourSyntheseGD.LoadFraisJourSynthGD()

                GCFraisJourSyntheseGD.DataSource = oFraisJourSyntheseGD.dtSyntheseFraisJourGD

            Case Else

                Me.Text = My.Resources.SaisieFrais_frmValidationGDReceive_liste_valider
                Label1.Text = My.Resources.SaisieFrais_frmValidationGDReceive_liste_valider

                BtnArchives.Text = My.Resources.Global_archives

                lblSem.Visible = False
				DateEditChoixSem.Visible = False

                oFraisJourSyntheseGD.bArchives = bArchives
				oFraisJourSyntheseGD.npernum = If(GLookUpTech.EditValue.ToString = "", 0, GLookUpTech.EditValue)
                oFraisJourSyntheseGD.LoadFraisJourSynthGD()
                GCFraisJourSyntheseGD.DataSource = oFraisJourSyntheseGD.dtSyntheseFraisJourGD

        End Select

    End Sub

    Private Sub BtnArchives_Click(sender As System.Object, e As System.EventArgs) Handles BtnArchives.Click
        bArchives = Not bArchives
		LoadWindow()
		LoadCboTech()
    End Sub

    Private Sub BtnFermer_Click(sender As System.Object, e As System.EventArgs) Handles BtnFermer.Click
        Me.Close()
    End Sub

    Private Sub BGFraisJourSyntheseGD_CellMerge(sender As Object, e As DevExpress.XtraGrid.Views.Grid.CellMergeEventArgs) Handles BGFraisJourSyntheseGD.CellMerge

        'colonne Technicien
        If e.Column.FieldName = "VPERNOMTECH" Then

            Dim value1 As String = BGFraisJourSyntheseGD.GetRowCellValue(e.RowHandle1, e.Column).ToString
            Dim value2 As String = BGFraisJourSyntheseGD.GetRowCellValue(e.RowHandle2, e.Column).ToString

            If value1 = value2 Then
                e.Merge = True
                e.Handled = True
            End If

        End If

        ''colonne client
        If e.Column.FieldName = "VCLINOM" Then

            Dim sDate1 As String = BGFraisJourSyntheseGD.GetRowCellValue(e.RowHandle1, BGColDFRAISJOUR).ToString
            Dim sDate2 As String = BGFraisJourSyntheseGD.GetRowCellValue(e.RowHandle2, BGColDFRAISJOUR).ToString

            If sDate1 <> sDate2 Then
                e.Merge = False
                e.Handled = True
                Exit Sub
            End If

            Dim value1 As String = BGFraisJourSyntheseGD.GetRowCellValue(e.RowHandle1, e.Column).ToString
            Dim value2 As String = BGFraisJourSyntheseGD.GetRowCellValue(e.RowHandle2, e.Column).ToString

            If value1 = value2 Then
                e.Merge = True
                e.Handled = True
            End If

        End If

        'colonne site
        If e.Column.FieldName = "VSITNOM" Then

            Dim sNomClient1 As String = BGFraisJourSyntheseGD.GetRowCellValue(e.RowHandle1, BGColVCLINOM).ToString
            Dim sNomClient2 As String = BGFraisJourSyntheseGD.GetRowCellValue(e.RowHandle2, BGColVCLINOM).ToString

            If sNomClient1 <> sNomClient2 Then
                e.Merge = False
                e.Handled = True
                Exit Sub
            End If

            Dim value1 As String = BGFraisJourSyntheseGD.GetRowCellValue(e.RowHandle1, e.Column).ToString
            Dim value2 As String = BGFraisJourSyntheseGD.GetRowCellValue(e.RowHandle2, e.Column).ToString

            If value1 = value2 Then
                e.Merge = True
                e.Handled = True
            End If
        End If

        'colonne repas/GD et Etat
        If e.Column.FieldName = "VTYPEREPASDETAIL" Or e.Column.FieldName = "VISAFRAISGD" Then

            Dim DateJour1 As String = BGFraisJourSyntheseGD.GetRowCellValue(e.RowHandle1, BGColDFRAISJOUR).ToString
            Dim DateJour2 As String = BGFraisJourSyntheseGD.GetRowCellValue(e.RowHandle2, BGColDFRAISJOUR).ToString

            If DateJour1 <> DateJour2 Then
                e.Merge = False
                e.Handled = True
                Exit Sub
            End If

            Dim value1 As String = BGFraisJourSyntheseGD.GetRowCellValue(e.RowHandle1, e.Column).ToString
            Dim value2 As String = BGFraisJourSyntheseGD.GetRowCellValue(e.RowHandle2, e.Column).ToString

            If value1 = value2 Then
                e.Merge = True
                e.Handled = True
            End If

        End If
    End Sub

    Private Sub BGFraisJourSyntheseGD_RowCellClick(sender As Object, e As DevExpress.XtraGrid.Views.Grid.RowCellClickEventArgs) Handles BGFraisJourSyntheseGD.RowCellClick

        If bArchives = True Then Exit Sub

        'pas d action si donnees transferees
        'traitement different selon l'etat
        Dim oBDView As BandedGridView = TryCast(sender, BandedGridView)
        Dim sqlcmd As SqlCommand

        'oBDView.GetSelectedCells(e.RowHandle)
        Dim dtr As DataRow = oBDView.GetDataRow(e.RowHandle)
        Dim iPos As Int32

        iPos = BGFraisJourSyntheseGD.GetVisibleIndex(e.RowHandle)

        If e.Column.FieldName = "VISAFRAISGD" Then
			' cas du GD
            If dtr.Item("VTYPEREPAS") = "GD" And dtr.Item("BKMSTECHASTREINTE") = True Then

                'si visa deja deposer alors exit
                If Not dtr.Item("DVISAGD") Is DBNull.Value Then Exit Sub

                'on verifie si montant saisi
                If dtr.Item("NMONTANTGD") <= 0 Then
                    MessageBox.Show(My.Resources.SaisieFrais_frmValidationGDReceive_msg, My.Resources.Global_Erreur, MessageBoxButtons.OK, MessageBoxIcon.Exclamation)
                    Exit Sub
                End If

                'on verifie si montant saisi
                If dtr.Item("VCOMMREPAS").ToString = "" Then
                    MessageBox.Show(My.Resources.SaisieFrais_frmValidationGDReceive_msg2, My.Resources.Global_Erreur, MessageBoxButtons.OK, MessageBoxIcon.Exclamation)
                    Exit Sub
                End If

                Select Case MessageBox.Show(My.Resources.SaisieFrais_frmValidationGDReceive_GD, My.Resources.Global_msg_info, MessageBoxButtons.YesNoCancel, MessageBoxIcon.Exclamation)

                    Case Windows.Forms.DialogResult.Yes

            'update montant GD dans tsynchrorepastech
            sqlcmd = New SqlCommand("api_sp_FraisJourUpdateVISAFRAISGD", MozartDatabase.cnxMozart)
            sqlcmd.CommandType = CommandType.StoredProcedure
                        sqlcmd.Parameters.Add("@p_NIDREPASTECHUNIQUE", SqlDbType.Int).Value = dtr.Item("NIDREPASTECHUNIQUE")

                        sqlcmd.ExecuteNonQuery()

            'update montant GD dans tsynchrorepastech
            sqlcmd = New SqlCommand("api_sp_FraisJourUpdateVISAFRAISASTREINTE", MozartDatabase.cnxMozart)
            sqlcmd.CommandType = CommandType.StoredProcedure
                        sqlcmd.Parameters.Add("@p_NIDKMSTECHUNIQUE", SqlDbType.Int).Value = dtr.Item("NIDKMSTECHUNIQUE")
                        sqlcmd.ExecuteNonQuery()

                        oFraisJourSyntheseGD.LoadFraisJourSynthGD()

                        GCFraisJourSyntheseGD.DataSource = oFraisJourSyntheseGD.dtSyntheseFraisJourGD

                        BGFraisJourSyntheseGD.TopRowIndex = iPos
                        BGFraisJourSyntheseGD.FocusedRowHandle = e.RowHandle

                End Select

                ' GD simple
            ElseIf dtr.Item("VTYPEREPAS") = "GD" And dtr.Item("BKMSTECHASTREINTE") = False Then

                'si visa deja deposer alors exit
                If Not dtr.Item("DVISAGD") Is DBNull.Value Then Exit Sub

                'on verifie si montant saisi
                If dtr.Item("NMONTANTGD") <= 0 Then
                    MessageBox.Show(My.Resources.SaisieFrais_frmValidationGDReceive_msg3, My.Resources.Global_Erreur, MessageBoxButtons.OK, MessageBoxIcon.Exclamation)
                    Exit Sub
                End If

                'on verifie si montant saisi
                If dtr.Item("VCOMMREPAS").ToString = "" Then
                    MessageBox.Show(My.Resources.SaisieFrais_frmValidationGDReceive_msg4, My.Resources.Global_Erreur, MessageBoxButtons.OK, MessageBoxIcon.Exclamation)
                    Exit Sub
                End If

                Select Case MessageBox.Show(My.Resources.SaisieFrais_frmValidationGDReceive_GD2, My.Resources.Global_msg_info, MessageBoxButtons.YesNoCancel, MessageBoxIcon.Exclamation)

                    Case Windows.Forms.DialogResult.Yes

            'update montant GD dans tsynchrorepastech
            sqlcmd = New SqlCommand("api_sp_FraisJourUpdateVISAFRAISGD", MozartDatabase.cnxMozart)
            sqlcmd.CommandType = CommandType.StoredProcedure
                        sqlcmd.Parameters.Add("@p_NIDREPASTECHUNIQUE", SqlDbType.Int).Value = dtr.Item("NIDREPASTECHUNIQUE")

                        sqlcmd.ExecuteNonQuery()

                        oFraisJourSyntheseGD.LoadFraisJourSynthGD()

                        GCFraisJourSyntheseGD.DataSource = oFraisJourSyntheseGD.dtSyntheseFraisJourGD

                        BGFraisJourSyntheseGD.TopRowIndex = iPos
                        BGFraisJourSyntheseGD.FocusedRowHandle = e.RowHandle

                End Select

                'seulement astreinte
            ElseIf (dtr.Item("VTYPEREPAS") = "" Or dtr.Item("VTYPEREPAS") = "RP") And dtr.Item("BKMSTECHASTREINTE") = True Then

                'si visa deja deposer alors exit
                If Not dtr.Item("DVISAGD") Is DBNull.Value Then Exit Sub

                'on verifie si montant saisi
                If dtr.Item("VCOMMREPAS").ToString = "" Then
                    MessageBox.Show(My.Resources.SaisieFrais_frmValidationGDReceive_msg5, My.Resources.Global_Erreur, MessageBoxButtons.OK, MessageBoxIcon.Exclamation)
                    Exit Sub
                End If

                Select Case MessageBox.Show(My.Resources.SaisieFrais_frmValidationGDReceive_astr, My.Resources.Global_msg_info, MessageBoxButtons.YesNoCancel, MessageBoxIcon.Exclamation)

                    Case Windows.Forms.DialogResult.Yes

            'update montant GD dans tsynchrorepastech
            sqlcmd = New SqlCommand("api_sp_FraisJourUpdateVISAFRAISASTREINTE", MozartDatabase.cnxMozart)
            sqlcmd.CommandType = CommandType.StoredProcedure
                        sqlcmd.Parameters.Add("@p_NIDKMSTECHUNIQUE", SqlDbType.Int).Value = dtr.Item("NIDKMSTECHUNIQUE")
                        sqlcmd.ExecuteNonQuery()

                        oFraisJourSyntheseGD.LoadFraisJourSynthGD()

                        GCFraisJourSyntheseGD.DataSource = oFraisJourSyntheseGD.dtSyntheseFraisJourGD

                        BGFraisJourSyntheseGD.TopRowIndex = iPos
                        BGFraisJourSyntheseGD.FocusedRowHandle = e.RowHandle

                End Select
            End If

        ElseIf e.Column.FieldName = "VTYPEREPASDETAIL" Then

            If dtr.Item("VTYPEREPAS") = "GD" Then

                'saisir du montant
                Dim oFrmSaisieMttGD As New frmSaisieMontantGD(If(dtr.Item("NMONTANTGD") = 0, 0, dtr.Item("NMONTANTGD")))
                oFrmSaisieMttGD.ShowDialog()

                If oFrmSaisieMttGD.bCancel = False Then

          'update montant GD dans tsynchrorepastech
          sqlcmd = New SqlCommand("api_sp_FraisJourUpdateMontantGD", MozartDatabase.cnxMozart)
          sqlcmd.CommandType = CommandType.StoredProcedure
                    sqlcmd.Parameters.Add("@p_NIDREPASTECHUNIQUE", SqlDbType.Int).Value = dtr.Item("NIDREPASTECHUNIQUE")
                    sqlcmd.Parameters.Add("@p_NMONTANTGD", SqlDbType.Int).Value = oFrmSaisieMttGD.NVALGD

                    sqlcmd.ExecuteNonQuery()

                End If

                oFraisJourSyntheseGD.LoadFraisJourSynthGD()

                GCFraisJourSyntheseGD.DataSource = oFraisJourSyntheseGD.dtSyntheseFraisJourGD

                BGFraisJourSyntheseGD.TopRowIndex = iPos
                BGFraisJourSyntheseGD.FocusedRowHandle = e.RowHandle

            End If

        ElseIf e.Column.FieldName = "VCOMMREPAS" Then

            'If dtr.Item("VTYPEREPAS") = "GD" Then

            'si visa deja deposer alors exit
            If Not dtr.Item("DVISAGD") Is DBNull.Value Then Exit Sub

            'update référence paie dans tsynchrorepastech
            Dim sRefPaie As String = InputBox(My.Resources.SaisieFrais_frmValidationGDReceive_saisie_ref, My.Resources.SaisieFrais_frmValidationGDReceive_ref, dtr.Item("VCOMMREPAS").ToString)

            If sRefPaie <> "" Then

                If sRefPaie.Length > 100 Then
                    MessageBox.Show(My.Resources.SaisieFrais_frmValidationGDReceive_msg6, My.Resources.SaisieFrais_frmValidationGDReceive_erreur, MessageBoxButtons.OK, MessageBoxIcon.Error)
                Else

          sqlcmd = New SqlCommand("api_sp_FraisJourUpdateGDReFPaie", MozartDatabase.cnxMozart)
          sqlcmd.CommandType = CommandType.StoredProcedure
                    sqlcmd.Parameters.Add("@p_NIDREPASTECHUNIQUE", SqlDbType.Int).Value = dtr.Item("NIDREPASTECHUNIQUE")
                    sqlcmd.Parameters.Add("@p_NIDKMSTECHUNIQUE", SqlDbType.Int).Value = dtr.Item("NIDKMSTECHUNIQUE")
                    sqlcmd.Parameters.Add("@p_VCOMMREPAS", SqlDbType.VarChar).Value = sRefPaie

                    sqlcmd.ExecuteNonQuery()

                End If

                oFraisJourSyntheseGD.LoadFraisJourSynthGD()

                GCFraisJourSyntheseGD.DataSource = oFraisJourSyntheseGD.dtSyntheseFraisJourGD

                BGFraisJourSyntheseGD.TopRowIndex = iPos
                BGFraisJourSyntheseGD.FocusedRowHandle = e.RowHandle

            Else

                MessageBox.Show(My.Resources.SaisieFrais_frmValidationGDReceive_obli, My.Resources.Global_Information, MessageBoxButtons.OK, MessageBoxIcon.Error)

            End If

            'End If

        End If

	End Sub

    Private Sub DateEditChoixSem_CustomDisplayText(sender As Object, e As DevExpress.XtraEditors.Controls.CustomDisplayTextEventArgs) Handles DateEditChoixSem.CustomDisplayText

        Dim MyDateEdit As DevExpress.XtraEditors.DateEdit = TryCast(sender, DevExpress.XtraEditors.DateEdit)

        If Not MyDateEdit Is Nothing And Not MyDateEdit.EditValue Is Nothing Then

            e.DisplayText = String.Format(My.Resources.Global_semaine_0_1, WeekNumber(MyDateEdit.EditValue), getFirstDayOfWeek(MyDateEdit.EditValue).ToShortDateString, getFirstDayOfWeek(MyDateEdit.EditValue).AddDays(6).ToShortDateString)

        End If

    End Sub

    Private Sub DateEditChoixSem_EditValueChanged(sender As System.Object, e As System.EventArgs) Handles DateEditChoixSem.EditValueChanged

        If Not GLookUpTech.EditValue Is Nothing AndAlso Not DateEditChoixSem.EditValue Is Nothing Then
            LoadWindow()
        End If

    End Sub

	Private Sub GLookUpTech_EditValueChanged(sender As System.Object, e As System.EventArgs) Handles GLookUpTech.EditValueChanged
		If Not GLookUpTech.EditValue Is Nothing Then
			LoadWindow()
		End If
	End Sub

End Class