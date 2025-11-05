<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class FrmFournituresConsultMag
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(FrmFournituresConsultMag))
        Me.LblTitre = New System.Windows.Forms.Label()
        Me.BtnSendMail = New System.Windows.Forms.Button()
        Me.BtnClose = New System.Windows.Forms.Button()
        Me.CboSerie = New System.Windows.Forms.ComboBox()
        Me.GCExportConsultMag = New DevExpress.XtraGrid.GridControl()
        Me.ABGVExportConsultMag = New DevExpress.XtraGrid.Views.BandedGrid.AdvBandedGridView()
        Me.GBLine1 = New DevExpress.XtraGrid.Views.BandedGrid.GridBand()
        Me.GBLine2 = New DevExpress.XtraGrid.Views.BandedGrid.GridBand()
        Me.GBLine3 = New DevExpress.XtraGrid.Views.BandedGrid.GridBand()
        Me.GBLine4 = New DevExpress.XtraGrid.Views.BandedGrid.GridBand()
        Me.GBLine5 = New DevExpress.XtraGrid.Views.BandedGrid.GridBand()
        Me.BGCOLNFOUNUM = New DevExpress.XtraGrid.Views.BandedGrid.BandedGridColumn()
        Me.BGCOLVFOUREF = New DevExpress.XtraGrid.Views.BandedGrid.BandedGridColumn()
        Me.BGCOLVFOUMAT = New DevExpress.XtraGrid.Views.BandedGrid.BandedGridColumn()
        Me.BGCOLVFOUTYP = New DevExpress.XtraGrid.Views.BandedGrid.BandedGridColumn()
        Me.BGCOLVFOUUNITE = New DevExpress.XtraGrid.Views.BandedGrid.BandedGridColumn()
        Me.BGCOLVFOUCONSO = New DevExpress.XtraGrid.Views.BandedGrid.BandedGridColumn()
        Me.BGCOLPRIXNETFO = New DevExpress.XtraGrid.Views.BandedGrid.BandedGridColumn()
        Me.BGCOLREMFO = New DevExpress.XtraGrid.Views.BandedGrid.BandedGridColumn()
        CType(Me.GCExportConsultMag, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.ABGVExportConsultMag, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'LblTitre
        '
        resources.ApplyResources(Me.LblTitre, "LblTitre")
        Me.LblTitre.Name = "LblTitre"
        '
        'BtnSendMail
        '
        resources.ApplyResources(Me.BtnSendMail, "BtnSendMail")
        Me.BtnSendMail.Name = "BtnSendMail"
        Me.BtnSendMail.UseVisualStyleBackColor = True
        '
        'BtnClose
        '
        resources.ApplyResources(Me.BtnClose, "BtnClose")
        Me.BtnClose.Name = "BtnClose"
        Me.BtnClose.UseVisualStyleBackColor = True
        '
        'CboSerie
        '
        resources.ApplyResources(Me.CboSerie, "CboSerie")
        Me.CboSerie.DisplayMember = "CCFOCOD"
        Me.CboSerie.FormattingEnabled = True
        Me.CboSerie.Name = "CboSerie"
        Me.CboSerie.ValueMember = "NCFOCOD"
        '
        'GCExportConsultMag
        '
        resources.ApplyResources(Me.GCExportConsultMag, "GCExportConsultMag")
        '
        '
        '
        Me.GCExportConsultMag.EmbeddedNavigator.AccessibleDescription = resources.GetString("GCExportConsultMag.EmbeddedNavigator.AccessibleDescription")
        Me.GCExportConsultMag.EmbeddedNavigator.AccessibleName = resources.GetString("GCExportConsultMag.EmbeddedNavigator.AccessibleName")
        Me.GCExportConsultMag.EmbeddedNavigator.AllowHtmlTextInToolTip = CType(resources.GetObject("GCExportConsultMag.EmbeddedNavigator.AllowHtmlTextInToolTip"), DevExpress.Utils.DefaultBoolean)
        Me.GCExportConsultMag.EmbeddedNavigator.Anchor = CType(resources.GetObject("GCExportConsultMag.EmbeddedNavigator.Anchor"), System.Windows.Forms.AnchorStyles)
        Me.GCExportConsultMag.EmbeddedNavigator.BackgroundImage = CType(resources.GetObject("GCExportConsultMag.EmbeddedNavigator.BackgroundImage"), System.Drawing.Image)
        Me.GCExportConsultMag.EmbeddedNavigator.BackgroundImageLayout = CType(resources.GetObject("GCExportConsultMag.EmbeddedNavigator.BackgroundImageLayout"), System.Windows.Forms.ImageLayout)
        Me.GCExportConsultMag.EmbeddedNavigator.ImeMode = CType(resources.GetObject("GCExportConsultMag.EmbeddedNavigator.ImeMode"), System.Windows.Forms.ImeMode)
        Me.GCExportConsultMag.EmbeddedNavigator.MaximumSize = CType(resources.GetObject("GCExportConsultMag.EmbeddedNavigator.MaximumSize"), System.Drawing.Size)
        Me.GCExportConsultMag.EmbeddedNavigator.TextLocation = CType(resources.GetObject("GCExportConsultMag.EmbeddedNavigator.TextLocation"), DevExpress.XtraEditors.NavigatorButtonsTextLocation)
        Me.GCExportConsultMag.EmbeddedNavigator.ToolTip = resources.GetString("GCExportConsultMag.EmbeddedNavigator.ToolTip")
        Me.GCExportConsultMag.EmbeddedNavigator.ToolTipIconType = CType(resources.GetObject("GCExportConsultMag.EmbeddedNavigator.ToolTipIconType"), DevExpress.Utils.ToolTipIconType)
        Me.GCExportConsultMag.EmbeddedNavigator.ToolTipTitle = resources.GetString("GCExportConsultMag.EmbeddedNavigator.ToolTipTitle")
        Me.GCExportConsultMag.LookAndFeel.Style = DevExpress.LookAndFeel.LookAndFeelStyle.Flat
        Me.GCExportConsultMag.LookAndFeel.UseDefaultLookAndFeel = False
        Me.GCExportConsultMag.MainView = Me.ABGVExportConsultMag
        Me.GCExportConsultMag.Name = "GCExportConsultMag"
        Me.GCExportConsultMag.ViewCollection.AddRange(New DevExpress.XtraGrid.Views.Base.BaseView() {Me.ABGVExportConsultMag})
        '
        'ABGVExportConsultMag
        '
        Me.ABGVExportConsultMag.Bands.AddRange(New DevExpress.XtraGrid.Views.BandedGrid.GridBand() {Me.GBLine1})
        resources.ApplyResources(Me.ABGVExportConsultMag, "ABGVExportConsultMag")
        Me.ABGVExportConsultMag.Columns.AddRange(New DevExpress.XtraGrid.Views.BandedGrid.BandedGridColumn() {Me.BGCOLNFOUNUM, Me.BGCOLVFOUREF, Me.BGCOLVFOUMAT, Me.BGCOLVFOUTYP, Me.BGCOLVFOUUNITE, Me.BGCOLVFOUCONSO, Me.BGCOLPRIXNETFO, Me.BGCOLREMFO})
        Me.ABGVExportConsultMag.GridControl = Me.GCExportConsultMag
        Me.ABGVExportConsultMag.Name = "ABGVExportConsultMag"
        Me.ABGVExportConsultMag.OptionsPrint.AutoWidth = False
        Me.ABGVExportConsultMag.OptionsView.ShowGroupPanel = False
        '
        'GBLine1
        '
        Me.GBLine1.AppearanceHeader.BackColor = CType(resources.GetObject("GBLine1.AppearanceHeader.BackColor"), System.Drawing.Color)
        Me.GBLine1.AppearanceHeader.Font = CType(resources.GetObject("GBLine1.AppearanceHeader.Font"), System.Drawing.Font)
        Me.GBLine1.AppearanceHeader.FontSizeDelta = CType(resources.GetObject("GBLine1.AppearanceHeader.FontSizeDelta"), Integer)
        Me.GBLine1.AppearanceHeader.FontStyleDelta = CType(resources.GetObject("GBLine1.AppearanceHeader.FontStyleDelta"), System.Drawing.FontStyle)
        Me.GBLine1.AppearanceHeader.GradientMode = CType(resources.GetObject("GBLine1.AppearanceHeader.GradientMode"), System.Drawing.Drawing2D.LinearGradientMode)
        Me.GBLine1.AppearanceHeader.Image = CType(resources.GetObject("GBLine1.AppearanceHeader.Image"), System.Drawing.Image)
        Me.GBLine1.AppearanceHeader.Options.UseBackColor = True
        Me.GBLine1.AppearanceHeader.Options.UseFont = True
        Me.GBLine1.AppearanceHeader.Options.UseTextOptions = True
        Me.GBLine1.AppearanceHeader.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center
        Me.GBLine1.AppearanceHeader.TextOptions.VAlignment = DevExpress.Utils.VertAlignment.Center
        Me.GBLine1.AppearanceHeader.TextOptions.WordWrap = DevExpress.Utils.WordWrap.Wrap
        resources.ApplyResources(Me.GBLine1, "GBLine1")
        Me.GBLine1.Children.AddRange(New DevExpress.XtraGrid.Views.BandedGrid.GridBand() {Me.GBLine2})
        Me.GBLine1.VisibleIndex = 0
        '
        'GBLine2
        '
        Me.GBLine2.AppearanceHeader.BackColor = CType(resources.GetObject("GBLine2.AppearanceHeader.BackColor"), System.Drawing.Color)
        Me.GBLine2.AppearanceHeader.Font = CType(resources.GetObject("GBLine2.AppearanceHeader.Font"), System.Drawing.Font)
        Me.GBLine2.AppearanceHeader.FontSizeDelta = CType(resources.GetObject("GBLine2.AppearanceHeader.FontSizeDelta"), Integer)
        Me.GBLine2.AppearanceHeader.FontStyleDelta = CType(resources.GetObject("GBLine2.AppearanceHeader.FontStyleDelta"), System.Drawing.FontStyle)
        Me.GBLine2.AppearanceHeader.GradientMode = CType(resources.GetObject("GBLine2.AppearanceHeader.GradientMode"), System.Drawing.Drawing2D.LinearGradientMode)
        Me.GBLine2.AppearanceHeader.Image = CType(resources.GetObject("GBLine2.AppearanceHeader.Image"), System.Drawing.Image)
        Me.GBLine2.AppearanceHeader.Options.UseBackColor = True
        Me.GBLine2.AppearanceHeader.Options.UseFont = True
        Me.GBLine2.AppearanceHeader.Options.UseTextOptions = True
        Me.GBLine2.AppearanceHeader.TextOptions.VAlignment = DevExpress.Utils.VertAlignment.Center
        Me.GBLine2.AppearanceHeader.TextOptions.WordWrap = DevExpress.Utils.WordWrap.Wrap
        resources.ApplyResources(Me.GBLine2, "GBLine2")
        Me.GBLine2.Children.AddRange(New DevExpress.XtraGrid.Views.BandedGrid.GridBand() {Me.GBLine3})
        Me.GBLine2.VisibleIndex = 0
        '
        'GBLine3
        '
        Me.GBLine3.AppearanceHeader.BackColor = CType(resources.GetObject("GBLine3.AppearanceHeader.BackColor"), System.Drawing.Color)
        Me.GBLine3.AppearanceHeader.Font = CType(resources.GetObject("GBLine3.AppearanceHeader.Font"), System.Drawing.Font)
        Me.GBLine3.AppearanceHeader.FontSizeDelta = CType(resources.GetObject("GBLine3.AppearanceHeader.FontSizeDelta"), Integer)
        Me.GBLine3.AppearanceHeader.FontStyleDelta = CType(resources.GetObject("GBLine3.AppearanceHeader.FontStyleDelta"), System.Drawing.FontStyle)
        Me.GBLine3.AppearanceHeader.GradientMode = CType(resources.GetObject("GBLine3.AppearanceHeader.GradientMode"), System.Drawing.Drawing2D.LinearGradientMode)
        Me.GBLine3.AppearanceHeader.Image = CType(resources.GetObject("GBLine3.AppearanceHeader.Image"), System.Drawing.Image)
        Me.GBLine3.AppearanceHeader.Options.UseBackColor = True
        Me.GBLine3.AppearanceHeader.Options.UseFont = True
        Me.GBLine3.AppearanceHeader.Options.UseTextOptions = True
        Me.GBLine3.AppearanceHeader.TextOptions.VAlignment = DevExpress.Utils.VertAlignment.Center
        Me.GBLine3.AppearanceHeader.TextOptions.WordWrap = DevExpress.Utils.WordWrap.Wrap
        resources.ApplyResources(Me.GBLine3, "GBLine3")
        Me.GBLine3.Children.AddRange(New DevExpress.XtraGrid.Views.BandedGrid.GridBand() {Me.GBLine4})
        Me.GBLine3.VisibleIndex = 0
        '
        'GBLine4
        '
        Me.GBLine4.AppearanceHeader.BackColor = CType(resources.GetObject("GBLine4.AppearanceHeader.BackColor"), System.Drawing.Color)
        Me.GBLine4.AppearanceHeader.Font = CType(resources.GetObject("GBLine4.AppearanceHeader.Font"), System.Drawing.Font)
        Me.GBLine4.AppearanceHeader.FontSizeDelta = CType(resources.GetObject("GBLine4.AppearanceHeader.FontSizeDelta"), Integer)
        Me.GBLine4.AppearanceHeader.FontStyleDelta = CType(resources.GetObject("GBLine4.AppearanceHeader.FontStyleDelta"), System.Drawing.FontStyle)
        Me.GBLine4.AppearanceHeader.GradientMode = CType(resources.GetObject("GBLine4.AppearanceHeader.GradientMode"), System.Drawing.Drawing2D.LinearGradientMode)
        Me.GBLine4.AppearanceHeader.Image = CType(resources.GetObject("GBLine4.AppearanceHeader.Image"), System.Drawing.Image)
        Me.GBLine4.AppearanceHeader.Options.UseBackColor = True
        Me.GBLine4.AppearanceHeader.Options.UseFont = True
        Me.GBLine4.AppearanceHeader.Options.UseTextOptions = True
        Me.GBLine4.AppearanceHeader.TextOptions.VAlignment = DevExpress.Utils.VertAlignment.Center
        Me.GBLine4.AppearanceHeader.TextOptions.WordWrap = DevExpress.Utils.WordWrap.Wrap
        resources.ApplyResources(Me.GBLine4, "GBLine4")
        Me.GBLine4.Children.AddRange(New DevExpress.XtraGrid.Views.BandedGrid.GridBand() {Me.GBLine5})
        Me.GBLine4.VisibleIndex = 0
        '
        'GBLine5
        '
        Me.GBLine5.AppearanceHeader.BackColor = CType(resources.GetObject("GBLine5.AppearanceHeader.BackColor"), System.Drawing.Color)
        Me.GBLine5.AppearanceHeader.Font = CType(resources.GetObject("GBLine5.AppearanceHeader.Font"), System.Drawing.Font)
        Me.GBLine5.AppearanceHeader.FontSizeDelta = CType(resources.GetObject("GBLine5.AppearanceHeader.FontSizeDelta"), Integer)
        Me.GBLine5.AppearanceHeader.FontStyleDelta = CType(resources.GetObject("GBLine5.AppearanceHeader.FontStyleDelta"), System.Drawing.FontStyle)
        Me.GBLine5.AppearanceHeader.ForeColor = CType(resources.GetObject("GBLine5.AppearanceHeader.ForeColor"), System.Drawing.Color)
        Me.GBLine5.AppearanceHeader.GradientMode = CType(resources.GetObject("GBLine5.AppearanceHeader.GradientMode"), System.Drawing.Drawing2D.LinearGradientMode)
        Me.GBLine5.AppearanceHeader.Image = CType(resources.GetObject("GBLine5.AppearanceHeader.Image"), System.Drawing.Image)
        Me.GBLine5.AppearanceHeader.Options.UseBackColor = True
        Me.GBLine5.AppearanceHeader.Options.UseFont = True
        Me.GBLine5.AppearanceHeader.Options.UseForeColor = True
        Me.GBLine5.AppearanceHeader.Options.UseTextOptions = True
        Me.GBLine5.AppearanceHeader.TextOptions.VAlignment = DevExpress.Utils.VertAlignment.Center
        Me.GBLine5.AppearanceHeader.TextOptions.WordWrap = DevExpress.Utils.WordWrap.Wrap
        resources.ApplyResources(Me.GBLine5, "GBLine5")
        Me.GBLine5.Columns.Add(Me.BGCOLNFOUNUM)
        Me.GBLine5.Columns.Add(Me.BGCOLVFOUREF)
        Me.GBLine5.Columns.Add(Me.BGCOLVFOUMAT)
        Me.GBLine5.Columns.Add(Me.BGCOLVFOUTYP)
        Me.GBLine5.Columns.Add(Me.BGCOLVFOUUNITE)
        Me.GBLine5.Columns.Add(Me.BGCOLVFOUCONSO)
        Me.GBLine5.Columns.Add(Me.BGCOLPRIXNETFO)
        Me.GBLine5.Columns.Add(Me.BGCOLREMFO)
        Me.GBLine5.VisibleIndex = 0
        '
        'BGCOLNFOUNUM
        '
        Me.BGCOLNFOUNUM.AppearanceHeader.BackColor = CType(resources.GetObject("BGCOLNFOUNUM.AppearanceHeader.BackColor"), System.Drawing.Color)
        Me.BGCOLNFOUNUM.AppearanceHeader.Font = CType(resources.GetObject("BGCOLNFOUNUM.AppearanceHeader.Font"), System.Drawing.Font)
        Me.BGCOLNFOUNUM.AppearanceHeader.FontSizeDelta = CType(resources.GetObject("BGCOLNFOUNUM.AppearanceHeader.FontSizeDelta"), Integer)
        Me.BGCOLNFOUNUM.AppearanceHeader.FontStyleDelta = CType(resources.GetObject("BGCOLNFOUNUM.AppearanceHeader.FontStyleDelta"), System.Drawing.FontStyle)
        Me.BGCOLNFOUNUM.AppearanceHeader.GradientMode = CType(resources.GetObject("BGCOLNFOUNUM.AppearanceHeader.GradientMode"), System.Drawing.Drawing2D.LinearGradientMode)
        Me.BGCOLNFOUNUM.AppearanceHeader.Image = CType(resources.GetObject("BGCOLNFOUNUM.AppearanceHeader.Image"), System.Drawing.Image)
        Me.BGCOLNFOUNUM.AppearanceHeader.Options.UseBackColor = True
        Me.BGCOLNFOUNUM.AppearanceHeader.Options.UseFont = True
        Me.BGCOLNFOUNUM.AppearanceHeader.Options.UseTextOptions = True
        Me.BGCOLNFOUNUM.AppearanceHeader.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center
        resources.ApplyResources(Me.BGCOLNFOUNUM, "BGCOLNFOUNUM")
        Me.BGCOLNFOUNUM.FieldName = "NFOUNUM"
        Me.BGCOLNFOUNUM.Name = "BGCOLNFOUNUM"
        Me.BGCOLNFOUNUM.RowCount = 2
        '
        'BGCOLVFOUREF
        '
        Me.BGCOLVFOUREF.AppearanceHeader.BackColor = CType(resources.GetObject("BGCOLVFOUREF.AppearanceHeader.BackColor"), System.Drawing.Color)
        Me.BGCOLVFOUREF.AppearanceHeader.Font = CType(resources.GetObject("BGCOLVFOUREF.AppearanceHeader.Font"), System.Drawing.Font)
        Me.BGCOLVFOUREF.AppearanceHeader.FontSizeDelta = CType(resources.GetObject("BGCOLVFOUREF.AppearanceHeader.FontSizeDelta"), Integer)
        Me.BGCOLVFOUREF.AppearanceHeader.FontStyleDelta = CType(resources.GetObject("BGCOLVFOUREF.AppearanceHeader.FontStyleDelta"), System.Drawing.FontStyle)
        Me.BGCOLVFOUREF.AppearanceHeader.GradientMode = CType(resources.GetObject("BGCOLVFOUREF.AppearanceHeader.GradientMode"), System.Drawing.Drawing2D.LinearGradientMode)
        Me.BGCOLVFOUREF.AppearanceHeader.Image = CType(resources.GetObject("BGCOLVFOUREF.AppearanceHeader.Image"), System.Drawing.Image)
        Me.BGCOLVFOUREF.AppearanceHeader.Options.UseBackColor = True
        Me.BGCOLVFOUREF.AppearanceHeader.Options.UseFont = True
        Me.BGCOLVFOUREF.AppearanceHeader.Options.UseTextOptions = True
        Me.BGCOLVFOUREF.AppearanceHeader.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center
        resources.ApplyResources(Me.BGCOLVFOUREF, "BGCOLVFOUREF")
        Me.BGCOLVFOUREF.FieldName = "VFOUREF"
        Me.BGCOLVFOUREF.Name = "BGCOLVFOUREF"
        Me.BGCOLVFOUREF.RowCount = 2
        '
        'BGCOLVFOUMAT
        '
        Me.BGCOLVFOUMAT.AppearanceCell.FontSizeDelta = CType(resources.GetObject("BGCOLVFOUMAT.AppearanceCell.FontSizeDelta"), Integer)
        Me.BGCOLVFOUMAT.AppearanceCell.FontStyleDelta = CType(resources.GetObject("BGCOLVFOUMAT.AppearanceCell.FontStyleDelta"), System.Drawing.FontStyle)
        Me.BGCOLVFOUMAT.AppearanceCell.GradientMode = CType(resources.GetObject("BGCOLVFOUMAT.AppearanceCell.GradientMode"), System.Drawing.Drawing2D.LinearGradientMode)
        Me.BGCOLVFOUMAT.AppearanceCell.Image = CType(resources.GetObject("BGCOLVFOUMAT.AppearanceCell.Image"), System.Drawing.Image)
        Me.BGCOLVFOUMAT.AppearanceCell.Options.UseTextOptions = True
        Me.BGCOLVFOUMAT.AppearanceCell.TextOptions.VAlignment = DevExpress.Utils.VertAlignment.Center
        Me.BGCOLVFOUMAT.AppearanceCell.TextOptions.WordWrap = DevExpress.Utils.WordWrap.Wrap
        Me.BGCOLVFOUMAT.AppearanceHeader.BackColor = CType(resources.GetObject("BGCOLVFOUMAT.AppearanceHeader.BackColor"), System.Drawing.Color)
        Me.BGCOLVFOUMAT.AppearanceHeader.Font = CType(resources.GetObject("BGCOLVFOUMAT.AppearanceHeader.Font"), System.Drawing.Font)
        Me.BGCOLVFOUMAT.AppearanceHeader.FontSizeDelta = CType(resources.GetObject("BGCOLVFOUMAT.AppearanceHeader.FontSizeDelta"), Integer)
        Me.BGCOLVFOUMAT.AppearanceHeader.FontStyleDelta = CType(resources.GetObject("BGCOLVFOUMAT.AppearanceHeader.FontStyleDelta"), System.Drawing.FontStyle)
        Me.BGCOLVFOUMAT.AppearanceHeader.GradientMode = CType(resources.GetObject("BGCOLVFOUMAT.AppearanceHeader.GradientMode"), System.Drawing.Drawing2D.LinearGradientMode)
        Me.BGCOLVFOUMAT.AppearanceHeader.Image = CType(resources.GetObject("BGCOLVFOUMAT.AppearanceHeader.Image"), System.Drawing.Image)
        Me.BGCOLVFOUMAT.AppearanceHeader.Options.UseBackColor = True
        Me.BGCOLVFOUMAT.AppearanceHeader.Options.UseFont = True
        Me.BGCOLVFOUMAT.AppearanceHeader.Options.UseTextOptions = True
        Me.BGCOLVFOUMAT.AppearanceHeader.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center
        Me.BGCOLVFOUMAT.AppearanceHeader.TextOptions.VAlignment = DevExpress.Utils.VertAlignment.Center
        Me.BGCOLVFOUMAT.AppearanceHeader.TextOptions.WordWrap = DevExpress.Utils.WordWrap.Wrap
        resources.ApplyResources(Me.BGCOLVFOUMAT, "BGCOLVFOUMAT")
        Me.BGCOLVFOUMAT.FieldName = "VFOUMAT"
        Me.BGCOLVFOUMAT.Name = "BGCOLVFOUMAT"
        Me.BGCOLVFOUMAT.RowCount = 2
        '
        'BGCOLVFOUTYP
        '
        Me.BGCOLVFOUTYP.AppearanceCell.FontSizeDelta = CType(resources.GetObject("BGCOLVFOUTYP.AppearanceCell.FontSizeDelta"), Integer)
        Me.BGCOLVFOUTYP.AppearanceCell.FontStyleDelta = CType(resources.GetObject("BGCOLVFOUTYP.AppearanceCell.FontStyleDelta"), System.Drawing.FontStyle)
        Me.BGCOLVFOUTYP.AppearanceCell.GradientMode = CType(resources.GetObject("BGCOLVFOUTYP.AppearanceCell.GradientMode"), System.Drawing.Drawing2D.LinearGradientMode)
        Me.BGCOLVFOUTYP.AppearanceCell.Image = CType(resources.GetObject("BGCOLVFOUTYP.AppearanceCell.Image"), System.Drawing.Image)
        Me.BGCOLVFOUTYP.AppearanceCell.Options.UseTextOptions = True
        Me.BGCOLVFOUTYP.AppearanceCell.TextOptions.VAlignment = DevExpress.Utils.VertAlignment.Center
        Me.BGCOLVFOUTYP.AppearanceCell.TextOptions.WordWrap = DevExpress.Utils.WordWrap.Wrap
        Me.BGCOLVFOUTYP.AppearanceHeader.BackColor = CType(resources.GetObject("BGCOLVFOUTYP.AppearanceHeader.BackColor"), System.Drawing.Color)
        Me.BGCOLVFOUTYP.AppearanceHeader.Font = CType(resources.GetObject("BGCOLVFOUTYP.AppearanceHeader.Font"), System.Drawing.Font)
        Me.BGCOLVFOUTYP.AppearanceHeader.FontSizeDelta = CType(resources.GetObject("BGCOLVFOUTYP.AppearanceHeader.FontSizeDelta"), Integer)
        Me.BGCOLVFOUTYP.AppearanceHeader.FontStyleDelta = CType(resources.GetObject("BGCOLVFOUTYP.AppearanceHeader.FontStyleDelta"), System.Drawing.FontStyle)
        Me.BGCOLVFOUTYP.AppearanceHeader.GradientMode = CType(resources.GetObject("BGCOLVFOUTYP.AppearanceHeader.GradientMode"), System.Drawing.Drawing2D.LinearGradientMode)
        Me.BGCOLVFOUTYP.AppearanceHeader.Image = CType(resources.GetObject("BGCOLVFOUTYP.AppearanceHeader.Image"), System.Drawing.Image)
        Me.BGCOLVFOUTYP.AppearanceHeader.Options.UseBackColor = True
        Me.BGCOLVFOUTYP.AppearanceHeader.Options.UseFont = True
        Me.BGCOLVFOUTYP.AppearanceHeader.Options.UseTextOptions = True
        Me.BGCOLVFOUTYP.AppearanceHeader.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center
        Me.BGCOLVFOUTYP.AppearanceHeader.TextOptions.VAlignment = DevExpress.Utils.VertAlignment.Center
        Me.BGCOLVFOUTYP.AppearanceHeader.TextOptions.WordWrap = DevExpress.Utils.WordWrap.Wrap
        resources.ApplyResources(Me.BGCOLVFOUTYP, "BGCOLVFOUTYP")
        Me.BGCOLVFOUTYP.FieldName = "VFOUTYP"
        Me.BGCOLVFOUTYP.Name = "BGCOLVFOUTYP"
        Me.BGCOLVFOUTYP.RowCount = 2
        '
        'BGCOLVFOUUNITE
        '
        Me.BGCOLVFOUUNITE.AppearanceCell.FontSizeDelta = CType(resources.GetObject("BGCOLVFOUUNITE.AppearanceCell.FontSizeDelta"), Integer)
        Me.BGCOLVFOUUNITE.AppearanceCell.FontStyleDelta = CType(resources.GetObject("BGCOLVFOUUNITE.AppearanceCell.FontStyleDelta"), System.Drawing.FontStyle)
        Me.BGCOLVFOUUNITE.AppearanceCell.GradientMode = CType(resources.GetObject("BGCOLVFOUUNITE.AppearanceCell.GradientMode"), System.Drawing.Drawing2D.LinearGradientMode)
        Me.BGCOLVFOUUNITE.AppearanceCell.Image = CType(resources.GetObject("BGCOLVFOUUNITE.AppearanceCell.Image"), System.Drawing.Image)
        Me.BGCOLVFOUUNITE.AppearanceCell.Options.UseTextOptions = True
        Me.BGCOLVFOUUNITE.AppearanceCell.TextOptions.VAlignment = DevExpress.Utils.VertAlignment.Center
        Me.BGCOLVFOUUNITE.AppearanceCell.TextOptions.WordWrap = DevExpress.Utils.WordWrap.Wrap
        Me.BGCOLVFOUUNITE.AppearanceHeader.BackColor = CType(resources.GetObject("BGCOLVFOUUNITE.AppearanceHeader.BackColor"), System.Drawing.Color)
        Me.BGCOLVFOUUNITE.AppearanceHeader.Font = CType(resources.GetObject("BGCOLVFOUUNITE.AppearanceHeader.Font"), System.Drawing.Font)
        Me.BGCOLVFOUUNITE.AppearanceHeader.FontSizeDelta = CType(resources.GetObject("BGCOLVFOUUNITE.AppearanceHeader.FontSizeDelta"), Integer)
        Me.BGCOLVFOUUNITE.AppearanceHeader.FontStyleDelta = CType(resources.GetObject("BGCOLVFOUUNITE.AppearanceHeader.FontStyleDelta"), System.Drawing.FontStyle)
        Me.BGCOLVFOUUNITE.AppearanceHeader.GradientMode = CType(resources.GetObject("BGCOLVFOUUNITE.AppearanceHeader.GradientMode"), System.Drawing.Drawing2D.LinearGradientMode)
        Me.BGCOLVFOUUNITE.AppearanceHeader.Image = CType(resources.GetObject("BGCOLVFOUUNITE.AppearanceHeader.Image"), System.Drawing.Image)
        Me.BGCOLVFOUUNITE.AppearanceHeader.Options.UseBackColor = True
        Me.BGCOLVFOUUNITE.AppearanceHeader.Options.UseFont = True
        Me.BGCOLVFOUUNITE.AppearanceHeader.Options.UseTextOptions = True
        Me.BGCOLVFOUUNITE.AppearanceHeader.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center
        Me.BGCOLVFOUUNITE.AppearanceHeader.TextOptions.VAlignment = DevExpress.Utils.VertAlignment.Center
        Me.BGCOLVFOUUNITE.AppearanceHeader.TextOptions.WordWrap = DevExpress.Utils.WordWrap.Wrap
        resources.ApplyResources(Me.BGCOLVFOUUNITE, "BGCOLVFOUUNITE")
        Me.BGCOLVFOUUNITE.FieldName = "VFOUUNITE"
        Me.BGCOLVFOUUNITE.Name = "BGCOLVFOUUNITE"
        Me.BGCOLVFOUUNITE.RowCount = 2
        '
        'BGCOLVFOUCONSO
        '
        Me.BGCOLVFOUCONSO.AppearanceCell.FontSizeDelta = CType(resources.GetObject("BGCOLVFOUCONSO.AppearanceCell.FontSizeDelta"), Integer)
        Me.BGCOLVFOUCONSO.AppearanceCell.FontStyleDelta = CType(resources.GetObject("BGCOLVFOUCONSO.AppearanceCell.FontStyleDelta"), System.Drawing.FontStyle)
        Me.BGCOLVFOUCONSO.AppearanceCell.GradientMode = CType(resources.GetObject("BGCOLVFOUCONSO.AppearanceCell.GradientMode"), System.Drawing.Drawing2D.LinearGradientMode)
        Me.BGCOLVFOUCONSO.AppearanceCell.Image = CType(resources.GetObject("BGCOLVFOUCONSO.AppearanceCell.Image"), System.Drawing.Image)
        Me.BGCOLVFOUCONSO.AppearanceCell.Options.UseTextOptions = True
        Me.BGCOLVFOUCONSO.AppearanceCell.TextOptions.VAlignment = DevExpress.Utils.VertAlignment.Center
        Me.BGCOLVFOUCONSO.AppearanceCell.TextOptions.WordWrap = DevExpress.Utils.WordWrap.Wrap
        Me.BGCOLVFOUCONSO.AppearanceHeader.BackColor = CType(resources.GetObject("BGCOLVFOUCONSO.AppearanceHeader.BackColor"), System.Drawing.Color)
        Me.BGCOLVFOUCONSO.AppearanceHeader.Font = CType(resources.GetObject("BGCOLVFOUCONSO.AppearanceHeader.Font"), System.Drawing.Font)
        Me.BGCOLVFOUCONSO.AppearanceHeader.FontSizeDelta = CType(resources.GetObject("BGCOLVFOUCONSO.AppearanceHeader.FontSizeDelta"), Integer)
        Me.BGCOLVFOUCONSO.AppearanceHeader.FontStyleDelta = CType(resources.GetObject("BGCOLVFOUCONSO.AppearanceHeader.FontStyleDelta"), System.Drawing.FontStyle)
        Me.BGCOLVFOUCONSO.AppearanceHeader.GradientMode = CType(resources.GetObject("BGCOLVFOUCONSO.AppearanceHeader.GradientMode"), System.Drawing.Drawing2D.LinearGradientMode)
        Me.BGCOLVFOUCONSO.AppearanceHeader.Image = CType(resources.GetObject("BGCOLVFOUCONSO.AppearanceHeader.Image"), System.Drawing.Image)
        Me.BGCOLVFOUCONSO.AppearanceHeader.Options.UseBackColor = True
        Me.BGCOLVFOUCONSO.AppearanceHeader.Options.UseFont = True
        Me.BGCOLVFOUCONSO.AppearanceHeader.Options.UseTextOptions = True
        Me.BGCOLVFOUCONSO.AppearanceHeader.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center
        Me.BGCOLVFOUCONSO.AppearanceHeader.TextOptions.VAlignment = DevExpress.Utils.VertAlignment.Center
        Me.BGCOLVFOUCONSO.AppearanceHeader.TextOptions.WordWrap = DevExpress.Utils.WordWrap.Wrap
        resources.ApplyResources(Me.BGCOLVFOUCONSO, "BGCOLVFOUCONSO")
        Me.BGCOLVFOUCONSO.FieldName = "VFOUCONSO"
        Me.BGCOLVFOUCONSO.Name = "BGCOLVFOUCONSO"
        Me.BGCOLVFOUCONSO.RowCount = 2
        '
        'BGCOLPRIXNETFO
        '
        Me.BGCOLPRIXNETFO.AppearanceCell.FontSizeDelta = CType(resources.GetObject("BGCOLPRIXNETFO.AppearanceCell.FontSizeDelta"), Integer)
        Me.BGCOLPRIXNETFO.AppearanceCell.FontStyleDelta = CType(resources.GetObject("BGCOLPRIXNETFO.AppearanceCell.FontStyleDelta"), System.Drawing.FontStyle)
        Me.BGCOLPRIXNETFO.AppearanceCell.GradientMode = CType(resources.GetObject("BGCOLPRIXNETFO.AppearanceCell.GradientMode"), System.Drawing.Drawing2D.LinearGradientMode)
        Me.BGCOLPRIXNETFO.AppearanceCell.Image = CType(resources.GetObject("BGCOLPRIXNETFO.AppearanceCell.Image"), System.Drawing.Image)
        Me.BGCOLPRIXNETFO.AppearanceCell.Options.UseTextOptions = True
        Me.BGCOLPRIXNETFO.AppearanceCell.TextOptions.VAlignment = DevExpress.Utils.VertAlignment.Center
        Me.BGCOLPRIXNETFO.AppearanceCell.TextOptions.WordWrap = DevExpress.Utils.WordWrap.Wrap
        Me.BGCOLPRIXNETFO.AppearanceHeader.BackColor = CType(resources.GetObject("BGCOLPRIXNETFO.AppearanceHeader.BackColor"), System.Drawing.Color)
        Me.BGCOLPRIXNETFO.AppearanceHeader.Font = CType(resources.GetObject("BGCOLPRIXNETFO.AppearanceHeader.Font"), System.Drawing.Font)
        Me.BGCOLPRIXNETFO.AppearanceHeader.FontSizeDelta = CType(resources.GetObject("BGCOLPRIXNETFO.AppearanceHeader.FontSizeDelta"), Integer)
        Me.BGCOLPRIXNETFO.AppearanceHeader.FontStyleDelta = CType(resources.GetObject("BGCOLPRIXNETFO.AppearanceHeader.FontStyleDelta"), System.Drawing.FontStyle)
        Me.BGCOLPRIXNETFO.AppearanceHeader.ForeColor = CType(resources.GetObject("BGCOLPRIXNETFO.AppearanceHeader.ForeColor"), System.Drawing.Color)
        Me.BGCOLPRIXNETFO.AppearanceHeader.GradientMode = CType(resources.GetObject("BGCOLPRIXNETFO.AppearanceHeader.GradientMode"), System.Drawing.Drawing2D.LinearGradientMode)
        Me.BGCOLPRIXNETFO.AppearanceHeader.Image = CType(resources.GetObject("BGCOLPRIXNETFO.AppearanceHeader.Image"), System.Drawing.Image)
        Me.BGCOLPRIXNETFO.AppearanceHeader.Options.UseBackColor = True
        Me.BGCOLPRIXNETFO.AppearanceHeader.Options.UseFont = True
        Me.BGCOLPRIXNETFO.AppearanceHeader.Options.UseForeColor = True
        Me.BGCOLPRIXNETFO.AppearanceHeader.Options.UseTextOptions = True
        Me.BGCOLPRIXNETFO.AppearanceHeader.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center
        Me.BGCOLPRIXNETFO.AppearanceHeader.TextOptions.VAlignment = DevExpress.Utils.VertAlignment.Center
        Me.BGCOLPRIXNETFO.AppearanceHeader.TextOptions.WordWrap = DevExpress.Utils.WordWrap.Wrap
        resources.ApplyResources(Me.BGCOLPRIXNETFO, "BGCOLPRIXNETFO")
        Me.BGCOLPRIXNETFO.Name = "BGCOLPRIXNETFO"
        Me.BGCOLPRIXNETFO.RowCount = 2
        '
        'BGCOLREMFO
        '
        Me.BGCOLREMFO.AppearanceCell.FontSizeDelta = CType(resources.GetObject("BGCOLREMFO.AppearanceCell.FontSizeDelta"), Integer)
        Me.BGCOLREMFO.AppearanceCell.FontStyleDelta = CType(resources.GetObject("BGCOLREMFO.AppearanceCell.FontStyleDelta"), System.Drawing.FontStyle)
        Me.BGCOLREMFO.AppearanceCell.GradientMode = CType(resources.GetObject("BGCOLREMFO.AppearanceCell.GradientMode"), System.Drawing.Drawing2D.LinearGradientMode)
        Me.BGCOLREMFO.AppearanceCell.Image = CType(resources.GetObject("BGCOLREMFO.AppearanceCell.Image"), System.Drawing.Image)
        Me.BGCOLREMFO.AppearanceCell.Options.UseTextOptions = True
        Me.BGCOLREMFO.AppearanceCell.TextOptions.VAlignment = DevExpress.Utils.VertAlignment.Center
        Me.BGCOLREMFO.AppearanceCell.TextOptions.WordWrap = DevExpress.Utils.WordWrap.Wrap
        Me.BGCOLREMFO.AppearanceHeader.BackColor = CType(resources.GetObject("BGCOLREMFO.AppearanceHeader.BackColor"), System.Drawing.Color)
        Me.BGCOLREMFO.AppearanceHeader.Font = CType(resources.GetObject("BGCOLREMFO.AppearanceHeader.Font"), System.Drawing.Font)
        Me.BGCOLREMFO.AppearanceHeader.FontSizeDelta = CType(resources.GetObject("BGCOLREMFO.AppearanceHeader.FontSizeDelta"), Integer)
        Me.BGCOLREMFO.AppearanceHeader.FontStyleDelta = CType(resources.GetObject("BGCOLREMFO.AppearanceHeader.FontStyleDelta"), System.Drawing.FontStyle)
        Me.BGCOLREMFO.AppearanceHeader.ForeColor = CType(resources.GetObject("BGCOLREMFO.AppearanceHeader.ForeColor"), System.Drawing.Color)
        Me.BGCOLREMFO.AppearanceHeader.GradientMode = CType(resources.GetObject("BGCOLREMFO.AppearanceHeader.GradientMode"), System.Drawing.Drawing2D.LinearGradientMode)
        Me.BGCOLREMFO.AppearanceHeader.Image = CType(resources.GetObject("BGCOLREMFO.AppearanceHeader.Image"), System.Drawing.Image)
        Me.BGCOLREMFO.AppearanceHeader.Options.UseBackColor = True
        Me.BGCOLREMFO.AppearanceHeader.Options.UseFont = True
        Me.BGCOLREMFO.AppearanceHeader.Options.UseForeColor = True
        Me.BGCOLREMFO.AppearanceHeader.Options.UseTextOptions = True
        Me.BGCOLREMFO.AppearanceHeader.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center
        Me.BGCOLREMFO.AppearanceHeader.TextOptions.VAlignment = DevExpress.Utils.VertAlignment.Center
        Me.BGCOLREMFO.AppearanceHeader.TextOptions.WordWrap = DevExpress.Utils.WordWrap.Wrap
        resources.ApplyResources(Me.BGCOLREMFO, "BGCOLREMFO")
        Me.BGCOLREMFO.Name = "BGCOLREMFO"
        Me.BGCOLREMFO.RowCount = 2
        '
        'FrmFournituresConsultMag
        '
        resources.ApplyResources(Me, "$this")
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.Wheat
        Me.Controls.Add(Me.GCExportConsultMag)
        Me.Controls.Add(Me.CboSerie)
        Me.Controls.Add(Me.BtnClose)
        Me.Controls.Add(Me.BtnSendMail)
        Me.Controls.Add(Me.LblTitre)
        Me.Name = "FrmFournituresConsultMag"
        CType(Me.GCExportConsultMag, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.ABGVExportConsultMag, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents LblTitre As System.Windows.Forms.Label
    Friend WithEvents BtnSendMail As System.Windows.Forms.Button
    Friend WithEvents BtnClose As System.Windows.Forms.Button
    Friend WithEvents CboSerie As System.Windows.Forms.ComboBox
    Private WithEvents GCExportConsultMag As DevExpress.XtraGrid.GridControl
    Private WithEvents ABGVExportConsultMag As DevExpress.XtraGrid.Views.BandedGrid.AdvBandedGridView
    Private WithEvents BGCOLVFOUMAT As DevExpress.XtraGrid.Views.BandedGrid.BandedGridColumn
    Private WithEvents BGCOLVFOUTYP As DevExpress.XtraGrid.Views.BandedGrid.BandedGridColumn
    Private WithEvents BGCOLVFOUUNITE As DevExpress.XtraGrid.Views.BandedGrid.BandedGridColumn
    Private WithEvents BGCOLVFOUCONSO As DevExpress.XtraGrid.Views.BandedGrid.BandedGridColumn
    Private WithEvents BGCOLPRIXNETFO As DevExpress.XtraGrid.Views.BandedGrid.BandedGridColumn
    Private WithEvents BGCOLREMFO As DevExpress.XtraGrid.Views.BandedGrid.BandedGridColumn
    Private WithEvents GBLine1 As DevExpress.XtraGrid.Views.BandedGrid.GridBand
    Private WithEvents GBLine2 As DevExpress.XtraGrid.Views.BandedGrid.GridBand
    Private WithEvents GBLine3 As DevExpress.XtraGrid.Views.BandedGrid.GridBand
    Private WithEvents GBLine4 As DevExpress.XtraGrid.Views.BandedGrid.GridBand
    Private WithEvents GBLine5 As DevExpress.XtraGrid.Views.BandedGrid.GridBand
    Private WithEvents BGCOLNFOUNUM As DevExpress.XtraGrid.Views.BandedGrid.BandedGridColumn
    Private WithEvents BGCOLVFOUREF As DevExpress.XtraGrid.Views.BandedGrid.BandedGridColumn
End Class
