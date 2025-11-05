Public Class FrmGestTechClient

    Dim oCliTech As CCLI_TECH
    Dim _VNOMFORM As String
    Dim _NID As Int32
    Dim _Type As String

    Public Sub New(ByVal c_Type As Object, ByVal c_NID As Object)

        ' Cet appel est requis par le concepteur.
        InitializeComponent()

        ' Ajoutez une initialisation quelconque après l'appel InitializeComponent().
        _NID = Convert.ToInt32(c_NID)
        _Type = c_Type

        Select Case _Type.ToString

            Case "C"
                oCliTech = New CCLI_TECH(c_Type.ToString, _NID)
                GColVPERNOM.Visible = True
                GColVPERPRE.Visible = True
                GColVSERLIB.Visible = True
                GColVCLINOM.Visible = False
            Case "T"
                oCliTech = New CCLI_TECH(c_Type.ToString, _NID)
                GColVPERNOM.Visible = False
                GColVPERPRE.Visible = False
                GColVSERLIB.Visible = False
                GColVCLINOM.Visible = True
                GColVCLINOM.Width = GCGestCliTech.Width * 0.90000000000000002
                GColBCLITECHCOCHE.Width = GCGestCliTech.Width * 0.10000000000000001
            Case Else
        End Select

        _VNOMFORM = oCliTech.sNomForm

    End Sub

    Private Sub FrmGestTechClient_Load(sender As System.Object, e As System.EventArgs) Handles MyBase.Load

        Select Case _Type

            Case "C"
                LblTitre.Text = String.Format("Gestion des contremaîtres et chef de site du client : {0}", _VNOMFORM)
            Case "T"
                LblTitre.Text = String.Format("Gestion des clients du contremaître/chef de site : {0}", _VNOMFORM)
            Case Else
        End Select

        Me.Text = LblTitre.Text

        If Not oCliTech Is Nothing Then
            GCGestCliTech.DataSource = oCliTech.DTCLI_TECH
        Else
            'read only
            BtnSave.Visible = False
        End If

    End Sub

    Private Sub FrmGestTechClient_FormClosing(sender As Object, e As System.Windows.Forms.FormClosingEventArgs) Handles Me.FormClosing

        If Not oCliTech.DTCLI_TECH Is Nothing AndAlso Not oCliTech.DTCLI_TECH.GetChanges(DataRowState.Modified) Is Nothing Then

            Select Case MessageBox.Show(My.Resources.Global_Enregistrer_Modif, "Confirmation", MessageBoxButtons.YesNoCancel, MessageBoxIcon.Exclamation)

                Case DialogResult.Yes
                    BtnSave.PerformClick()
                    e.Cancel = False
                    Me.Close()
                Case DialogResult.No
                    e.Cancel = False
                Case DialogResult.Cancel
                    e.Cancel = True
            End Select

        End If

    End Sub

    Private Sub BtnQuit_Click(sender As System.Object, e As System.EventArgs) Handles BtnQuit.Click
        Me.Close()
    End Sub

    Private Sub BtnSave_Click(sender As System.Object, e As System.EventArgs) Handles BtnSave.Click
        oCliTech.SaveTechnicien()
    End Sub

    Private Sub BtnCoche_Click(sender As System.Object, e As System.EventArgs) Handles BtnCoche.Click
        CocherAllFilterTous_Or_DecocheAllFilter(oCliTech.DTCLI_TECH, "BCLITECHCOCHE", GVGestCliTech.ActiveFilterCriteria, True)
        GCGestCliTech.Refresh()
    End Sub

    Private Sub BtnDecoche_Click(sender As System.Object, e As System.EventArgs) Handles BtnDecoche.Click
        CocherAllFilterTous_Or_DecocheAllFilter(oCliTech.DTCLI_TECH, "BCLITECHCOCHE", GVGestCliTech.ActiveFilterCriteria, True)
        GCGestCliTech.Refresh()
    End Sub

    Private Sub GVGestCliTech_CustomDrawFooter(sender As Object, e As DevExpress.XtraGrid.Views.Base.RowObjectCustomDrawEventArgs) Handles GVGestCliTech.CustomDrawFooter

        Dim oPos As Rectangle = e.Bounds
        Dim oFormat As New StringFormat
        Dim iNbSelected As Int32 = 0

        If Not oCliTech Is Nothing Then

            oPos.Location = New Point(oPos.Left + 1, oPos.Top + 1)
            oPos.Size = New Size(oPos.Width - 2, oPos.Height - 2)

            oFormat.Alignment = StringAlignment.Center

            Dim dttemp As DataTable = GCGestCliTech.DataSource

            For Each odrtemp As DataRow In dttemp.Rows

                If odrtemp.Item("BCLITECHCOCHE") = 1 Then
                    iNbSelected = iNbSelected + 1
                End If

            Next

            e.Appearance.DrawString(e.Cache, String.Format("Total sélectionné : {0} / {1}", iNbSelected, oCliTech.DTCLI_TECH.Rows.Count), oPos, oFormat)
            e.Handled = True

        End If

    End Sub

End Class