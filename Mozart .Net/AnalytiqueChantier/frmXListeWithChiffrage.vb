Imports System.Data.SqlClient
Imports System.Reflection
Imports DevExpress.XtraPrinting
Imports MozartControls
Imports MozartLib
Imports MZUtils = MozartControls.Utils

Public Class frmXListeWithChiffrage

  Dim drTemp As SqlDataReader
  Dim cmd As New SqlCommand("", MozartDatabase.cnxMozart)

  Public iFicheH As Integer

  Public iFicheH_Chaff As Integer
  Public iFicheH_BE As Integer

  Public iFicheF As Integer
  Public iFicheS As Integer
  Public iFO As Integer
  Public iMO As Integer

  Public iMO_Chaff As Integer
  Public iMO_BE As Integer

  Public iSTT As Integer

  Dim dtChifByChantier As DataTable
  Dim iNIDCHIF As Integer
  Dim iNIDCHANTIER As Integer
  Dim iPos As Integer

  Dim nTypeAffichage As Integer

  Dim sTypeOuverture As String

  Public Sub New()

    ' Cet appel est requis par le concepteur.
    InitializeComponent()

    ' Ajoutez une initialisation quelconque après l'appel InitializeComponent().

  End Sub

  Public Sub New(ByVal c_TypeOuverture As Object, ByVal c_NIDCHANTIER As Object)

    ' Cet appel est requis par le concepteur.
    InitializeComponent()

    ' Ajoutez une initialisation quelconque après l'appel InitializeComponent().
    sTypeOuverture = c_TypeOuverture.ToString
    iNIDCHANTIER = Convert.ToInt32(c_NIDCHANTIER)

  End Sub

  Private Sub frmXListe_Load(ByVal sender As Object, ByVal e As EventArgs) Handles MyBase.Load
    cmdPlanDeCharge.Visible = RechercheDroitMenu(736)

    'Init
    LoadChantierTAUX()

    'view by droit
    ' 2024/04/18 FGB : Si RechercheDroitMenu false, on a les droits ... ok ....
    Dim bControlVisible As Boolean = Not RechercheDroitMenu(665)

    GrpTypeAffichage.Visible = bControlVisible
    btnValidation.Visible = bControlVisible
    BtnModifProrata.Visible = bControlVisible
    btnCreationFiches.Visible = bControlVisible
    btnAnalyse.Visible = bControlVisible
    BtnChantierDoc.Visible = bControlVisible
    BtnPlanningChantier.Visible = bControlVisible
    btnSup.Visible = bControlVisible
    btnListeArchive.Visible = bControlVisible

    BtnPlanningChantier.Visible = False

    rbAll.Checked = True
  End Sub

  Private Sub btnModif_Click(ByVal sender As Object, ByVal e As EventArgs) Handles btnModif.Click
    Try

      If GVListeChantier.FocusedRowHandle < 0 Then Exit Sub
      If GVListeChantier.RowCount = 0 Then Exit Sub

      iNIDCHIF = Convert.ToInt32(GVListeChantier.GetDataRow(GVListeChantier.FocusedRowHandle).Item("NIDCHIF"))
      iPos = GVListeChantier.FocusedRowHandle

      ' modification
      Dim ofrmChiff As New frmChiffrage(iNIDCHIF)
      ofrmChiff.ShowDialog()

      LoadData()
      GVListeChantier.FocusedRowHandle = iPos

    Catch Ex As Exception
      MZUtils.displayError(MethodBase.GetCurrentMethod().Name, Ex)
    End Try
  End Sub

  Private Sub LoadData()
    cmd = New SqlCommand("api_sp_ChantierListeChiffrage", MozartDatabase.cnxMozart) With {
      .CommandType = CommandType.StoredProcedure
    }

    cmd.Parameters.Add("@actif", SqlDbType.VarChar).Value = "O"
    cmd.Parameters.Add("@soc", SqlDbType.VarChar).Value = MozartParams.NomSociete
    cmd.Parameters.Add("@iall", SqlDbType.Int).Value = nTypeAffichage

    dtChifByChantier = New DataTable
    dtChifByChantier.Load(cmd.ExecuteReader)

    If sTypeOuverture = "CHANTIER" Then
      GCListe.DataSource = dtChifByChantier.Select("NIDCHANTIER = " & iNIDCHANTIER.ToString).CopyToDataTable
      If GVListeChantier.RowCount > 0 Then GVListeChantier.FocusedRowHandle = 0
      StateChantier()
    Else
      GCListe.DataSource = dtChifByChantier
    End If

  End Sub

  Private Sub StateChantier()
    ' fonction permettant de déterminer l'état du chantier
    ' chiffrage OK si au moins un découpage 
    Try
      If GVListeChantier.RowCount = 0 Then Exit Sub
      If GVListeChantier.FocusedRowHandle < 0 Then Exit Sub

      iNIDCHIF = Convert.ToInt32(GVListeChantier.GetDataRow(GVListeChantier.FocusedRowHandle).Item("NIDCHIF"))
      iNIDCHANTIER = If(IsDBNull(GVListeChantier.GetDataRow(GVListeChantier.FocusedRowHandle).Item("NIDCHANTIER")) = True, 0, Convert.ToInt32(GVListeChantier.GetDataRow(GVListeChantier.FocusedRowHandle).Item("NIDCHANTIER")))

      If iNIDCHANTIER > 0 Then
        'couleur bouton
        btnValidation.BackColor = Color.Yellow
        ' Fiches de suivi OK si les 2 fiches sont crees
        cmd = New SqlCommand("SELECT ISNULL(SUM(NVAL),0) FROM TCHANTIERFICHE WITH (NOLOCK) WHERE NIDCHANTIER = " & iNIDCHANTIER & " AND VTYPE = 'H' AND NIDANACHAFICTYPE IN (5, 6, 7, 8)", MozartDatabase.cnxMozart)
        cmd.CommandType = CommandType.Text
        drTemp = cmd.ExecuteReader
        drTemp.Read()
        iFicheH = drTemp(0)
        drTemp.Close()

        cmd = New SqlCommand("SELECT ISNULL(SUM(NVAL),0) FROM TCHANTIERFICHE WITH (NOLOCK) WHERE NIDCHANTIER = " & iNIDCHANTIER & " AND VTYPE = 'H' AND NIDANACHAFICTYPE IN (2)", MozartDatabase.cnxMozart)
        cmd.CommandType = CommandType.Text
        drTemp = cmd.ExecuteReader
        drTemp.Read()
        iFicheH_Chaff = drTemp(0)
        drTemp.Close()

        cmd = New SqlCommand("SELECT ISNULL(SUM(NVAL),0) FROM TCHANTIERFICHE WITH (NOLOCK) WHERE NIDCHANTIER = " & iNIDCHANTIER & " AND VTYPE = 'H' AND NIDANACHAFICTYPE IN (1, 9, 10, 11)", MozartDatabase.cnxMozart)
        cmd.CommandType = CommandType.Text
        drTemp = cmd.ExecuteReader
        drTemp.Read()
        iFicheH_BE = drTemp(0)
        drTemp.Close()

        cmd = New SqlCommand("SELECT ISNULL(SUM(NVAL),0) FROM TCHANTIERFICHE WITH (NOLOCK) WHERE NIDCHANTIER = " & iNIDCHANTIER & " AND VTYPE = 'F'", MozartDatabase.cnxMozart)
        cmd.CommandType = CommandType.Text
        drTemp = cmd.ExecuteReader
        drTemp.Read()
        iFicheF = drTemp(0)
        drTemp.Close()

        ' Fiches de suivi OK si les 2 fiches sont crees
        cmd = New SqlCommand("SELECT ISNULL(SUM(NVAL),0) FROM TCHANTIERFICHE WITH (NOLOCK) WHERE NIDCHANTIER = " & iNIDCHANTIER & " AND VTYPE = 'S'", MozartDatabase.cnxMozart)
        cmd.CommandType = CommandType.Text
        drTemp = cmd.ExecuteReader
        drTemp.Read()
        iFicheS = drTemp(0)
        drTemp.Close()

        cmd = New SqlCommand("SELECT SUM(ISNULL(NMO,0)) + SUM(ISNULL(NMO_MECA,0)) + SUM(ISNULL(NMO_CABL,0)) + SUM(ISNULL(NMO_AIDETEC,0)) AS MO, " _
                                & " SUM(ISNULL(NMOBE_AUTO,0)) + SUM(ISNULL(NMOBE_ELEC,0)) + SUM(ISNULL(NMOBE_MECA,0)) + SUM(ISNULL(NMOBE,0)) AS MO_BE, " _
                                & " SUM(ISNULL(NMOCHAF,0)) AS MO_CHAFF, " _
                                & " SUM(ISNULL(NFO,0)) FO, SUM(ISNULL(NSTT,0)) STT FROM TCHANTIERCHIFFRAGE WITH (NOLOCK) WHERE CCHIFACTIF = 'O' AND NIDCHANTIER = " & iNIDCHANTIER, MozartDatabase.cnxMozart)
        cmd.CommandType = CommandType.Text
        drTemp = cmd.ExecuteReader
        drTemp.Read()
        iMO = drTemp("MO")
        iMO_Chaff = drTemp("MO_CHAFF")
        iMO_BE = drTemp("MO_BE")
        iFO = drTemp("FO")
        iSTT = drTemp("STT")
        drTemp.Close()
      Else
        btnValidation.BackColor = Color.Transparent
        iFicheH = 0
        iFicheH_Chaff = 0
        iFicheH_BE = 0
        iFicheF = 0
        iFicheS = 0
        iMO = -1
        iMO_Chaff = -1
        iMO_BE = -1
        iFO = -1
        iSTT = -1
      End If

      If iFO = iFicheF And iMO = iFicheH And iMO_Chaff = iFicheH_Chaff And iMO_BE = iFicheH_BE And iSTT = iFicheS Then
        btnCreationFiches.BackColor = Color.GreenYellow
        btnCreationFiches.Tag = 1
      Else
        btnCreationFiches.BackColor = Color.Transparent
        btnCreationFiches.Tag = 0
      End If

    Catch ex As Exception
      MZUtils.displayError(MethodBase.GetCurrentMethod().Name, ex)
    End Try

  End Sub

  Private Sub btnAjout_Click(ByVal sender As Object, ByVal e As EventArgs) Handles btnAjout.Click
    ' creation
    Dim oFrmChiff As New frmChiffrage(0)
    oFrmChiff.ShowDialog()

    iPos = GVListeChantier.FocusedRowHandle
    LoadData()
    GVListeChantier.FocusedRowHandle = iPos
  End Sub

  Private Sub btnValidation_Click(ByVal sender As Object, ByVal e As EventArgs) Handles btnValidation.Click
    If GVListeChantier.FocusedRowHandle < 0 Then Exit Sub
    If GVListeChantier.RowCount = 0 Then Exit Sub

    iNIDCHIF = Convert.ToInt32(GVListeChantier.GetDataRow(GVListeChantier.FocusedRowHandle).Item("NIDCHIF"))

    Dim oFrmValidationChif As New frmValidation(iNIDCHIF)
    oFrmValidationChif.ShowDialog()

    iPos = GVListeChantier.FocusedRowHandle

    LoadData()

    GVListeChantier.FocusedRowHandle = iPos
  End Sub

  Private Sub btnCreationFiches_Click(ByVal sender As Object, ByVal e As EventArgs) Handles btnCreationFiches.Click

    If GVListeChantier.FocusedRowHandle < 0 Then Exit Sub
    If GVListeChantier.RowCount = 0 Then Exit Sub

    Dim oDataRowSelect As DataRow = GVListeChantier.GetDataRow(GVListeChantier.FocusedRowHandle)

    'si chantier archivage chantier complet
    If IsDBNull(oDataRowSelect.Item("NIDCHANTIER")) = False AndAlso oDataRowSelect.Item("NIDCHANTIER") > 0 Then

      Dim oFrmChoixFiche As New frmChoixFiche(iNIDCHANTIER, (iFO = iFicheF), (iMO = iFicheH), (iSTT = iFicheS), (iMO_BE = iFicheH_BE), (iMO_Chaff = iFicheH_Chaff))
      oFrmChoixFiche.ShowDialog()
      StateChantier()

    Else
      MessageBox.Show(My.Resources.Global_Chiffrage_chantier, My.Resources.Global_Erreur, MessageBoxButtons.OK, MessageBoxIcon.Error)
    End If

  End Sub

  Private Sub btnAnalyse_Click(ByVal sender As Object, ByVal e As EventArgs) Handles btnAnalyse.Click

    If GVListeChantier.FocusedRowHandle < 0 Then Exit Sub

    Try
      If btnCreationFiches.Tag = 0 Then
        MessageBox.Show(My.Resources.Global_Heures_Fournitures, My.Resources.Global_Avertissement)
        Exit Sub
      End If

      Dim oDataRowSelect As DataRow = GVListeChantier.GetDataRow(GVListeChantier.FocusedRowHandle)

      'si chantier archivage chantier complet
      If IsDBNull(oDataRowSelect.Item("NIDCHANTIER")) = False AndAlso oDataRowSelect.Item("NIDCHANTIER") > 0 Then

        'test si actions en erreur
        Dim oActInError As New CActionsInError(iNIDCHANTIER)

        If oActInError IsNot Nothing AndAlso oActInError.dtActions.Rows.Count > 0 Then

          Dim oFrmActionsError As New frmChantierListeActionErreur_Heures(oActInError)
          oFrmActionsError.ShowDialog()

        End If

        Me.Cursor = Cursors.WaitCursor

        Dim oFrmRealisation As New frmRealisation(iNIDCHANTIER, False)
        oFrmRealisation.ShowDialog()

        'StateChantier()
        LoadData()

      Else
        MessageBox.Show(My.Resources.Global_sélectionner_Chantier, My.Resources.Global_Erreur, MessageBoxButtons.OK, MessageBoxIcon.Exclamation)
      End If

    Catch ex As Exception
      MZUtils.displayError(MethodBase.GetCurrentMethod().Name, ex)
    Finally
      Me.Cursor = Cursors.Default
    End Try
  End Sub

  Private Sub btnSup_Click(ByVal sender As Object, ByVal e As EventArgs) Handles btnSup.Click

    If GVListeChantier.FocusedRowHandle < 0 Then Exit Sub

    If GVListeChantier.RowCount = 0 Then Exit Sub

    Dim oDataRowSelect As DataRow = GVListeChantier.GetDataRow(GVListeChantier.FocusedRowHandle)

    'si chantier archivage chantier complet
    If IsDBNull(oDataRowSelect.Item("NIDCHANTIER")) = False AndAlso oDataRowSelect.Item("NIDCHANTIER") > 0 Then

      Select Case MessageBox.Show(My.Resources.Admin_frmXlisteChiffrage_Archiver & vbCrLf & My.Resources.Admin_frmXlisteChiffrage_Archiver_oui & vbCrLf & My.Resources.Admin_frmXlisteChiffrage_Archiver_non, My.Resources.Admin_frmXlisteChiffrage_Archiver_CC, MessageBoxButtons.YesNoCancel, MessageBoxIcon.Question)

        Case DialogResult.Yes 'archive du chantier

          cmd.CommandText = "api_sp_ChantierArchiverChantier " & oDataRowSelect("NIDCHANTIER").ToString
          cmd.ExecuteNonQuery()
          cmd.Dispose()

        Case DialogResult.No 'archive du chiffrage

          Dim sqlcmdSupp As New SqlCommand("api_sp_ChantierSupprimerChiffrage", MozartDatabase.cnxMozart)
          sqlcmdSupp.CommandType = CommandType.StoredProcedure
          sqlcmdSupp.Parameters.Add("@iD", SqlDbType.Int).Value = oDataRowSelect.Item("NIDCHIF")
          sqlcmdSupp.ExecuteNonQuery()

        Case Else
          Exit Sub

      End Select

    Else

      If MessageBox.Show(My.Resources.Admin_frmXlisteChiffrage_Archiver_tout, My.Resources.Global_confirmerArchivage, MessageBoxButtons.YesNo, MessageBoxIcon.Question) = Windows.Forms.DialogResult.Yes Then

        Dim sqlcmdSupp As New SqlCommand("api_sp_ChantierSupprimerChiffrage", MozartDatabase.cnxMozart)
        sqlcmdSupp.CommandType = CommandType.StoredProcedure
        sqlcmdSupp.Parameters.Add("@iD", SqlDbType.Int).Value = oDataRowSelect.Item("NIDCHIF")
        sqlcmdSupp.ExecuteNonQuery()

      End If

    End If

    iPos = GVListeChantier.FocusedRowHandle

    LoadData()

    GVListeChantier.FocusedRowHandle = iPos

  End Sub

  Private Sub btnListeArchive_Click(ByVal sender As Object, ByVal e As EventArgs) Handles btnListeArchive.Click

    Dim oFrmListeArchives As New frmListeChantierArch()
    oFrmListeArchives.ShowDialog()

    LoadData()

  End Sub

  Private Sub btnImprimer_Click(ByVal sender As Object, ByVal e As EventArgs) Handles btnImprimer.Click

    Dim ps As New PrintingSystem
    Dim link As New PrintableComponentLink(ps)

    link.Component = GCListe
    link.Landscape = True
    link.CreateDocument()
    link.PrintingSystemBase.ExportToPdf(MozartParams.CheminUtilisateurMozart & "PDF\ChantierExport.pdf")

    Dim oDoc As New CGenDoc("ChantierExport", MozartParams.CheminUtilisateurMozart & "PDF\ChantierExport.pdf")
    If oDoc.p_ERROR = "" Then
      Dim oFrmVisuDoc As New frmVisuDoc(oDoc.p_PathFileName)
      oFrmVisuDoc.ShowDialog()
    End If

  End Sub

  Private Sub rbChiffrage_CheckedChanged(ByVal sender As Object, ByVal e As EventArgs) Handles rbChiffrage.CheckedChanged

    If rbChiffrage.Checked Then

      nTypeAffichage = 2
      LoadData()
      chkExpand.Checked = False

    End If

  End Sub

  Private Sub rbAll_CheckedChanged(ByVal sender As Object, ByVal e As EventArgs) Handles rbAll.CheckedChanged

    If rbAll.Checked Then

      nTypeAffichage = 0
      LoadData()
      chkExpand.Checked = False

    End If

  End Sub

  Private Sub rbChantier_CheckedChanged(ByVal sender As Object, ByVal e As EventArgs) Handles rbChantier.CheckedChanged

    If rbChantier.Checked Then

      nTypeAffichage = 1
      LoadData()
      chkExpand.Checked = False

    End If

  End Sub

  Private Sub chkExpand_CheckedChanged(ByVal sender As Object, ByVal e As EventArgs) Handles chkExpand.CheckedChanged
    If chkExpand.Checked Then
      GVListeChantier.CollapseAllGroups()
    Else
      GVListeChantier.ExpandAllGroups()
    End If
  End Sub

  Private Sub GVListeChantier_FocusedRowChanged(ByVal sender As Object, ByVal e As DevExpress.XtraGrid.Views.Base.FocusedRowChangedEventArgs) Handles GVListeChantier.FocusedRowChanged

    StateChantier()

    If e.FocusedRowHandle > 0 Then

      Dim drSelect As DataRow = GVListeChantier.GetDataRow(e.FocusedRowHandle)

      If drSelect IsNot Nothing AndAlso IsDBNull(drSelect.Item("NBDOC")) = False AndAlso drSelect.Item("NBDOC") > 0 Then

        BtnChantierDoc.BackColor = Color.Yellow

      Else

        BtnChantierDoc.BackColor = Color.WhiteSmoke

      End If

      If RechercheDroitMenu(655) Then Return

      'gestion du bouton affection chiffrage
      'non affecter a un chantier
      If IsDBNull(drSelect.Item("NIDCHANTIER")) = True OrElse drSelect.Item("NIDCHANTIER") = 0 Then

        btnValidation.Text = My.Resources.Admin_frmXlisteChiffrage_AffecterC
        btnCreationFiches.Visible = True
        btnAnalyse.Visible = True
        BtnModifProrata.Visible = True

      Else 'affecter a un chantier

        btnValidation.Text = My.Resources.Admin_frmXlisteChiffrage_Désaffecter
        btnCreationFiches.Visible = True
        btnAnalyse.Visible = True
        BtnModifProrata.Visible = True

      End If
    Else

      'par défaut
      If RechercheDroitMenu(655) Then Return

      btnValidation.Text = My.Resources.Admin_frmXlisteChiffrage_AffecterC
      btnCreationFiches.Visible = True
      btnAnalyse.Visible = True
      BtnModifProrata.Visible = True

    End If

  End Sub

  Private Sub BtnChantierDoc_Click(ByVal sender As Object, ByVal e As EventArgs) Handles BtnChantierDoc.Click

    If GVListeChantier.FocusedRowHandle < 0 Then Exit Sub
    Dim oDataRowSelect As DataRow = GVListeChantier.GetDataRow(GVListeChantier.GetSelectedRows(0))

    If IsDBNull(oDataRowSelect.Item("NIDCHANTIER")) = False AndAlso oDataRowSelect.Item("NIDCHANTIER") > 0 Then

      iPos = GVListeChantier.FocusedRowHandle

      Dim oChantierDoc As New frmGestionDocChantier(oDataRowSelect.Item("NIDCHANTIER"), oDataRowSelect.Item("VCANLIB"), False)
      oChantierDoc.ShowDialog()

      GVListeChantier.FocusedRowHandle = iPos

    Else

      MessageBox.Show(My.Resources.Global_affecter_chantier, My.Resources.Global_Erreur, MessageBoxButtons.OK, MessageBoxIcon.Exclamation)

    End If

  End Sub

  Private Sub BtnPlanningChantier_Click(sender As Object, e As EventArgs) Handles BtnPlanningChantier.Click

    If GVListeChantier.FocusedRowHandle < 0 Then Exit Sub
    If GVListeChantier.RowCount = 0 Then Exit Sub

    Dim oDataRowSelect As DataRow = GVListeChantier.GetDataRow(GVListeChantier.FocusedRowHandle)

    If IsDBNull(oDataRowSelect.Item("NIDCHIF")) = False AndAlso oDataRowSelect.Item("NIDCHIF") > 0 Then

      iPos = GVListeChantier.FocusedRowHandle

      Dim oChifPlanningXLS As New CGestionPlanningXLS(oDataRowSelect.Item("NIDCHIF"))
      If oChifPlanningXLS.ExistPlanningXLS = False Then oChifPlanningXLS.CreateFichierPlanningXLS(oDataRowSelect.Item("VCLINOM"), MozartParams.NomSociete)
      oChifPlanningXLS.OpenPLanningXLS()

      GVListeChantier.FocusedRowHandle = iPos

    Else

      MessageBox.Show(My.Resources.Global_SelectionnerChiffrage, My.Resources.Global_Erreur, MessageBoxButtons.OK, MessageBoxIcon.Exclamation)

    End If

  End Sub

  Private Sub BtnModifProrata_Click(sender As Object, e As EventArgs) Handles BtnModifProrata.Click

    If GVListeChantier.FocusedRowHandle < 0 Then Exit Sub
    If GVListeChantier.RowCount = 0 Then Exit Sub

    Try

      iPos = GVListeChantier.FocusedRowHandle

      Dim dtr As DataRow = GVListeChantier.GetDataRow(GVListeChantier.FocusedRowHandle)

      Dim oDataRowSelect As DataRow = GVListeChantier.GetDataRow(GVListeChantier.FocusedRowHandle)

      'si chantier archivage chantier complet
      If IsDBNull(oDataRowSelect.Item("NIDCHANTIER")) = False AndAlso oDataRowSelect.Item("NIDCHANTIER") > 0 Then

        Dim sMsg As String = String.Format(My.Resources.Admin_XListe_compte_protata & vbCrLf & My.Resources.Admin_XListe_message_Attention, dtr.Item("NPCPRORATA"))

        If MessageBox.Show(sMsg, My.Resources.Admin_frmXlisteChiffrage_Modif, MessageBoxButtons.YesNoCancel, MessageBoxIcon.Information) = Windows.Forms.DialogResult.Yes Then

          Dim oFrmModifProrataChantier As New frmModifProrataChantier(dtr.Item("NIDCHANTIER"), Convert.ToDecimal(dtr.Item("NPCPRORATA")))
          oFrmModifProrataChantier.ShowDialog()

          LoadData()

        End If

      Else

        MessageBox.Show(My.Resources.Global_sélectionner_Chantier, My.Resources.Global_Erreur, MessageBoxButtons.OK, MessageBoxIcon.Exclamation)

      End If

      GVListeChantier.FocusedRowHandle = iPos

    Catch ex As Exception
      MZUtils.displayError(MethodBase.GetCurrentMethod().Name, ex)
    End Try
  End Sub

  Private Sub cmdPlanDeCharge_Click(sender As Object, e As EventArgs) Handles cmdPlanDeCharge.Click
    Cursor.Current = Cursors.WaitCursor

    Dim lFrmPlanDeChargeGlobal = New frmPlanDeChargeGlobal()
    lFrmPlanDeChargeGlobal.ShowDialog()

    Cursor.Current = Cursors.Default
  End Sub

End Class