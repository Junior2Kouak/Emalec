Imports System.Data.SqlClient
Imports DevExpress.XtraEditors
Imports DevExpress.XtraGrid.Views.Base
Imports DevExpress.XtraGrid.Views.Grid
Imports MozartLib

Public Class frmGestPrestationDetail

  Dim oDetailPresta As CPrestation

  Dim oPrestationSerie As New CPrestationSerie
  Dim oCboType As New CPrestationType
  Dim oCboUnite As New CPrestationUnite

  Dim NPERNUM_CREATEUR As Int32
  Dim _sModeOpen As String


  Public Sub New(ByVal C_DetailPresta As CPrestation, Optional c_sModeOpen As String = "")

    ' Cet appel est requis par le concepteur.
    InitializeComponent()

    ' Ajoutez une initialisation quelconque après l'appel InitializeComponent().
    oDetailPresta = C_DetailPresta
    _sModeOpen = c_sModeOpen

  End Sub

  Private Sub frmGestPrestationDetail_Load(sender As Object, e As EventArgs) Handles MyBase.Load

    If _sModeOpen = "COPIE" Then
      MessageBox.Show("Avant de créer la prestation, assurez-vous qu'elle ne soit pas déjà existante", "Information", MessageBoxButtons.OK, MessageBoxIcon.Information)
    End If

    'init cbo
    GridLookUpSerie.Properties.DataSource = oPrestationSerie.DtListeSerie
    GlookUpType.Properties.DataSource = oCboType.DtListeType
    GridLookUpEdit3.Properties.DataSource = oCboUnite.DtListeUnite

    Wb_Information.DocumentText = My.Resources.Prestation_Information

    LoadData()

  End Sub

  Private Sub LoadData()

    'typologie
    GlookUpType.EditValue = oDetailPresta.NPREST_TYPE_ID
    GridLookUpSerie.EditValue = oDetailPresta.NPRESTSERID
    GridLookUpSousSerie.EditValue = oDetailPresta.NPREST_SS_SERIE_ID

    'déboursé
    GridLookUpEdit3.EditValue = oDetailPresta.VPRESTUNITE
    Txt_QteMO.Text = oDetailPresta.NPRESTQTEMO
    Txt_PrixMO.Text = oPrestationSerie.GetSeriePrixMo(oDetailPresta.NPRESTSERID)
    Txt_MontantFO.Text = oDetailPresta.NPRESTFOHT


    'historique
    If _sModeOpen <> "COPIE" Then
      Txt_Createur.Text = oDetailPresta.CREATEUR
      Txt_DateCreate.Text = oDetailPresta.DPRESTCRE
      Txt_MODIF.Text = oDetailPresta.MODIF
      Txt_DPRESTMOD.Text = oDetailPresta.DPRESTMOD
    End If

    'code
    Txt_VPRESTCODE.Text = oDetailPresta.VPRESTCODE

    If oDetailPresta.NPRESTID = 0 Then
      NPERNUM_CREATEUR = MozartParams.UID
    Else
      NPERNUM_CREATEUR = oDetailPresta.NPRESTIDCREE
    End If

    'libellé
    Txt_VPRESTLIB.Text = oDetailPresta.VPRESTLIB

    'fournitures
    GCListePrestFou.DataSource = oDetailPresta.dtDetailPrestaFou

    'Txt_MontantFO.Text = string.format(GVListePrestFou.Columns("Prix Total").SummaryItem.SummaryValue,  'oDetailPresta.NPRESTFOHT

  End Sub

  Private Sub GridLookUpSerie_EditValueChanged(sender As Object, e As EventArgs) Handles GridLookUpSerie.EditValueChanged

    If GridLookUpSerie.EditValue Is Nothing OrElse GridLookUpSerie.EditValue.ToString = "" Then Exit Sub

    Dim ooCboSousSerie As New CPrestationSousSerie()
    GridLookUpSousSerie.Properties.DataSource = ooCboSousSerie.dtListeSousSerie

    Txt_PrixMO.Text = oPrestationSerie.GetSeriePrixMo(GridLookUpSerie.EditValue)

    CalculTotal()

  End Sub

  Private Sub BtnFermer_Click(sender As Object, e As EventArgs) Handles BtnFermer.Click
    Me.Close()
  End Sub

  Private Function CalculTotal() As Decimal

    If Txt_QteMO.Text = "" Or Txt_PrixMO.Text = "" Or Txt_MontantFO.Text = "" Then
      Return Nothing
    Else
      ' on calcul le total de la prestation
      Return (Txt_QteMO.Text * Txt_PrixMO.Text) + Txt_MontantFO.Text
    End If

  End Function

  Private Sub CalculTotaux_EditValueChanged(sender As Object, e As EventArgs) Handles Txt_MontantFO.EditValueChanged, Txt_PrixMO.EditValueChanged, Txt_QteMO.EditValueChanged

    Txt_MontantTotHT.EditValue = CalculTotal()

  End Sub

  Private Sub Txt_TextChanged(sender As Object, e As EventArgs) Handles Txt_QteMO.TextChanged

    Dim oTxt As TextEdit = TryCast(sender, TextEdit)
    If oTxt.Text = "" Then
      MessageBox.Show("Le format d'une quantité ou d'un montant n'est pas correcte !", "Erreur", MessageBoxButtons.OK, MessageBoxIcon.Exclamation)
    End If

  End Sub
  Private Sub BtnSave_Click(sender As Object, e As EventArgs) Handles BtnSave.Click

    'vérification
    If GridLookUpEdit3.Text = "" Then
      MessageBox.Show("Vous devez saisir l'unité de la prestation", "Erreur", MessageBoxButtons.OK, MessageBoxIcon.Exclamation)
      GridLookUpEdit3.Focus()
      Exit Sub
    End If

    If Txt_VPRESTLIB.Text = "" Then
      MessageBox.Show("Vous devez saisir un libellé de la prestation", "Erreur", MessageBoxButtons.OK, MessageBoxIcon.Exclamation)
      Txt_VPRESTLIB.Focus()
      Exit Sub
    End If

    If GlookUpType.Text = "" Then
      MessageBox.Show("Vous devez saisir un type de la prestation", "Erreur", MessageBoxButtons.OK, MessageBoxIcon.Exclamation)
      GlookUpType.Focus()
      Exit Sub
    End If

    If GridLookUpSerie.Text = "" Then
      MessageBox.Show("Vous devez saisir une série de la prestation", "Erreur", MessageBoxButtons.OK, MessageBoxIcon.Exclamation)
      GridLookUpSerie.Focus()
      Exit Sub
    End If

    If GridLookUpSousSerie.Text = "" Then
      MessageBox.Show("Vous devez saisir une sous série de la prestation", "Erreur", MessageBoxButtons.OK, MessageBoxIcon.Exclamation)
      GridLookUpSerie.Focus()
      Exit Sub
    End If

    If Txt_QteMO.Text = "" OrElse Convert.ToDecimal(Txt_QteMO.Text) = 0 Then
      MessageBox.Show("Vous devez saisir une quantité de main d'oeuvre de la prestation", "Erreur", MessageBoxButtons.OK, MessageBoxIcon.Exclamation)
      Txt_QteMO.Focus()
      Exit Sub
    End If

    If GVListePrestFou.DataRowCount = 0 Then
      MessageBox.Show("Vous devez sélectionner au moins une fourniture", "Erreur", MessageBoxButtons.OK, MessageBoxIcon.Exclamation)
      GridLookUpEdit3.Focus()
      Exit Sub
    End If


    ' le créateur de la prestation peut modifier la prestation uniquement (+ droit)
    If NPERNUM_CREATEUR <> MozartParams.UID And RechercheDroitMenu(612) = False And _sModeOpen <> "COPIE" And oDetailPresta.NPRESTID <> 0 And bPerActif(NPERNUM_CREATEUR) = True Then

      Dim strMsgBox As String

      strMsgBox = "INFO : Vous n’êtes pas le créateur de cette prestation, vous ne pouvez donc pas la modifier." & vbCrLf
      strMsgBox = strMsgBox & "Deux solutions sont possibles : " & vbCrLf
      strMsgBox = strMsgBox & "- Demander au créateur de modifier la prestation." & vbCrLf
      strMsgBox = strMsgBox & "- Copier (Bouton ‘Copie prestation’) cette prestation pour en créer une autre, sous la forme que vous souhaitez." & vbCrLf
      MessageBox.Show(strMsgBox, "Erreur", MessageBoxButtons.OK, MessageBoxIcon.Exclamation)
      Exit Sub
    End If

    'typologie
    oDetailPresta.NPREST_TYPE_ID = GlookUpType.EditValue
    oDetailPresta.NPRESTSERID = GridLookUpSerie.EditValue
    oDetailPresta.NPREST_SS_SERIE_ID = GridLookUpSousSerie.EditValue

    'déboursé
    oDetailPresta.VPRESTUNITE = GridLookUpEdit3.EditValue
    oDetailPresta.NPRESTQTEMO = If(Txt_QteMO.Text = "", 0, Txt_QteMO.Text)
    oDetailPresta.NPRESTFOHT = If(Txt_MontantFO.Text = "", 0, Txt_MontantFO.Text)

    oDetailPresta.VPRESTCODE = Txt_VPRESTCODE.Text

    'libellé
    oDetailPresta.VPRESTLIB = Txt_VPRESTLIB.Text

    If _sModeOpen = "COPIE" Then oDetailPresta.NPRESTID = 0

    oDetailPresta.SavePrestation()

    oDetailPresta.SaveFourniturePrestation(If(_sModeOpen = "COPIE", True, False))

    If _sModeOpen = "COPIE" Then _sModeOpen = ""

    'refresh
    oDetailPresta.Loaddata()
    LoadData()

  End Sub

  Private Sub GlookUpType_EditValueChanged(sender As Object, e As EventArgs) Handles GlookUpType.EditValueChanged

    If GlookUpType.EditValue IsNot Nothing AndAlso GlookUpType.EditValue.ToString <> "" AndAlso GlookUpType.EditValue = 1 Then
      Txt_VPRESTCODE.Visible = False
    Else
      Txt_VPRESTCODE.Visible = True
    End If
    Label13.Visible = Txt_VPRESTCODE.Visible

  End Sub

  Private Function bPerActif(ByVal p_npernum As Int32) As Boolean

    Dim sqlcmdPerActif As New SqlCommand("SELECT CPERACTIF FROM TPER WITH (NOLOCK) WHERE NPERNUM = " & p_npernum, MozartDatabase.cnxMozart)
    sqlcmdPerActif.CommandType = CommandType.Text
    Dim dr As SqlDataReader = sqlcmdPerActif.ExecuteReader

    If dr.HasRows Then
      dr.Read()
      If dr.Item("CPERACTIF") = "O" Then
        bPerActif = True
      Else
        bPerActif = False
      End If
    Else
      bPerActif = False
    End If
    dr.Close()

  End Function

  Private Sub frmGestPrestationDetail_ResizeEnd(sender As Object, e As EventArgs) Handles Me.ResizeEnd

    ResizeComponents()

  End Sub

  Private Sub frmGestPrestationDetail_SizeChanged(sender As Object, e As EventArgs) Handles Me.SizeChanged

    ResizeComponents()

  End Sub

  Private Sub ResizeComponents()

    GrpPageInfo.Location = New Point(Me.Size.Width - GrpPageInfo.Size.Width - 30, GrpPageInfo.Location.Y)
    GrpCodePresta.Size = New Size(Me.Size.Width - GrpPageInfo.Size.Width - GrpCodePresta.Location.X - 40, GrpCodePresta.Size.Height)

    GrpLibelle.Size = New Size(GrpCodePresta.Size.Width, (Me.Size.Height - GrpLibelle.Location.Y - 100) / 2)

    Txt_VPRESTLIB.Size = New Size(GrpLibelle.Size.Width - Txt_VPRESTLIB.Location.X - 5, GrpLibelle.Size.Height - Txt_VPRESTLIB.Location.Y - 5)

    GrpListeFo.Location = New Point(GrpLibelle.Location.X, GrpLibelle.Location.Y + GrpLibelle.Size.Height + 5)
    GrpListeFo.Size = New Size(GrpLibelle.Size.Width, Me.Size.Height - GrpListeFo.Location.Y - 100)

    GCListePrestFou.Size = New Size(GrpListeFo.Size.Width - GCListePrestFou.Location.X - 5, GrpListeFo.Size.Height - GCListePrestFou.Location.Y - 5)

  End Sub

  ' Returns the total amount for a specific row. 
  Private Function getTotalValue(view As GridView, listSourceRowIndex As Int32) As Decimal
    Dim unitPrice As Decimal = Convert.ToDecimal(view.GetListSourceRowCellValue(listSourceRowIndex, "Prix U"))
    Dim quantity As Decimal = Convert.ToDecimal(view.GetListSourceRowCellValue(listSourceRowIndex, "Quantite"))
    Return unitPrice * quantity
  End Function

  Private Sub GVListePrestFou_CustomUnboundColumnData(sender As Object, e As CustomColumnDataEventArgs) Handles GVListePrestFou.CustomUnboundColumnData

    Dim view As GridView = TryCast(sender, GridView)
    If e.Column.FieldName = "Prix Total" AndAlso e.IsGetData Then
      e.Value = getTotalValue(view, e.ListSourceRowIndex)
    End If

  End Sub

  Private Sub BtnAddFO_Click(sender As Object, e As EventArgs) Handles BtnAddFO.Click

    Dim oFrmRechercheArticle As New frmGestPrestaRechercheFournitures(oDetailPresta, "Prestation", False)
    oFrmRechercheArticle.ShowDialog()

    'fournitures
    GCListePrestFou.DataSource = oDetailPresta.dtDetailPrestaFou

    GVListePrestFou.UpdateTotalSummary()
    Txt_MontantFO.EditValue = GVListePrestFou.Columns("Prix Total").SummaryItem.SummaryValue

  End Sub

  Private Sub BtnSupprimer_Click(sender As Object, e As EventArgs) Handles BtnSupprimerFO.Click

    If GVListePrestFou.FocusedRowHandle < -1 Then Exit Sub

    If MessageBox.Show("Voulez-vous vraiment supprimer cette fourniture ?", "Confirmer", MessageBoxButtons.YesNoCancel, MessageBoxIcon.Question) = DialogResult.Yes Then

      Dim drSelect As DataRow = GVListePrestFou.GetDataRow(GVListePrestFou.FocusedRowHandle)
      drSelect.Delete()
      GVListePrestFou.UpdateCurrentRow()
      GVListePrestFou.UpdateTotalSummary()
      Txt_MontantFO.EditValue = GVListePrestFou.Columns("Prix Total").SummaryItem.SummaryValue

    End If

  End Sub

  Private Sub GVListePrestFou_CellValueChanged(sender As Object, e As CellValueChangedEventArgs) Handles GVListePrestFou.CellValueChanged

    If e.Column.FieldName = "Quantite" Then

      GVListePrestFou.UpdateTotalSummary()
      Txt_MontantFO.EditValue = GVListePrestFou.Columns("Prix Total").SummaryItem.SummaryValue

    End If

  End Sub

  Private Sub BtnConvert_Click(sender As Object, e As EventArgs) Handles BtnConvert.Click

    Dim oFrmCalculette As New frmConvertTimeToCentieme(Txt_QteMO.Text)
    oFrmCalculette.ShowDialog()

    If oFrmCalculette.bValid = True Then

      Txt_QteMO.Text = oFrmCalculette.NQTEMO

    End If

  End Sub

  Private Sub ChkNuit_CheckedChanged(sender As Object, e As EventArgs)

    Txt_PrixMO.Text = oPrestationSerie.GetSeriePrixMo(GridLookUpSerie.EditValue)

  End Sub
End Class