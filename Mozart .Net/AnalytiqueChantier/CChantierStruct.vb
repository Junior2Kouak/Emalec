Imports System.Data.SqlClient
Imports MozartLib


'*******************************************************************************************
'Contient les valeurs analyse chantier colonne !??????????
'********************************************************************************************
Public Structure StructChantierRealise

  Dim MOP As Int32
  Dim HRTECH As Int32
  Dim CTTECH As Int32
  Dim INTERIM As Int32
  Dim MOA As Int32
  Dim MOA_BE As Int32

  Dim HRASS As Int32
  Dim CTASS As Int32
  Dim HRCHAFF As Int32
  Dim CTCHAFF As Int32
  Dim HRBE As Int32
  Dim CTBE As Int32
  Dim NBREPAS As Int32
  Dim CTREPAS As Int32
  Dim NBGD As Int32
  Dim CTGD As Int32
  Dim NBKM As Int32
  Dim CTKM As Int32
  Dim NB_DEPLACE As Decimal
  Dim CT_DEPLACE As Int32
  Dim CTFRAIS As Int32
  Dim FRAIS As Int32
  Dim CTCDE As Int32
  Dim CTSS As Int32
  Dim FO As Int32
  Dim CTCS As Int32

  Dim HRTECH_MECA As Int32
  Dim CTTECH_MECA As Int32
  Dim HRTECH_CABL As Int32
  Dim CTTECH_CABL As Int32
  Dim HRTECH_AIDETEC As Int32
  Dim CTTECH_AIDETEC As Int32

  Dim HRBE_AUTO As Int32
  Dim CTBE_AUTO As Int32
  Dim HRBE_ELEC As Int32
  Dim CTBE_ELEC As Int32
  Dim HRBE_MECA As Int32
  Dim CTBE_MECA As Int32

  '*******************************************************************************************
  'Contient les valeurs analyse chantier colonne !??????????
  '********************************************************************************************
  Public Sub New(ByVal cIdChantier As Int32, ByVal p_NomSociete As String)

    Try

      Dim cmd As New SqlCommand("api_sp_ChantierSyntheseRealisation", MozartDatabase.cnxMozart) With {
        .CommandType = CommandType.StoredProcedure
      }
      cmd.Parameters.Add("@iD", SqlDbType.Int)
      cmd.Parameters("@iD").Value = cIdChantier
      cmd.Parameters.Add("@societe", SqlDbType.VarChar)
      cmd.Parameters("@societe").Value = p_NomSociete


      Dim dr As SqlDataReader = cmd.ExecuteReader

      If dr.HasRows = True Then

        dr.Read()

        MOP = dr("MOP")
        HRTECH = dr("HRTECH")
        CTTECH = dr("CTTECH")

        HRTECH_MECA = dr("HRTECH_MECA")
        CTTECH_MECA = dr("CTTECH_MECA")
        HRTECH_CABL = dr("HRTECH_CABL")
        CTTECH_CABL = dr("CTTECH_CABL")
        HRTECH_AIDETEC = dr("HRTECH_AIDETEC")
        CTTECH_AIDETEC = dr("CTTECH_AIDETEC")

        INTERIM = dr("INTERIM")
        MOA = dr("MOA")
        MOA_BE = dr("MOA_BE")

        HRASS = dr("HRASS")
        CTASS = dr("CTASS")
        HRCHAFF = dr("HRCHAFF")
        CTCHAFF = dr("CTCHAFF")
        HRBE = dr("HRBE")
        CTBE = dr("CTBE")

        HRBE_AUTO = dr("HRBE_AUTO")
        CTBE_AUTO = dr("CTBE_AUTO")
        HRBE_ELEC = dr("HRBE_ELEC")
        CTBE_ELEC = dr("CTBE_ELEC")
        HRBE_MECA = dr("HRBE_MECA")
        CTBE_MECA = dr("CTBE_MECA")

        NBREPAS = dr("NBREPAS")
        CTREPAS = dr("CTREPAS")
        NBGD = dr("NBGD")
        CTGD = dr("CTGD")
        NBKM = dr("NBKM")
        CTKM = dr("CTKM")
        CTFRAIS = dr("CTFRAIS")
        FRAIS = dr("FRAIS")
        CTCDE = dr("CTCDE")
        CTSS = dr("CTSS")
        FO = dr("FO")
        CTCS = dr("CTCS")

        NB_DEPLACE = dr("NB_HR_DEPLACE")
        CT_DEPLACE = dr("MTT_HR_DEPLACE")

      End If
      dr.Close()

    Catch ex As Exception

      MessageBox.Show("Erreur dans Constructeur Realise : " & ex.Message)

    End Try

  End Sub

End Structure

