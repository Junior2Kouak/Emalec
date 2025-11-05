using MozartLib;
using MozartNet;
using ReportEmalec.Net;
using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.IO;
using System.Reflection;
using System.Windows.Forms;
using MZUtils = MozartControls.Utils;

namespace MozartCS
{
	public partial class frmMenuPlanon : Form
	{
		private int NACTNUM;
		private string NumTaskPlanon;
		private string IdTaskPlanon = "";

		// test
		//const string BASE_URL = "https://services.samfm.net/svcplatform08/OrchestrationApi/api/";

		// prod
		const string BASE_URL = " https://api.samfm.net/samfmbpifrance/OrchestrationApi/api/";


		public string strObservation = "";
		public string strRepImage = "";
		public string strRepAtt = "";
		public string strDuree = "";
		public string strGMAO = "";


		List<List<string>> ListePJ;

		private frmMenuPlanon()
		{
			InitializeComponent();
		}

		public frmMenuPlanon(int numAction, string numGMAO, string duree) : this()
		{
			NACTNUM = numAction;

			strDuree = duree;
			NumTaskPlanon = txtNumTask.Text = numGMAO;
		}

		private void frmMenuEmPlus_Load(object sender, EventArgs e)
		{
			ListePJ = new List<List<string>>();
			strObservation = "";
			txtResponse.Text = "";

		}

		private void frmMenuPlanon_Shown(object sender, EventArgs e)
		{
			if (!ExistTask(NumTaskPlanon))
			{
				MessageBox.Show($"Il n'y a pas de demande avec ce numéro dans la base SamFM", Program.AppTitle, MessageBoxButtons.OK, MessageBoxIcon.Information);
			}
		}

