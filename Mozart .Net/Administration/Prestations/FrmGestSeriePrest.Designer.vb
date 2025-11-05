<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class FrmGestSeriePrest
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
        Me.GroupBox2 = New System.Windows.Forms.GroupBox()
        Me.GroupBox1 = New System.Windows.Forms.GroupBox()
        Me.BtnSerieRestaure = New System.Windows.Forms.Button()
        Me.BtnSerieLstArchives = New System.Windows.Forms.Button()
        Me.BtnSerieArchiver = New System.Windows.Forms.Button()
        Me.BtnFermer = New System.Windows.Forms.Button()
        Me.BtnSerieAjouter = New System.Windows.Forms.Button()
        Me.GCListePrestaSerie = New DevExpress.XtraGrid.GridControl()
        Me.GVListePrestaSerie = New DevExpress.XtraGrid.Views.Grid.GridView()
        Me.GColNCFOCOD = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.GColVPRESTSER = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.GColLANGUE = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.GColPRIXMO = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.GCol_NPRESTSERCOEFNUIT = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.GroupBox3 = New System.Windows.Forms.GroupBox()
        Me.TxtEditCoefNuit = New DevExpress.XtraEditors.TextEdit()
        Me.Label6 = New System.Windows.Forms.Label()
        Me.Txt_NPRESTSERMOHT = New DevExpress.XtraEditors.TextEdit()
        Me.BtnSaveSerie = New System.Windows.Forms.Button()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.TxtSerieLibelle = New System.Windows.Forms.TextBox()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.GroupBox4 = New System.Windows.Forms.GroupBox()
        Me.GroupBox5 = New System.Windows.Forms.GroupBox()
        Me.BtnSousSerieRestaure = New System.Windows.Forms.Button()
        Me.BtnSousSerieLstArchives = New System.Windows.Forms.Button()
        Me.BtnSousSerieArchiver = New System.Windows.Forms.Button()
        Me.BtnSousFermer = New System.Windows.Forms.Button()
        Me.BtnSousSerieAjouter = New System.Windows.Forms.Button()
        Me.GCListePresta_SS_Serie = New DevExpress.XtraGrid.GridControl()
        Me.GVListePresta_SS_Serie = New DevExpress.XtraGrid.Views.Grid.GridView()
        Me.GridColumn2 = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.GridColumn3 = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.GroupBox6 = New System.Windows.Forms.GroupBox()
        Me.BtnSaveSousSerie = New System.Windows.Forms.Button()
        Me.TxtSousSerieLibelle = New System.Windows.Forms.TextBox()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.GroupBox2.SuspendLayout()
        Me.GroupBox1.SuspendLayout()
        CType(Me.GCListePrestaSerie, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.GVListePrestaSerie, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.GroupBox3.SuspendLayout()
        CType(Me.TxtEditCoefNuit.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.Txt_NPRESTSERMOHT.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.GroupBox4.SuspendLayout()
        Me.GroupBox5.SuspendLayout()
        CType(Me.GCListePresta_SS_Serie, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.GVListePresta_SS_Serie, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.GroupBox6.SuspendLayout()
        Me.SuspendLayout()
        '
        'GroupBox2
        '
        Me.GroupBox2.Controls.Add(Me.GroupBox1)
        Me.GroupBox2.Controls.Add(Me.GCListePrestaSerie)
        Me.GroupBox2.Controls.Add(Me.GroupBox3)
        Me.GroupBox2.Location = New System.Drawing.Point(23, 12)
        Me.GroupBox2.Name = "GroupBox2"
        Me.GroupBox2.Size = New System.Drawing.Size(586, 551)
        Me.GroupBox2.TabIndex = 52
        Me.GroupBox2.TabStop = False
        '
        'GroupBox1
        '
        Me.GroupBox1.Controls.Add(Me.BtnSerieRestaure)
        Me.GroupBox1.Controls.Add(Me.BtnSerieLstArchives)
        Me.GroupBox1.Controls.Add(Me.BtnSerieArchiver)
        Me.GroupBox1.Controls.Add(Me.BtnFermer)
        Me.GroupBox1.Controls.Add(Me.BtnSerieAjouter)
        Me.GroupBox1.Location = New System.Drawing.Point(6, 19)
        Me.GroupBox1.Name = "GroupBox1"
        Me.GroupBox1.Size = New System.Drawing.Size(87, 452)
        Me.GroupBox1.TabIndex = 53
        Me.GroupBox1.TabStop = False
        '
        'BtnSerieRestaure
        '
        Me.BtnSerieRestaure.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold)
        Me.BtnSerieRestaure.ImeMode = System.Windows.Forms.ImeMode.NoControl
        Me.BtnSerieRestaure.Location = New System.Drawing.Point(6, 267)
        Me.BtnSerieRestaure.Name = "BtnSerieRestaure"
        Me.BtnSerieRestaure.Size = New System.Drawing.Size(75, 31)
        Me.BtnSerieRestaure.TabIndex = 40
        Me.BtnSerieRestaure.Text = "Restaurer"
        Me.BtnSerieRestaure.UseVisualStyleBackColor = True
        Me.BtnSerieRestaure.Visible = False
        '
        'BtnSerieLstArchives
        '
        Me.BtnSerieLstArchives.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold)
        Me.BtnSerieLstArchives.ImeMode = System.Windows.Forms.ImeMode.NoControl
        Me.BtnSerieLstArchives.Location = New System.Drawing.Point(6, 224)
        Me.BtnSerieLstArchives.Name = "BtnSerieLstArchives"
        Me.BtnSerieLstArchives.Size = New System.Drawing.Size(75, 37)
        Me.BtnSerieLstArchives.TabIndex = 39
        Me.BtnSerieLstArchives.Text = "Liste archives"
        Me.BtnSerieLstArchives.UseVisualStyleBackColor = True
        '
        'BtnSerieArchiver
        '
        Me.BtnSerieArchiver.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold)
        Me.BtnSerieArchiver.ImeMode = System.Windows.Forms.ImeMode.NoControl
        Me.BtnSerieArchiver.Location = New System.Drawing.Point(6, 181)
        Me.BtnSerieArchiver.Name = "BtnSerieArchiver"
        Me.BtnSerieArchiver.Size = New System.Drawing.Size(75, 37)
        Me.BtnSerieArchiver.TabIndex = 38
        Me.BtnSerieArchiver.Text = "Archiver"
        Me.BtnSerieArchiver.UseVisualStyleBackColor = True
        '
        'BtnFermer
        '
        Me.BtnFermer.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold)
        Me.BtnFermer.ImeMode = System.Windows.Forms.ImeMode.NoControl
        Me.BtnFermer.Location = New System.Drawing.Point(4, 384)
        Me.BtnFermer.Name = "BtnFermer"
        Me.BtnFermer.Size = New System.Drawing.Size(75, 48)
        Me.BtnFermer.TabIndex = 1
        Me.BtnFermer.Text = "Fermer"
        Me.BtnFermer.UseVisualStyleBackColor = True
        '
        'BtnSerieAjouter
        '
        Me.BtnSerieAjouter.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold)
        Me.BtnSerieAjouter.ImeMode = System.Windows.Forms.ImeMode.NoControl
        Me.BtnSerieAjouter.Location = New System.Drawing.Point(5, 134)
        Me.BtnSerieAjouter.Name = "BtnSerieAjouter"
        Me.BtnSerieAjouter.Size = New System.Drawing.Size(74, 41)
        Me.BtnSerieAjouter.TabIndex = 0
        Me.BtnSerieAjouter.Text = "Ajouter"
        Me.BtnSerieAjouter.UseVisualStyleBackColor = True
        '
        'GCListePrestaSerie
        '
        Me.GCListePrestaSerie.Location = New System.Drawing.Point(99, 153)
        Me.GCListePrestaSerie.MainView = Me.GVListePrestaSerie
        Me.GCListePrestaSerie.Name = "GCListePrestaSerie"
        Me.GCListePrestaSerie.Size = New System.Drawing.Size(466, 381)
        Me.GCListePrestaSerie.TabIndex = 52
        Me.GCListePrestaSerie.ViewCollection.AddRange(New DevExpress.XtraGrid.Views.Base.BaseView() {Me.GVListePrestaSerie})
        '
        'GVListePrestaSerie
        '
        Me.GVListePrestaSerie.Appearance.HeaderPanel.Font = New System.Drawing.Font("Tahoma", 8.25!, System.Drawing.FontStyle.Bold)
        Me.GVListePrestaSerie.Appearance.HeaderPanel.Options.UseFont = True
        Me.GVListePrestaSerie.Appearance.HeaderPanel.Options.UseTextOptions = True
        Me.GVListePrestaSerie.Appearance.HeaderPanel.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center
        Me.GVListePrestaSerie.Appearance.HeaderPanel.TextOptions.VAlignment = DevExpress.Utils.VertAlignment.Center
        Me.GVListePrestaSerie.Appearance.HeaderPanel.TextOptions.WordWrap = DevExpress.Utils.WordWrap.Wrap
        Me.GVListePrestaSerie.Columns.AddRange(New DevExpress.XtraGrid.Columns.GridColumn() {Me.GColNCFOCOD, Me.GColVPRESTSER, Me.GColLANGUE, Me.GColPRIXMO, Me.GCol_NPRESTSERCOEFNUIT})
        Me.GVListePrestaSerie.GridControl = Me.GCListePrestaSerie
        Me.GVListePrestaSerie.Name = "GVListePrestaSerie"
        Me.GVListePrestaSerie.OptionsBehavior.Editable = False
        Me.GVListePrestaSerie.OptionsBehavior.ReadOnly = True
        Me.GVListePrestaSerie.OptionsView.ShowAutoFilterRow = True
        Me.GVListePrestaSerie.OptionsView.ShowFooter = True
        Me.GVListePrestaSerie.OptionsView.ShowGroupPanel = False
        '
        'GColNCFOCOD
        '
        Me.GColNCFOCOD.Name = "GColNCFOCOD"
        '
        'GColVPRESTSER
        '
        Me.GColVPRESTSER.AppearanceHeader.ForeColor = System.Drawing.Color.Black
        Me.GColVPRESTSER.AppearanceHeader.Options.UseForeColor = True
        Me.GColVPRESTSER.Caption = "Libellé"
        Me.GColVPRESTSER.FieldName = "VPRESTSER"
        Me.GColVPRESTSER.Name = "GColVPRESTSER"
        Me.GColVPRESTSER.OptionsColumn.AllowEdit = False
        Me.GColVPRESTSER.OptionsColumn.ReadOnly = True
        Me.GColVPRESTSER.OptionsFilter.AutoFilterCondition = DevExpress.XtraGrid.Columns.AutoFilterCondition.Contains
        Me.GColVPRESTSER.Visible = True
        Me.GColVPRESTSER.VisibleIndex = 0
        Me.GColVPRESTSER.Width = 256
        '
        'GColLANGUE
        '
        Me.GColLANGUE.FieldName = "LANGUE"
        Me.GColLANGUE.Name = "GColLANGUE"
        '
        'GColPRIXMO
        '
        Me.GColPRIXMO.AppearanceCell.Options.UseTextOptions = True
        Me.GColPRIXMO.AppearanceCell.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center
        Me.GColPRIXMO.AppearanceCell.TextOptions.VAlignment = DevExpress.Utils.VertAlignment.Center
        Me.GColPRIXMO.AppearanceHeader.ForeColor = System.Drawing.Color.Black
        Me.GColPRIXMO.AppearanceHeader.Options.UseForeColor = True
        Me.GColPRIXMO.Caption = "Montant MO"
        Me.GColPRIXMO.DisplayFormat.FormatString = "C2"
        Me.GColPRIXMO.DisplayFormat.FormatType = DevExpress.Utils.FormatType.Custom
        Me.GColPRIXMO.FieldName = "NPRESTSERMOHT"
        Me.GColPRIXMO.Name = "GColPRIXMO"
        Me.GColPRIXMO.Visible = True
        Me.GColPRIXMO.VisibleIndex = 1
        Me.GColPRIXMO.Width = 126
        '
        'GCol_NPRESTSERCOEFNUIT
        '
        Me.GCol_NPRESTSERCOEFNUIT.AppearanceCell.Options.UseTextOptions = True
        Me.GCol_NPRESTSERCOEFNUIT.AppearanceCell.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center
        Me.GCol_NPRESTSERCOEFNUIT.AppearanceCell.TextOptions.VAlignment = DevExpress.Utils.VertAlignment.Center
        Me.GCol_NPRESTSERCOEFNUIT.AppearanceCell.TextOptions.WordWrap = DevExpress.Utils.WordWrap.Wrap
        Me.GCol_NPRESTSERCOEFNUIT.AppearanceHeader.ForeColor = System.Drawing.Color.Black
        Me.GCol_NPRESTSERCOEFNUIT.AppearanceHeader.Options.UseForeColor = True
        Me.GCol_NPRESTSERCOEFNUIT.Caption = "Coef de nuit"
        Me.GCol_NPRESTSERCOEFNUIT.DisplayFormat.FormatString = "n2"
        Me.GCol_NPRESTSERCOEFNUIT.DisplayFormat.FormatType = DevExpress.Utils.FormatType.Numeric
        Me.GCol_NPRESTSERCOEFNUIT.FieldName = "NPRESTSERCOEFNUIT"
        Me.GCol_NPRESTSERCOEFNUIT.Name = "GCol_NPRESTSERCOEFNUIT"
        Me.GCol_NPRESTSERCOEFNUIT.Visible = True
        Me.GCol_NPRESTSERCOEFNUIT.VisibleIndex = 2
        Me.GCol_NPRESTSERCOEFNUIT.Width = 120
        '
        'GroupBox3
        '
        Me.GroupBox3.Controls.Add(Me.TxtEditCoefNuit)
        Me.GroupBox3.Controls.Add(Me.Label6)
        Me.GroupBox3.Controls.Add(Me.Txt_NPRESTSERMOHT)
        Me.GroupBox3.Controls.Add(Me.BtnSaveSerie)
        Me.GroupBox3.Controls.Add(Me.Label4)
        Me.GroupBox3.Controls.Add(Me.Label3)
        Me.GroupBox3.Controls.Add(Me.TxtSerieLibelle)
        Me.GroupBox3.Controls.Add(Me.Label1)
        Me.GroupBox3.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.GroupBox3.ForeColor = System.Drawing.Color.Firebrick
        Me.GroupBox3.Location = New System.Drawing.Point(99, 19)
        Me.GroupBox3.Name = "GroupBox3"
        Me.GroupBox3.Size = New System.Drawing.Size(466, 128)
        Me.GroupBox3.TabIndex = 0
        Me.GroupBox3.TabStop = False
        Me.GroupBox3.Text = "Détail modification série"
        '
        'TxtEditCoefNuit
        '
        Me.TxtEditCoefNuit.Location = New System.Drawing.Point(183, 98)
        Me.TxtEditCoefNuit.Name = "TxtEditCoefNuit"
        Me.TxtEditCoefNuit.Properties.DisplayFormat.FormatString = "n2"
        Me.TxtEditCoefNuit.Properties.DisplayFormat.FormatType = DevExpress.Utils.FormatType.Numeric
        Me.TxtEditCoefNuit.Properties.Mask.EditMask = "n2"
        Me.TxtEditCoefNuit.Properties.Mask.MaskType = DevExpress.XtraEditors.Mask.MaskType.Numeric
        Me.TxtEditCoefNuit.Properties.Mask.UseMaskAsDisplayFormat = True
        Me.TxtEditCoefNuit.Size = New System.Drawing.Size(103, 20)
        Me.TxtEditCoefNuit.TabIndex = 9
        '
        'Label6
        '
        Me.Label6.AutoSize = True
        Me.Label6.ForeColor = System.Drawing.Color.Black
        Me.Label6.Location = New System.Drawing.Point(26, 102)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(76, 13)
        Me.Label6.TabIndex = 7
        Me.Label6.Text = "Coef de nuit"
        '
        'Txt_NPRESTSERMOHT
        '
        Me.Txt_NPRESTSERMOHT.Location = New System.Drawing.Point(183, 72)
        Me.Txt_NPRESTSERMOHT.Name = "Txt_NPRESTSERMOHT"
        Me.Txt_NPRESTSERMOHT.Properties.Mask.EditMask = "n2"
        Me.Txt_NPRESTSERMOHT.Properties.Mask.MaskType = DevExpress.XtraEditors.Mask.MaskType.Numeric
        Me.Txt_NPRESTSERMOHT.Properties.Mask.UseMaskAsDisplayFormat = True
        Me.Txt_NPRESTSERMOHT.Size = New System.Drawing.Size(103, 20)
        Me.Txt_NPRESTSERMOHT.TabIndex = 6
        '
        'BtnSaveSerie
        '
        Me.BtnSaveSerie.ForeColor = System.Drawing.Color.Black
        Me.BtnSaveSerie.Location = New System.Drawing.Point(364, 92)
        Me.BtnSaveSerie.Name = "BtnSaveSerie"
        Me.BtnSaveSerie.Size = New System.Drawing.Size(75, 23)
        Me.BtnSaveSerie.TabIndex = 5
        Me.BtnSaveSerie.Text = "Valider"
        Me.BtnSaveSerie.UseVisualStyleBackColor = True
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.ForeColor = System.Drawing.Color.Black
        Me.Label4.Location = New System.Drawing.Point(292, 75)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(14, 13)
        Me.Label4.TabIndex = 4
        Me.Label4.Text = "€"
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.ForeColor = System.Drawing.Color.Black
        Me.Label3.Location = New System.Drawing.Point(26, 76)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(136, 13)
        Me.Label3.TabIndex = 2
        Me.Label3.Text = "Montant main d'oeuvre"
        '
        'TxtSerieLibelle
        '
        Me.TxtSerieLibelle.Location = New System.Drawing.Point(97, 31)
        Me.TxtSerieLibelle.Name = "TxtSerieLibelle"
        Me.TxtSerieLibelle.Size = New System.Drawing.Size(342, 20)
        Me.TxtSerieLibelle.TabIndex = 1
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.ForeColor = System.Drawing.Color.Black
        Me.Label1.Location = New System.Drawing.Point(26, 34)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(44, 13)
        Me.Label1.TabIndex = 0
        Me.Label1.Text = "Libellé"
        '
        'GroupBox4
        '
        Me.GroupBox4.Controls.Add(Me.GroupBox5)
        Me.GroupBox4.Controls.Add(Me.GCListePresta_SS_Serie)
        Me.GroupBox4.Controls.Add(Me.GroupBox6)
        Me.GroupBox4.Location = New System.Drawing.Point(627, 12)
        Me.GroupBox4.Name = "GroupBox4"
        Me.GroupBox4.Size = New System.Drawing.Size(586, 551)
        Me.GroupBox4.TabIndex = 53
        Me.GroupBox4.TabStop = False
        '
        'GroupBox5
        '
        Me.GroupBox5.Controls.Add(Me.BtnSousSerieRestaure)
        Me.GroupBox5.Controls.Add(Me.BtnSousSerieLstArchives)
        Me.GroupBox5.Controls.Add(Me.BtnSousSerieArchiver)
        Me.GroupBox5.Controls.Add(Me.BtnSousFermer)
        Me.GroupBox5.Controls.Add(Me.BtnSousSerieAjouter)
        Me.GroupBox5.Location = New System.Drawing.Point(21, 19)
        Me.GroupBox5.Name = "GroupBox5"
        Me.GroupBox5.Size = New System.Drawing.Size(87, 452)
        Me.GroupBox5.TabIndex = 53
        Me.GroupBox5.TabStop = False
        '
        'BtnSousSerieRestaure
        '
        Me.BtnSousSerieRestaure.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold)
        Me.BtnSousSerieRestaure.ImeMode = System.Windows.Forms.ImeMode.NoControl
        Me.BtnSousSerieRestaure.Location = New System.Drawing.Point(5, 267)
        Me.BtnSousSerieRestaure.Name = "BtnSousSerieRestaure"
        Me.BtnSousSerieRestaure.Size = New System.Drawing.Size(75, 31)
        Me.BtnSousSerieRestaure.TabIndex = 40
        Me.BtnSousSerieRestaure.Text = "Restaurer"
        Me.BtnSousSerieRestaure.UseVisualStyleBackColor = True
        Me.BtnSousSerieRestaure.Visible = False
        '
        'BtnSousSerieLstArchives
        '
        Me.BtnSousSerieLstArchives.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold)
        Me.BtnSousSerieLstArchives.ImeMode = System.Windows.Forms.ImeMode.NoControl
        Me.BtnSousSerieLstArchives.Location = New System.Drawing.Point(5, 224)
        Me.BtnSousSerieLstArchives.Name = "BtnSousSerieLstArchives"
        Me.BtnSousSerieLstArchives.Size = New System.Drawing.Size(75, 37)
        Me.BtnSousSerieLstArchives.TabIndex = 39
        Me.BtnSousSerieLstArchives.Text = "Liste archives"
        Me.BtnSousSerieLstArchives.UseVisualStyleBackColor = True
        '
        'BtnSousSerieArchiver
        '
        Me.BtnSousSerieArchiver.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold)
        Me.BtnSousSerieArchiver.ImeMode = System.Windows.Forms.ImeMode.NoControl
        Me.BtnSousSerieArchiver.Location = New System.Drawing.Point(6, 181)
        Me.BtnSousSerieArchiver.Name = "BtnSousSerieArchiver"
        Me.BtnSousSerieArchiver.Size = New System.Drawing.Size(75, 37)
        Me.BtnSousSerieArchiver.TabIndex = 38
        Me.BtnSousSerieArchiver.Text = "Archiver"
        Me.BtnSousSerieArchiver.UseVisualStyleBackColor = True
        '
        'BtnSousFermer
        '
        Me.BtnSousFermer.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold)
        Me.BtnSousFermer.ImeMode = System.Windows.Forms.ImeMode.NoControl
        Me.BtnSousFermer.Location = New System.Drawing.Point(4, 384)
        Me.BtnSousFermer.Name = "BtnSousFermer"
        Me.BtnSousFermer.Size = New System.Drawing.Size(75, 48)
        Me.BtnSousFermer.TabIndex = 1
        Me.BtnSousFermer.Text = "Fermer"
        Me.BtnSousFermer.UseVisualStyleBackColor = True
        '
        'BtnSousSerieAjouter
        '
        Me.BtnSousSerieAjouter.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold)
        Me.BtnSousSerieAjouter.ImeMode = System.Windows.Forms.ImeMode.NoControl
        Me.BtnSousSerieAjouter.Location = New System.Drawing.Point(6, 134)
        Me.BtnSousSerieAjouter.Name = "BtnSousSerieAjouter"
        Me.BtnSousSerieAjouter.Size = New System.Drawing.Size(74, 41)
        Me.BtnSousSerieAjouter.TabIndex = 0
        Me.BtnSousSerieAjouter.Text = "Ajouter"
        Me.BtnSousSerieAjouter.UseVisualStyleBackColor = True
        '
        'GCListePresta_SS_Serie
        '
        Me.GCListePresta_SS_Serie.Location = New System.Drawing.Point(114, 153)
        Me.GCListePresta_SS_Serie.MainView = Me.GVListePresta_SS_Serie
        Me.GCListePresta_SS_Serie.Name = "GCListePresta_SS_Serie"
        Me.GCListePresta_SS_Serie.Size = New System.Drawing.Size(443, 304)
        Me.GCListePresta_SS_Serie.TabIndex = 52
        Me.GCListePresta_SS_Serie.ViewCollection.AddRange(New DevExpress.XtraGrid.Views.Base.BaseView() {Me.GVListePresta_SS_Serie})
        '
        'GVListePresta_SS_Serie
        '
        Me.GVListePresta_SS_Serie.Appearance.HeaderPanel.Font = New System.Drawing.Font("Tahoma", 8.25!, System.Drawing.FontStyle.Bold)
        Me.GVListePresta_SS_Serie.Appearance.HeaderPanel.Options.UseFont = True
        Me.GVListePresta_SS_Serie.Appearance.HeaderPanel.Options.UseTextOptions = True
        Me.GVListePresta_SS_Serie.Appearance.HeaderPanel.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center
        Me.GVListePresta_SS_Serie.Appearance.HeaderPanel.TextOptions.VAlignment = DevExpress.Utils.VertAlignment.Center
        Me.GVListePresta_SS_Serie.Appearance.HeaderPanel.TextOptions.WordWrap = DevExpress.Utils.WordWrap.Wrap
        Me.GVListePresta_SS_Serie.Columns.AddRange(New DevExpress.XtraGrid.Columns.GridColumn() {Me.GridColumn2, Me.GridColumn3})
        Me.GVListePresta_SS_Serie.GridControl = Me.GCListePresta_SS_Serie
        Me.GVListePresta_SS_Serie.Name = "GVListePresta_SS_Serie"
        Me.GVListePresta_SS_Serie.OptionsView.ShowAutoFilterRow = True
        Me.GVListePresta_SS_Serie.OptionsView.ShowGroupPanel = False
        '
        'GridColumn2
        '
        Me.GridColumn2.FieldName = "NPREST_SS_SERIE_ID"
        Me.GridColumn2.Name = "GridColumn2"
        '
        'GridColumn3
        '
        Me.GridColumn3.AppearanceHeader.ForeColor = System.Drawing.Color.Black
        Me.GridColumn3.AppearanceHeader.Options.UseForeColor = True
        Me.GridColumn3.Caption = "Série"
        Me.GridColumn3.FieldName = "VPREST_SS_SERIE_LIB"
        Me.GridColumn3.Name = "GridColumn3"
        Me.GridColumn3.OptionsColumn.AllowEdit = False
        Me.GridColumn3.OptionsColumn.ReadOnly = True
        Me.GridColumn3.OptionsFilter.AutoFilterCondition = DevExpress.XtraGrid.Columns.AutoFilterCondition.Contains
        Me.GridColumn3.Visible = True
        Me.GridColumn3.VisibleIndex = 0
        '
        'GroupBox6
        '
        Me.GroupBox6.Controls.Add(Me.BtnSaveSousSerie)
        Me.GroupBox6.Controls.Add(Me.TxtSousSerieLibelle)
        Me.GroupBox6.Controls.Add(Me.Label2)
        Me.GroupBox6.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.GroupBox6.ForeColor = System.Drawing.Color.Firebrick
        Me.GroupBox6.Location = New System.Drawing.Point(114, 19)
        Me.GroupBox6.Name = "GroupBox6"
        Me.GroupBox6.Size = New System.Drawing.Size(443, 112)
        Me.GroupBox6.TabIndex = 0
        Me.GroupBox6.TabStop = False
        Me.GroupBox6.Text = "Détail modification sous-série"
        '
        'BtnSaveSousSerie
        '
        Me.BtnSaveSousSerie.ForeColor = System.Drawing.Color.Black
        Me.BtnSaveSousSerie.Location = New System.Drawing.Point(353, 64)
        Me.BtnSaveSousSerie.Name = "BtnSaveSousSerie"
        Me.BtnSaveSousSerie.Size = New System.Drawing.Size(75, 23)
        Me.BtnSaveSousSerie.TabIndex = 8
        Me.BtnSaveSousSerie.Text = "Valider"
        Me.BtnSaveSousSerie.UseVisualStyleBackColor = True
        '
        'TxtSousSerieLibelle
        '
        Me.TxtSousSerieLibelle.Location = New System.Drawing.Point(86, 26)
        Me.TxtSousSerieLibelle.Name = "TxtSousSerieLibelle"
        Me.TxtSousSerieLibelle.Size = New System.Drawing.Size(342, 20)
        Me.TxtSousSerieLibelle.TabIndex = 7
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.ForeColor = System.Drawing.Color.Black
        Me.Label2.Location = New System.Drawing.Point(15, 29)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(44, 13)
        Me.Label2.TabIndex = 6
        Me.Label2.Text = "Libellé"
        '
        'FrmGestSeriePrest
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.Wheat
        Me.ClientSize = New System.Drawing.Size(1576, 908)
        Me.Controls.Add(Me.GroupBox4)
        Me.Controls.Add(Me.GroupBox2)
        Me.Name = "FrmGestSeriePrest"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent
        Me.Text = "Gestion des séries et sous séries de prestation"
        Me.GroupBox2.ResumeLayout(False)
        Me.GroupBox1.ResumeLayout(False)
        CType(Me.GCListePrestaSerie, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.GVListePrestaSerie, System.ComponentModel.ISupportInitialize).EndInit()
        Me.GroupBox3.ResumeLayout(False)
        Me.GroupBox3.PerformLayout()
        CType(Me.TxtEditCoefNuit.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.Txt_NPRESTSERMOHT.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        Me.GroupBox4.ResumeLayout(False)
        Me.GroupBox5.ResumeLayout(False)
        CType(Me.GCListePresta_SS_Serie, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.GVListePresta_SS_Serie, System.ComponentModel.ISupportInitialize).EndInit()
        Me.GroupBox6.ResumeLayout(False)
        Me.GroupBox6.PerformLayout()
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents GroupBox2 As GroupBox
    Friend WithEvents GroupBox3 As GroupBox
    Friend WithEvents GroupBox1 As GroupBox
    Friend WithEvents BtnSerieRestaure As Button
    Friend WithEvents BtnSerieLstArchives As Button
    Friend WithEvents BtnSerieArchiver As Button
    Friend WithEvents BtnSerieAjouter As Button
    Friend WithEvents GCListePrestaSerie As DevExpress.XtraGrid.GridControl
    Friend WithEvents GVListePrestaSerie As DevExpress.XtraGrid.Views.Grid.GridView
    Friend WithEvents GColNCFOCOD As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents GColVPRESTSER As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents GColLANGUE As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents GColPRIXMO As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents GroupBox4 As GroupBox
    Friend WithEvents GroupBox5 As GroupBox
    Friend WithEvents BtnSousSerieRestaure As Button
    Friend WithEvents BtnSousSerieLstArchives As Button
    Friend WithEvents BtnSousSerieArchiver As Button
    Friend WithEvents BtnSousSerieAjouter As Button
    Friend WithEvents GCListePresta_SS_Serie As DevExpress.XtraGrid.GridControl
    Friend WithEvents GVListePresta_SS_Serie As DevExpress.XtraGrid.Views.Grid.GridView
    Friend WithEvents GridColumn2 As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents GridColumn3 As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents GroupBox6 As GroupBox
    Friend WithEvents Label1 As Label
    Friend WithEvents TxtSerieLibelle As TextBox
    Friend WithEvents Label3 As Label
    Friend WithEvents Label4 As Label
    Friend WithEvents BtnSaveSerie As Button
    Friend WithEvents BtnFermer As Button
    Friend WithEvents BtnSousFermer As Button
    Private WithEvents Txt_NPRESTSERMOHT As DevExpress.XtraEditors.TextEdit
    Friend WithEvents BtnSaveSousSerie As Button
    Friend WithEvents TxtSousSerieLibelle As TextBox
    Friend WithEvents Label2 As Label
    Friend WithEvents GCol_NPRESTSERCOEFNUIT As DevExpress.XtraGrid.Columns.GridColumn
    Private WithEvents TxtEditCoefNuit As DevExpress.XtraEditors.TextEdit
    Friend WithEvents Label6 As Label
End Class
