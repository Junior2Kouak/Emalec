<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmListeFacturesErrorForTransfert
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(frmListeFacturesErrorForTransfert))
        Me.GrpActions = New System.Windows.Forms.GroupBox()
        Me.BtnMailInfo = New System.Windows.Forms.Button()
        Me.BtnFermer = New System.Windows.Forms.Button()
        Me.GrpListe = New System.Windows.Forms.GroupBox()
        Me.GCListeFOUFAC = New DevExpress.XtraGrid.GridControl()
        Me.GVListeFOUFAC = New DevExpress.XtraGrid.Views.Grid.GridView()
        Me.GColVFACREF = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.GColFFACHT = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.GColFFACTTC = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.GColDFACDATE = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.GColVSTFNOM = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.GColNFOUFACNUM = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.GrpActions.SuspendLayout()
        Me.GrpListe.SuspendLayout()
        CType(Me.GCListeFOUFAC, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.GVListeFOUFAC, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'GrpActions
        '
        resources.ApplyResources(Me.GrpActions, "GrpActions")
        Me.GrpActions.Controls.Add(Me.BtnMailInfo)
        Me.GrpActions.Controls.Add(Me.BtnFermer)
        Me.GrpActions.Name = "GrpActions"
        Me.GrpActions.TabStop = False
        '
        'BtnMailInfo
        '
        resources.ApplyResources(Me.BtnMailInfo, "BtnMailInfo")
        Me.BtnMailInfo.Name = "BtnMailInfo"
        Me.BtnMailInfo.UseVisualStyleBackColor = True
        '
        'BtnFermer
        '
        resources.ApplyResources(Me.BtnFermer, "BtnFermer")
        Me.BtnFermer.Name = "BtnFermer"
        Me.BtnFermer.UseVisualStyleBackColor = True
        '
        'GrpListe
        '
        resources.ApplyResources(Me.GrpListe, "GrpListe")
        Me.GrpListe.Controls.Add(Me.GCListeFOUFAC)
        Me.GrpListe.Name = "GrpListe"
        Me.GrpListe.TabStop = False
        '
        'GCListeFOUFAC
        '
        resources.ApplyResources(Me.GCListeFOUFAC, "GCListeFOUFAC")
        '
        '
        '
        Me.GCListeFOUFAC.EmbeddedNavigator.AccessibleDescription = resources.GetString("GCListeFOUFAC.EmbeddedNavigator.AccessibleDescription")
        Me.GCListeFOUFAC.EmbeddedNavigator.AccessibleName = resources.GetString("GCListeFOUFAC.EmbeddedNavigator.AccessibleName")
        Me.GCListeFOUFAC.EmbeddedNavigator.AllowHtmlTextInToolTip = CType(resources.GetObject("GCListeFOUFAC.EmbeddedNavigator.AllowHtmlTextInToolTip"), DevExpress.Utils.DefaultBoolean)
        Me.GCListeFOUFAC.EmbeddedNavigator.Anchor = CType(resources.GetObject("GCListeFOUFAC.EmbeddedNavigator.Anchor"), System.Windows.Forms.AnchorStyles)
        Me.GCListeFOUFAC.EmbeddedNavigator.BackgroundImage = CType(resources.GetObject("GCListeFOUFAC.EmbeddedNavigator.BackgroundImage"), System.Drawing.Image)
        Me.GCListeFOUFAC.EmbeddedNavigator.BackgroundImageLayout = CType(resources.GetObject("GCListeFOUFAC.EmbeddedNavigator.BackgroundImageLayout"), System.Windows.Forms.ImageLayout)
        Me.GCListeFOUFAC.EmbeddedNavigator.ImeMode = CType(resources.GetObject("GCListeFOUFAC.EmbeddedNavigator.ImeMode"), System.Windows.Forms.ImeMode)
        Me.GCListeFOUFAC.EmbeddedNavigator.MaximumSize = CType(resources.GetObject("GCListeFOUFAC.EmbeddedNavigator.MaximumSize"), System.Drawing.Size)
        Me.GCListeFOUFAC.EmbeddedNavigator.TextLocation = CType(resources.GetObject("GCListeFOUFAC.EmbeddedNavigator.TextLocation"), DevExpress.XtraEditors.NavigatorButtonsTextLocation)
        Me.GCListeFOUFAC.EmbeddedNavigator.ToolTip = resources.GetString("GCListeFOUFAC.EmbeddedNavigator.ToolTip")
        Me.GCListeFOUFAC.EmbeddedNavigator.ToolTipIconType = CType(resources.GetObject("GCListeFOUFAC.EmbeddedNavigator.ToolTipIconType"), DevExpress.Utils.ToolTipIconType)
        Me.GCListeFOUFAC.EmbeddedNavigator.ToolTipTitle = resources.GetString("GCListeFOUFAC.EmbeddedNavigator.ToolTipTitle")
        Me.GCListeFOUFAC.MainView = Me.GVListeFOUFAC
        Me.GCListeFOUFAC.Name = "GCListeFOUFAC"
        Me.GCListeFOUFAC.ViewCollection.AddRange(New DevExpress.XtraGrid.Views.Base.BaseView() {Me.GVListeFOUFAC})
        '
        'GVListeFOUFAC
        '
        Me.GVListeFOUFAC.Appearance.ColumnFilterButton.BackColor = CType(resources.GetObject("GVListeFOUFAC.Appearance.ColumnFilterButton.BackColor"), System.Drawing.Color)
        Me.GVListeFOUFAC.Appearance.ColumnFilterButton.BorderColor = CType(resources.GetObject("GVListeFOUFAC.Appearance.ColumnFilterButton.BorderColor"), System.Drawing.Color)
        Me.GVListeFOUFAC.Appearance.ColumnFilterButton.FontSizeDelta = CType(resources.GetObject("GVListeFOUFAC.Appearance.ColumnFilterButton.FontSizeDelta"), Integer)
        Me.GVListeFOUFAC.Appearance.ColumnFilterButton.FontStyleDelta = CType(resources.GetObject("GVListeFOUFAC.Appearance.ColumnFilterButton.FontStyleDelta"), System.Drawing.FontStyle)
        Me.GVListeFOUFAC.Appearance.ColumnFilterButton.ForeColor = CType(resources.GetObject("GVListeFOUFAC.Appearance.ColumnFilterButton.ForeColor"), System.Drawing.Color)
        Me.GVListeFOUFAC.Appearance.ColumnFilterButton.GradientMode = CType(resources.GetObject("GVListeFOUFAC.Appearance.ColumnFilterButton.GradientMode"), System.Drawing.Drawing2D.LinearGradientMode)
        Me.GVListeFOUFAC.Appearance.ColumnFilterButton.Image = CType(resources.GetObject("GVListeFOUFAC.Appearance.ColumnFilterButton.Image"), System.Drawing.Image)
        Me.GVListeFOUFAC.Appearance.ColumnFilterButton.Options.UseBackColor = True
        Me.GVListeFOUFAC.Appearance.ColumnFilterButton.Options.UseBorderColor = True
        Me.GVListeFOUFAC.Appearance.ColumnFilterButton.Options.UseForeColor = True
        Me.GVListeFOUFAC.Appearance.ColumnFilterButtonActive.BackColor = CType(resources.GetObject("GVListeFOUFAC.Appearance.ColumnFilterButtonActive.BackColor"), System.Drawing.Color)
        Me.GVListeFOUFAC.Appearance.ColumnFilterButtonActive.BorderColor = CType(resources.GetObject("GVListeFOUFAC.Appearance.ColumnFilterButtonActive.BorderColor"), System.Drawing.Color)
        Me.GVListeFOUFAC.Appearance.ColumnFilterButtonActive.FontSizeDelta = CType(resources.GetObject("GVListeFOUFAC.Appearance.ColumnFilterButtonActive.FontSizeDelta"), Integer)
        Me.GVListeFOUFAC.Appearance.ColumnFilterButtonActive.FontStyleDelta = CType(resources.GetObject("GVListeFOUFAC.Appearance.ColumnFilterButtonActive.FontStyleDelta"), System.Drawing.FontStyle)
        Me.GVListeFOUFAC.Appearance.ColumnFilterButtonActive.ForeColor = CType(resources.GetObject("GVListeFOUFAC.Appearance.ColumnFilterButtonActive.ForeColor"), System.Drawing.Color)
        Me.GVListeFOUFAC.Appearance.ColumnFilterButtonActive.GradientMode = CType(resources.GetObject("GVListeFOUFAC.Appearance.ColumnFilterButtonActive.GradientMode"), System.Drawing.Drawing2D.LinearGradientMode)
        Me.GVListeFOUFAC.Appearance.ColumnFilterButtonActive.Image = CType(resources.GetObject("GVListeFOUFAC.Appearance.ColumnFilterButtonActive.Image"), System.Drawing.Image)
        Me.GVListeFOUFAC.Appearance.ColumnFilterButtonActive.Options.UseBackColor = True
        Me.GVListeFOUFAC.Appearance.ColumnFilterButtonActive.Options.UseBorderColor = True
        Me.GVListeFOUFAC.Appearance.ColumnFilterButtonActive.Options.UseForeColor = True
        Me.GVListeFOUFAC.Appearance.Empty.BackColor = CType(resources.GetObject("GVListeFOUFAC.Appearance.Empty.BackColor"), System.Drawing.Color)
        Me.GVListeFOUFAC.Appearance.Empty.BackColor2 = CType(resources.GetObject("GVListeFOUFAC.Appearance.Empty.BackColor2"), System.Drawing.Color)
        Me.GVListeFOUFAC.Appearance.Empty.FontSizeDelta = CType(resources.GetObject("GVListeFOUFAC.Appearance.Empty.FontSizeDelta"), Integer)
        Me.GVListeFOUFAC.Appearance.Empty.FontStyleDelta = CType(resources.GetObject("GVListeFOUFAC.Appearance.Empty.FontStyleDelta"), System.Drawing.FontStyle)
        Me.GVListeFOUFAC.Appearance.Empty.GradientMode = CType(resources.GetObject("GVListeFOUFAC.Appearance.Empty.GradientMode"), System.Drawing.Drawing2D.LinearGradientMode)
        Me.GVListeFOUFAC.Appearance.Empty.Image = CType(resources.GetObject("GVListeFOUFAC.Appearance.Empty.Image"), System.Drawing.Image)
        Me.GVListeFOUFAC.Appearance.Empty.Options.UseBackColor = True
        Me.GVListeFOUFAC.Appearance.EvenRow.BackColor = CType(resources.GetObject("GVListeFOUFAC.Appearance.EvenRow.BackColor"), System.Drawing.Color)
        Me.GVListeFOUFAC.Appearance.EvenRow.BorderColor = CType(resources.GetObject("GVListeFOUFAC.Appearance.EvenRow.BorderColor"), System.Drawing.Color)
        Me.GVListeFOUFAC.Appearance.EvenRow.FontSizeDelta = CType(resources.GetObject("GVListeFOUFAC.Appearance.EvenRow.FontSizeDelta"), Integer)
        Me.GVListeFOUFAC.Appearance.EvenRow.FontStyleDelta = CType(resources.GetObject("GVListeFOUFAC.Appearance.EvenRow.FontStyleDelta"), System.Drawing.FontStyle)
        Me.GVListeFOUFAC.Appearance.EvenRow.ForeColor = CType(resources.GetObject("GVListeFOUFAC.Appearance.EvenRow.ForeColor"), System.Drawing.Color)
        Me.GVListeFOUFAC.Appearance.EvenRow.GradientMode = CType(resources.GetObject("GVListeFOUFAC.Appearance.EvenRow.GradientMode"), System.Drawing.Drawing2D.LinearGradientMode)
        Me.GVListeFOUFAC.Appearance.EvenRow.Image = CType(resources.GetObject("GVListeFOUFAC.Appearance.EvenRow.Image"), System.Drawing.Image)
        Me.GVListeFOUFAC.Appearance.EvenRow.Options.UseBackColor = True
        Me.GVListeFOUFAC.Appearance.EvenRow.Options.UseBorderColor = True
        Me.GVListeFOUFAC.Appearance.EvenRow.Options.UseForeColor = True
        Me.GVListeFOUFAC.Appearance.FilterCloseButton.BackColor = CType(resources.GetObject("GVListeFOUFAC.Appearance.FilterCloseButton.BackColor"), System.Drawing.Color)
        Me.GVListeFOUFAC.Appearance.FilterCloseButton.BorderColor = CType(resources.GetObject("GVListeFOUFAC.Appearance.FilterCloseButton.BorderColor"), System.Drawing.Color)
        Me.GVListeFOUFAC.Appearance.FilterCloseButton.FontSizeDelta = CType(resources.GetObject("GVListeFOUFAC.Appearance.FilterCloseButton.FontSizeDelta"), Integer)
        Me.GVListeFOUFAC.Appearance.FilterCloseButton.FontStyleDelta = CType(resources.GetObject("GVListeFOUFAC.Appearance.FilterCloseButton.FontStyleDelta"), System.Drawing.FontStyle)
        Me.GVListeFOUFAC.Appearance.FilterCloseButton.ForeColor = CType(resources.GetObject("GVListeFOUFAC.Appearance.FilterCloseButton.ForeColor"), System.Drawing.Color)
        Me.GVListeFOUFAC.Appearance.FilterCloseButton.GradientMode = CType(resources.GetObject("GVListeFOUFAC.Appearance.FilterCloseButton.GradientMode"), System.Drawing.Drawing2D.LinearGradientMode)
        Me.GVListeFOUFAC.Appearance.FilterCloseButton.Image = CType(resources.GetObject("GVListeFOUFAC.Appearance.FilterCloseButton.Image"), System.Drawing.Image)
        Me.GVListeFOUFAC.Appearance.FilterCloseButton.Options.UseBackColor = True
        Me.GVListeFOUFAC.Appearance.FilterCloseButton.Options.UseBorderColor = True
        Me.GVListeFOUFAC.Appearance.FilterCloseButton.Options.UseForeColor = True
        Me.GVListeFOUFAC.Appearance.FilterPanel.BackColor = CType(resources.GetObject("GVListeFOUFAC.Appearance.FilterPanel.BackColor"), System.Drawing.Color)
        Me.GVListeFOUFAC.Appearance.FilterPanel.BackColor2 = CType(resources.GetObject("GVListeFOUFAC.Appearance.FilterPanel.BackColor2"), System.Drawing.Color)
        Me.GVListeFOUFAC.Appearance.FilterPanel.FontSizeDelta = CType(resources.GetObject("GVListeFOUFAC.Appearance.FilterPanel.FontSizeDelta"), Integer)
        Me.GVListeFOUFAC.Appearance.FilterPanel.FontStyleDelta = CType(resources.GetObject("GVListeFOUFAC.Appearance.FilterPanel.FontStyleDelta"), System.Drawing.FontStyle)
        Me.GVListeFOUFAC.Appearance.FilterPanel.ForeColor = CType(resources.GetObject("GVListeFOUFAC.Appearance.FilterPanel.ForeColor"), System.Drawing.Color)
        Me.GVListeFOUFAC.Appearance.FilterPanel.GradientMode = CType(resources.GetObject("GVListeFOUFAC.Appearance.FilterPanel.GradientMode"), System.Drawing.Drawing2D.LinearGradientMode)
        Me.GVListeFOUFAC.Appearance.FilterPanel.Image = CType(resources.GetObject("GVListeFOUFAC.Appearance.FilterPanel.Image"), System.Drawing.Image)
        Me.GVListeFOUFAC.Appearance.FilterPanel.Options.UseBackColor = True
        Me.GVListeFOUFAC.Appearance.FilterPanel.Options.UseForeColor = True
        Me.GVListeFOUFAC.Appearance.FixedLine.BackColor = CType(resources.GetObject("GVListeFOUFAC.Appearance.FixedLine.BackColor"), System.Drawing.Color)
        Me.GVListeFOUFAC.Appearance.FixedLine.FontSizeDelta = CType(resources.GetObject("GVListeFOUFAC.Appearance.FixedLine.FontSizeDelta"), Integer)
        Me.GVListeFOUFAC.Appearance.FixedLine.FontStyleDelta = CType(resources.GetObject("GVListeFOUFAC.Appearance.FixedLine.FontStyleDelta"), System.Drawing.FontStyle)
        Me.GVListeFOUFAC.Appearance.FixedLine.GradientMode = CType(resources.GetObject("GVListeFOUFAC.Appearance.FixedLine.GradientMode"), System.Drawing.Drawing2D.LinearGradientMode)
        Me.GVListeFOUFAC.Appearance.FixedLine.Image = CType(resources.GetObject("GVListeFOUFAC.Appearance.FixedLine.Image"), System.Drawing.Image)
        Me.GVListeFOUFAC.Appearance.FixedLine.Options.UseBackColor = True
        Me.GVListeFOUFAC.Appearance.FocusedCell.BackColor = CType(resources.GetObject("GVListeFOUFAC.Appearance.FocusedCell.BackColor"), System.Drawing.Color)
        Me.GVListeFOUFAC.Appearance.FocusedCell.FontSizeDelta = CType(resources.GetObject("GVListeFOUFAC.Appearance.FocusedCell.FontSizeDelta"), Integer)
        Me.GVListeFOUFAC.Appearance.FocusedCell.FontStyleDelta = CType(resources.GetObject("GVListeFOUFAC.Appearance.FocusedCell.FontStyleDelta"), System.Drawing.FontStyle)
        Me.GVListeFOUFAC.Appearance.FocusedCell.ForeColor = CType(resources.GetObject("GVListeFOUFAC.Appearance.FocusedCell.ForeColor"), System.Drawing.Color)
        Me.GVListeFOUFAC.Appearance.FocusedCell.GradientMode = CType(resources.GetObject("GVListeFOUFAC.Appearance.FocusedCell.GradientMode"), System.Drawing.Drawing2D.LinearGradientMode)
        Me.GVListeFOUFAC.Appearance.FocusedCell.Image = CType(resources.GetObject("GVListeFOUFAC.Appearance.FocusedCell.Image"), System.Drawing.Image)
        Me.GVListeFOUFAC.Appearance.FocusedCell.Options.UseBackColor = True
        Me.GVListeFOUFAC.Appearance.FocusedCell.Options.UseForeColor = True
        Me.GVListeFOUFAC.Appearance.FocusedRow.BackColor = CType(resources.GetObject("GVListeFOUFAC.Appearance.FocusedRow.BackColor"), System.Drawing.Color)
        Me.GVListeFOUFAC.Appearance.FocusedRow.BorderColor = CType(resources.GetObject("GVListeFOUFAC.Appearance.FocusedRow.BorderColor"), System.Drawing.Color)
        Me.GVListeFOUFAC.Appearance.FocusedRow.FontSizeDelta = CType(resources.GetObject("GVListeFOUFAC.Appearance.FocusedRow.FontSizeDelta"), Integer)
        Me.GVListeFOUFAC.Appearance.FocusedRow.FontStyleDelta = CType(resources.GetObject("GVListeFOUFAC.Appearance.FocusedRow.FontStyleDelta"), System.Drawing.FontStyle)
        Me.GVListeFOUFAC.Appearance.FocusedRow.ForeColor = CType(resources.GetObject("GVListeFOUFAC.Appearance.FocusedRow.ForeColor"), System.Drawing.Color)
        Me.GVListeFOUFAC.Appearance.FocusedRow.GradientMode = CType(resources.GetObject("GVListeFOUFAC.Appearance.FocusedRow.GradientMode"), System.Drawing.Drawing2D.LinearGradientMode)
        Me.GVListeFOUFAC.Appearance.FocusedRow.Image = CType(resources.GetObject("GVListeFOUFAC.Appearance.FocusedRow.Image"), System.Drawing.Image)
        Me.GVListeFOUFAC.Appearance.FocusedRow.Options.UseBackColor = True
        Me.GVListeFOUFAC.Appearance.FocusedRow.Options.UseBorderColor = True
        Me.GVListeFOUFAC.Appearance.FocusedRow.Options.UseForeColor = True
        Me.GVListeFOUFAC.Appearance.FooterPanel.BackColor = CType(resources.GetObject("GVListeFOUFAC.Appearance.FooterPanel.BackColor"), System.Drawing.Color)
        Me.GVListeFOUFAC.Appearance.FooterPanel.BorderColor = CType(resources.GetObject("GVListeFOUFAC.Appearance.FooterPanel.BorderColor"), System.Drawing.Color)
        Me.GVListeFOUFAC.Appearance.FooterPanel.FontSizeDelta = CType(resources.GetObject("GVListeFOUFAC.Appearance.FooterPanel.FontSizeDelta"), Integer)
        Me.GVListeFOUFAC.Appearance.FooterPanel.FontStyleDelta = CType(resources.GetObject("GVListeFOUFAC.Appearance.FooterPanel.FontStyleDelta"), System.Drawing.FontStyle)
        Me.GVListeFOUFAC.Appearance.FooterPanel.ForeColor = CType(resources.GetObject("GVListeFOUFAC.Appearance.FooterPanel.ForeColor"), System.Drawing.Color)
        Me.GVListeFOUFAC.Appearance.FooterPanel.GradientMode = CType(resources.GetObject("GVListeFOUFAC.Appearance.FooterPanel.GradientMode"), System.Drawing.Drawing2D.LinearGradientMode)
        Me.GVListeFOUFAC.Appearance.FooterPanel.Image = CType(resources.GetObject("GVListeFOUFAC.Appearance.FooterPanel.Image"), System.Drawing.Image)
        Me.GVListeFOUFAC.Appearance.FooterPanel.Options.UseBackColor = True
        Me.GVListeFOUFAC.Appearance.FooterPanel.Options.UseBorderColor = True
        Me.GVListeFOUFAC.Appearance.FooterPanel.Options.UseForeColor = True
        Me.GVListeFOUFAC.Appearance.GroupButton.BackColor = CType(resources.GetObject("GVListeFOUFAC.Appearance.GroupButton.BackColor"), System.Drawing.Color)
        Me.GVListeFOUFAC.Appearance.GroupButton.BorderColor = CType(resources.GetObject("GVListeFOUFAC.Appearance.GroupButton.BorderColor"), System.Drawing.Color)
        Me.GVListeFOUFAC.Appearance.GroupButton.FontSizeDelta = CType(resources.GetObject("GVListeFOUFAC.Appearance.GroupButton.FontSizeDelta"), Integer)
        Me.GVListeFOUFAC.Appearance.GroupButton.FontStyleDelta = CType(resources.GetObject("GVListeFOUFAC.Appearance.GroupButton.FontStyleDelta"), System.Drawing.FontStyle)
        Me.GVListeFOUFAC.Appearance.GroupButton.GradientMode = CType(resources.GetObject("GVListeFOUFAC.Appearance.GroupButton.GradientMode"), System.Drawing.Drawing2D.LinearGradientMode)
        Me.GVListeFOUFAC.Appearance.GroupButton.Image = CType(resources.GetObject("GVListeFOUFAC.Appearance.GroupButton.Image"), System.Drawing.Image)
        Me.GVListeFOUFAC.Appearance.GroupButton.Options.UseBackColor = True
        Me.GVListeFOUFAC.Appearance.GroupButton.Options.UseBorderColor = True
        Me.GVListeFOUFAC.Appearance.GroupFooter.BackColor = CType(resources.GetObject("GVListeFOUFAC.Appearance.GroupFooter.BackColor"), System.Drawing.Color)
        Me.GVListeFOUFAC.Appearance.GroupFooter.BorderColor = CType(resources.GetObject("GVListeFOUFAC.Appearance.GroupFooter.BorderColor"), System.Drawing.Color)
        Me.GVListeFOUFAC.Appearance.GroupFooter.FontSizeDelta = CType(resources.GetObject("GVListeFOUFAC.Appearance.GroupFooter.FontSizeDelta"), Integer)
        Me.GVListeFOUFAC.Appearance.GroupFooter.FontStyleDelta = CType(resources.GetObject("GVListeFOUFAC.Appearance.GroupFooter.FontStyleDelta"), System.Drawing.FontStyle)
        Me.GVListeFOUFAC.Appearance.GroupFooter.ForeColor = CType(resources.GetObject("GVListeFOUFAC.Appearance.GroupFooter.ForeColor"), System.Drawing.Color)
        Me.GVListeFOUFAC.Appearance.GroupFooter.GradientMode = CType(resources.GetObject("GVListeFOUFAC.Appearance.GroupFooter.GradientMode"), System.Drawing.Drawing2D.LinearGradientMode)
        Me.GVListeFOUFAC.Appearance.GroupFooter.Image = CType(resources.GetObject("GVListeFOUFAC.Appearance.GroupFooter.Image"), System.Drawing.Image)
        Me.GVListeFOUFAC.Appearance.GroupFooter.Options.UseBackColor = True
        Me.GVListeFOUFAC.Appearance.GroupFooter.Options.UseBorderColor = True
        Me.GVListeFOUFAC.Appearance.GroupFooter.Options.UseForeColor = True
        Me.GVListeFOUFAC.Appearance.GroupPanel.BackColor = CType(resources.GetObject("GVListeFOUFAC.Appearance.GroupPanel.BackColor"), System.Drawing.Color)
        Me.GVListeFOUFAC.Appearance.GroupPanel.BackColor2 = CType(resources.GetObject("GVListeFOUFAC.Appearance.GroupPanel.BackColor2"), System.Drawing.Color)
        Me.GVListeFOUFAC.Appearance.GroupPanel.FontSizeDelta = CType(resources.GetObject("GVListeFOUFAC.Appearance.GroupPanel.FontSizeDelta"), Integer)
        Me.GVListeFOUFAC.Appearance.GroupPanel.FontStyleDelta = CType(resources.GetObject("GVListeFOUFAC.Appearance.GroupPanel.FontStyleDelta"), System.Drawing.FontStyle)
        Me.GVListeFOUFAC.Appearance.GroupPanel.ForeColor = CType(resources.GetObject("GVListeFOUFAC.Appearance.GroupPanel.ForeColor"), System.Drawing.Color)
        Me.GVListeFOUFAC.Appearance.GroupPanel.GradientMode = CType(resources.GetObject("GVListeFOUFAC.Appearance.GroupPanel.GradientMode"), System.Drawing.Drawing2D.LinearGradientMode)
        Me.GVListeFOUFAC.Appearance.GroupPanel.Image = CType(resources.GetObject("GVListeFOUFAC.Appearance.GroupPanel.Image"), System.Drawing.Image)
        Me.GVListeFOUFAC.Appearance.GroupPanel.Options.UseBackColor = True
        Me.GVListeFOUFAC.Appearance.GroupPanel.Options.UseForeColor = True
        Me.GVListeFOUFAC.Appearance.GroupRow.BackColor = CType(resources.GetObject("GVListeFOUFAC.Appearance.GroupRow.BackColor"), System.Drawing.Color)
        Me.GVListeFOUFAC.Appearance.GroupRow.BorderColor = CType(resources.GetObject("GVListeFOUFAC.Appearance.GroupRow.BorderColor"), System.Drawing.Color)
        Me.GVListeFOUFAC.Appearance.GroupRow.FontSizeDelta = CType(resources.GetObject("GVListeFOUFAC.Appearance.GroupRow.FontSizeDelta"), Integer)
        Me.GVListeFOUFAC.Appearance.GroupRow.FontStyleDelta = CType(resources.GetObject("GVListeFOUFAC.Appearance.GroupRow.FontStyleDelta"), System.Drawing.FontStyle)
        Me.GVListeFOUFAC.Appearance.GroupRow.ForeColor = CType(resources.GetObject("GVListeFOUFAC.Appearance.GroupRow.ForeColor"), System.Drawing.Color)
        Me.GVListeFOUFAC.Appearance.GroupRow.GradientMode = CType(resources.GetObject("GVListeFOUFAC.Appearance.GroupRow.GradientMode"), System.Drawing.Drawing2D.LinearGradientMode)
        Me.GVListeFOUFAC.Appearance.GroupRow.Image = CType(resources.GetObject("GVListeFOUFAC.Appearance.GroupRow.Image"), System.Drawing.Image)
        Me.GVListeFOUFAC.Appearance.GroupRow.Options.UseBackColor = True
        Me.GVListeFOUFAC.Appearance.GroupRow.Options.UseBorderColor = True
        Me.GVListeFOUFAC.Appearance.GroupRow.Options.UseForeColor = True
        Me.GVListeFOUFAC.Appearance.HeaderPanel.BackColor = CType(resources.GetObject("GVListeFOUFAC.Appearance.HeaderPanel.BackColor"), System.Drawing.Color)
        Me.GVListeFOUFAC.Appearance.HeaderPanel.BorderColor = CType(resources.GetObject("GVListeFOUFAC.Appearance.HeaderPanel.BorderColor"), System.Drawing.Color)
        Me.GVListeFOUFAC.Appearance.HeaderPanel.FontSizeDelta = CType(resources.GetObject("GVListeFOUFAC.Appearance.HeaderPanel.FontSizeDelta"), Integer)
        Me.GVListeFOUFAC.Appearance.HeaderPanel.FontStyleDelta = CType(resources.GetObject("GVListeFOUFAC.Appearance.HeaderPanel.FontStyleDelta"), System.Drawing.FontStyle)
        Me.GVListeFOUFAC.Appearance.HeaderPanel.ForeColor = CType(resources.GetObject("GVListeFOUFAC.Appearance.HeaderPanel.ForeColor"), System.Drawing.Color)
        Me.GVListeFOUFAC.Appearance.HeaderPanel.GradientMode = CType(resources.GetObject("GVListeFOUFAC.Appearance.HeaderPanel.GradientMode"), System.Drawing.Drawing2D.LinearGradientMode)
        Me.GVListeFOUFAC.Appearance.HeaderPanel.Image = CType(resources.GetObject("GVListeFOUFAC.Appearance.HeaderPanel.Image"), System.Drawing.Image)
        Me.GVListeFOUFAC.Appearance.HeaderPanel.Options.UseBackColor = True
        Me.GVListeFOUFAC.Appearance.HeaderPanel.Options.UseBorderColor = True
        Me.GVListeFOUFAC.Appearance.HeaderPanel.Options.UseForeColor = True
        Me.GVListeFOUFAC.Appearance.HideSelectionRow.BackColor = CType(resources.GetObject("GVListeFOUFAC.Appearance.HideSelectionRow.BackColor"), System.Drawing.Color)
        Me.GVListeFOUFAC.Appearance.HideSelectionRow.BorderColor = CType(resources.GetObject("GVListeFOUFAC.Appearance.HideSelectionRow.BorderColor"), System.Drawing.Color)
        Me.GVListeFOUFAC.Appearance.HideSelectionRow.FontSizeDelta = CType(resources.GetObject("GVListeFOUFAC.Appearance.HideSelectionRow.FontSizeDelta"), Integer)
        Me.GVListeFOUFAC.Appearance.HideSelectionRow.FontStyleDelta = CType(resources.GetObject("GVListeFOUFAC.Appearance.HideSelectionRow.FontStyleDelta"), System.Drawing.FontStyle)
        Me.GVListeFOUFAC.Appearance.HideSelectionRow.ForeColor = CType(resources.GetObject("GVListeFOUFAC.Appearance.HideSelectionRow.ForeColor"), System.Drawing.Color)
        Me.GVListeFOUFAC.Appearance.HideSelectionRow.GradientMode = CType(resources.GetObject("GVListeFOUFAC.Appearance.HideSelectionRow.GradientMode"), System.Drawing.Drawing2D.LinearGradientMode)
        Me.GVListeFOUFAC.Appearance.HideSelectionRow.Image = CType(resources.GetObject("GVListeFOUFAC.Appearance.HideSelectionRow.Image"), System.Drawing.Image)
        Me.GVListeFOUFAC.Appearance.HideSelectionRow.Options.UseBackColor = True
        Me.GVListeFOUFAC.Appearance.HideSelectionRow.Options.UseBorderColor = True
        Me.GVListeFOUFAC.Appearance.HideSelectionRow.Options.UseForeColor = True
        Me.GVListeFOUFAC.Appearance.HorzLine.BackColor = CType(resources.GetObject("GVListeFOUFAC.Appearance.HorzLine.BackColor"), System.Drawing.Color)
        Me.GVListeFOUFAC.Appearance.HorzLine.FontSizeDelta = CType(resources.GetObject("GVListeFOUFAC.Appearance.HorzLine.FontSizeDelta"), Integer)
        Me.GVListeFOUFAC.Appearance.HorzLine.FontStyleDelta = CType(resources.GetObject("GVListeFOUFAC.Appearance.HorzLine.FontStyleDelta"), System.Drawing.FontStyle)
        Me.GVListeFOUFAC.Appearance.HorzLine.GradientMode = CType(resources.GetObject("GVListeFOUFAC.Appearance.HorzLine.GradientMode"), System.Drawing.Drawing2D.LinearGradientMode)
        Me.GVListeFOUFAC.Appearance.HorzLine.Image = CType(resources.GetObject("GVListeFOUFAC.Appearance.HorzLine.Image"), System.Drawing.Image)
        Me.GVListeFOUFAC.Appearance.HorzLine.Options.UseBackColor = True
        Me.GVListeFOUFAC.Appearance.OddRow.BackColor = CType(resources.GetObject("GVListeFOUFAC.Appearance.OddRow.BackColor"), System.Drawing.Color)
        Me.GVListeFOUFAC.Appearance.OddRow.BorderColor = CType(resources.GetObject("GVListeFOUFAC.Appearance.OddRow.BorderColor"), System.Drawing.Color)
        Me.GVListeFOUFAC.Appearance.OddRow.FontSizeDelta = CType(resources.GetObject("GVListeFOUFAC.Appearance.OddRow.FontSizeDelta"), Integer)
        Me.GVListeFOUFAC.Appearance.OddRow.FontStyleDelta = CType(resources.GetObject("GVListeFOUFAC.Appearance.OddRow.FontStyleDelta"), System.Drawing.FontStyle)
        Me.GVListeFOUFAC.Appearance.OddRow.ForeColor = CType(resources.GetObject("GVListeFOUFAC.Appearance.OddRow.ForeColor"), System.Drawing.Color)
        Me.GVListeFOUFAC.Appearance.OddRow.GradientMode = CType(resources.GetObject("GVListeFOUFAC.Appearance.OddRow.GradientMode"), System.Drawing.Drawing2D.LinearGradientMode)
        Me.GVListeFOUFAC.Appearance.OddRow.Image = CType(resources.GetObject("GVListeFOUFAC.Appearance.OddRow.Image"), System.Drawing.Image)
        Me.GVListeFOUFAC.Appearance.OddRow.Options.UseBackColor = True
        Me.GVListeFOUFAC.Appearance.OddRow.Options.UseBorderColor = True
        Me.GVListeFOUFAC.Appearance.OddRow.Options.UseForeColor = True
        Me.GVListeFOUFAC.Appearance.Preview.Font = CType(resources.GetObject("GVListeFOUFAC.Appearance.Preview.Font"), System.Drawing.Font)
        Me.GVListeFOUFAC.Appearance.Preview.FontSizeDelta = CType(resources.GetObject("GVListeFOUFAC.Appearance.Preview.FontSizeDelta"), Integer)
        Me.GVListeFOUFAC.Appearance.Preview.FontStyleDelta = CType(resources.GetObject("GVListeFOUFAC.Appearance.Preview.FontStyleDelta"), System.Drawing.FontStyle)
        Me.GVListeFOUFAC.Appearance.Preview.ForeColor = CType(resources.GetObject("GVListeFOUFAC.Appearance.Preview.ForeColor"), System.Drawing.Color)
        Me.GVListeFOUFAC.Appearance.Preview.GradientMode = CType(resources.GetObject("GVListeFOUFAC.Appearance.Preview.GradientMode"), System.Drawing.Drawing2D.LinearGradientMode)
        Me.GVListeFOUFAC.Appearance.Preview.Image = CType(resources.GetObject("GVListeFOUFAC.Appearance.Preview.Image"), System.Drawing.Image)
        Me.GVListeFOUFAC.Appearance.Preview.Options.UseFont = True
        Me.GVListeFOUFAC.Appearance.Preview.Options.UseForeColor = True
        Me.GVListeFOUFAC.Appearance.Row.BackColor = CType(resources.GetObject("GVListeFOUFAC.Appearance.Row.BackColor"), System.Drawing.Color)
        Me.GVListeFOUFAC.Appearance.Row.FontSizeDelta = CType(resources.GetObject("GVListeFOUFAC.Appearance.Row.FontSizeDelta"), Integer)
        Me.GVListeFOUFAC.Appearance.Row.FontStyleDelta = CType(resources.GetObject("GVListeFOUFAC.Appearance.Row.FontStyleDelta"), System.Drawing.FontStyle)
        Me.GVListeFOUFAC.Appearance.Row.ForeColor = CType(resources.GetObject("GVListeFOUFAC.Appearance.Row.ForeColor"), System.Drawing.Color)
        Me.GVListeFOUFAC.Appearance.Row.GradientMode = CType(resources.GetObject("GVListeFOUFAC.Appearance.Row.GradientMode"), System.Drawing.Drawing2D.LinearGradientMode)
        Me.GVListeFOUFAC.Appearance.Row.Image = CType(resources.GetObject("GVListeFOUFAC.Appearance.Row.Image"), System.Drawing.Image)
        Me.GVListeFOUFAC.Appearance.Row.Options.UseBackColor = True
        Me.GVListeFOUFAC.Appearance.Row.Options.UseForeColor = True
        Me.GVListeFOUFAC.Appearance.RowSeparator.BackColor = CType(resources.GetObject("GVListeFOUFAC.Appearance.RowSeparator.BackColor"), System.Drawing.Color)
        Me.GVListeFOUFAC.Appearance.RowSeparator.BackColor2 = CType(resources.GetObject("GVListeFOUFAC.Appearance.RowSeparator.BackColor2"), System.Drawing.Color)
        Me.GVListeFOUFAC.Appearance.RowSeparator.FontSizeDelta = CType(resources.GetObject("GVListeFOUFAC.Appearance.RowSeparator.FontSizeDelta"), Integer)
        Me.GVListeFOUFAC.Appearance.RowSeparator.FontStyleDelta = CType(resources.GetObject("GVListeFOUFAC.Appearance.RowSeparator.FontStyleDelta"), System.Drawing.FontStyle)
        Me.GVListeFOUFAC.Appearance.RowSeparator.GradientMode = CType(resources.GetObject("GVListeFOUFAC.Appearance.RowSeparator.GradientMode"), System.Drawing.Drawing2D.LinearGradientMode)
        Me.GVListeFOUFAC.Appearance.RowSeparator.Image = CType(resources.GetObject("GVListeFOUFAC.Appearance.RowSeparator.Image"), System.Drawing.Image)
        Me.GVListeFOUFAC.Appearance.RowSeparator.Options.UseBackColor = True
        Me.GVListeFOUFAC.Appearance.SelectedRow.BackColor = CType(resources.GetObject("GVListeFOUFAC.Appearance.SelectedRow.BackColor"), System.Drawing.Color)
        Me.GVListeFOUFAC.Appearance.SelectedRow.FontSizeDelta = CType(resources.GetObject("GVListeFOUFAC.Appearance.SelectedRow.FontSizeDelta"), Integer)
        Me.GVListeFOUFAC.Appearance.SelectedRow.FontStyleDelta = CType(resources.GetObject("GVListeFOUFAC.Appearance.SelectedRow.FontStyleDelta"), System.Drawing.FontStyle)
        Me.GVListeFOUFAC.Appearance.SelectedRow.ForeColor = CType(resources.GetObject("GVListeFOUFAC.Appearance.SelectedRow.ForeColor"), System.Drawing.Color)
        Me.GVListeFOUFAC.Appearance.SelectedRow.GradientMode = CType(resources.GetObject("GVListeFOUFAC.Appearance.SelectedRow.GradientMode"), System.Drawing.Drawing2D.LinearGradientMode)
        Me.GVListeFOUFAC.Appearance.SelectedRow.Image = CType(resources.GetObject("GVListeFOUFAC.Appearance.SelectedRow.Image"), System.Drawing.Image)
        Me.GVListeFOUFAC.Appearance.SelectedRow.Options.UseBackColor = True
        Me.GVListeFOUFAC.Appearance.SelectedRow.Options.UseForeColor = True
        Me.GVListeFOUFAC.Appearance.TopNewRow.BackColor = CType(resources.GetObject("GVListeFOUFAC.Appearance.TopNewRow.BackColor"), System.Drawing.Color)
        Me.GVListeFOUFAC.Appearance.TopNewRow.FontSizeDelta = CType(resources.GetObject("GVListeFOUFAC.Appearance.TopNewRow.FontSizeDelta"), Integer)
        Me.GVListeFOUFAC.Appearance.TopNewRow.FontStyleDelta = CType(resources.GetObject("GVListeFOUFAC.Appearance.TopNewRow.FontStyleDelta"), System.Drawing.FontStyle)
        Me.GVListeFOUFAC.Appearance.TopNewRow.GradientMode = CType(resources.GetObject("GVListeFOUFAC.Appearance.TopNewRow.GradientMode"), System.Drawing.Drawing2D.LinearGradientMode)
        Me.GVListeFOUFAC.Appearance.TopNewRow.Image = CType(resources.GetObject("GVListeFOUFAC.Appearance.TopNewRow.Image"), System.Drawing.Image)
        Me.GVListeFOUFAC.Appearance.TopNewRow.Options.UseBackColor = True
        Me.GVListeFOUFAC.Appearance.VertLine.BackColor = CType(resources.GetObject("GVListeFOUFAC.Appearance.VertLine.BackColor"), System.Drawing.Color)
        Me.GVListeFOUFAC.Appearance.VertLine.FontSizeDelta = CType(resources.GetObject("GVListeFOUFAC.Appearance.VertLine.FontSizeDelta"), Integer)
        Me.GVListeFOUFAC.Appearance.VertLine.FontStyleDelta = CType(resources.GetObject("GVListeFOUFAC.Appearance.VertLine.FontStyleDelta"), System.Drawing.FontStyle)
        Me.GVListeFOUFAC.Appearance.VertLine.GradientMode = CType(resources.GetObject("GVListeFOUFAC.Appearance.VertLine.GradientMode"), System.Drawing.Drawing2D.LinearGradientMode)
        Me.GVListeFOUFAC.Appearance.VertLine.Image = CType(resources.GetObject("GVListeFOUFAC.Appearance.VertLine.Image"), System.Drawing.Image)
        Me.GVListeFOUFAC.Appearance.VertLine.Options.UseBackColor = True
        resources.ApplyResources(Me.GVListeFOUFAC, "GVListeFOUFAC")
        Me.GVListeFOUFAC.Columns.AddRange(New DevExpress.XtraGrid.Columns.GridColumn() {Me.GColVFACREF, Me.GColFFACHT, Me.GColFFACTTC, Me.GColDFACDATE, Me.GColVSTFNOM, Me.GColNFOUFACNUM})
        Me.GVListeFOUFAC.GridControl = Me.GCListeFOUFAC
        Me.GVListeFOUFAC.Name = "GVListeFOUFAC"
        Me.GVListeFOUFAC.OptionsBehavior.Editable = False
        Me.GVListeFOUFAC.OptionsBehavior.ReadOnly = True
        Me.GVListeFOUFAC.OptionsView.EnableAppearanceEvenRow = True
        Me.GVListeFOUFAC.OptionsView.EnableAppearanceOddRow = True
        Me.GVListeFOUFAC.OptionsView.RowAutoHeight = True
        Me.GVListeFOUFAC.OptionsView.ShowGroupPanel = False
        '
        'GColVFACREF
        '
        Me.GColVFACREF.AppearanceHeader.Font = CType(resources.GetObject("GColVFACREF.AppearanceHeader.Font"), System.Drawing.Font)
        Me.GColVFACREF.AppearanceHeader.FontSizeDelta = CType(resources.GetObject("GColVFACREF.AppearanceHeader.FontSizeDelta"), Integer)
        Me.GColVFACREF.AppearanceHeader.FontStyleDelta = CType(resources.GetObject("GColVFACREF.AppearanceHeader.FontStyleDelta"), System.Drawing.FontStyle)
        Me.GColVFACREF.AppearanceHeader.GradientMode = CType(resources.GetObject("GColVFACREF.AppearanceHeader.GradientMode"), System.Drawing.Drawing2D.LinearGradientMode)
        Me.GColVFACREF.AppearanceHeader.Image = CType(resources.GetObject("GColVFACREF.AppearanceHeader.Image"), System.Drawing.Image)
        Me.GColVFACREF.AppearanceHeader.Options.UseFont = True
        Me.GColVFACREF.AppearanceHeader.Options.UseTextOptions = True
        Me.GColVFACREF.AppearanceHeader.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center
        Me.GColVFACREF.AppearanceHeader.TextOptions.VAlignment = DevExpress.Utils.VertAlignment.Center
        resources.ApplyResources(Me.GColVFACREF, "GColVFACREF")
        Me.GColVFACREF.FieldName = "VFACREF"
        Me.GColVFACREF.Name = "GColVFACREF"
        Me.GColVFACREF.OptionsColumn.AllowEdit = False
        Me.GColVFACREF.OptionsColumn.ReadOnly = True
        Me.GColVFACREF.OptionsFilter.AutoFilterCondition = DevExpress.XtraGrid.Columns.AutoFilterCondition.Contains
        '
        'GColFFACHT
        '
        Me.GColFFACHT.AppearanceHeader.Font = CType(resources.GetObject("GColFFACHT.AppearanceHeader.Font"), System.Drawing.Font)
        Me.GColFFACHT.AppearanceHeader.FontSizeDelta = CType(resources.GetObject("GColFFACHT.AppearanceHeader.FontSizeDelta"), Integer)
        Me.GColFFACHT.AppearanceHeader.FontStyleDelta = CType(resources.GetObject("GColFFACHT.AppearanceHeader.FontStyleDelta"), System.Drawing.FontStyle)
        Me.GColFFACHT.AppearanceHeader.GradientMode = CType(resources.GetObject("GColFFACHT.AppearanceHeader.GradientMode"), System.Drawing.Drawing2D.LinearGradientMode)
        Me.GColFFACHT.AppearanceHeader.Image = CType(resources.GetObject("GColFFACHT.AppearanceHeader.Image"), System.Drawing.Image)
        Me.GColFFACHT.AppearanceHeader.Options.UseFont = True
        Me.GColFFACHT.AppearanceHeader.Options.UseTextOptions = True
        Me.GColFFACHT.AppearanceHeader.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center
        Me.GColFFACHT.AppearanceHeader.TextOptions.VAlignment = DevExpress.Utils.VertAlignment.Center
        resources.ApplyResources(Me.GColFFACHT, "GColFFACHT")
        Me.GColFFACHT.FieldName = "FFACHT"
        Me.GColFFACHT.Name = "GColFFACHT"
        Me.GColFFACHT.OptionsColumn.AllowEdit = False
        Me.GColFFACHT.OptionsColumn.ReadOnly = True
        '
        'GColFFACTTC
        '
        Me.GColFFACTTC.AppearanceHeader.Font = CType(resources.GetObject("GColFFACTTC.AppearanceHeader.Font"), System.Drawing.Font)
        Me.GColFFACTTC.AppearanceHeader.FontSizeDelta = CType(resources.GetObject("GColFFACTTC.AppearanceHeader.FontSizeDelta"), Integer)
        Me.GColFFACTTC.AppearanceHeader.FontStyleDelta = CType(resources.GetObject("GColFFACTTC.AppearanceHeader.FontStyleDelta"), System.Drawing.FontStyle)
        Me.GColFFACTTC.AppearanceHeader.GradientMode = CType(resources.GetObject("GColFFACTTC.AppearanceHeader.GradientMode"), System.Drawing.Drawing2D.LinearGradientMode)
        Me.GColFFACTTC.AppearanceHeader.Image = CType(resources.GetObject("GColFFACTTC.AppearanceHeader.Image"), System.Drawing.Image)
        Me.GColFFACTTC.AppearanceHeader.Options.UseFont = True
        Me.GColFFACTTC.AppearanceHeader.Options.UseTextOptions = True
        Me.GColFFACTTC.AppearanceHeader.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center
        Me.GColFFACTTC.AppearanceHeader.TextOptions.VAlignment = DevExpress.Utils.VertAlignment.Center
        resources.ApplyResources(Me.GColFFACTTC, "GColFFACTTC")
        Me.GColFFACTTC.FieldName = "FFACTTC"
        Me.GColFFACTTC.Name = "GColFFACTTC"
        Me.GColFFACTTC.OptionsColumn.AllowEdit = False
        Me.GColFFACTTC.OptionsColumn.ReadOnly = True
        '
        'GColDFACDATE
        '
        Me.GColDFACDATE.AppearanceCell.FontSizeDelta = CType(resources.GetObject("GColDFACDATE.AppearanceCell.FontSizeDelta"), Integer)
        Me.GColDFACDATE.AppearanceCell.FontStyleDelta = CType(resources.GetObject("GColDFACDATE.AppearanceCell.FontStyleDelta"), System.Drawing.FontStyle)
        Me.GColDFACDATE.AppearanceCell.GradientMode = CType(resources.GetObject("GColDFACDATE.AppearanceCell.GradientMode"), System.Drawing.Drawing2D.LinearGradientMode)
        Me.GColDFACDATE.AppearanceCell.Image = CType(resources.GetObject("GColDFACDATE.AppearanceCell.Image"), System.Drawing.Image)
        Me.GColDFACDATE.AppearanceCell.Options.UseTextOptions = True
        Me.GColDFACDATE.AppearanceCell.TextOptions.WordWrap = DevExpress.Utils.WordWrap.NoWrap
        Me.GColDFACDATE.AppearanceHeader.Font = CType(resources.GetObject("GColDFACDATE.AppearanceHeader.Font"), System.Drawing.Font)
        Me.GColDFACDATE.AppearanceHeader.FontSizeDelta = CType(resources.GetObject("GColDFACDATE.AppearanceHeader.FontSizeDelta"), Integer)
        Me.GColDFACDATE.AppearanceHeader.FontStyleDelta = CType(resources.GetObject("GColDFACDATE.AppearanceHeader.FontStyleDelta"), System.Drawing.FontStyle)
        Me.GColDFACDATE.AppearanceHeader.GradientMode = CType(resources.GetObject("GColDFACDATE.AppearanceHeader.GradientMode"), System.Drawing.Drawing2D.LinearGradientMode)
        Me.GColDFACDATE.AppearanceHeader.Image = CType(resources.GetObject("GColDFACDATE.AppearanceHeader.Image"), System.Drawing.Image)
        Me.GColDFACDATE.AppearanceHeader.Options.UseFont = True
        Me.GColDFACDATE.AppearanceHeader.Options.UseTextOptions = True
        Me.GColDFACDATE.AppearanceHeader.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center
        Me.GColDFACDATE.AppearanceHeader.TextOptions.VAlignment = DevExpress.Utils.VertAlignment.Center
        resources.ApplyResources(Me.GColDFACDATE, "GColDFACDATE")
        Me.GColDFACDATE.FieldName = "DFACDATE"
        Me.GColDFACDATE.Name = "GColDFACDATE"
        Me.GColDFACDATE.OptionsColumn.AllowEdit = False
        Me.GColDFACDATE.OptionsColumn.ReadOnly = True
        '
        'GColVSTFNOM
        '
        Me.GColVSTFNOM.AppearanceHeader.Font = CType(resources.GetObject("GColVSTFNOM.AppearanceHeader.Font"), System.Drawing.Font)
        Me.GColVSTFNOM.AppearanceHeader.FontSizeDelta = CType(resources.GetObject("GColVSTFNOM.AppearanceHeader.FontSizeDelta"), Integer)
        Me.GColVSTFNOM.AppearanceHeader.FontStyleDelta = CType(resources.GetObject("GColVSTFNOM.AppearanceHeader.FontStyleDelta"), System.Drawing.FontStyle)
        Me.GColVSTFNOM.AppearanceHeader.GradientMode = CType(resources.GetObject("GColVSTFNOM.AppearanceHeader.GradientMode"), System.Drawing.Drawing2D.LinearGradientMode)
        Me.GColVSTFNOM.AppearanceHeader.Image = CType(resources.GetObject("GColVSTFNOM.AppearanceHeader.Image"), System.Drawing.Image)
        Me.GColVSTFNOM.AppearanceHeader.Options.UseFont = True
        Me.GColVSTFNOM.AppearanceHeader.Options.UseTextOptions = True
        Me.GColVSTFNOM.AppearanceHeader.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center
        Me.GColVSTFNOM.AppearanceHeader.TextOptions.VAlignment = DevExpress.Utils.VertAlignment.Center
        resources.ApplyResources(Me.GColVSTFNOM, "GColVSTFNOM")
        Me.GColVSTFNOM.FieldName = "VSTFNOM"
        Me.GColVSTFNOM.Name = "GColVSTFNOM"
        Me.GColVSTFNOM.OptionsColumn.AllowEdit = False
        Me.GColVSTFNOM.OptionsColumn.ReadOnly = True
        Me.GColVSTFNOM.OptionsFilter.AutoFilterCondition = DevExpress.XtraGrid.Columns.AutoFilterCondition.Contains
        '
        'GColNFOUFACNUM
        '
        resources.ApplyResources(Me.GColNFOUFACNUM, "GColNFOUFACNUM")
        Me.GColNFOUFACNUM.FieldName = "NFOUFACNUM"
        Me.GColNFOUFACNUM.Name = "GColNFOUFACNUM"
        '
        'frmListeFacturesErrorForTransfert
        '
        resources.ApplyResources(Me, "$this")
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.Controls.Add(Me.GrpActions)
        Me.Controls.Add(Me.GrpListe)
        Me.Name = "frmListeFacturesErrorForTransfert"
        Me.GrpActions.ResumeLayout(False)
        Me.GrpListe.ResumeLayout(False)
        CType(Me.GCListeFOUFAC, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.GVListeFOUFAC, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents GrpActions As System.Windows.Forms.GroupBox
    Friend WithEvents BtnFermer As System.Windows.Forms.Button
    Friend WithEvents GrpListe As System.Windows.Forms.GroupBox
    Friend WithEvents BtnMailInfo As System.Windows.Forms.Button
    Private WithEvents GCListeFOUFAC As DevExpress.XtraGrid.GridControl
    Private WithEvents GVListeFOUFAC As DevExpress.XtraGrid.Views.Grid.GridView
    Private WithEvents GColVFACREF As DevExpress.XtraGrid.Columns.GridColumn
    Private WithEvents GColFFACTTC As DevExpress.XtraGrid.Columns.GridColumn
    Private WithEvents GColDFACDATE As DevExpress.XtraGrid.Columns.GridColumn
    Private WithEvents GColVSTFNOM As DevExpress.XtraGrid.Columns.GridColumn
    Private WithEvents GColFFACHT As DevExpress.XtraGrid.Columns.GridColumn
    Private WithEvents GColNFOUFACNUM As DevExpress.XtraGrid.Columns.GridColumn
End Class
