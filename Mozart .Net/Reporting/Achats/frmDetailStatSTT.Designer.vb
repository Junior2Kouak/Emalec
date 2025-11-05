<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmDetailStatSTT
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(frmDetailStatSTT))
        Me.Label1 = New System.Windows.Forms.Label()
        Me.GCFORMATION = New DevExpress.XtraGrid.GridControl()
        Me.GVFORMATION = New DevExpress.XtraGrid.Views.Grid.GridView()
        Me.ColNFORMNUM = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.ColVPERNOM = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.ColVFORLIB = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.ColVFORTYPE = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.ColFORMATEUR = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.ColVFORMOBS = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.ColDFORMDATE = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.ColSum = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.RepItemGLUpEditGTPLot = New DevExpress.XtraEditors.Repository.RepositoryItemGridLookUpEdit()
        Me.RepIGLUpEditViewLot = New DevExpress.XtraGrid.Views.Grid.GridView()
        Me.ColLOTIDTMP = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.ColLOTNGTPLOTID = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.ColLOTVGTPLOTNOM = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.RepItemGLUpEditUnite = New DevExpress.XtraEditors.Repository.RepositoryItemGridLookUpEdit()
        Me.RepItemGLUpEditViewUnite = New DevExpress.XtraGrid.Views.Grid.GridView()
        Me.ColUNITEIDTMP = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.ColUNITENGTPUNITEID = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.ColUNITEVGTPUNITENOM = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.BtnQuit = New System.Windows.Forms.Button()
        CType(Me.GCFORMATION, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.GVFORMATION, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.RepItemGLUpEditGTPLot, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.RepIGLUpEditViewLot, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.RepItemGLUpEditUnite, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.RepItemGLUpEditViewUnite, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'Label1
        '
        resources.ApplyResources(Me.Label1, "Label1")
        Me.Label1.Name = "Label1"
        '
        'GCFORMATION
        '
        resources.ApplyResources(Me.GCFORMATION, "GCFORMATION")
        '
        '
        '
        Me.GCFORMATION.EmbeddedNavigator.AccessibleDescription = resources.GetString("GCFORMATION.EmbeddedNavigator.AccessibleDescription")
        Me.GCFORMATION.EmbeddedNavigator.AccessibleName = resources.GetString("GCFORMATION.EmbeddedNavigator.AccessibleName")
        Me.GCFORMATION.EmbeddedNavigator.AllowHtmlTextInToolTip = CType(resources.GetObject("GCFORMATION.EmbeddedNavigator.AllowHtmlTextInToolTip"), DevExpress.Utils.DefaultBoolean)
        Me.GCFORMATION.EmbeddedNavigator.Anchor = CType(resources.GetObject("GCFORMATION.EmbeddedNavigator.Anchor"), System.Windows.Forms.AnchorStyles)
        Me.GCFORMATION.EmbeddedNavigator.BackgroundImage = CType(resources.GetObject("GCFORMATION.EmbeddedNavigator.BackgroundImage"), System.Drawing.Image)
        Me.GCFORMATION.EmbeddedNavigator.BackgroundImageLayout = CType(resources.GetObject("GCFORMATION.EmbeddedNavigator.BackgroundImageLayout"), System.Windows.Forms.ImageLayout)
        Me.GCFORMATION.EmbeddedNavigator.ImeMode = CType(resources.GetObject("GCFORMATION.EmbeddedNavigator.ImeMode"), System.Windows.Forms.ImeMode)
        Me.GCFORMATION.EmbeddedNavigator.MaximumSize = CType(resources.GetObject("GCFORMATION.EmbeddedNavigator.MaximumSize"), System.Drawing.Size)
        Me.GCFORMATION.EmbeddedNavigator.TextLocation = CType(resources.GetObject("GCFORMATION.EmbeddedNavigator.TextLocation"), DevExpress.XtraEditors.NavigatorButtonsTextLocation)
        Me.GCFORMATION.EmbeddedNavigator.ToolTip = resources.GetString("GCFORMATION.EmbeddedNavigator.ToolTip")
        Me.GCFORMATION.EmbeddedNavigator.ToolTipIconType = CType(resources.GetObject("GCFORMATION.EmbeddedNavigator.ToolTipIconType"), DevExpress.Utils.ToolTipIconType)
        Me.GCFORMATION.EmbeddedNavigator.ToolTipTitle = resources.GetString("GCFORMATION.EmbeddedNavigator.ToolTipTitle")
        Me.GCFORMATION.MainView = Me.GVFORMATION
        Me.GCFORMATION.Name = "GCFORMATION"
        Me.GCFORMATION.RepositoryItems.AddRange(New DevExpress.XtraEditors.Repository.RepositoryItem() {Me.RepItemGLUpEditGTPLot, Me.RepItemGLUpEditUnite})
        Me.GCFORMATION.ViewCollection.AddRange(New DevExpress.XtraGrid.Views.Base.BaseView() {Me.GVFORMATION})
        '
        'GVFORMATION
        '
        Me.GVFORMATION.Appearance.ColumnFilterButton.BackColor = CType(resources.GetObject("GVFORMATION.Appearance.ColumnFilterButton.BackColor"), System.Drawing.Color)
        Me.GVFORMATION.Appearance.ColumnFilterButton.BorderColor = CType(resources.GetObject("GVFORMATION.Appearance.ColumnFilterButton.BorderColor"), System.Drawing.Color)
        Me.GVFORMATION.Appearance.ColumnFilterButton.FontSizeDelta = CType(resources.GetObject("GVFORMATION.Appearance.ColumnFilterButton.FontSizeDelta"), Integer)
        Me.GVFORMATION.Appearance.ColumnFilterButton.FontStyleDelta = CType(resources.GetObject("GVFORMATION.Appearance.ColumnFilterButton.FontStyleDelta"), System.Drawing.FontStyle)
        Me.GVFORMATION.Appearance.ColumnFilterButton.ForeColor = CType(resources.GetObject("GVFORMATION.Appearance.ColumnFilterButton.ForeColor"), System.Drawing.Color)
        Me.GVFORMATION.Appearance.ColumnFilterButton.GradientMode = CType(resources.GetObject("GVFORMATION.Appearance.ColumnFilterButton.GradientMode"), System.Drawing.Drawing2D.LinearGradientMode)
        Me.GVFORMATION.Appearance.ColumnFilterButton.Image = CType(resources.GetObject("GVFORMATION.Appearance.ColumnFilterButton.Image"), System.Drawing.Image)
        Me.GVFORMATION.Appearance.ColumnFilterButton.Options.UseBackColor = True
        Me.GVFORMATION.Appearance.ColumnFilterButton.Options.UseBorderColor = True
        Me.GVFORMATION.Appearance.ColumnFilterButton.Options.UseForeColor = True
        Me.GVFORMATION.Appearance.ColumnFilterButtonActive.BackColor = CType(resources.GetObject("GVFORMATION.Appearance.ColumnFilterButtonActive.BackColor"), System.Drawing.Color)
        Me.GVFORMATION.Appearance.ColumnFilterButtonActive.BorderColor = CType(resources.GetObject("GVFORMATION.Appearance.ColumnFilterButtonActive.BorderColor"), System.Drawing.Color)
        Me.GVFORMATION.Appearance.ColumnFilterButtonActive.FontSizeDelta = CType(resources.GetObject("GVFORMATION.Appearance.ColumnFilterButtonActive.FontSizeDelta"), Integer)
        Me.GVFORMATION.Appearance.ColumnFilterButtonActive.FontStyleDelta = CType(resources.GetObject("GVFORMATION.Appearance.ColumnFilterButtonActive.FontStyleDelta"), System.Drawing.FontStyle)
        Me.GVFORMATION.Appearance.ColumnFilterButtonActive.ForeColor = CType(resources.GetObject("GVFORMATION.Appearance.ColumnFilterButtonActive.ForeColor"), System.Drawing.Color)
        Me.GVFORMATION.Appearance.ColumnFilterButtonActive.GradientMode = CType(resources.GetObject("GVFORMATION.Appearance.ColumnFilterButtonActive.GradientMode"), System.Drawing.Drawing2D.LinearGradientMode)
        Me.GVFORMATION.Appearance.ColumnFilterButtonActive.Image = CType(resources.GetObject("GVFORMATION.Appearance.ColumnFilterButtonActive.Image"), System.Drawing.Image)
        Me.GVFORMATION.Appearance.ColumnFilterButtonActive.Options.UseBackColor = True
        Me.GVFORMATION.Appearance.ColumnFilterButtonActive.Options.UseBorderColor = True
        Me.GVFORMATION.Appearance.ColumnFilterButtonActive.Options.UseForeColor = True
        Me.GVFORMATION.Appearance.Empty.BackColor = CType(resources.GetObject("GVFORMATION.Appearance.Empty.BackColor"), System.Drawing.Color)
        Me.GVFORMATION.Appearance.Empty.BackColor2 = CType(resources.GetObject("GVFORMATION.Appearance.Empty.BackColor2"), System.Drawing.Color)
        Me.GVFORMATION.Appearance.Empty.FontSizeDelta = CType(resources.GetObject("GVFORMATION.Appearance.Empty.FontSizeDelta"), Integer)
        Me.GVFORMATION.Appearance.Empty.FontStyleDelta = CType(resources.GetObject("GVFORMATION.Appearance.Empty.FontStyleDelta"), System.Drawing.FontStyle)
        Me.GVFORMATION.Appearance.Empty.GradientMode = CType(resources.GetObject("GVFORMATION.Appearance.Empty.GradientMode"), System.Drawing.Drawing2D.LinearGradientMode)
        Me.GVFORMATION.Appearance.Empty.Image = CType(resources.GetObject("GVFORMATION.Appearance.Empty.Image"), System.Drawing.Image)
        Me.GVFORMATION.Appearance.Empty.Options.UseBackColor = True
        Me.GVFORMATION.Appearance.EvenRow.BackColor = CType(resources.GetObject("GVFORMATION.Appearance.EvenRow.BackColor"), System.Drawing.Color)
        Me.GVFORMATION.Appearance.EvenRow.BorderColor = CType(resources.GetObject("GVFORMATION.Appearance.EvenRow.BorderColor"), System.Drawing.Color)
        Me.GVFORMATION.Appearance.EvenRow.FontSizeDelta = CType(resources.GetObject("GVFORMATION.Appearance.EvenRow.FontSizeDelta"), Integer)
        Me.GVFORMATION.Appearance.EvenRow.FontStyleDelta = CType(resources.GetObject("GVFORMATION.Appearance.EvenRow.FontStyleDelta"), System.Drawing.FontStyle)
        Me.GVFORMATION.Appearance.EvenRow.ForeColor = CType(resources.GetObject("GVFORMATION.Appearance.EvenRow.ForeColor"), System.Drawing.Color)
        Me.GVFORMATION.Appearance.EvenRow.GradientMode = CType(resources.GetObject("GVFORMATION.Appearance.EvenRow.GradientMode"), System.Drawing.Drawing2D.LinearGradientMode)
        Me.GVFORMATION.Appearance.EvenRow.Image = CType(resources.GetObject("GVFORMATION.Appearance.EvenRow.Image"), System.Drawing.Image)
        Me.GVFORMATION.Appearance.EvenRow.Options.UseBackColor = True
        Me.GVFORMATION.Appearance.EvenRow.Options.UseBorderColor = True
        Me.GVFORMATION.Appearance.EvenRow.Options.UseForeColor = True
        Me.GVFORMATION.Appearance.FilterCloseButton.BackColor = CType(resources.GetObject("GVFORMATION.Appearance.FilterCloseButton.BackColor"), System.Drawing.Color)
        Me.GVFORMATION.Appearance.FilterCloseButton.BorderColor = CType(resources.GetObject("GVFORMATION.Appearance.FilterCloseButton.BorderColor"), System.Drawing.Color)
        Me.GVFORMATION.Appearance.FilterCloseButton.FontSizeDelta = CType(resources.GetObject("GVFORMATION.Appearance.FilterCloseButton.FontSizeDelta"), Integer)
        Me.GVFORMATION.Appearance.FilterCloseButton.FontStyleDelta = CType(resources.GetObject("GVFORMATION.Appearance.FilterCloseButton.FontStyleDelta"), System.Drawing.FontStyle)
        Me.GVFORMATION.Appearance.FilterCloseButton.ForeColor = CType(resources.GetObject("GVFORMATION.Appearance.FilterCloseButton.ForeColor"), System.Drawing.Color)
        Me.GVFORMATION.Appearance.FilterCloseButton.GradientMode = CType(resources.GetObject("GVFORMATION.Appearance.FilterCloseButton.GradientMode"), System.Drawing.Drawing2D.LinearGradientMode)
        Me.GVFORMATION.Appearance.FilterCloseButton.Image = CType(resources.GetObject("GVFORMATION.Appearance.FilterCloseButton.Image"), System.Drawing.Image)
        Me.GVFORMATION.Appearance.FilterCloseButton.Options.UseBackColor = True
        Me.GVFORMATION.Appearance.FilterCloseButton.Options.UseBorderColor = True
        Me.GVFORMATION.Appearance.FilterCloseButton.Options.UseForeColor = True
        Me.GVFORMATION.Appearance.FilterPanel.BackColor = CType(resources.GetObject("GVFORMATION.Appearance.FilterPanel.BackColor"), System.Drawing.Color)
        Me.GVFORMATION.Appearance.FilterPanel.BackColor2 = CType(resources.GetObject("GVFORMATION.Appearance.FilterPanel.BackColor2"), System.Drawing.Color)
        Me.GVFORMATION.Appearance.FilterPanel.FontSizeDelta = CType(resources.GetObject("GVFORMATION.Appearance.FilterPanel.FontSizeDelta"), Integer)
        Me.GVFORMATION.Appearance.FilterPanel.FontStyleDelta = CType(resources.GetObject("GVFORMATION.Appearance.FilterPanel.FontStyleDelta"), System.Drawing.FontStyle)
        Me.GVFORMATION.Appearance.FilterPanel.ForeColor = CType(resources.GetObject("GVFORMATION.Appearance.FilterPanel.ForeColor"), System.Drawing.Color)
        Me.GVFORMATION.Appearance.FilterPanel.GradientMode = CType(resources.GetObject("GVFORMATION.Appearance.FilterPanel.GradientMode"), System.Drawing.Drawing2D.LinearGradientMode)
        Me.GVFORMATION.Appearance.FilterPanel.Image = CType(resources.GetObject("GVFORMATION.Appearance.FilterPanel.Image"), System.Drawing.Image)
        Me.GVFORMATION.Appearance.FilterPanel.Options.UseBackColor = True
        Me.GVFORMATION.Appearance.FilterPanel.Options.UseForeColor = True
        Me.GVFORMATION.Appearance.FixedLine.BackColor = CType(resources.GetObject("GVFORMATION.Appearance.FixedLine.BackColor"), System.Drawing.Color)
        Me.GVFORMATION.Appearance.FixedLine.FontSizeDelta = CType(resources.GetObject("GVFORMATION.Appearance.FixedLine.FontSizeDelta"), Integer)
        Me.GVFORMATION.Appearance.FixedLine.FontStyleDelta = CType(resources.GetObject("GVFORMATION.Appearance.FixedLine.FontStyleDelta"), System.Drawing.FontStyle)
        Me.GVFORMATION.Appearance.FixedLine.GradientMode = CType(resources.GetObject("GVFORMATION.Appearance.FixedLine.GradientMode"), System.Drawing.Drawing2D.LinearGradientMode)
        Me.GVFORMATION.Appearance.FixedLine.Image = CType(resources.GetObject("GVFORMATION.Appearance.FixedLine.Image"), System.Drawing.Image)
        Me.GVFORMATION.Appearance.FixedLine.Options.UseBackColor = True
        Me.GVFORMATION.Appearance.FocusedCell.BackColor = CType(resources.GetObject("GVFORMATION.Appearance.FocusedCell.BackColor"), System.Drawing.Color)
        Me.GVFORMATION.Appearance.FocusedCell.FontSizeDelta = CType(resources.GetObject("GVFORMATION.Appearance.FocusedCell.FontSizeDelta"), Integer)
        Me.GVFORMATION.Appearance.FocusedCell.FontStyleDelta = CType(resources.GetObject("GVFORMATION.Appearance.FocusedCell.FontStyleDelta"), System.Drawing.FontStyle)
        Me.GVFORMATION.Appearance.FocusedCell.ForeColor = CType(resources.GetObject("GVFORMATION.Appearance.FocusedCell.ForeColor"), System.Drawing.Color)
        Me.GVFORMATION.Appearance.FocusedCell.GradientMode = CType(resources.GetObject("GVFORMATION.Appearance.FocusedCell.GradientMode"), System.Drawing.Drawing2D.LinearGradientMode)
        Me.GVFORMATION.Appearance.FocusedCell.Image = CType(resources.GetObject("GVFORMATION.Appearance.FocusedCell.Image"), System.Drawing.Image)
        Me.GVFORMATION.Appearance.FocusedCell.Options.UseBackColor = True
        Me.GVFORMATION.Appearance.FocusedCell.Options.UseForeColor = True
        Me.GVFORMATION.Appearance.FocusedRow.BackColor = CType(resources.GetObject("GVFORMATION.Appearance.FocusedRow.BackColor"), System.Drawing.Color)
        Me.GVFORMATION.Appearance.FocusedRow.BorderColor = CType(resources.GetObject("GVFORMATION.Appearance.FocusedRow.BorderColor"), System.Drawing.Color)
        Me.GVFORMATION.Appearance.FocusedRow.FontSizeDelta = CType(resources.GetObject("GVFORMATION.Appearance.FocusedRow.FontSizeDelta"), Integer)
        Me.GVFORMATION.Appearance.FocusedRow.FontStyleDelta = CType(resources.GetObject("GVFORMATION.Appearance.FocusedRow.FontStyleDelta"), System.Drawing.FontStyle)
        Me.GVFORMATION.Appearance.FocusedRow.ForeColor = CType(resources.GetObject("GVFORMATION.Appearance.FocusedRow.ForeColor"), System.Drawing.Color)
        Me.GVFORMATION.Appearance.FocusedRow.GradientMode = CType(resources.GetObject("GVFORMATION.Appearance.FocusedRow.GradientMode"), System.Drawing.Drawing2D.LinearGradientMode)
        Me.GVFORMATION.Appearance.FocusedRow.Image = CType(resources.GetObject("GVFORMATION.Appearance.FocusedRow.Image"), System.Drawing.Image)
        Me.GVFORMATION.Appearance.FocusedRow.Options.UseBackColor = True
        Me.GVFORMATION.Appearance.FocusedRow.Options.UseBorderColor = True
        Me.GVFORMATION.Appearance.FocusedRow.Options.UseForeColor = True
        Me.GVFORMATION.Appearance.FooterPanel.BackColor = CType(resources.GetObject("GVFORMATION.Appearance.FooterPanel.BackColor"), System.Drawing.Color)
        Me.GVFORMATION.Appearance.FooterPanel.BorderColor = CType(resources.GetObject("GVFORMATION.Appearance.FooterPanel.BorderColor"), System.Drawing.Color)
        Me.GVFORMATION.Appearance.FooterPanel.FontSizeDelta = CType(resources.GetObject("GVFORMATION.Appearance.FooterPanel.FontSizeDelta"), Integer)
        Me.GVFORMATION.Appearance.FooterPanel.FontStyleDelta = CType(resources.GetObject("GVFORMATION.Appearance.FooterPanel.FontStyleDelta"), System.Drawing.FontStyle)
        Me.GVFORMATION.Appearance.FooterPanel.ForeColor = CType(resources.GetObject("GVFORMATION.Appearance.FooterPanel.ForeColor"), System.Drawing.Color)
        Me.GVFORMATION.Appearance.FooterPanel.GradientMode = CType(resources.GetObject("GVFORMATION.Appearance.FooterPanel.GradientMode"), System.Drawing.Drawing2D.LinearGradientMode)
        Me.GVFORMATION.Appearance.FooterPanel.Image = CType(resources.GetObject("GVFORMATION.Appearance.FooterPanel.Image"), System.Drawing.Image)
        Me.GVFORMATION.Appearance.FooterPanel.Options.UseBackColor = True
        Me.GVFORMATION.Appearance.FooterPanel.Options.UseBorderColor = True
        Me.GVFORMATION.Appearance.FooterPanel.Options.UseForeColor = True
        Me.GVFORMATION.Appearance.GroupButton.BackColor = CType(resources.GetObject("GVFORMATION.Appearance.GroupButton.BackColor"), System.Drawing.Color)
        Me.GVFORMATION.Appearance.GroupButton.BorderColor = CType(resources.GetObject("GVFORMATION.Appearance.GroupButton.BorderColor"), System.Drawing.Color)
        Me.GVFORMATION.Appearance.GroupButton.FontSizeDelta = CType(resources.GetObject("GVFORMATION.Appearance.GroupButton.FontSizeDelta"), Integer)
        Me.GVFORMATION.Appearance.GroupButton.FontStyleDelta = CType(resources.GetObject("GVFORMATION.Appearance.GroupButton.FontStyleDelta"), System.Drawing.FontStyle)
        Me.GVFORMATION.Appearance.GroupButton.GradientMode = CType(resources.GetObject("GVFORMATION.Appearance.GroupButton.GradientMode"), System.Drawing.Drawing2D.LinearGradientMode)
        Me.GVFORMATION.Appearance.GroupButton.Image = CType(resources.GetObject("GVFORMATION.Appearance.GroupButton.Image"), System.Drawing.Image)
        Me.GVFORMATION.Appearance.GroupButton.Options.UseBackColor = True
        Me.GVFORMATION.Appearance.GroupButton.Options.UseBorderColor = True
        Me.GVFORMATION.Appearance.GroupFooter.BackColor = CType(resources.GetObject("GVFORMATION.Appearance.GroupFooter.BackColor"), System.Drawing.Color)
        Me.GVFORMATION.Appearance.GroupFooter.BorderColor = CType(resources.GetObject("GVFORMATION.Appearance.GroupFooter.BorderColor"), System.Drawing.Color)
        Me.GVFORMATION.Appearance.GroupFooter.FontSizeDelta = CType(resources.GetObject("GVFORMATION.Appearance.GroupFooter.FontSizeDelta"), Integer)
        Me.GVFORMATION.Appearance.GroupFooter.FontStyleDelta = CType(resources.GetObject("GVFORMATION.Appearance.GroupFooter.FontStyleDelta"), System.Drawing.FontStyle)
        Me.GVFORMATION.Appearance.GroupFooter.ForeColor = CType(resources.GetObject("GVFORMATION.Appearance.GroupFooter.ForeColor"), System.Drawing.Color)
        Me.GVFORMATION.Appearance.GroupFooter.GradientMode = CType(resources.GetObject("GVFORMATION.Appearance.GroupFooter.GradientMode"), System.Drawing.Drawing2D.LinearGradientMode)
        Me.GVFORMATION.Appearance.GroupFooter.Image = CType(resources.GetObject("GVFORMATION.Appearance.GroupFooter.Image"), System.Drawing.Image)
        Me.GVFORMATION.Appearance.GroupFooter.Options.UseBackColor = True
        Me.GVFORMATION.Appearance.GroupFooter.Options.UseBorderColor = True
        Me.GVFORMATION.Appearance.GroupFooter.Options.UseForeColor = True
        Me.GVFORMATION.Appearance.GroupPanel.BackColor = CType(resources.GetObject("GVFORMATION.Appearance.GroupPanel.BackColor"), System.Drawing.Color)
        Me.GVFORMATION.Appearance.GroupPanel.BackColor2 = CType(resources.GetObject("GVFORMATION.Appearance.GroupPanel.BackColor2"), System.Drawing.Color)
        Me.GVFORMATION.Appearance.GroupPanel.FontSizeDelta = CType(resources.GetObject("GVFORMATION.Appearance.GroupPanel.FontSizeDelta"), Integer)
        Me.GVFORMATION.Appearance.GroupPanel.FontStyleDelta = CType(resources.GetObject("GVFORMATION.Appearance.GroupPanel.FontStyleDelta"), System.Drawing.FontStyle)
        Me.GVFORMATION.Appearance.GroupPanel.ForeColor = CType(resources.GetObject("GVFORMATION.Appearance.GroupPanel.ForeColor"), System.Drawing.Color)
        Me.GVFORMATION.Appearance.GroupPanel.GradientMode = CType(resources.GetObject("GVFORMATION.Appearance.GroupPanel.GradientMode"), System.Drawing.Drawing2D.LinearGradientMode)
        Me.GVFORMATION.Appearance.GroupPanel.Image = CType(resources.GetObject("GVFORMATION.Appearance.GroupPanel.Image"), System.Drawing.Image)
        Me.GVFORMATION.Appearance.GroupPanel.Options.UseBackColor = True
        Me.GVFORMATION.Appearance.GroupPanel.Options.UseForeColor = True
        Me.GVFORMATION.Appearance.GroupRow.BackColor = CType(resources.GetObject("GVFORMATION.Appearance.GroupRow.BackColor"), System.Drawing.Color)
        Me.GVFORMATION.Appearance.GroupRow.BorderColor = CType(resources.GetObject("GVFORMATION.Appearance.GroupRow.BorderColor"), System.Drawing.Color)
        Me.GVFORMATION.Appearance.GroupRow.FontSizeDelta = CType(resources.GetObject("GVFORMATION.Appearance.GroupRow.FontSizeDelta"), Integer)
        Me.GVFORMATION.Appearance.GroupRow.FontStyleDelta = CType(resources.GetObject("GVFORMATION.Appearance.GroupRow.FontStyleDelta"), System.Drawing.FontStyle)
        Me.GVFORMATION.Appearance.GroupRow.ForeColor = CType(resources.GetObject("GVFORMATION.Appearance.GroupRow.ForeColor"), System.Drawing.Color)
        Me.GVFORMATION.Appearance.GroupRow.GradientMode = CType(resources.GetObject("GVFORMATION.Appearance.GroupRow.GradientMode"), System.Drawing.Drawing2D.LinearGradientMode)
        Me.GVFORMATION.Appearance.GroupRow.Image = CType(resources.GetObject("GVFORMATION.Appearance.GroupRow.Image"), System.Drawing.Image)
        Me.GVFORMATION.Appearance.GroupRow.Options.UseBackColor = True
        Me.GVFORMATION.Appearance.GroupRow.Options.UseBorderColor = True
        Me.GVFORMATION.Appearance.GroupRow.Options.UseForeColor = True
        Me.GVFORMATION.Appearance.HeaderPanel.BackColor = CType(resources.GetObject("GVFORMATION.Appearance.HeaderPanel.BackColor"), System.Drawing.Color)
        Me.GVFORMATION.Appearance.HeaderPanel.BorderColor = CType(resources.GetObject("GVFORMATION.Appearance.HeaderPanel.BorderColor"), System.Drawing.Color)
        Me.GVFORMATION.Appearance.HeaderPanel.Font = CType(resources.GetObject("GVFORMATION.Appearance.HeaderPanel.Font"), System.Drawing.Font)
        Me.GVFORMATION.Appearance.HeaderPanel.FontSizeDelta = CType(resources.GetObject("GVFORMATION.Appearance.HeaderPanel.FontSizeDelta"), Integer)
        Me.GVFORMATION.Appearance.HeaderPanel.FontStyleDelta = CType(resources.GetObject("GVFORMATION.Appearance.HeaderPanel.FontStyleDelta"), System.Drawing.FontStyle)
        Me.GVFORMATION.Appearance.HeaderPanel.ForeColor = CType(resources.GetObject("GVFORMATION.Appearance.HeaderPanel.ForeColor"), System.Drawing.Color)
        Me.GVFORMATION.Appearance.HeaderPanel.GradientMode = CType(resources.GetObject("GVFORMATION.Appearance.HeaderPanel.GradientMode"), System.Drawing.Drawing2D.LinearGradientMode)
        Me.GVFORMATION.Appearance.HeaderPanel.Image = CType(resources.GetObject("GVFORMATION.Appearance.HeaderPanel.Image"), System.Drawing.Image)
        Me.GVFORMATION.Appearance.HeaderPanel.Options.UseBackColor = True
        Me.GVFORMATION.Appearance.HeaderPanel.Options.UseBorderColor = True
        Me.GVFORMATION.Appearance.HeaderPanel.Options.UseFont = True
        Me.GVFORMATION.Appearance.HeaderPanel.Options.UseForeColor = True
        Me.GVFORMATION.Appearance.HeaderPanel.Options.UseTextOptions = True
        Me.GVFORMATION.Appearance.HeaderPanel.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center
        Me.GVFORMATION.Appearance.HeaderPanel.TextOptions.VAlignment = DevExpress.Utils.VertAlignment.Center
        Me.GVFORMATION.Appearance.HeaderPanel.TextOptions.WordWrap = DevExpress.Utils.WordWrap.Wrap
        Me.GVFORMATION.Appearance.HideSelectionRow.BackColor = CType(resources.GetObject("GVFORMATION.Appearance.HideSelectionRow.BackColor"), System.Drawing.Color)
        Me.GVFORMATION.Appearance.HideSelectionRow.BorderColor = CType(resources.GetObject("GVFORMATION.Appearance.HideSelectionRow.BorderColor"), System.Drawing.Color)
        Me.GVFORMATION.Appearance.HideSelectionRow.FontSizeDelta = CType(resources.GetObject("GVFORMATION.Appearance.HideSelectionRow.FontSizeDelta"), Integer)
        Me.GVFORMATION.Appearance.HideSelectionRow.FontStyleDelta = CType(resources.GetObject("GVFORMATION.Appearance.HideSelectionRow.FontStyleDelta"), System.Drawing.FontStyle)
        Me.GVFORMATION.Appearance.HideSelectionRow.ForeColor = CType(resources.GetObject("GVFORMATION.Appearance.HideSelectionRow.ForeColor"), System.Drawing.Color)
        Me.GVFORMATION.Appearance.HideSelectionRow.GradientMode = CType(resources.GetObject("GVFORMATION.Appearance.HideSelectionRow.GradientMode"), System.Drawing.Drawing2D.LinearGradientMode)
        Me.GVFORMATION.Appearance.HideSelectionRow.Image = CType(resources.GetObject("GVFORMATION.Appearance.HideSelectionRow.Image"), System.Drawing.Image)
        Me.GVFORMATION.Appearance.HideSelectionRow.Options.UseBackColor = True
        Me.GVFORMATION.Appearance.HideSelectionRow.Options.UseBorderColor = True
        Me.GVFORMATION.Appearance.HideSelectionRow.Options.UseForeColor = True
        Me.GVFORMATION.Appearance.HorzLine.BackColor = CType(resources.GetObject("GVFORMATION.Appearance.HorzLine.BackColor"), System.Drawing.Color)
        Me.GVFORMATION.Appearance.HorzLine.FontSizeDelta = CType(resources.GetObject("GVFORMATION.Appearance.HorzLine.FontSizeDelta"), Integer)
        Me.GVFORMATION.Appearance.HorzLine.FontStyleDelta = CType(resources.GetObject("GVFORMATION.Appearance.HorzLine.FontStyleDelta"), System.Drawing.FontStyle)
        Me.GVFORMATION.Appearance.HorzLine.GradientMode = CType(resources.GetObject("GVFORMATION.Appearance.HorzLine.GradientMode"), System.Drawing.Drawing2D.LinearGradientMode)
        Me.GVFORMATION.Appearance.HorzLine.Image = CType(resources.GetObject("GVFORMATION.Appearance.HorzLine.Image"), System.Drawing.Image)
        Me.GVFORMATION.Appearance.HorzLine.Options.UseBackColor = True
        Me.GVFORMATION.Appearance.OddRow.BackColor = CType(resources.GetObject("GVFORMATION.Appearance.OddRow.BackColor"), System.Drawing.Color)
        Me.GVFORMATION.Appearance.OddRow.BorderColor = CType(resources.GetObject("GVFORMATION.Appearance.OddRow.BorderColor"), System.Drawing.Color)
        Me.GVFORMATION.Appearance.OddRow.FontSizeDelta = CType(resources.GetObject("GVFORMATION.Appearance.OddRow.FontSizeDelta"), Integer)
        Me.GVFORMATION.Appearance.OddRow.FontStyleDelta = CType(resources.GetObject("GVFORMATION.Appearance.OddRow.FontStyleDelta"), System.Drawing.FontStyle)
        Me.GVFORMATION.Appearance.OddRow.ForeColor = CType(resources.GetObject("GVFORMATION.Appearance.OddRow.ForeColor"), System.Drawing.Color)
        Me.GVFORMATION.Appearance.OddRow.GradientMode = CType(resources.GetObject("GVFORMATION.Appearance.OddRow.GradientMode"), System.Drawing.Drawing2D.LinearGradientMode)
        Me.GVFORMATION.Appearance.OddRow.Image = CType(resources.GetObject("GVFORMATION.Appearance.OddRow.Image"), System.Drawing.Image)
        Me.GVFORMATION.Appearance.OddRow.Options.UseBackColor = True
        Me.GVFORMATION.Appearance.OddRow.Options.UseBorderColor = True
        Me.GVFORMATION.Appearance.OddRow.Options.UseForeColor = True
        Me.GVFORMATION.Appearance.Preview.BackColor = CType(resources.GetObject("GVFORMATION.Appearance.Preview.BackColor"), System.Drawing.Color)
        Me.GVFORMATION.Appearance.Preview.Font = CType(resources.GetObject("GVFORMATION.Appearance.Preview.Font"), System.Drawing.Font)
        Me.GVFORMATION.Appearance.Preview.FontSizeDelta = CType(resources.GetObject("GVFORMATION.Appearance.Preview.FontSizeDelta"), Integer)
        Me.GVFORMATION.Appearance.Preview.FontStyleDelta = CType(resources.GetObject("GVFORMATION.Appearance.Preview.FontStyleDelta"), System.Drawing.FontStyle)
        Me.GVFORMATION.Appearance.Preview.ForeColor = CType(resources.GetObject("GVFORMATION.Appearance.Preview.ForeColor"), System.Drawing.Color)
        Me.GVFORMATION.Appearance.Preview.GradientMode = CType(resources.GetObject("GVFORMATION.Appearance.Preview.GradientMode"), System.Drawing.Drawing2D.LinearGradientMode)
        Me.GVFORMATION.Appearance.Preview.Image = CType(resources.GetObject("GVFORMATION.Appearance.Preview.Image"), System.Drawing.Image)
        Me.GVFORMATION.Appearance.Preview.Options.UseBackColor = True
        Me.GVFORMATION.Appearance.Preview.Options.UseFont = True
        Me.GVFORMATION.Appearance.Preview.Options.UseForeColor = True
        Me.GVFORMATION.Appearance.Row.BackColor = CType(resources.GetObject("GVFORMATION.Appearance.Row.BackColor"), System.Drawing.Color)
        Me.GVFORMATION.Appearance.Row.FontSizeDelta = CType(resources.GetObject("GVFORMATION.Appearance.Row.FontSizeDelta"), Integer)
        Me.GVFORMATION.Appearance.Row.FontStyleDelta = CType(resources.GetObject("GVFORMATION.Appearance.Row.FontStyleDelta"), System.Drawing.FontStyle)
        Me.GVFORMATION.Appearance.Row.ForeColor = CType(resources.GetObject("GVFORMATION.Appearance.Row.ForeColor"), System.Drawing.Color)
        Me.GVFORMATION.Appearance.Row.GradientMode = CType(resources.GetObject("GVFORMATION.Appearance.Row.GradientMode"), System.Drawing.Drawing2D.LinearGradientMode)
        Me.GVFORMATION.Appearance.Row.Image = CType(resources.GetObject("GVFORMATION.Appearance.Row.Image"), System.Drawing.Image)
        Me.GVFORMATION.Appearance.Row.Options.UseBackColor = True
        Me.GVFORMATION.Appearance.Row.Options.UseForeColor = True
        Me.GVFORMATION.Appearance.RowSeparator.BackColor = CType(resources.GetObject("GVFORMATION.Appearance.RowSeparator.BackColor"), System.Drawing.Color)
        Me.GVFORMATION.Appearance.RowSeparator.BackColor2 = CType(resources.GetObject("GVFORMATION.Appearance.RowSeparator.BackColor2"), System.Drawing.Color)
        Me.GVFORMATION.Appearance.RowSeparator.FontSizeDelta = CType(resources.GetObject("GVFORMATION.Appearance.RowSeparator.FontSizeDelta"), Integer)
        Me.GVFORMATION.Appearance.RowSeparator.FontStyleDelta = CType(resources.GetObject("GVFORMATION.Appearance.RowSeparator.FontStyleDelta"), System.Drawing.FontStyle)
        Me.GVFORMATION.Appearance.RowSeparator.GradientMode = CType(resources.GetObject("GVFORMATION.Appearance.RowSeparator.GradientMode"), System.Drawing.Drawing2D.LinearGradientMode)
        Me.GVFORMATION.Appearance.RowSeparator.Image = CType(resources.GetObject("GVFORMATION.Appearance.RowSeparator.Image"), System.Drawing.Image)
        Me.GVFORMATION.Appearance.RowSeparator.Options.UseBackColor = True
        Me.GVFORMATION.Appearance.SelectedRow.BackColor = CType(resources.GetObject("GVFORMATION.Appearance.SelectedRow.BackColor"), System.Drawing.Color)
        Me.GVFORMATION.Appearance.SelectedRow.BorderColor = CType(resources.GetObject("GVFORMATION.Appearance.SelectedRow.BorderColor"), System.Drawing.Color)
        Me.GVFORMATION.Appearance.SelectedRow.FontSizeDelta = CType(resources.GetObject("GVFORMATION.Appearance.SelectedRow.FontSizeDelta"), Integer)
        Me.GVFORMATION.Appearance.SelectedRow.FontStyleDelta = CType(resources.GetObject("GVFORMATION.Appearance.SelectedRow.FontStyleDelta"), System.Drawing.FontStyle)
        Me.GVFORMATION.Appearance.SelectedRow.ForeColor = CType(resources.GetObject("GVFORMATION.Appearance.SelectedRow.ForeColor"), System.Drawing.Color)
        Me.GVFORMATION.Appearance.SelectedRow.GradientMode = CType(resources.GetObject("GVFORMATION.Appearance.SelectedRow.GradientMode"), System.Drawing.Drawing2D.LinearGradientMode)
        Me.GVFORMATION.Appearance.SelectedRow.Image = CType(resources.GetObject("GVFORMATION.Appearance.SelectedRow.Image"), System.Drawing.Image)
        Me.GVFORMATION.Appearance.SelectedRow.Options.UseBackColor = True
        Me.GVFORMATION.Appearance.SelectedRow.Options.UseBorderColor = True
        Me.GVFORMATION.Appearance.SelectedRow.Options.UseForeColor = True
        Me.GVFORMATION.Appearance.TopNewRow.BackColor = CType(resources.GetObject("GVFORMATION.Appearance.TopNewRow.BackColor"), System.Drawing.Color)
        Me.GVFORMATION.Appearance.TopNewRow.FontSizeDelta = CType(resources.GetObject("GVFORMATION.Appearance.TopNewRow.FontSizeDelta"), Integer)
        Me.GVFORMATION.Appearance.TopNewRow.FontStyleDelta = CType(resources.GetObject("GVFORMATION.Appearance.TopNewRow.FontStyleDelta"), System.Drawing.FontStyle)
        Me.GVFORMATION.Appearance.TopNewRow.GradientMode = CType(resources.GetObject("GVFORMATION.Appearance.TopNewRow.GradientMode"), System.Drawing.Drawing2D.LinearGradientMode)
        Me.GVFORMATION.Appearance.TopNewRow.Image = CType(resources.GetObject("GVFORMATION.Appearance.TopNewRow.Image"), System.Drawing.Image)
        Me.GVFORMATION.Appearance.TopNewRow.Options.UseBackColor = True
        Me.GVFORMATION.Appearance.VertLine.BackColor = CType(resources.GetObject("GVFORMATION.Appearance.VertLine.BackColor"), System.Drawing.Color)
        Me.GVFORMATION.Appearance.VertLine.FontSizeDelta = CType(resources.GetObject("GVFORMATION.Appearance.VertLine.FontSizeDelta"), Integer)
        Me.GVFORMATION.Appearance.VertLine.FontStyleDelta = CType(resources.GetObject("GVFORMATION.Appearance.VertLine.FontStyleDelta"), System.Drawing.FontStyle)
        Me.GVFORMATION.Appearance.VertLine.GradientMode = CType(resources.GetObject("GVFORMATION.Appearance.VertLine.GradientMode"), System.Drawing.Drawing2D.LinearGradientMode)
        Me.GVFORMATION.Appearance.VertLine.Image = CType(resources.GetObject("GVFORMATION.Appearance.VertLine.Image"), System.Drawing.Image)
        Me.GVFORMATION.Appearance.VertLine.Options.UseBackColor = True
        resources.ApplyResources(Me.GVFORMATION, "GVFORMATION")
        Me.GVFORMATION.ColumnPanelRowHeight = 50
        Me.GVFORMATION.Columns.AddRange(New DevExpress.XtraGrid.Columns.GridColumn() {Me.ColNFORMNUM, Me.ColVPERNOM, Me.ColVFORLIB, Me.ColVFORTYPE, Me.ColFORMATEUR, Me.ColVFORMOBS, Me.ColDFORMDATE, Me.ColSum})
        Me.GVFORMATION.GridControl = Me.GCFORMATION
        Me.GVFORMATION.Name = "GVFORMATION"
        Me.GVFORMATION.OptionsBehavior.Editable = False
        Me.GVFORMATION.OptionsNavigation.AutoFocusNewRow = True
        Me.GVFORMATION.OptionsView.EnableAppearanceOddRow = True
        Me.GVFORMATION.OptionsView.ShowAutoFilterRow = True
        Me.GVFORMATION.OptionsView.ShowFooter = True
        Me.GVFORMATION.OptionsView.ShowGroupPanel = False
        Me.GVFORMATION.RowHeight = 20
        '
        'ColNFORMNUM
        '
        resources.ApplyResources(Me.ColNFORMNUM, "ColNFORMNUM")
        Me.ColNFORMNUM.FieldName = "NFORMNUM"
        Me.ColNFORMNUM.Name = "ColNFORMNUM"
        '
        'ColVPERNOM
        '
        resources.ApplyResources(Me.ColVPERNOM, "ColVPERNOM")
        Me.ColVPERNOM.FieldName = "VSTFNOM"
        Me.ColVPERNOM.Name = "ColVPERNOM"
        Me.ColVPERNOM.OptionsFilter.AutoFilterCondition = DevExpress.XtraGrid.Columns.AutoFilterCondition.Contains
        '
        'ColVFORLIB
        '
        resources.ApplyResources(Me.ColVFORLIB, "ColVFORLIB")
        Me.ColVFORLIB.FieldName = "VSTFHOBJET"
        Me.ColVFORLIB.Name = "ColVFORLIB"
        Me.ColVFORLIB.OptionsFilter.AutoFilterCondition = DevExpress.XtraGrid.Columns.AutoFilterCondition.Contains
        '
        'ColVFORTYPE
        '
        resources.ApplyResources(Me.ColVFORTYPE, "ColVFORTYPE")
        Me.ColVFORTYPE.FieldName = "PRIXANCIEN"
        Me.ColVFORTYPE.Name = "ColVFORTYPE"
        Me.ColVFORTYPE.OptionsFilter.AutoFilterCondition = DevExpress.XtraGrid.Columns.AutoFilterCondition.Contains
        '
        'ColFORMATEUR
        '
        resources.ApplyResources(Me.ColFORMATEUR, "ColFORMATEUR")
        Me.ColFORMATEUR.FieldName = "PRIXNEW"
        Me.ColFORMATEUR.Name = "ColFORMATEUR"
        Me.ColFORMATEUR.OptionsFilter.AutoFilterCondition = DevExpress.XtraGrid.Columns.AutoFilterCondition.Contains
        '
        'ColVFORMOBS
        '
        Me.ColVFORMOBS.AppearanceCell.FontSizeDelta = CType(resources.GetObject("ColVFORMOBS.AppearanceCell.FontSizeDelta"), Integer)
        Me.ColVFORMOBS.AppearanceCell.FontStyleDelta = CType(resources.GetObject("ColVFORMOBS.AppearanceCell.FontStyleDelta"), System.Drawing.FontStyle)
        Me.ColVFORMOBS.AppearanceCell.GradientMode = CType(resources.GetObject("ColVFORMOBS.AppearanceCell.GradientMode"), System.Drawing.Drawing2D.LinearGradientMode)
        Me.ColVFORMOBS.AppearanceCell.Image = CType(resources.GetObject("ColVFORMOBS.AppearanceCell.Image"), System.Drawing.Image)
        Me.ColVFORMOBS.AppearanceCell.Options.UseTextOptions = True
        Me.ColVFORMOBS.AppearanceCell.TextOptions.VAlignment = DevExpress.Utils.VertAlignment.Center
        resources.ApplyResources(Me.ColVFORMOBS, "ColVFORMOBS")
        Me.ColVFORMOBS.FieldName = "DELTA"
        Me.ColVFORMOBS.Name = "ColVFORMOBS"
        Me.ColVFORMOBS.OptionsFilter.AutoFilterCondition = DevExpress.XtraGrid.Columns.AutoFilterCondition.Contains
        '
        'ColDFORMDATE
        '
        Me.ColDFORMDATE.AppearanceCell.FontSizeDelta = CType(resources.GetObject("ColDFORMDATE.AppearanceCell.FontSizeDelta"), Integer)
        Me.ColDFORMDATE.AppearanceCell.FontStyleDelta = CType(resources.GetObject("ColDFORMDATE.AppearanceCell.FontStyleDelta"), System.Drawing.FontStyle)
        Me.ColDFORMDATE.AppearanceCell.GradientMode = CType(resources.GetObject("ColDFORMDATE.AppearanceCell.GradientMode"), System.Drawing.Drawing2D.LinearGradientMode)
        Me.ColDFORMDATE.AppearanceCell.Image = CType(resources.GetObject("ColDFORMDATE.AppearanceCell.Image"), System.Drawing.Image)
        Me.ColDFORMDATE.AppearanceCell.Options.UseTextOptions = True
        Me.ColDFORMDATE.AppearanceCell.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center
        Me.ColDFORMDATE.AppearanceCell.TextOptions.VAlignment = DevExpress.Utils.VertAlignment.Center
        resources.ApplyResources(Me.ColDFORMDATE, "ColDFORMDATE")
        Me.ColDFORMDATE.FieldName = "NB"
        Me.ColDFORMDATE.Name = "ColDFORMDATE"
        Me.ColDFORMDATE.OptionsFilter.AutoFilterCondition = DevExpress.XtraGrid.Columns.AutoFilterCondition.Contains
        '
        'ColSum
        '
        resources.ApplyResources(Me.ColSum, "ColSum")
        Me.ColSum.FieldName = "ColSum"
        Me.ColSum.Name = "ColSum"
        Me.ColSum.Summary.AddRange(New DevExpress.XtraGrid.GridSummaryItem() {New DevExpress.XtraGrid.GridColumnSummaryItem(CType(resources.GetObject("ColSum.Summary"), DevExpress.Data.SummaryItemType))})
        Me.ColSum.UnboundType = DevExpress.Data.UnboundColumnType.[Decimal]
        '
        'RepItemGLUpEditGTPLot
        '
        resources.ApplyResources(Me.RepItemGLUpEditGTPLot, "RepItemGLUpEditGTPLot")
        Me.RepItemGLUpEditGTPLot.Buttons.AddRange(New DevExpress.XtraEditors.Controls.EditorButton() {New DevExpress.XtraEditors.Controls.EditorButton(CType(resources.GetObject("RepItemGLUpEditGTPLot.Buttons"), DevExpress.XtraEditors.Controls.ButtonPredefines))})
        Me.RepItemGLUpEditGTPLot.DisplayMember = "VGTPLOTNOM"
        Me.RepItemGLUpEditGTPLot.Name = "RepItemGLUpEditGTPLot"
        Me.RepItemGLUpEditGTPLot.ValueMember = "NGTPLOTID"
        Me.RepItemGLUpEditGTPLot.View = Me.RepIGLUpEditViewLot
        '
        'RepIGLUpEditViewLot
        '
        resources.ApplyResources(Me.RepIGLUpEditViewLot, "RepIGLUpEditViewLot")
        Me.RepIGLUpEditViewLot.Columns.AddRange(New DevExpress.XtraGrid.Columns.GridColumn() {Me.ColLOTIDTMP, Me.ColLOTNGTPLOTID, Me.ColLOTVGTPLOTNOM})
        Me.RepIGLUpEditViewLot.FocusRectStyle = DevExpress.XtraGrid.Views.Grid.DrawFocusRectStyle.RowFocus
        Me.RepIGLUpEditViewLot.Name = "RepIGLUpEditViewLot"
        Me.RepIGLUpEditViewLot.OptionsSelection.EnableAppearanceFocusedCell = False
        Me.RepIGLUpEditViewLot.OptionsView.ShowGroupPanel = False
        '
        'ColLOTIDTMP
        '
        resources.ApplyResources(Me.ColLOTIDTMP, "ColLOTIDTMP")
        Me.ColLOTIDTMP.FieldName = "IDTMP"
        Me.ColLOTIDTMP.Name = "ColLOTIDTMP"
        '
        'ColLOTNGTPLOTID
        '
        resources.ApplyResources(Me.ColLOTNGTPLOTID, "ColLOTNGTPLOTID")
        Me.ColLOTNGTPLOTID.FieldName = "NGTPLOTID"
        Me.ColLOTNGTPLOTID.Name = "ColLOTNGTPLOTID"
        '
        'ColLOTVGTPLOTNOM
        '
        resources.ApplyResources(Me.ColLOTVGTPLOTNOM, "ColLOTVGTPLOTNOM")
        Me.ColLOTVGTPLOTNOM.FieldName = "VGTPLOTNOM"
        Me.ColLOTVGTPLOTNOM.Name = "ColLOTVGTPLOTNOM"
        '
        'RepItemGLUpEditUnite
        '
        resources.ApplyResources(Me.RepItemGLUpEditUnite, "RepItemGLUpEditUnite")
        Me.RepItemGLUpEditUnite.Buttons.AddRange(New DevExpress.XtraEditors.Controls.EditorButton() {New DevExpress.XtraEditors.Controls.EditorButton(CType(resources.GetObject("RepItemGLUpEditUnite.Buttons"), DevExpress.XtraEditors.Controls.ButtonPredefines))})
        Me.RepItemGLUpEditUnite.DisplayMember = "VGTPUNITENOM"
        Me.RepItemGLUpEditUnite.Name = "RepItemGLUpEditUnite"
        Me.RepItemGLUpEditUnite.ValueMember = "NGTPUNITEID"
        Me.RepItemGLUpEditUnite.View = Me.RepItemGLUpEditViewUnite
        '
        'RepItemGLUpEditViewUnite
        '
        resources.ApplyResources(Me.RepItemGLUpEditViewUnite, "RepItemGLUpEditViewUnite")
        Me.RepItemGLUpEditViewUnite.Columns.AddRange(New DevExpress.XtraGrid.Columns.GridColumn() {Me.ColUNITEIDTMP, Me.ColUNITENGTPUNITEID, Me.ColUNITEVGTPUNITENOM})
        Me.RepItemGLUpEditViewUnite.FocusRectStyle = DevExpress.XtraGrid.Views.Grid.DrawFocusRectStyle.RowFocus
        Me.RepItemGLUpEditViewUnite.Name = "RepItemGLUpEditViewUnite"
        Me.RepItemGLUpEditViewUnite.OptionsSelection.EnableAppearanceFocusedCell = False
        Me.RepItemGLUpEditViewUnite.OptionsView.ShowGroupPanel = False
        '
        'ColUNITEIDTMP
        '
        resources.ApplyResources(Me.ColUNITEIDTMP, "ColUNITEIDTMP")
        Me.ColUNITEIDTMP.FieldName = "IDTMP"
        Me.ColUNITEIDTMP.Name = "ColUNITEIDTMP"
        '
        'ColUNITENGTPUNITEID
        '
        resources.ApplyResources(Me.ColUNITENGTPUNITEID, "ColUNITENGTPUNITEID")
        Me.ColUNITENGTPUNITEID.FieldName = "NGTPUNITEID"
        Me.ColUNITENGTPUNITEID.Name = "ColUNITENGTPUNITEID"
        '
        'ColUNITEVGTPUNITENOM
        '
        resources.ApplyResources(Me.ColUNITEVGTPUNITENOM, "ColUNITEVGTPUNITENOM")
        Me.ColUNITEVGTPUNITENOM.FieldName = "VGTPUNITENOM"
        Me.ColUNITEVGTPUNITENOM.Name = "ColUNITEVGTPUNITENOM"
        '
        'BtnQuit
        '
        resources.ApplyResources(Me.BtnQuit, "BtnQuit")
        Me.BtnQuit.Name = "BtnQuit"
        Me.BtnQuit.UseVisualStyleBackColor = True
        '
        'frmDetailStatSTT
        '
        resources.ApplyResources(Me, "$this")
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.Wheat
        Me.Controls.Add(Me.BtnQuit)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.GCFORMATION)
        Me.Name = "frmDetailStatSTT"
        CType(Me.GCFORMATION, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.GVFORMATION, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.RepItemGLUpEditGTPLot, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.RepIGLUpEditViewLot, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.RepItemGLUpEditUnite, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.RepItemGLUpEditViewUnite, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents BtnQuit As System.Windows.Forms.Button
    Private WithEvents GCFORMATION As DevExpress.XtraGrid.GridControl
    Private WithEvents GVFORMATION As DevExpress.XtraGrid.Views.Grid.GridView
    Private WithEvents ColNFORMNUM As DevExpress.XtraGrid.Columns.GridColumn
    Private WithEvents ColVPERNOM As DevExpress.XtraGrid.Columns.GridColumn
    Private WithEvents ColVFORLIB As DevExpress.XtraGrid.Columns.GridColumn
    Private WithEvents ColVFORTYPE As DevExpress.XtraGrid.Columns.GridColumn
    Private WithEvents ColFORMATEUR As DevExpress.XtraGrid.Columns.GridColumn
    Private WithEvents ColVFORMOBS As DevExpress.XtraGrid.Columns.GridColumn
    Private WithEvents ColDFORMDATE As DevExpress.XtraGrid.Columns.GridColumn
    Private WithEvents RepItemGLUpEditGTPLot As DevExpress.XtraEditors.Repository.RepositoryItemGridLookUpEdit
    Private WithEvents RepIGLUpEditViewLot As DevExpress.XtraGrid.Views.Grid.GridView
    Private WithEvents ColLOTIDTMP As DevExpress.XtraGrid.Columns.GridColumn
    Private WithEvents ColLOTNGTPLOTID As DevExpress.XtraGrid.Columns.GridColumn
    Private WithEvents ColLOTVGTPLOTNOM As DevExpress.XtraGrid.Columns.GridColumn
    Private WithEvents RepItemGLUpEditUnite As DevExpress.XtraEditors.Repository.RepositoryItemGridLookUpEdit
    Private WithEvents RepItemGLUpEditViewUnite As DevExpress.XtraGrid.Views.Grid.GridView
    Private WithEvents ColUNITEIDTMP As DevExpress.XtraGrid.Columns.GridColumn
    Private WithEvents ColUNITENGTPUNITEID As DevExpress.XtraGrid.Columns.GridColumn
    Private WithEvents ColUNITEVGTPUNITENOM As DevExpress.XtraGrid.Columns.GridColumn
    Private WithEvents ColSum As DevExpress.XtraGrid.Columns.GridColumn
End Class
