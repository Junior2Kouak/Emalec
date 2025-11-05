Imports System.Data.SqlClient
Imports MozartLib

Public Class frmDetailsTelephone

  Dim calendar_open As String = ""

  Private Sub frmDetailsTelephone_Load(ByVal sender As Object, ByVal e As EventArgs) Handles MyBase.Load

    'Initialisation des sociétés dans la combobox
    initSociete()


    Dim dr As SqlDataReader
    Dim CmdSql

    ' Liste du personnel
    Dim sSQL As String = String.Format("select NPERNUM, VPERNOM + ' ' + VPERPRE AS VPERNOMPRENOM from TPER WHERE VSOCIETE = '{0}' AND CPERACTIF='O' UNION select 0, ' ' ", LabelSociete.Text)
    sSQL = sSQL & " order by VPERNOM  +  ' ' + VPERPRE "

    Dim dt As New DataTable
    Dim dsCond As SqlDataAdapter = New SqlDataAdapter(sSQL, MozartDatabase.cnxMozart)
    dsCond.Fill(dt)
    cboUtil.DataSource = dt
    dsCond.Dispose()

    If IsNumeric(LabelNTELNUM.Text) Then
      ' Mode modification
      Try

        Cursor = Cursors.WaitCursor
        'on ouvre la connexion
        If MozartDatabase.cnxMozart.State = ConnectionState.Open Then

          ' Données générales
          CmdSql = New SqlCommand("api_sp_DetailTelephone", MozartDatabase.cnxMozart)
          CmdSql.CommandType = CommandType.StoredProcedure
          CmdSql.Parameters.Add("@iNumTel", SqlDbType.Int).Value = LabelNTELNUM.Text
          CmdSql.Parameters.Add("@vsociete", SqlDbType.VarChar).Value = LabelSociete.Text

          Dim utilisateur As String = ""
          dr = CmdSql.ExecuteReader
          If dr.HasRows = True Then
            dr.Read()
            CboSociete.SelectedItem = dr("VSOCIETE").ToString
            TxtNum.Text = dr("NTELNUM").ToString
            txtNumSIM.Text = dr("VTELSIM").ToString
            txtNumAppel.Text = dr("VTELNUM").ToString
            txtNumCode.Text = dr("VTELCODE").ToString
            txtMateriel.Text = dr("VTELMAT").ToString
            txtDtEntree.Text = formateDate(dr("DTELDATE").ToString)
            txtObs.Text = dr("VTELOBS").ToString
            cboProf.SelectedItem = dr("VTELPROFIL").ToString
            utilisateur = dr("VTELUTIL").ToString
            TxtOperateur.Text = dr("VTELOP").ToString
            TxtDteEngagement.Text = formateDate(dr("DTELENGOP").ToString)
          End If
          dr.Close()
          CmdSql.Dispose()

          ' Valorisation des combobox
          Dim trouve As Boolean = False
          For i = 0 To cboUtil.Items.Count - 1
            cboUtil.SelectedIndex = i
            If cboUtil.Text.ToUpper = utilisateur.ToUpper Then
              trouve = True
              Exit For
            End If
          Next i
          If trouve = False Then
            cboUtil.SelectedIndex = -1
            If utilisateur.Trim <> "" Then MsgBox(My.Resources.Admin_frmDetailsTelephone_valeur_user & utilisateur, MsgBoxStyle.Exclamation + MsgBoxStyle.OkOnly, My.Resources.Global_Erreur_maj)
          End If

        End If

      Catch ex As Exception
        MessageBox.Show(My.Resources.Admin_frmDetailsTelephone_SubLoad + ex.Message, My.Resources.Global_Erreur)
      Finally
        Cursor = Cursors.Default
        dr = Nothing
        CmdSql = Nothing
      End Try
    End If
  End Sub

  Private Shared Function formateDate(ByVal chaine As String) As String
    Dim newChaine As String = ""

    If chaine.Trim().Equals("") Then
      Return ""
    Else
      newChaine = chaine.Substring(0, 10)
    End If

    Return newChaine
  End Function

  Private Sub BtnFermer_Click(ByVal sender As Object, ByVal e As EventArgs) Handles BtnFermer.Click
    Close()
  End Sub

  Private Sub BtnDate1_Click(ByVal sender As Object, ByVal e As EventArgs) Handles BtnDate1.Click
    If MonthCalendar1.Visible Then
      calendar_open = ""
      MonthCalendar1.Visible = False
    Else
      calendar_open = "ENTREE"
      MonthCalendar1.Visible = True
    End If
  End Sub

  Private Sub BtnDateEngagement_Click(ByVal sender As Object, ByVal e As EventArgs) Handles BtnDateEngagement.Click

    If MonthCalendar1.Visible Then
      calendar_open = ""
      MonthCalendar1.Visible = False
    Else
      calendar_open = "ENGAGEMENT"
      MonthCalendar1.Visible = True
    End If
  End Sub

  Private Sub MonthCalendar1_DateSelected(ByVal sender As Object, ByVal e As DateRangeEventArgs) Handles MonthCalendar1.DateSelected

    Select Case calendar_open
      Case "ENTREE"
        txtDtEntree.Text = MonthCalendar1.SelectionStart.Date
      Case "ENGAGEMENT"
        TxtDteEngagement.Text = MonthCalendar1.SelectionStart.Date
      Case Else
        Exit Select

    End Select

    MonthCalendar1.Visible = False
  End Sub

  Private Sub txtObs_GotFocus(ByVal sender As Object, ByVal e As EventArgs) Handles txtObs.GotFocus
    Dim aux As String = String.Format("{0} le {1} : ", MozartParams.strUID, Today.ToShortDateString)
    txtObs.Text = aux & vbCrLf & txtObs.Text
  End Sub

  Private Sub BtnSupp1_Click(ByVal sender As Object, ByVal e As EventArgs) Handles BtnSupp1.Click
    txtDtEntree.Text = ""
  End Sub

  Private Sub BtnSupp2_Click(ByVal sender As Object, ByVal e As EventArgs) Handles BtnSupp2.Click
    TxtDteEngagement.Text = ""
  End Sub

  Private Sub BtnEnreg_Click(ByVal sender As Object, ByVal e As EventArgs) Handles BtnEnreg.Click

    ' Enregistrement
    Try

      Cursor = Cursors.WaitCursor
      'on ouvre la connexion
      If MozartDatabase.cnxMozart.State = ConnectionState.Open Then

        Dim CmdSql As New SqlCommand("api_sp_creationTelephone", MozartDatabase.cnxMozart) With {.CommandType = CommandType.StoredProcedure}

        If IsNumeric(LabelNTELNUM.Text) Then
          CmdSql.Parameters.Add("@iNum", SqlDbType.Int).Value = LabelNTELNUM.Text ' Modification
        Else
          CmdSql.Parameters.Add("@iNum", SqlDbType.Int).Value = "0"  ' Nouveau téléphone
        End If

        CmdSql.Parameters.Add("@materiel", SqlDbType.VarChar).Value = txtMateriel.Text
        CmdSql.Parameters.Add("@sim", SqlDbType.VarChar).Value = txtNumSIM.Text
        CmdSql.Parameters.Add("@code", SqlDbType.VarChar).Value = txtNumCode.Text
        CmdSql.Parameters.Add("@appel", SqlDbType.VarChar).Value = txtNumAppel.Text
        CmdSql.Parameters.Add("@utilisateur", SqlDbType.VarChar).Value = cboUtil.Text
        CmdSql.Parameters.Add("@vObserv", SqlDbType.VarChar).Value = txtObs.Text
        CmdSql.Parameters.Add("@profil", SqlDbType.VarChar).Value = cboProf.Text
        CmdSql.Parameters.Add("@dDateE", SqlDbType.DateTime).Value = IIf(txtDtEntree.Text = "", DBNull.Value, txtDtEntree.Text)
        CmdSql.Parameters.Add("@voperateur", SqlDbType.VarChar).Value = TxtOperateur.Text
        CmdSql.Parameters.Add("@dDateEngage", SqlDbType.DateTime).Value = IIf(TxtDteEngagement.Text = "", DBNull.Value, TxtDteEngagement.Text)

        CmdSql.Parameters.Add("@vsociete", SqlDbType.VarChar).Value = CboSociete.Text

        LabelNTELNUM.Text = CmdSql.ExecuteScalar()
        TxtNum.Text = LabelNTELNUM.Text

        CmdSql.Dispose()
        CmdSql = Nothing

        MsgBox(My.Resources.Global_EnregistrementOK, MsgBoxStyle.Information + vbOKOnly, "INFO")
        Close()
      End If

    Catch ex As Exception
      MessageBox.Show(My.Resources.Admin_frmDetailsTelephone_SubClick + ex.Message, My.Resources.Global_Erreur)
    Finally
      Cursor = Cursors.Default
    End Try

  End Sub

  Private Sub initSociete()
    'initialisation de le combobox "Société"  

    If MozartDatabase.cnxMozart.State = ConnectionState.Open Then

      Dim CmdSql As New SqlCommand(String.Format("SELECT DISTINCT VSOCIETE FROM TDROIT WHERE NPERNUM = {0} AND NMENUNUM = {1} AND CDROITVAL = 'O' ORDER BY VSOCIETE", MozartParams.UID, CboSociete.Tag), MozartDatabase.cnxMozart)
      Dim dr As SqlDataReader = CmdSql.ExecuteReader
      While dr.Read() 'While données présentes, stocker les éléments en combobox
        CboSociete.Items.Add(dr("VSOCIETE"))
      End While

      CboSociete.SelectedIndex = 0

      dr.Close()
      CmdSql.Dispose()
      dr = Nothing

    End If

  End Sub

End Class