Imports DevExpress.XtraGrid.Views.Grid
Imports DevExpress.XtraGrid.Views.Base
Imports DevExpress.XtraGrid.Columns

Public Class frmGTPClient

    Dim oGestGTPClient As CGTPClient
    
    Dim oGestGTPMain As CGTPEQUIP 

    Dim NCLINUM As int32
    Dim sVCLINOM As String 

    Public Sub New(ByVal c_NCLINUM As int32, ByVal c_VCLINOM As String )

        ' Cet appel est requis par le concepteur.
        InitializeComponent()
        
        ' Ajoutez une initialisation quelconque après l'appel InitializeComponent().
        NCLINUM = c_NCLINUM
        sVCLINOM = c_VCLINOM

    End Sub

    Private Sub frmGTPLot_Load( ByVal sender As System.Object,  ByVal e As System.EventArgs) Handles MyBase.Load
                
        oGestGTPMain = New CGTPEQUIP
        oGestGTPClient = New CGTPCLIENT 

        GrpboxClient.Text = String.Format(GrpboxClient.Text,sVCLINOM)
        ME.Text = String.Format(ME.Text,sVCLINOM)
        Label1.Text = String.Format(Label1.Text,sVCLINOM)

        'charge lac ombo client 
        GCGTPLstEMALEC.DataSource = oGestGTPMain.ListeGTPEquipDetails          
        oGestGTPClient.p_NCLINUM = NCLINUM
        GCGTPClient.DataSource = oGestGTPClient.ListeGTPClient()

    End Sub

    Private Sub BtnQuit_Click( ByVal sender As System.Object,  ByVal e As System.EventArgs) Handles BtnQuit.Click

        Me.Close 

    End Sub
    
    Private Sub frmGTPLot_FormClosing(ByVal sender As Object, ByVal e As System.Windows.Forms.FormClosingEventArgs) Handles Me.FormClosing

        Try

            If DetectedChange = True  Then
                 e.Cancel = True
            Else
                e.Cancel = False                
            End If

        Catch ex As Exception

            MessageBox.Show(ex.Message)

        End Try

    End Sub 

    Private Sub BtnSave_Click( ByVal sender As System.Object,  ByVal e As System.EventArgs) Handles BtnSave.Click

        Try
            
            oGestGTPClient.SaveGTPClient
           
            GCGTPClient.DataSource = oGestGTPClient.ListeGTPClient 

        Catch ex As Exception
            MessageBox.Show(ex.Message)
        End Try

    End Sub

    Private Sub BtnAddLine_Click( ByVal sender As System.Object,  ByVal e As System.EventArgs) Handles BtnAddLine.Click

        Try
            
            If GVGTPLstEMALEC.SelectedRowsCount > 0  then
                
                Dim i As Int16 

                For i = 0 To GVGTPLstEMALEC.SelectedRowsCount - 1

                    'on test s il ya des doublons
                    Dim oRowsExist() As DataRow = oGestGTPClient.p_dtGTPClient.Select("NGTPMAINID = " + GVGTPLstEMALEC.GetDataRow(GVGTPLstEMALEC.GetSelectedRows(i)).Item("NGTPMAINID").ToString)

                    If oRowsExist.Length = 0 then
                        
                        oGestGTPClient.AddNewLineGTPClient(GVGTPLstEMALEC.GetDataRow(GVGTPLstEMALEC.GetSelectedRows(i)))
                                               
                    Else
                        MessageBox.Show(String.Format(My.Resources.Aperçu_frmGTPClient_equipement_existe, GVGTPLstEMALEC.GetDataRow(GVGTPLstEMALEC.GetSelectedRows(i)).Item("VGTPEQUIP").ToString), "Erreur - Ajout équipement", MessageBoxButtons.OK, MessageBoxIcon.Warning)
                    End If       
                    
                Next

            Else
                MessageBox.Show(My.Resources.Global_select_equipement, My.Resources.Global_Erreur_select_equi, MessageBoxButtons.OK, MessageBoxIcon.Warning)
            End If            

        Catch ex As Exception
            MessageBox.Show(ex.Message)
        End Try
    End Sub

    Private Sub BtnSupprLine_Click( ByVal sender As System.Object,  ByVal e As System.EventArgs) Handles BtnSupprLine.Click

        Try

            If GVGTPClient.SelectedRowsCount > 0 Then
                'si handle row est inférieur à 0 alors elle ne fait pas partir de la datatable
                If GVGTPClient.GetSelectedRows(0) < 0 Then
                    MessageBox.Show(My.Resources.Global_select_equipement, My.Resources.Global_Suppression_equipement, MessageBoxButtons.OK, MessageBoxIcon.Exclamation)
                    Return
                End If
            Else
                MessageBox.Show(My.Resources.Global_select_equipement, My.Resources.Global_Suppression_equipement, MessageBoxButtons.OK, MessageBoxIcon.Exclamation)
                Return
            End If

            'mise à jour de la datatable
            If MessageBox.Show(My.Resources.Global_supression_equipement_msg, My.Resources.Global_confirmation_suppression, MessageBoxButtons.YesNoCancel, MessageBoxIcon.Question) = vbYes Then

                If oGestGTPClient.ReturnSuppressionOK(GVGTPClient.GetDataRow(GVGTPClient.GetSelectedRows(0)).Item("NGTPMAINID")) = 0 Then
                    oGestGTPClient.SuppLineGTPClient(GVGTPClient.GetDataRow(GVGTPClient.GetSelectedRows(0)).Item("IDTMP"))
                Else
                    MessageBox.Show(My.Resources.Aperçu_frmGTPClient_sup_impossible, My.Resources.Global_confirmation_suppression, MessageBoxButtons.OK, MessageBoxIcon.Warning)
                End If

            End If

        Catch ex As Exception
            MessageBox.Show(ex.Message)
        End Try

    End Sub
   
    Private function DetectedChange() As Boolean 

        Try

            If (Not oGestGTPClient.p_dtGTPClient.GetChanges Is Nothing AndAlso oGestGTPClient.p_dtGTPClient.GetChanges.Rows.Count > 0) Then

                Select Case MessageBox.Show(My.Resources.Global_Enregistrer_Modif, My.Resources.Global_modif_confirmation, MessageBoxButtons.YesNoCancel, MessageBoxIcon.Exclamation)

                    Case vbYes
                        BtnSave.PerformClick()
                        Return False
                    Case vbCancel
                        Return True
                    Case Else
                        Return False
                End Select

            Else
                Return False 
            End If

        Catch ex As Exception

            MessageBox.Show(ex.Message)
            Return False 

        End Try

    End function

    Private Sub GCGTPLstEMALEC_DoubleClick(ByVal sender As Object, ByVal e As System.EventArgs) Handles GCGTPLstEMALEC.DoubleClick

        BtnAddLine.PerformClick  

    End Sub

    Private Sub BtnSelectAll_Click( ByVal sender As System.Object,  ByVal e As System.EventArgs) Handles BtnSelectAll.Click

        GVGTPLstEMALEC.SelectAll 

    End Sub

End Class