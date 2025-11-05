Imports System.Data.SqlClient
Imports MozartLib

Public Class frmAdminRepartitionAnaHrDetail

  Dim _NPERNUM As Int32
  Dim dtRepartition As DataTable

  '0=pas de mode, 1=mode exlusion total, 2 = mode compte ana, 3 = mode DI

  Dim bDetectedChange As Boolean

  Public Sub New(ByVal c_NPERNUM As Int32)

    ' Cet appel est requis par le concepteur.
    InitializeComponent()

    ' Ajoutez une initialisation quelconque après l'appel InitializeComponent().
    _NPERNUM = c_NPERNUM

  End Sub

  Private Sub frmAdminRepartitionAnaHrDetail_Load(sender As Object, e As EventArgs) Handles MyBase.Load

    'init
    Initboutons(Me)
    Label1.Visible = False
    LblValDI.Visible = False

    LoadCbo()

    LoadData()

  End Sub

  Private Sub LoadData()

    'on affiche le nom de la personne
    If _NPERNUM > 0 Then
      G_NPERNUM.EditValue = _NPERNUM
      G_NPERNUM.ReadOnly = True
    Else
      G_NPERNUM.ReadOnly = False
    End If

    Dim sqlcmdRead As New SqlCommand("[api_sp_RepartAnaHr_Detail]", MozartDatabase.cnxMozart)
    sqlcmdRead.CommandType = CommandType.StoredProcedure
    sqlcmdRead.Parameters.Add("@P_NPERNUM", SqlDbType.Int).Value = _NPERNUM
    Dim sqldr_pers As SqlDataReader = sqlcmdRead.ExecuteReader()
    If sqldr_pers.HasRows Then
      While sqldr_pers.Read
        If sqldr_pers.Item("REPART_EXCLU") > 0 Then
          ChkExclusion.Checked = True
        Else
          ChkExclusion.Checked = False
        End If
        If sqldr_pers.Item("REPART_DI") > 0 Then
          ChkDI.Checked = True
          LblValDI.Text = sqldr_pers.Item("REPART_DI_VAL").ToString + " %"
        Else
          ChkDI.Checked = False
          LblValDI.Text = ""
        End If
        If sqldr_pers.Item("NCAT") > 0 Then
          G_CAT.EditValue = sqldr_pers.Item("NCAT")
        Else
          G_CAT.EditValue = Nothing
        End If


      End While

    End If

    dtRepartition = New DataTable
    Dim sqlcmdComptes As New SqlCommand("[api_sp_RepartAnaHr_ListeByNPERNUM]", MozartDatabase.cnxMozart)
    sqlcmdComptes.CommandType = CommandType.StoredProcedure
    sqlcmdComptes.Parameters.Add("@P_NPERNUM", SqlDbType.Int).Value = _NPERNUM


    Dim ColAutoInc As DataColumn = New DataColumn
    ColAutoInc.DataType = Type.GetType("System.Int32")
    ColAutoInc.ColumnName = "IDTMP"
    With ColAutoInc
      .AutoIncrement = True
      .AutoIncrementSeed = 0
      .AutoIncrementStep = 1
    End With

    dtRepartition.Columns.Add(ColAutoInc)
    dtRepartition.Load(sqlcmdComptes.ExecuteReader())

    If dtRepartition IsNot Nothing Then
      GCRepartition.DataSource = dtRepartition
    End If

    'maj du taux di
    LblValDI.Text = RestantDI(GVRepartition.Columns("NVAL_REPART_ANA").SummaryItem.SummaryValue).ToString + " %"

    bDetectedChange = False

  End Sub

  Private Sub BtnEnreg_Click(sender As Object, e As EventArgs) Handles BtnEnreg.Click

    'on teste si personne sélectionnée
    If G_NPERNUM.EditValue Is Nothing Then
      MessageBox.Show("Enregistrement impossible, il faut sélectionner une personne", "Erreur", MessageBoxButtons.OK, MessageBoxIcon.Exclamation)
      Return
    End If

    ' on teste si repartition = 100 % 
    If ChkDI.Checked = True Then
      If (RestantDI(GVRepartition.Columns("NVAL_REPART_ANA").SummaryItem.SummaryValue) + GVRepartition.Columns("NVAL_REPART_ANA").SummaryItem.SummaryValue) <> 100 Then
        MessageBox.Show("Enregistrement impossible, la répartition des heures n'est pas égale à 100 %", "Erreur", MessageBoxButtons.OK, MessageBoxIcon.Exclamation)
        Return
      End If
    Else

      If GVRepartition.RowCount > 0 Then
        If GVRepartition.Columns("NVAL_REPART_ANA").SummaryItem.SummaryValue <> 100 Then
          MessageBox.Show("Enregistrement impossible, la répartition des heures n'est pas égale à 100 %", "Erreur", MessageBoxButtons.OK, MessageBoxIcon.Exclamation)
          Return
        End If
      End If

    End If

    'on recherche s il manque un compte à une ligne
    If dtRepartition.Select("NCANNUM IS NULL OR NCANNUM = 0").Count > 0 Then
      MessageBox.Show("Enregistrement impossible, il manque un compte sur une ligne de la répartition", "Erreur", MessageBoxButtons.OK, MessageBoxIcon.Exclamation)
      Return
    End If

    'recherche doublons compte
    If GVRepartition.RowCount > 0 Then
      Dim dt_verif As DataTable = dtRepartition.Copy
      dt_verif.AcceptChanges()

      Dim resultDoublon = From dbl In dt_verif.AsEnumerable
                          Group dbl By ncannum = dbl.Field(Of Int32)("NCANNUM") Into Group
                          Where Group.Count > 1
                          Select ncannum = ncannum, nb = Group.Count()


      If resultDoublon.Count > 0 Then
        MessageBox.Show("Enregistrement impossible, il y a des comptes en doublons", "Erreur", MessageBoxButtons.OK, MessageBoxIcon.Exclamation)
        Return
      End If
    End If

    'on save si exclusion cocher + on save si di cocher
    Dim sqlcmdSave As New SqlCommand("[api_sp_RepartAnaHr_Save]", MozartDatabase.cnxMozart) With {
      .CommandType = CommandType.StoredProcedure
    }
    sqlcmdSave.Parameters.Add("@P_NPERNUM", SqlDbType.Int).Value = G_NPERNUM.EditValue
    sqlcmdSave.Parameters.Add("@P_BMODE_EXCLU", SqlDbType.Int).Value = If(ChkExclusion.Checked = True, 1, 0)
    sqlcmdSave.Parameters.Add("@P_BMODE_DI", SqlDbType.Int).Value = If(ChkDI.Checked = True, 1, 0)
    sqlcmdSave.Parameters.Add("@P_NVAL_REPART_ANA_DI", SqlDbType.Decimal).Value = RestantDI(GVRepartition.Columns("NVAL_REPART_ANA").SummaryItem.SummaryValue)
    sqlcmdSave.Parameters.Add("@P_NCATEGORIE", SqlDbType.Int).Value = G_CAT.EditValue

    sqlcmdSave.ExecuteNonQuery()

    ''on recherche les lignes supprimer
    Dim dtDel As DataTable = dtRepartition.GetChanges(DataRowState.Deleted)

    If dtDel IsNot Nothing AndAlso dtDel.Rows.Count > 0 Then

      For Each drDel As DataRow In dtDel.Rows

        Delete(G_NPERNUM.EditValue, drDel.Item("NCANNUM", DataRowVersion.Original))

      Next

    End If

    ''on recherche les lignes ajouter ou modifier pour les save
    Dim dtAdd As DataTable
    If bDetectedChange = True Then
      dtAdd = dtRepartition.GetChanges(DataRowState.Added + DataRowState.Modified + DataRowState.Unchanged)
    Else
      dtAdd = dtRepartition.GetChanges(DataRowState.Added + DataRowState.Modified)
    End If
    If dtAdd IsNot Nothing AndAlso dtAdd.Rows.Count > 0 Then

      For Each drAdd As DataRow In dtAdd.Rows

        Save(G_NPERNUM.EditValue, drAdd.Item("NCANNUM"), drAdd.Item("NVAL_REPART_ANA"), G_CAT.EditValue)

      Next

    End If

    'Si catégorié fonctionnel et nouvel NPERNUM, envoi d'un mail pour avertir des modifications
    If (G_CAT.EditValue = 1) And (_NPERNUM = 0) Then
      Dim sqlcmdSend As New SqlCommand("[api_sp_RepartAnaHr_SendMailModif]", MozartDatabase.cnxMozart) With {
        .CommandType = CommandType.StoredProcedure
      }
      sqlcmdSend.Parameters.Add("@P_NPERNUM", SqlDbType.Int).Value = G_NPERNUM.EditValue
      sqlcmdSend.Parameters.Add("@P_MODE", SqlDbType.VarChar).Value = If(_NPERNUM = 0, "C", "M")

      sqlcmdSend.ExecuteNonQuery()
    End If

    If G_NPERNUM.ReadOnly = False Then G_NPERNUM.ReadOnly = True

  End Sub

  Private Sub LoadCbo()

    Dim dtcboUser As New DataTable

    Dim sqlcmd As New SqlCommand("[api_sp_RepartAnaHr_CboUser]", MozartDatabase.cnxMozart) With {
      .CommandType = CommandType.StoredProcedure
    }
    sqlcmd.Parameters.Add("@P_NPERNUM", SqlDbType.Int).Value = _NPERNUM
    dtcboUser.Load(sqlcmd.ExecuteReader())

    G_NPERNUM.Properties.DataSource = dtcboUser

    Dim dtcboCompte As New DataTable

    sqlcmd = New SqlCommand("[api_sp_RepartAnaHr_CboCompte]", MozartDatabase.cnxMozart) With {
      .CommandType = CommandType.StoredProcedure
    }
    dtcboCompte.Load(sqlcmd.ExecuteReader())

    R_NCANNUM.DataSource = dtcboCompte

    Dim dtcboCat As New DataTable

    sqlcmd = New SqlCommand("[api_sp_RepartAnaHr_CboCat]", MozartDatabase.cnxMozart) With {
      .CommandType = CommandType.StoredProcedure
    }
    dtcboCat.Load(sqlcmd.ExecuteReader())

    G_CAT.Properties.DataSource = dtcboCat

  End Sub
  Private Sub BtnAjouter_Click(sender As Object, e As EventArgs) Handles BtnAjouter.Click

    Dim Dr_add As DataRow = dtRepartition.NewRow

    Dr_add.Item("NIDPER_REPART_ANA") = 0
    Dr_add.Item("NCANNUM") = 0
    Dr_add.Item("NVAL_REPART_ANA") = 0
    Dr_add.Item("BMODE") = 2

    dtRepartition.Rows.Add(Dr_add)

  End Sub

  Private Sub BtnSupp_Click(sender As Object, e As EventArgs) Handles BtnSupp.Click

    If (dtRepartition.Rows.Count = 0) Then Exit Sub

    Dim row As DataRow = GVRepartition.GetFocusedDataRow()
    If row Is Nothing Then Exit Sub

    If MessageBox.Show("Voulez-vous supprimer cette ligne ?", My.Resources.Global_Confirmation, MessageBoxButtons.YesNoCancel, MessageBoxIcon.Question) = Windows.Forms.DialogResult.Yes Then

      row.Delete()

      LblValDI.Text = RestantDI(GVRepartition.Columns("NVAL_REPART_ANA").SummaryItem.SummaryValue).ToString + " %"
    End If

  End Sub

  Private Sub ChkDI_CheckedChanged(sender As Object, e As EventArgs) Handles ChkDI.CheckedChanged

    bDetectedChange = True

    If ChkDI.Checked = True Then
      Label1.Visible = True
      LblValDI.Visible = True
      LblValDI.Text = RestantDI(GVRepartition.Columns("NVAL_REPART_ANA").SummaryItem.SummaryValue).ToString + " %"
    Else
      Label1.Visible = False
      LblValDI.Visible = False
    End If

  End Sub
  Private Sub R_NVAL_REPART_ANA_EditValueChanged(sender As Object, e As EventArgs) Handles R_NVAL_REPART_ANA.EditValueChanged
    If GVRepartition.PostEditor() Then
      GVRepartition.UpdateCurrentRow()
      LblValDI.Text = RestantDI(GVRepartition.Columns("NVAL_REPART_ANA").SummaryItem.SummaryValue).ToString + " %"
    End If
  End Sub

  Private Function RestantDI(ByVal nval_not_di As Int32) As Int32

    Return 100 - nval_not_di

  End Function

  Public Sub Delete(ByVal p_NPERNUM As Int32, ByVal p_NCANNUM As Int32)
    Dim sqlcmd_save As New SqlCommand("[api_sp_RepartAnaHr_DeleteByCompte]", MozartDatabase.cnxMozart) With {
      .CommandType = CommandType.StoredProcedure
    }
    sqlcmd_save.Parameters.Add("@P_NPERNUM", SqlDbType.Int).Value = p_NPERNUM
    sqlcmd_save.Parameters.Add("@P_NCANNUM", SqlDbType.Int).Value = p_NCANNUM

    sqlcmd_save.ExecuteNonQuery()

  End Sub

  Public Sub Save(ByVal p_NPERNUM As Int32, ByVal p_NCANNUM As Int32, ByVal p_NVAL_REPART_ANA As Decimal, ByVal p_NCAT As Int32)
    Dim sqlcmd_save As New SqlCommand("[api_sp_RepartAnaHr_SaveCompte]", MozartDatabase.cnxMozart) With {
      .CommandType = CommandType.StoredProcedure
    }
    sqlcmd_save.Parameters.Add("@P_NPERNUM", SqlDbType.Int).Value = p_NPERNUM
    sqlcmd_save.Parameters.Add("@P_NCANNUM", SqlDbType.Int).Value = p_NCANNUM
    sqlcmd_save.Parameters.Add("@P_NVAL_REPART_ANA", SqlDbType.Decimal).Value = p_NVAL_REPART_ANA
    sqlcmd_save.Parameters.Add("@P_NCATEGORIE", SqlDbType.Int).Value = p_NCAT

    sqlcmd_save.ExecuteNonQuery()

  End Sub

  Private Sub G_CAT_EditValueChanged(sender As Object, e As EventArgs) Handles G_CAT.EditValueChanged

    bDetectedChange = True

  End Sub

  Private Sub ChkExclusion_CheckedChanged(sender As Object, e As EventArgs) Handles ChkExclusion.CheckedChanged
    bDetectedChange = True
  End Sub
End Class