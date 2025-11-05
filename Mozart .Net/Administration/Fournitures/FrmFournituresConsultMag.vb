Imports System.Data.SqlClient
Imports MozartLib

Public Class FrmFournituresConsultMag

  Dim sFileName As String
  Dim sDestMail As String
  Dim sSerieSelected As String

  Private Sub FrmFournituresConsultMag_Load(sender As System.Object, e As System.EventArgs) Handles MyBase.Load

    'init
    sDestMail = ""
    sFileName = ""
    sSerieSelected = ""
    ' TB SAMSIC CITY RES
    GBLine1.Caption += MozartParams.NomGroupe

    LoadPer()

    RemplirCombo()

  End Sub

  Private Sub RemplirCombo()

    Dim ssql As String = "select NCFOCOD,CCFOCOD from TREF_CFO where langue= 'FR' order by CCFOCOD"

    Dim dtSerie As New DataTable
    Dim dsSerie As SqlDataAdapter = New SqlDataAdapter(ssql, MozartDatabase.cnxMozart)

    Try
      CboSerie.Items.Clear()
      dsSerie.Fill(dtSerie)
      CboSerie.DataSource = dtSerie

    Catch Ex As Exception
      MessageBox.Show(My.Resources.Admin_frmFournituresConsultMag_erreur & Ex.Message)
    End Try

  End Sub

  Private Sub LoadPer()

    Dim ssql As String = String.Format("select ISNULL(TPER.VPERNOM, '') + ' ' + ISNULL(TPER.VPERPRE, '') AS VPERPERSONNE, CONVERT(VARCHAR(15), getdate(), 103) AS DATE, ISNULL(TPER.VPERMAILPRO, '') AS MAIL from TPER WITH (NOLOCK) where TPER.NPERNUM = {0}", MozartParams.UID)

    Try

      Dim sqlread As New SqlCommand(ssql, MozartDatabase.cnxMozart)
      sqlread.CommandType = CommandType.Text
      Dim dr As SqlDataReader = sqlread.ExecuteReader

      If dr.HasRows Then

        dr.Read()
        GBLine2.Caption = GBLine2.Caption.Replace("#VPERPERSONNE#", dr("VPERPERSONNE"))
        GBLine2.Caption = GBLine2.Caption.Replace("#DATE#", dr("DATE"))
        GBLine2.Caption = GBLine2.Caption.Replace("#MAIL#", dr("MAIL"))

        sDestMail = dr("MAIL")

      End If

      dr.Close()

    Catch Ex As Exception
      MessageBox.Show(My.Resources.Admin_frmFournituresConsultMag_erreurLoad & Ex.Message)
    End Try

  End Sub

  Private Sub BtnClose_Click(sender As System.Object, e As System.EventArgs) Handles BtnClose.Click
    Me.Close()
  End Sub

  Private Sub BtnSendMail_Click(sender As System.Object, e As System.EventArgs) Handles BtnSendMail.Click

    If CboSerie.SelectedIndex < 0 Then MessageBox.Show(My.Resources.Admin_frmFournituresConsultMag_select_fourn, My.Resources.Global_Erreur, MessageBoxButtons.OK) : Exit Sub

    Select Case MessageBox.Show(My.Resources.Admin_frmFournituresConsultMag_Excel, My.Resources.Global_Confirmation, MessageBoxButtons.YesNoCancel)

      Case DialogResult.Yes

        sFileName = MozartParams.CheminUtilisateurMozart & "TConsultMag.xlsx"

        'génération du fichier
        GenerateXLS(CboSerie.SelectedValue)

        'envoi par mail
        If sDestMail <> "" Then

          If File.Exists(sFileName) Then

            Dim sMsg As String

            sMsg = My.Resources.Global_bonjour & Chr(10) & Chr(10)
            sMsg = sMsg & My.Resources.Admin_frmFournituresConsultMag_Msg & Chr(10) & Chr(10)
            sMsg = sMsg & MozartParams.NomSociete

            Dim oSendMail As New CSendMail()
            oSendMail.Dest = sDestMail
            ' TB SAMSIC CITY SPEC
            If MozartParams.NomGroupe = "EMALEC" Then
              oSendMail.BlindCopyDest = "info@emalec.com"
            End If
            oSendMail.PJ = sFileName
            oSendMail.Subject = My.Resources.Admin_frmFournituresConsultMag_consultation & sSerieSelected
            oSendMail.Message = sMsg

            oSendMail.SendMail()

          End If

        End If


    End Select

  End Sub


  Private Sub GenerateXLS(ByVal p_NCFOCOD As Int32)

    Dim DtFou As New DataTable
    Dim sqlcmd As New SqlCommand("api_sp_ListeConsultFOMag", MozartDatabase.cnxMozart)
    sqlcmd.CommandType = CommandType.StoredProcedure
    sqlcmd.Parameters.Add("@ncfocod", SqlDbType.Int).Value = p_NCFOCOD

    DtFou.Load(sqlcmd.ExecuteReader)

    GCExportConsultMag.DataSource = DtFou

    'on exporte le fichier en 
    If File.Exists(sFileName) Then File.Delete(sFileName)
    GCExportConsultMag.ExportToXlsx(sFileName)

  End Sub

  Private Sub CboSerie_SelectedIndexChanged(sender As Object, e As System.EventArgs) Handles CboSerie.SelectedIndexChanged

    Dim comboBox As ComboBox = CType(sender, ComboBox)
    Dim selectedSerie = CType(CboSerie.SelectedItem, DataRowView)
    sSerieSelected = selectedSerie(1)

    GBLine3.Caption = String.Format(My.Resources.Admin_frmFournituresConsultMag_consultation0, sSerieSelected)

  End Sub

End Class