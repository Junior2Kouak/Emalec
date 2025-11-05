<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class frmFicSituDanger_Detail
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
        Me.components = New System.ComponentModel.Container()
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(frmFicSituDanger_Detail))
        Me.Label10 = New System.Windows.Forms.Label()
        Me.Label9 = New System.Windows.Forms.Label()
        Me.Label7 = New System.Windows.Forms.Label()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.Label8 = New System.Windows.Forms.Label()
        Me.ChkTypeSitu3 = New DevExpress.XtraEditors.CheckEdit()
        Me.GrpBoxFormationEI = New System.Windows.Forms.GroupBox()
        Me.GrpBoxPhotos = New System.Windows.Forms.GroupBox()
        Me.BtnSuppPhoto = New System.Windows.Forms.Button()
        Me.BtnAddPhoto = New System.Windows.Forms.Button()
        Me.LstViewPhotos = New System.Windows.Forms.ListView()
        Me.ImgLstFicheSituDang_Photos = New System.Windows.Forms.ImageList(Me.components)
        Me.GrpBoxFait = New System.Windows.Forms.GroupBox()
        Me.MemoEditFaits = New DevExpress.XtraEditors.MemoEdit()
        Me.GrpBoxVictimes = New System.Windows.Forms.GroupBox()
        Me.TxtEditVVICTIME_3 = New DevExpress.XtraEditors.TextEdit()
        Me.TxtEditVVICTIME_2 = New DevExpress.XtraEditors.TextEdit()
        Me.TxtEditVVICTIME_1 = New DevExpress.XtraEditors.TextEdit()
        Me.ChkVictime3 = New DevExpress.XtraEditors.CheckEdit()
        Me.ChkVictime2 = New DevExpress.XtraEditors.CheckEdit()
        Me.ChkVictime1 = New DevExpress.XtraEditors.CheckEdit()
        Me.GrpBoxSituDanger = New System.Windows.Forms.GroupBox()
        Me.Label11 = New System.Windows.Forms.Label()
        Me.ChkTypeSitu2 = New DevExpress.XtraEditors.CheckEdit()
        Me.ChkTypeSitu1 = New DevExpress.XtraEditors.CheckEdit()
        Me.GrpBoxEntete = New System.Windows.Forms.GroupBox()
        Me.BtnRechercheDI = New System.Windows.Forms.Button()
        Me.Txt_FicHeure = New System.Windows.Forms.TextBox()
        Me.Txt_FicDateCree = New System.Windows.Forms.TextBox()
        Me.Txt_Lieu = New System.Windows.Forms.TextBox()
        Me.Txt_DI = New System.Windows.Forms.TextBox()
        Me.Cbo_FicIntervenant = New System.Windows.Forms.ComboBox()
        Me.Label6 = New System.Windows.Forms.Label()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.GrpBoxObject = New System.Windows.Forms.GroupBox()
        Me.LblObjDemarche = New System.Windows.Forms.Label()
        Me.ODF = New System.Windows.Forms.OpenFileDialog()
        Me.GrpBoxActions = New System.Windows.Forms.GroupBox()
        Me.BtnSave = New System.Windows.Forms.Button()
        Me.BtnArchiver = New System.Windows.Forms.Button()
        Me.BtnFermer = New System.Windows.Forms.Button()
        Me.GrpBoxReponse = New System.Windows.Forms.GroupBox()
        Me.BtnValidRep = New System.Windows.Forms.Button()
        Me.GrpBoxLectureTech = New System.Windows.Forms.GroupBox()
        Me.LblLectureTechDate = New System.Windows.Forms.Label()
        Me.Label16 = New System.Windows.Forms.Label()
        Me.GrpBoxInfo = New System.Windows.Forms.GroupBox()
        Me.LblDeclarant = New System.Windows.Forms.Label()
        Me.Label14 = New System.Windows.Forms.Label()
        Me.LblDateReponse = New System.Windows.Forms.Label()
        Me.Label20 = New System.Windows.Forms.Label()
        Me.BtnEnregistrer = New System.Windows.Forms.Button()
        Me.GrpReponseTech = New System.Windows.Forms.GroupBox()
        Me.MemoRep = New DevExpress.XtraEditors.MemoEdit()
        Me.GrpBoxCotation = New System.Windows.Forms.GroupBox()
        Me.cboRisque = New System.Windows.Forms.ComboBox()
        Me.Label13 = New System.Windows.Forms.Label()
        Me.Label22 = New System.Windows.Forms.Label()
        Me.CboCotation = New DevExpress.XtraEditors.ComboBoxEdit()
        Me.GrpBoxAnalyse = New System.Windows.Forms.GroupBox()
        Me.TxtBoxAutres = New System.Windows.Forms.TextBox()
        Me.ChkAutres = New DevExpress.XtraEditors.CheckEdit()
        Me.ChkMilieu = New DevExpress.XtraEditors.CheckEdit()
        Me.ChkMate = New DevExpress.XtraEditors.CheckEdit()
        Me.ChkForm = New DevExpress.XtraEditors.CheckEdit()
        Me.ChkOrga = New DevExpress.XtraEditors.CheckEdit()
        Me.ChkConsigne = New DevExpress.XtraEditors.CheckEdit()
        Me.ChkHumaine = New DevExpress.XtraEditors.CheckEdit()
        Me.GrpBoxSuiviAction = New System.Windows.Forms.GroupBox()
        Me.BtnSaveComSuiviAction = New System.Windows.Forms.Button()
        Me.Label12 = New System.Windows.Forms.Label()
        Me.GrpEtatSuiviAction = New System.Windows.Forms.GroupBox()
        Me.Label15 = New System.Windows.Forms.Label()
        Me.RB_Termine_SuiviAction = New System.Windows.Forms.RadioButton()
        Me.RB_Encours_SuiviAction = New System.Windows.Forms.RadioButton()
        Me.MemoEditCom_SuiviAction = New DevExpress.XtraEditors.MemoEdit()
        CType(Me.ChkTypeSitu3.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.GrpBoxFormationEI.SuspendLayout()
        Me.GrpBoxPhotos.SuspendLayout()
        Me.GrpBoxFait.SuspendLayout()
        CType(Me.MemoEditFaits.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.GrpBoxVictimes.SuspendLayout()
        CType(Me.TxtEditVVICTIME_3.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.TxtEditVVICTIME_2.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.TxtEditVVICTIME_1.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.ChkVictime3.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.ChkVictime2.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.ChkVictime1.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.GrpBoxSituDanger.SuspendLayout()
        CType(Me.ChkTypeSitu2.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.ChkTypeSitu1.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.GrpBoxEntete.SuspendLayout()
        Me.GrpBoxObject.SuspendLayout()
        Me.GrpBoxActions.SuspendLayout()
        Me.GrpBoxReponse.SuspendLayout()
        Me.GrpBoxLectureTech.SuspendLayout()
        Me.GrpBoxInfo.SuspendLayout()
        Me.GrpReponseTech.SuspendLayout()
        CType(Me.MemoRep.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.GrpBoxCotation.SuspendLayout()
        CType(Me.CboCotation.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.GrpBoxAnalyse.SuspendLayout()
        CType(Me.ChkAutres.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.ChkMilieu.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.ChkMate.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.ChkForm.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.ChkOrga.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.ChkConsigne.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.ChkHumaine.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.GrpBoxSuiviAction.SuspendLayout()
        Me.GrpEtatSuiviAction.SuspendLayout()
        CType(Me.MemoEditCom_SuiviAction.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'Label10
        '
        resources.ApplyResources(Me.Label10, "Label10")
        Me.Label10.ForeColor = System.Drawing.Color.Black
        Me.Label10.Name = "Label10"
        '
        'Label9
        '
        resources.ApplyResources(Me.Label9, "Label9")
        Me.Label9.ForeColor = System.Drawing.Color.Black
        Me.Label9.Name = "Label9"
        '
        'Label7
        '
        resources.ApplyResources(Me.Label7, "Label7")
        Me.Label7.ForeColor = System.Drawing.Color.Black
        Me.Label7.Name = "Label7"
        '
        'Label5
        '
        resources.ApplyResources(Me.Label5, "Label5")
        Me.Label5.ForeColor = System.Drawing.Color.Black
        Me.Label5.Name = "Label5"
        '
        'Label3
        '
        resources.ApplyResources(Me.Label3, "Label3")
        Me.Label3.ForeColor = System.Drawing.Color.Black
        Me.Label3.Name = "Label3"
        '
        'Label8
        '
        resources.ApplyResources(Me.Label8, "Label8")
        Me.Label8.ForeColor = System.Drawing.Color.Black
        Me.Label8.Name = "Label8"
        '
        'ChkTypeSitu3
        '
        resources.ApplyResources(Me.ChkTypeSitu3, "ChkTypeSitu3")
        Me.ChkTypeSitu3.Name = "ChkTypeSitu3"
        Me.ChkTypeSitu3.Properties.Appearance.ForeColor = System.Drawing.Color.Black
        Me.ChkTypeSitu3.Properties.Appearance.Options.UseForeColor = True
        Me.ChkTypeSitu3.Properties.Caption = resources.GetString("ChkTypeSitu3.Properties.Caption")
        '
        'GrpBoxFormationEI
        '
        Me.GrpBoxFormationEI.Controls.Add(Me.GrpBoxPhotos)
        Me.GrpBoxFormationEI.Controls.Add(Me.GrpBoxFait)
        Me.GrpBoxFormationEI.Controls.Add(Me.GrpBoxVictimes)
        Me.GrpBoxFormationEI.Controls.Add(Me.GrpBoxSituDanger)
        Me.GrpBoxFormationEI.Controls.Add(Me.GrpBoxEntete)
        Me.GrpBoxFormationEI.Controls.Add(Me.GrpBoxObject)
        resources.ApplyResources(Me.GrpBoxFormationEI, "GrpBoxFormationEI")
        Me.GrpBoxFormationEI.ForeColor = System.Drawing.Color.Black
        Me.GrpBoxFormationEI.Name = "GrpBoxFormationEI"
        Me.GrpBoxFormationEI.TabStop = False
        '
        'GrpBoxPhotos
        '
        Me.GrpBoxPhotos.Controls.Add(Me.BtnSuppPhoto)
        Me.GrpBoxPhotos.Controls.Add(Me.BtnAddPhoto)
        Me.GrpBoxPhotos.Controls.Add(Me.LstViewPhotos)
        resources.ApplyResources(Me.GrpBoxPhotos, "GrpBoxPhotos")
        Me.GrpBoxPhotos.Name = "GrpBoxPhotos"
        Me.GrpBoxPhotos.TabStop = False
        '
        'BtnSuppPhoto
        '
        resources.ApplyResources(Me.BtnSuppPhoto, "BtnSuppPhoto")
        Me.BtnSuppPhoto.Name = "BtnSuppPhoto"
        Me.BtnSuppPhoto.Tag = "760"
        Me.BtnSuppPhoto.UseVisualStyleBackColor = True
        '
        'BtnAddPhoto
        '
        resources.ApplyResources(Me.BtnAddPhoto, "BtnAddPhoto")
        Me.BtnAddPhoto.Name = "BtnAddPhoto"
        Me.BtnAddPhoto.Tag = "760"
        Me.BtnAddPhoto.UseVisualStyleBackColor = True
        '
        'LstViewPhotos
        '
        Me.LstViewPhotos.HideSelection = False
        Me.LstViewPhotos.LargeImageList = Me.ImgLstFicheSituDang_Photos
        resources.ApplyResources(Me.LstViewPhotos, "LstViewPhotos")
        Me.LstViewPhotos.Name = "LstViewPhotos"
        Me.LstViewPhotos.UseCompatibleStateImageBehavior = False
        '
        'ImgLstFicheSituDang_Photos
        '
        Me.ImgLstFicheSituDang_Photos.ColorDepth = System.Windows.Forms.ColorDepth.Depth32Bit
        resources.ApplyResources(Me.ImgLstFicheSituDang_Photos, "ImgLstFicheSituDang_Photos")
        Me.ImgLstFicheSituDang_Photos.TransparentColor = System.Drawing.Color.Transparent
        '
        'GrpBoxFait
        '
        Me.GrpBoxFait.Controls.Add(Me.MemoEditFaits)
        resources.ApplyResources(Me.GrpBoxFait, "GrpBoxFait")
        Me.GrpBoxFait.Name = "GrpBoxFait"
        Me.GrpBoxFait.TabStop = False
        '
        'MemoEditFaits
        '
        resources.ApplyResources(Me.MemoEditFaits, "MemoEditFaits")
        Me.MemoEditFaits.Name = "MemoEditFaits"
        '
        'GrpBoxVictimes
        '
        Me.GrpBoxVictimes.Controls.Add(Me.TxtEditVVICTIME_3)
        Me.GrpBoxVictimes.Controls.Add(Me.TxtEditVVICTIME_2)
        Me.GrpBoxVictimes.Controls.Add(Me.TxtEditVVICTIME_1)
        Me.GrpBoxVictimes.Controls.Add(Me.ChkVictime3)
        Me.GrpBoxVictimes.Controls.Add(Me.ChkVictime2)
        Me.GrpBoxVictimes.Controls.Add(Me.ChkVictime1)
        resources.ApplyResources(Me.GrpBoxVictimes, "GrpBoxVictimes")
        Me.GrpBoxVictimes.Name = "GrpBoxVictimes"
        Me.GrpBoxVictimes.TabStop = False
        '
        'TxtEditVVICTIME_3
        '
        resources.ApplyResources(Me.TxtEditVVICTIME_3, "TxtEditVVICTIME_3")
        Me.TxtEditVVICTIME_3.Name = "TxtEditVVICTIME_3"
        '
        'TxtEditVVICTIME_2
        '
        resources.ApplyResources(Me.TxtEditVVICTIME_2, "TxtEditVVICTIME_2")
        Me.TxtEditVVICTIME_2.Name = "TxtEditVVICTIME_2"
        '
        'TxtEditVVICTIME_1
        '
        resources.ApplyResources(Me.TxtEditVVICTIME_1, "TxtEditVVICTIME_1")
        Me.TxtEditVVICTIME_1.Name = "TxtEditVVICTIME_1"
        '
        'ChkVictime3
        '
        resources.ApplyResources(Me.ChkVictime3, "ChkVictime3")
        Me.ChkVictime3.Name = "ChkVictime3"
        Me.ChkVictime3.Properties.Appearance.ForeColor = System.Drawing.Color.Black
        Me.ChkVictime3.Properties.Appearance.Options.UseForeColor = True
        Me.ChkVictime3.Properties.Caption = resources.GetString("ChkVictime3.Properties.Caption")
        '
        'ChkVictime2
        '
        resources.ApplyResources(Me.ChkVictime2, "ChkVictime2")
        Me.ChkVictime2.Name = "ChkVictime2"
        Me.ChkVictime2.Properties.Appearance.ForeColor = System.Drawing.Color.Black
        Me.ChkVictime2.Properties.Appearance.Options.UseForeColor = True
        Me.ChkVictime2.Properties.Caption = resources.GetString("ChkVictime2.Properties.Caption")
        '
        'ChkVictime1
        '
        resources.ApplyResources(Me.ChkVictime1, "ChkVictime1")
        Me.ChkVictime1.Name = "ChkVictime1"
        Me.ChkVictime1.Properties.Appearance.ForeColor = System.Drawing.Color.Black
        Me.ChkVictime1.Properties.Appearance.Options.UseForeColor = True
        Me.ChkVictime1.Properties.Caption = resources.GetString("ChkVictime1.Properties.Caption")
        '
        'GrpBoxSituDanger
        '
        Me.GrpBoxSituDanger.Controls.Add(Me.Label11)
        Me.GrpBoxSituDanger.Controls.Add(Me.Label10)
        Me.GrpBoxSituDanger.Controls.Add(Me.Label9)
        Me.GrpBoxSituDanger.Controls.Add(Me.Label7)
        Me.GrpBoxSituDanger.Controls.Add(Me.Label5)
        Me.GrpBoxSituDanger.Controls.Add(Me.Label3)
        Me.GrpBoxSituDanger.Controls.Add(Me.ChkTypeSitu3)
        Me.GrpBoxSituDanger.Controls.Add(Me.ChkTypeSitu2)
        Me.GrpBoxSituDanger.Controls.Add(Me.ChkTypeSitu1)
        resources.ApplyResources(Me.GrpBoxSituDanger, "GrpBoxSituDanger")
        Me.GrpBoxSituDanger.Name = "GrpBoxSituDanger"
        Me.GrpBoxSituDanger.TabStop = False
        '
        'Label11
        '
        resources.ApplyResources(Me.Label11, "Label11")
        Me.Label11.ForeColor = System.Drawing.Color.Black
        Me.Label11.Name = "Label11"
        '
        'ChkTypeSitu2
        '
        resources.ApplyResources(Me.ChkTypeSitu2, "ChkTypeSitu2")
        Me.ChkTypeSitu2.Name = "ChkTypeSitu2"
        Me.ChkTypeSitu2.Properties.Appearance.ForeColor = System.Drawing.Color.Black
        Me.ChkTypeSitu2.Properties.Appearance.Options.UseForeColor = True
        Me.ChkTypeSitu2.Properties.Caption = resources.GetString("ChkTypeSitu2.Properties.Caption")
        '
        'ChkTypeSitu1
        '
        resources.ApplyResources(Me.ChkTypeSitu1, "ChkTypeSitu1")
        Me.ChkTypeSitu1.Name = "ChkTypeSitu1"
        Me.ChkTypeSitu1.Properties.Appearance.ForeColor = System.Drawing.Color.Black
        Me.ChkTypeSitu1.Properties.Appearance.Options.UseForeColor = True
        Me.ChkTypeSitu1.Properties.Caption = resources.GetString("ChkTypeSitu1.Properties.Caption")
        '
        'GrpBoxEntete
        '
        Me.GrpBoxEntete.Controls.Add(Me.BtnRechercheDI)
        Me.GrpBoxEntete.Controls.Add(Me.Txt_FicHeure)
        Me.GrpBoxEntete.Controls.Add(Me.Txt_FicDateCree)
        Me.GrpBoxEntete.Controls.Add(Me.Txt_Lieu)
        Me.GrpBoxEntete.Controls.Add(Me.Txt_DI)
        Me.GrpBoxEntete.Controls.Add(Me.Cbo_FicIntervenant)
        Me.GrpBoxEntete.Controls.Add(Me.Label8)
        Me.GrpBoxEntete.Controls.Add(Me.Label6)
        Me.GrpBoxEntete.Controls.Add(Me.Label4)
        Me.GrpBoxEntete.Controls.Add(Me.Label1)
        Me.GrpBoxEntete.Controls.Add(Me.Label2)
        resources.ApplyResources(Me.GrpBoxEntete, "GrpBoxEntete")
        Me.GrpBoxEntete.Name = "GrpBoxEntete"
        Me.GrpBoxEntete.TabStop = False
        '
        'BtnRechercheDI
        '
        resources.ApplyResources(Me.BtnRechercheDI, "BtnRechercheDI")
        Me.BtnRechercheDI.Name = "BtnRechercheDI"
        Me.BtnRechercheDI.UseVisualStyleBackColor = True
        '
        'Txt_FicHeure
        '
        resources.ApplyResources(Me.Txt_FicHeure, "Txt_FicHeure")
        Me.Txt_FicHeure.Name = "Txt_FicHeure"
        '
        'Txt_FicDateCree
        '
        resources.ApplyResources(Me.Txt_FicDateCree, "Txt_FicDateCree")
        Me.Txt_FicDateCree.Name = "Txt_FicDateCree"
        '
        'Txt_Lieu
        '
        resources.ApplyResources(Me.Txt_Lieu, "Txt_Lieu")
        Me.Txt_Lieu.Name = "Txt_Lieu"
        '
        'Txt_DI
        '
        resources.ApplyResources(Me.Txt_DI, "Txt_DI")
        Me.Txt_DI.Name = "Txt_DI"
        '
        'Cbo_FicIntervenant
        '
        Me.Cbo_FicIntervenant.DisplayMember = "TECH"
        Me.Cbo_FicIntervenant.FormattingEnabled = True
        resources.ApplyResources(Me.Cbo_FicIntervenant, "Cbo_FicIntervenant")
        Me.Cbo_FicIntervenant.Name = "Cbo_FicIntervenant"
        Me.Cbo_FicIntervenant.ValueMember = "NPERNUM"
        '
        'Label6
        '
        resources.ApplyResources(Me.Label6, "Label6")
        Me.Label6.ForeColor = System.Drawing.Color.Black
        Me.Label6.Name = "Label6"
        '
        'Label4
        '
        resources.ApplyResources(Me.Label4, "Label4")
        Me.Label4.ForeColor = System.Drawing.Color.Black
        Me.Label4.Name = "Label4"
        '
        'Label1
        '
        resources.ApplyResources(Me.Label1, "Label1")
        Me.Label1.ForeColor = System.Drawing.Color.Black
        Me.Label1.Name = "Label1"
        '
        'Label2
        '
        resources.ApplyResources(Me.Label2, "Label2")
        Me.Label2.ForeColor = System.Drawing.Color.Black
        Me.Label2.Name = "Label2"
        '
        'GrpBoxObject
        '
        Me.GrpBoxObject.Controls.Add(Me.LblObjDemarche)
        resources.ApplyResources(Me.GrpBoxObject, "GrpBoxObject")
        Me.GrpBoxObject.Name = "GrpBoxObject"
        Me.GrpBoxObject.TabStop = False
        '
        'LblObjDemarche
        '
        resources.ApplyResources(Me.LblObjDemarche, "LblObjDemarche")
        Me.LblObjDemarche.ForeColor = System.Drawing.Color.Black
        Me.LblObjDemarche.Name = "LblObjDemarche"
        '
        'GrpBoxActions
        '
        Me.GrpBoxActions.Controls.Add(Me.BtnSave)
        Me.GrpBoxActions.Controls.Add(Me.BtnArchiver)
        Me.GrpBoxActions.Controls.Add(Me.BtnFermer)
        resources.ApplyResources(Me.GrpBoxActions, "GrpBoxActions")
        Me.GrpBoxActions.Name = "GrpBoxActions"
        Me.GrpBoxActions.TabStop = False
        '
        'BtnSave
        '
        resources.ApplyResources(Me.BtnSave, "BtnSave")
        Me.BtnSave.Name = "BtnSave"
        Me.BtnSave.Tag = "760"
        Me.BtnSave.UseVisualStyleBackColor = True
        '
        'BtnArchiver
        '
        resources.ApplyResources(Me.BtnArchiver, "BtnArchiver")
        Me.BtnArchiver.Name = "BtnArchiver"
        Me.BtnArchiver.Tag = "760"
        Me.BtnArchiver.UseVisualStyleBackColor = True
        '
        'BtnFermer
        '
        Me.BtnFermer.DialogResult = System.Windows.Forms.DialogResult.Cancel
        resources.ApplyResources(Me.BtnFermer, "BtnFermer")
        Me.BtnFermer.Name = "BtnFermer"
        Me.BtnFermer.UseVisualStyleBackColor = True
        '
        'GrpBoxReponse
        '
        Me.GrpBoxReponse.BackColor = System.Drawing.Color.Gainsboro
        Me.GrpBoxReponse.Controls.Add(Me.BtnValidRep)
        Me.GrpBoxReponse.Controls.Add(Me.GrpBoxLectureTech)
        Me.GrpBoxReponse.Controls.Add(Me.GrpBoxInfo)
        Me.GrpBoxReponse.Controls.Add(Me.BtnEnregistrer)
        Me.GrpBoxReponse.Controls.Add(Me.GrpReponseTech)
        Me.GrpBoxReponse.Controls.Add(Me.GrpBoxCotation)
        Me.GrpBoxReponse.Controls.Add(Me.GrpBoxAnalyse)
        resources.ApplyResources(Me.GrpBoxReponse, "GrpBoxReponse")
        Me.GrpBoxReponse.Name = "GrpBoxReponse"
        Me.GrpBoxReponse.TabStop = False
        '
        'BtnValidRep
        '
        resources.ApplyResources(Me.BtnValidRep, "BtnValidRep")
        Me.BtnValidRep.Name = "BtnValidRep"
        Me.BtnValidRep.Tag = "760"
        Me.BtnValidRep.UseVisualStyleBackColor = True
        '
        'GrpBoxLectureTech
        '
        Me.GrpBoxLectureTech.Controls.Add(Me.LblLectureTechDate)
        Me.GrpBoxLectureTech.Controls.Add(Me.Label16)
        resources.ApplyResources(Me.GrpBoxLectureTech, "GrpBoxLectureTech")
        Me.GrpBoxLectureTech.Name = "GrpBoxLectureTech"
        Me.GrpBoxLectureTech.TabStop = False
        '
        'LblLectureTechDate
        '
        Me.LblLectureTechDate.BackColor = System.Drawing.Color.White
        Me.LblLectureTechDate.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        resources.ApplyResources(Me.LblLectureTechDate, "LblLectureTechDate")
        Me.LblLectureTechDate.ForeColor = System.Drawing.Color.Black
        Me.LblLectureTechDate.Name = "LblLectureTechDate"
        '
        'Label16
        '
        resources.ApplyResources(Me.Label16, "Label16")
        Me.Label16.ForeColor = System.Drawing.Color.Black
        Me.Label16.Name = "Label16"
        '
        'GrpBoxInfo
        '
        Me.GrpBoxInfo.Controls.Add(Me.LblDeclarant)
        Me.GrpBoxInfo.Controls.Add(Me.Label14)
        Me.GrpBoxInfo.Controls.Add(Me.LblDateReponse)
        Me.GrpBoxInfo.Controls.Add(Me.Label20)
        resources.ApplyResources(Me.GrpBoxInfo, "GrpBoxInfo")
        Me.GrpBoxInfo.Name = "GrpBoxInfo"
        Me.GrpBoxInfo.TabStop = False
        '
        'LblDeclarant
        '
        Me.LblDeclarant.BackColor = System.Drawing.Color.White
        Me.LblDeclarant.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        resources.ApplyResources(Me.LblDeclarant, "LblDeclarant")
        Me.LblDeclarant.ForeColor = System.Drawing.Color.Black
        Me.LblDeclarant.Name = "LblDeclarant"
        '
        'Label14
        '
        resources.ApplyResources(Me.Label14, "Label14")
        Me.Label14.ForeColor = System.Drawing.Color.Black
        Me.Label14.Name = "Label14"
        '
        'LblDateReponse
        '
        Me.LblDateReponse.BackColor = System.Drawing.Color.White
        Me.LblDateReponse.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        resources.ApplyResources(Me.LblDateReponse, "LblDateReponse")
        Me.LblDateReponse.ForeColor = System.Drawing.Color.Black
        Me.LblDateReponse.Name = "LblDateReponse"
        '
        'Label20
        '
        resources.ApplyResources(Me.Label20, "Label20")
        Me.Label20.ForeColor = System.Drawing.Color.Black
        Me.Label20.Name = "Label20"
        '
        'BtnEnregistrer
        '
        resources.ApplyResources(Me.BtnEnregistrer, "BtnEnregistrer")
        Me.BtnEnregistrer.Name = "BtnEnregistrer"
        Me.BtnEnregistrer.Tag = "760"
        Me.BtnEnregistrer.UseVisualStyleBackColor = True
        '
        'GrpReponseTech
        '
        Me.GrpReponseTech.Controls.Add(Me.MemoRep)
        resources.ApplyResources(Me.GrpReponseTech, "GrpReponseTech")
        Me.GrpReponseTech.Name = "GrpReponseTech"
        Me.GrpReponseTech.TabStop = False
        '
        'MemoRep
        '
        resources.ApplyResources(Me.MemoRep, "MemoRep")
        Me.MemoRep.Name = "MemoRep"
        '
        'GrpBoxCotation
        '
        Me.GrpBoxCotation.Controls.Add(Me.cboRisque)
        Me.GrpBoxCotation.Controls.Add(Me.Label13)
        Me.GrpBoxCotation.Controls.Add(Me.Label22)
        Me.GrpBoxCotation.Controls.Add(Me.CboCotation)
        resources.ApplyResources(Me.GrpBoxCotation, "GrpBoxCotation")
        Me.GrpBoxCotation.Name = "GrpBoxCotation"
        Me.GrpBoxCotation.TabStop = False
        '
        'cboRisque
        '
        Me.cboRisque.DisplayMember = "VLIBRISQUE"
        Me.cboRisque.FormattingEnabled = True
        resources.ApplyResources(Me.cboRisque, "cboRisque")
        Me.cboRisque.Name = "cboRisque"
        Me.cboRisque.ValueMember = "ID"
        '
        'Label13
        '
        resources.ApplyResources(Me.Label13, "Label13")
        Me.Label13.ForeColor = System.Drawing.Color.Black
        Me.Label13.Name = "Label13"
        '
        'Label22
        '
        resources.ApplyResources(Me.Label22, "Label22")
        Me.Label22.ForeColor = System.Drawing.Color.Black
        Me.Label22.Name = "Label22"
        '
        'CboCotation
        '
        resources.ApplyResources(Me.CboCotation, "CboCotation")
        Me.CboCotation.Name = "CboCotation"
        Me.CboCotation.Properties.AllowDropDownWhenReadOnly = DevExpress.Utils.DefaultBoolean.[False]
        Me.CboCotation.Properties.Appearance.Options.UseTextOptions = True
        Me.CboCotation.Properties.Appearance.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center
        Me.CboCotation.Properties.Appearance.TextOptions.VAlignment = DevExpress.Utils.VertAlignment.Center
        Me.CboCotation.Properties.Buttons.AddRange(New DevExpress.XtraEditors.Controls.EditorButton() {New DevExpress.XtraEditors.Controls.EditorButton(CType(resources.GetObject("CboCotation.Properties.Buttons"), DevExpress.XtraEditors.Controls.ButtonPredefines))})
        Me.CboCotation.Properties.Items.AddRange(New Object() {resources.GetString("CboCotation.Properties.Items"), resources.GetString("CboCotation.Properties.Items1"), resources.GetString("CboCotation.Properties.Items2"), resources.GetString("CboCotation.Properties.Items3")})
        Me.CboCotation.Properties.TextEditStyle = DevExpress.XtraEditors.Controls.TextEditStyles.DisableTextEditor
        '
        'GrpBoxAnalyse
        '
        Me.GrpBoxAnalyse.Controls.Add(Me.TxtBoxAutres)
        Me.GrpBoxAnalyse.Controls.Add(Me.ChkAutres)
        Me.GrpBoxAnalyse.Controls.Add(Me.ChkMilieu)
        Me.GrpBoxAnalyse.Controls.Add(Me.ChkMate)
        Me.GrpBoxAnalyse.Controls.Add(Me.ChkForm)
        Me.GrpBoxAnalyse.Controls.Add(Me.ChkOrga)
        Me.GrpBoxAnalyse.Controls.Add(Me.ChkConsigne)
        Me.GrpBoxAnalyse.Controls.Add(Me.ChkHumaine)
        resources.ApplyResources(Me.GrpBoxAnalyse, "GrpBoxAnalyse")
        Me.GrpBoxAnalyse.Name = "GrpBoxAnalyse"
        Me.GrpBoxAnalyse.TabStop = False
        '
        'TxtBoxAutres
        '
        resources.ApplyResources(Me.TxtBoxAutres, "TxtBoxAutres")
        Me.TxtBoxAutres.Name = "TxtBoxAutres"
        '
        'ChkAutres
        '
        resources.ApplyResources(Me.ChkAutres, "ChkAutres")
        Me.ChkAutres.Name = "ChkAutres"
        Me.ChkAutres.Properties.Appearance.ForeColor = System.Drawing.Color.Black
        Me.ChkAutres.Properties.Appearance.Options.UseForeColor = True
        Me.ChkAutres.Properties.Caption = resources.GetString("ChkAutres.Properties.Caption")
        '
        'ChkMilieu
        '
        resources.ApplyResources(Me.ChkMilieu, "ChkMilieu")
        Me.ChkMilieu.Name = "ChkMilieu"
        Me.ChkMilieu.Properties.Appearance.ForeColor = System.Drawing.Color.Black
        Me.ChkMilieu.Properties.Appearance.Options.UseForeColor = True
        Me.ChkMilieu.Properties.Caption = resources.GetString("ChkMilieu.Properties.Caption")
        '
        'ChkMate
        '
        resources.ApplyResources(Me.ChkMate, "ChkMate")
        Me.ChkMate.Name = "ChkMate"
        Me.ChkMate.Properties.Appearance.ForeColor = System.Drawing.Color.Black
        Me.ChkMate.Properties.Appearance.Options.UseForeColor = True
        Me.ChkMate.Properties.Caption = resources.GetString("ChkMate.Properties.Caption")
        '
        'ChkForm
        '
        resources.ApplyResources(Me.ChkForm, "ChkForm")
        Me.ChkForm.Name = "ChkForm"
        Me.ChkForm.Properties.Appearance.ForeColor = System.Drawing.Color.Black
        Me.ChkForm.Properties.Appearance.Options.UseForeColor = True
        Me.ChkForm.Properties.Caption = resources.GetString("ChkForm.Properties.Caption")
        '
        'ChkOrga
        '
        resources.ApplyResources(Me.ChkOrga, "ChkOrga")
        Me.ChkOrga.Name = "ChkOrga"
        Me.ChkOrga.Properties.Appearance.ForeColor = System.Drawing.Color.Black
        Me.ChkOrga.Properties.Appearance.Options.UseForeColor = True
        Me.ChkOrga.Properties.Caption = resources.GetString("ChkOrga.Properties.Caption")
        '
        'ChkConsigne
        '
        resources.ApplyResources(Me.ChkConsigne, "ChkConsigne")
        Me.ChkConsigne.Name = "ChkConsigne"
        Me.ChkConsigne.Properties.Appearance.ForeColor = System.Drawing.Color.Black
        Me.ChkConsigne.Properties.Appearance.Options.UseForeColor = True
        Me.ChkConsigne.Properties.Caption = resources.GetString("ChkConsigne.Properties.Caption")
        '
        'ChkHumaine
        '
        resources.ApplyResources(Me.ChkHumaine, "ChkHumaine")
        Me.ChkHumaine.Name = "ChkHumaine"
        Me.ChkHumaine.Properties.Appearance.ForeColor = System.Drawing.Color.Black
        Me.ChkHumaine.Properties.Appearance.Options.UseForeColor = True
        Me.ChkHumaine.Properties.Caption = resources.GetString("ChkHumaine.Properties.Caption")
        '
        'GrpBoxSuiviAction
        '
        Me.GrpBoxSuiviAction.BackColor = System.Drawing.Color.LightSteelBlue
        Me.GrpBoxSuiviAction.Controls.Add(Me.BtnSaveComSuiviAction)
        Me.GrpBoxSuiviAction.Controls.Add(Me.Label12)
        Me.GrpBoxSuiviAction.Controls.Add(Me.GrpEtatSuiviAction)
        Me.GrpBoxSuiviAction.Controls.Add(Me.MemoEditCom_SuiviAction)
        resources.ApplyResources(Me.GrpBoxSuiviAction, "GrpBoxSuiviAction")
        Me.GrpBoxSuiviAction.Name = "GrpBoxSuiviAction"
        Me.GrpBoxSuiviAction.TabStop = False
        '
        'BtnSaveComSuiviAction
        '
        resources.ApplyResources(Me.BtnSaveComSuiviAction, "BtnSaveComSuiviAction")
        Me.BtnSaveComSuiviAction.Name = "BtnSaveComSuiviAction"
        Me.BtnSaveComSuiviAction.Tag = "760"
        Me.BtnSaveComSuiviAction.UseVisualStyleBackColor = True
        '
        'Label12
        '
        resources.ApplyResources(Me.Label12, "Label12")
        Me.Label12.ForeColor = System.Drawing.Color.Black
        Me.Label12.Name = "Label12"
        '
        'GrpEtatSuiviAction
        '
        Me.GrpEtatSuiviAction.Controls.Add(Me.Label15)
        Me.GrpEtatSuiviAction.Controls.Add(Me.RB_Termine_SuiviAction)
        Me.GrpEtatSuiviAction.Controls.Add(Me.RB_Encours_SuiviAction)
        resources.ApplyResources(Me.GrpEtatSuiviAction, "GrpEtatSuiviAction")
        Me.GrpEtatSuiviAction.Name = "GrpEtatSuiviAction"
        Me.GrpEtatSuiviAction.TabStop = False
        '
        'Label15
        '
        Me.Label15.BackColor = System.Drawing.Color.White
        Me.Label15.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        resources.ApplyResources(Me.Label15, "Label15")
        Me.Label15.Name = "Label15"
        '
        'RB_Termine_SuiviAction
        '
        resources.ApplyResources(Me.RB_Termine_SuiviAction, "RB_Termine_SuiviAction")
        Me.RB_Termine_SuiviAction.Name = "RB_Termine_SuiviAction"
        Me.RB_Termine_SuiviAction.TabStop = True
        Me.RB_Termine_SuiviAction.UseVisualStyleBackColor = True
        '
        'RB_Encours_SuiviAction
        '
        resources.ApplyResources(Me.RB_Encours_SuiviAction, "RB_Encours_SuiviAction")
        Me.RB_Encours_SuiviAction.Name = "RB_Encours_SuiviAction"
        Me.RB_Encours_SuiviAction.TabStop = True
        Me.RB_Encours_SuiviAction.UseVisualStyleBackColor = True
        '
        'MemoEditCom_SuiviAction
        '
        resources.ApplyResources(Me.MemoEditCom_SuiviAction, "MemoEditCom_SuiviAction")
        Me.MemoEditCom_SuiviAction.Name = "MemoEditCom_SuiviAction"
        '
        'frmFicSituDanger_Detail
        '
        resources.ApplyResources(Me, "$this")
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.Wheat
        Me.CancelButton = Me.BtnFermer
        Me.Controls.Add(Me.GrpBoxSuiviAction)
        Me.Controls.Add(Me.GrpBoxReponse)
        Me.Controls.Add(Me.GrpBoxActions)
        Me.Controls.Add(Me.GrpBoxFormationEI)
        Me.Name = "frmFicSituDanger_Detail"
        Me.WindowState = System.Windows.Forms.FormWindowState.Maximized
        CType(Me.ChkTypeSitu3.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        Me.GrpBoxFormationEI.ResumeLayout(False)
        Me.GrpBoxPhotos.ResumeLayout(False)
        Me.GrpBoxFait.ResumeLayout(False)
        CType(Me.MemoEditFaits.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        Me.GrpBoxVictimes.ResumeLayout(False)
        CType(Me.TxtEditVVICTIME_3.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.TxtEditVVICTIME_2.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.TxtEditVVICTIME_1.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.ChkVictime3.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.ChkVictime2.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.ChkVictime1.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        Me.GrpBoxSituDanger.ResumeLayout(False)
        CType(Me.ChkTypeSitu2.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.ChkTypeSitu1.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        Me.GrpBoxEntete.ResumeLayout(False)
        Me.GrpBoxEntete.PerformLayout()
        Me.GrpBoxObject.ResumeLayout(False)
        Me.GrpBoxActions.ResumeLayout(False)
        Me.GrpBoxReponse.ResumeLayout(False)
        Me.GrpBoxLectureTech.ResumeLayout(False)
        Me.GrpBoxInfo.ResumeLayout(False)
        Me.GrpReponseTech.ResumeLayout(False)
        CType(Me.MemoRep.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        Me.GrpBoxCotation.ResumeLayout(False)
        CType(Me.CboCotation.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        Me.GrpBoxAnalyse.ResumeLayout(False)
        Me.GrpBoxAnalyse.PerformLayout()
        CType(Me.ChkAutres.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.ChkMilieu.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.ChkMate.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.ChkForm.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.ChkOrga.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.ChkConsigne.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.ChkHumaine.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        Me.GrpBoxSuiviAction.ResumeLayout(False)
        Me.GrpEtatSuiviAction.ResumeLayout(False)
        Me.GrpEtatSuiviAction.PerformLayout()
        CType(Me.MemoEditCom_SuiviAction.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)

    End Sub

    Friend WithEvents Label10 As Label
    Friend WithEvents Label9 As Label
    Friend WithEvents Label7 As Label
    Friend WithEvents Label5 As Label
    Friend WithEvents Label3 As Label
    Friend WithEvents Label8 As Label
    Friend WithEvents ChkTypeSitu3 As DevExpress.XtraEditors.CheckEdit
    Friend WithEvents GrpBoxFormationEI As GroupBox
    Friend WithEvents GrpBoxFait As GroupBox
    Friend WithEvents GrpBoxVictimes As GroupBox
    Friend WithEvents TxtEditVVICTIME_3 As DevExpress.XtraEditors.TextEdit
    Friend WithEvents TxtEditVVICTIME_2 As DevExpress.XtraEditors.TextEdit
    Friend WithEvents TxtEditVVICTIME_1 As DevExpress.XtraEditors.TextEdit
    Friend WithEvents ChkVictime3 As DevExpress.XtraEditors.CheckEdit
    Friend WithEvents ChkVictime2 As DevExpress.XtraEditors.CheckEdit
    Friend WithEvents ChkVictime1 As DevExpress.XtraEditors.CheckEdit
    Friend WithEvents GrpBoxSituDanger As GroupBox
    Friend WithEvents Label11 As Label
    Friend WithEvents ChkTypeSitu2 As DevExpress.XtraEditors.CheckEdit
    Friend WithEvents ChkTypeSitu1 As DevExpress.XtraEditors.CheckEdit
    Friend WithEvents GrpBoxEntete As GroupBox
    Friend WithEvents Label6 As Label
    Friend WithEvents Label4 As Label
    Friend WithEvents Label1 As Label
    Friend WithEvents Label2 As Label
    Friend WithEvents GrpBoxObject As GroupBox
    Friend WithEvents LblObjDemarche As Label
    Friend WithEvents ODF As OpenFileDialog
    Friend WithEvents GrpBoxActions As GroupBox
    Friend WithEvents BtnFermer As Button
    Friend WithEvents GrpBoxReponse As GroupBox
    Friend WithEvents GrpReponseTech As GroupBox
    Friend WithEvents GrpBoxCotation As GroupBox
    Friend WithEvents GrpBoxAnalyse As GroupBox
    Friend WithEvents ChkOrga As DevExpress.XtraEditors.CheckEdit
    Friend WithEvents ChkConsigne As DevExpress.XtraEditors.CheckEdit
    Friend WithEvents ChkHumaine As DevExpress.XtraEditors.CheckEdit
    Friend WithEvents BtnEnregistrer As Button
    Friend WithEvents GrpBoxInfo As GroupBox
    Friend WithEvents LblDeclarant As Label
    Friend WithEvents Label14 As Label
    Friend WithEvents LblDateReponse As Label
    Friend WithEvents Label20 As Label
    Friend WithEvents Label22 As Label
    Friend WithEvents CboCotation As DevExpress.XtraEditors.ComboBoxEdit
    Friend WithEvents ChkMilieu As DevExpress.XtraEditors.CheckEdit
    Friend WithEvents ChkMate As DevExpress.XtraEditors.CheckEdit
    Friend WithEvents ChkForm As DevExpress.XtraEditors.CheckEdit
    Friend WithEvents TxtBoxAutres As TextBox
    Friend WithEvents ChkAutres As DevExpress.XtraEditors.CheckEdit
    Friend WithEvents GrpBoxLectureTech As GroupBox
    Friend WithEvents LblLectureTechDate As Label
    Friend WithEvents Label16 As Label
    Friend WithEvents BtnValidRep As Button
    Friend WithEvents ImgLstFicheSituDang_Photos As ImageList
    Friend WithEvents GrpBoxPhotos As GroupBox
    Friend WithEvents LstViewPhotos As ListView
    Friend WithEvents MemoEditFaits As DevExpress.XtraEditors.MemoEdit
    Friend WithEvents MemoRep As DevExpress.XtraEditors.MemoEdit
    Friend WithEvents BtnSuppPhoto As Button
    Friend WithEvents BtnAddPhoto As Button
    Friend WithEvents BtnArchiver As Button
    Friend WithEvents GrpBoxSuiviAction As GroupBox
    Friend WithEvents GrpEtatSuiviAction As GroupBox
    Friend WithEvents MemoEditCom_SuiviAction As DevExpress.XtraEditors.MemoEdit
    Friend WithEvents Label12 As Label
    Friend WithEvents BtnSaveComSuiviAction As Button
    Friend WithEvents RB_Termine_SuiviAction As RadioButton
    Friend WithEvents RB_Encours_SuiviAction As RadioButton
    Friend WithEvents BtnSave As Button
    Friend WithEvents Cbo_FicIntervenant As ComboBox
    Friend WithEvents Txt_DI As TextBox
    Friend WithEvents Txt_FicHeure As TextBox
    Friend WithEvents Txt_FicDateCree As TextBox
    Friend WithEvents Txt_Lieu As TextBox
    Friend WithEvents BtnRechercheDI As Button
    Friend WithEvents Label13 As Label
    Friend WithEvents cboRisque As ComboBox
    Friend WithEvents Label15 As Label
End Class
