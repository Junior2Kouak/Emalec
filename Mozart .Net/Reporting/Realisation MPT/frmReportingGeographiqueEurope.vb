Imports System.Data.SqlClient
Imports DevExpress.XtraEditors.Controls
Imports MozartLib

Public Class frmReportingGeographiqueEurope

  Dim CnxAux As New CGestionSQL
  Dim lblPourcAlsace As Object

  Private Sub frmReportingGeographiqueEurope_Load(sender As System.Object, e As System.EventArgs) Handles MyBase.Load

    'init
    initSociete()

    Dim dt, dt2 As DataTable

    Label1.Text = My.Resources.Reporting_RealisationMPT_frmReportingGeographiqueEurope_Reporting & "  " & MozartParams.NomSociete & " " & My.Resources.Global_le & " " & Date.Today

    Me.Cursor = Cursors.WaitCursor

    Try

      If CnxAux.ConnexionSQL(MozartParams.NomServeur, MozartParams.NomSociete) = False Then
        MessageBox.Show(My.Resources.Global_serveur_EMALEC, My.Resources.Global_Erreur, MessageBoxButtons.OK, MessageBoxIcon.Error)
      End If

      dt = New DataTable
      Dim cmdLoadList As New SqlCommand("SELECT CPRECOD, VPRELIB FROM TREF_PRE where langue = 'FR' union SELECT '', ' TOUTES' order by VPRELIB", CnxAux.CnxSQLOpen)
      cmdLoadList.CommandType = CommandType.Text
      dt.Load(cmdLoadList.ExecuteReader)
      ComboBoxPrest.DataSource = dt

      dt2 = New DataTable
      Dim cmdLoadList2 As New SqlCommand("SELECT CTECCOD, VTECLIB FROM TREF_TEC where langue = 'FR' union SELECT '', ' TOUTES' order by VTECLIB", CnxAux.CnxSQLOpen)
      cmdLoadList2.CommandType = CommandType.Text
      dt2.Load(cmdLoadList2.ExecuteReader)
      ComboBoxTech.DataSource = dt2

    Catch ex As Exception
      MessageBox.Show(My.Resources.Reporting_RealisationMPT_frmReportingGeographiqueEurope_sub + ex.Message, My.Resources.Global_Erreur, MessageBoxButtons.OK, MessageBoxIcon.Error)
    Finally
      Me.Cursor = Cursors.Default
    End Try

  End Sub

  Private Sub GridView1_EndSorting(sender As Object, e As System.EventArgs) Handles GridView1.EndSorting
    GridView1.MoveFirst()
  End Sub

  Private Sub ButtonExporter_Click(sender As System.Object, e As System.EventArgs) Handles ButtonExporter.Click
    Dim fileName As String = Environment.GetFolderPath(Environment.SpecialFolder.UserProfile) & "\ReportingGeographiqueEurope_" & Today.Year & Today.Month & Today.Day & "_" & TimeOfDay.Hour & TimeOfDay.Minute & ".xls"
    GCRECEPTIONS.ExportToXls(fileName)
    System.Diagnostics.Process.Start(Environment.GetFolderPath(Environment.SpecialFolder.UserProfile))
  End Sub

  Private Sub BtnFermer_Click(sender As System.Object, e As System.EventArgs) Handles BtnFermer.Click
    Me.Close()
  End Sub

  Private Sub BtnPrint_Click(sender As System.Object, e As System.EventArgs) Handles BtnPrint.Click
    GCRECEPTIONS.Print()
  End Sub

  Private Sub Button1_Click(sender As System.Object, e As System.EventArgs) Handles Button1.Click
    ' Remplir le tableau + initialiser les données sur la carte
    'Dim ds As DataSet

    Dim dts_src As New DataTable
    Dim dt_By_Soc As DataTable

    Me.Cursor = Cursors.WaitCursor

    Try
      Dim cmdLoadList As SqlCommand
      Dim ind As Int32 = 0

      For Each i As CheckedListBoxItem In CheckedComboBoxEdit1.Properties.Items

        If i.CheckState = CheckState.Checked Then

          dt_By_Soc = New DataTable
          cmdLoadList = New SqlCommand("api_sp_Reporting_Geographique_Europe", MozartDatabase.cnxMozart)
          cmdLoadList.CommandType = CommandType.StoredProcedure
          cmdLoadList.Parameters.Add("@CPRECOD", SqlDbType.Char).Value = ComboBoxPrest.SelectedValue
          cmdLoadList.Parameters.Add("@CTECCOD", SqlDbType.Char).Value = ComboBoxTech.SelectedValue
          cmdLoadList.Parameters.Add("@VSOCIETE", SqlDbType.VarChar).Value = i.Value
          dt_By_Soc.Load(cmdLoadList.ExecuteReader)

          If ind = 0 Then
            dts_src = dt_By_Soc.Copy
          Else

            For Each dts_ins As DataRow In dt_By_Soc.Rows

              dts_src.ImportRow(dts_ins)

            Next

          End If

          ind = ind + 1

        End If

      Next



      Dim CA_By_Pays = From data In dts_src
                       Group data By CodePays = data.Field(Of String)("PAYS").ToUpperInvariant Into PaysGroup = Group
                       Select New With {
                          Key CodePays,
                          .NELFTHT_TOT = PaysGroup.Sum(Function(r) r.Field(Of Decimal)("CA"))
                          }


      Dim CA_TOTAL = dts_src.Compute("SUM(CA)", "")



      'Order By data.Field(Of String)("PAYS"), data.Field(Of String)("VCLINOM")
      'Group By CountryName = data.PAYS
      'Into CustomersInCountry = Group, Count()
      'Order By CountryName



      'ds = New DataSet

      'Dim cmdLoadList As New SqlCommand("api_sp_Reporting_Geographique_Europe", CnxAux.CnxSQLOpen)
      'cmdLoadList.CommandType = CommandType.StoredProcedure
      'cmdLoadList.Parameters.Add("@CPRECOD", SqlDbType.Char).Value = ComboBoxPrest.SelectedValue
      'cmdLoadList.Parameters.Add("@CTECCOD", SqlDbType.Char).Value = ComboBoxTech.SelectedValue

      'cmdLoadList.Parameters.Add("@VSOCIETE", SqlDbType.VarChar).Value = If(CboSociete.SelectedIndex = 0, "$TS", CboSociete.SelectedItem)
      'cmdLoadList.Parameters.Add("@NPERNUM", SqlDbType.Int).Value = gintUID
      'cmdLoadList.Parameters.Add("@numMenu", SqlDbType.Int).Value = CboSociete.Tag


      'Dim sqlAdpat As SqlDataAdapter = New SqlDataAdapter(cmdLoadList)
      'sqlAdpat.Fill(ds)

      '' Données par client et région
      GCRECEPTIONS.DataSource = dts_src

      '' Données par région
      'Dim dtr As DataRow
      Dim lstRegions As New List(Of String)
      Dim lstCA As New List(Of Double)

      For Each dtr In CA_By_Pays
        lstRegions.Add(dtr.CodePays)
        lstCA.Add(dtr.NELFTHT_TOT)
      Next

      '' CA total
      'dtr = ds.Tables(2).Rows(0)
      'Dim CA_total As Double = 0 ' dtr("CA")

      lblPourcFrance.Text = alimentePourcentages(My.Resources.Global_france, CA_TOTAL, lstRegions, lstCA) & "%"
      lblPourcAngleterre.Text = alimentePourcentages(My.Resources.Global_GB, CA_TOTAL, lstRegions, lstCA) & "%"
      lblPourcAllemagne.Text = alimentePourcentages(My.Resources.Global_allemagne, CA_TOTAL, lstRegions, lstCA) & "%"
      lblPourcBelgique.Text = alimentePourcentages2pays(My.Resources.Global_belgique, "BELGIË", CA_TOTAL, lstRegions, lstCA) & "%"
      lblPourcEspagne.Text = alimentePourcentages(My.Resources.Global_espagne, CA_TOTAL, lstRegions, lstCA) & "%"
      lblPourcItalie.Text = alimentePourcentages(My.Resources.Global_italie, CA_TOTAL, lstRegions, lstCA) & "%"
      lblPourcPortugal.Text = alimentePourcentages(My.Resources.Global_portugal, CA_TOTAL, lstRegions, lstCA) & "%"
      lblPourcAutriche.Text = alimentePourcentages(My.Resources.Global_autriche, CA_TOTAL, lstRegions, lstCA) & "%"
      lblPourcDanemark.Text = alimentePourcentages(My.Resources.Global_danemark, CA_TOTAL, lstRegions, lstCA) & "%"
      lblPourcIrlande.Text = alimentePourcentages(My.Resources.Global_irlande, CA_TOTAL, lstRegions, lstCA) & "%"
      lblPourcNorvege.Text = alimentePourcentages(My.Resources.Global_norvege, CA_TOTAL, lstRegions, lstCA) & "%"
      lblPourcPaysBas.Text = alimentePourcentages(My.Resources.Global_pays_bas, CA_TOTAL, lstRegions, lstCA) & "%"
      lblPourcSuede.Text = alimentePourcentages(My.Resources.Global_suede, CA_TOTAL, lstRegions, lstCA) & "%"
      lblPourcFinlande.Text = alimentePourcentages(My.Resources.Global_finlande, CA_TOTAL, lstRegions, lstCA) & "%"
      lblPourcGrece.Text = alimentePourcentages(My.Resources.Global_grece, CA_TOTAL, lstRegions, lstCA) & "%"
      lblPourcPologne.Text = alimentePourcentages(My.Resources.Global_pologne, CA_TOTAL, lstRegions, lstCA) & "%"
      lblPourcRepTcheque.Text = alimentePourcentages(My.Resources.Global_RT, CA_TOTAL, lstRegions, lstCA) & "%"
      lblPourcSlovaquie.Text = alimentePourcentages(My.Resources.Global_slovaquie, CA_TOTAL, lstRegions, lstCA) & "%"
      lblPourcSuisse.Text = alimentePourcentages2pays(My.Resources.Global_suisse, "switzerland", CA_TOTAL, lstRegions, lstCA) & "%"
      lblPourcLuxembourg.Text = alimentePourcentages(My.Resources.Global_Luxembourg, CA_TOTAL, lstRegions, lstCA) & "%"

    Catch ex As Exception
      MessageBox.Show(My.Resources.Reporting_RealisationMPT_frmReportingGeographique_Sub + ex.Message, My.Resources.Global_Erreur, MessageBoxButtons.OK, MessageBoxIcon.Error)
    Finally
      Me.Cursor = Cursors.Default
    End Try
  End Sub

  Private Function alimentePourcentages(region As String, CATotal As Double, lstRegions As List(Of String), lstCA As List(Of Double)) As Double

    Dim pourc As Double = 0

    For i = 0 To lstRegions.Count - 1
      If lstRegions(i).ToUpper().Contains(region.ToUpper()) Then
        pourc = Math.Round(lstCA(i) / CATotal * 100, 2)
        Exit For
      End If
    Next i

    Return pourc

  End Function

  Private Function alimentePourcentages2pays(region1 As String, region2 As String, CATotal As Double, lstRegions As List(Of String), lstCA As List(Of Double)) As Double

    Dim pourc As Double = 0
    Dim pourc1 As Double = 0
    Dim pourc2 As Double = 0

    For i = 0 To lstRegions.Count - 1
      If lstRegions(i).ToUpper().Contains(region1.ToUpper()) Then
        pourc1 = Math.Round(lstCA(i) / CATotal * 100, 2)
        Exit For
      End If
    Next i

    For i = 0 To lstRegions.Count - 1
      If lstRegions(i).ToUpper().Contains(region2.ToUpper()) Then
        pourc2 = Math.Round(lstCA(i) / CATotal * 100, 2)
        Exit For
      End If
    Next i

    pourc = pourc1 + pourc2

    Return pourc

  End Function

  Private Sub Button2_Click(sender As System.Object, e As System.EventArgs) Handles Button2.Click
    ' Remplir le tableau + initialiser les données sur la carte
    Dim ds As DataSet

    Me.Cursor = Cursors.WaitCursor

    Try

      ds = New DataSet

      Dim cmdLoadList As New SqlCommand("api_sp_Reporting_Geographique_International", CnxAux.CnxSQLOpen)
      cmdLoadList.CommandType = CommandType.StoredProcedure
      cmdLoadList.Parameters.Add("@CPRECOD", SqlDbType.Char).Value = ComboBoxPrest.SelectedValue
      cmdLoadList.Parameters.Add("@CTECCOD", SqlDbType.Char).Value = ComboBoxTech.SelectedValue

      Dim sqlAdpat As SqlDataAdapter = New SqlDataAdapter(cmdLoadList)
      sqlAdpat.Fill(ds)

      ' Données par client et région
      GCRECEPTIONS.DataSource = ds.Tables(0)

      ' Données par région
      Dim dtr As DataRow
      Dim lstRegions As New List(Of String)
      Dim lstCA As New List(Of Double)

      For Each dtr In ds.Tables(1).Rows
        lstRegions.Add(dtr("PAYS").ToString)
        lstCA.Add(dtr("CA"))
      Next

      ' CA total
      dtr = ds.Tables(2).Rows(0)
      Dim CA_total As Double = dtr("CA")

      lblPourcFrance.Visible = False
      lblPourcAngleterre.Text = alimentePourcentages(My.Resources.Global_GB, CA_total, lstRegions, lstCA) & "%"
      lblPourcAllemagne.Text = alimentePourcentages(My.Resources.Global_allemagne, CA_total, lstRegions, lstCA) & "%"
      lblPourcBelgique.Text = alimentePourcentages2pays(My.Resources.Global_belgique, "BELGIË", CA_total, lstRegions, lstCA) & "%"
      lblPourcEspagne.Text = alimentePourcentages(My.Resources.Global_espagne, CA_total, lstRegions, lstCA) & "%"
      lblPourcItalie.Text = alimentePourcentages(My.Resources.Global_italie, CA_total, lstRegions, lstCA) & "%"
      lblPourcPortugal.Text = alimentePourcentages(My.Resources.Global_portugal, CA_total, lstRegions, lstCA) & "%"
      lblPourcAutriche.Text = alimentePourcentages(My.Resources.Global_autriche, CA_total, lstRegions, lstCA) & "%"
      lblPourcDanemark.Text = alimentePourcentages(My.Resources.Global_danemark, CA_total, lstRegions, lstCA) & "%"
      lblPourcIrlande.Text = alimentePourcentages(My.Resources.Global_irlande, CA_total, lstRegions, lstCA) & "%"
      lblPourcNorvege.Text = alimentePourcentages(My.Resources.Global_norvege, CA_total, lstRegions, lstCA) & "%"
      lblPourcPaysBas.Text = alimentePourcentages(My.Resources.Global_pays_bas, CA_total, lstRegions, lstCA) & "%"
      lblPourcSuede.Text = alimentePourcentages(My.Resources.Global_suede, CA_total, lstRegions, lstCA) & "%"
      lblPourcFinlande.Text = alimentePourcentages(My.Resources.Global_finlande, CA_total, lstRegions, lstCA) & "%"
      lblPourcGrece.Text = alimentePourcentages(My.Resources.Global_grece, CA_total, lstRegions, lstCA) & "%"
      lblPourcPologne.Text = alimentePourcentages(My.Resources.Global_pologne, CA_total, lstRegions, lstCA) & "%"
      lblPourcRepTcheque.Text = alimentePourcentages(My.Resources.Global_RT, CA_total, lstRegions, lstCA) & "%"
      lblPourcSlovaquie.Text = alimentePourcentages(My.Resources.Global_slovaquie, CA_total, lstRegions, lstCA) & "%"
      lblPourcSuisse.Text = alimentePourcentages2pays(My.Resources.Global_suisse, "switzerland", CA_total, lstRegions, lstCA) & "%"
      lblPourcLuxembourg.Text = alimentePourcentages(My.Resources.Global_Luxembourg, CA_total, lstRegions, lstCA) & "%"

    Catch ex As Exception
      MessageBox.Show(My.Resources.Reporting_RealisationMPT_frmReportingGeographique_Sub + ex.Message, My.Resources.Global_Erreur, MessageBoxButtons.OK, MessageBoxIcon.Error)
    Finally
      Me.Cursor = Cursors.Default
    End Try
  End Sub

  Private Sub initSociete()
    'initialisation de le combobox "Société"

    Dim CmdSql_test As New SqlCommand("SELECT DISTINCT VSOCIETE FROM TDROIT WHERE NPERNUM = " & MozartParams.UID & " AND NMENUNUM = 504 AND CDROITVAL = 'O' ORDER BY VSOCIETE", MozartDatabase.cnxMozart)
    CmdSql_test.CommandType = CommandType.Text
    Dim dt As New DataTable
    dt.Load(CmdSql_test.ExecuteReader)
    CheckedComboBoxEdit1.Properties.DataSource = dt


  End Sub

  Private Sub CboSociete_SelectedIndexChanged(sender As Object, e As EventArgs)

  End Sub
End Class