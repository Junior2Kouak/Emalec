Imports System.Data.SqlClient
Imports DevExpress.XtraGrid.Views.Base
Imports MozartLib

Public Class frmGestPrestationPrixClient


  Dim dtPrixClients As DataTable
  Dim _NPRESTID As Int32
  Dim _NPRESTPRIX As Decimal


  Public Sub New(ByVal c_NPRESTID As Int32, ByVal c_NPRESTPRIX As Decimal)

    ' Cet appel est requis par le concepteur.
    InitializeComponent()

    ' Ajoutez une initialisation quelconque après l'appel InitializeComponent().
    _NPRESTID = c_NPRESTID
    _NPRESTPRIX = c_NPRESTPRIX

  End Sub


  Private Sub frmGestPrestationPrixClient_Load(sender As Object, e As EventArgs) Handles MyBase.Load

    'init cbo
    Dim oListeCLient As New CListes
    GlookUpClient.Properties.DataSource = oListeCLient.GetListeClients

    TxtPrixRevient.EditValue = _NPRESTPRIX

    LoadData()

  End Sub

  Private Sub LoadData()

    dtPrixClients = New DataTable

    Dim sqlcmd As New SqlCommand("api_sp_ListePrixClientPrest", MozartDatabase.cnxMozart)
    sqlcmd.CommandType = CommandType.StoredProcedure
    sqlcmd.Parameters.Add("@nPrestId", SqlDbType.Int).Value = _NPRESTID
    dtPrixClients.Load(sqlcmd.ExecuteReader())

    GCListePrestaPrixClient.DataSource = dtPrixClients

  End Sub


  Private Sub BtnFermer_Click(sender As Object, e As EventArgs) Handles BtnFermer.Click
    Me.Close()
  End Sub

  Private Sub GVListePrestaPrixClient_FocusedRowChanged(sender As Object, e As FocusedRowChangedEventArgs) Handles GVListePrestaPrixClient.FocusedRowChanged

    If e.FocusedRowHandle < -1 Then
      GlookUpClient.EditValue = 0
      Exit Sub
    End If

    Dim drSelect As DataRow = GVListePrestaPrixClient.GetDataRow(e.FocusedRowHandle)

    If drSelect.Item("BASE") = MozartParams.NomSociete Then
      GlookUpClient.EditValue = drSelect.Item("NCLINUM")
      Txt_NPRIXCLIENT.Text = drSelect.Item("NPRIXCLI")
      Txt_NPRIXCLINUIT.Text = drSelect.Item("NPRIXCLINUIT").ToString
    End If

  End Sub

  Private Sub BtnPrixClientDel_Click(sender As Object, e As EventArgs) Handles BtnPrixClientDel.Click

    If GVListePrestaPrixClient.SelectedRowsCount = 0 Then Exit Sub

    If MessageBox.Show("Voulez-vous vraiment supprimer ce prix ?", "Confirmation", MessageBoxButtons.YesNoCancel, MessageBoxIcon.Question) = DialogResult.Yes Then

      Dim drSelect As DataRow = GVListePrestaPrixClient.GetDataRow(GVListePrestaPrixClient.FocusedRowHandle)
      If drSelect.Item("BASE") = MozartParams.NomSociete Then

        Dim sqlcmd As New SqlCommand("DELETE TPRESTPRIXCLI WHERE NPRESTID = " & _NPRESTID.ToString & " AND NCLINUM = " & drSelect.Item("NCLINUM").ToString, MozartDatabase.cnxMozart)
        sqlcmd.CommandType = CommandType.Text
        sqlcmd.ExecuteNonQuery()

        'init
        GlookUpClient.EditValue = 0
        Txt_NPRIXCLIENT.Text = ""
        Txt_NPRIXCLINUIT.Text = ""

        LoadData()

      Else
        MessageBox.Show("Suppression impossible. Le prix client que vous souhaitez supprimer est affecté sur un client du groupe EMALEC SAS", "Suppression impossible", MessageBoxButtons.OK, MessageBoxIcon.Exclamation)
        Exit Sub
      End If

    End If

  End Sub

  Private Sub BtnPrixClientAdd_Click(sender As Object, e As EventArgs) Handles BtnPrixClientAdd.Click

    'mise en com le 18/01/2022 a la demande Pierre
    'on teste si il existe deja un prix client avec un type en BPU/MARCHE, on ne peut en affecter que sur un seul client
    'Dim oPrestInfo As New CPrestation(_NPRESTID)
    '    If oPrestInfo.NPREST_TYPE_ID = 2 And dtPrixClients.Rows.Count > 1 Then
    '        MessageBox.Show("Sur une prestation de type BPU/MARCHE, on ne peut pas affecter plusieurs prix clients sur la meme prestation !", "Erreur", MessageBoxButtons.OK, MessageBoxIcon.Exclamation)
    '        Exit Sub
    '    End If

    GlookUpClient.EditValue = 0
    Txt_NPRIXCLIENT.Text = ""
    Txt_NPRIXCLINUIT.Text = ""

  End Sub
  Private Sub BtnSavePrixClient_Click(sender As Object, e As EventArgs) Handles BtnSavePrixClient.Click

    If GlookUpClient.EditValue.ToString = "" OrElse GlookUpClient.EditValue = 0 Then
      MessageBox.Show("Il faut sélectionner un client", "Erreur", MessageBoxButtons.OK, MessageBoxIcon.Exclamation)
      Exit Sub
    End If

    If Txt_NPRIXCLIENT.EditValue Is Nothing OrElse Txt_NPRIXCLIENT.EditValue.ToString = "" Then
      MessageBox.Show("Vous devez saisir le montant de vente HT", "Erreur", MessageBoxButtons.OK, MessageBoxIcon.Exclamation)
      Exit Sub
    End If

    'mis en com le 18/01/2022 a la demande de PC
    ''on teste si il existe deja un prix client avec un type en BPU/MARCHE, on ne peut en affecter que sur un seul client
    'Dim oPrestInfo As New CPrestation(_NPRESTID)

    ''GlookUpClient.EditValue

    'If oPrestInfo.NPREST_TYPE_ID = 2 And dtPrixClients.Select("[NCLINUM] <>" & GlookUpClient.EditValue).Count > 0 Then
    '    MessageBox.Show("Sur une prestation de type BPU/MARCHE, on ne peut pas affecter plusieurs prix clients sur la meme prestation !", "Erreur", MessageBoxButtons.OK, MessageBoxIcon.Exclamation)
    '    Exit Sub
    'End If

    Dim drSelect As DataRow = GVListePrestaPrixClient.GetDataRow(GVListePrestaPrixClient.FocusedRowHandle)

    'test si la presta exists
    Dim sqlcmdtest As New SqlCommand(String.Format("SELECT NPRESTID as NB FROM TPRESTPRIXCLI WITH (NOLOCK) WHERE NPRESTID = {0} AND NCLINUM = {1}", _NPRESTID, GlookUpClient.EditValue), MozartDatabase.cnxMozart)
    sqlcmdtest.CommandType = CommandType.Text
    Dim drread As SqlDataReader = sqlcmdtest.ExecuteReader

    If drread.HasRows = True Then
      If MessageBox.Show("Il existe déjà un prix pour ce client et cette prestation." & vbCrLf & "Vous allez modifier le prix existant", "Erreur", MessageBoxButtons.YesNoCancel, MessageBoxIcon.Question) <> vbYes Then
        drread.Close()
        Exit Sub
      End If
    End If
    drread.Close()

    'test prix prix client 
    'jour
    If Not Txt_NPRIXCLIENT.EditValue Is Nothing AndAlso Txt_NPRIXCLIENT.EditValue.ToString <> "" AndAlso CDbl(TxtPrixRevient.Text) > CDbl(Txt_NPRIXCLIENT.Text) Then
      MessageBox.Show("Vous ne pouvez pas enregistrer car le prix de vente de jour est inférieur au prix de revient HT.", "Erreur", MessageBoxButtons.OK, MessageBoxIcon.Exclamation)
      Exit Sub
    End If
    'nuit
    If Not Txt_NPRIXCLINUIT.EditValue Is Nothing AndAlso Txt_NPRIXCLINUIT.EditValue.ToString <> "" AndAlso CDbl(TxtPrixRevient.Text) > CDbl(Txt_NPRIXCLINUIT.Text) Then
      MessageBox.Show("Vous ne pouvez pas enregistrer car le prix de vente de nuit est inférieur au prix de revient HT.", "Erreur", MessageBoxButtons.OK, MessageBoxIcon.Exclamation)
      Exit Sub
    End If

    'test Coef client et prix de rivien
    If TxtPrixRevient.EditValue <> 0 Then
      'jour
      If Not Txt_NPRIXCLIENT.EditValue Is Nothing AndAlso Txt_NPRIXCLIENT.EditValue.ToString <> "" AndAlso (CDbl(Txt_NPRIXCLIENT.Text) / CDbl(TxtPrixRevient.Text)) < 1.2 Then
        If MessageBox.Show("Attention, le coefficient de vente de jour est inférieur à 1,2" & vbCrLf & "Souhaitez-vous forcer l'enregistrement ?", "Confirmation", MessageBoxButtons.YesNoCancel, MessageBoxIcon.Exclamation) <> DialogResult.Yes Then
          Exit Sub
        End If
      End If
      'nuit
      If Not Txt_NPRIXCLINUIT.EditValue Is Nothing AndAlso Txt_NPRIXCLINUIT.EditValue.ToString <> "" AndAlso (CDbl(Txt_NPRIXCLINUIT.Text) / CDbl(TxtPrixRevient.Text)) < 1.2 Then
        If MessageBox.Show("Attention, le coefficient de vente de nuit est inférieur à 1,2" & vbCrLf & "Souhaitez-vous forcer l'enregistrement ?", "Erreur", MessageBoxButtons.YesNoCancel, MessageBoxIcon.Exclamation) <> DialogResult.Yes Then
          Exit Sub
        End If
      End If
    End If

    Dim sqlSave As New SqlCommand("api_sp_CreationPrestationPrixClient", MozartDatabase.cnxMozart)
    sqlSave.CommandType = CommandType.StoredProcedure
    sqlSave.Parameters.Add("@iNumPrest", SqlDbType.Int).Value = _NPRESTID
    sqlSave.Parameters.Add("@iNumCli", SqlDbType.Int).Value = GlookUpClient.EditValue
    sqlSave.Parameters.Add("@iMontant", SqlDbType.Decimal).Value = Txt_NPRIXCLIENT.Text
    sqlSave.Parameters.Add("@iMontant_nuit", SqlDbType.Decimal).Value = If(Txt_NPRIXCLINUIT.Text <> "", Txt_NPRIXCLINUIT.Text, DBNull.Value)

    sqlSave.ExecuteNonQuery()

    LoadData()

    'GVListePrestaPrixClient.ActiveFilterString = "[NCLINUM] = " & GlookUpClient.EditValue.ToString

  End Sub

End Class