Option Compare Text

Imports System
Imports System.Threading
Imports Microsoft.VisualBasic

Public Class GenEtat

  Shared sImgValue As String
  Shared sImgPath As String
  Public LastError As String = ""

#Region "Constantes & Structures"

  ' Erreurs relatives à la génération des modèles (PrepareModeleRTF)
  Const RTFErr_noErr As Integer = 0             ' Pas d'erreur
  Const RTFErr_AutreErr As Integer = 32767        ' Autre erreur

  Const RTFErr_noData As Integer = 10           ' Pas de données 

  ' Erreurs relatives aux accés fichiers
  Const RTFErr_OpenFile As Integer = 50         ' Erreur d'ouverture de fichier
  Const RTFErr_OpenFileModele As Integer = 51   ' Erreur d'ouverture de fichier modèle

  ' Erreurs relatives aux accés Base de données
  Const RTFErr_SQLErr As Integer = 100            ' Erreur sur la requete SQL
  Const RTFErr_ORDBYErr As Integer = 101          ' Erreur sur la clause ORDER BY

  ' Erreurs relatives aux format du fichier modèle
  Const RTFErr_noDetailSec As Integer = 200     ' Pas de section détail (alors qu'il y a une ou des ruptures)
  Const RTFErr_noDetailEnd As Integer = 201     ' Pas de fin de section détail
  Const RTFErr_noRuptureEnd As Integer = 202      ' Pas de fin de rupture

  ' Erreurs relatives à la génération des modèles (PrepareModeleRTF)
  Const RTFErr_NoTDBGlobal As Integer = 500     ' Tableau de données globales absent ou mal initialisé
  Const RTFErr_no2Col As Integer = 501            ' Le nombre de colonne du tableau de données globale n'est pas suffisant

  Const cstFrmFrmt As Integer = 0                                       ' La formule est un format
  Const cstChFrmt As String = "#=FORMAT("
  Const cstInitFrmt As Integer = 0

  Const cstFrmSomme As Integer = 1                                        ' La formule est une somme
  Const cstChSomme As String = "#=SOMME("
  Const cstInitSomme As Integer = 0

  Const cstFrmMax As Integer = 2                                          ' La formule est un max
  Const cstChMax As String = "#=MAX("
  Const cstInitMax As Double = -1.79769313486231E+308

  Const cstFrmMin As Integer = 3                                          ' La formule est un min
  Const cstChMin As String = "#=MIN("
  Const cstInitMin As Double = 1.79769313486231E+308

  Const cstFrmCount As Integer = 4                                       ' La formule est un compte
  Const cstChcount As String = "#=COMPTE("
  Const cstInitCompte As Integer = 0

  ' Type de donnée
  Structure Formule
    Public Champ As String                                           ' Champ sur lequel doit s'effectuer la formule
    Public Type As Long                                                 ' Modele de la formule
    Public Valeur As Object                                         ' Résultat de la formule
    Public NivRupt As Long                                              ' Niveau de rupture de calcul (-1 pout tout le temps)
    Public Format As String                                          ' Chaine de formatage de la donnée
  End Structure

  Structure Rupture
    Public Entete As String                                          ' Partie entete de la rupture
    Public Pied As String                                                ' Pied de la rupture
    Public Champ As String                                           ' Champ de rupture
    Public ValPrec As String                                         ' Valeur précédente
    Public FrmEntete() As Formule                                ' Formules dans l'entete
    Public FrmPied() As Formule                                  ' Formules dans le pied
  End Structure

  Function ReturnError(ByVal Ret As Long) As String
    Select Case Ret
      Case RTFErr_noErr
        ReturnError = "Pas d 'erreur"
      Case RTFErr_noData '= 10
        ReturnError = "Pas de données"
      Case RTFErr_OpenFile '= 50
        ReturnError = "Erreur d'ouverture de fichier"
      Case RTFErr_OpenFileModele '= 51
        ReturnError = "Erreur d'ouverture de fichier modele"
      Case RTFErr_SQLErr '= 100
        ReturnError = "Erreur sur la requete SQL"
      Case RTFErr_ORDBYErr '= 101
        ReturnError = "Erreur sur la clause ORDER BY"
      Case RTFErr_noDetailSec '= 200
        ReturnError = "Pas de section détail (alors qu'il y a une ou des ruptures)"
      Case RTFErr_noDetailEnd '= 201
        ReturnError = "Pas de fin de section détail"
      Case RTFErr_noRuptureEnd '= 202
        ReturnError = "Pas de fin de rupture"
      Case RTFErr_NoTDBGlobal '= 500   
        ReturnError = "Tableau de données globale invalide ou inexistant"
      Case RTFErr_no2Col '= 501
        ReturnError = "Nombre de colonnes du tableau de données globale insuffisant"
      Case RTFErr_AutreErr '= 32767
        ReturnError = "Autre erreur : " + vbCrLf + LastError
      Case Else
        ReturnError = ""
    End Select
  End Function
