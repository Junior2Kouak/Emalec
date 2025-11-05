<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class frmStatTechEvolIndic
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
    Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(frmStatTechEvolIndic))
    Me.LblTitre = New System.Windows.Forms.Label()
    Me.GrpActions = New System.Windows.Forms.GroupBox()
    Me.btnExport = New System.Windows.Forms.Button()
    Me.BtnFermer = New System.Windows.Forms.Button()
    Me.BtnPrint = New System.Windows.Forms.Button()
    Me.GCStatEvolTech = New DevExpress.XtraGrid.GridControl()
    Me.GVStatEvolTech = New DevExpress.XtraGrid.Views.Grid.GridView()
    Me.GCol_NPERNUM = New DevExpress.XtraGrid.Columns.GridColumn()
    Me.GCol_VPERNOM = New DevExpress.XtraGrid.Columns.GridColumn()
    Me.GCol_VNOMSTAT = New DevExpress.XtraGrid.Columns.GridColumn()
    Me.GCol_COL_1 = New DevExpress.XtraGrid.Columns.GridColumn()
    Me.GCol_COL_2 = New DevExpress.XtraGrid.Columns.GridColumn()
    Me.GCol_COL_3 = New DevExpress.XtraGrid.Columns.GridColumn()
    Me.GCol_COL_4 = New DevExpress.XtraGrid.Columns.GridColumn()
    Me.GCol_COL_5 = New DevExpress.XtraGrid.Columns.GridColumn()
    Me.GCol_COL_6 = New DevExpress.XtraGrid.Columns.GridColumn()
    Me.GCol_COL_7 = New DevExpress.XtraGrid.Columns.GridColumn()
    Me.GCol_COL_8 = New DevExpress.XtraGrid.Columns.GridColumn()
    Me.GCol_COL_9 = New DevExpress.XtraGrid.Columns.GridColumn()
    Me.GCol_COL_10 = New DevExpress.XtraGrid.Columns.GridColumn()
    Me.GCol_COL_11 = New DevExpress.XtraGrid.Columns.GridColumn()
    Me.GCol_COL_12 = New DevExpress.XtraGrid.Columns.GridColumn()
    Me.GCol_MOY = New DevExpress.XtraGrid.Columns.GridColumn()
    Me.LblPeriode = New System.Windows.Forms.Label()
    Me.GrpActions.SuspendLayout()
    CType(Me.GCStatEvolTech, System.ComponentModel.ISupportInitialize).BeginInit()
    CType(Me.GVStatEvolTech, System.ComponentModel.ISupportInitialize).BeginInit()
    Me.SuspendLayout()
    '
    'LblTitre
    '
    resources.ApplyResources(Me.LblTitre, "LblTitre")
    Me.LblTitre.Name = "LblTitre"
    '
    'GrpActions
    '
    resources.ApplyResources(Me.GrpActions, "GrpActions")
    Me.GrpActions.Controls.Add(Me.btnExport)
    Me.GrpActions.Controls.Add(Me.BtnFermer)
    Me.GrpActions.Controls.Add(Me.BtnPrint)
    Me.GrpActions.Name = "GrpActions"
    Me.GrpActions.TabStop = False
    '
    'btnExport
    '
    resources.ApplyResources(Me.btnExport, "btnExport")
    Me.btnExport.Name = "btnExport"
    Me.btnExport.UseVisualStyleBackColor = True
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
    'GCStatEvolTech
    '
    resources.ApplyResources(Me.GCStatEvolTech, "GCStatEvolTech")
    Me.GCStatEvolTech.EmbeddedNavigator.AccessibleDescription = resources.GetString("GCStatEvolTech.EmbeddedNavigator.AccessibleDescription")
    Me.GCStatEvolTech.EmbeddedNavigator.AccessibleName = resources.GetString("GCStatEvolTech.EmbeddedNavigator.AccessibleName")
    Me.GCStatEvolTech.EmbeddedNavigator.AllowHtmlTextInToolTip = CType(resources.GetObject("GCStatEvolTech.EmbeddedNavigator.AllowHtmlTextInToolTip"), DevExpress.Utils.DefaultBoolean)
    Me.GCStatEvolTech.EmbeddedNavigator.Anchor = CType(resources.GetObject("GCStatEvolTech.EmbeddedNavigator.Anchor"), System.Windows.Forms.AnchorStyles)
    Me.GCStatEvolTech.EmbeddedNavigator.BackgroundImage = CType(resources.GetObject("GCStatEvolTech.EmbeddedNavigator.BackgroundImage"), System.Drawing.Image)
    Me.GCStatEvolTech.EmbeddedNavigator.BackgroundImageLayout = CType(resources.GetObject("GCStatEvolTech.EmbeddedNavigator.BackgroundImageLayout"), System.Windows.Forms.ImageLayout)
    Me.GCStatEvolTech.EmbeddedNavigator.ImeMode = CType(resources.GetObject("GCStatEvolTech.EmbeddedNavigator.ImeMode"), System.Windows.Forms.ImeMode)
    Me.GCStatEvolTech.EmbeddedNavigator.MaximumSize = CType(resources.GetObject("GCStatEvolTech.EmbeddedNavigator.MaximumSize"), System.Drawing.Size)
    Me.GCStatEvolTech.EmbeddedNavigator.TextLocation = CType(resources.GetObject("GCStatEvolTech.EmbeddedNavigator.TextLocation"), DevExpress.XtraEditors.NavigatorButtonsTextLocation)
    Me.GCStatEvolTech.EmbeddedNavigator.ToolTip = resources.GetString("GCStatEvolTech.EmbeddedNavigator.ToolTip")
    Me.GCStatEvolTech.EmbeddedNavigator.ToolTipIconType = CType(resources.GetObject("GCStatEvolTech.EmbeddedNavigator.ToolTipIconType"), DevExpress.Utils.ToolTipIconType)
    Me.GCStatEvolTech.EmbeddedNavigator.ToolTipTitle = resources.GetString("GCStatEvolTech.EmbeddedNavigator.ToolTipTitle")
    Me.GCStatEvolTech.MainView = Me.GVStatEvolTech
    Me.GCStatEvolTech.Name = "GCStatEvolTech"
    Me.GCStatEvolTech.ViewCollection.AddRange(New DevExpress.XtraGrid.Views.Base.BaseView() {Me.GVStatEvolTech})
    '
    'GVStatEvolTech
    '
    Me.GVStatEvolTech.Appearance.ColumnFilterButton.BackColor = CType(resources.GetObject("GVStatEvolTech.Appearance.ColumnFilterButton.BackColor"), System.Drawing.Color)
    Me.GVStatEvolTech.Appearance.ColumnFilterButton.BorderColor = CType(resources.GetObject("GVStatEvolTech.Appearance.ColumnFilterButton.BorderColor"), System.Drawing.Color)
    Me.GVStatEvolTech.Appearance.ColumnFilterButton.FontSizeDelta = CType(resources.GetObject("GVStatEvolTech.Appearance.ColumnFilterButton.FontSizeDelta"), Integer)
    Me.GVStatEvolTech.Appearance.ColumnFilterButton.FontStyleDelta = CType(resources.GetObject("GVStatEvolTech.Appearance.ColumnFilterButton.FontStyleDelta"), System.Drawing.FontStyle)
    Me.GVStatEvolTech.Appearance.ColumnFilterButton.ForeColor = CType(resources.GetObject("GVStatEvolTech.Appearance.ColumnFilterButton.ForeColor"), System.Drawing.Color)
    Me.GVStatEvolTech.Appearance.ColumnFilterButton.GradientMode = CType(resources.GetObject("GVStatEvolTech.Appearance.ColumnFilterButton.GradientMode"), System.Drawing.Drawing2D.LinearGradientMode)
    Me.GVStatEvolTech.Appearance.ColumnFilterButton.Image = CType(resources.GetObject("GVStatEvolTech.Appearance.ColumnFilterButton.Image"), System.Drawing.Image)
    Me.GVStatEvolTech.Appearance.ColumnFilterButton.Options.UseBackColor = True
    Me.GVStatEvolTech.Appearance.ColumnFilterButton.Options.UseBorderColor = True
    Me.GVStatEvolTech.Appearance.ColumnFilterButton.Options.UseForeColor = True
    Me.GVStatEvolTech.Appearance.ColumnFilterButtonActive.BackColor = CType(resources.GetObject("GVStatEvolTech.Appearance.ColumnFilterButtonActive.BackColor"), System.Drawing.Color)
    Me.GVStatEvolTech.Appearance.ColumnFilterButtonActive.BorderColor = CType(resources.GetObject("GVStatEvolTech.Appearance.ColumnFilterButtonActive.BorderColor"), System.Drawing.Color)
    Me.GVStatEvolTech.Appearance.ColumnFilterButtonActive.FontSizeDelta = CType(resources.GetObject("GVStatEvolTech.Appearance.ColumnFilterButtonActive.FontSizeDelta"), Integer)
    Me.GVStatEvolTech.Appearance.ColumnFilterButtonActive.FontStyleDelta = CType(resources.GetObject("GVStatEvolTech.Appearance.ColumnFilterButtonActive.FontStyleDelta"), System.Drawing.FontStyle)
    Me.GVStatEvolTech.Appearance.ColumnFilterButtonActive.ForeColor = CType(resources.GetObject("GVStatEvolTech.Appearance.ColumnFilterButtonActive.ForeColor"), System.Drawing.Color)
    Me.GVStatEvolTech.Appearance.ColumnFilterButtonActive.GradientMode = CType(resources.GetObject("GVStatEvolTech.Appearance.ColumnFilterButtonActive.GradientMode"), System.Drawing.Drawing2D.LinearGradientMode)
    Me.GVStatEvolTech.Appearance.ColumnFilterButtonActive.Image = CType(resources.GetObject("GVStatEvolTech.Appearance.ColumnFilterButtonActive.Image"), System.Drawing.Image)
    Me.GVStatEvolTech.Appearance.ColumnFilterButtonActive.Options.UseBackColor = True
    Me.GVStatEvolTech.Appearance.ColumnFilterButtonActive.Options.UseBorderColor = True
    Me.GVStatEvolTech.Appearance.ColumnFilterButtonActive.Options.UseForeColor = True
    Me.GVStatEvolTech.Appearance.Empty.BackColor = CType(resources.GetObject("GVStatEvolTech.Appearance.Empty.BackColor"), System.Drawing.Color)
    Me.GVStatEvolTech.Appearance.Empty.BackColor2 = CType(resources.GetObject("GVStatEvolTech.Appearance.Empty.BackColor2"), System.Drawing.Color)
    Me.GVStatEvolTech.Appearance.Empty.FontSizeDelta = CType(resources.GetObject("GVStatEvolTech.Appearance.Empty.FontSizeDelta"), Integer)
    Me.GVStatEvolTech.Appearance.Empty.FontStyleDelta = CType(resources.GetObject("GVStatEvolTech.Appearance.Empty.FontStyleDelta"), System.Drawing.FontStyle)
    Me.GVStatEvolTech.Appearance.Empty.GradientMode = CType(resources.GetObject("GVStatEvolTech.Appearance.Empty.GradientMode"), System.Drawing.Drawing2D.LinearGradientMode)
    Me.GVStatEvolTech.Appearance.Empty.Image = CType(resources.GetObject("GVStatEvolTech.Appearance.Empty.Image"), System.Drawing.Image)
    Me.GVStatEvolTech.Appearance.Empty.Options.UseBackColor = True
    Me.GVStatEvolTech.Appearance.EvenRow.BackColor = CType(resources.GetObject("GVStatEvolTech.Appearance.EvenRow.BackColor"), System.Drawing.Color)
    Me.GVStatEvolTech.Appearance.EvenRow.BorderColor = CType(resources.GetObject("GVStatEvolTech.Appearance.EvenRow.BorderColor"), System.Drawing.Color)
    Me.GVStatEvolTech.Appearance.EvenRow.FontSizeDelta = CType(resources.GetObject("GVStatEvolTech.Appearance.EvenRow.FontSizeDelta"), Integer)
    Me.GVStatEvolTech.Appearance.EvenRow.FontStyleDelta = CType(resources.GetObject("GVStatEvolTech.Appearance.EvenRow.FontStyleDelta"), System.Drawing.FontStyle)
    Me.GVStatEvolTech.Appearance.EvenRow.ForeColor = CType(resources.GetObject("GVStatEvolTech.Appearance.EvenRow.ForeColor"), System.Drawing.Color)
    Me.GVStatEvolTech.Appearance.EvenRow.GradientMode = CType(resources.GetObject("GVStatEvolTech.Appearance.EvenRow.GradientMode"), System.Drawing.Drawing2D.LinearGradientMode)
    Me.GVStatEvolTech.Appearance.EvenRow.Image = CType(resources.GetObject("GVStatEvolTech.Appearance.EvenRow.Image"), System.Drawing.Image)
    Me.GVStatEvolTech.Appearance.EvenRow.Options.UseBackColor = True
    Me.GVStatEvolTech.Appearance.EvenRow.Options.UseBorderColor = True
    Me.GVStatEvolTech.Appearance.EvenRow.Options.UseForeColor = True
    Me.GVStatEvolTech.Appearance.FilterCloseButton.BackColor = CType(resources.GetObject("GVStatEvolTech.Appearance.FilterCloseButton.BackColor"), System.Drawing.Color)
    Me.GVStatEvolTech.Appearance.FilterCloseButton.BorderColor = CType(resources.GetObject("GVStatEvolTech.Appearance.FilterCloseButton.BorderColor"), System.Drawing.Color)
    Me.GVStatEvolTech.Appearance.FilterCloseButton.FontSizeDelta = CType(resources.GetObject("GVStatEvolTech.Appearance.FilterCloseButton.FontSizeDelta"), Integer)
    Me.GVStatEvolTech.Appearance.FilterCloseButton.FontStyleDelta = CType(resources.GetObject("GVStatEvolTech.Appearance.FilterCloseButton.FontStyleDelta"), System.Drawing.FontStyle)
    Me.GVStatEvolTech.Appearance.FilterCloseButton.ForeColor = CType(resources.GetObject("GVStatEvolTech.Appearance.FilterCloseButton.ForeColor"), System.Drawing.Color)
    Me.GVStatEvolTech.Appearance.FilterCloseButton.GradientMode = CType(resources.GetObject("GVStatEvolTech.Appearance.FilterCloseButton.GradientMode"), System.Drawing.Drawing2D.LinearGradientMode)
    Me.GVStatEvolTech.Appearance.FilterCloseButton.Image = CType(resources.GetObject("GVStatEvolTech.Appearance.FilterCloseButton.Image"), System.Drawing.Image)
    Me.GVStatEvolTech.Appearance.FilterCloseButton.Options.UseBackColor = True
    Me.GVStatEvolTech.Appearance.FilterCloseButton.Options.UseBorderColor = True
    Me.GVStatEvolTech.Appearance.FilterCloseButton.Options.UseForeColor = True
    Me.GVStatEvolTech.Appearance.FilterPanel.BackColor = CType(resources.GetObject("GVStatEvolTech.Appearance.FilterPanel.BackColor"), System.Drawing.Color)
    Me.GVStatEvolTech.Appearance.FilterPanel.BackColor2 = CType(resources.GetObject("GVStatEvolTech.Appearance.FilterPanel.BackColor2"), System.Drawing.Color)
    Me.GVStatEvolTech.Appearance.FilterPanel.FontSizeDelta = CType(resources.GetObject("GVStatEvolTech.Appearance.FilterPanel.FontSizeDelta"), Integer)
    Me.GVStatEvolTech.Appearance.FilterPanel.FontStyleDelta = CType(resources.GetObject("GVStatEvolTech.Appearance.FilterPanel.FontStyleDelta"), System.Drawing.FontStyle)
    Me.GVStatEvolTech.Appearance.FilterPanel.ForeColor = CType(resources.GetObject("GVStatEvolTech.Appearance.FilterPanel.ForeColor"), System.Drawing.Color)
    Me.GVStatEvolTech.Appearance.FilterPanel.GradientMode = CType(resources.GetObject("GVStatEvolTech.Appearance.FilterPanel.GradientMode"), System.Drawing.Drawing2D.LinearGradientMode)
    Me.GVStatEvolTech.Appearance.FilterPanel.Image = CType(resources.GetObject("GVStatEvolTech.Appearance.FilterPanel.Image"), System.Drawing.Image)
    Me.GVStatEvolTech.Appearance.FilterPanel.Options.UseBackColor = True
    Me.GVStatEvolTech.Appearance.FilterPanel.Options.UseForeColor = True
    Me.GVStatEvolTech.Appearance.FixedLine.BackColor = CType(resources.GetObject("GVStatEvolTech.Appearance.FixedLine.BackColor"), System.Drawing.Color)
    Me.GVStatEvolTech.Appearance.FixedLine.FontSizeDelta = CType(resources.GetObject("GVStatEvolTech.Appearance.FixedLine.FontSizeDelta"), Integer)
    Me.GVStatEvolTech.Appearance.FixedLine.FontStyleDelta = CType(resources.GetObject("GVStatEvolTech.Appearance.FixedLine.FontStyleDelta"), System.Drawing.FontStyle)
    Me.GVStatEvolTech.Appearance.FixedLine.GradientMode = CType(resources.GetObject("GVStatEvolTech.Appearance.FixedLine.GradientMode"), System.Drawing.Drawing2D.LinearGradientMode)
    Me.GVStatEvolTech.Appearance.FixedLine.Image = CType(resources.GetObject("GVStatEvolTech.Appearance.FixedLine.Image"), System.Drawing.Image)
    Me.GVStatEvolTech.Appearance.FixedLine.Options.UseBackColor = True
    Me.GVStatEvolTech.Appearance.FocusedCell.BackColor = CType(resources.GetObject("GVStatEvolTech.Appearance.FocusedCell.BackColor"), System.Drawing.Color)
    Me.GVStatEvolTech.Appearance.FocusedCell.FontSizeDelta = CType(resources.GetObject("GVStatEvolTech.Appearance.FocusedCell.FontSizeDelta"), Integer)
    Me.GVStatEvolTech.Appearance.FocusedCell.FontStyleDelta = CType(resources.GetObject("GVStatEvolTech.Appearance.FocusedCell.FontStyleDelta"), System.Drawing.FontStyle)
    Me.GVStatEvolTech.Appearance.FocusedCell.ForeColor = CType(resources.GetObject("GVStatEvolTech.Appearance.FocusedCell.ForeColor"), System.Drawing.Color)
    Me.GVStatEvolTech.Appearance.FocusedCell.GradientMode = CType(resources.GetObject("GVStatEvolTech.Appearance.FocusedCell.GradientMode"), System.Drawing.Drawing2D.LinearGradientMode)
    Me.GVStatEvolTech.Appearance.FocusedCell.Image = CType(resources.GetObject("GVStatEvolTech.Appearance.FocusedCell.Image"), System.Drawing.Image)
    Me.GVStatEvolTech.Appearance.FocusedCell.Options.UseBackColor = True
    Me.GVStatEvolTech.Appearance.FocusedCell.Options.UseForeColor = True
    Me.GVStatEvolTech.Appearance.FocusedRow.BackColor = CType(resources.GetObject("GVStatEvolTech.Appearance.FocusedRow.BackColor"), System.Drawing.Color)
    Me.GVStatEvolTech.Appearance.FocusedRow.FontSizeDelta = CType(resources.GetObject("GVStatEvolTech.Appearance.FocusedRow.FontSizeDelta"), Integer)
    Me.GVStatEvolTech.Appearance.FocusedRow.FontStyleDelta = CType(resources.GetObject("GVStatEvolTech.Appearance.FocusedRow.FontStyleDelta"), System.Drawing.FontStyle)
    Me.GVStatEvolTech.Appearance.FocusedRow.ForeColor = CType(resources.GetObject("GVStatEvolTech.Appearance.FocusedRow.ForeColor"), System.Drawing.Color)
    Me.GVStatEvolTech.Appearance.FocusedRow.GradientMode = CType(resources.GetObject("GVStatEvolTech.Appearance.FocusedRow.GradientMode"), System.Drawing.Drawing2D.LinearGradientMode)
    Me.GVStatEvolTech.Appearance.FocusedRow.Image = CType(resources.GetObject("GVStatEvolTech.Appearance.FocusedRow.Image"), System.Drawing.Image)
    Me.GVStatEvolTech.Appearance.FocusedRow.Options.UseBackColor = True
    Me.GVStatEvolTech.Appearance.FocusedRow.Options.UseForeColor = True
    Me.GVStatEvolTech.Appearance.FooterPanel.BackColor = CType(resources.GetObject("GVStatEvolTech.Appearance.FooterPanel.BackColor"), System.Drawing.Color)
    Me.GVStatEvolTech.Appearance.FooterPanel.BorderColor = CType(resources.GetObject("GVStatEvolTech.Appearance.FooterPanel.BorderColor"), System.Drawing.Color)
    Me.GVStatEvolTech.Appearance.FooterPanel.FontSizeDelta = CType(resources.GetObject("GVStatEvolTech.Appearance.FooterPanel.FontSizeDelta"), Integer)
    Me.GVStatEvolTech.Appearance.FooterPanel.FontStyleDelta = CType(resources.GetObject("GVStatEvolTech.Appearance.FooterPanel.FontStyleDelta"), System.Drawing.FontStyle)
    Me.GVStatEvolTech.Appearance.FooterPanel.ForeColor = CType(resources.GetObject("GVStatEvolTech.Appearance.FooterPanel.ForeColor"), System.Drawing.Color)
    Me.GVStatEvolTech.Appearance.FooterPanel.GradientMode = CType(resources.GetObject("GVStatEvolTech.Appearance.FooterPanel.GradientMode"), System.Drawing.Drawing2D.LinearGradientMode)
    Me.GVStatEvolTech.Appearance.FooterPanel.Image = CType(resources.GetObject("GVStatEvolTech.Appearance.FooterPanel.Image"), System.Drawing.Image)
    Me.GVStatEvolTech.Appearance.FooterPanel.Options.UseBackColor = True
    Me.GVStatEvolTech.Appearance.FooterPanel.Options.UseBorderColor = True
    Me.GVStatEvolTech.Appearance.FooterPanel.Options.UseForeColor = True
    Me.GVStatEvolTech.Appearance.GroupButton.BackColor = CType(resources.GetObject("GVStatEvolTech.Appearance.GroupButton.BackColor"), System.Drawing.Color)
    Me.GVStatEvolTech.Appearance.GroupButton.BorderColor = CType(resources.GetObject("GVStatEvolTech.Appearance.GroupButton.BorderColor"), System.Drawing.Color)
    Me.GVStatEvolTech.Appearance.GroupButton.FontSizeDelta = CType(resources.GetObject("GVStatEvolTech.Appearance.GroupButton.FontSizeDelta"), Integer)
    Me.GVStatEvolTech.Appearance.GroupButton.FontStyleDelta = CType(resources.GetObject("GVStatEvolTech.Appearance.GroupButton.FontStyleDelta"), System.Drawing.FontStyle)
    Me.GVStatEvolTech.Appearance.GroupButton.GradientMode = CType(resources.GetObject("GVStatEvolTech.Appearance.GroupButton.GradientMode"), System.Drawing.Drawing2D.LinearGradientMode)
    Me.GVStatEvolTech.Appearance.GroupButton.Image = CType(resources.GetObject("GVStatEvolTech.Appearance.GroupButton.Image"), System.Drawing.Image)
    Me.GVStatEvolTech.Appearance.GroupButton.Options.UseBackColor = True
    Me.GVStatEvolTech.Appearance.GroupButton.Options.UseBorderColor = True
    Me.GVStatEvolTech.Appearance.GroupFooter.BackColor = CType(resources.GetObject("GVStatEvolTech.Appearance.GroupFooter.BackColor"), System.Drawing.Color)
    Me.GVStatEvolTech.Appearance.GroupFooter.BorderColor = CType(resources.GetObject("GVStatEvolTech.Appearance.GroupFooter.BorderColor"), System.Drawing.Color)
    Me.GVStatEvolTech.Appearance.GroupFooter.FontSizeDelta = CType(resources.GetObject("GVStatEvolTech.Appearance.GroupFooter.FontSizeDelta"), Integer)
    Me.GVStatEvolTech.Appearance.GroupFooter.FontStyleDelta = CType(resources.GetObject("GVStatEvolTech.Appearance.GroupFooter.FontStyleDelta"), System.Drawing.FontStyle)
    Me.GVStatEvolTech.Appearance.GroupFooter.ForeColor = CType(resources.GetObject("GVStatEvolTech.Appearance.GroupFooter.ForeColor"), System.Drawing.Color)
    Me.GVStatEvolTech.Appearance.GroupFooter.GradientMode = CType(resources.GetObject("GVStatEvolTech.Appearance.GroupFooter.GradientMode"), System.Drawing.Drawing2D.LinearGradientMode)
    Me.GVStatEvolTech.Appearance.GroupFooter.Image = CType(resources.GetObject("GVStatEvolTech.Appearance.GroupFooter.Image"), System.Drawing.Image)
    Me.GVStatEvolTech.Appearance.GroupFooter.Options.UseBackColor = True
    Me.GVStatEvolTech.Appearance.GroupFooter.Options.UseBorderColor = True
    Me.GVStatEvolTech.Appearance.GroupFooter.Options.UseForeColor = True
    Me.GVStatEvolTech.Appearance.GroupPanel.BackColor = CType(resources.GetObject("GVStatEvolTech.Appearance.GroupPanel.BackColor"), System.Drawing.Color)
    Me.GVStatEvolTech.Appearance.GroupPanel.BackColor2 = CType(resources.GetObject("GVStatEvolTech.Appearance.GroupPanel.BackColor2"), System.Drawing.Color)
    Me.GVStatEvolTech.Appearance.GroupPanel.FontSizeDelta = CType(resources.GetObject("GVStatEvolTech.Appearance.GroupPanel.FontSizeDelta"), Integer)
    Me.GVStatEvolTech.Appearance.GroupPanel.FontStyleDelta = CType(resources.GetObject("GVStatEvolTech.Appearance.GroupPanel.FontStyleDelta"), System.Drawing.FontStyle)
    Me.GVStatEvolTech.Appearance.GroupPanel.ForeColor = CType(resources.GetObject("GVStatEvolTech.Appearance.GroupPanel.ForeColor"), System.Drawing.Color)
    Me.GVStatEvolTech.Appearance.GroupPanel.GradientMode = CType(resources.GetObject("GVStatEvolTech.Appearance.GroupPanel.GradientMode"), System.Drawing.Drawing2D.LinearGradientMode)
    Me.GVStatEvolTech.Appearance.GroupPanel.Image = CType(resources.GetObject("GVStatEvolTech.Appearance.GroupPanel.Image"), System.Drawing.Image)
    Me.GVStatEvolTech.Appearance.GroupPanel.Options.UseBackColor = True
    Me.GVStatEvolTech.Appearance.GroupPanel.Options.UseForeColor = True
    Me.GVStatEvolTech.Appearance.GroupRow.FontSizeDelta = CType(resources.GetObject("GVStatEvolTech.Appearance.GroupRow.FontSizeDelta"), Integer)
    Me.GVStatEvolTech.Appearance.GroupRow.FontStyleDelta = CType(resources.GetObject("GVStatEvolTech.Appearance.GroupRow.FontStyleDelta"), System.Drawing.FontStyle)
    Me.GVStatEvolTech.Appearance.GroupRow.ForeColor = CType(resources.GetObject("GVStatEvolTech.Appearance.GroupRow.ForeColor"), System.Drawing.Color)
    Me.GVStatEvolTech.Appearance.GroupRow.GradientMode = CType(resources.GetObject("GVStatEvolTech.Appearance.GroupRow.GradientMode"), System.Drawing.Drawing2D.LinearGradientMode)
    Me.GVStatEvolTech.Appearance.GroupRow.Image = CType(resources.GetObject("GVStatEvolTech.Appearance.GroupRow.Image"), System.Drawing.Image)
    Me.GVStatEvolTech.Appearance.GroupRow.Options.UseForeColor = True
    Me.GVStatEvolTech.Appearance.HeaderPanel.BackColor = CType(resources.GetObject("GVStatEvolTech.Appearance.HeaderPanel.BackColor"), System.Drawing.Color)
    Me.GVStatEvolTech.Appearance.HeaderPanel.BorderColor = CType(resources.GetObject("GVStatEvolTech.Appearance.HeaderPanel.BorderColor"), System.Drawing.Color)
    Me.GVStatEvolTech.Appearance.HeaderPanel.Font = CType(resources.GetObject("GVStatEvolTech.Appearance.HeaderPanel.Font"), System.Drawing.Font)
    Me.GVStatEvolTech.Appearance.HeaderPanel.FontSizeDelta = CType(resources.GetObject("GVStatEvolTech.Appearance.HeaderPanel.FontSizeDelta"), Integer)
    Me.GVStatEvolTech.Appearance.HeaderPanel.FontStyleDelta = CType(resources.GetObject("GVStatEvolTech.Appearance.HeaderPanel.FontStyleDelta"), System.Drawing.FontStyle)
    Me.GVStatEvolTech.Appearance.HeaderPanel.ForeColor = CType(resources.GetObject("GVStatEvolTech.Appearance.HeaderPanel.ForeColor"), System.Drawing.Color)
    Me.GVStatEvolTech.Appearance.HeaderPanel.GradientMode = CType(resources.GetObject("GVStatEvolTech.Appearance.HeaderPanel.GradientMode"), System.Drawing.Drawing2D.LinearGradientMode)
    Me.GVStatEvolTech.Appearance.HeaderPanel.Image = CType(resources.GetObject("GVStatEvolTech.Appearance.HeaderPanel.Image"), System.Drawing.Image)
    Me.GVStatEvolTech.Appearance.HeaderPanel.Options.UseBackColor = True
    Me.GVStatEvolTech.Appearance.HeaderPanel.Options.UseBorderColor = True
    Me.GVStatEvolTech.Appearance.HeaderPanel.Options.UseFont = True
    Me.GVStatEvolTech.Appearance.HeaderPanel.Options.UseForeColor = True
    Me.GVStatEvolTech.Appearance.HeaderPanel.Options.UseTextOptions = True
    Me.GVStatEvolTech.Appearance.HeaderPanel.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center
    Me.GVStatEvolTech.Appearance.HeaderPanel.TextOptions.VAlignment = DevExpress.Utils.VertAlignment.Center
    Me.GVStatEvolTech.Appearance.HeaderPanel.TextOptions.WordWrap = DevExpress.Utils.WordWrap.Wrap
    Me.GVStatEvolTech.Appearance.HideSelectionRow.BackColor = CType(resources.GetObject("GVStatEvolTech.Appearance.HideSelectionRow.BackColor"), System.Drawing.Color)
    Me.GVStatEvolTech.Appearance.HideSelectionRow.FontSizeDelta = CType(resources.GetObject("GVStatEvolTech.Appearance.HideSelectionRow.FontSizeDelta"), Integer)
    Me.GVStatEvolTech.Appearance.HideSelectionRow.FontStyleDelta = CType(resources.GetObject("GVStatEvolTech.Appearance.HideSelectionRow.FontStyleDelta"), System.Drawing.FontStyle)
    Me.GVStatEvolTech.Appearance.HideSelectionRow.ForeColor = CType(resources.GetObject("GVStatEvolTech.Appearance.HideSelectionRow.ForeColor"), System.Drawing.Color)
    Me.GVStatEvolTech.Appearance.HideSelectionRow.GradientMode = CType(resources.GetObject("GVStatEvolTech.Appearance.HideSelectionRow.GradientMode"), System.Drawing.Drawing2D.LinearGradientMode)
    Me.GVStatEvolTech.Appearance.HideSelectionRow.Image = CType(resources.GetObject("GVStatEvolTech.Appearance.HideSelectionRow.Image"), System.Drawing.Image)
    Me.GVStatEvolTech.Appearance.HideSelectionRow.Options.UseBackColor = True
    Me.GVStatEvolTech.Appearance.HideSelectionRow.Options.UseForeColor = True
    Me.GVStatEvolTech.Appearance.HorzLine.BackColor = CType(resources.GetObject("GVStatEvolTech.Appearance.HorzLine.BackColor"), System.Drawing.Color)
    Me.GVStatEvolTech.Appearance.HorzLine.BorderColor = CType(resources.GetObject("GVStatEvolTech.Appearance.HorzLine.BorderColor"), System.Drawing.Color)
    Me.GVStatEvolTech.Appearance.HorzLine.FontSizeDelta = CType(resources.GetObject("GVStatEvolTech.Appearance.HorzLine.FontSizeDelta"), Integer)
    Me.GVStatEvolTech.Appearance.HorzLine.FontStyleDelta = CType(resources.GetObject("GVStatEvolTech.Appearance.HorzLine.FontStyleDelta"), System.Drawing.FontStyle)
    Me.GVStatEvolTech.Appearance.HorzLine.GradientMode = CType(resources.GetObject("GVStatEvolTech.Appearance.HorzLine.GradientMode"), System.Drawing.Drawing2D.LinearGradientMode)
    Me.GVStatEvolTech.Appearance.HorzLine.Image = CType(resources.GetObject("GVStatEvolTech.Appearance.HorzLine.Image"), System.Drawing.Image)
    Me.GVStatEvolTech.Appearance.HorzLine.Options.UseBackColor = True
    Me.GVStatEvolTech.Appearance.HorzLine.Options.UseBorderColor = True
    Me.GVStatEvolTech.Appearance.OddRow.BackColor = CType(resources.GetObject("GVStatEvolTech.Appearance.OddRow.BackColor"), System.Drawing.Color)
    Me.GVStatEvolTech.Appearance.OddRow.BorderColor = CType(resources.GetObject("GVStatEvolTech.Appearance.OddRow.BorderColor"), System.Drawing.Color)
    Me.GVStatEvolTech.Appearance.OddRow.FontSizeDelta = CType(resources.GetObject("GVStatEvolTech.Appearance.OddRow.FontSizeDelta"), Integer)
    Me.GVStatEvolTech.Appearance.OddRow.FontStyleDelta = CType(resources.GetObject("GVStatEvolTech.Appearance.OddRow.FontStyleDelta"), System.Drawing.FontStyle)
    Me.GVStatEvolTech.Appearance.OddRow.ForeColor = CType(resources.GetObject("GVStatEvolTech.Appearance.OddRow.ForeColor"), System.Drawing.Color)
    Me.GVStatEvolTech.Appearance.OddRow.GradientMode = CType(resources.GetObject("GVStatEvolTech.Appearance.OddRow.GradientMode"), System.Drawing.Drawing2D.LinearGradientMode)
    Me.GVStatEvolTech.Appearance.OddRow.Image = CType(resources.GetObject("GVStatEvolTech.Appearance.OddRow.Image"), System.Drawing.Image)
    Me.GVStatEvolTech.Appearance.OddRow.Options.UseBackColor = True
    Me.GVStatEvolTech.Appearance.OddRow.Options.UseBorderColor = True
    Me.GVStatEvolTech.Appearance.OddRow.Options.UseForeColor = True
    Me.GVStatEvolTech.Appearance.Preview.BackColor = CType(resources.GetObject("GVStatEvolTech.Appearance.Preview.BackColor"), System.Drawing.Color)
    Me.GVStatEvolTech.Appearance.Preview.Font = CType(resources.GetObject("GVStatEvolTech.Appearance.Preview.Font"), System.Drawing.Font)
    Me.GVStatEvolTech.Appearance.Preview.FontSizeDelta = CType(resources.GetObject("GVStatEvolTech.Appearance.Preview.FontSizeDelta"), Integer)
    Me.GVStatEvolTech.Appearance.Preview.FontStyleDelta = CType(resources.GetObject("GVStatEvolTech.Appearance.Preview.FontStyleDelta"), System.Drawing.FontStyle)
    Me.GVStatEvolTech.Appearance.Preview.ForeColor = CType(resources.GetObject("GVStatEvolTech.Appearance.Preview.ForeColor"), System.Drawing.Color)
    Me.GVStatEvolTech.Appearance.Preview.GradientMode = CType(resources.GetObject("GVStatEvolTech.Appearance.Preview.GradientMode"), System.Drawing.Drawing2D.LinearGradientMode)
    Me.GVStatEvolTech.Appearance.Preview.Image = CType(resources.GetObject("GVStatEvolTech.Appearance.Preview.Image"), System.Drawing.Image)
    Me.GVStatEvolTech.Appearance.Preview.Options.UseBackColor = True
    Me.GVStatEvolTech.Appearance.Preview.Options.UseFont = True
    Me.GVStatEvolTech.Appearance.Preview.Options.UseForeColor = True
    Me.GVStatEvolTech.Appearance.Row.BackColor = CType(resources.GetObject("GVStatEvolTech.Appearance.Row.BackColor"), System.Drawing.Color)
    Me.GVStatEvolTech.Appearance.Row.FontSizeDelta = CType(resources.GetObject("GVStatEvolTech.Appearance.Row.FontSizeDelta"), Integer)
    Me.GVStatEvolTech.Appearance.Row.FontStyleDelta = CType(resources.GetObject("GVStatEvolTech.Appearance.Row.FontStyleDelta"), System.Drawing.FontStyle)
    Me.GVStatEvolTech.Appearance.Row.ForeColor = CType(resources.GetObject("GVStatEvolTech.Appearance.Row.ForeColor"), System.Drawing.Color)
    Me.GVStatEvolTech.Appearance.Row.GradientMode = CType(resources.GetObject("GVStatEvolTech.Appearance.Row.GradientMode"), System.Drawing.Drawing2D.LinearGradientMode)
    Me.GVStatEvolTech.Appearance.Row.Image = CType(resources.GetObject("GVStatEvolTech.Appearance.Row.Image"), System.Drawing.Image)
    Me.GVStatEvolTech.Appearance.Row.Options.UseBackColor = True
    Me.GVStatEvolTech.Appearance.Row.Options.UseForeColor = True
    Me.GVStatEvolTech.Appearance.RowSeparator.BackColor = CType(resources.GetObject("GVStatEvolTech.Appearance.RowSeparator.BackColor"), System.Drawing.Color)
    Me.GVStatEvolTech.Appearance.RowSeparator.BackColor2 = CType(resources.GetObject("GVStatEvolTech.Appearance.RowSeparator.BackColor2"), System.Drawing.Color)
    Me.GVStatEvolTech.Appearance.RowSeparator.FontSizeDelta = CType(resources.GetObject("GVStatEvolTech.Appearance.RowSeparator.FontSizeDelta"), Integer)
    Me.GVStatEvolTech.Appearance.RowSeparator.FontStyleDelta = CType(resources.GetObject("GVStatEvolTech.Appearance.RowSeparator.FontStyleDelta"), System.Drawing.FontStyle)
    Me.GVStatEvolTech.Appearance.RowSeparator.GradientMode = CType(resources.GetObject("GVStatEvolTech.Appearance.RowSeparator.GradientMode"), System.Drawing.Drawing2D.LinearGradientMode)
    Me.GVStatEvolTech.Appearance.RowSeparator.Image = CType(resources.GetObject("GVStatEvolTech.Appearance.RowSeparator.Image"), System.Drawing.Image)
    Me.GVStatEvolTech.Appearance.RowSeparator.Options.UseBackColor = True
    Me.GVStatEvolTech.Appearance.SelectedRow.BackColor = CType(resources.GetObject("GVStatEvolTech.Appearance.SelectedRow.BackColor"), System.Drawing.Color)
    Me.GVStatEvolTech.Appearance.SelectedRow.FontSizeDelta = CType(resources.GetObject("GVStatEvolTech.Appearance.SelectedRow.FontSizeDelta"), Integer)
    Me.GVStatEvolTech.Appearance.SelectedRow.FontStyleDelta = CType(resources.GetObject("GVStatEvolTech.Appearance.SelectedRow.FontStyleDelta"), System.Drawing.FontStyle)
    Me.GVStatEvolTech.Appearance.SelectedRow.ForeColor = CType(resources.GetObject("GVStatEvolTech.Appearance.SelectedRow.ForeColor"), System.Drawing.Color)
    Me.GVStatEvolTech.Appearance.SelectedRow.GradientMode = CType(resources.GetObject("GVStatEvolTech.Appearance.SelectedRow.GradientMode"), System.Drawing.Drawing2D.LinearGradientMode)
    Me.GVStatEvolTech.Appearance.SelectedRow.Image = CType(resources.GetObject("GVStatEvolTech.Appearance.SelectedRow.Image"), System.Drawing.Image)
    Me.GVStatEvolTech.Appearance.SelectedRow.Options.UseBackColor = True
    Me.GVStatEvolTech.Appearance.SelectedRow.Options.UseForeColor = True
    Me.GVStatEvolTech.Appearance.TopNewRow.BackColor = CType(resources.GetObject("GVStatEvolTech.Appearance.TopNewRow.BackColor"), System.Drawing.Color)
    Me.GVStatEvolTech.Appearance.TopNewRow.FontSizeDelta = CType(resources.GetObject("GVStatEvolTech.Appearance.TopNewRow.FontSizeDelta"), Integer)
    Me.GVStatEvolTech.Appearance.TopNewRow.FontStyleDelta = CType(resources.GetObject("GVStatEvolTech.Appearance.TopNewRow.FontStyleDelta"), System.Drawing.FontStyle)
    Me.GVStatEvolTech.Appearance.TopNewRow.GradientMode = CType(resources.GetObject("GVStatEvolTech.Appearance.TopNewRow.GradientMode"), System.Drawing.Drawing2D.LinearGradientMode)
    Me.GVStatEvolTech.Appearance.TopNewRow.Image = CType(resources.GetObject("GVStatEvolTech.Appearance.TopNewRow.Image"), System.Drawing.Image)
    Me.GVStatEvolTech.Appearance.TopNewRow.Options.UseBackColor = True
    Me.GVStatEvolTech.Appearance.VertLine.BackColor = CType(resources.GetObject("GVStatEvolTech.Appearance.VertLine.BackColor"), System.Drawing.Color)
    Me.GVStatEvolTech.Appearance.VertLine.BorderColor = CType(resources.GetObject("GVStatEvolTech.Appearance.VertLine.BorderColor"), System.Drawing.Color)
    Me.GVStatEvolTech.Appearance.VertLine.FontSizeDelta = CType(resources.GetObject("GVStatEvolTech.Appearance.VertLine.FontSizeDelta"), Integer)
    Me.GVStatEvolTech.Appearance.VertLine.FontStyleDelta = CType(resources.GetObject("GVStatEvolTech.Appearance.VertLine.FontStyleDelta"), System.Drawing.FontStyle)
    Me.GVStatEvolTech.Appearance.VertLine.GradientMode = CType(resources.GetObject("GVStatEvolTech.Appearance.VertLine.GradientMode"), System.Drawing.Drawing2D.LinearGradientMode)
    Me.GVStatEvolTech.Appearance.VertLine.Image = CType(resources.GetObject("GVStatEvolTech.Appearance.VertLine.Image"), System.Drawing.Image)
    Me.GVStatEvolTech.Appearance.VertLine.Options.UseBackColor = True
    Me.GVStatEvolTech.Appearance.VertLine.Options.UseBorderColor = True
    resources.ApplyResources(Me.GVStatEvolTech, "GVStatEvolTech")
    Me.GVStatEvolTech.Columns.AddRange(New DevExpress.XtraGrid.Columns.GridColumn() {Me.GCol_NPERNUM, Me.GCol_VPERNOM, Me.GCol_VNOMSTAT, Me.GCol_COL_1, Me.GCol_COL_2, Me.GCol_COL_3, Me.GCol_COL_4, Me.GCol_COL_5, Me.GCol_COL_6, Me.GCol_COL_7, Me.GCol_COL_8, Me.GCol_COL_9, Me.GCol_COL_10, Me.GCol_COL_11, Me.GCol_COL_12, Me.GCol_MOY})
    Me.GVStatEvolTech.GridControl = Me.GCStatEvolTech
    Me.GVStatEvolTech.Name = "GVStatEvolTech"
    Me.GVStatEvolTech.OptionsBehavior.Editable = False
    Me.GVStatEvolTech.OptionsBehavior.ReadOnly = True
    Me.GVStatEvolTech.OptionsView.EnableAppearanceEvenRow = True
    Me.GVStatEvolTech.OptionsView.EnableAppearanceOddRow = True
    Me.GVStatEvolTech.OptionsView.ShowAutoFilterRow = True
    Me.GVStatEvolTech.OptionsView.ShowFooter = True
    Me.GVStatEvolTech.OptionsView.ShowGroupPanel = False
    '
    'GCol_NPERNUM
    '
    resources.ApplyResources(Me.GCol_NPERNUM, "GCol_NPERNUM")
    Me.GCol_NPERNUM.FieldName = "NPERNUM"
    Me.GCol_NPERNUM.Name = "GCol_NPERNUM"
    '
    'GCol_VPERNOM
    '
    resources.ApplyResources(Me.GCol_VPERNOM, "GCol_VPERNOM")
    Me.GCol_VPERNOM.FieldName = "VPERNOM"
    Me.GCol_VPERNOM.Name = "GCol_VPERNOM"
    Me.GCol_VPERNOM.OptionsColumn.AllowEdit = False
    Me.GCol_VPERNOM.OptionsColumn.ReadOnly = True
    Me.GCol_VPERNOM.OptionsFilter.AutoFilterCondition = DevExpress.XtraGrid.Columns.AutoFilterCondition.Contains
    '
    'GCol_VNOMSTAT
    '
    resources.ApplyResources(Me.GCol_VNOMSTAT, "GCol_VNOMSTAT")
    Me.GCol_VNOMSTAT.FieldName = "VNOMSTAT"
    Me.GCol_VNOMSTAT.Name = "GCol_VNOMSTAT"
    Me.GCol_VNOMSTAT.OptionsColumn.AllowEdit = False
    Me.GCol_VNOMSTAT.OptionsColumn.ReadOnly = True
    Me.GCol_VNOMSTAT.OptionsFilter.AutoFilterCondition = DevExpress.XtraGrid.Columns.AutoFilterCondition.Contains
    '
    'GCol_COL_1
    '
    resources.ApplyResources(Me.GCol_COL_1, "GCol_COL_1")
    Me.GCol_COL_1.FieldName = "COL_1"
    Me.GCol_COL_1.Name = "GCol_COL_1"
    Me.GCol_COL_1.OptionsColumn.AllowEdit = False
    Me.GCol_COL_1.OptionsColumn.ReadOnly = True
    Me.GCol_COL_1.OptionsFilter.AutoFilterCondition = DevExpress.XtraGrid.Columns.AutoFilterCondition.Contains
    '
    'GCol_COL_2
    '
    resources.ApplyResources(Me.GCol_COL_2, "GCol_COL_2")
    Me.GCol_COL_2.FieldName = "COL_2"
    Me.GCol_COL_2.Name = "GCol_COL_2"
    Me.GCol_COL_2.OptionsColumn.AllowEdit = False
    Me.GCol_COL_2.OptionsColumn.ReadOnly = True
    Me.GCol_COL_2.OptionsFilter.AutoFilterCondition = DevExpress.XtraGrid.Columns.AutoFilterCondition.Contains
    '
    'GCol_COL_3
    '
    resources.ApplyResources(Me.GCol_COL_3, "GCol_COL_3")
    Me.GCol_COL_3.FieldName = "COL_3"
    Me.GCol_COL_3.Name = "GCol_COL_3"
    Me.GCol_COL_3.OptionsColumn.AllowEdit = False
    Me.GCol_COL_3.OptionsColumn.ReadOnly = True
    Me.GCol_COL_3.OptionsFilter.AutoFilterCondition = DevExpress.XtraGrid.Columns.AutoFilterCondition.Contains
    '
    'GCol_COL_4
    '
    resources.ApplyResources(Me.GCol_COL_4, "GCol_COL_4")
    Me.GCol_COL_4.FieldName = "COL_4"
    Me.GCol_COL_4.Name = "GCol_COL_4"
    Me.GCol_COL_4.OptionsColumn.AllowEdit = False
    Me.GCol_COL_4.OptionsColumn.ReadOnly = True
    Me.GCol_COL_4.OptionsFilter.AutoFilterCondition = DevExpress.XtraGrid.Columns.AutoFilterCondition.Contains
    '
    'GCol_COL_5
    '
    resources.ApplyResources(Me.GCol_COL_5, "GCol_COL_5")
    Me.GCol_COL_5.FieldName = "COL_5"
    Me.GCol_COL_5.Name = "GCol_COL_5"
    Me.GCol_COL_5.OptionsColumn.AllowEdit = False
    Me.GCol_COL_5.OptionsColumn.ReadOnly = True
    Me.GCol_COL_5.OptionsFilter.AutoFilterCondition = DevExpress.XtraGrid.Columns.AutoFilterCondition.Contains
    '
    'GCol_COL_6
    '
    resources.ApplyResources(Me.GCol_COL_6, "GCol_COL_6")
    Me.GCol_COL_6.FieldName = "COL_6"
    Me.GCol_COL_6.Name = "GCol_COL_6"
    Me.GCol_COL_6.OptionsColumn.AllowEdit = False
    Me.GCol_COL_6.OptionsColumn.ReadOnly = True
    Me.GCol_COL_6.OptionsFilter.AutoFilterCondition = DevExpress.XtraGrid.Columns.AutoFilterCondition.Contains
    '
    'GCol_COL_7
    '
    resources.ApplyResources(Me.GCol_COL_7, "GCol_COL_7")
    Me.GCol_COL_7.FieldName = "COL_7"
    Me.GCol_COL_7.Name = "GCol_COL_7"
    Me.GCol_COL_7.OptionsColumn.AllowEdit = False
    Me.GCol_COL_7.OptionsColumn.ReadOnly = True
    Me.GCol_COL_7.OptionsFilter.AutoFilterCondition = DevExpress.XtraGrid.Columns.AutoFilterCondition.Contains
    '
    'GCol_COL_8
    '
    resources.ApplyResources(Me.GCol_COL_8, "GCol_COL_8")
    Me.GCol_COL_8.FieldName = "COL_8"
    Me.GCol_COL_8.Name = "GCol_COL_8"
    Me.GCol_COL_8.OptionsColumn.AllowEdit = False
    Me.GCol_COL_8.OptionsColumn.ReadOnly = True
    Me.GCol_COL_8.OptionsFilter.AutoFilterCondition = DevExpress.XtraGrid.Columns.AutoFilterCondition.Contains
    '
    'GCol_COL_9
    '
    resources.ApplyResources(Me.GCol_COL_9, "GCol_COL_9")
    Me.GCol_COL_9.FieldName = "COL_9"
    Me.GCol_COL_9.Name = "GCol_COL_9"
    Me.GCol_COL_9.OptionsColumn.AllowEdit = False
    Me.GCol_COL_9.OptionsColumn.ReadOnly = True
    Me.GCol_COL_9.OptionsFilter.AutoFilterCondition = DevExpress.XtraGrid.Columns.AutoFilterCondition.Contains
    '
    'GCol_COL_10
    '
    resources.ApplyResources(Me.GCol_COL_10, "GCol_COL_10")
    Me.GCol_COL_10.FieldName = "COL_10"
    Me.GCol_COL_10.Name = "GCol_COL_10"
    Me.GCol_COL_10.OptionsColumn.AllowEdit = False
    Me.GCol_COL_10.OptionsColumn.ReadOnly = True
    Me.GCol_COL_10.OptionsFilter.AutoFilterCondition = DevExpress.XtraGrid.Columns.AutoFilterCondition.Contains
    '
    'GCol_COL_11
    '
    resources.ApplyResources(Me.GCol_COL_11, "GCol_COL_11")
    Me.GCol_COL_11.FieldName = "COL_11"
    Me.GCol_COL_11.Name = "GCol_COL_11"
    Me.GCol_COL_11.OptionsColumn.AllowEdit = False
    Me.GCol_COL_11.OptionsColumn.ReadOnly = True
    Me.GCol_COL_11.OptionsFilter.AutoFilterCondition = DevExpress.XtraGrid.Columns.AutoFilterCondition.Contains
    '
    'GCol_COL_12
    '
    resources.ApplyResources(Me.GCol_COL_12, "GCol_COL_12")
    Me.GCol_COL_12.FieldName = "COL_12"
    Me.GCol_COL_12.Name = "GCol_COL_12"
    Me.GCol_COL_12.OptionsColumn.AllowEdit = False
    Me.GCol_COL_12.OptionsColumn.ReadOnly = True
    Me.GCol_COL_12.OptionsFilter.AutoFilterCondition = DevExpress.XtraGrid.Columns.AutoFilterCondition.Contains
    '
    'GCol_MOY
    '
    resources.ApplyResources(Me.GCol_MOY, "GCol_MOY")
    Me.GCol_MOY.FieldName = "MOY"
    Me.GCol_MOY.Name = "GCol_MOY"
    Me.GCol_MOY.OptionsColumn.AllowEdit = False
    Me.GCol_MOY.OptionsColumn.ReadOnly = True
    Me.GCol_MOY.OptionsFilter.AutoFilterCondition = DevExpress.XtraGrid.Columns.AutoFilterCondition.Contains
    '
    'LblPeriode
    '
    resources.ApplyResources(Me.LblPeriode, "LblPeriode")
    Me.LblPeriode.Name = "LblPeriode"
    '
    'frmStatTechEvolIndic
    '
    resources.ApplyResources(Me, "$this")
    Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
    Me.BackColor = System.Drawing.Color.Wheat
    Me.Controls.Add(Me.LblPeriode)
    Me.Controls.Add(Me.GCStatEvolTech)
    Me.Controls.Add(Me.LblTitre)
    Me.Controls.Add(Me.GrpActions)
    Me.Name = "frmStatTechEvolIndic"
    Me.WindowState = System.Windows.Forms.FormWindowState.Maximized
    Me.GrpActions.ResumeLayout(False)
    CType(Me.GCStatEvolTech, System.ComponentModel.ISupportInitialize).EndInit()
    CType(Me.GVStatEvolTech, System.ComponentModel.ISupportInitialize).EndInit()
    Me.ResumeLayout(False)
    Me.PerformLayout()

  End Sub

  Friend WithEvents LblTitre As Label
    Friend WithEvents GrpActions As GroupBox
    Friend WithEvents BtnFermer As Button
    Friend WithEvents BtnPrint As Button
    Private WithEvents GCStatEvolTech As DevExpress.XtraGrid.GridControl
    Private WithEvents GVStatEvolTech As DevExpress.XtraGrid.Views.Grid.GridView
    Friend WithEvents LblPeriode As Label
    Friend WithEvents GCol_NPERNUM As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents GCol_VPERNOM As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents GCol_VNOMSTAT As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents GCol_COL_1 As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents GCol_COL_2 As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents GCol_COL_3 As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents GCol_COL_4 As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents GCol_COL_5 As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents GCol_COL_6 As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents GCol_COL_7 As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents GCol_COL_8 As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents GCol_COL_9 As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents GCol_COL_10 As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents GCol_COL_11 As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents GCol_COL_12 As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents GCol_MOY As DevExpress.XtraGrid.Columns.GridColumn
  Friend WithEvents btnExport As Button
End Class
