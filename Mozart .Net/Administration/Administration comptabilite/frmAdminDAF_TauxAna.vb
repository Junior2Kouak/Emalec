Imports System.Data.SqlClient
Imports DevExpress.XtraPivotGrid
Imports MozartLib

Public Class frmAdminDAF_TauxAna


  Dim dtData As DataTable

  Private Sub frmAdminDAF_TauxAna_Load(sender As Object, e As EventArgs) Handles MyBase.Load

    CboAnnee.ValueMember = "ID"
    CboAnnee.DisplayMember = "VALUE"
    CboAnnee.DataSource = ModDataGridView.LoadList("SELECT NTAUX_ANA_ANNEE AS ID, NTAUX_ANA_ANNEE AS VALUE FROM TTAUX_ANA WHERE VSOCIETE = '" + MozartParams.NomSociete + "' GROUP BY NTAUX_ANA_ANNEE ORDER BY NTAUX_ANA_ANNEE DESC", MozartDatabase.cnxMozart)

  End Sub

  Private Sub BtnValid_Click(sender As Object, e As EventArgs) Handles BtnValid.Click

    If CboAnnee.SelectedValue Is Nothing Then Return

    LoadData()

  End Sub

  Private Sub LoadData()

    dtData = New DataTable
    dtData = ModDataGridView.LoadList("[api_sp_ListeTaux_Ana] " + CboAnnee.SelectedValue.ToString, MozartDatabase.cnxMozart)

    PGC_Taux_ANA.DataSource = dtData

  End Sub

  Private Sub PGC_Taux_ANA_EditValueChanged(sender As Object, e As EditValueChangedEventArgs) Handles PGC_Taux_ANA.EditValueChanged

    ChangeCellValue(e, Convert.ToDecimal(e.Value), Convert.ToDecimal(e.Editor.EditValue))

  End Sub

  Private Sub ChangeCellValue(ByVal e As EditValueChangedEventArgs, ByVal oldValue As Decimal, ByVal newValue As Decimal)
    Dim ds As PivotDrillDownDataSource = e.CreateDrillDownDataSource()
    For i As Integer = 0 To ds.RowCount - 1
      ds.SetValue(i, e.DataField, newValue)
    Next i
  End Sub

  Private Sub BtnExp_Click(sender As Object, e As EventArgs) Handles BtnExp.Click

    Dim dtDataChanges As DataTable = dtData.GetChanges(DataRowState.Modified)

    If dtDataChanges Is Nothing Then
      MessageBox.Show("Aucune valeur n'a été modifiée.", "Enregistrer",
                         MessageBoxButtons.OK, MessageBoxIcon.Information)

      Exit Sub
    End If

    If MessageBox.Show("L’enregistrement supprimera définitivement les précédentes valeurs, souhaitez-vous continuer ?", "Enregistrer",
                         MessageBoxButtons.YesNoCancel, MessageBoxIcon.Question) <> DialogResult.Yes Then
      Exit Sub
    End If

    Dim sqlsave As SqlCommand

    For Each drSave As DataRow In dtDataChanges.Rows


      If drSave.Item("CHAMP_TCHANTIERTAUX").ToString <> "" Then

        sqlsave = New SqlCommand("[api_sp_Chantier_Taux_Hor]", MozartDatabase.cnxMozart) With {
          .CommandType = CommandType.StoredProcedure
        }
        sqlsave.Parameters.Add("@P_NIDCHANTIERTAUX", SqlDbType.Int).Value = drSave.Item("NTAUX_ANA_ID")
        sqlsave.Parameters.Add("@P_CHAMP", SqlDbType.VarChar).Value = drSave.Item("CHAMP_TCHANTIERTAUX")
        sqlsave.Parameters.Add("@P_NVAL", SqlDbType.Decimal).Value = drSave.Item("NTAUX_ANA_VAL")
        sqlsave.Parameters.Add("@P_VSOCIETE", SqlDbType.VarChar).Value = drSave.Item("VSOCIETE")
        sqlsave.ExecuteNonQuery()

      Else

        sqlsave = New SqlCommand("[api_sp_Taux_Ana_Save]", MozartDatabase.cnxMozart) With {
          .CommandType = CommandType.StoredProcedure
        }
        sqlsave.Parameters.Add("@P_NTAUX_ANA_ID", SqlDbType.Decimal).Value = drSave.Item("NTAUX_ANA_ID")
        sqlsave.Parameters.Add("@P_NTAUX_ANA_VAL", SqlDbType.Decimal).Value = drSave.Item("NTAUX_ANA_VAL")
        sqlsave.ExecuteNonQuery()

      End If

    Next
  End Sub

  Private Sub BtnExportXLS_Click(sender As Object, e As EventArgs) Handles BtnExportXLS.Click

    SFD.Filter = "Fichiers XLSX |*.XLSX"
    SFD.ShowDialog()

    If SFD.FileName <> "" Then
      PGC_Taux_ANA.ExportToXlsx(SFD.FileName)
    End If

  End Sub

  Private Sub BtmExportPDF_Click(sender As Object, e As EventArgs) Handles BtmExportPDF.Click
    SFD.Filter = "Fichiers PDF |*.PDF"
    SFD.ShowDialog()

    If SFD.FileName <> "" Then
      PGC_Taux_ANA.ExportToPdf(SFD.FileName)
    End If

  End Sub
End Class