#End Region


  Function MkOrderBy(ByVal TdbRupture() As Rupture, ByVal sSql As String, ByRef cnxInterne As ADODB.Connection) As String
    '-----------------------------------------------------------------------------------
    ' NOM : MkOrderBy
    ' DESCRIPTION : Retourne la clause SQL Order by
    ' PARAMETRES :
    '           - TdbRupture()   : Tableau contenant la description des ruptures
    '           - sSql           : Requête SQL de base
    '           - cnxInterne            : connexion courante
    '-----------------------------------------------------------------------------------

    ' Parcours la liste des ruptures
    If Not TdbRupture Is Nothing Then
      Dim sClauseSql As String
      Dim rcsRecValue As New ADODB.Recordset

      rcsRecValue.Open(sSql, cnxInterne, ADODB.CursorTypeEnum.adOpenKeyset, ADODB.LockTypeEnum.adLockOptimistic)
      sClauseSql = " ORDER BY "           ' Initialise la clause ORDER BY

      For i As Integer = LBound(TdbRupture) To UBound(TdbRupture)
        ' Ajoute les champs dans l'ordre
        If Not (rcsRecValue(TdbRupture(i).Champ).Properties("basetablename") Is Nothing) Then
          sClauseSql += rcsRecValue(TdbRupture(i).Champ).Properties("basecolumnname").Value & ", "
        Else
          sClauseSql += rcsRecValue(TdbRupture(i).Champ).Properties("basetablename").Value & "." & rcsRecValue(TdbRupture(i).Champ).Properties("basecolumnname").Value & ", "
        End If
      Next
      rcsRecValue.Close()

      ' Supprime la dernière virgule
      Return Left(sClauseSql, Len(sClauseSql) - 2)
    Else
      Return ""
    End If
  End Function

  Function NbRupture(ByVal TdbRupture() As Rupture) As Long
    '-----------------------------------------------------------------------------------
    ' NOM : NbRupture
    ' DESCRIPTION : Retourne le nombre de rupture dans l'état
    ' PARAMETRES :
    '           - TdbRupture()   : Tableau contenant la description des ruptures
    '-----------------------------------------------------------------------------------

    If TdbRupture Is Nothing Then
      Return 0
    Else
      ' Retourne le nombre de ruptures
      Return UBound(TdbRupture) - LBound(TdbRupture) + 1
    End If

  End Function

  Function ExtractEntete(ByVal sFichier As String) As String
    '-----------------------------------------------------------------------------------
    ' NOM : ExtractEntete
    ' DESCRIPTION : Extrait la section Entete du fichier RTF
    ' PARAMETRES :
    '           - sFichier      : Le contenu du fichier RTF
    ' RETOUR :
    '           Retourne une chaine contenant la partie entete du fichier RTF
    '-----------------------------------------------------------------------------------

    Dim pos As Integer

    ' Recherche d'une rupture
    pos = InStr(sFichier, "[/")

    ' Si une rupture a été trouvée
    If pos > 0 Then
      ' Extrait la section Entete
      Return Left(sFichier, pos - 1)
    Else
      ' Recherche d'une répétition
      pos = InStr(sFichier, "[&")
      ' Si une répétition a été trouvée
      If pos > 0 Then
        Return Left(sFichier, pos - 1)      ' Extrait la section Entete
      Else
        Return sFichier     ' La zone entete est le fichier entier
      End If
    End If

  End Function

  Function ExtractRupture(ByRef sFichier As String, ByRef sDetail As String, ByRef TdbRupture() As Rupture) As Long
    '-----------------------------------------------------------------------------------
    ' NOM : ExtractRupture
    ' DESCRIPTION : Extrait les ruptures
    ' PARAMETRES :
    '           - sFichier      : Le contenu du fichier RTF
    '           - sDetail       : Le contenu de la section détail
    '           - TdbRupture()  : Tableau contenant les informations de ruptures
    ' RETOUR :  Retourne une chaine contenant la partie entete du fichier RTF
    '-----------------------------------------------------------------------------------

    Dim indice As Integer   ' Indice de la rupture
    Dim pos As Integer

    ' Il n'y a pas de rupture
    If Left(sFichier, Len("[/")) <> "[/" Then

      ' On recherche la section détail
      If Left(sFichier, Len("[&")) = "[&" Then
        ' On supprime '[&'
        sFichier = Mid(sFichier, Len("[&") + 1)
        ' On recherche la fin de la section détail
        pos = InStr(sFichier, "]&")
        ' Il n'y a pas de fin de section détail
        If pos = 0 Then Return RTFErr_noDetailEnd : Exit Function
        ' On extrait la section détail
        sDetail = Left(sFichier, pos - 1)
        ' On supprime la section détail de sFichier
        sFichier = Mid(sFichier, pos + Len("]&"))
      End If
      ' Ce qui reste dans sFichier est le pied de l'état
    Else

      ' Tant qu'il y a des ruptures
      While Left(sFichier, Len("[/")) = "[/"

        ' Nouvelle indice pour la rupture 
        If TdbRupture Is Nothing Then
          ' Ajoute une entrée au tableau de description des ruptures
          indice = 0
          ReDim TdbRupture(0)
        Else
          ' si tableau sans dimension, création tableau à une dimension
          indice = UBound(TdbRupture) + 1
          ReDim Preserve TdbRupture(indice)
        End If

        ' On supprime '[/#'
        sFichier = Mid(sFichier, Len("[/#"))

        pos = InStr(sFichier, "#")

        TdbRupture(indice).Entete = Left(sFichier, pos - 1)

        sFichier = Mid(sFichier, pos + 1)

        ' Extraction de la position de la fin du champ
        pos = InStr(sFichier, "#")

        ' Extraction du champ de rupture
        TdbRupture(indice).Champ = Left(sFichier, pos - 1)

        ' On supprime le champ de rupture
        sFichier = Mid(sFichier, pos + 1)

        ' On recherche la prochaine rupture
        pos = InStr(sFichier, "[/")

        ' On a trouvé la prochaine rupture
        If pos <> 0 Then
          ' On extrait l'entete de rupture
          TdbRupture(indice).Entete = TdbRupture(indice).Entete & Left(sFichier, pos - 1)
          ' On supprime l'entete de rupture
          sFichier = Mid(sFichier, pos)
        Else
          ' On recherche la section détail
          pos = InStr(sFichier, "[&")
          ' On a trouvé la section détail
          If pos <> 0 Then
            ' On extrait l'entete de rupture
            TdbRupture(indice).Entete = Left(sFichier, pos - 1)
            ' On supprime l'entete de rupture
            sFichier = Mid(sFichier, pos)
          Else
            ' Erreur, il n'y a pas de section detail
            Return RTFErr_noDetailSec
            Exit Function
          End If
        End If
      End While

      ' On supprime la fin d'occurence
      sFichier = Mid(sFichier, Len("[&") + 1)
      ' On recherche la fin de la section détail
      pos = InStr(sFichier, "]&")
      ' Il n'y a pas de fin de section détail
      If pos = 0 Then Return RTFErr_noDetailEnd : Exit Function

      ' On extrait la section détail
      sDetail = Left(sFichier, pos - 1)

      ' On supprime la section détail de sFichier
      sFichier = Mid(sFichier, pos + Len("]&"))

      ' On remonte les ruptures
      For indice = UBound(TdbRupture) To LBound(TdbRupture) Step -1

        ' On recherche la fin du pied de rupture
        pos = InStr(sFichier, "/]")

        ' Vérifie l'existence de la fin de rupture
        If pos = 0 Then Return RTFErr_noRuptureEnd : Exit Function
        ' On extrait le pied de rupture
        TdbRupture(indice).Pied = Left(sFichier, pos - 1)
        ' On supprime le pied de rupture dans sFichier
        sFichier = Mid(sFichier, pos + Len("/]"))
      Next indice
    End If
    Return RTFErr_noErr

  End Function

  Function RechercheFormule(ByRef TdbRupture() As Rupture, ByVal TdbGlobal(,) As String) As Long
    '-----------------------------------------------------------------------------------
    ' NOM : RechercheFormule
    ' DESCRIPTION : Recherche les formules dans les entetes et pieds de ruptures
    ' PARAMETRES :
    '           - TdbGlobal()     : Tableau des données globales
    ' RETOUR :
    '           Retourne une chaine contenant la partie entete du fichier RTF
    '-----------------------------------------------------------------------------------
    Dim TdbMin As Integer, TdbMax As Integer, CodeErr As Integer

    If Not TdbRupture Is Nothing Then
      TdbMin = LBound(TdbRupture)
      TdbMax = UBound(TdbRupture)

      ' Pour toute les ruptures
      For i As Integer = TdbMin To TdbMax
        ' Pour l'entete
        CodeErr = ExtraitFormule(TdbRupture(i).Entete, TdbRupture(i).FrmEntete, TdbGlobal)
        If CodeErr <> RTFErr_noErr Then Return CodeErr : Exit Function

        ' Pour le pied
        CodeErr = ExtraitFormule(TdbRupture(i).Pied, TdbRupture(i).FrmPied, TdbGlobal)
        If CodeErr <> RTFErr_noErr Then Return CodeErr : Exit Function
      Next i
    End If

    Return RTFErr_noErr

  End Function

  Function ExtraitFormule(ByVal Chaine As String, ByRef TdbFormule() As Formule, ByVal TdbGlobal(,) As String) As Long
    '-----------------------------------------------------------------------------------
    ' NOM : ExtraitFormule
    '-----------------------------------------------------------------------------------

    Dim Ret As Integer = RTFErr_AutreErr

    ' Recherche la fonction Format
    Ret = Extrait1Formule(Chaine, TdbFormule, cstFrmFrmt, cstChFrmt, cstInitFrmt, TdbGlobal)
    If Ret <> RTFErr_noErr Then Return Ret : Exit Function

    ' Recherche la fonction Max
    Ret = Extrait1Formule(Chaine, TdbFormule, cstFrmMax, cstChMax, cstInitMax, TdbGlobal)
    If Ret <> RTFErr_noErr Then Return Ret : Exit Function

    ' Recherche la fonction Somme
    Ret = Extrait1Formule(Chaine, TdbFormule, cstFrmSomme, cstChSomme, cstInitSomme, TdbGlobal)
    If Ret <> RTFErr_noErr Then Return Ret : Exit Function

    ' Recherche la fonction Min
    Ret = Extrait1Formule(Chaine, TdbFormule, cstFrmMin, cstChMin, cstInitMin, TdbGlobal)
    If Ret <> RTFErr_noErr Then Return Ret : Exit Function

    ' Recherche la fonction Compte
    Ret = Extrait1Formule(Chaine, TdbFormule, cstFrmCount, cstChcount, cstInitCompte, TdbGlobal)
    If Ret <> RTFErr_noErr Then Return Ret : Exit Function

    Return RTFErr_noErr

  End Function

  Function Extrait1Formule(ByVal Chaine As String, ByRef TdbFormule() As Formule, ByVal cstFrm As Integer, ByVal chFrm As String, ByVal initVal As Double, ByVal TdbGlobal(,) As String) As Long
    '-----------------------------------------------------------------------------------
    ' NOM : Extrait1Formule
    '-----------------------------------------------------------------------------------

    Dim pos As Integer
    Dim sWChaine As String
    Dim TdbMax As Integer = 0
    Dim posDieze As Integer, posPoint As Integer, posCote As Integer
    Dim IndMinRow As Integer = 0
    Dim IndMinCol As Integer = 0
    Dim IndMaxRow As Integer = 0
    Dim IndMaxCol As Integer = 0

    sWChaine = Chaine

    ' Recherche d'une formule
    pos = InStr(sWChaine, chFrm)

    ' On a trouvé une formule
    While pos > 0

      ' Récupère les dimensions du tableau des variables globlaes
      If Not TdbGlobal Is Nothing Then
        IndMinRow = LBound(TdbGlobal, 1)
        IndMinCol = LBound(TdbGlobal, 2)
        IndMaxRow = UBound(TdbGlobal, 1)
        IndMaxCol = UBound(TdbGlobal, 2)
      End If

      If Not TdbFormule Is Nothing Then
        TdbMax = UBound(TdbFormule) + 1
        ' Redimensionne le tableau
        ReDim Preserve TdbFormule(0 To TdbMax)
      Else
        ReDim TdbFormule(0 To 0)
        TdbMax = 0
      End If

      TdbFormule(TdbMax).Type = cstFrm
      TdbFormule(TdbMax).Valeur = initVal#

      If Mid(sWChaine, pos + Len(chFrm), 1) = "#" Then
        ' Extrait le reste de la chaine
        TdbFormule(TdbMax).Champ = Mid(sWChaine, pos + Len(chFrm) + 1)
        ' On calcul la somme à chaque changement d'enregistrement
        TdbFormule(TdbMax).NivRupt = -1
        ' Récupère la position  du # fermant le champ
        posDieze = InStr(TdbFormule(TdbMax).Champ, "#")
        ' Extrait le champ
        TdbFormule(TdbMax).Champ = Left(TdbFormule(TdbMax).Champ, posDieze - 1)
        ' Extrait le format
        TdbFormule(TdbMax).Format = Mid(sWChaine, pos + Len(TdbFormule(TdbMax).Champ) + Len(chFrm) + 2)

        ' Vérifie si un format existe
        If Left(TdbFormule(TdbMax).Format, 1) = "," Then
          ' supprime ,"
          TdbFormule(TdbMax).Format = Mid(TdbFormule(TdbMax).Format, 3)
          ' Recherche la fin de chaine de format
          posCote = InStr(TdbFormule(TdbMax).Format, """")
          ' Extrait le format
          TdbFormule(TdbMax).Format = Left(TdbFormule(TdbMax).Format, posCote - 1)
          ' Supprime le champ de la chaine de travail
          sWChaine = Left(sWChaine, pos - 2) + Mid(sWChaine, pos + Len(TdbFormule(TdbMax).Champ) + Len(TdbFormule(TdbMax).Format) + Len(chFrm) + 7)
        Else
          TdbFormule(TdbMax).Format = ""
          ' Supprime le champ de la chaine de travail
          sWChaine = Left(sWChaine, pos - 1) + Mid(sWChaine, pos + Len(TdbFormule(TdbMax).Champ) + Len(chFrm) + 4)
        End If

      Else

        ' Extrait le reste de la chaine
        TdbFormule(TdbMax).Champ = Mid(sWChaine, pos + Len(chFrm))
        posPoint = InStr(TdbFormule(TdbMax).Champ, ".")
        ' On calcul la somme à une rupture particulière
        TdbFormule(TdbMax).NivRupt = Val(Left(TdbFormule(TdbMax).Champ, posPoint - 1))
        ' On supprime jusqu'au premier #
        TdbFormule(TdbMax).Champ = Mid(TdbFormule(TdbMax).Champ, posPoint + 2)
        ' Récupère la position  du dièze fermant le champ
        posDieze = InStr(TdbFormule(TdbMax).Champ, "#")
        ' Extrait le champ
        TdbFormule(TdbMax).Champ = Left(TdbFormule(TdbMax).Champ, posDieze - 1)
        ' Extrait le format
        TdbFormule(TdbMax).Format = Mid(sWChaine, pos + Len(TdbFormule(TdbMax).Format) + Len(Trim(Str(TdbFormule(TdbMax).NivRupt))) + Len(TdbFormule(TdbMax).Champ) + Len(chFrm) + 3)

        ' Vérifie si un format existe
        If Left(TdbFormule(TdbMax).Format, 1) = "," Then
          ' supprime ,"
          TdbFormule(TdbMax).Format = Mid(TdbFormule(TdbMax).Format, 3)
          ' Recherche la fin de chaine de format
          posCote = InStr(TdbFormule(TdbMax).Format, """")
          ' Extrait le format
          TdbFormule(TdbMax).Format = Left(TdbFormule(TdbMax).Format, posCote - 1)
          ' Supprime le champ de la chaine de travail
          sWChaine = Left(sWChaine, pos - 2) + Mid(sWChaine, pos + Len(TdbFormule(TdbMax).Champ) + Len(Trim(Str(TdbFormule(TdbMax).NivRupt))) + Len(TdbFormule(TdbMax).Format) + Len(chFrm) + 7)
        Else
          TdbFormule(TdbMax).Format = ""
          ' Supprime le champ de la chaine de travail
          sWChaine = Left(sWChaine, pos - 2) + Mid(sWChaine, pos + Len(TdbFormule(TdbMax).Champ) + Len(Trim(Str(TdbFormule(TdbMax).NivRupt))) + Len(chFrm) + 5)
        End If
      End If

      If Not TdbGlobal Is Nothing Then
        ' On parcours le tableau des données globales
        For i As Integer = IndMinRow To IndMaxRow
          ' Si il y a une variable globale
          If Trim(TdbGlobal(i, IndMinCol)) <> "" And Not TdbGlobal(i, IndMinCol) Is Nothing Then
            If Trim(TdbGlobal(i, IndMinCol)) = Trim(TdbFormule(TdbMax).Champ) Then
              TdbFormule(TdbMax).Valeur = TdbGlobal(i, IndMaxCol)
            End If
          End If
        Next i
      End If

      ' Recherche de la somme suivante
      pos = InStr(sWChaine, chFrm)
    End While

    Return RTFErr_noErr

  End Function

  Function WriteEntete(ByVal FicFin As String, ByVal Entete As String, ByVal rsData As ADODB.Recordset, ByVal TdbGlobal(,) As String, ByRef TdbFormule() As Formule) As Long
    '-----------------------------------------------------------------------------------
    ' NOM : WriteEntete
    ' DESCRIPTION : Ecrit la partie entete du fichier RTF
    ' PARAMETRES :
    '           - FicFin         : Le fichier RTF en sortie
    '           - Entete         : Les informations de l'entete
    '           - rsData         : Les données
    '           - TdbGlobal()     : Tableau des données globales
    ' RETOUR :
    '           Retourne une chaine contenant la partie entete du fichier RTF
    '-----------------------------------------------------------------------------------

    Dim pos As Integer = 0
    Dim IndMinCol As Integer, IndMaxCol As Integer
    Dim IndMinRow As Integer, IndMaxRow As Integer
    Dim i As Integer
    Dim ToSearch As String
    Dim NFicRTF As Integer
    Dim NbCol As Integer
    Dim ret As Integer = RTFErr_AutreErr

    ret = InsereResFormule(Entete, TdbFormule)
    If ret <> RTFErr_noErr Then Return ret : Exit Function

    If Not TdbGlobal Is Nothing Then
      ' Récupère les dimensions du tableau
      IndMinRow = LBound(TdbGlobal, 1) : IndMinCol = LBound(TdbGlobal, 2)
      IndMaxRow = UBound(TdbGlobal, 1) : IndMaxCol = UBound(TdbGlobal, 2)

      ' Parcours le tableau
      For i = IndMinRow To IndMaxRow
        Do
          ' Si il y a une variable globale
          If Trim(TdbGlobal(i, IndMinCol)) <> "" And Not TdbGlobal(i, IndMinCol) Is Nothing Then
            ' Crée la chaine à retrouver
            ToSearch = "#" & Trim(TdbGlobal(i, IndMinCol)) & "#"
            ' Recherche le champ
            pos = InStr(Entete, ToSearch)
            ' Si le champ a été trouvé
            If pos <> 0 Then
              If Not TdbGlobal(i, IndMaxCol) Is Nothing Then
                ' Insère directement la valeur
                Entete = Left(Entete, pos - 1) & Trim(TdbGlobal(i, IndMaxCol)) & Mid(Entete, pos + Len(ToSearch))
              Else
                ' Affiche rien
                Entete = Left(Entete, pos - 1) & "" & Mid(Entete, pos + Len(ToSearch))
              End If
            End If
          End If
          ' Répeter l'opération tant que l'on trouve le champ
        Loop Until pos = 0
        ' On passe au champ suivant
      Next i
    End If

    ' Test s'il y a des enregistrements
    If rsData.RecordCount > 0 Then
      ' Récupère le nombre de champs
      NbCol = rsData.Fields.Count
      ' Parcours la liste des champs
      For i = 0 To NbCol - 1
        Do
          ' Crée la chaine à retrouver
          ToSearch = "#" & rsData(i).Name & "#"
          ' Recherche le champ
          pos = InStr(Entete, ToSearch)
          ' Si le champ a été trouvé
          If pos <> 0 Then
            If Not rsData(i).Value Is DBNull.Value Then
              ' Insère directement la valeur
              Entete = Left(Entete, pos - 1) & Trim(CStr(rsData(i).Value)) & Mid(Entete, pos + Len(ToSearch))
            Else
              ' Affiche NULL
              Entete = Left(Entete, pos - 1) & "" & Mid(Entete, pos + Len(ToSearch))
            End If
          End If
          ' Répeter l'opération tant que l'on trouve le champ
        Loop Until pos = 0
        ' On passe au champ suivant
      Next i
    End If

    ' Récupère un handle valide
    NFicRTF = FreeFile()

    ' Ouverture du fichier RTF en sortie
    FileOpen(NFicRTF, FicFin, OpenMode.Output)

    ' Erreur à l 'ouverture du fichier
    If Err.Number <> 0 Then Return RTFErr_OpenFile : Exit Function

    ' Ecrit la partie entete du fichier RTF
    Print(NFicRTF, Entete)
    FileClose(NFicRTF)
    Return RTFErr_noErr

  End Function

  'Function GenImages(ByVal FicFin As String, ByVal rsData As ADODB.Recordset) As Long
  '	Dim Pos As Integer = 0
  '	Dim IndMinCol As Integer, IndMaxCol As Integer
  '	Dim IndMinRow As Integer, IndMaxRow As Integer
  '	Dim i As Integer
  '	Dim ToSearch As String
  '	Dim NFicRTF As Integer
  '	Dim NbCol As Integer
  '	Dim Data As String
  '	Dim ret As Integer

  '	' Récupère un numéro de fichier valide
  '	NFicRTF = FreeFile()
  '	FileOpen(NFicRTF, FicFin, OpenMode.Binary)

  '	' Erreur à l 'ouverture du fichier
  '	If Err.Number <> 0 Then Return RTFErr_OpenFile : Exit Function

  '	Data = Space(LOF(NFicRTF))

  '	' Lecture du fichier et Fermeture du fichier
  '	FileGet(NFicRTF, Data)
  '	FileClose(NFicRTF)

  '	' Test s'il y a des enregistrements
  '	If rsData.RecordCount > 0 Then
  '		' Récupère le nombre de champs
  '		NbCol = rsData.Fields.Count
  '		' Parcours la liste des champs
  '		For i = 0 To NbCol - 1
  '			Do
  '				' Crée la chaine à retrouver
  '				ToSearch = "%%" & rsData(i).Name & "%%"
  '				' Recherche le champ
  '				Pos = InStr(Data, ToSearch)
  '				' Si le champ a été trouvé
  '				If Pos <> 0 Then
  '					If Not rsData(i) Is Nothing Then
  '						' Insère directement la valeur
  '						sImgPath = CStr(rsData(i).Value)

  '						'GetImageValue()

  '						Dim th As New Thread(AddressOf GetImageValue)
  '						th.SetApartmentState(ApartmentState.STA)
  '						th.Start()
  '						Thread.Sleep(0)
  '						th.Join()

  '						Data = Left(Data, Pos - 1) & sImgValue & Mid(Data, Pos + Len(ToSearch))
  '					Else
  '						' Affiche NULL
  '						Data = Left(Data, Pos - 1) & "" & Mid(Data, Pos + Len(ToSearch))
  '					End If
  '				End If
  '				' Répeter l'opération tant que l'on trouve le champ
  '			Loop Until Pos = 0
  '			' On passe au champ suivant
  '		Next i
  '	End If

  '	' Récupère un handle valide
  '	NFicRTF = FreeFile()

  '	On Error Resume Next

  '	' Ouverture du fichier RTF en sortie
  '	FileOpen(NFicRTF, FicFin, OpenMode.Output)
  '	If Err.Number <> RTFErr_noErr Then Return RTFErr_OpenFile : Exit Function

  '	' Ecrit la partie entete du fichier RTF
  '	Print(NFicRTF, Data)
  '	FileClose(NFicRTF)

  '	Return RTFErr_noErr

  'End Function

  'Public Shared Sub GetImageValue()
  '	Try

  '		Dim sImageString As String = ""

  '		Dim img As System.Drawing.Image
  '		img = System.Drawing.Image.FromFile(sImgPath)
  '		Clipboard.SetImage(img)

  '		Dim rtb As New RichTextBox
  '		rtb.Paste()

  '		sImgValue = rtb.Rtf.Substring(rtb.Rtf.IndexOf("{\pict\"))
  '		sImgValue = sImgValue.Substring(0, sImgValue.IndexOf("}") + 1)

  '	Catch ex As Exception
  '		sImgValue = ""
  '	End Try

  'End Sub

  Function GenSection(ByVal FicFin As String, ByVal Section As String, ByVal rsData As ADODB.Recordset, ByVal TdbGlobal(,) As String, ByRef TdbFormule() As Formule) As Long
    '-----------------------------------------------------------------------------------
    ' NOM : GenSection
    ' DESCRIPTION : Ecrit la partie entete du fichier RTF
    ' PARAMETRES :
    '           - FicFin         : Le fichier RTF en sortie
    '           - Section        : Les informations de la section
    '           - rsData         : Les données
    '           - TdbGlobal()     : Tableau des données globales
    ' RETOUR :
    '           Retourne une chaine contenant la partie entete du fichier RTF
    '-----------------------------------------------------------------------------------

    Dim pos As Integer = 0
    Dim IndMinCol As Integer, IndMaxCol As Integer
    Dim IndMinRow As Integer, IndMaxRow As Integer
    Dim i As Integer
    Dim ToSearch As String
    Dim NFicRTF As Integer
    Dim NbCol As Integer
    Dim Data As String
    Dim ret As Integer = RTFErr_AutreErr

    ' Travaille sur une copie de Section
    Data = Section

    ret = InsereResFormule(Data, TdbFormule)
    If ret <> RTFErr_noErr Then Return ret : Exit Function

    If Not TdbGlobal Is Nothing Then
      ' Récupère les dimensions du tableau
      IndMinRow = LBound(TdbGlobal, 1) : IndMinCol = LBound(TdbGlobal, 2)
      IndMaxRow = UBound(TdbGlobal, 1) : IndMaxCol = UBound(TdbGlobal, 2)

      ' Parcours le tableau
      For i = IndMinRow To IndMaxRow
        Do
          ' Si il y a une variable globale
          If Trim(TdbGlobal(i, IndMinCol)) <> "" And Not TdbGlobal(i, IndMinCol) Is Nothing Then
            ' Crée la chaine à retrouver
            ToSearch = "#" & Trim(TdbGlobal(i, IndMinCol)) & "#"
            ' Recherche le champ
            pos = InStr(Data, ToSearch)
            ' Si le champ a été trouvé
            If pos <> 0 Then
              If Not TdbGlobal(i, IndMaxCol - 1) Is Nothing Then
                ' Insère directement la valeur
                Data = Left(Data, pos - 1) & Trim(TdbGlobal(i, IndMaxCol)) & Mid(Data, pos + Len(ToSearch))
              Else
                ' Affiche ""  (vide)
                Data = Left(Data, pos - 1) & "" & Mid(Data, pos + Len(ToSearch))
              End If
            End If
          End If

          ' Répeter l'opération tant que l'on trouve le champ
        Loop Until pos = 0

        ' On passe au champ suivant
      Next i
    End If

    ' Test s'il y a des enregistrements
    If rsData.RecordCount > 0 Then
      ' Récupère le nombre de champs
      NbCol = rsData.Fields.Count
      ' Parcours la liste des champs
      For i = 0 To NbCol - 1
        Do
          ' Crée la chaine à retrouver
          ToSearch = "#" & rsData(i).Name & "#"
          ' Recherche le champ
          pos = InStr(Data, ToSearch)
          ' Si le champ a été trouvé
          If pos <> 0 Then
            If Not rsData(i).Value Is DBNull.Value Then
              ' Insère directement la valeur
              Data = Left(Data, pos - 1) & Trim(CStr(rsData(i).Value)) & Mid(Data, pos + Len(ToSearch))
            Else
              ' Affiche NULL
              Data = Left(Data, pos - 1) & "" & Mid(Data, pos + Len(ToSearch))
            End If
          End If
          ' Répeter l'opération tant que l'on trouve le champ
        Loop Until pos = 0
        ' On passe au champ suivant
      Next i
    End If

    ' Récupère un handle valide
    NFicRTF = FreeFile()

    On Error Resume Next

    ' Ouverture du fichier RTF en sortie
    FileOpen(NFicRTF, FicFin, OpenMode.Append)
    If Err.Number <> RTFErr_noErr Then Return RTFErr_OpenFile : Exit Function

    ' Ecrit la partie entete du fichier RTF
    Print(NFicRTF, Data)
    FileClose(NFicRTF)

    Return RTFErr_noErr

  End Function

  Function RuptureCassee(ByVal rsData As ADODB.Recordset, ByVal TdbRupt() As Rupture) As Long
    '-----------------------------------------------------------------------------------
    ' NOM : RuptureCassee
    ' DESCRIPTION : Permet de savoir si une rupture est cassée
    ' PARAMETRES :
    '           - rsData       : Recordset associé à l'état
    '           - TdbRupt       : Tableau contenant la description des ruptures
    ' RETOUR :  -1 si aucune rupture n'a été cassé,
    '           l'indice dans le tableau TdbRupt de la rupture de plus haut niveau qui
    '           a été cassé
    '-----------------------------------------------------------------------------------

    Dim IndMinRupt As Integer, IndMaxRupt As Integer
    Dim i As Integer

    If Not TdbRupt Is Nothing Then
      ' Récupère la taille du tableau de description des ruptures
      IndMinRupt = LBound(TdbRupt)
      IndMaxRupt = UBound(TdbRupt)

      ' Initialise les valeurs précédentes
      For i = IndMinRupt To IndMaxRupt
        ' Test si la rupture a été cassée
        If TdbRupt(i).ValPrec <> rsData(TdbRupt(i).Champ).Value Then
          ' Retourne l'indice de la rupture cassée
          TdbRupt(i).ValPrec = rsData(TdbRupt(i).Champ).Value
          Return i
          Exit Function
        End If
      Next i
    End If
    Return -1

  End Function

  Function InsereResFormule(ByRef Chaine As String, ByVal TdbFormule() As Formule) As Long
    '-----------------------------------------------------------------------------------
    ' NOM : InsereResFormule
    ' DESCRIPTION : Insere le résultat d'une formule
    ' PARAMETRES :
    '           - Chaine       : Chaine à modifier
    ' RETOUR :
    ' REMARQUES :
    '-----------------------------------------------------------------------------------
    'Try
    Dim TdbMax As Integer, pos As Integer
    Dim ToSearch As String = "", ToSearchSsFrmt As String = ""
    Dim Valeur As String = ""
    Dim Data As String
    Dim double_valeur As Double = 0.0
    Dim date_valeur As Date = Date.MinValue

    Data = Chaine
    On Error Resume Next

    If Not TdbFormule Is Nothing Then
      TdbMax = UBound(TdbFormule)
      For i As Integer = 0 To TdbMax
        Select Case TdbFormule(i).Type
          Case cstFrmFrmt
            ToSearch = cstChFrmt & "#" & TdbFormule(i).Champ & "#,""" & TdbFormule(i).Format & """)#"
            Valeur = TdbFormule(i).Valeur
          Case cstFrmSomme
            If TdbFormule(i).NivRupt = -1 Then
              ToSearchSsFrmt = cstChSomme & "#" & TdbFormule(i).Champ & "#)#"
              ToSearch = cstChSomme & "#" & TdbFormule(i).Champ & "#,""" & TdbFormule(i).Format & """)#"
            Else
              ToSearchSsFrmt = cstChSomme & Trim(Str(TdbFormule(i).NivRupt)) & ".#" & TdbFormule(i).Champ & "#)#"
              ToSearch = cstChSomme & Trim(Str(TdbFormule(i).NivRupt)) & ".#" & TdbFormule(i).Champ & "#,""" & TdbFormule(i).Format & """)#"
            End If
            Valeur = TdbFormule(i).Valeur
            TdbFormule(i).Valeur = cstInitSomme
          Case cstFrmMax
            If TdbFormule(i).NivRupt = -1 Then
              ToSearchSsFrmt = cstChMax & "#" & TdbFormule(i).Champ & "#)#"
              ToSearch = cstChMax & "#" & TdbFormule(i).Champ & "#,""" & TdbFormule(i).Format & """)#"
            Else
              ToSearchSsFrmt = cstChMax & Trim(Str(TdbFormule(i).NivRupt)) & ".#" & TdbFormule(i).Champ & "#)#"
              ToSearch = cstChMax & Trim(Str(TdbFormule(i).NivRupt)) & ".#" & TdbFormule(i).Champ & "#,""" & TdbFormule(i).Format & """)#"
            End If
            Valeur = TdbFormule(i).Valeur
            TdbFormule(i).Valeur = cstInitMax
          Case cstFrmMin
            If TdbFormule(i).NivRupt = -1 Then
              ToSearchSsFrmt = cstChMin & "#" & TdbFormule(i).Champ & "#)#"
              ToSearch = cstChMin & "#" & TdbFormule(i).Champ & "#,""" & TdbFormule(i).Format & """)#"
            Else
              ToSearchSsFrmt = cstChMin & Trim(Str(TdbFormule(i).NivRupt)) & ".#" & TdbFormule(i).Champ & "#)#"
              ToSearch = cstChMin & Trim(Str(TdbFormule(i).NivRupt)) & ".#" & TdbFormule(i).Champ & "#,""" & TdbFormule(i).Format & """)#"
            End If
            Valeur = TdbFormule(i).Valeur
            TdbFormule(i).Valeur = cstInitMin
          Case cstFrmCount
            If TdbFormule(i).NivRupt = -1 Then
              ToSearchSsFrmt = cstChcount & "#" & TdbFormule(i).Champ & "#)#"
              ToSearch = cstChcount & "#" & TdbFormule(i).Champ & "#,""" & TdbFormule(i).Format & """)#"
            Else
              ToSearchSsFrmt = cstChcount & Trim(Str(TdbFormule(i).NivRupt)) & ".#" & TdbFormule(i).Champ & "#)#"
              ToSearch = cstChcount & Trim(Str(TdbFormule(i).NivRupt)) & ".#" & TdbFormule(i).Champ & "#,""" & TdbFormule(i).Format & """)#"
            End If
            Valeur = TdbFormule(i).Valeur
            TdbFormule(i).Valeur = cstInitCompte
        End Select

        If TdbFormule(i).Format = "" And ToSearchSsFrmt <> "" Then
          pos = InStr(Data, ToSearchSsFrmt)
          While pos > 0
            Data = Left(Data, pos - 1) & Format(Valeur) & Mid(Data, pos + Len(ToSearchSsFrmt))
            pos = InStr(Data, ToSearchSsFrmt)
          End While
        End If

        pos = InStr(Data, ToSearch)

        While pos > 0
          If Double.TryParse(Valeur, double_valeur) Then
            Data = Left(Data, pos - 1) & Format(double_valeur, "## ##" & TdbFormule(i).Format) & Mid(Data, pos + Len(ToSearch))
          ElseIf Date.TryParse(Valeur, date_valeur) Then
            Data = Left(Data, pos - 1) & Format(date_valeur, TdbFormule(i).Format) & Mid(Data, pos + Len(ToSearch))
          Else
            Data = Left(Data, pos - 1) & Valeur & Mid(Data, pos + Len(ToSearch))
          End If
          pos = InStr(Data, ToSearch)
        End While

      Next i
    End If

    Chaine = Data
    Return RTFErr_noErr

    'Catch ex As Exception
    '  Return RTFErr_AutreErr
    'End Try

  End Function

  Function MkCalcul(ByRef TdbFormule() As Formule, ByVal rsData As ADODB.Recordset, ByVal NivRupt As Long) As Long
    '-----------------------------------------------------------------------------------
    ' NOM : MkCalcul
    '-----------------------------------------------------------------------------------
    'Try
    On Error Resume Next
    If Not TdbFormule Is Nothing Then

      Dim FrmMax As Integer = (TdbFormule.Length() - 1), j As Integer

      For j = 0 To FrmMax
        Select Case TdbFormule(j).Type
          Case cstFrmFrmt
            TdbFormule(j).Valeur = rsData(TdbFormule(j).Champ).Value
          Case cstFrmSomme
            If TdbFormule(j).NivRupt = -1 Or TdbFormule(j).NivRupt >= NivRupt Then
              TdbFormule(j).Valeur = TdbFormule(j).Valeur + CDbl(rsData(TdbFormule(j).Champ).Value)
            End If
          Case cstFrmMax
            If TdbFormule(j).NivRupt = -1 Or TdbFormule(j).NivRupt >= NivRupt Then
              If TdbFormule(j).Valeur < CDbl(rsData(TdbFormule(j).Champ).Value) Then
                TdbFormule(j).Valeur = CDbl(rsData(TdbFormule(j).Champ).Value)
              End If
            End If
          Case cstFrmMin
            If TdbFormule(j).NivRupt = -1 Or TdbFormule(j).NivRupt >= NivRupt Then
              If TdbFormule(j).Valeur > CDbl(rsData(TdbFormule(j).Champ).Value) Then
                TdbFormule(j).Valeur = CDbl(rsData(TdbFormule(j).Champ).Value)
              End If
            End If
          Case cstFrmCount
            If TdbFormule(j).NivRupt = -1 Or TdbFormule(j).NivRupt >= NivRupt Then
              TdbFormule(j).Valeur = TdbFormule(j).Valeur + 1
            End If
        End Select
      Next j
    End If

    Return RTFErr_noErr

    'Catch ex As Exception
    '  Return RTFErr_AutreErr
    'End Try

  End Function

  Public Function MkRTF(ByVal FicOrg As String, ByVal FicFin As String, ByVal sSql As String, ByRef cnxInterne As ADODB.Connection, ByVal TdbGlobal(,) As String, Optional ByVal bImage As Boolean = False) As Long
    '-----------------------------------------------------------------------------------
    ' NOM : MkRTF
    ' DESCRIPTION : Transforme un modele RTF en document à imprimer
    ' PARAMETRES :
    '           - FicOrg       : Nom du fichier modeèle
    '           - FicFin       : Nom du fichier document
    '           - sSql          : Requete SQL
    '           - DB            : Base de données
    '-----------------------------------------------------------------------------------
    Try
      Dim IndMinCol As Integer, IndMinRow As Integer
      Dim IndMaxCol As Integer, IndMaxRow As Integer
      Dim IndMinRupt As Integer, IndMaxRupt As Integer
      Dim i As Integer, ret As Integer, pos As Integer
      Dim NbRupt As Integer
      Dim sContenuFichier As String
      Dim sCmdSql As String
      Dim NFicRTF As Integer
      Dim PremiereFois As Integer
      Dim Entete As String = "", sDetail As String = "", sPied As String = ""

      Dim rsData As New ADODB.Recordset

      Dim TdbRupt() As Rupture = Nothing                                   ' Tableau contenant la description des ruptures
      Dim TdbFrmEntete() As Formule = Nothing
      Dim TdbFrmPied() As Formule = Nothing
      Dim TdbFormule() As Formule = Nothing
      Dim TdbFrmDetail() As Formule = Nothing
      Dim BookMark As Object

      If TdbGlobal Is Nothing Then Return RTFErr_NoTDBGlobal : Exit Function

      ' Récupère les dimensions du tableau
      IndMinRow = LBound(TdbGlobal, 1) : IndMinCol = LBound(TdbGlobal, 2)
      IndMaxRow = UBound(TdbGlobal, 1) : IndMaxCol = UBound(TdbGlobal, 2)

      ' Test si l'on a deux colonnes
      If IndMaxCol - IndMinCol <> 1 Then MkRTF = RTFErr_no2Col : Exit Function

      ' Récupère un numéro de fichier valide
      NFicRTF = FreeFile()

      'If Dir(FicOrg) = "" Then MkRTF = RTFErr_OpenFileModele : Exit Function

      FileOpen(NFicRTF, FicOrg, OpenMode.Binary, OpenAccess.Read, OpenShare.Shared)

      ' Erreur à l 'ouverture du fichier
      If Err.Number <> 0 Then MkRTF = RTFErr_OpenFileModele : Exit Function

      sContenuFichier = Space(LOF(NFicRTF))

      ' Lecture du fichier et Fermeture du fichier
      FileGet(NFicRTF, sContenuFichier)
      FileClose(NFicRTF)

      ' remplacement de " par "
      'sContenuFichier = sContenuFichier.Replace("""", """""")

      ' On extrait l'entete du fichier
      Entete = ExtractEntete(sContenuFichier)

      ' Enleve l'entete du contenuFichier
      sContenuFichier = Mid(sContenuFichier, Len(Entete) + 1)

      ' Extrait les ruptures et la section détail
      ret = ExtractRupture(sContenuFichier, sDetail, TdbRupt)
      If ret <> 0 Then Return ret : Exit Function

      ' Il reste dans contenu fichier le pied
      sPied = sContenuFichier

      ' Pour l'entete
      ret = ExtraitFormule(Entete, TdbFrmEntete, TdbGlobal)

      ' Test erreur et retourne le code d'erreur
      If ret <> 0 Then Return ret : Exit Function

      ' Recherche les formule dans les ruptures
      ret = RechercheFormule(TdbRupt, TdbGlobal)

      ' Test erreur et retourne le code d'erreur
      If ret <> 0 Then Return ret : Exit Function

      ' Pour le détail
      ret = ExtraitFormule(sDetail, TdbFrmDetail, TdbGlobal)

      ' Test erreur et retourne le code d'erreur
      If ret <> 0 Then Return ret : Exit Function

      ' Pour les pieds
      ret = ExtraitFormule(sPied, TdbFrmPied, TdbGlobal)

      ' Test erreur et retourne le code d'erreur
      If ret <> 0 Then Return ret : Exit Function

      ' Récupère le nombre de rupture
      NbRupt = NbRupture(TdbRupt)

      If NbRupt > 0 Then
        sCmdSql = sSql & MkOrderBy(TdbRupt, sSql, cnxInterne)
      Else
        sCmdSql = sSql
      End If

      ' Traite l'erreur sur la génération du ORDER BY
      If sCmdSql = "" Then MkRTF = RTFErr_ORDBYErr : Exit Function

      ' Crée le recordset
      rsData.CursorLocation = ADODB.CursorLocationEnum.adUseClient
      rsData.Open(sCmdSql, cnxInterne, ADODB.CursorTypeEnum.adOpenKeyset, ADODB.LockTypeEnum.adLockOptimistic)
      ret = rsData.RecordCount         'pour tester l'erreur
      If ret = 0 Then Return RTFErr_noData : Exit Function
      If Err.Number <> 0 Then MkRTF = RTFErr_SQLErr : Exit Function

      ' Initialise les données d'entete (calcul du format)
      ret = MkCalcul(TdbFrmEntete, rsData, 32767)

      ' Ecrit l'entete de l'édition
      ret = WriteEntete(FicFin, Entete, rsData, TdbGlobal, TdbFrmEntete)
      If ret <> 0 Then Return ret : Exit Function

      ' Initialise les données de la section détail (calcul du format)
      ret = MkCalcul(TdbFrmDetail, rsData, 32767)

      PremiereFois = True

      If NbRupt = 0 Then

        While Not rsData.EOF()

          ' Ecrit la section détail
          ret = GenSection(FicFin, sDetail, rsData, TdbGlobal, TdbFrmDetail)
          If ret <> 0 Then Return ret : rsData.Close() : Exit Function

          If PremiereFois = True Then
            ' Mise à jour dans le pied de page
            ret = MkCalcul(TdbFrmPied, rsData, 32767)
            PremiereFois = False
          Else
            ' Mise à jour dans le pied de page
            ret = MkCalcul(TdbFrmPied, rsData, pos)
          End If

          If ret <> 0 Then Return ret : rsData.Close() : Exit Function

          ' On passe à l'enregitrement suivant
          rsData.MoveNext()

          ' Initialise les données de la section détail (calcul du format)
          ret = MkCalcul(TdbFrmDetail, rsData, 32767)
        End While
      Else

        IndMinRupt = LBound(TdbRupt)
        IndMaxRupt = UBound(TdbRupt)

        ' Initialise les valeurs précédentes
        For i = IndMinRupt To IndMaxRupt

          ' Initialise la structure TdbRupt
          TdbRupt(i).ValPrec = rsData(TdbRupt(i).Champ).Value

          ' Mise à jour dans les entetes
          ret = MkCalcul(TdbRupt(i).FrmEntete, rsData, 32767)

          ' Ecrit la section pied de rupture (pour la première fois)
          ret = GenSection(FicFin, TdbRupt(i).Entete, rsData, TdbGlobal, TdbRupt(i).FrmEntete)
          If ret <> 0 Then Return ret : rsData.Close() : Exit Function

        Next i

        While Not rsData.EOF()

          ' Parcours toutes les ruptures, mise à jour des valeurs calculées
          For i = IndMinRupt To IndMaxRupt
            ' Mise à jour dans les entetes
            ret = MkCalcul(TdbRupt(i).FrmEntete, rsData, pos)
            If ret <> 0 Then Return ret : rsData.Close() : Exit Function
          Next i

          ' Recherche le niveau de la rupture cassée
          pos = RuptureCassee(rsData, TdbRupt)

          ' Mise à jour dans le détail
          ret = MkCalcul(TdbFrmDetail, rsData, pos)

          If pos <> -1 Then
            ' Remonte les pieds de ruptures
            For i = IndMaxRupt To pos Step -1
              BookMark = rsData.Bookmark
              rsData.MovePrevious()
              ' Ecrit la section pied de rupture
              ret = GenSection(FicFin, TdbRupt(i).Pied, rsData, TdbGlobal, TdbRupt(i).FrmPied)
              If ret <> 0 Then Return ret : rsData.Close() : Exit Function
              rsData.Bookmark = BookMark
            Next i

            ' Monte les entetes de ruptures
            For i = pos To IndMaxRupt
              ' Ecrit la section pied de rupture
              ret = GenSection(FicFin, TdbRupt(i).Entete, rsData, TdbGlobal, TdbRupt(i).FrmEntete)
              If ret <> 0 Then Return ret : rsData.Close() : Exit Function
            Next i
          End If

          ' Ecrit la section détail
          ret = GenSection(FicFin, sDetail, rsData, TdbGlobal, TdbFrmDetail)
          If ret <> 0 Then Return ret : rsData.Close() : Exit Function

          ' Parcours toutes les ruptures, mise à jour des valeurs calculées
          For i = IndMinRupt To IndMaxRupt
            ' Mise à jour dans les pieds
            ret = MkCalcul(TdbRupt(i).FrmPied, rsData, IIf(PremiereFois, 32767, pos))
            If ret <> 0 Then Return ret : rsData.Close() : Exit Function
          Next i

          If PremiereFois = True Then
            ' Mise à jour dans le pied de page
            ret = MkCalcul(TdbFrmPied, rsData, 0)
            PremiereFois = False
          Else
            ' Mise à jour dans le pied de page
            ret = MkCalcul(TdbFrmPied, rsData, pos)
          End If
          If ret <> 0 Then Return ret : rsData.Close() : Exit Function
          rsData.MoveNext()
        End While

        ' On revient au dernier enregistrement
        rsData.MoveLast()

        ' Remonte les pieds de ruptures
        For i = IndMaxRupt To IndMinRupt Step -1
          ' Ecrit la section pied de rupture
          ret = GenSection(FicFin, TdbRupt(i).Pied, rsData, TdbGlobal, TdbRupt(i).FrmPied)
          If ret <> 0 Then Return ret : rsData.Close() : Exit Function
        Next i
      End If

      rsData.MoveLast()

      ' Ecrit le pied de l'état
      ret = GenSection(FicFin, sPied, rsData, TdbGlobal, TdbFrmPied)

      If ret <> 0 Then
        MkRTF = ret
        rsData.Close()
        Exit Function
      End If

      '' Si image à traiter 
      'If bImage Then
      '	' mettre en place l'impersonation
      '	Dim imp As New Impersonate()

      '             '#If DEBUG Then
      '             '			imp.StartImp("apitechnew", "Administrateur", "AdmO5!C7")
      '             '#Else
      '             '"D0156-1"
      '             imp.StartImp("", "Administrator", "Rv7K#6gT")
      '             '#End If

      '	ret = GenImages(FicFin, rsData)
      '	imp.StopImp()
      'End If

      rsData.Close()
      Return RTFErr_noErr

    Catch ex As Exception
      LastError = ex.Message
      Return RTFErr_AutreErr
    End Try

  End Function

End Class

