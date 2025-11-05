<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class FrmDepensesAnalytique
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(FrmDepensesAnalytique))
        Me.LblTitre = New System.Windows.Forms.Label()
        Me.GrpActions = New System.Windows.Forms.GroupBox()
        Me.BtnExportPDF = New System.Windows.Forms.Button()
        Me.BtnExportXLS = New System.Windows.Forms.Button()
        Me.BtnFermer = New System.Windows.Forms.Button()
        Me.BtnPrint = New System.Windows.Forms.Button()
        Me.GrpPeriode = New System.Windows.Forms.GroupBox()
        Me.TxtAnnee = New System.Windows.Forms.TextBox()
        Me.TxtMois = New System.Windows.Forms.TextBox()
        Me.BtnValid = New System.Windows.Forms.Button()
        Me.LblAnnee = New System.Windows.Forms.Label()
        Me.LblMois = New System.Windows.Forms.Label()
        Me.GrpModele = New System.Windows.Forms.GroupBox()
        Me.GCANADEPMODELE = New DevExpress.XtraGrid.GridControl()
        Me.GVDEPANAMODELE = New DevExpress.XtraGrid.Views.Grid.GridView()
        Me.GModColVLIBELLE = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.GModColNDEPLOCMAT = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.GModColNDEPSTT = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.GModColNDEPTRANSP = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.GModColNDEPLOCVEH = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.GModColNDEPMAT = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.GModColNDEPDEPL = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.GModColNDEPPAN = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.GModColNDEPDOUANE = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.GModColNDEPHRMPT = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.GModColNDEPHRINT = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.GModColNDEPKMS = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.GModColNDEPSTOCK = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.GModColLINEMODELE = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.GrpDetail = New System.Windows.Forms.GroupBox()
        Me.GCDEPANADETAIL = New DevExpress.XtraGrid.GridControl()
        Me.GVDEPANADETAIL = New DevExpress.XtraGrid.Views.Grid.GridView()
        Me.GDetColNCANNUM = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.GDetCOLVCANLIB = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.GDetColTOTAL = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.GDetColNDEPLOCMAT = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.GDetColNDEPSTT = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.GDetColNDEPTRANSP = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.GDetColNDEPLOCVEH = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.GDetColNDEPMAT = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.GDetColNDEPDEPL = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.GEdtColNDEPPAN = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.GDetColNDEPDOUANE = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.GDetColNDEPHRMPT = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.GDetColNDEPHRINT = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.GDetColNDEPKMS = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.GDetColNDEPSTOCK = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.SFD = New System.Windows.Forms.SaveFileDialog()
        Me.GrpActions.SuspendLayout()
        Me.GrpPeriode.SuspendLayout()
        Me.GrpModele.SuspendLayout()
        CType(Me.GCANADEPMODELE, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.GVDEPANAMODELE, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.GrpDetail.SuspendLayout()
        CType(Me.GCDEPANADETAIL, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.GVDEPANADETAIL, System.ComponentModel.ISupportInitialize).BeginInit()
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
        Me.GrpActions.Controls.Add(Me.BtnExportPDF)
        Me.GrpActions.Controls.Add(Me.BtnExportXLS)
        Me.GrpActions.Controls.Add(Me.BtnFermer)
        Me.GrpActions.Controls.Add(Me.BtnPrint)
        Me.GrpActions.Name = "GrpActions"
        Me.GrpActions.TabStop = False
        '
        'BtnExportPDF
        '
        resources.ApplyResources(Me.BtnExportPDF, "BtnExportPDF")
        Me.BtnExportPDF.BackColor = System.Drawing.Color.LightYellow
        Me.BtnExportPDF.Name = "BtnExportPDF"
        Me.BtnExportPDF.UseVisualStyleBackColor = False
        '
        'BtnExportXLS
        '
        resources.ApplyResources(Me.BtnExportXLS, "BtnExportXLS")
        Me.BtnExportXLS.BackColor = System.Drawing.Color.LightYellow
        Me.BtnExportXLS.Name = "BtnExportXLS"
        Me.BtnExportXLS.UseVisualStyleBackColor = False
        '
        'BtnFermer
        '
        resources.ApplyResources(Me.BtnFermer, "BtnFermer")
        Me.BtnFermer.BackColor = System.Drawing.Color.LightYellow
        Me.BtnFermer.Name = "BtnFermer"
        Me.BtnFermer.UseVisualStyleBackColor = False
        '
        'BtnPrint
        '
        resources.ApplyResources(Me.BtnPrint, "BtnPrint")
        Me.BtnPrint.BackColor = System.Drawing.Color.LightYellow
        Me.BtnPrint.Name = "BtnPrint"
        Me.BtnPrint.UseVisualStyleBackColor = False
        '
        'GrpPeriode
        '
        resources.ApplyResources(Me.GrpPeriode, "GrpPeriode")
        Me.GrpPeriode.Controls.Add(Me.TxtAnnee)
        Me.GrpPeriode.Controls.Add(Me.TxtMois)
        Me.GrpPeriode.Controls.Add(Me.BtnValid)
        Me.GrpPeriode.Controls.Add(Me.LblAnnee)
        Me.GrpPeriode.Controls.Add(Me.LblMois)
        Me.GrpPeriode.Name = "GrpPeriode"
        Me.GrpPeriode.TabStop = False
        '
        'TxtAnnee
        '
        resources.ApplyResources(Me.TxtAnnee, "TxtAnnee")
        Me.TxtAnnee.Name = "TxtAnnee"
        '
        'TxtMois
        '
        resources.ApplyResources(Me.TxtMois, "TxtMois")
        Me.TxtMois.Name = "TxtMois"
        '
        'BtnValid
        '
        resources.ApplyResources(Me.BtnValid, "BtnValid")
        Me.BtnValid.Name = "BtnValid"
        Me.BtnValid.UseVisualStyleBackColor = True
        '
        'LblAnnee
        '
        resources.ApplyResources(Me.LblAnnee, "LblAnnee")
        Me.LblAnnee.Name = "LblAnnee"
        '
        'LblMois
        '
        resources.ApplyResources(Me.LblMois, "LblMois")
        Me.LblMois.Name = "LblMois"
        '
        'GrpModele
        '
        resources.ApplyResources(Me.GrpModele, "GrpModele")
        Me.GrpModele.Controls.Add(Me.GCANADEPMODELE)
        Me.GrpModele.Name = "GrpModele"
        Me.GrpModele.TabStop = False
        '
        'GCANADEPMODELE
        '
        resources.ApplyResources(Me.GCANADEPMODELE, "GCANADEPMODELE")
        '
        '
        '
        Me.GCANADEPMODELE.EmbeddedNavigator.AccessibleDescription = resources.GetString("GCANADEPMODELE.EmbeddedNavigator.AccessibleDescription")
        Me.GCANADEPMODELE.EmbeddedNavigator.AccessibleName = resources.GetString("GCANADEPMODELE.EmbeddedNavigator.AccessibleName")
        Me.GCANADEPMODELE.EmbeddedNavigator.AllowHtmlTextInToolTip = CType(resources.GetObject("GCANADEPMODELE.EmbeddedNavigator.AllowHtmlTextInToolTip"), DevExpress.Utils.DefaultBoolean)
        Me.GCANADEPMODELE.EmbeddedNavigator.Anchor = CType(resources.GetObject("GCANADEPMODELE.EmbeddedNavigator.Anchor"), System.Windows.Forms.AnchorStyles)
        Me.GCANADEPMODELE.EmbeddedNavigator.BackgroundImage = CType(resources.GetObject("GCANADEPMODELE.EmbeddedNavigator.BackgroundImage"), System.Drawing.Image)
        Me.GCANADEPMODELE.EmbeddedNavigator.BackgroundImageLayout = CType(resources.GetObject("GCANADEPMODELE.EmbeddedNavigator.BackgroundImageLayout"), System.Windows.Forms.ImageLayout)
        Me.GCANADEPMODELE.EmbeddedNavigator.ImeMode = CType(resources.GetObject("GCANADEPMODELE.EmbeddedNavigator.ImeMode"), System.Windows.Forms.ImeMode)
        Me.GCANADEPMODELE.EmbeddedNavigator.MaximumSize = CType(resources.GetObject("GCANADEPMODELE.EmbeddedNavigator.MaximumSize"), System.Drawing.Size)
        Me.GCANADEPMODELE.EmbeddedNavigator.TextLocation = CType(resources.GetObject("GCANADEPMODELE.EmbeddedNavigator.TextLocation"), DevExpress.XtraEditors.NavigatorButtonsTextLocation)
        Me.GCANADEPMODELE.EmbeddedNavigator.ToolTip = resources.GetString("GCANADEPMODELE.EmbeddedNavigator.ToolTip")
        Me.GCANADEPMODELE.EmbeddedNavigator.ToolTipIconType = CType(resources.GetObject("GCANADEPMODELE.EmbeddedNavigator.ToolTipIconType"), DevExpress.Utils.ToolTipIconType)
        Me.GCANADEPMODELE.EmbeddedNavigator.ToolTipTitle = resources.GetString("GCANADEPMODELE.EmbeddedNavigator.ToolTipTitle")
        Me.GCANADEPMODELE.MainView = Me.GVDEPANAMODELE
        Me.GCANADEPMODELE.Name = "GCANADEPMODELE"
        Me.GCANADEPMODELE.ViewCollection.AddRange(New DevExpress.XtraGrid.Views.Base.BaseView() {Me.GVDEPANAMODELE})
        '
        'GVDEPANAMODELE
        '
        Me.GVDEPANAMODELE.Appearance.ColumnFilterButton.BackColor = CType(resources.GetObject("GVDEPANAMODELE.Appearance.ColumnFilterButton.BackColor"), System.Drawing.Color)
        Me.GVDEPANAMODELE.Appearance.ColumnFilterButton.BorderColor = CType(resources.GetObject("GVDEPANAMODELE.Appearance.ColumnFilterButton.BorderColor"), System.Drawing.Color)
        Me.GVDEPANAMODELE.Appearance.ColumnFilterButton.FontSizeDelta = CType(resources.GetObject("GVDEPANAMODELE.Appearance.ColumnFilterButton.FontSizeDelta"), Integer)
        Me.GVDEPANAMODELE.Appearance.ColumnFilterButton.FontStyleDelta = CType(resources.GetObject("GVDEPANAMODELE.Appearance.ColumnFilterButton.FontStyleDelta"), System.Drawing.FontStyle)
        Me.GVDEPANAMODELE.Appearance.ColumnFilterButton.ForeColor = CType(resources.GetObject("GVDEPANAMODELE.Appearance.ColumnFilterButton.ForeColor"), System.Drawing.Color)
        Me.GVDEPANAMODELE.Appearance.ColumnFilterButton.GradientMode = CType(resources.GetObject("GVDEPANAMODELE.Appearance.ColumnFilterButton.GradientMode"), System.Drawing.Drawing2D.LinearGradientMode)
        Me.GVDEPANAMODELE.Appearance.ColumnFilterButton.Image = CType(resources.GetObject("GVDEPANAMODELE.Appearance.ColumnFilterButton.Image"), System.Drawing.Image)
        Me.GVDEPANAMODELE.Appearance.ColumnFilterButton.Options.UseBackColor = True
        Me.GVDEPANAMODELE.Appearance.ColumnFilterButton.Options.UseBorderColor = True
        Me.GVDEPANAMODELE.Appearance.ColumnFilterButton.Options.UseForeColor = True
        Me.GVDEPANAMODELE.Appearance.ColumnFilterButtonActive.BackColor = CType(resources.GetObject("GVDEPANAMODELE.Appearance.ColumnFilterButtonActive.BackColor"), System.Drawing.Color)
        Me.GVDEPANAMODELE.Appearance.ColumnFilterButtonActive.BorderColor = CType(resources.GetObject("GVDEPANAMODELE.Appearance.ColumnFilterButtonActive.BorderColor"), System.Drawing.Color)
        Me.GVDEPANAMODELE.Appearance.ColumnFilterButtonActive.FontSizeDelta = CType(resources.GetObject("GVDEPANAMODELE.Appearance.ColumnFilterButtonActive.FontSizeDelta"), Integer)
        Me.GVDEPANAMODELE.Appearance.ColumnFilterButtonActive.FontStyleDelta = CType(resources.GetObject("GVDEPANAMODELE.Appearance.ColumnFilterButtonActive.FontStyleDelta"), System.Drawing.FontStyle)
        Me.GVDEPANAMODELE.Appearance.ColumnFilterButtonActive.ForeColor = CType(resources.GetObject("GVDEPANAMODELE.Appearance.ColumnFilterButtonActive.ForeColor"), System.Drawing.Color)
        Me.GVDEPANAMODELE.Appearance.ColumnFilterButtonActive.GradientMode = CType(resources.GetObject("GVDEPANAMODELE.Appearance.ColumnFilterButtonActive.GradientMode"), System.Drawing.Drawing2D.LinearGradientMode)
        Me.GVDEPANAMODELE.Appearance.ColumnFilterButtonActive.Image = CType(resources.GetObject("GVDEPANAMODELE.Appearance.ColumnFilterButtonActive.Image"), System.Drawing.Image)
        Me.GVDEPANAMODELE.Appearance.ColumnFilterButtonActive.Options.UseBackColor = True
        Me.GVDEPANAMODELE.Appearance.ColumnFilterButtonActive.Options.UseBorderColor = True
        Me.GVDEPANAMODELE.Appearance.ColumnFilterButtonActive.Options.UseForeColor = True
        Me.GVDEPANAMODELE.Appearance.Empty.BackColor = CType(resources.GetObject("GVDEPANAMODELE.Appearance.Empty.BackColor"), System.Drawing.Color)
        Me.GVDEPANAMODELE.Appearance.Empty.BackColor2 = CType(resources.GetObject("GVDEPANAMODELE.Appearance.Empty.BackColor2"), System.Drawing.Color)
        Me.GVDEPANAMODELE.Appearance.Empty.FontSizeDelta = CType(resources.GetObject("GVDEPANAMODELE.Appearance.Empty.FontSizeDelta"), Integer)
        Me.GVDEPANAMODELE.Appearance.Empty.FontStyleDelta = CType(resources.GetObject("GVDEPANAMODELE.Appearance.Empty.FontStyleDelta"), System.Drawing.FontStyle)
        Me.GVDEPANAMODELE.Appearance.Empty.GradientMode = CType(resources.GetObject("GVDEPANAMODELE.Appearance.Empty.GradientMode"), System.Drawing.Drawing2D.LinearGradientMode)
        Me.GVDEPANAMODELE.Appearance.Empty.Image = CType(resources.GetObject("GVDEPANAMODELE.Appearance.Empty.Image"), System.Drawing.Image)
        Me.GVDEPANAMODELE.Appearance.Empty.Options.UseBackColor = True
        Me.GVDEPANAMODELE.Appearance.EvenRow.BackColor = CType(resources.GetObject("GVDEPANAMODELE.Appearance.EvenRow.BackColor"), System.Drawing.Color)
        Me.GVDEPANAMODELE.Appearance.EvenRow.BorderColor = CType(resources.GetObject("GVDEPANAMODELE.Appearance.EvenRow.BorderColor"), System.Drawing.Color)
        Me.GVDEPANAMODELE.Appearance.EvenRow.FontSizeDelta = CType(resources.GetObject("GVDEPANAMODELE.Appearance.EvenRow.FontSizeDelta"), Integer)
        Me.GVDEPANAMODELE.Appearance.EvenRow.FontStyleDelta = CType(resources.GetObject("GVDEPANAMODELE.Appearance.EvenRow.FontStyleDelta"), System.Drawing.FontStyle)
        Me.GVDEPANAMODELE.Appearance.EvenRow.ForeColor = CType(resources.GetObject("GVDEPANAMODELE.Appearance.EvenRow.ForeColor"), System.Drawing.Color)
        Me.GVDEPANAMODELE.Appearance.EvenRow.GradientMode = CType(resources.GetObject("GVDEPANAMODELE.Appearance.EvenRow.GradientMode"), System.Drawing.Drawing2D.LinearGradientMode)
        Me.GVDEPANAMODELE.Appearance.EvenRow.Image = CType(resources.GetObject("GVDEPANAMODELE.Appearance.EvenRow.Image"), System.Drawing.Image)
        Me.GVDEPANAMODELE.Appearance.EvenRow.Options.UseBackColor = True
        Me.GVDEPANAMODELE.Appearance.EvenRow.Options.UseBorderColor = True
        Me.GVDEPANAMODELE.Appearance.EvenRow.Options.UseForeColor = True
        Me.GVDEPANAMODELE.Appearance.FilterCloseButton.BackColor = CType(resources.GetObject("GVDEPANAMODELE.Appearance.FilterCloseButton.BackColor"), System.Drawing.Color)
        Me.GVDEPANAMODELE.Appearance.FilterCloseButton.BorderColor = CType(resources.GetObject("GVDEPANAMODELE.Appearance.FilterCloseButton.BorderColor"), System.Drawing.Color)
        Me.GVDEPANAMODELE.Appearance.FilterCloseButton.FontSizeDelta = CType(resources.GetObject("GVDEPANAMODELE.Appearance.FilterCloseButton.FontSizeDelta"), Integer)
        Me.GVDEPANAMODELE.Appearance.FilterCloseButton.FontStyleDelta = CType(resources.GetObject("GVDEPANAMODELE.Appearance.FilterCloseButton.FontStyleDelta"), System.Drawing.FontStyle)
        Me.GVDEPANAMODELE.Appearance.FilterCloseButton.ForeColor = CType(resources.GetObject("GVDEPANAMODELE.Appearance.FilterCloseButton.ForeColor"), System.Drawing.Color)
        Me.GVDEPANAMODELE.Appearance.FilterCloseButton.GradientMode = CType(resources.GetObject("GVDEPANAMODELE.Appearance.FilterCloseButton.GradientMode"), System.Drawing.Drawing2D.LinearGradientMode)
        Me.GVDEPANAMODELE.Appearance.FilterCloseButton.Image = CType(resources.GetObject("GVDEPANAMODELE.Appearance.FilterCloseButton.Image"), System.Drawing.Image)
        Me.GVDEPANAMODELE.Appearance.FilterCloseButton.Options.UseBackColor = True
        Me.GVDEPANAMODELE.Appearance.FilterCloseButton.Options.UseBorderColor = True
        Me.GVDEPANAMODELE.Appearance.FilterCloseButton.Options.UseForeColor = True
        Me.GVDEPANAMODELE.Appearance.FilterPanel.BackColor = CType(resources.GetObject("GVDEPANAMODELE.Appearance.FilterPanel.BackColor"), System.Drawing.Color)
        Me.GVDEPANAMODELE.Appearance.FilterPanel.BackColor2 = CType(resources.GetObject("GVDEPANAMODELE.Appearance.FilterPanel.BackColor2"), System.Drawing.Color)
        Me.GVDEPANAMODELE.Appearance.FilterPanel.FontSizeDelta = CType(resources.GetObject("GVDEPANAMODELE.Appearance.FilterPanel.FontSizeDelta"), Integer)
        Me.GVDEPANAMODELE.Appearance.FilterPanel.FontStyleDelta = CType(resources.GetObject("GVDEPANAMODELE.Appearance.FilterPanel.FontStyleDelta"), System.Drawing.FontStyle)
        Me.GVDEPANAMODELE.Appearance.FilterPanel.ForeColor = CType(resources.GetObject("GVDEPANAMODELE.Appearance.FilterPanel.ForeColor"), System.Drawing.Color)
        Me.GVDEPANAMODELE.Appearance.FilterPanel.GradientMode = CType(resources.GetObject("GVDEPANAMODELE.Appearance.FilterPanel.GradientMode"), System.Drawing.Drawing2D.LinearGradientMode)
        Me.GVDEPANAMODELE.Appearance.FilterPanel.Image = CType(resources.GetObject("GVDEPANAMODELE.Appearance.FilterPanel.Image"), System.Drawing.Image)
        Me.GVDEPANAMODELE.Appearance.FilterPanel.Options.UseBackColor = True
        Me.GVDEPANAMODELE.Appearance.FilterPanel.Options.UseForeColor = True
        Me.GVDEPANAMODELE.Appearance.FixedLine.BackColor = CType(resources.GetObject("GVDEPANAMODELE.Appearance.FixedLine.BackColor"), System.Drawing.Color)
        Me.GVDEPANAMODELE.Appearance.FixedLine.FontSizeDelta = CType(resources.GetObject("GVDEPANAMODELE.Appearance.FixedLine.FontSizeDelta"), Integer)
        Me.GVDEPANAMODELE.Appearance.FixedLine.FontStyleDelta = CType(resources.GetObject("GVDEPANAMODELE.Appearance.FixedLine.FontStyleDelta"), System.Drawing.FontStyle)
        Me.GVDEPANAMODELE.Appearance.FixedLine.GradientMode = CType(resources.GetObject("GVDEPANAMODELE.Appearance.FixedLine.GradientMode"), System.Drawing.Drawing2D.LinearGradientMode)
        Me.GVDEPANAMODELE.Appearance.FixedLine.Image = CType(resources.GetObject("GVDEPANAMODELE.Appearance.FixedLine.Image"), System.Drawing.Image)
        Me.GVDEPANAMODELE.Appearance.FixedLine.Options.UseBackColor = True
        Me.GVDEPANAMODELE.Appearance.FocusedCell.BackColor = CType(resources.GetObject("GVDEPANAMODELE.Appearance.FocusedCell.BackColor"), System.Drawing.Color)
        Me.GVDEPANAMODELE.Appearance.FocusedCell.FontSizeDelta = CType(resources.GetObject("GVDEPANAMODELE.Appearance.FocusedCell.FontSizeDelta"), Integer)
        Me.GVDEPANAMODELE.Appearance.FocusedCell.FontStyleDelta = CType(resources.GetObject("GVDEPANAMODELE.Appearance.FocusedCell.FontStyleDelta"), System.Drawing.FontStyle)
        Me.GVDEPANAMODELE.Appearance.FocusedCell.ForeColor = CType(resources.GetObject("GVDEPANAMODELE.Appearance.FocusedCell.ForeColor"), System.Drawing.Color)
        Me.GVDEPANAMODELE.Appearance.FocusedCell.GradientMode = CType(resources.GetObject("GVDEPANAMODELE.Appearance.FocusedCell.GradientMode"), System.Drawing.Drawing2D.LinearGradientMode)
        Me.GVDEPANAMODELE.Appearance.FocusedCell.Image = CType(resources.GetObject("GVDEPANAMODELE.Appearance.FocusedCell.Image"), System.Drawing.Image)
        Me.GVDEPANAMODELE.Appearance.FocusedCell.Options.UseBackColor = True
        Me.GVDEPANAMODELE.Appearance.FocusedCell.Options.UseForeColor = True
        Me.GVDEPANAMODELE.Appearance.FocusedRow.BackColor = CType(resources.GetObject("GVDEPANAMODELE.Appearance.FocusedRow.BackColor"), System.Drawing.Color)
        Me.GVDEPANAMODELE.Appearance.FocusedRow.BorderColor = CType(resources.GetObject("GVDEPANAMODELE.Appearance.FocusedRow.BorderColor"), System.Drawing.Color)
        Me.GVDEPANAMODELE.Appearance.FocusedRow.FontSizeDelta = CType(resources.GetObject("GVDEPANAMODELE.Appearance.FocusedRow.FontSizeDelta"), Integer)
        Me.GVDEPANAMODELE.Appearance.FocusedRow.FontStyleDelta = CType(resources.GetObject("GVDEPANAMODELE.Appearance.FocusedRow.FontStyleDelta"), System.Drawing.FontStyle)
        Me.GVDEPANAMODELE.Appearance.FocusedRow.ForeColor = CType(resources.GetObject("GVDEPANAMODELE.Appearance.FocusedRow.ForeColor"), System.Drawing.Color)
        Me.GVDEPANAMODELE.Appearance.FocusedRow.GradientMode = CType(resources.GetObject("GVDEPANAMODELE.Appearance.FocusedRow.GradientMode"), System.Drawing.Drawing2D.LinearGradientMode)
        Me.GVDEPANAMODELE.Appearance.FocusedRow.Image = CType(resources.GetObject("GVDEPANAMODELE.Appearance.FocusedRow.Image"), System.Drawing.Image)
        Me.GVDEPANAMODELE.Appearance.FocusedRow.Options.UseBackColor = True
        Me.GVDEPANAMODELE.Appearance.FocusedRow.Options.UseBorderColor = True
        Me.GVDEPANAMODELE.Appearance.FocusedRow.Options.UseForeColor = True
        Me.GVDEPANAMODELE.Appearance.FooterPanel.BackColor = CType(resources.GetObject("GVDEPANAMODELE.Appearance.FooterPanel.BackColor"), System.Drawing.Color)
        Me.GVDEPANAMODELE.Appearance.FooterPanel.BorderColor = CType(resources.GetObject("GVDEPANAMODELE.Appearance.FooterPanel.BorderColor"), System.Drawing.Color)
        Me.GVDEPANAMODELE.Appearance.FooterPanel.FontSizeDelta = CType(resources.GetObject("GVDEPANAMODELE.Appearance.FooterPanel.FontSizeDelta"), Integer)
        Me.GVDEPANAMODELE.Appearance.FooterPanel.FontStyleDelta = CType(resources.GetObject("GVDEPANAMODELE.Appearance.FooterPanel.FontStyleDelta"), System.Drawing.FontStyle)
        Me.GVDEPANAMODELE.Appearance.FooterPanel.ForeColor = CType(resources.GetObject("GVDEPANAMODELE.Appearance.FooterPanel.ForeColor"), System.Drawing.Color)
        Me.GVDEPANAMODELE.Appearance.FooterPanel.GradientMode = CType(resources.GetObject("GVDEPANAMODELE.Appearance.FooterPanel.GradientMode"), System.Drawing.Drawing2D.LinearGradientMode)
        Me.GVDEPANAMODELE.Appearance.FooterPanel.Image = CType(resources.GetObject("GVDEPANAMODELE.Appearance.FooterPanel.Image"), System.Drawing.Image)
        Me.GVDEPANAMODELE.Appearance.FooterPanel.Options.UseBackColor = True
        Me.GVDEPANAMODELE.Appearance.FooterPanel.Options.UseBorderColor = True
        Me.GVDEPANAMODELE.Appearance.FooterPanel.Options.UseForeColor = True
        Me.GVDEPANAMODELE.Appearance.GroupButton.BackColor = CType(resources.GetObject("GVDEPANAMODELE.Appearance.GroupButton.BackColor"), System.Drawing.Color)
        Me.GVDEPANAMODELE.Appearance.GroupButton.BorderColor = CType(resources.GetObject("GVDEPANAMODELE.Appearance.GroupButton.BorderColor"), System.Drawing.Color)
        Me.GVDEPANAMODELE.Appearance.GroupButton.FontSizeDelta = CType(resources.GetObject("GVDEPANAMODELE.Appearance.GroupButton.FontSizeDelta"), Integer)
        Me.GVDEPANAMODELE.Appearance.GroupButton.FontStyleDelta = CType(resources.GetObject("GVDEPANAMODELE.Appearance.GroupButton.FontStyleDelta"), System.Drawing.FontStyle)
        Me.GVDEPANAMODELE.Appearance.GroupButton.GradientMode = CType(resources.GetObject("GVDEPANAMODELE.Appearance.GroupButton.GradientMode"), System.Drawing.Drawing2D.LinearGradientMode)
        Me.GVDEPANAMODELE.Appearance.GroupButton.Image = CType(resources.GetObject("GVDEPANAMODELE.Appearance.GroupButton.Image"), System.Drawing.Image)
        Me.GVDEPANAMODELE.Appearance.GroupButton.Options.UseBackColor = True
        Me.GVDEPANAMODELE.Appearance.GroupButton.Options.UseBorderColor = True
        Me.GVDEPANAMODELE.Appearance.GroupFooter.BackColor = CType(resources.GetObject("GVDEPANAMODELE.Appearance.GroupFooter.BackColor"), System.Drawing.Color)
        Me.GVDEPANAMODELE.Appearance.GroupFooter.BorderColor = CType(resources.GetObject("GVDEPANAMODELE.Appearance.GroupFooter.BorderColor"), System.Drawing.Color)
        Me.GVDEPANAMODELE.Appearance.GroupFooter.FontSizeDelta = CType(resources.GetObject("GVDEPANAMODELE.Appearance.GroupFooter.FontSizeDelta"), Integer)
        Me.GVDEPANAMODELE.Appearance.GroupFooter.FontStyleDelta = CType(resources.GetObject("GVDEPANAMODELE.Appearance.GroupFooter.FontStyleDelta"), System.Drawing.FontStyle)
        Me.GVDEPANAMODELE.Appearance.GroupFooter.ForeColor = CType(resources.GetObject("GVDEPANAMODELE.Appearance.GroupFooter.ForeColor"), System.Drawing.Color)
        Me.GVDEPANAMODELE.Appearance.GroupFooter.GradientMode = CType(resources.GetObject("GVDEPANAMODELE.Appearance.GroupFooter.GradientMode"), System.Drawing.Drawing2D.LinearGradientMode)
        Me.GVDEPANAMODELE.Appearance.GroupFooter.Image = CType(resources.GetObject("GVDEPANAMODELE.Appearance.GroupFooter.Image"), System.Drawing.Image)
        Me.GVDEPANAMODELE.Appearance.GroupFooter.Options.UseBackColor = True
        Me.GVDEPANAMODELE.Appearance.GroupFooter.Options.UseBorderColor = True
        Me.GVDEPANAMODELE.Appearance.GroupFooter.Options.UseForeColor = True
        Me.GVDEPANAMODELE.Appearance.GroupPanel.BackColor = CType(resources.GetObject("GVDEPANAMODELE.Appearance.GroupPanel.BackColor"), System.Drawing.Color)
        Me.GVDEPANAMODELE.Appearance.GroupPanel.BackColor2 = CType(resources.GetObject("GVDEPANAMODELE.Appearance.GroupPanel.BackColor2"), System.Drawing.Color)
        Me.GVDEPANAMODELE.Appearance.GroupPanel.FontSizeDelta = CType(resources.GetObject("GVDEPANAMODELE.Appearance.GroupPanel.FontSizeDelta"), Integer)
        Me.GVDEPANAMODELE.Appearance.GroupPanel.FontStyleDelta = CType(resources.GetObject("GVDEPANAMODELE.Appearance.GroupPanel.FontStyleDelta"), System.Drawing.FontStyle)
        Me.GVDEPANAMODELE.Appearance.GroupPanel.ForeColor = CType(resources.GetObject("GVDEPANAMODELE.Appearance.GroupPanel.ForeColor"), System.Drawing.Color)
        Me.GVDEPANAMODELE.Appearance.GroupPanel.GradientMode = CType(resources.GetObject("GVDEPANAMODELE.Appearance.GroupPanel.GradientMode"), System.Drawing.Drawing2D.LinearGradientMode)
        Me.GVDEPANAMODELE.Appearance.GroupPanel.Image = CType(resources.GetObject("GVDEPANAMODELE.Appearance.GroupPanel.Image"), System.Drawing.Image)
        Me.GVDEPANAMODELE.Appearance.GroupPanel.Options.UseBackColor = True
        Me.GVDEPANAMODELE.Appearance.GroupPanel.Options.UseForeColor = True
        Me.GVDEPANAMODELE.Appearance.GroupRow.BackColor = CType(resources.GetObject("GVDEPANAMODELE.Appearance.GroupRow.BackColor"), System.Drawing.Color)
        Me.GVDEPANAMODELE.Appearance.GroupRow.BorderColor = CType(resources.GetObject("GVDEPANAMODELE.Appearance.GroupRow.BorderColor"), System.Drawing.Color)
        Me.GVDEPANAMODELE.Appearance.GroupRow.FontSizeDelta = CType(resources.GetObject("GVDEPANAMODELE.Appearance.GroupRow.FontSizeDelta"), Integer)
        Me.GVDEPANAMODELE.Appearance.GroupRow.FontStyleDelta = CType(resources.GetObject("GVDEPANAMODELE.Appearance.GroupRow.FontStyleDelta"), System.Drawing.FontStyle)
        Me.GVDEPANAMODELE.Appearance.GroupRow.ForeColor = CType(resources.GetObject("GVDEPANAMODELE.Appearance.GroupRow.ForeColor"), System.Drawing.Color)
        Me.GVDEPANAMODELE.Appearance.GroupRow.GradientMode = CType(resources.GetObject("GVDEPANAMODELE.Appearance.GroupRow.GradientMode"), System.Drawing.Drawing2D.LinearGradientMode)
        Me.GVDEPANAMODELE.Appearance.GroupRow.Image = CType(resources.GetObject("GVDEPANAMODELE.Appearance.GroupRow.Image"), System.Drawing.Image)
        Me.GVDEPANAMODELE.Appearance.GroupRow.Options.UseBackColor = True
        Me.GVDEPANAMODELE.Appearance.GroupRow.Options.UseBorderColor = True
        Me.GVDEPANAMODELE.Appearance.GroupRow.Options.UseForeColor = True
        Me.GVDEPANAMODELE.Appearance.HeaderPanel.BackColor = CType(resources.GetObject("GVDEPANAMODELE.Appearance.HeaderPanel.BackColor"), System.Drawing.Color)
        Me.GVDEPANAMODELE.Appearance.HeaderPanel.BorderColor = CType(resources.GetObject("GVDEPANAMODELE.Appearance.HeaderPanel.BorderColor"), System.Drawing.Color)
        Me.GVDEPANAMODELE.Appearance.HeaderPanel.Font = CType(resources.GetObject("GVDEPANAMODELE.Appearance.HeaderPanel.Font"), System.Drawing.Font)
        Me.GVDEPANAMODELE.Appearance.HeaderPanel.FontSizeDelta = CType(resources.GetObject("GVDEPANAMODELE.Appearance.HeaderPanel.FontSizeDelta"), Integer)
        Me.GVDEPANAMODELE.Appearance.HeaderPanel.FontStyleDelta = CType(resources.GetObject("GVDEPANAMODELE.Appearance.HeaderPanel.FontStyleDelta"), System.Drawing.FontStyle)
        Me.GVDEPANAMODELE.Appearance.HeaderPanel.ForeColor = CType(resources.GetObject("GVDEPANAMODELE.Appearance.HeaderPanel.ForeColor"), System.Drawing.Color)
        Me.GVDEPANAMODELE.Appearance.HeaderPanel.GradientMode = CType(resources.GetObject("GVDEPANAMODELE.Appearance.HeaderPanel.GradientMode"), System.Drawing.Drawing2D.LinearGradientMode)
        Me.GVDEPANAMODELE.Appearance.HeaderPanel.Image = CType(resources.GetObject("GVDEPANAMODELE.Appearance.HeaderPanel.Image"), System.Drawing.Image)
        Me.GVDEPANAMODELE.Appearance.HeaderPanel.Options.UseBackColor = True
        Me.GVDEPANAMODELE.Appearance.HeaderPanel.Options.UseBorderColor = True
        Me.GVDEPANAMODELE.Appearance.HeaderPanel.Options.UseFont = True
        Me.GVDEPANAMODELE.Appearance.HeaderPanel.Options.UseForeColor = True
        Me.GVDEPANAMODELE.Appearance.HeaderPanel.Options.UseTextOptions = True
        Me.GVDEPANAMODELE.Appearance.HeaderPanel.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center
        Me.GVDEPANAMODELE.Appearance.HeaderPanel.TextOptions.VAlignment = DevExpress.Utils.VertAlignment.Center
        Me.GVDEPANAMODELE.Appearance.HeaderPanel.TextOptions.WordWrap = DevExpress.Utils.WordWrap.Wrap
        Me.GVDEPANAMODELE.Appearance.HideSelectionRow.BackColor = CType(resources.GetObject("GVDEPANAMODELE.Appearance.HideSelectionRow.BackColor"), System.Drawing.Color)
        Me.GVDEPANAMODELE.Appearance.HideSelectionRow.BorderColor = CType(resources.GetObject("GVDEPANAMODELE.Appearance.HideSelectionRow.BorderColor"), System.Drawing.Color)
        Me.GVDEPANAMODELE.Appearance.HideSelectionRow.FontSizeDelta = CType(resources.GetObject("GVDEPANAMODELE.Appearance.HideSelectionRow.FontSizeDelta"), Integer)
        Me.GVDEPANAMODELE.Appearance.HideSelectionRow.FontStyleDelta = CType(resources.GetObject("GVDEPANAMODELE.Appearance.HideSelectionRow.FontStyleDelta"), System.Drawing.FontStyle)
        Me.GVDEPANAMODELE.Appearance.HideSelectionRow.ForeColor = CType(resources.GetObject("GVDEPANAMODELE.Appearance.HideSelectionRow.ForeColor"), System.Drawing.Color)
        Me.GVDEPANAMODELE.Appearance.HideSelectionRow.GradientMode = CType(resources.GetObject("GVDEPANAMODELE.Appearance.HideSelectionRow.GradientMode"), System.Drawing.Drawing2D.LinearGradientMode)
        Me.GVDEPANAMODELE.Appearance.HideSelectionRow.Image = CType(resources.GetObject("GVDEPANAMODELE.Appearance.HideSelectionRow.Image"), System.Drawing.Image)
        Me.GVDEPANAMODELE.Appearance.HideSelectionRow.Options.UseBackColor = True
        Me.GVDEPANAMODELE.Appearance.HideSelectionRow.Options.UseBorderColor = True
        Me.GVDEPANAMODELE.Appearance.HideSelectionRow.Options.UseForeColor = True
        Me.GVDEPANAMODELE.Appearance.HorzLine.BackColor = CType(resources.GetObject("GVDEPANAMODELE.Appearance.HorzLine.BackColor"), System.Drawing.Color)
        Me.GVDEPANAMODELE.Appearance.HorzLine.FontSizeDelta = CType(resources.GetObject("GVDEPANAMODELE.Appearance.HorzLine.FontSizeDelta"), Integer)
        Me.GVDEPANAMODELE.Appearance.HorzLine.FontStyleDelta = CType(resources.GetObject("GVDEPANAMODELE.Appearance.HorzLine.FontStyleDelta"), System.Drawing.FontStyle)
        Me.GVDEPANAMODELE.Appearance.HorzLine.GradientMode = CType(resources.GetObject("GVDEPANAMODELE.Appearance.HorzLine.GradientMode"), System.Drawing.Drawing2D.LinearGradientMode)
        Me.GVDEPANAMODELE.Appearance.HorzLine.Image = CType(resources.GetObject("GVDEPANAMODELE.Appearance.HorzLine.Image"), System.Drawing.Image)
        Me.GVDEPANAMODELE.Appearance.HorzLine.Options.UseBackColor = True
        Me.GVDEPANAMODELE.Appearance.OddRow.BackColor = CType(resources.GetObject("GVDEPANAMODELE.Appearance.OddRow.BackColor"), System.Drawing.Color)
        Me.GVDEPANAMODELE.Appearance.OddRow.BorderColor = CType(resources.GetObject("GVDEPANAMODELE.Appearance.OddRow.BorderColor"), System.Drawing.Color)
        Me.GVDEPANAMODELE.Appearance.OddRow.FontSizeDelta = CType(resources.GetObject("GVDEPANAMODELE.Appearance.OddRow.FontSizeDelta"), Integer)
        Me.GVDEPANAMODELE.Appearance.OddRow.FontStyleDelta = CType(resources.GetObject("GVDEPANAMODELE.Appearance.OddRow.FontStyleDelta"), System.Drawing.FontStyle)
        Me.GVDEPANAMODELE.Appearance.OddRow.ForeColor = CType(resources.GetObject("GVDEPANAMODELE.Appearance.OddRow.ForeColor"), System.Drawing.Color)
        Me.GVDEPANAMODELE.Appearance.OddRow.GradientMode = CType(resources.GetObject("GVDEPANAMODELE.Appearance.OddRow.GradientMode"), System.Drawing.Drawing2D.LinearGradientMode)
        Me.GVDEPANAMODELE.Appearance.OddRow.Image = CType(resources.GetObject("GVDEPANAMODELE.Appearance.OddRow.Image"), System.Drawing.Image)
        Me.GVDEPANAMODELE.Appearance.OddRow.Options.UseBackColor = True
        Me.GVDEPANAMODELE.Appearance.OddRow.Options.UseBorderColor = True
        Me.GVDEPANAMODELE.Appearance.OddRow.Options.UseForeColor = True
        Me.GVDEPANAMODELE.Appearance.Preview.Font = CType(resources.GetObject("GVDEPANAMODELE.Appearance.Preview.Font"), System.Drawing.Font)
        Me.GVDEPANAMODELE.Appearance.Preview.FontSizeDelta = CType(resources.GetObject("GVDEPANAMODELE.Appearance.Preview.FontSizeDelta"), Integer)
        Me.GVDEPANAMODELE.Appearance.Preview.FontStyleDelta = CType(resources.GetObject("GVDEPANAMODELE.Appearance.Preview.FontStyleDelta"), System.Drawing.FontStyle)
        Me.GVDEPANAMODELE.Appearance.Preview.ForeColor = CType(resources.GetObject("GVDEPANAMODELE.Appearance.Preview.ForeColor"), System.Drawing.Color)
        Me.GVDEPANAMODELE.Appearance.Preview.GradientMode = CType(resources.GetObject("GVDEPANAMODELE.Appearance.Preview.GradientMode"), System.Drawing.Drawing2D.LinearGradientMode)
        Me.GVDEPANAMODELE.Appearance.Preview.Image = CType(resources.GetObject("GVDEPANAMODELE.Appearance.Preview.Image"), System.Drawing.Image)
        Me.GVDEPANAMODELE.Appearance.Preview.Options.UseFont = True
        Me.GVDEPANAMODELE.Appearance.Preview.Options.UseForeColor = True
        Me.GVDEPANAMODELE.Appearance.Row.BackColor = CType(resources.GetObject("GVDEPANAMODELE.Appearance.Row.BackColor"), System.Drawing.Color)
        Me.GVDEPANAMODELE.Appearance.Row.FontSizeDelta = CType(resources.GetObject("GVDEPANAMODELE.Appearance.Row.FontSizeDelta"), Integer)
        Me.GVDEPANAMODELE.Appearance.Row.FontStyleDelta = CType(resources.GetObject("GVDEPANAMODELE.Appearance.Row.FontStyleDelta"), System.Drawing.FontStyle)
        Me.GVDEPANAMODELE.Appearance.Row.ForeColor = CType(resources.GetObject("GVDEPANAMODELE.Appearance.Row.ForeColor"), System.Drawing.Color)
        Me.GVDEPANAMODELE.Appearance.Row.GradientMode = CType(resources.GetObject("GVDEPANAMODELE.Appearance.Row.GradientMode"), System.Drawing.Drawing2D.LinearGradientMode)
        Me.GVDEPANAMODELE.Appearance.Row.Image = CType(resources.GetObject("GVDEPANAMODELE.Appearance.Row.Image"), System.Drawing.Image)
        Me.GVDEPANAMODELE.Appearance.Row.Options.UseBackColor = True
        Me.GVDEPANAMODELE.Appearance.Row.Options.UseForeColor = True
        Me.GVDEPANAMODELE.Appearance.RowSeparator.BackColor = CType(resources.GetObject("GVDEPANAMODELE.Appearance.RowSeparator.BackColor"), System.Drawing.Color)
        Me.GVDEPANAMODELE.Appearance.RowSeparator.BackColor2 = CType(resources.GetObject("GVDEPANAMODELE.Appearance.RowSeparator.BackColor2"), System.Drawing.Color)
        Me.GVDEPANAMODELE.Appearance.RowSeparator.FontSizeDelta = CType(resources.GetObject("GVDEPANAMODELE.Appearance.RowSeparator.FontSizeDelta"), Integer)
        Me.GVDEPANAMODELE.Appearance.RowSeparator.FontStyleDelta = CType(resources.GetObject("GVDEPANAMODELE.Appearance.RowSeparator.FontStyleDelta"), System.Drawing.FontStyle)
        Me.GVDEPANAMODELE.Appearance.RowSeparator.GradientMode = CType(resources.GetObject("GVDEPANAMODELE.Appearance.RowSeparator.GradientMode"), System.Drawing.Drawing2D.LinearGradientMode)
        Me.GVDEPANAMODELE.Appearance.RowSeparator.Image = CType(resources.GetObject("GVDEPANAMODELE.Appearance.RowSeparator.Image"), System.Drawing.Image)
        Me.GVDEPANAMODELE.Appearance.RowSeparator.Options.UseBackColor = True
        Me.GVDEPANAMODELE.Appearance.SelectedRow.BackColor = CType(resources.GetObject("GVDEPANAMODELE.Appearance.SelectedRow.BackColor"), System.Drawing.Color)
        Me.GVDEPANAMODELE.Appearance.SelectedRow.FontSizeDelta = CType(resources.GetObject("GVDEPANAMODELE.Appearance.SelectedRow.FontSizeDelta"), Integer)
        Me.GVDEPANAMODELE.Appearance.SelectedRow.FontStyleDelta = CType(resources.GetObject("GVDEPANAMODELE.Appearance.SelectedRow.FontStyleDelta"), System.Drawing.FontStyle)
        Me.GVDEPANAMODELE.Appearance.SelectedRow.ForeColor = CType(resources.GetObject("GVDEPANAMODELE.Appearance.SelectedRow.ForeColor"), System.Drawing.Color)
        Me.GVDEPANAMODELE.Appearance.SelectedRow.GradientMode = CType(resources.GetObject("GVDEPANAMODELE.Appearance.SelectedRow.GradientMode"), System.Drawing.Drawing2D.LinearGradientMode)
        Me.GVDEPANAMODELE.Appearance.SelectedRow.Image = CType(resources.GetObject("GVDEPANAMODELE.Appearance.SelectedRow.Image"), System.Drawing.Image)
        Me.GVDEPANAMODELE.Appearance.SelectedRow.Options.UseBackColor = True
        Me.GVDEPANAMODELE.Appearance.SelectedRow.Options.UseForeColor = True
        Me.GVDEPANAMODELE.Appearance.TopNewRow.BackColor = CType(resources.GetObject("GVDEPANAMODELE.Appearance.TopNewRow.BackColor"), System.Drawing.Color)
        Me.GVDEPANAMODELE.Appearance.TopNewRow.FontSizeDelta = CType(resources.GetObject("GVDEPANAMODELE.Appearance.TopNewRow.FontSizeDelta"), Integer)
        Me.GVDEPANAMODELE.Appearance.TopNewRow.FontStyleDelta = CType(resources.GetObject("GVDEPANAMODELE.Appearance.TopNewRow.FontStyleDelta"), System.Drawing.FontStyle)
        Me.GVDEPANAMODELE.Appearance.TopNewRow.GradientMode = CType(resources.GetObject("GVDEPANAMODELE.Appearance.TopNewRow.GradientMode"), System.Drawing.Drawing2D.LinearGradientMode)
        Me.GVDEPANAMODELE.Appearance.TopNewRow.Image = CType(resources.GetObject("GVDEPANAMODELE.Appearance.TopNewRow.Image"), System.Drawing.Image)
        Me.GVDEPANAMODELE.Appearance.TopNewRow.Options.UseBackColor = True
        Me.GVDEPANAMODELE.Appearance.VertLine.BackColor = CType(resources.GetObject("GVDEPANAMODELE.Appearance.VertLine.BackColor"), System.Drawing.Color)
        Me.GVDEPANAMODELE.Appearance.VertLine.FontSizeDelta = CType(resources.GetObject("GVDEPANAMODELE.Appearance.VertLine.FontSizeDelta"), Integer)
        Me.GVDEPANAMODELE.Appearance.VertLine.FontStyleDelta = CType(resources.GetObject("GVDEPANAMODELE.Appearance.VertLine.FontStyleDelta"), System.Drawing.FontStyle)
        Me.GVDEPANAMODELE.Appearance.VertLine.GradientMode = CType(resources.GetObject("GVDEPANAMODELE.Appearance.VertLine.GradientMode"), System.Drawing.Drawing2D.LinearGradientMode)
        Me.GVDEPANAMODELE.Appearance.VertLine.Image = CType(resources.GetObject("GVDEPANAMODELE.Appearance.VertLine.Image"), System.Drawing.Image)
        Me.GVDEPANAMODELE.Appearance.VertLine.Options.UseBackColor = True
        resources.ApplyResources(Me.GVDEPANAMODELE, "GVDEPANAMODELE")
        Me.GVDEPANAMODELE.ColumnPanelRowHeight = 50
        Me.GVDEPANAMODELE.Columns.AddRange(New DevExpress.XtraGrid.Columns.GridColumn() {Me.GModColVLIBELLE, Me.GModColNDEPLOCMAT, Me.GModColNDEPSTT, Me.GModColNDEPTRANSP, Me.GModColNDEPLOCVEH, Me.GModColNDEPMAT, Me.GModColNDEPDEPL, Me.GModColNDEPPAN, Me.GModColNDEPDOUANE, Me.GModColNDEPHRMPT, Me.GModColNDEPHRINT, Me.GModColNDEPKMS, Me.GModColNDEPSTOCK, Me.GModColLINEMODELE})
        Me.GVDEPANAMODELE.GridControl = Me.GCANADEPMODELE
        Me.GVDEPANAMODELE.Name = "GVDEPANAMODELE"
        Me.GVDEPANAMODELE.OptionsBehavior.Editable = False
        Me.GVDEPANAMODELE.OptionsBehavior.ReadOnly = True
        Me.GVDEPANAMODELE.OptionsCustomization.AllowSort = False
        Me.GVDEPANAMODELE.OptionsView.EnableAppearanceEvenRow = True
        Me.GVDEPANAMODELE.OptionsView.EnableAppearanceOddRow = True
        Me.GVDEPANAMODELE.OptionsView.ShowGroupPanel = False
        Me.GVDEPANAMODELE.RowHeight = 40
        '
        'GModColVLIBELLE
        '
        resources.ApplyResources(Me.GModColVLIBELLE, "GModColVLIBELLE")
        Me.GModColVLIBELLE.FieldName = "VLIBELLE"
        Me.GModColVLIBELLE.Name = "GModColVLIBELLE"
        '
        'GModColNDEPLOCMAT
        '
        resources.ApplyResources(Me.GModColNDEPLOCMAT, "GModColNDEPLOCMAT")
        Me.GModColNDEPLOCMAT.DisplayFormat.FormatString = "p"
        Me.GModColNDEPLOCMAT.DisplayFormat.FormatType = DevExpress.Utils.FormatType.Numeric
        Me.GModColNDEPLOCMAT.FieldName = "NDEPLOCMAT"
        Me.GModColNDEPLOCMAT.Name = "GModColNDEPLOCMAT"
        '
        'GModColNDEPSTT
        '
        resources.ApplyResources(Me.GModColNDEPSTT, "GModColNDEPSTT")
        Me.GModColNDEPSTT.DisplayFormat.FormatString = "p"
        Me.GModColNDEPSTT.DisplayFormat.FormatType = DevExpress.Utils.FormatType.Numeric
        Me.GModColNDEPSTT.FieldName = "NDEPSTT"
        Me.GModColNDEPSTT.Name = "GModColNDEPSTT"
        '
        'GModColNDEPTRANSP
        '
        resources.ApplyResources(Me.GModColNDEPTRANSP, "GModColNDEPTRANSP")
        Me.GModColNDEPTRANSP.DisplayFormat.FormatString = "p"
        Me.GModColNDEPTRANSP.DisplayFormat.FormatType = DevExpress.Utils.FormatType.Numeric
        Me.GModColNDEPTRANSP.FieldName = "NDEPTRANSP"
        Me.GModColNDEPTRANSP.Name = "GModColNDEPTRANSP"
        '
        'GModColNDEPLOCVEH
        '
        resources.ApplyResources(Me.GModColNDEPLOCVEH, "GModColNDEPLOCVEH")
        Me.GModColNDEPLOCVEH.DisplayFormat.FormatString = "p"
        Me.GModColNDEPLOCVEH.DisplayFormat.FormatType = DevExpress.Utils.FormatType.Numeric
        Me.GModColNDEPLOCVEH.FieldName = "NDEPLOCVEH"
        Me.GModColNDEPLOCVEH.Name = "GModColNDEPLOCVEH"
        '
        'GModColNDEPMAT
        '
        resources.ApplyResources(Me.GModColNDEPMAT, "GModColNDEPMAT")
        Me.GModColNDEPMAT.DisplayFormat.FormatString = "p"
        Me.GModColNDEPMAT.DisplayFormat.FormatType = DevExpress.Utils.FormatType.Numeric
        Me.GModColNDEPMAT.FieldName = "NDEPMAT"
        Me.GModColNDEPMAT.Name = "GModColNDEPMAT"
        '
        'GModColNDEPDEPL
        '
        resources.ApplyResources(Me.GModColNDEPDEPL, "GModColNDEPDEPL")
        Me.GModColNDEPDEPL.DisplayFormat.FormatString = "p"
        Me.GModColNDEPDEPL.DisplayFormat.FormatType = DevExpress.Utils.FormatType.Numeric
        Me.GModColNDEPDEPL.FieldName = "NDEPDEPL"
        Me.GModColNDEPDEPL.Name = "GModColNDEPDEPL"
        '
        'GModColNDEPPAN
        '
        resources.ApplyResources(Me.GModColNDEPPAN, "GModColNDEPPAN")
        Me.GModColNDEPPAN.DisplayFormat.FormatString = "p"
        Me.GModColNDEPPAN.DisplayFormat.FormatType = DevExpress.Utils.FormatType.Numeric
        Me.GModColNDEPPAN.FieldName = "NDEPPAN"
        Me.GModColNDEPPAN.Name = "GModColNDEPPAN"
        '
        'GModColNDEPDOUANE
        '
        resources.ApplyResources(Me.GModColNDEPDOUANE, "GModColNDEPDOUANE")
        Me.GModColNDEPDOUANE.DisplayFormat.FormatString = "p"
        Me.GModColNDEPDOUANE.DisplayFormat.FormatType = DevExpress.Utils.FormatType.Numeric
        Me.GModColNDEPDOUANE.FieldName = "NDEPDOUANE"
        Me.GModColNDEPDOUANE.Name = "GModColNDEPDOUANE"
        '
        'GModColNDEPHRMPT
        '
        resources.ApplyResources(Me.GModColNDEPHRMPT, "GModColNDEPHRMPT")
        Me.GModColNDEPHRMPT.DisplayFormat.FormatString = "p"
        Me.GModColNDEPHRMPT.DisplayFormat.FormatType = DevExpress.Utils.FormatType.Numeric
        Me.GModColNDEPHRMPT.FieldName = "NDEPHRMPT"
        Me.GModColNDEPHRMPT.Name = "GModColNDEPHRMPT"
        '
        'GModColNDEPHRINT
        '
        resources.ApplyResources(Me.GModColNDEPHRINT, "GModColNDEPHRINT")
        Me.GModColNDEPHRINT.DisplayFormat.FormatString = "p"
        Me.GModColNDEPHRINT.DisplayFormat.FormatType = DevExpress.Utils.FormatType.Numeric
        Me.GModColNDEPHRINT.FieldName = "NDEPHRINT"
        Me.GModColNDEPHRINT.Name = "GModColNDEPHRINT"
        '
        'GModColNDEPKMS
        '
        resources.ApplyResources(Me.GModColNDEPKMS, "GModColNDEPKMS")
        Me.GModColNDEPKMS.DisplayFormat.FormatString = "p"
        Me.GModColNDEPKMS.DisplayFormat.FormatType = DevExpress.Utils.FormatType.Numeric
        Me.GModColNDEPKMS.FieldName = "NDEPKMS"
        Me.GModColNDEPKMS.Name = "GModColNDEPKMS"
        '
        'GModColNDEPSTOCK
        '
        resources.ApplyResources(Me.GModColNDEPSTOCK, "GModColNDEPSTOCK")
        Me.GModColNDEPSTOCK.DisplayFormat.FormatString = "p"
        Me.GModColNDEPSTOCK.DisplayFormat.FormatType = DevExpress.Utils.FormatType.Numeric
        Me.GModColNDEPSTOCK.FieldName = "NDEPSTOCK"
        Me.GModColNDEPSTOCK.Name = "GModColNDEPSTOCK"
        '
        'GModColLINEMODELE
        '
        resources.ApplyResources(Me.GModColLINEMODELE, "GModColLINEMODELE")
        Me.GModColLINEMODELE.FieldName = "LINEMODELE"
        Me.GModColLINEMODELE.Name = "GModColLINEMODELE"
        '
        'GrpDetail
        '
        resources.ApplyResources(Me.GrpDetail, "GrpDetail")
        Me.GrpDetail.Controls.Add(Me.GCDEPANADETAIL)
        Me.GrpDetail.Name = "GrpDetail"
        Me.GrpDetail.TabStop = False
        '
        'GCDEPANADETAIL
        '
        resources.ApplyResources(Me.GCDEPANADETAIL, "GCDEPANADETAIL")
        '
        '
        '
        Me.GCDEPANADETAIL.EmbeddedNavigator.AccessibleDescription = resources.GetString("GCDEPANADETAIL.EmbeddedNavigator.AccessibleDescription")
        Me.GCDEPANADETAIL.EmbeddedNavigator.AccessibleName = resources.GetString("GCDEPANADETAIL.EmbeddedNavigator.AccessibleName")
        Me.GCDEPANADETAIL.EmbeddedNavigator.AllowHtmlTextInToolTip = CType(resources.GetObject("GCDEPANADETAIL.EmbeddedNavigator.AllowHtmlTextInToolTip"), DevExpress.Utils.DefaultBoolean)
        Me.GCDEPANADETAIL.EmbeddedNavigator.Anchor = CType(resources.GetObject("GCDEPANADETAIL.EmbeddedNavigator.Anchor"), System.Windows.Forms.AnchorStyles)
        Me.GCDEPANADETAIL.EmbeddedNavigator.BackgroundImage = CType(resources.GetObject("GCDEPANADETAIL.EmbeddedNavigator.BackgroundImage"), System.Drawing.Image)
        Me.GCDEPANADETAIL.EmbeddedNavigator.BackgroundImageLayout = CType(resources.GetObject("GCDEPANADETAIL.EmbeddedNavigator.BackgroundImageLayout"), System.Windows.Forms.ImageLayout)
        Me.GCDEPANADETAIL.EmbeddedNavigator.ImeMode = CType(resources.GetObject("GCDEPANADETAIL.EmbeddedNavigator.ImeMode"), System.Windows.Forms.ImeMode)
        Me.GCDEPANADETAIL.EmbeddedNavigator.MaximumSize = CType(resources.GetObject("GCDEPANADETAIL.EmbeddedNavigator.MaximumSize"), System.Drawing.Size)
        Me.GCDEPANADETAIL.EmbeddedNavigator.TextLocation = CType(resources.GetObject("GCDEPANADETAIL.EmbeddedNavigator.TextLocation"), DevExpress.XtraEditors.NavigatorButtonsTextLocation)
        Me.GCDEPANADETAIL.EmbeddedNavigator.ToolTip = resources.GetString("GCDEPANADETAIL.EmbeddedNavigator.ToolTip")
        Me.GCDEPANADETAIL.EmbeddedNavigator.ToolTipIconType = CType(resources.GetObject("GCDEPANADETAIL.EmbeddedNavigator.ToolTipIconType"), DevExpress.Utils.ToolTipIconType)
        Me.GCDEPANADETAIL.EmbeddedNavigator.ToolTipTitle = resources.GetString("GCDEPANADETAIL.EmbeddedNavigator.ToolTipTitle")
        Me.GCDEPANADETAIL.MainView = Me.GVDEPANADETAIL
        Me.GCDEPANADETAIL.Name = "GCDEPANADETAIL"
        Me.GCDEPANADETAIL.ViewCollection.AddRange(New DevExpress.XtraGrid.Views.Base.BaseView() {Me.GVDEPANADETAIL})
        '
        'GVDEPANADETAIL
        '
        Me.GVDEPANADETAIL.Appearance.ColumnFilterButton.BackColor = CType(resources.GetObject("GVDEPANADETAIL.Appearance.ColumnFilterButton.BackColor"), System.Drawing.Color)
        Me.GVDEPANADETAIL.Appearance.ColumnFilterButton.BackColor2 = CType(resources.GetObject("GVDEPANADETAIL.Appearance.ColumnFilterButton.BackColor2"), System.Drawing.Color)
        Me.GVDEPANADETAIL.Appearance.ColumnFilterButton.BorderColor = CType(resources.GetObject("GVDEPANADETAIL.Appearance.ColumnFilterButton.BorderColor"), System.Drawing.Color)
        Me.GVDEPANADETAIL.Appearance.ColumnFilterButton.FontSizeDelta = CType(resources.GetObject("GVDEPANADETAIL.Appearance.ColumnFilterButton.FontSizeDelta"), Integer)
        Me.GVDEPANADETAIL.Appearance.ColumnFilterButton.FontStyleDelta = CType(resources.GetObject("GVDEPANADETAIL.Appearance.ColumnFilterButton.FontStyleDelta"), System.Drawing.FontStyle)
        Me.GVDEPANADETAIL.Appearance.ColumnFilterButton.ForeColor = CType(resources.GetObject("GVDEPANADETAIL.Appearance.ColumnFilterButton.ForeColor"), System.Drawing.Color)
        Me.GVDEPANADETAIL.Appearance.ColumnFilterButton.GradientMode = CType(resources.GetObject("GVDEPANADETAIL.Appearance.ColumnFilterButton.GradientMode"), System.Drawing.Drawing2D.LinearGradientMode)
        Me.GVDEPANADETAIL.Appearance.ColumnFilterButton.Image = CType(resources.GetObject("GVDEPANADETAIL.Appearance.ColumnFilterButton.Image"), System.Drawing.Image)
        Me.GVDEPANADETAIL.Appearance.ColumnFilterButton.Options.UseBackColor = True
        Me.GVDEPANADETAIL.Appearance.ColumnFilterButton.Options.UseBorderColor = True
        Me.GVDEPANADETAIL.Appearance.ColumnFilterButton.Options.UseForeColor = True
        Me.GVDEPANADETAIL.Appearance.ColumnFilterButtonActive.BackColor = CType(resources.GetObject("GVDEPANADETAIL.Appearance.ColumnFilterButtonActive.BackColor"), System.Drawing.Color)
        Me.GVDEPANADETAIL.Appearance.ColumnFilterButtonActive.BackColor2 = CType(resources.GetObject("GVDEPANADETAIL.Appearance.ColumnFilterButtonActive.BackColor2"), System.Drawing.Color)
        Me.GVDEPANADETAIL.Appearance.ColumnFilterButtonActive.BorderColor = CType(resources.GetObject("GVDEPANADETAIL.Appearance.ColumnFilterButtonActive.BorderColor"), System.Drawing.Color)
        Me.GVDEPANADETAIL.Appearance.ColumnFilterButtonActive.FontSizeDelta = CType(resources.GetObject("GVDEPANADETAIL.Appearance.ColumnFilterButtonActive.FontSizeDelta"), Integer)
        Me.GVDEPANADETAIL.Appearance.ColumnFilterButtonActive.FontStyleDelta = CType(resources.GetObject("GVDEPANADETAIL.Appearance.ColumnFilterButtonActive.FontStyleDelta"), System.Drawing.FontStyle)
        Me.GVDEPANADETAIL.Appearance.ColumnFilterButtonActive.ForeColor = CType(resources.GetObject("GVDEPANADETAIL.Appearance.ColumnFilterButtonActive.ForeColor"), System.Drawing.Color)
        Me.GVDEPANADETAIL.Appearance.ColumnFilterButtonActive.GradientMode = CType(resources.GetObject("GVDEPANADETAIL.Appearance.ColumnFilterButtonActive.GradientMode"), System.Drawing.Drawing2D.LinearGradientMode)
        Me.GVDEPANADETAIL.Appearance.ColumnFilterButtonActive.Image = CType(resources.GetObject("GVDEPANADETAIL.Appearance.ColumnFilterButtonActive.Image"), System.Drawing.Image)
        Me.GVDEPANADETAIL.Appearance.ColumnFilterButtonActive.Options.UseBackColor = True
        Me.GVDEPANADETAIL.Appearance.ColumnFilterButtonActive.Options.UseBorderColor = True
        Me.GVDEPANADETAIL.Appearance.ColumnFilterButtonActive.Options.UseForeColor = True
        Me.GVDEPANADETAIL.Appearance.Empty.BackColor = CType(resources.GetObject("GVDEPANADETAIL.Appearance.Empty.BackColor"), System.Drawing.Color)
        Me.GVDEPANADETAIL.Appearance.Empty.FontSizeDelta = CType(resources.GetObject("GVDEPANADETAIL.Appearance.Empty.FontSizeDelta"), Integer)
        Me.GVDEPANADETAIL.Appearance.Empty.FontStyleDelta = CType(resources.GetObject("GVDEPANADETAIL.Appearance.Empty.FontStyleDelta"), System.Drawing.FontStyle)
        Me.GVDEPANADETAIL.Appearance.Empty.GradientMode = CType(resources.GetObject("GVDEPANADETAIL.Appearance.Empty.GradientMode"), System.Drawing.Drawing2D.LinearGradientMode)
        Me.GVDEPANADETAIL.Appearance.Empty.Image = CType(resources.GetObject("GVDEPANADETAIL.Appearance.Empty.Image"), System.Drawing.Image)
        Me.GVDEPANADETAIL.Appearance.Empty.Options.UseBackColor = True
        Me.GVDEPANADETAIL.Appearance.EvenRow.BackColor = CType(resources.GetObject("GVDEPANADETAIL.Appearance.EvenRow.BackColor"), System.Drawing.Color)
        Me.GVDEPANADETAIL.Appearance.EvenRow.FontSizeDelta = CType(resources.GetObject("GVDEPANADETAIL.Appearance.EvenRow.FontSizeDelta"), Integer)
        Me.GVDEPANADETAIL.Appearance.EvenRow.FontStyleDelta = CType(resources.GetObject("GVDEPANADETAIL.Appearance.EvenRow.FontStyleDelta"), System.Drawing.FontStyle)
        Me.GVDEPANADETAIL.Appearance.EvenRow.ForeColor = CType(resources.GetObject("GVDEPANADETAIL.Appearance.EvenRow.ForeColor"), System.Drawing.Color)
        Me.GVDEPANADETAIL.Appearance.EvenRow.GradientMode = CType(resources.GetObject("GVDEPANADETAIL.Appearance.EvenRow.GradientMode"), System.Drawing.Drawing2D.LinearGradientMode)
        Me.GVDEPANADETAIL.Appearance.EvenRow.Image = CType(resources.GetObject("GVDEPANADETAIL.Appearance.EvenRow.Image"), System.Drawing.Image)
        Me.GVDEPANADETAIL.Appearance.EvenRow.Options.UseBackColor = True
        Me.GVDEPANADETAIL.Appearance.EvenRow.Options.UseForeColor = True
        Me.GVDEPANADETAIL.Appearance.FilterCloseButton.BackColor = CType(resources.GetObject("GVDEPANADETAIL.Appearance.FilterCloseButton.BackColor"), System.Drawing.Color)
        Me.GVDEPANADETAIL.Appearance.FilterCloseButton.BackColor2 = CType(resources.GetObject("GVDEPANADETAIL.Appearance.FilterCloseButton.BackColor2"), System.Drawing.Color)
        Me.GVDEPANADETAIL.Appearance.FilterCloseButton.BorderColor = CType(resources.GetObject("GVDEPANADETAIL.Appearance.FilterCloseButton.BorderColor"), System.Drawing.Color)
        Me.GVDEPANADETAIL.Appearance.FilterCloseButton.FontSizeDelta = CType(resources.GetObject("GVDEPANADETAIL.Appearance.FilterCloseButton.FontSizeDelta"), Integer)
        Me.GVDEPANADETAIL.Appearance.FilterCloseButton.FontStyleDelta = CType(resources.GetObject("GVDEPANADETAIL.Appearance.FilterCloseButton.FontStyleDelta"), System.Drawing.FontStyle)
        Me.GVDEPANADETAIL.Appearance.FilterCloseButton.ForeColor = CType(resources.GetObject("GVDEPANADETAIL.Appearance.FilterCloseButton.ForeColor"), System.Drawing.Color)
        Me.GVDEPANADETAIL.Appearance.FilterCloseButton.GradientMode = CType(resources.GetObject("GVDEPANADETAIL.Appearance.FilterCloseButton.GradientMode"), System.Drawing.Drawing2D.LinearGradientMode)
        Me.GVDEPANADETAIL.Appearance.FilterCloseButton.Image = CType(resources.GetObject("GVDEPANADETAIL.Appearance.FilterCloseButton.Image"), System.Drawing.Image)
        Me.GVDEPANADETAIL.Appearance.FilterCloseButton.Options.UseBackColor = True
        Me.GVDEPANADETAIL.Appearance.FilterCloseButton.Options.UseBorderColor = True
        Me.GVDEPANADETAIL.Appearance.FilterCloseButton.Options.UseForeColor = True
        Me.GVDEPANADETAIL.Appearance.FilterPanel.BackColor = CType(resources.GetObject("GVDEPANADETAIL.Appearance.FilterPanel.BackColor"), System.Drawing.Color)
        Me.GVDEPANADETAIL.Appearance.FilterPanel.FontSizeDelta = CType(resources.GetObject("GVDEPANADETAIL.Appearance.FilterPanel.FontSizeDelta"), Integer)
        Me.GVDEPANADETAIL.Appearance.FilterPanel.FontStyleDelta = CType(resources.GetObject("GVDEPANADETAIL.Appearance.FilterPanel.FontStyleDelta"), System.Drawing.FontStyle)
        Me.GVDEPANADETAIL.Appearance.FilterPanel.ForeColor = CType(resources.GetObject("GVDEPANADETAIL.Appearance.FilterPanel.ForeColor"), System.Drawing.Color)
        Me.GVDEPANADETAIL.Appearance.FilterPanel.GradientMode = CType(resources.GetObject("GVDEPANADETAIL.Appearance.FilterPanel.GradientMode"), System.Drawing.Drawing2D.LinearGradientMode)
        Me.GVDEPANADETAIL.Appearance.FilterPanel.Image = CType(resources.GetObject("GVDEPANADETAIL.Appearance.FilterPanel.Image"), System.Drawing.Image)
        Me.GVDEPANADETAIL.Appearance.FilterPanel.Options.UseBackColor = True
        Me.GVDEPANADETAIL.Appearance.FilterPanel.Options.UseForeColor = True
        Me.GVDEPANADETAIL.Appearance.FixedLine.BackColor = CType(resources.GetObject("GVDEPANADETAIL.Appearance.FixedLine.BackColor"), System.Drawing.Color)
        Me.GVDEPANADETAIL.Appearance.FixedLine.FontSizeDelta = CType(resources.GetObject("GVDEPANADETAIL.Appearance.FixedLine.FontSizeDelta"), Integer)
        Me.GVDEPANADETAIL.Appearance.FixedLine.FontStyleDelta = CType(resources.GetObject("GVDEPANADETAIL.Appearance.FixedLine.FontStyleDelta"), System.Drawing.FontStyle)
        Me.GVDEPANADETAIL.Appearance.FixedLine.GradientMode = CType(resources.GetObject("GVDEPANADETAIL.Appearance.FixedLine.GradientMode"), System.Drawing.Drawing2D.LinearGradientMode)
        Me.GVDEPANADETAIL.Appearance.FixedLine.Image = CType(resources.GetObject("GVDEPANADETAIL.Appearance.FixedLine.Image"), System.Drawing.Image)
        Me.GVDEPANADETAIL.Appearance.FixedLine.Options.UseBackColor = True
        Me.GVDEPANADETAIL.Appearance.FocusedCell.BackColor = CType(resources.GetObject("GVDEPANADETAIL.Appearance.FocusedCell.BackColor"), System.Drawing.Color)
        Me.GVDEPANADETAIL.Appearance.FocusedCell.FontSizeDelta = CType(resources.GetObject("GVDEPANADETAIL.Appearance.FocusedCell.FontSizeDelta"), Integer)
        Me.GVDEPANADETAIL.Appearance.FocusedCell.FontStyleDelta = CType(resources.GetObject("GVDEPANADETAIL.Appearance.FocusedCell.FontStyleDelta"), System.Drawing.FontStyle)
        Me.GVDEPANADETAIL.Appearance.FocusedCell.ForeColor = CType(resources.GetObject("GVDEPANADETAIL.Appearance.FocusedCell.ForeColor"), System.Drawing.Color)
        Me.GVDEPANADETAIL.Appearance.FocusedCell.GradientMode = CType(resources.GetObject("GVDEPANADETAIL.Appearance.FocusedCell.GradientMode"), System.Drawing.Drawing2D.LinearGradientMode)
        Me.GVDEPANADETAIL.Appearance.FocusedCell.Image = CType(resources.GetObject("GVDEPANADETAIL.Appearance.FocusedCell.Image"), System.Drawing.Image)
        Me.GVDEPANADETAIL.Appearance.FocusedCell.Options.UseBackColor = True
        Me.GVDEPANADETAIL.Appearance.FocusedCell.Options.UseForeColor = True
        Me.GVDEPANADETAIL.Appearance.FocusedRow.BackColor = CType(resources.GetObject("GVDEPANADETAIL.Appearance.FocusedRow.BackColor"), System.Drawing.Color)
        Me.GVDEPANADETAIL.Appearance.FocusedRow.FontSizeDelta = CType(resources.GetObject("GVDEPANADETAIL.Appearance.FocusedRow.FontSizeDelta"), Integer)
        Me.GVDEPANADETAIL.Appearance.FocusedRow.FontStyleDelta = CType(resources.GetObject("GVDEPANADETAIL.Appearance.FocusedRow.FontStyleDelta"), System.Drawing.FontStyle)
        Me.GVDEPANADETAIL.Appearance.FocusedRow.ForeColor = CType(resources.GetObject("GVDEPANADETAIL.Appearance.FocusedRow.ForeColor"), System.Drawing.Color)
        Me.GVDEPANADETAIL.Appearance.FocusedRow.GradientMode = CType(resources.GetObject("GVDEPANADETAIL.Appearance.FocusedRow.GradientMode"), System.Drawing.Drawing2D.LinearGradientMode)
        Me.GVDEPANADETAIL.Appearance.FocusedRow.Image = CType(resources.GetObject("GVDEPANADETAIL.Appearance.FocusedRow.Image"), System.Drawing.Image)
        Me.GVDEPANADETAIL.Appearance.FocusedRow.Options.UseBackColor = True
        Me.GVDEPANADETAIL.Appearance.FocusedRow.Options.UseForeColor = True
        Me.GVDEPANADETAIL.Appearance.FooterPanel.BackColor = CType(resources.GetObject("GVDEPANADETAIL.Appearance.FooterPanel.BackColor"), System.Drawing.Color)
        Me.GVDEPANADETAIL.Appearance.FooterPanel.BackColor2 = CType(resources.GetObject("GVDEPANADETAIL.Appearance.FooterPanel.BackColor2"), System.Drawing.Color)
        Me.GVDEPANADETAIL.Appearance.FooterPanel.BorderColor = CType(resources.GetObject("GVDEPANADETAIL.Appearance.FooterPanel.BorderColor"), System.Drawing.Color)
        Me.GVDEPANADETAIL.Appearance.FooterPanel.FontSizeDelta = CType(resources.GetObject("GVDEPANADETAIL.Appearance.FooterPanel.FontSizeDelta"), Integer)
        Me.GVDEPANADETAIL.Appearance.FooterPanel.FontStyleDelta = CType(resources.GetObject("GVDEPANADETAIL.Appearance.FooterPanel.FontStyleDelta"), System.Drawing.FontStyle)
        Me.GVDEPANADETAIL.Appearance.FooterPanel.ForeColor = CType(resources.GetObject("GVDEPANADETAIL.Appearance.FooterPanel.ForeColor"), System.Drawing.Color)
        Me.GVDEPANADETAIL.Appearance.FooterPanel.GradientMode = CType(resources.GetObject("GVDEPANADETAIL.Appearance.FooterPanel.GradientMode"), System.Drawing.Drawing2D.LinearGradientMode)
        Me.GVDEPANADETAIL.Appearance.FooterPanel.Image = CType(resources.GetObject("GVDEPANADETAIL.Appearance.FooterPanel.Image"), System.Drawing.Image)
        Me.GVDEPANADETAIL.Appearance.FooterPanel.Options.UseBackColor = True
        Me.GVDEPANADETAIL.Appearance.FooterPanel.Options.UseBorderColor = True
        Me.GVDEPANADETAIL.Appearance.FooterPanel.Options.UseForeColor = True
        Me.GVDEPANADETAIL.Appearance.GroupButton.BackColor = CType(resources.GetObject("GVDEPANADETAIL.Appearance.GroupButton.BackColor"), System.Drawing.Color)
        Me.GVDEPANADETAIL.Appearance.GroupButton.BorderColor = CType(resources.GetObject("GVDEPANADETAIL.Appearance.GroupButton.BorderColor"), System.Drawing.Color)
        Me.GVDEPANADETAIL.Appearance.GroupButton.FontSizeDelta = CType(resources.GetObject("GVDEPANADETAIL.Appearance.GroupButton.FontSizeDelta"), Integer)
        Me.GVDEPANADETAIL.Appearance.GroupButton.FontStyleDelta = CType(resources.GetObject("GVDEPANADETAIL.Appearance.GroupButton.FontStyleDelta"), System.Drawing.FontStyle)
        Me.GVDEPANADETAIL.Appearance.GroupButton.ForeColor = CType(resources.GetObject("GVDEPANADETAIL.Appearance.GroupButton.ForeColor"), System.Drawing.Color)
        Me.GVDEPANADETAIL.Appearance.GroupButton.GradientMode = CType(resources.GetObject("GVDEPANADETAIL.Appearance.GroupButton.GradientMode"), System.Drawing.Drawing2D.LinearGradientMode)
        Me.GVDEPANADETAIL.Appearance.GroupButton.Image = CType(resources.GetObject("GVDEPANADETAIL.Appearance.GroupButton.Image"), System.Drawing.Image)
        Me.GVDEPANADETAIL.Appearance.GroupButton.Options.UseBackColor = True
        Me.GVDEPANADETAIL.Appearance.GroupButton.Options.UseBorderColor = True
        Me.GVDEPANADETAIL.Appearance.GroupButton.Options.UseForeColor = True
        Me.GVDEPANADETAIL.Appearance.GroupFooter.BackColor = CType(resources.GetObject("GVDEPANADETAIL.Appearance.GroupFooter.BackColor"), System.Drawing.Color)
        Me.GVDEPANADETAIL.Appearance.GroupFooter.BorderColor = CType(resources.GetObject("GVDEPANADETAIL.Appearance.GroupFooter.BorderColor"), System.Drawing.Color)
        Me.GVDEPANADETAIL.Appearance.GroupFooter.FontSizeDelta = CType(resources.GetObject("GVDEPANADETAIL.Appearance.GroupFooter.FontSizeDelta"), Integer)
        Me.GVDEPANADETAIL.Appearance.GroupFooter.FontStyleDelta = CType(resources.GetObject("GVDEPANADETAIL.Appearance.GroupFooter.FontStyleDelta"), System.Drawing.FontStyle)
        Me.GVDEPANADETAIL.Appearance.GroupFooter.ForeColor = CType(resources.GetObject("GVDEPANADETAIL.Appearance.GroupFooter.ForeColor"), System.Drawing.Color)
        Me.GVDEPANADETAIL.Appearance.GroupFooter.GradientMode = CType(resources.GetObject("GVDEPANADETAIL.Appearance.GroupFooter.GradientMode"), System.Drawing.Drawing2D.LinearGradientMode)
        Me.GVDEPANADETAIL.Appearance.GroupFooter.Image = CType(resources.GetObject("GVDEPANADETAIL.Appearance.GroupFooter.Image"), System.Drawing.Image)
        Me.GVDEPANADETAIL.Appearance.GroupFooter.Options.UseBackColor = True
        Me.GVDEPANADETAIL.Appearance.GroupFooter.Options.UseBorderColor = True
        Me.GVDEPANADETAIL.Appearance.GroupFooter.Options.UseForeColor = True
        Me.GVDEPANADETAIL.Appearance.GroupPanel.BackColor = CType(resources.GetObject("GVDEPANADETAIL.Appearance.GroupPanel.BackColor"), System.Drawing.Color)
        Me.GVDEPANADETAIL.Appearance.GroupPanel.FontSizeDelta = CType(resources.GetObject("GVDEPANADETAIL.Appearance.GroupPanel.FontSizeDelta"), Integer)
        Me.GVDEPANADETAIL.Appearance.GroupPanel.FontStyleDelta = CType(resources.GetObject("GVDEPANADETAIL.Appearance.GroupPanel.FontStyleDelta"), System.Drawing.FontStyle)
        Me.GVDEPANADETAIL.Appearance.GroupPanel.ForeColor = CType(resources.GetObject("GVDEPANADETAIL.Appearance.GroupPanel.ForeColor"), System.Drawing.Color)
        Me.GVDEPANADETAIL.Appearance.GroupPanel.GradientMode = CType(resources.GetObject("GVDEPANADETAIL.Appearance.GroupPanel.GradientMode"), System.Drawing.Drawing2D.LinearGradientMode)
        Me.GVDEPANADETAIL.Appearance.GroupPanel.Image = CType(resources.GetObject("GVDEPANADETAIL.Appearance.GroupPanel.Image"), System.Drawing.Image)
        Me.GVDEPANADETAIL.Appearance.GroupPanel.Options.UseBackColor = True
        Me.GVDEPANADETAIL.Appearance.GroupPanel.Options.UseForeColor = True
        Me.GVDEPANADETAIL.Appearance.GroupRow.BackColor = CType(resources.GetObject("GVDEPANADETAIL.Appearance.GroupRow.BackColor"), System.Drawing.Color)
        Me.GVDEPANADETAIL.Appearance.GroupRow.BorderColor = CType(resources.GetObject("GVDEPANADETAIL.Appearance.GroupRow.BorderColor"), System.Drawing.Color)
        Me.GVDEPANADETAIL.Appearance.GroupRow.Font = CType(resources.GetObject("GVDEPANADETAIL.Appearance.GroupRow.Font"), System.Drawing.Font)
        Me.GVDEPANADETAIL.Appearance.GroupRow.FontSizeDelta = CType(resources.GetObject("GVDEPANADETAIL.Appearance.GroupRow.FontSizeDelta"), Integer)
        Me.GVDEPANADETAIL.Appearance.GroupRow.FontStyleDelta = CType(resources.GetObject("GVDEPANADETAIL.Appearance.GroupRow.FontStyleDelta"), System.Drawing.FontStyle)
        Me.GVDEPANADETAIL.Appearance.GroupRow.ForeColor = CType(resources.GetObject("GVDEPANADETAIL.Appearance.GroupRow.ForeColor"), System.Drawing.Color)
        Me.GVDEPANADETAIL.Appearance.GroupRow.GradientMode = CType(resources.GetObject("GVDEPANADETAIL.Appearance.GroupRow.GradientMode"), System.Drawing.Drawing2D.LinearGradientMode)
        Me.GVDEPANADETAIL.Appearance.GroupRow.Image = CType(resources.GetObject("GVDEPANADETAIL.Appearance.GroupRow.Image"), System.Drawing.Image)
        Me.GVDEPANADETAIL.Appearance.GroupRow.Options.UseBackColor = True
        Me.GVDEPANADETAIL.Appearance.GroupRow.Options.UseBorderColor = True
        Me.GVDEPANADETAIL.Appearance.GroupRow.Options.UseFont = True
        Me.GVDEPANADETAIL.Appearance.GroupRow.Options.UseForeColor = True
        Me.GVDEPANADETAIL.Appearance.HeaderPanel.BackColor = CType(resources.GetObject("GVDEPANADETAIL.Appearance.HeaderPanel.BackColor"), System.Drawing.Color)
        Me.GVDEPANADETAIL.Appearance.HeaderPanel.BackColor2 = CType(resources.GetObject("GVDEPANADETAIL.Appearance.HeaderPanel.BackColor2"), System.Drawing.Color)
        Me.GVDEPANADETAIL.Appearance.HeaderPanel.BorderColor = CType(resources.GetObject("GVDEPANADETAIL.Appearance.HeaderPanel.BorderColor"), System.Drawing.Color)
        Me.GVDEPANADETAIL.Appearance.HeaderPanel.Font = CType(resources.GetObject("GVDEPANADETAIL.Appearance.HeaderPanel.Font"), System.Drawing.Font)
        Me.GVDEPANADETAIL.Appearance.HeaderPanel.FontSizeDelta = CType(resources.GetObject("GVDEPANADETAIL.Appearance.HeaderPanel.FontSizeDelta"), Integer)
        Me.GVDEPANADETAIL.Appearance.HeaderPanel.FontStyleDelta = CType(resources.GetObject("GVDEPANADETAIL.Appearance.HeaderPanel.FontStyleDelta"), System.Drawing.FontStyle)
        Me.GVDEPANADETAIL.Appearance.HeaderPanel.ForeColor = CType(resources.GetObject("GVDEPANADETAIL.Appearance.HeaderPanel.ForeColor"), System.Drawing.Color)
        Me.GVDEPANADETAIL.Appearance.HeaderPanel.GradientMode = CType(resources.GetObject("GVDEPANADETAIL.Appearance.HeaderPanel.GradientMode"), System.Drawing.Drawing2D.LinearGradientMode)
        Me.GVDEPANADETAIL.Appearance.HeaderPanel.Image = CType(resources.GetObject("GVDEPANADETAIL.Appearance.HeaderPanel.Image"), System.Drawing.Image)
        Me.GVDEPANADETAIL.Appearance.HeaderPanel.Options.UseBackColor = True
        Me.GVDEPANADETAIL.Appearance.HeaderPanel.Options.UseBorderColor = True
        Me.GVDEPANADETAIL.Appearance.HeaderPanel.Options.UseFont = True
        Me.GVDEPANADETAIL.Appearance.HeaderPanel.Options.UseForeColor = True
        Me.GVDEPANADETAIL.Appearance.HeaderPanel.Options.UseTextOptions = True
        Me.GVDEPANADETAIL.Appearance.HeaderPanel.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center
        Me.GVDEPANADETAIL.Appearance.HeaderPanel.TextOptions.VAlignment = DevExpress.Utils.VertAlignment.Center
        Me.GVDEPANADETAIL.Appearance.HeaderPanel.TextOptions.WordWrap = DevExpress.Utils.WordWrap.Wrap
        Me.GVDEPANADETAIL.Appearance.HideSelectionRow.BackColor = CType(resources.GetObject("GVDEPANADETAIL.Appearance.HideSelectionRow.BackColor"), System.Drawing.Color)
        Me.GVDEPANADETAIL.Appearance.HideSelectionRow.FontSizeDelta = CType(resources.GetObject("GVDEPANADETAIL.Appearance.HideSelectionRow.FontSizeDelta"), Integer)
        Me.GVDEPANADETAIL.Appearance.HideSelectionRow.FontStyleDelta = CType(resources.GetObject("GVDEPANADETAIL.Appearance.HideSelectionRow.FontStyleDelta"), System.Drawing.FontStyle)
        Me.GVDEPANADETAIL.Appearance.HideSelectionRow.ForeColor = CType(resources.GetObject("GVDEPANADETAIL.Appearance.HideSelectionRow.ForeColor"), System.Drawing.Color)
        Me.GVDEPANADETAIL.Appearance.HideSelectionRow.GradientMode = CType(resources.GetObject("GVDEPANADETAIL.Appearance.HideSelectionRow.GradientMode"), System.Drawing.Drawing2D.LinearGradientMode)
        Me.GVDEPANADETAIL.Appearance.HideSelectionRow.Image = CType(resources.GetObject("GVDEPANADETAIL.Appearance.HideSelectionRow.Image"), System.Drawing.Image)
        Me.GVDEPANADETAIL.Appearance.HideSelectionRow.Options.UseBackColor = True
        Me.GVDEPANADETAIL.Appearance.HideSelectionRow.Options.UseForeColor = True
        Me.GVDEPANADETAIL.Appearance.HorzLine.BackColor = CType(resources.GetObject("GVDEPANADETAIL.Appearance.HorzLine.BackColor"), System.Drawing.Color)
        Me.GVDEPANADETAIL.Appearance.HorzLine.FontSizeDelta = CType(resources.GetObject("GVDEPANADETAIL.Appearance.HorzLine.FontSizeDelta"), Integer)
        Me.GVDEPANADETAIL.Appearance.HorzLine.FontStyleDelta = CType(resources.GetObject("GVDEPANADETAIL.Appearance.HorzLine.FontStyleDelta"), System.Drawing.FontStyle)
        Me.GVDEPANADETAIL.Appearance.HorzLine.GradientMode = CType(resources.GetObject("GVDEPANADETAIL.Appearance.HorzLine.GradientMode"), System.Drawing.Drawing2D.LinearGradientMode)
        Me.GVDEPANADETAIL.Appearance.HorzLine.Image = CType(resources.GetObject("GVDEPANADETAIL.Appearance.HorzLine.Image"), System.Drawing.Image)
        Me.GVDEPANADETAIL.Appearance.HorzLine.Options.UseBackColor = True
        Me.GVDEPANADETAIL.Appearance.OddRow.BackColor = CType(resources.GetObject("GVDEPANADETAIL.Appearance.OddRow.BackColor"), System.Drawing.Color)
        Me.GVDEPANADETAIL.Appearance.OddRow.FontSizeDelta = CType(resources.GetObject("GVDEPANADETAIL.Appearance.OddRow.FontSizeDelta"), Integer)
        Me.GVDEPANADETAIL.Appearance.OddRow.FontStyleDelta = CType(resources.GetObject("GVDEPANADETAIL.Appearance.OddRow.FontStyleDelta"), System.Drawing.FontStyle)
        Me.GVDEPANADETAIL.Appearance.OddRow.ForeColor = CType(resources.GetObject("GVDEPANADETAIL.Appearance.OddRow.ForeColor"), System.Drawing.Color)
        Me.GVDEPANADETAIL.Appearance.OddRow.GradientMode = CType(resources.GetObject("GVDEPANADETAIL.Appearance.OddRow.GradientMode"), System.Drawing.Drawing2D.LinearGradientMode)
        Me.GVDEPANADETAIL.Appearance.OddRow.Image = CType(resources.GetObject("GVDEPANADETAIL.Appearance.OddRow.Image"), System.Drawing.Image)
        Me.GVDEPANADETAIL.Appearance.OddRow.Options.UseBackColor = True
        Me.GVDEPANADETAIL.Appearance.OddRow.Options.UseForeColor = True
        Me.GVDEPANADETAIL.Appearance.Preview.BackColor = CType(resources.GetObject("GVDEPANADETAIL.Appearance.Preview.BackColor"), System.Drawing.Color)
        Me.GVDEPANADETAIL.Appearance.Preview.FontSizeDelta = CType(resources.GetObject("GVDEPANADETAIL.Appearance.Preview.FontSizeDelta"), Integer)
        Me.GVDEPANADETAIL.Appearance.Preview.FontStyleDelta = CType(resources.GetObject("GVDEPANADETAIL.Appearance.Preview.FontStyleDelta"), System.Drawing.FontStyle)
        Me.GVDEPANADETAIL.Appearance.Preview.ForeColor = CType(resources.GetObject("GVDEPANADETAIL.Appearance.Preview.ForeColor"), System.Drawing.Color)
        Me.GVDEPANADETAIL.Appearance.Preview.GradientMode = CType(resources.GetObject("GVDEPANADETAIL.Appearance.Preview.GradientMode"), System.Drawing.Drawing2D.LinearGradientMode)
        Me.GVDEPANADETAIL.Appearance.Preview.Image = CType(resources.GetObject("GVDEPANADETAIL.Appearance.Preview.Image"), System.Drawing.Image)
        Me.GVDEPANADETAIL.Appearance.Preview.Options.UseBackColor = True
        Me.GVDEPANADETAIL.Appearance.Preview.Options.UseForeColor = True
        Me.GVDEPANADETAIL.Appearance.Row.BackColor = CType(resources.GetObject("GVDEPANADETAIL.Appearance.Row.BackColor"), System.Drawing.Color)
        Me.GVDEPANADETAIL.Appearance.Row.FontSizeDelta = CType(resources.GetObject("GVDEPANADETAIL.Appearance.Row.FontSizeDelta"), Integer)
        Me.GVDEPANADETAIL.Appearance.Row.FontStyleDelta = CType(resources.GetObject("GVDEPANADETAIL.Appearance.Row.FontStyleDelta"), System.Drawing.FontStyle)
        Me.GVDEPANADETAIL.Appearance.Row.ForeColor = CType(resources.GetObject("GVDEPANADETAIL.Appearance.Row.ForeColor"), System.Drawing.Color)
        Me.GVDEPANADETAIL.Appearance.Row.GradientMode = CType(resources.GetObject("GVDEPANADETAIL.Appearance.Row.GradientMode"), System.Drawing.Drawing2D.LinearGradientMode)
        Me.GVDEPANADETAIL.Appearance.Row.Image = CType(resources.GetObject("GVDEPANADETAIL.Appearance.Row.Image"), System.Drawing.Image)
        Me.GVDEPANADETAIL.Appearance.Row.Options.UseBackColor = True
        Me.GVDEPANADETAIL.Appearance.Row.Options.UseForeColor = True
        Me.GVDEPANADETAIL.Appearance.RowSeparator.BackColor = CType(resources.GetObject("GVDEPANADETAIL.Appearance.RowSeparator.BackColor"), System.Drawing.Color)
        Me.GVDEPANADETAIL.Appearance.RowSeparator.FontSizeDelta = CType(resources.GetObject("GVDEPANADETAIL.Appearance.RowSeparator.FontSizeDelta"), Integer)
        Me.GVDEPANADETAIL.Appearance.RowSeparator.FontStyleDelta = CType(resources.GetObject("GVDEPANADETAIL.Appearance.RowSeparator.FontStyleDelta"), System.Drawing.FontStyle)
        Me.GVDEPANADETAIL.Appearance.RowSeparator.GradientMode = CType(resources.GetObject("GVDEPANADETAIL.Appearance.RowSeparator.GradientMode"), System.Drawing.Drawing2D.LinearGradientMode)
        Me.GVDEPANADETAIL.Appearance.RowSeparator.Image = CType(resources.GetObject("GVDEPANADETAIL.Appearance.RowSeparator.Image"), System.Drawing.Image)
        Me.GVDEPANADETAIL.Appearance.RowSeparator.Options.UseBackColor = True
        Me.GVDEPANADETAIL.Appearance.SelectedRow.BackColor = CType(resources.GetObject("GVDEPANADETAIL.Appearance.SelectedRow.BackColor"), System.Drawing.Color)
        Me.GVDEPANADETAIL.Appearance.SelectedRow.FontSizeDelta = CType(resources.GetObject("GVDEPANADETAIL.Appearance.SelectedRow.FontSizeDelta"), Integer)
        Me.GVDEPANADETAIL.Appearance.SelectedRow.FontStyleDelta = CType(resources.GetObject("GVDEPANADETAIL.Appearance.SelectedRow.FontStyleDelta"), System.Drawing.FontStyle)
        Me.GVDEPANADETAIL.Appearance.SelectedRow.ForeColor = CType(resources.GetObject("GVDEPANADETAIL.Appearance.SelectedRow.ForeColor"), System.Drawing.Color)
        Me.GVDEPANADETAIL.Appearance.SelectedRow.GradientMode = CType(resources.GetObject("GVDEPANADETAIL.Appearance.SelectedRow.GradientMode"), System.Drawing.Drawing2D.LinearGradientMode)
        Me.GVDEPANADETAIL.Appearance.SelectedRow.Image = CType(resources.GetObject("GVDEPANADETAIL.Appearance.SelectedRow.Image"), System.Drawing.Image)
        Me.GVDEPANADETAIL.Appearance.SelectedRow.Options.UseBackColor = True
        Me.GVDEPANADETAIL.Appearance.SelectedRow.Options.UseForeColor = True
        Me.GVDEPANADETAIL.Appearance.VertLine.BackColor = CType(resources.GetObject("GVDEPANADETAIL.Appearance.VertLine.BackColor"), System.Drawing.Color)
        Me.GVDEPANADETAIL.Appearance.VertLine.FontSizeDelta = CType(resources.GetObject("GVDEPANADETAIL.Appearance.VertLine.FontSizeDelta"), Integer)
        Me.GVDEPANADETAIL.Appearance.VertLine.FontStyleDelta = CType(resources.GetObject("GVDEPANADETAIL.Appearance.VertLine.FontStyleDelta"), System.Drawing.FontStyle)
        Me.GVDEPANADETAIL.Appearance.VertLine.GradientMode = CType(resources.GetObject("GVDEPANADETAIL.Appearance.VertLine.GradientMode"), System.Drawing.Drawing2D.LinearGradientMode)
        Me.GVDEPANADETAIL.Appearance.VertLine.Image = CType(resources.GetObject("GVDEPANADETAIL.Appearance.VertLine.Image"), System.Drawing.Image)
        Me.GVDEPANADETAIL.Appearance.VertLine.Options.UseBackColor = True
        resources.ApplyResources(Me.GVDEPANADETAIL, "GVDEPANADETAIL")
        Me.GVDEPANADETAIL.ColumnPanelRowHeight = 50
        Me.GVDEPANADETAIL.Columns.AddRange(New DevExpress.XtraGrid.Columns.GridColumn() {Me.GDetColNCANNUM, Me.GDetCOLVCANLIB, Me.GDetColTOTAL, Me.GDetColNDEPLOCMAT, Me.GDetColNDEPSTT, Me.GDetColNDEPTRANSP, Me.GDetColNDEPLOCVEH, Me.GDetColNDEPMAT, Me.GDetColNDEPDEPL, Me.GEdtColNDEPPAN, Me.GDetColNDEPDOUANE, Me.GDetColNDEPHRMPT, Me.GDetColNDEPHRINT, Me.GDetColNDEPKMS, Me.GDetColNDEPSTOCK})
        Me.GVDEPANADETAIL.GridControl = Me.GCDEPANADETAIL
        Me.GVDEPANADETAIL.Name = "GVDEPANADETAIL"
        Me.GVDEPANADETAIL.OptionsBehavior.Editable = False
        Me.GVDEPANADETAIL.OptionsBehavior.ReadOnly = True
        Me.GVDEPANADETAIL.OptionsView.EnableAppearanceEvenRow = True
        Me.GVDEPANADETAIL.OptionsView.EnableAppearanceOddRow = True
        Me.GVDEPANADETAIL.OptionsView.ShowGroupPanel = False
        Me.GVDEPANADETAIL.RowHeight = 30
        '
        'GDetColNCANNUM
        '
        Me.GDetColNCANNUM.AppearanceCell.FontSizeDelta = CType(resources.GetObject("GDetColNCANNUM.AppearanceCell.FontSizeDelta"), Integer)
        Me.GDetColNCANNUM.AppearanceCell.FontStyleDelta = CType(resources.GetObject("GDetColNCANNUM.AppearanceCell.FontStyleDelta"), System.Drawing.FontStyle)
        Me.GDetColNCANNUM.AppearanceCell.GradientMode = CType(resources.GetObject("GDetColNCANNUM.AppearanceCell.GradientMode"), System.Drawing.Drawing2D.LinearGradientMode)
        Me.GDetColNCANNUM.AppearanceCell.Image = CType(resources.GetObject("GDetColNCANNUM.AppearanceCell.Image"), System.Drawing.Image)
        Me.GDetColNCANNUM.AppearanceCell.Options.UseTextOptions = True
        Me.GDetColNCANNUM.AppearanceCell.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center
        Me.GDetColNCANNUM.AppearanceCell.TextOptions.VAlignment = DevExpress.Utils.VertAlignment.Center
        resources.ApplyResources(Me.GDetColNCANNUM, "GDetColNCANNUM")
        Me.GDetColNCANNUM.FieldName = "NCANNUM"
        Me.GDetColNCANNUM.Name = "GDetColNCANNUM"
        '
        'GDetCOLVCANLIB
        '
        resources.ApplyResources(Me.GDetCOLVCANLIB, "GDetCOLVCANLIB")
        Me.GDetCOLVCANLIB.FieldName = "VCANLIB"
        Me.GDetCOLVCANLIB.Name = "GDetCOLVCANLIB"
        '
        'GDetColTOTAL
        '
        resources.ApplyResources(Me.GDetColTOTAL, "GDetColTOTAL")
        Me.GDetColTOTAL.DisplayFormat.FormatString = "c"
        Me.GDetColTOTAL.DisplayFormat.FormatType = DevExpress.Utils.FormatType.Numeric
        Me.GDetColTOTAL.FieldName = "TOTAL"
        Me.GDetColTOTAL.Name = "GDetColTOTAL"
        '
        'GDetColNDEPLOCMAT
        '
        resources.ApplyResources(Me.GDetColNDEPLOCMAT, "GDetColNDEPLOCMAT")
        Me.GDetColNDEPLOCMAT.DisplayFormat.FormatString = "p"
        Me.GDetColNDEPLOCMAT.DisplayFormat.FormatType = DevExpress.Utils.FormatType.Numeric
        Me.GDetColNDEPLOCMAT.FieldName = "NDEPLOCMAT"
        Me.GDetColNDEPLOCMAT.Name = "GDetColNDEPLOCMAT"
        '
        'GDetColNDEPSTT
        '
        resources.ApplyResources(Me.GDetColNDEPSTT, "GDetColNDEPSTT")
        Me.GDetColNDEPSTT.DisplayFormat.FormatString = "p"
        Me.GDetColNDEPSTT.DisplayFormat.FormatType = DevExpress.Utils.FormatType.Numeric
        Me.GDetColNDEPSTT.FieldName = "NDEPSTT"
        Me.GDetColNDEPSTT.Name = "GDetColNDEPSTT"
        '
        'GDetColNDEPTRANSP
        '
        resources.ApplyResources(Me.GDetColNDEPTRANSP, "GDetColNDEPTRANSP")
        Me.GDetColNDEPTRANSP.DisplayFormat.FormatString = "p"
        Me.GDetColNDEPTRANSP.DisplayFormat.FormatType = DevExpress.Utils.FormatType.Numeric
        Me.GDetColNDEPTRANSP.FieldName = "NDEPTRANSP"
        Me.GDetColNDEPTRANSP.Name = "GDetColNDEPTRANSP"
        '
        'GDetColNDEPLOCVEH
        '
        resources.ApplyResources(Me.GDetColNDEPLOCVEH, "GDetColNDEPLOCVEH")
        Me.GDetColNDEPLOCVEH.DisplayFormat.FormatString = "p"
        Me.GDetColNDEPLOCVEH.DisplayFormat.FormatType = DevExpress.Utils.FormatType.Numeric
        Me.GDetColNDEPLOCVEH.FieldName = "NDEPLOCVEH"
        Me.GDetColNDEPLOCVEH.Name = "GDetColNDEPLOCVEH"
        '
        'GDetColNDEPMAT
        '
        resources.ApplyResources(Me.GDetColNDEPMAT, "GDetColNDEPMAT")
        Me.GDetColNDEPMAT.DisplayFormat.FormatString = "p"
        Me.GDetColNDEPMAT.DisplayFormat.FormatType = DevExpress.Utils.FormatType.Numeric
        Me.GDetColNDEPMAT.FieldName = "NDEPMAT"
        Me.GDetColNDEPMAT.Name = "GDetColNDEPMAT"
        '
        'GDetColNDEPDEPL
        '
        resources.ApplyResources(Me.GDetColNDEPDEPL, "GDetColNDEPDEPL")
        Me.GDetColNDEPDEPL.DisplayFormat.FormatString = "p"
        Me.GDetColNDEPDEPL.DisplayFormat.FormatType = DevExpress.Utils.FormatType.Numeric
        Me.GDetColNDEPDEPL.FieldName = "NDEPDEPL"
        Me.GDetColNDEPDEPL.Name = "GDetColNDEPDEPL"
        '
        'GEdtColNDEPPAN
        '
        resources.ApplyResources(Me.GEdtColNDEPPAN, "GEdtColNDEPPAN")
        Me.GEdtColNDEPPAN.DisplayFormat.FormatString = "p"
        Me.GEdtColNDEPPAN.DisplayFormat.FormatType = DevExpress.Utils.FormatType.Numeric
        Me.GEdtColNDEPPAN.FieldName = "NDEPPAN"
        Me.GEdtColNDEPPAN.Name = "GEdtColNDEPPAN"
        '
        'GDetColNDEPDOUANE
        '
        resources.ApplyResources(Me.GDetColNDEPDOUANE, "GDetColNDEPDOUANE")
        Me.GDetColNDEPDOUANE.DisplayFormat.FormatString = "p"
        Me.GDetColNDEPDOUANE.DisplayFormat.FormatType = DevExpress.Utils.FormatType.Numeric
        Me.GDetColNDEPDOUANE.FieldName = "NDEPDOUANE"
        Me.GDetColNDEPDOUANE.Name = "GDetColNDEPDOUANE"
        '
        'GDetColNDEPHRMPT
        '
        resources.ApplyResources(Me.GDetColNDEPHRMPT, "GDetColNDEPHRMPT")
        Me.GDetColNDEPHRMPT.DisplayFormat.FormatString = "p"
        Me.GDetColNDEPHRMPT.DisplayFormat.FormatType = DevExpress.Utils.FormatType.Numeric
        Me.GDetColNDEPHRMPT.FieldName = "NDEPHRMPT"
        Me.GDetColNDEPHRMPT.Name = "GDetColNDEPHRMPT"
        '
        'GDetColNDEPHRINT
        '
        resources.ApplyResources(Me.GDetColNDEPHRINT, "GDetColNDEPHRINT")
        Me.GDetColNDEPHRINT.DisplayFormat.FormatString = "p"
        Me.GDetColNDEPHRINT.DisplayFormat.FormatType = DevExpress.Utils.FormatType.Numeric
        Me.GDetColNDEPHRINT.FieldName = "NDEPHRINT"
        Me.GDetColNDEPHRINT.Name = "GDetColNDEPHRINT"
        '
        'GDetColNDEPKMS
        '
        resources.ApplyResources(Me.GDetColNDEPKMS, "GDetColNDEPKMS")
        Me.GDetColNDEPKMS.DisplayFormat.FormatString = "p"
        Me.GDetColNDEPKMS.DisplayFormat.FormatType = DevExpress.Utils.FormatType.Numeric
        Me.GDetColNDEPKMS.FieldName = "NDEPKMS"
        Me.GDetColNDEPKMS.Name = "GDetColNDEPKMS"
        '
        'GDetColNDEPSTOCK
        '
        resources.ApplyResources(Me.GDetColNDEPSTOCK, "GDetColNDEPSTOCK")
        Me.GDetColNDEPSTOCK.DisplayFormat.FormatString = "p"
        Me.GDetColNDEPSTOCK.DisplayFormat.FormatType = DevExpress.Utils.FormatType.Numeric
        Me.GDetColNDEPSTOCK.FieldName = "NDEPSTOCK"
        Me.GDetColNDEPSTOCK.Name = "GDetColNDEPSTOCK"
        '
        'SFD
        '
        resources.ApplyResources(Me.SFD, "SFD")
        '
        'FrmDepensesAnalytique
        '
        resources.ApplyResources(Me, "$this")
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.Wheat
        Me.Controls.Add(Me.GrpDetail)
        Me.Controls.Add(Me.GrpModele)
        Me.Controls.Add(Me.GrpPeriode)
        Me.Controls.Add(Me.LblTitre)
        Me.Controls.Add(Me.GrpActions)
        Me.Name = "FrmDepensesAnalytique"
        Me.WindowState = System.Windows.Forms.FormWindowState.Maximized
        Me.GrpActions.ResumeLayout(False)
        Me.GrpPeriode.ResumeLayout(False)
        Me.GrpPeriode.PerformLayout()
        Me.GrpModele.ResumeLayout(False)
        CType(Me.GCANADEPMODELE, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.GVDEPANAMODELE, System.ComponentModel.ISupportInitialize).EndInit()
        Me.GrpDetail.ResumeLayout(False)
        CType(Me.GCDEPANADETAIL, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.GVDEPANADETAIL, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents LblTitre As System.Windows.Forms.Label
    Friend WithEvents GrpActions As System.Windows.Forms.GroupBox
    Friend WithEvents BtnFermer As System.Windows.Forms.Button
    Friend WithEvents BtnPrint As System.Windows.Forms.Button
    Friend WithEvents GrpPeriode As System.Windows.Forms.GroupBox
    Friend WithEvents BtnValid As System.Windows.Forms.Button
    Friend WithEvents LblAnnee As System.Windows.Forms.Label
    Friend WithEvents LblMois As System.Windows.Forms.Label
    Friend WithEvents GrpModele As System.Windows.Forms.GroupBox
    Friend WithEvents GrpDetail As System.Windows.Forms.GroupBox
    Friend WithEvents BtnExportPDF As System.Windows.Forms.Button
    Friend WithEvents BtnExportXLS As System.Windows.Forms.Button
    Friend WithEvents SFD As System.Windows.Forms.SaveFileDialog
    Friend WithEvents TxtAnnee As System.Windows.Forms.TextBox
    Friend WithEvents TxtMois As System.Windows.Forms.TextBox
    Private WithEvents GCANADEPMODELE As DevExpress.XtraGrid.GridControl
    Private WithEvents GVDEPANAMODELE As DevExpress.XtraGrid.Views.Grid.GridView
    Private WithEvents GModColVLIBELLE As DevExpress.XtraGrid.Columns.GridColumn
    Private WithEvents GModColNDEPLOCMAT As DevExpress.XtraGrid.Columns.GridColumn
    Private WithEvents GModColNDEPSTT As DevExpress.XtraGrid.Columns.GridColumn
    Private WithEvents GModColNDEPTRANSP As DevExpress.XtraGrid.Columns.GridColumn
    Private WithEvents GModColNDEPLOCVEH As DevExpress.XtraGrid.Columns.GridColumn
    Private WithEvents GModColNDEPMAT As DevExpress.XtraGrid.Columns.GridColumn
    Private WithEvents GModColNDEPDEPL As DevExpress.XtraGrid.Columns.GridColumn
    Private WithEvents GModColNDEPPAN As DevExpress.XtraGrid.Columns.GridColumn
    Private WithEvents GModColNDEPDOUANE As DevExpress.XtraGrid.Columns.GridColumn
    Private WithEvents GModColNDEPHRMPT As DevExpress.XtraGrid.Columns.GridColumn
    Private WithEvents GModColNDEPHRINT As DevExpress.XtraGrid.Columns.GridColumn
    Private WithEvents GModColNDEPKMS As DevExpress.XtraGrid.Columns.GridColumn
    Private WithEvents GModColNDEPSTOCK As DevExpress.XtraGrid.Columns.GridColumn
    Private WithEvents GModColLINEMODELE As DevExpress.XtraGrid.Columns.GridColumn
    Private WithEvents GCDEPANADETAIL As DevExpress.XtraGrid.GridControl
    Private WithEvents GVDEPANADETAIL As DevExpress.XtraGrid.Views.Grid.GridView
    Private WithEvents GDetColNCANNUM As DevExpress.XtraGrid.Columns.GridColumn
    Private WithEvents GDetCOLVCANLIB As DevExpress.XtraGrid.Columns.GridColumn
    Private WithEvents GDetColTOTAL As DevExpress.XtraGrid.Columns.GridColumn
    Private WithEvents GDetColNDEPLOCMAT As DevExpress.XtraGrid.Columns.GridColumn
    Private WithEvents GDetColNDEPSTT As DevExpress.XtraGrid.Columns.GridColumn
    Private WithEvents GDetColNDEPTRANSP As DevExpress.XtraGrid.Columns.GridColumn
    Private WithEvents GDetColNDEPLOCVEH As DevExpress.XtraGrid.Columns.GridColumn
    Private WithEvents GDetColNDEPMAT As DevExpress.XtraGrid.Columns.GridColumn
    Private WithEvents GDetColNDEPDEPL As DevExpress.XtraGrid.Columns.GridColumn
    Private WithEvents GEdtColNDEPPAN As DevExpress.XtraGrid.Columns.GridColumn
    Private WithEvents GDetColNDEPDOUANE As DevExpress.XtraGrid.Columns.GridColumn
    Private WithEvents GDetColNDEPHRMPT As DevExpress.XtraGrid.Columns.GridColumn
    Private WithEvents GDetColNDEPHRINT As DevExpress.XtraGrid.Columns.GridColumn
    Private WithEvents GDetColNDEPKMS As DevExpress.XtraGrid.Columns.GridColumn
    Private WithEvents GDetColNDEPSTOCK As DevExpress.XtraGrid.Columns.GridColumn
End Class
