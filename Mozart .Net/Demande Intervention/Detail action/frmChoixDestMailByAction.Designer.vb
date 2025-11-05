<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmChoixDestMailByAction
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
    Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(frmChoixDestMailByAction))
    Me.GrpBoxPers = New System.Windows.Forms.GroupBox()
    Me.chkAppro = New System.Windows.Forms.CheckBox()
    Me.Label3 = New System.Windows.Forms.Label()
    Me.Label2 = New System.Windows.Forms.Label()
    Me.txtAppro = New System.Windows.Forms.TextBox()
    Me.Label1 = New System.Windows.Forms.Label()
    Me.TxtAddMail = New System.Windows.Forms.TextBox()
    Me.LblAutresMail = New System.Windows.Forms.Label()
    Me.BtnDecoche = New System.Windows.Forms.Button()
    Me.BtnCoche = New System.Windows.Forms.Button()
    Me.GCDestMail = New DevExpress.XtraGrid.GridControl()
    Me.GVDestMail = New DevExpress.XtraGrid.Views.Grid.GridView()
    Me.GColVCHECK = New DevExpress.XtraGrid.Columns.GridColumn()
    Me.RepositoryItemCheckEditCHECK = New DevExpress.XtraEditors.Repository.RepositoryItemCheckEdit()
    Me.GColVMAIL = New DevExpress.XtraGrid.Columns.GridColumn()
    Me.GColVNOM = New DevExpress.XtraGrid.Columns.GridColumn()
    Me.GColVPRENOM = New DevExpress.XtraGrid.Columns.GridColumn()
    Me.GColVFONCTION = New DevExpress.XtraGrid.Columns.GridColumn()
    Me.GroupBox1 = New System.Windows.Forms.GroupBox()
    Me.BtnValid = New System.Windows.Forms.Button()
    Me.BtnFermer = New System.Windows.Forms.Button()
    Me.LblTitre = New System.Windows.Forms.Label()
    Me.framObs = New MozartUC.apiGroupBox()
    Me.TxtObs = New MozartUC.apiTextBox()
    Me.lblLabels39 = New MozartUC.apiLabel()
        Me.GrpBoxPers.SuspendLayout()
        CType(Me.GCDestMail, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.GVDestMail, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.RepositoryItemCheckEditCHECK, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.GroupBox1.SuspendLayout()
        Me.framObs.SuspendLayout()
        Me.SuspendLayout()
        '
        'GrpBoxPers
        '
        Me.GrpBoxPers.Controls.Add(Me.chkAppro)
        Me.GrpBoxPers.Controls.Add(Me.Label3)
        Me.GrpBoxPers.Controls.Add(Me.Label2)
        Me.GrpBoxPers.Controls.Add(Me.txtAppro)
        Me.GrpBoxPers.Controls.Add(Me.Label1)
        Me.GrpBoxPers.Controls.Add(Me.TxtAddMail)
        Me.GrpBoxPers.Controls.Add(Me.LblAutresMail)
        Me.GrpBoxPers.Controls.Add(Me.BtnDecoche)
        Me.GrpBoxPers.Controls.Add(Me.BtnCoche)
        Me.GrpBoxPers.Controls.Add(Me.GCDestMail)
        resources.ApplyResources(Me.GrpBoxPers, "GrpBoxPers")
        Me.GrpBoxPers.Name = "GrpBoxPers"
        Me.GrpBoxPers.TabStop = False
        '
        'chkAppro
        '
        resources.ApplyResources(Me.chkAppro, "chkAppro")
        Me.chkAppro.Name = "chkAppro"
        Me.chkAppro.UseVisualStyleBackColor = True
        '
        'Label3
        '
        resources.ApplyResources(Me.Label3, "Label3")
        Me.Label3.Name = "Label3"
        '
        'Label2
        '
        resources.ApplyResources(Me.Label2, "Label2")
        Me.Label2.Name = "Label2"
        '
        'txtAppro
        '
        resources.ApplyResources(Me.txtAppro, "txtAppro")
        Me.txtAppro.Name = "txtAppro"
        '
        'Label1
        '
        resources.ApplyResources(Me.Label1, "Label1")
        Me.Label1.Name = "Label1"
        '
        'TxtAddMail
        '
        resources.ApplyResources(Me.TxtAddMail, "TxtAddMail")
        Me.TxtAddMail.Name = "TxtAddMail"
        '
        'LblAutresMail
        '
        resources.ApplyResources(Me.LblAutresMail, "LblAutresMail")
        Me.LblAutresMail.Name = "LblAutresMail"
        '
        'BtnDecoche
        '
        resources.ApplyResources(Me.BtnDecoche, "BtnDecoche")
        Me.BtnDecoche.Name = "BtnDecoche"
        Me.BtnDecoche.UseVisualStyleBackColor = True
        '
        'BtnCoche
        '
        resources.ApplyResources(Me.BtnCoche, "BtnCoche")
        Me.BtnCoche.Name = "BtnCoche"
        Me.BtnCoche.UseVisualStyleBackColor = True
        '
        'GCDestMail
        '
        resources.ApplyResources(Me.GCDestMail, "GCDestMail")
        Me.GCDestMail.MainView = Me.GVDestMail
        Me.GCDestMail.Name = "GCDestMail"
        Me.GCDestMail.RepositoryItems.AddRange(New DevExpress.XtraEditors.Repository.RepositoryItem() {Me.RepositoryItemCheckEditCHECK})
        Me.GCDestMail.ViewCollection.AddRange(New DevExpress.XtraGrid.Views.Base.BaseView() {Me.GVDestMail})
        '
        'GVDestMail
        '
        Me.GVDestMail.Appearance.ColumnFilterButton.BackColor = System.Drawing.Color.FromArgb(CType(CType(202, Byte), Integer), CType(CType(221, Byte), Integer), CType(CType(208, Byte), Integer))
        Me.GVDestMail.Appearance.ColumnFilterButton.BorderColor = System.Drawing.Color.FromArgb(CType(CType(202, Byte), Integer), CType(CType(221, Byte), Integer), CType(CType(208, Byte), Integer))
        Me.GVDestMail.Appearance.ColumnFilterButton.ForeColor = System.Drawing.Color.Black
        Me.GVDestMail.Appearance.ColumnFilterButton.Options.UseBackColor = True
        Me.GVDestMail.Appearance.ColumnFilterButton.Options.UseBorderColor = True
        Me.GVDestMail.Appearance.ColumnFilterButton.Options.UseForeColor = True
        Me.GVDestMail.Appearance.ColumnFilterButtonActive.BackColor = System.Drawing.Color.FromArgb(CType(CType(211, Byte), Integer), CType(CType(226, Byte), Integer), CType(CType(216, Byte), Integer))
        Me.GVDestMail.Appearance.ColumnFilterButtonActive.BorderColor = System.Drawing.Color.FromArgb(CType(CType(211, Byte), Integer), CType(CType(226, Byte), Integer), CType(CType(216, Byte), Integer))
        Me.GVDestMail.Appearance.ColumnFilterButtonActive.ForeColor = System.Drawing.Color.Black
        Me.GVDestMail.Appearance.ColumnFilterButtonActive.Options.UseBackColor = True
        Me.GVDestMail.Appearance.ColumnFilterButtonActive.Options.UseBorderColor = True
        Me.GVDestMail.Appearance.ColumnFilterButtonActive.Options.UseForeColor = True
        Me.GVDestMail.Appearance.Empty.BackColor = System.Drawing.Color.FromArgb(CType(CType(242, Byte), Integer), CType(CType(244, Byte), Integer), CType(CType(236, Byte), Integer))
        Me.GVDestMail.Appearance.Empty.BackColor2 = CType(resources.GetObject("GVDestMail.Appearance.Empty.BackColor2"), System.Drawing.Color)
        Me.GVDestMail.Appearance.Empty.Options.UseBackColor = True
        Me.GVDestMail.Appearance.EvenRow.BackColor = System.Drawing.Color.FromArgb(CType(CType(221, Byte), Integer), CType(CType(227, Byte), Integer), CType(CType(245, Byte), Integer))
        Me.GVDestMail.Appearance.EvenRow.BorderColor = System.Drawing.Color.FromArgb(CType(CType(221, Byte), Integer), CType(CType(227, Byte), Integer), CType(CType(245, Byte), Integer))
        Me.GVDestMail.Appearance.EvenRow.ForeColor = System.Drawing.Color.Black
        Me.GVDestMail.Appearance.EvenRow.Options.UseBackColor = True
        Me.GVDestMail.Appearance.EvenRow.Options.UseBorderColor = True
        Me.GVDestMail.Appearance.EvenRow.Options.UseForeColor = True
        Me.GVDestMail.Appearance.FilterCloseButton.BackColor = System.Drawing.Color.FromArgb(CType(CType(202, Byte), Integer), CType(CType(221, Byte), Integer), CType(CType(208, Byte), Integer))
        Me.GVDestMail.Appearance.FilterCloseButton.BorderColor = System.Drawing.Color.FromArgb(CType(CType(202, Byte), Integer), CType(CType(221, Byte), Integer), CType(CType(208, Byte), Integer))
        Me.GVDestMail.Appearance.FilterCloseButton.ForeColor = System.Drawing.Color.Black
        Me.GVDestMail.Appearance.FilterCloseButton.Options.UseBackColor = True
        Me.GVDestMail.Appearance.FilterCloseButton.Options.UseBorderColor = True
        Me.GVDestMail.Appearance.FilterCloseButton.Options.UseForeColor = True
        Me.GVDestMail.Appearance.FilterPanel.BackColor = System.Drawing.Color.FromArgb(CType(CType(242, Byte), Integer), CType(CType(244, Byte), Integer), CType(CType(236, Byte), Integer))
        Me.GVDestMail.Appearance.FilterPanel.BackColor2 = CType(resources.GetObject("GVDestMail.Appearance.FilterPanel.BackColor2"), System.Drawing.Color)
        Me.GVDestMail.Appearance.FilterPanel.ForeColor = System.Drawing.Color.Black
        Me.GVDestMail.Appearance.FilterPanel.Options.UseBackColor = True
        Me.GVDestMail.Appearance.FilterPanel.Options.UseForeColor = True
        Me.GVDestMail.Appearance.FixedLine.BackColor = System.Drawing.Color.FromArgb(CType(CType(117, Byte), Integer), CType(CType(136, Byte), Integer), CType(CType(122, Byte), Integer))
        Me.GVDestMail.Appearance.FixedLine.Options.UseBackColor = True
        Me.GVDestMail.Appearance.FocusedCell.BackColor = System.Drawing.Color.White
        Me.GVDestMail.Appearance.FocusedCell.ForeColor = System.Drawing.Color.Black
        Me.GVDestMail.Appearance.FocusedCell.Options.UseBackColor = True
        Me.GVDestMail.Appearance.FocusedCell.Options.UseForeColor = True
        Me.GVDestMail.Appearance.FocusedRow.BackColor = System.Drawing.Color.FromArgb(CType(CType(129, Byte), Integer), CType(CType(171, Byte), Integer), CType(CType(177, Byte), Integer))
        Me.GVDestMail.Appearance.FocusedRow.ForeColor = System.Drawing.Color.White
        Me.GVDestMail.Appearance.FocusedRow.Options.UseBackColor = True
        Me.GVDestMail.Appearance.FocusedRow.Options.UseForeColor = True
        Me.GVDestMail.Appearance.FooterPanel.BackColor = System.Drawing.Color.FromArgb(CType(CType(202, Byte), Integer), CType(CType(221, Byte), Integer), CType(CType(208, Byte), Integer))
        Me.GVDestMail.Appearance.FooterPanel.BorderColor = System.Drawing.Color.FromArgb(CType(CType(202, Byte), Integer), CType(CType(221, Byte), Integer), CType(CType(208, Byte), Integer))
        Me.GVDestMail.Appearance.FooterPanel.ForeColor = System.Drawing.Color.Black
        Me.GVDestMail.Appearance.FooterPanel.Options.UseBackColor = True
        Me.GVDestMail.Appearance.FooterPanel.Options.UseBorderColor = True
        Me.GVDestMail.Appearance.FooterPanel.Options.UseForeColor = True
        Me.GVDestMail.Appearance.GroupButton.BackColor = System.Drawing.Color.FromArgb(CType(CType(178, Byte), Integer), CType(CType(209, Byte), Integer), CType(CType(188, Byte), Integer))
        Me.GVDestMail.Appearance.GroupButton.BorderColor = System.Drawing.Color.FromArgb(CType(CType(178, Byte), Integer), CType(CType(209, Byte), Integer), CType(CType(188, Byte), Integer))
        Me.GVDestMail.Appearance.GroupButton.Options.UseBackColor = True
        Me.GVDestMail.Appearance.GroupButton.Options.UseBorderColor = True
        Me.GVDestMail.Appearance.GroupFooter.BackColor = System.Drawing.Color.FromArgb(CType(CType(215, Byte), Integer), CType(CType(234, Byte), Integer), CType(CType(221, Byte), Integer))
        Me.GVDestMail.Appearance.GroupFooter.BorderColor = System.Drawing.Color.FromArgb(CType(CType(215, Byte), Integer), CType(CType(234, Byte), Integer), CType(CType(221, Byte), Integer))
        Me.GVDestMail.Appearance.GroupFooter.ForeColor = System.Drawing.Color.Black
        Me.GVDestMail.Appearance.GroupFooter.Options.UseBackColor = True
        Me.GVDestMail.Appearance.GroupFooter.Options.UseBorderColor = True
        Me.GVDestMail.Appearance.GroupFooter.Options.UseForeColor = True
        Me.GVDestMail.Appearance.GroupPanel.BackColor = System.Drawing.Color.FromArgb(CType(CType(242, Byte), Integer), CType(CType(244, Byte), Integer), CType(CType(236, Byte), Integer))
        Me.GVDestMail.Appearance.GroupPanel.BackColor2 = CType(resources.GetObject("GVDestMail.Appearance.GroupPanel.BackColor2"), System.Drawing.Color)
        Me.GVDestMail.Appearance.GroupPanel.ForeColor = System.Drawing.Color.Black
        Me.GVDestMail.Appearance.GroupPanel.Options.UseBackColor = True
        Me.GVDestMail.Appearance.GroupPanel.Options.UseForeColor = True
        Me.GVDestMail.Appearance.GroupRow.BackColor = System.Drawing.Color.FromArgb(CType(CType(215, Byte), Integer), CType(CType(234, Byte), Integer), CType(CType(221, Byte), Integer))
        Me.GVDestMail.Appearance.GroupRow.BorderColor = System.Drawing.Color.FromArgb(CType(CType(215, Byte), Integer), CType(CType(234, Byte), Integer), CType(CType(221, Byte), Integer))
        Me.GVDestMail.Appearance.GroupRow.ForeColor = System.Drawing.Color.Black
        Me.GVDestMail.Appearance.GroupRow.Options.UseBackColor = True
        Me.GVDestMail.Appearance.GroupRow.Options.UseBorderColor = True
        Me.GVDestMail.Appearance.GroupRow.Options.UseForeColor = True
        Me.GVDestMail.Appearance.HeaderPanel.BackColor = System.Drawing.Color.FromArgb(CType(CType(211, Byte), Integer), CType(CType(226, Byte), Integer), CType(CType(216, Byte), Integer))
        Me.GVDestMail.Appearance.HeaderPanel.BorderColor = System.Drawing.Color.FromArgb(CType(CType(211, Byte), Integer), CType(CType(226, Byte), Integer), CType(CType(216, Byte), Integer))
        Me.GVDestMail.Appearance.HeaderPanel.Font = CType(resources.GetObject("GVDestMail.Appearance.HeaderPanel.Font"), System.Drawing.Font)
        Me.GVDestMail.Appearance.HeaderPanel.ForeColor = System.Drawing.Color.Black
        Me.GVDestMail.Appearance.HeaderPanel.Options.UseBackColor = True
        Me.GVDestMail.Appearance.HeaderPanel.Options.UseBorderColor = True
        Me.GVDestMail.Appearance.HeaderPanel.Options.UseFont = True
        Me.GVDestMail.Appearance.HeaderPanel.Options.UseForeColor = True
        Me.GVDestMail.Appearance.HideSelectionRow.BackColor = System.Drawing.Color.FromArgb(CType(CType(186, Byte), Integer), CType(CType(211, Byte), Integer), CType(CType(215, Byte), Integer))
        Me.GVDestMail.Appearance.HideSelectionRow.ForeColor = System.Drawing.Color.FromArgb(CType(CType(104, Byte), Integer), CType(CType(130, Byte), Integer), CType(CType(134, Byte), Integer))
        Me.GVDestMail.Appearance.HideSelectionRow.Options.UseBackColor = True
        Me.GVDestMail.Appearance.HideSelectionRow.Options.UseForeColor = True
        Me.GVDestMail.Appearance.HorzLine.BackColor = System.Drawing.Color.FromArgb(CType(CType(172, Byte), Integer), CType(CType(197, Byte), Integer), CType(CType(180, Byte), Integer))
        Me.GVDestMail.Appearance.HorzLine.BorderColor = System.Drawing.Color.FromArgb(CType(CType(117, Byte), Integer), CType(CType(136, Byte), Integer), CType(CType(122, Byte), Integer))
        Me.GVDestMail.Appearance.HorzLine.Options.UseBackColor = True
        Me.GVDestMail.Appearance.HorzLine.Options.UseBorderColor = True
        Me.GVDestMail.Appearance.OddRow.BackColor = System.Drawing.Color.FromArgb(CType(CType(242, Byte), Integer), CType(CType(244, Byte), Integer), CType(CType(236, Byte), Integer))
        Me.GVDestMail.Appearance.OddRow.BorderColor = System.Drawing.Color.FromArgb(CType(CType(242, Byte), Integer), CType(CType(244, Byte), Integer), CType(CType(236, Byte), Integer))
        Me.GVDestMail.Appearance.OddRow.ForeColor = System.Drawing.Color.Black
        Me.GVDestMail.Appearance.OddRow.Options.UseBackColor = True
        Me.GVDestMail.Appearance.OddRow.Options.UseBorderColor = True
        Me.GVDestMail.Appearance.OddRow.Options.UseForeColor = True
        Me.GVDestMail.Appearance.Preview.BackColor = System.Drawing.Color.FromArgb(CType(CType(250, Byte), Integer), CType(CType(250, Byte), Integer), CType(CType(240, Byte), Integer))
        Me.GVDestMail.Appearance.Preview.Font = CType(resources.GetObject("GVDestMail.Appearance.Preview.Font"), System.Drawing.Font)
        Me.GVDestMail.Appearance.Preview.ForeColor = System.Drawing.Color.FromArgb(CType(CType(104, Byte), Integer), CType(CType(130, Byte), Integer), CType(CType(134, Byte), Integer))
        Me.GVDestMail.Appearance.Preview.Options.UseBackColor = True
        Me.GVDestMail.Appearance.Preview.Options.UseFont = True
        Me.GVDestMail.Appearance.Preview.Options.UseForeColor = True
        Me.GVDestMail.Appearance.Row.BackColor = System.Drawing.Color.FromArgb(CType(CType(242, Byte), Integer), CType(CType(244, Byte), Integer), CType(CType(236, Byte), Integer))
        Me.GVDestMail.Appearance.Row.Font = CType(resources.GetObject("GVDestMail.Appearance.Row.Font"), System.Drawing.Font)
        Me.GVDestMail.Appearance.Row.ForeColor = System.Drawing.Color.Black
        Me.GVDestMail.Appearance.Row.Options.UseBackColor = True
        Me.GVDestMail.Appearance.Row.Options.UseFont = True
        Me.GVDestMail.Appearance.Row.Options.UseForeColor = True
        Me.GVDestMail.Appearance.RowSeparator.BackColor = System.Drawing.Color.FromArgb(CType(CType(242, Byte), Integer), CType(CType(244, Byte), Integer), CType(CType(236, Byte), Integer))
        Me.GVDestMail.Appearance.RowSeparator.BackColor2 = CType(resources.GetObject("GVDestMail.Appearance.RowSeparator.BackColor2"), System.Drawing.Color)
        Me.GVDestMail.Appearance.RowSeparator.Options.UseBackColor = True
        Me.GVDestMail.Appearance.SelectedRow.BackColor = System.Drawing.Color.FromArgb(CType(CType(159, Byte), Integer), CType(CType(201, Byte), Integer), CType(CType(207, Byte), Integer))
        Me.GVDestMail.Appearance.SelectedRow.ForeColor = System.Drawing.Color.Black
        Me.GVDestMail.Appearance.SelectedRow.Options.UseBackColor = True
        Me.GVDestMail.Appearance.SelectedRow.Options.UseForeColor = True
        Me.GVDestMail.Appearance.TopNewRow.BackColor = System.Drawing.Color.White
        Me.GVDestMail.Appearance.TopNewRow.Options.UseBackColor = True
        Me.GVDestMail.Appearance.VertLine.BackColor = System.Drawing.Color.FromArgb(CType(CType(172, Byte), Integer), CType(CType(197, Byte), Integer), CType(CType(180, Byte), Integer))
        Me.GVDestMail.Appearance.VertLine.BorderColor = System.Drawing.Color.FromArgb(CType(CType(117, Byte), Integer), CType(CType(136, Byte), Integer), CType(CType(122, Byte), Integer))
        Me.GVDestMail.Appearance.VertLine.Options.UseBackColor = True
        Me.GVDestMail.Appearance.VertLine.Options.UseBorderColor = True
        Me.GVDestMail.Columns.AddRange(New DevExpress.XtraGrid.Columns.GridColumn() {Me.GColVCHECK, Me.GColVMAIL, Me.GColVNOM, Me.GColVPRENOM, Me.GColVFONCTION})
        Me.GVDestMail.GridControl = Me.GCDestMail
        Me.GVDestMail.Name = "GVDestMail"
        Me.GVDestMail.OptionsView.EnableAppearanceEvenRow = True
        Me.GVDestMail.OptionsView.EnableAppearanceOddRow = True
        Me.GVDestMail.OptionsView.ShowAutoFilterRow = True
        Me.GVDestMail.OptionsView.ShowFilterPanelMode = DevExpress.XtraGrid.Views.Base.ShowFilterPanelMode.Never
        Me.GVDestMail.OptionsView.ShowFooter = True
        Me.GVDestMail.OptionsView.ShowGroupPanel = False
        '
        'GColVCHECK
        '
        Me.GColVCHECK.AppearanceHeader.Options.UseTextOptions = True
        Me.GColVCHECK.AppearanceHeader.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center
        Me.GColVCHECK.AppearanceHeader.TextOptions.VAlignment = DevExpress.Utils.VertAlignment.Center
        Me.GColVCHECK.AppearanceHeader.TextOptions.WordWrap = DevExpress.Utils.WordWrap.Wrap
        resources.ApplyResources(Me.GColVCHECK, "GColVCHECK")
        Me.GColVCHECK.ColumnEdit = Me.RepositoryItemCheckEditCHECK
        Me.GColVCHECK.FieldName = "VCHECK"
        Me.GColVCHECK.Name = "GColVCHECK"
        '
        'RepositoryItemCheckEditCHECK
        '
        resources.ApplyResources(Me.RepositoryItemCheckEditCHECK, "RepositoryItemCheckEditCHECK")
        Me.RepositoryItemCheckEditCHECK.Name = "RepositoryItemCheckEditCHECK"
        Me.RepositoryItemCheckEditCHECK.NullStyle = DevExpress.XtraEditors.Controls.StyleIndeterminate.Unchecked
        Me.RepositoryItemCheckEditCHECK.ValueChecked = 1
        Me.RepositoryItemCheckEditCHECK.ValueUnchecked = 0
        '
        'GColVMAIL
        '
        Me.GColVMAIL.AppearanceHeader.Options.UseTextOptions = True
        Me.GColVMAIL.AppearanceHeader.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center
        Me.GColVMAIL.AppearanceHeader.TextOptions.VAlignment = DevExpress.Utils.VertAlignment.Center
        Me.GColVMAIL.AppearanceHeader.TextOptions.WordWrap = DevExpress.Utils.WordWrap.Wrap
        resources.ApplyResources(Me.GColVMAIL, "GColVMAIL")
        Me.GColVMAIL.FieldName = "VMAIL"
        Me.GColVMAIL.Name = "GColVMAIL"
        Me.GColVMAIL.OptionsColumn.ReadOnly = True
        Me.GColVMAIL.OptionsFilter.AutoFilterCondition = DevExpress.XtraGrid.Columns.AutoFilterCondition.Contains
        '
        'GColVNOM
        '
        Me.GColVNOM.AppearanceHeader.Options.UseTextOptions = True
        Me.GColVNOM.AppearanceHeader.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center
        Me.GColVNOM.AppearanceHeader.TextOptions.VAlignment = DevExpress.Utils.VertAlignment.Center
        Me.GColVNOM.AppearanceHeader.TextOptions.WordWrap = DevExpress.Utils.WordWrap.Wrap
        resources.ApplyResources(Me.GColVNOM, "GColVNOM")
        Me.GColVNOM.FieldName = "VNOM"
        Me.GColVNOM.Name = "GColVNOM"
        Me.GColVNOM.OptionsColumn.AllowEdit = False
        Me.GColVNOM.OptionsColumn.ReadOnly = True
        Me.GColVNOM.OptionsFilter.AutoFilterCondition = DevExpress.XtraGrid.Columns.AutoFilterCondition.Contains
        '
        'GColVPRENOM
        '
        Me.GColVPRENOM.AppearanceHeader.Options.UseTextOptions = True
        Me.GColVPRENOM.AppearanceHeader.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center
        Me.GColVPRENOM.AppearanceHeader.TextOptions.VAlignment = DevExpress.Utils.VertAlignment.Center
        Me.GColVPRENOM.AppearanceHeader.TextOptions.WordWrap = DevExpress.Utils.WordWrap.Wrap
        resources.ApplyResources(Me.GColVPRENOM, "GColVPRENOM")
        Me.GColVPRENOM.FieldName = "VPRENOM"
        Me.GColVPRENOM.Name = "GColVPRENOM"
        Me.GColVPRENOM.OptionsColumn.AllowEdit = False
        Me.GColVPRENOM.OptionsColumn.ReadOnly = True
        Me.GColVPRENOM.OptionsFilter.AutoFilterCondition = DevExpress.XtraGrid.Columns.AutoFilterCondition.Contains
        '
        'GColVFONCTION
        '
        Me.GColVFONCTION.AppearanceHeader.Options.UseTextOptions = True
        Me.GColVFONCTION.AppearanceHeader.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center
        Me.GColVFONCTION.AppearanceHeader.TextOptions.VAlignment = DevExpress.Utils.VertAlignment.Center
        Me.GColVFONCTION.AppearanceHeader.TextOptions.WordWrap = DevExpress.Utils.WordWrap.Wrap
        resources.ApplyResources(Me.GColVFONCTION, "GColVFONCTION")
        Me.GColVFONCTION.FieldName = "VFONCTION"
        Me.GColVFONCTION.Name = "GColVFONCTION"
        Me.GColVFONCTION.OptionsColumn.AllowEdit = False
        Me.GColVFONCTION.OptionsColumn.ReadOnly = True
        Me.GColVFONCTION.OptionsFilter.AutoFilterCondition = DevExpress.XtraGrid.Columns.AutoFilterCondition.Contains
        '
        'GroupBox1
        '
        Me.GroupBox1.Controls.Add(Me.BtnValid)
        Me.GroupBox1.Controls.Add(Me.BtnFermer)
        resources.ApplyResources(Me.GroupBox1, "GroupBox1")
        Me.GroupBox1.Name = "GroupBox1"
        Me.GroupBox1.TabStop = False
        '
        'BtnValid
        '
        resources.ApplyResources(Me.BtnValid, "BtnValid")
        Me.BtnValid.Name = "BtnValid"
        Me.BtnValid.UseVisualStyleBackColor = True
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
        'framObs
        '
        Me.framObs.Controls.Add(Me.TxtObs)
        Me.framObs.Controls.Add(Me.lblLabels39)
        resources.ApplyResources(Me.framObs, "framObs")
        Me.framObs.FrameColor = System.Drawing.Color.Empty
        Me.framObs.HelpContextID = 0
        Me.framObs.Name = "framObs"
        Me.framObs.TabStop = False
        '
        'TxtObs
        '
        Me.TxtObs.BackColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(255, Byte), Integer), CType(CType(255, Byte), Integer))
        resources.ApplyResources(Me.TxtObs, "TxtObs")
        Me.TxtObs.ForeColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(0, Byte), Integer), CType(CType(0, Byte), Integer))
        Me.TxtObs.HelpContextID = 0
        Me.TxtObs.Name = "TxtObs"
        '
        'lblLabels39
        '
        Me.lblLabels39.BackColor = System.Drawing.Color.Wheat
        resources.ApplyResources(Me.lblLabels39, "lblLabels39")
        Me.lblLabels39.ForeColor = System.Drawing.SystemColors.ControlText
        Me.lblLabels39.HelpContextID = 0
        Me.lblLabels39.Name = "lblLabels39"
        '
        'frmChoixDestMailByAction
        '
        resources.ApplyResources(Me, "$this")
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.Wheat
        Me.Controls.Add(Me.framObs)
        Me.Controls.Add(Me.LblTitre)
        Me.Controls.Add(Me.GroupBox1)
        Me.Controls.Add(Me.GrpBoxPers)
        Me.Name = "frmChoixDestMailByAction"
        Me.GrpBoxPers.ResumeLayout(False)
        Me.GrpBoxPers.PerformLayout()
        CType(Me.GCDestMail, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.GVDestMail, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.RepositoryItemCheckEditCHECK, System.ComponentModel.ISupportInitialize).EndInit()
        Me.GroupBox1.ResumeLayout(False)
        Me.framObs.ResumeLayout(False)
        Me.framObs.PerformLayout()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents GrpBoxPers As System.Windows.Forms.GroupBox
    Friend WithEvents BtnDecoche As System.Windows.Forms.Button
    Friend WithEvents BtnCoche As System.Windows.Forms.Button
    Friend WithEvents GroupBox1 As System.Windows.Forms.GroupBox
    Friend WithEvents BtnFermer As System.Windows.Forms.Button
    Friend WithEvents BtnValid As System.Windows.Forms.Button
    Friend WithEvents LblTitre As System.Windows.Forms.Label
    Private WithEvents GCDestMail As DevExpress.XtraGrid.GridControl
    Private WithEvents GVDestMail As DevExpress.XtraGrid.Views.Grid.GridView
    Private WithEvents GColVCHECK As DevExpress.XtraGrid.Columns.GridColumn
    Private WithEvents RepositoryItemCheckEditCHECK As DevExpress.XtraEditors.Repository.RepositoryItemCheckEdit
    Private WithEvents GColVNOM As DevExpress.XtraGrid.Columns.GridColumn
    Private WithEvents GColVPRENOM As DevExpress.XtraGrid.Columns.GridColumn
    Private WithEvents GColVFONCTION As DevExpress.XtraGrid.Columns.GridColumn
    Private WithEvents GColVMAIL As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents TxtAddMail As TextBox
    Friend WithEvents LblAutresMail As Label
    Friend WithEvents txtAppro As TextBox
    Friend WithEvents Label1 As Label
    Friend WithEvents chkAppro As CheckBox
    Friend WithEvents Label3 As Label
    Friend WithEvents Label2 As Label
    Private WithEvents framObs As MozartUC.apiGroupBox
    Private WithEvents TxtObs As MozartUC.apiTextBox
    Private WithEvents lblLabels39 As MozartUC.apiLabel
End Class
