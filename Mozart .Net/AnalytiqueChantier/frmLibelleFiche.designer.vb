<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmLibelleFiche
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(frmLibelleFiche))
        Me.btnValider = New System.Windows.Forms.Button()
        Me.GroupBox1 = New System.Windows.Forms.GroupBox()
        Me.txtVal = New DevExpress.XtraEditors.TextEdit()
        Me.lblVal = New System.Windows.Forms.Label()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.Label6 = New System.Windows.Forms.Label()
        Me.txtLib = New System.Windows.Forms.TextBox()
        Me.GroupBox1.SuspendLayout()
        CType(Me.txtVal.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'btnValider
        '
        resources.ApplyResources(Me.btnValider, "btnValider")
        Me.btnValider.Name = "btnValider"
        Me.btnValider.UseVisualStyleBackColor = True
        '
        'GroupBox1
        '
        resources.ApplyResources(Me.GroupBox1, "GroupBox1")
        Me.GroupBox1.Controls.Add(Me.txtVal)
        Me.GroupBox1.Controls.Add(Me.lblVal)
        Me.GroupBox1.Controls.Add(Me.Label2)
        Me.GroupBox1.Controls.Add(Me.Label6)
        Me.GroupBox1.Controls.Add(Me.txtLib)
        Me.GroupBox1.Name = "GroupBox1"
        Me.GroupBox1.TabStop = False
        '
        'txtVal
        '
        resources.ApplyResources(Me.txtVal, "txtVal")
        Me.txtVal.Name = "txtVal"
        '
        '
        '
        Me.txtVal.Properties.AccessibleDescription = resources.GetString("txtVal.Properties.AccessibleDescription")
        Me.txtVal.Properties.AccessibleName = resources.GetString("txtVal.Properties.AccessibleName")
        Me.txtVal.Properties.Appearance.FontSizeDelta = CType(resources.GetObject("txtVal.Properties.Appearance.FontSizeDelta"), Integer)
        Me.txtVal.Properties.Appearance.FontStyleDelta = CType(resources.GetObject("txtVal.Properties.Appearance.FontStyleDelta"), System.Drawing.FontStyle)
        Me.txtVal.Properties.Appearance.GradientMode = CType(resources.GetObject("txtVal.Properties.Appearance.GradientMode"), System.Drawing.Drawing2D.LinearGradientMode)
        Me.txtVal.Properties.Appearance.Image = CType(resources.GetObject("txtVal.Properties.Appearance.Image"), System.Drawing.Image)
        Me.txtVal.Properties.Appearance.Options.UseTextOptions = True
        Me.txtVal.Properties.Appearance.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Far
        Me.txtVal.Properties.AutoHeight = CType(resources.GetObject("txtVal.Properties.AutoHeight"), Boolean)
        Me.txtVal.Properties.Mask.AutoComplete = CType(resources.GetObject("txtVal.Properties.Mask.AutoComplete"), DevExpress.XtraEditors.Mask.AutoCompleteType)
        Me.txtVal.Properties.Mask.BeepOnError = CType(resources.GetObject("txtVal.Properties.Mask.BeepOnError"), Boolean)
        Me.txtVal.Properties.Mask.EditMask = resources.GetString("txtVal.Properties.Mask.EditMask")
        Me.txtVal.Properties.Mask.IgnoreMaskBlank = CType(resources.GetObject("txtVal.Properties.Mask.IgnoreMaskBlank"), Boolean)
        Me.txtVal.Properties.Mask.MaskType = CType(resources.GetObject("txtVal.Properties.Mask.MaskType"), DevExpress.XtraEditors.Mask.MaskType)
        Me.txtVal.Properties.Mask.PlaceHolder = CType(resources.GetObject("txtVal.Properties.Mask.PlaceHolder"), Char)
        Me.txtVal.Properties.Mask.SaveLiteral = CType(resources.GetObject("txtVal.Properties.Mask.SaveLiteral"), Boolean)
        Me.txtVal.Properties.Mask.ShowPlaceHolders = CType(resources.GetObject("txtVal.Properties.Mask.ShowPlaceHolders"), Boolean)
        Me.txtVal.Properties.Mask.UseMaskAsDisplayFormat = CType(resources.GetObject("txtVal.Properties.Mask.UseMaskAsDisplayFormat"), Boolean)
        Me.txtVal.Properties.NullText = resources.GetString("txtVal.Properties.NullText")
        Me.txtVal.Properties.NullValuePrompt = resources.GetString("txtVal.Properties.NullValuePrompt")
        Me.txtVal.Properties.NullValuePromptShowForEmptyValue = CType(resources.GetObject("txtVal.Properties.NullValuePromptShowForEmptyValue"), Boolean)
        '
        'lblVal
        '
        resources.ApplyResources(Me.lblVal, "lblVal")
        Me.lblVal.Name = "lblVal"
        '
        'Label2
        '
        resources.ApplyResources(Me.Label2, "Label2")
        Me.Label2.Name = "Label2"
        '
        'Label6
        '
        resources.ApplyResources(Me.Label6, "Label6")
        Me.Label6.Name = "Label6"
        '
        'txtLib
        '
        resources.ApplyResources(Me.txtLib, "txtLib")
        Me.txtLib.Name = "txtLib"
        '
        'frmLibelleFiche
        '
        resources.ApplyResources(Me, "$this")
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.Controls.Add(Me.GroupBox1)
        Me.Controls.Add(Me.btnValider)
        Me.Name = "frmLibelleFiche"
        Me.ShowInTaskbar = False
        Me.GroupBox1.ResumeLayout(False)
        Me.GroupBox1.PerformLayout()
        CType(Me.txtVal.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents btnValider As System.Windows.Forms.Button
    Friend WithEvents GroupBox1 As System.Windows.Forms.GroupBox
    Friend WithEvents lblVal As System.Windows.Forms.Label
    Friend WithEvents Label2 As System.Windows.Forms.Label
    Friend WithEvents Label6 As System.Windows.Forms.Label
    Friend WithEvents txtLib As System.Windows.Forms.TextBox
    Private WithEvents txtVal As DevExpress.XtraEditors.TextEdit
End Class
