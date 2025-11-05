Imports System.Windows.Forms

<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class apiTBandedGrid
    Inherits System.Windows.Forms.UserControl

    'UserControl remplace la méthode Dispose pour nettoyer la liste des composants.
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
    Me.components = New System.ComponentModel.Container()
    Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(apiTBandedGrid))
    Dim GridLevelNode1 As DevExpress.XtraGrid.GridLevelNode = New DevExpress.XtraGrid.GridLevelNode()
    Me.GridControl = New DevExpress.XtraGrid.GridControl()
    Me.dgv = New DevExpress.XtraGrid.Views.BandedGrid.BandedGridView()
    Me.RepositoryItemCheckEdit1 = New DevExpress.XtraEditors.Repository.RepositoryItemCheckEdit()
    Me.RepositoryItemComboBox1 = New DevExpress.XtraEditors.Repository.RepositoryItemComboBox()
    Me.ToolTipController1 = New DevExpress.Utils.ToolTipController(Me.components)
    Me.lblRowCount = New System.Windows.Forms.Label()
    Me.btnPrint = New DevExpress.XtraEditors.SimpleButton()
    Me.chkColumnsList = New DevExpress.XtraEditors.CheckedComboBoxEdit()
    Me.btnExcel = New DevExpress.XtraEditors.SimpleButton()
    Me.cmdTelAuto = New DevExpress.XtraEditors.SimpleButton()
    CType(Me.GridControl, System.ComponentModel.ISupportInitialize).BeginInit()
    CType(Me.dgv, System.ComponentModel.ISupportInitialize).BeginInit()
    CType(Me.RepositoryItemCheckEdit1, System.ComponentModel.ISupportInitialize).BeginInit()
    CType(Me.RepositoryItemComboBox1, System.ComponentModel.ISupportInitialize).BeginInit()
    CType(Me.chkColumnsList.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
    Me.SuspendLayout()
    '
    'GridControl
    '
    resources.ApplyResources(Me.GridControl, "GridControl")
    GridLevelNode1.RelationName = "Level1"
    Me.GridControl.LevelTree.Nodes.AddRange(New DevExpress.XtraGrid.GridLevelNode() {GridLevelNode1})
    Me.GridControl.LookAndFeel.SkinName = "Office 2016 Colorful"
    Me.GridControl.LookAndFeel.Style = DevExpress.LookAndFeel.LookAndFeelStyle.Style3D
    Me.GridControl.LookAndFeel.UseDefaultLookAndFeel = False
    Me.GridControl.MainView = Me.dgv
    Me.GridControl.Name = "GridControl"
    Me.GridControl.RepositoryItems.AddRange(New DevExpress.XtraEditors.Repository.RepositoryItem() {Me.RepositoryItemCheckEdit1, Me.RepositoryItemComboBox1})
    Me.GridControl.ToolTipController = Me.ToolTipController1
    Me.GridControl.ViewCollection.AddRange(New DevExpress.XtraGrid.Views.Base.BaseView() {Me.dgv})
    '
    'dgv
    '
    Me.dgv.Appearance.BandPanel.BackColor = System.Drawing.Color.FromArgb(CType(CType(216, Byte), Integer), CType(CType(209, Byte), Integer), CType(CType(170, Byte), Integer))
    Me.dgv.Appearance.BandPanel.BorderColor = System.Drawing.Color.FromArgb(CType(CType(216, Byte), Integer), CType(CType(209, Byte), Integer), CType(CType(170, Byte), Integer))
    Me.dgv.Appearance.BandPanel.ForeColor = System.Drawing.Color.Black
    Me.dgv.Appearance.BandPanel.Options.UseBackColor = True
    Me.dgv.Appearance.BandPanel.Options.UseBorderColor = True
    Me.dgv.Appearance.BandPanel.Options.UseForeColor = True
    Me.dgv.Appearance.ColumnFilterButton.BackColor = System.Drawing.Color.FromArgb(CType(CType(236, Byte), Integer), CType(CType(232, Byte), Integer), CType(CType(201, Byte), Integer))
    Me.dgv.Appearance.ColumnFilterButton.BorderColor = System.Drawing.Color.FromArgb(CType(CType(236, Byte), Integer), CType(CType(232, Byte), Integer), CType(CType(201, Byte), Integer))
    Me.dgv.Appearance.ColumnFilterButton.ForeColor = System.Drawing.Color.Black
    Me.dgv.Appearance.ColumnFilterButton.Options.UseBackColor = True
    Me.dgv.Appearance.ColumnFilterButton.Options.UseBorderColor = True
    Me.dgv.Appearance.ColumnFilterButton.Options.UseForeColor = True
    Me.dgv.Appearance.ColumnFilterButtonActive.BackColor = System.Drawing.Color.FromArgb(CType(CType(221, Byte), Integer), CType(CType(231, Byte), Integer), CType(CType(234, Byte), Integer))
    Me.dgv.Appearance.ColumnFilterButtonActive.BorderColor = System.Drawing.Color.FromArgb(CType(CType(221, Byte), Integer), CType(CType(231, Byte), Integer), CType(CType(234, Byte), Integer))
    Me.dgv.Appearance.ColumnFilterButtonActive.ForeColor = System.Drawing.Color.Black
    Me.dgv.Appearance.ColumnFilterButtonActive.Options.UseBackColor = True
    Me.dgv.Appearance.ColumnFilterButtonActive.Options.UseBorderColor = True
    Me.dgv.Appearance.ColumnFilterButtonActive.Options.UseForeColor = True
    Me.dgv.Appearance.Empty.BackColor = System.Drawing.Color.FromArgb(CType(CType(236, Byte), Integer), CType(CType(232, Byte), Integer), CType(CType(201, Byte), Integer))
    Me.dgv.Appearance.Empty.Options.UseBackColor = True
    Me.dgv.Appearance.EvenRow.BackColor = System.Drawing.Color.FromArgb(CType(CType(221, Byte), Integer), CType(CType(231, Byte), Integer), CType(CType(234, Byte), Integer))
    Me.dgv.Appearance.EvenRow.BorderColor = System.Drawing.Color.FromArgb(CType(CType(221, Byte), Integer), CType(CType(231, Byte), Integer), CType(CType(234, Byte), Integer))
    Me.dgv.Appearance.EvenRow.ForeColor = System.Drawing.Color.Black
    Me.dgv.Appearance.EvenRow.Options.UseBackColor = True
    Me.dgv.Appearance.EvenRow.Options.UseBorderColor = True
    Me.dgv.Appearance.EvenRow.Options.UseForeColor = True
    Me.dgv.Appearance.FilterCloseButton.BackColor = System.Drawing.Color.FromArgb(CType(CType(216, Byte), Integer), CType(CType(209, Byte), Integer), CType(CType(179, Byte), Integer))
    Me.dgv.Appearance.FilterCloseButton.BorderColor = System.Drawing.Color.FromArgb(CType(CType(216, Byte), Integer), CType(CType(209, Byte), Integer), CType(CType(179, Byte), Integer))
    Me.dgv.Appearance.FilterCloseButton.ForeColor = System.Drawing.Color.Black
    Me.dgv.Appearance.FilterCloseButton.Options.UseBackColor = True
    Me.dgv.Appearance.FilterCloseButton.Options.UseBorderColor = True
    Me.dgv.Appearance.FilterCloseButton.Options.UseForeColor = True
    Me.dgv.Appearance.FilterPanel.BackColor = System.Drawing.Color.FromArgb(CType(CType(236, Byte), Integer), CType(CType(232, Byte), Integer), CType(CType(201, Byte), Integer))
    Me.dgv.Appearance.FilterPanel.ForeColor = System.Drawing.Color.Black
    Me.dgv.Appearance.FilterPanel.Options.UseBackColor = True
    Me.dgv.Appearance.FilterPanel.Options.UseForeColor = True
    Me.dgv.Appearance.FixedLine.BackColor = System.Drawing.Color.FromArgb(CType(CType(122, Byte), Integer), CType(CType(114, Byte), Integer), CType(CType(113, Byte), Integer))
    Me.dgv.Appearance.FixedLine.Options.UseBackColor = True
    Me.dgv.Appearance.FocusedCell.BackColor = System.Drawing.Color.White
    Me.dgv.Appearance.FocusedCell.ForeColor = System.Drawing.Color.Black
    Me.dgv.Appearance.FocusedCell.Options.UseBackColor = True
    Me.dgv.Appearance.FocusedCell.Options.UseForeColor = True
    Me.dgv.Appearance.FocusedRow.BackColor = System.Drawing.Color.FromArgb(CType(CType(200, Byte), Integer), CType(CType(192, Byte), Integer), CType(CType(157, Byte), Integer))
    Me.dgv.Appearance.FocusedRow.BorderColor = System.Drawing.Color.FromArgb(CType(CType(226, Byte), Integer), CType(CType(219, Byte), Integer), CType(CType(188, Byte), Integer))
    Me.dgv.Appearance.FocusedRow.ForeColor = System.Drawing.Color.Black
    Me.dgv.Appearance.FocusedRow.Options.UseBackColor = True
    Me.dgv.Appearance.FocusedRow.Options.UseBorderColor = True
    Me.dgv.Appearance.FocusedRow.Options.UseForeColor = True
    Me.dgv.Appearance.FooterPanel.BackColor = System.Drawing.Color.FromArgb(CType(CType(216, Byte), Integer), CType(CType(209, Byte), Integer), CType(CType(170, Byte), Integer))
    Me.dgv.Appearance.FooterPanel.BorderColor = System.Drawing.Color.FromArgb(CType(CType(216, Byte), Integer), CType(CType(209, Byte), Integer), CType(CType(170, Byte), Integer))
    Me.dgv.Appearance.FooterPanel.ForeColor = System.Drawing.Color.Black
    Me.dgv.Appearance.FooterPanel.Options.UseBackColor = True
    Me.dgv.Appearance.FooterPanel.Options.UseBorderColor = True
    Me.dgv.Appearance.FooterPanel.Options.UseForeColor = True
    Me.dgv.Appearance.GroupButton.BackColor = System.Drawing.Color.FromArgb(CType(CType(216, Byte), Integer), CType(CType(209, Byte), Integer), CType(CType(179, Byte), Integer))
    Me.dgv.Appearance.GroupButton.BorderColor = System.Drawing.Color.FromArgb(CType(CType(216, Byte), Integer), CType(CType(209, Byte), Integer), CType(CType(179, Byte), Integer))
    Me.dgv.Appearance.GroupButton.Options.UseBackColor = True
    Me.dgv.Appearance.GroupButton.Options.UseBorderColor = True
    Me.dgv.Appearance.GroupFooter.BackColor = System.Drawing.Color.FromArgb(CType(CType(236, Byte), Integer), CType(CType(232, Byte), Integer), CType(CType(201, Byte), Integer))
    Me.dgv.Appearance.GroupFooter.BorderColor = System.Drawing.Color.FromArgb(CType(CType(236, Byte), Integer), CType(CType(232, Byte), Integer), CType(CType(201, Byte), Integer))
    Me.dgv.Appearance.GroupFooter.ForeColor = System.Drawing.Color.Black
    Me.dgv.Appearance.GroupFooter.Options.UseBackColor = True
    Me.dgv.Appearance.GroupFooter.Options.UseBorderColor = True
    Me.dgv.Appearance.GroupFooter.Options.UseForeColor = True
    Me.dgv.Appearance.GroupPanel.BackColor = System.Drawing.Color.FromArgb(CType(CType(246, Byte), Integer), CType(CType(242, Byte), Integer), CType(CType(213, Byte), Integer))
    Me.dgv.Appearance.GroupPanel.ForeColor = System.Drawing.Color.Black
    Me.dgv.Appearance.GroupPanel.Options.UseBackColor = True
    Me.dgv.Appearance.GroupPanel.Options.UseForeColor = True
    Me.dgv.Appearance.GroupRow.BackColor = System.Drawing.Color.FromArgb(CType(CType(236, Byte), Integer), CType(CType(232, Byte), Integer), CType(CType(201, Byte), Integer))
    Me.dgv.Appearance.GroupRow.BorderColor = System.Drawing.Color.FromArgb(CType(CType(236, Byte), Integer), CType(CType(232, Byte), Integer), CType(CType(201, Byte), Integer))
    Me.dgv.Appearance.GroupRow.ForeColor = System.Drawing.Color.Black
    Me.dgv.Appearance.GroupRow.Options.UseBackColor = True
    Me.dgv.Appearance.GroupRow.Options.UseBorderColor = True
    Me.dgv.Appearance.GroupRow.Options.UseForeColor = True
    Me.dgv.Appearance.HeaderPanel.BackColor = System.Drawing.Color.FromArgb(CType(CType(216, Byte), Integer), CType(CType(209, Byte), Integer), CType(CType(170, Byte), Integer))
    Me.dgv.Appearance.HeaderPanel.BorderColor = System.Drawing.Color.FromArgb(CType(CType(216, Byte), Integer), CType(CType(209, Byte), Integer), CType(CType(170, Byte), Integer))
    Me.dgv.Appearance.HeaderPanel.ForeColor = System.Drawing.Color.Black
    Me.dgv.Appearance.HeaderPanel.Options.UseBackColor = True
    Me.dgv.Appearance.HeaderPanel.Options.UseBorderColor = True
    Me.dgv.Appearance.HeaderPanel.Options.UseFont = True
    Me.dgv.Appearance.HeaderPanel.Options.UseForeColor = True
    Me.dgv.Appearance.HeaderPanel.Options.UseTextOptions = True
    Me.dgv.Appearance.HeaderPanel.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center
    Me.dgv.Appearance.HideSelectionRow.BackColor = System.Drawing.Color.FromArgb(CType(CType(237, Byte), Integer), CType(CType(230, Byte), Integer), CType(CType(203, Byte), Integer))
    Me.dgv.Appearance.HideSelectionRow.BorderColor = System.Drawing.Color.FromArgb(CType(CType(237, Byte), Integer), CType(CType(230, Byte), Integer), CType(CType(203, Byte), Integer))
    Me.dgv.Appearance.HideSelectionRow.ForeColor = System.Drawing.Color.Black
    Me.dgv.Appearance.HideSelectionRow.Options.UseBackColor = True
    Me.dgv.Appearance.HideSelectionRow.Options.UseBorderColor = True
    Me.dgv.Appearance.HideSelectionRow.Options.UseForeColor = True
    Me.dgv.Appearance.HorzLine.BackColor = System.Drawing.Color.FromArgb(CType(CType(216, Byte), Integer), CType(CType(209, Byte), Integer), CType(CType(170, Byte), Integer))
    Me.dgv.Appearance.HorzLine.Options.UseBackColor = True
    Me.dgv.Appearance.OddRow.BackColor = System.Drawing.Color.FromArgb(CType(CType(242, Byte), Integer), CType(CType(244, Byte), Integer), CType(CType(236, Byte), Integer))
    Me.dgv.Appearance.OddRow.BorderColor = System.Drawing.Color.FromArgb(CType(CType(242, Byte), Integer), CType(CType(244, Byte), Integer), CType(CType(236, Byte), Integer))
    Me.dgv.Appearance.OddRow.ForeColor = System.Drawing.Color.Black
    Me.dgv.Appearance.OddRow.Options.UseBackColor = True
    Me.dgv.Appearance.OddRow.Options.UseBorderColor = True
    Me.dgv.Appearance.OddRow.Options.UseForeColor = True
    Me.dgv.Appearance.Preview.BackColor = System.Drawing.Color.FromArgb(CType(CType(251, Byte), Integer), CType(CType(252, Byte), Integer), CType(CType(247, Byte), Integer))
    Me.dgv.Appearance.Preview.ForeColor = System.Drawing.Color.FromArgb(CType(CType(148, Byte), Integer), CType(CType(148, Byte), Integer), CType(CType(148, Byte), Integer))
    Me.dgv.Appearance.Preview.Options.UseBackColor = True
    Me.dgv.Appearance.Preview.Options.UseFont = True
    Me.dgv.Appearance.Preview.Options.UseForeColor = True
    Me.dgv.Appearance.Row.BackColor = System.Drawing.Color.FromArgb(CType(CType(242, Byte), Integer), CType(CType(244, Byte), Integer), CType(CType(236, Byte), Integer))
    Me.dgv.Appearance.Row.ForeColor = System.Drawing.Color.Black
    Me.dgv.Appearance.Row.Options.UseBackColor = True
    Me.dgv.Appearance.Row.Options.UseForeColor = True
    Me.dgv.Appearance.RowSeparator.BackColor = System.Drawing.Color.FromArgb(CType(CType(236, Byte), Integer), CType(CType(232, Byte), Integer), CType(CType(201, Byte), Integer))
    Me.dgv.Appearance.RowSeparator.Options.UseBackColor = True
    Me.dgv.Appearance.SelectedRow.BackColor = System.Drawing.Color.FromArgb(CType(CType(221, Byte), Integer), CType(CType(215, Byte), Integer), CType(CType(188, Byte), Integer))
    Me.dgv.Appearance.SelectedRow.BorderColor = System.Drawing.Color.FromArgb(CType(CType(237, Byte), Integer), CType(CType(230, Byte), Integer), CType(CType(203, Byte), Integer))
    Me.dgv.Appearance.SelectedRow.ForeColor = System.Drawing.Color.Black
    Me.dgv.Appearance.SelectedRow.Options.UseBackColor = True
    Me.dgv.Appearance.SelectedRow.Options.UseBorderColor = True
    Me.dgv.Appearance.SelectedRow.Options.UseForeColor = True
    Me.dgv.Appearance.TopNewRow.BackColor = System.Drawing.Color.White
    Me.dgv.Appearance.TopNewRow.Options.UseBackColor = True
    Me.dgv.Appearance.VertLine.BackColor = System.Drawing.Color.FromArgb(CType(CType(216, Byte), Integer), CType(CType(209, Byte), Integer), CType(CType(170, Byte), Integer))
    Me.dgv.Appearance.VertLine.Options.UseBackColor = True
    Me.dgv.GridControl = Me.GridControl
    Me.dgv.IndicatorWidth = 20
    Me.dgv.Name = "dgv"
    Me.dgv.OptionsBehavior.AutoPopulateColumns = False
    Me.dgv.OptionsBehavior.EditingMode = DevExpress.XtraGrid.Views.Grid.GridEditingMode.Inplace
    Me.dgv.OptionsSelection.MultiSelect = True
    Me.dgv.OptionsView.EnableAppearanceEvenRow = True
    Me.dgv.OptionsView.EnableAppearanceOddRow = True
    Me.dgv.OptionsView.ShowAutoFilterRow = True
    Me.dgv.OptionsView.ShowFilterPanelMode = DevExpress.XtraGrid.Views.Base.ShowFilterPanelMode.Never
    Me.dgv.OptionsView.ShowFooter = True
    Me.dgv.OptionsView.ShowGroupPanel = False
    '
    'RepositoryItemCheckEdit1
    '
    resources.ApplyResources(Me.RepositoryItemCheckEdit1, "RepositoryItemCheckEdit1")
    Me.RepositoryItemCheckEdit1.Name = "RepositoryItemCheckEdit1"
    '
    'RepositoryItemComboBox1
    '
    resources.ApplyResources(Me.RepositoryItemComboBox1, "RepositoryItemComboBox1")
    Me.RepositoryItemComboBox1.Buttons.AddRange(New DevExpress.XtraEditors.Controls.EditorButton() {New DevExpress.XtraEditors.Controls.EditorButton(CType(resources.GetObject("RepositoryItemComboBox1.Buttons"), DevExpress.XtraEditors.Controls.ButtonPredefines))})
    Me.RepositoryItemComboBox1.Name = "RepositoryItemComboBox1"
    '
    'ToolTipController1
    '
    Me.ToolTipController1.AutoPopDelay = 600000
    '
    'lblRowCount
    '
    resources.ApplyResources(Me.lblRowCount, "lblRowCount")
    Me.lblRowCount.BackColor = System.Drawing.Color.FromArgb(CType(CType(216, Byte), Integer), CType(CType(209, Byte), Integer), CType(CType(170, Byte), Integer))
    Me.lblRowCount.Name = "lblRowCount"
    '
    'btnPrint
    '
    resources.ApplyResources(Me.btnPrint, "btnPrint")
    Me.btnPrint.Appearance.BackColor = System.Drawing.Color.Transparent
    Me.btnPrint.Appearance.Options.UseBackColor = True
    Me.btnPrint.Name = "btnPrint"
    '
    'chkColumnsList
    '
    resources.ApplyResources(Me.chkColumnsList, "chkColumnsList")
    Me.chkColumnsList.Name = "chkColumnsList"
    Me.chkColumnsList.Properties.Appearance.BackColor = System.Drawing.Color.FromArgb(CType(CType(216, Byte), Integer), CType(CType(209, Byte), Integer), CType(CType(170, Byte), Integer))
    Me.chkColumnsList.Properties.Appearance.Options.UseBackColor = True
    Me.chkColumnsList.Properties.Buttons.AddRange(New DevExpress.XtraEditors.Controls.EditorButton() {New DevExpress.XtraEditors.Controls.EditorButton(CType(resources.GetObject("chkColumnsList.Properties.Buttons"), DevExpress.XtraEditors.Controls.ButtonPredefines))})
    Me.chkColumnsList.Properties.DropDownRows = 25
    Me.chkColumnsList.Properties.Mask.EditMask = resources.GetString("chkColumnsList.Properties.Mask.EditMask")
    Me.chkColumnsList.Properties.NullValuePrompt = resources.GetString("chkColumnsList.Properties.NullValuePrompt")
    '
    'btnExcel
    '
    resources.ApplyResources(Me.btnExcel, "btnExcel")
    Me.btnExcel.Appearance.BackColor = System.Drawing.Color.Transparent
    Me.btnExcel.Appearance.Options.UseBackColor = True
    Me.btnExcel.Name = "btnExcel"
    '
    'cmdTelAuto
    '
    resources.ApplyResources(Me.cmdTelAuto, "cmdTelAuto")
    Me.cmdTelAuto.Appearance.BackColor = System.Drawing.Color.Coral
    Me.cmdTelAuto.Appearance.ForeColor = System.Drawing.Color.Black
    Me.cmdTelAuto.Appearance.Options.UseBackColor = True
    Me.cmdTelAuto.Appearance.Options.UseForeColor = True
    Me.cmdTelAuto.ButtonStyle = DevExpress.XtraEditors.Controls.BorderStyles.Style3D
    Me.cmdTelAuto.Name = "cmdTelAuto"
    '
    'apiTBandedGrid
    '
    resources.ApplyResources(Me, "$this")
    Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
    Me.Controls.Add(Me.cmdTelAuto)
    Me.Controls.Add(Me.btnExcel)
    Me.Controls.Add(Me.btnPrint)
    Me.Controls.Add(Me.chkColumnsList)
    Me.Controls.Add(Me.lblRowCount)
    Me.Controls.Add(Me.GridControl)
    Me.Name = "apiTBandedGrid"
    CType(Me.GridControl, System.ComponentModel.ISupportInitialize).EndInit()
    CType(Me.dgv, System.ComponentModel.ISupportInitialize).EndInit()
    CType(Me.RepositoryItemCheckEdit1, System.ComponentModel.ISupportInitialize).EndInit()
    CType(Me.RepositoryItemComboBox1, System.ComponentModel.ISupportInitialize).EndInit()
    CType(Me.chkColumnsList.Properties, System.ComponentModel.ISupportInitialize).EndInit()
    Me.ResumeLayout(False)

  End Sub

  Public WithEvents GridControl As DevExpress.XtraGrid.GridControl
    Friend WithEvents RepositoryItemCheckEdit1 As DevExpress.XtraEditors.Repository.RepositoryItemCheckEdit
    Friend WithEvents RepositoryItemComboBox1 As DevExpress.XtraEditors.Repository.RepositoryItemComboBox
    Friend WithEvents ToolTipController1 As DevExpress.Utils.ToolTipController
    Public WithEvents btnPrint As DevExpress.XtraEditors.SimpleButton
    Public WithEvents btnExcel As DevExpress.XtraEditors.SimpleButton
    Public WithEvents lblRowCount As Label
    Public WithEvents chkColumnsList As DevExpress.XtraEditors.CheckedComboBoxEdit
    Public WithEvents cmdTelAuto As DevExpress.XtraEditors.SimpleButton
    Public WithEvents dgv As DevExpress.XtraGrid.Views.BandedGrid.BandedGridView
End Class
