Imports System.Data.SqlClient
Imports DevExpress.XtraGrid.Views.BandedGrid
Imports MozartLib

Public Class frmValidationFraisKMSReceive

  Dim oFraisJourSyntheseSemaine As CFraisKMSValidation

  Dim bArchives As Boolean
  Dim DateDebut As DateTime
  Dim DateFin As DateTime
  Dim iNPERNUM As Int32
  Dim sVPERNOM As String

  Dim dtListeTech As DataTable

  'Public Sub New(ByVal c_NPERNUM As Object)
  Public Sub New()

    ' Cet appel est requis par le concepteur.
    InitializeComponent()

    ' Ajoutez une initialisation quelconque après l'appel InitializeComponent().
    'iNPERNUM = Convert.ToInt32(c_NPERNUM)

  End Sub

  Private Sub frmValidationFraisKMSReceive_Load(sender As System.Object, e As System.EventArgs) Handles MyBase.Load


    'init
    BGColNKMSDEPART.Caption = BGColNKMSDEPART.Caption & vbCrLf & My.Resources.SaisieFrais_frmValidationFraisKMSReceive_kms
    BGColNKMSARRIVEE.Caption = BGColNKMSARRIVEE.Caption & vbCrLf & My.Resources.SaisieFrais_frmValidationFraisKMSReceive_kms
    BGColNKMSPARCOURS.Caption = BGColNKMSPARCOURS.Caption & vbCrLf & My.Resources.SaisieFrais_frmValidationFraisKMSReceive_kms

    'LblNomTech.Text = NomTech(iNPERNUM)

    oFraisJourSyntheseSemaine = New CFraisKMSValidation

    'ouverture sur la semaine en cours en archives
    DateEditChoixSem.EditValue = Now.Date
    bArchives = False

    LoadCboTech()

    LoadWindow()

  End Sub

  Private Sub LoadCboTech()
    Dim sSql As String

    'on charge la combo tech
    dtListeTech = New DataTable

    sSql = "SELECT DISTINCT TPER.NPERNUM,TPER.VPERNOM, TPER.VPERPRE FROM TSYNCHROFRAISJOUR LEFT OUTER JOIN " _
     & "TPER ON TPER.NPERNUM = TSYNCHROFRAISJOUR.NPERNUM LEFT OUTER JOIN " _
     & "TSYNCHROKMSTECH ON TSYNCHROKMSTECH.NIDFRAISJOURSERVER = TSYNCHROFRAISJOUR.NIDFRAISJOURSERVER LEFT OUTER JOIN " _
     & "TSYNCHROREPASTECH ON TSYNCHROREPASTECH.NIDFRAISJOURSERVER = TSYNCHROFRAISJOUR.NIDFRAISJOURSERVER LEFT OUTER JOIN " _
     & "TPER TPERVISAFRAIS ON TPERVISAFRAIS.NPERNUM = TSYNCHROFRAISJOUR.NQUIVISAFRAIS " _
     & "WHERE TSYNCHROFRAISJOUR.DVISAFRAIS IS " & IIf(bArchives, "NOT", "") & " NULL AND TPER.VSOCIETE = App_Name() ORDER BY  VPERNOM, VPERPRE"

    'Dim sqlcmdListTech As New SqlCommand("SELECT NPERNUM, VPERNOM + ' ' + VPERPRE AS VPERNOM FROM TPER WHERE VSOCIETE = App_Name() AND CPERACTIF = 'O' AND CPERTYP <> 'CA' ORDER BY  VPERNOM, VPERPRE", cnx)
    Dim sqlcmdListTech As New SqlCommand(sSql, MozartDatabase.cnxMozart)
    sqlcmdListTech.CommandType = CommandType.Text
		dtListeTech.Load(sqlcmdListTech.ExecuteReader)

		GLookUpTech.Properties.DataSource = dtListeTech

	End Sub



	Private Sub BGFraisJourSyntheseSem_CellMerge(sender As Object, e As DevExpress.XtraGrid.Views.Grid.CellMergeEventArgs) Handles BGFraisJourSyntheseSem.CellMerge

		'colonne Technicien
		If e.Column.FieldName = "VPERNOMTECH" Then

			Dim value1 As String = BGFraisJourSyntheseSem.GetRowCellValue(e.RowHandle1, e.Column).ToString
			Dim value2 As String = BGFraisJourSyntheseSem.GetRowCellValue(e.RowHandle2, e.Column).ToString

			If value1 = value2 Then
				e.Merge = True
				e.Handled = True
			End If

		End If

		'colonne Véhicule
		If e.Column.FieldName = "VVEHTECH" Then

			Dim sNomVeh1 As String = BGFraisJourSyntheseSem.GetRowCellValue(e.RowHandle1, BGColDFRAISJOUR).ToString
			Dim sNomVeh2 As String = BGFraisJourSyntheseSem.GetRowCellValue(e.RowHandle2, BGColDFRAISJOUR).ToString

			If sNomVeh1 <> sNomVeh2 Then
				e.Merge = False
				e.Handled = True
				Exit Sub
			End If

			Dim value1 As String = BGFraisJourSyntheseSem.GetRowCellValue(e.RowHandle1, e.Column).ToString
			Dim value2 As String = BGFraisJourSyntheseSem.GetRowCellValue(e.RowHandle2, e.Column).ToString

			If value1 = value2 Then
				e.Merge = True
				e.Handled = True
			End If

		End If

		''colonne client
		If e.Column.FieldName = "VCLINOM" Then

			Dim sDate1 As String = BGFraisJourSyntheseSem.GetRowCellValue(e.RowHandle1, BGColDFRAISJOUR).ToString
			Dim sDate2 As String = BGFraisJourSyntheseSem.GetRowCellValue(e.RowHandle2, BGColDFRAISJOUR).ToString

			If sDate1 <> sDate2 Then
				e.Merge = False
				e.Handled = True
				Exit Sub
			End If

			Dim value1 As String = BGFraisJourSyntheseSem.GetRowCellValue(e.RowHandle1, e.Column).ToString
			Dim value2 As String = BGFraisJourSyntheseSem.GetRowCellValue(e.RowHandle2, e.Column).ToString

			If value1 = value2 Then
				e.Merge = True
				e.Handled = True
			End If

		End If

		'colonne site
		If e.Column.FieldName = "VSITNOM" Then

			Dim sNomClient1 As String = BGFraisJourSyntheseSem.GetRowCellValue(e.RowHandle1, BGColVCLINOM).ToString
			Dim sNomClient2 As String = BGFraisJourSyntheseSem.GetRowCellValue(e.RowHandle2, BGColVCLINOM).ToString

			If sNomClient1 <> sNomClient2 Then
				e.Merge = False
				e.Handled = True
				Exit Sub
			End If

			Dim value1 As String = BGFraisJourSyntheseSem.GetRowCellValue(e.RowHandle1, e.Column).ToString
			Dim value2 As String = BGFraisJourSyntheseSem.GetRowCellValue(e.RowHandle2, e.Column).ToString

			If value1 = value2 Then
				e.Merge = True
				e.Handled = True
			End If
		End If

		'colonne repas/GD et Etat
		If e.Column.FieldName = "VTYPEREPASDETAIL" Or e.Column.FieldName = "VISAFRAIS" Then

			Dim DateJour1 As String = BGFraisJourSyntheseSem.GetRowCellValue(e.RowHandle1, BGColDFRAISJOUR).ToString
			Dim DateJour2 As String = BGFraisJourSyntheseSem.GetRowCellValue(e.RowHandle2, BGColDFRAISJOUR).ToString

			If DateJour1 <> DateJour2 Then
				e.Merge = False
				e.Handled = True
				Exit Sub
			End If

			Dim value1 As String = BGFraisJourSyntheseSem.GetRowCellValue(e.RowHandle1, e.Column).ToString
			Dim value2 As String = BGFraisJourSyntheseSem.GetRowCellValue(e.RowHandle2, e.Column).ToString

			If value1 = value2 Then
				e.Merge = True
				e.Handled = True
			End If

		End If

	End Sub

	Private Sub BtnFermer_Click(sender As System.Object, e As System.EventArgs) Handles BtnFermer.Click
		Me.Close()
	End Sub

	Private Sub LoadWindow()

		If oFraisJourSyntheseSemaine Is Nothing Then Exit Sub

		Select Case bArchives

			Case True

                Me.Text = My.Resources.SaisieFrais_frmValidationFraisKMSReceive_frais_archivés
                Label1.Text = My.Resources.SaisieFrais_frmValidationFraisKMSReceive_frais_archivés

                BtnArchives.Text = My.Resources.Global_en_attente
                'GrpSelectPeriode.Visible = bArchives
                'lblTech.Visible = False
                'GLookUpTech.Visible = False
                lblsem.Visible = True
				DateEditChoixSem.Visible = True

				oFraisJourSyntheseSemaine.bArchives = bArchives

				DateDebut = getFirstDayOfWeek(DateEditChoixSem.EditValue)
				DateFin = DateDebut.AddDays(6)

				oFraisJourSyntheseSemaine.dDateDebut = DateDebut
				oFraisJourSyntheseSemaine.dDateFin = DateFin
				oFraisJourSyntheseSemaine.npernum = If(GLookUpTech.EditValue.ToString = "", 0, GLookUpTech.EditValue)

				oFraisJourSyntheseSemaine.LoadFraisJourSynthSem()

				GCFraisJourSyntheseSem.DataSource = oFraisJourSyntheseSemaine.dtSyntheseFraisJour

			Case Else

                Me.Text = My.Resources.SaisieFrais_frmValidationFraisKMSReceive_frais_validation
                Label1.Text = My.Resources.SaisieFrais_frmValidationFraisKMSReceive_frais_liste

                BtnArchives.Text = My.Resources.Global_archives
                'GrpSelectPeriode.Visible = bArchives

                lblTech.Visible = True
				GLookUpTech.Visible = True
				lblsem.Visible = False
				DateEditChoixSem.Visible = False

				oFraisJourSyntheseSemaine.bArchives = bArchives
				oFraisJourSyntheseSemaine.npernum = If(GLookUpTech.EditValue.ToString = "", 0, GLookUpTech.EditValue)
				oFraisJourSyntheseSemaine.LoadFraisJourSynthSem()
				GCFraisJourSyntheseSem.DataSource = oFraisJourSyntheseSemaine.dtSyntheseFraisJour

		End Select

	End Sub

	Private Sub BGFraisJourSyntheseSem_RowCellClick(sender As Object, e As DevExpress.XtraGrid.Views.Grid.RowCellClickEventArgs) Handles BGFraisJourSyntheseSem.RowCellClick

		If bArchives = True Then Exit Sub

		'pas d action si donnees transferees
		'traitement different selon l'etat
		Dim oBDView As BandedGridView = TryCast(sender, BandedGridView)
		Dim sqlcmd As SqlCommand

		'oBDView.GetSelectedCells(e.RowHandle)
		Dim dtr As DataRow = oBDView.GetDataRow(e.RowHandle)
		Dim iPos As Int32

		iPos = BGFraisJourSyntheseSem.GetVisibleIndex(e.RowHandle)

		If e.Column.FieldName = "VISAFRAIS" Then

			'vous ne pouvez valider ce frais, tant que le montant du gd n'est pas saisi et valider
			If (dtr.Item("VTYPEREPAS") = "GD") Then

				'test si montant gd saisi
				If (dtr.Item("NMONTANTGD") = 0) Then
                    MessageBox.Show(My.Resources.SaisieFrais_frmValidationFraisKMSReceive_warning, My.Resources.Global_Erreur, MessageBoxButtons.OK, MessageBoxIcon.Exclamation)
                    Exit Sub
				End If

			End If

            Select Case MessageBox.Show(My.Resources.SaisieFrais_frmValidationFraisKMSReceive_valider_journé, My.Resources.Global_msg_info, MessageBoxButtons.YesNoCancel, MessageBoxIcon.Exclamation)

                Case Windows.Forms.DialogResult.Yes

          'update datetrans dans tsynchrofraisjour
          sqlcmd = New SqlCommand("[api_sp_FraisJourValidationJournee]", MozartDatabase.cnxMozart)
          sqlcmd.CommandType = CommandType.StoredProcedure
                    sqlcmd.Parameters.Add("@p_NIDFRAISJOURSERVER", SqlDbType.Int).Value = dtr.Item("NIDFRAISJOUR")

                    sqlcmd.ExecuteNonQuery()

                    oFraisJourSyntheseSemaine.LoadFraisJourSynthSem()

                    GCFraisJourSyntheseSem.DataSource = oFraisJourSyntheseSemaine.dtSyntheseFraisJour

            End Select

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

				oFraisJourSyntheseSemaine.LoadFraisJourSynthSem()

				GCFraisJourSyntheseSem.DataSource = oFraisJourSyntheseSemaine.dtSyntheseFraisJour

				BGFraisJourSyntheseSem.TopRowIndex = iPos
				BGFraisJourSyntheseSem.FocusedRowHandle = e.RowHandle

			End If

			'ElseIf e.Column.FieldName = "VISAFRAISGD" Then

			'    If dtr.Item("VTYPEREPAS") = "GD" Then

			'        'si visa deja deposer alors exit
			'        If Not dtr.Item("DVISAGD") Is DBNull.Value Then Exit Sub

			'        'on verifie si montant saisi
			'        If dtr.Item("NMONTANTGD") <= 0 Then
			'            MessageBox.Show("Vous ne pouvez pas valider ce GD, le montant du GD n'est pas saisi", "Erreur", MessageBoxButtons.OK, MessageBoxIcon.Exclamation)
			'            Exit Sub
			'        End If

			'        Select Case MessageBox.Show("Valider ce GD ?", "Message information", MessageBoxButtons.YesNoCancel, MessageBoxIcon.Exclamation)

			'            Case Windows.Forms.DialogResult.Yes

			'                'update montant GD dans tsynchrorepastech
			'                sqlcmd = New SqlCommand("api_sp_FraisJourUpdateVISAFRAISGD", cnx)
			'                sqlcmd.CommandType = CommandType.StoredProcedure
			'                sqlcmd.Parameters.Add("@p_NIDREPASTECHUNIQUE", SqlDbType.Int).Value = dtr.Item("NIDREPASTECHUNIQUE")

			'                sqlcmd.ExecuteNonQuery()

			'                oFraisJourSyntheseSemaine.LoadFraisJourSynthSem()

			'                GCFraisJourSyntheseSem.DataSource = oFraisJourSyntheseSemaine.dtSyntheseFraisJour

			'                BGFraisJourSyntheseSem.TopRowIndex = iPos
			'                BGFraisJourSyntheseSem.FocusedRowHandle = e.RowHandle

			'        End Select

			'End If

		End If

	End Sub

	Private Sub BtnArchives_Click(sender As System.Object, e As System.EventArgs) Handles BtnArchives.Click

		bArchives = Not bArchives
		LoadCboTech()
		LoadWindow()

	End Sub

	Private Sub GLookUpTech_EditValueChanged(sender As System.Object, e As System.EventArgs) Handles GLookUpTech.EditValueChanged

		If Not GLookUpTech.EditValue Is Nothing Then LoadWindow()

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



End Class