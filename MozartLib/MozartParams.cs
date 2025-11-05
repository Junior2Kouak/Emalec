using DevExpress.XtraPrinting.Drawing;
using MozartLib.Properties;
using System;
using System.Data.SqlClient;
using System.IO;
using System.Text.RegularExpressions;

namespace MozartLib
{
	/// <summary>
	/// Parametres de l'application Mozart (variables globales)
	/// </summary>
	public static class MozartParams
	{
    public static CUserConnecte UserConnecte;

		public const string userNameApiMozaris = "userApiMozaris";
		public const string pwdApiMozaris = "JBuegr*hFB-n6g*54er";
		public const string urlApiMozaris = "api.mozaris.emalec.com"; //api.mozaris.emalec.com

    /// <summary>
    /// Nom de la société
    /// </summary>
    private static string _NomSociete = "";
		public static string NomSociete
		{
			get { return _NomSociete; }
			set { _NomSociete = value; }
		}

		public static string GetNomSociete()
		{
			switch (MozartParams.NomSociete)
			{
				case "EMALECIDF":
					return "EMALEC IDF";
				case "EMALECBELGIQUE":
					return "EMALEC BELGIUM";
				case "EMALECLUXEMBOURG":
					return "EMALEC LUXEMBOURG";
				case "EMALECFACILITEAM":
					return "EMALEC FACILITEAM";
				case "EQUIPAGE":
					return "EMALEC BRETAGNE";
				case "EMALECESPAGNE":
					return "EMALEC IBERICA";
				case "EMALECMPM":
					return "MPM";
				case "SAMSICROMANIA":
					return "SAMSIC ROMANIA";
				case "EMALECDEV":
					return "EMALEC Développement";
				case "SAMSICITALIA":
					return "SAMSIC Italia";
				default:
					return MozartParams.NomSociete;
			}
		}

		/// <summary>
		/// TVA 20
		/// </summary>
		private static double _TVA1;
		public static double TVA1
		{
			get { return _TVA1; }
			set { _TVA1 = value; }
		}

		/// <summary>
		/// TVA 10
		/// </summary>
		private static double _TVA2;
		public static double TVA2
		{
			get { return _TVA2; }
			set { _TVA2 = value; }
		}

		/// <summary>
		/// gestion des infos tablet (technicien)
		/// </summary>
		private static int _NumActTablet;
		public static int NumActTablet
		{
			get { return _NumActTablet; }
			set { _NumActTablet = value; }
		}

		/// <summary>
		/// gestion des infos tablet (technicien)
		/// </summary>
		private static int _NumCSTTablet;
		public static int NumCSTTablet
		{
			get { return _NumCSTTablet; }
			set { _NumCSTTablet = value; }
		}

		/// <summary>
		/// gestion de la decision web (internet)
		/// </summary>
		private static int _NumDeciWeb;
		public static int NumDeciWeb
		{
			get { return _NumDeciWeb; }
			set { _NumDeciWeb = value; }
		}

		/// <summary>
		/// numero de la DI
		/// </summary>
		private static int _NumDi;
		public static int NumDi
		{
			get { return _NumDi; }
			set { _NumDi = value; }
		}

		/// <summary>
		/// gestion de la decision web (internet)
		/// </summary>
		private static int _NumMsgSTWeb;
		public static int NumMsgSTWeb
		{
			get { return _NumMsgSTWeb; }
			set { _NumMsgSTWeb = value; }
		}

		/// <summary>
		/// Numero de client de la societe dans tcli
		/// </summary>
		private static int _SOCIETE;
		public static int SOCIETE
		{
			get { return _SOCIETE; }
			set { _SOCIETE = value; }
		}

		/// <summary>
		/// UID
		/// </summary>
		private static int _UID;
		public static int UID
		{
			get { return _UID; }
			set { _UID = value; }
		}

		/// <summary>
		/// numero de l'action
		/// </summary>
		private static int _NumAction;
		public static int NumAction
		{
			get { return _NumAction; }
			set { _NumAction = value; }
		}

		/// <summary>
		/// numero de commande ou contrat
		/// </summary>
		private static int _NumCom;
		public static int NumCom
		{
			get { return _NumCom; }
			set { _NumCom = value; }
		}

		private static int _NumSTF;
		public static int NumSTF
		{
			get { return _NumSTF; }
			set { _NumSTF = value; }
		}

		private static int _NumSTFGRP;
		public static int NumSTFGRP
		{
			get { return _NumSTFGRP; }
			set { _NumSTFGRP = value; }
		}

