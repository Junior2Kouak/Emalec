<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class frmCertFluidBottle
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
        Me.BtnSupprimerCom = New System.Windows.Forms.Button()
        Me.GridLookUpEdit_CF = New DevExpress.XtraEditors.GridLookUpEdit()
        Me.GridView1 = New DevExpress.XtraGrid.Views.Grid.GridView()
        Me.GridColumn10 = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.GridColumn9 = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.GridColumn1 = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.GridColumn2 = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.GridColumn3 = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.GridColumn4 = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.GridColumn5 = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.GridColumn6 = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.GridColumn7 = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.GridColumn8 = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.Label6 = New System.Windows.Forms.Label()
        Me.PBC_Bottle_Util = New DevExpress.XtraEditors.ProgressBarControl()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.TxtBottle_Qte_Free = New DevExpress.XtraEditors.TextEdit()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.BtnDelDateResti = New System.Windows.Forms.Button()
        Me.BtnAddDateResti = New System.Windows.Forms.Button()
        Me.CalendarDateResti = New System.Windows.Forms.MonthCalendar()
        Me.GLUpBottleTech = New DevExpress.XtraEditors.GridLookUpEdit()
        Me.GV_Cbo_Tech = New DevExpress.XtraGrid.Views.Grid.GridView()
        Me.Col_Cbo_NPERNUM = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.Col_Cbo_VTECHNOM = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.GLUpBottleFluide = New DevExpress.XtraEditors.GridLookUpEdit()
        Me.GVBottleTechs = New DevExpress.XtraGrid.Views.Grid.GridView()
        Me.GCol_NTYPEFLUIDE = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.GCol_VTYPEFLUIDELIB = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.GLUpBottleContenance = New DevExpress.XtraEditors.GridLookUpEdit()
        Me.GVBottleContenant = New DevExpress.XtraGrid.Views.Grid.GridView()
        Me.Col_Cbo_NBOTTLE_CONTENANT = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.Col_Cbo_VBOTTLE_CONTENANT = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.GLUpBottleType = New DevExpress.XtraEditors.GridLookUpEdit()
        Me.GVCboBottleType = New DevExpress.XtraGrid.Views.Grid.GridView()
        Me.Col_Cbo_NBOTTLETYPE = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.Col_Cbo_VBOTTLETYPE = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.LblSociete = New System.Windows.Forms.Label()
        Me.ChkActif = New System.Windows.Forms.CheckBox()
        Me.txtDtResti = New System.Windows.Forms.TextBox()
        Me.txtObs = New System.Windows.Forms.TextBox()
        Me.Label7 = New System.Windows.Forms.Label()
        Me.Label12 = New System.Windows.Forms.Label()
        Me.txt_VREFBOTTLE = New System.Windows.Forms.TextBox()
        Me.Label9 = New System.Windows.Forms.Label()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.GroupBox1 = New System.Windows.Forms.GroupBox()
        Me.BtnFermer = New System.Windows.Forms.Button()
        Me.BtnEnreg = New System.Windows.Forms.Button()
        Me.LabelTitre = New System.Windows.Forms.Label()
        Me.GroupBox3.SuspendLayout()
        CType(Me.GridLookUpEdit_CF.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.GridView1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.PBC_Bottle_Util.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.TxtBottle_Qte_Free.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.GLUpBottleTech.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.GV_Cbo_Tech, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.GLUpBottleFluide.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.GVBottleTechs, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.GLUpBottleContenance.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.GVBottleContenant, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.GLUpBottleType.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.GVCboBottleType, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.GroupBox1.SuspendLayout()
        Me.SuspendLayout()
        '
        'GroupBox3
        '
        Me.GroupBox3.Controls.Add(Me.BtnSupprimerCom)
        Me.GroupBox3.Controls.Add(Me.GridLookUpEdit_CF)
        Me.GroupBox3.Controls.Add(Me.Label6)
        Me.GroupBox3.Controls.Add(Me.PBC_Bottle_Util)
        Me.GroupBox3.Controls.Add(Me.Label5)
        Me.GroupBox3.Controls.Add(Me.TxtBottle_Qte_Free)
        Me.GroupBox3.Controls.Add(Me.Label4)
        Me.GroupBox3.Controls.Add(Me.BtnDelDateResti)
        Me.GroupBox3.Controls.Add(Me.BtnAddDateResti)
        Me.GroupBox3.Controls.Add(Me.CalendarDateResti)
        Me.GroupBox3.Controls.Add(Me.GLUpBottleTech)
        Me.GroupBox3.Controls.Add(Me.GLUpBottleFluide)
        Me.GroupBox3.Controls.Add(Me.GLUpBottleContenance)
        Me.GroupBox3.Controls.Add(Me.GLUpBottleType)
        Me.GroupBox3.Controls.Add(Me.Label3)
        Me.GroupBox3.Controls.Add(Me.Label2)
        Me.GroupBox3.Controls.Add(Me.LblSociete)
        Me.GroupBox3.Controls.Add(Me.ChkActif)
        Me.GroupBox3.Controls.Add(Me.txtDtResti)
        Me.GroupBox3.Controls.Add(Me.txtObs)
        Me.GroupBox3.Controls.Add(Me.Label7)
        Me.GroupBox3.Controls.Add(Me.Label12)
        Me.GroupBox3.Controls.Add(Me.txt_VREFBOTTLE)
        Me.GroupBox3.Controls.Add(Me.Label9)
        Me.GroupBox3.Controls.Add(Me.Label1)
        Me.GroupBox3.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold)
        Me.GroupBox3.ForeColor = System.Drawing.Color.Red
        Me.GroupBox3.Location = New System.Drawing.Point(110, 54)
        Me.GroupBox3.Name = "GroupBox3"
        Me.GroupBox3.Size = New System.Drawing.Size(809, 670)
        Me.GroupBox3.TabIndex = 50
        Me.GroupBox3.TabStop = False
        Me.GroupBox3.Text = "Détails"
        '
        'BtnSupprimerCom
        '
        Me.BtnSupprimerCom.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold)
        Me.BtnSupprimerCom.ImeMode = System.Windows.Forms.ImeMode.NoControl
        Me.BtnSupprimerCom.Location = New System.Drawing.Point(515, 232)
        Me.BtnSupprimerCom.Name = "BtnSupprimerCom"
        Me.BtnSupprimerCom.Size = New System.Drawing.Size(29, 25)
        Me.BtnSupprimerCom.TabIndex = 85
        Me.BtnSupprimerCom.Text = "X"
        Me.BtnSupprimerCom.UseVisualStyleBackColor = True
        '
        'GridLookUpEdit_CF
        '
        Me.GridLookUpEdit_CF.EditValue = ""
        Me.GridLookUpEdit_CF.Location = New System.Drawing.Point(181, 235)
        Me.GridLookUpEdit_CF.Name = "GridLookUpEdit_CF"
        Me.GridLookUpEdit_CF.Properties.Buttons.AddRange(New DevExpress.XtraEditors.Controls.EditorButton() {New DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)})
        Me.GridLookUpEdit_CF.Properties.DisplayMember = "NCOMNUM"
        Me.GridLookUpEdit_CF.Properties.NullText = ""
        Me.GridLookUpEdit_CF.Properties.PopupFormSize = New System.Drawing.Size(640, 320)
        Me.GridLookUpEdit_CF.Properties.PopupView = Me.GridView1
        Me.GridLookUpEdit_CF.Properties.PopupWidthMode = DevExpress.XtraEditors.PopupWidthMode.UseEditorWidth
        Me.GridLookUpEdit_CF.Properties.ValueMember = "NCOMNUM"
        Me.GridLookUpEdit_CF.Size = New System.Drawing.Size(328, 20)
        Me.GridLookUpEdit_CF.TabIndex = 81
        '
        'GridView1
        '
        Me.GridView1.Columns.AddRange(New DevExpress.XtraGrid.Columns.GridColumn() {Me.GridColumn10, Me.GridColumn9, Me.GridColumn1, Me.GridColumn2, Me.GridColumn3, Me.GridColumn4, Me.GridColumn5, Me.GridColumn6, Me.GridColumn7, Me.GridColumn8})
        Me.GridView1.FocusRectStyle = DevExpress.XtraGrid.Views.Grid.DrawFocusRectStyle.RowFocus
        Me.GridView1.Name = "GridView1"
        Me.GridView1.OptionsSelection.EnableAppearanceFocusedCell = False
        Me.GridView1.OptionsView.ShowAutoFilterRow = True
        Me.GridView1.OptionsView.ShowGroupPanel = False
        '
        'GridColumn10
        '
        Me.GridColumn10.Caption = "Client"
        Me.GridColumn10.FieldName = "VCLINOM"
        Me.GridColumn10.Name = "GridColumn10"
        Me.GridColumn10.Visible = True
        Me.GridColumn10.VisibleIndex = 0
        '
        'GridColumn9
        '
        Me.GridColumn9.Caption = "Site"
        Me.GridColumn9.FieldName = "VSITNOM"
        Me.GridColumn9.Name = "GridColumn9"
        Me.GridColumn9.Visible = True
        Me.GridColumn9.VisibleIndex = 1
        '
        'GridColumn1
        '
        Me.GridColumn1.AppearanceHeader.Options.UseTextOptions = True
        Me.GridColumn1.AppearanceHeader.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center
        Me.GridColumn1.AppearanceHeader.TextOptions.VAlignment = DevExpress.Utils.VertAlignment.Center
        Me.GridColumn1.Caption = "N° Commande"
        Me.GridColumn1.FieldName = "NCOMNUM"
        Me.GridColumn1.Name = "GridColumn1"
        Me.GridColumn1.OptionsColumn.AllowEdit = False
        Me.GridColumn1.OptionsColumn.ReadOnly = True
        Me.GridColumn1.Visible = True
        Me.GridColumn1.VisibleIndex = 2
        '
        'GridColumn2
        '
        Me.GridColumn2.AppearanceHeader.Font = New System.Drawing.Font("Tahoma", 8.25!, System.Drawing.FontStyle.Bold)
        Me.GridColumn2.AppearanceHeader.Options.UseFont = True
        Me.GridColumn2.AppearanceHeader.Options.UseTextOptions = True
        Me.GridColumn2.AppearanceHeader.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center
        Me.GridColumn2.AppearanceHeader.TextOptions.VAlignment = DevExpress.Utils.VertAlignment.Center
        Me.GridColumn2.Caption = "Date Commande"
        Me.GridColumn2.FieldName = "DCOMDAT"
        Me.GridColumn2.Name = "GridColumn2"
        Me.GridColumn2.OptionsFilter.AutoFilterCondition = DevExpress.XtraGrid.Columns.AutoFilterCondition.Contains
        Me.GridColumn2.Visible = True
        Me.GridColumn2.VisibleIndex = 3
        '
        'GridColumn3
        '
        Me.GridColumn3.Caption = "Date livraison"
        Me.GridColumn3.FieldName = "DCOMDLI"
        Me.GridColumn3.Name = "GridColumn3"
        Me.GridColumn3.Visible = True
        Me.GridColumn3.VisibleIndex = 4
        '
        'GridColumn4
        '
        Me.GridColumn4.Caption = "Article"
        Me.GridColumn4.FieldName = "VFOUMAT"
        Me.GridColumn4.Name = "GridColumn4"
        Me.GridColumn4.Visible = True
        Me.GridColumn4.VisibleIndex = 5
        '
        'GridColumn5
        '
        Me.GridColumn5.Caption = "Quantité"
        Me.GridColumn5.FieldName = "NLCOQTE"
        Me.GridColumn5.Name = "GridColumn5"
        Me.GridColumn5.Visible = True
        Me.GridColumn5.VisibleIndex = 6
        '
        'GridColumn6
        '
        Me.GridColumn6.Caption = "Nb bouteilles"
        Me.GridColumn6.FieldName = "QTE_BY_BOTTLE"
        Me.GridColumn6.Name = "GridColumn6"
        Me.GridColumn6.Visible = True
        Me.GridColumn6.VisibleIndex = 7
        '
        'GridColumn7
        '
        Me.GridColumn7.Caption = "GridColumn7"
        Me.GridColumn7.FieldName = "NFOUNBLOT"
        Me.GridColumn7.Name = "GridColumn7"
        '
        'GridColumn8
        '
        Me.GridColumn8.Caption = "GridColumn8"
        Me.GridColumn8.FieldName = "NFOUNUM"
        Me.GridColumn8.Name = "GridColumn8"
        '
        'Label6
        '
        Me.Label6.AutoSize = True
        Me.Label6.ForeColor = System.Drawing.Color.Black
        Me.Label6.ImeMode = System.Windows.Forms.ImeMode.NoControl
        Me.Label6.Location = New System.Drawing.Point(15, 238)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(94, 13)
        Me.Label6.TabIndex = 80
        Me.Label6.Text = "N° Commande :"
        '
        'PBC_Bottle_Util
        '
        Me.PBC_Bottle_Util.Location = New System.Drawing.Point(181, 116)
        Me.PBC_Bottle_Util.Name = "PBC_Bottle_Util"
        Me.PBC_Bottle_Util.Properties.DisplayFormat.FormatString = "{0:n0} L"
        Me.PBC_Bottle_Util.Properties.DisplayFormat.FormatType = DevExpress.Utils.FormatType.Custom
        Me.PBC_Bottle_Util.Properties.LookAndFeel.Style = DevExpress.LookAndFeel.LookAndFeelStyle.Flat
        Me.PBC_Bottle_Util.Properties.LookAndFeel.UseDefaultLookAndFeel = False
        Me.PBC_Bottle_Util.Properties.PercentView = False
        Me.PBC_Bottle_Util.Properties.ProgressViewStyle = DevExpress.XtraEditors.Controls.ProgressViewStyle.Solid
        Me.PBC_Bottle_Util.Properties.ReadOnly = True
        Me.PBC_Bottle_Util.Properties.ShowTitle = True
        Me.PBC_Bottle_Util.Properties.Step = 1
        Me.PBC_Bottle_Util.Size = New System.Drawing.Size(328, 22)
        Me.PBC_Bottle_Util.TabIndex = 79
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.ForeColor = System.Drawing.Color.Black
        Me.Label5.ImeMode = System.Windows.Forms.ImeMode.NoControl
        Me.Label5.Location = New System.Drawing.Point(18, 122)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(117, 13)
        Me.Label5.TabIndex = 78
        Me.Label5.Text = "Quantité restante : "
        '
        'TxtBottle_Qte_Free
        '
        Me.TxtBottle_Qte_Free.Location = New System.Drawing.Point(515, 71)
        Me.TxtBottle_Qte_Free.Name = "TxtBottle_Qte_Free"
        Me.TxtBottle_Qte_Free.Properties.DisplayFormat.FormatString = "n3"
        Me.TxtBottle_Qte_Free.Properties.DisplayFormat.FormatType = DevExpress.Utils.FormatType.Numeric
        Me.TxtBottle_Qte_Free.Properties.EditFormat.FormatString = "n3"
        Me.TxtBottle_Qte_Free.Properties.EditFormat.FormatType = DevExpress.Utils.FormatType.Numeric
        Me.TxtBottle_Qte_Free.Properties.Mask.EditMask = "n3"
        Me.TxtBottle_Qte_Free.Properties.Mask.MaskType = DevExpress.XtraEditors.Mask.MaskType.Numeric
        Me.TxtBottle_Qte_Free.Properties.Mask.UseMaskAsDisplayFormat = True
        Me.TxtBottle_Qte_Free.Size = New System.Drawing.Size(202, 20)
        Me.TxtBottle_Qte_Free.TabIndex = 77
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.ForeColor = System.Drawing.Color.Black
        Me.Label4.ImeMode = System.Windows.Forms.ImeMode.NoControl
        Me.Label4.Location = New System.Drawing.Point(18, 364)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(41, 13)
        Me.Label4.TabIndex = 74
        Me.Label4.Text = "Actif :"
        '
        'BtnDelDateResti
        '
        Me.BtnDelDateResti.ForeColor = System.Drawing.Color.Black
        Me.BtnDelDateResti.Location = New System.Drawing.Point(348, 310)
        Me.BtnDelDateResti.Name = "BtnDelDateResti"
        Me.BtnDelDateResti.Size = New System.Drawing.Size(76, 39)
        Me.BtnDelDateResti.TabIndex = 73
        Me.BtnDelDateResti.Text = "Supprimer"
        Me.BtnDelDateResti.UseVisualStyleBackColor = True
        Me.BtnDelDateResti.Visible = False
        '
        'BtnAddDateResti
        '
        Me.BtnAddDateResti.ForeColor = System.Drawing.Color.Black
        Me.BtnAddDateResti.Location = New System.Drawing.Point(290, 310)
        Me.BtnAddDateResti.Name = "BtnAddDateResti"
        Me.BtnAddDateResti.Size = New System.Drawing.Size(52, 39)
        Me.BtnAddDateResti.TabIndex = 72
        Me.BtnAddDateResti.Text = "Définir"
        Me.BtnAddDateResti.UseVisualStyleBackColor = True
        Me.BtnAddDateResti.Visible = False
        '
        'CalendarDateResti
        '
        Me.CalendarDateResti.Location = New System.Drawing.Point(463, 310)
        Me.CalendarDateResti.MaxSelectionCount = 1
        Me.CalendarDateResti.Name = "CalendarDateResti"
        Me.CalendarDateResti.TabIndex = 71
        Me.CalendarDateResti.Visible = False
        '
        'GLUpBottleTech
        '
        Me.GLUpBottleTech.EditValue = ""
        Me.GLUpBottleTech.Location = New System.Drawing.Point(181, 198)
        Me.GLUpBottleTech.Name = "GLUpBottleTech"
        Me.GLUpBottleTech.Properties.Buttons.AddRange(New DevExpress.XtraEditors.Controls.EditorButton() {New DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)})
        Me.GLUpBottleTech.Properties.DisplayMember = "VTECHNOM"
        Me.GLUpBottleTech.Properties.NullText = ""
        Me.GLUpBottleTech.Properties.PopupView = Me.GV_Cbo_Tech
        Me.GLUpBottleTech.Properties.ValueMember = "NPERNUM"
        Me.GLUpBottleTech.Size = New System.Drawing.Size(328, 20)
        Me.GLUpBottleTech.TabIndex = 69
        '
        'GV_Cbo_Tech
        '
        Me.GV_Cbo_Tech.Columns.AddRange(New DevExpress.XtraGrid.Columns.GridColumn() {Me.Col_Cbo_NPERNUM, Me.Col_Cbo_VTECHNOM})
        Me.GV_Cbo_Tech.FocusRectStyle = DevExpress.XtraGrid.Views.Grid.DrawFocusRectStyle.RowFocus
        Me.GV_Cbo_Tech.Name = "GV_Cbo_Tech"
        Me.GV_Cbo_Tech.OptionsSelection.EnableAppearanceFocusedCell = False
        Me.GV_Cbo_Tech.OptionsView.ShowAutoFilterRow = True
        Me.GV_Cbo_Tech.OptionsView.ShowGroupPanel = False
        '
        'Col_Cbo_NPERNUM
        '
        Me.Col_Cbo_NPERNUM.AppearanceHeader.Options.UseTextOptions = True
        Me.Col_Cbo_NPERNUM.AppearanceHeader.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center
        Me.Col_Cbo_NPERNUM.AppearanceHeader.TextOptions.VAlignment = DevExpress.Utils.VertAlignment.Center
        Me.Col_Cbo_NPERNUM.FieldName = "NPERNUM"
        Me.Col_Cbo_NPERNUM.Name = "Col_Cbo_NPERNUM"
        Me.Col_Cbo_NPERNUM.OptionsColumn.AllowEdit = False
        Me.Col_Cbo_NPERNUM.OptionsColumn.ReadOnly = True
        '
        'Col_Cbo_VTECHNOM
        '
        Me.Col_Cbo_VTECHNOM.AppearanceHeader.Font = New System.Drawing.Font("Tahoma", 8.25!, System.Drawing.FontStyle.Bold)
        Me.Col_Cbo_VTECHNOM.AppearanceHeader.Options.UseFont = True
        Me.Col_Cbo_VTECHNOM.AppearanceHeader.Options.UseTextOptions = True
        Me.Col_Cbo_VTECHNOM.AppearanceHeader.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center
        Me.Col_Cbo_VTECHNOM.AppearanceHeader.TextOptions.VAlignment = DevExpress.Utils.VertAlignment.Center
        Me.Col_Cbo_VTECHNOM.Caption = "Technicien"
        Me.Col_Cbo_VTECHNOM.FieldName = "VTECHNOM"
        Me.Col_Cbo_VTECHNOM.Name = "Col_Cbo_VTECHNOM"
        Me.Col_Cbo_VTECHNOM.OptionsFilter.AutoFilterCondition = DevExpress.XtraGrid.Columns.AutoFilterCondition.Contains
        Me.Col_Cbo_VTECHNOM.Visible = True
        Me.Col_Cbo_VTECHNOM.VisibleIndex = 0
        '
        'GLUpBottleFluide
        '
        Me.GLUpBottleFluide.EditValue = ""
        Me.GLUpBottleFluide.Location = New System.Drawing.Point(181, 160)
        Me.GLUpBottleFluide.Name = "GLUpBottleFluide"
        Me.GLUpBottleFluide.Properties.Buttons.AddRange(New DevExpress.XtraEditors.Controls.EditorButton() {New DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)})
        Me.GLUpBottleFluide.Properties.DisplayMember = "VTYPEFLUIDELIB"
        Me.GLUpBottleFluide.Properties.NullText = ""
        Me.GLUpBottleFluide.Properties.PopupView = Me.GVBottleTechs
        Me.GLUpBottleFluide.Properties.ValueMember = "NIDTYPEFLUIDE"
        Me.GLUpBottleFluide.Size = New System.Drawing.Size(328, 20)
        Me.GLUpBottleFluide.TabIndex = 68
        '
        'GVBottleTechs
        '
        Me.GVBottleTechs.Columns.AddRange(New DevExpress.XtraGrid.Columns.GridColumn() {Me.GCol_NTYPEFLUIDE, Me.GCol_VTYPEFLUIDELIB})
        Me.GVBottleTechs.FocusRectStyle = DevExpress.XtraGrid.Views.Grid.DrawFocusRectStyle.RowFocus
        Me.GVBottleTechs.Name = "GVBottleTechs"
        Me.GVBottleTechs.OptionsSelection.EnableAppearanceFocusedCell = False
        Me.GVBottleTechs.OptionsView.ShowAutoFilterRow = True
        Me.GVBottleTechs.OptionsView.ShowGroupPanel = False
        '
        'GCol_NTYPEFLUIDE
        '
        Me.GCol_NTYPEFLUIDE.Caption = "NTYPEFLUIDE"
        Me.GCol_NTYPEFLUIDE.FieldName = "NTYPEFLUIDE"
        Me.GCol_NTYPEFLUIDE.Name = "GCol_NTYPEFLUIDE"
        '
        'GCol_VTYPEFLUIDELIB
        '
        Me.GCol_VTYPEFLUIDELIB.Caption = "Type fluide"
        Me.GCol_VTYPEFLUIDELIB.FieldName = "VTYPEFLUIDELIB"
        Me.GCol_VTYPEFLUIDELIB.Name = "GCol_VTYPEFLUIDELIB"
        Me.GCol_VTYPEFLUIDELIB.Visible = True
        Me.GCol_VTYPEFLUIDELIB.VisibleIndex = 0
        '
        'GLUpBottleContenance
        '
        Me.GLUpBottleContenance.EditValue = ""
        Me.GLUpBottleContenance.Location = New System.Drawing.Point(181, 71)
        Me.GLUpBottleContenance.Name = "GLUpBottleContenance"
        Me.GLUpBottleContenance.Properties.Buttons.AddRange(New DevExpress.XtraEditors.Controls.EditorButton() {New DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)})
        Me.GLUpBottleContenance.Properties.DisplayMember = "VBOTTLE_CONTENANT"
        Me.GLUpBottleContenance.Properties.NullText = ""
        Me.GLUpBottleContenance.Properties.PopupView = Me.GVBottleContenant
        Me.GLUpBottleContenance.Properties.ValueMember = "NBOTTLE_CONTENANT"
        Me.GLUpBottleContenance.Size = New System.Drawing.Size(328, 20)
        Me.GLUpBottleContenance.TabIndex = 67
        '
        'GVBottleContenant
        '
        Me.GVBottleContenant.Columns.AddRange(New DevExpress.XtraGrid.Columns.GridColumn() {Me.Col_Cbo_NBOTTLE_CONTENANT, Me.Col_Cbo_VBOTTLE_CONTENANT})
        Me.GVBottleContenant.FocusRectStyle = DevExpress.XtraGrid.Views.Grid.DrawFocusRectStyle.RowFocus
        Me.GVBottleContenant.Name = "GVBottleContenant"
        Me.GVBottleContenant.OptionsSelection.EnableAppearanceFocusedCell = False
        Me.GVBottleContenant.OptionsView.ShowAutoFilterRow = True
        Me.GVBottleContenant.OptionsView.ShowGroupPanel = False
        '
        'Col_Cbo_NBOTTLE_CONTENANT
        '
        Me.Col_Cbo_NBOTTLE_CONTENANT.AppearanceHeader.Options.UseTextOptions = True
        Me.Col_Cbo_NBOTTLE_CONTENANT.AppearanceHeader.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center
        Me.Col_Cbo_NBOTTLE_CONTENANT.AppearanceHeader.TextOptions.VAlignment = DevExpress.Utils.VertAlignment.Center
        Me.Col_Cbo_NBOTTLE_CONTENANT.FieldName = "NBOTTLE_CONTENANT"
        Me.Col_Cbo_NBOTTLE_CONTENANT.Name = "Col_Cbo_NBOTTLE_CONTENANT"
        Me.Col_Cbo_NBOTTLE_CONTENANT.OptionsColumn.AllowEdit = False
        Me.Col_Cbo_NBOTTLE_CONTENANT.OptionsColumn.ReadOnly = True
        '
        'Col_Cbo_VBOTTLE_CONTENANT
        '
        Me.Col_Cbo_VBOTTLE_CONTENANT.AppearanceHeader.Font = New System.Drawing.Font("Tahoma", 8.25!, System.Drawing.FontStyle.Bold)
        Me.Col_Cbo_VBOTTLE_CONTENANT.AppearanceHeader.Options.UseFont = True
        Me.Col_Cbo_VBOTTLE_CONTENANT.AppearanceHeader.Options.UseTextOptions = True
        Me.Col_Cbo_VBOTTLE_CONTENANT.AppearanceHeader.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center
        Me.Col_Cbo_VBOTTLE_CONTENANT.AppearanceHeader.TextOptions.VAlignment = DevExpress.Utils.VertAlignment.Center
        Me.Col_Cbo_VBOTTLE_CONTENANT.Caption = "Contenance"
        Me.Col_Cbo_VBOTTLE_CONTENANT.FieldName = "VBOTTLE_CONTENANT"
        Me.Col_Cbo_VBOTTLE_CONTENANT.Name = "Col_Cbo_VBOTTLE_CONTENANT"
        Me.Col_Cbo_VBOTTLE_CONTENANT.OptionsFilter.AutoFilterCondition = DevExpress.XtraGrid.Columns.AutoFilterCondition.Contains
        Me.Col_Cbo_VBOTTLE_CONTENANT.Visible = True
        Me.Col_Cbo_VBOTTLE_CONTENANT.VisibleIndex = 0
        '
        'GLUpBottleType
        '
        Me.GLUpBottleType.EditValue = ""
        Me.GLUpBottleType.Location = New System.Drawing.Point(181, 30)
        Me.GLUpBottleType.Name = "GLUpBottleType"
        Me.GLUpBottleType.Properties.Buttons.AddRange(New DevExpress.XtraEditors.Controls.EditorButton() {New DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)})
        Me.GLUpBottleType.Properties.DisplayMember = "VBOTTLETYPE"
        Me.GLUpBottleType.Properties.NullText = ""
        Me.GLUpBottleType.Properties.PopupView = Me.GVCboBottleType
        Me.GLUpBottleType.Properties.ValueMember = "NBOTTLETYPE"
        Me.GLUpBottleType.Size = New System.Drawing.Size(328, 20)
        Me.GLUpBottleType.TabIndex = 66
        '
        'GVCboBottleType
        '
        Me.GVCboBottleType.Columns.AddRange(New DevExpress.XtraGrid.Columns.GridColumn() {Me.Col_Cbo_NBOTTLETYPE, Me.Col_Cbo_VBOTTLETYPE})
        Me.GVCboBottleType.FocusRectStyle = DevExpress.XtraGrid.Views.Grid.DrawFocusRectStyle.RowFocus
        Me.GVCboBottleType.Name = "GVCboBottleType"
        Me.GVCboBottleType.OptionsSelection.EnableAppearanceFocusedCell = False
        Me.GVCboBottleType.OptionsView.ShowAutoFilterRow = True
        Me.GVCboBottleType.OptionsView.ShowGroupPanel = False
        '
        'Col_Cbo_NBOTTLETYPE
        '
        Me.Col_Cbo_NBOTTLETYPE.AppearanceHeader.Options.UseTextOptions = True
        Me.Col_Cbo_NBOTTLETYPE.AppearanceHeader.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center
        Me.Col_Cbo_NBOTTLETYPE.AppearanceHeader.TextOptions.VAlignment = DevExpress.Utils.VertAlignment.Center
        Me.Col_Cbo_NBOTTLETYPE.FieldName = "NBOTTLETYPE"
        Me.Col_Cbo_NBOTTLETYPE.Name = "Col_Cbo_NBOTTLETYPE"
        Me.Col_Cbo_NBOTTLETYPE.OptionsColumn.AllowEdit = False
        Me.Col_Cbo_NBOTTLETYPE.OptionsColumn.ReadOnly = True
        '
        'Col_Cbo_VBOTTLETYPE
        '
        Me.Col_Cbo_VBOTTLETYPE.AppearanceHeader.Font = New System.Drawing.Font("Tahoma", 8.25!, System.Drawing.FontStyle.Bold)
        Me.Col_Cbo_VBOTTLETYPE.AppearanceHeader.Options.UseFont = True
        Me.Col_Cbo_VBOTTLETYPE.AppearanceHeader.Options.UseTextOptions = True
        Me.Col_Cbo_VBOTTLETYPE.AppearanceHeader.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center
        Me.Col_Cbo_VBOTTLETYPE.AppearanceHeader.TextOptions.VAlignment = DevExpress.Utils.VertAlignment.Center
        Me.Col_Cbo_VBOTTLETYPE.Caption = "Type de bouteille"
        Me.Col_Cbo_VBOTTLETYPE.FieldName = "VBOTTLETYPE"
        Me.Col_Cbo_VBOTTLETYPE.Name = "Col_Cbo_VBOTTLETYPE"
        Me.Col_Cbo_VBOTTLETYPE.OptionsFilter.AutoFilterCondition = DevExpress.XtraGrid.Columns.AutoFilterCondition.Contains
        Me.Col_Cbo_VBOTTLETYPE.Visible = True
        Me.Col_Cbo_VBOTTLETYPE.VisibleIndex = 0
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.ForeColor = System.Drawing.Color.Black
        Me.Label3.ImeMode = System.Windows.Forms.ImeMode.NoControl
        Me.Label3.Location = New System.Drawing.Point(15, 201)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(78, 13)
        Me.Label3.TabIndex = 65
        Me.Label3.Text = "Technicien :"
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.ForeColor = System.Drawing.Color.Black
        Me.Label2.ImeMode = System.Windows.Forms.ImeMode.NoControl
        Me.Label2.Location = New System.Drawing.Point(14, 163)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(92, 13)
        Me.Label2.TabIndex = 63
        Me.Label2.Text = "Type de fluide:"
        '
        'LblSociete
        '
        Me.LblSociete.AutoSize = True
        Me.LblSociete.ForeColor = System.Drawing.Color.Black
        Me.LblSociete.ImeMode = System.Windows.Forms.ImeMode.NoControl
        Me.LblSociete.Location = New System.Drawing.Point(14, 33)
        Me.LblSociete.Name = "LblSociete"
        Me.LblSociete.Size = New System.Drawing.Size(43, 13)
        Me.LblSociete.TabIndex = 61
        Me.LblSociete.Text = "Type :"
        '
        'ChkActif
        '
        Me.ChkActif.AutoSize = True
        Me.ChkActif.CheckAlign = System.Drawing.ContentAlignment.MiddleRight
        Me.ChkActif.ForeColor = System.Drawing.Color.Black
        Me.ChkActif.ImeMode = System.Windows.Forms.ImeMode.NoControl
        Me.ChkActif.Location = New System.Drawing.Point(181, 363)
        Me.ChkActif.Name = "ChkActif"
        Me.ChkActif.Size = New System.Drawing.Size(15, 14)
        Me.ChkActif.TabIndex = 13
        Me.ChkActif.UseVisualStyleBackColor = True
        '
        'txtDtResti
        '
        Me.txtDtResti.Enabled = False
        Me.txtDtResti.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!)
        Me.txtDtResti.Location = New System.Drawing.Point(181, 318)
        Me.txtDtResti.MaxLength = 10
        Me.txtDtResti.Name = "txtDtResti"
        Me.txtDtResti.ReadOnly = True
        Me.txtDtResti.Size = New System.Drawing.Size(103, 21)
        Me.txtDtResti.TabIndex = 6
        '
        'txtObs
        '
        Me.txtObs.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.0!)
        Me.txtObs.Location = New System.Drawing.Point(17, 418)
        Me.txtObs.MaxLength = 0
        Me.txtObs.Multiline = True
        Me.txtObs.Name = "txtObs"
        Me.txtObs.ScrollBars = System.Windows.Forms.ScrollBars.Vertical
        Me.txtObs.Size = New System.Drawing.Size(542, 140)
        Me.txtObs.TabIndex = 15
        '
        'Label7
        '
        Me.Label7.AutoSize = True
        Me.Label7.ForeColor = System.Drawing.Color.Black
        Me.Label7.ImeMode = System.Windows.Forms.ImeMode.NoControl
        Me.Label7.Location = New System.Drawing.Point(14, 393)
        Me.Label7.Name = "Label7"
        Me.Label7.Size = New System.Drawing.Size(89, 13)
        Me.Label7.TabIndex = 7
        Me.Label7.Text = "Observations :"
        '
        'Label12
        '
        Me.Label12.AutoSize = True
        Me.Label12.ForeColor = System.Drawing.Color.Black
        Me.Label12.ImeMode = System.Windows.Forms.ImeMode.NoControl
        Me.Label12.Location = New System.Drawing.Point(15, 323)
        Me.Label12.Name = "Label12"
        Me.Label12.Size = New System.Drawing.Size(120, 13)
        Me.Label12.TabIndex = 15
        Me.Label12.Text = "Date de restitution :"
        '
        'txt_VREFBOTTLE
        '
        Me.txt_VREFBOTTLE.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!)
        Me.txt_VREFBOTTLE.Location = New System.Drawing.Point(181, 278)
        Me.txt_VREFBOTTLE.MaxLength = 100
        Me.txt_VREFBOTTLE.Name = "txt_VREFBOTTLE"
        Me.txt_VREFBOTTLE.Size = New System.Drawing.Size(277, 21)
        Me.txt_VREFBOTTLE.TabIndex = 0
        '
        'Label9
        '
        Me.Label9.AutoSize = True
        Me.Label9.ForeColor = System.Drawing.Color.Black
        Me.Label9.ImeMode = System.Windows.Forms.ImeMode.NoControl
        Me.Label9.Location = New System.Drawing.Point(15, 283)
        Me.Label9.Name = "Label9"
        Me.Label9.Size = New System.Drawing.Size(126, 13)
        Me.Label9.TabIndex = 9
        Me.Label9.Text = "Référence bouteille :"
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.ForeColor = System.Drawing.Color.Black
        Me.Label1.ImeMode = System.Windows.Forms.ImeMode.NoControl
        Me.Label1.Location = New System.Drawing.Point(15, 74)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(157, 13)
        Me.Label1.TabIndex = 1
        Me.Label1.Text = "Quantité contenant (en L):"
        '
        'GroupBox1
        '
        Me.GroupBox1.Controls.Add(Me.BtnFermer)
        Me.GroupBox1.Controls.Add(Me.BtnEnreg)
        Me.GroupBox1.Location = New System.Drawing.Point(12, 54)
        Me.GroupBox1.Name = "GroupBox1"
        Me.GroupBox1.Size = New System.Drawing.Size(87, 489)
        Me.GroupBox1.TabIndex = 49
        Me.GroupBox1.TabStop = False
        '
        'BtnFermer
        '
        Me.BtnFermer.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold)
        Me.BtnFermer.ImeMode = System.Windows.Forms.ImeMode.NoControl
        Me.BtnFermer.Location = New System.Drawing.Point(6, 409)
        Me.BtnFermer.Name = "BtnFermer"
        Me.BtnFermer.Size = New System.Drawing.Size(75, 48)
        Me.BtnFermer.TabIndex = 1
        Me.BtnFermer.Text = "Fermer"
        Me.BtnFermer.UseVisualStyleBackColor = True
        '
        'BtnEnreg
        '
        Me.BtnEnreg.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold)
        Me.BtnEnreg.ImeMode = System.Windows.Forms.ImeMode.NoControl
        Me.BtnEnreg.Location = New System.Drawing.Point(6, 25)
        Me.BtnEnreg.Name = "BtnEnreg"
        Me.BtnEnreg.Size = New System.Drawing.Size(76, 48)
        Me.BtnEnreg.TabIndex = 0
        Me.BtnEnreg.Text = "Enregistrer"
        Me.BtnEnreg.UseVisualStyleBackColor = True
        '
        'LabelTitre
        '
        Me.LabelTitre.AutoSize = True
        Me.LabelTitre.Font = New System.Drawing.Font("Arial", 18.0!, System.Drawing.FontStyle.Bold)
        Me.LabelTitre.ImeMode = System.Windows.Forms.ImeMode.NoControl
        Me.LabelTitre.Location = New System.Drawing.Point(105, 4)
        Me.LabelTitre.Name = "LabelTitre"
        Me.LabelTitre.Size = New System.Drawing.Size(309, 29)
        Me.LabelTitre.TabIndex = 48
        Me.LabelTitre.Tag = "44"
        Me.LabelTitre.Text = "Bouteille de fluide - Détail"
        '
        'frmCertFluidBottle
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.Wheat
        Me.ClientSize = New System.Drawing.Size(1749, 957)
        Me.Controls.Add(Me.GroupBox3)
        Me.Controls.Add(Me.GroupBox1)
        Me.Controls.Add(Me.LabelTitre)
        Me.Name = "frmCertFluidBottle"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Bouteille de fluide - Détail"
        Me.WindowState = System.Windows.Forms.FormWindowState.Maximized
        Me.GroupBox3.ResumeLayout(False)
        Me.GroupBox3.PerformLayout()
        CType(Me.GridLookUpEdit_CF.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.GridView1, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.PBC_Bottle_Util.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.TxtBottle_Qte_Free.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.GLUpBottleTech.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.GV_Cbo_Tech, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.GLUpBottleFluide.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.GVBottleTechs, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.GLUpBottleContenance.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.GVBottleContenant, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.GLUpBottleType.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.GVCboBottleType, System.ComponentModel.ISupportInitialize).EndInit()
        Me.GroupBox1.ResumeLayout(False)
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents GroupBox3 As GroupBox
    Friend WithEvents ChkActif As CheckBox
    Friend WithEvents txtObs As TextBox
    Friend WithEvents Label7 As Label
    Friend WithEvents txt_VREFBOTTLE As TextBox
    Friend WithEvents GroupBox1 As GroupBox
    Friend WithEvents BtnFermer As Button
    Friend WithEvents BtnEnreg As Button
    Friend WithEvents LabelTitre As Label
    Friend WithEvents LblSociete As Label
    Friend WithEvents Label9 As Label
    Friend WithEvents Label1 As Label
    Friend WithEvents Label12 As Label
    Friend WithEvents Label2 As Label
    Friend WithEvents Label3 As Label
    Private WithEvents GLUpBottleTech As DevExpress.XtraEditors.GridLookUpEdit
    Private WithEvents GV_Cbo_Tech As DevExpress.XtraGrid.Views.Grid.GridView
    Private WithEvents Col_Cbo_NPERNUM As DevExpress.XtraGrid.Columns.GridColumn
    Private WithEvents Col_Cbo_VTECHNOM As DevExpress.XtraGrid.Columns.GridColumn
    Private WithEvents GLUpBottleFluide As DevExpress.XtraEditors.GridLookUpEdit
    Private WithEvents GVBottleTechs As DevExpress.XtraGrid.Views.Grid.GridView
    Private WithEvents GLUpBottleContenance As DevExpress.XtraEditors.GridLookUpEdit
    Private WithEvents GVBottleContenant As DevExpress.XtraGrid.Views.Grid.GridView
    Private WithEvents Col_Cbo_NBOTTLE_CONTENANT As DevExpress.XtraGrid.Columns.GridColumn
    Private WithEvents Col_Cbo_VBOTTLE_CONTENANT As DevExpress.XtraGrid.Columns.GridColumn
    Private WithEvents GLUpBottleType As DevExpress.XtraEditors.GridLookUpEdit
    Private WithEvents GVCboBottleType As DevExpress.XtraGrid.Views.Grid.GridView
    Private WithEvents Col_Cbo_NBOTTLETYPE As DevExpress.XtraGrid.Columns.GridColumn
    Private WithEvents Col_Cbo_VBOTTLETYPE As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents CalendarDateResti As MonthCalendar
    Friend WithEvents txtDtResti As TextBox
    Friend WithEvents BtnDelDateResti As Button
    Friend WithEvents BtnAddDateResti As Button
    Friend WithEvents Label4 As Label
    Friend WithEvents GCol_NTYPEFLUIDE As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents GCol_VTYPEFLUIDELIB As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents TxtBottle_Qte_Free As DevExpress.XtraEditors.TextEdit
    Friend WithEvents Label5 As Label
    Friend WithEvents PBC_Bottle_Util As DevExpress.XtraEditors.ProgressBarControl
    Private WithEvents GridLookUpEdit_CF As DevExpress.XtraEditors.GridLookUpEdit
    Private WithEvents GridView1 As DevExpress.XtraGrid.Views.Grid.GridView
    Private WithEvents GridColumn1 As DevExpress.XtraGrid.Columns.GridColumn
    Private WithEvents GridColumn2 As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents Label6 As Label
    Friend WithEvents GridColumn3 As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents GridColumn4 As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents GridColumn5 As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents GridColumn6 As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents GridColumn7 As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents GridColumn8 As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents GridColumn10 As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents GridColumn9 As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents BtnSupprimerCom As Button
End Class
