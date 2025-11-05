using Microsoft.VisualBasic;
using MozartLib;
using MozartNet;
using ReportEmalec.Net;
using System;
using System.Data.SqlClient;
using System.IO;
using System.Reflection;
using System.Threading;
using System.Windows.Forms;
using MZUtils = MozartControls.Utils;

namespace MozartCS
{
  /// <summary>
  /// Fonctions issues de modMain.bas et modGDM.bas et utilisées par frmDetailstravaux
  /// </summary>
  class DetailstravauxUtils
  {
    public struct Info
    {
      public string strInfo;
      public DateTime DateValDeb;
      public DateTime DateValFin;
    }

    // depuis modmain.bas
    public static void RemplirComboHM(ComboBox cbo, string svue /* , bool Click = true => inutilisé */)
    {
      cbo.Items.Clear();
      int maxi = 0;
      if (svue == "H")
        maxi = 23;
      else if (svue == "M")
        maxi = 59;
      for (int i = 0; i <= maxi; i++)
        cbo.Items.Add(i.ToString("00"));
      if (cbo.Items.Count > 0) cbo.SelectedIndex = 0;
    }

    // depuis modmain.bas
    //'***************************************************************************
    //'Renvoi TRUE si le client est de type GIDT (case à cocher dans admin client)
    //'***************************************************************************
    public static bool VerifTypeClientGidt(int NCLINUM)
    {
      using (SqlDataReader reader = ModuleData.ExecuteReader($"SELECT 1 FROM TCLI WHERE BCLIGESTNUM = 1 AND NCLINUM = {NCLINUM}"))
      {
        if (reader.Read()) return true;
      }
      return false;
    }
    //Public Function VerifTypeClientGidt(NCLINUM As Long)
    //' UPGRADE_INFO (#0501): The 'sMsg' member isn't used anywhere in current application.
    //' Dim sMsg As String

    //  VerifTypeClientGidt = False
    //  Dim rsT As New ADODB.Recordset
    //  rsT.Open "SELECT 1 FROM TCLI WHERE BCLIGESTNUM = 1 AND NCLINUM = " & NCLINUM, cnx, adOpenDynamic, adLockOptimistic

    //  If Not rsT.EOF Then
    //    VerifTypeClientGidt = True
    //  End If


    //  rsT.Close
    //  Set rsT = Nothing

    //End Function

    // depuis modMain.bas
    //'******************************************************************************************************************************************************
    //'Cette Sub Envoi la gamme et l 'attachement
    //'******************************************************************************************************************************************************
    public static void SendMailAttachementAndGamme(int NACTNUM, int NCLINUM)
    {
      using (SqlDataReader reader = ModuleData.ExecuteReader($"exec api_sp_SendMailAttachementAndGamme {NACTNUM}, {NCLINUM}"))
      {
        if (reader.Read())
        {
          CSendMail oMail = new CSendMail();
          oMail.Dest = Utils.BlankIfNull(reader["VDEST"]);
          // TB SAMSIC CITY SPEC
          if (MozartParams.NomGroupe == "EMALEC") oMail.BlindCopyDest = "info@emalec.com";
          oMail.Subject = Utils.BlankIfNull(reader["VSUBJECT"]);
          oMail.Message = Utils.BlankIfNull(reader["VMAIL"]);
          oMail.PJ = Utils.BlankIfNull(reader["FILE_JOIN"]);

          oMail.SendMail("HTML");
        }
      }
    }

    //'******************************************************************************************************************************************************
    //'Cette Sub Envoi la gamme
    //'******************************************************************************************************************************************************
    public static void SendMailGamme(int NACTNUM, int NCLINUM)
    {
      //MozartDatabase.ExecuteNonQuery($"exec api_sp_SendMailGammeNew {NACTNUM}, {NCLINUM}");
      using (SqlDataReader reader = ModuleData.ExecuteReader($"exec api_sp_SendMailGamme {NACTNUM}, {NCLINUM}"))
      {
        if (reader.Read())
        {
          CSendMail oMail = new CSendMail
          {
            Dest = Utils.BlankIfNull(reader["VDEST"]),
            Subject = Utils.BlankIfNull(reader["VSUBJECT"]),
            Message = Utils.BlankIfNull(reader["VMAIL"]),
            PJ = Utils.BlankIfNull(reader["FILE_JOIN"])
          };
          if (MozartParams.NomGroupe == "EMALEC") oMail.BlindCopyDest = "info@emalec.com";

          oMail.SendMail("HTML");
        }
      }
    }

    // depuis modMain.bas
    //'*********************************************************************************************************
    //' renvoie les noms des documents manquants ou obsolète séparés pas des #
    //' GM
    //'*********************************************************************************************************
    public static string VerificationDocStt(int iNACTNUM)
    {
      string verif = "";
      using (SqlDataReader reader = ModuleData.ExecuteReader($"api_sp_VerifDocStf {iNACTNUM}"))
      {
        while (reader.Read())
        {
          verif += "#" + Utils.BlankIfNull(reader["VLIB"]);
        }
      }

      return verif;
    }


    // depuis modMain.bas
    public static bool DiAsDevisClientPrest(int inumAction)
    {
      try
      {
        // recherche des devis prestation sur la Di
        int nb = (int)ModuleData.ExecuteScalarInt($"(SELECT COUNT(NACTNUM) from TDCL WITH (NOLOCK) where  NACTNUM in (select nactnum from tact WITH (NOLOCK) where ndinnum=" +
                                                  $"(select ndinnum from tact WITH (NOLOCK) where nactnum={inumAction})) and CDEVISTYPE = 'P' and cdclactif='O')");
        return nb > 0;
      }
      catch (Exception ex)
      {
        MZUtils.displayError(MethodBase.GetCurrentMethod().Name, ex);
      }

      return false;
    }

    // depuis modMain.bas
    public static string RechercheParamBySociete(string sParam, string sSociete)
    {
      try
      {
        // recherche des devis prestation sur la Di
        using (SqlDataReader reader = ModuleData.ExecuteReader($"api_sp_getPAR_By_Societe {sParam},{sSociete}"))
        {
          if (reader.Read())
          {
            return Utils.BlankIfNull(reader[0]);
          }
        }
      }
      catch (Exception ex)
      {
        MZUtils.displayError(MethodBase.GetCurrentMethod().Name, ex);
      }

      return "";
    }

    // depuis modMain.bas
    public static string RechercheFonctionByPers(int NPERNUM)
    {
      try
      {
        // recherche des devis prestation sur la Di
        using (SqlDataReader reader = ModuleData.ExecuteReader($"SELECT TPER.CPERTYP FROM TPER WITH (NOLOCK) WHERE TPER.NPERNUM = {NPERNUM}"))
        {
          if (reader.Read())
          {
            return Utils.BlankIfNull(reader[0]);
          }
        }
      }
      catch (Exception ex)
      {
        MZUtils.displayError(MethodBase.GetCurrentMethod().Name, ex);
      }

      return "";
    }

    public static int RechercheServiceByPers()
    {
      try
      {
        // recherche des devis prestation sur la Di
        using (SqlDataReader reader = ModuleData.ExecuteReader($"SELECT TPER.NSERNUM FROM TPER WITH (NOLOCK) WHERE TPER.NPERNUM = {MozartParams.UID}"))
        {
          if (reader.Read())
          {
            return (int)Utils.ZeroIfNull(reader[0]);
          }
        }
      }
      catch (Exception ex)
      {
        MZUtils.displayError(MethodBase.GetCurrentMethod().Name, ex);
      }

      return 0;
    }

    // depuis modMain.bas
    public static int RechercheCotraitantAct(int iAction)
    {
      return (int)Utils.ZeroIfNull(ModuleData.ExecuteScalarInt($"api_sp_FindCotraitant {iAction}"));
    }


    //'*****************************************************************************************************************************************************
    //'Permet de tester si om actif sur une action
    //'*****************************************************************************************************************************************************
    // depuis modMain.bas
    public static int TestIfOMActif()
    {
      int nb = (int)Utils.ZeroIfNull(ModuleData.ExecuteScalarInt($"SELECT COUNT(TOM.NOMNUM) AS NBOMACTIF FROM TOM WHERE TOM.COMACTIF = 'OUI' AND TOM.NACTNUM = {MozartParams.NumAction}"));
      return nb > 0 ? 1 : 0;
    }

    public static Info RechercheInfos(string sTypeInfo, int iCle)
    {
      Info infos = new Info();
      try
      {
        // initialisation      
        infos.strInfo = "";
        infos.DateValDeb = new DateTime(2000, 1, 1);
        infos.DateValFin = new DateTime(2099, 12, 31);

        // recherche des informations sur le clients
        using (SqlDataReader reader = ModuleData.ExecuteReader($"SELECT * FROM TNOTES WHERE VNOTTYPE = '{sTypeInfo}' AND NNOTCLE = {iCle}"))
        {
          if (reader.Read())
          {
            infos.strInfo = Utils.BlankIfNull(reader["VNOTMESS"]);
            if (!Convert.IsDBNull(reader["DNOTVALSTART"])) infos.DateValDeb = Convert.ToDateTime(reader["DNOTVALSTART"]);
            if (!Convert.IsDBNull(reader["DNOTVALSTOP"])) infos.DateValFin = Convert.ToDateTime(reader["DNOTVALSTOP"]);
          }
        }

      }
      catch (Exception ex)
      {
        MZUtils.displayError(MethodBase.GetCurrentMethod().Name, ex);
      }

      return infos;
    }


