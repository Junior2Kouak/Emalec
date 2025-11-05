<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class frmPlanningDI
  Inherits System.Windows.Forms.Form

  'Form remplace la méthode Dispose pour nettoyer la liste des composants.
  <System.Diagnostics.DebuggerNonUserCode()>
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
  <System.Diagnostics.DebuggerStepThrough()>
  Private Sub InitializeComponent()
        Me.components = New System.ComponentModel.Container()
        Me.BtnFermer = New System.Windows.Forms.Button()
        Me.lblTitre = New System.Windows.Forms.Label()
        Me.btnLegende = New MozartUC.apiButton()
        Me.frame1 = New MozartUC.apiGroupBox()
        Me.ApiLabel7 = New MozartUC.apiLabel()
        Me.ApiLabel6 = New MozartUC.apiLabel()
        Me.ApiLabel5 = New MozartUC.apiLabel()
        Me.Label25 = New MozartUC.apiLabel()
        Me.lblGreen = New MozartUC.apiLabel()
        Me.lblRed = New MozartUC.apiLabel()
        Me.lblBlue = New MozartUC.apiLabel()
        Me.lblSilver = New MozartUC.apiLabel()
        Me.btnLegendeFermer = New MozartUC.apiButton()
        Me.gridPlanning = New DevExpress.XtraGrid.GridControl()
        Me.bandedGridView = New DevExpress.XtraGrid.Views.BandedGrid.BandedGridView()
        Me.toolTipCtrl = New DevExpress.Utils.ToolTipController(Me.components)
        Me.frame1.SuspendLayout()
        CType(Me.gridPlanning, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.bandedGridView, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'BtnFermer
        '
        Me.BtnFermer.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.BtnFermer.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold)
        Me.BtnFermer.ImeMode = System.Windows.Forms.ImeMode.NoControl
        Me.BtnFermer.Location = New System.Drawing.Point(1082, 12)
        Me.BtnFermer.Name = "BtnFermer"
        Me.BtnFermer.Size = New System.Drawing.Size(114, 39)
        Me.BtnFermer.TabIndex = 2
        Me.BtnFermer.Text = "Fermer"
        Me.BtnFermer.UseVisualStyleBackColor = True
        '
        'lblTitre
        '
        Me.lblTitre.AutoSize = True
        Me.lblTitre.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblTitre.ForeColor = System.Drawing.Color.Blue
        Me.lblTitre.Location = New System.Drawing.Point(12, 25)
        Me.lblTitre.Name = "lblTitre"
        Me.lblTitre.Size = New System.Drawing.Size(143, 20)
        Me.lblTitre.TabIndex = 6
        Me.lblTitre.Text = "Titre du planning"
        '
        'btnLegende
        '
        Me.btnLegende.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.btnLegende.HelpContextID = 0
        Me.btnLegende.Location = New System.Drawing.Point(920, 12)
        Me.btnLegende.Name = "btnLegende"
        Me.btnLegende.Size = New System.Drawing.Size(129, 39)
        Me.btnLegende.TabIndex = 7
        Me.btnLegende.Text = "Légende"
        Me.btnLegende.UseVisualStyleBackColor = True
        '
        'frame1
        '
        Me.frame1.Controls.Add(Me.ApiLabel7)
        Me.frame1.Controls.Add(Me.ApiLabel6)
        Me.frame1.Controls.Add(Me.ApiLabel5)
        Me.frame1.Controls.Add(Me.Label25)
        Me.frame1.Controls.Add(Me.lblGreen)
        Me.frame1.Controls.Add(Me.lblRed)
        Me.frame1.Controls.Add(Me.lblBlue)
        Me.frame1.Controls.Add(Me.lblSilver)
        Me.frame1.Controls.Add(Me.btnLegendeFermer)
        Me.frame1.HelpContextID = 0
        Me.frame1.Location = New System.Drawing.Point(899, 436)
        Me.frame1.Name = "frame1"
        Me.frame1.Size = New System.Drawing.Size(297, 244)
        Me.frame1.TabIndex = 8
        Me.frame1.TabStop = False
        Me.frame1.Text = "Légende"
        Me.frame1.Visible = False
        '
        'ApiLabel7
        '
        Me.ApiLabel7.AutoSize = True
        Me.ApiLabel7.BackColor = System.Drawing.Color.Wheat
        Me.ApiLabel7.Font = New System.Drawing.Font("Arial", 8.25!, System.Drawing.FontStyle.Bold)
        Me.ApiLabel7.ForeColor = System.Drawing.SystemColors.ControlText
        Me.ApiLabel7.HelpContextID = 0
        Me.ApiLabel7.ImeMode = System.Windows.Forms.ImeMode.NoControl
        Me.ApiLabel7.Location = New System.Drawing.Point(102, 71)
        Me.ApiLabel7.Name = "ApiLabel7"
        Me.ApiLabel7.Size = New System.Drawing.Size(57, 14)
        Me.ApiLabel7.TabIndex = 52
        Me.ApiLabel7.Text = "DI à venir"
        '
        'ApiLabel6
        '
        Me.ApiLabel6.AutoSize = True
        Me.ApiLabel6.BackColor = System.Drawing.Color.Wheat
        Me.ApiLabel6.Font = New System.Drawing.Font("Arial", 8.25!, System.Drawing.FontStyle.Bold)
        Me.ApiLabel6.ForeColor = System.Drawing.SystemColors.ControlText
        Me.ApiLabel6.HelpContextID = 0
        Me.ApiLabel6.ImeMode = System.Windows.Forms.ImeMode.NoControl
        Me.ApiLabel6.Location = New System.Drawing.Point(102, 101)
        Me.ApiLabel6.Name = "ApiLabel6"
        Me.ApiLabel6.Size = New System.Drawing.Size(71, 14)
        Me.ApiLabel6.TabIndex = 51
        Me.ApiLabel6.Text = "DI en retard"
        '
        'ApiLabel5
        '
        Me.ApiLabel5.AutoSize = True
        Me.ApiLabel5.BackColor = System.Drawing.Color.Wheat
        Me.ApiLabel5.Font = New System.Drawing.Font("Arial", 8.25!, System.Drawing.FontStyle.Bold)
        Me.ApiLabel5.ForeColor = System.Drawing.SystemColors.ControlText
        Me.ApiLabel5.HelpContextID = 0
        Me.ApiLabel5.ImeMode = System.Windows.Forms.ImeMode.NoControl
        Me.ApiLabel5.Location = New System.Drawing.Point(102, 130)
        Me.ApiLabel5.Name = "ApiLabel5"
        Me.ApiLabel5.Size = New System.Drawing.Size(71, 14)
        Me.ApiLabel5.TabIndex = 50
        Me.ApiLabel5.Text = "DI éxecutée"
        '
        'Label25
        '
        Me.Label25.AutoSize = True
        Me.Label25.BackColor = System.Drawing.Color.Wheat
        Me.Label25.Font = New System.Drawing.Font("Arial", 8.25!, System.Drawing.FontStyle.Bold)
        Me.Label25.ForeColor = System.Drawing.SystemColors.ControlText
        Me.Label25.HelpContextID = 0
        Me.Label25.ImeMode = System.Windows.Forms.ImeMode.NoControl
        Me.Label25.Location = New System.Drawing.Point(102, 40)
        Me.Label25.Name = "Label25"
        Me.Label25.Size = New System.Drawing.Size(61, 14)
        Me.Label25.TabIndex = 49
        Me.Label25.Text = "Jour férié"
        '
        'lblGreen
        '
        Me.lblGreen.BackColor = System.Drawing.Color.Lime
        Me.lblGreen.HelpContextID = 0
        Me.lblGreen.Location = New System.Drawing.Point(40, 130)
        Me.lblGreen.Name = "lblGreen"
        Me.lblGreen.Size = New System.Drawing.Size(40, 15)
        Me.lblGreen.TabIndex = 5
        '
        'lblRed
        '
        Me.lblRed.BackColor = System.Drawing.Color.Red
        Me.lblRed.HelpContextID = 0
        Me.lblRed.Location = New System.Drawing.Point(40, 100)
        Me.lblRed.Name = "lblRed"
        Me.lblRed.Size = New System.Drawing.Size(40, 15)
        Me.lblRed.TabIndex = 4
        '
        'lblBlue
        '
        Me.lblBlue.BackColor = System.Drawing.Color.Blue
        Me.lblBlue.HelpContextID = 0
        Me.lblBlue.Location = New System.Drawing.Point(40, 70)
        Me.lblBlue.Name = "lblBlue"
        Me.lblBlue.Size = New System.Drawing.Size(40, 15)
        Me.lblBlue.TabIndex = 3
        '
        'lblSilver
        '
        Me.lblSilver.BackColor = System.Drawing.Color.Silver
        Me.lblSilver.HelpContextID = 0
        Me.lblSilver.Location = New System.Drawing.Point(40, 40)
        Me.lblSilver.Name = "lblSilver"
        Me.lblSilver.Size = New System.Drawing.Size(40, 15)
        Me.lblSilver.TabIndex = 2
        '
        'btnLegendeFermer
        '
        Me.btnLegendeFermer.HelpContextID = 0
        Me.btnLegendeFermer.Location = New System.Drawing.Point(118, 191)
        Me.btnLegendeFermer.Name = "btnLegendeFermer"
        Me.btnLegendeFermer.Size = New System.Drawing.Size(78, 35)
        Me.btnLegendeFermer.TabIndex = 0
        Me.btnLegendeFermer.Text = "Fermer"
        Me.btnLegendeFermer.UseVisualStyleBackColor = True
        '
        'gridPlanning
        '
        Me.gridPlanning.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
            Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.gridPlanning.Location = New System.Drawing.Point(1, 58)
        Me.gridPlanning.MainView = Me.bandedGridView
        Me.gridPlanning.Name = "gridPlanning"
        Me.gridPlanning.Size = New System.Drawing.Size(1204, 650)
        Me.gridPlanning.TabIndex = 11
        Me.gridPlanning.ToolTipController = Me.toolTipCtrl
        Me.gridPlanning.ViewCollection.AddRange(New DevExpress.XtraGrid.Views.Base.BaseView() {Me.bandedGridView})
        '
        'bandedGridView
        '
        Me.bandedGridView.GridControl = Me.gridPlanning
        Me.bandedGridView.Name = "bandedGridView"
        Me.bandedGridView.OptionsBehavior.AllowAddRows = DevExpress.Utils.DefaultBoolean.[False]
        Me.bandedGridView.OptionsBehavior.AllowDeleteRows = DevExpress.Utils.DefaultBoolean.[False]
        Me.bandedGridView.OptionsBehavior.Editable = False
        Me.bandedGridView.OptionsCustomization.AllowBandMoving = False
        Me.bandedGridView.OptionsCustomization.AllowBandResizing = False
        Me.bandedGridView.OptionsCustomization.AllowColumnMoving = False
        Me.bandedGridView.OptionsCustomization.AllowColumnResizing = False
        Me.bandedGridView.OptionsPrint.AutoWidth = False
        Me.bandedGridView.OptionsSelection.EnableAppearanceFocusedCell = False
        Me.bandedGridView.OptionsSelection.EnableAppearanceFocusedRow = False
        Me.bandedGridView.OptionsView.ColumnAutoWidth = False
        Me.bandedGridView.OptionsView.ShowGroupPanel = False
        Me.bandedGridView.OptionsView.ShowIndicator = False
        Me.bandedGridView.PaintStyleName = "MixedXP"
        '
        'toolTipCtrl
        '
        '
        'frmPlanningDI
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.Wheat
        Me.ClientSize = New System.Drawing.Size(1208, 709)
        Me.Controls.Add(Me.frame1)
        Me.Controls.Add(Me.gridPlanning)
        Me.Controls.Add(Me.btnLegende)
        Me.Controls.Add(Me.lblTitre)
        Me.Controls.Add(Me.BtnFermer)
        Me.Name = "frmPlanningDI"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Planning projet"
        Me.WindowState = System.Windows.Forms.FormWindowState.Maximized
        Me.frame1.ResumeLayout(False)
        Me.frame1.PerformLayout()
        CType(Me.gridPlanning, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.bandedGridView, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents BtnFermer As Button
    Friend WithEvents lblTitre As Label
    Friend WithEvents btnLegende As MozartUC.apiButton
    Friend WithEvents frame1 As MozartUC.apiGroupBox
    Friend WithEvents btnLegendeFermer As MozartUC.apiButton
    Friend WithEvents lblGreen As MozartUC.apiLabel
    Friend WithEvents lblRed As MozartUC.apiLabel
    Friend WithEvents lblBlue As MozartUC.apiLabel
    Friend WithEvents lblSilver As MozartUC.apiLabel
    Private WithEvents ApiLabel7 As MozartUC.apiLabel
    Private WithEvents ApiLabel6 As MozartUC.apiLabel
    Private WithEvents ApiLabel5 As MozartUC.apiLabel
    Private WithEvents Label25 As MozartUC.apiLabel
    Friend WithEvents gridPlanning As DevExpress.XtraGrid.GridControl
    Friend WithEvents bandedGridView As DevExpress.XtraGrid.Views.BandedGrid.BandedGridView
    Friend WithEvents toolTipCtrl As DevExpress.Utils.ToolTipController
End Class
