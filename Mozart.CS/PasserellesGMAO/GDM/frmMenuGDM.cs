using Microsoft.VisualBasic;
using MozartLib;
using MozartNet;
using ReportEmalec.Net;
using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.IO;
using System.Reflection;
using System.Threading;
using System.Windows.Forms;
using MZUtils = MozartControls.Utils;

namespace MozartCS
{
	public partial class frmMenuGDM : Form
	{
		private int NACTNUM;
		private string NumTaskGDM;

		//  chemin de dépose des fichiers sur le FTP Emalec
		private string cheminGDMFTP = ""; 

		public string strObservation = "";
		public string strRepImage = "";
		public string strRepAtt = "";
		public string strGMAO = "";


		List<List<string>> ListePJ;

		private frmMenuGDM()
		{
			InitializeComponent();
		}

		public frmMenuGDM(int numAction, string numGMAO) : this()
		{
			NACTNUM = numAction;
			NumTaskGDM = txtNumTask.Text = numGMAO;
		}

		private void frmMenuEmPlus_Load(object sender, EventArgs e)
		{
			ListePJ = new List<List<string>>();
			strObservation = "";
			txtResponse.Text = "";

			cheminGDMFTP = Utils.RechercheParam("REP_GDM_FTP");

			// si le numéro GDM n'est pas indiqué dans le numéro GMAO, on le recherche dans la base TGDM sur l'action ou sur la DI
			if (NumTaskGDM == "")
				NumTaskGDM = txtNumTask.Text = getNumeroGDM(NACTNUM, "ACTION");

			// si le numéro GDM n'est pas indiqué sur l'action, on le recherche sur la DI
			if (NumTaskGDM == "")
				NumTaskGDM = txtNumTask.Text = getNumeroGDM(NACTNUM, "DI");

			// liste des docs clients
			InitListeBox();

		}

	

		private void btnSendNote_Click(object sender, EventArgs e)
		{

					
			// si il y a un devis sur l'action, on demande à l'utilisateur si il veut l'envoyer
			bool bEnvoyerDevis = false;
			if (DevisExiste(NACTNUM))
			{
				if (MessageBox.Show("Voulez-vous joindre le devis à l'envoi ?", Program.AppTitle, MessageBoxButtons.YesNo,
														MessageBoxIcon.Question, MessageBoxDefaultButton.Button2) == DialogResult.Yes)
				{

					// recherche si le devis est validé / édité
					int nb = (int)ModuleData.ExecuteScalarInt($"SELECT count(*) FROM TDCL WHERE NACTNUM = {NACTNUM} AND (CDEVISTYPE = 'F' OR CDCLVALID = 'I' OR CDCLVALID = 'P')");  //CDCLVALID = 'I'

					if (nb > 0)
						bEnvoyerDevis = true;
					else
					{
						MessageBox.Show($"Le devis pour cette action n'a pas été validé et édité, il ne peut pas être joint à l'envoi.", Program.AppTitle, MessageBoxButtons.OK, MessageBoxIcon.Error);
						return;
					}

				}
			}

			// confirmation de création chez le client dans le cas d'une nouvelle demande disr ou ddsr
			if (NumTaskGDM == "")
			{
				if (MessageBox.Show("Il n'y a pas de numéro GDM, donc vous allez créer une nouvelle demande chez le client ?", Program.AppTitle, MessageBoxButtons.YesNo,
												MessageBoxIcon.Question, MessageBoxDefaultButton.Button2) == DialogResult.No)
				{
					return;
				}
			}

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

			string obs = "";
			PrepaEnvoiGDM(NACTNUM, bEnvoyerDevis, ref obs);
			// mise à jour observation de l'action
			strObservation = obs;

		}

		public bool PrepaEnvoiGDM(int nactnum, bool bEnvoyerDevis, ref string txtObserv)
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
				NumGDM = getNumeroGDM(nactnum, "DI");

				// on recherche si cette action a déjà un traitement dans la table TGDM
				rGDM = ModuleData.ExecuteReader($"SELECT VTYPEDEMANDE, NGDMNUM, VACTDES, VCODECLIENT, TACT.NDINNUM, DACTPLA, DACTDEX, VDIGDM FROM " +
																				$"TGDM INNER JOIN TACT on TACT.NACTNUM = TGDM.NACTNUM WHERE TGDM.NACTNUM ={nactnum}");


