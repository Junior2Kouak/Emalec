Imports System.Data.SqlClient
Imports DevExpress.Data.Filtering
Imports DevExpress.XtraGrid.Views.Base
Imports MozartLib

Public Class frmGestDroitAnalytiqueByPer

  Dim DtComptes As DataTable
  Dim DtPers As DataTable

  Dim bComptesActif As Boolean

  Dim iMode As Int32 '0:Mode Partial compte 1: mode par personne

  Dim iTopGridMaster As Int32
  Dim iLeftGridMaster As Int32
  Dim oSizeGridMaster As Size

  Dim iTopGridChild As Int32
  Dim iLeftGridChild As Int32
  Dim oSizeGridChild As Size

  Dim _SocieteSelect As String

  Public Sub New(ByVal c_vsociete As Object)

    ' Cet appel est requis par le concepteur.
    InitializeComponent()

    ' Ajoutez une initialisation quelconque après l'appel InitializeComponent().
    _SocieteSelect = c_vsociete.ToString

  End Sub

  Private Sub frmGestDroitAnalytiqueByPer_Load(sender As Object, e As EventArgs) Handles MyBase.Load

    'INIT
    iMode = 0
    iTopGridMaster = GCComptes.Top
    iLeftGridMaster = GCComptes.Left
    oSizeGridMaster = New Size(GCComptes.Size)

    iTopGridChild = GCPers.Top
    iLeftGridChild = GCPers.Left
    oSizeGridChild = New Size(GCPers.Size)

    bComptesActif = True
    GestionAffichageByMode(iMode)

  End Sub

  Private Sub LoadDataCompte()

    DtComptes = New DataTable

    Dim sqlcmd As New SqlCommand("select NCANNUM, VCANLIB, CTYPECTE from TREF_CTEANA WHERE CCTEANAACTIF = '" & If(bComptesActif = True, "O", "N") & "' AND VSOCIETE = '" & _SocieteSelect & "' ORDER BY NCANNUM", MozartDatabase.cnxMozart)
    sqlcmd.CommandType = CommandType.Text
    DtComptes.Load(sqlcmd.ExecuteReader)

    GCComptes.DataSource = DtComptes

  End Sub

  Private Sub LoadDataPers()

    DtPers = New DataTable

    Dim sqlcmd As New SqlCommand("[api_sp_ListePerWithTypeExceptTech]", MozartDatabase.cnxMozart)
    sqlcmd.CommandType = CommandType.StoredProcedure
    sqlcmd.Parameters.Add("@vsociete", SqlDbType.VarChar).Value = _SocieteSelect
    DtPers.Load(sqlcmd.ExecuteReader)

    GCPers.DataSource = DtPers

  End Sub


  Private Sub LoadDataPersByCompte(ByVal p_NCANNUM As Int32)

    DtPers = New DataTable

    Dim sqlcmd As New SqlCommand("api_sp_ListeCptAnaCpt", MozartDatabase.cnxMozart)
    sqlcmd.CommandType = CommandType.StoredProcedure
    sqlcmd.Parameters.Add("@Cpt", SqlDbType.Int).Value = p_NCANNUM
    sqlcmd.Parameters.Add("@vsociete", SqlDbType.VarChar).Value = _SocieteSelect
    DtPers.Load(sqlcmd.ExecuteReader)

    DtPers.Columns("NCOCHE").ReadOnly = False

    GCPers.DataSource = DtPers

  End Sub

  Private Sub LoadDataCompteByPers(ByVal p_NPERNUM As Int32)

    DtComptes = New DataTable

    Dim sqlcmd As New SqlCommand("api_sp_ListeCptAnaPer", MozartDatabase.cnxMozart)
    sqlcmd.CommandType = CommandType.StoredProcedure
    sqlcmd.Parameters.Add("@Per", SqlDbType.Int).Value = p_NPERNUM
    sqlcmd.Parameters.Add("@vsociete", SqlDbType.VarChar).Value = _SocieteSelect
    sqlcmd.Parameters.Add("@cteactif", SqlDbType.VarChar).Value = If(bComptesActif = True, "O", "N")
    DtComptes.Load(sqlcmd.ExecuteReader)

    DtComptes.Columns("NCOCHE").ReadOnly = False

    GCComptes.DataSource = DtComptes

  End Sub

  Private Sub BtnQuit_Click(sender As Object, e As EventArgs) Handles BtnQuit.Click
    Me.Close()
  End Sub

  Private Sub ChkCptArch_CheckedChanged(sender As Object, e As EventArgs) Handles ChkCptArch.CheckedChanged

    If ChkCptArch.CheckState = CheckState.Checked Then
      bComptesActif = False
    Else
      bComptesActif = True
    End If

    Select Case iMode
      Case 0
        LoadDataCompte()
        If (GVComptes.FocusedRowHandle = 0) Then
          Dim drCompte As DataRow = GVComptes.GetDataRow(GVComptes.FocusedRowHandle)
          LoadDataPersByCompte(drCompte.Item("NCANNUM"))
        Else
          GVComptes.FocusedRowHandle = 0
        End If
      Case 1
        Dim drPer As DataRow = GVPers.GetDataRow(GVPers.FocusedRowHandle)
        LoadDataCompteByPers(drPer.Item("NPERNUM"))
        'If (GVComptes.FocusedRowHandle = 0) Then
        'Dim drCompte As DataRow = GVComptes.GetDataRow(GVComptes.FocusedRowHandle)
        'LoadDataPersByCompte(drCompte.Item("NCANNUM"))
        'Else
        'GVComptes.FocusedRowHandle = 0
        'End If
    End Select

  End Sub

    Private Sub GVComptes_FocusedRowChanged(sender As Object, e As FocusedRowChangedEventArgs) Handles GVComptes.FocusedRowChanged
        If e.FocusedRowHandle > -1 Then

            If iMode = 0 Then
                Dim drCompte As DataRow = GVComptes.GetDataRow(e.FocusedRowHandle)
                LoadDataPersByCompte(drCompte.Item("NCANNUM"))
            End If
        Else
            If iMode = 0 Then GCPers.DataSource = Nothing
        End If
    End Sub

    Private Sub GVPers_FocusedRowChanged(sender As Object, e As FocusedRowChangedEventArgs) Handles GVPers.FocusedRowChanged

        If e.FocusedRowHandle > -1 Then

            If iMode = 1 Then
                Dim drPer As DataRow = GVPers.GetDataRow(e.FocusedRowHandle)
                LoadDataCompteByPers(drPer.Item("NPERNUM"))
            End If
        Else
            If iMode = 1 Then GCComptes.DataSource = Nothing
        End If

    End Sub

    Private Sub RepItemChkNCOCHE_CheckStateChanged(sender As Object, e As EventArgs) Handles RepItemChkNCOCHE.CheckStateChanged

        If GVComptes.FocusedRowHandle < 0 Then Exit Sub
        If GVPers.FocusedRowHandle < 0 Then Exit Sub

        Dim drCompte As DataRow = GVComptes.GetDataRow(GVComptes.FocusedRowHandle)
        Dim drPers As DataRow = GVPers.GetDataRow(GVPers.FocusedRowHandle)
        Dim oRepItem As DevExpress.XtraEditors.CheckEdit = TryCast(sender, DevExpress.XtraEditors.CheckEdit)

        If oRepItem.CheckState = CheckState.Checked Then
            AddCompteOnPersonne(drCompte.Item("NCANNUM").ToString, drPers.Item("NPERNUM").ToString)
        Else
            DeleteCompteOnPersonne(drCompte.Item("NCANNUM").ToString, drPers.Item("NPERNUM").ToString)
        End If

    End Sub

    Private Sub RepItemChkCPT_NCOCHE_CheckStateChanged(sender As Object, e As EventArgs) Handles RepItemChkCPT_NCOCHE.CheckStateChanged

        If GVComptes.FocusedRowHandle < 0 Then Exit Sub
        If GVPers.FocusedRowHandle < 0 Then Exit Sub

        Dim drCompte As DataRow = GVComptes.GetDataRow(GVComptes.FocusedRowHandle)
        Dim drPers As DataRow = GVPers.GetDataRow(GVPers.FocusedRowHandle)
        Dim oRepItem As DevExpress.XtraEditors.CheckEdit = TryCast(sender, DevExpress.XtraEditors.CheckEdit)

        If oRepItem.CheckState = CheckState.Checked Then
            AddCompteOnPersonne(drCompte.Item("NCANNUM").ToString, drPers.Item("NPERNUM").ToString)
        Else
            DeleteCompteOnPersonne(drCompte.Item("NCANNUM").ToString, drPers.Item("NPERNUM").ToString)
        End If

    End Sub

    Private Sub AddCompteOnPersonne(ByVal p_NCANNUM As Int32, ByVal p_NPERNUM As Int32)

    Dim sqlcmdupdate As New SqlCommand("INSERT INTO TAUT (NCANNUM, NPERNUM) VALUES (" & p_NCANNUM.ToString & ", " & p_NPERNUM.ToString & ")", MozartDatabase.cnxMozart)
    sqlcmdupdate.CommandType = CommandType.Text
        sqlcmdupdate.ExecuteNonQuery()

    End Sub

    Private Sub DeleteCompteOnPersonne(ByVal p_NCANNUM As Int32, ByVal p_NPERNUM As Int32)

    Dim sqlcmdupdate As New SqlCommand("DELETE FROM TAUT WHERE NCANNUM = " & p_NCANNUM.ToString & " AND NPERNUM = " & p_NPERNUM.ToString, MozartDatabase.cnxMozart)
    sqlcmdupdate.CommandType = CommandType.Text
        sqlcmdupdate.ExecuteNonQuery()

    End Sub

    Private Sub BtnCheckedAll_Click(sender As Object, e As EventArgs) Handles BtnCheckedAll.Click

        Select Case iMode
            Case 0

                If GVComptes.FocusedRowHandle < 0 Then Exit Sub
                If DtPers Is Nothing Then Exit Sub

                Dim drCompte As DataRow = GVComptes.GetDataRow(GVComptes.FocusedRowHandle)

                If MessageBox.Show("Voulez-vous vraiment cocher tous les personnes pour le compte analytique [" & drCompte.Item("NCANNUM").ToString & " - " & drCompte.Item("VCANLIB") & "] ?", "Confirmation", MessageBoxButtons.YesNoCancel, MessageBoxIcon.Question) = DialogResult.Yes Then

                    Dim DvFilter() As DataRow = DtPers.Select(CriteriaToWhereClauseHelper.GetDataSetWhere(GVPers.ActiveFilterCriteria))

                    For Each drPer As DataRow In DvFilter

                        If drPer.Item("NCOCHE") = 0 Then
                            AddCompteOnPersonne(drCompte.Item("NCANNUM"), drPer.Item("NPERNUM"))
                            drPer.Item("NCOCHE") = 1
                        End If

                    Next
                    DtPers.AcceptChanges()

                End If

            Case 1

                If GVPers.FocusedRowHandle < 0 Then Exit Sub
                If DtComptes Is Nothing Then Exit Sub

                Dim drPer As DataRow = GVPers.GetDataRow(GVPers.FocusedRowHandle)

                If MessageBox.Show("Voulez-vous vraiment cocher tous les comptes analytiques de " & drPer.Item("VPERNOM").ToString & " ?", "Confirmation", MessageBoxButtons.YesNoCancel, MessageBoxIcon.Question) = DialogResult.Yes Then

                    Dim DvFilter() As DataRow = DtComptes.Select(CriteriaToWhereClauseHelper.GetDataSetWhere(GVComptes.ActiveFilterCriteria))

                    For Each drCpt As DataRow In DvFilter

                        If drCpt.Item("NCOCHE") = 0 Then
                            AddCompteOnPersonne(drCpt.Item("NCANNUM"), drPer.Item("NPERNUM"))
                            drCpt.Item("NCOCHE") = 1
                        End If

                    Next
                    DtComptes.AcceptChanges()

                End If

        End Select

    End Sub

    Private Sub BtnUnCheckedAll_Click(sender As Object, e As EventArgs) Handles BtnUnCheckedAll.Click

        Select Case iMode
            Case 0

                If GVComptes.FocusedRowHandle < 0 Then Exit Sub
                If DtPers Is Nothing Then Exit Sub

                Dim drCompte As DataRow = GVComptes.GetDataRow(GVComptes.FocusedRowHandle)

                If MessageBox.Show("Voulez-vous vraiment décocher tous les personnes pour le compte analytique [" & drCompte.Item("NCANNUM").ToString & " - " & drCompte.Item("VCANLIB") & "] ?", "Confirmation", MessageBoxButtons.YesNoCancel, MessageBoxIcon.Question) = DialogResult.Yes Then

                    Dim DvFilter() As DataRow = DtPers.Select(CriteriaToWhereClauseHelper.GetDataSetWhere(GVPers.ActiveFilterCriteria))

                    For Each drPer As DataRow In DvFilter

                        If drPer.Item("NCOCHE") = 1 Then
                            DeleteCompteOnPersonne(drCompte.Item("NCANNUM"), drPer.Item("NPERNUM"))
                            drPer.Item("NCOCHE") = 0
                        End If

                    Next
                    DtPers.AcceptChanges()
                End If

            Case 1

                If GVPers.FocusedRowHandle < 0 Then Exit Sub
                If DtComptes Is Nothing Then Exit Sub

                Dim drPer As DataRow = GVPers.GetDataRow(GVPers.FocusedRowHandle)

                If MessageBox.Show("Voulez-vous vraiment décocher tous les comptes analytiques de " & drPer.Item("VPERNOM").ToString & " ?", "Confirmation", MessageBoxButtons.YesNoCancel, MessageBoxIcon.Question) = DialogResult.Yes Then

                    Dim DvFilter() As DataRow = DtComptes.Select(CriteriaToWhereClauseHelper.GetDataSetWhere(GVComptes.ActiveFilterCriteria))

                    For Each drCpt As DataRow In DtComptes.Rows

                        If drCpt.Item("NCOCHE") = 1 Then
                            DeleteCompteOnPersonne(drCpt.Item("NCANNUM"), drPer.Item("NPERNUM"))
                            drCpt.Item("NCOCHE") = 0
                        End If

                    Next
                    DtComptes.AcceptChanges()

                End If

        End Select

    End Sub

    Private Sub BtnAffichage_Click(sender As Object, e As EventArgs) Handles BtnAffichage.Click

        If iMode = 0 Then
            iMode = 1
        Else
            iMode = 0
        End If
        GestionAffichageByMode(iMode)

    End Sub

    Private Sub GestionAffichageByMode(ByVal p_iMode As Int32)

        'init
        GCPers.DataSource = Nothing
        GCComptes.DataSource = Nothing

        GVPers.ClearColumnsFilter()
        GVComptes.ClearColumnsFilter()

        '0:Mode Partial compte 1: mode par personne
        Select Case p_iMode
            Case 0

                BtnAffichage.Text = "Droit par personne"

                GCCpt_NCOCHE.Visible = False
                GCPer_NCOCHE.Visible = True

                GCComptes.Top = iTopGridMaster
                GCComptes.Left = iLeftGridMaster
                GCComptes.Size = New Size(oSizeGridMaster)

                GCPers.Top = iTopGridChild
                GCPers.Left = iLeftGridChild
                GCPers.Size = New Size(oSizeGridChild)

                LoadDataCompte()

            Case 1

                BtnAffichage.Text = "Droit par compte"

                GCCpt_NCOCHE.Visible = True
                GCPer_NCOCHE.Visible = False

                GCPers.Top = iTopGridMaster
                GCPers.Left = iLeftGridMaster
                GCPers.Size = New Size(oSizeGridMaster)

                GCComptes.Top = iTopGridChild
                GCComptes.Left = iLeftGridChild
                GCComptes.Size = New Size(oSizeGridChild)

                LoadDataPers()

        End Select

        ChkCptArch.Left = GCComptes.Left + (GCComptes.Size.Width / 2) - (ChkCptArch.Width / 2)
        ChkCptArch.Top = GCComptes.Top - (ChkCptArch.Size.Height)

    End Sub

    Private Sub BtnCopyDroit_Click(sender As Object, e As EventArgs) Handles BtnCopyDroit.Click

        Dim oFrmCopyDroitAna As New frmGestDroitAnaCopy(0, _SocieteSelect)
        oFrmCopyDroitAna.ShowDialog()

        'refresh
        GestionAffichageByMode(iMode)

    End Sub

End Class