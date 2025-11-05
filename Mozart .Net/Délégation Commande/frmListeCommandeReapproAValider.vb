Imports System.Data.SqlClient
Imports MozartLib

Public Class frmListeCommandeReapproAValider

  Dim _DtListeReapproAValider As DataTable
  Dim bAfficheActif As Boolean = True

  Private Sub frmListeCommandeReapproAValider_Load(sender As Object, e As EventArgs) Handles MyBase.Load

    'init

    LoadData()

  End Sub

  Private Sub LoadData()

    _DtListeReapproAValider = New DataTable

    Dim sqlcmd As New SqlCommand("[api_sp_CommandeReapproTechListeAttenteValidation]", MozartDatabase.cnxMozart)
    sqlcmd.CommandType = CommandType.StoredProcedure
        _DtListeReapproAValider.Load(sqlcmd.ExecuteReader())

        GCREAPPRO.DataSource = _DtListeReapproAValider

    End Sub

    Private Sub LoadDataAchives()

        _DtListeReapproAValider = New DataTable

    Dim sqlcmd As New SqlCommand("[api_sp_CommandeReapproTechListeValidees]", MozartDatabase.cnxMozart)
    sqlcmd.CommandType = CommandType.StoredProcedure
        _DtListeReapproAValider.Load(sqlcmd.ExecuteReader())

        GCREAPPRO.DataSource = _DtListeReapproAValider

    End Sub

    Private Sub BtnQuit_Click(sender As Object, e As EventArgs) Handles BtnQuit.Click
        Me.Close()
    End Sub

    Private Sub BtnSupprLine_Click(sender As Object, e As EventArgs) Handles BtnSupprLine.Click

        If GVREAPPRO.FocusedRowHandle < -1 Then Exit Sub

        If MessageBox.Show("Voulez-vous archiver cette commande de réappro technicien ?", "Confirmation", MessageBoxButtons.YesNoCancel, MessageBoxIcon.Question) = DialogResult.Yes Then

            Dim drSelected As DataRow = GVREAPPRO.GetDataRow(GVREAPPRO.FocusedRowHandle)

            ArchiverDemandeReappro(drSelected.Item("NCMDWEBNUM"))
            LoadData()

        End If

    End Sub

    Private Sub BtnMod_Click(sender As Object, e As EventArgs) Handles BtnMod.Click

        If GVREAPPRO.FocusedRowHandle < -1 Then Exit Sub

        Dim drSelected As DataRow = GVREAPPRO.GetDataRow(GVREAPPRO.FocusedRowHandle)

        Dim oFrmReapproTechDetail As New frmCommandeReapproDetail(drSelected.Item("NCMDWEBNUM"))
        oFrmReapproTechDetail.ShowDialog()

        LoadData()

    End Sub

    Private Sub ArchiverDemandeReappro(ByVal P_NCMDWEBTECHNUM As Int32)

    Dim sqlcmd As New SqlCommand("[api_sp_CommandeReapproTechArchiver]", MozartDatabase.cnxMozart)
    sqlcmd.CommandType = CommandType.StoredProcedure
        sqlcmd.Parameters.Add("@P_NCMDWEBNUM", SqlDbType.Int).Value = P_NCMDWEBTECHNUM
        sqlcmd.ExecuteNonQuery()

    End Sub

    Private Sub BtnArchives_Click(sender As Object, e As EventArgs) Handles BtnArchives.Click

        If bAfficheActif = True Then

            BtnArchives.Text = "Voir actifs"
            BtnSupprLine.Visible = False
            bAfficheActif = False
            LoadDataAchives()
        Else

            BtnArchives.Text = "Archives"
            BtnSupprLine.Visible = True
            bAfficheActif = True
            LoadData()

        End If



    End Sub
End Class