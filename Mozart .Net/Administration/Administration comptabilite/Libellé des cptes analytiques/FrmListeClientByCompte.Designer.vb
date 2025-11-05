<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class FrmListeClientByCompte
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(FrmListeClientByCompte))
        Me.GCListClient = New DevExpress.XtraGrid.GridControl()
        Me.GVListClient = New DevExpress.XtraGrid.Views.Grid.GridView()
        Me.ColVCLINOM = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.ColVPERNOMCHAFF = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.BtnContinue = New System.Windows.Forms.Button()
        Me.BtnAnnuler = New System.Windows.Forms.Button()
        Me.LblTitre = New System.Windows.Forms.Label()
        Me.LblNbLine = New System.Windows.Forms.Label()
        CType(Me.GCListClient, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.GVListClient, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'GCListClient
        '
        resources.ApplyResources(Me.GCListClient, "GCListClient")
        '
        '
        '
        Me.GCListClient.EmbeddedNavigator.AccessibleDescription = resources.GetString("GCListClient.EmbeddedNavigator.AccessibleDescription")
        Me.GCListClient.EmbeddedNavigator.AccessibleName = resources.GetString("GCListClient.EmbeddedNavigator.AccessibleName")
        Me.GCListClient.EmbeddedNavigator.AllowHtmlTextInToolTip = CType(resources.GetObject("GCListClient.EmbeddedNavigator.AllowHtmlTextInToolTip"), DevExpress.Utils.DefaultBoolean)
        Me.GCListClient.EmbeddedNavigator.Anchor = CType(resources.GetObject("GCListClient.EmbeddedNavigator.Anchor"), System.Windows.Forms.AnchorStyles)
        Me.GCListClient.EmbeddedNavigator.BackgroundImage = CType(resources.GetObject("GCListClient.EmbeddedNavigator.BackgroundImage"), System.Drawing.Image)
        Me.GCListClient.EmbeddedNavigator.BackgroundImageLayout = CType(resources.GetObject("GCListClient.EmbeddedNavigator.BackgroundImageLayout"), System.Windows.Forms.ImageLayout)
        Me.GCListClient.EmbeddedNavigator.ImeMode = CType(resources.GetObject("GCListClient.EmbeddedNavigator.ImeMode"), System.Windows.Forms.ImeMode)
        Me.GCListClient.EmbeddedNavigator.MaximumSize = CType(resources.GetObject("GCListClient.EmbeddedNavigator.MaximumSize"), System.Drawing.Size)
        Me.GCListClient.EmbeddedNavigator.TextLocation = CType(resources.GetObject("GCListClient.EmbeddedNavigator.TextLocation"), DevExpress.XtraEditors.NavigatorButtonsTextLocation)
        Me.GCListClient.EmbeddedNavigator.ToolTip = resources.GetString("GCListClient.EmbeddedNavigator.ToolTip")
        Me.GCListClient.EmbeddedNavigator.ToolTipIconType = CType(resources.GetObject("GCListClient.EmbeddedNavigator.ToolTipIconType"), DevExpress.Utils.ToolTipIconType)
        Me.GCListClient.EmbeddedNavigator.ToolTipTitle = resources.GetString("GCListClient.EmbeddedNavigator.ToolTipTitle")
        Me.GCListClient.MainView = Me.GVListClient
        Me.GCListClient.Name = "GCListClient"
        Me.GCListClient.ViewCollection.AddRange(New DevExpress.XtraGrid.Views.Base.BaseView() {Me.GVListClient})
        '
        'GVListClient
        '
        Me.GVListClient.Appearance.ColumnFilterButton.BackColor = CType(resources.GetObject("GVListClient.Appearance.ColumnFilterButton.BackColor"), System.Drawing.Color)
        Me.GVListClient.Appearance.ColumnFilterButton.BackColor2 = CType(resources.GetObject("GVListClient.Appearance.ColumnFilterButton.BackColor2"), System.Drawing.Color)
        Me.GVListClient.Appearance.ColumnFilterButton.BorderColor = CType(resources.GetObject("GVListClient.Appearance.ColumnFilterButton.BorderColor"), System.Drawing.Color)
        Me.GVListClient.Appearance.ColumnFilterButton.FontSizeDelta = CType(resources.GetObject("GVListClient.Appearance.ColumnFilterButton.FontSizeDelta"), Integer)
        Me.GVListClient.Appearance.ColumnFilterButton.FontStyleDelta = CType(resources.GetObject("GVListClient.Appearance.ColumnFilterButton.FontStyleDelta"), System.Drawing.FontStyle)
        Me.GVListClient.Appearance.ColumnFilterButton.ForeColor = CType(resources.GetObject("GVListClient.Appearance.ColumnFilterButton.ForeColor"), System.Drawing.Color)
        Me.GVListClient.Appearance.ColumnFilterButton.GradientMode = CType(resources.GetObject("GVListClient.Appearance.ColumnFilterButton.GradientMode"), System.Drawing.Drawing2D.LinearGradientMode)
        Me.GVListClient.Appearance.ColumnFilterButton.Image = CType(resources.GetObject("GVListClient.Appearance.ColumnFilterButton.Image"), System.Drawing.Image)
        Me.GVListClient.Appearance.ColumnFilterButton.Options.UseBackColor = True
        Me.GVListClient.Appearance.ColumnFilterButton.Options.UseBorderColor = True
        Me.GVListClient.Appearance.ColumnFilterButton.Options.UseForeColor = True
        Me.GVListClient.Appearance.ColumnFilterButtonActive.BackColor = CType(resources.GetObject("GVListClient.Appearance.ColumnFilterButtonActive.BackColor"), System.Drawing.Color)
        Me.GVListClient.Appearance.ColumnFilterButtonActive.BackColor2 = CType(resources.GetObject("GVListClient.Appearance.ColumnFilterButtonActive.BackColor2"), System.Drawing.Color)
        Me.GVListClient.Appearance.ColumnFilterButtonActive.BorderColor = CType(resources.GetObject("GVListClient.Appearance.ColumnFilterButtonActive.BorderColor"), System.Drawing.Color)
        Me.GVListClient.Appearance.ColumnFilterButtonActive.FontSizeDelta = CType(resources.GetObject("GVListClient.Appearance.ColumnFilterButtonActive.FontSizeDelta"), Integer)
        Me.GVListClient.Appearance.ColumnFilterButtonActive.FontStyleDelta = CType(resources.GetObject("GVListClient.Appearance.ColumnFilterButtonActive.FontStyleDelta"), System.Drawing.FontStyle)
        Me.GVListClient.Appearance.ColumnFilterButtonActive.ForeColor = CType(resources.GetObject("GVListClient.Appearance.ColumnFilterButtonActive.ForeColor"), System.Drawing.Color)
        Me.GVListClient.Appearance.ColumnFilterButtonActive.GradientMode = CType(resources.GetObject("GVListClient.Appearance.ColumnFilterButtonActive.GradientMode"), System.Drawing.Drawing2D.LinearGradientMode)
        Me.GVListClient.Appearance.ColumnFilterButtonActive.Image = CType(resources.GetObject("GVListClient.Appearance.ColumnFilterButtonActive.Image"), System.Drawing.Image)
        Me.GVListClient.Appearance.ColumnFilterButtonActive.Options.UseBackColor = True
        Me.GVListClient.Appearance.ColumnFilterButtonActive.Options.UseBorderColor = True
        Me.GVListClient.Appearance.ColumnFilterButtonActive.Options.UseForeColor = True
        Me.GVListClient.Appearance.Empty.BackColor = CType(resources.GetObject("GVListClient.Appearance.Empty.BackColor"), System.Drawing.Color)
        Me.GVListClient.Appearance.Empty.FontSizeDelta = CType(resources.GetObject("GVListClient.Appearance.Empty.FontSizeDelta"), Integer)
        Me.GVListClient.Appearance.Empty.FontStyleDelta = CType(resources.GetObject("GVListClient.Appearance.Empty.FontStyleDelta"), System.Drawing.FontStyle)
        Me.GVListClient.Appearance.Empty.GradientMode = CType(resources.GetObject("GVListClient.Appearance.Empty.GradientMode"), System.Drawing.Drawing2D.LinearGradientMode)
        Me.GVListClient.Appearance.Empty.Image = CType(resources.GetObject("GVListClient.Appearance.Empty.Image"), System.Drawing.Image)
        Me.GVListClient.Appearance.Empty.Options.UseBackColor = True
        Me.GVListClient.Appearance.EvenRow.BackColor = CType(resources.GetObject("GVListClient.Appearance.EvenRow.BackColor"), System.Drawing.Color)
        Me.GVListClient.Appearance.EvenRow.FontSizeDelta = CType(resources.GetObject("GVListClient.Appearance.EvenRow.FontSizeDelta"), Integer)
        Me.GVListClient.Appearance.EvenRow.FontStyleDelta = CType(resources.GetObject("GVListClient.Appearance.EvenRow.FontStyleDelta"), System.Drawing.FontStyle)
        Me.GVListClient.Appearance.EvenRow.ForeColor = CType(resources.GetObject("GVListClient.Appearance.EvenRow.ForeColor"), System.Drawing.Color)
        Me.GVListClient.Appearance.EvenRow.GradientMode = CType(resources.GetObject("GVListClient.Appearance.EvenRow.GradientMode"), System.Drawing.Drawing2D.LinearGradientMode)
        Me.GVListClient.Appearance.EvenRow.Image = CType(resources.GetObject("GVListClient.Appearance.EvenRow.Image"), System.Drawing.Image)
        Me.GVListClient.Appearance.EvenRow.Options.UseBackColor = True
        Me.GVListClient.Appearance.EvenRow.Options.UseForeColor = True
        Me.GVListClient.Appearance.FilterCloseButton.BackColor = CType(resources.GetObject("GVListClient.Appearance.FilterCloseButton.BackColor"), System.Drawing.Color)
        Me.GVListClient.Appearance.FilterCloseButton.BackColor2 = CType(resources.GetObject("GVListClient.Appearance.FilterCloseButton.BackColor2"), System.Drawing.Color)
        Me.GVListClient.Appearance.FilterCloseButton.BorderColor = CType(resources.GetObject("GVListClient.Appearance.FilterCloseButton.BorderColor"), System.Drawing.Color)
        Me.GVListClient.Appearance.FilterCloseButton.FontSizeDelta = CType(resources.GetObject("GVListClient.Appearance.FilterCloseButton.FontSizeDelta"), Integer)
        Me.GVListClient.Appearance.FilterCloseButton.FontStyleDelta = CType(resources.GetObject("GVListClient.Appearance.FilterCloseButton.FontStyleDelta"), System.Drawing.FontStyle)
        Me.GVListClient.Appearance.FilterCloseButton.ForeColor = CType(resources.GetObject("GVListClient.Appearance.FilterCloseButton.ForeColor"), System.Drawing.Color)
        Me.GVListClient.Appearance.FilterCloseButton.GradientMode = CType(resources.GetObject("GVListClient.Appearance.FilterCloseButton.GradientMode"), System.Drawing.Drawing2D.LinearGradientMode)
        Me.GVListClient.Appearance.FilterCloseButton.Image = CType(resources.GetObject("GVListClient.Appearance.FilterCloseButton.Image"), System.Drawing.Image)
        Me.GVListClient.Appearance.FilterCloseButton.Options.UseBackColor = True
        Me.GVListClient.Appearance.FilterCloseButton.Options.UseBorderColor = True
        Me.GVListClient.Appearance.FilterCloseButton.Options.UseForeColor = True
        Me.GVListClient.Appearance.FilterPanel.BackColor = CType(resources.GetObject("GVListClient.Appearance.FilterPanel.BackColor"), System.Drawing.Color)
        Me.GVListClient.Appearance.FilterPanel.FontSizeDelta = CType(resources.GetObject("GVListClient.Appearance.FilterPanel.FontSizeDelta"), Integer)
        Me.GVListClient.Appearance.FilterPanel.FontStyleDelta = CType(resources.GetObject("GVListClient.Appearance.FilterPanel.FontStyleDelta"), System.Drawing.FontStyle)
        Me.GVListClient.Appearance.FilterPanel.ForeColor = CType(resources.GetObject("GVListClient.Appearance.FilterPanel.ForeColor"), System.Drawing.Color)
        Me.GVListClient.Appearance.FilterPanel.GradientMode = CType(resources.GetObject("GVListClient.Appearance.FilterPanel.GradientMode"), System.Drawing.Drawing2D.LinearGradientMode)
        Me.GVListClient.Appearance.FilterPanel.Image = CType(resources.GetObject("GVListClient.Appearance.FilterPanel.Image"), System.Drawing.Image)
        Me.GVListClient.Appearance.FilterPanel.Options.UseBackColor = True
        Me.GVListClient.Appearance.FilterPanel.Options.UseForeColor = True
        Me.GVListClient.Appearance.FixedLine.BackColor = CType(resources.GetObject("GVListClient.Appearance.FixedLine.BackColor"), System.Drawing.Color)
        Me.GVListClient.Appearance.FixedLine.FontSizeDelta = CType(resources.GetObject("GVListClient.Appearance.FixedLine.FontSizeDelta"), Integer)
        Me.GVListClient.Appearance.FixedLine.FontStyleDelta = CType(resources.GetObject("GVListClient.Appearance.FixedLine.FontStyleDelta"), System.Drawing.FontStyle)
        Me.GVListClient.Appearance.FixedLine.GradientMode = CType(resources.GetObject("GVListClient.Appearance.FixedLine.GradientMode"), System.Drawing.Drawing2D.LinearGradientMode)
        Me.GVListClient.Appearance.FixedLine.Image = CType(resources.GetObject("GVListClient.Appearance.FixedLine.Image"), System.Drawing.Image)
        Me.GVListClient.Appearance.FixedLine.Options.UseBackColor = True
        Me.GVListClient.Appearance.FocusedCell.BackColor = CType(resources.GetObject("GVListClient.Appearance.FocusedCell.BackColor"), System.Drawing.Color)
        Me.GVListClient.Appearance.FocusedCell.FontSizeDelta = CType(resources.GetObject("GVListClient.Appearance.FocusedCell.FontSizeDelta"), Integer)
        Me.GVListClient.Appearance.FocusedCell.FontStyleDelta = CType(resources.GetObject("GVListClient.Appearance.FocusedCell.FontStyleDelta"), System.Drawing.FontStyle)
        Me.GVListClient.Appearance.FocusedCell.ForeColor = CType(resources.GetObject("GVListClient.Appearance.FocusedCell.ForeColor"), System.Drawing.Color)
        Me.GVListClient.Appearance.FocusedCell.GradientMode = CType(resources.GetObject("GVListClient.Appearance.FocusedCell.GradientMode"), System.Drawing.Drawing2D.LinearGradientMode)
        Me.GVListClient.Appearance.FocusedCell.Image = CType(resources.GetObject("GVListClient.Appearance.FocusedCell.Image"), System.Drawing.Image)
        Me.GVListClient.Appearance.FocusedCell.Options.UseBackColor = True
        Me.GVListClient.Appearance.FocusedCell.Options.UseForeColor = True
        Me.GVListClient.Appearance.FocusedRow.BackColor = CType(resources.GetObject("GVListClient.Appearance.FocusedRow.BackColor"), System.Drawing.Color)
        Me.GVListClient.Appearance.FocusedRow.FontSizeDelta = CType(resources.GetObject("GVListClient.Appearance.FocusedRow.FontSizeDelta"), Integer)
        Me.GVListClient.Appearance.FocusedRow.FontStyleDelta = CType(resources.GetObject("GVListClient.Appearance.FocusedRow.FontStyleDelta"), System.Drawing.FontStyle)
        Me.GVListClient.Appearance.FocusedRow.ForeColor = CType(resources.GetObject("GVListClient.Appearance.FocusedRow.ForeColor"), System.Drawing.Color)
        Me.GVListClient.Appearance.FocusedRow.GradientMode = CType(resources.GetObject("GVListClient.Appearance.FocusedRow.GradientMode"), System.Drawing.Drawing2D.LinearGradientMode)
        Me.GVListClient.Appearance.FocusedRow.Image = CType(resources.GetObject("GVListClient.Appearance.FocusedRow.Image"), System.Drawing.Image)
        Me.GVListClient.Appearance.FocusedRow.Options.UseBackColor = True
        Me.GVListClient.Appearance.FocusedRow.Options.UseForeColor = True
        Me.GVListClient.Appearance.FooterPanel.BackColor = CType(resources.GetObject("GVListClient.Appearance.FooterPanel.BackColor"), System.Drawing.Color)
        Me.GVListClient.Appearance.FooterPanel.BackColor2 = CType(resources.GetObject("GVListClient.Appearance.FooterPanel.BackColor2"), System.Drawing.Color)
        Me.GVListClient.Appearance.FooterPanel.BorderColor = CType(resources.GetObject("GVListClient.Appearance.FooterPanel.BorderColor"), System.Drawing.Color)
        Me.GVListClient.Appearance.FooterPanel.FontSizeDelta = CType(resources.GetObject("GVListClient.Appearance.FooterPanel.FontSizeDelta"), Integer)
        Me.GVListClient.Appearance.FooterPanel.FontStyleDelta = CType(resources.GetObject("GVListClient.Appearance.FooterPanel.FontStyleDelta"), System.Drawing.FontStyle)
        Me.GVListClient.Appearance.FooterPanel.ForeColor = CType(resources.GetObject("GVListClient.Appearance.FooterPanel.ForeColor"), System.Drawing.Color)
        Me.GVListClient.Appearance.FooterPanel.GradientMode = CType(resources.GetObject("GVListClient.Appearance.FooterPanel.GradientMode"), System.Drawing.Drawing2D.LinearGradientMode)
        Me.GVListClient.Appearance.FooterPanel.Image = CType(resources.GetObject("GVListClient.Appearance.FooterPanel.Image"), System.Drawing.Image)
        Me.GVListClient.Appearance.FooterPanel.Options.UseBackColor = True
        Me.GVListClient.Appearance.FooterPanel.Options.UseBorderColor = True
        Me.GVListClient.Appearance.FooterPanel.Options.UseForeColor = True
        Me.GVListClient.Appearance.GroupButton.BackColor = CType(resources.GetObject("GVListClient.Appearance.GroupButton.BackColor"), System.Drawing.Color)
        Me.GVListClient.Appearance.GroupButton.BorderColor = CType(resources.GetObject("GVListClient.Appearance.GroupButton.BorderColor"), System.Drawing.Color)
        Me.GVListClient.Appearance.GroupButton.FontSizeDelta = CType(resources.GetObject("GVListClient.Appearance.GroupButton.FontSizeDelta"), Integer)
        Me.GVListClient.Appearance.GroupButton.FontStyleDelta = CType(resources.GetObject("GVListClient.Appearance.GroupButton.FontStyleDelta"), System.Drawing.FontStyle)
        Me.GVListClient.Appearance.GroupButton.ForeColor = CType(resources.GetObject("GVListClient.Appearance.GroupButton.ForeColor"), System.Drawing.Color)
        Me.GVListClient.Appearance.GroupButton.GradientMode = CType(resources.GetObject("GVListClient.Appearance.GroupButton.GradientMode"), System.Drawing.Drawing2D.LinearGradientMode)
        Me.GVListClient.Appearance.GroupButton.Image = CType(resources.GetObject("GVListClient.Appearance.GroupButton.Image"), System.Drawing.Image)
        Me.GVListClient.Appearance.GroupButton.Options.UseBackColor = True
        Me.GVListClient.Appearance.GroupButton.Options.UseBorderColor = True
        Me.GVListClient.Appearance.GroupButton.Options.UseForeColor = True
        Me.GVListClient.Appearance.GroupFooter.BackColor = CType(resources.GetObject("GVListClient.Appearance.GroupFooter.BackColor"), System.Drawing.Color)
        Me.GVListClient.Appearance.GroupFooter.BorderColor = CType(resources.GetObject("GVListClient.Appearance.GroupFooter.BorderColor"), System.Drawing.Color)
        Me.GVListClient.Appearance.GroupFooter.FontSizeDelta = CType(resources.GetObject("GVListClient.Appearance.GroupFooter.FontSizeDelta"), Integer)
        Me.GVListClient.Appearance.GroupFooter.FontStyleDelta = CType(resources.GetObject("GVListClient.Appearance.GroupFooter.FontStyleDelta"), System.Drawing.FontStyle)
        Me.GVListClient.Appearance.GroupFooter.ForeColor = CType(resources.GetObject("GVListClient.Appearance.GroupFooter.ForeColor"), System.Drawing.Color)
        Me.GVListClient.Appearance.GroupFooter.GradientMode = CType(resources.GetObject("GVListClient.Appearance.GroupFooter.GradientMode"), System.Drawing.Drawing2D.LinearGradientMode)
        Me.GVListClient.Appearance.GroupFooter.Image = CType(resources.GetObject("GVListClient.Appearance.GroupFooter.Image"), System.Drawing.Image)
        Me.GVListClient.Appearance.GroupFooter.Options.UseBackColor = True
        Me.GVListClient.Appearance.GroupFooter.Options.UseBorderColor = True
        Me.GVListClient.Appearance.GroupFooter.Options.UseForeColor = True
        Me.GVListClient.Appearance.GroupPanel.BackColor = CType(resources.GetObject("GVListClient.Appearance.GroupPanel.BackColor"), System.Drawing.Color)
        Me.GVListClient.Appearance.GroupPanel.FontSizeDelta = CType(resources.GetObject("GVListClient.Appearance.GroupPanel.FontSizeDelta"), Integer)
        Me.GVListClient.Appearance.GroupPanel.FontStyleDelta = CType(resources.GetObject("GVListClient.Appearance.GroupPanel.FontStyleDelta"), System.Drawing.FontStyle)
        Me.GVListClient.Appearance.GroupPanel.ForeColor = CType(resources.GetObject("GVListClient.Appearance.GroupPanel.ForeColor"), System.Drawing.Color)
        Me.GVListClient.Appearance.GroupPanel.GradientMode = CType(resources.GetObject("GVListClient.Appearance.GroupPanel.GradientMode"), System.Drawing.Drawing2D.LinearGradientMode)
        Me.GVListClient.Appearance.GroupPanel.Image = CType(resources.GetObject("GVListClient.Appearance.GroupPanel.Image"), System.Drawing.Image)
        Me.GVListClient.Appearance.GroupPanel.Options.UseBackColor = True
        Me.GVListClient.Appearance.GroupPanel.Options.UseForeColor = True
        Me.GVListClient.Appearance.GroupRow.BackColor = CType(resources.GetObject("GVListClient.Appearance.GroupRow.BackColor"), System.Drawing.Color)
        Me.GVListClient.Appearance.GroupRow.BorderColor = CType(resources.GetObject("GVListClient.Appearance.GroupRow.BorderColor"), System.Drawing.Color)
        Me.GVListClient.Appearance.GroupRow.Font = CType(resources.GetObject("GVListClient.Appearance.GroupRow.Font"), System.Drawing.Font)
        Me.GVListClient.Appearance.GroupRow.FontSizeDelta = CType(resources.GetObject("GVListClient.Appearance.GroupRow.FontSizeDelta"), Integer)
        Me.GVListClient.Appearance.GroupRow.FontStyleDelta = CType(resources.GetObject("GVListClient.Appearance.GroupRow.FontStyleDelta"), System.Drawing.FontStyle)
        Me.GVListClient.Appearance.GroupRow.ForeColor = CType(resources.GetObject("GVListClient.Appearance.GroupRow.ForeColor"), System.Drawing.Color)
        Me.GVListClient.Appearance.GroupRow.GradientMode = CType(resources.GetObject("GVListClient.Appearance.GroupRow.GradientMode"), System.Drawing.Drawing2D.LinearGradientMode)
        Me.GVListClient.Appearance.GroupRow.Image = CType(resources.GetObject("GVListClient.Appearance.GroupRow.Image"), System.Drawing.Image)
        Me.GVListClient.Appearance.GroupRow.Options.UseBackColor = True
        Me.GVListClient.Appearance.GroupRow.Options.UseBorderColor = True
        Me.GVListClient.Appearance.GroupRow.Options.UseFont = True
        Me.GVListClient.Appearance.GroupRow.Options.UseForeColor = True
        Me.GVListClient.Appearance.HeaderPanel.BackColor = CType(resources.GetObject("GVListClient.Appearance.HeaderPanel.BackColor"), System.Drawing.Color)
        Me.GVListClient.Appearance.HeaderPanel.BackColor2 = CType(resources.GetObject("GVListClient.Appearance.HeaderPanel.BackColor2"), System.Drawing.Color)
        Me.GVListClient.Appearance.HeaderPanel.BorderColor = CType(resources.GetObject("GVListClient.Appearance.HeaderPanel.BorderColor"), System.Drawing.Color)
        Me.GVListClient.Appearance.HeaderPanel.Font = CType(resources.GetObject("GVListClient.Appearance.HeaderPanel.Font"), System.Drawing.Font)
        Me.GVListClient.Appearance.HeaderPanel.FontSizeDelta = CType(resources.GetObject("GVListClient.Appearance.HeaderPanel.FontSizeDelta"), Integer)
        Me.GVListClient.Appearance.HeaderPanel.FontStyleDelta = CType(resources.GetObject("GVListClient.Appearance.HeaderPanel.FontStyleDelta"), System.Drawing.FontStyle)
        Me.GVListClient.Appearance.HeaderPanel.ForeColor = CType(resources.GetObject("GVListClient.Appearance.HeaderPanel.ForeColor"), System.Drawing.Color)
        Me.GVListClient.Appearance.HeaderPanel.GradientMode = CType(resources.GetObject("GVListClient.Appearance.HeaderPanel.GradientMode"), System.Drawing.Drawing2D.LinearGradientMode)
        Me.GVListClient.Appearance.HeaderPanel.Image = CType(resources.GetObject("GVListClient.Appearance.HeaderPanel.Image"), System.Drawing.Image)
        Me.GVListClient.Appearance.HeaderPanel.Options.UseBackColor = True
        Me.GVListClient.Appearance.HeaderPanel.Options.UseBorderColor = True
        Me.GVListClient.Appearance.HeaderPanel.Options.UseFont = True
        Me.GVListClient.Appearance.HeaderPanel.Options.UseForeColor = True
        Me.GVListClient.Appearance.HeaderPanel.Options.UseTextOptions = True
        Me.GVListClient.Appearance.HeaderPanel.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center
        Me.GVListClient.Appearance.HeaderPanel.TextOptions.VAlignment = DevExpress.Utils.VertAlignment.Center
        Me.GVListClient.Appearance.HeaderPanel.TextOptions.WordWrap = DevExpress.Utils.WordWrap.Wrap
        Me.GVListClient.Appearance.HideSelectionRow.BackColor = CType(resources.GetObject("GVListClient.Appearance.HideSelectionRow.BackColor"), System.Drawing.Color)
        Me.GVListClient.Appearance.HideSelectionRow.FontSizeDelta = CType(resources.GetObject("GVListClient.Appearance.HideSelectionRow.FontSizeDelta"), Integer)
        Me.GVListClient.Appearance.HideSelectionRow.FontStyleDelta = CType(resources.GetObject("GVListClient.Appearance.HideSelectionRow.FontStyleDelta"), System.Drawing.FontStyle)
        Me.GVListClient.Appearance.HideSelectionRow.ForeColor = CType(resources.GetObject("GVListClient.Appearance.HideSelectionRow.ForeColor"), System.Drawing.Color)
        Me.GVListClient.Appearance.HideSelectionRow.GradientMode = CType(resources.GetObject("GVListClient.Appearance.HideSelectionRow.GradientMode"), System.Drawing.Drawing2D.LinearGradientMode)
        Me.GVListClient.Appearance.HideSelectionRow.Image = CType(resources.GetObject("GVListClient.Appearance.HideSelectionRow.Image"), System.Drawing.Image)
        Me.GVListClient.Appearance.HideSelectionRow.Options.UseBackColor = True
        Me.GVListClient.Appearance.HideSelectionRow.Options.UseForeColor = True
        Me.GVListClient.Appearance.HorzLine.BackColor = CType(resources.GetObject("GVListClient.Appearance.HorzLine.BackColor"), System.Drawing.Color)
        Me.GVListClient.Appearance.HorzLine.FontSizeDelta = CType(resources.GetObject("GVListClient.Appearance.HorzLine.FontSizeDelta"), Integer)
        Me.GVListClient.Appearance.HorzLine.FontStyleDelta = CType(resources.GetObject("GVListClient.Appearance.HorzLine.FontStyleDelta"), System.Drawing.FontStyle)
        Me.GVListClient.Appearance.HorzLine.GradientMode = CType(resources.GetObject("GVListClient.Appearance.HorzLine.GradientMode"), System.Drawing.Drawing2D.LinearGradientMode)
        Me.GVListClient.Appearance.HorzLine.Image = CType(resources.GetObject("GVListClient.Appearance.HorzLine.Image"), System.Drawing.Image)
        Me.GVListClient.Appearance.HorzLine.Options.UseBackColor = True
        Me.GVListClient.Appearance.OddRow.BackColor = CType(resources.GetObject("GVListClient.Appearance.OddRow.BackColor"), System.Drawing.Color)
        Me.GVListClient.Appearance.OddRow.FontSizeDelta = CType(resources.GetObject("GVListClient.Appearance.OddRow.FontSizeDelta"), Integer)
        Me.GVListClient.Appearance.OddRow.FontStyleDelta = CType(resources.GetObject("GVListClient.Appearance.OddRow.FontStyleDelta"), System.Drawing.FontStyle)
        Me.GVListClient.Appearance.OddRow.ForeColor = CType(resources.GetObject("GVListClient.Appearance.OddRow.ForeColor"), System.Drawing.Color)
        Me.GVListClient.Appearance.OddRow.GradientMode = CType(resources.GetObject("GVListClient.Appearance.OddRow.GradientMode"), System.Drawing.Drawing2D.LinearGradientMode)
        Me.GVListClient.Appearance.OddRow.Image = CType(resources.GetObject("GVListClient.Appearance.OddRow.Image"), System.Drawing.Image)
        Me.GVListClient.Appearance.OddRow.Options.UseBackColor = True
        Me.GVListClient.Appearance.OddRow.Options.UseForeColor = True
        Me.GVListClient.Appearance.Preview.BackColor = CType(resources.GetObject("GVListClient.Appearance.Preview.BackColor"), System.Drawing.Color)
        Me.GVListClient.Appearance.Preview.FontSizeDelta = CType(resources.GetObject("GVListClient.Appearance.Preview.FontSizeDelta"), Integer)
        Me.GVListClient.Appearance.Preview.FontStyleDelta = CType(resources.GetObject("GVListClient.Appearance.Preview.FontStyleDelta"), System.Drawing.FontStyle)
        Me.GVListClient.Appearance.Preview.ForeColor = CType(resources.GetObject("GVListClient.Appearance.Preview.ForeColor"), System.Drawing.Color)
        Me.GVListClient.Appearance.Preview.GradientMode = CType(resources.GetObject("GVListClient.Appearance.Preview.GradientMode"), System.Drawing.Drawing2D.LinearGradientMode)
        Me.GVListClient.Appearance.Preview.Image = CType(resources.GetObject("GVListClient.Appearance.Preview.Image"), System.Drawing.Image)
        Me.GVListClient.Appearance.Preview.Options.UseBackColor = True
        Me.GVListClient.Appearance.Preview.Options.UseForeColor = True
        Me.GVListClient.Appearance.Row.BackColor = CType(resources.GetObject("GVListClient.Appearance.Row.BackColor"), System.Drawing.Color)
        Me.GVListClient.Appearance.Row.FontSizeDelta = CType(resources.GetObject("GVListClient.Appearance.Row.FontSizeDelta"), Integer)
        Me.GVListClient.Appearance.Row.FontStyleDelta = CType(resources.GetObject("GVListClient.Appearance.Row.FontStyleDelta"), System.Drawing.FontStyle)
        Me.GVListClient.Appearance.Row.ForeColor = CType(resources.GetObject("GVListClient.Appearance.Row.ForeColor"), System.Drawing.Color)
        Me.GVListClient.Appearance.Row.GradientMode = CType(resources.GetObject("GVListClient.Appearance.Row.GradientMode"), System.Drawing.Drawing2D.LinearGradientMode)
        Me.GVListClient.Appearance.Row.Image = CType(resources.GetObject("GVListClient.Appearance.Row.Image"), System.Drawing.Image)
        Me.GVListClient.Appearance.Row.Options.UseBackColor = True
        Me.GVListClient.Appearance.Row.Options.UseForeColor = True
        Me.GVListClient.Appearance.RowSeparator.BackColor = CType(resources.GetObject("GVListClient.Appearance.RowSeparator.BackColor"), System.Drawing.Color)
        Me.GVListClient.Appearance.RowSeparator.FontSizeDelta = CType(resources.GetObject("GVListClient.Appearance.RowSeparator.FontSizeDelta"), Integer)
        Me.GVListClient.Appearance.RowSeparator.FontStyleDelta = CType(resources.GetObject("GVListClient.Appearance.RowSeparator.FontStyleDelta"), System.Drawing.FontStyle)
        Me.GVListClient.Appearance.RowSeparator.GradientMode = CType(resources.GetObject("GVListClient.Appearance.RowSeparator.GradientMode"), System.Drawing.Drawing2D.LinearGradientMode)
        Me.GVListClient.Appearance.RowSeparator.Image = CType(resources.GetObject("GVListClient.Appearance.RowSeparator.Image"), System.Drawing.Image)
        Me.GVListClient.Appearance.RowSeparator.Options.UseBackColor = True
        Me.GVListClient.Appearance.SelectedRow.BackColor = CType(resources.GetObject("GVListClient.Appearance.SelectedRow.BackColor"), System.Drawing.Color)
        Me.GVListClient.Appearance.SelectedRow.FontSizeDelta = CType(resources.GetObject("GVListClient.Appearance.SelectedRow.FontSizeDelta"), Integer)
        Me.GVListClient.Appearance.SelectedRow.FontStyleDelta = CType(resources.GetObject("GVListClient.Appearance.SelectedRow.FontStyleDelta"), System.Drawing.FontStyle)
        Me.GVListClient.Appearance.SelectedRow.ForeColor = CType(resources.GetObject("GVListClient.Appearance.SelectedRow.ForeColor"), System.Drawing.Color)
        Me.GVListClient.Appearance.SelectedRow.GradientMode = CType(resources.GetObject("GVListClient.Appearance.SelectedRow.GradientMode"), System.Drawing.Drawing2D.LinearGradientMode)
        Me.GVListClient.Appearance.SelectedRow.Image = CType(resources.GetObject("GVListClient.Appearance.SelectedRow.Image"), System.Drawing.Image)
        Me.GVListClient.Appearance.SelectedRow.Options.UseBackColor = True
        Me.GVListClient.Appearance.SelectedRow.Options.UseForeColor = True
        Me.GVListClient.Appearance.VertLine.BackColor = CType(resources.GetObject("GVListClient.Appearance.VertLine.BackColor"), System.Drawing.Color)
        Me.GVListClient.Appearance.VertLine.FontSizeDelta = CType(resources.GetObject("GVListClient.Appearance.VertLine.FontSizeDelta"), Integer)
        Me.GVListClient.Appearance.VertLine.FontStyleDelta = CType(resources.GetObject("GVListClient.Appearance.VertLine.FontStyleDelta"), System.Drawing.FontStyle)
        Me.GVListClient.Appearance.VertLine.GradientMode = CType(resources.GetObject("GVListClient.Appearance.VertLine.GradientMode"), System.Drawing.Drawing2D.LinearGradientMode)
        Me.GVListClient.Appearance.VertLine.Image = CType(resources.GetObject("GVListClient.Appearance.VertLine.Image"), System.Drawing.Image)
        Me.GVListClient.Appearance.VertLine.Options.UseBackColor = True
        resources.ApplyResources(Me.GVListClient, "GVListClient")
        Me.GVListClient.Columns.AddRange(New DevExpress.XtraGrid.Columns.GridColumn() {Me.ColVCLINOM, Me.ColVPERNOMCHAFF})
        Me.GVListClient.GridControl = Me.GCListClient
        Me.GVListClient.Name = "GVListClient"
        Me.GVListClient.OptionsBehavior.Editable = False
        Me.GVListClient.OptionsBehavior.ReadOnly = True
        Me.GVListClient.OptionsView.EnableAppearanceEvenRow = True
        Me.GVListClient.OptionsView.EnableAppearanceOddRow = True
        Me.GVListClient.OptionsView.ShowGroupPanel = False
        '
        'ColVCLINOM
        '
        resources.ApplyResources(Me.ColVCLINOM, "ColVCLINOM")
        Me.ColVCLINOM.FieldName = "VCLINOM"
        Me.ColVCLINOM.Name = "ColVCLINOM"
        '
        'ColVPERNOMCHAFF
        '
        resources.ApplyResources(Me.ColVPERNOMCHAFF, "ColVPERNOMCHAFF")
        Me.ColVPERNOMCHAFF.FieldName = "VPERNOMCHAFF"
        Me.ColVPERNOMCHAFF.Name = "ColVPERNOMCHAFF"
        '
        'BtnContinue
        '
        resources.ApplyResources(Me.BtnContinue, "BtnContinue")
        Me.BtnContinue.Name = "BtnContinue"
        Me.BtnContinue.UseVisualStyleBackColor = True
        '
        'BtnAnnuler
        '
        resources.ApplyResources(Me.BtnAnnuler, "BtnAnnuler")
        Me.BtnAnnuler.Name = "BtnAnnuler"
        Me.BtnAnnuler.UseVisualStyleBackColor = True
        '
        'LblTitre
        '
        resources.ApplyResources(Me.LblTitre, "LblTitre")
        Me.LblTitre.Name = "LblTitre"
        '
        'LblNbLine
        '
        resources.ApplyResources(Me.LblNbLine, "LblNbLine")
        Me.LblNbLine.Name = "LblNbLine"
        '
        'FrmListeClientByCompte
        '
        resources.ApplyResources(Me, "$this")
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.Wheat
        Me.Controls.Add(Me.LblNbLine)
        Me.Controls.Add(Me.LblTitre)
        Me.Controls.Add(Me.BtnAnnuler)
        Me.Controls.Add(Me.BtnContinue)
        Me.Controls.Add(Me.GCListClient)
        Me.Name = "FrmListeClientByCompte"
        CType(Me.GCListClient, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.GVListClient, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents BtnContinue As System.Windows.Forms.Button
    Friend WithEvents BtnAnnuler As System.Windows.Forms.Button
    Friend WithEvents LblTitre As System.Windows.Forms.Label
    Friend WithEvents LblNbLine As System.Windows.Forms.Label
    Private WithEvents GCListClient As DevExpress.XtraGrid.GridControl
    Private WithEvents GVListClient As DevExpress.XtraGrid.Views.Grid.GridView
    Private WithEvents ColVCLINOM As DevExpress.XtraGrid.Columns.GridColumn
    Private WithEvents ColVPERNOMCHAFF As DevExpress.XtraGrid.Columns.GridColumn
End Class
