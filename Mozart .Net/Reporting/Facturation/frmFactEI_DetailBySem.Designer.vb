<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmFactEI_DetailBySem
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(frmFactEI_DetailBySem))
        Me.GCDetailFact = New DevExpress.XtraGrid.GridControl()
        Me.GVDetailFact = New DevExpress.XtraGrid.Views.Grid.GridView()
        Me.GColDFACDAT = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.GColNFACNUM = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.GColVCLINOM = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.GColNDINNUM = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.GColNELFTHT = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.TECHNICIEN = New DevExpress.XtraGrid.Columns.GridColumn()
        CType(Me.GCDetailFact, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.GVDetailFact, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'GCDetailFact
        '
        resources.ApplyResources(Me.GCDetailFact, "GCDetailFact")
        '
        '
        '
        Me.GCDetailFact.EmbeddedNavigator.AccessibleDescription = resources.GetString("GCDetailFact.EmbeddedNavigator.AccessibleDescription")
        Me.GCDetailFact.EmbeddedNavigator.AccessibleName = resources.GetString("GCDetailFact.EmbeddedNavigator.AccessibleName")
        Me.GCDetailFact.EmbeddedNavigator.AllowHtmlTextInToolTip = CType(resources.GetObject("GCDetailFact.EmbeddedNavigator.AllowHtmlTextInToolTip"), DevExpress.Utils.DefaultBoolean)
        Me.GCDetailFact.EmbeddedNavigator.Anchor = CType(resources.GetObject("GCDetailFact.EmbeddedNavigator.Anchor"), System.Windows.Forms.AnchorStyles)
        Me.GCDetailFact.EmbeddedNavigator.BackgroundImage = CType(resources.GetObject("GCDetailFact.EmbeddedNavigator.BackgroundImage"), System.Drawing.Image)
        Me.GCDetailFact.EmbeddedNavigator.BackgroundImageLayout = CType(resources.GetObject("GCDetailFact.EmbeddedNavigator.BackgroundImageLayout"), System.Windows.Forms.ImageLayout)
        Me.GCDetailFact.EmbeddedNavigator.ImeMode = CType(resources.GetObject("GCDetailFact.EmbeddedNavigator.ImeMode"), System.Windows.Forms.ImeMode)
        Me.GCDetailFact.EmbeddedNavigator.MaximumSize = CType(resources.GetObject("GCDetailFact.EmbeddedNavigator.MaximumSize"), System.Drawing.Size)
        Me.GCDetailFact.EmbeddedNavigator.TextLocation = CType(resources.GetObject("GCDetailFact.EmbeddedNavigator.TextLocation"), DevExpress.XtraEditors.NavigatorButtonsTextLocation)
        Me.GCDetailFact.EmbeddedNavigator.ToolTip = resources.GetString("GCDetailFact.EmbeddedNavigator.ToolTip")
        Me.GCDetailFact.EmbeddedNavigator.ToolTipIconType = CType(resources.GetObject("GCDetailFact.EmbeddedNavigator.ToolTipIconType"), DevExpress.Utils.ToolTipIconType)
        Me.GCDetailFact.EmbeddedNavigator.ToolTipTitle = resources.GetString("GCDetailFact.EmbeddedNavigator.ToolTipTitle")
        Me.GCDetailFact.MainView = Me.GVDetailFact
        Me.GCDetailFact.Name = "GCDetailFact"
        Me.GCDetailFact.ViewCollection.AddRange(New DevExpress.XtraGrid.Views.Base.BaseView() {Me.GVDetailFact})
        '
        'GVDetailFact
        '
        Me.GVDetailFact.Appearance.ColumnFilterButton.BackColor = CType(resources.GetObject("GVDetailFact.Appearance.ColumnFilterButton.BackColor"), System.Drawing.Color)
        Me.GVDetailFact.Appearance.ColumnFilterButton.BorderColor = CType(resources.GetObject("GVDetailFact.Appearance.ColumnFilterButton.BorderColor"), System.Drawing.Color)
        Me.GVDetailFact.Appearance.ColumnFilterButton.FontSizeDelta = CType(resources.GetObject("GVDetailFact.Appearance.ColumnFilterButton.FontSizeDelta"), Integer)
        Me.GVDetailFact.Appearance.ColumnFilterButton.FontStyleDelta = CType(resources.GetObject("GVDetailFact.Appearance.ColumnFilterButton.FontStyleDelta"), System.Drawing.FontStyle)
        Me.GVDetailFact.Appearance.ColumnFilterButton.ForeColor = CType(resources.GetObject("GVDetailFact.Appearance.ColumnFilterButton.ForeColor"), System.Drawing.Color)
        Me.GVDetailFact.Appearance.ColumnFilterButton.GradientMode = CType(resources.GetObject("GVDetailFact.Appearance.ColumnFilterButton.GradientMode"), System.Drawing.Drawing2D.LinearGradientMode)
        Me.GVDetailFact.Appearance.ColumnFilterButton.Image = CType(resources.GetObject("GVDetailFact.Appearance.ColumnFilterButton.Image"), System.Drawing.Image)
        Me.GVDetailFact.Appearance.ColumnFilterButton.Options.UseBackColor = True
        Me.GVDetailFact.Appearance.ColumnFilterButton.Options.UseBorderColor = True
        Me.GVDetailFact.Appearance.ColumnFilterButton.Options.UseForeColor = True
        Me.GVDetailFact.Appearance.ColumnFilterButtonActive.BackColor = CType(resources.GetObject("GVDetailFact.Appearance.ColumnFilterButtonActive.BackColor"), System.Drawing.Color)
        Me.GVDetailFact.Appearance.ColumnFilterButtonActive.BorderColor = CType(resources.GetObject("GVDetailFact.Appearance.ColumnFilterButtonActive.BorderColor"), System.Drawing.Color)
        Me.GVDetailFact.Appearance.ColumnFilterButtonActive.FontSizeDelta = CType(resources.GetObject("GVDetailFact.Appearance.ColumnFilterButtonActive.FontSizeDelta"), Integer)
        Me.GVDetailFact.Appearance.ColumnFilterButtonActive.FontStyleDelta = CType(resources.GetObject("GVDetailFact.Appearance.ColumnFilterButtonActive.FontStyleDelta"), System.Drawing.FontStyle)
        Me.GVDetailFact.Appearance.ColumnFilterButtonActive.ForeColor = CType(resources.GetObject("GVDetailFact.Appearance.ColumnFilterButtonActive.ForeColor"), System.Drawing.Color)
        Me.GVDetailFact.Appearance.ColumnFilterButtonActive.GradientMode = CType(resources.GetObject("GVDetailFact.Appearance.ColumnFilterButtonActive.GradientMode"), System.Drawing.Drawing2D.LinearGradientMode)
        Me.GVDetailFact.Appearance.ColumnFilterButtonActive.Image = CType(resources.GetObject("GVDetailFact.Appearance.ColumnFilterButtonActive.Image"), System.Drawing.Image)
        Me.GVDetailFact.Appearance.ColumnFilterButtonActive.Options.UseBackColor = True
        Me.GVDetailFact.Appearance.ColumnFilterButtonActive.Options.UseBorderColor = True
        Me.GVDetailFact.Appearance.ColumnFilterButtonActive.Options.UseForeColor = True
        Me.GVDetailFact.Appearance.Empty.BackColor = CType(resources.GetObject("GVDetailFact.Appearance.Empty.BackColor"), System.Drawing.Color)
        Me.GVDetailFact.Appearance.Empty.BackColor2 = CType(resources.GetObject("GVDetailFact.Appearance.Empty.BackColor2"), System.Drawing.Color)
        Me.GVDetailFact.Appearance.Empty.FontSizeDelta = CType(resources.GetObject("GVDetailFact.Appearance.Empty.FontSizeDelta"), Integer)
        Me.GVDetailFact.Appearance.Empty.FontStyleDelta = CType(resources.GetObject("GVDetailFact.Appearance.Empty.FontStyleDelta"), System.Drawing.FontStyle)
        Me.GVDetailFact.Appearance.Empty.GradientMode = CType(resources.GetObject("GVDetailFact.Appearance.Empty.GradientMode"), System.Drawing.Drawing2D.LinearGradientMode)
        Me.GVDetailFact.Appearance.Empty.Image = CType(resources.GetObject("GVDetailFact.Appearance.Empty.Image"), System.Drawing.Image)
        Me.GVDetailFact.Appearance.Empty.Options.UseBackColor = True
        Me.GVDetailFact.Appearance.EvenRow.BackColor = CType(resources.GetObject("GVDetailFact.Appearance.EvenRow.BackColor"), System.Drawing.Color)
        Me.GVDetailFact.Appearance.EvenRow.BorderColor = CType(resources.GetObject("GVDetailFact.Appearance.EvenRow.BorderColor"), System.Drawing.Color)
        Me.GVDetailFact.Appearance.EvenRow.FontSizeDelta = CType(resources.GetObject("GVDetailFact.Appearance.EvenRow.FontSizeDelta"), Integer)
        Me.GVDetailFact.Appearance.EvenRow.FontStyleDelta = CType(resources.GetObject("GVDetailFact.Appearance.EvenRow.FontStyleDelta"), System.Drawing.FontStyle)
        Me.GVDetailFact.Appearance.EvenRow.ForeColor = CType(resources.GetObject("GVDetailFact.Appearance.EvenRow.ForeColor"), System.Drawing.Color)
        Me.GVDetailFact.Appearance.EvenRow.GradientMode = CType(resources.GetObject("GVDetailFact.Appearance.EvenRow.GradientMode"), System.Drawing.Drawing2D.LinearGradientMode)
        Me.GVDetailFact.Appearance.EvenRow.Image = CType(resources.GetObject("GVDetailFact.Appearance.EvenRow.Image"), System.Drawing.Image)
        Me.GVDetailFact.Appearance.EvenRow.Options.UseBackColor = True
        Me.GVDetailFact.Appearance.EvenRow.Options.UseBorderColor = True
        Me.GVDetailFact.Appearance.EvenRow.Options.UseForeColor = True
        Me.GVDetailFact.Appearance.FilterCloseButton.BackColor = CType(resources.GetObject("GVDetailFact.Appearance.FilterCloseButton.BackColor"), System.Drawing.Color)
        Me.GVDetailFact.Appearance.FilterCloseButton.BorderColor = CType(resources.GetObject("GVDetailFact.Appearance.FilterCloseButton.BorderColor"), System.Drawing.Color)
        Me.GVDetailFact.Appearance.FilterCloseButton.FontSizeDelta = CType(resources.GetObject("GVDetailFact.Appearance.FilterCloseButton.FontSizeDelta"), Integer)
        Me.GVDetailFact.Appearance.FilterCloseButton.FontStyleDelta = CType(resources.GetObject("GVDetailFact.Appearance.FilterCloseButton.FontStyleDelta"), System.Drawing.FontStyle)
        Me.GVDetailFact.Appearance.FilterCloseButton.ForeColor = CType(resources.GetObject("GVDetailFact.Appearance.FilterCloseButton.ForeColor"), System.Drawing.Color)
        Me.GVDetailFact.Appearance.FilterCloseButton.GradientMode = CType(resources.GetObject("GVDetailFact.Appearance.FilterCloseButton.GradientMode"), System.Drawing.Drawing2D.LinearGradientMode)
        Me.GVDetailFact.Appearance.FilterCloseButton.Image = CType(resources.GetObject("GVDetailFact.Appearance.FilterCloseButton.Image"), System.Drawing.Image)
        Me.GVDetailFact.Appearance.FilterCloseButton.Options.UseBackColor = True
        Me.GVDetailFact.Appearance.FilterCloseButton.Options.UseBorderColor = True
        Me.GVDetailFact.Appearance.FilterCloseButton.Options.UseForeColor = True
        Me.GVDetailFact.Appearance.FilterPanel.BackColor = CType(resources.GetObject("GVDetailFact.Appearance.FilterPanel.BackColor"), System.Drawing.Color)
        Me.GVDetailFact.Appearance.FilterPanel.BackColor2 = CType(resources.GetObject("GVDetailFact.Appearance.FilterPanel.BackColor2"), System.Drawing.Color)
        Me.GVDetailFact.Appearance.FilterPanel.FontSizeDelta = CType(resources.GetObject("GVDetailFact.Appearance.FilterPanel.FontSizeDelta"), Integer)
        Me.GVDetailFact.Appearance.FilterPanel.FontStyleDelta = CType(resources.GetObject("GVDetailFact.Appearance.FilterPanel.FontStyleDelta"), System.Drawing.FontStyle)
        Me.GVDetailFact.Appearance.FilterPanel.ForeColor = CType(resources.GetObject("GVDetailFact.Appearance.FilterPanel.ForeColor"), System.Drawing.Color)
        Me.GVDetailFact.Appearance.FilterPanel.GradientMode = CType(resources.GetObject("GVDetailFact.Appearance.FilterPanel.GradientMode"), System.Drawing.Drawing2D.LinearGradientMode)
        Me.GVDetailFact.Appearance.FilterPanel.Image = CType(resources.GetObject("GVDetailFact.Appearance.FilterPanel.Image"), System.Drawing.Image)
        Me.GVDetailFact.Appearance.FilterPanel.Options.UseBackColor = True
        Me.GVDetailFact.Appearance.FilterPanel.Options.UseForeColor = True
        Me.GVDetailFact.Appearance.FixedLine.BackColor = CType(resources.GetObject("GVDetailFact.Appearance.FixedLine.BackColor"), System.Drawing.Color)
        Me.GVDetailFact.Appearance.FixedLine.FontSizeDelta = CType(resources.GetObject("GVDetailFact.Appearance.FixedLine.FontSizeDelta"), Integer)
        Me.GVDetailFact.Appearance.FixedLine.FontStyleDelta = CType(resources.GetObject("GVDetailFact.Appearance.FixedLine.FontStyleDelta"), System.Drawing.FontStyle)
        Me.GVDetailFact.Appearance.FixedLine.GradientMode = CType(resources.GetObject("GVDetailFact.Appearance.FixedLine.GradientMode"), System.Drawing.Drawing2D.LinearGradientMode)
        Me.GVDetailFact.Appearance.FixedLine.Image = CType(resources.GetObject("GVDetailFact.Appearance.FixedLine.Image"), System.Drawing.Image)
        Me.GVDetailFact.Appearance.FixedLine.Options.UseBackColor = True
        Me.GVDetailFact.Appearance.FocusedCell.BackColor = CType(resources.GetObject("GVDetailFact.Appearance.FocusedCell.BackColor"), System.Drawing.Color)
        Me.GVDetailFact.Appearance.FocusedCell.FontSizeDelta = CType(resources.GetObject("GVDetailFact.Appearance.FocusedCell.FontSizeDelta"), Integer)
        Me.GVDetailFact.Appearance.FocusedCell.FontStyleDelta = CType(resources.GetObject("GVDetailFact.Appearance.FocusedCell.FontStyleDelta"), System.Drawing.FontStyle)
        Me.GVDetailFact.Appearance.FocusedCell.ForeColor = CType(resources.GetObject("GVDetailFact.Appearance.FocusedCell.ForeColor"), System.Drawing.Color)
        Me.GVDetailFact.Appearance.FocusedCell.GradientMode = CType(resources.GetObject("GVDetailFact.Appearance.FocusedCell.GradientMode"), System.Drawing.Drawing2D.LinearGradientMode)
        Me.GVDetailFact.Appearance.FocusedCell.Image = CType(resources.GetObject("GVDetailFact.Appearance.FocusedCell.Image"), System.Drawing.Image)
        Me.GVDetailFact.Appearance.FocusedCell.Options.UseBackColor = True
        Me.GVDetailFact.Appearance.FocusedCell.Options.UseForeColor = True
        Me.GVDetailFact.Appearance.FocusedRow.BackColor = CType(resources.GetObject("GVDetailFact.Appearance.FocusedRow.BackColor"), System.Drawing.Color)
        Me.GVDetailFact.Appearance.FocusedRow.BorderColor = CType(resources.GetObject("GVDetailFact.Appearance.FocusedRow.BorderColor"), System.Drawing.Color)
        Me.GVDetailFact.Appearance.FocusedRow.FontSizeDelta = CType(resources.GetObject("GVDetailFact.Appearance.FocusedRow.FontSizeDelta"), Integer)
        Me.GVDetailFact.Appearance.FocusedRow.FontStyleDelta = CType(resources.GetObject("GVDetailFact.Appearance.FocusedRow.FontStyleDelta"), System.Drawing.FontStyle)
        Me.GVDetailFact.Appearance.FocusedRow.ForeColor = CType(resources.GetObject("GVDetailFact.Appearance.FocusedRow.ForeColor"), System.Drawing.Color)
        Me.GVDetailFact.Appearance.FocusedRow.GradientMode = CType(resources.GetObject("GVDetailFact.Appearance.FocusedRow.GradientMode"), System.Drawing.Drawing2D.LinearGradientMode)
        Me.GVDetailFact.Appearance.FocusedRow.Image = CType(resources.GetObject("GVDetailFact.Appearance.FocusedRow.Image"), System.Drawing.Image)
        Me.GVDetailFact.Appearance.FocusedRow.Options.UseBackColor = True
        Me.GVDetailFact.Appearance.FocusedRow.Options.UseBorderColor = True
        Me.GVDetailFact.Appearance.FocusedRow.Options.UseForeColor = True
        Me.GVDetailFact.Appearance.FooterPanel.BackColor = CType(resources.GetObject("GVDetailFact.Appearance.FooterPanel.BackColor"), System.Drawing.Color)
        Me.GVDetailFact.Appearance.FooterPanel.BorderColor = CType(resources.GetObject("GVDetailFact.Appearance.FooterPanel.BorderColor"), System.Drawing.Color)
        Me.GVDetailFact.Appearance.FooterPanel.FontSizeDelta = CType(resources.GetObject("GVDetailFact.Appearance.FooterPanel.FontSizeDelta"), Integer)
        Me.GVDetailFact.Appearance.FooterPanel.FontStyleDelta = CType(resources.GetObject("GVDetailFact.Appearance.FooterPanel.FontStyleDelta"), System.Drawing.FontStyle)
        Me.GVDetailFact.Appearance.FooterPanel.ForeColor = CType(resources.GetObject("GVDetailFact.Appearance.FooterPanel.ForeColor"), System.Drawing.Color)
        Me.GVDetailFact.Appearance.FooterPanel.GradientMode = CType(resources.GetObject("GVDetailFact.Appearance.FooterPanel.GradientMode"), System.Drawing.Drawing2D.LinearGradientMode)
        Me.GVDetailFact.Appearance.FooterPanel.Image = CType(resources.GetObject("GVDetailFact.Appearance.FooterPanel.Image"), System.Drawing.Image)
        Me.GVDetailFact.Appearance.FooterPanel.Options.UseBackColor = True
        Me.GVDetailFact.Appearance.FooterPanel.Options.UseBorderColor = True
        Me.GVDetailFact.Appearance.FooterPanel.Options.UseForeColor = True
        Me.GVDetailFact.Appearance.GroupButton.BackColor = CType(resources.GetObject("GVDetailFact.Appearance.GroupButton.BackColor"), System.Drawing.Color)
        Me.GVDetailFact.Appearance.GroupButton.BorderColor = CType(resources.GetObject("GVDetailFact.Appearance.GroupButton.BorderColor"), System.Drawing.Color)
        Me.GVDetailFact.Appearance.GroupButton.FontSizeDelta = CType(resources.GetObject("GVDetailFact.Appearance.GroupButton.FontSizeDelta"), Integer)
        Me.GVDetailFact.Appearance.GroupButton.FontStyleDelta = CType(resources.GetObject("GVDetailFact.Appearance.GroupButton.FontStyleDelta"), System.Drawing.FontStyle)
        Me.GVDetailFact.Appearance.GroupButton.GradientMode = CType(resources.GetObject("GVDetailFact.Appearance.GroupButton.GradientMode"), System.Drawing.Drawing2D.LinearGradientMode)
        Me.GVDetailFact.Appearance.GroupButton.Image = CType(resources.GetObject("GVDetailFact.Appearance.GroupButton.Image"), System.Drawing.Image)
        Me.GVDetailFact.Appearance.GroupButton.Options.UseBackColor = True
        Me.GVDetailFact.Appearance.GroupButton.Options.UseBorderColor = True
        Me.GVDetailFact.Appearance.GroupFooter.BackColor = CType(resources.GetObject("GVDetailFact.Appearance.GroupFooter.BackColor"), System.Drawing.Color)
        Me.GVDetailFact.Appearance.GroupFooter.BorderColor = CType(resources.GetObject("GVDetailFact.Appearance.GroupFooter.BorderColor"), System.Drawing.Color)
        Me.GVDetailFact.Appearance.GroupFooter.FontSizeDelta = CType(resources.GetObject("GVDetailFact.Appearance.GroupFooter.FontSizeDelta"), Integer)
        Me.GVDetailFact.Appearance.GroupFooter.FontStyleDelta = CType(resources.GetObject("GVDetailFact.Appearance.GroupFooter.FontStyleDelta"), System.Drawing.FontStyle)
        Me.GVDetailFact.Appearance.GroupFooter.ForeColor = CType(resources.GetObject("GVDetailFact.Appearance.GroupFooter.ForeColor"), System.Drawing.Color)
        Me.GVDetailFact.Appearance.GroupFooter.GradientMode = CType(resources.GetObject("GVDetailFact.Appearance.GroupFooter.GradientMode"), System.Drawing.Drawing2D.LinearGradientMode)
        Me.GVDetailFact.Appearance.GroupFooter.Image = CType(resources.GetObject("GVDetailFact.Appearance.GroupFooter.Image"), System.Drawing.Image)
        Me.GVDetailFact.Appearance.GroupFooter.Options.UseBackColor = True
        Me.GVDetailFact.Appearance.GroupFooter.Options.UseBorderColor = True
        Me.GVDetailFact.Appearance.GroupFooter.Options.UseForeColor = True
        Me.GVDetailFact.Appearance.GroupPanel.BackColor = CType(resources.GetObject("GVDetailFact.Appearance.GroupPanel.BackColor"), System.Drawing.Color)
        Me.GVDetailFact.Appearance.GroupPanel.BackColor2 = CType(resources.GetObject("GVDetailFact.Appearance.GroupPanel.BackColor2"), System.Drawing.Color)
        Me.GVDetailFact.Appearance.GroupPanel.FontSizeDelta = CType(resources.GetObject("GVDetailFact.Appearance.GroupPanel.FontSizeDelta"), Integer)
        Me.GVDetailFact.Appearance.GroupPanel.FontStyleDelta = CType(resources.GetObject("GVDetailFact.Appearance.GroupPanel.FontStyleDelta"), System.Drawing.FontStyle)
        Me.GVDetailFact.Appearance.GroupPanel.ForeColor = CType(resources.GetObject("GVDetailFact.Appearance.GroupPanel.ForeColor"), System.Drawing.Color)
        Me.GVDetailFact.Appearance.GroupPanel.GradientMode = CType(resources.GetObject("GVDetailFact.Appearance.GroupPanel.GradientMode"), System.Drawing.Drawing2D.LinearGradientMode)
        Me.GVDetailFact.Appearance.GroupPanel.Image = CType(resources.GetObject("GVDetailFact.Appearance.GroupPanel.Image"), System.Drawing.Image)
        Me.GVDetailFact.Appearance.GroupPanel.Options.UseBackColor = True
        Me.GVDetailFact.Appearance.GroupPanel.Options.UseForeColor = True
        Me.GVDetailFact.Appearance.GroupRow.BackColor = CType(resources.GetObject("GVDetailFact.Appearance.GroupRow.BackColor"), System.Drawing.Color)
        Me.GVDetailFact.Appearance.GroupRow.BorderColor = CType(resources.GetObject("GVDetailFact.Appearance.GroupRow.BorderColor"), System.Drawing.Color)
        Me.GVDetailFact.Appearance.GroupRow.FontSizeDelta = CType(resources.GetObject("GVDetailFact.Appearance.GroupRow.FontSizeDelta"), Integer)
        Me.GVDetailFact.Appearance.GroupRow.FontStyleDelta = CType(resources.GetObject("GVDetailFact.Appearance.GroupRow.FontStyleDelta"), System.Drawing.FontStyle)
        Me.GVDetailFact.Appearance.GroupRow.ForeColor = CType(resources.GetObject("GVDetailFact.Appearance.GroupRow.ForeColor"), System.Drawing.Color)
        Me.GVDetailFact.Appearance.GroupRow.GradientMode = CType(resources.GetObject("GVDetailFact.Appearance.GroupRow.GradientMode"), System.Drawing.Drawing2D.LinearGradientMode)
        Me.GVDetailFact.Appearance.GroupRow.Image = CType(resources.GetObject("GVDetailFact.Appearance.GroupRow.Image"), System.Drawing.Image)
        Me.GVDetailFact.Appearance.GroupRow.Options.UseBackColor = True
        Me.GVDetailFact.Appearance.GroupRow.Options.UseBorderColor = True
        Me.GVDetailFact.Appearance.GroupRow.Options.UseForeColor = True
        Me.GVDetailFact.Appearance.HeaderPanel.BackColor = CType(resources.GetObject("GVDetailFact.Appearance.HeaderPanel.BackColor"), System.Drawing.Color)
        Me.GVDetailFact.Appearance.HeaderPanel.BorderColor = CType(resources.GetObject("GVDetailFact.Appearance.HeaderPanel.BorderColor"), System.Drawing.Color)
        Me.GVDetailFact.Appearance.HeaderPanel.Font = CType(resources.GetObject("GVDetailFact.Appearance.HeaderPanel.Font"), System.Drawing.Font)
        Me.GVDetailFact.Appearance.HeaderPanel.FontSizeDelta = CType(resources.GetObject("GVDetailFact.Appearance.HeaderPanel.FontSizeDelta"), Integer)
        Me.GVDetailFact.Appearance.HeaderPanel.FontStyleDelta = CType(resources.GetObject("GVDetailFact.Appearance.HeaderPanel.FontStyleDelta"), System.Drawing.FontStyle)
        Me.GVDetailFact.Appearance.HeaderPanel.ForeColor = CType(resources.GetObject("GVDetailFact.Appearance.HeaderPanel.ForeColor"), System.Drawing.Color)
        Me.GVDetailFact.Appearance.HeaderPanel.GradientMode = CType(resources.GetObject("GVDetailFact.Appearance.HeaderPanel.GradientMode"), System.Drawing.Drawing2D.LinearGradientMode)
        Me.GVDetailFact.Appearance.HeaderPanel.Image = CType(resources.GetObject("GVDetailFact.Appearance.HeaderPanel.Image"), System.Drawing.Image)
        Me.GVDetailFact.Appearance.HeaderPanel.Options.UseBackColor = True
        Me.GVDetailFact.Appearance.HeaderPanel.Options.UseBorderColor = True
        Me.GVDetailFact.Appearance.HeaderPanel.Options.UseFont = True
        Me.GVDetailFact.Appearance.HeaderPanel.Options.UseForeColor = True
        Me.GVDetailFact.Appearance.HideSelectionRow.BackColor = CType(resources.GetObject("GVDetailFact.Appearance.HideSelectionRow.BackColor"), System.Drawing.Color)
        Me.GVDetailFact.Appearance.HideSelectionRow.BorderColor = CType(resources.GetObject("GVDetailFact.Appearance.HideSelectionRow.BorderColor"), System.Drawing.Color)
        Me.GVDetailFact.Appearance.HideSelectionRow.FontSizeDelta = CType(resources.GetObject("GVDetailFact.Appearance.HideSelectionRow.FontSizeDelta"), Integer)
        Me.GVDetailFact.Appearance.HideSelectionRow.FontStyleDelta = CType(resources.GetObject("GVDetailFact.Appearance.HideSelectionRow.FontStyleDelta"), System.Drawing.FontStyle)
        Me.GVDetailFact.Appearance.HideSelectionRow.ForeColor = CType(resources.GetObject("GVDetailFact.Appearance.HideSelectionRow.ForeColor"), System.Drawing.Color)
        Me.GVDetailFact.Appearance.HideSelectionRow.GradientMode = CType(resources.GetObject("GVDetailFact.Appearance.HideSelectionRow.GradientMode"), System.Drawing.Drawing2D.LinearGradientMode)
        Me.GVDetailFact.Appearance.HideSelectionRow.Image = CType(resources.GetObject("GVDetailFact.Appearance.HideSelectionRow.Image"), System.Drawing.Image)
        Me.GVDetailFact.Appearance.HideSelectionRow.Options.UseBackColor = True
        Me.GVDetailFact.Appearance.HideSelectionRow.Options.UseBorderColor = True
        Me.GVDetailFact.Appearance.HideSelectionRow.Options.UseForeColor = True
        Me.GVDetailFact.Appearance.HorzLine.BackColor = CType(resources.GetObject("GVDetailFact.Appearance.HorzLine.BackColor"), System.Drawing.Color)
        Me.GVDetailFact.Appearance.HorzLine.FontSizeDelta = CType(resources.GetObject("GVDetailFact.Appearance.HorzLine.FontSizeDelta"), Integer)
        Me.GVDetailFact.Appearance.HorzLine.FontStyleDelta = CType(resources.GetObject("GVDetailFact.Appearance.HorzLine.FontStyleDelta"), System.Drawing.FontStyle)
        Me.GVDetailFact.Appearance.HorzLine.GradientMode = CType(resources.GetObject("GVDetailFact.Appearance.HorzLine.GradientMode"), System.Drawing.Drawing2D.LinearGradientMode)
        Me.GVDetailFact.Appearance.HorzLine.Image = CType(resources.GetObject("GVDetailFact.Appearance.HorzLine.Image"), System.Drawing.Image)
        Me.GVDetailFact.Appearance.HorzLine.Options.UseBackColor = True
        Me.GVDetailFact.Appearance.OddRow.BackColor = CType(resources.GetObject("GVDetailFact.Appearance.OddRow.BackColor"), System.Drawing.Color)
        Me.GVDetailFact.Appearance.OddRow.BorderColor = CType(resources.GetObject("GVDetailFact.Appearance.OddRow.BorderColor"), System.Drawing.Color)
        Me.GVDetailFact.Appearance.OddRow.FontSizeDelta = CType(resources.GetObject("GVDetailFact.Appearance.OddRow.FontSizeDelta"), Integer)
        Me.GVDetailFact.Appearance.OddRow.FontStyleDelta = CType(resources.GetObject("GVDetailFact.Appearance.OddRow.FontStyleDelta"), System.Drawing.FontStyle)
        Me.GVDetailFact.Appearance.OddRow.ForeColor = CType(resources.GetObject("GVDetailFact.Appearance.OddRow.ForeColor"), System.Drawing.Color)
        Me.GVDetailFact.Appearance.OddRow.GradientMode = CType(resources.GetObject("GVDetailFact.Appearance.OddRow.GradientMode"), System.Drawing.Drawing2D.LinearGradientMode)
        Me.GVDetailFact.Appearance.OddRow.Image = CType(resources.GetObject("GVDetailFact.Appearance.OddRow.Image"), System.Drawing.Image)
        Me.GVDetailFact.Appearance.OddRow.Options.UseBackColor = True
        Me.GVDetailFact.Appearance.OddRow.Options.UseBorderColor = True
        Me.GVDetailFact.Appearance.OddRow.Options.UseForeColor = True
        Me.GVDetailFact.Appearance.Preview.Font = CType(resources.GetObject("GVDetailFact.Appearance.Preview.Font"), System.Drawing.Font)
        Me.GVDetailFact.Appearance.Preview.FontSizeDelta = CType(resources.GetObject("GVDetailFact.Appearance.Preview.FontSizeDelta"), Integer)
        Me.GVDetailFact.Appearance.Preview.FontStyleDelta = CType(resources.GetObject("GVDetailFact.Appearance.Preview.FontStyleDelta"), System.Drawing.FontStyle)
        Me.GVDetailFact.Appearance.Preview.ForeColor = CType(resources.GetObject("GVDetailFact.Appearance.Preview.ForeColor"), System.Drawing.Color)
        Me.GVDetailFact.Appearance.Preview.GradientMode = CType(resources.GetObject("GVDetailFact.Appearance.Preview.GradientMode"), System.Drawing.Drawing2D.LinearGradientMode)
        Me.GVDetailFact.Appearance.Preview.Image = CType(resources.GetObject("GVDetailFact.Appearance.Preview.Image"), System.Drawing.Image)
        Me.GVDetailFact.Appearance.Preview.Options.UseFont = True
        Me.GVDetailFact.Appearance.Preview.Options.UseForeColor = True
        Me.GVDetailFact.Appearance.Row.BackColor = CType(resources.GetObject("GVDetailFact.Appearance.Row.BackColor"), System.Drawing.Color)
        Me.GVDetailFact.Appearance.Row.FontSizeDelta = CType(resources.GetObject("GVDetailFact.Appearance.Row.FontSizeDelta"), Integer)
        Me.GVDetailFact.Appearance.Row.FontStyleDelta = CType(resources.GetObject("GVDetailFact.Appearance.Row.FontStyleDelta"), System.Drawing.FontStyle)
        Me.GVDetailFact.Appearance.Row.ForeColor = CType(resources.GetObject("GVDetailFact.Appearance.Row.ForeColor"), System.Drawing.Color)
        Me.GVDetailFact.Appearance.Row.GradientMode = CType(resources.GetObject("GVDetailFact.Appearance.Row.GradientMode"), System.Drawing.Drawing2D.LinearGradientMode)
        Me.GVDetailFact.Appearance.Row.Image = CType(resources.GetObject("GVDetailFact.Appearance.Row.Image"), System.Drawing.Image)
        Me.GVDetailFact.Appearance.Row.Options.UseBackColor = True
        Me.GVDetailFact.Appearance.Row.Options.UseForeColor = True
        Me.GVDetailFact.Appearance.RowSeparator.BackColor = CType(resources.GetObject("GVDetailFact.Appearance.RowSeparator.BackColor"), System.Drawing.Color)
        Me.GVDetailFact.Appearance.RowSeparator.BackColor2 = CType(resources.GetObject("GVDetailFact.Appearance.RowSeparator.BackColor2"), System.Drawing.Color)
        Me.GVDetailFact.Appearance.RowSeparator.FontSizeDelta = CType(resources.GetObject("GVDetailFact.Appearance.RowSeparator.FontSizeDelta"), Integer)
        Me.GVDetailFact.Appearance.RowSeparator.FontStyleDelta = CType(resources.GetObject("GVDetailFact.Appearance.RowSeparator.FontStyleDelta"), System.Drawing.FontStyle)
        Me.GVDetailFact.Appearance.RowSeparator.GradientMode = CType(resources.GetObject("GVDetailFact.Appearance.RowSeparator.GradientMode"), System.Drawing.Drawing2D.LinearGradientMode)
        Me.GVDetailFact.Appearance.RowSeparator.Image = CType(resources.GetObject("GVDetailFact.Appearance.RowSeparator.Image"), System.Drawing.Image)
        Me.GVDetailFact.Appearance.RowSeparator.Options.UseBackColor = True
        Me.GVDetailFact.Appearance.SelectedRow.BackColor = CType(resources.GetObject("GVDetailFact.Appearance.SelectedRow.BackColor"), System.Drawing.Color)
        Me.GVDetailFact.Appearance.SelectedRow.FontSizeDelta = CType(resources.GetObject("GVDetailFact.Appearance.SelectedRow.FontSizeDelta"), Integer)
        Me.GVDetailFact.Appearance.SelectedRow.FontStyleDelta = CType(resources.GetObject("GVDetailFact.Appearance.SelectedRow.FontStyleDelta"), System.Drawing.FontStyle)
        Me.GVDetailFact.Appearance.SelectedRow.ForeColor = CType(resources.GetObject("GVDetailFact.Appearance.SelectedRow.ForeColor"), System.Drawing.Color)
        Me.GVDetailFact.Appearance.SelectedRow.GradientMode = CType(resources.GetObject("GVDetailFact.Appearance.SelectedRow.GradientMode"), System.Drawing.Drawing2D.LinearGradientMode)
        Me.GVDetailFact.Appearance.SelectedRow.Image = CType(resources.GetObject("GVDetailFact.Appearance.SelectedRow.Image"), System.Drawing.Image)
        Me.GVDetailFact.Appearance.SelectedRow.Options.UseBackColor = True
        Me.GVDetailFact.Appearance.SelectedRow.Options.UseForeColor = True
        Me.GVDetailFact.Appearance.TopNewRow.BackColor = CType(resources.GetObject("GVDetailFact.Appearance.TopNewRow.BackColor"), System.Drawing.Color)
        Me.GVDetailFact.Appearance.TopNewRow.FontSizeDelta = CType(resources.GetObject("GVDetailFact.Appearance.TopNewRow.FontSizeDelta"), Integer)
        Me.GVDetailFact.Appearance.TopNewRow.FontStyleDelta = CType(resources.GetObject("GVDetailFact.Appearance.TopNewRow.FontStyleDelta"), System.Drawing.FontStyle)
        Me.GVDetailFact.Appearance.TopNewRow.GradientMode = CType(resources.GetObject("GVDetailFact.Appearance.TopNewRow.GradientMode"), System.Drawing.Drawing2D.LinearGradientMode)
        Me.GVDetailFact.Appearance.TopNewRow.Image = CType(resources.GetObject("GVDetailFact.Appearance.TopNewRow.Image"), System.Drawing.Image)
        Me.GVDetailFact.Appearance.TopNewRow.Options.UseBackColor = True
        Me.GVDetailFact.Appearance.VertLine.BackColor = CType(resources.GetObject("GVDetailFact.Appearance.VertLine.BackColor"), System.Drawing.Color)
        Me.GVDetailFact.Appearance.VertLine.FontSizeDelta = CType(resources.GetObject("GVDetailFact.Appearance.VertLine.FontSizeDelta"), Integer)
        Me.GVDetailFact.Appearance.VertLine.FontStyleDelta = CType(resources.GetObject("GVDetailFact.Appearance.VertLine.FontStyleDelta"), System.Drawing.FontStyle)
        Me.GVDetailFact.Appearance.VertLine.GradientMode = CType(resources.GetObject("GVDetailFact.Appearance.VertLine.GradientMode"), System.Drawing.Drawing2D.LinearGradientMode)
        Me.GVDetailFact.Appearance.VertLine.Image = CType(resources.GetObject("GVDetailFact.Appearance.VertLine.Image"), System.Drawing.Image)
        Me.GVDetailFact.Appearance.VertLine.Options.UseBackColor = True
        resources.ApplyResources(Me.GVDetailFact, "GVDetailFact")
        Me.GVDetailFact.Columns.AddRange(New DevExpress.XtraGrid.Columns.GridColumn() {Me.GColDFACDAT, Me.GColNFACNUM, Me.GColVCLINOM, Me.GColNDINNUM, Me.GColNELFTHT, Me.TECHNICIEN})
        Me.GVDetailFact.GridControl = Me.GCDetailFact
        Me.GVDetailFact.Name = "GVDetailFact"
        Me.GVDetailFact.OptionsBehavior.Editable = False
        Me.GVDetailFact.OptionsBehavior.ReadOnly = True
        Me.GVDetailFact.OptionsView.EnableAppearanceEvenRow = True
        Me.GVDetailFact.OptionsView.EnableAppearanceOddRow = True
        Me.GVDetailFact.OptionsView.ShowFooter = True
        Me.GVDetailFact.OptionsView.ShowGroupPanel = False
        '
        'GColDFACDAT
        '
        Me.GColDFACDAT.AppearanceCell.FontSizeDelta = CType(resources.GetObject("GColDFACDAT.AppearanceCell.FontSizeDelta"), Integer)
        Me.GColDFACDAT.AppearanceCell.FontStyleDelta = CType(resources.GetObject("GColDFACDAT.AppearanceCell.FontStyleDelta"), System.Drawing.FontStyle)
        Me.GColDFACDAT.AppearanceCell.GradientMode = CType(resources.GetObject("GColDFACDAT.AppearanceCell.GradientMode"), System.Drawing.Drawing2D.LinearGradientMode)
        Me.GColDFACDAT.AppearanceCell.Image = CType(resources.GetObject("GColDFACDAT.AppearanceCell.Image"), System.Drawing.Image)
        Me.GColDFACDAT.AppearanceCell.Options.UseTextOptions = True
        Me.GColDFACDAT.AppearanceCell.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center
        Me.GColDFACDAT.AppearanceCell.TextOptions.VAlignment = DevExpress.Utils.VertAlignment.Center
        Me.GColDFACDAT.AppearanceHeader.Font = CType(resources.GetObject("GColDFACDAT.AppearanceHeader.Font"), System.Drawing.Font)
        Me.GColDFACDAT.AppearanceHeader.FontSizeDelta = CType(resources.GetObject("GColDFACDAT.AppearanceHeader.FontSizeDelta"), Integer)
        Me.GColDFACDAT.AppearanceHeader.FontStyleDelta = CType(resources.GetObject("GColDFACDAT.AppearanceHeader.FontStyleDelta"), System.Drawing.FontStyle)
        Me.GColDFACDAT.AppearanceHeader.GradientMode = CType(resources.GetObject("GColDFACDAT.AppearanceHeader.GradientMode"), System.Drawing.Drawing2D.LinearGradientMode)
        Me.GColDFACDAT.AppearanceHeader.Image = CType(resources.GetObject("GColDFACDAT.AppearanceHeader.Image"), System.Drawing.Image)
        Me.GColDFACDAT.AppearanceHeader.Options.UseFont = True
        Me.GColDFACDAT.AppearanceHeader.Options.UseTextOptions = True
        Me.GColDFACDAT.AppearanceHeader.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center
        Me.GColDFACDAT.AppearanceHeader.TextOptions.VAlignment = DevExpress.Utils.VertAlignment.Center
        resources.ApplyResources(Me.GColDFACDAT, "GColDFACDAT")
        Me.GColDFACDAT.FieldName = "DFACDAT"
        Me.GColDFACDAT.Name = "GColDFACDAT"
        '
        'GColNFACNUM
        '
        Me.GColNFACNUM.AppearanceCell.FontSizeDelta = CType(resources.GetObject("GColNFACNUM.AppearanceCell.FontSizeDelta"), Integer)
        Me.GColNFACNUM.AppearanceCell.FontStyleDelta = CType(resources.GetObject("GColNFACNUM.AppearanceCell.FontStyleDelta"), System.Drawing.FontStyle)
        Me.GColNFACNUM.AppearanceCell.GradientMode = CType(resources.GetObject("GColNFACNUM.AppearanceCell.GradientMode"), System.Drawing.Drawing2D.LinearGradientMode)
        Me.GColNFACNUM.AppearanceCell.Image = CType(resources.GetObject("GColNFACNUM.AppearanceCell.Image"), System.Drawing.Image)
        Me.GColNFACNUM.AppearanceCell.Options.UseTextOptions = True
        Me.GColNFACNUM.AppearanceCell.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center
        Me.GColNFACNUM.AppearanceCell.TextOptions.VAlignment = DevExpress.Utils.VertAlignment.Center
        Me.GColNFACNUM.AppearanceHeader.Font = CType(resources.GetObject("GColNFACNUM.AppearanceHeader.Font"), System.Drawing.Font)
        Me.GColNFACNUM.AppearanceHeader.FontSizeDelta = CType(resources.GetObject("GColNFACNUM.AppearanceHeader.FontSizeDelta"), Integer)
        Me.GColNFACNUM.AppearanceHeader.FontStyleDelta = CType(resources.GetObject("GColNFACNUM.AppearanceHeader.FontStyleDelta"), System.Drawing.FontStyle)
        Me.GColNFACNUM.AppearanceHeader.GradientMode = CType(resources.GetObject("GColNFACNUM.AppearanceHeader.GradientMode"), System.Drawing.Drawing2D.LinearGradientMode)
        Me.GColNFACNUM.AppearanceHeader.Image = CType(resources.GetObject("GColNFACNUM.AppearanceHeader.Image"), System.Drawing.Image)
        Me.GColNFACNUM.AppearanceHeader.Options.UseFont = True
        Me.GColNFACNUM.AppearanceHeader.Options.UseTextOptions = True
        Me.GColNFACNUM.AppearanceHeader.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center
        Me.GColNFACNUM.AppearanceHeader.TextOptions.VAlignment = DevExpress.Utils.VertAlignment.Center
        resources.ApplyResources(Me.GColNFACNUM, "GColNFACNUM")
        Me.GColNFACNUM.FieldName = "NFACNUM"
        Me.GColNFACNUM.Name = "GColNFACNUM"
        '
        'GColVCLINOM
        '
        Me.GColVCLINOM.AppearanceCell.FontSizeDelta = CType(resources.GetObject("GColVCLINOM.AppearanceCell.FontSizeDelta"), Integer)
        Me.GColVCLINOM.AppearanceCell.FontStyleDelta = CType(resources.GetObject("GColVCLINOM.AppearanceCell.FontStyleDelta"), System.Drawing.FontStyle)
        Me.GColVCLINOM.AppearanceCell.GradientMode = CType(resources.GetObject("GColVCLINOM.AppearanceCell.GradientMode"), System.Drawing.Drawing2D.LinearGradientMode)
        Me.GColVCLINOM.AppearanceCell.Image = CType(resources.GetObject("GColVCLINOM.AppearanceCell.Image"), System.Drawing.Image)
        Me.GColVCLINOM.AppearanceCell.Options.UseTextOptions = True
        Me.GColVCLINOM.AppearanceCell.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center
        Me.GColVCLINOM.AppearanceCell.TextOptions.VAlignment = DevExpress.Utils.VertAlignment.Center
        Me.GColVCLINOM.AppearanceHeader.Font = CType(resources.GetObject("GColVCLINOM.AppearanceHeader.Font"), System.Drawing.Font)
        Me.GColVCLINOM.AppearanceHeader.FontSizeDelta = CType(resources.GetObject("GColVCLINOM.AppearanceHeader.FontSizeDelta"), Integer)
        Me.GColVCLINOM.AppearanceHeader.FontStyleDelta = CType(resources.GetObject("GColVCLINOM.AppearanceHeader.FontStyleDelta"), System.Drawing.FontStyle)
        Me.GColVCLINOM.AppearanceHeader.GradientMode = CType(resources.GetObject("GColVCLINOM.AppearanceHeader.GradientMode"), System.Drawing.Drawing2D.LinearGradientMode)
        Me.GColVCLINOM.AppearanceHeader.Image = CType(resources.GetObject("GColVCLINOM.AppearanceHeader.Image"), System.Drawing.Image)
        Me.GColVCLINOM.AppearanceHeader.Options.UseFont = True
        Me.GColVCLINOM.AppearanceHeader.Options.UseTextOptions = True
        Me.GColVCLINOM.AppearanceHeader.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center
        Me.GColVCLINOM.AppearanceHeader.TextOptions.VAlignment = DevExpress.Utils.VertAlignment.Center
        resources.ApplyResources(Me.GColVCLINOM, "GColVCLINOM")
        Me.GColVCLINOM.FieldName = "VCLINOM"
        Me.GColVCLINOM.Name = "GColVCLINOM"
        '
        'GColNDINNUM
        '
        Me.GColNDINNUM.AppearanceHeader.Font = CType(resources.GetObject("GColNDINNUM.AppearanceHeader.Font"), System.Drawing.Font)
        Me.GColNDINNUM.AppearanceHeader.FontSizeDelta = CType(resources.GetObject("GColNDINNUM.AppearanceHeader.FontSizeDelta"), Integer)
        Me.GColNDINNUM.AppearanceHeader.FontStyleDelta = CType(resources.GetObject("GColNDINNUM.AppearanceHeader.FontStyleDelta"), System.Drawing.FontStyle)
        Me.GColNDINNUM.AppearanceHeader.GradientMode = CType(resources.GetObject("GColNDINNUM.AppearanceHeader.GradientMode"), System.Drawing.Drawing2D.LinearGradientMode)
        Me.GColNDINNUM.AppearanceHeader.Image = CType(resources.GetObject("GColNDINNUM.AppearanceHeader.Image"), System.Drawing.Image)
        Me.GColNDINNUM.AppearanceHeader.Options.UseFont = True
        Me.GColNDINNUM.AppearanceHeader.Options.UseTextOptions = True
        Me.GColNDINNUM.AppearanceHeader.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center
        Me.GColNDINNUM.AppearanceHeader.TextOptions.VAlignment = DevExpress.Utils.VertAlignment.Center
        resources.ApplyResources(Me.GColNDINNUM, "GColNDINNUM")
        Me.GColNDINNUM.FieldName = "NDINNUM"
        Me.GColNDINNUM.Name = "GColNDINNUM"
        '
        'GColNELFTHT
        '
        Me.GColNELFTHT.AppearanceHeader.Font = CType(resources.GetObject("GColNELFTHT.AppearanceHeader.Font"), System.Drawing.Font)
        Me.GColNELFTHT.AppearanceHeader.FontSizeDelta = CType(resources.GetObject("GColNELFTHT.AppearanceHeader.FontSizeDelta"), Integer)
        Me.GColNELFTHT.AppearanceHeader.FontStyleDelta = CType(resources.GetObject("GColNELFTHT.AppearanceHeader.FontStyleDelta"), System.Drawing.FontStyle)
        Me.GColNELFTHT.AppearanceHeader.GradientMode = CType(resources.GetObject("GColNELFTHT.AppearanceHeader.GradientMode"), System.Drawing.Drawing2D.LinearGradientMode)
        Me.GColNELFTHT.AppearanceHeader.Image = CType(resources.GetObject("GColNELFTHT.AppearanceHeader.Image"), System.Drawing.Image)
        Me.GColNELFTHT.AppearanceHeader.Options.UseFont = True
        Me.GColNELFTHT.AppearanceHeader.Options.UseTextOptions = True
        Me.GColNELFTHT.AppearanceHeader.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center
        Me.GColNELFTHT.AppearanceHeader.TextOptions.VAlignment = DevExpress.Utils.VertAlignment.Center
        resources.ApplyResources(Me.GColNELFTHT, "GColNELFTHT")
        Me.GColNELFTHT.DisplayFormat.FormatString = "c0"
        Me.GColNELFTHT.DisplayFormat.FormatType = DevExpress.Utils.FormatType.Numeric
        Me.GColNELFTHT.FieldName = "NELFTHT"
        Me.GColNELFTHT.Name = "GColNELFTHT"
        Me.GColNELFTHT.Summary.AddRange(New DevExpress.XtraGrid.GridSummaryItem() {New DevExpress.XtraGrid.GridColumnSummaryItem(CType(resources.GetObject("GColNELFTHT.Summary"), DevExpress.Data.SummaryItemType), resources.GetString("GColNELFTHT.Summary1"), resources.GetString("GColNELFTHT.Summary2"))})
        '
        'TECHNICIEN
        '
        resources.ApplyResources(Me.TECHNICIEN, "TECHNICIEN")
        Me.TECHNICIEN.FieldName = "TECHNICIEN"
        Me.TECHNICIEN.Name = "TECHNICIEN"
        '
        'frmFactEI_DetailBySem
        '
        resources.ApplyResources(Me, "$this")
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.Controls.Add(Me.GCDetailFact)
        Me.Name = "frmFactEI_DetailBySem"
        CType(Me.GCDetailFact, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.GVDetailFact, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)

    End Sub

    Private WithEvents GCDetailFact As DevExpress.XtraGrid.GridControl
    Private WithEvents GVDetailFact As DevExpress.XtraGrid.Views.Grid.GridView
    Private WithEvents GColNFACNUM As DevExpress.XtraGrid.Columns.GridColumn
    Private WithEvents GColNDINNUM As DevExpress.XtraGrid.Columns.GridColumn
    Private WithEvents GColNELFTHT As DevExpress.XtraGrid.Columns.GridColumn
    Private WithEvents GColVCLINOM As DevExpress.XtraGrid.Columns.GridColumn
    Private WithEvents GColDFACDAT As DevExpress.XtraGrid.Columns.GridColumn
    Private WithEvents TECHNICIEN As DevExpress.XtraGrid.Columns.GridColumn
End Class
