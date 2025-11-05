<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmDetailsCle
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(frmDetailsCle))
        Me.GroupBox1 = New System.Windows.Forms.GroupBox()
        Me.BtnFermer = New System.Windows.Forms.Button()
        Me.BtnEnreg = New System.Windows.Forms.Button()
        Me.LabelTitre = New System.Windows.Forms.Label()
        Me.GroupBox3 = New System.Windows.Forms.GroupBox()
        Me.GroupBox2 = New System.Windows.Forms.GroupBox()
        Me.ApiRadioButtonYes = New MozartUC.apiRadioButton()
        Me.ApiRadioButtonNon = New MozartUC.apiRadioButton()
        Me.txtNumCleOrga = New System.Windows.Forms.TextBox()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.txtDateHabilitation = New DevExpress.XtraEditors.DateEdit()
        Me.txtDetenteurs = New System.Windows.Forms.TextBox()
        Me.txtAffect = New System.Windows.Forms.TextBox()
        Me.txtDesign = New System.Windows.Forms.TextBox()
        Me.Label12 = New System.Windows.Forms.Label()
        Me.txtObs = New System.Windows.Forms.TextBox()
        Me.txtRef = New System.Windows.Forms.TextBox()
        Me.Label9 = New System.Windows.Forms.Label()
        Me.Label7 = New System.Windows.Forms.Label()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.GroupBox1.SuspendLayout()
        Me.GroupBox3.SuspendLayout()
        Me.GroupBox2.SuspendLayout()
        CType(Me.txtDateHabilitation.Properties.CalendarTimeProperties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.txtDateHabilitation.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'GroupBox1
        '
        Me.GroupBox1.Controls.Add(Me.BtnFermer)
        Me.GroupBox1.Controls.Add(Me.BtnEnreg)
        resources.ApplyResources(Me.GroupBox1, "GroupBox1")
        Me.GroupBox1.Name = "GroupBox1"
        Me.GroupBox1.TabStop = False
        '
        'BtnFermer
        '
        resources.ApplyResources(Me.BtnFermer, "BtnFermer")
        Me.BtnFermer.Name = "BtnFermer"
        Me.BtnFermer.UseVisualStyleBackColor = True
        '
        'BtnEnreg
        '
        resources.ApplyResources(Me.BtnEnreg, "BtnEnreg")
        Me.BtnEnreg.Name = "BtnEnreg"
        Me.BtnEnreg.UseVisualStyleBackColor = True
        '
        'LabelTitre
        '
        resources.ApplyResources(Me.LabelTitre, "LabelTitre")
        Me.LabelTitre.Name = "LabelTitre"
        '
        'GroupBox3
        '
        Me.GroupBox3.Controls.Add(Me.GroupBox2)
        Me.GroupBox3.Controls.Add(Me.txtNumCleOrga)
        Me.GroupBox3.Controls.Add(Me.Label2)
        Me.GroupBox3.Controls.Add(Me.txtDateHabilitation)
        Me.GroupBox3.Controls.Add(Me.txtDetenteurs)
        Me.GroupBox3.Controls.Add(Me.txtAffect)
        Me.GroupBox3.Controls.Add(Me.txtDesign)
        Me.GroupBox3.Controls.Add(Me.Label12)
        Me.GroupBox3.Controls.Add(Me.txtObs)
        Me.GroupBox3.Controls.Add(Me.txtRef)
        Me.GroupBox3.Controls.Add(Me.Label9)
        Me.GroupBox3.Controls.Add(Me.Label7)
        Me.GroupBox3.Controls.Add(Me.Label5)
        Me.GroupBox3.Controls.Add(Me.Label4)
        Me.GroupBox3.Controls.Add(Me.Label3)
        Me.GroupBox3.Controls.Add(Me.Label1)
        resources.ApplyResources(Me.GroupBox3, "GroupBox3")
        Me.GroupBox3.ForeColor = System.Drawing.Color.Red
        Me.GroupBox3.Name = "GroupBox3"
        Me.GroupBox3.TabStop = False
        '
        'GroupBox2
        '
        Me.GroupBox2.Controls.Add(Me.ApiRadioButtonYes)
        Me.GroupBox2.Controls.Add(Me.ApiRadioButtonNon)
        resources.ApplyResources(Me.GroupBox2, "GroupBox2")
        Me.GroupBox2.Name = "GroupBox2"
        Me.GroupBox2.TabStop = False
        '
        'ApiRadioButtonYes
        '
        resources.ApplyResources(Me.ApiRadioButtonYes, "ApiRadioButtonYes")
        Me.ApiRadioButtonYes.ForeColor = System.Drawing.Color.Black
        Me.ApiRadioButtonYes.HelpContextID = 0
        Me.ApiRadioButtonYes.Name = "ApiRadioButtonYes"
        Me.ApiRadioButtonYes.UseVisualStyleBackColor = True
        '
        'ApiRadioButtonNon
        '
        resources.ApplyResources(Me.ApiRadioButtonNon, "ApiRadioButtonNon")
        Me.ApiRadioButtonNon.Checked = True
        Me.ApiRadioButtonNon.ForeColor = System.Drawing.Color.Black
        Me.ApiRadioButtonNon.HelpContextID = 0
        Me.ApiRadioButtonNon.Name = "ApiRadioButtonNon"
        Me.ApiRadioButtonNon.TabStop = True
        Me.ApiRadioButtonNon.UseVisualStyleBackColor = True
        '
        'txtNumCleOrga
        '
        resources.ApplyResources(Me.txtNumCleOrga, "txtNumCleOrga")
        Me.txtNumCleOrga.Name = "txtNumCleOrga"
        '
        'Label2
        '
        resources.ApplyResources(Me.Label2, "Label2")
        Me.Label2.ForeColor = System.Drawing.Color.Black
        Me.Label2.Name = "Label2"
        '
        'txtDateHabilitation
        '
        resources.ApplyResources(Me.txtDateHabilitation, "txtDateHabilitation")
        Me.txtDateHabilitation.Name = "txtDateHabilitation"
        Me.txtDateHabilitation.Properties.BorderStyle = DevExpress.XtraEditors.Controls.BorderStyles.Simple
        Me.txtDateHabilitation.Properties.Buttons.AddRange(New DevExpress.XtraEditors.Controls.EditorButton() {New DevExpress.XtraEditors.Controls.EditorButton(CType(resources.GetObject("txtDateHabilitation.Properties.Buttons"), DevExpress.XtraEditors.Controls.ButtonPredefines))})
        Me.txtDateHabilitation.Properties.CalendarTimeProperties.Buttons.AddRange(New DevExpress.XtraEditors.Controls.EditorButton() {New DevExpress.XtraEditors.Controls.EditorButton(CType(resources.GetObject("txtDateHabilitation.Properties.CalendarTimeProperties.Buttons"), DevExpress.XtraEditors.Controls.ButtonPredefines))})
        '
        'txtDetenteurs
        '
        resources.ApplyResources(Me.txtDetenteurs, "txtDetenteurs")
        Me.txtDetenteurs.Name = "txtDetenteurs"
        '
        'txtAffect
        '
        resources.ApplyResources(Me.txtAffect, "txtAffect")
        Me.txtAffect.Name = "txtAffect"
        '
        'txtDesign
        '
        resources.ApplyResources(Me.txtDesign, "txtDesign")
        Me.txtDesign.Name = "txtDesign"
        '
        'Label12
        '
        resources.ApplyResources(Me.Label12, "Label12")
        Me.Label12.ForeColor = System.Drawing.Color.Black
        Me.Label12.Name = "Label12"
        '
        'txtObs
        '
        resources.ApplyResources(Me.txtObs, "txtObs")
        Me.txtObs.Name = "txtObs"
        '
        'txtRef
        '
        resources.ApplyResources(Me.txtRef, "txtRef")
        Me.txtRef.Name = "txtRef"
        '
        'Label9
        '
        resources.ApplyResources(Me.Label9, "Label9")
        Me.Label9.ForeColor = System.Drawing.Color.Black
        Me.Label9.Name = "Label9"
        '
        'Label7
        '
        resources.ApplyResources(Me.Label7, "Label7")
        Me.Label7.ForeColor = System.Drawing.Color.Black
        Me.Label7.Name = "Label7"
        '
        'Label5
        '
        resources.ApplyResources(Me.Label5, "Label5")
        Me.Label5.ForeColor = System.Drawing.Color.Black
        Me.Label5.Name = "Label5"
        '
        'Label4
        '
        resources.ApplyResources(Me.Label4, "Label4")
        Me.Label4.ForeColor = System.Drawing.Color.Black
        Me.Label4.Name = "Label4"
        '
        'Label3
        '
        resources.ApplyResources(Me.Label3, "Label3")
        Me.Label3.ForeColor = System.Drawing.Color.Black
        Me.Label3.Name = "Label3"
        '
        'Label1
        '
        resources.ApplyResources(Me.Label1, "Label1")
        Me.Label1.ForeColor = System.Drawing.Color.Black
        Me.Label1.Name = "Label1"
        '
        'frmDetailsCle
        '
        resources.ApplyResources(Me, "$this")
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.Wheat
        Me.Controls.Add(Me.GroupBox3)
        Me.Controls.Add(Me.GroupBox1)
        Me.Controls.Add(Me.LabelTitre)
        Me.Name = "frmDetailsCle"
        Me.WindowState = System.Windows.Forms.FormWindowState.Maximized
        Me.GroupBox1.ResumeLayout(False)
        Me.GroupBox3.ResumeLayout(False)
        Me.GroupBox3.PerformLayout()
        Me.GroupBox2.ResumeLayout(False)
        Me.GroupBox2.PerformLayout()
        CType(Me.txtDateHabilitation.Properties.CalendarTimeProperties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.txtDateHabilitation.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents GroupBox1 As System.Windows.Forms.GroupBox
  Friend WithEvents BtnFermer As System.Windows.Forms.Button
  Friend WithEvents BtnEnreg As System.Windows.Forms.Button
  Friend WithEvents LabelTitre As System.Windows.Forms.Label
  Friend WithEvents GroupBox3 As System.Windows.Forms.GroupBox
  Friend WithEvents txtAffect As System.Windows.Forms.TextBox
  Friend WithEvents txtDesign As System.Windows.Forms.TextBox
    Friend WithEvents Label12 As System.Windows.Forms.Label
    Friend WithEvents txtObs As System.Windows.Forms.TextBox
    Friend WithEvents txtRef As System.Windows.Forms.TextBox
    Friend WithEvents Label9 As System.Windows.Forms.Label
    Friend WithEvents Label7 As System.Windows.Forms.Label
    Friend WithEvents Label5 As System.Windows.Forms.Label
    Friend WithEvents Label4 As System.Windows.Forms.Label
    Friend WithEvents Label3 As System.Windows.Forms.Label
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents txtDetenteurs As System.Windows.Forms.TextBox
    Friend WithEvents TxtNum As TextBox
    Private WithEvents txtDateHabilitation As DevExpress.XtraEditors.DateEdit
    Friend WithEvents GroupBox2 As GroupBox
    Friend WithEvents ApiRadioButtonYes As MozartUC.apiRadioButton
    Friend WithEvents ApiRadioButtonNon As MozartUC.apiRadioButton
    Friend WithEvents txtNumCleOrga As TextBox
    Friend WithEvents Label2 As Label
End Class
