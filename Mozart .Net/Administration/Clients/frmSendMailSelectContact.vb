Imports System.Data.SqlClient
Imports MozartLib

Public Class frmSendMailSelectContact

  Dim _DTListeCCL As DataTable
  Dim _ContratEI As C_CONTRATEI
  Dim _sFileJoin As String
  Dim _sRelanceContrat As String

  Dim sMailSender As String

  Public Sub New(ByVal c_ContratEI As Object, ByVal c_FileJoin As Object, Optional ByVal c_sRelanceContrat As String = "")

    ' Cet appel est requis par le concepteur.
    InitializeComponent()

    ' Ajoutez une initialisation quelconque après l'appel InitializeComponent().
    _ContratEI = CType(c_ContratEI, C_CONTRATEI)
    _sFileJoin = c_FileJoin.ToString
    sMailSender = ""
    _sRelanceContrat = c_sRelanceContrat

  End Sub

  Private Sub frmSendMailSelectContact_Load(sender As System.Object, e As System.EventArgs) Handles MyBase.Load

    'init
    sMailSender = ""

    'on charge l adresse mail du createur
    sMailSender = MozartParams.UserMail

    LoadListeContactClient()

    GCListeContact.DataSource = _DTListeCCL

  End Sub

  Private Sub LoadListeContactClient()

    Dim osqlcmdListeCCL As New SqlCommand("[api_sp_ListeContactClientActif]", MozartDatabase.cnxMozart)

    osqlcmdListeCCL.CommandType = CommandType.StoredProcedure
    osqlcmdListeCCL.Parameters.Add("@iClient", SqlDbType.Int).Value = _ContratEI.NCLINUM
    _DTListeCCL = New DataTable

    'on ajoute la checkbox
    _DTListeCCL.Columns.Add("CHECKCCL", Type.GetType("System.Int16"))
    _DTListeCCL.Columns("CHECKCCL").ReadOnly = False
    _DTListeCCL.Columns("CHECKCCL").DefaultValue = 0

    _DTListeCCL.Load(osqlcmdListeCCL.ExecuteReader())

  End Sub

  Private Sub BtnFermer_Click(sender As System.Object, e As System.EventArgs) Handles BtnFermer.Click
    Me.Close()
  End Sub

  Private Sub BtnSendContrat_Click(sender As System.Object, e As System.EventArgs) Handles BtnSendContrat.Click

    Try

      'on teste si au moins 1 contact de coche
      If _DTListeCCL.Select("[CHECKCCL]=1").Count = 0 Then MessageBox.Show(My.Resources.Admin_frmSendMailSelectContact_selectContact, My.Resources.Global_Erreur, MessageBoxButtons.OK, MessageBoxIcon.Exclamation) : Exit Sub

      'on concat les emails
      Dim sListemail As String = ""

      For Each oRow As DataRow In _DTListeCCL.Rows

        If Not oRow.Item("CHECKCCL") Is Nothing Then

          If oRow.Item("CHECKCCL") = 1 Then

            sListemail = sListemail & oRow.Item("VCCLMAIL") & ";"

          End If

        End If

      Next

      'envoi du mail
      Dim oSendMail As New CSendMail()
      oSendMail.Dest = sListemail
      ' TB SAMSIC CITY SPEC
      If MozartParams.NomGroupe = "EMALEC" Then oSendMail.CopyDest = "ssaroul@emalec.com;" & sMailSender
      oSendMail.Subject = My.Resources.Admin_frmSendMailSelectContact_MailSub

      'message différence si on n est en relance
      If _sRelanceContrat = "R" Then
        ' TODO_TB SAMSIC CITY RES
        oSendMail.Message = My.Resources.Admin_frmSendMailSelectContact_MM & vbCrLf & vbCrLf &
                       My.Resources.Admin_frmSendMailSelectContact_EMALEC & vbCrLf &
                       My.Resources.Admin_frmSendMailSelectContact_Planifier & vbCrLf &
                       My.Resources.Admin_frmSendMailSelectContact_Retourner.Replace("#gstrNomGroupe#", MozartParams.NomGroupe) & vbCrLf &
                       MozartParams.NomGroupe & vbCrLf &
                       My.Resources.Admin_frmSendMailSelectContact_Rue & vbCrLf &
                       "69290 SAINT-GENIS-LES-OLLIERES " & vbCrLf & vbCrLf &
                       My.Resources.Admin_frmSendMailSelectContact_Remerciement & vbCrLf &
                       My.Resources.Admin_frmSendMailSelectContact_cordialement & vbCrLf &
                       "Sandrine SAROUL"

      Else
        oSendMail.Message = My.Resources.Admin_frmSendMailSelectContact_MM & vbCrLf & vbCrLf &
                       My.Resources.Admin_frmSendMailSelectContact_EMALEC & vbCrLf &
                       My.Resources.Admin_frmSendMailSelectContact_Règlementation & vbCrLf &
                       My.Resources.Admin_frmSendMailSelectContact_Règle & vbCrLf &
                       My.Resources.Admin_frmSendMailSelectContact_Retourner.Replace("#gstrNomGroupe#", MozartParams.NomGroupe) & vbCrLf &
                       MozartParams.NomGroupe & vbCrLf &
                       My.Resources.Admin_frmSendMailSelectContact_Rue & vbCrLf &
                       "69290 SAINT-GENIS-LES-OLLIERES " & vbCrLf & vbCrLf &
                       My.Resources.Admin_frmSendMailSelectContact_Remerciement & vbCrLf &
                       My.Resources.Admin_frmSendMailSelectContact_cordialement & vbCrLf &
                       "Sandrine SAROUL"
      End If

      ' TB SAMSIC CITY SPEC
      If MozartParams.NomGroupe = "EMALEC" Then oSendMail.BlindCopyDest = "info@emalec.com"

      oSendMail.PJ = _sFileJoin
      oSendMail.SendMail()

      If oSendMail.sError <> "" Then MessageBox.Show(oSendMail.sError, My.Resources.Global_Erreur, MessageBoxButtons.OK, MessageBoxIcon.Exclamation) : Exit Sub

      'mise à jour dans la table des contrat ei de l'envoi
      _ContratEI.SaveContratEiSender()

      'on enregistre le contrat dans la table des contrat
      _ContratEI.SaveContratEiByClient(_sFileJoin)

      'mise a jour dans info client
      _ContratEI.SaveContratEiNoteClient()

      'nettoyage
      _ContratEI.Reinit(_sFileJoin)

      'on ferme la fenetre
      Me.Close()

    Catch ex As Exception
      MessageBox.Show("" + ex.Message, "")
    End Try

  End Sub

  Private Sub RepItemCheckEditCCLSelect_CheckedChanged(sender As Object, e As System.EventArgs) Handles RepItemCheckEditCCLSelect.CheckedChanged
    GVListeContact.PostEditor()
    GCListeContact.Refresh()
  End Sub

  Private Sub GVListeContact_CustomDrawFooter(sender As Object, e As DevExpress.XtraGrid.Views.Base.RowObjectCustomDrawEventArgs) Handles GVListeContact.CustomDrawFooter

    Dim oPos As Rectangle = e.Bounds
    Dim oFormat As New StringFormat
    Dim iNbPerSelected As Int32 = 0

    oPos.Location = New Point(oPos.Left + 1, oPos.Top + 1)
    oPos.Size = New Size(oPos.Width - 2, oPos.Height - 2)

    oFormat.Alignment = StringAlignment.Center

    Dim dttemp As DataTable = GCListeContact.DataSource

    For Each odrtemp As DataRow In dttemp.Rows

      If odrtemp.Item("CHECKCCL") = 1 Then
        iNbPerSelected = iNbPerSelected + 1
      End If

    Next

    e.Appearance.DrawString(e.Cache, String.Format(My.Resources.Admin_frmSendMailSelectContact_NBrContact, iNbPerSelected, _DTListeCCL.Rows.Count), oPos, oFormat)
    e.Handled = True

  End Sub

End Class