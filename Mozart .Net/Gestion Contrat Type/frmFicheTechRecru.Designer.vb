<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmFicheTechRecru
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(frmFicheTechRecru))
        Me.GCFicheTechRecru = New DevExpress.XtraGrid.GridControl()
        Me.BGVFicheTechRecru = New DevExpress.XtraGrid.Views.BandedGrid.BandedGridView()
        Me.GBSociete = New DevExpress.XtraGrid.Views.BandedGrid.GridBand()
        Me.GBTech = New DevExpress.XtraGrid.Views.BandedGrid.GridBand()
        Me.GColVCONTDOMLIB = New DevExpress.XtraGrid.Views.BandedGrid.BandedGridColumn()
        Me.GBCont = New DevExpress.XtraGrid.Views.BandedGrid.GridBand()
        Me.GColVTYPECONTRAT = New DevExpress.XtraGrid.Views.BandedGrid.BandedGridColumn()
        Me.GBDate = New DevExpress.XtraGrid.Views.BandedGrid.GridBand()
        Me.GBCompetTitre = New DevExpress.XtraGrid.Views.BandedGrid.GridBand()
        Me.BGColPrev = New DevExpress.XtraGrid.Views.BandedGrid.BandedGridColumn()
        Me.BGColTravaux = New DevExpress.XtraGrid.Views.BandedGrid.BandedGridColumn()
        Me.BGColDepannage = New DevExpress.XtraGrid.Views.BandedGrid.BandedGridColumn()
        Me.GrpActions = New System.Windows.Forms.GroupBox()
        Me.BtnFermer = New System.Windows.Forms.Button()
        Me.BtnExportPDF = New System.Windows.Forms.Button()
        Me.SDF = New System.Windows.Forms.SaveFileDialog()
        CType(Me.GCFicheTechRecru, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.BGVFicheTechRecru, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.GrpActions.SuspendLayout()
        Me.SuspendLayout()
        '
        'GCFicheTechRecru
        '
        resources.ApplyResources(Me.GCFicheTechRecru, "GCFicheTechRecru")
        '
        '
        '
        Me.GCFicheTechRecru.EmbeddedNavigator.AccessibleDescription = resources.GetString("GCFicheTechRecru.EmbeddedNavigator.AccessibleDescription")
        Me.GCFicheTechRecru.EmbeddedNavigator.AccessibleName = resources.GetString("GCFicheTechRecru.EmbeddedNavigator.AccessibleName")
        Me.GCFicheTechRecru.EmbeddedNavigator.AllowHtmlTextInToolTip = CType(resources.GetObject("GCFicheTechRecru.EmbeddedNavigator.AllowHtmlTextInToolTip"), DevExpress.Utils.DefaultBoolean)
        Me.GCFicheTechRecru.EmbeddedNavigator.Anchor = CType(resources.GetObject("GCFicheTechRecru.EmbeddedNavigator.Anchor"), System.Windows.Forms.AnchorStyles)
        Me.GCFicheTechRecru.EmbeddedNavigator.BackgroundImage = CType(resources.GetObject("GCFicheTechRecru.EmbeddedNavigator.BackgroundImage"), System.Drawing.Image)
        Me.GCFicheTechRecru.EmbeddedNavigator.BackgroundImageLayout = CType(resources.GetObject("GCFicheTechRecru.EmbeddedNavigator.BackgroundImageLayout"), System.Windows.Forms.ImageLayout)
        Me.GCFicheTechRecru.EmbeddedNavigator.ImeMode = CType(resources.GetObject("GCFicheTechRecru.EmbeddedNavigator.ImeMode"), System.Windows.Forms.ImeMode)
        Me.GCFicheTechRecru.EmbeddedNavigator.MaximumSize = CType(resources.GetObject("GCFicheTechRecru.EmbeddedNavigator.MaximumSize"), System.Drawing.Size)
        Me.GCFicheTechRecru.EmbeddedNavigator.TextLocation = CType(resources.GetObject("GCFicheTechRecru.EmbeddedNavigator.TextLocation"), DevExpress.XtraEditors.NavigatorButtonsTextLocation)
        Me.GCFicheTechRecru.EmbeddedNavigator.ToolTip = resources.GetString("GCFicheTechRecru.EmbeddedNavigator.ToolTip")
        Me.GCFicheTechRecru.EmbeddedNavigator.ToolTipIconType = CType(resources.GetObject("GCFicheTechRecru.EmbeddedNavigator.ToolTipIconType"), DevExpress.Utils.ToolTipIconType)
        Me.GCFicheTechRecru.EmbeddedNavigator.ToolTipTitle = resources.GetString("GCFicheTechRecru.EmbeddedNavigator.ToolTipTitle")
        Me.GCFicheTechRecru.MainView = Me.BGVFicheTechRecru
        Me.GCFicheTechRecru.Name = "GCFicheTechRecru"
        Me.GCFicheTechRecru.ViewCollection.AddRange(New DevExpress.XtraGrid.Views.Base.BaseView() {Me.BGVFicheTechRecru})
        '
        'BGVFicheTechRecru
        '
        Me.BGVFicheTechRecru.AppearancePrint.BandPanel.BackColor = CType(resources.GetObject("BGVFicheTechRecru.AppearancePrint.BandPanel.BackColor"), System.Drawing.Color)
        Me.BGVFicheTechRecru.AppearancePrint.BandPanel.FontSizeDelta = CType(resources.GetObject("BGVFicheTechRecru.AppearancePrint.BandPanel.FontSizeDelta"), Integer)
        Me.BGVFicheTechRecru.AppearancePrint.BandPanel.FontStyleDelta = CType(resources.GetObject("BGVFicheTechRecru.AppearancePrint.BandPanel.FontStyleDelta"), System.Drawing.FontStyle)
        Me.BGVFicheTechRecru.AppearancePrint.BandPanel.GradientMode = CType(resources.GetObject("BGVFicheTechRecru.AppearancePrint.BandPanel.GradientMode"), System.Drawing.Drawing2D.LinearGradientMode)
        Me.BGVFicheTechRecru.AppearancePrint.BandPanel.Image = CType(resources.GetObject("BGVFicheTechRecru.AppearancePrint.BandPanel.Image"), System.Drawing.Image)
        Me.BGVFicheTechRecru.AppearancePrint.BandPanel.Options.UseBackColor = True
        Me.BGVFicheTechRecru.AppearancePrint.HeaderPanel.BackColor = CType(resources.GetObject("BGVFicheTechRecru.AppearancePrint.HeaderPanel.BackColor"), System.Drawing.Color)
        Me.BGVFicheTechRecru.AppearancePrint.HeaderPanel.FontSizeDelta = CType(resources.GetObject("BGVFicheTechRecru.AppearancePrint.HeaderPanel.FontSizeDelta"), Integer)
        Me.BGVFicheTechRecru.AppearancePrint.HeaderPanel.FontStyleDelta = CType(resources.GetObject("BGVFicheTechRecru.AppearancePrint.HeaderPanel.FontStyleDelta"), System.Drawing.FontStyle)
        Me.BGVFicheTechRecru.AppearancePrint.HeaderPanel.GradientMode = CType(resources.GetObject("BGVFicheTechRecru.AppearancePrint.HeaderPanel.GradientMode"), System.Drawing.Drawing2D.LinearGradientMode)
        Me.BGVFicheTechRecru.AppearancePrint.HeaderPanel.Image = CType(resources.GetObject("BGVFicheTechRecru.AppearancePrint.HeaderPanel.Image"), System.Drawing.Image)
        Me.BGVFicheTechRecru.AppearancePrint.HeaderPanel.Options.UseBackColor = True
        Me.BGVFicheTechRecru.Bands.AddRange(New DevExpress.XtraGrid.Views.BandedGrid.GridBand() {Me.GBSociete, Me.GBCont, Me.GBDate})
        resources.ApplyResources(Me.BGVFicheTechRecru, "BGVFicheTechRecru")
        Me.BGVFicheTechRecru.Columns.AddRange(New DevExpress.XtraGrid.Views.BandedGrid.BandedGridColumn() {Me.GColVCONTDOMLIB, Me.GColVTYPECONTRAT, Me.BGColPrev, Me.BGColDepannage, Me.BGColTravaux})
        Me.BGVFicheTechRecru.GridControl = Me.GCFicheTechRecru
        Me.BGVFicheTechRecru.Name = "BGVFicheTechRecru"
        Me.BGVFicheTechRecru.OptionsBehavior.Editable = False
        Me.BGVFicheTechRecru.OptionsBehavior.ReadOnly = True
        Me.BGVFicheTechRecru.OptionsCustomization.AllowBandMoving = False
        Me.BGVFicheTechRecru.OptionsCustomization.AllowBandResizing = False
        Me.BGVFicheTechRecru.OptionsCustomization.AllowColumnMoving = False
        Me.BGVFicheTechRecru.OptionsCustomization.AllowColumnResizing = False
        Me.BGVFicheTechRecru.OptionsCustomization.AllowFilter = False
        Me.BGVFicheTechRecru.OptionsCustomization.AllowGroup = False
        Me.BGVFicheTechRecru.OptionsCustomization.AllowQuickHideColumns = False
        Me.BGVFicheTechRecru.OptionsCustomization.AllowSort = False
        Me.BGVFicheTechRecru.OptionsCustomization.ShowBandsInCustomizationForm = False
        Me.BGVFicheTechRecru.OptionsPrint.ExpandAllGroups = False
        Me.BGVFicheTechRecru.OptionsPrint.PrintFooter = False
        Me.BGVFicheTechRecru.OptionsPrint.PrintGroupFooter = False
        Me.BGVFicheTechRecru.OptionsView.ShowGroupPanel = False
        '
        'GBSociete
        '
        Me.GBSociete.AppearanceHeader.BackColor = CType(resources.GetObject("GBSociete.AppearanceHeader.BackColor"), System.Drawing.Color)
        Me.GBSociete.AppearanceHeader.Font = CType(resources.GetObject("GBSociete.AppearanceHeader.Font"), System.Drawing.Font)
        Me.GBSociete.AppearanceHeader.FontSizeDelta = CType(resources.GetObject("GBSociete.AppearanceHeader.FontSizeDelta"), Integer)
        Me.GBSociete.AppearanceHeader.FontStyleDelta = CType(resources.GetObject("GBSociete.AppearanceHeader.FontStyleDelta"), System.Drawing.FontStyle)
        Me.GBSociete.AppearanceHeader.GradientMode = CType(resources.GetObject("GBSociete.AppearanceHeader.GradientMode"), System.Drawing.Drawing2D.LinearGradientMode)
        Me.GBSociete.AppearanceHeader.Image = CType(resources.GetObject("GBSociete.AppearanceHeader.Image"), System.Drawing.Image)
        Me.GBSociete.AppearanceHeader.Options.UseBackColor = True
        Me.GBSociete.AppearanceHeader.Options.UseFont = True
        Me.GBSociete.AppearanceHeader.Options.UseTextOptions = True
        Me.GBSociete.AppearanceHeader.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center
        Me.GBSociete.AppearanceHeader.TextOptions.VAlignment = DevExpress.Utils.VertAlignment.Center
        resources.ApplyResources(Me.GBSociete, "GBSociete")
        Me.GBSociete.Children.AddRange(New DevExpress.XtraGrid.Views.BandedGrid.GridBand() {Me.GBTech})
        Me.GBSociete.VisibleIndex = 0
        '
        'GBTech
        '
        Me.GBTech.AppearanceHeader.BackColor = CType(resources.GetObject("GBTech.AppearanceHeader.BackColor"), System.Drawing.Color)
        Me.GBTech.AppearanceHeader.Font = CType(resources.GetObject("GBTech.AppearanceHeader.Font"), System.Drawing.Font)
        Me.GBTech.AppearanceHeader.FontSizeDelta = CType(resources.GetObject("GBTech.AppearanceHeader.FontSizeDelta"), Integer)
        Me.GBTech.AppearanceHeader.FontStyleDelta = CType(resources.GetObject("GBTech.AppearanceHeader.FontStyleDelta"), System.Drawing.FontStyle)
        Me.GBTech.AppearanceHeader.GradientMode = CType(resources.GetObject("GBTech.AppearanceHeader.GradientMode"), System.Drawing.Drawing2D.LinearGradientMode)
        Me.GBTech.AppearanceHeader.Image = CType(resources.GetObject("GBTech.AppearanceHeader.Image"), System.Drawing.Image)
        Me.GBTech.AppearanceHeader.Options.UseBackColor = True
        Me.GBTech.AppearanceHeader.Options.UseFont = True
        Me.GBTech.AppearanceHeader.Options.UseTextOptions = True
        Me.GBTech.AppearanceHeader.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Far
        Me.GBTech.AppearanceHeader.TextOptions.VAlignment = DevExpress.Utils.VertAlignment.Center
        resources.ApplyResources(Me.GBTech, "GBTech")
        Me.GBTech.Columns.Add(Me.GColVCONTDOMLIB)
        Me.GBTech.VisibleIndex = 0
        '
        'GColVCONTDOMLIB
        '
        Me.GColVCONTDOMLIB.AppearanceCell.Font = CType(resources.GetObject("GColVCONTDOMLIB.AppearanceCell.Font"), System.Drawing.Font)
        Me.GColVCONTDOMLIB.AppearanceCell.FontSizeDelta = CType(resources.GetObject("GColVCONTDOMLIB.AppearanceCell.FontSizeDelta"), Integer)
        Me.GColVCONTDOMLIB.AppearanceCell.FontStyleDelta = CType(resources.GetObject("GColVCONTDOMLIB.AppearanceCell.FontStyleDelta"), System.Drawing.FontStyle)
        Me.GColVCONTDOMLIB.AppearanceCell.GradientMode = CType(resources.GetObject("GColVCONTDOMLIB.AppearanceCell.GradientMode"), System.Drawing.Drawing2D.LinearGradientMode)
        Me.GColVCONTDOMLIB.AppearanceCell.Image = CType(resources.GetObject("GColVCONTDOMLIB.AppearanceCell.Image"), System.Drawing.Image)
        Me.GColVCONTDOMLIB.AppearanceCell.Options.UseFont = True
        Me.GColVCONTDOMLIB.AppearanceCell.Options.UseTextOptions = True
        Me.GColVCONTDOMLIB.AppearanceCell.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center
        Me.GColVCONTDOMLIB.AppearanceCell.TextOptions.VAlignment = DevExpress.Utils.VertAlignment.Center
        Me.GColVCONTDOMLIB.AppearanceCell.TextOptions.WordWrap = DevExpress.Utils.WordWrap.NoWrap
        Me.GColVCONTDOMLIB.AppearanceHeader.BackColor = CType(resources.GetObject("GColVCONTDOMLIB.AppearanceHeader.BackColor"), System.Drawing.Color)
        Me.GColVCONTDOMLIB.AppearanceHeader.Font = CType(resources.GetObject("GColVCONTDOMLIB.AppearanceHeader.Font"), System.Drawing.Font)
        Me.GColVCONTDOMLIB.AppearanceHeader.FontSizeDelta = CType(resources.GetObject("GColVCONTDOMLIB.AppearanceHeader.FontSizeDelta"), Integer)
        Me.GColVCONTDOMLIB.AppearanceHeader.FontStyleDelta = CType(resources.GetObject("GColVCONTDOMLIB.AppearanceHeader.FontStyleDelta"), System.Drawing.FontStyle)
        Me.GColVCONTDOMLIB.AppearanceHeader.GradientMode = CType(resources.GetObject("GColVCONTDOMLIB.AppearanceHeader.GradientMode"), System.Drawing.Drawing2D.LinearGradientMode)
        Me.GColVCONTDOMLIB.AppearanceHeader.Image = CType(resources.GetObject("GColVCONTDOMLIB.AppearanceHeader.Image"), System.Drawing.Image)
        Me.GColVCONTDOMLIB.AppearanceHeader.Options.UseBackColor = True
        Me.GColVCONTDOMLIB.AppearanceHeader.Options.UseFont = True
        Me.GColVCONTDOMLIB.AppearanceHeader.Options.UseTextOptions = True
        Me.GColVCONTDOMLIB.AppearanceHeader.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center
        Me.GColVCONTDOMLIB.AppearanceHeader.TextOptions.VAlignment = DevExpress.Utils.VertAlignment.Center
        Me.GColVCONTDOMLIB.AutoFillDown = True
        resources.ApplyResources(Me.GColVCONTDOMLIB, "GColVCONTDOMLIB")
        Me.GColVCONTDOMLIB.FieldName = "VCONTDOMLIB"
        Me.GColVCONTDOMLIB.Name = "GColVCONTDOMLIB"
        '
        'GBCont
        '
        Me.GBCont.AppearanceHeader.BackColor = CType(resources.GetObject("GBCont.AppearanceHeader.BackColor"), System.Drawing.Color)
        Me.GBCont.AppearanceHeader.FontSizeDelta = CType(resources.GetObject("GBCont.AppearanceHeader.FontSizeDelta"), Integer)
        Me.GBCont.AppearanceHeader.FontStyleDelta = CType(resources.GetObject("GBCont.AppearanceHeader.FontStyleDelta"), System.Drawing.FontStyle)
        Me.GBCont.AppearanceHeader.GradientMode = CType(resources.GetObject("GBCont.AppearanceHeader.GradientMode"), System.Drawing.Drawing2D.LinearGradientMode)
        Me.GBCont.AppearanceHeader.Image = CType(resources.GetObject("GBCont.AppearanceHeader.Image"), System.Drawing.Image)
        Me.GBCont.AppearanceHeader.Options.UseBackColor = True
        resources.ApplyResources(Me.GBCont, "GBCont")
        Me.GBCont.Columns.Add(Me.GColVTYPECONTRAT)
        Me.GBCont.OptionsBand.ShowCaption = False
        Me.GBCont.VisibleIndex = 1
        '
        'GColVTYPECONTRAT
        '
        Me.GColVTYPECONTRAT.AppearanceCell.Font = CType(resources.GetObject("GColVTYPECONTRAT.AppearanceCell.Font"), System.Drawing.Font)
        Me.GColVTYPECONTRAT.AppearanceCell.FontSizeDelta = CType(resources.GetObject("GColVTYPECONTRAT.AppearanceCell.FontSizeDelta"), Integer)
        Me.GColVTYPECONTRAT.AppearanceCell.FontStyleDelta = CType(resources.GetObject("GColVTYPECONTRAT.AppearanceCell.FontStyleDelta"), System.Drawing.FontStyle)
        Me.GColVTYPECONTRAT.AppearanceCell.GradientMode = CType(resources.GetObject("GColVTYPECONTRAT.AppearanceCell.GradientMode"), System.Drawing.Drawing2D.LinearGradientMode)
        Me.GColVTYPECONTRAT.AppearanceCell.Image = CType(resources.GetObject("GColVTYPECONTRAT.AppearanceCell.Image"), System.Drawing.Image)
        Me.GColVTYPECONTRAT.AppearanceCell.Options.UseFont = True
        Me.GColVTYPECONTRAT.AppearanceCell.Options.UseTextOptions = True
        Me.GColVTYPECONTRAT.AppearanceCell.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Near
        Me.GColVTYPECONTRAT.AppearanceCell.TextOptions.VAlignment = DevExpress.Utils.VertAlignment.Center
        Me.GColVTYPECONTRAT.AppearanceCell.TextOptions.WordWrap = DevExpress.Utils.WordWrap.Wrap
        Me.GColVTYPECONTRAT.AppearanceHeader.BackColor = CType(resources.GetObject("GColVTYPECONTRAT.AppearanceHeader.BackColor"), System.Drawing.Color)
        Me.GColVTYPECONTRAT.AppearanceHeader.Font = CType(resources.GetObject("GColVTYPECONTRAT.AppearanceHeader.Font"), System.Drawing.Font)
        Me.GColVTYPECONTRAT.AppearanceHeader.FontSizeDelta = CType(resources.GetObject("GColVTYPECONTRAT.AppearanceHeader.FontSizeDelta"), Integer)
        Me.GColVTYPECONTRAT.AppearanceHeader.FontStyleDelta = CType(resources.GetObject("GColVTYPECONTRAT.AppearanceHeader.FontStyleDelta"), System.Drawing.FontStyle)
        Me.GColVTYPECONTRAT.AppearanceHeader.GradientMode = CType(resources.GetObject("GColVTYPECONTRAT.AppearanceHeader.GradientMode"), System.Drawing.Drawing2D.LinearGradientMode)
        Me.GColVTYPECONTRAT.AppearanceHeader.Image = CType(resources.GetObject("GColVTYPECONTRAT.AppearanceHeader.Image"), System.Drawing.Image)
        Me.GColVTYPECONTRAT.AppearanceHeader.Options.UseBackColor = True
        Me.GColVTYPECONTRAT.AppearanceHeader.Options.UseFont = True
        Me.GColVTYPECONTRAT.AppearanceHeader.Options.UseTextOptions = True
        Me.GColVTYPECONTRAT.AppearanceHeader.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center
        Me.GColVTYPECONTRAT.AppearanceHeader.TextOptions.VAlignment = DevExpress.Utils.VertAlignment.Center
        Me.GColVTYPECONTRAT.AutoFillDown = True
        resources.ApplyResources(Me.GColVTYPECONTRAT, "GColVTYPECONTRAT")
        Me.GColVTYPECONTRAT.FieldName = "VTYPECONTRAT"
        Me.GColVTYPECONTRAT.Name = "GColVTYPECONTRAT"
        '
        'GBDate
        '
        Me.GBDate.AppearanceHeader.BackColor = CType(resources.GetObject("GBDate.AppearanceHeader.BackColor"), System.Drawing.Color)
        Me.GBDate.AppearanceHeader.Font = CType(resources.GetObject("GBDate.AppearanceHeader.Font"), System.Drawing.Font)
        Me.GBDate.AppearanceHeader.FontSizeDelta = CType(resources.GetObject("GBDate.AppearanceHeader.FontSizeDelta"), Integer)
        Me.GBDate.AppearanceHeader.FontStyleDelta = CType(resources.GetObject("GBDate.AppearanceHeader.FontStyleDelta"), System.Drawing.FontStyle)
        Me.GBDate.AppearanceHeader.GradientMode = CType(resources.GetObject("GBDate.AppearanceHeader.GradientMode"), System.Drawing.Drawing2D.LinearGradientMode)
        Me.GBDate.AppearanceHeader.Image = CType(resources.GetObject("GBDate.AppearanceHeader.Image"), System.Drawing.Image)
        Me.GBDate.AppearanceHeader.Options.UseBackColor = True
        Me.GBDate.AppearanceHeader.Options.UseFont = True
        Me.GBDate.AppearanceHeader.Options.UseTextOptions = True
        Me.GBDate.AppearanceHeader.TextOptions.VAlignment = DevExpress.Utils.VertAlignment.Center
        resources.ApplyResources(Me.GBDate, "GBDate")
        Me.GBDate.Children.AddRange(New DevExpress.XtraGrid.Views.BandedGrid.GridBand() {Me.GBCompetTitre})
        Me.GBDate.VisibleIndex = 2
        '
        'GBCompetTitre
        '
        Me.GBCompetTitre.AppearanceHeader.BackColor = CType(resources.GetObject("GBCompetTitre.AppearanceHeader.BackColor"), System.Drawing.Color)
        Me.GBCompetTitre.AppearanceHeader.Font = CType(resources.GetObject("GBCompetTitre.AppearanceHeader.Font"), System.Drawing.Font)
        Me.GBCompetTitre.AppearanceHeader.FontSizeDelta = CType(resources.GetObject("GBCompetTitre.AppearanceHeader.FontSizeDelta"), Integer)
        Me.GBCompetTitre.AppearanceHeader.FontStyleDelta = CType(resources.GetObject("GBCompetTitre.AppearanceHeader.FontStyleDelta"), System.Drawing.FontStyle)
        Me.GBCompetTitre.AppearanceHeader.GradientMode = CType(resources.GetObject("GBCompetTitre.AppearanceHeader.GradientMode"), System.Drawing.Drawing2D.LinearGradientMode)
        Me.GBCompetTitre.AppearanceHeader.Image = CType(resources.GetObject("GBCompetTitre.AppearanceHeader.Image"), System.Drawing.Image)
        Me.GBCompetTitre.AppearanceHeader.Options.UseBackColor = True
        Me.GBCompetTitre.AppearanceHeader.Options.UseFont = True
        Me.GBCompetTitre.AppearanceHeader.Options.UseTextOptions = True
        Me.GBCompetTitre.AppearanceHeader.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center
        Me.GBCompetTitre.AppearanceHeader.TextOptions.VAlignment = DevExpress.Utils.VertAlignment.Center
        resources.ApplyResources(Me.GBCompetTitre, "GBCompetTitre")
        Me.GBCompetTitre.Columns.Add(Me.BGColPrev)
        Me.GBCompetTitre.Columns.Add(Me.BGColTravaux)
        Me.GBCompetTitre.Columns.Add(Me.BGColDepannage)
        Me.GBCompetTitre.VisibleIndex = 0
        '
        'BGColPrev
        '
        Me.BGColPrev.AppearanceCell.Font = CType(resources.GetObject("BGColPrev.AppearanceCell.Font"), System.Drawing.Font)
        Me.BGColPrev.AppearanceCell.FontSizeDelta = CType(resources.GetObject("BGColPrev.AppearanceCell.FontSizeDelta"), Integer)
        Me.BGColPrev.AppearanceCell.FontStyleDelta = CType(resources.GetObject("BGColPrev.AppearanceCell.FontStyleDelta"), System.Drawing.FontStyle)
        Me.BGColPrev.AppearanceCell.GradientMode = CType(resources.GetObject("BGColPrev.AppearanceCell.GradientMode"), System.Drawing.Drawing2D.LinearGradientMode)
        Me.BGColPrev.AppearanceCell.Image = CType(resources.GetObject("BGColPrev.AppearanceCell.Image"), System.Drawing.Image)
        Me.BGColPrev.AppearanceCell.Options.UseFont = True
        Me.BGColPrev.AppearanceCell.Options.UseTextOptions = True
        Me.BGColPrev.AppearanceCell.TextOptions.WordWrap = DevExpress.Utils.WordWrap.NoWrap
        Me.BGColPrev.AppearanceHeader.BackColor = CType(resources.GetObject("BGColPrev.AppearanceHeader.BackColor"), System.Drawing.Color)
        Me.BGColPrev.AppearanceHeader.Font = CType(resources.GetObject("BGColPrev.AppearanceHeader.Font"), System.Drawing.Font)
        Me.BGColPrev.AppearanceHeader.FontSizeDelta = CType(resources.GetObject("BGColPrev.AppearanceHeader.FontSizeDelta"), Integer)
        Me.BGColPrev.AppearanceHeader.FontStyleDelta = CType(resources.GetObject("BGColPrev.AppearanceHeader.FontStyleDelta"), System.Drawing.FontStyle)
        Me.BGColPrev.AppearanceHeader.GradientMode = CType(resources.GetObject("BGColPrev.AppearanceHeader.GradientMode"), System.Drawing.Drawing2D.LinearGradientMode)
        Me.BGColPrev.AppearanceHeader.Image = CType(resources.GetObject("BGColPrev.AppearanceHeader.Image"), System.Drawing.Image)
        Me.BGColPrev.AppearanceHeader.Options.UseBackColor = True
        Me.BGColPrev.AppearanceHeader.Options.UseFont = True
        Me.BGColPrev.AppearanceHeader.Options.UseTextOptions = True
        Me.BGColPrev.AppearanceHeader.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center
        Me.BGColPrev.AppearanceHeader.TextOptions.VAlignment = DevExpress.Utils.VertAlignment.Center
        Me.BGColPrev.AutoFillDown = True
        resources.ApplyResources(Me.BGColPrev, "BGColPrev")
        Me.BGColPrev.FieldName = "PREV"
        Me.BGColPrev.Name = "BGColPrev"
        Me.BGColPrev.OptionsColumn.AllowEdit = False
        Me.BGColPrev.OptionsColumn.AllowGroup = DevExpress.Utils.DefaultBoolean.[False]
        Me.BGColPrev.OptionsColumn.AllowMerge = DevExpress.Utils.DefaultBoolean.[False]
        '
        'BGColTravaux
        '
        Me.BGColTravaux.AppearanceCell.Font = CType(resources.GetObject("BGColTravaux.AppearanceCell.Font"), System.Drawing.Font)
        Me.BGColTravaux.AppearanceCell.FontSizeDelta = CType(resources.GetObject("BGColTravaux.AppearanceCell.FontSizeDelta"), Integer)
        Me.BGColTravaux.AppearanceCell.FontStyleDelta = CType(resources.GetObject("BGColTravaux.AppearanceCell.FontStyleDelta"), System.Drawing.FontStyle)
        Me.BGColTravaux.AppearanceCell.GradientMode = CType(resources.GetObject("BGColTravaux.AppearanceCell.GradientMode"), System.Drawing.Drawing2D.LinearGradientMode)
        Me.BGColTravaux.AppearanceCell.Image = CType(resources.GetObject("BGColTravaux.AppearanceCell.Image"), System.Drawing.Image)
        Me.BGColTravaux.AppearanceCell.Options.UseFont = True
        Me.BGColTravaux.AppearanceCell.Options.UseTextOptions = True
        Me.BGColTravaux.AppearanceCell.TextOptions.WordWrap = DevExpress.Utils.WordWrap.NoWrap
        Me.BGColTravaux.AppearanceHeader.BackColor = CType(resources.GetObject("BGColTravaux.AppearanceHeader.BackColor"), System.Drawing.Color)
        Me.BGColTravaux.AppearanceHeader.Font = CType(resources.GetObject("BGColTravaux.AppearanceHeader.Font"), System.Drawing.Font)
        Me.BGColTravaux.AppearanceHeader.FontSizeDelta = CType(resources.GetObject("BGColTravaux.AppearanceHeader.FontSizeDelta"), Integer)
        Me.BGColTravaux.AppearanceHeader.FontStyleDelta = CType(resources.GetObject("BGColTravaux.AppearanceHeader.FontStyleDelta"), System.Drawing.FontStyle)
        Me.BGColTravaux.AppearanceHeader.GradientMode = CType(resources.GetObject("BGColTravaux.AppearanceHeader.GradientMode"), System.Drawing.Drawing2D.LinearGradientMode)
        Me.BGColTravaux.AppearanceHeader.Image = CType(resources.GetObject("BGColTravaux.AppearanceHeader.Image"), System.Drawing.Image)
        Me.BGColTravaux.AppearanceHeader.Options.UseBackColor = True
        Me.BGColTravaux.AppearanceHeader.Options.UseFont = True
        Me.BGColTravaux.AppearanceHeader.Options.UseTextOptions = True
        Me.BGColTravaux.AppearanceHeader.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center
        Me.BGColTravaux.AppearanceHeader.TextOptions.VAlignment = DevExpress.Utils.VertAlignment.Center
        Me.BGColTravaux.AutoFillDown = True
        resources.ApplyResources(Me.BGColTravaux, "BGColTravaux")
        Me.BGColTravaux.FieldName = "TRAV"
        Me.BGColTravaux.Name = "BGColTravaux"
        Me.BGColTravaux.OptionsColumn.AllowEdit = False
        Me.BGColTravaux.OptionsColumn.AllowGroup = DevExpress.Utils.DefaultBoolean.[False]
        Me.BGColTravaux.OptionsColumn.AllowMerge = DevExpress.Utils.DefaultBoolean.[False]
        '
        'BGColDepannage
        '
        Me.BGColDepannage.AppearanceCell.Font = CType(resources.GetObject("BGColDepannage.AppearanceCell.Font"), System.Drawing.Font)
        Me.BGColDepannage.AppearanceCell.FontSizeDelta = CType(resources.GetObject("BGColDepannage.AppearanceCell.FontSizeDelta"), Integer)
        Me.BGColDepannage.AppearanceCell.FontStyleDelta = CType(resources.GetObject("BGColDepannage.AppearanceCell.FontStyleDelta"), System.Drawing.FontStyle)
        Me.BGColDepannage.AppearanceCell.GradientMode = CType(resources.GetObject("BGColDepannage.AppearanceCell.GradientMode"), System.Drawing.Drawing2D.LinearGradientMode)
        Me.BGColDepannage.AppearanceCell.Image = CType(resources.GetObject("BGColDepannage.AppearanceCell.Image"), System.Drawing.Image)
        Me.BGColDepannage.AppearanceCell.Options.UseFont = True
        Me.BGColDepannage.AppearanceCell.Options.UseTextOptions = True
        Me.BGColDepannage.AppearanceCell.TextOptions.WordWrap = DevExpress.Utils.WordWrap.NoWrap
        Me.BGColDepannage.AppearanceHeader.BackColor = CType(resources.GetObject("BGColDepannage.AppearanceHeader.BackColor"), System.Drawing.Color)
        Me.BGColDepannage.AppearanceHeader.Font = CType(resources.GetObject("BGColDepannage.AppearanceHeader.Font"), System.Drawing.Font)
        Me.BGColDepannage.AppearanceHeader.FontSizeDelta = CType(resources.GetObject("BGColDepannage.AppearanceHeader.FontSizeDelta"), Integer)
        Me.BGColDepannage.AppearanceHeader.FontStyleDelta = CType(resources.GetObject("BGColDepannage.AppearanceHeader.FontStyleDelta"), System.Drawing.FontStyle)
        Me.BGColDepannage.AppearanceHeader.GradientMode = CType(resources.GetObject("BGColDepannage.AppearanceHeader.GradientMode"), System.Drawing.Drawing2D.LinearGradientMode)
        Me.BGColDepannage.AppearanceHeader.Image = CType(resources.GetObject("BGColDepannage.AppearanceHeader.Image"), System.Drawing.Image)
        Me.BGColDepannage.AppearanceHeader.Options.UseBackColor = True
        Me.BGColDepannage.AppearanceHeader.Options.UseFont = True
        Me.BGColDepannage.AppearanceHeader.Options.UseTextOptions = True
        Me.BGColDepannage.AppearanceHeader.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center
        Me.BGColDepannage.AppearanceHeader.TextOptions.VAlignment = DevExpress.Utils.VertAlignment.Center
        Me.BGColDepannage.AutoFillDown = True
        resources.ApplyResources(Me.BGColDepannage, "BGColDepannage")
        Me.BGColDepannage.FieldName = "DEPAN"
        Me.BGColDepannage.Name = "BGColDepannage"
        Me.BGColDepannage.OptionsColumn.AllowEdit = False
        Me.BGColDepannage.OptionsColumn.AllowGroup = DevExpress.Utils.DefaultBoolean.[False]
        Me.BGColDepannage.OptionsColumn.AllowMerge = DevExpress.Utils.DefaultBoolean.[False]
        '
        'GrpActions
        '
        resources.ApplyResources(Me.GrpActions, "GrpActions")
        Me.GrpActions.Controls.Add(Me.BtnFermer)
        Me.GrpActions.Controls.Add(Me.BtnExportPDF)
        Me.GrpActions.Name = "GrpActions"
        Me.GrpActions.TabStop = False
        '
        'BtnFermer
        '
        resources.ApplyResources(Me.BtnFermer, "BtnFermer")
        Me.BtnFermer.Name = "BtnFermer"
        Me.BtnFermer.UseVisualStyleBackColor = True
        '
        'BtnExportPDF
        '
        resources.ApplyResources(Me.BtnExportPDF, "BtnExportPDF")
        Me.BtnExportPDF.BackgroundImage = Global.MozartNet.My.Resources.Resources.PDF
        Me.BtnExportPDF.Name = "BtnExportPDF"
        Me.BtnExportPDF.UseVisualStyleBackColor = True
        '
        'SDF
        '
        resources.ApplyResources(Me.SDF, "SDF")
        '
        'frmFicheTechRecru
        '
        resources.ApplyResources(Me, "$this")
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.Wheat
        Me.Controls.Add(Me.GrpActions)
        Me.Controls.Add(Me.GCFicheTechRecru)
        Me.Name = "frmFicheTechRecru"
        CType(Me.GCFicheTechRecru, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.BGVFicheTechRecru, System.ComponentModel.ISupportInitialize).EndInit()
        Me.GrpActions.ResumeLayout(False)
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents GrpActions As System.Windows.Forms.GroupBox
    Friend WithEvents BtnFermer As System.Windows.Forms.Button
    Friend WithEvents BtnExportPDF As System.Windows.Forms.Button
    Friend WithEvents SDF As System.Windows.Forms.SaveFileDialog
    Private WithEvents GCFicheTechRecru As DevExpress.XtraGrid.GridControl
    Private WithEvents BGVFicheTechRecru As DevExpress.XtraGrid.Views.BandedGrid.BandedGridView
    Private WithEvents GColVCONTDOMLIB As DevExpress.XtraGrid.Views.BandedGrid.BandedGridColumn
    Private WithEvents GColVTYPECONTRAT As DevExpress.XtraGrid.Views.BandedGrid.BandedGridColumn
    Private WithEvents BGColPrev As DevExpress.XtraGrid.Views.BandedGrid.BandedGridColumn
    Private WithEvents BGColTravaux As DevExpress.XtraGrid.Views.BandedGrid.BandedGridColumn
    Private WithEvents BGColDepannage As DevExpress.XtraGrid.Views.BandedGrid.BandedGridColumn
    Private WithEvents GBSociete As DevExpress.XtraGrid.Views.BandedGrid.GridBand
    Private WithEvents GBTech As DevExpress.XtraGrid.Views.BandedGrid.GridBand
    Private WithEvents GBCont As DevExpress.XtraGrid.Views.BandedGrid.GridBand
    Private WithEvents GBDate As DevExpress.XtraGrid.Views.BandedGrid.GridBand
    Private WithEvents GBCompetTitre As DevExpress.XtraGrid.Views.BandedGrid.GridBand
End Class
