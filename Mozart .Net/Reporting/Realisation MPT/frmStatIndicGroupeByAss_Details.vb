Imports System.Data.SqlClient
Imports MozartLib

Public Class frmStatIndicGroupeByAss_Details
  Dim strName, strNPERNUM As String
  Dim iTypeDetail As Int32
  Dim CnxAux As New CGestionSQL

  Dim _DateDebut As String
  Dim _DateFin As String

  Public Sub New(ByVal p_Param As Object, ByVal typeDetail As Int32, ByVal c_DateDebut As String, ByVal c_DateFin As String)

    InitializeComponent()
    strName = p_Param(1)
    strNPERNUM = p_Param(2)
    _DateDebut = c_DateDebut
    _DateFin = c_DateFin
    iTypeDetail = typeDetail

  End Sub

  Private Sub frmStatChefGroupeDetails_Load(sender As System.Object, e As System.EventArgs) Handles MyBase.Load

    Dim ds As DataSet

    Me.Cursor = Cursors.WaitCursor

    Select Case iTypeDetail
      Case 1 : LabelType.Text = My.Resources.Reporting_RealisationMPT_frmStatIndicGroupeByAss_Details_NbrDiCree
      Case 2 : LabelType.Text = My.Resources.Reporting_RealisationMPT_frmStatIndicGroupeByAss_Details_NbrDSTCree
      Case 3 : LabelType.Text = My.Resources.Reporting_RealisationMPT_frmStatIndicGroupeByAss_Details_NbrDCLCree
      Case 4 : LabelType.Text = My.Resources.Reporting_RealisationMPT_frmStatIndicGroupeByAss_Details_NbrPlanif
      Case 5 : LabelType.Text = My.Resources.Reporting_RealisationMPT_frmStatIndicGroupeByAss_Details_NbrCSTCree
      Case 6 : LabelType.Text = My.Resources.Reporting_RealisationMPT_frmStatIndicGroupeByAss_Details_NbrTraiteTablet
    End Select

    '1-	Nbr DI créé
    '2-	Nbr de demande de devis créé
    '3-	Nbr de devis client créé
    '4-	Nbr de planification technicien réalisé
    '5-	Nbr de contrat de STT créé
    '6-	Nbr traitement tablette réalisé


    If iTypeDetail = 1 Then
      GCRECEPTIONS.Width = 970
      GridView1.Columns.ColumnByName("col1").Caption = "N° DI"
      GridView1.Columns.ColumnByName("col1").Width = 80
      GridView1.Columns.ColumnByName("col1").AppearanceCell.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Default
      GridView1.Columns.ColumnByName("col2").Caption = My.Resources.Global_desc_action
      GridView1.Columns.ColumnByName("col2").Width = 400
      GridView1.Columns.ColumnByName("col3").AppearanceCell.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center
      GridView1.Columns.ColumnByName("col3").Caption = My.Resources.Global_date_action
      GridView1.Columns.ColumnByName("col3").Width = 90
      GridView1.Columns.ColumnByName("col4").AppearanceCell.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center
      GridView1.Columns.ColumnByName("col4").Caption = My.Resources.Global_CLient
      GridView1.Columns.ColumnByName("col4").Width = 200
      GridView1.Columns.ColumnByName("col5").AppearanceCell.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center
      GridView1.Columns.ColumnByName("col5").Caption = My.Resources.Global_site
      GridView1.Columns.ColumnByName("col5").Width = 200
      GridView1.Columns.ColumnByName("col6").Caption = ""
      GridView1.Columns.ColumnByName("col6").Visible = False

    ElseIf iTypeDetail = 2 Then
      GCRECEPTIONS.Width = 1070
      GridView1.Columns.ColumnByName("col1").Caption = "N° DI"
      GridView1.Columns.ColumnByName("col1").Width = 80
      GridView1.Columns.ColumnByName("col1").AppearanceCell.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Default
      GridView1.Columns.ColumnByName("col2").Caption = My.Resources.Global_desc_action
      GridView1.Columns.ColumnByName("col2").Width = 400
      GridView1.Columns.ColumnByName("col3").AppearanceCell.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center
      GridView1.Columns.ColumnByName("col3").Caption = My.Resources.Global_date_crea_DST
      GridView1.Columns.ColumnByName("col3").Width = 90
      GridView1.Columns.ColumnByName("col4").AppearanceCell.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center
      GridView1.Columns.ColumnByName("col4").Caption = My.Resources.Global_CLient
      GridView1.Columns.ColumnByName("col4").Width = 200
      GridView1.Columns.ColumnByName("col5").AppearanceCell.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center
      GridView1.Columns.ColumnByName("col5").Caption = My.Resources.Global_site
      GridView1.Columns.ColumnByName("col5").Width = 200
      GridView1.Columns.ColumnByName("col6").Caption = ""
      GridView1.Columns.ColumnByName("col6").Width = 100
      GridView1.Columns.ColumnByName("col6").Visible = False

    ElseIf iTypeDetail = 3 Then
      GCRECEPTIONS.Width = 870
      GridView1.Columns.ColumnByName("col1").Caption = "N° DI"
      GridView1.Columns.ColumnByName("col1").Width = 80
      GridView1.Columns.ColumnByName("col2").Caption = My.Resources.Global_desc_action
      GridView1.Columns.ColumnByName("col2").Width = 300
      GridView1.Columns.ColumnByName("col3").AppearanceCell.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center
      GridView1.Columns.ColumnByName("col3").Caption = My.Resources.Global_date_Devis
      GridView1.Columns.ColumnByName("col3").Width = 120
      GridView1.Columns.ColumnByName("col4").AppearanceCell.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center
      GridView1.Columns.ColumnByName("col4").Caption = My.Resources.Global_CLient
      GridView1.Columns.ColumnByName("col4").Width = 200
      GridView1.Columns.ColumnByName("col5").AppearanceCell.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center
      GridView1.Columns.ColumnByName("col5").Caption = My.Resources.Global_site
      GridView1.Columns.ColumnByName("col5").Width = 200
      GridView1.Columns.ColumnByName("col6").Caption = My.Resources.Global_montant
      GridView1.Columns.ColumnByName("col6").Width = 120

    ElseIf iTypeDetail = 4 Then
      GCRECEPTIONS.Width = 770
      GridView1.Columns.ColumnByName("col1").Caption = "N° DI"
      GridView1.Columns.ColumnByName("col1").Width = 80
      GridView1.Columns.ColumnByName("col2").Caption = My.Resources.Global_desc_action
      GridView1.Columns.ColumnByName("col2").Width = 280
      GridView1.Columns.ColumnByName("col3").AppearanceCell.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center
      GridView1.Columns.ColumnByName("col3").Caption = My.Resources.Global_CLient
      GridView1.Columns.ColumnByName("col3").Width = 170
      GridView1.Columns.ColumnByName("col4").AppearanceCell.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center
      GridView1.Columns.ColumnByName("col4").Caption = My.Resources.Global_site
      GridView1.Columns.ColumnByName("col4").Width = 170
      GridView1.Columns.ColumnByName("col5").AppearanceCell.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center
      GridView1.Columns.ColumnByName("col5").Caption = My.Resources.Global_date_planification
      GridView1.Columns.ColumnByName("col5").Width = 160
      GridView1.Columns.ColumnByName("col6").Visible = False


    ElseIf iTypeDetail = 5 Then
      GCRECEPTIONS.Width = 770
      GridView1.Columns.ColumnByName("col1").Caption = "N° DI"
      GridView1.Columns.ColumnByName("col1").Width = 80
      GridView1.Columns.ColumnByName("col2").AppearanceCell.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center
      GridView1.Columns.ColumnByName("col2").Caption = My.Resources.Global_num_contrat
      GridView1.Columns.ColumnByName("col2").Width = 90
      GridView1.Columns.ColumnByName("col3").AppearanceCell.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center
      GridView1.Columns.ColumnByName("col3").Caption = My.Resources.Global_CLient
      GridView1.Columns.ColumnByName("col3").Width = 200
      GridView1.Columns.ColumnByName("col4").AppearanceCell.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center
      GridView1.Columns.ColumnByName("col4").Caption = My.Resources.Global_site
      GridView1.Columns.ColumnByName("col4").Width = 200
      GridView1.Columns.ColumnByName("col5").AppearanceCell.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center
      GridView1.Columns.ColumnByName("col5").Caption = My.Resources.Global_date_contrat
      GridView1.Columns.ColumnByName("col5").Visible = True
      GridView1.Columns.ColumnByName("col5").Width = 200
      GridView1.Columns.ColumnByName("col6").Caption = My.Resources.Global_montant
      GridView1.Columns.ColumnByName("col6").Width = 200

    ElseIf iTypeDetail = 6 Then
      GCRECEPTIONS.Width = 770
      GridView1.Columns.ColumnByName("col1").Caption = "N° DI"
      GridView1.Columns.ColumnByName("col1").Width = 80
      GridView1.Columns.ColumnByName("col2").Caption = My.Resources.Global_desc_action
      GridView1.Columns.ColumnByName("col2").Width = 300
      GridView1.Columns.ColumnByName("col3").AppearanceCell.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center
      GridView1.Columns.ColumnByName("col3").Caption = My.Resources.Global_CLient
      GridView1.Columns.ColumnByName("col3").Width = 200
      GridView1.Columns.ColumnByName("col4").AppearanceCell.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center
      GridView1.Columns.ColumnByName("col4").Caption = My.Resources.Global_site
      GridView1.Columns.ColumnByName("col4").Width = 200
      GridView1.Columns.ColumnByName("col5").AppearanceCell.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center
      GridView1.Columns.ColumnByName("col5").Caption = My.Resources.Global_date_reception
      GridView1.Columns.ColumnByName("col5").Visible = True
      GridView1.Columns.ColumnByName("col5").Width = 120
      GridView1.Columns.ColumnByName("col6").Caption = ""
      GridView1.Columns.ColumnByName("col6").Width = 200
      GridView1.Columns.ColumnByName("col6").Visible = False
    End If

    Try

      If CnxAux.ConnexionSQL(MozartParams.NomServeur, MozartParams.NomSociete) = False Then
        MessageBox.Show(My.Resources.Global_serveur_EMALEC, My.Resources.Global_Erreur, MessageBoxButtons.OK, MessageBoxIcon.Error)
      End If

      ds = New DataSet

      LabelDetail.Text = strName
      Dim cmdLoadList As New SqlCommand("[api_sp_StatIndicGroupeByAss_Details]", CnxAux.CnxSQLOpen)
      cmdLoadList.CommandType = CommandType.StoredProcedure
      cmdLoadList.Parameters.Add("@npernum", SqlDbType.Int).Value = strNPERNUM
      cmdLoadList.Parameters.Add("@typeDetail", SqlDbType.Int).Value = iTypeDetail
      cmdLoadList.Parameters.Add("@p_datedebut", SqlDbType.DateTime).Value = _DateDebut
      cmdLoadList.Parameters.Add("@p_datefin", SqlDbType.DateTime).Value = _DateFin
      cmdLoadList.Parameters.Add("@vsociete", SqlDbType.VarChar).Value = MozartParams.NomSociete


      Dim sqlAdpat As SqlDataAdapter = New SqlDataAdapter(cmdLoadList)
      sqlAdpat.Fill(ds)

      GCRECEPTIONS.DataSource = ds.Tables(0)

    Catch ex As Exception
      MessageBox.Show(My.Resources.Reporting_RealisationMPT_frmStatChefGroupeDetails_sub + ex.Message, My.Resources.Global_Erreur, MessageBoxButtons.OK, MessageBoxIcon.Error)
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
    Dim fileName As String = Environment.GetFolderPath(Environment.SpecialFolder.UserProfile) & "\StatsChefGroupe_" & Today.Year & Today.Month & Today.Day & "_" & TimeOfDay.Hour & TimeOfDay.Minute & ".xlsx"
    GCRECEPTIONS.ExportToXlsx(fileName)
    System.Diagnostics.Process.Start(Environment.GetFolderPath(Environment.SpecialFolder.UserProfile))
  End Sub
End Class