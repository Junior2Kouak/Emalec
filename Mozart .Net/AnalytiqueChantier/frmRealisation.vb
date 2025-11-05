Imports System.Data.SqlClient
Imports System.Drawing.Printing
Imports System.Reflection
Imports DevExpress.XtraEditors
Imports Microsoft.Office.Interop
Imports MozartControls
Imports MozartLib
Imports MZUtils = MozartControls.Utils

Public Class frmRealisation
  Private iSTTok As Integer = 0
  Private iFOok As Integer = 0
  Private iMOok As Integer = 0
  Private iSTTSAISIEok As Integer = 0
  Private bEnreg As Boolean
  Private TabInfo As New ArrayList()
  Private memoryImage As Bitmap
  Private thumb As Bitmap

  WithEvents printDoc As New PrintDocument

  Private oChantierRealise As Object
  Private oChantier_A_Realise As Object
  Private oChantierSynthese As Object
  Private oChantierSyntheseDetails As Object
  Private oChantierCalculRealisation As Object
  Private oChantierCalculTotal As Object
  Private oChantierAnaMARGE As Object
  Private oChantierSyntheseRea As Object
  Private oChantierSyntheseAna As Object

  Private iNIDCHANTIER As Integer

  Private bReadOnly As Boolean

  Public Sub New(ByVal c_NIDCHANTIER As Integer, ByVal c_bReadOnly As Boolean)

    ' Cet appel est requis par le concepteur.
    InitializeComponent()

    ' Ajoutez une initialisation quelconque après l'appel InitializeComponent().
    iNIDCHANTIER = c_NIDCHANTIER
    bReadOnly = c_bReadOnly

  End Sub

  Private Sub frmRealisation_Load(ByVal sender As Object, ByVal e As EventArgs) Handles MyBase.Load

    bEnreg = False

    'init langue
    'If MozartParams.Langue <> "ES" Then
    '  txtsrPMN.Properties.Mask.EditMask = "n2"
    'End If

    'init affichage
    Label6.Text = String.Format(Label6.Text & " ({0})", TxMOOuv)
    Label87.Text = String.Format(Label87.Text & " ({0})", TxMO_Meca)
    Label88.Text = String.Format(Label88.Text & " ({0})", TxMO_Cabl)
    Label89.Text = String.Format(Label89.Text & " ({0})", TxMO_AideTec)

    Label8.Text = String.Format(Label8.Text & " ({0})", TxMOAss)
    Label9.Text = String.Format(Label9.Text & " ({0})", TxMOChaf)

    Label10.Text = String.Format(Label10.Text & " ({0})", TxMOBE)
    Label80.Text = String.Format(Label80.Text & " ({0})", TxMOBE_Auto)
    Label84.Text = String.Format(Label84.Text & " ({0})", TxMOBE_Elec)
    Label85.Text = String.Format(Label85.Text & " ({0})", TxMOBE_Meca)

    Label11.Text = String.Format(Label11.Text & " ({0})", TxPanier)
    Label12.Text = String.Format(Label12.Text & " ({0})", TxGD)
    Label13.Text = String.Format(Label13.Text & " ({0})", TxKM)
    Label38.Text = String.Format(Label38.Text & " ({0})", TxDeplace)

    Label31.Text = String.Format("Frais généraux ({0:p2})", GetTauxFG())

    FontBar1.FloatLocation = New Point(Label35.Location.X + Label35.Size.Width + 5, Label35.Location.Y)

    Realise()
    ResteARealise()
    SyntheseChantier()
    CalculRealisation()

    'gestion affichage
    If bReadOnly Then
      btnValider.Visible = False
      txtrAss.Properties.ReadOnly = True

      txtrGD.Properties.ReadOnly = True
      txtrKM.Properties.ReadOnly = True
      txtrmdivers.Properties.ReadOnly = True

    Else
      btnValider.Visible = True
    End If

    If MozartParams.NomSociete = "EMALECMPM" Then

      LblProrata.Visible = False
      txtcmPRO.Visible = False
      txtPRO.Visible = False
      txtrmPRO.Visible = False
      txttPRO.Visible = False
      txtanaPRO.Visible = False

    End If

    setVisible(RechercheDroitMenu(744))

    Me.Cursor = Cursors.Default
  End Sub

  Private Sub setVisible(pBIsVisible As Boolean)
    txtMOA.Visible = pBIsVisible
    txtrMOA.Visible = pBIsVisible
    txttMOA.Visible = pBIsVisible
    txtanamMOA.Visible = pBIsVisible
    txtanapMOA.Visible = pBIsVisible

    txtmass.Visible = pBIsVisible
    txtrmass.Visible = pBIsVisible
    txttmass.Visible = pBIsVisible
    txtanamass.Visible = pBIsVisible

    txtmchaf.Visible = pBIsVisible
    txtrmchaf.Visible = pBIsVisible
    txttmchaf.Visible = pBIsVisible
    txtanamchaf.Visible = pBIsVisible

    txtMOA_BE.Visible = pBIsVisible
    txtrMOA_BE.Visible = pBIsVisible
    txttMOA_BE.Visible = pBIsVisible
    txtanamMOA_BE.Visible = pBIsVisible
    txtanapMOA_BE.Visible = pBIsVisible

    txtmbe.Visible = pBIsVisible
    txtrmbe.Visible = pBIsVisible
    txttmbe.Visible = pBIsVisible
    txtanambe.Visible = pBIsVisible

    txtmbe_auto.Visible = pBIsVisible
    txtrmbe_auto.Visible = pBIsVisible
    txttmbe_auto.Visible = pBIsVisible
    txtanambe_auto.Visible = pBIsVisible

    txtmbe_elec.Visible = pBIsVisible
    txtrmbe_elec.Visible = pBIsVisible
    txttmbe_elec.Visible = pBIsVisible
    txtanambe_elec.Visible = pBIsVisible

    txtmbe_meca.Visible = pBIsVisible
    txtrmbe_meca.Visible = pBIsVisible
    txttmbe_meca.Visible = pBIsVisible
    txtanambe_meca.Visible = pBIsVisible
  End Sub

  Private Sub frmRealisation_FormClosed(ByVal sender As Object, ByVal e As FormClosedEventArgs) Handles Me.FormClosed
    TabInfo.Clear()
    Me.Dispose()
  End Sub

  Private Sub ResteARealise()
    Try

      oChantier_A_Realise = New StructChantier_A_Realise(iNIDCHANTIER)

      txtrOuv.Text = oChantier_A_Realise.MO

      txtrOuv_meca.Text = oChantier_A_Realise.MO_MECA
      txtrOuv_cabl.Text = oChantier_A_Realise.MO_CABL
      txtrOuv_aidetec.Text = oChantier_A_Realise.MO_AIDETEC

      txtrAss.Text = oChantier_A_Realise.NMOASS
      txtrChaf.Text = oChantier_A_Realise.NMOCHAF
      txtrBE.Text = oChantier_A_Realise.NMOBE

      txtrBE_auto.Text = oChantier_A_Realise.NMOBE_AUTO
      txtrBE_elec.Text = oChantier_A_Realise.NMOBE_ELEC
      txtrBE_meca.Text = oChantier_A_Realise.NMOBE_MECA

      txtrPan.Text = oChantier_A_Realise.PAN
      txtrGD.Text = oChantier_A_Realise.NGD
      txtrKM.Text = oChantier_A_Realise.NKM
      txtr_HR_DEPLACE.Text = oChantier_A_Realise.HR_DEPLACE
      txtrmdivers.Text = oChantier_A_Realise.NDIVERS
      txtrmFO.Text = oChantier_A_Realise.FO
      txtrmSTT.Text = oChantier_A_Realise.STT

      lblDEnreg.Text = My.Resources.Admin_frmRealisation_Date_enreg & oChantier_A_Realise.DDATMOD

    Catch ex As Exception
      MZUtils.displayError(MethodBase.GetCurrentMethod().Name, ex)
    End Try
  End Sub

  Private Sub Realise()

    Try

      oChantierRealise = New StructChantierRealise(iNIDCHANTIER, MozartParams.NomSociete)

      txtMOP.Text = oChantierRealise.MOP
      txtqouv.Text = oChantierRealise.HRTECH
      txtmouv.Text = oChantierRealise.CTTECH
      txtmint.Text = oChantierRealise.INTERIM

      txtqouv_meca.Text = oChantierRealise.HRTECH_MECA
      txtmouv_meca.Text = oChantierRealise.CTTECH_MECA
      txtqouv_cabl.Text = oChantierRealise.HRTECH_CABL
      txtmouv_cabl.Text = oChantierRealise.CTTECH_CABL
      txtqouv_aidetec.Text = oChantierRealise.HRTECH_AIDETEC
      txtmouv_aidetec.Text = oChantierRealise.CTTECH_AIDETEC

      txtMOA.Text = oChantierRealise.MOA
      txtMOA_BE.Text = oChantierRealise.MOA_BE

      txtqass.Text = oChantierRealise.HRASS
      txtmass.Text = oChantierRealise.CTASS
      txtqchaf.Text = oChantierRealise.HRCHAFF
      txtmchaf.Text = oChantierRealise.CTCHAFF
      txtqbe.Text = oChantierRealise.HRBE
      txtmbe.Text = oChantierRealise.CTBE

      txtqbe_auto.Text = oChantierRealise.HRBE_auto
      txtmbe_auto.Text = oChantierRealise.CTBE_auto
      txtqbe_elec.Text = oChantierRealise.HRBE_elec
      txtmbe_elec.Text = oChantierRealise.CTBE_elec
      txtqbe_meca.Text = oChantierRealise.HRBE_meca
      txtmbe_meca.Text = oChantierRealise.CTBE_meca

      txtqpan.Text = oChantierRealise.NBREPAS
      txtmpan.Text = oChantierRealise.CTREPAS
      txtqgd.Text = oChantierRealise.NBGD
      txtmgd.Text = oChantierRealise.CTGD
      txtqkm.Text = oChantierRealise.NBKM
      txtmkm.Text = oChantierRealise.CTKM
      txtqdeplace.Text = oChantierRealise.NB_DEPLACE
      txtmdeplace.Text = oChantierRealise.CT_DEPLACE

      txtmdivers.Text = oChantierRealise.CTFRAIS
      txtFRAIS.Text = oChantierRealise.FRAIS
      txtcde.Text = oChantierRealise.CTCDE
      txtss.Text = oChantierRealise.CTSS
      txtFO.Text = oChantierRealise.FO
      txtSTT.Text = oChantierRealise.CTCS

    Catch ex As Exception
      MZUtils.displayError(MethodBase.GetCurrentMethod().Name, ex)
    End Try
  End Sub

  Private Sub CalculRealisation()
    Try

      oChantierCalculRealisation = New StructChantierCalculRealisation(oChantier_A_Realise)

      txtrmouv.Text = oChantierCalculRealisation.RMOUV
      txtrMOP.Text = oChantierCalculRealisation.RMOP

      txtrmouv_meca.Text = oChantierCalculRealisation.RMOUV_MECA
      txtrmouv_cabl.Text = oChantierCalculRealisation.RMOUV_CABL
      txtrmouv_aidetec.Text = oChantierCalculRealisation.RMOUV_AIDETEC

      txtrmass.Text = oChantierCalculRealisation.RMASS
      txtrmchaf.Text = oChantierCalculRealisation.RMCHAF
      txtrmbe.Text = oChantierCalculRealisation.RMBE

      txtrmbe_auto.Text = oChantierCalculRealisation.RMBE_auto
      txtrmbe_elec.Text = oChantierCalculRealisation.RMBE_ELEC
      txtrmbe_meca.Text = oChantierCalculRealisation.RMBE_MECA

      txtrMOA.Text = oChantierCalculRealisation.RMOA
      txtrMOA_BE.Text = oChantierCalculRealisation.RMOA_BE

      txtrmpan.Text = oChantierCalculRealisation.RMPAN
      txtrmgd.Text = oChantierCalculRealisation.RMGD
      txtrmkm.Text = oChantierCalculRealisation.RMKM

      txtrm_HR_DEPLACE.Text = oChantierCalculRealisation.RM_HR_DEPLACE

      txtrFRAIS.Text = oChantierCalculRealisation.RFRAIS

      CalculTotal()
      Analyse()
      SyntheseRea()
      'SyntheseAna()

    Catch ex As Exception
      MZUtils.displayError(MethodBase.GetCurrentMethod().Name, ex)
    End Try
  End Sub

  Private Sub CalculTotal()
    Try

      oChantierCalculTotal = New StructChantierCalculTotal(oChantierRealise, oChantierCalculRealisation, oChantier_A_Realise)

      txttMOP.Text = oChantierCalculTotal.TMOP
      txttouv.Text = oChantierCalculTotal.TOUV
      txttmouv.Text = oChantierCalculTotal.TMOUV
      txttmint.Text = oChantierCalculTotal.TMINT

      txttouv_meca.Text = oChantierCalculTotal.TOUV_MECA
      txttmouv_meca.Text = oChantierCalculTotal.TMOUV_MECA
      txttouv_cabl.Text = oChantierCalculTotal.TOUV_CABL
      txttmouv_cabl.Text = oChantierCalculTotal.TMOUV_CABL
      txttouv_aidetec.Text = oChantierCalculTotal.TOUV_AIDETEC
      txttmouv_aidetec.Text = oChantierCalculTotal.TMOUV_AIDETEC

      txttMOA.Text = oChantierCalculTotal.TMOA
      txttMOA_BE.Text = oChantierCalculTotal.TMOA_BE

      txttass.Text = oChantierCalculTotal.TASS
      txttmass.Text = oChantierCalculTotal.TMASS
      txttchaf.Text = oChantierCalculTotal.TCHAF
      txttmchaf.Text = oChantierCalculTotal.TMCHAF
      txttbe.Text = oChantierCalculTotal.TBE
      txttmbe.Text = oChantierCalculTotal.TMBE

      txttbe_auto.Text = oChantierCalculTotal.TBE_AUTO
      txttmbe_auto.Text = oChantierCalculTotal.TMBE_AUTO
      txttbe_elec.Text = oChantierCalculTotal.TBE_ELEC
      txttmbe_elec.Text = oChantierCalculTotal.TMBE_ELEC
      txttbe_meca.Text = oChantierCalculTotal.TBE_MECA
      txttmbe_meca.Text = oChantierCalculTotal.TMBE_MECA

      txttFRAIS.Text = oChantierCalculTotal.TFRAIS
      txttpan.Text = oChantierCalculTotal.TPAN
      txttmpan.Text = oChantierCalculTotal.TMPAN
      txttgd.Text = oChantierCalculTotal.TGD
      txttmgd.Text = oChantierCalculTotal.TMGD
      txttkm.Text = oChantierCalculTotal.TKM
      txttmkm.Text = oChantierCalculTotal.TMKM
      txttmdivers.Text = oChantierCalculTotal.TMDIVERS

      txtt_hr_deplace.Text = oChantierCalculTotal.T_HR_DEPLACE
      txttm_hr_deplace.Text = oChantierCalculTotal.TM_HR_DEPLACE

      txttFO.Text = oChantierCalculTotal.TFO
      txttSTT.Text = oChantierCalculTotal.TSTT

    Catch ex As Exception
      MZUtils.displayError(MethodBase.GetCurrentMethod().Name, ex)
    End Try
  End Sub

  Private Sub Analyse()

    Try

      oChantierSyntheseDetails = New StructSyntheseChantierDetails(iNIDCHANTIER, bReadOnly)

      Me.Text = oChantierSyntheseDetails.libelle

      ' rappel de chiffrage
      txtcMOP.Text = (oChantierSyntheseDetails.NMO * TxMOOuv) + (oChantierSyntheseDetails.NMO_MECA * TxMO_Meca) + (oChantierSyntheseDetails.NMO_CABL * TxMO_Cabl) + (oChantierSyntheseDetails.NMO_AIDETEC * TxMO_AideTec)

      txtcouv.Text = oChantierSyntheseDetails.NMO
      txtcmouv.Text = oChantierSyntheseDetails.NMO * TxMOOuv
      txtcouv_meca.Text = oChantierSyntheseDetails.NMO_MECA
      txtcmouv_meca.Text = oChantierSyntheseDetails.NMO_MECA * TxMO_Meca
      txtcouv_cabl.Text = oChantierSyntheseDetails.NMO_CABL
      txtcmouv_cabl.Text = oChantierSyntheseDetails.NMO_CABL * TxMO_Cabl
      txtcouv_aidetec.Text = oChantierSyntheseDetails.NMO_AIDETEC
      txtcmouv_aidetec.Text = oChantierSyntheseDetails.NMO_AIDETEC * TxMO_AideTec

      txtcMOA.Text = (oChantierSyntheseDetails.ASS * TxMOAss) + (oChantierSyntheseDetails.CHAFF * TxMOChaf)
      txtcMOA_BE.Text = (oChantierSyntheseDetails.BE * TxMOBE) + (oChantierSyntheseDetails.BE_AUTO * TxMOBE_Auto) + (oChantierSyntheseDetails.BE_ELEC * TxMOBE_Elec) + (oChantierSyntheseDetails.BE_MECA * TxMOBE_Meca)

      txtcass.Text = oChantierSyntheseDetails.ASS
      txtcmass.Text = oChantierSyntheseDetails.ASS * TxMOAss
      txtcchaf.Text = oChantierSyntheseDetails.CHAFF
      txtcmchaf.Text = oChantierSyntheseDetails.CHAFF * TxMOChaf
      txtcbe.Text = oChantierSyntheseDetails.BE
      txtcmbe.Text = oChantierSyntheseDetails.BE * TxMOBE

      txtcbe_auto.Text = oChantierSyntheseDetails.BE_AUTO
      txtcmbe_auto.Text = oChantierSyntheseDetails.BE_AUTO * TxMOBE_Auto
      txtcbe_elec.Text = oChantierSyntheseDetails.BE_ELEC
      txtcmbe_elec.Text = oChantierSyntheseDetails.BE_ELEC * TxMOBE_Elec
      txtcbe_meca.Text = oChantierSyntheseDetails.BE_MECA
      txtcmbe_meca.Text = oChantierSyntheseDetails.BE_MECA * TxMOBE_Meca

      txtcFRAIS.Text = (oChantierSyntheseDetails.PA * TxPanier) + (oChantierSyntheseDetails.GD * TxGD) + (oChantierSyntheseDetails.KM * TxKM) + oChantierSyntheseDetails.DIV + (oChantierSyntheseDetails.HrDeplace * TxDeplace)
      txtcpan.Text = oChantierSyntheseDetails.PA
      txtcmpan.Text = oChantierSyntheseDetails.PA * TxPanier
      txtcgd.Text = oChantierSyntheseDetails.GD
      txtcmgd.Text = oChantierSyntheseDetails.GD * TxGD
      txtckm.Text = oChantierSyntheseDetails.KM
      txtcdeplace.Text = oChantierSyntheseDetails.HrDeplace
      txtcmdeplace.Text = oChantierSyntheseDetails.HrDeplace * TxDeplace
      txtcmdivers.Text = oChantierSyntheseDetails.DIV
      txtcmkm.Text = oChantierSyntheseDetails.KMMTT
      txtcmFO.Text = oChantierSyntheseDetails.NFO
      txtcmSTT.Text = oChantierSyntheseDetails.STT
      txtcmPRO.Text = oChantierSyntheseDetails.PROR
      txtcmGAR.Text = oChantierSyntheseDetails.GAR
      '----------------------

      '----------------------
      txtPRO.Tag = oChantierSyntheseDetails.NPRORATA
      LblProrata.Text = String.Format("Compte prorata ({0:p1})", oChantierSyntheseDetails.NPRORATA)
      '----------------------

      oChantierAnaMARGE = New StructChantierAnaMARGE(oChantierCalculTotal, oChantierSyntheseDetails)

      'Analyse quantitée
      txtanaqouv.Text = oChantierAnaMARGE.ANAQOUV
      If oChantierAnaMARGE.ANAQOUV > 0 Then txtanaqouv.ForeColor = Color.Red Else txtanaqouv.ForeColor = Color.Green

      txtanaqouv_meca.Text = oChantierAnaMARGE.ANAQOUV_meca
      If oChantierAnaMARGE.ANAQOUV_meca > 0 Then txtanaqouv_meca.ForeColor = Color.Red Else txtanaqouv_meca.ForeColor = Color.Green
      txtanaqouv_cabl.Text = oChantierAnaMARGE.ANAQOUV_cabl
      If oChantierAnaMARGE.ANAQOUV_cabl > 0 Then txtanaqouv_cabl.ForeColor = Color.Red Else txtanaqouv_cabl.ForeColor = Color.Green
      txtanaqouv_aidetec.Text = oChantierAnaMARGE.ANAQOUV_AIDETEC
      If oChantierAnaMARGE.ANAQOUV_AIDETEC > 0 Then txtanaqouv_aidetec.ForeColor = Color.Red Else txtanaqouv_aidetec.ForeColor = Color.Green


      txtanaqass.Text = oChantierAnaMARGE.ANAQASS
      If oChantierAnaMARGE.ANAQASS > 0 Then txtanaqass.ForeColor = Color.Red Else txtanaqass.ForeColor = Color.Green
      txtanaqchaf.Text = oChantierAnaMARGE.ANAQCHAF
      If oChantierAnaMARGE.ANAQCHAF > 0 Then txtanaqchaf.ForeColor = Color.Red Else txtanaqchaf.ForeColor = Color.Green
      txtanaqbe.Text = oChantierAnaMARGE.ANAQBE
      If oChantierAnaMARGE.ANAQBE > 0 Then txtanaqbe.ForeColor = Color.Red Else txtanaqbe.ForeColor = Color.Green

      txtanaqbe_auto.Text = oChantierAnaMARGE.ANAQBE_auto
      If oChantierAnaMARGE.ANAQBE_auto > 0 Then txtanaqbe_auto.ForeColor = Color.Red Else txtanaqbe_auto.ForeColor = Color.Green
      txtanaqbe_elec.Text = oChantierAnaMARGE.ANAQBE_elec
      If oChantierAnaMARGE.ANAQBE_elec > 0 Then txtanaqbe_elec.ForeColor = Color.Red Else txtanaqbe_elec.ForeColor = Color.Green
      txtanaqbe_meca.Text = oChantierAnaMARGE.ANAQBE_meca
      If oChantierAnaMARGE.ANAQBE_meca > 0 Then txtanaqbe_meca.ForeColor = Color.Red Else txtanaqbe_meca.ForeColor = Color.Green

      txtanaqpan.Text = oChantierAnaMARGE.ANAQPAN
      If oChantierAnaMARGE.ANAQPAN > 0 Then txtanaqpan.ForeColor = Color.Red Else txtanaqpan.ForeColor = Color.Green
      txtanaqgd.Text = oChantierAnaMARGE.ANAQGD
      If oChantierAnaMARGE.ANAQGD > 0 Then txtanaqgd.ForeColor = Color.Red Else txtanaqgd.ForeColor = Color.Green
      txtanaqkm.Text = oChantierAnaMARGE.ANAQKM
      If oChantierAnaMARGE.ANAQKM > 0 Then txtanaqkm.ForeColor = Color.Red Else txtanaqkm.ForeColor = Color.Green


      txtanaq_hr_deplace.Text = oChantierAnaMARGE.ANAQ_HR_DEPLACE
      If oChantierAnaMARGE.ANAQ_HR_DEPLACE > 0 Then txtanaq_hr_deplace.ForeColor = Color.Red Else txtanaq_hr_deplace.ForeColor = Color.Green

      ' --------------------

      ' Analyse MARGE montant
      txtanamouv.Text = oChantierAnaMARGE.ANAMOUV
      txtanamint.Text = oChantierAnaMARGE.ANAMINT

      txtanamouv_meca.Text = oChantierAnaMARGE.ANAMOUV_MECA
      txtanamouv_cabl.Text = oChantierAnaMARGE.ANAMOUV_CABL
      txtanamouv_aidetec.Text = oChantierAnaMARGE.ANAMOUV_AIDETEC

      txtanamMOP.Text = oChantierAnaMARGE.ANAMMOP
      txtanamass.Text = oChantierAnaMARGE.ANAMASS
      txtanamchaf.Text = oChantierAnaMARGE.ANAMCHAF
      txtanambe.Text = oChantierAnaMARGE.ANAMBE

      txtanambe_auto.Text = oChantierAnaMARGE.ANAMBE_AUTO
      txtanambe_elec.Text = oChantierAnaMARGE.ANAMBE_ELEC
      txtanambe_meca.Text = oChantierAnaMARGE.ANAMBE_MECA

      txtanamMOA.Text = oChantierAnaMARGE.ANAMMOA
      txtanamMOA_BE.Text = oChantierAnaMARGE.ANAMMOA_BE
      txtanampan.Text = oChantierAnaMARGE.ANAMPAN
      txtanamgd.Text = oChantierAnaMARGE.ANAMGD
      txtanamkm.Text = oChantierAnaMARGE.ANAMKM
      txtanamFRAIS.Text = oChantierAnaMARGE.ANAMFRAIS
      txtanamFo.Text = oChantierAnaMARGE.ANAMFO
      txtanamstt.Text = oChantierAnaMARGE.ANAMSTT

      txtanam_hr_deplace.Text = oChantierAnaMARGE.ANAM_HR_DEPLACE

      '' Analyse MARGE %
      txtanapMOP.Text = oChantierAnaMARGE.ANAPMOP
      txtanapouv.Text = oChantierAnaMARGE.ANAPOUV

      txtanapouv_meca.Text = oChantierAnaMARGE.ANAPOUV_MECA
      txtanapouv_cabl.Text = oChantierAnaMARGE.ANAPOUV_cabl
      txtanapouv_aidetec.Text = oChantierAnaMARGE.ANAPOUV_aidetec

      txtanapMOA.Text = oChantierAnaMARGE.ANAPMOA
      txtanapMOA_BE.Text = oChantierAnaMARGE.ANAPMOA_BE
      txtanapass.Text = oChantierAnaMARGE.ANAPASS
      txtanapchaf.Text = oChantierAnaMARGE.ANAPCHAF
      txtanapbe.Text = oChantierAnaMARGE.ANAPBE

      txtanapbe_auto.Text = oChantierAnaMARGE.ANAPBE_auto
      txtanapbe_elec.Text = oChantierAnaMARGE.ANAPBE_elec
      txtanapbe_meca.Text = oChantierAnaMARGE.ANAPBE_meca

      txtanapFRAIS.Text = oChantierAnaMARGE.ANAPFRAIS
      txtanappan.Text = oChantierAnaMARGE.ANAPPAN
      txtanapgd.Text = oChantierAnaMARGE.ANAPGD
      txtanapkm.Text = oChantierAnaMARGE.ANAPKM
      txtanapFO.Text = oChantierAnaMARGE.ANAPFO
      txtanapstt.Text = oChantierAnaMARGE.ANAPSTT

      txtanap_hr_deplace.Text = oChantierAnaMARGE.ANAP_HR_DEPLACE

      If oChantierAnaMARGE.ANAPMOP < 0 Then txtanapMOP.ForeColor = Color.Red Else txtanapMOP.ForeColor = Color.Green
      If oChantierAnaMARGE.ANAPOUV < 0 Then txtanapouv.ForeColor = Color.Red Else txtanapouv.ForeColor = Color.Green

      If oChantierAnaMARGE.ANAPOUV_meca < 0 Then txtanapouv_meca.ForeColor = Color.Red Else txtanapouv_meca.ForeColor = Color.Green
      If oChantierAnaMARGE.ANAPOUV_cabl < 0 Then txtanapouv_cabl.ForeColor = Color.Red Else txtanapouv_cabl.ForeColor = Color.Green
      If oChantierAnaMARGE.ANAPOUV_aidetec < 0 Then txtanapouv_aidetec.ForeColor = Color.Red Else txtanapouv_aidetec.ForeColor = Color.Green

      If oChantierAnaMARGE.ANAPMOA < 0 Then txtanapMOA.ForeColor = Color.Red Else txtanapMOA.ForeColor = Color.Green
      If oChantierAnaMARGE.ANAPMOA_BE < 0 Then txtanapMOA_BE.ForeColor = Color.Red Else txtanapMOA_BE.ForeColor = Color.Green
      If oChantierAnaMARGE.ANAPASS < 0 Then txtanapass.ForeColor = Color.Red Else txtanapass.ForeColor = Color.Green
      If oChantierAnaMARGE.ANAPCHAF < 0 Then txtanapchaf.ForeColor = Color.Red Else txtanapchaf.ForeColor = Color.Green
      If oChantierAnaMARGE.ANAPBE < 0 Then txtanapbe.ForeColor = Color.Red Else txtanapbe.ForeColor = Color.Green

      If oChantierAnaMARGE.ANAPBE_auto < 0 Then txtanapbe_auto.ForeColor = Color.Red Else txtanapbe_auto.ForeColor = Color.Green
      If oChantierAnaMARGE.ANAPBE_elec < 0 Then txtanapbe_elec.ForeColor = Color.Red Else txtanapbe_elec.ForeColor = Color.Green
      If oChantierAnaMARGE.ANAPBE_meca < 0 Then txtanapbe_meca.ForeColor = Color.Red Else txtanapbe_meca.ForeColor = Color.Green

      If oChantierAnaMARGE.ANAPFRAIS < 0 Then txtanapFRAIS.ForeColor = Color.Red Else txtanapFRAIS.ForeColor = Color.Green
      If oChantierAnaMARGE.ANAPPAN < 0 Then txtanappan.ForeColor = Color.Red Else txtanappan.ForeColor = Color.Green
      If oChantierAnaMARGE.ANAPGD < 0 Then txtanapgd.ForeColor = Color.Red Else txtanapgd.ForeColor = Color.Green
      If oChantierAnaMARGE.ANAPKM < 0 Then txtanapkm.ForeColor = Color.Red Else txtanapkm.ForeColor = Color.Green
      If oChantierAnaMARGE.ANAPFO < 0 Then txtanapFO.ForeColor = Color.Red Else txtanapFO.ForeColor = Color.Green
      If oChantierAnaMARGE.ANAPSTT < 0 Then txtanapstt.ForeColor = Color.Red Else txtanapstt.ForeColor = Color.Green

      If oChantierAnaMARGE.ANAP_HR_DEPLACE < 0 Then txtanap_hr_deplace.ForeColor = Color.Red Else txtanap_hr_deplace.ForeColor = Color.Green

    Catch ex As Exception
      MZUtils.displayError(MethodBase.GetCurrentMethod().Name, ex)
    End Try

  End Sub

  Private Sub btnValider_Click(ByVal sender As Object, ByVal e As EventArgs) Handles btnValider.Click
    Try
      Cursor = Cursors.WaitCursor

      ' on enregistre les reste à réaliser
      oChantier_A_Realise.NMOASS = CInt(txtrAss.Text.Trim())
      oChantier_A_Realise.NMOCHAF = CInt(txtrChaf.Text.Trim())
      oChantier_A_Realise.NMOBE = CInt(txtrBE.Text.Trim())

      oChantier_A_Realise.NMOBE_AUTO = CInt(txtrBE_auto.Text.Trim())
      oChantier_A_Realise.NMOBE_ELEC = CInt(txtrBE_elec.Text.Trim())
      oChantier_A_Realise.NMOBE_MECA = CInt(txtrBE_meca.Text.Trim())

      oChantier_A_Realise.NGD = CInt(txtrGD.Text.Trim())
      oChantier_A_Realise.NKM = CInt(txtrKM.Text.Trim())
      oChantier_A_Realise.NDIVERS = CInt(txtrmdivers.Text.Trim())
      oChantier_A_Realise.HR_DEPLACE = CDbl(txtr_HR_DEPLACE.Text.Trim())

      oChantier_A_Realise.NPC_AVANCE = txtsythp.Text

      If oChantier_A_Realise.NMOASS > 0 Or
          oChantier_A_Realise.NMOCHAF > 0 Or
          oChantier_A_Realise.NMOBE > 0 Or
          oChantier_A_Realise.NMOBE_AUTO > 0 Or
          oChantier_A_Realise.NMOBE_ELEC > 0 Or
          oChantier_A_Realise.NMOBE_MECA > 0 Or
          oChantier_A_Realise.NGD > 0 Or
          oChantier_A_Realise.NKM > 0 Or
          oChantier_A_Realise.NDIVERS > 0 Or oChantier_A_Realise.HR_DEPLACE > 0 Then

        'on test s'il existe une ligne dans tchantierrea
        'si non, il faut en créer une en créant une fiche MO sur le chantier
        Dim nbLigne As Integer = MozartDatabase.ExecuteScalarInt($"SELECT COUNT(TCHANTIERREA.NIDCHANTIER) AS NBLINE FROM TCHANTIERREA WITH (NOLOCK) WHERE TCHANTIERREA.NIDCHANTIER = {iNIDCHANTIER}")
        If nbLigne = 0 Then
          MessageBox.Show(My.Resources.Admin_frmRealisation_Enregistrement_Reste & vbCrLf & My.Resources.Admin_frmRealisation_Creer_fiche_heures, My.Resources.Admin_frmRealisation_ErreurAnalytique, MessageBoxButtons.OK, MessageBoxIcon.Exclamation)
          Exit Sub
        End If

      End If

      MozartDatabase.ExecuteNonQuery("api_sp_ChantierReal " & iNIDCHANTIER & "," & oChantier_A_Realise.NMOASS.ToString & "," & oChantier_A_Realise.NMOCHAF.ToString &
                                     "," & oChantier_A_Realise.NMOBE.ToString & "," & oChantier_A_Realise.NMOBE_AUTO.ToString & "," & oChantier_A_Realise.NMOBE_ELEC.ToString &
                                     "," & oChantier_A_Realise.NMOBE_MECA.ToString & "," & oChantier_A_Realise.PAN.ToString & "," & oChantier_A_Realise.NGD.ToString & "," &
                                     oChantier_A_Realise.NKM.ToString & "," & oChantier_A_Realise.NDIVERS.ToString & "," & oChantier_A_Realise.HR_DEPLACE.ToString.Replace(",", ".") &
                                     "," & oChantier_A_Realise.NPC_AVANCE.ToString.Replace(",", "."))

      bEnreg = True

      MozartDatabase.ExecuteNonQuery("[api_sp_ChantierAddObs] " & iNIDCHANTIER & ", '" & RichEditControl1.RtfText.ToString.Replace("'", "''") & "'")

      Realise()
      ResteARealise()
      SyntheseChantier()
      CalculRealisation()

      SaveHistoChantier()

    Catch ex As Exception
      MZUtils.displayError(MethodBase.GetCurrentMethod().Name, ex)
    Finally
      Cursor = Cursors.Default
    End Try
  End Sub

  Private Function LoadDatatableHisto() As DataTable

    Try

      Dim dtTmp As New DataTable

      Dim sqlcmdList As New SqlCommand("[api_sp_ChantierListeHistoRea]", MozartDatabase.cnxMozart)
      sqlcmdList.CommandType = CommandType.StoredProcedure
      sqlcmdList.Parameters.Add("@p_iChantier", SqlDbType.Int)
      sqlcmdList.Parameters("@p_iChantier").Value = iNIDCHANTIER

      dtTmp.Load(sqlcmdList.ExecuteReader)

      Return dtTmp

    Catch ex As Exception
      MZUtils.displayError(MethodBase.GetCurrentMethod().Name, ex)
      Return Nothing

    End Try

  End Function

  Private Sub SaveHistoChantier()

    Try

      'on enregistre les données au moment de la vaildation
      Dim sqlsavehisto As New SqlCommand("[api_sp_ChantierCreationReaHisto]", MozartDatabase.cnxMozart) With {
        .CommandType = CommandType.StoredProcedure
      }

      sqlsavehisto.Parameters.Add("@p_nidchantier", SqlDbType.Int)
      sqlsavehisto.Parameters("@p_nidchantier").Value = iNIDCHANTIER
      sqlsavehisto.Parameters.Add("@p_ntotpv", SqlDbType.Int)
      sqlsavehisto.Parameters("@p_ntotpv").Value = oChantierSyntheseRea.srPV
      sqlsavehisto.Parameters.Add("@p_ntotmarge", SqlDbType.Int)
      sqlsavehisto.Parameters("@p_ntotmarge").Value = oChantierSyntheseRea.srMN
      sqlsavehisto.Parameters.Add("@p_ntotmoprodnb", SqlDbType.Int)
      sqlsavehisto.Parameters("@p_ntotmoprodnb").Value = oChantierCalculTotal.TOUV
      sqlsavehisto.Parameters.Add("@p_ntotmoprodmtt", SqlDbType.Int)
      sqlsavehisto.Parameters("@p_ntotmoprodmtt").Value = oChantierCalculTotal.TMOP
      sqlsavehisto.Parameters.Add("@p_ntotmoadminmtt", SqlDbType.Int)
      sqlsavehisto.Parameters("@p_ntotmoadminmtt").Value = oChantierCalculTotal.TMOA
      sqlsavehisto.Parameters.Add("@p_ntotfraismtt", SqlDbType.Int)
      sqlsavehisto.Parameters("@p_ntotfraismtt").Value = oChantierCalculTotal.TFRAIS
      sqlsavehisto.Parameters.Add("@p_ntotfomtt", SqlDbType.Int)
      sqlsavehisto.Parameters("@p_ntotfomtt").Value = oChantierCalculTotal.TFO
      sqlsavehisto.Parameters.Add("@p_ntotsttmtt", SqlDbType.Int)
      sqlsavehisto.Parameters("@p_ntotsttmtt").Value = oChantierCalculTotal.TSTT
      sqlsavehisto.Parameters.Add("@p_npc_avance", SqlDbType.Decimal)
      sqlsavehisto.Parameters("@p_npc_avance").Value = oChantier_A_Realise.NPC_AVANCE
      sqlsavehisto.Parameters.Add("@p_npc_marge", SqlDbType.Decimal)
      sqlsavehisto.Parameters("@p_npc_marge").Value = oChantierSyntheseRea.srPMN

      sqlsavehisto.ExecuteNonQuery()

    Catch ex As Exception
      MZUtils.displayError(MethodBase.GetCurrentMethod().Name, ex)
    End Try

  End Sub

  Private Sub AfficheGridResteARea_Click(ByVal sender As Object, ByVal e As EventArgs) Handles txtrOuv.Click, txtrmFO.Click, txtrmSTT.Click, txtrOuv_meca.Click, txtrOuv_cabl.Click, txtrOuv_aidetec.Click, txtrChaf.Click, txtrBE.Click, txtrBE_auto.Click, txtrBE_elec.Click, txtrBE_meca.Click

    Dim oTxtSrc As Object = CType(sender, TextEdit)
    Dim sType As String

    Select Case oTxtSrc.Name
      Case "txtrOuv" : sType = AnalytiqueChantierCst.TYPE_MO
      Case "txtrOuv_meca" : sType = AnalytiqueChantierCst.TYPE_MO_MECA
      Case "txtrOuv_cabl" : sType = AnalytiqueChantierCst.TYPE_MO_CABL
      Case "txtrOuv_aidetec" : sType = AnalytiqueChantierCst.TYPE_MO_AIDETEC
      Case "txtrChaf" : sType = AnalytiqueChantierCst.TYPE_MO_CHAFF
      Case "txtrBE" : sType = AnalytiqueChantierCst.TYPE_MO_BE
      Case "txtrBE_auto" : sType = AnalytiqueChantierCst.TYPE_MO_BE_AUTO
      Case "txtrBE_elec" : sType = AnalytiqueChantierCst.TYPE_MO_BE_ELEC
      Case "txtrBE_meca" : sType = AnalytiqueChantierCst.TYPE_MO_BE_MECA

      Case "txtrmFO" : sType = "FO"
      Case "txtrmSTT" : sType = "STTSAISIE"
      Case Else
        MessageBox.Show(My.Resources.Global_type_nonreconnu, My.Resources.Global_erreur_type, MessageBoxButtons.OK, MessageBoxIcon.Exclamation)
        Exit Sub
    End Select

    Dim ofrmGridResteARea As New frmGridResteARea(sType, iNIDCHANTIER, bReadOnly)
    ofrmGridResteARea.ShowDialog()

    If oChantier_A_Realise IsNot Nothing Then

      Select Case oTxtSrc.Name
        Case "txtrOuv" : oChantier_A_Realise.MO = ofrmGridResteARea.SumNbAReste : txtrOuv.EditValue = ofrmGridResteARea.SumNbAReste
        Case "txtrOuv_meca" : oChantier_A_Realise.MO_MECA = ofrmGridResteARea.SumNbAReste : txtrOuv_meca.EditValue = ofrmGridResteARea.SumNbAReste
        Case "txtrOuv_cabl" : oChantier_A_Realise.MO_CABL = ofrmGridResteARea.SumNbAReste : txtrOuv_cabl.EditValue = ofrmGridResteARea.SumNbAReste
        Case "txtrOuv_aidetec" : oChantier_A_Realise.MO_AIDETEC = ofrmGridResteARea.SumNbAReste : txtrOuv_aidetec.EditValue = ofrmGridResteARea.SumNbAReste

        Case "txtrChaf" : oChantier_A_Realise.NMOCHAF = ofrmGridResteARea.SumNbAReste : txtrChaf.EditValue = ofrmGridResteARea.SumNbAReste
        Case "txtrBE" : oChantier_A_Realise.NMOBE = ofrmGridResteARea.SumNbAReste : txtrBE.EditValue = ofrmGridResteARea.SumNbAReste
        Case "txtrBE_auto" : oChantier_A_Realise.NMOBE_AUTO = ofrmGridResteARea.SumNbAReste : txtrBE_auto.EditValue = ofrmGridResteARea.SumNbAReste
        Case "txtrBE_elec" : oChantier_A_Realise.NMOBE_ELEC = ofrmGridResteARea.SumNbAReste : txtrBE_elec.EditValue = ofrmGridResteARea.SumNbAReste
        Case "txtrBE_meca" : oChantier_A_Realise.NMOBE_MECA = ofrmGridResteARea.SumNbAReste : txtrBE_meca.EditValue = ofrmGridResteARea.SumNbAReste

        Case "txtrmFO" : oChantier_A_Realise.FO = ofrmGridResteARea.SumNbAReste : txtrmFO.EditValue = ofrmGridResteARea.SumNbAReste
        Case "txtrmSTT" : oChantier_A_Realise.STT = ofrmGridResteARea.SumNbAReste : txtrmSTT.EditValue = ofrmGridResteARea.SumNbAReste
        Case Else
          MessageBox.Show(My.Resources.Global_type_nonreconnu, My.Resources.Global_erreur_type, MessageBoxButtons.OK, MessageBoxIcon.Exclamation)
          Exit Sub
      End Select

    End If

    CalculRealisation()

  End Sub

  Private Sub SyntheseChantier()
    Try

      oChantierSynthese = New StructSyntheseChantier(iNIDCHANTIER, bReadOnly)

      txtDEB.Text = oChantierSynthese.DEBOURSE
      txtFG.Text = oChantierSynthese.FRAISGENE
      txtPV.Text = oChantierSynthese.PVENTE
      txtMARGE.Text = oChantierSynthese.MARGE
      txtPMarge.Text = oChantierSynthese.PMARGE

      Using sqlR = MozartDatabase.ExecuteReader($"[api_sp_ChantierGetObs] {iNIDCHANTIER}")
        If sqlR.Read() Then
          RichEditControl1.RtfText = sqlR.Item("VCHANTIEROBS")
        End If
      End Using

    Catch ex As Exception
      MZUtils.displayError(MethodBase.GetCurrentMethod().Name, ex)
    End Try
  End Sub

  Private Sub SyntheseRea()
    Try

      oChantierSyntheseRea = New StructChantierSyntheseRea()

      SyntheseAna()

      oChantierSyntheseRea.srTOT = oChantierCalculTotal.TMOP + oChantierCalculTotal.TMOA + oChantierCalculTotal.TMOA_BE + oChantierCalculTotal.TFRAIS +
                                  oChantierCalculTotal.TFO + oChantierCalculTotal.TSTT + oChantierSyntheseAna.TOT_PRO + oChantierSyntheseDetails.GAR

      oChantierSyntheseRea.srFG = oChantierSynthese.FRAISGENE
      oChantierSyntheseRea.srPV = oChantierSynthese.PVENTE

      oChantierSyntheseRea.srMN = oChantierSyntheseRea.srPV - oChantierSyntheseRea.srFG - oChantierSyntheseRea.srTOT
      oChantierSyntheseRea.srPMN = (oChantierSyntheseRea.srMN * 100) / oChantierSyntheseRea.srPV

      txtsrTOT.Text = oChantierSyntheseRea.srTOT
      txtsrFG.Text = oChantierSyntheseRea.srFG
      txtsrPV.Text = oChantierSyntheseRea.srPV
      txtsrMN.Text = oChantierSyntheseRea.srMN
      txtsrPMN.Text = oChantierSyntheseRea.srPMN

      ' lorsque le résultat est calculé, on l'enregistre dans TCHANTIER 
      MozartDatabase.ExecuteNonQuery("UPDATE TCHANTIER SET NMARGENET = " & oChantierSyntheseRea.srMN.ToString & " , NPMARGENET = " & oChantierSyntheseRea.srPMN.ToString().Replace(",", ".") &
                                     " WHERE NIDCHANTIER = " & iNIDCHANTIER.ToString)

    Catch ex As Exception
      MZUtils.displayError(MethodBase.GetCurrentMethod().Name, ex)
    End Try
  End Sub

  Private Sub SyntheseAna()
    Try

      oChantierSyntheseAna = New StructChantierSyntheseAna(iNIDCHANTIER, oChantierSyntheseRea, oChantierSyntheseDetails, oChantierSynthese, oChantierRealise,
                                                           oChantierCalculRealisation, oChantier_A_Realise)

      txtsyfac.Text = oChantierSyntheseAna.iSynthAnaFAc
      txtPRO.Text = oChantierSyntheseAna.PRO
      txtGAR.Text = oChantierSyntheseAna.GAR
      txtrmPRO.Text = oChantierSyntheseAna.RMPRO
      txtrmGAR.Text = oChantierSyntheseAna.RMGAR
      txtRES.Text = oChantierSyntheseAna.RES
      txtrmRES.Text = oChantierSyntheseAna.RMRES
      txtsyfacp.Text = oChantierSyntheseAna.SYFACP
      txtsythp.Text = oChantierSyntheseAna.SYTHP
      txtsyth.Text = oChantierSyntheseAna.SYTH
      txtsyen.Text = oChantierSyntheseAna.SYEN
      txtsyenp.Text = oChantierSyntheseAna.SYENP

      'total compte prorata = total engagé + total reste a engage
      txttPRO.Text = oChantierSyntheseAna.TOT_PRO
      txtanaPRO.Text = oChantierSyntheseAna.TOT_ANA_PRO
      txtanappro.Text = oChantierSyntheseAna.TOT_P_ANA_PRO

      'total garantie = total engagé garantie + total reste a engage garantie
      txttGAR.Text = oChantierSyntheseAna.TOT_GAR
      txtanaGAR.Text = oChantierSyntheseAna.TOT_ANA_GAR
      txtanapgar.Text = oChantierSyntheseAna.TOT_P_ANA_GAR

      If oChantierSyntheseAna.TOT_P_ANA_PRO < 0 Then txtanappro.ForeColor = Color.Red Else txtanappro.ForeColor = Color.Green
      If oChantierSyntheseAna.TOT_P_ANA_GAR < 0 Then txtanapgar.ForeColor = Color.Red Else txtanapgar.ForeColor = Color.Green

    Catch ex As Exception
      MZUtils.displayError(MethodBase.GetCurrentMethod().Name, ex)
    End Try
  End Sub

  Private Sub btnFermer_Click(ByVal sender As Object, ByVal e As EventArgs) Handles btnFermer.Click
    If (Not bEnreg) And (Not bReadOnly) Then
      If MessageBox.Show(My.Resources.Global_MessageEnre, My.Resources.Global_Enregistrer, MessageBoxButtons.YesNo, MessageBoxIcon.Question) = DialogResult.Yes Then
        btnValider.PerformClick()
      End If
    End If

    Me.Close()
  End Sub

  Private Sub btnPrint_Click(ByVal sender As Object, ByVal e As EventArgs) Handles btnPrint.Click
    CaptureScreen()

    printDoc.Print()

    'memoryImage.Save("C:\test.bmp")

  End Sub

  Private Sub CaptureScreen()
    Dim myGraphics As Graphics = Me.CreateGraphics()
    Dim s As Size = Me.Size

    Dim areaWidth As Single
    Dim areaHeight As Single
    memoryImage = New Bitmap(s.Width, s.Height, myGraphics)
    Dim memoryGraphics As Graphics = Graphics.FromImage(memoryImage)
    memoryGraphics.CopyFromScreen(Me.Location.X, Me.Location.Y, 0, 0, s)

    printDoc.DefaultPageSettings.Landscape = True

    With printDoc.DefaultPageSettings
      areaWidth = .Bounds.Width - .Margins.Left '- .Margins.Right
      areaHeight = .Bounds.Height - .Margins.Top '- .Margins.Bottom
    End With

    Dim bm As New Bitmap(memoryImage)
    Dim x As Integer = areaWidth 'printDoc.DefaultPageSettings.PrintableArea.Height      'variable for new width size
    Dim y As Integer = areaHeight   'printDoc.DefaultPageSettings.PrintableArea.Width 'variable for new height size

    Dim width As Integer = Val(x) 'image width 
    Dim height As Integer = Val(y) 'image height 
    thumb = New Bitmap(width, height)
    Dim g As Graphics = Graphics.FromImage(thumb)
    g.InterpolationMode = Drawing2D.InterpolationMode.HighQualityBicubic
    g.DrawImage(bm, New Rectangle(0, 0, width, height), New Rectangle(0, 0, bm.Width, bm.Height), GraphicsUnit.Pixel)

  End Sub


  Private Sub printDocument1_PrintPage(ByVal sender As Object, ByVal e As PrintPageEventArgs) Handles printDoc.PrintPage
    e.Graphics.DrawImage(thumb, 0, 0)
  End Sub

  Private Sub cmdOptim_Click(ByVal sender As Object, ByVal e As EventArgs) Handles cmdOptim.Click

    Dim sPathFile As String
    Dim ficxls As New Excel.Application
    Dim wksxls As Excel.Workbook
    Dim feuillexls As Excel.Worksheet
    Dim sSql As String

    Try
      ' TB SAMSIC CITY PATH
      sPathFile = RechercheParamByLib("MOZART_RESSOURCES") & "Modeles\AnalytiqueChantier\Optimisation" & iNIDCHANTIER.ToString & ".xls"

      If Not File.Exists(sPathFile) Then
        ' TB SAMSIC CITY PATH
        File.Copy(RechercheParamByLib("MOZART_RESSOURCES") & "Modeles\AnalytiqueChantier\ChantierOptimisation.xls", sPathFile)
        wksxls = ficxls.Workbooks.Open(sPathFile)
        feuillexls = wksxls.ActiveSheet

        sSql = "select TOP 1 VCANLIB + '  /  ' + CONVERT(VARCHAR(4),TREF_CTEANA.NCANNUM) AS LIB,  VPERNOM + ' ' + VPERPRE AS CHAF " &
          "from TCHANTIERCHIFFRAGE WITH (NOLOCK) INNER JOIN " &
          "TCHANTIERCAN WITH (NOLOCK)ON TCHANTIERCHIFFRAGE.NIDCHANTIER = TCHANTIERCAN.NIDCHANTIER INNER JOIN " &
          "TREF_CTEANA WITH (NOLOCK) ON TREF_CTEANA.NCANNUM = TCHANTIERCAN.NCANNUM INNER JOIN " &
          "TPER WITH (NOLOCK) ON TCHANTIERCHIFFRAGE.NCHAFNUM = TPER.NPERNUM " &
          "WHERE TCHANTIERCHIFFRAGE.NIDCHANTIER = " & iNIDCHANTIER.ToString & " AND TREF_CTEANA.VSOCIETE = APP_NAME()"

        Using sqlR = MozartDatabase.ExecuteReader(sSql)
          If sqlR.Read() Then
            feuillexls.Cells(2, 1) = My.Resources.Admin_frmRealisation_Affaire & sqlR("LIB").ToString
            feuillexls.Cells(3, 1) = My.Resources.Admin_frmRealisation_ChargeAffaire & sqlR("CHAF").ToString
            feuillexls.Cells(4, 1) = My.Resources.Admin_frmRealisation_Date_validation & Now.ToString("dd/MM/yyyy")

            wksxls.Save()
          End If
        End Using

      Else
        Dim fichier As New FileInfo(sPathFile)
        wksxls = ficxls.Workbooks.Open(sPathFile)
        feuillexls = wksxls.ActiveSheet
        feuillexls.Cells(4, 1) = My.Resources.Admin_frmRealisation_Date_validation & fichier.LastWriteTime.ToString("dd/MM/yyyy")
      End If

      ficxls.Application.Visible = True

    Catch ex As Exception
      MZUtils.displayError(MethodBase.GetCurrentMethod().Name, ex)
    End Try
  End Sub

  Private Sub txtcde_MouseClick(ByVal sender As Object, ByVal e As MouseEventArgs) Handles txtcde.MouseClick, txtmbe.MouseClick, txtmchaf.MouseClick,
            txtmass.MouseClick, txtSTT.MouseClick, txtss.MouseClick, txtFO.MouseClick, txtMOA.MouseClick, txtcmSTT.MouseClick, txtcmFO.MouseClick, txtcMOA.MouseClick,
            txtcMOP.MouseClick, txtMOP.MouseClick, txtPRO.MouseClick, txtmint.MouseClick, txtmouv.MouseClick,
            txtmouv_meca.MouseClick, txtmouv_cabl.MouseClick, txtmouv_aidetec.MouseClick,
            txtmbe_auto.MouseClick, txtmbe_elec.MouseClick, txtmbe_meca.MouseClick, txtMOA_BE.MouseClick, txtmdeplace.MouseClick

    Dim oTxtSrc As ButtonEdit = CType(sender, ButtonEdit)

    Dim sType As String

    Select Case oTxtSrc.Name
      Case "txtmbe" : sType = "RMOABE"

      Case "txtmbe_auto" : sType = "RMOABE_AUTO"
      Case "txtmbe_elec" : sType = "RMOABE_ELEC"
      Case "txtmbe_meca" : sType = "RMOABE_MECA"

      Case "txtmchaf" : sType = "RMOACHAF"
      Case "txtmass" : sType = "RMOASS"
      Case "txtSTT" : sType = "RSTT"
      Case "txtss" : sType = "RFOUSS"
      Case "txtcde" : sType = "RFOUCDE"
      Case "txtFO" : sType = "RFOU"
      Case "txtMOA" : sType = "RMOA"
      Case "txtMOA_BE" : sType = "RMOA_BE"
      Case "txtMOP" : sType = "RMOP"
      Case "txtcmSTT" : sType = "TSTT"
      Case "txtcmFO" : sType = "TFO"
      Case "txtcMOA" : sType = "TMOA"
      Case "txtcMOP" : sType = "TMOP"
      Case "txtPRO" : sType = "PRORATA"
      Case "txtmint" : sType = "RINTERIM"
      Case "txtmouv" : sType = "RQTEOUV"

      Case "txtmouv_meca" : sType = "RQTEOUV_MECA"
      Case "txtmouv_cabl" : sType = "RQTEOUV_CABL"
      Case "txtmouv_aidetec" : sType = "RQTEOUV_AIDETEC"
      Case "txtmdeplace" : sType = "RQTE_HR_DEPLACE"

      Case Else : sType = ""

    End Select

    Dim lCursorPos As New Point(Cursor.Position.X, Cursor.Position.Y)

    Select Case oTxtSrc.Name
      Case "txtcde", "txtSTT", "txtss", "txtFO", "txtPRO", "txtmint"
        Dim oFrmDetailsCaseWithDetail As New frmDetailsCaseWithDetail(sType, iNIDCHANTIER, lCursorPos)
        oFrmDetailsCaseWithDetail.ShowDialog()

      Case "txtmass", "txtmbe", "txtmchaf", "txtMOA", "txtMOA_BE", "txtMOP", "txtmouv", "txtmbe_auto", "txtmbe_elec", "txtmbe_meca", "txtmouv_meca", "txtmouv_cabl", "txtmouv_aidetec", "txtmdeplace"
        ' Evite les plantages si aucune donnée
        If oTxtSrc.EditValue = "0" Then Exit Sub

        Dim oFrmDetailsCaseWithDetailH As New frmDetailsCaseWithDetailH(sType, iNIDCHANTIER)
        oFrmDetailsCaseWithDetailH.ShowDialog()

      Case Else
        Using oFrmDetailsCase As New frmDetailsCase(sType, iNIDCHANTIER, lCursorPos, TabInfo)
          oFrmDetailsCase.ShowDialog()
        End Using

    End Select

  End Sub

  Private Sub txtrOuv_EditValueChanged(ByVal sender As Object, ByVal e As EventArgs) Handles txtrOuv.EditValueChanged

    Try

      'calcul auto des paniers (nombre et montant)
      If txtrOuv.EditValue.ToString <> "" AndAlso IsNumeric(txtrOuv.EditValue) = True Then

        If oChantier_A_Realise IsNot Nothing Then oChantier_A_Realise.PAN = Convert.ToInt32(txtrOuv.EditValue) \ 8 : txtrPan.Text = oChantier_A_Realise.PAN
        If oChantierCalculRealisation IsNot Nothing Then oChantierCalculRealisation.RMPAN = (Convert.ToInt32(txtrOuv.EditValue) \ 8) * TxPanier : txtrmpan.Text = oChantierCalculRealisation.RMPAN

      End If

    Catch ex As Exception
      MZUtils.displayError(MethodBase.GetCurrentMethod().Name, ex)
    End Try

  End Sub

  Private Sub txtrmFO_EditValueChanged(ByVal sender As Object, ByVal e As EventArgs) Handles txtrmFO.EditValueChanged

    Try

      'calcul auto des paniers (nombre et montant)
      If txtrmFO.EditValue.ToString <> "" AndAlso IsNumeric(txtrmFO.EditValue) = True Then

        If oChantier_A_Realise IsNot Nothing Then oChantier_A_Realise.FO = Convert.ToInt32(txtrmFO.EditValue) : txtrmFO.Text = oChantier_A_Realise.FO

      End If

    Catch ex As Exception
      MZUtils.displayError(MethodBase.GetCurrentMethod().Name, ex)
    End Try

  End Sub

  Private Sub txtrmSTT_EditValueChanged(ByVal sender As Object, ByVal e As EventArgs) Handles txtrmSTT.EditValueChanged

    Try

      'calcul auto des paniers (nombre et montant)
      If txtrmSTT.EditValue.ToString <> "" AndAlso IsNumeric(txtrmSTT.EditValue) = True Then

        If oChantier_A_Realise IsNot Nothing Then oChantier_A_Realise.STT = Convert.ToInt32(txtrmSTT.EditValue) : txtrmSTT.Text = oChantier_A_Realise.STT

      End If

    Catch ex As Exception
      MZUtils.displayError(MethodBase.GetCurrentMethod().Name, ex)
    End Try

  End Sub


  Private Sub BtnGraphMarge_Click(sender As Object, e As EventArgs) Handles BtnGraphMarge.Click

    Dim dtHisto As DataTable = LoadDatatableHisto()

    If dtHisto IsNot Nothing AndAlso dtHisto.Rows.Count > 0 Then

      Dim ofrmGraphHisto As New frmCourbeMargeChantier(iNIDCHANTIER)
      ofrmGraphHisto.ShowDialog()

    End If

  End Sub

  Private Sub BtnVisuHisto_Click(sender As Object, e As EventArgs) Handles BtnVisuHisto.Click
    Cursor.Current = Cursors.WaitCursor

    Dim ofrmHistoModifAnaChantier As New frmHistoModifAnaChantier(iNIDCHANTIER)
    ofrmHistoModifAnaChantier.ShowDialog()

    Cursor.Current = Cursors.Default
  End Sub

  Private Sub txtcoeftot_MouseDown(sender As Object, e As MouseEventArgs) Handles txttmouv.MouseDown, txttmouv_meca.MouseDown, txttmouv_cabl.MouseDown, txttmouv_aidetec.MouseDown, txttmass.MouseDown, txttmchaf.MouseDown, txttmbe.MouseDown, txttmbe_auto.MouseDown, txttmbe_elec.MouseDown, txttmbe_meca.MouseDown

    If e.Button = MouseButtons.Right Then

      Dim oValQte As TextEdit = TryCast(sender, TextEdit)
      Dim oValTot As TextEdit = Nothing

      Select Case oValQte.Name
        Case "txttmouv" : oValTot = txttouv
        Case "txttmouv_meca" : oValTot = txttouv_meca
        Case "txttmouv_cabl" : oValTot = txttouv_cabl
        Case "txttmouv_aidetec" : oValTot = txttouv_aidetec
        Case "txttmass" : oValTot = txttass
        Case "txttmchaf" : oValTot = txttchaf
        Case "txttmbe" : oValTot = txttbe
        Case "txttmbe_auto" : oValTot = txttbe_auto
        Case "txttmbe_elec" : oValTot = txttbe_elec
        Case "txttmbe_meca" : oValTot = txttbe_meca
      End Select

      If txttouv.EditValue.ToString <> "" And oValTot IsNot Nothing Then
        MessageBox.Show(String.Format("Taux horaire moyen réalisé : {0:n1}", If(oValTot.EditValue = 0, 0, oValQte.EditValue / oValTot.EditValue)), "Message", MessageBoxButtons.OK, MessageBoxIcon.Information)
      End If

    End If

  End Sub

  Private Sub Lbl_SousTotaux_Paint(sender As Object, e As PaintEventArgs) Handles Lbl_SousTotal_1.Paint, Lbl_SousTotal_2.Paint, Lbl_SousTotal_3.Paint, Lbl_SousTotal_4.Paint, Lbl_SousTotal_5.Paint, Lbl_SousTotal_6.Paint

    Dim oLbl As Label = TryCast(sender, Label)

    oLbl.Text = ""

    'line
    oLbl.Size = New Size(GrpAnalyse.Location.X + GrpAnalyse.Size.Width, oLbl.Size.Height)

    Dim oPen As Pen = New Pen(Color.FromArgb(255, 0, 0, 0))
    e.Graphics.DrawLine(oPen, 0, Convert.ToInt32(oLbl.Size.Height / 2), oLbl.Size.Width - oLbl.Location.X, Convert.ToInt32(oLbl.Size.Height / 2))
  End Sub

  Private Sub frmRealisation_ResizeEnd(sender As Object, e As EventArgs) Handles Me.ResizeEnd
    RichEditControl1.Size = New Size(Me.Size.Width - RichEditControl1.Location.X - 100, RichEditControl1.Size.Height)
  End Sub

  Private Sub frmRealisation_SizeChanged(sender As Object, e As EventArgs) Handles Me.SizeChanged
    RichEditControl1.Size = New Size(Me.Size.Width - RichEditControl1.Location.X - 100, RichEditControl1.Size.Height)
  End Sub

  Private Sub RichEditControl1_Resize(sender As Object, e As EventArgs) Handles RichEditControl1.Resize
    FontBar1.FloatSize = New Size(RichEditControl1.Size.Width, 0)

    RichEditControl1.Location = New Point(Label35.Location.X, Label35.Location.Y + Label35.Size.Height + 60)
  End Sub

  Private Sub RichEditControl1_SizeChanged(sender As Object, e As EventArgs) Handles RichEditControl1.SizeChanged
    FontBar1.FloatSize = New Size(RichEditControl1.Size.Width, 0)

    RichEditControl1.Location = New Point(Label35.Location.X, Label35.Location.Y + Label35.Size.Height + FontBar1.FloatSize.Height + 60)
  End Sub

  Private Sub Button1_Click(sender As Object, e As EventArgs)
    MozartDatabase.ExecuteNonQuery("[api_sp_ChantierAddObs] " & iNIDCHANTIER & ", '" & RichEditControl1.RtfText.ToString.Replace("'", "''") & "'")
  End Sub

  Private Sub txtsythp_EditValueChanged(sender As Object, e As EventArgs) Handles txtsythp.EditValueChanged
    Dim lPV As Integer
    Dim lPourc As Double
    Dim lFacturation As Integer
    Dim lResultAvancement As Integer
    Dim lResultEncours As Integer

    If Not Integer.TryParse(oChantierSynthese.PVENTE, lPV) Then lPV = 0
    If Not Double.TryParse(txtsythp.Text, lPourc) Then lPourc = 0

    lResultAvancement = lPV * lPourc / 100
    txtsyth.Text = lResultAvancement

    If Not Integer.TryParse(oChantierSyntheseAna.iSynthAnaFAc, lFacturation) Then lFacturation = 0
    lResultEncours = lResultAvancement - lFacturation

    txtsyen.Text = lResultEncours
  End Sub

End Class
