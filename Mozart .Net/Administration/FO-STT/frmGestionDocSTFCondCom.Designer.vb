<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmGestionDocSTFCondCom
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(frmGestionDocSTFCondCom))
        Me.GColVTITLE = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.GCOLNIDDOCSTFCONDCOM = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.GColVFILE = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.GCDocSTFCondCom = New DevExpress.XtraGrid.GridControl()
        Me.GVDocSTFCondCom = New DevExpress.XtraGrid.Views.Grid.GridView()
        Me.GColDATECRE = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.GColVPATHFILE = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.GColNSTFGRPNUM = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.GrpActions = New System.Windows.Forms.GroupBox()
        Me.btnVisualiser = New System.Windows.Forms.Button()
        Me.BtnModifier = New System.Windows.Forms.Button()
        Me.BtnSupprLine = New System.Windows.Forms.Button()
        Me.BtnAddLine = New System.Windows.Forms.Button()
        Me.BtnQuit = New System.Windows.Forms.Button()
        Me.WBApercu = New System.Windows.Forms.WebBrowser()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.GrpApercu = New System.Windows.Forms.GroupBox()
        CType(Me.GCDocSTFCondCom, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.GVDocSTFCondCom, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.GrpActions.SuspendLayout()
        Me.GrpApercu.SuspendLayout()
        Me.SuspendLayout()
        '
        'GColVTITLE
        '
        resources.ApplyResources(Me.GColVTITLE, "GColVTITLE")
        Me.GColVTITLE.FieldName = "VTITLE"
        Me.GColVTITLE.Name = "GColVTITLE"
        '
        'GCOLNIDDOCSTFCONDCOM
        '
        resources.ApplyResources(Me.GCOLNIDDOCSTFCONDCOM, "GCOLNIDDOCSTFCONDCOM")
        Me.GCOLNIDDOCSTFCONDCOM.FieldName = "NIDDOCSTFCONDCOM"
        Me.GCOLNIDDOCSTFCONDCOM.Name = "GCOLNIDDOCSTFCONDCOM"
        '
        'GColVFILE
        '
        resources.ApplyResources(Me.GColVFILE, "GColVFILE")
        Me.GColVFILE.FieldName = "VFILE"
        Me.GColVFILE.Name = "GColVFILE"
        '
        'GCDocSTFCondCom
        '
        resources.ApplyResources(Me.GCDocSTFCondCom, "GCDocSTFCondCom")
        '
        '
        '
        Me.GCDocSTFCondCom.EmbeddedNavigator.AccessibleDescription = resources.GetString("GCDocSTFCondCom.EmbeddedNavigator.AccessibleDescription")
        Me.GCDocSTFCondCom.EmbeddedNavigator.AccessibleName = resources.GetString("GCDocSTFCondCom.EmbeddedNavigator.AccessibleName")
        Me.GCDocSTFCondCom.EmbeddedNavigator.AllowHtmlTextInToolTip = CType(resources.GetObject("GCDocSTFCondCom.EmbeddedNavigator.AllowHtmlTextInToolTip"), DevExpress.Utils.DefaultBoolean)
        Me.GCDocSTFCondCom.EmbeddedNavigator.Anchor = CType(resources.GetObject("GCDocSTFCondCom.EmbeddedNavigator.Anchor"), System.Windows.Forms.AnchorStyles)
        Me.GCDocSTFCondCom.EmbeddedNavigator.BackgroundImage = CType(resources.GetObject("GCDocSTFCondCom.EmbeddedNavigator.BackgroundImage"), System.Drawing.Image)
        Me.GCDocSTFCondCom.EmbeddedNavigator.BackgroundImageLayout = CType(resources.GetObject("GCDocSTFCondCom.EmbeddedNavigator.BackgroundImageLayout"), System.Windows.Forms.ImageLayout)
        Me.GCDocSTFCondCom.EmbeddedNavigator.ImeMode = CType(resources.GetObject("GCDocSTFCondCom.EmbeddedNavigator.ImeMode"), System.Windows.Forms.ImeMode)
        Me.GCDocSTFCondCom.EmbeddedNavigator.MaximumSize = CType(resources.GetObject("GCDocSTFCondCom.EmbeddedNavigator.MaximumSize"), System.Drawing.Size)
        Me.GCDocSTFCondCom.EmbeddedNavigator.TextLocation = CType(resources.GetObject("GCDocSTFCondCom.EmbeddedNavigator.TextLocation"), DevExpress.XtraEditors.NavigatorButtonsTextLocation)
        Me.GCDocSTFCondCom.EmbeddedNavigator.ToolTip = resources.GetString("GCDocSTFCondCom.EmbeddedNavigator.ToolTip")
        Me.GCDocSTFCondCom.EmbeddedNavigator.ToolTipIconType = CType(resources.GetObject("GCDocSTFCondCom.EmbeddedNavigator.ToolTipIconType"), DevExpress.Utils.ToolTipIconType)
        Me.GCDocSTFCondCom.EmbeddedNavigator.ToolTipTitle = resources.GetString("GCDocSTFCondCom.EmbeddedNavigator.ToolTipTitle")
        Me.GCDocSTFCondCom.MainView = Me.GVDocSTFCondCom
        Me.GCDocSTFCondCom.Name = "GCDocSTFCondCom"
        Me.GCDocSTFCondCom.ViewCollection.AddRange(New DevExpress.XtraGrid.Views.Base.BaseView() {Me.GVDocSTFCondCom})
        '
        'GVDocSTFCondCom
        '
        Me.GVDocSTFCondCom.Appearance.ColumnFilterButton.BackColor = CType(resources.GetObject("GVDocSTFCondCom.Appearance.ColumnFilterButton.BackColor"), System.Drawing.Color)
        Me.GVDocSTFCondCom.Appearance.ColumnFilterButton.BorderColor = CType(resources.GetObject("GVDocSTFCondCom.Appearance.ColumnFilterButton.BorderColor"), System.Drawing.Color)
        Me.GVDocSTFCondCom.Appearance.ColumnFilterButton.FontSizeDelta = CType(resources.GetObject("GVDocSTFCondCom.Appearance.ColumnFilterButton.FontSizeDelta"), Integer)
        Me.GVDocSTFCondCom.Appearance.ColumnFilterButton.FontStyleDelta = CType(resources.GetObject("GVDocSTFCondCom.Appearance.ColumnFilterButton.FontStyleDelta"), System.Drawing.FontStyle)
        Me.GVDocSTFCondCom.Appearance.ColumnFilterButton.ForeColor = CType(resources.GetObject("GVDocSTFCondCom.Appearance.ColumnFilterButton.ForeColor"), System.Drawing.Color)
        Me.GVDocSTFCondCom.Appearance.ColumnFilterButton.GradientMode = CType(resources.GetObject("GVDocSTFCondCom.Appearance.ColumnFilterButton.GradientMode"), System.Drawing.Drawing2D.LinearGradientMode)
        Me.GVDocSTFCondCom.Appearance.ColumnFilterButton.Image = CType(resources.GetObject("GVDocSTFCondCom.Appearance.ColumnFilterButton.Image"), System.Drawing.Image)
        Me.GVDocSTFCondCom.Appearance.ColumnFilterButton.Options.UseBackColor = True
        Me.GVDocSTFCondCom.Appearance.ColumnFilterButton.Options.UseBorderColor = True
        Me.GVDocSTFCondCom.Appearance.ColumnFilterButton.Options.UseForeColor = True
        Me.GVDocSTFCondCom.Appearance.ColumnFilterButtonActive.BackColor = CType(resources.GetObject("GVDocSTFCondCom.Appearance.ColumnFilterButtonActive.BackColor"), System.Drawing.Color)
        Me.GVDocSTFCondCom.Appearance.ColumnFilterButtonActive.BorderColor = CType(resources.GetObject("GVDocSTFCondCom.Appearance.ColumnFilterButtonActive.BorderColor"), System.Drawing.Color)
        Me.GVDocSTFCondCom.Appearance.ColumnFilterButtonActive.FontSizeDelta = CType(resources.GetObject("GVDocSTFCondCom.Appearance.ColumnFilterButtonActive.FontSizeDelta"), Integer)
        Me.GVDocSTFCondCom.Appearance.ColumnFilterButtonActive.FontStyleDelta = CType(resources.GetObject("GVDocSTFCondCom.Appearance.ColumnFilterButtonActive.FontStyleDelta"), System.Drawing.FontStyle)
        Me.GVDocSTFCondCom.Appearance.ColumnFilterButtonActive.ForeColor = CType(resources.GetObject("GVDocSTFCondCom.Appearance.ColumnFilterButtonActive.ForeColor"), System.Drawing.Color)
        Me.GVDocSTFCondCom.Appearance.ColumnFilterButtonActive.GradientMode = CType(resources.GetObject("GVDocSTFCondCom.Appearance.ColumnFilterButtonActive.GradientMode"), System.Drawing.Drawing2D.LinearGradientMode)
        Me.GVDocSTFCondCom.Appearance.ColumnFilterButtonActive.Image = CType(resources.GetObject("GVDocSTFCondCom.Appearance.ColumnFilterButtonActive.Image"), System.Drawing.Image)
        Me.GVDocSTFCondCom.Appearance.ColumnFilterButtonActive.Options.UseBackColor = True
        Me.GVDocSTFCondCom.Appearance.ColumnFilterButtonActive.Options.UseBorderColor = True
        Me.GVDocSTFCondCom.Appearance.ColumnFilterButtonActive.Options.UseForeColor = True
        Me.GVDocSTFCondCom.Appearance.Empty.BackColor = CType(resources.GetObject("GVDocSTFCondCom.Appearance.Empty.BackColor"), System.Drawing.Color)
        Me.GVDocSTFCondCom.Appearance.Empty.BackColor2 = CType(resources.GetObject("GVDocSTFCondCom.Appearance.Empty.BackColor2"), System.Drawing.Color)
        Me.GVDocSTFCondCom.Appearance.Empty.FontSizeDelta = CType(resources.GetObject("GVDocSTFCondCom.Appearance.Empty.FontSizeDelta"), Integer)
        Me.GVDocSTFCondCom.Appearance.Empty.FontStyleDelta = CType(resources.GetObject("GVDocSTFCondCom.Appearance.Empty.FontStyleDelta"), System.Drawing.FontStyle)
        Me.GVDocSTFCondCom.Appearance.Empty.GradientMode = CType(resources.GetObject("GVDocSTFCondCom.Appearance.Empty.GradientMode"), System.Drawing.Drawing2D.LinearGradientMode)
        Me.GVDocSTFCondCom.Appearance.Empty.Image = CType(resources.GetObject("GVDocSTFCondCom.Appearance.Empty.Image"), System.Drawing.Image)
        Me.GVDocSTFCondCom.Appearance.Empty.Options.UseBackColor = True
        Me.GVDocSTFCondCom.Appearance.EvenRow.BackColor = CType(resources.GetObject("GVDocSTFCondCom.Appearance.EvenRow.BackColor"), System.Drawing.Color)
        Me.GVDocSTFCondCom.Appearance.EvenRow.BorderColor = CType(resources.GetObject("GVDocSTFCondCom.Appearance.EvenRow.BorderColor"), System.Drawing.Color)
        Me.GVDocSTFCondCom.Appearance.EvenRow.FontSizeDelta = CType(resources.GetObject("GVDocSTFCondCom.Appearance.EvenRow.FontSizeDelta"), Integer)
        Me.GVDocSTFCondCom.Appearance.EvenRow.FontStyleDelta = CType(resources.GetObject("GVDocSTFCondCom.Appearance.EvenRow.FontStyleDelta"), System.Drawing.FontStyle)
        Me.GVDocSTFCondCom.Appearance.EvenRow.ForeColor = CType(resources.GetObject("GVDocSTFCondCom.Appearance.EvenRow.ForeColor"), System.Drawing.Color)
        Me.GVDocSTFCondCom.Appearance.EvenRow.GradientMode = CType(resources.GetObject("GVDocSTFCondCom.Appearance.EvenRow.GradientMode"), System.Drawing.Drawing2D.LinearGradientMode)
        Me.GVDocSTFCondCom.Appearance.EvenRow.Image = CType(resources.GetObject("GVDocSTFCondCom.Appearance.EvenRow.Image"), System.Drawing.Image)
        Me.GVDocSTFCondCom.Appearance.EvenRow.Options.UseBackColor = True
        Me.GVDocSTFCondCom.Appearance.EvenRow.Options.UseBorderColor = True
        Me.GVDocSTFCondCom.Appearance.EvenRow.Options.UseForeColor = True
        Me.GVDocSTFCondCom.Appearance.FilterCloseButton.BackColor = CType(resources.GetObject("GVDocSTFCondCom.Appearance.FilterCloseButton.BackColor"), System.Drawing.Color)
        Me.GVDocSTFCondCom.Appearance.FilterCloseButton.BorderColor = CType(resources.GetObject("GVDocSTFCondCom.Appearance.FilterCloseButton.BorderColor"), System.Drawing.Color)
        Me.GVDocSTFCondCom.Appearance.FilterCloseButton.FontSizeDelta = CType(resources.GetObject("GVDocSTFCondCom.Appearance.FilterCloseButton.FontSizeDelta"), Integer)
        Me.GVDocSTFCondCom.Appearance.FilterCloseButton.FontStyleDelta = CType(resources.GetObject("GVDocSTFCondCom.Appearance.FilterCloseButton.FontStyleDelta"), System.Drawing.FontStyle)
        Me.GVDocSTFCondCom.Appearance.FilterCloseButton.ForeColor = CType(resources.GetObject("GVDocSTFCondCom.Appearance.FilterCloseButton.ForeColor"), System.Drawing.Color)
        Me.GVDocSTFCondCom.Appearance.FilterCloseButton.GradientMode = CType(resources.GetObject("GVDocSTFCondCom.Appearance.FilterCloseButton.GradientMode"), System.Drawing.Drawing2D.LinearGradientMode)
        Me.GVDocSTFCondCom.Appearance.FilterCloseButton.Image = CType(resources.GetObject("GVDocSTFCondCom.Appearance.FilterCloseButton.Image"), System.Drawing.Image)
        Me.GVDocSTFCondCom.Appearance.FilterCloseButton.Options.UseBackColor = True
        Me.GVDocSTFCondCom.Appearance.FilterCloseButton.Options.UseBorderColor = True
        Me.GVDocSTFCondCom.Appearance.FilterCloseButton.Options.UseForeColor = True
        Me.GVDocSTFCondCom.Appearance.FilterPanel.BackColor = CType(resources.GetObject("GVDocSTFCondCom.Appearance.FilterPanel.BackColor"), System.Drawing.Color)
        Me.GVDocSTFCondCom.Appearance.FilterPanel.BackColor2 = CType(resources.GetObject("GVDocSTFCondCom.Appearance.FilterPanel.BackColor2"), System.Drawing.Color)
        Me.GVDocSTFCondCom.Appearance.FilterPanel.FontSizeDelta = CType(resources.GetObject("GVDocSTFCondCom.Appearance.FilterPanel.FontSizeDelta"), Integer)
        Me.GVDocSTFCondCom.Appearance.FilterPanel.FontStyleDelta = CType(resources.GetObject("GVDocSTFCondCom.Appearance.FilterPanel.FontStyleDelta"), System.Drawing.FontStyle)
        Me.GVDocSTFCondCom.Appearance.FilterPanel.ForeColor = CType(resources.GetObject("GVDocSTFCondCom.Appearance.FilterPanel.ForeColor"), System.Drawing.Color)
        Me.GVDocSTFCondCom.Appearance.FilterPanel.GradientMode = CType(resources.GetObject("GVDocSTFCondCom.Appearance.FilterPanel.GradientMode"), System.Drawing.Drawing2D.LinearGradientMode)
        Me.GVDocSTFCondCom.Appearance.FilterPanel.Image = CType(resources.GetObject("GVDocSTFCondCom.Appearance.FilterPanel.Image"), System.Drawing.Image)
        Me.GVDocSTFCondCom.Appearance.FilterPanel.Options.UseBackColor = True
        Me.GVDocSTFCondCom.Appearance.FilterPanel.Options.UseForeColor = True
        Me.GVDocSTFCondCom.Appearance.FixedLine.BackColor = CType(resources.GetObject("GVDocSTFCondCom.Appearance.FixedLine.BackColor"), System.Drawing.Color)
        Me.GVDocSTFCondCom.Appearance.FixedLine.FontSizeDelta = CType(resources.GetObject("GVDocSTFCondCom.Appearance.FixedLine.FontSizeDelta"), Integer)
        Me.GVDocSTFCondCom.Appearance.FixedLine.FontStyleDelta = CType(resources.GetObject("GVDocSTFCondCom.Appearance.FixedLine.FontStyleDelta"), System.Drawing.FontStyle)
        Me.GVDocSTFCondCom.Appearance.FixedLine.GradientMode = CType(resources.GetObject("GVDocSTFCondCom.Appearance.FixedLine.GradientMode"), System.Drawing.Drawing2D.LinearGradientMode)
        Me.GVDocSTFCondCom.Appearance.FixedLine.Image = CType(resources.GetObject("GVDocSTFCondCom.Appearance.FixedLine.Image"), System.Drawing.Image)
        Me.GVDocSTFCondCom.Appearance.FixedLine.Options.UseBackColor = True
        Me.GVDocSTFCondCom.Appearance.FocusedCell.BackColor = CType(resources.GetObject("GVDocSTFCondCom.Appearance.FocusedCell.BackColor"), System.Drawing.Color)
        Me.GVDocSTFCondCom.Appearance.FocusedCell.FontSizeDelta = CType(resources.GetObject("GVDocSTFCondCom.Appearance.FocusedCell.FontSizeDelta"), Integer)
        Me.GVDocSTFCondCom.Appearance.FocusedCell.FontStyleDelta = CType(resources.GetObject("GVDocSTFCondCom.Appearance.FocusedCell.FontStyleDelta"), System.Drawing.FontStyle)
        Me.GVDocSTFCondCom.Appearance.FocusedCell.ForeColor = CType(resources.GetObject("GVDocSTFCondCom.Appearance.FocusedCell.ForeColor"), System.Drawing.Color)
        Me.GVDocSTFCondCom.Appearance.FocusedCell.GradientMode = CType(resources.GetObject("GVDocSTFCondCom.Appearance.FocusedCell.GradientMode"), System.Drawing.Drawing2D.LinearGradientMode)
        Me.GVDocSTFCondCom.Appearance.FocusedCell.Image = CType(resources.GetObject("GVDocSTFCondCom.Appearance.FocusedCell.Image"), System.Drawing.Image)
        Me.GVDocSTFCondCom.Appearance.FocusedCell.Options.UseBackColor = True
        Me.GVDocSTFCondCom.Appearance.FocusedCell.Options.UseForeColor = True
        Me.GVDocSTFCondCom.Appearance.FocusedRow.BackColor = CType(resources.GetObject("GVDocSTFCondCom.Appearance.FocusedRow.BackColor"), System.Drawing.Color)
        Me.GVDocSTFCondCom.Appearance.FocusedRow.FontSizeDelta = CType(resources.GetObject("GVDocSTFCondCom.Appearance.FocusedRow.FontSizeDelta"), Integer)
        Me.GVDocSTFCondCom.Appearance.FocusedRow.FontStyleDelta = CType(resources.GetObject("GVDocSTFCondCom.Appearance.FocusedRow.FontStyleDelta"), System.Drawing.FontStyle)
        Me.GVDocSTFCondCom.Appearance.FocusedRow.ForeColor = CType(resources.GetObject("GVDocSTFCondCom.Appearance.FocusedRow.ForeColor"), System.Drawing.Color)
        Me.GVDocSTFCondCom.Appearance.FocusedRow.GradientMode = CType(resources.GetObject("GVDocSTFCondCom.Appearance.FocusedRow.GradientMode"), System.Drawing.Drawing2D.LinearGradientMode)
        Me.GVDocSTFCondCom.Appearance.FocusedRow.Image = CType(resources.GetObject("GVDocSTFCondCom.Appearance.FocusedRow.Image"), System.Drawing.Image)
        Me.GVDocSTFCondCom.Appearance.FocusedRow.Options.UseBackColor = True
        Me.GVDocSTFCondCom.Appearance.FocusedRow.Options.UseForeColor = True
        Me.GVDocSTFCondCom.Appearance.FooterPanel.BackColor = CType(resources.GetObject("GVDocSTFCondCom.Appearance.FooterPanel.BackColor"), System.Drawing.Color)
        Me.GVDocSTFCondCom.Appearance.FooterPanel.BorderColor = CType(resources.GetObject("GVDocSTFCondCom.Appearance.FooterPanel.BorderColor"), System.Drawing.Color)
        Me.GVDocSTFCondCom.Appearance.FooterPanel.FontSizeDelta = CType(resources.GetObject("GVDocSTFCondCom.Appearance.FooterPanel.FontSizeDelta"), Integer)
        Me.GVDocSTFCondCom.Appearance.FooterPanel.FontStyleDelta = CType(resources.GetObject("GVDocSTFCondCom.Appearance.FooterPanel.FontStyleDelta"), System.Drawing.FontStyle)
        Me.GVDocSTFCondCom.Appearance.FooterPanel.ForeColor = CType(resources.GetObject("GVDocSTFCondCom.Appearance.FooterPanel.ForeColor"), System.Drawing.Color)
        Me.GVDocSTFCondCom.Appearance.FooterPanel.GradientMode = CType(resources.GetObject("GVDocSTFCondCom.Appearance.FooterPanel.GradientMode"), System.Drawing.Drawing2D.LinearGradientMode)
        Me.GVDocSTFCondCom.Appearance.FooterPanel.Image = CType(resources.GetObject("GVDocSTFCondCom.Appearance.FooterPanel.Image"), System.Drawing.Image)
        Me.GVDocSTFCondCom.Appearance.FooterPanel.Options.UseBackColor = True
        Me.GVDocSTFCondCom.Appearance.FooterPanel.Options.UseBorderColor = True
        Me.GVDocSTFCondCom.Appearance.FooterPanel.Options.UseForeColor = True
        Me.GVDocSTFCondCom.Appearance.GroupButton.BackColor = CType(resources.GetObject("GVDocSTFCondCom.Appearance.GroupButton.BackColor"), System.Drawing.Color)
        Me.GVDocSTFCondCom.Appearance.GroupButton.BorderColor = CType(resources.GetObject("GVDocSTFCondCom.Appearance.GroupButton.BorderColor"), System.Drawing.Color)
        Me.GVDocSTFCondCom.Appearance.GroupButton.FontSizeDelta = CType(resources.GetObject("GVDocSTFCondCom.Appearance.GroupButton.FontSizeDelta"), Integer)
        Me.GVDocSTFCondCom.Appearance.GroupButton.FontStyleDelta = CType(resources.GetObject("GVDocSTFCondCom.Appearance.GroupButton.FontStyleDelta"), System.Drawing.FontStyle)
        Me.GVDocSTFCondCom.Appearance.GroupButton.GradientMode = CType(resources.GetObject("GVDocSTFCondCom.Appearance.GroupButton.GradientMode"), System.Drawing.Drawing2D.LinearGradientMode)
        Me.GVDocSTFCondCom.Appearance.GroupButton.Image = CType(resources.GetObject("GVDocSTFCondCom.Appearance.GroupButton.Image"), System.Drawing.Image)
        Me.GVDocSTFCondCom.Appearance.GroupButton.Options.UseBackColor = True
        Me.GVDocSTFCondCom.Appearance.GroupButton.Options.UseBorderColor = True
        Me.GVDocSTFCondCom.Appearance.GroupFooter.BackColor = CType(resources.GetObject("GVDocSTFCondCom.Appearance.GroupFooter.BackColor"), System.Drawing.Color)
        Me.GVDocSTFCondCom.Appearance.GroupFooter.BorderColor = CType(resources.GetObject("GVDocSTFCondCom.Appearance.GroupFooter.BorderColor"), System.Drawing.Color)
        Me.GVDocSTFCondCom.Appearance.GroupFooter.FontSizeDelta = CType(resources.GetObject("GVDocSTFCondCom.Appearance.GroupFooter.FontSizeDelta"), Integer)
        Me.GVDocSTFCondCom.Appearance.GroupFooter.FontStyleDelta = CType(resources.GetObject("GVDocSTFCondCom.Appearance.GroupFooter.FontStyleDelta"), System.Drawing.FontStyle)
        Me.GVDocSTFCondCom.Appearance.GroupFooter.ForeColor = CType(resources.GetObject("GVDocSTFCondCom.Appearance.GroupFooter.ForeColor"), System.Drawing.Color)
        Me.GVDocSTFCondCom.Appearance.GroupFooter.GradientMode = CType(resources.GetObject("GVDocSTFCondCom.Appearance.GroupFooter.GradientMode"), System.Drawing.Drawing2D.LinearGradientMode)
        Me.GVDocSTFCondCom.Appearance.GroupFooter.Image = CType(resources.GetObject("GVDocSTFCondCom.Appearance.GroupFooter.Image"), System.Drawing.Image)
        Me.GVDocSTFCondCom.Appearance.GroupFooter.Options.UseBackColor = True
        Me.GVDocSTFCondCom.Appearance.GroupFooter.Options.UseBorderColor = True
        Me.GVDocSTFCondCom.Appearance.GroupFooter.Options.UseForeColor = True
        Me.GVDocSTFCondCom.Appearance.GroupPanel.BackColor = CType(resources.GetObject("GVDocSTFCondCom.Appearance.GroupPanel.BackColor"), System.Drawing.Color)
        Me.GVDocSTFCondCom.Appearance.GroupPanel.BackColor2 = CType(resources.GetObject("GVDocSTFCondCom.Appearance.GroupPanel.BackColor2"), System.Drawing.Color)
        Me.GVDocSTFCondCom.Appearance.GroupPanel.FontSizeDelta = CType(resources.GetObject("GVDocSTFCondCom.Appearance.GroupPanel.FontSizeDelta"), Integer)
        Me.GVDocSTFCondCom.Appearance.GroupPanel.FontStyleDelta = CType(resources.GetObject("GVDocSTFCondCom.Appearance.GroupPanel.FontStyleDelta"), System.Drawing.FontStyle)
        Me.GVDocSTFCondCom.Appearance.GroupPanel.ForeColor = CType(resources.GetObject("GVDocSTFCondCom.Appearance.GroupPanel.ForeColor"), System.Drawing.Color)
        Me.GVDocSTFCondCom.Appearance.GroupPanel.GradientMode = CType(resources.GetObject("GVDocSTFCondCom.Appearance.GroupPanel.GradientMode"), System.Drawing.Drawing2D.LinearGradientMode)
        Me.GVDocSTFCondCom.Appearance.GroupPanel.Image = CType(resources.GetObject("GVDocSTFCondCom.Appearance.GroupPanel.Image"), System.Drawing.Image)
        Me.GVDocSTFCondCom.Appearance.GroupPanel.Options.UseBackColor = True
        Me.GVDocSTFCondCom.Appearance.GroupPanel.Options.UseForeColor = True
        Me.GVDocSTFCondCom.Appearance.GroupRow.BackColor = CType(resources.GetObject("GVDocSTFCondCom.Appearance.GroupRow.BackColor"), System.Drawing.Color)
        Me.GVDocSTFCondCom.Appearance.GroupRow.BorderColor = CType(resources.GetObject("GVDocSTFCondCom.Appearance.GroupRow.BorderColor"), System.Drawing.Color)
        Me.GVDocSTFCondCom.Appearance.GroupRow.FontSizeDelta = CType(resources.GetObject("GVDocSTFCondCom.Appearance.GroupRow.FontSizeDelta"), Integer)
        Me.GVDocSTFCondCom.Appearance.GroupRow.FontStyleDelta = CType(resources.GetObject("GVDocSTFCondCom.Appearance.GroupRow.FontStyleDelta"), System.Drawing.FontStyle)
        Me.GVDocSTFCondCom.Appearance.GroupRow.ForeColor = CType(resources.GetObject("GVDocSTFCondCom.Appearance.GroupRow.ForeColor"), System.Drawing.Color)
        Me.GVDocSTFCondCom.Appearance.GroupRow.GradientMode = CType(resources.GetObject("GVDocSTFCondCom.Appearance.GroupRow.GradientMode"), System.Drawing.Drawing2D.LinearGradientMode)
        Me.GVDocSTFCondCom.Appearance.GroupRow.Image = CType(resources.GetObject("GVDocSTFCondCom.Appearance.GroupRow.Image"), System.Drawing.Image)
        Me.GVDocSTFCondCom.Appearance.GroupRow.Options.UseBackColor = True
        Me.GVDocSTFCondCom.Appearance.GroupRow.Options.UseBorderColor = True
        Me.GVDocSTFCondCom.Appearance.GroupRow.Options.UseForeColor = True
        Me.GVDocSTFCondCom.Appearance.HeaderPanel.BackColor = CType(resources.GetObject("GVDocSTFCondCom.Appearance.HeaderPanel.BackColor"), System.Drawing.Color)
        Me.GVDocSTFCondCom.Appearance.HeaderPanel.BorderColor = CType(resources.GetObject("GVDocSTFCondCom.Appearance.HeaderPanel.BorderColor"), System.Drawing.Color)
        Me.GVDocSTFCondCom.Appearance.HeaderPanel.Font = CType(resources.GetObject("GVDocSTFCondCom.Appearance.HeaderPanel.Font"), System.Drawing.Font)
        Me.GVDocSTFCondCom.Appearance.HeaderPanel.FontSizeDelta = CType(resources.GetObject("GVDocSTFCondCom.Appearance.HeaderPanel.FontSizeDelta"), Integer)
        Me.GVDocSTFCondCom.Appearance.HeaderPanel.FontStyleDelta = CType(resources.GetObject("GVDocSTFCondCom.Appearance.HeaderPanel.FontStyleDelta"), System.Drawing.FontStyle)
        Me.GVDocSTFCondCom.Appearance.HeaderPanel.ForeColor = CType(resources.GetObject("GVDocSTFCondCom.Appearance.HeaderPanel.ForeColor"), System.Drawing.Color)
        Me.GVDocSTFCondCom.Appearance.HeaderPanel.GradientMode = CType(resources.GetObject("GVDocSTFCondCom.Appearance.HeaderPanel.GradientMode"), System.Drawing.Drawing2D.LinearGradientMode)
        Me.GVDocSTFCondCom.Appearance.HeaderPanel.Image = CType(resources.GetObject("GVDocSTFCondCom.Appearance.HeaderPanel.Image"), System.Drawing.Image)
        Me.GVDocSTFCondCom.Appearance.HeaderPanel.Options.UseBackColor = True
        Me.GVDocSTFCondCom.Appearance.HeaderPanel.Options.UseBorderColor = True
        Me.GVDocSTFCondCom.Appearance.HeaderPanel.Options.UseFont = True
        Me.GVDocSTFCondCom.Appearance.HeaderPanel.Options.UseForeColor = True
        Me.GVDocSTFCondCom.Appearance.HeaderPanel.Options.UseTextOptions = True
        Me.GVDocSTFCondCom.Appearance.HeaderPanel.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center
        Me.GVDocSTFCondCom.Appearance.HeaderPanel.TextOptions.VAlignment = DevExpress.Utils.VertAlignment.Center
        Me.GVDocSTFCondCom.Appearance.HideSelectionRow.BackColor = CType(resources.GetObject("GVDocSTFCondCom.Appearance.HideSelectionRow.BackColor"), System.Drawing.Color)
        Me.GVDocSTFCondCom.Appearance.HideSelectionRow.FontSizeDelta = CType(resources.GetObject("GVDocSTFCondCom.Appearance.HideSelectionRow.FontSizeDelta"), Integer)
        Me.GVDocSTFCondCom.Appearance.HideSelectionRow.FontStyleDelta = CType(resources.GetObject("GVDocSTFCondCom.Appearance.HideSelectionRow.FontStyleDelta"), System.Drawing.FontStyle)
        Me.GVDocSTFCondCom.Appearance.HideSelectionRow.ForeColor = CType(resources.GetObject("GVDocSTFCondCom.Appearance.HideSelectionRow.ForeColor"), System.Drawing.Color)
        Me.GVDocSTFCondCom.Appearance.HideSelectionRow.GradientMode = CType(resources.GetObject("GVDocSTFCondCom.Appearance.HideSelectionRow.GradientMode"), System.Drawing.Drawing2D.LinearGradientMode)
        Me.GVDocSTFCondCom.Appearance.HideSelectionRow.Image = CType(resources.GetObject("GVDocSTFCondCom.Appearance.HideSelectionRow.Image"), System.Drawing.Image)
        Me.GVDocSTFCondCom.Appearance.HideSelectionRow.Options.UseBackColor = True
        Me.GVDocSTFCondCom.Appearance.HideSelectionRow.Options.UseForeColor = True
        Me.GVDocSTFCondCom.Appearance.HorzLine.BackColor = CType(resources.GetObject("GVDocSTFCondCom.Appearance.HorzLine.BackColor"), System.Drawing.Color)
        Me.GVDocSTFCondCom.Appearance.HorzLine.BorderColor = CType(resources.GetObject("GVDocSTFCondCom.Appearance.HorzLine.BorderColor"), System.Drawing.Color)
        Me.GVDocSTFCondCom.Appearance.HorzLine.FontSizeDelta = CType(resources.GetObject("GVDocSTFCondCom.Appearance.HorzLine.FontSizeDelta"), Integer)
        Me.GVDocSTFCondCom.Appearance.HorzLine.FontStyleDelta = CType(resources.GetObject("GVDocSTFCondCom.Appearance.HorzLine.FontStyleDelta"), System.Drawing.FontStyle)
        Me.GVDocSTFCondCom.Appearance.HorzLine.GradientMode = CType(resources.GetObject("GVDocSTFCondCom.Appearance.HorzLine.GradientMode"), System.Drawing.Drawing2D.LinearGradientMode)
        Me.GVDocSTFCondCom.Appearance.HorzLine.Image = CType(resources.GetObject("GVDocSTFCondCom.Appearance.HorzLine.Image"), System.Drawing.Image)
        Me.GVDocSTFCondCom.Appearance.HorzLine.Options.UseBackColor = True
        Me.GVDocSTFCondCom.Appearance.HorzLine.Options.UseBorderColor = True
        Me.GVDocSTFCondCom.Appearance.OddRow.BackColor = CType(resources.GetObject("GVDocSTFCondCom.Appearance.OddRow.BackColor"), System.Drawing.Color)
        Me.GVDocSTFCondCom.Appearance.OddRow.BorderColor = CType(resources.GetObject("GVDocSTFCondCom.Appearance.OddRow.BorderColor"), System.Drawing.Color)
        Me.GVDocSTFCondCom.Appearance.OddRow.FontSizeDelta = CType(resources.GetObject("GVDocSTFCondCom.Appearance.OddRow.FontSizeDelta"), Integer)
        Me.GVDocSTFCondCom.Appearance.OddRow.FontStyleDelta = CType(resources.GetObject("GVDocSTFCondCom.Appearance.OddRow.FontStyleDelta"), System.Drawing.FontStyle)
        Me.GVDocSTFCondCom.Appearance.OddRow.ForeColor = CType(resources.GetObject("GVDocSTFCondCom.Appearance.OddRow.ForeColor"), System.Drawing.Color)
        Me.GVDocSTFCondCom.Appearance.OddRow.GradientMode = CType(resources.GetObject("GVDocSTFCondCom.Appearance.OddRow.GradientMode"), System.Drawing.Drawing2D.LinearGradientMode)
        Me.GVDocSTFCondCom.Appearance.OddRow.Image = CType(resources.GetObject("GVDocSTFCondCom.Appearance.OddRow.Image"), System.Drawing.Image)
        Me.GVDocSTFCondCom.Appearance.OddRow.Options.UseBackColor = True
        Me.GVDocSTFCondCom.Appearance.OddRow.Options.UseBorderColor = True
        Me.GVDocSTFCondCom.Appearance.OddRow.Options.UseForeColor = True
        Me.GVDocSTFCondCom.Appearance.Preview.BackColor = CType(resources.GetObject("GVDocSTFCondCom.Appearance.Preview.BackColor"), System.Drawing.Color)
        Me.GVDocSTFCondCom.Appearance.Preview.Font = CType(resources.GetObject("GVDocSTFCondCom.Appearance.Preview.Font"), System.Drawing.Font)
        Me.GVDocSTFCondCom.Appearance.Preview.FontSizeDelta = CType(resources.GetObject("GVDocSTFCondCom.Appearance.Preview.FontSizeDelta"), Integer)
        Me.GVDocSTFCondCom.Appearance.Preview.FontStyleDelta = CType(resources.GetObject("GVDocSTFCondCom.Appearance.Preview.FontStyleDelta"), System.Drawing.FontStyle)
        Me.GVDocSTFCondCom.Appearance.Preview.ForeColor = CType(resources.GetObject("GVDocSTFCondCom.Appearance.Preview.ForeColor"), System.Drawing.Color)
        Me.GVDocSTFCondCom.Appearance.Preview.GradientMode = CType(resources.GetObject("GVDocSTFCondCom.Appearance.Preview.GradientMode"), System.Drawing.Drawing2D.LinearGradientMode)
        Me.GVDocSTFCondCom.Appearance.Preview.Image = CType(resources.GetObject("GVDocSTFCondCom.Appearance.Preview.Image"), System.Drawing.Image)
        Me.GVDocSTFCondCom.Appearance.Preview.Options.UseBackColor = True
        Me.GVDocSTFCondCom.Appearance.Preview.Options.UseFont = True
        Me.GVDocSTFCondCom.Appearance.Preview.Options.UseForeColor = True
        Me.GVDocSTFCondCom.Appearance.Row.BackColor = CType(resources.GetObject("GVDocSTFCondCom.Appearance.Row.BackColor"), System.Drawing.Color)
        Me.GVDocSTFCondCom.Appearance.Row.FontSizeDelta = CType(resources.GetObject("GVDocSTFCondCom.Appearance.Row.FontSizeDelta"), Integer)
        Me.GVDocSTFCondCom.Appearance.Row.FontStyleDelta = CType(resources.GetObject("GVDocSTFCondCom.Appearance.Row.FontStyleDelta"), System.Drawing.FontStyle)
        Me.GVDocSTFCondCom.Appearance.Row.ForeColor = CType(resources.GetObject("GVDocSTFCondCom.Appearance.Row.ForeColor"), System.Drawing.Color)
        Me.GVDocSTFCondCom.Appearance.Row.GradientMode = CType(resources.GetObject("GVDocSTFCondCom.Appearance.Row.GradientMode"), System.Drawing.Drawing2D.LinearGradientMode)
        Me.GVDocSTFCondCom.Appearance.Row.Image = CType(resources.GetObject("GVDocSTFCondCom.Appearance.Row.Image"), System.Drawing.Image)
        Me.GVDocSTFCondCom.Appearance.Row.Options.UseBackColor = True
        Me.GVDocSTFCondCom.Appearance.Row.Options.UseForeColor = True
        Me.GVDocSTFCondCom.Appearance.RowSeparator.BackColor = CType(resources.GetObject("GVDocSTFCondCom.Appearance.RowSeparator.BackColor"), System.Drawing.Color)
        Me.GVDocSTFCondCom.Appearance.RowSeparator.BackColor2 = CType(resources.GetObject("GVDocSTFCondCom.Appearance.RowSeparator.BackColor2"), System.Drawing.Color)
        Me.GVDocSTFCondCom.Appearance.RowSeparator.FontSizeDelta = CType(resources.GetObject("GVDocSTFCondCom.Appearance.RowSeparator.FontSizeDelta"), Integer)
        Me.GVDocSTFCondCom.Appearance.RowSeparator.FontStyleDelta = CType(resources.GetObject("GVDocSTFCondCom.Appearance.RowSeparator.FontStyleDelta"), System.Drawing.FontStyle)
        Me.GVDocSTFCondCom.Appearance.RowSeparator.GradientMode = CType(resources.GetObject("GVDocSTFCondCom.Appearance.RowSeparator.GradientMode"), System.Drawing.Drawing2D.LinearGradientMode)
        Me.GVDocSTFCondCom.Appearance.RowSeparator.Image = CType(resources.GetObject("GVDocSTFCondCom.Appearance.RowSeparator.Image"), System.Drawing.Image)
        Me.GVDocSTFCondCom.Appearance.RowSeparator.Options.UseBackColor = True
        Me.GVDocSTFCondCom.Appearance.SelectedRow.BackColor = CType(resources.GetObject("GVDocSTFCondCom.Appearance.SelectedRow.BackColor"), System.Drawing.Color)
        Me.GVDocSTFCondCom.Appearance.SelectedRow.FontSizeDelta = CType(resources.GetObject("GVDocSTFCondCom.Appearance.SelectedRow.FontSizeDelta"), Integer)
        Me.GVDocSTFCondCom.Appearance.SelectedRow.FontStyleDelta = CType(resources.GetObject("GVDocSTFCondCom.Appearance.SelectedRow.FontStyleDelta"), System.Drawing.FontStyle)
        Me.GVDocSTFCondCom.Appearance.SelectedRow.ForeColor = CType(resources.GetObject("GVDocSTFCondCom.Appearance.SelectedRow.ForeColor"), System.Drawing.Color)
        Me.GVDocSTFCondCom.Appearance.SelectedRow.GradientMode = CType(resources.GetObject("GVDocSTFCondCom.Appearance.SelectedRow.GradientMode"), System.Drawing.Drawing2D.LinearGradientMode)
        Me.GVDocSTFCondCom.Appearance.SelectedRow.Image = CType(resources.GetObject("GVDocSTFCondCom.Appearance.SelectedRow.Image"), System.Drawing.Image)
        Me.GVDocSTFCondCom.Appearance.SelectedRow.Options.UseBackColor = True
        Me.GVDocSTFCondCom.Appearance.SelectedRow.Options.UseForeColor = True
        Me.GVDocSTFCondCom.Appearance.TopNewRow.BackColor = CType(resources.GetObject("GVDocSTFCondCom.Appearance.TopNewRow.BackColor"), System.Drawing.Color)
        Me.GVDocSTFCondCom.Appearance.TopNewRow.FontSizeDelta = CType(resources.GetObject("GVDocSTFCondCom.Appearance.TopNewRow.FontSizeDelta"), Integer)
        Me.GVDocSTFCondCom.Appearance.TopNewRow.FontStyleDelta = CType(resources.GetObject("GVDocSTFCondCom.Appearance.TopNewRow.FontStyleDelta"), System.Drawing.FontStyle)
        Me.GVDocSTFCondCom.Appearance.TopNewRow.GradientMode = CType(resources.GetObject("GVDocSTFCondCom.Appearance.TopNewRow.GradientMode"), System.Drawing.Drawing2D.LinearGradientMode)
        Me.GVDocSTFCondCom.Appearance.TopNewRow.Image = CType(resources.GetObject("GVDocSTFCondCom.Appearance.TopNewRow.Image"), System.Drawing.Image)
        Me.GVDocSTFCondCom.Appearance.TopNewRow.Options.UseBackColor = True
        Me.GVDocSTFCondCom.Appearance.VertLine.BackColor = CType(resources.GetObject("GVDocSTFCondCom.Appearance.VertLine.BackColor"), System.Drawing.Color)
        Me.GVDocSTFCondCom.Appearance.VertLine.BorderColor = CType(resources.GetObject("GVDocSTFCondCom.Appearance.VertLine.BorderColor"), System.Drawing.Color)
        Me.GVDocSTFCondCom.Appearance.VertLine.FontSizeDelta = CType(resources.GetObject("GVDocSTFCondCom.Appearance.VertLine.FontSizeDelta"), Integer)
        Me.GVDocSTFCondCom.Appearance.VertLine.FontStyleDelta = CType(resources.GetObject("GVDocSTFCondCom.Appearance.VertLine.FontStyleDelta"), System.Drawing.FontStyle)
        Me.GVDocSTFCondCom.Appearance.VertLine.GradientMode = CType(resources.GetObject("GVDocSTFCondCom.Appearance.VertLine.GradientMode"), System.Drawing.Drawing2D.LinearGradientMode)
        Me.GVDocSTFCondCom.Appearance.VertLine.Image = CType(resources.GetObject("GVDocSTFCondCom.Appearance.VertLine.Image"), System.Drawing.Image)
        Me.GVDocSTFCondCom.Appearance.VertLine.Options.UseBackColor = True
        Me.GVDocSTFCondCom.Appearance.VertLine.Options.UseBorderColor = True
        resources.ApplyResources(Me.GVDocSTFCondCom, "GVDocSTFCondCom")
        Me.GVDocSTFCondCom.Columns.AddRange(New DevExpress.XtraGrid.Columns.GridColumn() {Me.GCOLNIDDOCSTFCONDCOM, Me.GColVTITLE, Me.GColDATECRE, Me.GColVFILE, Me.GColVPATHFILE, Me.GColNSTFGRPNUM})
        Me.GVDocSTFCondCom.GridControl = Me.GCDocSTFCondCom
        Me.GVDocSTFCondCom.Name = "GVDocSTFCondCom"
        Me.GVDocSTFCondCom.OptionsBehavior.Editable = False
        Me.GVDocSTFCondCom.OptionsBehavior.ReadOnly = True
        Me.GVDocSTFCondCom.OptionsNavigation.AutoFocusNewRow = True
        Me.GVDocSTFCondCom.OptionsView.EnableAppearanceEvenRow = True
        Me.GVDocSTFCondCom.OptionsView.EnableAppearanceOddRow = True
        Me.GVDocSTFCondCom.OptionsView.ShowGroupPanel = False
        '
        'GColDATECRE
        '
        Me.GColDATECRE.AppearanceCell.FontSizeDelta = CType(resources.GetObject("GColDATECRE.AppearanceCell.FontSizeDelta"), Integer)
        Me.GColDATECRE.AppearanceCell.FontStyleDelta = CType(resources.GetObject("GColDATECRE.AppearanceCell.FontStyleDelta"), System.Drawing.FontStyle)
        Me.GColDATECRE.AppearanceCell.GradientMode = CType(resources.GetObject("GColDATECRE.AppearanceCell.GradientMode"), System.Drawing.Drawing2D.LinearGradientMode)
        Me.GColDATECRE.AppearanceCell.Image = CType(resources.GetObject("GColDATECRE.AppearanceCell.Image"), System.Drawing.Image)
        Me.GColDATECRE.AppearanceCell.Options.UseTextOptions = True
        Me.GColDATECRE.AppearanceCell.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center
        Me.GColDATECRE.AppearanceCell.TextOptions.VAlignment = DevExpress.Utils.VertAlignment.Center
        resources.ApplyResources(Me.GColDATECRE, "GColDATECRE")
        Me.GColDATECRE.FieldName = "DATECRE"
        Me.GColDATECRE.Name = "GColDATECRE"
        '
        'GColVPATHFILE
        '
        resources.ApplyResources(Me.GColVPATHFILE, "GColVPATHFILE")
        Me.GColVPATHFILE.FieldName = "VPATHFILE"
        Me.GColVPATHFILE.Name = "GColVPATHFILE"
        '
        'GColNSTFGRPNUM
        '
        resources.ApplyResources(Me.GColNSTFGRPNUM, "GColNSTFGRPNUM")
        Me.GColNSTFGRPNUM.FieldName = "NSTFGRPNUM"
        Me.GColNSTFGRPNUM.Name = "GColNSTFGRPNUM"
        '
        'GrpActions
        '
        resources.ApplyResources(Me.GrpActions, "GrpActions")
        Me.GrpActions.Controls.Add(Me.btnVisualiser)
        Me.GrpActions.Controls.Add(Me.BtnModifier)
        Me.GrpActions.Controls.Add(Me.BtnSupprLine)
        Me.GrpActions.Controls.Add(Me.BtnAddLine)
        Me.GrpActions.Controls.Add(Me.BtnQuit)
        Me.GrpActions.Name = "GrpActions"
        Me.GrpActions.TabStop = False
        '
        'btnVisualiser
        '
        resources.ApplyResources(Me.btnVisualiser, "btnVisualiser")
        Me.btnVisualiser.Name = "btnVisualiser"
        Me.btnVisualiser.UseVisualStyleBackColor = True
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
        'WBApercu
        '
        resources.ApplyResources(Me.WBApercu, "WBApercu")
        Me.WBApercu.Name = "WBApercu"
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
        'frmGestionDocSTFCondCom
        '
        resources.ApplyResources(Me, "$this")
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.Wheat
        Me.Controls.Add(Me.GCDocSTFCondCom)
        Me.Controls.Add(Me.GrpActions)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.GrpApercu)
        Me.Name = "frmGestionDocSTFCondCom"
        Me.WindowState = System.Windows.Forms.FormWindowState.Maximized
        CType(Me.GCDocSTFCondCom, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.GVDocSTFCondCom, System.ComponentModel.ISupportInitialize).EndInit()
        Me.GrpActions.ResumeLayout(False)
        Me.GrpApercu.ResumeLayout(False)
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents GrpActions As System.Windows.Forms.GroupBox
    Friend WithEvents BtnSupprLine As System.Windows.Forms.Button
    Friend WithEvents BtnAddLine As System.Windows.Forms.Button
    Friend WithEvents BtnQuit As System.Windows.Forms.Button
    Friend WithEvents WBApercu As System.Windows.Forms.WebBrowser
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents GrpApercu As System.Windows.Forms.GroupBox
    Friend WithEvents BtnModifier As System.Windows.Forms.Button
    Friend WithEvents btnVisualiser As System.Windows.Forms.Button
    Private WithEvents GColVTITLE As DevExpress.XtraGrid.Columns.GridColumn
    Private WithEvents GCOLNIDDOCSTFCONDCOM As DevExpress.XtraGrid.Columns.GridColumn
    Private WithEvents GColVFILE As DevExpress.XtraGrid.Columns.GridColumn
    Private WithEvents GCDocSTFCondCom As DevExpress.XtraGrid.GridControl
    Private WithEvents GVDocSTFCondCom As DevExpress.XtraGrid.Views.Grid.GridView
    Private WithEvents GColDATECRE As DevExpress.XtraGrid.Columns.GridColumn
    Private WithEvents GColVPATHFILE As DevExpress.XtraGrid.Columns.GridColumn
    Private WithEvents GColNSTFGRPNUM As DevExpress.XtraGrid.Columns.GridColumn
End Class
