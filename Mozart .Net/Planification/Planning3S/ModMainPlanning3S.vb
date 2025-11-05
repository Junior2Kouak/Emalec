Imports System.Data.SqlClient
Imports MozartLib

Public Structure structIP
  Dim TYPEIP As String
  Dim NIPLNUM As Integer
  Dim NSITNUM As Integer
  Dim NACTNUM As Integer
  Dim VCLINOM As String
  Dim VSITNOM As String
  Dim NIPLDUR As Integer
  Dim NIPLDURJ As Decimal
  Dim CIPLDEB As String
  Dim NPERNUM As Integer
  Dim DIPLDATJ As Date
  Dim CIPLMULT As String
  Dim CACTNUIT As String
  Dim NBFACT As Integer
  Dim PREVMAG As Boolean
  Dim SCODE As String
  Dim Dist As Integer
  Dim PERLAT As Double
  Dim PERLON As Double
  Dim SITLAT As Double
  Dim SITLON As Double
  Dim bCOMPETENT As String
  Dim bContratOK As Integer
  Dim NIPLIND As Integer
  Dim BACTPAVEBLOCK As Boolean

  Sub New(ByVal lCLient As String, ByVal lSite As String, ByVal lValues As String, ByVal lBrush As Brush)
    VCLINOM = lCLient
    VSITNOM = lSite
  End Sub

End Structure

