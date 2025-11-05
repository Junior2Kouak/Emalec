<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmGTPAudit
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(frmGTPAudit))
        Me.GrpAction = New System.Windows.Forms.GroupBox()
        Me.BtnDetail = New System.Windows.Forms.Button()
        Me.BtnQuit = New System.Windows.Forms.Button()
        Me.GrpBoxEquip = New System.Windows.Forms.GroupBox()
        Me.GCGTPAUDIT = New DevExpress.XtraGrid.GridControl()
        Me.GVGTPAUDIT = New DevExpress.XtraGrid.Views.Grid.GridView()
        Me.ColSitNGTPAUDITLID = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.ColSitNGTPAUDITID = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.ColSitNSITNUM = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.ColSitNGTPMAINID = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.ColSitVGTPZONENOM = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.ColSitVGTPLOTNOM = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.ColSitVGTPEQUIP = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.ColSitVGTPPRECIS = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.ColSitVGTPUNITENOM = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.ColSitNGTPSITINSTANNEE = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.ColSitNGTPSITQTE = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.ColSitVGTPSITOBS = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.GrpAction.SuspendLayout()
        Me.GrpBoxEquip.SuspendLayout()
        CType(Me.GCGTPAUDIT, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.GVGTPAUDIT, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'GrpAction
        '
        resources.ApplyResources(Me.GrpAction, "GrpAction")
        Me.GrpAction.Controls.Add(Me.BtnDetail)
        Me.GrpAction.Controls.Add(Me.BtnQuit)
        Me.GrpAction.Name = "GrpAction"
        Me.GrpAction.TabStop = False
        '
        'BtnDetail
        '
        resources.ApplyResources(Me.BtnDetail, "BtnDetail")
        Me.BtnDetail.Name = "BtnDetail"
        Me.BtnDetail.UseVisualStyleBackColor = True
        '
        'BtnQuit
        '
        resources.ApplyResources(Me.BtnQuit, "BtnQuit")
        Me.BtnQuit.Name = "BtnQuit"
        Me.BtnQuit.UseVisualStyleBackColor = True
        '
        'GrpBoxEquip
        '
        resources.ApplyResources(Me.GrpBoxEquip, "GrpBoxEquip")
        Me.GrpBoxEquip.Controls.Add(Me.GCGTPAUDIT)
        Me.GrpBoxEquip.Name = "GrpBoxEquip"
        Me.GrpBoxEquip.TabStop = False
        '
        'GCGTPAUDIT
        '
        resources.ApplyResources(Me.GCGTPAUDIT, "GCGTPAUDIT")
        '
        '
        '
        Me.GCGTPAUDIT.EmbeddedNavigator.AccessibleDescription = resources.GetString("GCGTPAUDIT.EmbeddedNavigator.AccessibleDescription")
        Me.GCGTPAUDIT.EmbeddedNavigator.AccessibleName = resources.GetString("GCGTPAUDIT.EmbeddedNavigator.AccessibleName")
        Me.GCGTPAUDIT.EmbeddedNavigator.AllowHtmlTextInToolTip = CType(resources.GetObject("GCGTPAUDIT.EmbeddedNavigator.AllowHtmlTextInToolTip"), DevExpress.Utils.DefaultBoolean)
        Me.GCGTPAUDIT.EmbeddedNavigator.Anchor = CType(resources.GetObject("GCGTPAUDIT.EmbeddedNavigator.Anchor"), System.Windows.Forms.AnchorStyles)
        Me.GCGTPAUDIT.EmbeddedNavigator.BackgroundImage = CType(resources.GetObject("GCGTPAUDIT.EmbeddedNavigator.BackgroundImage"), System.Drawing.Image)
        Me.GCGTPAUDIT.EmbeddedNavigator.BackgroundImageLayout = CType(resources.GetObject("GCGTPAUDIT.EmbeddedNavigator.BackgroundImageLayout"), System.Windows.Forms.ImageLayout)
        Me.GCGTPAUDIT.EmbeddedNavigator.ImeMode = CType(resources.GetObject("GCGTPAUDIT.EmbeddedNavigator.ImeMode"), System.Windows.Forms.ImeMode)
        Me.GCGTPAUDIT.EmbeddedNavigator.MaximumSize = CType(resources.GetObject("GCGTPAUDIT.EmbeddedNavigator.MaximumSize"), System.Drawing.Size)
        Me.GCGTPAUDIT.EmbeddedNavigator.TextLocation = CType(resources.GetObject("GCGTPAUDIT.EmbeddedNavigator.TextLocation"), DevExpress.XtraEditors.NavigatorButtonsTextLocation)
        Me.GCGTPAUDIT.EmbeddedNavigator.ToolTip = resources.GetString("GCGTPAUDIT.EmbeddedNavigator.ToolTip")
        Me.GCGTPAUDIT.EmbeddedNavigator.ToolTipIconType = CType(resources.GetObject("GCGTPAUDIT.EmbeddedNavigator.ToolTipIconType"), DevExpress.Utils.ToolTipIconType)
        Me.GCGTPAUDIT.EmbeddedNavigator.ToolTipTitle = resources.GetString("GCGTPAUDIT.EmbeddedNavigator.ToolTipTitle")
        Me.GCGTPAUDIT.MainView = Me.GVGTPAUDIT
        Me.GCGTPAUDIT.Name = "GCGTPAUDIT"
        Me.GCGTPAUDIT.ViewCollection.AddRange(New DevExpress.XtraGrid.Views.Base.BaseView() {Me.GVGTPAUDIT})
        '
        'GVGTPAUDIT
        '
        Me.GVGTPAUDIT.Appearance.ColumnFilterButton.BackColor = CType(resources.GetObject("GVGTPAUDIT.Appearance.ColumnFilterButton.BackColor"), System.Drawing.Color)
        Me.GVGTPAUDIT.Appearance.ColumnFilterButton.BackColor2 = CType(resources.GetObject("GVGTPAUDIT.Appearance.ColumnFilterButton.BackColor2"), System.Drawing.Color)
        Me.GVGTPAUDIT.Appearance.ColumnFilterButton.BorderColor = CType(resources.GetObject("GVGTPAUDIT.Appearance.ColumnFilterButton.BorderColor"), System.Drawing.Color)
        Me.GVGTPAUDIT.Appearance.ColumnFilterButton.FontSizeDelta = CType(resources.GetObject("GVGTPAUDIT.Appearance.ColumnFilterButton.FontSizeDelta"), Integer)
        Me.GVGTPAUDIT.Appearance.ColumnFilterButton.FontStyleDelta = CType(resources.GetObject("GVGTPAUDIT.Appearance.ColumnFilterButton.FontStyleDelta"), System.Drawing.FontStyle)
        Me.GVGTPAUDIT.Appearance.ColumnFilterButton.ForeColor = CType(resources.GetObject("GVGTPAUDIT.Appearance.ColumnFilterButton.ForeColor"), System.Drawing.Color)
        Me.GVGTPAUDIT.Appearance.ColumnFilterButton.GradientMode = CType(resources.GetObject("GVGTPAUDIT.Appearance.ColumnFilterButton.GradientMode"), System.Drawing.Drawing2D.LinearGradientMode)
        Me.GVGTPAUDIT.Appearance.ColumnFilterButton.Image = CType(resources.GetObject("GVGTPAUDIT.Appearance.ColumnFilterButton.Image"), System.Drawing.Image)
        Me.GVGTPAUDIT.Appearance.ColumnFilterButton.Options.UseBackColor = True
        Me.GVGTPAUDIT.Appearance.ColumnFilterButton.Options.UseBorderColor = True
        Me.GVGTPAUDIT.Appearance.ColumnFilterButton.Options.UseForeColor = True
        Me.GVGTPAUDIT.Appearance.ColumnFilterButtonActive.BackColor = CType(resources.GetObject("GVGTPAUDIT.Appearance.ColumnFilterButtonActive.BackColor"), System.Drawing.Color)
        Me.GVGTPAUDIT.Appearance.ColumnFilterButtonActive.BackColor2 = CType(resources.GetObject("GVGTPAUDIT.Appearance.ColumnFilterButtonActive.BackColor2"), System.Drawing.Color)
        Me.GVGTPAUDIT.Appearance.ColumnFilterButtonActive.BorderColor = CType(resources.GetObject("GVGTPAUDIT.Appearance.ColumnFilterButtonActive.BorderColor"), System.Drawing.Color)
        Me.GVGTPAUDIT.Appearance.ColumnFilterButtonActive.FontSizeDelta = CType(resources.GetObject("GVGTPAUDIT.Appearance.ColumnFilterButtonActive.FontSizeDelta"), Integer)
        Me.GVGTPAUDIT.Appearance.ColumnFilterButtonActive.FontStyleDelta = CType(resources.GetObject("GVGTPAUDIT.Appearance.ColumnFilterButtonActive.FontStyleDelta"), System.Drawing.FontStyle)
        Me.GVGTPAUDIT.Appearance.ColumnFilterButtonActive.ForeColor = CType(resources.GetObject("GVGTPAUDIT.Appearance.ColumnFilterButtonActive.ForeColor"), System.Drawing.Color)
        Me.GVGTPAUDIT.Appearance.ColumnFilterButtonActive.GradientMode = CType(resources.GetObject("GVGTPAUDIT.Appearance.ColumnFilterButtonActive.GradientMode"), System.Drawing.Drawing2D.LinearGradientMode)
        Me.GVGTPAUDIT.Appearance.ColumnFilterButtonActive.Image = CType(resources.GetObject("GVGTPAUDIT.Appearance.ColumnFilterButtonActive.Image"), System.Drawing.Image)
        Me.GVGTPAUDIT.Appearance.ColumnFilterButtonActive.Options.UseBackColor = True
        Me.GVGTPAUDIT.Appearance.ColumnFilterButtonActive.Options.UseBorderColor = True
        Me.GVGTPAUDIT.Appearance.ColumnFilterButtonActive.Options.UseForeColor = True
        Me.GVGTPAUDIT.Appearance.Empty.BackColor = CType(resources.GetObject("GVGTPAUDIT.Appearance.Empty.BackColor"), System.Drawing.Color)
        Me.GVGTPAUDIT.Appearance.Empty.FontSizeDelta = CType(resources.GetObject("GVGTPAUDIT.Appearance.Empty.FontSizeDelta"), Integer)
        Me.GVGTPAUDIT.Appearance.Empty.FontStyleDelta = CType(resources.GetObject("GVGTPAUDIT.Appearance.Empty.FontStyleDelta"), System.Drawing.FontStyle)
        Me.GVGTPAUDIT.Appearance.Empty.GradientMode = CType(resources.GetObject("GVGTPAUDIT.Appearance.Empty.GradientMode"), System.Drawing.Drawing2D.LinearGradientMode)
        Me.GVGTPAUDIT.Appearance.Empty.Image = CType(resources.GetObject("GVGTPAUDIT.Appearance.Empty.Image"), System.Drawing.Image)
        Me.GVGTPAUDIT.Appearance.Empty.Options.UseBackColor = True
        Me.GVGTPAUDIT.Appearance.EvenRow.BackColor = CType(resources.GetObject("GVGTPAUDIT.Appearance.EvenRow.BackColor"), System.Drawing.Color)
        Me.GVGTPAUDIT.Appearance.EvenRow.FontSizeDelta = CType(resources.GetObject("GVGTPAUDIT.Appearance.EvenRow.FontSizeDelta"), Integer)
        Me.GVGTPAUDIT.Appearance.EvenRow.FontStyleDelta = CType(resources.GetObject("GVGTPAUDIT.Appearance.EvenRow.FontStyleDelta"), System.Drawing.FontStyle)
        Me.GVGTPAUDIT.Appearance.EvenRow.ForeColor = CType(resources.GetObject("GVGTPAUDIT.Appearance.EvenRow.ForeColor"), System.Drawing.Color)
        Me.GVGTPAUDIT.Appearance.EvenRow.GradientMode = CType(resources.GetObject("GVGTPAUDIT.Appearance.EvenRow.GradientMode"), System.Drawing.Drawing2D.LinearGradientMode)
        Me.GVGTPAUDIT.Appearance.EvenRow.Image = CType(resources.GetObject("GVGTPAUDIT.Appearance.EvenRow.Image"), System.Drawing.Image)
        Me.GVGTPAUDIT.Appearance.EvenRow.Options.UseBackColor = True
        Me.GVGTPAUDIT.Appearance.EvenRow.Options.UseForeColor = True
        Me.GVGTPAUDIT.Appearance.FilterCloseButton.BackColor = CType(resources.GetObject("GVGTPAUDIT.Appearance.FilterCloseButton.BackColor"), System.Drawing.Color)
        Me.GVGTPAUDIT.Appearance.FilterCloseButton.BackColor2 = CType(resources.GetObject("GVGTPAUDIT.Appearance.FilterCloseButton.BackColor2"), System.Drawing.Color)
        Me.GVGTPAUDIT.Appearance.FilterCloseButton.BorderColor = CType(resources.GetObject("GVGTPAUDIT.Appearance.FilterCloseButton.BorderColor"), System.Drawing.Color)
        Me.GVGTPAUDIT.Appearance.FilterCloseButton.FontSizeDelta = CType(resources.GetObject("GVGTPAUDIT.Appearance.FilterCloseButton.FontSizeDelta"), Integer)
        Me.GVGTPAUDIT.Appearance.FilterCloseButton.FontStyleDelta = CType(resources.GetObject("GVGTPAUDIT.Appearance.FilterCloseButton.FontStyleDelta"), System.Drawing.FontStyle)
        Me.GVGTPAUDIT.Appearance.FilterCloseButton.GradientMode = CType(resources.GetObject("GVGTPAUDIT.Appearance.FilterCloseButton.GradientMode"), System.Drawing.Drawing2D.LinearGradientMode)
        Me.GVGTPAUDIT.Appearance.FilterCloseButton.Image = CType(resources.GetObject("GVGTPAUDIT.Appearance.FilterCloseButton.Image"), System.Drawing.Image)
        Me.GVGTPAUDIT.Appearance.FilterCloseButton.Options.UseBackColor = True
        Me.GVGTPAUDIT.Appearance.FilterCloseButton.Options.UseBorderColor = True
        Me.GVGTPAUDIT.Appearance.FilterPanel.BackColor = CType(resources.GetObject("GVGTPAUDIT.Appearance.FilterPanel.BackColor"), System.Drawing.Color)
        Me.GVGTPAUDIT.Appearance.FilterPanel.FontSizeDelta = CType(resources.GetObject("GVGTPAUDIT.Appearance.FilterPanel.FontSizeDelta"), Integer)
        Me.GVGTPAUDIT.Appearance.FilterPanel.FontStyleDelta = CType(resources.GetObject("GVGTPAUDIT.Appearance.FilterPanel.FontStyleDelta"), System.Drawing.FontStyle)
        Me.GVGTPAUDIT.Appearance.FilterPanel.ForeColor = CType(resources.GetObject("GVGTPAUDIT.Appearance.FilterPanel.ForeColor"), System.Drawing.Color)
        Me.GVGTPAUDIT.Appearance.FilterPanel.GradientMode = CType(resources.GetObject("GVGTPAUDIT.Appearance.FilterPanel.GradientMode"), System.Drawing.Drawing2D.LinearGradientMode)
        Me.GVGTPAUDIT.Appearance.FilterPanel.Image = CType(resources.GetObject("GVGTPAUDIT.Appearance.FilterPanel.Image"), System.Drawing.Image)
        Me.GVGTPAUDIT.Appearance.FilterPanel.Options.UseBackColor = True
        Me.GVGTPAUDIT.Appearance.FilterPanel.Options.UseForeColor = True
        Me.GVGTPAUDIT.Appearance.FixedLine.BackColor = CType(resources.GetObject("GVGTPAUDIT.Appearance.FixedLine.BackColor"), System.Drawing.Color)
        Me.GVGTPAUDIT.Appearance.FixedLine.FontSizeDelta = CType(resources.GetObject("GVGTPAUDIT.Appearance.FixedLine.FontSizeDelta"), Integer)
        Me.GVGTPAUDIT.Appearance.FixedLine.FontStyleDelta = CType(resources.GetObject("GVGTPAUDIT.Appearance.FixedLine.FontStyleDelta"), System.Drawing.FontStyle)
        Me.GVGTPAUDIT.Appearance.FixedLine.GradientMode = CType(resources.GetObject("GVGTPAUDIT.Appearance.FixedLine.GradientMode"), System.Drawing.Drawing2D.LinearGradientMode)
        Me.GVGTPAUDIT.Appearance.FixedLine.Image = CType(resources.GetObject("GVGTPAUDIT.Appearance.FixedLine.Image"), System.Drawing.Image)
        Me.GVGTPAUDIT.Appearance.FixedLine.Options.UseBackColor = True
        Me.GVGTPAUDIT.Appearance.FocusedRow.BackColor = CType(resources.GetObject("GVGTPAUDIT.Appearance.FocusedRow.BackColor"), System.Drawing.Color)
        Me.GVGTPAUDIT.Appearance.FocusedRow.FontSizeDelta = CType(resources.GetObject("GVGTPAUDIT.Appearance.FocusedRow.FontSizeDelta"), Integer)
        Me.GVGTPAUDIT.Appearance.FocusedRow.FontStyleDelta = CType(resources.GetObject("GVGTPAUDIT.Appearance.FocusedRow.FontStyleDelta"), System.Drawing.FontStyle)
        Me.GVGTPAUDIT.Appearance.FocusedRow.ForeColor = CType(resources.GetObject("GVGTPAUDIT.Appearance.FocusedRow.ForeColor"), System.Drawing.Color)
        Me.GVGTPAUDIT.Appearance.FocusedRow.GradientMode = CType(resources.GetObject("GVGTPAUDIT.Appearance.FocusedRow.GradientMode"), System.Drawing.Drawing2D.LinearGradientMode)
        Me.GVGTPAUDIT.Appearance.FocusedRow.Image = CType(resources.GetObject("GVGTPAUDIT.Appearance.FocusedRow.Image"), System.Drawing.Image)
        Me.GVGTPAUDIT.Appearance.FocusedRow.Options.UseBackColor = True
        Me.GVGTPAUDIT.Appearance.FocusedRow.Options.UseForeColor = True
        Me.GVGTPAUDIT.Appearance.FooterPanel.BackColor = CType(resources.GetObject("GVGTPAUDIT.Appearance.FooterPanel.BackColor"), System.Drawing.Color)
        Me.GVGTPAUDIT.Appearance.FooterPanel.BackColor2 = CType(resources.GetObject("GVGTPAUDIT.Appearance.FooterPanel.BackColor2"), System.Drawing.Color)
        Me.GVGTPAUDIT.Appearance.FooterPanel.BorderColor = CType(resources.GetObject("GVGTPAUDIT.Appearance.FooterPanel.BorderColor"), System.Drawing.Color)
        Me.GVGTPAUDIT.Appearance.FooterPanel.FontSizeDelta = CType(resources.GetObject("GVGTPAUDIT.Appearance.FooterPanel.FontSizeDelta"), Integer)
        Me.GVGTPAUDIT.Appearance.FooterPanel.FontStyleDelta = CType(resources.GetObject("GVGTPAUDIT.Appearance.FooterPanel.FontStyleDelta"), System.Drawing.FontStyle)
        Me.GVGTPAUDIT.Appearance.FooterPanel.GradientMode = CType(resources.GetObject("GVGTPAUDIT.Appearance.FooterPanel.GradientMode"), System.Drawing.Drawing2D.LinearGradientMode)
        Me.GVGTPAUDIT.Appearance.FooterPanel.Image = CType(resources.GetObject("GVGTPAUDIT.Appearance.FooterPanel.Image"), System.Drawing.Image)
        Me.GVGTPAUDIT.Appearance.FooterPanel.Options.UseBackColor = True
        Me.GVGTPAUDIT.Appearance.FooterPanel.Options.UseBorderColor = True
        Me.GVGTPAUDIT.Appearance.GroupButton.BackColor = CType(resources.GetObject("GVGTPAUDIT.Appearance.GroupButton.BackColor"), System.Drawing.Color)
        Me.GVGTPAUDIT.Appearance.GroupButton.BorderColor = CType(resources.GetObject("GVGTPAUDIT.Appearance.GroupButton.BorderColor"), System.Drawing.Color)
        Me.GVGTPAUDIT.Appearance.GroupButton.FontSizeDelta = CType(resources.GetObject("GVGTPAUDIT.Appearance.GroupButton.FontSizeDelta"), Integer)
        Me.GVGTPAUDIT.Appearance.GroupButton.FontStyleDelta = CType(resources.GetObject("GVGTPAUDIT.Appearance.GroupButton.FontStyleDelta"), System.Drawing.FontStyle)
        Me.GVGTPAUDIT.Appearance.GroupButton.ForeColor = CType(resources.GetObject("GVGTPAUDIT.Appearance.GroupButton.ForeColor"), System.Drawing.Color)
        Me.GVGTPAUDIT.Appearance.GroupButton.GradientMode = CType(resources.GetObject("GVGTPAUDIT.Appearance.GroupButton.GradientMode"), System.Drawing.Drawing2D.LinearGradientMode)
        Me.GVGTPAUDIT.Appearance.GroupButton.Image = CType(resources.GetObject("GVGTPAUDIT.Appearance.GroupButton.Image"), System.Drawing.Image)
        Me.GVGTPAUDIT.Appearance.GroupButton.Options.UseBackColor = True
        Me.GVGTPAUDIT.Appearance.GroupButton.Options.UseBorderColor = True
        Me.GVGTPAUDIT.Appearance.GroupButton.Options.UseForeColor = True
        Me.GVGTPAUDIT.Appearance.GroupFooter.BackColor = CType(resources.GetObject("GVGTPAUDIT.Appearance.GroupFooter.BackColor"), System.Drawing.Color)
        Me.GVGTPAUDIT.Appearance.GroupFooter.BorderColor = CType(resources.GetObject("GVGTPAUDIT.Appearance.GroupFooter.BorderColor"), System.Drawing.Color)
        Me.GVGTPAUDIT.Appearance.GroupFooter.FontSizeDelta = CType(resources.GetObject("GVGTPAUDIT.Appearance.GroupFooter.FontSizeDelta"), Integer)
        Me.GVGTPAUDIT.Appearance.GroupFooter.FontStyleDelta = CType(resources.GetObject("GVGTPAUDIT.Appearance.GroupFooter.FontStyleDelta"), System.Drawing.FontStyle)
        Me.GVGTPAUDIT.Appearance.GroupFooter.ForeColor = CType(resources.GetObject("GVGTPAUDIT.Appearance.GroupFooter.ForeColor"), System.Drawing.Color)
        Me.GVGTPAUDIT.Appearance.GroupFooter.GradientMode = CType(resources.GetObject("GVGTPAUDIT.Appearance.GroupFooter.GradientMode"), System.Drawing.Drawing2D.LinearGradientMode)
        Me.GVGTPAUDIT.Appearance.GroupFooter.Image = CType(resources.GetObject("GVGTPAUDIT.Appearance.GroupFooter.Image"), System.Drawing.Image)
        Me.GVGTPAUDIT.Appearance.GroupFooter.Options.UseBackColor = True
        Me.GVGTPAUDIT.Appearance.GroupFooter.Options.UseBorderColor = True
        Me.GVGTPAUDIT.Appearance.GroupFooter.Options.UseForeColor = True
        Me.GVGTPAUDIT.Appearance.GroupPanel.BackColor = CType(resources.GetObject("GVGTPAUDIT.Appearance.GroupPanel.BackColor"), System.Drawing.Color)
        Me.GVGTPAUDIT.Appearance.GroupPanel.FontSizeDelta = CType(resources.GetObject("GVGTPAUDIT.Appearance.GroupPanel.FontSizeDelta"), Integer)
        Me.GVGTPAUDIT.Appearance.GroupPanel.FontStyleDelta = CType(resources.GetObject("GVGTPAUDIT.Appearance.GroupPanel.FontStyleDelta"), System.Drawing.FontStyle)
        Me.GVGTPAUDIT.Appearance.GroupPanel.ForeColor = CType(resources.GetObject("GVGTPAUDIT.Appearance.GroupPanel.ForeColor"), System.Drawing.Color)
        Me.GVGTPAUDIT.Appearance.GroupPanel.GradientMode = CType(resources.GetObject("GVGTPAUDIT.Appearance.GroupPanel.GradientMode"), System.Drawing.Drawing2D.LinearGradientMode)
        Me.GVGTPAUDIT.Appearance.GroupPanel.Image = CType(resources.GetObject("GVGTPAUDIT.Appearance.GroupPanel.Image"), System.Drawing.Image)
        Me.GVGTPAUDIT.Appearance.GroupPanel.Options.UseBackColor = True
        Me.GVGTPAUDIT.Appearance.GroupPanel.Options.UseForeColor = True
        Me.GVGTPAUDIT.Appearance.GroupRow.BackColor = CType(resources.GetObject("GVGTPAUDIT.Appearance.GroupRow.BackColor"), System.Drawing.Color)
        Me.GVGTPAUDIT.Appearance.GroupRow.BorderColor = CType(resources.GetObject("GVGTPAUDIT.Appearance.GroupRow.BorderColor"), System.Drawing.Color)
        Me.GVGTPAUDIT.Appearance.GroupRow.Font = CType(resources.GetObject("GVGTPAUDIT.Appearance.GroupRow.Font"), System.Drawing.Font)
        Me.GVGTPAUDIT.Appearance.GroupRow.FontSizeDelta = CType(resources.GetObject("GVGTPAUDIT.Appearance.GroupRow.FontSizeDelta"), Integer)
        Me.GVGTPAUDIT.Appearance.GroupRow.FontStyleDelta = CType(resources.GetObject("GVGTPAUDIT.Appearance.GroupRow.FontStyleDelta"), System.Drawing.FontStyle)
        Me.GVGTPAUDIT.Appearance.GroupRow.ForeColor = CType(resources.GetObject("GVGTPAUDIT.Appearance.GroupRow.ForeColor"), System.Drawing.Color)
        Me.GVGTPAUDIT.Appearance.GroupRow.GradientMode = CType(resources.GetObject("GVGTPAUDIT.Appearance.GroupRow.GradientMode"), System.Drawing.Drawing2D.LinearGradientMode)
        Me.GVGTPAUDIT.Appearance.GroupRow.Image = CType(resources.GetObject("GVGTPAUDIT.Appearance.GroupRow.Image"), System.Drawing.Image)
        Me.GVGTPAUDIT.Appearance.GroupRow.Options.UseBackColor = True
        Me.GVGTPAUDIT.Appearance.GroupRow.Options.UseBorderColor = True
        Me.GVGTPAUDIT.Appearance.GroupRow.Options.UseFont = True
        Me.GVGTPAUDIT.Appearance.GroupRow.Options.UseForeColor = True
        Me.GVGTPAUDIT.Appearance.HeaderPanel.BackColor = CType(resources.GetObject("GVGTPAUDIT.Appearance.HeaderPanel.BackColor"), System.Drawing.Color)
        Me.GVGTPAUDIT.Appearance.HeaderPanel.BackColor2 = CType(resources.GetObject("GVGTPAUDIT.Appearance.HeaderPanel.BackColor2"), System.Drawing.Color)
        Me.GVGTPAUDIT.Appearance.HeaderPanel.BorderColor = CType(resources.GetObject("GVGTPAUDIT.Appearance.HeaderPanel.BorderColor"), System.Drawing.Color)
        Me.GVGTPAUDIT.Appearance.HeaderPanel.Font = CType(resources.GetObject("GVGTPAUDIT.Appearance.HeaderPanel.Font"), System.Drawing.Font)
        Me.GVGTPAUDIT.Appearance.HeaderPanel.FontSizeDelta = CType(resources.GetObject("GVGTPAUDIT.Appearance.HeaderPanel.FontSizeDelta"), Integer)
        Me.GVGTPAUDIT.Appearance.HeaderPanel.FontStyleDelta = CType(resources.GetObject("GVGTPAUDIT.Appearance.HeaderPanel.FontStyleDelta"), System.Drawing.FontStyle)
        Me.GVGTPAUDIT.Appearance.HeaderPanel.ForeColor = CType(resources.GetObject("GVGTPAUDIT.Appearance.HeaderPanel.ForeColor"), System.Drawing.Color)
        Me.GVGTPAUDIT.Appearance.HeaderPanel.GradientMode = CType(resources.GetObject("GVGTPAUDIT.Appearance.HeaderPanel.GradientMode"), System.Drawing.Drawing2D.LinearGradientMode)
        Me.GVGTPAUDIT.Appearance.HeaderPanel.Image = CType(resources.GetObject("GVGTPAUDIT.Appearance.HeaderPanel.Image"), System.Drawing.Image)
        Me.GVGTPAUDIT.Appearance.HeaderPanel.Options.UseBackColor = True
        Me.GVGTPAUDIT.Appearance.HeaderPanel.Options.UseBorderColor = True
        Me.GVGTPAUDIT.Appearance.HeaderPanel.Options.UseFont = True
        Me.GVGTPAUDIT.Appearance.HeaderPanel.Options.UseForeColor = True
        Me.GVGTPAUDIT.Appearance.HeaderPanel.Options.UseTextOptions = True
        Me.GVGTPAUDIT.Appearance.HeaderPanel.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center
        Me.GVGTPAUDIT.Appearance.HeaderPanel.TextOptions.VAlignment = DevExpress.Utils.VertAlignment.Center
        Me.GVGTPAUDIT.Appearance.HeaderPanel.TextOptions.WordWrap = DevExpress.Utils.WordWrap.Wrap
        Me.GVGTPAUDIT.Appearance.HideSelectionRow.BackColor = CType(resources.GetObject("GVGTPAUDIT.Appearance.HideSelectionRow.BackColor"), System.Drawing.Color)
        Me.GVGTPAUDIT.Appearance.HideSelectionRow.FontSizeDelta = CType(resources.GetObject("GVGTPAUDIT.Appearance.HideSelectionRow.FontSizeDelta"), Integer)
        Me.GVGTPAUDIT.Appearance.HideSelectionRow.FontStyleDelta = CType(resources.GetObject("GVGTPAUDIT.Appearance.HideSelectionRow.FontStyleDelta"), System.Drawing.FontStyle)
        Me.GVGTPAUDIT.Appearance.HideSelectionRow.ForeColor = CType(resources.GetObject("GVGTPAUDIT.Appearance.HideSelectionRow.ForeColor"), System.Drawing.Color)
        Me.GVGTPAUDIT.Appearance.HideSelectionRow.GradientMode = CType(resources.GetObject("GVGTPAUDIT.Appearance.HideSelectionRow.GradientMode"), System.Drawing.Drawing2D.LinearGradientMode)
        Me.GVGTPAUDIT.Appearance.HideSelectionRow.Image = CType(resources.GetObject("GVGTPAUDIT.Appearance.HideSelectionRow.Image"), System.Drawing.Image)
        Me.GVGTPAUDIT.Appearance.HideSelectionRow.Options.UseBackColor = True
        Me.GVGTPAUDIT.Appearance.HideSelectionRow.Options.UseForeColor = True
        Me.GVGTPAUDIT.Appearance.HorzLine.BackColor = CType(resources.GetObject("GVGTPAUDIT.Appearance.HorzLine.BackColor"), System.Drawing.Color)
        Me.GVGTPAUDIT.Appearance.HorzLine.FontSizeDelta = CType(resources.GetObject("GVGTPAUDIT.Appearance.HorzLine.FontSizeDelta"), Integer)
        Me.GVGTPAUDIT.Appearance.HorzLine.FontStyleDelta = CType(resources.GetObject("GVGTPAUDIT.Appearance.HorzLine.FontStyleDelta"), System.Drawing.FontStyle)
        Me.GVGTPAUDIT.Appearance.HorzLine.GradientMode = CType(resources.GetObject("GVGTPAUDIT.Appearance.HorzLine.GradientMode"), System.Drawing.Drawing2D.LinearGradientMode)
        Me.GVGTPAUDIT.Appearance.HorzLine.Image = CType(resources.GetObject("GVGTPAUDIT.Appearance.HorzLine.Image"), System.Drawing.Image)
        Me.GVGTPAUDIT.Appearance.HorzLine.Options.UseBackColor = True
        Me.GVGTPAUDIT.Appearance.OddRow.BackColor = CType(resources.GetObject("GVGTPAUDIT.Appearance.OddRow.BackColor"), System.Drawing.Color)
        Me.GVGTPAUDIT.Appearance.OddRow.FontSizeDelta = CType(resources.GetObject("GVGTPAUDIT.Appearance.OddRow.FontSizeDelta"), Integer)
        Me.GVGTPAUDIT.Appearance.OddRow.FontStyleDelta = CType(resources.GetObject("GVGTPAUDIT.Appearance.OddRow.FontStyleDelta"), System.Drawing.FontStyle)
        Me.GVGTPAUDIT.Appearance.OddRow.ForeColor = CType(resources.GetObject("GVGTPAUDIT.Appearance.OddRow.ForeColor"), System.Drawing.Color)
        Me.GVGTPAUDIT.Appearance.OddRow.GradientMode = CType(resources.GetObject("GVGTPAUDIT.Appearance.OddRow.GradientMode"), System.Drawing.Drawing2D.LinearGradientMode)
        Me.GVGTPAUDIT.Appearance.OddRow.Image = CType(resources.GetObject("GVGTPAUDIT.Appearance.OddRow.Image"), System.Drawing.Image)
        Me.GVGTPAUDIT.Appearance.OddRow.Options.UseBackColor = True
        Me.GVGTPAUDIT.Appearance.OddRow.Options.UseForeColor = True
        Me.GVGTPAUDIT.Appearance.Preview.BackColor = CType(resources.GetObject("GVGTPAUDIT.Appearance.Preview.BackColor"), System.Drawing.Color)
        Me.GVGTPAUDIT.Appearance.Preview.FontSizeDelta = CType(resources.GetObject("GVGTPAUDIT.Appearance.Preview.FontSizeDelta"), Integer)
        Me.GVGTPAUDIT.Appearance.Preview.FontStyleDelta = CType(resources.GetObject("GVGTPAUDIT.Appearance.Preview.FontStyleDelta"), System.Drawing.FontStyle)
        Me.GVGTPAUDIT.Appearance.Preview.ForeColor = CType(resources.GetObject("GVGTPAUDIT.Appearance.Preview.ForeColor"), System.Drawing.Color)
        Me.GVGTPAUDIT.Appearance.Preview.GradientMode = CType(resources.GetObject("GVGTPAUDIT.Appearance.Preview.GradientMode"), System.Drawing.Drawing2D.LinearGradientMode)
        Me.GVGTPAUDIT.Appearance.Preview.Image = CType(resources.GetObject("GVGTPAUDIT.Appearance.Preview.Image"), System.Drawing.Image)
        Me.GVGTPAUDIT.Appearance.Preview.Options.UseBackColor = True
        Me.GVGTPAUDIT.Appearance.Preview.Options.UseForeColor = True
        Me.GVGTPAUDIT.Appearance.Row.BackColor = CType(resources.GetObject("GVGTPAUDIT.Appearance.Row.BackColor"), System.Drawing.Color)
        Me.GVGTPAUDIT.Appearance.Row.FontSizeDelta = CType(resources.GetObject("GVGTPAUDIT.Appearance.Row.FontSizeDelta"), Integer)
        Me.GVGTPAUDIT.Appearance.Row.FontStyleDelta = CType(resources.GetObject("GVGTPAUDIT.Appearance.Row.FontStyleDelta"), System.Drawing.FontStyle)
        Me.GVGTPAUDIT.Appearance.Row.ForeColor = CType(resources.GetObject("GVGTPAUDIT.Appearance.Row.ForeColor"), System.Drawing.Color)
        Me.GVGTPAUDIT.Appearance.Row.GradientMode = CType(resources.GetObject("GVGTPAUDIT.Appearance.Row.GradientMode"), System.Drawing.Drawing2D.LinearGradientMode)
        Me.GVGTPAUDIT.Appearance.Row.Image = CType(resources.GetObject("GVGTPAUDIT.Appearance.Row.Image"), System.Drawing.Image)
        Me.GVGTPAUDIT.Appearance.Row.Options.UseBackColor = True
        Me.GVGTPAUDIT.Appearance.Row.Options.UseForeColor = True
        Me.GVGTPAUDIT.Appearance.RowSeparator.BackColor = CType(resources.GetObject("GVGTPAUDIT.Appearance.RowSeparator.BackColor"), System.Drawing.Color)
        Me.GVGTPAUDIT.Appearance.RowSeparator.FontSizeDelta = CType(resources.GetObject("GVGTPAUDIT.Appearance.RowSeparator.FontSizeDelta"), Integer)
        Me.GVGTPAUDIT.Appearance.RowSeparator.FontStyleDelta = CType(resources.GetObject("GVGTPAUDIT.Appearance.RowSeparator.FontStyleDelta"), System.Drawing.FontStyle)
        Me.GVGTPAUDIT.Appearance.RowSeparator.GradientMode = CType(resources.GetObject("GVGTPAUDIT.Appearance.RowSeparator.GradientMode"), System.Drawing.Drawing2D.LinearGradientMode)
        Me.GVGTPAUDIT.Appearance.RowSeparator.Image = CType(resources.GetObject("GVGTPAUDIT.Appearance.RowSeparator.Image"), System.Drawing.Image)
        Me.GVGTPAUDIT.Appearance.RowSeparator.Options.UseBackColor = True
        Me.GVGTPAUDIT.Appearance.SelectedRow.BackColor = CType(resources.GetObject("GVGTPAUDIT.Appearance.SelectedRow.BackColor"), System.Drawing.Color)
        Me.GVGTPAUDIT.Appearance.SelectedRow.FontSizeDelta = CType(resources.GetObject("GVGTPAUDIT.Appearance.SelectedRow.FontSizeDelta"), Integer)
        Me.GVGTPAUDIT.Appearance.SelectedRow.FontStyleDelta = CType(resources.GetObject("GVGTPAUDIT.Appearance.SelectedRow.FontStyleDelta"), System.Drawing.FontStyle)
        Me.GVGTPAUDIT.Appearance.SelectedRow.ForeColor = CType(resources.GetObject("GVGTPAUDIT.Appearance.SelectedRow.ForeColor"), System.Drawing.Color)
        Me.GVGTPAUDIT.Appearance.SelectedRow.GradientMode = CType(resources.GetObject("GVGTPAUDIT.Appearance.SelectedRow.GradientMode"), System.Drawing.Drawing2D.LinearGradientMode)
        Me.GVGTPAUDIT.Appearance.SelectedRow.Image = CType(resources.GetObject("GVGTPAUDIT.Appearance.SelectedRow.Image"), System.Drawing.Image)
        Me.GVGTPAUDIT.Appearance.SelectedRow.Options.UseBackColor = True
        Me.GVGTPAUDIT.Appearance.SelectedRow.Options.UseForeColor = True
        Me.GVGTPAUDIT.Appearance.VertLine.BackColor = CType(resources.GetObject("GVGTPAUDIT.Appearance.VertLine.BackColor"), System.Drawing.Color)
        Me.GVGTPAUDIT.Appearance.VertLine.FontSizeDelta = CType(resources.GetObject("GVGTPAUDIT.Appearance.VertLine.FontSizeDelta"), Integer)
        Me.GVGTPAUDIT.Appearance.VertLine.FontStyleDelta = CType(resources.GetObject("GVGTPAUDIT.Appearance.VertLine.FontStyleDelta"), System.Drawing.FontStyle)
        Me.GVGTPAUDIT.Appearance.VertLine.GradientMode = CType(resources.GetObject("GVGTPAUDIT.Appearance.VertLine.GradientMode"), System.Drawing.Drawing2D.LinearGradientMode)
        Me.GVGTPAUDIT.Appearance.VertLine.Image = CType(resources.GetObject("GVGTPAUDIT.Appearance.VertLine.Image"), System.Drawing.Image)
        Me.GVGTPAUDIT.Appearance.VertLine.Options.UseBackColor = True
        resources.ApplyResources(Me.GVGTPAUDIT, "GVGTPAUDIT")
        Me.GVGTPAUDIT.ColumnPanelRowHeight = 60
        Me.GVGTPAUDIT.Columns.AddRange(New DevExpress.XtraGrid.Columns.GridColumn() {Me.ColSitNGTPAUDITLID, Me.ColSitNGTPAUDITID, Me.ColSitNSITNUM, Me.ColSitNGTPMAINID, Me.ColSitVGTPZONENOM, Me.ColSitVGTPLOTNOM, Me.ColSitVGTPEQUIP, Me.ColSitVGTPPRECIS, Me.ColSitVGTPUNITENOM, Me.ColSitNGTPSITINSTANNEE, Me.ColSitNGTPSITQTE, Me.ColSitVGTPSITOBS})
        Me.GVGTPAUDIT.GridControl = Me.GCGTPAUDIT
        Me.GVGTPAUDIT.Name = "GVGTPAUDIT"
        Me.GVGTPAUDIT.OptionsNavigation.AutoFocusNewRow = True
        Me.GVGTPAUDIT.OptionsView.EnableAppearanceEvenRow = True
        Me.GVGTPAUDIT.OptionsView.EnableAppearanceOddRow = True
        Me.GVGTPAUDIT.OptionsView.ShowAutoFilterRow = True
        Me.GVGTPAUDIT.OptionsView.ShowGroupPanel = False
        '
        'ColSitNGTPAUDITLID
        '
        resources.ApplyResources(Me.ColSitNGTPAUDITLID, "ColSitNGTPAUDITLID")
        Me.ColSitNGTPAUDITLID.FieldName = "NGTPAUDITLID"
        Me.ColSitNGTPAUDITLID.Name = "ColSitNGTPAUDITLID"
        '
        'ColSitNGTPAUDITID
        '
        resources.ApplyResources(Me.ColSitNGTPAUDITID, "ColSitNGTPAUDITID")
        Me.ColSitNGTPAUDITID.FieldName = "NGTPAUDITID"
        Me.ColSitNGTPAUDITID.Name = "ColSitNGTPAUDITID"
        '
        'ColSitNSITNUM
        '
        resources.ApplyResources(Me.ColSitNSITNUM, "ColSitNSITNUM")
        Me.ColSitNSITNUM.FieldName = "NSITNUM"
        Me.ColSitNSITNUM.Name = "ColSitNSITNUM"
        '
        'ColSitNGTPMAINID
        '
        resources.ApplyResources(Me.ColSitNGTPMAINID, "ColSitNGTPMAINID")
        Me.ColSitNGTPMAINID.FieldName = "NGTPMAINID"
        Me.ColSitNGTPMAINID.Name = "ColSitNGTPMAINID"
        '
        'ColSitVGTPZONENOM
        '
        resources.ApplyResources(Me.ColSitVGTPZONENOM, "ColSitVGTPZONENOM")
        Me.ColSitVGTPZONENOM.FieldName = "VGTPZONENOM"
        Me.ColSitVGTPZONENOM.Name = "ColSitVGTPZONENOM"
        Me.ColSitVGTPZONENOM.OptionsColumn.AllowEdit = False
        Me.ColSitVGTPZONENOM.OptionsColumn.ReadOnly = True
        '
        'ColSitVGTPLOTNOM
        '
        resources.ApplyResources(Me.ColSitVGTPLOTNOM, "ColSitVGTPLOTNOM")
        Me.ColSitVGTPLOTNOM.FieldName = "VGTPLOTNOM"
        Me.ColSitVGTPLOTNOM.Name = "ColSitVGTPLOTNOM"
        Me.ColSitVGTPLOTNOM.OptionsColumn.AllowEdit = False
        Me.ColSitVGTPLOTNOM.OptionsColumn.ReadOnly = True
        '
        'ColSitVGTPEQUIP
        '
        resources.ApplyResources(Me.ColSitVGTPEQUIP, "ColSitVGTPEQUIP")
        Me.ColSitVGTPEQUIP.FieldName = "VGTPEQUIP"
        Me.ColSitVGTPEQUIP.Name = "ColSitVGTPEQUIP"
        Me.ColSitVGTPEQUIP.OptionsColumn.AllowEdit = False
        Me.ColSitVGTPEQUIP.OptionsColumn.ReadOnly = True
        '
        'ColSitVGTPPRECIS
        '
        resources.ApplyResources(Me.ColSitVGTPPRECIS, "ColSitVGTPPRECIS")
        Me.ColSitVGTPPRECIS.FieldName = "VGTPPRECIS"
        Me.ColSitVGTPPRECIS.Name = "ColSitVGTPPRECIS"
        Me.ColSitVGTPPRECIS.OptionsColumn.AllowEdit = False
        Me.ColSitVGTPPRECIS.OptionsColumn.ReadOnly = True
        '
        'ColSitVGTPUNITENOM
        '
        Me.ColSitVGTPUNITENOM.AppearanceCell.FontSizeDelta = CType(resources.GetObject("ColSitVGTPUNITENOM.AppearanceCell.FontSizeDelta"), Integer)
        Me.ColSitVGTPUNITENOM.AppearanceCell.FontStyleDelta = CType(resources.GetObject("ColSitVGTPUNITENOM.AppearanceCell.FontStyleDelta"), System.Drawing.FontStyle)
        Me.ColSitVGTPUNITENOM.AppearanceCell.GradientMode = CType(resources.GetObject("ColSitVGTPUNITENOM.AppearanceCell.GradientMode"), System.Drawing.Drawing2D.LinearGradientMode)
        Me.ColSitVGTPUNITENOM.AppearanceCell.Image = CType(resources.GetObject("ColSitVGTPUNITENOM.AppearanceCell.Image"), System.Drawing.Image)
        Me.ColSitVGTPUNITENOM.AppearanceCell.Options.UseTextOptions = True
        Me.ColSitVGTPUNITENOM.AppearanceCell.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center
        resources.ApplyResources(Me.ColSitVGTPUNITENOM, "ColSitVGTPUNITENOM")
        Me.ColSitVGTPUNITENOM.FieldName = "VGTPUNITENOM"
        Me.ColSitVGTPUNITENOM.Name = "ColSitVGTPUNITENOM"
        Me.ColSitVGTPUNITENOM.OptionsColumn.AllowEdit = False
        Me.ColSitVGTPUNITENOM.OptionsColumn.ReadOnly = True
        '
        'ColSitNGTPSITINSTANNEE
        '
        Me.ColSitNGTPSITINSTANNEE.AppearanceCell.FontSizeDelta = CType(resources.GetObject("ColSitNGTPSITINSTANNEE.AppearanceCell.FontSizeDelta"), Integer)
        Me.ColSitNGTPSITINSTANNEE.AppearanceCell.FontStyleDelta = CType(resources.GetObject("ColSitNGTPSITINSTANNEE.AppearanceCell.FontStyleDelta"), System.Drawing.FontStyle)
        Me.ColSitNGTPSITINSTANNEE.AppearanceCell.GradientMode = CType(resources.GetObject("ColSitNGTPSITINSTANNEE.AppearanceCell.GradientMode"), System.Drawing.Drawing2D.LinearGradientMode)
        Me.ColSitNGTPSITINSTANNEE.AppearanceCell.Image = CType(resources.GetObject("ColSitNGTPSITINSTANNEE.AppearanceCell.Image"), System.Drawing.Image)
        Me.ColSitNGTPSITINSTANNEE.AppearanceCell.Options.UseTextOptions = True
        Me.ColSitNGTPSITINSTANNEE.AppearanceCell.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center
        resources.ApplyResources(Me.ColSitNGTPSITINSTANNEE, "ColSitNGTPSITINSTANNEE")
        Me.ColSitNGTPSITINSTANNEE.FieldName = "NGTPSITINSTANNEE"
        Me.ColSitNGTPSITINSTANNEE.Name = "ColSitNGTPSITINSTANNEE"
        Me.ColSitNGTPSITINSTANNEE.OptionsColumn.AllowEdit = False
        Me.ColSitNGTPSITINSTANNEE.OptionsColumn.ReadOnly = True
        '
        'ColSitNGTPSITQTE
        '
        Me.ColSitNGTPSITQTE.AppearanceCell.FontSizeDelta = CType(resources.GetObject("ColSitNGTPSITQTE.AppearanceCell.FontSizeDelta"), Integer)
        Me.ColSitNGTPSITQTE.AppearanceCell.FontStyleDelta = CType(resources.GetObject("ColSitNGTPSITQTE.AppearanceCell.FontStyleDelta"), System.Drawing.FontStyle)
        Me.ColSitNGTPSITQTE.AppearanceCell.GradientMode = CType(resources.GetObject("ColSitNGTPSITQTE.AppearanceCell.GradientMode"), System.Drawing.Drawing2D.LinearGradientMode)
        Me.ColSitNGTPSITQTE.AppearanceCell.Image = CType(resources.GetObject("ColSitNGTPSITQTE.AppearanceCell.Image"), System.Drawing.Image)
        Me.ColSitNGTPSITQTE.AppearanceCell.Options.UseTextOptions = True
        Me.ColSitNGTPSITQTE.AppearanceCell.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Far
        resources.ApplyResources(Me.ColSitNGTPSITQTE, "ColSitNGTPSITQTE")
        Me.ColSitNGTPSITQTE.DisplayFormat.FormatString = "d0"
        Me.ColSitNGTPSITQTE.DisplayFormat.FormatType = DevExpress.Utils.FormatType.Numeric
        Me.ColSitNGTPSITQTE.FieldName = "NGTPSITQTE"
        Me.ColSitNGTPSITQTE.Name = "ColSitNGTPSITQTE"
        Me.ColSitNGTPSITQTE.OptionsColumn.AllowEdit = False
        Me.ColSitNGTPSITQTE.OptionsColumn.ReadOnly = True
        '
        'ColSitVGTPSITOBS
        '
        resources.ApplyResources(Me.ColSitVGTPSITOBS, "ColSitVGTPSITOBS")
        Me.ColSitVGTPSITOBS.FieldName = "VGTPSITOBS"
        Me.ColSitVGTPSITOBS.Name = "ColSitVGTPSITOBS"
        Me.ColSitVGTPSITOBS.OptionsColumn.AllowEdit = False
        Me.ColSitVGTPSITOBS.OptionsColumn.ReadOnly = True
        '
        'Label1
        '
        resources.ApplyResources(Me.Label1, "Label1")
        Me.Label1.Name = "Label1"
        '
        'frmGTPAudit
        '
        resources.ApplyResources(Me, "$this")
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.Wheat
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.GrpBoxEquip)
        Me.Controls.Add(Me.GrpAction)
        Me.Name = "frmGTPAudit"
        Me.WindowState = System.Windows.Forms.FormWindowState.Maximized
        Me.GrpAction.ResumeLayout(False)
        Me.GrpBoxEquip.ResumeLayout(False)
        CType(Me.GCGTPAUDIT, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.GVGTPAUDIT, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents GrpAction As System.Windows.Forms.GroupBox
    Friend WithEvents BtnQuit As System.Windows.Forms.Button
    Friend WithEvents GrpBoxEquip As System.Windows.Forms.GroupBox
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents BtnDetail As System.Windows.Forms.Button
    Private WithEvents GCGTPAUDIT As DevExpress.XtraGrid.GridControl
    Private WithEvents GVGTPAUDIT As DevExpress.XtraGrid.Views.Grid.GridView
    Private WithEvents ColSitNGTPAUDITLID As DevExpress.XtraGrid.Columns.GridColumn
    Private WithEvents ColSitNGTPAUDITID As DevExpress.XtraGrid.Columns.GridColumn
    Private WithEvents ColSitNSITNUM As DevExpress.XtraGrid.Columns.GridColumn
    Private WithEvents ColSitNGTPMAINID As DevExpress.XtraGrid.Columns.GridColumn
    Private WithEvents ColSitVGTPLOTNOM As DevExpress.XtraGrid.Columns.GridColumn
    Private WithEvents ColSitVGTPEQUIP As DevExpress.XtraGrid.Columns.GridColumn
    Private WithEvents ColSitVGTPPRECIS As DevExpress.XtraGrid.Columns.GridColumn
    Private WithEvents ColSitVGTPUNITENOM As DevExpress.XtraGrid.Columns.GridColumn
    Private WithEvents ColSitNGTPSITINSTANNEE As DevExpress.XtraGrid.Columns.GridColumn
    Private WithEvents ColSitNGTPSITQTE As DevExpress.XtraGrid.Columns.GridColumn
    Private WithEvents ColSitVGTPSITOBS As DevExpress.XtraGrid.Columns.GridColumn
    Private WithEvents ColSitVGTPZONENOM As DevExpress.XtraGrid.Columns.GridColumn
End Class
