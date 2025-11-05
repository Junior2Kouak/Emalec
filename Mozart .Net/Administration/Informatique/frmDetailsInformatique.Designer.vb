<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmDetailsInformatique
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(frmDetailsInformatique))
        Me.LabelNORDINUM = New System.Windows.Forms.Label()
        Me.LabelSociete = New System.Windows.Forms.Label()
        Me.GroupBox1 = New System.Windows.Forms.GroupBox()
        Me.BtnFermer = New System.Windows.Forms.Button()
        Me.BtnEnreg = New System.Windows.Forms.Button()
        Me.LabelTitre = New System.Windows.Forms.Label()
        Me.GroupBox3 = New System.Windows.Forms.GroupBox()
        Me.cboMateriel = New MozartUC.apiCombo()
        Me.TxtAnyDesk = New System.Windows.Forms.TextBox()
        Me.Label14 = New System.Windows.Forms.Label()
        Me.ChkAtt_retour = New System.Windows.Forms.CheckBox()
        Me.CboSociete = New System.Windows.Forms.ComboBox()
        Me.LblSociete = New System.Windows.Forms.Label()
        Me.GroupBoxDetailsUC = New System.Windows.Forms.GroupBox()
        Me.BtnSuppr = New System.Windows.Forms.Button()
        Me.BtnModifier = New System.Windows.Forms.Button()
        Me.GroupBoxGestionDetailsUC = New System.Windows.Forms.GroupBox()
        Me.LabelNucNum = New System.Windows.Forms.Label()
        Me.BtnA = New System.Windows.Forms.Button()
        Me.BtnV = New System.Windows.Forms.Button()
        Me.txtLicence = New System.Windows.Forms.TextBox()
        Me.txtProgramme = New System.Windows.Forms.TextBox()
        Me.Label11 = New System.Windows.Forms.Label()
        Me.Label13 = New System.Windows.Forms.Label()
        Me.BtnAjout = New System.Windows.Forms.Button()
        Me.GridControl1 = New DevExpress.XtraGrid.GridControl()
        Me.GridView1 = New DevExpress.XtraGrid.Views.Grid.GridView()
        Me.NUCNUM = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.VUCPROGRAMME = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.VUCLICENCE = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.cbEcoLabel = New System.Windows.Forms.CheckBox()
        Me.CBPopUp = New System.Windows.Forms.CheckBox()
        Me.txtAdrIP = New System.Windows.Forms.TextBox()
        Me.Label10 = New System.Windows.Forms.Label()
        Me.BtnDate2 = New System.Windows.Forms.Button()
        Me.BtmSupp2 = New System.Windows.Forms.Button()
        Me.txtDtSortie = New System.Windows.Forms.TextBox()
        Me.Label6 = New System.Windows.Forms.Label()
        Me.txtNumSerie = New System.Windows.Forms.TextBox()
        Me.cboUtil = New System.Windows.Forms.ComboBox()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.MonthCalendar1 = New System.Windows.Forms.MonthCalendar()
        Me.txtType = New System.Windows.Forms.TextBox()
        Me.txtMarque = New System.Windows.Forms.TextBox()
        Me.BtnDate1 = New System.Windows.Forms.Button()
        Me.BtnSupp1 = New System.Windows.Forms.Button()
        Me.txtDtEntree = New System.Windows.Forms.TextBox()
        Me.txtImplantation = New System.Windows.Forms.TextBox()
        Me.txtObs = New System.Windows.Forms.TextBox()
        Me.Label7 = New System.Windows.Forms.Label()
        Me.Label12 = New System.Windows.Forms.Label()
        Me.txtMat = New System.Windows.Forms.TextBox()
        Me.Label9 = New System.Windows.Forms.Label()
        Me.Label8 = New System.Windows.Forms.Label()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.TxtNum = New System.Windows.Forms.TextBox()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.TxtDateEnvoiMat = New System.Windows.Forms.TextBox()
        Me.Label15 = New System.Windows.Forms.Label()
        Me.BtnDateEnvoiMat = New System.Windows.Forms.Button()
        Me.BtnSuppDateEnvoiMat = New System.Windows.Forms.Button()
        Me.GroupBox1.SuspendLayout()
        Me.GroupBox3.SuspendLayout()
        Me.GroupBoxDetailsUC.SuspendLayout()
        Me.GroupBoxGestionDetailsUC.SuspendLayout()
        CType(Me.GridControl1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.GridView1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'LabelNORDINUM
        '
        resources.ApplyResources(Me.LabelNORDINUM, "LabelNORDINUM")
        Me.LabelNORDINUM.ForeColor = System.Drawing.Color.Red
        Me.LabelNORDINUM.Name = "LabelNORDINUM"
        '
        'LabelSociete
        '
        resources.ApplyResources(Me.LabelSociete, "LabelSociete")
        Me.LabelSociete.Name = "LabelSociete"
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
        Me.BtnFermer.DialogResult = System.Windows.Forms.DialogResult.Cancel
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
        Me.LabelTitre.Tag = "44"
        '
        'GroupBox3
        '
        Me.GroupBox3.Controls.Add(Me.BtnDateEnvoiMat)
        Me.GroupBox3.Controls.Add(Me.BtnSuppDateEnvoiMat)
        Me.GroupBox3.Controls.Add(Me.Label15)
        Me.GroupBox3.Controls.Add(Me.TxtDateEnvoiMat)
        Me.GroupBox3.Controls.Add(Me.cboMateriel)
        Me.GroupBox3.Controls.Add(Me.TxtAnyDesk)
        Me.GroupBox3.Controls.Add(Me.Label14)
        Me.GroupBox3.Controls.Add(Me.ChkAtt_retour)
        Me.GroupBox3.Controls.Add(Me.CboSociete)
        Me.GroupBox3.Controls.Add(Me.LblSociete)
        Me.GroupBox3.Controls.Add(Me.GroupBoxDetailsUC)
        Me.GroupBox3.Controls.Add(Me.cbEcoLabel)
        Me.GroupBox3.Controls.Add(Me.CBPopUp)
        Me.GroupBox3.Controls.Add(Me.txtAdrIP)
        Me.GroupBox3.Controls.Add(Me.Label10)
        Me.GroupBox3.Controls.Add(Me.BtnDate2)
        Me.GroupBox3.Controls.Add(Me.BtmSupp2)
        Me.GroupBox3.Controls.Add(Me.txtDtSortie)
        Me.GroupBox3.Controls.Add(Me.Label6)
        Me.GroupBox3.Controls.Add(Me.txtNumSerie)
        Me.GroupBox3.Controls.Add(Me.cboUtil)
        Me.GroupBox3.Controls.Add(Me.Label2)
        Me.GroupBox3.Controls.Add(Me.MonthCalendar1)
        Me.GroupBox3.Controls.Add(Me.txtType)
        Me.GroupBox3.Controls.Add(Me.txtMarque)
        Me.GroupBox3.Controls.Add(Me.BtnDate1)
        Me.GroupBox3.Controls.Add(Me.BtnSupp1)
        Me.GroupBox3.Controls.Add(Me.txtDtEntree)
        Me.GroupBox3.Controls.Add(Me.txtImplantation)
        Me.GroupBox3.Controls.Add(Me.txtObs)
        Me.GroupBox3.Controls.Add(Me.Label7)
        Me.GroupBox3.Controls.Add(Me.Label12)
        Me.GroupBox3.Controls.Add(Me.txtMat)
        Me.GroupBox3.Controls.Add(Me.Label9)
        Me.GroupBox3.Controls.Add(Me.Label8)
        Me.GroupBox3.Controls.Add(Me.Label5)
        Me.GroupBox3.Controls.Add(Me.Label4)
        Me.GroupBox3.Controls.Add(Me.Label3)
        Me.GroupBox3.Controls.Add(Me.TxtNum)
        Me.GroupBox3.Controls.Add(Me.Label1)
        resources.ApplyResources(Me.GroupBox3, "GroupBox3")
        Me.GroupBox3.ForeColor = System.Drawing.Color.Red
        Me.GroupBox3.Name = "GroupBox3"
        Me.GroupBox3.TabStop = False
        '
        'cboMateriel
        '
        resources.ApplyResources(Me.cboMateriel, "cboMateriel")
        Me.cboMateriel.Name = "cboMateriel"
        Me.cboMateriel.NewValues = False
        '
        'TxtAnyDesk
        '
        resources.ApplyResources(Me.TxtAnyDesk, "TxtAnyDesk")
        Me.TxtAnyDesk.Name = "TxtAnyDesk"
        '
        'Label14
        '
        resources.ApplyResources(Me.Label14, "Label14")
        Me.Label14.ForeColor = System.Drawing.Color.Black
        Me.Label14.Name = "Label14"
        '
        'ChkAtt_retour
        '
        resources.ApplyResources(Me.ChkAtt_retour, "ChkAtt_retour")
        Me.ChkAtt_retour.ForeColor = System.Drawing.Color.Black
        Me.ChkAtt_retour.Name = "ChkAtt_retour"
        Me.ChkAtt_retour.UseVisualStyleBackColor = True
        '
        'CboSociete
        '
        Me.CboSociete.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.CboSociete.FormattingEnabled = True
        resources.ApplyResources(Me.CboSociete, "CboSociete")
        Me.CboSociete.Name = "CboSociete"
        Me.CboSociete.Tag = "114"
        '
        'LblSociete
        '
        resources.ApplyResources(Me.LblSociete, "LblSociete")
        Me.LblSociete.ForeColor = System.Drawing.Color.Black
        Me.LblSociete.Name = "LblSociete"
        '
        'GroupBoxDetailsUC
        '
        Me.GroupBoxDetailsUC.Controls.Add(Me.BtnSuppr)
        Me.GroupBoxDetailsUC.Controls.Add(Me.BtnModifier)
        Me.GroupBoxDetailsUC.Controls.Add(Me.GroupBoxGestionDetailsUC)
        Me.GroupBoxDetailsUC.Controls.Add(Me.BtnAjout)
        Me.GroupBoxDetailsUC.Controls.Add(Me.GridControl1)
        resources.ApplyResources(Me.GroupBoxDetailsUC, "GroupBoxDetailsUC")
        Me.GroupBoxDetailsUC.ForeColor = System.Drawing.Color.Red
        Me.GroupBoxDetailsUC.Name = "GroupBoxDetailsUC"
        Me.GroupBoxDetailsUC.TabStop = False
        '
        'BtnSuppr
        '
        resources.ApplyResources(Me.BtnSuppr, "BtnSuppr")
        Me.BtnSuppr.ForeColor = System.Drawing.Color.Black
        Me.BtnSuppr.Name = "BtnSuppr"
        Me.BtnSuppr.UseVisualStyleBackColor = True
        '
        'BtnModifier
        '
        resources.ApplyResources(Me.BtnModifier, "BtnModifier")
        Me.BtnModifier.ForeColor = System.Drawing.Color.Black
        Me.BtnModifier.Name = "BtnModifier"
        Me.BtnModifier.UseVisualStyleBackColor = True
        '
        'GroupBoxGestionDetailsUC
        '
        Me.GroupBoxGestionDetailsUC.Controls.Add(Me.LabelNucNum)
        Me.GroupBoxGestionDetailsUC.Controls.Add(Me.BtnA)
        Me.GroupBoxGestionDetailsUC.Controls.Add(Me.BtnV)
        Me.GroupBoxGestionDetailsUC.Controls.Add(Me.txtLicence)
        Me.GroupBoxGestionDetailsUC.Controls.Add(Me.txtProgramme)
        Me.GroupBoxGestionDetailsUC.Controls.Add(Me.Label11)
        Me.GroupBoxGestionDetailsUC.Controls.Add(Me.Label13)
        resources.ApplyResources(Me.GroupBoxGestionDetailsUC, "GroupBoxGestionDetailsUC")
        Me.GroupBoxGestionDetailsUC.ForeColor = System.Drawing.Color.Red
        Me.GroupBoxGestionDetailsUC.Name = "GroupBoxGestionDetailsUC"
        Me.GroupBoxGestionDetailsUC.TabStop = False
        '
        'LabelNucNum
        '
        resources.ApplyResources(Me.LabelNucNum, "LabelNucNum")
        Me.LabelNucNum.ForeColor = System.Drawing.Color.Red
        Me.LabelNucNum.Name = "LabelNucNum"
        '
        'BtnA
        '
        resources.ApplyResources(Me.BtnA, "BtnA")
        Me.BtnA.ForeColor = System.Drawing.Color.Red
        Me.BtnA.Name = "BtnA"
        Me.BtnA.UseVisualStyleBackColor = True
        '
        'BtnV
        '
        resources.ApplyResources(Me.BtnV, "BtnV")
        Me.BtnV.ForeColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(192, Byte), Integer), CType(CType(0, Byte), Integer))
        Me.BtnV.Name = "BtnV"
        Me.BtnV.UseVisualStyleBackColor = True
        '
        'txtLicence
        '
        resources.ApplyResources(Me.txtLicence, "txtLicence")
        Me.txtLicence.Name = "txtLicence"
        '
        'txtProgramme
        '
        resources.ApplyResources(Me.txtProgramme, "txtProgramme")
        Me.txtProgramme.Name = "txtProgramme"
        '
        'Label11
        '
        resources.ApplyResources(Me.Label11, "Label11")
        Me.Label11.ForeColor = System.Drawing.Color.Black
        Me.Label11.Name = "Label11"
        '
        'Label13
        '
        resources.ApplyResources(Me.Label13, "Label13")
        Me.Label13.ForeColor = System.Drawing.Color.Black
        Me.Label13.Name = "Label13"
        '
        'BtnAjout
        '
        resources.ApplyResources(Me.BtnAjout, "BtnAjout")
        Me.BtnAjout.ForeColor = System.Drawing.Color.Black
        Me.BtnAjout.Name = "BtnAjout"
        Me.BtnAjout.UseVisualStyleBackColor = True
        '
        'GridControl1
        '
        resources.ApplyResources(Me.GridControl1, "GridControl1")
        Me.GridControl1.MainView = Me.GridView1
        Me.GridControl1.Name = "GridControl1"
        Me.GridControl1.ViewCollection.AddRange(New DevExpress.XtraGrid.Views.Base.BaseView() {Me.GridView1})
        '
        'GridView1
        '
        Me.GridView1.Appearance.HeaderPanel.Font = CType(resources.GetObject("GridView1.Appearance.HeaderPanel.Font"), System.Drawing.Font)
        Me.GridView1.Appearance.HeaderPanel.Options.UseFont = True
        Me.GridView1.Appearance.HeaderPanel.Options.UseTextOptions = True
        Me.GridView1.Appearance.HeaderPanel.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center
        Me.GridView1.Columns.AddRange(New DevExpress.XtraGrid.Columns.GridColumn() {Me.NUCNUM, Me.VUCPROGRAMME, Me.VUCLICENCE})
        Me.GridView1.GridControl = Me.GridControl1
        Me.GridView1.Name = "GridView1"
        Me.GridView1.OptionsBehavior.ReadOnly = True
        Me.GridView1.OptionsCustomization.AllowGroup = False
        Me.GridView1.OptionsPrint.PrintPreview = True
        Me.GridView1.OptionsView.ShowAutoFilterRow = True
        Me.GridView1.OptionsView.ShowFooter = True
        Me.GridView1.OptionsView.ShowGroupPanel = False
        '
        'NUCNUM
        '
        resources.ApplyResources(Me.NUCNUM, "NUCNUM")
        Me.NUCNUM.FieldName = "NUCNUM"
        Me.NUCNUM.Name = "NUCNUM"
        '
        'VUCPROGRAMME
        '
        Me.VUCPROGRAMME.AppearanceHeader.ForeColor = System.Drawing.Color.Black
        Me.VUCPROGRAMME.AppearanceHeader.Options.UseForeColor = True
        resources.ApplyResources(Me.VUCPROGRAMME, "VUCPROGRAMME")
        Me.VUCPROGRAMME.FieldName = "VUCPROGRAMME"
        Me.VUCPROGRAMME.Name = "VUCPROGRAMME"
        Me.VUCPROGRAMME.OptionsColumn.AllowEdit = False
        Me.VUCPROGRAMME.OptionsFilter.AutoFilterCondition = DevExpress.XtraGrid.Columns.AutoFilterCondition.Contains
        Me.VUCPROGRAMME.Summary.AddRange(New DevExpress.XtraGrid.GridSummaryItem() {New DevExpress.XtraGrid.GridColumnSummaryItem(CType(resources.GetObject("VUCPROGRAMME.Summary"), DevExpress.Data.SummaryItemType))})
        '
        'VUCLICENCE
        '
        Me.VUCLICENCE.AppearanceHeader.ForeColor = System.Drawing.Color.Black
        Me.VUCLICENCE.AppearanceHeader.Options.UseForeColor = True
        resources.ApplyResources(Me.VUCLICENCE, "VUCLICENCE")
        Me.VUCLICENCE.FieldName = "VUCLICENCE"
        Me.VUCLICENCE.Name = "VUCLICENCE"
        Me.VUCLICENCE.OptionsColumn.AllowEdit = False
        Me.VUCLICENCE.OptionsFilter.AutoFilterCondition = DevExpress.XtraGrid.Columns.AutoFilterCondition.Contains
        '
        'cbEcoLabel
        '
        resources.ApplyResources(Me.cbEcoLabel, "cbEcoLabel")
        Me.cbEcoLabel.ForeColor = System.Drawing.Color.Black
        Me.cbEcoLabel.Name = "cbEcoLabel"
        Me.cbEcoLabel.UseVisualStyleBackColor = True
        '
        'CBPopUp
        '
        resources.ApplyResources(Me.CBPopUp, "CBPopUp")
        Me.CBPopUp.ForeColor = System.Drawing.Color.Black
        Me.CBPopUp.Name = "CBPopUp"
        Me.CBPopUp.UseVisualStyleBackColor = True
        '
        'txtAdrIP
        '
        resources.ApplyResources(Me.txtAdrIP, "txtAdrIP")
        Me.txtAdrIP.Name = "txtAdrIP"
        '
        'Label10
        '
        resources.ApplyResources(Me.Label10, "Label10")
        Me.Label10.ForeColor = System.Drawing.Color.Black
        Me.Label10.Name = "Label10"
        '
        'BtnDate2
        '
        Me.BtnDate2.Image = Global.MozartNet.My.Resources.Resources.choix_calendrier
        resources.ApplyResources(Me.BtnDate2, "BtnDate2")
        Me.BtnDate2.Name = "BtnDate2"
        Me.BtnDate2.UseVisualStyleBackColor = True
        '
        'BtmSupp2
        '
        Me.BtmSupp2.Image = Global.MozartNet.My.Resources.Resources.suppression
        resources.ApplyResources(Me.BtmSupp2, "BtmSupp2")
        Me.BtmSupp2.Name = "BtmSupp2"
        Me.BtmSupp2.UseVisualStyleBackColor = True
        '
        'txtDtSortie
        '
        resources.ApplyResources(Me.txtDtSortie, "txtDtSortie")
        Me.txtDtSortie.Name = "txtDtSortie"
        '
        'Label6
        '
        resources.ApplyResources(Me.Label6, "Label6")
        Me.Label6.ForeColor = System.Drawing.Color.Black
        Me.Label6.Name = "Label6"
        '
        'txtNumSerie
        '
        resources.ApplyResources(Me.txtNumSerie, "txtNumSerie")
        Me.txtNumSerie.Name = "txtNumSerie"
        '
        'cboUtil
        '
        Me.cboUtil.DisplayMember = "VPERNOMPRENOM"
        Me.cboUtil.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.cboUtil.FormattingEnabled = True
        resources.ApplyResources(Me.cboUtil, "cboUtil")
        Me.cboUtil.Name = "cboUtil"
        Me.cboUtil.ValueMember = "NPERNUM"
        '
        'Label2
        '
        resources.ApplyResources(Me.Label2, "Label2")
        Me.Label2.ForeColor = System.Drawing.Color.Black
        Me.Label2.Name = "Label2"
        '
        'MonthCalendar1
        '
        resources.ApplyResources(Me.MonthCalendar1, "MonthCalendar1")
        Me.MonthCalendar1.Name = "MonthCalendar1"
        '
        'txtType
        '
        resources.ApplyResources(Me.txtType, "txtType")
        Me.txtType.Name = "txtType"
        '
        'txtMarque
        '
        resources.ApplyResources(Me.txtMarque, "txtMarque")
        Me.txtMarque.Name = "txtMarque"
        '
        'BtnDate1
        '
        Me.BtnDate1.Image = Global.MozartNet.My.Resources.Resources.choix_calendrier
        resources.ApplyResources(Me.BtnDate1, "BtnDate1")
        Me.BtnDate1.Name = "BtnDate1"
        Me.BtnDate1.UseVisualStyleBackColor = True
        '
        'BtnSupp1
        '
        Me.BtnSupp1.Image = Global.MozartNet.My.Resources.Resources.suppression
        resources.ApplyResources(Me.BtnSupp1, "BtnSupp1")
        Me.BtnSupp1.Name = "BtnSupp1"
        Me.BtnSupp1.UseVisualStyleBackColor = True
        '
        'txtDtEntree
        '
        resources.ApplyResources(Me.txtDtEntree, "txtDtEntree")
        Me.txtDtEntree.Name = "txtDtEntree"
        '
        'txtImplantation
        '
        resources.ApplyResources(Me.txtImplantation, "txtImplantation")
        Me.txtImplantation.Name = "txtImplantation"
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
        'txtMat
        '
        resources.ApplyResources(Me.txtMat, "txtMat")
        Me.txtMat.Name = "txtMat"
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
        Me.TxtNum.BackColor = System.Drawing.Color.FromArgb(CType(CType(224, Byte), Integer), CType(CType(224, Byte), Integer), CType(CType(224, Byte), Integer))
        resources.ApplyResources(Me.TxtNum, "TxtNum")
        Me.TxtNum.Name = "TxtNum"
        '
        'Label1
        '
        resources.ApplyResources(Me.Label1, "Label1")
        Me.Label1.ForeColor = System.Drawing.Color.Black
        Me.Label1.Name = "Label1"
        '
        'TxtDateEnvoiMat
        '
        resources.ApplyResources(Me.TxtDateEnvoiMat, "TxtDateEnvoiMat")
        Me.TxtDateEnvoiMat.Name = "TxtDateEnvoiMat"
        '
        'Label15
        '
        resources.ApplyResources(Me.Label15, "Label15")
        Me.Label15.ForeColor = System.Drawing.Color.Black
        Me.Label15.Name = "Label15"
        '
        'BtnDateEnvoiMat
        '
        Me.BtnDateEnvoiMat.Image = Global.MozartNet.My.Resources.Resources.choix_calendrier
        resources.ApplyResources(Me.BtnDateEnvoiMat, "BtnDateEnvoiMat")
        Me.BtnDateEnvoiMat.Name = "BtnDateEnvoiMat"
        Me.BtnDateEnvoiMat.UseVisualStyleBackColor = True
        '
        'BtnSuppDateEnvoiMat
        '
        Me.BtnSuppDateEnvoiMat.Image = Global.MozartNet.My.Resources.Resources.suppression
        resources.ApplyResources(Me.BtnSuppDateEnvoiMat, "BtnSuppDateEnvoiMat")
        Me.BtnSuppDateEnvoiMat.Name = "BtnSuppDateEnvoiMat"
        Me.BtnSuppDateEnvoiMat.UseVisualStyleBackColor = True
        '
        'frmDetailsInformatique
        '
        resources.ApplyResources(Me, "$this")
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.Wheat
        Me.CancelButton = Me.BtnFermer
        Me.Controls.Add(Me.GroupBox3)
        Me.Controls.Add(Me.LabelNORDINUM)
        Me.Controls.Add(Me.LabelSociete)
        Me.Controls.Add(Me.GroupBox1)
        Me.Controls.Add(Me.LabelTitre)
        Me.Name = "frmDetailsInformatique"
        Me.WindowState = System.Windows.Forms.FormWindowState.Maximized
        Me.GroupBox1.ResumeLayout(False)
        Me.GroupBox3.ResumeLayout(False)
        Me.GroupBox3.PerformLayout()
        Me.GroupBoxDetailsUC.ResumeLayout(False)
        Me.GroupBoxGestionDetailsUC.ResumeLayout(False)
        Me.GroupBoxGestionDetailsUC.PerformLayout()
        CType(Me.GridControl1, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.GridView1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents LabelNORDINUM As System.Windows.Forms.Label
  Friend WithEvents LabelSociete As System.Windows.Forms.Label
  Friend WithEvents GroupBox1 As System.Windows.Forms.GroupBox
  Friend WithEvents BtnFermer As System.Windows.Forms.Button
  Friend WithEvents BtnEnreg As System.Windows.Forms.Button
  Friend WithEvents LabelTitre As System.Windows.Forms.Label
  Friend WithEvents GroupBox3 As System.Windows.Forms.GroupBox
  Friend WithEvents cboUtil As System.Windows.Forms.ComboBox
  Friend WithEvents MonthCalendar1 As System.Windows.Forms.MonthCalendar
  Friend WithEvents txtType As System.Windows.Forms.TextBox
  Friend WithEvents txtMarque As System.Windows.Forms.TextBox
  Friend WithEvents BtnDate1 As System.Windows.Forms.Button
  Friend WithEvents BtnSupp1 As System.Windows.Forms.Button
  Friend WithEvents txtDtEntree As System.Windows.Forms.TextBox
  Friend WithEvents txtImplantation As System.Windows.Forms.TextBox
  Friend WithEvents txtObs As System.Windows.Forms.TextBox
  Friend WithEvents Label7 As System.Windows.Forms.Label
  Friend WithEvents Label12 As System.Windows.Forms.Label
  Friend WithEvents txtMat As System.Windows.Forms.TextBox
  Friend WithEvents Label9 As System.Windows.Forms.Label
  Friend WithEvents Label8 As System.Windows.Forms.Label
  Friend WithEvents Label5 As System.Windows.Forms.Label
  Friend WithEvents Label4 As System.Windows.Forms.Label
  Friend WithEvents Label3 As System.Windows.Forms.Label
  Friend WithEvents TxtNum As System.Windows.Forms.TextBox
  Friend WithEvents Label1 As System.Windows.Forms.Label
  Friend WithEvents txtNumSerie As System.Windows.Forms.TextBox
  Friend WithEvents Label2 As System.Windows.Forms.Label
  Friend WithEvents BtnDate2 As System.Windows.Forms.Button
  Friend WithEvents BtmSupp2 As System.Windows.Forms.Button
  Friend WithEvents txtDtSortie As System.Windows.Forms.TextBox
  Friend WithEvents Label6 As System.Windows.Forms.Label
  Friend WithEvents cbEcoLabel As System.Windows.Forms.CheckBox
  Friend WithEvents CBPopUp As System.Windows.Forms.CheckBox
  Friend WithEvents txtAdrIP As System.Windows.Forms.TextBox
  Friend WithEvents Label10 As System.Windows.Forms.Label
  Friend WithEvents GroupBoxDetailsUC As System.Windows.Forms.GroupBox
    Friend WithEvents BtnAjout As System.Windows.Forms.Button
    Friend WithEvents GroupBoxGestionDetailsUC As System.Windows.Forms.GroupBox
    Friend WithEvents txtLicence As System.Windows.Forms.TextBox
    Friend WithEvents txtProgramme As System.Windows.Forms.TextBox
    Friend WithEvents Label11 As System.Windows.Forms.Label
    Friend WithEvents Label13 As System.Windows.Forms.Label
    Friend WithEvents BtnA As System.Windows.Forms.Button
    Friend WithEvents BtnV As System.Windows.Forms.Button
    Friend WithEvents BtnSuppr As System.Windows.Forms.Button
    Friend WithEvents BtnModifier As System.Windows.Forms.Button
    Friend WithEvents LabelNucNum As System.Windows.Forms.Label
    Private WithEvents GridControl1 As DevExpress.XtraGrid.GridControl
    Private WithEvents GridView1 As DevExpress.XtraGrid.Views.Grid.GridView
    Private WithEvents VUCPROGRAMME As DevExpress.XtraGrid.Columns.GridColumn
    Private WithEvents VUCLICENCE As DevExpress.XtraGrid.Columns.GridColumn
  Private WithEvents NUCNUM As DevExpress.XtraGrid.Columns.GridColumn
  Friend WithEvents CboSociete As System.Windows.Forms.ComboBox
  Friend WithEvents LblSociete As System.Windows.Forms.Label
    Friend WithEvents ChkAtt_retour As CheckBox
    Friend WithEvents TxtAnyDesk As TextBox
    Friend WithEvents Label14 As Label
    Friend WithEvents cboMateriel As MozartUC.apiCombo
    Friend WithEvents Label15 As Label
    Friend WithEvents TxtDateEnvoiMat As TextBox
    Friend WithEvents BtnDateEnvoiMat As Button
    Friend WithEvents BtnSuppDateEnvoiMat As Button
End Class
