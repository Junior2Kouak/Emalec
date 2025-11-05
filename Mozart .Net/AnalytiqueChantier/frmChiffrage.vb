Imports System.Data.SqlClient
Imports DevExpress.XtraEditors.Controls
Imports MozartLib

Public Class frmChiffrage

  Dim cmd As SqlCommand
  Dim bEnreg As Boolean
  Dim iIDChantier As Integer
  Dim iNIDCHIF As Int32

  Dim oChiffrage As StructChantierChiffrage

  Private Const FORMAT_POURC As String = "{0:p1}"

  Public Sub New(ByVal c_NIDCHIF As Int32)

    ' Cet appel est requis par le concepteur.
    InitializeComponent()

    ' Ajoutez une initialisation quelconque après l'appel InitializeComponent().
    iNIDCHIF = c_NIDCHIF

  End Sub

  Private Sub frmChiffrage_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
    bEnreg = False

    Try

      'init
      LblPPV.Text = String.Format(FORMAT_POURC, 1)

      'If iChif = 0 Then OuvertureCreation() Else 
      oChiffrage = New StructChantierChiffrage(iNIDCHIF)

      RemplirCombo()

      OuvertureModif()

      'mise ne forme des labels avec leur taux
      'taux main d oeuvre
      Label19.Text = String.Format(Label19.Text, TxMOOuv)
      'taux assistante
      Label6.Text = String.Format(Label6.Text, TxMOAss)
      'taux chargé d affaires
      Label2.Text = String.Format(Label2.Text, TxMOChaf)
      'taux bureau etudes
      Label1.Text = String.Format(Label1.Text, TxMOBE)
      'taux panier
      Label5.Text = String.Format(Label5.Text, TxPanier)
      'taux GD
      Label4.Text = String.Format(Label4.Text, TxGD)
      'taux KMS
      Label3.Text = String.Format(Label3.Text, TxKM)
      'taux deplacement
      Label26.Text = String.Format(Label26.Text, TxDeplace)


      'Taux
      Label57.Text = String.Format(Label57.Text, TxMO_Meca)
      Label61.Text = String.Format(Label61.Text, TxMO_Cabl)
      Label66.Text = String.Format(Label66.Text, TxMO_AideTec)

      Label34.Text = String.Format(Label34.Text, TxMOBE_Auto)
      Label44.Text = String.Format(Label44.Text, TxMOBE_Elec)
      Label49.Text = String.Format(Label49.Text, TxMOBE_Meca)

      Label31.Text = String.Format($"Frais généraux {FORMAT_POURC} (FG)", oChiffrage.NTAUX_FG)


      txtMO.Select()

      If MozartParams.NomSociete = "EMALECMPM" Then

        GrpboxProrata.Visible = False

      End If

    Catch ex As Exception
      MessageBox.Show(My.Resources.Admin_frmChiffrage_Erreur & ex.Message)
    End Try

  End Sub

  Private Sub OuvertureModif()

    iIDChantier = oChiffrage.NIDCHANTIER
    cmbClient.SelectedValue = oChiffrage.NCLINUM
    cmbChaf.SelectedValue = oChiffrage.NCHAFFNUM
    txtLibelle.Text = oChiffrage.VCHIFFLIB '    dr("VLIBCHIF")
    txtPV.Text = oChiffrage.NCHIFFPV ' dr("NPVHT")
    txtMO.Text = oChiffrage.NCHIFFMOADMIN  'dr("NMO")
    txtFO.Text = oChiffrage.NCHIFFFO 'dr("NFO")
    txtSTT.Text = oChiffrage.NCHIFFST  'dr("NSTT")
    txtASS.Text = oChiffrage.NCHIFFMOASS ' dr("NMOASS")
    txtCHAF.Text = oChiffrage.NCHIFFMOCHAFF ' dr("NMOCHAF")
    txtBE.Text = oChiffrage.NCHIFFMOBE  'dr("NMOBE")
    txtPA.Text = oChiffrage.NCHIFFPAN ' dr("NFRAISPA")
    txtGD.Text = oChiffrage.NCHIFFGD  'dr("NFRAISGD")
    txtKM.Text = oChiffrage.NCHIFFKM  'dr("NFRAISKM")
    txtFrais.Text = oChiffrage.NCHIFFFRAISANNEXE ' dr("NFRAISDIV")
    txtObs.Text = oChiffrage.VCHIFFOBS  'IIf(IsDBNull(dr("VOBS")), "", dr("VOBS"))
    dtpChif.Value = oChiffrage.DCHIFFDEB ' dr("DCHIFDAT")
    'If oChiffrage.CPRORATA = "O" Then cmbProrata.Text = "OUI" Else cmbProrata.Text = "NON"   'dr("CPRORATA").ToString
    SpinPRPRORATA.Value = oChiffrage.NPCPRORATA ' dr("DCHIFDAT")

    txtMO_Meca.Text = oChiffrage.NCHIFFMO_MECA
    txtMO_Cabl.Text = oChiffrage.NCHIFFMO_CABL
    txtMO_AideTec.Text = oChiffrage.NCHIFFMO_AIDETEC

    txtBE_Auto.Text = oChiffrage.NCHIFFMOBE_AUTO
    txtBE_Elec.Text = oChiffrage.NCHIFFMOBE_ELEC
    txtBE_Meca.Text = oChiffrage.NCHIFFMOBE_MECA
    txtHRDeplace.Text = oChiffrage.NCHIFF_DEPLACE


    If iIDChantier <> 0 Then SpinPRPRORATA.Properties.ReadOnly = True Else SpinPRPRORATA.Properties.ReadOnly = False

    RemplirGridHisto()

  End Sub

  Private Sub RemplirCombo()

    Dim ds As SqlDataAdapter = New SqlDataAdapter("SELECT 0 NCLINUM, '' VCLINOM " _
                                                        + " UNION SELECT NCLINUM, VCLINOM FROM TCLI WITH (NOLOCK) WHERE CCLIACTIF = 'O' AND VSOCIETE = '" & MozartParams.NomSociete & "' AND TCLI.NCLINUM <> " + oChiffrage.NCLINUM.ToString _
                                                        + " UNION SELECT NCLINUM, VCLINOM FROM TCLI WITH (NOLOCK) WHERE TCLI.NCLINUM = " + oChiffrage.NCLINUM.ToString + " ORDER BY VCLINOM", MozartDatabase.cnxMozart)
    Dim dt As New DataTable
    Dim lStr = "SELECT 0 NPERNUM, '' VPERNOM " _
                + " UNION SELECT NPERNUM, (VPERNOM + ' ' + VPERPRE) AS VPERNOM FROM TPER WHERE (CPERTYP = 'CA' OR CPERTYPDETAIL = 'BJ') AND CPERACTIF = 'O' AND BUTILISATEUR = 0 AND VSOCIETE = '" _
                & MozartParams.NomSociete & "' AND TPER.NPERNUM <> " + oChiffrage.NCHAFFNUM.ToString _
                + " UNION SELECT NPERNUM, (VPERNOM + ' ' + VPERPRE) AS VPERNOM FROM TPER WHERE TPER.NPERNUM = " + oChiffrage.NCHAFFNUM.ToString + " ORDER BY VPERNOM"
    Dim dsPer As SqlDataAdapter = New SqlDataAdapter(lStr, MozartDatabase.cnxMozart)
    Dim dtPer As New DataTable
    Try
      ds.Fill(dt)
      cmbClient.DataSource = dt

      dsPer.Fill(dtPer)
      cmbChaf.DataSource = dtPer

    Catch Ex As Exception
      MessageBox.Show(My.Resources.Admin_frmChiffrage_ErreurR & Ex.Message)
    End Try

  End Sub

  Private Sub btnValider_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnValider.Click
    Try
      If cmbClient.SelectedValue = 0 Then
        MessageBox.Show(My.Resources.Admin_frmChiffrage_MessageC)
        cmbClient.Focus()
        Exit Sub
      End If

      If cmbChaf.SelectedValue = 0 Then
        MessageBox.Show(My.Resources.Admin_frmChiffrage_MessageAF)
        cmbChaf.Focus()
        Exit Sub
      End If

      If txtLibelle.Text = "" Then
        MessageBox.Show(My.Resources.Admin_frmChiffrage_MessageL)
        txtLibelle.Focus()
        Exit Sub
      End If

      If oChiffrage.NCHIFFPV = 0 Then
        MessageBox.Show(My.Resources.Admin_frmChiffrage_MessagePV)
        txtPV.Focus()
        Exit Sub
      End If

      'If txtMO.Text = "0" Then
      '    MessageBox.Show("Vous devez saisir une quantité de main d'oeuvre!")
      '    txtMO.Focus()
      '    Exit Sub
      'End If

      'on vérifie si rien n'est négatif sur la totalité du chantier
      If iIDChantier <> 0 Then
        If VerifChiffrage(iIDChantier, oChiffrage.NCHIFFMOADMIN, oChiffrage.NCHIFFFO, oChiffrage.NCHIFFST, oChiffrage.NCHIFFMO_MECA, oChiffrage.NCHIFFMO_CABL, oChiffrage.NCHIFFMO_AIDETEC) = False Then 'CType(txtMO.Text, Integer), CType(txtFO.Text, Integer), CType(txtSTT.Text, Integer)
          Exit Sub
        End If
      End If

      cmd = New SqlCommand("api_sp_ChantierCreationChif", MozartDatabase.cnxMozart)
      cmd.CommandType = CommandType.StoredProcedure

      cmd.Parameters.Add("@iD", SqlDbType.Int)
      cmd.Parameters("@iD").Value = iNIDCHIF
      cmd.Parameters.Add("@lib", SqlDbType.VarChar, 1000)
      cmd.Parameters("@lib").Value = txtLibelle.Text 'Replace(txtLibelle.Text, "'", "''")
      cmd.Parameters.Add("@cli", SqlDbType.Int)
      cmd.Parameters("@cli").Value = cmbClient.SelectedValue
      cmd.Parameters.Add("@date", SqlDbType.DateTime)
      cmd.Parameters("@date").Value = dtpChif.Value
      cmd.Parameters.Add("@ass", SqlDbType.Int)
      cmd.Parameters("@ass").Value = oChiffrage.NCHIFFMOASS ' Ctype(txtASS.Text, Integer)
      cmd.Parameters.Add("@mochaf", SqlDbType.Int)
      cmd.Parameters("@mochaf").Value = oChiffrage.NCHIFFMOCHAFF  ' Ctype(txtCHAF.Text, Integer)
      cmd.Parameters.Add("@be", SqlDbType.Int)
      cmd.Parameters("@be").Value = oChiffrage.NCHIFFMOBE  'Ctype(txtBE.Text, Integer)
      cmd.Parameters.Add("@pa", SqlDbType.Int)
      cmd.Parameters("@pa").Value = oChiffrage.NCHIFFPAN   'Ctype(txtPA.Text, Integer)
      cmd.Parameters.Add("@gd", SqlDbType.Int)
      cmd.Parameters("@gd").Value = oChiffrage.NCHIFFGD   'Ctype(txtGD.Text, Integer)
      cmd.Parameters.Add("@km", SqlDbType.Int)
      cmd.Parameters("@km").Value = oChiffrage.NCHIFFKM   'Ctype(txtKM.Text, Integer)
      cmd.Parameters.Add("@pv", SqlDbType.Int)
      cmd.Parameters("@pv").Value = oChiffrage.NCHIFFPV   'Ctype(txtPV.Text, Integer)
      cmd.Parameters.Add("@mo", SqlDbType.Int)
      cmd.Parameters("@mo").Value = oChiffrage.NCHIFFMOADMIN   'Ctype(txtMO.Text, Integer)
      cmd.Parameters.Add("@fo", SqlDbType.Int)
      cmd.Parameters("@fo").Value = oChiffrage.NCHIFFFO   'Ctype(txtFO.Text, Integer)
      cmd.Parameters.Add("@stt", SqlDbType.Int)
      cmd.Parameters("@stt").Value = oChiffrage.NCHIFFST  'Ctype(txtSTT.Text, Integer)
      cmd.Parameters.Add("@prorata", SqlDbType.Char, 1)
      cmd.Parameters("@prorata").Value = "N"
      cmd.Parameters.Add("@chaf", SqlDbType.Int)
      cmd.Parameters("@chaf").Value = cmbChaf.SelectedValue
      cmd.Parameters.Add("@obs", SqlDbType.VarChar, 2000)
      cmd.Parameters("@obs").Value = txtObs.Text
      cmd.Parameters.Add("@frais", SqlDbType.Int)
      cmd.Parameters("@frais").Value = oChiffrage.NCHIFFFRAISANNEXE   'Ctype(txtFrais.Text, Integer)
      cmd.Parameters.Add("@nprprorata", SqlDbType.Decimal)
      cmd.Parameters("@nprprorata").Value = oChiffrage.NPCPRORATA   'Ctype(txtFrais.Text, Integer)

      cmd.Parameters.Add("@mo_meca", SqlDbType.Int).Value = oChiffrage.NCHIFFMO_MECA
      cmd.Parameters.Add("@mo_cabl", SqlDbType.Int).Value = oChiffrage.NCHIFFMO_CABL
      cmd.Parameters.Add("@mo_aidetec", SqlDbType.Int).Value = oChiffrage.NCHIFFMO_AIDETEC

      cmd.Parameters.Add("@mobe_auto", SqlDbType.Int).Value = oChiffrage.NCHIFFMOBE_AUTO
      cmd.Parameters.Add("@mobe_elec", SqlDbType.Int).Value = oChiffrage.NCHIFFMOBE_ELEC
      cmd.Parameters.Add("@mobe_meca", SqlDbType.Int).Value = oChiffrage.NCHIFFMOBE_MECA
      cmd.Parameters.Add("@deplace", SqlDbType.Decimal).Value = oChiffrage.NCHIFF_DEPLACE


      Dim dr As SqlDataReader
      dr = cmd.ExecuteReader

      dr.Read()
      iNIDCHIF = dr(0)
      dr.Close()

      SyntheseChiffrage()

      'sauvegarde modif chiffrage
      Dim nTotalDebourse As Int32 = ((TxMOOuv * oChiffrage.NCHIFFMOADMIN) + (TxMO_Meca * oChiffrage.NCHIFFMO_MECA) + (TxMO_Cabl * oChiffrage.NCHIFFMO_CABL) + (TxMO_AideTec * oChiffrage.NCHIFFMO_AIDETEC) _
                                                + (TxMOAss * oChiffrage.NCHIFFMOASS) + (TxMOChaf * oChiffrage.NCHIFFMOCHAFF) + (TxMOBE * oChiffrage.NCHIFFMOBE) _
                                                + (TxMOBE_Auto * oChiffrage.NCHIFFMOBE_AUTO) + (TxMOBE_Elec * oChiffrage.NCHIFFMOBE_ELEC) + (TxMOBE_Meca * oChiffrage.NCHIFFMOBE_MECA) _
                                                       + (TxPanier * oChiffrage.NCHIFFPAN) + (TxGD * oChiffrage.NCHIFFGD) + (TxKM * oChiffrage.NCHIFFKM) + (oChiffrage.NCHIFFFRAISANNEXE) _
                                                       + (oChiffrage.NCHIFFFO) + (oChiffrage.NCHIFFST)) + (oChiffrage.NCHIFFPV * 0.01) + (TxDeplace * oChiffrage.NCHIFF_DEPLACE)

      nTotalDebourse = nTotalDebourse + (oChiffrage.NCHIFFPV * oChiffrage.NPCPRORATA)

      cmd = New SqlCommand("[api_sp_ChantierCreationChifHisto]", MozartDatabase.cnxMozart)
      cmd.CommandType = CommandType.StoredProcedure
      cmd.Parameters.Add("@iD", SqlDbType.Int).Value = iNIDCHIF
      cmd.Parameters.Add("@pv", SqlDbType.Int).Value = oChiffrage.NCHIFFPV
      cmd.Parameters.Add("@tx", SqlDbType.Decimal).Value = ReturnValDivision((oChiffrage.NCHIFFPV - (oChiffrage.NCHIFFPV * oChiffrage.NTAUX_FG) - nTotalDebourse), oChiffrage.NCHIFFPV) * 100
      cmd.Parameters.Add("@P_NMARGENET", SqlDbType.Int).Value = oChiffrage.NCHIFFPV - (oChiffrage.NCHIFFPV * oChiffrage.NTAUX_FG) - nTotalDebourse
      cmd.Parameters.Add("@P_NMOPRODHRTOT", SqlDbType.Int).Value = oChiffrage.NCHIFFMOADMIN
      cmd.Parameters.Add("@P_NMOPRODHTTOT", SqlDbType.Int).Value = TxMOOuv * oChiffrage.NCHIFFMOADMIN
      cmd.Parameters.Add("@P_NMO_MECA_HRTOT", SqlDbType.Int).Value = oChiffrage.NCHIFFMO_MECA
      cmd.Parameters.Add("@P_NMO_MECA_HTTOT", SqlDbType.Int).Value = TxMO_Meca * oChiffrage.NCHIFFMO_MECA
      cmd.Parameters.Add("@P_NMO_CABL_HRTOT", SqlDbType.Int).Value = oChiffrage.NCHIFFMO_CABL
      cmd.Parameters.Add("@P_NMO_CABL_HTTOT", SqlDbType.Int).Value = TxMO_Cabl * oChiffrage.NCHIFFMO_CABL
      cmd.Parameters.Add("@P_NMO_AIDETEC_HRTOT", SqlDbType.Int).Value = oChiffrage.NCHIFFMO_AIDETEC
      cmd.Parameters.Add("@P_NMO_AIDETEC_HTTOT", SqlDbType.Int).Value = TxMO_AideTec * oChiffrage.NCHIFFMO_AIDETEC
      cmd.Parameters.Add("@P_NMOADMINTOT", SqlDbType.Int).Value = (TxMOAss * oChiffrage.NCHIFFMOASS) + (TxMOChaf * oChiffrage.NCHIFFMOCHAFF) + (TxMOBE * oChiffrage.NCHIFFMOBE) + (TxMOBE_Auto * oChiffrage.NCHIFFMOBE_AUTO) + (TxMOBE_Elec * oChiffrage.NCHIFFMOBE_ELEC) + (TxMOBE_Meca * oChiffrage.NCHIFFMO_MECA)
      cmd.Parameters.Add("@P_NFRAISANNEXTOT", SqlDbType.Int).Value = (TxPanier * oChiffrage.NCHIFFPAN) + (TxGD * oChiffrage.NCHIFFGD) + (TxKM * oChiffrage.NCHIFFKM) + (oChiffrage.NCHIFFFRAISANNEXE) + (TxDeplace * oChiffrage.NCHIFF_DEPLACE)
      cmd.Parameters.Add("@P_NFOTOT", SqlDbType.Int).Value = oChiffrage.NCHIFFFO
      cmd.Parameters.Add("@P_NSTTOT", SqlDbType.Int).Value = oChiffrage.NCHIFFST

      cmd.ExecuteNonQuery()

      RemplirGridHisto()

      bEnreg = True

      'verifie si le fichier existe
      Dim oFicPlanningXLS As New CGestionPlanningXLS(iNIDCHIF)
      If oFicPlanningXLS.ExistPlanningXLS = False Then oFicPlanningXLS.CreateFichierPlanningXLS(cmbClient.Text, MozartParams.NomSociete)

    Catch ex As Exception
      MessageBox.Show(My.Resources.Admin_frmChiffrage_ErreurB & ex.Message)
    End Try
  End Sub

  Private Sub SyntheseChiffrage()
    Try
      Dim nTotalDebourse As Int32 = ((TxMOOuv * oChiffrage.NCHIFFMOADMIN) + (TxMO_Meca * oChiffrage.NCHIFFMO_MECA) + (TxMO_Cabl * oChiffrage.NCHIFFMO_CABL) + (TxMO_AideTec * oChiffrage.NCHIFFMO_AIDETEC) _
                                            + (TxMOAss * oChiffrage.NCHIFFMOASS) + (TxMOChaf * oChiffrage.NCHIFFMOCHAFF) + (TxMOBE * oChiffrage.NCHIFFMOBE) _
                                            + (TxMOBE_Auto * oChiffrage.NCHIFFMOBE_AUTO) + (TxMOBE_Elec * oChiffrage.NCHIFFMOBE_ELEC) + (TxMOBE_Meca * oChiffrage.NCHIFFMOBE_MECA) _
                                                        + (TxPanier * oChiffrage.NCHIFFPAN) + (TxGD * oChiffrage.NCHIFFGD) + (TxKM * oChiffrage.NCHIFFKM) + (oChiffrage.NCHIFFFRAISANNEXE) _
                                                        + (oChiffrage.NCHIFFFO) + (oChiffrage.NCHIFFST)) + (oChiffrage.NCHIFFPV * 0.01) + (TxDeplace * oChiffrage.NCHIFF_DEPLACE)

      'If cmbProrata.Text = "OUI" Then nTotalDebourse = nTotalDebourse + (oChiffrage.NCHIFFPV * 0.015)

      nTotalDebourse = nTotalDebourse + (oChiffrage.NCHIFFPV * oChiffrage.NPCPRORATA)

      LblTotHTMOProd.Text = String.Format("{0:c0}", (TxMOOuv * oChiffrage.NCHIFFMOADMIN) + (TxMO_Meca * oChiffrage.NCHIFFMO_MECA) + (TxMO_Cabl * oChiffrage.NCHIFFMO_CABL) + (TxMO_AideTec * oChiffrage.NCHIFFMO_AIDETEC))
      LblTotPMOProd.Text = String.Format(FORMAT_POURC, ReturnValDivision((TxMOOuv * oChiffrage.NCHIFFMOADMIN) + (TxMO_Meca * oChiffrage.NCHIFFMO_MECA) + (TxMO_Cabl * oChiffrage.NCHIFFMO_CABL) + (TxMO_AideTec * oChiffrage.NCHIFFMO_AIDETEC), oChiffrage.NCHIFFPV))

      LblTotHTMOAdmin.Text = String.Format("{0:c0}", (TxMOAss * oChiffrage.NCHIFFMOASS) + (TxMOChaf * oChiffrage.NCHIFFMOCHAFF))
      LblTotPMOAdmin.Text = String.Format(FORMAT_POURC, ReturnValDivision(((TxMOAss * oChiffrage.NCHIFFMOASS) + (TxMOChaf * oChiffrage.NCHIFFMOCHAFF)), oChiffrage.NCHIFFPV))

      LblTotHTMO_BE.Text = String.Format("{0:c0}", (TxMOBE * oChiffrage.NCHIFFMOBE) + (TxMOBE_Auto * oChiffrage.NCHIFFMOBE_AUTO) + (TxMOBE_Elec * oChiffrage.NCHIFFMOBE_ELEC) + (TxMOBE_Meca * oChiffrage.NCHIFFMOBE_MECA))
      LblTotPMO_BE.Text = String.Format(FORMAT_POURC, ReturnValDivision(((TxMOBE * oChiffrage.NCHIFFMOBE) + (TxMOBE_Auto * oChiffrage.NCHIFFMOBE_AUTO) + (TxMOBE_Elec * oChiffrage.NCHIFFMOBE_ELEC) + (TxMOBE_Meca * oChiffrage.NCHIFFMOBE_MECA)), oChiffrage.NCHIFFPV))

      LblHTMO_Meca.Text = String.Format("{0:c0}", TxMO_Meca * oChiffrage.NCHIFFMO_MECA)
      LblPMO_Meca.Text = String.Format(FORMAT_POURC, ReturnValDivision((TxMO_Meca * oChiffrage.NCHIFFMO_MECA), oChiffrage.NCHIFFPV))

      LblHTMO_Cabl.Text = String.Format("{0:c0}", TxMO_Cabl * oChiffrage.NCHIFFMO_CABL)
      LblPMO_Cabl.Text = String.Format(FORMAT_POURC, ReturnValDivision((TxMO_Cabl * oChiffrage.NCHIFFMO_CABL), oChiffrage.NCHIFFPV))

      LblHTMO_AideTec.Text = String.Format("{0:c0}", TxMO_AideTec * oChiffrage.NCHIFFMO_AIDETEC)
      LblPMO_AideTec.Text = String.Format(FORMAT_POURC, ReturnValDivision((TxMO_AideTec * oChiffrage.NCHIFFMO_AIDETEC), oChiffrage.NCHIFFPV))

      LblHTMOBE_Auto.Text = String.Format("{0:c0}", TxMOBE_Auto * oChiffrage.NCHIFFMOBE_AUTO)
      LblPMOBE_Auto.Text = String.Format(FORMAT_POURC, ReturnValDivision((TxMOBE_Auto * oChiffrage.NCHIFFMOBE_AUTO), oChiffrage.NCHIFFPV))

      LblHTMOBE_Elec.Text = String.Format("{0:c0}", TxMOBE_Elec * oChiffrage.NCHIFFMOBE_ELEC)
      LblPMOBE_Elec.Text = String.Format(FORMAT_POURC, ReturnValDivision((TxMOBE_Elec * oChiffrage.NCHIFFMOBE_ELEC), oChiffrage.NCHIFFPV))

      LblHTMOBE_Meca.Text = String.Format("{0:c0}", TxMOBE_Meca * oChiffrage.NCHIFFMOBE_MECA)
      LblPMOBE_Meca.Text = String.Format(FORMAT_POURC, ReturnValDivision((TxMOBE_Meca * oChiffrage.NCHIFFMOBE_MECA), oChiffrage.NCHIFFPV))

      LblTotHTFraisAnnexe.Text = String.Format("{0:c0}", (TxPanier * oChiffrage.NCHIFFPAN) + (TxGD * oChiffrage.NCHIFFGD) + (TxKM * oChiffrage.NCHIFFKM) + (TxDeplace * oChiffrage.NCHIFF_DEPLACE) + (oChiffrage.NCHIFFFRAISANNEXE))
      LblTotPFraisAnnexe.Text = String.Format(FORMAT_POURC, ReturnValDivision(((TxPanier * oChiffrage.NCHIFFPAN) + (TxGD * oChiffrage.NCHIFFGD) + (TxKM * oChiffrage.NCHIFFKM) + (TxDeplace * oChiffrage.NCHIFF_DEPLACE) + (oChiffrage.NCHIFFFRAISANNEXE)), oChiffrage.NCHIFFPV))

      LblHTProrata.Text = String.Format("{0:c0}", oChiffrage.NCHIFFPV * oChiffrage.NPCPRORATA)
      LblPProrata.Text = String.Format(FORMAT_POURC, ReturnValDivision((oChiffrage.NCHIFFPV * oChiffrage.NPCPRORATA), oChiffrage.NCHIFFPV))

      LblHTGarantie.Text = String.Format("{0:c0}", oChiffrage.NCHIFFPV * 0.01)
      LblPGarantie.Text = String.Format(FORMAT_POURC, ReturnValDivision((oChiffrage.NCHIFFPV * 0.01), oChiffrage.NCHIFFPV))

      LblHTDEB.Text = String.Format("{0:c0}", nTotalDebourse) 'CLng(dr("DEBOURSE") ).ToString()
      LblPDEB.Text = String.Format(FORMAT_POURC, ReturnValDivision(nTotalDebourse, oChiffrage.NCHIFFPV)) 'CLng(dr("DEBOURSE") ).ToString()

      LblHTFG.Text = String.Format("{0:c0}", oChiffrage.NCHIFFPV * oChiffrage.NTAUX_FG) 'CLng(dr("FRAISGENE")).ToString()
      LblPFG.Text = String.Format(FORMAT_POURC, ReturnValDivision((oChiffrage.NCHIFFPV * oChiffrage.NTAUX_FG), oChiffrage.NCHIFFPV)) 'CLng(dr("FRAISGENE")).ToString()

      LblHTCR_FG.Text = String.Format("{0:c0}", nTotalDebourse + (oChiffrage.NCHIFFPV * oChiffrage.NTAUX_FG)) 'CLng(dr("PVENTE")).ToString()
      LblPCR_FG.Text = String.Format(FORMAT_POURC, ReturnValDivision((nTotalDebourse + (oChiffrage.NCHIFFPV * oChiffrage.NTAUX_FG)), oChiffrage.NCHIFFPV)) 'CLng(dr("PVENTE")).ToString()

      LblHTMargeNet.Text = String.Format("{0:c0}", oChiffrage.NCHIFFPV - (oChiffrage.NCHIFFPV * oChiffrage.NTAUX_FG) - nTotalDebourse) 'CLng(dr("MARGE")).ToString()
      LblPMargeNet.Text = String.Format(FORMAT_POURC, ReturnValDivision((oChiffrage.NCHIFFPV - (oChiffrage.NCHIFFPV * oChiffrage.NTAUX_FG) - nTotalDebourse), oChiffrage.NCHIFFPV)) 'CLng(dr("TX")).ToString()

    Catch ex As Exception
      MessageBox.Show(My.Resources.Admin_frmChiffrage_ErreurS & ex.Message)
    End Try
  End Sub

  Private Sub btnFermer_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnFermer.Click
    If Not bEnreg Then
      If MessageBox.Show(My.Resources.Global_MessageEnre, My.Resources.Global_Enregistrer, MessageBoxButtons.YesNoCancel, MessageBoxIcon.Question) = DialogResult.Yes Then
        btnValider.PerformClick()
      End If
    End If

    Me.Close()
  End Sub

  Private Function VerifChiffrage(ByVal idChantier As Integer, ByVal nbMO As Integer, ByVal TotCmdFO As Integer, ByVal TotCST As Integer, ByVal nbMO_Meca As Integer, ByVal nbMO_Cabl As Integer, ByVal nbMO_AideTec As Integer) As Boolean

    Try

      Dim bVerif As Boolean = True

      Dim cmdVerif As New SqlCommand("api_sp_ChantierVerifCreateChif", MozartDatabase.cnxMozart)
      cmdVerif.CommandType = CommandType.StoredProcedure

      cmdVerif.Parameters.Add("@iD", SqlDbType.Int)
      cmdVerif.Parameters("@iD").Value = idChantier

      cmdVerif.Parameters.Add("@mo", SqlDbType.Int)
      cmdVerif.Parameters("@mo").Value = nbMO

      cmdVerif.Parameters.Add("@fo", SqlDbType.Int)
      cmdVerif.Parameters("@fo").Value = TotCmdFO

      cmdVerif.Parameters.Add("@stt", SqlDbType.Int)
      cmdVerif.Parameters("@stt").Value = TotCST

      cmdVerif.Parameters.Add("@mo_meca", SqlDbType.Int).Value = nbMO_Meca
      cmdVerif.Parameters.Add("@mo_cabl", SqlDbType.Int).Value = nbMO_Cabl
      cmdVerif.Parameters.Add("@mo_aidetec", SqlDbType.Int).Value = nbMO_AideTec

      Dim drVerif As SqlDataReader = cmdVerif.ExecuteReader

      If drVerif.HasRows = True Then

        drVerif.Read()

        If drVerif.Item("TOTMO") < 0 Then
          MessageBox.Show(My.Resources.Global_NbrHeures + drVerif.Item("TOTMO").ToString + ")", My.Resources.Global_Erreur, MessageBoxButtons.OK, MessageBoxIcon.Error)
          bVerif = False
        End If

        If drVerif.Item("TOTFO") < 0 Then
          MessageBox.Show(My.Resources.Global_MontantFournitures + drVerif.Item("TOTFO").ToString + ")", My.Resources.Global_Erreur, MessageBoxButtons.OK, MessageBoxIcon.Error)
          bVerif = False
        End If

        If drVerif.Item("TOTSTT") < 0 Then
          MessageBox.Show(My.Resources.Global_MontantHeures + drVerif.Item("TOTSTT").ToString + ")", My.Resources.Global_Erreur, MessageBoxButtons.OK, MessageBoxIcon.Error)
          bVerif = False
        End If

        If drVerif.Item("TOTMO_MECA") < 0 Then
          MessageBox.Show(My.Resources.Global_MontantHeures_Meca + drVerif.Item("TOTMO_MECA").ToString + ")", My.Resources.Global_Erreur, MessageBoxButtons.OK, MessageBoxIcon.Error)
          bVerif = False
        End If

        If drVerif.Item("TOTMO_CABL") < 0 Then
          MessageBox.Show(My.Resources.Global_MontantHeures_Cabl + drVerif.Item("TOTMO_CABL").ToString + ")", My.Resources.Global_Erreur, MessageBoxButtons.OK, MessageBoxIcon.Error)
          bVerif = False
        End If

        If drVerif.Item("TOTMO_AIDETEC") < 0 Then
          MessageBox.Show(My.Resources.Global_MontantHeures_AideTec + drVerif.Item("TOTMO_AIDETEC").ToString + ")", My.Resources.Global_Erreur, MessageBoxButtons.OK, MessageBoxIcon.Error)
          bVerif = False
        End If

      End If

      drVerif.Close()

      Return bVerif

    Catch ex As Exception
      MessageBox.Show("VerifChiffrage " + ex.Message)
      Return False
    End Try

  End Function

  Private Sub RemplirGridHisto()
    Dim daData As SqlDataAdapter
    Dim dtData As DataTable
    Dim cmdGrid As SqlCommand
    Dim ssql As String

    ssql = "SELECT DDATEMODIF, VPERPRE + ' ' + VPERNOM AS USR , NPV, NTXMARGE, NMARGENET, NMOPRODHRTOT, NMOPRODHTTOT, NMOADMINTOT, NFRAISANNEXTOT, NFOTOT, NSTTOT, NMO_MECA_HRTOT, NMO_MECA_HTTOT, NMO_CABL_HRTOT, NMO_CABL_HTTOT, NMO_AIDETEC_HRTOT, NMO_AIDETEC_HTTOT " _
        & "FROM TCHANTIERCHIFFRAGEHISTO WITH(NOLOCK) INNER JOIN " _
        & "TPER WITH(NOLOCK) ON TCHANTIERCHIFFRAGEHISTO.NPERNUM = TPER.NPERNUM " _
        & "WHERE(NIDCHIF = " & iNIDCHIF & ") " _
        & "ORDER BY DDATEMODIF DESC "

    cmdGrid = New SqlCommand(ssql, MozartDatabase.cnxMozart)
    cmdGrid.CommandType = CommandType.Text

    daData = New SqlDataAdapter
    dtData = New DataTable

    daData.SelectCommand = cmdGrid
    daData.Fill(dtData)

    grdHisto.DataSource = dtData
  End Sub

  Private Sub txtData_EditValueChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles txtMO.EditValueChanged, txtASS.EditValueChanged, txtCHAF.EditValueChanged, txtPA.EditValueChanged, txtGD.EditValueChanged, txtFrais.EditValueChanged,
                                                                                                txtKM.EditValueChanged, txtFO.EditValueChanged, txtSTT.EditValueChanged,
                                                                                                txtMO_Meca.EditValueChanged, txtMO_Cabl.EditValueChanged, txtMO_AideTec.EditValueChanged, txtBE.EditValueChanged,
                                                                                                txtBE_Auto.EditValueChanged, txtBE_Elec.EditValueChanged, txtBE_Meca.EditValueChanged, txtHRDeplace.EditValueChanged

    Dim oTxtEdit As DevExpress.XtraEditors.TextEdit = TryCast(sender, DevExpress.XtraEditors.TextEdit)

    If (oTxtEdit.Text <> "") AndAlso (IsNumeric(oTxtEdit.Text)) Then

      Select Case oTxtEdit.Name
        Case "txtMO"

          oChiffrage.NCHIFFMOADMIN = IIf(oTxtEdit.Text = "", 0, CType(oTxtEdit.Text, Int32))
          LblHTMOProd.Text = String.Format("{0:c0}", TxMOOuv * oChiffrage.NCHIFFMOADMIN)
          LblPMOProd.Text = String.Format(FORMAT_POURC, ReturnValDivision((TxMOOuv * oChiffrage.NCHIFFMOADMIN), oChiffrage.NCHIFFPV))

          'ceci n'est valable que pour la creation
          If iNIDCHIF = 0 Then
            If MozartParams.NomSociete = "SCS" Then
              txtPA.Text = String.Format("{0}", oChiffrage.NCHIFFMOADMIN \ 8.75)
            Else
              txtPA.Text = String.Format("{0}", oChiffrage.NCHIFFMOADMIN \ 8)
            End If
          End If

        Case "txtASS"
          oChiffrage.NCHIFFMOASS = IIf(oTxtEdit.Text = "", 0, CType(oTxtEdit.Text, Int32))
          LblHTMOAss.Text = String.Format("{0:c0}", TxMOAss * oChiffrage.NCHIFFMOASS)
          LblPMOAss.Text = String.Format(FORMAT_POURC, ReturnValDivision((TxMOAss * oChiffrage.NCHIFFMOASS), oChiffrage.NCHIFFPV))
        Case "txtCHAF"
          oChiffrage.NCHIFFMOCHAFF = IIf(oTxtEdit.Text = "", 0, CType(oTxtEdit.Text, Int32))
          LblHTMOChaff.Text = String.Format("{0:c0}", TxMOChaf * oChiffrage.NCHIFFMOCHAFF)
          LblPMOChaff.Text = String.Format(FORMAT_POURC, ReturnValDivision((TxMOChaf * oChiffrage.NCHIFFMOCHAFF), oChiffrage.NCHIFFPV))
        Case "txtBE"
          oChiffrage.NCHIFFMOBE = IIf(oTxtEdit.Text = "", 0, CType(oTxtEdit.Text, Int32))
          LblHTMOBE.Text = String.Format("{0:c0}", TxMOBE * oChiffrage.NCHIFFMOBE)
          LblPMOBE.Text = String.Format(FORMAT_POURC, ReturnValDivision((TxMOBE * oChiffrage.NCHIFFMOBE), oChiffrage.NCHIFFPV))
        Case "txtPA"
          oChiffrage.NCHIFFPAN = IIf(oTxtEdit.Text = "", 0, CType(oTxtEdit.Text, Int32))
          LblHTFAPan.Text = String.Format("{0:c0}", TxPanier * oChiffrage.NCHIFFPAN)
          LblPFAPan.Text = String.Format(FORMAT_POURC, ReturnValDivision((TxPanier * oChiffrage.NCHIFFPAN), oChiffrage.NCHIFFPV))
        Case "txtGD"
          oChiffrage.NCHIFFGD = IIf(oTxtEdit.Text = "", 0, CType(oTxtEdit.Text, Int32))
          LblHTFAGD.Text = String.Format("{0:c0}", TxGD * oChiffrage.NCHIFFGD)
          LblPFAGD.Text = String.Format(FORMAT_POURC, ReturnValDivision((TxGD * oChiffrage.NCHIFFGD), oChiffrage.NCHIFFPV))
        Case "txtKM"
          oChiffrage.NCHIFFKM = IIf(oTxtEdit.Text = "", 0, CType(oTxtEdit.Text, Int32))
          LblHTFAKM.Text = String.Format("{0:c0}", TxKM * oChiffrage.NCHIFFKM)
          LblPFAKM.Text = String.Format(FORMAT_POURC, ReturnValDivision((TxKM * oChiffrage.NCHIFFKM), oChiffrage.NCHIFFPV))
        Case "txtHRDeplace"
          oChiffrage.NCHIFF_DEPLACE = IIf(oTxtEdit.Text = "", 0, CType(oTxtEdit.Text, Int32))
          LblHTFAHrDeplace.Text = String.Format("{0:c0}", TxDeplace * oChiffrage.NCHIFF_DEPLACE)
          LblPFAHrDeplace.Text = String.Format(FORMAT_POURC, ReturnValDivision((TxDeplace * oChiffrage.NCHIFF_DEPLACE), oChiffrage.NCHIFFPV))
        Case "txtFrais"
          oChiffrage.NCHIFFFRAISANNEXE = IIf(oTxtEdit.Text = "", 0, CType(oTxtEdit.Text, Int32))
          LblPFADivers.Text = String.Format(FORMAT_POURC, ReturnValDivision((oChiffrage.NCHIFFFRAISANNEXE), oChiffrage.NCHIFFPV))
        Case "txtFO"
          oChiffrage.NCHIFFFO = IIf(oTxtEdit.Text = "", 0, CType(oTxtEdit.Text, Int32))
          LblPFO.Text = String.Format(FORMAT_POURC, ReturnValDivision((oChiffrage.NCHIFFFO), oChiffrage.NCHIFFPV))
        Case "txtSTT"
          oChiffrage.NCHIFFST = IIf(oTxtEdit.Text = "", 0, CType(oTxtEdit.Text, Int32))
          LblPST.Text = String.Format(FORMAT_POURC, ReturnValDivision((oChiffrage.NCHIFFST), oChiffrage.NCHIFFPV))
        Case "txtMO_Meca"
          oChiffrage.NCHIFFMO_MECA = IIf(oTxtEdit.Text = "", 0, CType(oTxtEdit.Text, Int32))
          LblHTMO_Meca.Text = String.Format("{0:c0}", TxMO_Meca * oChiffrage.NCHIFFMO_MECA)
          LblPMO_Meca.Text = String.Format(FORMAT_POURC, ReturnValDivision((TxMO_Meca * oChiffrage.NCHIFFMO_MECA), oChiffrage.NCHIFFPV))
        Case "txtMO_Cabl"
          oChiffrage.NCHIFFMO_CABL = IIf(oTxtEdit.Text = "", 0, CType(oTxtEdit.Text, Int32))
          LblHTMO_Cabl.Text = String.Format("{0:c0}", TxMO_Cabl * oChiffrage.NCHIFFMO_CABL)
          LblPMO_Cabl.Text = String.Format(FORMAT_POURC, ReturnValDivision((TxMO_Cabl * oChiffrage.NCHIFFMO_CABL), oChiffrage.NCHIFFPV))
        Case "txtMO_AideTec"
          oChiffrage.NCHIFFMO_AIDETEC = IIf(oTxtEdit.Text = "", 0, CType(oTxtEdit.Text, Int32))
          LblHTMO_AideTec.Text = String.Format("{0:c0}", TxMO_AideTec * oChiffrage.NCHIFFMO_AIDETEC)
          LblPMO_AideTec.Text = String.Format(FORMAT_POURC, ReturnValDivision((TxMO_AideTec * oChiffrage.NCHIFFMO_AIDETEC), oChiffrage.NCHIFFPV))
        Case "txtBE_Auto"
          oChiffrage.NCHIFFMOBE_AUTO = IIf(oTxtEdit.Text = "", 0, CType(oTxtEdit.Text, Int32))
          LblHTMOBE_Auto.Text = String.Format("{0:c0}", TxMOBE_Auto * oChiffrage.NCHIFFMOBE_AUTO)
          LblPMOBE_Auto.Text = String.Format(FORMAT_POURC, ReturnValDivision((TxMOBE_Auto * oChiffrage.NCHIFFMOBE_AUTO), oChiffrage.NCHIFFPV))
        Case "txtBE_Elec"
          oChiffrage.NCHIFFMOBE_ELEC = IIf(oTxtEdit.Text = "", 0, CType(oTxtEdit.Text, Int32))
          LblHTMOBE_Elec.Text = String.Format("{0:c0}", TxMOBE_Elec * oChiffrage.NCHIFFMOBE_ELEC)
          LblPMOBE_Elec.Text = String.Format(FORMAT_POURC, ReturnValDivision((TxMOBE_Elec * oChiffrage.NCHIFFMOBE_ELEC), oChiffrage.NCHIFFPV))
        Case "txtBE_Meca"
          oChiffrage.NCHIFFMOBE_MECA = IIf(oTxtEdit.Text = "", 0, CType(oTxtEdit.Text, Int32))
          LblHTMOBE_Meca.Text = String.Format("{0:c0}", TxMOBE_Meca * oChiffrage.NCHIFFMOBE_MECA)
          LblPMOBE_Meca.Text = String.Format(FORMAT_POURC, ReturnValDivision((TxMOBE_Meca * oChiffrage.NCHIFFMOBE_MECA), oChiffrage.NCHIFFPV))
        Case "txtHRDeplace"
          oChiffrage.NCHIFF_DEPLACE = IIf(oTxtEdit.Text = "", 0, CType(oTxtEdit.Text, Int32))
          LblHTFAHrDeplace.Text = String.Format("{0:c0}", TxDeplace * oChiffrage.NCHIFF_DEPLACE)
          LblPFAHrDeplace.Text = String.Format(FORMAT_POURC, ReturnValDivision((TxDeplace * oChiffrage.NCHIFF_DEPLACE), oChiffrage.NCHIFFPV))


      End Select

      SyntheseChiffrage()

    End If

  End Sub

  Private Sub txtPV_EditValueChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles txtPV.EditValueChanged

    If (txtPV.Text <> "") AndAlso (IsNumeric(txtPV.Text)) Then

      oChiffrage.NCHIFFPV = IIf(txtPV.Text = "", 0, CType(txtPV.Text, Int32))

      LblHTMOProd.Text = String.Format("{0:c0}", TxMOOuv * oChiffrage.NCHIFFMOADMIN)
      LblPMOProd.Text = String.Format(FORMAT_POURC, ReturnValDivision((TxMOOuv * oChiffrage.NCHIFFMOADMIN), oChiffrage.NCHIFFPV))

      LblHTMO_Meca.Text = String.Format("{0:c0}", TxMO_Meca * oChiffrage.NCHIFFMO_MECA)
      LblPMO_Meca.Text = String.Format(FORMAT_POURC, ReturnValDivision((TxMO_Meca * oChiffrage.NCHIFFMO_MECA), oChiffrage.NCHIFFPV))

      LblHTMO_Cabl.Text = String.Format("{0:c0}", TxMO_Cabl * oChiffrage.NCHIFFMO_CABL)
      LblHTMO_Cabl.Text = String.Format(FORMAT_POURC, ReturnValDivision((TxMO_Cabl * oChiffrage.NCHIFFMO_CABL), oChiffrage.NCHIFFPV))

      LblHTMO_AideTec.Text = String.Format("{0:c0}", TxMO_AideTec * oChiffrage.NCHIFFMO_AIDETEC)
      LblPMO_AideTec.Text = String.Format(FORMAT_POURC, ReturnValDivision((TxMO_AideTec * oChiffrage.NCHIFFMO_AIDETEC), oChiffrage.NCHIFFPV))

      LblHTMOAss.Text = String.Format("{0:c0}", TxMOAss * oChiffrage.NCHIFFMOASS)
      LblPMOAss.Text = String.Format(FORMAT_POURC, ReturnValDivision((TxMOAss * oChiffrage.NCHIFFMOASS), oChiffrage.NCHIFFPV))

      LblHTMOChaff.Text = String.Format("{0:c0}", TxMOChaf * oChiffrage.NCHIFFMOCHAFF)
      LblPMOChaff.Text = String.Format(FORMAT_POURC, ReturnValDivision((TxMOChaf * oChiffrage.NCHIFFMOCHAFF), oChiffrage.NCHIFFPV))

      LblHTMOBE.Text = String.Format("{0:c0}", TxMOBE * oChiffrage.NCHIFFMOBE)
      LblPMOBE.Text = String.Format(FORMAT_POURC, ReturnValDivision((TxMOBE * oChiffrage.NCHIFFMOBE), oChiffrage.NCHIFFPV))

      LblHTMOBE_Auto.Text = String.Format("{0:c0}", TxMOBE_Auto * oChiffrage.NCHIFFMOBE_AUTO)
      LblPMOBE_Auto.Text = String.Format(FORMAT_POURC, ReturnValDivision((TxMOBE_Auto * oChiffrage.NCHIFFMOBE_AUTO), oChiffrage.NCHIFFPV))

      LblHTMOBE_Elec.Text = String.Format("{0:c0}", TxMOBE_Elec * oChiffrage.NCHIFFMOBE_ELEC)
      LblPMOBE_Elec.Text = String.Format(FORMAT_POURC, ReturnValDivision((TxMOBE_Elec * oChiffrage.NCHIFFMOBE_ELEC), oChiffrage.NCHIFFPV))

      LblHTMOBE_Meca.Text = String.Format("{0:c0}", TxMOBE_Meca * oChiffrage.NCHIFFMOBE_MECA)
      LblHTMOBE_Meca.Text = String.Format(FORMAT_POURC, ReturnValDivision((TxMOBE_Meca * oChiffrage.NCHIFFMOBE_MECA), oChiffrage.NCHIFFPV))

      LblHTFAPan.Text = String.Format("{0:c0}", TxPanier * oChiffrage.NCHIFFPAN)
      LblPFAPan.Text = String.Format(FORMAT_POURC, ReturnValDivision((TxPanier * oChiffrage.NCHIFFPAN), oChiffrage.NCHIFFPV))

      LblHTFAGD.Text = String.Format("{0:c0}", TxGD * oChiffrage.NCHIFFGD)
      LblPFAGD.Text = String.Format(FORMAT_POURC, ReturnValDivision((TxGD * oChiffrage.NCHIFFGD), oChiffrage.NCHIFFPV))

      LblHTFAKM.Text = String.Format("{0:c0}", TxKM * oChiffrage.NCHIFFKM)
      LblPFAKM.Text = String.Format(FORMAT_POURC, ReturnValDivision((TxKM * oChiffrage.NCHIFFKM), oChiffrage.NCHIFFPV))

      LblPFADivers.Text = String.Format(FORMAT_POURC, ReturnValDivision((oChiffrage.NCHIFFFRAISANNEXE), oChiffrage.NCHIFFPV))

      LblPFO.Text = String.Format(FORMAT_POURC, ReturnValDivision((oChiffrage.NCHIFFFO), oChiffrage.NCHIFFPV))

      LblPST.Text = String.Format(FORMAT_POURC, ReturnValDivision((oChiffrage.NCHIFFST), oChiffrage.NCHIFFPV))

      SyntheseChiffrage()

    End If

  End Sub

  Private Sub txtObs_TextChanged(ByVal sender As System.Object, ByVal e As System.EventArgs)

    oChiffrage.VCHIFFOBS = txtObs.Text

  End Sub

  Private Sub txtLibelle_TextChanged(ByVal sender As System.Object, ByVal e As System.EventArgs)

    oChiffrage.VCHIFFLIB = txtLibelle.Text

  End Sub

  Private Sub dtpChif_ValueChanged(ByVal sender As System.Object, ByVal e As System.EventArgs)

    oChiffrage.DCHIFFDEB = dtpChif.Value

  End Sub

  Private Sub cmbProrata_SelectedValueChanged(ByVal sender As Object, ByVal e As System.EventArgs)

    SyntheseChiffrage()

  End Sub

  Private Sub BtnImprimer_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles BtnImprimer.Click

    Dim oScreen As New CSreenShot(Me, True)

    oScreen.Print_Form()

  End Sub

  Private Sub SpinPRPRORATA_EditValueChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles SpinPRPRORATA.EditValueChanged
    oChiffrage.NPCPRORATA = SpinPRPRORATA.Value
    SyntheseChiffrage()
  End Sub

  Private Sub SpinPRPRORATA_MouseClick(ByVal sender As Object, ByVal e As System.Windows.Forms.MouseEventArgs) Handles SpinPRPRORATA.MouseClick
    'on test si le chiffrage est affecter à un chantier.
    'si oui alors on ne peut pas modifier le % du prorata
    If oChiffrage.NIDCHANTIER <> 0 Then
      MessageBox.Show(My.Resources.Admin_frmChiffrage_Modif_Impossible, My.Resources.Admin_frmChiffrage_ErreurModif, MessageBoxButtons.OK, MessageBoxIcon.Exclamation)
    End If
  End Sub

  Private Function ReturnValDivision(ByVal p_dividende As Object, ByVal p_diviseur As Object) As Object

    Try

      Select Case p_diviseur
        Case 0
          Return 0
        Case Else
          Return p_dividende / p_diviseur
      End Select

    Catch ex As Exception

      MessageBox.Show("ReturnValDivision " + ex.Message)
      Return 0

    End Try

  End Function

  Private Sub txtMO_Spin(sender As Object, e As SpinEventArgs) Handles txtMO.Spin, txtMO_Meca.Spin, txtMO_Cabl.Spin, txtMO_AideTec.Spin, txtASS.Spin, txtCHAF.Spin, txtPA.Spin, txtGD.Spin, txtKM.Spin, txtFrais.Spin, txtFO.Spin, txtSTT.Spin, txtPV.Spin

    e.Handled = True

  End Sub

End Class