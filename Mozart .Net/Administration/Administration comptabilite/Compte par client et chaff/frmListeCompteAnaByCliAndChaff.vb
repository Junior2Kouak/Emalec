Imports System.Data.SqlClient
Imports System.Linq
Imports DevExpress.XtraPrinting
Imports MozartLib

Public Class frmListeCompteAnaByCliAndChaff

  Dim sTypeForm As String
  Dim dtListCptAnaCLi As DataTable

  Public Sub New(Optional ByVal c_mTypeForm As Object = "")

    ' Cet appel est requis par le concepteur.
    InitializeComponent()

    ' Ajoutez une initialisation quelconque après l'appel InitializeComponent().
    sTypeForm = c_mTypeForm

  End Sub

  Private Sub frmListeCompteAnaByCliAndChaff_Load(sender As System.Object, e As System.EventArgs) Handles MyBase.Load

    'INIT
    Initboutons(Me)

    LoadData()

    GestionAffichage()

  End Sub

  Private Sub LoadData()

    Me.Cursor = Cursors.WaitCursor

    dtListCptAnaCLi = New DataTable

    Dim sqlcmdList As New SqlCommand("api_sp_listeCompteAna", MozartDatabase.cnxMozart)

    sqlcmdList.CommandType = CommandType.StoredProcedure
        sqlcmdList.Parameters.Add("@p_type", SqlDbType.Char).Value = sTypeForm

        dtListCptAnaCLi.Load(sqlcmdList.ExecuteReader)

        GCListCptByCliAndChaff.DataSource = dtListCptAnaCLi

        Me.Cursor = Cursors.Default

    End Sub

    Private Sub BtnFermer_Click(sender As System.Object, e As System.EventArgs) Handles BtnFermer.Click
        Me.Close()
    End Sub

    Private Sub GestionAffichage()

        If sTypeForm = "R" Then

            GColTOT.Visible = False
            GColASS.Visible = True
            GColFACTU.Visible = True

            'bouton nouveau
            BtnModif.Visible = False
            BtnAffectChaff.Visible = False
            BtnAffectAss.Visible = False
            BtnAffectFact.Visible = False
            BtnPrint.Visible = False
            BtnAffectAssChaff.Visible = False

        Else

            GColTOT.Visible = True
            GColASS.Visible = True
            GColFACTU.Visible = True

            BtnModif.Visible = True

        End If

    End Sub

    Private Sub BtnModif_Click(sender As System.Object, e As System.EventArgs) Handles BtnModif.Click

        If GVListCptByCliAndChaff.FocusedRowHandle > -1 Then

            Dim drSelect As DataRow = GVListCptByCliAndChaff.GetDataRow(GVListCptByCliAndChaff.FocusedRowHandle)

            Dim iPos As Int32 = GVListCptByCliAndChaff.FocusedRowHandle

            Dim oFrmGestCompteClient As New frmGestCompteCli(drSelect.Item("NCLINUM"), drSelect.Item("VCLINOM"))
            oFrmGestCompteClient.ShowDialog()

            LoadData()
            GVListCptByCliAndChaff.FocusedRowHandle = iPos

        End If

    End Sub

    Private Sub BtnAffect_Click(sender As System.Object, e As System.EventArgs) Handles BtnAffectChaff.Click, BtnAffectAss.Click, BtnAffectFact.Click, BtnAffectAssChaff.Click

        Dim sType As String
        Dim sNameChamp As String
        Dim iOldPers As Integer

        If GVListCptByCliAndChaff.RowCount > 0 And GVListCptByCliAndChaff.FocusedRowHandle > -1 Then

            Dim drSelect As DataRow = GVListCptByCliAndChaff.GetDataRow(GVListCptByCliAndChaff.FocusedRowHandle)

            Select Case sender.Name.ToString
                Case "BtnAffectAss"
                    sType = "ASS"
                    sNameChamp = "NPERNUMASS"
                Case "BtnAffectAssChaff"
                    sType = "ASSCHAFF"
                    sNameChamp = "NPERNUMASSCHAFF"
                Case "BtnAffectFact"
                    sType = "FAC"
                    sNameChamp = "NPERNUMFACT"
                Case Else
                    sType = "CHAFF"
                    sNameChamp = "NPERNUM"
            End Select

            iOldPers = drSelect.Item(sNameChamp)

            Dim DvFilter() As DataRow
            Dim sqlWhere As String = DevExpress.Data.Filtering.CriteriaToWhereClauseHelper.GetDataSetWhere(GVListCptByCliAndChaff.ActiveFilterCriteria)
            sqlWhere = sqlWhere.Replace("[NCANNUM]", "Convert(NCANNUM, 'System.String')")
            sqlWhere = sqlWhere.Replace("[TOT]", "Convert(TOT, 'System.String')")

            DvFilter = dtListCptAnaCLi.Select(sqlWhere)


            If DvFilter.Length > 0 Then

                '------------------------------------------------------------------------------------------------------
                Dim iPos As Int32 = GVListCptByCliAndChaff.FocusedRowHandle

                Dim oFrmAffectChaff As New frmCptAnaAffectSelect(sType, DvFilter, iOldPers)
                oFrmAffectChaff.ShowDialog()

                If oFrmAffectChaff.Cancel = False Then LoadData() : GVListCptByCliAndChaff.FocusedRowHandle = iPos

            End If

        End If

    End Sub

    Private Sub BtnPrint_Click(sender As System.Object, e As System.EventArgs) Handles BtnPrint.Click

        If GVListCptByCliAndChaff.RowCount > 100 Then
            If MessageBox.Show(My.Resources.Admin_frmListeCompteAnaByCliAndChaff_Attention, My.Resources.Global_ConfirmationI, MessageBoxButtons.YesNoCancel, MessageBoxIcon.Exclamation) <> Windows.Forms.DialogResult.Yes Then Exit Sub
        End If

        Dim pcl As PrintableComponentLink = New PrintableComponentLink(New PrintingSystem())
        pcl.Component = GCListCptByCliAndChaff
        pcl.Landscape = True
        pcl.CreateDocument()
        pcl.PrintDlg()

    End Sub

    Private Sub GVListCptByCliAndChaff_CustomDrawFooter(sender As Object, e As DevExpress.XtraGrid.Views.Base.RowObjectCustomDrawEventArgs) Handles GVListCptByCliAndChaff.CustomDrawFooter
        Dim oPos As Rectangle = e.Bounds
        Dim oFormat As New StringFormat
        oPos.Location = New Point(oPos.Left + 1, oPos.Top + 1)
        oPos.Size = New Size(oPos.Width - 2, oPos.Height - 2)
        oFormat.Alignment = StringAlignment.Center
        e.Appearance.DrawString(e.Cache, String.Format(My.Resources.Global_Selection_0_1, GVListCptByCliAndChaff.RowCount, GCListCptByCliAndChaff.DataSource.Rows.Count), oPos, oFormat)
        e.Handled = True
    End Sub

    Private Sub BtnAffectSuperviseur_Click(sender As Object, e As EventArgs) Handles BtnAffectSuperviseur.Click

        If GVListCptByCliAndChaff.RowCount > 0 And GVListCptByCliAndChaff.FocusedRowHandle > -1 Then

            Dim drSelect As DataRow = GVListCptByCliAndChaff.GetDataRow(GVListCptByCliAndChaff.FocusedRowHandle)

            '------------------------------------------------------------------------------------------------------
            Dim iPos As Int32 = GVListCptByCliAndChaff.FocusedRowHandle

            Dim oFrmAffectChaffSuperviseur As New frmCptAnaAffectSelectSuperviseur(drSelect)
            oFrmAffectChaffSuperviseur.ShowDialog()

            If oFrmAffectChaffSuperviseur.Cancel = False Then LoadData() : GVListCptByCliAndChaff.FocusedRowHandle = iPos

        End If

    End Sub

  Private Sub BtnExportXLS_Click(sender As Object, e As EventArgs) Handles BtnExportXLS.Click
    SFD.Filter = "Fichiers XLSX |*.XLSX"
    SFD.ShowDialog()

    If SFD.FileName <> "" Then
      GCListCptByCliAndChaff.ExportToXlsx(SFD.FileName)
    End If
  End Sub
End Class