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
	public partial class frmMenuGeronimmo : Form
	{
		private int NACTNUM;
		private string NumTaskGeronimmo;

		//const string BASE_URL = "https://www.sun-api-ppr.bpce.fr/EMALEC/task";
		const string BASE_URL = "https://www.sun-api.bpce.fr/EMALEC/task";

		public string strObservation = "";
		public string strRepImage = "";
		public string strRepAtt = "";


		List<List<string>> ListePJ;

		private frmMenuGeronimmo()
		{
			InitializeComponent();
		}

		public frmMenuGeronimmo(int numAction, string dateCreation, string datePlanification, string dateIntervention) : this()
		{
			NACTNUM = numAction;

			txtDateCreation.Text = dateCreation;
			txtDatePlanification.Text = datePlanification;
			txtDateIntervention.Text = dateIntervention;
		}

		private void frmMenuEmPlus_Load(object sender, EventArgs e)
		{
			ListePJ = new List<List<string>>();
			strObservation = "";
			txtResponse.Text = "";
			NumTaskGeronimmo = txtNumTask.Text = GetNumTask();
		}

		// -------------------------------------------------------------------------
		//
		// lors de la prise en charge on fait également l'accusé de réception 
		//
		// -------------------------------------------------------------------------
		private void btnCreateDi_Click(object sender, EventArgs e)
		{
			Cursor.Current = Cursors.WaitCursor;
			try
			{
				checkCommonParameters();

				if (string.IsNullOrEmpty(txtDateCreation.Text))
					throw new Exception("Invalid DateCreation");

				string result = "";
				Uri url = new Uri($"{BASE_URL}/update/updateTask");

				// Accusé de réception
				Geronimmo.GERONIMMO_UPDATE AR = new Geronimmo.GERONIMMO_UPDATE
				{
					u_number = NumTaskGeronimmo,
					u_action = "AR",
					u_external_reference = $"DI{MozartParams.NumDi}",
					u_maintainer_comment = "AR",
					u_end_date_of_intervention = "",
					u_effective_date_of_intervention = "",
					u_planned_date = ""
				};

				// envoi de l'AR
				if (!Geronimmo.CallUpdateTask(url, AR, ref result))
					throw new Exception($"{result}");

				LogInfo($"GMAO: {txtNumTask.Text},\tEnvoi de l'accusé de réception ({txtDateCreation.Text}), Action {NACTNUM}{Environment.NewLine}{Environment.NewLine}");
				txtResponse.Text = $"{txtResponse.Text}{Environment.NewLine}OK - Envoi de l'accusé de réception";

				// Prise en charge
				Geronimmo.GERONIMMO_UPDATE PEC = new Geronimmo.GERONIMMO_UPDATE
				{
					u_number = NumTaskGeronimmo,
					u_action = "PEC",
					u_external_reference = $"DI{MozartParams.NumDi}",
					u_maintainer_comment = "PEC",
					u_end_date_of_intervention = "",
					u_effective_date_of_intervention = "",
					u_planned_date = ""
				};
				// envoi de la prise en charge
				if (!Geronimmo.CallUpdateTask(url, PEC, ref result))
					throw new Exception($"{result}");

				LogInfo($"GMAO: {txtNumTask.Text},\tEnvoi de la prise en charge ({txtDateCreation.Text}), Action {NACTNUM}{Environment.NewLine}{Environment.NewLine}");
				txtResponse.Text = $"{txtResponse.Text}{Environment.NewLine}OK - Envoi de la prise en charge";
				strObservation = $"{strObservation}\r\nEnvoi de la prise en charge ({txtDateCreation.Text}) vers Sun Immo";

			}
			catch (Exception ex)
			{
				LogInfo($"GMAO: {txtNumTask.Text},\tError: {ex.Message}{Environment.NewLine}{Environment.NewLine}{MozartCS.Properties.Resources.Global_dans}{MethodBase.GetCurrentMethod().Name}");
				txtResponse.Text = ex.Message;
			}

			Cursor.Current = Cursors.Default;
		}

		// -------------------------------------------------------------------------
		private void btnSendDatePlanification_Click(object sender, EventArgs e)
		{
			Cursor.Current = Cursors.WaitCursor;

			try
			{
				checkCommonParameters();

				if (string.IsNullOrEmpty(txtDatePlanification.Text))
					throw new Exception("Date de planification non valide");

				string result = "";
				Uri url = new Uri($"{BASE_URL}/update/updateTask");

				// Planifiction
				Geronimmo.GERONIMMO_UPDATE PLANIF = new Geronimmo.GERONIMMO_UPDATE
				{
					u_number = NumTaskGeronimmo,
					u_action = "INTER1",
					u_effective_date_of_intervention = "",
					u_end_date_of_intervention = "",
					u_external_reference = $"DI{MozartParams.NumDi}",
					u_maintainer_comment = $"Intervention planifiée le {Convert.ToDateTime(txtDatePlanification.Text).ToString("dd/MM/yyyy HH:mm")}",
					u_planned_date = Convert.ToDateTime(txtDatePlanification.Text).ToString("dd/MM/yyyy HH:mm")
				};


				// envoi de la date de planification
				if (!Geronimmo.CallUpdateTask(url, PLANIF, ref result))
					throw new Exception($"{result}");

				LogInfo($"GMAO: {txtNumTask.Text},\tEnvoi de la date de planification ({txtDatePlanification.Text}), Action {NACTNUM}{Environment.NewLine}{Environment.NewLine}");
				txtResponse.Text = $"{txtResponse.Text}{Environment.NewLine}OK - Envoi de la date de planification de l'action";
				strObservation = $"{strObservation}\r\nEnvoi de la date de planification ({txtDatePlanification.Text}) vers Sun Immo";
			}
			catch (Exception ex)
			{
				LogInfo($"GMAO: {txtNumTask.Text},\tError: {ex.Message}{Environment.NewLine}{Environment.NewLine}{MozartCS.Properties.Resources.Global_dans}{MethodBase.GetCurrentMethod().Name}");
				txtResponse.Text = ex.Message;
			}

			Cursor.Current = Cursors.Default;
		}

		// -------------------------------------------------------------------------
		private void btnSendDateIntervention_Click(object sender, EventArgs e)
		{
			Cursor.Current = Cursors.WaitCursor;

			try
			{
				checkCommonParameters();

				if (string.IsNullOrEmpty(txtDateIntervention.Text))
					throw new Exception("Date d'exécution non valide");

				string result = "";
				Uri url = new Uri($"{BASE_URL}/update/updateTask");

				// exécution
				Geronimmo.GERONIMMO_UPDATE EXEC = new Geronimmo.GERONIMMO_UPDATE
				{
					u_number = NumTaskGeronimmo,
					u_action = "INTERREELLE",
					u_external_reference = $"DI{MozartParams.NumDi}",
					u_maintainer_comment = $"Intervention exécutée le {Convert.ToDateTime(txtDateIntervention.Text).ToString("dd/MM/yyyy HH:mm")}",
					u_effective_date_of_intervention = Convert.ToDateTime(txtDateIntervention.Text).ToString("dd/MM/yyyy HH:mm"),
					u_planned_date = "",
					u_end_date_of_intervention = ""
				};


				// envoi de la date d'exécution
				if (!Geronimmo.CallUpdateTask(url, EXEC, ref result))
					throw new Exception($"{result}");

				// garder le résultat de l'envoi de la date d'exécution
				LogInfo($"GMAO: {txtNumTask.Text},\tEnvoi de la date d'exécution ({txtDateIntervention.Text}), Action {NACTNUM}{Environment.NewLine}{Environment.NewLine}");
				strObservation = $"{strObservation}\r\nEnvoi de la date d'exécution ({txtDateIntervention.Text}) dans Sun Immo";
				txtResponse.Text = $"{txtResponse.Text}{Environment.NewLine}OK - Envoi de la date d'exécution de l'action";

			}
			catch (Exception ex)
			{
				LogInfo($"GMAO: {txtNumTask.Text},\tError: {ex.Message}{Environment.NewLine}{Environment.NewLine}{MozartCS.Properties.Resources.Global_dans}{MethodBase.GetCurrentMethod().Name}");
				txtResponse.Text = ex.Message;
			}

			Cursor.Current = Cursors.Default;
		}

		private void btnTerminer_Click(object sender, EventArgs e)
		{
			Cursor.Current = Cursors.WaitCursor;

			try
			{
				checkCommonParameters();

				string result = "";
				Uri url = new Uri($"{BASE_URL}/update/updateTask");

				// Planifiction
				Geronimmo.GERONIMMO_UPDATE FERMETURE = new Geronimmo.GERONIMMO_UPDATE
				{
					u_number = NumTaskGeronimmo,
					u_action = "FERMETURE",
					u_external_reference = $"DI{MozartParams.NumDi}",
					u_maintainer_comment = "Fermeture",
					u_end_date_of_intervention = DateTime.Now.ToString("dd/MM/yyyy HH:mm"),
					u_planned_date = "",
					u_effective_date_of_intervention = ""
				};


				// envoi de la date de planification
				if (!Geronimmo.CallUpdateTask(url, FERMETURE, ref result))
					throw new Exception($"{result}");

				LogInfo($"GMAO: {txtNumTask.Text},\tCloture de la demande, Action {NACTNUM}{Environment.NewLine}{Environment.NewLine}");
				txtResponse.Text = $"{txtResponse.Text}{Environment.NewLine}OK - Cloture de la demande";
				strObservation = $"{strObservation}\r\nCloture de la demande dans Sun Immo";
			}
			catch (Exception ex)
			{
				LogInfo($"GMAO: {txtNumTask.Text},\tError: {ex.Message}{Environment.NewLine}{Environment.NewLine}{MozartCS.Properties.Resources.Global_dans}{MethodBase.GetCurrentMethod().Name}");
				txtResponse.Text = ex.Message;
			}

			Cursor.Current = Cursors.Default;

		}

		// -------------------------------------------------------------------------
		private void btnSendPieceJointe_Click(object sender, EventArgs e)
		{
			Cursor.Current = Cursors.WaitCursor;

			try
			{
				checkCommonParameters();

				FileInfo fileInfo = GetAttachment();

				if (fileInfo == null)
					throw new Exception("Pas d'attachement sur l'action");

				// il faut copier l'attachement en local
				string filePath = CImpersonation.OpenFileImpersonated(fileInfo.FullName);
				string filename = Path.GetFileName(filePath);

				//string filePath = @"C:\temp\ChartImg.png";
				//string filename = "ChartImg.png";

				// Chemin du fichier à envoyer
				//string filePath = fileInfo.FullName;
				//string filename = fileInfo.Name;

				string result = "";
				Uri url = new Uri($"{BASE_URL}/write/attachment/addAttachment");

				if (NumTaskGeronimmo == "")
				{
					txtResponse.Text = "Il manque le numéro de la tache";
					return;
				}

				// envoi attachement
				if (!Geronimmo.CallSendDocument(NumTaskGeronimmo, url, filename, filePath, ref result))
					throw new Exception($"{result}");

				LogInfo($"GMAO: {txtNumTask.Text},\tEnvoi du document, Action {NACTNUM}{Environment.NewLine}{Environment.NewLine}");
				txtResponse.Text = $"{txtResponse.Text}{Environment.NewLine}OK - Envoi du document";
				strObservation = $"{strObservation}\r\nEnvoi du document";
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

				if (string.IsNullOrEmpty(txtDateCreation.Text))
					throw new Exception("Invalid DateCreation");

				string result = "";
				Uri url = new Uri($"{BASE_URL}/update/updateTask");

				if (FrameNote.Tag.ToString() == "SUSPENDRE")
				{
					// suspendre la demande
					Geronimmo.GERONIMMO_UPDATE SUSP = new Geronimmo.GERONIMMO_UPDATE
					{
						u_number = NumTaskGeronimmo,
						u_action = "SUSPENDUE",
						u_external_reference = $"DI{MozartParams.NumDi}",
						u_maintainer_comment = txtNote.Text,
						u_end_date_of_intervention = "",
						u_effective_date_of_intervention = "",
						u_planned_date = ""
					};

					// envoi du code de suspension
					if (!Geronimmo.CallUpdateTask(url, SUSP, ref result))
						throw new Exception($"{result}");

					LogInfo($"GMAO: {txtNumTask.Text},\tEnvoi du code de suspension de la demande, Action {NACTNUM}{Environment.NewLine}{Environment.NewLine}");
					txtResponse.Text = $"{txtResponse.Text}{Environment.NewLine}OK - Envoi du code SUSPENDRE";

					strObservation = $"{strObservation}\r\nEnvoi du code de suspension vers Sun Immo";
				}

				// il s'agit d'une note
				else
				{
					// envoyer une note d'information
					Geronimmo.GERONIMMO_UPDATE INFO = new Geronimmo.GERONIMMO_UPDATE
					{
						u_number = NumTaskGeronimmo,
						u_action = "INFO",
						u_external_reference = $"DI{MozartParams.NumDi}",
						u_maintainer_comment = txtNote.Text,
						u_end_date_of_intervention = "",
						u_effective_date_of_intervention = "",
						u_planned_date = ""
					};

					// envoi de la note
					if (!Geronimmo.CallUpdateTask(url, INFO, ref result))
						throw new Exception($"{result}");

					LogInfo($"GMAO: {txtNumTask.Text},\tEnvoi de commentaires sur une demande, Action {NACTNUM}{Environment.NewLine}{Environment.NewLine}");
					txtResponse.Text = $"{txtResponse.Text}{Environment.NewLine}OK - Envoi du message";

					strObservation = $"{strObservation}\r\nEnvoi d'un message vers Sun Immo";
				}

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
			MozartDatabase.ExecuteNonQuery($"Insert into TGERONIMMO_LOG (VLOGMSG) Values ('{message.Replace("'", "''")}')");
		}

		private FileInfo GetAttachment()
		{
			try
			{
				string sFile = "";
				string sRep = "";

				SqlCommand cmd = new SqlCommand($"Exec api_sp_GetFileAttachementByAction {NACTNUM}", MozartDatabase.cnxMozart);
				SqlDataReader dr = cmd.ExecuteReader();
				if (dr.Read())
				{
					sFile = dr["VFICHIER"].ToString();

					if (dr["VTYPE"].ToString() == "IMAGE")
					{
						sRep = ModuleData.ExecuteScalarString($"SELECT VPARVAL FROM TPAR WHERE VPARLIB = 'REP_PHOTOS_ACT' AND VSOCIETE = '{MozartParams.NomSociete}'");
					}
					else
					{
						sRep = ModuleData.ExecuteScalarString($"SELECT VPARVAL FROM TPAR WHERE VPARLIB = 'REP_ATTGAM' AND VSOCIETE = '{MozartParams.NomSociete}'");
					}


				}
				dr.Close();


				if (!string.IsNullOrEmpty(sFile))
				{

					LogInfo($"GMAO: {txtNumTask.Text}, \tSendFile Action: {NACTNUM}, Attachement: {sRep + sFile}");
					if (!File.Exists(sRep + sFile))
					{
						LogInfo($"GMAO: {txtNumTask.Text}, Error : Attachement {sFile} introuvable !");
						return null;
					}
					else
					{
						return new FileInfo(sRep + sFile);
					}
				}
			}
			catch (Exception ex)
			{
				LogInfo($"GMAO: {txtNumTask.Text},\tError: {ex.Message}{Environment.NewLine}{Environment.NewLine}{MozartCS.Properties.Resources.Global_dans}{MethodBase.GetCurrentMethod().Name}");
				MZUtils.displayError(MethodBase.GetCurrentMethod().Name, ex);
			}
			return null;
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

		private void btnSuspendre_Click(object sender, EventArgs e)
		{
			txtNote.Text = "";
			FrameNote.Tag = "SUSPENDRE";
			FrameNote.Visible = true;
		}

		private void btnSendNote_Click(object sender, EventArgs e)
		{
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

				//filePath = @"C:\temp\ChartImg.png";
				//filename = "ChartImg.png";
				//string filePath = fileInfo.FullName;
				//string filename = fileInfo.Name;

				string result = "";
				Uri url = new Uri($"{BASE_URL}/write/attachment/addAttachment");

				if (NumTaskGeronimmo == "")
				{
					txtResponse.Text = "Il manque le numéro de la tache";
					return;
				}

				// envoi attachement
				if (!Geronimmo.CallSendDocument(NumTaskGeronimmo, url, filename, filePath, ref result))
					throw new Exception($"{result}");

				txtResponse.Text = $"{txtResponse.Text}\r\nEnvoi du document ({filename}) dans Sun Immo ";
				strObservation = $"{strObservation}\r\nEnvoi du document ({filename}) dans Sun Immo ";

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

		private string GetNumTask()
		{

			string num = "";
			try
			{
				// recherche du numéro de tache
				num = ModuleData.ExecuteScalarString($"SELECT VGERO_Number FROM TDIGERONIMMO WHERE NACTNUM = {NACTNUM}");

				// si vide, alors recherche sur la première action de la DI
				if (num=="")
				{
					num = ModuleData.ExecuteScalarString($"SELECT VGERO_Number FROM TDIGERONIMMO WHERE NACTNUM = (" +
						$"SELECT TOP 1 NACTNUM FROM TACT WHERE NDINNUM = {MozartParams.NumDi} ORDER BY NACTID)");
				}

			}
			catch (Exception ex)
			{
				MZUtils.displayError(MethodBase.GetCurrentMethod().Name, ex);
			}

			return num;
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

		private void btnGetDI_Click(object sender, EventArgs e)
		{
			Cursor.Current = Cursors.WaitCursor;

			try
			{
				checkCommonParameters();

				string result = "";
				Uri url = new Uri($"{BASE_URL}/getList?sysparm_offset=1");


				if (!Geronimmo.GetDI(RestSharp.Method.GET, url))
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

	}
}
