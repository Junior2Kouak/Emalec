<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class FrmDecoupChantier
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(FrmDecoupChantier))
        Me.GrpActions = New System.Windows.Forms.GroupBox()
        Me.BtnFermer = New System.Windows.Forms.Button()
        Me.LblTitre = New System.Windows.Forms.Label()
        Me.GrpPresentDevis = New System.Windows.Forms.GroupBox()
        Me.BtnExportDevisXLS = New System.Windows.Forms.Button()
        Me.GCDEVIS = New DevExpress.XtraGrid.GridControl()
        Me.GVDEVIS = New DevExpress.XtraGrid.Views.Grid.GridView()
        Me.ColDEVISVLIB = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.ColDEVISMO = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.ColDEVISFOU = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.ColDEVISDEBOURSE = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.GrpSeriePrest = New System.Windows.Forms.GroupBox()
        Me.BtnExportSerieXLS = New System.Windows.Forms.Button()
        Me.GCSERIE = New DevExpress.XtraGrid.GridControl()
        Me.GVSERIE = New DevExpress.XtraGrid.Views.Grid.GridView()
        Me.ColSERIEVLIB = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.ColSERIEMO = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.ColSERIEFOU = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.ColSERIEDEBOURSE = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.SFD = New System.Windows.Forms.SaveFileDialog()
        Me.GrpBoxDecoupMO = New System.Windows.Forms.GroupBox()
        Me.BtnExportDecoupMOXLS = New System.Windows.Forms.Button()
        Me.GCDECOUPMO = New DevExpress.XtraGrid.GridControl()
        Me.GVDECOUPMO = New DevExpress.XtraGrid.Views.Grid.GridView()
        Me.ColMOVLIBDECOUPMO = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.ColMONBMO = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.ColMOMTTFO = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.ColMOMTTSTT = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.GrpBoxDecoupFO = New System.Windows.Forms.GroupBox()
        Me.BtnExportDecoupFOXLS = New System.Windows.Forms.Button()
        Me.GCDECOUPFO = New DevExpress.XtraGrid.GridControl()
        Me.GVDECOUPFO = New DevExpress.XtraGrid.Views.Grid.GridView()
        Me.ColMOVLIBDECOUPFO = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.ColFONBMO = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.ColFOMTTFO = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.ColFOMTTSTT = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.GrpBoxDecoupSTT = New System.Windows.Forms.GroupBox()
        Me.BtnExportDecoupSTTXLS = New System.Windows.Forms.Button()
        Me.GCDECOUPSTT = New DevExpress.XtraGrid.GridControl()
        Me.GVDECOUPSTT = New DevExpress.XtraGrid.Views.Grid.GridView()
        Me.ColSTTVLIBDECOUPSTT = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.ColSTTNBMO = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.ColSTTMTTFO = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.ColSTTMTTSTT = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.GrpActions.SuspendLayout()
        Me.GrpPresentDevis.SuspendLayout()
        CType(Me.GCDEVIS, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.GVDEVIS, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.GrpSeriePrest.SuspendLayout()
        CType(Me.GCSERIE, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.GVSERIE, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.GrpBoxDecoupMO.SuspendLayout()
        CType(Me.GCDECOUPMO, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.GVDECOUPMO, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.GrpBoxDecoupFO.SuspendLayout()
        CType(Me.GCDECOUPFO, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.GVDECOUPFO, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.GrpBoxDecoupSTT.SuspendLayout()
        CType(Me.GCDECOUPSTT, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.GVDECOUPSTT, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'GrpActions
        '
        resources.ApplyResources(Me.GrpActions, "GrpActions")
        Me.GrpActions.Controls.Add(Me.BtnFermer)
        Me.GrpActions.Name = "GrpActions"
        Me.GrpActions.TabStop = False
        '
        'BtnFermer
        '
        resources.ApplyResources(Me.BtnFermer, "BtnFermer")
        Me.BtnFermer.Name = "BtnFermer"
        Me.BtnFermer.UseVisualStyleBackColor = True
        '
        'LblTitre
        '
        resources.ApplyResources(Me.LblTitre, "LblTitre")
        Me.LblTitre.Name = "LblTitre"
        '
        'GrpPresentDevis
        '
        resources.ApplyResources(Me.GrpPresentDevis, "GrpPresentDevis")
        Me.GrpPresentDevis.Controls.Add(Me.BtnExportDevisXLS)
        Me.GrpPresentDevis.Controls.Add(Me.GCDEVIS)
        Me.GrpPresentDevis.Name = "GrpPresentDevis"
        Me.GrpPresentDevis.TabStop = False
        '
        'BtnExportDevisXLS
        '
        resources.ApplyResources(Me.BtnExportDevisXLS, "BtnExportDevisXLS")
        Me.BtnExportDevisXLS.Name = "BtnExportDevisXLS"
        Me.BtnExportDevisXLS.UseVisualStyleBackColor = True
        '
        'GCDEVIS
        '
        resources.ApplyResources(Me.GCDEVIS, "GCDEVIS")
        '
        '
        '
        Me.GCDEVIS.EmbeddedNavigator.AccessibleDescription = resources.GetString("GCDEVIS.EmbeddedNavigator.AccessibleDescription")
        Me.GCDEVIS.EmbeddedNavigator.AccessibleName = resources.GetString("GCDEVIS.EmbeddedNavigator.AccessibleName")
        Me.GCDEVIS.EmbeddedNavigator.AllowHtmlTextInToolTip = CType(resources.GetObject("GCDEVIS.EmbeddedNavigator.AllowHtmlTextInToolTip"), DevExpress.Utils.DefaultBoolean)
        Me.GCDEVIS.EmbeddedNavigator.Anchor = CType(resources.GetObject("GCDEVIS.EmbeddedNavigator.Anchor"), System.Windows.Forms.AnchorStyles)
        Me.GCDEVIS.EmbeddedNavigator.BackgroundImage = CType(resources.GetObject("GCDEVIS.EmbeddedNavigator.BackgroundImage"), System.Drawing.Image)
        Me.GCDEVIS.EmbeddedNavigator.BackgroundImageLayout = CType(resources.GetObject("GCDEVIS.EmbeddedNavigator.BackgroundImageLayout"), System.Windows.Forms.ImageLayout)
        Me.GCDEVIS.EmbeddedNavigator.ImeMode = CType(resources.GetObject("GCDEVIS.EmbeddedNavigator.ImeMode"), System.Windows.Forms.ImeMode)
        Me.GCDEVIS.EmbeddedNavigator.MaximumSize = CType(resources.GetObject("GCDEVIS.EmbeddedNavigator.MaximumSize"), System.Drawing.Size)
        Me.GCDEVIS.EmbeddedNavigator.TextLocation = CType(resources.GetObject("GCDEVIS.EmbeddedNavigator.TextLocation"), DevExpress.XtraEditors.NavigatorButtonsTextLocation)
        Me.GCDEVIS.EmbeddedNavigator.ToolTip = resources.GetString("GCDEVIS.EmbeddedNavigator.ToolTip")
        Me.GCDEVIS.EmbeddedNavigator.ToolTipIconType = CType(resources.GetObject("GCDEVIS.EmbeddedNavigator.ToolTipIconType"), DevExpress.Utils.ToolTipIconType)
        Me.GCDEVIS.EmbeddedNavigator.ToolTipTitle = resources.GetString("GCDEVIS.EmbeddedNavigator.ToolTipTitle")
        Me.GCDEVIS.MainView = Me.GVDEVIS
        Me.GCDEVIS.Name = "GCDEVIS"
        Me.GCDEVIS.ViewCollection.AddRange(New DevExpress.XtraGrid.Views.Base.BaseView() {Me.GVDEVIS})
        '
        'GVDEVIS
        '
        Me.GVDEVIS.Appearance.ColumnFilterButton.BackColor = CType(resources.GetObject("GVDEVIS.Appearance.ColumnFilterButton.BackColor"), System.Drawing.Color)
        Me.GVDEVIS.Appearance.ColumnFilterButton.BorderColor = CType(resources.GetObject("GVDEVIS.Appearance.ColumnFilterButton.BorderColor"), System.Drawing.Color)
        Me.GVDEVIS.Appearance.ColumnFilterButton.FontSizeDelta = CType(resources.GetObject("GVDEVIS.Appearance.ColumnFilterButton.FontSizeDelta"), Integer)
        Me.GVDEVIS.Appearance.ColumnFilterButton.FontStyleDelta = CType(resources.GetObject("GVDEVIS.Appearance.ColumnFilterButton.FontStyleDelta"), System.Drawing.FontStyle)
        Me.GVDEVIS.Appearance.ColumnFilterButton.ForeColor = CType(resources.GetObject("GVDEVIS.Appearance.ColumnFilterButton.ForeColor"), System.Drawing.Color)
        Me.GVDEVIS.Appearance.ColumnFilterButton.GradientMode = CType(resources.GetObject("GVDEVIS.Appearance.ColumnFilterButton.GradientMode"), System.Drawing.Drawing2D.LinearGradientMode)
        Me.GVDEVIS.Appearance.ColumnFilterButton.Image = CType(resources.GetObject("GVDEVIS.Appearance.ColumnFilterButton.Image"), System.Drawing.Image)
        Me.GVDEVIS.Appearance.ColumnFilterButton.Options.UseBackColor = True
        Me.GVDEVIS.Appearance.ColumnFilterButton.Options.UseBorderColor = True
        Me.GVDEVIS.Appearance.ColumnFilterButton.Options.UseForeColor = True
        Me.GVDEVIS.Appearance.ColumnFilterButtonActive.BackColor = CType(resources.GetObject("GVDEVIS.Appearance.ColumnFilterButtonActive.BackColor"), System.Drawing.Color)
        Me.GVDEVIS.Appearance.ColumnFilterButtonActive.BorderColor = CType(resources.GetObject("GVDEVIS.Appearance.ColumnFilterButtonActive.BorderColor"), System.Drawing.Color)
        Me.GVDEVIS.Appearance.ColumnFilterButtonActive.FontSizeDelta = CType(resources.GetObject("GVDEVIS.Appearance.ColumnFilterButtonActive.FontSizeDelta"), Integer)
        Me.GVDEVIS.Appearance.ColumnFilterButtonActive.FontStyleDelta = CType(resources.GetObject("GVDEVIS.Appearance.ColumnFilterButtonActive.FontStyleDelta"), System.Drawing.FontStyle)
        Me.GVDEVIS.Appearance.ColumnFilterButtonActive.ForeColor = CType(resources.GetObject("GVDEVIS.Appearance.ColumnFilterButtonActive.ForeColor"), System.Drawing.Color)
        Me.GVDEVIS.Appearance.ColumnFilterButtonActive.GradientMode = CType(resources.GetObject("GVDEVIS.Appearance.ColumnFilterButtonActive.GradientMode"), System.Drawing.Drawing2D.LinearGradientMode)
        Me.GVDEVIS.Appearance.ColumnFilterButtonActive.Image = CType(resources.GetObject("GVDEVIS.Appearance.ColumnFilterButtonActive.Image"), System.Drawing.Image)
        Me.GVDEVIS.Appearance.ColumnFilterButtonActive.Options.UseBackColor = True
        Me.GVDEVIS.Appearance.ColumnFilterButtonActive.Options.UseBorderColor = True
        Me.GVDEVIS.Appearance.ColumnFilterButtonActive.Options.UseForeColor = True
        Me.GVDEVIS.Appearance.Empty.BackColor = CType(resources.GetObject("GVDEVIS.Appearance.Empty.BackColor"), System.Drawing.Color)
        Me.GVDEVIS.Appearance.Empty.BackColor2 = CType(resources.GetObject("GVDEVIS.Appearance.Empty.BackColor2"), System.Drawing.Color)
        Me.GVDEVIS.Appearance.Empty.FontSizeDelta = CType(resources.GetObject("GVDEVIS.Appearance.Empty.FontSizeDelta"), Integer)
        Me.GVDEVIS.Appearance.Empty.FontStyleDelta = CType(resources.GetObject("GVDEVIS.Appearance.Empty.FontStyleDelta"), System.Drawing.FontStyle)
        Me.GVDEVIS.Appearance.Empty.GradientMode = CType(resources.GetObject("GVDEVIS.Appearance.Empty.GradientMode"), System.Drawing.Drawing2D.LinearGradientMode)
        Me.GVDEVIS.Appearance.Empty.Image = CType(resources.GetObject("GVDEVIS.Appearance.Empty.Image"), System.Drawing.Image)
        Me.GVDEVIS.Appearance.Empty.Options.UseBackColor = True
        Me.GVDEVIS.Appearance.EvenRow.BackColor = CType(resources.GetObject("GVDEVIS.Appearance.EvenRow.BackColor"), System.Drawing.Color)
        Me.GVDEVIS.Appearance.EvenRow.BorderColor = CType(resources.GetObject("GVDEVIS.Appearance.EvenRow.BorderColor"), System.Drawing.Color)
        Me.GVDEVIS.Appearance.EvenRow.FontSizeDelta = CType(resources.GetObject("GVDEVIS.Appearance.EvenRow.FontSizeDelta"), Integer)
        Me.GVDEVIS.Appearance.EvenRow.FontStyleDelta = CType(resources.GetObject("GVDEVIS.Appearance.EvenRow.FontStyleDelta"), System.Drawing.FontStyle)
        Me.GVDEVIS.Appearance.EvenRow.ForeColor = CType(resources.GetObject("GVDEVIS.Appearance.EvenRow.ForeColor"), System.Drawing.Color)
        Me.GVDEVIS.Appearance.EvenRow.GradientMode = CType(resources.GetObject("GVDEVIS.Appearance.EvenRow.GradientMode"), System.Drawing.Drawing2D.LinearGradientMode)
        Me.GVDEVIS.Appearance.EvenRow.Image = CType(resources.GetObject("GVDEVIS.Appearance.EvenRow.Image"), System.Drawing.Image)
        Me.GVDEVIS.Appearance.EvenRow.Options.UseBackColor = True
        Me.GVDEVIS.Appearance.EvenRow.Options.UseBorderColor = True
        Me.GVDEVIS.Appearance.EvenRow.Options.UseForeColor = True
        Me.GVDEVIS.Appearance.FilterCloseButton.BackColor = CType(resources.GetObject("GVDEVIS.Appearance.FilterCloseButton.BackColor"), System.Drawing.Color)
        Me.GVDEVIS.Appearance.FilterCloseButton.BorderColor = CType(resources.GetObject("GVDEVIS.Appearance.FilterCloseButton.BorderColor"), System.Drawing.Color)
        Me.GVDEVIS.Appearance.FilterCloseButton.FontSizeDelta = CType(resources.GetObject("GVDEVIS.Appearance.FilterCloseButton.FontSizeDelta"), Integer)
        Me.GVDEVIS.Appearance.FilterCloseButton.FontStyleDelta = CType(resources.GetObject("GVDEVIS.Appearance.FilterCloseButton.FontStyleDelta"), System.Drawing.FontStyle)
        Me.GVDEVIS.Appearance.FilterCloseButton.ForeColor = CType(resources.GetObject("GVDEVIS.Appearance.FilterCloseButton.ForeColor"), System.Drawing.Color)
        Me.GVDEVIS.Appearance.FilterCloseButton.GradientMode = CType(resources.GetObject("GVDEVIS.Appearance.FilterCloseButton.GradientMode"), System.Drawing.Drawing2D.LinearGradientMode)
        Me.GVDEVIS.Appearance.FilterCloseButton.Image = CType(resources.GetObject("GVDEVIS.Appearance.FilterCloseButton.Image"), System.Drawing.Image)
        Me.GVDEVIS.Appearance.FilterCloseButton.Options.UseBackColor = True
        Me.GVDEVIS.Appearance.FilterCloseButton.Options.UseBorderColor = True
        Me.GVDEVIS.Appearance.FilterCloseButton.Options.UseForeColor = True
        Me.GVDEVIS.Appearance.FilterPanel.BackColor = CType(resources.GetObject("GVDEVIS.Appearance.FilterPanel.BackColor"), System.Drawing.Color)
        Me.GVDEVIS.Appearance.FilterPanel.BackColor2 = CType(resources.GetObject("GVDEVIS.Appearance.FilterPanel.BackColor2"), System.Drawing.Color)
        Me.GVDEVIS.Appearance.FilterPanel.FontSizeDelta = CType(resources.GetObject("GVDEVIS.Appearance.FilterPanel.FontSizeDelta"), Integer)
        Me.GVDEVIS.Appearance.FilterPanel.FontStyleDelta = CType(resources.GetObject("GVDEVIS.Appearance.FilterPanel.FontStyleDelta"), System.Drawing.FontStyle)
        Me.GVDEVIS.Appearance.FilterPanel.ForeColor = CType(resources.GetObject("GVDEVIS.Appearance.FilterPanel.ForeColor"), System.Drawing.Color)
        Me.GVDEVIS.Appearance.FilterPanel.GradientMode = CType(resources.GetObject("GVDEVIS.Appearance.FilterPanel.GradientMode"), System.Drawing.Drawing2D.LinearGradientMode)
        Me.GVDEVIS.Appearance.FilterPanel.Image = CType(resources.GetObject("GVDEVIS.Appearance.FilterPanel.Image"), System.Drawing.Image)
        Me.GVDEVIS.Appearance.FilterPanel.Options.UseBackColor = True
        Me.GVDEVIS.Appearance.FilterPanel.Options.UseForeColor = True
        Me.GVDEVIS.Appearance.FixedLine.BackColor = CType(resources.GetObject("GVDEVIS.Appearance.FixedLine.BackColor"), System.Drawing.Color)
        Me.GVDEVIS.Appearance.FixedLine.FontSizeDelta = CType(resources.GetObject("GVDEVIS.Appearance.FixedLine.FontSizeDelta"), Integer)
        Me.GVDEVIS.Appearance.FixedLine.FontStyleDelta = CType(resources.GetObject("GVDEVIS.Appearance.FixedLine.FontStyleDelta"), System.Drawing.FontStyle)
        Me.GVDEVIS.Appearance.FixedLine.GradientMode = CType(resources.GetObject("GVDEVIS.Appearance.FixedLine.GradientMode"), System.Drawing.Drawing2D.LinearGradientMode)
        Me.GVDEVIS.Appearance.FixedLine.Image = CType(resources.GetObject("GVDEVIS.Appearance.FixedLine.Image"), System.Drawing.Image)
        Me.GVDEVIS.Appearance.FixedLine.Options.UseBackColor = True
        Me.GVDEVIS.Appearance.FocusedCell.BackColor = CType(resources.GetObject("GVDEVIS.Appearance.FocusedCell.BackColor"), System.Drawing.Color)
        Me.GVDEVIS.Appearance.FocusedCell.FontSizeDelta = CType(resources.GetObject("GVDEVIS.Appearance.FocusedCell.FontSizeDelta"), Integer)
        Me.GVDEVIS.Appearance.FocusedCell.FontStyleDelta = CType(resources.GetObject("GVDEVIS.Appearance.FocusedCell.FontStyleDelta"), System.Drawing.FontStyle)
        Me.GVDEVIS.Appearance.FocusedCell.ForeColor = CType(resources.GetObject("GVDEVIS.Appearance.FocusedCell.ForeColor"), System.Drawing.Color)
        Me.GVDEVIS.Appearance.FocusedCell.GradientMode = CType(resources.GetObject("GVDEVIS.Appearance.FocusedCell.GradientMode"), System.Drawing.Drawing2D.LinearGradientMode)
        Me.GVDEVIS.Appearance.FocusedCell.Image = CType(resources.GetObject("GVDEVIS.Appearance.FocusedCell.Image"), System.Drawing.Image)
        Me.GVDEVIS.Appearance.FocusedCell.Options.UseBackColor = True
        Me.GVDEVIS.Appearance.FocusedCell.Options.UseForeColor = True
        Me.GVDEVIS.Appearance.FocusedRow.BackColor = CType(resources.GetObject("GVDEVIS.Appearance.FocusedRow.BackColor"), System.Drawing.Color)
        Me.GVDEVIS.Appearance.FocusedRow.FontSizeDelta = CType(resources.GetObject("GVDEVIS.Appearance.FocusedRow.FontSizeDelta"), Integer)
        Me.GVDEVIS.Appearance.FocusedRow.FontStyleDelta = CType(resources.GetObject("GVDEVIS.Appearance.FocusedRow.FontStyleDelta"), System.Drawing.FontStyle)
        Me.GVDEVIS.Appearance.FocusedRow.ForeColor = CType(resources.GetObject("GVDEVIS.Appearance.FocusedRow.ForeColor"), System.Drawing.Color)
        Me.GVDEVIS.Appearance.FocusedRow.GradientMode = CType(resources.GetObject("GVDEVIS.Appearance.FocusedRow.GradientMode"), System.Drawing.Drawing2D.LinearGradientMode)
        Me.GVDEVIS.Appearance.FocusedRow.Image = CType(resources.GetObject("GVDEVIS.Appearance.FocusedRow.Image"), System.Drawing.Image)
        Me.GVDEVIS.Appearance.FocusedRow.Options.UseBackColor = True
        Me.GVDEVIS.Appearance.FocusedRow.Options.UseForeColor = True
        Me.GVDEVIS.Appearance.FooterPanel.BackColor = CType(resources.GetObject("GVDEVIS.Appearance.FooterPanel.BackColor"), System.Drawing.Color)
        Me.GVDEVIS.Appearance.FooterPanel.BorderColor = CType(resources.GetObject("GVDEVIS.Appearance.FooterPanel.BorderColor"), System.Drawing.Color)
        Me.GVDEVIS.Appearance.FooterPanel.FontSizeDelta = CType(resources.GetObject("GVDEVIS.Appearance.FooterPanel.FontSizeDelta"), Integer)
        Me.GVDEVIS.Appearance.FooterPanel.FontStyleDelta = CType(resources.GetObject("GVDEVIS.Appearance.FooterPanel.FontStyleDelta"), System.Drawing.FontStyle)
        Me.GVDEVIS.Appearance.FooterPanel.ForeColor = CType(resources.GetObject("GVDEVIS.Appearance.FooterPanel.ForeColor"), System.Drawing.Color)
        Me.GVDEVIS.Appearance.FooterPanel.GradientMode = CType(resources.GetObject("GVDEVIS.Appearance.FooterPanel.GradientMode"), System.Drawing.Drawing2D.LinearGradientMode)
        Me.GVDEVIS.Appearance.FooterPanel.Image = CType(resources.GetObject("GVDEVIS.Appearance.FooterPanel.Image"), System.Drawing.Image)
        Me.GVDEVIS.Appearance.FooterPanel.Options.UseBackColor = True
        Me.GVDEVIS.Appearance.FooterPanel.Options.UseBorderColor = True
        Me.GVDEVIS.Appearance.FooterPanel.Options.UseForeColor = True
        Me.GVDEVIS.Appearance.GroupButton.BackColor = CType(resources.GetObject("GVDEVIS.Appearance.GroupButton.BackColor"), System.Drawing.Color)
        Me.GVDEVIS.Appearance.GroupButton.BorderColor = CType(resources.GetObject("GVDEVIS.Appearance.GroupButton.BorderColor"), System.Drawing.Color)
        Me.GVDEVIS.Appearance.GroupButton.FontSizeDelta = CType(resources.GetObject("GVDEVIS.Appearance.GroupButton.FontSizeDelta"), Integer)
        Me.GVDEVIS.Appearance.GroupButton.FontStyleDelta = CType(resources.GetObject("GVDEVIS.Appearance.GroupButton.FontStyleDelta"), System.Drawing.FontStyle)
        Me.GVDEVIS.Appearance.GroupButton.GradientMode = CType(resources.GetObject("GVDEVIS.Appearance.GroupButton.GradientMode"), System.Drawing.Drawing2D.LinearGradientMode)
        Me.GVDEVIS.Appearance.GroupButton.Image = CType(resources.GetObject("GVDEVIS.Appearance.GroupButton.Image"), System.Drawing.Image)
        Me.GVDEVIS.Appearance.GroupButton.Options.UseBackColor = True
        Me.GVDEVIS.Appearance.GroupButton.Options.UseBorderColor = True
        Me.GVDEVIS.Appearance.GroupFooter.BackColor = CType(resources.GetObject("GVDEVIS.Appearance.GroupFooter.BackColor"), System.Drawing.Color)
        Me.GVDEVIS.Appearance.GroupFooter.BorderColor = CType(resources.GetObject("GVDEVIS.Appearance.GroupFooter.BorderColor"), System.Drawing.Color)
        Me.GVDEVIS.Appearance.GroupFooter.FontSizeDelta = CType(resources.GetObject("GVDEVIS.Appearance.GroupFooter.FontSizeDelta"), Integer)
        Me.GVDEVIS.Appearance.GroupFooter.FontStyleDelta = CType(resources.GetObject("GVDEVIS.Appearance.GroupFooter.FontStyleDelta"), System.Drawing.FontStyle)
        Me.GVDEVIS.Appearance.GroupFooter.ForeColor = CType(resources.GetObject("GVDEVIS.Appearance.GroupFooter.ForeColor"), System.Drawing.Color)
        Me.GVDEVIS.Appearance.GroupFooter.GradientMode = CType(resources.GetObject("GVDEVIS.Appearance.GroupFooter.GradientMode"), System.Drawing.Drawing2D.LinearGradientMode)
        Me.GVDEVIS.Appearance.GroupFooter.Image = CType(resources.GetObject("GVDEVIS.Appearance.GroupFooter.Image"), System.Drawing.Image)
        Me.GVDEVIS.Appearance.GroupFooter.Options.UseBackColor = True
        Me.GVDEVIS.Appearance.GroupFooter.Options.UseBorderColor = True
        Me.GVDEVIS.Appearance.GroupFooter.Options.UseForeColor = True
        Me.GVDEVIS.Appearance.GroupPanel.BackColor = CType(resources.GetObject("GVDEVIS.Appearance.GroupPanel.BackColor"), System.Drawing.Color)
        Me.GVDEVIS.Appearance.GroupPanel.BackColor2 = CType(resources.GetObject("GVDEVIS.Appearance.GroupPanel.BackColor2"), System.Drawing.Color)
        Me.GVDEVIS.Appearance.GroupPanel.FontSizeDelta = CType(resources.GetObject("GVDEVIS.Appearance.GroupPanel.FontSizeDelta"), Integer)
        Me.GVDEVIS.Appearance.GroupPanel.FontStyleDelta = CType(resources.GetObject("GVDEVIS.Appearance.GroupPanel.FontStyleDelta"), System.Drawing.FontStyle)
        Me.GVDEVIS.Appearance.GroupPanel.ForeColor = CType(resources.GetObject("GVDEVIS.Appearance.GroupPanel.ForeColor"), System.Drawing.Color)
        Me.GVDEVIS.Appearance.GroupPanel.GradientMode = CType(resources.GetObject("GVDEVIS.Appearance.GroupPanel.GradientMode"), System.Drawing.Drawing2D.LinearGradientMode)
        Me.GVDEVIS.Appearance.GroupPanel.Image = CType(resources.GetObject("GVDEVIS.Appearance.GroupPanel.Image"), System.Drawing.Image)
        Me.GVDEVIS.Appearance.GroupPanel.Options.UseBackColor = True
        Me.GVDEVIS.Appearance.GroupPanel.Options.UseForeColor = True
        Me.GVDEVIS.Appearance.GroupRow.BackColor = CType(resources.GetObject("GVDEVIS.Appearance.GroupRow.BackColor"), System.Drawing.Color)
        Me.GVDEVIS.Appearance.GroupRow.BorderColor = CType(resources.GetObject("GVDEVIS.Appearance.GroupRow.BorderColor"), System.Drawing.Color)
        Me.GVDEVIS.Appearance.GroupRow.FontSizeDelta = CType(resources.GetObject("GVDEVIS.Appearance.GroupRow.FontSizeDelta"), Integer)
        Me.GVDEVIS.Appearance.GroupRow.FontStyleDelta = CType(resources.GetObject("GVDEVIS.Appearance.GroupRow.FontStyleDelta"), System.Drawing.FontStyle)
        Me.GVDEVIS.Appearance.GroupRow.ForeColor = CType(resources.GetObject("GVDEVIS.Appearance.GroupRow.ForeColor"), System.Drawing.Color)
        Me.GVDEVIS.Appearance.GroupRow.GradientMode = CType(resources.GetObject("GVDEVIS.Appearance.GroupRow.GradientMode"), System.Drawing.Drawing2D.LinearGradientMode)
        Me.GVDEVIS.Appearance.GroupRow.Image = CType(resources.GetObject("GVDEVIS.Appearance.GroupRow.Image"), System.Drawing.Image)
        Me.GVDEVIS.Appearance.GroupRow.Options.UseBackColor = True
        Me.GVDEVIS.Appearance.GroupRow.Options.UseBorderColor = True
        Me.GVDEVIS.Appearance.GroupRow.Options.UseForeColor = True
        Me.GVDEVIS.Appearance.HeaderPanel.BackColor = CType(resources.GetObject("GVDEVIS.Appearance.HeaderPanel.BackColor"), System.Drawing.Color)
        Me.GVDEVIS.Appearance.HeaderPanel.BorderColor = CType(resources.GetObject("GVDEVIS.Appearance.HeaderPanel.BorderColor"), System.Drawing.Color)
        Me.GVDEVIS.Appearance.HeaderPanel.FontSizeDelta = CType(resources.GetObject("GVDEVIS.Appearance.HeaderPanel.FontSizeDelta"), Integer)
        Me.GVDEVIS.Appearance.HeaderPanel.FontStyleDelta = CType(resources.GetObject("GVDEVIS.Appearance.HeaderPanel.FontStyleDelta"), System.Drawing.FontStyle)
        Me.GVDEVIS.Appearance.HeaderPanel.ForeColor = CType(resources.GetObject("GVDEVIS.Appearance.HeaderPanel.ForeColor"), System.Drawing.Color)
        Me.GVDEVIS.Appearance.HeaderPanel.GradientMode = CType(resources.GetObject("GVDEVIS.Appearance.HeaderPanel.GradientMode"), System.Drawing.Drawing2D.LinearGradientMode)
        Me.GVDEVIS.Appearance.HeaderPanel.Image = CType(resources.GetObject("GVDEVIS.Appearance.HeaderPanel.Image"), System.Drawing.Image)
        Me.GVDEVIS.Appearance.HeaderPanel.Options.UseBackColor = True
        Me.GVDEVIS.Appearance.HeaderPanel.Options.UseBorderColor = True
        Me.GVDEVIS.Appearance.HeaderPanel.Options.UseForeColor = True
        Me.GVDEVIS.Appearance.HideSelectionRow.BackColor = CType(resources.GetObject("GVDEVIS.Appearance.HideSelectionRow.BackColor"), System.Drawing.Color)
        Me.GVDEVIS.Appearance.HideSelectionRow.FontSizeDelta = CType(resources.GetObject("GVDEVIS.Appearance.HideSelectionRow.FontSizeDelta"), Integer)
        Me.GVDEVIS.Appearance.HideSelectionRow.FontStyleDelta = CType(resources.GetObject("GVDEVIS.Appearance.HideSelectionRow.FontStyleDelta"), System.Drawing.FontStyle)
        Me.GVDEVIS.Appearance.HideSelectionRow.ForeColor = CType(resources.GetObject("GVDEVIS.Appearance.HideSelectionRow.ForeColor"), System.Drawing.Color)
        Me.GVDEVIS.Appearance.HideSelectionRow.GradientMode = CType(resources.GetObject("GVDEVIS.Appearance.HideSelectionRow.GradientMode"), System.Drawing.Drawing2D.LinearGradientMode)
        Me.GVDEVIS.Appearance.HideSelectionRow.Image = CType(resources.GetObject("GVDEVIS.Appearance.HideSelectionRow.Image"), System.Drawing.Image)
        Me.GVDEVIS.Appearance.HideSelectionRow.Options.UseBackColor = True
        Me.GVDEVIS.Appearance.HideSelectionRow.Options.UseForeColor = True
        Me.GVDEVIS.Appearance.HorzLine.BackColor = CType(resources.GetObject("GVDEVIS.Appearance.HorzLine.BackColor"), System.Drawing.Color)
        Me.GVDEVIS.Appearance.HorzLine.BorderColor = CType(resources.GetObject("GVDEVIS.Appearance.HorzLine.BorderColor"), System.Drawing.Color)
        Me.GVDEVIS.Appearance.HorzLine.FontSizeDelta = CType(resources.GetObject("GVDEVIS.Appearance.HorzLine.FontSizeDelta"), Integer)
        Me.GVDEVIS.Appearance.HorzLine.FontStyleDelta = CType(resources.GetObject("GVDEVIS.Appearance.HorzLine.FontStyleDelta"), System.Drawing.FontStyle)
        Me.GVDEVIS.Appearance.HorzLine.GradientMode = CType(resources.GetObject("GVDEVIS.Appearance.HorzLine.GradientMode"), System.Drawing.Drawing2D.LinearGradientMode)
        Me.GVDEVIS.Appearance.HorzLine.Image = CType(resources.GetObject("GVDEVIS.Appearance.HorzLine.Image"), System.Drawing.Image)
        Me.GVDEVIS.Appearance.HorzLine.Options.UseBackColor = True
        Me.GVDEVIS.Appearance.HorzLine.Options.UseBorderColor = True
        Me.GVDEVIS.Appearance.OddRow.BackColor = CType(resources.GetObject("GVDEVIS.Appearance.OddRow.BackColor"), System.Drawing.Color)
        Me.GVDEVIS.Appearance.OddRow.BorderColor = CType(resources.GetObject("GVDEVIS.Appearance.OddRow.BorderColor"), System.Drawing.Color)
        Me.GVDEVIS.Appearance.OddRow.FontSizeDelta = CType(resources.GetObject("GVDEVIS.Appearance.OddRow.FontSizeDelta"), Integer)
        Me.GVDEVIS.Appearance.OddRow.FontStyleDelta = CType(resources.GetObject("GVDEVIS.Appearance.OddRow.FontStyleDelta"), System.Drawing.FontStyle)
        Me.GVDEVIS.Appearance.OddRow.ForeColor = CType(resources.GetObject("GVDEVIS.Appearance.OddRow.ForeColor"), System.Drawing.Color)
        Me.GVDEVIS.Appearance.OddRow.GradientMode = CType(resources.GetObject("GVDEVIS.Appearance.OddRow.GradientMode"), System.Drawing.Drawing2D.LinearGradientMode)
        Me.GVDEVIS.Appearance.OddRow.Image = CType(resources.GetObject("GVDEVIS.Appearance.OddRow.Image"), System.Drawing.Image)
        Me.GVDEVIS.Appearance.OddRow.Options.UseBackColor = True
        Me.GVDEVIS.Appearance.OddRow.Options.UseBorderColor = True
        Me.GVDEVIS.Appearance.OddRow.Options.UseForeColor = True
        Me.GVDEVIS.Appearance.Preview.BackColor = CType(resources.GetObject("GVDEVIS.Appearance.Preview.BackColor"), System.Drawing.Color)
        Me.GVDEVIS.Appearance.Preview.Font = CType(resources.GetObject("GVDEVIS.Appearance.Preview.Font"), System.Drawing.Font)
        Me.GVDEVIS.Appearance.Preview.FontSizeDelta = CType(resources.GetObject("GVDEVIS.Appearance.Preview.FontSizeDelta"), Integer)
        Me.GVDEVIS.Appearance.Preview.FontStyleDelta = CType(resources.GetObject("GVDEVIS.Appearance.Preview.FontStyleDelta"), System.Drawing.FontStyle)
        Me.GVDEVIS.Appearance.Preview.ForeColor = CType(resources.GetObject("GVDEVIS.Appearance.Preview.ForeColor"), System.Drawing.Color)
        Me.GVDEVIS.Appearance.Preview.GradientMode = CType(resources.GetObject("GVDEVIS.Appearance.Preview.GradientMode"), System.Drawing.Drawing2D.LinearGradientMode)
        Me.GVDEVIS.Appearance.Preview.Image = CType(resources.GetObject("GVDEVIS.Appearance.Preview.Image"), System.Drawing.Image)
        Me.GVDEVIS.Appearance.Preview.Options.UseBackColor = True
        Me.GVDEVIS.Appearance.Preview.Options.UseFont = True
        Me.GVDEVIS.Appearance.Preview.Options.UseForeColor = True
        Me.GVDEVIS.Appearance.Row.BackColor = CType(resources.GetObject("GVDEVIS.Appearance.Row.BackColor"), System.Drawing.Color)
        Me.GVDEVIS.Appearance.Row.FontSizeDelta = CType(resources.GetObject("GVDEVIS.Appearance.Row.FontSizeDelta"), Integer)
        Me.GVDEVIS.Appearance.Row.FontStyleDelta = CType(resources.GetObject("GVDEVIS.Appearance.Row.FontStyleDelta"), System.Drawing.FontStyle)
        Me.GVDEVIS.Appearance.Row.ForeColor = CType(resources.GetObject("GVDEVIS.Appearance.Row.ForeColor"), System.Drawing.Color)
        Me.GVDEVIS.Appearance.Row.GradientMode = CType(resources.GetObject("GVDEVIS.Appearance.Row.GradientMode"), System.Drawing.Drawing2D.LinearGradientMode)
        Me.GVDEVIS.Appearance.Row.Image = CType(resources.GetObject("GVDEVIS.Appearance.Row.Image"), System.Drawing.Image)
        Me.GVDEVIS.Appearance.Row.Options.UseBackColor = True
        Me.GVDEVIS.Appearance.Row.Options.UseForeColor = True
        Me.GVDEVIS.Appearance.RowSeparator.BackColor = CType(resources.GetObject("GVDEVIS.Appearance.RowSeparator.BackColor"), System.Drawing.Color)
        Me.GVDEVIS.Appearance.RowSeparator.BackColor2 = CType(resources.GetObject("GVDEVIS.Appearance.RowSeparator.BackColor2"), System.Drawing.Color)
        Me.GVDEVIS.Appearance.RowSeparator.FontSizeDelta = CType(resources.GetObject("GVDEVIS.Appearance.RowSeparator.FontSizeDelta"), Integer)
        Me.GVDEVIS.Appearance.RowSeparator.FontStyleDelta = CType(resources.GetObject("GVDEVIS.Appearance.RowSeparator.FontStyleDelta"), System.Drawing.FontStyle)
        Me.GVDEVIS.Appearance.RowSeparator.GradientMode = CType(resources.GetObject("GVDEVIS.Appearance.RowSeparator.GradientMode"), System.Drawing.Drawing2D.LinearGradientMode)
        Me.GVDEVIS.Appearance.RowSeparator.Image = CType(resources.GetObject("GVDEVIS.Appearance.RowSeparator.Image"), System.Drawing.Image)
        Me.GVDEVIS.Appearance.RowSeparator.Options.UseBackColor = True
        Me.GVDEVIS.Appearance.SelectedRow.BackColor = CType(resources.GetObject("GVDEVIS.Appearance.SelectedRow.BackColor"), System.Drawing.Color)
        Me.GVDEVIS.Appearance.SelectedRow.FontSizeDelta = CType(resources.GetObject("GVDEVIS.Appearance.SelectedRow.FontSizeDelta"), Integer)
        Me.GVDEVIS.Appearance.SelectedRow.FontStyleDelta = CType(resources.GetObject("GVDEVIS.Appearance.SelectedRow.FontStyleDelta"), System.Drawing.FontStyle)
        Me.GVDEVIS.Appearance.SelectedRow.ForeColor = CType(resources.GetObject("GVDEVIS.Appearance.SelectedRow.ForeColor"), System.Drawing.Color)
        Me.GVDEVIS.Appearance.SelectedRow.GradientMode = CType(resources.GetObject("GVDEVIS.Appearance.SelectedRow.GradientMode"), System.Drawing.Drawing2D.LinearGradientMode)
        Me.GVDEVIS.Appearance.SelectedRow.Image = CType(resources.GetObject("GVDEVIS.Appearance.SelectedRow.Image"), System.Drawing.Image)
        Me.GVDEVIS.Appearance.SelectedRow.Options.UseBackColor = True
        Me.GVDEVIS.Appearance.SelectedRow.Options.UseForeColor = True
        Me.GVDEVIS.Appearance.TopNewRow.BackColor = CType(resources.GetObject("GVDEVIS.Appearance.TopNewRow.BackColor"), System.Drawing.Color)
        Me.GVDEVIS.Appearance.TopNewRow.FontSizeDelta = CType(resources.GetObject("GVDEVIS.Appearance.TopNewRow.FontSizeDelta"), Integer)
        Me.GVDEVIS.Appearance.TopNewRow.FontStyleDelta = CType(resources.GetObject("GVDEVIS.Appearance.TopNewRow.FontStyleDelta"), System.Drawing.FontStyle)
        Me.GVDEVIS.Appearance.TopNewRow.GradientMode = CType(resources.GetObject("GVDEVIS.Appearance.TopNewRow.GradientMode"), System.Drawing.Drawing2D.LinearGradientMode)
        Me.GVDEVIS.Appearance.TopNewRow.Image = CType(resources.GetObject("GVDEVIS.Appearance.TopNewRow.Image"), System.Drawing.Image)
        Me.GVDEVIS.Appearance.TopNewRow.Options.UseBackColor = True
        Me.GVDEVIS.Appearance.VertLine.BackColor = CType(resources.GetObject("GVDEVIS.Appearance.VertLine.BackColor"), System.Drawing.Color)
        Me.GVDEVIS.Appearance.VertLine.BorderColor = CType(resources.GetObject("GVDEVIS.Appearance.VertLine.BorderColor"), System.Drawing.Color)
        Me.GVDEVIS.Appearance.VertLine.FontSizeDelta = CType(resources.GetObject("GVDEVIS.Appearance.VertLine.FontSizeDelta"), Integer)
        Me.GVDEVIS.Appearance.VertLine.FontStyleDelta = CType(resources.GetObject("GVDEVIS.Appearance.VertLine.FontStyleDelta"), System.Drawing.FontStyle)
        Me.GVDEVIS.Appearance.VertLine.GradientMode = CType(resources.GetObject("GVDEVIS.Appearance.VertLine.GradientMode"), System.Drawing.Drawing2D.LinearGradientMode)
        Me.GVDEVIS.Appearance.VertLine.Image = CType(resources.GetObject("GVDEVIS.Appearance.VertLine.Image"), System.Drawing.Image)
        Me.GVDEVIS.Appearance.VertLine.Options.UseBackColor = True
        Me.GVDEVIS.Appearance.VertLine.Options.UseBorderColor = True
        resources.ApplyResources(Me.GVDEVIS, "GVDEVIS")
        Me.GVDEVIS.Columns.AddRange(New DevExpress.XtraGrid.Columns.GridColumn() {Me.ColDEVISVLIB, Me.ColDEVISMO, Me.ColDEVISFOU, Me.ColDEVISDEBOURSE})
        Me.GVDEVIS.GridControl = Me.GCDEVIS
        Me.GVDEVIS.Name = "GVDEVIS"
        Me.GVDEVIS.OptionsBehavior.Editable = False
        Me.GVDEVIS.OptionsBehavior.ReadOnly = True
        Me.GVDEVIS.OptionsView.EnableAppearanceEvenRow = True
        Me.GVDEVIS.OptionsView.EnableAppearanceOddRow = True
        Me.GVDEVIS.OptionsView.ShowFooter = True
        Me.GVDEVIS.OptionsView.ShowGroupPanel = False
        '
        'ColDEVISVLIB
        '
        Me.ColDEVISVLIB.AppearanceHeader.FontSizeDelta = CType(resources.GetObject("ColDEVISVLIB.AppearanceHeader.FontSizeDelta"), Integer)
        Me.ColDEVISVLIB.AppearanceHeader.FontStyleDelta = CType(resources.GetObject("ColDEVISVLIB.AppearanceHeader.FontStyleDelta"), System.Drawing.FontStyle)
        Me.ColDEVISVLIB.AppearanceHeader.GradientMode = CType(resources.GetObject("ColDEVISVLIB.AppearanceHeader.GradientMode"), System.Drawing.Drawing2D.LinearGradientMode)
        Me.ColDEVISVLIB.AppearanceHeader.Image = CType(resources.GetObject("ColDEVISVLIB.AppearanceHeader.Image"), System.Drawing.Image)
        Me.ColDEVISVLIB.AppearanceHeader.Options.UseTextOptions = True
        Me.ColDEVISVLIB.AppearanceHeader.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center
        Me.ColDEVISVLIB.AppearanceHeader.TextOptions.VAlignment = DevExpress.Utils.VertAlignment.Center
        resources.ApplyResources(Me.ColDEVISVLIB, "ColDEVISVLIB")
        Me.ColDEVISVLIB.FieldName = "VLIB"
        Me.ColDEVISVLIB.Name = "ColDEVISVLIB"
        '
        'ColDEVISMO
        '
        Me.ColDEVISMO.AppearanceHeader.FontSizeDelta = CType(resources.GetObject("ColDEVISMO.AppearanceHeader.FontSizeDelta"), Integer)
        Me.ColDEVISMO.AppearanceHeader.FontStyleDelta = CType(resources.GetObject("ColDEVISMO.AppearanceHeader.FontStyleDelta"), System.Drawing.FontStyle)
        Me.ColDEVISMO.AppearanceHeader.GradientMode = CType(resources.GetObject("ColDEVISMO.AppearanceHeader.GradientMode"), System.Drawing.Drawing2D.LinearGradientMode)
        Me.ColDEVISMO.AppearanceHeader.Image = CType(resources.GetObject("ColDEVISMO.AppearanceHeader.Image"), System.Drawing.Image)
        Me.ColDEVISMO.AppearanceHeader.Options.UseTextOptions = True
        Me.ColDEVISMO.AppearanceHeader.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center
        Me.ColDEVISMO.AppearanceHeader.TextOptions.VAlignment = DevExpress.Utils.VertAlignment.Center
        resources.ApplyResources(Me.ColDEVISMO, "ColDEVISMO")
        Me.ColDEVISMO.DisplayFormat.FormatString = "n2"
        Me.ColDEVISMO.DisplayFormat.FormatType = DevExpress.Utils.FormatType.Numeric
        Me.ColDEVISMO.FieldName = "MO"
        Me.ColDEVISMO.Name = "ColDEVISMO"
        Me.ColDEVISMO.Summary.AddRange(New DevExpress.XtraGrid.GridSummaryItem() {New DevExpress.XtraGrid.GridColumnSummaryItem(CType(resources.GetObject("ColDEVISMO.Summary"), DevExpress.Data.SummaryItemType), resources.GetString("ColDEVISMO.Summary1"), resources.GetString("ColDEVISMO.Summary2"))})
        '
        'ColDEVISFOU
        '
        Me.ColDEVISFOU.AppearanceHeader.FontSizeDelta = CType(resources.GetObject("ColDEVISFOU.AppearanceHeader.FontSizeDelta"), Integer)
        Me.ColDEVISFOU.AppearanceHeader.FontStyleDelta = CType(resources.GetObject("ColDEVISFOU.AppearanceHeader.FontStyleDelta"), System.Drawing.FontStyle)
        Me.ColDEVISFOU.AppearanceHeader.GradientMode = CType(resources.GetObject("ColDEVISFOU.AppearanceHeader.GradientMode"), System.Drawing.Drawing2D.LinearGradientMode)
        Me.ColDEVISFOU.AppearanceHeader.Image = CType(resources.GetObject("ColDEVISFOU.AppearanceHeader.Image"), System.Drawing.Image)
        Me.ColDEVISFOU.AppearanceHeader.Options.UseTextOptions = True
        Me.ColDEVISFOU.AppearanceHeader.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center
        Me.ColDEVISFOU.AppearanceHeader.TextOptions.VAlignment = DevExpress.Utils.VertAlignment.Center
        resources.ApplyResources(Me.ColDEVISFOU, "ColDEVISFOU")
        Me.ColDEVISFOU.DisplayFormat.FormatString = "c2"
        Me.ColDEVISFOU.DisplayFormat.FormatType = DevExpress.Utils.FormatType.Numeric
        Me.ColDEVISFOU.FieldName = "FOU"
        Me.ColDEVISFOU.Name = "ColDEVISFOU"
        Me.ColDEVISFOU.Summary.AddRange(New DevExpress.XtraGrid.GridSummaryItem() {New DevExpress.XtraGrid.GridColumnSummaryItem(CType(resources.GetObject("ColDEVISFOU.Summary"), DevExpress.Data.SummaryItemType), resources.GetString("ColDEVISFOU.Summary1"), resources.GetString("ColDEVISFOU.Summary2"))})
        '
        'ColDEVISDEBOURSE
        '
        Me.ColDEVISDEBOURSE.AppearanceHeader.FontSizeDelta = CType(resources.GetObject("ColDEVISDEBOURSE.AppearanceHeader.FontSizeDelta"), Integer)
        Me.ColDEVISDEBOURSE.AppearanceHeader.FontStyleDelta = CType(resources.GetObject("ColDEVISDEBOURSE.AppearanceHeader.FontStyleDelta"), System.Drawing.FontStyle)
        Me.ColDEVISDEBOURSE.AppearanceHeader.GradientMode = CType(resources.GetObject("ColDEVISDEBOURSE.AppearanceHeader.GradientMode"), System.Drawing.Drawing2D.LinearGradientMode)
        Me.ColDEVISDEBOURSE.AppearanceHeader.Image = CType(resources.GetObject("ColDEVISDEBOURSE.AppearanceHeader.Image"), System.Drawing.Image)
        Me.ColDEVISDEBOURSE.AppearanceHeader.Options.UseTextOptions = True
        Me.ColDEVISDEBOURSE.AppearanceHeader.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center
        Me.ColDEVISDEBOURSE.AppearanceHeader.TextOptions.VAlignment = DevExpress.Utils.VertAlignment.Center
        resources.ApplyResources(Me.ColDEVISDEBOURSE, "ColDEVISDEBOURSE")
        Me.ColDEVISDEBOURSE.DisplayFormat.FormatString = "c2"
        Me.ColDEVISDEBOURSE.DisplayFormat.FormatType = DevExpress.Utils.FormatType.Numeric
        Me.ColDEVISDEBOURSE.FieldName = "DEBOURSE"
        Me.ColDEVISDEBOURSE.Name = "ColDEVISDEBOURSE"
        Me.ColDEVISDEBOURSE.Summary.AddRange(New DevExpress.XtraGrid.GridSummaryItem() {New DevExpress.XtraGrid.GridColumnSummaryItem(CType(resources.GetObject("ColDEVISDEBOURSE.Summary"), DevExpress.Data.SummaryItemType), resources.GetString("ColDEVISDEBOURSE.Summary1"), resources.GetString("ColDEVISDEBOURSE.Summary2"))})
        '
        'GrpSeriePrest
        '
        resources.ApplyResources(Me.GrpSeriePrest, "GrpSeriePrest")
        Me.GrpSeriePrest.Controls.Add(Me.BtnExportSerieXLS)
        Me.GrpSeriePrest.Controls.Add(Me.GCSERIE)
        Me.GrpSeriePrest.Name = "GrpSeriePrest"
        Me.GrpSeriePrest.TabStop = False
        '
        'BtnExportSerieXLS
        '
        resources.ApplyResources(Me.BtnExportSerieXLS, "BtnExportSerieXLS")
        Me.BtnExportSerieXLS.Name = "BtnExportSerieXLS"
        Me.BtnExportSerieXLS.UseVisualStyleBackColor = True
        '
        'GCSERIE
        '
        resources.ApplyResources(Me.GCSERIE, "GCSERIE")
        '
        '
        '
        Me.GCSERIE.EmbeddedNavigator.AccessibleDescription = resources.GetString("GCSERIE.EmbeddedNavigator.AccessibleDescription")
        Me.GCSERIE.EmbeddedNavigator.AccessibleName = resources.GetString("GCSERIE.EmbeddedNavigator.AccessibleName")
        Me.GCSERIE.EmbeddedNavigator.AllowHtmlTextInToolTip = CType(resources.GetObject("GCSERIE.EmbeddedNavigator.AllowHtmlTextInToolTip"), DevExpress.Utils.DefaultBoolean)
        Me.GCSERIE.EmbeddedNavigator.Anchor = CType(resources.GetObject("GCSERIE.EmbeddedNavigator.Anchor"), System.Windows.Forms.AnchorStyles)
        Me.GCSERIE.EmbeddedNavigator.BackgroundImage = CType(resources.GetObject("GCSERIE.EmbeddedNavigator.BackgroundImage"), System.Drawing.Image)
        Me.GCSERIE.EmbeddedNavigator.BackgroundImageLayout = CType(resources.GetObject("GCSERIE.EmbeddedNavigator.BackgroundImageLayout"), System.Windows.Forms.ImageLayout)
        Me.GCSERIE.EmbeddedNavigator.ImeMode = CType(resources.GetObject("GCSERIE.EmbeddedNavigator.ImeMode"), System.Windows.Forms.ImeMode)
        Me.GCSERIE.EmbeddedNavigator.MaximumSize = CType(resources.GetObject("GCSERIE.EmbeddedNavigator.MaximumSize"), System.Drawing.Size)
        Me.GCSERIE.EmbeddedNavigator.TextLocation = CType(resources.GetObject("GCSERIE.EmbeddedNavigator.TextLocation"), DevExpress.XtraEditors.NavigatorButtonsTextLocation)
        Me.GCSERIE.EmbeddedNavigator.ToolTip = resources.GetString("GCSERIE.EmbeddedNavigator.ToolTip")
        Me.GCSERIE.EmbeddedNavigator.ToolTipIconType = CType(resources.GetObject("GCSERIE.EmbeddedNavigator.ToolTipIconType"), DevExpress.Utils.ToolTipIconType)
        Me.GCSERIE.EmbeddedNavigator.ToolTipTitle = resources.GetString("GCSERIE.EmbeddedNavigator.ToolTipTitle")
        Me.GCSERIE.MainView = Me.GVSERIE
        Me.GCSERIE.Name = "GCSERIE"
        Me.GCSERIE.ViewCollection.AddRange(New DevExpress.XtraGrid.Views.Base.BaseView() {Me.GVSERIE})
        '
        'GVSERIE
        '
        Me.GVSERIE.Appearance.ColumnFilterButton.BackColor = CType(resources.GetObject("GVSERIE.Appearance.ColumnFilterButton.BackColor"), System.Drawing.Color)
        Me.GVSERIE.Appearance.ColumnFilterButton.BorderColor = CType(resources.GetObject("GVSERIE.Appearance.ColumnFilterButton.BorderColor"), System.Drawing.Color)
        Me.GVSERIE.Appearance.ColumnFilterButton.FontSizeDelta = CType(resources.GetObject("GVSERIE.Appearance.ColumnFilterButton.FontSizeDelta"), Integer)
        Me.GVSERIE.Appearance.ColumnFilterButton.FontStyleDelta = CType(resources.GetObject("GVSERIE.Appearance.ColumnFilterButton.FontStyleDelta"), System.Drawing.FontStyle)
        Me.GVSERIE.Appearance.ColumnFilterButton.ForeColor = CType(resources.GetObject("GVSERIE.Appearance.ColumnFilterButton.ForeColor"), System.Drawing.Color)
        Me.GVSERIE.Appearance.ColumnFilterButton.GradientMode = CType(resources.GetObject("GVSERIE.Appearance.ColumnFilterButton.GradientMode"), System.Drawing.Drawing2D.LinearGradientMode)
        Me.GVSERIE.Appearance.ColumnFilterButton.Image = CType(resources.GetObject("GVSERIE.Appearance.ColumnFilterButton.Image"), System.Drawing.Image)
        Me.GVSERIE.Appearance.ColumnFilterButton.Options.UseBackColor = True
        Me.GVSERIE.Appearance.ColumnFilterButton.Options.UseBorderColor = True
        Me.GVSERIE.Appearance.ColumnFilterButton.Options.UseForeColor = True
        Me.GVSERIE.Appearance.ColumnFilterButtonActive.BackColor = CType(resources.GetObject("GVSERIE.Appearance.ColumnFilterButtonActive.BackColor"), System.Drawing.Color)
        Me.GVSERIE.Appearance.ColumnFilterButtonActive.BorderColor = CType(resources.GetObject("GVSERIE.Appearance.ColumnFilterButtonActive.BorderColor"), System.Drawing.Color)
        Me.GVSERIE.Appearance.ColumnFilterButtonActive.FontSizeDelta = CType(resources.GetObject("GVSERIE.Appearance.ColumnFilterButtonActive.FontSizeDelta"), Integer)
        Me.GVSERIE.Appearance.ColumnFilterButtonActive.FontStyleDelta = CType(resources.GetObject("GVSERIE.Appearance.ColumnFilterButtonActive.FontStyleDelta"), System.Drawing.FontStyle)
        Me.GVSERIE.Appearance.ColumnFilterButtonActive.ForeColor = CType(resources.GetObject("GVSERIE.Appearance.ColumnFilterButtonActive.ForeColor"), System.Drawing.Color)
        Me.GVSERIE.Appearance.ColumnFilterButtonActive.GradientMode = CType(resources.GetObject("GVSERIE.Appearance.ColumnFilterButtonActive.GradientMode"), System.Drawing.Drawing2D.LinearGradientMode)
        Me.GVSERIE.Appearance.ColumnFilterButtonActive.Image = CType(resources.GetObject("GVSERIE.Appearance.ColumnFilterButtonActive.Image"), System.Drawing.Image)
        Me.GVSERIE.Appearance.ColumnFilterButtonActive.Options.UseBackColor = True
        Me.GVSERIE.Appearance.ColumnFilterButtonActive.Options.UseBorderColor = True
        Me.GVSERIE.Appearance.ColumnFilterButtonActive.Options.UseForeColor = True
        Me.GVSERIE.Appearance.Empty.BackColor = CType(resources.GetObject("GVSERIE.Appearance.Empty.BackColor"), System.Drawing.Color)
        Me.GVSERIE.Appearance.Empty.BackColor2 = CType(resources.GetObject("GVSERIE.Appearance.Empty.BackColor2"), System.Drawing.Color)
        Me.GVSERIE.Appearance.Empty.FontSizeDelta = CType(resources.GetObject("GVSERIE.Appearance.Empty.FontSizeDelta"), Integer)
        Me.GVSERIE.Appearance.Empty.FontStyleDelta = CType(resources.GetObject("GVSERIE.Appearance.Empty.FontStyleDelta"), System.Drawing.FontStyle)
        Me.GVSERIE.Appearance.Empty.GradientMode = CType(resources.GetObject("GVSERIE.Appearance.Empty.GradientMode"), System.Drawing.Drawing2D.LinearGradientMode)
        Me.GVSERIE.Appearance.Empty.Image = CType(resources.GetObject("GVSERIE.Appearance.Empty.Image"), System.Drawing.Image)
        Me.GVSERIE.Appearance.Empty.Options.UseBackColor = True
        Me.GVSERIE.Appearance.EvenRow.BackColor = CType(resources.GetObject("GVSERIE.Appearance.EvenRow.BackColor"), System.Drawing.Color)
        Me.GVSERIE.Appearance.EvenRow.BorderColor = CType(resources.GetObject("GVSERIE.Appearance.EvenRow.BorderColor"), System.Drawing.Color)
        Me.GVSERIE.Appearance.EvenRow.FontSizeDelta = CType(resources.GetObject("GVSERIE.Appearance.EvenRow.FontSizeDelta"), Integer)
        Me.GVSERIE.Appearance.EvenRow.FontStyleDelta = CType(resources.GetObject("GVSERIE.Appearance.EvenRow.FontStyleDelta"), System.Drawing.FontStyle)
        Me.GVSERIE.Appearance.EvenRow.ForeColor = CType(resources.GetObject("GVSERIE.Appearance.EvenRow.ForeColor"), System.Drawing.Color)
        Me.GVSERIE.Appearance.EvenRow.GradientMode = CType(resources.GetObject("GVSERIE.Appearance.EvenRow.GradientMode"), System.Drawing.Drawing2D.LinearGradientMode)
        Me.GVSERIE.Appearance.EvenRow.Image = CType(resources.GetObject("GVSERIE.Appearance.EvenRow.Image"), System.Drawing.Image)
        Me.GVSERIE.Appearance.EvenRow.Options.UseBackColor = True
        Me.GVSERIE.Appearance.EvenRow.Options.UseBorderColor = True
        Me.GVSERIE.Appearance.EvenRow.Options.UseForeColor = True
        Me.GVSERIE.Appearance.FilterCloseButton.BackColor = CType(resources.GetObject("GVSERIE.Appearance.FilterCloseButton.BackColor"), System.Drawing.Color)
        Me.GVSERIE.Appearance.FilterCloseButton.BorderColor = CType(resources.GetObject("GVSERIE.Appearance.FilterCloseButton.BorderColor"), System.Drawing.Color)
        Me.GVSERIE.Appearance.FilterCloseButton.FontSizeDelta = CType(resources.GetObject("GVSERIE.Appearance.FilterCloseButton.FontSizeDelta"), Integer)
        Me.GVSERIE.Appearance.FilterCloseButton.FontStyleDelta = CType(resources.GetObject("GVSERIE.Appearance.FilterCloseButton.FontStyleDelta"), System.Drawing.FontStyle)
        Me.GVSERIE.Appearance.FilterCloseButton.ForeColor = CType(resources.GetObject("GVSERIE.Appearance.FilterCloseButton.ForeColor"), System.Drawing.Color)
        Me.GVSERIE.Appearance.FilterCloseButton.GradientMode = CType(resources.GetObject("GVSERIE.Appearance.FilterCloseButton.GradientMode"), System.Drawing.Drawing2D.LinearGradientMode)
        Me.GVSERIE.Appearance.FilterCloseButton.Image = CType(resources.GetObject("GVSERIE.Appearance.FilterCloseButton.Image"), System.Drawing.Image)
        Me.GVSERIE.Appearance.FilterCloseButton.Options.UseBackColor = True
        Me.GVSERIE.Appearance.FilterCloseButton.Options.UseBorderColor = True
        Me.GVSERIE.Appearance.FilterCloseButton.Options.UseForeColor = True
        Me.GVSERIE.Appearance.FilterPanel.BackColor = CType(resources.GetObject("GVSERIE.Appearance.FilterPanel.BackColor"), System.Drawing.Color)
        Me.GVSERIE.Appearance.FilterPanel.BackColor2 = CType(resources.GetObject("GVSERIE.Appearance.FilterPanel.BackColor2"), System.Drawing.Color)
        Me.GVSERIE.Appearance.FilterPanel.FontSizeDelta = CType(resources.GetObject("GVSERIE.Appearance.FilterPanel.FontSizeDelta"), Integer)
        Me.GVSERIE.Appearance.FilterPanel.FontStyleDelta = CType(resources.GetObject("GVSERIE.Appearance.FilterPanel.FontStyleDelta"), System.Drawing.FontStyle)
        Me.GVSERIE.Appearance.FilterPanel.ForeColor = CType(resources.GetObject("GVSERIE.Appearance.FilterPanel.ForeColor"), System.Drawing.Color)
        Me.GVSERIE.Appearance.FilterPanel.GradientMode = CType(resources.GetObject("GVSERIE.Appearance.FilterPanel.GradientMode"), System.Drawing.Drawing2D.LinearGradientMode)
        Me.GVSERIE.Appearance.FilterPanel.Image = CType(resources.GetObject("GVSERIE.Appearance.FilterPanel.Image"), System.Drawing.Image)
        Me.GVSERIE.Appearance.FilterPanel.Options.UseBackColor = True
        Me.GVSERIE.Appearance.FilterPanel.Options.UseForeColor = True
        Me.GVSERIE.Appearance.FixedLine.BackColor = CType(resources.GetObject("GVSERIE.Appearance.FixedLine.BackColor"), System.Drawing.Color)
        Me.GVSERIE.Appearance.FixedLine.FontSizeDelta = CType(resources.GetObject("GVSERIE.Appearance.FixedLine.FontSizeDelta"), Integer)
        Me.GVSERIE.Appearance.FixedLine.FontStyleDelta = CType(resources.GetObject("GVSERIE.Appearance.FixedLine.FontStyleDelta"), System.Drawing.FontStyle)
        Me.GVSERIE.Appearance.FixedLine.GradientMode = CType(resources.GetObject("GVSERIE.Appearance.FixedLine.GradientMode"), System.Drawing.Drawing2D.LinearGradientMode)
        Me.GVSERIE.Appearance.FixedLine.Image = CType(resources.GetObject("GVSERIE.Appearance.FixedLine.Image"), System.Drawing.Image)
        Me.GVSERIE.Appearance.FixedLine.Options.UseBackColor = True
        Me.GVSERIE.Appearance.FocusedCell.BackColor = CType(resources.GetObject("GVSERIE.Appearance.FocusedCell.BackColor"), System.Drawing.Color)
        Me.GVSERIE.Appearance.FocusedCell.FontSizeDelta = CType(resources.GetObject("GVSERIE.Appearance.FocusedCell.FontSizeDelta"), Integer)
        Me.GVSERIE.Appearance.FocusedCell.FontStyleDelta = CType(resources.GetObject("GVSERIE.Appearance.FocusedCell.FontStyleDelta"), System.Drawing.FontStyle)
        Me.GVSERIE.Appearance.FocusedCell.ForeColor = CType(resources.GetObject("GVSERIE.Appearance.FocusedCell.ForeColor"), System.Drawing.Color)
        Me.GVSERIE.Appearance.FocusedCell.GradientMode = CType(resources.GetObject("GVSERIE.Appearance.FocusedCell.GradientMode"), System.Drawing.Drawing2D.LinearGradientMode)
        Me.GVSERIE.Appearance.FocusedCell.Image = CType(resources.GetObject("GVSERIE.Appearance.FocusedCell.Image"), System.Drawing.Image)
        Me.GVSERIE.Appearance.FocusedCell.Options.UseBackColor = True
        Me.GVSERIE.Appearance.FocusedCell.Options.UseForeColor = True
        Me.GVSERIE.Appearance.FocusedRow.BackColor = CType(resources.GetObject("GVSERIE.Appearance.FocusedRow.BackColor"), System.Drawing.Color)
        Me.GVSERIE.Appearance.FocusedRow.FontSizeDelta = CType(resources.GetObject("GVSERIE.Appearance.FocusedRow.FontSizeDelta"), Integer)
        Me.GVSERIE.Appearance.FocusedRow.FontStyleDelta = CType(resources.GetObject("GVSERIE.Appearance.FocusedRow.FontStyleDelta"), System.Drawing.FontStyle)
        Me.GVSERIE.Appearance.FocusedRow.ForeColor = CType(resources.GetObject("GVSERIE.Appearance.FocusedRow.ForeColor"), System.Drawing.Color)
        Me.GVSERIE.Appearance.FocusedRow.GradientMode = CType(resources.GetObject("GVSERIE.Appearance.FocusedRow.GradientMode"), System.Drawing.Drawing2D.LinearGradientMode)
        Me.GVSERIE.Appearance.FocusedRow.Image = CType(resources.GetObject("GVSERIE.Appearance.FocusedRow.Image"), System.Drawing.Image)
        Me.GVSERIE.Appearance.FocusedRow.Options.UseBackColor = True
        Me.GVSERIE.Appearance.FocusedRow.Options.UseForeColor = True
        Me.GVSERIE.Appearance.FooterPanel.BackColor = CType(resources.GetObject("GVSERIE.Appearance.FooterPanel.BackColor"), System.Drawing.Color)
        Me.GVSERIE.Appearance.FooterPanel.BorderColor = CType(resources.GetObject("GVSERIE.Appearance.FooterPanel.BorderColor"), System.Drawing.Color)
        Me.GVSERIE.Appearance.FooterPanel.FontSizeDelta = CType(resources.GetObject("GVSERIE.Appearance.FooterPanel.FontSizeDelta"), Integer)
        Me.GVSERIE.Appearance.FooterPanel.FontStyleDelta = CType(resources.GetObject("GVSERIE.Appearance.FooterPanel.FontStyleDelta"), System.Drawing.FontStyle)
        Me.GVSERIE.Appearance.FooterPanel.ForeColor = CType(resources.GetObject("GVSERIE.Appearance.FooterPanel.ForeColor"), System.Drawing.Color)
        Me.GVSERIE.Appearance.FooterPanel.GradientMode = CType(resources.GetObject("GVSERIE.Appearance.FooterPanel.GradientMode"), System.Drawing.Drawing2D.LinearGradientMode)
        Me.GVSERIE.Appearance.FooterPanel.Image = CType(resources.GetObject("GVSERIE.Appearance.FooterPanel.Image"), System.Drawing.Image)
        Me.GVSERIE.Appearance.FooterPanel.Options.UseBackColor = True
        Me.GVSERIE.Appearance.FooterPanel.Options.UseBorderColor = True
        Me.GVSERIE.Appearance.FooterPanel.Options.UseForeColor = True
        Me.GVSERIE.Appearance.GroupButton.BackColor = CType(resources.GetObject("GVSERIE.Appearance.GroupButton.BackColor"), System.Drawing.Color)
        Me.GVSERIE.Appearance.GroupButton.BorderColor = CType(resources.GetObject("GVSERIE.Appearance.GroupButton.BorderColor"), System.Drawing.Color)
        Me.GVSERIE.Appearance.GroupButton.FontSizeDelta = CType(resources.GetObject("GVSERIE.Appearance.GroupButton.FontSizeDelta"), Integer)
        Me.GVSERIE.Appearance.GroupButton.FontStyleDelta = CType(resources.GetObject("GVSERIE.Appearance.GroupButton.FontStyleDelta"), System.Drawing.FontStyle)
        Me.GVSERIE.Appearance.GroupButton.GradientMode = CType(resources.GetObject("GVSERIE.Appearance.GroupButton.GradientMode"), System.Drawing.Drawing2D.LinearGradientMode)
        Me.GVSERIE.Appearance.GroupButton.Image = CType(resources.GetObject("GVSERIE.Appearance.GroupButton.Image"), System.Drawing.Image)
        Me.GVSERIE.Appearance.GroupButton.Options.UseBackColor = True
        Me.GVSERIE.Appearance.GroupButton.Options.UseBorderColor = True
        Me.GVSERIE.Appearance.GroupFooter.BackColor = CType(resources.GetObject("GVSERIE.Appearance.GroupFooter.BackColor"), System.Drawing.Color)
        Me.GVSERIE.Appearance.GroupFooter.BorderColor = CType(resources.GetObject("GVSERIE.Appearance.GroupFooter.BorderColor"), System.Drawing.Color)
        Me.GVSERIE.Appearance.GroupFooter.FontSizeDelta = CType(resources.GetObject("GVSERIE.Appearance.GroupFooter.FontSizeDelta"), Integer)
        Me.GVSERIE.Appearance.GroupFooter.FontStyleDelta = CType(resources.GetObject("GVSERIE.Appearance.GroupFooter.FontStyleDelta"), System.Drawing.FontStyle)
        Me.GVSERIE.Appearance.GroupFooter.ForeColor = CType(resources.GetObject("GVSERIE.Appearance.GroupFooter.ForeColor"), System.Drawing.Color)
        Me.GVSERIE.Appearance.GroupFooter.GradientMode = CType(resources.GetObject("GVSERIE.Appearance.GroupFooter.GradientMode"), System.Drawing.Drawing2D.LinearGradientMode)
        Me.GVSERIE.Appearance.GroupFooter.Image = CType(resources.GetObject("GVSERIE.Appearance.GroupFooter.Image"), System.Drawing.Image)
        Me.GVSERIE.Appearance.GroupFooter.Options.UseBackColor = True
        Me.GVSERIE.Appearance.GroupFooter.Options.UseBorderColor = True
        Me.GVSERIE.Appearance.GroupFooter.Options.UseForeColor = True
        Me.GVSERIE.Appearance.GroupPanel.BackColor = CType(resources.GetObject("GVSERIE.Appearance.GroupPanel.BackColor"), System.Drawing.Color)
        Me.GVSERIE.Appearance.GroupPanel.BackColor2 = CType(resources.GetObject("GVSERIE.Appearance.GroupPanel.BackColor2"), System.Drawing.Color)
        Me.GVSERIE.Appearance.GroupPanel.FontSizeDelta = CType(resources.GetObject("GVSERIE.Appearance.GroupPanel.FontSizeDelta"), Integer)
        Me.GVSERIE.Appearance.GroupPanel.FontStyleDelta = CType(resources.GetObject("GVSERIE.Appearance.GroupPanel.FontStyleDelta"), System.Drawing.FontStyle)
        Me.GVSERIE.Appearance.GroupPanel.ForeColor = CType(resources.GetObject("GVSERIE.Appearance.GroupPanel.ForeColor"), System.Drawing.Color)
        Me.GVSERIE.Appearance.GroupPanel.GradientMode = CType(resources.GetObject("GVSERIE.Appearance.GroupPanel.GradientMode"), System.Drawing.Drawing2D.LinearGradientMode)
        Me.GVSERIE.Appearance.GroupPanel.Image = CType(resources.GetObject("GVSERIE.Appearance.GroupPanel.Image"), System.Drawing.Image)
        Me.GVSERIE.Appearance.GroupPanel.Options.UseBackColor = True
        Me.GVSERIE.Appearance.GroupPanel.Options.UseForeColor = True
        Me.GVSERIE.Appearance.GroupRow.BackColor = CType(resources.GetObject("GVSERIE.Appearance.GroupRow.BackColor"), System.Drawing.Color)
        Me.GVSERIE.Appearance.GroupRow.BorderColor = CType(resources.GetObject("GVSERIE.Appearance.GroupRow.BorderColor"), System.Drawing.Color)
        Me.GVSERIE.Appearance.GroupRow.FontSizeDelta = CType(resources.GetObject("GVSERIE.Appearance.GroupRow.FontSizeDelta"), Integer)
        Me.GVSERIE.Appearance.GroupRow.FontStyleDelta = CType(resources.GetObject("GVSERIE.Appearance.GroupRow.FontStyleDelta"), System.Drawing.FontStyle)
        Me.GVSERIE.Appearance.GroupRow.ForeColor = CType(resources.GetObject("GVSERIE.Appearance.GroupRow.ForeColor"), System.Drawing.Color)
        Me.GVSERIE.Appearance.GroupRow.GradientMode = CType(resources.GetObject("GVSERIE.Appearance.GroupRow.GradientMode"), System.Drawing.Drawing2D.LinearGradientMode)
        Me.GVSERIE.Appearance.GroupRow.Image = CType(resources.GetObject("GVSERIE.Appearance.GroupRow.Image"), System.Drawing.Image)
        Me.GVSERIE.Appearance.GroupRow.Options.UseBackColor = True
        Me.GVSERIE.Appearance.GroupRow.Options.UseBorderColor = True
        Me.GVSERIE.Appearance.GroupRow.Options.UseForeColor = True
        Me.GVSERIE.Appearance.HeaderPanel.BackColor = CType(resources.GetObject("GVSERIE.Appearance.HeaderPanel.BackColor"), System.Drawing.Color)
        Me.GVSERIE.Appearance.HeaderPanel.BorderColor = CType(resources.GetObject("GVSERIE.Appearance.HeaderPanel.BorderColor"), System.Drawing.Color)
        Me.GVSERIE.Appearance.HeaderPanel.FontSizeDelta = CType(resources.GetObject("GVSERIE.Appearance.HeaderPanel.FontSizeDelta"), Integer)
        Me.GVSERIE.Appearance.HeaderPanel.FontStyleDelta = CType(resources.GetObject("GVSERIE.Appearance.HeaderPanel.FontStyleDelta"), System.Drawing.FontStyle)
        Me.GVSERIE.Appearance.HeaderPanel.ForeColor = CType(resources.GetObject("GVSERIE.Appearance.HeaderPanel.ForeColor"), System.Drawing.Color)
        Me.GVSERIE.Appearance.HeaderPanel.GradientMode = CType(resources.GetObject("GVSERIE.Appearance.HeaderPanel.GradientMode"), System.Drawing.Drawing2D.LinearGradientMode)
        Me.GVSERIE.Appearance.HeaderPanel.Image = CType(resources.GetObject("GVSERIE.Appearance.HeaderPanel.Image"), System.Drawing.Image)
        Me.GVSERIE.Appearance.HeaderPanel.Options.UseBackColor = True
        Me.GVSERIE.Appearance.HeaderPanel.Options.UseBorderColor = True
        Me.GVSERIE.Appearance.HeaderPanel.Options.UseForeColor = True
        Me.GVSERIE.Appearance.HideSelectionRow.BackColor = CType(resources.GetObject("GVSERIE.Appearance.HideSelectionRow.BackColor"), System.Drawing.Color)
        Me.GVSERIE.Appearance.HideSelectionRow.FontSizeDelta = CType(resources.GetObject("GVSERIE.Appearance.HideSelectionRow.FontSizeDelta"), Integer)
        Me.GVSERIE.Appearance.HideSelectionRow.FontStyleDelta = CType(resources.GetObject("GVSERIE.Appearance.HideSelectionRow.FontStyleDelta"), System.Drawing.FontStyle)
        Me.GVSERIE.Appearance.HideSelectionRow.ForeColor = CType(resources.GetObject("GVSERIE.Appearance.HideSelectionRow.ForeColor"), System.Drawing.Color)
        Me.GVSERIE.Appearance.HideSelectionRow.GradientMode = CType(resources.GetObject("GVSERIE.Appearance.HideSelectionRow.GradientMode"), System.Drawing.Drawing2D.LinearGradientMode)
        Me.GVSERIE.Appearance.HideSelectionRow.Image = CType(resources.GetObject("GVSERIE.Appearance.HideSelectionRow.Image"), System.Drawing.Image)
        Me.GVSERIE.Appearance.HideSelectionRow.Options.UseBackColor = True
        Me.GVSERIE.Appearance.HideSelectionRow.Options.UseForeColor = True
        Me.GVSERIE.Appearance.HorzLine.BackColor = CType(resources.GetObject("GVSERIE.Appearance.HorzLine.BackColor"), System.Drawing.Color)
        Me.GVSERIE.Appearance.HorzLine.BorderColor = CType(resources.GetObject("GVSERIE.Appearance.HorzLine.BorderColor"), System.Drawing.Color)
        Me.GVSERIE.Appearance.HorzLine.FontSizeDelta = CType(resources.GetObject("GVSERIE.Appearance.HorzLine.FontSizeDelta"), Integer)
        Me.GVSERIE.Appearance.HorzLine.FontStyleDelta = CType(resources.GetObject("GVSERIE.Appearance.HorzLine.FontStyleDelta"), System.Drawing.FontStyle)
        Me.GVSERIE.Appearance.HorzLine.GradientMode = CType(resources.GetObject("GVSERIE.Appearance.HorzLine.GradientMode"), System.Drawing.Drawing2D.LinearGradientMode)
        Me.GVSERIE.Appearance.HorzLine.Image = CType(resources.GetObject("GVSERIE.Appearance.HorzLine.Image"), System.Drawing.Image)
        Me.GVSERIE.Appearance.HorzLine.Options.UseBackColor = True
        Me.GVSERIE.Appearance.HorzLine.Options.UseBorderColor = True
        Me.GVSERIE.Appearance.OddRow.BackColor = CType(resources.GetObject("GVSERIE.Appearance.OddRow.BackColor"), System.Drawing.Color)
        Me.GVSERIE.Appearance.OddRow.BorderColor = CType(resources.GetObject("GVSERIE.Appearance.OddRow.BorderColor"), System.Drawing.Color)
        Me.GVSERIE.Appearance.OddRow.FontSizeDelta = CType(resources.GetObject("GVSERIE.Appearance.OddRow.FontSizeDelta"), Integer)
        Me.GVSERIE.Appearance.OddRow.FontStyleDelta = CType(resources.GetObject("GVSERIE.Appearance.OddRow.FontStyleDelta"), System.Drawing.FontStyle)
        Me.GVSERIE.Appearance.OddRow.ForeColor = CType(resources.GetObject("GVSERIE.Appearance.OddRow.ForeColor"), System.Drawing.Color)
        Me.GVSERIE.Appearance.OddRow.GradientMode = CType(resources.GetObject("GVSERIE.Appearance.OddRow.GradientMode"), System.Drawing.Drawing2D.LinearGradientMode)
        Me.GVSERIE.Appearance.OddRow.Image = CType(resources.GetObject("GVSERIE.Appearance.OddRow.Image"), System.Drawing.Image)
        Me.GVSERIE.Appearance.OddRow.Options.UseBackColor = True
        Me.GVSERIE.Appearance.OddRow.Options.UseBorderColor = True
        Me.GVSERIE.Appearance.OddRow.Options.UseForeColor = True
        Me.GVSERIE.Appearance.Preview.BackColor = CType(resources.GetObject("GVSERIE.Appearance.Preview.BackColor"), System.Drawing.Color)
        Me.GVSERIE.Appearance.Preview.Font = CType(resources.GetObject("GVSERIE.Appearance.Preview.Font"), System.Drawing.Font)
        Me.GVSERIE.Appearance.Preview.FontSizeDelta = CType(resources.GetObject("GVSERIE.Appearance.Preview.FontSizeDelta"), Integer)
        Me.GVSERIE.Appearance.Preview.FontStyleDelta = CType(resources.GetObject("GVSERIE.Appearance.Preview.FontStyleDelta"), System.Drawing.FontStyle)
        Me.GVSERIE.Appearance.Preview.ForeColor = CType(resources.GetObject("GVSERIE.Appearance.Preview.ForeColor"), System.Drawing.Color)
        Me.GVSERIE.Appearance.Preview.GradientMode = CType(resources.GetObject("GVSERIE.Appearance.Preview.GradientMode"), System.Drawing.Drawing2D.LinearGradientMode)
        Me.GVSERIE.Appearance.Preview.Image = CType(resources.GetObject("GVSERIE.Appearance.Preview.Image"), System.Drawing.Image)
        Me.GVSERIE.Appearance.Preview.Options.UseBackColor = True
        Me.GVSERIE.Appearance.Preview.Options.UseFont = True
        Me.GVSERIE.Appearance.Preview.Options.UseForeColor = True
        Me.GVSERIE.Appearance.Row.BackColor = CType(resources.GetObject("GVSERIE.Appearance.Row.BackColor"), System.Drawing.Color)
        Me.GVSERIE.Appearance.Row.FontSizeDelta = CType(resources.GetObject("GVSERIE.Appearance.Row.FontSizeDelta"), Integer)
        Me.GVSERIE.Appearance.Row.FontStyleDelta = CType(resources.GetObject("GVSERIE.Appearance.Row.FontStyleDelta"), System.Drawing.FontStyle)
        Me.GVSERIE.Appearance.Row.ForeColor = CType(resources.GetObject("GVSERIE.Appearance.Row.ForeColor"), System.Drawing.Color)
        Me.GVSERIE.Appearance.Row.GradientMode = CType(resources.GetObject("GVSERIE.Appearance.Row.GradientMode"), System.Drawing.Drawing2D.LinearGradientMode)
        Me.GVSERIE.Appearance.Row.Image = CType(resources.GetObject("GVSERIE.Appearance.Row.Image"), System.Drawing.Image)
        Me.GVSERIE.Appearance.Row.Options.UseBackColor = True
        Me.GVSERIE.Appearance.Row.Options.UseForeColor = True
        Me.GVSERIE.Appearance.RowSeparator.BackColor = CType(resources.GetObject("GVSERIE.Appearance.RowSeparator.BackColor"), System.Drawing.Color)
        Me.GVSERIE.Appearance.RowSeparator.BackColor2 = CType(resources.GetObject("GVSERIE.Appearance.RowSeparator.BackColor2"), System.Drawing.Color)
        Me.GVSERIE.Appearance.RowSeparator.FontSizeDelta = CType(resources.GetObject("GVSERIE.Appearance.RowSeparator.FontSizeDelta"), Integer)
        Me.GVSERIE.Appearance.RowSeparator.FontStyleDelta = CType(resources.GetObject("GVSERIE.Appearance.RowSeparator.FontStyleDelta"), System.Drawing.FontStyle)
        Me.GVSERIE.Appearance.RowSeparator.GradientMode = CType(resources.GetObject("GVSERIE.Appearance.RowSeparator.GradientMode"), System.Drawing.Drawing2D.LinearGradientMode)
        Me.GVSERIE.Appearance.RowSeparator.Image = CType(resources.GetObject("GVSERIE.Appearance.RowSeparator.Image"), System.Drawing.Image)
        Me.GVSERIE.Appearance.RowSeparator.Options.UseBackColor = True
        Me.GVSERIE.Appearance.SelectedRow.BackColor = CType(resources.GetObject("GVSERIE.Appearance.SelectedRow.BackColor"), System.Drawing.Color)
        Me.GVSERIE.Appearance.SelectedRow.FontSizeDelta = CType(resources.GetObject("GVSERIE.Appearance.SelectedRow.FontSizeDelta"), Integer)
        Me.GVSERIE.Appearance.SelectedRow.FontStyleDelta = CType(resources.GetObject("GVSERIE.Appearance.SelectedRow.FontStyleDelta"), System.Drawing.FontStyle)
        Me.GVSERIE.Appearance.SelectedRow.ForeColor = CType(resources.GetObject("GVSERIE.Appearance.SelectedRow.ForeColor"), System.Drawing.Color)
        Me.GVSERIE.Appearance.SelectedRow.GradientMode = CType(resources.GetObject("GVSERIE.Appearance.SelectedRow.GradientMode"), System.Drawing.Drawing2D.LinearGradientMode)
        Me.GVSERIE.Appearance.SelectedRow.Image = CType(resources.GetObject("GVSERIE.Appearance.SelectedRow.Image"), System.Drawing.Image)
        Me.GVSERIE.Appearance.SelectedRow.Options.UseBackColor = True
        Me.GVSERIE.Appearance.SelectedRow.Options.UseForeColor = True
        Me.GVSERIE.Appearance.TopNewRow.BackColor = CType(resources.GetObject("GVSERIE.Appearance.TopNewRow.BackColor"), System.Drawing.Color)
        Me.GVSERIE.Appearance.TopNewRow.FontSizeDelta = CType(resources.GetObject("GVSERIE.Appearance.TopNewRow.FontSizeDelta"), Integer)
        Me.GVSERIE.Appearance.TopNewRow.FontStyleDelta = CType(resources.GetObject("GVSERIE.Appearance.TopNewRow.FontStyleDelta"), System.Drawing.FontStyle)
        Me.GVSERIE.Appearance.TopNewRow.GradientMode = CType(resources.GetObject("GVSERIE.Appearance.TopNewRow.GradientMode"), System.Drawing.Drawing2D.LinearGradientMode)
        Me.GVSERIE.Appearance.TopNewRow.Image = CType(resources.GetObject("GVSERIE.Appearance.TopNewRow.Image"), System.Drawing.Image)
        Me.GVSERIE.Appearance.TopNewRow.Options.UseBackColor = True
        Me.GVSERIE.Appearance.VertLine.BackColor = CType(resources.GetObject("GVSERIE.Appearance.VertLine.BackColor"), System.Drawing.Color)
        Me.GVSERIE.Appearance.VertLine.BorderColor = CType(resources.GetObject("GVSERIE.Appearance.VertLine.BorderColor"), System.Drawing.Color)
        Me.GVSERIE.Appearance.VertLine.FontSizeDelta = CType(resources.GetObject("GVSERIE.Appearance.VertLine.FontSizeDelta"), Integer)
        Me.GVSERIE.Appearance.VertLine.FontStyleDelta = CType(resources.GetObject("GVSERIE.Appearance.VertLine.FontStyleDelta"), System.Drawing.FontStyle)
        Me.GVSERIE.Appearance.VertLine.GradientMode = CType(resources.GetObject("GVSERIE.Appearance.VertLine.GradientMode"), System.Drawing.Drawing2D.LinearGradientMode)
        Me.GVSERIE.Appearance.VertLine.Image = CType(resources.GetObject("GVSERIE.Appearance.VertLine.Image"), System.Drawing.Image)
        Me.GVSERIE.Appearance.VertLine.Options.UseBackColor = True
        Me.GVSERIE.Appearance.VertLine.Options.UseBorderColor = True
        resources.ApplyResources(Me.GVSERIE, "GVSERIE")
        Me.GVSERIE.Columns.AddRange(New DevExpress.XtraGrid.Columns.GridColumn() {Me.ColSERIEVLIB, Me.ColSERIEMO, Me.ColSERIEFOU, Me.ColSERIEDEBOURSE})
        Me.GVSERIE.GridControl = Me.GCSERIE
        Me.GVSERIE.Name = "GVSERIE"
        Me.GVSERIE.OptionsBehavior.Editable = False
        Me.GVSERIE.OptionsBehavior.ReadOnly = True
        Me.GVSERIE.OptionsView.EnableAppearanceEvenRow = True
        Me.GVSERIE.OptionsView.EnableAppearanceOddRow = True
        Me.GVSERIE.OptionsView.ShowFooter = True
        Me.GVSERIE.OptionsView.ShowGroupPanel = False
        '
        'ColSERIEVLIB
        '
        Me.ColSERIEVLIB.AppearanceHeader.FontSizeDelta = CType(resources.GetObject("ColSERIEVLIB.AppearanceHeader.FontSizeDelta"), Integer)
        Me.ColSERIEVLIB.AppearanceHeader.FontStyleDelta = CType(resources.GetObject("ColSERIEVLIB.AppearanceHeader.FontStyleDelta"), System.Drawing.FontStyle)
        Me.ColSERIEVLIB.AppearanceHeader.GradientMode = CType(resources.GetObject("ColSERIEVLIB.AppearanceHeader.GradientMode"), System.Drawing.Drawing2D.LinearGradientMode)
        Me.ColSERIEVLIB.AppearanceHeader.Image = CType(resources.GetObject("ColSERIEVLIB.AppearanceHeader.Image"), System.Drawing.Image)
        Me.ColSERIEVLIB.AppearanceHeader.Options.UseTextOptions = True
        Me.ColSERIEVLIB.AppearanceHeader.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center
        Me.ColSERIEVLIB.AppearanceHeader.TextOptions.VAlignment = DevExpress.Utils.VertAlignment.Center
        resources.ApplyResources(Me.ColSERIEVLIB, "ColSERIEVLIB")
        Me.ColSERIEVLIB.FieldName = "VLIB"
        Me.ColSERIEVLIB.Name = "ColSERIEVLIB"
        '
        'ColSERIEMO
        '
        Me.ColSERIEMO.AppearanceHeader.FontSizeDelta = CType(resources.GetObject("ColSERIEMO.AppearanceHeader.FontSizeDelta"), Integer)
        Me.ColSERIEMO.AppearanceHeader.FontStyleDelta = CType(resources.GetObject("ColSERIEMO.AppearanceHeader.FontStyleDelta"), System.Drawing.FontStyle)
        Me.ColSERIEMO.AppearanceHeader.GradientMode = CType(resources.GetObject("ColSERIEMO.AppearanceHeader.GradientMode"), System.Drawing.Drawing2D.LinearGradientMode)
        Me.ColSERIEMO.AppearanceHeader.Image = CType(resources.GetObject("ColSERIEMO.AppearanceHeader.Image"), System.Drawing.Image)
        Me.ColSERIEMO.AppearanceHeader.Options.UseTextOptions = True
        Me.ColSERIEMO.AppearanceHeader.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center
        Me.ColSERIEMO.AppearanceHeader.TextOptions.VAlignment = DevExpress.Utils.VertAlignment.Center
        resources.ApplyResources(Me.ColSERIEMO, "ColSERIEMO")
        Me.ColSERIEMO.DisplayFormat.FormatString = "n2"
        Me.ColSERIEMO.DisplayFormat.FormatType = DevExpress.Utils.FormatType.Numeric
        Me.ColSERIEMO.FieldName = "MO"
        Me.ColSERIEMO.Name = "ColSERIEMO"
        Me.ColSERIEMO.Summary.AddRange(New DevExpress.XtraGrid.GridSummaryItem() {New DevExpress.XtraGrid.GridColumnSummaryItem(CType(resources.GetObject("ColSERIEMO.Summary"), DevExpress.Data.SummaryItemType), resources.GetString("ColSERIEMO.Summary1"), resources.GetString("ColSERIEMO.Summary2"))})
        '
        'ColSERIEFOU
        '
        Me.ColSERIEFOU.AppearanceHeader.FontSizeDelta = CType(resources.GetObject("ColSERIEFOU.AppearanceHeader.FontSizeDelta"), Integer)
        Me.ColSERIEFOU.AppearanceHeader.FontStyleDelta = CType(resources.GetObject("ColSERIEFOU.AppearanceHeader.FontStyleDelta"), System.Drawing.FontStyle)
        Me.ColSERIEFOU.AppearanceHeader.GradientMode = CType(resources.GetObject("ColSERIEFOU.AppearanceHeader.GradientMode"), System.Drawing.Drawing2D.LinearGradientMode)
        Me.ColSERIEFOU.AppearanceHeader.Image = CType(resources.GetObject("ColSERIEFOU.AppearanceHeader.Image"), System.Drawing.Image)
        Me.ColSERIEFOU.AppearanceHeader.Options.UseTextOptions = True
        Me.ColSERIEFOU.AppearanceHeader.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center
        Me.ColSERIEFOU.AppearanceHeader.TextOptions.VAlignment = DevExpress.Utils.VertAlignment.Center
        resources.ApplyResources(Me.ColSERIEFOU, "ColSERIEFOU")
        Me.ColSERIEFOU.DisplayFormat.FormatString = "c2"
        Me.ColSERIEFOU.DisplayFormat.FormatType = DevExpress.Utils.FormatType.Numeric
        Me.ColSERIEFOU.FieldName = "FOU"
        Me.ColSERIEFOU.Name = "ColSERIEFOU"
        Me.ColSERIEFOU.Summary.AddRange(New DevExpress.XtraGrid.GridSummaryItem() {New DevExpress.XtraGrid.GridColumnSummaryItem(CType(resources.GetObject("ColSERIEFOU.Summary"), DevExpress.Data.SummaryItemType), resources.GetString("ColSERIEFOU.Summary1"), resources.GetString("ColSERIEFOU.Summary2"))})
        '
        'ColSERIEDEBOURSE
        '
        Me.ColSERIEDEBOURSE.AppearanceHeader.FontSizeDelta = CType(resources.GetObject("ColSERIEDEBOURSE.AppearanceHeader.FontSizeDelta"), Integer)
        Me.ColSERIEDEBOURSE.AppearanceHeader.FontStyleDelta = CType(resources.GetObject("ColSERIEDEBOURSE.AppearanceHeader.FontStyleDelta"), System.Drawing.FontStyle)
        Me.ColSERIEDEBOURSE.AppearanceHeader.GradientMode = CType(resources.GetObject("ColSERIEDEBOURSE.AppearanceHeader.GradientMode"), System.Drawing.Drawing2D.LinearGradientMode)
        Me.ColSERIEDEBOURSE.AppearanceHeader.Image = CType(resources.GetObject("ColSERIEDEBOURSE.AppearanceHeader.Image"), System.Drawing.Image)
        Me.ColSERIEDEBOURSE.AppearanceHeader.Options.UseTextOptions = True
        Me.ColSERIEDEBOURSE.AppearanceHeader.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center
        Me.ColSERIEDEBOURSE.AppearanceHeader.TextOptions.VAlignment = DevExpress.Utils.VertAlignment.Center
        resources.ApplyResources(Me.ColSERIEDEBOURSE, "ColSERIEDEBOURSE")
        Me.ColSERIEDEBOURSE.DisplayFormat.FormatString = "c2"
        Me.ColSERIEDEBOURSE.DisplayFormat.FormatType = DevExpress.Utils.FormatType.Numeric
        Me.ColSERIEDEBOURSE.FieldName = "DEBOURSE"
        Me.ColSERIEDEBOURSE.Name = "ColSERIEDEBOURSE"
        Me.ColSERIEDEBOURSE.Summary.AddRange(New DevExpress.XtraGrid.GridSummaryItem() {New DevExpress.XtraGrid.GridColumnSummaryItem(CType(resources.GetObject("ColSERIEDEBOURSE.Summary"), DevExpress.Data.SummaryItemType), resources.GetString("ColSERIEDEBOURSE.Summary1"), resources.GetString("ColSERIEDEBOURSE.Summary2"))})
        '
        'SFD
        '
        resources.ApplyResources(Me.SFD, "SFD")
        '
        'GrpBoxDecoupMO
        '
        resources.ApplyResources(Me.GrpBoxDecoupMO, "GrpBoxDecoupMO")
        Me.GrpBoxDecoupMO.Controls.Add(Me.BtnExportDecoupMOXLS)
        Me.GrpBoxDecoupMO.Controls.Add(Me.GCDECOUPMO)
        Me.GrpBoxDecoupMO.Name = "GrpBoxDecoupMO"
        Me.GrpBoxDecoupMO.TabStop = False
        '
        'BtnExportDecoupMOXLS
        '
        resources.ApplyResources(Me.BtnExportDecoupMOXLS, "BtnExportDecoupMOXLS")
        Me.BtnExportDecoupMOXLS.Name = "BtnExportDecoupMOXLS"
        Me.BtnExportDecoupMOXLS.UseVisualStyleBackColor = True
        '
        'GCDECOUPMO
        '
        resources.ApplyResources(Me.GCDECOUPMO, "GCDECOUPMO")
        '
        '
        '
        Me.GCDECOUPMO.EmbeddedNavigator.AccessibleDescription = resources.GetString("GCDECOUPMO.EmbeddedNavigator.AccessibleDescription")
        Me.GCDECOUPMO.EmbeddedNavigator.AccessibleName = resources.GetString("GCDECOUPMO.EmbeddedNavigator.AccessibleName")
        Me.GCDECOUPMO.EmbeddedNavigator.AllowHtmlTextInToolTip = CType(resources.GetObject("GCDECOUPMO.EmbeddedNavigator.AllowHtmlTextInToolTip"), DevExpress.Utils.DefaultBoolean)
        Me.GCDECOUPMO.EmbeddedNavigator.Anchor = CType(resources.GetObject("GCDECOUPMO.EmbeddedNavigator.Anchor"), System.Windows.Forms.AnchorStyles)
        Me.GCDECOUPMO.EmbeddedNavigator.BackgroundImage = CType(resources.GetObject("GCDECOUPMO.EmbeddedNavigator.BackgroundImage"), System.Drawing.Image)
        Me.GCDECOUPMO.EmbeddedNavigator.BackgroundImageLayout = CType(resources.GetObject("GCDECOUPMO.EmbeddedNavigator.BackgroundImageLayout"), System.Windows.Forms.ImageLayout)
        Me.GCDECOUPMO.EmbeddedNavigator.ImeMode = CType(resources.GetObject("GCDECOUPMO.EmbeddedNavigator.ImeMode"), System.Windows.Forms.ImeMode)
        Me.GCDECOUPMO.EmbeddedNavigator.MaximumSize = CType(resources.GetObject("GCDECOUPMO.EmbeddedNavigator.MaximumSize"), System.Drawing.Size)
        Me.GCDECOUPMO.EmbeddedNavigator.TextLocation = CType(resources.GetObject("GCDECOUPMO.EmbeddedNavigator.TextLocation"), DevExpress.XtraEditors.NavigatorButtonsTextLocation)
        Me.GCDECOUPMO.EmbeddedNavigator.ToolTip = resources.GetString("GCDECOUPMO.EmbeddedNavigator.ToolTip")
        Me.GCDECOUPMO.EmbeddedNavigator.ToolTipIconType = CType(resources.GetObject("GCDECOUPMO.EmbeddedNavigator.ToolTipIconType"), DevExpress.Utils.ToolTipIconType)
        Me.GCDECOUPMO.EmbeddedNavigator.ToolTipTitle = resources.GetString("GCDECOUPMO.EmbeddedNavigator.ToolTipTitle")
        Me.GCDECOUPMO.MainView = Me.GVDECOUPMO
        Me.GCDECOUPMO.Name = "GCDECOUPMO"
        Me.GCDECOUPMO.ViewCollection.AddRange(New DevExpress.XtraGrid.Views.Base.BaseView() {Me.GVDECOUPMO})
        '
        'GVDECOUPMO
        '
        Me.GVDECOUPMO.Appearance.ColumnFilterButton.BackColor = CType(resources.GetObject("GVDECOUPMO.Appearance.ColumnFilterButton.BackColor"), System.Drawing.Color)
        Me.GVDECOUPMO.Appearance.ColumnFilterButton.BorderColor = CType(resources.GetObject("GVDECOUPMO.Appearance.ColumnFilterButton.BorderColor"), System.Drawing.Color)
        Me.GVDECOUPMO.Appearance.ColumnFilterButton.FontSizeDelta = CType(resources.GetObject("GVDECOUPMO.Appearance.ColumnFilterButton.FontSizeDelta"), Integer)
        Me.GVDECOUPMO.Appearance.ColumnFilterButton.FontStyleDelta = CType(resources.GetObject("GVDECOUPMO.Appearance.ColumnFilterButton.FontStyleDelta"), System.Drawing.FontStyle)
        Me.GVDECOUPMO.Appearance.ColumnFilterButton.ForeColor = CType(resources.GetObject("GVDECOUPMO.Appearance.ColumnFilterButton.ForeColor"), System.Drawing.Color)
        Me.GVDECOUPMO.Appearance.ColumnFilterButton.GradientMode = CType(resources.GetObject("GVDECOUPMO.Appearance.ColumnFilterButton.GradientMode"), System.Drawing.Drawing2D.LinearGradientMode)
        Me.GVDECOUPMO.Appearance.ColumnFilterButton.Image = CType(resources.GetObject("GVDECOUPMO.Appearance.ColumnFilterButton.Image"), System.Drawing.Image)
        Me.GVDECOUPMO.Appearance.ColumnFilterButton.Options.UseBackColor = True
        Me.GVDECOUPMO.Appearance.ColumnFilterButton.Options.UseBorderColor = True
        Me.GVDECOUPMO.Appearance.ColumnFilterButton.Options.UseForeColor = True
        Me.GVDECOUPMO.Appearance.ColumnFilterButtonActive.BackColor = CType(resources.GetObject("GVDECOUPMO.Appearance.ColumnFilterButtonActive.BackColor"), System.Drawing.Color)
        Me.GVDECOUPMO.Appearance.ColumnFilterButtonActive.BorderColor = CType(resources.GetObject("GVDECOUPMO.Appearance.ColumnFilterButtonActive.BorderColor"), System.Drawing.Color)
        Me.GVDECOUPMO.Appearance.ColumnFilterButtonActive.FontSizeDelta = CType(resources.GetObject("GVDECOUPMO.Appearance.ColumnFilterButtonActive.FontSizeDelta"), Integer)
        Me.GVDECOUPMO.Appearance.ColumnFilterButtonActive.FontStyleDelta = CType(resources.GetObject("GVDECOUPMO.Appearance.ColumnFilterButtonActive.FontStyleDelta"), System.Drawing.FontStyle)
        Me.GVDECOUPMO.Appearance.ColumnFilterButtonActive.ForeColor = CType(resources.GetObject("GVDECOUPMO.Appearance.ColumnFilterButtonActive.ForeColor"), System.Drawing.Color)
        Me.GVDECOUPMO.Appearance.ColumnFilterButtonActive.GradientMode = CType(resources.GetObject("GVDECOUPMO.Appearance.ColumnFilterButtonActive.GradientMode"), System.Drawing.Drawing2D.LinearGradientMode)
        Me.GVDECOUPMO.Appearance.ColumnFilterButtonActive.Image = CType(resources.GetObject("GVDECOUPMO.Appearance.ColumnFilterButtonActive.Image"), System.Drawing.Image)
        Me.GVDECOUPMO.Appearance.ColumnFilterButtonActive.Options.UseBackColor = True
        Me.GVDECOUPMO.Appearance.ColumnFilterButtonActive.Options.UseBorderColor = True
        Me.GVDECOUPMO.Appearance.ColumnFilterButtonActive.Options.UseForeColor = True
        Me.GVDECOUPMO.Appearance.Empty.BackColor = CType(resources.GetObject("GVDECOUPMO.Appearance.Empty.BackColor"), System.Drawing.Color)
        Me.GVDECOUPMO.Appearance.Empty.BackColor2 = CType(resources.GetObject("GVDECOUPMO.Appearance.Empty.BackColor2"), System.Drawing.Color)
        Me.GVDECOUPMO.Appearance.Empty.FontSizeDelta = CType(resources.GetObject("GVDECOUPMO.Appearance.Empty.FontSizeDelta"), Integer)
        Me.GVDECOUPMO.Appearance.Empty.FontStyleDelta = CType(resources.GetObject("GVDECOUPMO.Appearance.Empty.FontStyleDelta"), System.Drawing.FontStyle)
        Me.GVDECOUPMO.Appearance.Empty.GradientMode = CType(resources.GetObject("GVDECOUPMO.Appearance.Empty.GradientMode"), System.Drawing.Drawing2D.LinearGradientMode)
        Me.GVDECOUPMO.Appearance.Empty.Image = CType(resources.GetObject("GVDECOUPMO.Appearance.Empty.Image"), System.Drawing.Image)
        Me.GVDECOUPMO.Appearance.Empty.Options.UseBackColor = True
        Me.GVDECOUPMO.Appearance.EvenRow.BackColor = CType(resources.GetObject("GVDECOUPMO.Appearance.EvenRow.BackColor"), System.Drawing.Color)
        Me.GVDECOUPMO.Appearance.EvenRow.BorderColor = CType(resources.GetObject("GVDECOUPMO.Appearance.EvenRow.BorderColor"), System.Drawing.Color)
        Me.GVDECOUPMO.Appearance.EvenRow.FontSizeDelta = CType(resources.GetObject("GVDECOUPMO.Appearance.EvenRow.FontSizeDelta"), Integer)
        Me.GVDECOUPMO.Appearance.EvenRow.FontStyleDelta = CType(resources.GetObject("GVDECOUPMO.Appearance.EvenRow.FontStyleDelta"), System.Drawing.FontStyle)
        Me.GVDECOUPMO.Appearance.EvenRow.ForeColor = CType(resources.GetObject("GVDECOUPMO.Appearance.EvenRow.ForeColor"), System.Drawing.Color)
        Me.GVDECOUPMO.Appearance.EvenRow.GradientMode = CType(resources.GetObject("GVDECOUPMO.Appearance.EvenRow.GradientMode"), System.Drawing.Drawing2D.LinearGradientMode)
        Me.GVDECOUPMO.Appearance.EvenRow.Image = CType(resources.GetObject("GVDECOUPMO.Appearance.EvenRow.Image"), System.Drawing.Image)
        Me.GVDECOUPMO.Appearance.EvenRow.Options.UseBackColor = True
        Me.GVDECOUPMO.Appearance.EvenRow.Options.UseBorderColor = True
        Me.GVDECOUPMO.Appearance.EvenRow.Options.UseForeColor = True
        Me.GVDECOUPMO.Appearance.FilterCloseButton.BackColor = CType(resources.GetObject("GVDECOUPMO.Appearance.FilterCloseButton.BackColor"), System.Drawing.Color)
        Me.GVDECOUPMO.Appearance.FilterCloseButton.BorderColor = CType(resources.GetObject("GVDECOUPMO.Appearance.FilterCloseButton.BorderColor"), System.Drawing.Color)
        Me.GVDECOUPMO.Appearance.FilterCloseButton.FontSizeDelta = CType(resources.GetObject("GVDECOUPMO.Appearance.FilterCloseButton.FontSizeDelta"), Integer)
        Me.GVDECOUPMO.Appearance.FilterCloseButton.FontStyleDelta = CType(resources.GetObject("GVDECOUPMO.Appearance.FilterCloseButton.FontStyleDelta"), System.Drawing.FontStyle)
        Me.GVDECOUPMO.Appearance.FilterCloseButton.ForeColor = CType(resources.GetObject("GVDECOUPMO.Appearance.FilterCloseButton.ForeColor"), System.Drawing.Color)
        Me.GVDECOUPMO.Appearance.FilterCloseButton.GradientMode = CType(resources.GetObject("GVDECOUPMO.Appearance.FilterCloseButton.GradientMode"), System.Drawing.Drawing2D.LinearGradientMode)
        Me.GVDECOUPMO.Appearance.FilterCloseButton.Image = CType(resources.GetObject("GVDECOUPMO.Appearance.FilterCloseButton.Image"), System.Drawing.Image)
        Me.GVDECOUPMO.Appearance.FilterCloseButton.Options.UseBackColor = True
        Me.GVDECOUPMO.Appearance.FilterCloseButton.Options.UseBorderColor = True
        Me.GVDECOUPMO.Appearance.FilterCloseButton.Options.UseForeColor = True
        Me.GVDECOUPMO.Appearance.FilterPanel.BackColor = CType(resources.GetObject("GVDECOUPMO.Appearance.FilterPanel.BackColor"), System.Drawing.Color)
        Me.GVDECOUPMO.Appearance.FilterPanel.BackColor2 = CType(resources.GetObject("GVDECOUPMO.Appearance.FilterPanel.BackColor2"), System.Drawing.Color)
        Me.GVDECOUPMO.Appearance.FilterPanel.FontSizeDelta = CType(resources.GetObject("GVDECOUPMO.Appearance.FilterPanel.FontSizeDelta"), Integer)
        Me.GVDECOUPMO.Appearance.FilterPanel.FontStyleDelta = CType(resources.GetObject("GVDECOUPMO.Appearance.FilterPanel.FontStyleDelta"), System.Drawing.FontStyle)
        Me.GVDECOUPMO.Appearance.FilterPanel.ForeColor = CType(resources.GetObject("GVDECOUPMO.Appearance.FilterPanel.ForeColor"), System.Drawing.Color)
        Me.GVDECOUPMO.Appearance.FilterPanel.GradientMode = CType(resources.GetObject("GVDECOUPMO.Appearance.FilterPanel.GradientMode"), System.Drawing.Drawing2D.LinearGradientMode)
        Me.GVDECOUPMO.Appearance.FilterPanel.Image = CType(resources.GetObject("GVDECOUPMO.Appearance.FilterPanel.Image"), System.Drawing.Image)
        Me.GVDECOUPMO.Appearance.FilterPanel.Options.UseBackColor = True
        Me.GVDECOUPMO.Appearance.FilterPanel.Options.UseForeColor = True
        Me.GVDECOUPMO.Appearance.FixedLine.BackColor = CType(resources.GetObject("GVDECOUPMO.Appearance.FixedLine.BackColor"), System.Drawing.Color)
        Me.GVDECOUPMO.Appearance.FixedLine.FontSizeDelta = CType(resources.GetObject("GVDECOUPMO.Appearance.FixedLine.FontSizeDelta"), Integer)
        Me.GVDECOUPMO.Appearance.FixedLine.FontStyleDelta = CType(resources.GetObject("GVDECOUPMO.Appearance.FixedLine.FontStyleDelta"), System.Drawing.FontStyle)
        Me.GVDECOUPMO.Appearance.FixedLine.GradientMode = CType(resources.GetObject("GVDECOUPMO.Appearance.FixedLine.GradientMode"), System.Drawing.Drawing2D.LinearGradientMode)
        Me.GVDECOUPMO.Appearance.FixedLine.Image = CType(resources.GetObject("GVDECOUPMO.Appearance.FixedLine.Image"), System.Drawing.Image)
        Me.GVDECOUPMO.Appearance.FixedLine.Options.UseBackColor = True
        Me.GVDECOUPMO.Appearance.FocusedCell.BackColor = CType(resources.GetObject("GVDECOUPMO.Appearance.FocusedCell.BackColor"), System.Drawing.Color)
        Me.GVDECOUPMO.Appearance.FocusedCell.FontSizeDelta = CType(resources.GetObject("GVDECOUPMO.Appearance.FocusedCell.FontSizeDelta"), Integer)
        Me.GVDECOUPMO.Appearance.FocusedCell.FontStyleDelta = CType(resources.GetObject("GVDECOUPMO.Appearance.FocusedCell.FontStyleDelta"), System.Drawing.FontStyle)
        Me.GVDECOUPMO.Appearance.FocusedCell.ForeColor = CType(resources.GetObject("GVDECOUPMO.Appearance.FocusedCell.ForeColor"), System.Drawing.Color)
        Me.GVDECOUPMO.Appearance.FocusedCell.GradientMode = CType(resources.GetObject("GVDECOUPMO.Appearance.FocusedCell.GradientMode"), System.Drawing.Drawing2D.LinearGradientMode)
        Me.GVDECOUPMO.Appearance.FocusedCell.Image = CType(resources.GetObject("GVDECOUPMO.Appearance.FocusedCell.Image"), System.Drawing.Image)
        Me.GVDECOUPMO.Appearance.FocusedCell.Options.UseBackColor = True
        Me.GVDECOUPMO.Appearance.FocusedCell.Options.UseForeColor = True
        Me.GVDECOUPMO.Appearance.FocusedRow.BackColor = CType(resources.GetObject("GVDECOUPMO.Appearance.FocusedRow.BackColor"), System.Drawing.Color)
        Me.GVDECOUPMO.Appearance.FocusedRow.FontSizeDelta = CType(resources.GetObject("GVDECOUPMO.Appearance.FocusedRow.FontSizeDelta"), Integer)
        Me.GVDECOUPMO.Appearance.FocusedRow.FontStyleDelta = CType(resources.GetObject("GVDECOUPMO.Appearance.FocusedRow.FontStyleDelta"), System.Drawing.FontStyle)
        Me.GVDECOUPMO.Appearance.FocusedRow.ForeColor = CType(resources.GetObject("GVDECOUPMO.Appearance.FocusedRow.ForeColor"), System.Drawing.Color)
        Me.GVDECOUPMO.Appearance.FocusedRow.GradientMode = CType(resources.GetObject("GVDECOUPMO.Appearance.FocusedRow.GradientMode"), System.Drawing.Drawing2D.LinearGradientMode)
        Me.GVDECOUPMO.Appearance.FocusedRow.Image = CType(resources.GetObject("GVDECOUPMO.Appearance.FocusedRow.Image"), System.Drawing.Image)
        Me.GVDECOUPMO.Appearance.FocusedRow.Options.UseBackColor = True
        Me.GVDECOUPMO.Appearance.FocusedRow.Options.UseForeColor = True
        Me.GVDECOUPMO.Appearance.FooterPanel.BackColor = CType(resources.GetObject("GVDECOUPMO.Appearance.FooterPanel.BackColor"), System.Drawing.Color)
        Me.GVDECOUPMO.Appearance.FooterPanel.BorderColor = CType(resources.GetObject("GVDECOUPMO.Appearance.FooterPanel.BorderColor"), System.Drawing.Color)
        Me.GVDECOUPMO.Appearance.FooterPanel.FontSizeDelta = CType(resources.GetObject("GVDECOUPMO.Appearance.FooterPanel.FontSizeDelta"), Integer)
        Me.GVDECOUPMO.Appearance.FooterPanel.FontStyleDelta = CType(resources.GetObject("GVDECOUPMO.Appearance.FooterPanel.FontStyleDelta"), System.Drawing.FontStyle)
        Me.GVDECOUPMO.Appearance.FooterPanel.ForeColor = CType(resources.GetObject("GVDECOUPMO.Appearance.FooterPanel.ForeColor"), System.Drawing.Color)
        Me.GVDECOUPMO.Appearance.FooterPanel.GradientMode = CType(resources.GetObject("GVDECOUPMO.Appearance.FooterPanel.GradientMode"), System.Drawing.Drawing2D.LinearGradientMode)
        Me.GVDECOUPMO.Appearance.FooterPanel.Image = CType(resources.GetObject("GVDECOUPMO.Appearance.FooterPanel.Image"), System.Drawing.Image)
        Me.GVDECOUPMO.Appearance.FooterPanel.Options.UseBackColor = True
        Me.GVDECOUPMO.Appearance.FooterPanel.Options.UseBorderColor = True
        Me.GVDECOUPMO.Appearance.FooterPanel.Options.UseForeColor = True
        Me.GVDECOUPMO.Appearance.GroupButton.BackColor = CType(resources.GetObject("GVDECOUPMO.Appearance.GroupButton.BackColor"), System.Drawing.Color)
        Me.GVDECOUPMO.Appearance.GroupButton.BorderColor = CType(resources.GetObject("GVDECOUPMO.Appearance.GroupButton.BorderColor"), System.Drawing.Color)
        Me.GVDECOUPMO.Appearance.GroupButton.FontSizeDelta = CType(resources.GetObject("GVDECOUPMO.Appearance.GroupButton.FontSizeDelta"), Integer)
        Me.GVDECOUPMO.Appearance.GroupButton.FontStyleDelta = CType(resources.GetObject("GVDECOUPMO.Appearance.GroupButton.FontStyleDelta"), System.Drawing.FontStyle)
        Me.GVDECOUPMO.Appearance.GroupButton.GradientMode = CType(resources.GetObject("GVDECOUPMO.Appearance.GroupButton.GradientMode"), System.Drawing.Drawing2D.LinearGradientMode)
        Me.GVDECOUPMO.Appearance.GroupButton.Image = CType(resources.GetObject("GVDECOUPMO.Appearance.GroupButton.Image"), System.Drawing.Image)
        Me.GVDECOUPMO.Appearance.GroupButton.Options.UseBackColor = True
        Me.GVDECOUPMO.Appearance.GroupButton.Options.UseBorderColor = True
        Me.GVDECOUPMO.Appearance.GroupFooter.BackColor = CType(resources.GetObject("GVDECOUPMO.Appearance.GroupFooter.BackColor"), System.Drawing.Color)
        Me.GVDECOUPMO.Appearance.GroupFooter.BorderColor = CType(resources.GetObject("GVDECOUPMO.Appearance.GroupFooter.BorderColor"), System.Drawing.Color)
        Me.GVDECOUPMO.Appearance.GroupFooter.FontSizeDelta = CType(resources.GetObject("GVDECOUPMO.Appearance.GroupFooter.FontSizeDelta"), Integer)
        Me.GVDECOUPMO.Appearance.GroupFooter.FontStyleDelta = CType(resources.GetObject("GVDECOUPMO.Appearance.GroupFooter.FontStyleDelta"), System.Drawing.FontStyle)
        Me.GVDECOUPMO.Appearance.GroupFooter.ForeColor = CType(resources.GetObject("GVDECOUPMO.Appearance.GroupFooter.ForeColor"), System.Drawing.Color)
        Me.GVDECOUPMO.Appearance.GroupFooter.GradientMode = CType(resources.GetObject("GVDECOUPMO.Appearance.GroupFooter.GradientMode"), System.Drawing.Drawing2D.LinearGradientMode)
        Me.GVDECOUPMO.Appearance.GroupFooter.Image = CType(resources.GetObject("GVDECOUPMO.Appearance.GroupFooter.Image"), System.Drawing.Image)
        Me.GVDECOUPMO.Appearance.GroupFooter.Options.UseBackColor = True
        Me.GVDECOUPMO.Appearance.GroupFooter.Options.UseBorderColor = True
        Me.GVDECOUPMO.Appearance.GroupFooter.Options.UseForeColor = True
        Me.GVDECOUPMO.Appearance.GroupPanel.BackColor = CType(resources.GetObject("GVDECOUPMO.Appearance.GroupPanel.BackColor"), System.Drawing.Color)
        Me.GVDECOUPMO.Appearance.GroupPanel.BackColor2 = CType(resources.GetObject("GVDECOUPMO.Appearance.GroupPanel.BackColor2"), System.Drawing.Color)
        Me.GVDECOUPMO.Appearance.GroupPanel.FontSizeDelta = CType(resources.GetObject("GVDECOUPMO.Appearance.GroupPanel.FontSizeDelta"), Integer)
        Me.GVDECOUPMO.Appearance.GroupPanel.FontStyleDelta = CType(resources.GetObject("GVDECOUPMO.Appearance.GroupPanel.FontStyleDelta"), System.Drawing.FontStyle)
        Me.GVDECOUPMO.Appearance.GroupPanel.ForeColor = CType(resources.GetObject("GVDECOUPMO.Appearance.GroupPanel.ForeColor"), System.Drawing.Color)
        Me.GVDECOUPMO.Appearance.GroupPanel.GradientMode = CType(resources.GetObject("GVDECOUPMO.Appearance.GroupPanel.GradientMode"), System.Drawing.Drawing2D.LinearGradientMode)
        Me.GVDECOUPMO.Appearance.GroupPanel.Image = CType(resources.GetObject("GVDECOUPMO.Appearance.GroupPanel.Image"), System.Drawing.Image)
        Me.GVDECOUPMO.Appearance.GroupPanel.Options.UseBackColor = True
        Me.GVDECOUPMO.Appearance.GroupPanel.Options.UseForeColor = True
        Me.GVDECOUPMO.Appearance.GroupRow.BackColor = CType(resources.GetObject("GVDECOUPMO.Appearance.GroupRow.BackColor"), System.Drawing.Color)
        Me.GVDECOUPMO.Appearance.GroupRow.BorderColor = CType(resources.GetObject("GVDECOUPMO.Appearance.GroupRow.BorderColor"), System.Drawing.Color)
        Me.GVDECOUPMO.Appearance.GroupRow.FontSizeDelta = CType(resources.GetObject("GVDECOUPMO.Appearance.GroupRow.FontSizeDelta"), Integer)
        Me.GVDECOUPMO.Appearance.GroupRow.FontStyleDelta = CType(resources.GetObject("GVDECOUPMO.Appearance.GroupRow.FontStyleDelta"), System.Drawing.FontStyle)
        Me.GVDECOUPMO.Appearance.GroupRow.ForeColor = CType(resources.GetObject("GVDECOUPMO.Appearance.GroupRow.ForeColor"), System.Drawing.Color)
        Me.GVDECOUPMO.Appearance.GroupRow.GradientMode = CType(resources.GetObject("GVDECOUPMO.Appearance.GroupRow.GradientMode"), System.Drawing.Drawing2D.LinearGradientMode)
        Me.GVDECOUPMO.Appearance.GroupRow.Image = CType(resources.GetObject("GVDECOUPMO.Appearance.GroupRow.Image"), System.Drawing.Image)
        Me.GVDECOUPMO.Appearance.GroupRow.Options.UseBackColor = True
        Me.GVDECOUPMO.Appearance.GroupRow.Options.UseBorderColor = True
        Me.GVDECOUPMO.Appearance.GroupRow.Options.UseForeColor = True
        Me.GVDECOUPMO.Appearance.HeaderPanel.BackColor = CType(resources.GetObject("GVDECOUPMO.Appearance.HeaderPanel.BackColor"), System.Drawing.Color)
        Me.GVDECOUPMO.Appearance.HeaderPanel.BorderColor = CType(resources.GetObject("GVDECOUPMO.Appearance.HeaderPanel.BorderColor"), System.Drawing.Color)
        Me.GVDECOUPMO.Appearance.HeaderPanel.FontSizeDelta = CType(resources.GetObject("GVDECOUPMO.Appearance.HeaderPanel.FontSizeDelta"), Integer)
        Me.GVDECOUPMO.Appearance.HeaderPanel.FontStyleDelta = CType(resources.GetObject("GVDECOUPMO.Appearance.HeaderPanel.FontStyleDelta"), System.Drawing.FontStyle)
        Me.GVDECOUPMO.Appearance.HeaderPanel.ForeColor = CType(resources.GetObject("GVDECOUPMO.Appearance.HeaderPanel.ForeColor"), System.Drawing.Color)
        Me.GVDECOUPMO.Appearance.HeaderPanel.GradientMode = CType(resources.GetObject("GVDECOUPMO.Appearance.HeaderPanel.GradientMode"), System.Drawing.Drawing2D.LinearGradientMode)
        Me.GVDECOUPMO.Appearance.HeaderPanel.Image = CType(resources.GetObject("GVDECOUPMO.Appearance.HeaderPanel.Image"), System.Drawing.Image)
        Me.GVDECOUPMO.Appearance.HeaderPanel.Options.UseBackColor = True
        Me.GVDECOUPMO.Appearance.HeaderPanel.Options.UseBorderColor = True
        Me.GVDECOUPMO.Appearance.HeaderPanel.Options.UseForeColor = True
        Me.GVDECOUPMO.Appearance.HideSelectionRow.BackColor = CType(resources.GetObject("GVDECOUPMO.Appearance.HideSelectionRow.BackColor"), System.Drawing.Color)
        Me.GVDECOUPMO.Appearance.HideSelectionRow.FontSizeDelta = CType(resources.GetObject("GVDECOUPMO.Appearance.HideSelectionRow.FontSizeDelta"), Integer)
        Me.GVDECOUPMO.Appearance.HideSelectionRow.FontStyleDelta = CType(resources.GetObject("GVDECOUPMO.Appearance.HideSelectionRow.FontStyleDelta"), System.Drawing.FontStyle)
        Me.GVDECOUPMO.Appearance.HideSelectionRow.ForeColor = CType(resources.GetObject("GVDECOUPMO.Appearance.HideSelectionRow.ForeColor"), System.Drawing.Color)
        Me.GVDECOUPMO.Appearance.HideSelectionRow.GradientMode = CType(resources.GetObject("GVDECOUPMO.Appearance.HideSelectionRow.GradientMode"), System.Drawing.Drawing2D.LinearGradientMode)
        Me.GVDECOUPMO.Appearance.HideSelectionRow.Image = CType(resources.GetObject("GVDECOUPMO.Appearance.HideSelectionRow.Image"), System.Drawing.Image)
        Me.GVDECOUPMO.Appearance.HideSelectionRow.Options.UseBackColor = True
        Me.GVDECOUPMO.Appearance.HideSelectionRow.Options.UseForeColor = True
        Me.GVDECOUPMO.Appearance.HorzLine.BackColor = CType(resources.GetObject("GVDECOUPMO.Appearance.HorzLine.BackColor"), System.Drawing.Color)
        Me.GVDECOUPMO.Appearance.HorzLine.BorderColor = CType(resources.GetObject("GVDECOUPMO.Appearance.HorzLine.BorderColor"), System.Drawing.Color)
        Me.GVDECOUPMO.Appearance.HorzLine.FontSizeDelta = CType(resources.GetObject("GVDECOUPMO.Appearance.HorzLine.FontSizeDelta"), Integer)
        Me.GVDECOUPMO.Appearance.HorzLine.FontStyleDelta = CType(resources.GetObject("GVDECOUPMO.Appearance.HorzLine.FontStyleDelta"), System.Drawing.FontStyle)
        Me.GVDECOUPMO.Appearance.HorzLine.GradientMode = CType(resources.GetObject("GVDECOUPMO.Appearance.HorzLine.GradientMode"), System.Drawing.Drawing2D.LinearGradientMode)
        Me.GVDECOUPMO.Appearance.HorzLine.Image = CType(resources.GetObject("GVDECOUPMO.Appearance.HorzLine.Image"), System.Drawing.Image)
        Me.GVDECOUPMO.Appearance.HorzLine.Options.UseBackColor = True
        Me.GVDECOUPMO.Appearance.HorzLine.Options.UseBorderColor = True
        Me.GVDECOUPMO.Appearance.OddRow.BackColor = CType(resources.GetObject("GVDECOUPMO.Appearance.OddRow.BackColor"), System.Drawing.Color)
        Me.GVDECOUPMO.Appearance.OddRow.BorderColor = CType(resources.GetObject("GVDECOUPMO.Appearance.OddRow.BorderColor"), System.Drawing.Color)
        Me.GVDECOUPMO.Appearance.OddRow.FontSizeDelta = CType(resources.GetObject("GVDECOUPMO.Appearance.OddRow.FontSizeDelta"), Integer)
        Me.GVDECOUPMO.Appearance.OddRow.FontStyleDelta = CType(resources.GetObject("GVDECOUPMO.Appearance.OddRow.FontStyleDelta"), System.Drawing.FontStyle)
        Me.GVDECOUPMO.Appearance.OddRow.ForeColor = CType(resources.GetObject("GVDECOUPMO.Appearance.OddRow.ForeColor"), System.Drawing.Color)
        Me.GVDECOUPMO.Appearance.OddRow.GradientMode = CType(resources.GetObject("GVDECOUPMO.Appearance.OddRow.GradientMode"), System.Drawing.Drawing2D.LinearGradientMode)
        Me.GVDECOUPMO.Appearance.OddRow.Image = CType(resources.GetObject("GVDECOUPMO.Appearance.OddRow.Image"), System.Drawing.Image)
        Me.GVDECOUPMO.Appearance.OddRow.Options.UseBackColor = True
        Me.GVDECOUPMO.Appearance.OddRow.Options.UseBorderColor = True
        Me.GVDECOUPMO.Appearance.OddRow.Options.UseForeColor = True
        Me.GVDECOUPMO.Appearance.Preview.BackColor = CType(resources.GetObject("GVDECOUPMO.Appearance.Preview.BackColor"), System.Drawing.Color)
        Me.GVDECOUPMO.Appearance.Preview.Font = CType(resources.GetObject("GVDECOUPMO.Appearance.Preview.Font"), System.Drawing.Font)
        Me.GVDECOUPMO.Appearance.Preview.FontSizeDelta = CType(resources.GetObject("GVDECOUPMO.Appearance.Preview.FontSizeDelta"), Integer)
        Me.GVDECOUPMO.Appearance.Preview.FontStyleDelta = CType(resources.GetObject("GVDECOUPMO.Appearance.Preview.FontStyleDelta"), System.Drawing.FontStyle)
        Me.GVDECOUPMO.Appearance.Preview.ForeColor = CType(resources.GetObject("GVDECOUPMO.Appearance.Preview.ForeColor"), System.Drawing.Color)
        Me.GVDECOUPMO.Appearance.Preview.GradientMode = CType(resources.GetObject("GVDECOUPMO.Appearance.Preview.GradientMode"), System.Drawing.Drawing2D.LinearGradientMode)
        Me.GVDECOUPMO.Appearance.Preview.Image = CType(resources.GetObject("GVDECOUPMO.Appearance.Preview.Image"), System.Drawing.Image)
        Me.GVDECOUPMO.Appearance.Preview.Options.UseBackColor = True
        Me.GVDECOUPMO.Appearance.Preview.Options.UseFont = True
        Me.GVDECOUPMO.Appearance.Preview.Options.UseForeColor = True
        Me.GVDECOUPMO.Appearance.Row.BackColor = CType(resources.GetObject("GVDECOUPMO.Appearance.Row.BackColor"), System.Drawing.Color)
        Me.GVDECOUPMO.Appearance.Row.FontSizeDelta = CType(resources.GetObject("GVDECOUPMO.Appearance.Row.FontSizeDelta"), Integer)
        Me.GVDECOUPMO.Appearance.Row.FontStyleDelta = CType(resources.GetObject("GVDECOUPMO.Appearance.Row.FontStyleDelta"), System.Drawing.FontStyle)
        Me.GVDECOUPMO.Appearance.Row.ForeColor = CType(resources.GetObject("GVDECOUPMO.Appearance.Row.ForeColor"), System.Drawing.Color)
        Me.GVDECOUPMO.Appearance.Row.GradientMode = CType(resources.GetObject("GVDECOUPMO.Appearance.Row.GradientMode"), System.Drawing.Drawing2D.LinearGradientMode)
        Me.GVDECOUPMO.Appearance.Row.Image = CType(resources.GetObject("GVDECOUPMO.Appearance.Row.Image"), System.Drawing.Image)
        Me.GVDECOUPMO.Appearance.Row.Options.UseBackColor = True
        Me.GVDECOUPMO.Appearance.Row.Options.UseForeColor = True
        Me.GVDECOUPMO.Appearance.RowSeparator.BackColor = CType(resources.GetObject("GVDECOUPMO.Appearance.RowSeparator.BackColor"), System.Drawing.Color)
        Me.GVDECOUPMO.Appearance.RowSeparator.BackColor2 = CType(resources.GetObject("GVDECOUPMO.Appearance.RowSeparator.BackColor2"), System.Drawing.Color)
        Me.GVDECOUPMO.Appearance.RowSeparator.FontSizeDelta = CType(resources.GetObject("GVDECOUPMO.Appearance.RowSeparator.FontSizeDelta"), Integer)
        Me.GVDECOUPMO.Appearance.RowSeparator.FontStyleDelta = CType(resources.GetObject("GVDECOUPMO.Appearance.RowSeparator.FontStyleDelta"), System.Drawing.FontStyle)
        Me.GVDECOUPMO.Appearance.RowSeparator.GradientMode = CType(resources.GetObject("GVDECOUPMO.Appearance.RowSeparator.GradientMode"), System.Drawing.Drawing2D.LinearGradientMode)
        Me.GVDECOUPMO.Appearance.RowSeparator.Image = CType(resources.GetObject("GVDECOUPMO.Appearance.RowSeparator.Image"), System.Drawing.Image)
        Me.GVDECOUPMO.Appearance.RowSeparator.Options.UseBackColor = True
        Me.GVDECOUPMO.Appearance.SelectedRow.BackColor = CType(resources.GetObject("GVDECOUPMO.Appearance.SelectedRow.BackColor"), System.Drawing.Color)
        Me.GVDECOUPMO.Appearance.SelectedRow.FontSizeDelta = CType(resources.GetObject("GVDECOUPMO.Appearance.SelectedRow.FontSizeDelta"), Integer)
        Me.GVDECOUPMO.Appearance.SelectedRow.FontStyleDelta = CType(resources.GetObject("GVDECOUPMO.Appearance.SelectedRow.FontStyleDelta"), System.Drawing.FontStyle)
        Me.GVDECOUPMO.Appearance.SelectedRow.ForeColor = CType(resources.GetObject("GVDECOUPMO.Appearance.SelectedRow.ForeColor"), System.Drawing.Color)
        Me.GVDECOUPMO.Appearance.SelectedRow.GradientMode = CType(resources.GetObject("GVDECOUPMO.Appearance.SelectedRow.GradientMode"), System.Drawing.Drawing2D.LinearGradientMode)
        Me.GVDECOUPMO.Appearance.SelectedRow.Image = CType(resources.GetObject("GVDECOUPMO.Appearance.SelectedRow.Image"), System.Drawing.Image)
        Me.GVDECOUPMO.Appearance.SelectedRow.Options.UseBackColor = True
        Me.GVDECOUPMO.Appearance.SelectedRow.Options.UseForeColor = True
        Me.GVDECOUPMO.Appearance.TopNewRow.BackColor = CType(resources.GetObject("GVDECOUPMO.Appearance.TopNewRow.BackColor"), System.Drawing.Color)
        Me.GVDECOUPMO.Appearance.TopNewRow.FontSizeDelta = CType(resources.GetObject("GVDECOUPMO.Appearance.TopNewRow.FontSizeDelta"), Integer)
        Me.GVDECOUPMO.Appearance.TopNewRow.FontStyleDelta = CType(resources.GetObject("GVDECOUPMO.Appearance.TopNewRow.FontStyleDelta"), System.Drawing.FontStyle)
        Me.GVDECOUPMO.Appearance.TopNewRow.GradientMode = CType(resources.GetObject("GVDECOUPMO.Appearance.TopNewRow.GradientMode"), System.Drawing.Drawing2D.LinearGradientMode)
        Me.GVDECOUPMO.Appearance.TopNewRow.Image = CType(resources.GetObject("GVDECOUPMO.Appearance.TopNewRow.Image"), System.Drawing.Image)
        Me.GVDECOUPMO.Appearance.TopNewRow.Options.UseBackColor = True
        Me.GVDECOUPMO.Appearance.VertLine.BackColor = CType(resources.GetObject("GVDECOUPMO.Appearance.VertLine.BackColor"), System.Drawing.Color)
        Me.GVDECOUPMO.Appearance.VertLine.BorderColor = CType(resources.GetObject("GVDECOUPMO.Appearance.VertLine.BorderColor"), System.Drawing.Color)
        Me.GVDECOUPMO.Appearance.VertLine.FontSizeDelta = CType(resources.GetObject("GVDECOUPMO.Appearance.VertLine.FontSizeDelta"), Integer)
        Me.GVDECOUPMO.Appearance.VertLine.FontStyleDelta = CType(resources.GetObject("GVDECOUPMO.Appearance.VertLine.FontStyleDelta"), System.Drawing.FontStyle)
        Me.GVDECOUPMO.Appearance.VertLine.GradientMode = CType(resources.GetObject("GVDECOUPMO.Appearance.VertLine.GradientMode"), System.Drawing.Drawing2D.LinearGradientMode)
        Me.GVDECOUPMO.Appearance.VertLine.Image = CType(resources.GetObject("GVDECOUPMO.Appearance.VertLine.Image"), System.Drawing.Image)
        Me.GVDECOUPMO.Appearance.VertLine.Options.UseBackColor = True
        Me.GVDECOUPMO.Appearance.VertLine.Options.UseBorderColor = True
        resources.ApplyResources(Me.GVDECOUPMO, "GVDECOUPMO")
        Me.GVDECOUPMO.Columns.AddRange(New DevExpress.XtraGrid.Columns.GridColumn() {Me.ColMOVLIBDECOUPMO, Me.ColMONBMO, Me.ColMOMTTFO, Me.ColMOMTTSTT})
        Me.GVDECOUPMO.GridControl = Me.GCDECOUPMO
        Me.GVDECOUPMO.Name = "GVDECOUPMO"
        Me.GVDECOUPMO.OptionsBehavior.Editable = False
        Me.GVDECOUPMO.OptionsBehavior.ReadOnly = True
        Me.GVDECOUPMO.OptionsView.EnableAppearanceEvenRow = True
        Me.GVDECOUPMO.OptionsView.EnableAppearanceOddRow = True
        Me.GVDECOUPMO.OptionsView.ShowFooter = True
        Me.GVDECOUPMO.OptionsView.ShowGroupPanel = False
        '
        'ColMOVLIBDECOUPMO
        '
        Me.ColMOVLIBDECOUPMO.AppearanceHeader.FontSizeDelta = CType(resources.GetObject("ColMOVLIBDECOUPMO.AppearanceHeader.FontSizeDelta"), Integer)
        Me.ColMOVLIBDECOUPMO.AppearanceHeader.FontStyleDelta = CType(resources.GetObject("ColMOVLIBDECOUPMO.AppearanceHeader.FontStyleDelta"), System.Drawing.FontStyle)
        Me.ColMOVLIBDECOUPMO.AppearanceHeader.GradientMode = CType(resources.GetObject("ColMOVLIBDECOUPMO.AppearanceHeader.GradientMode"), System.Drawing.Drawing2D.LinearGradientMode)
        Me.ColMOVLIBDECOUPMO.AppearanceHeader.Image = CType(resources.GetObject("ColMOVLIBDECOUPMO.AppearanceHeader.Image"), System.Drawing.Image)
        Me.ColMOVLIBDECOUPMO.AppearanceHeader.Options.UseTextOptions = True
        Me.ColMOVLIBDECOUPMO.AppearanceHeader.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center
        Me.ColMOVLIBDECOUPMO.AppearanceHeader.TextOptions.VAlignment = DevExpress.Utils.VertAlignment.Center
        resources.ApplyResources(Me.ColMOVLIBDECOUPMO, "ColMOVLIBDECOUPMO")
        Me.ColMOVLIBDECOUPMO.FieldName = "VLIBDECOUPMO"
        Me.ColMOVLIBDECOUPMO.Name = "ColMOVLIBDECOUPMO"
        '
        'ColMONBMO
        '
        Me.ColMONBMO.AppearanceHeader.FontSizeDelta = CType(resources.GetObject("ColMONBMO.AppearanceHeader.FontSizeDelta"), Integer)
        Me.ColMONBMO.AppearanceHeader.FontStyleDelta = CType(resources.GetObject("ColMONBMO.AppearanceHeader.FontStyleDelta"), System.Drawing.FontStyle)
        Me.ColMONBMO.AppearanceHeader.GradientMode = CType(resources.GetObject("ColMONBMO.AppearanceHeader.GradientMode"), System.Drawing.Drawing2D.LinearGradientMode)
        Me.ColMONBMO.AppearanceHeader.Image = CType(resources.GetObject("ColMONBMO.AppearanceHeader.Image"), System.Drawing.Image)
        Me.ColMONBMO.AppearanceHeader.Options.UseTextOptions = True
        Me.ColMONBMO.AppearanceHeader.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center
        Me.ColMONBMO.AppearanceHeader.TextOptions.VAlignment = DevExpress.Utils.VertAlignment.Center
        resources.ApplyResources(Me.ColMONBMO, "ColMONBMO")
        Me.ColMONBMO.DisplayFormat.FormatString = "n2"
        Me.ColMONBMO.DisplayFormat.FormatType = DevExpress.Utils.FormatType.Numeric
        Me.ColMONBMO.FieldName = "NBMO"
        Me.ColMONBMO.Name = "ColMONBMO"
        Me.ColMONBMO.Summary.AddRange(New DevExpress.XtraGrid.GridSummaryItem() {New DevExpress.XtraGrid.GridColumnSummaryItem(CType(resources.GetObject("ColMONBMO.Summary"), DevExpress.Data.SummaryItemType), resources.GetString("ColMONBMO.Summary1"), resources.GetString("ColMONBMO.Summary2"))})
        '
        'ColMOMTTFO
        '
        Me.ColMOMTTFO.AppearanceHeader.FontSizeDelta = CType(resources.GetObject("ColMOMTTFO.AppearanceHeader.FontSizeDelta"), Integer)
        Me.ColMOMTTFO.AppearanceHeader.FontStyleDelta = CType(resources.GetObject("ColMOMTTFO.AppearanceHeader.FontStyleDelta"), System.Drawing.FontStyle)
        Me.ColMOMTTFO.AppearanceHeader.GradientMode = CType(resources.GetObject("ColMOMTTFO.AppearanceHeader.GradientMode"), System.Drawing.Drawing2D.LinearGradientMode)
        Me.ColMOMTTFO.AppearanceHeader.Image = CType(resources.GetObject("ColMOMTTFO.AppearanceHeader.Image"), System.Drawing.Image)
        Me.ColMOMTTFO.AppearanceHeader.Options.UseTextOptions = True
        Me.ColMOMTTFO.AppearanceHeader.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center
        Me.ColMOMTTFO.AppearanceHeader.TextOptions.VAlignment = DevExpress.Utils.VertAlignment.Center
        resources.ApplyResources(Me.ColMOMTTFO, "ColMOMTTFO")
        Me.ColMOMTTFO.DisplayFormat.FormatString = "c2"
        Me.ColMOMTTFO.DisplayFormat.FormatType = DevExpress.Utils.FormatType.Numeric
        Me.ColMOMTTFO.FieldName = "MTTFO"
        Me.ColMOMTTFO.Name = "ColMOMTTFO"
        Me.ColMOMTTFO.Summary.AddRange(New DevExpress.XtraGrid.GridSummaryItem() {New DevExpress.XtraGrid.GridColumnSummaryItem(CType(resources.GetObject("ColMOMTTFO.Summary"), DevExpress.Data.SummaryItemType), resources.GetString("ColMOMTTFO.Summary1"), resources.GetString("ColMOMTTFO.Summary2"))})
        '
        'ColMOMTTSTT
        '
        Me.ColMOMTTSTT.AppearanceHeader.FontSizeDelta = CType(resources.GetObject("ColMOMTTSTT.AppearanceHeader.FontSizeDelta"), Integer)
        Me.ColMOMTTSTT.AppearanceHeader.FontStyleDelta = CType(resources.GetObject("ColMOMTTSTT.AppearanceHeader.FontStyleDelta"), System.Drawing.FontStyle)
        Me.ColMOMTTSTT.AppearanceHeader.GradientMode = CType(resources.GetObject("ColMOMTTSTT.AppearanceHeader.GradientMode"), System.Drawing.Drawing2D.LinearGradientMode)
        Me.ColMOMTTSTT.AppearanceHeader.Image = CType(resources.GetObject("ColMOMTTSTT.AppearanceHeader.Image"), System.Drawing.Image)
        Me.ColMOMTTSTT.AppearanceHeader.Options.UseTextOptions = True
        Me.ColMOMTTSTT.AppearanceHeader.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center
        Me.ColMOMTTSTT.AppearanceHeader.TextOptions.VAlignment = DevExpress.Utils.VertAlignment.Center
        resources.ApplyResources(Me.ColMOMTTSTT, "ColMOMTTSTT")
        Me.ColMOMTTSTT.DisplayFormat.FormatString = "c2"
        Me.ColMOMTTSTT.DisplayFormat.FormatType = DevExpress.Utils.FormatType.Numeric
        Me.ColMOMTTSTT.FieldName = "MTTSTT"
        Me.ColMOMTTSTT.Name = "ColMOMTTSTT"
        Me.ColMOMTTSTT.Summary.AddRange(New DevExpress.XtraGrid.GridSummaryItem() {New DevExpress.XtraGrid.GridColumnSummaryItem(CType(resources.GetObject("ColMOMTTSTT.Summary"), DevExpress.Data.SummaryItemType), resources.GetString("ColMOMTTSTT.Summary1"), resources.GetString("ColMOMTTSTT.Summary2"))})
        '
        'GrpBoxDecoupFO
        '
        resources.ApplyResources(Me.GrpBoxDecoupFO, "GrpBoxDecoupFO")
        Me.GrpBoxDecoupFO.Controls.Add(Me.BtnExportDecoupFOXLS)
        Me.GrpBoxDecoupFO.Controls.Add(Me.GCDECOUPFO)
        Me.GrpBoxDecoupFO.Name = "GrpBoxDecoupFO"
        Me.GrpBoxDecoupFO.TabStop = False
        '
        'BtnExportDecoupFOXLS
        '
        resources.ApplyResources(Me.BtnExportDecoupFOXLS, "BtnExportDecoupFOXLS")
        Me.BtnExportDecoupFOXLS.Name = "BtnExportDecoupFOXLS"
        Me.BtnExportDecoupFOXLS.UseVisualStyleBackColor = True
        '
        'GCDECOUPFO
        '
        resources.ApplyResources(Me.GCDECOUPFO, "GCDECOUPFO")
        '
        '
        '
        Me.GCDECOUPFO.EmbeddedNavigator.AccessibleDescription = resources.GetString("GCDECOUPFO.EmbeddedNavigator.AccessibleDescription")
        Me.GCDECOUPFO.EmbeddedNavigator.AccessibleName = resources.GetString("GCDECOUPFO.EmbeddedNavigator.AccessibleName")
        Me.GCDECOUPFO.EmbeddedNavigator.AllowHtmlTextInToolTip = CType(resources.GetObject("GCDECOUPFO.EmbeddedNavigator.AllowHtmlTextInToolTip"), DevExpress.Utils.DefaultBoolean)
        Me.GCDECOUPFO.EmbeddedNavigator.Anchor = CType(resources.GetObject("GCDECOUPFO.EmbeddedNavigator.Anchor"), System.Windows.Forms.AnchorStyles)
        Me.GCDECOUPFO.EmbeddedNavigator.BackgroundImage = CType(resources.GetObject("GCDECOUPFO.EmbeddedNavigator.BackgroundImage"), System.Drawing.Image)
        Me.GCDECOUPFO.EmbeddedNavigator.BackgroundImageLayout = CType(resources.GetObject("GCDECOUPFO.EmbeddedNavigator.BackgroundImageLayout"), System.Windows.Forms.ImageLayout)
        Me.GCDECOUPFO.EmbeddedNavigator.ImeMode = CType(resources.GetObject("GCDECOUPFO.EmbeddedNavigator.ImeMode"), System.Windows.Forms.ImeMode)
        Me.GCDECOUPFO.EmbeddedNavigator.MaximumSize = CType(resources.GetObject("GCDECOUPFO.EmbeddedNavigator.MaximumSize"), System.Drawing.Size)
        Me.GCDECOUPFO.EmbeddedNavigator.TextLocation = CType(resources.GetObject("GCDECOUPFO.EmbeddedNavigator.TextLocation"), DevExpress.XtraEditors.NavigatorButtonsTextLocation)
        Me.GCDECOUPFO.EmbeddedNavigator.ToolTip = resources.GetString("GCDECOUPFO.EmbeddedNavigator.ToolTip")
        Me.GCDECOUPFO.EmbeddedNavigator.ToolTipIconType = CType(resources.GetObject("GCDECOUPFO.EmbeddedNavigator.ToolTipIconType"), DevExpress.Utils.ToolTipIconType)
        Me.GCDECOUPFO.EmbeddedNavigator.ToolTipTitle = resources.GetString("GCDECOUPFO.EmbeddedNavigator.ToolTipTitle")
        Me.GCDECOUPFO.MainView = Me.GVDECOUPFO
        Me.GCDECOUPFO.Name = "GCDECOUPFO"
        Me.GCDECOUPFO.ViewCollection.AddRange(New DevExpress.XtraGrid.Views.Base.BaseView() {Me.GVDECOUPFO})
        '
        'GVDECOUPFO
        '
        Me.GVDECOUPFO.Appearance.ColumnFilterButton.BackColor = CType(resources.GetObject("GVDECOUPFO.Appearance.ColumnFilterButton.BackColor"), System.Drawing.Color)
        Me.GVDECOUPFO.Appearance.ColumnFilterButton.BorderColor = CType(resources.GetObject("GVDECOUPFO.Appearance.ColumnFilterButton.BorderColor"), System.Drawing.Color)
        Me.GVDECOUPFO.Appearance.ColumnFilterButton.FontSizeDelta = CType(resources.GetObject("GVDECOUPFO.Appearance.ColumnFilterButton.FontSizeDelta"), Integer)
        Me.GVDECOUPFO.Appearance.ColumnFilterButton.FontStyleDelta = CType(resources.GetObject("GVDECOUPFO.Appearance.ColumnFilterButton.FontStyleDelta"), System.Drawing.FontStyle)
        Me.GVDECOUPFO.Appearance.ColumnFilterButton.ForeColor = CType(resources.GetObject("GVDECOUPFO.Appearance.ColumnFilterButton.ForeColor"), System.Drawing.Color)
        Me.GVDECOUPFO.Appearance.ColumnFilterButton.GradientMode = CType(resources.GetObject("GVDECOUPFO.Appearance.ColumnFilterButton.GradientMode"), System.Drawing.Drawing2D.LinearGradientMode)
        Me.GVDECOUPFO.Appearance.ColumnFilterButton.Image = CType(resources.GetObject("GVDECOUPFO.Appearance.ColumnFilterButton.Image"), System.Drawing.Image)
        Me.GVDECOUPFO.Appearance.ColumnFilterButton.Options.UseBackColor = True
        Me.GVDECOUPFO.Appearance.ColumnFilterButton.Options.UseBorderColor = True
        Me.GVDECOUPFO.Appearance.ColumnFilterButton.Options.UseForeColor = True
        Me.GVDECOUPFO.Appearance.ColumnFilterButtonActive.BackColor = CType(resources.GetObject("GVDECOUPFO.Appearance.ColumnFilterButtonActive.BackColor"), System.Drawing.Color)
        Me.GVDECOUPFO.Appearance.ColumnFilterButtonActive.BorderColor = CType(resources.GetObject("GVDECOUPFO.Appearance.ColumnFilterButtonActive.BorderColor"), System.Drawing.Color)
        Me.GVDECOUPFO.Appearance.ColumnFilterButtonActive.FontSizeDelta = CType(resources.GetObject("GVDECOUPFO.Appearance.ColumnFilterButtonActive.FontSizeDelta"), Integer)
        Me.GVDECOUPFO.Appearance.ColumnFilterButtonActive.FontStyleDelta = CType(resources.GetObject("GVDECOUPFO.Appearance.ColumnFilterButtonActive.FontStyleDelta"), System.Drawing.FontStyle)
        Me.GVDECOUPFO.Appearance.ColumnFilterButtonActive.ForeColor = CType(resources.GetObject("GVDECOUPFO.Appearance.ColumnFilterButtonActive.ForeColor"), System.Drawing.Color)
        Me.GVDECOUPFO.Appearance.ColumnFilterButtonActive.GradientMode = CType(resources.GetObject("GVDECOUPFO.Appearance.ColumnFilterButtonActive.GradientMode"), System.Drawing.Drawing2D.LinearGradientMode)
        Me.GVDECOUPFO.Appearance.ColumnFilterButtonActive.Image = CType(resources.GetObject("GVDECOUPFO.Appearance.ColumnFilterButtonActive.Image"), System.Drawing.Image)
        Me.GVDECOUPFO.Appearance.ColumnFilterButtonActive.Options.UseBackColor = True
        Me.GVDECOUPFO.Appearance.ColumnFilterButtonActive.Options.UseBorderColor = True
        Me.GVDECOUPFO.Appearance.ColumnFilterButtonActive.Options.UseForeColor = True
        Me.GVDECOUPFO.Appearance.Empty.BackColor = CType(resources.GetObject("GVDECOUPFO.Appearance.Empty.BackColor"), System.Drawing.Color)
        Me.GVDECOUPFO.Appearance.Empty.BackColor2 = CType(resources.GetObject("GVDECOUPFO.Appearance.Empty.BackColor2"), System.Drawing.Color)
        Me.GVDECOUPFO.Appearance.Empty.FontSizeDelta = CType(resources.GetObject("GVDECOUPFO.Appearance.Empty.FontSizeDelta"), Integer)
        Me.GVDECOUPFO.Appearance.Empty.FontStyleDelta = CType(resources.GetObject("GVDECOUPFO.Appearance.Empty.FontStyleDelta"), System.Drawing.FontStyle)
        Me.GVDECOUPFO.Appearance.Empty.GradientMode = CType(resources.GetObject("GVDECOUPFO.Appearance.Empty.GradientMode"), System.Drawing.Drawing2D.LinearGradientMode)
        Me.GVDECOUPFO.Appearance.Empty.Image = CType(resources.GetObject("GVDECOUPFO.Appearance.Empty.Image"), System.Drawing.Image)
        Me.GVDECOUPFO.Appearance.Empty.Options.UseBackColor = True
        Me.GVDECOUPFO.Appearance.EvenRow.BackColor = CType(resources.GetObject("GVDECOUPFO.Appearance.EvenRow.BackColor"), System.Drawing.Color)
        Me.GVDECOUPFO.Appearance.EvenRow.BorderColor = CType(resources.GetObject("GVDECOUPFO.Appearance.EvenRow.BorderColor"), System.Drawing.Color)
        Me.GVDECOUPFO.Appearance.EvenRow.FontSizeDelta = CType(resources.GetObject("GVDECOUPFO.Appearance.EvenRow.FontSizeDelta"), Integer)
        Me.GVDECOUPFO.Appearance.EvenRow.FontStyleDelta = CType(resources.GetObject("GVDECOUPFO.Appearance.EvenRow.FontStyleDelta"), System.Drawing.FontStyle)
        Me.GVDECOUPFO.Appearance.EvenRow.ForeColor = CType(resources.GetObject("GVDECOUPFO.Appearance.EvenRow.ForeColor"), System.Drawing.Color)
        Me.GVDECOUPFO.Appearance.EvenRow.GradientMode = CType(resources.GetObject("GVDECOUPFO.Appearance.EvenRow.GradientMode"), System.Drawing.Drawing2D.LinearGradientMode)
        Me.GVDECOUPFO.Appearance.EvenRow.Image = CType(resources.GetObject("GVDECOUPFO.Appearance.EvenRow.Image"), System.Drawing.Image)
        Me.GVDECOUPFO.Appearance.EvenRow.Options.UseBackColor = True
        Me.GVDECOUPFO.Appearance.EvenRow.Options.UseBorderColor = True
        Me.GVDECOUPFO.Appearance.EvenRow.Options.UseForeColor = True
        Me.GVDECOUPFO.Appearance.FilterCloseButton.BackColor = CType(resources.GetObject("GVDECOUPFO.Appearance.FilterCloseButton.BackColor"), System.Drawing.Color)
        Me.GVDECOUPFO.Appearance.FilterCloseButton.BorderColor = CType(resources.GetObject("GVDECOUPFO.Appearance.FilterCloseButton.BorderColor"), System.Drawing.Color)
        Me.GVDECOUPFO.Appearance.FilterCloseButton.FontSizeDelta = CType(resources.GetObject("GVDECOUPFO.Appearance.FilterCloseButton.FontSizeDelta"), Integer)
        Me.GVDECOUPFO.Appearance.FilterCloseButton.FontStyleDelta = CType(resources.GetObject("GVDECOUPFO.Appearance.FilterCloseButton.FontStyleDelta"), System.Drawing.FontStyle)
        Me.GVDECOUPFO.Appearance.FilterCloseButton.ForeColor = CType(resources.GetObject("GVDECOUPFO.Appearance.FilterCloseButton.ForeColor"), System.Drawing.Color)
        Me.GVDECOUPFO.Appearance.FilterCloseButton.GradientMode = CType(resources.GetObject("GVDECOUPFO.Appearance.FilterCloseButton.GradientMode"), System.Drawing.Drawing2D.LinearGradientMode)
        Me.GVDECOUPFO.Appearance.FilterCloseButton.Image = CType(resources.GetObject("GVDECOUPFO.Appearance.FilterCloseButton.Image"), System.Drawing.Image)
        Me.GVDECOUPFO.Appearance.FilterCloseButton.Options.UseBackColor = True
        Me.GVDECOUPFO.Appearance.FilterCloseButton.Options.UseBorderColor = True
        Me.GVDECOUPFO.Appearance.FilterCloseButton.Options.UseForeColor = True
        Me.GVDECOUPFO.Appearance.FilterPanel.BackColor = CType(resources.GetObject("GVDECOUPFO.Appearance.FilterPanel.BackColor"), System.Drawing.Color)
        Me.GVDECOUPFO.Appearance.FilterPanel.BackColor2 = CType(resources.GetObject("GVDECOUPFO.Appearance.FilterPanel.BackColor2"), System.Drawing.Color)
        Me.GVDECOUPFO.Appearance.FilterPanel.FontSizeDelta = CType(resources.GetObject("GVDECOUPFO.Appearance.FilterPanel.FontSizeDelta"), Integer)
        Me.GVDECOUPFO.Appearance.FilterPanel.FontStyleDelta = CType(resources.GetObject("GVDECOUPFO.Appearance.FilterPanel.FontStyleDelta"), System.Drawing.FontStyle)
        Me.GVDECOUPFO.Appearance.FilterPanel.ForeColor = CType(resources.GetObject("GVDECOUPFO.Appearance.FilterPanel.ForeColor"), System.Drawing.Color)
        Me.GVDECOUPFO.Appearance.FilterPanel.GradientMode = CType(resources.GetObject("GVDECOUPFO.Appearance.FilterPanel.GradientMode"), System.Drawing.Drawing2D.LinearGradientMode)
        Me.GVDECOUPFO.Appearance.FilterPanel.Image = CType(resources.GetObject("GVDECOUPFO.Appearance.FilterPanel.Image"), System.Drawing.Image)
        Me.GVDECOUPFO.Appearance.FilterPanel.Options.UseBackColor = True
        Me.GVDECOUPFO.Appearance.FilterPanel.Options.UseForeColor = True
        Me.GVDECOUPFO.Appearance.FixedLine.BackColor = CType(resources.GetObject("GVDECOUPFO.Appearance.FixedLine.BackColor"), System.Drawing.Color)
        Me.GVDECOUPFO.Appearance.FixedLine.FontSizeDelta = CType(resources.GetObject("GVDECOUPFO.Appearance.FixedLine.FontSizeDelta"), Integer)
        Me.GVDECOUPFO.Appearance.FixedLine.FontStyleDelta = CType(resources.GetObject("GVDECOUPFO.Appearance.FixedLine.FontStyleDelta"), System.Drawing.FontStyle)
        Me.GVDECOUPFO.Appearance.FixedLine.GradientMode = CType(resources.GetObject("GVDECOUPFO.Appearance.FixedLine.GradientMode"), System.Drawing.Drawing2D.LinearGradientMode)
        Me.GVDECOUPFO.Appearance.FixedLine.Image = CType(resources.GetObject("GVDECOUPFO.Appearance.FixedLine.Image"), System.Drawing.Image)
        Me.GVDECOUPFO.Appearance.FixedLine.Options.UseBackColor = True
        Me.GVDECOUPFO.Appearance.FocusedCell.BackColor = CType(resources.GetObject("GVDECOUPFO.Appearance.FocusedCell.BackColor"), System.Drawing.Color)
        Me.GVDECOUPFO.Appearance.FocusedCell.FontSizeDelta = CType(resources.GetObject("GVDECOUPFO.Appearance.FocusedCell.FontSizeDelta"), Integer)
        Me.GVDECOUPFO.Appearance.FocusedCell.FontStyleDelta = CType(resources.GetObject("GVDECOUPFO.Appearance.FocusedCell.FontStyleDelta"), System.Drawing.FontStyle)
        Me.GVDECOUPFO.Appearance.FocusedCell.ForeColor = CType(resources.GetObject("GVDECOUPFO.Appearance.FocusedCell.ForeColor"), System.Drawing.Color)
        Me.GVDECOUPFO.Appearance.FocusedCell.GradientMode = CType(resources.GetObject("GVDECOUPFO.Appearance.FocusedCell.GradientMode"), System.Drawing.Drawing2D.LinearGradientMode)
        Me.GVDECOUPFO.Appearance.FocusedCell.Image = CType(resources.GetObject("GVDECOUPFO.Appearance.FocusedCell.Image"), System.Drawing.Image)
        Me.GVDECOUPFO.Appearance.FocusedCell.Options.UseBackColor = True
        Me.GVDECOUPFO.Appearance.FocusedCell.Options.UseForeColor = True
        Me.GVDECOUPFO.Appearance.FocusedRow.BackColor = CType(resources.GetObject("GVDECOUPFO.Appearance.FocusedRow.BackColor"), System.Drawing.Color)
        Me.GVDECOUPFO.Appearance.FocusedRow.FontSizeDelta = CType(resources.GetObject("GVDECOUPFO.Appearance.FocusedRow.FontSizeDelta"), Integer)
        Me.GVDECOUPFO.Appearance.FocusedRow.FontStyleDelta = CType(resources.GetObject("GVDECOUPFO.Appearance.FocusedRow.FontStyleDelta"), System.Drawing.FontStyle)
        Me.GVDECOUPFO.Appearance.FocusedRow.ForeColor = CType(resources.GetObject("GVDECOUPFO.Appearance.FocusedRow.ForeColor"), System.Drawing.Color)
        Me.GVDECOUPFO.Appearance.FocusedRow.GradientMode = CType(resources.GetObject("GVDECOUPFO.Appearance.FocusedRow.GradientMode"), System.Drawing.Drawing2D.LinearGradientMode)
        Me.GVDECOUPFO.Appearance.FocusedRow.Image = CType(resources.GetObject("GVDECOUPFO.Appearance.FocusedRow.Image"), System.Drawing.Image)
        Me.GVDECOUPFO.Appearance.FocusedRow.Options.UseBackColor = True
        Me.GVDECOUPFO.Appearance.FocusedRow.Options.UseForeColor = True
        Me.GVDECOUPFO.Appearance.FooterPanel.BackColor = CType(resources.GetObject("GVDECOUPFO.Appearance.FooterPanel.BackColor"), System.Drawing.Color)
        Me.GVDECOUPFO.Appearance.FooterPanel.BorderColor = CType(resources.GetObject("GVDECOUPFO.Appearance.FooterPanel.BorderColor"), System.Drawing.Color)
        Me.GVDECOUPFO.Appearance.FooterPanel.FontSizeDelta = CType(resources.GetObject("GVDECOUPFO.Appearance.FooterPanel.FontSizeDelta"), Integer)
        Me.GVDECOUPFO.Appearance.FooterPanel.FontStyleDelta = CType(resources.GetObject("GVDECOUPFO.Appearance.FooterPanel.FontStyleDelta"), System.Drawing.FontStyle)
        Me.GVDECOUPFO.Appearance.FooterPanel.ForeColor = CType(resources.GetObject("GVDECOUPFO.Appearance.FooterPanel.ForeColor"), System.Drawing.Color)
        Me.GVDECOUPFO.Appearance.FooterPanel.GradientMode = CType(resources.GetObject("GVDECOUPFO.Appearance.FooterPanel.GradientMode"), System.Drawing.Drawing2D.LinearGradientMode)
        Me.GVDECOUPFO.Appearance.FooterPanel.Image = CType(resources.GetObject("GVDECOUPFO.Appearance.FooterPanel.Image"), System.Drawing.Image)
        Me.GVDECOUPFO.Appearance.FooterPanel.Options.UseBackColor = True
        Me.GVDECOUPFO.Appearance.FooterPanel.Options.UseBorderColor = True
        Me.GVDECOUPFO.Appearance.FooterPanel.Options.UseForeColor = True
        Me.GVDECOUPFO.Appearance.GroupButton.BackColor = CType(resources.GetObject("GVDECOUPFO.Appearance.GroupButton.BackColor"), System.Drawing.Color)
        Me.GVDECOUPFO.Appearance.GroupButton.BorderColor = CType(resources.GetObject("GVDECOUPFO.Appearance.GroupButton.BorderColor"), System.Drawing.Color)
        Me.GVDECOUPFO.Appearance.GroupButton.FontSizeDelta = CType(resources.GetObject("GVDECOUPFO.Appearance.GroupButton.FontSizeDelta"), Integer)
        Me.GVDECOUPFO.Appearance.GroupButton.FontStyleDelta = CType(resources.GetObject("GVDECOUPFO.Appearance.GroupButton.FontStyleDelta"), System.Drawing.FontStyle)
        Me.GVDECOUPFO.Appearance.GroupButton.GradientMode = CType(resources.GetObject("GVDECOUPFO.Appearance.GroupButton.GradientMode"), System.Drawing.Drawing2D.LinearGradientMode)
        Me.GVDECOUPFO.Appearance.GroupButton.Image = CType(resources.GetObject("GVDECOUPFO.Appearance.GroupButton.Image"), System.Drawing.Image)
        Me.GVDECOUPFO.Appearance.GroupButton.Options.UseBackColor = True
        Me.GVDECOUPFO.Appearance.GroupButton.Options.UseBorderColor = True
        Me.GVDECOUPFO.Appearance.GroupFooter.BackColor = CType(resources.GetObject("GVDECOUPFO.Appearance.GroupFooter.BackColor"), System.Drawing.Color)
        Me.GVDECOUPFO.Appearance.GroupFooter.BorderColor = CType(resources.GetObject("GVDECOUPFO.Appearance.GroupFooter.BorderColor"), System.Drawing.Color)
        Me.GVDECOUPFO.Appearance.GroupFooter.FontSizeDelta = CType(resources.GetObject("GVDECOUPFO.Appearance.GroupFooter.FontSizeDelta"), Integer)
        Me.GVDECOUPFO.Appearance.GroupFooter.FontStyleDelta = CType(resources.GetObject("GVDECOUPFO.Appearance.GroupFooter.FontStyleDelta"), System.Drawing.FontStyle)
        Me.GVDECOUPFO.Appearance.GroupFooter.ForeColor = CType(resources.GetObject("GVDECOUPFO.Appearance.GroupFooter.ForeColor"), System.Drawing.Color)
        Me.GVDECOUPFO.Appearance.GroupFooter.GradientMode = CType(resources.GetObject("GVDECOUPFO.Appearance.GroupFooter.GradientMode"), System.Drawing.Drawing2D.LinearGradientMode)
        Me.GVDECOUPFO.Appearance.GroupFooter.Image = CType(resources.GetObject("GVDECOUPFO.Appearance.GroupFooter.Image"), System.Drawing.Image)
        Me.GVDECOUPFO.Appearance.GroupFooter.Options.UseBackColor = True
        Me.GVDECOUPFO.Appearance.GroupFooter.Options.UseBorderColor = True
        Me.GVDECOUPFO.Appearance.GroupFooter.Options.UseForeColor = True
        Me.GVDECOUPFO.Appearance.GroupPanel.BackColor = CType(resources.GetObject("GVDECOUPFO.Appearance.GroupPanel.BackColor"), System.Drawing.Color)
        Me.GVDECOUPFO.Appearance.GroupPanel.BackColor2 = CType(resources.GetObject("GVDECOUPFO.Appearance.GroupPanel.BackColor2"), System.Drawing.Color)
        Me.GVDECOUPFO.Appearance.GroupPanel.FontSizeDelta = CType(resources.GetObject("GVDECOUPFO.Appearance.GroupPanel.FontSizeDelta"), Integer)
        Me.GVDECOUPFO.Appearance.GroupPanel.FontStyleDelta = CType(resources.GetObject("GVDECOUPFO.Appearance.GroupPanel.FontStyleDelta"), System.Drawing.FontStyle)
        Me.GVDECOUPFO.Appearance.GroupPanel.ForeColor = CType(resources.GetObject("GVDECOUPFO.Appearance.GroupPanel.ForeColor"), System.Drawing.Color)
        Me.GVDECOUPFO.Appearance.GroupPanel.GradientMode = CType(resources.GetObject("GVDECOUPFO.Appearance.GroupPanel.GradientMode"), System.Drawing.Drawing2D.LinearGradientMode)
        Me.GVDECOUPFO.Appearance.GroupPanel.Image = CType(resources.GetObject("GVDECOUPFO.Appearance.GroupPanel.Image"), System.Drawing.Image)
        Me.GVDECOUPFO.Appearance.GroupPanel.Options.UseBackColor = True
        Me.GVDECOUPFO.Appearance.GroupPanel.Options.UseForeColor = True
        Me.GVDECOUPFO.Appearance.GroupRow.BackColor = CType(resources.GetObject("GVDECOUPFO.Appearance.GroupRow.BackColor"), System.Drawing.Color)
        Me.GVDECOUPFO.Appearance.GroupRow.BorderColor = CType(resources.GetObject("GVDECOUPFO.Appearance.GroupRow.BorderColor"), System.Drawing.Color)
        Me.GVDECOUPFO.Appearance.GroupRow.FontSizeDelta = CType(resources.GetObject("GVDECOUPFO.Appearance.GroupRow.FontSizeDelta"), Integer)
        Me.GVDECOUPFO.Appearance.GroupRow.FontStyleDelta = CType(resources.GetObject("GVDECOUPFO.Appearance.GroupRow.FontStyleDelta"), System.Drawing.FontStyle)
        Me.GVDECOUPFO.Appearance.GroupRow.ForeColor = CType(resources.GetObject("GVDECOUPFO.Appearance.GroupRow.ForeColor"), System.Drawing.Color)
        Me.GVDECOUPFO.Appearance.GroupRow.GradientMode = CType(resources.GetObject("GVDECOUPFO.Appearance.GroupRow.GradientMode"), System.Drawing.Drawing2D.LinearGradientMode)
        Me.GVDECOUPFO.Appearance.GroupRow.Image = CType(resources.GetObject("GVDECOUPFO.Appearance.GroupRow.Image"), System.Drawing.Image)
        Me.GVDECOUPFO.Appearance.GroupRow.Options.UseBackColor = True
        Me.GVDECOUPFO.Appearance.GroupRow.Options.UseBorderColor = True
        Me.GVDECOUPFO.Appearance.GroupRow.Options.UseForeColor = True
        Me.GVDECOUPFO.Appearance.HeaderPanel.BackColor = CType(resources.GetObject("GVDECOUPFO.Appearance.HeaderPanel.BackColor"), System.Drawing.Color)
        Me.GVDECOUPFO.Appearance.HeaderPanel.BorderColor = CType(resources.GetObject("GVDECOUPFO.Appearance.HeaderPanel.BorderColor"), System.Drawing.Color)
        Me.GVDECOUPFO.Appearance.HeaderPanel.FontSizeDelta = CType(resources.GetObject("GVDECOUPFO.Appearance.HeaderPanel.FontSizeDelta"), Integer)
        Me.GVDECOUPFO.Appearance.HeaderPanel.FontStyleDelta = CType(resources.GetObject("GVDECOUPFO.Appearance.HeaderPanel.FontStyleDelta"), System.Drawing.FontStyle)
        Me.GVDECOUPFO.Appearance.HeaderPanel.ForeColor = CType(resources.GetObject("GVDECOUPFO.Appearance.HeaderPanel.ForeColor"), System.Drawing.Color)
        Me.GVDECOUPFO.Appearance.HeaderPanel.GradientMode = CType(resources.GetObject("GVDECOUPFO.Appearance.HeaderPanel.GradientMode"), System.Drawing.Drawing2D.LinearGradientMode)
        Me.GVDECOUPFO.Appearance.HeaderPanel.Image = CType(resources.GetObject("GVDECOUPFO.Appearance.HeaderPanel.Image"), System.Drawing.Image)
        Me.GVDECOUPFO.Appearance.HeaderPanel.Options.UseBackColor = True
        Me.GVDECOUPFO.Appearance.HeaderPanel.Options.UseBorderColor = True
        Me.GVDECOUPFO.Appearance.HeaderPanel.Options.UseForeColor = True
        Me.GVDECOUPFO.Appearance.HeaderPanel.Options.UseTextOptions = True
        Me.GVDECOUPFO.Appearance.HeaderPanel.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center
        Me.GVDECOUPFO.Appearance.HeaderPanel.TextOptions.VAlignment = DevExpress.Utils.VertAlignment.Center
        Me.GVDECOUPFO.Appearance.HeaderPanel.TextOptions.WordWrap = DevExpress.Utils.WordWrap.Wrap
        Me.GVDECOUPFO.Appearance.HideSelectionRow.BackColor = CType(resources.GetObject("GVDECOUPFO.Appearance.HideSelectionRow.BackColor"), System.Drawing.Color)
        Me.GVDECOUPFO.Appearance.HideSelectionRow.FontSizeDelta = CType(resources.GetObject("GVDECOUPFO.Appearance.HideSelectionRow.FontSizeDelta"), Integer)
        Me.GVDECOUPFO.Appearance.HideSelectionRow.FontStyleDelta = CType(resources.GetObject("GVDECOUPFO.Appearance.HideSelectionRow.FontStyleDelta"), System.Drawing.FontStyle)
        Me.GVDECOUPFO.Appearance.HideSelectionRow.ForeColor = CType(resources.GetObject("GVDECOUPFO.Appearance.HideSelectionRow.ForeColor"), System.Drawing.Color)
        Me.GVDECOUPFO.Appearance.HideSelectionRow.GradientMode = CType(resources.GetObject("GVDECOUPFO.Appearance.HideSelectionRow.GradientMode"), System.Drawing.Drawing2D.LinearGradientMode)
        Me.GVDECOUPFO.Appearance.HideSelectionRow.Image = CType(resources.GetObject("GVDECOUPFO.Appearance.HideSelectionRow.Image"), System.Drawing.Image)
        Me.GVDECOUPFO.Appearance.HideSelectionRow.Options.UseBackColor = True
        Me.GVDECOUPFO.Appearance.HideSelectionRow.Options.UseForeColor = True
        Me.GVDECOUPFO.Appearance.HorzLine.BackColor = CType(resources.GetObject("GVDECOUPFO.Appearance.HorzLine.BackColor"), System.Drawing.Color)
        Me.GVDECOUPFO.Appearance.HorzLine.BorderColor = CType(resources.GetObject("GVDECOUPFO.Appearance.HorzLine.BorderColor"), System.Drawing.Color)
        Me.GVDECOUPFO.Appearance.HorzLine.FontSizeDelta = CType(resources.GetObject("GVDECOUPFO.Appearance.HorzLine.FontSizeDelta"), Integer)
        Me.GVDECOUPFO.Appearance.HorzLine.FontStyleDelta = CType(resources.GetObject("GVDECOUPFO.Appearance.HorzLine.FontStyleDelta"), System.Drawing.FontStyle)
        Me.GVDECOUPFO.Appearance.HorzLine.GradientMode = CType(resources.GetObject("GVDECOUPFO.Appearance.HorzLine.GradientMode"), System.Drawing.Drawing2D.LinearGradientMode)
        Me.GVDECOUPFO.Appearance.HorzLine.Image = CType(resources.GetObject("GVDECOUPFO.Appearance.HorzLine.Image"), System.Drawing.Image)
        Me.GVDECOUPFO.Appearance.HorzLine.Options.UseBackColor = True
        Me.GVDECOUPFO.Appearance.HorzLine.Options.UseBorderColor = True
        Me.GVDECOUPFO.Appearance.OddRow.BackColor = CType(resources.GetObject("GVDECOUPFO.Appearance.OddRow.BackColor"), System.Drawing.Color)
        Me.GVDECOUPFO.Appearance.OddRow.BorderColor = CType(resources.GetObject("GVDECOUPFO.Appearance.OddRow.BorderColor"), System.Drawing.Color)
        Me.GVDECOUPFO.Appearance.OddRow.FontSizeDelta = CType(resources.GetObject("GVDECOUPFO.Appearance.OddRow.FontSizeDelta"), Integer)
        Me.GVDECOUPFO.Appearance.OddRow.FontStyleDelta = CType(resources.GetObject("GVDECOUPFO.Appearance.OddRow.FontStyleDelta"), System.Drawing.FontStyle)
        Me.GVDECOUPFO.Appearance.OddRow.ForeColor = CType(resources.GetObject("GVDECOUPFO.Appearance.OddRow.ForeColor"), System.Drawing.Color)
        Me.GVDECOUPFO.Appearance.OddRow.GradientMode = CType(resources.GetObject("GVDECOUPFO.Appearance.OddRow.GradientMode"), System.Drawing.Drawing2D.LinearGradientMode)
        Me.GVDECOUPFO.Appearance.OddRow.Image = CType(resources.GetObject("GVDECOUPFO.Appearance.OddRow.Image"), System.Drawing.Image)
        Me.GVDECOUPFO.Appearance.OddRow.Options.UseBackColor = True
        Me.GVDECOUPFO.Appearance.OddRow.Options.UseBorderColor = True
        Me.GVDECOUPFO.Appearance.OddRow.Options.UseForeColor = True
        Me.GVDECOUPFO.Appearance.Preview.BackColor = CType(resources.GetObject("GVDECOUPFO.Appearance.Preview.BackColor"), System.Drawing.Color)
        Me.GVDECOUPFO.Appearance.Preview.Font = CType(resources.GetObject("GVDECOUPFO.Appearance.Preview.Font"), System.Drawing.Font)
        Me.GVDECOUPFO.Appearance.Preview.FontSizeDelta = CType(resources.GetObject("GVDECOUPFO.Appearance.Preview.FontSizeDelta"), Integer)
        Me.GVDECOUPFO.Appearance.Preview.FontStyleDelta = CType(resources.GetObject("GVDECOUPFO.Appearance.Preview.FontStyleDelta"), System.Drawing.FontStyle)
        Me.GVDECOUPFO.Appearance.Preview.ForeColor = CType(resources.GetObject("GVDECOUPFO.Appearance.Preview.ForeColor"), System.Drawing.Color)
        Me.GVDECOUPFO.Appearance.Preview.GradientMode = CType(resources.GetObject("GVDECOUPFO.Appearance.Preview.GradientMode"), System.Drawing.Drawing2D.LinearGradientMode)
        Me.GVDECOUPFO.Appearance.Preview.Image = CType(resources.GetObject("GVDECOUPFO.Appearance.Preview.Image"), System.Drawing.Image)
        Me.GVDECOUPFO.Appearance.Preview.Options.UseBackColor = True
        Me.GVDECOUPFO.Appearance.Preview.Options.UseFont = True
        Me.GVDECOUPFO.Appearance.Preview.Options.UseForeColor = True
        Me.GVDECOUPFO.Appearance.Row.BackColor = CType(resources.GetObject("GVDECOUPFO.Appearance.Row.BackColor"), System.Drawing.Color)
        Me.GVDECOUPFO.Appearance.Row.FontSizeDelta = CType(resources.GetObject("GVDECOUPFO.Appearance.Row.FontSizeDelta"), Integer)
        Me.GVDECOUPFO.Appearance.Row.FontStyleDelta = CType(resources.GetObject("GVDECOUPFO.Appearance.Row.FontStyleDelta"), System.Drawing.FontStyle)
        Me.GVDECOUPFO.Appearance.Row.ForeColor = CType(resources.GetObject("GVDECOUPFO.Appearance.Row.ForeColor"), System.Drawing.Color)
        Me.GVDECOUPFO.Appearance.Row.GradientMode = CType(resources.GetObject("GVDECOUPFO.Appearance.Row.GradientMode"), System.Drawing.Drawing2D.LinearGradientMode)
        Me.GVDECOUPFO.Appearance.Row.Image = CType(resources.GetObject("GVDECOUPFO.Appearance.Row.Image"), System.Drawing.Image)
        Me.GVDECOUPFO.Appearance.Row.Options.UseBackColor = True
        Me.GVDECOUPFO.Appearance.Row.Options.UseForeColor = True
        Me.GVDECOUPFO.Appearance.RowSeparator.BackColor = CType(resources.GetObject("GVDECOUPFO.Appearance.RowSeparator.BackColor"), System.Drawing.Color)
        Me.GVDECOUPFO.Appearance.RowSeparator.BackColor2 = CType(resources.GetObject("GVDECOUPFO.Appearance.RowSeparator.BackColor2"), System.Drawing.Color)
        Me.GVDECOUPFO.Appearance.RowSeparator.FontSizeDelta = CType(resources.GetObject("GVDECOUPFO.Appearance.RowSeparator.FontSizeDelta"), Integer)
        Me.GVDECOUPFO.Appearance.RowSeparator.FontStyleDelta = CType(resources.GetObject("GVDECOUPFO.Appearance.RowSeparator.FontStyleDelta"), System.Drawing.FontStyle)
        Me.GVDECOUPFO.Appearance.RowSeparator.GradientMode = CType(resources.GetObject("GVDECOUPFO.Appearance.RowSeparator.GradientMode"), System.Drawing.Drawing2D.LinearGradientMode)
        Me.GVDECOUPFO.Appearance.RowSeparator.Image = CType(resources.GetObject("GVDECOUPFO.Appearance.RowSeparator.Image"), System.Drawing.Image)
        Me.GVDECOUPFO.Appearance.RowSeparator.Options.UseBackColor = True
        Me.GVDECOUPFO.Appearance.SelectedRow.BackColor = CType(resources.GetObject("GVDECOUPFO.Appearance.SelectedRow.BackColor"), System.Drawing.Color)
        Me.GVDECOUPFO.Appearance.SelectedRow.FontSizeDelta = CType(resources.GetObject("GVDECOUPFO.Appearance.SelectedRow.FontSizeDelta"), Integer)
        Me.GVDECOUPFO.Appearance.SelectedRow.FontStyleDelta = CType(resources.GetObject("GVDECOUPFO.Appearance.SelectedRow.FontStyleDelta"), System.Drawing.FontStyle)
        Me.GVDECOUPFO.Appearance.SelectedRow.ForeColor = CType(resources.GetObject("GVDECOUPFO.Appearance.SelectedRow.ForeColor"), System.Drawing.Color)
        Me.GVDECOUPFO.Appearance.SelectedRow.GradientMode = CType(resources.GetObject("GVDECOUPFO.Appearance.SelectedRow.GradientMode"), System.Drawing.Drawing2D.LinearGradientMode)
        Me.GVDECOUPFO.Appearance.SelectedRow.Image = CType(resources.GetObject("GVDECOUPFO.Appearance.SelectedRow.Image"), System.Drawing.Image)
        Me.GVDECOUPFO.Appearance.SelectedRow.Options.UseBackColor = True
        Me.GVDECOUPFO.Appearance.SelectedRow.Options.UseForeColor = True
        Me.GVDECOUPFO.Appearance.TopNewRow.BackColor = CType(resources.GetObject("GVDECOUPFO.Appearance.TopNewRow.BackColor"), System.Drawing.Color)
        Me.GVDECOUPFO.Appearance.TopNewRow.FontSizeDelta = CType(resources.GetObject("GVDECOUPFO.Appearance.TopNewRow.FontSizeDelta"), Integer)
        Me.GVDECOUPFO.Appearance.TopNewRow.FontStyleDelta = CType(resources.GetObject("GVDECOUPFO.Appearance.TopNewRow.FontStyleDelta"), System.Drawing.FontStyle)
        Me.GVDECOUPFO.Appearance.TopNewRow.GradientMode = CType(resources.GetObject("GVDECOUPFO.Appearance.TopNewRow.GradientMode"), System.Drawing.Drawing2D.LinearGradientMode)
        Me.GVDECOUPFO.Appearance.TopNewRow.Image = CType(resources.GetObject("GVDECOUPFO.Appearance.TopNewRow.Image"), System.Drawing.Image)
        Me.GVDECOUPFO.Appearance.TopNewRow.Options.UseBackColor = True
        Me.GVDECOUPFO.Appearance.VertLine.BackColor = CType(resources.GetObject("GVDECOUPFO.Appearance.VertLine.BackColor"), System.Drawing.Color)
        Me.GVDECOUPFO.Appearance.VertLine.BorderColor = CType(resources.GetObject("GVDECOUPFO.Appearance.VertLine.BorderColor"), System.Drawing.Color)
        Me.GVDECOUPFO.Appearance.VertLine.FontSizeDelta = CType(resources.GetObject("GVDECOUPFO.Appearance.VertLine.FontSizeDelta"), Integer)
        Me.GVDECOUPFO.Appearance.VertLine.FontStyleDelta = CType(resources.GetObject("GVDECOUPFO.Appearance.VertLine.FontStyleDelta"), System.Drawing.FontStyle)
        Me.GVDECOUPFO.Appearance.VertLine.GradientMode = CType(resources.GetObject("GVDECOUPFO.Appearance.VertLine.GradientMode"), System.Drawing.Drawing2D.LinearGradientMode)
        Me.GVDECOUPFO.Appearance.VertLine.Image = CType(resources.GetObject("GVDECOUPFO.Appearance.VertLine.Image"), System.Drawing.Image)
        Me.GVDECOUPFO.Appearance.VertLine.Options.UseBackColor = True
        Me.GVDECOUPFO.Appearance.VertLine.Options.UseBorderColor = True
        resources.ApplyResources(Me.GVDECOUPFO, "GVDECOUPFO")
        Me.GVDECOUPFO.Columns.AddRange(New DevExpress.XtraGrid.Columns.GridColumn() {Me.ColMOVLIBDECOUPFO, Me.ColFONBMO, Me.ColFOMTTFO, Me.ColFOMTTSTT})
        Me.GVDECOUPFO.GridControl = Me.GCDECOUPFO
        Me.GVDECOUPFO.Name = "GVDECOUPFO"
        Me.GVDECOUPFO.OptionsBehavior.Editable = False
        Me.GVDECOUPFO.OptionsBehavior.ReadOnly = True
        Me.GVDECOUPFO.OptionsView.EnableAppearanceEvenRow = True
        Me.GVDECOUPFO.OptionsView.EnableAppearanceOddRow = True
        Me.GVDECOUPFO.OptionsView.ShowFooter = True
        Me.GVDECOUPFO.OptionsView.ShowGroupPanel = False
        '
        'ColMOVLIBDECOUPFO
        '
        resources.ApplyResources(Me.ColMOVLIBDECOUPFO, "ColMOVLIBDECOUPFO")
        Me.ColMOVLIBDECOUPFO.FieldName = "VLIBDECOUPFO"
        Me.ColMOVLIBDECOUPFO.Name = "ColMOVLIBDECOUPFO"
        '
        'ColFONBMO
        '
        resources.ApplyResources(Me.ColFONBMO, "ColFONBMO")
        Me.ColFONBMO.DisplayFormat.FormatString = "n2"
        Me.ColFONBMO.DisplayFormat.FormatType = DevExpress.Utils.FormatType.Numeric
        Me.ColFONBMO.FieldName = "NBMO"
        Me.ColFONBMO.Name = "ColFONBMO"
        Me.ColFONBMO.Summary.AddRange(New DevExpress.XtraGrid.GridSummaryItem() {New DevExpress.XtraGrid.GridColumnSummaryItem(CType(resources.GetObject("ColFONBMO.Summary"), DevExpress.Data.SummaryItemType), resources.GetString("ColFONBMO.Summary1"), resources.GetString("ColFONBMO.Summary2"))})
        '
        'ColFOMTTFO
        '
        resources.ApplyResources(Me.ColFOMTTFO, "ColFOMTTFO")
        Me.ColFOMTTFO.DisplayFormat.FormatString = "c2"
        Me.ColFOMTTFO.DisplayFormat.FormatType = DevExpress.Utils.FormatType.Numeric
        Me.ColFOMTTFO.FieldName = "MTTFO"
        Me.ColFOMTTFO.Name = "ColFOMTTFO"
        Me.ColFOMTTFO.Summary.AddRange(New DevExpress.XtraGrid.GridSummaryItem() {New DevExpress.XtraGrid.GridColumnSummaryItem(CType(resources.GetObject("ColFOMTTFO.Summary"), DevExpress.Data.SummaryItemType), resources.GetString("ColFOMTTFO.Summary1"), resources.GetString("ColFOMTTFO.Summary2"))})
        '
        'ColFOMTTSTT
        '
        resources.ApplyResources(Me.ColFOMTTSTT, "ColFOMTTSTT")
        Me.ColFOMTTSTT.DisplayFormat.FormatString = "c2"
        Me.ColFOMTTSTT.DisplayFormat.FormatType = DevExpress.Utils.FormatType.Numeric
        Me.ColFOMTTSTT.FieldName = "MTTSTT"
        Me.ColFOMTTSTT.Name = "ColFOMTTSTT"
        Me.ColFOMTTSTT.Summary.AddRange(New DevExpress.XtraGrid.GridSummaryItem() {New DevExpress.XtraGrid.GridColumnSummaryItem(CType(resources.GetObject("ColFOMTTSTT.Summary"), DevExpress.Data.SummaryItemType), resources.GetString("ColFOMTTSTT.Summary1"), resources.GetString("ColFOMTTSTT.Summary2"))})
        '
        'GrpBoxDecoupSTT
        '
        resources.ApplyResources(Me.GrpBoxDecoupSTT, "GrpBoxDecoupSTT")
        Me.GrpBoxDecoupSTT.Controls.Add(Me.BtnExportDecoupSTTXLS)
        Me.GrpBoxDecoupSTT.Controls.Add(Me.GCDECOUPSTT)
        Me.GrpBoxDecoupSTT.Name = "GrpBoxDecoupSTT"
        Me.GrpBoxDecoupSTT.TabStop = False
        '
        'BtnExportDecoupSTTXLS
        '
        resources.ApplyResources(Me.BtnExportDecoupSTTXLS, "BtnExportDecoupSTTXLS")
        Me.BtnExportDecoupSTTXLS.Name = "BtnExportDecoupSTTXLS"
        Me.BtnExportDecoupSTTXLS.UseVisualStyleBackColor = True
        '
        'GCDECOUPSTT
        '
        resources.ApplyResources(Me.GCDECOUPSTT, "GCDECOUPSTT")
        '
        '
        '
        Me.GCDECOUPSTT.EmbeddedNavigator.AccessibleDescription = resources.GetString("GCDECOUPSTT.EmbeddedNavigator.AccessibleDescription")
        Me.GCDECOUPSTT.EmbeddedNavigator.AccessibleName = resources.GetString("GCDECOUPSTT.EmbeddedNavigator.AccessibleName")
        Me.GCDECOUPSTT.EmbeddedNavigator.AllowHtmlTextInToolTip = CType(resources.GetObject("GCDECOUPSTT.EmbeddedNavigator.AllowHtmlTextInToolTip"), DevExpress.Utils.DefaultBoolean)
        Me.GCDECOUPSTT.EmbeddedNavigator.Anchor = CType(resources.GetObject("GCDECOUPSTT.EmbeddedNavigator.Anchor"), System.Windows.Forms.AnchorStyles)
        Me.GCDECOUPSTT.EmbeddedNavigator.BackgroundImage = CType(resources.GetObject("GCDECOUPSTT.EmbeddedNavigator.BackgroundImage"), System.Drawing.Image)
        Me.GCDECOUPSTT.EmbeddedNavigator.BackgroundImageLayout = CType(resources.GetObject("GCDECOUPSTT.EmbeddedNavigator.BackgroundImageLayout"), System.Windows.Forms.ImageLayout)
        Me.GCDECOUPSTT.EmbeddedNavigator.ImeMode = CType(resources.GetObject("GCDECOUPSTT.EmbeddedNavigator.ImeMode"), System.Windows.Forms.ImeMode)
        Me.GCDECOUPSTT.EmbeddedNavigator.MaximumSize = CType(resources.GetObject("GCDECOUPSTT.EmbeddedNavigator.MaximumSize"), System.Drawing.Size)
        Me.GCDECOUPSTT.EmbeddedNavigator.TextLocation = CType(resources.GetObject("GCDECOUPSTT.EmbeddedNavigator.TextLocation"), DevExpress.XtraEditors.NavigatorButtonsTextLocation)
        Me.GCDECOUPSTT.EmbeddedNavigator.ToolTip = resources.GetString("GCDECOUPSTT.EmbeddedNavigator.ToolTip")
        Me.GCDECOUPSTT.EmbeddedNavigator.ToolTipIconType = CType(resources.GetObject("GCDECOUPSTT.EmbeddedNavigator.ToolTipIconType"), DevExpress.Utils.ToolTipIconType)
        Me.GCDECOUPSTT.EmbeddedNavigator.ToolTipTitle = resources.GetString("GCDECOUPSTT.EmbeddedNavigator.ToolTipTitle")
        Me.GCDECOUPSTT.MainView = Me.GVDECOUPSTT
        Me.GCDECOUPSTT.Name = "GCDECOUPSTT"
        Me.GCDECOUPSTT.ViewCollection.AddRange(New DevExpress.XtraGrid.Views.Base.BaseView() {Me.GVDECOUPSTT})
        '
        'GVDECOUPSTT
        '
        Me.GVDECOUPSTT.Appearance.ColumnFilterButton.BackColor = CType(resources.GetObject("GVDECOUPSTT.Appearance.ColumnFilterButton.BackColor"), System.Drawing.Color)
        Me.GVDECOUPSTT.Appearance.ColumnFilterButton.BorderColor = CType(resources.GetObject("GVDECOUPSTT.Appearance.ColumnFilterButton.BorderColor"), System.Drawing.Color)
        Me.GVDECOUPSTT.Appearance.ColumnFilterButton.FontSizeDelta = CType(resources.GetObject("GVDECOUPSTT.Appearance.ColumnFilterButton.FontSizeDelta"), Integer)
        Me.GVDECOUPSTT.Appearance.ColumnFilterButton.FontStyleDelta = CType(resources.GetObject("GVDECOUPSTT.Appearance.ColumnFilterButton.FontStyleDelta"), System.Drawing.FontStyle)
        Me.GVDECOUPSTT.Appearance.ColumnFilterButton.ForeColor = CType(resources.GetObject("GVDECOUPSTT.Appearance.ColumnFilterButton.ForeColor"), System.Drawing.Color)
        Me.GVDECOUPSTT.Appearance.ColumnFilterButton.GradientMode = CType(resources.GetObject("GVDECOUPSTT.Appearance.ColumnFilterButton.GradientMode"), System.Drawing.Drawing2D.LinearGradientMode)
        Me.GVDECOUPSTT.Appearance.ColumnFilterButton.Image = CType(resources.GetObject("GVDECOUPSTT.Appearance.ColumnFilterButton.Image"), System.Drawing.Image)
        Me.GVDECOUPSTT.Appearance.ColumnFilterButton.Options.UseBackColor = True
        Me.GVDECOUPSTT.Appearance.ColumnFilterButton.Options.UseBorderColor = True
        Me.GVDECOUPSTT.Appearance.ColumnFilterButton.Options.UseForeColor = True
        Me.GVDECOUPSTT.Appearance.ColumnFilterButtonActive.BackColor = CType(resources.GetObject("GVDECOUPSTT.Appearance.ColumnFilterButtonActive.BackColor"), System.Drawing.Color)
        Me.GVDECOUPSTT.Appearance.ColumnFilterButtonActive.BorderColor = CType(resources.GetObject("GVDECOUPSTT.Appearance.ColumnFilterButtonActive.BorderColor"), System.Drawing.Color)
        Me.GVDECOUPSTT.Appearance.ColumnFilterButtonActive.FontSizeDelta = CType(resources.GetObject("GVDECOUPSTT.Appearance.ColumnFilterButtonActive.FontSizeDelta"), Integer)
        Me.GVDECOUPSTT.Appearance.ColumnFilterButtonActive.FontStyleDelta = CType(resources.GetObject("GVDECOUPSTT.Appearance.ColumnFilterButtonActive.FontStyleDelta"), System.Drawing.FontStyle)
        Me.GVDECOUPSTT.Appearance.ColumnFilterButtonActive.ForeColor = CType(resources.GetObject("GVDECOUPSTT.Appearance.ColumnFilterButtonActive.ForeColor"), System.Drawing.Color)
        Me.GVDECOUPSTT.Appearance.ColumnFilterButtonActive.GradientMode = CType(resources.GetObject("GVDECOUPSTT.Appearance.ColumnFilterButtonActive.GradientMode"), System.Drawing.Drawing2D.LinearGradientMode)
        Me.GVDECOUPSTT.Appearance.ColumnFilterButtonActive.Image = CType(resources.GetObject("GVDECOUPSTT.Appearance.ColumnFilterButtonActive.Image"), System.Drawing.Image)
        Me.GVDECOUPSTT.Appearance.ColumnFilterButtonActive.Options.UseBackColor = True
        Me.GVDECOUPSTT.Appearance.ColumnFilterButtonActive.Options.UseBorderColor = True
        Me.GVDECOUPSTT.Appearance.ColumnFilterButtonActive.Options.UseForeColor = True
        Me.GVDECOUPSTT.Appearance.Empty.BackColor = CType(resources.GetObject("GVDECOUPSTT.Appearance.Empty.BackColor"), System.Drawing.Color)
        Me.GVDECOUPSTT.Appearance.Empty.BackColor2 = CType(resources.GetObject("GVDECOUPSTT.Appearance.Empty.BackColor2"), System.Drawing.Color)
        Me.GVDECOUPSTT.Appearance.Empty.FontSizeDelta = CType(resources.GetObject("GVDECOUPSTT.Appearance.Empty.FontSizeDelta"), Integer)
        Me.GVDECOUPSTT.Appearance.Empty.FontStyleDelta = CType(resources.GetObject("GVDECOUPSTT.Appearance.Empty.FontStyleDelta"), System.Drawing.FontStyle)
        Me.GVDECOUPSTT.Appearance.Empty.GradientMode = CType(resources.GetObject("GVDECOUPSTT.Appearance.Empty.GradientMode"), System.Drawing.Drawing2D.LinearGradientMode)
        Me.GVDECOUPSTT.Appearance.Empty.Image = CType(resources.GetObject("GVDECOUPSTT.Appearance.Empty.Image"), System.Drawing.Image)
        Me.GVDECOUPSTT.Appearance.Empty.Options.UseBackColor = True
        Me.GVDECOUPSTT.Appearance.EvenRow.BackColor = CType(resources.GetObject("GVDECOUPSTT.Appearance.EvenRow.BackColor"), System.Drawing.Color)
        Me.GVDECOUPSTT.Appearance.EvenRow.BorderColor = CType(resources.GetObject("GVDECOUPSTT.Appearance.EvenRow.BorderColor"), System.Drawing.Color)
        Me.GVDECOUPSTT.Appearance.EvenRow.FontSizeDelta = CType(resources.GetObject("GVDECOUPSTT.Appearance.EvenRow.FontSizeDelta"), Integer)
        Me.GVDECOUPSTT.Appearance.EvenRow.FontStyleDelta = CType(resources.GetObject("GVDECOUPSTT.Appearance.EvenRow.FontStyleDelta"), System.Drawing.FontStyle)
        Me.GVDECOUPSTT.Appearance.EvenRow.ForeColor = CType(resources.GetObject("GVDECOUPSTT.Appearance.EvenRow.ForeColor"), System.Drawing.Color)
        Me.GVDECOUPSTT.Appearance.EvenRow.GradientMode = CType(resources.GetObject("GVDECOUPSTT.Appearance.EvenRow.GradientMode"), System.Drawing.Drawing2D.LinearGradientMode)
        Me.GVDECOUPSTT.Appearance.EvenRow.Image = CType(resources.GetObject("GVDECOUPSTT.Appearance.EvenRow.Image"), System.Drawing.Image)
        Me.GVDECOUPSTT.Appearance.EvenRow.Options.UseBackColor = True
        Me.GVDECOUPSTT.Appearance.EvenRow.Options.UseBorderColor = True
        Me.GVDECOUPSTT.Appearance.EvenRow.Options.UseForeColor = True
        Me.GVDECOUPSTT.Appearance.FilterCloseButton.BackColor = CType(resources.GetObject("GVDECOUPSTT.Appearance.FilterCloseButton.BackColor"), System.Drawing.Color)
        Me.GVDECOUPSTT.Appearance.FilterCloseButton.BorderColor = CType(resources.GetObject("GVDECOUPSTT.Appearance.FilterCloseButton.BorderColor"), System.Drawing.Color)
        Me.GVDECOUPSTT.Appearance.FilterCloseButton.FontSizeDelta = CType(resources.GetObject("GVDECOUPSTT.Appearance.FilterCloseButton.FontSizeDelta"), Integer)
        Me.GVDECOUPSTT.Appearance.FilterCloseButton.FontStyleDelta = CType(resources.GetObject("GVDECOUPSTT.Appearance.FilterCloseButton.FontStyleDelta"), System.Drawing.FontStyle)
        Me.GVDECOUPSTT.Appearance.FilterCloseButton.ForeColor = CType(resources.GetObject("GVDECOUPSTT.Appearance.FilterCloseButton.ForeColor"), System.Drawing.Color)
        Me.GVDECOUPSTT.Appearance.FilterCloseButton.GradientMode = CType(resources.GetObject("GVDECOUPSTT.Appearance.FilterCloseButton.GradientMode"), System.Drawing.Drawing2D.LinearGradientMode)
        Me.GVDECOUPSTT.Appearance.FilterCloseButton.Image = CType(resources.GetObject("GVDECOUPSTT.Appearance.FilterCloseButton.Image"), System.Drawing.Image)
        Me.GVDECOUPSTT.Appearance.FilterCloseButton.Options.UseBackColor = True
        Me.GVDECOUPSTT.Appearance.FilterCloseButton.Options.UseBorderColor = True
        Me.GVDECOUPSTT.Appearance.FilterCloseButton.Options.UseForeColor = True
        Me.GVDECOUPSTT.Appearance.FilterPanel.BackColor = CType(resources.GetObject("GVDECOUPSTT.Appearance.FilterPanel.BackColor"), System.Drawing.Color)
        Me.GVDECOUPSTT.Appearance.FilterPanel.BackColor2 = CType(resources.GetObject("GVDECOUPSTT.Appearance.FilterPanel.BackColor2"), System.Drawing.Color)
        Me.GVDECOUPSTT.Appearance.FilterPanel.FontSizeDelta = CType(resources.GetObject("GVDECOUPSTT.Appearance.FilterPanel.FontSizeDelta"), Integer)
        Me.GVDECOUPSTT.Appearance.FilterPanel.FontStyleDelta = CType(resources.GetObject("GVDECOUPSTT.Appearance.FilterPanel.FontStyleDelta"), System.Drawing.FontStyle)
        Me.GVDECOUPSTT.Appearance.FilterPanel.ForeColor = CType(resources.GetObject("GVDECOUPSTT.Appearance.FilterPanel.ForeColor"), System.Drawing.Color)
        Me.GVDECOUPSTT.Appearance.FilterPanel.GradientMode = CType(resources.GetObject("GVDECOUPSTT.Appearance.FilterPanel.GradientMode"), System.Drawing.Drawing2D.LinearGradientMode)
        Me.GVDECOUPSTT.Appearance.FilterPanel.Image = CType(resources.GetObject("GVDECOUPSTT.Appearance.FilterPanel.Image"), System.Drawing.Image)
        Me.GVDECOUPSTT.Appearance.FilterPanel.Options.UseBackColor = True
        Me.GVDECOUPSTT.Appearance.FilterPanel.Options.UseForeColor = True
        Me.GVDECOUPSTT.Appearance.FixedLine.BackColor = CType(resources.GetObject("GVDECOUPSTT.Appearance.FixedLine.BackColor"), System.Drawing.Color)
        Me.GVDECOUPSTT.Appearance.FixedLine.FontSizeDelta = CType(resources.GetObject("GVDECOUPSTT.Appearance.FixedLine.FontSizeDelta"), Integer)
        Me.GVDECOUPSTT.Appearance.FixedLine.FontStyleDelta = CType(resources.GetObject("GVDECOUPSTT.Appearance.FixedLine.FontStyleDelta"), System.Drawing.FontStyle)
        Me.GVDECOUPSTT.Appearance.FixedLine.GradientMode = CType(resources.GetObject("GVDECOUPSTT.Appearance.FixedLine.GradientMode"), System.Drawing.Drawing2D.LinearGradientMode)
        Me.GVDECOUPSTT.Appearance.FixedLine.Image = CType(resources.GetObject("GVDECOUPSTT.Appearance.FixedLine.Image"), System.Drawing.Image)
        Me.GVDECOUPSTT.Appearance.FixedLine.Options.UseBackColor = True
        Me.GVDECOUPSTT.Appearance.FocusedCell.BackColor = CType(resources.GetObject("GVDECOUPSTT.Appearance.FocusedCell.BackColor"), System.Drawing.Color)
        Me.GVDECOUPSTT.Appearance.FocusedCell.FontSizeDelta = CType(resources.GetObject("GVDECOUPSTT.Appearance.FocusedCell.FontSizeDelta"), Integer)
        Me.GVDECOUPSTT.Appearance.FocusedCell.FontStyleDelta = CType(resources.GetObject("GVDECOUPSTT.Appearance.FocusedCell.FontStyleDelta"), System.Drawing.FontStyle)
        Me.GVDECOUPSTT.Appearance.FocusedCell.ForeColor = CType(resources.GetObject("GVDECOUPSTT.Appearance.FocusedCell.ForeColor"), System.Drawing.Color)
        Me.GVDECOUPSTT.Appearance.FocusedCell.GradientMode = CType(resources.GetObject("GVDECOUPSTT.Appearance.FocusedCell.GradientMode"), System.Drawing.Drawing2D.LinearGradientMode)
        Me.GVDECOUPSTT.Appearance.FocusedCell.Image = CType(resources.GetObject("GVDECOUPSTT.Appearance.FocusedCell.Image"), System.Drawing.Image)
        Me.GVDECOUPSTT.Appearance.FocusedCell.Options.UseBackColor = True
        Me.GVDECOUPSTT.Appearance.FocusedCell.Options.UseForeColor = True
        Me.GVDECOUPSTT.Appearance.FocusedRow.BackColor = CType(resources.GetObject("GVDECOUPSTT.Appearance.FocusedRow.BackColor"), System.Drawing.Color)
        Me.GVDECOUPSTT.Appearance.FocusedRow.FontSizeDelta = CType(resources.GetObject("GVDECOUPSTT.Appearance.FocusedRow.FontSizeDelta"), Integer)
        Me.GVDECOUPSTT.Appearance.FocusedRow.FontStyleDelta = CType(resources.GetObject("GVDECOUPSTT.Appearance.FocusedRow.FontStyleDelta"), System.Drawing.FontStyle)
        Me.GVDECOUPSTT.Appearance.FocusedRow.ForeColor = CType(resources.GetObject("GVDECOUPSTT.Appearance.FocusedRow.ForeColor"), System.Drawing.Color)
        Me.GVDECOUPSTT.Appearance.FocusedRow.GradientMode = CType(resources.GetObject("GVDECOUPSTT.Appearance.FocusedRow.GradientMode"), System.Drawing.Drawing2D.LinearGradientMode)
        Me.GVDECOUPSTT.Appearance.FocusedRow.Image = CType(resources.GetObject("GVDECOUPSTT.Appearance.FocusedRow.Image"), System.Drawing.Image)
        Me.GVDECOUPSTT.Appearance.FocusedRow.Options.UseBackColor = True
        Me.GVDECOUPSTT.Appearance.FocusedRow.Options.UseForeColor = True
        Me.GVDECOUPSTT.Appearance.FooterPanel.BackColor = CType(resources.GetObject("GVDECOUPSTT.Appearance.FooterPanel.BackColor"), System.Drawing.Color)
        Me.GVDECOUPSTT.Appearance.FooterPanel.BorderColor = CType(resources.GetObject("GVDECOUPSTT.Appearance.FooterPanel.BorderColor"), System.Drawing.Color)
        Me.GVDECOUPSTT.Appearance.FooterPanel.FontSizeDelta = CType(resources.GetObject("GVDECOUPSTT.Appearance.FooterPanel.FontSizeDelta"), Integer)
        Me.GVDECOUPSTT.Appearance.FooterPanel.FontStyleDelta = CType(resources.GetObject("GVDECOUPSTT.Appearance.FooterPanel.FontStyleDelta"), System.Drawing.FontStyle)
        Me.GVDECOUPSTT.Appearance.FooterPanel.ForeColor = CType(resources.GetObject("GVDECOUPSTT.Appearance.FooterPanel.ForeColor"), System.Drawing.Color)
        Me.GVDECOUPSTT.Appearance.FooterPanel.GradientMode = CType(resources.GetObject("GVDECOUPSTT.Appearance.FooterPanel.GradientMode"), System.Drawing.Drawing2D.LinearGradientMode)
        Me.GVDECOUPSTT.Appearance.FooterPanel.Image = CType(resources.GetObject("GVDECOUPSTT.Appearance.FooterPanel.Image"), System.Drawing.Image)
        Me.GVDECOUPSTT.Appearance.FooterPanel.Options.UseBackColor = True
        Me.GVDECOUPSTT.Appearance.FooterPanel.Options.UseBorderColor = True
        Me.GVDECOUPSTT.Appearance.FooterPanel.Options.UseForeColor = True
        Me.GVDECOUPSTT.Appearance.GroupButton.BackColor = CType(resources.GetObject("GVDECOUPSTT.Appearance.GroupButton.BackColor"), System.Drawing.Color)
        Me.GVDECOUPSTT.Appearance.GroupButton.BorderColor = CType(resources.GetObject("GVDECOUPSTT.Appearance.GroupButton.BorderColor"), System.Drawing.Color)
        Me.GVDECOUPSTT.Appearance.GroupButton.FontSizeDelta = CType(resources.GetObject("GVDECOUPSTT.Appearance.GroupButton.FontSizeDelta"), Integer)
        Me.GVDECOUPSTT.Appearance.GroupButton.FontStyleDelta = CType(resources.GetObject("GVDECOUPSTT.Appearance.GroupButton.FontStyleDelta"), System.Drawing.FontStyle)
        Me.GVDECOUPSTT.Appearance.GroupButton.GradientMode = CType(resources.GetObject("GVDECOUPSTT.Appearance.GroupButton.GradientMode"), System.Drawing.Drawing2D.LinearGradientMode)
        Me.GVDECOUPSTT.Appearance.GroupButton.Image = CType(resources.GetObject("GVDECOUPSTT.Appearance.GroupButton.Image"), System.Drawing.Image)
        Me.GVDECOUPSTT.Appearance.GroupButton.Options.UseBackColor = True
        Me.GVDECOUPSTT.Appearance.GroupButton.Options.UseBorderColor = True
        Me.GVDECOUPSTT.Appearance.GroupFooter.BackColor = CType(resources.GetObject("GVDECOUPSTT.Appearance.GroupFooter.BackColor"), System.Drawing.Color)
        Me.GVDECOUPSTT.Appearance.GroupFooter.BorderColor = CType(resources.GetObject("GVDECOUPSTT.Appearance.GroupFooter.BorderColor"), System.Drawing.Color)
        Me.GVDECOUPSTT.Appearance.GroupFooter.FontSizeDelta = CType(resources.GetObject("GVDECOUPSTT.Appearance.GroupFooter.FontSizeDelta"), Integer)
        Me.GVDECOUPSTT.Appearance.GroupFooter.FontStyleDelta = CType(resources.GetObject("GVDECOUPSTT.Appearance.GroupFooter.FontStyleDelta"), System.Drawing.FontStyle)
        Me.GVDECOUPSTT.Appearance.GroupFooter.ForeColor = CType(resources.GetObject("GVDECOUPSTT.Appearance.GroupFooter.ForeColor"), System.Drawing.Color)
        Me.GVDECOUPSTT.Appearance.GroupFooter.GradientMode = CType(resources.GetObject("GVDECOUPSTT.Appearance.GroupFooter.GradientMode"), System.Drawing.Drawing2D.LinearGradientMode)
        Me.GVDECOUPSTT.Appearance.GroupFooter.Image = CType(resources.GetObject("GVDECOUPSTT.Appearance.GroupFooter.Image"), System.Drawing.Image)
        Me.GVDECOUPSTT.Appearance.GroupFooter.Options.UseBackColor = True
        Me.GVDECOUPSTT.Appearance.GroupFooter.Options.UseBorderColor = True
        Me.GVDECOUPSTT.Appearance.GroupFooter.Options.UseForeColor = True
        Me.GVDECOUPSTT.Appearance.GroupPanel.BackColor = CType(resources.GetObject("GVDECOUPSTT.Appearance.GroupPanel.BackColor"), System.Drawing.Color)
        Me.GVDECOUPSTT.Appearance.GroupPanel.BackColor2 = CType(resources.GetObject("GVDECOUPSTT.Appearance.GroupPanel.BackColor2"), System.Drawing.Color)
        Me.GVDECOUPSTT.Appearance.GroupPanel.FontSizeDelta = CType(resources.GetObject("GVDECOUPSTT.Appearance.GroupPanel.FontSizeDelta"), Integer)
        Me.GVDECOUPSTT.Appearance.GroupPanel.FontStyleDelta = CType(resources.GetObject("GVDECOUPSTT.Appearance.GroupPanel.FontStyleDelta"), System.Drawing.FontStyle)
        Me.GVDECOUPSTT.Appearance.GroupPanel.ForeColor = CType(resources.GetObject("GVDECOUPSTT.Appearance.GroupPanel.ForeColor"), System.Drawing.Color)
        Me.GVDECOUPSTT.Appearance.GroupPanel.GradientMode = CType(resources.GetObject("GVDECOUPSTT.Appearance.GroupPanel.GradientMode"), System.Drawing.Drawing2D.LinearGradientMode)
        Me.GVDECOUPSTT.Appearance.GroupPanel.Image = CType(resources.GetObject("GVDECOUPSTT.Appearance.GroupPanel.Image"), System.Drawing.Image)
        Me.GVDECOUPSTT.Appearance.GroupPanel.Options.UseBackColor = True
        Me.GVDECOUPSTT.Appearance.GroupPanel.Options.UseForeColor = True
        Me.GVDECOUPSTT.Appearance.GroupRow.BackColor = CType(resources.GetObject("GVDECOUPSTT.Appearance.GroupRow.BackColor"), System.Drawing.Color)
        Me.GVDECOUPSTT.Appearance.GroupRow.BorderColor = CType(resources.GetObject("GVDECOUPSTT.Appearance.GroupRow.BorderColor"), System.Drawing.Color)
        Me.GVDECOUPSTT.Appearance.GroupRow.FontSizeDelta = CType(resources.GetObject("GVDECOUPSTT.Appearance.GroupRow.FontSizeDelta"), Integer)
        Me.GVDECOUPSTT.Appearance.GroupRow.FontStyleDelta = CType(resources.GetObject("GVDECOUPSTT.Appearance.GroupRow.FontStyleDelta"), System.Drawing.FontStyle)
        Me.GVDECOUPSTT.Appearance.GroupRow.ForeColor = CType(resources.GetObject("GVDECOUPSTT.Appearance.GroupRow.ForeColor"), System.Drawing.Color)
        Me.GVDECOUPSTT.Appearance.GroupRow.GradientMode = CType(resources.GetObject("GVDECOUPSTT.Appearance.GroupRow.GradientMode"), System.Drawing.Drawing2D.LinearGradientMode)
        Me.GVDECOUPSTT.Appearance.GroupRow.Image = CType(resources.GetObject("GVDECOUPSTT.Appearance.GroupRow.Image"), System.Drawing.Image)
        Me.GVDECOUPSTT.Appearance.GroupRow.Options.UseBackColor = True
        Me.GVDECOUPSTT.Appearance.GroupRow.Options.UseBorderColor = True
        Me.GVDECOUPSTT.Appearance.GroupRow.Options.UseForeColor = True
        Me.GVDECOUPSTT.Appearance.HeaderPanel.BackColor = CType(resources.GetObject("GVDECOUPSTT.Appearance.HeaderPanel.BackColor"), System.Drawing.Color)
        Me.GVDECOUPSTT.Appearance.HeaderPanel.BorderColor = CType(resources.GetObject("GVDECOUPSTT.Appearance.HeaderPanel.BorderColor"), System.Drawing.Color)
        Me.GVDECOUPSTT.Appearance.HeaderPanel.FontSizeDelta = CType(resources.GetObject("GVDECOUPSTT.Appearance.HeaderPanel.FontSizeDelta"), Integer)
        Me.GVDECOUPSTT.Appearance.HeaderPanel.FontStyleDelta = CType(resources.GetObject("GVDECOUPSTT.Appearance.HeaderPanel.FontStyleDelta"), System.Drawing.FontStyle)
        Me.GVDECOUPSTT.Appearance.HeaderPanel.ForeColor = CType(resources.GetObject("GVDECOUPSTT.Appearance.HeaderPanel.ForeColor"), System.Drawing.Color)
        Me.GVDECOUPSTT.Appearance.HeaderPanel.GradientMode = CType(resources.GetObject("GVDECOUPSTT.Appearance.HeaderPanel.GradientMode"), System.Drawing.Drawing2D.LinearGradientMode)
        Me.GVDECOUPSTT.Appearance.HeaderPanel.Image = CType(resources.GetObject("GVDECOUPSTT.Appearance.HeaderPanel.Image"), System.Drawing.Image)
        Me.GVDECOUPSTT.Appearance.HeaderPanel.Options.UseBackColor = True
        Me.GVDECOUPSTT.Appearance.HeaderPanel.Options.UseBorderColor = True
        Me.GVDECOUPSTT.Appearance.HeaderPanel.Options.UseForeColor = True
        Me.GVDECOUPSTT.Appearance.HeaderPanel.Options.UseTextOptions = True
        Me.GVDECOUPSTT.Appearance.HeaderPanel.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center
        Me.GVDECOUPSTT.Appearance.HeaderPanel.TextOptions.VAlignment = DevExpress.Utils.VertAlignment.Center
        Me.GVDECOUPSTT.Appearance.HeaderPanel.TextOptions.WordWrap = DevExpress.Utils.WordWrap.Wrap
        Me.GVDECOUPSTT.Appearance.HideSelectionRow.BackColor = CType(resources.GetObject("GVDECOUPSTT.Appearance.HideSelectionRow.BackColor"), System.Drawing.Color)
        Me.GVDECOUPSTT.Appearance.HideSelectionRow.FontSizeDelta = CType(resources.GetObject("GVDECOUPSTT.Appearance.HideSelectionRow.FontSizeDelta"), Integer)
        Me.GVDECOUPSTT.Appearance.HideSelectionRow.FontStyleDelta = CType(resources.GetObject("GVDECOUPSTT.Appearance.HideSelectionRow.FontStyleDelta"), System.Drawing.FontStyle)
        Me.GVDECOUPSTT.Appearance.HideSelectionRow.ForeColor = CType(resources.GetObject("GVDECOUPSTT.Appearance.HideSelectionRow.ForeColor"), System.Drawing.Color)
        Me.GVDECOUPSTT.Appearance.HideSelectionRow.GradientMode = CType(resources.GetObject("GVDECOUPSTT.Appearance.HideSelectionRow.GradientMode"), System.Drawing.Drawing2D.LinearGradientMode)
        Me.GVDECOUPSTT.Appearance.HideSelectionRow.Image = CType(resources.GetObject("GVDECOUPSTT.Appearance.HideSelectionRow.Image"), System.Drawing.Image)
        Me.GVDECOUPSTT.Appearance.HideSelectionRow.Options.UseBackColor = True
        Me.GVDECOUPSTT.Appearance.HideSelectionRow.Options.UseForeColor = True
        Me.GVDECOUPSTT.Appearance.HorzLine.BackColor = CType(resources.GetObject("GVDECOUPSTT.Appearance.HorzLine.BackColor"), System.Drawing.Color)
        Me.GVDECOUPSTT.Appearance.HorzLine.BorderColor = CType(resources.GetObject("GVDECOUPSTT.Appearance.HorzLine.BorderColor"), System.Drawing.Color)
        Me.GVDECOUPSTT.Appearance.HorzLine.FontSizeDelta = CType(resources.GetObject("GVDECOUPSTT.Appearance.HorzLine.FontSizeDelta"), Integer)
        Me.GVDECOUPSTT.Appearance.HorzLine.FontStyleDelta = CType(resources.GetObject("GVDECOUPSTT.Appearance.HorzLine.FontStyleDelta"), System.Drawing.FontStyle)
        Me.GVDECOUPSTT.Appearance.HorzLine.GradientMode = CType(resources.GetObject("GVDECOUPSTT.Appearance.HorzLine.GradientMode"), System.Drawing.Drawing2D.LinearGradientMode)
        Me.GVDECOUPSTT.Appearance.HorzLine.Image = CType(resources.GetObject("GVDECOUPSTT.Appearance.HorzLine.Image"), System.Drawing.Image)
        Me.GVDECOUPSTT.Appearance.HorzLine.Options.UseBackColor = True
        Me.GVDECOUPSTT.Appearance.HorzLine.Options.UseBorderColor = True
        Me.GVDECOUPSTT.Appearance.OddRow.BackColor = CType(resources.GetObject("GVDECOUPSTT.Appearance.OddRow.BackColor"), System.Drawing.Color)
        Me.GVDECOUPSTT.Appearance.OddRow.BorderColor = CType(resources.GetObject("GVDECOUPSTT.Appearance.OddRow.BorderColor"), System.Drawing.Color)
        Me.GVDECOUPSTT.Appearance.OddRow.FontSizeDelta = CType(resources.GetObject("GVDECOUPSTT.Appearance.OddRow.FontSizeDelta"), Integer)
        Me.GVDECOUPSTT.Appearance.OddRow.FontStyleDelta = CType(resources.GetObject("GVDECOUPSTT.Appearance.OddRow.FontStyleDelta"), System.Drawing.FontStyle)
        Me.GVDECOUPSTT.Appearance.OddRow.ForeColor = CType(resources.GetObject("GVDECOUPSTT.Appearance.OddRow.ForeColor"), System.Drawing.Color)
        Me.GVDECOUPSTT.Appearance.OddRow.GradientMode = CType(resources.GetObject("GVDECOUPSTT.Appearance.OddRow.GradientMode"), System.Drawing.Drawing2D.LinearGradientMode)
        Me.GVDECOUPSTT.Appearance.OddRow.Image = CType(resources.GetObject("GVDECOUPSTT.Appearance.OddRow.Image"), System.Drawing.Image)
        Me.GVDECOUPSTT.Appearance.OddRow.Options.UseBackColor = True
        Me.GVDECOUPSTT.Appearance.OddRow.Options.UseBorderColor = True
        Me.GVDECOUPSTT.Appearance.OddRow.Options.UseForeColor = True
        Me.GVDECOUPSTT.Appearance.Preview.BackColor = CType(resources.GetObject("GVDECOUPSTT.Appearance.Preview.BackColor"), System.Drawing.Color)
        Me.GVDECOUPSTT.Appearance.Preview.Font = CType(resources.GetObject("GVDECOUPSTT.Appearance.Preview.Font"), System.Drawing.Font)
        Me.GVDECOUPSTT.Appearance.Preview.FontSizeDelta = CType(resources.GetObject("GVDECOUPSTT.Appearance.Preview.FontSizeDelta"), Integer)
        Me.GVDECOUPSTT.Appearance.Preview.FontStyleDelta = CType(resources.GetObject("GVDECOUPSTT.Appearance.Preview.FontStyleDelta"), System.Drawing.FontStyle)
        Me.GVDECOUPSTT.Appearance.Preview.ForeColor = CType(resources.GetObject("GVDECOUPSTT.Appearance.Preview.ForeColor"), System.Drawing.Color)
        Me.GVDECOUPSTT.Appearance.Preview.GradientMode = CType(resources.GetObject("GVDECOUPSTT.Appearance.Preview.GradientMode"), System.Drawing.Drawing2D.LinearGradientMode)
        Me.GVDECOUPSTT.Appearance.Preview.Image = CType(resources.GetObject("GVDECOUPSTT.Appearance.Preview.Image"), System.Drawing.Image)
        Me.GVDECOUPSTT.Appearance.Preview.Options.UseBackColor = True
        Me.GVDECOUPSTT.Appearance.Preview.Options.UseFont = True
        Me.GVDECOUPSTT.Appearance.Preview.Options.UseForeColor = True
        Me.GVDECOUPSTT.Appearance.Row.BackColor = CType(resources.GetObject("GVDECOUPSTT.Appearance.Row.BackColor"), System.Drawing.Color)
        Me.GVDECOUPSTT.Appearance.Row.FontSizeDelta = CType(resources.GetObject("GVDECOUPSTT.Appearance.Row.FontSizeDelta"), Integer)
        Me.GVDECOUPSTT.Appearance.Row.FontStyleDelta = CType(resources.GetObject("GVDECOUPSTT.Appearance.Row.FontStyleDelta"), System.Drawing.FontStyle)
        Me.GVDECOUPSTT.Appearance.Row.ForeColor = CType(resources.GetObject("GVDECOUPSTT.Appearance.Row.ForeColor"), System.Drawing.Color)
        Me.GVDECOUPSTT.Appearance.Row.GradientMode = CType(resources.GetObject("GVDECOUPSTT.Appearance.Row.GradientMode"), System.Drawing.Drawing2D.LinearGradientMode)
        Me.GVDECOUPSTT.Appearance.Row.Image = CType(resources.GetObject("GVDECOUPSTT.Appearance.Row.Image"), System.Drawing.Image)
        Me.GVDECOUPSTT.Appearance.Row.Options.UseBackColor = True
        Me.GVDECOUPSTT.Appearance.Row.Options.UseForeColor = True
        Me.GVDECOUPSTT.Appearance.RowSeparator.BackColor = CType(resources.GetObject("GVDECOUPSTT.Appearance.RowSeparator.BackColor"), System.Drawing.Color)
        Me.GVDECOUPSTT.Appearance.RowSeparator.BackColor2 = CType(resources.GetObject("GVDECOUPSTT.Appearance.RowSeparator.BackColor2"), System.Drawing.Color)
        Me.GVDECOUPSTT.Appearance.RowSeparator.FontSizeDelta = CType(resources.GetObject("GVDECOUPSTT.Appearance.RowSeparator.FontSizeDelta"), Integer)
        Me.GVDECOUPSTT.Appearance.RowSeparator.FontStyleDelta = CType(resources.GetObject("GVDECOUPSTT.Appearance.RowSeparator.FontStyleDelta"), System.Drawing.FontStyle)
        Me.GVDECOUPSTT.Appearance.RowSeparator.GradientMode = CType(resources.GetObject("GVDECOUPSTT.Appearance.RowSeparator.GradientMode"), System.Drawing.Drawing2D.LinearGradientMode)
        Me.GVDECOUPSTT.Appearance.RowSeparator.Image = CType(resources.GetObject("GVDECOUPSTT.Appearance.RowSeparator.Image"), System.Drawing.Image)
        Me.GVDECOUPSTT.Appearance.RowSeparator.Options.UseBackColor = True
        Me.GVDECOUPSTT.Appearance.SelectedRow.BackColor = CType(resources.GetObject("GVDECOUPSTT.Appearance.SelectedRow.BackColor"), System.Drawing.Color)
        Me.GVDECOUPSTT.Appearance.SelectedRow.FontSizeDelta = CType(resources.GetObject("GVDECOUPSTT.Appearance.SelectedRow.FontSizeDelta"), Integer)
        Me.GVDECOUPSTT.Appearance.SelectedRow.FontStyleDelta = CType(resources.GetObject("GVDECOUPSTT.Appearance.SelectedRow.FontStyleDelta"), System.Drawing.FontStyle)
        Me.GVDECOUPSTT.Appearance.SelectedRow.ForeColor = CType(resources.GetObject("GVDECOUPSTT.Appearance.SelectedRow.ForeColor"), System.Drawing.Color)
        Me.GVDECOUPSTT.Appearance.SelectedRow.GradientMode = CType(resources.GetObject("GVDECOUPSTT.Appearance.SelectedRow.GradientMode"), System.Drawing.Drawing2D.LinearGradientMode)
        Me.GVDECOUPSTT.Appearance.SelectedRow.Image = CType(resources.GetObject("GVDECOUPSTT.Appearance.SelectedRow.Image"), System.Drawing.Image)
        Me.GVDECOUPSTT.Appearance.SelectedRow.Options.UseBackColor = True
        Me.GVDECOUPSTT.Appearance.SelectedRow.Options.UseForeColor = True
        Me.GVDECOUPSTT.Appearance.TopNewRow.BackColor = CType(resources.GetObject("GVDECOUPSTT.Appearance.TopNewRow.BackColor"), System.Drawing.Color)
        Me.GVDECOUPSTT.Appearance.TopNewRow.FontSizeDelta = CType(resources.GetObject("GVDECOUPSTT.Appearance.TopNewRow.FontSizeDelta"), Integer)
        Me.GVDECOUPSTT.Appearance.TopNewRow.FontStyleDelta = CType(resources.GetObject("GVDECOUPSTT.Appearance.TopNewRow.FontStyleDelta"), System.Drawing.FontStyle)
        Me.GVDECOUPSTT.Appearance.TopNewRow.GradientMode = CType(resources.GetObject("GVDECOUPSTT.Appearance.TopNewRow.GradientMode"), System.Drawing.Drawing2D.LinearGradientMode)
        Me.GVDECOUPSTT.Appearance.TopNewRow.Image = CType(resources.GetObject("GVDECOUPSTT.Appearance.TopNewRow.Image"), System.Drawing.Image)
        Me.GVDECOUPSTT.Appearance.TopNewRow.Options.UseBackColor = True
        Me.GVDECOUPSTT.Appearance.VertLine.BackColor = CType(resources.GetObject("GVDECOUPSTT.Appearance.VertLine.BackColor"), System.Drawing.Color)
        Me.GVDECOUPSTT.Appearance.VertLine.BorderColor = CType(resources.GetObject("GVDECOUPSTT.Appearance.VertLine.BorderColor"), System.Drawing.Color)
        Me.GVDECOUPSTT.Appearance.VertLine.FontSizeDelta = CType(resources.GetObject("GVDECOUPSTT.Appearance.VertLine.FontSizeDelta"), Integer)
        Me.GVDECOUPSTT.Appearance.VertLine.FontStyleDelta = CType(resources.GetObject("GVDECOUPSTT.Appearance.VertLine.FontStyleDelta"), System.Drawing.FontStyle)
        Me.GVDECOUPSTT.Appearance.VertLine.GradientMode = CType(resources.GetObject("GVDECOUPSTT.Appearance.VertLine.GradientMode"), System.Drawing.Drawing2D.LinearGradientMode)
        Me.GVDECOUPSTT.Appearance.VertLine.Image = CType(resources.GetObject("GVDECOUPSTT.Appearance.VertLine.Image"), System.Drawing.Image)
        Me.GVDECOUPSTT.Appearance.VertLine.Options.UseBackColor = True
        Me.GVDECOUPSTT.Appearance.VertLine.Options.UseBorderColor = True
        resources.ApplyResources(Me.GVDECOUPSTT, "GVDECOUPSTT")
        Me.GVDECOUPSTT.Columns.AddRange(New DevExpress.XtraGrid.Columns.GridColumn() {Me.ColSTTVLIBDECOUPSTT, Me.ColSTTNBMO, Me.ColSTTMTTFO, Me.ColSTTMTTSTT})
        Me.GVDECOUPSTT.GridControl = Me.GCDECOUPSTT
        Me.GVDECOUPSTT.Name = "GVDECOUPSTT"
        Me.GVDECOUPSTT.OptionsBehavior.Editable = False
        Me.GVDECOUPSTT.OptionsBehavior.ReadOnly = True
        Me.GVDECOUPSTT.OptionsView.EnableAppearanceEvenRow = True
        Me.GVDECOUPSTT.OptionsView.EnableAppearanceOddRow = True
        Me.GVDECOUPSTT.OptionsView.ShowFooter = True
        Me.GVDECOUPSTT.OptionsView.ShowGroupPanel = False
        '
        'ColSTTVLIBDECOUPSTT
        '
        resources.ApplyResources(Me.ColSTTVLIBDECOUPSTT, "ColSTTVLIBDECOUPSTT")
        Me.ColSTTVLIBDECOUPSTT.FieldName = "VLIBDECOUPSTT"
        Me.ColSTTVLIBDECOUPSTT.Name = "ColSTTVLIBDECOUPSTT"
        '
        'ColSTTNBMO
        '
        resources.ApplyResources(Me.ColSTTNBMO, "ColSTTNBMO")
        Me.ColSTTNBMO.DisplayFormat.FormatString = "n2"
        Me.ColSTTNBMO.DisplayFormat.FormatType = DevExpress.Utils.FormatType.Numeric
        Me.ColSTTNBMO.FieldName = "NBMO"
        Me.ColSTTNBMO.Name = "ColSTTNBMO"
        Me.ColSTTNBMO.Summary.AddRange(New DevExpress.XtraGrid.GridSummaryItem() {New DevExpress.XtraGrid.GridColumnSummaryItem(CType(resources.GetObject("ColSTTNBMO.Summary"), DevExpress.Data.SummaryItemType), resources.GetString("ColSTTNBMO.Summary1"), resources.GetString("ColSTTNBMO.Summary2"))})
        '
        'ColSTTMTTFO
        '
        resources.ApplyResources(Me.ColSTTMTTFO, "ColSTTMTTFO")
        Me.ColSTTMTTFO.DisplayFormat.FormatString = "c2"
        Me.ColSTTMTTFO.DisplayFormat.FormatType = DevExpress.Utils.FormatType.Numeric
        Me.ColSTTMTTFO.FieldName = "MTTFO"
        Me.ColSTTMTTFO.Name = "ColSTTMTTFO"
        Me.ColSTTMTTFO.Summary.AddRange(New DevExpress.XtraGrid.GridSummaryItem() {New DevExpress.XtraGrid.GridColumnSummaryItem(CType(resources.GetObject("ColSTTMTTFO.Summary"), DevExpress.Data.SummaryItemType), resources.GetString("ColSTTMTTFO.Summary1"), resources.GetString("ColSTTMTTFO.Summary2"))})
        '
        'ColSTTMTTSTT
        '
        resources.ApplyResources(Me.ColSTTMTTSTT, "ColSTTMTTSTT")
        Me.ColSTTMTTSTT.DisplayFormat.FormatString = "n2"
        Me.ColSTTMTTSTT.DisplayFormat.FormatType = DevExpress.Utils.FormatType.Numeric
        Me.ColSTTMTTSTT.FieldName = "MTTSTT"
        Me.ColSTTMTTSTT.Name = "ColSTTMTTSTT"
        Me.ColSTTMTTSTT.Summary.AddRange(New DevExpress.XtraGrid.GridSummaryItem() {New DevExpress.XtraGrid.GridColumnSummaryItem(CType(resources.GetObject("ColSTTMTTSTT.Summary"), DevExpress.Data.SummaryItemType), resources.GetString("ColSTTMTTSTT.Summary1"), resources.GetString("ColSTTMTTSTT.Summary2"))})
        '
        'FrmDecoupChantier
        '
        resources.ApplyResources(Me, "$this")
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.Wheat
        Me.Controls.Add(Me.GrpBoxDecoupSTT)
        Me.Controls.Add(Me.GrpBoxDecoupFO)
        Me.Controls.Add(Me.GrpBoxDecoupMO)
        Me.Controls.Add(Me.GrpSeriePrest)
        Me.Controls.Add(Me.GrpPresentDevis)
        Me.Controls.Add(Me.GrpActions)
        Me.Controls.Add(Me.LblTitre)
        Me.Name = "FrmDecoupChantier"
        Me.WindowState = System.Windows.Forms.FormWindowState.Maximized
        Me.GrpActions.ResumeLayout(False)
        Me.GrpPresentDevis.ResumeLayout(False)
        CType(Me.GCDEVIS, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.GVDEVIS, System.ComponentModel.ISupportInitialize).EndInit()
        Me.GrpSeriePrest.ResumeLayout(False)
        CType(Me.GCSERIE, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.GVSERIE, System.ComponentModel.ISupportInitialize).EndInit()
        Me.GrpBoxDecoupMO.ResumeLayout(False)
        CType(Me.GCDECOUPMO, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.GVDECOUPMO, System.ComponentModel.ISupportInitialize).EndInit()
        Me.GrpBoxDecoupFO.ResumeLayout(False)
        CType(Me.GCDECOUPFO, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.GVDECOUPFO, System.ComponentModel.ISupportInitialize).EndInit()
        Me.GrpBoxDecoupSTT.ResumeLayout(False)
        CType(Me.GCDECOUPSTT, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.GVDECOUPSTT, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents GrpActions As System.Windows.Forms.GroupBox
    Friend WithEvents BtnFermer As System.Windows.Forms.Button
    Friend WithEvents LblTitre As System.Windows.Forms.Label
    Friend WithEvents GrpPresentDevis As System.Windows.Forms.GroupBox
    Friend WithEvents GrpSeriePrest As System.Windows.Forms.GroupBox
    Friend WithEvents SFD As System.Windows.Forms.SaveFileDialog
    Friend WithEvents GrpBoxDecoupMO As System.Windows.Forms.GroupBox
    Friend WithEvents GrpBoxDecoupFO As System.Windows.Forms.GroupBox
    Friend WithEvents GrpBoxDecoupSTT As System.Windows.Forms.GroupBox
    Friend WithEvents BtnExportDevisXLS As System.Windows.Forms.Button
    Friend WithEvents BtnExportSerieXLS As System.Windows.Forms.Button
    Friend WithEvents BtnExportDecoupMOXLS As System.Windows.Forms.Button
    Friend WithEvents BtnExportDecoupFOXLS As System.Windows.Forms.Button
    Friend WithEvents BtnExportDecoupSTTXLS As System.Windows.Forms.Button
    Private WithEvents GCDEVIS As DevExpress.XtraGrid.GridControl
    Private WithEvents GVDEVIS As DevExpress.XtraGrid.Views.Grid.GridView
    Private WithEvents GCSERIE As DevExpress.XtraGrid.GridControl
    Private WithEvents GVSERIE As DevExpress.XtraGrid.Views.Grid.GridView
    Private WithEvents ColDEVISVLIB As DevExpress.XtraGrid.Columns.GridColumn
    Private WithEvents ColDEVISMO As DevExpress.XtraGrid.Columns.GridColumn
    Private WithEvents ColDEVISFOU As DevExpress.XtraGrid.Columns.GridColumn
    Private WithEvents ColSERIEVLIB As DevExpress.XtraGrid.Columns.GridColumn
    Private WithEvents ColSERIEMO As DevExpress.XtraGrid.Columns.GridColumn
    Private WithEvents ColSERIEFOU As DevExpress.XtraGrid.Columns.GridColumn
    Private WithEvents ColDEVISDEBOURSE As DevExpress.XtraGrid.Columns.GridColumn
    Private WithEvents ColSERIEDEBOURSE As DevExpress.XtraGrid.Columns.GridColumn
    Private WithEvents GCDECOUPMO As DevExpress.XtraGrid.GridControl
    Private WithEvents GVDECOUPMO As DevExpress.XtraGrid.Views.Grid.GridView
    Private WithEvents GCDECOUPFO As DevExpress.XtraGrid.GridControl
    Private WithEvents GVDECOUPFO As DevExpress.XtraGrid.Views.Grid.GridView
    Private WithEvents GCDECOUPSTT As DevExpress.XtraGrid.GridControl
    Private WithEvents GVDECOUPSTT As DevExpress.XtraGrid.Views.Grid.GridView
    Private WithEvents ColMOVLIBDECOUPMO As DevExpress.XtraGrid.Columns.GridColumn
    Private WithEvents ColMONBMO As DevExpress.XtraGrid.Columns.GridColumn
    Private WithEvents ColMOMTTFO As DevExpress.XtraGrid.Columns.GridColumn
    Private WithEvents ColMOMTTSTT As DevExpress.XtraGrid.Columns.GridColumn
    Private WithEvents ColMOVLIBDECOUPFO As DevExpress.XtraGrid.Columns.GridColumn
    Private WithEvents ColFONBMO As DevExpress.XtraGrid.Columns.GridColumn
    Private WithEvents ColFOMTTFO As DevExpress.XtraGrid.Columns.GridColumn
    Private WithEvents ColFOMTTSTT As DevExpress.XtraGrid.Columns.GridColumn
    Private WithEvents ColSTTVLIBDECOUPSTT As DevExpress.XtraGrid.Columns.GridColumn
    Private WithEvents ColSTTNBMO As DevExpress.XtraGrid.Columns.GridColumn
    Private WithEvents ColSTTMTTFO As DevExpress.XtraGrid.Columns.GridColumn
    Private WithEvents ColSTTMTTSTT As DevExpress.XtraGrid.Columns.GridColumn
End Class