		public static int CurrentProcessId
		{
			get { return System.Diagnostics.Process.GetCurrentProcess().Id; }
		}

		/// <summary>
		/// pour la navigation dans les aperçu des plannings prèv
		/// </summary>
		private static string _CodeRetour = "";
		public static string CodeRetour
		{
			get { return _CodeRetour; }
			set { _CodeRetour = value; }
		}

		/// <summary>
		/// texte de description de la demande sur internet
		/// </summary>
		private static string _Action = "";
		public static string Action
		{
			get { return _Action; }
			set { _Action = value; }
		}

		private static string _CheminDeFer = "";
		public static string CheminDeFer
		{
			get { return _CheminDeFer; }
			set { _CheminDeFer = value; }
		}

		/// <summary>
		/// chemin du repertoire pour les documetns adminsitratifs Sous traitant
		/// </summary>
		private static string _CheminDocAdminSTF = "";
		public static string CheminDocAdminSTF
		{
			get { return _CheminDocAdminSTF; }
			set { _CheminDocAdminSTF = value; }
		}

		/// <summary>
		/// chemin du repertoire pour les documents techniciens
		/// </summary>
		private static string _CheminDocTechnicien = "";
		public static string CheminDocTechnicien
		{
			get { return _CheminDocTechnicien; }
			set { _CheminDocTechnicien = value; }
		}

		/// <summary>
		/// chemin du répertoire des fiches techniques
		/// </summary>
		private static string _CheminFicheTech = "";
		public static string CheminFicheTech
		{
			get { return _CheminFicheTech; }
			set { _CheminFicheTech = value; }
		}

		/// <summary>
		/// chemin du répertoire des modeles de documents utilisés
		/// </summary>
		private static string _CheminModeles = "";
		public static string CheminModeles
		{
			get { return _CheminModeles; }
			set { _CheminModeles = value; }
		}

		/// <summary>
		/// chemin du répertoire des modeles de documents utilisés (?)
		/// </summary>
		private static string _CheminMozart = "";
		public static string CheminMozart
		{
			get { return _CheminMozart; }
			set { _CheminMozart = value; }
		}

		/// <summary>
		/// chemin du repertoire Program Files
		/// C:\Program Files (x86)
		/// </summary>
		public static string CheminProgramme
		{
			get { return Environment.GetFolderPath(Environment.SpecialFolder.ProgramFilesX86); }
		}

		/// <summary>
		/// chemin du repertoire \Program Files (x86)\MOZART\
		/// C:\Program Files (x86)\MOZART\
		/// </summary>
		public static string CheminProgrammeMozart
		{
			get { return $"{Environment.GetFolderPath(Environment.SpecialFolder.ProgramFilesX86)}\\Mozart\\"; }
		}

		/// <summary>
		/// chemin du répertoire utilisateur Mes documents
		/// </summary>
		public static string CheminUtilisateur
		{
			get { return Environment.GetFolderPath(Environment.SpecialFolder.MyDocuments); }
		}

		/// <summary>
		/// chemin du répertoire utilisateur Mes documents\Mozart
		/// </summary>
		public static string CheminUtilisateurMozart
		{
			get
			{
				string lRepUtilMozart = $"{Environment.GetFolderPath(Environment.SpecialFolder.MyDocuments)}\\Mozart\\";
				if (!Directory.Exists(lRepUtilMozart))
				{
					Directory.CreateDirectory(lRepUtilMozart);
				}

				return lRepUtilMozart;
			}
		}

		/// <summary>
		/// Ouverture d'une page automatique au démarrage
		/// </summary>
		private static string _CodePageDemarrage = "";
		public static string CodePageDemarrage
		{
			get { return _CodePageDemarrage; }
			set { _CodePageDemarrage = value; }
		}

		/// <summary>
		/// date souhaité par le client (internet)
		/// </summary>
		private static string _DateAction = "";
		public static string DateAction
		{
			get { return _DateAction; }
			set { _DateAction = value; }
		}

		/// <summary>
		/// droit sur certains menu
		/// </summary>
		private static string _Droit = "";
		public static string Droit
		{
			get { return _Droit; }
			set { _Droit = value; }
		}

		/// <summary>
		/// Langue de l'utilisateur connecté
		/// </summary>
		private static string _Langue = "";
		public static string Langue
		{
			get { return _Langue; }
			set { _Langue = value; }
		}

