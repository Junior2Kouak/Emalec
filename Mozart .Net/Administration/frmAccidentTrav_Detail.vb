Imports System.Data.SqlClient
Imports DevExpress.XtraEditors
Imports DevExpress.XtraEditors.Controls
Imports MozartLib

Public Class frmAccidentTrav_Detail

  Dim _oAccidentDetail As CACCIDENT_TRAV
  Public Sub New(ByVal c_oAccidentDetail As CACCIDENT_TRAV)

    ' Cet appel est requis par le concepteur.
    InitializeComponent()

    ' Ajoutez une initialisation quelconque après l'appel InitializeComponent().
    _oAccidentDetail = c_oAccidentDetail

  End Sub

  Private Sub BtnFermer_Click(sender As Object, e As EventArgs) Handles BtnFermer.Click
    Me.Close()
  End Sub

  Private Sub frmAccidentTrav_Detail_Load(sender As Object, e As EventArgs) Handles MyBase.Load

    'init
    Initboutons(Me)

    LoadCbo()

    LoadData()

  End Sub
  Private Sub LoadData()

    If _oAccidentDetail IsNot Nothing Then

      TxtNum.Text = _oAccidentDetail.NACCIDENTID
      DTP_Accident.Text = _oAccidentDetail.DDATCRE
      CboUser.EditValue = _oAccidentDetail.NPERNUM
      ChkArret.Checked = _oAccidentDetail.BARRET
      LblSocPer.Text = _oAccidentDetail.VSOCIETE

    End If

  End Sub

  Private Sub BtnEnreg_Click(sender As Object, e As EventArgs) Handles BtnEnreg.Click

    _oAccidentDetail.DDATCRE = DTP_Accident.Text    '
    _oAccidentDetail.NPERNUM = CboUser.EditValue
    _oAccidentDetail.BARRET = ChkArret.Checked

    _oAccidentDetail.Save()

    LoadData()

  End Sub

  Private Sub LoadCbo()

    Dim dtcbo As New DataTable

    Dim sqlcmd As New SqlCommand("select	TPER.NPERNUM,
		                                  TPER.VPERNOM + ' '  + TPER.VPERPRE AS VPERNOM,
		                                  TPER.VSOCIETE,
		                                  TSOCIETE.VSOCIETE_NOM_USUEL 
                                  from	TPER WITH(NOLOCK) LEFT OUTER JOIN
		                                  TSOCIETE WITH(NOLOCK) ON TSOCIETE.VSOCIETENOM = TPER.VSOCIETE
                                  where	CPERACTIF = 'O'
		                                  and BUTILISATEUR = 0
                                  order by VPERNOM, vperpre", MozartDatabase.cnxMozart)
    sqlcmd.CommandType = CommandType.Text
    dtcbo.Load(sqlcmd.ExecuteReader())

    CboUser.Properties.DataSource = dtcbo

  End Sub

  Private Sub CboUser_CloseUp(sender As Object, e As CloseUpEventArgs) Handles CboUser.CloseUp

    Dim edit As GridLookUpEdit = TryCast(sender, GridLookUpEdit)
    If e.AcceptValue Then
      Dim row As Object = edit.Properties.GetRowByKeyValue(e.Value)
      LblSocPer.Text = row.item("VSOCIETE_NOM_USUEL")
    End If

  End Sub
End Class