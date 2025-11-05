<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmCtrlEtanchPeriodicite
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
    Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(frmCtrlEtanchPeriodicite))
    Me.GroupBox1 = New System.Windows.Forms.GroupBox()
    Me.GridLookUpEdit1 = New DevExpress.XtraEditors.GridLookUpEdit()
    Me.GridView1 = New DevExpress.XtraGrid.Views.Grid.GridView()
    Me.GridColumn2 = New DevExpress.XtraGrid.Columns.GridColumn()
    Me.Label1 = New System.Windows.Forms.Label()
    Me.Label3 = New System.Windows.Forms.Label()
    Me.BtnRechercher = New System.Windows.Forms.Button()
    Me.GlookUpClient = New DevExpress.XtraEditors.GridLookUpEdit()
    Me.GVCboClient = New DevExpress.XtraGrid.Views.Grid.GridView()
    Me.GCCboClientNCLINUM = New DevExpress.XtraGrid.Columns.GridColumn()
    Me.GCCboClientVCLINOM = New DevExpress.XtraGrid.Columns.GridColumn()
    Me.LblTitre = New System.Windows.Forms.Label()
    Me.GrpActions = New System.Windows.Forms.GroupBox()
    Me.BtnFermer = New System.Windows.Forms.Button()
    Me.WB = New System.Windows.Forms.WebBrowser()
    Me.GroupBox1.SuspendLayout()
    CType(Me.GridLookUpEdit1.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
    CType(Me.GridView1, System.ComponentModel.ISupportInitialize).BeginInit()
    CType(Me.GlookUpClient.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
    CType(Me.GVCboClient, System.ComponentModel.ISupportInitialize).BeginInit()
    Me.GrpActions.SuspendLayout()
    Me.SuspendLayout()
    '
    'GroupBox1
    '
    resources.ApplyResources(Me.GroupBox1, "GroupBox1")
    Me.GroupBox1.Controls.Add(Me.GridLookUpEdit1)
    Me.GroupBox1.Controls.Add(Me.Label1)
    Me.GroupBox1.Controls.Add(Me.Label3)
    Me.GroupBox1.Controls.Add(Me.BtnRechercher)
    Me.GroupBox1.Controls.Add(Me.GlookUpClient)
    Me.GroupBox1.Name = "GroupBox1"
    Me.GroupBox1.TabStop = False
    '
    'GridLookUpEdit1
    '
    resources.ApplyResources(Me.GridLookUpEdit1, "GridLookUpEdit1")
    Me.GridLookUpEdit1.Name = "GridLookUpEdit1"
    Me.GridLookUpEdit1.Properties.AccessibleDescription = resources.GetString("GridLookUpEdit1.Properties.AccessibleDescription")
    Me.GridLookUpEdit1.Properties.AccessibleName = resources.GetString("GridLookUpEdit1.Properties.AccessibleName")
    Me.GridLookUpEdit1.Properties.AutoHeight = CType(resources.GetObject("GridLookUpEdit1.Properties.AutoHeight"), Boolean)
    Me.GridLookUpEdit1.Properties.Buttons.AddRange(New DevExpress.XtraEditors.Controls.EditorButton() {New DevExpress.XtraEditors.Controls.EditorButton(CType(resources.GetObject("GridLookUpEdit1.Properties.Buttons"), DevExpress.XtraEditors.Controls.ButtonPredefines))})
    Me.GridLookUpEdit1.Properties.DisplayMember = "NIDANNEE"
    Me.GridLookUpEdit1.Properties.NullText = resources.GetString("GridLookUpEdit1.Properties.NullText")
    Me.GridLookUpEdit1.Properties.NullValuePrompt = resources.GetString("GridLookUpEdit1.Properties.NullValuePrompt")
    Me.GridLookUpEdit1.Properties.NullValuePromptShowForEmptyValue = CType(resources.GetObject("GridLookUpEdit1.Properties.NullValuePromptShowForEmptyValue"), Boolean)
    Me.GridLookUpEdit1.Properties.ValueMember = "NIDANNEE"
    Me.GridLookUpEdit1.Properties.View = Me.GridView1
    '
    'GridView1
    '
    resources.ApplyResources(Me.GridView1, "GridView1")
    Me.GridView1.Columns.AddRange(New DevExpress.XtraGrid.Columns.GridColumn() {Me.GridColumn2})
    Me.GridView1.FocusRectStyle = DevExpress.XtraGrid.Views.Grid.DrawFocusRectStyle.RowFocus
    Me.GridView1.Name = "GridView1"
    Me.GridView1.OptionsSelection.EnableAppearanceFocusedCell = False
    Me.GridView1.OptionsView.ShowAutoFilterRow = True
    Me.GridView1.OptionsView.ShowGroupPanel = False
    '
    'GridColumn2
    '
    Me.GridColumn2.AppearanceCell.FontSizeDelta = CType(resources.GetObject("GridColumn2.AppearanceCell.FontSizeDelta"), Integer)
    Me.GridColumn2.AppearanceCell.FontStyleDelta = CType(resources.GetObject("GridColumn2.AppearanceCell.FontStyleDelta"), System.Drawing.FontStyle)
    Me.GridColumn2.AppearanceCell.GradientMode = CType(resources.GetObject("GridColumn2.AppearanceCell.GradientMode"), System.Drawing.Drawing2D.LinearGradientMode)
    Me.GridColumn2.AppearanceCell.Image = CType(resources.GetObject("GridColumn2.AppearanceCell.Image"), System.Drawing.Image)
    Me.GridColumn2.AppearanceCell.Options.UseTextOptions = True
    Me.GridColumn2.AppearanceCell.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center
    Me.GridColumn2.AppearanceCell.TextOptions.VAlignment = DevExpress.Utils.VertAlignment.Center
    Me.GridColumn2.AppearanceHeader.Font = CType(resources.GetObject("GridColumn2.AppearanceHeader.Font"), System.Drawing.Font)
    Me.GridColumn2.AppearanceHeader.FontSizeDelta = CType(resources.GetObject("GridColumn2.AppearanceHeader.FontSizeDelta"), Integer)
    Me.GridColumn2.AppearanceHeader.FontStyleDelta = CType(resources.GetObject("GridColumn2.AppearanceHeader.FontStyleDelta"), System.Drawing.FontStyle)
    Me.GridColumn2.AppearanceHeader.GradientMode = CType(resources.GetObject("GridColumn2.AppearanceHeader.GradientMode"), System.Drawing.Drawing2D.LinearGradientMode)
    Me.GridColumn2.AppearanceHeader.Image = CType(resources.GetObject("GridColumn2.AppearanceHeader.Image"), System.Drawing.Image)
    Me.GridColumn2.AppearanceHeader.Options.UseFont = True
    Me.GridColumn2.AppearanceHeader.Options.UseTextOptions = True
    Me.GridColumn2.AppearanceHeader.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center
    Me.GridColumn2.AppearanceHeader.TextOptions.VAlignment = DevExpress.Utils.VertAlignment.Center
    resources.ApplyResources(Me.GridColumn2, "GridColumn2")
    Me.GridColumn2.FieldName = "NIDANNEE"
    Me.GridColumn2.Name = "GridColumn2"
    Me.GridColumn2.OptionsFilter.AutoFilterCondition = DevExpress.XtraGrid.Columns.AutoFilterCondition.Contains
    '
    'Label1
    '
    resources.ApplyResources(Me.Label1, "Label1")
    Me.Label1.Name = "Label1"
    '
    'Label3
    '
    resources.ApplyResources(Me.Label3, "Label3")
    Me.Label3.Name = "Label3"
    '
    'BtnRechercher
    '
    resources.ApplyResources(Me.BtnRechercher, "BtnRechercher")
    Me.BtnRechercher.Name = "BtnRechercher"
    Me.BtnRechercher.UseVisualStyleBackColor = True
    '
    'GlookUpClient
    '
    resources.ApplyResources(Me.GlookUpClient, "GlookUpClient")
    Me.GlookUpClient.Name = "GlookUpClient"
    Me.GlookUpClient.Properties.AccessibleDescription = resources.GetString("GlookUpClient.Properties.AccessibleDescription")
    Me.GlookUpClient.Properties.AccessibleName = resources.GetString("GlookUpClient.Properties.AccessibleName")
    Me.GlookUpClient.Properties.AutoHeight = CType(resources.GetObject("GlookUpClient.Properties.AutoHeight"), Boolean)
    Me.GlookUpClient.Properties.Buttons.AddRange(New DevExpress.XtraEditors.Controls.EditorButton() {New DevExpress.XtraEditors.Controls.EditorButton(CType(resources.GetObject("GlookUpClient.Properties.Buttons"), DevExpress.XtraEditors.Controls.ButtonPredefines))})
    Me.GlookUpClient.Properties.DisplayMember = "VCLINOM"
    Me.GlookUpClient.Properties.NullText = resources.GetString("GlookUpClient.Properties.NullText")
    Me.GlookUpClient.Properties.NullValuePrompt = resources.GetString("GlookUpClient.Properties.NullValuePrompt")
    Me.GlookUpClient.Properties.NullValuePromptShowForEmptyValue = CType(resources.GetObject("GlookUpClient.Properties.NullValuePromptShowForEmptyValue"), Boolean)
    Me.GlookUpClient.Properties.ValueMember = "NCLINUM"
    Me.GlookUpClient.Properties.View = Me.GVCboClient
    '
    'GVCboClient
    '
    resources.ApplyResources(Me.GVCboClient, "GVCboClient")
    Me.GVCboClient.Columns.AddRange(New DevExpress.XtraGrid.Columns.GridColumn() {Me.GCCboClientNCLINUM, Me.GCCboClientVCLINOM})
    Me.GVCboClient.FocusRectStyle = DevExpress.XtraGrid.Views.Grid.DrawFocusRectStyle.RowFocus
    Me.GVCboClient.Name = "GVCboClient"
    Me.GVCboClient.OptionsSelection.EnableAppearanceFocusedCell = False
    Me.GVCboClient.OptionsView.ShowAutoFilterRow = True
    Me.GVCboClient.OptionsView.ShowGroupPanel = False
    '
    'GCCboClientNCLINUM
    '
    Me.GCCboClientNCLINUM.AppearanceHeader.FontSizeDelta = CType(resources.GetObject("GCCboClientNCLINUM.AppearanceHeader.FontSizeDelta"), Integer)
    Me.GCCboClientNCLINUM.AppearanceHeader.FontStyleDelta = CType(resources.GetObject("GCCboClientNCLINUM.AppearanceHeader.FontStyleDelta"), System.Drawing.FontStyle)
    Me.GCCboClientNCLINUM.AppearanceHeader.GradientMode = CType(resources.GetObject("GCCboClientNCLINUM.AppearanceHeader.GradientMode"), System.Drawing.Drawing2D.LinearGradientMode)
    Me.GCCboClientNCLINUM.AppearanceHeader.Image = CType(resources.GetObject("GCCboClientNCLINUM.AppearanceHeader.Image"), System.Drawing.Image)
    Me.GCCboClientNCLINUM.AppearanceHeader.Options.UseTextOptions = True
    Me.GCCboClientNCLINUM.AppearanceHeader.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center
    Me.GCCboClientNCLINUM.AppearanceHeader.TextOptions.VAlignment = DevExpress.Utils.VertAlignment.Center
    resources.ApplyResources(Me.GCCboClientNCLINUM, "GCCboClientNCLINUM")
    Me.GCCboClientNCLINUM.FieldName = "NCLINUM"
    Me.GCCboClientNCLINUM.Name = "GCCboClientNCLINUM"
    Me.GCCboClientNCLINUM.OptionsColumn.AllowEdit = False
    Me.GCCboClientNCLINUM.OptionsColumn.ReadOnly = True
    '
    'GCCboClientVCLINOM
    '
    Me.GCCboClientVCLINOM.AppearanceHeader.Font = CType(resources.GetObject("GCCboClientVCLINOM.AppearanceHeader.Font"), System.Drawing.Font)
    Me.GCCboClientVCLINOM.AppearanceHeader.FontSizeDelta = CType(resources.GetObject("GCCboClientVCLINOM.AppearanceHeader.FontSizeDelta"), Integer)
    Me.GCCboClientVCLINOM.AppearanceHeader.FontStyleDelta = CType(resources.GetObject("GCCboClientVCLINOM.AppearanceHeader.FontStyleDelta"), System.Drawing.FontStyle)
    Me.GCCboClientVCLINOM.AppearanceHeader.GradientMode = CType(resources.GetObject("GCCboClientVCLINOM.AppearanceHeader.GradientMode"), System.Drawing.Drawing2D.LinearGradientMode)
    Me.GCCboClientVCLINOM.AppearanceHeader.Image = CType(resources.GetObject("GCCboClientVCLINOM.AppearanceHeader.Image"), System.Drawing.Image)
    Me.GCCboClientVCLINOM.AppearanceHeader.Options.UseFont = True
    Me.GCCboClientVCLINOM.AppearanceHeader.Options.UseTextOptions = True
    Me.GCCboClientVCLINOM.AppearanceHeader.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center
    Me.GCCboClientVCLINOM.AppearanceHeader.TextOptions.VAlignment = DevExpress.Utils.VertAlignment.Center
    resources.ApplyResources(Me.GCCboClientVCLINOM, "GCCboClientVCLINOM")
    Me.GCCboClientVCLINOM.FieldName = "VCLINOM"
    Me.GCCboClientVCLINOM.Name = "GCCboClientVCLINOM"
    Me.GCCboClientVCLINOM.OptionsFilter.AutoFilterCondition = DevExpress.XtraGrid.Columns.AutoFilterCondition.Contains
    '
    'LblTitre
    '
    resources.ApplyResources(Me.LblTitre, "LblTitre")
    Me.LblTitre.Name = "LblTitre"
    '
    'GrpActions
    '
    resources.ApplyResources(Me.GrpActions, "GrpActions")
    Me.GrpActions.Controls.Add(Me.BtnFermer)
    Me.GrpActions.Name = "GrpActions"
    Me.GrpActions.TabStop = False
    '
    'BtnFermer
    '
    resources.ApplyResources(Me.BtnFermer, "BtnFermer")
    Me.BtnFermer.Name = "BtnFermer"
    Me.BtnFermer.UseVisualStyleBackColor = True
    '
    'WB
    '
    resources.ApplyResources(Me.WB, "WB")
    Me.WB.AllowWebBrowserDrop = False
    Me.WB.Name = "WB"
    Me.WB.ScriptErrorsSuppressed = True
    '
    'frmCtrlEtanchPeriodicite
    '
    resources.ApplyResources(Me, "$this")
    Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
    Me.BackColor = System.Drawing.Color.Wheat
    Me.Controls.Add(Me.WB)
    Me.Controls.Add(Me.GroupBox1)
    Me.Controls.Add(Me.LblTitre)
    Me.Controls.Add(Me.GrpActions)
    Me.Name = "frmCtrlEtanchPeriodicite"
    Me.WindowState = System.Windows.Forms.FormWindowState.Maximized
    Me.GroupBox1.ResumeLayout(False)
    Me.GroupBox1.PerformLayout()
    CType(Me.GridLookUpEdit1.Properties, System.ComponentModel.ISupportInitialize).EndInit()
    CType(Me.GridView1, System.ComponentModel.ISupportInitialize).EndInit()
    CType(Me.GlookUpClient.Properties, System.ComponentModel.ISupportInitialize).EndInit()
    CType(Me.GVCboClient, System.ComponentModel.ISupportInitialize).EndInit()
    Me.GrpActions.ResumeLayout(False)
    Me.ResumeLayout(False)
    Me.PerformLayout()

  End Sub

  Friend WithEvents GroupBox1 As GroupBox
    Friend WithEvents Label3 As Label
    Friend WithEvents BtnRechercher As Button
    Private WithEvents GlookUpClient As DevExpress.XtraEditors.GridLookUpEdit
    Private WithEvents GVCboClient As DevExpress.XtraGrid.Views.Grid.GridView
    Private WithEvents GCCboClientNCLINUM As DevExpress.XtraGrid.Columns.GridColumn
    Private WithEvents GCCboClientVCLINOM As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents LblTitre As Label
    Friend WithEvents GrpActions As GroupBox
    Friend WithEvents BtnFermer As Button
    Public WithEvents WB As WebBrowser
    Friend WithEvents Label1 As Label
    Private WithEvents GridLookUpEdit1 As DevExpress.XtraEditors.GridLookUpEdit
    Private WithEvents GridView1 As DevExpress.XtraGrid.Views.Grid.GridView
    Private WithEvents GridColumn2 As DevExpress.XtraGrid.Columns.GridColumn
End Class
