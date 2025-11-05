Imports System.Data.SqlClient
Imports MozartLib

Public Class frmStatRHChargeStruct_Details_Taux

  Dim dtStatDetail As DataTable

  Dim _iAnnee As Int32
  Dim _societe As String

  Public Sub New(ByVal c_iAnnee As Int32, ByVal c_societe As String)

    ' Cet appel est requis par le concepteur.
    InitializeComponent()

    ' Ajoutez une initialisation quelconque après l'appel InitializeComponent().
    _iAnnee = c_iAnnee
    _societe = c_societe

  End Sub

  Private Sub frmStatRHChargeStruct_Details_Taux_Load(sender As Object, e As EventArgs) Handles MyBase.Load

    LblTitre.Text = String.Format(LblTitre.Text, _iAnnee)

    LoadData()

  End Sub

  Private Sub LoadData()

    dtStatDetail = New DataTable

    Dim sqlcmd As New SqlCommand("[api_sp_StatRHChargeStruct_Details_Taux]", MozartDatabase.cnxMozart)
    sqlcmd.CommandType = CommandType.StoredProcedure
        sqlcmd.Parameters.Add("@nannee", SqlDbType.Int).Value = _iAnnee
        sqlcmd.Parameters.Add("@vsociete", SqlDbType.VarChar).Value = _societe

        dtStatDetail.Load(sqlcmd.ExecuteReader)

        GCStat.DataSource = dtStatDetail

    End Sub

    Private Sub BtnFermer_Click(sender As Object, e As EventArgs) Handles BtnFermer.Click
        Me.Close()
    End Sub

    Private Sub BtnPrint_Click(sender As Object, e As EventArgs) Handles BtnPrint.Click
        GCStat.Print()
    End Sub

End Class