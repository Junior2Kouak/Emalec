Imports System.Data.SqlClient
Imports DevExpress.XtraEditors.Repository
Imports DevExpress.XtraGrid.Views.Grid
Imports MozartLib

Public Class frmAdminCertFluidBottle

  Dim DtListeBottle As DataTable
  Dim _bVisuActif As Boolean

  Private Sub frmAdminCertFluidBottle_Load(sender As Object, e As EventArgs) Handles MyBase.Load

    _bVisuActif = True
    LoadData(_bVisuActif)

  End Sub

  Private Sub LoadData(ByVal p_Actif As Boolean)

    DtListeBottle = New DataTable

    Dim osqlcmdRead As New SqlCommand("[api_sp_CertFluid_Bottle_Liste]", MozartDatabase.cnxMozart)
    osqlcmdRead.CommandType = CommandType.StoredProcedure
        osqlcmdRead.Parameters.Add("@p_BBOTTLE_ACTIF", SqlDbType.Bit).Value = p_Actif
        DtListeBottle.Load(osqlcmdRead.ExecuteReader)

        GCLSTCERTFLUID_BOTTLE.DataSource = DtListeBottle

    End Sub

    Private Sub BtnQuit_Click(sender As Object, e As EventArgs) Handles BtnQuit.Click

        Me.Close()

    End Sub
    Private Sub btnAdd_Click(sender As Object, e As EventArgs) Handles btnAdd.Click

        Dim oFrmCertFluidBottle As New frmCertFluidBottle("")
        oFrmCertFluidBottle.ShowDialog()

        LoadData(_bVisuActif)

    End Sub

    Private Sub BtnModif_Click(sender As Object, e As EventArgs) Handles BtnModif.Click

        If GVLSTCERTFLUID_BOTTLE.SelectedRowsCount = 0 Then MessageBox.Show("Il faut sélectionner une bouteille !", "Erreur", MessageBoxButtons.OK, MessageBoxIcon.Exclamation) : Exit Sub

        Dim oFrmCertFluidBottle As New frmCertFluidBottle(GVLSTCERTFLUID_BOTTLE.GetDataRow(GVLSTCERTFLUID_BOTTLE.FocusedRowHandle).Item("KEY_BOTTLE_UNIQUE"))
        oFrmCertFluidBottle.ShowDialog()

        LoadData(_bVisuActif)

    End Sub

    Private Sub BtnArchiver_Click(sender As Object, e As EventArgs) Handles BtnArchiver.Click
        If GVLSTCERTFLUID_BOTTLE.SelectedRowsCount = 0 Then MessageBox.Show("Il faut sélectionner une bouteille !", "Erreur", MessageBoxButtons.OK, MessageBoxIcon.Exclamation) : Exit Sub

        Dim sMessagebox As String = ""

        If _bVisuActif = True Then
            sMessagebox = "Voulez-vous vraiment archiver cette bouteille ?"
        Else
            sMessagebox = "Voulez-vous vraiment restaurer cette bouteille ?"
        End If

        If MessageBox.Show(sMessagebox, "Confirmation", MessageBoxButtons.YesNoCancel, MessageBoxIcon.Question) = vbYes Then

            Dim oCertFluidBottle As New CCertFluidBottle(GVLSTCERTFLUID_BOTTLE.GetDataRow(GVLSTCERTFLUID_BOTTLE.FocusedRowHandle).Item("KEY_BOTTLE_UNIQUE"))
            If _bVisuActif = True Then
                oCertFluidBottle.Archive()
            Else
                oCertFluidBottle.Restaure()
            End If
            LoadData(_bVisuActif)

        End If

    End Sub

    Private Sub BtnArchives_Click(sender As Object, e As EventArgs) Handles BtnArchives.Click

        _bVisuActif = Not (_bVisuActif)

        If _bVisuActif = True Then

            Label1.Text = "Administration des bouteilles de récupération / transfert actives"
            Me.Text = "Administration des bouteilles de récupération / transfert actives"
            btnAdd.Visible = True
            BtnModif.Text = "Modifier"
            BtnArchiver.Text = "Archiver"
            BtnArchives.Text = "Archives"

        Else

            Label1.Text = "Administration des bouteilles de récupération / transfert archivées"
            Me.Text = "Administration des bouteilles de récupération / transfert archivées"
            btnAdd.Visible = False
            BtnModif.Text = "Ouvrir"
            BtnArchiver.Text = "Restaurer"
            BtnArchives.Text = "Voir actives"

        End If

        LoadData(_bVisuActif)

    End Sub
    Private Sub GVLSTCERTFLUID_BOTTLE_CustomRowCellEdit(sender As Object, e As CustomRowCellEditEventArgs) Handles GVLSTCERTFLUID_BOTTLE.CustomRowCellEdit

        Dim view As GridView = TryCast(sender, GridView)
        If e.Column.FieldName = "NBOTTLEQTERESTE" Then

            If e.RowHandle < 0 Then Return

            Dim ValueReste As Int32 = CInt(e.CellValue)
            Dim ValueContenant As Int32 = CInt(view.GetRowCellValue(e.RowHandle, "NBOTTLE_CONTENANT"))
      Dim ValuePourc As Int32
      Dim TYPE_BOTTLE As Int32 = CInt(view.GetRowCellValue(e.RowHandle, "NBOTTLE_TYPE"))

      If ValueContenant = 0 Then ValuePourc = 0 Else ValuePourc = (ValueReste / ValueContenant) * 100

            Dim PBC_Color_by_value As RepositoryItemProgressBar = TryCast(e.RepositoryItem, RepositoryItemProgressBar)
            PBC_Color_by_value.Maximum = ValueContenant

      If TYPE_BOTTLE = 3 Then
        PBC_Color_by_value.DisplayFormat.FormatString = "{0:n3} Kg"
      Else
        PBC_Color_by_value.DisplayFormat.FormatString = "{0:n0} L"
      End If

      Select Case ValuePourc

                Case 0 To 25

                    PBC_Color_by_value.StartColor = Color.Red

                Case 26 To 50
                    PBC_Color_by_value.StartColor = Color.Orange
                Case Else
                    PBC_Color_by_value.StartColor = Color.Green

            End Select
            PBC_Color_by_value.EndColor = PBC_Color_by_value.StartColor

        End If

    End Sub
End Class