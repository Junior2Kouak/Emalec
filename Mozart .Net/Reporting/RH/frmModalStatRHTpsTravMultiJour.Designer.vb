<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmModalStatRHTpsTravMultiJour
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(frmModalStatRHTpsTravMultiJour))
        Me.GrpBoxPaveJour = New System.Windows.Forms.GroupBox()
        Me.LblIPLMultiEXE = New System.Windows.Forms.Label()
        Me.TimeEditExe = New DevExpress.XtraEditors.TimeEdit()
        Me.LblIPLMultiARR = New System.Windows.Forms.Label()
        Me.TimeEditArr = New DevExpress.XtraEditors.TimeEdit()
        Me.BtnValid = New System.Windows.Forms.Button()
        Me.GrpBoxPaveJour.SuspendLayout()
        CType(Me.TimeEditExe.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.TimeEditArr.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'GrpBoxPaveJour
        '
        resources.ApplyResources(Me.GrpBoxPaveJour, "GrpBoxPaveJour")
        Me.GrpBoxPaveJour.Controls.Add(Me.LblIPLMultiEXE)
        Me.GrpBoxPaveJour.Controls.Add(Me.TimeEditExe)
        Me.GrpBoxPaveJour.Controls.Add(Me.LblIPLMultiARR)
        Me.GrpBoxPaveJour.Controls.Add(Me.TimeEditArr)
        Me.GrpBoxPaveJour.Controls.Add(Me.BtnValid)
        Me.GrpBoxPaveJour.Name = "GrpBoxPaveJour"
        Me.GrpBoxPaveJour.TabStop = False
        '
        'LblIPLMultiEXE
        '
        resources.ApplyResources(Me.LblIPLMultiEXE, "LblIPLMultiEXE")
        Me.LblIPLMultiEXE.Name = "LblIPLMultiEXE"
        '
        'TimeEditExe
        '
        resources.ApplyResources(Me.TimeEditExe, "TimeEditExe")
        Me.TimeEditExe.Name = "TimeEditExe"
        '
        '
        '
        Me.TimeEditExe.Properties.AccessibleDescription = resources.GetString("TimeEditExe.Properties.AccessibleDescription")
        Me.TimeEditExe.Properties.AccessibleName = resources.GetString("TimeEditExe.Properties.AccessibleName")
        Me.TimeEditExe.Properties.Appearance.FontSizeDelta = CType(resources.GetObject("TimeEditExe.Properties.Appearance.FontSizeDelta"), Integer)
        Me.TimeEditExe.Properties.Appearance.FontStyleDelta = CType(resources.GetObject("TimeEditExe.Properties.Appearance.FontStyleDelta"), System.Drawing.FontStyle)
        Me.TimeEditExe.Properties.Appearance.GradientMode = CType(resources.GetObject("TimeEditExe.Properties.Appearance.GradientMode"), System.Drawing.Drawing2D.LinearGradientMode)
        Me.TimeEditExe.Properties.Appearance.Image = CType(resources.GetObject("TimeEditExe.Properties.Appearance.Image"), System.Drawing.Image)
        Me.TimeEditExe.Properties.Appearance.Options.UseTextOptions = True
        Me.TimeEditExe.Properties.Appearance.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center
        Me.TimeEditExe.Properties.Appearance.TextOptions.VAlignment = DevExpress.Utils.VertAlignment.Center
        Me.TimeEditExe.Properties.AutoHeight = CType(resources.GetObject("TimeEditExe.Properties.AutoHeight"), Boolean)
        Me.TimeEditExe.Properties.Buttons.AddRange(New DevExpress.XtraEditors.Controls.EditorButton() {New DevExpress.XtraEditors.Controls.EditorButton()})
        Me.TimeEditExe.Properties.Mask.AutoComplete = CType(resources.GetObject("TimeEditExe.Properties.Mask.AutoComplete"), DevExpress.XtraEditors.Mask.AutoCompleteType)
        Me.TimeEditExe.Properties.Mask.BeepOnError = CType(resources.GetObject("TimeEditExe.Properties.Mask.BeepOnError"), Boolean)
        Me.TimeEditExe.Properties.Mask.EditMask = resources.GetString("TimeEditExe.Properties.Mask.EditMask")
        Me.TimeEditExe.Properties.Mask.IgnoreMaskBlank = CType(resources.GetObject("TimeEditExe.Properties.Mask.IgnoreMaskBlank"), Boolean)
        Me.TimeEditExe.Properties.Mask.MaskType = CType(resources.GetObject("TimeEditExe.Properties.Mask.MaskType"), DevExpress.XtraEditors.Mask.MaskType)
        Me.TimeEditExe.Properties.Mask.PlaceHolder = CType(resources.GetObject("TimeEditExe.Properties.Mask.PlaceHolder"), Char)
        Me.TimeEditExe.Properties.Mask.SaveLiteral = CType(resources.GetObject("TimeEditExe.Properties.Mask.SaveLiteral"), Boolean)
        Me.TimeEditExe.Properties.Mask.ShowPlaceHolders = CType(resources.GetObject("TimeEditExe.Properties.Mask.ShowPlaceHolders"), Boolean)
        Me.TimeEditExe.Properties.Mask.UseMaskAsDisplayFormat = CType(resources.GetObject("TimeEditExe.Properties.Mask.UseMaskAsDisplayFormat"), Boolean)
        Me.TimeEditExe.Properties.NullValuePrompt = resources.GetString("TimeEditExe.Properties.NullValuePrompt")
        Me.TimeEditExe.Properties.NullValuePromptShowForEmptyValue = CType(resources.GetObject("TimeEditExe.Properties.NullValuePromptShowForEmptyValue"), Boolean)
        '
        'LblIPLMultiARR
        '
        resources.ApplyResources(Me.LblIPLMultiARR, "LblIPLMultiARR")
        Me.LblIPLMultiARR.Name = "LblIPLMultiARR"
        '
        'TimeEditArr
        '
        resources.ApplyResources(Me.TimeEditArr, "TimeEditArr")
        Me.TimeEditArr.Name = "TimeEditArr"
        '
        '
        '
        Me.TimeEditArr.Properties.AccessibleDescription = resources.GetString("TimeEditArr.Properties.AccessibleDescription")
        Me.TimeEditArr.Properties.AccessibleName = resources.GetString("TimeEditArr.Properties.AccessibleName")
        Me.TimeEditArr.Properties.Appearance.FontSizeDelta = CType(resources.GetObject("TimeEditArr.Properties.Appearance.FontSizeDelta"), Integer)
        Me.TimeEditArr.Properties.Appearance.FontStyleDelta = CType(resources.GetObject("TimeEditArr.Properties.Appearance.FontStyleDelta"), System.Drawing.FontStyle)
        Me.TimeEditArr.Properties.Appearance.GradientMode = CType(resources.GetObject("TimeEditArr.Properties.Appearance.GradientMode"), System.Drawing.Drawing2D.LinearGradientMode)
        Me.TimeEditArr.Properties.Appearance.Image = CType(resources.GetObject("TimeEditArr.Properties.Appearance.Image"), System.Drawing.Image)
        Me.TimeEditArr.Properties.Appearance.Options.UseTextOptions = True
        Me.TimeEditArr.Properties.Appearance.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center
        Me.TimeEditArr.Properties.Appearance.TextOptions.VAlignment = DevExpress.Utils.VertAlignment.Center
        Me.TimeEditArr.Properties.AutoHeight = CType(resources.GetObject("TimeEditArr.Properties.AutoHeight"), Boolean)
        Me.TimeEditArr.Properties.Buttons.AddRange(New DevExpress.XtraEditors.Controls.EditorButton() {New DevExpress.XtraEditors.Controls.EditorButton()})
        Me.TimeEditArr.Properties.Mask.AutoComplete = CType(resources.GetObject("TimeEditArr.Properties.Mask.AutoComplete"), DevExpress.XtraEditors.Mask.AutoCompleteType)
        Me.TimeEditArr.Properties.Mask.BeepOnError = CType(resources.GetObject("TimeEditArr.Properties.Mask.BeepOnError"), Boolean)
        Me.TimeEditArr.Properties.Mask.EditMask = resources.GetString("TimeEditArr.Properties.Mask.EditMask")
        Me.TimeEditArr.Properties.Mask.IgnoreMaskBlank = CType(resources.GetObject("TimeEditArr.Properties.Mask.IgnoreMaskBlank"), Boolean)
        Me.TimeEditArr.Properties.Mask.MaskType = CType(resources.GetObject("TimeEditArr.Properties.Mask.MaskType"), DevExpress.XtraEditors.Mask.MaskType)
        Me.TimeEditArr.Properties.Mask.PlaceHolder = CType(resources.GetObject("TimeEditArr.Properties.Mask.PlaceHolder"), Char)
        Me.TimeEditArr.Properties.Mask.SaveLiteral = CType(resources.GetObject("TimeEditArr.Properties.Mask.SaveLiteral"), Boolean)
        Me.TimeEditArr.Properties.Mask.ShowPlaceHolders = CType(resources.GetObject("TimeEditArr.Properties.Mask.ShowPlaceHolders"), Boolean)
        Me.TimeEditArr.Properties.Mask.UseMaskAsDisplayFormat = CType(resources.GetObject("TimeEditArr.Properties.Mask.UseMaskAsDisplayFormat"), Boolean)
        Me.TimeEditArr.Properties.NullValuePrompt = resources.GetString("TimeEditArr.Properties.NullValuePrompt")
        Me.TimeEditArr.Properties.NullValuePromptShowForEmptyValue = CType(resources.GetObject("TimeEditArr.Properties.NullValuePromptShowForEmptyValue"), Boolean)
        '
        'BtnValid
        '
        resources.ApplyResources(Me.BtnValid, "BtnValid")
        Me.BtnValid.Name = "BtnValid"
        Me.BtnValid.UseVisualStyleBackColor = True
        '
        'frmModalStatRHTpsTravMultiJour
        '
        resources.ApplyResources(Me, "$this")
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.Wheat
        Me.Controls.Add(Me.GrpBoxPaveJour)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle
        Me.MaximizeBox = False
        Me.MinimizeBox = False
        Me.Name = "frmModalStatRHTpsTravMultiJour"
        Me.GrpBoxPaveJour.ResumeLayout(False)
        CType(Me.TimeEditExe.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.TimeEditArr.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents GrpBoxPaveJour As System.Windows.Forms.GroupBox
    Friend WithEvents LblIPLMultiARR As System.Windows.Forms.Label
    Friend WithEvents BtnValid As System.Windows.Forms.Button
    Friend WithEvents LblIPLMultiEXE As System.Windows.Forms.Label
    Private WithEvents TimeEditArr As DevExpress.XtraEditors.TimeEdit
    Private WithEvents TimeEditExe As DevExpress.XtraEditors.TimeEdit
End Class
