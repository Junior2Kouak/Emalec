<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class frmMenuSynergee
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
        Me.lblStatus = New System.Windows.Forms.Label()
        Me.lstDis = New System.Windows.Forms.ListBox()
        Me.cmdSendReport = New System.Windows.Forms.Button()
        Me.txtWorkOrder = New System.Windows.Forms.TextBox()
        Me.txtUrlId = New System.Windows.Forms.TextBox()
        Me.cmdSendDatePlanif = New System.Windows.Forms.Button()
        Me.lblNbDis = New System.Windows.Forms.Label()
        Me.cmdSendDevis = New System.Windows.Forms.Button()
        Me.txtOut = New System.Windows.Forms.TextBox()
        Me.cmdFermer = New System.Windows.Forms.Button()
        Me.txtNumAction = New System.Windows.Forms.TextBox()
        Me.txtDiDesc = New System.Windows.Forms.TextBox()
        Me.lblDI = New System.Windows.Forms.Label()
        Me.lblStatutSynergee = New System.Windows.Forms.Label()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.txtNumDI = New System.Windows.Forms.TextBox()
        Me.fraSendReport = New MozartUC.apiGroupBox()
        Me.chkInterPlanifiee = New MozartUC.apiCheckBox()
        Me.dtpNewInter = New System.Windows.Forms.DateTimePicker()
        Me.optResoluNo = New System.Windows.Forms.RadioButton()
        Me.optResoluYes = New System.Windows.Forms.RadioButton()
        Me.Command2 = New MozartUC.apiButton()
        Me.cmdOk = New MozartUC.apiButton()
        Me.lblLabels4 = New System.Windows.Forms.Label()
        Me.lblLabels0 = New System.Windows.Forms.Label()
        Me.cmdGetSynergee = New MozartUC.apiButton()
        Me.cmdAttachement = New System.Windows.Forms.Button()
        Me.fraSendReport.SuspendLayout()
        Me.SuspendLayout()
        '
        'lblStatus
        '
        Me.lblStatus.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.lblStatus.AutoEllipsis = True
        Me.lblStatus.BackColor = System.Drawing.Color.White
        Me.lblStatus.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.lblStatus.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblStatus.Location = New System.Drawing.Point(21, 107)
        Me.lblStatus.Margin = New System.Windows.Forms.Padding(2, 0, 2, 0)
        Me.lblStatus.Name = "lblStatus"
        Me.lblStatus.Size = New System.Drawing.Size(900, 40)
        Me.lblStatus.TabIndex = 31
        Me.lblStatus.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'lstDis
        '
        Me.lstDis.Anchor = System.Windows.Forms.AnchorStyles.None
        Me.lstDis.BackColor = System.Drawing.Color.White
        Me.lstDis.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lstDis.FormattingEnabled = True
        Me.lstDis.ItemHeight = 16
        Me.lstDis.Location = New System.Drawing.Point(685, 69)
        Me.lstDis.Margin = New System.Windows.Forms.Padding(2)
        Me.lstDis.Name = "lstDis"
        Me.lstDis.Size = New System.Drawing.Size(236, 36)
        Me.lstDis.TabIndex = 30
        Me.lstDis.Visible = False
        '
        'cmdSendReport
        '
        Me.cmdSendReport.BackColor = System.Drawing.SystemColors.ControlLight
        Me.cmdSendReport.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.cmdSendReport.Location = New System.Drawing.Point(303, 13)
        Me.cmdSendReport.Margin = New System.Windows.Forms.Padding(2)
        Me.cmdSendReport.Name = "cmdSendReport"
        Me.cmdSendReport.Size = New System.Drawing.Size(90, 44)
        Me.cmdSendReport.TabIndex = 29
        Me.cmdSendReport.Text = "Envoi Date Intervention"
        Me.cmdSendReport.UseCompatibleTextRendering = True
        Me.cmdSendReport.UseMnemonic = False
        Me.cmdSendReport.UseVisualStyleBackColor = False
        '
        'txtWorkOrder
        '
        Me.txtWorkOrder.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtWorkOrder.Location = New System.Drawing.Point(21, 61)
        Me.txtWorkOrder.Margin = New System.Windows.Forms.Padding(2)
        Me.txtWorkOrder.Name = "txtWorkOrder"
        Me.txtWorkOrder.Size = New System.Drawing.Size(76, 22)
        Me.txtWorkOrder.TabIndex = 28
        Me.txtWorkOrder.Visible = False
        '
        'txtUrlId
        '
        Me.txtUrlId.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtUrlId.Location = New System.Drawing.Point(104, 61)
        Me.txtUrlId.Margin = New System.Windows.Forms.Padding(2)
        Me.txtUrlId.Name = "txtUrlId"
        Me.txtUrlId.Size = New System.Drawing.Size(354, 22)
        Me.txtUrlId.TabIndex = 27
        Me.txtUrlId.Visible = False
        '
        'cmdSendDatePlanif
        '
        Me.cmdSendDatePlanif.BackColor = System.Drawing.SystemColors.ControlLight
        Me.cmdSendDatePlanif.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.cmdSendDatePlanif.Location = New System.Drawing.Point(209, 13)
        Me.cmdSendDatePlanif.Margin = New System.Windows.Forms.Padding(2)
        Me.cmdSendDatePlanif.Name = "cmdSendDatePlanif"
        Me.cmdSendDatePlanif.Size = New System.Drawing.Size(90, 44)
        Me.cmdSendDatePlanif.TabIndex = 26
        Me.cmdSendDatePlanif.Text = "Envoi Date Planification"
        Me.cmdSendDatePlanif.UseCompatibleTextRendering = True
        Me.cmdSendDatePlanif.UseMnemonic = False
        Me.cmdSendDatePlanif.UseVisualStyleBackColor = False
        '
        'lblNbDis
        '
        Me.lblNbDis.AutoSize = True
        Me.lblNbDis.BackColor = System.Drawing.Color.Transparent
        Me.lblNbDis.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblNbDis.Location = New System.Drawing.Point(640, 26)
        Me.lblNbDis.Margin = New System.Windows.Forms.Padding(2, 0, 2, 0)
        Me.lblNbDis.Name = "lblNbDis"
        Me.lblNbDis.Size = New System.Drawing.Size(0, 19)
        Me.lblNbDis.TabIndex = 25
        Me.lblNbDis.UseCompatibleTextRendering = True
        Me.lblNbDis.UseMnemonic = False
        '
        'cmdSendDevis
        '
        Me.cmdSendDevis.BackColor = System.Drawing.SystemColors.ControlLight
        Me.cmdSendDevis.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.cmdSendDevis.Location = New System.Drawing.Point(115, 13)
        Me.cmdSendDevis.Margin = New System.Windows.Forms.Padding(2)
        Me.cmdSendDevis.Name = "cmdSendDevis"
        Me.cmdSendDevis.Size = New System.Drawing.Size(90, 44)
        Me.cmdSendDevis.TabIndex = 23
        Me.cmdSendDevis.Text = "Envoi Devis"
        Me.cmdSendDevis.UseCompatibleTextRendering = True
        Me.cmdSendDevis.UseMnemonic = False
        Me.cmdSendDevis.UseVisualStyleBackColor = False
        '
        'txtOut
        '
        Me.txtOut.BackColor = System.Drawing.Color.White
        Me.txtOut.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtOut.Location = New System.Drawing.Point(21, 319)
        Me.txtOut.Margin = New System.Windows.Forms.Padding(2)
        Me.txtOut.Multiline = True
        Me.txtOut.Name = "txtOut"
        Me.txtOut.ScrollBars = System.Windows.Forms.ScrollBars.Vertical
        Me.txtOut.Size = New System.Drawing.Size(900, 269)
        Me.txtOut.TabIndex = 22
        '
        'cmdFermer
        '
        Me.cmdFermer.BackColor = System.Drawing.SystemColors.ControlLight
        Me.cmdFermer.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.cmdFermer.Location = New System.Drawing.Point(824, 11)
        Me.cmdFermer.Margin = New System.Windows.Forms.Padding(2)
        Me.cmdFermer.Name = "cmdFermer"
        Me.cmdFermer.Size = New System.Drawing.Size(97, 44)
        Me.cmdFermer.TabIndex = 33
        Me.cmdFermer.Text = "Fermer"
        Me.cmdFermer.UseCompatibleTextRendering = True
        Me.cmdFermer.UseMnemonic = False
        Me.cmdFermer.UseVisualStyleBackColor = False
        '
        'txtNumAction
        '
        Me.txtNumAction.Enabled = False
        Me.txtNumAction.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtNumAction.Location = New System.Drawing.Point(711, 26)
        Me.txtNumAction.Margin = New System.Windows.Forms.Padding(2)
        Me.txtNumAction.Name = "txtNumAction"
        Me.txtNumAction.Size = New System.Drawing.Size(94, 22)
        Me.txtNumAction.TabIndex = 34
        '
        'txtDiDesc
        '
        Me.txtDiDesc.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtDiDesc.Location = New System.Drawing.Point(21, 176)
        Me.txtDiDesc.Margin = New System.Windows.Forms.Padding(2)
        Me.txtDiDesc.Multiline = True
        Me.txtDiDesc.Name = "txtDiDesc"
        Me.txtDiDesc.Size = New System.Drawing.Size(900, 121)
        Me.txtDiDesc.TabIndex = 36
        '
        'lblDI
        '
        Me.lblDI.AutoSize = True
        Me.lblDI.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblDI.Location = New System.Drawing.Point(21, 159)
        Me.lblDI.Name = "lblDI"
        Me.lblDI.Size = New System.Drawing.Size(138, 15)
        Me.lblDI.TabIndex = 37
        Me.lblDI.Text = "Description de la DI "
        '
        'lblStatutSynergee
        '
        Me.lblStatutSynergee.AutoSize = True
        Me.lblStatutSynergee.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblStatutSynergee.Location = New System.Drawing.Point(21, 90)
        Me.lblStatutSynergee.Name = "lblStatutSynergee"
        Me.lblStatutSynergee.Size = New System.Drawing.Size(269, 15)
        Me.lblStatutSynergee.TabIndex = 38
        Me.lblStatutSynergee.Text = "Statut de la DI dans le système Synergee"
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.Location = New System.Drawing.Point(21, 299)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(274, 15)
        Me.Label1.TabIndex = 39
        Me.Label1.Text = "Retour(s) de l'action Synergee demandée"
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label2.Location = New System.Drawing.Point(708, 9)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(57, 15)
        Me.Label2.TabIndex = 40
        Me.Label2.Text = "N° action"
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label3.Location = New System.Drawing.Point(606, 9)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(36, 15)
        Me.Label3.TabIndex = 42
        Me.Label3.Text = "N° DI"
        '
        'txtNumDI
        '
        Me.txtNumDI.Enabled = False
        Me.txtNumDI.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtNumDI.Location = New System.Drawing.Point(609, 26)
        Me.txtNumDI.Margin = New System.Windows.Forms.Padding(2)
        Me.txtNumDI.Name = "txtNumDI"
        Me.txtNumDI.Size = New System.Drawing.Size(94, 22)
        Me.txtNumDI.TabIndex = 41
        '
        'fraSendReport
        '
        Me.fraSendReport.BackColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(192, Byte), Integer), CType(CType(192, Byte), Integer))
        Me.fraSendReport.Controls.Add(Me.chkInterPlanifiee)
        Me.fraSendReport.Controls.Add(Me.dtpNewInter)
        Me.fraSendReport.Controls.Add(Me.optResoluNo)
        Me.fraSendReport.Controls.Add(Me.optResoluYes)
        Me.fraSendReport.Controls.Add(Me.Command2)
        Me.fraSendReport.Controls.Add(Me.cmdOk)
        Me.fraSendReport.Controls.Add(Me.lblLabels4)
        Me.fraSendReport.Controls.Add(Me.lblLabels0)
        Me.fraSendReport.FrameColor = System.Drawing.Color.Empty
        Me.fraSendReport.HelpContextID = 0
        Me.fraSendReport.Location = New System.Drawing.Point(241, 213)
        Me.fraSendReport.Name = "fraSendReport"
        Me.fraSendReport.Size = New System.Drawing.Size(425, 192)
        Me.fraSendReport.TabIndex = 43
        Me.fraSendReport.TabStop = False
        Me.fraSendReport.Visible = False
        '
        'chkInterPlanifiee
        '
        Me.chkInterPlanifiee.BackColor = System.Drawing.Color.Transparent
        Me.chkInterPlanifiee.CheckAlign = System.Drawing.ContentAlignment.MiddleRight
        Me.chkInterPlanifiee.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Bold)
        Me.chkInterPlanifiee.HelpContextID = 0
        Me.chkInterPlanifiee.ImeMode = System.Windows.Forms.ImeMode.NoControl
        Me.chkInterPlanifiee.Location = New System.Drawing.Point(29, 63)
        Me.chkInterPlanifiee.Name = "chkInterPlanifiee"
        Me.chkInterPlanifiee.Size = New System.Drawing.Size(244, 21)
        Me.chkInterPlanifiee.TabIndex = 31
        Me.chkInterPlanifiee.Text = "Intervention non planifiée"
        Me.chkInterPlanifiee.UseVisualStyleBackColor = False
        Me.chkInterPlanifiee.Visible = False
        '
        'dtpNewInter
        '
        Me.dtpNewInter.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.dtpNewInter.Format = System.Windows.Forms.DateTimePickerFormat.[Short]
        Me.dtpNewInter.Location = New System.Drawing.Point(264, 100)
        Me.dtpNewInter.Name = "dtpNewInter"
        Me.dtpNewInter.Size = New System.Drawing.Size(112, 21)
        Me.dtpNewInter.TabIndex = 29
        Me.dtpNewInter.Visible = False
        '
        'optResoluNo
        '
        Me.optResoluNo.AutoSize = True
        Me.optResoluNo.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.optResoluNo.Location = New System.Drawing.Point(255, 20)
        Me.optResoluNo.Name = "optResoluNo"
        Me.optResoluNo.Size = New System.Drawing.Size(51, 19)
        Me.optResoluNo.TabIndex = 28
        Me.optResoluNo.Text = "Non"
        Me.optResoluNo.UseVisualStyleBackColor = True
        '
        'optResoluYes
        '
        Me.optResoluYes.AutoSize = True
        Me.optResoluYes.Checked = True
        Me.optResoluYes.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.optResoluYes.Location = New System.Drawing.Point(182, 20)
        Me.optResoluYes.Name = "optResoluYes"
        Me.optResoluYes.Size = New System.Drawing.Size(47, 19)
        Me.optResoluYes.TabIndex = 27
        Me.optResoluYes.TabStop = True
        Me.optResoluYes.Text = "Oui"
        Me.optResoluYes.UseVisualStyleBackColor = True
        '
        'Command2
        '
        Me.Command2.HelpContextID = 0
        Me.Command2.ImeMode = System.Windows.Forms.ImeMode.NoControl
        Me.Command2.Location = New System.Drawing.Point(238, 151)
        Me.Command2.Name = "Command2"
        Me.Command2.Size = New System.Drawing.Size(84, 35)
        Me.Command2.TabIndex = 23
        Me.Command2.Text = "Annuler"
        Me.Command2.UseVisualStyleBackColor = True
        '
        'cmdOk
        '
        Me.cmdOk.HelpContextID = 0
        Me.cmdOk.ImeMode = System.Windows.Forms.ImeMode.NoControl
        Me.cmdOk.Location = New System.Drawing.Point(326, 151)
        Me.cmdOk.Name = "cmdOk"
        Me.cmdOk.Size = New System.Drawing.Size(84, 35)
        Me.cmdOk.TabIndex = 22
        Me.cmdOk.Text = "Valider"
        Me.cmdOk.UseVisualStyleBackColor = True
        '
        'lblLabels4
        '
        Me.lblLabels4.AutoSize = True
        Me.lblLabels4.BackColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(192, Byte), Integer), CType(CType(192, Byte), Integer))
        Me.lblLabels4.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Bold)
        Me.lblLabels4.ImeMode = System.Windows.Forms.ImeMode.NoControl
        Me.lblLabels4.Location = New System.Drawing.Point(29, 21)
        Me.lblLabels4.Name = "lblLabels4"
        Me.lblLabels4.Size = New System.Drawing.Size(130, 16)
        Me.lblLabels4.TabIndex = 26
        Me.lblLabels4.Text = "Problème résolu :"
        '
        'lblLabels0
        '
        Me.lblLabels0.AutoSize = True
        Me.lblLabels0.BackColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(192, Byte), Integer), CType(CType(192, Byte), Integer))
        Me.lblLabels0.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Bold)
        Me.lblLabels0.ImeMode = System.Windows.Forms.ImeMode.NoControl
        Me.lblLabels0.Location = New System.Drawing.Point(29, 103)
        Me.lblLabels0.Name = "lblLabels0"
        Me.lblLabels0.Size = New System.Drawing.Size(231, 32)
        Me.lblLabels0.TabIndex = 25
        Me.lblLabels0.Text = "Date de la nouvelle intervention " & Global.Microsoft.VisualBasic.ChrW(13) & Global.Microsoft.VisualBasic.ChrW(10) & "(si planifiée)" & Global.Microsoft.VisualBasic.ChrW(13) & Global.Microsoft.VisualBasic.ChrW(10)
        Me.lblLabels0.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.lblLabels0.Visible = False
        '
        'cmdGetSynergee
        '
        Me.cmdGetSynergee.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.0!)
        Me.cmdGetSynergee.HelpContextID = 394
        Me.cmdGetSynergee.ImeMode = System.Windows.Forms.ImeMode.NoControl
        Me.cmdGetSynergee.Location = New System.Drawing.Point(21, 13)
        Me.cmdGetSynergee.Name = "cmdGetSynergee"
        Me.cmdGetSynergee.Size = New System.Drawing.Size(90, 44)
        Me.cmdGetSynergee.TabIndex = 44
        Me.cmdGetSynergee.Tag = "2"
        Me.cmdGetSynergee.Text = "Interroger Synergee"
        Me.cmdGetSynergee.UseVisualStyleBackColor = True
        '
        'cmdAttachement
        '
        Me.cmdAttachement.BackColor = System.Drawing.SystemColors.ControlLight
        Me.cmdAttachement.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.cmdAttachement.Location = New System.Drawing.Point(397, 13)
        Me.cmdAttachement.Margin = New System.Windows.Forms.Padding(2)
        Me.cmdAttachement.Name = "cmdAttachement"
        Me.cmdAttachement.Size = New System.Drawing.Size(90, 44)
        Me.cmdAttachement.TabIndex = 45
        Me.cmdAttachement.Text = "Envoi Attachement"
        Me.cmdAttachement.UseCompatibleTextRendering = True
        Me.cmdAttachement.UseMnemonic = False
        Me.cmdAttachement.UseVisualStyleBackColor = False
        '
        'frmMenuSynergee
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.Wheat
        Me.ClientSize = New System.Drawing.Size(997, 594)
        Me.Controls.Add(Me.cmdAttachement)
        Me.Controls.Add(Me.cmdGetSynergee)
        Me.Controls.Add(Me.fraSendReport)
        Me.Controls.Add(Me.Label3)
        Me.Controls.Add(Me.txtNumDI)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.lblStatutSynergee)
        Me.Controls.Add(Me.lblDI)
        Me.Controls.Add(Me.txtDiDesc)
        Me.Controls.Add(Me.txtNumAction)
        Me.Controls.Add(Me.cmdFermer)
        Me.Controls.Add(Me.lblStatus)
        Me.Controls.Add(Me.lstDis)
        Me.Controls.Add(Me.cmdSendReport)
        Me.Controls.Add(Me.txtWorkOrder)
        Me.Controls.Add(Me.txtUrlId)
        Me.Controls.Add(Me.cmdSendDatePlanif)
        Me.Controls.Add(Me.lblNbDis)
        Me.Controls.Add(Me.cmdSendDevis)
        Me.Controls.Add(Me.txtOut)
        Me.Margin = New System.Windows.Forms.Padding(2)
        Me.Name = "frmMenuSynergee"
        Me.Text = "Actions sur les DI Synergee"
        Me.fraSendReport.ResumeLayout(False)
        Me.fraSendReport.PerformLayout()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents lblStatus As Label
    Friend WithEvents lstDis As ListBox
    Private WithEvents cmdSendReport As Button
    Friend WithEvents txtWorkOrder As TextBox
    Friend WithEvents txtUrlId As TextBox
    Private WithEvents cmdSendDatePlanif As Button
    Friend WithEvents lblNbDis As Label
    Private WithEvents cmdSendDevis As Button
    Private WithEvents txtOut As TextBox
    Private WithEvents cmdFermer As Button
    Friend WithEvents txtNumAction As TextBox
    Friend WithEvents txtDiDesc As TextBox
    Friend WithEvents lblDI As Label
    Friend WithEvents lblStatutSynergee As Label
    Friend WithEvents Label1 As Label
    Friend WithEvents Label2 As Label
    Friend WithEvents Label3 As Label
    Friend WithEvents txtNumDI As TextBox
    Private WithEvents fraSendReport As MozartUC.apiGroupBox
    Private WithEvents Command2 As MozartUC.apiButton
    Private WithEvents cmdOk As MozartUC.apiButton
    Private WithEvents lblLabels4 As Label
    Private WithEvents lblLabels0 As Label
    Friend WithEvents dtpNewInter As DateTimePicker
    Friend WithEvents optResoluNo As RadioButton
    Friend WithEvents optResoluYes As RadioButton
    Private WithEvents chkInterPlanifiee As MozartUC.apiCheckBox
    Private WithEvents cmdGetSynergee As MozartUC.apiButton
    Private WithEvents cmdAttachement As Button
End Class
