Imports System.Data.SqlClient
Imports DevExpress.XtraEditors
Imports DevExpress.XtraEditors.Controls
Imports MozartLib

Public Class frmCertFluidBottle

  Dim _oCertFluidBottle As CCertFluidBottle

  Dim dtBottleType As DataTable
  Dim dtBottleContenance As DataTable
  Dim dtBottleFluides As DataTable
  Dim dtBottleTechniciens As DataTable
  Dim dtBottleCF As DataTable
  Dim bLoading As Boolean = False
  Dim _NSSCFONUM As Int32
  Dim _bActif As Boolean

  Public Sub New(ByVal c_KEY_BOTTLE_UNIQUE As String)

    ' Cet appel est requis par le concepteur.
    InitializeComponent()

    ' Ajoutez une initialisation quelconque après l'appel InitializeComponent().
    _oCertFluidBottle = New CCertFluidBottle(c_KEY_BOTTLE_UNIQUE)

  End Sub

  Private Sub frmCertFluidBottle_Load(sender As Object, e As EventArgs) Handles MyBase.Load

    'init position
    TxtBottle_Qte_Free.Location = New Point(GLUpBottleContenance.Location)
    TxtBottle_Qte_Free.Size = New Size(GLUpBottleContenance.Size)
    TxtBottle_Qte_Free.Visible = False

    _oCertFluidBottle.LoadData()
    LoadDataCbo()
    GLUpBottleType.EditValue = _oCertFluidBottle.NBOTTLE_TYPE
    If _oCertFluidBottle.NBOTTLE_TYPE = 3 Then
      TxtBottle_Qte_Free.Text = _oCertFluidBottle.NBOTTLE_CONTENANT
    Else
      GLUpBottleContenance.EditValue = _oCertFluidBottle.NBOTTLE_CONTENANT
    End If
    GLUpBottleFluide.EditValue = _oCertFluidBottle.NIDTYPEFLUIDE
    GLUpBottleTech.EditValue = _oCertFluidBottle.NPERNUM
    txt_VREFBOTTLE.Text = _oCertFluidBottle.VBOTTLE_REF
    txtObs.Text = _oCertFluidBottle.VBOTTLE_OBS
    If _oCertFluidBottle.DBOTTLE_RESTI Is Nothing Then
      txtDtResti.Text = ""
    Else
      txtDtResti.Text = _oCertFluidBottle.DBOTTLE_RESTI.ToString
    End If
    ChkActif.Checked = _oCertFluidBottle.BBOTTLE_ACTIF

    'progressbar
    PBC_Bottle_Util.Properties.Maximum = _oCertFluidBottle.NBOTTLE_CONTENANT
    PBC_Bottle_Util.Properties.Minimum = 0

    If _oCertFluidBottle.NBOTTLE_CONTENANT = 0 Then
      PBC_Bottle_Util.EditValue = 0
    Else
      PBC_Bottle_Util.EditValue = _oCertFluidBottle.NBOTTLE_CONTENANT - _oCertFluidBottle.NBOTTLEQTEUTIL
    End If

    GridLookUpEdit_CF.EditValue = _oCertFluidBottle.NCOMNUM

    'si N° commande saisie alors modif quantité bloquée
    If _oCertFluidBottle.NCOMNUM > 0 Then

      TxtBottle_Qte_Free.ReadOnly = True

    End If


    Dim ValuePourc As Int32

    If _oCertFluidBottle.NBOTTLE_CONTENANT = 0 Then ValuePourc = 0 Else ValuePourc = ((_oCertFluidBottle.NBOTTLE_CONTENANT - _oCertFluidBottle.NBOTTLEQTEUTIL) / _oCertFluidBottle.NBOTTLE_CONTENANT) * 100

    Select Case ValuePourc
      Case 0 To 25
        PBC_Bottle_Util.Properties.StartColor = Color.Red
      Case 26 To 50
        PBC_Bottle_Util.Properties.StartColor = Color.Orange
      Case Else
        PBC_Bottle_Util.Properties.StartColor = Color.Green
    End Select
    PBC_Bottle_Util.Properties.EndColor = PBC_Bottle_Util.Properties.StartColor

  End Sub

  Private Sub BtnFermer_Click(sender As Object, e As EventArgs) Handles BtnFermer.Click
    Me.Close()
  End Sub

  Private Sub BtnEnreg_Click(sender As Object, e As EventArgs) Handles BtnEnreg.Click

    If _oCertFluidBottle Is Nothing Then Exit Sub

    'test des infos saisi
    If GLUpBottleType.EditValue Is Nothing OrElse GLUpBottleType.EditValue.ToString = "" Then
      MessageBox.Show("Vous devez saisir un type de bouteille !", "Erreur", MessageBoxButtons.OK, MessageBoxIcon.Exclamation)
      Exit Sub
    End If

    If GLUpBottleType.EditValue = 3 Then

      If TxtBottle_Qte_Free.Text = "" Then
        MessageBox.Show("Vous devez saisir la quantité de la bouteille !", "Erreur", MessageBoxButtons.OK, MessageBoxIcon.Exclamation)
        Exit Sub
      End If

    Else

      If GLUpBottleContenance.EditValue Is Nothing OrElse GLUpBottleContenance.EditValue.ToString = "" Then
        MessageBox.Show("Vous devez saisir la quantité de la bouteille !", "Erreur", MessageBoxButtons.OK, MessageBoxIcon.Exclamation)
        Exit Sub
      End If

    End If

    If GLUpBottleFluide.EditValue Is Nothing OrElse GLUpBottleFluide.EditValue.ToString = "" Then
      MessageBox.Show("Vous devez saisir un type de fluide !", "Erreur", MessageBoxButtons.OK, MessageBoxIcon.Exclamation)
      Exit Sub
    End If

    If txt_VREFBOTTLE.Text = "" Then
      MessageBox.Show("Vous devez saisir la référence de la bouteille !", "Erreur", MessageBoxButtons.OK, MessageBoxIcon.Exclamation)
      Exit Sub
    End If

    _oCertFluidBottle.NBOTTLE_TYPE = GLUpBottleType.EditValue
    _oCertFluidBottle.NBOTTLE_CONTENANT = If(GLUpBottleType.EditValue = 3, Convert.ToDecimal(TxtBottle_Qte_Free.EditValue.ToString.Replace(".", ",")), GLUpBottleContenance.EditValue)  'TxtBottle_Qte_Free.EditValue
    _oCertFluidBottle.NIDTYPEFLUIDE = GLUpBottleFluide.EditValue
    _oCertFluidBottle.VTYPEFLUIDE = GLUpBottleFluide.Text
    _oCertFluidBottle.NPERNUM = GLUpBottleTech.EditValue
    _oCertFluidBottle.VBOTTLE_REF = txt_VREFBOTTLE.Text
    _oCertFluidBottle.VBOTTLE_OBS = txtObs.Text
    If txtDtResti.Text = "" Then
      _oCertFluidBottle.DBOTTLE_RESTI = Nothing
    Else
      _oCertFluidBottle.DBOTTLE_RESTI = Convert.ToDateTime(txtDtResti.Text)
    End If
    _oCertFluidBottle.BBOTTLE_ACTIF = ChkActif.Checked

    ' _oCertFluidBottle.NCOMNUM = GridLookUpEdit_CF.EditValue

    _oCertFluidBottle.SaveCertFluidBottle()

    _oCertFluidBottle.LoadData()

    PBC_Bottle_Util.Refresh()

  End Sub

  Private Sub LoadDataCbo()

    dtBottleType = New DataTable
    dtBottleContenance = New DataTable
    dtBottleFluides = New DataTable
    dtBottleTechniciens = New DataTable

    Dim osqlcmdLoadCbo As New SqlCommand("[api_sp_CertFluid_Bottle_ListeType]", MozartDatabase.cnxMozart)
    osqlcmdLoadCbo.CommandType = CommandType.StoredProcedure
    dtBottleType.Load(osqlcmdLoadCbo.ExecuteReader)
    GLUpBottleType.Properties.DataSource = dtBottleType

    osqlcmdLoadCbo = New SqlCommand("[api_sp_CertFluid_Bottle_ListeContenant]", MozartDatabase.cnxMozart)
    osqlcmdLoadCbo.CommandType = CommandType.StoredProcedure
    dtBottleContenance.Load(osqlcmdLoadCbo.ExecuteReader)
    GLUpBottleContenance.Properties.DataSource = dtBottleContenance

    osqlcmdLoadCbo = New SqlCommand("[api_sp_CertFluid_Bottle_ListeFluideFrigo]", MozartDatabase.cnxMozart)
    osqlcmdLoadCbo.CommandType = CommandType.StoredProcedure
    dtBottleFluides.Load(osqlcmdLoadCbo.ExecuteReader)
    GLUpBottleFluide.Properties.DataSource = dtBottleFluides

    osqlcmdLoadCbo = New SqlCommand("[api_sp_CertFluid_Bottle_ListeTechsFluideFrigo]", MozartDatabase.cnxMozart)
    osqlcmdLoadCbo.CommandType = CommandType.StoredProcedure
    osqlcmdLoadCbo.Parameters.Add("@P_VSOCIETE", SqlDbType.VarChar).Value = MozartParams.NomSociete
    osqlcmdLoadCbo.Parameters.Add("@P_NPERNUM", SqlDbType.Int).Value = _oCertFluidBottle.NPERNUM
    dtBottleTechniciens.Load(osqlcmdLoadCbo.ExecuteReader)

    GLUpBottleTech.Properties.DataSource = dtBottleTechniciens

  End Sub

  Private Sub BtnAddDateResti_Click(sender As Object, e As EventArgs) Handles BtnAddDateResti.Click
    CalendarDateResti.Visible = True
  End Sub
  Private Sub CalendarDateResti_DateSelected(sender As Object, e As DateRangeEventArgs) Handles CalendarDateResti.DateSelected
    txtDtResti.Text = CalendarDateResti.SelectionRange.Start
    CalendarDateResti.Visible = False
    txtObs.Text = "Restitution de la bouteille le " & txtDtResti.Text & " saisi le " & Now.Date.ToShortDateString & " par " & MozartParams.strUID & "." & vbCrLf & txtObs.Text

  End Sub

  Private Sub BtnDelDateResti_Click(sender As Object, e As EventArgs) Handles BtnDelDateResti.Click
    txtObs.Text = "Suppression de la restitution de la bouteille du " & txtDtResti.Text & " saisi le " & Now.Date.ToShortDateString & " par " & MozartParams.strUID & "." & vbCrLf & txtObs.Text
    txtDtResti.Text = ""
  End Sub
  Private Sub GLUpBottleType_EditValueChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles GLUpBottleType.EditValueChanged

    If Not GLUpBottleType.EditValue Is Nothing AndAlso GLUpBottleType.EditValue.ToString <> "" AndAlso GLUpBottleType.EditValue = 3 Then
      TxtBottle_Qte_Free.Visible = True
      'changment des libelles
      Label1.Text = "Quantité contenant (en Kg):"
      PBC_Bottle_Util.Properties.DisplayFormat.FormatString = "{0:n3} Kg"
      Label6.Visible = True

    Else
      TxtBottle_Qte_Free.Visible = False
      Label6.Visible = False
      Label1.Text = "Quantité contenant (en L):"
      PBC_Bottle_Util.Properties.DisplayFormat.FormatString = "{0:n0} L"

    End If

    If Not GLUpBottleType.EditValue Is Nothing AndAlso GLUpBottleType.EditValue.ToString <> "" Then
      Select Case Convert.ToInt32(GLUpBottleType.EditValue)
        Case 1 ''BOUTEILLE RÉCUPÉRATION'
          _NSSCFONUM = 100
          PBC_Bottle_Util.Text = "0 L"
          Label1.Text = "Quantité contenant (en L):"
        Case 2 'BOUTEILLE TRANSFERT
          _NSSCFONUM = 101
          PBC_Bottle_Util.Text = "0 L"
          Label1.Text = "Quantité contenant (en L):"
        Case Else 'BOUTEILLE NEUVE'
          _NSSCFONUM = -1
          PBC_Bottle_Util.Text = "0 Kg"
          Label1.Text = "Quantité contenant (en Kg):"
      End Select

    End If

    If GLUpBottleFluide.EditValue IsNot Nothing Then

      'init des variables
      If bLoading = False Then
        GridLookUpEdit_CF.EditValue = Nothing
      End If

      LoadCboCF()

    End If

    GLUpBottleContenance.Visible = Not TxtBottle_Qte_Free.Visible

  End Sub

  Private Sub GLUpBottleContenance_EditValueChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles GLUpBottleContenance.EditValueChanged

    If _oCertFluidBottle Is Nothing Then Return

    _oCertFluidBottle.NBOTTLE_CONTENANT = If(GLUpBottleType.EditValue = 3, TxtBottle_Qte_Free.EditValue, GLUpBottleContenance.EditValue)

    'progressbar
    PBC_Bottle_Util.Properties.Maximum = _oCertFluidBottle.NBOTTLE_CONTENANT
    PBC_Bottle_Util.Properties.Minimum = 0

    If _oCertFluidBottle.NBOTTLE_CONTENANT = 0 Then
      PBC_Bottle_Util.EditValue = 0
    Else
      PBC_Bottle_Util.EditValue = _oCertFluidBottle.NBOTTLE_CONTENANT - _oCertFluidBottle.NBOTTLEQTEUTIL
    End If

    Dim ValuePourc As Int32

    If _oCertFluidBottle.NBOTTLE_CONTENANT = 0 Then ValuePourc = 0 Else ValuePourc = ((_oCertFluidBottle.NBOTTLE_CONTENANT - _oCertFluidBottle.NBOTTLEQTEUTIL) / _oCertFluidBottle.NBOTTLE_CONTENANT) * 100

    Select Case ValuePourc
      Case 0 To 25
        PBC_Bottle_Util.Properties.StartColor = Color.Red
      Case 26 To 50
        PBC_Bottle_Util.Properties.StartColor = Color.Orange
      Case Else
        PBC_Bottle_Util.Properties.StartColor = Color.Green
    End Select
    PBC_Bottle_Util.Properties.EndColor = PBC_Bottle_Util.Properties.StartColor

  End Sub

  Private Sub GLUpBottleFluide_EditValueChanged(sender As Object, e As EventArgs) Handles GLUpBottleFluide.EditValueChanged
    LoadCboCF()
  End Sub

  Private Sub GLUpBottleTech_EditValueChanged(sender As Object, e As EventArgs) Handles GLUpBottleTech.EditValueChanged
    LoadCboCF()
  End Sub

  Private Sub LoadCboCF()

    If (GLUpBottleFluide.EditValue IsNot Nothing) And (GLUpBottleTech.EditValue IsNot Nothing) Then

      dtBottleCF = New DataTable

      Dim osqlcmdLoadCbo As New SqlCommand("[api_sp_CertFluid_Bottle_LoadCF]", MozartDatabase.cnxMozart)
      osqlcmdLoadCbo.CommandType = CommandType.StoredProcedure
      osqlcmdLoadCbo.Parameters.Add("@P_NPERNUM", SqlDbType.Int).Value = If(GLUpBottleTech.EditValue.ToString = "", DBNull.Value, GLUpBottleTech.EditValue)
      osqlcmdLoadCbo.Parameters.Add("@P_NTYPEFLUIDE", SqlDbType.Int).Value = If(GLUpBottleFluide.EditValue.ToString = "", DBNull.Value, GLUpBottleFluide.EditValue)
      osqlcmdLoadCbo.Parameters.Add("@P_NSSCFONUM", SqlDbType.Int).Value = _NSSCFONUM
      If _oCertFluidBottle IsNot Nothing Then osqlcmdLoadCbo.Parameters.Add("@P_NCOMNUM", SqlDbType.Int).Value = _oCertFluidBottle.NCOMNUM
      If _oCertFluidBottle IsNot Nothing Then osqlcmdLoadCbo.Parameters.Add("@P_NFOUNUM", SqlDbType.Int).Value = _oCertFluidBottle.NFOUNUM
      dtBottleCF.Load(osqlcmdLoadCbo.ExecuteReader)

      GridLookUpEdit_CF.Properties.DataSource = dtBottleCF

    End If
  End Sub

  Private Sub GridLookUpEdit_CF_CloseUp(sender As Object, e As CloseUpEventArgs) Handles GridLookUpEdit_CF.CloseUp

    Dim edit As GridLookUpEdit = TryCast(sender, GridLookUpEdit)
    If e.AcceptValue Then
      Dim row As Object = edit.Properties.GetRowByKeyValue(e.Value)

      If row IsNot Nothing Then

        If row.Item("NCOMNUM") Is DBNull.Value Then

          TxtBottle_Qte_Free.ReadOnly = False
          _oCertFluidBottle.NFOUNUM = 0
          _oCertFluidBottle.NCOMNUM = 0

        Else

          'si N° commande saisie alors modif quantité bloquée
          TxtBottle_Qte_Free.ReadOnly = True

          If row.Item("NFOUNBLOT") <> Convert.ToInt32(TxtBottle_Qte_Free.Text) Then
            MessageBox.Show("Attention, la quantité va être modifiée car elle ne correspond pas à la quantité de la bouteille commandée !", "Information", MessageBoxButtons.OK, MessageBoxIcon.Exclamation)
          End If

          TxtBottle_Qte_Free.Text = row.Item("NFOUNBLOT")
          _oCertFluidBottle.NFOUNUM = row.Item("NFOUNUM")
          _oCertFluidBottle.NCOMNUM = row.Item("NCOMNUM")

        End If

      Else
        TxtBottle_Qte_Free.ReadOnly = False
        _oCertFluidBottle.NFOUNUM = 0
        _oCertFluidBottle.NCOMNUM = 0
      End If

    End If

  End Sub

  Private Sub TxtBottle_Qte_Free_EditValueChanged(sender As Object, e As EventArgs) Handles TxtBottle_Qte_Free.EditValueChanged

    If TxtBottle_Qte_Free.Text <> "" Then

      _oCertFluidBottle.NBOTTLE_CONTENANT = Convert.ToDecimal(TxtBottle_Qte_Free.Text)

      'progressbar
      PBC_Bottle_Util.Properties.Maximum = _oCertFluidBottle.NBOTTLE_CONTENANT
      PBC_Bottle_Util.Properties.Minimum = 0

      If _oCertFluidBottle.NBOTTLE_CONTENANT = 0 Then
        PBC_Bottle_Util.EditValue = 0
      Else
        PBC_Bottle_Util.EditValue = _oCertFluidBottle.NBOTTLE_CONTENANT - _oCertFluidBottle.NBOTTLEQTEUTIL
      End If

      Dim ValuePourc As Int32

      If _oCertFluidBottle.NBOTTLE_CONTENANT = 0 Then ValuePourc = 0 Else ValuePourc = ((_oCertFluidBottle.NBOTTLE_CONTENANT - _oCertFluidBottle.NBOTTLEQTEUTIL) / _oCertFluidBottle.NBOTTLE_CONTENANT) * 100

      Select Case ValuePourc
        Case 0 To 25
          PBC_Bottle_Util.Properties.StartColor = Color.Red
        Case 26 To 50
          PBC_Bottle_Util.Properties.StartColor = Color.Orange
        Case Else
          PBC_Bottle_Util.Properties.StartColor = Color.Green
      End Select
      PBC_Bottle_Util.Properties.EndColor = PBC_Bottle_Util.Properties.StartColor

    End If

  End Sub

  Private Sub GLUpBottleType_EditValueChanging(sender As Object, e As ChangingEventArgs) Handles GLUpBottleType.EditValueChanging

    If e.OldValue = "3" Then

      If _oCertFluidBottle.NCOMNUM > 0 Then

        If MessageBox.Show("Attention , si vous changer le type de bouteille, le N° de commande sera supprimé de la bouteille" & vbCrLf & "Voulez-vous continuer ?", "Avertissement", MessageBoxButtons.YesNoCancel, MessageBoxIcon.Exclamation) <> DialogResult.Yes Then
          e.Cancel = True
        End If

      End If

    End If

  End Sub

  Private Sub GridLookUpEdit_CF_EditValueChanged(sender As Object, e As EventArgs) Handles GridLookUpEdit_CF.EditValueChanged


    Dim view As DevExpress.XtraGrid.Views.Grid.GridView =
        CType(GridLookUpEdit_CF.Properties.View, DevExpress.XtraGrid.Views.Grid.GridView)

    If _oCertFluidBottle IsNot Nothing And bLoading = False Then
      _oCertFluidBottle.NCOMNUM = view.GetRowCellValue(view.FocusedRowHandle, "NCOMNUM")
      _oCertFluidBottle.NFOUNUM = view.GetRowCellValue(view.FocusedRowHandle, "NFOUNUM")
    End If

  End Sub

  Private Sub BtnSupprimerCom_Click(sender As Object, e As EventArgs) Handles BtnSupprimerCom.Click

    _oCertFluidBottle.NCOMNUM = 0
    _oCertFluidBottle.NFOUNUM = 0
    GridLookUpEdit_CF.EditValue = Nothing

  End Sub
End Class

