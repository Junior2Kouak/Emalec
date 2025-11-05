<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmSuiviLectureMessages
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
    Me.GColNum = New DevExpress.XtraGrid.Columns.GridColumn()
    Me.GColDate = New DevExpress.XtraGrid.Columns.GridColumn()
    Me.GColAut = New DevExpress.XtraGrid.Columns.GridColumn()
    Me.GrpListe = New System.Windows.Forms.GroupBox()
    Me.GCListeFouEI = New DevExpress.XtraGrid.GridControl()
    Me.GVlisteFouEI = New DevExpress.XtraGrid.Views.Grid.GridView()
    Me.GColLecteur = New DevExpress.XtraGrid.Columns.GridColumn()
    Me.GColDatLec = New DevExpress.XtraGrid.Columns.GridColumn()
    Me.GColLib = New DevExpress.XtraGrid.Columns.GridColumn()
    Me.GrpActions = New System.Windows.Forms.GroupBox()
    Me.BtnFermer = New System.Windows.Forms.Button()
    Me.OFD = New System.Windows.Forms.OpenFileDialog()
    Me.GrpListe.SuspendLayout()
    CType(Me.GCListeFouEI, System.ComponentModel.ISupportInitialize).BeginInit()
    CType(Me.GVlisteFouEI, System.ComponentModel.ISupportInitialize).BeginInit()
    Me.GrpActions.SuspendLayout()
    Me.SuspendLayout()
    '
    'GColNum
    '
    Me.GColNum.Caption = "N°"
    Me.GColNum.FieldName = "NINFONUM"
    Me.GColNum.Name = "GColNum"
    Me.GColNum.OptionsColumn.AllowEdit = False
    Me.GColNum.OptionsColumn.ReadOnly = True
    Me.GColNum.OptionsFilter.AutoFilterCondition = DevExpress.XtraGrid.Columns.AutoFilterCondition.Contains
    Me.GColNum.Visible = True
    Me.GColNum.VisibleIndex = 0
    '
    'GColDate
    '
    Me.GColDate.Caption = "Date création"
    Me.GColDate.FieldName = "DINFODAT"
    Me.GColDate.Name = "GColDate"
    Me.GColDate.OptionsFilter.AutoFilterCondition = DevExpress.XtraGrid.Columns.AutoFilterCondition.Contains
    Me.GColDate.Visible = True
    Me.GColDate.VisibleIndex = 1
    Me.GColDate.Width = 104
    '
    'GColAut
    '
    Me.GColAut.Caption = "Auteur"
    Me.GColAut.FieldName = "AUTEUR"
    Me.GColAut.Name = "GColAut"
    Me.GColAut.Visible = True
    Me.GColAut.VisibleIndex = 2
    Me.GColAut.Width = 103
    '
    'GrpListe
    '
    Me.GrpListe.Controls.Add(Me.GCListeFouEI)
    Me.GrpListe.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Bold)
    Me.GrpListe.Location = New System.Drawing.Point(205, 13)
    Me.GrpListe.Margin = New System.Windows.Forms.Padding(4)
    Me.GrpListe.Name = "GrpListe"
    Me.GrpListe.Padding = New System.Windows.Forms.Padding(4)
    Me.GrpListe.Size = New System.Drawing.Size(1433, 804)
    Me.GrpListe.TabIndex = 8
    Me.GrpListe.TabStop = False
    Me.GrpListe.Text = "Liste de suivi des messages Mozart"
    '
    'GCListeFouEI
    '
    Me.GCListeFouEI.Dock = System.Windows.Forms.DockStyle.Fill
    Me.GCListeFouEI.EmbeddedNavigator.Margin = New System.Windows.Forms.Padding(4)
    Me.GCListeFouEI.Location = New System.Drawing.Point(4, 23)
    Me.GCListeFouEI.MainView = Me.GVlisteFouEI
    Me.GCListeFouEI.Margin = New System.Windows.Forms.Padding(4)
    Me.GCListeFouEI.Name = "GCListeFouEI"
    Me.GCListeFouEI.Size = New System.Drawing.Size(1425, 777)
    Me.GCListeFouEI.TabIndex = 0
    Me.GCListeFouEI.ViewCollection.AddRange(New DevExpress.XtraGrid.Views.Base.BaseView() {Me.GVlisteFouEI})
    '
    'GVlisteFouEI
    '
    Me.GVlisteFouEI.Appearance.ColumnFilterButton.BackColor = System.Drawing.Color.FromArgb(CType(CType(104, Byte), Integer), CType(CType(184, Byte), Integer), CType(CType(251, Byte), Integer))
    Me.GVlisteFouEI.Appearance.ColumnFilterButton.BorderColor = System.Drawing.Color.FromArgb(CType(CType(104, Byte), Integer), CType(CType(184, Byte), Integer), CType(CType(251, Byte), Integer))
    Me.GVlisteFouEI.Appearance.ColumnFilterButton.ForeColor = System.Drawing.Color.White
    Me.GVlisteFouEI.Appearance.ColumnFilterButton.Options.UseBackColor = True
    Me.GVlisteFouEI.Appearance.ColumnFilterButton.Options.UseBorderColor = True
    Me.GVlisteFouEI.Appearance.ColumnFilterButton.Options.UseForeColor = True
    Me.GVlisteFouEI.Appearance.ColumnFilterButtonActive.BackColor = System.Drawing.Color.FromArgb(CType(CType(170, Byte), Integer), CType(CType(216, Byte), Integer), CType(CType(254, Byte), Integer))
    Me.GVlisteFouEI.Appearance.ColumnFilterButtonActive.BorderColor = System.Drawing.Color.FromArgb(CType(CType(170, Byte), Integer), CType(CType(216, Byte), Integer), CType(CType(254, Byte), Integer))
    Me.GVlisteFouEI.Appearance.ColumnFilterButtonActive.ForeColor = System.Drawing.Color.Black
    Me.GVlisteFouEI.Appearance.ColumnFilterButtonActive.Options.UseBackColor = True
    Me.GVlisteFouEI.Appearance.ColumnFilterButtonActive.Options.UseBorderColor = True
    Me.GVlisteFouEI.Appearance.ColumnFilterButtonActive.Options.UseForeColor = True
    Me.GVlisteFouEI.Appearance.Empty.BackColor = System.Drawing.Color.FromArgb(CType(CType(236, Byte), Integer), CType(CType(246, Byte), Integer), CType(CType(255, Byte), Integer))
    Me.GVlisteFouEI.Appearance.Empty.BackColor2 = System.Drawing.Color.White
    Me.GVlisteFouEI.Appearance.Empty.Options.UseBackColor = True
    Me.GVlisteFouEI.Appearance.EvenRow.BackColor = System.Drawing.Color.FromArgb(CType(CType(247, Byte), Integer), CType(CType(251, Byte), Integer), CType(CType(255, Byte), Integer))
    Me.GVlisteFouEI.Appearance.EvenRow.BorderColor = System.Drawing.Color.FromArgb(CType(CType(247, Byte), Integer), CType(CType(251, Byte), Integer), CType(CType(255, Byte), Integer))
    Me.GVlisteFouEI.Appearance.EvenRow.ForeColor = System.Drawing.Color.Black
    Me.GVlisteFouEI.Appearance.EvenRow.Options.UseBackColor = True
    Me.GVlisteFouEI.Appearance.EvenRow.Options.UseBorderColor = True
    Me.GVlisteFouEI.Appearance.EvenRow.Options.UseForeColor = True
    Me.GVlisteFouEI.Appearance.FilterCloseButton.BackColor = System.Drawing.Color.FromArgb(CType(CType(104, Byte), Integer), CType(CType(184, Byte), Integer), CType(CType(251, Byte), Integer))
    Me.GVlisteFouEI.Appearance.FilterCloseButton.BorderColor = System.Drawing.Color.FromArgb(CType(CType(104, Byte), Integer), CType(CType(184, Byte), Integer), CType(CType(251, Byte), Integer))
    Me.GVlisteFouEI.Appearance.FilterCloseButton.ForeColor = System.Drawing.Color.White
    Me.GVlisteFouEI.Appearance.FilterCloseButton.Options.UseBackColor = True
    Me.GVlisteFouEI.Appearance.FilterCloseButton.Options.UseBorderColor = True
    Me.GVlisteFouEI.Appearance.FilterCloseButton.Options.UseForeColor = True
    Me.GVlisteFouEI.Appearance.FilterPanel.BackColor = System.Drawing.Color.FromArgb(CType(CType(236, Byte), Integer), CType(CType(246, Byte), Integer), CType(CType(255, Byte), Integer))
    Me.GVlisteFouEI.Appearance.FilterPanel.BackColor2 = System.Drawing.Color.White
    Me.GVlisteFouEI.Appearance.FilterPanel.ForeColor = System.Drawing.Color.Black
    Me.GVlisteFouEI.Appearance.FilterPanel.Options.UseBackColor = True
    Me.GVlisteFouEI.Appearance.FilterPanel.Options.UseForeColor = True
    Me.GVlisteFouEI.Appearance.FixedLine.BackColor = System.Drawing.Color.FromArgb(CType(CType(59, Byte), Integer), CType(CType(133, Byte), Integer), CType(CType(195, Byte), Integer))
    Me.GVlisteFouEI.Appearance.FixedLine.Options.UseBackColor = True
    Me.GVlisteFouEI.Appearance.FocusedCell.BackColor = System.Drawing.Color.White
    Me.GVlisteFouEI.Appearance.FocusedCell.ForeColor = System.Drawing.Color.Black
    Me.GVlisteFouEI.Appearance.FocusedCell.Options.UseBackColor = True
    Me.GVlisteFouEI.Appearance.FocusedCell.Options.UseForeColor = True
    Me.GVlisteFouEI.Appearance.FocusedRow.BackColor = System.Drawing.Color.FromArgb(CType(CType(38, Byte), Integer), CType(CType(109, Byte), Integer), CType(CType(189, Byte), Integer))
    Me.GVlisteFouEI.Appearance.FocusedRow.BorderColor = System.Drawing.Color.FromArgb(CType(CType(59, Byte), Integer), CType(CType(139, Byte), Integer), CType(CType(206, Byte), Integer))
    Me.GVlisteFouEI.Appearance.FocusedRow.ForeColor = System.Drawing.Color.White
    Me.GVlisteFouEI.Appearance.FocusedRow.Options.UseBackColor = True
    Me.GVlisteFouEI.Appearance.FocusedRow.Options.UseBorderColor = True
    Me.GVlisteFouEI.Appearance.FocusedRow.Options.UseForeColor = True
    Me.GVlisteFouEI.Appearance.FooterPanel.BackColor = System.Drawing.Color.FromArgb(CType(CType(104, Byte), Integer), CType(CType(184, Byte), Integer), CType(CType(251, Byte), Integer))
    Me.GVlisteFouEI.Appearance.FooterPanel.BorderColor = System.Drawing.Color.FromArgb(CType(CType(104, Byte), Integer), CType(CType(184, Byte), Integer), CType(CType(251, Byte), Integer))
    Me.GVlisteFouEI.Appearance.FooterPanel.ForeColor = System.Drawing.Color.Black
    Me.GVlisteFouEI.Appearance.FooterPanel.Options.UseBackColor = True
    Me.GVlisteFouEI.Appearance.FooterPanel.Options.UseBorderColor = True
    Me.GVlisteFouEI.Appearance.FooterPanel.Options.UseForeColor = True
    Me.GVlisteFouEI.Appearance.GroupButton.BackColor = System.Drawing.Color.FromArgb(CType(CType(104, Byte), Integer), CType(CType(184, Byte), Integer), CType(CType(251, Byte), Integer))
    Me.GVlisteFouEI.Appearance.GroupButton.BorderColor = System.Drawing.Color.FromArgb(CType(CType(104, Byte), Integer), CType(CType(184, Byte), Integer), CType(CType(251, Byte), Integer))
    Me.GVlisteFouEI.Appearance.GroupButton.Options.UseBackColor = True
    Me.GVlisteFouEI.Appearance.GroupButton.Options.UseBorderColor = True
    Me.GVlisteFouEI.Appearance.GroupFooter.BackColor = System.Drawing.Color.FromArgb(CType(CType(170, Byte), Integer), CType(CType(216, Byte), Integer), CType(CType(254, Byte), Integer))
    Me.GVlisteFouEI.Appearance.GroupFooter.BorderColor = System.Drawing.Color.FromArgb(CType(CType(170, Byte), Integer), CType(CType(216, Byte), Integer), CType(CType(254, Byte), Integer))
    Me.GVlisteFouEI.Appearance.GroupFooter.ForeColor = System.Drawing.Color.Black
    Me.GVlisteFouEI.Appearance.GroupFooter.Options.UseBackColor = True
    Me.GVlisteFouEI.Appearance.GroupFooter.Options.UseBorderColor = True
    Me.GVlisteFouEI.Appearance.GroupFooter.Options.UseForeColor = True
    Me.GVlisteFouEI.Appearance.GroupPanel.BackColor = System.Drawing.Color.FromArgb(CType(CType(236, Byte), Integer), CType(CType(246, Byte), Integer), CType(CType(255, Byte), Integer))
    Me.GVlisteFouEI.Appearance.GroupPanel.BackColor2 = System.Drawing.Color.White
    Me.GVlisteFouEI.Appearance.GroupPanel.ForeColor = System.Drawing.Color.Black
    Me.GVlisteFouEI.Appearance.GroupPanel.Options.UseBackColor = True
    Me.GVlisteFouEI.Appearance.GroupPanel.Options.UseForeColor = True
    Me.GVlisteFouEI.Appearance.GroupRow.BackColor = System.Drawing.Color.FromArgb(CType(CType(170, Byte), Integer), CType(CType(216, Byte), Integer), CType(CType(254, Byte), Integer))
    Me.GVlisteFouEI.Appearance.GroupRow.BorderColor = System.Drawing.Color.FromArgb(CType(CType(170, Byte), Integer), CType(CType(216, Byte), Integer), CType(CType(254, Byte), Integer))
    Me.GVlisteFouEI.Appearance.GroupRow.ForeColor = System.Drawing.Color.Black
    Me.GVlisteFouEI.Appearance.GroupRow.Options.UseBackColor = True
    Me.GVlisteFouEI.Appearance.GroupRow.Options.UseBorderColor = True
    Me.GVlisteFouEI.Appearance.GroupRow.Options.UseForeColor = True
    Me.GVlisteFouEI.Appearance.HeaderPanel.BackColor = System.Drawing.Color.FromArgb(CType(CType(139, Byte), Integer), CType(CType(201, Byte), Integer), CType(CType(254, Byte), Integer))
    Me.GVlisteFouEI.Appearance.HeaderPanel.BorderColor = System.Drawing.Color.FromArgb(CType(CType(139, Byte), Integer), CType(CType(201, Byte), Integer), CType(CType(254, Byte), Integer))
    Me.GVlisteFouEI.Appearance.HeaderPanel.ForeColor = System.Drawing.Color.Black
    Me.GVlisteFouEI.Appearance.HeaderPanel.Options.UseBackColor = True
    Me.GVlisteFouEI.Appearance.HeaderPanel.Options.UseBorderColor = True
    Me.GVlisteFouEI.Appearance.HeaderPanel.Options.UseForeColor = True
    Me.GVlisteFouEI.Appearance.HideSelectionRow.BackColor = System.Drawing.Color.FromArgb(CType(CType(105, Byte), Integer), CType(CType(170, Byte), Integer), CType(CType(225, Byte), Integer))
    Me.GVlisteFouEI.Appearance.HideSelectionRow.BorderColor = System.Drawing.Color.FromArgb(CType(CType(83, Byte), Integer), CType(CType(155, Byte), Integer), CType(CType(215, Byte), Integer))
    Me.GVlisteFouEI.Appearance.HideSelectionRow.ForeColor = System.Drawing.Color.FromArgb(CType(CType(236, Byte), Integer), CType(CType(246, Byte), Integer), CType(CType(255, Byte), Integer))
    Me.GVlisteFouEI.Appearance.HideSelectionRow.Options.UseBackColor = True
    Me.GVlisteFouEI.Appearance.HideSelectionRow.Options.UseBorderColor = True
    Me.GVlisteFouEI.Appearance.HideSelectionRow.Options.UseForeColor = True
    Me.GVlisteFouEI.Appearance.HorzLine.BackColor = System.Drawing.Color.FromArgb(CType(CType(104, Byte), Integer), CType(CType(184, Byte), Integer), CType(CType(251, Byte), Integer))
    Me.GVlisteFouEI.Appearance.HorzLine.Options.UseBackColor = True
    Me.GVlisteFouEI.Appearance.OddRow.BackColor = System.Drawing.Color.FromArgb(CType(CType(236, Byte), Integer), CType(CType(246, Byte), Integer), CType(CType(255, Byte), Integer))
    Me.GVlisteFouEI.Appearance.OddRow.BorderColor = System.Drawing.Color.FromArgb(CType(CType(236, Byte), Integer), CType(CType(246, Byte), Integer), CType(CType(255, Byte), Integer))
    Me.GVlisteFouEI.Appearance.OddRow.ForeColor = System.Drawing.Color.Black
    Me.GVlisteFouEI.Appearance.OddRow.Options.UseBackColor = True
    Me.GVlisteFouEI.Appearance.OddRow.Options.UseBorderColor = True
    Me.GVlisteFouEI.Appearance.OddRow.Options.UseForeColor = True
    Me.GVlisteFouEI.Appearance.Preview.Font = New System.Drawing.Font("Verdana", 7.5!)
    Me.GVlisteFouEI.Appearance.Preview.ForeColor = System.Drawing.Color.FromArgb(CType(CType(83, Byte), Integer), CType(CType(155, Byte), Integer), CType(CType(215, Byte), Integer))
    Me.GVlisteFouEI.Appearance.Preview.Options.UseFont = True
    Me.GVlisteFouEI.Appearance.Preview.Options.UseForeColor = True
    Me.GVlisteFouEI.Appearance.Row.BackColor = System.Drawing.Color.FromArgb(CType(CType(247, Byte), Integer), CType(CType(251, Byte), Integer), CType(CType(255, Byte), Integer))
    Me.GVlisteFouEI.Appearance.Row.ForeColor = System.Drawing.Color.Black
    Me.GVlisteFouEI.Appearance.Row.Options.UseBackColor = True
    Me.GVlisteFouEI.Appearance.Row.Options.UseForeColor = True
    Me.GVlisteFouEI.Appearance.RowSeparator.BackColor = System.Drawing.Color.FromArgb(CType(CType(236, Byte), Integer), CType(CType(246, Byte), Integer), CType(CType(255, Byte), Integer))
    Me.GVlisteFouEI.Appearance.RowSeparator.BackColor2 = System.Drawing.Color.White
    Me.GVlisteFouEI.Appearance.RowSeparator.Options.UseBackColor = True
    Me.GVlisteFouEI.Appearance.SelectedRow.BackColor = System.Drawing.Color.FromArgb(CType(CType(83, Byte), Integer), CType(CType(155, Byte), Integer), CType(CType(215, Byte), Integer))
    Me.GVlisteFouEI.Appearance.SelectedRow.ForeColor = System.Drawing.Color.White
    Me.GVlisteFouEI.Appearance.SelectedRow.Options.UseBackColor = True
    Me.GVlisteFouEI.Appearance.SelectedRow.Options.UseForeColor = True
    Me.GVlisteFouEI.Appearance.TopNewRow.BackColor = System.Drawing.Color.White
    Me.GVlisteFouEI.Appearance.TopNewRow.Options.UseBackColor = True
    Me.GVlisteFouEI.Appearance.VertLine.BackColor = System.Drawing.Color.FromArgb(CType(CType(104, Byte), Integer), CType(CType(184, Byte), Integer), CType(CType(251, Byte), Integer))
    Me.GVlisteFouEI.Appearance.VertLine.Options.UseBackColor = True
    Me.GVlisteFouEI.Columns.AddRange(New DevExpress.XtraGrid.Columns.GridColumn() {Me.GColNum, Me.GColDate, Me.GColAut, Me.GColLecteur, Me.GColDatLec, Me.GColLib})
    Me.GVlisteFouEI.GridControl = Me.GCListeFouEI
    Me.GVlisteFouEI.Name = "GVlisteFouEI"
    Me.GVlisteFouEI.OptionsBehavior.Editable = False
    Me.GVlisteFouEI.OptionsBehavior.ReadOnly = True
    Me.GVlisteFouEI.OptionsView.EnableAppearanceEvenRow = True
    Me.GVlisteFouEI.OptionsView.EnableAppearanceOddRow = True
    Me.GVlisteFouEI.OptionsView.ShowAutoFilterRow = True
    Me.GVlisteFouEI.OptionsView.ShowGroupPanel = False
    '
    'GColLecteur
    '
    Me.GColLecteur.Caption = "Lecteur"
    Me.GColLecteur.FieldName = "LECTEUR"
    Me.GColLecteur.Name = "GColLecteur"
    Me.GColLecteur.Visible = True
    Me.GColLecteur.VisibleIndex = 3
    Me.GColLecteur.Width = 138
    '
    'GColDatLec
    '
    Me.GColDatLec.Caption = "Date lecture"
    Me.GColDatLec.DisplayFormat.FormatString = "dd/MM/yyyy HH:mm"
    Me.GColDatLec.DisplayFormat.FormatType = DevExpress.Utils.FormatType.DateTime
    Me.GColDatLec.FieldName = "DINFOLEC"
    Me.GColDatLec.Name = "GColDatLec"
    Me.GColDatLec.Visible = True
    Me.GColDatLec.VisibleIndex = 4
    Me.GColDatLec.Width = 150
    '
    'GColLib
    '
    Me.GColLib.Caption = "Message"
    Me.GColLib.FieldName = "VINFOTEXTE"
    Me.GColLib.Name = "GColLib"
    Me.GColLib.OptionsFilter.AutoFilterCondition = DevExpress.XtraGrid.Columns.AutoFilterCondition.Contains
    Me.GColLib.Visible = True
    Me.GColLib.VisibleIndex = 5
    Me.GColLib.Width = 835
    '
    'GrpActions
    '
    Me.GrpActions.Controls.Add(Me.BtnFermer)
    Me.GrpActions.Location = New System.Drawing.Point(9, 13)
    Me.GrpActions.Margin = New System.Windows.Forms.Padding(4)
    Me.GrpActions.Name = "GrpActions"
    Me.GrpActions.Padding = New System.Windows.Forms.Padding(4)
    Me.GrpActions.Size = New System.Drawing.Size(188, 804)
    Me.GrpActions.TabIndex = 7
    Me.GrpActions.TabStop = False
    '
    'BtnFermer
    '
    Me.BtnFermer.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold)
    Me.BtnFermer.ImeMode = System.Windows.Forms.ImeMode.NoControl
    Me.BtnFermer.Location = New System.Drawing.Point(8, 746)
    Me.BtnFermer.Margin = New System.Windows.Forms.Padding(4)
    Me.BtnFermer.Name = "BtnFermer"
    Me.BtnFermer.Size = New System.Drawing.Size(172, 50)
    Me.BtnFermer.TabIndex = 1
    Me.BtnFermer.Text = "Fermer"
    Me.BtnFermer.UseVisualStyleBackColor = True
    '
    'frmSuiviLectureMessages
    '
    Me.AutoScaleDimensions = New System.Drawing.SizeF(8.0!, 16.0!)
    Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
    Me.BackColor = System.Drawing.Color.Wheat
    Me.ClientSize = New System.Drawing.Size(1863, 1051)
    Me.Controls.Add(Me.GrpListe)
    Me.Controls.Add(Me.GrpActions)
    Me.Name = "frmSuiviLectureMessages"
    Me.Text = "Liste de suivi des messages Mozart"
    Me.WindowState = System.Windows.Forms.FormWindowState.Maximized
    Me.GrpListe.ResumeLayout(False)
    CType(Me.GCListeFouEI, System.ComponentModel.ISupportInitialize).EndInit()
    CType(Me.GVlisteFouEI, System.ComponentModel.ISupportInitialize).EndInit()
    Me.GrpActions.ResumeLayout(False)
    Me.ResumeLayout(False)

  End Sub
  Private WithEvents GColNum As DevExpress.XtraGrid.Columns.GridColumn
  Private WithEvents GColDate As DevExpress.XtraGrid.Columns.GridColumn
  Private WithEvents GColAut As DevExpress.XtraGrid.Columns.GridColumn
  Friend WithEvents GrpListe As System.Windows.Forms.GroupBox
  Private WithEvents GCListeFouEI As DevExpress.XtraGrid.GridControl
  Private WithEvents GVlisteFouEI As DevExpress.XtraGrid.Views.Grid.GridView
  Private WithEvents GColLib As DevExpress.XtraGrid.Columns.GridColumn
  Friend WithEvents GrpActions As System.Windows.Forms.GroupBox
  Friend WithEvents BtnFermer As System.Windows.Forms.Button
  Friend WithEvents OFD As System.Windows.Forms.OpenFileDialog
  Friend WithEvents GColLecteur As DevExpress.XtraGrid.Columns.GridColumn
  Friend WithEvents GColDatLec As DevExpress.XtraGrid.Columns.GridColumn
End Class
