<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmDetailReleveCompteur
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
        Dim SideBySideBarSeriesLabel1 As DevExpress.XtraCharts.SideBySideBarSeriesLabel = New DevExpress.XtraCharts.SideBySideBarSeriesLabel()
        Me.LblTitre = New System.Windows.Forms.Label()
        Me.cmdFermer = New MozartUC.apiButton()
        Me.GrpGraph = New System.Windows.Forms.GroupBox()
        Me.ChartGraph = New DevExpress.XtraCharts.ChartControl()
        Me.Panel1 = New System.Windows.Forms.Panel()
        Me.apiGridSite = New MozartUC.apiTGrid()
        Me.GrpGraph.SuspendLayout()
        CType(Me.ChartGraph, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(SideBySideBarSeriesLabel1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.Panel1.SuspendLayout()
        Me.SuspendLayout()
        '
        'LblTitre
        '
        Me.LblTitre.Font = New System.Drawing.Font("Arial", 13.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.LblTitre.ImeMode = System.Windows.Forms.ImeMode.NoControl
        Me.LblTitre.Location = New System.Drawing.Point(95, 18)
        Me.LblTitre.Name = "LblTitre"
        Me.LblTitre.Size = New System.Drawing.Size(701, 55)
        Me.LblTitre.TabIndex = 47
        Me.LblTitre.Text = "Compteur "
        '
        'cmdFermer
        '
        Me.cmdFermer.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Left), System.Windows.Forms.AnchorStyles)
        Me.cmdFermer.DialogResult = System.Windows.Forms.DialogResult.Cancel
        Me.cmdFermer.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold)
        Me.cmdFermer.HelpContextID = 0
        Me.cmdFermer.ImeMode = System.Windows.Forms.ImeMode.NoControl
        Me.cmdFermer.Location = New System.Drawing.Point(10, 594)
        Me.cmdFermer.Name = "cmdFermer"
        Me.cmdFermer.Size = New System.Drawing.Size(73, 57)
        Me.cmdFermer.TabIndex = 46
        Me.cmdFermer.Tag = "15"
        Me.cmdFermer.Text = "Fermer"
        Me.cmdFermer.UseVisualStyleBackColor = True
        '
        'GrpGraph
        '
        Me.GrpGraph.Controls.Add(Me.ChartGraph)
        Me.GrpGraph.Location = New System.Drawing.Point(421, 76)
        Me.GrpGraph.Name = "GrpGraph"
        Me.GrpGraph.Size = New System.Drawing.Size(1075, 575)
        Me.GrpGraph.TabIndex = 48
        Me.GrpGraph.TabStop = False
        '
        'ChartGraph
        '
        Me.ChartGraph.Dock = System.Windows.Forms.DockStyle.Fill
        Me.ChartGraph.Legend.Name = "Default Legend"
        Me.ChartGraph.Location = New System.Drawing.Point(3, 16)
        Me.ChartGraph.Name = "ChartGraph"
        Me.ChartGraph.SeriesSerializable = New DevExpress.XtraCharts.Series(-1) {}
        SideBySideBarSeriesLabel1.LineVisibility = DevExpress.Utils.DefaultBoolean.[True]
        Me.ChartGraph.SeriesTemplate.Label = SideBySideBarSeriesLabel1
        Me.ChartGraph.Size = New System.Drawing.Size(1069, 556)
        Me.ChartGraph.TabIndex = 0
        '
        'Panel1
        '
        Me.Panel1.Controls.Add(Me.apiGridSite)
        Me.Panel1.Location = New System.Drawing.Point(99, 76)
        Me.Panel1.Name = "Panel1"
        Me.Panel1.Size = New System.Drawing.Size(319, 575)
        Me.Panel1.TabIndex = 49
        '
        'apiGridSite
        '
        Me.apiGridSite.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
            Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.apiGridSite.FilterBar = True
        Me.apiGridSite.FooterBar = True
        Me.apiGridSite.Location = New System.Drawing.Point(3, 16)
        Me.apiGridSite.Name = "apiGridSite"
        Me.apiGridSite.Size = New System.Drawing.Size(313, 556)
        Me.apiGridSite.TabIndex = 45
        '
        'frmDetailReleveCompteur
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.Wheat
        Me.ClientSize = New System.Drawing.Size(1719, 1023)
        Me.Controls.Add(Me.Panel1)
        Me.Controls.Add(Me.GrpGraph)
        Me.Controls.Add(Me.LblTitre)
        Me.Controls.Add(Me.cmdFermer)
        Me.Name = "frmDetailReleveCompteur"
        Me.Text = "Relevés d'un compteur"
        Me.WindowState = System.Windows.Forms.FormWindowState.Maximized
        Me.GrpGraph.ResumeLayout(False)
        CType(SideBySideBarSeriesLabel1, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.ChartGraph, System.ComponentModel.ISupportInitialize).EndInit()
        Me.Panel1.ResumeLayout(False)
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents LblTitre As Label
    Private WithEvents cmdFermer As MozartUC.apiButton
    Friend WithEvents GrpGraph As GroupBox
    Private WithEvents ChartGraph As DevExpress.XtraCharts.ChartControl
    Friend WithEvents Panel1 As Panel
    Friend WithEvents apiGridSite As MozartUC.apiTGrid
End Class
