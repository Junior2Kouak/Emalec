<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmNotationSTT
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
    Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(frmNotationSTT))
    Me.BtnValider = New System.Windows.Forms.Button()
    Me.BtnFermer = New System.Windows.Forms.Button()
    Me.LblTitre = New System.Windows.Forms.Label()
    Me.Label3 = New System.Windows.Forms.Label()
    Me.Label4 = New System.Windows.Forms.Label()
    Me.Label5 = New System.Windows.Forms.Label()
    Me.Label6 = New System.Windows.Forms.Label()
    Me.chkAfter = New DevExpress.XtraEditors.CheckedListBoxControl()
    Me.chkBefore = New DevExpress.XtraEditors.CheckedListBoxControl()
    CType(Me.chkAfter, System.ComponentModel.ISupportInitialize).BeginInit()
    CType(Me.chkBefore, System.ComponentModel.ISupportInitialize).BeginInit()
    Me.SuspendLayout()
    '
    'BtnValider
    '
    resources.ApplyResources(Me.BtnValider, "BtnValider")
    Me.BtnValider.Name = "BtnValider"
    Me.BtnValider.UseVisualStyleBackColor = True
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
    'Label3
    '
    resources.ApplyResources(Me.Label3, "Label3")
    Me.Label3.Name = "Label3"
    '
    'Label4
    '
    resources.ApplyResources(Me.Label4, "Label4")
    Me.Label4.ForeColor = System.Drawing.Color.Green
    Me.Label4.Name = "Label4"
    '
    'Label5
    '
    resources.ApplyResources(Me.Label5, "Label5")
    Me.Label5.Name = "Label5"
    '
    'Label6
    '
    resources.ApplyResources(Me.Label6, "Label6")
    Me.Label6.ForeColor = System.Drawing.Color.FromArgb(CType(CType(192, Byte), Integer), CType(CType(0, Byte), Integer), CType(CType(0, Byte), Integer))
    Me.Label6.Name = "Label6"
    '
    'chkAfter
    '
    resources.ApplyResources(Me.chkAfter, "chkAfter")
    Me.chkAfter.Appearance.BackColor = CType(resources.GetObject("chkAfter.Appearance.BackColor"), System.Drawing.Color)
    Me.chkAfter.Appearance.Font = CType(resources.GetObject("chkAfter.Appearance.Font"), System.Drawing.Font)
    Me.chkAfter.Appearance.FontSizeDelta = CType(resources.GetObject("chkAfter.Appearance.FontSizeDelta"), Integer)
    Me.chkAfter.Appearance.FontStyleDelta = CType(resources.GetObject("chkAfter.Appearance.FontStyleDelta"), System.Drawing.FontStyle)
    Me.chkAfter.Appearance.GradientMode = CType(resources.GetObject("chkAfter.Appearance.GradientMode"), System.Drawing.Drawing2D.LinearGradientMode)
    Me.chkAfter.Appearance.Image = CType(resources.GetObject("chkAfter.Appearance.Image"), System.Drawing.Image)
    Me.chkAfter.Appearance.Options.UseBackColor = True
    Me.chkAfter.Appearance.Options.UseFont = True
    Me.chkAfter.Appearance.Options.UseTextOptions = True
    Me.chkAfter.Appearance.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Far
    Me.chkAfter.BorderStyle = DevExpress.XtraEditors.Controls.BorderStyles.UltraFlat
    Me.chkAfter.CheckOnClick = True
    Me.chkAfter.Items.AddRange(New DevExpress.XtraEditors.Controls.CheckedListBoxItem() {New DevExpress.XtraEditors.Controls.CheckedListBoxItem(resources.GetString("chkAfter.Items"), resources.GetString("chkAfter.Items1"), CType(resources.GetObject("chkAfter.Items2"), Object)), New DevExpress.XtraEditors.Controls.CheckedListBoxItem(resources.GetString("chkAfter.Items3"), resources.GetString("chkAfter.Items4"), CType(resources.GetObject("chkAfter.Items5"), Object)), New DevExpress.XtraEditors.Controls.CheckedListBoxItem(resources.GetString("chkAfter.Items6"), resources.GetString("chkAfter.Items7"), CType(resources.GetObject("chkAfter.Items8"), Object)), New DevExpress.XtraEditors.Controls.CheckedListBoxItem(resources.GetString("chkAfter.Items9"), resources.GetString("chkAfter.Items10"), CType(resources.GetObject("chkAfter.Items11"), Object)), New DevExpress.XtraEditors.Controls.CheckedListBoxItem(resources.GetString("chkAfter.Items12"), resources.GetString("chkAfter.Items13"), CType(resources.GetObject("chkAfter.Items14"), Object))})
    Me.chkAfter.Name = "chkAfter"
    '
    'chkBefore
    '
    resources.ApplyResources(Me.chkBefore, "chkBefore")
    Me.chkBefore.Appearance.BackColor = CType(resources.GetObject("chkBefore.Appearance.BackColor"), System.Drawing.Color)
    Me.chkBefore.Appearance.Font = CType(resources.GetObject("chkBefore.Appearance.Font"), System.Drawing.Font)
    Me.chkBefore.Appearance.FontSizeDelta = CType(resources.GetObject("chkBefore.Appearance.FontSizeDelta"), Integer)
    Me.chkBefore.Appearance.FontStyleDelta = CType(resources.GetObject("chkBefore.Appearance.FontStyleDelta"), System.Drawing.FontStyle)
    Me.chkBefore.Appearance.GradientMode = CType(resources.GetObject("chkBefore.Appearance.GradientMode"), System.Drawing.Drawing2D.LinearGradientMode)
    Me.chkBefore.Appearance.Image = CType(resources.GetObject("chkBefore.Appearance.Image"), System.Drawing.Image)
    Me.chkBefore.Appearance.Options.UseBackColor = True
    Me.chkBefore.Appearance.Options.UseFont = True
    Me.chkBefore.Appearance.Options.UseTextOptions = True
    Me.chkBefore.Appearance.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Far
    Me.chkBefore.BorderStyle = DevExpress.XtraEditors.Controls.BorderStyles.UltraFlat
    Me.chkBefore.CheckOnClick = True
    Me.chkBefore.Items.AddRange(New DevExpress.XtraEditors.Controls.CheckedListBoxItem() {New DevExpress.XtraEditors.Controls.CheckedListBoxItem(resources.GetString("chkBefore.Items"), resources.GetString("chkBefore.Items1"), CType(resources.GetObject("chkBefore.Items2"), Object)), New DevExpress.XtraEditors.Controls.CheckedListBoxItem(resources.GetString("chkBefore.Items3"), resources.GetString("chkBefore.Items4"), CType(resources.GetObject("chkBefore.Items5"), Object)), New DevExpress.XtraEditors.Controls.CheckedListBoxItem(resources.GetString("chkBefore.Items6"), resources.GetString("chkBefore.Items7"), CType(resources.GetObject("chkBefore.Items8"), Object)), New DevExpress.XtraEditors.Controls.CheckedListBoxItem(resources.GetString("chkBefore.Items9"), resources.GetString("chkBefore.Items10"), CType(resources.GetObject("chkBefore.Items11"), Object)), New DevExpress.XtraEditors.Controls.CheckedListBoxItem(resources.GetString("chkBefore.Items12"), resources.GetString("chkBefore.Items13"), CType(resources.GetObject("chkBefore.Items14"), Object))})
    Me.chkBefore.Name = "chkBefore"
    '
    'frmNotationSTT
    '
    resources.ApplyResources(Me, "$this")
    Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
    Me.BackColor = System.Drawing.Color.Wheat
    Me.Controls.Add(Me.chkBefore)
    Me.Controls.Add(Me.chkAfter)
    Me.Controls.Add(Me.Label6)
    Me.Controls.Add(Me.Label5)
    Me.Controls.Add(Me.Label4)
    Me.Controls.Add(Me.Label3)
    Me.Controls.Add(Me.LblTitre)
    Me.Controls.Add(Me.BtnFermer)
    Me.Controls.Add(Me.BtnValider)
    Me.Name = "frmNotationSTT"
    CType(Me.chkAfter, System.ComponentModel.ISupportInitialize).EndInit()
    CType(Me.chkBefore, System.ComponentModel.ISupportInitialize).EndInit()
    Me.ResumeLayout(False)
    Me.PerformLayout()

  End Sub

  Friend WithEvents BtnValider As Button
  Friend WithEvents BtnFermer As Button
  Friend WithEvents LblTitre As Label
  Friend WithEvents Label3 As Label
  Friend WithEvents Label4 As Label
  Friend WithEvents Label5 As Label
  Friend WithEvents Label6 As Label
  Friend WithEvents chkAfter As DevExpress.XtraEditors.CheckedListBoxControl
  Friend WithEvents chkBefore As DevExpress.XtraEditors.CheckedListBoxControl
End Class
