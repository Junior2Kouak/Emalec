Imports System.Data.SqlClient
Imports MozartLib

Public Class frmFicSituDanger_Detail

  Dim _NIDFICSITUDANG_REP As Int32
  Dim _NIDFICSITUDANG_SERVER As Int32
  Dim _NIDFICSITUDANG_SUIVIACT As Int32
  Dim _NACTNUM As Int32
  Dim _NPERNUM As Int32
  Dim oFicheSituDanger As CFICSITUDANG
  Dim oFicheSituDanger_Reponse As CFICSITUDANG_REP
  Dim oFicheSituDanger_SuiviAct As CFICSITUDANG_SUIVIACT

  Dim IsLoading As Boolean

  Public Sub New(ByVal c_NIDFICSITUDANG_SERVER As Int32, ByVal c_NACTNUM As Int32, ByVal c_NPERNUM As Int32, ByVal c_NIDFICSITUDANG_REP As Int32, ByVal c_NIDFICSITUDANG_SUIVIACT As Int32)
    ' Cet appel est requis par le concepteur.
    InitializeComponent()

    ' Ajoutez une initialisation quelconque après l'appel InitializeComponent().
    _NACTNUM = c_NACTNUM
    _NPERNUM = c_NPERNUM
    _NIDFICSITUDANG_SERVER = c_NIDFICSITUDANG_SERVER
    _NIDFICSITUDANG_REP = c_NIDFICSITUDANG_REP
    _NIDFICSITUDANG_SUIVIACT = c_NIDFICSITUDANG_SUIVIACT
  End Sub

    Private Sub frmFicSituDanger_Detail_Load(sender As Object, e As EventArgs) Handles MyBase.Load

        Initboutons(Me)

        IsLoading = True

        LblObjDemarche.Text = "Comprendre les circonstances, évaluer les conséquences et dégager des actions correctives ou préventives."

        LoadDataCboTech()
        LoadDataCboRisque()
        LoaddataFicheTech()
        LoaddataFicheReponse()
        LoaddataFicheSuiviAct()

        IsLoading = False
    End Sub
    Public Sub LoadDataCboTech()

    Dim dtListTech As New DataTable
    Dim sqlcmdLoad As New SqlCommand("[api_sp_ListeTechniciensActifsForCBO]", MozartDatabase.cnxMozart)
    sqlcmdLoad.CommandType = CommandType.StoredProcedure
    sqlcmdLoad.Parameters.Add("@P_NPERNUM", SqlDbType.Int).Value = _NPERNUM
    dtListTech.Load(sqlcmdLoad.ExecuteReader)

    Cbo_FicIntervenant.DataSource = dtListTech

  End Sub

  Public Sub LoadDataCboRisque()

    Dim dtList As New DataTable
    Dim sqlcmdLoad As New SqlCommand("SELECT ID, VLIBRISQUE FROM TREF_TYPERISQUE", MozartDatabase.cnxMozart)
    sqlcmdLoad.CommandType = CommandType.Text
    dtList.Load(sqlcmdLoad.ExecuteReader)

    cboRisque.DataSource = dtList

  End Sub

  Private Sub BtnEnregistrer_Click(sender As Object, e As EventArgs) Handles BtnEnregistrer.Click

    If oFicheSituDanger Is Nothing OrElse oFicheSituDanger.NIDFICSITUDANG_SERVER = 0 Then
      MessageBox.Show("Il faut enregistrer la fiche de situation dangereuse", "Erreur", MessageBoxButtons.OK, MessageBoxIcon.Exclamation)
      Return
    End If

    ''type situation
    oFicheSituDanger_Reponse.CHK_HUMAINE = ChkHumaine.Checked
    oFicheSituDanger_Reponse.CHK_CONSIGNE = ChkConsigne.Checked
    oFicheSituDanger_Reponse.CHK_ORGANISATION = ChkOrga.Checked
    oFicheSituDanger_Reponse.CHK_FORMATION = ChkForm.Checked
    oFicheSituDanger_Reponse.CHK_MATERIEL = ChkMate.Checked
    oFicheSituDanger_Reponse.CHK_MILIEU = ChkMilieu.Checked
    oFicheSituDanger_Reponse.CHK_AUTRE = ChkAutres.Checked
    oFicheSituDanger_Reponse.VAUTRES = TxtBoxAutres.Text

    oFicheSituDanger_Reponse.NCOTATION = CboCotation.EditValue
    oFicheSituDanger_Reponse.NRISQUE = cboRisque.SelectedValue

    oFicheSituDanger_Reponse.VREPONSE = MemoRep.Text

    oFicheSituDanger_Reponse.SaveFicheSituDanger_Reponse()

    _NIDFICSITUDANG_REP = oFicheSituDanger_Reponse.NIDFICSITUDANG_REP
    _NIDFICSITUDANG_SERVER = oFicheSituDanger_Reponse.NIDFICSITUDANG_SERVER

    LoaddataFicheReponse()

  End Sub

  Private Sub LoaddataFicheTech()

    oFicheSituDanger = New CFICSITUDANG(_NIDFICSITUDANG_SERVER, _NACTNUM, _NPERNUM)

    Cbo_FicIntervenant.SelectedValue = oFicheSituDanger.NPERNUM

    Txt_DI.Text = oFicheSituDanger.NDINNUM
    Txt_Lieu.Text = oFicheSituDanger.SSITE
    Txt_FicDateCree.Text = If(oFicheSituDanger.DFICSITUDANG_DATCREE Is Nothing, "", Convert.ToDateTime(oFicheSituDanger.DFICSITUDANG_DATCREE).ToShortDateString)
    Txt_FicHeure.Text = If(oFicheSituDanger.DFICSITUDANG_DATCREE Is Nothing, "", Convert.ToDateTime(oFicheSituDanger.DFICSITUDANG_DATCREE).ToShortTimeString)

    'type situation
    ChkTypeSitu1.Checked = oFicheSituDanger.NTYPESITUATION_CHK_1
    ChkTypeSitu2.Checked = oFicheSituDanger.NTYPESITUATION_CHK_2
    ChkTypeSitu3.Checked = oFicheSituDanger.NTYPESITUATION_CHK_3

    'victime
    ChkVictime1.Checked = oFicheSituDanger.NVICTIME_CHK_1
    ChkVictime2.Checked = oFicheSituDanger.NVICTIME_CHK_2
    ChkVictime3.Checked = oFicheSituDanger.NVICTIME_CHK_3

    TxtEditVVICTIME_1.Text = oFicheSituDanger.VVICTIME_INFO_1
    TxtEditVVICTIME_2.Text = oFicheSituDanger.VVICTIME_INFO_2
    TxtEditVVICTIME_3.Text = oFicheSituDanger.VVICTIME_INFO_3

    'fait
    MemoEditFaits.Text = oFicheSituDanger.VFAITS_INFO

    'init
    ImgLstFicheSituDang_Photos.Images.Clear()
    LstViewPhotos.Items.Clear()

    'photos
    For Each DrPhoto As DataRow In oFicheSituDanger.DtDetailFicheSituDang_Photos.Rows

      ImgLstFicheSituDang_Photos.Images.Add(DrPhoto.Item("NIDFICSITUDANG_PHOTO_SERVER").ToString, byteArrayToImage(DrPhoto.Item("IMG_PHOTO")))
      LstViewPhotos.Items.Add(DrPhoto.Item("VPHOTOS_LIB").ToString, DrPhoto.Item("NIDFICSITUDANG_PHOTO_SERVER").ToString)

    Next

    GrpBoxPhotos.Text = oFicheSituDanger.DtDetailFicheSituDang_Photos.Rows.Count.ToString & " Photo(s) - Double clic sur la photo pour agrandir"

    'si création alors on cache des frames
    If oFicheSituDanger.NIDFICSITUDANG_SERVER = 0 Then
      GrpBoxReponse.Visible = False
      GrpBoxSuiviAction.Visible = False
    Else
      GrpBoxReponse.Visible = True
      GrpBoxSuiviAction.Visible = True
    End If


  End Sub
  Private Function byteArrayToImage(ByVal byteArrayIn As Byte()) As Image
    Using mStream As New MemoryStream(byteArrayIn)
      Return Image.FromStream(mStream)
    End Using
  End Function

  Private Sub LoaddataFicheReponse()

    oFicheSituDanger_Reponse = New CFICSITUDANG_REP(_NIDFICSITUDANG_REP, _NIDFICSITUDANG_SERVER)

    LblDateReponse.Text = oFicheSituDanger_Reponse.DREPVALID
    LblDeclarant.Text = oFicheSituDanger_Reponse.VQUIREP + " - " + oFicheSituDanger_Reponse.VQUIFONC

    ''type situation
    ChkHumaine.Checked = oFicheSituDanger_Reponse.CHK_HUMAINE
    ChkConsigne.Checked = oFicheSituDanger_Reponse.CHK_CONSIGNE
    ChkOrga.Checked = oFicheSituDanger_Reponse.CHK_ORGANISATION
    ChkForm.Checked = oFicheSituDanger_Reponse.CHK_FORMATION
    ChkMate.Checked = oFicheSituDanger_Reponse.CHK_MATERIEL
    ChkMilieu.Checked = oFicheSituDanger_Reponse.CHK_MILIEU
    ChkAutres.Checked = oFicheSituDanger_Reponse.CHK_AUTRE
    TxtBoxAutres.Text = oFicheSituDanger_Reponse.VAUTRES


    CboCotation.EditValue = oFicheSituDanger_Reponse.NCOTATION
    cboRisque.SelectedValue = oFicheSituDanger_Reponse.NRISQUE

    MemoRep.Text = oFicheSituDanger_Reponse.VREPONSE

    LblLectureTechDate.Text = oFicheSituDanger_Reponse.DTECH_LU

    If oFicheSituDanger_Reponse.BVALID_REP = True Then

      TxtBoxAutres.ReadOnly = True
      MemoRep.ReadOnly = True
      cboRisque.Enabled = True
      ChkHumaine.ReadOnly = True
      ChkConsigne.ReadOnly = True
      ChkOrga.ReadOnly = True
      ChkForm.ReadOnly = True
      ChkMate.ReadOnly = True
      ChkMilieu.ReadOnly = True
      ChkAutres.ReadOnly = True

      BtnValidRep.Visible = False

      'fiche
      Txt_DI.ReadOnly = True
      Txt_Lieu.ReadOnly = True
      Txt_FicDateCree.ReadOnly = True
      Txt_FicHeure.ReadOnly = True
      Cbo_FicIntervenant.Enabled = False

      BtnRechercheDI.Visible = False

      TxtEditVVICTIME_1.ReadOnly = True
      TxtEditVVICTIME_2.ReadOnly = True
      TxtEditVVICTIME_3.ReadOnly = True
      ChkVictime1.ReadOnly = True
      ChkVictime2.ReadOnly = True
      ChkVictime3.ReadOnly = True
      MemoEditFaits.ReadOnly = True

    Else

      'fiche
      Txt_DI.ReadOnly = True
      Txt_Lieu.ReadOnly = True
      Txt_FicDateCree.ReadOnly = True
      Txt_FicHeure.ReadOnly = True
      Cbo_FicIntervenant.Enabled = True

      BtnRechercheDI.Visible = True

      TxtEditVVICTIME_1.ReadOnly = False
      TxtEditVVICTIME_2.ReadOnly = False
      TxtEditVVICTIME_3.ReadOnly = False
      ChkVictime1.ReadOnly = False
      ChkVictime2.ReadOnly = False
      ChkVictime3.ReadOnly = False
      MemoEditFaits.ReadOnly = False

    End If

  End Sub
  Private Sub LoaddataFicheSuiviAct()

    oFicheSituDanger_SuiviAct = New CFICSITUDANG_SUIVIACT(_NIDFICSITUDANG_SUIVIACT, _NIDFICSITUDANG_SERVER)

    MemoEditCom_SuiviAction.Text = oFicheSituDanger_SuiviAct.VSUIVIACTION_COM

    Select Case oFicheSituDanger_SuiviAct.NSUIVIACTION_ETAT
      Case 0 'aucun
        RB_Encours_SuiviAction.Checked = False
        RB_Termine_SuiviAction.Checked = False
      Case 1 'encours
        RB_Encours_SuiviAction.Checked = True
        RB_Termine_SuiviAction.Checked = False
      Case 2 'terminée
        RB_Encours_SuiviAction.Checked = False
        RB_Termine_SuiviAction.Checked = True
    End Select

  End Sub

  Private Sub BtnValidRep_Click(sender As Object, e As EventArgs) Handles BtnValidRep.Click

    If oFicheSituDanger Is Nothing OrElse oFicheSituDanger.NIDFICSITUDANG_SERVER = 0 Then
      MessageBox.Show("Il faut enregistrer la fiche de situation dangereuse", "Erreur", MessageBoxButtons.OK, MessageBoxIcon.Exclamation)
      Return
    End If

    If MessageBox.Show("Voulez-vous valider la réponse ?" & vbCrLf & "Si oui, le technicien recevra la réponse lors de sa prochaine synchronisation", "Confirmation", MessageBoxButtons.YesNoCancel, MessageBoxIcon.Question) = vbYes Then

      oFicheSituDanger_Reponse.BVALID_REP = True
      oFicheSituDanger_Reponse.DREPVALID = Now

      BtnEnregistrer.PerformClick()

    End If

  End Sub

  Private Sub LstViewPhotos_MouseDoubleClick(sender As Object, e As MouseEventArgs) Handles LstViewPhotos.MouseDoubleClick

    Dim sPathTemp As String = Path.GetTempFileName
    Dim DrTOPhoto() As DataRow = oFicheSituDanger.DtDetailFicheSituDang_Photos.Select("[NIDFICSITUDANG_PHOTO_SERVER] = " & LstViewPhotos.SelectedItems.Item(0).ImageKey)

    If Not DrTOPhoto(0).Item("IMG_PHOTO") Is Nothing Then

      Dim ImgTemp As Image = ConvertSQLToImage(DrTOPhoto(0).Item("IMG_PHOTO"))
      ImgTemp.Save(sPathTemp)

      Dim oFrmVisu As New frmVisuDoc(sPathTemp)
      oFrmVisu.ShowDialog()

      If File.Exists(sPathTemp) Then File.Delete(sPathTemp)

    End If

  End Sub

  Private Function ConvertSQLToImage(ByVal tDataSQLImg As Byte()) As Image

    Dim strnomficcli As String = Path.GetTempFileName

    Try

      Dim fscli As New FileStream(strnomficcli, FileMode.Create, FileAccess.Write, FileShare.Write)
      fscli.Write(tDataSQLImg, 0, tDataSQLImg.Length)
      fscli.Flush()
      fscli.Close()
      fscli.Dispose()

      Return Image.FromFile(strnomficcli)

    Catch ex As Exception

      MessageBox.Show(ex.Message, "ConvertSQLToImage")
      Return Nothing

    Finally

      'If File.Exists(strnomficcli) = True Then File.Delete(strnomficcli)

    End Try

  End Function

  Private Sub BtnSaveComSuiviAction_Click(sender As Object, e As EventArgs) Handles BtnSaveComSuiviAction.Click

    If oFicheSituDanger Is Nothing OrElse oFicheSituDanger.NIDFICSITUDANG_SERVER = 0 Then
      MessageBox.Show("Il faut enregistrer la fiche de situation dangereuse", "Erreur", MessageBoxButtons.OK, MessageBoxIcon.Exclamation)
      Return
    End If

    ''type situation
    oFicheSituDanger_SuiviAct.VSUIVIACTION_COM = MemoEditCom_SuiviAction.Text

    If RB_Encours_SuiviAction.Checked = False And RB_Termine_SuiviAction.Checked = False Then
      oFicheSituDanger_SuiviAct.NSUIVIACTION_ETAT = 0
    ElseIf RB_Encours_SuiviAction.Checked = True And RB_Termine_SuiviAction.Checked = False Then
      oFicheSituDanger_SuiviAct.NSUIVIACTION_ETAT = 1
    ElseIf RB_Encours_SuiviAction.Checked = False And RB_Termine_SuiviAction.Checked = True Then
      oFicheSituDanger_SuiviAct.NSUIVIACTION_ETAT = 2
    End If

    oFicheSituDanger_SuiviAct.SaveFicheSituDanger_SuiviAction()

    _NIDFICSITUDANG_SUIVIACT = oFicheSituDanger_SuiviAct.NIDFICSITUDANG_SUIVIACT

    LoaddataFicheSuiviAct()

  End Sub

  Private Sub BtnAddPhoto_Click(sender As Object, e As EventArgs) Handles BtnAddPhoto.Click

    If oFicheSituDanger Is Nothing OrElse oFicheSituDanger.NIDFICSITUDANG_SERVER = 0 Then
      MessageBox.Show("Il faut enregistrer la fiche de situation dangereuse", "Erreur", MessageBoxButtons.OK, MessageBoxIcon.Exclamation)
      Return
    End If

    ODF.FileName = ""
    ODF.Multiselect = False
    ODF.Filter = "Fichiers Images (*.jpg, *.jpeg, *.png, *.gif, *.bmp)|*.jpg|*.jpeg|*.png|*.gif|*.bmp"
    ODF.ShowDialog()

    If ODF.FileName <> "" Then

      Dim sNamePhoto As String = InputBox("Nom de la photo")

      If sNamePhoto = "" Then MessageBox.Show("Il faut saisir un nom", "Erreur") : Exit Sub

      oFicheSituDanger.Addphoto(sNamePhoto, ODF.FileName)
      LoaddataFicheTech()

    End If

  End Sub

  Private Sub BtnSuppPhoto_Click(sender As Object, e As EventArgs) Handles BtnSuppPhoto.Click

    If LstViewPhotos.SelectedItems.Count = 0 Then Return

    If MessageBox.Show("Voulez-vous vraiement supprimer cette photo ?", "Suppression photo", MessageBoxButtons.YesNoCancel, MessageBoxIcon.Question) = DialogResult.Yes Then

      oFicheSituDanger.DelPhoto(LstViewPhotos.SelectedItems.Item(0).ImageKey)

      LstViewPhotos.SelectedItems.Item(0).Remove()

    End If

  End Sub

  Private Sub BtnArchiver_Click(sender As Object, e As EventArgs) Handles BtnArchiver.Click

    If MessageBox.Show("Voulez-vous vraiment archiver cette fiche de situation dangereuse ?", "Archiver", MessageBoxButtons.YesNoCancel, MessageBoxIcon.Question) = DialogResult.Yes Then

      oFicheSituDanger.ArchiverFicheSituDang()

    End If

  End Sub

  Private Sub BtnSave_Click(sender As Object, e As EventArgs) Handles BtnSave.Click

    If oFicheSituDanger Is Nothing Then Return


    'NACTNUM obligatoire
    If oFicheSituDanger.NACTNUM = 0 Then
      MessageBox.Show("Il faut sélectionner une DI", "Erreur", MessageBoxButtons.OK, MessageBoxIcon.Exclamation)
      Return
    End If


    If MessageBox.Show("Voulez-vous vraiment enregistrer cette fiche de situation dangereuse ?", "Enregistrer", MessageBoxButtons.YesNoCancel, MessageBoxIcon.Question) = DialogResult.Yes Then

      'MAJ DES VARIABLES
      oFicheSituDanger.NPERNUM = Cbo_FicIntervenant.SelectedValue
      oFicheSituDanger.VNOMTECH = Cbo_FicIntervenant.Text

      oFicheSituDanger.NTYPESITUATION_CHK_1 = ChkTypeSitu1.Checked
      oFicheSituDanger.NTYPESITUATION_CHK_2 = ChkTypeSitu2.Checked
      oFicheSituDanger.NTYPESITUATION_CHK_3 = ChkTypeSitu3.Checked

      'victime
      oFicheSituDanger.NVICTIME_CHK_1 = ChkVictime1.Checked
      oFicheSituDanger.NVICTIME_CHK_2 = ChkVictime2.Checked
      oFicheSituDanger.NVICTIME_CHK_3 = ChkVictime3.Checked

      oFicheSituDanger.VVICTIME_INFO_1 = TxtEditVVICTIME_1.Text
      oFicheSituDanger.VVICTIME_INFO_2 = TxtEditVVICTIME_2.Text
      oFicheSituDanger.VVICTIME_INFO_3 = TxtEditVVICTIME_3.Text

      'fait
      oFicheSituDanger.VFAITS_INFO = MemoEditFaits.Text

      oFicheSituDanger.SaveFicheSituDang()

      'refresh 
      _NACTNUM = oFicheSituDanger.NACTNUM
      _NPERNUM = oFicheSituDanger.NPERNUM
      _NIDFICSITUDANG_SERVER = oFicheSituDanger.NIDFICSITUDANG_SERVER

      'reload
      LoaddataFicheTech()
      LoaddataFicheReponse()
      LoaddataFicheSuiviAct()

    End If

  End Sub

  Private Sub BtnRechercheDI_Click(sender As Object, e As EventArgs) Handles BtnRechercheDI.Click

    If Cbo_FicIntervenant.SelectedValue Is Nothing Then
      MessageBox.Show("Il faut sélectionner un intervenant", "Erreur", MessageBoxButtons.OK, MessageBoxIcon.Exclamation)
      Return
    End If

    Dim ofrmSelectDIByTech As New frmSelectDIByTech(Cbo_FicIntervenant.SelectedValue)
    ofrmSelectDIByTech.ShowDialog()

    If ofrmSelectDIByTech.NACTNUM_SELECTED > 0 Then

      oFicheSituDanger.NACTNUM = ofrmSelectDIByTech.NACTNUM_SELECTED
      oFicheSituDanger.NDINNUM = ofrmSelectDIByTech.NDINNUM_SELECTED
      oFicheSituDanger.SSITE = ofrmSelectDIByTech.VSITNOM_SELECTED

      Txt_DI.Text = oFicheSituDanger.NDINNUM
      Txt_Lieu.Text = oFicheSituDanger.SSITE

    End If

  End Sub

  Private Sub Cbo_FicIntervenant_SelectedIndexChanged(sender As Object, e As EventArgs) Handles Cbo_FicIntervenant.SelectedIndexChanged

    If oFicheSituDanger Is Nothing Then Return

    If IsLoading = True Then Return

    oFicheSituDanger.NACTNUM = 0
    oFicheSituDanger.NDINNUM = 0
    oFicheSituDanger.SSITE = ""

    Txt_DI.Text = oFicheSituDanger.NDINNUM
    Txt_Lieu.Text = oFicheSituDanger.SSITE

  End Sub
End Class