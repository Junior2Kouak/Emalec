using Microsoft.Win32;
using MozartCS.Properties;
using MozartLib;
using MozartNet;
using System;
using System.Data.SqlClient;
using System.Diagnostics;
using System.Globalization;
using System.IO;
using System.Reflection;
using System.Windows.Forms;
using MZUtils = MozartControls.Utils;

namespace MozartCS
{
  class MozartCsUtils
  {
    public static void InitVariablesMozart()
    {
      // appel MozartCS avec SERVEUR;SOCIETE
      string[] args = Environment.GetCommandLineArgs();

      // valeurs par défaut
      MozartParams.NomServeur = "SRV-VMSQLPROD";
      MozartParams.NomSociete = "EMALEC";

      // appel MozartCS avec SERVEUR;SOCIETE
      if (2 == args.Length)
      {
        string[] compos = args[1].Split(';');

        if (2 <= compos.Length)
        {
          MozartParams.NomServeur = compos[0].ToUpper();
          MozartParams.NomSociete = compos[1].ToUpper();
        }
        else
        {
          Console.WriteLine("Erreur d'appel de l'application: arguments incorrects");
        }
      }
    }

    public static void InitMozartApp()
    {
      ModuleMain.ConnexionBase();

      MozartParams.NomGroupe = ModuleMain.InitNomGroupe();

      if (null != MozartParams.Langue && "FR" != MozartParams.Langue.ToUpper())
      {
        //ApplicationBase.ChangeUICulture(ModuleMain.sLanguageAppli);
        //https://docs.microsoft.com/fr-fr/dotnet/api/system.globalization.cultureinfo.currentculture?view=netframework-4.6
        CultureInfo.CurrentUICulture = new CultureInfo(MozartParams.Langue, false);
      }
    }

    public static void VerifieVersion()
    {
      string cheminSource = Path.Combine(MozartParams.CheminMozart, "MozartCS.exe");
      if (!File.Exists(cheminSource))
      {
        Console.WriteLine($"Fichier inexistant:{cheminSource}");
        return;
      }
      string vServeur = FileVersionInfo.GetVersionInfo(cheminSource).ProductVersion;

      string[] args = Environment.GetCommandLineArgs();
      string vLocale = FileVersionInfo.GetVersionInfo(args[0]).ProductVersion;

      if (vServeur != vLocale)
      {
        //msg_version_mozart_pas_a_jour
        //msg_version_mozart_vserveur
        //msg_version_mozart_vclient
        //msg_version_mozart_service       
        //MessageBox.Show($"§La version de MOZART que vous utilisez n'est pas à jour !§\r\n\r\n§Version serveur§ : {vServeur}\r\n§Version local§ : {vLocale}\r\n\r\n§Veuillez contacter le service informatique§");
        MessageBox.Show($"{Resources.msg_version_mozart_pas_a_jour}{Environment.NewLine}{Environment.NewLine}{Resources.msg_version_mozart_vserveur} : {vServeur}" +
                        $"{Environment.NewLine}{Resources.msg_version_mozart_vclient} : {vLocale}{Environment.NewLine}{Environment.NewLine}{Resources.msg_version_mozart_service}");

      }
    }

    // 
    /// <summary>
    /// compte le nombre de processus MozartCS pour l'utilisateur courant
    /// </summary>
    /// <returns></returns>
    public static int NbProcessForCurrentUser()
    {
      int sessionId = Process.GetCurrentProcess().SessionId;
      int nb = 0;

      Process[] mozartcs = Process.GetProcessesByName("MozartCS");
      foreach (Process p in mozartcs)
      {
        if (p.SessionId == sessionId)
          nb++;
      }

      return nb;
    }

    public static void SetDefaultWebBrowser()
    {
      string AppName = Assembly.GetExecutingAssembly().GetName().Name;
      Int32 VersionCode = 12001;

      string Root = @"HKEY_CURRENT_USER\";
      string Key = @"Software\Microsoft\Internet Explorer\Main\FeatureControl\FEATURE_BROWSER_EMULATION";
      string CurrentSetting = Convert.ToString(Microsoft.Win32.Registry.CurrentUser.OpenSubKey(Key).GetValue(AppName + ".exe"));
      if (CurrentSetting == "" || Convert.ToInt32(CurrentSetting) != 11001)  //|| Convert.ToInt32(CurrentSetting) = !"10001"
      {
        Microsoft.Win32.Registry.SetValue(Root + Key, AppName + ".exe", VersionCode);
        Microsoft.Win32.Registry.SetValue(Root + Key, AppName + ".vshost.exe", VersionCode);
      }
    }

