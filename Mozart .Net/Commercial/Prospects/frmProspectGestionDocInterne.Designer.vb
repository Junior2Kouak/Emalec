<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmProspectGestionDocInterne
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(frmProspectGestionDocInterne))
        Me.GCProspDocInt = New DevExpress.XtraGrid.GridControl()
        Me.GVProspDocInt = New DevExpress.XtraGrid.Views.Grid.GridView()
        Me.GCOLIDTMP = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.GColNPROSDOCID = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.GColVLIBDOC = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.GColVFILENAME = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.GColDDATCREE = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.GColVQUICREE = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.GColDDATMODIF = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.GColVQUIMODIF = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.GrpActions = New System.Windows.Forms.GroupBox()
        Me.BtnModifier = New System.Windows.Forms.Button()
        Me.BtnSupprLine = New System.Windows.Forms.Button()
        Me.BtnAddLine = New System.Windows.Forms.Button()
        Me.BtnQuit = New System.Windows.Forms.Button()
        Me.BtnSave = New System.Windows.Forms.Button()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.GrpApercu = New System.Windows.Forms.GroupBox()
        Me.WBApercu = New System.Windows.Forms.WebBrowser()
        CType(Me.GCProspDocInt, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.GVProspDocInt, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.GrpActions.SuspendLayout()
        Me.GrpApercu.SuspendLayout()
        Me.SuspendLayout()
        '
        'GCProspDocInt
        '
        resources.ApplyResources(Me.GCProspDocInt, "GCProspDocInt")
        '
        '
        '
        Me.GCProspDocInt.EmbeddedNavigator.AccessibleDescription = resources.GetString("GCProspDocInt.EmbeddedNavigator.AccessibleDescription")
        Me.GCProspDocInt.EmbeddedNavigator.AccessibleName = resources.GetString("GCProspDocInt.EmbeddedNavigator.AccessibleName")
        Me.GCProspDocInt.EmbeddedNavigator.AllowHtmlTextInToolTip = CType(resources.GetObject("GCProspDocInt.EmbeddedNavigator.AllowHtmlTextInToolTip"), DevExpress.Utils.DefaultBoolean)
        Me.GCProspDocInt.EmbeddedNavigator.Anchor = CType(resources.GetObject("GCProspDocInt.EmbeddedNavigator.Anchor"), System.Windows.Forms.AnchorStyles)
        Me.GCProspDocInt.EmbeddedNavigator.BackgroundImage = CType(resources.GetObject("GCProspDocInt.EmbeddedNavigator.BackgroundImage"), System.Drawing.Image)
        Me.GCProspDocInt.EmbeddedNavigator.BackgroundImageLayout = CType(resources.GetObject("GCProspDocInt.EmbeddedNavigator.BackgroundImageLayout"), System.Windows.Forms.ImageLayout)
        Me.GCProspDocInt.EmbeddedNavigator.ImeMode = CType(resources.GetObject("GCProspDocInt.EmbeddedNavigator.ImeMode"), System.Windows.Forms.ImeMode)
        Me.GCProspDocInt.EmbeddedNavigator.MaximumSize = CType(resources.GetObject("GCProspDocInt.EmbeddedNavigator.MaximumSize"), System.Drawing.Size)
        Me.GCProspDocInt.EmbeddedNavigator.TextLocation = CType(resources.GetObject("GCProspDocInt.EmbeddedNavigator.TextLocation"), DevExpress.XtraEditors.NavigatorButtonsTextLocation)
        Me.GCProspDocInt.EmbeddedNavigator.ToolTip = resources.GetString("GCProspDocInt.EmbeddedNavigator.ToolTip")
        Me.GCProspDocInt.EmbeddedNavigator.ToolTipIconType = CType(resources.GetObject("GCProspDocInt.EmbeddedNavigator.ToolTipIconType"), DevExpress.Utils.ToolTipIconType)
        Me.GCProspDocInt.EmbeddedNavigator.ToolTipTitle = resources.GetString("GCProspDocInt.EmbeddedNavigator.ToolTipTitle")
        Me.GCProspDocInt.MainView = Me.GVProspDocInt
        Me.GCProspDocInt.Name = "GCProspDocInt"
        Me.GCProspDocInt.ViewCollection.AddRange(New DevExpress.XtraGrid.Views.Base.BaseView() {Me.GVProspDocInt})
        '
        'GVProspDocInt
        '
        Me.GVProspDocInt.Appearance.ColumnFilterButton.BackColor = CType(resources.GetObject("GVProspDocInt.Appearance.ColumnFilterButton.BackColor"), System.Drawing.Color)
        Me.GVProspDocInt.Appearance.ColumnFilterButton.BorderColor = CType(resources.GetObject("GVProspDocInt.Appearance.ColumnFilterButton.BorderColor"), System.Drawing.Color)
        Me.GVProspDocInt.Appearance.ColumnFilterButton.FontSizeDelta = CType(resources.GetObject("GVProspDocInt.Appearance.ColumnFilterButton.FontSizeDelta"), Integer)
        Me.GVProspDocInt.Appearance.ColumnFilterButton.FontStyleDelta = CType(resources.GetObject("GVProspDocInt.Appearance.ColumnFilterButton.FontStyleDelta"), System.Drawing.FontStyle)
        Me.GVProspDocInt.Appearance.ColumnFilterButton.ForeColor = CType(resources.GetObject("GVProspDocInt.Appearance.ColumnFilterButton.ForeColor"), System.Drawing.Color)
        Me.GVProspDocInt.Appearance.ColumnFilterButton.GradientMode = CType(resources.GetObject("GVProspDocInt.Appearance.ColumnFilterButton.GradientMode"), System.Drawing.Drawing2D.LinearGradientMode)
        Me.GVProspDocInt.Appearance.ColumnFilterButton.Image = CType(resources.GetObject("GVProspDocInt.Appearance.ColumnFilterButton.Image"), System.Drawing.Image)
        Me.GVProspDocInt.Appearance.ColumnFilterButton.Options.UseBackColor = True
        Me.GVProspDocInt.Appearance.ColumnFilterButton.Options.UseBorderColor = True
        Me.GVProspDocInt.Appearance.ColumnFilterButton.Options.UseForeColor = True
        Me.GVProspDocInt.Appearance.ColumnFilterButtonActive.BackColor = CType(resources.GetObject("GVProspDocInt.Appearance.ColumnFilterButtonActive.BackColor"), System.Drawing.Color)
        Me.GVProspDocInt.Appearance.ColumnFilterButtonActive.BorderColor = CType(resources.GetObject("GVProspDocInt.Appearance.ColumnFilterButtonActive.BorderColor"), System.Drawing.Color)
        Me.GVProspDocInt.Appearance.ColumnFilterButtonActive.FontSizeDelta = CType(resources.GetObject("GVProspDocInt.Appearance.ColumnFilterButtonActive.FontSizeDelta"), Integer)
        Me.GVProspDocInt.Appearance.ColumnFilterButtonActive.FontStyleDelta = CType(resources.GetObject("GVProspDocInt.Appearance.ColumnFilterButtonActive.FontStyleDelta"), System.Drawing.FontStyle)
        Me.GVProspDocInt.Appearance.ColumnFilterButtonActive.ForeColor = CType(resources.GetObject("GVProspDocInt.Appearance.ColumnFilterButtonActive.ForeColor"), System.Drawing.Color)
        Me.GVProspDocInt.Appearance.ColumnFilterButtonActive.GradientMode = CType(resources.GetObject("GVProspDocInt.Appearance.ColumnFilterButtonActive.GradientMode"), System.Drawing.Drawing2D.LinearGradientMode)
        Me.GVProspDocInt.Appearance.ColumnFilterButtonActive.Image = CType(resources.GetObject("GVProspDocInt.Appearance.ColumnFilterButtonActive.Image"), System.Drawing.Image)
        Me.GVProspDocInt.Appearance.ColumnFilterButtonActive.Options.UseBackColor = True
        Me.GVProspDocInt.Appearance.ColumnFilterButtonActive.Options.UseBorderColor = True
        Me.GVProspDocInt.Appearance.ColumnFilterButtonActive.Options.UseForeColor = True
        Me.GVProspDocInt.Appearance.Empty.BackColor = CType(resources.GetObject("GVProspDocInt.Appearance.Empty.BackColor"), System.Drawing.Color)
        Me.GVProspDocInt.Appearance.Empty.BackColor2 = CType(resources.GetObject("GVProspDocInt.Appearance.Empty.BackColor2"), System.Drawing.Color)
        Me.GVProspDocInt.Appearance.Empty.FontSizeDelta = CType(resources.GetObject("GVProspDocInt.Appearance.Empty.FontSizeDelta"), Integer)
        Me.GVProspDocInt.Appearance.Empty.FontStyleDelta = CType(resources.GetObject("GVProspDocInt.Appearance.Empty.FontStyleDelta"), System.Drawing.FontStyle)
        Me.GVProspDocInt.Appearance.Empty.GradientMode = CType(resources.GetObject("GVProspDocInt.Appearance.Empty.GradientMode"), System.Drawing.Drawing2D.LinearGradientMode)
        Me.GVProspDocInt.Appearance.Empty.Image = CType(resources.GetObject("GVProspDocInt.Appearance.Empty.Image"), System.Drawing.Image)
        Me.GVProspDocInt.Appearance.Empty.Options.UseBackColor = True
        Me.GVProspDocInt.Appearance.EvenRow.BackColor = CType(resources.GetObject("GVProspDocInt.Appearance.EvenRow.BackColor"), System.Drawing.Color)
        Me.GVProspDocInt.Appearance.EvenRow.BorderColor = CType(resources.GetObject("GVProspDocInt.Appearance.EvenRow.BorderColor"), System.Drawing.Color)
        Me.GVProspDocInt.Appearance.EvenRow.FontSizeDelta = CType(resources.GetObject("GVProspDocInt.Appearance.EvenRow.FontSizeDelta"), Integer)
        Me.GVProspDocInt.Appearance.EvenRow.FontStyleDelta = CType(resources.GetObject("GVProspDocInt.Appearance.EvenRow.FontStyleDelta"), System.Drawing.FontStyle)
        Me.GVProspDocInt.Appearance.EvenRow.ForeColor = CType(resources.GetObject("GVProspDocInt.Appearance.EvenRow.ForeColor"), System.Drawing.Color)
        Me.GVProspDocInt.Appearance.EvenRow.GradientMode = CType(resources.GetObject("GVProspDocInt.Appearance.EvenRow.GradientMode"), System.Drawing.Drawing2D.LinearGradientMode)
        Me.GVProspDocInt.Appearance.EvenRow.Image = CType(resources.GetObject("GVProspDocInt.Appearance.EvenRow.Image"), System.Drawing.Image)
        Me.GVProspDocInt.Appearance.EvenRow.Options.UseBackColor = True
        Me.GVProspDocInt.Appearance.EvenRow.Options.UseBorderColor = True
        Me.GVProspDocInt.Appearance.EvenRow.Options.UseForeColor = True
        Me.GVProspDocInt.Appearance.FilterCloseButton.BackColor = CType(resources.GetObject("GVProspDocInt.Appearance.FilterCloseButton.BackColor"), System.Drawing.Color)
        Me.GVProspDocInt.Appearance.FilterCloseButton.BorderColor = CType(resources.GetObject("GVProspDocInt.Appearance.FilterCloseButton.BorderColor"), System.Drawing.Color)
        Me.GVProspDocInt.Appearance.FilterCloseButton.FontSizeDelta = CType(resources.GetObject("GVProspDocInt.Appearance.FilterCloseButton.FontSizeDelta"), Integer)
        Me.GVProspDocInt.Appearance.FilterCloseButton.FontStyleDelta = CType(resources.GetObject("GVProspDocInt.Appearance.FilterCloseButton.FontStyleDelta"), System.Drawing.FontStyle)
        Me.GVProspDocInt.Appearance.FilterCloseButton.ForeColor = CType(resources.GetObject("GVProspDocInt.Appearance.FilterCloseButton.ForeColor"), System.Drawing.Color)
        Me.GVProspDocInt.Appearance.FilterCloseButton.GradientMode = CType(resources.GetObject("GVProspDocInt.Appearance.FilterCloseButton.GradientMode"), System.Drawing.Drawing2D.LinearGradientMode)
        Me.GVProspDocInt.Appearance.FilterCloseButton.Image = CType(resources.GetObject("GVProspDocInt.Appearance.FilterCloseButton.Image"), System.Drawing.Image)
        Me.GVProspDocInt.Appearance.FilterCloseButton.Options.UseBackColor = True
        Me.GVProspDocInt.Appearance.FilterCloseButton.Options.UseBorderColor = True
        Me.GVProspDocInt.Appearance.FilterCloseButton.Options.UseForeColor = True
        Me.GVProspDocInt.Appearance.FilterPanel.BackColor = CType(resources.GetObject("GVProspDocInt.Appearance.FilterPanel.BackColor"), System.Drawing.Color)
        Me.GVProspDocInt.Appearance.FilterPanel.BackColor2 = CType(resources.GetObject("GVProspDocInt.Appearance.FilterPanel.BackColor2"), System.Drawing.Color)
        Me.GVProspDocInt.Appearance.FilterPanel.FontSizeDelta = CType(resources.GetObject("GVProspDocInt.Appearance.FilterPanel.FontSizeDelta"), Integer)
        Me.GVProspDocInt.Appearance.FilterPanel.FontStyleDelta = CType(resources.GetObject("GVProspDocInt.Appearance.FilterPanel.FontStyleDelta"), System.Drawing.FontStyle)
        Me.GVProspDocInt.Appearance.FilterPanel.ForeColor = CType(resources.GetObject("GVProspDocInt.Appearance.FilterPanel.ForeColor"), System.Drawing.Color)
        Me.GVProspDocInt.Appearance.FilterPanel.GradientMode = CType(resources.GetObject("GVProspDocInt.Appearance.FilterPanel.GradientMode"), System.Drawing.Drawing2D.LinearGradientMode)
        Me.GVProspDocInt.Appearance.FilterPanel.Image = CType(resources.GetObject("GVProspDocInt.Appearance.FilterPanel.Image"), System.Drawing.Image)
        Me.GVProspDocInt.Appearance.FilterPanel.Options.UseBackColor = True
        Me.GVProspDocInt.Appearance.FilterPanel.Options.UseForeColor = True
        Me.GVProspDocInt.Appearance.FixedLine.BackColor = CType(resources.GetObject("GVProspDocInt.Appearance.FixedLine.BackColor"), System.Drawing.Color)
        Me.GVProspDocInt.Appearance.FixedLine.FontSizeDelta = CType(resources.GetObject("GVProspDocInt.Appearance.FixedLine.FontSizeDelta"), Integer)
        Me.GVProspDocInt.Appearance.FixedLine.FontStyleDelta = CType(resources.GetObject("GVProspDocInt.Appearance.FixedLine.FontStyleDelta"), System.Drawing.FontStyle)
        Me.GVProspDocInt.Appearance.FixedLine.GradientMode = CType(resources.GetObject("GVProspDocInt.Appearance.FixedLine.GradientMode"), System.Drawing.Drawing2D.LinearGradientMode)
        Me.GVProspDocInt.Appearance.FixedLine.Image = CType(resources.GetObject("GVProspDocInt.Appearance.FixedLine.Image"), System.Drawing.Image)
        Me.GVProspDocInt.Appearance.FixedLine.Options.UseBackColor = True
        Me.GVProspDocInt.Appearance.FocusedCell.BackColor = CType(resources.GetObject("GVProspDocInt.Appearance.FocusedCell.BackColor"), System.Drawing.Color)
        Me.GVProspDocInt.Appearance.FocusedCell.FontSizeDelta = CType(resources.GetObject("GVProspDocInt.Appearance.FocusedCell.FontSizeDelta"), Integer)
        Me.GVProspDocInt.Appearance.FocusedCell.FontStyleDelta = CType(resources.GetObject("GVProspDocInt.Appearance.FocusedCell.FontStyleDelta"), System.Drawing.FontStyle)
        Me.GVProspDocInt.Appearance.FocusedCell.ForeColor = CType(resources.GetObject("GVProspDocInt.Appearance.FocusedCell.ForeColor"), System.Drawing.Color)
        Me.GVProspDocInt.Appearance.FocusedCell.GradientMode = CType(resources.GetObject("GVProspDocInt.Appearance.FocusedCell.GradientMode"), System.Drawing.Drawing2D.LinearGradientMode)
        Me.GVProspDocInt.Appearance.FocusedCell.Image = CType(resources.GetObject("GVProspDocInt.Appearance.FocusedCell.Image"), System.Drawing.Image)
        Me.GVProspDocInt.Appearance.FocusedCell.Options.UseBackColor = True
        Me.GVProspDocInt.Appearance.FocusedCell.Options.UseForeColor = True
        Me.GVProspDocInt.Appearance.FocusedRow.BackColor = CType(resources.GetObject("GVProspDocInt.Appearance.FocusedRow.BackColor"), System.Drawing.Color)
        Me.GVProspDocInt.Appearance.FocusedRow.FontSizeDelta = CType(resources.GetObject("GVProspDocInt.Appearance.FocusedRow.FontSizeDelta"), Integer)
        Me.GVProspDocInt.Appearance.FocusedRow.FontStyleDelta = CType(resources.GetObject("GVProspDocInt.Appearance.FocusedRow.FontStyleDelta"), System.Drawing.FontStyle)
        Me.GVProspDocInt.Appearance.FocusedRow.ForeColor = CType(resources.GetObject("GVProspDocInt.Appearance.FocusedRow.ForeColor"), System.Drawing.Color)
        Me.GVProspDocInt.Appearance.FocusedRow.GradientMode = CType(resources.GetObject("GVProspDocInt.Appearance.FocusedRow.GradientMode"), System.Drawing.Drawing2D.LinearGradientMode)
        Me.GVProspDocInt.Appearance.FocusedRow.Image = CType(resources.GetObject("GVProspDocInt.Appearance.FocusedRow.Image"), System.Drawing.Image)
        Me.GVProspDocInt.Appearance.FocusedRow.Options.UseBackColor = True
        Me.GVProspDocInt.Appearance.FocusedRow.Options.UseForeColor = True
        Me.GVProspDocInt.Appearance.FooterPanel.BackColor = CType(resources.GetObject("GVProspDocInt.Appearance.FooterPanel.BackColor"), System.Drawing.Color)
        Me.GVProspDocInt.Appearance.FooterPanel.BorderColor = CType(resources.GetObject("GVProspDocInt.Appearance.FooterPanel.BorderColor"), System.Drawing.Color)
        Me.GVProspDocInt.Appearance.FooterPanel.FontSizeDelta = CType(resources.GetObject("GVProspDocInt.Appearance.FooterPanel.FontSizeDelta"), Integer)
        Me.GVProspDocInt.Appearance.FooterPanel.FontStyleDelta = CType(resources.GetObject("GVProspDocInt.Appearance.FooterPanel.FontStyleDelta"), System.Drawing.FontStyle)
        Me.GVProspDocInt.Appearance.FooterPanel.ForeColor = CType(resources.GetObject("GVProspDocInt.Appearance.FooterPanel.ForeColor"), System.Drawing.Color)
        Me.GVProspDocInt.Appearance.FooterPanel.GradientMode = CType(resources.GetObject("GVProspDocInt.Appearance.FooterPanel.GradientMode"), System.Drawing.Drawing2D.LinearGradientMode)
        Me.GVProspDocInt.Appearance.FooterPanel.Image = CType(resources.GetObject("GVProspDocInt.Appearance.FooterPanel.Image"), System.Drawing.Image)
        Me.GVProspDocInt.Appearance.FooterPanel.Options.UseBackColor = True
        Me.GVProspDocInt.Appearance.FooterPanel.Options.UseBorderColor = True
        Me.GVProspDocInt.Appearance.FooterPanel.Options.UseForeColor = True
        Me.GVProspDocInt.Appearance.GroupButton.BackColor = CType(resources.GetObject("GVProspDocInt.Appearance.GroupButton.BackColor"), System.Drawing.Color)
        Me.GVProspDocInt.Appearance.GroupButton.BorderColor = CType(resources.GetObject("GVProspDocInt.Appearance.GroupButton.BorderColor"), System.Drawing.Color)
        Me.GVProspDocInt.Appearance.GroupButton.FontSizeDelta = CType(resources.GetObject("GVProspDocInt.Appearance.GroupButton.FontSizeDelta"), Integer)
        Me.GVProspDocInt.Appearance.GroupButton.FontStyleDelta = CType(resources.GetObject("GVProspDocInt.Appearance.GroupButton.FontStyleDelta"), System.Drawing.FontStyle)
        Me.GVProspDocInt.Appearance.GroupButton.GradientMode = CType(resources.GetObject("GVProspDocInt.Appearance.GroupButton.GradientMode"), System.Drawing.Drawing2D.LinearGradientMode)
        Me.GVProspDocInt.Appearance.GroupButton.Image = CType(resources.GetObject("GVProspDocInt.Appearance.GroupButton.Image"), System.Drawing.Image)
        Me.GVProspDocInt.Appearance.GroupButton.Options.UseBackColor = True
        Me.GVProspDocInt.Appearance.GroupButton.Options.UseBorderColor = True
        Me.GVProspDocInt.Appearance.GroupFooter.BackColor = CType(resources.GetObject("GVProspDocInt.Appearance.GroupFooter.BackColor"), System.Drawing.Color)
        Me.GVProspDocInt.Appearance.GroupFooter.BorderColor = CType(resources.GetObject("GVProspDocInt.Appearance.GroupFooter.BorderColor"), System.Drawing.Color)
        Me.GVProspDocInt.Appearance.GroupFooter.FontSizeDelta = CType(resources.GetObject("GVProspDocInt.Appearance.GroupFooter.FontSizeDelta"), Integer)
        Me.GVProspDocInt.Appearance.GroupFooter.FontStyleDelta = CType(resources.GetObject("GVProspDocInt.Appearance.GroupFooter.FontStyleDelta"), System.Drawing.FontStyle)
        Me.GVProspDocInt.Appearance.GroupFooter.ForeColor = CType(resources.GetObject("GVProspDocInt.Appearance.GroupFooter.ForeColor"), System.Drawing.Color)
        Me.GVProspDocInt.Appearance.GroupFooter.GradientMode = CType(resources.GetObject("GVProspDocInt.Appearance.GroupFooter.GradientMode"), System.Drawing.Drawing2D.LinearGradientMode)
        Me.GVProspDocInt.Appearance.GroupFooter.Image = CType(resources.GetObject("GVProspDocInt.Appearance.GroupFooter.Image"), System.Drawing.Image)
        Me.GVProspDocInt.Appearance.GroupFooter.Options.UseBackColor = True
        Me.GVProspDocInt.Appearance.GroupFooter.Options.UseBorderColor = True
        Me.GVProspDocInt.Appearance.GroupFooter.Options.UseForeColor = True
        Me.GVProspDocInt.Appearance.GroupPanel.BackColor = CType(resources.GetObject("GVProspDocInt.Appearance.GroupPanel.BackColor"), System.Drawing.Color)
        Me.GVProspDocInt.Appearance.GroupPanel.BackColor2 = CType(resources.GetObject("GVProspDocInt.Appearance.GroupPanel.BackColor2"), System.Drawing.Color)
        Me.GVProspDocInt.Appearance.GroupPanel.FontSizeDelta = CType(resources.GetObject("GVProspDocInt.Appearance.GroupPanel.FontSizeDelta"), Integer)
        Me.GVProspDocInt.Appearance.GroupPanel.FontStyleDelta = CType(resources.GetObject("GVProspDocInt.Appearance.GroupPanel.FontStyleDelta"), System.Drawing.FontStyle)
        Me.GVProspDocInt.Appearance.GroupPanel.ForeColor = CType(resources.GetObject("GVProspDocInt.Appearance.GroupPanel.ForeColor"), System.Drawing.Color)
        Me.GVProspDocInt.Appearance.GroupPanel.GradientMode = CType(resources.GetObject("GVProspDocInt.Appearance.GroupPanel.GradientMode"), System.Drawing.Drawing2D.LinearGradientMode)
        Me.GVProspDocInt.Appearance.GroupPanel.Image = CType(resources.GetObject("GVProspDocInt.Appearance.GroupPanel.Image"), System.Drawing.Image)
        Me.GVProspDocInt.Appearance.GroupPanel.Options.UseBackColor = True
        Me.GVProspDocInt.Appearance.GroupPanel.Options.UseForeColor = True
        Me.GVProspDocInt.Appearance.GroupRow.BackColor = CType(resources.GetObject("GVProspDocInt.Appearance.GroupRow.BackColor"), System.Drawing.Color)
        Me.GVProspDocInt.Appearance.GroupRow.BorderColor = CType(resources.GetObject("GVProspDocInt.Appearance.GroupRow.BorderColor"), System.Drawing.Color)
        Me.GVProspDocInt.Appearance.GroupRow.FontSizeDelta = CType(resources.GetObject("GVProspDocInt.Appearance.GroupRow.FontSizeDelta"), Integer)
        Me.GVProspDocInt.Appearance.GroupRow.FontStyleDelta = CType(resources.GetObject("GVProspDocInt.Appearance.GroupRow.FontStyleDelta"), System.Drawing.FontStyle)
        Me.GVProspDocInt.Appearance.GroupRow.ForeColor = CType(resources.GetObject("GVProspDocInt.Appearance.GroupRow.ForeColor"), System.Drawing.Color)
        Me.GVProspDocInt.Appearance.GroupRow.GradientMode = CType(resources.GetObject("GVProspDocInt.Appearance.GroupRow.GradientMode"), System.Drawing.Drawing2D.LinearGradientMode)
        Me.GVProspDocInt.Appearance.GroupRow.Image = CType(resources.GetObject("GVProspDocInt.Appearance.GroupRow.Image"), System.Drawing.Image)
        Me.GVProspDocInt.Appearance.GroupRow.Options.UseBackColor = True
        Me.GVProspDocInt.Appearance.GroupRow.Options.UseBorderColor = True
        Me.GVProspDocInt.Appearance.GroupRow.Options.UseForeColor = True
        Me.GVProspDocInt.Appearance.HeaderPanel.BackColor = CType(resources.GetObject("GVProspDocInt.Appearance.HeaderPanel.BackColor"), System.Drawing.Color)
        Me.GVProspDocInt.Appearance.HeaderPanel.BorderColor = CType(resources.GetObject("GVProspDocInt.Appearance.HeaderPanel.BorderColor"), System.Drawing.Color)
        Me.GVProspDocInt.Appearance.HeaderPanel.FontSizeDelta = CType(resources.GetObject("GVProspDocInt.Appearance.HeaderPanel.FontSizeDelta"), Integer)
        Me.GVProspDocInt.Appearance.HeaderPanel.FontStyleDelta = CType(resources.GetObject("GVProspDocInt.Appearance.HeaderPanel.FontStyleDelta"), System.Drawing.FontStyle)
        Me.GVProspDocInt.Appearance.HeaderPanel.ForeColor = CType(resources.GetObject("GVProspDocInt.Appearance.HeaderPanel.ForeColor"), System.Drawing.Color)
        Me.GVProspDocInt.Appearance.HeaderPanel.GradientMode = CType(resources.GetObject("GVProspDocInt.Appearance.HeaderPanel.GradientMode"), System.Drawing.Drawing2D.LinearGradientMode)
        Me.GVProspDocInt.Appearance.HeaderPanel.Image = CType(resources.GetObject("GVProspDocInt.Appearance.HeaderPanel.Image"), System.Drawing.Image)
        Me.GVProspDocInt.Appearance.HeaderPanel.Options.UseBackColor = True
        Me.GVProspDocInt.Appearance.HeaderPanel.Options.UseBorderColor = True
        Me.GVProspDocInt.Appearance.HeaderPanel.Options.UseForeColor = True
        Me.GVProspDocInt.Appearance.HideSelectionRow.BackColor = CType(resources.GetObject("GVProspDocInt.Appearance.HideSelectionRow.BackColor"), System.Drawing.Color)
        Me.GVProspDocInt.Appearance.HideSelectionRow.FontSizeDelta = CType(resources.GetObject("GVProspDocInt.Appearance.HideSelectionRow.FontSizeDelta"), Integer)
        Me.GVProspDocInt.Appearance.HideSelectionRow.FontStyleDelta = CType(resources.GetObject("GVProspDocInt.Appearance.HideSelectionRow.FontStyleDelta"), System.Drawing.FontStyle)
        Me.GVProspDocInt.Appearance.HideSelectionRow.ForeColor = CType(resources.GetObject("GVProspDocInt.Appearance.HideSelectionRow.ForeColor"), System.Drawing.Color)
        Me.GVProspDocInt.Appearance.HideSelectionRow.GradientMode = CType(resources.GetObject("GVProspDocInt.Appearance.HideSelectionRow.GradientMode"), System.Drawing.Drawing2D.LinearGradientMode)
        Me.GVProspDocInt.Appearance.HideSelectionRow.Image = CType(resources.GetObject("GVProspDocInt.Appearance.HideSelectionRow.Image"), System.Drawing.Image)
        Me.GVProspDocInt.Appearance.HideSelectionRow.Options.UseBackColor = True
        Me.GVProspDocInt.Appearance.HideSelectionRow.Options.UseForeColor = True
        Me.GVProspDocInt.Appearance.HorzLine.BackColor = CType(resources.GetObject("GVProspDocInt.Appearance.HorzLine.BackColor"), System.Drawing.Color)
        Me.GVProspDocInt.Appearance.HorzLine.BorderColor = CType(resources.GetObject("GVProspDocInt.Appearance.HorzLine.BorderColor"), System.Drawing.Color)
        Me.GVProspDocInt.Appearance.HorzLine.FontSizeDelta = CType(resources.GetObject("GVProspDocInt.Appearance.HorzLine.FontSizeDelta"), Integer)
        Me.GVProspDocInt.Appearance.HorzLine.FontStyleDelta = CType(resources.GetObject("GVProspDocInt.Appearance.HorzLine.FontStyleDelta"), System.Drawing.FontStyle)
        Me.GVProspDocInt.Appearance.HorzLine.GradientMode = CType(resources.GetObject("GVProspDocInt.Appearance.HorzLine.GradientMode"), System.Drawing.Drawing2D.LinearGradientMode)
        Me.GVProspDocInt.Appearance.HorzLine.Image = CType(resources.GetObject("GVProspDocInt.Appearance.HorzLine.Image"), System.Drawing.Image)
        Me.GVProspDocInt.Appearance.HorzLine.Options.UseBackColor = True
        Me.GVProspDocInt.Appearance.HorzLine.Options.UseBorderColor = True
        Me.GVProspDocInt.Appearance.OddRow.BackColor = CType(resources.GetObject("GVProspDocInt.Appearance.OddRow.BackColor"), System.Drawing.Color)
        Me.GVProspDocInt.Appearance.OddRow.BorderColor = CType(resources.GetObject("GVProspDocInt.Appearance.OddRow.BorderColor"), System.Drawing.Color)
        Me.GVProspDocInt.Appearance.OddRow.FontSizeDelta = CType(resources.GetObject("GVProspDocInt.Appearance.OddRow.FontSizeDelta"), Integer)
        Me.GVProspDocInt.Appearance.OddRow.FontStyleDelta = CType(resources.GetObject("GVProspDocInt.Appearance.OddRow.FontStyleDelta"), System.Drawing.FontStyle)
        Me.GVProspDocInt.Appearance.OddRow.ForeColor = CType(resources.GetObject("GVProspDocInt.Appearance.OddRow.ForeColor"), System.Drawing.Color)
        Me.GVProspDocInt.Appearance.OddRow.GradientMode = CType(resources.GetObject("GVProspDocInt.Appearance.OddRow.GradientMode"), System.Drawing.Drawing2D.LinearGradientMode)
        Me.GVProspDocInt.Appearance.OddRow.Image = CType(resources.GetObject("GVProspDocInt.Appearance.OddRow.Image"), System.Drawing.Image)
        Me.GVProspDocInt.Appearance.OddRow.Options.UseBackColor = True
        Me.GVProspDocInt.Appearance.OddRow.Options.UseBorderColor = True
        Me.GVProspDocInt.Appearance.OddRow.Options.UseForeColor = True
        Me.GVProspDocInt.Appearance.Preview.BackColor = CType(resources.GetObject("GVProspDocInt.Appearance.Preview.BackColor"), System.Drawing.Color)
        Me.GVProspDocInt.Appearance.Preview.Font = CType(resources.GetObject("GVProspDocInt.Appearance.Preview.Font"), System.Drawing.Font)
        Me.GVProspDocInt.Appearance.Preview.FontSizeDelta = CType(resources.GetObject("GVProspDocInt.Appearance.Preview.FontSizeDelta"), Integer)
        Me.GVProspDocInt.Appearance.Preview.FontStyleDelta = CType(resources.GetObject("GVProspDocInt.Appearance.Preview.FontStyleDelta"), System.Drawing.FontStyle)
        Me.GVProspDocInt.Appearance.Preview.ForeColor = CType(resources.GetObject("GVProspDocInt.Appearance.Preview.ForeColor"), System.Drawing.Color)
        Me.GVProspDocInt.Appearance.Preview.GradientMode = CType(resources.GetObject("GVProspDocInt.Appearance.Preview.GradientMode"), System.Drawing.Drawing2D.LinearGradientMode)
        Me.GVProspDocInt.Appearance.Preview.Image = CType(resources.GetObject("GVProspDocInt.Appearance.Preview.Image"), System.Drawing.Image)
        Me.GVProspDocInt.Appearance.Preview.Options.UseBackColor = True
        Me.GVProspDocInt.Appearance.Preview.Options.UseFont = True
        Me.GVProspDocInt.Appearance.Preview.Options.UseForeColor = True
        Me.GVProspDocInt.Appearance.Row.BackColor = CType(resources.GetObject("GVProspDocInt.Appearance.Row.BackColor"), System.Drawing.Color)
        Me.GVProspDocInt.Appearance.Row.FontSizeDelta = CType(resources.GetObject("GVProspDocInt.Appearance.Row.FontSizeDelta"), Integer)
        Me.GVProspDocInt.Appearance.Row.FontStyleDelta = CType(resources.GetObject("GVProspDocInt.Appearance.Row.FontStyleDelta"), System.Drawing.FontStyle)
        Me.GVProspDocInt.Appearance.Row.ForeColor = CType(resources.GetObject("GVProspDocInt.Appearance.Row.ForeColor"), System.Drawing.Color)
        Me.GVProspDocInt.Appearance.Row.GradientMode = CType(resources.GetObject("GVProspDocInt.Appearance.Row.GradientMode"), System.Drawing.Drawing2D.LinearGradientMode)
        Me.GVProspDocInt.Appearance.Row.Image = CType(resources.GetObject("GVProspDocInt.Appearance.Row.Image"), System.Drawing.Image)
        Me.GVProspDocInt.Appearance.Row.Options.UseBackColor = True
        Me.GVProspDocInt.Appearance.Row.Options.UseForeColor = True
        Me.GVProspDocInt.Appearance.RowSeparator.BackColor = CType(resources.GetObject("GVProspDocInt.Appearance.RowSeparator.BackColor"), System.Drawing.Color)
        Me.GVProspDocInt.Appearance.RowSeparator.BackColor2 = CType(resources.GetObject("GVProspDocInt.Appearance.RowSeparator.BackColor2"), System.Drawing.Color)
        Me.GVProspDocInt.Appearance.RowSeparator.FontSizeDelta = CType(resources.GetObject("GVProspDocInt.Appearance.RowSeparator.FontSizeDelta"), Integer)
        Me.GVProspDocInt.Appearance.RowSeparator.FontStyleDelta = CType(resources.GetObject("GVProspDocInt.Appearance.RowSeparator.FontStyleDelta"), System.Drawing.FontStyle)
        Me.GVProspDocInt.Appearance.RowSeparator.GradientMode = CType(resources.GetObject("GVProspDocInt.Appearance.RowSeparator.GradientMode"), System.Drawing.Drawing2D.LinearGradientMode)
        Me.GVProspDocInt.Appearance.RowSeparator.Image = CType(resources.GetObject("GVProspDocInt.Appearance.RowSeparator.Image"), System.Drawing.Image)
        Me.GVProspDocInt.Appearance.RowSeparator.Options.UseBackColor = True
        Me.GVProspDocInt.Appearance.SelectedRow.BackColor = CType(resources.GetObject("GVProspDocInt.Appearance.SelectedRow.BackColor"), System.Drawing.Color)
        Me.GVProspDocInt.Appearance.SelectedRow.FontSizeDelta = CType(resources.GetObject("GVProspDocInt.Appearance.SelectedRow.FontSizeDelta"), Integer)
        Me.GVProspDocInt.Appearance.SelectedRow.FontStyleDelta = CType(resources.GetObject("GVProspDocInt.Appearance.SelectedRow.FontStyleDelta"), System.Drawing.FontStyle)
        Me.GVProspDocInt.Appearance.SelectedRow.ForeColor = CType(resources.GetObject("GVProspDocInt.Appearance.SelectedRow.ForeColor"), System.Drawing.Color)
        Me.GVProspDocInt.Appearance.SelectedRow.GradientMode = CType(resources.GetObject("GVProspDocInt.Appearance.SelectedRow.GradientMode"), System.Drawing.Drawing2D.LinearGradientMode)
        Me.GVProspDocInt.Appearance.SelectedRow.Image = CType(resources.GetObject("GVProspDocInt.Appearance.SelectedRow.Image"), System.Drawing.Image)
        Me.GVProspDocInt.Appearance.SelectedRow.Options.UseBackColor = True
        Me.GVProspDocInt.Appearance.SelectedRow.Options.UseForeColor = True
        Me.GVProspDocInt.Appearance.TopNewRow.BackColor = CType(resources.GetObject("GVProspDocInt.Appearance.TopNewRow.BackColor"), System.Drawing.Color)
        Me.GVProspDocInt.Appearance.TopNewRow.FontSizeDelta = CType(resources.GetObject("GVProspDocInt.Appearance.TopNewRow.FontSizeDelta"), Integer)
        Me.GVProspDocInt.Appearance.TopNewRow.FontStyleDelta = CType(resources.GetObject("GVProspDocInt.Appearance.TopNewRow.FontStyleDelta"), System.Drawing.FontStyle)
        Me.GVProspDocInt.Appearance.TopNewRow.GradientMode = CType(resources.GetObject("GVProspDocInt.Appearance.TopNewRow.GradientMode"), System.Drawing.Drawing2D.LinearGradientMode)
        Me.GVProspDocInt.Appearance.TopNewRow.Image = CType(resources.GetObject("GVProspDocInt.Appearance.TopNewRow.Image"), System.Drawing.Image)
        Me.GVProspDocInt.Appearance.TopNewRow.Options.UseBackColor = True
        Me.GVProspDocInt.Appearance.VertLine.BackColor = CType(resources.GetObject("GVProspDocInt.Appearance.VertLine.BackColor"), System.Drawing.Color)
        Me.GVProspDocInt.Appearance.VertLine.BorderColor = CType(resources.GetObject("GVProspDocInt.Appearance.VertLine.BorderColor"), System.Drawing.Color)
        Me.GVProspDocInt.Appearance.VertLine.FontSizeDelta = CType(resources.GetObject("GVProspDocInt.Appearance.VertLine.FontSizeDelta"), Integer)
        Me.GVProspDocInt.Appearance.VertLine.FontStyleDelta = CType(resources.GetObject("GVProspDocInt.Appearance.VertLine.FontStyleDelta"), System.Drawing.FontStyle)
        Me.GVProspDocInt.Appearance.VertLine.GradientMode = CType(resources.GetObject("GVProspDocInt.Appearance.VertLine.GradientMode"), System.Drawing.Drawing2D.LinearGradientMode)
        Me.GVProspDocInt.Appearance.VertLine.Image = CType(resources.GetObject("GVProspDocInt.Appearance.VertLine.Image"), System.Drawing.Image)
        Me.GVProspDocInt.Appearance.VertLine.Options.UseBackColor = True
        Me.GVProspDocInt.Appearance.VertLine.Options.UseBorderColor = True
        resources.ApplyResources(Me.GVProspDocInt, "GVProspDocInt")
        Me.GVProspDocInt.Columns.AddRange(New DevExpress.XtraGrid.Columns.GridColumn() {Me.GCOLIDTMP, Me.GColNPROSDOCID, Me.GColVLIBDOC, Me.GColVFILENAME, Me.GColDDATCREE, Me.GColVQUICREE, Me.GColDDATMODIF, Me.GColVQUIMODIF})
        Me.GVProspDocInt.GridControl = Me.GCProspDocInt
        Me.GVProspDocInt.Name = "GVProspDocInt"
        Me.GVProspDocInt.OptionsBehavior.Editable = False
        Me.GVProspDocInt.OptionsBehavior.ReadOnly = True
        Me.GVProspDocInt.OptionsNavigation.AutoFocusNewRow = True
        Me.GVProspDocInt.OptionsView.EnableAppearanceEvenRow = True
        Me.GVProspDocInt.OptionsView.EnableAppearanceOddRow = True
        Me.GVProspDocInt.OptionsView.ShowGroupPanel = False
        '
        'GCOLIDTMP
        '
        resources.ApplyResources(Me.GCOLIDTMP, "GCOLIDTMP")
        Me.GCOLIDTMP.FieldName = "IDTMP"
        Me.GCOLIDTMP.Name = "GCOLIDTMP"
        '
        'GColNPROSDOCID
        '
        resources.ApplyResources(Me.GColNPROSDOCID, "GColNPROSDOCID")
        Me.GColNPROSDOCID.FieldName = "NPROSDOCID"
        Me.GColNPROSDOCID.Name = "GColNPROSDOCID"
        '
        'GColVLIBDOC
        '
        resources.ApplyResources(Me.GColVLIBDOC, "GColVLIBDOC")
        Me.GColVLIBDOC.FieldName = "VLIBDOC"
        Me.GColVLIBDOC.Name = "GColVLIBDOC"
        '
        'GColVFILENAME
        '
        resources.ApplyResources(Me.GColVFILENAME, "GColVFILENAME")
        Me.GColVFILENAME.FieldName = "VFILENAME"
        Me.GColVFILENAME.Name = "GColVFILENAME"
        '
        'GColDDATCREE
        '
        resources.ApplyResources(Me.GColDDATCREE, "GColDDATCREE")
        Me.GColDDATCREE.FieldName = "DDATCREE"
        Me.GColDDATCREE.Name = "GColDDATCREE"
        '
        'GColVQUICREE
        '
        resources.ApplyResources(Me.GColVQUICREE, "GColVQUICREE")
        Me.GColVQUICREE.FieldName = "VQUICREE"
        Me.GColVQUICREE.Name = "GColVQUICREE"
        '
        'GColDDATMODIF
        '
        resources.ApplyResources(Me.GColDDATMODIF, "GColDDATMODIF")
        Me.GColDDATMODIF.FieldName = "DDATMODIF"
        Me.GColDDATMODIF.Name = "GColDDATMODIF"
        '
        'GColVQUIMODIF
        '
        resources.ApplyResources(Me.GColVQUIMODIF, "GColVQUIMODIF")
        Me.GColVQUIMODIF.FieldName = "VQUIMODIF"
        Me.GColVQUIMODIF.Name = "GColVQUIMODIF"
        '
        'GrpActions
        '
        resources.ApplyResources(Me.GrpActions, "GrpActions")
        Me.GrpActions.Controls.Add(Me.BtnModifier)
        Me.GrpActions.Controls.Add(Me.BtnSupprLine)
        Me.GrpActions.Controls.Add(Me.BtnAddLine)
        Me.GrpActions.Controls.Add(Me.BtnQuit)
        Me.GrpActions.Controls.Add(Me.BtnSave)
        Me.GrpActions.Name = "GrpActions"
        Me.GrpActions.TabStop = False
        '
        'BtnModifier
        '
        resources.ApplyResources(Me.BtnModifier, "BtnModifier")
        Me.BtnModifier.BackColor = System.Drawing.Color.LightGreen
        Me.BtnModifier.Name = "BtnModifier"
        Me.BtnModifier.UseVisualStyleBackColor = False
        '
        'BtnSupprLine
        '
        resources.ApplyResources(Me.BtnSupprLine, "BtnSupprLine")
        Me.BtnSupprLine.BackColor = System.Drawing.Color.LightGreen
        Me.BtnSupprLine.Name = "BtnSupprLine"
        Me.BtnSupprLine.UseVisualStyleBackColor = False
        '
        'BtnAddLine
        '
        resources.ApplyResources(Me.BtnAddLine, "BtnAddLine")
        Me.BtnAddLine.BackColor = System.Drawing.Color.LightGreen
        Me.BtnAddLine.Name = "BtnAddLine"
        Me.BtnAddLine.UseVisualStyleBackColor = False
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
        'GrpApercu
        '
        resources.ApplyResources(Me.GrpApercu, "GrpApercu")
        Me.GrpApercu.Controls.Add(Me.WBApercu)
        Me.GrpApercu.Name = "GrpApercu"
        Me.GrpApercu.TabStop = False
        '
        'WBApercu
        '
        resources.ApplyResources(Me.WBApercu, "WBApercu")
        Me.WBApercu.Name = "WBApercu"
        '
        'frmProspectGestionDocInterne
        '
        resources.ApplyResources(Me, "$this")
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.Wheat
        Me.Controls.Add(Me.GrpApercu)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.GrpActions)
        Me.Controls.Add(Me.GCProspDocInt)
        Me.Name = "frmProspectGestionDocInterne"
        Me.WindowState = System.Windows.Forms.FormWindowState.Maximized
        CType(Me.GCProspDocInt, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.GVProspDocInt, System.ComponentModel.ISupportInitialize).EndInit()
        Me.GrpActions.ResumeLayout(False)
        Me.GrpApercu.ResumeLayout(False)
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents GrpActions As System.Windows.Forms.GroupBox
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents BtnModifier As System.Windows.Forms.Button
    Friend WithEvents BtnSupprLine As System.Windows.Forms.Button
    Friend WithEvents BtnAddLine As System.Windows.Forms.Button
    Friend WithEvents BtnQuit As System.Windows.Forms.Button
    Friend WithEvents BtnSave As System.Windows.Forms.Button
    Friend WithEvents GrpApercu As System.Windows.Forms.GroupBox
    Friend WithEvents WBApercu As System.Windows.Forms.WebBrowser
    Private WithEvents GCProspDocInt As DevExpress.XtraGrid.GridControl
    Private WithEvents GVProspDocInt As DevExpress.XtraGrid.Views.Grid.GridView
    Private WithEvents GColNPROSDOCID As DevExpress.XtraGrid.Columns.GridColumn
    Private WithEvents GColVLIBDOC As DevExpress.XtraGrid.Columns.GridColumn
    Private WithEvents GColVFILENAME As DevExpress.XtraGrid.Columns.GridColumn
    Private WithEvents GColDDATCREE As DevExpress.XtraGrid.Columns.GridColumn
    Private WithEvents GColVQUICREE As DevExpress.XtraGrid.Columns.GridColumn
    Private WithEvents GColDDATMODIF As DevExpress.XtraGrid.Columns.GridColumn
    Private WithEvents GColVQUIMODIF As DevExpress.XtraGrid.Columns.GridColumn
    Private WithEvents GCOLIDTMP As DevExpress.XtraGrid.Columns.GridColumn
End Class
