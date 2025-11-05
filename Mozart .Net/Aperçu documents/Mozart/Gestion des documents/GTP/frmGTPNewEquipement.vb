Imports System.Data.SqlClient   

Public Class frmGTPNewEquipement

    Dim oDTTmpNew As datatable 

    Public Sub New(Optional ByVal c_oDTTmpNew As datatable = Nothing)

        ' Cet appel est requis par le concepteur.
        InitializeComponent()
        
        ' Ajoutez une initialisation quelconque après l'appel InitializeComponent().
        If Not c_oDTTmpNew Is Nothing Then

            oDTTmpNew = c_oDTTmpNew
            
        End If
                
    End Sub

    Private Sub frmGTPNewEquipement_Load( ByVal sender As System.Object,  ByVal e As System.EventArgs) Handles MyBase.Load

        Dim oGTPLot As New CGTPLOT 
        Dim oGTPUnite As New CGTPUNITE 

        CboLot.DataSource = oGTPLot.ListeGTPLot        
        CboUnite.DataSource = oGTPUnite.ListeGTPUnite

        If oGTPLot.ListeGTPLot.Rows.Count = 0 or oGTPUnite.ListeGTPUnite.Rows.Count = 0 Then BtnCreate.Enabled = False 
                   
    End Sub

    Private Function IsVerifChampOK() As Boolean 

        If txtNomEquipement.Text.Trim = "" or txtCout.Text.Trim = "" or txtDureeVie.Text.Trim = ""  Then
            
            If txtNomEquipement.Text.Trim = "" Then txtNomEquipement.BackColor = color.Yellow
            If txtDureeVie.Text.Trim = "" Then txtDureeVie.BackColor = color.Yellow  
            If txtCout.Text.Trim = "" Then txtCout.BackColor = color.Yellow 
                                               
            Return False 

        elseif Isnumeric(txtCout.Text.Trim) = False or Isnumeric(txtDureeVie.Text.Trim) = False then

            If Isnumeric(txtCout.Text.Trim) = False Then txtCout.BackColor = color.Yellow
            If Isnumeric(txtDureeVie.Text.Trim) = False Then txtDureeVie.BackColor = color.Yellow

            Return False 

        else

            Return true             

        End If

    End Function

    Private Sub BtnCancel_Click( ByVal sender As System.Object,  ByVal e As System.EventArgs) Handles BtnCancel.Click

        If MessageBox.Show(My.Resources.Aperçu_frmGTPNewEquipement_annuler_création, My.Resources.Global_confirmation_annulation, MessageBoxButtons.YesNoCancel, MessageBoxIcon.Question) = DialogResult.Yes Then

            Me.Close()

        End If

    End Sub

    Private Sub BtnCreate_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles BtnCreate.Click

        If MessageBox.Show(My.Resources.Aperçu_frmGTPNewEquipement_confirmer_création, My.Resources.Global_confirmation_creation, MessageBoxButtons.YesNoCancel, MessageBoxIcon.Question) = DialogResult.Yes Then

            If IsVerifChampOK() = True Then

                Dim oDataRowTmpNew As DataRow = oDTTmpNew.NewRow

                oDataRowTmpNew.Item("NGTPMAINID") = 0
                oDataRowTmpNew.Item("NGTPLOTID") = CboLot.SelectedValue
                oDataRowTmpNew.Item("VGTPEQUIP") = txtNomEquipement.Text
                oDataRowTmpNew.Item("VGTPPRECIS") = txtPrecision.Text
                oDataRowTmpNew.Item("NGTPDURVIE") = txtDureeVie.Text.Replace(".", ",")
                oDataRowTmpNew.Item("NGTPUNITEID") = CboUnite.SelectedValue
                oDataRowTmpNew.Item("NGTPCOUTUNIT") = txtCout.Text

                oDTTmpNew.Rows.Add(oDataRowTmpNew)

                MessageBox.Show(My.Resources.Global_equipement_créé, My.Resources.Global_creation_equipement, MessageBoxButtons.OK, MessageBoxIcon.Information)
                Me.Close()

            Else

                MessageBox.Show(My.Resources.Aperçu_frmGTPNewEquipement_champs_vide, My.Resources.Aperçu_frmGTPNewEquipement_erreur, MessageBoxButtons.OK, MessageBoxIcon.Information)

            End If

        End If



    End Sub

    Private Sub txtNomEquipement_TextChanged( ByVal sender As System.Object,  ByVal e As System.EventArgs) Handles txtNomEquipement.TextChanged, txtCout.TextChanged, txtPrecision.TextChanged 
 
        If sender.backcolor = Color.Yellow Then sender.backcolor = Color.White 
        
    End Sub

    Private Sub txtDureeVie_EditValueChanged( ByVal sender As System.Object,  ByVal e As System.EventArgs) Handles txtDureeVie.EditValueChanged
        If sender.backcolor = Color.Yellow Then sender.backcolor = Color.White 
    End Sub

    Private Sub txtCout_EditValueChanged( ByVal sender As System.Object,  ByVal e As System.EventArgs) Handles txtCout.EditValueChanged

        txtCout.Text = txtCout.Text.Replace(".", ",")  

    End Sub

End Class