				// si pas de ligne dans TGDM pour cette action

				if (!rGDM.Read())
				{
					// si pas de numéro GDM (ni sur l'action, ni sur la DI, ni dans GMAO, on fait une DISR ou DDSR (en fonction devis ou pas)
					if (NumTaskGDM == "")
					{
						if (bEnvoyerDevis) TypeGDM = "DDSR";
						else TypeGDM = "DISR";
					}
					else
					{
						// numéro GDM existe sur la DI ou sur numéro GMAO et pas de demande sur cette action dans TGDM
						// donc on va faire une DI sur cette action en reprenant le numéro GDM existant
						// donc il faut faire un insert dans TGDM
						// on privilégie le numéro GMAO sur l'action ou le numéro GDM sur la DI ?
						TypeGDM = "DI";
						if (NumGDM == "")
							NumGDM = NumTaskGDM;

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
																				 $" VNOMSITE, DDATECREATION, DDATEPLANIFIEE, DDATECLOTUREINTERV, VDESCRIPTION, VNOMXML, NACTNUM) VALUES ('{rGDM["VCODECLIENT"]}', 'DI','{NumGDM}'," +
																				 $"'EMALE009', '', '{rGDM["NDINNUM"]}/{nactnum}', '{rGDM["VPERMAILPRO"]}', '{rGDM["NSITNUE"]}', '{Utils.BlankIfNull(rGDM["VSITNOM"]).Replace("'", "''")}'," +
																				 $" '{DateTime.Now.ToShortDateString()} {DateTime.Now.ToShortTimeString()}', '{Utils.BlankIfNull(rGDM["DACTPLA"])}', " +
																				 $" '{Utils.BlankIfNull(rGDM["DACTDEX"])}','{sDescString}', '{sNomFichierXML}', {nactnum})");
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

					//// ajout de l'attachement en PJ
					//if (MessageBox.Show("Voulez-vous joindre l'attachement à l'envoi ?", Program.AppTitle, MessageBoxButtons.YesNo, MessageBoxIcon.Question, MessageBoxDefaultButton.Button2) == DialogResult.Yes)
					//{
					//	JoindrePJ_GDM(sNomFichierXML, nactnum);
					//}

					// ajout des documents cochés en PJ
					JoindreDoc_GDM(sNomFichierXML, nactnum);

					// Gestion des PJ ajoutées précédemment, pour l'envoi FTP
					PreparerEnvoiPJ(sNomFichierXML, nactnum);

					// fg le 22/11/2020 ajout de l'envoi du devis si demandé
					if (bEnvoyerDevis && DevisExiste(nactnum))
					{

						JoindreDevis_GDM(sNomFichierXML, nactnum);
					
						// Tracer l'envoi dans le LOG
						ECRIRE_LOG_GDM(getNGDMNUM(nactnum), "DI mise à disposition du programme de transfert GDM, avec devis en PJ");
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
																			 $" VNOMSITE, DDATECREATION, DDATEPLANIFIEE, DDATECLOTUREINTERV, VDESCRIPTION, VNOMXML, NACTNUM) VALUES ('{rGDM["VCODECLIENT"]}', 'DI','{NumGDM}'," +
																			 $"'EMALE009', '', '{rGDM["NDINNUM"]}/{nactnum}', '{rGDM["VPERMAILPRO"]}', '{rGDM["NSITNUE"]}', '{Utils.BlankIfNull(rGDM["VSITNOM"]).Replace("'", "''")}'," +
																			 $" '{DateTime.Now.ToShortDateString()} {DateTime.Now.ToShortTimeString()}', " +
																			 $" '{Utils.BlankIfNull(rGDM["DACTPLA"])}','{Utils.BlankIfNull(rGDM["DACTDEX"])}', '{sDescString}', '{sNomFichierXML}', {nactnum})");
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
					//if (MessageBox.Show("Voulez-vous joindre l'attachement à l'envoi ?", Program.AppTitle, MessageBoxButtons.YesNo, MessageBoxIcon.Question, MessageBoxDefaultButton.Button2) == DialogResult.Yes)
					//{
					//	JoindrePJ_GDM(sNomFichierXML, nactnum);
					//}

					// ajout des documents cochés en PJ
					JoindreDoc_GDM(sNomFichierXML, nactnum);

					// Gestion des PJ ajoutées précédemment, pour l'envoi FTP
					PreparerEnvoiPJ(sNomFichierXML, nactnum);

					// ajout devis si demandé et existe
					if (bEnvoyerDevis && DevisExiste(nactnum))
					{

						JoindreDevis_GDM(sNomFichierXML, nactnum);

						// Tracer l'envoi dans le LOG
						ECRIRE_LOG_GDM(getNGDMNUM(nactnum), "DD mise à disposition du programme de transfert GDM, avec devis en PJ");
						
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
						ModuleData.ExecuteNonQuery($"insert into TGDM (VCODECLIENT, VTYPEDEMANDE, VCODEPRESTATAIRE, VACTIVITE, VDIEMALEC, VCONTACT, " +
																				$"VCODESITE, VNOMSITE, DDATECREATION, DDATEPLANIFIEE, DDATECLOTUREINTERV, VDESCRIPTION, VNOMXML, NACTNUM)" +
																			 $" VALUES ('{rGDM["VCODECLIENT"]}', 'DISR', 'EMALE009', '', '{rGDM["NDINNUM"]}/{nactnum}', '{rGDM["VPERMAILPRO"]}', '{rGDM["NSITNUE"]}'" +
																			 $", '{Utils.BlankIfNull(rGDM["VSITNOM"]).Replace("'", "''")}', '{DateTime.Now.ToShortDateString()} {DateTime.Now.ToShortTimeString()}'" +
																			 $", '{Utils.BlankIfNull(rGDM["DACTPLA"])}', '{Utils.BlankIfNull(rGDM["DACTDEX"])}', '{sDescString}', '{sNomFichierXML}', {nactnum})");
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
					string Nomf2 = $"DI{rGDM["NDINNUM"]}A{nactnum}.pdf";// Nom du fichier à stocker en SQL
					string sNomFichierDI_PDF = sNomFichierXML_ssExt + "_" + Nomf2;
					File.Copy($@"{MozartParams.CheminUtilisateurMozart}PDF\{nactnum}.pdf", $@"{cheminGDMFTP}FTP\OutBox_PJ\{sNomFichierDI_PDF}", true);

					// on a fait un insert dans TGDM, donc il faut récupérer le nouveau NGDMNUM
					rGDM.Close();
					rGDM = ModuleData.ExecuteReader($"select NGDMNUM from TGDM WHERE TGDM.NACTNUM = {nactnum}");
					rGDM.Read();

					// Ecrire les détails de la pièce jointe dans la table TGDM_LSTDOC
					ModuleData.ExecuteNonQuery($"insert into TGDM_LSTDOC (NGDMNUM, VNOM, DDATE, VPROVENANCE, DDATEENVOI, BENVOYERPJ, TYPEPJ) VALUES ({rGDM["NGDMNUM"]}" +
																		 $", '{Nomf2}', '{DateTime.Now.ToShortDateString()} {DateTime.Now.ToShortTimeString()}', 'EMALEC', '{DateTime.Now.ToShortDateString()} {DateTime.Now.ToShortTimeString()}', 1, 'DI')");


					// ajout de l'attachement en PJ
					//if (MessageBox.Show("Voulez-vous joindre l'attachement à l'envoi ?", Program.AppTitle, MessageBoxButtons.YesNo, MessageBoxIcon.Question, MessageBoxDefaultButton.Button2) == DialogResult.Yes)
					//{
					//	JoindrePJ_GDM(sNomFichierXML, nactnum);
					//}

					// ajout des documents cochés en PJ
					JoindreDoc_GDM(sNomFichierXML, nactnum);

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
						ModuleData.ExecuteNonQuery($"insert into TGDM (VCODECLIENT, VTYPEDEMANDE, VCODEPRESTATAIRE, VACTIVITE, VDIEMALEC, VCONTACT, " +
																			$"VCODESITE, VNOMSITE, DDATECREATION, DDATEPLANIFIEE, DDATECLOTUREINTERV, VDESCRIPTION, VNOMXML, NACTNUM)" +
																				$" VALUES ('{rGDM["VCODECLIENT"]}', 'DDSR', 'EMALE009', '', '{rGDM["NDINNUM"]}/{nactnum}', '{rGDM["VPERMAILPRO"]}', '{rGDM["NSITNUE"]}'" +
																				$", '{Utils.BlankIfNull(rGDM["VSITNOM"]).Replace("'", "''")}', '{DateTime.Now.ToShortDateString()} {DateTime.Now.ToShortTimeString()}'" +
																				$", '{Utils.BlankIfNull(rGDM["DACTPLA"])}', '{Utils.BlankIfNull(rGDM["DACTDEX"])}', '{sDescString}', '{sNomFichierXML}', {nactnum})");

					}
					else
					{
						// Màj DDSR existante (interdit normalement mais pourquoi pas)
						ModuleData.ExecuteNonQuery($"update TGDM SET VNOMXML = '{sNomFichierXML}', VDESCRIPTION = '{sDescString}', DDATEPLANIFIEE = '{Utils.BlankIfNull(rGDM["DACTPLA"])}', DDATECLOTUREINTERV = '{Utils.BlankIfNull(rGDM["DACTDEX"])}' where NACTNUM = {nactnum}");
					}

					// ajout de l'attachement en PJ
					//if (MessageBox.Show("Voulez-vous joindre l'attachement à l'envoi ?", Program.AppTitle, MessageBoxButtons.YesNo, MessageBoxIcon.Question, MessageBoxDefaultButton.Button2) == DialogResult.Yes)
					//{
					//	JoindrePJ_GDM(sNomFichierXML, nactnum);
					//}

					// ajout des documents cochés en PJ
					JoindreDoc_GDM(sNomFichierXML, nactnum);

					// Gestion des PJ ajoutées précédemment, pour l'envoi FTP
					PreparerEnvoiPJ(sNomFichierXML, nactnum);

					if (bEnvoyerDevis && DevisExiste(nactnum))
					{
						JoindreDevis_GDM(sNomFichierXML, nactnum);

						ECRIRE_LOG_GDM(getNGDMNUM(nactnum), "DDSR mise à disposition du programme de transfert GDM, avec devis en PJ");
					}
					else
					{
						UpdateFlag_cJoindreDevisEnvoi_TGDM(nactnum, "N");

						ECRIRE_LOG_GDM(getNGDMNUM(nactnum), "DDSR mise à disposition du programme de transfert GDM sans devis en PJ");
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

		public static void ECRIRE_LOG_GDM(int NGDMNUM, string QUOI)
		{
			ModuleData.ExecuteNonQuery($"insert into TGDM_LOG (NGDMNUM, DGDMLOGDATE, VGDMLOGQUI, VGDMLOGQUOI) VALUES ({NGDMNUM}, '{DateTime.Now.ToShortDateString()} {DateTime.Now.ToShortTimeString()}', '{MozartParams.strUID}', '{QUOI.Replace("'", "''")}')");
		}

		public void JoindreDevis_GDM(string sNomFichierXML, int nactnum)
		{

			SqlDataReader reader;

			reader = ModuleData.ExecuteReader($"select NGDMNUM, NDCLNUM, CDEVISTYPE, CTYPEMODELE, NDCLHT, DDCLDAT from " +
																$"TGDM INNER JOIN TACT on TACT.NACTNUM = TGDM.NACTNUM INNER JOIN TDCL ON TDCL.NACTNUM = " +
																$"TACT.NACTNUM WHERE TGDM.NACTNUM = {nactnum} ");
			reader.Read();

			// ajout devis dans l'envoi
			UpdateFlag_cJoindreDevisEnvoi_TGDM(nactnum, "O");

			string sNomFichierXML_ssExt = Path.GetFileNameWithoutExtension(sNomFichierXML);

			// génération du devis en pdf
			string sNomReport = RechercheModeleDevis(Utils.BlankIfNull(reader["CDEVISTYPE"]), Utils.BlankIfNull(reader["CTYPEMODELE"]));
			new frmMainReport
			{
				bLaunchByProcessStart = false,
				sTypeReport = sNomReport,
				sIdentifiant = Utils.BlankIfNull(reader["NDCLNUM"]),
				InfosMail = "TCCL|NCCLCODE|000",
				sNomSociete = MozartParams.NomSociete,
				sLangue = "FR",
				sOption = "PDF",
				strType = "DC",
				numAction = nactnum
			}.ShowDialog();

			string Nomf = $"DD{reader["NDCLNUM"]}_{nactnum}.pdf";// Nom du fichier à stocker en SQL
			string sNomFichierDD_PDF = $"{sNomFichierXML_ssExt}_{reader["NDCLNUM"]}_{Nomf}";
			File.Copy($@"{MozartParams.CheminUtilisateurMozart}PDF\{reader["NDCLNUM"]}.pdf", $@"{cheminGDMFTP}FTP\OutBox_PJ\{sNomFichierDD_PDF}", true);

			// Ecrire les détails du devis dans la table TGDM_DEVIS
			int nGDMDEVISNUM = getNGDMDEVISNUM((int)Utils.ZeroIfNull(reader["NGDMNUM"]));// Voir si la section devis existe déjà en SQL
			if (nGDMDEVISNUM == 0)
			{
				ModuleData.ExecuteNonQuery($"insert into TGDM_DEVIS (NGDMNUM, VNUMERO, NMONTANT, DDATEDEVIS) VALUES ({reader["NGDMNUM"]}" +
																	 $", '{reader["NDCLNUM"]}', {Utils.BlankIfNull(reader["NDCLHT"]).Replace(",", ".")}, '{reader["DDCLDAT"]}')");
			}
			else
			{
				ModuleData.ExecuteNonQuery($"update TGDM_DEVIS SET VNUMERO = '{reader["NDCLNUM"]}', NMONTANT =  {Utils.BlankIfNull(reader["NDCLHT"]).Replace(",", ".")}," +
																	 $" DDATEDEVIS = '{reader["DDCLDAT"]}' where NGDMDEVISNUM = {nGDMDEVISNUM}");
			}

			// Récupérer à nouveau le n° unique de devis
			nGDMDEVISNUM = getNGDMDEVISNUM((int)Utils.ZeroIfNull(reader["NGDMNUM"]));

			// Ecrire les détails du devis dans la table TGDM_DEVIS_DOCLST
			ModuleData.ExecuteNonQuery($"insert into TGDM_DEVIS_DOCLST (NGDMDEVISNUM, VNOM, DDATE, VPROVENANCE) VALUES (" +
																 $"{nGDMDEVISNUM}, '{Nomf}', '{DateTime.Now.ToShortDateString()} {DateTime.Now.ToShortTimeString()}', 'EMALEC')");


			reader.Close();

		}


		public class MonItem
		{
			public string Libelle { get; set; }
			public string Fichier { get; set; }
			public int IdFichier { get; set; }

			public override string ToString()
			{
				return Libelle; // Ce qui sera affiché dans le CheckedListBox
			}
		}

		private void InitListeBox()
		{

			try
			{
				lstDoc.Items.Clear();
				ListePJ.Clear();

				// initialisation      
				SqlDataReader mRs = ModuleData.ExecuteReader($"EXEC api_sp_ListeDocClientForPJ {NACTNUM}");

				while (mRs.Read())
				{
					lstDoc.Items.Add(new MonItem { Libelle = mRs["VIMAGE"].ToString(), 
																				Fichier = mRs["VFILE"].ToString(), 
																				IdFichier = Convert.ToInt32(mRs["NIMAGE"])	});

					}

				mRs.Close();
			}

			catch (Exception ex)
			{
				MZUtils.displayError(MethodBase.GetCurrentMethod().Name, ex);
			}
		}

		public static int getNGDMNUM(int nACTION)
		{
			int? NGDMNUM = ModuleData.ExecuteScalarInt($"select NGDMNUM from TGDM where NACTNUM = {nACTION}");
			return (int)Utils.ZeroIfNull(NGDMNUM);
		}

		public static string getNumeroGDM(int nACTION, string sType)
		{
			string NGDM;
			if (sType == "ACTION")
				NGDM = ModuleData.ExecuteScalarString($"select VDIGDM from TGDM where NACTNUM = {nACTION}");
			else
				NGDM = ModuleData.ExecuteScalarString($"select top 1 VDIGDM from TGDM where vtypedemande in ('DD', 'DI') " +
																							$"AND NACTNUM in (select nactnum from tact where ndinnum = " +
																							$"(select ndinnum from tact where nactnum={nACTION}))");

			return Utils.BlankIfNull(NGDM);
		}

	
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

		public static void UpdateFlag_cJoindreDevisEnvoi_TGDM(int nactnum, string val)
		{
			ModuleData.ExecuteNonQuery($"UPDATE TGDM SET cJoindreDevisEnvoi = '{val}' WHERE NACTNUM = {nactnum}");
		}

		public static string RechercheModeleDevis(string sDevisType, string sTypeModele)
		{
			string sNomReport;

			switch (sDevisType)
			{

				// devis prestation
				case "P":
					sNomReport = "TDevisClientPrestationSansDetails";
					break;

				// Nouveaux devis
				case "G":
					sNomReport = "DEVIS_V2";
					break;

				default:
					sNomReport = "DEVIS_V2";
					break;
			}

			return sNomReport;
		}

		public static bool DevisExiste(int nactnum)
		{
			using (SqlDataReader reader = ModuleData.ExecuteReader($"select NDCLNUM FROM TDCL WHERE NACTNUM = {nactnum}"))
				return reader.Read();
		}


		public void PreparerEnvoiPJ(string sNomFichierXML, int nactnum)
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

				do
				{
					// On dépose les fichiers pour le FTP
					string sNomFichierDest = Path.GetFileNameWithoutExtension(sNomFichierXML) + "_" + Utils.BlankIfNull(reader["VNOM"]);
					Thread.Sleep(500);
					File.Copy(Utils.BlankIfNull(reader["VFICHIER_SOURCE"]), $@"{cheminGDMFTP}FTP\OutBox_PJ\{sNomFichierDest}", true);
				} while (reader.Read());
			}
		}


