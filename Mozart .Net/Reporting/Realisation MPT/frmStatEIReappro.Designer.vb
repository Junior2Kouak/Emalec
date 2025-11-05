<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmStatEIReappro
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(frmStatEIReappro))
        Dim GridLevelNode1 As DevExpress.XtraGrid.GridLevelNode = New DevExpress.XtraGrid.GridLevelNode()
        Me.GVListeEIReapproDetail = New DevExpress.XtraGrid.Views.Grid.GridView()
        Me.GColDetailVLART = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.GColDetailNLARTQTE = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.GCListeEIReappro = New DevExpress.XtraGrid.GridControl()
        Me.GVListeEIReappro = New DevExpress.XtraGrid.Views.Grid.GridView()
        Me.GColNDINNUM = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.GColVDDEQUICRE = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.GColVPERNOM = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.GColDDDEDATE = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.GColDDDELIVR = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.GColNDDENUM = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.GroupBox1 = New System.Windows.Forms.GroupBox()
        Me.BtnFermer = New System.Windows.Forms.Button()
        Me.BtnPrint = New System.Windows.Forms.Button()
        Me.LabelTitre = New System.Windows.Forms.Label()
        Me.lblDateJour = New System.Windows.Forms.Label()
        CType(Me.GVListeEIReapproDetail, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.GCListeEIReappro, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.GVListeEIReappro, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.GroupBox1.SuspendLayout()
        Me.SuspendLayout()
        '
        'GVListeEIReapproDetail
        '
        Me.GVListeEIReapproDetail.Appearance.HeaderPanel.Font = CType(resources.GetObject("GVListeEIReapproDetail.Appearance.HeaderPanel.Font"), System.Drawing.Font)
        Me.GVListeEIReapproDetail.Appearance.HeaderPanel.FontSizeDelta = CType(resources.GetObject("GVListeEIReapproDetail.Appearance.HeaderPanel.FontSizeDelta"), Integer)
        Me.GVListeEIReapproDetail.Appearance.HeaderPanel.FontStyleDelta = CType(resources.GetObject("GVListeEIReapproDetail.Appearance.HeaderPanel.FontStyleDelta"), System.Drawing.FontStyle)
        Me.GVListeEIReapproDetail.Appearance.HeaderPanel.GradientMode = CType(resources.GetObject("GVListeEIReapproDetail.Appearance.HeaderPanel.GradientMode"), System.Drawing.Drawing2D.LinearGradientMode)
        Me.GVListeEIReapproDetail.Appearance.HeaderPanel.Image = CType(resources.GetObject("GVListeEIReapproDetail.Appearance.HeaderPanel.Image"), System.Drawing.Image)
        Me.GVListeEIReapproDetail.Appearance.HeaderPanel.Options.UseFont = True
        Me.GVListeEIReapproDetail.Appearance.HeaderPanel.Options.UseTextOptions = True
        Me.GVListeEIReapproDetail.Appearance.HeaderPanel.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center
        Me.GVListeEIReapproDetail.Appearance.HeaderPanel.TextOptions.VAlignment = DevExpress.Utils.VertAlignment.Center
        Me.GVListeEIReapproDetail.Appearance.HeaderPanel.TextOptions.WordWrap = DevExpress.Utils.WordWrap.Wrap
        Me.GVListeEIReapproDetail.Appearance.ViewCaption.BackColor = CType(resources.GetObject("GVListeEIReapproDetail.Appearance.ViewCaption.BackColor"), System.Drawing.Color)
        Me.GVListeEIReapproDetail.Appearance.ViewCaption.Font = CType(resources.GetObject("GVListeEIReapproDetail.Appearance.ViewCaption.Font"), System.Drawing.Font)
        Me.GVListeEIReapproDetail.Appearance.ViewCaption.FontSizeDelta = CType(resources.GetObject("GVListeEIReapproDetail.Appearance.ViewCaption.FontSizeDelta"), Integer)
        Me.GVListeEIReapproDetail.Appearance.ViewCaption.FontStyleDelta = CType(resources.GetObject("GVListeEIReapproDetail.Appearance.ViewCaption.FontStyleDelta"), System.Drawing.FontStyle)
        Me.GVListeEIReapproDetail.Appearance.ViewCaption.GradientMode = CType(resources.GetObject("GVListeEIReapproDetail.Appearance.ViewCaption.GradientMode"), System.Drawing.Drawing2D.LinearGradientMode)
        Me.GVListeEIReapproDetail.Appearance.ViewCaption.Image = CType(resources.GetObject("GVListeEIReapproDetail.Appearance.ViewCaption.Image"), System.Drawing.Image)
        Me.GVListeEIReapproDetail.Appearance.ViewCaption.Options.UseBackColor = True
        Me.GVListeEIReapproDetail.Appearance.ViewCaption.Options.UseFont = True
        Me.GVListeEIReapproDetail.Appearance.ViewCaption.Options.UseTextOptions = True
        Me.GVListeEIReapproDetail.Appearance.ViewCaption.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center
        Me.GVListeEIReapproDetail.Appearance.ViewCaption.TextOptions.VAlignment = DevExpress.Utils.VertAlignment.Center
        Me.GVListeEIReapproDetail.Appearance.ViewCaption.TextOptions.WordWrap = DevExpress.Utils.WordWrap.Wrap
        resources.ApplyResources(Me.GVListeEIReapproDetail, "GVListeEIReapproDetail")
        Me.GVListeEIReapproDetail.Columns.AddRange(New DevExpress.XtraGrid.Columns.GridColumn() {Me.GColDetailVLART, Me.GColDetailNLARTQTE})
        Me.GVListeEIReapproDetail.GridControl = Me.GCListeEIReappro
        Me.GVListeEIReapproDetail.Name = "GVListeEIReapproDetail"
        Me.GVListeEIReapproDetail.OptionsDetail.ShowDetailTabs = False
        Me.GVListeEIReapproDetail.OptionsView.ShowAutoFilterRow = True
        Me.GVListeEIReapproDetail.OptionsView.ShowGroupPanel = False
        Me.GVListeEIReapproDetail.OptionsView.ShowViewCaption = True
        Me.GVListeEIReapproDetail.VertScrollVisibility = DevExpress.XtraGrid.Views.Base.ScrollVisibility.Always
        '
        'GColDetailVLART
        '
        resources.ApplyResources(Me.GColDetailVLART, "GColDetailVLART")
        Me.GColDetailVLART.FieldName = "VLART"
        Me.GColDetailVLART.Name = "GColDetailVLART"
        '
        'GColDetailNLARTQTE
        '
        resources.ApplyResources(Me.GColDetailNLARTQTE, "GColDetailNLARTQTE")
        Me.GColDetailNLARTQTE.FieldName = "NLARTQTE"
        Me.GColDetailNLARTQTE.Name = "GColDetailNLARTQTE"
        '
        'GCListeEIReappro
        '
        resources.ApplyResources(Me.GCListeEIReappro, "GCListeEIReappro")
        '
        '
        '
        Me.GCListeEIReappro.EmbeddedNavigator.AccessibleDescription = resources.GetString("GCListeEIReappro.EmbeddedNavigator.AccessibleDescription")
        Me.GCListeEIReappro.EmbeddedNavigator.AccessibleName = resources.GetString("GCListeEIReappro.EmbeddedNavigator.AccessibleName")
        Me.GCListeEIReappro.EmbeddedNavigator.AllowHtmlTextInToolTip = CType(resources.GetObject("GCListeEIReappro.EmbeddedNavigator.AllowHtmlTextInToolTip"), DevExpress.Utils.DefaultBoolean)
        Me.GCListeEIReappro.EmbeddedNavigator.Anchor = CType(resources.GetObject("GCListeEIReappro.EmbeddedNavigator.Anchor"), System.Windows.Forms.AnchorStyles)
        Me.GCListeEIReappro.EmbeddedNavigator.BackgroundImage = CType(resources.GetObject("GCListeEIReappro.EmbeddedNavigator.BackgroundImage"), System.Drawing.Image)
        Me.GCListeEIReappro.EmbeddedNavigator.BackgroundImageLayout = CType(resources.GetObject("GCListeEIReappro.EmbeddedNavigator.BackgroundImageLayout"), System.Windows.Forms.ImageLayout)
        Me.GCListeEIReappro.EmbeddedNavigator.ImeMode = CType(resources.GetObject("GCListeEIReappro.EmbeddedNavigator.ImeMode"), System.Windows.Forms.ImeMode)
        Me.GCListeEIReappro.EmbeddedNavigator.MaximumSize = CType(resources.GetObject("GCListeEIReappro.EmbeddedNavigator.MaximumSize"), System.Drawing.Size)
        Me.GCListeEIReappro.EmbeddedNavigator.TextLocation = CType(resources.GetObject("GCListeEIReappro.EmbeddedNavigator.TextLocation"), DevExpress.XtraEditors.NavigatorButtonsTextLocation)
        Me.GCListeEIReappro.EmbeddedNavigator.ToolTip = resources.GetString("GCListeEIReappro.EmbeddedNavigator.ToolTip")
        Me.GCListeEIReappro.EmbeddedNavigator.ToolTipIconType = CType(resources.GetObject("GCListeEIReappro.EmbeddedNavigator.ToolTipIconType"), DevExpress.Utils.ToolTipIconType)
        Me.GCListeEIReappro.EmbeddedNavigator.ToolTipTitle = resources.GetString("GCListeEIReappro.EmbeddedNavigator.ToolTipTitle")
        GridLevelNode1.LevelTemplate = Me.GVListeEIReapproDetail
        GridLevelNode1.RelationName = "Detail Fourniture"
        Me.GCListeEIReappro.LevelTree.Nodes.AddRange(New DevExpress.XtraGrid.GridLevelNode() {GridLevelNode1})
        Me.GCListeEIReappro.MainView = Me.GVListeEIReappro
        Me.GCListeEIReappro.Name = "GCListeEIReappro"
        Me.GCListeEIReappro.ViewCollection.AddRange(New DevExpress.XtraGrid.Views.Base.BaseView() {Me.GVListeEIReappro, Me.GVListeEIReapproDetail})
        '
        'GVListeEIReappro
        '
        Me.GVListeEIReappro.Appearance.ColumnFilterButton.BackColor = CType(resources.GetObject("GVListeEIReappro.Appearance.ColumnFilterButton.BackColor"), System.Drawing.Color)
        Me.GVListeEIReappro.Appearance.ColumnFilterButton.BorderColor = CType(resources.GetObject("GVListeEIReappro.Appearance.ColumnFilterButton.BorderColor"), System.Drawing.Color)
        Me.GVListeEIReappro.Appearance.ColumnFilterButton.FontSizeDelta = CType(resources.GetObject("GVListeEIReappro.Appearance.ColumnFilterButton.FontSizeDelta"), Integer)
        Me.GVListeEIReappro.Appearance.ColumnFilterButton.FontStyleDelta = CType(resources.GetObject("GVListeEIReappro.Appearance.ColumnFilterButton.FontStyleDelta"), System.Drawing.FontStyle)
        Me.GVListeEIReappro.Appearance.ColumnFilterButton.ForeColor = CType(resources.GetObject("GVListeEIReappro.Appearance.ColumnFilterButton.ForeColor"), System.Drawing.Color)
        Me.GVListeEIReappro.Appearance.ColumnFilterButton.GradientMode = CType(resources.GetObject("GVListeEIReappro.Appearance.ColumnFilterButton.GradientMode"), System.Drawing.Drawing2D.LinearGradientMode)
        Me.GVListeEIReappro.Appearance.ColumnFilterButton.Image = CType(resources.GetObject("GVListeEIReappro.Appearance.ColumnFilterButton.Image"), System.Drawing.Image)
        Me.GVListeEIReappro.Appearance.ColumnFilterButton.Options.UseBackColor = True
        Me.GVListeEIReappro.Appearance.ColumnFilterButton.Options.UseBorderColor = True
        Me.GVListeEIReappro.Appearance.ColumnFilterButton.Options.UseForeColor = True
        Me.GVListeEIReappro.Appearance.ColumnFilterButtonActive.BackColor = CType(resources.GetObject("GVListeEIReappro.Appearance.ColumnFilterButtonActive.BackColor"), System.Drawing.Color)
        Me.GVListeEIReappro.Appearance.ColumnFilterButtonActive.BorderColor = CType(resources.GetObject("GVListeEIReappro.Appearance.ColumnFilterButtonActive.BorderColor"), System.Drawing.Color)
        Me.GVListeEIReappro.Appearance.ColumnFilterButtonActive.FontSizeDelta = CType(resources.GetObject("GVListeEIReappro.Appearance.ColumnFilterButtonActive.FontSizeDelta"), Integer)
        Me.GVListeEIReappro.Appearance.ColumnFilterButtonActive.FontStyleDelta = CType(resources.GetObject("GVListeEIReappro.Appearance.ColumnFilterButtonActive.FontStyleDelta"), System.Drawing.FontStyle)
        Me.GVListeEIReappro.Appearance.ColumnFilterButtonActive.ForeColor = CType(resources.GetObject("GVListeEIReappro.Appearance.ColumnFilterButtonActive.ForeColor"), System.Drawing.Color)
        Me.GVListeEIReappro.Appearance.ColumnFilterButtonActive.GradientMode = CType(resources.GetObject("GVListeEIReappro.Appearance.ColumnFilterButtonActive.GradientMode"), System.Drawing.Drawing2D.LinearGradientMode)
        Me.GVListeEIReappro.Appearance.ColumnFilterButtonActive.Image = CType(resources.GetObject("GVListeEIReappro.Appearance.ColumnFilterButtonActive.Image"), System.Drawing.Image)
        Me.GVListeEIReappro.Appearance.ColumnFilterButtonActive.Options.UseBackColor = True
        Me.GVListeEIReappro.Appearance.ColumnFilterButtonActive.Options.UseBorderColor = True
        Me.GVListeEIReappro.Appearance.ColumnFilterButtonActive.Options.UseForeColor = True
        Me.GVListeEIReappro.Appearance.Empty.BackColor = CType(resources.GetObject("GVListeEIReappro.Appearance.Empty.BackColor"), System.Drawing.Color)
        Me.GVListeEIReappro.Appearance.Empty.BackColor2 = CType(resources.GetObject("GVListeEIReappro.Appearance.Empty.BackColor2"), System.Drawing.Color)
        Me.GVListeEIReappro.Appearance.Empty.FontSizeDelta = CType(resources.GetObject("GVListeEIReappro.Appearance.Empty.FontSizeDelta"), Integer)
        Me.GVListeEIReappro.Appearance.Empty.FontStyleDelta = CType(resources.GetObject("GVListeEIReappro.Appearance.Empty.FontStyleDelta"), System.Drawing.FontStyle)
        Me.GVListeEIReappro.Appearance.Empty.GradientMode = CType(resources.GetObject("GVListeEIReappro.Appearance.Empty.GradientMode"), System.Drawing.Drawing2D.LinearGradientMode)
        Me.GVListeEIReappro.Appearance.Empty.Image = CType(resources.GetObject("GVListeEIReappro.Appearance.Empty.Image"), System.Drawing.Image)
        Me.GVListeEIReappro.Appearance.Empty.Options.UseBackColor = True
        Me.GVListeEIReappro.Appearance.EvenRow.BackColor = CType(resources.GetObject("GVListeEIReappro.Appearance.EvenRow.BackColor"), System.Drawing.Color)
        Me.GVListeEIReappro.Appearance.EvenRow.FontSizeDelta = CType(resources.GetObject("GVListeEIReappro.Appearance.EvenRow.FontSizeDelta"), Integer)
        Me.GVListeEIReappro.Appearance.EvenRow.FontStyleDelta = CType(resources.GetObject("GVListeEIReappro.Appearance.EvenRow.FontStyleDelta"), System.Drawing.FontStyle)
        Me.GVListeEIReappro.Appearance.EvenRow.ForeColor = CType(resources.GetObject("GVListeEIReappro.Appearance.EvenRow.ForeColor"), System.Drawing.Color)
        Me.GVListeEIReappro.Appearance.EvenRow.GradientMode = CType(resources.GetObject("GVListeEIReappro.Appearance.EvenRow.GradientMode"), System.Drawing.Drawing2D.LinearGradientMode)
        Me.GVListeEIReappro.Appearance.EvenRow.Image = CType(resources.GetObject("GVListeEIReappro.Appearance.EvenRow.Image"), System.Drawing.Image)
        Me.GVListeEIReappro.Appearance.EvenRow.Options.UseBackColor = True
        Me.GVListeEIReappro.Appearance.EvenRow.Options.UseForeColor = True
        Me.GVListeEIReappro.Appearance.FilterCloseButton.BackColor = CType(resources.GetObject("GVListeEIReappro.Appearance.FilterCloseButton.BackColor"), System.Drawing.Color)
        Me.GVListeEIReappro.Appearance.FilterCloseButton.BorderColor = CType(resources.GetObject("GVListeEIReappro.Appearance.FilterCloseButton.BorderColor"), System.Drawing.Color)
        Me.GVListeEIReappro.Appearance.FilterCloseButton.FontSizeDelta = CType(resources.GetObject("GVListeEIReappro.Appearance.FilterCloseButton.FontSizeDelta"), Integer)
        Me.GVListeEIReappro.Appearance.FilterCloseButton.FontStyleDelta = CType(resources.GetObject("GVListeEIReappro.Appearance.FilterCloseButton.FontStyleDelta"), System.Drawing.FontStyle)
        Me.GVListeEIReappro.Appearance.FilterCloseButton.ForeColor = CType(resources.GetObject("GVListeEIReappro.Appearance.FilterCloseButton.ForeColor"), System.Drawing.Color)
        Me.GVListeEIReappro.Appearance.FilterCloseButton.GradientMode = CType(resources.GetObject("GVListeEIReappro.Appearance.FilterCloseButton.GradientMode"), System.Drawing.Drawing2D.LinearGradientMode)
        Me.GVListeEIReappro.Appearance.FilterCloseButton.Image = CType(resources.GetObject("GVListeEIReappro.Appearance.FilterCloseButton.Image"), System.Drawing.Image)
        Me.GVListeEIReappro.Appearance.FilterCloseButton.Options.UseBackColor = True
        Me.GVListeEIReappro.Appearance.FilterCloseButton.Options.UseBorderColor = True
        Me.GVListeEIReappro.Appearance.FilterCloseButton.Options.UseForeColor = True
        Me.GVListeEIReappro.Appearance.FilterPanel.BackColor = CType(resources.GetObject("GVListeEIReappro.Appearance.FilterPanel.BackColor"), System.Drawing.Color)
        Me.GVListeEIReappro.Appearance.FilterPanel.BackColor2 = CType(resources.GetObject("GVListeEIReappro.Appearance.FilterPanel.BackColor2"), System.Drawing.Color)
        Me.GVListeEIReappro.Appearance.FilterPanel.FontSizeDelta = CType(resources.GetObject("GVListeEIReappro.Appearance.FilterPanel.FontSizeDelta"), Integer)
        Me.GVListeEIReappro.Appearance.FilterPanel.FontStyleDelta = CType(resources.GetObject("GVListeEIReappro.Appearance.FilterPanel.FontStyleDelta"), System.Drawing.FontStyle)
        Me.GVListeEIReappro.Appearance.FilterPanel.ForeColor = CType(resources.GetObject("GVListeEIReappro.Appearance.FilterPanel.ForeColor"), System.Drawing.Color)
        Me.GVListeEIReappro.Appearance.FilterPanel.GradientMode = CType(resources.GetObject("GVListeEIReappro.Appearance.FilterPanel.GradientMode"), System.Drawing.Drawing2D.LinearGradientMode)
        Me.GVListeEIReappro.Appearance.FilterPanel.Image = CType(resources.GetObject("GVListeEIReappro.Appearance.FilterPanel.Image"), System.Drawing.Image)
        Me.GVListeEIReappro.Appearance.FilterPanel.Options.UseBackColor = True
        Me.GVListeEIReappro.Appearance.FilterPanel.Options.UseForeColor = True
        Me.GVListeEIReappro.Appearance.FixedLine.BackColor = CType(resources.GetObject("GVListeEIReappro.Appearance.FixedLine.BackColor"), System.Drawing.Color)
        Me.GVListeEIReappro.Appearance.FixedLine.FontSizeDelta = CType(resources.GetObject("GVListeEIReappro.Appearance.FixedLine.FontSizeDelta"), Integer)
        Me.GVListeEIReappro.Appearance.FixedLine.FontStyleDelta = CType(resources.GetObject("GVListeEIReappro.Appearance.FixedLine.FontStyleDelta"), System.Drawing.FontStyle)
        Me.GVListeEIReappro.Appearance.FixedLine.GradientMode = CType(resources.GetObject("GVListeEIReappro.Appearance.FixedLine.GradientMode"), System.Drawing.Drawing2D.LinearGradientMode)
        Me.GVListeEIReappro.Appearance.FixedLine.Image = CType(resources.GetObject("GVListeEIReappro.Appearance.FixedLine.Image"), System.Drawing.Image)
        Me.GVListeEIReappro.Appearance.FixedLine.Options.UseBackColor = True
        Me.GVListeEIReappro.Appearance.FocusedCell.BackColor = CType(resources.GetObject("GVListeEIReappro.Appearance.FocusedCell.BackColor"), System.Drawing.Color)
        Me.GVListeEIReappro.Appearance.FocusedCell.FontSizeDelta = CType(resources.GetObject("GVListeEIReappro.Appearance.FocusedCell.FontSizeDelta"), Integer)
        Me.GVListeEIReappro.Appearance.FocusedCell.FontStyleDelta = CType(resources.GetObject("GVListeEIReappro.Appearance.FocusedCell.FontStyleDelta"), System.Drawing.FontStyle)
        Me.GVListeEIReappro.Appearance.FocusedCell.ForeColor = CType(resources.GetObject("GVListeEIReappro.Appearance.FocusedCell.ForeColor"), System.Drawing.Color)
        Me.GVListeEIReappro.Appearance.FocusedCell.GradientMode = CType(resources.GetObject("GVListeEIReappro.Appearance.FocusedCell.GradientMode"), System.Drawing.Drawing2D.LinearGradientMode)
        Me.GVListeEIReappro.Appearance.FocusedCell.Image = CType(resources.GetObject("GVListeEIReappro.Appearance.FocusedCell.Image"), System.Drawing.Image)
        Me.GVListeEIReappro.Appearance.FocusedCell.Options.UseBackColor = True
        Me.GVListeEIReappro.Appearance.FocusedCell.Options.UseForeColor = True
        Me.GVListeEIReappro.Appearance.FocusedRow.BackColor = CType(resources.GetObject("GVListeEIReappro.Appearance.FocusedRow.BackColor"), System.Drawing.Color)
        Me.GVListeEIReappro.Appearance.FocusedRow.FontSizeDelta = CType(resources.GetObject("GVListeEIReappro.Appearance.FocusedRow.FontSizeDelta"), Integer)
        Me.GVListeEIReappro.Appearance.FocusedRow.FontStyleDelta = CType(resources.GetObject("GVListeEIReappro.Appearance.FocusedRow.FontStyleDelta"), System.Drawing.FontStyle)
        Me.GVListeEIReappro.Appearance.FocusedRow.ForeColor = CType(resources.GetObject("GVListeEIReappro.Appearance.FocusedRow.ForeColor"), System.Drawing.Color)
        Me.GVListeEIReappro.Appearance.FocusedRow.GradientMode = CType(resources.GetObject("GVListeEIReappro.Appearance.FocusedRow.GradientMode"), System.Drawing.Drawing2D.LinearGradientMode)
        Me.GVListeEIReappro.Appearance.FocusedRow.Image = CType(resources.GetObject("GVListeEIReappro.Appearance.FocusedRow.Image"), System.Drawing.Image)
        Me.GVListeEIReappro.Appearance.FocusedRow.Options.UseBackColor = True
        Me.GVListeEIReappro.Appearance.FocusedRow.Options.UseForeColor = True
        Me.GVListeEIReappro.Appearance.FooterPanel.BackColor = CType(resources.GetObject("GVListeEIReappro.Appearance.FooterPanel.BackColor"), System.Drawing.Color)
        Me.GVListeEIReappro.Appearance.FooterPanel.BorderColor = CType(resources.GetObject("GVListeEIReappro.Appearance.FooterPanel.BorderColor"), System.Drawing.Color)
        Me.GVListeEIReappro.Appearance.FooterPanel.FontSizeDelta = CType(resources.GetObject("GVListeEIReappro.Appearance.FooterPanel.FontSizeDelta"), Integer)
        Me.GVListeEIReappro.Appearance.FooterPanel.FontStyleDelta = CType(resources.GetObject("GVListeEIReappro.Appearance.FooterPanel.FontStyleDelta"), System.Drawing.FontStyle)
        Me.GVListeEIReappro.Appearance.FooterPanel.ForeColor = CType(resources.GetObject("GVListeEIReappro.Appearance.FooterPanel.ForeColor"), System.Drawing.Color)
        Me.GVListeEIReappro.Appearance.FooterPanel.GradientMode = CType(resources.GetObject("GVListeEIReappro.Appearance.FooterPanel.GradientMode"), System.Drawing.Drawing2D.LinearGradientMode)
        Me.GVListeEIReappro.Appearance.FooterPanel.Image = CType(resources.GetObject("GVListeEIReappro.Appearance.FooterPanel.Image"), System.Drawing.Image)
        Me.GVListeEIReappro.Appearance.FooterPanel.Options.UseBackColor = True
        Me.GVListeEIReappro.Appearance.FooterPanel.Options.UseBorderColor = True
        Me.GVListeEIReappro.Appearance.FooterPanel.Options.UseForeColor = True
        Me.GVListeEIReappro.Appearance.GroupButton.BackColor = CType(resources.GetObject("GVListeEIReappro.Appearance.GroupButton.BackColor"), System.Drawing.Color)
        Me.GVListeEIReappro.Appearance.GroupButton.BorderColor = CType(resources.GetObject("GVListeEIReappro.Appearance.GroupButton.BorderColor"), System.Drawing.Color)
        Me.GVListeEIReappro.Appearance.GroupButton.FontSizeDelta = CType(resources.GetObject("GVListeEIReappro.Appearance.GroupButton.FontSizeDelta"), Integer)
        Me.GVListeEIReappro.Appearance.GroupButton.FontStyleDelta = CType(resources.GetObject("GVListeEIReappro.Appearance.GroupButton.FontStyleDelta"), System.Drawing.FontStyle)
        Me.GVListeEIReappro.Appearance.GroupButton.GradientMode = CType(resources.GetObject("GVListeEIReappro.Appearance.GroupButton.GradientMode"), System.Drawing.Drawing2D.LinearGradientMode)
        Me.GVListeEIReappro.Appearance.GroupButton.Image = CType(resources.GetObject("GVListeEIReappro.Appearance.GroupButton.Image"), System.Drawing.Image)
        Me.GVListeEIReappro.Appearance.GroupButton.Options.UseBackColor = True
        Me.GVListeEIReappro.Appearance.GroupButton.Options.UseBorderColor = True
        Me.GVListeEIReappro.Appearance.GroupFooter.BackColor = CType(resources.GetObject("GVListeEIReappro.Appearance.GroupFooter.BackColor"), System.Drawing.Color)
        Me.GVListeEIReappro.Appearance.GroupFooter.BorderColor = CType(resources.GetObject("GVListeEIReappro.Appearance.GroupFooter.BorderColor"), System.Drawing.Color)
        Me.GVListeEIReappro.Appearance.GroupFooter.FontSizeDelta = CType(resources.GetObject("GVListeEIReappro.Appearance.GroupFooter.FontSizeDelta"), Integer)
        Me.GVListeEIReappro.Appearance.GroupFooter.FontStyleDelta = CType(resources.GetObject("GVListeEIReappro.Appearance.GroupFooter.FontStyleDelta"), System.Drawing.FontStyle)
        Me.GVListeEIReappro.Appearance.GroupFooter.ForeColor = CType(resources.GetObject("GVListeEIReappro.Appearance.GroupFooter.ForeColor"), System.Drawing.Color)
        Me.GVListeEIReappro.Appearance.GroupFooter.GradientMode = CType(resources.GetObject("GVListeEIReappro.Appearance.GroupFooter.GradientMode"), System.Drawing.Drawing2D.LinearGradientMode)
        Me.GVListeEIReappro.Appearance.GroupFooter.Image = CType(resources.GetObject("GVListeEIReappro.Appearance.GroupFooter.Image"), System.Drawing.Image)
        Me.GVListeEIReappro.Appearance.GroupFooter.Options.UseBackColor = True
        Me.GVListeEIReappro.Appearance.GroupFooter.Options.UseBorderColor = True
        Me.GVListeEIReappro.Appearance.GroupFooter.Options.UseForeColor = True
        Me.GVListeEIReappro.Appearance.GroupPanel.BackColor = CType(resources.GetObject("GVListeEIReappro.Appearance.GroupPanel.BackColor"), System.Drawing.Color)
        Me.GVListeEIReappro.Appearance.GroupPanel.BackColor2 = CType(resources.GetObject("GVListeEIReappro.Appearance.GroupPanel.BackColor2"), System.Drawing.Color)
        Me.GVListeEIReappro.Appearance.GroupPanel.FontSizeDelta = CType(resources.GetObject("GVListeEIReappro.Appearance.GroupPanel.FontSizeDelta"), Integer)
        Me.GVListeEIReappro.Appearance.GroupPanel.FontStyleDelta = CType(resources.GetObject("GVListeEIReappro.Appearance.GroupPanel.FontStyleDelta"), System.Drawing.FontStyle)
        Me.GVListeEIReappro.Appearance.GroupPanel.ForeColor = CType(resources.GetObject("GVListeEIReappro.Appearance.GroupPanel.ForeColor"), System.Drawing.Color)
        Me.GVListeEIReappro.Appearance.GroupPanel.GradientMode = CType(resources.GetObject("GVListeEIReappro.Appearance.GroupPanel.GradientMode"), System.Drawing.Drawing2D.LinearGradientMode)
        Me.GVListeEIReappro.Appearance.GroupPanel.Image = CType(resources.GetObject("GVListeEIReappro.Appearance.GroupPanel.Image"), System.Drawing.Image)
        Me.GVListeEIReappro.Appearance.GroupPanel.Options.UseBackColor = True
        Me.GVListeEIReappro.Appearance.GroupPanel.Options.UseForeColor = True
        Me.GVListeEIReappro.Appearance.GroupRow.BackColor = CType(resources.GetObject("GVListeEIReappro.Appearance.GroupRow.BackColor"), System.Drawing.Color)
        Me.GVListeEIReappro.Appearance.GroupRow.BorderColor = CType(resources.GetObject("GVListeEIReappro.Appearance.GroupRow.BorderColor"), System.Drawing.Color)
        Me.GVListeEIReappro.Appearance.GroupRow.FontSizeDelta = CType(resources.GetObject("GVListeEIReappro.Appearance.GroupRow.FontSizeDelta"), Integer)
        Me.GVListeEIReappro.Appearance.GroupRow.FontStyleDelta = CType(resources.GetObject("GVListeEIReappro.Appearance.GroupRow.FontStyleDelta"), System.Drawing.FontStyle)
        Me.GVListeEIReappro.Appearance.GroupRow.ForeColor = CType(resources.GetObject("GVListeEIReappro.Appearance.GroupRow.ForeColor"), System.Drawing.Color)
        Me.GVListeEIReappro.Appearance.GroupRow.GradientMode = CType(resources.GetObject("GVListeEIReappro.Appearance.GroupRow.GradientMode"), System.Drawing.Drawing2D.LinearGradientMode)
        Me.GVListeEIReappro.Appearance.GroupRow.Image = CType(resources.GetObject("GVListeEIReappro.Appearance.GroupRow.Image"), System.Drawing.Image)
        Me.GVListeEIReappro.Appearance.GroupRow.Options.UseBackColor = True
        Me.GVListeEIReappro.Appearance.GroupRow.Options.UseBorderColor = True
        Me.GVListeEIReappro.Appearance.GroupRow.Options.UseForeColor = True
        Me.GVListeEIReappro.Appearance.HeaderPanel.BackColor = CType(resources.GetObject("GVListeEIReappro.Appearance.HeaderPanel.BackColor"), System.Drawing.Color)
        Me.GVListeEIReappro.Appearance.HeaderPanel.BorderColor = CType(resources.GetObject("GVListeEIReappro.Appearance.HeaderPanel.BorderColor"), System.Drawing.Color)
        Me.GVListeEIReappro.Appearance.HeaderPanel.Font = CType(resources.GetObject("GVListeEIReappro.Appearance.HeaderPanel.Font"), System.Drawing.Font)
        Me.GVListeEIReappro.Appearance.HeaderPanel.FontSizeDelta = CType(resources.GetObject("GVListeEIReappro.Appearance.HeaderPanel.FontSizeDelta"), Integer)
        Me.GVListeEIReappro.Appearance.HeaderPanel.FontStyleDelta = CType(resources.GetObject("GVListeEIReappro.Appearance.HeaderPanel.FontStyleDelta"), System.Drawing.FontStyle)
        Me.GVListeEIReappro.Appearance.HeaderPanel.ForeColor = CType(resources.GetObject("GVListeEIReappro.Appearance.HeaderPanel.ForeColor"), System.Drawing.Color)
        Me.GVListeEIReappro.Appearance.HeaderPanel.GradientMode = CType(resources.GetObject("GVListeEIReappro.Appearance.HeaderPanel.GradientMode"), System.Drawing.Drawing2D.LinearGradientMode)
        Me.GVListeEIReappro.Appearance.HeaderPanel.Image = CType(resources.GetObject("GVListeEIReappro.Appearance.HeaderPanel.Image"), System.Drawing.Image)
        Me.GVListeEIReappro.Appearance.HeaderPanel.Options.UseBackColor = True
        Me.GVListeEIReappro.Appearance.HeaderPanel.Options.UseBorderColor = True
        Me.GVListeEIReappro.Appearance.HeaderPanel.Options.UseFont = True
        Me.GVListeEIReappro.Appearance.HeaderPanel.Options.UseForeColor = True
        Me.GVListeEIReappro.Appearance.HeaderPanel.Options.UseTextOptions = True
        Me.GVListeEIReappro.Appearance.HeaderPanel.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center
        Me.GVListeEIReappro.Appearance.HeaderPanel.TextOptions.VAlignment = DevExpress.Utils.VertAlignment.Center
        Me.GVListeEIReappro.Appearance.HeaderPanel.TextOptions.WordWrap = DevExpress.Utils.WordWrap.Wrap
        Me.GVListeEIReappro.Appearance.HideSelectionRow.BackColor = CType(resources.GetObject("GVListeEIReappro.Appearance.HideSelectionRow.BackColor"), System.Drawing.Color)
        Me.GVListeEIReappro.Appearance.HideSelectionRow.FontSizeDelta = CType(resources.GetObject("GVListeEIReappro.Appearance.HideSelectionRow.FontSizeDelta"), Integer)
        Me.GVListeEIReappro.Appearance.HideSelectionRow.FontStyleDelta = CType(resources.GetObject("GVListeEIReappro.Appearance.HideSelectionRow.FontStyleDelta"), System.Drawing.FontStyle)
        Me.GVListeEIReappro.Appearance.HideSelectionRow.ForeColor = CType(resources.GetObject("GVListeEIReappro.Appearance.HideSelectionRow.ForeColor"), System.Drawing.Color)
        Me.GVListeEIReappro.Appearance.HideSelectionRow.GradientMode = CType(resources.GetObject("GVListeEIReappro.Appearance.HideSelectionRow.GradientMode"), System.Drawing.Drawing2D.LinearGradientMode)
        Me.GVListeEIReappro.Appearance.HideSelectionRow.Image = CType(resources.GetObject("GVListeEIReappro.Appearance.HideSelectionRow.Image"), System.Drawing.Image)
        Me.GVListeEIReappro.Appearance.HideSelectionRow.Options.UseBackColor = True
        Me.GVListeEIReappro.Appearance.HideSelectionRow.Options.UseForeColor = True
        Me.GVListeEIReappro.Appearance.HorzLine.BackColor = CType(resources.GetObject("GVListeEIReappro.Appearance.HorzLine.BackColor"), System.Drawing.Color)
        Me.GVListeEIReappro.Appearance.HorzLine.FontSizeDelta = CType(resources.GetObject("GVListeEIReappro.Appearance.HorzLine.FontSizeDelta"), Integer)
        Me.GVListeEIReappro.Appearance.HorzLine.FontStyleDelta = CType(resources.GetObject("GVListeEIReappro.Appearance.HorzLine.FontStyleDelta"), System.Drawing.FontStyle)
        Me.GVListeEIReappro.Appearance.HorzLine.GradientMode = CType(resources.GetObject("GVListeEIReappro.Appearance.HorzLine.GradientMode"), System.Drawing.Drawing2D.LinearGradientMode)
        Me.GVListeEIReappro.Appearance.HorzLine.Image = CType(resources.GetObject("GVListeEIReappro.Appearance.HorzLine.Image"), System.Drawing.Image)
        Me.GVListeEIReappro.Appearance.HorzLine.Options.UseBackColor = True
        Me.GVListeEIReappro.Appearance.OddRow.BackColor = CType(resources.GetObject("GVListeEIReappro.Appearance.OddRow.BackColor"), System.Drawing.Color)
        Me.GVListeEIReappro.Appearance.OddRow.FontSizeDelta = CType(resources.GetObject("GVListeEIReappro.Appearance.OddRow.FontSizeDelta"), Integer)
        Me.GVListeEIReappro.Appearance.OddRow.FontStyleDelta = CType(resources.GetObject("GVListeEIReappro.Appearance.OddRow.FontStyleDelta"), System.Drawing.FontStyle)
        Me.GVListeEIReappro.Appearance.OddRow.ForeColor = CType(resources.GetObject("GVListeEIReappro.Appearance.OddRow.ForeColor"), System.Drawing.Color)
        Me.GVListeEIReappro.Appearance.OddRow.GradientMode = CType(resources.GetObject("GVListeEIReappro.Appearance.OddRow.GradientMode"), System.Drawing.Drawing2D.LinearGradientMode)
        Me.GVListeEIReappro.Appearance.OddRow.Image = CType(resources.GetObject("GVListeEIReappro.Appearance.OddRow.Image"), System.Drawing.Image)
        Me.GVListeEIReappro.Appearance.OddRow.Options.UseBackColor = True
        Me.GVListeEIReappro.Appearance.OddRow.Options.UseForeColor = True
        Me.GVListeEIReappro.Appearance.Preview.BackColor = CType(resources.GetObject("GVListeEIReappro.Appearance.Preview.BackColor"), System.Drawing.Color)
        Me.GVListeEIReappro.Appearance.Preview.Font = CType(resources.GetObject("GVListeEIReappro.Appearance.Preview.Font"), System.Drawing.Font)
        Me.GVListeEIReappro.Appearance.Preview.FontSizeDelta = CType(resources.GetObject("GVListeEIReappro.Appearance.Preview.FontSizeDelta"), Integer)
        Me.GVListeEIReappro.Appearance.Preview.FontStyleDelta = CType(resources.GetObject("GVListeEIReappro.Appearance.Preview.FontStyleDelta"), System.Drawing.FontStyle)
        Me.GVListeEIReappro.Appearance.Preview.ForeColor = CType(resources.GetObject("GVListeEIReappro.Appearance.Preview.ForeColor"), System.Drawing.Color)
        Me.GVListeEIReappro.Appearance.Preview.GradientMode = CType(resources.GetObject("GVListeEIReappro.Appearance.Preview.GradientMode"), System.Drawing.Drawing2D.LinearGradientMode)
        Me.GVListeEIReappro.Appearance.Preview.Image = CType(resources.GetObject("GVListeEIReappro.Appearance.Preview.Image"), System.Drawing.Image)
        Me.GVListeEIReappro.Appearance.Preview.Options.UseBackColor = True
        Me.GVListeEIReappro.Appearance.Preview.Options.UseFont = True
        Me.GVListeEIReappro.Appearance.Preview.Options.UseForeColor = True
        Me.GVListeEIReappro.Appearance.Row.BackColor = CType(resources.GetObject("GVListeEIReappro.Appearance.Row.BackColor"), System.Drawing.Color)
        Me.GVListeEIReappro.Appearance.Row.BorderColor = CType(resources.GetObject("GVListeEIReappro.Appearance.Row.BorderColor"), System.Drawing.Color)
        Me.GVListeEIReappro.Appearance.Row.FontSizeDelta = CType(resources.GetObject("GVListeEIReappro.Appearance.Row.FontSizeDelta"), Integer)
        Me.GVListeEIReappro.Appearance.Row.FontStyleDelta = CType(resources.GetObject("GVListeEIReappro.Appearance.Row.FontStyleDelta"), System.Drawing.FontStyle)
        Me.GVListeEIReappro.Appearance.Row.ForeColor = CType(resources.GetObject("GVListeEIReappro.Appearance.Row.ForeColor"), System.Drawing.Color)
        Me.GVListeEIReappro.Appearance.Row.GradientMode = CType(resources.GetObject("GVListeEIReappro.Appearance.Row.GradientMode"), System.Drawing.Drawing2D.LinearGradientMode)
        Me.GVListeEIReappro.Appearance.Row.Image = CType(resources.GetObject("GVListeEIReappro.Appearance.Row.Image"), System.Drawing.Image)
        Me.GVListeEIReappro.Appearance.Row.Options.UseBackColor = True
        Me.GVListeEIReappro.Appearance.Row.Options.UseBorderColor = True
        Me.GVListeEIReappro.Appearance.Row.Options.UseForeColor = True
        Me.GVListeEIReappro.Appearance.RowSeparator.BackColor = CType(resources.GetObject("GVListeEIReappro.Appearance.RowSeparator.BackColor"), System.Drawing.Color)
        Me.GVListeEIReappro.Appearance.RowSeparator.BackColor2 = CType(resources.GetObject("GVListeEIReappro.Appearance.RowSeparator.BackColor2"), System.Drawing.Color)
        Me.GVListeEIReappro.Appearance.RowSeparator.FontSizeDelta = CType(resources.GetObject("GVListeEIReappro.Appearance.RowSeparator.FontSizeDelta"), Integer)
        Me.GVListeEIReappro.Appearance.RowSeparator.FontStyleDelta = CType(resources.GetObject("GVListeEIReappro.Appearance.RowSeparator.FontStyleDelta"), System.Drawing.FontStyle)
        Me.GVListeEIReappro.Appearance.RowSeparator.GradientMode = CType(resources.GetObject("GVListeEIReappro.Appearance.RowSeparator.GradientMode"), System.Drawing.Drawing2D.LinearGradientMode)
        Me.GVListeEIReappro.Appearance.RowSeparator.Image = CType(resources.GetObject("GVListeEIReappro.Appearance.RowSeparator.Image"), System.Drawing.Image)
        Me.GVListeEIReappro.Appearance.RowSeparator.Options.UseBackColor = True
        Me.GVListeEIReappro.Appearance.SelectedRow.BackColor = CType(resources.GetObject("GVListeEIReappro.Appearance.SelectedRow.BackColor"), System.Drawing.Color)
        Me.GVListeEIReappro.Appearance.SelectedRow.FontSizeDelta = CType(resources.GetObject("GVListeEIReappro.Appearance.SelectedRow.FontSizeDelta"), Integer)
        Me.GVListeEIReappro.Appearance.SelectedRow.FontStyleDelta = CType(resources.GetObject("GVListeEIReappro.Appearance.SelectedRow.FontStyleDelta"), System.Drawing.FontStyle)
        Me.GVListeEIReappro.Appearance.SelectedRow.GradientMode = CType(resources.GetObject("GVListeEIReappro.Appearance.SelectedRow.GradientMode"), System.Drawing.Drawing2D.LinearGradientMode)
        Me.GVListeEIReappro.Appearance.SelectedRow.Image = CType(resources.GetObject("GVListeEIReappro.Appearance.SelectedRow.Image"), System.Drawing.Image)
        Me.GVListeEIReappro.Appearance.SelectedRow.Options.UseBackColor = True
        Me.GVListeEIReappro.Appearance.TopNewRow.BackColor = CType(resources.GetObject("GVListeEIReappro.Appearance.TopNewRow.BackColor"), System.Drawing.Color)
        Me.GVListeEIReappro.Appearance.TopNewRow.FontSizeDelta = CType(resources.GetObject("GVListeEIReappro.Appearance.TopNewRow.FontSizeDelta"), Integer)
        Me.GVListeEIReappro.Appearance.TopNewRow.FontStyleDelta = CType(resources.GetObject("GVListeEIReappro.Appearance.TopNewRow.FontStyleDelta"), System.Drawing.FontStyle)
        Me.GVListeEIReappro.Appearance.TopNewRow.GradientMode = CType(resources.GetObject("GVListeEIReappro.Appearance.TopNewRow.GradientMode"), System.Drawing.Drawing2D.LinearGradientMode)
        Me.GVListeEIReappro.Appearance.TopNewRow.Image = CType(resources.GetObject("GVListeEIReappro.Appearance.TopNewRow.Image"), System.Drawing.Image)
        Me.GVListeEIReappro.Appearance.TopNewRow.Options.UseBackColor = True
        Me.GVListeEIReappro.Appearance.VertLine.BackColor = CType(resources.GetObject("GVListeEIReappro.Appearance.VertLine.BackColor"), System.Drawing.Color)
        Me.GVListeEIReappro.Appearance.VertLine.FontSizeDelta = CType(resources.GetObject("GVListeEIReappro.Appearance.VertLine.FontSizeDelta"), Integer)
        Me.GVListeEIReappro.Appearance.VertLine.FontStyleDelta = CType(resources.GetObject("GVListeEIReappro.Appearance.VertLine.FontStyleDelta"), System.Drawing.FontStyle)
        Me.GVListeEIReappro.Appearance.VertLine.GradientMode = CType(resources.GetObject("GVListeEIReappro.Appearance.VertLine.GradientMode"), System.Drawing.Drawing2D.LinearGradientMode)
        Me.GVListeEIReappro.Appearance.VertLine.Image = CType(resources.GetObject("GVListeEIReappro.Appearance.VertLine.Image"), System.Drawing.Image)
        Me.GVListeEIReappro.Appearance.VertLine.Options.UseBackColor = True
        Me.GVListeEIReappro.Appearance.ViewCaption.Font = CType(resources.GetObject("GVListeEIReappro.Appearance.ViewCaption.Font"), System.Drawing.Font)
        Me.GVListeEIReappro.Appearance.ViewCaption.FontSizeDelta = CType(resources.GetObject("GVListeEIReappro.Appearance.ViewCaption.FontSizeDelta"), Integer)
        Me.GVListeEIReappro.Appearance.ViewCaption.FontStyleDelta = CType(resources.GetObject("GVListeEIReappro.Appearance.ViewCaption.FontStyleDelta"), System.Drawing.FontStyle)
        Me.GVListeEIReappro.Appearance.ViewCaption.GradientMode = CType(resources.GetObject("GVListeEIReappro.Appearance.ViewCaption.GradientMode"), System.Drawing.Drawing2D.LinearGradientMode)
        Me.GVListeEIReappro.Appearance.ViewCaption.Image = CType(resources.GetObject("GVListeEIReappro.Appearance.ViewCaption.Image"), System.Drawing.Image)
        Me.GVListeEIReappro.Appearance.ViewCaption.Options.UseFont = True
        Me.GVListeEIReappro.Appearance.ViewCaption.Options.UseTextOptions = True
        Me.GVListeEIReappro.Appearance.ViewCaption.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center
        Me.GVListeEIReappro.Appearance.ViewCaption.TextOptions.VAlignment = DevExpress.Utils.VertAlignment.Center
        Me.GVListeEIReappro.Appearance.ViewCaption.TextOptions.WordWrap = DevExpress.Utils.WordWrap.Wrap
        resources.ApplyResources(Me.GVListeEIReappro, "GVListeEIReappro")
        Me.GVListeEIReappro.ColumnPanelRowHeight = 50
        Me.GVListeEIReappro.Columns.AddRange(New DevExpress.XtraGrid.Columns.GridColumn() {Me.GColNDINNUM, Me.GColVDDEQUICRE, Me.GColVPERNOM, Me.GColDDDEDATE, Me.GColDDDELIVR, Me.GColNDDENUM})
        Me.GVListeEIReappro.GridControl = Me.GCListeEIReappro
        Me.GVListeEIReappro.Name = "GVListeEIReappro"
        Me.GVListeEIReappro.OptionsBehavior.ReadOnly = True
        Me.GVListeEIReappro.OptionsCustomization.AllowGroup = False
        Me.GVListeEIReappro.OptionsDetail.ShowDetailTabs = False
        Me.GVListeEIReappro.OptionsPrint.PrintFilterInfo = True
        Me.GVListeEIReappro.OptionsView.EnableAppearanceEvenRow = True
        Me.GVListeEIReappro.OptionsView.EnableAppearanceOddRow = True
        Me.GVListeEIReappro.OptionsView.ShowAutoFilterRow = True
        Me.GVListeEIReappro.OptionsView.ShowFooter = True
        Me.GVListeEIReappro.OptionsView.ShowGroupPanel = False
        '
        'GColNDINNUM
        '
        Me.GColNDINNUM.AppearanceCell.FontSizeDelta = CType(resources.GetObject("GColNDINNUM.AppearanceCell.FontSizeDelta"), Integer)
        Me.GColNDINNUM.AppearanceCell.FontStyleDelta = CType(resources.GetObject("GColNDINNUM.AppearanceCell.FontStyleDelta"), System.Drawing.FontStyle)
        Me.GColNDINNUM.AppearanceCell.GradientMode = CType(resources.GetObject("GColNDINNUM.AppearanceCell.GradientMode"), System.Drawing.Drawing2D.LinearGradientMode)
        Me.GColNDINNUM.AppearanceCell.Image = CType(resources.GetObject("GColNDINNUM.AppearanceCell.Image"), System.Drawing.Image)
        Me.GColNDINNUM.AppearanceCell.Options.UseFont = True
        Me.GColNDINNUM.AppearanceCell.Options.UseTextOptions = True
        Me.GColNDINNUM.AppearanceCell.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center
        Me.GColNDINNUM.AppearanceCell.TextOptions.VAlignment = DevExpress.Utils.VertAlignment.Center
        Me.GColNDINNUM.AppearanceCell.TextOptions.WordWrap = DevExpress.Utils.WordWrap.Wrap
        Me.GColNDINNUM.AppearanceHeader.Font = CType(resources.GetObject("GColNDINNUM.AppearanceHeader.Font"), System.Drawing.Font)
        Me.GColNDINNUM.AppearanceHeader.FontSizeDelta = CType(resources.GetObject("GColNDINNUM.AppearanceHeader.FontSizeDelta"), Integer)
        Me.GColNDINNUM.AppearanceHeader.FontStyleDelta = CType(resources.GetObject("GColNDINNUM.AppearanceHeader.FontStyleDelta"), System.Drawing.FontStyle)
        Me.GColNDINNUM.AppearanceHeader.GradientMode = CType(resources.GetObject("GColNDINNUM.AppearanceHeader.GradientMode"), System.Drawing.Drawing2D.LinearGradientMode)
        Me.GColNDINNUM.AppearanceHeader.Image = CType(resources.GetObject("GColNDINNUM.AppearanceHeader.Image"), System.Drawing.Image)
        resources.ApplyResources(Me.GColNDINNUM, "GColNDINNUM")
        Me.GColNDINNUM.FieldName = "NDINNUM"
        Me.GColNDINNUM.MinWidth = 10
        Me.GColNDINNUM.Name = "GColNDINNUM"
        Me.GColNDINNUM.OptionsColumn.AllowEdit = False
        Me.GColNDINNUM.OptionsColumn.ReadOnly = True
        Me.GColNDINNUM.OptionsFilter.AutoFilterCondition = DevExpress.XtraGrid.Columns.AutoFilterCondition.Contains
        Me.GColNDINNUM.Summary.AddRange(New DevExpress.XtraGrid.GridSummaryItem() {New DevExpress.XtraGrid.GridColumnSummaryItem(CType(resources.GetObject("GColNDINNUM.Summary"), DevExpress.Data.SummaryItemType))})
        '
        'GColVDDEQUICRE
        '
        Me.GColVDDEQUICRE.AppearanceCell.FontSizeDelta = CType(resources.GetObject("GColVDDEQUICRE.AppearanceCell.FontSizeDelta"), Integer)
        Me.GColVDDEQUICRE.AppearanceCell.FontStyleDelta = CType(resources.GetObject("GColVDDEQUICRE.AppearanceCell.FontStyleDelta"), System.Drawing.FontStyle)
        Me.GColVDDEQUICRE.AppearanceCell.GradientMode = CType(resources.GetObject("GColVDDEQUICRE.AppearanceCell.GradientMode"), System.Drawing.Drawing2D.LinearGradientMode)
        Me.GColVDDEQUICRE.AppearanceCell.Image = CType(resources.GetObject("GColVDDEQUICRE.AppearanceCell.Image"), System.Drawing.Image)
        Me.GColVDDEQUICRE.AppearanceCell.Options.UseTextOptions = True
        Me.GColVDDEQUICRE.AppearanceCell.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center
        Me.GColVDDEQUICRE.AppearanceCell.TextOptions.VAlignment = DevExpress.Utils.VertAlignment.Center
        Me.GColVDDEQUICRE.AppearanceCell.TextOptions.WordWrap = DevExpress.Utils.WordWrap.Wrap
        resources.ApplyResources(Me.GColVDDEQUICRE, "GColVDDEQUICRE")
        Me.GColVDDEQUICRE.FieldName = "VDDEQUICRE"
        Me.GColVDDEQUICRE.Name = "GColVDDEQUICRE"
        Me.GColVDDEQUICRE.OptionsFilter.AutoFilterCondition = DevExpress.XtraGrid.Columns.AutoFilterCondition.Contains
        '
        'GColVPERNOM
        '
        Me.GColVPERNOM.AppearanceCell.FontSizeDelta = CType(resources.GetObject("GColVPERNOM.AppearanceCell.FontSizeDelta"), Integer)
        Me.GColVPERNOM.AppearanceCell.FontStyleDelta = CType(resources.GetObject("GColVPERNOM.AppearanceCell.FontStyleDelta"), System.Drawing.FontStyle)
        Me.GColVPERNOM.AppearanceCell.GradientMode = CType(resources.GetObject("GColVPERNOM.AppearanceCell.GradientMode"), System.Drawing.Drawing2D.LinearGradientMode)
        Me.GColVPERNOM.AppearanceCell.Image = CType(resources.GetObject("GColVPERNOM.AppearanceCell.Image"), System.Drawing.Image)
        Me.GColVPERNOM.AppearanceCell.Options.UseTextOptions = True
        Me.GColVPERNOM.AppearanceCell.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center
        Me.GColVPERNOM.AppearanceCell.TextOptions.VAlignment = DevExpress.Utils.VertAlignment.Center
        Me.GColVPERNOM.AppearanceCell.TextOptions.WordWrap = DevExpress.Utils.WordWrap.Wrap
        resources.ApplyResources(Me.GColVPERNOM, "GColVPERNOM")
        Me.GColVPERNOM.FieldName = "VPERNOM"
        Me.GColVPERNOM.Name = "GColVPERNOM"
        Me.GColVPERNOM.OptionsFilter.AutoFilterCondition = DevExpress.XtraGrid.Columns.AutoFilterCondition.Contains
        '
        'GColDDDEDATE
        '
        Me.GColDDDEDATE.AppearanceCell.FontSizeDelta = CType(resources.GetObject("GColDDDEDATE.AppearanceCell.FontSizeDelta"), Integer)
        Me.GColDDDEDATE.AppearanceCell.FontStyleDelta = CType(resources.GetObject("GColDDDEDATE.AppearanceCell.FontStyleDelta"), System.Drawing.FontStyle)
        Me.GColDDDEDATE.AppearanceCell.GradientMode = CType(resources.GetObject("GColDDDEDATE.AppearanceCell.GradientMode"), System.Drawing.Drawing2D.LinearGradientMode)
        Me.GColDDDEDATE.AppearanceCell.Image = CType(resources.GetObject("GColDDDEDATE.AppearanceCell.Image"), System.Drawing.Image)
        Me.GColDDDEDATE.AppearanceCell.Options.UseTextOptions = True
        Me.GColDDDEDATE.AppearanceCell.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center
        Me.GColDDDEDATE.AppearanceCell.TextOptions.VAlignment = DevExpress.Utils.VertAlignment.Center
        Me.GColDDDEDATE.AppearanceCell.TextOptions.WordWrap = DevExpress.Utils.WordWrap.Wrap
        resources.ApplyResources(Me.GColDDDEDATE, "GColDDDEDATE")
        Me.GColDDDEDATE.FieldName = "DDDEDATE"
        Me.GColDDDEDATE.Name = "GColDDDEDATE"
        Me.GColDDDEDATE.OptionsFilter.AutoFilterCondition = DevExpress.XtraGrid.Columns.AutoFilterCondition.Contains
        '
        'GColDDDELIVR
        '
        Me.GColDDDELIVR.AppearanceCell.FontSizeDelta = CType(resources.GetObject("GColDDDELIVR.AppearanceCell.FontSizeDelta"), Integer)
        Me.GColDDDELIVR.AppearanceCell.FontStyleDelta = CType(resources.GetObject("GColDDDELIVR.AppearanceCell.FontStyleDelta"), System.Drawing.FontStyle)
        Me.GColDDDELIVR.AppearanceCell.GradientMode = CType(resources.GetObject("GColDDDELIVR.AppearanceCell.GradientMode"), System.Drawing.Drawing2D.LinearGradientMode)
        Me.GColDDDELIVR.AppearanceCell.Image = CType(resources.GetObject("GColDDDELIVR.AppearanceCell.Image"), System.Drawing.Image)
        Me.GColDDDELIVR.AppearanceCell.Options.UseTextOptions = True
        Me.GColDDDELIVR.AppearanceCell.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center
        Me.GColDDDELIVR.AppearanceCell.TextOptions.VAlignment = DevExpress.Utils.VertAlignment.Center
        Me.GColDDDELIVR.AppearanceCell.TextOptions.WordWrap = DevExpress.Utils.WordWrap.Wrap
        resources.ApplyResources(Me.GColDDDELIVR, "GColDDDELIVR")
        Me.GColDDDELIVR.FieldName = "DDDELIVR"
        Me.GColDDDELIVR.Name = "GColDDDELIVR"
        Me.GColDDDELIVR.OptionsFilter.AutoFilterCondition = DevExpress.XtraGrid.Columns.AutoFilterCondition.Contains
        '
        'GColNDDENUM
        '
        resources.ApplyResources(Me.GColNDDENUM, "GColNDDENUM")
        Me.GColNDDENUM.FieldName = "NDDENUM"
        Me.GColNDDENUM.Name = "GColNDDENUM"
        '
        'GroupBox1
        '
        resources.ApplyResources(Me.GroupBox1, "GroupBox1")
        Me.GroupBox1.Controls.Add(Me.BtnFermer)
        Me.GroupBox1.Controls.Add(Me.BtnPrint)
        Me.GroupBox1.Name = "GroupBox1"
        Me.GroupBox1.TabStop = False
        '
        'BtnFermer
        '
        resources.ApplyResources(Me.BtnFermer, "BtnFermer")
        Me.BtnFermer.Name = "BtnFermer"
        Me.BtnFermer.UseVisualStyleBackColor = True
        '
        'BtnPrint
        '
        resources.ApplyResources(Me.BtnPrint, "BtnPrint")
        Me.BtnPrint.Name = "BtnPrint"
        Me.BtnPrint.UseVisualStyleBackColor = True
        '
        'LabelTitre
        '
        resources.ApplyResources(Me.LabelTitre, "LabelTitre")
        Me.LabelTitre.Name = "LabelTitre"
        '
        'lblDateJour
        '
        resources.ApplyResources(Me.lblDateJour, "lblDateJour")
        Me.lblDateJour.Name = "lblDateJour"
        '
        'frmStatEIReappro
        '
        resources.ApplyResources(Me, "$this")
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.Wheat
        Me.Controls.Add(Me.lblDateJour)
        Me.Controls.Add(Me.GCListeEIReappro)
        Me.Controls.Add(Me.GroupBox1)
        Me.Controls.Add(Me.LabelTitre)
        Me.Name = "frmStatEIReappro"
        Me.WindowState = System.Windows.Forms.FormWindowState.Maximized
        CType(Me.GVListeEIReapproDetail, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.GCListeEIReappro, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.GVListeEIReappro, System.ComponentModel.ISupportInitialize).EndInit()
        Me.GroupBox1.ResumeLayout(False)
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents GroupBox1 As System.Windows.Forms.GroupBox
    Friend WithEvents BtnFermer As System.Windows.Forms.Button
    Friend WithEvents BtnPrint As System.Windows.Forms.Button
    Friend WithEvents LabelTitre As System.Windows.Forms.Label
    Friend WithEvents lblDateJour As System.Windows.Forms.Label
    Private WithEvents GCListeEIReappro As DevExpress.XtraGrid.GridControl
    Private WithEvents GVListeEIReappro As DevExpress.XtraGrid.Views.Grid.GridView
    Private WithEvents GColNDINNUM As DevExpress.XtraGrid.Columns.GridColumn
    Private WithEvents GColVDDEQUICRE As DevExpress.XtraGrid.Columns.GridColumn
    Private WithEvents GColVPERNOM As DevExpress.XtraGrid.Columns.GridColumn
    Private WithEvents GColDDDEDATE As DevExpress.XtraGrid.Columns.GridColumn
    Private WithEvents GColDDDELIVR As DevExpress.XtraGrid.Columns.GridColumn
    Private WithEvents GVListeEIReapproDetail As DevExpress.XtraGrid.Views.Grid.GridView
    Private WithEvents GColDetailVLART As DevExpress.XtraGrid.Columns.GridColumn
    Private WithEvents GColDetailNLARTQTE As DevExpress.XtraGrid.Columns.GridColumn
    Private WithEvents GColNDDENUM As DevExpress.XtraGrid.Columns.GridColumn
End Class
