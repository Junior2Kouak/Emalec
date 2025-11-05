using MozartCS.Menu;
using MozartLib;
using MozartNet;
using System;
using System.Data.SqlClient;
using System.Drawing;
using System.Drawing.Drawing2D;
using System.Reflection;
using System.Threading.Tasks;
using System.Web;
using System.Windows.Forms;
using MZUtils = MozartControls.Utils;

namespace MozartCS
{
	public partial class frmMenu : Form
	{
		private bool mBDroitsWorkFlowCommande;
		private bool mBDroitsWorkFlowDevis;
		public frmMenu() { InitializeComponent(); }

		private void frmMenu_Load(object sender, System.EventArgs e)
		{
			try
			{
				Cursor.Current = Cursors.WaitCursor;

				try
				{
					MozartCsUtils.SetDefaultWebBrowser();
				}
				catch (Exception ex)
				{
					// exception non fatale
					Console.WriteLine($"Echec SetDefaultWebBrowser.\r\n{ex.Message}");
				}

				try
				{

					if (System.Diagnostics.Debugger.IsAttached == false)
					{
						MozartCsUtils.VerifieVersion();
					}

				}
				catch (Exception ex)
				{
					// exception non fatale
					Console.WriteLine($"Echec MozartCsUtils.VerifieVersion.\r\n{ex.Message}");
				}

				string[] args = Environment.GetCommandLineArgs();
				string appParams = "";

				if (2 == args.Length)
				{
					appParams = args[1];
					// cas DELEGATION CF/CS
					if (appParams.EndsWith(";DELEGATION"))
						appParams = appParams.Replace(";DELEGATION", "");

					// cas DELEGATION CF/CS
					if (appParams.EndsWith(";DELEGATIONDEVIS"))
						appParams = appParams.Replace(";DELEGATIONDEVIS", "");
				}
				else
				{
					// on utilise les valeurs par défault
					appParams = "SRV-VMSQLPROD;EMALEC";
				}

				MozartParams.NumDeciWeb = 0;
				// MozartParams.Langue = "FR";

				//Version avec connexion par authentification Windows intégrée
				if (MozartCsUtils.ConnexionIntegree(appParams))
				{
					//  couleur et nom de la société
					Frame1.BackColor = this.BackColor = ModuleMain.Couleur(MozartParams.NomSociete);

					Label1.Text = MozartParams.GetNomSociete();
					ModuleMain.Initboutons(this);
					Frame1.Visible = mnuFichier.Visible = true;

					// enregistrement de l'imprimante windows par défault si ce n'est pas une fax ou une pdf
					// tache en arriere plan => accélère le load
					Task t = new Task(() => MozartParams.Printer = FindImprimantePapier());
					t.Start();
				}

				this.Text += "  -  MOZARIS " + Application.ProductVersion;

				gererWorkFlow();

				GereCodePageDemarrage();

				AfficheAccidentTrav();

				//affichage message web tech si nouveau
				AfficheNewMessageWebTech();

				// on affiche le procedure d'urgence
				if (AfficheProcUrgence())
					cmdProc.PerformClick();

			}
			catch (Exception ex)
			{
				MZUtils.displayError(MethodBase.GetCurrentMethod().Name, ex);
				Dispose();
			}
			finally { Cursor.Current = Cursors.Default; }
		}

		private void cmdDoc_Click(object sender, EventArgs e)
		{
			new frmAdminDoc().ShowDialog();
		}

		private void cmdOutils_Click(object sender, EventArgs e)
		{
			new frmAdminOutils().ShowDialog();
		}

		private void cmdCMD_Click(object sender, EventArgs e)
		{
			new frmAdminCdes().ShowDialog();
		}

		private void cmdReception_Click(object sender, EventArgs e)
		{
			Cursor.Current = Cursors.WaitCursor;
			new frmStockListeReceptions { mstrType = "ALL" }.ShowDialog();
			Cursor.Current = Cursors.Default;
		}

		private void cmdCourrier_Click(object sender, EventArgs e)
		{
			new frmListeCourrier().ShowDialog();
		}

