<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class frmTypeFormation
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(frmTypeFormation))
        Me.Label1 = New System.Windows.Forms.Label()
        Me.GCORGANISME = New DevExpress.XtraGrid.GridControl()
        Me.GridView1 = New DevExpress.XtraGrid.Views.Grid.GridView()
        Me.GVORGANISME = New DevExpress.XtraGrid.Views.Grid.GridView()
        Me.BtnSupprLine = New System.Windows.Forms.Button()
        Me.BtnQuit = New System.Windows.Forms.Button()
        Me.GrpActions = New System.Windows.Forms.GroupBox()
        Me.BtnModLine = New System.Windows.Forms.Button()
        Me.BtnAddLine = New System.Windows.Forms.Button()
        Me.GCTYPEFORMATION = New DevExpress.XtraGrid.GridControl()
        Me.GVTYPEFORMATION = New DevExpress.XtraGrid.Views.Grid.GridView()
        Me.ColIDTMP = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.ColNFORNUM = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.ColVFORLIB = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.ColVFORTYPE = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.ColFORMATEUR = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.ColVFOROBS = New DevExpress.XtraGrid.Columns.GridColumn()
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
        CType(Me.GCORGANISME, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.GridView1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.GVORGANISME, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.GrpActions.SuspendLayout()
        CType(Me.GCTYPEFORMATION, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.GVTYPEFORMATION, System.ComponentModel.ISupportInitialize).BeginInit()
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
        'GCORGANISME
        '
        resources.ApplyResources(Me.GCORGANISME, "GCORGANISME")
        Me.GCORGANISME.MainView = Me.GridView1
        Me.GCORGANISME.Name = "GCORGANISME"
        Me.GCORGANISME.ViewCollection.AddRange(New DevExpress.XtraGrid.Views.Base.BaseView() {Me.GridView1, Me.GVORGANISME})
        '
        'GridView1
        '
        Me.GridView1.GridControl = Me.GCORGANISME
        Me.GridView1.Name = "GridView1"
        '
        'GVORGANISME
        '
        Me.GVORGANISME.Appearance.ColumnFilterButton.BackColor = System.Drawing.Color.FromArgb(CType(CType(243, Byte), Integer), CType(CType(244, Byte), Integer), CType(CType(250, Byte), Integer))
        Me.GVORGANISME.Appearance.ColumnFilterButton.BackColor2 = CType(resources.GetObject("GVORGANISME.Appearance.ColumnFilterButton.BackColor2"), System.Drawing.Color)
        Me.GVORGANISME.Appearance.ColumnFilterButton.BorderColor = System.Drawing.Color.FromArgb(CType(CType(243, Byte), Integer), CType(CType(244, Byte), Integer), CType(CType(250, Byte), Integer))
        Me.GVORGANISME.Appearance.ColumnFilterButton.ForeColor = System.Drawing.Color.Black
        Me.GVORGANISME.Appearance.ColumnFilterButton.GradientMode = CType(resources.GetObject("GVORGANISME.Appearance.ColumnFilterButton.GradientMode"), System.Drawing.Drawing2D.LinearGradientMode)
        Me.GVORGANISME.Appearance.ColumnFilterButton.Options.UseBackColor = True
        Me.GVORGANISME.Appearance.ColumnFilterButton.Options.UseBorderColor = True
        Me.GVORGANISME.Appearance.ColumnFilterButton.Options.UseForeColor = True
        Me.GVORGANISME.Appearance.ColumnFilterButtonActive.BackColor = System.Drawing.Color.White
        Me.GVORGANISME.Appearance.ColumnFilterButtonActive.BackColor2 = CType(resources.GetObject("GVORGANISME.Appearance.ColumnFilterButtonActive.BackColor2"), System.Drawing.Color)
        Me.GVORGANISME.Appearance.ColumnFilterButtonActive.BorderColor = System.Drawing.Color.White
        Me.GVORGANISME.Appearance.ColumnFilterButtonActive.ForeColor = System.Drawing.Color.Black
        Me.GVORGANISME.Appearance.ColumnFilterButtonActive.GradientMode = CType(resources.GetObject("GVORGANISME.Appearance.ColumnFilterButtonActive.GradientMode"), System.Drawing.Drawing2D.LinearGradientMode)
        Me.GVORGANISME.Appearance.ColumnFilterButtonActive.Options.UseBackColor = True
        Me.GVORGANISME.Appearance.ColumnFilterButtonActive.Options.UseBorderColor = True
        Me.GVORGANISME.Appearance.ColumnFilterButtonActive.Options.UseForeColor = True
        Me.GVORGANISME.Appearance.Empty.BackColor = System.Drawing.Color.White
        Me.GVORGANISME.Appearance.Empty.Options.UseBackColor = True
        Me.GVORGANISME.Appearance.EvenRow.BackColor = System.Drawing.Color.FromArgb(CType(CType(243, Byte), Integer), CType(CType(244, Byte), Integer), CType(CType(250, Byte), Integer))
        Me.GVORGANISME.Appearance.EvenRow.ForeColor = System.Drawing.Color.Black
        Me.GVORGANISME.Appearance.EvenRow.Options.UseBackColor = True
        Me.GVORGANISME.Appearance.EvenRow.Options.UseForeColor = True
        Me.GVORGANISME.Appearance.FilterCloseButton.BackColor = System.Drawing.Color.FromArgb(CType(CType(243, Byte), Integer), CType(CType(244, Byte), Integer), CType(CType(250, Byte), Integer))
        Me.GVORGANISME.Appearance.FilterCloseButton.BackColor2 = CType(resources.GetObject("GVORGANISME.Appearance.FilterCloseButton.BackColor2"), System.Drawing.Color)
        Me.GVORGANISME.Appearance.FilterCloseButton.BorderColor = System.Drawing.Color.FromArgb(CType(CType(243, Byte), Integer), CType(CType(244, Byte), Integer), CType(CType(250, Byte), Integer))
        Me.GVORGANISME.Appearance.FilterCloseButton.GradientMode = CType(resources.GetObject("GVORGANISME.Appearance.FilterCloseButton.GradientMode"), System.Drawing.Drawing2D.LinearGradientMode)
        Me.GVORGANISME.Appearance.FilterCloseButton.Options.UseBackColor = True
        Me.GVORGANISME.Appearance.FilterCloseButton.Options.UseBorderColor = True
        Me.GVORGANISME.Appearance.FilterPanel.BackColor = System.Drawing.Color.FromArgb(CType(CType(133, Byte), Integer), CType(CType(131, Byte), Integer), CType(CType(161, Byte), Integer))
        Me.GVORGANISME.Appearance.FilterPanel.ForeColor = System.Drawing.Color.White
        Me.GVORGANISME.Appearance.FilterPanel.Options.UseBackColor = True
        Me.GVORGANISME.Appearance.FilterPanel.Options.UseForeColor = True
        Me.GVORGANISME.Appearance.FixedLine.BackColor = System.Drawing.Color.FromArgb(CType(CType(124, Byte), Integer), CType(CType(124, Byte), Integer), CType(CType(148, Byte), Integer))
        Me.GVORGANISME.Appearance.FixedLine.Options.UseBackColor = True
        Me.GVORGANISME.Appearance.FocusedRow.BackColor = System.Drawing.Color.FromArgb(CType(CType(178, Byte), Integer), CType(CType(180, Byte), Integer), CType(CType(191, Byte), Integer))
        Me.GVORGANISME.Appearance.FocusedRow.ForeColor = System.Drawing.Color.Black
        Me.GVORGANISME.Appearance.FocusedRow.Options.UseBackColor = True
        Me.GVORGANISME.Appearance.FocusedRow.Options.UseForeColor = True
        Me.GVORGANISME.Appearance.FooterPanel.BackColor = System.Drawing.Color.FromArgb(CType(CType(243, Byte), Integer), CType(CType(244, Byte), Integer), CType(CType(250, Byte), Integer))
        Me.GVORGANISME.Appearance.FooterPanel.BackColor2 = CType(resources.GetObject("GVORGANISME.Appearance.FooterPanel.BackColor2"), System.Drawing.Color)
        Me.GVORGANISME.Appearance.FooterPanel.BorderColor = System.Drawing.Color.FromArgb(CType(CType(243, Byte), Integer), CType(CType(244, Byte), Integer), CType(CType(250, Byte), Integer))
        Me.GVORGANISME.Appearance.FooterPanel.GradientMode = CType(resources.GetObject("GVORGANISME.Appearance.FooterPanel.GradientMode"), System.Drawing.Drawing2D.LinearGradientMode)
        Me.GVORGANISME.Appearance.FooterPanel.Options.UseBackColor = True
        Me.GVORGANISME.Appearance.FooterPanel.Options.UseBorderColor = True
        Me.GVORGANISME.Appearance.GroupButton.BackColor = System.Drawing.Color.FromArgb(CType(CType(215, Byte), Integer), CType(CType(215, Byte), Integer), CType(CType(229, Byte), Integer))
        Me.GVORGANISME.Appearance.GroupButton.BorderColor = System.Drawing.Color.FromArgb(CType(CType(215, Byte), Integer), CType(CType(215, Byte), Integer), CType(CType(229, Byte), Integer))
        Me.GVORGANISME.Appearance.GroupButton.ForeColor = System.Drawing.Color.Black
        Me.GVORGANISME.Appearance.GroupButton.Options.UseBackColor = True
        Me.GVORGANISME.Appearance.GroupButton.Options.UseBorderColor = True
        Me.GVORGANISME.Appearance.GroupButton.Options.UseForeColor = True
        Me.GVORGANISME.Appearance.GroupFooter.BackColor = System.Drawing.Color.FromArgb(CType(CType(215, Byte), Integer), CType(CType(215, Byte), Integer), CType(CType(229, Byte), Integer))
        Me.GVORGANISME.Appearance.GroupFooter.BorderColor = System.Drawing.Color.FromArgb(CType(CType(215, Byte), Integer), CType(CType(215, Byte), Integer), CType(CType(229, Byte), Integer))
        Me.GVORGANISME.Appearance.GroupFooter.ForeColor = System.Drawing.Color.Black
        Me.GVORGANISME.Appearance.GroupFooter.Options.UseBackColor = True
        Me.GVORGANISME.Appearance.GroupFooter.Options.UseBorderColor = True
        Me.GVORGANISME.Appearance.GroupFooter.Options.UseForeColor = True
        Me.GVORGANISME.Appearance.GroupPanel.BackColor = System.Drawing.Color.FromArgb(CType(CType(133, Byte), Integer), CType(CType(131, Byte), Integer), CType(CType(161, Byte), Integer))
        Me.GVORGANISME.Appearance.GroupPanel.ForeColor = System.Drawing.Color.FromArgb(CType(CType(243, Byte), Integer), CType(CType(244, Byte), Integer), CType(CType(250, Byte), Integer))
        Me.GVORGANISME.Appearance.GroupPanel.Options.UseBackColor = True
        Me.GVORGANISME.Appearance.GroupPanel.Options.UseForeColor = True
        Me.GVORGANISME.Appearance.GroupRow.BackColor = System.Drawing.Color.FromArgb(CType(CType(215, Byte), Integer), CType(CType(215, Byte), Integer), CType(CType(229, Byte), Integer))
        Me.GVORGANISME.Appearance.GroupRow.BorderColor = System.Drawing.Color.FromArgb(CType(CType(215, Byte), Integer), CType(CType(215, Byte), Integer), CType(CType(229, Byte), Integer))
        Me.GVORGANISME.Appearance.GroupRow.Font = CType(resources.GetObject("GVORGANISME.Appearance.GroupRow.Font"), System.Drawing.Font)
        Me.GVORGANISME.Appearance.GroupRow.ForeColor = System.Drawing.Color.Black
        Me.GVORGANISME.Appearance.GroupRow.Options.UseBackColor = True
        Me.GVORGANISME.Appearance.GroupRow.Options.UseBorderColor = True
        Me.GVORGANISME.Appearance.GroupRow.Options.UseFont = True
        Me.GVORGANISME.Appearance.GroupRow.Options.UseForeColor = True
        Me.GVORGANISME.Appearance.HeaderPanel.BackColor = System.Drawing.Color.FromArgb(CType(CType(243, Byte), Integer), CType(CType(244, Byte), Integer), CType(CType(250, Byte), Integer))
        Me.GVORGANISME.Appearance.HeaderPanel.BackColor2 = CType(resources.GetObject("GVORGANISME.Appearance.HeaderPanel.BackColor2"), System.Drawing.Color)
        Me.GVORGANISME.Appearance.HeaderPanel.BorderColor = System.Drawing.Color.FromArgb(CType(CType(243, Byte), Integer), CType(CType(244, Byte), Integer), CType(CType(250, Byte), Integer))
        Me.GVORGANISME.Appearance.HeaderPanel.Font = CType(resources.GetObject("GVORGANISME.Appearance.HeaderPanel.Font"), System.Drawing.Font)
        Me.GVORGANISME.Appearance.HeaderPanel.ForeColor = System.Drawing.Color.Black
        Me.GVORGANISME.Appearance.HeaderPanel.GradientMode = CType(resources.GetObject("GVORGANISME.Appearance.HeaderPanel.GradientMode"), System.Drawing.Drawing2D.LinearGradientMode)
        Me.GVORGANISME.Appearance.HeaderPanel.Options.UseBackColor = True
        Me.GVORGANISME.Appearance.HeaderPanel.Options.UseBorderColor = True
        Me.GVORGANISME.Appearance.HeaderPanel.Options.UseFont = True
        Me.GVORGANISME.Appearance.HeaderPanel.Options.UseForeColor = True
        Me.GVORGANISME.Appearance.HeaderPanel.Options.UseTextOptions = True
        Me.GVORGANISME.Appearance.HeaderPanel.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center
        Me.GVORGANISME.Appearance.HeaderPanel.TextOptions.VAlignment = DevExpress.Utils.VertAlignment.Center
        Me.GVORGANISME.Appearance.HideSelectionRow.BackColor = System.Drawing.Color.FromArgb(CType(CType(218, Byte), Integer), CType(CType(219, Byte), Integer), CType(CType(226, Byte), Integer))
        Me.GVORGANISME.Appearance.HideSelectionRow.ForeColor = System.Drawing.Color.FromArgb(CType(CType(133, Byte), Integer), CType(CType(131, Byte), Integer), CType(CType(161, Byte), Integer))
        Me.GVORGANISME.Appearance.HideSelectionRow.Options.UseBackColor = True
        Me.GVORGANISME.Appearance.HideSelectionRow.Options.UseForeColor = True
        Me.GVORGANISME.Appearance.HorzLine.BackColor = System.Drawing.Color.FromArgb(CType(CType(164, Byte), Integer), CType(CType(164, Byte), Integer), CType(CType(188, Byte), Integer))
        Me.GVORGANISME.Appearance.HorzLine.Options.UseBackColor = True
        Me.GVORGANISME.Appearance.OddRow.BackColor = System.Drawing.Color.White
        Me.GVORGANISME.Appearance.OddRow.ForeColor = System.Drawing.Color.Black
        Me.GVORGANISME.Appearance.OddRow.Options.UseBackColor = True
        Me.GVORGANISME.Appearance.OddRow.Options.UseForeColor = True
        Me.GVORGANISME.Appearance.Preview.BackColor = System.Drawing.Color.FromArgb(CType(CType(250, Byte), Integer), CType(CType(250, Byte), Integer), CType(CType(253, Byte), Integer))
        Me.GVORGANISME.Appearance.Preview.ForeColor = System.Drawing.Color.FromArgb(CType(CType(163, Byte), Integer), CType(CType(165, Byte), Integer), CType(CType(177, Byte), Integer))
        Me.GVORGANISME.Appearance.Preview.Options.UseBackColor = True
        Me.GVORGANISME.Appearance.Preview.Options.UseForeColor = True
        Me.GVORGANISME.Appearance.Row.BackColor = System.Drawing.Color.White
        Me.GVORGANISME.Appearance.Row.ForeColor = System.Drawing.Color.Black
        Me.GVORGANISME.Appearance.Row.Options.UseBackColor = True
        Me.GVORGANISME.Appearance.Row.Options.UseForeColor = True
        Me.GVORGANISME.Appearance.RowSeparator.BackColor = System.Drawing.Color.White
        Me.GVORGANISME.Appearance.RowSeparator.Options.UseBackColor = True
        Me.GVORGANISME.Appearance.SelectedRow.BackColor = System.Drawing.Color.FromArgb(CType(CType(195, Byte), Integer), CType(CType(197, Byte), Integer), CType(CType(205, Byte), Integer))
        Me.GVORGANISME.Appearance.SelectedRow.ForeColor = System.Drawing.Color.Black
        Me.GVORGANISME.Appearance.SelectedRow.Options.UseBackColor = True
        Me.GVORGANISME.Appearance.SelectedRow.Options.UseForeColor = True
        Me.GVORGANISME.Appearance.VertLine.BackColor = System.Drawing.Color.FromArgb(CType(CType(164, Byte), Integer), CType(CType(164, Byte), Integer), CType(CType(188, Byte), Integer))
        Me.GVORGANISME.Appearance.VertLine.Options.UseBackColor = True
        Me.GVORGANISME.GridControl = Me.GCORGANISME
        Me.GVORGANISME.Name = "GVORGANISME"
        Me.GVORGANISME.OptionsView.EnableAppearanceEvenRow = True
        Me.GVORGANISME.OptionsView.EnableAppearanceOddRow = True
        Me.GVORGANISME.OptionsView.ShowGroupPanel = False
        '
        'BtnSupprLine
        '
        Me.BtnSupprLine.BackColor = System.Drawing.Color.LightGreen
        resources.ApplyResources(Me.BtnSupprLine, "BtnSupprLine")
        Me.BtnSupprLine.Name = "BtnSupprLine"
        Me.BtnSupprLine.UseVisualStyleBackColor = False
        '
        'BtnQuit
        '
        resources.ApplyResources(Me.BtnQuit, "BtnQuit")
        Me.BtnQuit.Name = "BtnQuit"
        Me.BtnQuit.UseVisualStyleBackColor = True
        '
        'GrpActions
        '
        Me.GrpActions.Controls.Add(Me.BtnModLine)
        Me.GrpActions.Controls.Add(Me.BtnSupprLine)
        Me.GrpActions.Controls.Add(Me.BtnAddLine)
        Me.GrpActions.Controls.Add(Me.BtnQuit)
        resources.ApplyResources(Me.GrpActions, "GrpActions")
        Me.GrpActions.Name = "GrpActions"
        Me.GrpActions.TabStop = False
        '
        'BtnModLine
        '
        Me.BtnModLine.BackColor = System.Drawing.Color.LightGreen
        resources.ApplyResources(Me.BtnModLine, "BtnModLine")
        Me.BtnModLine.Name = "BtnModLine"
        Me.BtnModLine.UseVisualStyleBackColor = False
        '
        'BtnAddLine
        '
        Me.BtnAddLine.BackColor = System.Drawing.Color.LightGreen
        resources.ApplyResources(Me.BtnAddLine, "BtnAddLine")
        Me.BtnAddLine.Name = "BtnAddLine"
        Me.BtnAddLine.UseVisualStyleBackColor = False
        '
        'GCTYPEFORMATION
        '
        resources.ApplyResources(Me.GCTYPEFORMATION, "GCTYPEFORMATION")
        Me.GCTYPEFORMATION.MainView = Me.GVTYPEFORMATION
        Me.GCTYPEFORMATION.Name = "GCTYPEFORMATION"
        Me.GCTYPEFORMATION.RepositoryItems.AddRange(New DevExpress.XtraEditors.Repository.RepositoryItem() {Me.RepItemGLUpEditGTPLot, Me.RepItemGLUpEditUnite})
        Me.GCTYPEFORMATION.ViewCollection.AddRange(New DevExpress.XtraGrid.Views.Base.BaseView() {Me.GVTYPEFORMATION})
        '
        'GVTYPEFORMATION
        '
        Me.GVTYPEFORMATION.Appearance.ColumnFilterButton.BackColor = System.Drawing.Color.FromArgb(CType(CType(236, Byte), Integer), CType(CType(232, Byte), Integer), CType(CType(201, Byte), Integer))
        Me.GVTYPEFORMATION.Appearance.ColumnFilterButton.BorderColor = System.Drawing.Color.FromArgb(CType(CType(236, Byte), Integer), CType(CType(232, Byte), Integer), CType(CType(201, Byte), Integer))
        Me.GVTYPEFORMATION.Appearance.ColumnFilterButton.ForeColor = System.Drawing.Color.Black
        Me.GVTYPEFORMATION.Appearance.ColumnFilterButton.Options.UseBackColor = True
        Me.GVTYPEFORMATION.Appearance.ColumnFilterButton.Options.UseBorderColor = True
        Me.GVTYPEFORMATION.Appearance.ColumnFilterButton.Options.UseForeColor = True
        Me.GVTYPEFORMATION.Appearance.ColumnFilterButtonActive.BackColor = System.Drawing.Color.FromArgb(CType(CType(221, Byte), Integer), CType(CType(231, Byte), Integer), CType(CType(234, Byte), Integer))
        Me.GVTYPEFORMATION.Appearance.ColumnFilterButtonActive.BorderColor = System.Drawing.Color.FromArgb(CType(CType(221, Byte), Integer), CType(CType(231, Byte), Integer), CType(CType(234, Byte), Integer))
        Me.GVTYPEFORMATION.Appearance.ColumnFilterButtonActive.ForeColor = System.Drawing.Color.Black
        Me.GVTYPEFORMATION.Appearance.ColumnFilterButtonActive.Options.UseBackColor = True
        Me.GVTYPEFORMATION.Appearance.ColumnFilterButtonActive.Options.UseBorderColor = True
        Me.GVTYPEFORMATION.Appearance.ColumnFilterButtonActive.Options.UseForeColor = True
        Me.GVTYPEFORMATION.Appearance.Empty.BackColor = System.Drawing.Color.FromArgb(CType(CType(236, Byte), Integer), CType(CType(232, Byte), Integer), CType(CType(201, Byte), Integer))
        Me.GVTYPEFORMATION.Appearance.Empty.BackColor2 = CType(resources.GetObject("GVTYPEFORMATION.Appearance.Empty.BackColor2"), System.Drawing.Color)
        Me.GVTYPEFORMATION.Appearance.Empty.Options.UseBackColor = True
        Me.GVTYPEFORMATION.Appearance.EvenRow.BackColor = System.Drawing.Color.FromArgb(CType(CType(221, Byte), Integer), CType(CType(231, Byte), Integer), CType(CType(234, Byte), Integer))
        Me.GVTYPEFORMATION.Appearance.EvenRow.BorderColor = System.Drawing.Color.FromArgb(CType(CType(221, Byte), Integer), CType(CType(231, Byte), Integer), CType(CType(234, Byte), Integer))
        Me.GVTYPEFORMATION.Appearance.EvenRow.ForeColor = System.Drawing.Color.Black
        Me.GVTYPEFORMATION.Appearance.EvenRow.Options.UseBackColor = True
        Me.GVTYPEFORMATION.Appearance.EvenRow.Options.UseBorderColor = True
        Me.GVTYPEFORMATION.Appearance.EvenRow.Options.UseForeColor = True
        Me.GVTYPEFORMATION.Appearance.FilterCloseButton.BackColor = System.Drawing.Color.FromArgb(CType(CType(216, Byte), Integer), CType(CType(209, Byte), Integer), CType(CType(179, Byte), Integer))
        Me.GVTYPEFORMATION.Appearance.FilterCloseButton.BorderColor = System.Drawing.Color.FromArgb(CType(CType(216, Byte), Integer), CType(CType(209, Byte), Integer), CType(CType(179, Byte), Integer))
        Me.GVTYPEFORMATION.Appearance.FilterCloseButton.ForeColor = System.Drawing.Color.Black
        Me.GVTYPEFORMATION.Appearance.FilterCloseButton.Options.UseBackColor = True
        Me.GVTYPEFORMATION.Appearance.FilterCloseButton.Options.UseBorderColor = True
        Me.GVTYPEFORMATION.Appearance.FilterCloseButton.Options.UseForeColor = True
        Me.GVTYPEFORMATION.Appearance.FilterPanel.BackColor = System.Drawing.Color.FromArgb(CType(CType(236, Byte), Integer), CType(CType(232, Byte), Integer), CType(CType(201, Byte), Integer))
        Me.GVTYPEFORMATION.Appearance.FilterPanel.BackColor2 = CType(resources.GetObject("GVTYPEFORMATION.Appearance.FilterPanel.BackColor2"), System.Drawing.Color)
        Me.GVTYPEFORMATION.Appearance.FilterPanel.ForeColor = System.Drawing.Color.Black
        Me.GVTYPEFORMATION.Appearance.FilterPanel.Options.UseBackColor = True
        Me.GVTYPEFORMATION.Appearance.FilterPanel.Options.UseForeColor = True
        Me.GVTYPEFORMATION.Appearance.FixedLine.BackColor = System.Drawing.Color.FromArgb(CType(CType(122, Byte), Integer), CType(CType(114, Byte), Integer), CType(CType(113, Byte), Integer))
        Me.GVTYPEFORMATION.Appearance.FixedLine.Options.UseBackColor = True
        Me.GVTYPEFORMATION.Appearance.FocusedCell.BackColor = System.Drawing.Color.White
        Me.GVTYPEFORMATION.Appearance.FocusedCell.ForeColor = System.Drawing.Color.Black
        Me.GVTYPEFORMATION.Appearance.FocusedCell.Options.UseBackColor = True
        Me.GVTYPEFORMATION.Appearance.FocusedCell.Options.UseForeColor = True
        Me.GVTYPEFORMATION.Appearance.FocusedRow.BackColor = System.Drawing.Color.FromArgb(CType(CType(200, Byte), Integer), CType(CType(192, Byte), Integer), CType(CType(157, Byte), Integer))
        Me.GVTYPEFORMATION.Appearance.FocusedRow.BorderColor = System.Drawing.Color.FromArgb(CType(CType(226, Byte), Integer), CType(CType(219, Byte), Integer), CType(CType(188, Byte), Integer))
        Me.GVTYPEFORMATION.Appearance.FocusedRow.ForeColor = System.Drawing.Color.Black
        Me.GVTYPEFORMATION.Appearance.FocusedRow.Options.UseBackColor = True
        Me.GVTYPEFORMATION.Appearance.FocusedRow.Options.UseBorderColor = True
        Me.GVTYPEFORMATION.Appearance.FocusedRow.Options.UseForeColor = True
        Me.GVTYPEFORMATION.Appearance.FooterPanel.BackColor = System.Drawing.Color.FromArgb(CType(CType(216, Byte), Integer), CType(CType(209, Byte), Integer), CType(CType(170, Byte), Integer))
        Me.GVTYPEFORMATION.Appearance.FooterPanel.BorderColor = System.Drawing.Color.FromArgb(CType(CType(216, Byte), Integer), CType(CType(209, Byte), Integer), CType(CType(170, Byte), Integer))
        Me.GVTYPEFORMATION.Appearance.FooterPanel.ForeColor = System.Drawing.Color.Black
        Me.GVTYPEFORMATION.Appearance.FooterPanel.Options.UseBackColor = True
        Me.GVTYPEFORMATION.Appearance.FooterPanel.Options.UseBorderColor = True
        Me.GVTYPEFORMATION.Appearance.FooterPanel.Options.UseForeColor = True
        Me.GVTYPEFORMATION.Appearance.GroupButton.BackColor = System.Drawing.Color.FromArgb(CType(CType(216, Byte), Integer), CType(CType(209, Byte), Integer), CType(CType(179, Byte), Integer))
        Me.GVTYPEFORMATION.Appearance.GroupButton.BorderColor = System.Drawing.Color.FromArgb(CType(CType(216, Byte), Integer), CType(CType(209, Byte), Integer), CType(CType(179, Byte), Integer))
        Me.GVTYPEFORMATION.Appearance.GroupButton.Options.UseBackColor = True
        Me.GVTYPEFORMATION.Appearance.GroupButton.Options.UseBorderColor = True
        Me.GVTYPEFORMATION.Appearance.GroupFooter.BackColor = System.Drawing.Color.FromArgb(CType(CType(236, Byte), Integer), CType(CType(232, Byte), Integer), CType(CType(201, Byte), Integer))
        Me.GVTYPEFORMATION.Appearance.GroupFooter.BorderColor = System.Drawing.Color.FromArgb(CType(CType(236, Byte), Integer), CType(CType(232, Byte), Integer), CType(CType(201, Byte), Integer))
        Me.GVTYPEFORMATION.Appearance.GroupFooter.ForeColor = System.Drawing.Color.Black
        Me.GVTYPEFORMATION.Appearance.GroupFooter.Options.UseBackColor = True
        Me.GVTYPEFORMATION.Appearance.GroupFooter.Options.UseBorderColor = True
        Me.GVTYPEFORMATION.Appearance.GroupFooter.Options.UseForeColor = True
        Me.GVTYPEFORMATION.Appearance.GroupPanel.BackColor = System.Drawing.Color.FromArgb(CType(CType(246, Byte), Integer), CType(CType(242, Byte), Integer), CType(CType(213, Byte), Integer))
        Me.GVTYPEFORMATION.Appearance.GroupPanel.BackColor2 = CType(resources.GetObject("GVTYPEFORMATION.Appearance.GroupPanel.BackColor2"), System.Drawing.Color)
        Me.GVTYPEFORMATION.Appearance.GroupPanel.ForeColor = System.Drawing.Color.Black
        Me.GVTYPEFORMATION.Appearance.GroupPanel.Options.UseBackColor = True
        Me.GVTYPEFORMATION.Appearance.GroupPanel.Options.UseForeColor = True
        Me.GVTYPEFORMATION.Appearance.GroupRow.BackColor = System.Drawing.Color.FromArgb(CType(CType(236, Byte), Integer), CType(CType(232, Byte), Integer), CType(CType(201, Byte), Integer))
        Me.GVTYPEFORMATION.Appearance.GroupRow.BorderColor = System.Drawing.Color.FromArgb(CType(CType(236, Byte), Integer), CType(CType(232, Byte), Integer), CType(CType(201, Byte), Integer))
        Me.GVTYPEFORMATION.Appearance.GroupRow.ForeColor = System.Drawing.Color.Black
        Me.GVTYPEFORMATION.Appearance.GroupRow.Options.UseBackColor = True
        Me.GVTYPEFORMATION.Appearance.GroupRow.Options.UseBorderColor = True
        Me.GVTYPEFORMATION.Appearance.GroupRow.Options.UseForeColor = True
        Me.GVTYPEFORMATION.Appearance.HeaderPanel.BackColor = System.Drawing.Color.FromArgb(CType(CType(216, Byte), Integer), CType(CType(209, Byte), Integer), CType(CType(170, Byte), Integer))
        Me.GVTYPEFORMATION.Appearance.HeaderPanel.BorderColor = System.Drawing.Color.FromArgb(CType(CType(216, Byte), Integer), CType(CType(209, Byte), Integer), CType(CType(170, Byte), Integer))
        Me.GVTYPEFORMATION.Appearance.HeaderPanel.Font = CType(resources.GetObject("GVTYPEFORMATION.Appearance.HeaderPanel.Font"), System.Drawing.Font)
        Me.GVTYPEFORMATION.Appearance.HeaderPanel.ForeColor = System.Drawing.Color.Black
        Me.GVTYPEFORMATION.Appearance.HeaderPanel.Options.UseBackColor = True
        Me.GVTYPEFORMATION.Appearance.HeaderPanel.Options.UseBorderColor = True
        Me.GVTYPEFORMATION.Appearance.HeaderPanel.Options.UseFont = True
        Me.GVTYPEFORMATION.Appearance.HeaderPanel.Options.UseForeColor = True
        Me.GVTYPEFORMATION.Appearance.HeaderPanel.Options.UseTextOptions = True
        Me.GVTYPEFORMATION.Appearance.HeaderPanel.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center
        Me.GVTYPEFORMATION.Appearance.HeaderPanel.TextOptions.VAlignment = DevExpress.Utils.VertAlignment.Center
        Me.GVTYPEFORMATION.Appearance.HeaderPanel.TextOptions.WordWrap = DevExpress.Utils.WordWrap.Wrap
        Me.GVTYPEFORMATION.Appearance.HideSelectionRow.BackColor = System.Drawing.Color.FromArgb(CType(CType(237, Byte), Integer), CType(CType(230, Byte), Integer), CType(CType(203, Byte), Integer))
        Me.GVTYPEFORMATION.Appearance.HideSelectionRow.BorderColor = System.Drawing.Color.FromArgb(CType(CType(237, Byte), Integer), CType(CType(230, Byte), Integer), CType(CType(203, Byte), Integer))
        Me.GVTYPEFORMATION.Appearance.HideSelectionRow.ForeColor = System.Drawing.Color.Black
        Me.GVTYPEFORMATION.Appearance.HideSelectionRow.Options.UseBackColor = True
        Me.GVTYPEFORMATION.Appearance.HideSelectionRow.Options.UseBorderColor = True
        Me.GVTYPEFORMATION.Appearance.HideSelectionRow.Options.UseForeColor = True
        Me.GVTYPEFORMATION.Appearance.HorzLine.BackColor = System.Drawing.Color.FromArgb(CType(CType(216, Byte), Integer), CType(CType(209, Byte), Integer), CType(CType(170, Byte), Integer))
        Me.GVTYPEFORMATION.Appearance.HorzLine.Options.UseBackColor = True
        Me.GVTYPEFORMATION.Appearance.OddRow.BackColor = System.Drawing.Color.FromArgb(CType(CType(242, Byte), Integer), CType(CType(244, Byte), Integer), CType(CType(236, Byte), Integer))
        Me.GVTYPEFORMATION.Appearance.OddRow.BorderColor = System.Drawing.Color.FromArgb(CType(CType(242, Byte), Integer), CType(CType(244, Byte), Integer), CType(CType(236, Byte), Integer))
        Me.GVTYPEFORMATION.Appearance.OddRow.ForeColor = System.Drawing.Color.Black
        Me.GVTYPEFORMATION.Appearance.OddRow.Options.UseBackColor = True
        Me.GVTYPEFORMATION.Appearance.OddRow.Options.UseBorderColor = True
        Me.GVTYPEFORMATION.Appearance.OddRow.Options.UseForeColor = True
        Me.GVTYPEFORMATION.Appearance.Preview.BackColor = System.Drawing.Color.FromArgb(CType(CType(251, Byte), Integer), CType(CType(252, Byte), Integer), CType(CType(247, Byte), Integer))
        Me.GVTYPEFORMATION.Appearance.Preview.Font = CType(resources.GetObject("GVTYPEFORMATION.Appearance.Preview.Font"), System.Drawing.Font)
        Me.GVTYPEFORMATION.Appearance.Preview.ForeColor = System.Drawing.Color.FromArgb(CType(CType(148, Byte), Integer), CType(CType(148, Byte), Integer), CType(CType(148, Byte), Integer))
        Me.GVTYPEFORMATION.Appearance.Preview.Options.UseBackColor = True
        Me.GVTYPEFORMATION.Appearance.Preview.Options.UseFont = True
        Me.GVTYPEFORMATION.Appearance.Preview.Options.UseForeColor = True
        Me.GVTYPEFORMATION.Appearance.Row.BackColor = System.Drawing.Color.FromArgb(CType(CType(242, Byte), Integer), CType(CType(244, Byte), Integer), CType(CType(236, Byte), Integer))
        Me.GVTYPEFORMATION.Appearance.Row.ForeColor = System.Drawing.Color.Black
        Me.GVTYPEFORMATION.Appearance.Row.Options.UseBackColor = True
        Me.GVTYPEFORMATION.Appearance.Row.Options.UseForeColor = True
        Me.GVTYPEFORMATION.Appearance.RowSeparator.BackColor = System.Drawing.Color.FromArgb(CType(CType(236, Byte), Integer), CType(CType(232, Byte), Integer), CType(CType(201, Byte), Integer))
        Me.GVTYPEFORMATION.Appearance.RowSeparator.BackColor2 = CType(resources.GetObject("GVTYPEFORMATION.Appearance.RowSeparator.BackColor2"), System.Drawing.Color)
        Me.GVTYPEFORMATION.Appearance.RowSeparator.Options.UseBackColor = True
        Me.GVTYPEFORMATION.Appearance.SelectedRow.BackColor = System.Drawing.Color.FromArgb(CType(CType(221, Byte), Integer), CType(CType(215, Byte), Integer), CType(CType(188, Byte), Integer))
        Me.GVTYPEFORMATION.Appearance.SelectedRow.BorderColor = System.Drawing.Color.FromArgb(CType(CType(237, Byte), Integer), CType(CType(230, Byte), Integer), CType(CType(203, Byte), Integer))
        Me.GVTYPEFORMATION.Appearance.SelectedRow.ForeColor = System.Drawing.Color.Black
        Me.GVTYPEFORMATION.Appearance.SelectedRow.Options.UseBackColor = True
        Me.GVTYPEFORMATION.Appearance.SelectedRow.Options.UseBorderColor = True
        Me.GVTYPEFORMATION.Appearance.SelectedRow.Options.UseForeColor = True
        Me.GVTYPEFORMATION.Appearance.TopNewRow.BackColor = System.Drawing.Color.White
        Me.GVTYPEFORMATION.Appearance.TopNewRow.Options.UseBackColor = True
        Me.GVTYPEFORMATION.Appearance.VertLine.BackColor = System.Drawing.Color.FromArgb(CType(CType(216, Byte), Integer), CType(CType(209, Byte), Integer), CType(CType(170, Byte), Integer))
        Me.GVTYPEFORMATION.Appearance.VertLine.Options.UseBackColor = True
        Me.GVTYPEFORMATION.ColumnPanelRowHeight = 50
        Me.GVTYPEFORMATION.Columns.AddRange(New DevExpress.XtraGrid.Columns.GridColumn() {Me.ColIDTMP, Me.ColNFORNUM, Me.ColVFORLIB, Me.ColVFORTYPE, Me.ColFORMATEUR, Me.ColVFOROBS})
        Me.GVTYPEFORMATION.GridControl = Me.GCTYPEFORMATION
        Me.GVTYPEFORMATION.Name = "GVTYPEFORMATION"
        Me.GVTYPEFORMATION.OptionsBehavior.Editable = False
        Me.GVTYPEFORMATION.OptionsNavigation.AutoFocusNewRow = True
        Me.GVTYPEFORMATION.OptionsView.EnableAppearanceEvenRow = True
        Me.GVTYPEFORMATION.OptionsView.EnableAppearanceOddRow = True
        Me.GVTYPEFORMATION.OptionsView.ShowAutoFilterRow = True
        Me.GVTYPEFORMATION.OptionsView.ShowFooter = True
        Me.GVTYPEFORMATION.OptionsView.ShowGroupPanel = False
        Me.GVTYPEFORMATION.RowHeight = 20
        '
        'ColIDTMP
        '
        resources.ApplyResources(Me.ColIDTMP, "ColIDTMP")
        Me.ColIDTMP.FieldName = "IDTMP"
        Me.ColIDTMP.Name = "ColIDTMP"
        '
        'ColNFORNUM
        '
        resources.ApplyResources(Me.ColNFORNUM, "ColNFORNUM")
        Me.ColNFORNUM.FieldName = "NFORNUM"
        Me.ColNFORNUM.Name = "ColNFORNUM"
        '
        'ColVFORLIB
        '
        resources.ApplyResources(Me.ColVFORLIB, "ColVFORLIB")
        Me.ColVFORLIB.FieldName = "VFORLIB"
        Me.ColVFORLIB.Name = "ColVFORLIB"
        Me.ColVFORLIB.OptionsFilter.AutoFilterCondition = DevExpress.XtraGrid.Columns.AutoFilterCondition.Contains
        '
        'ColVFORTYPE
        '
        resources.ApplyResources(Me.ColVFORTYPE, "ColVFORTYPE")
        Me.ColVFORTYPE.FieldName = "VFORTYPE"
        Me.ColVFORTYPE.Name = "ColVFORTYPE"
        Me.ColVFORTYPE.OptionsFilter.AutoFilterCondition = DevExpress.XtraGrid.Columns.AutoFilterCondition.Contains
        '
        'ColFORMATEUR
        '
        resources.ApplyResources(Me.ColFORMATEUR, "ColFORMATEUR")
        Me.ColFORMATEUR.FieldName = "FORMATEUR"
        Me.ColFORMATEUR.Name = "ColFORMATEUR"
        Me.ColFORMATEUR.OptionsFilter.AutoFilterCondition = DevExpress.XtraGrid.Columns.AutoFilterCondition.Contains
        '
        'ColVFOROBS
        '
        Me.ColVFOROBS.AppearanceCell.Options.UseTextOptions = True
        Me.ColVFOROBS.AppearanceCell.TextOptions.VAlignment = DevExpress.Utils.VertAlignment.Center
        resources.ApplyResources(Me.ColVFOROBS, "ColVFOROBS")
        Me.ColVFOROBS.FieldName = "VFOROBS"
        Me.ColVFOROBS.Name = "ColVFOROBS"
        Me.ColVFOROBS.OptionsFilter.AutoFilterCondition = DevExpress.XtraGrid.Columns.AutoFilterCondition.Contains
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
        Me.RepItemGLUpEditUnite.PopupView = Me.RepItemGLUpEditViewUnite
        Me.RepItemGLUpEditUnite.ValueMember = "NGTPUNITEID"
        '
        'RepItemGLUpEditViewUnite
        '
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
        'frmTypeFormation
        '
        resources.ApplyResources(Me, "$this")
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.Wheat
        Me.Controls.Add(Me.GCTYPEFORMATION)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.GrpActions)
        Me.Name = "frmTypeFormation"
        Me.WindowState = System.Windows.Forms.FormWindowState.Maximized
        CType(Me.GCORGANISME, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.GridView1, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.GVORGANISME, System.ComponentModel.ISupportInitialize).EndInit()
        Me.GrpActions.ResumeLayout(False)
        CType(Me.GCTYPEFORMATION, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.GVTYPEFORMATION, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.RepItemGLUpEditGTPLot, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.RepIGLUpEditViewLot, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.RepItemGLUpEditUnite, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.RepItemGLUpEditViewUnite, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents BtnSupprLine As System.Windows.Forms.Button
    Friend WithEvents BtnQuit As System.Windows.Forms.Button
    Friend WithEvents GrpActions As System.Windows.Forms.GroupBox
    Friend WithEvents BtnAddLine As System.Windows.Forms.Button
    Friend WithEvents BtnModLine As System.Windows.Forms.Button
    Private WithEvents GCORGANISME As DevExpress.XtraGrid.GridControl
    Private WithEvents GVORGANISME As DevExpress.XtraGrid.Views.Grid.GridView
    Private WithEvents GCTYPEFORMATION As DevExpress.XtraGrid.GridControl
    Private WithEvents GVTYPEFORMATION As DevExpress.XtraGrid.Views.Grid.GridView
    Private WithEvents ColIDTMP As DevExpress.XtraGrid.Columns.GridColumn
    Private WithEvents ColNFORNUM As DevExpress.XtraGrid.Columns.GridColumn
    Private WithEvents ColVFORLIB As DevExpress.XtraGrid.Columns.GridColumn
    Private WithEvents ColVFORTYPE As DevExpress.XtraGrid.Columns.GridColumn
    Private WithEvents ColFORMATEUR As DevExpress.XtraGrid.Columns.GridColumn
    Private WithEvents ColVFOROBS As DevExpress.XtraGrid.Columns.GridColumn
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
    Private WithEvents GridView1 As DevExpress.XtraGrid.Views.Grid.GridView
End Class
