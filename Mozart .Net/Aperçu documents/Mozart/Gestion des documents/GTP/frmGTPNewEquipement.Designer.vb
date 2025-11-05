<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmGTPNewEquipement
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(frmGTPNewEquipement))
        Me.GrpCreateNewEquip = New System.Windows.Forms.GroupBox()
        Me.txtDureeVie = New DevExpress.XtraEditors.TextEdit()
        Me.txtCout = New DevExpress.XtraEditors.TextEdit()
        Me.CboUnite = New System.Windows.Forms.ComboBox()
        Me.Label7 = New System.Windows.Forms.Label()
        Me.Label6 = New System.Windows.Forms.Label()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.txtPrecision = New System.Windows.Forms.TextBox()
        Me.txtNomEquipement = New System.Windows.Forms.TextBox()
        Me.CboLot = New System.Windows.Forms.ComboBox()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.BtnCancel = New System.Windows.Forms.Button()
        Me.BtnCreate = New System.Windows.Forms.Button()
        Me.GrpCreateNewEquip.SuspendLayout()
        CType(Me.txtDureeVie.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.txtCout.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'GrpCreateNewEquip
        '
        resources.ApplyResources(Me.GrpCreateNewEquip, "GrpCreateNewEquip")
        Me.GrpCreateNewEquip.Controls.Add(Me.txtDureeVie)
        Me.GrpCreateNewEquip.Controls.Add(Me.txtCout)
        Me.GrpCreateNewEquip.Controls.Add(Me.CboUnite)
        Me.GrpCreateNewEquip.Controls.Add(Me.Label7)
        Me.GrpCreateNewEquip.Controls.Add(Me.Label6)
        Me.GrpCreateNewEquip.Controls.Add(Me.Label4)
        Me.GrpCreateNewEquip.Controls.Add(Me.txtPrecision)
        Me.GrpCreateNewEquip.Controls.Add(Me.txtNomEquipement)
        Me.GrpCreateNewEquip.Controls.Add(Me.CboLot)
        Me.GrpCreateNewEquip.Controls.Add(Me.Label3)
        Me.GrpCreateNewEquip.Controls.Add(Me.Label2)
        Me.GrpCreateNewEquip.Controls.Add(Me.Label1)
        Me.GrpCreateNewEquip.Controls.Add(Me.BtnCancel)
        Me.GrpCreateNewEquip.Controls.Add(Me.BtnCreate)
        Me.GrpCreateNewEquip.Name = "GrpCreateNewEquip"
        Me.GrpCreateNewEquip.TabStop = False
        '
        'txtDureeVie
        '
        resources.ApplyResources(Me.txtDureeVie, "txtDureeVie")
        Me.txtDureeVie.Name = "txtDureeVie"
        '
        '
        '
        Me.txtDureeVie.Properties.AccessibleDescription = resources.GetString("txtDureeVie.Properties.AccessibleDescription")
        Me.txtDureeVie.Properties.AccessibleName = resources.GetString("txtDureeVie.Properties.AccessibleName")
        Me.txtDureeVie.Properties.Appearance.Font = CType(resources.GetObject("txtDureeVie.Properties.Appearance.Font"), System.Drawing.Font)
        Me.txtDureeVie.Properties.Appearance.FontSizeDelta = CType(resources.GetObject("txtDureeVie.Properties.Appearance.FontSizeDelta"), Integer)
        Me.txtDureeVie.Properties.Appearance.FontStyleDelta = CType(resources.GetObject("txtDureeVie.Properties.Appearance.FontStyleDelta"), System.Drawing.FontStyle)
        Me.txtDureeVie.Properties.Appearance.GradientMode = CType(resources.GetObject("txtDureeVie.Properties.Appearance.GradientMode"), System.Drawing.Drawing2D.LinearGradientMode)
        Me.txtDureeVie.Properties.Appearance.Image = CType(resources.GetObject("txtDureeVie.Properties.Appearance.Image"), System.Drawing.Image)
        Me.txtDureeVie.Properties.Appearance.Options.UseFont = True
        Me.txtDureeVie.Properties.AutoHeight = CType(resources.GetObject("txtDureeVie.Properties.AutoHeight"), Boolean)
        Me.txtDureeVie.Properties.BorderStyle = DevExpress.XtraEditors.Controls.BorderStyles.Simple
        Me.txtDureeVie.Properties.DisplayFormat.FormatString = "c"
        Me.txtDureeVie.Properties.DisplayFormat.FormatType = DevExpress.Utils.FormatType.Numeric
        Me.txtDureeVie.Properties.Mask.AutoComplete = CType(resources.GetObject("txtDureeVie.Properties.Mask.AutoComplete"), DevExpress.XtraEditors.Mask.AutoCompleteType)
        Me.txtDureeVie.Properties.Mask.BeepOnError = CType(resources.GetObject("txtDureeVie.Properties.Mask.BeepOnError"), Boolean)
        Me.txtDureeVie.Properties.Mask.EditMask = resources.GetString("txtDureeVie.Properties.Mask.EditMask")
        Me.txtDureeVie.Properties.Mask.IgnoreMaskBlank = CType(resources.GetObject("txtDureeVie.Properties.Mask.IgnoreMaskBlank"), Boolean)
        Me.txtDureeVie.Properties.Mask.MaskType = CType(resources.GetObject("txtDureeVie.Properties.Mask.MaskType"), DevExpress.XtraEditors.Mask.MaskType)
        Me.txtDureeVie.Properties.Mask.PlaceHolder = CType(resources.GetObject("txtDureeVie.Properties.Mask.PlaceHolder"), Char)
        Me.txtDureeVie.Properties.Mask.SaveLiteral = CType(resources.GetObject("txtDureeVie.Properties.Mask.SaveLiteral"), Boolean)
        Me.txtDureeVie.Properties.Mask.ShowPlaceHolders = CType(resources.GetObject("txtDureeVie.Properties.Mask.ShowPlaceHolders"), Boolean)
        Me.txtDureeVie.Properties.Mask.UseMaskAsDisplayFormat = CType(resources.GetObject("txtDureeVie.Properties.Mask.UseMaskAsDisplayFormat"), Boolean)
        Me.txtDureeVie.Properties.NullValuePrompt = resources.GetString("txtDureeVie.Properties.NullValuePrompt")
        Me.txtDureeVie.Properties.NullValuePromptShowForEmptyValue = CType(resources.GetObject("txtDureeVie.Properties.NullValuePromptShowForEmptyValue"), Boolean)
        '
        'txtCout
        '
        resources.ApplyResources(Me.txtCout, "txtCout")
        Me.txtCout.Name = "txtCout"
        '
        '
        '
        Me.txtCout.Properties.AccessibleDescription = resources.GetString("txtCout.Properties.AccessibleDescription")
        Me.txtCout.Properties.AccessibleName = resources.GetString("txtCout.Properties.AccessibleName")
        Me.txtCout.Properties.Appearance.Font = CType(resources.GetObject("txtCout.Properties.Appearance.Font"), System.Drawing.Font)
        Me.txtCout.Properties.Appearance.FontSizeDelta = CType(resources.GetObject("txtCout.Properties.Appearance.FontSizeDelta"), Integer)
        Me.txtCout.Properties.Appearance.FontStyleDelta = CType(resources.GetObject("txtCout.Properties.Appearance.FontStyleDelta"), System.Drawing.FontStyle)
        Me.txtCout.Properties.Appearance.GradientMode = CType(resources.GetObject("txtCout.Properties.Appearance.GradientMode"), System.Drawing.Drawing2D.LinearGradientMode)
        Me.txtCout.Properties.Appearance.Image = CType(resources.GetObject("txtCout.Properties.Appearance.Image"), System.Drawing.Image)
        Me.txtCout.Properties.Appearance.Options.UseFont = True
        Me.txtCout.Properties.AutoHeight = CType(resources.GetObject("txtCout.Properties.AutoHeight"), Boolean)
        Me.txtCout.Properties.BorderStyle = DevExpress.XtraEditors.Controls.BorderStyles.Simple
        Me.txtCout.Properties.DisplayFormat.FormatString = "### ### ##0. ###"
        Me.txtCout.Properties.DisplayFormat.FormatType = DevExpress.Utils.FormatType.Custom
        Me.txtCout.Properties.Mask.AutoComplete = CType(resources.GetObject("txtCout.Properties.Mask.AutoComplete"), DevExpress.XtraEditors.Mask.AutoCompleteType)
        Me.txtCout.Properties.Mask.BeepOnError = CType(resources.GetObject("txtCout.Properties.Mask.BeepOnError"), Boolean)
        Me.txtCout.Properties.Mask.EditMask = resources.GetString("txtCout.Properties.Mask.EditMask")
        Me.txtCout.Properties.Mask.IgnoreMaskBlank = CType(resources.GetObject("txtCout.Properties.Mask.IgnoreMaskBlank"), Boolean)
        Me.txtCout.Properties.Mask.MaskType = CType(resources.GetObject("txtCout.Properties.Mask.MaskType"), DevExpress.XtraEditors.Mask.MaskType)
        Me.txtCout.Properties.Mask.PlaceHolder = CType(resources.GetObject("txtCout.Properties.Mask.PlaceHolder"), Char)
        Me.txtCout.Properties.Mask.SaveLiteral = CType(resources.GetObject("txtCout.Properties.Mask.SaveLiteral"), Boolean)
        Me.txtCout.Properties.Mask.ShowPlaceHolders = CType(resources.GetObject("txtCout.Properties.Mask.ShowPlaceHolders"), Boolean)
        Me.txtCout.Properties.Mask.UseMaskAsDisplayFormat = CType(resources.GetObject("txtCout.Properties.Mask.UseMaskAsDisplayFormat"), Boolean)
        Me.txtCout.Properties.NullValuePrompt = resources.GetString("txtCout.Properties.NullValuePrompt")
        Me.txtCout.Properties.NullValuePromptShowForEmptyValue = CType(resources.GetObject("txtCout.Properties.NullValuePromptShowForEmptyValue"), Boolean)
        '
        'CboUnite
        '
        resources.ApplyResources(Me.CboUnite, "CboUnite")
        Me.CboUnite.DisplayMember = "VGTPUNITENOM"
        Me.CboUnite.FormattingEnabled = True
        Me.CboUnite.Name = "CboUnite"
        Me.CboUnite.ValueMember = "NGTPUNITEID"
        '
        'Label7
        '
        resources.ApplyResources(Me.Label7, "Label7")
        Me.Label7.Name = "Label7"
        '
        'Label6
        '
        resources.ApplyResources(Me.Label6, "Label6")
        Me.Label6.Name = "Label6"
        '
        'Label4
        '
        resources.ApplyResources(Me.Label4, "Label4")
        Me.Label4.Name = "Label4"
        '
        'txtPrecision
        '
        resources.ApplyResources(Me.txtPrecision, "txtPrecision")
        Me.txtPrecision.Name = "txtPrecision"
        '
        'txtNomEquipement
        '
        resources.ApplyResources(Me.txtNomEquipement, "txtNomEquipement")
        Me.txtNomEquipement.Name = "txtNomEquipement"
        '
        'CboLot
        '
        resources.ApplyResources(Me.CboLot, "CboLot")
        Me.CboLot.DisplayMember = "VGTPLOTNOM"
        Me.CboLot.FormattingEnabled = True
        Me.CboLot.Name = "CboLot"
        Me.CboLot.ValueMember = "NGTPLOTID"
        '
        'Label3
        '
        resources.ApplyResources(Me.Label3, "Label3")
        Me.Label3.Name = "Label3"
        '
        'Label2
        '
        resources.ApplyResources(Me.Label2, "Label2")
        Me.Label2.Name = "Label2"
        '
        'Label1
        '
        resources.ApplyResources(Me.Label1, "Label1")
        Me.Label1.Name = "Label1"
        '
        'BtnCancel
        '
        resources.ApplyResources(Me.BtnCancel, "BtnCancel")
        Me.BtnCancel.Name = "BtnCancel"
        Me.BtnCancel.UseVisualStyleBackColor = True
        '
        'BtnCreate
        '
        resources.ApplyResources(Me.BtnCreate, "BtnCreate")
        Me.BtnCreate.Name = "BtnCreate"
        Me.BtnCreate.UseVisualStyleBackColor = True
        '
        'frmGTPNewEquipement
        '
        resources.ApplyResources(Me, "$this")
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.Wheat
        Me.Controls.Add(Me.GrpCreateNewEquip)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle
        Me.MaximizeBox = False
        Me.Name = "frmGTPNewEquipement"
        Me.GrpCreateNewEquip.ResumeLayout(False)
        Me.GrpCreateNewEquip.PerformLayout()
        CType(Me.txtDureeVie.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.txtCout.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents GrpCreateNewEquip As System.Windows.Forms.GroupBox
    Friend WithEvents BtnCancel As System.Windows.Forms.Button
    Friend WithEvents BtnCreate As System.Windows.Forms.Button
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents Label3 As System.Windows.Forms.Label
    Friend WithEvents Label2 As System.Windows.Forms.Label
    Friend WithEvents txtPrecision As System.Windows.Forms.TextBox
    Friend WithEvents txtNomEquipement As System.Windows.Forms.TextBox
    Friend WithEvents Label4 As System.Windows.Forms.Label
    Friend WithEvents Label6 As System.Windows.Forms.Label
    Friend WithEvents Label7 As System.Windows.Forms.Label
    Friend WithEvents CboLot As System.Windows.Forms.ComboBox
    Friend WithEvents CboUnite As System.Windows.Forms.ComboBox
    Private WithEvents txtCout As DevExpress.XtraEditors.TextEdit
    Private WithEvents txtDureeVie As DevExpress.XtraEditors.TextEdit
End Class
