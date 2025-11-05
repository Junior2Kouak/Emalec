Imports System.Data.SqlClient
Imports MozartLib

Public Class frmDevisAFaireDetails

  Dim strName, strCle, strRequete As String
  Dim CnxAux As New CGestionSQL

  Public Sub New(ByVal p_Param As Object, Type_req As String)

    InitializeComponent()
    strName = p_Param(2)
    strCle = p_Param(3)
    strRequete = Type_req

  End Sub
  Private Sub frmDevisAFaireDetails_Load(sender As System.Object, e As System.EventArgs) Handles MyBase.Load

    Dim ds As DataSet

    Me.Cursor = Cursors.WaitCursor

    Try

      If CnxAux.ConnexionSQL(MozartParams.NomServeur, MozartParams.NomSociete) = False Then
        MessageBox.Show(My.Resources.Global_serveur_EMALEC, My.Resources.Global_Erreur, MessageBoxButtons.OK, MessageBoxIcon.Error)
      End If

      If strRequete = "CHAFF" Then
        GCRECEPTIONS.Width = 1070
        GridView1.Columns.ColumnByName("GridColumn1").Caption = My.Resources.Global_N_Devis
        GridView1.Columns.ColumnByName("GridColumn1").Width = 80
        GridView1.Columns.ColumnByName("GridColumn1").AppearanceCell.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center
        GridView1.Columns.ColumnByName("GridColumn2").Caption = My.Resources.Global_CLient
        GridView1.Columns.ColumnByName("GridColumn2").Width = 200
        GridView1.Columns.ColumnByName("GridColumn3").Caption = My.Resources.Global_date_Devis
        GridView1.Columns.ColumnByName("GridColumn3").Width = 90
        GridView1.Columns.ColumnByName("GridColumn3").AppearanceCell.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center
        GridView1.Columns.ColumnByName("GridColumn4").Caption = My.Resources.Global_sujet_Devis
        GridView1.Columns.ColumnByName("GridColumn4").Width = 300
        GridView1.Columns.ColumnByName("GridColumn5").Caption = My.Resources.Global_desc_Devis

        GridControl1.Width = 1070
        GridView2.Columns.ColumnByName("GridColumn6").Caption = "N° DI"
        GridView2.Columns.ColumnByName("GridColumn6").Width = 80
        GridView2.Columns.ColumnByName("GridColumn6").AppearanceCell.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center
        GridView2.Columns.ColumnByName("GridColumn7").Caption = My.Resources.Global_CLient
        GridView2.Columns.ColumnByName("GridColumn7").Width = 200
        GridView2.Columns.ColumnByName("GridColumn8").Caption = My.Resources.Global_site
        GridView2.Columns.ColumnByName("GridColumn8").Width = 200
        GridView2.Columns.ColumnByName("GridColumn9").Caption = My.Resources.Global_date_action
        GridView2.Columns.ColumnByName("GridColumn9").Width = 90
        GridView2.Columns.ColumnByName("GridColumn9").AppearanceCell.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center
        GridView2.Columns.ColumnByName("GridColumn10").Caption = My.Resources.Global_desc_action
      ElseIf strRequete = "CLIENT" Then
        GCRECEPTIONS.Width = 1070
        GridView1.Columns.ColumnByName("GridColumn1").Caption = My.Resources.Global_N_Devis
        GridView1.Columns.ColumnByName("GridColumn1").Width = 80
        GridView1.Columns.ColumnByName("GridColumn1").AppearanceCell.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center
        GridView1.Columns.ColumnByName("GridColumn2").Caption = My.Resources.Global_site
        GridView1.Columns.ColumnByName("GridColumn2").Width = 200
        GridView1.Columns.ColumnByName("GridColumn3").Caption = My.Resources.Global_date_Devis
        GridView1.Columns.ColumnByName("GridColumn3").Width = 90
        GridView1.Columns.ColumnByName("GridColumn3").AppearanceCell.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center
        GridView1.Columns.ColumnByName("GridColumn4").Caption = My.Resources.Global_sujet_Devis
        GridView1.Columns.ColumnByName("GridColumn4").Width = 300
        GridView1.Columns.ColumnByName("GridColumn5").Caption = My.Resources.Global_desc_Devis


        GridControl1.Width = 1070
        GridView2.Columns.ColumnByName("GridColumn6").Caption = "N° DI"
        GridView2.Columns.ColumnByName("GridColumn6").Width = 80
        GridView2.Columns.ColumnByName("GridColumn6").AppearanceCell.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center
        GridView2.Columns.ColumnByName("GridColumn7").Caption = ""
        GridView2.Columns.ColumnByName("GridColumn7").Width = 0
        GridView2.Columns.ColumnByName("GridColumn7").Visible = False
        GridView2.Columns.ColumnByName("GridColumn8").Caption = My.Resources.Global_site
        GridView2.Columns.ColumnByName("GridColumn8").Width = 200
        GridView2.Columns.ColumnByName("GridColumn9").Caption = My.Resources.Global_date_action
        GridView2.Columns.ColumnByName("GridColumn9").Width = 90
        GridView2.Columns.ColumnByName("GridColumn9").AppearanceCell.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center
        GridView2.Columns.ColumnByName("GridColumn10").Caption = My.Resources.Global_desc_action
      End If

      ds = New DataSet

      LabelDetail.Text = strName
      Dim cmdLoadList As New SqlCommand("api_sp_StatDevisAFaireDetails", CnxAux.CnxSQLOpen)
      cmdLoadList.CommandType = CommandType.StoredProcedure
      cmdLoadList.Parameters.Add("@cle", SqlDbType.Int).Value = strCle
      cmdLoadList.Parameters.Add("@requete", SqlDbType.VarChar).Value = strRequete

      Dim sqlAdpat As SqlDataAdapter = New SqlDataAdapter(cmdLoadList)
      sqlAdpat.Fill(ds)

      GCRECEPTIONS.DataSource = ds.Tables(0)
      GridControl1.DataSource = ds.Tables(1)

    Catch ex As Exception
      MessageBox.Show(My.Resources.Reporting_Devis_frmDevisAFaire_SubDevisLoad + ex.Message, My.Resources.Global_Erreur, MessageBoxButtons.OK, MessageBoxIcon.Error)
    Finally
      Me.Cursor = Cursors.Default
    End Try

  End Sub

  Private Sub BtnFermer_Click(sender As System.Object, e As System.EventArgs) Handles BtnFermer.Click
    Me.Close()
  End Sub

  Private Sub BtnPrint_Click(sender As System.Object, e As System.EventArgs) Handles BtnPrint.Click
    GCRECEPTIONS.Print()
  End Sub

  Private Sub ButtonExporter_Click(sender As System.Object, e As System.EventArgs) Handles ButtonExporter.Click
    Dim fileName As String = Environment.GetFolderPath(Environment.SpecialFolder.UserProfile) & "\StatsDevisAFaire1_" & LabelDetail.Text & "_" & Today.Year & Today.Month & Today.Day & "_" & TimeOfDay.Hour & TimeOfDay.Minute & ".xls"
    GCRECEPTIONS.ExportToXls(fileName)
    System.Diagnostics.Process.Start(Environment.GetFolderPath(Environment.SpecialFolder.UserProfile))
  End Sub

  Private Sub Button2_Click(sender As System.Object, e As System.EventArgs) Handles Button2.Click
    GridControl1.Print()
  End Sub

  Private Sub Button1_Click(sender As System.Object, e As System.EventArgs) Handles Button1.Click
    Dim fileName As String = Environment.GetFolderPath(Environment.SpecialFolder.UserProfile) & "\StatsDevisAFaire2_" & LabelDetail.Text & "_" & Today.Year & Today.Month & Today.Day & "_" & TimeOfDay.Hour & TimeOfDay.Minute & ".xls"
    GridControl1.ExportToXls(fileName)
    System.Diagnostics.Process.Start(Environment.GetFolderPath(Environment.SpecialFolder.UserProfile))
  End Sub
End Class