
Public Class frmGTPAudit
    
    Dim oGTPAUDIT As CGTPAUDIT
    Dim NSITNUM As Int32 
    Dim sTitreDetailFormAudit As String

    Public Sub New(ByVal c_NSITNUM As Int32, ByVal c_VSITNOM As string, ByVal c_VCLINOM As string)
        
        ' Cet appel est requis par le concepteur.
        InitializeComponent()
        
        ' Ajoutez une initialisation quelconque après l'appel InitializeComponent().
        NSITNUM = c_NSITNUM

        Me.Text = String.Format(Me.Text, c_VCLINOM, c_VSITNOM)
        Label1.Text = String.Format(Label1.Text, c_VCLINOM, c_VSITNOM)

        sTitreDetailFormAudit = String.Format(My.Resources.Aperçu_frmGTPAudit_GTP, c_VCLINOM, c_VSITNOM)

    End Sub

    Private Sub frmGTPAudit_Load( ByVal sender As System.Object,  ByVal e As System.EventArgs) Handles MyBase.Load

        oGTPAUDIT = New CGTPAUDIT()
        
        GCGTPAUDIT.DataSource = oGTPAUDIT.GTPAuditLastBySite(NSITNUM) 
        
    End Sub

    Private Sub GVGTPAudit_DoubleClick(ByVal sender As Object, ByVal e As System.EventArgs) Handles GVGTPAUDIT.DoubleClick 

        If GVGTPAUDIT.SelectedRowsCount > 0 Then
        
            Dim oDrSelected As DataRow = GVGTPAUDIT.GetDataRow(GVGTPAUDIT.GetSelectedRows(0))
            
            Dim oFrmGTPAuditDetail As new frmGTPAuditDetail(oDrSelected.item("NGTPAUDITLID"), sTitreDetailFormAudit)
            oFrmGTPAuditDetail.ShowDialog

        Else
            MessageBox.Show(My.Resources.Global_select_equipement, My.Resources.Global_Erreur_select_equi, MessageBoxButtons.OK, MessageBoxIcon.Exclamation)
        End If       

    End Sub

    Private Sub BtnQuit_Click( ByVal sender As System.Object,  ByVal e As System.EventArgs) Handles BtnQuit.Click

        Me.Close 

    End Sub

    Private Sub BtnDetail_Click( ByVal sender As System.Object,  ByVal e As System.EventArgs) Handles BtnDetail.Click

        If GVGTPAUDIT.SelectedRowsCount > 0 Then                       

            Dim oDrSelected As DataRow = GVGTPAUDIT.GetDataRow(GVGTPAUDIT.GetSelectedRows(0))
            
            Dim oFrmGTPAuditDetail As new frmGTPAuditDetail(oDrSelected.item("NGTPAUDITLID"), sTitreDetailFormAudit)
            oFrmGTPAuditDetail.ShowDialog

        Else
            MessageBox.Show(My.Resources.Global_select_equipement, My.Resources.Global_Erreur_select_equi, MessageBoxButtons.OK, MessageBoxIcon.Exclamation)
        End If  

    End Sub

End Class