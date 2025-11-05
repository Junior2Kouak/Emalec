Imports System.Data.SqlClient
Imports DevExpress.XtraEditors.Controls
Imports MozartLib

Public Class frmPlanifAuto_Creation


  Dim _DtJourSemaine As DataTable
  Dim _DtListeSemainesTolerance As DataTable
  Dim _DtListeTechniciens As DataTable
  Dim _TypeDate As String

  Dim _bReadOnly As Boolean

  Dim _oCPLAAUTO As CPLAAUTO

  Friend dtListesActionsCoche As DataTable

  Public Sub New(ByVal c_oCPLAAUTO As CPLAAUTO, ByVal c_bReadOnly As Boolean)

    ' Cet appel est requis par le concepteur.
    InitializeComponent()

    ' Ajoutez une initialisation quelconque après l'appel InitializeComponent().
    _oCPLAAUTO = c_oCPLAAUTO
    _bReadOnly = c_bReadOnly

  End Sub

  Private Sub frmPlanifAuto_Creation_Load(sender As Object, e As EventArgs) Handles MyBase.Load

    Initboutons(Me)

    'init
    ChkJ_Forbid_NO.Checked = True
    ChkPaveBloc_NO.Checked = True
    Cal_Adder.SetDate(Now.Date)

    If _bReadOnly = True Or _oCPLAAUTO.CPLA_AUTO_ETAT <> "A" Then

      Me.Text = Me.Text & " (Lecture seule)"

      BtnAddDateP_Debut.Visible = False
      BtnDelDateP_Debut.Visible = False
      BtnAddDateP_Fin.Visible = False
      BtnDelDateP_Fin.Visible = False

      Chk_P_Pla_DateS.Enabled = False
      Chk_P_Pla_DateS_With_Tol.Enabled = False
      CboDateS_Tolerance.Enabled = False

      ChkJ_Forbid_YES.Enabled = False
      ChkJ_Forbid_NO.Enabled = False
      ChkListJourSem.Enabled = False

      Chk_PlaAuto_AllTechs.Enabled = False
      Chk_PlaAuto_OneTech.Enabled = False
      CboTechs.Enabled = False

      ChkPaveBloc_YES.Enabled = False
      ChkPaveBloc_NO.Enabled = False
      Txt_PaveBloc_Text.ReadOnly = True

      BtnValider.Visible = False

    End If

    LoadData()

  End Sub

  Private Sub LoadData()

    'liste jour semaine
    _DtJourSemaine = New DataTable

    Dim sqlcmd As New SqlCommand("[api_sp_ListeJour_By_Name]", MozartDatabase.cnxMozart)
    sqlcmd.CommandType = CommandType.StoredProcedure

        _DtJourSemaine.Load(sqlcmd.ExecuteReader)

        ChkListJourSem.DataSource = _DtJourSemaine

        'ListeSsemaines tolerance
        _DtListeSemainesTolerance = New DataTable

    sqlcmd = New SqlCommand("[api_sp_Planif_Auto_ListeSemainesTolerance]", MozartDatabase.cnxMozart)
    sqlcmd.CommandType = CommandType.StoredProcedure

        _DtListeSemainesTolerance.Load(sqlcmd.ExecuteReader)

        CboDateS_Tolerance.DataSource = _DtListeSemainesTolerance

        'Liste techniciens
        _DtListeTechniciens = New DataTable

    sqlcmd = New SqlCommand("[api_sp_ListeTechniciensActifsForCBO]", MozartDatabase.cnxMozart)
    sqlcmd.CommandType = CommandType.StoredProcedure
        sqlcmd.Parameters.Add("@P_NPERNUM", SqlDbType.Int).Value = 0

        _DtListeTechniciens.Load(sqlcmd.ExecuteReader)

        CboTechs.DataSource = _DtListeTechniciens

        'chargement des données
        If _oCPLAAUTO IsNot Nothing Then

            Txt_P_Debut.Text = _oCPLAAUTO.DPERIODE_DEBUT.ToString
            Txt_P_Fin.Text = _oCPLAAUTO.DPERIODE_FIN.ToString

            '1 = peridoe
            '2 = date souhaitée 
            '3 = date souhaitée avec tolérance
            Select Case _oCPLAAUTO.NCHOIXPERIODE
                Case 1
                    Chk_P_Pla_DateS.Checked = False
                    Chk_P_Pla_DateS_With_Tol.Checked = False
                Case 2
                    Chk_P_Pla_DateS.Checked = True
                    Chk_P_Pla_DateS_With_Tol.Checked = False
                Case 3
                    Chk_P_Pla_DateS.Checked = False
                    Chk_P_Pla_DateS_With_Tol.Checked = True
                Case Else
                    Chk_P_Pla_DateS.Checked = False
                    Chk_P_Pla_DateS_With_Tol.Checked = False
            End Select

            If _oCPLAAUTO.NPERIODE_TOLERANCE IsNot Nothing Then
                CboDateS_Tolerance.SelectedValue = _oCPLAAUTO.NPERIODE_TOLERANCE
            End If

            Select Case _oCPLAAUTO.BJOUR_FORBIDEN
                Case 0
                    ChkJ_Forbid_YES.Checked = False
                    ChkJ_Forbid_NO.Checked = True
                Case 1
                    ChkJ_Forbid_YES.Checked = True
                    ChkJ_Forbid_NO.Checked = False
                Case Else
                    ChkJ_Forbid_YES.Checked = False
                    ChkJ_Forbid_NO.Checked = False
            End Select

            If _oCPLAAUTO.VJOUR_FORBIDEN_LIST <> "" Then

                For Each nJour As Int16 In _oCPLAAUTO.VJOUR_FORBIDEN_LIST.Split(";")

                    For ItemJ As Int16 = 0 To ChkListJourSem.ItemCount - 1 Step 1

                        If Convert.ToInt16(ChkListJourSem.GetItemValue(ItemJ)) = nJour Then
                            ChkListJourSem.SetItemChecked(ItemJ, True)
                        End If

                    Next

                Next

            End If

            Chk_PlaAuto_AllTechs.Checked = _oCPLAAUTO.BTECH_COMPET

            Chk_PlaAuto_OneTech.Checked = _oCPLAAUTO.BTECH_UNIQUE

            CboTechs.SelectedValue = _oCPLAAUTO.NPERNUM_TECH_UNIQUE

            Select Case _oCPLAAUTO.BBLOC_PAVE
                Case 0
                    ChkPaveBloc_YES.Checked = False
                    ChkPaveBloc_NO.Checked = True
                Case 1
                    ChkPaveBloc_YES.Checked = True
                    ChkPaveBloc_NO.Checked = False
                Case Else
                    ChkPaveBloc_YES.Checked = False
                    ChkPaveBloc_NO.Checked = False
            End Select

            Txt_PaveBloc_Text.Text = _oCPLAAUTO.VBLOCPAVE_LABEL


        End If

    End Sub

    Private Sub ChkListJourSem_SelectedIndexChanged(sender As Object, e As EventArgs) Handles ChkListJourSem.SelectedIndexChanged

        'on teste si checked jour interdit est à non


    End Sub

    Private Sub ChkJ_Forbid_NO_CheckedChanged(sender As Object, e As EventArgs) Handles ChkJ_Forbid_NO.CheckedChanged

        If ChkJ_Forbid_NO.CheckState = CheckState.Checked Then
            If ChkJ_Forbid_YES.CheckState = CheckState.Checked Then ChkJ_Forbid_YES.CheckState = CheckState.Unchecked
            ChkListJourSem.Visible = False
        ElseIf ChkJ_Forbid_NO.CheckState = CheckState.Unchecked And ChkJ_Forbid_YES.CheckState = CheckState.Unchecked Then
            ChkListJourSem.Visible = False
        End If

    End Sub

    Private Sub ChkJ_Forbid_YES_CheckedChanged(sender As Object, e As EventArgs) Handles ChkJ_Forbid_YES.CheckedChanged

        If ChkJ_Forbid_YES.CheckState = CheckState.Checked Then

            If ChkJ_Forbid_NO.CheckState = CheckState.Checked Then ChkJ_Forbid_NO.CheckState = CheckState.Unchecked
            ChkListJourSem.Visible = True
        Else
            ChkListJourSem.Visible = False
        End If

    End Sub

    Private Sub BtnClose_Click(sender As Object, e As EventArgs) Handles BtnClose.Click
        Me.Close()
    End Sub

    Private Sub BtnValider_Click(sender As Object, e As EventArgs) Handles BtnValider.Click

        'on save
        If _oCPLAAUTO IsNot Nothing Then

            Dim bReadyToTraite As Boolean = ReadyToTraite()

            'teste si tous les criteres sont saisies
            If bReadyToTraite = False Then
                If MessageBox.Show("La demande de planification automatique n'est pas complète pour qu'elle puisse être traitée." & vbCrLf & "Voulez-vous tout de même enregistrer ?", "Confirmation", MessageBoxButtons.YesNoCancel, MessageBoxIcon.Exclamation) <> DialogResult.Yes Then
                    Return
                End If
            End If

            If (Txt_P_Debut.Text = "") Then
                _oCPLAAUTO.DPERIODE_DEBUT = Nothing
            Else
                _oCPLAAUTO.DPERIODE_DEBUT = Convert.ToDateTime(Txt_P_Debut.Text)
            End If

            If (Txt_P_Fin.Text = "") Then
                _oCPLAAUTO.DPERIODE_FIN = Nothing
            Else
                _oCPLAAUTO.DPERIODE_FIN = Convert.ToDateTime(Txt_P_Fin.Text)
            End If

            '1 = periode
            '2 = date souhaitée 
            '3 = date souhaitée avec tolérance

            If (Txt_P_Debut.Text = "" Or Txt_P_Debut.Text = "") And Chk_P_Pla_DateS.Checked = False And Chk_P_Pla_DateS_With_Tol.Checked = False Then
                _oCPLAAUTO.NCHOIXPERIODE = 0
            ElseIf (Txt_P_Debut.Text <> "" Or Txt_P_Debut.Text <> "") And Chk_P_Pla_DateS.Checked = False And Chk_P_Pla_DateS_With_Tol.Checked = False Then
                _oCPLAAUTO.NCHOIXPERIODE = 1
            ElseIf (Txt_P_Debut.Text = "" Or Txt_P_Debut.Text = "") And Chk_P_Pla_DateS.Checked = True And Chk_P_Pla_DateS_With_Tol.Checked = False Then
                _oCPLAAUTO.NCHOIXPERIODE = 2
            ElseIf (Txt_P_Debut.Text = "" Or Txt_P_Debut.Text = "") And Chk_P_Pla_DateS.Checked = False And Chk_P_Pla_DateS_With_Tol.Checked = True Then
                _oCPLAAUTO.NCHOIXPERIODE = 3
            ElseIf (Txt_P_Debut.Text = "" Or Txt_P_Debut.Text = "") And Chk_P_Pla_DateS.Checked = False And Chk_P_Pla_DateS_With_Tol.Checked = False Then
                _oCPLAAUTO.NCHOIXPERIODE = 0
            End If

            If Chk_P_Pla_DateS_With_Tol.Checked = True Then
                _oCPLAAUTO.NPERIODE_TOLERANCE = CboDateS_Tolerance.SelectedValue
            Else
                _oCPLAAUTO.NPERIODE_TOLERANCE = 0
            End If

            If ChkJ_Forbid_YES.Checked = False And ChkJ_Forbid_NO.Checked = False Then
                _oCPLAAUTO.BJOUR_FORBIDEN = Nothing
            ElseIf ChkJ_Forbid_YES.Checked = True And ChkJ_Forbid_NO.Checked = False Then
                _oCPLAAUTO.BJOUR_FORBIDEN = True
            ElseIf ChkJ_Forbid_YES.Checked = False And ChkJ_Forbid_NO.Checked = True Then
                _oCPLAAUTO.BJOUR_FORBIDEN = False
            End If

            If ChkJ_Forbid_YES.Checked = True And ChkListJourSem.CheckedItems.Count > 0 Then

                Dim sListJourToSave As String = ""

                For Each oitem As Object In ChkListJourSem.CheckedItems

                    Dim row As DataRowView = TryCast(oitem, DataRowView)
                    If sListJourToSave = "" Then
                        sListJourToSave = row.Item(ChkListJourSem.ValueMember)
                    Else
                        sListJourToSave = sListJourToSave & ";" & row.Item(ChkListJourSem.ValueMember)
                    End If

                Next

                _oCPLAAUTO.VJOUR_FORBIDEN_LIST = sListJourToSave

            Else

                _oCPLAAUTO.VJOUR_FORBIDEN_LIST = ""

            End If

            _oCPLAAUTO.BTECH_COMPET = If(Chk_PlaAuto_AllTechs.Checked = True, 1, 0)

            _oCPLAAUTO.BTECH_UNIQUE = If(Chk_PlaAuto_OneTech.Checked = True, 1, 0)

            If (Chk_PlaAuto_OneTech.Checked = True) Then
                _oCPLAAUTO.NPERNUM_TECH_UNIQUE = CboTechs.SelectedValue
            Else
                _oCPLAAUTO.NPERNUM_TECH_UNIQUE = 0
            End If

            If ChkJ_Forbid_YES.Checked = False And ChkJ_Forbid_NO.Checked = False Then
                _oCPLAAUTO.BJOUR_FORBIDEN = Nothing
            ElseIf ChkJ_Forbid_YES.Checked = True And ChkJ_Forbid_NO.Checked = False Then
                _oCPLAAUTO.BJOUR_FORBIDEN = True
            ElseIf ChkJ_Forbid_YES.Checked = False And ChkJ_Forbid_NO.Checked = True Then
                _oCPLAAUTO.BJOUR_FORBIDEN = False
            End If

            '_oCPLAAUTO.BBLOC_PAVE
            If ChkPaveBloc_YES.Checked = False And ChkPaveBloc_NO.Checked = False Then
                _oCPLAAUTO.BBLOC_PAVE = Nothing
            ElseIf ChkPaveBloc_YES.Checked = True And ChkPaveBloc_NO.Checked = False Then
                _oCPLAAUTO.BBLOC_PAVE = True
            ElseIf ChkPaveBloc_YES.Checked = False And ChkPaveBloc_NO.Checked = True Then
                _oCPLAAUTO.BBLOC_PAVE = False
            End If

            If ChkPaveBloc_YES.Checked = True Then
                _oCPLAAUTO.VBLOCPAVE_LABEL = Txt_PaveBloc_Text.Text
            Else
                _oCPLAAUTO.VBLOCPAVE_LABEL = ""
            End If

            _oCPLAAUTO.SaveData()

            'sauvegarde des actions
            'si actions coché n'existe pas dans la liste des actions chargées, alors on insert
            If dtListesActionsCoche IsNot Nothing Then

                For Each drCoche As DataRow In dtListesActionsCoche.Rows

                    If _oCPLAAUTO.DTPLA_AUTO_ACT.Select("[NACTNUM] = " & drCoche.Item("NACTNUM") & " AND [NPLA_AUTO_ID] = " & _oCPLAAUTO.NPLA_AUTO_ID).Length = 0 Then

                        'on insert
                        _oCPLAAUTO.AddActionInPlaAuto(drCoche.Item("NACTNUM"))

                    End If
                Next

                'si action chargés n'existe pas dans la liste des actions cochées alors on supprime
                For Each drLoaded As DataRow In _oCPLAAUTO.DTPLA_AUTO_ACT.Rows

                    If dtListesActionsCoche.Select("[NACTNUM] = " & drLoaded.Item("NACTNUM")).Length = 0 Then

                        'on delete
                        _oCPLAAUTO.DeleteActionInPlaAuto(drLoaded.Item("NACTNUM"))


                    End If
                Next

                'demande de finalisation seulement si etat en attente
                If _oCPLAAUTO.CPLA_AUTO_ETAT = "A" And bReadyToTraite = True AndAlso MessageBox.Show("Voulez-vous lancer la PREVISUALISATION du traitement ?" & vbCrLf & "A la fin du traitement, vous pourrez valider le traitement pour la planification définitive.", "Confirmation", MessageBoxButtons.YesNoCancel, MessageBoxIcon.Question) = DialogResult.Yes Then

                    'save etat de la demande
                    'on teste si toutes les informations sont prete pour le traitement de la planif auto
                    'passage de A -> P
                    _oCPLAAUTO.SaveEtatToReadyToTraite()

                    'on lance le traitement


                End If

            End If

            _oCPLAAUTO.RefreshData()

        End If

    End Sub

    Private Sub BtnAddDateP_Debut_Click(sender As Object, e As EventArgs) Handles BtnAddDateP_Debut.Click

        If Chk_P_Pla_DateS.CheckState = CheckState.Checked Then

            MessageBox.Show("Vous ne pouvez pas saisir de période car vous avez déjà coché la planification sur la date souhaitée", "Erreur", MessageBoxButtons.OK, MessageBoxIcon.Exclamation)

            Return

        End If

        If Chk_P_Pla_DateS_With_Tol.CheckState = CheckState.Checked Then

            MessageBox.Show("Vous ne pouvez pas saisir de période car vous avez déjà coché la planification sur la date souhaitée avec tolérance", "Erreur", MessageBoxButtons.OK, MessageBoxIcon.Exclamation)

            Return

        End If

        _TypeDate = "DB"
        Cal_Adder.Visible = True

    End Sub

    Private Sub BtnAddDateP_Fin_Click(sender As Object, e As EventArgs) Handles BtnAddDateP_Fin.Click

        If Chk_P_Pla_DateS.CheckState = CheckState.Checked Then

            MessageBox.Show("Vous ne pouvez pas saisir de période car vous avez déjà coché la planification sur la date souhaitée", "Erreur", MessageBoxButtons.OK, MessageBoxIcon.Exclamation)

            Return

        End If

        If Chk_P_Pla_DateS_With_Tol.CheckState = CheckState.Checked Then

            MessageBox.Show("Vous ne pouvez pas saisir de période car vous avez déjà coché la planification sur la date souhaitée avec tolérance", "Erreur", MessageBoxButtons.OK, MessageBoxIcon.Exclamation)

            Return

        End If

        _TypeDate = "DF"
        Cal_Adder.Visible = True
    End Sub

    Private Sub Cal_Adder_DateSelected(sender As Object, e As DateRangeEventArgs) Handles Cal_Adder.DateSelected

        If e.Start.Date < Now.Date Then

            MessageBox.Show("La date sélectionnée ne peut pas être antérieure la date d'aujourd'hui", "Erreur", MessageBoxButtons.OK, MessageBoxIcon.Exclamation)
            Cal_Adder.Visible = False
            Return

        End If

        Select Case _TypeDate
            Case "DB"

                'test si date inférieur
                If Txt_P_Fin.Text <> "" AndAlso e.Start.Date > Convert.ToDateTime(Txt_P_Fin.Text) Then

                    MessageBox.Show("La date de début sélectionnée ne peut pas être supérieure à la date de fin de période", "Erreur", MessageBoxButtons.OK, MessageBoxIcon.Exclamation)
                    Cal_Adder.Visible = False
                    Return

                End If

                Txt_P_Debut.Text = e.Start.Date.ToShortDateString
            Case "DF"

                'test si date inférieur
                If Txt_P_Debut.Text <> "" AndAlso e.Start.Date < Convert.ToDateTime(Txt_P_Debut.Text) Then

                    MessageBox.Show("La date de fin sélectionnée ne peut pas être antérieure à la date de début de période", "Erreur", MessageBoxButtons.OK, MessageBoxIcon.Exclamation)
                    Cal_Adder.Visible = False
                    Return

                End If

                Txt_P_Fin.Text = e.Start.Date.ToShortDateString
        End Select
        Cal_Adder.Visible = False

    End Sub

    Private Sub BtnDelDateP_Debut_Click(sender As Object, e As EventArgs) Handles BtnDelDateP_Debut.Click

        Txt_P_Debut.Text = ""

    End Sub

    Private Sub BtnDelDateP_Fin_Click(sender As Object, e As EventArgs) Handles BtnDelDateP_Fin.Click

        Txt_P_Fin.Text = ""

    End Sub

    Private Sub Chk_P_Pla_DateS_CheckedChanged(sender As Object, e As EventArgs) Handles Chk_P_Pla_DateS.CheckedChanged

        If Chk_P_Pla_DateS.CheckState = CheckState.Checked And (Txt_P_Debut.Text <> "" Or Txt_P_Fin.Text <> "") Then

            MessageBox.Show("Vous ne pouvez pas définir la planification sur la date souhaitée car vous avez déjà saisi une période", "Erreur", MessageBoxButtons.OK, MessageBoxIcon.Exclamation)
            Chk_P_Pla_DateS.CheckState = CheckState.Unchecked
            Return

        End If

        If Chk_P_Pla_DateS.CheckState = CheckState.Checked And Chk_P_Pla_DateS_With_Tol.CheckState = CheckState.Checked Then

            MessageBox.Show("Vous ne pouvez pas définir la planification sur la date souhaitée car vous avez déjà coché la planification sur la date souhaitée avec tolérance", "Erreur", MessageBoxButtons.OK, MessageBoxIcon.Exclamation)
            Chk_P_Pla_DateS.CheckState = CheckState.Unchecked
            Return

        End If

        'si planif sur date souhaitée alors on ne peut sélectionner qu'un seul technicien
        If Chk_P_Pla_DateS.CheckState = CheckState.Checked And Chk_PlaAuto_AllTechs.CheckState = True Then
            'vous ne pouvez pas sélectionner la planification sur la date souhaitée au jour J car il faut sélectionner obligatoirement un seul technicien
            MessageBox.Show("Vous ne pouvez pas sélectionner la planification sur la date souhaitée au jour J car il faut obligatoirement sélectionner un seul technicien", "Erreur", MessageBoxButtons.OK, MessageBoxIcon.Exclamation)
            Chk_P_Pla_DateS.CheckState = CheckState.Unchecked
            Return
        End If


    End Sub

    Private Sub Chk_P_Pla_DateS_With_Tol_CheckedChanged(sender As Object, e As EventArgs) Handles Chk_P_Pla_DateS_With_Tol.CheckedChanged

        If Chk_P_Pla_DateS_With_Tol.CheckState = CheckState.Checked And (Txt_P_Debut.Text <> "" Or Txt_P_Fin.Text <> "") Then

            MessageBox.Show("Vous ne pouvez pas définir la planification sur la date souhaitée car vous avez déjà saisi une période", "Erreur", MessageBoxButtons.OK, MessageBoxIcon.Exclamation)
            Chk_P_Pla_DateS_With_Tol.CheckState = CheckState.Unchecked : CboDateS_Tolerance.Visible = False
            Return

        End If

        If Chk_P_Pla_DateS_With_Tol.CheckState = CheckState.Checked And Chk_P_Pla_DateS.CheckState = CheckState.Checked Then

            MessageBox.Show("Vous ne pouvez pas saisir de période car vous avez déjà coché la planification sur la date souhaitée", "Erreur", MessageBoxButtons.OK, MessageBoxIcon.Exclamation)
            Chk_P_Pla_DateS_With_Tol.CheckState = CheckState.Unchecked : CboDateS_Tolerance.Visible = False
            Return

        End If

        If Chk_P_Pla_DateS_With_Tol.CheckState = CheckState.Checked Then
            CboDateS_Tolerance.Visible = True
        Else
            CboDateS_Tolerance.Visible = False
        End If

    End Sub

    Private Sub ChkPaveBloc_YES_CheckedChanged(sender As Object, e As EventArgs) Handles ChkPaveBloc_YES.CheckedChanged

        If ChkPaveBloc_YES.CheckState = CheckState.Checked Then
            If ChkPaveBloc_NO.CheckState = CheckState.Checked Then ChkPaveBloc_NO.CheckState = CheckState.Unchecked
            Label6.Visible = True
            Txt_PaveBloc_Text.Visible = True
        Else
            Label6.Visible = False
            Txt_PaveBloc_Text.Visible = False
        End If

    End Sub

    Private Sub ChkPaveBloc_NO_CheckedChanged(sender As Object, e As EventArgs) Handles ChkPaveBloc_NO.CheckedChanged

        If ChkPaveBloc_NO.CheckState = CheckState.Checked Then
            If ChkPaveBloc_YES.CheckState = CheckState.Checked Then ChkPaveBloc_YES.CheckState = CheckState.Unchecked
            Label6.Visible = False
            Txt_PaveBloc_Text.Visible = False

        End If

    End Sub

    Private Sub Chk_PlaAuto_OneTech_CheckedChanged(sender As Object, e As EventArgs) Handles Chk_PlaAuto_OneTech.CheckedChanged

        If Chk_PlaAuto_OneTech.CheckState = CheckState.Checked Then
            If Chk_PlaAuto_AllTechs.CheckState = CheckState.Checked Then Chk_PlaAuto_AllTechs.CheckState = CheckState.Unchecked
            CboTechs.Visible = True
        Else
            CboTechs.Visible = False
        End If

    End Sub

    Private Sub Chk_PlaAuto_AllTechs_CheckedChanged(sender As Object, e As EventArgs) Handles Chk_PlaAuto_AllTechs.CheckedChanged

        If Chk_PlaAuto_AllTechs.CheckState = CheckState.Checked Then
            If Chk_PlaAuto_OneTech.CheckState = CheckState.Checked Then Chk_PlaAuto_OneTech.CheckState = CheckState.Unchecked
            CboTechs.Visible = False
        End If

    End Sub

    Private Sub BtnHelp_Click(sender As Object, e As EventArgs) Handles BtnHelp.Click



    End Sub

    'on testesi tous les critères sont renséignés pour finaliser la demande de planif auto
    Private Function ReadyToTraite() As Boolean

        If (Txt_P_Debut.Text = "" Or Txt_P_Fin.Text = "") And Chk_P_Pla_DateS.Checked = False And Chk_P_Pla_DateS_With_Tol.Checked = False Then
            MessageBox.Show("Il faut définir une période.", "Erreur", MessageBoxButtons.OK, MessageBoxIcon.Exclamation)
            Return False
        End If

        If ChkJ_Forbid_YES.Checked = False And ChkJ_Forbid_NO.Checked = False Then
            MessageBox.Show("Il faut définir s'il y a une ou des journée(s) interdites.", "Erreur", MessageBoxButtons.OK, MessageBoxIcon.Exclamation)
            Return False
        End If
        If ChkJ_Forbid_YES.Checked = True And ChkListJourSem.CheckedItemsCount = 0 Then
            MessageBox.Show("Vous avez défini des journées interdites." & vbCrLf & "Il faut sélectionner une ou des journée(s) interdites", "Erreur", MessageBoxButtons.OK, MessageBoxIcon.Exclamation)
            Return False
        End If

        If Chk_P_Pla_DateS.Checked = True And Chk_PlaAuto_OneTech.Checked = False Then
            MessageBox.Show("Pour une planification à la date souhaitée au jour J, il faut obligatoirement  cocher et définir un seul technicien", "Erreur", MessageBoxButtons.OK, MessageBoxIcon.Exclamation)
            Return False
        End If

        If Chk_PlaAuto_AllTechs.Checked = False And Chk_PlaAuto_OneTech.Checked = False Then
            MessageBox.Show("Il faut définir le choix technicien à planifier", "Erreur", MessageBoxButtons.OK, MessageBoxIcon.Exclamation)
            Return False
        End If

        If Chk_PlaAuto_OneTech.Checked = True AndAlso CboTechs.SelectedValue Is Nothing Then
            MessageBox.Show("Vous avez défini un seul technicien." & vbCrLf & "Il faut sélectionner le technicien à planifier.", "Erreur", MessageBoxButtons.OK, MessageBoxIcon.Exclamation)
            Return False
        End If

        If ChkPaveBloc_YES.Checked = False And ChkPaveBloc_NO.Checked = False Then
            MessageBox.Show("Vous n'avez pas défini le blocage pavé.", "Erreur", MessageBoxButtons.OK, MessageBoxIcon.Exclamation)
            Return False
        End If

        Return True

    End Function

End Class