'*******************************************************************************************
'Contient les valeurs analyse chantier colonne !??????????
'********************************************************************************************
Public Structure StructChantier_A_Realise

  Dim MO As Integer

  Dim MO_BAT As Int32
  Dim MO_MECA As Int32
  Dim MO_CABL As Int32
  Dim MO_AIDETEC As Int32


  Dim NMOASS As Integer
  Dim NMOCHAF As Integer
  Dim NMOBE As Integer

  Dim NMOBE_BAT As Int32
  Dim NMOBE_AUTO As Int32
  Dim NMOBE_ELEC As Int32
  Dim NMOBE_MECA As Int32

  Dim PAN As Integer
  Dim NGD As Integer
  Dim NKM As Integer

  Dim HR_DEPLACE As Decimal

  Dim NPC_AVANCE As Decimal

  Dim NDIVERS As Integer
  Dim FO As Integer
  Dim STT As Integer
  Dim DDATMOD As String

  Public Sub New(ByVal cIdChantier As Integer)

    Try

      Dim cmd As New SqlCommand("api_sp_ChantierSyntheseResteARea2", MozartDatabase.cnxMozart) With {
        .CommandType = CommandType.StoredProcedure
      }
      cmd.Parameters.Add("@iD", SqlDbType.Int)
      cmd.Parameters("@iD").Value = cIdChantier

      Dim dr As SqlDataReader = cmd.ExecuteReader

      If dr.HasRows Then

        dr.Read()

        MO = dr("MO")

        MO_MECA = dr("MO_MECA")
        MO_CABL = dr("MO_CABL")
        MO_AIDETEC = dr("MO_AIDETEC")

        NMOASS = dr("NMOASS")
        NMOCHAF = dr("NMOCHAF")
        NMOBE = dr("NMOBE")
        PAN = (dr("MO") \ 8)
        NGD = dr("NGD")
        NKM = dr("NKM")
        NDIVERS = dr("NDIVERS")
        FO = dr("FO")
        STT = dr("STT")
        DDATMOD = dr("DDATMOD")

        NMOBE_AUTO = dr("NMOBE_AUTO")
        NMOBE_ELEC = dr("NMOBE_ELEC")
        NMOBE_MECA = dr("NMOBE_MECA")

        HR_DEPLACE = dr("NHR_DEPLACE")

        NPC_AVANCE = dr("NPC_AVANCE")
      End If
      dr.Close()

    Catch ex As Exception

      MessageBox.Show("Erreur dans Constructeur StructChantier_A_Realise : " & ex.Message)

    End Try

  End Sub

End Structure

'*******************************************************************************************
'Contient les valeurs analyse chantier colonne !??????????
'********************************************************************************************
Public Structure StructSyntheseChantier

  Dim DEBOURSE As Integer
  Dim FRAISGENE As Integer
  Dim PVENTE As Integer
  Dim MARGE As Integer
  Dim PMARGE As Integer

  Public Sub New(ByVal cIdChantier As Integer, ByVal bReadOnly As Boolean)
    Dim sActif As String

    Try
      If bReadOnly Then
        sActif = "N"
      Else
        sActif = "O"
      End If

      Dim cmd As New SqlCommand("api_sp_ChantierSyntheseChantier", MozartDatabase.cnxMozart) With {
        .CommandType = CommandType.StoredProcedure
      }
      cmd.Parameters.Add("@iD", SqlDbType.Int).Value = cIdChantier
      cmd.Parameters.Add("@p_cchifactif", SqlDbType.Char).Value = sActif

      Dim dr As SqlDataReader = cmd.ExecuteReader

      If dr.HasRows Then

        dr.Read()

        DEBOURSE = dr("DEBOURSE")
        FRAISGENE = dr("FRAISGENE")
        PVENTE = dr("PVENTE")
        MARGE = dr("MARGE")

        PMARGE = ((MARGE * 100) / PVENTE)

      End If
      dr.Close()

    Catch ex As Exception

      MessageBox.Show("Erreur dans Constructeur StructSyntheseChantier : " & ex.Message)

    End Try
  End Sub

End Structure

'*******************************************************************************************
'Contient les valeurs analyse chantier colonne !??????????
'********************************************************************************************
Public Structure StructSyntheseChantierDetails

  Dim Libelle As String
  Dim NMO As Integer

  Dim NMO_MECA As Int32
  Dim NMO_CABL As Int32
  Dim NMO_AIDETEC As Int32

  Dim ASS As Integer
  Dim CHAFF As Integer
  Dim BE As Integer

  Dim BE_AUTO As Int32
  Dim BE_ELEC As Int32
  Dim BE_MECA As Int32

  Dim PA As Integer
  Dim GD As Integer
  Dim KM As Integer
  Dim KMMTT As Integer
  Dim HrDeplace As Decimal
  Dim DIV As Integer
  Dim NFO As Integer
  Dim STT As Integer
  Dim PROR As Integer
  Dim GAR As Integer
  Dim CPRORATA As String
  Dim NPRORATA As Decimal

  Public Sub New(ByVal cIdChantier As Integer, ByVal c_Archives As Boolean)

    Try

      Dim cmd As New SqlCommand("api_sp_ChantierSyntheseChantierDetails", MozartDatabase.cnxMozart) With {
        .CommandType = CommandType.StoredProcedure
      }
      cmd.Parameters.Add("@iD", SqlDbType.Int)
      cmd.Parameters("@iD").Value = cIdChantier
      cmd.Parameters.Add("@p_cArch", SqlDbType.Char)
      cmd.Parameters("@p_cArch").Value = If(c_Archives = True, "N", "O")

      Dim dr As SqlDataReader = cmd.ExecuteReader

      If dr.HasRows Then

        dr.Read()
        Libelle = dr("LIB")
        NMO = dr("NMO")

        NMO_MECA = dr("NMO_MECA")
        NMO_CABL = dr("NMO_CABL")
        NMO_AIDETEC = dr("NMO_AIDETEC")


        ASS = dr("ASS")
        CHAFF = dr("CHAFF")
        BE = dr("BE")

        BE_AUTO = dr("NMOBE_AUTO")
        BE_ELEC = dr("NMOBE_ELEC")
        BE_MECA = dr("NMOBE_MECA")

        PA = dr("PA")
        GD = dr("GD")
        KM = dr("KM")
        KMMTT = dr("NKMSMTT")
        HrDeplace = dr("NFRAIS_DEPLACE")
        DIV = dr("DIV")
        NFO = dr("NFO")
        STT = dr("STT")
        PROR = dr("PROR")
        GAR = dr("GAR")
        CPRORATA = dr("CPRORATA")
        NPRORATA = dr("NPCPRORATA")

      End If
      dr.Close()

    Catch ex As Exception

      MessageBox.Show("Erreur dans Constructeur StructSyntheseChantier : " & ex.Message)

    End Try

  End Sub

