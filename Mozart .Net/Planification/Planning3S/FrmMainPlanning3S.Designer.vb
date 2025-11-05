<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class FrmMainPlanning3S
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
        Me.components = New System.ComponentModel.Container()
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(FrmMainPlanning3S))
        Dim DataGridViewCellStyle1 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Me.grdvPlanning = New System.Windows.Forms.DataGridView()
        Me.btnRefresh = New System.Windows.Forms.Button()
        Me.pnlTechs = New System.Windows.Forms.Panel()
        Me.btnQuit = New System.Windows.Forms.Button()
        Me.pnlCommandes = New System.Windows.Forms.Panel()
        Me.btnTechSuiv = New System.Windows.Forms.Button()
        Me.cboTechs = New System.Windows.Forms.ComboBox()
        Me.btnTechPrec = New System.Windows.Forms.Button()
        Me.btnSemSuiv = New System.Windows.Forms.Button()
        Me.btnSemPrec = New System.Windows.Forms.Button()
        Me.Timer1 = New System.Windows.Forms.Timer(Me.components)
        Me.btnTechsClim = New System.Windows.Forms.Button()
        Me.btnTechsCFaible = New System.Windows.Forms.Button()
        Me.btnTechsCFort = New System.Windows.Forms.Button()
        Me.btnTechsSecOeuvre = New System.Windows.Forms.Button()
        Me.btnTechsPlomb = New System.Windows.Forms.Button()
        Me.btnTechsMultitech = New System.Windows.Forms.Button()
        Me.btnSelectTech = New System.Windows.Forms.Button()
        Me.btnMaps = New System.Windows.Forms.Button()
        Me.btnDistance = New System.Windows.Forms.Button()
        Me.btnCompetences = New System.Windows.Forms.Button()
        Me.btnCarte = New System.Windows.Forms.Button()
        Me.BtnPrintS3 = New System.Windows.Forms.Button()
        Me.btnTechsCouvreur = New System.Windows.Forms.Button()
        Me.BtnTechEI = New System.Windows.Forms.Button()
        Me.BtnCommerce = New System.Windows.Forms.Button()
        CType(Me.grdvPlanning, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.pnlTechs.SuspendLayout()
        Me.pnlCommandes.SuspendLayout()
        Me.SuspendLayout()
        '
        'grdvPlanning
        '
        Me.grdvPlanning.AllowDrop = True
        Me.grdvPlanning.AllowUserToAddRows = False
        Me.grdvPlanning.AllowUserToDeleteRows = False
        Me.grdvPlanning.AllowUserToResizeColumns = False
        Me.grdvPlanning.AllowUserToResizeRows = False
        resources.ApplyResources(Me.grdvPlanning, "grdvPlanning")
        Me.grdvPlanning.CellBorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.Sunken
        DataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter
        DataGridViewCellStyle1.BackColor = System.Drawing.Color.DodgerBlue
        DataGridViewCellStyle1.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        DataGridViewCellStyle1.ForeColor = System.Drawing.Color.White
        DataGridViewCellStyle1.SelectionBackColor = System.Drawing.SystemColors.Highlight
        DataGridViewCellStyle1.SelectionForeColor = System.Drawing.SystemColors.HighlightText
        DataGridViewCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.[False]
        Me.grdvPlanning.ColumnHeadersDefaultCellStyle = DataGridViewCellStyle1
        Me.grdvPlanning.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.DisableResizing
        Me.grdvPlanning.MultiSelect = False
        Me.grdvPlanning.Name = "grdvPlanning"
        Me.grdvPlanning.ReadOnly = True
        Me.grdvPlanning.RowHeadersVisible = False
        Me.grdvPlanning.ShowRowErrors = False
        '
        'btnRefresh
        '
        resources.ApplyResources(Me.btnRefresh, "btnRefresh")
        Me.btnRefresh.BackColor = System.Drawing.Color.Transparent
        Me.btnRefresh.Name = "btnRefresh"
        Me.btnRefresh.UseVisualStyleBackColor = False
        '
        'pnlTechs
        '
        resources.ApplyResources(Me.pnlTechs, "pnlTechs")
        Me.pnlTechs.BackColor = System.Drawing.Color.DimGray
        Me.pnlTechs.Controls.Add(Me.btnQuit)
        Me.pnlTechs.Controls.Add(Me.pnlCommandes)
        Me.pnlTechs.Controls.Add(Me.btnRefresh)
        Me.pnlTechs.Name = "pnlTechs"
        '
        'btnQuit
        '
        resources.ApplyResources(Me.btnQuit, "btnQuit")
        Me.btnQuit.BackColor = System.Drawing.Color.Transparent
        Me.btnQuit.Name = "btnQuit"
        Me.btnQuit.UseVisualStyleBackColor = False
        '
        'pnlCommandes
        '
        Me.pnlCommandes.AllowDrop = True
        Me.pnlCommandes.BackColor = System.Drawing.Color.Peru
        Me.pnlCommandes.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
        Me.pnlCommandes.Controls.Add(Me.btnTechSuiv)
        Me.pnlCommandes.Controls.Add(Me.cboTechs)
        Me.pnlCommandes.Controls.Add(Me.btnTechPrec)
        Me.pnlCommandes.Controls.Add(Me.btnSemSuiv)
        Me.pnlCommandes.Controls.Add(Me.btnSemPrec)
        resources.ApplyResources(Me.pnlCommandes, "pnlCommandes")
        Me.pnlCommandes.Name = "pnlCommandes"
        '
        'btnTechSuiv
        '
        Me.btnTechSuiv.AllowDrop = True
        resources.ApplyResources(Me.btnTechSuiv, "btnTechSuiv")
        Me.btnTechSuiv.Name = "btnTechSuiv"
        Me.btnTechSuiv.UseVisualStyleBackColor = True
        '
        'cboTechs
        '
        Me.cboTechs.DropDownHeight = 800
        Me.cboTechs.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.cboTechs.DropDownWidth = 300
        resources.ApplyResources(Me.cboTechs, "cboTechs")
        Me.cboTechs.ForeColor = System.Drawing.Color.MediumBlue
        Me.cboTechs.FormattingEnabled = True
        Me.cboTechs.Name = "cboTechs"
        Me.cboTechs.Sorted = True
        '
        'btnTechPrec
        '
        Me.btnTechPrec.AllowDrop = True
        resources.ApplyResources(Me.btnTechPrec, "btnTechPrec")
        Me.btnTechPrec.Name = "btnTechPrec"
        Me.btnTechPrec.UseVisualStyleBackColor = True
        '
        'btnSemSuiv
        '
        resources.ApplyResources(Me.btnSemSuiv, "btnSemSuiv")
        Me.btnSemSuiv.Name = "btnSemSuiv"
        Me.btnSemSuiv.UseVisualStyleBackColor = True
        '
        'btnSemPrec
        '
        resources.ApplyResources(Me.btnSemPrec, "btnSemPrec")
        Me.btnSemPrec.Name = "btnSemPrec"
        Me.btnSemPrec.UseVisualStyleBackColor = True
        '
        'Timer1
        '
        Me.Timer1.Interval = 500
        '
        'btnTechsClim
        '
        Me.btnTechsClim.BackColor = System.Drawing.Color.BurlyWood
        resources.ApplyResources(Me.btnTechsClim, "btnTechsClim")
        Me.btnTechsClim.Name = "btnTechsClim"
        Me.btnTechsClim.Tag = "1"
        Me.btnTechsClim.UseVisualStyleBackColor = False
        '
        'btnTechsCFaible
        '
        Me.btnTechsCFaible.BackColor = System.Drawing.Color.BurlyWood
        resources.ApplyResources(Me.btnTechsCFaible, "btnTechsCFaible")
        Me.btnTechsCFaible.Name = "btnTechsCFaible"
        Me.btnTechsCFaible.Tag = "3"
        Me.btnTechsCFaible.UseVisualStyleBackColor = False
        '
        'btnTechsCFort
        '
        Me.btnTechsCFort.BackColor = System.Drawing.Color.BurlyWood
        resources.ApplyResources(Me.btnTechsCFort, "btnTechsCFort")
        Me.btnTechsCFort.Name = "btnTechsCFort"
        Me.btnTechsCFort.Tag = "2"
        Me.btnTechsCFort.UseVisualStyleBackColor = False
        '
        'btnTechsSecOeuvre
        '
        Me.btnTechsSecOeuvre.BackColor = System.Drawing.Color.BurlyWood
        resources.ApplyResources(Me.btnTechsSecOeuvre, "btnTechsSecOeuvre")
        Me.btnTechsSecOeuvre.Name = "btnTechsSecOeuvre"
        Me.btnTechsSecOeuvre.Tag = "7"
        Me.btnTechsSecOeuvre.UseVisualStyleBackColor = False
        '
        'btnTechsPlomb
        '
        Me.btnTechsPlomb.BackColor = System.Drawing.Color.BurlyWood
        resources.ApplyResources(Me.btnTechsPlomb, "btnTechsPlomb")
        Me.btnTechsPlomb.Name = "btnTechsPlomb"
        Me.btnTechsPlomb.Tag = "8"
        Me.btnTechsPlomb.UseVisualStyleBackColor = False
        '
        'btnTechsMultitech
        '
        Me.btnTechsMultitech.BackColor = System.Drawing.Color.BurlyWood
        resources.ApplyResources(Me.btnTechsMultitech, "btnTechsMultitech")
        Me.btnTechsMultitech.Name = "btnTechsMultitech"
        Me.btnTechsMultitech.Tag = "4"
        Me.btnTechsMultitech.UseVisualStyleBackColor = False
        '
        'btnSelectTech
        '
        Me.btnSelectTech.BackColor = System.Drawing.Color.Peru
        resources.ApplyResources(Me.btnSelectTech, "btnSelectTech")
        Me.btnSelectTech.Name = "btnSelectTech"
        Me.btnSelectTech.UseVisualStyleBackColor = False
        '
        'btnMaps
        '
        Me.btnMaps.BackColor = System.Drawing.Color.Peru
        resources.ApplyResources(Me.btnMaps, "btnMaps")
        Me.btnMaps.Name = "btnMaps"
        Me.btnMaps.UseVisualStyleBackColor = False
        '
        'btnDistance
        '
        Me.btnDistance.BackColor = System.Drawing.Color.OrangeRed
        resources.ApplyResources(Me.btnDistance, "btnDistance")
        Me.btnDistance.Name = "btnDistance"
        Me.btnDistance.UseVisualStyleBackColor = False
        '
        'btnCompetences
        '
        Me.btnCompetences.BackColor = System.Drawing.Color.OrangeRed
        resources.ApplyResources(Me.btnCompetences, "btnCompetences")
        Me.btnCompetences.Name = "btnCompetences"
        Me.btnCompetences.UseVisualStyleBackColor = False
        '
        'btnCarte
        '
        Me.btnCarte.BackColor = System.Drawing.Color.Bisque
        resources.ApplyResources(Me.btnCarte, "btnCarte")
        Me.btnCarte.Name = "btnCarte"
        Me.btnCarte.UseVisualStyleBackColor = False
        '
        'BtnPrintS3
        '
        Me.BtnPrintS3.BackColor = System.Drawing.Color.Bisque
        resources.ApplyResources(Me.BtnPrintS3, "BtnPrintS3")
        Me.BtnPrintS3.Name = "BtnPrintS3"
        Me.BtnPrintS3.UseVisualStyleBackColor = False
        '
        'btnTechsCouvreur
        '
        Me.btnTechsCouvreur.BackColor = System.Drawing.Color.BurlyWood
        resources.ApplyResources(Me.btnTechsCouvreur, "btnTechsCouvreur")
        Me.btnTechsCouvreur.Name = "btnTechsCouvreur"
        Me.btnTechsCouvreur.Tag = "9"
        Me.btnTechsCouvreur.UseVisualStyleBackColor = False
        '
        'BtnTechEI
        '
        Me.BtnTechEI.BackColor = System.Drawing.Color.BurlyWood
        resources.ApplyResources(Me.BtnTechEI, "BtnTechEI")
        Me.BtnTechEI.Name = "BtnTechEI"
        Me.BtnTechEI.Tag = "11"
        Me.BtnTechEI.UseVisualStyleBackColor = False
        '
        'BtnCommerce
        '
        Me.BtnCommerce.BackColor = System.Drawing.Color.BurlyWood
        resources.ApplyResources(Me.BtnCommerce, "BtnCommerce")
        Me.BtnCommerce.Name = "BtnCommerce"
        Me.BtnCommerce.Tag = "CO"
        Me.BtnCommerce.UseVisualStyleBackColor = False
        '
        'FrmMainPlanning3S
        '
        resources.ApplyResources(Me, "$this")
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.Controls.Add(Me.BtnCommerce)
        Me.Controls.Add(Me.BtnTechEI)
        Me.Controls.Add(Me.btnTechsCouvreur)
        Me.Controls.Add(Me.BtnPrintS3)
        Me.Controls.Add(Me.btnCarte)
        Me.Controls.Add(Me.btnCompetences)
        Me.Controls.Add(Me.btnDistance)
        Me.Controls.Add(Me.btnMaps)
        Me.Controls.Add(Me.btnSelectTech)
        Me.Controls.Add(Me.btnTechsMultitech)
        Me.Controls.Add(Me.btnTechsPlomb)
        Me.Controls.Add(Me.btnTechsSecOeuvre)
        Me.Controls.Add(Me.btnTechsCFort)
        Me.Controls.Add(Me.btnTechsCFaible)
        Me.Controls.Add(Me.btnTechsClim)
        Me.Controls.Add(Me.pnlTechs)
        Me.Controls.Add(Me.grdvPlanning)
        Me.KeyPreview = True
        Me.Name = "FrmMainPlanning3S"
        Me.WindowState = System.Windows.Forms.FormWindowState.Maximized
        CType(Me.grdvPlanning, System.ComponentModel.ISupportInitialize).EndInit()
        Me.pnlTechs.ResumeLayout(False)
        Me.pnlCommandes.ResumeLayout(False)
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents grdvPlanning As System.Windows.Forms.DataGridView
    Friend WithEvents btnRefresh As System.Windows.Forms.Button
    Friend WithEvents pnlTechs As System.Windows.Forms.Panel
    Friend WithEvents pnlCommandes As System.Windows.Forms.Panel
    Friend WithEvents cboTechs As System.Windows.Forms.ComboBox
    Friend WithEvents btnTechPrec As System.Windows.Forms.Button
    Friend WithEvents btnSemSuiv As System.Windows.Forms.Button
    Friend WithEvents btnSemPrec As System.Windows.Forms.Button
    Friend WithEvents btnTechSuiv As System.Windows.Forms.Button
    Friend WithEvents Timer1 As System.Windows.Forms.Timer
    Friend WithEvents btnQuit As System.Windows.Forms.Button
    Friend WithEvents btnTechsClim As System.Windows.Forms.Button
    Friend WithEvents btnTechsCFaible As System.Windows.Forms.Button
    Friend WithEvents btnTechsCFort As System.Windows.Forms.Button
    Friend WithEvents btnTechsSecOeuvre As System.Windows.Forms.Button
    Friend WithEvents btnTechsPlomb As System.Windows.Forms.Button
    Friend WithEvents btnTechsMultitech As System.Windows.Forms.Button
    Friend WithEvents btnSelectTech As System.Windows.Forms.Button
    Friend WithEvents btnMaps As System.Windows.Forms.Button
    Friend WithEvents btnDistance As System.Windows.Forms.Button
    Friend WithEvents btnCompetences As System.Windows.Forms.Button
    Friend WithEvents btnCarte As System.Windows.Forms.Button
    Friend WithEvents BtnPrintS3 As System.Windows.Forms.Button
    Friend WithEvents btnTechsCouvreur As System.Windows.Forms.Button
    Friend WithEvents BtnTechEI As System.Windows.Forms.Button
  Friend WithEvents BtnCommerce As System.Windows.Forms.Button
End Class
