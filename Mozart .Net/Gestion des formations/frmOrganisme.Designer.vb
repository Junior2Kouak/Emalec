<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmOrganisme
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(frmOrganisme))
        Me.Label1 = New System.Windows.Forms.Label()
        Me.ColIDTMP = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.ColNORGNUM = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.ColVORGNOM = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.BtnAddLine = New System.Windows.Forms.Button()
        Me.GVORGANISME = New DevExpress.XtraGrid.Views.Grid.GridView()
        Me.ColVORGADRESSE = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.ColVORGOBS = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.GCORGANISME = New DevExpress.XtraGrid.GridControl()
        Me.BtnSupprLine = New System.Windows.Forms.Button()
        Me.BtnQuit = New System.Windows.Forms.Button()
        Me.GrpActions = New System.Windows.Forms.GroupBox()
        Me.BtnSave = New System.Windows.Forms.Button()
        CType(Me.GVORGANISME, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.GCORGANISME, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.GrpActions.SuspendLayout()
        Me.SuspendLayout()
        '
        'Label1
        '
        resources.ApplyResources(Me.Label1, "Label1")
        Me.Label1.Name = "Label1"
        '
        'ColIDTMP
        '
        resources.ApplyResources(Me.ColIDTMP, "ColIDTMP")
        Me.ColIDTMP.FieldName = "IDTMP"
        Me.ColIDTMP.Name = "ColIDTMP"
        '
        'ColNORGNUM
        '
        resources.ApplyResources(Me.ColNORGNUM, "ColNORGNUM")
        Me.ColNORGNUM.FieldName = "NORGNUM"
        Me.ColNORGNUM.Name = "ColNORGNUM"
        '
        'ColVORGNOM
        '
        resources.ApplyResources(Me.ColVORGNOM, "ColVORGNOM")
        Me.ColVORGNOM.FieldName = "VORGNOM"
        Me.ColVORGNOM.Name = "ColVORGNOM"
        '
        'BtnAddLine
        '
        resources.ApplyResources(Me.BtnAddLine, "BtnAddLine")
        Me.BtnAddLine.BackColor = System.Drawing.Color.LightGreen
        Me.BtnAddLine.Name = "BtnAddLine"
        Me.BtnAddLine.UseVisualStyleBackColor = False
        '
        'GVORGANISME
        '
        Me.GVORGANISME.Appearance.ColumnFilterButton.BackColor = CType(resources.GetObject("GVORGANISME.Appearance.ColumnFilterButton.BackColor"), System.Drawing.Color)
        Me.GVORGANISME.Appearance.ColumnFilterButton.BackColor2 = CType(resources.GetObject("GVORGANISME.Appearance.ColumnFilterButton.BackColor2"), System.Drawing.Color)
        Me.GVORGANISME.Appearance.ColumnFilterButton.BorderColor = CType(resources.GetObject("GVORGANISME.Appearance.ColumnFilterButton.BorderColor"), System.Drawing.Color)
        Me.GVORGANISME.Appearance.ColumnFilterButton.FontSizeDelta = CType(resources.GetObject("GVORGANISME.Appearance.ColumnFilterButton.FontSizeDelta"), Integer)
        Me.GVORGANISME.Appearance.ColumnFilterButton.FontStyleDelta = CType(resources.GetObject("GVORGANISME.Appearance.ColumnFilterButton.FontStyleDelta"), System.Drawing.FontStyle)
        Me.GVORGANISME.Appearance.ColumnFilterButton.ForeColor = CType(resources.GetObject("GVORGANISME.Appearance.ColumnFilterButton.ForeColor"), System.Drawing.Color)
        Me.GVORGANISME.Appearance.ColumnFilterButton.GradientMode = CType(resources.GetObject("GVORGANISME.Appearance.ColumnFilterButton.GradientMode"), System.Drawing.Drawing2D.LinearGradientMode)
        Me.GVORGANISME.Appearance.ColumnFilterButton.Image = CType(resources.GetObject("GVORGANISME.Appearance.ColumnFilterButton.Image"), System.Drawing.Image)
        Me.GVORGANISME.Appearance.ColumnFilterButton.Options.UseBackColor = True
        Me.GVORGANISME.Appearance.ColumnFilterButton.Options.UseBorderColor = True
        Me.GVORGANISME.Appearance.ColumnFilterButton.Options.UseForeColor = True
        Me.GVORGANISME.Appearance.ColumnFilterButtonActive.BackColor = CType(resources.GetObject("GVORGANISME.Appearance.ColumnFilterButtonActive.BackColor"), System.Drawing.Color)
        Me.GVORGANISME.Appearance.ColumnFilterButtonActive.BackColor2 = CType(resources.GetObject("GVORGANISME.Appearance.ColumnFilterButtonActive.BackColor2"), System.Drawing.Color)
        Me.GVORGANISME.Appearance.ColumnFilterButtonActive.BorderColor = CType(resources.GetObject("GVORGANISME.Appearance.ColumnFilterButtonActive.BorderColor"), System.Drawing.Color)
        Me.GVORGANISME.Appearance.ColumnFilterButtonActive.FontSizeDelta = CType(resources.GetObject("GVORGANISME.Appearance.ColumnFilterButtonActive.FontSizeDelta"), Integer)
        Me.GVORGANISME.Appearance.ColumnFilterButtonActive.FontStyleDelta = CType(resources.GetObject("GVORGANISME.Appearance.ColumnFilterButtonActive.FontStyleDelta"), System.Drawing.FontStyle)
        Me.GVORGANISME.Appearance.ColumnFilterButtonActive.ForeColor = CType(resources.GetObject("GVORGANISME.Appearance.ColumnFilterButtonActive.ForeColor"), System.Drawing.Color)
        Me.GVORGANISME.Appearance.ColumnFilterButtonActive.GradientMode = CType(resources.GetObject("GVORGANISME.Appearance.ColumnFilterButtonActive.GradientMode"), System.Drawing.Drawing2D.LinearGradientMode)
        Me.GVORGANISME.Appearance.ColumnFilterButtonActive.Image = CType(resources.GetObject("GVORGANISME.Appearance.ColumnFilterButtonActive.Image"), System.Drawing.Image)
        Me.GVORGANISME.Appearance.ColumnFilterButtonActive.Options.UseBackColor = True
        Me.GVORGANISME.Appearance.ColumnFilterButtonActive.Options.UseBorderColor = True
        Me.GVORGANISME.Appearance.ColumnFilterButtonActive.Options.UseForeColor = True
        Me.GVORGANISME.Appearance.Empty.BackColor = CType(resources.GetObject("GVORGANISME.Appearance.Empty.BackColor"), System.Drawing.Color)
        Me.GVORGANISME.Appearance.Empty.FontSizeDelta = CType(resources.GetObject("GVORGANISME.Appearance.Empty.FontSizeDelta"), Integer)
        Me.GVORGANISME.Appearance.Empty.FontStyleDelta = CType(resources.GetObject("GVORGANISME.Appearance.Empty.FontStyleDelta"), System.Drawing.FontStyle)
        Me.GVORGANISME.Appearance.Empty.GradientMode = CType(resources.GetObject("GVORGANISME.Appearance.Empty.GradientMode"), System.Drawing.Drawing2D.LinearGradientMode)
        Me.GVORGANISME.Appearance.Empty.Image = CType(resources.GetObject("GVORGANISME.Appearance.Empty.Image"), System.Drawing.Image)
        Me.GVORGANISME.Appearance.Empty.Options.UseBackColor = True
        Me.GVORGANISME.Appearance.EvenRow.BackColor = CType(resources.GetObject("GVORGANISME.Appearance.EvenRow.BackColor"), System.Drawing.Color)
        Me.GVORGANISME.Appearance.EvenRow.FontSizeDelta = CType(resources.GetObject("GVORGANISME.Appearance.EvenRow.FontSizeDelta"), Integer)
        Me.GVORGANISME.Appearance.EvenRow.FontStyleDelta = CType(resources.GetObject("GVORGANISME.Appearance.EvenRow.FontStyleDelta"), System.Drawing.FontStyle)
        Me.GVORGANISME.Appearance.EvenRow.ForeColor = CType(resources.GetObject("GVORGANISME.Appearance.EvenRow.ForeColor"), System.Drawing.Color)
        Me.GVORGANISME.Appearance.EvenRow.GradientMode = CType(resources.GetObject("GVORGANISME.Appearance.EvenRow.GradientMode"), System.Drawing.Drawing2D.LinearGradientMode)
        Me.GVORGANISME.Appearance.EvenRow.Image = CType(resources.GetObject("GVORGANISME.Appearance.EvenRow.Image"), System.Drawing.Image)
        Me.GVORGANISME.Appearance.EvenRow.Options.UseBackColor = True
        Me.GVORGANISME.Appearance.EvenRow.Options.UseForeColor = True
        Me.GVORGANISME.Appearance.FilterCloseButton.BackColor = CType(resources.GetObject("GVORGANISME.Appearance.FilterCloseButton.BackColor"), System.Drawing.Color)
        Me.GVORGANISME.Appearance.FilterCloseButton.BackColor2 = CType(resources.GetObject("GVORGANISME.Appearance.FilterCloseButton.BackColor2"), System.Drawing.Color)
        Me.GVORGANISME.Appearance.FilterCloseButton.BorderColor = CType(resources.GetObject("GVORGANISME.Appearance.FilterCloseButton.BorderColor"), System.Drawing.Color)
        Me.GVORGANISME.Appearance.FilterCloseButton.FontSizeDelta = CType(resources.GetObject("GVORGANISME.Appearance.FilterCloseButton.FontSizeDelta"), Integer)
        Me.GVORGANISME.Appearance.FilterCloseButton.FontStyleDelta = CType(resources.GetObject("GVORGANISME.Appearance.FilterCloseButton.FontStyleDelta"), System.Drawing.FontStyle)
        Me.GVORGANISME.Appearance.FilterCloseButton.GradientMode = CType(resources.GetObject("GVORGANISME.Appearance.FilterCloseButton.GradientMode"), System.Drawing.Drawing2D.LinearGradientMode)
        Me.GVORGANISME.Appearance.FilterCloseButton.Image = CType(resources.GetObject("GVORGANISME.Appearance.FilterCloseButton.Image"), System.Drawing.Image)
        Me.GVORGANISME.Appearance.FilterCloseButton.Options.UseBackColor = True
        Me.GVORGANISME.Appearance.FilterCloseButton.Options.UseBorderColor = True
        Me.GVORGANISME.Appearance.FilterPanel.BackColor = CType(resources.GetObject("GVORGANISME.Appearance.FilterPanel.BackColor"), System.Drawing.Color)
        Me.GVORGANISME.Appearance.FilterPanel.FontSizeDelta = CType(resources.GetObject("GVORGANISME.Appearance.FilterPanel.FontSizeDelta"), Integer)
        Me.GVORGANISME.Appearance.FilterPanel.FontStyleDelta = CType(resources.GetObject("GVORGANISME.Appearance.FilterPanel.FontStyleDelta"), System.Drawing.FontStyle)
        Me.GVORGANISME.Appearance.FilterPanel.ForeColor = CType(resources.GetObject("GVORGANISME.Appearance.FilterPanel.ForeColor"), System.Drawing.Color)
        Me.GVORGANISME.Appearance.FilterPanel.GradientMode = CType(resources.GetObject("GVORGANISME.Appearance.FilterPanel.GradientMode"), System.Drawing.Drawing2D.LinearGradientMode)
        Me.GVORGANISME.Appearance.FilterPanel.Image = CType(resources.GetObject("GVORGANISME.Appearance.FilterPanel.Image"), System.Drawing.Image)
        Me.GVORGANISME.Appearance.FilterPanel.Options.UseBackColor = True
        Me.GVORGANISME.Appearance.FilterPanel.Options.UseForeColor = True
        Me.GVORGANISME.Appearance.FixedLine.BackColor = CType(resources.GetObject("GVORGANISME.Appearance.FixedLine.BackColor"), System.Drawing.Color)
        Me.GVORGANISME.Appearance.FixedLine.FontSizeDelta = CType(resources.GetObject("GVORGANISME.Appearance.FixedLine.FontSizeDelta"), Integer)
        Me.GVORGANISME.Appearance.FixedLine.FontStyleDelta = CType(resources.GetObject("GVORGANISME.Appearance.FixedLine.FontStyleDelta"), System.Drawing.FontStyle)
        Me.GVORGANISME.Appearance.FixedLine.GradientMode = CType(resources.GetObject("GVORGANISME.Appearance.FixedLine.GradientMode"), System.Drawing.Drawing2D.LinearGradientMode)
        Me.GVORGANISME.Appearance.FixedLine.Image = CType(resources.GetObject("GVORGANISME.Appearance.FixedLine.Image"), System.Drawing.Image)
        Me.GVORGANISME.Appearance.FixedLine.Options.UseBackColor = True
        Me.GVORGANISME.Appearance.FocusedRow.BackColor = CType(resources.GetObject("GVORGANISME.Appearance.FocusedRow.BackColor"), System.Drawing.Color)
        Me.GVORGANISME.Appearance.FocusedRow.FontSizeDelta = CType(resources.GetObject("GVORGANISME.Appearance.FocusedRow.FontSizeDelta"), Integer)
        Me.GVORGANISME.Appearance.FocusedRow.FontStyleDelta = CType(resources.GetObject("GVORGANISME.Appearance.FocusedRow.FontStyleDelta"), System.Drawing.FontStyle)
        Me.GVORGANISME.Appearance.FocusedRow.ForeColor = CType(resources.GetObject("GVORGANISME.Appearance.FocusedRow.ForeColor"), System.Drawing.Color)
        Me.GVORGANISME.Appearance.FocusedRow.GradientMode = CType(resources.GetObject("GVORGANISME.Appearance.FocusedRow.GradientMode"), System.Drawing.Drawing2D.LinearGradientMode)
        Me.GVORGANISME.Appearance.FocusedRow.Image = CType(resources.GetObject("GVORGANISME.Appearance.FocusedRow.Image"), System.Drawing.Image)
        Me.GVORGANISME.Appearance.FocusedRow.Options.UseBackColor = True
        Me.GVORGANISME.Appearance.FocusedRow.Options.UseForeColor = True
        Me.GVORGANISME.Appearance.FooterPanel.BackColor = CType(resources.GetObject("GVORGANISME.Appearance.FooterPanel.BackColor"), System.Drawing.Color)
        Me.GVORGANISME.Appearance.FooterPanel.BackColor2 = CType(resources.GetObject("GVORGANISME.Appearance.FooterPanel.BackColor2"), System.Drawing.Color)
        Me.GVORGANISME.Appearance.FooterPanel.BorderColor = CType(resources.GetObject("GVORGANISME.Appearance.FooterPanel.BorderColor"), System.Drawing.Color)
        Me.GVORGANISME.Appearance.FooterPanel.FontSizeDelta = CType(resources.GetObject("GVORGANISME.Appearance.FooterPanel.FontSizeDelta"), Integer)
        Me.GVORGANISME.Appearance.FooterPanel.FontStyleDelta = CType(resources.GetObject("GVORGANISME.Appearance.FooterPanel.FontStyleDelta"), System.Drawing.FontStyle)
        Me.GVORGANISME.Appearance.FooterPanel.GradientMode = CType(resources.GetObject("GVORGANISME.Appearance.FooterPanel.GradientMode"), System.Drawing.Drawing2D.LinearGradientMode)
        Me.GVORGANISME.Appearance.FooterPanel.Image = CType(resources.GetObject("GVORGANISME.Appearance.FooterPanel.Image"), System.Drawing.Image)
        Me.GVORGANISME.Appearance.FooterPanel.Options.UseBackColor = True
        Me.GVORGANISME.Appearance.FooterPanel.Options.UseBorderColor = True
        Me.GVORGANISME.Appearance.GroupButton.BackColor = CType(resources.GetObject("GVORGANISME.Appearance.GroupButton.BackColor"), System.Drawing.Color)
        Me.GVORGANISME.Appearance.GroupButton.BorderColor = CType(resources.GetObject("GVORGANISME.Appearance.GroupButton.BorderColor"), System.Drawing.Color)
        Me.GVORGANISME.Appearance.GroupButton.FontSizeDelta = CType(resources.GetObject("GVORGANISME.Appearance.GroupButton.FontSizeDelta"), Integer)
        Me.GVORGANISME.Appearance.GroupButton.FontStyleDelta = CType(resources.GetObject("GVORGANISME.Appearance.GroupButton.FontStyleDelta"), System.Drawing.FontStyle)
        Me.GVORGANISME.Appearance.GroupButton.ForeColor = CType(resources.GetObject("GVORGANISME.Appearance.GroupButton.ForeColor"), System.Drawing.Color)
        Me.GVORGANISME.Appearance.GroupButton.GradientMode = CType(resources.GetObject("GVORGANISME.Appearance.GroupButton.GradientMode"), System.Drawing.Drawing2D.LinearGradientMode)
        Me.GVORGANISME.Appearance.GroupButton.Image = CType(resources.GetObject("GVORGANISME.Appearance.GroupButton.Image"), System.Drawing.Image)
        Me.GVORGANISME.Appearance.GroupButton.Options.UseBackColor = True
        Me.GVORGANISME.Appearance.GroupButton.Options.UseBorderColor = True
        Me.GVORGANISME.Appearance.GroupButton.Options.UseForeColor = True
        Me.GVORGANISME.Appearance.GroupFooter.BackColor = CType(resources.GetObject("GVORGANISME.Appearance.GroupFooter.BackColor"), System.Drawing.Color)
        Me.GVORGANISME.Appearance.GroupFooter.BorderColor = CType(resources.GetObject("GVORGANISME.Appearance.GroupFooter.BorderColor"), System.Drawing.Color)
        Me.GVORGANISME.Appearance.GroupFooter.FontSizeDelta = CType(resources.GetObject("GVORGANISME.Appearance.GroupFooter.FontSizeDelta"), Integer)
        Me.GVORGANISME.Appearance.GroupFooter.FontStyleDelta = CType(resources.GetObject("GVORGANISME.Appearance.GroupFooter.FontStyleDelta"), System.Drawing.FontStyle)
        Me.GVORGANISME.Appearance.GroupFooter.ForeColor = CType(resources.GetObject("GVORGANISME.Appearance.GroupFooter.ForeColor"), System.Drawing.Color)
        Me.GVORGANISME.Appearance.GroupFooter.GradientMode = CType(resources.GetObject("GVORGANISME.Appearance.GroupFooter.GradientMode"), System.Drawing.Drawing2D.LinearGradientMode)
        Me.GVORGANISME.Appearance.GroupFooter.Image = CType(resources.GetObject("GVORGANISME.Appearance.GroupFooter.Image"), System.Drawing.Image)
        Me.GVORGANISME.Appearance.GroupFooter.Options.UseBackColor = True
        Me.GVORGANISME.Appearance.GroupFooter.Options.UseBorderColor = True
        Me.GVORGANISME.Appearance.GroupFooter.Options.UseForeColor = True
        Me.GVORGANISME.Appearance.GroupPanel.BackColor = CType(resources.GetObject("GVORGANISME.Appearance.GroupPanel.BackColor"), System.Drawing.Color)
        Me.GVORGANISME.Appearance.GroupPanel.FontSizeDelta = CType(resources.GetObject("GVORGANISME.Appearance.GroupPanel.FontSizeDelta"), Integer)
        Me.GVORGANISME.Appearance.GroupPanel.FontStyleDelta = CType(resources.GetObject("GVORGANISME.Appearance.GroupPanel.FontStyleDelta"), System.Drawing.FontStyle)
        Me.GVORGANISME.Appearance.GroupPanel.ForeColor = CType(resources.GetObject("GVORGANISME.Appearance.GroupPanel.ForeColor"), System.Drawing.Color)
        Me.GVORGANISME.Appearance.GroupPanel.GradientMode = CType(resources.GetObject("GVORGANISME.Appearance.GroupPanel.GradientMode"), System.Drawing.Drawing2D.LinearGradientMode)
        Me.GVORGANISME.Appearance.GroupPanel.Image = CType(resources.GetObject("GVORGANISME.Appearance.GroupPanel.Image"), System.Drawing.Image)
        Me.GVORGANISME.Appearance.GroupPanel.Options.UseBackColor = True
        Me.GVORGANISME.Appearance.GroupPanel.Options.UseForeColor = True
        Me.GVORGANISME.Appearance.GroupRow.BackColor = CType(resources.GetObject("GVORGANISME.Appearance.GroupRow.BackColor"), System.Drawing.Color)
        Me.GVORGANISME.Appearance.GroupRow.BorderColor = CType(resources.GetObject("GVORGANISME.Appearance.GroupRow.BorderColor"), System.Drawing.Color)
        Me.GVORGANISME.Appearance.GroupRow.Font = CType(resources.GetObject("GVORGANISME.Appearance.GroupRow.Font"), System.Drawing.Font)
        Me.GVORGANISME.Appearance.GroupRow.FontSizeDelta = CType(resources.GetObject("GVORGANISME.Appearance.GroupRow.FontSizeDelta"), Integer)
        Me.GVORGANISME.Appearance.GroupRow.FontStyleDelta = CType(resources.GetObject("GVORGANISME.Appearance.GroupRow.FontStyleDelta"), System.Drawing.FontStyle)
        Me.GVORGANISME.Appearance.GroupRow.ForeColor = CType(resources.GetObject("GVORGANISME.Appearance.GroupRow.ForeColor"), System.Drawing.Color)
        Me.GVORGANISME.Appearance.GroupRow.GradientMode = CType(resources.GetObject("GVORGANISME.Appearance.GroupRow.GradientMode"), System.Drawing.Drawing2D.LinearGradientMode)
        Me.GVORGANISME.Appearance.GroupRow.Image = CType(resources.GetObject("GVORGANISME.Appearance.GroupRow.Image"), System.Drawing.Image)
        Me.GVORGANISME.Appearance.GroupRow.Options.UseBackColor = True
        Me.GVORGANISME.Appearance.GroupRow.Options.UseBorderColor = True
        Me.GVORGANISME.Appearance.GroupRow.Options.UseFont = True
        Me.GVORGANISME.Appearance.GroupRow.Options.UseForeColor = True
        Me.GVORGANISME.Appearance.HeaderPanel.BackColor = CType(resources.GetObject("GVORGANISME.Appearance.HeaderPanel.BackColor"), System.Drawing.Color)
        Me.GVORGANISME.Appearance.HeaderPanel.BackColor2 = CType(resources.GetObject("GVORGANISME.Appearance.HeaderPanel.BackColor2"), System.Drawing.Color)
        Me.GVORGANISME.Appearance.HeaderPanel.BorderColor = CType(resources.GetObject("GVORGANISME.Appearance.HeaderPanel.BorderColor"), System.Drawing.Color)
        Me.GVORGANISME.Appearance.HeaderPanel.Font = CType(resources.GetObject("GVORGANISME.Appearance.HeaderPanel.Font"), System.Drawing.Font)
        Me.GVORGANISME.Appearance.HeaderPanel.FontSizeDelta = CType(resources.GetObject("GVORGANISME.Appearance.HeaderPanel.FontSizeDelta"), Integer)
        Me.GVORGANISME.Appearance.HeaderPanel.FontStyleDelta = CType(resources.GetObject("GVORGANISME.Appearance.HeaderPanel.FontStyleDelta"), System.Drawing.FontStyle)
        Me.GVORGANISME.Appearance.HeaderPanel.ForeColor = CType(resources.GetObject("GVORGANISME.Appearance.HeaderPanel.ForeColor"), System.Drawing.Color)
        Me.GVORGANISME.Appearance.HeaderPanel.GradientMode = CType(resources.GetObject("GVORGANISME.Appearance.HeaderPanel.GradientMode"), System.Drawing.Drawing2D.LinearGradientMode)
        Me.GVORGANISME.Appearance.HeaderPanel.Image = CType(resources.GetObject("GVORGANISME.Appearance.HeaderPanel.Image"), System.Drawing.Image)
        Me.GVORGANISME.Appearance.HeaderPanel.Options.UseBackColor = True
        Me.GVORGANISME.Appearance.HeaderPanel.Options.UseBorderColor = True
        Me.GVORGANISME.Appearance.HeaderPanel.Options.UseFont = True
        Me.GVORGANISME.Appearance.HeaderPanel.Options.UseForeColor = True
        Me.GVORGANISME.Appearance.HeaderPanel.Options.UseTextOptions = True
        Me.GVORGANISME.Appearance.HeaderPanel.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center
        Me.GVORGANISME.Appearance.HeaderPanel.TextOptions.VAlignment = DevExpress.Utils.VertAlignment.Center
        Me.GVORGANISME.Appearance.HideSelectionRow.BackColor = CType(resources.GetObject("GVORGANISME.Appearance.HideSelectionRow.BackColor"), System.Drawing.Color)
        Me.GVORGANISME.Appearance.HideSelectionRow.FontSizeDelta = CType(resources.GetObject("GVORGANISME.Appearance.HideSelectionRow.FontSizeDelta"), Integer)
        Me.GVORGANISME.Appearance.HideSelectionRow.FontStyleDelta = CType(resources.GetObject("GVORGANISME.Appearance.HideSelectionRow.FontStyleDelta"), System.Drawing.FontStyle)
        Me.GVORGANISME.Appearance.HideSelectionRow.ForeColor = CType(resources.GetObject("GVORGANISME.Appearance.HideSelectionRow.ForeColor"), System.Drawing.Color)
        Me.GVORGANISME.Appearance.HideSelectionRow.GradientMode = CType(resources.GetObject("GVORGANISME.Appearance.HideSelectionRow.GradientMode"), System.Drawing.Drawing2D.LinearGradientMode)
        Me.GVORGANISME.Appearance.HideSelectionRow.Image = CType(resources.GetObject("GVORGANISME.Appearance.HideSelectionRow.Image"), System.Drawing.Image)
        Me.GVORGANISME.Appearance.HideSelectionRow.Options.UseBackColor = True
        Me.GVORGANISME.Appearance.HideSelectionRow.Options.UseForeColor = True
        Me.GVORGANISME.Appearance.HorzLine.BackColor = CType(resources.GetObject("GVORGANISME.Appearance.HorzLine.BackColor"), System.Drawing.Color)
        Me.GVORGANISME.Appearance.HorzLine.FontSizeDelta = CType(resources.GetObject("GVORGANISME.Appearance.HorzLine.FontSizeDelta"), Integer)
        Me.GVORGANISME.Appearance.HorzLine.FontStyleDelta = CType(resources.GetObject("GVORGANISME.Appearance.HorzLine.FontStyleDelta"), System.Drawing.FontStyle)
        Me.GVORGANISME.Appearance.HorzLine.GradientMode = CType(resources.GetObject("GVORGANISME.Appearance.HorzLine.GradientMode"), System.Drawing.Drawing2D.LinearGradientMode)
        Me.GVORGANISME.Appearance.HorzLine.Image = CType(resources.GetObject("GVORGANISME.Appearance.HorzLine.Image"), System.Drawing.Image)
        Me.GVORGANISME.Appearance.HorzLine.Options.UseBackColor = True
        Me.GVORGANISME.Appearance.OddRow.BackColor = CType(resources.GetObject("GVORGANISME.Appearance.OddRow.BackColor"), System.Drawing.Color)
        Me.GVORGANISME.Appearance.OddRow.FontSizeDelta = CType(resources.GetObject("GVORGANISME.Appearance.OddRow.FontSizeDelta"), Integer)
        Me.GVORGANISME.Appearance.OddRow.FontStyleDelta = CType(resources.GetObject("GVORGANISME.Appearance.OddRow.FontStyleDelta"), System.Drawing.FontStyle)
        Me.GVORGANISME.Appearance.OddRow.ForeColor = CType(resources.GetObject("GVORGANISME.Appearance.OddRow.ForeColor"), System.Drawing.Color)
        Me.GVORGANISME.Appearance.OddRow.GradientMode = CType(resources.GetObject("GVORGANISME.Appearance.OddRow.GradientMode"), System.Drawing.Drawing2D.LinearGradientMode)
        Me.GVORGANISME.Appearance.OddRow.Image = CType(resources.GetObject("GVORGANISME.Appearance.OddRow.Image"), System.Drawing.Image)
        Me.GVORGANISME.Appearance.OddRow.Options.UseBackColor = True
        Me.GVORGANISME.Appearance.OddRow.Options.UseForeColor = True
        Me.GVORGANISME.Appearance.Preview.BackColor = CType(resources.GetObject("GVORGANISME.Appearance.Preview.BackColor"), System.Drawing.Color)
        Me.GVORGANISME.Appearance.Preview.FontSizeDelta = CType(resources.GetObject("GVORGANISME.Appearance.Preview.FontSizeDelta"), Integer)
        Me.GVORGANISME.Appearance.Preview.FontStyleDelta = CType(resources.GetObject("GVORGANISME.Appearance.Preview.FontStyleDelta"), System.Drawing.FontStyle)
        Me.GVORGANISME.Appearance.Preview.ForeColor = CType(resources.GetObject("GVORGANISME.Appearance.Preview.ForeColor"), System.Drawing.Color)
        Me.GVORGANISME.Appearance.Preview.GradientMode = CType(resources.GetObject("GVORGANISME.Appearance.Preview.GradientMode"), System.Drawing.Drawing2D.LinearGradientMode)
        Me.GVORGANISME.Appearance.Preview.Image = CType(resources.GetObject("GVORGANISME.Appearance.Preview.Image"), System.Drawing.Image)
        Me.GVORGANISME.Appearance.Preview.Options.UseBackColor = True
        Me.GVORGANISME.Appearance.Preview.Options.UseForeColor = True
        Me.GVORGANISME.Appearance.Row.BackColor = CType(resources.GetObject("GVORGANISME.Appearance.Row.BackColor"), System.Drawing.Color)
        Me.GVORGANISME.Appearance.Row.FontSizeDelta = CType(resources.GetObject("GVORGANISME.Appearance.Row.FontSizeDelta"), Integer)
        Me.GVORGANISME.Appearance.Row.FontStyleDelta = CType(resources.GetObject("GVORGANISME.Appearance.Row.FontStyleDelta"), System.Drawing.FontStyle)
        Me.GVORGANISME.Appearance.Row.ForeColor = CType(resources.GetObject("GVORGANISME.Appearance.Row.ForeColor"), System.Drawing.Color)
        Me.GVORGANISME.Appearance.Row.GradientMode = CType(resources.GetObject("GVORGANISME.Appearance.Row.GradientMode"), System.Drawing.Drawing2D.LinearGradientMode)
        Me.GVORGANISME.Appearance.Row.Image = CType(resources.GetObject("GVORGANISME.Appearance.Row.Image"), System.Drawing.Image)
        Me.GVORGANISME.Appearance.Row.Options.UseBackColor = True
        Me.GVORGANISME.Appearance.Row.Options.UseForeColor = True
        Me.GVORGANISME.Appearance.RowSeparator.BackColor = CType(resources.GetObject("GVORGANISME.Appearance.RowSeparator.BackColor"), System.Drawing.Color)
        Me.GVORGANISME.Appearance.RowSeparator.FontSizeDelta = CType(resources.GetObject("GVORGANISME.Appearance.RowSeparator.FontSizeDelta"), Integer)
        Me.GVORGANISME.Appearance.RowSeparator.FontStyleDelta = CType(resources.GetObject("GVORGANISME.Appearance.RowSeparator.FontStyleDelta"), System.Drawing.FontStyle)
        Me.GVORGANISME.Appearance.RowSeparator.GradientMode = CType(resources.GetObject("GVORGANISME.Appearance.RowSeparator.GradientMode"), System.Drawing.Drawing2D.LinearGradientMode)
        Me.GVORGANISME.Appearance.RowSeparator.Image = CType(resources.GetObject("GVORGANISME.Appearance.RowSeparator.Image"), System.Drawing.Image)
        Me.GVORGANISME.Appearance.RowSeparator.Options.UseBackColor = True
        Me.GVORGANISME.Appearance.SelectedRow.BackColor = CType(resources.GetObject("GVORGANISME.Appearance.SelectedRow.BackColor"), System.Drawing.Color)
        Me.GVORGANISME.Appearance.SelectedRow.FontSizeDelta = CType(resources.GetObject("GVORGANISME.Appearance.SelectedRow.FontSizeDelta"), Integer)
        Me.GVORGANISME.Appearance.SelectedRow.FontStyleDelta = CType(resources.GetObject("GVORGANISME.Appearance.SelectedRow.FontStyleDelta"), System.Drawing.FontStyle)
        Me.GVORGANISME.Appearance.SelectedRow.ForeColor = CType(resources.GetObject("GVORGANISME.Appearance.SelectedRow.ForeColor"), System.Drawing.Color)
        Me.GVORGANISME.Appearance.SelectedRow.GradientMode = CType(resources.GetObject("GVORGANISME.Appearance.SelectedRow.GradientMode"), System.Drawing.Drawing2D.LinearGradientMode)
        Me.GVORGANISME.Appearance.SelectedRow.Image = CType(resources.GetObject("GVORGANISME.Appearance.SelectedRow.Image"), System.Drawing.Image)
        Me.GVORGANISME.Appearance.SelectedRow.Options.UseBackColor = True
        Me.GVORGANISME.Appearance.SelectedRow.Options.UseForeColor = True
        Me.GVORGANISME.Appearance.VertLine.BackColor = CType(resources.GetObject("GVORGANISME.Appearance.VertLine.BackColor"), System.Drawing.Color)
        Me.GVORGANISME.Appearance.VertLine.FontSizeDelta = CType(resources.GetObject("GVORGANISME.Appearance.VertLine.FontSizeDelta"), Integer)
        Me.GVORGANISME.Appearance.VertLine.FontStyleDelta = CType(resources.GetObject("GVORGANISME.Appearance.VertLine.FontStyleDelta"), System.Drawing.FontStyle)
        Me.GVORGANISME.Appearance.VertLine.GradientMode = CType(resources.GetObject("GVORGANISME.Appearance.VertLine.GradientMode"), System.Drawing.Drawing2D.LinearGradientMode)
        Me.GVORGANISME.Appearance.VertLine.Image = CType(resources.GetObject("GVORGANISME.Appearance.VertLine.Image"), System.Drawing.Image)
        Me.GVORGANISME.Appearance.VertLine.Options.UseBackColor = True
        resources.ApplyResources(Me.GVORGANISME, "GVORGANISME")
        Me.GVORGANISME.Columns.AddRange(New DevExpress.XtraGrid.Columns.GridColumn() {Me.ColIDTMP, Me.ColNORGNUM, Me.ColVORGNOM, Me.ColVORGADRESSE, Me.ColVORGOBS})
        Me.GVORGANISME.GridControl = Me.GCORGANISME
        Me.GVORGANISME.Name = "GVORGANISME"
        Me.GVORGANISME.OptionsView.EnableAppearanceEvenRow = True
        Me.GVORGANISME.OptionsView.EnableAppearanceOddRow = True
        Me.GVORGANISME.OptionsView.ShowGroupPanel = False
        '
        'ColVORGADRESSE
        '
        resources.ApplyResources(Me.ColVORGADRESSE, "ColVORGADRESSE")
        Me.ColVORGADRESSE.FieldName = "VORGADRESSE"
        Me.ColVORGADRESSE.Name = "ColVORGADRESSE"
        '
        'ColVORGOBS
        '
        resources.ApplyResources(Me.ColVORGOBS, "ColVORGOBS")
        Me.ColVORGOBS.FieldName = "VORGOBS"
        Me.ColVORGOBS.Name = "ColVORGOBS"
        '
        'GCORGANISME
        '
        resources.ApplyResources(Me.GCORGANISME, "GCORGANISME")
        '
        '
        '
        Me.GCORGANISME.EmbeddedNavigator.AccessibleDescription = resources.GetString("GCORGANISME.EmbeddedNavigator.AccessibleDescription")
        Me.GCORGANISME.EmbeddedNavigator.AccessibleName = resources.GetString("GCORGANISME.EmbeddedNavigator.AccessibleName")
        Me.GCORGANISME.EmbeddedNavigator.AllowHtmlTextInToolTip = CType(resources.GetObject("GCORGANISME.EmbeddedNavigator.AllowHtmlTextInToolTip"), DevExpress.Utils.DefaultBoolean)
        Me.GCORGANISME.EmbeddedNavigator.Anchor = CType(resources.GetObject("GCORGANISME.EmbeddedNavigator.Anchor"), System.Windows.Forms.AnchorStyles)
        Me.GCORGANISME.EmbeddedNavigator.BackgroundImage = CType(resources.GetObject("GCORGANISME.EmbeddedNavigator.BackgroundImage"), System.Drawing.Image)
        Me.GCORGANISME.EmbeddedNavigator.BackgroundImageLayout = CType(resources.GetObject("GCORGANISME.EmbeddedNavigator.BackgroundImageLayout"), System.Windows.Forms.ImageLayout)
        Me.GCORGANISME.EmbeddedNavigator.ImeMode = CType(resources.GetObject("GCORGANISME.EmbeddedNavigator.ImeMode"), System.Windows.Forms.ImeMode)
        Me.GCORGANISME.EmbeddedNavigator.MaximumSize = CType(resources.GetObject("GCORGANISME.EmbeddedNavigator.MaximumSize"), System.Drawing.Size)
        Me.GCORGANISME.EmbeddedNavigator.TextLocation = CType(resources.GetObject("GCORGANISME.EmbeddedNavigator.TextLocation"), DevExpress.XtraEditors.NavigatorButtonsTextLocation)
        Me.GCORGANISME.EmbeddedNavigator.ToolTip = resources.GetString("GCORGANISME.EmbeddedNavigator.ToolTip")
        Me.GCORGANISME.EmbeddedNavigator.ToolTipIconType = CType(resources.GetObject("GCORGANISME.EmbeddedNavigator.ToolTipIconType"), DevExpress.Utils.ToolTipIconType)
        Me.GCORGANISME.EmbeddedNavigator.ToolTipTitle = resources.GetString("GCORGANISME.EmbeddedNavigator.ToolTipTitle")
        Me.GCORGANISME.MainView = Me.GVORGANISME
        Me.GCORGANISME.Name = "GCORGANISME"
        Me.GCORGANISME.ViewCollection.AddRange(New DevExpress.XtraGrid.Views.Base.BaseView() {Me.GVORGANISME})
        '
        'BtnSupprLine
        '
        resources.ApplyResources(Me.BtnSupprLine, "BtnSupprLine")
        Me.BtnSupprLine.BackColor = System.Drawing.Color.LightGreen
        Me.BtnSupprLine.Name = "BtnSupprLine"
        Me.BtnSupprLine.UseVisualStyleBackColor = False
        '
        'BtnQuit
        '
        resources.ApplyResources(Me.BtnQuit, "BtnQuit")
        Me.BtnQuit.Name = "BtnQuit"
        Me.BtnQuit.UseVisualStyleBackColor = True
        '
        'GrpActions
        '
        resources.ApplyResources(Me.GrpActions, "GrpActions")
        Me.GrpActions.Controls.Add(Me.BtnSupprLine)
        Me.GrpActions.Controls.Add(Me.BtnAddLine)
        Me.GrpActions.Controls.Add(Me.BtnQuit)
        Me.GrpActions.Controls.Add(Me.BtnSave)
        Me.GrpActions.Name = "GrpActions"
        Me.GrpActions.TabStop = False
        '
        'BtnSave
        '
        resources.ApplyResources(Me.BtnSave, "BtnSave")
        Me.BtnSave.Name = "BtnSave"
        Me.BtnSave.UseVisualStyleBackColor = True
        '
        'frmOrganisme
        '
        resources.ApplyResources(Me, "$this")
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.Wheat
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.GCORGANISME)
        Me.Controls.Add(Me.GrpActions)
        Me.Name = "frmOrganisme"
        CType(Me.GVORGANISME, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.GCORGANISME, System.ComponentModel.ISupportInitialize).EndInit()
        Me.GrpActions.ResumeLayout(False)
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents BtnAddLine As System.Windows.Forms.Button
    Friend WithEvents BtnSupprLine As System.Windows.Forms.Button
    Friend WithEvents BtnQuit As System.Windows.Forms.Button
    Friend WithEvents GrpActions As System.Windows.Forms.GroupBox
    Friend WithEvents BtnSave As System.Windows.Forms.Button
    Private WithEvents ColIDTMP As DevExpress.XtraGrid.Columns.GridColumn
    Private WithEvents ColNORGNUM As DevExpress.XtraGrid.Columns.GridColumn
    Private WithEvents ColVORGNOM As DevExpress.XtraGrid.Columns.GridColumn
    Private WithEvents GVORGANISME As DevExpress.XtraGrid.Views.Grid.GridView
    Private WithEvents GCORGANISME As DevExpress.XtraGrid.GridControl
    Private WithEvents ColVORGOBS As DevExpress.XtraGrid.Columns.GridColumn
    Private WithEvents ColVORGADRESSE As DevExpress.XtraGrid.Columns.GridColumn
End Class
