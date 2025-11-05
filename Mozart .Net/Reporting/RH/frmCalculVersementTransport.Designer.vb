<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmCalculVersementTransport
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(frmCalculVersementTransport))
        Me.GroupBox1 = New System.Windows.Forms.GroupBox()
        Me.BtnPrint = New System.Windows.Forms.Button()
        Me.ButtonExporter = New System.Windows.Forms.Button()
        Me.BtnFermer = New System.Windows.Forms.Button()
        Me.LabelTitre = New System.Windows.Forms.Label()
        Me.GridControl1 = New DevExpress.XtraGrid.GridControl()
        Me.GridView1 = New DevExpress.XtraGrid.Views.Grid.GridView()
        Me.ColRegion = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.Zone = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.Technicien = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.TempspasseZone = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.TempspasseRegion = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.TpsTrav = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.Pourcentage = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.PourcentageRegion = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.GrpPeriode = New System.Windows.Forms.GroupBox()
        Me.BtnValider = New System.Windows.Forms.Button()
        Me.CboAnnee = New DevExpress.XtraEditors.GridLookUpEdit()
        Me.GridView2 = New DevExpress.XtraGrid.Views.Grid.GridView()
        Me.GColCboAnneeNIDANNEE = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.CboMois = New DevExpress.XtraEditors.GridLookUpEdit()
        Me.GridCboMois = New DevExpress.XtraGrid.Views.Grid.GridView()
        Me.GColCboMoisNIDMOIS = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.GColCboMoisSMOISNAME = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.LabelInfo1 = New System.Windows.Forms.Label()
        Me.txtAnalyse = New System.Windows.Forms.TextBox()
        Me.GroupBox1.SuspendLayout()
        CType(Me.GridControl1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.GridView1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.GrpPeriode.SuspendLayout()
        CType(Me.CboAnnee.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.GridView2, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.CboMois.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.GridCboMois, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'GroupBox1
        '
        Me.GroupBox1.Controls.Add(Me.BtnPrint)
        Me.GroupBox1.Controls.Add(Me.ButtonExporter)
        Me.GroupBox1.Controls.Add(Me.BtnFermer)
        resources.ApplyResources(Me.GroupBox1, "GroupBox1")
        Me.GroupBox1.Name = "GroupBox1"
        Me.GroupBox1.TabStop = False
        '
        'BtnPrint
        '
        resources.ApplyResources(Me.BtnPrint, "BtnPrint")
        Me.BtnPrint.Name = "BtnPrint"
        Me.BtnPrint.UseVisualStyleBackColor = True
        '
        'ButtonExporter
        '
        resources.ApplyResources(Me.ButtonExporter, "ButtonExporter")
        Me.ButtonExporter.Name = "ButtonExporter"
        Me.ButtonExporter.UseVisualStyleBackColor = True
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
        Me.GridView1.Columns.AddRange(New DevExpress.XtraGrid.Columns.GridColumn() {Me.ColRegion, Me.Zone, Me.Technicien, Me.TempspasseZone, Me.TempspasseRegion, Me.TpsTrav, Me.Pourcentage, Me.PourcentageRegion})
        Me.GridView1.GridControl = Me.GridControl1
        Me.GridView1.HorzScrollVisibility = DevExpress.XtraGrid.Views.Base.ScrollVisibility.Always
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
        'ColRegion
        '
        Me.ColRegion.AppearanceHeader.ForeColor = System.Drawing.Color.Black
        Me.ColRegion.AppearanceHeader.Options.UseForeColor = True
        resources.ApplyResources(Me.ColRegion, "ColRegion")
        Me.ColRegion.FieldName = "REGION"
        Me.ColRegion.Name = "ColRegion"
        '
        'Zone
        '
        Me.Zone.AppearanceHeader.ForeColor = System.Drawing.Color.Black
        Me.Zone.AppearanceHeader.Options.UseForeColor = True
        resources.ApplyResources(Me.Zone, "Zone")
        Me.Zone.FieldName = "ZONE"
        Me.Zone.Name = "Zone"
        Me.Zone.OptionsFilter.AutoFilterCondition = DevExpress.XtraGrid.Columns.AutoFilterCondition.Contains
        Me.Zone.Summary.AddRange(New DevExpress.XtraGrid.GridSummaryItem() {New DevExpress.XtraGrid.GridColumnSummaryItem(CType(resources.GetObject("Zone.Summary"), DevExpress.Data.SummaryItemType))})
        '
        'Technicien
        '
        Me.Technicien.AppearanceHeader.ForeColor = System.Drawing.Color.Black
        Me.Technicien.AppearanceHeader.Options.UseForeColor = True
        resources.ApplyResources(Me.Technicien, "Technicien")
        Me.Technicien.FieldName = "NOM"
        Me.Technicien.Name = "Technicien"
        Me.Technicien.OptionsFilter.AutoFilterCondition = DevExpress.XtraGrid.Columns.AutoFilterCondition.Contains
        '
        'TempspasseZone
        '
        Me.TempspasseZone.AppearanceHeader.ForeColor = System.Drawing.Color.Black
        Me.TempspasseZone.AppearanceHeader.Options.UseForeColor = True
        resources.ApplyResources(Me.TempspasseZone, "TempspasseZone")
        Me.TempspasseZone.FieldName = "TPSPASSEZONE"
        Me.TempspasseZone.Name = "TempspasseZone"
        '
        'TempspasseRegion
        '
        Me.TempspasseRegion.AppearanceHeader.ForeColor = System.Drawing.Color.Black
        Me.TempspasseRegion.AppearanceHeader.Options.UseForeColor = True
        resources.ApplyResources(Me.TempspasseRegion, "TempspasseRegion")
        Me.TempspasseRegion.FieldName = "TPSPASSEREGION"
        Me.TempspasseRegion.Name = "TempspasseRegion"
        '
        'TpsTrav
        '
        Me.TpsTrav.AppearanceHeader.ForeColor = System.Drawing.Color.Black
        Me.TpsTrav.AppearanceHeader.Options.UseForeColor = True
        resources.ApplyResources(Me.TpsTrav, "TpsTrav")
        Me.TpsTrav.FieldName = "TPSTRAVAIL"
        Me.TpsTrav.Name = "TpsTrav"
        '
        'Pourcentage
        '
        Me.Pourcentage.AppearanceHeader.ForeColor = System.Drawing.Color.Black
        Me.Pourcentage.AppearanceHeader.Options.UseForeColor = True
        resources.ApplyResources(Me.Pourcentage, "Pourcentage")
        Me.Pourcentage.FieldName = "POURCENTAGE"
        Me.Pourcentage.Name = "Pourcentage"
        '
        'PourcentageRegion
        '
        Me.PourcentageRegion.AppearanceHeader.ForeColor = System.Drawing.Color.Black
        Me.PourcentageRegion.AppearanceHeader.Options.UseForeColor = True
        resources.ApplyResources(Me.PourcentageRegion, "PourcentageRegion")
        Me.PourcentageRegion.FieldName = "POURCENTAGEREGION"
        Me.PourcentageRegion.Name = "PourcentageRegion"
        '
        'GrpPeriode
        '
        Me.GrpPeriode.Controls.Add(Me.BtnValider)
        Me.GrpPeriode.Controls.Add(Me.CboAnnee)
        Me.GrpPeriode.Controls.Add(Me.CboMois)
        Me.GrpPeriode.Controls.Add(Me.Label2)
        Me.GrpPeriode.Controls.Add(Me.Label1)
        resources.ApplyResources(Me.GrpPeriode, "GrpPeriode")
        Me.GrpPeriode.Name = "GrpPeriode"
        Me.GrpPeriode.TabStop = False
        '
        'BtnValider
        '
        resources.ApplyResources(Me.BtnValider, "BtnValider")
        Me.BtnValider.Name = "BtnValider"
        Me.BtnValider.UseVisualStyleBackColor = True
        '
        'CboAnnee
        '
        resources.ApplyResources(Me.CboAnnee, "CboAnnee")
        Me.CboAnnee.Name = "CboAnnee"
        Me.CboAnnee.Properties.Appearance.Options.UseTextOptions = True
        Me.CboAnnee.Properties.Appearance.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center
        Me.CboAnnee.Properties.Appearance.TextOptions.VAlignment = DevExpress.Utils.VertAlignment.Center
        Me.CboAnnee.Properties.Buttons.AddRange(New DevExpress.XtraEditors.Controls.EditorButton() {New DevExpress.XtraEditors.Controls.EditorButton(CType(resources.GetObject("CboAnnee.Properties.Buttons"), DevExpress.XtraEditors.Controls.ButtonPredefines))})
        Me.CboAnnee.Properties.DisplayMember = "NIDANNEE"
        Me.CboAnnee.Properties.NullText = resources.GetString("CboAnnee.Properties.NullText")
        Me.CboAnnee.Properties.PopupFormSize = New System.Drawing.Size(200, 300)
        Me.CboAnnee.Properties.PopupSizeable = False
        Me.CboAnnee.Properties.PopupView = Me.GridView2
        Me.CboAnnee.Properties.ShowNullValuePrompt = CType((DevExpress.XtraEditors.ShowNullValuePromptOptions.EditorFocused Or DevExpress.XtraEditors.ShowNullValuePromptOptions.EditorReadOnly), DevExpress.XtraEditors.ShowNullValuePromptOptions)
        Me.CboAnnee.Properties.ValueMember = "NIDANNEE"
        '
        'GridView2
        '
        Me.GridView2.Columns.AddRange(New DevExpress.XtraGrid.Columns.GridColumn() {Me.GColCboAnneeNIDANNEE})
        Me.GridView2.FocusRectStyle = DevExpress.XtraGrid.Views.Grid.DrawFocusRectStyle.RowFocus
        Me.GridView2.Name = "GridView2"
        Me.GridView2.OptionsSelection.EnableAppearanceFocusedCell = False
        Me.GridView2.OptionsView.ShowGroupPanel = False
        '
        'GColCboAnneeNIDANNEE
        '
        Me.GColCboAnneeNIDANNEE.AppearanceCell.Options.UseTextOptions = True
        Me.GColCboAnneeNIDANNEE.AppearanceCell.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center
        Me.GColCboAnneeNIDANNEE.AppearanceCell.TextOptions.VAlignment = DevExpress.Utils.VertAlignment.Center
        Me.GColCboAnneeNIDANNEE.AppearanceHeader.Font = CType(resources.GetObject("GColCboAnneeNIDANNEE.AppearanceHeader.Font"), System.Drawing.Font)
        Me.GColCboAnneeNIDANNEE.AppearanceHeader.Options.UseFont = True
        Me.GColCboAnneeNIDANNEE.AppearanceHeader.Options.UseTextOptions = True
        Me.GColCboAnneeNIDANNEE.AppearanceHeader.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center
        Me.GColCboAnneeNIDANNEE.AppearanceHeader.TextOptions.VAlignment = DevExpress.Utils.VertAlignment.Center
        resources.ApplyResources(Me.GColCboAnneeNIDANNEE, "GColCboAnneeNIDANNEE")
        Me.GColCboAnneeNIDANNEE.FieldName = "NIDANNEE"
        Me.GColCboAnneeNIDANNEE.Name = "GColCboAnneeNIDANNEE"
        Me.GColCboAnneeNIDANNEE.OptionsColumn.AllowEdit = False
        Me.GColCboAnneeNIDANNEE.OptionsColumn.ReadOnly = True
        '
        'CboMois
        '
        resources.ApplyResources(Me.CboMois, "CboMois")
        Me.CboMois.Name = "CboMois"
        Me.CboMois.Properties.Appearance.Options.UseTextOptions = True
        Me.CboMois.Properties.Appearance.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center
        Me.CboMois.Properties.Appearance.TextOptions.VAlignment = DevExpress.Utils.VertAlignment.Center
        Me.CboMois.Properties.Buttons.AddRange(New DevExpress.XtraEditors.Controls.EditorButton() {New DevExpress.XtraEditors.Controls.EditorButton(CType(resources.GetObject("CboMois.Properties.Buttons"), DevExpress.XtraEditors.Controls.ButtonPredefines))})
        Me.CboMois.Properties.DisplayMember = "SMOISNAME"
        Me.CboMois.Properties.NullText = resources.GetString("CboMois.Properties.NullText")
        Me.CboMois.Properties.PopupFormSize = New System.Drawing.Size(120, 300)
        Me.CboMois.Properties.PopupSizeable = False
        Me.CboMois.Properties.PopupView = Me.GridCboMois
        Me.CboMois.Properties.ShowNullValuePrompt = CType((DevExpress.XtraEditors.ShowNullValuePromptOptions.EditorFocused Or DevExpress.XtraEditors.ShowNullValuePromptOptions.EditorReadOnly), DevExpress.XtraEditors.ShowNullValuePromptOptions)
        Me.CboMois.Properties.ValueMember = "NIDMOIS"
        '
        'GridCboMois
        '
        Me.GridCboMois.Columns.AddRange(New DevExpress.XtraGrid.Columns.GridColumn() {Me.GColCboMoisNIDMOIS, Me.GColCboMoisSMOISNAME})
        Me.GridCboMois.FocusRectStyle = DevExpress.XtraGrid.Views.Grid.DrawFocusRectStyle.RowFocus
        Me.GridCboMois.Name = "GridCboMois"
        Me.GridCboMois.OptionsSelection.EnableAppearanceFocusedCell = False
        Me.GridCboMois.OptionsView.ShowGroupPanel = False
        '
        'GColCboMoisNIDMOIS
        '
        resources.ApplyResources(Me.GColCboMoisNIDMOIS, "GColCboMoisNIDMOIS")
        Me.GColCboMoisNIDMOIS.FieldName = "NIDMOIS"
        Me.GColCboMoisNIDMOIS.Name = "GColCboMoisNIDMOIS"
        '
        'GColCboMoisSMOISNAME
        '
        Me.GColCboMoisSMOISNAME.AppearanceCell.Options.UseTextOptions = True
        Me.GColCboMoisSMOISNAME.AppearanceCell.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center
        Me.GColCboMoisSMOISNAME.AppearanceCell.TextOptions.VAlignment = DevExpress.Utils.VertAlignment.Center
        Me.GColCboMoisSMOISNAME.AppearanceHeader.Font = CType(resources.GetObject("GColCboMoisSMOISNAME.AppearanceHeader.Font"), System.Drawing.Font)
        Me.GColCboMoisSMOISNAME.AppearanceHeader.Options.UseFont = True
        Me.GColCboMoisSMOISNAME.AppearanceHeader.Options.UseTextOptions = True
        Me.GColCboMoisSMOISNAME.AppearanceHeader.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center
        Me.GColCboMoisSMOISNAME.AppearanceHeader.TextOptions.VAlignment = DevExpress.Utils.VertAlignment.Center
        resources.ApplyResources(Me.GColCboMoisSMOISNAME, "GColCboMoisSMOISNAME")
        Me.GColCboMoisSMOISNAME.FieldName = "SMOISNAME"
        Me.GColCboMoisSMOISNAME.Name = "GColCboMoisSMOISNAME"
        Me.GColCboMoisSMOISNAME.OptionsColumn.AllowEdit = False
        Me.GColCboMoisSMOISNAME.OptionsColumn.ReadOnly = True
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
        'LabelInfo1
        '
        resources.ApplyResources(Me.LabelInfo1, "LabelInfo1")
        Me.LabelInfo1.Name = "LabelInfo1"
        '
        'txtAnalyse
        '
        resources.ApplyResources(Me.txtAnalyse, "txtAnalyse")
        Me.txtAnalyse.Name = "txtAnalyse"
        Me.txtAnalyse.ReadOnly = True
        '
        'frmCalculVersementTransport
        '
        resources.ApplyResources(Me, "$this")
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.Wheat
        Me.Controls.Add(Me.txtAnalyse)
        Me.Controls.Add(Me.LabelInfo1)
        Me.Controls.Add(Me.GrpPeriode)
        Me.Controls.Add(Me.GridControl1)
        Me.Controls.Add(Me.GroupBox1)
        Me.Controls.Add(Me.LabelTitre)
        Me.Name = "frmCalculVersementTransport"
        Me.WindowState = System.Windows.Forms.FormWindowState.Maximized
        Me.GroupBox1.ResumeLayout(False)
        CType(Me.GridControl1, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.GridView1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.GrpPeriode.ResumeLayout(False)
        CType(Me.CboAnnee.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.GridView2, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.CboMois.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.GridCboMois, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents GroupBox1 As System.Windows.Forms.GroupBox
    Friend WithEvents ButtonExporter As System.Windows.Forms.Button
    Friend WithEvents BtnFermer As System.Windows.Forms.Button
    Friend WithEvents LabelTitre As System.Windows.Forms.Label
    Friend WithEvents GrpPeriode As System.Windows.Forms.GroupBox
    Friend WithEvents BtnValider As System.Windows.Forms.Button
    Friend WithEvents Label2 As System.Windows.Forms.Label
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents LabelInfo1 As System.Windows.Forms.Label
    Friend WithEvents txtAnalyse As System.Windows.Forms.TextBox
    Friend WithEvents BtnPrint As System.Windows.Forms.Button
    Private WithEvents GridControl1 As DevExpress.XtraGrid.GridControl
    Private WithEvents GridView1 As DevExpress.XtraGrid.Views.Grid.GridView
    Private WithEvents CboAnnee As DevExpress.XtraEditors.GridLookUpEdit
    Private WithEvents GridView2 As DevExpress.XtraGrid.Views.Grid.GridView
    Private WithEvents GColCboAnneeNIDANNEE As DevExpress.XtraGrid.Columns.GridColumn
    Private WithEvents CboMois As DevExpress.XtraEditors.GridLookUpEdit
    Private WithEvents GridCboMois As DevExpress.XtraGrid.Views.Grid.GridView
    Private WithEvents GColCboMoisNIDMOIS As DevExpress.XtraGrid.Columns.GridColumn
    Private WithEvents GColCboMoisSMOISNAME As DevExpress.XtraGrid.Columns.GridColumn
    Private WithEvents Zone As DevExpress.XtraGrid.Columns.GridColumn
    Private WithEvents Technicien As DevExpress.XtraGrid.Columns.GridColumn
    Private WithEvents TempspasseZone As DevExpress.XtraGrid.Columns.GridColumn
    Private WithEvents TpsTrav As DevExpress.XtraGrid.Columns.GridColumn
    Private WithEvents Pourcentage As DevExpress.XtraGrid.Columns.GridColumn
    Private WithEvents ColRegion As DevExpress.XtraGrid.Columns.GridColumn
    Private WithEvents TempspasseRegion As DevExpress.XtraGrid.Columns.GridColumn
    Private WithEvents PourcentageRegion As DevExpress.XtraGrid.Columns.GridColumn
End Class
