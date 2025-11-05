<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmStatCAClientParAN
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
    Me.GrpActions = New System.Windows.Forms.GroupBox()
    Me.BtnFermer = New System.Windows.Forms.Button()
    Me.BtnPrint = New System.Windows.Forms.Button()
    Me.GrpGraph = New System.Windows.Forms.GroupBox()
    Me.ChartGraph = New DevExpress.XtraCharts.ChartControl()
    Me.lblSociete = New System.Windows.Forms.Label()
        Me.GrpActions.SuspendLayout()
        Me.GrpGraph.SuspendLayout()
        CType(Me.ChartGraph, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(SideBySideBarSeriesLabel1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'LblTitre
        '
        Me.LblTitre.AutoSize = True
        Me.LblTitre.Font = New System.Drawing.Font("Arial", 18.0!, System.Drawing.FontStyle.Bold)
        Me.LblTitre.ImeMode = System.Windows.Forms.ImeMode.NoControl
        Me.LblTitre.Location = New System.Drawing.Point(132, 19)
        Me.LblTitre.Name = "LblTitre"
        Me.LblTitre.Size = New System.Drawing.Size(461, 29)
        Me.LblTitre.TabIndex = 95
        Me.LblTitre.Text = "Evolution du chiffre d'affaire du client :"
        '
        'GrpActions
        '
        Me.GrpActions.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
            Or System.Windows.Forms.AnchorStyles.Left), System.Windows.Forms.AnchorStyles)
        Me.GrpActions.Controls.Add(Me.BtnFermer)
        Me.GrpActions.Controls.Add(Me.BtnPrint)
        Me.GrpActions.Location = New System.Drawing.Point(10, 9)
        Me.GrpActions.Name = "GrpActions"
        Me.GrpActions.Size = New System.Drawing.Size(107, 669)
        Me.GrpActions.TabIndex = 94
        Me.GrpActions.TabStop = False
        '
        'BtnFermer
        '
        Me.BtnFermer.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Left), System.Windows.Forms.AnchorStyles)
        Me.BtnFermer.DialogResult = System.Windows.Forms.DialogResult.Cancel
        Me.BtnFermer.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold)
        Me.BtnFermer.ImeMode = System.Windows.Forms.ImeMode.NoControl
        Me.BtnFermer.Location = New System.Drawing.Point(6, 615)
        Me.BtnFermer.Name = "BtnFermer"
        Me.BtnFermer.Size = New System.Drawing.Size(95, 48)
        Me.BtnFermer.TabIndex = 1
        Me.BtnFermer.Text = "Fermer"
        Me.BtnFermer.UseVisualStyleBackColor = True
        '
        'BtnPrint
        '
        Me.BtnPrint.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold)
        Me.BtnPrint.ImeMode = System.Windows.Forms.ImeMode.NoControl
        Me.BtnPrint.Location = New System.Drawing.Point(6, 19)
        Me.BtnPrint.Name = "BtnPrint"
        Me.BtnPrint.Size = New System.Drawing.Size(95, 48)
        Me.BtnPrint.TabIndex = 0
        Me.BtnPrint.Text = "Imprimer"
        Me.BtnPrint.UseVisualStyleBackColor = True
        Me.BtnPrint.Visible = False
        '
        'GrpGraph
        '
        Me.GrpGraph.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
            Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.GrpGraph.Controls.Add(Me.ChartGraph)
        Me.GrpGraph.Location = New System.Drawing.Point(134, 51)
        Me.GrpGraph.Name = "GrpGraph"
        Me.GrpGraph.Size = New System.Drawing.Size(1084, 627)
        Me.GrpGraph.TabIndex = 96
        Me.GrpGraph.TabStop = False
        '
        'ChartGraph
        '
        Me.ChartGraph.CrosshairEnabled = DevExpress.Utils.DefaultBoolean.[False]
        Me.ChartGraph.Dock = System.Windows.Forms.DockStyle.Fill
        Me.ChartGraph.Location = New System.Drawing.Point(3, 16)
        Me.ChartGraph.Name = "ChartGraph"
        Me.ChartGraph.SeriesSerializable = New DevExpress.XtraCharts.Series(-1) {}
        SideBySideBarSeriesLabel1.LineVisibility = DevExpress.Utils.DefaultBoolean.[True]
        Me.ChartGraph.SeriesTemplate.Label = SideBySideBarSeriesLabel1
        Me.ChartGraph.Size = New System.Drawing.Size(1078, 608)
        Me.ChartGraph.TabIndex = 0
        '
        'lblSociete
        '
        Me.lblSociete.AutoSize = True
        Me.lblSociete.Font = New System.Drawing.Font("Arial", 18.0!, System.Drawing.FontStyle.Bold)
        Me.lblSociete.ImeMode = System.Windows.Forms.ImeMode.NoControl
        Me.lblSociete.Location = New System.Drawing.Point(609, 19)
        Me.lblSociete.Name = "lblSociete"
        Me.lblSociete.Size = New System.Drawing.Size(173, 29)
        Me.lblSociete.TabIndex = 99
        Me.lblSociete.Text = "Nom du client"
        '
        'frmStatCAClientParAN
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.Wheat
        Me.CancelButton = Me.BtnFermer
        Me.ClientSize = New System.Drawing.Size(1229, 690)
        Me.Controls.Add(Me.LblTitre)
        Me.Controls.Add(Me.GrpActions)
        Me.Controls.Add(Me.GrpGraph)
        Me.Controls.Add(Me.lblSociete)
        Me.Name = "frmStatCAClientParAN"
        Me.Text = "Evolution du chiffre d'affaire du client"
        Me.WindowState = System.Windows.Forms.FormWindowState.Maximized
        Me.GrpActions.ResumeLayout(False)
        Me.GrpGraph.ResumeLayout(False)
        CType(SideBySideBarSeriesLabel1, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.ChartGraph, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents LblTitre As Label
  Friend WithEvents GrpActions As GroupBox
  Friend WithEvents BtnFermer As Button
  Friend WithEvents BtnPrint As Button
  Friend WithEvents GrpGraph As GroupBox
  Private WithEvents ChartGraph As DevExpress.XtraCharts.ChartControl
  Friend WithEvents lblSociete As Label
End Class
