Imports System.Data.SqlClient
Imports DevExpress.XtraGrid.Views.Base
Imports DevExpress.XtraReports.UI
Imports DevExpress.LookAndFeel
Imports MozartLib

Public Class FrmRapportFm_ListeRapportFM


    Dim DtListeRapportFM As DataTable
    Dim _NCLINUM As Int32

    Dim _VisuActif As Boolean

    Public Sub New(ByVal C_NCLINUM As Object)

        ' Cet appel est requis par le concepteur.
        InitializeComponent()

        ' Ajoutez une initialisation quelconque après l'appel InitializeComponent().
        _NCLINUM = Convert.ToInt32(C_NCLINUM)
        _VisuActif = True

    End Sub

    Private Sub FrmRapportFm_ListeClients_Load(sender As Object, e As EventArgs) Handles MyBase.Load


        'init
        LblTitre.Text = "Liste des rapports FM du client {0}"

        LoadData()

    End Sub

    Private Sub LoadData()

        DtListeRapportFM = New DataTable

    Dim sqlcmd As New SqlCommand("[api_sp_Rapport_FM_Liste]", MozartDatabase.cnxMozart)
    sqlcmd.CommandType = CommandType.StoredProcedure
        sqlcmd.Parameters.Add("@P_NCLINUM", SqlDbType.Int).Value = _NCLINUM
        sqlcmd.Parameters.Add("@P_VCLINOM", SqlDbType.VarChar, 150)
        sqlcmd.Parameters("@P_VCLINOM").Direction = ParameterDirection.Output
        sqlcmd.Parameters.Add("@P_BRAPPORT_FM_ACTIF", SqlDbType.Bit).Value = _VisuActif

        DtListeRapportFM.Load(sqlcmd.ExecuteReader)

        LblTitre.Text = String.Format(LblTitre.Text, sqlcmd.Parameters("@P_VCLINOM").Value)

        GCListeRapportFM.DataSource = DtListeRapportFM

    End Sub

    Private Sub BtnAddRapportFM_Click(sender As Object, e As EventArgs) Handles BtnAddRapportFM.Click

        'Dim oRapportFM As New CRapportFM(_NCLINUM, 0)

        Dim oFrmRapportFmMaster As New FrmRapportFM_Detail(_NCLINUM, 0)
        oFrmRapportFmMaster.ShowDialog()

        'If oFrmRapportFmMaster.Cancel = False Then
        '    If MessageBox.Show("Voulez-vous visualiser le rapport FM ?", "Confirmation", MessageBoxButtons.YesNoCancel, MessageBoxIcon.Question) = vbYes Then
        '        BtnVisualiser.PerformClick()
        '    End If
        'End If

        LoadData()

    End Sub


    Private Sub BtnClose_Click(sender As Object, e As EventArgs) Handles BtnClose.Click

        Me.Close()

    End Sub

    Private Sub BtnModifier_Click(sender As Object, e As EventArgs) Handles BtnModifier.Click

        If GVListeRapportFM.FocusedRowHandle < 0 Then
            MessageBox.Show("Il faut sélectionner un rapport FM", "Erreur", MessageBoxButtons.OK, MessageBoxIcon.Exclamation)
            Exit Sub
        End If

        Dim drSelect As DataRow = GVListeRapportFM.GetDataRow(GVListeRapportFM.FocusedRowHandle)

        If drSelect.Item("DDATSEND").ToString <> "" Then
            MessageBox.Show("La modification est impossible car le rapport FM a été envoyé", "Erreur", MessageBoxButtons.OK, MessageBoxIcon.Exclamation)
            Exit Sub
        End If

        If GVListeRapportFM.FocusedRowHandle > -1 Then

            'Dim oFrmRapportFmAdmin As New FrmRapportFmAdmin(_NCLINUM, GVListeRapportFM.GetDataRow(GVListeRapportFM.FocusedRowHandle).Item("NIDRAPPORT_FM_CLI"))
            'oFrmRapportFmAdmin.ShowDialog()

            Dim oFrmRapportFmMasterMod As New FrmRapportFM_Detail(_NCLINUM, GVListeRapportFM.GetDataRow(GVListeRapportFM.FocusedRowHandle).Item("NIDRAPPORT_FM_CLI"))
            oFrmRapportFmMasterMod.ShowDialog()

            'If oFrmRapportFmMasterMod.Cancel = False Then
            '    If MessageBox.Show("Voulez-vous visualiser le rapport FM ?", "Confirmation", MessageBoxButtons.YesNoCancel, MessageBoxIcon.Question) = vbYes Then
            '        BtnVisualiser.PerformClick()
            '    End If
            'End If

            LoadData()

        End If

    End Sub

    Private Sub BtnSendTo_Click(sender As Object, e As EventArgs) Handles BtnSendTo.Click

        Dim sTypeOutExport As String = "PDF"

        Try


            If GVListeRapportFM.FocusedRowHandle < 0 Then
                MessageBox.Show("Il faut sélectionner un rapport FM", "Erreur", MessageBoxButtons.OK, MessageBoxIcon.Exclamation)
                Exit Sub
            End If

            Dim drSelect As DataRow = GVListeRapportFM.GetDataRow(GVListeRapportFM.FocusedRowHandle)

            'Dim oRapportFmVisu As New CRapportFM(_NCLINUM, drSelect.Item("NIDRAPPORT_FM_CLI"))

            Select Case MessageBox.Show("Voulez-vous générer le rapport fm au format WORD (.docx) ?" & vbCrLf & "- OUI : Export en Word (docx)" & vbCrLf & "- NON : Export en PDF", "Confirmation", MessageBoxButtons.YesNoCancel, MessageBoxIcon.Question)
                Case DialogResult.Yes
                    sTypeOutExport = "DOCX"
                Case DialogResult.Cancel
                    Return
            End Select

            Dim slistdest As String = InputBox("Veuillez saisir les adresses mail des destinataires (séparées par un point-virgule ';')", "Saisie des destinataires", MozartParams.UserMail)
            'vérifaition adresse mail
            If (slistdest = "") Then Throw New Exception("Aucune adresse mail de destinataire n'a été saisie.")
            Dim pattern As String = "^[a-zA-Z0-9._%+-]+@[a-zA-Z0-9.-]+\.[a-zA-Z]{2,}$"
            Dim isValid As Boolean = False
            Dim sMailVerif As List(Of String) = slistdest.Split(";"c).ToList()
            For Each smail As String In sMailVerif

                isValid = Regex.IsMatch(smail, pattern)
                If (isValid = False) Then
                    MessageBox.Show("L'adresse mail suivante n'est pas valide : " & smail, My.Resources.Global_Erreur, MessageBoxButtons.OK, MessageBoxIcon.Exclamation)
                    Return
                End If

            Next

            Me.Cursor = Cursors.WaitCursor


      Dim sqlcmdinsert As New SqlCommand("[api_sp_Rapport_FM_InsertToGenerate]", MozartDatabase.cnxMozart)
      sqlcmdinsert.CommandType = CommandType.StoredProcedure
            sqlcmdinsert.Parameters.Add("@P_NIDRAPPORT_FM_CLI", SqlDbType.Int).Value = drSelect.Item("NIDRAPPORT_FM_CLI")
            sqlcmdinsert.Parameters.Add("@P_CTYPE", SqlDbType.VarChar, 5).Value = sTypeOutExport
            sqlcmdinsert.Parameters.Add("@P_vmaildest", SqlDbType.VarChar, 1000).Value = slistdest
            sqlcmdinsert.ExecuteNonQuery()

            MessageBox.Show("Le rapport FM va être généré et envoyé aux destinataires suivants :" & vbCrLf & slistdest, "Information", MessageBoxButtons.OK, MessageBoxIcon.Information)

            'Dim OGenRaportFMClient As New CRapportFM_Generate(oRapportFmVisu, sTypeOutExport)
            'Dim sFileOut As String = OGenRaportFMClient.GenerateRapportFM()

            'Dim bMailVisu As Boolean

            'If drSelect.Item("DDATSEND").ToString <> "" Then
            '    bMailVisu = False
            'Else
            '    bMailVisu = True
            'End If

            'Dim oFrmBrowser As New frmVisuDoc(sFileOut, bMailVisu, Me.Name, oRapportFmVisu)
            'oFrmBrowser.NCLINUM = _NCLINUM
            'oFrmBrowser.ShowDialog()

        Catch ex As Exception
            MessageBox.Show("BtnSendTo_Click dans " + Me.Name + " : " + ex.Message, My.Resources.Global_Erreur)
        Finally
            Me.Cursor = Cursors.Default
        End Try
        LoadData()


    End Sub

    Private Sub GVListeRapportFM_FocusedRowChanged(sender As Object, e As FocusedRowChangedEventArgs) Handles GVListeRapportFM.FocusedRowChanged
        If e.FocusedRowHandle < 0 Then Exit Sub

        If GVListeRapportFM.GetDataRow(e.FocusedRowHandle).Item("DDATSEND").ToString <> "" Then
            BtnModifier.Visible = False
        Else
            BtnModifier.Visible = True
        End If
    End Sub

    Private Sub BtnArchiver_Click(sender As Object, e As EventArgs) Handles BtnArchiver.Click

        If GVListeRapportFM.FocusedRowHandle < 0 Then Exit Sub

        If MessageBox.Show("Voulez-vous archiver ce rapport FM ?", "Archiver rapport FM", MessageBoxButtons.YesNoCancel, MessageBoxIcon.Question) = DialogResult.Yes Then


      Dim sqlcmd As New SqlCommand("UPDATE TRAPPORT_FM_CLI SET BRAPPORT_FM_ACTIF = 0 WHERE NIDRAPPORT_FM_CLI = " & GVListeRapportFM.GetDataRow(GVListeRapportFM.FocusedRowHandle).Item("NIDRAPPORT_FM_CLI").ToString(), MozartDatabase.cnxMozart)
      sqlcmd.CommandType = CommandType.Text
            sqlcmd.ExecuteNonQuery()

            LoadData()

        End If

    End Sub

    Private Sub ChkArchives_CheckedChanged(sender As Object, e As EventArgs) Handles ChkArchives.CheckedChanged

        If ChkArchives.Checked = True Then
            _VisuActif = False
            BtnAddRapportFM.Visible = False
            BtnModifier.Visible = False
            BtnArchiver.Visible = False
            LoadData()
        Else
            _VisuActif = True
            BtnAddRapportFM.Visible = True
            BtnModifier.Visible = True
            BtnArchiver.Visible = True
            LoadData()
        End If

    End Sub

    Private Sub RepositoryItemHyperLinkEdit1_OpenLink(sender As Object, e As DevExpress.XtraEditors.Controls.OpenLinkEventArgs) Handles RepositoryItemHyperLinkEdit1.OpenLink
        If GVListeRapportFM.FocusedRowHandle > -1 Then

            Dim drSelect As DataRow = GVListeRapportFM.GetDataRow(GVListeRapportFM.FocusedRowHandle)
            If (drSelect.Item("NIDRAPPORT_FM_CLI") > 0) Then

                Dim ofrmHistoGenerate As New frmRapportFm_HistoGenerate("Historique des générations du rapport FM - " & drSelect.Item("VRAPPORT_FM_TITRE"), drSelect.Item("NIDRAPPORT_FM_CLI"))
                ofrmHistoGenerate.ShowDialog()

            End If

        End If
    End Sub
End Class