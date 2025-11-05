Imports System.Data.SqlClient
Imports DevExpress.XtraEditors.Controls
Imports MozartLib

Public Class frmListeCtrlEtanch

  Dim _DtClient As DataTable
  Dim _DtSite As DataTable

  Dim _DtData As DataTable

  Private Sub frmListeCtrlEtanch_Load(sender As Object, e As EventArgs) Handles MyBase.Load

    'init
    DTP_Fin.Value = Now.Date
    DTP_Debut.Value = CDate("01/01/" & DTP_Fin.Value.Year.ToString)

    LoadataClient()

  End Sub

  Private Sub LoadataClient()

    _DtClient = New DataTable

    Dim sqlcmdread As New SqlCommand("api_sp_ListeClientsWithCertFluid", MozartDatabase.cnxMozart)
    sqlcmdread.CommandType = CommandType.StoredProcedure
    sqlcmdread.Parameters.Add("@p_vsociete", SqlDbType.VarChar).Value = MozartParams.NomSociete

    _DtClient.Load(sqlcmdread.ExecuteReader)

    GlookUpClient.Properties.DataSource = _DtClient

  End Sub
  Private Sub LoadataSite(ByVal p_NCLINUM As Int32)

    _DtSite = New DataTable

    Dim sqlcmdread As New SqlCommand("[api_sp_ListeSitesByClient]", MozartDatabase.cnxMozart)
    sqlcmdread.CommandType = CommandType.StoredProcedure
    sqlcmdread.Parameters.Add("@iClient", SqlDbType.Int).Value = p_NCLINUM

    _DtSite.Load(sqlcmdread.ExecuteReader)

    GlookUpSite.Properties.DataSource = _DtSite

  End Sub
  Private Sub BtnFermer_Click(sender As Object, e As EventArgs) Handles BtnFermer.Click
    Me.Close()
  End Sub

  Private Sub frmListeCtrlEtanch_ResizeEnd(sender As Object, e As EventArgs) Handles Me.ResizeEnd

    GCStat.Size = New Size(Me.Size.Width - GCStat.Location.X - 50, Me.Size.Height - GCStat.Location.Y - 50)

  End Sub

  Private Sub frmListeCtrlEtanch_SizeChanged(sender As Object, e As EventArgs) Handles Me.SizeChanged
    GCStat.Size = New Size(Me.Size.Width - GCStat.Location.X - 50, Me.Size.Height - GCStat.Location.Y - 50)
  End Sub

  Private Sub GlookUpClient_EditValueChanged(sender As Object, e As EventArgs) Handles GlookUpClient.EditValueChanged

    If GlookUpClient.EditValue <> 0 Then

      LoadataSite(GlookUpClient.EditValue)

    End If

  End Sub
  Private Sub BtnRechercher_Click(sender As Object, e As EventArgs) Handles BtnRechercher.Click

    LoadData()

  End Sub

  Private Sub LoadData()

    _DtData = New DataTable

    Dim sqlcmdread As New SqlCommand("[api_sp_ListeCertificatEtancheite]", MozartDatabase.cnxMozart)
    sqlcmdread.CommandType = CommandType.StoredProcedure
    sqlcmdread.Parameters.Add("@P_DATE_DEBUT", SqlDbType.DateTime).Value = DTP_Debut.Value
    sqlcmdread.Parameters.Add("@P_DATE_FIN", SqlDbType.DateTime).Value = DTP_Fin.Value
    sqlcmdread.Parameters.Add("@P_NCLINUM", SqlDbType.Int).Value = GlookUpClient.EditValue
    sqlcmdread.Parameters.Add("@P_NSITNUM", SqlDbType.Int).Value = GlookUpSite.EditValue

    _DtData.Load(sqlcmdread.ExecuteReader)

    _DtData.Columns("NCOCHE").ReadOnly = False

    GCStat.DataSource = _DtData

  End Sub

  Private Sub BtnExportXLS_Click(sender As Object, e As EventArgs) Handles BtnExportXLS.Click

    SFD.FileName = "Liste Ctrl Etancheite"
    SFD.Filter = "Fichier Excel |*.xlsx"
    SFD.ShowDialog()

    GCStat.ExportToXlsx(SFD.FileName)

  End Sub

  Private Sub BtnSend_Click(sender As Object, e As EventArgs) Handles BtnSend.Click


    If MessageBox.Show("Voulez-vous envoyer les certificats sélectionnés par mail ?", "Confirmation", MessageBoxButtons.YesNoCancel, MessageBoxIcon.Question) = DialogResult.Yes Then

      Dim sLstPJ As String = ""

      For Each drData As DataRow In _DtData.Rows

        If drData.Item("NCOCHE") = 1 Then

          If IsDBNull(drData.Item("VFILECERT")) Then
            MessageBox.Show("Il n' y a pas de certificat d'étanchéité sur cette intervention " & drData.Item("NDINNUM"), "Erreur", MessageBoxButtons.OK, MessageBoxIcon.Exclamation)

          Else

            If sLstPJ = "" Then
              sLstPJ = drData.Item("VFILECERT")
            Else
              sLstPJ = sLstPJ & ";" & drData.Item("VFILECERT")
            End If

          End If

        End If

      Next

      If sLstPJ = "" Then
        MessageBox.Show("Il n' y a aucun certificat d'étanchéité de sélectionner", "Erreur", MessageBoxButtons.OK, MessageBoxIcon.Exclamation)
        Return
      End If

      Dim sDest As String = InputBox("Adresse(s) mail (séparer par un ;):", "Destinataires")
      Dim oRegUtils As New RegexUtils

      If sDest = "" Then MessageBox.Show("Il faut saisir une adresse mail !", "Erreur", MessageBoxButtons.OK, MessageBoxIcon.Error) : Exit Sub
      If oRegUtils.IsValidEmail(sDest) = False Then MessageBox.Show("L'adresse mail n'est pas correcte !", "Erreur", MessageBoxButtons.OK, MessageBoxIcon.Error) : Exit Sub

      Dim oSendMail As New CSendMail
      oSendMail.Dest = sDest
      oSendMail.Subject = "Liste des certificats d'étanchéité"
      oSendMail.Message = "Bonjour," & vbCrLf _
                                    & "Vous trouverez ci-joint les certificats d'étanchéité." & vbCrLf _
                                    & MozartParams.NomSociete
      oSendMail.PJ = sLstPJ
      oSendMail.SendMail()

    End If

  End Sub

  Private Sub RepositoryItemHyperLinkEdit1_OpenLink(sender As Object, e As OpenLinkEventArgs) Handles RepositoryItemHyperLinkEdit1.OpenLink
    If GVStat.FocusedRowHandle > -1 Then

      Dim drSelect As DataRow = GVStat.GetDataRow(GVStat.FocusedRowHandle)
      If File.Exists(drSelect.Item("VFILECERT")) Then
        Dim oFrmVisu As New frmVisuDoc(drSelect.Item("VFILECERT"))
        oFrmVisu.ShowDialog()
      End If

    End If
  End Sub

  Private Sub RepositoryItemHyperLinkEdit2_OpenLink(sender As Object, e As OpenLinkEventArgs) Handles RepositoryItemHyperLinkEdit2.OpenLink
    If GVStat.FocusedRowHandle > -1 Then

      Dim drSelect As DataRow = GVStat.GetDataRow(GVStat.FocusedRowHandle)
      If File.Exists(drSelect.Item("VFILEBSD")) Then
        Dim oFrmVisu As New frmVisuDoc(drSelect.Item("VFILEBSD"))
        oFrmVisu.ShowDialog()
      End If

    End If
  End Sub
End Class