End Structure

'*******************************************************************************************
'Contient les valeurs analyse chantier colonne !??????????
'********************************************************************************************
Public Structure StructChantierCalculTotal

  Dim TMOP As Integer
  Dim TOUV As Integer
  Dim TMOUV As Integer

  Dim TOUV_MECA As Int32
  Dim TMOUV_MECA As Int32
  Dim TOUV_CABL As Int32
  Dim TMOUV_CABL As Int32
  Dim TOUV_AIDETEC As Int32
  Dim TMOUV_AIDETEC As Int32

  Dim TMINT As Int32
  Dim TMOA As Int32
  Dim TMOA_BE As Int32
  Dim TASS As Int32
  Dim TMASS As Int32
  Dim TCHAF As Int32
  Dim TMCHAF As Int32
  Dim TBE As Int32
  Dim TMBE As Int32

  Dim TBE_AUTO As Int32
  Dim TMBE_AUTO As Int32
  Dim TBE_ELEC As Int32
  Dim TMBE_ELEC As Int32
  Dim TBE_MECA As Int32
  Dim TMBE_MECA As Int32

  Dim TFRAIS As Integer
  Dim TPAN As Integer
  Dim TMPAN As Integer
  Dim TGD As Integer
  Dim TMGD As Integer
  Dim TKM As Integer
  Dim TMKM As Integer
  Dim TMDIVERS As Integer
  Dim TFO As Integer
  Dim TSTT As Integer

  Dim T_HR_DEPLACE As Decimal
  Dim TM_HR_DEPLACE As Integer

  Public Sub New(ByRef oChantierRealise As StructChantierRealise, ByRef oChantierCalculRealisation As StructChantierCalculRealisation, ByRef oChantier_A_Realise As StructChantier_A_Realise)

    Try

      TMOP = oChantierRealise.MOP + oChantierCalculRealisation.RMOP
      TOUV = oChantierRealise.HRTECH + oChantier_A_Realise.MO
      TMOUV = oChantierRealise.CTTECH + oChantierCalculRealisation.RMOUV
      TMINT = oChantierRealise.INTERIM

      TOUV_MECA = oChantierRealise.HRTECH_MECA + oChantier_A_Realise.MO_MECA
      TMOUV_MECA = oChantierRealise.CTTECH_MECA + oChantierCalculRealisation.RMOUV_MECA

      TOUV_CABL = oChantierRealise.HRTECH_CABL + oChantier_A_Realise.MO_CABL
      TMOUV_CABL = oChantierRealise.CTTECH_CABL + oChantierCalculRealisation.RMOUV_CABL

      TOUV_AIDETEC = oChantierRealise.HRTECH_AIDETEC + oChantier_A_Realise.MO_AIDETEC
      TMOUV_AIDETEC = oChantierRealise.CTTECH_AIDETEC + oChantierCalculRealisation.RMOUV_AIDETEC

      TMOA = oChantierRealise.MOA + oChantierCalculRealisation.RMOA

      TMOA_BE = oChantierRealise.MOA_BE + oChantierCalculRealisation.RMOA_BE

      TASS = oChantierRealise.HRASS + oChantier_A_Realise.NMOASS
      TMASS = oChantierRealise.CTASS + oChantierCalculRealisation.RMASS
      TCHAF = oChantierRealise.HRCHAFF + oChantier_A_Realise.NMOCHAF
      TMCHAF = oChantierRealise.CTCHAFF + oChantierCalculRealisation.RMCHAF
      TBE = oChantierRealise.HRBE + oChantier_A_Realise.NMOBE
      TMBE = oChantierRealise.CTBE + oChantierCalculRealisation.RMBE

      TBE_AUTO = oChantierRealise.HRBE_AUTO + oChantier_A_Realise.NMOBE_AUTO
      TMBE_AUTO = oChantierRealise.CTBE_AUTO + oChantierCalculRealisation.RMBE_AUTO
      TBE_ELEC = oChantierRealise.HRBE_ELEC + oChantier_A_Realise.NMOBE_ELEC
      TMBE_ELEC = oChantierRealise.CTBE_ELEC + oChantierCalculRealisation.RMBE_ELEC
      TBE_MECA = oChantierRealise.HRBE_MECA + oChantier_A_Realise.NMOBE_MECA
      TMBE_MECA = oChantierRealise.CTBE_MECA + oChantierCalculRealisation.RMBE_MECA

      TFRAIS = oChantierRealise.FRAIS + oChantierCalculRealisation.RFRAIS
      TPAN = oChantierRealise.NBREPAS + oChantier_A_Realise.PAN
      TMPAN = oChantierRealise.CTREPAS + oChantierCalculRealisation.RMPAN
      TGD = oChantierRealise.NBGD + oChantier_A_Realise.NGD
      TMGD = oChantierRealise.CTGD + oChantierCalculRealisation.RMGD
      TKM = oChantierRealise.NBKM + oChantier_A_Realise.NKM
      TMKM = oChantierRealise.CTKM + oChantierCalculRealisation.RMKM
      TMDIVERS = oChantierRealise.CTFRAIS + oChantier_A_Realise.NDIVERS

      T_HR_DEPLACE = oChantierRealise.NB_DEPLACE + oChantier_A_Realise.HR_DEPLACE
      TM_HR_DEPLACE = oChantierRealise.CT_DEPLACE + oChantierCalculRealisation.RM_HR_DEPLACE

      TFO = oChantierRealise.FO + oChantier_A_Realise.FO
      TSTT = oChantierRealise.CTCS + oChantier_A_Realise.STT

    Catch ex As Exception

      MessageBox.Show("Erreur dans Constructeur StructChantierCalculRealisation : " & ex.Message)

    End Try

  End Sub

