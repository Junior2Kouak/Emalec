<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class UCSiteSTF
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(UCSiteSTF))
        Me.Label9 = New System.Windows.Forms.Label()
        Me.Label10 = New System.Windows.Forms.Label()
        Me.Label11 = New System.Windows.Forms.Label()
        Me.Label7 = New System.Windows.Forms.Label()
        Me.GridSITSTFVille = New DevExpress.XtraEditors.GridLookUpEdit()
        Me.GVVille = New DevExpress.XtraGrid.Views.Grid.GridView()
        Me.GColCommune = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.GColCODEPOSTAL = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.TxtVSITSTFCPCedex = New System.Windows.Forms.TextBox()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.GrpBoxCedex = New System.Windows.Forms.GroupBox()
        Me.TxtVSITSTFCEDEX = New System.Windows.Forms.TextBox()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.TxtSiteSTFNom = New DevExpress.XtraEditors.TextEdit()
        Me.GridSITSTFPays = New DevExpress.XtraEditors.GridLookUpEdit()
        Me.GridPays = New DevExpress.XtraGrid.Views.Grid.GridView()
        Me.GColNPAYSNUM = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.GColVPAYSNOM = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.Label12 = New System.Windows.Forms.Label()
        Me.TxtVSITSTFCP = New System.Windows.Forms.TextBox()
        Me.TxtVSITSTFAD2 = New System.Windows.Forms.TextBox()
        Me.TxtVSITSTFAD1 = New System.Windows.Forms.TextBox()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.LblTitre = New System.Windows.Forms.Label()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.Label13 = New System.Windows.Forms.Label()
        Me.TxtSITSTFCoutHor = New DevExpress.XtraEditors.TextEdit()
        Me.TxtSITSTFCoutDep = New DevExpress.XtraEditors.TextEdit()
        Me.Label14 = New System.Windows.Forms.Label()
        Me.Label15 = New System.Windows.Forms.Label()
        Me.GridSITSTFLangue = New DevExpress.XtraEditors.GridLookUpEdit()
        Me.GridView1 = New DevExpress.XtraGrid.Views.Grid.GridView()
        Me.GridColumn1 = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.GridColumn2 = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.LblTitreLangue = New System.Windows.Forms.Label()
        CType(Me.GridSITSTFVille.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.GVVille, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.GrpBoxCedex.SuspendLayout()
        CType(Me.TxtSiteSTFNom.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.GridSITSTFPays.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.GridPays, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.TxtSITSTFCoutHor.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.TxtSITSTFCoutDep.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.GridSITSTFLangue.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.GridView1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'Label9
        '
        resources.ApplyResources(Me.Label9, "Label9")
        Me.Label9.ForeColor = System.Drawing.Color.Black
        Me.Label9.Name = "Label9"
        '
        'Label10
        '
        resources.ApplyResources(Me.Label10, "Label10")
        Me.Label10.ForeColor = System.Drawing.Color.DarkGreen
        Me.Label10.Name = "Label10"
        '
        'Label11
        '
        resources.ApplyResources(Me.Label11, "Label11")
        Me.Label11.ForeColor = System.Drawing.Color.Black
        Me.Label11.Name = "Label11"
        '
        'Label7
        '
        resources.ApplyResources(Me.Label7, "Label7")
        Me.Label7.ForeColor = System.Drawing.Color.DarkGreen
        Me.Label7.Name = "Label7"
        '
        'GridSITSTFVille
        '
        resources.ApplyResources(Me.GridSITSTFVille, "GridSITSTFVille")
        Me.GridSITSTFVille.Name = "GridSITSTFVille"
        Me.GridSITSTFVille.Properties.AccessibleDescription = resources.GetString("GridSITSTFVille.Properties.AccessibleDescription")
        Me.GridSITSTFVille.Properties.AccessibleName = resources.GetString("GridSITSTFVille.Properties.AccessibleName")
        Me.GridSITSTFVille.Properties.AutoHeight = CType(resources.GetObject("GridSITSTFVille.Properties.AutoHeight"), Boolean)
        Me.GridSITSTFVille.Properties.Buttons.AddRange(New DevExpress.XtraEditors.Controls.EditorButton() {New DevExpress.XtraEditors.Controls.EditorButton(CType(resources.GetObject("GridSITSTFVille.Properties.Buttons"), DevExpress.XtraEditors.Controls.ButtonPredefines))})
        Me.GridSITSTFVille.Properties.DisplayMember = "VILLE"
        Me.GridSITSTFVille.Properties.NullText = resources.GetString("GridSITSTFVille.Properties.NullText")
        Me.GridSITSTFVille.Properties.NullValuePrompt = resources.GetString("GridSITSTFVille.Properties.NullValuePrompt")
        Me.GridSITSTFVille.Properties.NullValuePromptShowForEmptyValue = CType(resources.GetObject("GridSITSTFVille.Properties.NullValuePromptShowForEmptyValue"), Boolean)
        Me.GridSITSTFVille.Properties.ValueMember = "VILLE"
        Me.GridSITSTFVille.Properties.View = Me.GVVille
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
        'TxtVSITSTFCPCedex
        '
        resources.ApplyResources(Me.TxtVSITSTFCPCedex, "TxtVSITSTFCPCedex")
        Me.TxtVSITSTFCPCedex.Name = "TxtVSITSTFCPCedex"
        '
        'Label1
        '
        resources.ApplyResources(Me.Label1, "Label1")
        Me.Label1.ForeColor = System.Drawing.Color.DarkGreen
        Me.Label1.Name = "Label1"
        '
        'GrpBoxCedex
        '
        resources.ApplyResources(Me.GrpBoxCedex, "GrpBoxCedex")
        Me.GrpBoxCedex.Controls.Add(Me.Label11)
        Me.GrpBoxCedex.Controls.Add(Me.TxtVSITSTFCPCedex)
        Me.GrpBoxCedex.Controls.Add(Me.Label7)
        Me.GrpBoxCedex.Controls.Add(Me.Label9)
        Me.GrpBoxCedex.Controls.Add(Me.TxtVSITSTFCEDEX)
        Me.GrpBoxCedex.Controls.Add(Me.Label5)
        Me.GrpBoxCedex.ForeColor = System.Drawing.Color.DarkGreen
        Me.GrpBoxCedex.Name = "GrpBoxCedex"
        Me.GrpBoxCedex.TabStop = False
        '
        'TxtVSITSTFCEDEX
        '
        resources.ApplyResources(Me.TxtVSITSTFCEDEX, "TxtVSITSTFCEDEX")
        Me.TxtVSITSTFCEDEX.Name = "TxtVSITSTFCEDEX"
        '
        'Label5
        '
        resources.ApplyResources(Me.Label5, "Label5")
        Me.Label5.ForeColor = System.Drawing.Color.DarkGreen
        Me.Label5.Name = "Label5"
        '
        'TxtSiteSTFNom
        '
        resources.ApplyResources(Me.TxtSiteSTFNom, "TxtSiteSTFNom")
        Me.TxtSiteSTFNom.Name = "TxtSiteSTFNom"
        Me.TxtSiteSTFNom.Properties.AccessibleDescription = resources.GetString("TxtSiteSTFNom.Properties.AccessibleDescription")
        Me.TxtSiteSTFNom.Properties.AccessibleName = resources.GetString("TxtSiteSTFNom.Properties.AccessibleName")
        Me.TxtSiteSTFNom.Properties.AutoHeight = CType(resources.GetObject("TxtSiteSTFNom.Properties.AutoHeight"), Boolean)
        Me.TxtSiteSTFNom.Properties.Mask.AutoComplete = CType(resources.GetObject("TxtSiteSTFNom.Properties.Mask.AutoComplete"), DevExpress.XtraEditors.Mask.AutoCompleteType)
        Me.TxtSiteSTFNom.Properties.Mask.BeepOnError = CType(resources.GetObject("TxtSiteSTFNom.Properties.Mask.BeepOnError"), Boolean)
        Me.TxtSiteSTFNom.Properties.Mask.EditMask = resources.GetString("TxtSiteSTFNom.Properties.Mask.EditMask")
        Me.TxtSiteSTFNom.Properties.Mask.IgnoreMaskBlank = CType(resources.GetObject("TxtSiteSTFNom.Properties.Mask.IgnoreMaskBlank"), Boolean)
        Me.TxtSiteSTFNom.Properties.Mask.MaskType = CType(resources.GetObject("TxtSiteSTFNom.Properties.Mask.MaskType"), DevExpress.XtraEditors.Mask.MaskType)
        Me.TxtSiteSTFNom.Properties.Mask.PlaceHolder = CType(resources.GetObject("TxtSiteSTFNom.Properties.Mask.PlaceHolder"), Char)
        Me.TxtSiteSTFNom.Properties.Mask.SaveLiteral = CType(resources.GetObject("TxtSiteSTFNom.Properties.Mask.SaveLiteral"), Boolean)
        Me.TxtSiteSTFNom.Properties.Mask.ShowPlaceHolders = CType(resources.GetObject("TxtSiteSTFNom.Properties.Mask.ShowPlaceHolders"), Boolean)
        Me.TxtSiteSTFNom.Properties.Mask.UseMaskAsDisplayFormat = CType(resources.GetObject("TxtSiteSTFNom.Properties.Mask.UseMaskAsDisplayFormat"), Boolean)
        Me.TxtSiteSTFNom.Properties.MaxLength = 40
        Me.TxtSiteSTFNom.Properties.NullValuePrompt = resources.GetString("TxtSiteSTFNom.Properties.NullValuePrompt")
        Me.TxtSiteSTFNom.Properties.NullValuePromptShowForEmptyValue = CType(resources.GetObject("TxtSiteSTFNom.Properties.NullValuePromptShowForEmptyValue"), Boolean)
        '
        'GridSITSTFPays
        '
        resources.ApplyResources(Me.GridSITSTFPays, "GridSITSTFPays")
        Me.GridSITSTFPays.Name = "GridSITSTFPays"
        Me.GridSITSTFPays.Properties.AccessibleDescription = resources.GetString("GridSITSTFPays.Properties.AccessibleDescription")
        Me.GridSITSTFPays.Properties.AccessibleName = resources.GetString("GridSITSTFPays.Properties.AccessibleName")
        Me.GridSITSTFPays.Properties.AutoHeight = CType(resources.GetObject("GridSITSTFPays.Properties.AutoHeight"), Boolean)
        Me.GridSITSTFPays.Properties.Buttons.AddRange(New DevExpress.XtraEditors.Controls.EditorButton() {New DevExpress.XtraEditors.Controls.EditorButton(CType(resources.GetObject("GridSITSTFPays.Properties.Buttons"), DevExpress.XtraEditors.Controls.ButtonPredefines))})
        Me.GridSITSTFPays.Properties.DisplayMember = "VPAYSNOM"
        Me.GridSITSTFPays.Properties.NullText = resources.GetString("GridSITSTFPays.Properties.NullText")
        Me.GridSITSTFPays.Properties.NullValuePrompt = resources.GetString("GridSITSTFPays.Properties.NullValuePrompt")
        Me.GridSITSTFPays.Properties.NullValuePromptShowForEmptyValue = CType(resources.GetObject("GridSITSTFPays.Properties.NullValuePromptShowForEmptyValue"), Boolean)
        Me.GridSITSTFPays.Properties.ValueMember = "NPAYSNUM"
        Me.GridSITSTFPays.Properties.View = Me.GridPays
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
        'Label12
        '
        resources.ApplyResources(Me.Label12, "Label12")
        Me.Label12.Name = "Label12"
        '
        'TxtVSITSTFCP
        '
        resources.ApplyResources(Me.TxtVSITSTFCP, "TxtVSITSTFCP")
        Me.TxtVSITSTFCP.Name = "TxtVSITSTFCP"
        '
        'TxtVSITSTFAD2
        '
        resources.ApplyResources(Me.TxtVSITSTFAD2, "TxtVSITSTFAD2")
        Me.TxtVSITSTFAD2.Name = "TxtVSITSTFAD2"
        '
        'TxtVSITSTFAD1
        '
        resources.ApplyResources(Me.TxtVSITSTFAD1, "TxtVSITSTFAD1")
        Me.TxtVSITSTFAD1.Name = "TxtVSITSTFAD1"
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
        'LblTitre
        '
        resources.ApplyResources(Me.LblTitre, "LblTitre")
        Me.LblTitre.ForeColor = System.Drawing.Color.IndianRed
        Me.LblTitre.Name = "LblTitre"
        '
        'Label2
        '
        resources.ApplyResources(Me.Label2, "Label2")
        Me.Label2.ForeColor = System.Drawing.Color.DarkGreen
        Me.Label2.Name = "Label2"
        '
        'Label13
        '
        resources.ApplyResources(Me.Label13, "Label13")
        Me.Label13.ForeColor = System.Drawing.Color.DarkGreen
        Me.Label13.Name = "Label13"
        '
        'TxtSITSTFCoutHor
        '
        resources.ApplyResources(Me.TxtSITSTFCoutHor, "TxtSITSTFCoutHor")
        Me.TxtSITSTFCoutHor.Name = "TxtSITSTFCoutHor"
        Me.TxtSITSTFCoutHor.Properties.AccessibleDescription = resources.GetString("TxtSITSTFCoutHor.Properties.AccessibleDescription")
        Me.TxtSITSTFCoutHor.Properties.AccessibleName = resources.GetString("TxtSITSTFCoutHor.Properties.AccessibleName")
        Me.TxtSITSTFCoutHor.Properties.Appearance.GradientMode = CType(resources.GetObject("TxtSITSTFCoutHor.Properties.Appearance.GradientMode"), System.Drawing.Drawing2D.LinearGradientMode)
        Me.TxtSITSTFCoutHor.Properties.Appearance.Image = CType(resources.GetObject("TxtSITSTFCoutHor.Properties.Appearance.Image"), System.Drawing.Image)
        Me.TxtSITSTFCoutHor.Properties.Appearance.Options.UseTextOptions = True
        Me.TxtSITSTFCoutHor.Properties.Appearance.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Far
        Me.TxtSITSTFCoutHor.Properties.AutoHeight = CType(resources.GetObject("TxtSITSTFCoutHor.Properties.AutoHeight"), Boolean)
        Me.TxtSITSTFCoutHor.Properties.Mask.AutoComplete = CType(resources.GetObject("TxtSITSTFCoutHor.Properties.Mask.AutoComplete"), DevExpress.XtraEditors.Mask.AutoCompleteType)
        Me.TxtSITSTFCoutHor.Properties.Mask.BeepOnError = CType(resources.GetObject("TxtSITSTFCoutHor.Properties.Mask.BeepOnError"), Boolean)
        Me.TxtSITSTFCoutHor.Properties.Mask.EditMask = resources.GetString("TxtSITSTFCoutHor.Properties.Mask.EditMask")
        Me.TxtSITSTFCoutHor.Properties.Mask.IgnoreMaskBlank = CType(resources.GetObject("TxtSITSTFCoutHor.Properties.Mask.IgnoreMaskBlank"), Boolean)
        Me.TxtSITSTFCoutHor.Properties.Mask.MaskType = CType(resources.GetObject("TxtSITSTFCoutHor.Properties.Mask.MaskType"), DevExpress.XtraEditors.Mask.MaskType)
        Me.TxtSITSTFCoutHor.Properties.Mask.PlaceHolder = CType(resources.GetObject("TxtSITSTFCoutHor.Properties.Mask.PlaceHolder"), Char)
        Me.TxtSITSTFCoutHor.Properties.Mask.SaveLiteral = CType(resources.GetObject("TxtSITSTFCoutHor.Properties.Mask.SaveLiteral"), Boolean)
        Me.TxtSITSTFCoutHor.Properties.Mask.ShowPlaceHolders = CType(resources.GetObject("TxtSITSTFCoutHor.Properties.Mask.ShowPlaceHolders"), Boolean)
        Me.TxtSITSTFCoutHor.Properties.Mask.UseMaskAsDisplayFormat = CType(resources.GetObject("TxtSITSTFCoutHor.Properties.Mask.UseMaskAsDisplayFormat"), Boolean)
        Me.TxtSITSTFCoutHor.Properties.NullValuePrompt = resources.GetString("TxtSITSTFCoutHor.Properties.NullValuePrompt")
        Me.TxtSITSTFCoutHor.Properties.NullValuePromptShowForEmptyValue = CType(resources.GetObject("TxtSITSTFCoutHor.Properties.NullValuePromptShowForEmptyValue"), Boolean)
        '
        'TxtSITSTFCoutDep
        '
        resources.ApplyResources(Me.TxtSITSTFCoutDep, "TxtSITSTFCoutDep")
        Me.TxtSITSTFCoutDep.Name = "TxtSITSTFCoutDep"
        Me.TxtSITSTFCoutDep.Properties.AccessibleDescription = resources.GetString("TxtSITSTFCoutDep.Properties.AccessibleDescription")
        Me.TxtSITSTFCoutDep.Properties.AccessibleName = resources.GetString("TxtSITSTFCoutDep.Properties.AccessibleName")
        Me.TxtSITSTFCoutDep.Properties.Appearance.GradientMode = CType(resources.GetObject("TxtSITSTFCoutDep.Properties.Appearance.GradientMode"), System.Drawing.Drawing2D.LinearGradientMode)
        Me.TxtSITSTFCoutDep.Properties.Appearance.Image = CType(resources.GetObject("TxtSITSTFCoutDep.Properties.Appearance.Image"), System.Drawing.Image)
        Me.TxtSITSTFCoutDep.Properties.Appearance.Options.UseTextOptions = True
        Me.TxtSITSTFCoutDep.Properties.Appearance.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Far
        Me.TxtSITSTFCoutDep.Properties.AutoHeight = CType(resources.GetObject("TxtSITSTFCoutDep.Properties.AutoHeight"), Boolean)
        Me.TxtSITSTFCoutDep.Properties.Mask.AutoComplete = CType(resources.GetObject("TxtSITSTFCoutDep.Properties.Mask.AutoComplete"), DevExpress.XtraEditors.Mask.AutoCompleteType)
        Me.TxtSITSTFCoutDep.Properties.Mask.BeepOnError = CType(resources.GetObject("TxtSITSTFCoutDep.Properties.Mask.BeepOnError"), Boolean)
        Me.TxtSITSTFCoutDep.Properties.Mask.EditMask = resources.GetString("TxtSITSTFCoutDep.Properties.Mask.EditMask")
        Me.TxtSITSTFCoutDep.Properties.Mask.IgnoreMaskBlank = CType(resources.GetObject("TxtSITSTFCoutDep.Properties.Mask.IgnoreMaskBlank"), Boolean)
        Me.TxtSITSTFCoutDep.Properties.Mask.MaskType = CType(resources.GetObject("TxtSITSTFCoutDep.Properties.Mask.MaskType"), DevExpress.XtraEditors.Mask.MaskType)
        Me.TxtSITSTFCoutDep.Properties.Mask.PlaceHolder = CType(resources.GetObject("TxtSITSTFCoutDep.Properties.Mask.PlaceHolder"), Char)
        Me.TxtSITSTFCoutDep.Properties.Mask.SaveLiteral = CType(resources.GetObject("TxtSITSTFCoutDep.Properties.Mask.SaveLiteral"), Boolean)
        Me.TxtSITSTFCoutDep.Properties.Mask.ShowPlaceHolders = CType(resources.GetObject("TxtSITSTFCoutDep.Properties.Mask.ShowPlaceHolders"), Boolean)
        Me.TxtSITSTFCoutDep.Properties.Mask.UseMaskAsDisplayFormat = CType(resources.GetObject("TxtSITSTFCoutDep.Properties.Mask.UseMaskAsDisplayFormat"), Boolean)
        Me.TxtSITSTFCoutDep.Properties.NullValuePrompt = resources.GetString("TxtSITSTFCoutDep.Properties.NullValuePrompt")
        Me.TxtSITSTFCoutDep.Properties.NullValuePromptShowForEmptyValue = CType(resources.GetObject("TxtSITSTFCoutDep.Properties.NullValuePromptShowForEmptyValue"), Boolean)
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
        'GridSITSTFLangue
        '
        resources.ApplyResources(Me.GridSITSTFLangue, "GridSITSTFLangue")
        Me.GridSITSTFLangue.Name = "GridSITSTFLangue"
        Me.GridSITSTFLangue.Properties.AccessibleDescription = resources.GetString("GridSITSTFLangue.Properties.AccessibleDescription")
        Me.GridSITSTFLangue.Properties.AccessibleName = resources.GetString("GridSITSTFLangue.Properties.AccessibleName")
        Me.GridSITSTFLangue.Properties.AutoHeight = CType(resources.GetObject("GridSITSTFLangue.Properties.AutoHeight"), Boolean)
        Me.GridSITSTFLangue.Properties.Buttons.AddRange(New DevExpress.XtraEditors.Controls.EditorButton() {New DevExpress.XtraEditors.Controls.EditorButton(CType(resources.GetObject("GridSITSTFLangue.Properties.Buttons"), DevExpress.XtraEditors.Controls.ButtonPredefines))})
        Me.GridSITSTFLangue.Properties.DisplayMember = "VLANGUEDEFAUT"
        Me.GridSITSTFLangue.Properties.NullText = resources.GetString("GridSITSTFLangue.Properties.NullText")
        Me.GridSITSTFLangue.Properties.NullValuePrompt = resources.GetString("GridSITSTFLangue.Properties.NullValuePrompt")
        Me.GridSITSTFLangue.Properties.NullValuePromptShowForEmptyValue = CType(resources.GetObject("GridSITSTFLangue.Properties.NullValuePromptShowForEmptyValue"), Boolean)
        Me.GridSITSTFLangue.Properties.ValueMember = "VLANGUEABR"
        Me.GridSITSTFLangue.Properties.View = Me.GridView1
        '
        'GridView1
        '
        resources.ApplyResources(Me.GridView1, "GridView1")
        Me.GridView1.Columns.AddRange(New DevExpress.XtraGrid.Columns.GridColumn() {Me.GridColumn1, Me.GridColumn2})
        Me.GridView1.FocusRectStyle = DevExpress.XtraGrid.Views.Grid.DrawFocusRectStyle.RowFocus
        Me.GridView1.Name = "GridView1"
        Me.GridView1.OptionsSelection.EnableAppearanceFocusedCell = False
        Me.GridView1.OptionsView.ShowAutoFilterRow = True
        Me.GridView1.OptionsView.ShowGroupPanel = False
        '
        'GridColumn1
        '
        resources.ApplyResources(Me.GridColumn1, "GridColumn1")
        Me.GridColumn1.FieldName = "VLANGUEABR"
        Me.GridColumn1.Name = "GridColumn1"
        '
        'GridColumn2
        '
        Me.GridColumn2.AppearanceHeader.Font = CType(resources.GetObject("GridColumn2.AppearanceHeader.Font"), System.Drawing.Font)
        Me.GridColumn2.AppearanceHeader.GradientMode = CType(resources.GetObject("GridColumn2.AppearanceHeader.GradientMode"), System.Drawing.Drawing2D.LinearGradientMode)
        Me.GridColumn2.AppearanceHeader.Image = CType(resources.GetObject("GridColumn2.AppearanceHeader.Image"), System.Drawing.Image)
        Me.GridColumn2.AppearanceHeader.Options.UseFont = True
        Me.GridColumn2.AppearanceHeader.Options.UseTextOptions = True
        Me.GridColumn2.AppearanceHeader.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center
        Me.GridColumn2.AppearanceHeader.TextOptions.VAlignment = DevExpress.Utils.VertAlignment.Center
        resources.ApplyResources(Me.GridColumn2, "GridColumn2")
        Me.GridColumn2.FieldName = "VLANGUEDEFAUT"
        Me.GridColumn2.Name = "GridColumn2"
        Me.GridColumn2.OptionsFilter.AutoFilterCondition = DevExpress.XtraGrid.Columns.AutoFilterCondition.Contains
        '
        'LblTitreLangue
        '
        resources.ApplyResources(Me.LblTitreLangue, "LblTitreLangue")
        Me.LblTitreLangue.ForeColor = System.Drawing.Color.DarkGreen
        Me.LblTitreLangue.Name = "LblTitreLangue"
        '
        'UCSiteSTF
        '
        resources.ApplyResources(Me, "$this")
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.DarkSeaGreen
        Me.Controls.Add(Me.GridSITSTFLangue)
        Me.Controls.Add(Me.LblTitreLangue)
        Me.Controls.Add(Me.Label15)
        Me.Controls.Add(Me.Label14)
        Me.Controls.Add(Me.TxtSITSTFCoutDep)
        Me.Controls.Add(Me.TxtSITSTFCoutHor)
        Me.Controls.Add(Me.Label13)
        Me.Controls.Add(Me.Label10)
        Me.Controls.Add(Me.GridSITSTFVille)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.GrpBoxCedex)
        Me.Controls.Add(Me.TxtSiteSTFNom)
        Me.Controls.Add(Me.GridSITSTFPays)
        Me.Controls.Add(Me.Label12)
        Me.Controls.Add(Me.TxtVSITSTFCP)
        Me.Controls.Add(Me.TxtVSITSTFAD2)
        Me.Controls.Add(Me.TxtVSITSTFAD1)
        Me.Controls.Add(Me.Label4)
        Me.Controls.Add(Me.Label3)
        Me.Controls.Add(Me.LblTitre)
        Me.Controls.Add(Me.Label2)
        Me.Name = "UCSiteSTF"
        CType(Me.GridSITSTFVille.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.GVVille, System.ComponentModel.ISupportInitialize).EndInit()
        Me.GrpBoxCedex.ResumeLayout(False)
        Me.GrpBoxCedex.PerformLayout()
        CType(Me.TxtSiteSTFNom.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.GridSITSTFPays.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.GridPays, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.TxtSITSTFCoutHor.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.TxtSITSTFCoutDep.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.GridSITSTFLangue.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.GridView1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents Label9 As System.Windows.Forms.Label
    Friend WithEvents Label10 As System.Windows.Forms.Label
    Friend WithEvents Label11 As System.Windows.Forms.Label
    Friend WithEvents Label7 As System.Windows.Forms.Label
    Friend WithEvents GridSITSTFVille As DevExpress.XtraEditors.GridLookUpEdit
    Friend WithEvents GVVille As DevExpress.XtraGrid.Views.Grid.GridView
    Friend WithEvents GColCommune As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents GColCODEPOSTAL As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents GColNPAYSNUM As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents TxtVSITSTFCPCedex As System.Windows.Forms.TextBox
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents GrpBoxCedex As System.Windows.Forms.GroupBox
    Friend WithEvents TxtVSITSTFCEDEX As System.Windows.Forms.TextBox
    Friend WithEvents Label5 As System.Windows.Forms.Label
    Friend WithEvents TxtSiteSTFNom As DevExpress.XtraEditors.TextEdit
    Friend WithEvents GridSITSTFPays As DevExpress.XtraEditors.GridLookUpEdit
    Friend WithEvents GridPays As DevExpress.XtraGrid.Views.Grid.GridView
    Friend WithEvents GColVPAYSNOM As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents Label12 As System.Windows.Forms.Label
    Friend WithEvents TxtVSITSTFCP As System.Windows.Forms.TextBox
    Friend WithEvents TxtVSITSTFAD2 As System.Windows.Forms.TextBox
    Friend WithEvents TxtVSITSTFAD1 As System.Windows.Forms.TextBox
    Friend WithEvents Label4 As System.Windows.Forms.Label
    Friend WithEvents Label3 As System.Windows.Forms.Label
    Friend WithEvents LblTitre As System.Windows.Forms.Label
    Friend WithEvents Label2 As System.Windows.Forms.Label
    Friend WithEvents Label13 As System.Windows.Forms.Label
    Friend WithEvents TxtSITSTFCoutHor As DevExpress.XtraEditors.TextEdit
    Friend WithEvents TxtSITSTFCoutDep As DevExpress.XtraEditors.TextEdit
    Friend WithEvents Label14 As System.Windows.Forms.Label
    Friend WithEvents Label15 As System.Windows.Forms.Label
    Friend WithEvents GridSITSTFLangue As DevExpress.XtraEditors.GridLookUpEdit
    Friend WithEvents GridView1 As DevExpress.XtraGrid.Views.Grid.GridView
    Friend WithEvents GridColumn1 As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents GridColumn2 As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents LblTitreLangue As System.Windows.Forms.Label

End Class