Public Module ModMainPlanning3S

  Public cnx2 As New SqlConnection()

  Dim dr As SqlDataReader = Nothing

  Public Function TestTechOK(ByVal p_iTech As Int32, ByVal p_dateRef As Date) As Boolean

    Try

      Dim cmd As New SqlCommand(String.Format("SELECT ISNULL(DPERSOR, GetDate() + 365) FROM TPER WITH (NOLOCK) WHERE NPERNUM = {0}", p_iTech), MozartDatabase.cnxMozart)
      Dim dDateSortie As String = cmd.ExecuteScalar()
      If CDate(dDateSortie) > p_dateRef Then
        Return True
      Else
        Return False
      End If
    Catch ex As Exception
      MessageBox.Show(ex.Message & vbCrLf & vbCrLf & "dans TestTechOK")
      End
    End Try

  End Function

  Public Function DemiJournee(ByVal pSiteNum As Integer, ByVal indice As Integer, ByVal datepla As String) As Boolean

    Try

      Dim sSql As String = String.Format("SELECT COALESCE(NMATAPINT,0) AS NMATAPINT FROM THORAIRES WHERE NSITNUM = {0} " _
                                                   & "AND VJOUR = DATENAME(WEEKDAY,'{1}')", pSiteNum, datepla)

      Dim rsDemiJour As New SqlCommand(sSql, MozartDatabase.cnxMozart)
      Dim Resultat As Int32 = rsDemiJour.ExecuteScalar()

      Select Case Resultat
        Case 0
          Return True
        Case 1
          If indice = 1 Or indice = 2 Then
            Return False
          Else
            Return True
          End If
        Case 2
          If indice = 3 Or indice = 4 Then
            Return False
          Else
            Return True
          End If
        Case 3
          Return False
        Case Else
          Return False
      End Select

    Catch ex As Exception
      MessageBox.Show(ex.Message & vbCrLf & vbCrLf & "dans DemiJournee")
      End
    End Try

  End Function

  Public Sub AddLogIPL(ByVal nIplNUm As Long, ByVal sType As String, Optional ByVal sCommentaire As String = "")

    Dim cmd As SqlCommand, cmd2 As SqlCommand
    Dim sLog As String

    If nIplNUm = 0 Then Exit Sub

    Try

      cmd = New SqlCommand("SELECT NACTNUM, NDINNUM FROM TACT WITH (NOLOCK) WHERE NIPLNUM = " & nIplNUm, MozartDatabase.cnxMozart)
      dr = cmd.ExecuteReader()

      If sType = "S" Then
        sLog = "Suppression planification" + sCommentaire
      ElseIf sType = "M" Then
        sLog = "Modification planification" + sCommentaire
      ElseIf sType = "C" Then
        sLog = "Création planification" + sCommentaire
      Else
        Exit Sub
      End If

      While dr.Read()
        cmd2 = New SqlCommand("INSERT INTO TLOG VALUES(" & dr("NDINNUM") & "," & dr("NACTNUM") & "," & nIplNUm & ",'" & sLog & "','" & MozartParams.strUID & "', getdate())", MozartDatabase.cnxMozart)
        cmd2.ExecuteNonQuery()
      End While

    Catch ex As Exception
      MessageBox.Show(ex.Message & vbCrLf & vbCrLf & "dans : " & System.Reflection.MethodBase.GetCurrentMethod.Name)
    Finally
      If Not dr Is Nothing Then dr.Close()
    End Try

  End Sub

  Function CouleurExecution(ByVal IplNum As Integer, ByVal CurrentColor As Color) As Color

    Dim cmd As New SqlCommand("exec api_sp_ControleDateExec_Attach " & IplNum, MozartDatabase.cnxMozart)
    Try
      dr = cmd.ExecuteReader()
      dr.Read()

      If dr(1) = 0 Then Return Color.LightGreen
      If dr(0) = 0 Then Return Color.Orange
      Return CurrentColor

    Catch ex As Exception
      MessageBox.Show(ex.Message & vbCrLf & vbCrLf & "dans : " & System.Reflection.MethodBase.GetCurrentMethod.Name)
      Return CurrentColor
    Finally
      If Not dr Is Nothing Then dr.Close()
    End Try

  End Function

  Public Function GetTechniciens(ByVal lstCtrlTechs As ListControl, ByVal sTypeControl As String, ByVal sType As String) As Collection

    Dim Techs As New Collection
    Try

      ' liste des techniciens
      Dim i As Integer = 1
      Dim sSql As String = ""

      Select Case sType
        Case "TOUS"
          sSql = "select * from api_v_listeTechniciens3S ORDER BY CPERTYP desc, VSERLIB, NREGROUPREG, VREGLIB , NREGCOD "
        Case "LISTE"
          sSql = "select * from api_v_listeTechniciens3S order by vpernom"
        Case "Regroup"
                    'sSql = "select * from api_v_listeTechniciens3S where NPERNUM in (" + sListeSelectTech + ") ORDER BY CPERTYP desc, VSERLIB,NREGROUPREG, VREGLIB , NREGCOD "
        Case "CO"
          sSql = "select * from api_v_listeTechniciens3S where CPERTYP = 'CO' ORDER BY CPERTYP desc, VSERLIB,NREGROUPREG, VREGLIB , NREGCOD "
        Case Else
          sSql = "select * from api_v_listeTechniciens3S where NSERNUM = " & sType & " AND CPERTYP = 'TE' ORDER BY CPERTYP desc, VSERLIB, NREGROUPREG, VREGLIB , NREGCOD "
      End Select

      Dim cmd As New SqlCommand(sSql, MozartDatabase.cnxMozart)
      dr = cmd.ExecuteReader()
      While dr.Read()
        Dim Tech As New ClsTechnicien(i, dr("VPERNOM"), dr("NPERNUM"))
        Tech.CPERTYP = dr("CPERTYP")
        Tech.NREGCOD = dr("NREGCOD")
        Tech.NSERNUM = dr("NSERNUM")
        Tech.VREGLIB = dr("VREGLIB")
        Tech.VSERLIB = dr("VSERLIB")
        Tech.VPERPERMI = dr("VPERPERMI")
        Tech.NREGROUPREG = dr("NREGROUPREG")
        Tech.TCOMPETENCES = dr("COMPETENCES")
        Tech.LAT = If(dr("FPERLAT") Is DBNull.Value, 0.0, dr("FPERLAT"))
        Tech.LON = If(dr("FPERLON") Is DBNull.Value, 0.0, dr("FPERLON"))
        Tech.VTYPEDETAILLIB = dr("VTYPEDETAILLIB")
        Tech.VPERTYPEPOSTE = dr("VPERTYPEPOSTE")
        Tech.VSITNOM_POSTE = dr("VSITNOM_POSTE")
        Tech.VCLINOM_POSTE = dr("VCLINOM_POSTE")
        Tech.VTUTEUR = dr("VTUTEUR")
        Tech.CPERTYPDETAIL = dr("CPERTYPDETAIL")
        Techs.Add(Tech)
        If sTypeControl = "Combo" Then
          CType(lstCtrlTechs, ComboBox).Items.Add(Tech)
        Else
          CType(lstCtrlTechs, ListBox).Items.Add(Tech)
        End If
        i += 1
      End While
      Return Techs

    Catch ex As Exception
      MessageBox.Show(ex.Message & vbCrLf & vbCrLf & "dans : " & System.Reflection.MethodBase.GetCurrentMethod.Name)
      Return Nothing
    Finally
      If Not dr Is Nothing Then dr.Close()
    End Try

  End Function

  Public Function Verifications(ByVal nIpl As Long, ByVal sDatePla As String, ByVal nSitNum As Long, ByVal numClient As Integer, Optional ByVal nTech As Integer = 0, Optional ByVal nActnum As Long = 0, Optional ByVal bDateMmJr As Boolean = False) As Boolean

    If VerifDroits(nIpl) Then
      If VerifAuto(nIpl) Then
        If VerifESTEE(nIpl) Then
          If VerifLockAction(nIpl) Then
            If VerifInfosClient(nIpl, bDateMmJr) Then
              If VerifdateSouhaiteLimite(nIpl, sDatePla, nActnum) Then
                If VerifAide(nIpl) Then
                  If VerifRDV(nIpl) Then
                    If VerifBlocage(nIpl) Then
                      If VerifNacelleTech(nIpl, nTech, nActnum) Then
                        If VerifCompTech(nIpl, nTech, nActnum, numClient) Then
                          If VerifTechInterdit(nIpl, nTech, nSitNum) Then
                            If VerifSiteOuvert(nSitNum, sDatePla) Then
                              If VerifTechDevis(nIpl, nTech, nActnum) Then
                                Return True
                                Exit Function
                              End If
                            End If
                          End If
                        End If
                      End If
                    End If
                  End If
                End If
              End If
            End If
          End If
        End If
      End If
    End If
    Return False

  End Function

  Private Function VerifdateSouhaiteLimite(ByVal nIpl As Long, ByVal sDatePla As String, ByVal nActnum As Long) As Boolean

    Try

      Dim strSQL As String
      Dim bOK As Boolean = True

      ' la date souhaitée est utilisée comme limite de planification
      ' RCBT + ARGEDIS + PIMKIE + SPIR + THOMEUROPE + IDGROUP + ED DIA

      If sDatePla = "" Then Return bOK
      If nIpl = 0 Then
        'Hors prev
        'strSQL = "SELECT ISNULL(DACTDAT, 0)  FROM TACT INNER JOIN TDIN ON TDIN.NDINNUM = TACT.NDINNUM WHERE TACT.NPERNUM <> 10 AND NCLINUM in (1812,4031,125, 91, 1597) AND CPRECOD <> 'P' AND NACTNUM = " & nActnum
        strSQL = "SELECT ISNULL(DACTDAT, 0)  FROM TACT INNER JOIN TDIN ON TDIN.NDINNUM = TACT.NDINNUM WHERE TACT.NPERNUM <> 10 AND CPRECOD NOT IN ('P', 'R', 'F') AND NACTNUM = " & nActnum
      Else
        'Hors prev
        'strSQL = "SELECT ISNULL(DACTDAT, 0) FROM TACT INNER JOIN TDIN ON TDIN.NDINNUM = TACT.NDINNUM WHERE TACT.NPERNUM <> 10 AND NCLINUM in (1812,4031,125, 91, 1597) AND CPRECOD <> 'P' AND NIPLNUM = " & nIpl
        strSQL = "SELECT MIN(DACTDAT) FROM TACT INNER JOIN TDIN ON TDIN.NDINNUM = TACT.NDINNUM WHERE TACT.NPERNUM <> 10 AND CPRECOD NOT IN ('P', 'R', 'F') AND NIPLNUM = " & nIpl
      End If
      Dim cmd As New SqlCommand(strSQL, MozartDatabase.cnxMozart)
      dr = cmd.ExecuteReader()

      If Not dr.HasRows Then
        dr.Close()
        Return bOK
      End If

      dr.Read()

      If IsDBNull(dr(0)) = False Then

        If CDate(sDatePla) > CDate(dr(0)) Then
          MsgBox("Modification impossible car vous dépassez la date souhaitée (date limite de planification).", vbInformation)
          bOK = False
        End If
      Else
        bOK = True
      End If
      dr.Close()
      Return bOK
    Catch ex As Exception
      MessageBox.Show(ex.Message & vbCrLf & vbCrLf & "dans VerifdateSouhaiteLimite")
      End
    End Try

  End Function

  Private Function VerifBlocage(ByVal nIpl As Long) As Boolean

    If nIpl = 0 Then Return True

    Try
      Dim cmd As New SqlCommand("SELECT COUNT(TACT.NACTNUM) FROM TACT WITH (NOLOCK) INNER JOIN TACTCOMP WITH (NOLOCK) ON TACTCOMP.NACTNUM = TACT.NACTNUM WHERE BACTPAVEBLOCK = 1  AND NIPLNUM = " & nIpl, MozartDatabase.cnxMozart)
      If cmd.ExecuteScalar() > 0 Then
        MsgBox("Cette action a été bloquée par le service planification")
        Return False
      End If
      Return True
    Catch ex As Exception
      MessageBox.Show(ex.Message & vbCrLf & vbCrLf & "dans : " & System.Reflection.MethodBase.GetCurrentMethod.Name)
      Return False
    End Try

  End Function

  Private Function VerifTechDevis(ByVal nIpl As Long, ByVal nTech As Long, ByVal nActnum As Long) As Boolean
    Dim sObs As String
    Dim sSql As String

    If nTech = 0 Then Return True

    Try
      Dim cmd1 As New SqlCommand("SELECT count(NWDEVNUM) AS CPT FROM TWDEVIS WITH (NOLOCK) INNER JOIN TACT WITH (NOLOCK) ON TWDEVIS.NACTNUM = TACT.NACTNUM WHERE TACT.NDINNUM in (SELECT NDINNUM FROM TACT WITH (NOLOCK) WHERE (NACTNUM = " & nActnum & " OR NIPLNUM = " & nIpl & "))", MozartDatabase.cnxMozart)
      If cmd1.ExecuteScalar() > 0 Then
        Dim cmd2 As New SqlCommand("SELECT count(NWDEVNUM) AS CPT FROM TWDEVIS WITH (NOLOCK) INNER JOIN TACT WITH (NOLOCK) ON TWDEVIS.NACTNUM = TACT.NACTNUM WHERE TACT.NDINNUM in (SELECT NDINNUM FROM TACT WITH (NOLOCK) WHERE (NACTNUM = " & nActnum & " OR NIPLNUM = " & nIpl & "))", MozartDatabase.cnxMozart)
        If cmd2.ExecuteScalar() > 0 Then
          If MsgBox("Ce technicien n'est pas celui qui a fait le devis. Voulez-vous toutefois planifier ce technicien ?", vbYesNo) = vbYes Then
            sObs = MozartParams.strUID & " le " & Format(Now, "dd/MM/yy HH:mm") & " : Planification volontaire d''un technicien autre que celui qui a fait le devis."
            sSql = "UPDATE TACT SET VACTOBS = '" & sObs & "' + CHAR(10) + CHAR(13) + VACTOBS WHERE (NIPLNUM = " & nIpl & " OR NACTNUM = " & nActnum & ")" _
                    & " AND NDINNUM IN (SELECT NDINNUM FROM TACT WITH (NOLOCK) INNER JOIN TWDEVIS ON TWDEVIS.NACTNUM = TACT.NACTNUM " _
                    & " WHERE (TACT.NACTNUM = " & nActnum & " OR TACT.NIPLNUM = " & nIpl & "))"

            cmd1 = New SqlCommand(sSql, MozartDatabase.cnxMozart)
            cmd1.ExecuteNonQuery()
            Return True
          Else
            Return False
          End If
        End If
      End If
      Return True

    Catch ex As Exception
      MessageBox.Show(ex.Message & vbCrLf & vbCrLf & "dans : " & System.Reflection.MethodBase.GetCurrentMethod.Name)
      Return False
    End Try

  End Function

  Function VerifAide(ByVal nIpl As Long, Optional ByVal bmsg As Boolean = True) As Boolean

    Dim strSQL As String
    Dim bReturn As Boolean = True

    If nIpl = 0 Then Return True

    Try

      strSQL = "SELECT COUNT(T1.NACTNUM) FROM TACT T1, TACT T2 WHERE T1.NIPLNUM = " & nIpl
      strSQL = strSQL & " AND T1.NSITNUM = T2.NSITNUM AND T1.DACTPLA = T2.DACTPLA AND T1.NPERNUM <> ISNULL(T2.NPERNUM,'') AND T1.CACTTYT = 'T' AND T2.CACTTYT = 'T' "
      Dim cmd As New SqlCommand(strSQL, MozartDatabase.cnxMozart)
      dr = cmd.ExecuteReader()
      dr.Read()
      If dr(0) > 0 Then
        If bmsg Then
          If MessageBox.Show("Attention, vous allez déplacer la planification d'une action groupée. Il y a plusieurs techniciens ou sous traitants planifiés au même moment pour réaliser cette prestation." & vbCrLf & "Vérifiez les conséquences" & vbCrLf & vbCrLf & "Voulez-vous continuer ?", "", MessageBoxButtons.YesNo, MessageBoxIcon.Exclamation, MessageBoxDefaultButton.Button2) = DialogResult.No Then
            bReturn = False
          End If
        Else
          bReturn = False
        End If
      End If

      Return bReturn

    Catch ex As Exception
      MessageBox.Show(ex.Message & vbCrLf & vbCrLf & "dans : " & System.Reflection.MethodBase.GetCurrentMethod.Name)
      Return False
    Finally
      If Not dr Is Nothing Then dr.Close()
    End Try

  End Function

  Private Function VerifDroits(ByVal nIpl As Long) As Boolean

    If nIpl = 0 Then Return True
    Try
      ' interdir de deplacer des paves dont on a pas les droits  ' recherche des droits sur cette DI
      Dim cmd As New SqlCommand("SELECT count(*) FROM TDIN WITH (NOLOCK) INNER JOIN TAUT WITH (NOLOCK) ON  TDIN.NDINCTE = TAUT.NCANNUM " &
          " INNER JOIN TPER WITH (NOLOCK) ON TAUT.NPERNUM=TPER.NPERNUM INNER JOIN TACT WITH (NOLOCK) ON TDIN.NDINNUM=TACT.NDINNUM " &
          " WHERE TPER.NPERNUM = " & MozartParams.UID & " And TACT.NIPLNUM=" & nIpl, MozartDatabase.cnxMozart)

      If cmd.ExecuteScalar() = 0 Then
        MsgBox("Vous n'avez pas les droits pour déplacer ou supprimer cette intervention.", vbExclamation + vbOKOnly)
        Return False
      End If
      Return True

    Catch ex As Exception
      MessageBox.Show(ex.Message & vbCrLf & vbCrLf & "dans : " & System.Reflection.MethodBase.GetCurrentMethod.Name)
      Return False
    End Try

  End Function

  Private Function VerifInfosClient(ByVal nIpl As Long, ByVal bDateMmJr As Boolean) As Boolean

    If nIpl = 0 Then Return True

    Try
      Dim cmd As New SqlCommand("SELECT count(CACTINFOMAG) FROM TACT WITH (NOLOCK) WHERE CACTINFOMAG = 'O' AND NIPLNUM = " & nIpl, MozartDatabase.cnxMozart)
      If cmd.ExecuteScalar() > 0 Then
        If bDateMmJr = False Then

          If RechercheClient(nIpl) = 9823 Then
            Dim sMes As String
            sMes = "Modification impossible car le site est informé et 4 personnes du siège ont été également informées par mail." & vbCrLf
            sMes = sMes & "Pour déplacer cette intervention, il faut supprimer l'information du site, mais vous ne pouvez pas changer cette date sans d'importantes conséquences." & vbCrLf
            sMes = sMes & "Vous rapprocher du chargé d'affaire." & vbCrLf
            MessageBox.Show(sMes, "Erreur", MessageBoxButtons.OK, MessageBoxIcon.Information)

          Else
            MessageBox.Show("Modification impossible car le site est informé du passage de notre technicien." & vbCrLf & "Pour déplacer cette intervention, il faut obligatoirement la replanifier dans la même journée ou supprimer l'information du site", "Erreur", MessageBoxButtons.OK, MessageBoxIcon.Information)
          End If
          Return False
        Else
          MessageBox.Show("Avertissement : le site a été informé du passage de notre technicien.", "Erreur", MessageBoxButtons.OK, MessageBoxIcon.Information)
          Return True
        End If
      Else
        Return True
      End If

    Catch ex As Exception
      MessageBox.Show(ex.Message & vbCrLf & vbCrLf & "dans : " & System.Reflection.MethodBase.GetCurrentMethod.Name)
      Return False
    End Try

  End Function

  Private Function RechercheClient(ByVal nIpl As Long) As Int32

    Try
      Dim lRs As New SqlCommand("SELECT NCLINUM FROM TACT WITH (NOLOCK) INNER JOIN TSIT WITH (NOLOCK) ON TSIT.NSITNUM=TACT.NSITNUM WHERE NIPLNUM = " & nIpl, MozartDatabase.cnxMozart)

      If nIpl = 0 Then Return 0

      Return Convert.ToInt32(lRs.ExecuteScalar())

    Catch ex As Exception
      MessageBox.Show(ex.Message & vbCrLf & vbCrLf & "dans : " & System.Reflection.MethodBase.GetCurrentMethod.Name)
      Return 0
    End Try

  End Function

  Private Function VerifRDV(ByVal nIpl As Long) As Boolean

    If nIpl = 0 Then Return True

    Try
      Dim cmd As New SqlCommand("SELECT ISNULL(VACTRDV, '') FROM TACT WITH (NOLOCK) WHERE NIPLNUM = " & nIpl, MozartDatabase.cnxMozart)
      If cmd.ExecuteScalar() <> "" Then
        If MsgBox("Attention, vous allez déplacer la planification de cette action alors qu'il existe un rendez vous." & vbCrLf & "Vérifiez les conséquences (information magasin, siège, technicien, chargé d'affaires, assistantes, ...)" & vbCrLf & vbCrLf & "Voulez-vous continuer ?", vbExclamation + vbYesNo + vbDefaultButton2) = vbYes Then
          Return True
        Else
          Return False
        End If
      End If
      Return True

    Catch ex As Exception
      MessageBox.Show(ex.Message & vbCrLf & vbCrLf & "dans : " & System.Reflection.MethodBase.GetCurrentMethod.Name)
      Return False
    End Try

  End Function

  '******************************************************************************************************************************************************
  'Bloque la modif planif si le site a été informé par mail 15 j avant. seulement pour les prev (voir TMAILBLOCKPLA)
  '******************************************************************************************************************************************************
  Private Function VerifESTEE(ByVal nIpl As Long) As Boolean

    If nIpl = 0 Then Return True

    ' droit sur le planning : interdit de modifier mais pouvoir planifier la première fois
    Dim cmd As New SqlCommand("SELECT COUNT(*) FROM TACT WITH (NOLOCK) INNER JOIN TMAILBLOCKPLA WITH (NOLOCK) ON TACT.NACTNUM = TMAILBLOCKPLA.NACTNUM WHERE NIPLNUM = " & nIpl, MozartDatabase.cnxMozart)
    If cmd.ExecuteScalar() > 0 Then
      If RechercheDroitMenu(538) Then
        Return True
      Else
        ' TB SAMSIC CITY SPEC
        ' Chaîne de caractère avec des noms spécifiques
        MsgBox("§Modification interdite car client informé par mail.§" & vbCrLf & "§Voir Michel ou jean§" & vbCrLf & "§L'action sera annulée.§", vbExclamation + vbOKOnly)
        Return False
      End If
    Else
      Return True
    End If

  End Function

  Private Function VerifAuto(ByVal nIpl As Long) As Boolean

    If nIpl = 0 Then Return True

    'If UCase(gstrNomSociete) <> "EMALEC" Then Return False

    Try
      ' droit sur le planning : interdit de modifier mais pouvoir planifier la première fois
      If Not RechercheDroitMenu(535) Then
        MsgBox("Vous n'avez pas les droits pour déplacer ou supprimer les interventions." & vbCrLf & "L'action sera annulée.", vbExclamation + vbOKOnly)
        Return False
      End If
      Return True

    Catch ex As Exception
      MessageBox.Show(ex.Message & vbCrLf & vbCrLf & "dans : " & System.Reflection.MethodBase.GetCurrentMethod.Name)
      Return False
    End Try

  End Function

  Private Function VerifLockAction(ByVal nIpl As Long) As Boolean

    If nIpl = 0 Then Return True

    Try
      ' recherche si une action de l'IP n'est pas en cours de modification par quelqu'un
      ' ne pas bloquer si on vient du détail de l'action
      dr = New SqlCommand("api_sp_ListeLockAction " & nIpl & ", 0", MozartDatabase.cnxMozart).ExecuteReader()
      dr.Read()
      If dr.HasRows() Then
        MsgBox("Une action de cette intervention est en cours de modification par " & dr(1) & " (DI" & dr(0) & ")" & vbCrLf & "Vous ne pouvez pas déplacer cette intervention actuellement !", vbExclamation + vbOKOnly)
        Return False
      End If
      dr.Close()
      Return True

    Catch ex As Exception
      MessageBox.Show(ex.Message & vbCrLf & vbCrLf & "dans : " & System.Reflection.MethodBase.GetCurrentMethod.Name)
      Return False
    Finally
      If Not dr Is Nothing Then dr.Close()
    End Try

  End Function

  Private Function VerifNacelleTech(ByVal nIpl As Long, ByVal nTech As Integer, ByVal nActnum As Long) As Boolean
    Dim cmd As SqlCommand
    If nIpl = 0 Then Return True

    Try
      ' recherche si action necessite nacelle
      If nIpl = 0 Then
        cmd = New SqlCommand("SELECT count(CACTNACEL) FROM TACT WITH (NOLOCK) WHERE CACTNACEL='O' AND NACTNUM = " & nActnum, MozartDatabase.cnxMozart)
      Else
        cmd = New SqlCommand("SELECT count(CACTNACEL) FROM TACT WITH (NOLOCK) WHERE CACTNACEL='O' AND NIPLNUM = " & nIpl, MozartDatabase.cnxMozart)
      End If

      If cmd.ExecuteScalar() > 0 Then
        ' On regarde si le technicien possède le permis nacelle
        Dim cmd2 As New SqlCommand("SELECT VPERPERMI FROM TPER WHERE NPERNUM= " & nTech, MozartDatabase.cnxMozart)
        'If InStr(1, lRs("VPERPERMI"), "C") > 0 Then
        If InStr(1, cmd.ExecuteScalar(), "C") > 0 Then
          Return True
        Else
          If MsgBox("Attention, cette action nécessite l'utilisation d'une nacelle et le technicien n'a pas le permis requis." & vbCrLf & vbCrLf & "Voulez-vous continuer ?", vbExclamation + vbYesNo + vbDefaultButton2) = vbYes Then
            Return True
          Else
            Return False
          End If
        End If
      End If
      Return True

    Catch ex As Exception
      MessageBox.Show(ex.Message & vbCrLf & vbCrLf & "dans : " & System.Reflection.MethodBase.GetCurrentMethod.Name)
      Return False
    End Try

  End Function

  Private Function VerifCompTech(ByVal nIpl As Long, ByVal nTech As Integer, ByVal nActnum As Long, ByVal iNumClientSOCIETE As Integer) As Boolean
    ' recherche si le tehcnicien a les compétences (contrat sur la DI)

    If nTech = 0 Then Return True

    Dim cmd2 As SqlCommand
    Dim bVerif As Boolean = True

    Try
      ' recherche du contrat ou des contrats
      Dim cmd As New SqlCommand("SELECT NTYPECONTRAT FROM TACT A, TDIN D WHERE D.NDINNUM=A.NDINNUM AND NCLINUM <> " & iNumClientSOCIETE.ToString(), MozartDatabase.cnxMozart)
      If nIpl = 0 Then
        cmd.CommandText &= " AND NACTNUM = " & nActnum
      Else
        cmd.CommandText &= " AND NIPLNUM = " & nIpl
      End If
      dr = cmd.ExecuteReader()

      While dr.Read()
        'on regarde si le technicien a la bonne compétence (sauf pour hors contrat )
        If dr("NTYPECONTRAT") <> 48 Then
          cmd2 = New SqlCommand("SELECT count(*) FROM TPERTYPECONTRAT WITH (NOLOCK) WHERE NPERNUM= " + nTech.ToString() + " AND NTYPECONTRAT='" & dr("NTYPECONTRAT").ToString() & "'", MozartDatabase.cnxMozart)
          If cmd2.ExecuteScalar() = 0 Then bVerif = False
        End If
      End While


      If Not bVerif Then
        If MsgBox("Attention, le technicien n'a pas la compétence requise pour cette intervention." & vbCrLf & vbCrLf & "Voulez-vous continuer ?", vbExclamation + vbYesNo + vbDefaultButton2) = vbYes Then
          Return True
        Else
          Return False
        End If
      End If
      Return True

    Catch ex As Exception
      MessageBox.Show(ex.Message & vbCrLf & vbCrLf & "dans : " & System.Reflection.MethodBase.GetCurrentMethod.Name)
      Return False
    Finally
      If Not dr Is Nothing Then dr.Close()
    End Try

  End Function

  Private Function VerifTechInterdit(ByVal nIp As Long, ByVal nTech As Integer, ByVal nSitNum As Long) As Boolean

    If nTech = 0 Or nSitNum = 0 Then Return True

    Try
      ' vérification interdiction et obligation tech sur site

      ' TECH EN COURS INTERDIT
      Dim cmdVerifInt As New SqlCommand("SELECT COUNT(*) FROM TTECHSITE WITH (NOLOCK) WHERE NSITNUM = " & nSitNum & " AND NPERNUM = " & nTech & " AND CTYPE = 'I'", MozartDatabase.cnxMozart)

      ' AUTRES TECH OBLIGATOIRE?
      Dim cmdVerifObl As New SqlCommand("SELECT COUNT(*) FROM TTECHSITE WITH (NOLOCK) WHERE NSITNUM = " & nSitNum & " AND NPERNUM <> " & nTech & " AND CTYPE = 'O' AND NPERNUM NOT IN (SELECT NPERNUM FROM TPER WHERE CPERACTIF = 'N')", MozartDatabase.cnxMozart)

      ' TECH EN COURS OBLIGATOIRE
      Dim cmdVerifOblTech As New SqlCommand("SELECT COUNT(*) FROM TTECHSITE WITH (NOLOCK) WHERE NSITNUM = " & nSitNum & " AND NPERNUM = " & nTech & " AND CTYPE = 'O'", MozartDatabase.cnxMozart)

      'Dim cmdIP As New SqlCommand("SELECT COUNT(*) FROM TACT WITH (NOLOCK) WHERE NIPLNUM = " & nIp & " AND CPRECOD = 'P'", cnx)

      If cmdVerifInt.ExecuteScalar() > 0 Then
        MsgBox("Ce technicien est interdit sur ce site!", vbCritical)
        Return False
        ' on ne teste les tech obligatoire que sur les PREV (modif FG le 10/11/16 maintenant on fait pour toutes actions)
        'ElseIf cmdVerifOblTech.ExecuteScalar() = 0 And cmdIP.ExecuteScalar() <> 0 Then
      ElseIf cmdVerifOblTech.ExecuteScalar() = 0 Then
        If cmdVerifObl.ExecuteScalar() > 0 Then
          MsgBox("Il y a des techniciens obligatoires sur ce site!", vbCritical)
          Return False
        End If
      End If
      Return True

    Catch ex As Exception
      MessageBox.Show(ex.Message & vbCrLf & vbCrLf & "dans : " & System.Reflection.MethodBase.GetCurrentMethod.Name)
      Return False
    End Try

  End Function

  Public Sub RechercheInfoCdeFo(ByVal NumIP As Long)
    Dim sMsgDateLiv As String = ""

    Try
      ' Message si il existe 1 ou + commande fournisseurs ou sorties de stock sur une action préventive relative à l'IP
      dr = New SqlCommand("api_sp_IpCommandeSortie " & NumIP, MozartDatabase.cnxMozart).ExecuteReader()

      If dr.HasRows Then
        'rsDateLiv.MoveFirst()
        While dr.Read()
          sMsgDateLiv = sMsgDateLiv + "," + dr("DateLivr")
        End While

        sMsgDateLiv = Right(sMsgDateLiv, Len(sMsgDateLiv) - 1)
        MsgBox("Attention" + vbCrLf & "Il existe une ou des commandes de fournitures ou sorties " _
        + "de stock avec une ou des dates de livraisons suivantes :" + vbCrLf _
        + sMsgDateLiv, vbExclamation)

      End If
      dr.Close()

    Catch ex As Exception
      MessageBox.Show(ex.Message & vbCrLf & vbCrLf & "dans : " & System.Reflection.MethodBase.GetCurrentMethod.Name)
    Finally
      If Not dr Is Nothing Then dr.Close()
    End Try

  End Sub

  Public Sub AfficheInfoSite(ByVal NumSite As Long)

    Dim sInfos As String = ""
    Dim DateValDeb As Date
    Dim DateValFin As Date

    Try
      Dim cmd As New SqlCommand("SELECT * FROM TNOTES WITH (NOLOCK) WHERE VNOTTYPE = 'INFO_SITE' AND NNOTCLE = " & NumSite, MozartDatabase.cnxMozart)
      dr = cmd.ExecuteReader()

      If dr.HasRows Then
        dr.Read()

        sInfos = dr("VNOTMESS") & ""
        DateValDeb = IIf(dr("DNOTVALSTART").ToString() = "", "01/01/2000", dr("DNOTVALSTART"))
        DateValFin = IIf(dr("DNOTVALSTOP").ToString() = "", "31/12/2099", dr("DNOTVALSTOP"))

        If sInfos <> "" And DateValDeb < Date.Now And DateValFin > Date.Now Then
          FrmInfosClient.strInfo = sInfos
          FrmInfosClient.ShowDialog()
        End If
      End If

    Catch ex As Exception
      MessageBox.Show(ex.Message & vbCrLf & vbCrLf & "dans : " & System.Reflection.MethodBase.GetCurrentMethod.Name)
    Finally
      If Not dr Is Nothing Then dr.Close()
    End Try

  End Sub

  Private Function VerifSiteOuvert(ByVal nSitNum As Long, ByVal sDate As String) As Boolean

    Dim rsfermeture As New SqlCommand("SELECT COUNT(*) FROM TFERMETURESITE WHERE NSITNUM = " & nSitNum & " AND DDATEFERM = '" & sDate & "'", MozartDatabase.cnxMozart)

    Try

      ' on recherche les fermetures du sites
      If Convert.ToInt32(rsfermeture.ExecuteScalar()) <> 0 Then
        MessageBox.Show("Site indisponible le : " & sDate & " (fermeture exceptionnelle du site)")
        Return False

      Else
        Return True
      End If

    Catch ex As Exception
      MessageBox.Show(ex.Message & vbCrLf & vbCrLf & "dans : " & System.Reflection.MethodBase.GetCurrentMethod.Name)
      Return False

    End Try

  End Function

  Public Function GetMozart_Soc_By_NomSociete(ByVal p_NomSociete As String) As DataTable

    Dim iResponse As Int32 = 0
    Dim DtResponse As DataTable

    Try

      DtResponse = New DataTable

      Dim sqlcmd As New SqlCommand("[api_sp_GetMozart_Soc]", MozartDatabase.cnxMozart)

      sqlcmd.CommandType = CommandType.StoredProcedure
      sqlcmd.Parameters.Add("@P_VNOMSOCIETE", SqlDbType.VarChar).Value = p_NomSociete

      DtResponse.Load(sqlcmd.ExecuteReader)

      Return DtResponse
    Catch ex As Exception
      MessageBox.Show(ex.Message & vbCrLf & vbCrLf & "dans : " & System.Reflection.MethodBase.GetCurrentMethod.Name)
      Return Nothing
    End Try

  End Function

End Module
