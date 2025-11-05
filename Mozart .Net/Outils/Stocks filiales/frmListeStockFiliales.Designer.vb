<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmListeStockFiliales
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(frmListeStockFiliales))
        Dim GridLevelNode1 As DevExpress.XtraGrid.GridLevelNode = New DevExpress.XtraGrid.GridLevelNode()
        Me.GCListeFournitures = New DevExpress.XtraGrid.GridControl()
        Me.GVListeStockEMALEC = New DevExpress.XtraGrid.Views.Grid.GridView()
        Me.SERIE = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.ARTICLE = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.MARQUE = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.TYPE = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.REFERENCE = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.EMPLACEMENT = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.PCB = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.QUANTITE = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.QTTCDE = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.MINI = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.MAXI = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.GESTION = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.GroupBox1 = New System.Windows.Forms.GroupBox()
        Me.BtnImprimer = New System.Windows.Forms.Button()
        Me.BtnFermer = New System.Windows.Forms.Button()
        Me.LblTitre = New System.Windows.Forms.Label()
        Me.LblSociete = New System.Windows.Forms.Label()
        Me.SDF = New System.Windows.Forms.SaveFileDialog()
        CType(Me.GCListeFournitures, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.GVListeStockEMALEC, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.GroupBox1.SuspendLayout()
        Me.SuspendLayout()
        '
        'GCListeFournitures
        '
        resources.ApplyResources(Me.GCListeFournitures, "GCListeFournitures")
        GridLevelNode1.RelationName = "Level1"
        Me.GCListeFournitures.LevelTree.Nodes.AddRange(New DevExpress.XtraGrid.GridLevelNode() {GridLevelNode1})
        Me.GCListeFournitures.MainView = Me.GVListeStockEMALEC
        Me.GCListeFournitures.Name = "GCListeFournitures"
        Me.GCListeFournitures.ViewCollection.AddRange(New DevExpress.XtraGrid.Views.Base.BaseView() {Me.GVListeStockEMALEC})
        '
        'GVListeStockEMALEC
        '
        Me.GVListeStockEMALEC.Columns.AddRange(New DevExpress.XtraGrid.Columns.GridColumn() {Me.SERIE, Me.ARTICLE, Me.MARQUE, Me.TYPE, Me.REFERENCE, Me.EMPLACEMENT, Me.PCB, Me.QUANTITE, Me.QTTCDE, Me.MINI, Me.MAXI, Me.GESTION})
        Me.GVListeStockEMALEC.GridControl = Me.GCListeFournitures
        Me.GVListeStockEMALEC.Name = "GVListeStockEMALEC"
        Me.GVListeStockEMALEC.OptionsBehavior.Editable = False
        Me.GVListeStockEMALEC.OptionsBehavior.ReadOnly = True
        Me.GVListeStockEMALEC.OptionsCustomization.AllowGroup = False
        Me.GVListeStockEMALEC.OptionsPrint.PrintPreview = True
        Me.GVListeStockEMALEC.OptionsView.ColumnAutoWidth = False
        Me.GVListeStockEMALEC.OptionsView.EnableAppearanceEvenRow = True
        Me.GVListeStockEMALEC.OptionsView.EnableAppearanceOddRow = True
        Me.GVListeStockEMALEC.OptionsView.ShowAutoFilterRow = True
        Me.GVListeStockEMALEC.OptionsView.ShowFooter = True
        Me.GVListeStockEMALEC.OptionsView.ShowGroupPanel = False
        '
        'SERIE
        '
        Me.SERIE.AppearanceHeader.FontStyleDelta = CType(resources.GetObject("SERIE.AppearanceHeader.FontStyleDelta"), System.Drawing.FontStyle)
        Me.SERIE.AppearanceHeader.ForeColor = System.Drawing.Color.Black
        Me.SERIE.AppearanceHeader.Options.UseFont = True
        Me.SERIE.AppearanceHeader.Options.UseForeColor = True
        Me.SERIE.AppearanceHeader.Options.UseTextOptions = True
        Me.SERIE.AppearanceHeader.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center
        resources.ApplyResources(Me.SERIE, "SERIE")
        Me.SERIE.FieldName = "VFOUSER"
        Me.SERIE.Name = "SERIE"
        Me.SERIE.Summary.AddRange(New DevExpress.XtraGrid.GridSummaryItem() {New DevExpress.XtraGrid.GridColumnSummaryItem(CType(resources.GetObject("SERIE.Summary"), DevExpress.Data.SummaryItemType))})
        '
        'ARTICLE
        '
        Me.ARTICLE.AppearanceHeader.FontStyleDelta = CType(resources.GetObject("ARTICLE.AppearanceHeader.FontStyleDelta"), System.Drawing.FontStyle)
        Me.ARTICLE.AppearanceHeader.ForeColor = System.Drawing.Color.Black
        Me.ARTICLE.AppearanceHeader.Options.UseFont = True
        Me.ARTICLE.AppearanceHeader.Options.UseForeColor = True
        Me.ARTICLE.AppearanceHeader.Options.UseTextOptions = True
        Me.ARTICLE.AppearanceHeader.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center
        resources.ApplyResources(Me.ARTICLE, "ARTICLE")
        Me.ARTICLE.FieldName = "VFOUMAT"
        Me.ARTICLE.Name = "ARTICLE"
        '
        'MARQUE
        '
        Me.MARQUE.AppearanceHeader.FontStyleDelta = CType(resources.GetObject("MARQUE.AppearanceHeader.FontStyleDelta"), System.Drawing.FontStyle)
        Me.MARQUE.AppearanceHeader.ForeColor = System.Drawing.Color.Black
        Me.MARQUE.AppearanceHeader.Options.UseFont = True
        Me.MARQUE.AppearanceHeader.Options.UseForeColor = True
        Me.MARQUE.AppearanceHeader.Options.UseTextOptions = True
        Me.MARQUE.AppearanceHeader.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center
        resources.ApplyResources(Me.MARQUE, "MARQUE")
        Me.MARQUE.FieldName = "VFOUMAR"
        Me.MARQUE.Name = "MARQUE"
        '
        'TYPE
        '
        Me.TYPE.AppearanceHeader.FontStyleDelta = CType(resources.GetObject("TYPE.AppearanceHeader.FontStyleDelta"), System.Drawing.FontStyle)
        Me.TYPE.AppearanceHeader.ForeColor = System.Drawing.Color.Black
        Me.TYPE.AppearanceHeader.Options.UseFont = True
        Me.TYPE.AppearanceHeader.Options.UseForeColor = True
        Me.TYPE.AppearanceHeader.Options.UseTextOptions = True
        Me.TYPE.AppearanceHeader.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center
        resources.ApplyResources(Me.TYPE, "TYPE")
        Me.TYPE.FieldName = "VFOUTYP"
        Me.TYPE.Name = "TYPE"
        '
        'REFERENCE
        '
        Me.REFERENCE.AppearanceCell.Options.UseTextOptions = True
        Me.REFERENCE.AppearanceCell.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center
        Me.REFERENCE.AppearanceHeader.FontStyleDelta = CType(resources.GetObject("REFERENCE.AppearanceHeader.FontStyleDelta"), System.Drawing.FontStyle)
        Me.REFERENCE.AppearanceHeader.ForeColor = System.Drawing.Color.Black
        Me.REFERENCE.AppearanceHeader.Options.UseFont = True
        Me.REFERENCE.AppearanceHeader.Options.UseForeColor = True
        Me.REFERENCE.AppearanceHeader.Options.UseTextOptions = True
        Me.REFERENCE.AppearanceHeader.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center
        resources.ApplyResources(Me.REFERENCE, "REFERENCE")
        Me.REFERENCE.FieldName = "VFOUREF"
        Me.REFERENCE.Name = "REFERENCE"
        '
        'EMPLACEMENT
        '
        Me.EMPLACEMENT.AppearanceCell.Options.UseTextOptions = True
        Me.EMPLACEMENT.AppearanceCell.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center
        Me.EMPLACEMENT.AppearanceHeader.FontStyleDelta = CType(resources.GetObject("EMPLACEMENT.AppearanceHeader.FontStyleDelta"), System.Drawing.FontStyle)
        Me.EMPLACEMENT.AppearanceHeader.ForeColor = System.Drawing.Color.Black
        Me.EMPLACEMENT.AppearanceHeader.Options.UseFont = True
        Me.EMPLACEMENT.AppearanceHeader.Options.UseForeColor = True
        Me.EMPLACEMENT.AppearanceHeader.Options.UseTextOptions = True
        Me.EMPLACEMENT.AppearanceHeader.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center
        resources.ApplyResources(Me.EMPLACEMENT, "EMPLACEMENT")
        Me.EMPLACEMENT.FieldName = "VFOUEMPLACEMENT"
        Me.EMPLACEMENT.Name = "EMPLACEMENT"
        '
        'PCB
        '
        Me.PCB.AppearanceCell.Options.UseTextOptions = True
        Me.PCB.AppearanceCell.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center
        Me.PCB.AppearanceHeader.FontStyleDelta = CType(resources.GetObject("PCB.AppearanceHeader.FontStyleDelta"), System.Drawing.FontStyle)
        Me.PCB.AppearanceHeader.ForeColor = System.Drawing.Color.Black
        Me.PCB.AppearanceHeader.Options.UseFont = True
        Me.PCB.AppearanceHeader.Options.UseForeColor = True
        Me.PCB.AppearanceHeader.Options.UseTextOptions = True
        Me.PCB.AppearanceHeader.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center
        resources.ApplyResources(Me.PCB, "PCB")
        Me.PCB.FieldName = "NFOUNBLOT"
        Me.PCB.Name = "PCB"
        '
        'QUANTITE
        '
        Me.QUANTITE.AppearanceCell.Options.UseTextOptions = True
        Me.QUANTITE.AppearanceCell.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center
        Me.QUANTITE.AppearanceHeader.FontStyleDelta = CType(resources.GetObject("QUANTITE.AppearanceHeader.FontStyleDelta"), System.Drawing.FontStyle)
        Me.QUANTITE.AppearanceHeader.ForeColor = System.Drawing.Color.Black
        Me.QUANTITE.AppearanceHeader.Options.UseFont = True
        Me.QUANTITE.AppearanceHeader.Options.UseForeColor = True
        Me.QUANTITE.AppearanceHeader.Options.UseTextOptions = True
        Me.QUANTITE.AppearanceHeader.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center
        resources.ApplyResources(Me.QUANTITE, "QUANTITE")
        Me.QUANTITE.FieldName = "NFOUQTESTOCK"
        Me.QUANTITE.Name = "QUANTITE"
        '
        'QTTCDE
        '
        Me.QTTCDE.AppearanceCell.Options.UseTextOptions = True
        Me.QTTCDE.AppearanceCell.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center
        Me.QTTCDE.AppearanceHeader.FontStyleDelta = CType(resources.GetObject("QTTCDE.AppearanceHeader.FontStyleDelta"), System.Drawing.FontStyle)
        Me.QTTCDE.AppearanceHeader.ForeColor = System.Drawing.Color.Black
        Me.QTTCDE.AppearanceHeader.Options.UseFont = True
        Me.QTTCDE.AppearanceHeader.Options.UseForeColor = True
        Me.QTTCDE.AppearanceHeader.Options.UseTextOptions = True
        Me.QTTCDE.AppearanceHeader.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center
        resources.ApplyResources(Me.QTTCDE, "QTTCDE")
        Me.QTTCDE.FieldName = "QteAttendue"
        Me.QTTCDE.Name = "QTTCDE"
        '
        'MINI
        '
        Me.MINI.AppearanceCell.Options.UseTextOptions = True
        Me.MINI.AppearanceCell.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center
        Me.MINI.AppearanceHeader.FontStyleDelta = CType(resources.GetObject("MINI.AppearanceHeader.FontStyleDelta"), System.Drawing.FontStyle)
        Me.MINI.AppearanceHeader.ForeColor = System.Drawing.Color.Black
        Me.MINI.AppearanceHeader.Options.UseFont = True
        Me.MINI.AppearanceHeader.Options.UseForeColor = True
        Me.MINI.AppearanceHeader.Options.UseTextOptions = True
        Me.MINI.AppearanceHeader.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center
        resources.ApplyResources(Me.MINI, "MINI")
        Me.MINI.FieldName = "MINI"
        Me.MINI.Name = "MINI"
        '
        'MAXI
        '
        Me.MAXI.AppearanceCell.Options.UseTextOptions = True
        Me.MAXI.AppearanceCell.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center
        Me.MAXI.AppearanceHeader.FontStyleDelta = CType(resources.GetObject("MAXI.AppearanceHeader.FontStyleDelta"), System.Drawing.FontStyle)
        Me.MAXI.AppearanceHeader.ForeColor = System.Drawing.Color.Black
        Me.MAXI.AppearanceHeader.Options.UseFont = True
        Me.MAXI.AppearanceHeader.Options.UseForeColor = True
        Me.MAXI.AppearanceHeader.Options.UseTextOptions = True
        Me.MAXI.AppearanceHeader.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center
        resources.ApplyResources(Me.MAXI, "MAXI")
        Me.MAXI.FieldName = "MAXI"
        Me.MAXI.Name = "MAXI"
        '
        'GESTION
        '
        Me.GESTION.AppearanceCell.Options.UseTextOptions = True
        Me.GESTION.AppearanceCell.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center
        Me.GESTION.AppearanceHeader.FontStyleDelta = CType(resources.GetObject("GESTION.AppearanceHeader.FontStyleDelta"), System.Drawing.FontStyle)
        Me.GESTION.AppearanceHeader.ForeColor = System.Drawing.Color.Black
        Me.GESTION.AppearanceHeader.Options.UseFont = True
        Me.GESTION.AppearanceHeader.Options.UseForeColor = True
        Me.GESTION.AppearanceHeader.Options.UseTextOptions = True
        Me.GESTION.AppearanceHeader.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center
        resources.ApplyResources(Me.GESTION, "GESTION")
        Me.GESTION.FieldName = "CODE"
        Me.GESTION.Name = "GESTION"
        '
        'GroupBox1
        '
        Me.GroupBox1.Controls.Add(Me.BtnImprimer)
        Me.GroupBox1.Controls.Add(Me.BtnFermer)
        resources.ApplyResources(Me.GroupBox1, "GroupBox1")
        Me.GroupBox1.Name = "GroupBox1"
        Me.GroupBox1.TabStop = False
        '
        'BtnImprimer
        '
        resources.ApplyResources(Me.BtnImprimer, "BtnImprimer")
        Me.BtnImprimer.Name = "BtnImprimer"
        Me.BtnImprimer.UseVisualStyleBackColor = True
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
        'LblSociete
        '
        resources.ApplyResources(Me.LblSociete, "LblSociete")
        Me.LblSociete.Name = "LblSociete"
        '
        'frmListeStockFiliales
        '
        resources.ApplyResources(Me, "$this")
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.Wheat
        Me.Controls.Add(Me.LblSociete)
        Me.Controls.Add(Me.LblTitre)
        Me.Controls.Add(Me.GroupBox1)
        Me.Controls.Add(Me.GCListeFournitures)
        Me.Name = "frmListeStockFiliales"
        Me.WindowState = System.Windows.Forms.FormWindowState.Maximized
        CType(Me.GCListeFournitures, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.GVListeStockEMALEC, System.ComponentModel.ISupportInitialize).EndInit()
        Me.GroupBox1.ResumeLayout(False)
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
  Friend WithEvents BtnFermer As System.Windows.Forms.Button
  Private WithEvents GVListeStockEMALEC As DevExpress.XtraGrid.Views.Grid.GridView
  Private WithEvents GCListeFournitures As DevExpress.XtraGrid.GridControl
  Private WithEvents SERIE As DevExpress.XtraGrid.Columns.GridColumn
  Private WithEvents ARTICLE As DevExpress.XtraGrid.Columns.GridColumn
  Private WithEvents MARQUE As DevExpress.XtraGrid.Columns.GridColumn
  Private WithEvents TYPE As DevExpress.XtraGrid.Columns.GridColumn
  Private WithEvents REFERENCE As DevExpress.XtraGrid.Columns.GridColumn
  Private WithEvents EMPLACEMENT As DevExpress.XtraGrid.Columns.GridColumn
  Private WithEvents PCB As DevExpress.XtraGrid.Columns.GridColumn
  Private WithEvents QUANTITE As DevExpress.XtraGrid.Columns.GridColumn
  Private WithEvents QTTCDE As DevExpress.XtraGrid.Columns.GridColumn
  Private WithEvents MINI As DevExpress.XtraGrid.Columns.GridColumn
  Private WithEvents MAXI As DevExpress.XtraGrid.Columns.GridColumn
  Private WithEvents GESTION As DevExpress.XtraGrid.Columns.GridColumn
  Private WithEvents GroupBox1 As System.Windows.Forms.GroupBox
  Friend WithEvents LblTitre As System.Windows.Forms.Label
  Friend WithEvents LblSociete As System.Windows.Forms.Label
  Friend WithEvents BtnImprimer As System.Windows.Forms.Button
  Friend WithEvents SDF As System.Windows.Forms.SaveFileDialog
End Class