		public void JoindreDoc_GDM(string sNomFichierXML, int nactnum)
		{

			foreach (object item in lstDoc.CheckedItems)
			{

				MonItem monItem = (MonItem)item;
				string filePath = monItem.Fichier;
				int IdDoc = monItem.IdFichier;
				string Ext = Path.GetExtension(filePath);

				// On insère une ligne dans la table des fichiers à envoyer
				string o_sql = $"insert into TGDM_LSTDOC (NGDMNUM, VNOM, DDATE, DDATEENVOI, VPROVENANCE, TIMAC_NIMAGE, " +
											$"VFICHIER_SOURCE, BENVOYERPJ, TYPEPJ) VALUES ({getNGDMNUM(nactnum)}, 'PJ{IdDoc}{Ext}', " +
											$"GetDate(), GetDate(), 'EMALEC', {IdDoc}, '{filePath}', 1, 'PJ')";

				ModuleData.ExecuteNonQuery(o_sql);
			}
		}

		public static void JoindrePJ_GDM(string sNomFichierXML, int nactnum)
		{

			string cheminPhoto = Utils.RechercheParam("REP_ATTGAM");
			string cheminAttach = Utils.RechercheParam("REP_PHOTOS_ACT");

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

		private static string Generate_NOMXML(string sVCODECLIENT)
		{
			// A utiliser uniquement pour la table TGDM (champ VNOMXML)
			int ran = 1 + (int)(new Random().NextDouble() * 9999);
			string sRan = ran.ToString();
			sRan.PadLeft(4, '0');

			DateTime jour = DateTime.Now;

			return $"{sVCODECLIENT}_EMALE009_{jour.ToString("yyyy")}{jour.ToString("MM")}{jour.ToString("dd")}-{jour.ToString("HH")}{jour.ToString("mm")}{jour.ToString("ss")}-{sRan}.xml";
		}

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

	
		private void apiButton1_Click(object sender, EventArgs e)
		{
			Frame3.Visible = false;
		}

		private void btnSendDoc_Click(object sender, EventArgs e)
		{
			Frame3.Visible = true;
		}

		private void apiButton2_Click(object sender, EventArgs e)
		{
			Cursor.Current = Cursors.WaitCursor;

			try
			{
				strObservation = "";

				Frame3.Visible = false;
			}
			catch (Exception ex)
			{
				txtResponse.Text = ex.Message;
			}

			Cursor.Current = Cursors.Default;
		}

		private void btnClose_Click(object sender, EventArgs e)
		{
			this.Close();
		}

	}
}