		private void cmdAdmin_Click(object sender, EventArgs e)
		{
			//MozartUcUtils.SpyLog(MozartDatabase.cnxMozart, "", cmdAdmin.Tag.ToString(), "Entrée");
			new frmAdmin().ShowDialog();
		}

		private void cmdClient_Click(object sender, EventArgs e)
		{
			new frmListeClients().ShowDialog();
		}

		private void cmdDI2_Click(object sender, EventArgs e)
		{
			Cursor.Current = Cursors.WaitCursor;
			new frmListeDI2().ShowDialog();
			Cursor.Current = Cursors.Default;
		}

		private void cmdDeleg_Click(object sender, EventArgs e)
		{
			if (mBDroitsWorkFlowCommande && mBDroitsWorkFlowDevis)
			{
				new frmWorkFlowDelegation().ShowDialog();
				return;
			}

			if (mBDroitsWorkFlowCommande)
			{
				new frmListeDelegation().ShowDialog();
				return;
			}

			if (mBDroitsWorkFlowDevis)
			{
				new frmListeDelegationDevis().ShowDialog();
				return;
			}
		}

		// Gestion des droits du workflow commandes et devis
		private void gererWorkFlow()
		{
			mBDroitsWorkFlowCommande = (ModuleMain.bAccesBouton("272") != 0);
			mBDroitsWorkFlowDevis = (ModuleMain.bAccesBouton("705") != 0);

			// Titre du bouton selon droits
			if (mBDroitsWorkFlowCommande && mBDroitsWorkFlowDevis)
			{
				cmdDeleg.Text = "Workflow Commandes et Devis";
				cmdDeleg.Visible = true;
				return;
			}

			if (mBDroitsWorkFlowCommande)
			{
				cmdDeleg.Text = "Workflow Commandes";
				cmdDeleg.Visible = true;
				return;
			}

			if (mBDroitsWorkFlowDevis)
			{
				cmdDeleg.Text = "Workflow Devis";
				cmdDeleg.Visible = true;
				return;
			}

			// Aucun droit, on cache le bouton
			cmdDeleg.Visible = false;
		}

		private void cmdProc_Click(object sender, EventArgs e)
		{
			Cursor.Current = Cursors.WaitCursor;
			new FrmProcedureUrgence().ShowDialog();
			Cursor.Current = Cursors.Default;
		}

		private void Command1_Click(object sender, EventArgs e)
		{
			new frmGIDTAdmin().ShowDialog();
		}

		private void Command2_Click(object sender, EventArgs e)
		{
			new frmListeFactures2().ShowDialog();
		}

		private void cmdInfo_Click(object sender, EventArgs e)
		{
			new frmMenuInformatique().ShowDialog();
		}

		private void cmdFournisseur_Click(object sender, EventArgs e)
		{
			new frmListeFournisseurs().ShowDialog();
		}

		private void cmdPlanif_Click(object sender, EventArgs e)
		{
			new frmListePlanif().ShowDialog();
		}



		private void cmdRH_Click(object sender, EventArgs e)
		{
			new frmMenuAdminRH().ShowDialog();
		}

		private void cmdStat_Click(object sender, EventArgs e)
		{
			new frmStatistique().ShowDialog();
		}

		private void cmsST_Click(object sender, EventArgs e)
		{
			new frmListeSousTraitant().ShowDialog();
		}

		private void cmdSuivi_Click(object sender, EventArgs e)
		{
			new frmSuiviDI().ShowDialog();
		}

		private void cmdSaisie_Click(object sender, EventArgs e)
		{
			new frmSaisieKMhebdo { miNumAuto = 0 }.ShowDialog();
		}

		private void cmdStock_Click(object sender, EventArgs e)
		{
			new frmAdminStock().ShowDialog();
		}

		private void CmdCommercial_Click(object sender, EventArgs e)
		{
			Cursor.Current = Cursors.WaitCursor;
			new frmAdminCom().ShowDialog();
			Cursor.Current = Cursors.Default;
		}

		private void cmdRecru_Click(object sender, EventArgs e)
		{
			new frmGestRecrutement { mstrStatut = "O" }.ShowDialog();
		}

