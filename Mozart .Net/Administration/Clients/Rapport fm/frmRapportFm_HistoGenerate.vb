Imports MozartLib

Public Class frmRapportFm_HistoGenerate

  Dim _NIDRAPPORT_FM_CLI As Int32

  Public Sub New(ByVal Tilte As String, ByVal c_NIDRAPPORT_FM_CLI As Int32)
    ' Cet appel est requis par le concepteur.
    InitializeComponent()
    ' Ajoutez une initialisation quelconque après l'appel InitializeComponent().
    Me.Text = Tilte
    _NIDRAPPORT_FM_CLI = c_NIDRAPPORT_FM_CLI

  End Sub

  Private Sub frmRapportFm_HistoGenerate_Load(sender As Object, e As EventArgs) Handles MyBase.Load

    Dim DtHistoGenerate As New DataTable
    Dim sqlcmd As New SqlClient.SqlCommand("[api_sp_Rapport_FM_ListeHistoGenerate]", MozartDatabase.cnxMozart)
    sqlcmd.CommandType = CommandType.StoredProcedure
        sqlcmd.Parameters.Add("@P_NIDRAPPORT_FM_CLI", SqlDbType.Int).Value = _NIDRAPPORT_FM_CLI
        DtHistoGenerate.Load(sqlcmd.ExecuteReader)
        GCListeRapportFM.DataSource = DtHistoGenerate

    End Sub
End Class