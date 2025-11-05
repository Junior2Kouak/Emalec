Imports System.Data.SqlClient
Imports System.Reflection
Imports MozartLib
Imports MZCtrlResources = MozartControls.Properties.Resources
Imports MZUtils = MozartControls.Utils

Public Class frmDetailVehicule

  Private calendar_open As String = ""

  Private iNVEHNUM As Integer
  Private sVSOCIETE As String

  Public Sub New(ByVal c_NVEHNUM As Integer, ByVal c_VSOCIETE As String)

    ' Cet appel est requis par le concepteur.
    InitializeComponent()

    iNVEHNUM = c_NVEHNUM
    sVSOCIETE = c_VSOCIETE

  End Sub

  Public Sub New(ByVal c_NVEHNUM As Integer, ByVal c_VSOCIETE As String, ByVal pBIsArchive As Boolean)
    Me.New(c_NVEHNUM, c_VSOCIETE)

    If pBIsArchive Then
      LabelTitre.Text = LabelTitre.Text & " " & MZCtrlResources.archives
      BtnEnreg.Visible = False
    End If
  End Sub

  Private Sub frmDetailVehicule_Load(ByVal sender As Object, ByVal e As EventArgs) Handles MyBase.Load
    Dim dr As SqlDataReader
    Dim CmdSql
    Dim conducteur As String = ""
    Dim conducteur_libelle As String = ""

    Cursor = Cursors.WaitCursor

    Initboutons(Me)

    cboCarbu.Items.Clear()
    cboCarbu.Items.Add("")
    cboCarbu.Items.Add("Diesel")
    cboCarbu.Items.Add("Essence")
    cboCarbu.Items.Add("Electrique")
    cboCarbu.Items.Add("Hybride")

    initSociete()

    Try

      LabelSociete.Text = sVSOCIETE

      ' Dans tous les cas : création et modification de données :

      ' Marques de véhicules
      CmdSql = New SqlCommand("select distinct VVEHMARQUE from TREF_VEHICULES Order By VVEHMARQUE", MozartDatabase.cnxMozart)
      dr = CmdSql.ExecuteReader

      cboMarque.Items.Add("")
      While dr.Read() 'While données présentes, stocker les éléments en combobox
        cboMarque.Items.Add(dr("VVEHMARQUE"))
      End While

      dr.Close()
      CmdSql.Dispose()

      ' Etats de véhicules
      CmdSql = New SqlCommand("select ID, VETALIB from TREF_VEHETA", MozartDatabase.cnxMozart)
      dr = CmdSql.ExecuteReader

      cboMarque.Items.Add("")
      While dr.Read() 'While données présentes, stocker les éléments en combobox
        cboEtat.Items.Add(dr("VETALIB"))
      End While

      dr.Close()
      CmdSql.Dispose()

      ' Aménagement 
      CmdSql = New SqlCommand("exec [api_sp_comboAmenagementVehicule]", MozartDatabase.cnxMozart)
      dr = CmdSql.ExecuteReader

      cboAmenagement.Items.Add("")
      While dr.Read() 'While données présentes, stocker les éléments en combobox
        cboAmenagement.Items.Add(dr("LIBELLE"))
      End While

      dr.Close()
      CmdSql.Dispose()

      ' gestion des GPS que pour FGA et ST
      'ajout hermann le 190/2055 pour toutes les sociétés
      If ((New List(Of Integer) From {30, 2762, 5026, 5032, 5033, 5034, 5035, 5036, 5037, 5038, 5243}).Contains(MozartParams.UID)) Then

        ApiComboGPS.Visible = True
        cmdRechGPS.Visible = True

        'chargement liste des gps disponibles
        Dim sSql As String = $"select ntelnum, vtelmat from ttel where vtelprofil = 'Geolocalisation' and vtelmat<>'' 
                              and vtelmat not in (select vvehngps from TVEHICULES where VVEHNGPS <> '') order by vtelmat"


        ApiComboGPS.Init(MozartDatabase.cnxMozart, sSql, "ntelnum", "vtelmat", New List(Of String)() From {"ID", "N°"}, 300, 300, True)

      End If

    Catch ex As Exception
      MZUtils.displayError(MethodBase.GetCurrentMethod().Name, ex)
    Finally
      Cursor = Cursors.Default
      dr = Nothing
      CmdSql = Nothing
    End Try

    If iNVEHNUM <> 0 Then
      ' Mode modification
      Try

        Cursor = Cursors.WaitCursor

        ' Données générales
        CmdSql = New SqlCommand("api_sp_InfoVehicule", MozartDatabase.cnxMozart) With {
          .CommandType = CommandType.StoredProcedure
        }
        CmdSql.Parameters.Add("@iNumAuto", SqlDbType.Int).Value = iNVEHNUM
        CmdSql.Parameters.Add("@VSOCIETE", SqlDbType.VarChar).Value = sVSOCIETE

        dr = CmdSql.ExecuteReader

        If dr.HasRows = True Then
          dr.Read()
          CboSociete.SelectedItem = dr("VSOCIETE").ToString
          TxtNum.Text = dr("VVEHNUMCLE").ToString
          txtObs.Text = dr("VVEHOBS").ToString
          txtImmat.Text = dr("VVEHIMAT").ToString
          txtNumSerie.Text = dr("VVEHNSERIE").ToString
          txtNumCode.Text = dr("NVEHCARBUCODE").ToString
          txtNumCarte.Text = dr("VVEHCARBU").ToString
          cboCarbu.SelectedItem = dr("VVEHCARBU2").ToString
          txtKmCours.Text = dr("NVEHDERKM").ToString
          txtInitKM.Text = dr("NVEHINITKM").ToString
          txtGPS.Text = dr("VVEHNGPS").ToString
          txtPneus.Text = dr("VVEHTPNEU").ToString
          cboAmenagement.SelectedItem = dr("VVEHAMENAGEMENT").ToString
          If Not dr("NVEHGCO2").Equals(DBNull.Value) Then
            txtgCO2.Text = dr("NVEHGCO2").ToString
          Else
            txtgCO2.Text = "0"
          End If
          txtNumcartePeage.Text = dr("VVEHNUMPEAGE").ToString


          If Not dr("DVEHCIRCU").Equals(DBNull.Value) Then txtDVEHCIRCU.DateTime = dr("DVEHCIRCU")
          If Not dr("DVEHDENTRE").Equals(DBNull.Value) Then txtDVEHDENTRE.DateTime = dr("DVEHDENTRE")
          If Not dr("DVEHFINCONT").Equals(DBNull.Value) Then txtDVEHFINCONT.DateTime = dr("DVEHFINCONT")
          If Not dr("DVEHDSORTI").Equals(DBNull.Value) Then txtDVEHDSORTI.DateTime = dr("DVEHDSORTI")
          If Not dr("DVEHDCTRL").Equals(DBNull.Value) Then txtDVEHDCTRL.DateTime = dr("DVEHDCTRL")
          If Not dr("DVEHINSTGPS").Equals(DBNull.Value) Then txtDVEHINSTGPS.DateTime = dr("DVEHINSTGPS")
          If Not dr("DVEHCTRLPOL").Equals(DBNull.Value) Then txtDVEHCTRLPOL.DateTime = dr("DVEHCTRLPOL")
          If Not dr("DVEHVISCONF").Equals(DBNull.Value) Then txtDVEHVISCONF.DateTime = dr("DVEHVISCONF")
          txtCertifImmat.Text = dr("VVEHCERTIFIMMAT").ToString
          txtCritAir.Text = dr("VVEHCRITAIR").ToString
          cboGestionnaire.SelectedItem = dr("VVEHGESTIONNAIRE").ToString

          If Not dr("VVEHTYPEPNEU").Equals(DBNull.Value) Then cboTypePneu.Text = dr("VVEHTYPEPNEU")

          Dim nbplaces As String = dr("VNBPLACES").ToString
          Dim marque As String = dr("VVEHMARQUE").ToString
          Dim type As String = dr("VVEHTYPE").ToString
          Dim contrat As String = dr("VVEHCONT").ToString
          Dim etat As String = dr("VETATLIB").ToString
          conducteur = dr("NPERNUM").ToString
          conducteur_libelle = dr("VVEHCOND").ToString

          dr.Close()
          CmdSql.Dispose()

          'charge combo
          ' Liste du personnel
          Dim sSQL As String = String.Format("select NPERNUM, VPERNOM + ' ' + VPERPRE AS VPERNOMPRENOM from TPER WHERE VSOCIETE = '{0}' AND (NPERNUM not in (select NPERNUM from TVEHICULES where NPERNUM is not null)) AND CPERACTIF='O' UNION select 0, ' ' ", sVSOCIETE)
          sSQL = String.Format("{0}UNION select {1}, '{2}'", sSQL, conducteur, (conducteur_libelle).Replace("'", "''"))
          sSQL &= " order by VPERNOM  +  ' ' + VPERPRE "

          Dim dt As New DataTable
          Dim dsCond As SqlDataAdapter = New SqlDataAdapter(sSQL, MozartDatabase.cnxMozart)
          dsCond.Fill(dt)
          cboConducteur.DataSource = dt
          dsCond.Dispose()

          chargeRevs()

          ' Valorisation des combobox
          Dim trouve As Boolean = False

          For i = 0 To cboConducteur.Items.Count - 1
            cboConducteur.SelectedIndex = i
            If cboConducteur.Text.ToUpper = conducteur_libelle.ToUpper Then
              trouve = True
              Exit For
            End If
          Next i
          If trouve = False Then
            cboConducteur.SelectedIndex = -1
            If conducteur <> "0" Then MsgBox(My.Resources.Admin_frmDetailVehicule_val_nontrouvée & conducteur_libelle, MsgBoxStyle.Exclamation + MsgBoxStyle.OkOnly, My.Resources.Global_Erreur_maj)
          End If

          trouve = False
          For i = 0 To cboMarque.Items.Count - 1
            cboMarque.SelectedIndex = i
            If cboMarque.Text.ToUpper = marque.ToUpper Then
              trouve = True
              Exit For
            End If
          Next i
          If trouve = False Then
            cboMarque.SelectedIndex = -1
            If marque <> "" Then MsgBox(My.Resources.Admin_frmDetailVehicule_val_nontrouvée_marque & marque, MsgBoxStyle.Exclamation + MsgBoxStyle.OkOnly, My.Resources.Global_Erreur_maj)
          End If

          trouve = False
          For i = 0 To cboType.Items.Count - 1
            cboType.SelectedIndex = i
            If cboType.Text.ToUpper = type.ToUpper Then
              trouve = True
              Exit For
            End If
          Next i
          If trouve = False Then
            cboType.SelectedIndex = -1
            If type <> "" Then MsgBox(My.Resources.Admin_frmDetailVehicule_val_nontrouvée_type & type, MsgBoxStyle.Exclamation + MsgBoxStyle.OkOnly, My.Resources.Global_Erreur_maj)
          End If

          trouve = False
          For i = 0 To cboContrat.Items.Count - 1
            cboContrat.SelectedIndex = i

            If cboContrat.Text.ToUpper = contrat.ToUpper Then
              trouve = True
              Exit For
            End If
          Next i
          If trouve = False Then
            cboContrat.SelectedIndex = -1
            If contrat <> "" Then MsgBox(My.Resources.Admin_frmDetailVehicule_val_nontrouvée_contrat & contrat, MsgBoxStyle.Exclamation + MsgBoxStyle.OkOnly, My.Resources.Global_Erreur_maj)
          End If

          trouve = False
          For i = 0 To cboEtat.Items.Count - 1
            cboEtat.SelectedIndex = i
            If cboEtat.Text.ToUpper = etat.ToUpper Then
              trouve = True
              Exit For
            End If
          Next i
          If trouve = False Then
            cboEtat.SelectedIndex = -1
            If etat <> "" Then MsgBox(My.Resources.Admin_frmDetailVehicule_val_nontrouvée_etat & etat, MsgBoxStyle.Exclamation + MsgBoxStyle.OkOnly, My.Resources.Global_Erreur_maj)
          End If

          trouve = False
          For i = 0 To cboNbPlaces.Items.Count - 1
            cboNbPlaces.SelectedIndex = i
            If cboNbPlaces.Text.ToUpper = nbplaces.ToUpper Then
              trouve = True
              Exit For
            End If
          Next i
          If trouve = False Then
            If nbplaces <> "" Then MsgBox(My.Resources.Admin_frmDetailVehicule_val_nontrouvée_place & nbplaces, MsgBoxStyle.Exclamation + MsgBoxStyle.OkOnly, My.Resources.Global_Erreur_maj)
            cboNbPlaces.SelectedIndex = -1
          End If

        End If

      Catch ex As Exception
        MZUtils.displayError(MethodBase.GetCurrentMethod().Name, ex)
      Finally
        Cursor = Cursors.Default
        dr = Nothing
        CmdSql = Nothing
      End Try
    Else
      ' Mode création
      GroupBoxRev.Visible = False
      ' Liste du personnel
      Dim sSQL As String = String.Format("select NPERNUM, VPERNOM + ' ' + VPERPRE AS VPERNOMPRENOM from TPER WHERE VSOCIETE = '{0}' AND (NPERNUM not in (select NPERNUM from TVEHICULES where NPERNUM is not null)) AND CPERACTIF='O' UNION select 0, ' ' ", sVSOCIETE)
      sSQL &= " order by VPERNOM  +  ' ' + VPERPRE "

      Dim dt As New DataTable
      Dim dsCond As New SqlDataAdapter(sSQL, MozartDatabase.cnxMozart)
      dsCond.Fill(dt)
      cboConducteur.DataSource = dt
      dsCond.Dispose()
    End If


  End Sub

  Private Sub chargeRevs()
    Dim o_sql = $"select NREVINUM, NVEHNUM, NREVIKM, DREVIDATE, NREVTARIF, VREVCOURROIE from TREVAUTO where NVEHNUM = {iNVEHNUM} Order by NREVIKM"
    Dim CmdSqlRev As New SqlCommand(o_sql, MozartDatabase.cnxMozart)
    Dim sqlAdapt As New SqlDataAdapter(CmdSqlRev)
    Dim dtRev As New DataSet

    sqlAdapt.Fill(dtRev)

    GridControl1.DataSource = dtRev.Tables(0)

    CmdSqlRev.Dispose()
  End Sub

  Private Sub cboMarque_SelectedIndexChanged(ByVal sender As Object, ByVal e As EventArgs) Handles cboMarque.SelectedIndexChanged

    Dim dr As SqlDataReader
    Dim CmdSql

    Try
      Cursor = Cursors.WaitCursor

      ' Données générales
      CmdSql = New SqlCommand(String.Format("select distinct NVEHNUM,VVEHMODELE  from TREF_VEHICULES WHERE VVEHMARQUE='{0}' Order By  VVEHMODELE", cboMarque.Text), MozartDatabase.cnxMozart)
      dr = CmdSql.ExecuteReader
      cboType.Items.Clear()
      cboType.Items.Add("")
      While dr.Read() 'While données présentes, stocker les éléments en combobox
        cboType.Items.Add(dr("VVEHMODELE"))
      End While

      dr.Close()
      CmdSql.Dispose()

    Catch ex As Exception
      MZUtils.displayError(MethodBase.GetCurrentMethod().Name, ex)
    Finally
      Cursor = Cursors.Default
    End Try
  End Sub

  Private Sub BtnEnreg_Click(ByVal sender As Object, ByVal e As EventArgs) Handles BtnEnreg.Click

    ' Contrôles :
    If TxtNum.Text <> "" And Not IsNumeric(TxtNum.Text) Then
      MsgBox(My.Resources.Admin_frmDetailVehicule_Erreur_numérique, MsgBoxStyle.Critical + MsgBoxStyle.OkOnly, My.Resources.Global_Donnée_non_num)
      Exit Sub
    End If

    If txtInitKM.Text <> "" And Not IsNumeric(txtInitKM.Text) Then
      MsgBox(My.Resources.Admin_frmDetailVehicule_Erreur_Kilo_init, MsgBoxStyle.Critical + MsgBoxStyle.OkOnly, My.Resources.Global_Donnée_non_num)
      Exit Sub
    End If

    If txtKmCours.Text <> "" And Not IsNumeric(txtKmCours.Text) Then
      MsgBox(My.Resources.Admin_frmDetailVehicule_Erreur_Kilo_encours, MsgBoxStyle.Critical + MsgBoxStyle.OkOnly, My.Resources.Global_Donnée_non_num)
      Exit Sub
    End If

    If cboType.Text = "" Then
      MsgBox(My.Resources.Admin_frmDetailVehicule_choisissez_modèle, vbInformation + MsgBoxStyle.OkOnly)
      Exit Sub
    End If

    If txtgCO2.Text = "" Then
      MsgBox(My.Resources.Admin_frmDetailVehicule_Erreur_gCO2, MsgBoxStyle.Critical + MsgBoxStyle.OkOnly, My.Resources.Global_Donnée_non_num)
      Exit Sub
    End If

    ' Enregistrement
    Try
      Cursor = Cursors.WaitCursor
      InsertUpdateVehicule()

    Catch ex As Exception
      MZUtils.displayError(MethodBase.GetCurrentMethod().Name, ex)
    Finally
      Cursor = Cursors.Default
    End Try

  End Sub

  Private Sub txtObs_GotFocus(ByVal sender As Object, ByVal e As EventArgs) Handles txtObs.GotFocus
    Dim aux As String = String.Format("{0} le {1} : ", MozartParams.strUID, DateTime.Now.ToString("dd/MM/yy HH:mm"))

    txtObs.Text = aux & vbCrLf & txtObs.Text
  End Sub

  Private Sub BtnAjout_Click(ByVal sender As Object, ByVal e As EventArgs) Handles BtnAjout.Click

    txtKM.Text = ""
    txtDtRev.Text = ""
    TxtTarifs.Text = ""
    TxtCourroie.Text = ""
    BtnModifier.Enabled = False
    BtnSuppr.Enabled = False
    GroupBoxDetails.Visible = True

  End Sub

  Private Sub BtnModifier_Click(ByVal sender As Object, ByVal e As EventArgs) Handles BtnModifier.Click
    Try
      ' On récupère les éléments dont on a besoin, dans la liste
      Dim ligne_selectionnee As Integer() = GridView1.GetSelectedRows()
      LabelNReviNum.Text = GridView1.GetRowCellValue(ligne_selectionnee.ElementAt(0), "NREVINUM").ToString

      txtKM.Text = GridView1.GetRowCellValue(ligne_selectionnee.ElementAt(0), "NREVIKM").ToString
      Try
        Dim lTmpDate As String = GridView1.GetRowCellValue(ligne_selectionnee.ElementAt(0), "DREVIDATE").ToString()
        txtDtRev.DateTime = lTmpDate
      Catch ex As Exception
      End Try
      TxtTarifs.Text = GridView1.GetRowCellValue(ligne_selectionnee.ElementAt(0), "NREVTARIF").ToString
      TxtCourroie.Text = GridView1.GetRowCellValue(ligne_selectionnee.ElementAt(0), "VREVCOURROIE").ToString

      BtnAjout.Enabled = False
      BtnSuppr.Enabled = False
      GroupBoxDetails.Visible = True

    Catch ex As Exception
      MessageBox.Show(My.Resources.Global_aucune_ligne, My.Resources.Global_Information)
    End Try
  End Sub

  Private Sub BtnSuppr_Click(ByVal sender As Object, ByVal e As EventArgs) Handles BtnSuppr.Click
    Try
      ' On récupère les éléments dont on a besoin, dans la liste
      Dim ligne_selectionnee As Integer() = GridView1.GetSelectedRows()
      Dim nrevinum As String = GridView1.GetRowCellValue(ligne_selectionnee.ElementAt(0), "NREVINUM").ToString

      If MsgBox(My.Resources.Admin_frmDetailVehicule_SupprimerRévision, MsgBoxStyle.Question + MsgBoxStyle.YesNo, My.Resources.Global_Attention) = vbYes Then
        Dim o_sql = "delete from TREVAUTO where NREVINUM = " & nrevinum
        Dim CmdSql As New SqlCommand(o_sql, MozartDatabase.cnxMozart)
        CmdSql.ExecuteNonQuery()
        CmdSql.Dispose()

        'Raffraichir l'affichage
        chargeRevs()

      End If

    Catch ex As Exception
      MessageBox.Show(My.Resources.Global_aucune_ligne, My.Resources.Global_Information)
    End Try

  End Sub

  Private Sub BtnV_Click(ByVal sender As Object, ByVal e As EventArgs) Handles BtnV.Click

    ' Enregistrement
    Try
      ' Contrôles :
      If TxtTarifs.Text <> "" And Not IsNumeric(TxtTarifs.Text) Then
        MsgBox(My.Resources.Admin_frmDetailVehicule_Erreur_Saisie_tarif, MsgBoxStyle.Critical + MsgBoxStyle.OkOnly, My.Resources.Global_Donnée_non_num)
        Exit Sub
      End If

      If Not IsNumeric(txtKM.Text) Then
        MsgBox(My.Resources.Admin_frmDetailVehicule_Erreur_Saisie_Km, MsgBoxStyle.Critical + MsgBoxStyle.OkOnly, My.Resources.Global_Donnée_non_num)
        Exit Sub
      End If

      Cursor = Cursors.WaitCursor
      'on ouvre la connexion

      Dim CmdSql As New SqlCommand("api_sp_creationRevAuto", MozartDatabase.cnxMozart) With {.CommandType = CommandType.StoredProcedure}

      If IsNumeric(LabelNReviNum.Text) Then
        CmdSql.Parameters.Add("@iNum", SqlDbType.Int).Value = LabelNReviNum.Text ' Modification
      Else
        CmdSql.Parameters.Add("@iNum", SqlDbType.Int).Value = "0"  ' Nouvelle clé
      End If

      CmdSql.Parameters.Add("@nvehnum", SqlDbType.Int).Value = iNVEHNUM
      CmdSql.Parameters.Add("@nrevikm", SqlDbType.Int).Value = txtKM.Text
      CmdSql.Parameters.Add("@drevidate", SqlDbType.DateTime).Value = IIf(txtDtRev.Text = "", DBNull.Value, txtDtRev.Text)
      CmdSql.Parameters.Add("@nrevtarif", SqlDbType.Decimal).Value = IIf(TxtTarifs.Text = "", DBNull.Value, TxtTarifs.Text)
      CmdSql.Parameters.Add("@courroie", SqlDbType.VarChar).Value = TxtCourroie.Text

      CmdSql.ExecuteNonQuery()
      CmdSql.Dispose()
      CmdSql = Nothing

      Cursor = Cursors.Default
      LabelNReviNum.Text = "NREVINUM" ' Init pour la prochaine fois, si besoin
      BtnModifier.Enabled = True
      BtnSuppr.Enabled = True
      BtnAjout.Enabled = True
      GroupBoxDetails.Visible = False
      chargeRevs()

    Catch ex As Exception
      MZUtils.displayError(MethodBase.GetCurrentMethod().Name, ex)
    Finally
      Cursor = Cursors.Default
    End Try
  End Sub

  Private Sub BtnA_Click(ByVal sender As Object, ByVal e As EventArgs) Handles BtnA.Click
    LabelNReviNum.Text = "NREVINUM"
    txtKM.Text = ""
    txtDtRev.Text = ""
    TxtTarifs.Text = ""
    TxtCourroie.Text = ""
    BtnModifier.Enabled = True
    BtnSuppr.Enabled = True
    BtnAjout.Enabled = True
    GroupBoxDetails.Visible = False
  End Sub

  Private Sub initSociete()
    'initialisation de le combobox "Société"

    Dim CmdSql As New SqlCommand(String.Format("SELECT DISTINCT VSOCIETE FROM TDROIT WHERE NPERNUM = {0} AND NMENUNUM = {1} AND CDROITVAL = 'O' ORDER BY VSOCIETE", MozartParams.UID, CboSociete.Tag), MozartDatabase.cnxMozart)
    Dim dr As SqlDataReader = CmdSql.ExecuteReader
    While dr.Read() 'While données présentes, stocker les éléments en combobox
      CboSociete.Items.Add(dr("VSOCIETE"))
    End While

    CboSociete.SelectedIndex = 0
    dr.Close()
    CmdSql.Dispose()

  End Sub

  Private Sub InsertUpdateVehicule()

    Dim CmdSql As New SqlCommand("api_sp_creationVehicule", MozartDatabase.cnxMozart) With {.CommandType = CommandType.StoredProcedure}

    CmdSql.Parameters.Add("@iNum", SqlDbType.Int).Value = iNVEHNUM ' Modification

    CmdSql.Parameters.Add("@immat", SqlDbType.VarChar).Value = txtImmat.Text
    CmdSql.Parameters.Add("@numSerie", SqlDbType.VarChar).Value = txtNumSerie.Text
    CmdSql.Parameters.Add("@NumCode", SqlDbType.VarChar).Value = IIf(txtNumCode.Text = "", DBNull.Value, txtNumCode.Text)
    CmdSql.Parameters.Add("@Conducteur", SqlDbType.VarChar).Value = cboConducteur.Text
    CmdSql.Parameters.Add("@Type", SqlDbType.VarChar).Value = cboType.Text
    CmdSql.Parameters.Add("@Marque", SqlDbType.VarChar).Value = cboMarque.Text
    CmdSql.Parameters.Add("@Pneus", SqlDbType.VarChar).Value = txtPneus.Text
    CmdSql.Parameters.Add("@contrat", SqlDbType.VarChar).Value = cboContrat.Text
    CmdSql.Parameters.Add("@vObserv", SqlDbType.VarChar).Value = txtObs.Text
    CmdSql.Parameters.Add("@NumCarte", SqlDbType.VarChar).Value = txtNumCarte.Text
    CmdSql.Parameters.Add("@iTech", SqlDbType.Int).Value = IIf(cboConducteur.SelectedValue = Nothing, "0", cboConducteur.SelectedValue)
    CmdSql.Parameters.Add("@iDerKM", SqlDbType.Int).Value = IIf(txtKmCours.Text = "", DBNull.Value, txtKmCours.Text)
    CmdSql.Parameters.Add("@nGPS", SqlDbType.VarChar).Value = txtGPS.Text
    CmdSql.Parameters.Add("@numcle", SqlDbType.VarChar).Value = TxtNum.Text
    CmdSql.Parameters.Add("@iInitKM", SqlDbType.Int).Value = IIf(txtInitKM.Text = "", DBNull.Value, txtInitKM.Text)
    CmdSql.Parameters.Add("@NumCarte2", SqlDbType.VarChar).Value = cboCarbu.Text
    CmdSql.Parameters.Add("@etat", SqlDbType.VarChar).Value = cboEtat.Text
    CmdSql.Parameters.Add("@NbPneu", SqlDbType.Int).Value = DBNull.Value
    CmdSql.Parameters.Add("@NbPlaces", SqlDbType.VarChar).Value = cboNbPlaces.Text
    CmdSql.Parameters.Add("@dDateC", SqlDbType.DateTime).Value = IIf(txtDVEHCIRCU.Text = "", DBNull.Value, txtDVEHCIRCU.Text)
    CmdSql.Parameters.Add("@dDateE", SqlDbType.DateTime).Value = IIf(txtDVEHDENTRE.Text = "", DBNull.Value, txtDVEHDENTRE.Text)
    CmdSql.Parameters.Add("@dDateF", SqlDbType.DateTime).Value = IIf(txtDVEHFINCONT.Text = "", DBNull.Value, txtDVEHFINCONT.Text)
    CmdSql.Parameters.Add("@dDateS", SqlDbType.DateTime).Value = IIf(txtDVEHDSORTI.Text = "", DBNull.Value, txtDVEHDSORTI.Text)
    CmdSql.Parameters.Add("@dDateCtrl", SqlDbType.DateTime).Value = IIf(txtDVEHDCTRL.Text = "", DBNull.Value, txtDVEHDCTRL.Text)
    CmdSql.Parameters.Add("@dDateAss", SqlDbType.DateTime).Value = DBNull.Value
    CmdSql.Parameters.Add("@Dinstall", SqlDbType.DateTime).Value = IIf(txtDVEHINSTGPS.Text = "", DBNull.Value, txtDVEHINSTGPS.Text)
    CmdSql.Parameters.Add("@dDateCtrlPol", SqlDbType.DateTime).Value = IIf(txtDVEHCTRLPOL.Text = "", DBNull.Value, txtDVEHCTRLPOL.Text)
    CmdSql.Parameters.Add("@dDateSim", SqlDbType.DateTime).Value = DBNull.Value
    CmdSql.Parameters.Add("@dDateVisConf", SqlDbType.DateTime).Value = IIf(txtDVEHVISCONF.Text = "", DBNull.Value, txtDVEHVISCONF.Text)
    CmdSql.Parameters.Add("@dDateMontPneu", SqlDbType.DateTime).Value = DBNull.Value
    CmdSql.Parameters.Add("@certifImmat", SqlDbType.VarChar).Value = txtCertifImmat.Text
    CmdSql.Parameters.Add("@critAir", SqlDbType.VarChar).Value = txtCritAir.Text
    CmdSql.Parameters.Add("@Gestionnaire", SqlDbType.VarChar).Value = cboGestionnaire.Text
    CmdSql.Parameters.Add("@nGCO2", SqlDbType.Int).Value = txtgCO2.Text
    CmdSql.Parameters.Add("@NumPeage", SqlDbType.VarChar).Value = txtNumcartePeage.Text
    CmdSql.Parameters.Add("@Amenagement", SqlDbType.VarChar).Value = cboAmenagement.Text
    CmdSql.Parameters.Add("@typePneu", SqlDbType.VarChar).Value = cboTypePneu.Text
    CmdSql.Parameters.Add("@vsociete", SqlDbType.VarChar).Value = CboSociete.Text

    CmdSql.ExecuteNonQuery()
    CmdSql.Dispose()
    CmdSql = Nothing

    MsgBox(My.Resources.Global_EnregistrementOK, MsgBoxStyle.Information + vbOKOnly, "INFO")
    Close()  ' Ne pas commenter, SVP, Nico.

  End Sub

  Private Sub cmdRechGPS_Click(sender As Object, e As EventArgs) Handles cmdRechGPS.Click
    txtGPS.Text = ApiComboGPS.GetText()
  End Sub
End Class