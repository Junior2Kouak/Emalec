Imports System.Data.SqlClient
Imports DevExpress.XtraGrid.Views.Grid.ViewInfo
Imports DevExpress.XtraGrid.Columns
Imports MozartLib

Public Class frmNbTransDevisParChaff

  Private highlightedColumn As GridColumn
  Private highlightedRowHandle As Integer = -1
  Private prevHighlightedRowHandle As Integer = -1

  Private Sub frmNbTransDevisParChaff_Load(ByVal sender As Object, ByVal e As EventArgs) Handles MyBase.Load

    'Formate les dates de début et de fin de la plage annuelle pour laquelle on veut sélectionner les devis.
    'Cette plage annuelle correspond à une plage calculée avant les trois derniers mois courants.
    'ex : si  nous sommes le 18 Avril 2018, cette plage courra du 1er Février 2017 au 31 Janvier 2018.

    LblDteDebut.Text = CDate(String.Format("01/{0}/{1}", Format(DateTime.Now.Month(), "00"), DateTime.Now.Year)).AddMonths(-14)
    LblDateFin.Text = CDate(String.Format("01/{0}/{1}", Format(DateTime.Now.Month(), "00"), DateTime.Now.Year)).AddMonths(-2).AddDays(-1)

    LblChaff.Text = MozartParams.strUID

    LblExplic.Text = "Périmètre de l'indicateur :" & vbCrLf & "Les taux de transformation sont les rapports entre les devis clients éxécutés et le nombre total de devis client créés ( on ne prend en compte que les clients ayant 10 devis créés et exécutéées sur la période)" _
