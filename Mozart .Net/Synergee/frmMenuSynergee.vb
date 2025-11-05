Imports System.Data.SqlClient
Imports System.IO
Imports System.Net
Imports System.Reflection
Imports System.Threading
Imports MozartLib
Imports Newtonsoft.Json
Imports ReportEmalec.Net
Imports RestSharp
Imports MozartControls
Imports MZUtils = MozartControls.Utils

Public Class frmMenuSynergee

  Dim clsSynergee As New Synergee()

  Dim _NACTNUM As Int32
  Dim URL As String = ""
  Dim API As String = ""
  Dim _NCLINUM As Int32

  Public strObservation As String = ""



  Public Sub New(ByVal NACTNUM As Object)
    InitializeComponent()
    _NACTNUM = NACTNUM
  End Sub

  Private Sub Form1_Load(sender As Object, e As EventArgs) Handles MyBase.Load

    ModuleMain.Initboutons(Me)

    If _NACTNUM <> 0 Then
      txtNumAction.Text = _NACTNUM
      strObservation = ""
      GetInfoConnexionSynergee()
      GetInfoDI()
    Else
      ' on est dans le cas d'une interrogation manuel de Synergee
      ' on lance automatiquement la recherche et on ferme le programme
      LogInfo("Recherche manuelle DI Randstad")
      GetInfoConnexionSynergee(12544)   'randstad
      cmdGetListDI_Click(Nothing, Nothing)

      LogInfo("Recherche manuelle DI Pro Duo")
      GetInfoConnexionSynergee(17913)   'pro duo
      cmdGetListDI_Click(Nothing, Nothing)

      Me.Close()
    End If

  End Sub

  Private Sub LogInfo(sMessage As String)
    ModuleData.ExecuteNonQuery($"Insert into TSYNERGEE_LOG (VLOGMSG) Values ('{sMessage.Replace("'", "''")}')")
  End Sub

  Private Sub cmdGetListDI_Click(sender As Object, e As EventArgs) Handles cmdGetSynergee.Click

    Cursor.Current = Cursors.WaitCursor

    Try
      lstDis.Items.Clear()

      'Dim dateFrom = If(File.Exists(cstLastSynergeeExecDate), File.ReadAllText(cstLastSynergeeExecDate), Date.Now.AddDays(-1).ToString("yyyy-MM-dd"))
      'dans le mode Mozart utilisateur, on utilise pas de fichier de date, on recherche sur j-1 et j
      Dim dateFrom = Date.Now.AddDays(-1).ToString("yyyy-MM-dd")
      Dim dateTo As String = Date.Now.AddDays(1).ToString("yyyy-MM-dd")

      LogInfo($"{vbTab}GetFiles from '{dateFrom}' To '{dateTo}'")

      Dim response As RestResponse = clsSynergee.GetFiles(dateFrom, dateTo, URL, API)
      LogInfo($"{vbTab}GetFiles StatusCode: {response.StatusCode}")

      If response.StatusCode = HttpStatusCode.OK Then
        Dim DIs As cSynergeeDI() = JsonConvert.DeserializeObject(Of cSynergeeDI())(response.Content)

        LogInfo($"{vbTab}GetFiles {DIs.Count} DI")

        If (DIs.Count > 0) Then
          SaveToDB(DIs)
          LogInfo($"{vbTab}SavedToDB ({DIs.Count} DI)")
        End If

        For Each item As cSynergeeDI In DIs
          lstDis.Items.Add($"{item.CompleteStatus} | {item.ID} | {item.UrlId} {vbCrLf}")
        Next
      Else
        txtOut.Text = response.StatusDescription
      End If

    Catch ex As Exception
      LogInfo($"{vbTab}Error: {ex.Message}{Environment.NewLine}{My.Resources.Global_dans}{MethodBase.GetCurrentMethod().Name}")
      'MessageBox.Show($"{ex.Message}\r\n\r\n{My.Resources.Global_dans}{MethodBase.GetCurrentMethod().Name}",
      '                  My.Resources.Global_Erreur, MessageBoxButtons.OK, MessageBoxIcon.Exclamation)
    End Try

    Cursor.Current = Cursors.Default

  End Sub

  ' *****************************************************************************
  ' envoie d'un devis : 
  ' il faut envoyer le document avec AttachFile et les info du devis avec UpdateQuote 
  ' donc il y a 2 appels à des API
  '*******************************************************************************
  Private Sub cmdSendDevis_Click(sender As Object, e As EventArgs) Handles cmdSendDevis.Click

    Dim NumDCL As Integer = 0
    Dim dPrice As String = ""
    Dim TypeDevis As String = ""
    Dim TypeModele As String = ""

    Try

      ' si pas de lien synergee on ne peut pas envoyer la date
      If (txtWorkOrder.Text = "0") Then
        MessageBox.Show("Pas de liaison avec une DI Synergee", MozartParams.NomSociete, MessageBoxButtons.OK, MessageBoxIcon.Exclamation)
        Return
      End If

      Cursor.Current = Cursors.WaitCursor

      ' Recherche des infos sur le devis associé à cette action
      Dim sql As String = "select NSYNNUM, NDCLNUM, CDEVISTYPE, CTYPEMODELE, NDCLHT, DDCLDAT from TDISYNERGEE S INNER JOIN TACT A on A.NACTNUM = S.NACTNUM 
                         INNER JOIN TDCL D ON D.NACTNUM = A.NACTNUM WHERE S.NACTNUM = " & _NACTNUM
      Using cmd As New SqlCommand(sql, MozartDatabase.cnxMozart)
        Dim dr As SqlDataReader = cmd.ExecuteReader()
        If (dr.Read) Then
          NumDCL = dr("NDCLNUM")
          TypeDevis = dr("CDEVISTYPE")
          TypeModele = dr("CTYPEMODELE")
          dPrice = dr("NDCLHT")
        End If
      End Using

      If (NumDCL = 0) Then
        txtOut.Text = "Aucun devis disponible sur cette action !"
        LogInfo($"DI: {txtNumDI.Text}, {txtOut.Text}")
        Return
      End If

      ' Génération du fichier PDF du devis
      Dim sNomReport As String

      Select Case TypeDevis
        Case "F"
          ' devis classique
          Select Case TypeModele
            'Case "F"
            '  sNomReport = "TDevisClientForfait_V2"
            Case "D"
              sNomReport = "TDevisClientDetail_V2"
            Case "M"
              sNomReport = "TDevisClientDetailMODEP_V2"
            Case "A"
              sNomReport = "TDevisClientDetailFournitures_V2"
            Case "P"
              sNomReport = "TDevisClientDetailFournituresPrix_V2"
            Case "H"
              sNomReport = "TDevisClientDetailMODEPFournituresPrix_V2"
            Case Else
              sNomReport = "TDevisClientForfait_V2"
          End Select

        Case "P"
          ' devis prestation
          sNomReport = "TDevisClientPrestationSansDetails"

        Case "B", "G"
          ' Nouveaux devis
          sNomReport = "DEVIS_V2"

        Case Else
          sNomReport = ""
      End Select

      Dim lFrmMainReport As New frmMainReport With {
        .bLaunchByProcessStart = False,
        .sTypeReport = sNomReport,
        .sIdentifiant = NumDCL.ToString(),
        .InfosMail = "TCCL|NCCLCODE|000",
        .sNomSociete = MozartParams.NomSociete,
        .sLangue = "FR",
        .sOption = "PDF",
        .strType = "DC",
        .numAction = _NACTNUM
      }
      lFrmMainReport.ShowDialog()

      Dim sFichierDevis As String = MozartParams.CheminUtilisateurMozart & "PDF\" & NumDCL & ".pdf"

      If (File.Exists(sFichierDevis)) Then
        ' Envoi du fichier (devis pdf)
        LogInfo($"DI: {txtNumDI.Text}, {vbTab}SendFile DI: {txtNumDI.Text}, Action: {_NACTNUM}, Devis: {sFichierDevis}")
        Dim resp = clsSynergee.SendFile(urlid:=txtUrlId.Text, Filename:=sFichierDevis, Shortname:=NumDCL & ".pdf", Scope:="Quote details", cstUrl:=URL, cstApiKey:=API)

        If resp.StatusCode <> HttpStatusCode.OK Then
          txtOut.Text = vbCrLf & vbCrLf & resp.StatusCode & " " & resp.StatusDescription & vbCrLf & resp.Content
          LogInfo($"DI: {txtNumDI.Text}, Action: {_NACTNUM}, Devis: {sFichierDevis}, {vbTab}SendFile DI Error: {txtOut.Text}")
        Else
          txtOut.Text = "Envoi fichier devis : OK" + vbCrLf

          LogInfo($"DI: {txtNumDI.Text}, {txtOut.Text}")

          ' Mise à jour de la DI (envoi des infos du devis)
          LogInfo($"DI: {txtNumDI.Text}, {vbTab}SendDevis DI: {txtNumDI.Text}, Action: {_NACTNUM}, Devis: {NumDCL}")
          resp = clsSynergee.SendDevis(txtUrlId.Text, txtWorkOrder.Text, dPrice.ToString().Replace(",", "."), "Devis " & NumDCL, "Devis " & NumDCL, URL, API)

          If resp.StatusCode <> HttpStatusCode.OK Then
            txtOut.Text &= resp.StatusCode & " " & resp.StatusDescription & vbCrLf & resp.Content
          Else
            txtOut.Text &= vbCrLf & "Envoi infos devis : OK"
            strObservation = $"{strObservation}\r\nEnvoi du devis vers Synergee"

          End If
          LogInfo($"DI: {txtNumDI.Text}, {txtOut.Text}")

        End If
      Else
        txtOut.Text = "Erreur de génération du devis !"
        LogInfo($"DI: {txtNumDI.Text}, {txtOut.Text}")
      End If

      ' Mettre à jour le statut des DI
      cmdGetListDI_Click(Nothing, Nothing)

    Catch ex As Exception
      LogInfo($"DI: {txtNumDI.Text}, {vbTab}Error: {ex.Message}{Environment.NewLine}{My.Resources.Global_dans}{MethodBase.GetCurrentMethod().Name}")
      MZUtils.displayError(MethodBase.GetCurrentMethod().Name, ex)
    Finally
      Cursor.Current = Cursors.Default
    End Try

  End Sub

  Private Sub cmdSendDatePlanif_Click(sender As Object, e As EventArgs) Handles cmdSendDatePlanif.Click

    ' aller chercher la date de planification de l'action et l'envoyer

    Try

      ' si pas de lien synergee on ne peut pas envoyer la date
      If (txtWorkOrder.Text = "0") Then
        MessageBox.Show("Pas de liaison avec une DI Synergee", MozartParams.NomSociete, MessageBoxButtons.OK, MessageBoxIcon.Exclamation)
        Return
      End If


      Cursor.Current = Cursors.WaitCursor
      Dim sActDescription = ""
      Dim DatePla = Nothing

      Using cmd As New SqlCommand("select DACTPLA, VACTDES from TACT WHERE NACTNUM = " & _NACTNUM, MozartDatabase.cnxMozart)
        Dim dr As SqlDataReader = cmd.ExecuteReader()
        If (dr.Read) Then
          DatePla = dr("DACTPLA")
          sActDescription = dr("VACTDES").ToString().Replace(vbCrLf, "\n").Replace(vbCr, "\r").Replace(vbLf, "\n")
        End If
      End Using

      If DatePla = Nothing Then
        txtOut.Text = $"DI: {txtNumDI.Text}, aucune date de planification pour cette action !"
        LogInfo($"DI: {txtNumDI.Text}, {txtOut.Text}")
        Return
      Else
        Dim sDate As String = CDate(DatePla).ToString("yyyy-MM-dd")

        LogInfo($"DI: {txtNumDI.Text}, {vbTab}SendDatePlanification Action: {_NACTNUM}, DACTPLA: {sDate}")

        Dim resp = clsSynergee.SendDateInter(txtUrlId.Text, txtWorkOrder.Text, sDate, sActDescription, URL, API)
        If resp.StatusCode <> HttpStatusCode.OK Then
          txtOut.Text = resp.StatusCode & " " & resp.StatusDescription & vbCrLf & resp.Content
        Else
          txtOut.Text = $"DI: {txtNumDI.Text}, Envoi date de planification : OK"
          strObservation = $"{strObservation}\r\nEnvoi date de planification vers Synergee"
        End If
      End If

      LogInfo($"DI: {txtNumDI.Text}, {txtOut.Text}")

      ' Mettre à jour le statut des DI
      cmdGetListDI_Click(Nothing, Nothing)

    Catch ex As Exception
      LogInfo($"DI: {txtNumDI.Text}, {vbTab}Error: {ex.Message}{Environment.NewLine}{My.Resources.Global_dans}{MethodBase.GetCurrentMethod().Name}")
      MZUtils.displayError(MethodBase.GetCurrentMethod().Name, ex)
    Finally
      Cursor.Current = Cursors.Default
    End Try

  End Sub

  Private Sub cmdSendReport_Click(sender As Object, e As EventArgs) Handles cmdSendReport.Click

    ' si pas de lien synergee on ne peut pas envoyer la date
    If (txtWorkOrder.Text = "0") Then
      MessageBox.Show("Pas de liaison avec une DI Synergee", MozartParams.NomSociete, MessageBoxButtons.OK, MessageBoxIcon.Exclamation)
      Return
    End If

    fraSendReport.Visible = True

  End Sub

  Private Sub cmdPostFact_Click(sender As Object, e As EventArgs)
    Dim dPrice As Double = 100.0
    Dim dTax As Double = 20.0
    Try
      Dim resp = clsSynergee.SendFacture(txtUrlId.Text,
                           dPrice.ToString().Replace(",", "."),
                           dTax.ToString().Replace(",", "."),
                           "Facture",
                           "Facture de test",
                           "2020-10-15", URL, API)
      txtOut.Text = resp.StatusCode & " " & resp.StatusDescription & vbCrLf & resp.Content
      LogInfo($"DI: {txtNumDI.Text}, {txtOut.Text}")
    Catch ex As Exception
      MZUtils.displayError(MethodBase.GetCurrentMethod().Name, ex)
    End Try
  End Sub

  Private Sub cmdFermer_Click(sender As Object, e As EventArgs) Handles cmdFermer.Click
    Dispose()
  End Sub

  Private Sub GetInfoDI()
    Try
      Dim bNewAction As Boolean = False
      Dim nDinNum As Integer = 0
      ' recherche si nouvelle action sur cette DI Synergee
      ' Retrouver la DI à partir de l'action courante
      Dim sql As String = $"select A.NDINNUM, S.NACTNUM, IsNull(S.NSYNNUM, 0) NSYNNUM from TACT A left join TDISYNERGEE S On A.NACTNUM = S.NACTNUM where A.NACTNUM = {_NACTNUM}"
      Using cmd As New SqlCommand(sql, MozartDatabase.cnxMozart)
        Dim dr As SqlDataReader = cmd.ExecuteReader()
        If dr.Read() Then
          nDinNum = dr("NDINNUM")
          txtNumDI.Text = nDinNum
          txtWorkOrder.Text = dr("NSYNNUM")
          If dr("NACTNUM") Is DBNull.Value Then bNewAction = True
        End If
        dr.Close()
      End Using

      ' Créer une ligne dans TDISYNERGEE pour une nouvelle action sur une DI Synergee existante en prenant l'action la plus ancienne
      If bNewAction Then
        Dim nPrevActNum = ModuleData.ExecuteScalarInt($"SELECT TOP 1 NACTNUM FROM TACT WHERE NDINNUM = {nDinNum} ORDER BY NACTID")

        sql = $"Insert Into TDISYNERGEE  select [NSYNNUM], {_NACTNUM}, [NSYNSTATUS], [DSYNDAT], "
        sql += "[VACTDES], [VSYNEQPT], [VSYNCAT], [VSYNCLIENT], [VSYNSITE], [VSYNADR1], [VSYNCP], [VSYNVILLE], [VSYNURLID], "
        sql += $" [CSYNDILOCK], [CSTATUT], cast(NDINNUM as varchar) + '/' + cast(TACT.NACTNUM as varchar), [VCONTACT], {_NCLINUM}, NULL "
        sql += $" FROM TDISYNERGEE CROSS JOIN TACT WHERE TDISYNERGEE.NACTNUM = {nPrevActNum} And TACT.NACTNUM = {_NACTNUM}"
        ModuleData.ExecuteNonQuery(sql)
      End If


      ' Récupérer les informations de cette DI Synergee
      sql = $"Select * from TDISYNERGEE WHERE NACTNUM = {_NACTNUM}"
      Using cmd As New SqlCommand(sql, MozartDatabase.cnxMozart)
        Dim dr As SqlDataReader = cmd.ExecuteReader()
        If (dr.Read) Then
          txtUrlId.Text = dr("VSYNURLID")
          txtWorkOrder.Text = dr("NSYNNUM")
          txtDiDesc.Text = $"{dr("VSYNDESC")}{vbCrLf}DI / Action :  {dr("VDIEMALEC")}"
          lblStatus.Text = GetStatus(dr("NSYNSTATUS"))
        Else
          lblStatus.Text = "Il n'existe pas de DI Synergee associée à cette action !"
        End If
      End Using

    Catch ex As Exception
      LogInfo($"DI: {txtNumDI.Text}, {vbTab}Error: {ex.Message}{Environment.NewLine}{My.Resources.Global_dans}{MethodBase.GetCurrentMethod().Name}")
      MZUtils.displayError(MethodBase.GetCurrentMethod().Name, ex)
    End Try
  End Sub

  Private Sub GetInfoConnexionSynergee()
    Try
      ' recherche des codes du client pour accés Synergee
      Dim sql As String = $"select URL, API, S.NCLINUM from TACT A inner join TDIN D ON A.NDINNUM=D.NDINNUM INNER JOIN TSYNERGEE_TCLI S On D.NCLINUM = S.NCLINUM where A.NACTNUM = {_NACTNUM}"
      Using cmd As New SqlCommand(sql, MozartDatabase.cnxMozart)
        Dim dr As SqlDataReader = cmd.ExecuteReader()
        If dr.Read() Then
          URL = dr("URL")
          API = dr("API")
          _NCLINUM = dr("NCLINUM")
        End If
        dr.Close()
      End Using

    Catch ex As Exception
      LogInfo($"DI: {txtNumDI.Text}, {vbTab}Error: {ex.Message}{Environment.NewLine}{My.Resources.Global_dans}{MethodBase.GetCurrentMethod().Name}")
      MZUtils.displayError(MethodBase.GetCurrentMethod().Name, ex)
    End Try
  End Sub

  Private Sub GetInfoConnexionSynergee(NCLINUM As Integer)
    Try
      ' recherche des codes du client pour accés Synergee
      Dim sql As String = $"select URL, API from TSYNERGEE_TCLI WHERE NCLINUM = {NCLINUM}"
      Using cmd As New SqlCommand(sql, MozartDatabase.cnxMozart)
        Dim dr As SqlDataReader = cmd.ExecuteReader()
        If dr.Read() Then
          URL = dr("URL")
          API = dr("API")
          _NCLINUM = NCLINUM
        End If
        dr.Close()
      End Using

    Catch ex As Exception
      LogInfo($"Robot :{vbTab}Error: {ex.Message}{Environment.NewLine}dans{MethodBase.GetCurrentMethod().Name}")
      MZUtils.displayError(MethodBase.GetCurrentMethod().Name, ex)
    End Try
  End Sub
  Private Function GetStatus(status As String) As String
    Dim ret As String = ""

    Try

      Using cmd As New SqlCommand($"Select VLIBELLE FROM COMMUN.dbo.TREF_ETASYNERGEE Where NSYNSTATUS = {status}", MozartDatabase.cnxMozart)
        ret = cmd.ExecuteScalar().ToString()
      End Using
    Catch ex As Exception
      LogInfo($"DI: {txtNumDI.Text}, {vbTab}Error: {ex.Message}{Environment.NewLine}{My.Resources.Global_dans}{MethodBase.GetCurrentMethod().Name}")
      MZUtils.displayError(MethodBase.GetCurrentMethod().Name, ex)
    End Try
    Return ret
  End Function

  Private Sub SaveToDB(dis As cSynergeeDI())
    Try
      Dim Equipement As String = "Autres"

      Using cmd As New SqlCommand("", MozartDatabase.cnxMozart)
        For Each di As cSynergeeDI In dis

          ' gestion des cas ou il n'y a pas d'équipement
          If (di.Equipment.Fr <> Nothing) Then
            Equipement = di.Equipment.Fr.Replace("'", "''")
          Else
            Equipement = "Autres"
          End If

          cmd.CommandText = $"Exec [api_sp_AddDiSynergee] 
            {di.ID}, 
            {di.CompleteStatus}, 
            '{di.RequestDate.ToLocalTime()}',         
            '{di.Description.Replace("'", "''")}', 
            '{Equipement}', 
            '{di.Category.Fr.Replace("'", "''")}', 
            '{di.POS.Brand.Name.Replace("'", "''")}', 
            '{di.POS.POSNumber.Replace("'", "''")}', 
            '{di.POS.Street.Replace("'", "''")}', 
            '{di.POS.ZipCode}', 
            '{di.POS.City}',
            '{di.UrlId}',
            {_NCLINUM}"
          cmd.ExecuteNonQuery()
        Next
      End Using
    Catch ex As Exception
      LogInfo($"DI: {txtNumDI.Text}, {vbTab}Error: {ex.Message}{Environment.NewLine}{My.Resources.Global_dans}{MethodBase.GetCurrentMethod().Name}")
      'MZUtils.displayError(MethodBase.GetCurrentMethod().Name, ex)
    End Try
  End Sub


  Private Sub cmdOk_Click(sender As Object, e As EventArgs) Handles cmdOk.Click

    Dim NewInterventionDate As String = ""

    fraSendReport.Visible = False

    Dim bProblemResolved As Boolean = optResoluYes.Checked
    If (bProblemResolved And chkInterPlanifiee.Checked) Then
      NewInterventionDate = dtpNewInter.Value.ToShortDateString()
    End If

    Dim dDateDebut As DateTime = Nothing
    Dim dDateFin As DateTime = Nothing
    Dim sActObservation As String = ""

    Try
      Cursor.Current = Cursors.WaitCursor
      ' Rechercher les dates d'intervention
      Dim sql As String = "select DACTARR, DACTDEX, VACTDES from TACT join TACTCOMP on TACT.NACTNUM = TACTCOMP.NACTNUM Where TACT.NACTNUM  = " & _NACTNUM
      Using cmd As New SqlCommand(sql, MozartDatabase.cnxMozart)
        Dim dr As SqlDataReader = cmd.ExecuteReader()
        If (dr.Read) Then
          If (dr("DACTARR").ToString() = "" Or dr("DACTDEX").ToString() = "") Then
          Else
            dDateDebut = CDate(dr("DACTARR"))    ' Pas de conversion en temps UTC
            dDateFin = CDate(dr("DACTDEX"))      ' Pas de conversion en temps UTC
            sActObservation = dr("VACTDES").ToString().Replace(vbCrLf, "\n").Replace(vbCr, "\r").Replace(vbLf, "\n")
          End If
        End If
      End Using

      If (dDateDebut = Nothing) Then
        txtOut.Text = "Cette action n'a pas de début d'intervention ou pas de date d'exécution !"
        LogInfo($"DI: {txtNumDI.Text}, {txtOut.Text}")
        Return
      End If

      ' L'attachement doit obligatoirement être envoyé sinon on ne peut pas envoyer la requête ReportIntervention qui suit

      ' VL 27/09/21 : ne plus envoyer l'attachement avant la date d'exécutuion !

      'Dim sFile As String = ExecuteScalarString($"Exec api_sp_GetFileAttachementByAction {_NACTNUM}")
      'Dim sRep As String

      'If (sFile <> "") Then
      '  sRep = ExecuteScalarString($"SELECT VPARVAL FROM TPAR WHERE VPARLIB = 'REP_ATTGAM' AND VSOCIETE = '{gstrNomSociete}'")
      '  LogInfo($"DI: {txtNumDI.Text}, {vbTab}SendFile Action: {_NACTNUM}, Attachement: {sRep & sFile}")
      '  If (File.Exists(sRep & sFile) = False) Then
      '    txtOut.Text = $"Attachement '{sFile}' introuvable !"
      '    LogInfo($"DI: {txtNumDI.Text}, {txtOut.Text}")
      '    Return
      '  End If

      '  ' Envoi de l'attachement
      '  Dim resp = clsSynergee.SendFile(urlid:=txtUrlId.Text, Filename:=sRep & sFile, Shortname:=sFile, Scope:="Intervention report")

      '  If resp.StatusCode <> HttpStatusCode.OK Then
      '    txtOut.Text &= resp.StatusCode & " " & resp.StatusDescription & vbCrLf & resp.Content
      '  Else
      '    txtOut.Text = "Envoi rapport intervention : OK" + vbCrLf
      '  End If
      'End If

      ' Mise à jour de la DI
      LogInfo($"DI: {txtNumDI.Text}, {vbTab}SendReportInter Action: {_NACTNUM}, DACTARR: {dDateDebut}, DACTDEX: {dDateFin}")

      '  Envoi de la date d'exécution
      Dim resp2 = clsSynergee.SendReportInter(txtUrlId.Text, txtWorkOrder.Text, dDateDebut.ToString("yyyy-MM-dd HH:mm:ss"),
                                              dDateFin.ToString("yyyy-MM-dd HH:mm:ss"), sActObservation, bProblemResolved, NewInterventionDate, URL, API)
      If resp2.StatusCode <> HttpStatusCode.OK Then
        txtOut.Text &= resp2.StatusCode & " " & resp2.StatusDescription & vbCrLf & resp2.Content
      Else
        txtOut.Text &= vbCrLf & "Envoi date intervention : OK"
        strObservation = $"{strObservation}\r\nEnvoi date intervention vers Synergee"
      End If

      LogInfo($"DI: {txtNumDI.Text}, {txtOut.Text}")

      ' Mettre à jour le statut des DI
      cmdGetListDI_Click(Nothing, Nothing)

    Catch ex As Exception
      LogInfo($"DI: {txtNumDI.Text}, {vbTab}Error: {ex.Message}{Environment.NewLine}{My.Resources.Global_dans}{MethodBase.GetCurrentMethod().Name}")
      MZUtils.displayError(MethodBase.GetCurrentMethod().Name, ex)
    Finally
      Cursor.Current = Cursors.Default
    End Try

  End Sub

  Private Sub cmdAttachement_Click(sender As Object, e As EventArgs) Handles cmdAttachement.Click

    ' les documents ne peuvent pas être envoyé si on a envoyé la date d'exécution (statut terminé)
    ' il faut tester le statut Synergee de la demande.
    Dim SynStatut As Int32 = Nothing

    Try

      ' si pas de lien synergee on ne peut pas envoyer 'info
      If (txtWorkOrder.Text = "0") Then
        MessageBox.Show("Pas de liaison avec une DI Synergee", MozartParams.NomSociete, MessageBoxButtons.OK, MessageBoxIcon.Exclamation)
        Return
      End If

      Cursor.Current = Cursors.WaitCursor

      ' Rechercher le statut Synergee
      Dim sql As String = "select NSYNSTATUS from TDISYNERGEE WHERE NACTNUM = " & _NACTNUM

      Using cmd As New SqlCommand(sql, MozartDatabase.cnxMozart)
        Dim dr As SqlDataReader = cmd.ExecuteReader()
        If (dr.Read) Then
          SynStatut = dr("NSYNSTATUS")
        Else
          lblStatus.Text = "Il n'existe pas de DI Synergee associée à cette action !"
          Return
        End If
      End Using

      '' si le statut est supérieur à 7 , on est dans les cas ou la demande est close chez Synergee, on ne peut pas joindre des docs
      'If SynStatut > 7 Then
      '  txtOut.Text = "Le statut de cette demande ne permet pas d'envoyer des documents"
      '  LogInfo($"DI: {txtNumDI.Text}, {txtOut.Text}")
      '  Return
      'End If

      ' recherche de l'attachement sur l'action
      Dim sFile As String = ""
      Dim sRep As String
      Using cmdA As New SqlCommand($"Exec api_sp_GetFileAttachementByAction {_NACTNUM}", MozartDatabase.cnxMozart)
        Dim dra As SqlDataReader = cmdA.ExecuteReader()

        If (dra.Read) Then

          sFile = dra("VFICHIER")

          If (dra("VTYPE").ToString() = "IMAGE") Then
            sRep = ModuleData.ExecuteScalarString($"SELECT VPARVAL FROM TPAR WHERE VPARLIB = 'REP_PHOTOS_ACT' AND VSOCIETE = '{MozartParams.NomSociete}'")
          Else
            sRep = ModuleData.ExecuteScalarString($"SELECT VPARVAL FROM TPAR WHERE VPARLIB = 'REP_ATTGAM' AND VSOCIETE = '{MozartParams.NomSociete}'")
          End If

          dra.Close()

        End If

      End Using

      If (sFile <> "") Then
        LogInfo($"DI: {txtNumDI.Text}, {vbTab}SendFile DI: {txtNumDI.Text}, Action: {_NACTNUM}, Attachement: {sRep & sFile}")
        If (File.Exists(sRep & sFile) = False) Then
          txtOut.Text = $"Attachement '{sFile}' introuvable !"
          LogInfo($"DI: {txtNumDI.Text}, {txtOut.Text}")
          Return
        End If

        ' Envoi de l'attachement
        Dim resp = clsSynergee.SendFile(urlid:=txtUrlId.Text, Filename:=sRep & sFile, Shortname:=sFile, Scope:="Intervention report", cstUrl:=URL, cstApiKey:=API) 'URL API

        If resp.StatusCode <> HttpStatusCode.OK Then
          txtOut.Text &= resp.StatusCode & " " & resp.StatusDescription & vbCrLf & resp.Content
        Else
          txtOut.Text = "Envoi du document : OK" + vbCrLf
          strObservation = $"{strObservation}\r\nEnvoi attachement vers Synergee"
        End If
      End If

    Catch ex As Exception
      LogInfo($"DI: {txtNumDI.Text}, {vbTab}Error: {ex.Message}{Environment.NewLine}{My.Resources.Global_dans}{MethodBase.GetCurrentMethod().Name}")
      MZUtils.displayError(MethodBase.GetCurrentMethod().Name, ex)
    Finally
      Cursor.Current = Cursors.Default
    End Try
  End Sub

  Private Sub optResoluNo_CheckedChanged(sender As Object, e As EventArgs) Handles optResoluNo.CheckedChanged
    chkInterPlanifiee.Visible = optResoluNo.Checked
  End Sub

  Private Sub chkInterPlanifiee_CheckedChanged(sender As Object, e As EventArgs) Handles chkInterPlanifiee.CheckedChanged
    lblLabels0.Visible = chkInterPlanifiee.Checked
    dtpNewInter.Visible = chkInterPlanifiee.Checked
  End Sub

  Function format_json(json As String) As String
    Return JsonConvert.SerializeObject(JsonConvert.DeserializeObject(json), Formatting.Indented)
  End Function

  Private Sub Command2_Click(sender As Object, e As EventArgs) Handles Command2.Click
    fraSendReport.Visible = False
  End Sub

End Class
