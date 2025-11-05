Imports System.Data.SqlClient
Imports MozartLib

Public Class frmSuiviAnalytiqueDI

  Dim cmd As SqlCommand
  Dim dtChif As DataTable
  Dim numDI As String

  Public Sub New(ByVal p_Param As Object)
    InitializeComponent()
    numDI = p_Param
  End Sub

  Private Sub frmSuiviAnalytiqueDI_Load(sender As System.Object, e As System.EventArgs) Handles MyBase.Load

    Try

      Me.Cursor = Cursors.WaitCursor
      lblNumDI.Text = "DI n°" & numDI

      'limité à 50 actions maximum pour calcul en live
      cmd = New SqlCommand("SELECT COUNT(NACTNUM) AS NB_ACT FROM TACT WITH (NOLOCK) WHERE TACT.NDINNUM = " & numDI, MozartDatabase.cnxMozart)
      cmd.CommandType = CommandType.Text
      Dim dr As SqlDataReader = cmd.ExecuteReader
      If dr.HasRows Then

        dr.Read()
        If dr.Item("NB_ACT") >= 50 Then
          MessageBox.Show("Le calcul du suivi analytique est trop important (plus de 50 actions dans la DI)", "Erreur", MessageBoxButtons.OK, MessageBoxIcon.Exclamation)
          Me.Close()
          Return
        End If

      End If
      dr.Close()


      cmd = New SqlCommand("api_sp_SuiviBudgetDI2", MozartDatabase.cnxMozart)
      cmd.CommandType = CommandType.StoredProcedure
      cmd.Parameters.Add("@Di", SqlDbType.Int).Value = numDI


      Dim sqlAdpat As SqlDataAdapter = New SqlDataAdapter(cmd)
      Dim dtStat As New DataSet
      sqlAdpat.Fill(dtStat)

      ' Relation entre les grid :
      GridControl1.LevelTree.Nodes(0).RelationName = "TYPEDATA"
      GridView2.ChildGridLevelName = "TYPEDATA"
      dtStat.Relations.Add("TYPEDATA", dtStat.Tables(0).Columns("TYPEDATA"), dtStat.Tables(1).Columns("TYPEDATA"))

      GridControl1.DataSource = dtStat.Tables(0)

      LabelCoeff.Text = My.Resources.Global_coeff & Math.Round(dtStat.Tables(2).Rows(0).Item(0), 2)

    Catch ex As Exception
      MessageBox.Show(My.Resources.Reporting_analytique_frmSuiviAnalytiqueDI_SubLoad + ex.Message, My.Resources.Global_Erreur)
    Finally
      Me.Cursor = Cursors.Default
    End Try
  End Sub

  Private Sub BtnPrint_Click(sender As System.Object, e As System.EventArgs) Handles BtnPrint.Click
    GridControl1.Print()
  End Sub

  Private Sub ButtonExporter_Click(sender As System.Object, e As System.EventArgs) Handles ButtonExporter.Click
    Dim fileName As String = Environment.GetFolderPath(Environment.SpecialFolder.UserProfile) & "\SuiviAnalytique_" & Today.Year & Today.Month & Today.Day & "_" & TimeOfDay.Hour & TimeOfDay.Minute & ".xls"
    GridControl1.ExportToXls(fileName)
    System.Diagnostics.Process.Start(Environment.GetFolderPath(Environment.SpecialFolder.UserProfile))
  End Sub

  Private Sub BtnFermer_Click(sender As System.Object, e As System.EventArgs) Handles BtnFermer.Click
    Me.Close()
  End Sub

End Class