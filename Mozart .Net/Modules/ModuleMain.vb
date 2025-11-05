Imports System.Data.SqlClient
Imports System.Text.RegularExpressions.Regex
Imports DevExpress.XtraTab
Imports MozartLib

Public Module ModuleMain
  Public giNumDi As Long
  Public glNumAction As Long

  ' TB SAMSIC CITY SPEC
  Public gstrUserSignatureMail As String = ""
  Dim gstrForm As String
  Dim gstrParam() As Object

  Public TxMOOuv As Integer
  Public TxMOInt As Integer
  Public TxMOAss As Integer
  Public TxMOChaf As Integer
  Public TxMOBE As Integer
  Public TxPanier As Integer
  Public TxGD As Integer
  Public TxKM As Double = 0.42
  Public TxDeplace As Double = 30

  Public TxMO_Meca As Int32
  Public TxMO_Cabl As Int32
  Public TxMO_AideTec As Int32

  Public TxMOBE_Auto As Int32
  Public TxMOBE_Elec As Int32
  Public TxMOBE_Meca As Int32

  Public gstrCheminFicheFourniture As String
  Public gstrCheminChantierDoc As String
  Public gstrCheminChantierPlanning As String
  Public gstrCheminDocSTFCondCom As String
  Public gstrCheminDocClientWeb As String
  Public gstrCheminActDocSecure As String

  Private mJoursFeries As Dictionary(Of DateTime, DateTime)

  'Public Sub Main()
  'mJoursFeries = Nothing

  '' on recupere les paramètres d'execution
  'If Environment.GetCommandLineArgs.Length >= 4 Then
  '  MozartParams.NomServeur = Environment.GetCommandLineArgs()(1)
  '  MozartParams.NomSociete = Environment.GetCommandLineArgs()(2)
  '  gstrForm = Environment.GetCommandLineArgs()(3)

  '  If Environment.GetCommandLineArgs.Length = 5 Then
  '    gstrParam = Environment.GetCommandLineArgs()(4).Split("|")
  '  End If

  'Else
  '  MozartParams.NomServeur = "SRV-VMSQLPROD"
  '  MozartParams.NomSociete = "EMALEC"
  '  gstrForm = "FrmQCMListe"
  'End If

  ''MessageBox.Show(gstrNomServeur & " " & gstrNomSociete & " " & gstrForm)

  'ConnexionBase()

  'If MozartParams.Langue IsNot Nothing And MozartParams.Langue <> "FR" Then
  '  'changement langue
  '  My.Application.ChangeUICulture(MozartParams.Langue)
  'End If

  'MozartParams.NomGroupe = InitNomGroupe()

  '' The following line provides localization for the application's user interface. 
  ''Thread.CurrentThread.CurrentUICulture = Culture

  '' The following line provides localization for data formats. 
  ''Thread.CurrentThread.CurrentCulture = Culture

  '' Set this culture as the default culture for all threads in this application.  
  '' Note: The following properties are supported in the .NET Framework 4.5+ 
  ''CultureInfo. = Culture
  ''CultureInfo.DefaultThreadCurrentUICulture = Culture

  ''pour l ananlytique chantier, on charge la valeur des taux de gestion
  ''If gstrForm = "ANACHANTIER" Or gstrForm = "frmMenuChantierAnalytique" Or gstrForm = "frmXListeWithChiffrage" Then LoadChantierTAUX()

  'LoadChantierTAUX()

  '' ONLY FOR MIGRATION
  'If gstrForm <> "APITECHTEST" Then
  '  OuvertureForm(gstrForm, gstrParam)
  'End If

  'End Sub

  'Private Sub OuvertureForm(ByVal P_Form As String, ByVal P_Param() As Object)

  '  Dim test As Assembly = Assembly.GetExecutingAssembly

  '  'Dim test As New frmQCMListe 

  '  'MsgBox(Application.ProductName)

  '  'on test le parametre 'P_Form' pour orienter l'ouverture du formulaire
  '  Select Case P_Form
  '    Case "ANACHANTIER"
  '      'frmXListe.ShowDialog()

  '      Using oFrmXListeWIthChiff As New frmXListeWithChiffrage()
  '        oFrmXListeWIthChiff.ShowDialog()
  '      End Using

  '      'Dim oFrmMenuChantierAnalytique As New frmMenuChantierAnalytique
  '      'oFrmMenuChantierAnalytique.ShowDialog()

  '    Case Else
  '      Try
  '        Dim frmLoader As Object = Activator.CreateInstance(test.GetType(Application.ProductName + "." + P_Form, True, True), P_Param) 'new object() { 612, "CAVALLARO"} new object() { P_Param(0) , P_Param(1)} 
  '        frmLoader.ShowDialog()

  '      Catch ex As Exception
  '        MessageBox.Show("CAS D'OUVERTURE NON IDENTIFIE! : " + ex.Message + vbCrLf + ex.InnerException.ToString(), "ERREUR CHARGEMENT", MessageBoxButtons.OK, MessageBoxIcon.Warning)
  '      End Try
  '  End Select

  'End Sub

  Public Sub ConnexionBase()

    MozartDatabase.cnxMozart.ConnectionString = String.Format("Data Source={0};Database=MULTI;MultipleActiveResultSets=True;trusted_connection=true;APP={1}", MozartParams.NomServeur, MozartParams.NomSociete)
    MozartDatabase.cnxMozart.Open()

    RechercheParam()

    GetUserConnecte()

  End Sub

  'Public Function RechercheMail(ByVal iDest As Long, ByVal sType As String) As Boolean

  '  Dim cmd As New SqlCommand("", MozartDatabase.cnxMozart)

  '  Select Case sType
  '    Case "Client"
  '      cmd.CommandText = "SELECT count(*) from TCCL where VCCLMAIL is not null AND NCCLNUM = " & iDest
  '    Case "Sous-traitant", "Fournisseur"
  '      cmd.CommandText = "SELECT count(*) from TINT where VINTMAIL is not null AND NINTNUM = " & iDest
  '    Case "Site"
  '      cmd.CommandText = "SELECT count(*) FROM TSIT, TCSIT WHERE VSITMAI IS NOT NULL AND TCSIT.NSITNUM = TSIT.NSITNUM AND TCSIT.NTYPCSITNUM = 1 AND TSIT.NSITNUM = " & iDest
  '    Case "Personnel"
  '      cmd.CommandText = "SELECT count(*) from TPER where VPERMAI is not null AND NPERNUM = " & iDest
  '  End Select

  '  Using dr As SqlDataReader = cmd.ExecuteReader()
  '    dr.Read()
  '    Return IIf(Convert.ToInt32(dr(0)) = 0, False, True)
  '  End Using

  'End Function

  Private Sub RechercheParam()
    MozartParams.CheminModeles = ModuleData.RechercheParam("REP_MODELES", MozartParams.NomSociete)
    MozartParams.CheminFicheTech = ModuleData.RechercheParam("REP_FICHETECH", MozartParams.NomSociete)
    MozartParams.CheminDocAdminSTF = ModuleData.RechercheParam("REP_DOC_STF", MozartParams.NomSociete)

    MozartParams.RoleFacturation = RechercheRoleNomme("Facturation")

    gstrCheminFicheFourniture = ModuleData.RechercheParam("REP_FICHE_FOURN", MozartParams.NomSociete)

    'document chantier
    gstrCheminChantierDoc = ModuleData.RechercheParam("REP_DOC_CHANTIER", MozartParams.NomSociete)

    'document STF Conditions commerciales
    gstrCheminDocSTFCondCom = ModuleData.RechercheParam("REP_DOC_COND_COM_STF", MozartParams.NomSociete)

    'chantier planning XLS
    gstrCheminChantierPlanning = ModuleData.RechercheParam("REP_CHANTIER_PLANNING", MozartParams.NomSociete)

    'Doc technicien
    MozartParams.CheminDocTechnicien = ModuleData.RechercheParam("REP_DOC_TECH", MozartParams.NomSociete)

    'Doc technicien
    gstrCheminDocClientWeb = ModuleData.RechercheParam("REP_INFO", MozartParams.NomSociete)

    ' Chemin acces à MozartNEt et autres progs
    MozartParams.CheminMozart = ModuleData.RechercheParam("REP_MOZART", MozartParams.NomSociete)
  End Sub

  Public Function RechercheParamByLib(ByVal p_VPARLIB As String) As String
    Return ModuleData.RechercheParam(p_VPARLIB, MozartParams.NomSociete)
  End Function

  Public Function RechercheRoleNomme(sRole As String) As String
    Return ExecuteScalarString("Select dbo.GetRole('" + sRole + "') as FACT")
  End Function

  Public Function RechercheTrad(sCle As String, sLangue As String) As String
    Return ExecuteScalarString($"SELECT Chaine{sLangue} FROM COMMUN.dbo.TLGMOZART where Fichier = 'CodeVB{MozartParams.NomSociete}' and Chaine = '{sCle}'")
  End Function

  Public Function RechercheModele(strTypeCour As String, Optional sTypExp As String = "") As String

    Dim retour As String = ""
    If sTypExp = "" Then
      Select Case strTypeCour
        Case "A"
          retour = "TAttestation.rtf"   ' TCCL / TSIT
        Case "C"
          retour = "TAttestationElec.rtf"   ' TCCL / TSIT
        Case "L", "M"
          retour = "TLettreV3.rtf"
        Case "B"
          retour = "TBordereau.rtf"
        Case "N"
          retour = "TNoteService.rtf"
        Case "F"
          retour = "TFax.rtf"
      End Select
      ' Normalement cela ne sert pus à rien. Les modèles sont identiques mais des répertoires différents
    ElseIf sTypExp = "SAS" Then
      Select Case strTypeCour
