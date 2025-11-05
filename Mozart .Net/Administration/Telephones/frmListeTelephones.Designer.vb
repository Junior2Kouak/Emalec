<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmListeTelephones
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(frmListeTelephones))
        Me.GroupBox1 = New System.Windows.Forms.GroupBox()
        Me.Button1 = New System.Windows.Forms.Button()
        Me.ButtonExporter = New System.Windows.Forms.Button()
        Me.ButtonArchiver = New System.Windows.Forms.Button()
        Me.ButtonDetails = New System.Windows.Forms.Button()
        Me.BtnFermer = New System.Windows.Forms.Button()
        Me.BtnAjouter = New System.Windows.Forms.Button()
        Me.LabelSte = New System.Windows.Forms.Label()
        Me.cboSociete = New System.Windows.Forms.ComboBox()
        Me.GridControl1 = New DevExpress.XtraGrid.GridControl()
        Me.GridView1 = New DevExpress.XtraGrid.Views.Grid.GridView()
        Me.VTELOBS = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.NTELNUM = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.VSOCIETE = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.VTELSIM = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.VTELNUM = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.VTELCODE = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.VTELUTIL = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.VTELPROFIL = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.VTELMAT = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.DTELDATE = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.VTELOP = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.DTELENGOP = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.VVEHIMAT = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.nPerNum = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.LabelTitre = New System.Windows.Forms.Label()
        Me.GroupBoxTI = New System.Windows.Forms.GroupBox()
        Me.Label38 = New System.Windows.Forms.Label()
        Me.Label34 = New System.Windows.Forms.Label()
        Me.Label37 = New System.Windows.Forms.Label()
        Me.Label36 = New System.Windows.Forms.Label()
        Me.Label35 = New System.Windows.Forms.Label()
        Me.Label33 = New System.Windows.Forms.Label()
        Me.Label32 = New System.Windows.Forms.Label()
        Me.Label31 = New System.Windows.Forms.Label()
        Me.Label30 = New System.Windows.Forms.Label()
        Me.Label29 = New System.Windows.Forms.Label()
        Me.Label28 = New System.Windows.Forms.Label()
        Me.Label27 = New System.Windows.Forms.Label()
        Me.Label26 = New System.Windows.Forms.Label()
        Me.Label25 = New System.Windows.Forms.Label()
        Me.Label24 = New System.Windows.Forms.Label()
        Me.Label23 = New System.Windows.Forms.Label()
        Me.Label22 = New System.Windows.Forms.Label()
        Me.Label21 = New System.Windows.Forms.Label()
        Me.Label20 = New System.Windows.Forms.Label()
        Me.Label19 = New System.Windows.Forms.Label()
        Me.Label18 = New System.Windows.Forms.Label()
        Me.Label17 = New System.Windows.Forms.Label()
        Me.Label16 = New System.Windows.Forms.Label()
        Me.Label15 = New System.Windows.Forms.Label()
        Me.Label14 = New System.Windows.Forms.Label()
        Me.Label13 = New System.Windows.Forms.Label()
        Me.Label12 = New System.Windows.Forms.Label()
        Me.Label11 = New System.Windows.Forms.Label()
        Me.Label10 = New System.Windows.Forms.Label()
        Me.Label9 = New System.Windows.Forms.Label()
        Me.Label8 = New System.Windows.Forms.Label()
        Me.Label7 = New System.Windows.Forms.Label()
        Me.Label6 = New System.Windows.Forms.Label()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.Button2 = New System.Windows.Forms.Button()
        Me.BtnArchives = New System.Windows.Forms.Button()
        Me.GroupBox1.SuspendLayout()
        CType(Me.GridControl1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.GridView1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.GroupBoxTI.SuspendLayout()
        Me.SuspendLayout()
        '
        'GroupBox1
        '
        resources.ApplyResources(Me.GroupBox1, "GroupBox1")
        Me.GroupBox1.Controls.Add(Me.BtnArchives)
        Me.GroupBox1.Controls.Add(Me.Button1)
        Me.GroupBox1.Controls.Add(Me.ButtonExporter)
        Me.GroupBox1.Controls.Add(Me.ButtonArchiver)
        Me.GroupBox1.Controls.Add(Me.ButtonDetails)
        Me.GroupBox1.Controls.Add(Me.BtnFermer)
        Me.GroupBox1.Controls.Add(Me.BtnAjouter)
        Me.GroupBox1.Name = "GroupBox1"
        Me.GroupBox1.TabStop = False
        '
        'Button1
        '
        resources.ApplyResources(Me.Button1, "Button1")
        Me.Button1.Name = "Button1"
        Me.Button1.UseVisualStyleBackColor = True
        '
        'ButtonExporter
        '
        resources.ApplyResources(Me.ButtonExporter, "ButtonExporter")
        Me.ButtonExporter.Name = "ButtonExporter"
        Me.ButtonExporter.UseVisualStyleBackColor = True
        '
        'ButtonArchiver
        '
        resources.ApplyResources(Me.ButtonArchiver, "ButtonArchiver")
        Me.ButtonArchiver.Name = "ButtonArchiver"
        Me.ButtonArchiver.UseVisualStyleBackColor = True
        '
        'ButtonDetails
        '
        resources.ApplyResources(Me.ButtonDetails, "ButtonDetails")
        Me.ButtonDetails.Name = "ButtonDetails"
        Me.ButtonDetails.UseVisualStyleBackColor = True
        '
        'BtnFermer
        '
        resources.ApplyResources(Me.BtnFermer, "BtnFermer")
        Me.BtnFermer.Name = "BtnFermer"
        Me.BtnFermer.UseVisualStyleBackColor = True
        '
        'BtnAjouter
        '
        resources.ApplyResources(Me.BtnAjouter, "BtnAjouter")
        Me.BtnAjouter.Name = "BtnAjouter"
        Me.BtnAjouter.UseVisualStyleBackColor = True
        '
        'LabelSte
        '
        resources.ApplyResources(Me.LabelSte, "LabelSte")
        Me.LabelSte.Name = "LabelSte"
        '
        'cboSociete
        '
        Me.cboSociete.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.cboSociete.FormattingEnabled = True
        resources.ApplyResources(Me.cboSociete, "cboSociete")
        Me.cboSociete.Name = "cboSociete"
        Me.cboSociete.Tag = "112"
        '
        'GridControl1
        '
        resources.ApplyResources(Me.GridControl1, "GridControl1")
        Me.GridControl1.MainView = Me.GridView1
        Me.GridControl1.Name = "GridControl1"
        Me.GridControl1.ViewCollection.AddRange(New DevExpress.XtraGrid.Views.Base.BaseView() {Me.GridView1})
        '
        'GridView1
        '
        Me.GridView1.Appearance.ColumnFilterButton.BackColor = System.Drawing.Color.Silver
        Me.GridView1.Appearance.ColumnFilterButton.Options.UseBackColor = True
        Me.GridView1.Appearance.ColumnFilterButtonActive.BackColor = System.Drawing.Color.Silver
        Me.GridView1.Appearance.ColumnFilterButtonActive.Options.UseBackColor = True
        Me.GridView1.Appearance.FilterCloseButton.BackColor = System.Drawing.Color.White
        Me.GridView1.Appearance.FilterPanel.BackColor = System.Drawing.Color.Silver
        Me.GridView1.Appearance.FilterPanel.Options.UseBackColor = True
        Me.GridView1.Appearance.FixedLine.BackColor = System.Drawing.Color.Silver
        Me.GridView1.Appearance.FixedLine.Options.UseBackColor = True
        Me.GridView1.Appearance.FocusedCell.BackColor = System.Drawing.Color.Silver
        Me.GridView1.Appearance.FocusedCell.ForeColor = System.Drawing.Color.White
        Me.GridView1.Appearance.FocusedCell.Options.UseBackColor = True
        Me.GridView1.Appearance.FocusedCell.Options.UseForeColor = True
        Me.GridView1.Appearance.FocusedRow.ForeColor = System.Drawing.Color.Red
        Me.GridView1.Appearance.FocusedRow.Options.UseForeColor = True
        Me.GridView1.Appearance.HeaderPanel.Font = CType(resources.GetObject("GridView1.Appearance.HeaderPanel.Font"), System.Drawing.Font)
        Me.GridView1.Appearance.HeaderPanel.Options.UseFont = True
        Me.GridView1.Appearance.HeaderPanel.Options.UseTextOptions = True
        Me.GridView1.Appearance.HeaderPanel.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center
        Me.GridView1.Appearance.OddRow.BackColor = System.Drawing.Color.FromArgb(CType(CType(192, Byte), Integer), CType(CType(255, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.GridView1.Appearance.OddRow.BorderColor = System.Drawing.Color.FromArgb(CType(CType(192, Byte), Integer), CType(CType(255, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.GridView1.Appearance.OddRow.ForeColor = System.Drawing.Color.Black
        Me.GridView1.Appearance.OddRow.Options.UseBackColor = True
        Me.GridView1.Appearance.OddRow.Options.UseBorderColor = True
        Me.GridView1.Appearance.OddRow.Options.UseForeColor = True
        Me.GridView1.Appearance.SelectedRow.BackColor = System.Drawing.Color.White
        Me.GridView1.Appearance.SelectedRow.BackColor2 = CType(resources.GetObject("GridView1.Appearance.SelectedRow.BackColor2"), System.Drawing.Color)
        Me.GridView1.Appearance.SelectedRow.ForeColor = System.Drawing.Color.White
        Me.GridView1.Appearance.SelectedRow.Options.UseBackColor = True
        Me.GridView1.Appearance.SelectedRow.Options.UseForeColor = True
        Me.GridView1.AppearancePrint.FilterPanel.BackColor = System.Drawing.Color.Silver
        Me.GridView1.AppearancePrint.FilterPanel.Options.UseBackColor = True
        Me.GridView1.AutoFillColumn = Me.VTELOBS
        Me.GridView1.Columns.AddRange(New DevExpress.XtraGrid.Columns.GridColumn() {Me.NTELNUM, Me.VSOCIETE, Me.VTELSIM, Me.VTELNUM, Me.VTELCODE, Me.VTELUTIL, Me.VTELPROFIL, Me.VTELMAT, Me.DTELDATE, Me.VTELOP, Me.DTELENGOP, Me.VVEHIMAT, Me.VTELOBS, Me.nPerNum})
        Me.GridView1.DetailHeight = 284
        Me.GridView1.GridControl = Me.GridControl1
        Me.GridView1.Name = "GridView1"
        Me.GridView1.OptionsBehavior.Editable = False
        Me.GridView1.OptionsBehavior.ReadOnly = True
        Me.GridView1.OptionsCustomization.AllowGroup = False
        Me.GridView1.OptionsFilter.ShowAllTableValuesInFilterPopup = True
        Me.GridView1.OptionsPrint.PrintPreview = True
        Me.GridView1.OptionsView.ColumnAutoWidth = False
        Me.GridView1.OptionsView.EnableAppearanceEvenRow = True
        Me.GridView1.OptionsView.EnableAppearanceOddRow = True
        Me.GridView1.OptionsView.ShowAutoFilterRow = True
        Me.GridView1.OptionsView.ShowFilterPanelMode = DevExpress.XtraGrid.Views.Base.ShowFilterPanelMode.ShowAlways
        Me.GridView1.OptionsView.ShowFooter = True
        Me.GridView1.OptionsView.ShowGroupPanel = False
        '
        'VTELOBS
        '
        Me.VTELOBS.AppearanceHeader.ForeColor = System.Drawing.Color.Black
        Me.VTELOBS.AppearanceHeader.Options.UseForeColor = True
        resources.ApplyResources(Me.VTELOBS, "VTELOBS")
        Me.VTELOBS.FieldName = "VTELOBS"
        Me.VTELOBS.MinWidth = 15
        Me.VTELOBS.Name = "VTELOBS"
        Me.VTELOBS.OptionsFilter.AutoFilterCondition = DevExpress.XtraGrid.Columns.AutoFilterCondition.Contains
        '
        'NTELNUM
        '
        Me.NTELNUM.AppearanceHeader.ForeColor = System.Drawing.Color.Black
        Me.NTELNUM.AppearanceHeader.Options.UseForeColor = True
        resources.ApplyResources(Me.NTELNUM, "NTELNUM")
        Me.NTELNUM.FieldName = "NTELNUM"
        Me.NTELNUM.MinWidth = 15
        Me.NTELNUM.Name = "NTELNUM"
        Me.NTELNUM.OptionsFilter.AutoFilterCondition = DevExpress.XtraGrid.Columns.AutoFilterCondition.Contains
        Me.NTELNUM.Summary.AddRange(New DevExpress.XtraGrid.GridSummaryItem() {New DevExpress.XtraGrid.GridColumnSummaryItem(CType(resources.GetObject("NTELNUM.Summary"), DevExpress.Data.SummaryItemType))})
        '
        'VSOCIETE
        '
        Me.VSOCIETE.AppearanceHeader.ForeColor = System.Drawing.Color.Black
        Me.VSOCIETE.AppearanceHeader.Options.UseForeColor = True
        resources.ApplyResources(Me.VSOCIETE, "VSOCIETE")
        Me.VSOCIETE.FieldName = "VSOCIETE"
        Me.VSOCIETE.MinWidth = 15
        Me.VSOCIETE.Name = "VSOCIETE"
        Me.VSOCIETE.OptionsFilter.AutoFilterCondition = DevExpress.XtraGrid.Columns.AutoFilterCondition.Contains
        '
        'VTELSIM
        '
        Me.VTELSIM.AppearanceHeader.ForeColor = System.Drawing.Color.Black
        Me.VTELSIM.AppearanceHeader.Options.UseForeColor = True
        resources.ApplyResources(Me.VTELSIM, "VTELSIM")
        Me.VTELSIM.FieldName = "VTELSIM"
        Me.VTELSIM.MinWidth = 15
        Me.VTELSIM.Name = "VTELSIM"
        Me.VTELSIM.OptionsFilter.AutoFilterCondition = DevExpress.XtraGrid.Columns.AutoFilterCondition.Contains
        '
        'VTELNUM
        '
        Me.VTELNUM.AppearanceHeader.ForeColor = System.Drawing.Color.Black
        Me.VTELNUM.AppearanceHeader.Options.UseForeColor = True
        resources.ApplyResources(Me.VTELNUM, "VTELNUM")
        Me.VTELNUM.FieldName = "VTELNUM"
        Me.VTELNUM.MinWidth = 15
        Me.VTELNUM.Name = "VTELNUM"
        Me.VTELNUM.OptionsFilter.AutoFilterCondition = DevExpress.XtraGrid.Columns.AutoFilterCondition.Contains
        '
        'VTELCODE
        '
        Me.VTELCODE.AppearanceHeader.ForeColor = System.Drawing.Color.Black
        Me.VTELCODE.AppearanceHeader.Options.UseForeColor = True
        resources.ApplyResources(Me.VTELCODE, "VTELCODE")
        Me.VTELCODE.FieldName = "VTELCODE"
        Me.VTELCODE.MinWidth = 15
        Me.VTELCODE.Name = "VTELCODE"
        Me.VTELCODE.OptionsFilter.AutoFilterCondition = DevExpress.XtraGrid.Columns.AutoFilterCondition.Contains
        '
        'VTELUTIL
        '
        Me.VTELUTIL.AppearanceHeader.ForeColor = System.Drawing.Color.Black
        Me.VTELUTIL.AppearanceHeader.Options.UseForeColor = True
        resources.ApplyResources(Me.VTELUTIL, "VTELUTIL")
        Me.VTELUTIL.FieldName = "VTELUTIL"
        Me.VTELUTIL.MinWidth = 15
        Me.VTELUTIL.Name = "VTELUTIL"
        Me.VTELUTIL.OptionsFilter.AutoFilterCondition = DevExpress.XtraGrid.Columns.AutoFilterCondition.Contains
        '
        'VTELPROFIL
        '
        Me.VTELPROFIL.AppearanceHeader.ForeColor = System.Drawing.Color.Black
        Me.VTELPROFIL.AppearanceHeader.Options.UseForeColor = True
        resources.ApplyResources(Me.VTELPROFIL, "VTELPROFIL")
        Me.VTELPROFIL.FieldName = "VTELPROFIL"
        Me.VTELPROFIL.MinWidth = 15
        Me.VTELPROFIL.Name = "VTELPROFIL"
        Me.VTELPROFIL.OptionsFilter.AutoFilterCondition = DevExpress.XtraGrid.Columns.AutoFilterCondition.Contains
        '
        'VTELMAT
        '
        Me.VTELMAT.AppearanceHeader.ForeColor = System.Drawing.Color.Black
        Me.VTELMAT.AppearanceHeader.Options.UseForeColor = True
        resources.ApplyResources(Me.VTELMAT, "VTELMAT")
        Me.VTELMAT.FieldName = "VTELMAT"
        Me.VTELMAT.MinWidth = 15
        Me.VTELMAT.Name = "VTELMAT"
        Me.VTELMAT.OptionsFilter.AutoFilterCondition = DevExpress.XtraGrid.Columns.AutoFilterCondition.Contains
        '
        'DTELDATE
        '
        Me.DTELDATE.AppearanceHeader.ForeColor = System.Drawing.Color.Black
        Me.DTELDATE.AppearanceHeader.Options.UseForeColor = True
        resources.ApplyResources(Me.DTELDATE, "DTELDATE")
        Me.DTELDATE.FieldName = "DTELDATE"
        Me.DTELDATE.MinWidth = 15
        Me.DTELDATE.Name = "DTELDATE"
        Me.DTELDATE.OptionsFilter.AutoFilterCondition = DevExpress.XtraGrid.Columns.AutoFilterCondition.Contains
        '
        'VTELOP
        '
        Me.VTELOP.AppearanceHeader.ForeColor = System.Drawing.Color.Black
        Me.VTELOP.AppearanceHeader.Options.UseForeColor = True
        resources.ApplyResources(Me.VTELOP, "VTELOP")
        Me.VTELOP.FieldName = "VTELOP"
        Me.VTELOP.MinWidth = 15
        Me.VTELOP.Name = "VTELOP"
        '
        'DTELENGOP
        '
        Me.DTELENGOP.AppearanceHeader.ForeColor = System.Drawing.Color.Black
        Me.DTELENGOP.AppearanceHeader.Options.UseForeColor = True
        resources.ApplyResources(Me.DTELENGOP, "DTELENGOP")
        Me.DTELENGOP.FieldName = "DTELENGOP"
        Me.DTELENGOP.MinWidth = 15
        Me.DTELENGOP.Name = "DTELENGOP"
        '
        'VVEHIMAT
        '
        Me.VVEHIMAT.AppearanceHeader.ForeColor = System.Drawing.Color.Black
        Me.VVEHIMAT.AppearanceHeader.Options.UseForeColor = True
        resources.ApplyResources(Me.VVEHIMAT, "VVEHIMAT")
        Me.VVEHIMAT.FieldName = "VVEHIMAT"
        Me.VVEHIMAT.Name = "VVEHIMAT"
        '
        'nPerNum
        '
        resources.ApplyResources(Me.nPerNum, "nPerNum")
        Me.nPerNum.FieldName = "nPerNum"
        Me.nPerNum.MinWidth = 15
        Me.nPerNum.Name = "nPerNum"
        '
        'LabelTitre
        '
        resources.ApplyResources(Me.LabelTitre, "LabelTitre")
        Me.LabelTitre.Name = "LabelTitre"
        '
        'GroupBoxTI
        '
        Me.GroupBoxTI.Controls.Add(Me.Label38)
        Me.GroupBoxTI.Controls.Add(Me.Label34)
        Me.GroupBoxTI.Controls.Add(Me.Label37)
        Me.GroupBoxTI.Controls.Add(Me.Label36)
        Me.GroupBoxTI.Controls.Add(Me.Label35)
        Me.GroupBoxTI.Controls.Add(Me.Label33)
        Me.GroupBoxTI.Controls.Add(Me.Label32)
        Me.GroupBoxTI.Controls.Add(Me.Label31)
        Me.GroupBoxTI.Controls.Add(Me.Label30)
        Me.GroupBoxTI.Controls.Add(Me.Label29)
        Me.GroupBoxTI.Controls.Add(Me.Label28)
        Me.GroupBoxTI.Controls.Add(Me.Label27)
        Me.GroupBoxTI.Controls.Add(Me.Label26)
        Me.GroupBoxTI.Controls.Add(Me.Label25)
        Me.GroupBoxTI.Controls.Add(Me.Label24)
        Me.GroupBoxTI.Controls.Add(Me.Label23)
        Me.GroupBoxTI.Controls.Add(Me.Label22)
        Me.GroupBoxTI.Controls.Add(Me.Label21)
        Me.GroupBoxTI.Controls.Add(Me.Label20)
        Me.GroupBoxTI.Controls.Add(Me.Label19)
        Me.GroupBoxTI.Controls.Add(Me.Label18)
        Me.GroupBoxTI.Controls.Add(Me.Label17)
        Me.GroupBoxTI.Controls.Add(Me.Label16)
        Me.GroupBoxTI.Controls.Add(Me.Label15)
        Me.GroupBoxTI.Controls.Add(Me.Label14)
        Me.GroupBoxTI.Controls.Add(Me.Label13)
        Me.GroupBoxTI.Controls.Add(Me.Label12)
        Me.GroupBoxTI.Controls.Add(Me.Label11)
        Me.GroupBoxTI.Controls.Add(Me.Label10)
        Me.GroupBoxTI.Controls.Add(Me.Label9)
        Me.GroupBoxTI.Controls.Add(Me.Label8)
        Me.GroupBoxTI.Controls.Add(Me.Label7)
        Me.GroupBoxTI.Controls.Add(Me.Label6)
        Me.GroupBoxTI.Controls.Add(Me.Label5)
        Me.GroupBoxTI.Controls.Add(Me.Label4)
        Me.GroupBoxTI.Controls.Add(Me.Label3)
        Me.GroupBoxTI.Controls.Add(Me.Label2)
        Me.GroupBoxTI.Controls.Add(Me.Label1)
        Me.GroupBoxTI.Controls.Add(Me.Button2)
        resources.ApplyResources(Me.GroupBoxTI, "GroupBoxTI")
        Me.GroupBoxTI.Name = "GroupBoxTI"
        Me.GroupBoxTI.TabStop = False
        '
        'Label38
        '
        resources.ApplyResources(Me.Label38, "Label38")
        Me.Label38.Name = "Label38"
        '
        'Label34
        '
        resources.ApplyResources(Me.Label34, "Label34")
        Me.Label34.Name = "Label34"
        '
        'Label37
        '
        resources.ApplyResources(Me.Label37, "Label37")
        Me.Label37.Name = "Label37"
        '
        'Label36
        '
        resources.ApplyResources(Me.Label36, "Label36")
        Me.Label36.Name = "Label36"
        '
        'Label35
        '
        resources.ApplyResources(Me.Label35, "Label35")
        Me.Label35.Name = "Label35"
        '
        'Label33
        '
        resources.ApplyResources(Me.Label33, "Label33")
        Me.Label33.Name = "Label33"
        '
        'Label32
        '
        resources.ApplyResources(Me.Label32, "Label32")
        Me.Label32.Name = "Label32"
        '
        'Label31
        '
        resources.ApplyResources(Me.Label31, "Label31")
        Me.Label31.Name = "Label31"
        '
        'Label30
        '
        resources.ApplyResources(Me.Label30, "Label30")
        Me.Label30.Name = "Label30"
        '
        'Label29
        '
        resources.ApplyResources(Me.Label29, "Label29")
        Me.Label29.Name = "Label29"
        '
        'Label28
        '
        resources.ApplyResources(Me.Label28, "Label28")
        Me.Label28.Name = "Label28"
        '
        'Label27
        '
        resources.ApplyResources(Me.Label27, "Label27")
        Me.Label27.Name = "Label27"
        '
        'Label26
        '
        resources.ApplyResources(Me.Label26, "Label26")
        Me.Label26.Name = "Label26"
        '
        'Label25
        '
        resources.ApplyResources(Me.Label25, "Label25")
        Me.Label25.Name = "Label25"
        '
        'Label24
        '
        resources.ApplyResources(Me.Label24, "Label24")
        Me.Label24.Name = "Label24"
        '
        'Label23
        '
        resources.ApplyResources(Me.Label23, "Label23")
        Me.Label23.Name = "Label23"
        '
        'Label22
        '
        resources.ApplyResources(Me.Label22, "Label22")
        Me.Label22.Name = "Label22"
        '
        'Label21
        '
        resources.ApplyResources(Me.Label21, "Label21")
        Me.Label21.Name = "Label21"
        '
        'Label20
        '
        resources.ApplyResources(Me.Label20, "Label20")
        Me.Label20.Name = "Label20"
        '
        'Label19
        '
        resources.ApplyResources(Me.Label19, "Label19")
        Me.Label19.Name = "Label19"
        '
        'Label18
        '
        resources.ApplyResources(Me.Label18, "Label18")
        Me.Label18.Name = "Label18"
        '
        'Label17
        '
        resources.ApplyResources(Me.Label17, "Label17")
        Me.Label17.Name = "Label17"
        '
        'Label16
        '
        resources.ApplyResources(Me.Label16, "Label16")
        Me.Label16.Name = "Label16"
        '
        'Label15
        '
        resources.ApplyResources(Me.Label15, "Label15")
        Me.Label15.Name = "Label15"
        '
        'Label14
        '
        resources.ApplyResources(Me.Label14, "Label14")
        Me.Label14.Name = "Label14"
        '
        'Label13
        '
        resources.ApplyResources(Me.Label13, "Label13")
        Me.Label13.Name = "Label13"
        '
        'Label12
        '
        resources.ApplyResources(Me.Label12, "Label12")
        Me.Label12.Name = "Label12"
        '
        'Label11
        '
        resources.ApplyResources(Me.Label11, "Label11")
        Me.Label11.Name = "Label11"
        '
        'Label10
        '
        resources.ApplyResources(Me.Label10, "Label10")
        Me.Label10.Name = "Label10"
        '
        'Label9
        '
        resources.ApplyResources(Me.Label9, "Label9")
        Me.Label9.Name = "Label9"
        '
        'Label8
        '
        resources.ApplyResources(Me.Label8, "Label8")
        Me.Label8.Name = "Label8"
        '
        'Label7
        '
        resources.ApplyResources(Me.Label7, "Label7")
        Me.Label7.Name = "Label7"
        '
        'Label6
        '
        resources.ApplyResources(Me.Label6, "Label6")
        Me.Label6.Name = "Label6"
        '
        'Label5
        '
        resources.ApplyResources(Me.Label5, "Label5")
        Me.Label5.Name = "Label5"
        '
        'Label4
        '
        resources.ApplyResources(Me.Label4, "Label4")
        Me.Label4.Name = "Label4"
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
        'Label1
        '
        resources.ApplyResources(Me.Label1, "Label1")
        Me.Label1.Name = "Label1"
        '
        'Button2
        '
        resources.ApplyResources(Me.Button2, "Button2")
        Me.Button2.Name = "Button2"
        Me.Button2.UseVisualStyleBackColor = True
        '
        'BtnArchives
        '
        resources.ApplyResources(Me.BtnArchives, "BtnArchives")
        Me.BtnArchives.Name = "BtnArchives"
        Me.BtnArchives.UseVisualStyleBackColor = True
        '
        'frmListeTelephones
        '
        resources.ApplyResources(Me, "$this")
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.Wheat
        Me.Controls.Add(Me.GroupBoxTI)
        Me.Controls.Add(Me.LabelSte)
        Me.Controls.Add(Me.cboSociete)
        Me.Controls.Add(Me.GridControl1)
        Me.Controls.Add(Me.LabelTitre)
        Me.Controls.Add(Me.GroupBox1)
        Me.Name = "frmListeTelephones"
        Me.WindowState = System.Windows.Forms.FormWindowState.Maximized
        Me.GroupBox1.ResumeLayout(False)
        CType(Me.GridControl1, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.GridView1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.GroupBoxTI.ResumeLayout(False)
        Me.GroupBoxTI.PerformLayout()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents GroupBox1 As System.Windows.Forms.GroupBox
    Friend WithEvents ButtonArchiver As System.Windows.Forms.Button
    Friend WithEvents ButtonDetails As System.Windows.Forms.Button
    Friend WithEvents BtnFermer As System.Windows.Forms.Button
    Friend WithEvents BtnAjouter As System.Windows.Forms.Button
    Friend WithEvents LabelSte As System.Windows.Forms.Label
    Friend WithEvents cboSociete As System.Windows.Forms.ComboBox
    Friend WithEvents LabelTitre As System.Windows.Forms.Label
    Friend WithEvents ButtonExporter As System.Windows.Forms.Button
    Friend WithEvents Button1 As System.Windows.Forms.Button
    Friend WithEvents GroupBoxTI As System.Windows.Forms.GroupBox
    Friend WithEvents Button2 As System.Windows.Forms.Button
    Friend WithEvents Label12 As System.Windows.Forms.Label
    Friend WithEvents Label11 As System.Windows.Forms.Label
    Friend WithEvents Label10 As System.Windows.Forms.Label
    Friend WithEvents Label9 As System.Windows.Forms.Label
    Friend WithEvents Label8 As System.Windows.Forms.Label
    Friend WithEvents Label7 As System.Windows.Forms.Label
    Friend WithEvents Label6 As System.Windows.Forms.Label
    Friend WithEvents Label5 As System.Windows.Forms.Label
    Friend WithEvents Label4 As System.Windows.Forms.Label
    Friend WithEvents Label3 As System.Windows.Forms.Label
    Friend WithEvents Label2 As System.Windows.Forms.Label
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents Label24 As System.Windows.Forms.Label
    Friend WithEvents Label23 As System.Windows.Forms.Label
    Friend WithEvents Label22 As System.Windows.Forms.Label
    Friend WithEvents Label21 As System.Windows.Forms.Label
    Friend WithEvents Label20 As System.Windows.Forms.Label
    Friend WithEvents Label19 As System.Windows.Forms.Label
    Friend WithEvents Label18 As System.Windows.Forms.Label
    Friend WithEvents Label17 As System.Windows.Forms.Label
    Friend WithEvents Label16 As System.Windows.Forms.Label
    Friend WithEvents Label15 As System.Windows.Forms.Label
    Friend WithEvents Label14 As System.Windows.Forms.Label
    Friend WithEvents Label13 As System.Windows.Forms.Label
    Friend WithEvents Label37 As System.Windows.Forms.Label
    Friend WithEvents Label36 As System.Windows.Forms.Label
    Friend WithEvents Label35 As System.Windows.Forms.Label
    Friend WithEvents Label33 As System.Windows.Forms.Label
    Friend WithEvents Label32 As System.Windows.Forms.Label
    Friend WithEvents Label31 As System.Windows.Forms.Label
    Friend WithEvents Label30 As System.Windows.Forms.Label
    Friend WithEvents Label29 As System.Windows.Forms.Label
    Friend WithEvents Label28 As System.Windows.Forms.Label
    Friend WithEvents Label27 As System.Windows.Forms.Label
    Friend WithEvents Label26 As System.Windows.Forms.Label
    Friend WithEvents Label25 As System.Windows.Forms.Label
    Friend WithEvents Label38 As System.Windows.Forms.Label
    Friend WithEvents Label34 As System.Windows.Forms.Label
    Private WithEvents GridControl1 As DevExpress.XtraGrid.GridControl
    Private WithEvents GridView1 As DevExpress.XtraGrid.Views.Grid.GridView
    Private WithEvents NTELNUM As DevExpress.XtraGrid.Columns.GridColumn
    Private WithEvents VSOCIETE As DevExpress.XtraGrid.Columns.GridColumn
    Private WithEvents VTELSIM As DevExpress.XtraGrid.Columns.GridColumn
    Private WithEvents VTELCODE As DevExpress.XtraGrid.Columns.GridColumn
    Private WithEvents VTELUTIL As DevExpress.XtraGrid.Columns.GridColumn
    Private WithEvents VTELPROFIL As DevExpress.XtraGrid.Columns.GridColumn
    Private WithEvents VTELMAT As DevExpress.XtraGrid.Columns.GridColumn
    Private WithEvents DTELDATE As DevExpress.XtraGrid.Columns.GridColumn
    Private WithEvents VTELOBS As DevExpress.XtraGrid.Columns.GridColumn
    Private WithEvents nPerNum As DevExpress.XtraGrid.Columns.GridColumn
    Private WithEvents VTELNUM As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents VTELOP As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents DTELENGOP As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents VVEHIMAT As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents BtnArchives As Button
End Class