		private void cmdCompta_Click(object sender, EventArgs e)
		{
			new frmMenuCompta().ShowDialog();
		}

		private void cmdTrav_Click(object sender, EventArgs e)
		{
			Cursor.Current = Cursors.WaitCursor;
			new frmXListeWithChiffrage().ShowDialog();
			Cursor.Current = Cursors.Default;
		}

		private void frmMenu_FormClosed(object sender, FormClosedEventArgs e)
		{
			// deblock IMPRIM ECRAN
			// TODO UnhookKeyboard ?
		}
		//Private Sub Form_Unload(Cancel As Integer)
		//    
		//  On Error Resume Next
		//  cnx.Close
		//  'deblock IMPRIM ECRAN
		//  UnhookKeyboard
		//  
		//End Sub
		//
		/* --------------------------------------------------------------------------------------- */
		private void imgLangue_Click(object sender, EventArgs e) { }
		//Private Sub imgLangue_Click(Index As Integer)
		//  'gstrLangue = imgLangue(Index).Tag
		//'  If MsgBox("Attention, FERMEZ TOUS VOS MOZART, lors de la prochaine ouverture de Mozart, vous utiliserez la langue : " & imgLangue(Index).Tag & Chr(13) _
		//'          & "Attention, CLOSE ALL YOUR MOZART, at the next opening of Mozart you will use the language : " & imgLangue(Index).Tag & Chr(13) _
		//'            & "Attenzione, Chiudi tutte le MOZART, in occasione della prossima apertura di Mozart, si utilizza la lingua : " & imgLangue(Index).Tag & Chr(13) _
		//'            & "Aviso: Fecha os MOZART na próxima abertura de Mozart, você usa o idioma: " & imgLangue(Index).Tag & Chr(13) _
		//'            & "Atención, CIERRE A TODOS SUS MOZART, en el momento de la abertura próxima de Mozart, usted utilizará la lengua : " & imgLangue(Index).Tag, vbYesNo) = vbYes Then
		//'    cnx.Execute "UPDATE TPER SET VLANGUESYS = '" & imgLangue(Index).Tag & "' WHERE NPERNUM = " & gintUID
		//'  End If
		//End Sub

		private void aProposToolStripMenuItem_Click(object sender, EventArgs e)
		{
			new frmAbout().ShowDialog();
		}

		private void quitterToolStripMenuItem_Click(object sender, EventArgs e)
		{
			cmdQuitter.PerformClick();
		}

		private void Picture1_Click(object sender, EventArgs e)
		{
			new frmBrowser { msStartingAddress = "http://www.iddn.org" }.ShowDialog();
		}

