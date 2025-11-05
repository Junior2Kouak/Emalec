<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmStatTauxSousTraitance
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
        Dim XyDiagram1 As DevExpress.XtraCharts.XYDiagram = New DevExpress.XtraCharts.XYDiagram()
        Dim ConstantLine1 As DevExpress.XtraCharts.ConstantLine = New DevExpress.XtraCharts.ConstantLine()
        Dim Series1 As DevExpress.XtraCharts.Series = New DevExpress.XtraCharts.Series()
        Dim SideBySideBarSeriesLabel1 As DevExpress.XtraCharts.SideBySideBarSeriesLabel = New DevExpress.XtraCharts.SideBySideBarSeriesLabel()
        Dim SideBySideBarSeriesView1 As DevExpress.XtraCharts.SideBySideBarSeriesView = New DevExpress.XtraCharts.SideBySideBarSeriesView()
        Dim RegressionLine1 As DevExpress.XtraCharts.RegressionLine = New DevExpress.XtraCharts.RegressionLine()
        Dim SideBySideBarSeriesLabel2 As DevExpress.XtraCharts.SideBySideBarSeriesLabel = New DevExpress.XtraCharts.SideBySideBarSeriesLabel()
        Dim ChartTitle1 As DevExpress.XtraCharts.ChartTitle = New DevExpress.XtraCharts.ChartTitle()
        Me.GrpActions = New System.Windows.Forms.GroupBox()
        Me.BtnFermer = New System.Windows.Forms.Button()
        Me.BtnPrint = New System.Windows.Forms.Button()
        Me.LblTitre = New System.Windows.Forms.Label()
        Me.GrpPer = New System.Windows.Forms.GroupBox()
        Me.ChartBas = New DevExpress.XtraCharts.ChartControl()
        Me.GrpFilter = New System.Windows.Forms.GroupBox()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.BtValider = New System.Windows.Forms.Button()
        Me.ComboBox1 = New System.Windows.Forms.ComboBox()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.ChkOutFrance = New System.Windows.Forms.CheckBox()
        Me.ChkFR = New System.Windows.Forms.CheckBox()
        Me.ChkTous = New System.Windows.Forms.CheckBox()
        Me.ChkMTT = New System.Windows.Forms.CheckBox()
        Me.ChkNB = New System.Windows.Forms.CheckBox()
        Me.Label25 = New System.Windows.Forms.Label()
        Me.Label26 = New System.Windows.Forms.Label()
        Me.DTPFin = New System.Windows.Forms.DateTimePicker()
        Me.DTPDebut = New System.Windows.Forms.DateTimePicker()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.ChkHorsPrev = New System.Windows.Forms.CheckBox()
        Me.GrpActions.SuspendLayout()
        Me.GrpPer.SuspendLayout()
        CType(Me.ChartBas, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(XyDiagram1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Series1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(SideBySideBarSeriesLabel1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(SideBySideBarSeriesView1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(RegressionLine1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(SideBySideBarSeriesLabel2, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.GrpFilter.SuspendLayout()
        Me.SuspendLayout()
        '
        'GrpActions
        '
        Me.GrpActions.Controls.Add(Me.BtnFermer)
        Me.GrpActions.Controls.Add(Me.BtnPrint)
        Me.GrpActions.Location = New System.Drawing.Point(12, 32)
        Me.GrpActions.Name = "GrpActions"
        Me.GrpActions.Size = New System.Drawing.Size(89, 644)
        Me.GrpActions.TabIndex = 52
        Me.GrpActions.TabStop = False
        '
        'BtnFermer
        '
        Me.BtnFermer.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold)
        Me.BtnFermer.ImeMode = System.Windows.Forms.ImeMode.NoControl
        Me.BtnFermer.Location = New System.Drawing.Point(6, 579)
        Me.BtnFermer.Name = "BtnFermer"
        Me.BtnFermer.Size = New System.Drawing.Size(75, 48)
        Me.BtnFermer.TabIndex = 1
        Me.BtnFermer.Text = "Fermer"
        Me.BtnFermer.UseVisualStyleBackColor = True
        '
        'BtnPrint
        '
        Me.BtnPrint.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold)
        Me.BtnPrint.ImeMode = System.Windows.Forms.ImeMode.NoControl
        Me.BtnPrint.Location = New System.Drawing.Point(6, 19)
        Me.BtnPrint.Name = "BtnPrint"
        Me.BtnPrint.Size = New System.Drawing.Size(75, 48)
        Me.BtnPrint.TabIndex = 0
        Me.BtnPrint.Text = "Imprimer"
        Me.BtnPrint.UseVisualStyleBackColor = True
        '
        'LblTitre
        '
        Me.LblTitre.AutoSize = True
        Me.LblTitre.Font = New System.Drawing.Font("Arial", 12.0!, System.Drawing.FontStyle.Bold)
        Me.LblTitre.ImeMode = System.Windows.Forms.ImeMode.NoControl
        Me.LblTitre.Location = New System.Drawing.Point(105, 8)
        Me.LblTitre.Name = "LblTitre"
        Me.LblTitre.Size = New System.Drawing.Size(159, 19)
        Me.LblTitre.TabIndex = 53
        Me.LblTitre.Text = "Taux sous-traitance"
        '
        'GrpPer
        '
        Me.GrpPer.Controls.Add(Me.ChartBas)
        Me.GrpPer.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold)
        Me.GrpPer.Location = New System.Drawing.Point(109, 280)
        Me.GrpPer.Name = "GrpPer"
        Me.GrpPer.Size = New System.Drawing.Size(1608, 644)
        Me.GrpPer.TabIndex = 56
        Me.GrpPer.TabStop = False
        '
        'ChartBas
        '
        XyDiagram1.AxisX.Label.Angle = 90
        XyDiagram1.AxisX.Reverse = True
        XyDiagram1.AxisX.VisibleInPanesSerializable = "-1"
        ConstantLine1.AxisValueSerializable = "1"
        ConstantLine1.Color = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(255, Byte), Integer), CType(CType(0, Byte), Integer))
        ConstantLine1.LineStyle.DashStyle = DevExpress.XtraCharts.DashStyle.Solid
        ConstantLine1.LineStyle.Thickness = 2
        ConstantLine1.Name = "Objectif"
        ConstantLine1.Title.DXFont = New DevExpress.Drawing.DXFont("Tahoma", 8.0!, DevExpress.Drawing.DXFontStyle.Bold)
        ConstantLine1.Title.EnableAntialiasing = DevExpress.Utils.DefaultBoolean.[True]
        ConstantLine1.Title.TextColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(255, Byte), Integer), CType(CType(0, Byte), Integer))
        ConstantLine1.Visible = False
        XyDiagram1.AxisY.ConstantLines.AddRange(New DevExpress.XtraCharts.ConstantLine() {ConstantLine1})
        XyDiagram1.AxisY.Label.TextPattern = "{V:N0}"
        XyDiagram1.AxisY.Title.Text = "(%)"
        XyDiagram1.AxisY.Title.Visibility = DevExpress.Utils.DefaultBoolean.[True]
        XyDiagram1.AxisY.VisibleInPanesSerializable = "-1"
        Me.ChartBas.Diagram = XyDiagram1
        Me.ChartBas.Dock = System.Windows.Forms.DockStyle.Fill
        Me.ChartBas.Legend.EquallySpacedItems = False
        Me.ChartBas.Legend.Name = "Default Legend"
        Me.ChartBas.Legend.Visibility = DevExpress.Utils.DefaultBoolean.[False]
        Me.ChartBas.Location = New System.Drawing.Point(3, 16)
        Me.ChartBas.Name = "ChartBas"
        Series1.ArgumentDataMember = "LIB"
        SideBySideBarSeriesLabel1.LineVisibility = DevExpress.Utils.DefaultBoolean.[True]
        SideBySideBarSeriesLabel1.TextPattern = "{V:N0}"
        Series1.Label = SideBySideBarSeriesLabel1
        Series1.LabelsVisibility = DevExpress.Utils.DefaultBoolean.[False]
        Series1.ShowInLegend = False
        Series1.ValueDataMembersSerializable = "TAUX_TOTAL"
        SideBySideBarSeriesView1.Color = System.Drawing.Color.DodgerBlue
        RegressionLine1.Color = System.Drawing.Color.Fuchsia
        SideBySideBarSeriesView1.Indicators.AddRange(New DevExpress.XtraCharts.Indicator() {RegressionLine1})
        Series1.View = SideBySideBarSeriesView1
        Me.ChartBas.SeriesSerializable = New DevExpress.XtraCharts.Series() {Series1}
        SideBySideBarSeriesLabel2.LineVisibility = DevExpress.Utils.DefaultBoolean.[True]
        Me.ChartBas.SeriesTemplate.Label = SideBySideBarSeriesLabel2
        Me.ChartBas.Size = New System.Drawing.Size(1602, 625)
        Me.ChartBas.TabIndex = 2
        ChartTitle1.Text = "TAUX Sous-traitance"
        ChartTitle1.TextColor = System.Drawing.Color.Black
        Me.ChartBas.Titles.AddRange(New DevExpress.XtraCharts.ChartTitle() {ChartTitle1})
        '
        'GrpFilter
        '
        Me.GrpFilter.Controls.Add(Me.Label4)
        Me.GrpFilter.Controls.Add(Me.ChkHorsPrev)
        Me.GrpFilter.Controls.Add(Me.Label3)
        Me.GrpFilter.Controls.Add(Me.Label1)
        Me.GrpFilter.Controls.Add(Me.BtValider)
        Me.GrpFilter.Controls.Add(Me.ComboBox1)
        Me.GrpFilter.Controls.Add(Me.Label2)
        Me.GrpFilter.Controls.Add(Me.ChkOutFrance)
        Me.GrpFilter.Controls.Add(Me.ChkFR)
        Me.GrpFilter.Controls.Add(Me.ChkTous)
        Me.GrpFilter.Controls.Add(Me.ChkMTT)
        Me.GrpFilter.Controls.Add(Me.ChkNB)
        Me.GrpFilter.Controls.Add(Me.Label25)
        Me.GrpFilter.Controls.Add(Me.Label26)
        Me.GrpFilter.Controls.Add(Me.DTPFin)
        Me.GrpFilter.Controls.Add(Me.DTPDebut)
        Me.GrpFilter.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Bold)
        Me.GrpFilter.Location = New System.Drawing.Point(109, 32)
        Me.GrpFilter.Name = "GrpFilter"
        Me.GrpFilter.Size = New System.Drawing.Size(800, 242)
        Me.GrpFilter.TabIndex = 186
        Me.GrpFilter.TabStop = False
        '
        'Label3
        '
        Me.Label3.Font = New System.Drawing.Font("Arial", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label3.ImeMode = System.Windows.Forms.ImeMode.NoControl
        Me.Label3.Location = New System.Drawing.Point(17, 197)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(124, 27)
        Me.Label3.TabIndex = 90
        Me.Label3.Text = "Zone :"
        Me.Label3.TextAlign = System.Drawing.ContentAlignment.TopRight
        '
        'Label1
        '
        Me.Label1.Font = New System.Drawing.Font("Arial", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.ImeMode = System.Windows.Forms.ImeMode.NoControl
        Me.Label1.Location = New System.Drawing.Point(6, 123)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(135, 27)
        Me.Label1.TabIndex = 89
        Me.Label1.Text = "Type Affichage :"
        Me.Label1.TextAlign = System.Drawing.ContentAlignment.TopRight
        '
        'BtValider
        '
        Me.BtValider.Font = New System.Drawing.Font("Arial", 12.0!, System.Drawing.FontStyle.Bold)
        Me.BtValider.ImeMode = System.Windows.Forms.ImeMode.NoControl
        Me.BtValider.Location = New System.Drawing.Point(694, 188)
        Me.BtValider.Name = "BtValider"
        Me.BtValider.Size = New System.Drawing.Size(88, 31)
        Me.BtValider.TabIndex = 86
        Me.BtValider.Text = "Valider"
        Me.BtValider.UseVisualStyleBackColor = True
        '
        'ComboBox1
        '
        Me.ComboBox1.DisplayMember = "VSOCIETENOM"
        Me.ComboBox1.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.ComboBox1.Font = New System.Drawing.Font("Arial", 12.0!, System.Drawing.FontStyle.Bold)
        Me.ComboBox1.ForeColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(0, Byte), Integer), CType(CType(192, Byte), Integer))
        Me.ComboBox1.FormattingEnabled = True
        Me.ComboBox1.Items.AddRange(New Object() {"Toutes sociétés", "EMALEC", "EMALECESPAGNE", "EMALECFACILITEAM", "EMALECIDF", "EMALECMPM", "EQUIPAGE", "MAGESTIME", "SCS"})
        Me.ComboBox1.Location = New System.Drawing.Point(154, 25)
        Me.ComboBox1.Name = "ComboBox1"
        Me.ComboBox1.Size = New System.Drawing.Size(235, 27)
        Me.ComboBox1.TabIndex = 88
        Me.ComboBox1.ValueMember = "VSOCIETENOM"
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Font = New System.Drawing.Font("Arial", 12.0!, System.Drawing.FontStyle.Bold)
        Me.Label2.ImeMode = System.Windows.Forms.ImeMode.NoControl
        Me.Label2.Location = New System.Drawing.Point(65, 28)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(76, 19)
        Me.Label2.TabIndex = 87
        Me.Label2.Text = "Société :"
        Me.Label2.TextAlign = System.Drawing.ContentAlignment.TopRight
        '
        'ChkOutFrance
        '
        Me.ChkOutFrance.AutoSize = True
        Me.ChkOutFrance.Font = New System.Drawing.Font("Arial", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.ChkOutFrance.Location = New System.Drawing.Point(449, 196)
        Me.ChkOutFrance.Name = "ChkOutFrance"
        Me.ChkOutFrance.Size = New System.Drawing.Size(122, 23)
        Me.ChkOutFrance.TabIndex = 14
        Me.ChkOutFrance.Text = "Hors France"
        Me.ChkOutFrance.UseVisualStyleBackColor = True
        '
        'ChkFR
        '
        Me.ChkFR.AutoSize = True
        Me.ChkFR.Font = New System.Drawing.Font("Arial", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.ChkFR.Location = New System.Drawing.Point(308, 196)
        Me.ChkFR.Name = "ChkFR"
        Me.ChkFR.Size = New System.Drawing.Size(81, 23)
        Me.ChkFR.TabIndex = 13
        Me.ChkFR.Text = "France"
        Me.ChkFR.UseVisualStyleBackColor = True
        '
        'ChkTous
        '
        Me.ChkTous.AutoSize = True
        Me.ChkTous.Font = New System.Drawing.Font("Arial", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.ChkTous.Location = New System.Drawing.Point(159, 196)
        Me.ChkTous.Name = "ChkTous"
        Me.ChkTous.Size = New System.Drawing.Size(66, 23)
        Me.ChkTous.TabIndex = 12
        Me.ChkTous.Text = "Tous"
        Me.ChkTous.UseVisualStyleBackColor = True
        '
        'ChkMTT
        '
        Me.ChkMTT.AutoSize = True
        Me.ChkMTT.Font = New System.Drawing.Font("Arial", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.ChkMTT.Location = New System.Drawing.Point(363, 122)
        Me.ChkMTT.Name = "ChkMTT"
        Me.ChkMTT.Size = New System.Drawing.Size(161, 23)
        Me.ChkMTT.TabIndex = 11
        Me.ChkMTT.Text = "Taux par montant"
        Me.ChkMTT.UseVisualStyleBackColor = True
        '
        'ChkNB
        '
        Me.ChkNB.AutoSize = True
        Me.ChkNB.Font = New System.Drawing.Font("Arial", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.ChkNB.Location = New System.Drawing.Point(159, 122)
        Me.ChkNB.Name = "ChkNB"
        Me.ChkNB.Size = New System.Drawing.Size(157, 23)
        Me.ChkNB.TabIndex = 10
        Me.ChkNB.Text = "Taux par nombre"
        Me.ChkNB.UseVisualStyleBackColor = True
        '
        'Label25
        '
        Me.Label25.ImeMode = System.Windows.Forms.ImeMode.NoControl
        Me.Label25.Location = New System.Drawing.Point(446, 75)
        Me.Label25.Name = "Label25"
        Me.Label25.Size = New System.Drawing.Size(33, 27)
        Me.Label25.TabIndex = 7
        Me.Label25.Text = "Au"
        '
        'Label26
        '
        Me.Label26.Font = New System.Drawing.Font("Arial", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label26.ImeMode = System.Windows.Forms.ImeMode.NoControl
        Me.Label26.Location = New System.Drawing.Point(98, 73)
        Me.Label26.Name = "Label26"
        Me.Label26.Size = New System.Drawing.Size(43, 27)
        Me.Label26.TabIndex = 6
        Me.Label26.Text = "Du :"
        '
        'DTPFin
        '
        Me.DTPFin.Location = New System.Drawing.Point(494, 73)
        Me.DTPFin.Name = "DTPFin"
        Me.DTPFin.Size = New System.Drawing.Size(278, 22)
        Me.DTPFin.TabIndex = 5
        '
        'DTPDebut
        '
        Me.DTPDebut.Location = New System.Drawing.Point(154, 73)
        Me.DTPDebut.Name = "DTPDebut"
        Me.DTPDebut.Size = New System.Drawing.Size(278, 22)
        Me.DTPDebut.TabIndex = 4
        '
        'Label4
        '
        Me.Label4.Font = New System.Drawing.Font("Arial", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label4.ImeMode = System.Windows.Forms.ImeMode.NoControl
        Me.Label4.Location = New System.Drawing.Point(6, 159)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(135, 27)
        Me.Label4.TabIndex = 92
        Me.Label4.Text = "Prestation :"
        Me.Label4.TextAlign = System.Drawing.ContentAlignment.TopRight
        '
        'ChkHorsPrev
        '
        Me.ChkHorsPrev.AutoSize = True
        Me.ChkHorsPrev.Font = New System.Drawing.Font("Arial", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.ChkHorsPrev.Location = New System.Drawing.Point(159, 158)
        Me.ChkHorsPrev.Name = "ChkHorsPrev"
        Me.ChkHorsPrev.Size = New System.Drawing.Size(149, 23)
        Me.ChkHorsPrev.TabIndex = 91
        Me.ChkHorsPrev.Text = "Hors préventive"
        Me.ChkHorsPrev.UseVisualStyleBackColor = True
        '
        'frmStatTauxSousTraitance
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.Wheat
        Me.ClientSize = New System.Drawing.Size(2014, 996)
        Me.Controls.Add(Me.GrpFilter)
        Me.Controls.Add(Me.GrpActions)
        Me.Controls.Add(Me.LblTitre)
        Me.Controls.Add(Me.GrpPer)
        Me.Name = "frmStatTauxSousTraitance"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent
        Me.Text = "Statistique taux sous-traitance"
        Me.WindowState = System.Windows.Forms.FormWindowState.Maximized
        Me.GrpActions.ResumeLayout(False)
        Me.GrpPer.ResumeLayout(False)
        CType(XyDiagram1, System.ComponentModel.ISupportInitialize).EndInit()
        CType(SideBySideBarSeriesLabel1, System.ComponentModel.ISupportInitialize).EndInit()
        CType(RegressionLine1, System.ComponentModel.ISupportInitialize).EndInit()
        CType(SideBySideBarSeriesView1, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Series1, System.ComponentModel.ISupportInitialize).EndInit()
        CType(SideBySideBarSeriesLabel2, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.ChartBas, System.ComponentModel.ISupportInitialize).EndInit()
        Me.GrpFilter.ResumeLayout(False)
        Me.GrpFilter.PerformLayout()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents GrpActions As GroupBox
    Friend WithEvents BtnFermer As Button
    Friend WithEvents BtnPrint As Button
    Friend WithEvents LblTitre As Label
    Friend WithEvents GrpPer As GroupBox
    Private WithEvents ChartBas As DevExpress.XtraCharts.ChartControl
    Friend WithEvents GrpFilter As GroupBox
    Friend WithEvents ChkOutFrance As CheckBox
    Friend WithEvents ChkFR As CheckBox
    Friend WithEvents ChkTous As CheckBox
    Friend WithEvents ChkMTT As CheckBox
    Friend WithEvents ChkNB As CheckBox
    Friend WithEvents Label25 As Label
    Friend WithEvents Label26 As Label
    Friend WithEvents DTPFin As DateTimePicker
    Friend WithEvents DTPDebut As DateTimePicker
    Friend WithEvents BtValider As Button
    Friend WithEvents ComboBox1 As ComboBox
    Friend WithEvents Label2 As Label
    Friend WithEvents Label1 As Label
    Friend WithEvents Label3 As Label
    Friend WithEvents Label4 As Label
    Friend WithEvents ChkHorsPrev As CheckBox
End Class
