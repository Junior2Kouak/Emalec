Imports System.Data.SqlClient
Imports MozartLib

Public Class frmGestionServiceTechniqueDetails

  Dim nom_FichierDocSpecif As String = ""

  Dim sPathFileNameLoaded As String
  Dim sPathFileNameSelected As String

  Private Sub BtnFermer_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles BtnFermer.Click
    Me.Close()
  End Sub

  Private Sub frmGestionServiceTechniqueDetails_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
    Dim dr As SqlDataReader
    Dim CmdSql

    If IsNumeric(LabelNservtechnum.Text) Then
      ' Mode modification
      Try

        Me.Cursor = Cursors.WaitCursor
        'on ouvre la connexion
        If MozartDatabase.cnxMozart.State = ConnectionState.Open Then

          ' Données générales
          CmdSql = New SqlCommand("select * from tservtech where nservtechnum = " & LabelNservtechnum.Text, MozartDatabase.cnxMozart)
          CmdSql.CommandType = CommandType.Text
          dr = CmdSql.ExecuteReader
          If dr.HasRows = True Then
            dr.Read()
            TxtNom.Text = dr("VSERVTECHNOM").ToString
            TxtAdr1.Text = dr("VSERVTECHAD1").ToString
            TxtAdr2.Text = dr("VSERVTECHAD2").ToString
            TxtCP.Text = dr("VSERVTECHCP").ToString
            TxtVille.Text = dr("VSERVTECHVIL").ToString
            TxtObs.Text = dr("VSERVTECHINFO").ToString
            nom_FichierDocSpecif = dr("VDOCSPECIF").ToString

            sPathFileNameLoaded = RechercheParam("REP_DOCS_SERV_TECH", MozartParams.NomSociete) + dr("VDOCSPECIF").ToString
            sPathFileNameSelected = sPathFileNameLoaded

            If sPathFileNameLoaded <> "" Then TxtFileSrc.Text = nom_FichierDocSpecif
            If dr("CMULTIDOCSPECIF").ToString = "1" Then
              cbMultiDocsDansPDF.Checked = True
            Else
              cbMultiDocsDansPDF.Checked = False
            End If
          End If
          dr.Close()
          CmdSql.Dispose()

          ' Données sécurité
          CmdSql = New SqlCommand("select * from tservtechcont where vservtechconttype  = 'S' and nservtechnum = " & LabelNservtechnum.Text, MozartDatabase.cnxMozart)
          CmdSql.CommandType = CommandType.Text
          dr = CmdSql.ExecuteReader
          If dr.HasRows = True Then
            dr.Read()
            TxtNomsec.Text = dr("VSERVTECHCONTNOM").ToString
            TxtPrenomsec.Text = dr("VSERVTECHCONTPRE").ToString
            ComboCivilitesec.Text = dr("VSERVTECHCONTCIV").ToString
            TxtQualitesec.Text = dr("VSERVTECHCONTQAL").ToString
            TxtTelsec.Text = dr("VSERVTECHCONTTEL").ToString
            TxtPortablesec.Text = dr("VSERVTECHCONTPORT").ToString
            TxtFaxsec.Text = dr("VSERVTECHCONTFAX").ToString
            TxtMailsec.Text = dr("VSERVTECHCONTMAIL").ToString
          End If
          dr.Close()
          CmdSql.Dispose()

          ' Données Techniques
          CmdSql = New SqlCommand("select * from tservtechcont where vservtechconttype  = 'T' and nservtechnum = " & LabelNservtechnum.Text, MozartDatabase.cnxMozart)
          CmdSql.CommandType = CommandType.Text
          dr = CmdSql.ExecuteReader
          If dr.HasRows = True Then
            dr.Read()
            TxtNomtech.Text = dr("VSERVTECHCONTNOM").ToString
            TxtPrenomtech.Text = dr("VSERVTECHCONTPRE").ToString
            ComboCivilitetech.Text = dr("VSERVTECHCONTCIV").ToString
            TxtQualitetech.Text = dr("VSERVTECHCONTQAL").ToString
            TxtTeltech.Text = dr("VSERVTECHCONTTEL").ToString
            TxtPortabletech.Text = dr("VSERVTECHCONTPORT").ToString
            TxtFaxtech.Text = dr("VSERVTECHCONTFAX").ToString
            TxtMailtech.Text = dr("VSERVTECHCONTMAIL").ToString
          End If

          dr.Close()
          CmdSql.Dispose()

        End If

      Catch ex As Exception
        MessageBox.Show(My.Resources.Admin_frmGestionServicesTechniquesDetails_Sub + ex.Message, My.Resources.Global_Erreur)
      Finally
        Me.Cursor = Cursors.Default
        dr = Nothing
        CmdSql = Nothing
      End Try
    Else
      ' Mode création
      ComboCivilitesec.Text = My.Resources.Global_Mme
      ComboCivilitetech.Text = My.Resources.Global_Mme
    End If
  End Sub

  Private Sub ButtonEnreg_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles ButtonEnreg.Click

    Dim sqlcmdUpdate = New SqlCommand("api_sp_CreationServTech", MozartDatabase.cnxMozart)
    sqlcmdUpdate.CommandType = CommandType.StoredProcedure

    If TxtNom.Text <> "" Then

      Try

        If IsNumeric(LabelNservtechnum.Text) Then
          ' Confirmation de l'action par l'utilisateur si on est en modification
          If MessageBox.Show(My.Resources.Admin_frmGestionServicesTechniquesDetails_modif_service_tech & TxtNom.Text & " ?", My.Resources.Admin_frmGestionServicesTechniquesDetails_modif, MessageBoxButtons.YesNo, MessageBoxIcon.Question) = Windows.Forms.DialogResult.No Then
            MessageBox.Show(My.Resources.Admin_frmGestionServicesTechniquesDetails_cancel, My.Resources.Admin_frmGestionServicesTechniquesDetails_modif_données_ab, MessageBoxButtons.OK, MessageBoxIcon.Information)
            Exit Sub
          End If
        End If

        Me.Cursor = Cursors.WaitCursor

        sqlcmdUpdate.Parameters.Clear()

        ' Déclaration des paramètres

        sqlcmdUpdate.Parameters.Add("@iNumServTech", SqlDbType.Int)
        If IsNumeric(LabelNservtechnum.Text) Then
          ' Modification
          sqlcmdUpdate.Parameters("@iNumServTech").Value = LabelNservtechnum.Text
        Else
          ' Création
          sqlcmdUpdate.Parameters("@iNumServTech").Value = "-1"
        End If

        sqlcmdUpdate.Parameters.Add("@vNomServTech", SqlDbType.VarChar)
        sqlcmdUpdate.Parameters("@vNomServTech").Value = TxtNom.Text

        sqlcmdUpdate.Parameters.Add("@vAd1ServTech", SqlDbType.VarChar)
        sqlcmdUpdate.Parameters("@vAd1ServTech").Value = TxtAdr1.Text

        sqlcmdUpdate.Parameters.Add("@vAd2ServTech", SqlDbType.VarChar)
        sqlcmdUpdate.Parameters("@vAd2ServTech").Value = TxtAdr2.Text

        sqlcmdUpdate.Parameters.Add("@vCpServTech", SqlDbType.VarChar)
        sqlcmdUpdate.Parameters("@vCpServTech").Value = TxtCP.Text

        sqlcmdUpdate.Parameters.Add("@vVilServTech", SqlDbType.VarChar)
        sqlcmdUpdate.Parameters("@vVilServTech").Value = TxtVille.Text

        sqlcmdUpdate.Parameters.Add("@vInfoServTech", SqlDbType.VarChar)
        sqlcmdUpdate.Parameters("@vInfoServTech").Value = TxtObs.Text



        sqlcmdUpdate.Parameters.Add("@vNomServTechCS", SqlDbType.VarChar)
        sqlcmdUpdate.Parameters("@vNomServTechCS").Value = TxtNomsec.Text

        sqlcmdUpdate.Parameters.Add("@vPreServTechCS", SqlDbType.VarChar)
        sqlcmdUpdate.Parameters("@vPreServTechCS").Value = TxtPrenomsec.Text

        sqlcmdUpdate.Parameters.Add("@vCivServTechCS", SqlDbType.VarChar)
        sqlcmdUpdate.Parameters("@vCivServTechCS").Value = ComboCivilitesec.Text

        sqlcmdUpdate.Parameters.Add("@vQalServTechCS", SqlDbType.VarChar)
        sqlcmdUpdate.Parameters("@vQalServTechCS").Value = TxtQualitesec.Text

        sqlcmdUpdate.Parameters.Add("@vTelServTechCS", SqlDbType.VarChar)
        sqlcmdUpdate.Parameters("@vTelServTechCS").Value = TxtTelsec.Text

        sqlcmdUpdate.Parameters.Add("@vPortServTechCS", SqlDbType.VarChar)
        sqlcmdUpdate.Parameters("@vPortServTechCS").Value = TxtPortablesec.Text

        sqlcmdUpdate.Parameters.Add("@vFaxServTechCS", SqlDbType.VarChar)
        sqlcmdUpdate.Parameters("@vFaxServTechCS").Value = TxtFaxsec.Text

        sqlcmdUpdate.Parameters.Add("@vMailServTechCS", SqlDbType.VarChar)
        sqlcmdUpdate.Parameters("@vMailServTechCS").Value = TxtMailsec.Text



        sqlcmdUpdate.Parameters.Add("@vNomServTechCT", SqlDbType.VarChar)
        sqlcmdUpdate.Parameters("@vNomServTechCT").Value = TxtNomtech.Text

        sqlcmdUpdate.Parameters.Add("@vPreServTechCT", SqlDbType.VarChar)
        sqlcmdUpdate.Parameters("@vPreServTechCT").Value = TxtPrenomtech.Text

        sqlcmdUpdate.Parameters.Add("@vCivServTechCT", SqlDbType.VarChar)
        sqlcmdUpdate.Parameters("@vCivServTechCT").Value = ComboCivilitetech.Text

        sqlcmdUpdate.Parameters.Add("@vQalServTechCT", SqlDbType.VarChar)
        sqlcmdUpdate.Parameters("@vQalServTechCT").Value = TxtQualitetech.Text

        sqlcmdUpdate.Parameters.Add("@vTelServTechCT", SqlDbType.VarChar)
        sqlcmdUpdate.Parameters("@vTelServTechCT").Value = TxtTeltech.Text

        sqlcmdUpdate.Parameters.Add("@vPortServTechCT", SqlDbType.VarChar)
        sqlcmdUpdate.Parameters("@vPortServTechCT").Value = TxtPortabletech.Text

        sqlcmdUpdate.Parameters.Add("@vFaxServTechCT", SqlDbType.VarChar)
        sqlcmdUpdate.Parameters("@vFaxServTechCT").Value = TxtFaxtech.Text

        sqlcmdUpdate.Parameters.Add("@vMailServTechCT", SqlDbType.VarChar)
        sqlcmdUpdate.Parameters("@vMailServTechCT").Value = TxtMailtech.Text

        sqlcmdUpdate.Parameters.Add("@vDocSpecif", SqlDbType.VarChar)
        sqlcmdUpdate.Parameters("@vDocSpecif").Value = If(sPathFileNameSelected = "", "", nom_FichierDocSpecif)

        sqlcmdUpdate.Parameters.Add("@cMultiDocSpecif", SqlDbType.Char)
        If cbMultiDocsDansPDF.Checked = True Then
          sqlcmdUpdate.Parameters("@cMultiDocSpecif").Value = "1"
        Else
          sqlcmdUpdate.Parameters("@cMultiDocSpecif").Value = "0"
        End If

        sqlcmdUpdate.ExecuteNonQuery()
        sqlcmdUpdate.Dispose()
        sqlcmdUpdate = Nothing

        'si suppresion
        If TxtFileSrc.Text = "" And sPathFileNameLoaded <> "" Then
          If File.Exists(sPathFileNameLoaded) Then File.Delete(sPathFileNameLoaded)
          sPathFileNameLoaded = ""
        End If

        If TxtFileSrc.Text <> "" AndAlso sPathFileNameLoaded <> sPathFileNameSelected And TxtFileSrc.Text.Trim <> "" Then

          If File.Exists(sPathFileNameLoaded) Then File.Delete(sPathFileNameLoaded)

          ' Modif du fichier lié
          File.Copy(sPathFileNameSelected, RechercheParam("REP_DOCS_SERV_TECH", MozartParams.NomSociete) & TxtFileSrc.Text, True)

        End If

        Me.Close()

      Catch ex As Exception
        MessageBox.Show(My.Resources.Admin_frmGestionServicesTechniquesDetails_click + ex.Message, My.Resources.Global_Erreur)
      Finally
        Me.Cursor = Cursors.Default

      End Try

    Else
      MessageBox.Show(My.Resources.Admin_frmGestionServicesTechniquesDetails_nom_service, My.Resources.Global_Erreur, MessageBoxButtons.OK, MessageBoxIcon.Exclamation)
    End If

  End Sub

  Private Sub btnParcourir_Click(sender As System.Object, e As System.EventArgs) Handles btnParcourir.Click

    OFD.Filter = "Fichiers PDF (*.PDF)|*.pdf;"
    OFD.FileName = ""
    OFD.ShowDialog()

    If OFD.FileName <> "" Then

      TxtFileSrc.Text = OFD.SafeFileName  ' Pas besoin du chemin
      nom_FichierDocSpecif = TxtFileSrc.Text
      sPathFileNameSelected = OFD.FileName ' Pas besoin du chemin

    End If

  End Sub

  Private Sub BtnSupprimerDoc_Click(sender As Object, e As EventArgs) Handles BtnSupprimerDoc.Click


    If MessageBox.Show("Voulez-vous définitvement supprimer ce document ?", "Suppression", MessageBoxButtons.YesNoCancel, MessageBoxIcon.Question) = DialogResult.Yes Then

      TxtFileSrc.Text = ""
      sPathFileNameSelected = ""

    End If

  End Sub
End Class