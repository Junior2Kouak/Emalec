<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class FrmListeMessageWebTech
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(FrmListeMessageWebTech))
        Me.GrpActions = New System.Windows.Forms.GroupBox()
        Me.BtnSupprimer = New System.Windows.Forms.Button()
        Me.BtnFermer = New System.Windows.Forms.Button()
        Me.BtnSave = New System.Windows.Forms.Button()
        Me.GColDate = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.GColLib = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.GCListeMess = New DevExpress.XtraGrid.GridControl()
        Me.GVlisteMess = New DevExpress.XtraGrid.Views.Grid.GridView()
        Me.GColTechnicien = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.GColNum = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.GrpListe = New System.Windows.Forms.GroupBox()
        Me.OFD = New System.Windows.Forms.OpenFileDialog()
        Me.GrpActions.SuspendLayout()
        CType(Me.GCListeMess, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.GVlisteMess, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.GrpListe.SuspendLayout()
        Me.SuspendLayout()
        '
        'GrpActions
        '
        resources.ApplyResources(Me.GrpActions, "GrpActions")
        Me.GrpActions.Controls.Add(Me.BtnSupprimer)
        Me.GrpActions.Controls.Add(Me.BtnFermer)
        Me.GrpActions.Controls.Add(Me.BtnSave)
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
        'BtnSave
        '
        resources.ApplyResources(Me.BtnSave, "BtnSave")
        Me.BtnSave.Name = "BtnSave"
        Me.BtnSave.UseVisualStyleBackColor = True
        '
        'GColDate
        '
        Me.GColDate.AppearanceCell.FontSizeDelta = CType(resources.GetObject("GColDate.AppearanceCell.FontSizeDelta"), Integer)
        Me.GColDate.AppearanceCell.FontStyleDelta = CType(resources.GetObject("GColDate.AppearanceCell.FontStyleDelta"), System.Drawing.FontStyle)
        Me.GColDate.AppearanceCell.GradientMode = CType(resources.GetObject("GColDate.AppearanceCell.GradientMode"), System.Drawing.Drawing2D.LinearGradientMode)
        Me.GColDate.AppearanceCell.Image = CType(resources.GetObject("GColDate.AppearanceCell.Image"), System.Drawing.Image)
        Me.GColDate.AppearanceCell.Options.UseTextOptions = True
        Me.GColDate.AppearanceCell.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center
        resources.ApplyResources(Me.GColDate, "GColDate")
        Me.GColDate.FieldName = "DPERDATE"
        Me.GColDate.Name = "GColDate"
        Me.GColDate.OptionsFilter.AutoFilterCondition = DevExpress.XtraGrid.Columns.AutoFilterCondition.Contains
        '
        'GColLib
        '
        resources.ApplyResources(Me.GColLib, "GColLib")
        Me.GColLib.FieldName = "VPERMESSHTML"
        Me.GColLib.Name = "GColLib"
        Me.GColLib.OptionsFilter.AutoFilterCondition = DevExpress.XtraGrid.Columns.AutoFilterCondition.Contains
        '
        'GCListeMess
        '
        resources.ApplyResources(Me.GCListeMess, "GCListeMess")
        '
        '
        '
        Me.GCListeMess.EmbeddedNavigator.AccessibleDescription = resources.GetString("GCListeMess.EmbeddedNavigator.AccessibleDescription")
        Me.GCListeMess.EmbeddedNavigator.AccessibleName = resources.GetString("GCListeMess.EmbeddedNavigator.AccessibleName")
        Me.GCListeMess.EmbeddedNavigator.AllowHtmlTextInToolTip = CType(resources.GetObject("GCListeMess.EmbeddedNavigator.AllowHtmlTextInToolTip"), DevExpress.Utils.DefaultBoolean)
        Me.GCListeMess.EmbeddedNavigator.Anchor = CType(resources.GetObject("GCListeMess.EmbeddedNavigator.Anchor"), System.Windows.Forms.AnchorStyles)
        Me.GCListeMess.EmbeddedNavigator.BackgroundImage = CType(resources.GetObject("GCListeMess.EmbeddedNavigator.BackgroundImage"), System.Drawing.Image)
        Me.GCListeMess.EmbeddedNavigator.BackgroundImageLayout = CType(resources.GetObject("GCListeMess.EmbeddedNavigator.BackgroundImageLayout"), System.Windows.Forms.ImageLayout)
        Me.GCListeMess.EmbeddedNavigator.ImeMode = CType(resources.GetObject("GCListeMess.EmbeddedNavigator.ImeMode"), System.Windows.Forms.ImeMode)
        Me.GCListeMess.EmbeddedNavigator.MaximumSize = CType(resources.GetObject("GCListeMess.EmbeddedNavigator.MaximumSize"), System.Drawing.Size)
        Me.GCListeMess.EmbeddedNavigator.TextLocation = CType(resources.GetObject("GCListeMess.EmbeddedNavigator.TextLocation"), DevExpress.XtraEditors.NavigatorButtonsTextLocation)
        Me.GCListeMess.EmbeddedNavigator.ToolTip = resources.GetString("GCListeMess.EmbeddedNavigator.ToolTip")
        Me.GCListeMess.EmbeddedNavigator.ToolTipIconType = CType(resources.GetObject("GCListeMess.EmbeddedNavigator.ToolTipIconType"), DevExpress.Utils.ToolTipIconType)
        Me.GCListeMess.EmbeddedNavigator.ToolTipTitle = resources.GetString("GCListeMess.EmbeddedNavigator.ToolTipTitle")
        Me.GCListeMess.MainView = Me.GVlisteMess
        Me.GCListeMess.Name = "GCListeMess"
        Me.GCListeMess.ViewCollection.AddRange(New DevExpress.XtraGrid.Views.Base.BaseView() {Me.GVlisteMess})
        '
        'GVlisteMess
        '
        Me.GVlisteMess.Appearance.ColumnFilterButton.BackColor = CType(resources.GetObject("GVlisteMess.Appearance.ColumnFilterButton.BackColor"), System.Drawing.Color)
        Me.GVlisteMess.Appearance.ColumnFilterButton.BorderColor = CType(resources.GetObject("GVlisteMess.Appearance.ColumnFilterButton.BorderColor"), System.Drawing.Color)
        Me.GVlisteMess.Appearance.ColumnFilterButton.FontSizeDelta = CType(resources.GetObject("GVlisteMess.Appearance.ColumnFilterButton.FontSizeDelta"), Integer)
        Me.GVlisteMess.Appearance.ColumnFilterButton.FontStyleDelta = CType(resources.GetObject("GVlisteMess.Appearance.ColumnFilterButton.FontStyleDelta"), System.Drawing.FontStyle)
        Me.GVlisteMess.Appearance.ColumnFilterButton.ForeColor = CType(resources.GetObject("GVlisteMess.Appearance.ColumnFilterButton.ForeColor"), System.Drawing.Color)
        Me.GVlisteMess.Appearance.ColumnFilterButton.GradientMode = CType(resources.GetObject("GVlisteMess.Appearance.ColumnFilterButton.GradientMode"), System.Drawing.Drawing2D.LinearGradientMode)
        Me.GVlisteMess.Appearance.ColumnFilterButton.Image = CType(resources.GetObject("GVlisteMess.Appearance.ColumnFilterButton.Image"), System.Drawing.Image)
        Me.GVlisteMess.Appearance.ColumnFilterButton.Options.UseBackColor = True
        Me.GVlisteMess.Appearance.ColumnFilterButton.Options.UseBorderColor = True
        Me.GVlisteMess.Appearance.ColumnFilterButton.Options.UseForeColor = True
        Me.GVlisteMess.Appearance.ColumnFilterButtonActive.BackColor = CType(resources.GetObject("GVlisteMess.Appearance.ColumnFilterButtonActive.BackColor"), System.Drawing.Color)
        Me.GVlisteMess.Appearance.ColumnFilterButtonActive.BorderColor = CType(resources.GetObject("GVlisteMess.Appearance.ColumnFilterButtonActive.BorderColor"), System.Drawing.Color)
        Me.GVlisteMess.Appearance.ColumnFilterButtonActive.FontSizeDelta = CType(resources.GetObject("GVlisteMess.Appearance.ColumnFilterButtonActive.FontSizeDelta"), Integer)
        Me.GVlisteMess.Appearance.ColumnFilterButtonActive.FontStyleDelta = CType(resources.GetObject("GVlisteMess.Appearance.ColumnFilterButtonActive.FontStyleDelta"), System.Drawing.FontStyle)
        Me.GVlisteMess.Appearance.ColumnFilterButtonActive.ForeColor = CType(resources.GetObject("GVlisteMess.Appearance.ColumnFilterButtonActive.ForeColor"), System.Drawing.Color)
        Me.GVlisteMess.Appearance.ColumnFilterButtonActive.GradientMode = CType(resources.GetObject("GVlisteMess.Appearance.ColumnFilterButtonActive.GradientMode"), System.Drawing.Drawing2D.LinearGradientMode)
        Me.GVlisteMess.Appearance.ColumnFilterButtonActive.Image = CType(resources.GetObject("GVlisteMess.Appearance.ColumnFilterButtonActive.Image"), System.Drawing.Image)
        Me.GVlisteMess.Appearance.ColumnFilterButtonActive.Options.UseBackColor = True
        Me.GVlisteMess.Appearance.ColumnFilterButtonActive.Options.UseBorderColor = True
        Me.GVlisteMess.Appearance.ColumnFilterButtonActive.Options.UseForeColor = True
        Me.GVlisteMess.Appearance.Empty.BackColor = CType(resources.GetObject("GVlisteMess.Appearance.Empty.BackColor"), System.Drawing.Color)
        Me.GVlisteMess.Appearance.Empty.BackColor2 = CType(resources.GetObject("GVlisteMess.Appearance.Empty.BackColor2"), System.Drawing.Color)
        Me.GVlisteMess.Appearance.Empty.FontSizeDelta = CType(resources.GetObject("GVlisteMess.Appearance.Empty.FontSizeDelta"), Integer)
        Me.GVlisteMess.Appearance.Empty.FontStyleDelta = CType(resources.GetObject("GVlisteMess.Appearance.Empty.FontStyleDelta"), System.Drawing.FontStyle)
        Me.GVlisteMess.Appearance.Empty.GradientMode = CType(resources.GetObject("GVlisteMess.Appearance.Empty.GradientMode"), System.Drawing.Drawing2D.LinearGradientMode)
        Me.GVlisteMess.Appearance.Empty.Image = CType(resources.GetObject("GVlisteMess.Appearance.Empty.Image"), System.Drawing.Image)
        Me.GVlisteMess.Appearance.Empty.Options.UseBackColor = True
        Me.GVlisteMess.Appearance.EvenRow.BackColor = CType(resources.GetObject("GVlisteMess.Appearance.EvenRow.BackColor"), System.Drawing.Color)
        Me.GVlisteMess.Appearance.EvenRow.BorderColor = CType(resources.GetObject("GVlisteMess.Appearance.EvenRow.BorderColor"), System.Drawing.Color)
        Me.GVlisteMess.Appearance.EvenRow.FontSizeDelta = CType(resources.GetObject("GVlisteMess.Appearance.EvenRow.FontSizeDelta"), Integer)
        Me.GVlisteMess.Appearance.EvenRow.FontStyleDelta = CType(resources.GetObject("GVlisteMess.Appearance.EvenRow.FontStyleDelta"), System.Drawing.FontStyle)
        Me.GVlisteMess.Appearance.EvenRow.ForeColor = CType(resources.GetObject("GVlisteMess.Appearance.EvenRow.ForeColor"), System.Drawing.Color)
        Me.GVlisteMess.Appearance.EvenRow.GradientMode = CType(resources.GetObject("GVlisteMess.Appearance.EvenRow.GradientMode"), System.Drawing.Drawing2D.LinearGradientMode)
        Me.GVlisteMess.Appearance.EvenRow.Image = CType(resources.GetObject("GVlisteMess.Appearance.EvenRow.Image"), System.Drawing.Image)
        Me.GVlisteMess.Appearance.EvenRow.Options.UseBackColor = True
        Me.GVlisteMess.Appearance.EvenRow.Options.UseBorderColor = True
        Me.GVlisteMess.Appearance.EvenRow.Options.UseForeColor = True
        Me.GVlisteMess.Appearance.FilterCloseButton.BackColor = CType(resources.GetObject("GVlisteMess.Appearance.FilterCloseButton.BackColor"), System.Drawing.Color)
        Me.GVlisteMess.Appearance.FilterCloseButton.BorderColor = CType(resources.GetObject("GVlisteMess.Appearance.FilterCloseButton.BorderColor"), System.Drawing.Color)
        Me.GVlisteMess.Appearance.FilterCloseButton.FontSizeDelta = CType(resources.GetObject("GVlisteMess.Appearance.FilterCloseButton.FontSizeDelta"), Integer)
        Me.GVlisteMess.Appearance.FilterCloseButton.FontStyleDelta = CType(resources.GetObject("GVlisteMess.Appearance.FilterCloseButton.FontStyleDelta"), System.Drawing.FontStyle)
        Me.GVlisteMess.Appearance.FilterCloseButton.ForeColor = CType(resources.GetObject("GVlisteMess.Appearance.FilterCloseButton.ForeColor"), System.Drawing.Color)
        Me.GVlisteMess.Appearance.FilterCloseButton.GradientMode = CType(resources.GetObject("GVlisteMess.Appearance.FilterCloseButton.GradientMode"), System.Drawing.Drawing2D.LinearGradientMode)
        Me.GVlisteMess.Appearance.FilterCloseButton.Image = CType(resources.GetObject("GVlisteMess.Appearance.FilterCloseButton.Image"), System.Drawing.Image)
        Me.GVlisteMess.Appearance.FilterCloseButton.Options.UseBackColor = True
        Me.GVlisteMess.Appearance.FilterCloseButton.Options.UseBorderColor = True
        Me.GVlisteMess.Appearance.FilterCloseButton.Options.UseForeColor = True
        Me.GVlisteMess.Appearance.FilterPanel.BackColor = CType(resources.GetObject("GVlisteMess.Appearance.FilterPanel.BackColor"), System.Drawing.Color)
        Me.GVlisteMess.Appearance.FilterPanel.BackColor2 = CType(resources.GetObject("GVlisteMess.Appearance.FilterPanel.BackColor2"), System.Drawing.Color)
        Me.GVlisteMess.Appearance.FilterPanel.FontSizeDelta = CType(resources.GetObject("GVlisteMess.Appearance.FilterPanel.FontSizeDelta"), Integer)
        Me.GVlisteMess.Appearance.FilterPanel.FontStyleDelta = CType(resources.GetObject("GVlisteMess.Appearance.FilterPanel.FontStyleDelta"), System.Drawing.FontStyle)
        Me.GVlisteMess.Appearance.FilterPanel.ForeColor = CType(resources.GetObject("GVlisteMess.Appearance.FilterPanel.ForeColor"), System.Drawing.Color)
        Me.GVlisteMess.Appearance.FilterPanel.GradientMode = CType(resources.GetObject("GVlisteMess.Appearance.FilterPanel.GradientMode"), System.Drawing.Drawing2D.LinearGradientMode)
        Me.GVlisteMess.Appearance.FilterPanel.Image = CType(resources.GetObject("GVlisteMess.Appearance.FilterPanel.Image"), System.Drawing.Image)
        Me.GVlisteMess.Appearance.FilterPanel.Options.UseBackColor = True
        Me.GVlisteMess.Appearance.FilterPanel.Options.UseForeColor = True
        Me.GVlisteMess.Appearance.FixedLine.BackColor = CType(resources.GetObject("GVlisteMess.Appearance.FixedLine.BackColor"), System.Drawing.Color)
        Me.GVlisteMess.Appearance.FixedLine.FontSizeDelta = CType(resources.GetObject("GVlisteMess.Appearance.FixedLine.FontSizeDelta"), Integer)
        Me.GVlisteMess.Appearance.FixedLine.FontStyleDelta = CType(resources.GetObject("GVlisteMess.Appearance.FixedLine.FontStyleDelta"), System.Drawing.FontStyle)
        Me.GVlisteMess.Appearance.FixedLine.GradientMode = CType(resources.GetObject("GVlisteMess.Appearance.FixedLine.GradientMode"), System.Drawing.Drawing2D.LinearGradientMode)
        Me.GVlisteMess.Appearance.FixedLine.Image = CType(resources.GetObject("GVlisteMess.Appearance.FixedLine.Image"), System.Drawing.Image)
        Me.GVlisteMess.Appearance.FixedLine.Options.UseBackColor = True
        Me.GVlisteMess.Appearance.FocusedCell.BackColor = CType(resources.GetObject("GVlisteMess.Appearance.FocusedCell.BackColor"), System.Drawing.Color)
        Me.GVlisteMess.Appearance.FocusedCell.FontSizeDelta = CType(resources.GetObject("GVlisteMess.Appearance.FocusedCell.FontSizeDelta"), Integer)
        Me.GVlisteMess.Appearance.FocusedCell.FontStyleDelta = CType(resources.GetObject("GVlisteMess.Appearance.FocusedCell.FontStyleDelta"), System.Drawing.FontStyle)
        Me.GVlisteMess.Appearance.FocusedCell.ForeColor = CType(resources.GetObject("GVlisteMess.Appearance.FocusedCell.ForeColor"), System.Drawing.Color)
        Me.GVlisteMess.Appearance.FocusedCell.GradientMode = CType(resources.GetObject("GVlisteMess.Appearance.FocusedCell.GradientMode"), System.Drawing.Drawing2D.LinearGradientMode)
        Me.GVlisteMess.Appearance.FocusedCell.Image = CType(resources.GetObject("GVlisteMess.Appearance.FocusedCell.Image"), System.Drawing.Image)
        Me.GVlisteMess.Appearance.FocusedCell.Options.UseBackColor = True
        Me.GVlisteMess.Appearance.FocusedCell.Options.UseForeColor = True
        Me.GVlisteMess.Appearance.FocusedRow.BackColor = CType(resources.GetObject("GVlisteMess.Appearance.FocusedRow.BackColor"), System.Drawing.Color)
        Me.GVlisteMess.Appearance.FocusedRow.BorderColor = CType(resources.GetObject("GVlisteMess.Appearance.FocusedRow.BorderColor"), System.Drawing.Color)
        Me.GVlisteMess.Appearance.FocusedRow.FontSizeDelta = CType(resources.GetObject("GVlisteMess.Appearance.FocusedRow.FontSizeDelta"), Integer)
        Me.GVlisteMess.Appearance.FocusedRow.FontStyleDelta = CType(resources.GetObject("GVlisteMess.Appearance.FocusedRow.FontStyleDelta"), System.Drawing.FontStyle)
        Me.GVlisteMess.Appearance.FocusedRow.ForeColor = CType(resources.GetObject("GVlisteMess.Appearance.FocusedRow.ForeColor"), System.Drawing.Color)
        Me.GVlisteMess.Appearance.FocusedRow.GradientMode = CType(resources.GetObject("GVlisteMess.Appearance.FocusedRow.GradientMode"), System.Drawing.Drawing2D.LinearGradientMode)
        Me.GVlisteMess.Appearance.FocusedRow.Image = CType(resources.GetObject("GVlisteMess.Appearance.FocusedRow.Image"), System.Drawing.Image)
        Me.GVlisteMess.Appearance.FocusedRow.Options.UseBackColor = True
        Me.GVlisteMess.Appearance.FocusedRow.Options.UseBorderColor = True
        Me.GVlisteMess.Appearance.FocusedRow.Options.UseForeColor = True
        Me.GVlisteMess.Appearance.FooterPanel.BackColor = CType(resources.GetObject("GVlisteMess.Appearance.FooterPanel.BackColor"), System.Drawing.Color)
        Me.GVlisteMess.Appearance.FooterPanel.BorderColor = CType(resources.GetObject("GVlisteMess.Appearance.FooterPanel.BorderColor"), System.Drawing.Color)
        Me.GVlisteMess.Appearance.FooterPanel.FontSizeDelta = CType(resources.GetObject("GVlisteMess.Appearance.FooterPanel.FontSizeDelta"), Integer)
        Me.GVlisteMess.Appearance.FooterPanel.FontStyleDelta = CType(resources.GetObject("GVlisteMess.Appearance.FooterPanel.FontStyleDelta"), System.Drawing.FontStyle)
        Me.GVlisteMess.Appearance.FooterPanel.ForeColor = CType(resources.GetObject("GVlisteMess.Appearance.FooterPanel.ForeColor"), System.Drawing.Color)
        Me.GVlisteMess.Appearance.FooterPanel.GradientMode = CType(resources.GetObject("GVlisteMess.Appearance.FooterPanel.GradientMode"), System.Drawing.Drawing2D.LinearGradientMode)
        Me.GVlisteMess.Appearance.FooterPanel.Image = CType(resources.GetObject("GVlisteMess.Appearance.FooterPanel.Image"), System.Drawing.Image)
        Me.GVlisteMess.Appearance.FooterPanel.Options.UseBackColor = True
        Me.GVlisteMess.Appearance.FooterPanel.Options.UseBorderColor = True
        Me.GVlisteMess.Appearance.FooterPanel.Options.UseForeColor = True
        Me.GVlisteMess.Appearance.GroupButton.BackColor = CType(resources.GetObject("GVlisteMess.Appearance.GroupButton.BackColor"), System.Drawing.Color)
        Me.GVlisteMess.Appearance.GroupButton.BorderColor = CType(resources.GetObject("GVlisteMess.Appearance.GroupButton.BorderColor"), System.Drawing.Color)
        Me.GVlisteMess.Appearance.GroupButton.FontSizeDelta = CType(resources.GetObject("GVlisteMess.Appearance.GroupButton.FontSizeDelta"), Integer)
        Me.GVlisteMess.Appearance.GroupButton.FontStyleDelta = CType(resources.GetObject("GVlisteMess.Appearance.GroupButton.FontStyleDelta"), System.Drawing.FontStyle)
        Me.GVlisteMess.Appearance.GroupButton.GradientMode = CType(resources.GetObject("GVlisteMess.Appearance.GroupButton.GradientMode"), System.Drawing.Drawing2D.LinearGradientMode)
        Me.GVlisteMess.Appearance.GroupButton.Image = CType(resources.GetObject("GVlisteMess.Appearance.GroupButton.Image"), System.Drawing.Image)
        Me.GVlisteMess.Appearance.GroupButton.Options.UseBackColor = True
        Me.GVlisteMess.Appearance.GroupButton.Options.UseBorderColor = True
        Me.GVlisteMess.Appearance.GroupFooter.BackColor = CType(resources.GetObject("GVlisteMess.Appearance.GroupFooter.BackColor"), System.Drawing.Color)
        Me.GVlisteMess.Appearance.GroupFooter.BorderColor = CType(resources.GetObject("GVlisteMess.Appearance.GroupFooter.BorderColor"), System.Drawing.Color)
        Me.GVlisteMess.Appearance.GroupFooter.FontSizeDelta = CType(resources.GetObject("GVlisteMess.Appearance.GroupFooter.FontSizeDelta"), Integer)
        Me.GVlisteMess.Appearance.GroupFooter.FontStyleDelta = CType(resources.GetObject("GVlisteMess.Appearance.GroupFooter.FontStyleDelta"), System.Drawing.FontStyle)
        Me.GVlisteMess.Appearance.GroupFooter.ForeColor = CType(resources.GetObject("GVlisteMess.Appearance.GroupFooter.ForeColor"), System.Drawing.Color)
        Me.GVlisteMess.Appearance.GroupFooter.GradientMode = CType(resources.GetObject("GVlisteMess.Appearance.GroupFooter.GradientMode"), System.Drawing.Drawing2D.LinearGradientMode)
        Me.GVlisteMess.Appearance.GroupFooter.Image = CType(resources.GetObject("GVlisteMess.Appearance.GroupFooter.Image"), System.Drawing.Image)
        Me.GVlisteMess.Appearance.GroupFooter.Options.UseBackColor = True
        Me.GVlisteMess.Appearance.GroupFooter.Options.UseBorderColor = True
        Me.GVlisteMess.Appearance.GroupFooter.Options.UseForeColor = True
        Me.GVlisteMess.Appearance.GroupPanel.BackColor = CType(resources.GetObject("GVlisteMess.Appearance.GroupPanel.BackColor"), System.Drawing.Color)
        Me.GVlisteMess.Appearance.GroupPanel.BackColor2 = CType(resources.GetObject("GVlisteMess.Appearance.GroupPanel.BackColor2"), System.Drawing.Color)
        Me.GVlisteMess.Appearance.GroupPanel.FontSizeDelta = CType(resources.GetObject("GVlisteMess.Appearance.GroupPanel.FontSizeDelta"), Integer)
        Me.GVlisteMess.Appearance.GroupPanel.FontStyleDelta = CType(resources.GetObject("GVlisteMess.Appearance.GroupPanel.FontStyleDelta"), System.Drawing.FontStyle)
        Me.GVlisteMess.Appearance.GroupPanel.ForeColor = CType(resources.GetObject("GVlisteMess.Appearance.GroupPanel.ForeColor"), System.Drawing.Color)
        Me.GVlisteMess.Appearance.GroupPanel.GradientMode = CType(resources.GetObject("GVlisteMess.Appearance.GroupPanel.GradientMode"), System.Drawing.Drawing2D.LinearGradientMode)
        Me.GVlisteMess.Appearance.GroupPanel.Image = CType(resources.GetObject("GVlisteMess.Appearance.GroupPanel.Image"), System.Drawing.Image)
        Me.GVlisteMess.Appearance.GroupPanel.Options.UseBackColor = True
        Me.GVlisteMess.Appearance.GroupPanel.Options.UseForeColor = True
        Me.GVlisteMess.Appearance.GroupRow.BackColor = CType(resources.GetObject("GVlisteMess.Appearance.GroupRow.BackColor"), System.Drawing.Color)
        Me.GVlisteMess.Appearance.GroupRow.BorderColor = CType(resources.GetObject("GVlisteMess.Appearance.GroupRow.BorderColor"), System.Drawing.Color)
        Me.GVlisteMess.Appearance.GroupRow.FontSizeDelta = CType(resources.GetObject("GVlisteMess.Appearance.GroupRow.FontSizeDelta"), Integer)
        Me.GVlisteMess.Appearance.GroupRow.FontStyleDelta = CType(resources.GetObject("GVlisteMess.Appearance.GroupRow.FontStyleDelta"), System.Drawing.FontStyle)
        Me.GVlisteMess.Appearance.GroupRow.ForeColor = CType(resources.GetObject("GVlisteMess.Appearance.GroupRow.ForeColor"), System.Drawing.Color)
        Me.GVlisteMess.Appearance.GroupRow.GradientMode = CType(resources.GetObject("GVlisteMess.Appearance.GroupRow.GradientMode"), System.Drawing.Drawing2D.LinearGradientMode)
        Me.GVlisteMess.Appearance.GroupRow.Image = CType(resources.GetObject("GVlisteMess.Appearance.GroupRow.Image"), System.Drawing.Image)
        Me.GVlisteMess.Appearance.GroupRow.Options.UseBackColor = True
        Me.GVlisteMess.Appearance.GroupRow.Options.UseBorderColor = True
        Me.GVlisteMess.Appearance.GroupRow.Options.UseForeColor = True
        Me.GVlisteMess.Appearance.HeaderPanel.BackColor = CType(resources.GetObject("GVlisteMess.Appearance.HeaderPanel.BackColor"), System.Drawing.Color)
        Me.GVlisteMess.Appearance.HeaderPanel.BorderColor = CType(resources.GetObject("GVlisteMess.Appearance.HeaderPanel.BorderColor"), System.Drawing.Color)
        Me.GVlisteMess.Appearance.HeaderPanel.FontSizeDelta = CType(resources.GetObject("GVlisteMess.Appearance.HeaderPanel.FontSizeDelta"), Integer)
        Me.GVlisteMess.Appearance.HeaderPanel.FontStyleDelta = CType(resources.GetObject("GVlisteMess.Appearance.HeaderPanel.FontStyleDelta"), System.Drawing.FontStyle)
        Me.GVlisteMess.Appearance.HeaderPanel.ForeColor = CType(resources.GetObject("GVlisteMess.Appearance.HeaderPanel.ForeColor"), System.Drawing.Color)
        Me.GVlisteMess.Appearance.HeaderPanel.GradientMode = CType(resources.GetObject("GVlisteMess.Appearance.HeaderPanel.GradientMode"), System.Drawing.Drawing2D.LinearGradientMode)
        Me.GVlisteMess.Appearance.HeaderPanel.Image = CType(resources.GetObject("GVlisteMess.Appearance.HeaderPanel.Image"), System.Drawing.Image)
        Me.GVlisteMess.Appearance.HeaderPanel.Options.UseBackColor = True
        Me.GVlisteMess.Appearance.HeaderPanel.Options.UseBorderColor = True
        Me.GVlisteMess.Appearance.HeaderPanel.Options.UseForeColor = True
        Me.GVlisteMess.Appearance.HideSelectionRow.BackColor = CType(resources.GetObject("GVlisteMess.Appearance.HideSelectionRow.BackColor"), System.Drawing.Color)
        Me.GVlisteMess.Appearance.HideSelectionRow.BorderColor = CType(resources.GetObject("GVlisteMess.Appearance.HideSelectionRow.BorderColor"), System.Drawing.Color)
        Me.GVlisteMess.Appearance.HideSelectionRow.FontSizeDelta = CType(resources.GetObject("GVlisteMess.Appearance.HideSelectionRow.FontSizeDelta"), Integer)
        Me.GVlisteMess.Appearance.HideSelectionRow.FontStyleDelta = CType(resources.GetObject("GVlisteMess.Appearance.HideSelectionRow.FontStyleDelta"), System.Drawing.FontStyle)
        Me.GVlisteMess.Appearance.HideSelectionRow.ForeColor = CType(resources.GetObject("GVlisteMess.Appearance.HideSelectionRow.ForeColor"), System.Drawing.Color)
        Me.GVlisteMess.Appearance.HideSelectionRow.GradientMode = CType(resources.GetObject("GVlisteMess.Appearance.HideSelectionRow.GradientMode"), System.Drawing.Drawing2D.LinearGradientMode)
        Me.GVlisteMess.Appearance.HideSelectionRow.Image = CType(resources.GetObject("GVlisteMess.Appearance.HideSelectionRow.Image"), System.Drawing.Image)
        Me.GVlisteMess.Appearance.HideSelectionRow.Options.UseBackColor = True
        Me.GVlisteMess.Appearance.HideSelectionRow.Options.UseBorderColor = True
        Me.GVlisteMess.Appearance.HideSelectionRow.Options.UseForeColor = True
        Me.GVlisteMess.Appearance.HorzLine.BackColor = CType(resources.GetObject("GVlisteMess.Appearance.HorzLine.BackColor"), System.Drawing.Color)
        Me.GVlisteMess.Appearance.HorzLine.FontSizeDelta = CType(resources.GetObject("GVlisteMess.Appearance.HorzLine.FontSizeDelta"), Integer)
        Me.GVlisteMess.Appearance.HorzLine.FontStyleDelta = CType(resources.GetObject("GVlisteMess.Appearance.HorzLine.FontStyleDelta"), System.Drawing.FontStyle)
        Me.GVlisteMess.Appearance.HorzLine.GradientMode = CType(resources.GetObject("GVlisteMess.Appearance.HorzLine.GradientMode"), System.Drawing.Drawing2D.LinearGradientMode)
        Me.GVlisteMess.Appearance.HorzLine.Image = CType(resources.GetObject("GVlisteMess.Appearance.HorzLine.Image"), System.Drawing.Image)
        Me.GVlisteMess.Appearance.HorzLine.Options.UseBackColor = True
        Me.GVlisteMess.Appearance.OddRow.BackColor = CType(resources.GetObject("GVlisteMess.Appearance.OddRow.BackColor"), System.Drawing.Color)
        Me.GVlisteMess.Appearance.OddRow.BorderColor = CType(resources.GetObject("GVlisteMess.Appearance.OddRow.BorderColor"), System.Drawing.Color)
        Me.GVlisteMess.Appearance.OddRow.FontSizeDelta = CType(resources.GetObject("GVlisteMess.Appearance.OddRow.FontSizeDelta"), Integer)
        Me.GVlisteMess.Appearance.OddRow.FontStyleDelta = CType(resources.GetObject("GVlisteMess.Appearance.OddRow.FontStyleDelta"), System.Drawing.FontStyle)
        Me.GVlisteMess.Appearance.OddRow.ForeColor = CType(resources.GetObject("GVlisteMess.Appearance.OddRow.ForeColor"), System.Drawing.Color)
        Me.GVlisteMess.Appearance.OddRow.GradientMode = CType(resources.GetObject("GVlisteMess.Appearance.OddRow.GradientMode"), System.Drawing.Drawing2D.LinearGradientMode)
        Me.GVlisteMess.Appearance.OddRow.Image = CType(resources.GetObject("GVlisteMess.Appearance.OddRow.Image"), System.Drawing.Image)
        Me.GVlisteMess.Appearance.OddRow.Options.UseBackColor = True
        Me.GVlisteMess.Appearance.OddRow.Options.UseBorderColor = True
        Me.GVlisteMess.Appearance.OddRow.Options.UseForeColor = True
        Me.GVlisteMess.Appearance.Preview.Font = CType(resources.GetObject("GVlisteMess.Appearance.Preview.Font"), System.Drawing.Font)
        Me.GVlisteMess.Appearance.Preview.FontSizeDelta = CType(resources.GetObject("GVlisteMess.Appearance.Preview.FontSizeDelta"), Integer)
        Me.GVlisteMess.Appearance.Preview.FontStyleDelta = CType(resources.GetObject("GVlisteMess.Appearance.Preview.FontStyleDelta"), System.Drawing.FontStyle)
        Me.GVlisteMess.Appearance.Preview.ForeColor = CType(resources.GetObject("GVlisteMess.Appearance.Preview.ForeColor"), System.Drawing.Color)
        Me.GVlisteMess.Appearance.Preview.GradientMode = CType(resources.GetObject("GVlisteMess.Appearance.Preview.GradientMode"), System.Drawing.Drawing2D.LinearGradientMode)
        Me.GVlisteMess.Appearance.Preview.Image = CType(resources.GetObject("GVlisteMess.Appearance.Preview.Image"), System.Drawing.Image)
        Me.GVlisteMess.Appearance.Preview.Options.UseFont = True
        Me.GVlisteMess.Appearance.Preview.Options.UseForeColor = True
        Me.GVlisteMess.Appearance.Row.BackColor = CType(resources.GetObject("GVlisteMess.Appearance.Row.BackColor"), System.Drawing.Color)
        Me.GVlisteMess.Appearance.Row.FontSizeDelta = CType(resources.GetObject("GVlisteMess.Appearance.Row.FontSizeDelta"), Integer)
        Me.GVlisteMess.Appearance.Row.FontStyleDelta = CType(resources.GetObject("GVlisteMess.Appearance.Row.FontStyleDelta"), System.Drawing.FontStyle)
        Me.GVlisteMess.Appearance.Row.ForeColor = CType(resources.GetObject("GVlisteMess.Appearance.Row.ForeColor"), System.Drawing.Color)
        Me.GVlisteMess.Appearance.Row.GradientMode = CType(resources.GetObject("GVlisteMess.Appearance.Row.GradientMode"), System.Drawing.Drawing2D.LinearGradientMode)
        Me.GVlisteMess.Appearance.Row.Image = CType(resources.GetObject("GVlisteMess.Appearance.Row.Image"), System.Drawing.Image)
        Me.GVlisteMess.Appearance.Row.Options.UseBackColor = True
        Me.GVlisteMess.Appearance.Row.Options.UseForeColor = True
        Me.GVlisteMess.Appearance.RowSeparator.BackColor = CType(resources.GetObject("GVlisteMess.Appearance.RowSeparator.BackColor"), System.Drawing.Color)
        Me.GVlisteMess.Appearance.RowSeparator.BackColor2 = CType(resources.GetObject("GVlisteMess.Appearance.RowSeparator.BackColor2"), System.Drawing.Color)
        Me.GVlisteMess.Appearance.RowSeparator.FontSizeDelta = CType(resources.GetObject("GVlisteMess.Appearance.RowSeparator.FontSizeDelta"), Integer)
        Me.GVlisteMess.Appearance.RowSeparator.FontStyleDelta = CType(resources.GetObject("GVlisteMess.Appearance.RowSeparator.FontStyleDelta"), System.Drawing.FontStyle)
        Me.GVlisteMess.Appearance.RowSeparator.GradientMode = CType(resources.GetObject("GVlisteMess.Appearance.RowSeparator.GradientMode"), System.Drawing.Drawing2D.LinearGradientMode)
        Me.GVlisteMess.Appearance.RowSeparator.Image = CType(resources.GetObject("GVlisteMess.Appearance.RowSeparator.Image"), System.Drawing.Image)
        Me.GVlisteMess.Appearance.RowSeparator.Options.UseBackColor = True
        Me.GVlisteMess.Appearance.SelectedRow.BackColor = CType(resources.GetObject("GVlisteMess.Appearance.SelectedRow.BackColor"), System.Drawing.Color)
        Me.GVlisteMess.Appearance.SelectedRow.FontSizeDelta = CType(resources.GetObject("GVlisteMess.Appearance.SelectedRow.FontSizeDelta"), Integer)
        Me.GVlisteMess.Appearance.SelectedRow.FontStyleDelta = CType(resources.GetObject("GVlisteMess.Appearance.SelectedRow.FontStyleDelta"), System.Drawing.FontStyle)
        Me.GVlisteMess.Appearance.SelectedRow.ForeColor = CType(resources.GetObject("GVlisteMess.Appearance.SelectedRow.ForeColor"), System.Drawing.Color)
        Me.GVlisteMess.Appearance.SelectedRow.GradientMode = CType(resources.GetObject("GVlisteMess.Appearance.SelectedRow.GradientMode"), System.Drawing.Drawing2D.LinearGradientMode)
        Me.GVlisteMess.Appearance.SelectedRow.Image = CType(resources.GetObject("GVlisteMess.Appearance.SelectedRow.Image"), System.Drawing.Image)
        Me.GVlisteMess.Appearance.SelectedRow.Options.UseBackColor = True
        Me.GVlisteMess.Appearance.SelectedRow.Options.UseForeColor = True
        Me.GVlisteMess.Appearance.TopNewRow.BackColor = CType(resources.GetObject("GVlisteMess.Appearance.TopNewRow.BackColor"), System.Drawing.Color)
        Me.GVlisteMess.Appearance.TopNewRow.FontSizeDelta = CType(resources.GetObject("GVlisteMess.Appearance.TopNewRow.FontSizeDelta"), Integer)
        Me.GVlisteMess.Appearance.TopNewRow.FontStyleDelta = CType(resources.GetObject("GVlisteMess.Appearance.TopNewRow.FontStyleDelta"), System.Drawing.FontStyle)
        Me.GVlisteMess.Appearance.TopNewRow.GradientMode = CType(resources.GetObject("GVlisteMess.Appearance.TopNewRow.GradientMode"), System.Drawing.Drawing2D.LinearGradientMode)
        Me.GVlisteMess.Appearance.TopNewRow.Image = CType(resources.GetObject("GVlisteMess.Appearance.TopNewRow.Image"), System.Drawing.Image)
        Me.GVlisteMess.Appearance.TopNewRow.Options.UseBackColor = True
        Me.GVlisteMess.Appearance.VertLine.BackColor = CType(resources.GetObject("GVlisteMess.Appearance.VertLine.BackColor"), System.Drawing.Color)
        Me.GVlisteMess.Appearance.VertLine.FontSizeDelta = CType(resources.GetObject("GVlisteMess.Appearance.VertLine.FontSizeDelta"), Integer)
        Me.GVlisteMess.Appearance.VertLine.FontStyleDelta = CType(resources.GetObject("GVlisteMess.Appearance.VertLine.FontStyleDelta"), System.Drawing.FontStyle)
        Me.GVlisteMess.Appearance.VertLine.GradientMode = CType(resources.GetObject("GVlisteMess.Appearance.VertLine.GradientMode"), System.Drawing.Drawing2D.LinearGradientMode)
        Me.GVlisteMess.Appearance.VertLine.Image = CType(resources.GetObject("GVlisteMess.Appearance.VertLine.Image"), System.Drawing.Image)
        Me.GVlisteMess.Appearance.VertLine.Options.UseBackColor = True
        resources.ApplyResources(Me.GVlisteMess, "GVlisteMess")
        Me.GVlisteMess.Columns.AddRange(New DevExpress.XtraGrid.Columns.GridColumn() {Me.GColTechnicien, Me.GColDate, Me.GColLib, Me.GColNum})
        Me.GVlisteMess.GridControl = Me.GCListeMess
        Me.GVlisteMess.Name = "GVlisteMess"
        Me.GVlisteMess.OptionsBehavior.Editable = False
        Me.GVlisteMess.OptionsBehavior.ReadOnly = True
        Me.GVlisteMess.OptionsView.EnableAppearanceEvenRow = True
        Me.GVlisteMess.OptionsView.EnableAppearanceOddRow = True
        Me.GVlisteMess.OptionsView.ShowAutoFilterRow = True
        Me.GVlisteMess.OptionsView.ShowGroupPanel = False
        '
        'GColTechnicien
        '
        resources.ApplyResources(Me.GColTechnicien, "GColTechnicien")
        Me.GColTechnicien.FieldName = "VPERNOM"
        Me.GColTechnicien.Name = "GColTechnicien"
        Me.GColTechnicien.OptionsColumn.AllowEdit = False
        Me.GColTechnicien.OptionsColumn.ReadOnly = True
        Me.GColTechnicien.OptionsFilter.AutoFilterCondition = DevExpress.XtraGrid.Columns.AutoFilterCondition.Contains
        '
        'GColNum
        '
        resources.ApplyResources(Me.GColNum, "GColNum")
        Me.GColNum.FieldName = "NPERNUM"
        Me.GColNum.Name = "GColNum"
        '
        'GrpListe
        '
        resources.ApplyResources(Me.GrpListe, "GrpListe")
        Me.GrpListe.Controls.Add(Me.GCListeMess)
        Me.GrpListe.Name = "GrpListe"
        Me.GrpListe.TabStop = False
        '
        'OFD
        '
        resources.ApplyResources(Me.OFD, "OFD")
        '
        'FrmListeMessageWebTech
        '
        resources.ApplyResources(Me, "$this")
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.Wheat
        Me.Controls.Add(Me.GrpActions)
        Me.Controls.Add(Me.GrpListe)
        Me.Name = "FrmListeMessageWebTech"
        Me.WindowState = System.Windows.Forms.FormWindowState.Maximized
        Me.GrpActions.ResumeLayout(False)
        CType(Me.GCListeMess, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.GVlisteMess, System.ComponentModel.ISupportInitialize).EndInit()
        Me.GrpListe.ResumeLayout(False)
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents GrpActions As System.Windows.Forms.GroupBox
    Friend WithEvents BtnSupprimer As System.Windows.Forms.Button
    Friend WithEvents BtnFermer As System.Windows.Forms.Button
    Friend WithEvents BtnSave As System.Windows.Forms.Button
    Friend WithEvents GrpListe As System.Windows.Forms.GroupBox
    Friend WithEvents OFD As System.Windows.Forms.OpenFileDialog
    Private WithEvents GColDate As DevExpress.XtraGrid.Columns.GridColumn
    Private WithEvents GColLib As DevExpress.XtraGrid.Columns.GridColumn
    Private WithEvents GCListeMess As DevExpress.XtraGrid.GridControl
    Private WithEvents GVlisteMess As DevExpress.XtraGrid.Views.Grid.GridView
    Private WithEvents GColTechnicien As DevExpress.XtraGrid.Columns.GridColumn
    Private WithEvents GColNum As DevExpress.XtraGrid.Columns.GridColumn
End Class
