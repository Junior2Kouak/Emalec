<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmDetailsTelephone
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
Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(frmDetailsTelephone))
Me.GroupBox1 = New System.Windows.Forms.GroupBox()
Me.BtnFermer = New System.Windows.Forms.Button()
Me.BtnEnreg = New System.Windows.Forms.Button()
Me.LabelTitre = New System.Windows.Forms.Label()
Me.GroupBox3 = New System.Windows.Forms.GroupBox()
Me.MonthCalendar1 = New System.Windows.Forms.MonthCalendar()
Me.CboSociete = New System.Windows.Forms.ComboBox()
Me.LblSociete = New System.Windows.Forms.Label()
Me.BtnDateEngagement = New System.Windows.Forms.Button()
Me.BtnSupp2 = New System.Windows.Forms.Button()
Me.TxtDteEngagement = New System.Windows.Forms.TextBox()
Me.LblDateEng = New System.Windows.Forms.Label()
Me.TxtOperateur = New System.Windows.Forms.TextBox()
Me.LblOperateur = New System.Windows.Forms.Label()
Me.cboUtil = New System.Windows.Forms.ComboBox()
Me.txtNumCode = New System.Windows.Forms.TextBox()
Me.txtNumAppel = New System.Windows.Forms.TextBox()
Me.cboProf = New System.Windows.Forms.ComboBox()
Me.BtnDate1 = New System.Windows.Forms.Button()
Me.BtnSupp1 = New System.Windows.Forms.Button()
Me.txtDtEntree = New System.Windows.Forms.TextBox()
Me.txtMateriel = New System.Windows.Forms.TextBox()
Me.txtObs = New System.Windows.Forms.TextBox()
Me.Label7 = New System.Windows.Forms.Label()
Me.Label12 = New System.Windows.Forms.Label()
Me.txtNumSIM = New System.Windows.Forms.TextBox()
Me.Label9 = New System.Windows.Forms.Label()
Me.Label8 = New System.Windows.Forms.Label()
Me.Label6 = New System.Windows.Forms.Label()
Me.Label5 = New System.Windows.Forms.Label()
Me.Label4 = New System.Windows.Forms.Label()
Me.Label3 = New System.Windows.Forms.Label()
Me.TxtNum = New System.Windows.Forms.TextBox()
Me.Label1 = New System.Windows.Forms.Label()
Me.LabelNTELNUM = New System.Windows.Forms.Label()
Me.LabelSociete = New System.Windows.Forms.Label()
Me.GroupBox1.SuspendLayout()
Me.GroupBox3.SuspendLayout()
Me.SuspendLayout()
'
'GroupBox1
'
resources.ApplyResources(Me.GroupBox1, "GroupBox1")
Me.GroupBox1.Controls.Add(Me.BtnFermer)
Me.GroupBox1.Controls.Add(Me.BtnEnreg)
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
resources.ApplyResources(Me.GroupBox3, "GroupBox3")
Me.GroupBox3.Controls.Add(Me.MonthCalendar1)
Me.GroupBox3.Controls.Add(Me.CboSociete)
Me.GroupBox3.Controls.Add(Me.LblSociete)
Me.GroupBox3.Controls.Add(Me.BtnDateEngagement)
Me.GroupBox3.Controls.Add(Me.BtnSupp2)
Me.GroupBox3.Controls.Add(Me.TxtDteEngagement)
Me.GroupBox3.Controls.Add(Me.LblDateEng)
Me.GroupBox3.Controls.Add(Me.TxtOperateur)
Me.GroupBox3.Controls.Add(Me.LblOperateur)
Me.GroupBox3.Controls.Add(Me.cboUtil)
Me.GroupBox3.Controls.Add(Me.txtNumCode)
Me.GroupBox3.Controls.Add(Me.txtNumAppel)
Me.GroupBox3.Controls.Add(Me.cboProf)
Me.GroupBox3.Controls.Add(Me.BtnDate1)
Me.GroupBox3.Controls.Add(Me.BtnSupp1)
Me.GroupBox3.Controls.Add(Me.txtDtEntree)
Me.GroupBox3.Controls.Add(Me.txtMateriel)
Me.GroupBox3.Controls.Add(Me.txtObs)
Me.GroupBox3.Controls.Add(Me.Label7)
Me.GroupBox3.Controls.Add(Me.Label12)
Me.GroupBox3.Controls.Add(Me.txtNumSIM)
Me.GroupBox3.Controls.Add(Me.Label9)
Me.GroupBox3.Controls.Add(Me.Label8)
Me.GroupBox3.Controls.Add(Me.Label6)
Me.GroupBox3.Controls.Add(Me.Label5)
Me.GroupBox3.Controls.Add(Me.Label4)
Me.GroupBox3.Controls.Add(Me.Label3)
Me.GroupBox3.Controls.Add(Me.TxtNum)
Me.GroupBox3.Controls.Add(Me.Label1)
Me.GroupBox3.ForeColor = System.Drawing.Color.Red
Me.GroupBox3.Name = "GroupBox3"
Me.GroupBox3.TabStop = False
'
'MonthCalendar1
'
resources.ApplyResources(Me.MonthCalendar1, "MonthCalendar1")
Me.MonthCalendar1.Name = "MonthCalendar1"
'
'CboSociete
'
resources.ApplyResources(Me.CboSociete, "CboSociete")
Me.CboSociete.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
Me.CboSociete.FormattingEnabled = True
Me.CboSociete.Name = "CboSociete"
Me.CboSociete.Tag = "112"
'
'LblSociete
'
resources.ApplyResources(Me.LblSociete, "LblSociete")
Me.LblSociete.ForeColor = System.Drawing.Color.Black
Me.LblSociete.Name = "LblSociete"
'
'BtnDateEngagement
'
resources.ApplyResources(Me.BtnDateEngagement, "BtnDateEngagement")
Me.BtnDateEngagement.Image = Global.MozartNet.My.Resources.Resources.choix_calendrier
Me.BtnDateEngagement.Name = "BtnDateEngagement"
Me.BtnDateEngagement.UseVisualStyleBackColor = True
'
'BtnSupp2
'
resources.ApplyResources(Me.BtnSupp2, "BtnSupp2")
Me.BtnSupp2.Image = Global.MozartNet.My.Resources.Resources.suppression
Me.BtnSupp2.Name = "BtnSupp2"
Me.BtnSupp2.UseVisualStyleBackColor = True
'
'TxtDteEngagement
'
resources.ApplyResources(Me.TxtDteEngagement, "TxtDteEngagement")
Me.TxtDteEngagement.Name = "TxtDteEngagement"
'
'LblDateEng
'
resources.ApplyResources(Me.LblDateEng, "LblDateEng")
Me.LblDateEng.ForeColor = System.Drawing.Color.Black
Me.LblDateEng.Name = "LblDateEng"
'
'TxtOperateur
'
resources.ApplyResources(Me.TxtOperateur, "TxtOperateur")
Me.TxtOperateur.Name = "TxtOperateur"
'
'LblOperateur
'
resources.ApplyResources(Me.LblOperateur, "LblOperateur")
Me.LblOperateur.ForeColor = System.Drawing.Color.Black
Me.LblOperateur.Name = "LblOperateur"
'
'cboUtil
'
resources.ApplyResources(Me.cboUtil, "cboUtil")
Me.cboUtil.DisplayMember = "VPERNOMPRENOM"
Me.cboUtil.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
Me.cboUtil.FormattingEnabled = True
Me.cboUtil.Name = "cboUtil"
Me.cboUtil.ValueMember = "NPERNUM"
'
'txtNumCode
'
resources.ApplyResources(Me.txtNumCode, "txtNumCode")
Me.txtNumCode.Name = "txtNumCode"
'
'txtNumAppel
'
resources.ApplyResources(Me.txtNumAppel, "txtNumAppel")
Me.txtNumAppel.Name = "txtNumAppel"
'
'cboProf
'
resources.ApplyResources(Me.cboProf, "cboProf")
Me.cboProf.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
Me.cboProf.FormattingEnabled = True
Me.cboProf.Items.AddRange(New Object() {resources.GetString("cboProf.Items"), resources.GetString("cboProf.Items1"), resources.GetString("cboProf.Items2"), resources.GetString("cboProf.Items3"), resources.GetString("cboProf.Items4"), resources.GetString("cboProf.Items5")})
Me.cboProf.Name = "cboProf"
'
'BtnDate1
'
resources.ApplyResources(Me.BtnDate1, "BtnDate1")
Me.BtnDate1.Image = Global.MozartNet.My.Resources.Resources.choix_calendrier
Me.BtnDate1.Name = "BtnDate1"
Me.BtnDate1.UseVisualStyleBackColor = True
'
'BtnSupp1
'
resources.ApplyResources(Me.BtnSupp1, "BtnSupp1")
Me.BtnSupp1.Image = Global.MozartNet.My.Resources.Resources.suppression
Me.BtnSupp1.Name = "BtnSupp1"
Me.BtnSupp1.UseVisualStyleBackColor = True
'
'txtDtEntree
'
resources.ApplyResources(Me.txtDtEntree, "txtDtEntree")
Me.txtDtEntree.Name = "txtDtEntree"
'
'txtMateriel
'
resources.ApplyResources(Me.txtMateriel, "txtMateriel")
Me.txtMateriel.Name = "txtMateriel"
'
'txtObs
'
resources.ApplyResources(Me.txtObs, "txtObs")
Me.txtObs.Name = "txtObs"
'
'Label7
'
resources.ApplyResources(Me.Label7, "Label7")
Me.Label7.ForeColor = System.Drawing.Color.Black
Me.Label7.Name = "Label7"
'
'Label12
'
resources.ApplyResources(Me.Label12, "Label12")
Me.Label12.ForeColor = System.Drawing.Color.Black
Me.Label12.Name = "Label12"
'
'txtNumSIM
'
resources.ApplyResources(Me.txtNumSIM, "txtNumSIM")
Me.txtNumSIM.Name = "txtNumSIM"
'
'Label9
'
resources.ApplyResources(Me.Label9, "Label9")
Me.Label9.ForeColor = System.Drawing.Color.Black
Me.Label9.Name = "Label9"
'
'Label8
'
resources.ApplyResources(Me.Label8, "Label8")
Me.Label8.ForeColor = System.Drawing.Color.Black
Me.Label8.Name = "Label8"
'
'Label6
'
resources.ApplyResources(Me.Label6, "Label6")
Me.Label6.ForeColor = System.Drawing.Color.Black
Me.Label6.Name = "Label6"
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
'TxtNum
'
resources.ApplyResources(Me.TxtNum, "TxtNum")
Me.TxtNum.BackColor = System.Drawing.Color.FromArgb(CType(CType(224, Byte), Integer), CType(CType(224, Byte), Integer), CType(CType(224, Byte), Integer))
Me.TxtNum.Name = "TxtNum"
'
'Label1
'
resources.ApplyResources(Me.Label1, "Label1")
Me.Label1.ForeColor = System.Drawing.Color.Black
Me.Label1.Name = "Label1"
'
'LabelNTELNUM
'
resources.ApplyResources(Me.LabelNTELNUM, "LabelNTELNUM")
Me.LabelNTELNUM.ForeColor = System.Drawing.Color.Red
Me.LabelNTELNUM.Name = "LabelNTELNUM"
'
'LabelSociete
'
resources.ApplyResources(Me.LabelSociete, "LabelSociete")
Me.LabelSociete.Name = "LabelSociete"
'
'frmDetailsTelephone
'
resources.ApplyResources(Me, "$this")
Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
Me.BackColor = System.Drawing.Color.Wheat
Me.Controls.Add(Me.LabelSociete)
Me.Controls.Add(Me.LabelNTELNUM)
Me.Controls.Add(Me.GroupBox3)
Me.Controls.Add(Me.GroupBox1)
Me.Controls.Add(Me.LabelTitre)
Me.Name = "frmDetailsTelephone"
Me.WindowState = System.Windows.Forms.FormWindowState.Maximized
Me.GroupBox1.ResumeLayout(False)
Me.GroupBox3.ResumeLayout(False)
Me.GroupBox3.PerformLayout()
Me.ResumeLayout(False)
Me.PerformLayout()

