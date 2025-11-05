<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmDevisTechnicien
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
    Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(frmDevisTechnicien))
    Me.LblTxtAideFou = New System.Windows.Forms.Label()
    Me.GrpBoxEnteteDevisTech = New System.Windows.Forms.GroupBox()
    Me.LblNDINCTE = New System.Windows.Forms.Label()
    Me.LblVSITNOM = New System.Windows.Forms.Label()
    Me.LblVCLINOM = New System.Windows.Forms.Label()
    Me.cboSite = New System.Windows.Forms.ComboBox()
    Me.cboCompte = New System.Windows.Forms.ComboBox()
    Me.cboClient = New System.Windows.Forms.ComboBox()
    Me.DateTimeSaisie = New System.Windows.Forms.DateTimePicker()
    Me.Label4 = New System.Windows.Forms.Label()
    Me.Label3 = New System.Windows.Forms.Label()
    Me.Label2 = New System.Windows.Forms.Label()
    Me.LblTitre1 = New System.Windows.Forms.Label()
    Me.LblTxtAidePresta = New System.Windows.Forms.Label()
    Me.PanelNbTech = New System.Windows.Forms.Panel()
    Me.rb2tech = New System.Windows.Forms.RadioButton()
    Me.rb1tech = New System.Windows.Forms.RadioButton()
    Me.LblTxtAideConstat = New System.Windows.Forms.Label()
    Me.LblTxtAideSujet = New System.Windows.Forms.Label()
    Me.LblAideTitre = New System.Windows.Forms.Label()
    Me.Label12 = New System.Windows.Forms.Label()
    Me.txtFourniture = New System.Windows.Forms.TextBox()
    Me.BtnAjoutPhotos = New System.Windows.Forms.Button()
    Me.BtnValider = New System.Windows.Forms.Button()
    Me.Label11 = New System.Windows.Forms.Label()
    Me.GroupBox3 = New System.Windows.Forms.GroupBox()
    Me.txtHeuresHN = New System.Windows.Forms.TextBox()
    Me.Label10 = New System.Windows.Forms.Label()
    Me.txtHeuresHP = New System.Windows.Forms.TextBox()
    Me.lblHeuresHP = New System.Windows.Forms.Label()
    Me.txtHeuresJ = New System.Windows.Forms.TextBox()
    Me.Label8 = New System.Windows.Forms.Label()
    Me.Label7 = New System.Windows.Forms.Label()
    Me.txtPrestation = New System.Windows.Forms.TextBox()
    Me.Label6 = New System.Windows.Forms.Label()
    Me.txtConstat = New System.Windows.Forms.TextBox()
    Me.txtSujet = New System.Windows.Forms.TextBox()
    Me.Label5 = New System.Windows.Forms.Label()
    Me.GrpBoxDevisTech = New System.Windows.Forms.GroupBox()
    Me.txtTitre = New System.Windows.Forms.TextBox()
    Me.Label1 = New System.Windows.Forms.Label()
    Me.BtnQuit = New System.Windows.Forms.Button()
        Me.Label9 = New System.Windows.Forms.Label()
        Me.TxtSecu = New System.Windows.Forms.TextBox()
        Me.Label13 = New System.Windows.Forms.Label()
        Me.GrpBoxEnteteDevisTech.SuspendLayout()
        Me.PanelNbTech.SuspendLayout()
        Me.GroupBox3.SuspendLayout()
        Me.GrpBoxDevisTech.SuspendLayout()
        Me.SuspendLayout()
        '
        'LblTxtAideFou
        '
        resources.ApplyResources(Me.LblTxtAideFou, "LblTxtAideFou")
        Me.LblTxtAideFou.ForeColor = System.Drawing.Color.Red
        Me.LblTxtAideFou.Name = "LblTxtAideFou"
        '
        'GrpBoxEnteteDevisTech
        '
        Me.GrpBoxEnteteDevisTech.Controls.Add(Me.LblNDINCTE)
        Me.GrpBoxEnteteDevisTech.Controls.Add(Me.LblVSITNOM)
        Me.GrpBoxEnteteDevisTech.Controls.Add(Me.LblVCLINOM)
        Me.GrpBoxEnteteDevisTech.Controls.Add(Me.cboSite)
        Me.GrpBoxEnteteDevisTech.Controls.Add(Me.cboCompte)
        Me.GrpBoxEnteteDevisTech.Controls.Add(Me.cboClient)
        Me.GrpBoxEnteteDevisTech.Controls.Add(Me.DateTimeSaisie)
        Me.GrpBoxEnteteDevisTech.Controls.Add(Me.Label4)
        Me.GrpBoxEnteteDevisTech.Controls.Add(Me.Label3)
        Me.GrpBoxEnteteDevisTech.Controls.Add(Me.Label2)
        Me.GrpBoxEnteteDevisTech.Controls.Add(Me.LblTitre1)
        resources.ApplyResources(Me.GrpBoxEnteteDevisTech, "GrpBoxEnteteDevisTech")
        Me.GrpBoxEnteteDevisTech.Name = "GrpBoxEnteteDevisTech"
        Me.GrpBoxEnteteDevisTech.TabStop = False
        '
        'LblNDINCTE
        '
        Me.LblNDINCTE.BackColor = System.Drawing.Color.White
        Me.LblNDINCTE.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        resources.ApplyResources(Me.LblNDINCTE, "LblNDINCTE")
        Me.LblNDINCTE.Name = "LblNDINCTE"
        '
        'LblVSITNOM
        '
        Me.LblVSITNOM.BackColor = System.Drawing.Color.White
        Me.LblVSITNOM.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        resources.ApplyResources(Me.LblVSITNOM, "LblVSITNOM")
        Me.LblVSITNOM.Name = "LblVSITNOM"
        '
        'LblVCLINOM
        '
        Me.LblVCLINOM.BackColor = System.Drawing.Color.White
        Me.LblVCLINOM.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        resources.ApplyResources(Me.LblVCLINOM, "LblVCLINOM")
        Me.LblVCLINOM.Name = "LblVCLINOM"
        '
        'cboSite
        '
        Me.cboSite.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.cboSite.FormattingEnabled = True
        resources.ApplyResources(Me.cboSite, "cboSite")
        Me.cboSite.Name = "cboSite"
        '
        'cboCompte
        '
        Me.cboCompte.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.cboCompte.FormattingEnabled = True
        resources.ApplyResources(Me.cboCompte, "cboCompte")
        Me.cboCompte.Name = "cboCompte"
        '
        'cboClient
        '
        Me.cboClient.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.cboClient.FormattingEnabled = True
        resources.ApplyResources(Me.cboClient, "cboClient")
        Me.cboClient.Name = "cboClient"
        '
        'DateTimeSaisie
        '
        resources.ApplyResources(Me.DateTimeSaisie, "DateTimeSaisie")
        Me.DateTimeSaisie.Name = "DateTimeSaisie"
        '
        'Label4
        '
        resources.ApplyResources(Me.Label4, "Label4")
        Me.Label4.BackColor = System.Drawing.Color.Transparent
        Me.Label4.Name = "Label4"
        '
        'Label3
        '
        resources.ApplyResources(Me.Label3, "Label3")
        Me.Label3.BackColor = System.Drawing.Color.Transparent
        Me.Label3.Name = "Label3"
        '
        'Label2
        '
        resources.ApplyResources(Me.Label2, "Label2")
        Me.Label2.BackColor = System.Drawing.Color.Transparent
        Me.Label2.Name = "Label2"
        '
        'LblTitre1
        '
        resources.ApplyResources(Me.LblTitre1, "LblTitre1")
        Me.LblTitre1.BackColor = System.Drawing.Color.Transparent
        Me.LblTitre1.Name = "LblTitre1"
        '
        'LblTxtAidePresta
        '
        resources.ApplyResources(Me.LblTxtAidePresta, "LblTxtAidePresta")
        Me.LblTxtAidePresta.ForeColor = System.Drawing.Color.Red
        Me.LblTxtAidePresta.Name = "LblTxtAidePresta"
        '
        'PanelNbTech
        '
        Me.PanelNbTech.Controls.Add(Me.rb2tech)
        Me.PanelNbTech.Controls.Add(Me.rb1tech)
        resources.ApplyResources(Me.PanelNbTech, "PanelNbTech")
        Me.PanelNbTech.Name = "PanelNbTech"
        '
        'rb2tech
        '
        resources.ApplyResources(Me.rb2tech, "rb2tech")
        Me.rb2tech.Name = "rb2tech"
        Me.rb2tech.TabStop = True
        Me.rb2tech.UseVisualStyleBackColor = True
        '
        'rb1tech
        '
        resources.ApplyResources(Me.rb1tech, "rb1tech")
        Me.rb1tech.Name = "rb1tech"
        Me.rb1tech.TabStop = True
        Me.rb1tech.UseVisualStyleBackColor = True
        '
        'LblTxtAideConstat
        '
        resources.ApplyResources(Me.LblTxtAideConstat, "LblTxtAideConstat")
        Me.LblTxtAideConstat.ForeColor = System.Drawing.Color.Red
        Me.LblTxtAideConstat.Name = "LblTxtAideConstat"
        '
        'LblTxtAideSujet
        '
        resources.ApplyResources(Me.LblTxtAideSujet, "LblTxtAideSujet")
        Me.LblTxtAideSujet.ForeColor = System.Drawing.Color.Red
        Me.LblTxtAideSujet.Name = "LblTxtAideSujet"
        '
        'LblAideTitre
        '
        resources.ApplyResources(Me.LblAideTitre, "LblAideTitre")
        Me.LblAideTitre.ForeColor = System.Drawing.Color.Red
        Me.LblAideTitre.Name = "LblAideTitre"
        '
        'Label12
        '
        resources.ApplyResources(Me.Label12, "Label12")
        Me.Label12.BackColor = System.Drawing.Color.Transparent
        Me.Label12.Name = "Label12"
        '
        'txtFourniture
        '
        resources.ApplyResources(Me.txtFourniture, "txtFourniture")
        Me.txtFourniture.Name = "txtFourniture"
        '
        'BtnAjoutPhotos
        '
        resources.ApplyResources(Me.BtnAjoutPhotos, "BtnAjoutPhotos")
        Me.BtnAjoutPhotos.Name = "BtnAjoutPhotos"
        Me.BtnAjoutPhotos.UseVisualStyleBackColor = True
        '
        'BtnValider
        '
        resources.ApplyResources(Me.BtnValider, "BtnValider")
        Me.BtnValider.Name = "BtnValider"
        Me.BtnValider.UseVisualStyleBackColor = True
        '
        'Label11
        '
        resources.ApplyResources(Me.Label11, "Label11")
        Me.Label11.BackColor = System.Drawing.Color.Transparent
        Me.Label11.Name = "Label11"
        '
        'GroupBox3
        '
        Me.GroupBox3.Controls.Add(Me.PanelNbTech)
        Me.GroupBox3.Controls.Add(Me.Label11)
        Me.GroupBox3.Controls.Add(Me.txtHeuresHN)
        Me.GroupBox3.Controls.Add(Me.Label10)
        Me.GroupBox3.Controls.Add(Me.txtHeuresHP)
        Me.GroupBox3.Controls.Add(Me.lblHeuresHP)
        Me.GroupBox3.Controls.Add(Me.txtHeuresJ)
        Me.GroupBox3.Controls.Add(Me.Label8)
        resources.ApplyResources(Me.GroupBox3, "GroupBox3")
        Me.GroupBox3.Name = "GroupBox3"
        Me.GroupBox3.TabStop = False
        '
        'txtHeuresHN
        '
        resources.ApplyResources(Me.txtHeuresHN, "txtHeuresHN")
        Me.txtHeuresHN.Name = "txtHeuresHN"
        '
        'Label10
        '
        Me.Label10.BackColor = System.Drawing.Color.Transparent
        resources.ApplyResources(Me.Label10, "Label10")
        Me.Label10.Name = "Label10"
        '
        'txtHeuresHP
        '
        resources.ApplyResources(Me.txtHeuresHP, "txtHeuresHP")
        Me.txtHeuresHP.Name = "txtHeuresHP"
        '
        'lblHeuresHP
        '
        Me.lblHeuresHP.BackColor = System.Drawing.Color.Transparent
        resources.ApplyResources(Me.lblHeuresHP, "lblHeuresHP")
        Me.lblHeuresHP.Name = "lblHeuresHP"
        '
        'txtHeuresJ
        '
        resources.ApplyResources(Me.txtHeuresJ, "txtHeuresJ")
        Me.txtHeuresJ.Name = "txtHeuresJ"
        '
        'Label8
        '
        Me.Label8.BackColor = System.Drawing.Color.Transparent
        resources.ApplyResources(Me.Label8, "Label8")
        Me.Label8.Name = "Label8"
        '
        'Label7
        '
        resources.ApplyResources(Me.Label7, "Label7")
        Me.Label7.BackColor = System.Drawing.Color.Transparent
        Me.Label7.Name = "Label7"
        '
        'txtPrestation
        '
        resources.ApplyResources(Me.txtPrestation, "txtPrestation")
        Me.txtPrestation.Name = "txtPrestation"
        '
        'Label6
        '
        resources.ApplyResources(Me.Label6, "Label6")
        Me.Label6.BackColor = System.Drawing.Color.Transparent
        Me.Label6.Name = "Label6"
        '
        'txtConstat
        '
        resources.ApplyResources(Me.txtConstat, "txtConstat")
        Me.txtConstat.Name = "txtConstat"
        '
        'txtSujet
        '
        resources.ApplyResources(Me.txtSujet, "txtSujet")
        Me.txtSujet.Name = "txtSujet"
        '
        'Label5
        '
        resources.ApplyResources(Me.Label5, "Label5")
        Me.Label5.BackColor = System.Drawing.Color.Transparent
        Me.Label5.Name = "Label5"
        '
        'GrpBoxDevisTech
        '
        Me.GrpBoxDevisTech.Controls.Add(Me.Label9)
        Me.GrpBoxDevisTech.Controls.Add(Me.TxtSecu)
        Me.GrpBoxDevisTech.Controls.Add(Me.Label13)
        Me.GrpBoxDevisTech.Controls.Add(Me.LblTxtAideFou)
        Me.GrpBoxDevisTech.Controls.Add(Me.LblTxtAidePresta)
        Me.GrpBoxDevisTech.Controls.Add(Me.LblTxtAideConstat)
        Me.GrpBoxDevisTech.Controls.Add(Me.LblTxtAideSujet)
        Me.GrpBoxDevisTech.Controls.Add(Me.LblAideTitre)
        Me.GrpBoxDevisTech.Controls.Add(Me.txtFourniture)
        Me.GrpBoxDevisTech.Controls.Add(Me.Label12)
        Me.GrpBoxDevisTech.Controls.Add(Me.txtPrestation)
        Me.GrpBoxDevisTech.Controls.Add(Me.Label7)
        Me.GrpBoxDevisTech.Controls.Add(Me.txtConstat)
        Me.GrpBoxDevisTech.Controls.Add(Me.Label6)
        Me.GrpBoxDevisTech.Controls.Add(Me.txtSujet)
        Me.GrpBoxDevisTech.Controls.Add(Me.Label5)
        Me.GrpBoxDevisTech.Controls.Add(Me.txtTitre)
        Me.GrpBoxDevisTech.Controls.Add(Me.Label1)
        resources.ApplyResources(Me.GrpBoxDevisTech, "GrpBoxDevisTech")
        Me.GrpBoxDevisTech.Name = "GrpBoxDevisTech"
        Me.GrpBoxDevisTech.TabStop = False
        '
        'txtTitre
        '
        resources.ApplyResources(Me.txtTitre, "txtTitre")
        Me.txtTitre.Name = "txtTitre"
        '
        'Label1
        '
        resources.ApplyResources(Me.Label1, "Label1")
        Me.Label1.BackColor = System.Drawing.Color.Transparent
        Me.Label1.Name = "Label1"
        '
        'BtnQuit
        '
        resources.ApplyResources(Me.BtnQuit, "BtnQuit")
        Me.BtnQuit.Name = "BtnQuit"
        Me.BtnQuit.UseVisualStyleBackColor = True
        '
        'Label9
        '
        resources.ApplyResources(Me.Label9, "Label9")
        Me.Label9.ForeColor = System.Drawing.Color.Red
        Me.Label9.Name = "Label9"
        '
        'TxtSecu
        '
        resources.ApplyResources(Me.TxtSecu, "TxtSecu")
        Me.TxtSecu.Name = "TxtSecu"
        '
        'Label13
        '
        Me.Label13.BackColor = System.Drawing.Color.Transparent
        resources.ApplyResources(Me.Label13, "Label13")
        Me.Label13.Name = "Label13"
        '
        'frmDevisTechnicien
        '
        resources.ApplyResources(Me, "$this")
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.Wheat
        Me.Controls.Add(Me.GrpBoxEnteteDevisTech)
        Me.Controls.Add(Me.BtnAjoutPhotos)
        Me.Controls.Add(Me.BtnValider)
        Me.Controls.Add(Me.GroupBox3)
        Me.Controls.Add(Me.GrpBoxDevisTech)
        Me.Controls.Add(Me.BtnQuit)
        Me.Name = "frmDevisTechnicien"
        Me.GrpBoxEnteteDevisTech.ResumeLayout(False)
        Me.GrpBoxEnteteDevisTech.PerformLayout()
        Me.PanelNbTech.ResumeLayout(False)
        Me.PanelNbTech.PerformLayout()
        Me.GroupBox3.ResumeLayout(False)
        Me.GroupBox3.PerformLayout()
        Me.GrpBoxDevisTech.ResumeLayout(False)
        Me.GrpBoxDevisTech.PerformLayout()
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents LblTxtAideFou As System.Windows.Forms.Label
    Friend WithEvents GrpBoxEnteteDevisTech As System.Windows.Forms.GroupBox
    Friend WithEvents LblNDINCTE As System.Windows.Forms.Label
    Friend WithEvents LblVSITNOM As System.Windows.Forms.Label
    Friend WithEvents LblVCLINOM As System.Windows.Forms.Label
    Friend WithEvents cboSite As System.Windows.Forms.ComboBox
    Friend WithEvents cboCompte As System.Windows.Forms.ComboBox
    Friend WithEvents cboClient As System.Windows.Forms.ComboBox
    Friend WithEvents DateTimeSaisie As System.Windows.Forms.DateTimePicker
    Friend WithEvents Label4 As System.Windows.Forms.Label
    Friend WithEvents Label3 As System.Windows.Forms.Label
    Friend WithEvents Label2 As System.Windows.Forms.Label
    Friend WithEvents LblTitre1 As System.Windows.Forms.Label
    Friend WithEvents LblTxtAidePresta As System.Windows.Forms.Label
    Friend WithEvents PanelNbTech As System.Windows.Forms.Panel
    Friend WithEvents rb2tech As System.Windows.Forms.RadioButton
    Friend WithEvents rb1tech As System.Windows.Forms.RadioButton
    Friend WithEvents LblTxtAideConstat As System.Windows.Forms.Label
    Friend WithEvents LblTxtAideSujet As System.Windows.Forms.Label
    Friend WithEvents LblAideTitre As System.Windows.Forms.Label
    Friend WithEvents Label12 As System.Windows.Forms.Label
    Friend WithEvents txtFourniture As System.Windows.Forms.TextBox
    Friend WithEvents BtnAjoutPhotos As System.Windows.Forms.Button
    Friend WithEvents BtnValider As System.Windows.Forms.Button
    Friend WithEvents Label11 As System.Windows.Forms.Label
    Friend WithEvents GroupBox3 As System.Windows.Forms.GroupBox
    Friend WithEvents txtHeuresHN As System.Windows.Forms.TextBox
    Friend WithEvents Label10 As System.Windows.Forms.Label
    Friend WithEvents txtHeuresHP As System.Windows.Forms.TextBox
    Friend WithEvents lblHeuresHP As System.Windows.Forms.Label
    Friend WithEvents txtHeuresJ As System.Windows.Forms.TextBox
    Friend WithEvents Label8 As System.Windows.Forms.Label
    Friend WithEvents Label7 As System.Windows.Forms.Label
    Friend WithEvents txtPrestation As System.Windows.Forms.TextBox
    Friend WithEvents Label6 As System.Windows.Forms.Label
    Friend WithEvents txtConstat As System.Windows.Forms.TextBox
    Friend WithEvents txtSujet As System.Windows.Forms.TextBox
    Friend WithEvents Label5 As System.Windows.Forms.Label
    Friend WithEvents GrpBoxDevisTech As System.Windows.Forms.GroupBox
    Friend WithEvents txtTitre As System.Windows.Forms.TextBox
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents BtnQuit As System.Windows.Forms.Button
    Friend WithEvents Label9 As Label
    Friend WithEvents TxtSecu As TextBox
    Friend WithEvents Label13 As Label
End Class
