<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class FrmDevPrestAffectFiche
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(FrmDevPrestAffectFiche))
        Me.GrpActions = New System.Windows.Forms.GroupBox()
        Me.BtnExportXLS = New System.Windows.Forms.Button()
        Me.BtnDecoupChantier = New System.Windows.Forms.Button()
        Me.BtnFermer = New System.Windows.Forms.Button()
        Me.BtnSave = New System.Windows.Forms.Button()
        Me.LblTitre = New System.Windows.Forms.Label()
        Me.GCDevPrestAffect = New DevExpress.XtraGrid.GridControl()
        Me.GVDevPrestAffect = New DevExpress.XtraGrid.Views.Grid.GridView()
        Me.GColNLDCLPRESTID = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.GColCAT = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.GColVPRESTLIB = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.GColVPRESTUNITE = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.GColNQTE = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.GColNPRESTSERMOHT = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.GColNPRESTQTEMO = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.GColNTOTPRESTQTEMO = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.GColNTOTPRESTSERMOHT = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.GColNPRESTFOHT = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.GColNTOTPRESTFOHT = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.GColTOTAL = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.GColCOEF = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.GColTOTALCOEF = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.GColNPRIXCLITOT = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.GColNIDFICHEFO = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.RepItemComboFicheChantierFO = New DevExpress.XtraEditors.Repository.RepositoryItemGridLookUpEdit()
        Me.RepItemViewCboFicheChantierFO = New DevExpress.XtraGrid.Views.Grid.GridView()
        Me.GVColCboNIDFICHEFO = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.GVColCboVLIBFO = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.GColNIDFICHEMO = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.RepItemComboFicheChantierMO = New DevExpress.XtraEditors.Repository.RepositoryItemGridLookUpEdit()
        Me.RepItemViewCboFicheChantierMO = New DevExpress.XtraGrid.Views.Grid.GridView()
        Me.GVColCboNIDFICHEMO = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.GVColCboVLIBMO = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.GColVLIBDECOUPMO = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.GColVLIBDECOUPFO = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.SFD = New System.Windows.Forms.SaveFileDialog()
        Me.GrpActions.SuspendLayout()
        CType(Me.GCDevPrestAffect, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.GVDevPrestAffect, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.RepItemComboFicheChantierFO, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.RepItemViewCboFicheChantierFO, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.RepItemComboFicheChantierMO, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.RepItemViewCboFicheChantierMO, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'GrpActions
        '
        resources.ApplyResources(Me.GrpActions, "GrpActions")
        Me.GrpActions.Controls.Add(Me.BtnExportXLS)
        Me.GrpActions.Controls.Add(Me.BtnDecoupChantier)
        Me.GrpActions.Controls.Add(Me.BtnFermer)
        Me.GrpActions.Controls.Add(Me.BtnSave)
        Me.GrpActions.Name = "GrpActions"
        Me.GrpActions.TabStop = False
        '
        'BtnExportXLS
        '
        resources.ApplyResources(Me.BtnExportXLS, "BtnExportXLS")
        Me.BtnExportXLS.Name = "BtnExportXLS"
        Me.BtnExportXLS.UseVisualStyleBackColor = True
        '
        'BtnDecoupChantier
        '
        resources.ApplyResources(Me.BtnDecoupChantier, "BtnDecoupChantier")
        Me.BtnDecoupChantier.Name = "BtnDecoupChantier"
        Me.BtnDecoupChantier.UseVisualStyleBackColor = True
        '
        'BtnFermer
        '
        resources.ApplyResources(Me.BtnFermer, "BtnFermer")
        Me.BtnFermer.Name = "BtnFermer"
        Me.BtnFermer.UseVisualStyleBackColor = True
        '
        'BtnSave
        '
        resources.ApplyResources(Me.BtnSave, "BtnSave")
        Me.BtnSave.Name = "BtnSave"
        Me.BtnSave.UseVisualStyleBackColor = True
        '
        'LblTitre
        '
        resources.ApplyResources(Me.LblTitre, "LblTitre")
        Me.LblTitre.Name = "LblTitre"
        '
        'GCDevPrestAffect
        '
        resources.ApplyResources(Me.GCDevPrestAffect, "GCDevPrestAffect")
        '
        '
        '
        Me.GCDevPrestAffect.EmbeddedNavigator.AccessibleDescription = resources.GetString("GCDevPrestAffect.EmbeddedNavigator.AccessibleDescription")
        Me.GCDevPrestAffect.EmbeddedNavigator.AccessibleName = resources.GetString("GCDevPrestAffect.EmbeddedNavigator.AccessibleName")
        Me.GCDevPrestAffect.EmbeddedNavigator.AllowHtmlTextInToolTip = CType(resources.GetObject("GCDevPrestAffect.EmbeddedNavigator.AllowHtmlTextInToolTip"), DevExpress.Utils.DefaultBoolean)
        Me.GCDevPrestAffect.EmbeddedNavigator.Anchor = CType(resources.GetObject("GCDevPrestAffect.EmbeddedNavigator.Anchor"), System.Windows.Forms.AnchorStyles)
        Me.GCDevPrestAffect.EmbeddedNavigator.BackgroundImage = CType(resources.GetObject("GCDevPrestAffect.EmbeddedNavigator.BackgroundImage"), System.Drawing.Image)
        Me.GCDevPrestAffect.EmbeddedNavigator.BackgroundImageLayout = CType(resources.GetObject("GCDevPrestAffect.EmbeddedNavigator.BackgroundImageLayout"), System.Windows.Forms.ImageLayout)
        Me.GCDevPrestAffect.EmbeddedNavigator.ImeMode = CType(resources.GetObject("GCDevPrestAffect.EmbeddedNavigator.ImeMode"), System.Windows.Forms.ImeMode)
        Me.GCDevPrestAffect.EmbeddedNavigator.MaximumSize = CType(resources.GetObject("GCDevPrestAffect.EmbeddedNavigator.MaximumSize"), System.Drawing.Size)
        Me.GCDevPrestAffect.EmbeddedNavigator.TextLocation = CType(resources.GetObject("GCDevPrestAffect.EmbeddedNavigator.TextLocation"), DevExpress.XtraEditors.NavigatorButtonsTextLocation)
        Me.GCDevPrestAffect.EmbeddedNavigator.ToolTip = resources.GetString("GCDevPrestAffect.EmbeddedNavigator.ToolTip")
        Me.GCDevPrestAffect.EmbeddedNavigator.ToolTipIconType = CType(resources.GetObject("GCDevPrestAffect.EmbeddedNavigator.ToolTipIconType"), DevExpress.Utils.ToolTipIconType)
        Me.GCDevPrestAffect.EmbeddedNavigator.ToolTipTitle = resources.GetString("GCDevPrestAffect.EmbeddedNavigator.ToolTipTitle")
        Me.GCDevPrestAffect.MainView = Me.GVDevPrestAffect
        Me.GCDevPrestAffect.Name = "GCDevPrestAffect"
        Me.GCDevPrestAffect.RepositoryItems.AddRange(New DevExpress.XtraEditors.Repository.RepositoryItem() {Me.RepItemComboFicheChantierFO, Me.RepItemComboFicheChantierMO})
        Me.GCDevPrestAffect.ViewCollection.AddRange(New DevExpress.XtraGrid.Views.Base.BaseView() {Me.GVDevPrestAffect})
        '
        'GVDevPrestAffect
        '
        Me.GVDevPrestAffect.Appearance.ColumnFilterButton.BackColor = CType(resources.GetObject("GVDevPrestAffect.Appearance.ColumnFilterButton.BackColor"), System.Drawing.Color)
        Me.GVDevPrestAffect.Appearance.ColumnFilterButton.BackColor2 = CType(resources.GetObject("GVDevPrestAffect.Appearance.ColumnFilterButton.BackColor2"), System.Drawing.Color)
        Me.GVDevPrestAffect.Appearance.ColumnFilterButton.BorderColor = CType(resources.GetObject("GVDevPrestAffect.Appearance.ColumnFilterButton.BorderColor"), System.Drawing.Color)
        Me.GVDevPrestAffect.Appearance.ColumnFilterButton.FontSizeDelta = CType(resources.GetObject("GVDevPrestAffect.Appearance.ColumnFilterButton.FontSizeDelta"), Integer)
        Me.GVDevPrestAffect.Appearance.ColumnFilterButton.FontStyleDelta = CType(resources.GetObject("GVDevPrestAffect.Appearance.ColumnFilterButton.FontStyleDelta"), System.Drawing.FontStyle)
        Me.GVDevPrestAffect.Appearance.ColumnFilterButton.ForeColor = CType(resources.GetObject("GVDevPrestAffect.Appearance.ColumnFilterButton.ForeColor"), System.Drawing.Color)
        Me.GVDevPrestAffect.Appearance.ColumnFilterButton.GradientMode = CType(resources.GetObject("GVDevPrestAffect.Appearance.ColumnFilterButton.GradientMode"), System.Drawing.Drawing2D.LinearGradientMode)
        Me.GVDevPrestAffect.Appearance.ColumnFilterButton.Image = CType(resources.GetObject("GVDevPrestAffect.Appearance.ColumnFilterButton.Image"), System.Drawing.Image)
        Me.GVDevPrestAffect.Appearance.ColumnFilterButton.Options.UseBackColor = True
        Me.GVDevPrestAffect.Appearance.ColumnFilterButton.Options.UseBorderColor = True
        Me.GVDevPrestAffect.Appearance.ColumnFilterButton.Options.UseForeColor = True
        Me.GVDevPrestAffect.Appearance.ColumnFilterButtonActive.BackColor = CType(resources.GetObject("GVDevPrestAffect.Appearance.ColumnFilterButtonActive.BackColor"), System.Drawing.Color)
        Me.GVDevPrestAffect.Appearance.ColumnFilterButtonActive.BackColor2 = CType(resources.GetObject("GVDevPrestAffect.Appearance.ColumnFilterButtonActive.BackColor2"), System.Drawing.Color)
        Me.GVDevPrestAffect.Appearance.ColumnFilterButtonActive.BorderColor = CType(resources.GetObject("GVDevPrestAffect.Appearance.ColumnFilterButtonActive.BorderColor"), System.Drawing.Color)
        Me.GVDevPrestAffect.Appearance.ColumnFilterButtonActive.FontSizeDelta = CType(resources.GetObject("GVDevPrestAffect.Appearance.ColumnFilterButtonActive.FontSizeDelta"), Integer)
        Me.GVDevPrestAffect.Appearance.ColumnFilterButtonActive.FontStyleDelta = CType(resources.GetObject("GVDevPrestAffect.Appearance.ColumnFilterButtonActive.FontStyleDelta"), System.Drawing.FontStyle)
        Me.GVDevPrestAffect.Appearance.ColumnFilterButtonActive.ForeColor = CType(resources.GetObject("GVDevPrestAffect.Appearance.ColumnFilterButtonActive.ForeColor"), System.Drawing.Color)
        Me.GVDevPrestAffect.Appearance.ColumnFilterButtonActive.GradientMode = CType(resources.GetObject("GVDevPrestAffect.Appearance.ColumnFilterButtonActive.GradientMode"), System.Drawing.Drawing2D.LinearGradientMode)
        Me.GVDevPrestAffect.Appearance.ColumnFilterButtonActive.Image = CType(resources.GetObject("GVDevPrestAffect.Appearance.ColumnFilterButtonActive.Image"), System.Drawing.Image)
        Me.GVDevPrestAffect.Appearance.ColumnFilterButtonActive.Options.UseBackColor = True
        Me.GVDevPrestAffect.Appearance.ColumnFilterButtonActive.Options.UseBorderColor = True
        Me.GVDevPrestAffect.Appearance.ColumnFilterButtonActive.Options.UseForeColor = True
        Me.GVDevPrestAffect.Appearance.Empty.BackColor = CType(resources.GetObject("GVDevPrestAffect.Appearance.Empty.BackColor"), System.Drawing.Color)
        Me.GVDevPrestAffect.Appearance.Empty.FontSizeDelta = CType(resources.GetObject("GVDevPrestAffect.Appearance.Empty.FontSizeDelta"), Integer)
        Me.GVDevPrestAffect.Appearance.Empty.FontStyleDelta = CType(resources.GetObject("GVDevPrestAffect.Appearance.Empty.FontStyleDelta"), System.Drawing.FontStyle)
        Me.GVDevPrestAffect.Appearance.Empty.GradientMode = CType(resources.GetObject("GVDevPrestAffect.Appearance.Empty.GradientMode"), System.Drawing.Drawing2D.LinearGradientMode)
        Me.GVDevPrestAffect.Appearance.Empty.Image = CType(resources.GetObject("GVDevPrestAffect.Appearance.Empty.Image"), System.Drawing.Image)
        Me.GVDevPrestAffect.Appearance.Empty.Options.UseBackColor = True
        Me.GVDevPrestAffect.Appearance.EvenRow.BackColor = CType(resources.GetObject("GVDevPrestAffect.Appearance.EvenRow.BackColor"), System.Drawing.Color)
        Me.GVDevPrestAffect.Appearance.EvenRow.FontSizeDelta = CType(resources.GetObject("GVDevPrestAffect.Appearance.EvenRow.FontSizeDelta"), Integer)
        Me.GVDevPrestAffect.Appearance.EvenRow.FontStyleDelta = CType(resources.GetObject("GVDevPrestAffect.Appearance.EvenRow.FontStyleDelta"), System.Drawing.FontStyle)
        Me.GVDevPrestAffect.Appearance.EvenRow.ForeColor = CType(resources.GetObject("GVDevPrestAffect.Appearance.EvenRow.ForeColor"), System.Drawing.Color)
        Me.GVDevPrestAffect.Appearance.EvenRow.GradientMode = CType(resources.GetObject("GVDevPrestAffect.Appearance.EvenRow.GradientMode"), System.Drawing.Drawing2D.LinearGradientMode)
        Me.GVDevPrestAffect.Appearance.EvenRow.Image = CType(resources.GetObject("GVDevPrestAffect.Appearance.EvenRow.Image"), System.Drawing.Image)
        Me.GVDevPrestAffect.Appearance.EvenRow.Options.UseBackColor = True
        Me.GVDevPrestAffect.Appearance.EvenRow.Options.UseForeColor = True
        Me.GVDevPrestAffect.Appearance.FilterCloseButton.BackColor = CType(resources.GetObject("GVDevPrestAffect.Appearance.FilterCloseButton.BackColor"), System.Drawing.Color)
        Me.GVDevPrestAffect.Appearance.FilterCloseButton.BackColor2 = CType(resources.GetObject("GVDevPrestAffect.Appearance.FilterCloseButton.BackColor2"), System.Drawing.Color)
        Me.GVDevPrestAffect.Appearance.FilterCloseButton.BorderColor = CType(resources.GetObject("GVDevPrestAffect.Appearance.FilterCloseButton.BorderColor"), System.Drawing.Color)
        Me.GVDevPrestAffect.Appearance.FilterCloseButton.FontSizeDelta = CType(resources.GetObject("GVDevPrestAffect.Appearance.FilterCloseButton.FontSizeDelta"), Integer)
        Me.GVDevPrestAffect.Appearance.FilterCloseButton.FontStyleDelta = CType(resources.GetObject("GVDevPrestAffect.Appearance.FilterCloseButton.FontStyleDelta"), System.Drawing.FontStyle)
        Me.GVDevPrestAffect.Appearance.FilterCloseButton.ForeColor = CType(resources.GetObject("GVDevPrestAffect.Appearance.FilterCloseButton.ForeColor"), System.Drawing.Color)
        Me.GVDevPrestAffect.Appearance.FilterCloseButton.GradientMode = CType(resources.GetObject("GVDevPrestAffect.Appearance.FilterCloseButton.GradientMode"), System.Drawing.Drawing2D.LinearGradientMode)
        Me.GVDevPrestAffect.Appearance.FilterCloseButton.Image = CType(resources.GetObject("GVDevPrestAffect.Appearance.FilterCloseButton.Image"), System.Drawing.Image)
        Me.GVDevPrestAffect.Appearance.FilterCloseButton.Options.UseBackColor = True
        Me.GVDevPrestAffect.Appearance.FilterCloseButton.Options.UseBorderColor = True
        Me.GVDevPrestAffect.Appearance.FilterCloseButton.Options.UseForeColor = True
        Me.GVDevPrestAffect.Appearance.FilterPanel.BackColor = CType(resources.GetObject("GVDevPrestAffect.Appearance.FilterPanel.BackColor"), System.Drawing.Color)
        Me.GVDevPrestAffect.Appearance.FilterPanel.FontSizeDelta = CType(resources.GetObject("GVDevPrestAffect.Appearance.FilterPanel.FontSizeDelta"), Integer)
        Me.GVDevPrestAffect.Appearance.FilterPanel.FontStyleDelta = CType(resources.GetObject("GVDevPrestAffect.Appearance.FilterPanel.FontStyleDelta"), System.Drawing.FontStyle)
        Me.GVDevPrestAffect.Appearance.FilterPanel.ForeColor = CType(resources.GetObject("GVDevPrestAffect.Appearance.FilterPanel.ForeColor"), System.Drawing.Color)
        Me.GVDevPrestAffect.Appearance.FilterPanel.GradientMode = CType(resources.GetObject("GVDevPrestAffect.Appearance.FilterPanel.GradientMode"), System.Drawing.Drawing2D.LinearGradientMode)
        Me.GVDevPrestAffect.Appearance.FilterPanel.Image = CType(resources.GetObject("GVDevPrestAffect.Appearance.FilterPanel.Image"), System.Drawing.Image)
        Me.GVDevPrestAffect.Appearance.FilterPanel.Options.UseBackColor = True
        Me.GVDevPrestAffect.Appearance.FilterPanel.Options.UseForeColor = True
        Me.GVDevPrestAffect.Appearance.FixedLine.BackColor = CType(resources.GetObject("GVDevPrestAffect.Appearance.FixedLine.BackColor"), System.Drawing.Color)
        Me.GVDevPrestAffect.Appearance.FixedLine.FontSizeDelta = CType(resources.GetObject("GVDevPrestAffect.Appearance.FixedLine.FontSizeDelta"), Integer)
        Me.GVDevPrestAffect.Appearance.FixedLine.FontStyleDelta = CType(resources.GetObject("GVDevPrestAffect.Appearance.FixedLine.FontStyleDelta"), System.Drawing.FontStyle)
        Me.GVDevPrestAffect.Appearance.FixedLine.GradientMode = CType(resources.GetObject("GVDevPrestAffect.Appearance.FixedLine.GradientMode"), System.Drawing.Drawing2D.LinearGradientMode)
        Me.GVDevPrestAffect.Appearance.FixedLine.Image = CType(resources.GetObject("GVDevPrestAffect.Appearance.FixedLine.Image"), System.Drawing.Image)
        Me.GVDevPrestAffect.Appearance.FixedLine.Options.UseBackColor = True
        Me.GVDevPrestAffect.Appearance.FocusedCell.BackColor = CType(resources.GetObject("GVDevPrestAffect.Appearance.FocusedCell.BackColor"), System.Drawing.Color)
        Me.GVDevPrestAffect.Appearance.FocusedCell.FontSizeDelta = CType(resources.GetObject("GVDevPrestAffect.Appearance.FocusedCell.FontSizeDelta"), Integer)
        Me.GVDevPrestAffect.Appearance.FocusedCell.FontStyleDelta = CType(resources.GetObject("GVDevPrestAffect.Appearance.FocusedCell.FontStyleDelta"), System.Drawing.FontStyle)
        Me.GVDevPrestAffect.Appearance.FocusedCell.ForeColor = CType(resources.GetObject("GVDevPrestAffect.Appearance.FocusedCell.ForeColor"), System.Drawing.Color)
        Me.GVDevPrestAffect.Appearance.FocusedCell.GradientMode = CType(resources.GetObject("GVDevPrestAffect.Appearance.FocusedCell.GradientMode"), System.Drawing.Drawing2D.LinearGradientMode)
        Me.GVDevPrestAffect.Appearance.FocusedCell.Image = CType(resources.GetObject("GVDevPrestAffect.Appearance.FocusedCell.Image"), System.Drawing.Image)
        Me.GVDevPrestAffect.Appearance.FocusedCell.Options.UseBackColor = True
        Me.GVDevPrestAffect.Appearance.FocusedCell.Options.UseForeColor = True
        Me.GVDevPrestAffect.Appearance.FocusedRow.BackColor = CType(resources.GetObject("GVDevPrestAffect.Appearance.FocusedRow.BackColor"), System.Drawing.Color)
        Me.GVDevPrestAffect.Appearance.FocusedRow.FontSizeDelta = CType(resources.GetObject("GVDevPrestAffect.Appearance.FocusedRow.FontSizeDelta"), Integer)
        Me.GVDevPrestAffect.Appearance.FocusedRow.FontStyleDelta = CType(resources.GetObject("GVDevPrestAffect.Appearance.FocusedRow.FontStyleDelta"), System.Drawing.FontStyle)
        Me.GVDevPrestAffect.Appearance.FocusedRow.ForeColor = CType(resources.GetObject("GVDevPrestAffect.Appearance.FocusedRow.ForeColor"), System.Drawing.Color)
        Me.GVDevPrestAffect.Appearance.FocusedRow.GradientMode = CType(resources.GetObject("GVDevPrestAffect.Appearance.FocusedRow.GradientMode"), System.Drawing.Drawing2D.LinearGradientMode)
        Me.GVDevPrestAffect.Appearance.FocusedRow.Image = CType(resources.GetObject("GVDevPrestAffect.Appearance.FocusedRow.Image"), System.Drawing.Image)
        Me.GVDevPrestAffect.Appearance.FocusedRow.Options.UseBackColor = True
        Me.GVDevPrestAffect.Appearance.FocusedRow.Options.UseForeColor = True
        Me.GVDevPrestAffect.Appearance.FooterPanel.BackColor = CType(resources.GetObject("GVDevPrestAffect.Appearance.FooterPanel.BackColor"), System.Drawing.Color)
        Me.GVDevPrestAffect.Appearance.FooterPanel.BackColor2 = CType(resources.GetObject("GVDevPrestAffect.Appearance.FooterPanel.BackColor2"), System.Drawing.Color)
        Me.GVDevPrestAffect.Appearance.FooterPanel.BorderColor = CType(resources.GetObject("GVDevPrestAffect.Appearance.FooterPanel.BorderColor"), System.Drawing.Color)
        Me.GVDevPrestAffect.Appearance.FooterPanel.FontSizeDelta = CType(resources.GetObject("GVDevPrestAffect.Appearance.FooterPanel.FontSizeDelta"), Integer)
        Me.GVDevPrestAffect.Appearance.FooterPanel.FontStyleDelta = CType(resources.GetObject("GVDevPrestAffect.Appearance.FooterPanel.FontStyleDelta"), System.Drawing.FontStyle)
        Me.GVDevPrestAffect.Appearance.FooterPanel.ForeColor = CType(resources.GetObject("GVDevPrestAffect.Appearance.FooterPanel.ForeColor"), System.Drawing.Color)
        Me.GVDevPrestAffect.Appearance.FooterPanel.GradientMode = CType(resources.GetObject("GVDevPrestAffect.Appearance.FooterPanel.GradientMode"), System.Drawing.Drawing2D.LinearGradientMode)
        Me.GVDevPrestAffect.Appearance.FooterPanel.Image = CType(resources.GetObject("GVDevPrestAffect.Appearance.FooterPanel.Image"), System.Drawing.Image)
        Me.GVDevPrestAffect.Appearance.FooterPanel.Options.UseBackColor = True
        Me.GVDevPrestAffect.Appearance.FooterPanel.Options.UseBorderColor = True
        Me.GVDevPrestAffect.Appearance.FooterPanel.Options.UseForeColor = True
        Me.GVDevPrestAffect.Appearance.GroupButton.BackColor = CType(resources.GetObject("GVDevPrestAffect.Appearance.GroupButton.BackColor"), System.Drawing.Color)
        Me.GVDevPrestAffect.Appearance.GroupButton.BorderColor = CType(resources.GetObject("GVDevPrestAffect.Appearance.GroupButton.BorderColor"), System.Drawing.Color)
        Me.GVDevPrestAffect.Appearance.GroupButton.FontSizeDelta = CType(resources.GetObject("GVDevPrestAffect.Appearance.GroupButton.FontSizeDelta"), Integer)
        Me.GVDevPrestAffect.Appearance.GroupButton.FontStyleDelta = CType(resources.GetObject("GVDevPrestAffect.Appearance.GroupButton.FontStyleDelta"), System.Drawing.FontStyle)
        Me.GVDevPrestAffect.Appearance.GroupButton.ForeColor = CType(resources.GetObject("GVDevPrestAffect.Appearance.GroupButton.ForeColor"), System.Drawing.Color)
        Me.GVDevPrestAffect.Appearance.GroupButton.GradientMode = CType(resources.GetObject("GVDevPrestAffect.Appearance.GroupButton.GradientMode"), System.Drawing.Drawing2D.LinearGradientMode)
        Me.GVDevPrestAffect.Appearance.GroupButton.Image = CType(resources.GetObject("GVDevPrestAffect.Appearance.GroupButton.Image"), System.Drawing.Image)
        Me.GVDevPrestAffect.Appearance.GroupButton.Options.UseBackColor = True
        Me.GVDevPrestAffect.Appearance.GroupButton.Options.UseBorderColor = True
        Me.GVDevPrestAffect.Appearance.GroupButton.Options.UseForeColor = True
        Me.GVDevPrestAffect.Appearance.GroupFooter.BackColor = CType(resources.GetObject("GVDevPrestAffect.Appearance.GroupFooter.BackColor"), System.Drawing.Color)
        Me.GVDevPrestAffect.Appearance.GroupFooter.BorderColor = CType(resources.GetObject("GVDevPrestAffect.Appearance.GroupFooter.BorderColor"), System.Drawing.Color)
        Me.GVDevPrestAffect.Appearance.GroupFooter.FontSizeDelta = CType(resources.GetObject("GVDevPrestAffect.Appearance.GroupFooter.FontSizeDelta"), Integer)
        Me.GVDevPrestAffect.Appearance.GroupFooter.FontStyleDelta = CType(resources.GetObject("GVDevPrestAffect.Appearance.GroupFooter.FontStyleDelta"), System.Drawing.FontStyle)
        Me.GVDevPrestAffect.Appearance.GroupFooter.ForeColor = CType(resources.GetObject("GVDevPrestAffect.Appearance.GroupFooter.ForeColor"), System.Drawing.Color)
        Me.GVDevPrestAffect.Appearance.GroupFooter.GradientMode = CType(resources.GetObject("GVDevPrestAffect.Appearance.GroupFooter.GradientMode"), System.Drawing.Drawing2D.LinearGradientMode)
        Me.GVDevPrestAffect.Appearance.GroupFooter.Image = CType(resources.GetObject("GVDevPrestAffect.Appearance.GroupFooter.Image"), System.Drawing.Image)
        Me.GVDevPrestAffect.Appearance.GroupFooter.Options.UseBackColor = True
        Me.GVDevPrestAffect.Appearance.GroupFooter.Options.UseBorderColor = True
        Me.GVDevPrestAffect.Appearance.GroupFooter.Options.UseForeColor = True
        Me.GVDevPrestAffect.Appearance.GroupPanel.BackColor = CType(resources.GetObject("GVDevPrestAffect.Appearance.GroupPanel.BackColor"), System.Drawing.Color)
        Me.GVDevPrestAffect.Appearance.GroupPanel.FontSizeDelta = CType(resources.GetObject("GVDevPrestAffect.Appearance.GroupPanel.FontSizeDelta"), Integer)
        Me.GVDevPrestAffect.Appearance.GroupPanel.FontStyleDelta = CType(resources.GetObject("GVDevPrestAffect.Appearance.GroupPanel.FontStyleDelta"), System.Drawing.FontStyle)
        Me.GVDevPrestAffect.Appearance.GroupPanel.ForeColor = CType(resources.GetObject("GVDevPrestAffect.Appearance.GroupPanel.ForeColor"), System.Drawing.Color)
        Me.GVDevPrestAffect.Appearance.GroupPanel.GradientMode = CType(resources.GetObject("GVDevPrestAffect.Appearance.GroupPanel.GradientMode"), System.Drawing.Drawing2D.LinearGradientMode)
        Me.GVDevPrestAffect.Appearance.GroupPanel.Image = CType(resources.GetObject("GVDevPrestAffect.Appearance.GroupPanel.Image"), System.Drawing.Image)
        Me.GVDevPrestAffect.Appearance.GroupPanel.Options.UseBackColor = True
        Me.GVDevPrestAffect.Appearance.GroupPanel.Options.UseForeColor = True
        Me.GVDevPrestAffect.Appearance.GroupRow.BackColor = CType(resources.GetObject("GVDevPrestAffect.Appearance.GroupRow.BackColor"), System.Drawing.Color)
        Me.GVDevPrestAffect.Appearance.GroupRow.BorderColor = CType(resources.GetObject("GVDevPrestAffect.Appearance.GroupRow.BorderColor"), System.Drawing.Color)
        Me.GVDevPrestAffect.Appearance.GroupRow.Font = CType(resources.GetObject("GVDevPrestAffect.Appearance.GroupRow.Font"), System.Drawing.Font)
        Me.GVDevPrestAffect.Appearance.GroupRow.FontSizeDelta = CType(resources.GetObject("GVDevPrestAffect.Appearance.GroupRow.FontSizeDelta"), Integer)
        Me.GVDevPrestAffect.Appearance.GroupRow.FontStyleDelta = CType(resources.GetObject("GVDevPrestAffect.Appearance.GroupRow.FontStyleDelta"), System.Drawing.FontStyle)
        Me.GVDevPrestAffect.Appearance.GroupRow.ForeColor = CType(resources.GetObject("GVDevPrestAffect.Appearance.GroupRow.ForeColor"), System.Drawing.Color)
        Me.GVDevPrestAffect.Appearance.GroupRow.GradientMode = CType(resources.GetObject("GVDevPrestAffect.Appearance.GroupRow.GradientMode"), System.Drawing.Drawing2D.LinearGradientMode)
        Me.GVDevPrestAffect.Appearance.GroupRow.Image = CType(resources.GetObject("GVDevPrestAffect.Appearance.GroupRow.Image"), System.Drawing.Image)
        Me.GVDevPrestAffect.Appearance.GroupRow.Options.UseBackColor = True
        Me.GVDevPrestAffect.Appearance.GroupRow.Options.UseBorderColor = True
        Me.GVDevPrestAffect.Appearance.GroupRow.Options.UseFont = True
        Me.GVDevPrestAffect.Appearance.GroupRow.Options.UseForeColor = True
        Me.GVDevPrestAffect.Appearance.HeaderPanel.BackColor = CType(resources.GetObject("GVDevPrestAffect.Appearance.HeaderPanel.BackColor"), System.Drawing.Color)
        Me.GVDevPrestAffect.Appearance.HeaderPanel.BackColor2 = CType(resources.GetObject("GVDevPrestAffect.Appearance.HeaderPanel.BackColor2"), System.Drawing.Color)
        Me.GVDevPrestAffect.Appearance.HeaderPanel.BorderColor = CType(resources.GetObject("GVDevPrestAffect.Appearance.HeaderPanel.BorderColor"), System.Drawing.Color)
        Me.GVDevPrestAffect.Appearance.HeaderPanel.FontSizeDelta = CType(resources.GetObject("GVDevPrestAffect.Appearance.HeaderPanel.FontSizeDelta"), Integer)
        Me.GVDevPrestAffect.Appearance.HeaderPanel.FontStyleDelta = CType(resources.GetObject("GVDevPrestAffect.Appearance.HeaderPanel.FontStyleDelta"), System.Drawing.FontStyle)
        Me.GVDevPrestAffect.Appearance.HeaderPanel.ForeColor = CType(resources.GetObject("GVDevPrestAffect.Appearance.HeaderPanel.ForeColor"), System.Drawing.Color)
        Me.GVDevPrestAffect.Appearance.HeaderPanel.GradientMode = CType(resources.GetObject("GVDevPrestAffect.Appearance.HeaderPanel.GradientMode"), System.Drawing.Drawing2D.LinearGradientMode)
        Me.GVDevPrestAffect.Appearance.HeaderPanel.Image = CType(resources.GetObject("GVDevPrestAffect.Appearance.HeaderPanel.Image"), System.Drawing.Image)
        Me.GVDevPrestAffect.Appearance.HeaderPanel.Options.UseBackColor = True
        Me.GVDevPrestAffect.Appearance.HeaderPanel.Options.UseBorderColor = True
        Me.GVDevPrestAffect.Appearance.HeaderPanel.Options.UseForeColor = True
        Me.GVDevPrestAffect.Appearance.HeaderPanel.Options.UseTextOptions = True
        Me.GVDevPrestAffect.Appearance.HeaderPanel.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center
        Me.GVDevPrestAffect.Appearance.HeaderPanel.TextOptions.VAlignment = DevExpress.Utils.VertAlignment.Center
        Me.GVDevPrestAffect.Appearance.HeaderPanel.TextOptions.WordWrap = DevExpress.Utils.WordWrap.Wrap
        Me.GVDevPrestAffect.Appearance.HideSelectionRow.BackColor = CType(resources.GetObject("GVDevPrestAffect.Appearance.HideSelectionRow.BackColor"), System.Drawing.Color)
        Me.GVDevPrestAffect.Appearance.HideSelectionRow.FontSizeDelta = CType(resources.GetObject("GVDevPrestAffect.Appearance.HideSelectionRow.FontSizeDelta"), Integer)
        Me.GVDevPrestAffect.Appearance.HideSelectionRow.FontStyleDelta = CType(resources.GetObject("GVDevPrestAffect.Appearance.HideSelectionRow.FontStyleDelta"), System.Drawing.FontStyle)
        Me.GVDevPrestAffect.Appearance.HideSelectionRow.ForeColor = CType(resources.GetObject("GVDevPrestAffect.Appearance.HideSelectionRow.ForeColor"), System.Drawing.Color)
        Me.GVDevPrestAffect.Appearance.HideSelectionRow.GradientMode = CType(resources.GetObject("GVDevPrestAffect.Appearance.HideSelectionRow.GradientMode"), System.Drawing.Drawing2D.LinearGradientMode)
        Me.GVDevPrestAffect.Appearance.HideSelectionRow.Image = CType(resources.GetObject("GVDevPrestAffect.Appearance.HideSelectionRow.Image"), System.Drawing.Image)
        Me.GVDevPrestAffect.Appearance.HideSelectionRow.Options.UseBackColor = True
        Me.GVDevPrestAffect.Appearance.HideSelectionRow.Options.UseForeColor = True
        Me.GVDevPrestAffect.Appearance.HorzLine.BackColor = CType(resources.GetObject("GVDevPrestAffect.Appearance.HorzLine.BackColor"), System.Drawing.Color)
        Me.GVDevPrestAffect.Appearance.HorzLine.FontSizeDelta = CType(resources.GetObject("GVDevPrestAffect.Appearance.HorzLine.FontSizeDelta"), Integer)
        Me.GVDevPrestAffect.Appearance.HorzLine.FontStyleDelta = CType(resources.GetObject("GVDevPrestAffect.Appearance.HorzLine.FontStyleDelta"), System.Drawing.FontStyle)
        Me.GVDevPrestAffect.Appearance.HorzLine.GradientMode = CType(resources.GetObject("GVDevPrestAffect.Appearance.HorzLine.GradientMode"), System.Drawing.Drawing2D.LinearGradientMode)
        Me.GVDevPrestAffect.Appearance.HorzLine.Image = CType(resources.GetObject("GVDevPrestAffect.Appearance.HorzLine.Image"), System.Drawing.Image)
        Me.GVDevPrestAffect.Appearance.HorzLine.Options.UseBackColor = True
        Me.GVDevPrestAffect.Appearance.OddRow.BackColor = CType(resources.GetObject("GVDevPrestAffect.Appearance.OddRow.BackColor"), System.Drawing.Color)
        Me.GVDevPrestAffect.Appearance.OddRow.FontSizeDelta = CType(resources.GetObject("GVDevPrestAffect.Appearance.OddRow.FontSizeDelta"), Integer)
        Me.GVDevPrestAffect.Appearance.OddRow.FontStyleDelta = CType(resources.GetObject("GVDevPrestAffect.Appearance.OddRow.FontStyleDelta"), System.Drawing.FontStyle)
        Me.GVDevPrestAffect.Appearance.OddRow.ForeColor = CType(resources.GetObject("GVDevPrestAffect.Appearance.OddRow.ForeColor"), System.Drawing.Color)
        Me.GVDevPrestAffect.Appearance.OddRow.GradientMode = CType(resources.GetObject("GVDevPrestAffect.Appearance.OddRow.GradientMode"), System.Drawing.Drawing2D.LinearGradientMode)
        Me.GVDevPrestAffect.Appearance.OddRow.Image = CType(resources.GetObject("GVDevPrestAffect.Appearance.OddRow.Image"), System.Drawing.Image)
        Me.GVDevPrestAffect.Appearance.OddRow.Options.UseBackColor = True
        Me.GVDevPrestAffect.Appearance.OddRow.Options.UseForeColor = True
        Me.GVDevPrestAffect.Appearance.Preview.BackColor = CType(resources.GetObject("GVDevPrestAffect.Appearance.Preview.BackColor"), System.Drawing.Color)
        Me.GVDevPrestAffect.Appearance.Preview.FontSizeDelta = CType(resources.GetObject("GVDevPrestAffect.Appearance.Preview.FontSizeDelta"), Integer)
        Me.GVDevPrestAffect.Appearance.Preview.FontStyleDelta = CType(resources.GetObject("GVDevPrestAffect.Appearance.Preview.FontStyleDelta"), System.Drawing.FontStyle)
        Me.GVDevPrestAffect.Appearance.Preview.ForeColor = CType(resources.GetObject("GVDevPrestAffect.Appearance.Preview.ForeColor"), System.Drawing.Color)
        Me.GVDevPrestAffect.Appearance.Preview.GradientMode = CType(resources.GetObject("GVDevPrestAffect.Appearance.Preview.GradientMode"), System.Drawing.Drawing2D.LinearGradientMode)
        Me.GVDevPrestAffect.Appearance.Preview.Image = CType(resources.GetObject("GVDevPrestAffect.Appearance.Preview.Image"), System.Drawing.Image)
        Me.GVDevPrestAffect.Appearance.Preview.Options.UseBackColor = True
        Me.GVDevPrestAffect.Appearance.Preview.Options.UseForeColor = True
        Me.GVDevPrestAffect.Appearance.Row.BackColor = CType(resources.GetObject("GVDevPrestAffect.Appearance.Row.BackColor"), System.Drawing.Color)
        Me.GVDevPrestAffect.Appearance.Row.FontSizeDelta = CType(resources.GetObject("GVDevPrestAffect.Appearance.Row.FontSizeDelta"), Integer)
        Me.GVDevPrestAffect.Appearance.Row.FontStyleDelta = CType(resources.GetObject("GVDevPrestAffect.Appearance.Row.FontStyleDelta"), System.Drawing.FontStyle)
        Me.GVDevPrestAffect.Appearance.Row.ForeColor = CType(resources.GetObject("GVDevPrestAffect.Appearance.Row.ForeColor"), System.Drawing.Color)
        Me.GVDevPrestAffect.Appearance.Row.GradientMode = CType(resources.GetObject("GVDevPrestAffect.Appearance.Row.GradientMode"), System.Drawing.Drawing2D.LinearGradientMode)
        Me.GVDevPrestAffect.Appearance.Row.Image = CType(resources.GetObject("GVDevPrestAffect.Appearance.Row.Image"), System.Drawing.Image)
        Me.GVDevPrestAffect.Appearance.Row.Options.UseBackColor = True
        Me.GVDevPrestAffect.Appearance.Row.Options.UseForeColor = True
        Me.GVDevPrestAffect.Appearance.RowSeparator.BackColor = CType(resources.GetObject("GVDevPrestAffect.Appearance.RowSeparator.BackColor"), System.Drawing.Color)
        Me.GVDevPrestAffect.Appearance.RowSeparator.FontSizeDelta = CType(resources.GetObject("GVDevPrestAffect.Appearance.RowSeparator.FontSizeDelta"), Integer)
        Me.GVDevPrestAffect.Appearance.RowSeparator.FontStyleDelta = CType(resources.GetObject("GVDevPrestAffect.Appearance.RowSeparator.FontStyleDelta"), System.Drawing.FontStyle)
        Me.GVDevPrestAffect.Appearance.RowSeparator.GradientMode = CType(resources.GetObject("GVDevPrestAffect.Appearance.RowSeparator.GradientMode"), System.Drawing.Drawing2D.LinearGradientMode)
        Me.GVDevPrestAffect.Appearance.RowSeparator.Image = CType(resources.GetObject("GVDevPrestAffect.Appearance.RowSeparator.Image"), System.Drawing.Image)
        Me.GVDevPrestAffect.Appearance.RowSeparator.Options.UseBackColor = True
        Me.GVDevPrestAffect.Appearance.SelectedRow.BackColor = CType(resources.GetObject("GVDevPrestAffect.Appearance.SelectedRow.BackColor"), System.Drawing.Color)
        Me.GVDevPrestAffect.Appearance.SelectedRow.FontSizeDelta = CType(resources.GetObject("GVDevPrestAffect.Appearance.SelectedRow.FontSizeDelta"), Integer)
        Me.GVDevPrestAffect.Appearance.SelectedRow.FontStyleDelta = CType(resources.GetObject("GVDevPrestAffect.Appearance.SelectedRow.FontStyleDelta"), System.Drawing.FontStyle)
        Me.GVDevPrestAffect.Appearance.SelectedRow.ForeColor = CType(resources.GetObject("GVDevPrestAffect.Appearance.SelectedRow.ForeColor"), System.Drawing.Color)
        Me.GVDevPrestAffect.Appearance.SelectedRow.GradientMode = CType(resources.GetObject("GVDevPrestAffect.Appearance.SelectedRow.GradientMode"), System.Drawing.Drawing2D.LinearGradientMode)
        Me.GVDevPrestAffect.Appearance.SelectedRow.Image = CType(resources.GetObject("GVDevPrestAffect.Appearance.SelectedRow.Image"), System.Drawing.Image)
        Me.GVDevPrestAffect.Appearance.SelectedRow.Options.UseBackColor = True
        Me.GVDevPrestAffect.Appearance.SelectedRow.Options.UseForeColor = True
        Me.GVDevPrestAffect.Appearance.VertLine.BackColor = CType(resources.GetObject("GVDevPrestAffect.Appearance.VertLine.BackColor"), System.Drawing.Color)
        Me.GVDevPrestAffect.Appearance.VertLine.FontSizeDelta = CType(resources.GetObject("GVDevPrestAffect.Appearance.VertLine.FontSizeDelta"), Integer)
        Me.GVDevPrestAffect.Appearance.VertLine.FontStyleDelta = CType(resources.GetObject("GVDevPrestAffect.Appearance.VertLine.FontStyleDelta"), System.Drawing.FontStyle)
        Me.GVDevPrestAffect.Appearance.VertLine.GradientMode = CType(resources.GetObject("GVDevPrestAffect.Appearance.VertLine.GradientMode"), System.Drawing.Drawing2D.LinearGradientMode)
        Me.GVDevPrestAffect.Appearance.VertLine.Image = CType(resources.GetObject("GVDevPrestAffect.Appearance.VertLine.Image"), System.Drawing.Image)
        Me.GVDevPrestAffect.Appearance.VertLine.Options.UseBackColor = True
        resources.ApplyResources(Me.GVDevPrestAffect, "GVDevPrestAffect")
        Me.GVDevPrestAffect.ColumnPanelRowHeight = 40
        Me.GVDevPrestAffect.Columns.AddRange(New DevExpress.XtraGrid.Columns.GridColumn() {Me.GColNLDCLPRESTID, Me.GColCAT, Me.GColVPRESTLIB, Me.GColVPRESTUNITE, Me.GColNQTE, Me.GColNPRESTSERMOHT, Me.GColNPRESTQTEMO, Me.GColNTOTPRESTQTEMO, Me.GColNTOTPRESTSERMOHT, Me.GColNPRESTFOHT, Me.GColNTOTPRESTFOHT, Me.GColTOTAL, Me.GColCOEF, Me.GColTOTALCOEF, Me.GColNPRIXCLITOT, Me.GColNIDFICHEFO, Me.GColNIDFICHEMO, Me.GColVLIBDECOUPMO, Me.GColVLIBDECOUPFO})
        Me.GVDevPrestAffect.GridControl = Me.GCDevPrestAffect
        Me.GVDevPrestAffect.Name = "GVDevPrestAffect"
        Me.GVDevPrestAffect.OptionsBehavior.AllowAddRows = DevExpress.Utils.DefaultBoolean.[False]
        Me.GVDevPrestAffect.OptionsBehavior.AllowDeleteRows = DevExpress.Utils.DefaultBoolean.[True]
        Me.GVDevPrestAffect.OptionsView.EnableAppearanceEvenRow = True
        Me.GVDevPrestAffect.OptionsView.EnableAppearanceOddRow = True
        Me.GVDevPrestAffect.OptionsView.ShowAutoFilterRow = True
        Me.GVDevPrestAffect.OptionsView.ShowGroupPanel = False
        '
        'GColNLDCLPRESTID
        '
        resources.ApplyResources(Me.GColNLDCLPRESTID, "GColNLDCLPRESTID")
        Me.GColNLDCLPRESTID.FieldName = "NLDCLPRESTID"
        Me.GColNLDCLPRESTID.Name = "GColNLDCLPRESTID"
        Me.GColNLDCLPRESTID.OptionsColumn.AllowEdit = False
        Me.GColNLDCLPRESTID.OptionsColumn.AllowFocus = False
        Me.GColNLDCLPRESTID.OptionsColumn.ReadOnly = True
        '
        'GColCAT
        '
        resources.ApplyResources(Me.GColCAT, "GColCAT")
        Me.GColCAT.FieldName = "CAT"
        Me.GColCAT.Name = "GColCAT"
        Me.GColCAT.OptionsColumn.AllowEdit = False
        Me.GColCAT.OptionsColumn.AllowFocus = False
        Me.GColCAT.OptionsColumn.ReadOnly = True
        Me.GColCAT.OptionsFilter.AutoFilterCondition = DevExpress.XtraGrid.Columns.AutoFilterCondition.Contains
        '
        'GColVPRESTLIB
        '
        resources.ApplyResources(Me.GColVPRESTLIB, "GColVPRESTLIB")
        Me.GColVPRESTLIB.FieldName = "VPRESTLIB"
        Me.GColVPRESTLIB.Name = "GColVPRESTLIB"
        Me.GColVPRESTLIB.OptionsColumn.AllowEdit = False
        Me.GColVPRESTLIB.OptionsColumn.AllowFocus = False
        Me.GColVPRESTLIB.OptionsColumn.ReadOnly = True
        Me.GColVPRESTLIB.OptionsFilter.AutoFilterCondition = DevExpress.XtraGrid.Columns.AutoFilterCondition.Contains
        '
        'GColVPRESTUNITE
        '
        resources.ApplyResources(Me.GColVPRESTUNITE, "GColVPRESTUNITE")
        Me.GColVPRESTUNITE.DisplayFormat.FormatType = DevExpress.Utils.FormatType.Numeric
        Me.GColVPRESTUNITE.FieldName = "VPRESTUNITE"
        Me.GColVPRESTUNITE.Name = "GColVPRESTUNITE"
        Me.GColVPRESTUNITE.OptionsColumn.AllowEdit = False
        Me.GColVPRESTUNITE.OptionsColumn.AllowFocus = False
        Me.GColVPRESTUNITE.OptionsColumn.ReadOnly = True
        Me.GColVPRESTUNITE.OptionsFilter.AutoFilterCondition = DevExpress.XtraGrid.Columns.AutoFilterCondition.Contains
        '
        'GColNQTE
        '
        resources.ApplyResources(Me.GColNQTE, "GColNQTE")
        Me.GColNQTE.DisplayFormat.FormatType = DevExpress.Utils.FormatType.Numeric
        Me.GColNQTE.FieldName = "NQTE"
        Me.GColNQTE.Name = "GColNQTE"
        Me.GColNQTE.OptionsColumn.AllowEdit = False
        Me.GColNQTE.OptionsColumn.AllowFocus = False
        Me.GColNQTE.OptionsColumn.ReadOnly = True
        Me.GColNQTE.OptionsFilter.AutoFilterCondition = DevExpress.XtraGrid.Columns.AutoFilterCondition.Contains
        '
        'GColNPRESTSERMOHT
        '
        resources.ApplyResources(Me.GColNPRESTSERMOHT, "GColNPRESTSERMOHT")
        Me.GColNPRESTSERMOHT.DisplayFormat.FormatString = "c2"
        Me.GColNPRESTSERMOHT.DisplayFormat.FormatType = DevExpress.Utils.FormatType.Numeric
        Me.GColNPRESTSERMOHT.FieldName = "NPRESTSERMOHT"
        Me.GColNPRESTSERMOHT.Name = "GColNPRESTSERMOHT"
        Me.GColNPRESTSERMOHT.OptionsColumn.AllowEdit = False
        Me.GColNPRESTSERMOHT.OptionsColumn.AllowFocus = False
        Me.GColNPRESTSERMOHT.OptionsColumn.ReadOnly = True
        Me.GColNPRESTSERMOHT.OptionsFilter.AutoFilterCondition = DevExpress.XtraGrid.Columns.AutoFilterCondition.Contains
        '
        'GColNPRESTQTEMO
        '
        resources.ApplyResources(Me.GColNPRESTQTEMO, "GColNPRESTQTEMO")
        Me.GColNPRESTQTEMO.DisplayFormat.FormatString = "n2"
        Me.GColNPRESTQTEMO.DisplayFormat.FormatType = DevExpress.Utils.FormatType.Numeric
        Me.GColNPRESTQTEMO.FieldName = "NPRESTQTEMO"
        Me.GColNPRESTQTEMO.Name = "GColNPRESTQTEMO"
        Me.GColNPRESTQTEMO.OptionsColumn.AllowEdit = False
        Me.GColNPRESTQTEMO.OptionsColumn.AllowFocus = False
        Me.GColNPRESTQTEMO.OptionsColumn.ReadOnly = True
        Me.GColNPRESTQTEMO.OptionsFilter.AutoFilterCondition = DevExpress.XtraGrid.Columns.AutoFilterCondition.Contains
        '
        'GColNTOTPRESTQTEMO
        '
        resources.ApplyResources(Me.GColNTOTPRESTQTEMO, "GColNTOTPRESTQTEMO")
        Me.GColNTOTPRESTQTEMO.DisplayFormat.FormatString = "n2"
        Me.GColNTOTPRESTQTEMO.DisplayFormat.FormatType = DevExpress.Utils.FormatType.Numeric
        Me.GColNTOTPRESTQTEMO.FieldName = "NTOTPRESTQTEMO"
        Me.GColNTOTPRESTQTEMO.Name = "GColNTOTPRESTQTEMO"
        Me.GColNTOTPRESTQTEMO.OptionsColumn.AllowEdit = False
        Me.GColNTOTPRESTQTEMO.OptionsColumn.AllowFocus = False
        Me.GColNTOTPRESTQTEMO.OptionsColumn.ReadOnly = True
        Me.GColNTOTPRESTQTEMO.OptionsFilter.AutoFilterCondition = DevExpress.XtraGrid.Columns.AutoFilterCondition.Contains
        '
        'GColNTOTPRESTSERMOHT
        '
        resources.ApplyResources(Me.GColNTOTPRESTSERMOHT, "GColNTOTPRESTSERMOHT")
        Me.GColNTOTPRESTSERMOHT.DisplayFormat.FormatString = "c2"
        Me.GColNTOTPRESTSERMOHT.DisplayFormat.FormatType = DevExpress.Utils.FormatType.Numeric
        Me.GColNTOTPRESTSERMOHT.FieldName = "NTOTPRESTSERMOHT"
        Me.GColNTOTPRESTSERMOHT.Name = "GColNTOTPRESTSERMOHT"
        Me.GColNTOTPRESTSERMOHT.OptionsColumn.AllowEdit = False
        Me.GColNTOTPRESTSERMOHT.OptionsColumn.AllowFocus = False
        Me.GColNTOTPRESTSERMOHT.OptionsColumn.ReadOnly = True
        Me.GColNTOTPRESTSERMOHT.OptionsFilter.AutoFilterCondition = DevExpress.XtraGrid.Columns.AutoFilterCondition.Contains
        '
        'GColNPRESTFOHT
        '
        resources.ApplyResources(Me.GColNPRESTFOHT, "GColNPRESTFOHT")
        Me.GColNPRESTFOHT.DisplayFormat.FormatString = "c2"
        Me.GColNPRESTFOHT.DisplayFormat.FormatType = DevExpress.Utils.FormatType.Numeric
        Me.GColNPRESTFOHT.FieldName = "NPRESTFOHT"
        Me.GColNPRESTFOHT.Name = "GColNPRESTFOHT"
        Me.GColNPRESTFOHT.OptionsColumn.AllowEdit = False
        Me.GColNPRESTFOHT.OptionsColumn.AllowFocus = False
        Me.GColNPRESTFOHT.OptionsColumn.ReadOnly = True
        Me.GColNPRESTFOHT.OptionsFilter.AutoFilterCondition = DevExpress.XtraGrid.Columns.AutoFilterCondition.Contains
        '
        'GColNTOTPRESTFOHT
        '
        resources.ApplyResources(Me.GColNTOTPRESTFOHT, "GColNTOTPRESTFOHT")
        Me.GColNTOTPRESTFOHT.DisplayFormat.FormatString = "c2"
        Me.GColNTOTPRESTFOHT.DisplayFormat.FormatType = DevExpress.Utils.FormatType.Numeric
        Me.GColNTOTPRESTFOHT.FieldName = "NTOTPRESTFOHT"
        Me.GColNTOTPRESTFOHT.Name = "GColNTOTPRESTFOHT"
        Me.GColNTOTPRESTFOHT.OptionsColumn.AllowEdit = False
        Me.GColNTOTPRESTFOHT.OptionsColumn.AllowFocus = False
        Me.GColNTOTPRESTFOHT.OptionsColumn.ReadOnly = True
        Me.GColNTOTPRESTFOHT.OptionsFilter.AutoFilterCondition = DevExpress.XtraGrid.Columns.AutoFilterCondition.Contains
        '
        'GColTOTAL
        '
        resources.ApplyResources(Me.GColTOTAL, "GColTOTAL")
        Me.GColTOTAL.DisplayFormat.FormatString = "c2"
        Me.GColTOTAL.DisplayFormat.FormatType = DevExpress.Utils.FormatType.Numeric
        Me.GColTOTAL.FieldName = "TOTAL"
        Me.GColTOTAL.Name = "GColTOTAL"
        Me.GColTOTAL.OptionsColumn.AllowEdit = False
        Me.GColTOTAL.OptionsColumn.AllowFocus = False
        Me.GColTOTAL.OptionsColumn.ReadOnly = True
        Me.GColTOTAL.OptionsFilter.AutoFilterCondition = DevExpress.XtraGrid.Columns.AutoFilterCondition.Contains
        '
        'GColCOEF
        '
        resources.ApplyResources(Me.GColCOEF, "GColCOEF")
        Me.GColCOEF.DisplayFormat.FormatString = "n2"
        Me.GColCOEF.DisplayFormat.FormatType = DevExpress.Utils.FormatType.Numeric
        Me.GColCOEF.FieldName = "COEF"
        Me.GColCOEF.Name = "GColCOEF"
        Me.GColCOEF.OptionsColumn.AllowEdit = False
        Me.GColCOEF.OptionsColumn.AllowFocus = False
        Me.GColCOEF.OptionsColumn.ReadOnly = True
        Me.GColCOEF.OptionsFilter.AutoFilterCondition = DevExpress.XtraGrid.Columns.AutoFilterCondition.Contains
        '
        'GColTOTALCOEF
        '
        resources.ApplyResources(Me.GColTOTALCOEF, "GColTOTALCOEF")
        Me.GColTOTALCOEF.DisplayFormat.FormatString = "c2"
        Me.GColTOTALCOEF.DisplayFormat.FormatType = DevExpress.Utils.FormatType.Numeric
        Me.GColTOTALCOEF.FieldName = "TOTALCOEF"
        Me.GColTOTALCOEF.Name = "GColTOTALCOEF"
        Me.GColTOTALCOEF.OptionsColumn.AllowEdit = False
        Me.GColTOTALCOEF.OptionsColumn.AllowFocus = False
        Me.GColTOTALCOEF.OptionsColumn.ReadOnly = True
        Me.GColTOTALCOEF.OptionsFilter.AutoFilterCondition = DevExpress.XtraGrid.Columns.AutoFilterCondition.Contains
        '
        'GColNPRIXCLITOT
        '
        resources.ApplyResources(Me.GColNPRIXCLITOT, "GColNPRIXCLITOT")
        Me.GColNPRIXCLITOT.DisplayFormat.FormatString = "c2"
        Me.GColNPRIXCLITOT.DisplayFormat.FormatType = DevExpress.Utils.FormatType.Numeric
        Me.GColNPRIXCLITOT.FieldName = "NPRIXCLITOT"
        Me.GColNPRIXCLITOT.Name = "GColNPRIXCLITOT"
        Me.GColNPRIXCLITOT.OptionsColumn.AllowEdit = False
        Me.GColNPRIXCLITOT.OptionsColumn.AllowFocus = False
        Me.GColNPRIXCLITOT.OptionsColumn.ReadOnly = True
        Me.GColNPRIXCLITOT.OptionsFilter.AutoFilterCondition = DevExpress.XtraGrid.Columns.AutoFilterCondition.Contains
        '
        'GColNIDFICHEFO
        '
        resources.ApplyResources(Me.GColNIDFICHEFO, "GColNIDFICHEFO")
        Me.GColNIDFICHEFO.ColumnEdit = Me.RepItemComboFicheChantierFO
        Me.GColNIDFICHEFO.FieldName = "NIDFICHEFO"
        Me.GColNIDFICHEFO.Name = "GColNIDFICHEFO"
        Me.GColNIDFICHEFO.OptionsFilter.AutoFilterCondition = DevExpress.XtraGrid.Columns.AutoFilterCondition.Contains
        '
        'RepItemComboFicheChantierFO
        '
        resources.ApplyResources(Me.RepItemComboFicheChantierFO, "RepItemComboFicheChantierFO")
        Me.RepItemComboFicheChantierFO.Buttons.AddRange(New DevExpress.XtraEditors.Controls.EditorButton() {New DevExpress.XtraEditors.Controls.EditorButton(CType(resources.GetObject("RepItemComboFicheChantierFO.Buttons"), DevExpress.XtraEditors.Controls.ButtonPredefines))})
        Me.RepItemComboFicheChantierFO.DisplayMember = "VLIB"
        Me.RepItemComboFicheChantierFO.Name = "RepItemComboFicheChantierFO"
        Me.RepItemComboFicheChantierFO.ValueMember = "NIDFICHE"
        Me.RepItemComboFicheChantierFO.View = Me.RepItemViewCboFicheChantierFO
        '
        'RepItemViewCboFicheChantierFO
        '
        resources.ApplyResources(Me.RepItemViewCboFicheChantierFO, "RepItemViewCboFicheChantierFO")
        Me.RepItemViewCboFicheChantierFO.Columns.AddRange(New DevExpress.XtraGrid.Columns.GridColumn() {Me.GVColCboNIDFICHEFO, Me.GVColCboVLIBFO})
        Me.RepItemViewCboFicheChantierFO.FocusRectStyle = DevExpress.XtraGrid.Views.Grid.DrawFocusRectStyle.RowFocus
        Me.RepItemViewCboFicheChantierFO.Name = "RepItemViewCboFicheChantierFO"
        Me.RepItemViewCboFicheChantierFO.OptionsSelection.EnableAppearanceFocusedCell = False
        Me.RepItemViewCboFicheChantierFO.OptionsView.ShowGroupPanel = False
        '
        'GVColCboNIDFICHEFO
        '
        resources.ApplyResources(Me.GVColCboNIDFICHEFO, "GVColCboNIDFICHEFO")
        Me.GVColCboNIDFICHEFO.FieldName = "NIDFICHE"
        Me.GVColCboNIDFICHEFO.Name = "GVColCboNIDFICHEFO"
        '
        'GVColCboVLIBFO
        '
        resources.ApplyResources(Me.GVColCboVLIBFO, "GVColCboVLIBFO")
        Me.GVColCboVLIBFO.FieldName = "VLIB"
        Me.GVColCboVLIBFO.Name = "GVColCboVLIBFO"
        '
        'GColNIDFICHEMO
        '
        resources.ApplyResources(Me.GColNIDFICHEMO, "GColNIDFICHEMO")
        Me.GColNIDFICHEMO.ColumnEdit = Me.RepItemComboFicheChantierMO
        Me.GColNIDFICHEMO.FieldName = "NIDFICHEMO"
        Me.GColNIDFICHEMO.Name = "GColNIDFICHEMO"
        Me.GColNIDFICHEMO.OptionsFilter.AutoFilterCondition = DevExpress.XtraGrid.Columns.AutoFilterCondition.Contains
        '
        'RepItemComboFicheChantierMO
        '
        resources.ApplyResources(Me.RepItemComboFicheChantierMO, "RepItemComboFicheChantierMO")
        Me.RepItemComboFicheChantierMO.Buttons.AddRange(New DevExpress.XtraEditors.Controls.EditorButton() {New DevExpress.XtraEditors.Controls.EditorButton(CType(resources.GetObject("RepItemComboFicheChantierMO.Buttons"), DevExpress.XtraEditors.Controls.ButtonPredefines))})
        Me.RepItemComboFicheChantierMO.DisplayMember = "VLIB"
        Me.RepItemComboFicheChantierMO.Name = "RepItemComboFicheChantierMO"
        Me.RepItemComboFicheChantierMO.ValueMember = "NIDFICHE"
        Me.RepItemComboFicheChantierMO.View = Me.RepItemViewCboFicheChantierMO
        '
        'RepItemViewCboFicheChantierMO
        '
        resources.ApplyResources(Me.RepItemViewCboFicheChantierMO, "RepItemViewCboFicheChantierMO")
        Me.RepItemViewCboFicheChantierMO.Columns.AddRange(New DevExpress.XtraGrid.Columns.GridColumn() {Me.GVColCboNIDFICHEMO, Me.GVColCboVLIBMO})
        Me.RepItemViewCboFicheChantierMO.FocusRectStyle = DevExpress.XtraGrid.Views.Grid.DrawFocusRectStyle.RowFocus
        Me.RepItemViewCboFicheChantierMO.Name = "RepItemViewCboFicheChantierMO"
        Me.RepItemViewCboFicheChantierMO.OptionsSelection.EnableAppearanceFocusedCell = False
        Me.RepItemViewCboFicheChantierMO.OptionsView.ShowGroupPanel = False
        '
        'GVColCboNIDFICHEMO
        '
        resources.ApplyResources(Me.GVColCboNIDFICHEMO, "GVColCboNIDFICHEMO")
        Me.GVColCboNIDFICHEMO.FieldName = "NIDFICHE"
        Me.GVColCboNIDFICHEMO.Name = "GVColCboNIDFICHEMO"
        '
        'GVColCboVLIBMO
        '
        resources.ApplyResources(Me.GVColCboVLIBMO, "GVColCboVLIBMO")
        Me.GVColCboVLIBMO.FieldName = "VLIB"
        Me.GVColCboVLIBMO.Name = "GVColCboVLIBMO"
        '
        'GColVLIBDECOUPMO
        '
        resources.ApplyResources(Me.GColVLIBDECOUPMO, "GColVLIBDECOUPMO")
        Me.GColVLIBDECOUPMO.FieldName = "VLIBDECOUPMO"
        Me.GColVLIBDECOUPMO.Name = "GColVLIBDECOUPMO"
        Me.GColVLIBDECOUPMO.OptionsFilter.AutoFilterCondition = DevExpress.XtraGrid.Columns.AutoFilterCondition.Contains
        '
        'GColVLIBDECOUPFO
        '
        resources.ApplyResources(Me.GColVLIBDECOUPFO, "GColVLIBDECOUPFO")
        Me.GColVLIBDECOUPFO.FieldName = "VLIBDECOUPFO"
        Me.GColVLIBDECOUPFO.Name = "GColVLIBDECOUPFO"
        Me.GColVLIBDECOUPFO.OptionsFilter.AutoFilterCondition = DevExpress.XtraGrid.Columns.AutoFilterCondition.Contains
        '
        'SFD
        '
        resources.ApplyResources(Me.SFD, "SFD")
        '
        'FrmDevPrestAffectFiche
        '
        resources.ApplyResources(Me, "$this")
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.Wheat
        Me.Controls.Add(Me.GCDevPrestAffect)
        Me.Controls.Add(Me.GrpActions)
        Me.Controls.Add(Me.LblTitre)
        Me.Name = "FrmDevPrestAffectFiche"
        Me.WindowState = System.Windows.Forms.FormWindowState.Maximized
        Me.GrpActions.ResumeLayout(False)
        CType(Me.GCDevPrestAffect, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.GVDevPrestAffect, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.RepItemComboFicheChantierFO, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.RepItemViewCboFicheChantierFO, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.RepItemComboFicheChantierMO, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.RepItemViewCboFicheChantierMO, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents GrpActions As System.Windows.Forms.GroupBox
    Friend WithEvents BtnFermer As System.Windows.Forms.Button
    Friend WithEvents BtnSave As System.Windows.Forms.Button
    Friend WithEvents LblTitre As System.Windows.Forms.Label
    Friend WithEvents BtnDecoupChantier As System.Windows.Forms.Button
    Friend WithEvents BtnExportXLS As System.Windows.Forms.Button
    Friend WithEvents SFD As System.Windows.Forms.SaveFileDialog
    Private WithEvents GCDevPrestAffect As DevExpress.XtraGrid.GridControl
    Private WithEvents GVDevPrestAffect As DevExpress.XtraGrid.Views.Grid.GridView
    Private WithEvents GColNLDCLPRESTID As DevExpress.XtraGrid.Columns.GridColumn
    Private WithEvents GColCAT As DevExpress.XtraGrid.Columns.GridColumn
    Private WithEvents GColVPRESTLIB As DevExpress.XtraGrid.Columns.GridColumn
    Private WithEvents GColVPRESTUNITE As DevExpress.XtraGrid.Columns.GridColumn
    Private WithEvents GColNQTE As DevExpress.XtraGrid.Columns.GridColumn
    Private WithEvents GColNPRESTSERMOHT As DevExpress.XtraGrid.Columns.GridColumn
    Private WithEvents GColNPRESTQTEMO As DevExpress.XtraGrid.Columns.GridColumn
    Private WithEvents GColNTOTPRESTQTEMO As DevExpress.XtraGrid.Columns.GridColumn
    Private WithEvents GColNTOTPRESTSERMOHT As DevExpress.XtraGrid.Columns.GridColumn
    Private WithEvents GColNPRESTFOHT As DevExpress.XtraGrid.Columns.GridColumn
    Private WithEvents GColNTOTPRESTFOHT As DevExpress.XtraGrid.Columns.GridColumn
    Private WithEvents GColTOTAL As DevExpress.XtraGrid.Columns.GridColumn
    Private WithEvents GColCOEF As DevExpress.XtraGrid.Columns.GridColumn
    Private WithEvents GColTOTALCOEF As DevExpress.XtraGrid.Columns.GridColumn
    Private WithEvents GColNPRIXCLITOT As DevExpress.XtraGrid.Columns.GridColumn
    Private WithEvents GColNIDFICHEFO As DevExpress.XtraGrid.Columns.GridColumn
    Private WithEvents RepItemComboFicheChantierFO As DevExpress.XtraEditors.Repository.RepositoryItemGridLookUpEdit
    Private WithEvents RepItemViewCboFicheChantierFO As DevExpress.XtraGrid.Views.Grid.GridView
    Private WithEvents GVColCboNIDFICHEFO As DevExpress.XtraGrid.Columns.GridColumn
    Private WithEvents GVColCboVLIBFO As DevExpress.XtraGrid.Columns.GridColumn
    Private WithEvents RepItemComboFicheChantierMO As DevExpress.XtraEditors.Repository.RepositoryItemGridLookUpEdit
    Private WithEvents RepItemViewCboFicheChantierMO As DevExpress.XtraGrid.Views.Grid.GridView
    Private WithEvents GVColCboNIDFICHEMO As DevExpress.XtraGrid.Columns.GridColumn
    Private WithEvents GVColCboVLIBMO As DevExpress.XtraGrid.Columns.GridColumn
    Private WithEvents GColNIDFICHEMO As DevExpress.XtraGrid.Columns.GridColumn
    Private WithEvents GColVLIBDECOUPMO As DevExpress.XtraGrid.Columns.GridColumn
    Private WithEvents GColVLIBDECOUPFO As DevExpress.XtraGrid.Columns.GridColumn
End Class