		private void GereCodePageDemarrage()
		{
			switch (MozartParams.CodePageDemarrage)
			{
				case "DI":
					// Aller directement sur une DI depuis RAVEL(on récupère Di et action dans connexion integree)
					new frmAddAction { mstrStatutDI = "M" }.ShowDialog();
					return;// on ne fait rien d'autre si on vient de RAVEL

				case "frmDetailsSiteSTF":
					new frmDetailsSiteSTF
					{
						mstrStatut = "M",
						miNumSTFGRP = MozartParams.NumSTFGRP,
						miNumSTF = MozartParams.NumSTF
					}.ShowDialog();
					return;// on ne fait rien d'autre si on vient de RAVEL

				case "DELEGATION":
					// Aller directement sur délégation de commande si on viens du programme alerte
					Cursor.Current = Cursors.WaitCursor;
					new frmListeDelegation().ShowDialog();
					Cursor.Current = Cursors.Default;
					return;

				case "DELEGATIONDEVIS":
					// Aller directement sur délégation de devis si on viens du programme alerte
					Cursor.Current = Cursors.WaitCursor;
					new frmListeDelegationDevis().ShowDialog();
					Cursor.Current = Cursors.Default;
					return;

				case "CF":
					// Aller directement sur détail d'une commande
					new frmCommandeFournisseur
					{
						mstrStatutCommande = "M",
						miNumCommande = MozartParams.NumCom,
						mstrStatutAlerte = "OUI"
					}.ShowDialog();
					Dispose();
					break;

				case "CS":
					// Aller directement sur détail d'un contrat
					if (ContratAvecPrestation(MozartParams.NumCom))
					{
						new frmContratPrest
						{
							msTypeContrat = "P",
							mstrStatutContrat = "M",
							miNumContratST = MozartParams.NumCom,
							mstrStatutAlerte = "OUI",
							bDesactive = false            // on ne desactive pas les autres contrats de l'action
						}.ShowDialog();
					}
					else
					{
						new frmContratAutoST
						{
							msTypeContrat = "S",
							mstrStatutContrat = "M",
							mNumContratST = MozartParams.NumCom,
							mstrStatutAlerte = "OUI",
							mbDesactive = false            // on ne desactive pas les autres contrats de l'action
						}.ShowDialog();
					}
					Dispose();
					break;

				case "P":
					// Devis de prestation (type 'P')
					new frmDevisClientPrestation
					{
						//miNumDevisCL = MozartParams.NumCom, // Dans numcom, il y a le numéro du devis .....
						miNumAction = MozartParams.NumAction,
						mstrStatutAlerte = "OUI"
					}.ShowDialog();
					Dispose();
					break;

				case "G":
					//  Nouveaux devis : G (Validé)
					new frmDevisClient2
					{
						miNumDevisCL = MozartParams.NumCom, // Dans numcom, il y a le numéro du devis .....
						miNumDI = MozartParams.NumDi,
						miNumAction = MozartParams.NumAction,
						mstrStatutAlerte = "OUI"
					}.ShowDialog();
					Dispose();
					break;

				case "ACT":
					// Aller directement sur détail d'une action
					// écran de modification de l' action
					new frmDetailstravaux { mstrStatutAction = "M" }.ShowDialog();
					// on revient donc on réinitialise les variables globales
					MozartParams.NumDi = 0;
					MozartParams.NumAction = 0;
					return;

				case "ADD_DOC":
					// Aller directement sur l'ajout de document interne dans l'action
					using (SqlDataReader reader = ModuleData.ExecuteReader($"SELECT TACT.NDINNUM, TCLI.VCLINOM, TSIT.VSITNOM, TACT.VACTDES FROM TACT WITH (NOLOCK) INNER JOIN TSIT WITH (NOLOCK) ON TSIT.NSITNUM = TACT.NSITNUM INNER JOIN TCLI WITH (NOLOCK) ON TCLI.NCLINUM = TSIT.NCLINUM WHERE TACT.NACTNUM = {MozartParams.NumAction}"))
					{
						if (reader.Read())
						{
							new frmListActDoc
							{
								mstrVueWeb = "N",
								mstrTypeDoc = "Interne",
								mstrClient = Utils.BlankIfNull(reader["VCLINOM"]),
								mstrSite = Utils.BlankIfNull(reader["VSITNOM"]),
								mstrNumDI = Utils.BlankIfNull(reader["NDINNUM"]),
								mstrAction = Utils.BlankIfNull(reader["VACTDES"]),
								mlAction = MozartParams.NumAction
							}.ShowDialog();
						}
					}
					// on revient donc on réinitialise les variables globales
					MozartParams.NumDi = 0;
					MozartParams.NumAction = 0;
					return;

				default:
					break;
			}

			// saisie des km chaff
			int iVeh = ISaisieKm();
			if (iVeh != 0)
				new frmSaisieKMMensuelChaff
				{
					miNumVeh = iVeh,
					miPerNumChaff = MozartParams.UID
				}.ShowDialog();


			// affichage fenetre des dépannages en cours
			// fga le 26/12/23 demande de philippe
			//if (MozartCsUtils.NbProcessForCurrentUser() == 1 && NbDepannages() > 0)
			//  new frmSuiviDepannage().ShowDialog();

			// tableau des relances actions
			if (MozartCsUtils.NbProcessForCurrentUser() == 1 && MozartParams.TypePer != "TE")
			{
				using (SqlDataReader reader = ModuleData.ExecuteReader("exec api_sp_ExistRelanceTraitement"))
				{
					if (reader.Read())
						if ((int)Utils.ZeroIfNull(reader[0]) > 0)
							new frmListeDiRelance().ShowDialog();
				}
			}

			// tableau de visu des documents normes modifiés
			if (MozartParams.TypePer == "CA" && MozartParams.NomSociete == "EMALEC")
			{
				string lSql = $"select count(TFICHEADMVISU.NID) From TFICHEADMVISU inner join TFICHENORME on TFICHENORME.NID = TFICHEADMVISU.NID and TFICHENORME.CACTIF = 'O'";
				lSql += $"where CETAT='A' AND NPERNUM={MozartParams.UID} AND TFICHENORME.VSOCIETE='{MozartParams.NomSociete}'";
				using (SqlDataReader reader = MozartDatabase.ExecuteReader(lSql))
				{
					if (reader.Read())
						if ((int)Utils.ZeroIfNull(reader[0]) > 0)
							new frmGestVisuDocNorme().ShowDialog();
				}
			}

			if (MozartParams.strUID != "GIRAUD-BY")
			{
				System.Diagnostics.Process.Start(Environment.GetEnvironmentVariable("ProgramFiles(x86)") + @"\Mozart\AlerteDelegation.exe");




			}
		}

