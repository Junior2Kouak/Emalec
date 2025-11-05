Imports System.Data.SqlClient   
Imports DevExpress.XtraGrid.Views.Grid
Imports DevExpress.XtraGrid.Views.Base
Imports DevExpress.XtraGrid.Columns
Imports System.Runtime.Serialization

Public Class frmGTPSite
    
    Dim oGTPSite As CGTPSIT 

    Dim oGTPEmalec As CGTPEQUIP 

    Dim oGTPZone As CGTPZONE 

    Dim NCLINUM As int32
    Dim sVCLINOM As String 
    Dim NSITNUM As int32
    Dim sVSITNOM As String 

    Public Sub new(ByVal c_NCLINUM As int32, ByVal c_VCLINOM As String, ByVal c_NSITNUM As int32, ByVal c_VSITNOM As String)
        
        ' Cet appel est requis par le concepteur.
        InitializeComponent()
        
        ' Ajoutez une initialisation quelconque après l'appel InitializeComponent().
        NCLINUM = c_NCLINUM
        sVCLINOM = c_VCLINOM
        NSITNUM = c_NSITNUM
        sVSITNOM = c_VSITNOM
                
    End Sub

    Private Sub frmGTPSite_Load( ByVal sender As System.Object,  ByVal e As System.EventArgs) Handles MyBase.Load

        Try
                
            oGTPSite = New CGTPSIT
            oGTPEmalec = New CGTPEQUIP
            oGTPZone = New CGTPZONE
            
            Me.Text = String.Format(Me.Text, sVCLINOM, sVSITNOM)
            Label1.Text = String.Format(Label1.Text, sVCLINOM, sVSITNOM)

            RepItemGLUpEditZone.DataSource = oGTPZone.ListeGTPZone             

            'on charge les liste combo des zones par client
            GCGTPClient.DataSource = oGTPSite.ListeGTPMainByClient(NCLINUM)
            GrpClient.Text = String.Format(GrpClient.Text, sVCLINOM)  
            
            oGTPSite.p_NSITNUM = NSITNUM
            GCGTPSIT.DataSource = oGTPSite.ListeGTPSite   
            GrpSite.Text = String.Format(GrpSite.Text, sVSITNOM)  

        Catch ex As Exception

            MessageBox.Show(My.Resources.Aperçu_frmGTPSite_SubLoad + ex.Message, My.Resources.Global_Erreur)

        End Try

    End Sub

    Private Sub BtnQuit_Click( ByVal sender As System.Object,  ByVal e As System.EventArgs) Handles BtnQuit.Click

        Me.close

    End Sub

    Private Sub frmGTPSite_FormClosing(ByVal sender As Object, ByVal e As System.Windows.Forms.FormClosingEventArgs) Handles Me.FormClosing

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

            If DetectEquipWithoutData = false Then
                
                oGTPSite.SaveGTPSite
           
                GCGTPSIT.DataSource = oGTPSite.ListeGTPSite

            Else

                MessageBox.Show(My.Resources.Aperçu_frmGTPSite_enreg_impossible, My.Resources.Aperçu_frmGTPSite_erreur, MessageBoxButtons.OK, MessageBoxIcon.Error)

            End If

            

        Catch ex As Exception
            MessageBox.Show(ex.Message)
        End Try
       
    End Sub

    Private Sub BtnAddLine_Click( ByVal sender As System.Object,  ByVal e As System.EventArgs) Handles BtnAddLine.Click
       
        Try

            If GVGTPClient.SelectedRowsCount > 0  then

                Dim i As int16

                For i = 0 To GVGTPClient.SelectedRowsCount - 1

                    'on test s il ya des doublons
                    'Dim oRowsExist() As DataRow = oGTPSite.p_dtGTPSite.Select("NGTPMAINID = " + GVGTPClient.GetDataRow(GVGTPClient.GetSelectedRows(0)).Item("NGTPMAINID").ToString)

                    'If oRowsExist.Length = 0 then
                        oGTPSite.AddNewLineGTPSite(GVGTPClient.GetDataRow(GVGTPClient.GetSelectedRows(i)))
                    'else
                    '    MessageBox.Show("L'équipement sélectionné existe déjà dans la liste des équipements client !", "Erreur - Ajout équipement", MessageBoxButtons.OK, MessageBoxIcon.Warning) 
                    'End If     

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

            If GVGTPSIT.SelectedRowsCount > 0 Then
                'si handle row est inférieur à 0 alors elle ne fait pas partir de la datatable
                If GVGTPSIT.GetSelectedRows(0) < 0 Then
                    MessageBox.Show(My.Resources.Global_select_equipement, My.Resources.Global_Suppression_equipement, MessageBoxButtons.OK, MessageBoxIcon.Exclamation)
                    Return
                End If
            Else
                MessageBox.Show(My.Resources.Global_select_equipement, My.Resources.Global_Suppression_equipement, MessageBoxButtons.OK, MessageBoxIcon.Exclamation)
                Return
            End If

            'mise à jour de la datatable
            If MessageBox.Show(My.Resources.Global_supression_equipement_msg, My.Resources.Global_confirmation_suppression, MessageBoxButtons.YesNoCancel, MessageBoxIcon.Question) = vbYes Then

                oGTPSite.SuppLineGTPSite(GVGTPSIT.GetDataRow(GVGTPSIT.GetSelectedRows(0)).Item("IDTMP"))

            End If

        Catch ex As Exception
            MessageBox.Show(ex.Message)
        End Try

    End Sub

    Private function DetectedChange() As Boolean 

        Try

            If (Not oGTPSite.p_dtGTPSite.GetChanges Is Nothing AndAlso oGTPSite.p_dtGTPSite.GetChanges.Rows.Count > 0) Then

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
    
    Private Sub GVGTPSIT_FocusedRowChanged(ByVal sender As Object, ByVal e As DevExpress.XtraGrid.Views.Base.FocusedRowChangedEventArgs) Handles GVGTPSIT.FocusedRowChanged
        
        Dim oDRSelectedNew As DataRow = GVGTPSIT.GetDataRow(e.FocusedRowHandle) 
        Dim oDRSelectedOld As DataRow = GVGTPSIT.GetDataRow(e.PrevFocusedRowHandle) 

        'pour l'ancienne selected
        'si zone selectionne : alors on clear error
        'sinon error
        If Not oDRSelectedOld is Nothing then
            if oDRSelectedOld.Item("NGTPZONEID") = 0 or IsDBNull(oDRSelectedOld.Item("NGTPSITQTE")) or IsDBNull(oDRSelectedOld.Item("NGTPSITINSTANNEE")) Then
                oDRSelectedOld.RowError = My.Resources.Aperçu_frmGTPSite_zone_obligatoire
                oDRSelectedOld.SetColumnError(7, My.Resources.Global_Erreur_min)
            Else
                oDRSelectedOld.ClearErrors             
            End If
        End If
        
        If Not oDRSelectedNew is Nothing then
            if oDRSelectedNew.Item("NGTPZONEID") = 0 or IsDBNull(oDRSelectedNew.Item("NGTPSITQTE")) or IsDBNull(oDRSelectedNew.Item("NGTPSITINSTANNEE")) Then
                
                If oDRSelectedNew.Item("NGTPZONEID") = 0 Then
                    oDRSelectedNew.RowError = My.Resources.Aperçu_frmGTPSite_zone_obligatoire
                    oDRSelectedNew.SetColumnError(7, My.Resources.Global_Erreur_min)
                End If
                If IsDBNull(oDRSelectedNew.Item("NGTPSITQTE")) Then
                    oDRSelectedNew.RowError = My.Resources.Aperçu_frmGTPSite_quantité_obligatoire
                    oDRSelectedNew.SetColumnError(9, My.Resources.Global_Erreur_min)
                End If
                If IsDBNull(oDRSelectedNew.Item("NGTPSITINSTANNEE")) Then
                    oDRSelectedNew.RowError = My.Resources.Aperçu_frmGTPSite_installation_obligatoire
                    oDRSelectedNew.SetColumnError(10, My.Resources.Global_Erreur_min)
                End If
                                                        
            Else
                GVGTPSIT.GetDataRow(e.FocusedRowHandle).ClearErrors 
            end if
        End If
        
    End Sub

    '**********************************************************************************************************************************************************
    'Cette sub permet de tratier les actions selon le type d'erreur sur la valité de la row
    '**********************************************************************************************************************************************************
    Private Sub GVGTPSIT_InvalidRowException(ByVal sender As Object, ByVal e As DevExpress.XtraGrid.Views.Base.InvalidRowExceptionEventArgs) Handles GVGTPSIT.InvalidRowException
        
        'MessageBox.Show(e.ErrorText, e.WindowCaption, MessageBoxButtons.OK, MessageBoxIcon.Error)
        
        Select Case e.ErrorText
            Case My.Resources.Aperçu_frmGTPSite_zone_obligatoire
                e.ExceptionMode = DevExpress.XtraEditors.Controls.ExceptionMode.Ignore    
            Case Else
                e.ExceptionMode = DevExpress.XtraEditors.Controls.ExceptionMode.Ignore
        End Select

    End Sub

    '********************************************************************************************************************************
    'Cette sub permet de tester les lugnes saisies dans le bordereau au moment de la saisie
    '********************************************************************************************************************************
    Private Sub GVGTPSIT_ValidateRow(ByVal sender As Object, ByVal e As DevExpress.XtraGrid.Views.Base.ValidateRowEventArgs) Handles GVGTPSIT.ValidateRow

        Dim GV As GridView = CType(sender, GridView)
        Dim oDRSelected As DataRow = GV.GetDataRow(e.RowHandle)

        If GV.IsNewItemRow(e.RowHandle) Then
            
             If oDRSelected.Item("NGTPZONEID") = 0 Then

                e.ErrorText = My.Resources.Aperçu_frmGTPSite_zone_obligatoire
                ' e.Valid = False

            End If
            If IsDBNull(oDRSelected.Item("NGTPSITQTE")) Then

                e.ErrorText = My.Resources.Aperçu_frmGTPSite_quantité_obligatoire
                'e.Valid = False

            End If
            If IsDBNull(oDRSelected.Item("NGTPSITINSTANNEE")) Then

                e.ErrorText = My.Resources.Aperçu_frmGTPSite_installation_obligatoire
                'e.Valid = False

            End If
        
        Else

            If oDRSelected.Item("NGTPZONEID") = 0 Then

                e.ErrorText = My.Resources.Aperçu_frmGTPSite_zone_obligatoire
                'e.Valid = False

            End If
            If IsDBNull(oDRSelected.Item("NGTPSITQTE")) Then

                e.ErrorText = My.Resources.Aperçu_frmGTPSite_quantité_obligatoire
                'e.Valid = False

            End If
            If IsDBNull(oDRSelected.Item("NGTPSITINSTANNEE")) Then

                e.ErrorText = My.Resources.Aperçu_frmGTPSite_installation_obligatoire
                'e.Valid = False                

            End If

        End If        

    End Sub

    Private Sub GVGTPClient_DoubleClick(ByVal sender As Object, ByVal e As System.EventArgs) Handles GVGTPClient.DoubleClick

        BtnAddLine.PerformClick  

    End Sub
    
    Private Function DetectEquipWithoutData() As Boolean 

        Try
            
            Dim oDtVerif As New DataTable

            oDtVerif = oGTPSite.p_dtGTPSite.Copy 
            oDtVerif.AcceptChanges 

            For Each oDrVerif As DataRow In oDtVerif.Rows 
                If oDrVerif.Item("NGTPZONEID") = 0 or IsDBNull(oDrVerif.Item("NGTPSITQTE")) or IsDBNull(oDrVerif.Item("NGTPSITINSTANNEE")) then
                    Return true
                End If
            Next

            Return False 
            
        Catch ex As Exception

            MessageBox.Show(ex.Message)
            Return true                   

        End Try

    End Function

    Private Sub BtnSelectAll_Click( ByVal sender As System.Object,  ByVal e As System.EventArgs) Handles BtnSelectAll.Click

        GVGTPClient.SelectAll 

    End Sub

End Class
