<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmGestionServiceTechniqueDetails
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(frmGestionServiceTechniqueDetails))
        Me.LabelTitre = New System.Windows.Forms.Label()
        Me.GroupBox1 = New System.Windows.Forms.GroupBox()
        Me.ButtonEnreg = New System.Windows.Forms.Button()
        Me.BtnFermer = New System.Windows.Forms.Button()
        Me.GroupBox2 = New System.Windows.Forms.GroupBox()
        Me.GroupBox8 = New System.Windows.Forms.GroupBox()
        Me.cbMultiDocsDansPDF = New System.Windows.Forms.CheckBox()
        Me.TxtFileSrc = New System.Windows.Forms.TextBox()
        Me.Label22 = New System.Windows.Forms.Label()
        Me.btnParcourir = New System.Windows.Forms.Button()
        Me.GroupBox7 = New System.Windows.Forms.GroupBox()
        Me.TxtMailtech = New System.Windows.Forms.TextBox()
        Me.TxtFaxtech = New System.Windows.Forms.TextBox()
        Me.TxtPortabletech = New System.Windows.Forms.TextBox()
        Me.TxtTeltech = New System.Windows.Forms.TextBox()
        Me.TxtQualitetech = New System.Windows.Forms.TextBox()
        Me.ComboCivilitetech = New System.Windows.Forms.ComboBox()
        Me.TxtPrenomtech = New System.Windows.Forms.TextBox()
        Me.TxtNomtech = New System.Windows.Forms.TextBox()
        Me.Label14 = New System.Windows.Forms.Label()
        Me.Label15 = New System.Windows.Forms.Label()
        Me.Label16 = New System.Windows.Forms.Label()
        Me.Label17 = New System.Windows.Forms.Label()
        Me.Label18 = New System.Windows.Forms.Label()
        Me.Label19 = New System.Windows.Forms.Label()
        Me.Label20 = New System.Windows.Forms.Label()
        Me.Label21 = New System.Windows.Forms.Label()
        Me.GroupBox6 = New System.Windows.Forms.GroupBox()
        Me.TxtMailsec = New System.Windows.Forms.TextBox()
        Me.TxtFaxsec = New System.Windows.Forms.TextBox()
        Me.TxtPortablesec = New System.Windows.Forms.TextBox()
        Me.TxtTelsec = New System.Windows.Forms.TextBox()
        Me.TxtQualitesec = New System.Windows.Forms.TextBox()
        Me.ComboCivilitesec = New System.Windows.Forms.ComboBox()
        Me.TxtPrenomsec = New System.Windows.Forms.TextBox()
        Me.TxtNomsec = New System.Windows.Forms.TextBox()
        Me.Label13 = New System.Windows.Forms.Label()
        Me.Label12 = New System.Windows.Forms.Label()
        Me.Label11 = New System.Windows.Forms.Label()
        Me.Label10 = New System.Windows.Forms.Label()
        Me.Label9 = New System.Windows.Forms.Label()
        Me.Label8 = New System.Windows.Forms.Label()
        Me.Label7 = New System.Windows.Forms.Label()
        Me.Label6 = New System.Windows.Forms.Label()
        Me.GroupBox3 = New System.Windows.Forms.GroupBox()
        Me.GroupBox5 = New System.Windows.Forms.GroupBox()
        Me.TxtObs = New System.Windows.Forms.TextBox()
        Me.GroupBox4 = New System.Windows.Forms.GroupBox()
        Me.TxtVille = New System.Windows.Forms.TextBox()
        Me.TxtCP = New System.Windows.Forms.TextBox()
        Me.TxtAdr2 = New System.Windows.Forms.TextBox()
        Me.TxtAdr1 = New System.Windows.Forms.TextBox()
        Me.TxtNom = New System.Windows.Forms.TextBox()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.LabelNservtechnum = New System.Windows.Forms.Label()
        Me.OFD = New System.Windows.Forms.OpenFileDialog()
        Me.BtnSupprimerDoc = New System.Windows.Forms.Button()
        Me.GroupBox1.SuspendLayout()
        Me.GroupBox2.SuspendLayout()
        Me.GroupBox8.SuspendLayout()
        Me.GroupBox7.SuspendLayout()
        Me.GroupBox6.SuspendLayout()
        Me.GroupBox3.SuspendLayout()
        Me.GroupBox5.SuspendLayout()
        Me.GroupBox4.SuspendLayout()
        Me.SuspendLayout()
        '
        'LabelTitre
        '
        resources.ApplyResources(Me.LabelTitre, "LabelTitre")
        Me.LabelTitre.Name = "LabelTitre"
        '
        'GroupBox1
        '
        Me.GroupBox1.Controls.Add(Me.ButtonEnreg)
        Me.GroupBox1.Controls.Add(Me.BtnFermer)
        resources.ApplyResources(Me.GroupBox1, "GroupBox1")
        Me.GroupBox1.Name = "GroupBox1"
        Me.GroupBox1.TabStop = False
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
        'GroupBox2
        '
        Me.GroupBox2.Controls.Add(Me.GroupBox8)
        Me.GroupBox2.Controls.Add(Me.GroupBox7)
        Me.GroupBox2.Controls.Add(Me.GroupBox6)
        Me.GroupBox2.Controls.Add(Me.GroupBox3)
        resources.ApplyResources(Me.GroupBox2, "GroupBox2")
        Me.GroupBox2.Name = "GroupBox2"
        Me.GroupBox2.TabStop = False
        '
        'GroupBox8
        '
        Me.GroupBox8.Controls.Add(Me.BtnSupprimerDoc)
        Me.GroupBox8.Controls.Add(Me.cbMultiDocsDansPDF)
        Me.GroupBox8.Controls.Add(Me.TxtFileSrc)
        Me.GroupBox8.Controls.Add(Me.Label22)
        Me.GroupBox8.Controls.Add(Me.btnParcourir)
        resources.ApplyResources(Me.GroupBox8, "GroupBox8")
        Me.GroupBox8.ForeColor = System.Drawing.Color.Red
        Me.GroupBox8.Name = "GroupBox8"
        Me.GroupBox8.TabStop = False
        '
        'cbMultiDocsDansPDF
        '
        resources.ApplyResources(Me.cbMultiDocsDansPDF, "cbMultiDocsDansPDF")
        Me.cbMultiDocsDansPDF.ForeColor = System.Drawing.Color.Black
        Me.cbMultiDocsDansPDF.Name = "cbMultiDocsDansPDF"
        Me.cbMultiDocsDansPDF.UseVisualStyleBackColor = True
        '
        'TxtFileSrc
        '
        resources.ApplyResources(Me.TxtFileSrc, "TxtFileSrc")
        Me.TxtFileSrc.Name = "TxtFileSrc"
        Me.TxtFileSrc.ReadOnly = True
        '
        'Label22
        '
        resources.ApplyResources(Me.Label22, "Label22")
        Me.Label22.ForeColor = System.Drawing.Color.Black
        Me.Label22.Name = "Label22"
        '
        'btnParcourir
        '
        resources.ApplyResources(Me.btnParcourir, "btnParcourir")
        Me.btnParcourir.ForeColor = System.Drawing.Color.Black
        Me.btnParcourir.Name = "btnParcourir"
        Me.btnParcourir.UseVisualStyleBackColor = True
        '
        'GroupBox7
        '
        Me.GroupBox7.Controls.Add(Me.TxtMailtech)
        Me.GroupBox7.Controls.Add(Me.TxtFaxtech)
        Me.GroupBox7.Controls.Add(Me.TxtPortabletech)
        Me.GroupBox7.Controls.Add(Me.TxtTeltech)
        Me.GroupBox7.Controls.Add(Me.TxtQualitetech)
        Me.GroupBox7.Controls.Add(Me.ComboCivilitetech)
        Me.GroupBox7.Controls.Add(Me.TxtPrenomtech)
        Me.GroupBox7.Controls.Add(Me.TxtNomtech)
        Me.GroupBox7.Controls.Add(Me.Label14)
        Me.GroupBox7.Controls.Add(Me.Label15)
        Me.GroupBox7.Controls.Add(Me.Label16)
        Me.GroupBox7.Controls.Add(Me.Label17)
        Me.GroupBox7.Controls.Add(Me.Label18)
        Me.GroupBox7.Controls.Add(Me.Label19)
        Me.GroupBox7.Controls.Add(Me.Label20)
        Me.GroupBox7.Controls.Add(Me.Label21)
        resources.ApplyResources(Me.GroupBox7, "GroupBox7")
        Me.GroupBox7.ForeColor = System.Drawing.Color.Red
        Me.GroupBox7.Name = "GroupBox7"
        Me.GroupBox7.TabStop = False
        '
        'TxtMailtech
        '
        resources.ApplyResources(Me.TxtMailtech, "TxtMailtech")
        Me.TxtMailtech.Name = "TxtMailtech"
        '
        'TxtFaxtech
        '
        resources.ApplyResources(Me.TxtFaxtech, "TxtFaxtech")
        Me.TxtFaxtech.Name = "TxtFaxtech"
        '
        'TxtPortabletech
        '
        resources.ApplyResources(Me.TxtPortabletech, "TxtPortabletech")
        Me.TxtPortabletech.Name = "TxtPortabletech"
        '
        'TxtTeltech
        '
        resources.ApplyResources(Me.TxtTeltech, "TxtTeltech")
        Me.TxtTeltech.Name = "TxtTeltech"
        '
        'TxtQualitetech
        '
        resources.ApplyResources(Me.TxtQualitetech, "TxtQualitetech")
        Me.TxtQualitetech.Name = "TxtQualitetech"
        '
        'ComboCivilitetech
        '
        Me.ComboCivilitetech.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        resources.ApplyResources(Me.ComboCivilitetech, "ComboCivilitetech")
        Me.ComboCivilitetech.FormattingEnabled = True
        Me.ComboCivilitetech.Items.AddRange(New Object() {resources.GetString("ComboCivilitetech.Items"), resources.GetString("ComboCivilitetech.Items1"), resources.GetString("ComboCivilitetech.Items2")})
        Me.ComboCivilitetech.Name = "ComboCivilitetech"
        '
        'TxtPrenomtech
        '
        resources.ApplyResources(Me.TxtPrenomtech, "TxtPrenomtech")
        Me.TxtPrenomtech.Name = "TxtPrenomtech"
        '
        'TxtNomtech
        '
        resources.ApplyResources(Me.TxtNomtech, "TxtNomtech")
        Me.TxtNomtech.Name = "TxtNomtech"
        '
        'Label14
        '
        resources.ApplyResources(Me.Label14, "Label14")
        Me.Label14.ForeColor = System.Drawing.Color.Black
        Me.Label14.Name = "Label14"
        '
        'Label15
        '
        resources.ApplyResources(Me.Label15, "Label15")
        Me.Label15.ForeColor = System.Drawing.Color.Black
        Me.Label15.Name = "Label15"
        '
        'Label16
        '
        resources.ApplyResources(Me.Label16, "Label16")
        Me.Label16.ForeColor = System.Drawing.Color.Black
        Me.Label16.Name = "Label16"
        '
        'Label17
        '
        resources.ApplyResources(Me.Label17, "Label17")
        Me.Label17.ForeColor = System.Drawing.Color.Black
        Me.Label17.Name = "Label17"
        '
        'Label18
        '
        resources.ApplyResources(Me.Label18, "Label18")
        Me.Label18.ForeColor = System.Drawing.Color.Black
        Me.Label18.Name = "Label18"
        '
        'Label19
        '
        resources.ApplyResources(Me.Label19, "Label19")
        Me.Label19.ForeColor = System.Drawing.Color.Black
        Me.Label19.Name = "Label19"
        '
        'Label20
        '
        resources.ApplyResources(Me.Label20, "Label20")
        Me.Label20.ForeColor = System.Drawing.Color.Black
        Me.Label20.Name = "Label20"
        '
        'Label21
        '
        resources.ApplyResources(Me.Label21, "Label21")
        Me.Label21.ForeColor = System.Drawing.Color.Black
        Me.Label21.Name = "Label21"
        '
        'GroupBox6
        '
        Me.GroupBox6.Controls.Add(Me.TxtMailsec)
        Me.GroupBox6.Controls.Add(Me.TxtFaxsec)
        Me.GroupBox6.Controls.Add(Me.TxtPortablesec)
        Me.GroupBox6.Controls.Add(Me.TxtTelsec)
        Me.GroupBox6.Controls.Add(Me.TxtQualitesec)
        Me.GroupBox6.Controls.Add(Me.ComboCivilitesec)
        Me.GroupBox6.Controls.Add(Me.TxtPrenomsec)
        Me.GroupBox6.Controls.Add(Me.TxtNomsec)
        Me.GroupBox6.Controls.Add(Me.Label13)
        Me.GroupBox6.Controls.Add(Me.Label12)
        Me.GroupBox6.Controls.Add(Me.Label11)
        Me.GroupBox6.Controls.Add(Me.Label10)
        Me.GroupBox6.Controls.Add(Me.Label9)
        Me.GroupBox6.Controls.Add(Me.Label8)
        Me.GroupBox6.Controls.Add(Me.Label7)
        Me.GroupBox6.Controls.Add(Me.Label6)
        resources.ApplyResources(Me.GroupBox6, "GroupBox6")
        Me.GroupBox6.ForeColor = System.Drawing.Color.Red
        Me.GroupBox6.Name = "GroupBox6"
        Me.GroupBox6.TabStop = False
        '
        'TxtMailsec
        '
        resources.ApplyResources(Me.TxtMailsec, "TxtMailsec")
        Me.TxtMailsec.Name = "TxtMailsec"
        '
        'TxtFaxsec
        '
        resources.ApplyResources(Me.TxtFaxsec, "TxtFaxsec")
        Me.TxtFaxsec.Name = "TxtFaxsec"
        '
        'TxtPortablesec
        '
        resources.ApplyResources(Me.TxtPortablesec, "TxtPortablesec")
        Me.TxtPortablesec.Name = "TxtPortablesec"
        '
        'TxtTelsec
        '
        resources.ApplyResources(Me.TxtTelsec, "TxtTelsec")
        Me.TxtTelsec.Name = "TxtTelsec"
        '
        'TxtQualitesec
        '
        resources.ApplyResources(Me.TxtQualitesec, "TxtQualitesec")
        Me.TxtQualitesec.Name = "TxtQualitesec"
        '
        'ComboCivilitesec
        '
        Me.ComboCivilitesec.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        resources.ApplyResources(Me.ComboCivilitesec, "ComboCivilitesec")
        Me.ComboCivilitesec.FormattingEnabled = True
        Me.ComboCivilitesec.Items.AddRange(New Object() {resources.GetString("ComboCivilitesec.Items"), resources.GetString("ComboCivilitesec.Items1"), resources.GetString("ComboCivilitesec.Items2")})
        Me.ComboCivilitesec.Name = "ComboCivilitesec"
        '
        'TxtPrenomsec
        '
        resources.ApplyResources(Me.TxtPrenomsec, "TxtPrenomsec")
        Me.TxtPrenomsec.Name = "TxtPrenomsec"
        '
        'TxtNomsec
        '
        resources.ApplyResources(Me.TxtNomsec, "TxtNomsec")
        Me.TxtNomsec.Name = "TxtNomsec"
        '
        'Label13
        '
        resources.ApplyResources(Me.Label13, "Label13")
        Me.Label13.ForeColor = System.Drawing.Color.Black
        Me.Label13.Name = "Label13"
        '
        'Label12
        '
        resources.ApplyResources(Me.Label12, "Label12")
        Me.Label12.ForeColor = System.Drawing.Color.Black
        Me.Label12.Name = "Label12"
        '
        'Label11
        '
        resources.ApplyResources(Me.Label11, "Label11")
        Me.Label11.ForeColor = System.Drawing.Color.Black
        Me.Label11.Name = "Label11"
        '
        'Label10
        '
        resources.ApplyResources(Me.Label10, "Label10")
        Me.Label10.ForeColor = System.Drawing.Color.Black
        Me.Label10.Name = "Label10"
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
        'Label7
        '
        resources.ApplyResources(Me.Label7, "Label7")
        Me.Label7.ForeColor = System.Drawing.Color.Black
        Me.Label7.Name = "Label7"
        '
        'Label6
        '
        resources.ApplyResources(Me.Label6, "Label6")
        Me.Label6.ForeColor = System.Drawing.Color.Black
        Me.Label6.Name = "Label6"
        '
        'GroupBox3
        '
        Me.GroupBox3.Controls.Add(Me.GroupBox5)
        Me.GroupBox3.Controls.Add(Me.GroupBox4)
        resources.ApplyResources(Me.GroupBox3, "GroupBox3")
        Me.GroupBox3.ForeColor = System.Drawing.Color.Red
        Me.GroupBox3.Name = "GroupBox3"
        Me.GroupBox3.TabStop = False
        '
        'GroupBox5
        '
        Me.GroupBox5.Controls.Add(Me.TxtObs)
        resources.ApplyResources(Me.GroupBox5, "GroupBox5")
        Me.GroupBox5.ForeColor = System.Drawing.Color.Red
        Me.GroupBox5.Name = "GroupBox5"
        Me.GroupBox5.TabStop = False
        '
        'TxtObs
        '
        resources.ApplyResources(Me.TxtObs, "TxtObs")
        Me.TxtObs.Name = "TxtObs"
        '
        'GroupBox4
        '
        Me.GroupBox4.Controls.Add(Me.TxtVille)
        Me.GroupBox4.Controls.Add(Me.TxtCP)
        Me.GroupBox4.Controls.Add(Me.TxtAdr2)
        Me.GroupBox4.Controls.Add(Me.TxtAdr1)
        Me.GroupBox4.Controls.Add(Me.TxtNom)
        Me.GroupBox4.Controls.Add(Me.Label5)
        Me.GroupBox4.Controls.Add(Me.Label4)
        Me.GroupBox4.Controls.Add(Me.Label3)
        Me.GroupBox4.Controls.Add(Me.Label2)
        Me.GroupBox4.Controls.Add(Me.Label1)
        resources.ApplyResources(Me.GroupBox4, "GroupBox4")
        Me.GroupBox4.ForeColor = System.Drawing.Color.Red
        Me.GroupBox4.Name = "GroupBox4"
        Me.GroupBox4.TabStop = False
        '
        'TxtVille
        '
        resources.ApplyResources(Me.TxtVille, "TxtVille")
        Me.TxtVille.Name = "TxtVille"
        '
        'TxtCP
        '
        resources.ApplyResources(Me.TxtCP, "TxtCP")
        Me.TxtCP.Name = "TxtCP"
        '
        'TxtAdr2
        '
        resources.ApplyResources(Me.TxtAdr2, "TxtAdr2")
        Me.TxtAdr2.Name = "TxtAdr2"
        '
        'TxtAdr1
        '
        resources.ApplyResources(Me.TxtAdr1, "TxtAdr1")
        Me.TxtAdr1.Name = "TxtAdr1"
        '
        'TxtNom
        '
        resources.ApplyResources(Me.TxtNom, "TxtNom")
        Me.TxtNom.Name = "TxtNom"
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
        'Label2
        '
        resources.ApplyResources(Me.Label2, "Label2")
        Me.Label2.ForeColor = System.Drawing.Color.Black
        Me.Label2.Name = "Label2"
        '
        'Label1
        '
        resources.ApplyResources(Me.Label1, "Label1")
        Me.Label1.ForeColor = System.Drawing.Color.Black
        Me.Label1.Name = "Label1"
        '
        'LabelNservtechnum
        '
        resources.ApplyResources(Me.LabelNservtechnum, "LabelNservtechnum")
        Me.LabelNservtechnum.ForeColor = System.Drawing.Color.Red
        Me.LabelNservtechnum.Name = "LabelNservtechnum"
        '
        'BtnSupprimerDoc
        '
        resources.ApplyResources(Me.BtnSupprimerDoc, "BtnSupprimerDoc")
        Me.BtnSupprimerDoc.ForeColor = System.Drawing.Color.Black
        Me.BtnSupprimerDoc.Name = "BtnSupprimerDoc"
        Me.BtnSupprimerDoc.UseVisualStyleBackColor = True
        '
        'frmGestionServiceTechniqueDetails
        '
        resources.ApplyResources(Me, "$this")
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.Wheat
        Me.Controls.Add(Me.LabelNservtechnum)
        Me.Controls.Add(Me.GroupBox2)
        Me.Controls.Add(Me.LabelTitre)
        Me.Controls.Add(Me.GroupBox1)
        Me.Name = "frmGestionServiceTechniqueDetails"
        Me.WindowState = System.Windows.Forms.FormWindowState.Maximized
        Me.GroupBox1.ResumeLayout(False)
        Me.GroupBox2.ResumeLayout(False)
        Me.GroupBox8.ResumeLayout(False)
        Me.GroupBox8.PerformLayout()
        Me.GroupBox7.ResumeLayout(False)
        Me.GroupBox7.PerformLayout()
        Me.GroupBox6.ResumeLayout(False)
        Me.GroupBox6.PerformLayout()
        Me.GroupBox3.ResumeLayout(False)
        Me.GroupBox5.ResumeLayout(False)
        Me.GroupBox5.PerformLayout()
        Me.GroupBox4.ResumeLayout(False)
        Me.GroupBox4.PerformLayout()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents LabelTitre As System.Windows.Forms.Label
  Friend WithEvents GroupBox1 As System.Windows.Forms.GroupBox
  Friend WithEvents ButtonEnreg As System.Windows.Forms.Button
  Friend WithEvents BtnFermer As System.Windows.Forms.Button
  Friend WithEvents GroupBox2 As System.Windows.Forms.GroupBox
  Friend WithEvents GroupBox3 As System.Windows.Forms.GroupBox
  Friend WithEvents GroupBox4 As System.Windows.Forms.GroupBox
  Friend WithEvents Label5 As System.Windows.Forms.Label
  Friend WithEvents Label4 As System.Windows.Forms.Label
  Friend WithEvents Label3 As System.Windows.Forms.Label
  Friend WithEvents Label2 As System.Windows.Forms.Label
  Friend WithEvents Label1 As System.Windows.Forms.Label
  Friend WithEvents LabelNservtechnum As System.Windows.Forms.Label
  Friend WithEvents TxtCP As System.Windows.Forms.TextBox
  Friend WithEvents TxtAdr2 As System.Windows.Forms.TextBox
  Friend WithEvents TxtAdr1 As System.Windows.Forms.TextBox
  Friend WithEvents TxtNom As System.Windows.Forms.TextBox
  Friend WithEvents TxtVille As System.Windows.Forms.TextBox
  Friend WithEvents GroupBox5 As System.Windows.Forms.GroupBox
  Friend WithEvents GroupBox7 As System.Windows.Forms.GroupBox
  Friend WithEvents Label14 As System.Windows.Forms.Label
  Friend WithEvents Label15 As System.Windows.Forms.Label
  Friend WithEvents Label16 As System.Windows.Forms.Label
  Friend WithEvents Label17 As System.Windows.Forms.Label
  Friend WithEvents Label18 As System.Windows.Forms.Label
  Friend WithEvents Label19 As System.Windows.Forms.Label
  Friend WithEvents Label20 As System.Windows.Forms.Label
  Friend WithEvents Label21 As System.Windows.Forms.Label
  Friend WithEvents GroupBox6 As System.Windows.Forms.GroupBox
  Friend WithEvents Label13 As System.Windows.Forms.Label
  Friend WithEvents Label12 As System.Windows.Forms.Label
  Friend WithEvents Label11 As System.Windows.Forms.Label
  Friend WithEvents Label10 As System.Windows.Forms.Label
  Friend WithEvents Label9 As System.Windows.Forms.Label
  Friend WithEvents Label8 As System.Windows.Forms.Label
  Friend WithEvents Label7 As System.Windows.Forms.Label
  Friend WithEvents Label6 As System.Windows.Forms.Label
  Friend WithEvents TxtQualitesec As System.Windows.Forms.TextBox
  Friend WithEvents ComboCivilitesec As System.Windows.Forms.ComboBox
  Friend WithEvents TxtPrenomsec As System.Windows.Forms.TextBox
  Friend WithEvents TxtNomsec As System.Windows.Forms.TextBox
  Friend WithEvents TxtMailtech As System.Windows.Forms.TextBox
  Friend WithEvents TxtFaxtech As System.Windows.Forms.TextBox
  Friend WithEvents TxtPortabletech As System.Windows.Forms.TextBox
  Friend WithEvents TxtTeltech As System.Windows.Forms.TextBox
  Friend WithEvents TxtQualitetech As System.Windows.Forms.TextBox
  Friend WithEvents ComboCivilitetech As System.Windows.Forms.ComboBox
  Friend WithEvents TxtPrenomtech As System.Windows.Forms.TextBox
  Friend WithEvents TxtNomtech As System.Windows.Forms.TextBox
  Friend WithEvents TxtMailsec As System.Windows.Forms.TextBox
  Friend WithEvents TxtFaxsec As System.Windows.Forms.TextBox
  Friend WithEvents TxtPortablesec As System.Windows.Forms.TextBox
  Friend WithEvents TxtTelsec As System.Windows.Forms.TextBox
  Friend WithEvents TxtObs As System.Windows.Forms.TextBox
  Friend WithEvents GroupBox8 As System.Windows.Forms.GroupBox
  Friend WithEvents btnParcourir As System.Windows.Forms.Button
  Friend WithEvents OFD As System.Windows.Forms.OpenFileDialog
  Friend WithEvents TxtFileSrc As System.Windows.Forms.TextBox
  Friend WithEvents Label22 As System.Windows.Forms.Label
  Friend WithEvents cbMultiDocsDansPDF As System.Windows.Forms.CheckBox
    Friend WithEvents BtnSupprimerDoc As Button
End Class