    public static bool ConnexionIntegree(string appParams)
    {
      try
      {
        string[] par = appParams.Split(';');
        switch (par.Length - 1)
        {
          // cas général, ouverture sur les menus
          case 1: MozartParams.CodePageDemarrage = "MENU"; break;

          // ouverture sur la liste de délégation de commande
          case 2:
            switch (par[2])
            {
              case "ALERTE":
                MozartParams.CodePageDemarrage = "DELEGATION";

                break;
              case "ALERTEDELEGATION":
                MozartParams.CodePageDemarrage = "DELEGATIONDEVIS";
                break;

              default:
                // Cas d'appel non-reconnu
                MessageBox.Show("Erreur d'appel de Mozart : Cas non-reconnu...", "ERREUR APPEL DIRECT", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                Application.Exit();
                return false;
            }
            break;

          case 3:
            MozartParams.CodePageDemarrage = par[3];
            if (MozartParams.CodePageDemarrage == "ADD_DOC")
              MozartParams.NumAction = Convert.ToInt32(par[2]);
            else
            {
              MozartParams.CodePageDemarrage = "DI";
              MozartParams.NumDi = Convert.ToInt32(par[2]);
              MozartParams.NumAction = Convert.ToInt32(par[3]);
            }
            break;

          case 4:
            MozartParams.CodePageDemarrage = par[4];// 30/08/16 : Nouveau pour appel depuis Ravel des gestion de site STF : frmDetailsSiteSTF
            if (MozartParams.CodePageDemarrage == "frmDetailsSiteSTF")
            {
              MozartParams.NumSTFGRP = Convert.ToInt32(par[2]);
              MozartParams.NumSTF = Convert.ToInt32(par[3]);
            }
            else
            {
              // Cas d'appel non-reconnu
              MessageBox.Show("Erreur d'appel de Mozart : Cas non-reconnu...", "ERREUR APPEL DIRECT", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
              Application.Exit();
              return false;
            }
            break;

          case 5:// ouverture sur le détail d'une commande ou d'un devis
            MozartParams.CodePageDemarrage = par[4];
            MozartParams.NumDi = Convert.ToInt32(par[2]);
            MozartParams.NumAction = Convert.ToInt32(par[3]);
            MozartParams.NumCom = Convert.ToInt32(par[5]);
            break;

          default:// !
                  // Cas d'appel non-reconnu
            MessageBox.Show("Erreur d'appel de Mozart : Cas non-reconnu...", "ERREUR APPEL DIRECT", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
            Application.Exit();
            return false;

        }

        // récupération du numéro de client de la société dans la table TSOCIETE
        using (SqlDataReader reader = ModuleData.ExecuteReader($"select NCLINUM FROM TSOCIETE WHERE VSOCIETENOM='{MozartParams.NomSociete}'"))
        {
          if (reader.Read())
            MozartParams.SOCIETE = (int)Utils.ZeroIfNull(reader[0]);
        }

        // création du répertoire MOZART dans Mes documents et du repertoire PDF dans Mozart
        // Vérifier l'existance d'un dossier
        if (Directory.Exists(MozartParams.CheminUtilisateurMozart))
        {
          // on verifie si l assembleur pdf est present
          if (!Directory.Exists(MozartParams.CheminUtilisateurMozart + @"PDF"))
            Directory.CreateDirectory(MozartParams.CheminUtilisateurMozart + @"PDF");
          if (File.Exists(MozartParams.CheminMozart + @"\PdfAsm.exe") && !File.Exists(MozartParams.CheminUtilisateurMozart + @"PDF\PdfAsm.exe"))
            File.Copy(MozartParams.CheminMozart + @"\PdfAsm.exe", MozartParams.CheminUtilisateurMozart + @"PDF\PdfAsm.exe");

          if (File.Exists(MozartParams.CheminMozart + @"\libiconv2.dll") && !File.Exists(MozartParams.CheminUtilisateurMozart + @"PDF\libiconv2.dll"))
            File.Copy(MozartParams.CheminMozart + @"\libiconv2.dll", MozartParams.CheminUtilisateurMozart + @"PDF\libiconv2.dll");

          if (File.Exists(MozartParams.CheminMozart + @"\pdftk.exe") && !File.Exists(MozartParams.CheminUtilisateurMozart + @"PDF\pdftk.exe"))
            File.Copy(MozartParams.CheminMozart + @"\pdftk.exe", MozartParams.CheminUtilisateurMozart + @"PDF\pdftk.exe");
        }
        else
        {
          Directory.CreateDirectory(MozartParams.CheminUtilisateurMozart + @"PDF");// Creates all the directories in a specified path.
          File.Copy(MozartParams.CheminMozart + @"\PdfAsm.exe", MozartParams.CheminUtilisateurMozart + @"PDF\PdfAsm.exe");
          File.Copy(MozartParams.CheminMozart + @"\libiconv2.dll", MozartParams.CheminUtilisateurMozart + @"PDF\libiconv2.dll");
          File.Copy(MozartParams.CheminMozart + @"\pdftk.exe", MozartParams.CheminUtilisateurMozart + @"PDF\pdftk.exe");
        }

        // Gestion du paramétrage de PDF creator
        RegistryKey clePDF = Registry.CurrentUser.CreateSubKey(@"Software\PDFcreator\program");
        clePDF.SetValue("AutosaveDirectory", MozartParams.CheminUtilisateurMozart + @"PDF\");
        clePDF.SetValue("AutosaveFilename", "<Title>");
        clePDF.SetValue("UseAutosave", "1");
        clePDF.SetValue("UseAutosaveDirectory", "1");

        // parametre du pdf creator 2.x ou plus
        RegistryKey clePDF2 = Registry.CurrentUser.CreateSubKey(@"Software\PDFcreator.net\Settings\ApplicationSettings");
        clePDF2.SetValue("UpdateInterval", "Never");
        clePDF2 = Registry.CurrentUser.CreateSubKey(@"Software\PDFcreator.net\Settings\ConversionProfiles\0");
        clePDF2.SetValue("OpenViewer", "False");
        clePDF2.SetValue("ShowProgress", "False");
        clePDF2 = Registry.CurrentUser.CreateSubKey(@"Software\PDFcreator.net\Settings\ConversionProfiles\0\AutoSave");
        clePDF2.SetValue("Enabled", "True");
        clePDF2.SetValue("EnsureUniqueFilenames", "False");
        clePDF2.SetValue("TargetDirectory", MozartParams.CheminUtilisateurMozart.Replace(@"\", @"\\") + @"PDF\");

        using (SqlDataReader reader = ModuleData.ExecuteReader("api_sp_DroitsVisu 9999"))
        {
          if (reader.Read() && (int)reader["AsDroit"] > 0) MozartParams.Droit = "OUI";
          else MozartParams.Droit = "NON";
        }

        string tva = ModuleData.ExecuteScalarString("api_sp_getPAR TVA1");
        MozartParams.TVA1 = Utils.ZeroIfBlank(tva);
        tva = ModuleData.ExecuteScalarString("api_sp_getPAR TVA2");
        MozartParams.TVA2 = Utils.ZeroIfBlank(tva);
        // si problème...
        if (MozartParams.TVA1 == 0) MozartParams.TVA1 = 20;

        // Récupérer la langue Mozart dans TPER (VLANGUESYS) et autres paramètres
        using (SqlDataReader readerL = ModuleData.ExecuteReader($"SELECT VLANGUESYS, CPERTYP, NPERSTD, isnull(VPERMAILPRO,'') FROM TPER WHERE NPERNUM = {MozartParams.UID}"))
        {
          if (readerL.Read())
          {
            MozartParams.TypePer = Utils.BlankIfNull(readerL["CPERTYP"]);
            MozartParams.UserTelInt = Utils.BlankIfNull(readerL["NPERSTD"]);
          }
        }

        return true;
      }
      catch (Exception ex)
      {
        MZUtils.displayError(MethodBase.GetCurrentMethod().Name, ex);
      }
      return false;
    }
  }
}
