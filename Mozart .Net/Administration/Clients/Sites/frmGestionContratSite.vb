
Imports System.Data.SqlClient
Imports MozartLib

Public Class frmGestionContratSite
  Dim inumclient As Integer

  Dim bActif As Boolean
  Dim NUM_CONTRAT As Int32
  Dim NUM_SITE As Int32

  Private dragVisibleIndex As Integer = -1
  Private dragAbsIndex As Integer = -1

  'constructeur de la classe avec 1 paramtres
  Public Sub New(ByVal p_Client As Object)
    InitializeComponent()
    inumclient = Convert.ToInt32(p_Client)
  End Sub

  Private Sub frmListeFormation_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load

    Try

      'load combo des contrats du client
      Dim dtLstContrat = New DataTable
      dtLstContrat = ModDataGridView.LoadList(String.Format("[api_sp_ListeComboContratSite] {0}", inumclient), MozartDatabase.cnxMozart)

      GlookUpContrat.Properties.DataSource = dtLstContrat



    Catch ex As Exception

      MessageBox.Show(My.Resources.GestionDesFormation_frmGestHabilitation_subLoad + ex.Message, My.Resources.Global_Erreur)

    End Try

  End Sub

  '*******************************************************************************
  'Charge dans une table la liste des sites d'un contrat
  '*******************************************************************************
  Public Function ListeSites(ByVal numContrat As Integer) As DataTable

    Try

      Dim dtForm = New DataTable

      Dim sqlcmd As New SqlCommand("api_sp_ListeSitebycontrat", MozartDatabase.cnxMozart)
      sqlcmd.CommandType = CommandType.StoredProcedure
      sqlcmd.Parameters.Add("@p_NCLINUM", SqlDbType.Int)
      sqlcmd.Parameters("@p_NCLINUM").Value = inumclient
      sqlcmd.Parameters.Add("@p_NTYPECONTRAT", SqlDbType.Int)
      sqlcmd.Parameters("@p_NTYPECONTRAT").Value = numContrat

      dtForm.Load(sqlcmd.ExecuteReader)

      Return dtForm

    Catch ex As Exception

      MessageBox.Show("ListeSites dans frmGestionContratSites : " + ex.Message)
      Return Nothing

    End Try

  End Function


  '*****************************************************************************************************************************************************************************
  'Cette fonction permet de cocher ou decocher les rows filters dans une gridview
  '*****************************************************************************************************************************************************************************
  Public Sub CocherAllFilterTous_Or_DecocheAllFilter(ByVal oDtCoche As DataTable, ByVal sFieldNameCheck As String, ByVal sFilterCondition As DevExpress.Data.Filtering.CriteriaOperator, ByVal sValue As Boolean)

    Dim DvFilter() As DataRow
    Dim i As Int32

    DvFilter = oDtCoche.Select(DevExpress.Data.Filtering.CriteriaToWhereClauseHelper.GetDataSetWhere(sFilterCondition))

    If DvFilter.Length >= 1 Then

      For i = 0 To DvFilter.Length - 1

        DvFilter(i).Item(sFieldNameCheck) = sValue

      Next


    End If

  End Sub

  Private Sub BtnMod_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles BtnMod.Click
    Try

      Dim oFrmGestForm As New frmGestFormation(GVFORMATION.GetDataRow(GVFORMATION.GetSelectedRows(0)).Item("NFORMNUM"))
      oFrmGestForm.ShowDialog()

      ' rafraichir la liste
      ' GCFORMATION.DataSource = ListeSites(Convert.ToInt32(GlookUpContrat.EditValue))

    Catch ex As Exception
      MessageBox.Show(ex.Message)
    End Try
  End Sub


  Private Sub BtnExcel_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles BtnExcel.Click

    Dim SDF = New System.Windows.Forms.SaveFileDialog()
    SDF.AddExtension = True
    SDF.Filter = "Fichier EXCEL (*.XSL)|.XLS"
    SDF.ShowDialog()

    If SDF.FileName <> "" Then

      GCFORMATION.ExportToXls(SDF.FileName)

    End If

  End Sub

  Private Sub cmdValiderListe_Click(sender As Object, e As EventArgs) Handles cmdValiderListe.Click
    Dim row As DataRow
    Dim sqlupdate As New SqlCommand()
    sqlupdate.CommandType = CommandType.Text
    sqlupdate.Connection = MozartDatabase.cnxMozart

    ' enregistrement dans la table TCONT pour toutes les lignes filtrées
    For k = 0 To GVFORMATION.DataRowCount - 1
      row = GVFORMATION.GetDataRow(k)
      sqlupdate.CommandText = String.Format("update TCONT set VCONTETAT='{0}' WHERE NSITNUM ={1} And NTYPECONTRAT = {2}", CboValeur.Text, row(1), NUM_CONTRAT)
      sqlupdate.ExecuteNonQuery()
    Next

    sqlupdate.Dispose()
    Panel1.Visible = False

    ' recupération des filtres
    Dim f As DevExpress.Data.Filtering.CriteriaOperator = GVFORMATION.ActiveFilterCriteria
    GCFORMATION.DataSource = ListeSites(Convert.ToInt32(GlookUpContrat.EditValue))
    GVFORMATION.ActiveFilterCriteria = f

  End Sub

  Private Sub btn_Click(sender As Object, e As EventArgs) Handles cmdValiderLigne.Click
    ' enregistrement dans la table TCONT pour la ligne sélectionnée
    Dim sqlupdate As New SqlCommand(String.Format("update TCONT set VCONTETAT='{0}' WHERE NSITNUM={1} And NTYPECONTRAT={2}", CboValeur.Text, NUM_SITE, NUM_CONTRAT), MozartDatabase.cnxMozart)
    sqlupdate.CommandType = CommandType.Text
    sqlupdate.ExecuteNonQuery()
    sqlupdate.Dispose()
    Panel1.Visible = False

    ' recupération des filtres
    Dim f As DevExpress.Data.Filtering.CriteriaOperator = GVFORMATION.ActiveFilterCriteria
    GCFORMATION.DataSource = ListeSites(Convert.ToInt32(GlookUpContrat.EditValue))
    GVFORMATION.ActiveFilterCriteria = f

  End Sub

  Private Sub GVFORMATION_RowCellClick(sender As Object, e As DevExpress.XtraGrid.Views.Grid.RowCellClickEventArgs) Handles GVFORMATION.RowCellClick

    ' On teste la ligne
    Dim ligne_selectionnee As Integer() = GVFORMATION.GetSelectedRows()
    Dim colonne As DevExpress.XtraGrid.Columns.GridColumn = GVFORMATION.FocusedColumn()

    If Not ligne_selectionnee Is Nothing And colonne.Caption = "Gestion" Then
      NUM_CONTRAT = GVFORMATION.GetRowCellValue(ligne_selectionnee.ElementAt(0), "NTYPECONTRAT").ToString
      NUM_SITE = GVFORMATION.GetRowCellValue(ligne_selectionnee.ElementAt(0), "NSITNUM").ToString

      lblColonne.Text = colonne.Caption

      Panel1.Visible = True

    Else
      Exit Sub
    End If

    ' rafraichir la liste si modifications
    'GCStat.
  End Sub

  Private Sub cmdHabilitation_Click(ByVal sender As System.Object, ByVal e As System.EventArgs)

    Try
      If GVFORMATION.GetSelectedRows(0) < 0 Then
        Dim oFrmHabilitation As New frmGestHabilitation(0)
        oFrmHabilitation.ShowDialog()
      Else
        Dim oFrmHabilitation As New frmGestHabilitation(GVFORMATION.GetDataRow(GVFORMATION.GetSelectedRows(0)).Item("NTYPECONTRAT").ToString)
        oFrmHabilitation.ShowDialog()
      End If

    Catch ex As Exception
      MessageBox.Show(ex.Message)
    End Try
  End Sub

  Private Sub GlookUpContrat_EditValueChanged(sender As Object, e As EventArgs) Handles GlookUpContrat.EditValueChanged
    If GlookUpContrat.EditValue.ToString = "" Then
      Exit Sub
    Else
      GCFORMATION.DataSource = ListeSites(Convert.ToInt32(GlookUpContrat.EditValue))
    End If
  End Sub

  Private Sub BtnGestForm_Click(sender As Object, e As EventArgs) Handles BtnGestForm.Click
    Panel1.Visible = False
  End Sub

  Private Sub BtnQuit_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles BtnQuit.Click

    Me.Close()

  End Sub
End Class