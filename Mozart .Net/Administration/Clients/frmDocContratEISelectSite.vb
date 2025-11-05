Imports System.Data.SqlClient
Imports System.IO
Imports DevExpress.XtraEditors
Imports MozartLib

Public Class frmDocContratEISelectSite

  Dim _DTListeCCL As DataTable
  Dim _DTListeSite As DataTable

  Dim _oContratEI As C_CONTRATEI

  Public Sub New(ByVal c_oContratEI As Object)

    ' Cet appel est requis par le concepteur.
    InitializeComponent()

    ' Ajoutez une initialisation quelconque après l'appel InitializeComponent().
    _oContratEI = CType(c_oContratEI, C_CONTRATEI)

  End Sub

  Private Sub frmDocContratEISelectSite_Load(sender As System.Object, e As System.EventArgs) Handles MyBase.Load


    LoadListeContactClient()
    LoadListeSitesClient()
    GridLookUpContact.Properties.DataSource = _DTListeCCL

    GCListeSites.DataSource = _DTListeSite

  End Sub

  Private Sub LoadListeContactClient()

    Dim osqlcmdListeCCL As New SqlCommand("[api_sp_ListeContactClientActif]", MozartDatabase.cnxMozart)

    osqlcmdListeCCL.CommandType = CommandType.StoredProcedure
        osqlcmdListeCCL.Parameters.Add("@iClient", SqlDbType.Int).Value = _oContratEI.NCLINUM
        _DTListeCCL = New DataTable
        _DTListeCCL.Load(osqlcmdListeCCL.ExecuteReader())

    End Sub

    Private Sub LoadListeSitesClient()

    Dim osqlcmdListeSite As New SqlCommand("[api_sp_ListeSitesClientContEI]", MozartDatabase.cnxMozart)

    osqlcmdListeSite.CommandType = CommandType.StoredProcedure
        osqlcmdListeSite.Parameters.Add("@iClient", SqlDbType.Int).Value = _oContratEI.NCLINUM
        _DTListeSite = New DataTable
        _DTListeSite.Load(osqlcmdListeSite.ExecuteReader())

        _DTListeSite.Columns("CHECKSITE").ReadOnly = False

    End Sub

    Private Sub BtnClose_Click(sender As System.Object, e As System.EventArgs) Handles BtnClose.Click
        Me.Close()
    End Sub

    Private Sub GVListeSites_CustomDrawFooter(sender As Object, e As DevExpress.XtraGrid.Views.Base.RowObjectCustomDrawEventArgs) Handles GVListeSites.CustomDrawFooter

        Dim oPos As Rectangle = e.Bounds
        Dim oFormat As New StringFormat
        Dim iNbPerSelected As Int32 = 0

        oPos.Location = New Point(oPos.Left + 1, oPos.Top + 1)
        oPos.Size = New Size(oPos.Width - 2, oPos.Height - 2)

        oFormat.Alignment = StringAlignment.Center

        Dim dttemp As DataTable = GCListeSites.DataSource

        For Each odrtemp As DataRow In dttemp.Rows

            If odrtemp.Item("CHECKSITE") = 1 Then
                iNbPerSelected = iNbPerSelected + 1
            End If

        Next

        e.Appearance.DrawString(e.Cache, String.Format(My.Resources.Admin_frmDocContratElSelectSite_NbrSite, iNbPerSelected, _DTListeSite.Rows.Count), oPos, oFormat)
        e.Handled = True

    End Sub

    Private Sub RepItemCheckEditSite_CheckedChanged(sender As Object, e As System.EventArgs) Handles RepItemCheckEditSite.CheckedChanged

        GVListeSites.PostEditor()
        GCListeSites.Refresh()

    End Sub

    Private Sub BtnCoche_Click(sender As System.Object, e As System.EventArgs) Handles BtnCoche.Click
        CocherAllFilterTous_Or_DecocheAllFilter(_DTListeSite, "CHECKSITE", GVListeSites.ActiveFilterCriteria, True)
        GCListeSites.Refresh()
    End Sub

    '*****************************************************************************************************************************************************************************
    'Cette fonction permet de cocher ou decocher les rows filters dans une gridview
    '*****************************************************************************************************************************************************************************
    Private Sub CocherAllFilterTous_Or_DecocheAllFilter(ByVal oDtCoche As DataTable, ByVal sFieldNameCheck As String, ByVal sFilterCondition As DevExpress.Data.Filtering.CriteriaOperator, ByVal sValue As Boolean)

        Dim DvFilter() As DataRow
        Dim i As Int32

        DvFilter = oDtCoche.Select(DevExpress.Data.Filtering.CriteriaToWhereClauseHelper.GetDataSetWhere(sFilterCondition))

        If DvFilter.Length >= 1 Then

            For i = 0 To DvFilter.Length - 1

                DvFilter(i).Item(sFieldNameCheck) = sValue

            Next

        End If

    End Sub

    Private Sub BtnDecoche_Click(sender As System.Object, e As System.EventArgs) Handles BtnDecoche.Click

        CocherAllFilterTous_Or_DecocheAllFilter(_DTListeSite, "CHECKSITE", GVListeSites.ActiveFilterCriteria, False)
        GCListeSites.Refresh()

    End Sub

    Private Sub BtnGenerate_Click(sender As System.Object, e As System.EventArgs) Handles BtnGenerate.Click

        If GridLookUpContact.EditValue Is Nothing Then MessageBox.Show(My.Resources.Admin_frmDocContratElSelectSite_SelectionnerContact, My.Resources.Global_Erreur, MessageBoxButtons.OK, MessageBoxIcon.Exclamation) : Exit Sub

        If _DTListeSite.Select("[CHECKSITE]=1").Count = 0 Then MessageBox.Show(My.Resources.Admin_frmDocContratElSelectSite_SelectionnerSite, My.Resources.Global_Erreur, MessageBoxButtons.OK, MessageBoxIcon.Exclamation) : Exit Sub

        'selection des sites
        Dim sListeSites As String = ""

        For Each oRow As DataRow In _DTListeSite.Rows

            If oRow.Item("CHECKSITE") = 1 Then

                sListeSites = sListeSites & oRow.Item("NSITNUM") & ";"

            End If

        Next

        _oContratEI.CreateContratEI(sListeSites, GridLookUpContact.EditValue())

        Me.Close()

    End Sub
End Class