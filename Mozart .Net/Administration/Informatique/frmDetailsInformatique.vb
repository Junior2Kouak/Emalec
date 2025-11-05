Imports System.Data.SqlClient
Imports MozartLib
Imports MZCtrlResources = MozartControls.Properties.Resources

Public Class frmDetailsInformatique

  Dim calendar_open As String = ""
  Dim bloader As Boolean = False

  Private Sub frmDetailsInformatique_Load(ByVal sender As Object, ByVal e As EventArgs) Handles MyBase.Load

    ' Initialisation et remplissage de la combobox Société
    initSociete()

    cboMateriel.Init(MozartDatabase.cnxMozart, $"SELECT NTYPEMATNUM, VTYPEMATNOM FROM TREF_TYPEMAT ORDER BY VTYPEMATNOM",
                   "NTYPEMATNUM", "VTYPEMATNOM", New List(Of String) From {MZCtrlResources.col_No, MZCtrlResources.col_Materiel}, 200, 200)

    bloader = True

    Dim dr As SqlDataReader
    Dim CmdSql
    Dim utilisateur_libelle As String

    Try

      Cursor = Cursors.WaitCursor
      'on ouvre la connexion
      If MozartDatabase.cnxMozart.State = ConnectionState.Open Then

        ' Dans tous les cas : création et modification de données :

        ' Liste du personnel
        Dim sSQL As String = String.Format("select NPERNUM, VPERNOM + ' ' + VPERPRE AS VPERNOMPRENOM from TPER WHERE VSOCIETE = '{0}' AND CPERACTIF='O' UNION select 0, ' ' ", LabelSociete.Text)
        sSQL &= " order by VPERNOM  +  ' ' + VPERPRE "

        Dim dt As New DataTable
        Dim dsCond As New SqlDataAdapter(sSQL, MozartDatabase.cnxMozart)
        dsCond.Fill(dt)
        cboUtil.DataSource = dt
        dsCond.Dispose()

      End If
    Catch ex As Exception
      MessageBox.Show(My.Resources.Admin_frmDetailsInformatique_sub + ex.Message, My.Resources.Global_Erreur)
    Finally
      Cursor = Cursors.Default
      dr = Nothing
      CmdSql = Nothing
    End Try


    If IsNumeric(LabelNORDINUM.Text) Then
      ' Mode modification
      Try

        Cursor = Cursors.WaitCursor
        'on ouvre la connexion
        If MozartDatabase.cnxMozart.State = ConnectionState.Open Then

          ' Données générales
          CmdSql = New SqlCommand("select * from api_v_listeOrdinateurs2 where NORDINUM = " & LabelNORDINUM.Text, MozartDatabase.cnxMozart)

          dr = CmdSql.ExecuteReader

          If dr.HasRows Then
            dr.Read()
            CboSociete.SelectedItem = dr("VSOCIETE").ToString
            TxtNum.Text = dr("NORDINUM").ToString
            txtObs.Text = dr("VORDIOBS").ToString
            txtMat.Text = dr("VORDIMAT").ToString
            If Not IsDBNull(dr("NTYPEMATNUM")) Then
              cboMateriel.SetItemData(Convert.ToInt32(dr("NTYPEMATNUM")))
            End If
            txtNumSerie.Text = dr("VORDINUMSERIE").ToString
            txtMarque.Text = dr("VORDIMARQUE").ToString
            txtImplantation.Text = dr("VORDIIMPL").ToString
            txtType.Text = dr("VORDITYPE").ToString
            txtAdrIP.Text = dr("VORDINUMIP").ToString
            txtDtEntree.Text = formateDate(dr("DORDIDATE").ToString)
            txtDtSortie.Text = formateDate(dr("DORDIDATES").ToString)
            CBPopUp.Checked = dr("BORDIRECEPTMSG").ToString
            cbEcoLabel.Checked = IIf(dr("CORDIECO") = "N", 0, 1)
            utilisateur_libelle = dr("VORDIAFFECTATION").ToString
            ChkAtt_retour.Checked = dr("BATT_RETOUR").ToString
                        TxtAnyDesk.Text = dr("VORDI_ANYDESK").ToString
                        TxtDateEnvoiMat.Text = formateDate(dr("DENVOIMAT").ToString())

                        dr.Close()
            CmdSql.Dispose()

            chargeDetailsUC()

            ' Valorisation des combobox
            Dim trouve As Boolean = False
            For i = 0 To cboUtil.Items.Count - 1
              cboUtil.SelectedIndex = i
              If cboUtil.Text.ToUpper = utilisateur_libelle.ToUpper Then
                trouve = True
                Exit For
              End If
            Next i
            If Not trouve Then
              cboUtil.SelectedIndex = -1
              If utilisateur_libelle.Trim <> "" Then MsgBox(My.Resources.Admin_frmDetailsInformatique_value_notFound & utilisateur_libelle, MsgBoxStyle.Exclamation + MsgBoxStyle.OkOnly, My.Resources.Global_Erreur_maj)
            End If
          End If

        End If

      Catch ex As Exception
        MessageBox.Show(My.Resources.Admin_frmDetailsInformatique_Load + ex.Message, My.Resources.Global_Erreur)
      Finally
        Cursor = Cursors.Default
        dr = Nothing
        CmdSql = Nothing
      End Try

    End If

    bloader = False

  End Sub

  Private Sub chargeDetailsUC()
    Dim o_sql = String.Format("select NUCNUM, VUCPROGRAMME, VUCLICENCE from TUC where NORDINUM = {0} Order by NUCNUM", LabelNORDINUM.Text)
    Dim CmdSqlUC As New SqlCommand(o_sql, MozartDatabase.cnxMozart)
    Dim sqlAdapt As SqlDataAdapter = New SqlDataAdapter(CmdSqlUC)
    Dim dtUC As New DataSet
    sqlAdapt.Fill(dtUC)

    GridControl1.DataSource = dtUC.Tables(0)

    CmdSqlUC.Dispose()
  End Sub

  Private Shared Function formateDate(ByVal chaine As String) As String
    If chaine.Trim().Equals("") Then
      Return ""
    End If

    Return chaine.Substring(0, 10)
  End Function

  Private Sub BtnDate1_Click(ByVal sender As Object, ByVal e As EventArgs) Handles BtnDate1.Click
    If MonthCalendar1.Visible Then
      calendar_open = ""
      MonthCalendar1.Visible = False
    Else
      calendar_open = "txtDtEntree"
      MonthCalendar1.Visible = True
    End If
  End Sub

  Private Sub BtnSupp1_Click(ByVal sender As Object, ByVal e As EventArgs) Handles BtnSupp1.Click
    txtDtEntree.Text = ""
  End Sub

  Private Sub BtnDate2_Click(ByVal sender As Object, ByVal e As EventArgs) Handles BtnDate2.Click
    If MonthCalendar1.Visible Then
      calendar_open = ""
      MonthCalendar1.Visible = False
    Else
      calendar_open = "txtDtSortie"
      MonthCalendar1.Visible = True
    End If
  End Sub

  Private Sub BtmSupp2_Click(ByVal sender As Object, ByVal e As EventArgs) Handles BtmSupp2.Click
    txtDtSortie.Text = ""
  End Sub

  Private Sub MonthCalendar1_DateSelected(ByVal sender As Object, ByVal e As DateRangeEventArgs) Handles MonthCalendar1.DateSelected

    Select Case calendar_open
      Case "txtDtEntree"
        txtDtEntree.Text = MonthCalendar1.SelectionStart.Date
      Case "txtDtSortie"
                txtDtSortie.Text = MonthCalendar1.SelectionStart.Date
            Case "txtDateEnvoiMat"
                TxtDateEnvoiMat.Text = MonthCalendar1.SelectionStart.Date
                Dim aux2 As String = String.Format("{0} le {1} : Ajout de la date d'envoi de matériel {2} automatique par la case à coché 'Attente retour'", MozartParams.strUID, Today.ToShortDateString, TxtDateEnvoiMat.Text)
                txtObs.Text = aux2 & vbCrLf & txtObs.Text
            Case Else
        Exit Select
    End Select

    MonthCalendar1.Visible = False
  End Sub

  Private Sub txtObs_GotFocus(ByVal sender As Object, ByVal e As EventArgs) Handles txtObs.GotFocus
    Dim aux As String = String.Format("{0} le {1} : ", MozartParams.strUID, Today.ToShortDateString)
    txtObs.Text = aux & vbCrLf & txtObs.Text
  End Sub

  Private Sub BtnEnreg_Click(ByVal sender As Object, ByVal e As EventArgs) Handles BtnEnreg.Click
    If cboMateriel.GetItemData() = -1 Then
      MsgBox(My.Resources.Admin_frmDetailsInformatique_nom_mat, vbInformation + MsgBoxStyle.OkOnly)

      Exit Sub
    End If

    ' Passage de la marque ne majuscule
    txtMarque.Text = txtMarque.Text.ToUpper()

    ' Enregistrement
    Try
      Cursor = Cursors.WaitCursor
      'on ouvre la connexion
      If MozartDatabase.cnxMozart.State = ConnectionState.Open Then

        Dim CmdSql As New SqlCommand("api_sp_creationMateriel2", MozartDatabase.cnxMozart) With {.CommandType = CommandType.StoredProcedure}

        If IsNumeric(LabelNORDINUM.Text) Then
          CmdSql.Parameters.Add("@iNum", SqlDbType.Int).Value = LabelNORDINUM.Text ' Modification
        Else
          CmdSql.Parameters.Add("@iNum", SqlDbType.Int).Value = "0"  ' Nouveau véhicule
        End If

        CmdSql.Parameters.Add("@materiel", SqlDbType.Int).Value = cboMateriel.GetItemData()
        CmdSql.Parameters.Add("@numSerie", SqlDbType.VarChar).Value = txtNumSerie.Text
        CmdSql.Parameters.Add("@Marque", SqlDbType.VarChar).Value = txtMarque.Text
        CmdSql.Parameters.Add("@Type", SqlDbType.VarChar).Value = txtType.Text
        CmdSql.Parameters.Add("@Affectation", SqlDbType.VarChar).Value = cboUtil.Text
        CmdSql.Parameters.Add("@implantation", SqlDbType.VarChar).Value = txtImplantation.Text
        CmdSql.Parameters.Add("@dDateE", SqlDbType.DateTime).Value = IIf(txtDtEntree.Text = "", DBNull.Value, txtDtEntree.Text)
        CmdSql.Parameters.Add("@dDateS", SqlDbType.DateTime).Value = IIf(txtDtSortie.Text = "", DBNull.Value, txtDtSortie.Text)
        CmdSql.Parameters.Add("@vObserv", SqlDbType.VarChar).Value = txtObs.Text
        CmdSql.Parameters.Add("@adIp", SqlDbType.VarChar).Value = txtAdrIP.Text
        CmdSql.Parameters.Add("@eco", SqlDbType.Char).Value = IIf(cbEcoLabel.Checked = True, "O", "N")
        CmdSql.Parameters.Add("@bordireceptmsg", SqlDbType.Int).Value = IIf(CBPopUp.Checked = True, "1", "0")

        CmdSql.Parameters.Add("@vsociete", SqlDbType.VarChar).Value = CboSociete.Text
        CmdSql.Parameters.Add("@npernum", SqlDbType.Int).Value = If(cboUtil.SelectedValue Is Nothing, DBNull.Value, cboUtil.SelectedValue)
        CmdSql.Parameters.Add("@batt_retour", SqlDbType.Bit).Value = If(ChkAtt_retour.Checked = True, 1, 0)
                CmdSql.Parameters.Add("@VORDI_ANYDESK", SqlDbType.VarChar).Value = TxtAnyDesk.Text
                CmdSql.Parameters.Add("@DENVOIMAT", SqlDbType.DateTime).Value = IIf(TxtDateEnvoiMat.Text = "", DBNull.Value, TxtDateEnvoiMat.Text)

                LabelNORDINUM.Text = CmdSql.ExecuteScalar
        TxtNum.Text = LabelNORDINUM.Text
        CmdSql.Dispose()

        MsgBox(My.Resources.Global_EnregistrementOK, MsgBoxStyle.Information + vbOKOnly, "INFO")

      End If

    Catch ex As Exception
      MessageBox.Show(My.Resources.Admin_frmDetailsInformatique_Click + ex.Message, My.Resources.Global_Erreur)
    Finally
      Cursor = Cursors.Default
    End Try

  End Sub

  Private Sub BtnAjout_Click(ByVal sender As Object, ByVal e As EventArgs) Handles BtnAjout.Click

    txtProgramme.Text = ""
    txtLicence.Text = ""
    BtnModifier.Enabled = False
    BtnSuppr.Enabled = False
    GroupBoxGestionDetailsUC.Visible = True

  End Sub

  Private Sub BtnA_Click(ByVal sender As Object, ByVal e As EventArgs) Handles BtnA.Click
    LabelNucNum.Text = "NUCNUM"
    txtProgramme.Text = ""
    txtLicence.Text = ""
    BtnModifier.Enabled = True
    BtnSuppr.Enabled = True
    BtnAjout.Enabled = True
    GroupBoxGestionDetailsUC.Visible = False
  End Sub

  Private Sub BtnModifier_Click(ByVal sender As Object, ByVal e As EventArgs) Handles BtnModifier.Click
    Try
      ' On récupère les éléments dont on a besoin, dans la liste
      Dim ligne_selectionnee As Integer() = GridView1.GetSelectedRows()
      LabelNucNum.Text = GridView1.GetRowCellValue(ligne_selectionnee.ElementAt(0), "NUCNUM").ToString

      txtProgramme.Text = GridView1.GetRowCellValue(ligne_selectionnee.ElementAt(0), "VUCPROGRAMME").ToString
      txtLicence.Text = GridView1.GetRowCellValue(ligne_selectionnee.ElementAt(0), "VUCLICENCE").ToString
      BtnAjout.Enabled = False
      BtnSuppr.Enabled = False
      GroupBoxGestionDetailsUC.Visible = True

    Catch ex As Exception
      MessageBox.Show(My.Resources.Global_aucune_ligne, My.Resources.Global_Information)
    End Try
  End Sub

  Private Sub BtnSuppr_Click(ByVal sender As Object, ByVal e As EventArgs) Handles BtnSuppr.Click

    Try
      ' On récupère les éléments dont on a besoin, dans la liste
      Dim ligne_selectionnee As Integer() = GridView1.GetSelectedRows()
      Dim nucnum As String = GridView1.GetRowCellValue(ligne_selectionnee.ElementAt(0), "NUCNUM").ToString

      If MsgBox(My.Resources.Admin_frmDetailsInformatique_msg_supp, MsgBoxStyle.Question + MsgBoxStyle.YesNo, My.Resources.Global_Attention) = vbYes Then
        Dim o_sql = "delete from TUC where NUCNUM = " & nucnum
        Dim CmdSql As New SqlCommand(o_sql, MozartDatabase.cnxMozart)
        CmdSql.ExecuteNonQuery()
        CmdSql.Dispose()

        'Raffraichir l'affichage
        chargeDetailsUC()

      End If

    Catch ex As Exception
      MessageBox.Show(My.Resources.Global_aucune_ligne, My.Resources.Global_Information)
    End Try

  End Sub

  Private Sub BtnV_Click(ByVal sender As Object, ByVal e As EventArgs) Handles BtnV.Click

    ' Enregistrement
    Try

      Cursor = Cursors.WaitCursor
      'on ouvre la connexion
      If MozartDatabase.cnxMozart.State = ConnectionState.Open Then

        Dim CmdSql As New SqlCommand("api_sp_creationUC", MozartDatabase.cnxMozart) With {.CommandType = CommandType.StoredProcedure}

        If IsNumeric(LabelNucNum.Text) Then
          CmdSql.Parameters.Add("@iNum", SqlDbType.Int).Value = LabelNucNum.Text ' Modification
        Else
          CmdSql.Parameters.Add("@iNum", SqlDbType.Int).Value = "0"  ' Nouvelle clé
        End If

        CmdSql.Parameters.Add("@ordinum", SqlDbType.Int).Value = TxtNum.Text
        CmdSql.Parameters.Add("@programme", SqlDbType.VarChar).Value = txtProgramme.Text
        CmdSql.Parameters.Add("@licence", SqlDbType.VarChar).Value = txtLicence.Text
        CmdSql.Parameters.Add("@vsociete", SqlDbType.VarChar).Value = LabelSociete.Text

        CmdSql.ExecuteNonQuery()
        CmdSql.Dispose()
        CmdSql = Nothing

        Cursor = Cursors.Default
        LabelNucNum.Text = "NUCNUM" ' Init pour la prochaine fois, si besoin
        BtnModifier.Enabled = True
        BtnSuppr.Enabled = True
        BtnAjout.Enabled = True
        GroupBoxGestionDetailsUC.Visible = False
        chargeDetailsUC()
      End If

    Catch ex As Exception
      MessageBox.Show(My.Resources.Admin_frmDetailsInformatique_msg_Vclick + ex.Message, My.Resources.Global_Erreur)
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

  Private Sub ChkAtt_retour_CheckedChanged(sender As Object, e As EventArgs) Handles ChkAtt_retour.CheckedChanged

    If bloader Then Return

    Dim aux As String = String.Format("{0} le {1} : Attente retour {2}", MozartParams.strUID, Today.ToShortDateString, If(ChkAtt_retour.Checked = True, "cochée", "décochée"))
    txtObs.Text = aux & vbCrLf & txtObs.Text


        If (TxtDateEnvoiMat.Text = "" And ChkAtt_retour.Checked = True And bloader = False) Then
            TxtDateEnvoiMat.Text = Today.ToShortDateString()
            Dim aux2 As String = String.Format("{0} le {1} : Ajout de la date d'envoi de matériel {2} automatique par la case à coché 'Attente retour'", MozartParams.strUID, Today.ToShortDateString, TxtDateEnvoiMat.Text)
            txtObs.Text = aux2 & vbCrLf & txtObs.Text
        End If


    End Sub

    Private Sub BtnDateEnvoiMat_Click(sender As Object, e As EventArgs) Handles BtnDateEnvoiMat.Click
        If MonthCalendar1.Visible Then
            calendar_open = ""
            MonthCalendar1.Visible = False
        Else
            calendar_open = "txtDateEnvoiMat"
            MonthCalendar1.Visible = True
        End If
    End Sub

    Private Sub BtnSuppDateEnvoiMat_Click(sender As Object, e As EventArgs) Handles BtnSuppDateEnvoiMat.Click

        Dim aux As String = String.Format("{0} le {1} : Suppression de la date d'envoi de matériel {2}", MozartParams.strUID, Today.ToShortDateString, TxtDateEnvoiMat.Text)
        txtObs.Text = aux & vbCrLf & txtObs.Text

        TxtDateEnvoiMat.Text = ""

    End Sub
End Class