Imports System.Data.SqlClient
Imports MozartLib

'*********************************************************************************************************************************************
'Date création : 18/12/2013
'Date de dernière modification : 18/12/2013
'Auteur : MC
'Dernière personne ayant effectuee une modification : 
'Version : 1.0
'Description :
'Cette classe permet de charger les elements d'un chiffrage et pouvoir calculer sa propre synthese  dynamiquement
'*********************************************************************************************************************************************
Public Structure StructChantierChiffrage

  Dim NIDCHIFF As Int32
  Dim NIDCHANTIER As Int32
  Dim NCLINUM As Int32
  Dim NCHAFFNUM As Int32
  Dim VCHIFFLIB As String
  Dim DCHIFFDEB As String
  Dim NCHIFFPV As Int32
  Dim NCHIFFMOADMIN As Int32
  Dim NCHIFFMOASS As Int32
  Dim NCHIFFMOCHAFF As Int32
  Dim NCHIFFMOBE As Int32
  Dim NCHIFFPAN As Int32
  Dim NCHIFFGD As Int32
  Dim NCHIFFKM As Int32
  Dim NCHIFFFRAISANNEXE As Int32
  Dim NCHIFFFO As Int32
  Dim NCHIFFST As Int32
  Dim VCHIFFOBS As String
  Dim CPRORATA As String
  Dim NPCPRORATA As Decimal

  Dim NCHIFF_DEPLACE As Decimal

  Dim NTAUX_FG As Decimal

  Dim NCHIFFMOBE_AUTO As Int32
  Dim NCHIFFMOBE_ELEC As Int32
  Dim NCHIFFMOBE_MECA As Int32

  Dim NCHIFFMO_MECA As Int32
  Dim NCHIFFMO_CABL As Int32
  Dim NCHIFFMO_AIDETEC As Int32

  Public Sub New(ByVal c_nidchiff As Int32)

    Try

      Dim cmd As New SqlCommand("api_sp_ChantierDetailChif", MozartDatabase.cnxMozart)
      cmd.CommandType = CommandType.StoredProcedure
      cmd.Parameters.Add("@p_nIDChif", SqlDbType.Int)
      cmd.Parameters("@p_nIDChif").Value = c_nidchiff

      Dim dr As SqlDataReader = cmd.ExecuteReader

      If dr.HasRows = True Then

        dr.Read()
        NIDCHIFF = NIDCHIFF
        NIDCHANTIER = dr("NIDCHANTIER")
        NCLINUM = dr("NCLINUM")
        NCHAFFNUM = dr("NCHAFNUM")
        VCHIFFLIB = dr("VLIBCHIF")
        DCHIFFDEB = dr("DCHIFDAT")
        NCHIFFPV = dr("NPVHT")
        NCHIFFMOADMIN = dr("NMO")
        NCHIFFFO = dr("NFO")
        NCHIFFST = dr("NSTT")
        NCHIFFMOASS = dr("NMOASS")
        NCHIFFMOCHAFF = dr("NMOCHAF")
        NCHIFFMOBE = dr("NMOBE")
        NCHIFFPAN = dr("NFRAISPA")
        NCHIFFGD = dr("NFRAISGD")
        NCHIFFKM = dr("NFRAISKM")
        NCHIFFFRAISANNEXE = dr("NFRAISDIV")
        VCHIFFOBS = dr("VOBS")
        CPRORATA = dr("CPRORATA")
        NPCPRORATA = dr("NPCPRORATA")

        NCHIFFMOBE_AUTO = dr("NMOBE_AUTO")
        NCHIFFMOBE_ELEC = dr("NMOBE_ELEC")
        NCHIFFMOBE_MECA = dr("NMOBE_MECA")

        NCHIFFMO_MECA = dr("NMO_MECA")
        NCHIFFMO_CABL = dr("NMO_CABL")
        NCHIFFMO_AIDETEC = dr("NMO_AIDETEC")
        NCHIFF_DEPLACE = dr("NFRAIS_DEPLACE")

        NTAUX_FG = dr("TAUX_FG")
      Else

        NIDCHIFF = NIDCHIFF
        NIDCHANTIER = 0
        NCLINUM = 0
        NCHAFFNUM = 0
        VCHIFFLIB = ""
        DCHIFFDEB = Date.Now
        NCHIFFPV = 0
        NCHIFFMOADMIN = 0
        NCHIFFFO = 0
        NCHIFFST = 0
        NCHIFFMOASS = 0
        NCHIFFMOCHAFF = 0
        NCHIFFMOBE = 0
        NCHIFFPAN = 0
        NCHIFFGD = 0
        NCHIFFKM = 0
        NCHIFFFRAISANNEXE = 0
        VCHIFFOBS = ""
        CPRORATA = "N"
        If MozartParams.NomSociete = "EMALECMPM" Then
          NPCPRORATA = 0
        Else
          NPCPRORATA = 0.015
        End If

        NCHIFFMOBE_AUTO = 0
        NCHIFFMOBE_ELEC = 0
        NCHIFFMOBE_MECA = 0

        NCHIFFMO_MECA = 0
        NCHIFFMO_CABL = 0
        NCHIFFMO_AIDETEC = 0
        NCHIFF_DEPLACE = 0

        NTAUX_FG = GetTauxFG()

      End If
      dr.Close()

    Catch ex As Exception

      MessageBox.Show("Erreur dans Constructeur StructChantierChiffrage : " & ex.Message)

    End Try

  End Sub

End Structure
