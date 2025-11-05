<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class frmPlanifAuto_Creation
    Inherits System.Windows.Forms.Form

    'Form remplace la méthode Dispose pour nettoyer la liste des composants.
    <System.Diagnostics.DebuggerNonUserCode()>
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
    <System.Diagnostics.DebuggerStepThrough()>
    Private Sub InitializeComponent()
        Me.GroupBox3 = New System.Windows.Forms.GroupBox()
        Me.GroupBox4 = New System.Windows.Forms.GroupBox()
        Me.Label6 = New System.Windows.Forms.Label()
        Me.Txt_PaveBloc_Text = New System.Windows.Forms.TextBox()
        Me.ChkPaveBloc_NO = New System.Windows.Forms.CheckBox()
        Me.ChkPaveBloc_YES = New System.Windows.Forms.CheckBox()
        Me.CboTechs = New System.Windows.Forms.ComboBox()
        Me.Chk_PlaAuto_OneTech = New System.Windows.Forms.CheckBox()
        Me.Chk_PlaAuto_AllTechs = New System.Windows.Forms.CheckBox()
        Me.BtnValider = New System.Windows.Forms.Button()
        Me.BtnClose = New System.Windows.Forms.Button()
        Me.BtnHelp = New System.Windows.Forms.Button()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.Txt_P_Debut = New System.Windows.Forms.TextBox()
        Me.BtnAddDateP_Debut = New System.Windows.Forms.Button()
        Me.BtnDelDateP_Debut = New System.Windows.Forms.Button()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.Txt_P_Fin = New System.Windows.Forms.TextBox()
        Me.BtnAddDateP_Fin = New System.Windows.Forms.Button()
        Me.BtnDelDateP_Fin = New System.Windows.Forms.Button()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.Chk_P_Pla_DateS = New System.Windows.Forms.CheckBox()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.Chk_P_Pla_DateS_With_Tol = New System.Windows.Forms.CheckBox()
        Me.CboDateS_Tolerance = New System.Windows.Forms.ComboBox()
        Me.GroupBox1 = New System.Windows.Forms.GroupBox()
        Me.GroupBox2 = New System.Windows.Forms.GroupBox()
        Me.ChkListJourSem = New DevExpress.XtraEditors.CheckedListBoxControl()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.ChkJ_Forbid_NO = New System.Windows.Forms.CheckBox()
        Me.ChkJ_Forbid_YES = New System.Windows.Forms.CheckBox()
        Me.Cal_Adder = New System.Windows.Forms.MonthCalendar()
        Me.GroupBox3.SuspendLayout()
        Me.GroupBox4.SuspendLayout()
        Me.GroupBox1.SuspendLayout()
        Me.GroupBox2.SuspendLayout()
        CType(Me.ChkListJourSem, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'GroupBox3
        '
        Me.GroupBox3.Controls.Add(Me.GroupBox4)
        Me.GroupBox3.Controls.Add(Me.CboTechs)
        Me.GroupBox3.Controls.Add(Me.Chk_PlaAuto_OneTech)
        Me.GroupBox3.Controls.Add(Me.Chk_PlaAuto_AllTechs)
        Me.GroupBox3.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.GroupBox3.Location = New System.Drawing.Point(637, 12)
        Me.GroupBox3.Name = "GroupBox3"
        Me.GroupBox3.Size = New System.Drawing.Size(588, 634)
        Me.GroupBox3.TabIndex = 2
        Me.GroupBox3.TabStop = False
        Me.GroupBox3.Text = "Choix du technicien à planifier"
        '
        'GroupBox4
        '
        Me.GroupBox4.Controls.Add(Me.Label6)
        Me.GroupBox4.Controls.Add(Me.Txt_PaveBloc_Text)
        Me.GroupBox4.Controls.Add(Me.ChkPaveBloc_NO)
        Me.GroupBox4.Controls.Add(Me.ChkPaveBloc_YES)
        Me.GroupBox4.Location = New System.Drawing.Point(28, 324)
        Me.GroupBox4.Name = "GroupBox4"
        Me.GroupBox4.Size = New System.Drawing.Size(560, 276)
        Me.GroupBox4.TabIndex = 23
        Me.GroupBox4.TabStop = False
        Me.GroupBox4.Text = "Blocage pavé"
        '
        'Label6
        '
        Me.Label6.AutoSize = True
        Me.Label6.Location = New System.Drawing.Point(18, 99)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(248, 13)
        Me.Label6.TabIndex = 30
        Me.Label6.Text = "Libellé blocage pavé (50 caractères maxi.)"
        Me.Label6.Visible = False
        '
        'Txt_PaveBloc_Text
        '
        Me.Txt_PaveBloc_Text.BackColor = System.Drawing.Color.White
        Me.Txt_PaveBloc_Text.Location = New System.Drawing.Point(21, 124)
        Me.Txt_PaveBloc_Text.MaxLength = 50
        Me.Txt_PaveBloc_Text.Name = "Txt_PaveBloc_Text"
        Me.Txt_PaveBloc_Text.Size = New System.Drawing.Size(515, 20)
        Me.Txt_PaveBloc_Text.TabIndex = 29
        Me.Txt_PaveBloc_Text.Visible = False
        '
        'ChkPaveBloc_NO
        '
        Me.ChkPaveBloc_NO.AutoSize = True
        Me.ChkPaveBloc_NO.Location = New System.Drawing.Point(268, 34)
        Me.ChkPaveBloc_NO.Name = "ChkPaveBloc_NO"
        Me.ChkPaveBloc_NO.Size = New System.Drawing.Size(49, 17)
        Me.ChkPaveBloc_NO.TabIndex = 28
        Me.ChkPaveBloc_NO.Text = "Non"
        Me.ChkPaveBloc_NO.UseVisualStyleBackColor = True
        '
        'ChkPaveBloc_YES
        '
        Me.ChkPaveBloc_YES.AutoSize = True
        Me.ChkPaveBloc_YES.Location = New System.Drawing.Point(130, 34)
        Me.ChkPaveBloc_YES.Name = "ChkPaveBloc_YES"
        Me.ChkPaveBloc_YES.Size = New System.Drawing.Size(45, 17)
        Me.ChkPaveBloc_YES.TabIndex = 22
        Me.ChkPaveBloc_YES.Text = "Oui"
        Me.ChkPaveBloc_YES.UseVisualStyleBackColor = True
        '
        'CboTechs
        '
        Me.CboTechs.DisplayMember = "TECH"
        Me.CboTechs.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.CboTechs.FormattingEnabled = True
        Me.CboTechs.Location = New System.Drawing.Point(101, 146)
        Me.CboTechs.Name = "CboTechs"
        Me.CboTechs.Size = New System.Drawing.Size(394, 21)
        Me.CboTechs.TabIndex = 15
        Me.CboTechs.ValueMember = "NPERNUM"
        Me.CboTechs.Visible = False
        '
        'Chk_PlaAuto_OneTech
        '
        Me.Chk_PlaAuto_OneTech.AutoSize = True
        Me.Chk_PlaAuto_OneTech.Location = New System.Drawing.Point(88, 110)
        Me.Chk_PlaAuto_OneTech.Name = "Chk_PlaAuto_OneTech"
        Me.Chk_PlaAuto_OneTech.Size = New System.Drawing.Size(298, 17)
        Me.Chk_PlaAuto_OneTech.TabIndex = 14
        Me.Chk_PlaAuto_OneTech.Text = "Planification d'un seul technicien à sélectionner"
        Me.Chk_PlaAuto_OneTech.UseVisualStyleBackColor = True
        '
        'Chk_PlaAuto_AllTechs
        '
        Me.Chk_PlaAuto_AllTechs.AutoSize = True
        Me.Chk_PlaAuto_AllTechs.Location = New System.Drawing.Point(88, 52)
        Me.Chk_PlaAuto_AllTechs.Name = "Chk_PlaAuto_AllTechs"
        Me.Chk_PlaAuto_AllTechs.Size = New System.Drawing.Size(418, 17)
        Me.Chk_PlaAuto_AllTechs.TabIndex = 13
        Me.Chk_PlaAuto_AllTechs.Text = "Planification de tous techniciens ayant la/les compétences affectées"
        Me.Chk_PlaAuto_AllTechs.UseVisualStyleBackColor = True
        '
        'BtnValider
        '
        Me.BtnValider.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.BtnValider.Location = New System.Drawing.Point(489, 710)
        Me.BtnValider.Name = "BtnValider"
        Me.BtnValider.Size = New System.Drawing.Size(105, 85)
        Me.BtnValider.TabIndex = 4
        Me.BtnValider.Text = "Valider"
        Me.BtnValider.UseVisualStyleBackColor = True
        '
        'BtnClose
        '
        Me.BtnClose.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.BtnClose.Location = New System.Drawing.Point(654, 710)
        Me.BtnClose.Name = "BtnClose"
        Me.BtnClose.Size = New System.Drawing.Size(105, 85)
        Me.BtnClose.TabIndex = 5
        Me.BtnClose.Text = "Fermer"
        Me.BtnClose.UseVisualStyleBackColor = True
        '
        'BtnHelp
        '
        Me.BtnHelp.BackgroundImage = Global.MozartNet.My.Resources.Resources._49277
        Me.BtnHelp.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.BtnHelp.ImageAlign = System.Drawing.ContentAlignment.BottomLeft
        Me.BtnHelp.Location = New System.Drawing.Point(1154, 710)
        Me.BtnHelp.Name = "BtnHelp"
        Me.BtnHelp.Size = New System.Drawing.Size(105, 85)
        Me.BtnHelp.TabIndex = 6
        Me.BtnHelp.UseVisualStyleBackColor = True
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(19, 43)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(88, 13)
        Me.Label1.TabIndex = 0
        Me.Label1.Text = "Date de début"
        '
        'Txt_P_Debut
        '
        Me.Txt_P_Debut.BackColor = System.Drawing.Color.White
        Me.Txt_P_Debut.Location = New System.Drawing.Point(126, 43)
        Me.Txt_P_Debut.Name = "Txt_P_Debut"
        Me.Txt_P_Debut.ReadOnly = True
        Me.Txt_P_Debut.Size = New System.Drawing.Size(174, 20)
        Me.Txt_P_Debut.TabIndex = 1
        '
        'BtnAddDateP_Debut
        '
        Me.BtnAddDateP_Debut.BackgroundImage = Global.MozartNet.My.Resources.Resources.choix_calendrier
        Me.BtnAddDateP_Debut.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.BtnAddDateP_Debut.Location = New System.Drawing.Point(317, 29)
        Me.BtnAddDateP_Debut.Name = "BtnAddDateP_Debut"
        Me.BtnAddDateP_Debut.Size = New System.Drawing.Size(45, 40)
        Me.BtnAddDateP_Debut.TabIndex = 2
        Me.BtnAddDateP_Debut.UseVisualStyleBackColor = True
        '
        'BtnDelDateP_Debut
        '
        Me.BtnDelDateP_Debut.BackgroundImage = Global.MozartNet.My.Resources.Resources._stop
        Me.BtnDelDateP_Debut.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.BtnDelDateP_Debut.Location = New System.Drawing.Point(392, 29)
        Me.BtnDelDateP_Debut.Name = "BtnDelDateP_Debut"
        Me.BtnDelDateP_Debut.Size = New System.Drawing.Size(45, 40)
        Me.BtnDelDateP_Debut.TabIndex = 3
        Me.BtnDelDateP_Debut.UseVisualStyleBackColor = True
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Location = New System.Drawing.Point(19, 92)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(70, 13)
        Me.Label2.TabIndex = 4
        Me.Label2.Text = "Date de fin"
        '
        'Txt_P_Fin
        '
        Me.Txt_P_Fin.BackColor = System.Drawing.Color.White
        Me.Txt_P_Fin.Location = New System.Drawing.Point(126, 92)
        Me.Txt_P_Fin.Name = "Txt_P_Fin"
        Me.Txt_P_Fin.ReadOnly = True
        Me.Txt_P_Fin.Size = New System.Drawing.Size(174, 20)
        Me.Txt_P_Fin.TabIndex = 5
        '
        'BtnAddDateP_Fin
        '
        Me.BtnAddDateP_Fin.BackgroundImage = Global.MozartNet.My.Resources.Resources.choix_calendrier
        Me.BtnAddDateP_Fin.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.BtnAddDateP_Fin.Location = New System.Drawing.Point(317, 80)
        Me.BtnAddDateP_Fin.Name = "BtnAddDateP_Fin"
        Me.BtnAddDateP_Fin.Size = New System.Drawing.Size(45, 42)
        Me.BtnAddDateP_Fin.TabIndex = 6
        Me.BtnAddDateP_Fin.UseVisualStyleBackColor = True
        '
        'BtnDelDateP_Fin
        '
        Me.BtnDelDateP_Fin.BackgroundImage = Global.MozartNet.My.Resources.Resources._stop
        Me.BtnDelDateP_Fin.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.BtnDelDateP_Fin.Location = New System.Drawing.Point(392, 80)
        Me.BtnDelDateP_Fin.Name = "BtnDelDateP_Fin"
        Me.BtnDelDateP_Fin.Size = New System.Drawing.Size(45, 42)
        Me.BtnDelDateP_Fin.TabIndex = 7
        Me.BtnDelDateP_Fin.UseVisualStyleBackColor = True
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Location = New System.Drawing.Point(172, 140)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(25, 13)
        Me.Label3.TabIndex = 8
        Me.Label3.Text = "OU"
        '
        'Chk_P_Pla_DateS
        '
        Me.Chk_P_Pla_DateS.AutoSize = True
        Me.Chk_P_Pla_DateS.Location = New System.Drawing.Point(37, 175)
        Me.Chk_P_Pla_DateS.Name = "Chk_P_Pla_DateS"
        Me.Chk_P_Pla_DateS.Size = New System.Drawing.Size(343, 17)
        Me.Chk_P_Pla_DateS.TabIndex = 9
        Me.Chk_P_Pla_DateS.Text = "Planification à la date souhaitée (planification au jour J)"
        Me.Chk_P_Pla_DateS.UseVisualStyleBackColor = True
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Location = New System.Drawing.Point(172, 208)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(25, 13)
        Me.Label4.TabIndex = 10
        Me.Label4.Text = "OU"
        '
        'Chk_P_Pla_DateS_With_Tol
        '
        Me.Chk_P_Pla_DateS_With_Tol.AutoSize = True
        Me.Chk_P_Pla_DateS_With_Tol.Location = New System.Drawing.Point(37, 233)
        Me.Chk_P_Pla_DateS_With_Tol.Name = "Chk_P_Pla_DateS_With_Tol"
        Me.Chk_P_Pla_DateS_With_Tol.Size = New System.Drawing.Size(424, 17)
        Me.Chk_P_Pla_DateS_With_Tol.TabIndex = 11
        Me.Chk_P_Pla_DateS_With_Tol.Text = "Planification en fonction de la date souhaitée avec une tolérance de :"
        Me.Chk_P_Pla_DateS_With_Tol.UseVisualStyleBackColor = True
        '
        'CboDateS_Tolerance
        '
        Me.CboDateS_Tolerance.DisplayMember = "LIB_SEM"
        Me.CboDateS_Tolerance.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.CboDateS_Tolerance.FormattingEnabled = True
        Me.CboDateS_Tolerance.Location = New System.Drawing.Point(117, 269)
        Me.CboDateS_Tolerance.Name = "CboDateS_Tolerance"
        Me.CboDateS_Tolerance.Size = New System.Drawing.Size(232, 21)
        Me.CboDateS_Tolerance.TabIndex = 12
        Me.CboDateS_Tolerance.ValueMember = "NUM_SEM"
        Me.CboDateS_Tolerance.Visible = False
        '
        'GroupBox1
        '
        Me.GroupBox1.Controls.Add(Me.GroupBox2)
        Me.GroupBox1.Controls.Add(Me.CboDateS_Tolerance)
        Me.GroupBox1.Controls.Add(Me.Chk_P_Pla_DateS_With_Tol)
        Me.GroupBox1.Controls.Add(Me.Label4)
        Me.GroupBox1.Controls.Add(Me.Chk_P_Pla_DateS)
        Me.GroupBox1.Controls.Add(Me.Label3)
        Me.GroupBox1.Controls.Add(Me.BtnDelDateP_Fin)
        Me.GroupBox1.Controls.Add(Me.BtnAddDateP_Fin)
        Me.GroupBox1.Controls.Add(Me.Txt_P_Fin)
        Me.GroupBox1.Controls.Add(Me.Label2)
        Me.GroupBox1.Controls.Add(Me.BtnDelDateP_Debut)
        Me.GroupBox1.Controls.Add(Me.BtnAddDateP_Debut)
        Me.GroupBox1.Controls.Add(Me.Txt_P_Debut)
        Me.GroupBox1.Controls.Add(Me.Label1)
        Me.GroupBox1.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.GroupBox1.Location = New System.Drawing.Point(29, 12)
        Me.GroupBox1.Name = "GroupBox1"
        Me.GroupBox1.Size = New System.Drawing.Size(588, 634)
        Me.GroupBox1.TabIndex = 0
        Me.GroupBox1.TabStop = False
        Me.GroupBox1.Text = "Choix de la période (date de début et de fin inclus)"
        '
        'GroupBox2
        '
        Me.GroupBox2.Controls.Add(Me.ChkListJourSem)
        Me.GroupBox2.Controls.Add(Me.Label5)
        Me.GroupBox2.Controls.Add(Me.ChkJ_Forbid_NO)
        Me.GroupBox2.Controls.Add(Me.ChkJ_Forbid_YES)
        Me.GroupBox2.Location = New System.Drawing.Point(22, 324)
        Me.GroupBox2.Name = "GroupBox2"
        Me.GroupBox2.Size = New System.Drawing.Size(560, 276)
        Me.GroupBox2.TabIndex = 22
        Me.GroupBox2.TabStop = False
        Me.GroupBox2.Text = "Journées interdites à la planification"
        '
        'ChkListJourSem
        '
        Me.ChkListJourSem.CheckOnClick = True
        Me.ChkListJourSem.DisplayMember = "JOUR_NOM"
        Me.ChkListJourSem.HotTrackSelectMode = DevExpress.XtraEditors.HotTrackSelectMode.SelectItemOnClick
        Me.ChkListJourSem.Location = New System.Drawing.Point(71, 96)
        Me.ChkListJourSem.Name = "ChkListJourSem"
        Me.ChkListJourSem.SelectionMode = System.Windows.Forms.SelectionMode.None
        Me.ChkListJourSem.Size = New System.Drawing.Size(299, 165)
        Me.ChkListJourSem.TabIndex = 30
        Me.ChkListJourSem.ValueMember = "ID_JOUR"
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.Location = New System.Drawing.Point(20, 68)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(150, 13)
        Me.Label5.TabIndex = 29
        Me.Label5.Text = "Liste des jours à interdire"
        '
        'ChkJ_Forbid_NO
        '
        Me.ChkJ_Forbid_NO.AutoSize = True
        Me.ChkJ_Forbid_NO.Location = New System.Drawing.Point(268, 34)
        Me.ChkJ_Forbid_NO.Name = "ChkJ_Forbid_NO"
        Me.ChkJ_Forbid_NO.Size = New System.Drawing.Size(49, 17)
        Me.ChkJ_Forbid_NO.TabIndex = 28
        Me.ChkJ_Forbid_NO.Text = "Non"
        Me.ChkJ_Forbid_NO.UseVisualStyleBackColor = True
        '
        'ChkJ_Forbid_YES
        '
        Me.ChkJ_Forbid_YES.AutoSize = True
        Me.ChkJ_Forbid_YES.Location = New System.Drawing.Point(130, 34)
        Me.ChkJ_Forbid_YES.Name = "ChkJ_Forbid_YES"
        Me.ChkJ_Forbid_YES.Size = New System.Drawing.Size(45, 17)
        Me.ChkJ_Forbid_YES.TabIndex = 22
        Me.ChkJ_Forbid_YES.Text = "Oui"
        Me.ChkJ_Forbid_YES.UseVisualStyleBackColor = True
        '
        'Cal_Adder
        '
        Me.Cal_Adder.Location = New System.Drawing.Point(499, 128)
        Me.Cal_Adder.Name = "Cal_Adder"
        Me.Cal_Adder.TabIndex = 14
        Me.Cal_Adder.Visible = False
        '
        'frmPlanifAuto_Creation
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(1282, 830)
        Me.Controls.Add(Me.Cal_Adder)
        Me.Controls.Add(Me.BtnHelp)
        Me.Controls.Add(Me.BtnClose)
        Me.Controls.Add(Me.BtnValider)
        Me.Controls.Add(Me.GroupBox3)
        Me.Controls.Add(Me.GroupBox1)
        Me.Name = "frmPlanifAuto_Creation"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent
        Me.Text = "Choix du technicien à planifier et de la période de planification"
        Me.GroupBox3.ResumeLayout(False)
        Me.GroupBox3.PerformLayout()
        Me.GroupBox4.ResumeLayout(False)
        Me.GroupBox4.PerformLayout()
        Me.GroupBox1.ResumeLayout(False)
        Me.GroupBox1.PerformLayout()
        Me.GroupBox2.ResumeLayout(False)
        Me.GroupBox2.PerformLayout()
        CType(Me.ChkListJourSem, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents GroupBox3 As GroupBox
    Friend WithEvents BtnValider As Button
    Friend WithEvents BtnClose As Button
    Friend WithEvents BtnHelp As Button
    Friend WithEvents Label1 As Label
    Friend WithEvents Txt_P_Debut As TextBox
    Friend WithEvents BtnAddDateP_Debut As Button
    Friend WithEvents BtnDelDateP_Debut As Button
    Friend WithEvents Label2 As Label
    Friend WithEvents Txt_P_Fin As TextBox
    Friend WithEvents BtnAddDateP_Fin As Button
    Friend WithEvents BtnDelDateP_Fin As Button
    Friend WithEvents Label3 As Label
    Friend WithEvents Chk_P_Pla_DateS As CheckBox
    Friend WithEvents Label4 As Label
    Friend WithEvents Chk_P_Pla_DateS_With_Tol As CheckBox
    Friend WithEvents CboDateS_Tolerance As ComboBox
    Friend WithEvents GroupBox1 As GroupBox
    Friend WithEvents Cal_Adder As MonthCalendar
    Friend WithEvents GroupBox2 As GroupBox
    Friend WithEvents ChkJ_Forbid_NO As CheckBox
    Friend WithEvents ChkJ_Forbid_YES As CheckBox
    Friend WithEvents Label5 As Label
    Friend WithEvents ChkListJourSem As DevExpress.XtraEditors.CheckedListBoxControl
    Friend WithEvents CboTechs As ComboBox
    Friend WithEvents Chk_PlaAuto_OneTech As CheckBox
    Friend WithEvents Chk_PlaAuto_AllTechs As CheckBox
    Friend WithEvents GroupBox4 As GroupBox
    Friend WithEvents ChkPaveBloc_NO As CheckBox
    Friend WithEvents ChkPaveBloc_YES As CheckBox
    Friend WithEvents Label6 As Label
    Friend WithEvents Txt_PaveBloc_Text As TextBox
End Class