& "en Gestion MPT sur 12 mois glissants (les 3 derniers mois en cours ne sont pas pris en compte)." _
& "Les devis exécutés correspondent aux valeurs 'O' : A planifier; 'P' : Planifié; 'W' : Planifié, attente d'éléments; 'E' : Exécuté"

    'Charge la liste des données dans le tableau.
    ChargeListe()

  End Sub

  ' Fonction permettant de rédiger la requête d'accès utilisée pour remplir la liste en fonction de l'utilisateur connecté.
  ' C'est la procédure stockée api_sp_StatNbDevisTransformésParChaff qui est utilisée pour remplir la table TSTATDEVISTAUXTRANS tous les 1er du mois.
  Public Shared Function FormatRequete(ByVal id As Integer) As String
    Dim requete As String = ""

    ' TB SAMSIC CITY SPEC
    If MozartParams.NomGroupe = "EMALEC" Then
      Select Case id
        Case "1", "612"  'Dans le cas de Jean JULLIEN
          requete = "SELECT * from STATISTIQUE.dbo.TSTATDEVISTAUXTRANS order by chaff"
        Case "253" 'Dans le cas de Pierre CHEVALIER
          requete = "SELECT * from STATISTIQUE.dbo.TSTATDEVISTAUXTRANS order by chaff"
        Case Else 'Dans le cas d'un chargé d'affaire quelconque
          requete = "SELECT * from STATISTIQUE.dbo.TSTATDEVISTAUXTRANS where npernumchaff = " & id
      End Select
    Else
      requete = "SELECT * from STATISTIQUE.dbo.TSTATDEVISTAUXTRANS where npernumchaff = " & id
    End If

    Return requete

  End Function

  Private Sub ChargeListe()
    Try

      'Affiche la colonne des chargés d'affaire et une introduction différente dans le cas ou la personne connectée est Jean JULLIEN ou Pierre CHEVALIER. 
      ' TB SAMSIC CITY SPEC
      If (MozartParams.UID = 1 Or MozartParams.UID = 253) And MozartParams.NomGroupe = "EMALEC" Then

        GVStat.Columns("chaff").Visible = True
        LblTxTrans.Text = My.Resources.Reporting_RealisationMPT_frmNbTransDevisParChaff_titre
        LblDteDebut.Visible = False
        LblDateFin.Visible = False
        LblEtLe.Visible = False
        LblPourChaff.Text = My.Resources.Reporting_RealisationMPT_frmNbTransDevisParChaff_perimetre & " Groupe" & MozartParams.NomGroupe
        LblChaff.Visible = False

      End If
      Cursor = Cursors.WaitCursor

      Dim CmdSql As New SqlCommand(FormatRequete(MozartParams.UID), MozartDatabase.cnxMozart) With {.CommandType = CommandType.Text}

      Dim sqlAdpat As SqlDataAdapter = New SqlDataAdapter(CmdSql)
      Dim dtStat As New DataSet
      sqlAdpat.Fill(dtStat)

      GCStat.DataSource = dtStat.Tables(0)

      CmdSql.Dispose()

    Catch ex As Exception
      MessageBox.Show("Sub frmNbTransDevisParChaff.ChargeListe() frmNbTransDevisParChaff :" + ex.Message, My.Resources.Global_Erreur)
    Finally
      Cursor = Cursors.Default
    End Try

  End Sub

  Private Sub BtnFermer_Click(ByVal sender As Object, ByVal e As EventArgs) Handles BtnFermer.Click

    Close()

  End Sub

  'Customise l'affichage du footer et de ses données.
  Private Sub GVStat_CustomDrawFooterCell(ByVal sender As Object, ByVal e As DevExpress.XtraGrid.Views.Grid.FooterCellCustomDrawEventArgs) Handles GVStat.CustomDrawFooterCell
    e.Handled = True
    e.Appearance.BackColor = Color.Gray
    e.Appearance.ForeColor = Color.White
    e.Appearance.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center
    e.Appearance.DrawBackground(e.Cache, e.Bounds)
    e.Appearance.DrawString(e.Cache, e.Info.DisplayText, e.Bounds)
  End Sub

  'Autorise le clic sur la cellule sélectionnée pour en afficher les données.
  Private Sub GVStat_RowCellClick(ByVal sender As Object, ByVal e As DevExpress.XtraGrid.Views.Grid.RowCellClickEventArgs) Handles GVStat.RowCellClick

    If e.Column.Name = "DevisCrees" And GVStat.GetRowCellValue(e.RowHandle, DevisCrees) <> 0 Then
      Dim oFrmDetailStat As New frmDetailsDevisParChaff(GVStat.GetRowCellValue(e.RowHandle, NPERNUMCHAFF), GVStat.GetRowCellValue(e.RowHandle, NCLINUM), LblDteDebut.Text, LblDateFin.Text, 0)
      oFrmDetailStat.ShowDialog()
      oFrmDetailStat.Dispose()
    End If

    If e.Column.Name = "NombreDevisExecutes" And GVStat.GetRowCellValue(e.RowHandle, NombreDevisExecutes) <> 0 Then

      Dim oFrmDetailStat As New frmDetailsDevisParChaff(GVStat.GetRowCellValue(e.RowHandle, NPERNUMCHAFF), GVStat.GetRowCellValue(e.RowHandle, NCLINUM), LblDteDebut.Text, LblDateFin.Text, 1)
      oFrmDetailStat.ShowDialog()
      oFrmDetailStat.Dispose()
    End If

  End Sub

  ' Gère la forme du curseur et la couleur des cellules au passage de la souris sur les cellules cliquables.
  Private Sub GVStat_MouseMove(ByVal sender As Object, ByVal e As MouseEventArgs) Handles GVStat.MouseMove

    Dim hInfo As GridHitInfo = GVStat.CalcHitInfo(e.Location)

    If hInfo.InRowCell = True And (hInfo.Column Is GVStat.Columns.ColumnByName("DevisCrees") Or hInfo.Column Is GVStat.Columns.ColumnByName("NombreDevisExecutes")) Then
      GCStat.Cursor = Cursors.Hand
      prevHighlightedRowHandle = highlightedRowHandle
      highlightedColumn = hInfo.Column
      highlightedRowHandle = hInfo.RowHandle
      GVStat.RefreshRow(highlightedRowHandle)
      GVStat.RefreshRow(prevHighlightedRowHandle)

    Else
      GCStat.Cursor = Cursors.Default
      highlightedColumn = Nothing
      GVStat.RefreshRow(highlightedRowHandle)
      GVStat.RefreshRow(prevHighlightedRowHandle)
    End If

  End Sub

  Private Sub GVStat_RowCellStyle(sender As Object, e As DevExpress.XtraGrid.Views.Grid.RowCellStyleEventArgs) Handles GVStat.RowCellStyle

    If ((e.Column Is highlightedColumn) AndAlso (e.RowHandle = highlightedRowHandle)) Then
      e.Appearance.BackColor = Color.LightBlue

    End If
  End Sub
End Class