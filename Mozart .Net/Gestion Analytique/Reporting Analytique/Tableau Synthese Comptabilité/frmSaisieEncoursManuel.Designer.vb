<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmSaisieEncoursManuel
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(frmSaisieEncoursManuel))
        Me.GCEncoursManuel = New DevExpress.XtraGrid.GridControl()
        Me.GVENCRSMANU = New DevExpress.XtraGrid.Views.Grid.GridView()
        Me.ColNCANNUM = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.ColNMONTANT = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.TextEditNMONTANT = New DevExpress.XtraEditors.Repository.RepositoryItemTextEdit()
        Me.ColVCOMMENTAIRE = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.TextEditVCOMMENTAIRE = New DevExpress.XtraEditors.Repository.RepositoryItemTextEdit()
        Me.GrpActions = New System.Windows.Forms.GroupBox()
        Me.BtnQuit = New System.Windows.Forms.Button()
        Me.BtnSave = New System.Windows.Forms.Button()
        Me.LblTitre = New System.Windows.Forms.Label()
        CType(Me.GCEncoursManuel, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.GVENCRSMANU, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.TextEditNMONTANT, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.TextEditVCOMMENTAIRE, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.GrpActions.SuspendLayout()
        Me.SuspendLayout()
        '
        'GCEncoursManuel
        '
        resources.ApplyResources(Me.GCEncoursManuel, "GCEncoursManuel")
        Me.GCEncoursManuel.MainView = Me.GVENCRSMANU
        Me.GCEncoursManuel.Name = "GCEncoursManuel"
        Me.GCEncoursManuel.RepositoryItems.AddRange(New DevExpress.XtraEditors.Repository.RepositoryItem() {Me.TextEditNMONTANT, Me.TextEditVCOMMENTAIRE})
        Me.GCEncoursManuel.ViewCollection.AddRange(New DevExpress.XtraGrid.Views.Base.BaseView() {Me.GVENCRSMANU})
        '
        'GVENCRSMANU
        '
        Me.GVENCRSMANU.Columns.AddRange(New DevExpress.XtraGrid.Columns.GridColumn() {Me.ColNCANNUM, Me.ColNMONTANT, Me.ColVCOMMENTAIRE})
        Me.GVENCRSMANU.GridControl = Me.GCEncoursManuel
        Me.GVENCRSMANU.Name = "GVENCRSMANU"
        Me.GVENCRSMANU.OptionsView.ShowFooter = True
        Me.GVENCRSMANU.OptionsView.ShowGroupPanel = False
        '
        'ColNCANNUM
        '
        Me.ColNCANNUM.AppearanceHeader.Font = CType(resources.GetObject("ColNCANNUM.AppearanceHeader.Font"), System.Drawing.Font)
        Me.ColNCANNUM.AppearanceHeader.ForeColor = System.Drawing.Color.Black
        Me.ColNCANNUM.AppearanceHeader.Options.UseFont = True
        Me.ColNCANNUM.AppearanceHeader.Options.UseForeColor = True
        Me.ColNCANNUM.AppearanceHeader.Options.UseTextOptions = True
        Me.ColNCANNUM.AppearanceHeader.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center
        Me.ColNCANNUM.AppearanceHeader.TextOptions.VAlignment = DevExpress.Utils.VertAlignment.Center
        resources.ApplyResources(Me.ColNCANNUM, "ColNCANNUM")
        Me.ColNCANNUM.FieldName = "NCANNUM"
        Me.ColNCANNUM.Name = "ColNCANNUM"
        Me.ColNCANNUM.OptionsColumn.AllowEdit = False
        Me.ColNCANNUM.OptionsColumn.ReadOnly = True
        '
        'ColNMONTANT
        '
        Me.ColNMONTANT.AppearanceHeader.Font = CType(resources.GetObject("ColNMONTANT.AppearanceHeader.Font"), System.Drawing.Font)
        Me.ColNMONTANT.AppearanceHeader.ForeColor = System.Drawing.Color.Black
        Me.ColNMONTANT.AppearanceHeader.Options.UseFont = True
        Me.ColNMONTANT.AppearanceHeader.Options.UseForeColor = True
        Me.ColNMONTANT.AppearanceHeader.Options.UseTextOptions = True
        Me.ColNMONTANT.AppearanceHeader.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center
        Me.ColNMONTANT.AppearanceHeader.TextOptions.VAlignment = DevExpress.Utils.VertAlignment.Center
        resources.ApplyResources(Me.ColNMONTANT, "ColNMONTANT")
        Me.ColNMONTANT.ColumnEdit = Me.TextEditNMONTANT
        Me.ColNMONTANT.DisplayFormat.FormatString = "d0"
        Me.ColNMONTANT.DisplayFormat.FormatType = DevExpress.Utils.FormatType.Numeric
        Me.ColNMONTANT.FieldName = "NMONTANT"
        Me.ColNMONTANT.Name = "ColNMONTANT"
        Me.ColNMONTANT.Summary.AddRange(New DevExpress.XtraGrid.GridSummaryItem() {New DevExpress.XtraGrid.GridColumnSummaryItem(CType(resources.GetObject("ColNMONTANT.Summary"), DevExpress.Data.SummaryItemType), resources.GetString("ColNMONTANT.Summary1"), resources.GetString("ColNMONTANT.Summary2"))})
        '
        'TextEditNMONTANT
        '
        Me.TextEditNMONTANT.AllowNullInput = DevExpress.Utils.DefaultBoolean.[True]
        resources.ApplyResources(Me.TextEditNMONTANT, "TextEditNMONTANT")
        Me.TextEditNMONTANT.Name = "TextEditNMONTANT"
        '
        'ColVCOMMENTAIRE
        '
        Me.ColVCOMMENTAIRE.AppearanceHeader.Font = CType(resources.GetObject("ColVCOMMENTAIRE.AppearanceHeader.Font"), System.Drawing.Font)
        Me.ColVCOMMENTAIRE.AppearanceHeader.ForeColor = System.Drawing.Color.Black
        Me.ColVCOMMENTAIRE.AppearanceHeader.Options.UseFont = True
        Me.ColVCOMMENTAIRE.AppearanceHeader.Options.UseForeColor = True
        Me.ColVCOMMENTAIRE.AppearanceHeader.Options.UseTextOptions = True
        Me.ColVCOMMENTAIRE.AppearanceHeader.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center
        Me.ColVCOMMENTAIRE.AppearanceHeader.TextOptions.VAlignment = DevExpress.Utils.VertAlignment.Center
        resources.ApplyResources(Me.ColVCOMMENTAIRE, "ColVCOMMENTAIRE")
        Me.ColVCOMMENTAIRE.ColumnEdit = Me.TextEditVCOMMENTAIRE
        Me.ColVCOMMENTAIRE.FieldName = "VCOMMENTAIRE"
        Me.ColVCOMMENTAIRE.Name = "ColVCOMMENTAIRE"
        '
        'TextEditVCOMMENTAIRE
        '
        resources.ApplyResources(Me.TextEditVCOMMENTAIRE, "TextEditVCOMMENTAIRE")
        Me.TextEditVCOMMENTAIRE.MaxLength = 1000
        Me.TextEditVCOMMENTAIRE.Name = "TextEditVCOMMENTAIRE"
        '
        'GrpActions
        '
        Me.GrpActions.Controls.Add(Me.BtnQuit)
        Me.GrpActions.Controls.Add(Me.BtnSave)
        resources.ApplyResources(Me.GrpActions, "GrpActions")
        Me.GrpActions.Name = "GrpActions"
        Me.GrpActions.TabStop = False
        '
        'BtnQuit
        '
        resources.ApplyResources(Me.BtnQuit, "BtnQuit")
        Me.BtnQuit.Name = "BtnQuit"
        Me.BtnQuit.UseVisualStyleBackColor = True
        '
        'BtnSave
        '
        resources.ApplyResources(Me.BtnSave, "BtnSave")
        Me.BtnSave.Name = "BtnSave"
        Me.BtnSave.UseVisualStyleBackColor = True
        '
        'LblTitre
        '
        resources.ApplyResources(Me.LblTitre, "LblTitre")
        Me.LblTitre.Name = "LblTitre"
        '
        'frmSaisieEncoursManuel
        '
        resources.ApplyResources(Me, "$this")
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.Wheat
        Me.Controls.Add(Me.LblTitre)
        Me.Controls.Add(Me.GrpActions)
        Me.Controls.Add(Me.GCEncoursManuel)
        Me.Name = "frmSaisieEncoursManuel"
        Me.WindowState = System.Windows.Forms.FormWindowState.Maximized
        CType(Me.GCEncoursManuel, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.GVENCRSMANU, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.TextEditNMONTANT, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.TextEditVCOMMENTAIRE, System.ComponentModel.ISupportInitialize).EndInit()
        Me.GrpActions.ResumeLayout(False)
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents GrpActions As System.Windows.Forms.GroupBox
    Friend WithEvents BtnSave As System.Windows.Forms.Button
    Friend WithEvents BtnQuit As System.Windows.Forms.Button
    Friend WithEvents LblTitre As System.Windows.Forms.Label
    Private WithEvents GCEncoursManuel As DevExpress.XtraGrid.GridControl
    Private WithEvents GVENCRSMANU As DevExpress.XtraGrid.Views.Grid.GridView
    Private WithEvents ColNCANNUM As DevExpress.XtraGrid.Columns.GridColumn
    Private WithEvents TextEditNMONTANT As DevExpress.XtraEditors.Repository.RepositoryItemTextEdit
    Private WithEvents ColNMONTANT As DevExpress.XtraGrid.Columns.GridColumn
    Private WithEvents ColVCOMMENTAIRE As DevExpress.XtraGrid.Columns.GridColumn
    Private WithEvents TextEditVCOMMENTAIRE As DevExpress.XtraEditors.Repository.RepositoryItemTextEdit
End Class