		private void btnTerminer_Click(object sender, EventArgs e)
		{
			Cursor.Current = Cursors.WaitCursor;

			try
			{
				checkCommonParameters();

				// rechercher si la demande existe dans la base EMALEC
				if (IdTaskPlanon == "")
				{
					MessageBox.Show($"Il n'y a pas de demande avec ce numéro dans la base SamFM", MozartCS.Properties.Resources.Global_Erreur, MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
					return;
				}

				// confirmation de la cloture de la demande (c'est irreversible et ça bloque la demande)
				if (MessageBox.Show("Etes-vous sûr de vouloir clore cette demande chez le client ?", Program.AppTitle, MessageBoxButtons.YesNo,
														MessageBoxIcon.Question, MessageBoxDefaultButton.Button2) != DialogResult.Yes)
				{
					return;
				}

				string result = "";
				Uri url = new Uri($"{BASE_URL}/operations/{IdTaskPlanon}/reports");

				DateTime date = DateTime.Now;
				string rfc3339 = date.ToString("yyyy-MM-dd'T'HH:mm:ss.fffK", System.Globalization.CultureInfo.InvariantCulture);

				// passer la demande à Terminé (workFinished = true) duree doit être > 0
				var INFO = new Planon.RootObject
				{
					beginDate = DateTime.Parse(rfc3339),
					endDate = DateTime.Parse(rfc3339),
					duration = Convert.ToDouble(strDuree) == 0 ? 1 : Convert.ToDouble(strDuree),
					comment = txtNote.Text,
					workFinished = true
				};

				// envoi de la cloture
				if (!Planon.CallUpdateTask(url, INFO, ref result))
					throw new Exception($"{result}");

				LogInfo($"GMAO: {txtNumTask.Text},\tCloture de la demande, Action {NACTNUM}{Environment.NewLine}{Environment.NewLine}");
				txtResponse.Text = $"{txtResponse.Text}{Environment.NewLine}OK - Cloture de la demande";
				strObservation = $"{strObservation}\r\nCloture de la demande dans SamFM";
			}
			catch (Exception ex)
			{
				LogInfo($"GMAO: {txtNumTask.Text},\tError: {ex.Message}{Environment.NewLine}{Environment.NewLine}{MozartCS.Properties.Resources.Global_dans}{MethodBase.GetCurrentMethod().Name}");
				txtResponse.Text = ex.Message;
			}

			Cursor.Current = Cursors.Default;

		}

		private void cmdValide_Click(object sender, EventArgs e)
		{
			Cursor.Current = Cursors.WaitCursor;
			try
			{
				checkCommonParameters();

				if (string.IsNullOrEmpty(txtNote.Text))
				{
					MessageBox.Show($"Il faut saisir un commentaire", MozartCS.Properties.Resources.Global_Erreur, MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
					return;
				}

				string result = "";
				Uri url = new Uri($"{BASE_URL}operations/{IdTaskPlanon}/reports");

				DateTime date = DateTime.Now;
				string rfc3339 = date.ToString("yyyy-MM-dd'T'HH:mm:ss.fffK", System.Globalization.CultureInfo.InvariantCulture);

				// envoyer une note d'information sans cloturer l'intervention (duree doit être > 0)
				var INFO = new Planon.RootObject
				{
					beginDate = DateTime.Parse(rfc3339),
					endDate = DateTime.Parse(rfc3339),
					duration = Convert.ToDouble(strDuree) == 0 ? 1 : Convert.ToDouble(strDuree),
					comment = txtNote.Text,
					operatorId = 0,
					workFinished = false
				};


				// envoi de la note
				if (!Planon.CallUpdateTask(url, INFO, ref result))
					throw new Exception($"{result}");

				LogInfo($"GMAO: {txtNumTask.Text},\tEnvoi de commentaires sur une demande, Action {NACTNUM}{Environment.NewLine}{Environment.NewLine}");
				txtResponse.Text = $"{txtResponse.Text}{Environment.NewLine}OK - Envoi du message";

				strObservation = $"{strObservation}\r\nEnvoi d'un message vers SamFM";

			}
			catch (Exception ex)
			{
				LogInfo($"GMAO: {txtNumTask.Text},\tError: {ex.Message}{Environment.NewLine}{Environment.NewLine}{MozartCS.Properties.Resources.Global_dans}{MethodBase.GetCurrentMethod().Name}");
				txtResponse.Text = ex.Message;
			}

			Cursor.Current = Cursors.Default;

			FrameNote.Visible = false;

		}

		private void LogInfo(string message)
		{
			MozartDatabase.ExecuteNonQuery($"Insert into TPLANON_LOG (VLOGMSG) Values ('{message.Replace("'", "''")}')");
		}

		private FileInfo GetDevis(ref decimal montant)
		{
			try
			{
				int numDCL = 0;
				string dPrice = "";
				string typeDevis = "";
				string typeModele = "";
				// FGA le 10/10/23 pas besoin de faire référence à la table EMPLUS car on peut envoyer devis meme si rien dans la table
				//                string sql = @"select NDCLNUM, CDEVISTYPE, CTYPEMODELE, NDCLHT, DDCLDAT from TDIEMPLUS E INNER JOIN TACT A on A.NACTNUM = E.NACTNUM INNER JOIN TDCL D ON D.NACTNUM = A.NACTNUM WHERE E.NACTNUM = " + NACTNUM;
				string sql = @"select NDCLNUM, CDEVISTYPE, CTYPEMODELE, NDCLHT, DDCLDAT from TACT A INNER JOIN TDCL D ON D.NACTNUM = A.NACTNUM WHERE A.NACTNUM = " + NACTNUM;
				using (var cmd = new SqlCommand(sql, MozartDatabase.cnxMozart))
				{
					SqlDataReader dr = cmd.ExecuteReader();
					if (dr.Read())
					{
						numDCL = Convert.ToInt32(dr["NDCLNUM"]);
						typeDevis = dr["CDEVISTYPE"]?.ToString();
						typeModele = dr["CTYPEMODELE"]?.ToString();
						dPrice = dr["NDCLHT"]?.ToString();

						if (!string.IsNullOrEmpty(dPrice))
							montant = decimal.Parse(dPrice);
					}
				}

				if (numDCL == 0)
				{
					LogInfo($"GMAO: {txtNumTask.Text}, Aucun devis disponible sur cette action (Action: {NACTNUM})");
					return null;
				}

				// Génération du fichier PDF du devis
				string sNomReport = DetailstravauxUtils.RechercheModeleDevis(typeDevis, typeModele);
				var lFrmMainReport = new frmMainReport()
				{
					bLaunchByProcessStart = false,
					sTypeReport = sNomReport,
					sIdentifiant = numDCL.ToString(),
					InfosMail = "TCCL|NCCLCODE|000",
					sNomSociete = MozartParams.NomSociete,
					sLangue = "FR",
					sOption = "PDF",
					strType = "DC",
					numAction = NACTNUM
				};
				lFrmMainReport.ShowDialog();

				string sFichierDevis = MozartParams.CheminUtilisateurMozart + @"PDF\" + numDCL + ".pdf";

				LogInfo($"GMAO: {txtNumTask.Text}, \tGénération du devis Action: {NACTNUM}, Devis: {sFichierDevis}");

				if (File.Exists(sFichierDevis))
					return new FileInfo(sFichierDevis);
			}
			catch (Exception ex)
			{
				LogInfo($"GMAO: {txtNumTask.Text},\tError: {ex.Message}{Environment.NewLine}{Environment.NewLine}{MozartCS.Properties.Resources.Global_dans}{MethodBase.GetCurrentMethod().Name}");
				MZUtils.displayError(MethodBase.GetCurrentMethod().Name, ex);
			}

			return null;
		}

		private void checkCommonParameters()
		{
			if (string.IsNullOrEmpty(txtNumTask.Text))
				throw new Exception("Invalid GMAO");

			if (string.IsNullOrEmpty(BASE_URL))
				throw new Exception("Invalid BASE_URL");
		}


		private void btnSendNote_Click(object sender, EventArgs e)
		{

			// rechercher si la demande existe dans la base EMALEC
			if (IdTaskPlanon == "")
			{
				MessageBox.Show($"Il n'y a pas de demande avec ce numéro dans la base SamFM", MozartCS.Properties.Resources.Global_Erreur, MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
				return;
			}

			txtNote.Text = "";
			FrameNote.Tag = "NOTE";
			FrameNote.Visible = true;
		}

		private void cmdAnnule_Click(object sender, EventArgs e)
		{
			txtNote.Text = "";
			FrameNote.Tag = "";
			FrameNote.Visible = false;
		}

		private void btnClose_Click(object sender, EventArgs e)
		{
			this.Close();
		}

		private void apiButton1_Click(object sender, EventArgs e)
		{
			Frame3.Visible = false;
		}

		private void btnSendDoc_Click(object sender, EventArgs e)
		{
			if (IdTaskPlanon == "")
			{
				MessageBox.Show($"Il n'y a pas de demande avec ce numéro dans la base SamFM", MozartCS.Properties.Resources.Global_Erreur, MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
				return;
			}

			InitListeBox();
			Frame3.Visible = true;
		}

		private void apiButton2_Click(object sender, EventArgs e)
		{
			Cursor.Current = Cursors.WaitCursor;

			try
			{
				checkCommonParameters();
				strObservation = "";

				foreach (string item in lstDoc.CheckedItems)
				{
					FileInfo fileInfo = new FileInfo(RechercheFile(item.ToString()));
					SendDocument(fileInfo);
				}
				Frame3.Visible = false;
			}
			catch (Exception ex)
			{
				txtResponse.Text = ex.Message;
			}

			Cursor.Current = Cursors.Default;
		}

		private void SendDocument(FileInfo fileInfo)
		{
			Cursor.Current = Cursors.WaitCursor;

			try
			{

				if (fileInfo == null)
					throw new Exception("Pas de document valide");

				// il faut copier l'attachement en local
				string filePath = CImpersonation.OpenFileImpersonated(fileInfo.FullName);
				string filename = Path.GetFileName(filePath);

				//filePath = @"C:\temp\toto.pdf";
				//filename = "toto.pdf";
				//string filePath = fileInfo.FullName;
				//string filename = fileInfo.Name;

				string result = "";
				// test
				//Uri url = new Uri($"https://webconnectors.samfm.net/APIMozaris/api/operation/{IdTaskPlanon}/attachment");
				// prod
				Uri url = new Uri($"https://webservices.samfm.net/WS18A060APIMozaris/api/operation/{IdTaskPlanon}/attachment");


				//Uri url = new Uri($"{BASE_URL}operations/{NumTaskPlanon}/images");

				// envoi attachement
				if (!Planon.CallSendDocument(NumTaskPlanon, url, filename, filePath, ref result))
					throw new Exception($"{result}");

				txtResponse.Text = $"{txtResponse.Text}\r\nEnvoi du document ({filename}) dans SamFM ";
				strObservation = $"{strObservation}\r\nEnvoi du document ({filename}) dans SamFM ";

			}

			catch (Exception ex)
			{
				LogInfo($"GMAO: {txtNumTask.Text},\tError: {ex.Message}{Environment.NewLine}{Environment.NewLine}{MozartCS.Properties.Resources.Global_dans}{MethodBase.GetCurrentMethod().Name}");
				txtResponse.Text = ex.Message;
			}

			Cursor.Current = Cursors.Default;
		}

		private void btnStatutDA_Click(object sender, EventArgs e)
		{
			Cursor.Current = Cursors.WaitCursor;

			try
			{
				// rechercher si la demande existe dans la base EMALEC
				if (IdTaskPlanon == "")
				{
					MessageBox.Show($"Il n'y a pas de demande avec ce numéro dans la base SamFM", MozartCS.Properties.Resources.Global_Erreur, MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
					return;
				}

				// Récupération des infos sur SamFM et mise à jour dans la base EMALEC
				// pas utile
				//MiseAjourTask(NumTaskPlanon);

				// API de mise à jour de SamFM
				string result = "";
				Uri url = new Uri($"{BASE_URL}/operations/{IdTaskPlanon}");

				// il faut faire un GET global de la demande, changer le statut et refaire un PUT
				// Récupération de la demande sur SamFM 
				Planon.OperationResponse INFO = Planon.GetWork(url.ToString());

				// on change le statut "DEVIS A FAIRE"
				INFO.StatusId = 11;

				// envoi du statut
				if (!Planon.CallUpdateStatut(url, INFO, ref result))
					throw new Exception($"{result}");

				LogInfo($"GMAO: {txtNumTask.Text},\tPassage du statut de la demande à 'Devis à faire', Action {NACTNUM}{Environment.NewLine}{Environment.NewLine}");
				txtResponse.Text = $"{txtResponse.Text}{Environment.NewLine}OK - changement statut 'Devis à faire'";
				strObservation = $"{strObservation}\r\nChangement de statut (DF) de la demande dans SamFM";

			}
			catch (Exception ex)
			{
				LogInfo($"GMAO: {txtNumTask.Text},\tError: {ex.Message}{Environment.NewLine}{Environment.NewLine}{MozartCS.Properties.Resources.Global_dans}{MethodBase.GetCurrentMethod().Name}");
				txtResponse.Text = ex.Message;
			}

			Cursor.Current = Cursors.Default;
		}

		private void btnDevisClient_Click(object sender, EventArgs e)
		{
			if (IdTaskPlanon == "")
			{
				MessageBox.Show($"Il n'y a pas de demande avec ce numéro dans la base SamFM", MozartCS.Properties.Resources.Global_Erreur, MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
				return;
			}
			Cursor.Current = Cursors.WaitCursor;

			try
			{
				checkCommonParameters();
				strObservation = "";

				// on recherche dans la base Mozart
				SqlDataReader red = ModuleData.ExecuteReader($"select NDCLNUM FROM TDCL WHERE NACTNUM = {NACTNUM} AND (CDEVISTYPE = 'F' OR CDCLVALID = 'I' OR CDCLVALID = 'P')");
				if (!red.Read())
				{
					MessageBox.Show($"Il n'y a pas de devis validé et édité sur cette action", MozartCS.Properties.Resources.Global_Erreur, MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
				}
				else
				{

					// report du devis en pdf en local
					new frmMainReport
					{
						bLaunchByProcessStart = false,
						sTypeReport = "DEVIS_V2",
						sIdentifiant = Utils.BlankIfNull(red["NDCLNUM"]),
						InfosMail = "TCCL|NCCLCODE|000",
						sNomSociete = MozartParams.NomSociete,
						sLangue = "FR",
						sOption = "PDF",
						strType = "DC",
						numAction = NACTNUM
					}.ShowDialog();

					FileInfo fileInfo = new FileInfo($@"{MozartParams.CheminUtilisateurMozart}PDF\{red["NDCLNUM"]}.pdf");
					SendDocument(fileInfo);
				}
			}
			catch (Exception ex)
			{
				txtResponse.Text = ex.Message;
			}

			Cursor.Current = Cursors.Default;
		}


		private void bntStatutDD_Click(object sender, EventArgs e)
		{
			Cursor.Current = Cursors.WaitCursor;

			try
			{
				// rechercher si la demande existe dans la base EMALEC
				if (IdTaskPlanon == "")
				{
					MessageBox.Show($"Il n'y a pas de demande avec ce numéro dans la base SamFM", MozartCS.Properties.Resources.Global_Erreur, MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
					return;
				}

				// API de mise à jour de SamFM
				string result = "";
				Uri url = new Uri($"{BASE_URL}/operations/{IdTaskPlanon}");

				// il faut faire un GET global de la demande, changer le statut et refaire un PUT
				// Récupération de la demande sur SamFM 
				Planon.OperationResponse INFO = Planon.GetWork(url.ToString());

				// statut "DEVIS DEPOSE"
				INFO.StatusId = 12;

				// envoi du statut
				if (!Planon.CallUpdateStatut(url, INFO, ref result))
					throw new Exception($"{result}");

				LogInfo($"GMAO: {txtNumTask.Text},\tPassage du statut de la demande à 'Devis déposé', Action {NACTNUM}{Environment.NewLine}{Environment.NewLine}");
				txtResponse.Text = $"{txtResponse.Text}{Environment.NewLine}OK - changement statut 'Devis déposé'";
				strObservation = $"{strObservation}\r\nChangement de statut (DD) de la demande dans SamFM";

			}
			catch (Exception ex)
			{
				LogInfo($"GMAO: {txtNumTask.Text},\tError: {ex.Message}{Environment.NewLine}{Environment.NewLine}{MozartCS.Properties.Resources.Global_dans}{MethodBase.GetCurrentMethod().Name}");
				txtResponse.Text = ex.Message;
			}

			Cursor.Current = Cursors.Default;
		}

		private void InitListeBox()
		{

			try
			{
				lstDoc.Items.Clear();
				ListePJ.Clear();

				// initialisation      
				SqlDataReader mRs = ModuleData.ExecuteReader($"EXEC api_sp_ListeDocClientForPJ {MozartParams.NumAction}");

				while (mRs.Read())
				{
					List<string> elem = new List<string>();
					lstDoc.Items.Add(mRs["VIMAGE"]);
					elem.Add(mRs["VIMAGE"].ToString());
					elem.Add(mRs["VFILE"].ToString());
					ListePJ.Add(elem);
				}

				mRs.Close();
			}

			catch (Exception ex)
			{
				MZUtils.displayError(MethodBase.GetCurrentMethod().Name, ex);
			}
		}

		private bool ExistTask(string numGMAO)
		{
			try
			{
				// on recherche dans la base Mozart ce numéro de task
				SqlDataReader red = ModuleData.ExecuteReader($"Select NIDOPE from TDIPLANON  where VCODEOPE = '{numGMAO}'");
				if (!red.Read())
				{
					// Si on ne le trouve pas dans la base Mozart, on lance le GetTask sur la dernière heure pour éventuellement récupérer la demande si elle est récente
					Planon.GetListWork($"{BASE_URL}operations/findByDate");

					SqlDataReader red2 = ModuleData.ExecuteReader($"Select NIDOPE from TDIPLANON  where VCODEOPE = '{numGMAO}'");
					if (red2.Read())
					{
						IdTaskPlanon = red2["NIDOPE"].ToString();
						red2.Close();
						return true;
					}
					else
					{
						IdTaskPlanon = "";
						red2.Close();
						return false;
					}
				}
				else
				{
					IdTaskPlanon = red["NIDOPE"].ToString();
					red.Close(); 
					return true;
				}
				
			}
			catch (Exception ex)
			{
				MZUtils.displayError(MethodBase.GetCurrentMethod().Name, ex);
				return false;
			}
		}


		private void MiseAjourTask(string numGMAO)
		{

			try
			{
				// recherche du numéro de tache
				string num = ModuleData.ExecuteScalarString($"Select NIDOPE from TDIPLANON  where VCODEOPE = '{numGMAO}'");

				// recherche task par numéro
				Uri url = new Uri($"{BASE_URL}operations/{num}");

				if (!Planon.MajWordOrder(RestSharp.Method.GET, url, NACTNUM))
				{
					LogInfo($"GMAO: {txtNumTask.Text},\t Problème de Mise aà jour de la tache,  Action : {NACTNUM}{Environment.NewLine}{Environment.NewLine}");
					txtResponse.Text = "Problème de mise à jour de la demande";
				}
			}
			catch (Exception ex)
			{
				MZUtils.displayError(MethodBase.GetCurrentMethod().Name, ex);
			}
		}

		private string RechercheFile(string Nom)
		{
			// Cette fonction permet de rechercher le fichiher avec son nom
			string sFile = "";
			foreach (List<string> l in ListePJ)
			{
				if (l[0] == Nom)
					sFile = l[1];
			}

			return sFile;
		}


		private void btnTest_Click(object sender, EventArgs e)
		{
			Cursor.Current = Cursors.WaitCursor;

			try
			{
				checkCommonParameters();

				string result = "";
				Uri url = new Uri($"{BASE_URL}operations/findByDate");


				if (!Planon.GetDI(RestSharp.Method.GET, url))
					throw new Exception($"'\r\n{result}");

				LogInfo($"GMAO: {txtNumTask.Text},\tRécupération des taches,  Action : {NACTNUM}{Environment.NewLine}{Environment.NewLine}");
				txtResponse.Text = "OK - récupération des taches";

			}
			catch (Exception ex)
			{
				LogInfo($"GMAO: {txtNumTask.Text},\tError: {ex.Message}{Environment.NewLine}{Environment.NewLine}{MozartCS.Properties.Resources.Global_dans}{MethodBase.GetCurrentMethod().Name}");
				txtResponse.Text = ex.Message;
			}

			Cursor.Current = Cursors.Default;
		}


		private void button1_Click(object sender, EventArgs e)
		{
			Cursor.Current = Cursors.WaitCursor;

			try
			{
				checkCommonParameters();

				string result = "";
				Uri url = new Uri($"{BASE_URL}operations/105588");
				//Uri url = new Uri($"{BASE_URL}activityTypes");
				//Uri url = new Uri($"{BASE_URL}operationStatus");



				if (!Planon.MajWordOrder(RestSharp.Method.GET, url, NACTNUM))
					throw new Exception($"'\r\n{result}");

				LogInfo($"GMAO: {txtNumTask.Text},\tRécupération des taches,  Action : {NACTNUM}{Environment.NewLine}{Environment.NewLine}");
				txtResponse.Text = "OK - récupération des taches";

			}
			catch (Exception ex)
			{
				LogInfo($"GMAO: {txtNumTask.Text},\tError: {ex.Message}{Environment.NewLine}{Environment.NewLine}{MozartCS.Properties.Resources.Global_dans}{MethodBase.GetCurrentMethod().Name}");
				txtResponse.Text = ex.Message;
			}

			Cursor.Current = Cursors.Default;
		}

		private void btnCreation_Click(object sender, EventArgs e)
		{
			Cursor.Current = Cursors.WaitCursor;

			try
			{
				// rechercher si la demande existe dans la base EMALEC
				if (IdTaskPlanon != "")
				{
					MessageBox.Show($"Il y a déjà une demande avec ce numéro dans la base SamFM", MozartCS.Properties.Resources.Global_Erreur, MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
					return;
				}

				// confirmation de la creation de la demande
				if (MessageBox.Show("Etes-vous sûr de vouloir créer cette demande chez le client ?", Program.AppTitle, MessageBoxButtons.YesNo,
														MessageBoxIcon.Question, MessageBoxDefaultButton.Button2) != DialogResult.Yes)
				{
					return;
				}

				// API de creation de la demande sur SamFM
				string result = "";
				Uri url = new Uri($"{BASE_URL}/operations");

				// recherche des infos de la DI
				SqlDataReader red = ModuleData.ExecuteReader($"Select left([dbo].[GetActionTitle](NACTNUM),40) TITRE, VACTDES, NSITNUE FROM TACT " +
					$"INNER JOIN TSIT ON TSIT.NSITNUM=TACT.NSITNUM WHERE NACTNUM={NACTNUM}");

				if (red.Read())
				{

					Planon.OperationResponse WorkOrder = new Planon.OperationResponse
					{
						Code = $"DI{MozartParams.NumDi}",
						Label = red["TITRE"].ToString(),
						Detail = red["VACTDES"].ToString(),
						ActivityTypeId = 8,															// dépannage
						DomainId = 41,																	// TCE
						SiteId = Convert.ToInt32(red["NSITNUE"]),
						StatusId = 3,																		// En cours
						ExpectedDuration = Convert.ToDouble(strDuree) == 0 ? 1 : Convert.ToDouble(strDuree)
					};


					// creation de la demande
					if (!Planon.CallCreateWorkOrder(url, WorkOrder, ref result))
						throw new Exception($"{result}");

					LogInfo($"GMAO: {txtNumTask.Text},\tCreation de la demande sur SamFM avec le code DI{MozartParams.NumDi}, Action {NACTNUM}{Environment.NewLine}{Environment.NewLine}");
					txtResponse.Text = $"{txtResponse.Text}{Environment.NewLine}OK - création demande avec le code GMAO DI{MozartParams.NumDi}";
					strObservation = $"{strObservation}\r\nCréation de la demande dans SamFM";

					// mise à jour du champ gmao dans l'action
					strGMAO = $"DI{ MozartParams.NumDi}";

				}
				else
				{
					// pas d'info sur la DI, pas vraiment possible...
					txtResponse.Text = $"Erreur de récupération des infos de la DI";
				}
				red.Close();
			}
			catch (Exception ex)
			{
				LogInfo($"GMAO: {txtNumTask.Text},\tError: {ex.Message}{Environment.NewLine}{Environment.NewLine}{MozartCS.Properties.Resources.Global_dans}{MethodBase.GetCurrentMethod().Name}");
				txtResponse.Text = ex.Message;
			}

			Cursor.Current = Cursors.Default;
		}

	}
}
