<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmGTPGestSite
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(frmGTPGestSite))
        Me.GCGTPGESTSIT = New DevExpress.XtraGrid.GridControl()
        Me.GVGTPGESTSIT = New DevExpress.XtraGrid.Views.Grid.GridView()
        Me.ColIDTMP = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.ColNCLINUM = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.ColNSITNUM = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.ColVCLINOM = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.ColVSITNOM = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.BtnModifier = New System.Windows.Forms.Button()
        Me.BtnSupprLine = New System.Windows.Forms.Button()
        Me.BtnAddLine = New System.Windows.Forms.Button()
        Me.GrpActions = New System.Windows.Forms.GroupBox()
        Me.BtnAudit = New System.Windows.Forms.Button()
        Me.BtnQuit = New System.Windows.Forms.Button()
        Me.BtnSave = New System.Windows.Forms.Button()
        Me.Label1 = New System.Windows.Forms.Label()
        CType(Me.GCGTPGESTSIT, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.GVGTPGESTSIT, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.GrpActions.SuspendLayout()
        Me.SuspendLayout()
        '
        'GCGTPGESTSIT
        '
        resources.ApplyResources(Me.GCGTPGESTSIT, "GCGTPGESTSIT")
        Me.GCGTPGESTSIT.MainView = Me.GVGTPGESTSIT
        Me.GCGTPGESTSIT.Name = "GCGTPGESTSIT"
        Me.GCGTPGESTSIT.ViewCollection.AddRange(New DevExpress.XtraGrid.Views.Base.BaseView() {Me.GVGTPGESTSIT})
        '
        'GVGTPGESTSIT
        '
        Me.GVGTPGESTSIT.Appearance.ColumnFilterButton.BackColor = CType(resources.GetObject("GVGTPGESTSIT.Appearance.ColumnFilterButton.BackColor"), System.Drawing.Color)
        Me.GVGTPGESTSIT.Appearance.ColumnFilterButton.BorderColor = CType(resources.GetObject("GVGTPGESTSIT.Appearance.ColumnFilterButton.BorderColor"), System.Drawing.Color)
        Me.GVGTPGESTSIT.Appearance.ColumnFilterButton.ForeColor = CType(resources.GetObject("GVGTPGESTSIT.Appearance.ColumnFilterButton.ForeColor"), System.Drawing.Color)
        Me.GVGTPGESTSIT.Appearance.ColumnFilterButton.Options.UseBackColor = True
        Me.GVGTPGESTSIT.Appearance.ColumnFilterButton.Options.UseBorderColor = True
        Me.GVGTPGESTSIT.Appearance.ColumnFilterButton.Options.UseForeColor = True
        Me.GVGTPGESTSIT.Appearance.ColumnFilterButtonActive.BackColor = CType(resources.GetObject("GVGTPGESTSIT.Appearance.ColumnFilterButtonActive.BackColor"), System.Drawing.Color)
        Me.GVGTPGESTSIT.Appearance.ColumnFilterButtonActive.BorderColor = CType(resources.GetObject("GVGTPGESTSIT.Appearance.ColumnFilterButtonActive.BorderColor"), System.Drawing.Color)
        Me.GVGTPGESTSIT.Appearance.ColumnFilterButtonActive.ForeColor = CType(resources.GetObject("GVGTPGESTSIT.Appearance.ColumnFilterButtonActive.ForeColor"), System.Drawing.Color)
        Me.GVGTPGESTSIT.Appearance.ColumnFilterButtonActive.Options.UseBackColor = True
        Me.GVGTPGESTSIT.Appearance.ColumnFilterButtonActive.Options.UseBorderColor = True
        Me.GVGTPGESTSIT.Appearance.ColumnFilterButtonActive.Options.UseForeColor = True
        Me.GVGTPGESTSIT.Appearance.Empty.BackColor = CType(resources.GetObject("GVGTPGESTSIT.Appearance.Empty.BackColor"), System.Drawing.Color)
        Me.GVGTPGESTSIT.Appearance.Empty.BackColor2 = CType(resources.GetObject("GVGTPGESTSIT.Appearance.Empty.BackColor2"), System.Drawing.Color)
        Me.GVGTPGESTSIT.Appearance.Empty.Options.UseBackColor = True
        Me.GVGTPGESTSIT.Appearance.EvenRow.BackColor = CType(resources.GetObject("GVGTPGESTSIT.Appearance.EvenRow.BackColor"), System.Drawing.Color)
        Me.GVGTPGESTSIT.Appearance.EvenRow.BorderColor = CType(resources.GetObject("GVGTPGESTSIT.Appearance.EvenRow.BorderColor"), System.Drawing.Color)
        Me.GVGTPGESTSIT.Appearance.EvenRow.ForeColor = CType(resources.GetObject("GVGTPGESTSIT.Appearance.EvenRow.ForeColor"), System.Drawing.Color)
        Me.GVGTPGESTSIT.Appearance.EvenRow.Options.UseBackColor = True
        Me.GVGTPGESTSIT.Appearance.EvenRow.Options.UseBorderColor = True
        Me.GVGTPGESTSIT.Appearance.EvenRow.Options.UseForeColor = True
        Me.GVGTPGESTSIT.Appearance.FilterCloseButton.BackColor = CType(resources.GetObject("GVGTPGESTSIT.Appearance.FilterCloseButton.BackColor"), System.Drawing.Color)
        Me.GVGTPGESTSIT.Appearance.FilterCloseButton.BorderColor = CType(resources.GetObject("GVGTPGESTSIT.Appearance.FilterCloseButton.BorderColor"), System.Drawing.Color)
        Me.GVGTPGESTSIT.Appearance.FilterCloseButton.ForeColor = CType(resources.GetObject("GVGTPGESTSIT.Appearance.FilterCloseButton.ForeColor"), System.Drawing.Color)
        Me.GVGTPGESTSIT.Appearance.FilterCloseButton.Options.UseBackColor = True
        Me.GVGTPGESTSIT.Appearance.FilterCloseButton.Options.UseBorderColor = True
        Me.GVGTPGESTSIT.Appearance.FilterCloseButton.Options.UseForeColor = True
        Me.GVGTPGESTSIT.Appearance.FilterPanel.BackColor = CType(resources.GetObject("GVGTPGESTSIT.Appearance.FilterPanel.BackColor"), System.Drawing.Color)
        Me.GVGTPGESTSIT.Appearance.FilterPanel.BackColor2 = CType(resources.GetObject("GVGTPGESTSIT.Appearance.FilterPanel.BackColor2"), System.Drawing.Color)
        Me.GVGTPGESTSIT.Appearance.FilterPanel.ForeColor = CType(resources.GetObject("GVGTPGESTSIT.Appearance.FilterPanel.ForeColor"), System.Drawing.Color)
        Me.GVGTPGESTSIT.Appearance.FilterPanel.Options.UseBackColor = True
        Me.GVGTPGESTSIT.Appearance.FilterPanel.Options.UseForeColor = True
        Me.GVGTPGESTSIT.Appearance.FixedLine.BackColor = CType(resources.GetObject("GVGTPGESTSIT.Appearance.FixedLine.BackColor"), System.Drawing.Color)
        Me.GVGTPGESTSIT.Appearance.FixedLine.Options.UseBackColor = True
        Me.GVGTPGESTSIT.Appearance.FocusedCell.BackColor = CType(resources.GetObject("GVGTPGESTSIT.Appearance.FocusedCell.BackColor"), System.Drawing.Color)
        Me.GVGTPGESTSIT.Appearance.FocusedCell.ForeColor = CType(resources.GetObject("GVGTPGESTSIT.Appearance.FocusedCell.ForeColor"), System.Drawing.Color)
        Me.GVGTPGESTSIT.Appearance.FocusedCell.Options.UseBackColor = True
        Me.GVGTPGESTSIT.Appearance.FocusedCell.Options.UseForeColor = True
        Me.GVGTPGESTSIT.Appearance.FocusedRow.BackColor = CType(resources.GetObject("GVGTPGESTSIT.Appearance.FocusedRow.BackColor"), System.Drawing.Color)
        Me.GVGTPGESTSIT.Appearance.FocusedRow.BorderColor = CType(resources.GetObject("GVGTPGESTSIT.Appearance.FocusedRow.BorderColor"), System.Drawing.Color)
        Me.GVGTPGESTSIT.Appearance.FocusedRow.ForeColor = CType(resources.GetObject("GVGTPGESTSIT.Appearance.FocusedRow.ForeColor"), System.Drawing.Color)
        Me.GVGTPGESTSIT.Appearance.FocusedRow.Options.UseBackColor = True
        Me.GVGTPGESTSIT.Appearance.FocusedRow.Options.UseBorderColor = True
        Me.GVGTPGESTSIT.Appearance.FocusedRow.Options.UseForeColor = True
        Me.GVGTPGESTSIT.Appearance.FooterPanel.BackColor = CType(resources.GetObject("GVGTPGESTSIT.Appearance.FooterPanel.BackColor"), System.Drawing.Color)
        Me.GVGTPGESTSIT.Appearance.FooterPanel.BorderColor = CType(resources.GetObject("GVGTPGESTSIT.Appearance.FooterPanel.BorderColor"), System.Drawing.Color)
        Me.GVGTPGESTSIT.Appearance.FooterPanel.ForeColor = CType(resources.GetObject("GVGTPGESTSIT.Appearance.FooterPanel.ForeColor"), System.Drawing.Color)
        Me.GVGTPGESTSIT.Appearance.FooterPanel.Options.UseBackColor = True
        Me.GVGTPGESTSIT.Appearance.FooterPanel.Options.UseBorderColor = True
        Me.GVGTPGESTSIT.Appearance.FooterPanel.Options.UseForeColor = True
        Me.GVGTPGESTSIT.Appearance.GroupButton.BackColor = CType(resources.GetObject("GVGTPGESTSIT.Appearance.GroupButton.BackColor"), System.Drawing.Color)
        Me.GVGTPGESTSIT.Appearance.GroupButton.BorderColor = CType(resources.GetObject("GVGTPGESTSIT.Appearance.GroupButton.BorderColor"), System.Drawing.Color)
        Me.GVGTPGESTSIT.Appearance.GroupButton.Options.UseBackColor = True
        Me.GVGTPGESTSIT.Appearance.GroupButton.Options.UseBorderColor = True
        Me.GVGTPGESTSIT.Appearance.GroupFooter.BackColor = CType(resources.GetObject("GVGTPGESTSIT.Appearance.GroupFooter.BackColor"), System.Drawing.Color)
        Me.GVGTPGESTSIT.Appearance.GroupFooter.BorderColor = CType(resources.GetObject("GVGTPGESTSIT.Appearance.GroupFooter.BorderColor"), System.Drawing.Color)
        Me.GVGTPGESTSIT.Appearance.GroupFooter.ForeColor = CType(resources.GetObject("GVGTPGESTSIT.Appearance.GroupFooter.ForeColor"), System.Drawing.Color)
        Me.GVGTPGESTSIT.Appearance.GroupFooter.Options.UseBackColor = True
        Me.GVGTPGESTSIT.Appearance.GroupFooter.Options.UseBorderColor = True
        Me.GVGTPGESTSIT.Appearance.GroupFooter.Options.UseForeColor = True
        Me.GVGTPGESTSIT.Appearance.GroupPanel.BackColor = CType(resources.GetObject("GVGTPGESTSIT.Appearance.GroupPanel.BackColor"), System.Drawing.Color)
        Me.GVGTPGESTSIT.Appearance.GroupPanel.BackColor2 = CType(resources.GetObject("GVGTPGESTSIT.Appearance.GroupPanel.BackColor2"), System.Drawing.Color)
        Me.GVGTPGESTSIT.Appearance.GroupPanel.ForeColor = CType(resources.GetObject("GVGTPGESTSIT.Appearance.GroupPanel.ForeColor"), System.Drawing.Color)
        Me.GVGTPGESTSIT.Appearance.GroupPanel.Options.UseBackColor = True
        Me.GVGTPGESTSIT.Appearance.GroupPanel.Options.UseForeColor = True
        Me.GVGTPGESTSIT.Appearance.GroupRow.BackColor = CType(resources.GetObject("GVGTPGESTSIT.Appearance.GroupRow.BackColor"), System.Drawing.Color)
        Me.GVGTPGESTSIT.Appearance.GroupRow.BorderColor = CType(resources.GetObject("GVGTPGESTSIT.Appearance.GroupRow.BorderColor"), System.Drawing.Color)
        Me.GVGTPGESTSIT.Appearance.GroupRow.ForeColor = CType(resources.GetObject("GVGTPGESTSIT.Appearance.GroupRow.ForeColor"), System.Drawing.Color)
        Me.GVGTPGESTSIT.Appearance.GroupRow.Options.UseBackColor = True
        Me.GVGTPGESTSIT.Appearance.GroupRow.Options.UseBorderColor = True
        Me.GVGTPGESTSIT.Appearance.GroupRow.Options.UseForeColor = True
        Me.GVGTPGESTSIT.Appearance.HeaderPanel.BackColor = CType(resources.GetObject("GVGTPGESTSIT.Appearance.HeaderPanel.BackColor"), System.Drawing.Color)
        Me.GVGTPGESTSIT.Appearance.HeaderPanel.BorderColor = CType(resources.GetObject("GVGTPGESTSIT.Appearance.HeaderPanel.BorderColor"), System.Drawing.Color)
        Me.GVGTPGESTSIT.Appearance.HeaderPanel.Font = CType(resources.GetObject("GVGTPGESTSIT.Appearance.HeaderPanel.Font"), System.Drawing.Font)
        Me.GVGTPGESTSIT.Appearance.HeaderPanel.ForeColor = CType(resources.GetObject("GVGTPGESTSIT.Appearance.HeaderPanel.ForeColor"), System.Drawing.Color)
        Me.GVGTPGESTSIT.Appearance.HeaderPanel.Options.UseBackColor = True
        Me.GVGTPGESTSIT.Appearance.HeaderPanel.Options.UseBorderColor = True
        Me.GVGTPGESTSIT.Appearance.HeaderPanel.Options.UseFont = True
        Me.GVGTPGESTSIT.Appearance.HeaderPanel.Options.UseForeColor = True
        Me.GVGTPGESTSIT.Appearance.HeaderPanel.Options.UseTextOptions = True
        Me.GVGTPGESTSIT.Appearance.HeaderPanel.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center
        Me.GVGTPGESTSIT.Appearance.HeaderPanel.TextOptions.VAlignment = DevExpress.Utils.VertAlignment.Center
        Me.GVGTPGESTSIT.Appearance.HeaderPanel.TextOptions.WordWrap = DevExpress.Utils.WordWrap.Wrap
        Me.GVGTPGESTSIT.Appearance.HideSelectionRow.BackColor = CType(resources.GetObject("GVGTPGESTSIT.Appearance.HideSelectionRow.BackColor"), System.Drawing.Color)
        Me.GVGTPGESTSIT.Appearance.HideSelectionRow.BorderColor = CType(resources.GetObject("GVGTPGESTSIT.Appearance.HideSelectionRow.BorderColor"), System.Drawing.Color)
        Me.GVGTPGESTSIT.Appearance.HideSelectionRow.ForeColor = CType(resources.GetObject("GVGTPGESTSIT.Appearance.HideSelectionRow.ForeColor"), System.Drawing.Color)
        Me.GVGTPGESTSIT.Appearance.HideSelectionRow.Options.UseBackColor = True
        Me.GVGTPGESTSIT.Appearance.HideSelectionRow.Options.UseBorderColor = True
        Me.GVGTPGESTSIT.Appearance.HideSelectionRow.Options.UseForeColor = True
        Me.GVGTPGESTSIT.Appearance.HorzLine.BackColor = CType(resources.GetObject("GVGTPGESTSIT.Appearance.HorzLine.BackColor"), System.Drawing.Color)
        Me.GVGTPGESTSIT.Appearance.HorzLine.Options.UseBackColor = True
        Me.GVGTPGESTSIT.Appearance.OddRow.BackColor = CType(resources.GetObject("GVGTPGESTSIT.Appearance.OddRow.BackColor"), System.Drawing.Color)
        Me.GVGTPGESTSIT.Appearance.OddRow.BorderColor = CType(resources.GetObject("GVGTPGESTSIT.Appearance.OddRow.BorderColor"), System.Drawing.Color)
        Me.GVGTPGESTSIT.Appearance.OddRow.ForeColor = CType(resources.GetObject("GVGTPGESTSIT.Appearance.OddRow.ForeColor"), System.Drawing.Color)
        Me.GVGTPGESTSIT.Appearance.OddRow.Options.UseBackColor = True
        Me.GVGTPGESTSIT.Appearance.OddRow.Options.UseBorderColor = True
        Me.GVGTPGESTSIT.Appearance.OddRow.Options.UseForeColor = True
        Me.GVGTPGESTSIT.Appearance.Preview.BackColor = CType(resources.GetObject("GVGTPGESTSIT.Appearance.Preview.BackColor"), System.Drawing.Color)
        Me.GVGTPGESTSIT.Appearance.Preview.Font = CType(resources.GetObject("GVGTPGESTSIT.Appearance.Preview.Font"), System.Drawing.Font)
        Me.GVGTPGESTSIT.Appearance.Preview.ForeColor = CType(resources.GetObject("GVGTPGESTSIT.Appearance.Preview.ForeColor"), System.Drawing.Color)
        Me.GVGTPGESTSIT.Appearance.Preview.Options.UseBackColor = True
        Me.GVGTPGESTSIT.Appearance.Preview.Options.UseFont = True
        Me.GVGTPGESTSIT.Appearance.Preview.Options.UseForeColor = True
        Me.GVGTPGESTSIT.Appearance.Row.BackColor = CType(resources.GetObject("GVGTPGESTSIT.Appearance.Row.BackColor"), System.Drawing.Color)
        Me.GVGTPGESTSIT.Appearance.Row.ForeColor = CType(resources.GetObject("GVGTPGESTSIT.Appearance.Row.ForeColor"), System.Drawing.Color)
        Me.GVGTPGESTSIT.Appearance.Row.Options.UseBackColor = True
        Me.GVGTPGESTSIT.Appearance.Row.Options.UseForeColor = True
        Me.GVGTPGESTSIT.Appearance.RowSeparator.BackColor = CType(resources.GetObject("GVGTPGESTSIT.Appearance.RowSeparator.BackColor"), System.Drawing.Color)
        Me.GVGTPGESTSIT.Appearance.RowSeparator.BackColor2 = CType(resources.GetObject("GVGTPGESTSIT.Appearance.RowSeparator.BackColor2"), System.Drawing.Color)
        Me.GVGTPGESTSIT.Appearance.RowSeparator.Options.UseBackColor = True
        Me.GVGTPGESTSIT.Appearance.SelectedRow.BackColor = CType(resources.GetObject("GVGTPGESTSIT.Appearance.SelectedRow.BackColor"), System.Drawing.Color)
        Me.GVGTPGESTSIT.Appearance.SelectedRow.BorderColor = CType(resources.GetObject("GVGTPGESTSIT.Appearance.SelectedRow.BorderColor"), System.Drawing.Color)
        Me.GVGTPGESTSIT.Appearance.SelectedRow.ForeColor = CType(resources.GetObject("GVGTPGESTSIT.Appearance.SelectedRow.ForeColor"), System.Drawing.Color)
        Me.GVGTPGESTSIT.Appearance.SelectedRow.Options.UseBackColor = True
        Me.GVGTPGESTSIT.Appearance.SelectedRow.Options.UseBorderColor = True
        Me.GVGTPGESTSIT.Appearance.SelectedRow.Options.UseForeColor = True
        Me.GVGTPGESTSIT.Appearance.TopNewRow.BackColor = CType(resources.GetObject("GVGTPGESTSIT.Appearance.TopNewRow.BackColor"), System.Drawing.Color)
        Me.GVGTPGESTSIT.Appearance.TopNewRow.Options.UseBackColor = True
        Me.GVGTPGESTSIT.Appearance.VertLine.BackColor = CType(resources.GetObject("GVGTPGESTSIT.Appearance.VertLine.BackColor"), System.Drawing.Color)
        Me.GVGTPGESTSIT.Appearance.VertLine.Options.UseBackColor = True
        Me.GVGTPGESTSIT.ColumnPanelRowHeight = 60
        Me.GVGTPGESTSIT.Columns.AddRange(New DevExpress.XtraGrid.Columns.GridColumn() {Me.ColIDTMP, Me.ColNCLINUM, Me.ColNSITNUM, Me.ColVCLINOM, Me.ColVSITNOM})
        Me.GVGTPGESTSIT.GridControl = Me.GCGTPGESTSIT
        Me.GVGTPGESTSIT.Name = "GVGTPGESTSIT"
        Me.GVGTPGESTSIT.OptionsBehavior.Editable = False
        Me.GVGTPGESTSIT.OptionsBehavior.ReadOnly = True
        Me.GVGTPGESTSIT.OptionsNavigation.AutoFocusNewRow = True
        Me.GVGTPGESTSIT.OptionsView.EnableAppearanceEvenRow = True
        Me.GVGTPGESTSIT.OptionsView.EnableAppearanceOddRow = True
        Me.GVGTPGESTSIT.OptionsView.ShowAutoFilterRow = True
        Me.GVGTPGESTSIT.OptionsView.ShowFooter = True
        Me.GVGTPGESTSIT.OptionsView.ShowGroupPanel = False
        Me.GVGTPGESTSIT.RowHeight = 20
        '
        'ColIDTMP
        '
        resources.ApplyResources(Me.ColIDTMP, "ColIDTMP")
        Me.ColIDTMP.FieldName = "IDTMP"
        Me.ColIDTMP.Name = "ColIDTMP"
        '
        'ColNCLINUM
        '
        resources.ApplyResources(Me.ColNCLINUM, "ColNCLINUM")
        Me.ColNCLINUM.FieldName = "NCLINUM"
        Me.ColNCLINUM.Name = "ColNCLINUM"
        '
        'ColNSITNUM
        '
        resources.ApplyResources(Me.ColNSITNUM, "ColNSITNUM")
        Me.ColNSITNUM.Name = "ColNSITNUM"
        '
        'ColVCLINOM
        '
        resources.ApplyResources(Me.ColVCLINOM, "ColVCLINOM")
        Me.ColVCLINOM.FieldName = "VCLINOM"
        Me.ColVCLINOM.Name = "ColVCLINOM"
        '
        'ColVSITNOM
        '
        resources.ApplyResources(Me.ColVSITNOM, "ColVSITNOM")
        Me.ColVSITNOM.FieldName = "VSITNOM"
        Me.ColVSITNOM.Name = "ColVSITNOM"
        '
        'BtnModifier
        '
        Me.BtnModifier.BackColor = System.Drawing.Color.LightGreen
        resources.ApplyResources(Me.BtnModifier, "BtnModifier")
        Me.BtnModifier.Name = "BtnModifier"
        Me.BtnModifier.UseVisualStyleBackColor = False
        '
        'BtnSupprLine
        '
        Me.BtnSupprLine.BackColor = System.Drawing.Color.LightGreen
        resources.ApplyResources(Me.BtnSupprLine, "BtnSupprLine")
        Me.BtnSupprLine.Name = "BtnSupprLine"
        Me.BtnSupprLine.UseVisualStyleBackColor = False
        '
        'BtnAddLine
        '
        Me.BtnAddLine.BackColor = System.Drawing.Color.LightGreen
        resources.ApplyResources(Me.BtnAddLine, "BtnAddLine")
        Me.BtnAddLine.Name = "BtnAddLine"
        Me.BtnAddLine.UseVisualStyleBackColor = False
        '
        'GrpActions
        '
        Me.GrpActions.Controls.Add(Me.BtnAudit)
        Me.GrpActions.Controls.Add(Me.BtnModifier)
        Me.GrpActions.Controls.Add(Me.BtnSupprLine)
        Me.GrpActions.Controls.Add(Me.BtnAddLine)
        Me.GrpActions.Controls.Add(Me.BtnQuit)
        Me.GrpActions.Controls.Add(Me.BtnSave)
        resources.ApplyResources(Me.GrpActions, "GrpActions")
        Me.GrpActions.Name = "GrpActions"
        Me.GrpActions.TabStop = False
        '
        'BtnAudit
        '
        Me.BtnAudit.BackColor = System.Drawing.Color.LightBlue
        resources.ApplyResources(Me.BtnAudit, "BtnAudit")
        Me.BtnAudit.Name = "BtnAudit"
        Me.BtnAudit.UseVisualStyleBackColor = False
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
        'Label1
        '
        resources.ApplyResources(Me.Label1, "Label1")
        Me.Label1.Name = "Label1"
        '
        'frmGTPGestSite
        '
        resources.ApplyResources(Me, "$this")
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.Wheat
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.GCGTPGESTSIT)
        Me.Controls.Add(Me.GrpActions)
        Me.Name = "frmGTPGestSite"
        Me.WindowState = System.Windows.Forms.FormWindowState.Maximized
        CType(Me.GCGTPGESTSIT, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.GVGTPGESTSIT, System.ComponentModel.ISupportInitialize).EndInit()
        Me.GrpActions.ResumeLayout(False)
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents BtnModifier As System.Windows.Forms.Button
    Friend WithEvents BtnSupprLine As System.Windows.Forms.Button
    Friend WithEvents BtnAddLine As System.Windows.Forms.Button
    Friend WithEvents GrpActions As System.Windows.Forms.GroupBox
    Friend WithEvents BtnQuit As System.Windows.Forms.Button
    Friend WithEvents BtnSave As System.Windows.Forms.Button
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents BtnAudit As System.Windows.Forms.Button
    Private WithEvents GCGTPGESTSIT As DevExpress.XtraGrid.GridControl
    Private WithEvents GVGTPGESTSIT As DevExpress.XtraGrid.Views.Grid.GridView
    Private WithEvents ColIDTMP As DevExpress.XtraGrid.Columns.GridColumn
    Private WithEvents ColNCLINUM As DevExpress.XtraGrid.Columns.GridColumn
    Private WithEvents ColVCLINOM As DevExpress.XtraGrid.Columns.GridColumn
    Private WithEvents ColNSITNUM As DevExpress.XtraGrid.Columns.GridColumn
    Private WithEvents ColVSITNOM As DevExpress.XtraGrid.Columns.GridColumn
End Class
