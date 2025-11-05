Imports System.Data.SqlClient
Imports DevExpress.XtraEditors.Controls
Imports DevExpress.XtraGrid.Views.Base
Imports DevExpress.XtraGrid.Views.Grid
Imports MozartLib

Public Class frmPlanifAuto_Liste

  Dim ds As DataSet

  Dim _DtListePlanifAuto As DataTable
  Dim DTPLA_AUTO_PREVIEW As DataTable
  Dim DTPLA_AUTO_PREVIEW_ACT As DataTable
  Dim DTPLA_AUTO_RESULT_PREVIEW_ACT As DataTable

  Dim _bArchives As Boolean

  Private Sub frmPlanifAuto_Liste_Load(sender As Object, e As EventArgs) Handles MyBase.Load

    Initboutons(Me)

    'init
    _bArchives = False
    BtnChangeEtat.Visible = False

    LoadData()

  End Sub

  Private Sub LoadData()

    ds = New DataSet


    'liste jour semaine
    _DtListePlanifAuto = New DataTable

    Dim sqlcmd As New SqlCommand("[api_sp_Planif_Auto_Liste]", MozartDatabase.cnxMozart)
    sqlcmd.CommandType = CommandType.StoredProcedure
    sqlcmd.Parameters.Add("@P_Archives", SqlDbType.Bit).Value = _bArchives
    _DtListePlanifAuto.Load(sqlcmd.ExecuteReader)

    ds.Tables.Add(_DtListePlanifAuto)

    'liste des preview
    DTPLA_AUTO_PREVIEW = New DataTable

    sqlcmd = New SqlCommand("[api_sp_Planif_Auto_Preview_Detail]", MozartDatabase.cnxMozart)
    sqlcmd.CommandType = CommandType.StoredProcedure
    sqlcmd.Parameters.Add("@P_Archives", SqlDbType.Bit).Value = _bArchives
    DTPLA_AUTO_PREVIEW.Load(sqlcmd.ExecuteReader())

    DTPLA_AUTO_PREVIEW.Columns("BREADYTOPLANIF").ReadOnly = False

    ds.Tables.Add(DTPLA_AUTO_PREVIEW)

    ds.Relations.Add("NPLA_AUTO_ID", ds.Tables(0).Columns("NPLA_AUTO_ID"), ds.Tables(1).Columns("NPLA_AUTO_ID"))

    'liste des preview
    DTPLA_AUTO_PREVIEW_ACT = New DataTable

    sqlcmd = New SqlCommand("[api_sp_Planif_Auto_Preview_ListeActions]", MozartDatabase.cnxMozart)
    sqlcmd.CommandType = CommandType.StoredProcedure
    sqlcmd.Parameters.Add("@P_Archives", SqlDbType.Bit).Value = _bArchives
    DTPLA_AUTO_PREVIEW_ACT.Load(sqlcmd.ExecuteReader())

    DTPLA_AUTO_PREVIEW_ACT.Columns("NCOCHE").ReadOnly = False

    ds.Tables.Add(DTPLA_AUTO_PREVIEW_ACT)



    ''liste des preview
    DTPLA_AUTO_RESULT_PREVIEW_ACT = New DataTable

    sqlcmd = New SqlCommand("[api_sp_Planif_Auto_Result_Preview_ListeActions]", MozartDatabase.cnxMozart)
    sqlcmd.CommandType = CommandType.StoredProcedure
    sqlcmd.Parameters.Add("@P_Archives", SqlDbType.Bit).Value = _bArchives
    DTPLA_AUTO_RESULT_PREVIEW_ACT.Load(sqlcmd.ExecuteReader())

    ds.Tables.Add(DTPLA_AUTO_RESULT_PREVIEW_ACT)

    'relation entre les  grid
    GCPLANIFAUTO.LevelTree.Nodes(0).RelationName = "NPLA_AUTO_ID"
    GVListePreviewByPlaAuto.ChildGridLevelName = "NPLA_AUTO_ID"

    If _bArchives = True Then
      'GVListePreviewByAction

      ds.Relations.Add("NPLA_AUTO_ID_PREVIEW_RESULT", ds.Tables(1).Columns("NPLA_AUTO_ID_PREVIEW"), ds.Tables(3).Columns("NPLA_AUTO_ID_PREVIEW"))

      GCol_2_BREADYTOPLANIF.Visible = False
      GCPLANIFAUTO.LevelTree.Nodes(0).Nodes(1).RelationName = "NPLA_AUTO_ID_PREVIEW_RESULT"
      GVListeResultPlanifByAction.ChildGridLevelName = "NPLA_AUTO_ID_PREVIEW_RESULT"

      GVListePreviewByAction.ChildGridLevelName = ""

    Else

      ds.Relations.Add("NPLA_AUTO_ID_PREVIEW", ds.Tables(1).Columns("NPLA_AUTO_ID_PREVIEW"), ds.Tables(2).Columns("NPLA_AUTO_ID_PREVIEW"))

      GCol_2_BREADYTOPLANIF.Visible = True
      GCPLANIFAUTO.LevelTree.Nodes(0).Nodes(0).RelationName = "NPLA_AUTO_ID_PREVIEW"
      GVListePreviewByAction.ChildGridLevelName = "NPLA_AUTO_ID_PREVIEW"
      GVListeResultPlanifByAction.ChildGridLevelName = ""

    End If

    GCPLANIFAUTO.DataSource = ds.Tables(0)

  End Sub

  Private Sub BtnAdd_Click(sender As Object, e As EventArgs) Handles BtnAdd.Click

    Dim oPlaAutoNew As New CPLAAUTO(0)

    Using ofrmPlanifAuto_Creation As New frmPlanifAuto_ListeActions(oPlaAutoNew, False)

      ofrmPlanifAuto_Creation.ShowDialog()
      LoadData()
    End Using

  End Sub

  Private Sub BtnMod_Click(sender As Object, e As EventArgs) Handles BtnMod.Click

    Dim bModReadOnly As Boolean = False

    If GVPLANIFAUTO.SelectedRowsCount = 0 Then
      MessageBox.Show("Il faut sélectionner une demande de planification automatique", "Erreur", MessageBoxButtons.OK, MessageBoxIcon.Exclamation)
      Return
    End If

    Dim drselect As DataRow = GVPLANIFAUTO.GetDataRow(GVPLANIFAUTO.FocusedRowHandle)

    'on teste l etat de laction en temps réel pour vérifier sir le système n'est pas en train de traiter cette demande
    If TestIfPlaAutoEnCours(drselect.Item("NPLA_AUTO_ID")) = True Then
      MessageBox.Show("Le statut de la demande a changé." & vbCrLf & "La modification n'est plus autorisée car elle est en cours de traitement, archivée ou traitée.", "Erreur", MessageBoxButtons.OK, MessageBoxIcon.Exclamation)
      Return
    End If

    'on ne peut pas supprimer une demande en cours de traitement ou
    If drselect.Item("CPLA_AUTO_ETAT") = "EC" Or drselect.Item("CPLA_AUTO_ETAT") = "P" Then
      MessageBox.Show("Attention, la modification de cette demande de planification est impossible car elle est en cours de traitement ou prête pour traitement.", "Erreur", MessageBoxButtons.OK, MessageBoxIcon.Exclamation)
      bModReadOnly = True
    End If

    If bModReadOnly = False And _bArchives = True Then bModReadOnly = True

    If drselect IsNot Nothing Then

      Dim oPlaAutoSelect As New CPLAAUTO(drselect.Item("NPLA_AUTO_ID"))

      Using ofrmPlanifAuto_Creation As New frmPlanifAuto_ListeActions(oPlaAutoSelect, bModReadOnly)

        ofrmPlanifAuto_Creation.ShowDialog()
      End Using

      LoadData()

    End If

  End Sub

  Private Sub BtnQuit_Click(sender As Object, e As EventArgs) Handles BtnQuit.Click
    Me.Close()
  End Sub

  Private Sub BtnArchives_Click(sender As Object, e As EventArgs) Handles BtnArchives.Click

    If _bArchives = False Then
      _bArchives = True
      BtnArchives.Text = "Actifs"
      BtnAdd.Visible = False
      BtnSupprLine.Visible = False

      Label1.Text = "Liste des demandes de planifications automatiques traitées"
      Me.Text = "Liste des demandes de planifications automatiques traitées"

      GColDDATE_TRAITEMENT.Visible = True
      BtnChangeEtat.Visible = False

    Else
      _bArchives = False

      BtnArchives.Text = "Archives"
      BtnAdd.Visible = True
      BtnSupprLine.Visible = True

      Label1.Text = "Liste des demandes de planifications automatiques en attente de traitement"
      Me.Text = "Liste des demandes de planifications automatiques en attente de traitement"
      GColDDATE_TRAITEMENT.Visible = False
      BtnChangeEtat.Visible = True

    End If

    LoadData()

  End Sub

  Private Sub BtnSupprLine_Click(sender As Object, e As EventArgs) Handles BtnSupprLine.Click


    If GVPLANIFAUTO.SelectedRowsCount = 0 Then
      MessageBox.Show("Il faut sélectionner une demande de planification automatique", "Erreur", MessageBoxButtons.OK, MessageBoxIcon.Exclamation)
      Return
    End If

    Dim drselect As DataRow = GVPLANIFAUTO.GetDataRow(GVPLANIFAUTO.FocusedRowHandle)

    If drselect Is Nothing Then Return

    'on ne peut pas supprimer une demande en cours de traitement ou
    If drselect.Item("CPLA_AUTO_ETAT") = "EC" Or drselect.Item("CPLA_AUTO_ETAT") = "PC" Then
      MessageBox.Show("On ne peut pas archiver une demande de planification en cours de traitement", "Erreur", MessageBoxButtons.OK, MessageBoxIcon.Exclamation)
      Return
    End If

    If MessageBox.Show("Voulez-vous archiver cette demande de planification automatique ?", "Confirmation", MessageBoxButtons.YesNoCancel, MessageBoxIcon.Question) = DialogResult.Yes Then

      Dim oPlaAutoDelete As New CPLAAUTO(drselect.Item("NPLA_AUTO_ID"))
      oPlaAutoDelete.Delete()

      LoadData()

    End If

  End Sub

  Private Function TestIfPlaAutoEnCours(ByVal P_NPLA_AUTO_ID As Int32) As Boolean

    Dim bReturn As Boolean = False

    Dim sqlcmdtest As New SqlCommand("SELECT CPLA_AUTO_ETAT FROM TPLA_AUTO WHERE NPLA_AUTO_ID = " & P_NPLA_AUTO_ID.ToString, MozartDatabase.cnxMozart)
    sqlcmdtest.CommandType = CommandType.Text
    Dim sqldr As SqlDataReader = sqlcmdtest.ExecuteReader

    Dim oLstEtatNotChange As New List(Of String)
    oLstEtatNotChange.Add(New String("EC"))
    oLstEtatNotChange.Add(New String("E"))
    oLstEtatNotChange.Add(New String("S"))
    oLstEtatNotChange.Add(New String("P"))
    oLstEtatNotChange.Add(New String("PV"))
    oLstEtatNotChange.Add(New String("PC"))

    If sqldr.HasRows Then

      sqldr.Read()

      If oLstEtatNotChange.Contains(New String(sqldr.Item("CPLA_AUTO_ETAT").ToString)) Then

        bReturn = True

      End If

    End If
    sqldr.Close()

    Return bReturn

  End Function

  Private Sub BtnChangeEtat_Click(sender As Object, e As EventArgs) Handles BtnChangeEtat.Click

    Dim drselect As DataRow = GVPLANIFAUTO.GetDataRow(GVPLANIFAUTO.FocusedRowHandle)

    If drselect Is Nothing Then Return

    If MessageBox.Show("Voulez-vous changer le statut de 'pret pour traitement' -> 'En attente'", "Confirmation", MessageBoxButtons.YesNoCancel, MessageBoxIcon.Question) = DialogResult.Yes Then

      Dim oPlaAutoUpdate As New CPLAAUTO(drselect.Item("NPLA_AUTO_ID"))

      If TestIfPlaAutoEnCours(oPlaAutoUpdate.NPLA_AUTO_ID) = True Then
        MessageBox.Show("Vous ne pouvez pas changer le statut de cette demande car elle est en cours de traitement ou elle a été traitée ou archivée.", "Erreur", MessageBoxButtons.OK, MessageBoxIcon.Exclamation)
      Else
        oPlaAutoUpdate.SaveEtatToStandBy()
        LoadData()
      End If

    End If

  End Sub

  Private Sub GVPLANIFAUTO_FocusedRowChanged(sender As Object, e As FocusedRowChangedEventArgs) Handles GVPLANIFAUTO.FocusedRowChanged

    Dim drselect As DataRow = GVPLANIFAUTO.GetDataRow(e.FocusedRowHandle)

    If drselect Is Nothing Then BtnChangeEtat.Visible = False : Return


    If _bArchives = False OrElse (drselect.Item("CPLA_AUTO_ETAT") = "RP" Or drselect.Item("CPLA_AUTO_ETAT") = "P") Then
      BtnChangeEtat.Visible = True
    Else
      BtnChangeEtat.Visible = False
    End If

  End Sub

  Private Sub RepItemChk_BREADYTOPLANIF_EditValueChanged(sender As Object, e As EventArgs) Handles RepItemChk_BREADYTOPLANIF.EditValueChanged





  End Sub

  Private Function AutoriseChangeEtatPreview(ByVal P_COCHE As Boolean, ByVal P_NPLA_AUTO_ID As Int32, ByVal P_NPLA_AUTO_ID_PREVIEW As Int32) As Boolean

    Dim bReturn As Boolean = False

    Dim sql As String = ""

    If P_COCHE = True Then
      sql = "SELECT BREADYTOPLANIF FROM TPLA_AUTO_PREVIEW WHERE BREADYTOPLANIF = 1 AND NPLA_AUTO_ID_PREVIEW <> " & P_NPLA_AUTO_ID_PREVIEW.ToString & " AND NPLA_AUTO_ID = " & P_NPLA_AUTO_ID.ToString
    Else
      sql = "SELECT CPLA_AUTO_ETAT FROM TPLA_AUTO WHERE CPLA_AUTO_ETAT = 'PC' AND NPLA_AUTO_ID = " & P_NPLA_AUTO_ID.ToString
    End If

    Dim sqlcmdtest As New SqlCommand(sql, MozartDatabase.cnxMozart)
    sqlcmdtest.CommandType = CommandType.Text
    Dim sqldr As SqlDataReader = sqlcmdtest.ExecuteReader

    If sqldr.HasRows Then bReturn = False Else bReturn = True

    sqldr.Close()

    Return bReturn

  End Function

  Private Sub RepItemChk_BREADYTOPLANIF_EditValueChanging(sender As Object, e As ChangingEventArgs) Handles RepItemChk_BREADYTOPLANIF.EditValueChanging

    Dim gv As GridView = TryCast(GCPLANIFAUTO.FocusedView, GridView)
    Dim odtr As DataRow = gv.GetDataRow(gv.FocusedRowHandle)

    If odtr Is Nothing Then Return

    'on save la valeur

    'on teste si on peut cocher la validation de la preview pour mise en planif
    'si on coche oui, on teste s'il y a d autres preview de validé (car il y a une unicité)
    If e.NewValue = 1 AndAlso AutoriseChangeEtatPreview(True, odtr.Item("NPLA_AUTO_ID"), odtr.Item("NPLA_AUTO_ID_PREVIEW")) = False Then

      e.Cancel = True
      MessageBox.Show("Vous ne pouvez pas valider cette preview car il y a déjà une preview validée pour planification", "Erreur", MessageBoxButtons.OK, MessageBoxIcon.Exclamation)
      Return

      'on teste si une planif est en cours sur cet id, si oui alors on ne peut pas decocher
    ElseIf e.NewValue = 0 AndAlso AutoriseChangeEtatPreview(False, odtr.Item("NPLA_AUTO_ID"), odtr.Item("NPLA_AUTO_ID_PREVIEW")) = False Then

      e.Cancel = True
      MessageBox.Show("Vous ne pouvez pas décocher cette preview car elle est en cours de traitement pour planification", "Erreur", MessageBoxButtons.OK, MessageBoxIcon.Exclamation)
      Return

    End If

    Dim sqlcmd As New SqlCommand("[api_sp_Planif_Auto_Preview_Save_ValidPLa]", MozartDatabase.cnxMozart)
    sqlcmd.CommandType = CommandType.StoredProcedure
    sqlcmd.Parameters.Add("@P_NPLA_AUTO_ID", SqlDbType.Int).Value = odtr.Item("NPLA_AUTO_ID")
    sqlcmd.Parameters.Add("@P_NPLA_AUTO_ID_PREVIEW", SqlDbType.Int).Value = odtr.Item("NPLA_AUTO_ID_PREVIEW")
    sqlcmd.Parameters.Add("@P_VALIDER", SqlDbType.Int).Value = e.NewValue
    sqlcmd.ExecuteNonQuery()

    GVListePreviewByAction.PostEditor()
    GCPLANIFAUTO.Refresh()

  End Sub

End Class