    //'*********************************************************************************************************
    //' Verification de possibilité de certificat N4 sur une intervention
    //' ON doit avoir un inventaire, les informations sur site et un devis client avec quantitatif
    //'*********************************************************************************************************
    // depuis modMain.bas
    public static bool VerifExtN4(int iNumsite, int iNumAct)
    {
      if (iNumAct == 0)
      {
        MessageBox.Show("Vous devez enregistrer l'action pour émettre un certificat N4.", Program.AppTitle, MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
        return false;
      }
      int nb = (int)ModuleData.ExecuteScalarInt($"SELECT COUNT(*) AS CPT FROM TEXTINV INNER JOIN TEXTINVL ON TEXTINV.NEXTINVID = TEXTINVL.NEXTINVID WHERE NSITNUM = {iNumsite}");
      if (nb > 0)
      {
        nb = (int)ModuleData.ExecuteScalarInt($"SELECT COUNT(*) AS CPT FROM TSIT WHERE VSITEXTCARACT IS NOT NULL AND VSITEXTPART IS NOT NULL AND NSITNUM = {iNumsite}");
        if (nb > 0)
        {
          nb = (int)ModuleData.ExecuteScalarInt($"SELECT COUNT(*) AS CPT FROM TDCL INNER JOIN TLDCL ON TDCL.NDCLNUM = TLDCL.NDCLNUM WHERE CDCLACTIF = 'O' AND NACTNUM = {iNumAct}");
          if (nb > 0) return true;
          MessageBox.Show("Un devis avec quantitatif est obligatoire pour émettre un certificat N4.", Program.AppTitle, MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
          return false;
        }
        else
        {
          MessageBox.Show($"Vous devez saisir les Caractéristiques et Particularités du site pour émettre un certificat N4.{Environment.NewLine}" +
                          $"Admnistration --> Client --> Site --> Détails --> EXTINCTION INCENDIE", Program.AppTitle, MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
        }
      }
      else
      {
        MessageBox.Show("Il n'y a pas d'inventaire EI sur ce site, il est obligatoire pour émettre un certificat N4.", Program.AppTitle, MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
      }

      return false;
    }
    //Public Function VerifExtN4(ByVal iNumsite As Long, ByVal iNumAct As Long) As Boolean
    //Dim sSQL As String
    //Dim rsverif As New ADODB.Recordset

    //    VerifExtN4 = False


    //    If iNumAct = 0 Then
    //      MsgBox "Vous devez enregistrer l'action pour émettre un certificat N4.", vbExclamation
    //      GoTo Fin
    //    End If


    //    sSQL = "SELECT COUNT(*) AS CPT FROM TEXTINV INNER JOIN TEXTINVL ON TEXTINV.NEXTINVID = TEXTINVL.NEXTINVID WHERE NSITNUM = " & iNumsite
    //    rsverif.Open sSQL, cnx

    //    If CInt(rsverif("CPT")) > 0 Then
    //        rsverif.Close


    //        sSQL = "SELECT COUNT(*) AS CPT FROM TSIT WHERE VSITEXTCARACT IS NOT NULL AND VSITEXTPART IS NOT NULL AND NSITNUM = " & iNumsite
    //        rsverif.Open sSQL, cnx

    //        If CInt(rsverif("CPT")) > 0 Then
    //             rsverif.Close


    //            sSQL = "SELECT COUNT(*) AS CPT FROM TDCL INNER JOIN TLDCL ON TDCL.NDCLNUM = TLDCL.NDCLNUM WHERE CDCLACTIF = 'O' AND NACTNUM = " & iNumAct
    //            rsverif.Open sSQL, cnx
    //            If CInt(rsverif("CPT")) > 0 Then
    //                VerifExtN4 = True
    //            Else
    //                MsgBox "Un devis avec quantitatif est obligatoire pour émettre un certificat N4.", vbExclamation
    //            End If
    //            GoTo Fin
    //        Else
    //            MsgBox "Vous devez saisir les Caractéristiques et Particularités du site pour émettre un certificat N4." _
    //                    & vbCrLf & "Admnistration --> Client --> Site --> Détails --> EXTINCTION INCENDIE", vbExclamation
    //        End If
    //    Else
    //        MsgBox "Il n'y a pas d'inventaire EI sur ce site, il est obligatoire pour émettre un certificat N4.", vbExclamation
    //        GoTo Fin
    //    End If


    //Fin:


    //    rsverif.Close
    //    Set rsverif = Nothing

    //End Function

    public static string getNumGDM(int nDI)
    {
      // on cherche l'existance d'une demande GDM sur toutes les actions de la DI Emalec
      using (SqlDataReader reader = ModuleData.ExecuteReader($"select distinct VDIGDM from TGDM where vtypedemande in ('DD', 'DI') " +
                                                            $"and NACTNUM in (select nactnum from tact where ndinnum={nDI})"))
      {
        if (reader.Read())
        {
          return Utils.BlankIfNull(reader["VDIGDM"]);
        }
      }

      return "";
    }

    public static bool PrepaEnvoiGDM2(int nactnum, int ndinnum, string vClinom, bool bEnvoyerDevis, string NumGMAO, ref string txtObserv)
    {
      SqlDataReader rGDM = null;
      string TypeGDM = "";
      int NGDMNUM;
      string NumGDM;
      bool bMAJData;
      string sDesc = "";
      string sDescString = "";
      string sNomFichierXML = "";
      string sNomFichierXML_ssExt = "";
      string cheminGDMFTP = "";
      string sNomFichierDD_PDF = "";
      int nGDMDEVISNUM;

      //txtObserv = "";

      try
      {
        Cursor.Current = Cursors.WaitCursor;

        // 1 Suis-je dans une DI, DD, DISR ou DDSR ?

        //  si cette action existe déjà dans TGDM, on renvoie les infos pour modification
        //  si cette action n'existe pas dans TGDM :
        //     si on a un numéro GDM sur la DI, on crée une DI ou une DD (en fonction de ce qui exite déjà dans TGDM ?) et on envoie
        //     si pas de numéro GDM sur la DI, on fait une DISR ou une DDSR (en fonction devis ou pas) (cela fait une nouvelle demande chez le client)

        // recherche si cette action est déjà gérée dans la table GDM
        // FG le 24/11/20
        // on souhaite maintenant gérer une seule demande GDM par DI
        // on va donc vérifier si on a un numéro de demande GDM sur une action de la DI
        // on peut également être dans le cas ou on a déjà envoyé une DDSR ou une DISR sur une autre action de la DI
        // alors, sans numéro GDM, on peut renvoyer une nouvelle DDSR ou DISR sur cette action

        // FGA le 26/06/25
        // tenir compte du numéro GDM qui est saisi à la main sur les actions.
        // le rattacher à la demande GDM si elle existe dans la base.
        //  sinon, ajouter un enregistrement dans la base.
        
        // recherche du numéro GDM sur la DI
        NumGDM = getNumGDM(ndinnum);

        // on recherche si cette action a déjà un traitement dans la table TGDM
        rGDM = ModuleData.ExecuteReader($"SELECT VTYPEDEMANDE, NGDMNUM, VACTDES, VCODECLIENT, TACT.NDINNUM, DACTPLA, DACTDEX, VDIGDM FROM " +
                                        $"TGDM INNER JOIN TACT on TACT.NACTNUM = TGDM.NACTNUM WHERE TGDM.NACTNUM ={nactnum}");


        // si pas de ligne dans TGDM pour cette action
        
        if (!rGDM.Read())
        {
          // si pas de numéro GDM et pas de ligne pour cette DI, on fait une DISR ou DDSR (en fonction devis ou pas)
          if (NumGDM == "" && NumGMAO == "")
          {
            if (bEnvoyerDevis) TypeGDM = "DDSR";
            else TypeGDM = "DISR";
          }
          else
          {
						// numéro GDM existe sur la DI ou sur numéro GMAO et pas de demande sur cette action dans TGDM
						// donc on va faire une DI sur cette action
						// en reprenant le numéro GDM existant
						// donc il faut faire un insert dans TGDM
						// on privilégie le numéro GMAO sur l'action ou le numéro GDM sur la DI ?
						TypeGDM = "DI"; 
            if (NumGDM == "")
							    NumGDM = NumGMAO;

						//using (SqlDataReader rNumGDM = ModuleData.ExecuteReader($"select * from TGDM where VDIGDM = '{NumGDM}'"))
						//{
						//  if (rNumGDM.Read())
						//    TypeGDM = Utils.BlankIfNull(rNumGDM["VTYPEDEMANDE"]);
						//  else
						//    // dans le cas on le numéro est sur N° GMAO (et donc rien dans TGDM)
						//    TypeGDM = "DI";  
						//    NumGDM = NumGMAO;
						//}
					}
						bMAJData = false;
        }
        else
        {
          // Correspondance trouvée dans TGDM: DI ou DD déjà existante (! ! ! mise à jour de DISR ou DDSR interdite)
          // si on trouve que c'est une demande GDM que l'on a déjà envoyé nous même (DISR ou DDSR), normalement il ne faut pas la renvoyer chez le client
          // mais est-ce si grave ? 
          // car souvent ils me demandent de renvoyer la demande car le client n'a rien reçu.
          // normalement cela crée une nouvelle demande chez le client (ce qui n'est pas forcément génial)
          TypeGDM = Utils.BlankIfNull(rGDM["VTYPEDEMANDE"]);
          NGDMNUM = (int)Utils.ZeroIfNull(rGDM["NGDMNUM"]);
          // on est en mise à jour de la ligne
          bMAJData = true;
        }


        // 2 Traiter chaque cas différent (à priori, il y a 4 cas différents et 2 sous-cas dans les cas DI et DD)
        // ------------------------------------------------------------------------------------------------------------------------------------------------
        // ------------------------------------------------------------------------------------------------------------------------------------------------
        if (TypeGDM == "DI")
        {
          // champs principaux concernés : Description, DatePlanifieeIntervention, DateClotureIntervention, VNOMXML
          // Je suis en mise à jour de la DI existante;
          // nouveau cas :  Je suis en création d'une ligne GDM sur une action avec un numéro GDM existant sur la DI
          if (!bMAJData)
          {
            rGDM.Close();
            rGDM = ModuleData.ExecuteReader($"SELECT VACTDES, VCODECLIENT, TDIN.NDINNUM, VSITNOM, DACTPLA, DACTDEX, VPERMAILPRO, NSITNUE FROM " +
                                            $"TACT INNER JOIN TSIT on TSIT.NSITNUM = TACT.NSITNUM INNER JOIN TGDM_TCLI ON TGDM_TCLI.NCLINUM = " +
                                            $"TSIT.NCLINUM INNER JOIN TDIN ON TDIN.NDINNUM = TACT.NDINNUM INNER JOIN TPER ON TPER.VPERADSI = " +
                                            $"TDIN.VDINCHAFF WHERE TACT.NACTNUM = {nactnum} AND TPER.VSOCIETE = '{MozartParams.NomSociete}'");

            if (rGDM.Read())
            {
              sDesc = Utils.BlankIfNull(rGDM["VACTDES"]).Replace("'", "''");
              sDescString = Strings.Left(sDesc, 7999).TrimEnd();
              sNomFichierXML = Generate_NOMXML(Utils.BlankIfNull(rGDM["VCODECLIENT"]));

              // insert dans la table GDM
              ModuleData.ExecuteNonQuery($"insert into TGDM (VCODECLIENT, VTYPEDEMANDE, VDIGDM, VCODEPRESTATAIRE, VACTIVITE, VDIEMALEC, VCONTACT, VCODESITE," +
                                         $" VNOMSITE, DDATECREATION, DDATEPLANIFIEE, VDESCRIPTION, VNOMXML, NACTNUM) VALUES ('{rGDM["VCODECLIENT"]}', 'DI','{NumGDM}'," +
                                         $"'EMALE009', '', '{rGDM["NDINNUM"]}/{nactnum}', '{rGDM["VPERMAILPRO"]}', '{rGDM["NSITNUE"]}', '{Utils.BlankIfNull(rGDM["VSITNOM"]).Replace("'", "''")}'," +
                                         $" '{DateTime.Now.ToShortDateString()} {DateTime.Now.ToShortTimeString()}', '{Utils.BlankIfNull(rGDM["DACTPLA"])}', '{sDescString}', '{sNomFichierXML}', {nactnum})");
            }
          }
          else
          {
            sDesc = Utils.BlankIfNull(rGDM["VACTDES"]).Replace("'", "''");
            sDescString = Strings.Left(sDesc, 7999).TrimEnd();
            sNomFichierXML = Generate_NOMXML(Utils.BlankIfNull(rGDM["VCODECLIENT"]));

            // update dans la table GDM.
            ModuleData.ExecuteNonQuery($"update TGDM SET VNOMXML = '{sNomFichierXML}', VDESCRIPTION = '{sDescString}', DDATEPLANIFIEE = '{Utils.BlankIfNull(rGDM["DACTPLA"])}'," +
                                       $" DDATECLOTUREINTERV = '{Utils.BlankIfNull(rGDM["DACTDEX"])}' where NACTNUM = {nactnum} ");
          }

          // ajout de l'attachement en PJ
          if (MessageBox.Show("Voulez-vous joindre l'attachement à l'envoi ?", Program.AppTitle, MessageBoxButtons.YesNo, MessageBoxIcon.Question, MessageBoxDefaultButton.Button2) == DialogResult.Yes)
          {
            JoindrePJ_GDM(sNomFichierXML, nactnum);
          }

          // Gestion des PJ ajoutées précédemment, pour l'envoi FTP
          PreparerEnvoiPJ(sNomFichierXML, nactnum);

          // fg le 22/11/2020 ajout de l'envoi du devis si demandé
          if (bEnvoyerDevis && DevisExiste(nactnum))
          {
            // On réouvre le recordset avec jointure sur le devis client cette fois
            rGDM.Close();
            rGDM = ModuleData.ExecuteReader($"select NGDMNUM, NDCLNUM, CDEVISTYPE, CTYPEMODELE, NDCLHT, DDCLDAT from " +
                                            $"TGDM INNER JOIN TACT on TACT.NACTNUM = TGDM.NACTNUM INNER JOIN TDCL ON TDCL.NACTNUM = " +
                                            $"TACT.NACTNUM WHERE TGDM.NACTNUM = {nactnum} ");
            rGDM.Read();

            // ajout devis dans l'envoi
            UpdateFlag_cJoindreDevisEnvoi_TGDM(nactnum, "O");

            sNomFichierXML_ssExt = Path.GetFileNameWithoutExtension(sNomFichierXML);

            // génération du devis en pdf
            string sNomReport = RechercheModeleDevis(Utils.BlankIfNull(rGDM["CDEVISTYPE"]), Utils.BlankIfNull(rGDM["CTYPEMODELE"]));
            new frmMainReport
            {
              bLaunchByProcessStart = false,
              sTypeReport = sNomReport,
              sIdentifiant = Utils.BlankIfNull(rGDM["NDCLNUM"]),
              InfosMail = "TCCL|NCCLCODE|000",
              sNomSociete = MozartParams.NomSociete,
              sLangue = "FR",
              sOption = "PDF",
              strType = "DC",
              numAction = nactnum
            }.ShowDialog();

            cheminGDMFTP = Utils.RechercheParam("REP_GDM_FTP");
            string Nomf = $"DD{rGDM["NDCLNUM"]}_{nactnum}.pdf";// Nom du fichier à stocker en SQL
            sNomFichierDD_PDF = $"{sNomFichierXML_ssExt}_{rGDM["NDCLNUM"]}_{Nomf}";
            File.Copy($@"{MozartParams.CheminUtilisateurMozart}PDF\{rGDM["NDCLNUM"]}.pdf", $@"{cheminGDMFTP}FTP\OutBox_PJ\{sNomFichierDD_PDF}", true);

            // Ecrire les détails du devis dans la table TGDM_DEVIS
            nGDMDEVISNUM = getNGDMDEVISNUM((int)Utils.ZeroIfNull(rGDM["NGDMNUM"]));// Voir si la section devis existe déjà en SQL
            if (nGDMDEVISNUM == 0)
            {
              ModuleData.ExecuteNonQuery($"insert into TGDM_DEVIS (NGDMNUM, VNUMERO, NMONTANT, DDATEDEVIS) VALUES ({rGDM["NGDMNUM"]}" +
                                         $", '{rGDM["NDCLNUM"]}', {Utils.BlankIfNull(rGDM["NDCLHT"]).Replace(",", ".")}, '{rGDM["DDCLDAT"]}')");
            }
            else
            {
              ModuleData.ExecuteNonQuery($"update TGDM_DEVIS SET VNUMERO = '{rGDM["NDCLNUM"]}', NMONTANT =  {Utils.BlankIfNull(rGDM["NDCLHT"]).Replace(",", ".")}," +
                                         $" DDATEDEVIS = '{rGDM["DDCLDAT"]}' where NGDMDEVISNUM = {nGDMDEVISNUM}");
            }

            // Récupérer à nouveau le n° unique de devis
            nGDMDEVISNUM = getNGDMDEVISNUM((int)Utils.ZeroIfNull(rGDM["NGDMNUM"]));

            // Ecrire les détails du devis dans la table TGDM_DEVIS_DOCLST
            ModuleData.ExecuteNonQuery($"insert into TGDM_DEVIS_DOCLST (NGDMDEVISNUM, VNOM, DDATE, VPROVENANCE) VALUES (" +
                                       $"{nGDMDEVISNUM}, '{Nomf}', '{DateTime.Now.ToShortDateString()} {DateTime.Now.ToShortTimeString()}', 'EMALEC')");

            // Tracer l'envoi dans le LOG
            ECRIRE_LOG_GDM((int)Utils.ZeroIfNull(rGDM["NGDMNUM"]), "DI mise à disposition du programme de transfert GDM, avec devis en PJ");
          }
          else
          {
            // pas de devis dans l'envoi
            UpdateFlag_cJoindreDevisEnvoi_TGDM(nactnum, "N");

            // Tracer l'envoi dans le LOG
            ECRIRE_LOG_GDM(getNGDMNUM(nactnum), "DI mise à disposition du programme de transfert GDM, sans devis en PJ");
          }

          rGDM.Close();

          // Tout s'est bien passé, on met à jour le flag d'envoi GDM
          ModuleData.ExecuteNonQuery($"update TGDM SET CSTATUT = 'A', BGENERERXML = 1 where NACTNUM = {nactnum}");
          MessageBox.Show("La demande d'intervention est en cours d'envoi chez GDM", Program.AppTitle, MessageBoxButtons.OK, MessageBoxIcon.Information);
        }


        //  ------------------------------------------------------------------------------------------------------------------------------------------------
        //  ------------------------------------------------------------------------------------------------------------------------------------------------
        if (TypeGDM == "DD")
        {
          // Je suis en mise à jour de la DD existante;
          // champs principaux concernés : Description, DatePlanifieeIntervention, DateClotureIntervention
          // ou bien en création d'une DD
          if (!bMAJData)
          {
            rGDM.Close();
            rGDM = ModuleData.ExecuteReader($"SELECT VACTDES, VCODECLIENT, TDIN.NDINNUM, VSITNOM, DACTPLA, DACTDEX, VPERMAILPRO, NSITNUE FROM " +
                                            $"TACT INNER JOIN TSIT on TSIT.NSITNUM = TACT.NSITNUM INNER JOIN TGDM_TCLI ON TGDM_TCLI.NCLINUM = " +
                                            $"TSIT.NCLINUM INNER JOIN TDIN ON TDIN.NDINNUM = TACT.NDINNUM INNER JOIN TPER ON TPER.VPERADSI = " +
                                            $"TDIN.VDINCHAFF WHERE TACT.NACTNUM = {nactnum} AND TPER.VSOCIETE = '{MozartParams.NomSociete}'");

            if (rGDM.Read())
            {
              sDesc = Utils.BlankIfNull(rGDM["VACTDES"]).Replace("'", "''");
              sDescString = Strings.Left(sDesc, 7999).TrimEnd();
              sNomFichierXML = Generate_NOMXML(Utils.BlankIfNull(rGDM["VCODECLIENT"]));

              // insert dans la table GDM
              ModuleData.ExecuteNonQuery($"insert into TGDM (VCODECLIENT, VTYPEDEMANDE, VDIGDM, VCODEPRESTATAIRE, VACTIVITE, VDIEMALEC, VCONTACT, VCODESITE," +
                                       $" VNOMSITE, DDATECREATION, DDATEPLANIFIEE, VDESCRIPTION, VNOMXML, NACTNUM) VALUES ('{rGDM["VCODECLIENT"]}', 'DI','{NumGDM}'," +
                                       $"'EMALE009', '', '{rGDM["NDINNUM"]}/{nactnum}', '{rGDM["VPERMAILPRO"]}', '{rGDM["NSITNUE"]}', '{Utils.BlankIfNull(rGDM["VSITNOM"]).Replace("'", "''")}'," +
                                       $" '{DateTime.Now.ToShortDateString()} {DateTime.Now.ToShortTimeString()}', '{Utils.BlankIfNull(rGDM["DACTPLA"])}', '{sDescString}', '{sNomFichierXML}', {nactnum})");
            }
          }
          else
          {
            sDesc = Utils.BlankIfNull(rGDM["VACTDES"]).Replace("'", "''");
            sDescString = Strings.Left(sDesc, 7999).TrimEnd();
            sNomFichierXML = Generate_NOMXML(Utils.BlankIfNull(rGDM["VCODECLIENT"]));

            // update dans la table GDM.
            ModuleData.ExecuteNonQuery($"update TGDM SET VNOMXML = '{sNomFichierXML}', VDESCRIPTION = '{sDescString}', DDATEPLANIFIEE = '{Utils.BlankIfNull(rGDM["DACTPLA"])}'," +
                                       $" DDATECLOTUREINTERV = '{Utils.BlankIfNull(rGDM["DACTDEX"])}' where NACTNUM = {nactnum} ");
          }

          // ajout de l'attachement en PJ
          if (MessageBox.Show("Voulez-vous joindre l'attachement à l'envoi ?", Program.AppTitle, MessageBoxButtons.YesNo, MessageBoxIcon.Question, MessageBoxDefaultButton.Button2) == DialogResult.Yes)
          {
            JoindrePJ_GDM(sNomFichierXML, nactnum);
          }

          // Gestion des PJ ajoutées précédemment, pour l'envoi FTP
          PreparerEnvoiPJ(sNomFichierXML, nactnum);

          // ajout devis si demandé et existe
          if (bEnvoyerDevis && DevisExiste(nactnum))
          {
            rGDM = ModuleData.ExecuteReader($"select NGDMNUM, NDCLNUM, CDEVISTYPE, CTYPEMODELE, NDCLHT, DDCLDAT  from TGDM INNER JOIN TACT on TACT.NACTNUM = TGDM.NACTNUM INNER JOIN TDCL ON TDCL.NACTNUM = TACT.NACTNUM WHERE TGDM.NACTNUM = {nactnum}");
            if (rGDM.Read())
            {
              // ajout envoi devis
              UpdateFlag_cJoindreDevisEnvoi_TGDM(nactnum, "O");

              sNomFichierXML_ssExt = Path.GetFileNameWithoutExtension(sNomFichierXML);

              // génération du devis en pdf
              string sNomReport = RechercheModeleDevis(Utils.BlankIfNull(rGDM["CDEVISTYPE"]), Utils.BlankIfNull(rGDM["CTYPEMODELE"]));
              new frmMainReport
              {
                bLaunchByProcessStart = false,
                sTypeReport = sNomReport,
                sIdentifiant = Utils.BlankIfNull(rGDM["NDCLNUM"]),
                InfosMail = "TCCL|NCCLCODE|000",
                sNomSociete = MozartParams.NomSociete,
                sLangue = "FR",
                sOption = "PDF",
                strType = "DC",
                numAction = nactnum
              }.ShowDialog();

              // Mettre le PDF à disposition du programme de gestion des transferts FTP
              cheminGDMFTP = Utils.RechercheParam("REP_GDM_FTP");
              string Nomf = $"DD{rGDM["NDCLNUM"]}_{nactnum}.pdf";// Nom du fichier à stocker en SQL
              sNomFichierDD_PDF = $"{sNomFichierXML_ssExt}_{rGDM["NDCLNUM"]}_{Nomf}";
              File.Copy($@"{MozartParams.CheminUtilisateurMozart}PDF\{rGDM["NDCLNUM"]}.pdf", $@"{cheminGDMFTP}FTP\OutBox_PJ\{sNomFichierDD_PDF}", true);

              // Ecrire les détails du devis dans la table TGDM_DEVIS
              nGDMDEVISNUM = getNGDMDEVISNUM((int)Utils.ZeroIfNull(rGDM["NGDMNUM"]));// Voir si la section devis existe déjà en SQL
              if (nGDMDEVISNUM == 0)
              {
                ModuleData.ExecuteNonQuery($"insert into TGDM_DEVIS (NGDMNUM, VNUMERO, NMONTANT, DDATEDEVIS) VALUES ({rGDM["NGDMNUM"]}" +
                                           $", '{rGDM["NDCLNUM"]}', {Utils.BlankIfNull(rGDM["NDCLHT"]).Replace(",", ".")}, '{rGDM["DDCLDAT"]}')");
              }
              else
              {
                ModuleData.ExecuteNonQuery($"update TGDM_DEVIS SET VNUMERO = '{rGDM["NDCLNUM"]}', NMONTANT =  {Utils.BlankIfNull(rGDM["NDCLHT"]).Replace(",", ".")}," +
                                           $" DDATEDEVIS = '{rGDM["DDCLDAT"]}' where NGDMDEVISNUM = {nGDMDEVISNUM}");
              }
              // Récupérer à nouveau le n° unique de devis
              nGDMDEVISNUM = getNGDMDEVISNUM((int)Utils.ZeroIfNull(rGDM["NGDMNUM"]));

              // Ecrire les détails du devis dans la table TGDM_DEVIS_DOCLST
              ModuleData.ExecuteNonQuery($"insert into TGDM_DEVIS_DOCLST (NGDMDEVISNUM, VNOM, DDATE, VPROVENANCE) VALUES (" +
                                         $"{nGDMDEVISNUM}, '{Nomf}', '{DateTime.Now.ToShortDateString()} {DateTime.Now.ToShortTimeString()}', 'EMALEC')");

              // Tracer l'envoi dans le LOG
              ECRIRE_LOG_GDM((int)Utils.ZeroIfNull(rGDM["NGDMNUM"]), "DD mise à disposition du programme de transfert GDM, avec devis en PJ");
            }
          }
          else
          {
            // pas de devis dans l'envoi
            UpdateFlag_cJoindreDevisEnvoi_TGDM(nactnum, "N");
            // Tracer l'envoi dans le LOG
            ECRIRE_LOG_GDM(getNGDMNUM(nactnum), "DD mise à disposition du programme de transfert GDM, sans devis en PJ");
          }

          rGDM.Close();

          // Tout s'est bien passé, on met à jour le flag d'envoi GDM
          ModuleData.ExecuteNonQuery($"update TGDM SET CSTATUT = 'A', BGENERERXML = 1 where NACTNUM = {nactnum}");
          MessageBox.Show("La demande d'intervention est en cours d'envoi chez GDM", Program.AppTitle, MessageBoxButtons.OK, MessageBoxIcon.Information);
        }


        // ------------------------------------------------------------------------------------------------------------------------------------------------
        // ------------------------------------------------------------------------------------------------------------------------------------------------
        if (TypeGDM == "DISR")
        {
          // Je suis en création d'une nouvelle demande de DI
          // Attention, d'après la documentation,  VACTIVITE serait facultatif
          // Attention PJ (DI en PDF) obligatoire
          rGDM.Close();

          rGDM = ModuleData.ExecuteReader($"SELECT VACTDES, VCODECLIENT, TDIN.NDINNUM, VSITNOM, DACTPLA, DACTDEX, VPERMAILPRO, NSITNUE FROM " +
                                          $"TACT INNER JOIN TSIT on TSIT.NSITNUM = TACT.NSITNUM INNER JOIN TGDM_TCLI ON TGDM_TCLI.NCLINUM = TSIT.NCLINUM " +
                                          $"INNER JOIN TDIN ON TDIN.NDINNUM = TACT.NDINNUM INNER JOIN TPER ON TPER.VPERADSI = TDIN.VDINCHAFF " +
                                          $"WHERE TACT.NACTNUM = {nactnum} AND TPER.VSOCIETE = '{MozartParams.NomSociete}'");
          if (!rGDM.Read())
          {
            MessageBox.Show("Erreur de données : impossible d'envoyer la demande DISR", Program.AppTitle, MessageBoxButtons.OK, MessageBoxIcon.Error);
            return false;
          }

          // pas de devis sur une DISR (car sinon c'est une DDSR)
          // et si on est en modification d'une DISR et qu'il y a un devis ?
          UpdateFlag_cJoindreDevisEnvoi_TGDM(nactnum, "N");

          sDesc = Utils.BlankIfNull(rGDM["VACTDES"]).Replace("'", "''");
          sDescString = Strings.Left(sDesc, 7999).TrimEnd();
          sNomFichierXML = Generate_NOMXML(Utils.BlankIfNull(rGDM["VCODECLIENT"]));

          if (!bMAJData)
          {
            // Nelle DISR
            ModuleData.ExecuteNonQuery($"insert into TGDM (VCODECLIENT, VTYPEDEMANDE, VCODEPRESTATAIRE, VACTIVITE, VDIEMALEC, VCONTACT, VCODESITE, VNOMSITE, DDATECREATION, DDATEPLANIFIEE, VDESCRIPTION, VNOMXML, NACTNUM)" +
                                       $" VALUES ('{rGDM["VCODECLIENT"]}', 'DISR', 'EMALE009', '', '{rGDM["NDINNUM"]}/{nactnum}', '{rGDM["VPERMAILPRO"]}', '{rGDM["NSITNUE"]}'" +
                                       $", '{ Utils.BlankIfNull(rGDM["VSITNOM"]).Replace("'", "''")}', '{DateTime.Now.ToShortDateString()} {DateTime.Now.ToShortTimeString()}'" +
                                       $", '{Utils.BlankIfNull(rGDM["DACTPLA"])}', '{sDescString}', '{sNomFichierXML}', {nactnum})");
          }
          else
          {
            // Màj DISR existante
            ModuleData.ExecuteNonQuery($"update TGDM SET VNOMXML = '{sNomFichierXML}', VDESCRIPTION = '{sDescString}', DDATEPLANIFIEE = '{Utils.BlankIfNull(rGDM["DACTPLA"])}', DDATECLOTUREINTERV = '{Utils.BlankIfNull(rGDM["DACTDEX"])}' where NACTNUM = {nactnum}");
          }

          // On nettoie avant, car il ne doit y avoir qu'une seule DI en PDF comme pièce jointe :
          Nettoyer_PJ_EMALEC_BDD("DI", nactnum);

          sNomFichierXML_ssExt = Path.GetFileNameWithoutExtension(sNomFichierXML);

          // Générer la DI en PDF
          new frmMainReport
          {
            bLaunchByProcessStart = false,
            sTypeReport = "TDIGDM",
            sIdentifiant = nactnum.ToString(),
            InfosMail = "TCCL|NCCLCODE|000",
            sNomSociete = MozartParams.NomSociete,
            sLangue = "FR",
            sOption = "PDF",
            strType = "",
            numAction = nactnum
          }.ShowDialog();

          // Mettre le PDF à disposition du programme de gestion des transferts FTP
          cheminGDMFTP = Utils.RechercheParam("REP_GDM_FTP");
          string Nomf2 = $"DI{rGDM["NDINNUM"]}A{nactnum}.pdf";// Nom du fichier à stocker en SQL
          string sNomFichierDI_PDF = sNomFichierXML_ssExt + "_" + Nomf2;
          File.Copy($@"{MozartParams.CheminUtilisateurMozart}PDF\{nactnum}.pdf", $@"{cheminGDMFTP}FTP\OutBox_PJ\{sNomFichierDI_PDF}", true);

          rGDM.Close();

          rGDM = ModuleData.ExecuteReader($"select NGDMNUM from TGDM WHERE TGDM.NACTNUM = {nactnum}");
          rGDM.Read();

          // Ecrire les détails de la pièce jointe dans la table TGDM_LSTDOC
          ModuleData.ExecuteNonQuery($"insert into TGDM_LSTDOC (NGDMNUM, VNOM, DDATE, VPROVENANCE, DDATEENVOI, BENVOYERPJ, TYPEPJ) VALUES ({rGDM["NGDMNUM"]}" +
                                     $", '{Nomf2}', '{DateTime.Now.ToShortDateString()} {DateTime.Now.ToShortTimeString()}', 'EMALEC', '{DateTime.Now.ToShortDateString()} {DateTime.Now.ToShortTimeString()}', 1, 'DI')");


          // ajout de l'attachement en PJ
          if (MessageBox.Show("Voulez-vous joindre l'attachement à l'envoi ?", Program.AppTitle, MessageBoxButtons.YesNo, MessageBoxIcon.Question, MessageBoxDefaultButton.Button2) == DialogResult.Yes)
          {
            JoindrePJ_GDM(sNomFichierXML, nactnum);
          }

          // Gestion des PJ ajoutées précédemment, pour l'envoi FTP
          PreparerEnvoiPJ(sNomFichierXML, nactnum);

          // Tracer l'envoi dans le LOG
          ECRIRE_LOG_GDM((int)Utils.ZeroIfNull(rGDM["NGDMNUM"]), "DISR mise à disposition du programme de transfert GDM");

          rGDM.Close();

          // Tout s'est bien passé, on met à jour le flag d'envoi GDM
          ModuleData.ExecuteNonQuery($"update TGDM SET CSTATUT = 'A', BGENERERXML = 1 where NACTNUM = {nactnum}");

          MessageBox.Show("La nouvelle DI est en cours d'envoi chez GDM", Program.AppTitle, MessageBoxButtons.OK, MessageBoxIcon.Information);
        }

        //'------------------------------------------------------------------------------------------------------------------------------------------------
        //'------------------------------------------------------------------------------------------------------------------------------------------------
        //'------------------------------------------------------------------------------------------------------------------------------------------------
        if (TypeGDM == "DDSR")
        {
          // Je suis en création d'une nouvelle demande de DD
          // Attention, d'après la documentation, VACTIVITE serait facultatif
          rGDM.Close();

          rGDM = ModuleData.ExecuteReader($"SELECT VACTDES, VCODECLIENT, TDIN.NDINNUM, VSITNOM, DACTPLA, DACTDEX, VPERMAILPRO, NSITNUE FROM " +
                                          $"TACT INNER JOIN TSIT on TSIT.NSITNUM = TACT.NSITNUM INNER JOIN TGDM_TCLI ON TGDM_TCLI.NCLINUM = " +
                                          $"TSIT.NCLINUM INNER JOIN TDIN ON TDIN.NDINNUM = TACT.NDINNUM INNER JOIN TPER ON TPER.VPERADSI = " +
                                          $"TDIN.VDINCHAFF WHERE TACT.NACTNUM = {nactnum} AND TPER.VSOCIETE = '{MozartParams.NomSociete}'");
          if (!rGDM.Read())
          {
            MessageBox.Show("Erreur de données : impossible d'envoyer la demande DDSR", Program.AppTitle, MessageBoxButtons.OK, MessageBoxIcon.Error);
            rGDM.Close();
            return false;
          }

          sDesc = Utils.BlankIfNull(rGDM["VACTDES"]).Replace("'", "''");
          sDescString = Strings.Left(sDesc, 7999).TrimEnd();
          sNomFichierXML = Generate_NOMXML(Utils.BlankIfNull(rGDM["VCODECLIENT"]));

          if (!bMAJData)
          {
            // Nelle DDSR
            ModuleData.ExecuteNonQuery($"insert into TGDM (VCODECLIENT, VTYPEDEMANDE, VCODEPRESTATAIRE, VACTIVITE, VDIEMALEC, VCONTACT, VCODESITE, VNOMSITE, DDATECREATION, DDATEPLANIFIEE, VDESCRIPTION, VNOMXML, NACTNUM)" +
                                        $" VALUES ('{rGDM["VCODECLIENT"]}', 'DDSR', 'EMALE009', '', '{rGDM["NDINNUM"]}/{nactnum}', '{rGDM["VPERMAILPRO"]}', '{rGDM["NSITNUE"]}'" +
                                        $", '{ Utils.BlankIfNull(rGDM["VSITNOM"]).Replace("'", "''")}', '{DateTime.Now.ToShortDateString()} {DateTime.Now.ToShortTimeString()}'" +
                                        $", '{Utils.BlankIfNull(rGDM["DACTPLA"])}', '{sDescString}', '{sNomFichierXML}', {nactnum})");

          }
          else
          {
            // Màj DDSR existante (interdit normalement mais pourquoi pas)
            ModuleData.ExecuteNonQuery($"update TGDM SET VNOMXML = '{sNomFichierXML}', VDESCRIPTION = '{sDescString}', DDATEPLANIFIEE = '{Utils.BlankIfNull(rGDM["DACTPLA"])}', DDATECLOTUREINTERV = '{Utils.BlankIfNull(rGDM["DACTDEX"])}' where NACTNUM = {nactnum}");
          }

          if (bEnvoyerDevis)
          {
            // On réouvre le recordset avec jointure sur le devis client
            rGDM.Close();

            UpdateFlag_cJoindreDevisEnvoi_TGDM(nactnum, "O");

            rGDM = ModuleData.ExecuteReader($"select NGDMNUM, NDCLNUM, CDEVISTYPE, CTYPEMODELE, NDCLHT, DDCLDAT " +
                                            $"from TGDM INNER JOIN TACT on TACT.NACTNUM = TGDM.NACTNUM INNER JOIN TDCL ON TDCL.NACTNUM = " +
                                            $"TACT.NACTNUM WHERE TGDM.NACTNUM = {nactnum}");
            rGDM.Read();

            sNomFichierXML_ssExt = Path.GetFileNameWithoutExtension(sNomFichierXML);

            // génération du devis en pdf
            string sNomReport = RechercheModeleDevis(Utils.BlankIfNull(rGDM["CDEVISTYPE"]), Utils.BlankIfNull(rGDM["CTYPEMODELE"]));
            new frmMainReport
            {
              bLaunchByProcessStart = false,
              sTypeReport = sNomReport,
              sIdentifiant = Utils.BlankIfNull(rGDM["NDCLNUM"]),
              InfosMail = "TCCL|NCCLCODE|000",
              sNomSociete = MozartParams.NomSociete,
              sLangue = "FR",
              sOption = "PDF",
              strType = "DC",
              numAction = nactnum
            }.ShowDialog();

            // Mettre le PDF à disposition du programme de gestion des transferts FTP
            cheminGDMFTP = Utils.RechercheParam("REP_GDM_FTP");
            string Nomf = $"DD{rGDM["NDCLNUM"]}_{nactnum}.pdf";// Nom du fichier à stocker en SQL
            sNomFichierDD_PDF = $"{sNomFichierXML_ssExt}_{rGDM["NDCLNUM"]}_{Nomf}";
            File.Copy($@"{MozartParams.CheminUtilisateurMozart}PDF\{rGDM["NDCLNUM"]}.pdf", $@"{cheminGDMFTP}FTP\OutBox_PJ\{sNomFichierDD_PDF}", true);

            // Ecrire les détails du devis dans la table TGDM_DEVIS
            nGDMDEVISNUM = getNGDMDEVISNUM((int)Utils.ZeroIfNull(rGDM["NGDMNUM"]));// Voir si la section devis existe déjà en SQL
            if (nGDMDEVISNUM == 0)
            {
              ModuleData.ExecuteNonQuery($"insert into TGDM_DEVIS (NGDMNUM, VNUMERO, NMONTANT, DDATEDEVIS) VALUES ({rGDM["NGDMNUM"]}" +
                                         $", '{rGDM["NDCLNUM"]}', {Utils.BlankIfNull(rGDM["NDCLHT"]).Replace(",", ".")}, '{rGDM["DDCLDAT"]}')");
            }
            else
            {
              ModuleData.ExecuteNonQuery($"update TGDM_DEVIS SET VNUMERO = '{rGDM["NDCLNUM"]}', NMONTANT =  {Utils.BlankIfNull(rGDM["NDCLHT"]).Replace(",", ".")}," +
                                         $" DDATEDEVIS = '{rGDM["DDCLDAT"]}' where NGDMDEVISNUM = {nGDMDEVISNUM}");
            }

            // Récupérer à nouveau le n° unique de devis
            nGDMDEVISNUM = getNGDMDEVISNUM((int)Utils.ZeroIfNull(rGDM["NGDMNUM"]));

            // Ecrire les détails du devis dans la table TGDM_DEVIS_DOCLST
            ModuleData.ExecuteNonQuery($"insert into TGDM_DEVIS_DOCLST (NGDMDEVISNUM, VNOM, DDATE, VPROVENANCE) VALUES (" +
                                       $"{nGDMDEVISNUM}, '{Nomf}', '{DateTime.Now.ToShortDateString()} {DateTime.Now.ToShortTimeString()}', 'EMALEC')");


            // ajout de l'attachement en PJ
            if (MessageBox.Show("Voulez-vous joindre l'attachement à l'envoi ?", Program.AppTitle, MessageBoxButtons.YesNo, MessageBoxIcon.Question, MessageBoxDefaultButton.Button2) == DialogResult.Yes)
            {
              JoindrePJ_GDM(sNomFichierXML, nactnum);
            }

            // Gestion des PJ ajoutées précédemment, pour l'envoi FTP
            PreparerEnvoiPJ(sNomFichierXML, nactnum);

            // Tracer l'envoi dans le LOG
            ECRIRE_LOG_GDM((int)Utils.ZeroIfNull(rGDM["NGDMNUM"]), "DDSR mise à disposition du programme de transfert GDM avec devis en PJ");
          }
          else
          {
            UpdateFlag_cJoindreDevisEnvoi_TGDM(nactnum, "N");
            // Tracer l'envoi dans le LOG
            ECRIRE_LOG_GDM(getNGDMNUM((int)Utils.ZeroIfNull(rGDM["NGDMNUM"])), "DDSR mise à disposition du programme de transfert GDM sans devis en PJ");
          }

          rGDM.Close();

          // Tout s'est bien passé, on met à jour le flag d'envoi GDM
          ModuleData.ExecuteNonQuery($"update TGDM SET CSTATUT = 'A', BGENERERXML = 1 where NACTNUM = {nactnum}");
          MessageBox.Show("La nouvelle demande de devis est en cours d'envoi chez GDM", Program.AppTitle, MessageBoxButtons.OK, MessageBoxIcon.Information);
        }

        // Mise à jour du champ observation de l'action
        string sObs = $"{MozartParams.strUID} le {DateTime.Now.ToString("dd/MM/yy HH:mm")} : Envoi des données chez GDM.";
        ModuleData.ExecuteNonQuery($"update TACT set VACTOBS = '{sObs}' + Char(13) + Char(10) + coalesce(VACTOBS,'') where nactnum = {nactnum}");

        txtObserv = $"{sObs}{Environment.NewLine}{txtObserv}";
      }
      catch (Exception ex)
      {
        MZUtils.displayError(MethodBase.GetCurrentMethod().Name, ex);
      }
      finally
      {
        Cursor.Current = Cursors.Default;
        if (null != rGDM && !rGDM.IsClosed) rGDM.Close();
      }

      return true;
    }
    //  ' si cette action existe déjà dans TGDM, on renvoie les infos pour modification
    //  ' si cette action n'existe pas dans TGDM :
    //      ' si on a un numéro GDM sur la DI, on crée une DI ou une DD (en fonction de ce qui exite déjà dans TGDM ?) et on envoie
    //      ' si pas de numéro GDM sur la DI, on fait une DISR ou une DDSR (en fonction devis ou pas)


    //  ' on recherche si cette action a déjà un traitement dans la table TGDM
    //  Set rsGDM = New ADODB.Recordset
    //  rsGDM.Open "select * from TGDM INNER JOIN TACT on TACT.NACTNUM = TGDM.NACTNUM WHERE TGDM.NACTNUM = " & nactnum, cnx

    //  If rsGDM.EOF Then
    //    ' si pas de numéro GDM et pas de ligne pour cette action, on fait une DISR ou DDSR (en fonction devis ou pas)
    //    If NumGDM = 0 Then
    //      If bEnvoyerDevis Then
    //          TypeGDM = "DDSR"
    //        Else
    //          TypeGDM = "DISR"
    //      End If
    //    Else
    //      ' numéro GDM existe sur la DI et pas de demande sur cette action dans TGDM
    //      ' donc on va faire une DI ou une DD (en fonction de ce qui existe déjà sur la DI) sur cette action en reprenant le numéro GDM existant
    //      ' donc il faut faire un insert dans TGDM
    //      Set rsNumGDM = New ADODB.Recordset
    //      rsNumGDM.Open "select * from TGDM where VDIGDM = " & NumGDM, cnx
    //      TypeGDM = rsNumGDM("VTYPEDEMANDE")
    //      rsNumGDM.Close
    //      Set rsNumGDM = Nothing
    //    End If
    //    bMAJData = False
    //  Else
    //    ' Correspondance trouvée dans TGDM: DI ou DD déjà existante (! ! ! mise à jour de DISR ou DDSR interdite)
    //    ' si on trouve que c'est une demande GDM que l'on a déjà envoyé nous même (DISR ou DDSR), normalement il ne faut pas la renvoyer chez le client
    //    ' mais est-ce si grave ?
    //    ' car souvent ils me demandent de renvoyer la demande car le client n'a rien reçu.
    //    TypeGDM = rsGDM("VTYPEDEMANDE")
    //    NGDMNUM = rsGDM("NGDMNUM")
    //'   si on veut ne pas renvoyer les DISR et les DDSR
    //'    If TypeGDM = "DISR" Or TypeGDM = "DDSR" Then
    //'      ' En attente de retour de chez GDM
    //'      MsgBox "La demande est en cours de traitement chez GDM. Vous ne pouvez pas refaire un envoi GDM pour l'instant.", vbCritical + vbOKOnly, "ATTENTION"
    //'      Screen.MousePointer = vbDefault
    //'      Exit Function
    //'    End If

    //    ' on est en mise à jour de la ligne
    //    bMAJData = True
    //  End If

    //  ' Mettre l'imprimante PDF par défaut
    //  If SelectImpPDF(cstImpPDF) = False Then
    //    MsgBox "L'imprimante PDF n'est pas accessible sur ce poste", , "PB d'imprimante PDF"
    //    Exit Function
    //  End If

    //  ' 2 Traiter chaque cas différent (à priori, il y a 4 cas différents et 2 sous-cas dans les cas DI et DD)
    //  '------------------------------------------------------------------------------------------------------------------------------------------------
    //  '------------------------------------------------------------------------------------------------------------------------------------------------
    //  If TypeGDM = "DI" Then
    //    ' champs principaux concernés : Description, DatePlanifieeIntervention, DateClotureIntervention, VNOMXML
    //    ' Je suis en mise à jour de la DI existante;
    //    ' nouveau cas :  Je suis en création d'une ligne GDM sur une action avec un numéro GDM existant sur la DI
    //    If Not bMAJData Then
    //      rsGDM.Close

    //      rsGDM.Open "select * from TACT INNER JOIN TSIT on TSIT.NSITNUM = TACT.NSITNUM INNER JOIN TGDM_TCLI ON TGDM_TCLI.NCLINUM = TSIT.NCLINUM INNER JOIN TDIN ON TDIN.NDINNUM = TACT.NDINNUM INNER JOIN TPER ON TPER.VPERADSI = TDIN.VDINCHAFF WHERE TACT.NACTNUM = " & nactnum & " AND TPER.VSOCIETE = '" & gstrNomSociete & "'", cnx

    //      sDesc = Replace(rsGDM("VACTDES"), "'", "''")
    //      sDescString = RTrim(Left(sDesc, 7999))
    //      sNomFichierXML = Generate_NOMXML(rsGDM("VCODECLIENT"))

    //      ' insert dans la table GDM
    //      o_sql = "insert into TGDM (VCODECLIENT, VTYPEDEMANDE, VDIGDM, VCODEPRESTATAIRE, VACTIVITE, VDIEMALEC, VCONTACT, VCODESITE, VNOMSITE, DDATECREATION, DDATEPLANIFIEE, VDESCRIPTION, VNOMXML, NACTNUM) VALUES ('"
    //      o_sql = o_sql & rsGDM("VCODECLIENT") & "', 'DI','" & NumGDM & "','EMALE009', '', '" & rsGDM("NDINNUM") & "/" & nactnum & "', '" & rsGDM("VPERMAILPRO") & "', '" & rsGDM("NSITNUE") & "', '" & Replace(rsGDM("VSITNOM"), "'", "''") & "', '" & DateValue(Now) & " " & TimeValue(Now)
    //      o_sql = o_sql & "', '" & BlankIfNull(rsGDM("DACTPLA")) & "', '" & sDescString & "', '" & sNomFichierXML & "', " & nactnum & ")"
    //      cnx.Execute o_sql


    //    Else
    //      sDesc = Replace(rsGDM("VACTDES"), "'", "''")
    //      sDescString = RTrim(Left(sDesc, 7999))
    //      sNomFichierXML = Generate_NOMXML(rsGDM("VCODECLIENT"))

    //      ' update dans la table GDM.
    //      o_sql = "update TGDM SET VNOMXML = '" & sNomFichierXML & "', VDESCRIPTION = '" & sDescString & "', DDATEPLANIFIEE = '" & BlankIfNull(rsGDM("DACTPLA")) & "', DDATECLOTUREINTERV = '" & BlankIfNull(rsGDM("DACTDEX")) & "' where NACTNUM = " & nactnum
    //      cnx.Execute o_sql


    //    End If

    //    ' Gestion des PJ ajoutées précédemment, pour l'envoi FTP
    //    PreparerEnvoiPJ sNomFichierXML, nactnum

    //    ' fg le 22/11/2020 ajout de l'envoi du devis si demandé
    //    If bEnvoyerDevis = True And DevisExiste(nactnum) Then
    //       ' On réouvre le recordset avec jointure sur le devis client cette fois
    //        rsGDM.Close

    //        rsGDM.Open "select NGDMNUM, NDCLNUM, CDEVISTYPE, CTYPEMODELE, NDCLHT, DDCLDAT from TGDM INNER JOIN TACT on TACT.NACTNUM = TGDM.NACTNUM INNER JOIN TDCL ON TDCL.NACTNUM = TACT.NACTNUM WHERE TGDM.NACTNUM = " & nactnum, cnx

    //        ' ajout devis dans l'envoi
    //        UpdateFlag_cJoindreDevisEnvoi_TGDM nactnum, "O"


    //        sNomFichierXML_ssExt = Left(sNomFichierXML, Len(sNomFichierXML) - 4)  ' On enlève .xml

    //        ' génération du devis en pdf
    //        ShellAndWait gstrRepertoireReports & "ReportEmalec.Net.exe " & """" & RechercheModeleDevis(rsGDM("CTYPEMODELE")) & ";" & rsGDM("NDCLNUM") & ";TCCL|NCCLCODE|000;" & gstrNomSociete & ";FR;PDF;DC;" & nactnum & """", vbNormalFocus

    //        ' Mettre le PDF à disposition du programme de gestion des transferts FTP
    //        cheminGDMFTP = RechercheParam("REP_GDM_FTP")


    //        Dim Nomf As String ' Nom du fichier à stocker en SQL
    //        Nomf = "DD" & rsGDM("NDCLNUM") & "_" & nactnum & ".pdf"

    //        sNomFichierDD_PDF = sNomFichierXML_ssExt & "_" & rsGDM("NDCLNUM") & "_" & Nomf
    //        fs.CopyFile gstrCheminUtilisateur & "\Mozart\PDF\" & rsGDM("NDCLNUM") & ".pdf", cheminGDMFTP & "FTP\OutBox_PJ\" & sNomFichierDD_PDF, True

    //        ' Ecrire les détails du devis dans la table TGDM_DEVIS
    //        nGDMDEVISNUM = getNGDMDEVISNUM(rsGDM("NGDMNUM"))  ' Voir si la section devis existe déjà en SQL
    //        If nGDMDEVISNUM = 0 Then
    //          o_sql = "insert into TGDM_DEVIS (NGDMNUM, VNUMERO, NMONTANT, DDATEDEVIS) VALUES (" & rsGDM("NGDMNUM")
    //          o_sql = o_sql & ", '" & rsGDM("NDCLNUM") & "', " & Replace(rsGDM("NDCLHT"), ",", ".") & ", '" & rsGDM("DDCLDAT") & "')"
    //          cnx.Execute o_sql
    //        Else
    //          o_sql = "update TGDM_DEVIS SET VNUMERO = '" & rsGDM("NDCLNUM") & "', NMONTANT = " & Replace(rsGDM("NDCLHT"), ",", ".") & ", DDATEDEVIS = '" & rsGDM("DDCLDAT") & "' where NGDMDEVISNUM = " & nGDMDEVISNUM
    //          cnx.Execute o_sql
    //        End If

    //        ' Récupérer à nouveau le n° unique de devis
    //        nGDMDEVISNUM = getNGDMDEVISNUM(rsGDM("NGDMNUM"))

    //        ' Ecrire les détails du devis dans la table TGDM_DEVIS_DOCLST
    //        o_sql = "insert into TGDM_DEVIS_DOCLST (NGDMDEVISNUM, VNOM, DDATE, VPROVENANCE) VALUES ("
    //        o_sql = o_sql & nGDMDEVISNUM & ", '" & Nomf & "', '" & DateValue(Now) & " " & TimeValue(Now) & "', 'EMALEC')"
    //        cnx.Execute o_sql

    //        ' Tracer l'envoi dans le LOG
    //        ECRIRE_LOG_GDM rsGDM("NGDMNUM"), "DI mise à disposition du programme de transfert GDM, avec devis en PJ"

    //        '*****************************************************************************************

    //    Else
    //        ' pas de devis dans l'envoi
    //        UpdateFlag_cJoindreDevisEnvoi_TGDM nactnum, "N"

    //        ' Tracer l'envoi dans le LOG
    //        ECRIRE_LOG_GDM rsGDM("NGDMNUM"), "DI mise à disposition du programme de transfert GDM, sans devis en PJ"
    //    End If


    //    rsGDM.Close

    //    ' Tout s'est bien passé, on met à jour le flag d'envoi GDM
    //    o_sql = "update TGDM SET CSTATUT = 'A', BGENERERXML = 1 where NACTNUM = " & nactnum
    //    cnx.Execute o_sql

    //    MsgBox "La demande d'intervention est en cours d'envoi chez GDM", vbInformation + vbOKOnly

    //  End If

    //  '------------------------------------------------------------------------------------------------------------------------------------------------
    //  '------------------------------------------------------------------------------------------------------------------------------------------------
    //  If TypeGDM = "DD" Then
    //    ' Je suis en mise à jour de la DD existante;
    //    'champs principaux concernés : Description, DatePlanifieeIntervention, DateClotureIntervention
    //    ' ou bien en création d'une DD
    //    If Not bMAJData Then
    //      rsGDM.Close

    //      rsGDM.Open "select * from TACT INNER JOIN TSIT on TSIT.NSITNUM = TACT.NSITNUM INNER JOIN TGDM_TCLI ON TGDM_TCLI.NCLINUM = TSIT.NCLINUM INNER JOIN TDIN ON TDIN.NDINNUM = TACT.NDINNUM INNER JOIN TPER ON TPER.VPERADSI = TDIN.VDINCHAFF WHERE TACT.NACTNUM = " & nactnum & " AND TPER.VSOCIETE = '" & gstrNomSociete & "'", cnx

    //      sDesc = Replace(rsGDM("VACTDES"), "'", "''")
    //      sDescString = RTrim(Left(sDesc, 7999))
    //      sNomFichierXML = Generate_NOMXML(rsGDM("VCODECLIENT"))

    //      ' insert dans la table GDM
    //      o_sql = "insert into TGDM (VCODECLIENT, VTYPEDEMANDE, VDIGDM, VCODEPRESTATAIRE, VACTIVITE, VDIEMALEC, VCONTACT, VCODESITE, VNOMSITE, DDATECREATION, DDATEPLANIFIEE, VDESCRIPTION, VNOMXML, NACTNUM) VALUES ('"
    //      o_sql = o_sql & rsGDM("VCODECLIENT") & "', 'DI','" & NumGDM & "','EMALE009', '', '" & rsGDM("NDINNUM") & "/" & nactnum & "', '" & rsGDM("VPERMAILPRO") & "', '" & rsGDM("NSITNUE") & "', '" & Replace(rsGDM("VSITNOM"), "'", "''") & "', '" & DateValue(Now) & " " & TimeValue(Now)
    //      o_sql = o_sql & "', '" & BlankIfNull(rsGDM("DACTPLA")) & "', '" & sDescString & "', '" & sNomFichierXML & "', " & nactnum & ")"
    //      cnx.Execute o_sql


    //    Else
    //      sDesc = Replace(rsGDM("VACTDES"), "'", "''")
    //      sDescString = RTrim(Left(sDesc, 7999))
    //      sNomFichierXML = Generate_NOMXML(rsGDM("VCODECLIENT"))

    //      ' update dans la table GDM.
    //      o_sql = "update TGDM SET VNOMXML = '" & sNomFichierXML & "', VDESCRIPTION = '" & sDescString & "', DDATEPLANIFIEE = '" & BlankIfNull(rsGDM("DACTPLA")) & "', DDATECLOTUREINTERV = '" & BlankIfNull(rsGDM("DACTDEX")) & "' where NACTNUM = " & nactnum
    //      cnx.Execute o_sql


    //    End If

    //    ' Gestion des PJ ajoutées précédemment, pour l'envoi FTP
    //    PreparerEnvoiPJ sNomFichierXML, nactnum

    //    ' ajout devis si demandé et existe
    //    If bEnvoyerDevis = True And DevisExiste(nactnum) Then
    //      ' On réouvre le recordset avec jointure sur le devis client
    //      rsGDM.Close

    //      rsGDM.Open "select NGDMNUM, NDCLNUM, CDEVISTYPE, CTYPEMODELE, NDCLHT, DDCLDAT  from TGDM INNER JOIN TACT on TACT.NACTNUM = TGDM.NACTNUM INNER JOIN TDCL ON TDCL.NACTNUM = TACT.NACTNUM WHERE TGDM.NACTNUM = " & nactnum, cnx

    //      ' ajout envoi devis
    //      UpdateFlag_cJoindreDevisEnvoi_TGDM nactnum, "O"


    //      sNomFichierXML_ssExt = Left(sNomFichierXML, Len(sNomFichierXML) - 4)  ' On enlève .xml

    //      ' génération du devis en pdf
    //      ShellAndWait gstrRepertoireReports & "ReportEmalec.Net.exe " & """" & RechercheModeleDevis(rsGDM("CTYPEMODELE")) & ";" & rsGDM("NDCLNUM") & ";TCCL|NCCLCODE|000;" & gstrNomSociete & ";FR;PDF;DC;" & nactnum & """", vbNormalFocus

    //      ' Mettre le PDF à disposition du programme de gestion des transferts FTP
    //      cheminGDMFTP = RechercheParam("REP_GDM_FTP")

    //      Nomf = "DD" & rsGDM("NDCLNUM") & "_" & nactnum & ".pdf"

    //      sNomFichierDD_PDF = sNomFichierXML_ssExt & "_" & rsGDM("NDCLNUM") & "_" & Nomf
    //      fs.CopyFile gstrCheminUtilisateur & "\Mozart\PDF\" & rsGDM("NDCLNUM") & ".pdf", cheminGDMFTP & "FTP\OutBox_PJ\" & sNomFichierDD_PDF, True

    //      ' Ecrire les détails du devis dans la table TGDM_DEVIS
    //      nGDMDEVISNUM = getNGDMDEVISNUM(rsGDM("NGDMNUM"))  ' Voir si la section devis existe déjà en SQL
    //      If nGDMDEVISNUM = 0 Then
    //        o_sql = "insert into TGDM_DEVIS (NGDMNUM, VNUMERO, NMONTANT, DDATEDEVIS) VALUES (" & rsGDM("NGDMNUM")
    //        o_sql = o_sql & ", '" & rsGDM("NDCLNUM") & "', " & Replace(rsGDM("NDCLHT"), ",", ".") & ", '" & rsGDM("DDCLDAT") & "')"
    //        cnx.Execute o_sql
    //      Else
    //        o_sql = "update TGDM_DEVIS SET VNUMERO = '" & rsGDM("NDCLNUM") & "', NMONTANT = " & Replace(rsGDM("NDCLHT"), ",", ".") & ", DDATEDEVIS = '" & rsGDM("DDCLDAT") & "' where NGDMDEVISNUM = " & nGDMDEVISNUM
    //        cnx.Execute o_sql
    //      End If

    //      ' Récupérer à nouveau le n° unique de devis
    //      nGDMDEVISNUM = getNGDMDEVISNUM(rsGDM("NGDMNUM"))

    //      ' Ecrire les détails du devis dans la table TGDM_DEVIS_DOCLST
    //      o_sql = "insert into TGDM_DEVIS_DOCLST (NGDMDEVISNUM, VNOM, DDATE, VPROVENANCE) VALUES ("
    //      o_sql = o_sql & nGDMDEVISNUM & ", '" & Nomf & "', '" & DateValue(Now) & " " & TimeValue(Now) & "', 'EMALEC')"
    //      cnx.Execute o_sql

    //      ' Tracer l'envoi dans le LOG
    //      ECRIRE_LOG_GDM rsGDM("NGDMNUM"), "DD mise à disposition du programme de transfert GDM, avec devis en PJ"

    //    Else
    //      ' pas de devis
    //      UpdateFlag_cJoindreDevisEnvoi_TGDM nactnum, "N"


    //      ECRIRE_LOG_GDM rsGDM("NGDMNUM"), "DD mise à disposition du programme de transfert GDM, sans devis en PJ"

    //    End If


    //    rsGDM.Close

    //    ' Tout s'est bien passé, on met à jour le flag d'envoi GDM
    //    o_sql = "update TGDM SET CSTATUT = 'A', BGENERERXML = 1 where NACTNUM = " & nactnum
    //    cnx.Execute o_sql

    //    MsgBox "La demande de devis est en cours d'envoi chez GDM", vbInformation + vbOKOnly

    //  End If

    //''  '------------------------------------------------------------------------------------------------------------------------------------------------
    //''  '------------------------------------------------------------------------------------------------------------------------------------------------
    //''  If TypeGDM = "DD" And Not bMAJData Then
    //''    ' Je suis en création d'une ligne GDM sur une action avec un numéro GDM sur la DI (nouveau cas); champs principaux concernés : Description, DatePlanifieeIntervention, DateClotureIntervention
    //''    sDesc = Replace(rsGDM("VACTDES"), "'", "''")
    //''    sDescString = RTrim(Left(sDesc, 7999))
    //''    sNomFichierXML = Generate_NOMXML(rsGDM("VCODECLIENT"))
    //''
    //''    ' préparation de l'update dans la table GDM, (uniquement si on ne sort pas de cette fonction avant la fin)
    //''    o_sql = "update TGDM SET VNOMXML = '" & sNomFichierXML & "', VDESCRIPTION = '" & sDescString & "', DDATEPLANIFIEE = '" & BlankIfNull(rsGDM("DACTPLA")) & "', DDATECLOTUREINTERV = '" & BlankIfNull(rsGDM("DACTDEX")) & "' where NACTNUM = " & nactnum
    //''
    //''    ' Gestion des PJ ajoutées précédemment, pour l'envoi FTP
    //''    PreparerEnvoiPJ sNomFichierXML, nactnum
    //''
    //''    If bEnvoyerDevis = True Then
    //''      ' On réouvre le recordset avec jointure sur le devis client
    //''      rsGDM.Close
    //''
    //''      rsGDM.Open "select NGDMNUM, NDCLNUM, CDEVISTYPE,NDCLHT, DDCLDAT  from TGDM INNER JOIN TACT on TACT.NACTNUM = TGDM.NACTNUM INNER JOIN TDCL ON TDCL.NACTNUM = TACT.NACTNUM WHERE TGDM.NACTNUM = " & nactnum, cnx
    //''
    //''      ' si pas de devis client, on envoie pas la demande
    //''      If rsGDM.EOF Then
    //''        MsgBox "Aucun devis client n'a été créé pour cette demande GDM. Annulation de l'envoi chez GDM.", vbCritical + vbOKOnly
    //''        rsGDM.Close
    //''        Exit Function
    //''      End If
    //''
    //''      ' mise a jour du dessus
    //''      cnx.Execute o_sql
    //''
    //''      UpdateFlag_cJoindreDevisEnvoi_TGDM nactnum, "O"
    //''
    //''      sNomFichierXML_ssExt = Left(sNomFichierXML, Len(sNomFichierXML) - 4)  ' On enlève .xml
    //''
    //''      If rsGDM("CDEVISTYPE") = "F" Then
    //''        ShellAndWait gstrRepertoireReports & "ReportEmalec.Net.exe " & """TDevisClientForfait_V2;" & rsGDM("NDCLNUM") & ";TCCL|NCCLCODE|000;" & gstrNomSociete & ";FR;PDF;DC;" & nactnum & """", vbNormalFocus
    //''      Else
    //''        ShellAndWait gstrRepertoireReports & "ReportEmalec.Net.exe " & """TDevisClientPrestationSansDetails;" & rsGDM("NDCLNUM") & ";TCCL|NCCLCODE|000;" & gstrNomSociete & ";FR;PDF;DC;" & nactnum & """", vbNormalFocus
    //''      End If
    //''
    //''      ' Mettre le PDF à disposition du programme de gestion des transferts FTP
    //''      cheminGDMFTP = RechercheParam("REP_GDM_FTP")
    //''
    //''      Nomf = "DD" & rsGDM("NDCLNUM") & "_" & nactnum & ".pdf"
    //''
    //''      sNomFichierDD_PDF = sNomFichierXML_ssExt & "_" & rsGDM("NDCLNUM") & "_" & Nomf
    //''      fs.CopyFile gstrCheminUtilisateur & "\Mozart\PDF\" & rsGDM("NDCLNUM") & ".pdf", cheminGDMFTP & "FTP\OutBox_PJ\" & sNomFichierDD_PDF, True
    //''
    //''      ' Ecrire les détails du devis dans la table TGDM_DEVIS
    //''      nGDMDEVISNUM = getNGDMDEVISNUM(rsGDM("NGDMNUM"))  ' Voir si la section devis existe déjà en SQL
    //''      If nGDMDEVISNUM = 0 Then
    //''        o_sql = "insert into TGDM_DEVIS (NGDMNUM, VNUMERO, NMONTANT, DDATEDEVIS) VALUES (" & rsGDM("NGDMNUM")
    //''        o_sql = o_sql & ", '" & rsGDM("NDCLNUM") & "', " & Replace(rsGDM("NDCLHT"), ",", ".") & ", '" & rsGDM("DDCLDAT") & "')"
    //''        cnx.Execute o_sql
    //''      Else
    //''        o_sql = "update TGDM_DEVIS SET VNUMERO = '" & rsGDM("NDCLNUM") & "', NMONTANT = " & Replace(rsGDM("NDCLHT"), ",", ".") & ", DDATEDEVIS = '" & rsGDM("DDCLDAT") & "' where NGDMDEVISNUM = " & nGDMDEVISNUM
    //''        cnx.Execute o_sql
    //''      End If
    //''
    //''      ' Récupérer à nouveau le n° unique de devis
    //''      nGDMDEVISNUM = getNGDMDEVISNUM(rsGDM("NGDMNUM"))
    //''
    //''      ' Ecrire les détails du devis dans la table TGDM_DEVIS_DOCLST
    //''      o_sql = "insert into TGDM_DEVIS_DOCLST (NGDMDEVISNUM, VNOM, DDATE, VPROVENANCE) VALUES ("
    //''      o_sql = o_sql & nGDMDEVISNUM & ", '" & Nomf & "', '" & DateValue(Now) & " " & TimeValue(Now) & "', 'EMALEC')"
    //''      cnx.Execute o_sql
    //''
    //''      ' Tracer l'envoi dans le LOG
    //''      ECRIRE_LOG_GDM rsGDM("NGDMNUM"), "DD mise à disposition du programme de transfert GDM, avec devis en PJ"
    //''
    //''      rsGDM.Close
    //''
    //''    Else
    //''     ' mise a jour du dessus
    //''      cnx.Execute o_sql
    //''
    //''      UpdateFlag_cJoindreDevisEnvoi_TGDM nactnum, "N"
    //''
    //''      ECRIRE_LOG_GDM rsGDM("NGDMNUM"), "DD mise à disposition du programme de transfert GDM, sans devis en PJ"
    //''      rsGDM.Close
    //''    End If
    //''
    //''    ' Tout s'est bien passé, on met à jour le flag d'envoi GDM
    //''    o_sql = "update TGDM SET CSTATUT = 'A', BGENERERXML = 1 where NACTNUM = " & nactnum
    //''    cnx.Execute o_sql
    //''
    //''    MsgBox "La demande de devis est en cours d'envoi chez GDM", vbInformation + vbOKOnly
    //''
    //''  End If

    //  '------------------------------------------------------------------------------------------------------------------------------------------------
    //  '------------------------------------------------------------------------------------------------------------------------------------------------
    //  If TypeGDM = "DISR" Then
    //    ' Je suis en création d'une nouvelle demande de DI
    //    ' Attention, d'après la documentation,  VACTIVITE serait facultatif
    //    ' Attention PJ (DI en PDF) obligatoire
    //    rsGDM.Close

    //    rsGDM.Open "select * from TACT INNER JOIN TSIT on TSIT.NSITNUM = TACT.NSITNUM INNER JOIN TGDM_TCLI ON TGDM_TCLI.NCLINUM = TSIT.NCLINUM INNER JOIN TDIN ON TDIN.NDINNUM = TACT.NDINNUM INNER JOIN TPER ON TPER.VPERADSI = TDIN.VDINCHAFF WHERE TACT.NACTNUM = " & nactnum & " AND TPER.VSOCIETE = '" & gstrNomSociete & "'", cnx

    //    If rsGDM.EOF Then
    //      MsgBox "Erreur de données : impossible d'envoyer la demande DISR", vbCritical + vbOKOnly
    //      rsGDM.Close
    //      Exit Function
    //    End If

    //    ' pas de devis sur une DISR (car sinon c'est une DDSR)
    //    ' et si on est en modification d'une DISR et qu'il y a un devis ?
    //    UpdateFlag_cJoindreDevisEnvoi_TGDM nactnum, "N"

    //'    If bEnvoyerDevis = True Then
    //'      UpdateFlag_cJoindreDevisEnvoi_TGDM nactnum, "O"
    //'    Else
    //'      UpdateFlag_cJoindreDevisEnvoi_TGDM nactnum, "N"
    //'    End If


    //    sDesc = Replace(rsGDM("VACTDES"), "'", "''")
    //    sDescString = RTrim(Left(sDesc, 7999))
    //    sNomFichierXML = Generate_NOMXML(rsGDM("VCODECLIENT"))

    //    If bMAJData = False Then
    //        ' Nelle DISR
    //        o_sql = "insert into TGDM (VCODECLIENT, VTYPEDEMANDE, VCODEPRESTATAIRE, VACTIVITE, VDIEMALEC, VCONTACT, VCODESITE, VNOMSITE, DDATECREATION, DDATEPLANIFIEE, VDESCRIPTION, VNOMXML, NACTNUM) VALUES ('"
    //        o_sql = o_sql & rsGDM("VCODECLIENT") & "', 'DISR', 'EMALE009', '', '" & rsGDM("NDINNUM") & "/" & nactnum & "', '" & rsGDM("VPERMAILPRO") & "', '" & rsGDM("NSITNUE") & "', '" & Replace(rsGDM("VSITNOM"), "'", "''") & "', '" & DateValue(Now) & " " & TimeValue(Now)
    //        o_sql = o_sql & "', '" & BlankIfNull(rsGDM("DACTPLA")) & "', '" & sDescString & "', '" & sNomFichierXML & "', " & nactnum & ")"
    //        cnx.Execute o_sql

    //        ' on simplifie la gestion pour le moment
    //'        ret = MsgBox("Voulez-vous ajouter des pièces jointes à l'envoi?", vbQuestion + vbYesNo)
    //'        If ret = vbYes Then
    //'          ' Gestion des pièces jointes aux nouvelles DISR :
    //'          frmGestionPJ_GDM.mstrClient = vClinom
    //'          frmGestionPJ_GDM.mstrSite = rsGDM("VSITNOM")
    //'          frmGestionPJ_GDM.mstrNumDI = rsGDM("NDINNUM")
    //'          frmGestionPJ_GDM.mlAction = nactnum
    //'          frmGestionPJ_GDM.iClientNum = rsGDM("NCLINUM")
    //'          frmGestionPJ_GDM.bPresenceDevis = bPresenceDevis
    //'          frmGestionPJ_GDM.bGestionNelleDISR_DDSR = True
    //'          frmGestionPJ_GDM.Show vbModal
    //'        End If

    //      Else
    //        ' Màj DISR existante
    //        o_sql = "update TGDM SET VNOMXML = '" & sNomFichierXML & "', VDESCRIPTION = '" & sDescString & "', DDATEPLANIFIEE = '" & BlankIfNull(rsGDM("DACTPLA")) & "', DDATECLOTUREINTERV = '" & BlankIfNull(rsGDM("DACTDEX")) & "' where NACTNUM = " & nactnum
    //        cnx.Execute o_sql
    //    End If

    //    ' On nettoie avant, car il ne doit y avoir qu'une seule DI en PDF comme pièce jointe :
    //    Nettoyer_PJ_EMALEC_BDD "DI", nactnum

    //    ' Générer la DI en PDF
    //    TdbGlobal(0, 0) = "CLIENT"
    //    TdbGlobal(0, 1) = vClinom
    //    TdbGlobal(1, 0) = "DateJ"
    //    TdbGlobal(1, 1) = Date

    //    sNomFichierXML_ssExt = Left(sNomFichierXML, Len(sNomFichierXML) - 4)  ' On enlève .xml


    //    ImprimerFichier gstrCheminModeles & "FR\" & "TDImodeleGDM.rtf", "\" & sNomFichierXML_ssExt & "_DI" & rsGDM("NDINNUM") & "A" & nactnum, TdbGlobal(), "exec api_sp_impDImodeleGDM " & nactnum
    //    ' & "_" & rsGDM("NDINNUM")

    //    ' Mettre le PDF à disposition du programme de gestion des transferts FTP
    //    cheminGDMFTP = RechercheParam("REP_GDM_FTP")
    //    Dim sNomFichierDI_PDF As String


    //    Dim Nomf2 As String ' Nom du fichier à stocker en SQL
    //    Nomf2 = "DI" & rsGDM("NDINNUM") & "A" & nactnum & ".pdf"
    //    sNomFichierDI_PDF = sNomFichierXML_ssExt & "_" & Nomf2
    //    AttenteFinImpressionPDF gstrCheminUtilisateur & "\Mozart\PDF\" & Left(sNomFichierDI_PDF, Len(sNomFichierDI_PDF) - 4)  ' On enlève .PDF
    //    fs.CopyFile gstrCheminUtilisateur & "\Mozart\PDF\" & sNomFichierDI_PDF, cheminGDMFTP & "FTP\OutBox_PJ\", True

    //    rsGDM.Close

    //    Set rsGDM = New ADODB.Recordset
    //    rsGDM.Open "select NGDMNUM from TGDM WHERE TGDM.NACTNUM = " & nactnum, cnx
    //    ' Ecrire les détails de la pièce jointe dans la table TGDM_LSTDOC
    //    o_sql = "insert into TGDM_LSTDOC (NGDMNUM, VNOM, DDATE, VPROVENANCE, DDATEENVOI, BENVOYERPJ, TYPEPJ) VALUES (" & rsGDM("NGDMNUM")
    //    o_sql = o_sql & ", '" & Nomf2 & "', '" & DateValue(Now) & " " & TimeValue(Now) & "', 'EMALEC', '" & DateValue(Now) & " " & TimeValue(Now) & "', 1, 'DI')"
    //    cnx.Execute o_sql

    //    ' Gestion des PJ ajoutées précédemment, pour l'envoi FTP
    //    PreparerEnvoiPJ sNomFichierXML, nactnum

    //    ' Tracer l'envoi dans le LOG
    //    ECRIRE_LOG_GDM rsGDM("NGDMNUM"), "DISR mise à disposition du programme de transfert GDM"

    //    rsGDM.Close

    //    ' Tout s'est bien passé, on met à jour le flag d'envoi GDM
    //    o_sql = "update TGDM SET CSTATUT = 'A', BGENERERXML = 1 where NACTNUM = " & nactnum
    //    cnx.Execute o_sql

    //    MsgBox "La nouvelle DI est en cours d'envoi chez GDM", vbInformation + vbOKOnly

    //  End If

    //'------------------------------------------------------------------------------------------------------------------------------------------------
    //'------------------------------------------------------------------------------------------------------------------------------------------------
    //'------------------------------------------------------------------------------------------------------------------------------------------------
    //  If TypeGDM = "DDSR" Then
    //    ' Je suis en création d'une nouvelle demande de DD
    //    ' Attention, d'après la documentation, VACTIVITE serait facultatif
    //    rsGDM.Close
    //    rsGDM.Open "select * from TACT INNER JOIN TSIT on TSIT.NSITNUM = TACT.NSITNUM INNER JOIN TGDM_TCLI ON TGDM_TCLI.NCLINUM = TSIT.NCLINUM INNER JOIN TDIN ON TDIN.NDINNUM = TACT.NDINNUM INNER JOIN TPER ON TPER.VPERADSI = TDIN.VDINCHAFF WHERE TACT.NACTNUM = " & nactnum & " AND TPER.VSOCIETE = '" & gstrNomSociete & "'", cnx

    //    If rsGDM.EOF Then
    //      MsgBox "Erreur de données : impossible d'envoyer la demande DDSR", vbCritical + vbOKOnly
    //      rsGDM.Close
    //      Exit Function
    //    End If

    //    sDesc = Replace(rsGDM("VACTDES"), "'", "''")
    //    sDescString = RTrim(Left(sDesc, 7999))
    //    sNomFichierXML = Generate_NOMXML(rsGDM("VCODECLIENT"))


    //    If bMAJData = False Then
    //        ' Nelle DDSR
    //        o_sql = "insert into TGDM (VCODECLIENT, VTYPEDEMANDE, VCODEPRESTATAIRE, VACTIVITE, VDIEMALEC, VCONTACT, VCODESITE, VNOMSITE, DDATECREATION, DDATEPLANIFIEE, VDESCRIPTION, VNOMXML, NACTNUM) VALUES ('"
    //        o_sql = o_sql & rsGDM("VCODECLIENT") & "', 'DDSR', 'EMALE009', '', '" & rsGDM("NDINNUM") & "/" & nactnum & "', '" & rsGDM("VPERMAILPRO") & "', '" & rsGDM("NSITNUE") & "', '" & Replace(rsGDM("VSITNOM"), "'", "''") & "', '" & DateValue(Now) & " " & TimeValue(Now)
    //        o_sql = o_sql & "', '" & BlankIfNull(rsGDM("DACTPLA")) & "', '" & sDescString & "', '" & sNomFichierXML & "', " & nactnum & ")"
    //        cnx.Execute o_sql

    //'        ret = MsgBox("Voulez-vous ajouter des pièces jointes à l'envoi?", vbQuestion + vbYesNo)
    //'        If ret = vbYes Then
    //'          ' Gestion des pièces jointes aux nouvelles DDSR :
    //'          frmGestionPJ_GDM.mstrClient = vClinom
    //'          frmGestionPJ_GDM.mstrSite = rsGDM("VSITNOM")
    //'          frmGestionPJ_GDM.mstrNumDI = rsGDM("NDINNUM")
    //'          frmGestionPJ_GDM.mlAction = nactnum
    //'          frmGestionPJ_GDM.iClientNum = rsGDM("NCLINUM")
    //'          frmGestionPJ_GDM.bPresenceDevis = bPresenceDevis
    //'          frmGestionPJ_GDM.bGestionNelleDISR_DDSR = True
    //'          frmGestionPJ_GDM.Show vbModal
    //'        End If


    //      Else
    //        ' Màj DDSR existante (interdit normalement mais pourquoi pas)
    //        o_sql = "update TGDM SET VNOMXML = '" & sNomFichierXML & "', VDESCRIPTION = '" & sDescString & "', DDATEPLANIFIEE = '" & BlankIfNull(rsGDM("DACTPLA")) & "', DDATECLOTUREINTERV = '" & BlankIfNull(rsGDM("DACTDEX")) & "' where NACTNUM = " & nactnum
    //        cnx.Execute o_sql
    //    End If


    //    If bEnvoyerDevis = True Then

    //      ' On réouvre le recordset avec jointure sur le devis client
    //      rsGDM.Close

    //      UpdateFlag_cJoindreDevisEnvoi_TGDM nactnum, "O"


    //      rsGDM.Open "select NGDMNUM, NDCLNUM, CDEVISTYPE, CTYPEMODELE, NDCLHT, DDCLDAT from TGDM INNER JOIN TACT on TACT.NACTNUM = TGDM.NACTNUM INNER JOIN TDCL ON TDCL.NACTNUM = TACT.NACTNUM WHERE TGDM.NACTNUM = " & nactnum, cnx

    //      sNomFichierXML_ssExt = Left(sNomFichierXML, Len(sNomFichierXML) - 4)  ' On enlève .xml

    //      ' génération du devis en pdf
    //      ShellAndWait gstrRepertoireReports & "ReportEmalec.Net.exe " & """" & RechercheModeleDevis(rsGDM("CTYPEMODELE")) & ";" & rsGDM("NDCLNUM") & ";TCCL|NCCLCODE|000;" & gstrNomSociete & ";FR;PDF;DC;" & nactnum & """", vbNormalFocus

    //      ' Mettre le PDF à disposition du programme de gestion des transferts FTP
    //      cheminGDMFTP = RechercheParam("REP_GDM_FTP")

    //      Dim Nomf3 As String ' Nom du fichier à stocker en SQL
    //      Nomf3 = "DD" & rsGDM("NDCLNUM") & "_" & nactnum & ".pdf"
    //      sNomFichierDD_PDF = sNomFichierXML_ssExt & "_" & rsGDM("NDCLNUM") & "_" & Nomf3
    //      fs.CopyFile gstrCheminUtilisateur & "\Mozart\PDF\" & rsGDM("NDCLNUM") & ".pdf", cheminGDMFTP & "FTP\OutBox_PJ\" & sNomFichierDD_PDF, True

    //      ' Ecrire les détails du devis dans la table TGDM_DEVIS
    //      nGDMDEVISNUM = getNGDMDEVISNUM(rsGDM("NGDMNUM"))  ' Voir si la section devis existe déjà en SQL
    //      If nGDMDEVISNUM = 0 Then
    //        o_sql = "insert into TGDM_DEVIS (NGDMNUM, VNUMERO, NMONTANT, DDATEDEVIS) VALUES (" & rsGDM("NGDMNUM")
    //        o_sql = o_sql & ", '" & rsGDM("NDCLNUM") & "', " & Replace(rsGDM("NDCLHT"), ",", ".") & ", '" & rsGDM("DDCLDAT") & "')"
    //        cnx.Execute o_sql
    //      Else
    //        o_sql = "update TGDM_DEVIS SET VNUMERO = '" & rsGDM("NDCLNUM") & "', NMONTANT = " & Replace(rsGDM("NDCLHT"), ",", ".") & ", DDATEDEVIS = '" & rsGDM("DDCLDAT") & "' where NGDMDEVISNUM = " & nGDMDEVISNUM
    //        cnx.Execute o_sql
    //      End If

    //      ' Récupérer à nouveau le n° unique de devis
    //      nGDMDEVISNUM = getNGDMDEVISNUM(rsGDM("NGDMNUM"))

    //      ' Ecrire les détails du devis dans la table TGDM_DEVIS_DOCLST
    //      o_sql = "insert into TGDM_DEVIS_DOCLST (NGDMDEVISNUM, VNOM, DDATE, VPROVENANCE) VALUES ("
    //      o_sql = o_sql & nGDMDEVISNUM & ", '" & Nomf3 & "', '" & DateValue(Now) & " " & TimeValue(Now) & "', 'EMALEC')"
    //      cnx.Execute o_sql

    //      ' Gestion des PJ ajoutées précédemment, pour l'envoi FTP
    //      PreparerEnvoiPJ sNomFichierXML, nactnum

    //      ' Tracer l'envoi dans le LOG
    //      ECRIRE_LOG_GDM rsGDM("NGDMNUM"), "DDSR mise à disposition du programme de transfert GDM avec devis en PJ"

    //    Else
    //      UpdateFlag_cJoindreDevisEnvoi_TGDM nactnum, "N"

    //      ' Tracer l'envoi dans le LOG
    //      ECRIRE_LOG_GDM getNGDMNUM(rsGDM("NACTNUM")), "DDSR mise à disposition du programme de transfert GDM sans devis en PJ"

    //    End If


    //    rsGDM.Close

    //    ' Tout s'est bien passé, on met à jour le flag d'envoi GDM
    //    o_sql = "update TGDM SET CSTATUT = 'A', BGENERERXML = 1 where NACTNUM = " & nactnum
    //    cnx.Execute o_sql

    //    MsgBox "La nouvelle demande de devis est en cours d'envoi chez GDM", vbInformation + vbOKOnly
    //  End If

    //  ' ----------------------------------------------------------------------------------------------------
    //  ' Envoi proprement dit :
    //  ' Modif NL, le 17/05/2017 : on désynchronise l'envoi et on le programme par le planificateur de tâches du serveur srv-vmapps
    //  ' Shell RechercheParam("REP_GDM_FTP") & "GDM.exe UPLOAD " & gstrNomServeur, vbNormalFocus
    //  ' ----------------------------------------------------------------------------------------------------

    //  ' Mise à jour du champ observation de l'action
    //  Dim sSqlFinal As String
    //  Dim sObs As String
    //  sObs = gstrUID & " le " & Format(Now, "dd/MM/YY HH:MM") & " : Envoi des données chez GDM."
    //  sSqlFinal = "update TACT set VACTOBS = '" & sObs & "' + Char(13) + Char(10) + coalesce(VACTOBS,'') where nactnum = " & nactnum
    //  cnx.Execute sSqlFinal

    //  frmDetailstravaux.txtObserv.Text = sObs + Chr(13) + Chr(10) + frmDetailstravaux.txtObserv.Text


    //  Screen.MousePointer = vbDefault


    //Exit Function
    //Resume
    //handler:
    //  Screen.MousePointer = vbDefault
    //  ShowError "PrepaEnvoiGDM2"


    //End Function

    // depuis modGDM
    public static void Nettoyer_PJ_EMALEC_BDD(string typePJ, int nactnum)
    {
      // On efface en BDD les PJ liées au n° GDM en cours qui ont :
      //  + VPROVENANCE = 'EMALEC'
      //  + Le type de PJ (typePJ) défini en paramètre (DI)
      //  + BENVOYERPJ à 1 (donc pas encore envoyées)
      //  + ne sont pas en cours d'ajout(DDATEENVOI non NULL)
      //  + TIMAC_NIMAGE est NULL (donc ne provient pas de TIMAC, à la base)
      ModuleData.ExecuteNonQuery($"delete from TGDM_LSTDOC where VPROVENANCE = 'EMALEC' and TYPEPJ = '{typePJ}' and BENVOYERPJ = 1 " +
                                 $"and TIMAC_NIMAGE is null and DDATEENVOI is not null and NGDMNUM = {getNGDMNUM(nactnum)}");
    }

    // depuis modGDM
    public static int getNGDMNUM(int nACTION)
    {
      int? NGDMNUM = ModuleData.ExecuteScalarInt($"select NGDMNUM from TGDM where NACTNUM = {nACTION}");
      return (int)Utils.ZeroIfNull(NGDMNUM);
    }


    // depuis modGDM
    public static void ECRIRE_LOG_GDM(int NGDMNUM, string QUOI)
    {
      ModuleData.ExecuteNonQuery($"insert into TGDM_LOG (NGDMNUM, DGDMLOGDATE, VGDMLOGQUI, VGDMLOGQUOI) VALUES ({NGDMNUM}, '{DateTime.Now.ToShortDateString()} {DateTime.Now.ToShortTimeString()}', '{MozartParams.strUID}', '{QUOI.Replace("'", "''")}')");
    }

    // depuis modGDM
    public static int getNGDMDEVISNUM(int NGDMNUM)
    {
      using (SqlDataReader reader = ModuleData.ExecuteReader($"select top 1 NGDMDEVISNUM from TGDM_devis where ngdmnum = {NGDMNUM} order by NGDMDEVISNUM desc"))
      {
        if (reader.Read())
        {
          return (int)Utils.ZeroIfNull(reader["NGDMDEVISNUM"]);
        }
      }
      return 0;
    }


    // depuis modGDM
    public static void UpdateFlag_cJoindreDevisEnvoi_TGDM(int nactnum, string val)
    {
      ModuleData.ExecuteNonQuery($"UPDATE TGDM SET cJoindreDevisEnvoi = '{val}' WHERE NACTNUM = {nactnum}");
    }

    public static string RechercheModeleDevis(string sDevisType, string sTypeModele)
    {
      string sNomReport;

      switch (sDevisType)
      {
        // devis classique
        case "F":
          switch (sTypeModele)
          {
            case "F":
              sNomReport = "TDevisClientForfait_V2";
              break;
            case "D":
              sNomReport = "TDevisClientDetail_V2";
              break;
            case "M":
              sNomReport = "TDevisClientDetailMODEP_V2";
              break;
            case "A":
              sNomReport = "TDevisClientDetailFournitures_V2";
              break;
            case "P":
              sNomReport = "TDevisClientDetailFournituresPrix_V2";
              break;
            case "H":
              sNomReport = "TDevisClientDetailMODEPFournituresPrix_V2";
              break;
            default:
              sNomReport = "TDevisClientDetail_V2";
              break;
          }
          break;

        // devis prestation
        case "P":
          sNomReport = "TDevisClientPrestationSansDetails";
          break;

        // Nouveaux devis
        case "B":
        case "G":
          sNomReport = "DEVIS_V2";
          break;

        default:
          sNomReport = "";
          break;
      }

      return sNomReport;
    }

    // depuis modGDM
    public static bool DevisExiste(int nactnum)
    {
      using (SqlDataReader reader = ModuleData.ExecuteReader($"select NDCLNUM FROM TDCL WHERE NACTNUM = {nactnum}"))
        return reader.Read();
    }

    
     // depuis modGDM
    public static void PreparerEnvoiPJ(string sNomFichierXML, int nactnum)
    {
      // Cette fonction vient placer la pièce jointe dans le bon dossier, avec le bon nom, pour envoi par FTP par programme externe
      // TGDM_LSTDOC.BENVOYERPJ doit être à 1 pour envoyer la pièce jointe
      using (SqlDataReader reader = ModuleData.ExecuteReader($"select * from TGDM_LSTDOC inner join TGDM on TGDM.NGDMNUM = TGDM_LSTDOC.NGDMNUM " +
                                                             $"where BENVOYERPJ = 1 and VFICHIER_SOURCE is not null and NACTNUM = {nactnum}"))
      {
        if (!reader.Read())
        {
          // Pas de PJ
          return;
        }

        //  chemin de dépose des fichiers sur le FTP Emalec
        string cheminGDMFTP = Utils.RechercheParam("REP_GDM_FTP");

        do
        {
          // On dépose les fichiers pour le FTP
          string sNomFichierDest = Path.GetFileNameWithoutExtension(sNomFichierXML) + "_" + Utils.BlankIfNull(reader["VNOM"]);
          Thread.Sleep(500);
          File.Copy(Utils.BlankIfNull(reader["VFICHIER_SOURCE"]), $@"{cheminGDMFTP}FTP\OutBox_PJ\{sNomFichierDest}", true);
        } while (reader.Read());
      }
    }

    // depuis modGDM
    public static void JoindrePJ_GDM(string sNomFichierXML, int nactnum)
    {

      string cheminPhoto = Utils.RechercheParam("REP_ATTGAM");
      string cheminAttach = Utils.RechercheParam("REP_PHOTOS_ACT");

      // recherche de l'attachement (de type ATTACH ou IMAGE)
      //string sSQL = $"SELECT NIMAGE, CFORMAT, VFICHIER, case VTYPE when 'ATTACH' then '\\\\srv-vmweb02\\AttGamPdf' + APP_NAME() + '\\' " +
      //  $"    when 'IMAGE'	then '\\\\srv-vmweb02\\PhotosAct' + APP_NAME() + '\\'" +
      //  $"    else '\\\\srv-vmweb02\\PhotosAct' + APP_NAME() + '\\' end as CHEMIN  " +
      //  $"FROM TIMAC WHERE NACTNUM = {nactnum} AND VTYPEDEST = 'C' AND NTYPEDOC = 1";

      string sSQL = $"SELECT NIMAGE, CFORMAT, VFICHIER, case VTYPE when 'ATTACH' then '{cheminPhoto}' " +
                    $" when 'IMAGE'	then '{cheminAttach}' else '{cheminAttach}' end as CHEMIN  " +
                    $"FROM TIMAC WHERE NACTNUM = {nactnum} AND VTYPEDEST = 'C' AND NTYPEDOC = 1";

      using (SqlDataReader reader = ModuleData.ExecuteReader(sSQL))
      {
        if (reader.Read())
        {
          do
          {
            // On insère une ligne dans la table des fichiers à envoyer
            string o_sql = $"insert into TGDM_LSTDOC (NGDMNUM, VNOM, DDATE, DDATEENVOI, VPROVENANCE, TIMAC_NIMAGE, " +
                          $"VFICHIER_SOURCE, BENVOYERPJ, TYPEPJ) VALUES ({getNGDMNUM(nactnum)}, 'PJ{reader["NIMAGE"]}.{reader["CFORMAT"]}', " +
                          $"GetDate(), GetDate(), 'EMALEC', {reader["NIMAGE"]}, '{reader["CHEMIN"]}{reader["VFICHIER"]}', 1, 'PJ')";

            ModuleData.ExecuteNonQuery(o_sql);
          } while (reader.Read());

        }
        else
        {
          MessageBox.Show("Il n'y a pas d'attachement", Program.AppTitle, MessageBoxButtons.OK, MessageBoxIcon.Information);
        }
      }
    }

    // depuis modGDM
    private static string Generate_NOMXML(string sVCODECLIENT)
    {
      // A utiliser uniquement pour la table TGDM (champ VNOMXML)
      int ran = 1 + (int)(new Random().NextDouble() * 9999);
      string sRan = ran.ToString();
      sRan.PadLeft(4, '0');

      DateTime jour = DateTime.Now;

      return $"{sVCODECLIENT}_EMALE009_{jour.ToString("yyyy")}{jour.ToString("MM")}{jour.ToString("dd")}-{jour.ToString("HH")}{jour.ToString("mm")}{jour.ToString("ss")}-{sRan}.xml";
    }

    //'******************************************************************************************************************************************************
    //'Cette fonction retourne si l intervenant possède une tablet pc
    //'******************************************************************************************************************************************************
    // depuis modGDM.bas
    public static bool IntervantWithTabletSTF(string NINTNUM)
    {
      if (NINTNUM != "")
      {
        using (SqlDataReader reader = ModuleData.ExecuteReader($"EXEC api_sp_IntervenantAvecTabletSTF {NINTNUM}"))
          return reader.Read();
      }
      return false;
    }

    //'******************************************************************************************************************************************************
    //'Cette fonction retourne si l intervenant possède une tablet pc
    //'******************************************************************************************************************************************************
    // depuis modMain.bas
    public static bool ExistsContratOnIntervenant(string NINTNUM, int NACTNUM)
    {
      if (NINTNUM != "")
      {
        using (SqlDataReader reader = ModuleData.ExecuteReader($"EXEC api_sp_ExistContratSTFOnIntervenant {NINTNUM}, {NACTNUM}"))
          return reader.Read();
      }
      return false;
    }

    public static void AffichageMessageJO2024(int numSite)
    {

      return;

      //int JO = (int)ModuleData.ExecuteScalarInt($"SELECT ISNULL(NSITNBCOUVERT,0) FROM TSIT WHERE NSITNUM = {numSite}");
      //if (JO == 1)
      //{
      //  string Message = $"Ce site est situé dans une des zones impactées par les jeux olympiques 2024.\r\n" +
      //    $"Merci de bien respecter les consignes en vigueur.";

      //  MessageBox.Show(Message, Program.AppTitle, MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
      
      //}
    }
  }
}
