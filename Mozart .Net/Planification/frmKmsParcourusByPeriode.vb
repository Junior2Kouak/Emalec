Imports System.Data.SqlClient
Imports MozartLib

Public Class frmKmsParcourusByPeriode

  Dim DTData As DataTable

  Dim _NPERNUM As Int32

  Public Sub New(ByVal c_NPERNUM As Object, ByVal c_DATEDEBUT As Object, ByVal c_DATEFIN As Object)

    ' Cet appel est requis par le concepteur.
    InitializeComponent()

    ' Ajoutez une initialisation quelconque après l'appel InitializeComponent().
    DTPDebut.Value = c_DATEDEBUT
    DTPFin.Value = c_DATEFIN
    _NPERNUM = c_NPERNUM


  End Sub


  Private Sub frmKmsParcourusByPeriode_Load(sender As Object, e As EventArgs) Handles MyBase.Load


    LblTitre.Text = "Nombre de kms parcourus - " & GetNomTech(_NPERNUM)

    Loaddata()

  End Sub

  Private Sub Loaddata()

    DTData = New DataTable

    Dim sqlcmd As New SqlCommand("[api_sp_KmsParcourusOnPeriodByTech]", MozartDatabase.cnxMozart)
    sqlcmd.CommandType = CommandType.StoredProcedure
        sqlcmd.Parameters.Add("@P_DATEDEBUT", SqlDbType.DateTime).Value = DTPDebut.Value
        sqlcmd.Parameters.Add("@P_DATEFIN", SqlDbType.DateTime).Value = DTPFin.Value
        sqlcmd.Parameters.Add("@P_NPERNUM", SqlDbType.Int).Value = _NPERNUM

        DTData.Load(sqlcmd.ExecuteReader)

        GCKMS.DataSource = DTData

    End Sub


    Private Function GetNomTech(ByVal p_NPERNUM As Int32) As String

    Dim sqlcmdLoad As New SqlCommand("SELECT TPER.VPERNOM + ' ' + TPER.VPERPRE FROM TPER WHERE TPER.NPERNUM =  " & _NPERNUM.ToString, MozartDatabase.cnxMozart)
    sqlcmdLoad.CommandType = CommandType.Text
        Return sqlcmdLoad.ExecuteScalar()

    End Function

    Private Sub BtnValid_Click(sender As Object, e As EventArgs) Handles BtnValid.Click

        Loaddata()

    End Sub

    Private Sub BtnFermer_Click(sender As Object, e As EventArgs) Handles BtnFermer.Click
        Me.Close()
    End Sub
End Class