Imports System.Data.SqlClient
Imports MozartLib

Public Class FrmGestSerieFO

  Dim DtListeSerieFO As DataTable
  Dim bActif As Boolean

  Private Sub FrmGestSerieFO_Load(sender As Object, e As EventArgs) Handles MyBase.Load

    bActif = True
    LoadData(bActif)

  End Sub

  Private Sub LoadData(Optional ByVal p_actif As Boolean = True)

    DtListeSerieFO = New DataTable
    Dim sqlcmdLoad As New SqlCommand("[api_sp_SerieFo_Liste]", MozartDatabase.cnxMozart)
    sqlcmdLoad.CommandType = CommandType.StoredProcedure
        sqlcmdLoad.Parameters.Add("@p_bcfoactif", SqlDbType.Bit).Value = p_actif
        DtListeSerieFO.Load(sqlcmdLoad.ExecuteReader)

        GCListeSerieFO.DataSource = DtListeSerieFO

    End Sub


    Private Sub ButtonLstArchives_Click(sender As Object, e As EventArgs) Handles ButtonLstArchives.Click

        If bActif = True Then

            bActif = False
            LabelTitre.Text = "Liste des séries de fournitures archivées"
            ButtonLstArchives.Text = "Liste actifs"
            ButtonArchiver.Visible = False
            ButtonRestaurer.Visible = True

        Else

            bActif = True
            LabelTitre.Text = "Liste des séries de fournitures"
            ButtonLstArchives.Text = "Liste archives"
            ButtonArchiver.Visible = True
            ButtonRestaurer.Visible = False
        End If

        LoadData(bActif)

    End Sub

    Private Sub BtnFermer_Click(sender As Object, e As EventArgs) Handles BtnFermer.Click
        Me.Close()
    End Sub

    Private Sub ButtonArchiver_Click(sender As Object, e As EventArgs) Handles ButtonArchiver.Click

        If GVListeSerieFO.RowCount = 0 Then Exit Sub

        Dim dr As DataRow = GVListeSerieFO.GetDataRow(GVListeSerieFO.FocusedRowHandle)

    Dim sqlcmdupdate As New SqlCommand("UPDATE TREF_CFO SET BCFOACTIF = 0 WHERE NCFOCOD=" & dr.Item("NCFOCOD") & " AND LANGUE='" & dr.Item("LANGUE") & "'", MozartDatabase.cnxMozart)
    sqlcmdupdate.CommandType = CommandType.Text
        sqlcmdupdate.ExecuteNonQuery()

        LoadData(bActif)

    End Sub

    Private Sub ButtonDetails_Click(sender As Object, e As EventArgs) Handles ButtonDetails.Click

        If GVListeSerieFO.RowCount = 0 Then Exit Sub

        Dim dr As DataRow = GVListeSerieFO.GetDataRow(GVListeSerieFO.FocusedRowHandle)

        Dim oFrmDetailSerieFo As New FrmDetailSerieFO(dr.Item("NCFOCOD"), dr.Item("LANGUE"), dr.Item("CCFOCOD"))
        oFrmDetailSerieFo.ShowDialog()

        LoadData(bActif)

    End Sub

    Private Sub ButtonRestaurer_Click(sender As Object, e As EventArgs) Handles ButtonRestaurer.Click

        If GVListeSerieFO.RowCount = 0 Then Exit Sub

        Dim dr As DataRow = GVListeSerieFO.GetDataRow(GVListeSerieFO.FocusedRowHandle)

    Dim sqlcmdupdate As New SqlCommand("UPDATE TREF_CFO SET BCFOACTIF = 1 WHERE NCFOCOD=" & dr.Item("NCFOCOD") & " AND LANGUE='" & dr.Item("LANGUE") & "'", MozartDatabase.cnxMozart)
    sqlcmdupdate.CommandType = CommandType.Text
        sqlcmdupdate.ExecuteNonQuery()

        LoadData(bActif)

    End Sub

    Private Sub BtnAjouter_Click(sender As Object, e As EventArgs) Handles BtnAjouter.Click

        Dim oFrmDetailSerieFo As New FrmDetailSerieFO(0, "", "")
        oFrmDetailSerieFo.ShowDialog()

        LoadData(bActif)

    End Sub

End Class