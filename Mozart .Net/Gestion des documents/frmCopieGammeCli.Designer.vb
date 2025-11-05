<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmCopieGammeCli
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(frmCopieGammeCli))
        Me.Label1 = New System.Windows.Forms.Label()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.LabelDetailsGamme = New System.Windows.Forms.Label()
        Me.ComboBoxSociete = New DevExpress.XtraEditors.GridLookUpEdit()
        Me.GridCbo = New DevExpress.XtraGrid.Views.Grid.GridView()
        Me.c1 = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.VSOCIETE = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.LabelNumGamme = New System.Windows.Forms.Label()
        Me.BtnFermer = New System.Windows.Forms.Button()
        Me.Button1 = New System.Windows.Forms.Button()
        Me.Label3 = New System.Windows.Forms.Label()
        CType(Me.ComboBoxSociete.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.GridCbo, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'Label1
        '
        resources.ApplyResources(Me.Label1, "Label1")
        Me.Label1.Name = "Label1"
        '
        'Label2
        '
        resources.ApplyResources(Me.Label2, "Label2")
        Me.Label2.Name = "Label2"
        '
        'LabelDetailsGamme
        '
        resources.ApplyResources(Me.LabelDetailsGamme, "LabelDetailsGamme")
        Me.LabelDetailsGamme.Name = "LabelDetailsGamme"
        '
        'ComboBoxSociete
        '
        resources.ApplyResources(Me.ComboBoxSociete, "ComboBoxSociete")
        Me.ComboBoxSociete.Name = "ComboBoxSociete"
        '
        '
        '
        Me.ComboBoxSociete.Properties.AccessibleDescription = resources.GetString("ComboBoxSociete.Properties.AccessibleDescription")
        Me.ComboBoxSociete.Properties.AccessibleName = resources.GetString("ComboBoxSociete.Properties.AccessibleName")
        Me.ComboBoxSociete.Properties.Appearance.Font = CType(resources.GetObject("ComboBoxSociete.Properties.Appearance.Font"), System.Drawing.Font)
        Me.ComboBoxSociete.Properties.Appearance.FontSizeDelta = CType(resources.GetObject("ComboBoxSociete.Properties.Appearance.FontSizeDelta"), Integer)
        Me.ComboBoxSociete.Properties.Appearance.FontStyleDelta = CType(resources.GetObject("ComboBoxSociete.Properties.Appearance.FontStyleDelta"), System.Drawing.FontStyle)
        Me.ComboBoxSociete.Properties.Appearance.GradientMode = CType(resources.GetObject("ComboBoxSociete.Properties.Appearance.GradientMode"), System.Drawing.Drawing2D.LinearGradientMode)
        Me.ComboBoxSociete.Properties.Appearance.Image = CType(resources.GetObject("ComboBoxSociete.Properties.Appearance.Image"), System.Drawing.Image)
        Me.ComboBoxSociete.Properties.Appearance.Options.UseFont = True
        Me.ComboBoxSociete.Properties.Appearance.Options.UseTextOptions = True
        Me.ComboBoxSociete.Properties.Appearance.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center
        Me.ComboBoxSociete.Properties.Appearance.TextOptions.VAlignment = DevExpress.Utils.VertAlignment.Center
        Me.ComboBoxSociete.Properties.AutoHeight = CType(resources.GetObject("ComboBoxSociete.Properties.AutoHeight"), Boolean)
        Me.ComboBoxSociete.Properties.Buttons.AddRange(New DevExpress.XtraEditors.Controls.EditorButton() {New DevExpress.XtraEditors.Controls.EditorButton(CType(resources.GetObject("ComboBoxSociete.Properties.Buttons"), DevExpress.XtraEditors.Controls.ButtonPredefines))})
        Me.ComboBoxSociete.Properties.DisplayMember = "VSOCIETE"
        Me.ComboBoxSociete.Properties.NullText = resources.GetString("ComboBoxSociete.Properties.NullText")
        Me.ComboBoxSociete.Properties.NullValuePrompt = resources.GetString("ComboBoxSociete.Properties.NullValuePrompt")
        Me.ComboBoxSociete.Properties.NullValuePromptShowForEmptyValue = CType(resources.GetObject("ComboBoxSociete.Properties.NullValuePromptShowForEmptyValue"), Boolean)
        Me.ComboBoxSociete.Properties.PopupFormSize = New System.Drawing.Size(120, 300)
        Me.ComboBoxSociete.Properties.PopupSizeable = False
        Me.ComboBoxSociete.Properties.ValueMember = "NCLINUM"
        Me.ComboBoxSociete.Properties.View = Me.GridCbo
        '
        'GridCbo
        '
        resources.ApplyResources(Me.GridCbo, "GridCbo")
        Me.GridCbo.Columns.AddRange(New DevExpress.XtraGrid.Columns.GridColumn() {Me.c1, Me.VSOCIETE})
        Me.GridCbo.FocusRectStyle = DevExpress.XtraGrid.Views.Grid.DrawFocusRectStyle.RowFocus
        Me.GridCbo.Name = "GridCbo"
        Me.GridCbo.OptionsSelection.EnableAppearanceFocusedCell = False
        Me.GridCbo.OptionsView.ShowGroupPanel = False
        '
        'c1
        '
        resources.ApplyResources(Me.c1, "c1")
        Me.c1.FieldName = "NCLINUM"
        Me.c1.Name = "c1"
        '
        'VSOCIETE
        '
        Me.VSOCIETE.AppearanceCell.FontSizeDelta = CType(resources.GetObject("VSOCIETE.AppearanceCell.FontSizeDelta"), Integer)
        Me.VSOCIETE.AppearanceCell.FontStyleDelta = CType(resources.GetObject("VSOCIETE.AppearanceCell.FontStyleDelta"), System.Drawing.FontStyle)
        Me.VSOCIETE.AppearanceCell.GradientMode = CType(resources.GetObject("VSOCIETE.AppearanceCell.GradientMode"), System.Drawing.Drawing2D.LinearGradientMode)
        Me.VSOCIETE.AppearanceCell.Image = CType(resources.GetObject("VSOCIETE.AppearanceCell.Image"), System.Drawing.Image)
        Me.VSOCIETE.AppearanceCell.Options.UseTextOptions = True
        Me.VSOCIETE.AppearanceCell.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center
        Me.VSOCIETE.AppearanceCell.TextOptions.VAlignment = DevExpress.Utils.VertAlignment.Center
        Me.VSOCIETE.AppearanceHeader.Font = CType(resources.GetObject("VSOCIETE.AppearanceHeader.Font"), System.Drawing.Font)
        Me.VSOCIETE.AppearanceHeader.FontSizeDelta = CType(resources.GetObject("VSOCIETE.AppearanceHeader.FontSizeDelta"), Integer)
        Me.VSOCIETE.AppearanceHeader.FontStyleDelta = CType(resources.GetObject("VSOCIETE.AppearanceHeader.FontStyleDelta"), System.Drawing.FontStyle)
        Me.VSOCIETE.AppearanceHeader.GradientMode = CType(resources.GetObject("VSOCIETE.AppearanceHeader.GradientMode"), System.Drawing.Drawing2D.LinearGradientMode)
        Me.VSOCIETE.AppearanceHeader.Image = CType(resources.GetObject("VSOCIETE.AppearanceHeader.Image"), System.Drawing.Image)
        Me.VSOCIETE.AppearanceHeader.Options.UseFont = True
        Me.VSOCIETE.AppearanceHeader.Options.UseTextOptions = True
        Me.VSOCIETE.AppearanceHeader.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center
        Me.VSOCIETE.AppearanceHeader.TextOptions.VAlignment = DevExpress.Utils.VertAlignment.Center
        resources.ApplyResources(Me.VSOCIETE, "VSOCIETE")
        Me.VSOCIETE.FieldName = "VSOCIETE"
        Me.VSOCIETE.Name = "VSOCIETE"
        Me.VSOCIETE.OptionsColumn.AllowEdit = False
        Me.VSOCIETE.OptionsColumn.ReadOnly = True
        '
        'LabelNumGamme
        '
        resources.ApplyResources(Me.LabelNumGamme, "LabelNumGamme")
        Me.LabelNumGamme.Name = "LabelNumGamme"
        '
        'BtnFermer
        '
        resources.ApplyResources(Me.BtnFermer, "BtnFermer")
        Me.BtnFermer.Name = "BtnFermer"
        Me.BtnFermer.UseVisualStyleBackColor = True
        '
        'Button1
        '
        resources.ApplyResources(Me.Button1, "Button1")
        Me.Button1.Name = "Button1"
        Me.Button1.UseVisualStyleBackColor = True
        '
        'Label3
        '
        resources.ApplyResources(Me.Label3, "Label3")
        Me.Label3.Name = "Label3"
        '
        'frmCopieGammeCli
        '
        resources.ApplyResources(Me, "$this")
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.Wheat
        Me.Controls.Add(Me.Label3)
        Me.Controls.Add(Me.Button1)
        Me.Controls.Add(Me.BtnFermer)
        Me.Controls.Add(Me.LabelNumGamme)
        Me.Controls.Add(Me.ComboBoxSociete)
        Me.Controls.Add(Me.LabelDetailsGamme)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.Label1)
        Me.Name = "frmCopieGammeCli"
        CType(Me.ComboBoxSociete.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.GridCbo, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents Label1 As System.Windows.Forms.Label
  Friend WithEvents Label2 As System.Windows.Forms.Label
  Friend WithEvents LabelDetailsGamme As System.Windows.Forms.Label
    Friend WithEvents LabelNumGamme As System.Windows.Forms.Label
    Friend WithEvents BtnFermer As System.Windows.Forms.Button
    Friend WithEvents Button1 As System.Windows.Forms.Button
    Friend WithEvents Label3 As System.Windows.Forms.Label
    Private WithEvents ComboBoxSociete As DevExpress.XtraEditors.GridLookUpEdit
    Private WithEvents GridCbo As DevExpress.XtraGrid.Views.Grid.GridView
    Private WithEvents c1 As DevExpress.XtraGrid.Columns.GridColumn
    Private WithEvents VSOCIETE As DevExpress.XtraGrid.Columns.GridColumn
End Class
