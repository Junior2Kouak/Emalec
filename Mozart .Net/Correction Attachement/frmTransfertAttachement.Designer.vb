<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmTransfertAttachement
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(frmTransfertAttachement))
        Dim DataGridViewCellStyle9 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim DataGridViewCellStyle10 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim DataGridViewCellStyle11 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim DataGridViewCellStyle12 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim DataGridViewCellStyle13 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim DataGridViewCellStyle14 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim DataGridViewCellStyle15 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim DataGridViewCellStyle16 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Me.BtnQuitter = New System.Windows.Forms.Button()
        Me.GrpBoxVisuEMALEC = New System.Windows.Forms.GroupBox()
        Me.WBVisuAttachEMALEC = New System.Windows.Forms.WebBrowser()
        Me.GrpBoxLstDIEMASOLAR = New System.Windows.Forms.GroupBox()
        Me.DGVListeDIEMASOLAR = New System.Windows.Forms.DataGridView()
        Me.ColNACTNUM = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.ColNDINNUM = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.ColNACTID = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.ColNDINCTE = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.ColVCLINOM = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.ColVSITNOM = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.ColVACTDES = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.ColDACTDEX = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.BtnPrevisu = New System.Windows.Forms.Button()
        Me.BtnTransfertAttachement = New System.Windows.Forms.Button()
        Me.GrpBoxVisuEMALEC.SuspendLayout()
        Me.GrpBoxLstDIEMASOLAR.SuspendLayout()
        CType(Me.DGVListeDIEMASOLAR, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'BtnQuitter
        '
        resources.ApplyResources(Me.BtnQuitter, "BtnQuitter")
        Me.BtnQuitter.Name = "BtnQuitter"
        Me.BtnQuitter.UseVisualStyleBackColor = True
        '
        'GrpBoxVisuEMALEC
        '
        Me.GrpBoxVisuEMALEC.Controls.Add(Me.WBVisuAttachEMALEC)
        resources.ApplyResources(Me.GrpBoxVisuEMALEC, "GrpBoxVisuEMALEC")
        Me.GrpBoxVisuEMALEC.Name = "GrpBoxVisuEMALEC"
        Me.GrpBoxVisuEMALEC.TabStop = False
        '
        'WBVisuAttachEMALEC
        '
        resources.ApplyResources(Me.WBVisuAttachEMALEC, "WBVisuAttachEMALEC")
        Me.WBVisuAttachEMALEC.Name = "WBVisuAttachEMALEC"
        '
        'GrpBoxLstDIEMASOLAR
        '
        Me.GrpBoxLstDIEMASOLAR.Controls.Add(Me.DGVListeDIEMASOLAR)
        resources.ApplyResources(Me.GrpBoxLstDIEMASOLAR, "GrpBoxLstDIEMASOLAR")
        Me.GrpBoxLstDIEMASOLAR.Name = "GrpBoxLstDIEMASOLAR"
        Me.GrpBoxLstDIEMASOLAR.TabStop = False
        '
        'DGVListeDIEMASOLAR
        '
        Me.DGVListeDIEMASOLAR.AllowUserToAddRows = False
        Me.DGVListeDIEMASOLAR.AllowUserToDeleteRows = False
        DataGridViewCellStyle9.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter
        DataGridViewCellStyle9.BackColor = System.Drawing.SystemColors.Control
        DataGridViewCellStyle9.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        DataGridViewCellStyle9.ForeColor = System.Drawing.SystemColors.WindowText
        DataGridViewCellStyle9.SelectionBackColor = System.Drawing.SystemColors.Highlight
        DataGridViewCellStyle9.SelectionForeColor = System.Drawing.SystemColors.HighlightText
        DataGridViewCellStyle9.WrapMode = System.Windows.Forms.DataGridViewTriState.[True]
        Me.DGVListeDIEMASOLAR.ColumnHeadersDefaultCellStyle = DataGridViewCellStyle9
        Me.DGVListeDIEMASOLAR.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.DGVListeDIEMASOLAR.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {Me.ColNACTNUM, Me.ColNDINNUM, Me.ColNACTID, Me.ColNDINCTE, Me.ColVCLINOM, Me.ColVSITNOM, Me.ColVACTDES, Me.ColDACTDEX})
        resources.ApplyResources(Me.DGVListeDIEMASOLAR, "DGVListeDIEMASOLAR")
        Me.DGVListeDIEMASOLAR.MultiSelect = False
        Me.DGVListeDIEMASOLAR.Name = "DGVListeDIEMASOLAR"
        Me.DGVListeDIEMASOLAR.ReadOnly = True
        Me.DGVListeDIEMASOLAR.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect
        '
        'ColNACTNUM
        '
        Me.ColNACTNUM.DataPropertyName = "NACTNUM"
        resources.ApplyResources(Me.ColNACTNUM, "ColNACTNUM")
        Me.ColNACTNUM.Name = "ColNACTNUM"
        Me.ColNACTNUM.ReadOnly = True
        '
        'ColNDINNUM
        '
        Me.ColNDINNUM.DataPropertyName = "NDINNUM"
        DataGridViewCellStyle10.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleRight
        DataGridViewCellStyle10.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.ColNDINNUM.DefaultCellStyle = DataGridViewCellStyle10
        resources.ApplyResources(Me.ColNDINNUM, "ColNDINNUM")
        Me.ColNDINNUM.Name = "ColNDINNUM"
        Me.ColNDINNUM.ReadOnly = True
        '
        'ColNACTID
        '
        Me.ColNACTID.DataPropertyName = "NACTID"
        DataGridViewCellStyle11.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleRight
        Me.ColNACTID.DefaultCellStyle = DataGridViewCellStyle11
        resources.ApplyResources(Me.ColNACTID, "ColNACTID")
        Me.ColNACTID.Name = "ColNACTID"
        Me.ColNACTID.ReadOnly = True
        '
        'ColNDINCTE
        '
        Me.ColNDINCTE.DataPropertyName = "NDINCTE"
        DataGridViewCellStyle12.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter
        Me.ColNDINCTE.DefaultCellStyle = DataGridViewCellStyle12
        resources.ApplyResources(Me.ColNDINCTE, "ColNDINCTE")
        Me.ColNDINCTE.Name = "ColNDINCTE"
        Me.ColNDINCTE.ReadOnly = True
        '
        'ColVCLINOM
        '
        Me.ColVCLINOM.DataPropertyName = "VCLINOM"
        DataGridViewCellStyle13.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter
        Me.ColVCLINOM.DefaultCellStyle = DataGridViewCellStyle13
        resources.ApplyResources(Me.ColVCLINOM, "ColVCLINOM")
        Me.ColVCLINOM.Name = "ColVCLINOM"
        Me.ColVCLINOM.ReadOnly = True
        '
        'ColVSITNOM
        '
        Me.ColVSITNOM.DataPropertyName = "VSITNOM"
        DataGridViewCellStyle14.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter
        Me.ColVSITNOM.DefaultCellStyle = DataGridViewCellStyle14
        resources.ApplyResources(Me.ColVSITNOM, "ColVSITNOM")
        Me.ColVSITNOM.Name = "ColVSITNOM"
        Me.ColVSITNOM.ReadOnly = True
        '
        'ColVACTDES
        '
        Me.ColVACTDES.DataPropertyName = "VACTDES"
        DataGridViewCellStyle15.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter
        Me.ColVACTDES.DefaultCellStyle = DataGridViewCellStyle15
        resources.ApplyResources(Me.ColVACTDES, "ColVACTDES")
        Me.ColVACTDES.Name = "ColVACTDES"
        Me.ColVACTDES.ReadOnly = True
        '
        'ColDACTDEX
        '
        Me.ColDACTDEX.DataPropertyName = "DACTDEX"
        DataGridViewCellStyle16.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter
        Me.ColDACTDEX.DefaultCellStyle = DataGridViewCellStyle16
        resources.ApplyResources(Me.ColDACTDEX, "ColDACTDEX")
        Me.ColDACTDEX.Name = "ColDACTDEX"
        Me.ColDACTDEX.ReadOnly = True
        '
        'BtnPrevisu
        '
        resources.ApplyResources(Me.BtnPrevisu, "BtnPrevisu")
        Me.BtnPrevisu.Name = "BtnPrevisu"
        Me.BtnPrevisu.UseVisualStyleBackColor = True
        '
        'BtnTransfertAttachement
        '
        resources.ApplyResources(Me.BtnTransfertAttachement, "BtnTransfertAttachement")
        Me.BtnTransfertAttachement.Name = "BtnTransfertAttachement"
        Me.BtnTransfertAttachement.UseVisualStyleBackColor = True
        '
        'frmTransfertAttachement
        '
        resources.ApplyResources(Me, "$this")
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.Wheat
        Me.Controls.Add(Me.BtnTransfertAttachement)
        Me.Controls.Add(Me.BtnPrevisu)
        Me.Controls.Add(Me.GrpBoxLstDIEMASOLAR)
        Me.Controls.Add(Me.GrpBoxVisuEMALEC)
        Me.Controls.Add(Me.BtnQuitter)
        Me.Name = "frmTransfertAttachement"
        Me.WindowState = System.Windows.Forms.FormWindowState.Maximized
        Me.GrpBoxVisuEMALEC.ResumeLayout(False)
        Me.GrpBoxLstDIEMASOLAR.ResumeLayout(False)
        CType(Me.DGVListeDIEMASOLAR, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents BtnQuitter As System.Windows.Forms.Button
    Friend WithEvents GrpBoxVisuEMALEC As System.Windows.Forms.GroupBox
    Friend WithEvents WBVisuAttachEMALEC As System.Windows.Forms.WebBrowser
    Friend WithEvents GrpBoxLstDIEMASOLAR As System.Windows.Forms.GroupBox
    Friend WithEvents DGVListeDIEMASOLAR As System.Windows.Forms.DataGridView
    Friend WithEvents BtnPrevisu As System.Windows.Forms.Button
    Friend WithEvents BtnTransfertAttachement As System.Windows.Forms.Button
    Friend WithEvents ColNACTNUM As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents ColNDINNUM As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents ColNACTID As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents ColNDINCTE As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents ColVCLINOM As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents ColVSITNOM As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents ColVACTDES As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents ColDACTDEX As System.Windows.Forms.DataGridViewTextBoxColumn
End Class