		// depuis modmain
		private string FindImprimantePapier()
		{
			// set de l'imprimante par défaut si non pdf ou fax
			if (!MyPrinter.DefaultPrinterName().ToUpper().Contains("PDF") &&
				!MyPrinter.DefaultPrinterName().ToUpper().Contains("FAX"))
				return MyPrinter.DefaultPrinterName();
			else
			{
				foreach (string prn in System.Drawing.Printing.PrinterSettings.InstalledPrinters)
				{
					if (!prn.ToUpper().Contains("PDF") && !prn.ToUpper().Contains("FAX"))
						return prn;
				}
			}
			return "";
		}

		//private int NbDepannages()
		//{
		//	using (SqlDataReader reader = ModuleData.ExecuteReader($"api_sp_DepannageEnCours {MozartParams.UID},'O'"))
		//	{
		//		if (reader.Read())
		//		{
		//			return (int)Utils.ZeroIfNull(reader[0]);
		//		}
		//	}
		//	return 0;
		//}

		// depuis modMain
		private bool ContratAvecPrestation(int NumContrat)
		{
			using (SqlDataReader sdr = ModuleData.ExecuteReader($"Select CCSTTYPE FROM TCST WHERE NCSTNUM= {NumContrat}"))
			{
				if (sdr.Read())
					return Utils.BlankIfNull(sdr["CCSTTYPE"]) == "P";
			}
			return false;
		}

		private int ISaisieKm()
		{
			// saisie des km seulement pour les chaff ou chaff adjoint qui ont un véhicule
			// modification FGA le 01/03/22 on a maintenant une coche sur le personnel pour appliquer cette fonctionnalité.
			using (SqlDataReader reader = ModuleData.ExecuteReader($"select BPERDEMANDEAUTOKMS, CPERTYP, CPERTYPDETAIL, NVEHNUM,DPERENT, TPER.NPERNUM from TPER LEFT OUTER JOIN TVEHICULES " +
																														 $" ON TPER.NPERNUM=TVEHICULES.NPERNUM  where TPER.NPERNUM = {MozartParams.UID} AND TPER.VSOCIETE <> 'EMALECFACILITEAM'"))
			{
				if (reader.Read() && Utils.ZeroIfNull(reader["BPERDEMANDEAUTOKMS"]) == 1)
				{
					DateTime dDate = new DateTime(DateTime.Today.AddMonths(-1).Year, DateTime.Today.AddMonths(-1).Month, 1);
					DateTime dDateFinMois = dDate.AddMonths(1);
					// on verifie que la personne soit déja entrée dans l'entreprise le mois dernier
					if (!Convert.IsDBNull(reader["DPERENT"]) && Convert.ToDateTime(reader["DPERENT"]) < dDateFinMois)
					{
						// on vérifie si il a déjà saisi des KM pour la période
						using (SqlDataReader reader2 = ModuleData.ExecuteReader($"SELECT * from TVEHKM WHERE NPERNUM = {MozartParams.UID} AND DVEHJOUR >= '{dDate}'"))
						{
							if (!reader2.Read())
								return (int)Utils.ZeroIfNull(reader["NVEHNUM"]);
						}
					}
				}
			}

			return 0;
		}