End Structure

'*******************************************************************************************
'Contient les valeurs analyse chantier colonne !??????????
'********************************************************************************************
Public Structure StructChantierCalculRealisation

  Dim RMOP As Int32
  Dim RMOUV As Int32

  Dim RMOUV_MECA As Int32
  Dim RMOUV_CABL As Int32
  Dim RMOUV_AIDETEC As Int32

  Dim RMASS As Int32
  Dim RMCHAF As Int32
  Dim RMBE As Int32

  Dim RMBE_AUTO As Int32
  Dim RMBE_ELEC As Int32
  Dim RMBE_MECA As Int32

  Dim RMOA As Int32
  Dim RMOA_BE As Int32

  Dim RMPAN As Int32
  Dim RMGD As Int32
  Dim RMKM As Int32
  Dim RFRAIS As Int32

  Dim RM_HR_DEPLACE As Int32

  Public Sub New(ByRef oChantier_A_Realise As StructChantier_A_Realise)

    Try

      RMOUV = oChantier_A_Realise.MO * TxMOOuv
      RMOUV_MECA = oChantier_A_Realise.MO_MECA * TxMO_Meca
      RMOUV_CABL = oChantier_A_Realise.MO_CABL * TxMO_Cabl
      RMOUV_AIDETEC = oChantier_A_Realise.MO_AIDETEC * TxMO_AideTec

      RMOP = RMOUV + RMOUV_MECA + RMOUV_CABL + RMOUV_AIDETEC

      RMASS = oChantier_A_Realise.NMOASS * TxMOAss
      RMCHAF = oChantier_A_Realise.NMOCHAF * TxMOChaf
      RMBE = oChantier_A_Realise.NMOBE * TxMOBE

      RMBE_AUTO = oChantier_A_Realise.NMOBE_AUTO * TxMOBE_Auto
      RMBE_ELEC = oChantier_A_Realise.NMOBE_ELEC * TxMOBE_Elec
      RMBE_MECA = oChantier_A_Realise.NMOBE_MECA * TxMOBE_Meca

      RMOA = RMASS + RMCHAF
      RMOA_BE = RMBE + RMBE_AUTO + RMBE_ELEC + RMBE_MECA

      RMPAN = oChantier_A_Realise.PAN * TxPanier
      RMGD = oChantier_A_Realise.NGD * TxGD
      RMKM = oChantier_A_Realise.NKM * TxKM

      RM_HR_DEPLACE = oChantier_A_Realise.HR_DEPLACE * TxDeplace

      RFRAIS = RMPAN + RMGD + RMKM + RM_HR_DEPLACE + oChantier_A_Realise.NDIVERS

    Catch ex As Exception

      MessageBox.Show("Erreur dans Constructeur StructChantierCalculRealisation : " & ex.Message)

    End Try

  End Sub

End Structure

