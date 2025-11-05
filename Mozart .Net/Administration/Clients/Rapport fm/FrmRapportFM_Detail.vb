Public Class FrmRapportFM_Detail

    Dim _NIDRAPPORT_FM_CLi As Int32
    Dim _NCLINUM As Int32
    Dim _Cancel As Boolean
    Dim oRapportFm As CRapportFM

    Dim iIndexUserCtrl As Int32

    Dim oUsrCtrlPeriode As UCRapportFM_Periode
    Dim oUsrCtrlChoixPeriode As UCRapportFM_ChoixReq
  Dim oUsrCtrlGeneralites As UCRapportFM_Generalites
  Dim oUsrCtrlImagePG As UCRapportFM_ImagePG

    Public ReadOnly Property Cancel As Boolean
        Get
            Cancel = _Cancel
        End Get

    End Property





    Public Sub New(ByVal c_NCLINUM As Int32, ByVal c_NIDRAPPORT_FM_CLi As Int32)

        ' Cet appel est requis par le concepteur.
        InitializeComponent()

        ' Ajoutez une initialisation quelconque après l'appel InitializeComponent().
        _NIDRAPPORT_FM_CLi = c_NIDRAPPORT_FM_CLi
        _NCLINUM = c_NCLINUM
        _Cancel = False

    End Sub


    Private Sub FrmRapportFM_Detail_Load(sender As Object, e As EventArgs) Handles MyBase.Load

        oRapportFm = New CRapportFM(_NCLINUM, _NIDRAPPORT_FM_CLi)

        'on charge tous les user control en respectant l'ordre
        oUsrCtrlPeriode = New UCRapportFM_Periode(oRapportFm)
        oUsrCtrlImagePG = New UCRapportFM_ImagePG(oRapportFm)
        oUsrCtrlChoixPeriode = New UCRapportFM_ChoixReq(oRapportFm)
    oUsrCtrlGeneralites = New UCRapportFM_Generalites(oRapportFm)

    PanelMaster.Controls.Add(oUsrCtrlPeriode)
        PanelMaster.Controls.Add(oUsrCtrlImagePG)
        PanelMaster.Controls.Add(oUsrCtrlChoixPeriode)
        PanelMaster.Controls.Add(oUsrCtrlGeneralites)

        'chargement des donness du prospect
        'If _NIDRAPPORT_FM_CLi > 0 Then LoadDefaultProsp()

        iIndexUserCtrl = 0
        VisibleUserCtrl(iIndexUserCtrl)


    End Sub

    Private Sub BtnCancel_Click(sender As Object, e As EventArgs) Handles BtnCancel.Click

        _Cancel = True
        Me.Close()

    End Sub

    Private Sub VisibleUserCtrl(ByVal p_iIndexVisible As Int32)

        Dim i As Int32 = 0

        For Each oUserCtrlVisible As Control In PanelMaster.Controls

            If p_iIndexVisible = i Then
                oUserCtrlVisible.Visible = True
            Else
                oUserCtrlVisible.Visible = False
            End If
            i = i + 1

        Next

        'champ focus par défaut
        Select Case p_iIndexVisible

            Case 1
                'oUsrCtrlInfoClient.TxtCliNom.Focus()
            Case 2
                'oUsrCtrlContactClient.CboCCLCiv.Focus()
            Case 3
                'oUsrCtrlRSFFactuClient.TxtRSFNom.Focus()


        End Select

    End Sub

    Private Sub BtnNext_Click(sender As Object, e As EventArgs) Handles BtnNext.Click

    If VerifSaisieChamp(1) = False Then Exit Sub

    'on saivegarde la langue
    If iIndexUserCtrl = 0 Then oRapportFm.sLangue = oUsrCtrlPeriode.CboLangue.SelectedValue

    iIndexUserCtrl = iIndexUserCtrl + 1
        If iIndexUserCtrl >= PanelMaster.Controls.Count - 1 Then
            BtnLast.Visible = True
            BtnNext.Visible = False
            BtnFinish.Visible = True
        Else
            BtnLast.Visible = True
            BtnNext.Visible = True
            BtnFinish.Visible = False
        End If
        SetDefaultData(1)
        VisibleUserCtrl(iIndexUserCtrl)

    End Sub

    Private Sub BtnLast_Click(sender As Object, e As EventArgs) Handles BtnLast.Click

    If VerifSaisieChamp(-1) = False Then Exit Sub

    iIndexUserCtrl = iIndexUserCtrl - 1
        If iIndexUserCtrl <= 0 Then
            BtnLast.Visible = False
            BtnNext.Visible = True
            BtnFinish.Visible = False
        Else
            BtnLast.Visible = True
            BtnNext.Visible = True
            BtnFinish.Visible = False
        End If
        SetDefaultData(-1)
        VisibleUserCtrl(iIndexUserCtrl)

    End Sub

    Private Function VerifSaisieChamp(ByVal p_LASTNEXT As Int16) As Boolean

        Dim bOK As Boolean = True

        If p_LASTNEXT = 1 Then

            Select Case iIndexUserCtrl

                Case 0 'période
                Case 1 'choix requete
                Case 2 'genrealites

            End Select

        End If

        Return bOK

    End Function

    Private Sub SetDefaultData(ByVal p_LASTNEXT As Int16)

        Dim bOK As Boolean = True

        'NEXT
        If p_LASTNEXT = 1 Then

            Select Case iIndexUserCtrl

                Case 0 'période
                Case 1 'choix requete
                Case 2 'genrealites

            End Select

            'LAST
        ElseIf p_LASTNEXT = -1 Then

            Select Case iIndexUserCtrl

                Case 0 'période
                Case 1 'choix requete
                Case 2 'genrealites

            End Select

        End If



    End Sub

    Private Sub BtnFinish_Click(sender As Object, e As EventArgs) Handles BtnFinish.Click

        'maj du generalites
        oRapportFm.VRAPPORT_FM_TITLE = oUsrCtrlPeriode.TxtRapportFM_Titre.Text
        oRapportFm.sDateDebut_This = oUsrCtrlPeriode.DTP_Debut.Value
        oRapportFm.sDateFin_This = oUsrCtrlPeriode.DTP_Fin.Value
        oRapportFm.VCHAP_MSG = oUsrCtrlGeneralites.VCHAPMSG
        oRapportFm.sLangue = oUsrCtrlPeriode.CboLangue.SelectedValue
        oRapportFm.iBandeauClient = oUsrCtrlImagePG.PictureEdit_PG.Image
        oRapportFm.bAfficheSite = oUsrCtrlPeriode.ChkAfficheListeSite.Checked

        Me.Cursor = Cursors.WaitCursor

        'sauvegarde
        oRapportFm.SaveRapportFM()
        oRapportFm.SaveRapportFM_Requetes()
        oRapportFm.SaveRapportFM_SitesSelected(oUsrCtrlPeriode.DT_Sites)

    oRapportFm.SaveRapportFM_CompteSelected(oUsrCtrlPeriode.DT_CAN)
    oRapportFm.SaveRapportFM_ContratSelected(oUsrCtrlPeriode.DT_Contrat)

    Me.Cursor = Cursors.Default

        If MessageBox.Show("Le rapport FM a été créé avec succès" & vbCrLf & "Voulez-vous visualiser le rapport FM ?", "Confirmation", MessageBoxButtons.YesNoCancel, MessageBoxIcon.Question) = vbYes Then

            Me.Cursor = Cursors.WaitCursor

            'On reload le rapport fm
            Dim NIDRAPPORT_FM_CLI_SVG As Int32 = oRapportFm.NIDRAPPORT_FM_CLI
            oRapportFm = New CRapportFM(_NCLINUM, NIDRAPPORT_FM_CLI_SVG)

            Me.Cursor = Cursors.WaitCursor

            Dim OGenRaportFMClient As New CRapportFM_Generate(oRapportFm)
            Dim sFileOut As String = OGenRaportFMClient.GenerateRapportFM()

            Me.Cursor = Cursors.Default

            Dim oFrmBrowser As New frmVisuDoc(sFileOut, True, Me.Name, oRapportFm)
            oFrmBrowser.ShowDialog()

        End If

        Me.Close()

    End Sub
End Class