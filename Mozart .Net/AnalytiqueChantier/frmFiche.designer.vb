<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmFiche
    Inherits System.Windows.Forms.Form

    'Form remplace la méthode Dispose pour nettoyer la liste des composants.
    <System.Diagnostics.DebuggerNonUserCode()> _
    Protected Overrides Sub Dispose(ByVal disposing As Boolean)
        Try
            If disposing AndAlso components IsNot Nothing Then
                components.Dispose()
            End If
        Finally
            MyBase.Dispose(disposing)
        End Try
    End Sub

    'Requise par le Concepteur Windows Form
    Private components As System.ComponentModel.IContainer

    'REMARQUE : la procédure suivante est requise par le Concepteur Windows Form
    'Elle peut être modifiée à l'aide du Concepteur Windows Form.  
    'Ne la modifiez pas à l'aide de l'éditeur de code.
    <System.Diagnostics.DebuggerStepThrough()> _
    Private Sub InitializeComponent()
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(frmFiche))
        Dim DataGridViewCellStyle1 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim DataGridViewCellStyle2 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim DataGridViewCellStyle3 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim DataGridViewCellStyle4 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim DataGridViewCellStyle5 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Me.grpBox = New System.Windows.Forms.GroupBox()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.txtPourc = New System.Windows.Forms.TextBox()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.TxtDiffHeures = New System.Windows.Forms.TextBox()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.txtTotObj = New System.Windows.Forms.TextBox()
        Me.BtnUnchkAll = New System.Windows.Forms.Button()
        Me.BtnChkAll = New System.Windows.Forms.Button()
        Me.cmdDescendre = New System.Windows.Forms.Button()
        Me.cmdMonter = New System.Windows.Forms.Button()
        Me.lblchif = New System.Windows.Forms.Label()
        Me.lblVal = New System.Windows.Forms.Label()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.txtTotalSaisie = New System.Windows.Forms.TextBox()
        Me.Label6 = New System.Windows.Forms.Label()
        Me.txtTotalChif = New System.Windows.Forms.TextBox()
        Me.grdFiche = New System.Windows.Forms.DataGridView()
        Me.Edition = New System.Windows.Forms.DataGridViewCheckBoxColumn()
        Me.NIDFICHE = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.NCLASS = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.VLIB = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.NVAL = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.ColNVALOBJ = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.Début = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.Fin = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.btnAjouter = New System.Windows.Forms.Button()
        Me.btnSupprimer = New System.Windows.Forms.Button()
        Me.btnValider = New System.Windows.Forms.Button()
        Me.cmdVisu = New System.Windows.Forms.Button()
        Me.grpBox.SuspendLayout()
        CType(Me.grdFiche, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'grpBox
        '
        Me.grpBox.Controls.Add(Me.Label4)
        Me.grpBox.Controls.Add(Me.txtPourc)
        Me.grpBox.Controls.Add(Me.Label5)
        Me.grpBox.Controls.Add(Me.TxtDiffHeures)
        Me.grpBox.Controls.Add(Me.Label3)
        Me.grpBox.Controls.Add(Me.txtTotObj)
        Me.grpBox.Controls.Add(Me.BtnUnchkAll)
        Me.grpBox.Controls.Add(Me.BtnChkAll)
        Me.grpBox.Controls.Add(Me.cmdDescendre)
        Me.grpBox.Controls.Add(Me.cmdMonter)
        Me.grpBox.Controls.Add(Me.lblchif)
        Me.grpBox.Controls.Add(Me.lblVal)
        Me.grpBox.Controls.Add(Me.Label1)
        Me.grpBox.Controls.Add(Me.txtTotalSaisie)
        Me.grpBox.Controls.Add(Me.Label6)
        Me.grpBox.Controls.Add(Me.txtTotalChif)
        Me.grpBox.Controls.Add(Me.grdFiche)
        Me.grpBox.Controls.Add(Me.btnAjouter)
        Me.grpBox.Controls.Add(Me.btnSupprimer)
        resources.ApplyResources(Me.grpBox, "grpBox")
        Me.grpBox.Name = "grpBox"
        Me.grpBox.TabStop = False
        '
        'Label4
        '
        resources.ApplyResources(Me.Label4, "Label4")
        Me.Label4.Name = "Label4"
        '
        'txtPourc
        '
        resources.ApplyResources(Me.txtPourc, "txtPourc")
        Me.txtPourc.Name = "txtPourc"
        '
        'Label5
        '
        resources.ApplyResources(Me.Label5, "Label5")
        Me.Label5.Name = "Label5"
        '
        'TxtDiffHeures
        '
        resources.ApplyResources(Me.TxtDiffHeures, "TxtDiffHeures")
        Me.TxtDiffHeures.Name = "TxtDiffHeures"
        '
        'Label3
        '
        resources.ApplyResources(Me.Label3, "Label3")
        Me.Label3.Name = "Label3"
        '
        'txtTotObj
        '
        resources.ApplyResources(Me.txtTotObj, "txtTotObj")
        Me.txtTotObj.Name = "txtTotObj"
        '
        'BtnUnchkAll
        '
        resources.ApplyResources(Me.BtnUnchkAll, "BtnUnchkAll")
        Me.BtnUnchkAll.Name = "BtnUnchkAll"
        Me.BtnUnchkAll.UseVisualStyleBackColor = True
        '
        'BtnChkAll
        '
        resources.ApplyResources(Me.BtnChkAll, "BtnChkAll")
        Me.BtnChkAll.Name = "BtnChkAll"
        Me.BtnChkAll.UseVisualStyleBackColor = True
        '
        'cmdDescendre
        '
        resources.ApplyResources(Me.cmdDescendre, "cmdDescendre")
        Me.cmdDescendre.Name = "cmdDescendre"
        Me.cmdDescendre.UseVisualStyleBackColor = True
        '
        'cmdMonter
        '
        resources.ApplyResources(Me.cmdMonter, "cmdMonter")
        Me.cmdMonter.Name = "cmdMonter"
        Me.cmdMonter.UseVisualStyleBackColor = True
        '
        'lblchif
        '
        resources.ApplyResources(Me.lblchif, "lblchif")
        Me.lblchif.Name = "lblchif"
        '
        'lblVal
        '
        resources.ApplyResources(Me.lblVal, "lblVal")
        Me.lblVal.Name = "lblVal"
        '
        'Label1
        '
        resources.ApplyResources(Me.Label1, "Label1")
        Me.Label1.Name = "Label1"
        '
        'txtTotalSaisie
        '
        Me.txtTotalSaisie.BackColor = System.Drawing.Color.Yellow
        resources.ApplyResources(Me.txtTotalSaisie, "txtTotalSaisie")
        Me.txtTotalSaisie.Name = "txtTotalSaisie"
        '
        'Label6
        '
        resources.ApplyResources(Me.Label6, "Label6")
        Me.Label6.Name = "Label6"
        '
        'txtTotalChif
        '
        resources.ApplyResources(Me.txtTotalChif, "txtTotalChif")
        Me.txtTotalChif.Name = "txtTotalChif"
        '
        'grdFiche
        '
        Me.grdFiche.AllowUserToAddRows = False
        Me.grdFiche.AllowUserToDeleteRows = False
        DataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter
        DataGridViewCellStyle1.BackColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(128, Byte), Integer), CType(CType(0, Byte), Integer))
        DataGridViewCellStyle1.Font = New System.Drawing.Font("Segoe UI", 9.75!)
        DataGridViewCellStyle1.ForeColor = System.Drawing.SystemColors.WindowText
        DataGridViewCellStyle1.SelectionBackColor = System.Drawing.SystemColors.Highlight
        DataGridViewCellStyle1.SelectionForeColor = System.Drawing.SystemColors.HighlightText
        DataGridViewCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.[True]
        Me.grdFiche.ColumnHeadersDefaultCellStyle = DataGridViewCellStyle1
        Me.grdFiche.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.grdFiche.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {Me.Edition, Me.NIDFICHE, Me.NCLASS, Me.VLIB, Me.NVAL, Me.ColNVALOBJ, Me.Début, Me.Fin})
        resources.ApplyResources(Me.grdFiche, "grdFiche")
        Me.grdFiche.MultiSelect = False
        Me.grdFiche.Name = "grdFiche"
        '
        'Edition
        '
        resources.ApplyResources(Me.Edition, "Edition")
        Me.Edition.Name = "Edition"
        '
        'NIDFICHE
        '
        Me.NIDFICHE.DataPropertyName = "NIDFICHE"
        resources.ApplyResources(Me.NIDFICHE, "NIDFICHE")
        Me.NIDFICHE.Name = "NIDFICHE"
        Me.NIDFICHE.Resizable = System.Windows.Forms.DataGridViewTriState.[False]
        '
        'NCLASS
        '
        Me.NCLASS.DataPropertyName = "NCLASS"
        resources.ApplyResources(Me.NCLASS, "NCLASS")
        Me.NCLASS.Name = "NCLASS"
        '
        'VLIB
        '
        Me.VLIB.DataPropertyName = "VLIB"
        resources.ApplyResources(Me.VLIB, "VLIB")
        Me.VLIB.Name = "VLIB"
        '
        'NVAL
        '
        Me.NVAL.DataPropertyName = "NVAL"
        DataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleRight
        DataGridViewCellStyle2.Format = "### ### ###"
        DataGridViewCellStyle2.NullValue = "0"
        Me.NVAL.DefaultCellStyle = DataGridViewCellStyle2
        resources.ApplyResources(Me.NVAL, "NVAL")
        Me.NVAL.Name = "NVAL"
        '
        'ColNVALOBJ
        '
        Me.ColNVALOBJ.DataPropertyName = "NVALOBJ"
        DataGridViewCellStyle3.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleRight
        Me.ColNVALOBJ.DefaultCellStyle = DataGridViewCellStyle3
        resources.ApplyResources(Me.ColNVALOBJ, "ColNVALOBJ")
        Me.ColNVALOBJ.Name = "ColNVALOBJ"
        '
        'Début
        '
        Me.Début.DataPropertyName = "DDEB"
        DataGridViewCellStyle4.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter
        Me.Début.DefaultCellStyle = DataGridViewCellStyle4
        resources.ApplyResources(Me.Début, "Début")
        Me.Début.MaxInputLength = 10
        Me.Début.Name = "Début"
        '
        'Fin
        '
        Me.Fin.DataPropertyName = "DFIN"
        DataGridViewCellStyle5.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter
        Me.Fin.DefaultCellStyle = DataGridViewCellStyle5
        resources.ApplyResources(Me.Fin, "Fin")
        Me.Fin.MaxInputLength = 10
        Me.Fin.Name = "Fin"
        '
        'btnAjouter
        '
        resources.ApplyResources(Me.btnAjouter, "btnAjouter")
        Me.btnAjouter.Name = "btnAjouter"
        Me.btnAjouter.UseVisualStyleBackColor = True
        '
        'btnSupprimer
        '
        resources.ApplyResources(Me.btnSupprimer, "btnSupprimer")
        Me.btnSupprimer.Name = "btnSupprimer"
        Me.btnSupprimer.UseVisualStyleBackColor = True
        '
        'btnValider
        '
        resources.ApplyResources(Me.btnValider, "btnValider")
        Me.btnValider.Name = "btnValider"
        Me.btnValider.UseVisualStyleBackColor = True
        '
        'cmdVisu
        '
        resources.ApplyResources(Me.cmdVisu, "cmdVisu")
        Me.cmdVisu.Name = "cmdVisu"
        Me.cmdVisu.Tag = "0"
        Me.cmdVisu.UseVisualStyleBackColor = True
        '
        'frmFiche
        '
        resources.ApplyResources(Me, "$this")
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.Controls.Add(Me.cmdVisu)
        Me.Controls.Add(Me.btnValider)
        Me.Controls.Add(Me.grpBox)
        Me.Name = "frmFiche"
        Me.ShowInTaskbar = False
        Me.grpBox.ResumeLayout(False)
        Me.grpBox.PerformLayout()
        CType(Me.grdFiche, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents grpBox As System.Windows.Forms.GroupBox
    Public WithEvents grdFiche As System.Windows.Forms.DataGridView
    Friend WithEvents btnAjouter As System.Windows.Forms.Button
    Friend WithEvents btnSupprimer As System.Windows.Forms.Button
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents txtTotalSaisie As System.Windows.Forms.TextBox
    Friend WithEvents Label6 As System.Windows.Forms.Label
    Friend WithEvents txtTotalChif As System.Windows.Forms.TextBox
    Friend WithEvents btnValider As System.Windows.Forms.Button
    Friend WithEvents lblchif As System.Windows.Forms.Label
    Friend WithEvents lblVal As System.Windows.Forms.Label
    Friend WithEvents cmdVisu As System.Windows.Forms.Button
    Friend WithEvents cmdMonter As System.Windows.Forms.Button
    Friend WithEvents cmdDescendre As System.Windows.Forms.Button
    Friend WithEvents BtnUnchkAll As System.Windows.Forms.Button
    Friend WithEvents BtnChkAll As System.Windows.Forms.Button
    Friend WithEvents Label5 As Label
    Friend WithEvents TxtDiffHeures As TextBox
    Friend WithEvents Label3 As Label
    Friend WithEvents txtTotObj As TextBox
    Friend WithEvents Label4 As Label
    Friend WithEvents txtPourc As TextBox
    Friend WithEvents Edition As DataGridViewCheckBoxColumn
    Friend WithEvents NIDFICHE As DataGridViewTextBoxColumn
    Friend WithEvents NCLASS As DataGridViewTextBoxColumn
    Friend WithEvents VLIB As DataGridViewTextBoxColumn
    Friend WithEvents NVAL As DataGridViewTextBoxColumn
    Friend WithEvents ColNVALOBJ As DataGridViewTextBoxColumn
    Friend WithEvents Début As DataGridViewTextBoxColumn
    Friend WithEvents Fin As DataGridViewTextBoxColumn
End Class
