<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmStatSyntContreMaitre
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(frmStatSyntContreMaitre))
        Me.LblPeriode = New System.Windows.Forms.Label()
        Me.LblTitre = New System.Windows.Forms.Label()
        Me.GrpActions = New System.Windows.Forms.GroupBox()
        Me.BtnFermer = New System.Windows.Forms.Button()
        Me.BtnPrint = New System.Windows.Forms.Button()
        Me.LblHrRef = New System.Windows.Forms.Label()
        Me.GVStatTot = New DevExpress.XtraGrid.Views.Grid.GridView()
        Me.GColTotVPERNOM = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.GColTotT = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.GColTotH = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.GColTotF = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.GColTotKM = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.GColTotD = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.GColTotFA = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.GCStatTot = New DevExpress.XtraGrid.GridControl()
        Me.AdvBandedGridView1 = New DevExpress.XtraGrid.Views.BandedGrid.AdvBandedGridView()
        Me.gridBand4 = New DevExpress.XtraGrid.Views.BandedGrid.GridBand()
        Me.BandedGridColumn1 = New DevExpress.XtraGrid.Views.BandedGrid.BandedGridColumn()
        Me.BandedGridColumn2 = New DevExpress.XtraGrid.Views.BandedGrid.BandedGridColumn()
        Me.GridBand1 = New DevExpress.XtraGrid.Views.BandedGrid.GridBand()
        Me.BandedGridColumn3 = New DevExpress.XtraGrid.Views.BandedGrid.BandedGridColumn()
        Me.BandedGridColumn8 = New DevExpress.XtraGrid.Views.BandedGrid.BandedGridColumn()
        Me.BandedGridColumn9 = New DevExpress.XtraGrid.Views.BandedGrid.BandedGridColumn()
        Me.gridBand2 = New DevExpress.XtraGrid.Views.BandedGrid.GridBand()
        Me.BandedGridColumn4 = New DevExpress.XtraGrid.Views.BandedGrid.BandedGridColumn()
        Me.BandedGridColumn11 = New DevExpress.XtraGrid.Views.BandedGrid.BandedGridColumn()
        Me.BandedGridColumn12 = New DevExpress.XtraGrid.Views.BandedGrid.BandedGridColumn()
        Me.gridBand3 = New DevExpress.XtraGrid.Views.BandedGrid.GridBand()
        Me.BandedGridColumn5 = New DevExpress.XtraGrid.Views.BandedGrid.BandedGridColumn()
        Me.BandedGridColumn13 = New DevExpress.XtraGrid.Views.BandedGrid.BandedGridColumn()
        Me.BandedGridColumn10 = New DevExpress.XtraGrid.Views.BandedGrid.BandedGridColumn()
        Me.gridBand5 = New DevExpress.XtraGrid.Views.BandedGrid.GridBand()
        Me.BandedGridColumn6 = New DevExpress.XtraGrid.Views.BandedGrid.BandedGridColumn()
        Me.BandedGridColumn15 = New DevExpress.XtraGrid.Views.BandedGrid.BandedGridColumn()
        Me.BandedGridColumn14 = New DevExpress.XtraGrid.Views.BandedGrid.BandedGridColumn()
        Me.gridBand6 = New DevExpress.XtraGrid.Views.BandedGrid.GridBand()
        Me.BandedGridColumn7 = New DevExpress.XtraGrid.Views.BandedGrid.BandedGridColumn()
        Me.BandedGridColumn16 = New DevExpress.XtraGrid.Views.BandedGrid.BandedGridColumn()
        Me.BandedGridColumn17 = New DevExpress.XtraGrid.Views.BandedGrid.BandedGridColumn()
        Me.GrpActions.SuspendLayout()
        CType(Me.GVStatTot, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.GCStatTot, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.AdvBandedGridView1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'LblPeriode
        '
        resources.ApplyResources(Me.LblPeriode, "LblPeriode")
        Me.LblPeriode.Name = "LblPeriode"
        '
        'LblTitre
        '
        resources.ApplyResources(Me.LblTitre, "LblTitre")
        Me.LblTitre.Name = "LblTitre"
        '
        'GrpActions
        '
        Me.GrpActions.Controls.Add(Me.BtnFermer)
        Me.GrpActions.Controls.Add(Me.BtnPrint)
        resources.ApplyResources(Me.GrpActions, "GrpActions")
        Me.GrpActions.Name = "GrpActions"
        Me.GrpActions.TabStop = False
        '
        'BtnFermer
        '
        resources.ApplyResources(Me.BtnFermer, "BtnFermer")
        Me.BtnFermer.Name = "BtnFermer"
        Me.BtnFermer.UseVisualStyleBackColor = True
        '
        'BtnPrint
        '
        resources.ApplyResources(Me.BtnPrint, "BtnPrint")
        Me.BtnPrint.Name = "BtnPrint"
        Me.BtnPrint.UseVisualStyleBackColor = True
        '
        'LblHrRef
        '
        resources.ApplyResources(Me.LblHrRef, "LblHrRef")
        Me.LblHrRef.Name = "LblHrRef"
        '
        'GVStatTot
        '
        Me.GVStatTot.Appearance.ColumnFilterButton.BackColor = System.Drawing.Color.FromArgb(CType(CType(202, Byte), Integer), CType(CType(221, Byte), Integer), CType(CType(208, Byte), Integer))
        Me.GVStatTot.Appearance.ColumnFilterButton.BorderColor = System.Drawing.Color.FromArgb(CType(CType(202, Byte), Integer), CType(CType(221, Byte), Integer), CType(CType(208, Byte), Integer))
        Me.GVStatTot.Appearance.ColumnFilterButton.ForeColor = System.Drawing.Color.Black
        Me.GVStatTot.Appearance.ColumnFilterButton.Options.UseBackColor = True
        Me.GVStatTot.Appearance.ColumnFilterButton.Options.UseBorderColor = True
        Me.GVStatTot.Appearance.ColumnFilterButton.Options.UseForeColor = True
        Me.GVStatTot.Appearance.ColumnFilterButtonActive.BackColor = System.Drawing.Color.FromArgb(CType(CType(211, Byte), Integer), CType(CType(226, Byte), Integer), CType(CType(216, Byte), Integer))
        Me.GVStatTot.Appearance.ColumnFilterButtonActive.BorderColor = System.Drawing.Color.FromArgb(CType(CType(211, Byte), Integer), CType(CType(226, Byte), Integer), CType(CType(216, Byte), Integer))
        Me.GVStatTot.Appearance.ColumnFilterButtonActive.ForeColor = System.Drawing.Color.Black
        Me.GVStatTot.Appearance.ColumnFilterButtonActive.Options.UseBackColor = True
        Me.GVStatTot.Appearance.ColumnFilterButtonActive.Options.UseBorderColor = True
        Me.GVStatTot.Appearance.ColumnFilterButtonActive.Options.UseForeColor = True
        Me.GVStatTot.Appearance.Empty.BackColor = System.Drawing.Color.FromArgb(CType(CType(242, Byte), Integer), CType(CType(244, Byte), Integer), CType(CType(236, Byte), Integer))
        Me.GVStatTot.Appearance.Empty.BackColor2 = CType(resources.GetObject("GVStatTot.Appearance.Empty.BackColor2"), System.Drawing.Color)
        Me.GVStatTot.Appearance.Empty.Options.UseBackColor = True
        Me.GVStatTot.Appearance.EvenRow.BackColor = System.Drawing.Color.FromArgb(CType(CType(221, Byte), Integer), CType(CType(227, Byte), Integer), CType(CType(245, Byte), Integer))
        Me.GVStatTot.Appearance.EvenRow.BorderColor = System.Drawing.Color.FromArgb(CType(CType(221, Byte), Integer), CType(CType(227, Byte), Integer), CType(CType(245, Byte), Integer))
        Me.GVStatTot.Appearance.EvenRow.ForeColor = System.Drawing.Color.Black
        Me.GVStatTot.Appearance.EvenRow.Options.UseBackColor = True
        Me.GVStatTot.Appearance.EvenRow.Options.UseBorderColor = True
        Me.GVStatTot.Appearance.EvenRow.Options.UseForeColor = True
        Me.GVStatTot.Appearance.FilterCloseButton.BackColor = System.Drawing.Color.FromArgb(CType(CType(202, Byte), Integer), CType(CType(221, Byte), Integer), CType(CType(208, Byte), Integer))
        Me.GVStatTot.Appearance.FilterCloseButton.BorderColor = System.Drawing.Color.FromArgb(CType(CType(202, Byte), Integer), CType(CType(221, Byte), Integer), CType(CType(208, Byte), Integer))
        Me.GVStatTot.Appearance.FilterCloseButton.ForeColor = System.Drawing.Color.Black
        Me.GVStatTot.Appearance.FilterCloseButton.Options.UseBackColor = True
        Me.GVStatTot.Appearance.FilterCloseButton.Options.UseBorderColor = True
        Me.GVStatTot.Appearance.FilterCloseButton.Options.UseForeColor = True
        Me.GVStatTot.Appearance.FilterPanel.BackColor = System.Drawing.Color.FromArgb(CType(CType(242, Byte), Integer), CType(CType(244, Byte), Integer), CType(CType(236, Byte), Integer))
        Me.GVStatTot.Appearance.FilterPanel.BackColor2 = CType(resources.GetObject("GVStatTot.Appearance.FilterPanel.BackColor2"), System.Drawing.Color)
        Me.GVStatTot.Appearance.FilterPanel.ForeColor = System.Drawing.Color.Black
        Me.GVStatTot.Appearance.FilterPanel.Options.UseBackColor = True
        Me.GVStatTot.Appearance.FilterPanel.Options.UseForeColor = True
        Me.GVStatTot.Appearance.FixedLine.BackColor = System.Drawing.Color.FromArgb(CType(CType(117, Byte), Integer), CType(CType(136, Byte), Integer), CType(CType(122, Byte), Integer))
        Me.GVStatTot.Appearance.FixedLine.Options.UseBackColor = True
        Me.GVStatTot.Appearance.FocusedCell.BackColor = System.Drawing.Color.White
        Me.GVStatTot.Appearance.FocusedCell.ForeColor = System.Drawing.Color.Black
        Me.GVStatTot.Appearance.FocusedCell.Options.UseBackColor = True
        Me.GVStatTot.Appearance.FocusedCell.Options.UseForeColor = True
        Me.GVStatTot.Appearance.FocusedRow.BackColor = System.Drawing.Color.FromArgb(CType(CType(129, Byte), Integer), CType(CType(171, Byte), Integer), CType(CType(177, Byte), Integer))
        Me.GVStatTot.Appearance.FocusedRow.ForeColor = System.Drawing.Color.White
        Me.GVStatTot.Appearance.FocusedRow.Options.UseBackColor = True
        Me.GVStatTot.Appearance.FocusedRow.Options.UseForeColor = True
        Me.GVStatTot.Appearance.FooterPanel.BackColor = System.Drawing.Color.FromArgb(CType(CType(202, Byte), Integer), CType(CType(221, Byte), Integer), CType(CType(208, Byte), Integer))
        Me.GVStatTot.Appearance.FooterPanel.BorderColor = System.Drawing.Color.FromArgb(CType(CType(202, Byte), Integer), CType(CType(221, Byte), Integer), CType(CType(208, Byte), Integer))
        Me.GVStatTot.Appearance.FooterPanel.ForeColor = System.Drawing.Color.Black
        Me.GVStatTot.Appearance.FooterPanel.Options.UseBackColor = True
        Me.GVStatTot.Appearance.FooterPanel.Options.UseBorderColor = True
        Me.GVStatTot.Appearance.FooterPanel.Options.UseForeColor = True
        Me.GVStatTot.Appearance.GroupButton.BackColor = System.Drawing.Color.FromArgb(CType(CType(178, Byte), Integer), CType(CType(209, Byte), Integer), CType(CType(188, Byte), Integer))
        Me.GVStatTot.Appearance.GroupButton.BorderColor = System.Drawing.Color.FromArgb(CType(CType(178, Byte), Integer), CType(CType(209, Byte), Integer), CType(CType(188, Byte), Integer))
        Me.GVStatTot.Appearance.GroupButton.Options.UseBackColor = True
        Me.GVStatTot.Appearance.GroupButton.Options.UseBorderColor = True
        Me.GVStatTot.Appearance.GroupFooter.BackColor = System.Drawing.Color.FromArgb(CType(CType(215, Byte), Integer), CType(CType(234, Byte), Integer), CType(CType(221, Byte), Integer))
        Me.GVStatTot.Appearance.GroupFooter.BorderColor = System.Drawing.Color.FromArgb(CType(CType(215, Byte), Integer), CType(CType(234, Byte), Integer), CType(CType(221, Byte), Integer))
        Me.GVStatTot.Appearance.GroupFooter.ForeColor = System.Drawing.Color.Black
        Me.GVStatTot.Appearance.GroupFooter.Options.UseBackColor = True
        Me.GVStatTot.Appearance.GroupFooter.Options.UseBorderColor = True
        Me.GVStatTot.Appearance.GroupFooter.Options.UseForeColor = True
        Me.GVStatTot.Appearance.GroupPanel.BackColor = System.Drawing.Color.FromArgb(CType(CType(242, Byte), Integer), CType(CType(244, Byte), Integer), CType(CType(236, Byte), Integer))
        Me.GVStatTot.Appearance.GroupPanel.BackColor2 = CType(resources.GetObject("GVStatTot.Appearance.GroupPanel.BackColor2"), System.Drawing.Color)
        Me.GVStatTot.Appearance.GroupPanel.ForeColor = System.Drawing.Color.Black
        Me.GVStatTot.Appearance.GroupPanel.Options.UseBackColor = True
        Me.GVStatTot.Appearance.GroupPanel.Options.UseForeColor = True
        Me.GVStatTot.Appearance.GroupRow.BackColor = System.Drawing.Color.FromArgb(CType(CType(215, Byte), Integer), CType(CType(234, Byte), Integer), CType(CType(221, Byte), Integer))
        Me.GVStatTot.Appearance.GroupRow.BorderColor = System.Drawing.Color.FromArgb(CType(CType(215, Byte), Integer), CType(CType(234, Byte), Integer), CType(CType(221, Byte), Integer))
        Me.GVStatTot.Appearance.GroupRow.ForeColor = System.Drawing.Color.Black
        Me.GVStatTot.Appearance.GroupRow.Options.UseBackColor = True
        Me.GVStatTot.Appearance.GroupRow.Options.UseBorderColor = True
        Me.GVStatTot.Appearance.GroupRow.Options.UseForeColor = True
        Me.GVStatTot.Appearance.HeaderPanel.BackColor = System.Drawing.Color.FromArgb(CType(CType(211, Byte), Integer), CType(CType(226, Byte), Integer), CType(CType(216, Byte), Integer))
        Me.GVStatTot.Appearance.HeaderPanel.BorderColor = System.Drawing.Color.FromArgb(CType(CType(211, Byte), Integer), CType(CType(226, Byte), Integer), CType(CType(216, Byte), Integer))
        Me.GVStatTot.Appearance.HeaderPanel.ForeColor = System.Drawing.Color.Black
        Me.GVStatTot.Appearance.HeaderPanel.Options.UseBackColor = True
        Me.GVStatTot.Appearance.HeaderPanel.Options.UseBorderColor = True
        Me.GVStatTot.Appearance.HeaderPanel.Options.UseForeColor = True
        Me.GVStatTot.Appearance.HideSelectionRow.BackColor = System.Drawing.Color.FromArgb(CType(CType(186, Byte), Integer), CType(CType(211, Byte), Integer), CType(CType(215, Byte), Integer))
        Me.GVStatTot.Appearance.HideSelectionRow.ForeColor = System.Drawing.Color.FromArgb(CType(CType(104, Byte), Integer), CType(CType(130, Byte), Integer), CType(CType(134, Byte), Integer))
        Me.GVStatTot.Appearance.HideSelectionRow.Options.UseBackColor = True
        Me.GVStatTot.Appearance.HideSelectionRow.Options.UseForeColor = True
        Me.GVStatTot.Appearance.HorzLine.BackColor = System.Drawing.Color.FromArgb(CType(CType(172, Byte), Integer), CType(CType(197, Byte), Integer), CType(CType(180, Byte), Integer))
        Me.GVStatTot.Appearance.HorzLine.BorderColor = System.Drawing.Color.FromArgb(CType(CType(117, Byte), Integer), CType(CType(136, Byte), Integer), CType(CType(122, Byte), Integer))
        Me.GVStatTot.Appearance.HorzLine.Options.UseBackColor = True
        Me.GVStatTot.Appearance.HorzLine.Options.UseBorderColor = True
        Me.GVStatTot.Appearance.OddRow.BackColor = System.Drawing.Color.FromArgb(CType(CType(242, Byte), Integer), CType(CType(244, Byte), Integer), CType(CType(236, Byte), Integer))
        Me.GVStatTot.Appearance.OddRow.BorderColor = System.Drawing.Color.FromArgb(CType(CType(242, Byte), Integer), CType(CType(244, Byte), Integer), CType(CType(236, Byte), Integer))
        Me.GVStatTot.Appearance.OddRow.ForeColor = System.Drawing.Color.Black
        Me.GVStatTot.Appearance.OddRow.Options.UseBackColor = True
        Me.GVStatTot.Appearance.OddRow.Options.UseBorderColor = True
        Me.GVStatTot.Appearance.OddRow.Options.UseForeColor = True
        Me.GVStatTot.Appearance.Preview.BackColor = System.Drawing.Color.FromArgb(CType(CType(250, Byte), Integer), CType(CType(250, Byte), Integer), CType(CType(240, Byte), Integer))
        Me.GVStatTot.Appearance.Preview.Font = CType(resources.GetObject("GVStatTot.Appearance.Preview.Font"), System.Drawing.Font)
        Me.GVStatTot.Appearance.Preview.ForeColor = System.Drawing.Color.FromArgb(CType(CType(104, Byte), Integer), CType(CType(130, Byte), Integer), CType(CType(134, Byte), Integer))
        Me.GVStatTot.Appearance.Preview.Options.UseBackColor = True
        Me.GVStatTot.Appearance.Preview.Options.UseFont = True
        Me.GVStatTot.Appearance.Preview.Options.UseForeColor = True
        Me.GVStatTot.Appearance.Row.BackColor = System.Drawing.Color.FromArgb(CType(CType(242, Byte), Integer), CType(CType(244, Byte), Integer), CType(CType(236, Byte), Integer))
        Me.GVStatTot.Appearance.Row.ForeColor = System.Drawing.Color.Black
        Me.GVStatTot.Appearance.Row.Options.UseBackColor = True
        Me.GVStatTot.Appearance.Row.Options.UseForeColor = True
        Me.GVStatTot.Appearance.RowSeparator.BackColor = System.Drawing.Color.FromArgb(CType(CType(242, Byte), Integer), CType(CType(244, Byte), Integer), CType(CType(236, Byte), Integer))
        Me.GVStatTot.Appearance.RowSeparator.BackColor2 = CType(resources.GetObject("GVStatTot.Appearance.RowSeparator.BackColor2"), System.Drawing.Color)
        Me.GVStatTot.Appearance.RowSeparator.Options.UseBackColor = True
        Me.GVStatTot.Appearance.SelectedRow.BackColor = System.Drawing.Color.FromArgb(CType(CType(159, Byte), Integer), CType(CType(201, Byte), Integer), CType(CType(207, Byte), Integer))
        Me.GVStatTot.Appearance.SelectedRow.ForeColor = System.Drawing.Color.Black
        Me.GVStatTot.Appearance.SelectedRow.Options.UseBackColor = True
        Me.GVStatTot.Appearance.SelectedRow.Options.UseForeColor = True
        Me.GVStatTot.Appearance.TopNewRow.BackColor = System.Drawing.Color.White
        Me.GVStatTot.Appearance.TopNewRow.Options.UseBackColor = True
        Me.GVStatTot.Appearance.VertLine.BackColor = System.Drawing.Color.FromArgb(CType(CType(172, Byte), Integer), CType(CType(197, Byte), Integer), CType(CType(180, Byte), Integer))
        Me.GVStatTot.Appearance.VertLine.BorderColor = System.Drawing.Color.FromArgb(CType(CType(117, Byte), Integer), CType(CType(136, Byte), Integer), CType(CType(122, Byte), Integer))
        Me.GVStatTot.Appearance.VertLine.Options.UseBackColor = True
        Me.GVStatTot.Appearance.VertLine.Options.UseBorderColor = True
        Me.GVStatTot.Columns.AddRange(New DevExpress.XtraGrid.Columns.GridColumn() {Me.GColTotVPERNOM, Me.GColTotT, Me.GColTotH, Me.GColTotF, Me.GColTotKM, Me.GColTotD, Me.GColTotFA})
        Me.GVStatTot.GridControl = Me.GCStatTot
        Me.GVStatTot.Name = "GVStatTot"
        Me.GVStatTot.OptionsBehavior.Editable = False
        Me.GVStatTot.OptionsBehavior.ReadOnly = True
        Me.GVStatTot.OptionsView.EnableAppearanceEvenRow = True
        Me.GVStatTot.OptionsView.EnableAppearanceOddRow = True
        Me.GVStatTot.OptionsView.ShowFooter = True
        Me.GVStatTot.OptionsView.ShowGroupPanel = False
        '
        'GColTotVPERNOM
        '
        Me.GColTotVPERNOM.AppearanceHeader.Font = CType(resources.GetObject("GColTotVPERNOM.AppearanceHeader.Font"), System.Drawing.Font)
        Me.GColTotVPERNOM.AppearanceHeader.Options.UseFont = True
        Me.GColTotVPERNOM.AppearanceHeader.Options.UseTextOptions = True
        Me.GColTotVPERNOM.AppearanceHeader.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center
        Me.GColTotVPERNOM.AppearanceHeader.TextOptions.VAlignment = DevExpress.Utils.VertAlignment.Center
        resources.ApplyResources(Me.GColTotVPERNOM, "GColTotVPERNOM")
        Me.GColTotVPERNOM.FieldName = "VPERNOM"
        Me.GColTotVPERNOM.Name = "GColTotVPERNOM"
        Me.GColTotVPERNOM.OptionsColumn.AllowEdit = False
        Me.GColTotVPERNOM.OptionsColumn.ReadOnly = True
        '
        'GColTotT
        '
        Me.GColTotT.AppearanceHeader.Font = CType(resources.GetObject("GColTotT.AppearanceHeader.Font"), System.Drawing.Font)
        Me.GColTotT.AppearanceHeader.Options.UseFont = True
        Me.GColTotT.AppearanceHeader.Options.UseTextOptions = True
        Me.GColTotT.AppearanceHeader.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center
        Me.GColTotT.AppearanceHeader.TextOptions.VAlignment = DevExpress.Utils.VertAlignment.Center
        resources.ApplyResources(Me.GColTotT, "GColTotT")
        Me.GColTotT.DisplayFormat.FormatType = DevExpress.Utils.FormatType.Numeric
        Me.GColTotT.FieldName = "T"
        Me.GColTotT.Name = "GColTotT"
        Me.GColTotT.OptionsColumn.AllowEdit = False
        Me.GColTotT.OptionsColumn.ReadOnly = True
        '
        'GColTotH
        '
        Me.GColTotH.AppearanceHeader.Font = CType(resources.GetObject("GColTotH.AppearanceHeader.Font"), System.Drawing.Font)
        Me.GColTotH.AppearanceHeader.Options.UseFont = True
        Me.GColTotH.AppearanceHeader.Options.UseTextOptions = True
        Me.GColTotH.AppearanceHeader.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center
        Me.GColTotH.AppearanceHeader.TextOptions.VAlignment = DevExpress.Utils.VertAlignment.Center
        resources.ApplyResources(Me.GColTotH, "GColTotH")
        Me.GColTotH.FieldName = "H"
        Me.GColTotH.Name = "GColTotH"
        Me.GColTotH.OptionsColumn.AllowEdit = False
        Me.GColTotH.OptionsColumn.ReadOnly = True
        '
        'GColTotF
        '
        Me.GColTotF.AppearanceHeader.Font = CType(resources.GetObject("GColTotF.AppearanceHeader.Font"), System.Drawing.Font)
        Me.GColTotF.AppearanceHeader.Options.UseFont = True
        Me.GColTotF.AppearanceHeader.Options.UseTextOptions = True
        Me.GColTotF.AppearanceHeader.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center
        Me.GColTotF.AppearanceHeader.TextOptions.VAlignment = DevExpress.Utils.VertAlignment.Center
        resources.ApplyResources(Me.GColTotF, "GColTotF")
        Me.GColTotF.DisplayFormat.FormatString = "{0:c0}"
        Me.GColTotF.DisplayFormat.FormatType = DevExpress.Utils.FormatType.Numeric
        Me.GColTotF.FieldName = "F"
        Me.GColTotF.Name = "GColTotF"
        Me.GColTotF.OptionsColumn.AllowEdit = False
        Me.GColTotF.OptionsColumn.ReadOnly = True
        '
        'GColTotKM
        '
        Me.GColTotKM.AppearanceHeader.Font = CType(resources.GetObject("GColTotKM.AppearanceHeader.Font"), System.Drawing.Font)
        Me.GColTotKM.AppearanceHeader.Options.UseFont = True
        Me.GColTotKM.AppearanceHeader.Options.UseTextOptions = True
        Me.GColTotKM.AppearanceHeader.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center
        Me.GColTotKM.AppearanceHeader.TextOptions.VAlignment = DevExpress.Utils.VertAlignment.Center
        resources.ApplyResources(Me.GColTotKM, "GColTotKM")
        Me.GColTotKM.DisplayFormat.FormatString = "{0:n0}"
        Me.GColTotKM.DisplayFormat.FormatType = DevExpress.Utils.FormatType.Numeric
        Me.GColTotKM.FieldName = "KM"
        Me.GColTotKM.Name = "GColTotKM"
        Me.GColTotKM.OptionsColumn.AllowEdit = False
        Me.GColTotKM.OptionsColumn.ReadOnly = True
        '
        'GColTotD
        '
        Me.GColTotD.AppearanceHeader.Font = CType(resources.GetObject("GColTotD.AppearanceHeader.Font"), System.Drawing.Font)
        Me.GColTotD.AppearanceHeader.Options.UseFont = True
        Me.GColTotD.AppearanceHeader.Options.UseTextOptions = True
        Me.GColTotD.AppearanceHeader.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center
        Me.GColTotD.AppearanceHeader.TextOptions.VAlignment = DevExpress.Utils.VertAlignment.Center
        resources.ApplyResources(Me.GColTotD, "GColTotD")
        Me.GColTotD.FieldName = "D"
        Me.GColTotD.Name = "GColTotD"
        Me.GColTotD.OptionsColumn.AllowEdit = False
        Me.GColTotD.OptionsColumn.ReadOnly = True
        '
        'GColTotFA
        '
        Me.GColTotFA.AppearanceHeader.Font = CType(resources.GetObject("GColTotFA.AppearanceHeader.Font"), System.Drawing.Font)
        Me.GColTotFA.AppearanceHeader.Options.UseFont = True
        Me.GColTotFA.AppearanceHeader.Options.UseTextOptions = True
        Me.GColTotFA.AppearanceHeader.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center
        Me.GColTotFA.AppearanceHeader.TextOptions.VAlignment = DevExpress.Utils.VertAlignment.Center
        resources.ApplyResources(Me.GColTotFA, "GColTotFA")
        Me.GColTotFA.DisplayFormat.FormatString = "{0:c0}"
        Me.GColTotFA.DisplayFormat.FormatType = DevExpress.Utils.FormatType.Numeric
        Me.GColTotFA.FieldName = "FA"
        Me.GColTotFA.Name = "GColTotFA"
        Me.GColTotFA.OptionsColumn.AllowEdit = False
        Me.GColTotFA.OptionsColumn.ReadOnly = True
        '
        'GCStatTot
        '
        resources.ApplyResources(Me.GCStatTot, "GCStatTot")
        Me.GCStatTot.MainView = Me.AdvBandedGridView1
        Me.GCStatTot.Name = "GCStatTot"
        Me.GCStatTot.ViewCollection.AddRange(New DevExpress.XtraGrid.Views.Base.BaseView() {Me.AdvBandedGridView1, Me.GVStatTot})
        '
        'AdvBandedGridView1
        '
        Me.AdvBandedGridView1.Appearance.BandPanel.Options.UseBackColor = True
        Me.AdvBandedGridView1.Appearance.BandPanelBackground.Options.UseBackColor = True
        Me.AdvBandedGridView1.Appearance.FixedLine.Options.UseBackColor = True
        Me.AdvBandedGridView1.Appearance.FocusedRow.BackColor = System.Drawing.Color.White
        Me.AdvBandedGridView1.Appearance.FocusedRow.Options.UseBackColor = True
        Me.AdvBandedGridView1.BandPanelRowHeight = 50
        Me.AdvBandedGridView1.Bands.AddRange(New DevExpress.XtraGrid.Views.BandedGrid.GridBand() {Me.gridBand4, Me.GridBand1, Me.gridBand2, Me.gridBand3, Me.gridBand5, Me.gridBand6})
        Me.AdvBandedGridView1.ColumnPanelRowHeight = 40
        Me.AdvBandedGridView1.Columns.AddRange(New DevExpress.XtraGrid.Views.BandedGrid.BandedGridColumn() {Me.BandedGridColumn1, Me.BandedGridColumn2, Me.BandedGridColumn3, Me.BandedGridColumn8, Me.BandedGridColumn9, Me.BandedGridColumn4, Me.BandedGridColumn11, Me.BandedGridColumn12, Me.BandedGridColumn5, Me.BandedGridColumn13, Me.BandedGridColumn10, Me.BandedGridColumn6, Me.BandedGridColumn15, Me.BandedGridColumn14, Me.BandedGridColumn7, Me.BandedGridColumn16, Me.BandedGridColumn17})
        Me.AdvBandedGridView1.GridControl = Me.GCStatTot
        Me.AdvBandedGridView1.Name = "AdvBandedGridView1"
        Me.AdvBandedGridView1.OptionsBehavior.Editable = False
        Me.AdvBandedGridView1.OptionsBehavior.ReadOnly = True
        Me.AdvBandedGridView1.OptionsSelection.EnableAppearanceFocusedCell = False
        Me.AdvBandedGridView1.OptionsSelection.EnableAppearanceFocusedRow = False
        Me.AdvBandedGridView1.OptionsView.ColumnAutoWidth = True
        Me.AdvBandedGridView1.OptionsView.ShowFooter = True
        Me.AdvBandedGridView1.OptionsView.ShowGroupPanel = False
        '
        'gridBand4
        '
        Me.gridBand4.AppearanceHeader.Font = CType(resources.GetObject("gridBand4.AppearanceHeader.Font"), System.Drawing.Font)
        Me.gridBand4.AppearanceHeader.Options.UseFont = True
        Me.gridBand4.Columns.Add(Me.BandedGridColumn1)
        Me.gridBand4.Columns.Add(Me.BandedGridColumn2)
        resources.ApplyResources(Me.gridBand4, "gridBand4")
        Me.gridBand4.VisibleIndex = 0
        '
        'BandedGridColumn1
        '
        Me.BandedGridColumn1.AppearanceCell.BackColor = System.Drawing.SystemColors.ButtonFace
        Me.BandedGridColumn1.AppearanceCell.Font = CType(resources.GetObject("BandedGridColumn1.AppearanceCell.Font"), System.Drawing.Font)
        Me.BandedGridColumn1.AppearanceCell.Options.UseBackColor = True
        Me.BandedGridColumn1.AppearanceCell.Options.UseFont = True
        Me.BandedGridColumn1.AppearanceHeader.Font = CType(resources.GetObject("BandedGridColumn1.AppearanceHeader.Font"), System.Drawing.Font)
        Me.BandedGridColumn1.AppearanceHeader.ForeColor = System.Drawing.Color.Black
        Me.BandedGridColumn1.AppearanceHeader.Options.UseFont = True
        Me.BandedGridColumn1.AppearanceHeader.Options.UseForeColor = True
        Me.BandedGridColumn1.AppearanceHeader.Options.UseTextOptions = True
        Me.BandedGridColumn1.AppearanceHeader.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center
        Me.BandedGridColumn1.AppearanceHeader.TextOptions.VAlignment = DevExpress.Utils.VertAlignment.Center
        resources.ApplyResources(Me.BandedGridColumn1, "BandedGridColumn1")
        Me.BandedGridColumn1.FieldName = "VPERNOM"
        Me.BandedGridColumn1.MinWidth = 150
        Me.BandedGridColumn1.Name = "BandedGridColumn1"
        Me.BandedGridColumn1.OptionsColumn.AllowEdit = False
        Me.BandedGridColumn1.OptionsColumn.ReadOnly = True
        '
        'BandedGridColumn2
        '
        Me.BandedGridColumn2.AppearanceCell.BackColor = System.Drawing.SystemColors.ButtonFace
        Me.BandedGridColumn2.AppearanceCell.Font = CType(resources.GetObject("BandedGridColumn2.AppearanceCell.Font"), System.Drawing.Font)
        Me.BandedGridColumn2.AppearanceCell.Options.UseBackColor = True
        Me.BandedGridColumn2.AppearanceCell.Options.UseFont = True
        Me.BandedGridColumn2.AppearanceCell.Options.UseTextOptions = True
        Me.BandedGridColumn2.AppearanceCell.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center
        Me.BandedGridColumn2.AppearanceHeader.Font = CType(resources.GetObject("BandedGridColumn2.AppearanceHeader.Font"), System.Drawing.Font)
        Me.BandedGridColumn2.AppearanceHeader.ForeColor = System.Drawing.Color.Black
        Me.BandedGridColumn2.AppearanceHeader.Options.UseFont = True
        Me.BandedGridColumn2.AppearanceHeader.Options.UseForeColor = True
        Me.BandedGridColumn2.AppearanceHeader.Options.UseTextOptions = True
        Me.BandedGridColumn2.AppearanceHeader.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center
        Me.BandedGridColumn2.AppearanceHeader.TextOptions.VAlignment = DevExpress.Utils.VertAlignment.Center
        resources.ApplyResources(Me.BandedGridColumn2, "BandedGridColumn2")
        Me.BandedGridColumn2.DisplayFormat.FormatType = DevExpress.Utils.FormatType.Numeric
        Me.BandedGridColumn2.FieldName = "T"
        Me.BandedGridColumn2.MinWidth = 80
        Me.BandedGridColumn2.Name = "BandedGridColumn2"
        Me.BandedGridColumn2.OptionsColumn.AllowEdit = False
        Me.BandedGridColumn2.OptionsColumn.ReadOnly = True
        '
        'GridBand1
        '
        Me.GridBand1.AppearanceHeader.BackColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(255, Byte), Integer), CType(CType(192, Byte), Integer))
        Me.GridBand1.AppearanceHeader.BackColor2 = CType(resources.GetObject("GridBand1.AppearanceHeader.BackColor2"), System.Drawing.Color)
        Me.GridBand1.AppearanceHeader.Font = CType(resources.GetObject("GridBand1.AppearanceHeader.Font"), System.Drawing.Font)
        Me.GridBand1.AppearanceHeader.Options.UseBackColor = True
        Me.GridBand1.AppearanceHeader.Options.UseFont = True
        Me.GridBand1.AppearanceHeader.Options.UseTextOptions = True
        Me.GridBand1.AppearanceHeader.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center
        resources.ApplyResources(Me.GridBand1, "GridBand1")
        Me.GridBand1.Columns.Add(Me.BandedGridColumn3)
        Me.GridBand1.Columns.Add(Me.BandedGridColumn8)
        Me.GridBand1.Columns.Add(Me.BandedGridColumn9)
        Me.GridBand1.ImageOptions.Alignment = CType(resources.GetObject("GridBand1.ImageOptions.Alignment"), System.Drawing.StringAlignment)
        Me.GridBand1.VisibleIndex = 1
        '
        'BandedGridColumn3
        '
        Me.BandedGridColumn3.AppearanceCell.BackColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(255, Byte), Integer), CType(CType(192, Byte), Integer))
        Me.BandedGridColumn3.AppearanceCell.Font = CType(resources.GetObject("BandedGridColumn3.AppearanceCell.Font"), System.Drawing.Font)
        Me.BandedGridColumn3.AppearanceCell.Options.UseBackColor = True
        Me.BandedGridColumn3.AppearanceCell.Options.UseFont = True
        Me.BandedGridColumn3.AppearanceCell.Options.UseTextOptions = True
        Me.BandedGridColumn3.AppearanceCell.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center
        Me.BandedGridColumn3.AppearanceHeader.BackColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(255, Byte), Integer), CType(CType(192, Byte), Integer))
        Me.BandedGridColumn3.AppearanceHeader.Font = CType(resources.GetObject("BandedGridColumn3.AppearanceHeader.Font"), System.Drawing.Font)
        Me.BandedGridColumn3.AppearanceHeader.Options.UseBackColor = True
        Me.BandedGridColumn3.AppearanceHeader.Options.UseFont = True
        Me.BandedGridColumn3.AppearanceHeader.Options.UseTextOptions = True
        Me.BandedGridColumn3.AppearanceHeader.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center
        Me.BandedGridColumn3.AppearanceHeader.TextOptions.VAlignment = DevExpress.Utils.VertAlignment.Center
        resources.ApplyResources(Me.BandedGridColumn3, "BandedGridColumn3")
        Me.BandedGridColumn3.FieldName = "H"
        Me.BandedGridColumn3.Name = "BandedGridColumn3"
        Me.BandedGridColumn3.OptionsColumn.AllowEdit = False
        Me.BandedGridColumn3.OptionsColumn.ReadOnly = True
        '
        'BandedGridColumn8
        '
        Me.BandedGridColumn8.AppearanceCell.BackColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(255, Byte), Integer), CType(CType(192, Byte), Integer))
        Me.BandedGridColumn8.AppearanceCell.Font = CType(resources.GetObject("BandedGridColumn8.AppearanceCell.Font"), System.Drawing.Font)
        Me.BandedGridColumn8.AppearanceCell.Options.UseBackColor = True
        Me.BandedGridColumn8.AppearanceCell.Options.UseFont = True
        Me.BandedGridColumn8.AppearanceCell.Options.UseTextOptions = True
        Me.BandedGridColumn8.AppearanceCell.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center
        Me.BandedGridColumn8.AppearanceHeader.BackColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(255, Byte), Integer), CType(CType(192, Byte), Integer))
        Me.BandedGridColumn8.AppearanceHeader.Font = CType(resources.GetObject("BandedGridColumn8.AppearanceHeader.Font"), System.Drawing.Font)
        Me.BandedGridColumn8.AppearanceHeader.Options.UseBackColor = True
        Me.BandedGridColumn8.AppearanceHeader.Options.UseFont = True
        Me.BandedGridColumn8.AppearanceHeader.Options.UseTextOptions = True
        Me.BandedGridColumn8.AppearanceHeader.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center
        resources.ApplyResources(Me.BandedGridColumn8, "BandedGridColumn8")
        Me.BandedGridColumn8.FieldName = "HCLASS"
        Me.BandedGridColumn8.Name = "BandedGridColumn8"
        '
        'BandedGridColumn9
        '
        Me.BandedGridColumn9.AppearanceCell.BackColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(255, Byte), Integer), CType(CType(192, Byte), Integer))
        Me.BandedGridColumn9.AppearanceCell.Font = CType(resources.GetObject("BandedGridColumn9.AppearanceCell.Font"), System.Drawing.Font)
        Me.BandedGridColumn9.AppearanceCell.Options.UseBackColor = True
        Me.BandedGridColumn9.AppearanceCell.Options.UseFont = True
        Me.BandedGridColumn9.AppearanceCell.Options.UseTextOptions = True
        Me.BandedGridColumn9.AppearanceCell.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center
        Me.BandedGridColumn9.AppearanceHeader.BackColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(255, Byte), Integer), CType(CType(192, Byte), Integer))
        Me.BandedGridColumn9.AppearanceHeader.Font = CType(resources.GetObject("BandedGridColumn9.AppearanceHeader.Font"), System.Drawing.Font)
        Me.BandedGridColumn9.AppearanceHeader.Options.UseBackColor = True
        Me.BandedGridColumn9.AppearanceHeader.Options.UseFont = True
        Me.BandedGridColumn9.AppearanceHeader.Options.UseTextOptions = True
        Me.BandedGridColumn9.AppearanceHeader.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center
        resources.ApplyResources(Me.BandedGridColumn9, "BandedGridColumn9")
        Me.BandedGridColumn9.DisplayFormat.FormatString = " {0} %"
        Me.BandedGridColumn9.DisplayFormat.FormatType = DevExpress.Utils.FormatType.Custom
        Me.BandedGridColumn9.FieldName = "HP"
        Me.BandedGridColumn9.Name = "BandedGridColumn9"
        '
        'gridBand2
        '
        Me.gridBand2.AppearanceHeader.BackColor = System.Drawing.Color.FromArgb(CType(CType(192, Byte), Integer), CType(CType(255, Byte), Integer), CType(CType(192, Byte), Integer))
        Me.gridBand2.AppearanceHeader.Font = CType(resources.GetObject("gridBand2.AppearanceHeader.Font"), System.Drawing.Font)
        Me.gridBand2.AppearanceHeader.Options.UseBackColor = True
        Me.gridBand2.AppearanceHeader.Options.UseFont = True
        Me.gridBand2.AppearanceHeader.Options.UseTextOptions = True
        Me.gridBand2.AppearanceHeader.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center
        resources.ApplyResources(Me.gridBand2, "gridBand2")
        Me.gridBand2.Columns.Add(Me.BandedGridColumn4)
        Me.gridBand2.Columns.Add(Me.BandedGridColumn11)
        Me.gridBand2.Columns.Add(Me.BandedGridColumn12)
        Me.gridBand2.VisibleIndex = 2
        '
        'BandedGridColumn4
        '
        Me.BandedGridColumn4.AppearanceCell.BackColor = System.Drawing.Color.FromArgb(CType(CType(192, Byte), Integer), CType(CType(255, Byte), Integer), CType(CType(192, Byte), Integer))
        Me.BandedGridColumn4.AppearanceCell.Font = CType(resources.GetObject("BandedGridColumn4.AppearanceCell.Font"), System.Drawing.Font)
        Me.BandedGridColumn4.AppearanceCell.Options.UseBackColor = True
        Me.BandedGridColumn4.AppearanceCell.Options.UseFont = True
        Me.BandedGridColumn4.AppearanceCell.Options.UseTextOptions = True
        Me.BandedGridColumn4.AppearanceCell.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center
        Me.BandedGridColumn4.AppearanceHeader.Font = CType(resources.GetObject("BandedGridColumn4.AppearanceHeader.Font"), System.Drawing.Font)
        Me.BandedGridColumn4.AppearanceHeader.ForeColor = System.Drawing.Color.Black
        Me.BandedGridColumn4.AppearanceHeader.Options.UseFont = True
        Me.BandedGridColumn4.AppearanceHeader.Options.UseForeColor = True
        Me.BandedGridColumn4.AppearanceHeader.Options.UseTextOptions = True
        Me.BandedGridColumn4.AppearanceHeader.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center
        Me.BandedGridColumn4.AppearanceHeader.TextOptions.VAlignment = DevExpress.Utils.VertAlignment.Center
        resources.ApplyResources(Me.BandedGridColumn4, "BandedGridColumn4")
        Me.BandedGridColumn4.DisplayFormat.FormatString = "{0:c0}"
        Me.BandedGridColumn4.DisplayFormat.FormatType = DevExpress.Utils.FormatType.Numeric
        Me.BandedGridColumn4.FieldName = "F"
        Me.BandedGridColumn4.Name = "BandedGridColumn4"
        Me.BandedGridColumn4.OptionsColumn.AllowEdit = False
        Me.BandedGridColumn4.OptionsColumn.ReadOnly = True
        '
        'BandedGridColumn11
        '
        Me.BandedGridColumn11.AppearanceCell.BackColor = System.Drawing.Color.FromArgb(CType(CType(192, Byte), Integer), CType(CType(255, Byte), Integer), CType(CType(192, Byte), Integer))
        Me.BandedGridColumn11.AppearanceCell.Font = CType(resources.GetObject("BandedGridColumn11.AppearanceCell.Font"), System.Drawing.Font)
        Me.BandedGridColumn11.AppearanceCell.Options.UseBackColor = True
        Me.BandedGridColumn11.AppearanceCell.Options.UseFont = True
        Me.BandedGridColumn11.AppearanceCell.Options.UseTextOptions = True
        Me.BandedGridColumn11.AppearanceCell.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center
        Me.BandedGridColumn11.AppearanceHeader.Font = CType(resources.GetObject("BandedGridColumn11.AppearanceHeader.Font"), System.Drawing.Font)
        Me.BandedGridColumn11.AppearanceHeader.ForeColor = System.Drawing.Color.Black
        Me.BandedGridColumn11.AppearanceHeader.Options.UseFont = True
        Me.BandedGridColumn11.AppearanceHeader.Options.UseForeColor = True
        Me.BandedGridColumn11.AppearanceHeader.Options.UseTextOptions = True
        Me.BandedGridColumn11.AppearanceHeader.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center
        resources.ApplyResources(Me.BandedGridColumn11, "BandedGridColumn11")
        Me.BandedGridColumn11.FieldName = "FCLASS"
        Me.BandedGridColumn11.Name = "BandedGridColumn11"
        '
        'BandedGridColumn12
        '
        Me.BandedGridColumn12.AppearanceCell.BackColor = System.Drawing.Color.FromArgb(CType(CType(192, Byte), Integer), CType(CType(255, Byte), Integer), CType(CType(192, Byte), Integer))
        Me.BandedGridColumn12.AppearanceCell.Font = CType(resources.GetObject("BandedGridColumn12.AppearanceCell.Font"), System.Drawing.Font)
        Me.BandedGridColumn12.AppearanceCell.Options.UseBackColor = True
        Me.BandedGridColumn12.AppearanceCell.Options.UseFont = True
        Me.BandedGridColumn12.AppearanceCell.Options.UseTextOptions = True
        Me.BandedGridColumn12.AppearanceCell.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center
        Me.BandedGridColumn12.AppearanceHeader.Font = CType(resources.GetObject("BandedGridColumn12.AppearanceHeader.Font"), System.Drawing.Font)
        Me.BandedGridColumn12.AppearanceHeader.ForeColor = System.Drawing.Color.Black
        Me.BandedGridColumn12.AppearanceHeader.Options.UseFont = True
        Me.BandedGridColumn12.AppearanceHeader.Options.UseForeColor = True
        Me.BandedGridColumn12.AppearanceHeader.Options.UseTextOptions = True
        Me.BandedGridColumn12.AppearanceHeader.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center
        resources.ApplyResources(Me.BandedGridColumn12, "BandedGridColumn12")
        Me.BandedGridColumn12.DisplayFormat.FormatString = " {0} %"
        Me.BandedGridColumn12.DisplayFormat.FormatType = DevExpress.Utils.FormatType.Custom
        Me.BandedGridColumn12.FieldName = "FP"
        Me.BandedGridColumn12.Name = "BandedGridColumn12"
        '
        'gridBand3
        '
        Me.gridBand3.AppearanceHeader.BackColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(224, Byte), Integer), CType(CType(192, Byte), Integer))
        Me.gridBand3.AppearanceHeader.Font = CType(resources.GetObject("gridBand3.AppearanceHeader.Font"), System.Drawing.Font)
        Me.gridBand3.AppearanceHeader.Options.UseBackColor = True
        Me.gridBand3.AppearanceHeader.Options.UseFont = True
        Me.gridBand3.AppearanceHeader.Options.UseTextOptions = True
        Me.gridBand3.AppearanceHeader.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center
        resources.ApplyResources(Me.gridBand3, "gridBand3")
        Me.gridBand3.Columns.Add(Me.BandedGridColumn5)
        Me.gridBand3.Columns.Add(Me.BandedGridColumn13)
        Me.gridBand3.Columns.Add(Me.BandedGridColumn10)
        Me.gridBand3.VisibleIndex = 3
        '
        'BandedGridColumn5
        '
        Me.BandedGridColumn5.AppearanceCell.BackColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(224, Byte), Integer), CType(CType(192, Byte), Integer))
        Me.BandedGridColumn5.AppearanceCell.Font = CType(resources.GetObject("BandedGridColumn5.AppearanceCell.Font"), System.Drawing.Font)
        Me.BandedGridColumn5.AppearanceCell.Options.UseBackColor = True
        Me.BandedGridColumn5.AppearanceCell.Options.UseFont = True
        Me.BandedGridColumn5.AppearanceCell.Options.UseTextOptions = True
        Me.BandedGridColumn5.AppearanceCell.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center
        Me.BandedGridColumn5.AppearanceHeader.Font = CType(resources.GetObject("BandedGridColumn5.AppearanceHeader.Font"), System.Drawing.Font)
        Me.BandedGridColumn5.AppearanceHeader.ForeColor = System.Drawing.Color.Black
        Me.BandedGridColumn5.AppearanceHeader.Options.UseFont = True
        Me.BandedGridColumn5.AppearanceHeader.Options.UseForeColor = True
        Me.BandedGridColumn5.AppearanceHeader.Options.UseTextOptions = True
        Me.BandedGridColumn5.AppearanceHeader.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center
        Me.BandedGridColumn5.AppearanceHeader.TextOptions.VAlignment = DevExpress.Utils.VertAlignment.Center
        resources.ApplyResources(Me.BandedGridColumn5, "BandedGridColumn5")
        Me.BandedGridColumn5.DisplayFormat.FormatString = "{0:n0}"
        Me.BandedGridColumn5.DisplayFormat.FormatType = DevExpress.Utils.FormatType.Numeric
        Me.BandedGridColumn5.FieldName = "KM"
        Me.BandedGridColumn5.Name = "BandedGridColumn5"
        Me.BandedGridColumn5.OptionsColumn.AllowEdit = False
        Me.BandedGridColumn5.OptionsColumn.ReadOnly = True
        '
        'BandedGridColumn13
        '
        Me.BandedGridColumn13.AppearanceCell.BackColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(224, Byte), Integer), CType(CType(192, Byte), Integer))
        Me.BandedGridColumn13.AppearanceCell.Font = CType(resources.GetObject("BandedGridColumn13.AppearanceCell.Font"), System.Drawing.Font)
        Me.BandedGridColumn13.AppearanceCell.Options.UseBackColor = True
        Me.BandedGridColumn13.AppearanceCell.Options.UseFont = True
        Me.BandedGridColumn13.AppearanceCell.Options.UseTextOptions = True
        Me.BandedGridColumn13.AppearanceCell.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center
        Me.BandedGridColumn13.AppearanceHeader.Font = CType(resources.GetObject("BandedGridColumn13.AppearanceHeader.Font"), System.Drawing.Font)
        Me.BandedGridColumn13.AppearanceHeader.ForeColor = System.Drawing.Color.Black
        Me.BandedGridColumn13.AppearanceHeader.Options.UseFont = True
        Me.BandedGridColumn13.AppearanceHeader.Options.UseForeColor = True
        Me.BandedGridColumn13.AppearanceHeader.Options.UseTextOptions = True
        Me.BandedGridColumn13.AppearanceHeader.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center
        resources.ApplyResources(Me.BandedGridColumn13, "BandedGridColumn13")
        Me.BandedGridColumn13.FieldName = "KCLASS"
        Me.BandedGridColumn13.Name = "BandedGridColumn13"
        '
        'BandedGridColumn10
        '
        Me.BandedGridColumn10.AppearanceCell.BackColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(224, Byte), Integer), CType(CType(192, Byte), Integer))
        Me.BandedGridColumn10.AppearanceCell.Font = CType(resources.GetObject("BandedGridColumn10.AppearanceCell.Font"), System.Drawing.Font)
        Me.BandedGridColumn10.AppearanceCell.Options.UseBackColor = True
        Me.BandedGridColumn10.AppearanceCell.Options.UseFont = True
        Me.BandedGridColumn10.AppearanceCell.Options.UseTextOptions = True
        Me.BandedGridColumn10.AppearanceCell.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center
        Me.BandedGridColumn10.AppearanceHeader.Font = CType(resources.GetObject("BandedGridColumn10.AppearanceHeader.Font"), System.Drawing.Font)
        Me.BandedGridColumn10.AppearanceHeader.ForeColor = System.Drawing.Color.Black
        Me.BandedGridColumn10.AppearanceHeader.Options.UseFont = True
        Me.BandedGridColumn10.AppearanceHeader.Options.UseForeColor = True
        Me.BandedGridColumn10.AppearanceHeader.Options.UseTextOptions = True
        Me.BandedGridColumn10.AppearanceHeader.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center
        resources.ApplyResources(Me.BandedGridColumn10, "BandedGridColumn10")
        Me.BandedGridColumn10.DisplayFormat.FormatString = " {0} %"
        Me.BandedGridColumn10.DisplayFormat.FormatType = DevExpress.Utils.FormatType.Custom
        Me.BandedGridColumn10.FieldName = "KP"
        Me.BandedGridColumn10.Name = "BandedGridColumn10"
        '
        'gridBand5
        '
        Me.gridBand5.AppearanceHeader.BackColor = System.Drawing.Color.FromArgb(CType(CType(192, Byte), Integer), CType(CType(192, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.gridBand5.AppearanceHeader.Font = CType(resources.GetObject("gridBand5.AppearanceHeader.Font"), System.Drawing.Font)
        Me.gridBand5.AppearanceHeader.Options.UseBackColor = True
        Me.gridBand5.AppearanceHeader.Options.UseFont = True
        Me.gridBand5.AppearanceHeader.Options.UseTextOptions = True
        Me.gridBand5.AppearanceHeader.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center
        resources.ApplyResources(Me.gridBand5, "gridBand5")
        Me.gridBand5.Columns.Add(Me.BandedGridColumn6)
        Me.gridBand5.Columns.Add(Me.BandedGridColumn15)
        Me.gridBand5.Columns.Add(Me.BandedGridColumn14)
        Me.gridBand5.VisibleIndex = 4
        '
        'BandedGridColumn6
        '
        Me.BandedGridColumn6.AppearanceCell.BackColor = System.Drawing.Color.FromArgb(CType(CType(192, Byte), Integer), CType(CType(192, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.BandedGridColumn6.AppearanceCell.Font = CType(resources.GetObject("BandedGridColumn6.AppearanceCell.Font"), System.Drawing.Font)
        Me.BandedGridColumn6.AppearanceCell.Options.UseBackColor = True
        Me.BandedGridColumn6.AppearanceCell.Options.UseFont = True
        Me.BandedGridColumn6.AppearanceCell.Options.UseTextOptions = True
        Me.BandedGridColumn6.AppearanceCell.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center
        Me.BandedGridColumn6.AppearanceHeader.Font = CType(resources.GetObject("BandedGridColumn6.AppearanceHeader.Font"), System.Drawing.Font)
        Me.BandedGridColumn6.AppearanceHeader.ForeColor = System.Drawing.Color.Black
        Me.BandedGridColumn6.AppearanceHeader.Options.UseFont = True
        Me.BandedGridColumn6.AppearanceHeader.Options.UseForeColor = True
        Me.BandedGridColumn6.AppearanceHeader.Options.UseTextOptions = True
        Me.BandedGridColumn6.AppearanceHeader.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center
        Me.BandedGridColumn6.AppearanceHeader.TextOptions.VAlignment = DevExpress.Utils.VertAlignment.Center
        resources.ApplyResources(Me.BandedGridColumn6, "BandedGridColumn6")
        Me.BandedGridColumn6.FieldName = "D"
        Me.BandedGridColumn6.Name = "BandedGridColumn6"
        Me.BandedGridColumn6.OptionsColumn.AllowEdit = False
        Me.BandedGridColumn6.OptionsColumn.ReadOnly = True
        '
        'BandedGridColumn15
        '
        Me.BandedGridColumn15.AppearanceCell.BackColor = System.Drawing.Color.FromArgb(CType(CType(192, Byte), Integer), CType(CType(192, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.BandedGridColumn15.AppearanceCell.Font = CType(resources.GetObject("BandedGridColumn15.AppearanceCell.Font"), System.Drawing.Font)
        Me.BandedGridColumn15.AppearanceCell.Options.UseBackColor = True
        Me.BandedGridColumn15.AppearanceCell.Options.UseFont = True
        Me.BandedGridColumn15.AppearanceCell.Options.UseTextOptions = True
        Me.BandedGridColumn15.AppearanceCell.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center
        Me.BandedGridColumn15.AppearanceHeader.Font = CType(resources.GetObject("BandedGridColumn15.AppearanceHeader.Font"), System.Drawing.Font)
        Me.BandedGridColumn15.AppearanceHeader.ForeColor = System.Drawing.Color.Black
        Me.BandedGridColumn15.AppearanceHeader.Options.UseFont = True
        Me.BandedGridColumn15.AppearanceHeader.Options.UseForeColor = True
        Me.BandedGridColumn15.AppearanceHeader.Options.UseTextOptions = True
        Me.BandedGridColumn15.AppearanceHeader.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center
        resources.ApplyResources(Me.BandedGridColumn15, "BandedGridColumn15")
        Me.BandedGridColumn15.FieldName = "DCLASS"
        Me.BandedGridColumn15.Name = "BandedGridColumn15"
        '
        'BandedGridColumn14
        '
        Me.BandedGridColumn14.AppearanceCell.BackColor = System.Drawing.Color.FromArgb(CType(CType(192, Byte), Integer), CType(CType(192, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.BandedGridColumn14.AppearanceCell.Font = CType(resources.GetObject("BandedGridColumn14.AppearanceCell.Font"), System.Drawing.Font)
        Me.BandedGridColumn14.AppearanceCell.Options.UseBackColor = True
        Me.BandedGridColumn14.AppearanceCell.Options.UseFont = True
        Me.BandedGridColumn14.AppearanceCell.Options.UseTextOptions = True
        Me.BandedGridColumn14.AppearanceCell.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center
        Me.BandedGridColumn14.AppearanceHeader.Font = CType(resources.GetObject("BandedGridColumn14.AppearanceHeader.Font"), System.Drawing.Font)
        Me.BandedGridColumn14.AppearanceHeader.ForeColor = System.Drawing.Color.Black
        Me.BandedGridColumn14.AppearanceHeader.Options.UseFont = True
        Me.BandedGridColumn14.AppearanceHeader.Options.UseForeColor = True
        Me.BandedGridColumn14.AppearanceHeader.Options.UseTextOptions = True
        Me.BandedGridColumn14.AppearanceHeader.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center
        resources.ApplyResources(Me.BandedGridColumn14, "BandedGridColumn14")
        Me.BandedGridColumn14.DisplayFormat.FormatString = " {0} %"
        Me.BandedGridColumn14.DisplayFormat.FormatType = DevExpress.Utils.FormatType.Custom
        Me.BandedGridColumn14.FieldName = "DP"
        Me.BandedGridColumn14.Name = "BandedGridColumn14"
        '
        'gridBand6
        '
        Me.gridBand6.AppearanceHeader.BackColor = System.Drawing.Color.FromArgb(CType(CType(192, Byte), Integer), CType(CType(255, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.gridBand6.AppearanceHeader.Font = CType(resources.GetObject("gridBand6.AppearanceHeader.Font"), System.Drawing.Font)
        Me.gridBand6.AppearanceHeader.Options.UseBackColor = True
        Me.gridBand6.AppearanceHeader.Options.UseFont = True
        Me.gridBand6.AppearanceHeader.Options.UseTextOptions = True
        Me.gridBand6.AppearanceHeader.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center
        resources.ApplyResources(Me.gridBand6, "gridBand6")
        Me.gridBand6.Columns.Add(Me.BandedGridColumn7)
        Me.gridBand6.Columns.Add(Me.BandedGridColumn16)
        Me.gridBand6.Columns.Add(Me.BandedGridColumn17)
        Me.gridBand6.VisibleIndex = 5
        '
        'BandedGridColumn7
        '
        Me.BandedGridColumn7.AppearanceCell.BackColor = System.Drawing.Color.FromArgb(CType(CType(192, Byte), Integer), CType(CType(255, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.BandedGridColumn7.AppearanceCell.Font = CType(resources.GetObject("BandedGridColumn7.AppearanceCell.Font"), System.Drawing.Font)
        Me.BandedGridColumn7.AppearanceCell.Options.UseBackColor = True
        Me.BandedGridColumn7.AppearanceCell.Options.UseFont = True
        Me.BandedGridColumn7.AppearanceCell.Options.UseTextOptions = True
        Me.BandedGridColumn7.AppearanceCell.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center
        Me.BandedGridColumn7.AppearanceHeader.Font = CType(resources.GetObject("BandedGridColumn7.AppearanceHeader.Font"), System.Drawing.Font)
        Me.BandedGridColumn7.AppearanceHeader.ForeColor = System.Drawing.Color.Black
        Me.BandedGridColumn7.AppearanceHeader.Options.UseFont = True
        Me.BandedGridColumn7.AppearanceHeader.Options.UseForeColor = True
        Me.BandedGridColumn7.AppearanceHeader.Options.UseTextOptions = True
        Me.BandedGridColumn7.AppearanceHeader.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center
        Me.BandedGridColumn7.AppearanceHeader.TextOptions.VAlignment = DevExpress.Utils.VertAlignment.Center
        resources.ApplyResources(Me.BandedGridColumn7, "BandedGridColumn7")
        Me.BandedGridColumn7.DisplayFormat.FormatString = "{0:c0}"
        Me.BandedGridColumn7.DisplayFormat.FormatType = DevExpress.Utils.FormatType.Numeric
        Me.BandedGridColumn7.FieldName = "FA"
        Me.BandedGridColumn7.Name = "BandedGridColumn7"
        Me.BandedGridColumn7.OptionsColumn.AllowEdit = False
        Me.BandedGridColumn7.OptionsColumn.ReadOnly = True
        '
        'BandedGridColumn16
        '
        Me.BandedGridColumn16.AppearanceCell.BackColor = System.Drawing.Color.FromArgb(CType(CType(192, Byte), Integer), CType(CType(255, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.BandedGridColumn16.AppearanceCell.Font = CType(resources.GetObject("BandedGridColumn16.AppearanceCell.Font"), System.Drawing.Font)
        Me.BandedGridColumn16.AppearanceCell.Options.UseBackColor = True
        Me.BandedGridColumn16.AppearanceCell.Options.UseFont = True
        Me.BandedGridColumn16.AppearanceCell.Options.UseTextOptions = True
        Me.BandedGridColumn16.AppearanceCell.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center
        Me.BandedGridColumn16.AppearanceHeader.Font = CType(resources.GetObject("BandedGridColumn16.AppearanceHeader.Font"), System.Drawing.Font)
        Me.BandedGridColumn16.AppearanceHeader.ForeColor = System.Drawing.Color.Black
        Me.BandedGridColumn16.AppearanceHeader.Options.UseFont = True
        Me.BandedGridColumn16.AppearanceHeader.Options.UseForeColor = True
        Me.BandedGridColumn16.AppearanceHeader.Options.UseTextOptions = True
        Me.BandedGridColumn16.AppearanceHeader.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center
        resources.ApplyResources(Me.BandedGridColumn16, "BandedGridColumn16")
        Me.BandedGridColumn16.FieldName = "ACLASS"
        Me.BandedGridColumn16.Name = "BandedGridColumn16"
        '
        'BandedGridColumn17
        '
        Me.BandedGridColumn17.AppearanceCell.BackColor = System.Drawing.Color.FromArgb(CType(CType(192, Byte), Integer), CType(CType(255, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.BandedGridColumn17.AppearanceCell.Font = CType(resources.GetObject("BandedGridColumn17.AppearanceCell.Font"), System.Drawing.Font)
        Me.BandedGridColumn17.AppearanceCell.Options.UseBackColor = True
        Me.BandedGridColumn17.AppearanceCell.Options.UseFont = True
        Me.BandedGridColumn17.AppearanceCell.Options.UseTextOptions = True
        Me.BandedGridColumn17.AppearanceCell.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center
        Me.BandedGridColumn17.AppearanceHeader.Font = CType(resources.GetObject("BandedGridColumn17.AppearanceHeader.Font"), System.Drawing.Font)
        Me.BandedGridColumn17.AppearanceHeader.ForeColor = System.Drawing.Color.Black
        Me.BandedGridColumn17.AppearanceHeader.Options.UseFont = True
        Me.BandedGridColumn17.AppearanceHeader.Options.UseForeColor = True
        Me.BandedGridColumn17.AppearanceHeader.Options.UseTextOptions = True
        Me.BandedGridColumn17.AppearanceHeader.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center
        resources.ApplyResources(Me.BandedGridColumn17, "BandedGridColumn17")
        Me.BandedGridColumn17.DisplayFormat.FormatString = " {0} %"
        Me.BandedGridColumn17.DisplayFormat.FormatType = DevExpress.Utils.FormatType.Custom
        Me.BandedGridColumn17.FieldName = "AP"
        Me.BandedGridColumn17.Name = "BandedGridColumn17"
        '
        'frmStatSyntContreMaitre
        '
        resources.ApplyResources(Me, "$this")
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.Wheat
        Me.Controls.Add(Me.LblHrRef)
        Me.Controls.Add(Me.LblPeriode)
        Me.Controls.Add(Me.GCStatTot)
        Me.Controls.Add(Me.LblTitre)
        Me.Controls.Add(Me.GrpActions)
        Me.Name = "frmStatSyntContreMaitre"
        Me.WindowState = System.Windows.Forms.FormWindowState.Maximized
        Me.GrpActions.ResumeLayout(False)
        CType(Me.GVStatTot, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.GCStatTot, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.AdvBandedGridView1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents LblPeriode As System.Windows.Forms.Label
    Friend WithEvents LblTitre As System.Windows.Forms.Label
    Friend WithEvents GrpActions As System.Windows.Forms.GroupBox
    Friend WithEvents BtnFermer As System.Windows.Forms.Button
    Friend WithEvents BtnPrint As System.Windows.Forms.Button
    Friend WithEvents LblHrRef As System.Windows.Forms.Label
    Private WithEvents GVStatTot As DevExpress.XtraGrid.Views.Grid.GridView
    Private WithEvents GColTotVPERNOM As DevExpress.XtraGrid.Columns.GridColumn
    Private WithEvents GColTotT As DevExpress.XtraGrid.Columns.GridColumn
    Private WithEvents GColTotH As DevExpress.XtraGrid.Columns.GridColumn
    Private WithEvents GColTotF As DevExpress.XtraGrid.Columns.GridColumn
    Private WithEvents GColTotKM As DevExpress.XtraGrid.Columns.GridColumn
    Private WithEvents GColTotD As DevExpress.XtraGrid.Columns.GridColumn
    Private WithEvents GColTotFA As DevExpress.XtraGrid.Columns.GridColumn
    Private WithEvents GCStatTot As DevExpress.XtraGrid.GridControl
    Private WithEvents AdvBandedGridView1 As DevExpress.XtraGrid.Views.BandedGrid.AdvBandedGridView
    Private WithEvents gridBand4 As DevExpress.XtraGrid.Views.BandedGrid.GridBand
    Private WithEvents BandedGridColumn1 As DevExpress.XtraGrid.Views.BandedGrid.BandedGridColumn
    Private WithEvents BandedGridColumn2 As DevExpress.XtraGrid.Views.BandedGrid.BandedGridColumn
    Private WithEvents GridBand1 As DevExpress.XtraGrid.Views.BandedGrid.GridBand
    Private WithEvents BandedGridColumn3 As DevExpress.XtraGrid.Views.BandedGrid.BandedGridColumn
    Private WithEvents BandedGridColumn8 As DevExpress.XtraGrid.Views.BandedGrid.BandedGridColumn
    Private WithEvents BandedGridColumn9 As DevExpress.XtraGrid.Views.BandedGrid.BandedGridColumn
    Private WithEvents gridBand2 As DevExpress.XtraGrid.Views.BandedGrid.GridBand
    Private WithEvents BandedGridColumn4 As DevExpress.XtraGrid.Views.BandedGrid.BandedGridColumn
    Private WithEvents BandedGridColumn11 As DevExpress.XtraGrid.Views.BandedGrid.BandedGridColumn
    Private WithEvents BandedGridColumn12 As DevExpress.XtraGrid.Views.BandedGrid.BandedGridColumn
    Private WithEvents gridBand3 As DevExpress.XtraGrid.Views.BandedGrid.GridBand
    Private WithEvents BandedGridColumn5 As DevExpress.XtraGrid.Views.BandedGrid.BandedGridColumn
    Private WithEvents BandedGridColumn13 As DevExpress.XtraGrid.Views.BandedGrid.BandedGridColumn
    Private WithEvents BandedGridColumn10 As DevExpress.XtraGrid.Views.BandedGrid.BandedGridColumn
    Private WithEvents gridBand5 As DevExpress.XtraGrid.Views.BandedGrid.GridBand
    Private WithEvents BandedGridColumn6 As DevExpress.XtraGrid.Views.BandedGrid.BandedGridColumn
    Private WithEvents BandedGridColumn15 As DevExpress.XtraGrid.Views.BandedGrid.BandedGridColumn
    Private WithEvents BandedGridColumn14 As DevExpress.XtraGrid.Views.BandedGrid.BandedGridColumn
    Private WithEvents gridBand6 As DevExpress.XtraGrid.Views.BandedGrid.GridBand
    Private WithEvents BandedGridColumn7 As DevExpress.XtraGrid.Views.BandedGrid.BandedGridColumn
    Private WithEvents BandedGridColumn16 As DevExpress.XtraGrid.Views.BandedGrid.BandedGridColumn
    Private WithEvents BandedGridColumn17 As DevExpress.XtraGrid.Views.BandedGrid.BandedGridColumn
End Class
