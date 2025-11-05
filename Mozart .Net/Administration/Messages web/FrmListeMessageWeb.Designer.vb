<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class FrmListeMessageWeb
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(FrmListeMessageWeb))
        Me.GrpActions = New System.Windows.Forms.GroupBox()
        Me.BtnSupprimer = New System.Windows.Forms.Button()
        Me.BtnFermer = New System.Windows.Forms.Button()
        Me.BtnModif = New System.Windows.Forms.Button()
        Me.GColNum = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.GVlisteFouEI = New DevExpress.XtraGrid.Views.Grid.GridView()
        Me.GColDate = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.GColCli = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.GColLangue = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.GColLib = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.GCListeFouEI = New DevExpress.XtraGrid.GridControl()
        Me.GrpListe = New System.Windows.Forms.GroupBox()
        Me.OFD = New System.Windows.Forms.OpenFileDialog()
        Me.Label6 = New System.Windows.Forms.Label()
        Me.GLU_SOCIETE = New DevExpress.XtraEditors.GridLookUpEdit()
        Me.GridLookUpEdit1View = New DevExpress.XtraGrid.Views.Grid.GridView()
        Me.GridColumn1 = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.GrpActions.SuspendLayout()
        CType(Me.GVlisteFouEI, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.GCListeFouEI, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.GrpListe.SuspendLayout()
        CType(Me.GLU_SOCIETE.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.GridLookUpEdit1View, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'GrpActions
        '
        Me.GrpActions.Controls.Add(Me.BtnSupprimer)
        Me.GrpActions.Controls.Add(Me.BtnFermer)
        Me.GrpActions.Controls.Add(Me.BtnModif)
        resources.ApplyResources(Me.GrpActions, "GrpActions")
        Me.GrpActions.Name = "GrpActions"
        Me.GrpActions.TabStop = False
        '
        'BtnSupprimer
        '
        resources.ApplyResources(Me.BtnSupprimer, "BtnSupprimer")
        Me.BtnSupprimer.Name = "BtnSupprimer"
        Me.BtnSupprimer.UseVisualStyleBackColor = True
        '
        'BtnFermer
        '
        resources.ApplyResources(Me.BtnFermer, "BtnFermer")
        Me.BtnFermer.Name = "BtnFermer"
        Me.BtnFermer.UseVisualStyleBackColor = True
        '
        'BtnModif
        '
        resources.ApplyResources(Me.BtnModif, "BtnModif")
        Me.BtnModif.Name = "BtnModif"
        Me.BtnModif.UseVisualStyleBackColor = True
        '
        'GColNum
        '
        resources.ApplyResources(Me.GColNum, "GColNum")
        Me.GColNum.FieldName = "NWEBNUM"
        Me.GColNum.Name = "GColNum"
        Me.GColNum.OptionsColumn.AllowEdit = False
        Me.GColNum.OptionsColumn.ReadOnly = True
        Me.GColNum.OptionsFilter.AutoFilterCondition = DevExpress.XtraGrid.Columns.AutoFilterCondition.Contains
        '
        'GVlisteFouEI
        '
        Me.GVlisteFouEI.Appearance.ColumnFilterButton.BackColor = CType(resources.GetObject("GVlisteFouEI.Appearance.ColumnFilterButton.BackColor"), System.Drawing.Color)
        Me.GVlisteFouEI.Appearance.ColumnFilterButton.BorderColor = CType(resources.GetObject("GVlisteFouEI.Appearance.ColumnFilterButton.BorderColor"), System.Drawing.Color)
        Me.GVlisteFouEI.Appearance.ColumnFilterButton.ForeColor = CType(resources.GetObject("GVlisteFouEI.Appearance.ColumnFilterButton.ForeColor"), System.Drawing.Color)
        Me.GVlisteFouEI.Appearance.ColumnFilterButton.Options.UseBackColor = True
        Me.GVlisteFouEI.Appearance.ColumnFilterButton.Options.UseBorderColor = True
        Me.GVlisteFouEI.Appearance.ColumnFilterButton.Options.UseForeColor = True
        Me.GVlisteFouEI.Appearance.ColumnFilterButtonActive.BackColor = CType(resources.GetObject("GVlisteFouEI.Appearance.ColumnFilterButtonActive.BackColor"), System.Drawing.Color)
        Me.GVlisteFouEI.Appearance.ColumnFilterButtonActive.BorderColor = CType(resources.GetObject("GVlisteFouEI.Appearance.ColumnFilterButtonActive.BorderColor"), System.Drawing.Color)
        Me.GVlisteFouEI.Appearance.ColumnFilterButtonActive.ForeColor = CType(resources.GetObject("GVlisteFouEI.Appearance.ColumnFilterButtonActive.ForeColor"), System.Drawing.Color)
        Me.GVlisteFouEI.Appearance.ColumnFilterButtonActive.Options.UseBackColor = True
        Me.GVlisteFouEI.Appearance.ColumnFilterButtonActive.Options.UseBorderColor = True
        Me.GVlisteFouEI.Appearance.ColumnFilterButtonActive.Options.UseForeColor = True
        Me.GVlisteFouEI.Appearance.Empty.BackColor = CType(resources.GetObject("GVlisteFouEI.Appearance.Empty.BackColor"), System.Drawing.Color)
        Me.GVlisteFouEI.Appearance.Empty.BackColor2 = CType(resources.GetObject("GVlisteFouEI.Appearance.Empty.BackColor2"), System.Drawing.Color)
        Me.GVlisteFouEI.Appearance.Empty.Options.UseBackColor = True
        Me.GVlisteFouEI.Appearance.EvenRow.BackColor = CType(resources.GetObject("GVlisteFouEI.Appearance.EvenRow.BackColor"), System.Drawing.Color)
        Me.GVlisteFouEI.Appearance.EvenRow.BorderColor = CType(resources.GetObject("GVlisteFouEI.Appearance.EvenRow.BorderColor"), System.Drawing.Color)
        Me.GVlisteFouEI.Appearance.EvenRow.ForeColor = CType(resources.GetObject("GVlisteFouEI.Appearance.EvenRow.ForeColor"), System.Drawing.Color)
        Me.GVlisteFouEI.Appearance.EvenRow.Options.UseBackColor = True
        Me.GVlisteFouEI.Appearance.EvenRow.Options.UseBorderColor = True
        Me.GVlisteFouEI.Appearance.EvenRow.Options.UseForeColor = True
        Me.GVlisteFouEI.Appearance.FilterCloseButton.BackColor = CType(resources.GetObject("GVlisteFouEI.Appearance.FilterCloseButton.BackColor"), System.Drawing.Color)
        Me.GVlisteFouEI.Appearance.FilterCloseButton.BorderColor = CType(resources.GetObject("GVlisteFouEI.Appearance.FilterCloseButton.BorderColor"), System.Drawing.Color)
        Me.GVlisteFouEI.Appearance.FilterCloseButton.ForeColor = CType(resources.GetObject("GVlisteFouEI.Appearance.FilterCloseButton.ForeColor"), System.Drawing.Color)
        Me.GVlisteFouEI.Appearance.FilterCloseButton.Options.UseBackColor = True
        Me.GVlisteFouEI.Appearance.FilterCloseButton.Options.UseBorderColor = True
        Me.GVlisteFouEI.Appearance.FilterCloseButton.Options.UseForeColor = True
        Me.GVlisteFouEI.Appearance.FilterPanel.BackColor = CType(resources.GetObject("GVlisteFouEI.Appearance.FilterPanel.BackColor"), System.Drawing.Color)
        Me.GVlisteFouEI.Appearance.FilterPanel.BackColor2 = CType(resources.GetObject("GVlisteFouEI.Appearance.FilterPanel.BackColor2"), System.Drawing.Color)
        Me.GVlisteFouEI.Appearance.FilterPanel.ForeColor = CType(resources.GetObject("GVlisteFouEI.Appearance.FilterPanel.ForeColor"), System.Drawing.Color)
        Me.GVlisteFouEI.Appearance.FilterPanel.Options.UseBackColor = True
        Me.GVlisteFouEI.Appearance.FilterPanel.Options.UseForeColor = True
        Me.GVlisteFouEI.Appearance.FixedLine.BackColor = CType(resources.GetObject("GVlisteFouEI.Appearance.FixedLine.BackColor"), System.Drawing.Color)
        Me.GVlisteFouEI.Appearance.FixedLine.Options.UseBackColor = True
        Me.GVlisteFouEI.Appearance.FocusedCell.BackColor = CType(resources.GetObject("GVlisteFouEI.Appearance.FocusedCell.BackColor"), System.Drawing.Color)
        Me.GVlisteFouEI.Appearance.FocusedCell.ForeColor = CType(resources.GetObject("GVlisteFouEI.Appearance.FocusedCell.ForeColor"), System.Drawing.Color)
        Me.GVlisteFouEI.Appearance.FocusedCell.Options.UseBackColor = True
        Me.GVlisteFouEI.Appearance.FocusedCell.Options.UseForeColor = True
        Me.GVlisteFouEI.Appearance.FocusedRow.BackColor = CType(resources.GetObject("GVlisteFouEI.Appearance.FocusedRow.BackColor"), System.Drawing.Color)
        Me.GVlisteFouEI.Appearance.FocusedRow.BorderColor = CType(resources.GetObject("GVlisteFouEI.Appearance.FocusedRow.BorderColor"), System.Drawing.Color)
        Me.GVlisteFouEI.Appearance.FocusedRow.ForeColor = CType(resources.GetObject("GVlisteFouEI.Appearance.FocusedRow.ForeColor"), System.Drawing.Color)
        Me.GVlisteFouEI.Appearance.FocusedRow.Options.UseBackColor = True
        Me.GVlisteFouEI.Appearance.FocusedRow.Options.UseBorderColor = True
        Me.GVlisteFouEI.Appearance.FocusedRow.Options.UseForeColor = True
        Me.GVlisteFouEI.Appearance.FooterPanel.BackColor = CType(resources.GetObject("GVlisteFouEI.Appearance.FooterPanel.BackColor"), System.Drawing.Color)
        Me.GVlisteFouEI.Appearance.FooterPanel.BorderColor = CType(resources.GetObject("GVlisteFouEI.Appearance.FooterPanel.BorderColor"), System.Drawing.Color)
        Me.GVlisteFouEI.Appearance.FooterPanel.ForeColor = CType(resources.GetObject("GVlisteFouEI.Appearance.FooterPanel.ForeColor"), System.Drawing.Color)
        Me.GVlisteFouEI.Appearance.FooterPanel.Options.UseBackColor = True
        Me.GVlisteFouEI.Appearance.FooterPanel.Options.UseBorderColor = True
        Me.GVlisteFouEI.Appearance.FooterPanel.Options.UseForeColor = True
        Me.GVlisteFouEI.Appearance.GroupButton.BackColor = CType(resources.GetObject("GVlisteFouEI.Appearance.GroupButton.BackColor"), System.Drawing.Color)
        Me.GVlisteFouEI.Appearance.GroupButton.BorderColor = CType(resources.GetObject("GVlisteFouEI.Appearance.GroupButton.BorderColor"), System.Drawing.Color)
        Me.GVlisteFouEI.Appearance.GroupButton.Options.UseBackColor = True
        Me.GVlisteFouEI.Appearance.GroupButton.Options.UseBorderColor = True
        Me.GVlisteFouEI.Appearance.GroupFooter.BackColor = CType(resources.GetObject("GVlisteFouEI.Appearance.GroupFooter.BackColor"), System.Drawing.Color)
        Me.GVlisteFouEI.Appearance.GroupFooter.BorderColor = CType(resources.GetObject("GVlisteFouEI.Appearance.GroupFooter.BorderColor"), System.Drawing.Color)
        Me.GVlisteFouEI.Appearance.GroupFooter.ForeColor = CType(resources.GetObject("GVlisteFouEI.Appearance.GroupFooter.ForeColor"), System.Drawing.Color)
        Me.GVlisteFouEI.Appearance.GroupFooter.Options.UseBackColor = True
        Me.GVlisteFouEI.Appearance.GroupFooter.Options.UseBorderColor = True
        Me.GVlisteFouEI.Appearance.GroupFooter.Options.UseForeColor = True
        Me.GVlisteFouEI.Appearance.GroupPanel.BackColor = CType(resources.GetObject("GVlisteFouEI.Appearance.GroupPanel.BackColor"), System.Drawing.Color)
        Me.GVlisteFouEI.Appearance.GroupPanel.BackColor2 = CType(resources.GetObject("GVlisteFouEI.Appearance.GroupPanel.BackColor2"), System.Drawing.Color)
        Me.GVlisteFouEI.Appearance.GroupPanel.ForeColor = CType(resources.GetObject("GVlisteFouEI.Appearance.GroupPanel.ForeColor"), System.Drawing.Color)
        Me.GVlisteFouEI.Appearance.GroupPanel.Options.UseBackColor = True
        Me.GVlisteFouEI.Appearance.GroupPanel.Options.UseForeColor = True
        Me.GVlisteFouEI.Appearance.GroupRow.BackColor = CType(resources.GetObject("GVlisteFouEI.Appearance.GroupRow.BackColor"), System.Drawing.Color)
        Me.GVlisteFouEI.Appearance.GroupRow.BorderColor = CType(resources.GetObject("GVlisteFouEI.Appearance.GroupRow.BorderColor"), System.Drawing.Color)
        Me.GVlisteFouEI.Appearance.GroupRow.ForeColor = CType(resources.GetObject("GVlisteFouEI.Appearance.GroupRow.ForeColor"), System.Drawing.Color)
        Me.GVlisteFouEI.Appearance.GroupRow.Options.UseBackColor = True
        Me.GVlisteFouEI.Appearance.GroupRow.Options.UseBorderColor = True
        Me.GVlisteFouEI.Appearance.GroupRow.Options.UseForeColor = True
        Me.GVlisteFouEI.Appearance.HeaderPanel.BackColor = CType(resources.GetObject("GVlisteFouEI.Appearance.HeaderPanel.BackColor"), System.Drawing.Color)
        Me.GVlisteFouEI.Appearance.HeaderPanel.BorderColor = CType(resources.GetObject("GVlisteFouEI.Appearance.HeaderPanel.BorderColor"), System.Drawing.Color)
        Me.GVlisteFouEI.Appearance.HeaderPanel.ForeColor = CType(resources.GetObject("GVlisteFouEI.Appearance.HeaderPanel.ForeColor"), System.Drawing.Color)
        Me.GVlisteFouEI.Appearance.HeaderPanel.Options.UseBackColor = True
        Me.GVlisteFouEI.Appearance.HeaderPanel.Options.UseBorderColor = True
        Me.GVlisteFouEI.Appearance.HeaderPanel.Options.UseForeColor = True
        Me.GVlisteFouEI.Appearance.HideSelectionRow.BackColor = CType(resources.GetObject("GVlisteFouEI.Appearance.HideSelectionRow.BackColor"), System.Drawing.Color)
        Me.GVlisteFouEI.Appearance.HideSelectionRow.BorderColor = CType(resources.GetObject("GVlisteFouEI.Appearance.HideSelectionRow.BorderColor"), System.Drawing.Color)
        Me.GVlisteFouEI.Appearance.HideSelectionRow.ForeColor = CType(resources.GetObject("GVlisteFouEI.Appearance.HideSelectionRow.ForeColor"), System.Drawing.Color)
        Me.GVlisteFouEI.Appearance.HideSelectionRow.Options.UseBackColor = True
        Me.GVlisteFouEI.Appearance.HideSelectionRow.Options.UseBorderColor = True
        Me.GVlisteFouEI.Appearance.HideSelectionRow.Options.UseForeColor = True
        Me.GVlisteFouEI.Appearance.HorzLine.BackColor = CType(resources.GetObject("GVlisteFouEI.Appearance.HorzLine.BackColor"), System.Drawing.Color)
        Me.GVlisteFouEI.Appearance.HorzLine.Options.UseBackColor = True
        Me.GVlisteFouEI.Appearance.OddRow.BackColor = CType(resources.GetObject("GVlisteFouEI.Appearance.OddRow.BackColor"), System.Drawing.Color)
        Me.GVlisteFouEI.Appearance.OddRow.BorderColor = CType(resources.GetObject("GVlisteFouEI.Appearance.OddRow.BorderColor"), System.Drawing.Color)
        Me.GVlisteFouEI.Appearance.OddRow.ForeColor = CType(resources.GetObject("GVlisteFouEI.Appearance.OddRow.ForeColor"), System.Drawing.Color)
        Me.GVlisteFouEI.Appearance.OddRow.Options.UseBackColor = True
        Me.GVlisteFouEI.Appearance.OddRow.Options.UseBorderColor = True
        Me.GVlisteFouEI.Appearance.OddRow.Options.UseForeColor = True
        Me.GVlisteFouEI.Appearance.Preview.Font = CType(resources.GetObject("GVlisteFouEI.Appearance.Preview.Font"), System.Drawing.Font)
        Me.GVlisteFouEI.Appearance.Preview.ForeColor = CType(resources.GetObject("GVlisteFouEI.Appearance.Preview.ForeColor"), System.Drawing.Color)
        Me.GVlisteFouEI.Appearance.Preview.Options.UseFont = True
        Me.GVlisteFouEI.Appearance.Preview.Options.UseForeColor = True
        Me.GVlisteFouEI.Appearance.Row.BackColor = CType(resources.GetObject("GVlisteFouEI.Appearance.Row.BackColor"), System.Drawing.Color)
        Me.GVlisteFouEI.Appearance.Row.ForeColor = CType(resources.GetObject("GVlisteFouEI.Appearance.Row.ForeColor"), System.Drawing.Color)
        Me.GVlisteFouEI.Appearance.Row.Options.UseBackColor = True
        Me.GVlisteFouEI.Appearance.Row.Options.UseForeColor = True
        Me.GVlisteFouEI.Appearance.RowSeparator.BackColor = CType(resources.GetObject("GVlisteFouEI.Appearance.RowSeparator.BackColor"), System.Drawing.Color)
        Me.GVlisteFouEI.Appearance.RowSeparator.BackColor2 = CType(resources.GetObject("GVlisteFouEI.Appearance.RowSeparator.BackColor2"), System.Drawing.Color)
        Me.GVlisteFouEI.Appearance.RowSeparator.Options.UseBackColor = True
        Me.GVlisteFouEI.Appearance.SelectedRow.BackColor = CType(resources.GetObject("GVlisteFouEI.Appearance.SelectedRow.BackColor"), System.Drawing.Color)
        Me.GVlisteFouEI.Appearance.SelectedRow.ForeColor = CType(resources.GetObject("GVlisteFouEI.Appearance.SelectedRow.ForeColor"), System.Drawing.Color)
        Me.GVlisteFouEI.Appearance.SelectedRow.Options.UseBackColor = True
        Me.GVlisteFouEI.Appearance.SelectedRow.Options.UseForeColor = True
        Me.GVlisteFouEI.Appearance.TopNewRow.BackColor = CType(resources.GetObject("GVlisteFouEI.Appearance.TopNewRow.BackColor"), System.Drawing.Color)
        Me.GVlisteFouEI.Appearance.TopNewRow.Options.UseBackColor = True
        Me.GVlisteFouEI.Appearance.VertLine.BackColor = CType(resources.GetObject("GVlisteFouEI.Appearance.VertLine.BackColor"), System.Drawing.Color)
        Me.GVlisteFouEI.Appearance.VertLine.Options.UseBackColor = True
        Me.GVlisteFouEI.Columns.AddRange(New DevExpress.XtraGrid.Columns.GridColumn() {Me.GColNum, Me.GColDate, Me.GColCli, Me.GColLangue, Me.GColLib})
        Me.GVlisteFouEI.GridControl = Me.GCListeFouEI
        Me.GVlisteFouEI.Name = "GVlisteFouEI"
        Me.GVlisteFouEI.OptionsBehavior.Editable = False
        Me.GVlisteFouEI.OptionsBehavior.ReadOnly = True
        Me.GVlisteFouEI.OptionsView.EnableAppearanceEvenRow = True
        Me.GVlisteFouEI.OptionsView.EnableAppearanceOddRow = True
        Me.GVlisteFouEI.OptionsView.ShowAutoFilterRow = True
        Me.GVlisteFouEI.OptionsView.ShowGroupPanel = False
        '
        'GColDate
        '
        resources.ApplyResources(Me.GColDate, "GColDate")
        Me.GColDate.FieldName = "DWEBDAT"
        Me.GColDate.Name = "GColDate"
        Me.GColDate.OptionsFilter.AutoFilterCondition = DevExpress.XtraGrid.Columns.AutoFilterCondition.Contains
        '
        'GColCli
        '
        resources.ApplyResources(Me.GColCli, "GColCli")
        Me.GColCli.FieldName = "VCLINOM"
        Me.GColCli.Name = "GColCli"
        '
        'GColLangue
        '
        resources.ApplyResources(Me.GColLangue, "GColLangue")
        Me.GColLangue.FieldName = "LANGUE"
        Me.GColLangue.Name = "GColLangue"
        '
        'GColLib
        '
        resources.ApplyResources(Me.GColLib, "GColLib")
        Me.GColLib.FieldName = "VLIBINFO"
        Me.GColLib.Name = "GColLib"
        Me.GColLib.OptionsFilter.AutoFilterCondition = DevExpress.XtraGrid.Columns.AutoFilterCondition.Contains
        '
        'GCListeFouEI
        '
        resources.ApplyResources(Me.GCListeFouEI, "GCListeFouEI")
        Me.GCListeFouEI.MainView = Me.GVlisteFouEI
        Me.GCListeFouEI.Name = "GCListeFouEI"
        Me.GCListeFouEI.ViewCollection.AddRange(New DevExpress.XtraGrid.Views.Base.BaseView() {Me.GVlisteFouEI})
        '
        'GrpListe
        '
        Me.GrpListe.Controls.Add(Me.GCListeFouEI)
        resources.ApplyResources(Me.GrpListe, "GrpListe")
        Me.GrpListe.Name = "GrpListe"
        Me.GrpListe.TabStop = False
        '
        'Label6
        '
        resources.ApplyResources(Me.Label6, "Label6")
        Me.Label6.Name = "Label6"
        '
        'GLU_SOCIETE
        '
        resources.ApplyResources(Me.GLU_SOCIETE, "GLU_SOCIETE")
        Me.GLU_SOCIETE.Name = "GLU_SOCIETE"
        Me.GLU_SOCIETE.Properties.Buttons.AddRange(New DevExpress.XtraEditors.Controls.EditorButton() {New DevExpress.XtraEditors.Controls.EditorButton(CType(resources.GetObject("GridLookUpEdit1.Properties.Buttons"), DevExpress.XtraEditors.Controls.ButtonPredefines))})
        Me.GLU_SOCIETE.Properties.DisplayMember = "VSOCIETE"
        Me.GLU_SOCIETE.Properties.NullText = resources.GetString("GridLookUpEdit1.Properties.NullText")
        Me.GLU_SOCIETE.Properties.ValueMember = "VSOCIETE"
        Me.GLU_SOCIETE.Properties.View = Me.GridLookUpEdit1View
        Me.GLU_SOCIETE.Tag = "406"
        '
        'GridLookUpEdit1View
        '
        Me.GridLookUpEdit1View.Columns.AddRange(New DevExpress.XtraGrid.Columns.GridColumn() {Me.GridColumn1})
        Me.GridLookUpEdit1View.FocusRectStyle = DevExpress.XtraGrid.Views.Grid.DrawFocusRectStyle.RowFocus
        Me.GridLookUpEdit1View.Name = "GridLookUpEdit1View"
        Me.GridLookUpEdit1View.OptionsSelection.EnableAppearanceFocusedCell = False
        Me.GridLookUpEdit1View.OptionsView.ShowGroupPanel = False
        '
        'GridColumn1
        '
        resources.ApplyResources(Me.GridColumn1, "GridColumn1")
        Me.GridColumn1.FieldName = "VSOCIETE"
        Me.GridColumn1.Name = "GridColumn1"
        Me.GridColumn1.OptionsColumn.AllowEdit = False
        Me.GridColumn1.OptionsColumn.ReadOnly = True
        Me.GridColumn1.OptionsFilter.AutoFilterCondition = DevExpress.XtraGrid.Columns.AutoFilterCondition.Contains
        '
        'FrmListeMessageWeb
        '
        resources.ApplyResources(Me, "$this")
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.Wheat
        Me.Controls.Add(Me.GLU_SOCIETE)
        Me.Controls.Add(Me.Label6)
        Me.Controls.Add(Me.GrpActions)
        Me.Controls.Add(Me.GrpListe)
        Me.Name = "FrmListeMessageWeb"
        Me.WindowState = System.Windows.Forms.FormWindowState.Maximized
        Me.GrpActions.ResumeLayout(False)
        CType(Me.GVlisteFouEI, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.GCListeFouEI, System.ComponentModel.ISupportInitialize).EndInit()
        Me.GrpListe.ResumeLayout(False)
        CType(Me.GLU_SOCIETE.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.GridLookUpEdit1View, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents GrpActions As System.Windows.Forms.GroupBox
    Friend WithEvents BtnFermer As System.Windows.Forms.Button
    Friend WithEvents BtnModif As System.Windows.Forms.Button
    Friend WithEvents GrpListe As System.Windows.Forms.GroupBox
    Friend WithEvents OFD As System.Windows.Forms.OpenFileDialog
    Friend WithEvents BtnSupprimer As System.Windows.Forms.Button
    Private WithEvents GColNum As DevExpress.XtraGrid.Columns.GridColumn
    Private WithEvents GVlisteFouEI As DevExpress.XtraGrid.Views.Grid.GridView
    Private WithEvents GCListeFouEI As DevExpress.XtraGrid.GridControl
    Private WithEvents GColLib As DevExpress.XtraGrid.Columns.GridColumn
    Private WithEvents GColDate As DevExpress.XtraGrid.Columns.GridColumn
    Private WithEvents GColLangue As DevExpress.XtraGrid.Columns.GridColumn
    Private WithEvents GColCli As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents Label6 As Label
    Friend WithEvents GLU_SOCIETE As DevExpress.XtraEditors.GridLookUpEdit
    Friend WithEvents GridLookUpEdit1View As DevExpress.XtraGrid.Views.Grid.GridView
    Friend WithEvents GridColumn1 As DevExpress.XtraGrid.Columns.GridColumn
End Class
