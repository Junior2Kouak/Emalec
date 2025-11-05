<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class UCSelectArticle
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
    Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(UCSelectArticle))
    Me.txtCritRefFab = New MozartUC.apiTextBox()
    Me.txtCritId = New MozartUC.apiTextBox()
    Me.lblreffou = New MozartUC.apiLabel()
    Me.txtCritRefFou = New MozartUC.apiTextBox()
    Me.lblF2 = New MozartUC.apiLabel()
    Me.lblId = New MozartUC.apiLabel()
    Me.lblref = New MozartUC.apiLabel()
    Me.lblmarque = New MozartUC.apiLabel()
    Me.cmdFind = New MozartUC.apiButton()
    Me.txtCritSerie = New MozartUC.apiCombo()
    Me.lblserie = New MozartUC.apiLabel()
    Me.lblmat = New MozartUC.apiLabel()
    Me.txtCritType = New MozartUC.apiTextBox()
    Me.apiLabel5 = New MozartUC.apiLabel()
    Me.txtCritMarque = New MozartUC.apiTextBox()
    Me.lbltype = New MozartUC.apiLabel()
    Me.txtCritFour = New MozartUC.apiCombo()
    Me.txtCritMat = New MozartUC.apiTextBox()
    Me.SuspendLayout()
    '
    'txtCritRefFab
    '
    resources.ApplyResources(Me.txtCritRefFab, "txtCritRefFab")
    Me.txtCritRefFab.ForeColor = System.Drawing.SystemColors.ControlText
    Me.txtCritRefFab.HelpContextID = 0
    Me.txtCritRefFab.Name = "txtCritRefFab"
    Me.txtCritRefFab.Tag = "TSTF.VSTFFOUREFCLI"
    '
    'txtCritId
    '
    resources.ApplyResources(Me.txtCritId, "txtCritId")
    Me.txtCritId.ForeColor = System.Drawing.SystemColors.ControlText
    Me.txtCritId.HelpContextID = 0
    Me.txtCritId.Name = "txtCritId"
    Me.txtCritId.Tag = "TFOU.NFOUNUM"
    '
    'lblreffou
    '
    resources.ApplyResources(Me.lblreffou, "lblreffou")
    Me.lblreffou.ForeColor = System.Drawing.SystemColors.ControlText
    Me.lblreffou.HelpContextID = 0
    Me.lblreffou.Name = "lblreffou"
    '
    'txtCritRefFou
    '
    resources.ApplyResources(Me.txtCritRefFou, "txtCritRefFou")
    Me.txtCritRefFou.ForeColor = System.Drawing.SystemColors.ControlText
    Me.txtCritRefFou.HelpContextID = 0
    Me.txtCritRefFou.Name = "txtCritRefFou"
    Me.txtCritRefFou.Tag = "TFOU.VFOUREF"
    '
    'lblF2
    '
    resources.ApplyResources(Me.lblF2, "lblF2")
    Me.lblF2.ForeColor = System.Drawing.SystemColors.ControlText
    Me.lblF2.HelpContextID = 0
    Me.lblF2.Name = "lblF2"
    '
    'lblId
    '
    resources.ApplyResources(Me.lblId, "lblId")
    Me.lblId.ForeColor = System.Drawing.SystemColors.ControlText
    Me.lblId.HelpContextID = 0
    Me.lblId.Name = "lblId"
    '
    'lblref
    '
    resources.ApplyResources(Me.lblref, "lblref")
    Me.lblref.ForeColor = System.Drawing.SystemColors.ControlText
    Me.lblref.HelpContextID = 0
    Me.lblref.Name = "lblref"
    '
    'lblmarque
    '
    resources.ApplyResources(Me.lblmarque, "lblmarque")
    Me.lblmarque.ForeColor = System.Drawing.SystemColors.ControlText
    Me.lblmarque.HelpContextID = 0
    Me.lblmarque.Name = "lblmarque"
    '
    'cmdFind
    '
    Me.cmdFind.ForeColor = System.Drawing.SystemColors.ControlText
    Me.cmdFind.HelpContextID = 0
    Me.cmdFind.Image = Global.MozartNet.My.Resources.Find
    resources.ApplyResources(Me.cmdFind, "cmdFind")
    Me.cmdFind.Name = "cmdFind"
    Me.cmdFind.Tag = "8"
    Me.cmdFind.UseVisualStyleBackColor = True
    '
    'txtCritSerie
    '
    resources.ApplyResources(Me.txtCritSerie, "txtCritSerie")
    Me.txtCritSerie.Name = "txtCritSerie"
    Me.txtCritSerie.NewValues = False
    '
    'lblserie
    '
    resources.ApplyResources(Me.lblserie, "lblserie")
    Me.lblserie.ForeColor = System.Drawing.SystemColors.ControlText
    Me.lblserie.HelpContextID = 0
    Me.lblserie.Name = "lblserie"
    '
    'lblmat
    '
    resources.ApplyResources(Me.lblmat, "lblmat")
    Me.lblmat.ForeColor = System.Drawing.SystemColors.ControlText
    Me.lblmat.HelpContextID = 0
    Me.lblmat.Name = "lblmat"
    '
    'txtCritType
    '
    resources.ApplyResources(Me.txtCritType, "txtCritType")
    Me.txtCritType.ForeColor = System.Drawing.SystemColors.ControlText
    Me.txtCritType.HelpContextID = 0
    Me.txtCritType.Name = "txtCritType"
    Me.txtCritType.Tag = "TFOU.VFOUTYP"
    '
    'apiLabel5
    '
    resources.ApplyResources(Me.apiLabel5, "apiLabel5")
    Me.apiLabel5.ForeColor = System.Drawing.SystemColors.ControlText
    Me.apiLabel5.HelpContextID = 0
    Me.apiLabel5.Name = "apiLabel5"
    '
    'txtCritMarque
    '
    resources.ApplyResources(Me.txtCritMarque, "txtCritMarque")
    Me.txtCritMarque.ForeColor = System.Drawing.SystemColors.ControlText
    Me.txtCritMarque.HelpContextID = 0
    Me.txtCritMarque.Name = "txtCritMarque"
    Me.txtCritMarque.Tag = "TFOU.VFOUMAR"
    '
    'lbltype
    '
    resources.ApplyResources(Me.lbltype, "lbltype")
    Me.lbltype.ForeColor = System.Drawing.SystemColors.ControlText
    Me.lbltype.HelpContextID = 0
    Me.lbltype.Name = "lbltype"
    '
    'txtCritFour
    '
    resources.ApplyResources(Me.txtCritFour, "txtCritFour")
    Me.txtCritFour.Name = "txtCritFour"
    Me.txtCritFour.NewValues = False
    '
    'txtCritMat
    '
    resources.ApplyResources(Me.txtCritMat, "txtCritMat")
    Me.txtCritMat.ForeColor = System.Drawing.SystemColors.ControlText
    Me.txtCritMat.HelpContextID = 0
    Me.txtCritMat.Name = "txtCritMat"
    Me.txtCritMat.Tag = "TFOU.VFOUMAT"
    '
    'UCSelectArticle
    '
    resources.ApplyResources(Me, "$this")
    Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
    Me.BackColor = System.Drawing.Color.FromArgb(CType(CType(183, Byte), Integer), CType(CType(218, Byte), Integer), CType(CType(242, Byte), Integer))
    Me.Controls.Add(Me.txtCritRefFab)
    Me.Controls.Add(Me.txtCritId)
    Me.Controls.Add(Me.lblreffou)
    Me.Controls.Add(Me.txtCritRefFou)
    Me.Controls.Add(Me.lblF2)
    Me.Controls.Add(Me.lblId)
    Me.Controls.Add(Me.lblref)
    Me.Controls.Add(Me.lblmarque)
    Me.Controls.Add(Me.cmdFind)
    Me.Controls.Add(Me.txtCritSerie)
    Me.Controls.Add(Me.lblserie)
    Me.Controls.Add(Me.lblmat)
    Me.Controls.Add(Me.txtCritType)
    Me.Controls.Add(Me.apiLabel5)
    Me.Controls.Add(Me.txtCritMarque)
    Me.Controls.Add(Me.lbltype)
    Me.Controls.Add(Me.txtCritFour)
    Me.Controls.Add(Me.txtCritMat)
    Me.Name = "UCSelectArticle"
    Me.ResumeLayout(False)
    Me.PerformLayout()

  End Sub

  Private WithEvents txtCritRefFab As MozartUC.apiTextBox
    Private WithEvents txtCritId As MozartUC.apiTextBox
    Private WithEvents lblreffou As MozartUC.apiLabel
    Private WithEvents txtCritRefFou As MozartUC.apiTextBox
    Private WithEvents lblF2 As MozartUC.apiLabel
    Private WithEvents lblId As MozartUC.apiLabel
    Private WithEvents lblref As MozartUC.apiLabel
    Private WithEvents lblmarque As MozartUC.apiLabel
    Private WithEvents cmdFind As MozartUC.apiButton
    Private WithEvents txtCritSerie As MozartUC.apiCombo
    Private WithEvents lblserie As MozartUC.apiLabel
    Private WithEvents lblmat As MozartUC.apiLabel
    Private WithEvents txtCritType As MozartUC.apiTextBox
    Private WithEvents apiLabel5 As MozartUC.apiLabel
    Private WithEvents txtCritMarque As MozartUC.apiTextBox
    Private WithEvents lbltype As MozartUC.apiLabel
    Private WithEvents txtCritFour As MozartUC.apiCombo
    Private WithEvents txtCritMat As MozartUC.apiTextBox
End Class