'*******************************************************************************************
'Contient les valeurs analyse chantier colonne !??????????
'********************************************************************************************
Public Structure StructChantierAnaMARGE

  'quantité
  Dim ANAQOUV As Int32

  Dim ANAQOUV_MECA As Int32
  Dim ANAQOUV_CABL As Int32
  Dim ANAQOUV_AIDETEC As Int32

  Dim ANAQASS As Int32
  Dim ANAQCHAF As Int32
  Dim ANAQBE As Int32

  Dim ANAQBE_AUTO As Int32
  Dim ANAQBE_ELEC As Int32
  Dim ANAQBE_MECA As Int32

  Dim ANAQPAN As Int32
  Dim ANAQGD As Int32
  Dim ANAQKM As Int32
  'montant
  Dim ANAMOUV As Int32

  Dim ANAMOUV_MECA As Int32
  Dim ANAMOUV_CABL As Int32
  Dim ANAMOUV_AIDETEC As Int32

  Dim ANAMINT As Int32
  Dim ANAMMOP As Int32
  Dim ANAMASS As Int32
  Dim ANAMCHAF As Int32
  Dim ANAMBE As Int32

  Dim ANAMBE_AUTO As Int32
  Dim ANAMBE_ELEC As Int32
  Dim ANAMBE_MECA As Int32

  Dim ANAMMOA As Int32
  Dim ANAMMOA_BE As Int32
  Dim ANAMPAN As Int32
  Dim ANAMGD As Int32
  Dim ANAMKM As Int32
  Dim ANAMFRAIS As Int32
  Dim ANAMFO As Int32
  Dim ANAMSTT As Int32

  Dim ANAQ_HR_DEPLACE As Decimal
  Dim ANAM_HR_DEPLACE As Int32
  Dim ANAP_HR_DEPLACE As Int32

  'ANA MARGE POURC
  Dim ANAPMOP As Int32
  Dim ANAPOUV As Int32

  Dim ANAPOUV_MECA As Int32
  Dim ANAPOUV_CABL As Int32
  Dim ANAPOUV_AIDETEC As Int32

  Dim ANAPMOA As Int32
  Dim ANAPMOA_BE As Int32
  Dim ANAPASS As Int32
  Dim ANAPCHAF As Int32
  Dim ANAPBE As Int32

  Dim ANAPBE_AUTO As Int32
  Dim ANAPBE_ELEC As Int32
  Dim ANAPBE_MECA As Int32

  Dim ANAPFRAIS As Int32
  Dim ANAPPAN As Int32
  Dim ANAPGD As Int32
  Dim ANAPKM As Int32
  Dim ANAPFO As Int32
  Dim ANAPSTT As Int32

  Public Sub New(ByRef oChantierCalculTotal As StructChantierCalculTotal, ByRef oChantierSyntheseDetails As StructSyntheseChantierDetails)

    Try

      'Analyse quantitée
      ANAQOUV = (oChantierCalculTotal.TOUV - oChantierSyntheseDetails.NMO)

      ANAQOUV_MECA = (oChantierCalculTotal.TOUV_MECA - oChantierSyntheseDetails.NMO_MECA)
      ANAQOUV_CABL = (oChantierCalculTotal.TOUV_CABL - oChantierSyntheseDetails.NMO_CABL)
      ANAQOUV_AIDETEC = (oChantierCalculTotal.TOUV_AIDETEC - oChantierSyntheseDetails.NMO_AIDETEC)

      ANAQASS = (oChantierCalculTotal.TASS - oChantierSyntheseDetails.ASS)
      ANAQCHAF = (oChantierCalculTotal.TCHAF - oChantierSyntheseDetails.CHAFF)
      ANAQBE = (oChantierCalculTotal.TBE - oChantierSyntheseDetails.BE)

      ANAQBE_AUTO = (oChantierCalculTotal.TBE_AUTO - oChantierSyntheseDetails.BE_AUTO)
      ANAQBE_ELEC = (oChantierCalculTotal.TBE_ELEC - oChantierSyntheseDetails.BE_ELEC)
      ANAQBE_MECA = (oChantierCalculTotal.TBE_MECA - oChantierSyntheseDetails.BE_MECA)

      ANAQPAN = (oChantierCalculTotal.TPAN - oChantierSyntheseDetails.PA)
      ANAQGD = (oChantierCalculTotal.TGD - oChantierSyntheseDetails.GD)
      ANAQKM = (oChantierCalculTotal.TKM - oChantierSyntheseDetails.KM)

      ANAQ_HR_DEPLACE = (oChantierCalculTotal.T_HR_DEPLACE - oChantierSyntheseDetails.HrDeplace)

      'Analyse MARGE montant
      ANAMOUV = (oChantierSyntheseDetails.NMO * TxMOOuv) - oChantierCalculTotal.TMOUV

      ANAMOUV_MECA = (oChantierSyntheseDetails.NMO_MECA * TxMO_Meca) - oChantierCalculTotal.TMOUV_MECA
      ANAMOUV_CABL = (oChantierSyntheseDetails.NMO_CABL * TxMO_Cabl) - oChantierCalculTotal.TMOUV_CABL
      ANAMOUV_AIDETEC = (oChantierSyntheseDetails.NMO_AIDETEC * TxMO_AideTec) - oChantierCalculTotal.TMOUV_AIDETEC

      ANAMINT = -oChantierCalculTotal.TMINT

      ANAMMOP = ANAMOUV + ANAMINT + ANAMOUV_MECA + ANAMOUV_CABL + ANAMOUV_AIDETEC

      ANAMASS = (oChantierSyntheseDetails.ASS * TxMOAss) - oChantierCalculTotal.TMASS
      ANAMCHAF = (oChantierSyntheseDetails.CHAFF * TxMOChaf) - oChantierCalculTotal.TMCHAF
      ANAMBE = (oChantierSyntheseDetails.BE * TxMOBE) - oChantierCalculTotal.TMBE

      ANAMBE_AUTO = (oChantierSyntheseDetails.BE_AUTO * TxMOBE_Auto) - oChantierCalculTotal.TMBE_AUTO
      ANAMBE_ELEC = (oChantierSyntheseDetails.BE_ELEC * TxMOBE_Elec) - oChantierCalculTotal.TMBE_ELEC
      ANAMBE_MECA = (oChantierSyntheseDetails.BE_MECA * TxMOBE_Meca) - oChantierCalculTotal.TMBE_MECA

      ANAMMOA = ANAMASS + ANAMCHAF
      ANAMMOA_BE = ANAMBE + ANAMBE_AUTO + ANAMBE_ELEC + ANAMBE_MECA

      ANAMPAN = (oChantierSyntheseDetails.PA * TxPanier) - oChantierCalculTotal.TMPAN
      ANAMGD = (oChantierSyntheseDetails.GD * TxGD) - oChantierCalculTotal.TMGD
      ANAMKM = (oChantierSyntheseDetails.KM * TxKM) - oChantierCalculTotal.TMKM
      ANAM_HR_DEPLACE = ((oChantierSyntheseDetails.HrDeplace * TxDeplace) - oChantierCalculTotal.TM_HR_DEPLACE)
      ANAMFRAIS = ANAMPAN + ANAMGD + ANAMKM + ANAM_HR_DEPLACE
      ANAMFO = oChantierSyntheseDetails.NFO - oChantierCalculTotal.TFO
      ANAMSTT = oChantierSyntheseDetails.STT - oChantierCalculTotal.TSTT



      If ((oChantierSyntheseDetails.NMO * TxMOOuv) + (oChantierSyntheseDetails.NMO_MECA * TxMO_Meca) + (oChantierSyntheseDetails.NMO_CABL * TxMO_Cabl) + (oChantierSyntheseDetails.NMO_AIDETEC * TxMO_AideTec)) <> 0 Then
        ANAPMOP = (ANAMMOP * 100) / ((oChantierSyntheseDetails.NMO * TxMOOuv) + (oChantierSyntheseDetails.NMO_MECA * TxMO_Meca) + (oChantierSyntheseDetails.NMO_CABL * TxMO_Cabl) + (oChantierSyntheseDetails.NMO_AIDETEC * TxMO_AideTec))
      Else
        ANAPMOP = 0
      End If

      If (oChantierSyntheseDetails.NMO * TxMOOuv) <> 0 Then
        ANAPOUV = (ANAMOUV * 100) / (oChantierSyntheseDetails.NMO * TxMOOuv)
      Else
        ANAPOUV = 0
      End If

      If (oChantierSyntheseDetails.NMO_MECA * TxMO_Meca) <> 0 Then
        ANAPOUV_MECA = (ANAMOUV_MECA * 100) / (oChantierSyntheseDetails.NMO_MECA * TxMO_Meca)
      Else
        ANAPOUV_MECA = 0
      End If

      If (oChantierSyntheseDetails.NMO_CABL * TxMO_Cabl) <> 0 Then
        ANAPOUV_CABL = (ANAMOUV_CABL * 100) / (oChantierSyntheseDetails.NMO_CABL * TxMO_Cabl)
      Else
        ANAPOUV_CABL = 0
      End If

      If (oChantierSyntheseDetails.NMO_AIDETEC * TxMO_AideTec) <> 0 Then
        ANAPOUV_AIDETEC = (ANAMOUV_AIDETEC * 100) / (oChantierSyntheseDetails.NMO_AIDETEC * TxMO_AideTec)
      Else
        ANAPOUV_AIDETEC = 0
      End If

      If ((oChantierSyntheseDetails.ASS * TxMOAss) + (oChantierSyntheseDetails.CHAFF * TxMOChaf)) <> 0 Then
        ANAPMOA = (ANAMMOA * 100) / ((oChantierSyntheseDetails.ASS * TxMOAss) + (oChantierSyntheseDetails.CHAFF * TxMOChaf))
      Else
        ANAPMOA = 0
      End If

      If ((oChantierSyntheseDetails.BE * TxMOBE) + (oChantierSyntheseDetails.BE_AUTO * TxMOBE_Auto) + (oChantierSyntheseDetails.BE_ELEC * TxMOBE_Elec) + (oChantierSyntheseDetails.BE_MECA * TxMOBE_Meca)) <> 0 Then
        ANAPMOA_BE = (ANAMMOA_BE * 100) / ((oChantierSyntheseDetails.BE * TxMOBE) + (oChantierSyntheseDetails.BE_AUTO * TxMOBE_Auto) + (oChantierSyntheseDetails.BE_ELEC * TxMOBE_Elec) + (oChantierSyntheseDetails.BE_MECA * TxMOBE_Meca))
      Else
        ANAPMOA_BE = 0
      End If

      If (oChantierSyntheseDetails.ASS * TxMOAss) <> 0 Then
        ANAPASS = (ANAMASS * 100) / (oChantierSyntheseDetails.ASS * TxMOAss)
      Else
        ANAPASS = 0
      End If
      If (oChantierSyntheseDetails.CHAFF * TxMOChaf) <> 0 Then
        ANAPCHAF = CLng(ANAMCHAF * 100) / (oChantierSyntheseDetails.CHAFF * TxMOChaf)
      Else
        ANAPCHAF = 0
      End If
      If (oChantierSyntheseDetails.BE * TxMOBE) <> 0 Then
        ANAPBE = (ANAMBE * 100) / (oChantierSyntheseDetails.BE * TxMOBE)
      Else
        ANAPBE = 0
      End If

      If (oChantierSyntheseDetails.BE_AUTO * TxMOBE_Auto) <> 0 Then
        ANAPBE_AUTO = (ANAMBE_AUTO * 100) / (oChantierSyntheseDetails.BE_AUTO * TxMOBE_Auto)
      Else
        ANAPBE_AUTO = 0
      End If
      If (oChantierSyntheseDetails.BE_ELEC * TxMOBE_Elec) <> 0 Then
        ANAPBE_ELEC = (ANAMBE_ELEC * 100) / (oChantierSyntheseDetails.BE_ELEC * TxMOBE_Elec)
      Else
        ANAPBE_ELEC = 0
      End If
      If (oChantierSyntheseDetails.BE_MECA * TxMOBE_Meca) <> 0 Then
        ANAPBE_MECA = (ANAMBE_MECA * 100) / (oChantierSyntheseDetails.BE_MECA * TxMOBE_Meca)
      Else
        ANAPBE_MECA = 0
      End If

      If (oChantierSyntheseDetails.PA * TxPanier) + (oChantierSyntheseDetails.GD * TxGD) + (oChantierSyntheseDetails.KM * TxKM) + (oChantierSyntheseDetails.HrDeplace * TxDeplace) <> 0 Then
        ANAPFRAIS = CLng(ANAMFRAIS * 100) / ((oChantierSyntheseDetails.PA * TxPanier) + (oChantierSyntheseDetails.GD * TxGD) + (oChantierSyntheseDetails.KM * TxKM) + (oChantierSyntheseDetails.HrDeplace * TxDeplace))
      Else
        ANAPFRAIS = 0
      End If
      If (oChantierSyntheseDetails.PA * TxPanier) <> 0 Then
        ANAPPAN = (ANAMPAN * 100) / (oChantierSyntheseDetails.PA * TxPanier)
      Else
        ANAPPAN = 0
      End If
      If (oChantierSyntheseDetails.GD * TxGD) <> 0 Then
        ANAPGD = (ANAMGD * 100) / (oChantierSyntheseDetails.GD * TxGD)
      Else
        ANAPGD = 0
      End If
      If (oChantierSyntheseDetails.KM * TxKM) <> 0 Then
        ANAPKM = (ANAMKM * 100) / (oChantierSyntheseDetails.KM * TxKM)
      Else
        ANAPKM = 0
      End If
      If (oChantierSyntheseDetails.NFO) <> 0 Then
        ANAPFO = (ANAMFO * 100) / (oChantierSyntheseDetails.NFO)
      Else
        ANAPFO = 0
      End If
      If (oChantierSyntheseDetails.STT) <> 0 Then
        ANAPSTT = (ANAMSTT * 100) / (oChantierSyntheseDetails.STT)
      Else
        ANAPSTT = 0
      End If
      If (oChantierSyntheseDetails.HrDeplace * TxDeplace) <> 0 Then
        ANAP_HR_DEPLACE = (ANAM_HR_DEPLACE * 100) / (oChantierSyntheseDetails.HrDeplace * TxDeplace)
      Else
        ANAP_HR_DEPLACE = 0
      End If


    Catch ex As Exception

      MessageBox.Show("Erreur dans Constructeur StructChantierAnaMARGE : " & ex.Message)

    End Try

  End Sub