		/// <summary>
		/// Nom du groupe
		/// </summary>
		private static string _NomGroupe = "";
		public static string NomGroupe
		{
			get { return _NomGroupe; }
			set { _NomGroupe = value; }
		}

		/// <summary>
		/// Serveur de la base de données
		/// </summary>
		private static string _NomServeur = "";
		public static string NomServeur
		{
			get { return _NomServeur; }
			set { _NomServeur = value; }
		}

		/// <summary>
		/// Nom de la société sélectionné dans le contrôle utilisateur api_societeauto
		/// </summary>
		private static string _NomSocieteTemp = "";
		public static string NomSocieteTemp
		{
			get { return _NomSocieteTemp; }
			set { _NomSocieteTemp = value; }
		}

		/// <summary>
		/// imprimante par default de windows
		/// </summary>
		private static string _Printer = "";
		public static string Printer
		{
			get { return _Printer; }
			set { _Printer = value; }
		}

		/// <summary>
		/// OUI si role facturation de la personne
		/// </summary>
		private static string _RoleFacturation = "";
		public static string RoleFacturation
		{
			get { return _RoleFacturation; }
			set { _RoleFacturation = value; }
		}

		/// <summary>
		/// type du personnel (assistante, chaff,...)
		/// </summary>
		private static string _TypePer = "";
		public static string TypePer
		{
			get { return _TypePer; }
			set { _TypePer = value; }
		}

		/// <summary>
		/// c'est le VPERADSI
		/// </summary>
		private static string _strUID = "";
		public static string strUID
		{
			get { return _strUID; }
			set { _strUID = value; }
		}

		/// <summary>
		/// Mail interne du USER
		/// </summary>
		private static string _UserMail = "";
		public static string UserMail
		{
			get { return _UserMail; }
			set { _UserMail = value; }
		}

		/// <summary>
		/// N° tel interne
		/// </summary>
		private static string _UserTelInt = "";
		public static string UserTelInt
		{
			get { return _UserTelInt; }
			set { _UserTelInt = value; }
		}

		/// <summary>
		/// Pour debug
		/// </summary>
		public static void Dump()
		{
			try
			{
				Console.WriteLine("*** Dump MozartParams: ***\n");
				foreach (System.Reflection.PropertyInfo prop in typeof(MozartParams).GetProperties())
				{
					Console.WriteLine($"{prop.Name} : {prop.GetValue(typeof(MozartParams), null)}");
				}
			}
			catch (Exception ex1)
			{
				Console.WriteLine($"{ex1}");
			}
		}

		public static string SupprimerCaracteresSpeciaux(string input)
		{
			// Remplace tout ce qui n'est pas une lettre ou un chiffre par une chaîne vide
			return Regex.Replace(input, "[^a-zA-Z0-9]", "");
		}

		public static string RechercheParam(string sParamTemp, string sNomSociete)
		{
			return RechercheParam(sParamTemp, sNomSociete, MozartDatabase.cnxMozart);
		}

		public static string RechercheParam(string sParamTemp, string sNomSociete, SqlConnection pCnx)
		{
			return MozartDatabase.ExecuteScalarString($"api_sp_getPAR_By_Societe '{sParamTemp}', '{sNomSociete}'", pCnx);
		}

		// 02/04/2025 - FGB : Utilisé pour report Fiche Formation : Pourquoi on ne pointe pas sur GetLogoFromSociete directement ? Je ne sais pas ... à voir
		public static ImageSource GetLogoEMALEC()
		{
			return new ImageSource(Resources.Logo_EMALEC_02, true);
		}

		public static ImageSource GetLogoFromSociete(string pSociete)
		{
			ImageSource lRetValue;

			switch (pSociete.ToUpper())
			{
				case "EMALEC":
				case "EMALECIDF":
				case "SCS":
				case "MAGESTIME":
					lRetValue = new ImageSource(Resources.Logo_EMALEC_Icon, true);
					break;

				case "EMALECMPM":
					lRetValue = new ImageSource(Resources.logo_mpm_final, true);
					break;

				case "EMALECLUXEMBOURG":
					lRetValue = new ImageSource(Resources.LuxLogo, true);
					break;

				case "EQUIPAGE":
					lRetValue = new ImageSource(Resources.LogoOCEATEC, true);
					break;

				default:
					lRetValue = new ImageSource(Resources.Logo_EMALEC_Icon, true);
					break;
			}

			return lRetValue;
		}
	}
}
