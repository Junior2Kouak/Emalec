Imports System.Data.SqlClient
Imports MozartLib

Public Class frmStatTauxConformiteDetails

  Dim annee As String
  Dim mois As String
  Dim TypeRequete As String

  Public Sub New(ByVal p_Param As Object, ByVal titre As String, ByVal _TypeRequete As String)

    InitializeComponent()
    annee = p_Param(1).ToString.Substring(0, 4)
    mois = p_Param(1).ToString.Substring(5)
    LblTitre.Text = titre & My.Resources.Reporting_RH_FrmstatTauxConformiteDetails_mois & mois & "/" & annee & My.Resources.Global_le & Today()
    TypeRequete = _TypeRequete

  End Sub

  Private Sub frmStatTauxConformiteDetails_Load(sender As System.Object, e As System.EventArgs) Handles MyBase.Load

    Dim NIDPROCESS As String

    If TypeRequete = "R" Then
      NIDPROCESS = "9"
    ElseIf TypeRequete = "G" Then
      NIDPROCESS = "3"
    ElseIf TypeRequete = "C" Then
      NIDPROCESS = "8"
    ElseIf TypeRequete = "M" Then
      NIDPROCESS = "6"
    Else
      Exit Sub
    End If

    Try

      Dim CmdSql As New SqlCommand("api_sp_StatQualTauxConf_Details", MozartDatabase.cnxMozart)
      CmdSql.CommandType = CommandType.StoredProcedure
      CmdSql.Parameters.Add("@mois", SqlDbType.Int).Value = mois
      CmdSql.Parameters.Add("@annee", SqlDbType.Int).Value = annee
      CmdSql.Parameters.Add("@NIDPROCESS", SqlDbType.Int).Value = NIDPROCESS

      Dim sqlAdapt As SqlDataAdapter = New SqlDataAdapter(CmdSql)
      Dim dtStat As New DataSet
      sqlAdapt.Fill(dtStat)

      ChartBas.DataSource = dtStat.Tables(0)

      CmdSql.Dispose()

    Catch ex As Exception
      MessageBox.Show(My.Resources.Reporting_RH_FrmstatTauxConformiteDetails_sub + ex.Message, My.Resources.Global_Erreur)
        End Try

  End Sub

  Private Sub BtnFermer_Click(sender As System.Object, e As System.EventArgs) Handles BtnFermer.Click
    Me.Close()
  End Sub

  Private Sub BtnPrint_Click(sender As System.Object, e As System.EventArgs) Handles BtnPrint.Click
    Dim oScreenShot As New CSreenShot(Me, True)
    oScreenShot.Print_Form()
  End Sub
End Class