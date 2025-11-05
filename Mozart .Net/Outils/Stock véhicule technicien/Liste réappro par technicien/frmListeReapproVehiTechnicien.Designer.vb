<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmListeReapproVehiTechnicien
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
    Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(frmListeReapproVehiTechnicien))
    Me.GCListeReapproVehiculeTechnicien = New DevExpress.XtraGrid.GridControl()
    Me.GVListereapproVehiculeTech = New DevExpress.XtraGrid.Views.Grid.GridView()
    Me.VPERNOM = New DevExpress.XtraGrid.Columns.GridColumn()
    Me.VPERPRE = New DevExpress.XtraGrid.Columns.GridColumn()
    Me.VSERLIB = New DevExpress.XtraGrid.Columns.GridColumn()
    Me.MULTITECH = New DevExpress.XtraGrid.Columns.GridColumn()
    Me.CLIM = New DevExpress.XtraGrid.Columns.GridColumn()
    Me.CFAIBLE = New DevExpress.XtraGrid.Columns.GridColumn()
    Me.CFORT = New DevExpress.XtraGrid.Columns.GridColumn()
    Me.EXTINCTION = New DevExpress.XtraGrid.Columns.GridColumn()
    Me.MULTIEI = New DevExpress.XtraGrid.Columns.GridColumn()
    Me.PLOMBERIE = New DevExpress.XtraGrid.Columns.GridColumn()
    Me.ED = New DevExpress.XtraGrid.Columns.GridColumn()
    Me.ARGEDIS = New DevExpress.XtraGrid.Columns.GridColumn()
    Me.GUNNEBO = New DevExpress.XtraGrid.Columns.GridColumn()
    Me.PHOTOVOLTAIQUE = New DevExpress.XtraGrid.Columns.GridColumn()
    Me.COUVERTURE = New DevExpress.XtraGrid.Columns.GridColumn()
    Me.VISSERIE = New DevExpress.XtraGrid.Columns.GridColumn()
    Me.GroupBox1 = New System.Windows.Forms.GroupBox()
        Me.BtnExportXLS = New System.Windows.Forms.Button()
        Me.BtnFermer = New System.Windows.Forms.Button()
        Me.LabelTitre = New System.Windows.Forms.Label()
        Me.SFD = New System.Windows.Forms.SaveFileDialog()
        CType(Me.GCListeReapproVehiculeTechnicien, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.GVListereapproVehiculeTech, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.GroupBox1.SuspendLayout()
        Me.SuspendLayout()
        '
        'GCListeReapproVehiculeTechnicien
        '
        resources.ApplyResources(Me.GCListeReapproVehiculeTechnicien, "GCListeReapproVehiculeTechnicien")
        Me.GCListeReapproVehiculeTechnicien.MainView = Me.GVListereapproVehiculeTech
        Me.GCListeReapproVehiculeTechnicien.Name = "GCListeReapproVehiculeTechnicien"
        Me.GCListeReapproVehiculeTechnicien.ViewCollection.AddRange(New DevExpress.XtraGrid.Views.Base.BaseView() {Me.GVListereapproVehiculeTech})
        '
        'GVListereapproVehiculeTech
        '
        Me.GVListereapproVehiculeTech.Columns.AddRange(New DevExpress.XtraGrid.Columns.GridColumn() {Me.VPERNOM, Me.VPERPRE, Me.VSERLIB, Me.MULTITECH, Me.CLIM, Me.CFAIBLE, Me.CFORT, Me.EXTINCTION, Me.MULTIEI, Me.PLOMBERIE, Me.ED, Me.ARGEDIS, Me.GUNNEBO, Me.PHOTOVOLTAIQUE, Me.COUVERTURE, Me.VISSERIE})
        Me.GVListereapproVehiculeTech.GridControl = Me.GCListeReapproVehiculeTechnicien
        Me.GVListereapproVehiculeTech.Name = "GVListereapproVehiculeTech"
        Me.GVListereapproVehiculeTech.OptionsBehavior.Editable = False
        Me.GVListereapproVehiculeTech.OptionsBehavior.ReadOnly = True
        Me.GVListereapproVehiculeTech.OptionsCustomization.AllowGroup = False
        Me.GVListereapproVehiculeTech.OptionsPrint.PrintPreview = True
        Me.GVListereapproVehiculeTech.OptionsView.ColumnAutoWidth = False
        Me.GVListereapproVehiculeTech.OptionsView.EnableAppearanceEvenRow = True
        Me.GVListereapproVehiculeTech.OptionsView.EnableAppearanceOddRow = True
        Me.GVListereapproVehiculeTech.OptionsView.ShowAutoFilterRow = True
        Me.GVListereapproVehiculeTech.OptionsView.ShowFooter = True
        Me.GVListereapproVehiculeTech.OptionsView.ShowGroupPanel = False
        '
        'VPERNOM
        '
        Me.VPERNOM.AppearanceCell.Options.UseTextOptions = True
        Me.VPERNOM.AppearanceCell.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center
        Me.VPERNOM.AppearanceHeader.FontStyleDelta = CType(resources.GetObject("VPERNOM.AppearanceHeader.FontStyleDelta"), System.Drawing.FontStyle)
        Me.VPERNOM.AppearanceHeader.ForeColor = System.Drawing.Color.Black
        Me.VPERNOM.AppearanceHeader.Options.UseFont = True
        Me.VPERNOM.AppearanceHeader.Options.UseForeColor = True
        Me.VPERNOM.AppearanceHeader.Options.UseTextOptions = True
        Me.VPERNOM.AppearanceHeader.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center
        resources.ApplyResources(Me.VPERNOM, "VPERNOM")
        Me.VPERNOM.FieldName = "vpernom"
        Me.VPERNOM.Name = "VPERNOM"
        Me.VPERNOM.Summary.AddRange(New DevExpress.XtraGrid.GridSummaryItem() {New DevExpress.XtraGrid.GridColumnSummaryItem(CType(resources.GetObject("VPERNOM.Summary"), DevExpress.Data.SummaryItemType))})
        '
        'VPERPRE
        '
        Me.VPERPRE.AppearanceCell.Options.UseTextOptions = True
        Me.VPERPRE.AppearanceCell.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center
        Me.VPERPRE.AppearanceHeader.FontStyleDelta = CType(resources.GetObject("VPERPRE.AppearanceHeader.FontStyleDelta"), System.Drawing.FontStyle)
        Me.VPERPRE.AppearanceHeader.ForeColor = System.Drawing.Color.Black
        Me.VPERPRE.AppearanceHeader.Options.UseFont = True
        Me.VPERPRE.AppearanceHeader.Options.UseForeColor = True
        Me.VPERPRE.AppearanceHeader.Options.UseTextOptions = True
        Me.VPERPRE.AppearanceHeader.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center
        resources.ApplyResources(Me.VPERPRE, "VPERPRE")
        Me.VPERPRE.FieldName = "vperpre"
        Me.VPERPRE.Name = "VPERPRE"
        '
        'VSERLIB
        '
        Me.VSERLIB.AppearanceCell.Options.UseTextOptions = True
        Me.VSERLIB.AppearanceCell.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center
        Me.VSERLIB.AppearanceHeader.FontStyleDelta = CType(resources.GetObject("VSERLIB.AppearanceHeader.FontStyleDelta"), System.Drawing.FontStyle)
        Me.VSERLIB.AppearanceHeader.ForeColor = System.Drawing.Color.Black
        Me.VSERLIB.AppearanceHeader.Options.UseFont = True
        Me.VSERLIB.AppearanceHeader.Options.UseForeColor = True
        Me.VSERLIB.AppearanceHeader.Options.UseTextOptions = True
        Me.VSERLIB.AppearanceHeader.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center
        resources.ApplyResources(Me.VSERLIB, "VSERLIB")
        Me.VSERLIB.FieldName = "vserlib"
        Me.VSERLIB.Name = "VSERLIB"
        Me.VSERLIB.OptionsFilter.AutoFilterCondition = DevExpress.XtraGrid.Columns.AutoFilterCondition.[Like]
        '
        'MULTITECH
        '
        Me.MULTITECH.AppearanceCell.Options.UseTextOptions = True
        Me.MULTITECH.AppearanceCell.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center
        Me.MULTITECH.AppearanceHeader.FontStyleDelta = CType(resources.GetObject("MULTITECH.AppearanceHeader.FontStyleDelta"), System.Drawing.FontStyle)
        Me.MULTITECH.AppearanceHeader.ForeColor = System.Drawing.Color.Black
        Me.MULTITECH.AppearanceHeader.Options.UseFont = True
        Me.MULTITECH.AppearanceHeader.Options.UseForeColor = True
        Me.MULTITECH.AppearanceHeader.Options.UseTextOptions = True
        Me.MULTITECH.AppearanceHeader.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center
        resources.ApplyResources(Me.MULTITECH, "MULTITECH")
        Me.MULTITECH.FieldName = "M"
        Me.MULTITECH.Name = "MULTITECH"
        '
        'CLIM
        '
        Me.CLIM.AppearanceCell.Options.UseTextOptions = True
        Me.CLIM.AppearanceCell.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center
        Me.CLIM.AppearanceHeader.FontStyleDelta = CType(resources.GetObject("CLIM.AppearanceHeader.FontStyleDelta"), System.Drawing.FontStyle)
        Me.CLIM.AppearanceHeader.ForeColor = System.Drawing.Color.Black
        Me.CLIM.AppearanceHeader.Options.UseFont = True
        Me.CLIM.AppearanceHeader.Options.UseForeColor = True
        Me.CLIM.AppearanceHeader.Options.UseTextOptions = True
        Me.CLIM.AppearanceHeader.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center
        resources.ApplyResources(Me.CLIM, "CLIM")
        Me.CLIM.FieldName = "C"
        Me.CLIM.Name = "CLIM"
        '
        'CFAIBLE
        '
        Me.CFAIBLE.AppearanceCell.Options.UseTextOptions = True
        Me.CFAIBLE.AppearanceCell.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center
        Me.CFAIBLE.AppearanceHeader.FontStyleDelta = CType(resources.GetObject("CFAIBLE.AppearanceHeader.FontStyleDelta"), System.Drawing.FontStyle)
        Me.CFAIBLE.AppearanceHeader.ForeColor = System.Drawing.Color.Black
        Me.CFAIBLE.AppearanceHeader.Options.UseFont = True
        Me.CFAIBLE.AppearanceHeader.Options.UseForeColor = True
        Me.CFAIBLE.AppearanceHeader.Options.UseTextOptions = True
        Me.CFAIBLE.AppearanceHeader.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center
        resources.ApplyResources(Me.CFAIBLE, "CFAIBLE")
        Me.CFAIBLE.FieldName = "CFA"
        Me.CFAIBLE.Name = "CFAIBLE"
        '
        'CFORT
        '
        Me.CFORT.AppearanceCell.Options.UseTextOptions = True
        Me.CFORT.AppearanceCell.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center
        Me.CFORT.AppearanceHeader.FontStyleDelta = CType(resources.GetObject("CFORT.AppearanceHeader.FontStyleDelta"), System.Drawing.FontStyle)
        Me.CFORT.AppearanceHeader.ForeColor = System.Drawing.Color.Black
        Me.CFORT.AppearanceHeader.Options.UseFont = True
        Me.CFORT.AppearanceHeader.Options.UseForeColor = True
        Me.CFORT.AppearanceHeader.Options.UseTextOptions = True
        Me.CFORT.AppearanceHeader.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center
        resources.ApplyResources(Me.CFORT, "CFORT")
        Me.CFORT.FieldName = "CFO"
        Me.CFORT.GroupInterval = DevExpress.XtraGrid.ColumnGroupInterval.[Date]
        Me.CFORT.Name = "CFORT"
        '
        'EXTINCTION
        '
        Me.EXTINCTION.AppearanceCell.Options.UseTextOptions = True
        Me.EXTINCTION.AppearanceCell.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center
        Me.EXTINCTION.AppearanceHeader.FontStyleDelta = CType(resources.GetObject("EXTINCTION.AppearanceHeader.FontStyleDelta"), System.Drawing.FontStyle)
        Me.EXTINCTION.AppearanceHeader.ForeColor = System.Drawing.Color.Black
        Me.EXTINCTION.AppearanceHeader.Options.UseFont = True
        Me.EXTINCTION.AppearanceHeader.Options.UseForeColor = True
        Me.EXTINCTION.AppearanceHeader.Options.UseTextOptions = True
        Me.EXTINCTION.AppearanceHeader.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center
        resources.ApplyResources(Me.EXTINCTION, "EXTINCTION")
        Me.EXTINCTION.FieldName = "EI"
        Me.EXTINCTION.Name = "EXTINCTION"
        '
        'MULTIEI
        '
        Me.MULTIEI.AppearanceCell.Options.UseTextOptions = True
        Me.MULTIEI.AppearanceCell.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center
        Me.MULTIEI.AppearanceHeader.FontStyleDelta = CType(resources.GetObject("MULTIEI.AppearanceHeader.FontStyleDelta"), System.Drawing.FontStyle)
        Me.MULTIEI.AppearanceHeader.ForeColor = System.Drawing.Color.Black
        Me.MULTIEI.AppearanceHeader.Options.UseFont = True
        Me.MULTIEI.AppearanceHeader.Options.UseForeColor = True
        Me.MULTIEI.AppearanceHeader.Options.UseTextOptions = True
        Me.MULTIEI.AppearanceHeader.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center
        resources.ApplyResources(Me.MULTIEI, "MULTIEI")
        Me.MULTIEI.FieldName = "MEI"
        Me.MULTIEI.Name = "MULTIEI"
        '
        'PLOMBERIE
        '
        Me.PLOMBERIE.AppearanceCell.Options.UseTextOptions = True
        Me.PLOMBERIE.AppearanceCell.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center
        Me.PLOMBERIE.AppearanceHeader.FontStyleDelta = CType(resources.GetObject("PLOMBERIE.AppearanceHeader.FontStyleDelta"), System.Drawing.FontStyle)
        Me.PLOMBERIE.AppearanceHeader.ForeColor = System.Drawing.Color.Black
        Me.PLOMBERIE.AppearanceHeader.Options.UseFont = True
        Me.PLOMBERIE.AppearanceHeader.Options.UseForeColor = True
        Me.PLOMBERIE.AppearanceHeader.Options.UseTextOptions = True
        Me.PLOMBERIE.AppearanceHeader.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center
        resources.ApplyResources(Me.PLOMBERIE, "PLOMBERIE")
        Me.PLOMBERIE.FieldName = "P"
        Me.PLOMBERIE.Name = "PLOMBERIE"
        '
        'ED
        '
        Me.ED.AppearanceCell.Options.UseTextOptions = True
        Me.ED.AppearanceCell.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center
        Me.ED.AppearanceHeader.FontStyleDelta = CType(resources.GetObject("ED.AppearanceHeader.FontStyleDelta"), System.Drawing.FontStyle)
        Me.ED.AppearanceHeader.ForeColor = System.Drawing.Color.Black
        Me.ED.AppearanceHeader.Options.UseFont = True
        Me.ED.AppearanceHeader.Options.UseForeColor = True
        Me.ED.AppearanceHeader.Options.UseTextOptions = True
        Me.ED.AppearanceHeader.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center
        resources.ApplyResources(Me.ED, "ED")
        Me.ED.FieldName = "ED"
        Me.ED.Name = "ED"
        '
        'ARGEDIS
        '
        Me.ARGEDIS.AppearanceCell.Options.UseTextOptions = True
        Me.ARGEDIS.AppearanceCell.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center
        Me.ARGEDIS.AppearanceHeader.FontStyleDelta = CType(resources.GetObject("ARGEDIS.AppearanceHeader.FontStyleDelta"), System.Drawing.FontStyle)
        Me.ARGEDIS.AppearanceHeader.ForeColor = System.Drawing.Color.Black
        Me.ARGEDIS.AppearanceHeader.Options.UseFont = True
        Me.ARGEDIS.AppearanceHeader.Options.UseForeColor = True
        Me.ARGEDIS.AppearanceHeader.Options.UseTextOptions = True
        Me.ARGEDIS.AppearanceHeader.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center
        resources.ApplyResources(Me.ARGEDIS, "ARGEDIS")
        Me.ARGEDIS.FieldName = "AR"
        Me.ARGEDIS.Name = "ARGEDIS"
        '
        'GUNNEBO
        '
        Me.GUNNEBO.AppearanceCell.Options.UseTextOptions = True
        Me.GUNNEBO.AppearanceCell.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center
        Me.GUNNEBO.AppearanceHeader.FontStyleDelta = CType(resources.GetObject("GUNNEBO.AppearanceHeader.FontStyleDelta"), System.Drawing.FontStyle)
        Me.GUNNEBO.AppearanceHeader.ForeColor = System.Drawing.Color.Black
        Me.GUNNEBO.AppearanceHeader.Options.UseFont = True
        Me.GUNNEBO.AppearanceHeader.Options.UseForeColor = True
        Me.GUNNEBO.AppearanceHeader.Options.UseTextOptions = True
        Me.GUNNEBO.AppearanceHeader.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center
        resources.ApplyResources(Me.GUNNEBO, "GUNNEBO")
        Me.GUNNEBO.FieldName = "GU"
        Me.GUNNEBO.Name = "GUNNEBO"
        '
        'PHOTOVOLTAIQUE
        '
        Me.PHOTOVOLTAIQUE.AppearanceCell.Options.UseTextOptions = True
        Me.PHOTOVOLTAIQUE.AppearanceCell.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center
        Me.PHOTOVOLTAIQUE.AppearanceHeader.FontStyleDelta = CType(resources.GetObject("PHOTOVOLTAIQUE.AppearanceHeader.FontStyleDelta"), System.Drawing.FontStyle)
        Me.PHOTOVOLTAIQUE.AppearanceHeader.ForeColor = System.Drawing.Color.Black
        Me.PHOTOVOLTAIQUE.AppearanceHeader.Options.UseFont = True
        Me.PHOTOVOLTAIQUE.AppearanceHeader.Options.UseForeColor = True
        Me.PHOTOVOLTAIQUE.AppearanceHeader.Options.UseTextOptions = True
        Me.PHOTOVOLTAIQUE.AppearanceHeader.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center
        resources.ApplyResources(Me.PHOTOVOLTAIQUE, "PHOTOVOLTAIQUE")
        Me.PHOTOVOLTAIQUE.FieldName = "PH"
        Me.PHOTOVOLTAIQUE.Name = "PHOTOVOLTAIQUE"
        '
        'COUVERTURE
        '
        Me.COUVERTURE.AppearanceCell.Options.UseTextOptions = True
        Me.COUVERTURE.AppearanceCell.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center
        Me.COUVERTURE.AppearanceHeader.FontStyleDelta = CType(resources.GetObject("COUVERTURE.AppearanceHeader.FontStyleDelta"), System.Drawing.FontStyle)
        Me.COUVERTURE.AppearanceHeader.ForeColor = System.Drawing.Color.Black
        Me.COUVERTURE.AppearanceHeader.Options.UseFont = True
        Me.COUVERTURE.AppearanceHeader.Options.UseForeColor = True
        Me.COUVERTURE.AppearanceHeader.Options.UseTextOptions = True
        Me.COUVERTURE.AppearanceHeader.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center
        resources.ApplyResources(Me.COUVERTURE, "COUVERTURE")
        Me.COUVERTURE.FieldName = "COU"
        Me.COUVERTURE.Name = "COUVERTURE"
        '
        'VISSERIE
        '
        Me.VISSERIE.AppearanceCell.Options.UseTextOptions = True
        Me.VISSERIE.AppearanceCell.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center
        Me.VISSERIE.AppearanceHeader.FontStyleDelta = CType(resources.GetObject("VISSERIE.AppearanceHeader.FontStyleDelta"), System.Drawing.FontStyle)
        Me.VISSERIE.AppearanceHeader.ForeColor = System.Drawing.Color.Black
        Me.VISSERIE.AppearanceHeader.Options.UseFont = True
        Me.VISSERIE.AppearanceHeader.Options.UseForeColor = True
        Me.VISSERIE.AppearanceHeader.Options.UseTextOptions = True
        Me.VISSERIE.AppearanceHeader.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center
        resources.ApplyResources(Me.VISSERIE, "VISSERIE")
        Me.VISSERIE.FieldName = "V"
        Me.VISSERIE.Name = "VISSERIE"
        '
        'GroupBox1
        '
        Me.GroupBox1.Controls.Add(Me.BtnExportXLS)
        Me.GroupBox1.Controls.Add(Me.BtnFermer)
        resources.ApplyResources(Me.GroupBox1, "GroupBox1")
        Me.GroupBox1.Name = "GroupBox1"
        Me.GroupBox1.TabStop = False
        '
        'BtnExportXLS
        '
        Me.BtnExportXLS.BackColor = System.Drawing.Color.LightYellow
        resources.ApplyResources(Me.BtnExportXLS, "BtnExportXLS")
        Me.BtnExportXLS.Name = "BtnExportXLS"
        Me.BtnExportXLS.UseVisualStyleBackColor = False
        '
        'BtnFermer
        '
        resources.ApplyResources(Me.BtnFermer, "BtnFermer")
        Me.BtnFermer.Name = "BtnFermer"
        Me.BtnFermer.UseVisualStyleBackColor = True
        '
        'LabelTitre
        '
        resources.ApplyResources(Me.LabelTitre, "LabelTitre")
        Me.LabelTitre.Name = "LabelTitre"
        '
        'frmListeReapproVehiTechnicien
        '
        resources.ApplyResources(Me, "$this")
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.Wheat
        Me.Controls.Add(Me.LabelTitre)
        Me.Controls.Add(Me.GroupBox1)
        Me.Controls.Add(Me.GCListeReapproVehiculeTechnicien)
        Me.Name = "frmListeReapproVehiTechnicien"
        Me.Tag = "45"
        Me.WindowState = System.Windows.Forms.FormWindowState.Maximized
        CType(Me.GCListeReapproVehiculeTechnicien, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.GVListereapproVehiculeTech, System.ComponentModel.ISupportInitialize).EndInit()
        Me.GroupBox1.ResumeLayout(False)
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents GCListeReapproVehiculeTechnicien As DevExpress.XtraGrid.GridControl
    Private WithEvents VPERNOM As DevExpress.XtraGrid.Columns.GridColumn
    Private WithEvents VPERPRE As DevExpress.XtraGrid.Columns.GridColumn
    Private WithEvents VSERLIB As DevExpress.XtraGrid.Columns.GridColumn
    Private WithEvents MULTITECH As DevExpress.XtraGrid.Columns.GridColumn
    Private WithEvents CLIM As DevExpress.XtraGrid.Columns.GridColumn
    Private WithEvents CFAIBLE As DevExpress.XtraGrid.Columns.GridColumn
    Private WithEvents CFORT As DevExpress.XtraGrid.Columns.GridColumn
    Private WithEvents EXTINCTION As DevExpress.XtraGrid.Columns.GridColumn
    Private WithEvents MULTIEI As DevExpress.XtraGrid.Columns.GridColumn
    Private WithEvents PLOMBERIE As DevExpress.XtraGrid.Columns.GridColumn
    Private WithEvents ED As DevExpress.XtraGrid.Columns.GridColumn
    Private WithEvents ARGEDIS As DevExpress.XtraGrid.Columns.GridColumn
    Private WithEvents GUNNEBO As DevExpress.XtraGrid.Columns.GridColumn
    Private WithEvents PHOTOVOLTAIQUE As DevExpress.XtraGrid.Columns.GridColumn
    Private WithEvents COUVERTURE As DevExpress.XtraGrid.Columns.GridColumn
    Private WithEvents VISSERIE As DevExpress.XtraGrid.Columns.GridColumn
    Private WithEvents GVListereapproVehiculeTech As DevExpress.XtraGrid.Views.Grid.GridView
    Friend WithEvents GroupBox1 As System.Windows.Forms.GroupBox
    Friend WithEvents BtnFermer As System.Windows.Forms.Button
    Friend WithEvents LabelTitre As System.Windows.Forms.Label
    Friend WithEvents BtnExportXLS As Button
    Friend WithEvents SFD As SaveFileDialog
End Class
