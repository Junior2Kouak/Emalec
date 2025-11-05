<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmListeActionsR_AND_D
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
        Me.GCListeAct = New DevExpress.XtraGrid.GridControl()
        Me.GVListeAct = New DevExpress.XtraGrid.Views.Grid.GridView()
        Me.GCol_NDINNUM = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.GCol_VACTDES = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.GCol_DACTDEX = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.GCol_NACTDUR = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.GCol_VTECHNOM = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.GCol_TAUX = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.GCol_MTT = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.BtValider = New System.Windows.Forms.Button()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.GrpActions = New System.Windows.Forms.GroupBox()
        Me.BtnFermer = New System.Windows.Forms.Button()
        Me.LblTitre = New System.Windows.Forms.Label()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.DTP_Debut = New System.Windows.Forms.DateTimePicker()
        Me.DTP_Fin = New System.Windows.Forms.DateTimePicker()
        CType(Me.GCListeAct, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.GVListeAct, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.GrpActions.SuspendLayout()
        Me.SuspendLayout()
        '
        'GCListeAct
        '
        Me.GCListeAct.Location = New System.Drawing.Point(116, 115)
        Me.GCListeAct.MainView = Me.GVListeAct
        Me.GCListeAct.Name = "GCListeAct"
        Me.GCListeAct.Size = New System.Drawing.Size(1359, 753)
        Me.GCListeAct.TabIndex = 83
        Me.GCListeAct.ViewCollection.AddRange(New DevExpress.XtraGrid.Views.Base.BaseView() {Me.GVListeAct})
        '
        'GVListeAct
        '
        Me.GVListeAct.Appearance.HeaderPanel.Font = New System.Drawing.Font("Tahoma", 8.25!, System.Drawing.FontStyle.Bold)
        Me.GVListeAct.Appearance.HeaderPanel.Options.UseFont = True
        Me.GVListeAct.Appearance.HeaderPanel.Options.UseTextOptions = True
        Me.GVListeAct.Appearance.HeaderPanel.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center
        Me.GVListeAct.Appearance.HeaderPanel.TextOptions.VAlignment = DevExpress.Utils.VertAlignment.Center
        Me.GVListeAct.Appearance.HeaderPanel.TextOptions.WordWrap = DevExpress.Utils.WordWrap.Wrap
        Me.GVListeAct.ColumnPanelRowHeight = 60
        Me.GVListeAct.Columns.AddRange(New DevExpress.XtraGrid.Columns.GridColumn() {Me.GCol_NDINNUM, Me.GCol_VACTDES, Me.GCol_DACTDEX, Me.GCol_NACTDUR, Me.GCol_VTECHNOM, Me.GCol_TAUX, Me.GCol_MTT})
        Me.GVListeAct.GridControl = Me.GCListeAct
        Me.GVListeAct.Name = "GVListeAct"
        Me.GVListeAct.OptionsBehavior.Editable = False
        Me.GVListeAct.OptionsBehavior.ReadOnly = True
        Me.GVListeAct.OptionsView.ShowAutoFilterRow = True
        Me.GVListeAct.OptionsView.ShowFooter = True
        Me.GVListeAct.OptionsView.ShowGroupPanel = False
        '
        'GCol_NDINNUM
        '
        Me.GCol_NDINNUM.AppearanceCell.Options.UseTextOptions = True
        Me.GCol_NDINNUM.AppearanceCell.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center
        Me.GCol_NDINNUM.AppearanceCell.TextOptions.VAlignment = DevExpress.Utils.VertAlignment.Center
        Me.GCol_NDINNUM.AppearanceHeader.ForeColor = System.Drawing.Color.Black
        Me.GCol_NDINNUM.AppearanceHeader.Options.UseForeColor = True
        Me.GCol_NDINNUM.Caption = "N° Action"
        Me.GCol_NDINNUM.FieldName = "NDINNUM"
        Me.GCol_NDINNUM.Name = "GCol_NDINNUM"
        Me.GCol_NDINNUM.Summary.AddRange(New DevExpress.XtraGrid.GridSummaryItem() {New DevExpress.XtraGrid.GridColumnSummaryItem(DevExpress.Data.SummaryItemType.Custom, "NDINNUM", "Total de la période")})
        Me.GCol_NDINNUM.Visible = True
        Me.GCol_NDINNUM.VisibleIndex = 0
        Me.GCol_NDINNUM.Width = 150
        '
        'GCol_VACTDES
        '
        Me.GCol_VACTDES.AppearanceHeader.ForeColor = System.Drawing.Color.Black
        Me.GCol_VACTDES.AppearanceHeader.Options.UseForeColor = True
        Me.GCol_VACTDES.Caption = "Sujet"
        Me.GCol_VACTDES.FieldName = "VACTDES"
        Me.GCol_VACTDES.Name = "GCol_VACTDES"
        Me.GCol_VACTDES.Visible = True
        Me.GCol_VACTDES.VisibleIndex = 1
        Me.GCol_VACTDES.Width = 400
        '
        'GCol_DACTDEX
        '
        Me.GCol_DACTDEX.AppearanceCell.Options.UseTextOptions = True
        Me.GCol_DACTDEX.AppearanceCell.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center
        Me.GCol_DACTDEX.AppearanceCell.TextOptions.VAlignment = DevExpress.Utils.VertAlignment.Center
        Me.GCol_DACTDEX.AppearanceHeader.ForeColor = System.Drawing.Color.Black
        Me.GCol_DACTDEX.AppearanceHeader.Options.UseForeColor = True
        Me.GCol_DACTDEX.Caption = "Date d'exécution"
        Me.GCol_DACTDEX.FieldName = "DACTDEX"
        Me.GCol_DACTDEX.Name = "GCol_DACTDEX"
        Me.GCol_DACTDEX.Visible = True
        Me.GCol_DACTDEX.VisibleIndex = 2
        Me.GCol_DACTDEX.Width = 120
        '
        'GCol_NACTDUR
        '
        Me.GCol_NACTDUR.AppearanceCell.Options.UseTextOptions = True
        Me.GCol_NACTDUR.AppearanceCell.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center
        Me.GCol_NACTDUR.AppearanceCell.TextOptions.VAlignment = DevExpress.Utils.VertAlignment.Center
        Me.GCol_NACTDUR.AppearanceHeader.ForeColor = System.Drawing.Color.Black
        Me.GCol_NACTDUR.AppearanceHeader.Options.UseForeColor = True
        Me.GCol_NACTDUR.Caption = "Nbr Heures"
        Me.GCol_NACTDUR.FieldName = "NACTDUR"
        Me.GCol_NACTDUR.Name = "GCol_NACTDUR"
        Me.GCol_NACTDUR.Summary.AddRange(New DevExpress.XtraGrid.GridSummaryItem() {New DevExpress.XtraGrid.GridColumnSummaryItem(DevExpress.Data.SummaryItemType.Sum, "NACTDUR", "{0:0.##}")})
        Me.GCol_NACTDUR.Visible = True
        Me.GCol_NACTDUR.VisibleIndex = 3
        Me.GCol_NACTDUR.Width = 163
        '
        'GCol_VTECHNOM
        '
        Me.GCol_VTECHNOM.AppearanceCell.Options.UseTextOptions = True
        Me.GCol_VTECHNOM.AppearanceCell.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center
        Me.GCol_VTECHNOM.AppearanceCell.TextOptions.VAlignment = DevExpress.Utils.VertAlignment.Center
        Me.GCol_VTECHNOM.AppearanceHeader.ForeColor = System.Drawing.Color.Black
        Me.GCol_VTECHNOM.AppearanceHeader.Options.UseForeColor = True
        Me.GCol_VTECHNOM.Caption = "Exécutant"
        Me.GCol_VTECHNOM.FieldName = "VTECHNOM"
        Me.GCol_VTECHNOM.Name = "GCol_VTECHNOM"
        Me.GCol_VTECHNOM.Visible = True
        Me.GCol_VTECHNOM.VisibleIndex = 4
        Me.GCol_VTECHNOM.Width = 163
        '
        'GCol_TAUX
        '
        Me.GCol_TAUX.AppearanceCell.Options.UseTextOptions = True
        Me.GCol_TAUX.AppearanceCell.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center
        Me.GCol_TAUX.AppearanceCell.TextOptions.VAlignment = DevExpress.Utils.VertAlignment.Center
        Me.GCol_TAUX.AppearanceHeader.ForeColor = System.Drawing.Color.Black
        Me.GCol_TAUX.AppearanceHeader.Options.UseForeColor = True
        Me.GCol_TAUX.Caption = "Taux horaire HT de l'exécutant"
        Me.GCol_TAUX.DisplayFormat.FormatString = "{0:0}"
        Me.GCol_TAUX.DisplayFormat.FormatType = DevExpress.Utils.FormatType.Numeric
        Me.GCol_TAUX.FieldName = "TAUX"
        Me.GCol_TAUX.Name = "GCol_TAUX"
        Me.GCol_TAUX.Visible = True
        Me.GCol_TAUX.VisibleIndex = 5
        Me.GCol_TAUX.Width = 163
        '
        'GCol_MTT
        '
        Me.GCol_MTT.AppearanceCell.Options.UseTextOptions = True
        Me.GCol_MTT.AppearanceCell.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center
        Me.GCol_MTT.AppearanceCell.TextOptions.VAlignment = DevExpress.Utils.VertAlignment.Center
        Me.GCol_MTT.AppearanceHeader.ForeColor = System.Drawing.Color.Black
        Me.GCol_MTT.AppearanceHeader.Options.UseForeColor = True
        Me.GCol_MTT.Caption = "Montant HT"
        Me.GCol_MTT.DisplayFormat.FormatString = "{0:0.##}"
        Me.GCol_MTT.DisplayFormat.FormatType = DevExpress.Utils.FormatType.Numeric
        Me.GCol_MTT.FieldName = "MTT"
        Me.GCol_MTT.Name = "GCol_MTT"
        Me.GCol_MTT.Summary.AddRange(New DevExpress.XtraGrid.GridSummaryItem() {New DevExpress.XtraGrid.GridColumnSummaryItem(DevExpress.Data.SummaryItemType.Sum, "MTT", "{0:0.##}")})
        Me.GCol_MTT.Visible = True
        Me.GCol_MTT.VisibleIndex = 6
        Me.GCol_MTT.Width = 182
        '
        'BtValider
        '
        Me.BtValider.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold)
        Me.BtValider.ImeMode = System.Windows.Forms.ImeMode.NoControl
        Me.BtValider.Location = New System.Drawing.Point(725, 74)
        Me.BtValider.Name = "BtValider"
        Me.BtValider.Size = New System.Drawing.Size(75, 31)
        Me.BtValider.TabIndex = 82
        Me.BtValider.Text = "Valider"
        Me.BtValider.UseVisualStyleBackColor = True
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Font = New System.Drawing.Font("Arial", 12.0!, System.Drawing.FontStyle.Bold)
        Me.Label3.ImeMode = System.Windows.Forms.ImeMode.NoControl
        Me.Label3.Location = New System.Drawing.Point(462, 79)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(28, 19)
        Me.Label3.TabIndex = 77
        Me.Label3.Text = "au"
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Font = New System.Drawing.Font("Arial", 12.0!, System.Drawing.FontStyle.Bold)
        Me.Label2.ImeMode = System.Windows.Forms.ImeMode.NoControl
        Me.Label2.Location = New System.Drawing.Point(112, 79)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(78, 19)
        Me.Label2.TabIndex = 76
        Me.Label2.Text = "Période :"
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Font = New System.Drawing.Font("Arial", 12.0!, System.Drawing.FontStyle.Bold)
        Me.Label1.ImeMode = System.Windows.Forms.ImeMode.NoControl
        Me.Label1.Location = New System.Drawing.Point(206, 79)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(31, 19)
        Me.Label1.TabIndex = 75
        Me.Label1.Text = "Du"
        '
        'GrpActions
        '
        Me.GrpActions.Controls.Add(Me.BtnFermer)
        Me.GrpActions.Location = New System.Drawing.Point(12, 169)
        Me.GrpActions.Name = "GrpActions"
        Me.GrpActions.Size = New System.Drawing.Size(89, 699)
        Me.GrpActions.TabIndex = 73
        Me.GrpActions.TabStop = False
        '
        'BtnFermer
        '
        Me.BtnFermer.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold)
        Me.BtnFermer.ImeMode = System.Windows.Forms.ImeMode.NoControl
        Me.BtnFermer.Location = New System.Drawing.Point(6, 635)
        Me.BtnFermer.Name = "BtnFermer"
        Me.BtnFermer.Size = New System.Drawing.Size(75, 48)
        Me.BtnFermer.TabIndex = 1
        Me.BtnFermer.Text = "Fermer"
        Me.BtnFermer.UseVisualStyleBackColor = True
        '
        'LblTitre
        '
        Me.LblTitre.AutoSize = True
        Me.LblTitre.Font = New System.Drawing.Font("Arial", 12.0!, System.Drawing.FontStyle.Bold)
        Me.LblTitre.ImeMode = System.Windows.Forms.ImeMode.NoControl
        Me.LblTitre.Location = New System.Drawing.Point(112, 43)
        Me.LblTitre.Name = "LblTitre"
        Me.LblTitre.Size = New System.Drawing.Size(238, 19)
        Me.LblTitre.TabIndex = 74
        Me.LblTitre.Text = "Titre : Actions de gestion R&&D"
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Font = New System.Drawing.Font("Arial", 12.0!, System.Drawing.FontStyle.Bold)
        Me.Label4.ImeMode = System.Windows.Forms.ImeMode.NoControl
        Me.Label4.Location = New System.Drawing.Point(112, 9)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(104, 19)
        Me.Label4.TabIndex = 84
        Me.Label4.Text = "Filiale : MPM"
        '
        'DTP_Debut
        '
        Me.DTP_Debut.Location = New System.Drawing.Point(256, 77)
        Me.DTP_Debut.Name = "DTP_Debut"
        Me.DTP_Debut.Size = New System.Drawing.Size(200, 20)
        Me.DTP_Debut.TabIndex = 85
        '
        'DTP_Fin
        '
        Me.DTP_Fin.Location = New System.Drawing.Point(507, 77)
        Me.DTP_Fin.Name = "DTP_Fin"
        Me.DTP_Fin.Size = New System.Drawing.Size(200, 20)
        Me.DTP_Fin.TabIndex = 86
        '
        'frmListeActionsR_AND_D
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.Wheat
        Me.ClientSize = New System.Drawing.Size(1714, 947)
        Me.Controls.Add(Me.DTP_Fin)
        Me.Controls.Add(Me.DTP_Debut)
        Me.Controls.Add(Me.Label4)
        Me.Controls.Add(Me.GCListeAct)
        Me.Controls.Add(Me.BtValider)
        Me.Controls.Add(Me.Label3)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.GrpActions)
        Me.Controls.Add(Me.LblTitre)
        Me.Name = "frmListeActionsR_AND_D"
        Me.Text = "Actions de gestion R&D"
        Me.WindowState = System.Windows.Forms.FormWindowState.Maximized
        CType(Me.GCListeAct, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.GVListeAct, System.ComponentModel.ISupportInitialize).EndInit()
        Me.GrpActions.ResumeLayout(False)
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Private WithEvents GCListeAct As DevExpress.XtraGrid.GridControl
    Private WithEvents GVListeAct As DevExpress.XtraGrid.Views.Grid.GridView
    Private WithEvents GCol_NDINNUM As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents BtValider As Button
    Friend WithEvents Label3 As Label
    Friend WithEvents Label2 As Label
    Friend WithEvents Label1 As Label
    Friend WithEvents GrpActions As GroupBox
    Friend WithEvents BtnFermer As Button
    Friend WithEvents LblTitre As Label
    Friend WithEvents Label4 As Label
    Friend WithEvents GCol_VACTDES As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents GCol_DACTDEX As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents GCol_NACTDUR As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents GCol_VTECHNOM As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents GCol_TAUX As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents GCol_MTT As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents DTP_Debut As DateTimePicker
    Friend WithEvents DTP_Fin As DateTimePicker
End Class
