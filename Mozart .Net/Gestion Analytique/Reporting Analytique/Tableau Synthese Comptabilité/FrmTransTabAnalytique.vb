Imports System.Data.SqlClient
Imports MozartLib

Public Class FrmTransTabAnalytique

  Dim oGestConnectSQL As New CGestionSQL
  Dim iDataexist As Int32 = 0

  Private Sub FrmTransTabAnalytique_FormClosed(ByVal sender As Object, ByVal e As System.Windows.Forms.FormClosedEventArgs) Handles Me.FormClosed

    oGestConnectSQL.CloseConnexionSQL()

  End Sub

  Private Sub FrmTransTabAnalytique_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load

    Try

      'on ouvre la connexion
      If oGestConnectSQL.ConnexionSQL(MozartParams.NomServeur, MozartParams.NomSociete) = True Then

      End If

    Catch ex As Exception

      MessageBox.Show(My.Resources.TabSyntheseCompta_frmTransTabAnalytique_Sub + ex.Message, My.Resources.Global_Erreur)

    End Try

  End Sub

  Private Sub BtnValidTab_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles BtnValidTab.Click

    Me.Cursor = Cursors.Default

    'on vérifie s'il existe des données dans TANAHISTO sur ce mois et cette année
    Dim sqlcmd As New SqlCommand("api_sp_VerifDataAnalytique", oGestConnectSQL.CnxSQLOpen)
    sqlcmd.CommandType = CommandType.StoredProcedure
    sqlcmd.Parameters.Add("@p_dateverif", SqlDbType.DateTime)
    sqlcmd.Parameters("@p_dateverif").Value = DTPButoireAna.Value.ToShortDateString + " 23:59"

    Dim dr As SqlDataReader = sqlcmd.ExecuteReader

    Try

      If dr.HasRows = True Then

        dr.Read()
        iDataexist = dr("NBEXIST")

      End If

      dr.Close()

      If iDataexist > 0 Then

        'si menunum = 372 à oui alors la personne a le droit de supprimer les données mais seulement du dernier mois de TANAHISTO
        'recherche du droit sur leNMENUNUM = 372
        If RechercheDroitMenu(372) Then

          Dim sLastDateAna As String = LastDateAnalytique()

          'on ne peut supprimer que le dernier mois analyser. pour éviter tout ecrasement des données précédente
          If sLastDateAna <> "" AndAlso (Month(Convert.ToDateTime(sLastDateAna)) = DTPButoireAna.Value.Month And Year(Convert.ToDateTime(sLastDateAna)) = DTPButoireAna.Value.Year) Then

            Select Case MessageBox.Show(My.Resources.TabSyntheseCompta_frmTransTabAnalytique_data_existe & MonthName(DTPButoireAna.Value.Month) & " " & DTPButoireAna.Value.Year & My.Resources.TabSyntheseCompta_frmTransTabAnalytique_delete_data + vbCrLf + My.Resources.TabSyntheseCompta_frmTransTabAnalytique_attention, My.Resources.TabSyntheseCompta_frmTransTabAnalytique_erreur, MessageBoxButtons.YesNoCancel, MessageBoxIcon.Warning)

              Case DialogResult.Yes

                If ChkRecalcEncours.CheckState = CheckState.Checked Then

                  MessageBox.Show(My.Resources.TabSyntheseCompta_frmTransTabAnalytique_continuer, "", MessageBoxButtons.YesNoCancel, MessageBoxIcon.Question)

                  Dim sqlcmdSaveEncours As New SqlCommand("api_sp_AnalytiqueSaveEnCours", oGestConnectSQL.CnxSQLOpen)
                  sqlcmdSaveEncours.CommandType = CommandType.StoredProcedure
                  sqlcmdSaveEncours.Parameters.Add("@p_datecrea", SqlDbType.DateTime)
                  sqlcmdSaveEncours.Parameters("@p_datecrea").Value = DTPButoireAna.Value
                  sqlcmdSaveEncours.ExecuteNonQuery()

                End If

                Dim sqlcmdSuppr As New SqlCommand("api_sp_SupprimerTableauSynthAna", oGestConnectSQL.CnxSQLOpen)
                sqlcmdSuppr.CommandType = CommandType.StoredProcedure
                sqlcmdSuppr.Parameters.Add("@p_datecrea", SqlDbType.DateTime)
                sqlcmdSuppr.Parameters("@p_datecrea").Value = DTPButoireAna.Value
                sqlcmdSuppr.ExecuteNonQuery()

                MessageBox.Show(My.Resources.TabSyntheseCompta_frmTransTabAnalytique_sup_done, My.Resources.global_msg_dinfo, MessageBoxButtons.OK, MessageBoxIcon.Information)

                iDataexist = 0

                'Return

              Case Else

                'Return

            End Select

          Else

            If iDataexist > 0 Then MessageBox.Show(My.Resources.Global_contactez_EMALEC, My.Resources.TabSyntheseCompta_frmTransTabAnalytique_erreur, MessageBoxButtons.OK, MessageBoxIcon.Warning) : Return

          End If

        Else
          If iDataexist > 0 Then MessageBox.Show(My.Resources.Global_contactez_EMALEC, My.Resources.TabSyntheseCompta_frmTransTabAnalytique_erreur, MessageBoxButtons.OK, MessageBoxIcon.Warning) : Return
        End If

      End If

      'lancement du traitement
      If MessageBox.Show(My.Resources.TabSyntheseCompta_frmTransTabAnalytique_lancer_tait, My.Resources.Global_Confirmation, MessageBoxButtons.YesNoCancel, MessageBoxIcon.Question) = DialogResult.Yes Then

        If iDataexist = 0 AndAlso MessageBox.Show(String.Format(My.Resources.TabSyntheseCompta_frmTransTabAnalytique_confirmation_trait, DTPButoireAna.Value.ToShortDateString + " 23:59"), My.Resources.Global_Confirmation, MessageBoxButtons.YesNoCancel, MessageBoxIcon.Question) = DialogResult.Yes Then

          Dim sqlcmdJob As SqlCommand

          Me.Cursor = Cursors.WaitCursor



          Dim b_Visible As Boolean = True

          Select Case MessageBox.Show("Voulez-vous rendre ce reporting visible ?", "Confirmation", MessageBoxButtons.YesNoCancel)
            Case DialogResult.Yes
              b_Visible = True
            Case Else

              b_Visible = False


          End Select

          'remplissage table TANAHISTO
          Try

            'Lancement du traitement
            sqlcmdJob = New SqlCommand("api_sp_JobCalculSynthComptaV2", oGestConnectSQL.CnxSQLOpen)
            sqlcmdJob.CommandType = CommandType.StoredProcedure
            sqlcmdJob.CommandTimeout = 0
            sqlcmdJob.Parameters.Add("@p_dateDebutAn", SqlDbType.DateTime)
            sqlcmdJob.Parameters("@p_dateDebutAn").Value = Convert.ToDateTime("01/01/" + Year(DTPButoireAna.Value).ToString)
            sqlcmdJob.Parameters.Add("@p_dateFinMois", SqlDbType.DateTime)
            sqlcmdJob.Parameters("@p_dateFinMois").Value = DTPButoireAna.Value.ToShortDateString + " 23:59"
            sqlcmdJob.Parameters.Add("@vsociete", SqlDbType.VarChar)
            sqlcmdJob.Parameters("@vsociete").Value = MozartParams.NomSociete
            sqlcmdJob.Parameters.Add("@p_recalcencours", SqlDbType.Bit).Value = If(ChkRecalcEncours.CheckState = CheckState.Checked, 0, 1)
            sqlcmdJob.Parameters.Add("@P_VISIBLE", SqlDbType.Bit).Value = If(b_Visible = True, 1, 0)


                        sqlcmdJob.ExecuteNonQuery()

                        'save date lancement calcul reporting
                        sqlcmdJob = New SqlCommand("[api_sp_AnaHisto_SaveLog]", oGestConnectSQL.CnxSQLOpen)
                        sqlcmdJob.CommandType = CommandType.StoredProcedure
                        sqlcmdJob.CommandTimeout = 0
                        sqlcmdJob.Parameters.Add("@p_dateFinMois", SqlDbType.DateTime)
                        sqlcmdJob.Parameters("@p_dateFinMois").Value = DTPButoireAna.Value.ToShortDateString + " 23:59"
                        sqlcmdJob.ExecuteNonQuery()

                    Catch ex As Exception

            Me.Cursor = Cursors.Default
            MessageBox.Show(My.Resources.TabSyntheseCompta_frmTransTabAnalytique_remplissage + ex.Message)
            Return

          End Try

          'remplissage table TANAHISTOBAL
          Try

            'Lancement du traitement
            sqlcmdJob = New SqlCommand("api_sp_JobCalculSynthComptaBalanceV2", oGestConnectSQL.CnxSQLOpen)
            sqlcmdJob.CommandType = CommandType.StoredProcedure
            sqlcmdJob.CommandTimeout = 0
            sqlcmdJob.Parameters.Add("@p_dateDebutAn", SqlDbType.DateTime)
            sqlcmdJob.Parameters("@p_dateDebutAn").Value = Convert.ToDateTime("01/01/" + Year(DTPButoireAna.Value).ToString)
            sqlcmdJob.Parameters.Add("@p_dateFinMois", SqlDbType.DateTime)
            sqlcmdJob.Parameters("@p_dateFinMois").Value = DTPButoireAna.Value.ToShortDateString + " 23:59"
            sqlcmdJob.Parameters.Add("@vsociete", SqlDbType.VarChar)
            sqlcmdJob.Parameters("@vsociete").Value = MozartParams.NomSociete
            sqlcmdJob.Parameters.Add("@p_recalcencours", SqlDbType.Bit).Value = If(ChkRecalcEncours.CheckState = CheckState.Checked, 0, 1)
            sqlcmdJob.Parameters.Add("@P_VISIBLE", SqlDbType.Bit).Value = If(b_Visible = True, 1, 0)

            sqlcmdJob.ExecuteNonQuery()

          Catch ex As Exception

            Me.Cursor = Cursors.Default
            MessageBox.Show(My.Resources.TabSyntheseCompta_frmTransTabAnalytique_remplissage2 + ex.Message)
            Return

          End Try

          'remplissage table TANAHISTOREX
          Try

            'Lancement du traitement
            sqlcmdJob = New SqlCommand("api_sp_JobCalculSynthComptaREXV2", oGestConnectSQL.CnxSQLOpen)
            sqlcmdJob.CommandType = CommandType.StoredProcedure
            sqlcmdJob.CommandTimeout = 0
            sqlcmdJob.Parameters.Add("@p_dateDebutAn", SqlDbType.DateTime)
            sqlcmdJob.Parameters("@p_dateDebutAn").Value = Convert.ToDateTime("01/01/" + Year(DTPButoireAna.Value).ToString)
            sqlcmdJob.Parameters.Add("@p_dateFinMois", SqlDbType.DateTime)
            sqlcmdJob.Parameters("@p_dateFinMois").Value = DTPButoireAna.Value.ToShortDateString + " 23:59"
            sqlcmdJob.Parameters.Add("@vsociete", SqlDbType.VarChar)
            sqlcmdJob.Parameters("@vsociete").Value = MozartParams.NomSociete
            sqlcmdJob.Parameters.Add("@P_VISIBLE", SqlDbType.Bit).Value = If(b_Visible = True, 1, 0)


            sqlcmdJob.ExecuteNonQuery()

          Catch ex As Exception

            Me.Cursor = Cursors.Default
            MessageBox.Show(My.Resources.TabSyntheseCompta_frmTransTabAnalytique_remplissage3 + ex.Message)
            Return

          End Try

          MessageBox.Show(My.Resources.TabSyntheseCompta_frmTransTabAnalytique_trait_terminé, My.Resources.Global_fin_traitement, MessageBoxButtons.OK, MessageBoxIcon.Information)

        End If

      End If

      Me.Cursor = Cursors.Default

    Catch ex As Exception

      MessageBox.Show(My.Resources.TabSyntheseCompta_frmTransTabAnalytique_btn + ex.Message, My.Resources.Global_Erreur, MessageBoxButtons.OK, MessageBoxIcon.Error)

    Finally

      If dr.IsClosed = False Then dr.Close()

    End Try

  End Sub

  Private Function LastDateAnalytique() As String

    Try
      Dim slastDateAna As String

      Dim sqlcmdRecup As New SqlCommand("SELECT MAX(DDATCRE) AS MAXDATE FROM TANAHISTO WHERE VSOCIETE = '" & MozartParams.NomSociete & "'", MozartDatabase.cnxMozart)
      sqlcmdRecup.CommandType = CommandType.Text
      Dim oDrRecup As SqlDataReader = sqlcmdRecup.ExecuteReader

      If oDrRecup.HasRows Then

        oDrRecup.Read()
        slastDateAna = oDrRecup.Item("MAXDATE").ToString

      Else

        slastDateAna = ""

      End If

      oDrRecup.Close()

      Return slastDateAna

    Catch ex As Exception

      MessageBox.Show(My.Resources.TabSyntheseCompta_frmTransTabAnalytique_last + ex.Message, My.Resources.Global_Erreur, MessageBoxButtons.OK, MessageBoxIcon.Error)
      Return ""

    End Try

  End Function

  Private Sub BtnValidDep_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles BtnValidDep.Click

    Dim iDataExist As Int32 = 0
    Dim iDepenseExist As Int32 = 0

    'on test s'il existe des données sur ce mois dans TANADEP
    'si existe
    'si droit suppresion
    'suppression
    ' si pas le droit
    'message impossible

    'si existe pas

    'on test s'il existe des données dans TANAHISTO sur ce mois

    'si oui
    'on peut lancer le traitment

    'si non
    'lancement impossible


    Me.Cursor = Cursors.Default

    'on vérifie s'il existe des données dans TANAHISTO sur ce mois et cette année
    Dim sqlcmd As New SqlCommand("api_sp_VerifDataDepenseAnalytique", oGestConnectSQL.CnxSQLOpen)
    sqlcmd.CommandType = CommandType.StoredProcedure
    sqlcmd.Parameters.Add("@p_dateverif", SqlDbType.DateTime)
    sqlcmd.Parameters("@p_dateverif").Value = DTPButoireAna.Value.ToShortDateString + " 23:59"

    Dim dr As SqlDataReader = sqlcmd.ExecuteReader

    Try

      If dr.HasRows = True Then

        dr.Read()
        iDataExist = dr.Item("NBEXISTDATA")
        iDepenseExist = dr.Item("NBEXISTDEP")

      End If

      dr.Close()

    Catch ex As Exception

      MessageBox.Show(My.Resources.TabSyntheseCompta_frmTransTabAnalytique_btn2 + ex.Message, My.Resources.Global_Erreur, MessageBoxButtons.OK, MessageBoxIcon.Error)

    Finally

      If dr.IsClosed = False Then dr.Close()

    End Try

    'test si existe des dépenses sur ce mois
    If iDepenseExist > 0 Then

      'test si droit de suppresion des donnnées NMENUNUM = 372
      If RechercheDroitMenu(372) Then

        Select Case MessageBox.Show(My.Resources.TabSyntheseCompta_frmTransTabAnalytique_warning, My.Resources.Global_sup_confirmation, MessageBoxButtons.YesNoCancel, MessageBoxIcon.Question)

          Case DialogResult.Yes

            'suppression table TANADEP
            Try

              Me.Cursor = Cursors.WaitCursor

              Dim sqlcmdSuppr As SqlCommand

              'Lancement du traitement
              sqlcmdSuppr = New SqlCommand("api_sp_SupprimerTableauDepenseAna", oGestConnectSQL.CnxSQLOpen)
              sqlcmdSuppr.CommandType = CommandType.StoredProcedure
              sqlcmdSuppr.CommandTimeout = 0
              sqlcmdSuppr.Parameters.Add("@p_datecrea", SqlDbType.DateTime)
              sqlcmdSuppr.Parameters("@p_datecrea").Value = DTPButoireAna.Value

              sqlcmdSuppr.ExecuteNonQuery()

              MessageBox.Show(My.Resources.TabSyntheseCompta_frmTransTabAnalytique_succes + vbCrLf + My.Resources.TabSyntheseCompta_frmTransTabAnalytique_relancer, My.Resources.Global_suppression, MessageBoxButtons.OK, MessageBoxIcon.Information)

            Catch ex As Exception

              Me.Cursor = Cursors.Default
              MessageBox.Show(My.Resources.TabSyntheseCompta_frmTransTabAnalytique_remplissage4 + ex.Message, My.Resources.Global_Erreur, MessageBoxButtons.OK, MessageBoxIcon.Error)
              Return

            Finally

              Me.Cursor = Cursors.Default

            End Try

          Case Else
        End Select

      Else

        MessageBox.Show(My.Resources.TabSyntheseCompta_frmTransTabAnalytique_impossible_lancer, My.Resources.Global_Erreur, MessageBoxButtons.OK, MessageBoxIcon.Exclamation)

      End If

    Else

      'test si existe data dans TANAHISTO
      If iDataExist > 0 Then

        If MessageBox.Show(String.Format(My.Resources.TabSyntheseCompta_frmTransTabAnalytique_impossible_lancement_trait, DTPButoireAna.Value.ToShortDateString + " 23:59"), My.Resources.Global_Confirmation, MessageBoxButtons.YesNoCancel, MessageBoxIcon.Question) = DialogResult.Yes Then

          'remplissage table TANADEP
          Try

            Me.Cursor = Cursors.WaitCursor

            Dim sqlcmdJob As SqlCommand

            'Lancement du traitement
            sqlcmdJob = New SqlCommand("api_sp_JobCalculSynthComptaDepense", oGestConnectSQL.CnxSQLOpen)
            sqlcmdJob.CommandType = CommandType.StoredProcedure
            sqlcmdJob.CommandTimeout = 0
            sqlcmdJob.Parameters.Add("@p_dateDebutAn", SqlDbType.DateTime)
            sqlcmdJob.Parameters("@p_dateDebutAn").Value = Convert.ToDateTime("01/01/" + Year(DTPButoireAna.Value).ToString)
            sqlcmdJob.Parameters.Add("@p_dateFinMois", SqlDbType.DateTime)
            sqlcmdJob.Parameters("@p_dateFinMois").Value = DTPButoireAna.Value.ToShortDateString + " 23:59"
            sqlcmdJob.Parameters.Add("@vsociete", SqlDbType.VarChar)
            sqlcmdJob.Parameters("@vsociete").Value = MozartParams.NomSociete

            sqlcmdJob.ExecuteNonQuery()

            MessageBox.Show(My.Resources.TabSyntheseCompta_frmTransTabAnalytique_depenses_succes, My.Resources.Global_suppression, MessageBoxButtons.OK, MessageBoxIcon.Information)

          Catch ex As Exception

            MessageBox.Show(My.Resources.TabSyntheseCompta_frmTransTabAnalytique_remplissage5 + ex.Message)
            Return

          Finally

            Me.Cursor = Cursors.Default

          End Try

        End If

      Else

        MessageBox.Show(My.Resources.TabSyntheseCompta_frmTransTabAnalytique_warning2, My.Resources.Global_Erreur, MessageBoxButtons.OK, MessageBoxIcon.Exclamation)

      End If

    End If

  End Sub

  Private Sub DTPButoireAna_ValueChanged(sender As System.Object, e As System.EventArgs) Handles DTPButoireAna.ValueChanged

    'init
    If ChkRecalcEncours.CheckState = CheckState.Checked Then ChkRecalcEncours.CheckState = CheckState.Unchecked

    'on vérifie s'il existe des données dans TANAHISTO sur ce mois et cette année
    Dim sqlcmd As New SqlCommand("api_sp_VerifDataAnalytique", oGestConnectSQL.CnxSQLOpen)
    sqlcmd.CommandType = CommandType.StoredProcedure
    sqlcmd.Parameters.Add("@p_dateverif", SqlDbType.DateTime)
    sqlcmd.Parameters("@p_dateverif").Value = DTPButoireAna.Value.ToShortDateString + " 23:59"

    Dim dr As SqlDataReader = sqlcmd.ExecuteReader

    Try

      If dr.HasRows = True Then

        dr.Read()
        If dr("NBEXIST") > 0 Then
          ChkRecalcEncours.Visible = RechercheDroitMenu(372)

        Else
          ChkRecalcEncours.Visible = False
        End If

      End If

      dr.Close()

    Catch ex As Exception
      MessageBox.Show(My.Resources.TabSyntheseCompta_frmTransTabAnalytique_DTP + ex.Message, My.Resources.Global_Erreur, MessageBoxButtons.OK, MessageBoxIcon.Error)
    End Try

  End Sub

End Class