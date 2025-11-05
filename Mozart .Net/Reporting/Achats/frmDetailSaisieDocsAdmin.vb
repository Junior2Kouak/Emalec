Imports System.Data.SqlClient
Imports MozartLib

Public Class frmDetailSaisieDocsAdmin

  ReadOnly oGestConnectSQL As New CGestionSQL()

  Private Sub frmDetailSaisieDocsAdmin_Load(sender As System.Object, e As EventArgs) Handles MyBase.Load

    oGestConnectSQL.ConnexionSQL(MozartParams.NomServeur, MozartParams.NomSociete)

    InitSociete()

    DTPDebut.Format = DateTimePickerFormat.Custom
    DTPDebut.CustomFormat = "    dd / MM / yyyy"

    DTPFin.Format = DateTimePickerFormat.Custom
    DTPFin.CustomFormat = "    dd / MM / yyyy"

    DTPFin.Value = Now
    DTPDebut.Value = DTPFin.Value.AddMonths(-12)

    lblPerim.Text = My.Resources.Reporting_achat_frmDetailSaisieDocsAdmin_perim
    Text = My.Resources.Reporting_achat_frmDetailsSaisieDocsAdmin_titreform

    ChargeListe()

  End Sub

  Private Sub ChargeListe()
    Try

      Cursor = Cursors.WaitCursor


      Dim CmdSql As New SqlCommand("api_sp_ListeSaisieDocsAdminParPersonne", oGestConnectSQL.CnxSQLOpen)
      CmdSql.CommandType = CommandType.StoredProcedure
      CmdSql.Parameters.Add("@dateDebut", SqlDbType.DateTime).Value = DTPDebut.Value.ToShortDateString
      CmdSql.Parameters.Add("@dateFin", SqlDbType.DateTime).Value = DTPFin.Value.ToShortDateString
      CmdSql.Parameters.Add("@societe", SqlDbType.VarChar).Value = cboSociete.SelectedItem

      Dim sqlAdapt As SqlDataAdapter = New SqlDataAdapter(CmdSql)
      Dim dtStat As New DataSet
      sqlAdapt.Fill(dtStat)

      ChartControl1.DataSource = dtStat.Tables(0)

      If cboSociete.SelectedItem <> "GROUPE" Then
        LblTitre.Text = My.Resources.Reporting_achat_frmDetailSaisieDocsAdmin_nombre_saisies & " " & DTPDebut.Value.ToShortDateString & " " &
                      My.Resources.Global_au & " " & DTPFin.Value.ToShortDateString & " " & My.Resources.Global_pour_société & " " & cboSociete.SelectedItem &
                      My.Resources.Global_le & " " & Today.Date
      Else
        LblTitre.Text = My.Resources.Reporting_achat_frmDetailSaisieDocsAdmin_nombre_saisies & " " & DTPDebut.Value.ToShortDateString & " " &
                              My.Resources.Global_au & " " & DTPFin.Value.ToShortDateString & " " & My.Resources.global_pour_groupe & "EMALEC" & " " &
                              My.Resources.Global_le & " " & Today.Date

      End If

      CmdSql.Dispose()

    Catch ex As Exception
      MessageBox.Show(My.Resources.Reporting_achat_frmDetailSaisieDocsAdmin_sub + ex.Message, My.Resources.Global_Erreur)
    Finally
      Cursor = Cursors.Default
    End Try
  End Sub


  'Initialisation de le combobox répertoriant les sociétés du groupe EMALEC.
  Private Sub InitSociete()

    Dim i As Integer = 0

    Dim CmdSql As New SqlCommand("SELECT DISTINCT VSOCIETE FROM TDROIT WHERE NPERNUM = " & MozartParams.UID & " AND NMENUNUM = " & cboSociete.Tag & " AND CDROITVAL = 'O' ORDER BY VSOCIETE", oGestConnectSQL.CnxSQLOpen)
    Dim dr As SqlDataReader = CmdSql.ExecuteReader
    While dr.Read()
      cboSociete.Items.Add(dr("VSOCIETE"))
      i = i + 1
    End While

    'Plusieurs sociétés : on peut gérer le "groupe"
    If i > 1 Then
      cboSociete.Items.Add("GROUPE")
      cboSociete.SelectedItem = MozartParams.NomSociete
      Label4.Visible = True
      cboSociete.Visible = True
    Else
      cboSociete.SelectedIndex = 0
    End If

    dr.Close()
    CmdSql.Dispose()
    dr = Nothing

  End Sub

  Private Sub BtnFermer_Click(sender As System.Object, e As EventArgs) Handles BtnFermer.Click
    Close()
  End Sub

  Private Sub BtnPrint_Click(sender As System.Object, e As EventArgs) Handles BtnPrint.Click
    Dim oScreenShot As New CSreenShot(Me, True)
    oScreenShot.Print_Form()
  End Sub

  Private Sub BtValider_Click(sender As System.Object, e As EventArgs) Handles BtValider.Click
    ChargeListe()
  End Sub

  Private Sub frmDetailSaisieDocsAdmin_FormClosed(ByVal sender As Object, ByVal e As System.Windows.Forms.FormClosedEventArgs) Handles Me.FormClosed

    oGestConnectSQL.CloseConnexionSQL()

  End Sub

End Class