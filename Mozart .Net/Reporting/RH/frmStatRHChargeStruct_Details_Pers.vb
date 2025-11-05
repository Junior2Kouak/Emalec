Imports System.Data.SqlClient
Imports MozartLib

Public Class frmStatRHChargeStruct_Details_Pers

  Dim dsStatDetail As DataSet


  Dim _iAnnee As Int32
  Dim _societe As String

  Public Sub New(ByVal c_iAnnee As Int32, ByVal c_societe As String)

    ' Cet appel est requis par le concepteur.
    InitializeComponent()

    ' Ajoutez une initialisation quelconque après l'appel InitializeComponent().
    _iAnnee = c_iAnnee
    _societe = c_societe

  End Sub

  Private Sub frmStatRHChargeStruct_Details_Pers_Load(sender As Object, e As EventArgs) Handles MyBase.Load

    LblTitre.Text = String.Format(LblTitre.Text, _iAnnee)

    LoadData()

  End Sub
  Private Sub LoadData()

    dsStatDetail = New DataSet

    Dim sqlcmd As New SqlCommand("[api_sp_StatRHChargeStruct_Details_Personnel]", MozartDatabase.cnxMozart)
    sqlcmd.CommandType = CommandType.StoredProcedure
        sqlcmd.Parameters.Add("@nannee", SqlDbType.Int).Value = _iAnnee
        sqlcmd.Parameters.Add("@vsociete", SqlDbType.VarChar).Value = _societe

        Dim sqlAdpat As SqlDataAdapter = New SqlDataAdapter(sqlcmd)
        sqlAdpat.Fill(dsStatDetail)

        GCStatTech.DataSource = dsStatDetail.Tables(0)
        GCStatPerOpe.DataSource = dsStatDetail.Tables(1)
        GCStatPerFonc.DataSource = dsStatDetail.Tables(2)

    End Sub

    Private Sub BtnFermer_Click(sender As Object, e As EventArgs) Handles BtnFermer.Click
        Me.Close()
    End Sub

    Private Sub BtnPrint_Click(sender As Object, e As EventArgs) Handles BtnPrint.Click
        Dim oScreenShot As New CSreenShot(Me, True)
        oScreenShot.Print_Form()
    End Sub
End Class