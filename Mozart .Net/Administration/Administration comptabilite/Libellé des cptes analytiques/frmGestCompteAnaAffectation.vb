Imports System.Data.SqlClient
Imports DevExpress.XtraEditors

Public Class frmGestCompteAnaAffectation

    Dim dtTets As New DataTable
    Dim oCtpAnaByPers As CCompteAna
    Dim iNCANNUM_Select As Int32

    Public Sub New(ByVal cO_CptAna As CCompteAna, ByVal c_NCANNUMSelect As Int32, ByVal c_NomCompte As String)

        ' Cet appel est requis par le concepteur.
        InitializeComponent()

        ' Ajoutez une initialisation quelconque après l'appel InitializeComponent().
        oCtpAnaByPers = cO_CptAna
        iNCANNUM_Select = c_NCANNUMSelect

        LblCANSelect.Text = String.Format("{0} - {1}", c_NCANNUMSelect, c_NomCompte)

    End Sub

    Private Sub frmGestCompteAnaAffectation_FormClosing(sender As Object, e As System.Windows.Forms.FormClosingEventArgs) Handles Me.FormClosing

        If Not oCtpAnaByPers.dtCptAnaAffect Is Nothing AndAlso Not oCtpAnaByPers.dtCptAnaAffect.GetChanges(DataRowState.Modified) Is Nothing Then

            Select Case MessageBox.Show(My.Resources.Global_Enregistrer_Modif, My.Resources.admin_frmGestCompteAnaAffectation_MozartAffectation, MessageBoxButtons.YesNoCancel, MessageBoxIcon.Exclamation)

                Case DialogResult.Yes
                    BtnSave.PerformClick()
                    e.Cancel = False
                Case DialogResult.No
                    e.Cancel = False
                Case DialogResult.Cancel
                    e.Cancel = True
            End Select

        End If

    End Sub

    Private Sub frmGestCompteAnaAffectation_Load(sender As System.Object, e As System.EventArgs) Handles MyBase.Load

        LoadData()

    End Sub

    Private Sub LoadData()

        If Not oCtpAnaByPers Is Nothing Then

            GCPers.DataSource = oCtpAnaByPers.LoadComptesAnaAffect(iNCANNUM_Select)

        End If

    End Sub

    Private Sub BtnQuit_Click(sender As System.Object, e As System.EventArgs) Handles BtnQuit.Click
        Me.Close()
    End Sub

    Private Sub GVPers_CustomDrawFooter(sender As Object, e As DevExpress.XtraGrid.Views.Base.RowObjectCustomDrawEventArgs) Handles GVPers.CustomDrawFooter

        Dim oPos As Rectangle = e.Bounds
        Dim oFormat As New StringFormat
        Dim iNbPerSelected As Int32 = 0

        oPos.Location = New Point(oPos.Left + 1, oPos.Top + 1)
        oPos.Size = New Size(oPos.Width - 2, oPos.Height - 2)

        oFormat.Alignment = StringAlignment.Center

        Dim dttemp As DataTable = GCPers.DataSource

        For Each odrtemp As DataRow In dttemp.Rows

            If odrtemp.Item("CHECK") = 1 Then
                iNbPerSelected = iNbPerSelected + 1
            End If

        Next

        e.Appearance.DrawString(e.Cache, String.Format(My.Resources.Global_NbrPersonne, iNbPerSelected, oCtpAnaByPers.dtCptAnaAffect.Rows.Count), oPos, oFormat)
        e.Handled = True

    End Sub

    Private Sub RepositoryItemCheckEditCHECK_CheckedChanged(sender As Object, e As System.EventArgs) Handles RepositoryItemCheckEditCHECK.CheckedChanged
        Dim odtr As DataRow = GVPers.GetDataRow(GVPers.GetSelectedRows(0))

        If Not odtr Is Nothing AndAlso odtr.Item("CHECK") = 1 Then
            CType(sender, DevExpress.XtraEditors.CheckEdit).Checked = False
            odtr.Item("CHECK") = 0
        Else
            CType(sender, DevExpress.XtraEditors.CheckEdit).Checked = True
            odtr.Item("CHECK") = 1
        End If

        GVPers.PostEditor()
        GCPers.Refresh()
    End Sub

    Private Sub BtnCoche_Click(sender As System.Object, e As System.EventArgs) Handles BtnCoche.Click
        CocherAllFilterTous_Or_DecocheAllFilter(oCtpAnaByPers.dtCptAnaAffect, "CHECK", GVPers.ActiveFilterCriteria, True)
        GCPers.Refresh()
    End Sub

    Private Sub BtnDecoche_Click(sender As System.Object, e As System.EventArgs) Handles BtnDecoche.Click
        CocherAllFilterTous_Or_DecocheAllFilter(oCtpAnaByPers.dtCptAnaAffect, "CHECK", GVPers.ActiveFilterCriteria, False)
        GCPers.Refresh()
    End Sub

    Private Sub BtnSave_Click(sender As System.Object, e As System.EventArgs) Handles BtnSave.Click

        Me.Cursor = Cursors.WaitCursor
        oCtpAnaByPers.SaveListPersByComtpeAna(iNCANNUM_Select)
        Me.Cursor = Cursors.Default

        'refresh
        LoadData()

    End Sub
End Class