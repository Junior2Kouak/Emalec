Imports System.Data.SqlClient
Imports MozartLib

Public Class frmSTTPartenairesAffectation

  Private Sub frmSTTPartenairesAffectation_Load(sender As System.Object, e As System.EventArgs) Handles MyBase.Load

    loadData()

    Timer1.Enabled = True

  End Sub

  Private Sub loadData()

    Try

      Me.Cursor = Cursors.WaitCursor
      'on ouvre la connexion
      If MozartDatabase.cnxMozart.State = ConnectionState.Open Then

        Dim CmdSql As New SqlCommand("select NSTFNUM, VSTFNOM, VSTFVIL, VListeActivites from TSTF inner join TSTFGRP on TSTFGRP.NSTFGRPNUM = TSTF.NSTFGRPNUM where vstfpays like '%" & LabelPaysFiltre.Text & "%' and (vstfetrtype = 'STTP' or vstfetrtype = 'STTPF') and TSTF.cstftyp = 'ST' and VLISTEACTIVITESRECHERCHE like '%" & LabelActiviteFiltre.Text & "%' order by vstfnom", MozartDatabase.cnxMozart)
        Dim dr As SqlDataReader = CmdSql.ExecuteReader

        While dr.Read()
          Dim multiActivite As Boolean
          multiActivite = VerifMultiActivite(dr("VListeActivites"))

          Dim chk As New DataGridViewCheckBoxColumn()
          If multiActivite = True Then
            chk.HeaderCell.Style.ForeColor = Color.Red
          End If
          DataGridView1.Columns.Add(chk)
          chk.HeaderText = dr("VSTFNOM") & vbCrLf & "(" & dr("VSTFVIL") & ")"
          chk.Name = dr("NSTFNUM")

        End While
        dr.Close()

        CmdSql = New SqlCommand("select id, region, ville, pays from tvilles where pays like '%" & LabelPaysFiltre.Text & "%' order by region, ville", MozartDatabase.cnxMozart)
        dr = CmdSql.ExecuteReader

        Dim indexRow As Integer = 0

        While dr.Read()

          DataGridView1.Rows.Add()

          DataGridView1.Rows(indexRow).Cells("CID").Value = dr("ID")
          DataGridView1.Rows(indexRow).Cells("CPays").Value = dr("pays")
          DataGridView1.Rows(indexRow).Cells("CRegion").Value = dr("REGION")
          DataGridView1.Rows(indexRow).Cells("CVille").Value = dr("VILLE")
          DataGridView1.Rows(indexRow).Cells("CVille").Style.BackColor = Color.Orange
          indexRow = indexRow + 1

        End While
        dr.Close()

      End If

      chkGrid()

    Catch ex As Exception
      MessageBox.Show(My.Resources.Admin_frmSTTPartenairesAffectation_SubLoad + ex.Message, My.Resources.Global_Erreur)
    Finally
      Me.Cursor = Cursors.Default
    End Try

  End Sub

  Private Function VerifMultiActivite(ByVal VListeActivites As String) As Boolean

    Dim competences As String() = VListeActivites.Split(";")
    Dim lstIDs As String = ""

    For i = 0 To competences.Count - 1
      If competences(i).Length > 0 Then
        Dim id_unique As String = competences(i).Substring(0, competences(i).IndexOf("_"))
        If lstIDs.IndexOf("," & id_unique) = -1 Then lstIDs = lstIDs & "," & id_unique
      End If
    Next
    lstIDs = lstIDs.Substring(1) ' Enlever la 1ère virgule de la chaine

    'Dim cnxTemp As New SqlConnection()
    'cnxTemp.ConnectionString = cnx.ConnectionString
    'cnxTemp.Open()
    'Dim CmdSql0 As New SqlCommand("select count(distinct vcategorie) from tactivites where id in (" & lstIDs & ")", cnxTemp)
    Dim CmdSql0 As New SqlCommand("select count(distinct vcategorie) from tactivites where id in (" & lstIDs & ")", MozartDatabase.cnxMozart)
    Dim dr0 As SqlDataReader = CmdSql0.ExecuteReader
    dr0.Read()

    If dr0(0) = "1" Then
      Return False
    Else
      Return True
    End If

    dr0.Close()
    CmdSql0.Dispose()
    'cnxTemp.Close()

  End Function

  Private Sub chkGrid()
    ' Cocher les liens villes cibles / STT

    Try

      For i = 4 To DataGridView1.ColumnCount - 1
        Dim nstfnum As String = DataGridView1.Columns.Item(i).Name

        Dim CmdSql As New SqlCommand("select VListeVilles from TSTF where nstfnum = " & nstfnum, MozartDatabase.cnxMozart)
        Dim dr As SqlDataReader = CmdSql.ExecuteReader

        dr.Read()
        Dim vlistevilles As String = ""
        If Not dr("VListeVilles").Equals(System.DBNull.Value) Then
          vlistevilles = dr("VListeVilles")
        End If
        If vlistevilles <> "" Then
          Dim villes As String() = vlistevilles.Split(";")

          For j = 0 To DataGridView1.RowCount - 1
            If villes.Contains(DataGridView1.Rows(j).Cells(0).Value.ToString) Then
              DataGridView1.Rows(j).Cells(i).Value = True
            End If
          Next j

        End If
        dr.Close()
        CmdSql.Dispose()
      Next i

    Catch ex As Exception
      MessageBox.Show(My.Resources.Admin_frmSTTPartenairesAffectation_SubGrid + ex.Message, My.Resources.Global_Erreur)
      Exit Sub
    Finally
      Me.Cursor = Cursors.Default
    End Try
  End Sub

  Private Sub initCarte()

    Dim NSTFNUM, VSTFNOM, VSTFETRTYPE As String

    Try

      Me.Cursor = Cursors.WaitCursor

      If MozartDatabase.cnxMozart.State = ConnectionState.Open Then

        Dim CmdSql As New SqlCommand("api_sp_Initialiser_TTMP_STTPartenaires", MozartDatabase.cnxMozart)
        CmdSql.CommandType = CommandType.StoredProcedure
        CmdSql.Parameters.Add("@NPERNUM", SqlDbType.Int).Value = MozartParams.UID

        Dim LstVilles As New List(Of String)
        Dim LstIcones As New List(Of String)
        For i = 0 To DataGridView1.RowCount - 1
          LstVilles.Add(DataGridView1.Rows(i).Cells(3).Value.ToString)
          LstIcones.Add("0")
        Next i

        ' 1 Récupérer la liste des sites sélectionnés
        For cpt = 4 To DataGridView1.ColumnCount - 1
          NSTFNUM = DataGridView1.Columns.Item(cpt).Name
          VSTFNOM = DataGridView1.Columns.Item(cpt).HeaderText
          VSTFNOM = VSTFNOM.Replace(vbCrLf, " ")
          VSTFETRTYPE = ""
          If cpt = 4 Then
            CmdSql.Parameters.Add("@NSTFNUM", SqlDbType.Int).Value = NSTFNUM
            CmdSql.Parameters.Add("@VSTFNOM", SqlDbType.VarChar).Value = Replace(VSTFNOM, "'", "''")
            CmdSql.Parameters.Add("@VSTFETRTYPE", SqlDbType.VarChar).Value = VSTFETRTYPE
            CmdSql.Parameters.Add("@COULEUR", SqlDbType.VarChar).Value = (cpt - 3).ToString
            CmdSql.Parameters.Add("@BDELETE", SqlDbType.Int).Value = 1
          Else
            CmdSql.Parameters.Item("@NSTFNUM").Value = NSTFNUM
            CmdSql.Parameters.Item("@VSTFNOM").Value = Replace(VSTFNOM, "'", "''")
            CmdSql.Parameters.Item("@VSTFETRTYPE").Value = VSTFETRTYPE
            CmdSql.Parameters.Item("@COULEUR").Value = (cpt - 3).ToString
            CmdSql.Parameters.Item("@BDELETE").Value = 0
          End If

          ' 2 La stocker dans la table temporaire TTMP_STTPartenaires
          CmdSql.ExecuteNonQuery()

          ' 3 Identifier les villes cibles avec un numéro de couleur pour la Google map...
          For cpt2 = 0 To DataGridView1.RowCount - 1
            'DataGridView1.Rows(cpt2).Cells(3).Style.BackColor = Color.Orange  ' Par défaut, ville pas affectée
            If DataGridView1.Rows(cpt2).Cells(cpt).Value = True Then
              ' Case cochée une fois maxi
              If LstIcones.ElementAt(cpt2) = "0" Then
                DataGridView1.Rows(cpt2).Cells(3).Style.BackColor = Color.White
              Else
                ' Case cochée plusieurs fois
                DataGridView1.Rows(cpt2).Cells(3).Style.BackColor = Color.Red
              End If
              LstIcones(cpt2) = (cpt - 3).ToString
            End If
          Next cpt2
        Next cpt

        Dim CmdSql2 As New SqlCommand("api_sp_Initialiser_TTMP_STTPartenaires2", MozartDatabase.cnxMozart)
        CmdSql2.CommandType = CommandType.StoredProcedure
        CmdSql2.Parameters.Add("@NPERNUM", SqlDbType.Int).Value = MozartParams.UID

        For cpt2 = 0 To DataGridView1.RowCount - 1
          If cpt2 = 0 Then
            CmdSql2.Parameters.Add("@PAYS", SqlDbType.VarChar).Value = DataGridView1.Rows(cpt2).Cells(1).Value.ToString
            CmdSql2.Parameters.Add("@VILLECIBLE", SqlDbType.VarChar).Value = DataGridView1.Rows(cpt2).Cells(3).Value.ToString
            CmdSql2.Parameters.Add("@ICONE", SqlDbType.VarChar).Value = LstIcones.ElementAt(cpt2)
            CmdSql2.Parameters.Add("@BDELETE", SqlDbType.Int).Value = 1
          Else
            CmdSql2.Parameters.Item("@PAYS").Value = DataGridView1.Rows(cpt2).Cells(1).Value.ToString
            CmdSql2.Parameters.Item("@VILLECIBLE").Value = Replace(DataGridView1.Rows(cpt2).Cells(3).Value.ToString, "'", "''")
            CmdSql2.Parameters.Item("@ICONE").Value = LstIcones.ElementAt(cpt2)
            CmdSql2.Parameters.Item("@BDELETE").Value = 0
          End If

          ' 4 La stocker dans la table temporaire TTMP_STTPartenaires2
          CmdSql2.ExecuteNonQuery()

        Next cpt2

        CmdSql2.Dispose()
        CmdSql2 = Nothing

        CmdSql.Dispose()
        CmdSql = Nothing

        ' 5 Appeler la map qui récupèrera ces infos
        ' TB SAMSIC CITY SPEC
        If MozartParams.NomGroupe = "EMALEC" Then
          WebBrowser1.Navigate("https://maps.emalec.com/STT_Selectionnes_par_couleur.asp?base=MULTI&NPERNUM=" & MozartParams.UID & "&APP=" & MozartParams.NomSociete)
        End If ' TODO_TB SAMSIC CITY -> else pour samsic

      End If

    Catch ex As Exception
      MessageBox.Show(My.Resources.Admin_frmSTTPartenairesAffectation_Subinit + ex.Message, My.Resources.Global_Erreur)
    Finally
      Me.Cursor = Cursors.Default
    End Try
  End Sub
  Private Sub BtnFermer_Click(sender As System.Object, e As System.EventArgs) Handles BtnFermer.Click
    Me.Close()
  End Sub

  Private Sub Timer1_Tick(sender As System.Object, e As System.EventArgs) Handles Timer1.Tick

    ' Timer pour afficher le tableau complètement avant d'afficher la carte, car long...
    Timer1.Enabled = False
    initCarte()

  End Sub

  Private Sub BtEnreg_Click(sender As System.Object, e As System.EventArgs) Handles BtEnreg.Click
    ' Enregistrer les villes liées au STT
    Dim NSTFNUM As String
    Dim villescibles As String
    Dim villesciblesRecherche As String

    ' Enlever les filtres éventuels
    TextBox1.Text = ""
    TextBox2.Text = ""

    For cpt = 4 To DataGridView1.ColumnCount - 1
      NSTFNUM = DataGridView1.Columns.Item(cpt).Name
      villescibles = ""
      villesciblesRecherche = ""
      For cpt2 = 0 To DataGridView1.RowCount - 1
        DataGridView1.Rows(cpt2).Cells("CVille").Style.BackColor = Color.Orange
        If DataGridView1.Rows(cpt2).Cells(cpt).Value = True Then
          ' ATTENTION A L'ORDRE DES COLONNES DANS LE TABLEAU
          villescibles = villescibles & DataGridView1.Rows(cpt2).Cells(0).Value & ";"   ' ids
          villesciblesRecherche = villesciblesRecherche & DataGridView1.Rows(cpt2).Cells(3).Value & ";"   ' villes
        End If
      Next

      ' Update TSTF
      Dim sqlcmdUpdate As SqlCommand
      sqlcmdUpdate = New SqlCommand("update TSTF set VListeVilles = '" & villescibles & "', VListeVillesRecherche = '" & villesciblesRecherche & "' WHERE NSTFNUM = " & NSTFNUM, MozartDatabase.cnxMozart)
      sqlcmdUpdate.ExecuteNonQuery()

    Next cpt

    MsgBox(My.Resources.Admin_frmSTTPartenairesAffectation_cart_maj, MsgBoxStyle.Information + MsgBoxStyle.OkOnly, My.Resources.Global_EnregistrementOK)
    initCarte()
  End Sub

  Private Sub TextBox1_TextChanged(sender As System.Object, e As System.EventArgs) Handles TextBox1.TextChanged
    ' Filtrer sur région

    Dim s1 As String = TextBox1.Text.ToUpper
    Dim s2 As String = TextBox2.Text.ToUpper

    If s1 = "" And s2 = "" Then

      For i = 0 To DataGridView1.Rows.Count - 1
        DataGridView1.Rows(i).Visible = True
      Next i

    Else
      ' Filtrer
      For i = 0 To DataGridView1.Rows.Count - 1

        If DataGridView1.Rows(i).Cells("CRegion").Value.ToString.ToUpper.Contains(s1) And DataGridView1.Rows(i).Cells("CVille").Value.ToString.ToUpper.Contains(s2) Then
          DataGridView1.Rows(i).Visible = True
        Else
          DataGridView1.Rows(i).Visible = False
        End If

      Next i
    End If
  End Sub

  Private Sub TextBox2_TextChanged(sender As System.Object, e As System.EventArgs) Handles TextBox2.TextChanged
    ' Filtrer sur ville

    Dim s3 As String = TextBox1.Text.ToUpper
    Dim s4 As String = TextBox2.Text.ToUpper

    If s4 = "" And s3 = "" Then

      For i = 0 To DataGridView1.Rows.Count - 1
        DataGridView1.Rows(i).Visible = True
      Next i

    Else
      ' Filtrer
      For i = 0 To DataGridView1.Rows.Count - 1

        If DataGridView1.Rows(i).Cells("CVille").Value.ToString.ToUpper.Contains(s4) And DataGridView1.Rows(i).Cells("CRegion").Value.ToString.ToUpper.Contains(s3) Then
          DataGridView1.Rows(i).Visible = True
        Else
          DataGridView1.Rows(i).Visible = False
        End If

      Next i
    End If
  End Sub
End Class