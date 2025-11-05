Imports System.Data.SqlClient
Imports MozartLib

Public Class C_CONTRATEI

  Dim _NIDDOCCONTEI As Int32
  Dim _NCLINUM As Int32
  Dim _VRTFTEXT As String
  Dim _VFILENAME As String
  Dim _DDOCCONTEIENVOI As String
  Dim _NIDPROC As Int32

  ' TB SAMSIC CITY PATH
  ' Dim fileRead As String = "\\srv-web01\Mozart\Modeles\Emalec\FR\EI_CONTRAT.xml"
  Dim fileRead As String = RechercheParamByLib("MOZART_RESSOURCES") & "Modeles\Emalec\FR\EI_CONTRAT.xml"
  Dim FileOut As String = ""

  Public Property FileContratEI As String
    Get
      Return FileOut
    End Get
    Set(ByVal value As String)
      FileOut = value
    End Set
  End Property

  Public ReadOnly Property NCLINUM As Int32
    Get
      Return _NCLINUM
    End Get
  End Property

  Public ReadOnly Property RTFTEXT As String
    Get
      Return _VRTFTEXT
    End Get
  End Property

  Public ReadOnly Property DDOCCONTEIENVOI As String
    Get
      Return _DDOCCONTEIENVOI
    End Get
  End Property

  Public Property NIDDOCCONTEI As Int32
    Get
      Return _NIDDOCCONTEI
    End Get
    Set(value As Int32)
      _NIDDOCCONTEI = value
    End Set
  End Property

  Public Property NIDPROC As Int32
    Get
      Return _NIDPROC
    End Get
    Set(value As Int32)
      _NIDPROC = value
    End Set
  End Property

  Public Sub New(ByVal c_NCLINUM As Int32, ByVal c_NIDPROC As Int32, Optional ByVal c_NCCLNUM As Int32 = 0)

    _NIDDOCCONTEI = 0
    _NIDPROC = c_NIDPROC
    _NCLINUM = c_NCLINUM
    _VFILENAME = String.Format("Contrat_EI_{0}", _NCLINUM)

    'on charge le dernier contrat du client
    LoadContratEI()

  End Sub

  Private Sub LoadContratEI()

    Dim osqlcmdRead As New SqlCommand("[api_sp_DocContEIOpen]", MozartDatabase.cnxMozart)

    osqlcmdRead.CommandType = CommandType.StoredProcedure
    osqlcmdRead.Parameters.Add("@p_NCLINUM", SqlDbType.Int).Value = _NCLINUM
    osqlcmdRead.Parameters.Add("@p_NIDPROC", SqlDbType.Int).Value = _NIDPROC

    Dim osqldr As SqlDataReader = osqlcmdRead.ExecuteReader

    If osqldr.HasRows Then

      osqldr.Read()
      _NIDDOCCONTEI = osqldr.Item("NIDDOCCONTEI")
      _VFILENAME = osqldr.Item("VFILENAME")
      _VRTFTEXT = osqldr.Item("VDOCCONTEIRTFTEXT")
      _DDOCCONTEIENVOI = osqldr.Item("DDOCCONTEIENVOI")

      'si _NIDPROC = 0 alors on le laisse à 0
      If _NIDPROC <> 0 Then _NIDPROC = osqldr.Item("NIDPROC")

    Else

      'nouveau
      _NIDDOCCONTEI = 0
      _NIDPROC = 0

    End If

    If osqldr.IsClosed = False Then osqldr.Close()


  End Sub

  Public Sub CreateContratEI(ByVal p_ListeSites As String, ByVal p_NCCLNUM As Int32)

    'modele xml
    Dim Tableau_Inventaire_Modele As String = "<w:tbl> " &
                                              "<w:tblPr> " &
                                               "<w:tblW w:w=""0"" w:type=""auto""/> " &
                                               "<w:tblBorders> " &
                                                "<w:top w:val=""single"" w:sz=""4"" w:space=""0"" w:color=""auto""/> " &
                                                "<w:left w:val=""single"" w:sz=""4"" w:space=""0"" w:color=""auto""/> " &
                                                "<w:bottom w:val=""single"" w:sz=""4"" w:space=""0"" w:color=""auto""/> " &
                                                "<w:right w:val=""single"" w:sz=""4"" w:space=""0"" w:color=""auto""/> " &
                                                "<w:insideH w:val=""single"" w:sz=""4"" w:space=""0"" w:color=""auto""/> " &
                                                "<w:insideV w:val=""single"" w:sz=""4"" w:space=""0"" w:color=""auto""/> " &
                                               "</w:tblBorders> " &
                                               "<w:tblLook w:val=""04A0"" w:firstRow=""1"" w:lastRow=""0"" w:firstColumn=""1"" w:lastColumn=""0"" w:noHBand=""0"" w:noVBand=""1""/> " &
                                              "</w:tblPr> " &
                                              "<w:tblGrid> " &
                                               "<w:gridCol w:w=""4882""/> " &
                                               "<w:gridCol w:w=""2172""/> " &
                                               "<w:gridCol w:w=""816""/> " &
                                               "<w:gridCol w:w=""1433""/> " &
                                               "<w:gridCol w:w=""1583""/> " &
                                              "</w:tblGrid>"

    Dim Tableau_Inventaire_Modele_Fin As String = "</w:tbl>"

    Dim Tableau_Inventaire_Modele_Site_Nom As String = "<w:tr w:rsidR=""00FD3584"" w:rsidRPr=""00666D18"" w:rsidTr=""000807A2""> " &
                                                           "<w:trPr> " &
                                                               "<w:trHeight w:val=""315""/> " &
                                                           "</w:trPr> " &
                                                           "<w:tc> " &
                                                               "<w:tcPr> " &
                                                                   "<w:tcW w:w=""10886"" w:type=""dxa""/> " &
                                                                   "<w:gridSpan w:val=""5""/> " &
                                                                   "<w:shd w:val=""clear"" w:color=""auto"" w:fill=""D9D9D9""/> " &
                                                                   "<w:vAlign w:val=""center""/> " &
                                                               "</w:tcPr> " &
                                                               "<w:p w:rsidR=""00FD3584"" w:rsidRPr=""00666D18"" w:rsidRDefault=""00FD3584"" w:rsidP=""0083565A""> " &
                                                                   "<w:pPr> " &
                                                                       "<w:rPr> " &
                                                                           "<w:b/> " &
                                                                           "<w:sz w:val=""20""/> " &
                                                                           "<w:szCs w:val=""20""/> " &
                                                                       "</w:rPr> " &
                                                                   "</w:pPr> " &
                                                                   "<w:r w:rsidRPr=""00666D18""> " &
                                                                       "<w:rPr> " &
                                                                           "<w:b/> " &
                                                                           "<w:sz w:val=""20""/> " &
                                                                           "<w:szCs w:val=""20""/> " &
                                                                       "</w:rPr> " &
                                                                       "<w:t>Site : {0}</w:t> " &
                                                                   "</w:r> " &
                                                               "</w:p> " &
                                                           "</w:tc> " &
                                                       "</w:tr>"

    Dim Tableau_Inventaire_Modele_Entete_Col As String = "<w:tr w:rsidR=""00FD3584"" w:rsidRPr=""00666D18"" w:rsidTr=""00FA6B84""> " &
                                                             "<w:trPr> " &
                                                                 "<w:trHeight w:val=""418""/> " &
                                                             "</w:trPr> " &
                                                             "<w:tc> " &
                                                                 "<w:tcPr> " &
                                                                     "<w:tcW w:w=""4882"" w:type=""dxa""/> " &
                                                                     "<w:shd w:val=""clear"" w:color=""auto"" w:fill=""auto""/> " &
                                                                     "<w:vAlign w:val=""center""/> " &
                                                                 "</w:tcPr> " &
                                                                 "<w:p w:rsidR=""00FD3584"" w:rsidRPr=""00666D18"" w:rsidRDefault=""00FD3584"" w:rsidP=""00666D18""> " &
                                                                     "<w:pPr> " &
                                                                         "<w:jc w:val=""center""/> " &
                                                                         "<w:rPr> " &
                                                                             "<w:b/> " &
                                                                             "<w:sz w:val=""20""/> " &
                                                                             "<w:szCs w:val=""20""/> " &
                                                                         "</w:rPr> " &
                                                                     "</w:pPr> " &
                                                                     "<w:r w:rsidRPr=""00666D18""> " &
                                                                         "<w:rPr> " &
                                                                             "<w:b/> " &
                                                                             "<w:sz w:val=""20""/> " &
                                                                             "<w:szCs w:val=""20""/> " &
                                                                         "</w:rPr> " &
                                                                         "<w:t>Désignation</w:t> " &
                                                                     "</w:r> " &
                                                                 "</w:p> " &
                                                             "</w:tc> " &
                                                             "<w:tc> " &
                                                                 "<w:tcPr> " &
                                                                     "<w:tcW w:w=""2172"" w:type=""dxa""/> " &
                                                                     "<w:shd w:val=""clear"" w:color=""auto"" w:fill=""auto""/> " &
                                                                     "<w:vAlign w:val=""center""/> " &
                                                                 "</w:tcPr> " &
                                                                 "<w:p w:rsidR=""00FD3584"" w:rsidRPr=""00666D18"" w:rsidRDefault=""00FD3584"" w:rsidP=""00666D18""> " &
                                                                     "<w:pPr> " &
                                                                         "<w:pStyle w:val=""Listepuces""/> " &
                                                                         "<w:numPr> " &
                                                                             "<w:ilvl w:val=""0""/> " &
                                                                             "<w:numId w:val=""0""/> " &
                                                                         "</w:numPr> " &
                                                                         "<w:ind w:left=""360"" w:hanging=""360""/> " &
                                                                         "<w:jc w:val=""center""/> " &
                                                                         "<w:rPr> " &
                                                                             "<w:b/> " &
                                                                             "<w:sz w:val=""20""/> " &
                                                                             "<w:szCs w:val=""20""/> " &
                                                                         "</w:rPr> " &
                                                                     "</w:pPr> " &
                                                                     "<w:r> " &
                                                                         "<w:rPr> " &
                                                                             "<w:b/> " &
                                                                             "<w:sz w:val=""20""/> " &
                                                                             "<w:szCs w:val=""20""/> " &
                                                                         "</w:rPr> " &
                                                                         "<w:t>Marque</w:t> " &
                                                                     "</w:r> " &
                                                                 "</w:p> " &
                                                             "</w:tc> " &
                                                             "<w:tc> " &
                                                                 "<w:tcPr> " &
                                                                     "<w:tcW w:w=""816"" w:type=""dxa""/> " &
                                                                     "<w:shd w:val=""clear"" w:color=""auto"" w:fill=""auto""/> " &
                                                                     "<w:vAlign w:val=""center""/> " &
                                                                 "</w:tcPr> " &
                                                                 "<w:p w:rsidR=""00FD3584"" w:rsidRPr=""00666D18"" w:rsidRDefault=""00FD3584"" w:rsidP=""00666D18""> " &
                                                                     "<w:pPr> " &
                                                                         "<w:jc w:val=""center""/> " &
                                                                         "<w:rPr> " &
                                                                             "<w:b/> " &
                                                                             "<w:sz w:val=""20""/> " &
                                                                             "<w:szCs w:val=""20""/> " &
                                                                         "</w:rPr> " &
                                                                     "</w:pPr> " &
                                                                     "<w:r> " &
                                                                         "<w:rPr> " &
                                                                             "<w:b/> " &
                                                                             "<w:sz w:val=""20""/> " &
                                                                             "<w:szCs w:val=""20""/> " &
                                                                         "</w:rPr> " &
                                                                         "<w:t>N°</w:t> " &
                                                                     "</w:r> " &
                                                                 "</w:p> " &
                                                             "</w:tc> " &
                                                             "<w:tc> " &
                                                                 "<w:tcPr> " &
                                                                     "<w:tcW w:w=""1433"" w:type=""dxa""/> " &
                                                                     "<w:vAlign w:val=""center""/> " &
                                                                 "</w:tcPr> " &
                                                                 "<w:p w:rsidR=""00FD3584"" w:rsidRPr=""00666D18"" w:rsidRDefault=""00FD3584"" w:rsidP=""00666D18""> " &
                                                                     "<w:pPr> " &
                                                                         "<w:jc w:val=""center""/> " &
                                                                         "<w:rPr> " &
                                                                             "<w:b/> " &
                                                                             "<w:sz w:val=""20""/> " &
                                                                             "<w:szCs w:val=""20""/> " &
                                                                         "</w:rPr> " &
                                                                     "</w:pPr> " &
                                                                     "<w:r w:rsidRPr=""00666D18""> " &
                                                                         "<w:rPr> " &
                                                                             "<w:b/> " &
                                                                             "<w:sz w:val=""20""/> " &
                                                                             "<w:szCs w:val=""20""/> " &
                                                                         "</w:rPr> " &
                                                                         "<w:t>Année estampillé</w:t> " &
                                                                     "</w:r> " &
                                                                 "</w:p> " &
                                                             "</w:tc> " &
                                                             "<w:tc> " &
                                                                 "<w:tcPr> " &
                                                                     "<w:tcW w:w=""1583"" w:type=""dxa""/> " &
                                                                     "<w:vAlign w:val=""center""/> " &
                                                                 "</w:tcPr> " &
                                                                 "<w:p w:rsidR=""00FD3584"" w:rsidRPr=""00666D18"" w:rsidRDefault=""00FD3584"" w:rsidP=""00666D18""> " &
                                                                     "<w:pPr> " &
                                                                         "<w:jc w:val=""center""/> " &
                                                                         "<w:rPr> " &
                                                                             "<w:b/> " &
                                                                             "<w:sz w:val=""20""/> " &
                                                                             "<w:szCs w:val=""20""/> " &
                                                                         "</w:rPr> " &
                                                                     "</w:pPr> " &
                                                                     "<w:r w:rsidRPr=""00666D18""> " &
                                                                         "<w:rPr> " &
                                                                             "<w:b/> " &
                                                                             "<w:sz w:val=""20""/> " &
                                                                             "<w:szCs w:val=""20""/> " &
                                                                         "</w:rPr> " &
                                                                         "<w:t>Lieu</w:t> " &
                                                                     "</w:r> " &
                                                                     "<w:r> " &
                                                                         "<w:rPr> " &
                                                                             "<w:b/> " &
                                                                             "<w:sz w:val=""20""/> " &
                                                                             "<w:szCs w:val=""20""/> " &
                                                                         "</w:rPr> " &
                                                                         "<w:t xml:space=""preserve""> d’implantation</w:t> " &
                                                                     "</w:r> " &
                                                                 "</w:p> " &
                                                             "</w:tc> " &
                                                         "</w:tr>"

    Dim Tableau_Inventaire_Modele_Line_Fou As String = "<w:tr w:rsidR=""00FD3584"" w:rsidRPr=""00666D18"" w:rsidTr=""00FA6B84""> " &
                                                           "<w:trPr> " &
                                                               "<w:trHeight w:val=""416""/> " &
                                                           "</w:trPr> " &
                                                           "<w:tc> " &
                                                               "<w:tcPr> " &
                                                                   "<w:tcW w:w=""4882"" w:type=""dxa""/> " &
                                                                   "<w:shd w:val=""clear"" w:color=""auto"" w:fill=""auto""/> " &
                                                                   "<w:vAlign w:val=""center""/> " &
                                                               "</w:tcPr> " &
                                                               "<w:p w:rsidR=""00FD3584"" w:rsidRPr=""00666D18"" w:rsidRDefault=""00FD3584"" w:rsidP=""0083565A""> " &
                                                                   "<w:pPr> " &
                                                                       "<w:rPr> " &
                                                                           "<w:sz w:val=""20""/> " &
                                                                           "<w:szCs w:val=""20""/> " &
                                                                       "</w:rPr> " &
                                                                   "</w:pPr> " &
                                                                   "<w:r w:rsidRPr=""00666D18""> " &
                                                                       "<w:rPr> " &
                                                                           "<w:sz w:val=""20""/> " &
                                                                           "<w:szCs w:val=""20""/> " &
                                                                       "</w:rPr> " &
                                                                       "<w:lastRenderedPageBreak/> " &
                                                                       "<w:t>{0}</w:t> " &
                                                                   "</w:r> " &
                                                               "</w:p> " &
                                                           "</w:tc> " &
                                                           "<w:tc> " &
                                                               "<w:tcPr> " &
                                                                   "<w:tcW w:w=""2172"" w:type=""dxa""/> " &
                                                                   "<w:shd w:val=""clear"" w:color=""auto"" w:fill=""auto""/> " &
                                                                   "<w:vAlign w:val=""center""/> " &
                                                               "</w:tcPr> " &
                                                               "<w:p w:rsidR=""00FD3584"" w:rsidRDefault=""00FA6B84"" w:rsidP=""00666D18""> " &
                                                                   "<w:pPr> " &
                                                                       "<w:pStyle w:val=""Listepuces""/> " &
                                                                       "<w:numPr> " &
                                                                           "<w:ilvl w:val=""0""/> " &
                                                                           "<w:numId w:val=""0""/> " &
                                                                       "</w:numPr> " &
                                                                       "<w:ind w:left=""360"" w:hanging=""360""/> " &
                                                                       "<w:jc w:val=""center""/> " &
                                                                   "</w:pPr> " &
                                                                   "<w:r> " &
                                                                       "<w:rPr> " &
                                                                           "<w:sz w:val=""20""/> " &
                                                                           "<w:szCs w:val=""20""/> " &
                                                                       "</w:rPr> " &
                                                                       "<w:t xml:space=""preserve"">{1}</w:t> " &
                                                                   "</w:r> " &
                                                               "</w:p> " &
                                                           "</w:tc> " &
                                                           "<w:tc> " &
                                                               "<w:tcPr> " &
                                                                   "<w:tcW w:w=""816"" w:type=""dxa""/> " &
                                                                   "<w:shd w:val=""clear"" w:color=""auto"" w:fill=""auto""/> " &
                                                                   "<w:vAlign w:val=""center""/> " &
                                                               "</w:tcPr> " &
                                                               "<w:p w:rsidR=""00FD3584"" w:rsidRPr=""00666D18"" w:rsidRDefault=""00FA6B84"" w:rsidP=""00666D18""> " &
                                                                   "<w:pPr> " &
                                                                       "<w:jc w:val=""center""/> " &
                                                                       "<w:rPr> " &
                                                                           "<w:sz w:val=""20""/> " &
                                                                           "<w:szCs w:val=""20""/> " &
                                                                       "</w:rPr> " &
                                                                   "</w:pPr> " &
                                                                   "<w:r> " &
                                                                       "<w:rPr> " &
                                                                           "<w:sz w:val=""20""/> " &
                                                                           "<w:szCs w:val=""20""/> " &
                                                                       "</w:rPr> " &
                                                                       "<w:t>{2}</w:t> " &
                                                                   "</w:r> " &
                                                                   "<w:bookmarkStart w:id=""0"" w:name=""_GoBack""/> " &
                                                                   "<w:bookmarkEnd w:id=""0""/> " &
                                                               "</w:p> " &
                                                           "</w:tc> " &
                                                           "<w:tc> " &
                                                               "<w:tcPr> " &
                                                                   "<w:tcW w:w=""1433"" w:type=""dxa""/> " &
                                                                   "<w:vAlign w:val=""center""/> " &
                                                               "</w:tcPr> " &
                                                               "<w:p w:rsidR=""00FD3584"" w:rsidRPr=""00666D18"" w:rsidRDefault=""00FA6B84"" w:rsidP=""00666D18""> " &
                                                                   "<w:pPr> " &
                                                                       "<w:jc w:val=""center""/> " &
                                                                       "<w:rPr> " &
                                                                           "<w:sz w:val=""20""/> " &
                                                                           "<w:szCs w:val=""20""/> " &
                                                                       "</w:rPr> " &
                                                                   "</w:pPr> " &
                                                                   "<w:r> " &
                                                                       "<w:rPr> " &
                                                                           "<w:sz w:val=""20""/> " &
                                                                           "<w:szCs w:val=""20""/> " &
                                                                       "</w:rPr> " &
                                                                       "<w:t>{3}</w:t> " &
                                                                   "</w:r> " &
                                                               "</w:p> " &
                                                           "</w:tc> " &
                                                           "<w:tc> " &
                                                               "<w:tcPr> " &
                                                                   "<w:tcW w:w=""1583"" w:type=""dxa""/> " &
                                                                   "<w:vAlign w:val=""center""/> " &
                                                               "</w:tcPr> " &
                                                               "<w:p w:rsidR=""00FD3584"" w:rsidRPr=""00666D18"" w:rsidRDefault=""00FD3584"" w:rsidP=""00666D18""> " &
                                                                   "<w:pPr> " &
                                                                       "<w:jc w:val=""center""/> " &
                                                                       "<w:rPr> " &
                                                                           "<w:sz w:val=""20""/> " &
                                                                           "<w:szCs w:val=""20""/> " &
                                                                       "</w:rPr> " &
                                                                   "</w:pPr> " &
                                                                   "<w:r> " &
                                                                       "<w:t>{4}</w:t> " &
                                                                   "</w:r> " &
                                                               "</w:p> " &
                                                           "</w:tc> " &
                                                       "</w:tr>"


    '------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------
    Dim Tableau_Prestation_Modele As String = "<w:tbl> " &
                                              "<w:tblPr> " &
                                               "<w:tblW w:w=""10450"" w:type=""dxa""/> " &
                                               "<w:tblInd w:w=""108"" w:type=""dxa""/> " &
                                               "<w:tblBorders> " &
                                                "<w:top w:val=""single"" w:sz=""4"" w:space=""0"" w:color=""auto""/> " &
                                                "<w:left w:val=""single"" w:sz=""4"" w:space=""0"" w:color=""auto""/> " &
                                                "<w:bottom w:val=""single"" w:sz=""4"" w:space=""0"" w:color=""auto""/> " &
                                                "<w:right w:val=""single"" w:sz=""4"" w:space=""0"" w:color=""auto""/> " &
                                                "<w:insideH w:val=""single"" w:sz=""4"" w:space=""0"" w:color=""auto""/> " &
                                                "<w:insideV w:val=""single"" w:sz=""4"" w:space=""0"" w:color=""auto""/> " &
                                               "</w:tblBorders> " &
                                               "<w:tblLayout w:type=""fixed""/> " &
                                               "<w:tblLook w:val=""01E0"" w:firstRow=""1"" w:lastRow=""1"" w:firstColumn=""1"" w:lastColumn=""1"" w:noHBand=""0"" w:noVBand=""0""/> " &
                                              "</w:tblPr> " &
                                              "<w:tblGrid> " &
                                               "<w:gridCol w:w=""6600""/> " &
                                               "<w:gridCol w:w=""1336""/> " &
                                               "<w:gridCol w:w=""1304""/> " &
                                               "<w:gridCol w:w=""1210""/> " &
                                              "</w:tblGrid> " &
                                              "<w:tr w:rsidR=""00A3692F"" w:rsidRPr=""001E212D"" w:rsidTr=""00B2029F""> " &
                                               "<w:trPr> " &
                                                "<w:trHeight w:val=""227""/> " &
                                               "</w:trPr> " &
                                               "<w:tc> " &
                                                "<w:tcPr> " &
                                                 "<w:tcW w:w=""6600"" w:type=""dxa""/> " &
                                                 "<w:shd w:val=""clear"" w:color=""auto"" w:fill=""E0E0E0""/> " &
                                                 "<w:vAlign w:val=""center""/> " &
                                                "</w:tcPr> " &
                                                "<w:p w:rsidR=""00A3692F"" w:rsidRPr=""001E212D"" w:rsidRDefault=""00A3692F"" w:rsidP=""00F70E81""> " &
                                                 "<w:pPr> " &
                                                  "<w:jc w:val=""center""/> " &
                                                  "<w:rPr> " &
                                                   "<w:b/> " &
                                                   "<w:sz w:val=""20""/> " &
                                                   "<w:szCs w:val=""20""/> " &
                                                  "</w:rPr> " &
                                                 "</w:pPr> " &
                                                 "<w:r w:rsidRPr=""001E212D""> " &
                                                  "<w:rPr> " &
                                                   "<w:b/> " &
                                                   "<w:sz w:val=""20""/> " &
                                                   "<w:szCs w:val=""20""/> " &
                                                  "</w:rPr> " &
                                                  "<w:t>Désignation</w:t> " &
                                                 "</w:r> " &
                                                "</w:p> " &
                                               "</w:tc> " &
                                               "<w:tc> " &
                                                "<w:tcPr> " &
                                                 "<w:tcW w:w=""1336"" w:type=""dxa""/> " &
                                                 "<w:shd w:val=""clear"" w:color=""auto"" w:fill=""E0E0E0""/> " &
                                                 "<w:vAlign w:val=""center""/> " &
                                                "</w:tcPr> " &
                                                "<w:p w:rsidR=""001E212D"" w:rsidRPr=""001E212D"" w:rsidRDefault=""00A3692F"" w:rsidP=""00F70E81""> " &
                                                 "<w:pPr> " &
                                                  "<w:jc w:val=""center""/> " &
                                                  "<w:rPr> " &
                                                   "<w:b/> " &
                                                   "<w:sz w:val=""20""/> " &
                                                   "<w:szCs w:val=""20""/> " &
                                                  "</w:rPr> " &
                                                 "</w:pPr> " &
                                                 "<w:proofErr w:type=""spellStart""/> " &
                                                 "<w:r w:rsidRPr=""001E212D""> " &
                                                  "<w:rPr> " &
                                                   "<w:b/> " &
                                                   "<w:sz w:val=""20""/> " &
                                                   "<w:szCs w:val=""20""/> " &
                                                  "</w:rPr> " &
                                                  "<w:t>Nbr</w:t> " &
                                                 "</w:r> " &
                                                 "<w:r w:rsidR=""00E4655E"" w:rsidRPr=""001E212D""> " &
                                                  "<w:rPr> " &
                                                   "<w:b/> " &
                                                   "<w:sz w:val=""20""/> " &
                                                   "<w:szCs w:val=""20""/> " &
                                                  "</w:rPr> " &
                                                  "<w:t>e</w:t> " &
                                                 "</w:r> " &
                                                 "<w:proofErr w:type=""spellEnd""/> " &
                                                 "<w:r w:rsidR=""001E212D"" w:rsidRPr=""001E212D""> " &
                                                  "<w:rPr> " &
                                                   "<w:b/> " &
                                                   "<w:sz w:val=""20""/> " &
                                                   "<w:szCs w:val=""20""/> " &
                                                  "</w:rPr> " &
                                                  "<w:t xml:space=""preserve""> visite</w:t> " &
                                                 "</w:r> " &
                                                "</w:p> " &
                                                "<w:p w:rsidR=""00A3692F"" w:rsidRPr=""001E212D"" w:rsidRDefault=""00A3692F"" w:rsidP=""00F70E81""> " &
                                                 "<w:pPr> " &
                                                  "<w:jc w:val=""center""/> " &
                                                  "<w:rPr> " &
                                                   "<w:b/> " &
                                                   "<w:sz w:val=""20""/> " &
                                                   "<w:szCs w:val=""20""/> " &
                                                  "</w:rPr> " &
                                                 "</w:pPr> " &
                                                 "<w:r w:rsidRPr=""001E212D""> " &
                                                  "<w:rPr> " &
                                                   "<w:b/> " &
                                                   "<w:sz w:val=""20""/> " &
                                                   "<w:szCs w:val=""20""/> " &
                                                  "</w:rPr> " &
                                                  "<w:t>par an</w:t> " &
                                                 "</w:r> " &
                                                "</w:p> " &
                                               "</w:tc> " &
                                               "<w:tc> " &
                                                "<w:tcPr> " &
                                                 "<w:tcW w:w=""1304"" w:type=""dxa""/> " &
                                                 "<w:shd w:val=""clear"" w:color=""auto"" w:fill=""E0E0E0""/> " &
                                                 "<w:vAlign w:val=""center""/> " &
                                                "</w:tcPr> " &
                                                "<w:p w:rsidR=""00A3692F"" w:rsidRPr=""001E212D"" w:rsidRDefault=""00A3692F"" w:rsidP=""00F70E81""> " &
                                                 "<w:pPr> " &
                                                  "<w:jc w:val=""center""/> " &
                                                  "<w:rPr> " &
                                                   "<w:b/> " &
                                                   "<w:sz w:val=""20""/> " &
                                                   "<w:szCs w:val=""20""/> " &
                                                  "</w:rPr> " &
                                                 "</w:pPr> " &
                                                 "<w:r w:rsidRPr=""001E212D""> " &
                                                  "<w:rPr> " &
                                                   "<w:b/> " &
                                                   "<w:sz w:val=""20""/> " &
                                                   "<w:szCs w:val=""20""/> " &
                                                  "</w:rPr> " &
                                                  "<w:t>Forfait par équipement</w:t> " &
                                                 "</w:r> " &
                                                "</w:p> " &
                                               "</w:tc> " &
                                               "<w:tc> " &
                                                "<w:tcPr> " &
                                                 "<w:tcW w:w=""1210"" w:type=""dxa""/> " &
                                                 "<w:tcBorders> " &
                                                  "<w:bottom w:val=""single"" w:sz=""4"" w:space=""0"" w:color=""auto""/> " &
                                                 "</w:tcBorders> " &
                                                 "<w:shd w:val=""clear"" w:color=""auto"" w:fill=""E0E0E0""/> " &
                                                 "<w:vAlign w:val=""center""/> " &
                                                "</w:tcPr> " &
                                                "<w:p w:rsidR=""00A3692F"" w:rsidRPr=""001E212D"" w:rsidRDefault=""00A3692F"" w:rsidP=""00F70E81""> " &
                                                 "<w:pPr> " &
                                                  "<w:jc w:val=""center""/> " &
                                                  "<w:rPr> " &
                                                   "<w:b/> " &
                                                   "<w:sz w:val=""20""/> " &
                                                   "<w:szCs w:val=""20""/> " &
                                                  "</w:rPr> " &
                                                 "</w:pPr> " &
                                                 "<w:r w:rsidRPr=""001E212D""> " &
                                                  "<w:rPr> " &
                                                   "<w:b/> " &
                                                   "<w:sz w:val=""20""/> " &
                                                   "<w:szCs w:val=""20""/> " &
                                                  "</w:rPr> " &
                                                  "<w:t>Forfait par visite et par site</w:t> " &
                                                 "</w:r> " &
                                                "</w:p> " &
                                               "</w:tc> " &
                                              "</w:tr>"


    Dim Tableau_Prestation_Modele_Fin As String = "<w:tr>" &
                                     "<w:trPr> " &
                                      "<w:trHeight w:hRule=""at-least"" w:val=""227""/>" &
                                     "</w:trPr>" &
                                     "<w:tc>" &
                                      "<w:tcPr>" &
                                       "<w:tcW w:w=""6600"" w:type=""dxa"" />" &
                                       "<w:vAlign w:val=""center"" />" &
                                      "</w:tcPr>" &
                                      "<w:p>" &
                                       "<w:pPr>" &
                                        "<w:rPr>" &
                                         "<w:sz w:val=""16"" />" &
                                        "</w:rPr>" &
                                       "</w:pPr>" &
                                       "<w:r>" &
                                        "<w:rPr>" &
                                         "<w:sz w:val=""16"" />" &
                                        "</w:rPr>" &
                                        "<w:t>PIECES DETACHEES, REPARATIONS, REMPLACEMENTS, RECHARGES</w:t>" &
                                       "</w:r>" &
                                      "</w:p>" &
                                     "</w:tc>" &
                                     "<w:tc>" &
                                      "<w:tcPr>" &
                                       "<w:tcW w:w=""3850"" w:type=""dxa"" />" &
                                       "<w:gridSpan w:val=""3"" />" &
                                       "<w:vAlign w:val=""center"" />" &
                                      "</w:tcPr>" &
                                      "<w:p>" &
                                       "<w:pPr>" &
                                        "<w:jc w:val=""center"" />" &
                                        "<w:rPr>" &
                                         "<w:sz w:val=""16"" />" &
                                        "</w:rPr>" &
                                       "</w:pPr>" &
                                       "<w:r>" &
                                        "<w:rPr>" &
                                         "<w:sz w:val=""16"" />" &
                                        "</w:rPr>" &
                                        "<w:t>Suivant bordereau des pièces détachées et prestations correctives</w:t>" &
                                       "</w:r>" &
                                      "</w:p>" &
                                     "</w:tc>" &
                                    "</w:tr>" &
                                    "<w:tr>" &
                                     "<w:trPr>" &
                                      "<w:trHeight w:hRule=""at-least"" w:val=""227"" />" &
                                     "</w:trPr>" &
                                     "<w:tc>" &
                                      "<w:tcPr>" &
                                       "<w:tcW w:w=""6600"" w:type=""dxa"" />" &
                                       "<w:vAlign w:val=""center"" />" &
                                      "</w:tcPr>" &
                                      "<w:p>" &
                                       "<w:pPr>" &
                                        "<w:rPr>" &
                                         "<w:sz w:val=""16"" />" &
                                        "</w:rPr>" &
                                       "</w:pPr>" &
                                       "<w:r>" &
                                        "<w:rPr>" &
                                         "<w:sz w:val=""16"" />" &
                                        "</w:rPr>" &
                                        "<w:t>MAINTENANCE APPROFONDIE QUINQUENNALE DES EXTINCTEURS</w:t>" &
                                       "</w:r>" &
                                      "</w:p>" &
                                     "</w:tc>" &
                                     "<w:tc>" &
                                      "<w:tcPr>" &
                                       "<w:tcW w:w=""3850"" w:type=""dxa"" />" &
                                       "<w:gridSpan w:val=""3"" />" &
                                       "<w:vAlign w:val=""center"" />" &
                                      "</w:tcPr>" &
                                      "<w:p>" &
                                       "<w:pPr>" &
                                        "<w:jc w:val=""center"" />" &
                                        "<w:rPr>" &
                                         "<w:sz w:val=""16"" />" &
                                        "</w:rPr>" &
                                       "</w:pPr>" &
                                       "<w:r>" &
                                        "<w:rPr>" &
                                         "<w:sz w:val=""16"" />" &
                                        "</w:rPr>" &
                                        "<w:t>Suivant bordereau de prix en annexe</w:t>" &
                                       "</w:r>" &
                                      "</w:p>" &
                                     "</w:tc>" &
                                    "</w:tr>" &
                                    "<w:tr>" &
                                     "<w:trPr>" &
                                      "<w:trHeight w:hRule=""at-least"" w:val=""227"" />" &
                                     "</w:trPr>" &
                                     "<w:tc>" &
                                      "<w:tcPr>" &
                                       "<w:tcW w:w=""6600"" w:type=""dxa"" />" &
                                       "<w:vAlign w:val=""center"" />" &
                                      "</w:tcPr>" &
                                      "<w:p>" &
                                       "<w:pPr>" &
                                        "<w:rPr>" &
                                         "<w:sz w:val=""16"" />" &
                                        "</w:rPr>" &
                                       "</w:pPr>" &
                                       "<w:r>" &
                                        "<w:rPr>" &
                                         "<w:sz w:val=""16"" />" &
                                        "</w:rPr>" &
                                        "<w:t>MAINTENANCE DECENNALE DES EXTINCTEURS soit :</w:t>" &
                                       "</w:r>" &
                                      "</w:p>" &
                                      "<w:p>" &
                                       "<w:pPr>" &
                                        "<w:spacing w:before=""120"" w:before-autospacing=""off"" w:after-autospacing=""off"" />" &
                                        "<w:ind w:left=""885"" />" &
                                        "<w:rPr>" &
                                         "<w:sz w:val=""16"" />" &
                                        "</w:rPr>" &
                                       "</w:pPr>" &
                                       "<w:r>" &
                                        "<w:rPr>" &
                                         "<w:rFonts w:ascii=""Wingdings"" w:h-ansi=""Wingdings"" />" &
                                         "<w:sz w:val=""16"" />" &
                                        "</w:rPr>" &
                                        "<w:t></w:t>" &
                                       "</w:r>" &
                                       "<w:r>" &
                                        "<w:rPr>" &
                                         "<w:sz w:val=""16"" />" &
                                        "</w:rPr>" &
                                        "<w:t xml:space=""preserve""> REVISION EN ATELIER </w:t>" &
                                       "</w:r>" &
                                      "</w:p>" &
                                      "<w:p>" &
                                       "<w:pPr>" &
                                        "<w:spacing w:before=""120"" w:before-autospacing=""off"" w:after-autospacing=""off"" />" &
                                        "<w:ind w:left=""885"" />" &
                                        "<w:rPr>" &
                                         "<w:sz w:val=""16"" />" &
                                        "</w:rPr>" &
                                       "</w:pPr>" &
                                       "<w:r>" &
                                        "<w:rPr>" &
                                         "<w:rFonts w:ascii=""Wingdings"" w:h-ansi=""Wingdings"" />" &
                                         "<w:sz w:val=""16"" />" &
                                        "</w:rPr>" &
                                        "<w:t></w:t>" &
                                       "</w:r>" &
                                       "<w:r>" &
                                        "<w:rPr>" &
                                         "<w:sz w:val=""16"" />" &
                                        "</w:rPr>" &
                                        "<w:t xml:space=""preserve""> REMPLACEMENT APPAREIL </w:t>" &
                                       "</w:r>" &
                                      "</w:p>" &
                                      "<w:p>" &
                                       "<w:pPr>" &
                                        "<w:rPr>" &
                                         "<w:sz w:val=""16"" />" &
                                        "</w:rPr>" &
                                       "</w:pPr>" &
                                      "</w:p>" &
                                     "</w:tc>" &
                                     "<w:tc>" &
                                      "<w:tcPr>" &
                                       "<w:tcW w:w=""3850"" w:type=""dxa"" />" &
                                       "<w:gridSpan w:val=""3"" />" &
                                       "<w:vAlign w:val=""center"" />" &
                                      "</w:tcPr>" &
                                      "<w:p>" &
                                       "<w:pPr>" &
                                        "<w:jc w:val=""center"" />" &
                                        "<w:rPr>" &
                                         "<w:sz w:val=""16"" />" &
                                        "</w:rPr>" &
                                       "</w:pPr>" &
                                       "<w:r>" &
                                        "<w:rPr>" &
                                         "<w:sz w:val=""16"" />" &
                                        "</w:rPr>" &
                                        "<w:t>Suivant bordereau de prix en annexe</w:t>" &
                                       "</w:r>" &
                                      "</w:p>" &
                                     "</w:tc>" &
                                    "</w:tr></w:tbl>"

    Dim Tableau_Prestation_Modele_Line_Fou As String = "<w:tr w:rsidR=""00A3692F"" w:rsidRPr=""001E212D"" w:rsidTr=""00B2029F""> " &
                                                           "<w:trPr> " &
                                                               "<w:trHeight w:val=""227""/> " &
                                                           "</w:trPr> " &
                                                           "<w:tc> " &
                                                               "<w:tcPr> " &
                                                                   "<w:tcW w:w=""6600"" w:type=""dxa""/> " &
                                                                   "<w:vAlign w:val=""center""/> " &
                                                               "</w:tcPr> " &
                                                               "<w:p w:rsidR=""00A3692F"" w:rsidRPr=""001E212D"" w:rsidRDefault=""00A3692F"" w:rsidP=""00F70E81""> " &
                                                                   "<w:pPr> " &
                                                                       "<w:rPr> " &
                                                                           "<w:sz w:val=""16""/> " &
                                                                           "<w:szCs w:val=""16""/> " &
                                                                       "</w:rPr> " &
                                                                   "</w:pPr> " &
                                                                   "<w:r w:rsidRPr=""001E212D""> " &
                                                                       "<w:rPr> " &
                                                                           "<w:sz w:val=""16""/> " &
                                                                           "<w:szCs w:val=""16""/> " &
                                                                       "</w:rPr> " &
                                                                       "<w:t>{0}</w:t> " &
                                                                   "</w:r> " &
                                                               "</w:p> " &
                                                           "</w:tc> " &
                                                           "<w:tc> " &
                                                               "<w:tcPr> " &
                                                                   "<w:tcW w:w=""1336"" w:type=""dxa""/> " &
                                                                    "<w:shd w:val=""clear"" w:color=""auto"" w:fill=""{4}""/> " &
                                                                   "<w:vAlign w:val=""center""/> " &
                                                               "</w:tcPr> " &
                                                               "<w:p w:rsidR=""00A3692F"" w:rsidRPr=""001E212D"" w:rsidRDefault=""00A3692F"" w:rsidP=""00F70E81""> " &
                                                                   "<w:pPr> " &
                                                                       "<w:jc w:val=""center""/> " &
                                                                       "<w:rPr> " &
                                                                           "<w:b/> " &
                                                                           "<w:sz w:val=""16""/> " &
                                                                           "<w:szCs w:val=""16""/> " &
                                                                       "</w:rPr> " &
                                                                   "</w:pPr> " &
                                                                   "<w:r w:rsidRPr=""001E212D""> " &
                                                                       "<w:rPr> " &
                                                                           "<w:b/> " &
                                                                           "<w:sz w:val=""16""/> " &
                                                                           "<w:szCs w:val=""16""/> " &
                                                                       "</w:rPr> " &
                                                                       "<w:t>{1}</w:t> " &
                                                                   "</w:r> " &
                                                               "</w:p> " &
                                                           "</w:tc> " &
                                                           "<w:tc> " &
                                                               "<w:tcPr> " &
                                                                   "<w:tcW w:w=""1304"" w:type=""dxa""/> " &
                                                                   "<w:shd w:val=""clear"" w:color=""auto"" w:fill=""{5}""/> " &
                                                                   "<w:vAlign w:val=""center""/> " &
                                                               "</w:tcPr> " &
                                                               "<w:p w:rsidR=""00A3692F"" w:rsidRPr=""001E212D"" w:rsidRDefault=""00A8295B"" w:rsidP=""00F70E81""> " &
                                                                   "<w:pPr> " &
                                                                       "<w:jc w:val=""center""/> " &
                                                                       "<w:rPr> " &
                                                                           "<w:b/> " &
                                                                           "<w:sz w:val=""16""/> " &
                                                                           "<w:szCs w:val=""16""/> " &
                                                                       "</w:rPr> " &
                                                                   "</w:pPr> " &
                                                                   "<w:r w:rsidRPr=""001E212D""> " &
                                                                       "<w:rPr> " &
                                                                           "<w:b/> " &
                                                                           "<w:sz w:val=""16""/> " &
                                                                           "<w:szCs w:val=""16""/> " &
                                                                       "</w:rPr> " &
                                                                       "<w:t>{2}</w:t> " &
                                                                   "</w:r> " &
                                                               "</w:p> " &
                                                           "</w:tc> " &
                                                            "<w:tc> " &
                                                               "<w:tcPr> " &
                                                                   "<w:tcW w:w=""1304"" w:type=""dxa""/> " &
                                                                   "<w:shd w:val=""clear"" w:color=""auto"" w:fill=""{6}""/> " &
                                                                   "<w:vAlign w:val=""center""/> " &
                                                               "</w:tcPr> " &
                                                               "<w:p w:rsidR=""00A3692F"" w:rsidRPr=""001E212D"" w:rsidRDefault=""00A8295B"" w:rsidP=""00F70E81""> " &
                                                                   "<w:pPr> " &
                                                                       "<w:jc w:val=""center""/> " &
                                                                       "<w:rPr> " &
                                                                           "<w:b/> " &
                                                                           "<w:sz w:val=""16""/> " &
                                                                           "<w:szCs w:val=""16""/> " &
                                                                       "</w:rPr> " &
                                                                   "</w:pPr> " &
                                                                   "<w:r w:rsidRPr=""001E212D""> " &
                                                                       "<w:rPr> " &
                                                                           "<w:b/> " &
                                                                           "<w:sz w:val=""16""/> " &
                                                                           "<w:szCs w:val=""16""/> " &
                                                                       "</w:rPr> " &
                                                                       "<w:t>{3}</w:t> " &
                                                                   "</w:r> " &
                                                               "</w:p> " &
                                                           "</w:tc> " &
                                                       "</w:tr>"






    'donnnees
    Dim VCLINOM As String = ""
    Dim VCLIADRESSE As String = ""
    Dim VCCLNOM As String = ""
    Dim VSITNOM As String = ""

    Dim VLISTESITE As String = ""
    Dim VLISTE_INV_SITE As String = ""

    Dim VLISTE_PRESTATION_SITE As String = ""

    Dim oSqldrSite As SqlDataReader
    Dim oSqlCmdSite As New SqlCommand("[api_sp_ImpCreateContratEI_DetailSite]", MozartDatabase.cnxMozart)
    oSqlCmdSite.CommandType = CommandType.StoredProcedure
    oSqlCmdSite.Parameters.Add("@p_NSITNUM", SqlDbType.Int)
    oSqlCmdSite.Parameters.Add("@p_NCLINUM", SqlDbType.Int)

    'entete tableau inventaire
    VLISTE_INV_SITE = Tableau_Inventaire_Modele

    For Each sSite As String In p_ListeSites.Split(";")

      If sSite <> "" Then

        oSqlCmdSite.Parameters("@p_NSITNUM").Value = sSite
        oSqlCmdSite.Parameters("@p_NCLINUM").Value = _NCLINUM
        oSqldrSite = oSqlCmdSite.ExecuteReader()

        If oSqldrSite.HasRows Then

          oSqldrSite.Read()
          VSITNOM = oSqldrSite.Item("VSITNOM")

          VLISTESITE = VLISTESITE & String.Format(" <w:p w:rsidR=""003C3083"" w:rsidRPr=""008A257B"" w:rsidRDefault=""008A257B"" w:rsidP=""008A257B""> " &
                                                     "<w:pPr> " &
                                                      "<w:numPr> " &
                                                       "<w:ilvl w:val=""0""/> " &
                                                       "<w:numId w:val=""33""/> " &
                                                      "</w:numPr> " &
                                                      "<w:rPr> " &
                                                       "<w:color w:val=""0000FF""/> " &
                                                       "<w:sz w:val=""20""/> " &
                                                       "<w:szCs w:val=""20""/> " &
                                                      "</w:rPr> " &
                                                     "</w:pPr> " &
                                                     "<w:r> " &
                                                      "<w:rPr> " &
                                                       "<w:sz w:val=""20""/> " &
                                                       "<w:szCs w:val=""20""/> " &
                                                      "</w:rPr> " &
                                                      "<w:t>- {0}</w:t> " &
                                                     "</w:r> " &
                                                    "</w:p>", oSqldrSite.Item("VSITNOM"))


        End If

        oSqldrSite.NextResult()

        If oSqldrSite.HasRows Then

          'on préfini l'ente du tableau 
          VLISTE_INV_SITE = VLISTE_INV_SITE & String.Format(Tableau_Inventaire_Modele_Site_Nom, VSITNOM) & Tableau_Inventaire_Modele_Entete_Col

          While oSqldrSite.Read()

            VLISTE_INV_SITE = VLISTE_INV_SITE & String.Format(Tableau_Inventaire_Modele_Line_Fou, oSqldrSite.Item("VFOUMAT"), oSqldrSite.Item("VEXTINVLMARQ"), oSqldrSite.Item("VEXTINVLNUMERO"), oSqldrSite.Item("NEXTINVLANNEE"), oSqldrSite.Item("VEXTINVEMPL"))

          End While

        End If

        oSqldrSite.Close()
      End If

    Next

    VLISTE_INV_SITE = VLISTE_INV_SITE & Tableau_Inventaire_Modele_Fin

    'on charge toutes les données
    Dim oSqlcmd As New SqlCommand("[api_sp_ImpCreateContratEI]", MozartDatabase.cnxMozart)

    oSqlcmd.CommandType = CommandType.StoredProcedure
    oSqlcmd.Parameters.Add("@p_NCLINUM", SqlDbType.Int).Value = _NCLINUM
    oSqlcmd.Parameters.Add("@p_NCCLNUM", SqlDbType.Int).Value = p_NCCLNUM

    Dim oSqlReader As SqlDataReader = oSqlcmd.ExecuteReader

    If oSqlReader.HasRows Then

      oSqlReader.Read()
      VCLINOM = oSqlReader.Item("VCLINOM")
      VCLIADRESSE = oSqlReader.Item("VCLIADRESSE")

      oSqlReader.NextResult()

      If oSqlReader.HasRows Then
        oSqlReader.Read()
        VCCLNOM = oSqlReader.Item("VCCLNOM")

      End If

      'montant des prestations
      oSqlReader.NextResult()

      If oSqlReader.HasRows Then

        'on préfini l'ente du tableau 
        VLISTE_PRESTATION_SITE = Tableau_Prestation_Modele

        While oSqlReader.Read()

          VLISTE_PRESTATION_SITE = VLISTE_PRESTATION_SITE & String.Format(Tableau_Prestation_Modele_Line_Fou, oSqlReader.Item("VFOUMAT"), oSqlReader.Item("NQTE"), oSqlReader.Item("PRIXBYEQUIP"), oSqlReader.Item("PRIXBYVISIT"), oSqlReader.Item("COLOR_QTE"), oSqlReader.Item("COLOR_PRIXBYEQUIP"), oSqlReader.Item("COLOR_PRIXBYVISIT"))

        End While

      End If

    End If
    oSqlReader.Close()

    If VLISTE_PRESTATION_SITE <> "" Then VLISTE_PRESTATION_SITE = VLISTE_PRESTATION_SITE & Tableau_Prestation_Modele_Fin

    'init
    FileOut = String.Format("{0}EI_CONTRAT_{1}.xml", MozartParams.CheminUtilisateurMozart, _NCLINUM)

    If File.Exists(fileRead) = False Then MessageBox.Show("le fichier modèle Contrat EI n'existe pas", "Erreur", MessageBoxButtons.OK, MessageBoxIcon.Error) : Exit Sub
    If File.Exists(FileOut) Then File.Delete(FileOut)

    'on charge le document modele xml
    Dim reader As StreamReader
    Dim Writer As New StreamWriter(FileOut)
    Dim line As String

    Try

      reader = File.OpenText(fileRead)

      While reader.Peek <> -1

        line = reader.ReadLine()

        Select Case True

          Case line.Contains("#VCLINOM#")
            line = line.Replace("#VCLINOM#", VCLINOM)
          Case line.Contains("#VCLIADR_COMPLETE#")
            line = line.Replace("#VCLIADR_COMPLETE#", VCLIADRESSE)
          Case line.Contains("#NOM_CONTACT_CLI#")
            line = line.Replace("#NOM_CONTACT_CLI#", VCCLNOM)
          Case line.Contains("#VLISTESITES#")
            line = line.Replace("#VLISTESITES#", VLISTESITE)
          Case line.Contains("#VLISTE_INV_SITE#")
            line = line.Replace("#VLISTE_INV_SITE#", VLISTE_INV_SITE)
          Case line.Contains("#VLISTE_PRESTA_SITE#")
            line = line.Replace("#VLISTE_PRESTA_SITE#", VLISTE_PRESTATION_SITE)
          Case line.Contains("#DATE_ENVOI#")
            line = line.Replace("#DATE_ENVOI#", Now.Date.ToShortDateString)
          Case line.Contains("#VSOCIETE#")
            line = line.Replace("#VSOCIETE#", MozartParams.NomSociete)
            'Case line.Contains("#SIGN_CHAFF#")
            '    line = line.Replace("#SIGN_CHAFF#", "sign_pinson.png")
            'Case line.Contains("#LOGO_SOCIETE#")
            '    line = line.Replace("#LOGO_SOCIETE#", "logo-emalec.jpg")
        End Select

        Writer.WriteLine(line)

      End While
      reader.Close()

    Catch ex As Exception
      MsgBox(ex.Message)
    End Try

    Writer.Close()

  End Sub

  Public Sub SaveDocRTF(ByVal p_VTEXTRTF As String)

    Dim osqlcmdSave As New SqlCommand("[api_sp_DocContEICreate]", MozartDatabase.cnxMozart)

    osqlcmdSave.CommandType = CommandType.StoredProcedure
    osqlcmdSave.Parameters.Add("@p_NIDDOCCONTEI", SqlDbType.Int).Value = _NIDDOCCONTEI
    osqlcmdSave.Parameters.Add("@p_NCLINUM", SqlDbType.Int).Value = _NCLINUM
    osqlcmdSave.Parameters.Add("@p_VFILENAME", SqlDbType.VarChar).Value = _VFILENAME
    osqlcmdSave.Parameters.Add("@p_VRTFTEXT", SqlDbType.VarChar).Value = p_VTEXTRTF

    _NIDDOCCONTEI = osqlcmdSave.ExecuteScalar

    LoadContratEI()

  End Sub

  Public Sub SaveContratEiSender()

    If _NIDDOCCONTEI > 0 Then

      Dim sqlcmdSaveSender As New SqlCommand("[api_sp_DocContEISaveSender]", MozartDatabase.cnxMozart)
      sqlcmdSaveSender.CommandType = CommandType.StoredProcedure
      sqlcmdSaveSender.Parameters.Add("@p_NIDDOCCONTEI", SqlDbType.Int).Value = _NIDDOCCONTEI

      sqlcmdSaveSender.ExecuteNonQuery()

    End If

  End Sub

  Public Sub SaveContratEiNoteClient()

    If _NIDDOCCONTEI > 0 Then

      Dim sqlcmdSaveNoteCli As New SqlCommand("[api_sp_DocContEISaveInfoClient]", MozartDatabase.cnxMozart)
      sqlcmdSaveNoteCli.CommandType = CommandType.StoredProcedure
      sqlcmdSaveNoteCli.Parameters.Add("@p_NCLINUM", SqlDbType.Int).Value = _NCLINUM

      sqlcmdSaveNoteCli.ExecuteNonQuery()

    End If

  End Sub

  Public Sub SaveContratEiByClient(ByVal p_sfilesrc As String)

    'on copy le fichier
    Dim fileOutSave As String = gstrCheminDocClientWeb & Path.GetFileName(p_sfilesrc)
    File.Copy(p_sfilesrc, fileOutSave, True)

    'on le sauvegarde dans tproc
    Dim sqlcmdSaveContratEI As New SqlCommand("[api_sp_creationProcedure]", MozartDatabase.cnxMozart)
    sqlcmdSaveContratEI.CommandType = CommandType.StoredProcedure
    sqlcmdSaveContratEI.Parameters.Add("@inumProc", SqlDbType.Int).Value = _NIDPROC
    sqlcmdSaveContratEI.Parameters.Add("@iCliNum", SqlDbType.Int).Value = _NCLINUM
    sqlcmdSaveContratEI.Parameters.Add("@iSitNum", SqlDbType.Int).Value = 0
    sqlcmdSaveContratEI.Parameters.Add("@vTitre", SqlDbType.VarChar).Value = "CONTRAT EI"
    sqlcmdSaveContratEI.Parameters.Add("@vFichier", SqlDbType.VarChar).Value = Path.GetFileName(fileOutSave)
    sqlcmdSaveContratEI.Parameters.Add("@iTypeProc", SqlDbType.Int).Value = 15
    sqlcmdSaveContratEI.Parameters.Add("@ddatvalid", SqlDbType.DateTime).Value = Now.Date
    sqlcmdSaveContratEI.Parameters.Add("@di", SqlDbType.Int).Value = 0
    sqlcmdSaveContratEI.Parameters.Add("@bactif", SqlDbType.Bit).Value = 1
    sqlcmdSaveContratEI.Parameters.Add("@dprocecheance", SqlDbType.DateTime).Value = DBNull.Value
    sqlcmdSaveContratEI.Parameters.Add("@bproctaciterecond", SqlDbType.Bit).Value = True

    _NIDPROC = sqlcmdSaveContratEI.ExecuteScalar

  End Sub

  Public Sub Reinit(ByVal p_FileOut As String)

    If File.Exists(p_FileOut) Then File.Delete(p_FileOut)

    If File.Exists(FileOut) Then File.Delete(FileOut)

    'on recharge les données
    LoadContratEI()

  End Sub

End Class
