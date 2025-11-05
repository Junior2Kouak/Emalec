<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class frmGestCompteAna
  Inherits System.Windows.Forms.Form

  'Form remplace la méthode Dispose pour nettoyer la liste des composants.
  <System.Diagnostics.DebuggerNonUserCode()>
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
  <System.Diagnostics.DebuggerStepThrough()>
  Private Sub InitializeComponent()
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(frmGestCompteAna))
        Me.GCCompteAna = New DevExpress.XtraGrid.GridControl()
        Me.GVCompteAna = New DevExpress.XtraGrid.Views.Grid.GridView()
        Me.GColNCANNUM = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.GColVCANLIB = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.GColCTYPECTE = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.GColNRFAPOURC = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.RepositoryItemTextEdit1 = New DevExpress.XtraEditors.Repository.RepositoryItemTextEdit()
        Me.GColVSOCIETE = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.GColMBEHMBE = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.GrpActions = New System.Windows.Forms.GroupBox()
        Me.btnExtraire = New System.Windows.Forms.Button()
        Me.BtnPrint = New System.Windows.Forms.Button()
        Me.BtnAffectByPers = New System.Windows.Forms.Button()
        Me.BtnRestaurer = New System.Windows.Forms.Button()
        Me.ChkArchives = New System.Windows.Forms.CheckBox()
        Me.BtnArchiver = New System.Windows.Forms.Button()
        Me.BtnModifier = New System.Windows.Forms.Button()
        Me.BtnAjouter = New System.Windows.Forms.Button()
        Me.BtnFermer = New System.Windows.Forms.Button()
        Me.LblTitre = New System.Windows.Forms.Label()
        Me.PrintDialog = New System.Windows.Forms.PrintDialog()
        Me.GColDATCREE = New DevExpress.XtraGrid.Columns.GridColumn()
        CType(Me.GCCompteAna, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.GVCompteAna, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.RepositoryItemTextEdit1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.GrpActions.SuspendLayout()
        Me.SuspendLayout()
        '
        'GCCompteAna
        '
        resources.ApplyResources(Me.GCCompteAna, "GCCompteAna")
        Me.GCCompteAna.MainView = Me.GVCompteAna
        Me.GCCompteAna.Name = "GCCompteAna"
        Me.GCCompteAna.RepositoryItems.AddRange(New DevExpress.XtraEditors.Repository.RepositoryItem() {Me.RepositoryItemTextEdit1})
        Me.GCCompteAna.ViewCollection.AddRange(New DevExpress.XtraGrid.Views.Base.BaseView() {Me.GVCompteAna})
        '
        'GVCompteAna
        '
        Me.GVCompteAna.Appearance.ColumnFilterButton.BackColor = System.Drawing.Color.FromArgb(CType(CType(221, Byte), Integer), CType(CType(236, Byte), Integer), CType(CType(254, Byte), Integer))
        Me.GVCompteAna.Appearance.ColumnFilterButton.BackColor2 = CType(resources.GetObject("GVCompteAna.Appearance.ColumnFilterButton.BackColor2"), System.Drawing.Color)
        Me.GVCompteAna.Appearance.ColumnFilterButton.BorderColor = System.Drawing.Color.FromArgb(CType(CType(221, Byte), Integer), CType(CType(236, Byte), Integer), CType(CType(254, Byte), Integer))
        Me.GVCompteAna.Appearance.ColumnFilterButton.ForeColor = System.Drawing.Color.Black
        Me.GVCompteAna.Appearance.ColumnFilterButton.GradientMode = CType(resources.GetObject("GVCompteAna.Appearance.ColumnFilterButton.GradientMode"), System.Drawing.Drawing2D.LinearGradientMode)
        Me.GVCompteAna.Appearance.ColumnFilterButton.Options.UseBackColor = True
        Me.GVCompteAna.Appearance.ColumnFilterButton.Options.UseBorderColor = True
        Me.GVCompteAna.Appearance.ColumnFilterButton.Options.UseForeColor = True
        Me.GVCompteAna.Appearance.ColumnFilterButtonActive.BackColor = System.Drawing.Color.FromArgb(CType(CType(247, Byte), Integer), CType(CType(251, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.GVCompteAna.Appearance.ColumnFilterButtonActive.BackColor2 = CType(resources.GetObject("GVCompteAna.Appearance.ColumnFilterButtonActive.BackColor2"), System.Drawing.Color)
        Me.GVCompteAna.Appearance.ColumnFilterButtonActive.BorderColor = System.Drawing.Color.FromArgb(CType(CType(247, Byte), Integer), CType(CType(251, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.GVCompteAna.Appearance.ColumnFilterButtonActive.ForeColor = System.Drawing.Color.Black
        Me.GVCompteAna.Appearance.ColumnFilterButtonActive.GradientMode = CType(resources.GetObject("GVCompteAna.Appearance.ColumnFilterButtonActive.GradientMode"), System.Drawing.Drawing2D.LinearGradientMode)
        Me.GVCompteAna.Appearance.ColumnFilterButtonActive.Options.UseBackColor = True
        Me.GVCompteAna.Appearance.ColumnFilterButtonActive.Options.UseBorderColor = True
        Me.GVCompteAna.Appearance.ColumnFilterButtonActive.Options.UseForeColor = True
        Me.GVCompteAna.Appearance.Empty.BackColor = System.Drawing.Color.White
        Me.GVCompteAna.Appearance.Empty.Options.UseBackColor = True
        Me.GVCompteAna.Appearance.EvenRow.BackColor = System.Drawing.Color.FromArgb(CType(CType(231, Byte), Integer), CType(CType(242, Byte), Integer), CType(CType(254, Byte), Integer))
        Me.GVCompteAna.Appearance.EvenRow.ForeColor = System.Drawing.Color.Black
        Me.GVCompteAna.Appearance.EvenRow.Options.UseBackColor = True
        Me.GVCompteAna.Appearance.EvenRow.Options.UseForeColor = True
        Me.GVCompteAna.Appearance.FilterCloseButton.BackColor = System.Drawing.Color.FromArgb(CType(CType(221, Byte), Integer), CType(CType(236, Byte), Integer), CType(CType(254, Byte), Integer))
        Me.GVCompteAna.Appearance.FilterCloseButton.BackColor2 = CType(resources.GetObject("GVCompteAna.Appearance.FilterCloseButton.BackColor2"), System.Drawing.Color)
        Me.GVCompteAna.Appearance.FilterCloseButton.BorderColor = System.Drawing.Color.FromArgb(CType(CType(221, Byte), Integer), CType(CType(236, Byte), Integer), CType(CType(254, Byte), Integer))
        Me.GVCompteAna.Appearance.FilterCloseButton.ForeColor = System.Drawing.Color.Black
        Me.GVCompteAna.Appearance.FilterCloseButton.GradientMode = CType(resources.GetObject("GVCompteAna.Appearance.FilterCloseButton.GradientMode"), System.Drawing.Drawing2D.LinearGradientMode)
        Me.GVCompteAna.Appearance.FilterCloseButton.Options.UseBackColor = True
        Me.GVCompteAna.Appearance.FilterCloseButton.Options.UseBorderColor = True
        Me.GVCompteAna.Appearance.FilterCloseButton.Options.UseForeColor = True
        Me.GVCompteAna.Appearance.FilterPanel.BackColor = System.Drawing.Color.FromArgb(CType(CType(62, Byte), Integer), CType(CType(109, Byte), Integer), CType(CType(185, Byte), Integer))
        Me.GVCompteAna.Appearance.FilterPanel.ForeColor = System.Drawing.Color.White
        Me.GVCompteAna.Appearance.FilterPanel.Options.UseBackColor = True
        Me.GVCompteAna.Appearance.FilterPanel.Options.UseForeColor = True
        Me.GVCompteAna.Appearance.FixedLine.BackColor = System.Drawing.Color.FromArgb(CType(CType(59, Byte), Integer), CType(CType(97, Byte), Integer), CType(CType(156, Byte), Integer))
        Me.GVCompteAna.Appearance.FixedLine.Options.UseBackColor = True
        Me.GVCompteAna.Appearance.FocusedCell.BackColor = System.Drawing.Color.White
        Me.GVCompteAna.Appearance.FocusedCell.ForeColor = System.Drawing.Color.Black
        Me.GVCompteAna.Appearance.FocusedCell.Options.UseBackColor = True
        Me.GVCompteAna.Appearance.FocusedCell.Options.UseForeColor = True
        Me.GVCompteAna.Appearance.FocusedRow.BackColor = System.Drawing.Color.FromArgb(CType(CType(49, Byte), Integer), CType(CType(106, Byte), Integer), CType(CType(197, Byte), Integer))
        Me.GVCompteAna.Appearance.FocusedRow.ForeColor = System.Drawing.Color.White
        Me.GVCompteAna.Appearance.FocusedRow.Options.UseBackColor = True
        Me.GVCompteAna.Appearance.FocusedRow.Options.UseForeColor = True
        Me.GVCompteAna.Appearance.FooterPanel.BackColor = System.Drawing.Color.Gainsboro
        Me.GVCompteAna.Appearance.FooterPanel.BorderColor = System.Drawing.Color.FromArgb(CType(CType(221, Byte), Integer), CType(CType(236, Byte), Integer), CType(CType(254, Byte), Integer))
        Me.GVCompteAna.Appearance.FooterPanel.ForeColor = System.Drawing.Color.Black
        Me.GVCompteAna.Appearance.FooterPanel.GradientMode = CType(resources.GetObject("GVCompteAna.Appearance.FooterPanel.GradientMode"), System.Drawing.Drawing2D.LinearGradientMode)
        Me.GVCompteAna.Appearance.FooterPanel.Options.UseBackColor = True
        Me.GVCompteAna.Appearance.FooterPanel.Options.UseBorderColor = True
        Me.GVCompteAna.Appearance.FooterPanel.Options.UseForeColor = True
        Me.GVCompteAna.Appearance.GroupButton.BackColor = System.Drawing.Color.FromArgb(CType(CType(193, Byte), Integer), CType(CType(216, Byte), Integer), CType(CType(247, Byte), Integer))
        Me.GVCompteAna.Appearance.GroupButton.BorderColor = System.Drawing.Color.FromArgb(CType(CType(193, Byte), Integer), CType(CType(216, Byte), Integer), CType(CType(247, Byte), Integer))
        Me.GVCompteAna.Appearance.GroupButton.ForeColor = System.Drawing.Color.Black
        Me.GVCompteAna.Appearance.GroupButton.Options.UseBackColor = True
        Me.GVCompteAna.Appearance.GroupButton.Options.UseBorderColor = True
        Me.GVCompteAna.Appearance.GroupButton.Options.UseForeColor = True
        Me.GVCompteAna.Appearance.GroupFooter.BackColor = System.Drawing.Color.FromArgb(CType(CType(193, Byte), Integer), CType(CType(216, Byte), Integer), CType(CType(247, Byte), Integer))
        Me.GVCompteAna.Appearance.GroupFooter.BorderColor = System.Drawing.Color.FromArgb(CType(CType(193, Byte), Integer), CType(CType(216, Byte), Integer), CType(CType(247, Byte), Integer))
        Me.GVCompteAna.Appearance.GroupFooter.Font = CType(resources.GetObject("GVCompteAna.Appearance.GroupFooter.Font"), System.Drawing.Font)
        Me.GVCompteAna.Appearance.GroupFooter.ForeColor = System.Drawing.Color.Black
        Me.GVCompteAna.Appearance.GroupFooter.Options.UseBackColor = True
        Me.GVCompteAna.Appearance.GroupFooter.Options.UseBorderColor = True
        Me.GVCompteAna.Appearance.GroupFooter.Options.UseFont = True
        Me.GVCompteAna.Appearance.GroupFooter.Options.UseForeColor = True
        Me.GVCompteAna.Appearance.GroupPanel.BackColor = System.Drawing.Color.FromArgb(CType(CType(62, Byte), Integer), CType(CType(109, Byte), Integer), CType(CType(185, Byte), Integer))
        Me.GVCompteAna.Appearance.GroupPanel.ForeColor = System.Drawing.Color.FromArgb(CType(CType(221, Byte), Integer), CType(CType(236, Byte), Integer), CType(CType(254, Byte), Integer))
        Me.GVCompteAna.Appearance.GroupPanel.Options.UseBackColor = True
        Me.GVCompteAna.Appearance.GroupPanel.Options.UseForeColor = True
        Me.GVCompteAna.Appearance.GroupRow.BackColor = System.Drawing.Color.FromArgb(CType(CType(193, Byte), Integer), CType(CType(216, Byte), Integer), CType(CType(247, Byte), Integer))
        Me.GVCompteAna.Appearance.GroupRow.BorderColor = System.Drawing.Color.FromArgb(CType(CType(193, Byte), Integer), CType(CType(216, Byte), Integer), CType(CType(247, Byte), Integer))
        Me.GVCompteAna.Appearance.GroupRow.Font = CType(resources.GetObject("GVCompteAna.Appearance.GroupRow.Font"), System.Drawing.Font)
        Me.GVCompteAna.Appearance.GroupRow.ForeColor = System.Drawing.Color.Black
        Me.GVCompteAna.Appearance.GroupRow.Options.UseBackColor = True
        Me.GVCompteAna.Appearance.GroupRow.Options.UseBorderColor = True
        Me.GVCompteAna.Appearance.GroupRow.Options.UseFont = True
        Me.GVCompteAna.Appearance.GroupRow.Options.UseForeColor = True
        Me.GVCompteAna.Appearance.HeaderPanel.BackColor = System.Drawing.Color.FromArgb(CType(CType(221, Byte), Integer), CType(CType(236, Byte), Integer), CType(CType(254, Byte), Integer))
        Me.GVCompteAna.Appearance.HeaderPanel.BackColor2 = CType(resources.GetObject("GVCompteAna.Appearance.HeaderPanel.BackColor2"), System.Drawing.Color)
        Me.GVCompteAna.Appearance.HeaderPanel.BorderColor = System.Drawing.Color.FromArgb(CType(CType(221, Byte), Integer), CType(CType(236, Byte), Integer), CType(CType(254, Byte), Integer))
        Me.GVCompteAna.Appearance.HeaderPanel.ForeColor = System.Drawing.Color.Black
        Me.GVCompteAna.Appearance.HeaderPanel.GradientMode = CType(resources.GetObject("GVCompteAna.Appearance.HeaderPanel.GradientMode"), System.Drawing.Drawing2D.LinearGradientMode)
        Me.GVCompteAna.Appearance.HeaderPanel.Options.UseBackColor = True
        Me.GVCompteAna.Appearance.HeaderPanel.Options.UseBorderColor = True
        Me.GVCompteAna.Appearance.HeaderPanel.Options.UseForeColor = True
        Me.GVCompteAna.Appearance.HideSelectionRow.BackColor = System.Drawing.Color.FromArgb(CType(CType(106, Byte), Integer), CType(CType(153, Byte), Integer), CType(CType(228, Byte), Integer))
        Me.GVCompteAna.Appearance.HideSelectionRow.ForeColor = System.Drawing.Color.FromArgb(CType(CType(208, Byte), Integer), CType(CType(224, Byte), Integer), CType(CType(251, Byte), Integer))
        Me.GVCompteAna.Appearance.HideSelectionRow.Options.UseBackColor = True
        Me.GVCompteAna.Appearance.HideSelectionRow.Options.UseForeColor = True
        Me.GVCompteAna.Appearance.HorzLine.BackColor = System.Drawing.Color.FromArgb(CType(CType(99, Byte), Integer), CType(CType(127, Byte), Integer), CType(CType(196, Byte), Integer))
        Me.GVCompteAna.Appearance.HorzLine.Options.UseBackColor = True
        Me.GVCompteAna.Appearance.OddRow.BackColor = System.Drawing.Color.White
        Me.GVCompteAna.Appearance.OddRow.ForeColor = System.Drawing.Color.Black
        Me.GVCompteAna.Appearance.OddRow.Options.UseBackColor = True
        Me.GVCompteAna.Appearance.OddRow.Options.UseForeColor = True
        Me.GVCompteAna.Appearance.Preview.BackColor = System.Drawing.Color.FromArgb(CType(CType(249, Byte), Integer), CType(CType(252, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.GVCompteAna.Appearance.Preview.ForeColor = System.Drawing.Color.FromArgb(CType(CType(88, Byte), Integer), CType(CType(129, Byte), Integer), CType(CType(185, Byte), Integer))
        Me.GVCompteAna.Appearance.Preview.Options.UseBackColor = True
        Me.GVCompteAna.Appearance.Preview.Options.UseForeColor = True
        Me.GVCompteAna.Appearance.Row.BackColor = System.Drawing.Color.White
        Me.GVCompteAna.Appearance.Row.ForeColor = System.Drawing.Color.Black
        Me.GVCompteAna.Appearance.Row.Options.UseBackColor = True
        Me.GVCompteAna.Appearance.Row.Options.UseForeColor = True
        Me.GVCompteAna.Appearance.RowSeparator.BackColor = System.Drawing.Color.White
        Me.GVCompteAna.Appearance.RowSeparator.Options.UseBackColor = True
        Me.GVCompteAna.Appearance.SelectedRow.BackColor = System.Drawing.Color.FromArgb(CType(CType(69, Byte), Integer), CType(CType(126, Byte), Integer), CType(CType(217, Byte), Integer))
        Me.GVCompteAna.Appearance.SelectedRow.ForeColor = System.Drawing.Color.White
        Me.GVCompteAna.Appearance.SelectedRow.Options.UseBackColor = True
        Me.GVCompteAna.Appearance.SelectedRow.Options.UseForeColor = True
        Me.GVCompteAna.Appearance.VertLine.BackColor = System.Drawing.Color.FromArgb(CType(CType(99, Byte), Integer), CType(CType(127, Byte), Integer), CType(CType(196, Byte), Integer))
        Me.GVCompteAna.Appearance.VertLine.Options.UseBackColor = True
        Me.GVCompteAna.ColumnPanelRowHeight = 60
        Me.GVCompteAna.Columns.AddRange(New DevExpress.XtraGrid.Columns.GridColumn() {Me.GColNCANNUM, Me.GColVCANLIB, Me.GColCTYPECTE, Me.GColNRFAPOURC, Me.GColVSOCIETE, Me.GColMBEHMBE, Me.GColDATCREE})
        Me.GVCompteAna.GridControl = Me.GCCompteAna
        Me.GVCompteAna.Name = "GVCompteAna"
        Me.GVCompteAna.OptionsView.EnableAppearanceEvenRow = True
        Me.GVCompteAna.OptionsView.EnableAppearanceOddRow = True
        Me.GVCompteAna.OptionsView.ShowAutoFilterRow = True
        Me.GVCompteAna.OptionsView.ShowFooter = True
        Me.GVCompteAna.OptionsView.ShowGroupPanel = False
        Me.GVCompteAna.RowHeight = 20
        '
        'GColNCANNUM
        '
        Me.GColNCANNUM.AppearanceCell.Options.UseTextOptions = True
        Me.GColNCANNUM.AppearanceCell.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Near
        Me.GColNCANNUM.AppearanceCell.TextOptions.VAlignment = DevExpress.Utils.VertAlignment.Center
        Me.GColNCANNUM.AppearanceHeader.Font = CType(resources.GetObject("GColNCANNUM.AppearanceHeader.Font"), System.Drawing.Font)
        Me.GColNCANNUM.AppearanceHeader.Options.UseFont = True
        Me.GColNCANNUM.AppearanceHeader.Options.UseTextOptions = True
        Me.GColNCANNUM.AppearanceHeader.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center
        Me.GColNCANNUM.AppearanceHeader.TextOptions.VAlignment = DevExpress.Utils.VertAlignment.Center
        Me.GColNCANNUM.AppearanceHeader.TextOptions.WordWrap = DevExpress.Utils.WordWrap.Wrap
        resources.ApplyResources(Me.GColNCANNUM, "GColNCANNUM")
        Me.GColNCANNUM.FieldName = "NCANNUM"
        Me.GColNCANNUM.Name = "GColNCANNUM"
        Me.GColNCANNUM.OptionsColumn.AllowEdit = False
        Me.GColNCANNUM.OptionsColumn.ReadOnly = True
        Me.GColNCANNUM.OptionsFilter.AutoFilterCondition = DevExpress.XtraGrid.Columns.AutoFilterCondition.Contains
        '
        'GColVCANLIB
        '
        Me.GColVCANLIB.AppearanceCell.Options.UseTextOptions = True
        Me.GColVCANLIB.AppearanceCell.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Near
        Me.GColVCANLIB.AppearanceCell.TextOptions.VAlignment = DevExpress.Utils.VertAlignment.Center
        Me.GColVCANLIB.AppearanceCell.TextOptions.WordWrap = DevExpress.Utils.WordWrap.Wrap
        Me.GColVCANLIB.AppearanceHeader.Font = CType(resources.GetObject("GColVCANLIB.AppearanceHeader.Font"), System.Drawing.Font)
        Me.GColVCANLIB.AppearanceHeader.Options.UseFont = True
        Me.GColVCANLIB.AppearanceHeader.Options.UseTextOptions = True
        Me.GColVCANLIB.AppearanceHeader.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center
        Me.GColVCANLIB.AppearanceHeader.TextOptions.VAlignment = DevExpress.Utils.VertAlignment.Center
        Me.GColVCANLIB.AppearanceHeader.TextOptions.WordWrap = DevExpress.Utils.WordWrap.Wrap
        resources.ApplyResources(Me.GColVCANLIB, "GColVCANLIB")
        Me.GColVCANLIB.FieldName = "VCANLIB"
        Me.GColVCANLIB.Name = "GColVCANLIB"
        Me.GColVCANLIB.OptionsColumn.AllowEdit = False
        Me.GColVCANLIB.OptionsColumn.ReadOnly = True
        Me.GColVCANLIB.OptionsFilter.AutoFilterCondition = DevExpress.XtraGrid.Columns.AutoFilterCondition.Contains
        '
        'GColCTYPECTE
        '
        Me.GColCTYPECTE.AppearanceCell.Options.UseTextOptions = True
        Me.GColCTYPECTE.AppearanceCell.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Near
        Me.GColCTYPECTE.AppearanceCell.TextOptions.VAlignment = DevExpress.Utils.VertAlignment.Center
        Me.GColCTYPECTE.AppearanceCell.TextOptions.WordWrap = DevExpress.Utils.WordWrap.Wrap
        Me.GColCTYPECTE.AppearanceHeader.Font = CType(resources.GetObject("GColCTYPECTE.AppearanceHeader.Font"), System.Drawing.Font)
        Me.GColCTYPECTE.AppearanceHeader.Options.UseFont = True
        Me.GColCTYPECTE.AppearanceHeader.Options.UseTextOptions = True
        Me.GColCTYPECTE.AppearanceHeader.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center
        Me.GColCTYPECTE.AppearanceHeader.TextOptions.VAlignment = DevExpress.Utils.VertAlignment.Center
        Me.GColCTYPECTE.AppearanceHeader.TextOptions.WordWrap = DevExpress.Utils.WordWrap.Wrap
        resources.ApplyResources(Me.GColCTYPECTE, "GColCTYPECTE")
        Me.GColCTYPECTE.FieldName = "VTYPECTE"
        Me.GColCTYPECTE.Name = "GColCTYPECTE"
        Me.GColCTYPECTE.OptionsColumn.AllowEdit = False
        Me.GColCTYPECTE.OptionsColumn.ReadOnly = True
        Me.GColCTYPECTE.OptionsFilter.AutoFilterCondition = DevExpress.XtraGrid.Columns.AutoFilterCondition.Contains
        '
        'GColNRFAPOURC
        '
        Me.GColNRFAPOURC.AppearanceHeader.Font = CType(resources.GetObject("GColNRFAPOURC.AppearanceHeader.Font"), System.Drawing.Font)
        Me.GColNRFAPOURC.AppearanceHeader.Options.UseFont = True
        Me.GColNRFAPOURC.AppearanceHeader.Options.UseTextOptions = True
        Me.GColNRFAPOURC.AppearanceHeader.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center
        Me.GColNRFAPOURC.AppearanceHeader.TextOptions.VAlignment = DevExpress.Utils.VertAlignment.Center
        Me.GColNRFAPOURC.AppearanceHeader.TextOptions.WordWrap = DevExpress.Utils.WordWrap.Wrap
        resources.ApplyResources(Me.GColNRFAPOURC, "GColNRFAPOURC")
        Me.GColNRFAPOURC.ColumnEdit = Me.RepositoryItemTextEdit1
        Me.GColNRFAPOURC.DisplayFormat.FormatString = "p2"
        Me.GColNRFAPOURC.DisplayFormat.FormatType = DevExpress.Utils.FormatType.Numeric
        Me.GColNRFAPOURC.FieldName = "NRFAPOURC"
        Me.GColNRFAPOURC.Name = "GColNRFAPOURC"
        Me.GColNRFAPOURC.OptionsFilter.AutoFilterCondition = DevExpress.XtraGrid.Columns.AutoFilterCondition.Contains
        '
        'RepositoryItemTextEdit1
        '
        resources.ApplyResources(Me.RepositoryItemTextEdit1, "RepositoryItemTextEdit1")
        Me.RepositoryItemTextEdit1.Mask.EditMask = resources.GetString("RepositoryItemTextEdit1.Mask.EditMask")
        Me.RepositoryItemTextEdit1.Mask.MaskType = CType(resources.GetObject("RepositoryItemTextEdit1.Mask.MaskType"), DevExpress.XtraEditors.Mask.MaskType)
        Me.RepositoryItemTextEdit1.Mask.UseMaskAsDisplayFormat = CType(resources.GetObject("RepositoryItemTextEdit1.Mask.UseMaskAsDisplayFormat"), Boolean)
        Me.RepositoryItemTextEdit1.Name = "RepositoryItemTextEdit1"
        '
        'GColVSOCIETE
        '
        resources.ApplyResources(Me.GColVSOCIETE, "GColVSOCIETE")
        Me.GColVSOCIETE.FieldName = "VSOCIETE"
        Me.GColVSOCIETE.Name = "GColVSOCIETE"
        '
        'GColMBEHMBE
        '
        Me.GColMBEHMBE.AppearanceCell.Options.UseTextOptions = True
        Me.GColMBEHMBE.AppearanceCell.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center
        Me.GColMBEHMBE.AppearanceCell.TextOptions.VAlignment = DevExpress.Utils.VertAlignment.Center
        Me.GColMBEHMBE.AppearanceHeader.Font = CType(resources.GetObject("GridColumn1.AppearanceHeader.Font"), System.Drawing.Font)
        Me.GColMBEHMBE.AppearanceHeader.Options.UseFont = True
        Me.GColMBEHMBE.AppearanceHeader.Options.UseTextOptions = True
        Me.GColMBEHMBE.AppearanceHeader.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center
        Me.GColMBEHMBE.AppearanceHeader.TextOptions.VAlignment = DevExpress.Utils.VertAlignment.Center
        Me.GColMBEHMBE.AppearanceHeader.TextOptions.WordWrap = DevExpress.Utils.WordWrap.Wrap
        resources.ApplyResources(Me.GColMBEHMBE, "GColMBEHMBE")
        Me.GColMBEHMBE.FieldName = "VTYPEMBE"
        Me.GColMBEHMBE.Name = "GColMBEHMBE"
        Me.GColMBEHMBE.OptionsColumn.AllowEdit = False
        Me.GColMBEHMBE.OptionsColumn.ReadOnly = True
        Me.GColMBEHMBE.OptionsFilter.AutoFilterCondition = DevExpress.XtraGrid.Columns.AutoFilterCondition.Contains
        '
        'GrpActions
        '
        Me.GrpActions.Controls.Add(Me.btnExtraire)
        Me.GrpActions.Controls.Add(Me.BtnPrint)
        Me.GrpActions.Controls.Add(Me.BtnAffectByPers)
        Me.GrpActions.Controls.Add(Me.BtnRestaurer)
        Me.GrpActions.Controls.Add(Me.ChkArchives)
        Me.GrpActions.Controls.Add(Me.BtnArchiver)
        Me.GrpActions.Controls.Add(Me.BtnModifier)
        Me.GrpActions.Controls.Add(Me.BtnAjouter)
        Me.GrpActions.Controls.Add(Me.BtnFermer)
        resources.ApplyResources(Me.GrpActions, "GrpActions")
        Me.GrpActions.Name = "GrpActions"
        Me.GrpActions.TabStop = False
        '
        'btnExtraire
        '
        resources.ApplyResources(Me.btnExtraire, "btnExtraire")
        Me.btnExtraire.Name = "btnExtraire"
        Me.btnExtraire.UseVisualStyleBackColor = True
        '
        'BtnPrint
        '
        resources.ApplyResources(Me.BtnPrint, "BtnPrint")
        Me.BtnPrint.Name = "BtnPrint"
        Me.BtnPrint.Tag = "136"
        Me.BtnPrint.UseVisualStyleBackColor = True
        '
        'BtnAffectByPers
        '
        resources.ApplyResources(Me.BtnAffectByPers, "BtnAffectByPers")
        Me.BtnAffectByPers.Name = "BtnAffectByPers"
        Me.BtnAffectByPers.Tag = "136"
        Me.BtnAffectByPers.UseVisualStyleBackColor = True
        '
        'BtnRestaurer
        '
        resources.ApplyResources(Me.BtnRestaurer, "BtnRestaurer")
        Me.BtnRestaurer.Name = "BtnRestaurer"
        Me.BtnRestaurer.UseVisualStyleBackColor = True
        '
        'ChkArchives
        '
        resources.ApplyResources(Me.ChkArchives, "ChkArchives")
        Me.ChkArchives.Name = "ChkArchives"
        Me.ChkArchives.UseVisualStyleBackColor = True
        '
        'BtnArchiver
        '
        resources.ApplyResources(Me.BtnArchiver, "BtnArchiver")
        Me.BtnArchiver.Name = "BtnArchiver"
        Me.BtnArchiver.UseVisualStyleBackColor = True
        '
        'BtnModifier
        '
        resources.ApplyResources(Me.BtnModifier, "BtnModifier")
        Me.BtnModifier.Name = "BtnModifier"
        Me.BtnModifier.UseVisualStyleBackColor = True
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
        'LblTitre
        '
        resources.ApplyResources(Me.LblTitre, "LblTitre")
        Me.LblTitre.Name = "LblTitre"
        '
        'PrintDialog
        '
        Me.PrintDialog.UseEXDialog = True
        '
        'GColDATCREE
        '
        Me.GColDATCREE.AppearanceHeader.Font = CType(resources.GetObject("GridColumn2.AppearanceHeader.Font"), System.Drawing.Font)
        Me.GColDATCREE.AppearanceHeader.Options.UseFont = True
        resources.ApplyResources(Me.GColDATCREE, "GColDATCREE")
        Me.GColDATCREE.DisplayFormat.FormatString = "d"
        Me.GColDATCREE.DisplayFormat.FormatType = DevExpress.Utils.FormatType.DateTime
        Me.GColDATCREE.FieldName = "DDATCREE"
        Me.GColDATCREE.MinWidth = 30
        Me.GColDATCREE.Name = "GColDATCREE"
        Me.GColDATCREE.OptionsColumn.AllowEdit = False
        Me.GColDATCREE.OptionsColumn.ReadOnly = True
        '
        'frmGestCompteAna
        '
        resources.ApplyResources(Me, "$this")
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.Wheat
        Me.Controls.Add(Me.GCCompteAna)
        Me.Controls.Add(Me.GrpActions)
        Me.Controls.Add(Me.LblTitre)
        Me.Name = "frmGestCompteAna"
        Me.WindowState = System.Windows.Forms.FormWindowState.Maximized
        CType(Me.GCCompteAna, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.GVCompteAna, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.RepositoryItemTextEdit1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.GrpActions.ResumeLayout(False)
        Me.GrpActions.PerformLayout()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents GrpActions As System.Windows.Forms.GroupBox
    Friend WithEvents BtnFermer As System.Windows.Forms.Button
    Friend WithEvents LblTitre As System.Windows.Forms.Label
    Friend WithEvents BtnAjouter As System.Windows.Forms.Button
    Friend WithEvents BtnModifier As System.Windows.Forms.Button
    Friend WithEvents BtnArchiver As System.Windows.Forms.Button
    Friend WithEvents ChkArchives As System.Windows.Forms.CheckBox
    Friend WithEvents BtnRestaurer As System.Windows.Forms.Button
    Friend WithEvents BtnAffectByPers As System.Windows.Forms.Button
    Friend WithEvents BtnPrint As System.Windows.Forms.Button
    Friend WithEvents PrintDialog As System.Windows.Forms.PrintDialog
    Friend WithEvents btnExtraire As System.Windows.Forms.Button
    Private WithEvents GCCompteAna As DevExpress.XtraGrid.GridControl
    Private WithEvents GVCompteAna As DevExpress.XtraGrid.Views.Grid.GridView
    Private WithEvents GColNCANNUM As DevExpress.XtraGrid.Columns.GridColumn
    Private WithEvents GColVCANLIB As DevExpress.XtraGrid.Columns.GridColumn
    Private WithEvents GColCTYPECTE As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents GColNRFAPOURC As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents RepositoryItemTextEdit1 As DevExpress.XtraEditors.Repository.RepositoryItemTextEdit
    Friend WithEvents GColVSOCIETE As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents GColMBEHMBE As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents GColDATCREE As DevExpress.XtraGrid.Columns.GridColumn
End Class
