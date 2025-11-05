<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmSiteGestionDocInterne
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(frmSiteGestionDocInterne))
        Me.BtnModifier = New System.Windows.Forms.Button()
        Me.WBApercu = New System.Windows.Forms.WebBrowser()
        Me.BtnSupprLine = New System.Windows.Forms.Button()
        Me.GrpActions = New System.Windows.Forms.GroupBox()
        Me.BtnAddLine = New System.Windows.Forms.Button()
        Me.BtnQuit = New System.Windows.Forms.Button()
        Me.BtnSave = New System.Windows.Forms.Button()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.GColVQUIMODIF = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.GColDDATMODIF = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.GVSitDocInt = New DevExpress.XtraGrid.Views.Grid.GridView()
        Me.GCOLIDTMP = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.GColNSITDOCID = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.GColVLIBDOC = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.GColVFILENAME = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.GColDDATCREE = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.GColVQUICREE = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.GCSitDocInt = New DevExpress.XtraGrid.GridControl()
        Me.GrpApercu = New System.Windows.Forms.GroupBox()
        Me.BtnOpen = New System.Windows.Forms.Button()
        Me.GrpActions.SuspendLayout()
        CType(Me.GVSitDocInt, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.GCSitDocInt, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.GrpApercu.SuspendLayout()
        Me.SuspendLayout()
        '
        'BtnModifier
        '
        Me.BtnModifier.BackColor = System.Drawing.Color.LightGreen
        resources.ApplyResources(Me.BtnModifier, "BtnModifier")
        Me.BtnModifier.Name = "BtnModifier"
        Me.BtnModifier.UseVisualStyleBackColor = False
        '
        'WBApercu
        '
        resources.ApplyResources(Me.WBApercu, "WBApercu")
        Me.WBApercu.Name = "WBApercu"
        '
        'BtnSupprLine
        '
        Me.BtnSupprLine.BackColor = System.Drawing.Color.LightGreen
        resources.ApplyResources(Me.BtnSupprLine, "BtnSupprLine")
        Me.BtnSupprLine.Name = "BtnSupprLine"
        Me.BtnSupprLine.UseVisualStyleBackColor = False
        '
        'GrpActions
        '
        Me.GrpActions.Controls.Add(Me.BtnOpen)
        Me.GrpActions.Controls.Add(Me.BtnModifier)
        Me.GrpActions.Controls.Add(Me.BtnSupprLine)
        Me.GrpActions.Controls.Add(Me.BtnAddLine)
        Me.GrpActions.Controls.Add(Me.BtnQuit)
        Me.GrpActions.Controls.Add(Me.BtnSave)
        resources.ApplyResources(Me.GrpActions, "GrpActions")
        Me.GrpActions.Name = "GrpActions"
        Me.GrpActions.TabStop = False
        '
        'BtnAddLine
        '
        Me.BtnAddLine.BackColor = System.Drawing.Color.LightGreen
        resources.ApplyResources(Me.BtnAddLine, "BtnAddLine")
        Me.BtnAddLine.Name = "BtnAddLine"
        Me.BtnAddLine.UseVisualStyleBackColor = False
        '
        'BtnQuit
        '
        resources.ApplyResources(Me.BtnQuit, "BtnQuit")
        Me.BtnQuit.Name = "BtnQuit"
        Me.BtnQuit.UseVisualStyleBackColor = True
        '
        'BtnSave
        '
        resources.ApplyResources(Me.BtnSave, "BtnSave")
        Me.BtnSave.Name = "BtnSave"
        Me.BtnSave.UseVisualStyleBackColor = True
        '
        'Label1
        '
        resources.ApplyResources(Me.Label1, "Label1")
        Me.Label1.Name = "Label1"
        '
        'GColVQUIMODIF
        '
        resources.ApplyResources(Me.GColVQUIMODIF, "GColVQUIMODIF")
        Me.GColVQUIMODIF.FieldName = "VQUIMODIF"
        Me.GColVQUIMODIF.Name = "GColVQUIMODIF"
        '
        'GColDDATMODIF
        '
        resources.ApplyResources(Me.GColDDATMODIF, "GColDDATMODIF")
        Me.GColDDATMODIF.FieldName = "DDATMODIF"
        Me.GColDDATMODIF.Name = "GColDDATMODIF"
        '
        'GVSitDocInt
        '
        Me.GVSitDocInt.Appearance.ColumnFilterButton.BackColor = System.Drawing.Color.FromArgb(CType(CType(202, Byte), Integer), CType(CType(221, Byte), Integer), CType(CType(208, Byte), Integer))
        Me.GVSitDocInt.Appearance.ColumnFilterButton.BorderColor = System.Drawing.Color.FromArgb(CType(CType(202, Byte), Integer), CType(CType(221, Byte), Integer), CType(CType(208, Byte), Integer))
        Me.GVSitDocInt.Appearance.ColumnFilterButton.ForeColor = System.Drawing.Color.Black
        Me.GVSitDocInt.Appearance.ColumnFilterButton.Options.UseBackColor = True
        Me.GVSitDocInt.Appearance.ColumnFilterButton.Options.UseBorderColor = True
        Me.GVSitDocInt.Appearance.ColumnFilterButton.Options.UseForeColor = True
        Me.GVSitDocInt.Appearance.ColumnFilterButtonActive.BackColor = System.Drawing.Color.FromArgb(CType(CType(211, Byte), Integer), CType(CType(226, Byte), Integer), CType(CType(216, Byte), Integer))
        Me.GVSitDocInt.Appearance.ColumnFilterButtonActive.BorderColor = System.Drawing.Color.FromArgb(CType(CType(211, Byte), Integer), CType(CType(226, Byte), Integer), CType(CType(216, Byte), Integer))
        Me.GVSitDocInt.Appearance.ColumnFilterButtonActive.ForeColor = System.Drawing.Color.Black
        Me.GVSitDocInt.Appearance.ColumnFilterButtonActive.Options.UseBackColor = True
        Me.GVSitDocInt.Appearance.ColumnFilterButtonActive.Options.UseBorderColor = True
        Me.GVSitDocInt.Appearance.ColumnFilterButtonActive.Options.UseForeColor = True
        Me.GVSitDocInt.Appearance.Empty.BackColor = System.Drawing.Color.FromArgb(CType(CType(242, Byte), Integer), CType(CType(244, Byte), Integer), CType(CType(236, Byte), Integer))
        Me.GVSitDocInt.Appearance.Empty.BackColor2 = CType(resources.GetObject("GVSitDocInt.Appearance.Empty.BackColor2"), System.Drawing.Color)
        Me.GVSitDocInt.Appearance.Empty.Options.UseBackColor = True
        Me.GVSitDocInt.Appearance.EvenRow.BackColor = System.Drawing.Color.FromArgb(CType(CType(221, Byte), Integer), CType(CType(227, Byte), Integer), CType(CType(245, Byte), Integer))
        Me.GVSitDocInt.Appearance.EvenRow.BorderColor = System.Drawing.Color.FromArgb(CType(CType(221, Byte), Integer), CType(CType(227, Byte), Integer), CType(CType(245, Byte), Integer))
        Me.GVSitDocInt.Appearance.EvenRow.ForeColor = System.Drawing.Color.Black
        Me.GVSitDocInt.Appearance.EvenRow.Options.UseBackColor = True
        Me.GVSitDocInt.Appearance.EvenRow.Options.UseBorderColor = True
        Me.GVSitDocInt.Appearance.EvenRow.Options.UseForeColor = True
        Me.GVSitDocInt.Appearance.FilterCloseButton.BackColor = System.Drawing.Color.FromArgb(CType(CType(202, Byte), Integer), CType(CType(221, Byte), Integer), CType(CType(208, Byte), Integer))
        Me.GVSitDocInt.Appearance.FilterCloseButton.BorderColor = System.Drawing.Color.FromArgb(CType(CType(202, Byte), Integer), CType(CType(221, Byte), Integer), CType(CType(208, Byte), Integer))
        Me.GVSitDocInt.Appearance.FilterCloseButton.ForeColor = System.Drawing.Color.Black
        Me.GVSitDocInt.Appearance.FilterCloseButton.Options.UseBackColor = True
        Me.GVSitDocInt.Appearance.FilterCloseButton.Options.UseBorderColor = True
        Me.GVSitDocInt.Appearance.FilterCloseButton.Options.UseForeColor = True
        Me.GVSitDocInt.Appearance.FilterPanel.BackColor = System.Drawing.Color.FromArgb(CType(CType(242, Byte), Integer), CType(CType(244, Byte), Integer), CType(CType(236, Byte), Integer))
        Me.GVSitDocInt.Appearance.FilterPanel.BackColor2 = CType(resources.GetObject("GVSitDocInt.Appearance.FilterPanel.BackColor2"), System.Drawing.Color)
        Me.GVSitDocInt.Appearance.FilterPanel.ForeColor = System.Drawing.Color.Black
        Me.GVSitDocInt.Appearance.FilterPanel.Options.UseBackColor = True
        Me.GVSitDocInt.Appearance.FilterPanel.Options.UseForeColor = True
        Me.GVSitDocInt.Appearance.FixedLine.BackColor = System.Drawing.Color.FromArgb(CType(CType(117, Byte), Integer), CType(CType(136, Byte), Integer), CType(CType(122, Byte), Integer))
        Me.GVSitDocInt.Appearance.FixedLine.Options.UseBackColor = True
        Me.GVSitDocInt.Appearance.FocusedCell.BackColor = System.Drawing.Color.White
        Me.GVSitDocInt.Appearance.FocusedCell.ForeColor = System.Drawing.Color.Black
        Me.GVSitDocInt.Appearance.FocusedCell.Options.UseBackColor = True
        Me.GVSitDocInt.Appearance.FocusedCell.Options.UseForeColor = True
        Me.GVSitDocInt.Appearance.FocusedRow.BackColor = System.Drawing.Color.FromArgb(CType(CType(129, Byte), Integer), CType(CType(171, Byte), Integer), CType(CType(177, Byte), Integer))
        Me.GVSitDocInt.Appearance.FocusedRow.ForeColor = System.Drawing.Color.White
        Me.GVSitDocInt.Appearance.FocusedRow.Options.UseBackColor = True
        Me.GVSitDocInt.Appearance.FocusedRow.Options.UseForeColor = True
        Me.GVSitDocInt.Appearance.FooterPanel.BackColor = System.Drawing.Color.FromArgb(CType(CType(202, Byte), Integer), CType(CType(221, Byte), Integer), CType(CType(208, Byte), Integer))
        Me.GVSitDocInt.Appearance.FooterPanel.BorderColor = System.Drawing.Color.FromArgb(CType(CType(202, Byte), Integer), CType(CType(221, Byte), Integer), CType(CType(208, Byte), Integer))
        Me.GVSitDocInt.Appearance.FooterPanel.ForeColor = System.Drawing.Color.Black
        Me.GVSitDocInt.Appearance.FooterPanel.Options.UseBackColor = True
        Me.GVSitDocInt.Appearance.FooterPanel.Options.UseBorderColor = True
        Me.GVSitDocInt.Appearance.FooterPanel.Options.UseForeColor = True
        Me.GVSitDocInt.Appearance.GroupButton.BackColor = System.Drawing.Color.FromArgb(CType(CType(178, Byte), Integer), CType(CType(209, Byte), Integer), CType(CType(188, Byte), Integer))
        Me.GVSitDocInt.Appearance.GroupButton.BorderColor = System.Drawing.Color.FromArgb(CType(CType(178, Byte), Integer), CType(CType(209, Byte), Integer), CType(CType(188, Byte), Integer))
        Me.GVSitDocInt.Appearance.GroupButton.Options.UseBackColor = True
        Me.GVSitDocInt.Appearance.GroupButton.Options.UseBorderColor = True
        Me.GVSitDocInt.Appearance.GroupFooter.BackColor = System.Drawing.Color.FromArgb(CType(CType(215, Byte), Integer), CType(CType(234, Byte), Integer), CType(CType(221, Byte), Integer))
        Me.GVSitDocInt.Appearance.GroupFooter.BorderColor = System.Drawing.Color.FromArgb(CType(CType(215, Byte), Integer), CType(CType(234, Byte), Integer), CType(CType(221, Byte), Integer))
        Me.GVSitDocInt.Appearance.GroupFooter.ForeColor = System.Drawing.Color.Black
        Me.GVSitDocInt.Appearance.GroupFooter.Options.UseBackColor = True
        Me.GVSitDocInt.Appearance.GroupFooter.Options.UseBorderColor = True
        Me.GVSitDocInt.Appearance.GroupFooter.Options.UseForeColor = True
        Me.GVSitDocInt.Appearance.GroupPanel.BackColor = System.Drawing.Color.FromArgb(CType(CType(242, Byte), Integer), CType(CType(244, Byte), Integer), CType(CType(236, Byte), Integer))
        Me.GVSitDocInt.Appearance.GroupPanel.BackColor2 = CType(resources.GetObject("GVSitDocInt.Appearance.GroupPanel.BackColor2"), System.Drawing.Color)
        Me.GVSitDocInt.Appearance.GroupPanel.ForeColor = System.Drawing.Color.Black
        Me.GVSitDocInt.Appearance.GroupPanel.Options.UseBackColor = True
        Me.GVSitDocInt.Appearance.GroupPanel.Options.UseForeColor = True
        Me.GVSitDocInt.Appearance.GroupRow.BackColor = System.Drawing.Color.FromArgb(CType(CType(215, Byte), Integer), CType(CType(234, Byte), Integer), CType(CType(221, Byte), Integer))
        Me.GVSitDocInt.Appearance.GroupRow.BorderColor = System.Drawing.Color.FromArgb(CType(CType(215, Byte), Integer), CType(CType(234, Byte), Integer), CType(CType(221, Byte), Integer))
        Me.GVSitDocInt.Appearance.GroupRow.ForeColor = System.Drawing.Color.Black
        Me.GVSitDocInt.Appearance.GroupRow.Options.UseBackColor = True
        Me.GVSitDocInt.Appearance.GroupRow.Options.UseBorderColor = True
        Me.GVSitDocInt.Appearance.GroupRow.Options.UseForeColor = True
        Me.GVSitDocInt.Appearance.HeaderPanel.BackColor = System.Drawing.Color.FromArgb(CType(CType(211, Byte), Integer), CType(CType(226, Byte), Integer), CType(CType(216, Byte), Integer))
        Me.GVSitDocInt.Appearance.HeaderPanel.BorderColor = System.Drawing.Color.FromArgb(CType(CType(211, Byte), Integer), CType(CType(226, Byte), Integer), CType(CType(216, Byte), Integer))
        Me.GVSitDocInt.Appearance.HeaderPanel.ForeColor = System.Drawing.Color.Black
        Me.GVSitDocInt.Appearance.HeaderPanel.Options.UseBackColor = True
        Me.GVSitDocInt.Appearance.HeaderPanel.Options.UseBorderColor = True
        Me.GVSitDocInt.Appearance.HeaderPanel.Options.UseForeColor = True
        Me.GVSitDocInt.Appearance.HideSelectionRow.BackColor = System.Drawing.Color.FromArgb(CType(CType(186, Byte), Integer), CType(CType(211, Byte), Integer), CType(CType(215, Byte), Integer))
        Me.GVSitDocInt.Appearance.HideSelectionRow.ForeColor = System.Drawing.Color.FromArgb(CType(CType(104, Byte), Integer), CType(CType(130, Byte), Integer), CType(CType(134, Byte), Integer))
        Me.GVSitDocInt.Appearance.HideSelectionRow.Options.UseBackColor = True
        Me.GVSitDocInt.Appearance.HideSelectionRow.Options.UseForeColor = True
        Me.GVSitDocInt.Appearance.HorzLine.BackColor = System.Drawing.Color.FromArgb(CType(CType(172, Byte), Integer), CType(CType(197, Byte), Integer), CType(CType(180, Byte), Integer))
        Me.GVSitDocInt.Appearance.HorzLine.BorderColor = System.Drawing.Color.FromArgb(CType(CType(117, Byte), Integer), CType(CType(136, Byte), Integer), CType(CType(122, Byte), Integer))
        Me.GVSitDocInt.Appearance.HorzLine.Options.UseBackColor = True
        Me.GVSitDocInt.Appearance.HorzLine.Options.UseBorderColor = True
        Me.GVSitDocInt.Appearance.OddRow.BackColor = System.Drawing.Color.FromArgb(CType(CType(242, Byte), Integer), CType(CType(244, Byte), Integer), CType(CType(236, Byte), Integer))
        Me.GVSitDocInt.Appearance.OddRow.BorderColor = System.Drawing.Color.FromArgb(CType(CType(242, Byte), Integer), CType(CType(244, Byte), Integer), CType(CType(236, Byte), Integer))
        Me.GVSitDocInt.Appearance.OddRow.ForeColor = System.Drawing.Color.Black
        Me.GVSitDocInt.Appearance.OddRow.Options.UseBackColor = True
        Me.GVSitDocInt.Appearance.OddRow.Options.UseBorderColor = True
        Me.GVSitDocInt.Appearance.OddRow.Options.UseForeColor = True
        Me.GVSitDocInt.Appearance.Preview.BackColor = System.Drawing.Color.FromArgb(CType(CType(250, Byte), Integer), CType(CType(250, Byte), Integer), CType(CType(240, Byte), Integer))
        Me.GVSitDocInt.Appearance.Preview.Font = CType(resources.GetObject("GVSitDocInt.Appearance.Preview.Font"), System.Drawing.Font)
        Me.GVSitDocInt.Appearance.Preview.ForeColor = System.Drawing.Color.FromArgb(CType(CType(104, Byte), Integer), CType(CType(130, Byte), Integer), CType(CType(134, Byte), Integer))
        Me.GVSitDocInt.Appearance.Preview.Options.UseBackColor = True
        Me.GVSitDocInt.Appearance.Preview.Options.UseFont = True
        Me.GVSitDocInt.Appearance.Preview.Options.UseForeColor = True
        Me.GVSitDocInt.Appearance.Row.BackColor = System.Drawing.Color.FromArgb(CType(CType(242, Byte), Integer), CType(CType(244, Byte), Integer), CType(CType(236, Byte), Integer))
        Me.GVSitDocInt.Appearance.Row.ForeColor = System.Drawing.Color.Black
        Me.GVSitDocInt.Appearance.Row.Options.UseBackColor = True
        Me.GVSitDocInt.Appearance.Row.Options.UseForeColor = True
        Me.GVSitDocInt.Appearance.RowSeparator.BackColor = System.Drawing.Color.FromArgb(CType(CType(242, Byte), Integer), CType(CType(244, Byte), Integer), CType(CType(236, Byte), Integer))
        Me.GVSitDocInt.Appearance.RowSeparator.BackColor2 = CType(resources.GetObject("GVSitDocInt.Appearance.RowSeparator.BackColor2"), System.Drawing.Color)
        Me.GVSitDocInt.Appearance.RowSeparator.Options.UseBackColor = True
        Me.GVSitDocInt.Appearance.SelectedRow.BackColor = System.Drawing.Color.FromArgb(CType(CType(159, Byte), Integer), CType(CType(201, Byte), Integer), CType(CType(207, Byte), Integer))
        Me.GVSitDocInt.Appearance.SelectedRow.ForeColor = System.Drawing.Color.Black
        Me.GVSitDocInt.Appearance.SelectedRow.Options.UseBackColor = True
        Me.GVSitDocInt.Appearance.SelectedRow.Options.UseForeColor = True
        Me.GVSitDocInt.Appearance.TopNewRow.BackColor = System.Drawing.Color.White
        Me.GVSitDocInt.Appearance.TopNewRow.Options.UseBackColor = True
        Me.GVSitDocInt.Appearance.VertLine.BackColor = System.Drawing.Color.FromArgb(CType(CType(172, Byte), Integer), CType(CType(197, Byte), Integer), CType(CType(180, Byte), Integer))
        Me.GVSitDocInt.Appearance.VertLine.BorderColor = System.Drawing.Color.FromArgb(CType(CType(117, Byte), Integer), CType(CType(136, Byte), Integer), CType(CType(122, Byte), Integer))
        Me.GVSitDocInt.Appearance.VertLine.Options.UseBackColor = True
        Me.GVSitDocInt.Appearance.VertLine.Options.UseBorderColor = True
        Me.GVSitDocInt.Columns.AddRange(New DevExpress.XtraGrid.Columns.GridColumn() {Me.GCOLIDTMP, Me.GColNSITDOCID, Me.GColVLIBDOC, Me.GColVFILENAME, Me.GColDDATCREE, Me.GColVQUICREE, Me.GColDDATMODIF, Me.GColVQUIMODIF})
        Me.GVSitDocInt.GridControl = Me.GCSitDocInt
        Me.GVSitDocInt.Name = "GVSitDocInt"
        Me.GVSitDocInt.OptionsBehavior.Editable = False
        Me.GVSitDocInt.OptionsBehavior.ReadOnly = True
        Me.GVSitDocInt.OptionsNavigation.AutoFocusNewRow = True
        Me.GVSitDocInt.OptionsView.EnableAppearanceEvenRow = True
        Me.GVSitDocInt.OptionsView.EnableAppearanceOddRow = True
        Me.GVSitDocInt.OptionsView.ShowGroupPanel = False
        '
        'GCOLIDTMP
        '
        resources.ApplyResources(Me.GCOLIDTMP, "GCOLIDTMP")
        Me.GCOLIDTMP.FieldName = "IDTMP"
        Me.GCOLIDTMP.Name = "GCOLIDTMP"
        '
        'GColNSITDOCID
        '
        resources.ApplyResources(Me.GColNSITDOCID, "GColNSITDOCID")
        Me.GColNSITDOCID.FieldName = "NSITDOCID"
        Me.GColNSITDOCID.Name = "GColNSITDOCID"
        '
        'GColVLIBDOC
        '
        resources.ApplyResources(Me.GColVLIBDOC, "GColVLIBDOC")
        Me.GColVLIBDOC.FieldName = "VLIBDOC"
        Me.GColVLIBDOC.Name = "GColVLIBDOC"
        '
        'GColVFILENAME
        '
        resources.ApplyResources(Me.GColVFILENAME, "GColVFILENAME")
        Me.GColVFILENAME.FieldName = "VFILENAME"
        Me.GColVFILENAME.Name = "GColVFILENAME"
        '
        'GColDDATCREE
        '
        resources.ApplyResources(Me.GColDDATCREE, "GColDDATCREE")
        Me.GColDDATCREE.FieldName = "DDATCREE"
        Me.GColDDATCREE.Name = "GColDDATCREE"
        '
        'GColVQUICREE
        '
        resources.ApplyResources(Me.GColVQUICREE, "GColVQUICREE")
        Me.GColVQUICREE.FieldName = "VQUICREE"
        Me.GColVQUICREE.Name = "GColVQUICREE"
        '
        'GCSitDocInt
        '
        resources.ApplyResources(Me.GCSitDocInt, "GCSitDocInt")
        Me.GCSitDocInt.MainView = Me.GVSitDocInt
        Me.GCSitDocInt.Name = "GCSitDocInt"
        Me.GCSitDocInt.ViewCollection.AddRange(New DevExpress.XtraGrid.Views.Base.BaseView() {Me.GVSitDocInt})
        '
        'GrpApercu
        '
        Me.GrpApercu.Controls.Add(Me.WBApercu)
        resources.ApplyResources(Me.GrpApercu, "GrpApercu")
        Me.GrpApercu.Name = "GrpApercu"
        Me.GrpApercu.TabStop = False
        '
        'BtnOpen
        '
        resources.ApplyResources(Me.BtnOpen, "BtnOpen")
        Me.BtnOpen.Name = "BtnOpen"
        Me.BtnOpen.UseVisualStyleBackColor = True
        '
        'frmSiteGestionDocInterne
        '
        resources.ApplyResources(Me, "$this")
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.Wheat
        Me.Controls.Add(Me.GrpActions)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.GCSitDocInt)
        Me.Controls.Add(Me.GrpApercu)
        Me.Name = "frmSiteGestionDocInterne"
        Me.WindowState = System.Windows.Forms.FormWindowState.Maximized
        Me.GrpActions.ResumeLayout(False)
        CType(Me.GVSitDocInt, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.GCSitDocInt, System.ComponentModel.ISupportInitialize).EndInit()
        Me.GrpApercu.ResumeLayout(False)
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents BtnModifier As System.Windows.Forms.Button
    Friend WithEvents WBApercu As System.Windows.Forms.WebBrowser
    Friend WithEvents BtnSupprLine As System.Windows.Forms.Button
    Friend WithEvents GrpActions As System.Windows.Forms.GroupBox
    Friend WithEvents BtnAddLine As System.Windows.Forms.Button
    Friend WithEvents BtnQuit As System.Windows.Forms.Button
    Friend WithEvents BtnSave As System.Windows.Forms.Button
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents GrpApercu As System.Windows.Forms.GroupBox
    Private WithEvents GColVQUIMODIF As DevExpress.XtraGrid.Columns.GridColumn
    Private WithEvents GColDDATMODIF As DevExpress.XtraGrid.Columns.GridColumn
    Private WithEvents GVSitDocInt As DevExpress.XtraGrid.Views.Grid.GridView
    Private WithEvents GCOLIDTMP As DevExpress.XtraGrid.Columns.GridColumn
    Private WithEvents GColNSITDOCID As DevExpress.XtraGrid.Columns.GridColumn
    Private WithEvents GColVLIBDOC As DevExpress.XtraGrid.Columns.GridColumn
    Private WithEvents GColVFILENAME As DevExpress.XtraGrid.Columns.GridColumn
    Private WithEvents GColDDATCREE As DevExpress.XtraGrid.Columns.GridColumn
    Private WithEvents GColVQUICREE As DevExpress.XtraGrid.Columns.GridColumn
    Private WithEvents GCSitDocInt As DevExpress.XtraGrid.GridControl
    Friend WithEvents BtnOpen As Button
End Class