End Structure


'*******************************************************************************************
'Contient les valeurs analyse chantier colonne !??????????
'********************************************************************************************
Public Structure StructChantierSyntheseAna

  Dim iSynthAnaFAc As Int32
  Dim PRO As Int32
  Dim GAR As Int32
  Dim RMPRO As Int32
  Dim RMGAR As Int32
  Dim RES As Int32
  Dim RMRES As Int32
  Dim SYFACP As Int32
  Dim SYTHP As Double
  Dim SYTH As Int32
  Dim SYEN As Int32
  Dim SYENP As Int32

  Dim TOT_PRO As Int32
  Dim TOT_ANA_PRO As Int32
  Dim TOT_P_ANA_PRO As Int32
  Dim TOT_GAR As Int32
  Dim TOT_ANA_GAR As Int32
  Dim TOT_P_ANA_GAR As Int32

  Public Sub New(ByRef cIdChantier As Integer, ByRef oChantierSyntheseRea As StructChantierSyntheseRea,
                 ByRef oChantierSyntheseDetails As StructSyntheseChantierDetails, ByRef oChantierSynthese As StructSyntheseChantier,
                 ByRef oChantierRealise As StructChantierRealise, ByRef oChantierCalculRealisation As StructChantierCalculRealisation,
                 ByRef oChantier_A_Realise As StructChantier_A_Realise)

    Try

      Dim cmd As New SqlCommand("api_sp_ChantierSyntheseAnaChantier", MozartDatabase.cnxMozart) With {
        .CommandType = CommandType.StoredProcedure
      }
      cmd.Parameters.Add("@iD", SqlDbType.Int)
      cmd.Parameters("@iD").Value = cIdChantier

      Dim dr As SqlDataReader = cmd.ExecuteReader

      If dr.HasRows = True Then

        dr.Read()

        iSynthAnaFAc = dr(0)

      End If
      dr.Close()

      'modif du 06/04/2016 : vu avec pierre.
      'a présent, le prorata est calculé en fonction de la fiche libelle Compte prorata CS et CF
      ' et plus sur le taux du compte prorata


      cmd = New SqlCommand("api_sp_ChantierReturnMontantEngageProrata", MozartDatabase.cnxMozart) With {
        .CommandType = CommandType.StoredProcedure
      }
      cmd.Parameters.Add("@iDChantier", SqlDbType.Int).Value = cIdChantier

      dr = cmd.ExecuteReader

      If dr.HasRows Then
        dr.Read()

        PRO = dr(0)
      End If
      dr.Close()

      SYFACP = (iSynthAnaFAc * 100) / oChantierSynthese.PVENTE

      GAR = iSynthAnaFAc * 0.01
      RMPRO = ((100 - SYFACP) / 100) * oChantierSyntheseDetails.PROR

      RMGAR = oChantierSyntheseDetails.GAR - GAR

      RES = oChantierRealise.MOP + oChantierRealise.MOA + oChantierRealise.MOA_BE + oChantierRealise.FRAIS + oChantierRealise.FO + oChantierRealise.CTCS + PRO + GAR
      RMRES = oChantierCalculRealisation.RMOP + oChantierCalculRealisation.RMOA + oChantierCalculRealisation.RMOA_BE + oChantierCalculRealisation.RFRAIS + oChantier_A_Realise.FO + oChantier_A_Realise.STT + RMPRO + RMGAR

      'If oChantierSyntheseRea.srTOT > 0 Then
      '  SYTHP = ((RES * 100) / oChantierSyntheseRea.srTOT)
      'Else
      '  SYTHP = 0
      'End If
      SYTHP = oChantier_A_Realise.NPC_AVANCE

      SYTH = (oChantierSynthese.PVENTE * SYTHP / 100)

      SYEN = (SYTH - iSynthAnaFAc)
      SYENP = (SYEN * 100) / oChantierSynthese.PVENTE

      TOT_PRO = PRO + RMPRO
      TOT_ANA_PRO = oChantierSyntheseDetails.PROR - (PRO + RMPRO)
      TOT_P_ANA_PRO = If(oChantierSyntheseDetails.PROR = 0, 0, (((oChantierSyntheseDetails.PROR - (PRO + RMPRO)) / oChantierSyntheseDetails.PROR) * 100))
      TOT_GAR = GAR + RMGAR
      TOT_ANA_GAR = oChantierSyntheseDetails.GAR - (GAR + RMGAR)
      TOT_P_ANA_GAR = If(oChantierSyntheseDetails.GAR = 0, 0, (((oChantierSyntheseDetails.GAR - (GAR + RMGAR)) / oChantierSyntheseDetails.GAR) * 100))

    Catch ex As Exception
      MessageBox.Show("Erreur dans Constructeur StructChantierSyntheseAna : " & ex.Message)
    End Try

  End Sub

End Structure

'*******************************************************************************************
'Contient les valeurs analyse chantier colonne !??????????
'********************************************************************************************
Public Class StructChantierSyntheseRea

  Public srTOT As Integer
  Public srFG As Integer
  Public srPV As Integer
  Public srMN As Integer
  Public srPMN As Decimal

End Class


Public Class CActionsInError

  Dim _dtActions As DataTable

  Dim _NIDCHANTIER As Int32

  ReadOnly Property dtActions As DataTable
    Get
      Return _dtActions
    End Get
  End Property

  Public Sub New(ByVal c_NIDCHANTIER As Int32)

    _NIDCHANTIER = c_NIDCHANTIER

    LoadData()

  End Sub

  Private Sub LoadData()

    _dtActions = New DataTable

    Dim sqlcmd As New SqlCommand("[api_sp_ChantierVerifHeuresFiche_Realise]", MozartDatabase.cnxMozart) With {
      .CommandType = CommandType.StoredProcedure
    }
    sqlcmd.Parameters.Add("@nidchantier", SqlDbType.Int).Value = _NIDCHANTIER
    _dtActions.Load(sqlcmd.ExecuteReader())

  End Sub

End Class

