<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmListeClientsEI
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(frmListeClientsEI))
        Me.ButtonExporter = New System.Windows.Forms.Button()
        Me.GCListeClientsEI = New DevExpress.XtraGrid.GridControl()
        Me.GVListeClientsEI = New DevExpress.XtraGrid.Views.Grid.GridView()
        Me.ColNIDPROC = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.NCLINUM = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.ColVCLINOM = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.GColVCONTEISIGN = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.ColVCONTEI = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.ColVTITRE = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.ColVLIBDATECHE = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.ColVFICHIER = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.DateCre = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.NBEXTINCTEURS = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.CA = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.PASDECONTRATEI = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.GroupBox1 = New System.Windows.Forms.GroupBox()
        Me.BtnArchiverContEI = New System.Windows.Forms.Button()
        Me.BtnRelanceCont = New System.Windows.Forms.Button()
        Me.BtnModifContratEI = New System.Windows.Forms.Button()
        Me.btnCreerContratEI = New System.Windows.Forms.Button()
        Me.BtnFermer = New System.Windows.Forms.Button()
        Me.BtnPrint = New System.Windows.Forms.Button()
        Me.LabelTitre = New System.Windows.Forms.Label()
        Me.GrpApercu = New System.Windows.Forms.GroupBox()
        Me.WBApercu = New System.Windows.Forms.WebBrowser()
        CType(Me.GCListeClientsEI, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.GVListeClientsEI, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.GroupBox1.SuspendLayout()
        Me.GrpApercu.SuspendLayout()
        Me.SuspendLayout()
        '
        'ButtonExporter
        '
        resources.ApplyResources(Me.ButtonExporter, "ButtonExporter")
        Me.ButtonExporter.Name = "ButtonExporter"
        Me.ButtonExporter.UseVisualStyleBackColor = True
        '
        'GCListeClientsEI
        '
        resources.ApplyResources(Me.GCListeClientsEI, "GCListeClientsEI")
        Me.GCListeClientsEI.MainView = Me.GVListeClientsEI
        Me.GCListeClientsEI.Name = "GCListeClientsEI"
        Me.GCListeClientsEI.ViewCollection.AddRange(New DevExpress.XtraGrid.Views.Base.BaseView() {Me.GVListeClientsEI})
        '
        'GVListeClientsEI
        '
        Me.GVListeClientsEI.ColumnPanelRowHeight = 50
        Me.GVListeClientsEI.Columns.AddRange(New DevExpress.XtraGrid.Columns.GridColumn() {Me.ColNIDPROC, Me.NCLINUM, Me.ColVCLINOM, Me.GColVCONTEISIGN, Me.ColVCONTEI, Me.ColVTITRE, Me.ColVLIBDATECHE, Me.ColVFICHIER, Me.DateCre, Me.NBEXTINCTEURS, Me.CA, Me.PASDECONTRATEI})
        Me.GVListeClientsEI.GridControl = Me.GCListeClientsEI
        Me.GVListeClientsEI.Name = "GVListeClientsEI"
        Me.GVListeClientsEI.OptionsBehavior.ReadOnly = True
        Me.GVListeClientsEI.OptionsCustomization.AllowGroup = False
        Me.GVListeClientsEI.OptionsPrint.PrintFilterInfo = True
        Me.GVListeClientsEI.OptionsView.ShowAutoFilterRow = True
        Me.GVListeClientsEI.OptionsView.ShowFilterPanelMode = DevExpress.XtraGrid.Views.Base.ShowFilterPanelMode.Never
        Me.GVListeClientsEI.OptionsView.ShowFooter = True
        Me.GVListeClientsEI.OptionsView.ShowGroupPanel = False
        '
        'ColNIDPROC
        '
        Me.ColNIDPROC.FieldName = "NIDPROC"
        Me.ColNIDPROC.Name = "ColNIDPROC"
        '
        'NCLINUM
        '
        resources.ApplyResources(Me.NCLINUM, "NCLINUM")
        Me.NCLINUM.FieldName = "NCLINUM"
        Me.NCLINUM.Name = "NCLINUM"
        '
        'ColVCLINOM
        '
        Me.ColVCLINOM.AppearanceCell.Font = CType(resources.GetObject("ColVCLINOM.AppearanceCell.Font"), System.Drawing.Font)
        Me.ColVCLINOM.AppearanceCell.Options.UseFont = True
        Me.ColVCLINOM.AppearanceHeader.Font = CType(resources.GetObject("ColVCLINOM.AppearanceHeader.Font"), System.Drawing.Font)
        Me.ColVCLINOM.AppearanceHeader.ForeColor = System.Drawing.Color.Black
        Me.ColVCLINOM.AppearanceHeader.Options.UseFont = True
        Me.ColVCLINOM.AppearanceHeader.Options.UseForeColor = True
        Me.ColVCLINOM.AppearanceHeader.Options.UseTextOptions = True
        Me.ColVCLINOM.AppearanceHeader.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center
        Me.ColVCLINOM.AppearanceHeader.TextOptions.VAlignment = DevExpress.Utils.VertAlignment.Center
        Me.ColVCLINOM.AppearanceHeader.TextOptions.WordWrap = DevExpress.Utils.WordWrap.Wrap
        resources.ApplyResources(Me.ColVCLINOM, "ColVCLINOM")
        Me.ColVCLINOM.FieldName = "VCLINOM"
        Me.ColVCLINOM.MinWidth = 200
        Me.ColVCLINOM.Name = "ColVCLINOM"
        Me.ColVCLINOM.OptionsColumn.AllowEdit = False
        Me.ColVCLINOM.OptionsColumn.ReadOnly = True
        Me.ColVCLINOM.OptionsFilter.AutoFilterCondition = DevExpress.XtraGrid.Columns.AutoFilterCondition.Contains
        '
        'GColVCONTEISIGN
        '
        Me.GColVCONTEISIGN.AppearanceCell.Options.UseTextOptions = True
        Me.GColVCONTEISIGN.AppearanceCell.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center
        Me.GColVCONTEISIGN.AppearanceCell.TextOptions.VAlignment = DevExpress.Utils.VertAlignment.Center
        Me.GColVCONTEISIGN.AppearanceHeader.Font = CType(resources.GetObject("GColVCONTEISIGN.AppearanceHeader.Font"), System.Drawing.Font)
        Me.GColVCONTEISIGN.AppearanceHeader.ForeColor = System.Drawing.Color.Black
        Me.GColVCONTEISIGN.AppearanceHeader.Options.UseFont = True
        Me.GColVCONTEISIGN.AppearanceHeader.Options.UseForeColor = True
        Me.GColVCONTEISIGN.AppearanceHeader.Options.UseTextOptions = True
        Me.GColVCONTEISIGN.AppearanceHeader.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center
        Me.GColVCONTEISIGN.AppearanceHeader.TextOptions.VAlignment = DevExpress.Utils.VertAlignment.Center
        Me.GColVCONTEISIGN.AppearanceHeader.TextOptions.WordWrap = DevExpress.Utils.WordWrap.Wrap
        resources.ApplyResources(Me.GColVCONTEISIGN, "GColVCONTEISIGN")
        Me.GColVCONTEISIGN.FieldName = "VCONTEISIGN"
        Me.GColVCONTEISIGN.Name = "GColVCONTEISIGN"
        '
        'ColVCONTEI
        '
        Me.ColVCONTEI.AppearanceCell.Font = CType(resources.GetObject("ColVCONTEI.AppearanceCell.Font"), System.Drawing.Font)
        Me.ColVCONTEI.AppearanceCell.Options.UseFont = True
        Me.ColVCONTEI.AppearanceCell.Options.UseTextOptions = True
        Me.ColVCONTEI.AppearanceCell.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center
        Me.ColVCONTEI.AppearanceCell.TextOptions.VAlignment = DevExpress.Utils.VertAlignment.Center
        Me.ColVCONTEI.AppearanceHeader.Font = CType(resources.GetObject("ColVCONTEI.AppearanceHeader.Font"), System.Drawing.Font)
        Me.ColVCONTEI.AppearanceHeader.ForeColor = System.Drawing.Color.Black
        Me.ColVCONTEI.AppearanceHeader.Options.UseFont = True
        Me.ColVCONTEI.AppearanceHeader.Options.UseForeColor = True
        Me.ColVCONTEI.AppearanceHeader.Options.UseTextOptions = True
        Me.ColVCONTEI.AppearanceHeader.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center
        Me.ColVCONTEI.AppearanceHeader.TextOptions.VAlignment = DevExpress.Utils.VertAlignment.Center
        Me.ColVCONTEI.AppearanceHeader.TextOptions.WordWrap = DevExpress.Utils.WordWrap.Wrap
        resources.ApplyResources(Me.ColVCONTEI, "ColVCONTEI")
        Me.ColVCONTEI.FieldName = "VCONTEI"
        Me.ColVCONTEI.MinWidth = 70
        Me.ColVCONTEI.Name = "ColVCONTEI"
        Me.ColVCONTEI.OptionsColumn.AllowEdit = False
        Me.ColVCONTEI.OptionsColumn.ReadOnly = True
        Me.ColVCONTEI.OptionsFilter.AutoFilterCondition = DevExpress.XtraGrid.Columns.AutoFilterCondition.Contains
        '
        'ColVTITRE
        '
        Me.ColVTITRE.AppearanceHeader.Font = CType(resources.GetObject("ColVTITRE.AppearanceHeader.Font"), System.Drawing.Font)
        Me.ColVTITRE.AppearanceHeader.ForeColor = System.Drawing.Color.Black
        Me.ColVTITRE.AppearanceHeader.Options.UseFont = True
        Me.ColVTITRE.AppearanceHeader.Options.UseForeColor = True
        Me.ColVTITRE.AppearanceHeader.Options.UseTextOptions = True
        Me.ColVTITRE.AppearanceHeader.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center
        Me.ColVTITRE.AppearanceHeader.TextOptions.VAlignment = DevExpress.Utils.VertAlignment.Center
        Me.ColVTITRE.AppearanceHeader.TextOptions.WordWrap = DevExpress.Utils.WordWrap.Wrap
        resources.ApplyResources(Me.ColVTITRE, "ColVTITRE")
        Me.ColVTITRE.FieldName = "VTITRE"
        Me.ColVTITRE.Name = "ColVTITRE"
        '
        'ColVLIBDATECHE
        '
        Me.ColVLIBDATECHE.AppearanceCell.Options.UseTextOptions = True
        Me.ColVLIBDATECHE.AppearanceCell.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center
        Me.ColVLIBDATECHE.AppearanceCell.TextOptions.VAlignment = DevExpress.Utils.VertAlignment.Center
        Me.ColVLIBDATECHE.AppearanceHeader.Font = CType(resources.GetObject("ColVLIBDATECHE.AppearanceHeader.Font"), System.Drawing.Font)
        Me.ColVLIBDATECHE.AppearanceHeader.ForeColor = System.Drawing.Color.Black
        Me.ColVLIBDATECHE.AppearanceHeader.Options.UseFont = True
        Me.ColVLIBDATECHE.AppearanceHeader.Options.UseForeColor = True
        Me.ColVLIBDATECHE.AppearanceHeader.Options.UseTextOptions = True
        Me.ColVLIBDATECHE.AppearanceHeader.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center
        Me.ColVLIBDATECHE.AppearanceHeader.TextOptions.VAlignment = DevExpress.Utils.VertAlignment.Center
        Me.ColVLIBDATECHE.AppearanceHeader.TextOptions.WordWrap = DevExpress.Utils.WordWrap.Wrap
        resources.ApplyResources(Me.ColVLIBDATECHE, "ColVLIBDATECHE")
        Me.ColVLIBDATECHE.FieldName = "VLIBDATECHE"
        Me.ColVLIBDATECHE.Name = "ColVLIBDATECHE"
        Me.ColVLIBDATECHE.OptionsColumn.ReadOnly = True
        Me.ColVLIBDATECHE.OptionsFilter.AutoFilterCondition = DevExpress.XtraGrid.Columns.AutoFilterCondition.Contains
        '
        'ColVFICHIER
        '
        resources.ApplyResources(Me.ColVFICHIER, "ColVFICHIER")
        Me.ColVFICHIER.FieldName = "VFICHIER"
        Me.ColVFICHIER.Name = "ColVFICHIER"
        '
        'DateCre
        '
        Me.DateCre.AppearanceHeader.Font = CType(resources.GetObject("DateCre.AppearanceHeader.Font"), System.Drawing.Font)
        Me.DateCre.AppearanceHeader.ForeColor = System.Drawing.Color.Black
        Me.DateCre.AppearanceHeader.Options.UseFont = True
        Me.DateCre.AppearanceHeader.Options.UseForeColor = True
        Me.DateCre.AppearanceHeader.Options.UseTextOptions = True
        Me.DateCre.AppearanceHeader.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center
        Me.DateCre.AppearanceHeader.TextOptions.VAlignment = DevExpress.Utils.VertAlignment.Center
        Me.DateCre.AppearanceHeader.TextOptions.WordWrap = DevExpress.Utils.WordWrap.Wrap
        resources.ApplyResources(Me.DateCre, "DateCre")
        Me.DateCre.FieldName = "DATECRE"
        Me.DateCre.Name = "DateCre"
        '
        'NBEXTINCTEURS
        '
        Me.NBEXTINCTEURS.AppearanceHeader.Font = CType(resources.GetObject("NBEXTINCTEURS.AppearanceHeader.Font"), System.Drawing.Font)
        Me.NBEXTINCTEURS.AppearanceHeader.ForeColor = System.Drawing.Color.Black
        Me.NBEXTINCTEURS.AppearanceHeader.Options.UseFont = True
        Me.NBEXTINCTEURS.AppearanceHeader.Options.UseForeColor = True
        Me.NBEXTINCTEURS.AppearanceHeader.Options.UseTextOptions = True
        Me.NBEXTINCTEURS.AppearanceHeader.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center
        Me.NBEXTINCTEURS.AppearanceHeader.TextOptions.VAlignment = DevExpress.Utils.VertAlignment.Center
        Me.NBEXTINCTEURS.AppearanceHeader.TextOptions.WordWrap = DevExpress.Utils.WordWrap.Wrap
        resources.ApplyResources(Me.NBEXTINCTEURS, "NBEXTINCTEURS")
        Me.NBEXTINCTEURS.FieldName = "NBEXTINCTEURS"
        Me.NBEXTINCTEURS.Name = "NBEXTINCTEURS"
        '
        'CA
        '
        Me.CA.AppearanceHeader.Font = CType(resources.GetObject("CA.AppearanceHeader.Font"), System.Drawing.Font)
        Me.CA.AppearanceHeader.ForeColor = System.Drawing.Color.Black
        Me.CA.AppearanceHeader.Options.UseFont = True
        Me.CA.AppearanceHeader.Options.UseForeColor = True
        Me.CA.AppearanceHeader.Options.UseTextOptions = True
        Me.CA.AppearanceHeader.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center
        Me.CA.AppearanceHeader.TextOptions.VAlignment = DevExpress.Utils.VertAlignment.Center
        Me.CA.AppearanceHeader.TextOptions.WordWrap = DevExpress.Utils.WordWrap.Wrap
        resources.ApplyResources(Me.CA, "CA")
        Me.CA.DisplayFormat.FormatString = "## ##0.00"
        Me.CA.DisplayFormat.FormatType = DevExpress.Utils.FormatType.Numeric
        Me.CA.FieldName = "CA"
        Me.CA.Name = "CA"
        '
        'PASDECONTRATEI
        '
        Me.PASDECONTRATEI.AppearanceHeader.Font = CType(resources.GetObject("PASDECONTRATEI.AppearanceHeader.Font"), System.Drawing.Font)
        Me.PASDECONTRATEI.AppearanceHeader.ForeColor = System.Drawing.Color.Black
        Me.PASDECONTRATEI.AppearanceHeader.Options.UseFont = True
        Me.PASDECONTRATEI.AppearanceHeader.Options.UseForeColor = True
        resources.ApplyResources(Me.PASDECONTRATEI, "PASDECONTRATEI")
        Me.PASDECONTRATEI.FieldName = "PASDECONTRATEI"
        Me.PASDECONTRATEI.Name = "PASDECONTRATEI"
        Me.PASDECONTRATEI.OptionsColumn.AllowEdit = False
        Me.PASDECONTRATEI.OptionsColumn.ReadOnly = True
        '
        'GroupBox1
        '
        Me.GroupBox1.Controls.Add(Me.BtnArchiverContEI)
        Me.GroupBox1.Controls.Add(Me.BtnRelanceCont)
        Me.GroupBox1.Controls.Add(Me.BtnModifContratEI)
        Me.GroupBox1.Controls.Add(Me.btnCreerContratEI)
        Me.GroupBox1.Controls.Add(Me.ButtonExporter)
        Me.GroupBox1.Controls.Add(Me.BtnFermer)
        Me.GroupBox1.Controls.Add(Me.BtnPrint)
        resources.ApplyResources(Me.GroupBox1, "GroupBox1")
        Me.GroupBox1.Name = "GroupBox1"
        Me.GroupBox1.TabStop = False
        '
        'BtnArchiverContEI
        '
        resources.ApplyResources(Me.BtnArchiverContEI, "BtnArchiverContEI")
        Me.BtnArchiverContEI.Name = "BtnArchiverContEI"
        Me.BtnArchiverContEI.UseVisualStyleBackColor = True
        '
        'BtnRelanceCont
        '
        resources.ApplyResources(Me.BtnRelanceCont, "BtnRelanceCont")
        Me.BtnRelanceCont.Name = "BtnRelanceCont"
        Me.BtnRelanceCont.UseVisualStyleBackColor = True
        '
        'BtnModifContratEI
        '
        resources.ApplyResources(Me.BtnModifContratEI, "BtnModifContratEI")
        Me.BtnModifContratEI.Name = "BtnModifContratEI"
        Me.BtnModifContratEI.UseVisualStyleBackColor = True
        '
        'btnCreerContratEI
        '
        resources.ApplyResources(Me.btnCreerContratEI, "btnCreerContratEI")
        Me.btnCreerContratEI.Name = "btnCreerContratEI"
        Me.btnCreerContratEI.UseVisualStyleBackColor = True
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
        'LabelTitre
        '
        resources.ApplyResources(Me.LabelTitre, "LabelTitre")
        Me.LabelTitre.Name = "LabelTitre"
        '
        'GrpApercu
        '
        Me.GrpApercu.Controls.Add(Me.WBApercu)
        resources.ApplyResources(Me.GrpApercu, "GrpApercu")
        Me.GrpApercu.Name = "GrpApercu"
        Me.GrpApercu.TabStop = False
        '
        'WBApercu
        '
        resources.ApplyResources(Me.WBApercu, "WBApercu")
        Me.WBApercu.Name = "WBApercu"
        '
        'frmListeClientsEI
        '
        resources.ApplyResources(Me, "$this")
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.Wheat
        Me.Controls.Add(Me.GrpApercu)
        Me.Controls.Add(Me.GCListeClientsEI)
        Me.Controls.Add(Me.GroupBox1)
        Me.Controls.Add(Me.LabelTitre)
        Me.Name = "frmListeClientsEI"
        Me.WindowState = System.Windows.Forms.FormWindowState.Maximized
        CType(Me.GCListeClientsEI, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.GVListeClientsEI, System.ComponentModel.ISupportInitialize).EndInit()
        Me.GroupBox1.ResumeLayout(False)
        Me.GrpApercu.ResumeLayout(False)
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents ButtonExporter As System.Windows.Forms.Button
    Friend WithEvents GroupBox1 As System.Windows.Forms.GroupBox
    Friend WithEvents BtnFermer As System.Windows.Forms.Button
    Friend WithEvents BtnPrint As System.Windows.Forms.Button
    Friend WithEvents LabelTitre As System.Windows.Forms.Label
    Friend WithEvents GrpApercu As System.Windows.Forms.GroupBox
    Friend WithEvents WBApercu As System.Windows.Forms.WebBrowser
    Friend WithEvents btnCreerContratEI As System.Windows.Forms.Button
    Friend WithEvents BtnModifContratEI As System.Windows.Forms.Button
    Friend WithEvents BtnRelanceCont As System.Windows.Forms.Button
    Friend WithEvents BtnArchiverContEI As System.Windows.Forms.Button
    Private WithEvents GCListeClientsEI As DevExpress.XtraGrid.GridControl
    Private WithEvents GVListeClientsEI As DevExpress.XtraGrid.Views.Grid.GridView
    Private WithEvents ColVCLINOM As DevExpress.XtraGrid.Columns.GridColumn
    Private WithEvents ColVCONTEI As DevExpress.XtraGrid.Columns.GridColumn
    Private WithEvents ColVLIBDATECHE As DevExpress.XtraGrid.Columns.GridColumn
    Private WithEvents ColVFICHIER As DevExpress.XtraGrid.Columns.GridColumn
    Private WithEvents ColVTITRE As DevExpress.XtraGrid.Columns.GridColumn
    Private WithEvents GColVCONTEISIGN As DevExpress.XtraGrid.Columns.GridColumn
    Private WithEvents DateCre As DevExpress.XtraGrid.Columns.GridColumn
    Private WithEvents NBEXTINCTEURS As DevExpress.XtraGrid.Columns.GridColumn
    Private WithEvents CA As DevExpress.XtraGrid.Columns.GridColumn
    Private WithEvents NCLINUM As DevExpress.XtraGrid.Columns.GridColumn
    Private WithEvents ColNIDPROC As DevExpress.XtraGrid.Columns.GridColumn
    Private WithEvents PASDECONTRATEI As DevExpress.XtraGrid.Columns.GridColumn
End Class