'       Case "A"
'         retour = "TAttestationSAS.rtf"   ' TCCL / TSIT
        Case "L", "M"
          retour = "TLettreV3.rtf"
      End Select
    End If
    Return retour
  End Function

  Public Function InitNomGroupe() As String
    Dim sPathReturn As String
    Dim dr As SqlDataReader

    Dim cmd As New SqlCommand("api_sp_getGroupe", MozartDatabase.cnxMozart) With {
      .CommandType = CommandType.StoredProcedure
    }

    dr = cmd.ExecuteReader
    dr.Read()
    sPathReturn = dr(0).ToString.ToUpper()
    dr.Close()

    Return sPathReturn
  End Function

  Private Sub GetUserConnecte()

    Dim cmd As SqlCommand = Nothing
    Dim dr As SqlDataReader = Nothing

    Try
      cmd = New SqlCommand("select upper(dbo.GetUserName()), dbo.GetUserID(),  dbo.GetUserMail(), dbo.[GetUserSignatureMail](), dbo.[GetUserLangueSys]() ", MozartDatabase.cnxMozart)
      dr = cmd.ExecuteReader()
      dr.Read()
      MozartParams.strUID = dr(0) ' c'est le vperadsi
      MozartParams.UID = dr(1)
      MozartParams.UserMail = dr(2)
      gstrUserSignatureMail = dr(3)
      MozartParams.Langue = dr(4)
      'sLanguageAppli = "ES"

      ' C'est le bordel ici, on devrait tout charger directement ici et pas dans frmMenu.cs
      Dim lMULTIEntities As New MULTIEntities()
      Dim lCOMMUNEntities As New COMMUNEntities()

      ' HAMMANI IDF MozartParams.UID = 2654
      'MozartParams.UID = 253
      'MozartParams.UID = 300
      'MozartParams.UID = 4468
      If Debugger.IsAttached Then
        'MozartParams.UID = 253
      End If

      MozartParams.UserConnecte = New CUserConnecte(lMULTIEntities.TPER.Where(Function(x) x.NPERNUM = MozartParams.UID).FirstOrDefault())

      Dim idSoc As Integer
      idSoc = lCOMMUNEntities.TSOCIETE.Where(Function(x) x.VSOCIETENOM = MozartParams.NomSociete).FirstOrDefault().NSOCIETEID
      MozartParams.UserConnecte.NSOCIETEID = idSoc

    Catch ex As Exception
      MessageBox.Show("Vous n'avez pas les droits pour vous connecter", "Erreur", MessageBoxButtons.OK, MessageBoxIcon.Error)
      End
    Finally
      If dr IsNot Nothing Then dr.Close()
      If cmd IsNot Nothing Then cmd.Dispose()
    End Try

  End Sub

  'fonction permettant de charger les taux de gestion pour l'analytique chantier
  Public Sub LoadChantierTAUX()

    Dim dr As SqlDataReader
    Dim cmd As New SqlCommand("SELECT NTAUXMOOUV, NTAUXMOINT, NTAUXMOASS, NTAUXMOCHAF, NTAUXMOBE, NTAUXPANIER, NTAUXGD, NTAUXKM, NTAUXMO_MECA, NTAUXMO_CABL, NTAUXMO_AIDETEC, NTAUXMOBE_AUTO, NTAUXMOBE_ELEC, NTAUXMOBE_MECA, NTAUX_DEPLACE FROM TCHANTIERTAUX WHERE VSOCIETE = '" & MozartParams.NomSociete & "'", MozartDatabase.cnxMozart)
    dr = cmd.ExecuteReader

    If dr.HasRows Then

      dr.Read()
      TxMOOuv = dr.Item("NTAUXMOOUV")
      TxMOInt = dr.Item("NTAUXMOINT")
      TxMOAss = dr.Item("NTAUXMOASS")
      TxMOChaf = dr.Item("NTAUXMOCHAF")
      TxMOBE = dr.Item("NTAUXMOBE")
      TxPanier = dr.Item("NTAUXPANIER")
      TxGD = dr.Item("NTAUXGD")
      TxKM = dr.Item("NTAUXKM")
      TxDeplace = dr.Item("NTAUX_DEPLACE")

      TxMO_Meca = dr.Item("NTAUXMO_MECA")
      TxMO_Cabl = dr.Item("NTAUXMO_CABL")
      TxMO_AideTec = dr.Item("NTAUXMO_AIDETEC")

      TxMOBE_Auto = dr.Item("NTAUXMOBE_AUTO")
      TxMOBE_Elec = dr.Item("NTAUXMOBE_ELEC")
      TxMOBE_Meca = dr.Item("NTAUXMOBE_MECA")

    Else
      'valeur par défaut
      TxMOOuv = 30
      TxMOInt = 32
      TxMOAss = 28
      TxMOChaf = 45
      TxMOBE = 45
      TxPanier = 12
      TxGD = 85
      TxKM = 0.42
      TxDeplace = 30

      TxMO_Meca = 30
      TxMO_Cabl = 30
      TxMO_AideTec = 30

      TxMOBE_Auto = 45
      TxMOBE_Elec = 45
      TxMOBE_Meca = 45

    End If

    dr.Close()

  End Sub

  Public Function RechercheHeureRef(ByVal iMois As Int32, ByVal iYear As Int32) As Int32

    Dim DateCourant As Date
    Dim Mois As Int32
    Dim iRechercheHeureRef As Int32

    Try

      ' initialisation
      DateCourant = CDate("01/" & Format(iMois, "00") & "/" & iYear)
      Mois = DateCourant.Month

      While DateCourant.Month = Mois
        ' si ce n'est pas un weekend ou un jour fériée on ajout 8 heures
        If DateCourant.DayOfWeek <> 6 And DateCourant.DayOfWeek <> 0 Then
          If Not IsFeriee(DateCourant) Then
            If DateCourant.DayOfWeek = 5 Then ' vendredi 7 heures
              iRechercheHeureRef = iRechercheHeureRef + 7
            Else
              iRechercheHeureRef = iRechercheHeureRef + 8
            End If
          End If
        End If
        DateCourant = DateAdd(DateInterval.Day, 1, DateCourant)
      End While

      Return iRechercheHeureRef

    Catch ex As Exception

      MessageBox.Show("Erreur dans ModMain - RechercheHeureRef : " + ex.Message)
      Return 0

    End Try

  End Function


  Class Info
    Public sType As String
    Public dTable As DataTable
  End Class

  Public Sub Initboutons(ByVal Frm As Form)
    Try
      Dim societe As String = MozartParams.GetNomSociete().ToUpper()

      If Frm.MinimizeBox <> Nothing And Frm.Name <> "frmMenu" Then Frm.MinimizeBox = False
      'If Frm.Name <> "frmMenu" Then Frm.ShowInTaskbar = False

      For Each c In Frm.Controls

        If TypeOf c Is Button OrElse TypeOf c Is Label OrElse TypeOf c Is GroupBox OrElse TypeOf c Is CheckBox OrElse TypeOf c Is MozartUC.apiCheckBox Then

          c.Text = c.Text.ToString.Replace("$ste", societe)

          If c.GetType().GetProperty("HelpContextID") Is Nothing Then
            c.visible = 0 <> bAccesBouton(c.Tag)
          ElseIf c.HelpContextID <> 0 Then
            c.visible = 0 <> bAccesBouton(c.HelpContextID)
          End If

        ElseIf TypeOf c Is XtraTabControl Then

          For Each TabPage As XtraTabPage In c.TabPages
            TabPage.Text = TabPage.Text.ToString.Replace("$ste", societe)
            TabPage.PageVisible = 0 <> bAccesBouton(TabPage.Tag)
          Next

        End If

        If TypeOf c Is GroupBox OrElse TypeOf c Is TableLayoutPanel OrElse TypeOf c Is FlowLayoutPanel Then

          'recherche dans groupbox
          For Each GrpCtrl In c.Controls

            If TypeOf GrpCtrl Is Button OrElse TypeOf GrpCtrl Is Label OrElse TypeOf GrpCtrl Is GroupBox _
            OrElse TypeOf GrpCtrl Is CheckBox OrElse TypeOf GrpCtrl Is MozartUC.apiCheckBox Then

              GrpCtrl.Text = GrpCtrl.Text.ToString.Replace("$ste", societe)
              If GrpCtrl.GetType().GetProperty("HelpContextID") Is Nothing Then
                GrpCtrl.Visible = 0 <> bAccesBouton(GrpCtrl.Tag)
              ElseIf GrpCtrl.HelpContextID <> 0 Then
                GrpCtrl.Visible = 0 <> bAccesBouton(GrpCtrl.HelpContextID)
              End If

            End If

            'ajout
            If TypeOf GrpCtrl Is GroupBox OrElse TypeOf GrpCtrl Is TableLayoutPanel OrElse TypeOf c Is FlowLayoutPanel Then

              'recherche dans groupbox
              For Each GrpFrame In GrpCtrl.Controls

                If TypeOf GrpFrame Is Button OrElse TypeOf GrpFrame Is Label OrElse TypeOf GrpFrame Is GroupBox _
                OrElse TypeOf GrpFrame Is CheckBox OrElse TypeOf GrpFrame Is MozartUC.apiCheckBox Then

                  GrpFrame.Text = GrpFrame.Text.ToString.Replace("$ste", societe)
                  If GrpFrame.GetType().GetProperty("HelpContextID") Is Nothing Then
                    GrpFrame.Visible = 0 <> bAccesBouton(GrpFrame.Tag)
                  ElseIf GrpFrame.HelpContextID <> 0 Then
                    GrpFrame.Visible = 0 <> bAccesBouton(GrpFrame.HelpContextID)
                  End If
                End If

                'ajout 2 (pour la gestion des contrôles qui sont dans 2 groupe box imbriqués)
                If TypeOf GrpFrame Is GroupBox OrElse TypeOf c Is FlowLayoutPanel Then

                  'recherche dans groupbox
                  For Each obj In GrpFrame.Controls
                    If TypeOf obj Is Button OrElse TypeOf obj Is Label OrElse TypeOf obj Is CheckBox OrElse TypeOf obj Is GroupBox Then
                      obj.Text = obj.Text.ToString.Replace("$ste", societe)
                      If obj.GetType().GetProperty("HelpContextID") Is Nothing Then
                        obj.Visible = 0 <> bAccesBouton(obj.Tag)
                      ElseIf obj.HelpContextID <> 0 Then
                        obj.Visible = 0 <> bAccesBouton(obj.HelpContextID)
                      End If
                    End If

                    'ajout 3 (pour la gestion des contrôles qui sont dans 3 groupe box imbriqués)
                    If TypeOf obj Is GroupBox OrElse TypeOf c Is FlowLayoutPanel Then
                      'recherche dans groupbox
                      For Each ctrlobj In obj.Controls
                        If TypeOf ctrlobj Is Button OrElse TypeOf ctrlobj Is Label OrElse TypeOf ctrlobj Is CheckBox OrElse TypeOf ctrlobj Is GroupBox OrElse TypeOf c Is FlowLayoutPanel Then
                          ctrlobj.Text = ctrlobj.Text.ToString.Replace("$ste", societe)
                          If ctrlobj.GetType().GetProperty("HelpContextID") Is Nothing Then
                            ctrlobj.Visible = 0 <> bAccesBouton(ctrlobj.Tag)
                          ElseIf ctrlobj.HelpContextID <> 0 Then
                            ctrlobj.Visible = 0 <> bAccesBouton(ctrlobj.HelpContextID)
                          End If
                        End If
                      Next
                    End If
                    'fin ajout 3

                  Next
                End If
                'fin ajout 2

              Next
              'fin ajout

            End If

          Next
        End If

      Next

      Frm.Text += " " + MozartParams.GetNomSociete()

      If MozartParams.NomServeur <> "SRV-VMSQLPROD" Then
        Frm.Text += "  " + MozartParams.NomServeur
      End If

    Catch ex As Exception

      MessageBox.Show("Erreur dans ModMain - Initboutons : " + ex.Message)

    End Try

  End Sub

  Private mDroits As CDroits

  '*****************************************************************************************************************************
  'Fonction permettant de géré l affichage des composant selon les droits utilsiateurs
  '0 = non visible
  '1 = visible
  '20 = on ne fait rien (permet de respecter l etat visible selon la source)
  '*****************************************************************************************************************************
  Public Function bAccesBouton(ByVal p_iNmenunum As String) As Int16
    '' Autoriser tous les boutons si on teste depuis une session Visual Studio uniquement
    ''If Debugger.IsAttached Then
    ''Return 1
    ''End If

    Try
      ' Init de la table des droits
      If mDroits Is Nothing Then
        mDroits = New CDroits()
      End If

      Return mDroits.getRight(p_iNmenunum)
    Catch ex As Exception
      MessageBox.Show("Erreur dans ModMain - bAccesBouton : " + ex.Message)
      Return 0
    End Try

  End Function

  Public Function RechercheDroitMenu(ByVal IdMenu As Long) As Boolean
    Return (bAccesBouton(IdMenu) = 1)
  End Function


  Public Function GetNCLINUM_On_VSOCIETE(ByVal p_NomSociete As String) As Int32

    Select Case p_NomSociete.ToUpper
      Case "EMALEC"
        Return 108
      Case "FITELEC"
        Return 2002
      Case "EQUIPAGE"
        Return 3001
      Case "EMALECO"
        Return 4001
      Case "ALC"
        Return 5891
      Case "SCS"
        Return 4030
      Case "MAGESTIME"
        Return 8396
      Case "EMASOLAR"
        Return 8493
      Case Else
        Return 0
    End Select

  End Function
  '******************************************************************************************
  '
  '******************************************************************************************
  Public Function IsFeriee(ByVal Jour As Date) As Boolean

    Dim sqlcmd As SqlCommand
    Dim sSql

    Try

      ' Dictionnaire des jours fériés encore pas initialisé : On les charge en mémoire
      If mJoursFeries Is Nothing Then
        mJoursFeries = New Dictionary(Of DateTime, DateTime)

        sSql = "select distinct DFERDAT from TFERIE where VSOCIETE = APP_NAME()"
        sqlcmd = New SqlCommand(sSql, MozartDatabase.cnxMozart)

        Dim oDr As SqlDataReader = sqlcmd.ExecuteReader
        Dim lTmpDate As Date

        While oDr.Read()
          lTmpDate = Convert.ToDateTime(oDr(0))
          mJoursFeries.Add(lTmpDate, lTmpDate)
        End While

        oDr.Close()
      End If

    Catch ex As Exception
      MessageBox.Show("Erreur : IsFeriee dans modMain :" + ex.Message)
      Return False
    End Try

    Try
      Return mJoursFeries.ContainsKey(Jour.Date)
    Catch ex As Exception
      Return False
    End Try

  End Function

  '*****************************************************************************************************************************************************************************
  'Cette fonction permet de cocher ou decocher les rows filters dans une gridview
  '*****************************************************************************************************************************************************************************
  Public Sub CocherAllFilterTous_Or_DecocheAllFilter(ByVal oDtCoche As DataTable, ByVal sFieldNameCheck As String, ByVal sFilterCondition As DevExpress.Data.Filtering.CriteriaOperator, ByVal sValue As Boolean)

    Dim DvFilter() As DataRow
    Dim i As Int32

    DvFilter = oDtCoche.Select(DevExpress.Data.Filtering.CriteriaToWhereClauseHelper.GetDataSetWhere(sFilterCondition))

    If DvFilter.Length >= 1 Then

      For i = 0 To DvFilter.Length - 1

        DvFilter(i).Item(sFieldNameCheck) = sValue

      Next

    End If

  End Sub
  '******************************************************************************************************************************************************************************
  'Obtenir le premier jour de la semaine
  '******************************************************************************************************************************************************************************
  Public Function getFirstDayOfWeek(ByVal dt As DateTime) As DateTime

    Return dt.AddDays(((dt.DayOfWeek) * (-1)) + 1)

  End Function
  '******************************************************************************************************************************************************************************
  'obtenir le numero de semaine selon sa date
  '******************************************************************************************************************************************************************************
  Public Function WeekNumber(ByVal FromDate As Date) As Integer

    ' Get jan 1st of the year
    Dim StartOfYear As Date = FromDate.AddDays(-FromDate.Day + 1).AddMonths(-FromDate.Month + 1)
    ' Get dec 31st of the year
    Dim EndOfYear As Date = StartOfYear.AddYears(1).AddDays(-1)
    ' ISO 8601 weeks start with Monday 
    ' The first week of a year includes the first Thursday 
    ' DayOfWeek returns 0 for sunday up to 6 for saterday
    Dim iso8601Correction() As Integer = {6, 7, 8, 9, 10, 4, 5}
    Dim nds As Integer = FromDate.Subtract(StartOfYear).Days + iso8601Correction(StartOfYear.DayOfWeek)
    Dim wk As Integer = nds / 7
    Select Case wk
      Case 0
        ' Return weeknumber of dec 31st of the previous year
        Return WeekNumber(StartOfYear.AddDays(-1))
      Case 53
        ' If dec 31st falls before thursday it is week 01 of next year
        If EndOfYear.DayOfWeek < DayOfWeek.Thursday Then
          Return 1
        Else
          Return wk
        End If
      Case Else
        Return wk
    End Select

  End Function

  Public Function GetPays(ByVal sTable As String, ByVal sChampPays As String, ByVal sChampCle As String, ByVal sCle As String) As String

    Try

      Dim SqlcmdPays As New SqlCommand(String.Format("SELECT {0} FROM {1} WHERE {2} = {3}", sChampPays, sTable, sChampCle, sCle), MozartDatabase.cnxMozart)
      Return SqlcmdPays.ExecuteScalar.ToString

    Catch ex As Exception

      MessageBox.Show("Erreur dans GetPays() ModuleMain : " + ex.Message, "Erreur", MessageBoxButtons.OK, MessageBoxIcon.Error)
      Return "FRANCE"

    End Try

  End Function
  Function GetPaysDest(ByVal sTypeDest As String, ByVal idDest As Long) As String
    Dim sPays As String = ""

    Select Case sTypeDest
      Case "Service Technique"
        sPays = "FRANCE"
      Case "Client"
        sPays = GetPays("TCCL", "VCCLPAYS", "NCCLNUM", idDest)

      Case "Sous-traitant", "Fournisseur", "Ravel"

        sPays = ExecuteScalarString("SELECT VSTFPAYS FROM TSTF, TINT where TINT.NSTFNUM = TSTF.NSTFNUM AND NINTNUM = " & idDest)

      Case "Site"
        sPays = GetPays("TSIT", "VSITPAYS", "NSITNUM", idDest)

      Case "Personnel"
        sPays = GetPays("TPER", "VPERPAYS", "NPERNUM", idDest)

    End Select
    Return sPays

  End Function

  Public Function CodePays(ByVal sCodePays As String) As String

    Dim sCode As String
    Select Case sCodePays
      Case "ESPAGNE"
        sCode = "ES"
      Case "ITALIE"
        sCode = "IT"
      Case "GRANDE BRETAGNE"
        sCode = "EN"
      Case "USA"
        sCode = "EN"
      Case "PAYS-BAS"
        sCode = "NL"
      Case "ALLEMAGNE"
        sCode = "DE"
      Case "AUTRICHE"
        sCode = "DE"
      Case "PORTUGAL"
        sCode = "PT"
      Case "SUISSE"
        sCode = "CH"
      Case "POLOGNE"
        sCode = "PL"
      Case "SWITZERLAND"
        sCode = "DE"
      Case "DANEMARK"
        sCode = "EN"
      Case "SVIZZERA"
        sCode = "IT"
      Case "BELGIQUE" 'Walonnie = français
        sCode = "BE"
      Case "BELGIË"  'Flandre = neerlandais
        sCode = "BL"
      Case "SUEDE"
        sCode = "EN"
      Case "IRLANDE"
        sCode = "EN"
      Case "FRANCE"
        sCode = "FR"
      Case "REPUBLIQUE TCHEQUE"
        sCode = "CZ"
      Case "SLOVAQUIE"
        sCode = "SL"
      Case Else
        sCode = "FR"
    End Select
    CodePays = sCode & "\"

  End Function

  Public Function ChoixModelOTDevExpress(ByVal nIplNum As Long) As String

    Dim rsIP As SqlCommand
    Dim sSql As String
    Dim lNb As Integer

    Dim ReturnModele As String = "TORDRETRAVAILINFO"

    'sSql = "SELECT COUNT(TDCL.NACTNUM) FROM TDCL WITH (NOLOCK) INNER JOIN TACT WITH (NOLOCK) ON TACT.NACTNUM = TDCL.NACTNUM WHERE TACT.NIPLNUM = " & nIplNum & " AND CDEVISTYPE = 'P'"
    sSql = "SELECT CASE WHEN EXISTS(SELECT TDCL.NACTNUM FROM TDCL WITH (NOLOCK) INNER JOIN TACT WITH (NOLOCK) ON TACT.NACTNUM = TDCL.NACTNUM"
    sSql += $" WHERE TACT.NIPLNUM = {nIplNum} AND CDEVISTYPE = 'P') THEN 1 ELSE 0 END"
    rsIP = New SqlCommand(sSql, MozartDatabase.cnxMozart)
    lNb = Convert.ToInt32(rsIP.ExecuteScalar())

    If lNb = 1 Then
      sSql = "SELECT COUNT(NACTNUM) FROM TACT WITH (NOLOCK) WHERE NIPLNUM = " & nIplNum
      rsIP = New SqlCommand(sSql, MozartDatabase.cnxMozart)
      If rsIP.ExecuteScalar = 1 Then
        ReturnModele = "TORDRETRAVAILINFOPREST"
      End If
    Else
      'Si la di est une multi equipements alors on change le modele
      'sSql = "SELECT COUNT(*) FROM TACT WITH (NOLOCK) INNER JOIN TSIT WITH (NOLOCK) ON TSIT.NSITNUM = TACT.NSITNUM INNER JOIN TCLI ON TCLI.NCLINUM = TSIT.NCLINUM WHERE BCLIGESTNUM = 1 AND NIPLNUM = " & nIplNum
      sSql = "SELECT COUNT(NACTNUM) FROM TACT WITH (NOLOCK) INNER JOIN TSIT WITH (NOLOCK) ON TSIT.NSITNUM = TACT.NSITNUM"
      sSql += $" INNER JOIN TCLI ON TCLI.NCLINUM = TSIT.NCLINUM WHERE BCLIGESTNUM = 1 AND NIPLNUM = {nIplNum}"
      rsIP = New SqlCommand(sSql, MozartDatabase.cnxMozart)
      If rsIP.ExecuteScalar() > 0 Then
        ReturnModele = "TORDRETRAVAILINFOGIDT"
      End If
    End If

    Return ReturnModele

  End Function

  Public Function FormatFileNameAuthorized(ByVal p_srcfilename As String) As String

    Dim invalidFileChars() As Char = Path.GetInvalidFileNameChars()

    For Each CharForbidden As Char In invalidFileChars

      If p_srcfilename.Contains(CharForbidden) Then

        p_srcfilename.Replace(CharForbidden, "_")

      End If

    Next

    Return p_srcfilename

  End Function

  Function IsEmail(ByVal email As String) As Boolean
    Static emailExpression As New Regex("^[_a-z0-9-]+(.[a-z0-9-]+)@[a-z0-9-]+(.[a-z0-9-]+)*(.[a-z]{2,4})$")

    Return emailExpression.IsMatch(email)
  End Function

  Public Function ImageResizeForImageSQL(ByVal sFilename As String) As String

    Try

      Dim sFileTemp As String = Path.GetTempFileName

      Dim myBitmap As New Bitmap(sFilename)

      Dim ratio As Double = myBitmap.Height / myBitmap.Width

      Dim myBitmap2 As New Bitmap(myBitmap, New Size(1024, 1024 * ratio))
      myBitmap2.Save(sFileTemp, ImageFormat.Jpeg)

      Return sFileTemp
    Catch ex As Exception
      MessageBox.Show(ex.Message, "Erreur - ImageResizeForImageSQL")
      Return Nothing
    End Try

  End Function

  Public Function ConvertImagetoSQL(ByVal sNomFicTemp As String) As Byte()

    Try
      Dim fiImage As New FileInfo(sNomFicTemp)

      Dim ILenImg As Long = fiImage.Length
      ReDim ConvertImagetoSQL(ILenImg)

      Dim fs As New FileStream(sNomFicTemp, FileMode.Open, FileAccess.Read, FileShare.Read)
      fs.Read(ConvertImagetoSQL, 0, ILenImg)
      fs.Flush()
      fs.Close()

      Return ConvertImagetoSQL

    Catch ex As Exception

      MessageBox.Show(ex.Message, "Erreur - ConvertImagetoSQL()")
      Return Nothing

    End Try

  End Function

  Public Function formatPhoneNumber(phoneNum As String, phoneFormat As String) As String

    If phoneFormat = "" Then
      ' Default format is ##.##.##.##.##
      phoneFormat = "##.##.##.##.##"
    End If

    ' First, remove everything except of numbers
    Dim regexObj As Regex = New Regex("[^\d]")
    phoneNum = regexObj.Replace(phoneNum, "")

    ' Second, format numbers to phone string 
    If phoneNum.Length > 0 Then
      phoneNum = Convert.ToInt64(phoneNum).ToString(phoneFormat)
    End If

    Return phoneNum

  End Function

  Public Function GetNomPersonne(ByVal IdPer As Int32) As String

    Dim dr As SqlDataReader = Nothing
    Dim sNomtech As String = ""
    Try
      Dim cmd As New SqlCommand("SELECT ISNULL(VPERNOM + ' ' + VPERPRE, '') AS VTECHNOM FROM TPER WITH (NOLOCK) WHERE  NPERNUM=" & IdPer, MozartDatabase.cnxMozart)
      dr = cmd.ExecuteReader
      dr.Read()
      sNomtech = dr(0).ToString()
      dr.Close()

    Catch ex As Exception
      Return ""
    Finally
      If dr IsNot Nothing AndAlso dr.IsClosed = False Then dr.Close()
    End Try

    Return sNomtech


  End Function

  Public Function VerifSIRET(ByVal p_NUMSIRET As String) As Boolean
    Dim lNumSIRET As String = p_NUMSIRET.Replace(" ", "")

    If Not IsNumeric(lNumSIRET) Then Return False
    If lNumSIRET.Length <> 14 Then Return False

    Dim sTab() As Char = StrReverse(lNumSIRET).ToCharArray()
    Dim iVal As Int32
    Dim bPair As Boolean

    Dim iPos As Int32 = 1
    Dim iTotal As Int32 = 0
    Dim iValPair As Int32 = 0

    For Each sElement As String In sTab

      iVal = Convert.ToInt32(sElement)

      iValPair += iVal

      bPair = (iPos Mod 2 = 0)
      'pair
      If bPair Then

        iVal *= 2

        If iVal > 9 Then
          iVal -= 9
        End If

      Else 'impair
      End If

      iTotal += iVal

      iPos += 1
    Next

    If iTotal Mod 10 = 0 Then
      Return True
    Else
      ' Spécifique LA POSTE
      If (lNumSIRET.StartsWith("356000000")) Then
        Return ((iValPair Mod 5) = 0)
      Else
        Return False
      End If

    End If

  End Function

  Public Sub EndAllEXCELProcess()

    For Each clsProcess As Process In Process.GetProcesses()
      If clsProcess.ProcessName.Equals("EXCEL") Then
        clsProcess.Kill()
      End If
    Next

  End Sub

  Public Function GetFileAttchementByAction(ByVal p_NACTNUM As Long, ByRef p_sTypeDoc As String) As String

    GetFileAttchementByAction = ""
    p_sTypeDoc = ""

    Dim dr As SqlDataReader = ExecuteReader("EXEC [api_sp_GetFileAttachementByAction] " & p_NACTNUM)

    If (dr.HasRows) Then
      dr.Read()
      GetFileAttchementByAction = BlankIfNull(dr(0))
      p_sTypeDoc = BlankIfNull(dr(1))
    End If
    dr.Close()

  End Function

  Public Function GetFileBonCmdByAction(ByVal p_NACTNUM As Long) As String
    Return ExecuteScalarString("EXEC [api_sp_GetFileBonCmdByAction] " & p_NACTNUM)
  End Function

  Public Function BlankIfNull(ByVal sString) As String
    Return sString.ToString()
  End Function

  Public Function ZeroIfNull(ByVal sString) As Decimal

    Return IIf(sString.ToString() = "" Or IsDBNull(sString), 0, sString)

  End Function


  Public Function RechercheChaff(ByVal NumDI As Long) As String

    Dim sSql = "SELECT isnull(VPERMAILPRO,'') FROM TCAN INNER JOIN TPER ON TCAN.NPERNUM = TPER.NPERNUM INNER JOIN TDIN ON TCAN.NCANNUM = TDIN.NDINCTE"
    sSql = sSql & " AND TDIN.NCLINUM = TCAN.NCLINUM WHERE TDIN.NDINNUM = " & NumDI
    Return ExecuteScalarString(sSql)

  End Function

  Public Function FormatMail(txtCtrl As TextBox)
    FormatMail = txtCtrl.Text
    If txtCtrl.Text <> "" Then
      If InStr(txtCtrl.Text, " ") > 0 Or InStr(txtCtrl.Text, "@") = 0 Or InStr(txtCtrl.Text, ".") = 0 Then
        MsgBox(My.Resources.msg_adresseCourrielInvalide, vbExclamation, My.Resources.msg_detail_personne)
        txtCtrl.Focus()
      End If
    End If
  End Function

  Public Function FormatTel(sNum As String) As String
    FormatTel = sNum
    If Left(sNum, 2) <> "00" Then
      sNum = sNum.Replace(".", "")
      sNum = sNum.Replace(" ", "")
      FormatTel = Left(sNum, 2) & "." & Mid(sNum, 3, 2) & "." & Mid(sNum, 5, 2) & "." & Mid(sNum, 7, 2) & "." & Right(sNum, 2)
      If FormatTel = "...." Then FormatTel = ""
    End If
  End Function

  Public Function ScaleImage(ByVal image As Image, ByVal size As Size, Optional ByVal preserveAspectRatio As Boolean = True) As Image
    Dim newWidth As Integer
    Dim newHeight As Integer
    If preserveAspectRatio Then
      Dim originalWidth As Integer = image.Width
      Dim originalHeight As Integer = image.Height
      Dim percentWidth As Single = CSng(size.Width) / CSng(originalWidth)
      Dim percentHeight As Single = CSng(size.Height) / CSng(originalHeight)
      Dim percent As Single = If(percentHeight < percentWidth,
      percentHeight, percentWidth)
      newWidth = CInt(originalWidth * percent)
      newHeight = CInt(originalHeight * percent)
    Else
      newWidth = size.Width
      newHeight = size.Height
    End If
    Dim newImage As Image = New Bitmap(newWidth, newHeight)
    Using graphicsHandle As Graphics = Graphics.FromImage(newImage)
      graphicsHandle.InterpolationMode = Drawing2D.InterpolationMode.HighQualityBicubic
      graphicsHandle.DrawImage(image, 0, 0, newWidth, newHeight)
    End Using
    Return newImage
  End Function

  Public Function Couleur(ByVal sSociete) As Color

    'Global Const gstrCouleurSAMSICROMANIA = &HE0E0E0       ' couleur de fond

    Select Case sSociete
      Case "EMALEC"
        'Global Const gstrCouleurEMALEC = 8438015      ' couleur de fond
        Couleur = Color.Wheat     'Color.FromArgb(8438015)
      Case "EQUIPAGE"
        'Global Const gstrCouleurEQUIPAGE = 16445620   'RGB(180, 240, 250)  ' couleur de fond
        Couleur = Color.DeepSkyBlue
      Case "MAGESTIME"
        'Global Const gstrCouleurMAGESTIME = &H80000013   'RGB(220, 180, 180)  ' couleur de fond
        'Couleur = Color.FromArgb(220, 180, 180)
        Couleur = Color.LightGray
      Case "EMALECLUXEMBOURG"
        'Global Const gstrCouleurEMALECLUXEMBOURG = 12050862    ' couleur de fond
        Couleur = Color.LightGreen
      Case "EMALECFACILITEAM"
        'Global Const gstrCouleurEMALECFACILITEAM = &HE0E0E0       ' couleur de fond
        Couleur = Color.LightSalmon
      Case "SCS"
        'Global Const gstrCouleurSCS = 16445620        ' couleur de fond
        Couleur = Color.DeepSkyBlue
      Case "EMALECESPAGNE"
        'Global Const gstrCouleurEMALECESPAGNE = &HC0FFFF         ' couleur de fond
        Couleur = Color.Beige
      Case "EMALECIDF"
        'Global Const gstrCouleurIDF = &HC0C0C0        ' couleur de fond
        Couleur = Color.LightGray
      Case "EMALECMPM"
        Couleur = Color.LightGreen
      Case "SAMSICROMANIA"
        '  Couleur = gstrCouleurSAMSICROMANIA
        Couleur = Color.LightGray
      Case "EMALECDEV", "EMAFI"
        Couleur = Color.SkyBlue
      Case Else
        Couleur = Color.Wheat
    End Select
  End Function

  Public Sub RechercheCommune(strCp As String, cbo As ComboBox)

    cbo.Items.Clear()
    ModuleData.RemplirCombo1item(cbo, $"SELECT VILLE FROM TCOMMUNE WHERE CODEPOSTAL LIKE '{strCp}%'")

    ' dans le cas d'un cedex avec code postal spécial, on recherche les communes du département
    If cbo.Items.Count = 0 Then
      ModuleData.RemplirCombo1item(cbo, "SELECT VILLE FROM TCOMMUNE WHERE CODEPOSTAL LIKE '" + strCp.Substring(0, 2) + "%'")
    End If
    If cbo.Items.Count >= 0 Then cbo.SelectedIndex = 0
  End Sub

  Function ReplaceCharToBD(strIn As String, strType As String) As String
    Return IIf(strType = "RTF", Replace(strIn, vbCr, "\par"), Replace(strIn, vbCr, "<BR>"))
  End Function

  Function ReplaceCharFromBD(strIn As String, strType As String) As String
    Return IIf(strType = "RTF", Replace(strIn, "\\par", vbCr), Replace(strIn, "<BR>", vbCr))
  End Function

  Function RechercheInfos(sTypeInfo As String, iCle As Long) As Infos
    Dim lesInfos As New Infos
    lesInfos.strInfo = ""
    lesInfos.DateValDeb = "01/01/2000"
    lesInfos.DateValFin = "31/12/2099"

    Using reader As SqlDataReader = ModuleData.ExecuteReader($"SELECT * FROM TNOTES WHERE VNOTTYPE = '{sTypeInfo}' AND NNOTCLE ={iCle}")
      If reader.Read Then
        lesInfos.strInfo = BlankIfNull(reader("VNOTMESS"))
        If Not reader("DNOTVALSTART") Is DBNull.Value Then lesInfos.DateValDeb = reader("DNOTVALSTART")
        If Not reader("DNOTVALSTOP") Is DBNull.Value Then lesInfos.DateValFin = reader("DNOTVALSTOP")
      End If
    End Using

    Return lesInfos
  End Function

  '********************************************************************************************************
  ' Cette fonction est utilisée pour verifier le taux de dépendance sous-traitant
  ' exclure les filiales pour ne pas avoir des messages identiques , récurrents et inutiles
  '********************************************************************************************************'
  Public Function IsOKTauxDependanceSTF(ByVal p_NSTFNUM As Long, ByVal p_NACTNUM As Long, ByVal p_NPERNUM As Long, ByVal p_vsociete As String) As Boolean

    IsOKTauxDependanceSTF = True

    ' si filiale exit sans test
    If (p_NSTFNUM = 35576 Or p_NSTFNUM = 36375 Or p_NSTFNUM = 39392) Then Exit Function

    ' recherche du taux de dep
    Dim cmd As SqlCommand = New SqlCommand("exec api_sp_TestTauxDependanceSTF " & p_NSTFNUM, MozartDatabase.cnxMozart)
    Dim dr As SqlDataReader = cmd.ExecuteReader()

    While dr.Read()

      'si > 30 % alors envoi du mail
      If dr("NTAUXDEP") >= 0.3 Then
        If MsgBox("ATTENTION : vous sélectionnez un prestataire pour lequel le taux de dépendance à " & MozartParams.NomSociete & " est égal ou supérieur à 30 %. " & vbCrLf &
                    "Vous devez faire intervenir un autre prestataire ou demander l'autorisation de la hiérarchie. " & vbCrLf &
                    "Souhaitez-vous quand même sélectionner ce prestataire ?", vbExclamation + vbYesNoCancel, "Taux de dépendance sous-traitant") = vbYes Then

          IsOKTauxDependanceSTF = True
        Else
          IsOKTauxDependanceSTF = False
        End If

      End If

    End While
    dr.Close()

  End Function

  '*********************************************************************************************************
  'Fonction permettant de tester un ST possède un accès WEB selon le type de document
  ''*********************************************************************************************************
  Public Function TestIfSTWithAccessWEB(ByVal sType As String, ByVal iIdDoc As Long) As Boolean

    Dim bRet As Boolean = False
    'Dim cmd As SqlCommand = New SqlCommand("EXEC api_sp_STWithWeb '" & sType & "'," & iIdDoc, cnx)
    'Dim o = cmd.ExecuteScalar()

    'If o <> DBNull.Value AndAlso (Convert.ToInt32(o) >= 1) Then bRet = True

    Dim o = ModuleData.ExecuteScalarInt("EXEC api_sp_STWithWeb '" & sType & "'," & iIdDoc)
    bRet = (Convert.ToInt32(o) >= 1)

    Return bRet
  End Function

  '*********************************************************************************************************
  'Fonction permettant de recupérer le montant de validation des CF/CS
  ''*********************************************************************************************************
  Public Function GetMontantSeuilByNPERNUM(ByVal p_NPERNUM As Int32) As Int32
    Return ModuleData.ExecuteScalarInt("EXEC [api_sp_GetMontantValidationByNPERNUM] " & p_NPERNUM)
  End Function

  Public Function GetMontantSeuilDevisByNPERNUM(ByVal p_NPERNUM As Integer) As Integer
    Return ModuleData.ExecuteScalarInt("EXEC [api_sp_GetMontantValidationDevisByNPERNUM] " & p_NPERNUM)
  End Function

  Public Function GetTauxFG() As Decimal

    Dim sSql = "EXEC [api_sp_GetTauxFG]"
    Return ExecuteScalarString(sSql)

  End Function

  Public Function GetAfficheProcUrgence() As Boolean

    Dim bRet As Boolean
    Dim o = ExecuteScalarInt("EXEC [api_sp_AfficheProcUrgence_Get]")
    bRet = (Convert.ToInt32(o) >= 1)

    Return bRet

  End Function

  Public Sub SetAfficheProcUrgence(ByVal p_Val As Boolean)

    Dim cmd As New SqlCommand("[api_sp_AfficheProcUrgence_Save]", MozartDatabase.cnxMozart)
    cmd.CommandType = CommandType.StoredProcedure
    cmd.Parameters.Add("@P_BAFFICHEPROCURG", SqlDbType.Bit).Value = p_Val

    cmd.ExecuteNonQuery()

  End Sub

  Public Class Infos
    Public strInfo As String
    Public DateValDeb As Date
    Public DateValFin As Date
  End Class

End Module


