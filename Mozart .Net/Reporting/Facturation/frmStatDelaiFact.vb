
Imports System.Data.SqlClient
Imports DevExpress.XtraCharts
Imports MozartLib

Public Class frmStatDelaiFact

  Dim oGestConnectSQL As New CGestionSQL
  Dim dtStatKMS As DataTable
  Dim dtStat As DataTable

    Public iTypeStat As Int32

    Private Sub frmStatDelaiFact_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Me.Load

    Try
      'on ouvre la connexion
      If oGestConnectSQL.ConnexionSQL(MozartParams.NomServeur, MozartParams.NomSociete) = True Then

        initSociete()

        DTPFin.Value = "01/" + Now.Month.ToString + "/" + Now.Year.ToString
        DTPDebut.Value = DTPFin.Value.AddMonths(-12)
        DTPFin.Value = DTPFin.Value.AddDays(-1)

        LoadStat()

      End If

    Catch ex As Exception
      MessageBox.Show(My.Resources.Reporting_Facturation_frmStatDetailFact_Sub1 + ex.Message, My.Resources.Global_Erreur)
    End Try

  End Sub

  Private Sub initSociete()
    'initialisation de le combobox "Société"
    Dim i As Integer = 0

    Dim CmdSql As New SqlCommand("SELECT DISTINCT VSOCIETE FROM TDROIT WHERE NPERNUM = " & MozartParams.UID & " AND NMENUNUM = " & ComboBox1.Tag & " AND CDROITVAL = 'O' ORDER BY VSOCIETE", MozartDatabase.cnxMozart)
    Dim dr As SqlDataReader = CmdSql.ExecuteReader
      While dr.Read() 'While données présentes, stocker les éléments en combobox
        ComboBox1.Items.Add(dr("VSOCIETE"))
        i = i + 1
      End While

      If i > 1 Then
        ' Plusieurs société : on peut gérer le "groupe"   ' libellé "toutes sociétés
        ComboBox1.Items.Insert(0, My.Resources.Reporting_Facturation_frmStatFacturationCa_toutesociété)
        ComboBox1.SelectedItem = MozartParams.NomSociete
        ComboBox1.Visible = True
      End If

      ComboBox1.SelectedIndex = 0

      dr.Close()
      CmdSql.Dispose()
      dr = Nothing

  End Sub

  Private Sub BtnValid_Click(sender As System.Object, e As System.EventArgs) Handles BtnValid.Click
    LoadStat()
  End Sub

  Private Sub LoadStat()

    Try

            dtStatKMS = New DataTable

            If iTypeStat = 1 Then 'delai par facturation

                LblTitre.Text = "Taux de délai de facturation"

                lblObj.Text = "Objectif qualité : >80% sous 6 semaines"

                dtStatKMS = ModDataGridView.LoadList(String.Format("api_sp_StatIndicaFacturation '{0}','{1}','{2}',{3},{4}", DTPDebut.Value.ToShortDateString, DTPFin.Value.ToShortDateString, ComboBox1.Text, ComboBox1.Tag, MozartParams.UID), oGestConnectSQL.CnxSQLOpen)

            ElseIf iTypeStat = 2 Then 'delai par chiffrage

                LblTitre.Text = "Taux de délai de chiffrage"
                lblObj.Text = "Objectif qualité : >95% sous 4 semaines"

                dtStatKMS = ModDataGridView.LoadList(String.Format("[api_sp_StatIndicaFacturation_Delai_EXE_ChifCree] '{0}','{1}','{2}',{3},{4}", DTPDebut.Value.ToShortDateString, DTPFin.Value.ToShortDateString, ComboBox1.Text, ComboBox1.Tag, MozartParams.UID), oGestConnectSQL.CnxSQLOpen)

            End If
            Me.Text = LblTitre.Text
            lblPerim.Text = My.Resources.Reporting_Facturation_frmStatDetailFact_Rapport & vbCrLf

      GCStat.DataSource = dtStatKMS
      ChartCtrl.DataSource = dtStatKMS

      ' moyenne sur les 12 dernier mois
      lblMoy12.Text = My.Resources.Reporting_Facturation_frmStatDetailFact_Resultat & FormatNumber(dtStatKMS.Rows(0).Item(2), 1) & " %"

    Catch ex As Exception
      MessageBox.Show(My.Resources.Reporting_Facturation_frmStatDetailFact_Sub2 + ex.Message, My.Resources.Global_Erreur)
    End Try
  End Sub

  Private Function CalculMoyenne12() As Decimal

    Dim j As Integer
    CalculMoyenne12 = 0

    For j = 0 To 11
      CalculMoyenne12 += dtStat.Rows(j).Item(0)
    Next

    Return CalculMoyenne12 / 12
  End Function

  Private Sub BtnPrint_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles BtnPrint.Click
    Dim oScreenShot As New CSreenShot(Me, True)
    oScreenShot.Print_Form()
  End Sub

  Private Sub BtnFermer_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles BtnFermer.Click
    Me.Close()
  End Sub

  Private Sub frmStatDelaiFact_FormClosed(ByVal sender As Object, ByVal e As System.Windows.Forms.FormClosedEventArgs) Handles Me.FormClosed
    oGestConnectSQL.CloseConnexionSQL()
  End Sub

End Class
