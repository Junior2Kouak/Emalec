<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class UCInfoSTF
    Inherits System.Windows.Forms.UserControl

    'UserControl remplace la méthode Dispose pour nettoyer la liste des composants.
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(UCInfoSTF))
        Me.Label12 = New System.Windows.Forms.Label()
        Me.TxtVSTFCP = New System.Windows.Forms.TextBox()
        Me.TxtVSTFAD2 = New System.Windows.Forms.TextBox()
        Me.TxtVSTFAD1 = New System.Windows.Forms.TextBox()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.LblTitre = New System.Windows.Forms.Label()
        Me.GridSTFPays = New DevExpress.XtraEditors.GridLookUpEdit()
        Me.GridPays = New DevExpress.XtraGrid.Views.Grid.GridView()
        Me.GColNPAYSNUM = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.GColVPAYSNOM = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.TxtSTFNom = New DevExpress.XtraEditors.TextEdit()
        Me.ChkFO = New System.Windows.Forms.CheckBox()
        Me.ChkSTM = New System.Windows.Forms.CheckBox()
        Me.ChkSTI = New System.Windows.Forms.CheckBox()
        Me.ChkSTG = New System.Windows.Forms.CheckBox()
        Me.GrpBoxCedex = New System.Windows.Forms.GroupBox()
        Me.Label11 = New System.Windows.Forms.Label()
        Me.TxtVSTFCPCedex = New System.Windows.Forms.TextBox()
        Me.Label7 = New System.Windows.Forms.Label()
        Me.Label9 = New System.Windows.Forms.Label()
        Me.TxtVSTFCEDEX = New System.Windows.Forms.TextBox()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.GridSTFStatutSoc = New DevExpress.XtraEditors.GridLookUpEdit()
        Me.GVStatutSoc = New DevExpress.XtraGrid.Views.Grid.GridView()
        Me.GColStatSocID = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.GColStatSocVLIBSTATUT = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.Label6 = New System.Windows.Forms.Label()
        Me.Label8 = New System.Windows.Forms.Label()
        Me.Label10 = New System.Windows.Forms.Label()
        Me.TxtSTFSIRET = New System.Windows.Forms.TextBox()
        Me.GridSTFVille = New DevExpress.XtraEditors.GridLookUpEdit()
        Me.GVVille = New DevExpress.XtraGrid.Views.Grid.GridView()
        Me.GColCommune = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.GColCODEPOSTAL = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.TxtSTFCA = New DevExpress.XtraEditors.TextEdit()
        CType(Me.GridSTFPays.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.GridPays, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.TxtSTFNom.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.GrpBoxCedex.SuspendLayout()
        CType(Me.GridSTFStatutSoc.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.GVStatutSoc, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.GridSTFVille.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.GVVille, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.TxtSTFCA.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'Label12
        '
        resources.ApplyResources(Me.Label12, "Label12")
        Me.Label12.Name = "Label12"
        '
        'TxtVSTFCP
        '
        resources.ApplyResources(Me.TxtVSTFCP, "TxtVSTFCP")
        Me.TxtVSTFCP.Name = "TxtVSTFCP"
        '
        'TxtVSTFAD2
        '
        resources.ApplyResources(Me.TxtVSTFAD2, "TxtVSTFAD2")
        Me.TxtVSTFAD2.Name = "TxtVSTFAD2"
        '
        'TxtVSTFAD1
        '
        resources.ApplyResources(Me.TxtVSTFAD1, "TxtVSTFAD1")
        Me.TxtVSTFAD1.Name = "TxtVSTFAD1"
        '
        'Label4
        '
        resources.ApplyResources(Me.Label4, "Label4")
        Me.Label4.ForeColor = System.Drawing.Color.DarkGreen
        Me.Label4.Name = "Label4"
        '
        'Label3
        '
        resources.ApplyResources(Me.Label3, "Label3")
        Me.Label3.ForeColor = System.Drawing.Color.DarkGreen
        Me.Label3.Name = "Label3"
        '
        'Label2
        '
        resources.ApplyResources(Me.Label2, "Label2")
        Me.Label2.ForeColor = System.Drawing.Color.DarkGreen
        Me.Label2.Name = "Label2"
        '
        'Label1
        '
        resources.ApplyResources(Me.Label1, "Label1")
        Me.Label1.ForeColor = System.Drawing.Color.DarkGreen
        Me.Label1.Name = "Label1"
        '
        'LblTitre
        '
        resources.ApplyResources(Me.LblTitre, "LblTitre")
        Me.LblTitre.ForeColor = System.Drawing.Color.IndianRed
        Me.LblTitre.Name = "LblTitre"
        '
        'GridSTFPays
        '
        resources.ApplyResources(Me.GridSTFPays, "GridSTFPays")
        Me.GridSTFPays.Name = "GridSTFPays"
        Me.GridSTFPays.Properties.AccessibleDescription = resources.GetString("GridSTFPays.Properties.AccessibleDescription")
        Me.GridSTFPays.Properties.AccessibleName = resources.GetString("GridSTFPays.Properties.AccessibleName")
        Me.GridSTFPays.Properties.AutoHeight = CType(resources.GetObject("GridSTFPays.Properties.AutoHeight"), Boolean)
        Me.GridSTFPays.Properties.Buttons.AddRange(New DevExpress.XtraEditors.Controls.EditorButton() {New DevExpress.XtraEditors.Controls.EditorButton(CType(resources.GetObject("GridSTFPays.Properties.Buttons"), DevExpress.XtraEditors.Controls.ButtonPredefines))})
        Me.GridSTFPays.Properties.DisplayMember = "VPAYSNOM"
        Me.GridSTFPays.Properties.NullText = resources.GetString("GridSTFPays.Properties.NullText")
        Me.GridSTFPays.Properties.NullValuePrompt = resources.GetString("GridSTFPays.Properties.NullValuePrompt")
        Me.GridSTFPays.Properties.NullValuePromptShowForEmptyValue = CType(resources.GetObject("GridSTFPays.Properties.NullValuePromptShowForEmptyValue"), Boolean)
        Me.GridSTFPays.Properties.ValueMember = "NPAYSNUM"
        Me.GridSTFPays.Properties.View = Me.GridPays
        '
        'GridPays
        '
        resources.ApplyResources(Me.GridPays, "GridPays")
        Me.GridPays.Columns.AddRange(New DevExpress.XtraGrid.Columns.GridColumn() {Me.GColNPAYSNUM, Me.GColVPAYSNOM})
        Me.GridPays.FocusRectStyle = DevExpress.XtraGrid.Views.Grid.DrawFocusRectStyle.RowFocus
        Me.GridPays.Name = "GridPays"
        Me.GridPays.OptionsSelection.EnableAppearanceFocusedCell = False
        Me.GridPays.OptionsView.ShowAutoFilterRow = True
        Me.GridPays.OptionsView.ShowGroupPanel = False
        '
        'GColNPAYSNUM
        '
        resources.ApplyResources(Me.GColNPAYSNUM, "GColNPAYSNUM")
        Me.GColNPAYSNUM.FieldName = "NPAYSNUM"
        Me.GColNPAYSNUM.Name = "GColNPAYSNUM"
        '
        'GColVPAYSNOM
        '
        Me.GColVPAYSNOM.AppearanceHeader.Font = CType(resources.GetObject("GColVPAYSNOM.AppearanceHeader.Font"), System.Drawing.Font)
        Me.GColVPAYSNOM.AppearanceHeader.GradientMode = CType(resources.GetObject("GColVPAYSNOM.AppearanceHeader.GradientMode"), System.Drawing.Drawing2D.LinearGradientMode)
        Me.GColVPAYSNOM.AppearanceHeader.Image = CType(resources.GetObject("GColVPAYSNOM.AppearanceHeader.Image"), System.Drawing.Image)
        Me.GColVPAYSNOM.AppearanceHeader.Options.UseFont = True
        Me.GColVPAYSNOM.AppearanceHeader.Options.UseTextOptions = True
        Me.GColVPAYSNOM.AppearanceHeader.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center
        Me.GColVPAYSNOM.AppearanceHeader.TextOptions.VAlignment = DevExpress.Utils.VertAlignment.Center
        resources.ApplyResources(Me.GColVPAYSNOM, "GColVPAYSNOM")
        Me.GColVPAYSNOM.FieldName = "VPAYSNOM"
        Me.GColVPAYSNOM.Name = "GColVPAYSNOM"
        Me.GColVPAYSNOM.OptionsFilter.AutoFilterCondition = DevExpress.XtraGrid.Columns.AutoFilterCondition.Contains
        '
        'TxtSTFNom
        '
        resources.ApplyResources(Me.TxtSTFNom, "TxtSTFNom")
        Me.TxtSTFNom.Name = "TxtSTFNom"
        Me.TxtSTFNom.Properties.AccessibleDescription = resources.GetString("TxtSTFNom.Properties.AccessibleDescription")
        Me.TxtSTFNom.Properties.AccessibleName = resources.GetString("TxtSTFNom.Properties.AccessibleName")
        Me.TxtSTFNom.Properties.AutoHeight = CType(resources.GetObject("TxtSTFNom.Properties.AutoHeight"), Boolean)
        Me.TxtSTFNom.Properties.Mask.AutoComplete = CType(resources.GetObject("TxtSTFNom.Properties.Mask.AutoComplete"), DevExpress.XtraEditors.Mask.AutoCompleteType)
        Me.TxtSTFNom.Properties.Mask.BeepOnError = CType(resources.GetObject("TxtSTFNom.Properties.Mask.BeepOnError"), Boolean)
        Me.TxtSTFNom.Properties.Mask.EditMask = resources.GetString("TxtSTFNom.Properties.Mask.EditMask")
        Me.TxtSTFNom.Properties.Mask.IgnoreMaskBlank = CType(resources.GetObject("TxtSTFNom.Properties.Mask.IgnoreMaskBlank"), Boolean)
        Me.TxtSTFNom.Properties.Mask.MaskType = CType(resources.GetObject("TxtSTFNom.Properties.Mask.MaskType"), DevExpress.XtraEditors.Mask.MaskType)
        Me.TxtSTFNom.Properties.Mask.PlaceHolder = CType(resources.GetObject("TxtSTFNom.Properties.Mask.PlaceHolder"), Char)
        Me.TxtSTFNom.Properties.Mask.SaveLiteral = CType(resources.GetObject("TxtSTFNom.Properties.Mask.SaveLiteral"), Boolean)
        Me.TxtSTFNom.Properties.Mask.ShowPlaceHolders = CType(resources.GetObject("TxtSTFNom.Properties.Mask.ShowPlaceHolders"), Boolean)
        Me.TxtSTFNom.Properties.Mask.UseMaskAsDisplayFormat = CType(resources.GetObject("TxtSTFNom.Properties.Mask.UseMaskAsDisplayFormat"), Boolean)
        Me.TxtSTFNom.Properties.MaxLength = 40
        Me.TxtSTFNom.Properties.NullValuePrompt = resources.GetString("TxtSTFNom.Properties.NullValuePrompt")
        Me.TxtSTFNom.Properties.NullValuePromptShowForEmptyValue = CType(resources.GetObject("TxtSTFNom.Properties.NullValuePromptShowForEmptyValue"), Boolean)
        '
        'ChkFO
        '
        resources.ApplyResources(Me.ChkFO, "ChkFO")
        Me.ChkFO.ForeColor = System.Drawing.Color.Teal
        Me.ChkFO.Name = "ChkFO"
        Me.ChkFO.UseVisualStyleBackColor = True
        '
        'ChkSTM
        '
        resources.ApplyResources(Me.ChkSTM, "ChkSTM")
        Me.ChkSTM.ForeColor = System.Drawing.Color.Teal
        Me.ChkSTM.Name = "ChkSTM"
        Me.ChkSTM.UseVisualStyleBackColor = True
        '
        'ChkSTI
        '
        resources.ApplyResources(Me.ChkSTI, "ChkSTI")
        Me.ChkSTI.ForeColor = System.Drawing.Color.Teal
        Me.ChkSTI.Name = "ChkSTI"
        Me.ChkSTI.UseVisualStyleBackColor = True
        '
        'ChkSTG
        '
        resources.ApplyResources(Me.ChkSTG, "ChkSTG")
        Me.ChkSTG.ForeColor = System.Drawing.Color.Teal
        Me.ChkSTG.Name = "ChkSTG"
        Me.ChkSTG.UseVisualStyleBackColor = True
        '
        'GrpBoxCedex
        '
        resources.ApplyResources(Me.GrpBoxCedex, "GrpBoxCedex")
        Me.GrpBoxCedex.Controls.Add(Me.Label11)
        Me.GrpBoxCedex.Controls.Add(Me.TxtVSTFCPCedex)
        Me.GrpBoxCedex.Controls.Add(Me.Label7)
        Me.GrpBoxCedex.Controls.Add(Me.Label9)
        Me.GrpBoxCedex.Controls.Add(Me.TxtVSTFCEDEX)
        Me.GrpBoxCedex.Controls.Add(Me.Label5)
        Me.GrpBoxCedex.ForeColor = System.Drawing.Color.DarkGreen
        Me.GrpBoxCedex.Name = "GrpBoxCedex"
        Me.GrpBoxCedex.TabStop = False
        '
        'Label11
        '
        resources.ApplyResources(Me.Label11, "Label11")
        Me.Label11.ForeColor = System.Drawing.Color.Black
        Me.Label11.Name = "Label11"
        '
        'TxtVSTFCPCedex
        '
        resources.ApplyResources(Me.TxtVSTFCPCedex, "TxtVSTFCPCedex")
        Me.TxtVSTFCPCedex.Name = "TxtVSTFCPCedex"
        '
        'Label7
        '
        resources.ApplyResources(Me.Label7, "Label7")
        Me.Label7.ForeColor = System.Drawing.Color.DarkGreen
        Me.Label7.Name = "Label7"
        '
        'Label9
        '
        resources.ApplyResources(Me.Label9, "Label9")
        Me.Label9.ForeColor = System.Drawing.Color.Black
        Me.Label9.Name = "Label9"
        '
        'TxtVSTFCEDEX
        '
        resources.ApplyResources(Me.TxtVSTFCEDEX, "TxtVSTFCEDEX")
        Me.TxtVSTFCEDEX.Name = "TxtVSTFCEDEX"
        '
        'Label5
        '
        resources.ApplyResources(Me.Label5, "Label5")
        Me.Label5.ForeColor = System.Drawing.Color.DarkGreen
        Me.Label5.Name = "Label5"
        '
        'GridSTFStatutSoc
        '
        resources.ApplyResources(Me.GridSTFStatutSoc, "GridSTFStatutSoc")
        Me.GridSTFStatutSoc.Name = "GridSTFStatutSoc"
        Me.GridSTFStatutSoc.Properties.AccessibleDescription = resources.GetString("GridSTFStatutSoc.Properties.AccessibleDescription")
        Me.GridSTFStatutSoc.Properties.AccessibleName = resources.GetString("GridSTFStatutSoc.Properties.AccessibleName")
        Me.GridSTFStatutSoc.Properties.AutoHeight = CType(resources.GetObject("GridSTFStatutSoc.Properties.AutoHeight"), Boolean)
        Me.GridSTFStatutSoc.Properties.Buttons.AddRange(New DevExpress.XtraEditors.Controls.EditorButton() {New DevExpress.XtraEditors.Controls.EditorButton(CType(resources.GetObject("GridSTFStatutSoc.Properties.Buttons"), DevExpress.XtraEditors.Controls.ButtonPredefines))})
        Me.GridSTFStatutSoc.Properties.DisplayMember = "VLIBSTATUT"
        Me.GridSTFStatutSoc.Properties.NullText = resources.GetString("GridSTFStatutSoc.Properties.NullText")
        Me.GridSTFStatutSoc.Properties.NullValuePrompt = resources.GetString("GridSTFStatutSoc.Properties.NullValuePrompt")
        Me.GridSTFStatutSoc.Properties.NullValuePromptShowForEmptyValue = CType(resources.GetObject("GridSTFStatutSoc.Properties.NullValuePromptShowForEmptyValue"), Boolean)
        Me.GridSTFStatutSoc.Properties.PopupFormSize = New System.Drawing.Size(350, 0)
        Me.GridSTFStatutSoc.Properties.ValueMember = "ID"
        Me.GridSTFStatutSoc.Properties.View = Me.GVStatutSoc
        '
        'GVStatutSoc
        '
        resources.ApplyResources(Me.GVStatutSoc, "GVStatutSoc")
        Me.GVStatutSoc.Columns.AddRange(New DevExpress.XtraGrid.Columns.GridColumn() {Me.GColStatSocID, Me.GColStatSocVLIBSTATUT})
        Me.GVStatutSoc.FocusRectStyle = DevExpress.XtraGrid.Views.Grid.DrawFocusRectStyle.RowFocus
        Me.GVStatutSoc.Name = "GVStatutSoc"
        Me.GVStatutSoc.OptionsSelection.EnableAppearanceFocusedCell = False
        Me.GVStatutSoc.OptionsView.ShowAutoFilterRow = True
        Me.GVStatutSoc.OptionsView.ShowGroupPanel = False
        '
        'GColStatSocID
        '
        resources.ApplyResources(Me.GColStatSocID, "GColStatSocID")
        Me.GColStatSocID.FieldName = "ID"
        Me.GColStatSocID.Name = "GColStatSocID"
        '
        'GColStatSocVLIBSTATUT
        '
        Me.GColStatSocVLIBSTATUT.AppearanceHeader.Font = CType(resources.GetObject("GColStatSocVLIBSTATUT.AppearanceHeader.Font"), System.Drawing.Font)
        Me.GColStatSocVLIBSTATUT.AppearanceHeader.GradientMode = CType(resources.GetObject("GColStatSocVLIBSTATUT.AppearanceHeader.GradientMode"), System.Drawing.Drawing2D.LinearGradientMode)
        Me.GColStatSocVLIBSTATUT.AppearanceHeader.Image = CType(resources.GetObject("GColStatSocVLIBSTATUT.AppearanceHeader.Image"), System.Drawing.Image)
        Me.GColStatSocVLIBSTATUT.AppearanceHeader.Options.UseFont = True
        Me.GColStatSocVLIBSTATUT.AppearanceHeader.Options.UseTextOptions = True
        Me.GColStatSocVLIBSTATUT.AppearanceHeader.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center
        Me.GColStatSocVLIBSTATUT.AppearanceHeader.TextOptions.VAlignment = DevExpress.Utils.VertAlignment.Center
        resources.ApplyResources(Me.GColStatSocVLIBSTATUT, "GColStatSocVLIBSTATUT")
        Me.GColStatSocVLIBSTATUT.FieldName = "VLIBSTATUT"
        Me.GColStatSocVLIBSTATUT.Name = "GColStatSocVLIBSTATUT"
        Me.GColStatSocVLIBSTATUT.OptionsFilter.AutoFilterCondition = DevExpress.XtraGrid.Columns.AutoFilterCondition.Contains
        '
        'Label6
        '
        resources.ApplyResources(Me.Label6, "Label6")
        Me.Label6.ForeColor = System.Drawing.Color.DarkGreen
        Me.Label6.Name = "Label6"
        '
        'Label8
        '
        resources.ApplyResources(Me.Label8, "Label8")
        Me.Label8.ForeColor = System.Drawing.Color.DarkGreen
        Me.Label8.Name = "Label8"
        '
        'Label10
        '
        resources.ApplyResources(Me.Label10, "Label10")
        Me.Label10.ForeColor = System.Drawing.Color.DarkGreen
        Me.Label10.Name = "Label10"
        '
        'TxtSTFSIRET
        '
        resources.ApplyResources(Me.TxtSTFSIRET, "TxtSTFSIRET")
        Me.TxtSTFSIRET.Name = "TxtSTFSIRET"
        '
        'GridSTFVille
        '
        resources.ApplyResources(Me.GridSTFVille, "GridSTFVille")
        Me.GridSTFVille.Name = "GridSTFVille"
        Me.GridSTFVille.Properties.AccessibleDescription = resources.GetString("GridSTFVille.Properties.AccessibleDescription")
        Me.GridSTFVille.Properties.AccessibleName = resources.GetString("GridSTFVille.Properties.AccessibleName")
        Me.GridSTFVille.Properties.AutoHeight = CType(resources.GetObject("GridSTFVille.Properties.AutoHeight"), Boolean)
        Me.GridSTFVille.Properties.Buttons.AddRange(New DevExpress.XtraEditors.Controls.EditorButton() {New DevExpress.XtraEditors.Controls.EditorButton(CType(resources.GetObject("GridSTFVille.Properties.Buttons"), DevExpress.XtraEditors.Controls.ButtonPredefines))})
        Me.GridSTFVille.Properties.DisplayMember = "VILLE"
        Me.GridSTFVille.Properties.NullText = resources.GetString("GridSTFVille.Properties.NullText")
        Me.GridSTFVille.Properties.NullValuePrompt = resources.GetString("GridSTFVille.Properties.NullValuePrompt")
        Me.GridSTFVille.Properties.NullValuePromptShowForEmptyValue = CType(resources.GetObject("GridSTFVille.Properties.NullValuePromptShowForEmptyValue"), Boolean)
        Me.GridSTFVille.Properties.ValueMember = "VILLE"
        Me.GridSTFVille.Properties.View = Me.GVVille
        '
        'GVVille
        '
        resources.ApplyResources(Me.GVVille, "GVVille")
        Me.GVVille.Columns.AddRange(New DevExpress.XtraGrid.Columns.GridColumn() {Me.GColCommune, Me.GColCODEPOSTAL})
        Me.GVVille.FocusRectStyle = DevExpress.XtraGrid.Views.Grid.DrawFocusRectStyle.RowFocus
        Me.GVVille.Name = "GVVille"
        Me.GVVille.OptionsSelection.EnableAppearanceFocusedCell = False
        Me.GVVille.OptionsView.ShowAutoFilterRow = True
        Me.GVVille.OptionsView.ShowGroupPanel = False
        Me.GVVille.OptionsView.ShowButtonMode = DevExpress.XtraGrid.Views.Base.ShowButtonModeEnum.ShowForFocusedRow
        '
        'GColCommune
        '
        Me.GColCommune.AppearanceHeader.Font = CType(resources.GetObject("GColCommune.AppearanceHeader.Font"), System.Drawing.Font)
        Me.GColCommune.AppearanceHeader.GradientMode = CType(resources.GetObject("GColCommune.AppearanceHeader.GradientMode"), System.Drawing.Drawing2D.LinearGradientMode)
        Me.GColCommune.AppearanceHeader.Image = CType(resources.GetObject("GColCommune.AppearanceHeader.Image"), System.Drawing.Image)
        Me.GColCommune.AppearanceHeader.Options.UseFont = True
        Me.GColCommune.AppearanceHeader.Options.UseTextOptions = True
        Me.GColCommune.AppearanceHeader.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center
        Me.GColCommune.AppearanceHeader.TextOptions.VAlignment = DevExpress.Utils.VertAlignment.Center
        resources.ApplyResources(Me.GColCommune, "GColCommune")
        Me.GColCommune.FieldName = "VILLE"
        Me.GColCommune.Name = "GColCommune"
        Me.GColCommune.OptionsFilter.AutoFilterCondition = DevExpress.XtraGrid.Columns.AutoFilterCondition.Contains
        '
        'GColCODEPOSTAL
        '
        Me.GColCODEPOSTAL.AppearanceHeader.Font = CType(resources.GetObject("GColCODEPOSTAL.AppearanceHeader.Font"), System.Drawing.Font)
        Me.GColCODEPOSTAL.AppearanceHeader.GradientMode = CType(resources.GetObject("GColCODEPOSTAL.AppearanceHeader.GradientMode"), System.Drawing.Drawing2D.LinearGradientMode)
        Me.GColCODEPOSTAL.AppearanceHeader.Image = CType(resources.GetObject("GColCODEPOSTAL.AppearanceHeader.Image"), System.Drawing.Image)
        Me.GColCODEPOSTAL.AppearanceHeader.Options.UseFont = True
        Me.GColCODEPOSTAL.AppearanceHeader.Options.UseTextOptions = True
        Me.GColCODEPOSTAL.AppearanceHeader.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center
        Me.GColCODEPOSTAL.AppearanceHeader.TextOptions.VAlignment = DevExpress.Utils.VertAlignment.Center
        resources.ApplyResources(Me.GColCODEPOSTAL, "GColCODEPOSTAL")
        Me.GColCODEPOSTAL.FieldName = "CODEPOSTAL"
        Me.GColCODEPOSTAL.Name = "GColCODEPOSTAL"
        Me.GColCODEPOSTAL.OptionsFilter.AutoFilterCondition = DevExpress.XtraGrid.Columns.AutoFilterCondition.Contains
        '
        'TxtSTFCA
        '
        resources.ApplyResources(Me.TxtSTFCA, "TxtSTFCA")
        Me.TxtSTFCA.Name = "TxtSTFCA"
        Me.TxtSTFCA.Properties.AccessibleDescription = resources.GetString("TxtSTFCA.Properties.AccessibleDescription")
        Me.TxtSTFCA.Properties.AccessibleName = resources.GetString("TxtSTFCA.Properties.AccessibleName")
        Me.TxtSTFCA.Properties.Appearance.GradientMode = CType(resources.GetObject("TxtSTFCA.Properties.Appearance.GradientMode"), System.Drawing.Drawing2D.LinearGradientMode)
        Me.TxtSTFCA.Properties.Appearance.Image = CType(resources.GetObject("TxtSTFCA.Properties.Appearance.Image"), System.Drawing.Image)
        Me.TxtSTFCA.Properties.Appearance.Options.UseTextOptions = True
        Me.TxtSTFCA.Properties.Appearance.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Far
        Me.TxtSTFCA.Properties.AutoHeight = CType(resources.GetObject("TxtSTFCA.Properties.AutoHeight"), Boolean)
        Me.TxtSTFCA.Properties.Mask.AutoComplete = CType(resources.GetObject("TxtSTFCA.Properties.Mask.AutoComplete"), DevExpress.XtraEditors.Mask.AutoCompleteType)
        Me.TxtSTFCA.Properties.Mask.BeepOnError = CType(resources.GetObject("TxtSTFCA.Properties.Mask.BeepOnError"), Boolean)
        Me.TxtSTFCA.Properties.Mask.EditMask = resources.GetString("TxtSTFCA.Properties.Mask.EditMask")
        Me.TxtSTFCA.Properties.Mask.IgnoreMaskBlank = CType(resources.GetObject("TxtSTFCA.Properties.Mask.IgnoreMaskBlank"), Boolean)
        Me.TxtSTFCA.Properties.Mask.MaskType = CType(resources.GetObject("TxtSTFCA.Properties.Mask.MaskType"), DevExpress.XtraEditors.Mask.MaskType)
        Me.TxtSTFCA.Properties.Mask.PlaceHolder = CType(resources.GetObject("TxtSTFCA.Properties.Mask.PlaceHolder"), Char)
        Me.TxtSTFCA.Properties.Mask.SaveLiteral = CType(resources.GetObject("TxtSTFCA.Properties.Mask.SaveLiteral"), Boolean)
        Me.TxtSTFCA.Properties.Mask.ShowPlaceHolders = CType(resources.GetObject("TxtSTFCA.Properties.Mask.ShowPlaceHolders"), Boolean)
        Me.TxtSTFCA.Properties.Mask.UseMaskAsDisplayFormat = CType(resources.GetObject("TxtSTFCA.Properties.Mask.UseMaskAsDisplayFormat"), Boolean)
        Me.TxtSTFCA.Properties.MaxLength = 150
        Me.TxtSTFCA.Properties.NullValuePrompt = resources.GetString("TxtSTFCA.Properties.NullValuePrompt")
        Me.TxtSTFCA.Properties.NullValuePromptShowForEmptyValue = CType(resources.GetObject("TxtSTFCA.Properties.NullValuePromptShowForEmptyValue"), Boolean)
        '
        'UCInfoSTF
        '
        resources.ApplyResources(Me, "$this")
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.DarkSeaGreen
        Me.Controls.Add(Me.TxtSTFCA)
        Me.Controls.Add(Me.GridSTFVille)
        Me.Controls.Add(Me.TxtSTFSIRET)
        Me.Controls.Add(Me.Label10)
        Me.Controls.Add(Me.Label8)
        Me.Controls.Add(Me.GridSTFStatutSoc)
        Me.Controls.Add(Me.Label6)
        Me.Controls.Add(Me.GrpBoxCedex)
        Me.Controls.Add(Me.ChkSTG)
        Me.Controls.Add(Me.ChkSTI)
        Me.Controls.Add(Me.ChkSTM)
        Me.Controls.Add(Me.ChkFO)
        Me.Controls.Add(Me.TxtSTFNom)
        Me.Controls.Add(Me.GridSTFPays)
        Me.Controls.Add(Me.Label12)
        Me.Controls.Add(Me.TxtVSTFCP)
        Me.Controls.Add(Me.TxtVSTFAD2)
        Me.Controls.Add(Me.TxtVSTFAD1)
        Me.Controls.Add(Me.Label4)
        Me.Controls.Add(Me.Label3)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.LblTitre)
        Me.Name = "UCInfoSTF"
        CType(Me.GridSTFPays.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.GridPays, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.TxtSTFNom.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        Me.GrpBoxCedex.ResumeLayout(False)
        Me.GrpBoxCedex.PerformLayout()
        CType(Me.GridSTFStatutSoc.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.GVStatutSoc, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.GridSTFVille.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.GVVille, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.TxtSTFCA.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents Label12 As System.Windows.Forms.Label
    Friend WithEvents TxtVSTFCP As System.Windows.Forms.TextBox
    Friend WithEvents TxtVSTFAD2 As System.Windows.Forms.TextBox
    Friend WithEvents TxtVSTFAD1 As System.Windows.Forms.TextBox
    Friend WithEvents Label4 As System.Windows.Forms.Label
    Friend WithEvents Label3 As System.Windows.Forms.Label
    Friend WithEvents Label2 As System.Windows.Forms.Label
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents LblTitre As System.Windows.Forms.Label
    Friend WithEvents GridSTFPays As DevExpress.XtraEditors.GridLookUpEdit
    Friend WithEvents GridPays As DevExpress.XtraGrid.Views.Grid.GridView
    Friend WithEvents GColNPAYSNUM As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents GColVPAYSNOM As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents TxtSTFNom As DevExpress.XtraEditors.TextEdit
    Friend WithEvents ChkFO As System.Windows.Forms.CheckBox
    Friend WithEvents ChkSTM As System.Windows.Forms.CheckBox
    Friend WithEvents ChkSTI As System.Windows.Forms.CheckBox
    Friend WithEvents ChkSTG As System.Windows.Forms.CheckBox
    Friend WithEvents GrpBoxCedex As System.Windows.Forms.GroupBox
    Friend WithEvents Label9 As System.Windows.Forms.Label
    Friend WithEvents TxtVSTFCEDEX As System.Windows.Forms.TextBox
    Friend WithEvents Label5 As System.Windows.Forms.Label
    Friend WithEvents TxtVSTFCPCedex As System.Windows.Forms.TextBox
    Friend WithEvents Label7 As System.Windows.Forms.Label
    Friend WithEvents Label11 As System.Windows.Forms.Label
    Friend WithEvents GridSTFStatutSoc As DevExpress.XtraEditors.GridLookUpEdit
    Friend WithEvents GVStatutSoc As DevExpress.XtraGrid.Views.Grid.GridView
    Friend WithEvents GColStatSocID As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents GColStatSocVLIBSTATUT As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents Label6 As System.Windows.Forms.Label
    Friend WithEvents Label8 As System.Windows.Forms.Label
    Friend WithEvents Label10 As System.Windows.Forms.Label
    Friend WithEvents TxtSTFSIRET As System.Windows.Forms.TextBox
    Friend WithEvents GridSTFVille As DevExpress.XtraEditors.GridLookUpEdit
    Friend WithEvents GVVille As DevExpress.XtraGrid.Views.Grid.GridView
    Friend WithEvents GColCommune As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents GColCODEPOSTAL As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents TxtSTFCA As DevExpress.XtraEditors.TextEdit

End Class