End Sub
  Friend WithEvents GroupBox1 As System.Windows.Forms.GroupBox
  Friend WithEvents BtnFermer As System.Windows.Forms.Button
  Friend WithEvents BtnEnreg As System.Windows.Forms.Button
  Friend WithEvents LabelTitre As System.Windows.Forms.Label
  Friend WithEvents GroupBox3 As System.Windows.Forms.GroupBox
  Friend WithEvents BtnDate1 As System.Windows.Forms.Button
  Friend WithEvents BtnSupp1 As System.Windows.Forms.Button
  Friend WithEvents cboProf As System.Windows.Forms.ComboBox
  Friend WithEvents txtDtEntree As System.Windows.Forms.TextBox
  Friend WithEvents txtMateriel As System.Windows.Forms.TextBox
  Friend WithEvents Label12 As System.Windows.Forms.Label
  Friend WithEvents txtObs As System.Windows.Forms.TextBox
  Friend WithEvents txtNumSIM As System.Windows.Forms.TextBox
  Friend WithEvents Label9 As System.Windows.Forms.Label
  Friend WithEvents Label8 As System.Windows.Forms.Label
  Friend WithEvents Label7 As System.Windows.Forms.Label
  Friend WithEvents Label6 As System.Windows.Forms.Label
  Friend WithEvents Label5 As System.Windows.Forms.Label
  Friend WithEvents Label4 As System.Windows.Forms.Label
  Friend WithEvents Label3 As System.Windows.Forms.Label
  Friend WithEvents TxtNum As System.Windows.Forms.TextBox
  Friend WithEvents Label1 As System.Windows.Forms.Label
  Friend WithEvents MonthCalendar1 As System.Windows.Forms.MonthCalendar
  Friend WithEvents txtNumCode As System.Windows.Forms.TextBox
  Friend WithEvents txtNumAppel As System.Windows.Forms.TextBox
  Friend WithEvents LabelNTELNUM As System.Windows.Forms.Label
  Friend WithEvents LabelSociete As System.Windows.Forms.Label
  Friend WithEvents cboUtil As System.Windows.Forms.ComboBox
  Friend WithEvents BtnDateEngagement As System.Windows.Forms.Button
  Friend WithEvents BtnSupp2 As System.Windows.Forms.Button
  Friend WithEvents TxtDteEngagement As System.Windows.Forms.TextBox
  Friend WithEvents LblDateEng As System.Windows.Forms.Label
  Friend WithEvents TxtOperateur As System.Windows.Forms.TextBox
  Friend WithEvents LblOperateur As System.Windows.Forms.Label
  Friend WithEvents CboSociete As System.Windows.Forms.ComboBox
  Friend WithEvents LblSociete As System.Windows.Forms.Label
End Class
