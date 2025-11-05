<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class FrmGestDocDetail
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(FrmGestDocDetail))
        Me.LabelTitre = New System.Windows.Forms.Label()
        Me.GrpActions = New System.Windows.Forms.GroupBox()
        Me.BtnFile = New System.Windows.Forms.Button()
        Me.ButtonEnreg = New System.Windows.Forms.Button()
        Me.BtnFermer = New System.Windows.Forms.Button()
        Me.GrpFileInfo = New System.Windows.Forms.GroupBox()
        Me.DatePublication = New DevExpress.XtraEditors.DateEdit()
        Me.TxtTitreFiche = New System.Windows.Forms.TextBox()
        Me.LblTitreDetailNom = New System.Windows.Forms.Label()
        Me.LblTitreDatePubli = New System.Windows.Forms.Label()
        Me.GrpFile = New System.Windows.Forms.GroupBox()
        Me.WBFile = New System.Windows.Forms.WebBrowser()
        Me.OFD = New System.Windows.Forms.OpenFileDialog()
        Me.GrpActions.SuspendLayout()
        Me.GrpFileInfo.SuspendLayout()
        CType(Me.DatePublication.Properties.CalendarTimeProperties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.DatePublication.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.GrpFile.SuspendLayout()
        Me.SuspendLayout()
        '
        'LabelTitre
        '
        resources.ApplyResources(Me.LabelTitre, "LabelTitre")
        Me.LabelTitre.Name = "LabelTitre"
        '
        'GrpActions
        '
        resources.ApplyResources(Me.GrpActions, "GrpActions")
        Me.GrpActions.Controls.Add(Me.BtnFile)
        Me.GrpActions.Controls.Add(Me.ButtonEnreg)
        Me.GrpActions.Controls.Add(Me.BtnFermer)
        Me.GrpActions.Name = "GrpActions"
        Me.GrpActions.TabStop = False
        '
        'BtnFile
        '
        resources.ApplyResources(Me.BtnFile, "BtnFile")
        Me.BtnFile.Name = "BtnFile"
        Me.BtnFile.UseVisualStyleBackColor = True
        '
        'ButtonEnreg
        '
        resources.ApplyResources(Me.ButtonEnreg, "ButtonEnreg")
        Me.ButtonEnreg.Name = "ButtonEnreg"
        Me.ButtonEnreg.UseVisualStyleBackColor = True
        '
        'BtnFermer
        '
        resources.ApplyResources(Me.BtnFermer, "BtnFermer")
        Me.BtnFermer.Name = "BtnFermer"
        Me.BtnFermer.UseVisualStyleBackColor = True
        '
        'GrpFileInfo
        '
        resources.ApplyResources(Me.GrpFileInfo, "GrpFileInfo")
        Me.GrpFileInfo.Controls.Add(Me.DatePublication)
        Me.GrpFileInfo.Controls.Add(Me.TxtTitreFiche)
        Me.GrpFileInfo.Controls.Add(Me.LblTitreDetailNom)
        Me.GrpFileInfo.Controls.Add(Me.LblTitreDatePubli)
        Me.GrpFileInfo.Name = "GrpFileInfo"
        Me.GrpFileInfo.TabStop = False
        '
        'DatePublication
        '
        resources.ApplyResources(Me.DatePublication, "DatePublication")
        Me.DatePublication.Name = "DatePublication"
        Me.DatePublication.Properties.AccessibleDescription = resources.GetString("DatePublication.Properties.AccessibleDescription")
        Me.DatePublication.Properties.AccessibleName = resources.GetString("DatePublication.Properties.AccessibleName")
        Me.DatePublication.Properties.AutoHeight = CType(resources.GetObject("DatePublication.Properties.AutoHeight"), Boolean)
        Me.DatePublication.Properties.Buttons.AddRange(New DevExpress.XtraEditors.Controls.EditorButton() {New DevExpress.XtraEditors.Controls.EditorButton(CType(resources.GetObject("DatePublication.Properties.Buttons"), DevExpress.XtraEditors.Controls.ButtonPredefines))})
        Me.DatePublication.Properties.CalendarTimeProperties.AccessibleDescription = resources.GetString("DatePublication.Properties.CalendarTimeProperties.AccessibleDescription")
        Me.DatePublication.Properties.CalendarTimeProperties.AccessibleName = resources.GetString("DatePublication.Properties.CalendarTimeProperties.AccessibleName")
        Me.DatePublication.Properties.CalendarTimeProperties.AutoHeight = CType(resources.GetObject("DatePublication.Properties.CalendarTimeProperties.AutoHeight"), Boolean)
        Me.DatePublication.Properties.CalendarTimeProperties.Buttons.AddRange(New DevExpress.XtraEditors.Controls.EditorButton() {New DevExpress.XtraEditors.Controls.EditorButton(CType(resources.GetObject("DatePublication.Properties.CalendarTimeProperties.Buttons"), DevExpress.XtraEditors.Controls.ButtonPredefines))})
        Me.DatePublication.Properties.CalendarTimeProperties.Mask.AutoComplete = CType(resources.GetObject("DatePublication.Properties.CalendarTimeProperties.Mask.AutoComplete"), DevExpress.XtraEditors.Mask.AutoCompleteType)
        Me.DatePublication.Properties.CalendarTimeProperties.Mask.BeepOnError = CType(resources.GetObject("DatePublication.Properties.CalendarTimeProperties.Mask.BeepOnError"), Boolean)
        Me.DatePublication.Properties.CalendarTimeProperties.Mask.EditMask = resources.GetString("DatePublication.Properties.CalendarTimeProperties.Mask.EditMask")
        Me.DatePublication.Properties.CalendarTimeProperties.Mask.IgnoreMaskBlank = CType(resources.GetObject("DatePublication.Properties.CalendarTimeProperties.Mask.IgnoreMaskBlank"), Boolean)
        Me.DatePublication.Properties.CalendarTimeProperties.Mask.MaskType = CType(resources.GetObject("DatePublication.Properties.CalendarTimeProperties.Mask.MaskType"), DevExpress.XtraEditors.Mask.MaskType)
        Me.DatePublication.Properties.CalendarTimeProperties.Mask.PlaceHolder = CType(resources.GetObject("DatePublication.Properties.CalendarTimeProperties.Mask.PlaceHolder"), Char)
        Me.DatePublication.Properties.CalendarTimeProperties.Mask.SaveLiteral = CType(resources.GetObject("DatePublication.Properties.CalendarTimeProperties.Mask.SaveLiteral"), Boolean)
        Me.DatePublication.Properties.CalendarTimeProperties.Mask.ShowPlaceHolders = CType(resources.GetObject("DatePublication.Properties.CalendarTimeProperties.Mask.ShowPlaceHolders"), Boolean)
        Me.DatePublication.Properties.CalendarTimeProperties.Mask.UseMaskAsDisplayFormat = CType(resources.GetObject("DatePublication.Properties.CalendarTimeProperties.Mask.UseMaskAsDisplayFormat"), Boolean)
        Me.DatePublication.Properties.CalendarTimeProperties.NullValuePrompt = resources.GetString("DatePublication.Properties.CalendarTimeProperties.NullValuePrompt")
        Me.DatePublication.Properties.CalendarTimeProperties.NullValuePromptShowForEmptyValue = CType(resources.GetObject("DatePublication.Properties.CalendarTimeProperties.NullValuePromptShowForEmptyValu" &
        "e"), Boolean)
        Me.DatePublication.Properties.Mask.AutoComplete = CType(resources.GetObject("DatePublication.Properties.Mask.AutoComplete"), DevExpress.XtraEditors.Mask.AutoCompleteType)
        Me.DatePublication.Properties.Mask.BeepOnError = CType(resources.GetObject("DatePublication.Properties.Mask.BeepOnError"), Boolean)
        Me.DatePublication.Properties.Mask.EditMask = resources.GetString("DatePublication.Properties.Mask.EditMask")
        Me.DatePublication.Properties.Mask.IgnoreMaskBlank = CType(resources.GetObject("DatePublication.Properties.Mask.IgnoreMaskBlank"), Boolean)
        Me.DatePublication.Properties.Mask.MaskType = CType(resources.GetObject("DatePublication.Properties.Mask.MaskType"), DevExpress.XtraEditors.Mask.MaskType)
        Me.DatePublication.Properties.Mask.PlaceHolder = CType(resources.GetObject("DatePublication.Properties.Mask.PlaceHolder"), Char)
        Me.DatePublication.Properties.Mask.SaveLiteral = CType(resources.GetObject("DatePublication.Properties.Mask.SaveLiteral"), Boolean)
        Me.DatePublication.Properties.Mask.ShowPlaceHolders = CType(resources.GetObject("DatePublication.Properties.Mask.ShowPlaceHolders"), Boolean)
        Me.DatePublication.Properties.Mask.UseMaskAsDisplayFormat = CType(resources.GetObject("DatePublication.Properties.Mask.UseMaskAsDisplayFormat"), Boolean)
        Me.DatePublication.Properties.NullValuePrompt = resources.GetString("DatePublication.Properties.NullValuePrompt")
        Me.DatePublication.Properties.NullValuePromptShowForEmptyValue = CType(resources.GetObject("DatePublication.Properties.NullValuePromptShowForEmptyValue"), Boolean)
        '
        'TxtTitreFiche
        '
        resources.ApplyResources(Me.TxtTitreFiche, "TxtTitreFiche")
        Me.TxtTitreFiche.Name = "TxtTitreFiche"
        '
        'LblTitreDetailNom
        '
        resources.ApplyResources(Me.LblTitreDetailNom, "LblTitreDetailNom")
        Me.LblTitreDetailNom.ForeColor = System.Drawing.Color.Black
        Me.LblTitreDetailNom.Name = "LblTitreDetailNom"
        '
        'LblTitreDatePubli
        '
        resources.ApplyResources(Me.LblTitreDatePubli, "LblTitreDatePubli")
        Me.LblTitreDatePubli.ForeColor = System.Drawing.Color.Black
        Me.LblTitreDatePubli.Name = "LblTitreDatePubli"
        '
        'GrpFile
        '
        resources.ApplyResources(Me.GrpFile, "GrpFile")
        Me.GrpFile.Controls.Add(Me.WBFile)
        Me.GrpFile.Name = "GrpFile"
        Me.GrpFile.TabStop = False
        '
        'WBFile
        '
        resources.ApplyResources(Me.WBFile, "WBFile")
        Me.WBFile.Name = "WBFile"
        '
        'OFD
        '
        resources.ApplyResources(Me.OFD, "OFD")
        '
        'FrmGestDocDetail
        '
        resources.ApplyResources(Me, "$this")
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.Wheat
        Me.Controls.Add(Me.GrpFile)
        Me.Controls.Add(Me.GrpFileInfo)
        Me.Controls.Add(Me.LabelTitre)
        Me.Controls.Add(Me.GrpActions)
        Me.Name = "FrmGestDocDetail"
        Me.WindowState = System.Windows.Forms.FormWindowState.Maximized
        Me.GrpActions.ResumeLayout(False)
        Me.GrpFileInfo.ResumeLayout(False)
        Me.GrpFileInfo.PerformLayout()
        CType(Me.DatePublication.Properties.CalendarTimeProperties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.DatePublication.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        Me.GrpFile.ResumeLayout(False)
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents LabelTitre As System.Windows.Forms.Label
    Friend WithEvents GrpActions As System.Windows.Forms.GroupBox
    Friend WithEvents ButtonEnreg As System.Windows.Forms.Button
    Friend WithEvents BtnFermer As System.Windows.Forms.Button
    Friend WithEvents GrpFileInfo As System.Windows.Forms.GroupBox
    Friend WithEvents GrpFile As System.Windows.Forms.GroupBox
    Friend WithEvents BtnFile As System.Windows.Forms.Button
    Friend WithEvents TxtTitreFiche As System.Windows.Forms.TextBox
    Friend WithEvents LblTitreDetailNom As System.Windows.Forms.Label
    Friend WithEvents LblTitreDatePubli As System.Windows.Forms.Label
    Friend WithEvents DatePublication As DevExpress.XtraEditors.DateEdit
    Friend WithEvents WBFile As System.Windows.Forms.WebBrowser
    Friend WithEvents OFD As System.Windows.Forms.OpenFileDialog
End Class
