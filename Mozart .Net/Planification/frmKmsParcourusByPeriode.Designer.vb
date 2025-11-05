<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class frmKmsParcourusByPeriode
    Inherits System.Windows.Forms.Form

    'Form remplace la méthode Dispose pour nettoyer la liste des composants.
    <System.Diagnostics.DebuggerNonUserCode()>
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
    <System.Diagnostics.DebuggerStepThrough()>
    Private Sub InitializeComponent()
        Me.GrpFilter = New System.Windows.Forms.GroupBox()
        Me.BtnValid = New System.Windows.Forms.Button()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.DTPFin = New System.Windows.Forms.DateTimePicker()
        Me.DTPDebut = New System.Windows.Forms.DateTimePicker()
        Me.GCKMS = New DevExpress.XtraGrid.GridControl()
        Me.GVKMS = New DevExpress.XtraGrid.Views.Grid.GridView()
        Me.ColVCLINOM = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.ColVSITNOM = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.ColDIPLDATJ = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.ColKMS = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.LblTitre = New System.Windows.Forms.Label()
        Me.GrpActions = New System.Windows.Forms.GroupBox()
        Me.BtnFermer = New System.Windows.Forms.Button()
        Me.GrpFilter.SuspendLayout()
        CType(Me.GCKMS, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.GVKMS, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.GrpActions.SuspendLayout()
        Me.SuspendLayout()
        '
        'GrpFilter
        '
        Me.GrpFilter.Controls.Add(Me.BtnValid)
        Me.GrpFilter.Controls.Add(Me.Label2)
        Me.GrpFilter.Controls.Add(Me.Label1)
        Me.GrpFilter.Controls.Add(Me.DTPFin)
        Me.GrpFilter.Controls.Add(Me.DTPDebut)
        Me.GrpFilter.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Bold)
        Me.GrpFilter.Location = New System.Drawing.Point(112, 44)
        Me.GrpFilter.Name = "GrpFilter"
        Me.GrpFilter.Size = New System.Drawing.Size(717, 62)
        Me.GrpFilter.TabIndex = 56
        Me.GrpFilter.TabStop = False
        Me.GrpFilter.Text = "Filtre"
        '
        'BtnValid
        '
        Me.BtnValid.ImeMode = System.Windows.Forms.ImeMode.NoControl
        Me.BtnValid.Location = New System.Drawing.Point(587, 14)
        Me.BtnValid.Name = "BtnValid"
        Me.BtnValid.Size = New System.Drawing.Size(105, 36)
        Me.BtnValid.TabIndex = 8
        Me.BtnValid.Text = "Valider"
        Me.BtnValid.UseVisualStyleBackColor = True
        '
        'Label2
        '
        Me.Label2.ImeMode = System.Windows.Forms.ImeMode.NoControl
        Me.Label2.Location = New System.Drawing.Point(292, 23)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(33, 27)
        Me.Label2.TabIndex = 7
        Me.Label2.Text = "Au"
        '
        'Label1
        '
        Me.Label1.ImeMode = System.Windows.Forms.ImeMode.NoControl
        Me.Label1.Location = New System.Drawing.Point(13, 24)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(33, 27)
        Me.Label1.TabIndex = 6
        Me.Label1.Text = "Du"
        '
        'DTPFin
        '
        Me.DTPFin.Location = New System.Drawing.Point(331, 21)
        Me.DTPFin.Name = "DTPFin"
        Me.DTPFin.Size = New System.Drawing.Size(241, 22)
        Me.DTPFin.TabIndex = 5
        '
        'DTPDebut
        '
        Me.DTPDebut.Location = New System.Drawing.Point(52, 21)
        Me.DTPDebut.Name = "DTPDebut"
        Me.DTPDebut.Size = New System.Drawing.Size(230, 22)
        Me.DTPDebut.TabIndex = 4
        '
        'GCKMS
        '
        Me.GCKMS.Location = New System.Drawing.Point(112, 112)
        Me.GCKMS.MainView = Me.GVKMS
        Me.GCKMS.Name = "GCKMS"
        Me.GCKMS.Size = New System.Drawing.Size(719, 559)
        Me.GCKMS.TabIndex = 55
        Me.GCKMS.ViewCollection.AddRange(New DevExpress.XtraGrid.Views.Base.BaseView() {Me.GVKMS})
        '
        'GVKMS
        '
        Me.GVKMS.Appearance.HeaderPanel.Font = New System.Drawing.Font("Tahoma", 8.25!, System.Drawing.FontStyle.Bold)
        Me.GVKMS.Appearance.HeaderPanel.Options.UseFont = True
        Me.GVKMS.Appearance.HeaderPanel.Options.UseTextOptions = True
        Me.GVKMS.Appearance.HeaderPanel.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center
        Me.GVKMS.Appearance.HeaderPanel.TextOptions.VAlignment = DevExpress.Utils.VertAlignment.Center
        Me.GVKMS.Columns.AddRange(New DevExpress.XtraGrid.Columns.GridColumn() {Me.ColVCLINOM, Me.ColVSITNOM, Me.ColDIPLDATJ, Me.ColKMS})
        Me.GVKMS.GridControl = Me.GCKMS
        Me.GVKMS.Name = "GVKMS"
        Me.GVKMS.OptionsBehavior.Editable = False
        Me.GVKMS.OptionsBehavior.ReadOnly = True
        Me.GVKMS.OptionsView.ShowAutoFilterRow = True
        Me.GVKMS.OptionsView.ShowFooter = True
        Me.GVKMS.OptionsView.ShowGroupPanel = False
        '
        'ColVCLINOM
        '
        Me.ColVCLINOM.AppearanceHeader.ForeColor = System.Drawing.Color.Black
        Me.ColVCLINOM.AppearanceHeader.Options.UseForeColor = True
        Me.ColVCLINOM.Caption = "Client"
        Me.ColVCLINOM.FieldName = "VCLINOM"
        Me.ColVCLINOM.Name = "ColVCLINOM"
        Me.ColVCLINOM.Visible = True
        Me.ColVCLINOM.VisibleIndex = 0
        Me.ColVCLINOM.Width = 250
        '
        'ColVSITNOM
        '
        Me.ColVSITNOM.AppearanceHeader.ForeColor = System.Drawing.Color.Black
        Me.ColVSITNOM.AppearanceHeader.Options.UseForeColor = True
        Me.ColVSITNOM.Caption = "Site"
        Me.ColVSITNOM.FieldName = "VSITNOM"
        Me.ColVSITNOM.Name = "ColVSITNOM"
        Me.ColVSITNOM.Visible = True
        Me.ColVSITNOM.VisibleIndex = 1
        Me.ColVSITNOM.Width = 230
        '
        'ColDIPLDATJ
        '
        Me.ColDIPLDATJ.AppearanceHeader.ForeColor = System.Drawing.Color.Black
        Me.ColDIPLDATJ.AppearanceHeader.Options.UseForeColor = True
        Me.ColDIPLDATJ.Caption = "Date"
        Me.ColDIPLDATJ.FieldName = "DIPLDATJ"
        Me.ColDIPLDATJ.Name = "ColDIPLDATJ"
        Me.ColDIPLDATJ.Visible = True
        Me.ColDIPLDATJ.VisibleIndex = 2
        Me.ColDIPLDATJ.Width = 128
        '
        'ColKMS
        '
        Me.ColKMS.AppearanceCell.Options.UseTextOptions = True
        Me.ColKMS.AppearanceCell.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Far
        Me.ColKMS.AppearanceHeader.ForeColor = System.Drawing.Color.Black
        Me.ColKMS.AppearanceHeader.Options.UseForeColor = True
        Me.ColKMS.Caption = "Kms Parcourus"
        Me.ColKMS.DisplayFormat.FormatString = "n0"
        Me.ColKMS.DisplayFormat.FormatType = DevExpress.Utils.FormatType.Numeric
        Me.ColKMS.FieldName = "NKMSPARCOURS"
        Me.ColKMS.Name = "ColKMS"
        Me.ColKMS.Summary.AddRange(New DevExpress.XtraGrid.GridSummaryItem() {New DevExpress.XtraGrid.GridColumnSummaryItem(DevExpress.Data.SummaryItemType.Sum, "NKMSPARCOURS", "TOTAL={0:0.##}")})
        Me.ColKMS.Visible = True
        Me.ColKMS.VisibleIndex = 3
        Me.ColKMS.Width = 93
        '
        'LblTitre
        '
        Me.LblTitre.AutoSize = True
        Me.LblTitre.Font = New System.Drawing.Font("Arial", 18.0!, System.Drawing.FontStyle.Bold)
        Me.LblTitre.ImeMode = System.Windows.Forms.ImeMode.NoControl
        Me.LblTitre.Location = New System.Drawing.Point(107, 12)
        Me.LblTitre.Name = "LblTitre"
        Me.LblTitre.Size = New System.Drawing.Size(316, 29)
        Me.LblTitre.TabIndex = 54
        Me.LblTitre.Text = "Nombre de kms parcourus"
        '
        'GrpActions
        '
        Me.GrpActions.Controls.Add(Me.BtnFermer)
        Me.GrpActions.Location = New System.Drawing.Point(12, 12)
        Me.GrpActions.Name = "GrpActions"
        Me.GrpActions.Size = New System.Drawing.Size(89, 659)
        Me.GrpActions.TabIndex = 53
        Me.GrpActions.TabStop = False
        '
        'BtnFermer
        '
        Me.BtnFermer.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold)
        Me.BtnFermer.ImeMode = System.Windows.Forms.ImeMode.NoControl
        Me.BtnFermer.Location = New System.Drawing.Point(6, 605)
        Me.BtnFermer.Name = "BtnFermer"
        Me.BtnFermer.Size = New System.Drawing.Size(75, 48)
        Me.BtnFermer.TabIndex = 1
        Me.BtnFermer.Text = "Fermer"
        Me.BtnFermer.UseVisualStyleBackColor = True
        '
        'frmKmsParcourusByPeriode
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.Wheat
        Me.ClientSize = New System.Drawing.Size(843, 698)
        Me.Controls.Add(Me.GrpFilter)
        Me.Controls.Add(Me.GCKMS)
        Me.Controls.Add(Me.LblTitre)
        Me.Controls.Add(Me.GrpActions)
        Me.Name = "frmKmsParcourusByPeriode"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Nombre de kms parcourus"
        Me.GrpFilter.ResumeLayout(False)
        CType(Me.GCKMS, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.GVKMS, System.ComponentModel.ISupportInitialize).EndInit()
        Me.GrpActions.ResumeLayout(False)
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents GrpFilter As GroupBox
    Friend WithEvents BtnValid As Button
    Friend WithEvents Label2 As Label
    Friend WithEvents Label1 As Label
    Friend WithEvents DTPFin As DateTimePicker
    Friend WithEvents DTPDebut As DateTimePicker
    Private WithEvents GCKMS As DevExpress.XtraGrid.GridControl
    Private WithEvents GVKMS As DevExpress.XtraGrid.Views.Grid.GridView
    Private WithEvents ColVCLINOM As DevExpress.XtraGrid.Columns.GridColumn
    Private WithEvents ColVSITNOM As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents LblTitre As Label
    Friend WithEvents GrpActions As GroupBox
    Friend WithEvents BtnFermer As Button
    Friend WithEvents ColDIPLDATJ As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents ColKMS As DevExpress.XtraGrid.Columns.GridColumn
End Class
