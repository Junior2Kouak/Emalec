Imports System.Data.SqlClient
Imports MozartLib

Public Class frmSTTPartenaires

  Private Sub frmSTTPartenaires_Load(sender As System.Object, e As System.EventArgs) Handles MyBase.Load

    Try
      ' TB SAMSIC CITY RES
      CSTFGRPPARTVALIDE.Caption += MozartParams.NomGroupe

      Initboutons(Me)

      Me.Cursor = Cursors.WaitCursor
      'on ouvre la connexion
      If MozartDatabase.cnxMozart.State = ConnectionState.Open Then

        Dim CmdSql As New SqlCommand("api_sp_GetSTTPartenaires", MozartDatabase.cnxMozart)
        CmdSql.CommandType = CommandType.StoredProcedure

        Dim sqlAdpat As SqlDataAdapter = New SqlDataAdapter(CmdSql)
        Dim dtStat As New DataSet
        sqlAdpat.Fill(dtStat)

        ' Traiter la liste des villes cibles et des activités (on substitue, dans le DataSet, la liste d'ids par les vraies valeurs)
        Traiter_dataTable(dtStat.Tables(0))

        GridControl1.DataSource = dtStat.Tables(0)

        CmdSql.Dispose()

        GridControl1.Focus()

      End If

    Catch ex As Exception
      MessageBox.Show(My.Resources.Admin_frmSTTPartenaires_subLoad + ex.Message, My.Resources.Global_Erreur)
    Finally
      Me.Cursor = Cursors.Default
    End Try

  End Sub

  Private Sub Traiter_dataTable(ByVal dtc As System.Data.DataTable)

    ' Récupérer la liste des villes depuis la table TVILLES
    Dim CmdSql As New SqlCommand("select ID, VILLE from TVILLES order by ID", MozartDatabase.cnxMozart)
    Dim dr As SqlDataReader = CmdSql.ExecuteReader

    Dim lstID As New List(Of String)
    Dim LstVillesBDD As New List(Of String)
    While dr.Read()
      lstID.Add(dr("ID"))
      LstVillesBDD.Add(dr("VILLE"))
    End While
    dr.Close()

    ' Récupérer la liste des activités depuis la table TACTIVITES
    CmdSql = New SqlCommand("select ID, VCATEGORIE, VACTIVITE from TACTIVITES order by ID", MozartDatabase.cnxMozart)
    dr = CmdSql.ExecuteReader

    Dim lstIDAct As New List(Of String)
    Dim LstCatBDD As New List(Of String)
    Dim LstCatBDDCount As New List(Of String)
    Dim LstActBDD As New List(Of String)
    While dr.Read()
      lstIDAct.Add(dr("ID"))
      LstCatBDD.Add(dr("VCATEGORIE"))
      LstCatBDDCount.Add("0")  ' Sert uniquement à compter ensuite la catégorie la plus cochée pour déterminer l'activité principale...
      LstActBDD.Add(dr("VACTIVITE"))
    End While
    dr.Close()
    CmdSql.Dispose()

    ' Interpréter la suite d'ID et en sortir la liste de villes
    For cpt = 0 To dtc.DataSet.Tables(0).Rows.Count - 1

      Dim sVilles As String = dtc.DataSet.Tables(0).Rows(cpt).ItemArray.GetValue(7).ToString  ' On récupère la liste des villes
      Dim sActivites As String = dtc.DataSet.Tables(0).Rows(cpt).ItemArray.GetValue(6).ToString  ' On récupère la liste des activités

      ' Pour tests : sVilles = "36;41;43;263;276;280;281;288;291;292;295;306;310;315;330;333;334;342;348;"
      ' Pour tests : sActivites = "1_Inst;1_Maint;1_Dep;1_Astr;15_Inst;15_Maint;15_Dep;15_Astr;24_Inst;24_Maint;24_Dep;24_Astr;39_Inst;39_Maint;39_Dep;39_Astr;49_Inst;49_Maint;49_Dep;49_Astr;"

      Dim IDvilles As String() = sVilles.ToString.Split(";")
      Dim IDactivites As String() = sActivites.ToString.Split(";")

      Dim VillesAafficher As String = ""
      Dim ActivitesAafficher As String = ""

      For i = 0 To IDvilles.Count - 1
        If IDvilles(i).Length > 0 Then
          Dim index = lstID.IndexOf(IDvilles(i))
          VillesAafficher = VillesAafficher & LstVillesBDD.ElementAt(index) & ";"
        End If
      Next i

      If VillesAafficher.Length > 0 Then VillesAafficher = VillesAafficher.Substring(0, VillesAafficher.Length - 1)
      dtc.DataSet.Tables(0).Rows(cpt)(7) = VillesAafficher

      For i = 0 To LstCatBDDCount.Count - 1
        LstCatBDDCount(i) = "0"
      Next i

      For i = 0 To IDactivites.Count - 1
        If IDactivites(i).Length > 0 Then
          Dim index = lstIDAct.IndexOf(IDactivites(i).Substring(0, IDactivites(i).IndexOf("_")))
          ' On compte les coches pour déterminer l'activité générale principale (la catégorie)
          LstCatBDDCount(index) = LstCatBDDCount(index) + 1

          If ActivitesAafficher.IndexOf(LstActBDD.ElementAt(index)) = -1 Then ' On traite les doublons (exemple : si installation et maintenance préventive sur la même activité)
            ActivitesAafficher = ActivitesAafficher & LstActBDD.ElementAt(index) & ";"
          End If

          If ActivitesAafficher.IndexOf(LstCatBDD.ElementAt(index)) = -1 Then ' On traite les doublons (exemple : si installation et maintenance préventive sur la même activité)
            ActivitesAafficher = ActivitesAafficher & LstCatBDD.ElementAt(index) & ";"
          End If

        End If
      Next i

      If ActivitesAafficher.Length > 0 Then ActivitesAafficher = ActivitesAafficher.Substring(0, ActivitesAafficher.Length - 1)
      dtc.DataSet.Tables(0).Rows(cpt)(6) = ActivitesAafficher

      ' Retrouver la catégorie la plus sélectionnée :
      For i = 200 To 1 Step -1
        If LstCatBDDCount.Contains(i.ToString) Then
          dtc.DataSet.Tables(0).Rows(cpt)(9) = LstCatBDD.ElementAt(LstCatBDDCount.IndexOf(i.ToString))
          Exit For
        End If
      Next i
    Next cpt

  End Sub

  Private Sub ButtonExporter_Click(sender As System.Object, e As System.EventArgs) Handles ButtonExporter.Click
    Dim fileName As String = Environment.GetFolderPath(Environment.SpecialFolder.UserProfile) & "\LstSTTPartenaires_" & Today.Year & Today.Month & Today.Day & "_" & TimeOfDay.Hour & TimeOfDay.Minute & ".xls"
    GridControl1.ExportToXls(fileName)
    System.Diagnostics.Process.Start(Environment.GetFolderPath(Environment.SpecialFolder.UserProfile))
  End Sub

  Private Sub BtnFermer_Click(sender As System.Object, e As System.EventArgs) Handles BtnFermer.Click
    Me.Close()
  End Sub

  Private Sub ButtonCarte_Click(sender As System.Object, e As System.EventArgs) Handles ButtonCarte.Click

    Dim NSTFNUM, VSTFNOM, VSTFETRTYPE, VILLESCIBLES, PAYS As String

    'If GridView1.RowCount < 1 Or GridView1.RowCount > 5000 Then
    'MsgBox("Le nombre de lignes sélectionnées doit être compris entre 1 et 5000.", MsgBoxStyle.Information + MsgBoxStyle.OkOnly, "Visualisation carte")
    'Exit Sub
    'End If

    Try

      Me.Cursor = Cursors.WaitCursor

      If MozartDatabase.cnxMozart.State = ConnectionState.Open Then

        Dim CmdSql As New SqlCommand("api_sp_Initialiser_TTMP_STTPartenaires", MozartDatabase.cnxMozart)
        CmdSql.CommandType = CommandType.StoredProcedure
        CmdSql.Parameters.Add("@NPERNUM", SqlDbType.Int).Value = MozartParams.UID

        ' 1 Récupérer la liste des sites sélectionnés
        For cpt = 0 To GridView1.RowCount - 1
          NSTFNUM = GridView1.GetRowCellValue(cpt, "NSTFNUM").ToString
          VSTFNOM = GridView1.GetRowCellValue(cpt, "VSTFNOM").ToString
          VSTFETRTYPE = GridView1.GetRowCellValue(cpt, "VSTFETRTYPE").ToString
          If cpt = 0 Then
            CmdSql.Parameters.Add("@NSTFNUM", SqlDbType.Int).Value = NSTFNUM
            CmdSql.Parameters.Add("@VSTFNOM", SqlDbType.VarChar).Value = Replace(VSTFNOM, "'", "''")
            CmdSql.Parameters.Add("@VSTFETRTYPE", SqlDbType.VarChar).Value = VSTFETRTYPE
            CmdSql.Parameters.Add("@BDELETE", SqlDbType.Int).Value = 1
          Else
            CmdSql.Parameters.Item("@NSTFNUM").Value = NSTFNUM
            CmdSql.Parameters.Item("@VSTFNOM").Value = Replace(VSTFNOM, "'", "''")
            CmdSql.Parameters.Item("@VSTFETRTYPE").Value = VSTFETRTYPE
            CmdSql.Parameters.Item("@BDELETE").Value = 0
          End If

          ' 2 La stocker dans la table temporaire TTMP_STTPartenaires
          CmdSql.ExecuteNonQuery()

        Next

        CmdSql.Dispose()
        CmdSql = Nothing

        Dim filtre As String = ""
        If Not GridView1.ActiveFilterCriteria Is Nothing Then
          filtre = GridView1.ActiveFilterCriteria.ToString()
        End If

        CmdSql = New SqlCommand("api_sp_Initialiser_TTMP_STTPartenaires2", MozartDatabase.cnxMozart)
        CmdSql.CommandType = CommandType.StoredProcedure
        CmdSql.Parameters.Add("@NPERNUM", SqlDbType.Int).Value = MozartParams.UID

        ' 3 Récupérer la liste des villes cibles des sites sélectionnés
        Dim VillesAafficher As New List(Of String)
        Dim Pays_concerne As New List(Of String)

        ' 29/03/2016 : Petit apparté... On cherche les pays sélectionnés pour avoir des icônes de couleurs différentes sur la carte :-(
        Dim LstPays As New List(Of String)
        Dim LstPaysIndice As New List(Of String)
        For cpt = 0 To GridView1.RowCount - 1
          VILLESCIBLES = GridView1.GetRowCellValue(cpt, "VLISTEVILLES").ToString  ' Contient la liste de villes séparées par ;
          PAYS = GridView1.GetRowCellValue(cpt, "VSTFPAYS").ToString

          Dim Villes As String() = VILLESCIBLES.Split(";")

          For i = 0 To Villes.Count - 1
            If Villes(i).Length > 0 And Not VillesAafficher.Contains(Villes(i)) Then
              VillesAafficher.Add(Villes(i))
              Pays_concerne.Add(PAYS)
            End If
          Next i
          If Not LstPays.Contains(PAYS) Then LstPays.Add(PAYS)
        Next cpt

        For c = 1 To LstPays.Count  ' 10 icônes différentes maxi...
          If c < 10 Then
            LstPaysIndice.Add(c.ToString)
          Else
            LstPaysIndice.Add("10")
          End If
        Next

        Dim filtrePays As String = ""
        If filtre.Contains("VSTFPAYS") Then
          filtrePays = GridView1.GetRowCellValue(1, "VSTFPAYS").ToString().ToUpper
        End If

        Dim filtreAafficher As String = ""

        If filtre.Contains("VLISTEACTIVITES") Then
          filtreAafficher = filtre.Substring(filtre.IndexOf("[VLISTEACTIVITES], '"))
          filtreAafficher = filtreAafficher.Substring(filtreAafficher.IndexOf("[VLISTEACTIVITES], '") + 20, filtreAafficher.IndexOf("')") - filtreAafficher.IndexOf("[VLISTEACTIVITES], '") - 20).ToUpper
          For cpt = 0 To VillesAafficher.Count - 1
            If cpt = 0 Then
              CmdSql.Parameters.Add("@PAYS", SqlDbType.VarChar).Value = Pays_concerne.ElementAt(cpt)
              CmdSql.Parameters.Add("@VILLECIBLE", SqlDbType.VarChar).Value = VillesAafficher.ElementAt(cpt)
              CmdSql.Parameters.Add("@ICONE", SqlDbType.VarChar).Value = LstPaysIndice.ElementAt(LstPays.IndexOf(Pays_concerne.ElementAt(cpt)))
              CmdSql.Parameters.Add("@BDELETE", SqlDbType.Int).Value = 1
            Else
              CmdSql.Parameters.Item("@PAYS").Value = Pays_concerne.ElementAt(cpt)
              CmdSql.Parameters.Item("@VILLECIBLE").Value = VillesAafficher.ElementAt(cpt)
              CmdSql.Parameters.Item("@ICONE").Value = LstPaysIndice.ElementAt(LstPays.IndexOf(Pays_concerne.ElementAt(cpt)))
              CmdSql.Parameters.Item("@BDELETE").Value = 0
            End If

            ' 4 La stocker dans la table temporaire TTMP_STTPartenaires2
            CmdSql.ExecuteNonQuery()

          Next cpt
        Else
          CmdSql.Parameters.Add("@BDELETE", SqlDbType.Int).Value = 1
          CmdSql.ExecuteNonQuery()
        End If

        CmdSql.Dispose()
        CmdSql = Nothing

        ' 5 Appeler la map qui récupèrera ces infos
        Dim oFrmBrowser As New FrmBrowser
        ' TB SAMSIC CITY SPEC
        If MozartParams.NomGroupe = "EMALEC" Then
          oFrmBrowser.StartingAddress = "https://maps.emalec.com/STTPartenaires_v2.asp?base=MULTI&NPERNUM=" & MozartParams.UID & "&APP=" & MozartParams.NomSociete & "&FILTRE=" & filtreAafficher & "&FILTREPAYS=" & filtrePays
        End If ' TODO_TB SAMSIC CITY -> else pour samsic
        oFrmBrowser.ShowDialog()

      End If

    Catch ex As Exception
      MessageBox.Show(My.Resources.Admin_frmSTTPartenaires_subClick + ex.Message, My.Resources.Global_Erreur)
    Finally
      Me.Cursor = Cursors.Default
    End Try
  End Sub

  Private Sub GridView1_RowCellClick(sender As Object, e As DevExpress.XtraGrid.Views.Grid.RowCellClickEventArgs) Handles GridView1.RowCellClick

    ' On teste la colonne double-cliquée
    Dim ligne_selectionnee As Integer() = GridView1.GetSelectedRows()
    Dim colonne As DevExpress.XtraGrid.Columns.GridColumn = GridView1.FocusedColumn()

    Dim valeur_cellule As String

    If Not ligne_selectionnee Is Nothing Then
      valeur_cellule = GridView1.GetRowCellValue(ligne_selectionnee.ElementAt(0), colonne).ToString
    Else
      Exit Sub
    End If

    If valeur_cellule = "" Then
      LabelDetails.Visible = False
      ListBoxControl1.Visible = False
      Exit Sub
    End If


    If colonne.AbsoluteIndex = 9 Or colonne.AbsoluteIndex = 10 Then   ' Villes ou Activités
      ListBoxControl1.Items.Clear()
      Dim liste As String() = valeur_cellule.Split(";")
      For i = 0 To liste.Count - 1
        ListBoxControl1.Items.Add(liste(i))
      Next i
      LabelDetails.Visible = True
      ListBoxControl1.Visible = True
    Else
      LabelDetails.Visible = False
      ListBoxControl1.Visible = False
    End If

  End Sub

  Private Sub BtnAffectation_Click(sender As System.Object, e As System.EventArgs) Handles BtnAffectation.Click

    If GridView1.RowCount < 1 Then
      Exit Sub
    End If

    Dim filtre As String = ""
    If Not GridView1.ActiveFilterCriteria Is Nothing Then
      filtre = GridView1.ActiveFilterCriteria.ToString()
      If Not filtre.Contains("VLISTEACTIVITES") Or Not filtre.Contains("VSTFPAYS") Then
        MsgBox(My.Resources.Admin_frmSTTPartenaires_filtrerparpays, MsgBoxStyle.Information + MsgBoxStyle.OkOnly, My.Resources.Global_Attention)
      End If
    Else
      MsgBox(My.Resources.Admin_frmSTTPartenaires_filtrerparpays, MsgBoxStyle.Information + MsgBoxStyle.OkOnly, My.Resources.Global_Attention)
      Exit Sub
    End If

    If filtre.Contains("VLISTEACTIVITES") And filtre.Contains("VSTFPAYS") Then

      Dim oForm As New frmSTTPartenairesAffectation
      oForm.LabelPaysFiltre.Text = GridView1.GetRowCellValue(0, "VSTFPAYS").ToString().ToUpper
      filtre = filtre.Substring(filtre.IndexOf("[VLISTEACTIVITES], '"))
      oForm.LabelActiviteFiltre.Text = filtre.Substring(filtre.IndexOf("[VLISTEACTIVITES], '") + 20, filtre.IndexOf("')") - filtre.IndexOf("[VLISTEACTIVITES], '") - 20).ToUpper
      oForm.ShowDialog()

      ' Nettoyage
      oForm = Nothing

    End If

  End Sub

  Private Sub ButtonGestionVillesCibles_Click(sender As System.Object, e As System.EventArgs) Handles ButtonGestionVillesCibles.Click

    Try
      ' On récupère le n° unique NSTFNUM sélectionné dans la liste
      Dim ligne_selectionnee As Integer() = GridView1.GetSelectedRows()
      Dim sNumSTT As String = GridView1.GetRowCellValue(ligne_selectionnee.ElementAt(0), "NSTFNUM").ToString

      Dim oForm As New frmGestionVillesCibles
      oForm.sNumSTT = sNumSTT
      oForm.ShowDialog()

      ' Nettoyage
      oForm = Nothing

    Catch ex As Exception
      MessageBox.Show(My.Resources.Global_aucune_ligne, My.Resources.Global_Information)
    End Try

  End Sub

  Private Sub ButtonGestionPrestations_Click(sender As System.Object, e As System.EventArgs) Handles ButtonGestionPrestations.Click

    Try
      ' On récupère le n° unique NSTFNUM sélectionné dans la liste
      Dim ligne_selectionnee As Integer() = GridView1.GetSelectedRows()
      Dim sNumSTT As String = GridView1.GetRowCellValue(ligne_selectionnee.ElementAt(0), "NSTFNUM").ToString

      Dim oForm As New frmGestionPrestations
      oForm.sNumSTT = sNumSTT
      oForm.ShowDialog()

      ' Nettoyage
      oForm = Nothing

    Catch ex As Exception
      MessageBox.Show(My.Resources.Global_aucune_ligne, My.Resources.Global_Information)
    End Try

  End Sub

  Private Sub ButtonVoir_Click(sender As System.Object, e As System.EventArgs) Handles ButtonVoir.Click

    Try
      ' On récupère le n° unique NSTFNUM sélectionné dans la liste
      Dim ligne_selectionnee As Integer() = GridView1.GetSelectedRows()
      Dim sNumSTT As String = GridView1.GetRowCellValue(ligne_selectionnee.ElementAt(0), "NSTFNUM").ToString

      Dim CmdSql As New SqlCommand("select SSTFNUMCODE from TREF_STT Where NstfNum = " & sNumSTT, MozartDatabase.cnxMozart)
      Dim dr As SqlDataReader = CmdSql.ExecuteReader

      If Not dr.Read() Then
        MsgBox(My.Resources.Admin_frmSTTPartenaires_Pas_formulaire)
        dr.Close()
        CmdSql.Dispose()
        Exit Sub
      End If

      ' TB SAMSIC CITY SPEC
      If MozartParams.NomGroupe = "EMALEC" Then
        FrmBrowser.StartingAddress = "https://stt.emalec.com/formulaire.aspx?LANGUE=FR&NSTFNUM=" & dr("sstfnumcode") & "&NINTNUM=NULL"
      End If ' TODO_TB SAMSIC CITY -> else pour samsic
      FrmBrowser.Text = My.Resources.Admin_frmSTTPartenaires_formulaire
      FrmBrowser.ShowDialog()

      dr.Close()
      CmdSql.Dispose()

    Catch ex As Exception
      MessageBox.Show(My.Resources.Global_aucune_ligne, My.Resources.Global_Information)
    End Try

  End Sub

  Private Sub BtrecupVilles_Click(sender As System.Object, e As System.EventArgs) Handles BtrecupVilles.Click

    ' Récupérer les données renseignée en web et les intégrer au sous-traitant, dans Mozart
    Try
      ' On récupère le n° unique NSTFNUM sélectionné dans la liste
      Dim ligne_selectionnee As Integer() = GridView1.GetSelectedRows()
      Dim sNumSTT As String = GridView1.GetRowCellValue(ligne_selectionnee.ElementAt(0), "NSTFNUM").ToString

      ' Recherche des informations du formulaire
      Dim CmdSql As New SqlCommand("select VListeVilles from TREF_STT Where NstfNum = " & sNumSTT, MozartDatabase.cnxMozart)
      Dim dr As SqlDataReader = CmdSql.ExecuteReader

      If Not dr.Read() Then
        MsgBox(My.Resources.Admin_frmSTTPartenaires_Pas_formulaire)
        dr.Close()
        CmdSql.Dispose()
        Exit Sub
      End If

      Dim VListeVilles As String = dr("VListeVilles")

      dr.Close()
      CmdSql.Dispose()

      Dim villes() As String = Split(VListeVilles, ";")  ' villes contient la liste des ids de villes cibles

      Dim VListeVillesRecherche As String = ""
      Dim i As Integer
      For i = 0 To UBound(villes) - 1
        CmdSql = New SqlCommand("select VILLE from TVILLES Where id = " & villes(i), MozartDatabase.cnxMozart)
        dr = CmdSql.ExecuteReader

        If dr.Read() Then
          If InStr(VListeVillesRecherche, dr("ville")) = 0 Then
            VListeVillesRecherche = VListeVillesRecherche & dr("ville") & ";"
          End If
        End If
        dr.Close()
        CmdSql.Dispose()
      Next

      ' Recherche des informations du sous-traitant
      CmdSql = New SqlCommand("select VListeVilles from TSTF Where NstfNum = " & sNumSTT, MozartDatabase.cnxMozart)
      dr = CmdSql.ExecuteReader

      Dim VListeVillesActuelle As String = ""
      If dr.Read() Then
        VListeVillesActuelle = dr("VListeVilles")
      End If
      dr.Close()

      Dim Ret As String = vbYes
      If VListeVillesActuelle <> "" Then
        Ret = MsgBox(My.Resources.Admin_frmSTTPartenaires_msg_frm_web, vbQuestion + vbYesNo, My.Resources.Global_confirmation_maj)
      End If

      If Ret = vbYes Then
        ' Mise à jour de TSTF
        VListeVillesRecherche = Replace(VListeVillesRecherche, "'", "''")
        Dim sqlcmdUpdate As New SqlCommand("UPDATE TSTF set VListeVilles = '" & VListeVilles & "', VListeVillesRecherche = '" & VListeVillesRecherche & "' WHERE NSTFNUM = " & sNumSTT, MozartDatabase.cnxMozart)
        sqlcmdUpdate.ExecuteNonQuery()
      End If

    Catch ex As Exception
      MessageBox.Show(My.Resources.Global_aucune_ligne, My.Resources.Global_Information)
    End Try

  End Sub

  Private Sub BtRecupPresta_Click(sender As System.Object, e As System.EventArgs) Handles BtRecupPresta.Click

    ' Récupérer les données renseignée en web et les intégrer au sous-traitant, dans Mozart
    Try
      ' On récupère le n° unique NSTFNUM sélectionné dans la liste
      Dim ligne_selectionnee As Integer() = GridView1.GetSelectedRows()
      Dim sNumSTT As String = GridView1.GetRowCellValue(ligne_selectionnee.ElementAt(0), "NSTFNUM").ToString

      ' Recherche des informations du formulaire
      Dim CmdSql As New SqlCommand("select VListeActivites from TREF_STT Where NstfNum = " & sNumSTT, MozartDatabase.cnxMozart)
      Dim dr As SqlDataReader = CmdSql.ExecuteReader

      If Not dr.Read() Then
        MsgBox(My.Resources.Admin_frmSTTPartenaires_Pas_formulaire)
        dr.Close()
        CmdSql.Dispose()
        Exit Sub
      End If

      Dim VListeActivites As String = dr("VListeActivites")

      dr.Close()
      CmdSql.Dispose()

      Dim competences() As String = Split(VListeActivites, ";")  ' competences contient la liste des activités au format "1_Inst" où 1 représente l'id et Inst la prestation détaillée

      Dim VListeActivitesRecherche As String = ""
      Dim i As Integer
      For i = 0 To UBound(competences) - 1
        CmdSql = New SqlCommand("select VCategorie, VActivite from TACTIVITES Where id = " & competences(i).Substring(0, InStr(competences(i), "_") - 1), MozartDatabase.cnxMozart)
        dr = CmdSql.ExecuteReader
        If dr.Read() Then
          If InStr(VListeActivitesRecherche, dr("VCategorie")) = 0 Then
            VListeActivitesRecherche = VListeActivitesRecherche & dr("VCategorie") & ";"
          End If
          If InStr(VListeActivitesRecherche, dr("VActivite")) = 0 Then
            VListeActivitesRecherche = VListeActivitesRecherche & dr("VActivite") & ";"
          End If
        End If
        dr.Close()
        CmdSql.Dispose()
      Next

      ' Recherche des informations du sous-traitant
      CmdSql = New SqlCommand("select VListeActivites from TSTF Where NstfNum = " & sNumSTT, MozartDatabase.cnxMozart)
      dr = CmdSql.ExecuteReader

      Dim VListeActivitesActuelle As String = ""
      If dr.Read() Then
        VListeActivitesActuelle = dr("VListeActivites")
      End If
      dr.Close()

      Dim Ret As String = vbYes
      If VListeActivitesActuelle <> "" Then
        Ret = MsgBox(My.Resources.Admin_frmSTTPartenaires_msg_frm_web, vbQuestion + vbYesNo, My.Resources.Global_confirmation_maj)
      End If

      If Ret = vbYes Then
        ' Mise à jour de TSTF
        VListeActivitesRecherche = Replace(VListeActivitesRecherche, "'", "''")
        Dim sqlcmdUpdate As New SqlCommand("UPDATE TSTF set VListeActivites = '" & VListeActivites & "', VListeActivitesRecherche = '" & VListeActivitesRecherche & "' WHERE NSTFNUM = " & sNumSTT, MozartDatabase.cnxMozart)
        sqlcmdUpdate.ExecuteNonQuery()
      End If

    Catch ex As Exception
      MessageBox.Show(My.Resources.Global_aucune_ligne, My.Resources.Global_Information)
    End Try

  End Sub
End Class