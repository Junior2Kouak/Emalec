Imports System.Data.SqlClient
Imports MozartLib

Public Class frmSaisieMontantGD

  Dim dtMontantGD As DataTable
  Dim _NVALGD As Int32
  Dim _bCancel As Boolean

  Public ReadOnly Property NVALGD As Int32
    Get
      NVALGD = _NVALGD
    End Get
  End Property

  Public ReadOnly Property bCancel As Int32
    Get
      bCancel = _bCancel
    End Get
  End Property

  Public Sub New(Optional ByVal c_NVALGD As Int32 = 0)

    ' Cet appel est requis par le concepteur.
    InitializeComponent()

    ' Ajoutez une initialisation quelconque après l'appel InitializeComponent().
    _NVALGD = c_NVALGD
    _bCancel = False

  End Sub

  Private Sub frmSaisieMontantGD_Load(sender As System.Object, e As System.EventArgs) Handles MyBase.Load

    Try

      dtMontantGD = New DataTable

      Dim sqlcmdLoad As New SqlCommand("api_sp_MontantGDSrc", MozartDatabase.cnxMozart)
      sqlcmdLoad.CommandType = CommandType.StoredProcedure

            dtMontantGD.Load(sqlcmdLoad.ExecuteReader)

            CboMontantGD.DataSource = dtMontantGD

            If _NVALGD > 0 Then

                'selection auto
                CboMontantGD.SelectedValue = _NVALGD

            End If

        Catch ex As Exception

            MessageBox.Show(ex.Message)

        End Try

    End Sub

    Private Sub BtnCancel_Click(sender As System.Object, e As System.EventArgs) Handles BtnCancel.Click

        _bCancel = True
        Me.Close()

    End Sub

    Private Sub BtnValid_Click(sender As System.Object, e As System.EventArgs) Handles BtnValid.Click

        If Not CboMontantGD.SelectedValue Is DBNull.Value AndAlso CboMontantGD.SelectedValue > 0 Then
            _NVALGD = CboMontantGD.SelectedValue
            Me.Close()
        Else
            MessageBox.Show(My.Resources.SaisieFrais_FrmSaisieMontantGD_select_montant, My.Resources.Global_Erreur, MessageBoxButtons.OK, MessageBoxIcon.Exclamation)
            _bCancel = True
        End If

    End Sub

End Class