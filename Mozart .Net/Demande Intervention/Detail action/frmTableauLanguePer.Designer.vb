<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmTableauLanguePer
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
        Me.PvtGridCompetence = New DevExpress.XtraPivotGrid.PivotGridControl()
        Me.PvtRowVTYPELIB = New DevExpress.XtraPivotGrid.PivotGridField()
        Me.PvtRowVLIBCOMPET = New DevExpress.XtraPivotGrid.PivotGridField()
        Me.PvtColVPERNOM = New DevExpress.XtraPivotGrid.PivotGridField()
        Me.PvtDataBAFFECTE = New DevExpress.XtraPivotGrid.PivotGridField()
        Me.GroupBox1 = New System.Windows.Forms.GroupBox()
        Me.BtnFermer = New System.Windows.Forms.Button()
        Me.RepositoryItemCheckEditBAFFECTE = New DevExpress.XtraEditors.Repository.RepositoryItemCheckEdit()
        CType(Me.PvtGridCompetence, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.GroupBox1.SuspendLayout()
        CType(Me.RepositoryItemCheckEditBAFFECTE, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'PvtGridCompetence
        '
        Me.PvtGridCompetence.Fields.AddRange(New DevExpress.XtraPivotGrid.PivotGridField() {Me.PvtRowVTYPELIB, Me.PvtRowVLIBCOMPET, Me.PvtColVPERNOM, Me.PvtDataBAFFECTE})
        Me.PvtGridCompetence.Location = New System.Drawing.Point(144, 12)
        Me.PvtGridCompetence.Name = "PvtGridCompetence"
        Me.PvtGridCompetence.OptionsBehavior.EditorShowMode = DevExpress.Utils.EditorShowMode.MouseDown
        Me.PvtGridCompetence.OptionsSelection.MultiSelect = False
        Me.PvtGridCompetence.OptionsView.ShowColumnGrandTotalHeader = False
        Me.PvtGridCompetence.OptionsView.ShowColumnGrandTotals = False
        Me.PvtGridCompetence.OptionsView.ShowColumnTotals = False
        Me.PvtGridCompetence.OptionsView.ShowDataHeaders = False
        Me.PvtGridCompetence.OptionsView.ShowFilterHeaders = False
        Me.PvtGridCompetence.OptionsView.ShowRowGrandTotalHeader = False
        Me.PvtGridCompetence.OptionsView.ShowRowGrandTotals = False
        Me.PvtGridCompetence.OptionsView.ShowRowTotals = False
        Me.PvtGridCompetence.RepositoryItems.AddRange(New DevExpress.XtraEditors.Repository.RepositoryItem() {Me.RepositoryItemCheckEditBAFFECTE})
        Me.PvtGridCompetence.Size = New System.Drawing.Size(1245, 535)
        Me.PvtGridCompetence.TabIndex = 7
        '
        'PvtRowVTYPELIB
        '
        Me.PvtRowVTYPELIB.Appearance.Value.Options.UseTextOptions = True
        Me.PvtRowVTYPELIB.Appearance.Value.TextOptions.VAlignment = DevExpress.Utils.VertAlignment.Center
        Me.PvtRowVTYPELIB.Appearance.Value.TextOptions.WordWrap = DevExpress.Utils.WordWrap.Wrap
        Me.PvtRowVTYPELIB.Area = DevExpress.XtraPivotGrid.PivotArea.RowArea
        Me.PvtRowVTYPELIB.AreaIndex = 0
        Me.PvtRowVTYPELIB.Caption = "Fonction"
        Me.PvtRowVTYPELIB.FieldName = "VTYPELIB"
        Me.PvtRowVTYPELIB.Name = "PvtRowVTYPELIB"
        Me.PvtRowVTYPELIB.Options.AllowDrag = DevExpress.Utils.DefaultBoolean.[False]
        Me.PvtRowVTYPELIB.Options.AllowEdit = False
        Me.PvtRowVTYPELIB.Options.AllowExpand = DevExpress.Utils.DefaultBoolean.[False]
        Me.PvtRowVTYPELIB.Options.ReadOnly = True
        Me.PvtRowVTYPELIB.Width = 150
        '
        'PvtRowVLIBCOMPET
        '
        Me.PvtRowVLIBCOMPET.Appearance.Value.Font = New System.Drawing.Font("Tahoma", 8.25!, System.Drawing.FontStyle.Bold)
        Me.PvtRowVLIBCOMPET.Appearance.Value.Options.UseFont = True
        Me.PvtRowVLIBCOMPET.Appearance.Value.Options.UseTextOptions = True
        Me.PvtRowVLIBCOMPET.Appearance.Value.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center
        Me.PvtRowVLIBCOMPET.Appearance.Value.TextOptions.VAlignment = DevExpress.Utils.VertAlignment.Center
        Me.PvtRowVLIBCOMPET.Appearance.Value.TextOptions.WordWrap = DevExpress.Utils.WordWrap.Wrap
        Me.PvtRowVLIBCOMPET.Area = DevExpress.XtraPivotGrid.PivotArea.ColumnArea
        Me.PvtRowVLIBCOMPET.AreaIndex = 0
        Me.PvtRowVLIBCOMPET.Caption = "Compétence"
        Me.PvtRowVLIBCOMPET.FieldName = "VLIBCOMPET"
        Me.PvtRowVLIBCOMPET.Name = "PvtRowVLIBCOMPET"
        Me.PvtRowVLIBCOMPET.Options.AllowEdit = False
        Me.PvtRowVLIBCOMPET.Options.ReadOnly = True
        Me.PvtRowVLIBCOMPET.Width = 80
        '
        'PvtColVPERNOM
        '
        Me.PvtColVPERNOM.Appearance.Value.Font = New System.Drawing.Font("Tahoma", 8.25!, System.Drawing.FontStyle.Bold)
        Me.PvtColVPERNOM.Appearance.Value.Options.UseFont = True
        Me.PvtColVPERNOM.Appearance.Value.Options.UseTextOptions = True
        Me.PvtColVPERNOM.Appearance.Value.TextOptions.VAlignment = DevExpress.Utils.VertAlignment.Center
        Me.PvtColVPERNOM.Appearance.Value.TextOptions.WordWrap = DevExpress.Utils.WordWrap.Wrap
        Me.PvtColVPERNOM.Area = DevExpress.XtraPivotGrid.PivotArea.RowArea
        Me.PvtColVPERNOM.AreaIndex = 1
        Me.PvtColVPERNOM.Caption = "Personne"
        Me.PvtColVPERNOM.ColumnValueLineCount = 2
        Me.PvtColVPERNOM.FieldName = "VPERNOM"
        Me.PvtColVPERNOM.Name = "PvtColVPERNOM"
        Me.PvtColVPERNOM.Options.AllowEdit = False
        Me.PvtColVPERNOM.Options.ReadOnly = True
        Me.PvtColVPERNOM.Width = 250
        '
        'PvtDataBAFFECTE
        '
        Me.PvtDataBAFFECTE.Area = DevExpress.XtraPivotGrid.PivotArea.DataArea
        Me.PvtDataBAFFECTE.AreaIndex = 0
        Me.PvtDataBAFFECTE.FieldEdit = Me.RepositoryItemCheckEditBAFFECTE
        Me.PvtDataBAFFECTE.FieldName = "BAFFECTE"
        Me.PvtDataBAFFECTE.Name = "PvtDataBAFFECTE"
        Me.PvtDataBAFFECTE.Options.AllowEdit = False
        Me.PvtDataBAFFECTE.Options.ReadOnly = True
        Me.PvtDataBAFFECTE.Width = 60
        '
        'GroupBox1
        '
        Me.GroupBox1.Controls.Add(Me.BtnFermer)
        Me.GroupBox1.Location = New System.Drawing.Point(12, 12)
        Me.GroupBox1.Name = "GroupBox1"
        Me.GroupBox1.Size = New System.Drawing.Size(126, 535)
        Me.GroupBox1.TabIndex = 32
        Me.GroupBox1.TabStop = False
        '
        'BtnFermer
        '
        Me.BtnFermer.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold)
        Me.BtnFermer.ImeMode = System.Windows.Forms.ImeMode.NoControl
        Me.BtnFermer.Location = New System.Drawing.Point(6, 472)
        Me.BtnFermer.Name = "BtnFermer"
        Me.BtnFermer.Size = New System.Drawing.Size(114, 48)
        Me.BtnFermer.TabIndex = 1
        Me.BtnFermer.Text = "Fermer"
        Me.BtnFermer.UseVisualStyleBackColor = True
        '
        'RepositoryItemCheckEditBAFFECTE
        '
        Me.RepositoryItemCheckEditBAFFECTE.AutoHeight = False
        Me.RepositoryItemCheckEditBAFFECTE.Name = "RepositoryItemCheckEditBAFFECTE"
        Me.RepositoryItemCheckEditBAFFECTE.NullStyle = DevExpress.XtraEditors.Controls.StyleIndeterminate.Unchecked
        Me.RepositoryItemCheckEditBAFFECTE.ValueChecked = New Decimal(New Integer() {1, 0, 0, 0})
        Me.RepositoryItemCheckEditBAFFECTE.ValueUnchecked = New Decimal(New Integer() {0, 0, 0, 0})
        '
        'frmTableauLanguePer
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.Wheat
        Me.ClientSize = New System.Drawing.Size(1406, 560)
        Me.Controls.Add(Me.GroupBox1)
        Me.Controls.Add(Me.PvtGridCompetence)
        Me.Name = "frmTableauLanguePer"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent
        Me.Text = "Qui parle quelle langue"
        CType(Me.PvtGridCompetence, System.ComponentModel.ISupportInitialize).EndInit()
        Me.GroupBox1.ResumeLayout(False)
        CType(Me.RepositoryItemCheckEditBAFFECTE, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents PvtGridCompetence As DevExpress.XtraPivotGrid.PivotGridControl
    Friend WithEvents PvtRowVTYPELIB As DevExpress.XtraPivotGrid.PivotGridField
    Friend WithEvents PvtRowVLIBCOMPET As DevExpress.XtraPivotGrid.PivotGridField
    Friend WithEvents PvtColVPERNOM As DevExpress.XtraPivotGrid.PivotGridField
    Friend WithEvents PvtDataBAFFECTE As DevExpress.XtraPivotGrid.PivotGridField
    Friend WithEvents GroupBox1 As System.Windows.Forms.GroupBox
    Friend WithEvents BtnFermer As System.Windows.Forms.Button
    Friend WithEvents RepositoryItemCheckEditBAFFECTE As DevExpress.XtraEditors.Repository.RepositoryItemCheckEdit
End Class
