<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class frmListeCommandeReapproAValider
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
    Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(frmListeCommandeReapproAValider))
    Me.GrpActions = New System.Windows.Forms.GroupBox()
    Me.BtnArchives = New System.Windows.Forms.Button()
    Me.BtnMod = New System.Windows.Forms.Button()
    Me.BtnSupprLine = New System.Windows.Forms.Button()
    Me.BtnQuit = New System.Windows.Forms.Button()
    Me.Label1 = New System.Windows.Forms.Label()
    Me.GCREAPPRO = New DevExpress.XtraGrid.GridControl()
    Me.GVREAPPRO = New DevExpress.XtraGrid.Views.Grid.GridView()
    Me.GColNCMDWEBNUM = New DevExpress.XtraGrid.Columns.GridColumn()
    Me.GColDCMDDATE = New DevExpress.XtraGrid.Columns.GridColumn()
    Me.GColVTECHNOM = New DevExpress.XtraGrid.Columns.GridColumn()
    Me.GColVMESSAGE = New DevExpress.XtraGrid.Columns.GridColumn()
    Me.GColCLIEU_LIVR = New DevExpress.XtraGrid.Columns.GridColumn()
    Me.GColVLIEU_LIVR = New DevExpress.XtraGrid.Columns.GridColumn()
    Me.GColDDATELIVR = New DevExpress.XtraGrid.Columns.GridColumn()
    Me.GColBMESSAGEVU = New DevExpress.XtraGrid.Columns.GridColumn()
    Me.GColVMESSAGEVU = New DevExpress.XtraGrid.Columns.GridColumn()
    Me.GColNQUIVALID = New DevExpress.XtraGrid.Columns.GridColumn()
    Me.GColDQUIVALID = New DevExpress.XtraGrid.Columns.GridColumn()
    Me.GColNPERNUM_DEMAND = New DevExpress.XtraGrid.Columns.GridColumn()
    Me.GColVSOCIETE = New DevExpress.XtraGrid.Columns.GridColumn()
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
    Me.RepositoryItemCheckEdit1 = New DevExpress.XtraEditors.Repository.RepositoryItemCheckEdit()
    Me.GrpActions.SuspendLayout()
    CType(Me.GCREAPPRO, System.ComponentModel.ISupportInitialize).BeginInit()
    CType(Me.GVREAPPRO, System.ComponentModel.ISupportInitialize).BeginInit()
    CType(Me.RepItemGLUpEditGTPLot, System.ComponentModel.ISupportInitialize).BeginInit()
    CType(Me.RepIGLUpEditViewLot, System.ComponentModel.ISupportInitialize).BeginInit()
    CType(Me.RepItemGLUpEditUnite, System.ComponentModel.ISupportInitialize).BeginInit()
    CType(Me.RepItemGLUpEditViewUnite, System.ComponentModel.ISupportInitialize).BeginInit()
    CType(Me.RepositoryItemCheckEdit1, System.ComponentModel.ISupportInitialize).BeginInit()
    Me.SuspendLayout()
    '
    'GrpActions
    '
    resources.ApplyResources(Me.GrpActions, "GrpActions")
    Me.GrpActions.Controls.Add(Me.BtnArchives)
    Me.GrpActions.Controls.Add(Me.BtnMod)
    Me.GrpActions.Controls.Add(Me.BtnSupprLine)
    Me.GrpActions.Controls.Add(Me.BtnQuit)
    Me.GrpActions.Name = "GrpActions"
    Me.GrpActions.TabStop = False
    '
    'BtnArchives
    '
    resources.ApplyResources(Me.BtnArchives, "BtnArchives")
    Me.BtnArchives.BackColor = System.Drawing.Color.Gainsboro
    Me.BtnArchives.Name = "BtnArchives"
    Me.BtnArchives.UseVisualStyleBackColor = False
    '
    'BtnMod
    '
    resources.ApplyResources(Me.BtnMod, "BtnMod")
    Me.BtnMod.BackColor = System.Drawing.Color.Gainsboro
    Me.BtnMod.Name = "BtnMod"
    Me.BtnMod.UseVisualStyleBackColor = False
    '
    'BtnSupprLine
    '
    resources.ApplyResources(Me.BtnSupprLine, "BtnSupprLine")
    Me.BtnSupprLine.BackColor = System.Drawing.Color.Gainsboro
    Me.BtnSupprLine.Name = "BtnSupprLine"
    Me.BtnSupprLine.UseVisualStyleBackColor = False
    '
    'BtnQuit
    '
    resources.ApplyResources(Me.BtnQuit, "BtnQuit")
    Me.BtnQuit.Name = "BtnQuit"
    Me.BtnQuit.UseVisualStyleBackColor = True
    '
    'Label1
    '
    resources.ApplyResources(Me.Label1, "Label1")
    Me.Label1.Name = "Label1"
    '
    'GCREAPPRO
    '
    resources.ApplyResources(Me.GCREAPPRO, "GCREAPPRO")
    Me.GCREAPPRO.EmbeddedNavigator.AccessibleDescription = resources.GetString("GCREAPPRO.EmbeddedNavigator.AccessibleDescription")
    Me.GCREAPPRO.EmbeddedNavigator.AccessibleName = resources.GetString("GCREAPPRO.EmbeddedNavigator.AccessibleName")
    Me.GCREAPPRO.EmbeddedNavigator.AllowHtmlTextInToolTip = CType(resources.GetObject("GCREAPPRO.EmbeddedNavigator.AllowHtmlTextInToolTip"), DevExpress.Utils.DefaultBoolean)
    Me.GCREAPPRO.EmbeddedNavigator.Anchor = CType(resources.GetObject("GCREAPPRO.EmbeddedNavigator.Anchor"), System.Windows.Forms.AnchorStyles)
    Me.GCREAPPRO.EmbeddedNavigator.BackgroundImage = CType(resources.GetObject("GCREAPPRO.EmbeddedNavigator.BackgroundImage"), System.Drawing.Image)
    Me.GCREAPPRO.EmbeddedNavigator.BackgroundImageLayout = CType(resources.GetObject("GCREAPPRO.EmbeddedNavigator.BackgroundImageLayout"), System.Windows.Forms.ImageLayout)
    Me.GCREAPPRO.EmbeddedNavigator.ImeMode = CType(resources.GetObject("GCREAPPRO.EmbeddedNavigator.ImeMode"), System.Windows.Forms.ImeMode)
    Me.GCREAPPRO.EmbeddedNavigator.MaximumSize = CType(resources.GetObject("GCREAPPRO.EmbeddedNavigator.MaximumSize"), System.Drawing.Size)
    Me.GCREAPPRO.EmbeddedNavigator.TextLocation = CType(resources.GetObject("GCREAPPRO.EmbeddedNavigator.TextLocation"), DevExpress.XtraEditors.NavigatorButtonsTextLocation)
    Me.GCREAPPRO.EmbeddedNavigator.ToolTip = resources.GetString("GCREAPPRO.EmbeddedNavigator.ToolTip")
    Me.GCREAPPRO.EmbeddedNavigator.ToolTipIconType = CType(resources.GetObject("GCREAPPRO.EmbeddedNavigator.ToolTipIconType"), DevExpress.Utils.ToolTipIconType)
    Me.GCREAPPRO.EmbeddedNavigator.ToolTipTitle = resources.GetString("GCREAPPRO.EmbeddedNavigator.ToolTipTitle")
    Me.GCREAPPRO.MainView = Me.GVREAPPRO
    Me.GCREAPPRO.Name = "GCREAPPRO"
    Me.GCREAPPRO.RepositoryItems.AddRange(New DevExpress.XtraEditors.Repository.RepositoryItem() {Me.RepItemGLUpEditGTPLot, Me.RepItemGLUpEditUnite, Me.RepositoryItemCheckEdit1})
    Me.GCREAPPRO.ViewCollection.AddRange(New DevExpress.XtraGrid.Views.Base.BaseView() {Me.GVREAPPRO})
    '
    'GVREAPPRO
    '
    Me.GVREAPPRO.Appearance.ColumnFilterButton.BackColor = System.Drawing.Color.FromArgb(CType(CType(236, Byte), Integer), CType(CType(232, Byte), Integer), CType(CType(201, Byte), Integer))
    Me.GVREAPPRO.Appearance.ColumnFilterButton.BorderColor = System.Drawing.Color.FromArgb(CType(CType(236, Byte), Integer), CType(CType(232, Byte), Integer), CType(CType(201, Byte), Integer))
    Me.GVREAPPRO.Appearance.ColumnFilterButton.FontSizeDelta = CType(resources.GetObject("GVREAPPRO.Appearance.ColumnFilterButton.FontSizeDelta"), Integer)
    Me.GVREAPPRO.Appearance.ColumnFilterButton.FontStyleDelta = CType(resources.GetObject("GVREAPPRO.Appearance.ColumnFilterButton.FontStyleDelta"), System.Drawing.FontStyle)
    Me.GVREAPPRO.Appearance.ColumnFilterButton.ForeColor = System.Drawing.Color.Black
    Me.GVREAPPRO.Appearance.ColumnFilterButton.GradientMode = CType(resources.GetObject("GVREAPPRO.Appearance.ColumnFilterButton.GradientMode"), System.Drawing.Drawing2D.LinearGradientMode)
    Me.GVREAPPRO.Appearance.ColumnFilterButton.Image = CType(resources.GetObject("GVREAPPRO.Appearance.ColumnFilterButton.Image"), System.Drawing.Image)
    Me.GVREAPPRO.Appearance.ColumnFilterButton.Options.UseBackColor = True
    Me.GVREAPPRO.Appearance.ColumnFilterButton.Options.UseBorderColor = True
    Me.GVREAPPRO.Appearance.ColumnFilterButton.Options.UseForeColor = True
    Me.GVREAPPRO.Appearance.ColumnFilterButtonActive.BackColor = System.Drawing.Color.FromArgb(CType(CType(221, Byte), Integer), CType(CType(231, Byte), Integer), CType(CType(234, Byte), Integer))
    Me.GVREAPPRO.Appearance.ColumnFilterButtonActive.BorderColor = System.Drawing.Color.FromArgb(CType(CType(221, Byte), Integer), CType(CType(231, Byte), Integer), CType(CType(234, Byte), Integer))
    Me.GVREAPPRO.Appearance.ColumnFilterButtonActive.FontSizeDelta = CType(resources.GetObject("GVREAPPRO.Appearance.ColumnFilterButtonActive.FontSizeDelta"), Integer)
    Me.GVREAPPRO.Appearance.ColumnFilterButtonActive.FontStyleDelta = CType(resources.GetObject("GVREAPPRO.Appearance.ColumnFilterButtonActive.FontStyleDelta"), System.Drawing.FontStyle)
    Me.GVREAPPRO.Appearance.ColumnFilterButtonActive.ForeColor = System.Drawing.Color.Black
    Me.GVREAPPRO.Appearance.ColumnFilterButtonActive.GradientMode = CType(resources.GetObject("GVREAPPRO.Appearance.ColumnFilterButtonActive.GradientMode"), System.Drawing.Drawing2D.LinearGradientMode)
    Me.GVREAPPRO.Appearance.ColumnFilterButtonActive.Image = CType(resources.GetObject("GVREAPPRO.Appearance.ColumnFilterButtonActive.Image"), System.Drawing.Image)
    Me.GVREAPPRO.Appearance.ColumnFilterButtonActive.Options.UseBackColor = True
    Me.GVREAPPRO.Appearance.ColumnFilterButtonActive.Options.UseBorderColor = True
    Me.GVREAPPRO.Appearance.ColumnFilterButtonActive.Options.UseForeColor = True
    Me.GVREAPPRO.Appearance.Empty.BackColor = System.Drawing.Color.FromArgb(CType(CType(236, Byte), Integer), CType(CType(232, Byte), Integer), CType(CType(201, Byte), Integer))
    Me.GVREAPPRO.Appearance.Empty.BackColor2 = CType(resources.GetObject("GVREAPPRO.Appearance.Empty.BackColor2"), System.Drawing.Color)
    Me.GVREAPPRO.Appearance.Empty.FontSizeDelta = CType(resources.GetObject("GVREAPPRO.Appearance.Empty.FontSizeDelta"), Integer)
    Me.GVREAPPRO.Appearance.Empty.FontStyleDelta = CType(resources.GetObject("GVREAPPRO.Appearance.Empty.FontStyleDelta"), System.Drawing.FontStyle)
    Me.GVREAPPRO.Appearance.Empty.GradientMode = CType(resources.GetObject("GVREAPPRO.Appearance.Empty.GradientMode"), System.Drawing.Drawing2D.LinearGradientMode)
    Me.GVREAPPRO.Appearance.Empty.Image = CType(resources.GetObject("GVREAPPRO.Appearance.Empty.Image"), System.Drawing.Image)
    Me.GVREAPPRO.Appearance.Empty.Options.UseBackColor = True
    Me.GVREAPPRO.Appearance.EvenRow.BackColor = System.Drawing.Color.FromArgb(CType(CType(221, Byte), Integer), CType(CType(231, Byte), Integer), CType(CType(234, Byte), Integer))
    Me.GVREAPPRO.Appearance.EvenRow.BorderColor = System.Drawing.Color.FromArgb(CType(CType(221, Byte), Integer), CType(CType(231, Byte), Integer), CType(CType(234, Byte), Integer))
    Me.GVREAPPRO.Appearance.EvenRow.FontSizeDelta = CType(resources.GetObject("GVREAPPRO.Appearance.EvenRow.FontSizeDelta"), Integer)
    Me.GVREAPPRO.Appearance.EvenRow.FontStyleDelta = CType(resources.GetObject("GVREAPPRO.Appearance.EvenRow.FontStyleDelta"), System.Drawing.FontStyle)
    Me.GVREAPPRO.Appearance.EvenRow.ForeColor = System.Drawing.Color.Black
    Me.GVREAPPRO.Appearance.EvenRow.GradientMode = CType(resources.GetObject("GVREAPPRO.Appearance.EvenRow.GradientMode"), System.Drawing.Drawing2D.LinearGradientMode)
    Me.GVREAPPRO.Appearance.EvenRow.Image = CType(resources.GetObject("GVREAPPRO.Appearance.EvenRow.Image"), System.Drawing.Image)
    Me.GVREAPPRO.Appearance.EvenRow.Options.UseBackColor = True
    Me.GVREAPPRO.Appearance.EvenRow.Options.UseBorderColor = True
    Me.GVREAPPRO.Appearance.EvenRow.Options.UseForeColor = True
    Me.GVREAPPRO.Appearance.FilterCloseButton.BackColor = System.Drawing.Color.FromArgb(CType(CType(216, Byte), Integer), CType(CType(209, Byte), Integer), CType(CType(179, Byte), Integer))
    Me.GVREAPPRO.Appearance.FilterCloseButton.BorderColor = System.Drawing.Color.FromArgb(CType(CType(216, Byte), Integer), CType(CType(209, Byte), Integer), CType(CType(179, Byte), Integer))
    Me.GVREAPPRO.Appearance.FilterCloseButton.FontSizeDelta = CType(resources.GetObject("GVREAPPRO.Appearance.FilterCloseButton.FontSizeDelta"), Integer)
    Me.GVREAPPRO.Appearance.FilterCloseButton.FontStyleDelta = CType(resources.GetObject("GVREAPPRO.Appearance.FilterCloseButton.FontStyleDelta"), System.Drawing.FontStyle)
    Me.GVREAPPRO.Appearance.FilterCloseButton.ForeColor = System.Drawing.Color.Black
    Me.GVREAPPRO.Appearance.FilterCloseButton.GradientMode = CType(resources.GetObject("GVREAPPRO.Appearance.FilterCloseButton.GradientMode"), System.Drawing.Drawing2D.LinearGradientMode)
    Me.GVREAPPRO.Appearance.FilterCloseButton.Image = CType(resources.GetObject("GVREAPPRO.Appearance.FilterCloseButton.Image"), System.Drawing.Image)
    Me.GVREAPPRO.Appearance.FilterCloseButton.Options.UseBackColor = True
    Me.GVREAPPRO.Appearance.FilterCloseButton.Options.UseBorderColor = True
    Me.GVREAPPRO.Appearance.FilterCloseButton.Options.UseForeColor = True
    Me.GVREAPPRO.Appearance.FilterPanel.BackColor = System.Drawing.Color.FromArgb(CType(CType(236, Byte), Integer), CType(CType(232, Byte), Integer), CType(CType(201, Byte), Integer))
    Me.GVREAPPRO.Appearance.FilterPanel.BackColor2 = CType(resources.GetObject("GVREAPPRO.Appearance.FilterPanel.BackColor2"), System.Drawing.Color)
    Me.GVREAPPRO.Appearance.FilterPanel.FontSizeDelta = CType(resources.GetObject("GVREAPPRO.Appearance.FilterPanel.FontSizeDelta"), Integer)
    Me.GVREAPPRO.Appearance.FilterPanel.FontStyleDelta = CType(resources.GetObject("GVREAPPRO.Appearance.FilterPanel.FontStyleDelta"), System.Drawing.FontStyle)
    Me.GVREAPPRO.Appearance.FilterPanel.ForeColor = System.Drawing.Color.Black
    Me.GVREAPPRO.Appearance.FilterPanel.GradientMode = CType(resources.GetObject("GVREAPPRO.Appearance.FilterPanel.GradientMode"), System.Drawing.Drawing2D.LinearGradientMode)
    Me.GVREAPPRO.Appearance.FilterPanel.Image = CType(resources.GetObject("GVREAPPRO.Appearance.FilterPanel.Image"), System.Drawing.Image)
    Me.GVREAPPRO.Appearance.FilterPanel.Options.UseBackColor = True
    Me.GVREAPPRO.Appearance.FilterPanel.Options.UseForeColor = True
    Me.GVREAPPRO.Appearance.FixedLine.BackColor = System.Drawing.Color.FromArgb(CType(CType(122, Byte), Integer), CType(CType(114, Byte), Integer), CType(CType(113, Byte), Integer))
    Me.GVREAPPRO.Appearance.FixedLine.FontSizeDelta = CType(resources.GetObject("GVREAPPRO.Appearance.FixedLine.FontSizeDelta"), Integer)
    Me.GVREAPPRO.Appearance.FixedLine.FontStyleDelta = CType(resources.GetObject("GVREAPPRO.Appearance.FixedLine.FontStyleDelta"), System.Drawing.FontStyle)
    Me.GVREAPPRO.Appearance.FixedLine.GradientMode = CType(resources.GetObject("GVREAPPRO.Appearance.FixedLine.GradientMode"), System.Drawing.Drawing2D.LinearGradientMode)
    Me.GVREAPPRO.Appearance.FixedLine.Image = CType(resources.GetObject("GVREAPPRO.Appearance.FixedLine.Image"), System.Drawing.Image)
    Me.GVREAPPRO.Appearance.FixedLine.Options.UseBackColor = True
    Me.GVREAPPRO.Appearance.FocusedCell.BackColor = System.Drawing.Color.White
    Me.GVREAPPRO.Appearance.FocusedCell.FontSizeDelta = CType(resources.GetObject("GVREAPPRO.Appearance.FocusedCell.FontSizeDelta"), Integer)
    Me.GVREAPPRO.Appearance.FocusedCell.FontStyleDelta = CType(resources.GetObject("GVREAPPRO.Appearance.FocusedCell.FontStyleDelta"), System.Drawing.FontStyle)
    Me.GVREAPPRO.Appearance.FocusedCell.ForeColor = System.Drawing.Color.Black
    Me.GVREAPPRO.Appearance.FocusedCell.GradientMode = CType(resources.GetObject("GVREAPPRO.Appearance.FocusedCell.GradientMode"), System.Drawing.Drawing2D.LinearGradientMode)
    Me.GVREAPPRO.Appearance.FocusedCell.Image = CType(resources.GetObject("GVREAPPRO.Appearance.FocusedCell.Image"), System.Drawing.Image)
    Me.GVREAPPRO.Appearance.FocusedCell.Options.UseBackColor = True
    Me.GVREAPPRO.Appearance.FocusedCell.Options.UseForeColor = True
    Me.GVREAPPRO.Appearance.FocusedRow.BackColor = System.Drawing.Color.FromArgb(CType(CType(200, Byte), Integer), CType(CType(192, Byte), Integer), CType(CType(157, Byte), Integer))
    Me.GVREAPPRO.Appearance.FocusedRow.BorderColor = System.Drawing.Color.FromArgb(CType(CType(226, Byte), Integer), CType(CType(219, Byte), Integer), CType(CType(188, Byte), Integer))
    Me.GVREAPPRO.Appearance.FocusedRow.FontSizeDelta = CType(resources.GetObject("GVREAPPRO.Appearance.FocusedRow.FontSizeDelta"), Integer)
    Me.GVREAPPRO.Appearance.FocusedRow.FontStyleDelta = CType(resources.GetObject("GVREAPPRO.Appearance.FocusedRow.FontStyleDelta"), System.Drawing.FontStyle)
    Me.GVREAPPRO.Appearance.FocusedRow.ForeColor = System.Drawing.Color.Black
    Me.GVREAPPRO.Appearance.FocusedRow.GradientMode = CType(resources.GetObject("GVREAPPRO.Appearance.FocusedRow.GradientMode"), System.Drawing.Drawing2D.LinearGradientMode)
    Me.GVREAPPRO.Appearance.FocusedRow.Image = CType(resources.GetObject("GVREAPPRO.Appearance.FocusedRow.Image"), System.Drawing.Image)
    Me.GVREAPPRO.Appearance.FocusedRow.Options.UseBackColor = True
    Me.GVREAPPRO.Appearance.FocusedRow.Options.UseBorderColor = True
    Me.GVREAPPRO.Appearance.FocusedRow.Options.UseForeColor = True
    Me.GVREAPPRO.Appearance.FooterPanel.BackColor = System.Drawing.Color.FromArgb(CType(CType(216, Byte), Integer), CType(CType(209, Byte), Integer), CType(CType(170, Byte), Integer))
    Me.GVREAPPRO.Appearance.FooterPanel.BorderColor = System.Drawing.Color.FromArgb(CType(CType(216, Byte), Integer), CType(CType(209, Byte), Integer), CType(CType(170, Byte), Integer))
    Me.GVREAPPRO.Appearance.FooterPanel.FontSizeDelta = CType(resources.GetObject("GVREAPPRO.Appearance.FooterPanel.FontSizeDelta"), Integer)
    Me.GVREAPPRO.Appearance.FooterPanel.FontStyleDelta = CType(resources.GetObject("GVREAPPRO.Appearance.FooterPanel.FontStyleDelta"), System.Drawing.FontStyle)
    Me.GVREAPPRO.Appearance.FooterPanel.ForeColor = System.Drawing.Color.Black
    Me.GVREAPPRO.Appearance.FooterPanel.GradientMode = CType(resources.GetObject("GVREAPPRO.Appearance.FooterPanel.GradientMode"), System.Drawing.Drawing2D.LinearGradientMode)
    Me.GVREAPPRO.Appearance.FooterPanel.Image = CType(resources.GetObject("GVREAPPRO.Appearance.FooterPanel.Image"), System.Drawing.Image)
    Me.GVREAPPRO.Appearance.FooterPanel.Options.UseBackColor = True
    Me.GVREAPPRO.Appearance.FooterPanel.Options.UseBorderColor = True
    Me.GVREAPPRO.Appearance.FooterPanel.Options.UseForeColor = True
    Me.GVREAPPRO.Appearance.GroupButton.BackColor = System.Drawing.Color.FromArgb(CType(CType(216, Byte), Integer), CType(CType(209, Byte), Integer), CType(CType(179, Byte), Integer))
    Me.GVREAPPRO.Appearance.GroupButton.BorderColor = System.Drawing.Color.FromArgb(CType(CType(216, Byte), Integer), CType(CType(209, Byte), Integer), CType(CType(179, Byte), Integer))
    Me.GVREAPPRO.Appearance.GroupButton.FontSizeDelta = CType(resources.GetObject("GVREAPPRO.Appearance.GroupButton.FontSizeDelta"), Integer)
    Me.GVREAPPRO.Appearance.GroupButton.FontStyleDelta = CType(resources.GetObject("GVREAPPRO.Appearance.GroupButton.FontStyleDelta"), System.Drawing.FontStyle)
    Me.GVREAPPRO.Appearance.GroupButton.GradientMode = CType(resources.GetObject("GVREAPPRO.Appearance.GroupButton.GradientMode"), System.Drawing.Drawing2D.LinearGradientMode)
    Me.GVREAPPRO.Appearance.GroupButton.Image = CType(resources.GetObject("GVREAPPRO.Appearance.GroupButton.Image"), System.Drawing.Image)
    Me.GVREAPPRO.Appearance.GroupButton.Options.UseBackColor = True
    Me.GVREAPPRO.Appearance.GroupButton.Options.UseBorderColor = True
    Me.GVREAPPRO.Appearance.GroupFooter.BackColor = System.Drawing.Color.FromArgb(CType(CType(236, Byte), Integer), CType(CType(232, Byte), Integer), CType(CType(201, Byte), Integer))
    Me.GVREAPPRO.Appearance.GroupFooter.BorderColor = System.Drawing.Color.FromArgb(CType(CType(236, Byte), Integer), CType(CType(232, Byte), Integer), CType(CType(201, Byte), Integer))
    Me.GVREAPPRO.Appearance.GroupFooter.FontSizeDelta = CType(resources.GetObject("GVREAPPRO.Appearance.GroupFooter.FontSizeDelta"), Integer)
    Me.GVREAPPRO.Appearance.GroupFooter.FontStyleDelta = CType(resources.GetObject("GVREAPPRO.Appearance.GroupFooter.FontStyleDelta"), System.Drawing.FontStyle)
    Me.GVREAPPRO.Appearance.GroupFooter.ForeColor = System.Drawing.Color.Black
    Me.GVREAPPRO.Appearance.GroupFooter.GradientMode = CType(resources.GetObject("GVREAPPRO.Appearance.GroupFooter.GradientMode"), System.Drawing.Drawing2D.LinearGradientMode)
    Me.GVREAPPRO.Appearance.GroupFooter.Image = CType(resources.GetObject("GVREAPPRO.Appearance.GroupFooter.Image"), System.Drawing.Image)
    Me.GVREAPPRO.Appearance.GroupFooter.Options.UseBackColor = True
    Me.GVREAPPRO.Appearance.GroupFooter.Options.UseBorderColor = True
    Me.GVREAPPRO.Appearance.GroupFooter.Options.UseForeColor = True
    Me.GVREAPPRO.Appearance.GroupPanel.BackColor = System.Drawing.Color.FromArgb(CType(CType(246, Byte), Integer), CType(CType(242, Byte), Integer), CType(CType(213, Byte), Integer))
    Me.GVREAPPRO.Appearance.GroupPanel.BackColor2 = CType(resources.GetObject("GVREAPPRO.Appearance.GroupPanel.BackColor2"), System.Drawing.Color)
    Me.GVREAPPRO.Appearance.GroupPanel.FontSizeDelta = CType(resources.GetObject("GVREAPPRO.Appearance.GroupPanel.FontSizeDelta"), Integer)
    Me.GVREAPPRO.Appearance.GroupPanel.FontStyleDelta = CType(resources.GetObject("GVREAPPRO.Appearance.GroupPanel.FontStyleDelta"), System.Drawing.FontStyle)
    Me.GVREAPPRO.Appearance.GroupPanel.ForeColor = System.Drawing.Color.Black
    Me.GVREAPPRO.Appearance.GroupPanel.GradientMode = CType(resources.GetObject("GVREAPPRO.Appearance.GroupPanel.GradientMode"), System.Drawing.Drawing2D.LinearGradientMode)
    Me.GVREAPPRO.Appearance.GroupPanel.Image = CType(resources.GetObject("GVREAPPRO.Appearance.GroupPanel.Image"), System.Drawing.Image)
    Me.GVREAPPRO.Appearance.GroupPanel.Options.UseBackColor = True
    Me.GVREAPPRO.Appearance.GroupPanel.Options.UseForeColor = True
    Me.GVREAPPRO.Appearance.GroupRow.BackColor = System.Drawing.Color.FromArgb(CType(CType(236, Byte), Integer), CType(CType(232, Byte), Integer), CType(CType(201, Byte), Integer))
    Me.GVREAPPRO.Appearance.GroupRow.BorderColor = System.Drawing.Color.FromArgb(CType(CType(236, Byte), Integer), CType(CType(232, Byte), Integer), CType(CType(201, Byte), Integer))
    Me.GVREAPPRO.Appearance.GroupRow.FontSizeDelta = CType(resources.GetObject("GVREAPPRO.Appearance.GroupRow.FontSizeDelta"), Integer)
    Me.GVREAPPRO.Appearance.GroupRow.FontStyleDelta = CType(resources.GetObject("GVREAPPRO.Appearance.GroupRow.FontStyleDelta"), System.Drawing.FontStyle)
    Me.GVREAPPRO.Appearance.GroupRow.ForeColor = System.Drawing.Color.Black
    Me.GVREAPPRO.Appearance.GroupRow.GradientMode = CType(resources.GetObject("GVREAPPRO.Appearance.GroupRow.GradientMode"), System.Drawing.Drawing2D.LinearGradientMode)
    Me.GVREAPPRO.Appearance.GroupRow.Image = CType(resources.GetObject("GVREAPPRO.Appearance.GroupRow.Image"), System.Drawing.Image)
    Me.GVREAPPRO.Appearance.GroupRow.Options.UseBackColor = True
    Me.GVREAPPRO.Appearance.GroupRow.Options.UseBorderColor = True
    Me.GVREAPPRO.Appearance.GroupRow.Options.UseForeColor = True
    Me.GVREAPPRO.Appearance.HeaderPanel.BackColor = System.Drawing.Color.FromArgb(CType(CType(216, Byte), Integer), CType(CType(209, Byte), Integer), CType(CType(170, Byte), Integer))
    Me.GVREAPPRO.Appearance.HeaderPanel.BorderColor = System.Drawing.Color.FromArgb(CType(CType(216, Byte), Integer), CType(CType(209, Byte), Integer), CType(CType(170, Byte), Integer))
    Me.GVREAPPRO.Appearance.HeaderPanel.Font = CType(resources.GetObject("GVREAPPRO.Appearance.HeaderPanel.Font"), System.Drawing.Font)
    Me.GVREAPPRO.Appearance.HeaderPanel.FontSizeDelta = CType(resources.GetObject("GVREAPPRO.Appearance.HeaderPanel.FontSizeDelta"), Integer)
    Me.GVREAPPRO.Appearance.HeaderPanel.FontStyleDelta = CType(resources.GetObject("GVREAPPRO.Appearance.HeaderPanel.FontStyleDelta"), System.Drawing.FontStyle)
    Me.GVREAPPRO.Appearance.HeaderPanel.ForeColor = System.Drawing.Color.Black
    Me.GVREAPPRO.Appearance.HeaderPanel.GradientMode = CType(resources.GetObject("GVREAPPRO.Appearance.HeaderPanel.GradientMode"), System.Drawing.Drawing2D.LinearGradientMode)
    Me.GVREAPPRO.Appearance.HeaderPanel.Image = CType(resources.GetObject("GVREAPPRO.Appearance.HeaderPanel.Image"), System.Drawing.Image)
    Me.GVREAPPRO.Appearance.HeaderPanel.Options.UseBackColor = True
    Me.GVREAPPRO.Appearance.HeaderPanel.Options.UseBorderColor = True
    Me.GVREAPPRO.Appearance.HeaderPanel.Options.UseFont = True
    Me.GVREAPPRO.Appearance.HeaderPanel.Options.UseForeColor = True
    Me.GVREAPPRO.Appearance.HeaderPanel.Options.UseTextOptions = True
    Me.GVREAPPRO.Appearance.HeaderPanel.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center
    Me.GVREAPPRO.Appearance.HeaderPanel.TextOptions.VAlignment = DevExpress.Utils.VertAlignment.Center
    Me.GVREAPPRO.Appearance.HeaderPanel.TextOptions.WordWrap = DevExpress.Utils.WordWrap.Wrap
    Me.GVREAPPRO.Appearance.HideSelectionRow.BackColor = System.Drawing.Color.FromArgb(CType(CType(237, Byte), Integer), CType(CType(230, Byte), Integer), CType(CType(203, Byte), Integer))
    Me.GVREAPPRO.Appearance.HideSelectionRow.BorderColor = System.Drawing.Color.FromArgb(CType(CType(237, Byte), Integer), CType(CType(230, Byte), Integer), CType(CType(203, Byte), Integer))
    Me.GVREAPPRO.Appearance.HideSelectionRow.FontSizeDelta = CType(resources.GetObject("GVREAPPRO.Appearance.HideSelectionRow.FontSizeDelta"), Integer)
    Me.GVREAPPRO.Appearance.HideSelectionRow.FontStyleDelta = CType(resources.GetObject("GVREAPPRO.Appearance.HideSelectionRow.FontStyleDelta"), System.Drawing.FontStyle)
    Me.GVREAPPRO.Appearance.HideSelectionRow.ForeColor = System.Drawing.Color.Black
    Me.GVREAPPRO.Appearance.HideSelectionRow.GradientMode = CType(resources.GetObject("GVREAPPRO.Appearance.HideSelectionRow.GradientMode"), System.Drawing.Drawing2D.LinearGradientMode)
    Me.GVREAPPRO.Appearance.HideSelectionRow.Image = CType(resources.GetObject("GVREAPPRO.Appearance.HideSelectionRow.Image"), System.Drawing.Image)
    Me.GVREAPPRO.Appearance.HideSelectionRow.Options.UseBackColor = True
    Me.GVREAPPRO.Appearance.HideSelectionRow.Options.UseBorderColor = True
    Me.GVREAPPRO.Appearance.HideSelectionRow.Options.UseForeColor = True
    Me.GVREAPPRO.Appearance.HorzLine.BackColor = System.Drawing.Color.FromArgb(CType(CType(216, Byte), Integer), CType(CType(209, Byte), Integer), CType(CType(170, Byte), Integer))
    Me.GVREAPPRO.Appearance.HorzLine.FontSizeDelta = CType(resources.GetObject("GVREAPPRO.Appearance.HorzLine.FontSizeDelta"), Integer)
    Me.GVREAPPRO.Appearance.HorzLine.FontStyleDelta = CType(resources.GetObject("GVREAPPRO.Appearance.HorzLine.FontStyleDelta"), System.Drawing.FontStyle)
    Me.GVREAPPRO.Appearance.HorzLine.GradientMode = CType(resources.GetObject("GVREAPPRO.Appearance.HorzLine.GradientMode"), System.Drawing.Drawing2D.LinearGradientMode)
    Me.GVREAPPRO.Appearance.HorzLine.Image = CType(resources.GetObject("GVREAPPRO.Appearance.HorzLine.Image"), System.Drawing.Image)
    Me.GVREAPPRO.Appearance.HorzLine.Options.UseBackColor = True
    Me.GVREAPPRO.Appearance.OddRow.BackColor = System.Drawing.Color.FromArgb(CType(CType(242, Byte), Integer), CType(CType(244, Byte), Integer), CType(CType(236, Byte), Integer))
    Me.GVREAPPRO.Appearance.OddRow.BorderColor = System.Drawing.Color.FromArgb(CType(CType(242, Byte), Integer), CType(CType(244, Byte), Integer), CType(CType(236, Byte), Integer))
    Me.GVREAPPRO.Appearance.OddRow.FontSizeDelta = CType(resources.GetObject("GVREAPPRO.Appearance.OddRow.FontSizeDelta"), Integer)
    Me.GVREAPPRO.Appearance.OddRow.FontStyleDelta = CType(resources.GetObject("GVREAPPRO.Appearance.OddRow.FontStyleDelta"), System.Drawing.FontStyle)
    Me.GVREAPPRO.Appearance.OddRow.ForeColor = System.Drawing.Color.Black
    Me.GVREAPPRO.Appearance.OddRow.GradientMode = CType(resources.GetObject("GVREAPPRO.Appearance.OddRow.GradientMode"), System.Drawing.Drawing2D.LinearGradientMode)
    Me.GVREAPPRO.Appearance.OddRow.Image = CType(resources.GetObject("GVREAPPRO.Appearance.OddRow.Image"), System.Drawing.Image)
    Me.GVREAPPRO.Appearance.OddRow.Options.UseBackColor = True
    Me.GVREAPPRO.Appearance.OddRow.Options.UseBorderColor = True
    Me.GVREAPPRO.Appearance.OddRow.Options.UseForeColor = True
    Me.GVREAPPRO.Appearance.Preview.BackColor = System.Drawing.Color.FromArgb(CType(CType(251, Byte), Integer), CType(CType(252, Byte), Integer), CType(CType(247, Byte), Integer))
    Me.GVREAPPRO.Appearance.Preview.Font = CType(resources.GetObject("GVREAPPRO.Appearance.Preview.Font"), System.Drawing.Font)
    Me.GVREAPPRO.Appearance.Preview.FontSizeDelta = CType(resources.GetObject("GVREAPPRO.Appearance.Preview.FontSizeDelta"), Integer)
    Me.GVREAPPRO.Appearance.Preview.FontStyleDelta = CType(resources.GetObject("GVREAPPRO.Appearance.Preview.FontStyleDelta"), System.Drawing.FontStyle)
    Me.GVREAPPRO.Appearance.Preview.ForeColor = System.Drawing.Color.FromArgb(CType(CType(148, Byte), Integer), CType(CType(148, Byte), Integer), CType(CType(148, Byte), Integer))
    Me.GVREAPPRO.Appearance.Preview.GradientMode = CType(resources.GetObject("GVREAPPRO.Appearance.Preview.GradientMode"), System.Drawing.Drawing2D.LinearGradientMode)
    Me.GVREAPPRO.Appearance.Preview.Image = CType(resources.GetObject("GVREAPPRO.Appearance.Preview.Image"), System.Drawing.Image)
    Me.GVREAPPRO.Appearance.Preview.Options.UseBackColor = True
    Me.GVREAPPRO.Appearance.Preview.Options.UseFont = True
    Me.GVREAPPRO.Appearance.Preview.Options.UseForeColor = True
    Me.GVREAPPRO.Appearance.Row.BackColor = System.Drawing.Color.FromArgb(CType(CType(242, Byte), Integer), CType(CType(244, Byte), Integer), CType(CType(236, Byte), Integer))
    Me.GVREAPPRO.Appearance.Row.FontSizeDelta = CType(resources.GetObject("GVREAPPRO.Appearance.Row.FontSizeDelta"), Integer)
    Me.GVREAPPRO.Appearance.Row.FontStyleDelta = CType(resources.GetObject("GVREAPPRO.Appearance.Row.FontStyleDelta"), System.Drawing.FontStyle)
    Me.GVREAPPRO.Appearance.Row.ForeColor = System.Drawing.Color.Black
    Me.GVREAPPRO.Appearance.Row.GradientMode = CType(resources.GetObject("GVREAPPRO.Appearance.Row.GradientMode"), System.Drawing.Drawing2D.LinearGradientMode)
    Me.GVREAPPRO.Appearance.Row.Image = CType(resources.GetObject("GVREAPPRO.Appearance.Row.Image"), System.Drawing.Image)
    Me.GVREAPPRO.Appearance.Row.Options.UseBackColor = True
    Me.GVREAPPRO.Appearance.Row.Options.UseForeColor = True
    Me.GVREAPPRO.Appearance.RowSeparator.BackColor = System.Drawing.Color.FromArgb(CType(CType(236, Byte), Integer), CType(CType(232, Byte), Integer), CType(CType(201, Byte), Integer))
    Me.GVREAPPRO.Appearance.RowSeparator.BackColor2 = CType(resources.GetObject("GVREAPPRO.Appearance.RowSeparator.BackColor2"), System.Drawing.Color)
    Me.GVREAPPRO.Appearance.RowSeparator.FontSizeDelta = CType(resources.GetObject("GVREAPPRO.Appearance.RowSeparator.FontSizeDelta"), Integer)
    Me.GVREAPPRO.Appearance.RowSeparator.FontStyleDelta = CType(resources.GetObject("GVREAPPRO.Appearance.RowSeparator.FontStyleDelta"), System.Drawing.FontStyle)
    Me.GVREAPPRO.Appearance.RowSeparator.GradientMode = CType(resources.GetObject("GVREAPPRO.Appearance.RowSeparator.GradientMode"), System.Drawing.Drawing2D.LinearGradientMode)
    Me.GVREAPPRO.Appearance.RowSeparator.Image = CType(resources.GetObject("GVREAPPRO.Appearance.RowSeparator.Image"), System.Drawing.Image)
    Me.GVREAPPRO.Appearance.RowSeparator.Options.UseBackColor = True
    Me.GVREAPPRO.Appearance.SelectedRow.BackColor = System.Drawing.Color.FromArgb(CType(CType(221, Byte), Integer), CType(CType(215, Byte), Integer), CType(CType(188, Byte), Integer))
    Me.GVREAPPRO.Appearance.SelectedRow.BorderColor = System.Drawing.Color.FromArgb(CType(CType(237, Byte), Integer), CType(CType(230, Byte), Integer), CType(CType(203, Byte), Integer))
    Me.GVREAPPRO.Appearance.SelectedRow.FontSizeDelta = CType(resources.GetObject("GVREAPPRO.Appearance.SelectedRow.FontSizeDelta"), Integer)
    Me.GVREAPPRO.Appearance.SelectedRow.FontStyleDelta = CType(resources.GetObject("GVREAPPRO.Appearance.SelectedRow.FontStyleDelta"), System.Drawing.FontStyle)
    Me.GVREAPPRO.Appearance.SelectedRow.ForeColor = System.Drawing.Color.Black
    Me.GVREAPPRO.Appearance.SelectedRow.GradientMode = CType(resources.GetObject("GVREAPPRO.Appearance.SelectedRow.GradientMode"), System.Drawing.Drawing2D.LinearGradientMode)
    Me.GVREAPPRO.Appearance.SelectedRow.Image = CType(resources.GetObject("GVREAPPRO.Appearance.SelectedRow.Image"), System.Drawing.Image)
    Me.GVREAPPRO.Appearance.SelectedRow.Options.UseBackColor = True
    Me.GVREAPPRO.Appearance.SelectedRow.Options.UseBorderColor = True
    Me.GVREAPPRO.Appearance.SelectedRow.Options.UseForeColor = True
    Me.GVREAPPRO.Appearance.TopNewRow.BackColor = System.Drawing.Color.White
    Me.GVREAPPRO.Appearance.TopNewRow.FontSizeDelta = CType(resources.GetObject("GVREAPPRO.Appearance.TopNewRow.FontSizeDelta"), Integer)
    Me.GVREAPPRO.Appearance.TopNewRow.FontStyleDelta = CType(resources.GetObject("GVREAPPRO.Appearance.TopNewRow.FontStyleDelta"), System.Drawing.FontStyle)
    Me.GVREAPPRO.Appearance.TopNewRow.GradientMode = CType(resources.GetObject("GVREAPPRO.Appearance.TopNewRow.GradientMode"), System.Drawing.Drawing2D.LinearGradientMode)
    Me.GVREAPPRO.Appearance.TopNewRow.Image = CType(resources.GetObject("GVREAPPRO.Appearance.TopNewRow.Image"), System.Drawing.Image)
    Me.GVREAPPRO.Appearance.TopNewRow.Options.UseBackColor = True
    Me.GVREAPPRO.Appearance.VertLine.BackColor = System.Drawing.Color.FromArgb(CType(CType(216, Byte), Integer), CType(CType(209, Byte), Integer), CType(CType(170, Byte), Integer))
    Me.GVREAPPRO.Appearance.VertLine.FontSizeDelta = CType(resources.GetObject("GVREAPPRO.Appearance.VertLine.FontSizeDelta"), Integer)
    Me.GVREAPPRO.Appearance.VertLine.FontStyleDelta = CType(resources.GetObject("GVREAPPRO.Appearance.VertLine.FontStyleDelta"), System.Drawing.FontStyle)
    Me.GVREAPPRO.Appearance.VertLine.GradientMode = CType(resources.GetObject("GVREAPPRO.Appearance.VertLine.GradientMode"), System.Drawing.Drawing2D.LinearGradientMode)
    Me.GVREAPPRO.Appearance.VertLine.Image = CType(resources.GetObject("GVREAPPRO.Appearance.VertLine.Image"), System.Drawing.Image)
    Me.GVREAPPRO.Appearance.VertLine.Options.UseBackColor = True
    resources.ApplyResources(Me.GVREAPPRO, "GVREAPPRO")
    Me.GVREAPPRO.ColumnPanelRowHeight = 50
    Me.GVREAPPRO.Columns.AddRange(New DevExpress.XtraGrid.Columns.GridColumn() {Me.GColNCMDWEBNUM, Me.GColDCMDDATE, Me.GColVTECHNOM, Me.GColVMESSAGE, Me.GColCLIEU_LIVR, Me.GColVLIEU_LIVR, Me.GColDDATELIVR, Me.GColBMESSAGEVU, Me.GColVMESSAGEVU, Me.GColNQUIVALID, Me.GColDQUIVALID, Me.GColNPERNUM_DEMAND, Me.GColVSOCIETE})
    Me.GVREAPPRO.GridControl = Me.GCREAPPRO
    Me.GVREAPPRO.Name = "GVREAPPRO"
    Me.GVREAPPRO.OptionsBehavior.Editable = False
    Me.GVREAPPRO.OptionsNavigation.AutoFocusNewRow = True
    Me.GVREAPPRO.OptionsView.EnableAppearanceOddRow = True
    Me.GVREAPPRO.OptionsView.ShowAutoFilterRow = True
    Me.GVREAPPRO.OptionsView.ShowFooter = True
    Me.GVREAPPRO.OptionsView.ShowGroupPanel = False
    Me.GVREAPPRO.RowHeight = 20
    '
    'GColNCMDWEBNUM
    '
    resources.ApplyResources(Me.GColNCMDWEBNUM, "GColNCMDWEBNUM")
    Me.GColNCMDWEBNUM.FieldName = "NCMDWEBNUM"
    Me.GColNCMDWEBNUM.ImageOptions.ImageIndex = CType(resources.GetObject("GColNCMDWEBNUM.ImageOptions.ImageIndex"), Integer)
    Me.GColNCMDWEBNUM.Name = "GColNCMDWEBNUM"
    Me.GColNCMDWEBNUM.OptionsColumn.AllowEdit = False
    Me.GColNCMDWEBNUM.OptionsColumn.ReadOnly = True
    Me.GColNCMDWEBNUM.OptionsFilter.AutoFilterCondition = DevExpress.XtraGrid.Columns.AutoFilterCondition.Contains
    '
    'GColDCMDDATE
    '
    resources.ApplyResources(Me.GColDCMDDATE, "GColDCMDDATE")
    Me.GColDCMDDATE.FieldName = "DCMDDATE"
    Me.GColDCMDDATE.ImageOptions.ImageIndex = CType(resources.GetObject("GColDCMDDATE.ImageOptions.ImageIndex"), Integer)
    Me.GColDCMDDATE.Name = "GColDCMDDATE"
    Me.GColDCMDDATE.OptionsColumn.AllowEdit = False
    Me.GColDCMDDATE.OptionsColumn.ReadOnly = True
    Me.GColDCMDDATE.OptionsFilter.AutoFilterCondition = DevExpress.XtraGrid.Columns.AutoFilterCondition.Contains
    '
    'GColVTECHNOM
    '
    resources.ApplyResources(Me.GColVTECHNOM, "GColVTECHNOM")
    Me.GColVTECHNOM.FieldName = "VTECHNOM"
    Me.GColVTECHNOM.ImageOptions.ImageIndex = CType(resources.GetObject("GColVTECHNOM.ImageOptions.ImageIndex"), Integer)
    Me.GColVTECHNOM.Name = "GColVTECHNOM"
    Me.GColVTECHNOM.OptionsColumn.AllowEdit = False
    Me.GColVTECHNOM.OptionsColumn.ReadOnly = True
    Me.GColVTECHNOM.OptionsFilter.AutoFilterCondition = DevExpress.XtraGrid.Columns.AutoFilterCondition.Contains
    '
    'GColVMESSAGE
    '
    resources.ApplyResources(Me.GColVMESSAGE, "GColVMESSAGE")
    Me.GColVMESSAGE.FieldName = "VMESSAGE"
    Me.GColVMESSAGE.ImageOptions.ImageIndex = CType(resources.GetObject("GColVMESSAGE.ImageOptions.ImageIndex"), Integer)
    Me.GColVMESSAGE.Name = "GColVMESSAGE"
    Me.GColVMESSAGE.OptionsColumn.AllowEdit = False
    Me.GColVMESSAGE.OptionsColumn.ReadOnly = True
    Me.GColVMESSAGE.OptionsFilter.AutoFilterCondition = DevExpress.XtraGrid.Columns.AutoFilterCondition.Contains
    '
    'GColCLIEU_LIVR
    '
    resources.ApplyResources(Me.GColCLIEU_LIVR, "GColCLIEU_LIVR")
    Me.GColCLIEU_LIVR.FieldName = "CLIEU_LIVR"
    Me.GColCLIEU_LIVR.ImageOptions.ImageIndex = CType(resources.GetObject("GColCLIEU_LIVR.ImageOptions.ImageIndex"), Integer)
    Me.GColCLIEU_LIVR.Name = "GColCLIEU_LIVR"
    '
    'GColVLIEU_LIVR
    '
    resources.ApplyResources(Me.GColVLIEU_LIVR, "GColVLIEU_LIVR")
    Me.GColVLIEU_LIVR.FieldName = "VLIEU_LIVR"
    Me.GColVLIEU_LIVR.ImageOptions.ImageIndex = CType(resources.GetObject("GColVLIEU_LIVR.ImageOptions.ImageIndex"), Integer)
    Me.GColVLIEU_LIVR.Name = "GColVLIEU_LIVR"
    Me.GColVLIEU_LIVR.OptionsColumn.AllowEdit = False
    Me.GColVLIEU_LIVR.OptionsColumn.ReadOnly = True
    Me.GColVLIEU_LIVR.OptionsFilter.AutoFilterCondition = DevExpress.XtraGrid.Columns.AutoFilterCondition.Contains
    '
    'GColDDATELIVR
    '
    resources.ApplyResources(Me.GColDDATELIVR, "GColDDATELIVR")
    Me.GColDDATELIVR.FieldName = "DDATELIVR"
    Me.GColDDATELIVR.ImageOptions.ImageIndex = CType(resources.GetObject("GColDDATELIVR.ImageOptions.ImageIndex"), Integer)
    Me.GColDDATELIVR.Name = "GColDDATELIVR"
    Me.GColDDATELIVR.OptionsColumn.AllowEdit = False
    Me.GColDDATELIVR.OptionsFilter.AutoFilterCondition = DevExpress.XtraGrid.Columns.AutoFilterCondition.Contains
    '
    'GColBMESSAGEVU
    '
    resources.ApplyResources(Me.GColBMESSAGEVU, "GColBMESSAGEVU")
    Me.GColBMESSAGEVU.FieldName = "BMESSAGEVU"
    Me.GColBMESSAGEVU.ImageOptions.ImageIndex = CType(resources.GetObject("GColBMESSAGEVU.ImageOptions.ImageIndex"), Integer)
    Me.GColBMESSAGEVU.Name = "GColBMESSAGEVU"
    '
    'GColVMESSAGEVU
    '
    resources.ApplyResources(Me.GColVMESSAGEVU, "GColVMESSAGEVU")
    Me.GColVMESSAGEVU.FieldName = "VMESSAGEVU"
    Me.GColVMESSAGEVU.ImageOptions.ImageIndex = CType(resources.GetObject("GColVMESSAGEVU.ImageOptions.ImageIndex"), Integer)
    Me.GColVMESSAGEVU.Name = "GColVMESSAGEVU"
    Me.GColVMESSAGEVU.OptionsColumn.AllowEdit = False
    Me.GColVMESSAGEVU.OptionsColumn.ReadOnly = True
    Me.GColVMESSAGEVU.OptionsFilter.AutoFilterCondition = DevExpress.XtraGrid.Columns.AutoFilterCondition.Contains
    '
    'GColNQUIVALID
    '
    resources.ApplyResources(Me.GColNQUIVALID, "GColNQUIVALID")
    Me.GColNQUIVALID.FieldName = "NQUIVALID"
    Me.GColNQUIVALID.ImageOptions.ImageIndex = CType(resources.GetObject("GColNQUIVALID.ImageOptions.ImageIndex"), Integer)
    Me.GColNQUIVALID.Name = "GColNQUIVALID"
    '
    'GColDQUIVALID
    '
    resources.ApplyResources(Me.GColDQUIVALID, "GColDQUIVALID")
    Me.GColDQUIVALID.FieldName = "DQUIVALID"
    Me.GColDQUIVALID.ImageOptions.ImageIndex = CType(resources.GetObject("GColDQUIVALID.ImageOptions.ImageIndex"), Integer)
    Me.GColDQUIVALID.Name = "GColDQUIVALID"
    '
    'GColNPERNUM_DEMAND
    '
    resources.ApplyResources(Me.GColNPERNUM_DEMAND, "GColNPERNUM_DEMAND")
    Me.GColNPERNUM_DEMAND.FieldName = "NPERNUM_DEMAND"
    Me.GColNPERNUM_DEMAND.ImageOptions.ImageIndex = CType(resources.GetObject("GColNPERNUM_DEMAND.ImageOptions.ImageIndex"), Integer)
    Me.GColNPERNUM_DEMAND.Name = "GColNPERNUM_DEMAND"
    '
    'GColVSOCIETE
    '
    resources.ApplyResources(Me.GColVSOCIETE, "GColVSOCIETE")
    Me.GColVSOCIETE.FieldName = "VSOCIETE"
    Me.GColVSOCIETE.ImageOptions.ImageIndex = CType(resources.GetObject("GColVSOCIETE.ImageOptions.ImageIndex"), Integer)
    Me.GColVSOCIETE.Name = "GColVSOCIETE"
    '
    'RepItemGLUpEditGTPLot
    '
    resources.ApplyResources(Me.RepItemGLUpEditGTPLot, "RepItemGLUpEditGTPLot")
    Me.RepItemGLUpEditGTPLot.Buttons.AddRange(New DevExpress.XtraEditors.Controls.EditorButton() {New DevExpress.XtraEditors.Controls.EditorButton(CType(resources.GetObject("RepItemGLUpEditGTPLot.Buttons"), DevExpress.XtraEditors.Controls.ButtonPredefines))})
    Me.RepItemGLUpEditGTPLot.DisplayMember = "VGTPLOTNOM"
    Me.RepItemGLUpEditGTPLot.Name = "RepItemGLUpEditGTPLot"
    Me.RepItemGLUpEditGTPLot.PopupView = Me.RepIGLUpEditViewLot
    Me.RepItemGLUpEditGTPLot.ValueMember = "NGTPLOTID"
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
    Me.ColLOTIDTMP.ImageOptions.ImageIndex = CType(resources.GetObject("ColLOTIDTMP.ImageOptions.ImageIndex"), Integer)
    Me.ColLOTIDTMP.Name = "ColLOTIDTMP"
    '
    'ColLOTNGTPLOTID
    '
    resources.ApplyResources(Me.ColLOTNGTPLOTID, "ColLOTNGTPLOTID")
    Me.ColLOTNGTPLOTID.FieldName = "NGTPLOTID"
    Me.ColLOTNGTPLOTID.ImageOptions.ImageIndex = CType(resources.GetObject("ColLOTNGTPLOTID.ImageOptions.ImageIndex"), Integer)
    Me.ColLOTNGTPLOTID.Name = "ColLOTNGTPLOTID"
    '
    'ColLOTVGTPLOTNOM
    '
    resources.ApplyResources(Me.ColLOTVGTPLOTNOM, "ColLOTVGTPLOTNOM")
    Me.ColLOTVGTPLOTNOM.FieldName = "VGTPLOTNOM"
    Me.ColLOTVGTPLOTNOM.ImageOptions.ImageIndex = CType(resources.GetObject("ColLOTVGTPLOTNOM.ImageOptions.ImageIndex"), Integer)
    Me.ColLOTVGTPLOTNOM.Name = "ColLOTVGTPLOTNOM"
    '
    'RepItemGLUpEditUnite
    '
    resources.ApplyResources(Me.RepItemGLUpEditUnite, "RepItemGLUpEditUnite")
    Me.RepItemGLUpEditUnite.Buttons.AddRange(New DevExpress.XtraEditors.Controls.EditorButton() {New DevExpress.XtraEditors.Controls.EditorButton(CType(resources.GetObject("RepItemGLUpEditUnite.Buttons"), DevExpress.XtraEditors.Controls.ButtonPredefines))})
    Me.RepItemGLUpEditUnite.DisplayMember = "VGTPUNITENOM"
    Me.RepItemGLUpEditUnite.Name = "RepItemGLUpEditUnite"
    Me.RepItemGLUpEditUnite.PopupView = Me.RepItemGLUpEditViewUnite
    Me.RepItemGLUpEditUnite.ValueMember = "NGTPUNITEID"
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
    Me.ColUNITEIDTMP.ImageOptions.ImageIndex = CType(resources.GetObject("ColUNITEIDTMP.ImageOptions.ImageIndex"), Integer)
    Me.ColUNITEIDTMP.Name = "ColUNITEIDTMP"
    '
    'ColUNITENGTPUNITEID
    '
    resources.ApplyResources(Me.ColUNITENGTPUNITEID, "ColUNITENGTPUNITEID")
    Me.ColUNITENGTPUNITEID.FieldName = "NGTPUNITEID"
    Me.ColUNITENGTPUNITEID.ImageOptions.ImageIndex = CType(resources.GetObject("ColUNITENGTPUNITEID.ImageOptions.ImageIndex"), Integer)
    Me.ColUNITENGTPUNITEID.Name = "ColUNITENGTPUNITEID"
    '
    'ColUNITEVGTPUNITENOM
    '
    resources.ApplyResources(Me.ColUNITEVGTPUNITENOM, "ColUNITEVGTPUNITENOM")
    Me.ColUNITEVGTPUNITENOM.FieldName = "VGTPUNITENOM"
    Me.ColUNITEVGTPUNITENOM.ImageOptions.ImageIndex = CType(resources.GetObject("ColUNITEVGTPUNITENOM.ImageOptions.ImageIndex"), Integer)
    Me.ColUNITEVGTPUNITENOM.Name = "ColUNITEVGTPUNITENOM"
    '
    'RepositoryItemCheckEdit1
    '
    resources.ApplyResources(Me.RepositoryItemCheckEdit1, "RepositoryItemCheckEdit1")
    Me.RepositoryItemCheckEdit1.Name = "RepositoryItemCheckEdit1"
    Me.RepositoryItemCheckEdit1.NullStyle = DevExpress.XtraEditors.Controls.StyleIndeterminate.Unchecked
    Me.RepositoryItemCheckEdit1.ReadOnly = True
    Me.RepositoryItemCheckEdit1.ValueChecked = "O"
    Me.RepositoryItemCheckEdit1.ValueUnchecked = "N"
    '
    'frmListeCommandeReapproAValider
    '
    resources.ApplyResources(Me, "$this")
    Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
    Me.BackColor = System.Drawing.Color.Wheat
    Me.Controls.Add(Me.GrpActions)
    Me.Controls.Add(Me.Label1)
    Me.Controls.Add(Me.GCREAPPRO)
    Me.Name = "frmListeCommandeReapproAValider"
    Me.WindowState = System.Windows.Forms.FormWindowState.Maximized
    Me.GrpActions.ResumeLayout(False)
    CType(Me.GCREAPPRO, System.ComponentModel.ISupportInitialize).EndInit()
    CType(Me.GVREAPPRO, System.ComponentModel.ISupportInitialize).EndInit()
    CType(Me.RepItemGLUpEditGTPLot, System.ComponentModel.ISupportInitialize).EndInit()
    CType(Me.RepIGLUpEditViewLot, System.ComponentModel.ISupportInitialize).EndInit()
    CType(Me.RepItemGLUpEditUnite, System.ComponentModel.ISupportInitialize).EndInit()
    CType(Me.RepItemGLUpEditViewUnite, System.ComponentModel.ISupportInitialize).EndInit()
    CType(Me.RepositoryItemCheckEdit1, System.ComponentModel.ISupportInitialize).EndInit()
    Me.ResumeLayout(False)

  End Sub

  Friend WithEvents GrpActions As GroupBox
    Friend WithEvents BtnArchives As Button
    Friend WithEvents BtnMod As Button
    Friend WithEvents BtnSupprLine As Button
    Friend WithEvents BtnQuit As Button
    Friend WithEvents Label1 As Label
    Private WithEvents GCREAPPRO As DevExpress.XtraGrid.GridControl
    Private WithEvents GVREAPPRO As DevExpress.XtraGrid.Views.Grid.GridView
    Private WithEvents GColNCMDWEBNUM As DevExpress.XtraGrid.Columns.GridColumn
    Private WithEvents GColDCMDDATE As DevExpress.XtraGrid.Columns.GridColumn
    Private WithEvents GColVTECHNOM As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents RepositoryItemCheckEdit1 As DevExpress.XtraEditors.Repository.RepositoryItemCheckEdit
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
    Friend WithEvents GColVMESSAGE As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents GColCLIEU_LIVR As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents GColVLIEU_LIVR As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents GColDDATELIVR As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents GColBMESSAGEVU As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents GColVMESSAGEVU As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents GColNQUIVALID As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents GColDQUIVALID As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents GColNPERNUM_DEMAND As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents GColVSOCIETE As DevExpress.XtraGrid.Columns.GridColumn
End Class