		private void AfficheAccidentTrav()
		{
			using (SqlDataReader reader = ModuleData.ExecuteReader($"EXEC [api_sp_Accident_Synthese] '{MozartParams.NomSociete}'"))
			{
				if (reader.Read())
				{
					PanelAccident.Visible = !Convert.IsDBNull(reader["DATE_MAX"]);
					LblNb_J_Sans_accident.Text = Utils.BlankIfNull(reader["NB_J_SANS_ACCIDENT"]);
					LblRecord.Text = Utils.BlankIfNull(reader["RECORD"]);
					Lbl_Nb_Accident_OnYear.Text = Utils.BlankIfNull(reader["NB_ACCIDENT"]);
				}
			}
		}

		private void AfficheNewMessageWebTech()
		{

			int NB_NEW_MSG = 0;
			using (SqlDataReader reader = ModuleData.ExecuteReader($"EXEC [api_sp_Msg_Personne_Get]"))
			{
				if (reader.Read())
				{
					NB_NEW_MSG = (int)reader["NB_NEW_MSG"];
				}
			}
			if (NB_NEW_MSG > 0)
			{
				C_CRYPTAGE oGenCrypt = new C_CRYPTAGE("password");

				//on affiche le message
				new frmBrowser
				{
					bPrintable = false,
					Text = "Nouveau message Web Technicien",
					msStartingAddress = $"https://tablets.emalec.com/MessageTechnicien.aspx?NPERNUM={HttpUtility.UrlEncode(oGenCrypt.AES_Encrypt("0"))}&VSOCIETE={MozartParams.NomSociete}"
				}.ShowDialog();


				//on mets à jour la lecture du message 
				ModuleData.ExecuteNonQuery("EXEC [api_sp_Msg_Personne_Lu]");
			}

		}

		private void frmMenu_Paint(object sender, PaintEventArgs e)
		{
			// ajout des lignes entre MOZARIS et SOCIETE
			using (Pen pen = new Pen(MozartColors.ColorHC000, 3))
			{
				//e.Graphics.DrawLine(pen, 248, 860, 640, 860);
				Point[] pts = { new Point(248,860),
												new Point(640,860),
												new Point(656,844),
												new Point(680,892),
												new Point(704,860),
												new Point(760,860)
											};
				GraphicsPath chemin = new GraphicsPath();
				chemin.AddLines(pts);
				e.Graphics.DrawPath(pen, chemin);
			}
		}

		private bool AfficheProcUrgence()
		{
			return (ModuleData.ExecuteScalarInt("EXEC [api_sp_AfficheProcUrgence_Get]") == 1);
		}

		private void frmMenu_FormClosing(object sender, FormClosingEventArgs e)
		{
			cmdQuitter_Click(sender, e);
		}

		private void cmdQuitter_Click(object sender, System.EventArgs e)
		{
			try
			{
				// fga le 26/12/23 demande de philippe
				//// alerte depannages pour assistant et chaff
				//if (MozartCsUtils.NbProcessForCurrentUser() == 2 && NbDepannages() > 0)
				//{
				//  new frmSuiviDepannage().ShowDialog();
				//}
				//// suppression des fichiers temp
				Utils.DeleteTemporaryFile();

			}
			catch (Exception ex)
			{
				MZUtils.displayError(MethodBase.GetCurrentMethod().Name, ex);
			}

			// TODO UnhookKeyboard ?

			Dispose();
		}

		private void BtnDashBoard_Click(object sender, EventArgs e)
		{

			frmDashBoard ofrmDashBoard = new frmDashBoard();
			ofrmDashBoard.Show(this);

		}

		private void cmdAutomobile_Click(object sender, EventArgs e)
		{
			Cursor.Current = Cursors.WaitCursor;
			new frmMenuFlotteAuto().ShowDialog();
			Cursor.Current = Cursors.Default;
		}
	}
}

