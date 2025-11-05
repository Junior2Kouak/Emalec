<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmGestionDocChantier
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(frmGestionDocChantier))
        Me.GrpActions = New System.Windows.Forms.GroupBox()
        Me.BtnPrint = New System.Windows.Forms.Button()
        Me.BtnSupprimer = New System.Windows.Forms.Button()
        Me.BtnAjouter = New System.Windows.Forms.Button()
        Me.BtnFermer = New System.Windows.Forms.Button()
        Me.BtnSave = New System.Windows.Forms.Button()
        Me.GrpListe = New System.Windows.Forms.GroupBox()
        Me.GCChantierDoc = New DevExpress.XtraGrid.GridControl()
        Me.GVChantierDoc = New DevExpress.XtraGrid.Views.Grid.GridView()
        Me.GColIDTMP = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.GColNIDCHANTIERDOC = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.GColNIDCHANTIER = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.GColVFILE = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.GColDQUICREE = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.GColVQUICREE = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.GColFICTMP = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.GrpApercu = New System.Windows.Forms.GroupBox()
        Me.WBApercu = New System.Windows.Forms.WebBrowser()
        Me.OFD = New System.Windows.Forms.OpenFileDialog()
        Me.GrpActions.SuspendLayout()
        Me.GrpListe.SuspendLayout()
        CType(Me.GCChantierDoc, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.GVChantierDoc, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.GrpApercu.SuspendLayout()
        Me.SuspendLayout()
        '
        'GrpActions
        '
        resources.ApplyResources(Me.GrpActions, "GrpActions")
        Me.GrpActions.Controls.Add(Me.BtnPrint)
        Me.GrpActions.Controls.Add(Me.BtnSupprimer)
        Me.GrpActions.Controls.Add(Me.BtnAjouter)
        Me.GrpActions.Controls.Add(Me.BtnFermer)
        Me.GrpActions.Controls.Add(Me.BtnSave)
        Me.GrpActions.Name = "GrpActions"
        Me.GrpActions.TabStop = False
        '
        'BtnPrint
        '
        resources.ApplyResources(Me.BtnPrint, "BtnPrint")
        Me.BtnPrint.Name = "BtnPrint"
        Me.BtnPrint.UseVisualStyleBackColor = True
        '
        'BtnSupprimer
        '
        resources.ApplyResources(Me.BtnSupprimer, "BtnSupprimer")
        Me.BtnSupprimer.Name = "BtnSupprimer"
        Me.BtnSupprimer.UseVisualStyleBackColor = True
        '
        'BtnAjouter
        '
        resources.ApplyResources(Me.BtnAjouter, "BtnAjouter")
        Me.BtnAjouter.Name = "BtnAjouter"
        Me.BtnAjouter.UseVisualStyleBackColor = True
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
        'GrpListe
        '
        resources.ApplyResources(Me.GrpListe, "GrpListe")
        Me.GrpListe.Controls.Add(Me.GCChantierDoc)
        Me.GrpListe.Name = "GrpListe"
        Me.GrpListe.TabStop = False
        '
        'GCChantierDoc
        '
        resources.ApplyResources(Me.GCChantierDoc, "GCChantierDoc")
        '
        '
        '
        Me.GCChantierDoc.EmbeddedNavigator.AccessibleDescription = resources.GetString("GCChantierDoc.EmbeddedNavigator.AccessibleDescription")
        Me.GCChantierDoc.EmbeddedNavigator.AccessibleName = resources.GetString("GCChantierDoc.EmbeddedNavigator.AccessibleName")
        Me.GCChantierDoc.EmbeddedNavigator.AllowHtmlTextInToolTip = CType(resources.GetObject("GCChantierDoc.EmbeddedNavigator.AllowHtmlTextInToolTip"), DevExpress.Utils.DefaultBoolean)
        Me.GCChantierDoc.EmbeddedNavigator.Anchor = CType(resources.GetObject("GCChantierDoc.EmbeddedNavigator.Anchor"), System.Windows.Forms.AnchorStyles)
        Me.GCChantierDoc.EmbeddedNavigator.BackgroundImage = CType(resources.GetObject("GCChantierDoc.EmbeddedNavigator.BackgroundImage"), System.Drawing.Image)
        Me.GCChantierDoc.EmbeddedNavigator.BackgroundImageLayout = CType(resources.GetObject("GCChantierDoc.EmbeddedNavigator.BackgroundImageLayout"), System.Windows.Forms.ImageLayout)
        Me.GCChantierDoc.EmbeddedNavigator.ImeMode = CType(resources.GetObject("GCChantierDoc.EmbeddedNavigator.ImeMode"), System.Windows.Forms.ImeMode)
        Me.GCChantierDoc.EmbeddedNavigator.MaximumSize = CType(resources.GetObject("GCChantierDoc.EmbeddedNavigator.MaximumSize"), System.Drawing.Size)
        Me.GCChantierDoc.EmbeddedNavigator.TextLocation = CType(resources.GetObject("GCChantierDoc.EmbeddedNavigator.TextLocation"), DevExpress.XtraEditors.NavigatorButtonsTextLocation)
        Me.GCChantierDoc.EmbeddedNavigator.ToolTip = resources.GetString("GCChantierDoc.EmbeddedNavigator.ToolTip")
        Me.GCChantierDoc.EmbeddedNavigator.ToolTipIconType = CType(resources.GetObject("GCChantierDoc.EmbeddedNavigator.ToolTipIconType"), DevExpress.Utils.ToolTipIconType)
        Me.GCChantierDoc.EmbeddedNavigator.ToolTipTitle = resources.GetString("GCChantierDoc.EmbeddedNavigator.ToolTipTitle")
        Me.GCChantierDoc.MainView = Me.GVChantierDoc
        Me.GCChantierDoc.Name = "GCChantierDoc"
        Me.GCChantierDoc.ViewCollection.AddRange(New DevExpress.XtraGrid.Views.Base.BaseView() {Me.GVChantierDoc})
        '
        'GVChantierDoc
        '
        Me.GVChantierDoc.Appearance.ColumnFilterButton.BackColor = CType(resources.GetObject("GVChantierDoc.Appearance.ColumnFilterButton.BackColor"), System.Drawing.Color)
        Me.GVChantierDoc.Appearance.ColumnFilterButton.BackColor2 = CType(resources.GetObject("GVChantierDoc.Appearance.ColumnFilterButton.BackColor2"), System.Drawing.Color)
        Me.GVChantierDoc.Appearance.ColumnFilterButton.BorderColor = CType(resources.GetObject("GVChantierDoc.Appearance.ColumnFilterButton.BorderColor"), System.Drawing.Color)
        Me.GVChantierDoc.Appearance.ColumnFilterButton.FontSizeDelta = CType(resources.GetObject("GVChantierDoc.Appearance.ColumnFilterButton.FontSizeDelta"), Integer)
        Me.GVChantierDoc.Appearance.ColumnFilterButton.FontStyleDelta = CType(resources.GetObject("GVChantierDoc.Appearance.ColumnFilterButton.FontStyleDelta"), System.Drawing.FontStyle)
        Me.GVChantierDoc.Appearance.ColumnFilterButton.ForeColor = CType(resources.GetObject("GVChantierDoc.Appearance.ColumnFilterButton.ForeColor"), System.Drawing.Color)
        Me.GVChantierDoc.Appearance.ColumnFilterButton.GradientMode = CType(resources.GetObject("GVChantierDoc.Appearance.ColumnFilterButton.GradientMode"), System.Drawing.Drawing2D.LinearGradientMode)
        Me.GVChantierDoc.Appearance.ColumnFilterButton.Image = CType(resources.GetObject("GVChantierDoc.Appearance.ColumnFilterButton.Image"), System.Drawing.Image)
        Me.GVChantierDoc.Appearance.ColumnFilterButton.Options.UseBackColor = True
        Me.GVChantierDoc.Appearance.ColumnFilterButton.Options.UseBorderColor = True
        Me.GVChantierDoc.Appearance.ColumnFilterButton.Options.UseForeColor = True
        Me.GVChantierDoc.Appearance.ColumnFilterButtonActive.BackColor = CType(resources.GetObject("GVChantierDoc.Appearance.ColumnFilterButtonActive.BackColor"), System.Drawing.Color)
        Me.GVChantierDoc.Appearance.ColumnFilterButtonActive.BackColor2 = CType(resources.GetObject("GVChantierDoc.Appearance.ColumnFilterButtonActive.BackColor2"), System.Drawing.Color)
        Me.GVChantierDoc.Appearance.ColumnFilterButtonActive.BorderColor = CType(resources.GetObject("GVChantierDoc.Appearance.ColumnFilterButtonActive.BorderColor"), System.Drawing.Color)
        Me.GVChantierDoc.Appearance.ColumnFilterButtonActive.FontSizeDelta = CType(resources.GetObject("GVChantierDoc.Appearance.ColumnFilterButtonActive.FontSizeDelta"), Integer)
        Me.GVChantierDoc.Appearance.ColumnFilterButtonActive.FontStyleDelta = CType(resources.GetObject("GVChantierDoc.Appearance.ColumnFilterButtonActive.FontStyleDelta"), System.Drawing.FontStyle)
        Me.GVChantierDoc.Appearance.ColumnFilterButtonActive.ForeColor = CType(resources.GetObject("GVChantierDoc.Appearance.ColumnFilterButtonActive.ForeColor"), System.Drawing.Color)
        Me.GVChantierDoc.Appearance.ColumnFilterButtonActive.GradientMode = CType(resources.GetObject("GVChantierDoc.Appearance.ColumnFilterButtonActive.GradientMode"), System.Drawing.Drawing2D.LinearGradientMode)
        Me.GVChantierDoc.Appearance.ColumnFilterButtonActive.Image = CType(resources.GetObject("GVChantierDoc.Appearance.ColumnFilterButtonActive.Image"), System.Drawing.Image)
        Me.GVChantierDoc.Appearance.ColumnFilterButtonActive.Options.UseBackColor = True
        Me.GVChantierDoc.Appearance.ColumnFilterButtonActive.Options.UseBorderColor = True
        Me.GVChantierDoc.Appearance.ColumnFilterButtonActive.Options.UseForeColor = True
        Me.GVChantierDoc.Appearance.Empty.BackColor = CType(resources.GetObject("GVChantierDoc.Appearance.Empty.BackColor"), System.Drawing.Color)
        Me.GVChantierDoc.Appearance.Empty.FontSizeDelta = CType(resources.GetObject("GVChantierDoc.Appearance.Empty.FontSizeDelta"), Integer)
        Me.GVChantierDoc.Appearance.Empty.FontStyleDelta = CType(resources.GetObject("GVChantierDoc.Appearance.Empty.FontStyleDelta"), System.Drawing.FontStyle)
        Me.GVChantierDoc.Appearance.Empty.GradientMode = CType(resources.GetObject("GVChantierDoc.Appearance.Empty.GradientMode"), System.Drawing.Drawing2D.LinearGradientMode)
        Me.GVChantierDoc.Appearance.Empty.Image = CType(resources.GetObject("GVChantierDoc.Appearance.Empty.Image"), System.Drawing.Image)
        Me.GVChantierDoc.Appearance.Empty.Options.UseBackColor = True
        Me.GVChantierDoc.Appearance.EvenRow.BackColor = CType(resources.GetObject("GVChantierDoc.Appearance.EvenRow.BackColor"), System.Drawing.Color)
        Me.GVChantierDoc.Appearance.EvenRow.FontSizeDelta = CType(resources.GetObject("GVChantierDoc.Appearance.EvenRow.FontSizeDelta"), Integer)
        Me.GVChantierDoc.Appearance.EvenRow.FontStyleDelta = CType(resources.GetObject("GVChantierDoc.Appearance.EvenRow.FontStyleDelta"), System.Drawing.FontStyle)
        Me.GVChantierDoc.Appearance.EvenRow.ForeColor = CType(resources.GetObject("GVChantierDoc.Appearance.EvenRow.ForeColor"), System.Drawing.Color)
        Me.GVChantierDoc.Appearance.EvenRow.GradientMode = CType(resources.GetObject("GVChantierDoc.Appearance.EvenRow.GradientMode"), System.Drawing.Drawing2D.LinearGradientMode)
        Me.GVChantierDoc.Appearance.EvenRow.Image = CType(resources.GetObject("GVChantierDoc.Appearance.EvenRow.Image"), System.Drawing.Image)
        Me.GVChantierDoc.Appearance.EvenRow.Options.UseBackColor = True
        Me.GVChantierDoc.Appearance.EvenRow.Options.UseForeColor = True
        Me.GVChantierDoc.Appearance.FilterCloseButton.BackColor = CType(resources.GetObject("GVChantierDoc.Appearance.FilterCloseButton.BackColor"), System.Drawing.Color)
        Me.GVChantierDoc.Appearance.FilterCloseButton.BackColor2 = CType(resources.GetObject("GVChantierDoc.Appearance.FilterCloseButton.BackColor2"), System.Drawing.Color)
        Me.GVChantierDoc.Appearance.FilterCloseButton.BorderColor = CType(resources.GetObject("GVChantierDoc.Appearance.FilterCloseButton.BorderColor"), System.Drawing.Color)
        Me.GVChantierDoc.Appearance.FilterCloseButton.FontSizeDelta = CType(resources.GetObject("GVChantierDoc.Appearance.FilterCloseButton.FontSizeDelta"), Integer)
        Me.GVChantierDoc.Appearance.FilterCloseButton.FontStyleDelta = CType(resources.GetObject("GVChantierDoc.Appearance.FilterCloseButton.FontStyleDelta"), System.Drawing.FontStyle)
        Me.GVChantierDoc.Appearance.FilterCloseButton.GradientMode = CType(resources.GetObject("GVChantierDoc.Appearance.FilterCloseButton.GradientMode"), System.Drawing.Drawing2D.LinearGradientMode)
        Me.GVChantierDoc.Appearance.FilterCloseButton.Image = CType(resources.GetObject("GVChantierDoc.Appearance.FilterCloseButton.Image"), System.Drawing.Image)
        Me.GVChantierDoc.Appearance.FilterCloseButton.Options.UseBackColor = True
        Me.GVChantierDoc.Appearance.FilterCloseButton.Options.UseBorderColor = True
        Me.GVChantierDoc.Appearance.FilterPanel.BackColor = CType(resources.GetObject("GVChantierDoc.Appearance.FilterPanel.BackColor"), System.Drawing.Color)
        Me.GVChantierDoc.Appearance.FilterPanel.FontSizeDelta = CType(resources.GetObject("GVChantierDoc.Appearance.FilterPanel.FontSizeDelta"), Integer)
        Me.GVChantierDoc.Appearance.FilterPanel.FontStyleDelta = CType(resources.GetObject("GVChantierDoc.Appearance.FilterPanel.FontStyleDelta"), System.Drawing.FontStyle)
        Me.GVChantierDoc.Appearance.FilterPanel.ForeColor = CType(resources.GetObject("GVChantierDoc.Appearance.FilterPanel.ForeColor"), System.Drawing.Color)
        Me.GVChantierDoc.Appearance.FilterPanel.GradientMode = CType(resources.GetObject("GVChantierDoc.Appearance.FilterPanel.GradientMode"), System.Drawing.Drawing2D.LinearGradientMode)
        Me.GVChantierDoc.Appearance.FilterPanel.Image = CType(resources.GetObject("GVChantierDoc.Appearance.FilterPanel.Image"), System.Drawing.Image)
        Me.GVChantierDoc.Appearance.FilterPanel.Options.UseBackColor = True
        Me.GVChantierDoc.Appearance.FilterPanel.Options.UseForeColor = True
        Me.GVChantierDoc.Appearance.FixedLine.BackColor = CType(resources.GetObject("GVChantierDoc.Appearance.FixedLine.BackColor"), System.Drawing.Color)
        Me.GVChantierDoc.Appearance.FixedLine.FontSizeDelta = CType(resources.GetObject("GVChantierDoc.Appearance.FixedLine.FontSizeDelta"), Integer)
        Me.GVChantierDoc.Appearance.FixedLine.FontStyleDelta = CType(resources.GetObject("GVChantierDoc.Appearance.FixedLine.FontStyleDelta"), System.Drawing.FontStyle)
        Me.GVChantierDoc.Appearance.FixedLine.GradientMode = CType(resources.GetObject("GVChantierDoc.Appearance.FixedLine.GradientMode"), System.Drawing.Drawing2D.LinearGradientMode)
        Me.GVChantierDoc.Appearance.FixedLine.Image = CType(resources.GetObject("GVChantierDoc.Appearance.FixedLine.Image"), System.Drawing.Image)
        Me.GVChantierDoc.Appearance.FixedLine.Options.UseBackColor = True
        Me.GVChantierDoc.Appearance.FocusedRow.BackColor = CType(resources.GetObject("GVChantierDoc.Appearance.FocusedRow.BackColor"), System.Drawing.Color)
        Me.GVChantierDoc.Appearance.FocusedRow.FontSizeDelta = CType(resources.GetObject("GVChantierDoc.Appearance.FocusedRow.FontSizeDelta"), Integer)
        Me.GVChantierDoc.Appearance.FocusedRow.FontStyleDelta = CType(resources.GetObject("GVChantierDoc.Appearance.FocusedRow.FontStyleDelta"), System.Drawing.FontStyle)
        Me.GVChantierDoc.Appearance.FocusedRow.ForeColor = CType(resources.GetObject("GVChantierDoc.Appearance.FocusedRow.ForeColor"), System.Drawing.Color)
        Me.GVChantierDoc.Appearance.FocusedRow.GradientMode = CType(resources.GetObject("GVChantierDoc.Appearance.FocusedRow.GradientMode"), System.Drawing.Drawing2D.LinearGradientMode)
        Me.GVChantierDoc.Appearance.FocusedRow.Image = CType(resources.GetObject("GVChantierDoc.Appearance.FocusedRow.Image"), System.Drawing.Image)
        Me.GVChantierDoc.Appearance.FocusedRow.Options.UseBackColor = True
        Me.GVChantierDoc.Appearance.FocusedRow.Options.UseForeColor = True
        Me.GVChantierDoc.Appearance.FooterPanel.BackColor = CType(resources.GetObject("GVChantierDoc.Appearance.FooterPanel.BackColor"), System.Drawing.Color)
        Me.GVChantierDoc.Appearance.FooterPanel.BackColor2 = CType(resources.GetObject("GVChantierDoc.Appearance.FooterPanel.BackColor2"), System.Drawing.Color)
        Me.GVChantierDoc.Appearance.FooterPanel.BorderColor = CType(resources.GetObject("GVChantierDoc.Appearance.FooterPanel.BorderColor"), System.Drawing.Color)
        Me.GVChantierDoc.Appearance.FooterPanel.FontSizeDelta = CType(resources.GetObject("GVChantierDoc.Appearance.FooterPanel.FontSizeDelta"), Integer)
        Me.GVChantierDoc.Appearance.FooterPanel.FontStyleDelta = CType(resources.GetObject("GVChantierDoc.Appearance.FooterPanel.FontStyleDelta"), System.Drawing.FontStyle)
        Me.GVChantierDoc.Appearance.FooterPanel.GradientMode = CType(resources.GetObject("GVChantierDoc.Appearance.FooterPanel.GradientMode"), System.Drawing.Drawing2D.LinearGradientMode)
        Me.GVChantierDoc.Appearance.FooterPanel.Image = CType(resources.GetObject("GVChantierDoc.Appearance.FooterPanel.Image"), System.Drawing.Image)
        Me.GVChantierDoc.Appearance.FooterPanel.Options.UseBackColor = True
        Me.GVChantierDoc.Appearance.FooterPanel.Options.UseBorderColor = True
        Me.GVChantierDoc.Appearance.GroupButton.BackColor = CType(resources.GetObject("GVChantierDoc.Appearance.GroupButton.BackColor"), System.Drawing.Color)
        Me.GVChantierDoc.Appearance.GroupButton.BorderColor = CType(resources.GetObject("GVChantierDoc.Appearance.GroupButton.BorderColor"), System.Drawing.Color)
        Me.GVChantierDoc.Appearance.GroupButton.FontSizeDelta = CType(resources.GetObject("GVChantierDoc.Appearance.GroupButton.FontSizeDelta"), Integer)
        Me.GVChantierDoc.Appearance.GroupButton.FontStyleDelta = CType(resources.GetObject("GVChantierDoc.Appearance.GroupButton.FontStyleDelta"), System.Drawing.FontStyle)
        Me.GVChantierDoc.Appearance.GroupButton.ForeColor = CType(resources.GetObject("GVChantierDoc.Appearance.GroupButton.ForeColor"), System.Drawing.Color)
        Me.GVChantierDoc.Appearance.GroupButton.GradientMode = CType(resources.GetObject("GVChantierDoc.Appearance.GroupButton.GradientMode"), System.Drawing.Drawing2D.LinearGradientMode)
        Me.GVChantierDoc.Appearance.GroupButton.Image = CType(resources.GetObject("GVChantierDoc.Appearance.GroupButton.Image"), System.Drawing.Image)
        Me.GVChantierDoc.Appearance.GroupButton.Options.UseBackColor = True
        Me.GVChantierDoc.Appearance.GroupButton.Options.UseBorderColor = True
        Me.GVChantierDoc.Appearance.GroupButton.Options.UseForeColor = True
        Me.GVChantierDoc.Appearance.GroupFooter.BackColor = CType(resources.GetObject("GVChantierDoc.Appearance.GroupFooter.BackColor"), System.Drawing.Color)
        Me.GVChantierDoc.Appearance.GroupFooter.BorderColor = CType(resources.GetObject("GVChantierDoc.Appearance.GroupFooter.BorderColor"), System.Drawing.Color)
        Me.GVChantierDoc.Appearance.GroupFooter.FontSizeDelta = CType(resources.GetObject("GVChantierDoc.Appearance.GroupFooter.FontSizeDelta"), Integer)
        Me.GVChantierDoc.Appearance.GroupFooter.FontStyleDelta = CType(resources.GetObject("GVChantierDoc.Appearance.GroupFooter.FontStyleDelta"), System.Drawing.FontStyle)
        Me.GVChantierDoc.Appearance.GroupFooter.ForeColor = CType(resources.GetObject("GVChantierDoc.Appearance.GroupFooter.ForeColor"), System.Drawing.Color)
        Me.GVChantierDoc.Appearance.GroupFooter.GradientMode = CType(resources.GetObject("GVChantierDoc.Appearance.GroupFooter.GradientMode"), System.Drawing.Drawing2D.LinearGradientMode)
        Me.GVChantierDoc.Appearance.GroupFooter.Image = CType(resources.GetObject("GVChantierDoc.Appearance.GroupFooter.Image"), System.Drawing.Image)
        Me.GVChantierDoc.Appearance.GroupFooter.Options.UseBackColor = True
        Me.GVChantierDoc.Appearance.GroupFooter.Options.UseBorderColor = True
        Me.GVChantierDoc.Appearance.GroupFooter.Options.UseForeColor = True
        Me.GVChantierDoc.Appearance.GroupPanel.BackColor = CType(resources.GetObject("GVChantierDoc.Appearance.GroupPanel.BackColor"), System.Drawing.Color)
        Me.GVChantierDoc.Appearance.GroupPanel.FontSizeDelta = CType(resources.GetObject("GVChantierDoc.Appearance.GroupPanel.FontSizeDelta"), Integer)
        Me.GVChantierDoc.Appearance.GroupPanel.FontStyleDelta = CType(resources.GetObject("GVChantierDoc.Appearance.GroupPanel.FontStyleDelta"), System.Drawing.FontStyle)
        Me.GVChantierDoc.Appearance.GroupPanel.ForeColor = CType(resources.GetObject("GVChantierDoc.Appearance.GroupPanel.ForeColor"), System.Drawing.Color)
        Me.GVChantierDoc.Appearance.GroupPanel.GradientMode = CType(resources.GetObject("GVChantierDoc.Appearance.GroupPanel.GradientMode"), System.Drawing.Drawing2D.LinearGradientMode)
        Me.GVChantierDoc.Appearance.GroupPanel.Image = CType(resources.GetObject("GVChantierDoc.Appearance.GroupPanel.Image"), System.Drawing.Image)
        Me.GVChantierDoc.Appearance.GroupPanel.Options.UseBackColor = True
        Me.GVChantierDoc.Appearance.GroupPanel.Options.UseForeColor = True
        Me.GVChantierDoc.Appearance.GroupRow.BackColor = CType(resources.GetObject("GVChantierDoc.Appearance.GroupRow.BackColor"), System.Drawing.Color)
        Me.GVChantierDoc.Appearance.GroupRow.BorderColor = CType(resources.GetObject("GVChantierDoc.Appearance.GroupRow.BorderColor"), System.Drawing.Color)
        Me.GVChantierDoc.Appearance.GroupRow.Font = CType(resources.GetObject("GVChantierDoc.Appearance.GroupRow.Font"), System.Drawing.Font)
        Me.GVChantierDoc.Appearance.GroupRow.FontSizeDelta = CType(resources.GetObject("GVChantierDoc.Appearance.GroupRow.FontSizeDelta"), Integer)
        Me.GVChantierDoc.Appearance.GroupRow.FontStyleDelta = CType(resources.GetObject("GVChantierDoc.Appearance.GroupRow.FontStyleDelta"), System.Drawing.FontStyle)
        Me.GVChantierDoc.Appearance.GroupRow.ForeColor = CType(resources.GetObject("GVChantierDoc.Appearance.GroupRow.ForeColor"), System.Drawing.Color)
        Me.GVChantierDoc.Appearance.GroupRow.GradientMode = CType(resources.GetObject("GVChantierDoc.Appearance.GroupRow.GradientMode"), System.Drawing.Drawing2D.LinearGradientMode)
        Me.GVChantierDoc.Appearance.GroupRow.Image = CType(resources.GetObject("GVChantierDoc.Appearance.GroupRow.Image"), System.Drawing.Image)
        Me.GVChantierDoc.Appearance.GroupRow.Options.UseBackColor = True
        Me.GVChantierDoc.Appearance.GroupRow.Options.UseBorderColor = True
        Me.GVChantierDoc.Appearance.GroupRow.Options.UseFont = True
        Me.GVChantierDoc.Appearance.GroupRow.Options.UseForeColor = True
        Me.GVChantierDoc.Appearance.HeaderPanel.BackColor = CType(resources.GetObject("GVChantierDoc.Appearance.HeaderPanel.BackColor"), System.Drawing.Color)
        Me.GVChantierDoc.Appearance.HeaderPanel.BackColor2 = CType(resources.GetObject("GVChantierDoc.Appearance.HeaderPanel.BackColor2"), System.Drawing.Color)
        Me.GVChantierDoc.Appearance.HeaderPanel.BorderColor = CType(resources.GetObject("GVChantierDoc.Appearance.HeaderPanel.BorderColor"), System.Drawing.Color)
        Me.GVChantierDoc.Appearance.HeaderPanel.Font = CType(resources.GetObject("GVChantierDoc.Appearance.HeaderPanel.Font"), System.Drawing.Font)
        Me.GVChantierDoc.Appearance.HeaderPanel.FontSizeDelta = CType(resources.GetObject("GVChantierDoc.Appearance.HeaderPanel.FontSizeDelta"), Integer)
        Me.GVChantierDoc.Appearance.HeaderPanel.FontStyleDelta = CType(resources.GetObject("GVChantierDoc.Appearance.HeaderPanel.FontStyleDelta"), System.Drawing.FontStyle)
        Me.GVChantierDoc.Appearance.HeaderPanel.ForeColor = CType(resources.GetObject("GVChantierDoc.Appearance.HeaderPanel.ForeColor"), System.Drawing.Color)
        Me.GVChantierDoc.Appearance.HeaderPanel.GradientMode = CType(resources.GetObject("GVChantierDoc.Appearance.HeaderPanel.GradientMode"), System.Drawing.Drawing2D.LinearGradientMode)
        Me.GVChantierDoc.Appearance.HeaderPanel.Image = CType(resources.GetObject("GVChantierDoc.Appearance.HeaderPanel.Image"), System.Drawing.Image)
        Me.GVChantierDoc.Appearance.HeaderPanel.Options.UseBackColor = True
        Me.GVChantierDoc.Appearance.HeaderPanel.Options.UseBorderColor = True
        Me.GVChantierDoc.Appearance.HeaderPanel.Options.UseFont = True
        Me.GVChantierDoc.Appearance.HeaderPanel.Options.UseForeColor = True
        Me.GVChantierDoc.Appearance.HeaderPanel.Options.UseTextOptions = True
        Me.GVChantierDoc.Appearance.HeaderPanel.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center
        Me.GVChantierDoc.Appearance.HeaderPanel.TextOptions.VAlignment = DevExpress.Utils.VertAlignment.Center
        Me.GVChantierDoc.Appearance.HideSelectionRow.BackColor = CType(resources.GetObject("GVChantierDoc.Appearance.HideSelectionRow.BackColor"), System.Drawing.Color)
        Me.GVChantierDoc.Appearance.HideSelectionRow.FontSizeDelta = CType(resources.GetObject("GVChantierDoc.Appearance.HideSelectionRow.FontSizeDelta"), Integer)
        Me.GVChantierDoc.Appearance.HideSelectionRow.FontStyleDelta = CType(resources.GetObject("GVChantierDoc.Appearance.HideSelectionRow.FontStyleDelta"), System.Drawing.FontStyle)
        Me.GVChantierDoc.Appearance.HideSelectionRow.ForeColor = CType(resources.GetObject("GVChantierDoc.Appearance.HideSelectionRow.ForeColor"), System.Drawing.Color)
        Me.GVChantierDoc.Appearance.HideSelectionRow.GradientMode = CType(resources.GetObject("GVChantierDoc.Appearance.HideSelectionRow.GradientMode"), System.Drawing.Drawing2D.LinearGradientMode)
        Me.GVChantierDoc.Appearance.HideSelectionRow.Image = CType(resources.GetObject("GVChantierDoc.Appearance.HideSelectionRow.Image"), System.Drawing.Image)
        Me.GVChantierDoc.Appearance.HideSelectionRow.Options.UseBackColor = True
        Me.GVChantierDoc.Appearance.HideSelectionRow.Options.UseForeColor = True
        Me.GVChantierDoc.Appearance.HorzLine.BackColor = CType(resources.GetObject("GVChantierDoc.Appearance.HorzLine.BackColor"), System.Drawing.Color)
        Me.GVChantierDoc.Appearance.HorzLine.FontSizeDelta = CType(resources.GetObject("GVChantierDoc.Appearance.HorzLine.FontSizeDelta"), Integer)
        Me.GVChantierDoc.Appearance.HorzLine.FontStyleDelta = CType(resources.GetObject("GVChantierDoc.Appearance.HorzLine.FontStyleDelta"), System.Drawing.FontStyle)
        Me.GVChantierDoc.Appearance.HorzLine.GradientMode = CType(resources.GetObject("GVChantierDoc.Appearance.HorzLine.GradientMode"), System.Drawing.Drawing2D.LinearGradientMode)
        Me.GVChantierDoc.Appearance.HorzLine.Image = CType(resources.GetObject("GVChantierDoc.Appearance.HorzLine.Image"), System.Drawing.Image)
        Me.GVChantierDoc.Appearance.HorzLine.Options.UseBackColor = True
        Me.GVChantierDoc.Appearance.OddRow.BackColor = CType(resources.GetObject("GVChantierDoc.Appearance.OddRow.BackColor"), System.Drawing.Color)
        Me.GVChantierDoc.Appearance.OddRow.FontSizeDelta = CType(resources.GetObject("GVChantierDoc.Appearance.OddRow.FontSizeDelta"), Integer)
        Me.GVChantierDoc.Appearance.OddRow.FontStyleDelta = CType(resources.GetObject("GVChantierDoc.Appearance.OddRow.FontStyleDelta"), System.Drawing.FontStyle)
        Me.GVChantierDoc.Appearance.OddRow.ForeColor = CType(resources.GetObject("GVChantierDoc.Appearance.OddRow.ForeColor"), System.Drawing.Color)
        Me.GVChantierDoc.Appearance.OddRow.GradientMode = CType(resources.GetObject("GVChantierDoc.Appearance.OddRow.GradientMode"), System.Drawing.Drawing2D.LinearGradientMode)
        Me.GVChantierDoc.Appearance.OddRow.Image = CType(resources.GetObject("GVChantierDoc.Appearance.OddRow.Image"), System.Drawing.Image)
        Me.GVChantierDoc.Appearance.OddRow.Options.UseBackColor = True
        Me.GVChantierDoc.Appearance.OddRow.Options.UseForeColor = True
        Me.GVChantierDoc.Appearance.Preview.BackColor = CType(resources.GetObject("GVChantierDoc.Appearance.Preview.BackColor"), System.Drawing.Color)
        Me.GVChantierDoc.Appearance.Preview.FontSizeDelta = CType(resources.GetObject("GVChantierDoc.Appearance.Preview.FontSizeDelta"), Integer)
        Me.GVChantierDoc.Appearance.Preview.FontStyleDelta = CType(resources.GetObject("GVChantierDoc.Appearance.Preview.FontStyleDelta"), System.Drawing.FontStyle)
        Me.GVChantierDoc.Appearance.Preview.ForeColor = CType(resources.GetObject("GVChantierDoc.Appearance.Preview.ForeColor"), System.Drawing.Color)
        Me.GVChantierDoc.Appearance.Preview.GradientMode = CType(resources.GetObject("GVChantierDoc.Appearance.Preview.GradientMode"), System.Drawing.Drawing2D.LinearGradientMode)
        Me.GVChantierDoc.Appearance.Preview.Image = CType(resources.GetObject("GVChantierDoc.Appearance.Preview.Image"), System.Drawing.Image)
        Me.GVChantierDoc.Appearance.Preview.Options.UseBackColor = True
        Me.GVChantierDoc.Appearance.Preview.Options.UseForeColor = True
        Me.GVChantierDoc.Appearance.Row.BackColor = CType(resources.GetObject("GVChantierDoc.Appearance.Row.BackColor"), System.Drawing.Color)
        Me.GVChantierDoc.Appearance.Row.FontSizeDelta = CType(resources.GetObject("GVChantierDoc.Appearance.Row.FontSizeDelta"), Integer)
        Me.GVChantierDoc.Appearance.Row.FontStyleDelta = CType(resources.GetObject("GVChantierDoc.Appearance.Row.FontStyleDelta"), System.Drawing.FontStyle)
        Me.GVChantierDoc.Appearance.Row.ForeColor = CType(resources.GetObject("GVChantierDoc.Appearance.Row.ForeColor"), System.Drawing.Color)
        Me.GVChantierDoc.Appearance.Row.GradientMode = CType(resources.GetObject("GVChantierDoc.Appearance.Row.GradientMode"), System.Drawing.Drawing2D.LinearGradientMode)
        Me.GVChantierDoc.Appearance.Row.Image = CType(resources.GetObject("GVChantierDoc.Appearance.Row.Image"), System.Drawing.Image)
        Me.GVChantierDoc.Appearance.Row.Options.UseBackColor = True
        Me.GVChantierDoc.Appearance.Row.Options.UseForeColor = True
        Me.GVChantierDoc.Appearance.RowSeparator.BackColor = CType(resources.GetObject("GVChantierDoc.Appearance.RowSeparator.BackColor"), System.Drawing.Color)
        Me.GVChantierDoc.Appearance.RowSeparator.FontSizeDelta = CType(resources.GetObject("GVChantierDoc.Appearance.RowSeparator.FontSizeDelta"), Integer)
        Me.GVChantierDoc.Appearance.RowSeparator.FontStyleDelta = CType(resources.GetObject("GVChantierDoc.Appearance.RowSeparator.FontStyleDelta"), System.Drawing.FontStyle)
        Me.GVChantierDoc.Appearance.RowSeparator.GradientMode = CType(resources.GetObject("GVChantierDoc.Appearance.RowSeparator.GradientMode"), System.Drawing.Drawing2D.LinearGradientMode)
        Me.GVChantierDoc.Appearance.RowSeparator.Image = CType(resources.GetObject("GVChantierDoc.Appearance.RowSeparator.Image"), System.Drawing.Image)
        Me.GVChantierDoc.Appearance.RowSeparator.Options.UseBackColor = True
        Me.GVChantierDoc.Appearance.SelectedRow.BackColor = CType(resources.GetObject("GVChantierDoc.Appearance.SelectedRow.BackColor"), System.Drawing.Color)
        Me.GVChantierDoc.Appearance.SelectedRow.FontSizeDelta = CType(resources.GetObject("GVChantierDoc.Appearance.SelectedRow.FontSizeDelta"), Integer)
        Me.GVChantierDoc.Appearance.SelectedRow.FontStyleDelta = CType(resources.GetObject("GVChantierDoc.Appearance.SelectedRow.FontStyleDelta"), System.Drawing.FontStyle)
        Me.GVChantierDoc.Appearance.SelectedRow.ForeColor = CType(resources.GetObject("GVChantierDoc.Appearance.SelectedRow.ForeColor"), System.Drawing.Color)
        Me.GVChantierDoc.Appearance.SelectedRow.GradientMode = CType(resources.GetObject("GVChantierDoc.Appearance.SelectedRow.GradientMode"), System.Drawing.Drawing2D.LinearGradientMode)
        Me.GVChantierDoc.Appearance.SelectedRow.Image = CType(resources.GetObject("GVChantierDoc.Appearance.SelectedRow.Image"), System.Drawing.Image)
        Me.GVChantierDoc.Appearance.SelectedRow.Options.UseBackColor = True
        Me.GVChantierDoc.Appearance.SelectedRow.Options.UseForeColor = True
        Me.GVChantierDoc.Appearance.VertLine.BackColor = CType(resources.GetObject("GVChantierDoc.Appearance.VertLine.BackColor"), System.Drawing.Color)
        Me.GVChantierDoc.Appearance.VertLine.FontSizeDelta = CType(resources.GetObject("GVChantierDoc.Appearance.VertLine.FontSizeDelta"), Integer)
        Me.GVChantierDoc.Appearance.VertLine.FontStyleDelta = CType(resources.GetObject("GVChantierDoc.Appearance.VertLine.FontStyleDelta"), System.Drawing.FontStyle)
        Me.GVChantierDoc.Appearance.VertLine.GradientMode = CType(resources.GetObject("GVChantierDoc.Appearance.VertLine.GradientMode"), System.Drawing.Drawing2D.LinearGradientMode)
        Me.GVChantierDoc.Appearance.VertLine.Image = CType(resources.GetObject("GVChantierDoc.Appearance.VertLine.Image"), System.Drawing.Image)
        Me.GVChantierDoc.Appearance.VertLine.Options.UseBackColor = True
        resources.ApplyResources(Me.GVChantierDoc, "GVChantierDoc")
        Me.GVChantierDoc.Columns.AddRange(New DevExpress.XtraGrid.Columns.GridColumn() {Me.GColIDTMP, Me.GColNIDCHANTIERDOC, Me.GColNIDCHANTIER, Me.GColVFILE, Me.GColDQUICREE, Me.GColVQUICREE, Me.GColFICTMP})
        Me.GVChantierDoc.GridControl = Me.GCChantierDoc
        Me.GVChantierDoc.Name = "GVChantierDoc"
        Me.GVChantierDoc.OptionsView.EnableAppearanceEvenRow = True
        Me.GVChantierDoc.OptionsView.EnableAppearanceOddRow = True
        Me.GVChantierDoc.OptionsView.ShowGroupPanel = False
        '
        'GColIDTMP
        '
        resources.ApplyResources(Me.GColIDTMP, "GColIDTMP")
        Me.GColIDTMP.FieldName = "IDTMP"
        Me.GColIDTMP.Name = "GColIDTMP"
        '
        'GColNIDCHANTIERDOC
        '
        resources.ApplyResources(Me.GColNIDCHANTIERDOC, "GColNIDCHANTIERDOC")
        Me.GColNIDCHANTIERDOC.FieldName = "NIDCHANTIERDOC"
        Me.GColNIDCHANTIERDOC.Name = "GColNIDCHANTIERDOC"
        '
        'GColNIDCHANTIER
        '
        resources.ApplyResources(Me.GColNIDCHANTIER, "GColNIDCHANTIER")
        Me.GColNIDCHANTIER.FieldName = "NIDCHANTIER"
        Me.GColNIDCHANTIER.Name = "GColNIDCHANTIER"
        '
        'GColVFILE
        '
        resources.ApplyResources(Me.GColVFILE, "GColVFILE")
        Me.GColVFILE.FieldName = "VFILE"
        Me.GColVFILE.Name = "GColVFILE"
        Me.GColVFILE.OptionsColumn.AllowEdit = False
        Me.GColVFILE.OptionsColumn.ReadOnly = True
        '
        'GColDQUICREE
        '
        resources.ApplyResources(Me.GColDQUICREE, "GColDQUICREE")
        Me.GColDQUICREE.FieldName = "DQUICREE"
        Me.GColDQUICREE.Name = "GColDQUICREE"
        Me.GColDQUICREE.OptionsColumn.AllowEdit = False
        Me.GColDQUICREE.OptionsColumn.ReadOnly = True
        '
        'GColVQUICREE
        '
        resources.ApplyResources(Me.GColVQUICREE, "GColVQUICREE")
        Me.GColVQUICREE.FieldName = "VQUICREE"
        Me.GColVQUICREE.Name = "GColVQUICREE"
        '
        'GColFICTMP
        '
        resources.ApplyResources(Me.GColFICTMP, "GColFICTMP")
        Me.GColFICTMP.FieldName = "FICTMP"
        Me.GColFICTMP.Name = "GColFICTMP"
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
        'OFD
        '
        resources.ApplyResources(Me.OFD, "OFD")
        '
        'frmGestionDocChantier
        '
        resources.ApplyResources(Me, "$this")
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.Wheat
        Me.Controls.Add(Me.GrpApercu)
        Me.Controls.Add(Me.GrpListe)
        Me.Controls.Add(Me.GrpActions)
        Me.Name = "frmGestionDocChantier"
        Me.WindowState = System.Windows.Forms.FormWindowState.Maximized
        Me.GrpActions.ResumeLayout(False)
        Me.GrpListe.ResumeLayout(False)
        CType(Me.GCChantierDoc, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.GVChantierDoc, System.ComponentModel.ISupportInitialize).EndInit()
        Me.GrpApercu.ResumeLayout(False)
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents GrpActions As System.Windows.Forms.GroupBox
    Friend WithEvents GrpListe As System.Windows.Forms.GroupBox
    Friend WithEvents BtnFermer As System.Windows.Forms.Button
    Friend WithEvents BtnSave As System.Windows.Forms.Button
    Friend WithEvents GrpApercu As System.Windows.Forms.GroupBox
    Friend WithEvents BtnSupprimer As System.Windows.Forms.Button
    Friend WithEvents BtnAjouter As System.Windows.Forms.Button
    Friend WithEvents OFD As System.Windows.Forms.OpenFileDialog
    Friend WithEvents WBApercu As System.Windows.Forms.WebBrowser
    Friend WithEvents BtnPrint As System.Windows.Forms.Button
    Private WithEvents GCChantierDoc As DevExpress.XtraGrid.GridControl
    Private WithEvents GVChantierDoc As DevExpress.XtraGrid.Views.Grid.GridView
    Private WithEvents GColNIDCHANTIERDOC As DevExpress.XtraGrid.Columns.GridColumn
    Private WithEvents GColNIDCHANTIER As DevExpress.XtraGrid.Columns.GridColumn
    Private WithEvents GColVFILE As DevExpress.XtraGrid.Columns.GridColumn
    Private WithEvents GColDQUICREE As DevExpress.XtraGrid.Columns.GridColumn
    Private WithEvents GColVQUICREE As DevExpress.XtraGrid.Columns.GridColumn
    Private WithEvents GColIDTMP As DevExpress.XtraGrid.Columns.GridColumn
    Private WithEvents GColFICTMP As DevExpress.XtraGrid.Columns.GridColumn
End Class
