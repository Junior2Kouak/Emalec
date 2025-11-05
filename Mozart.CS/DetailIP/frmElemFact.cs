using MZCtrlResources = MozartControls.Properties.Resources;
using Microsoft.VisualBasic;
using MozartCS.Properties;
using MozartLib;
using MozartNet;
using System;
using System.Data;
using System.Data.SqlClient;
using System.Reflection;
using System.Windows.Forms;
using MZUtils = MozartControls.Utils;

namespace MozartCS
{
	public partial class frmElemFact : Form
	{

		public int miNumClient;
		public string mstrAction;
		public string mstrStatutAction;
		public string mstrSite;
		public string mstrPrestation;
		public int miNumSite;

		public bool mchkTE;
		public bool mchkTSite;

		DataTable dtFact = new DataTable();
		DataTable dtAct = new DataTable();

		public frmElemFact() { InitializeComponent(); }

		private void frmElemFact_Load(object sender, System.EventArgs e)
		{
			try
			{
				Cursor.Current = Cursors.WaitCursor;
				ModuleMain.Initboutons(this);

				InitialiserFeuille();
			}
			catch (Exception ex)
			{
				MZUtils.displayError(MethodBase.GetCurrentMethod().Name, ex);
			}
			finally { Cursor.Current = Cursors.Default; }
		}


		private void cmdNouveau_Click(object sender, EventArgs e)
		{
			if (ContratExistOnClient())
			{
				new frmNewElemFact
				{
					mstrAction = mstrAction,
					mstrStatutAction = mstrStatutAction,
					mstrSite = mstrSite,
					mstrPrestation = mstrPrestation,
					miNumSite = miNumSite,
					mchkTE = mchkTE,
					mchkTSite = mchkTSite,
					miNumElemFact = 0,
					miNumClient = miNumClient,
					mstrStatutElemFact = "C"
				}.ShowDialog();
			}

			//rafraichissement du recordset
			apiTgridElem.Requery(dtFact, MozartDatabase.cnxMozart);

			DataRow row = apiTgridElem.GetFocusedDataRow();
			if (row == null) return;
			InitialiserDonnees();
		}

		private void cmdModifier_Click(object sender, EventArgs e)
		{
			DataRow row = apiTgridElem.GetFocusedDataRow();
			if (row == null) return;

			//pas le droit de modifier si l'élément de facture est facturé
			if (Utils.BlankIfNull(row["VELFSTA"]) != "Chiffré")
			{
				MessageBox.Show(Resources.msg_Modifier_Element_Deja_Facture, Program.AppTitle, MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
				return;
			}

			new frmNewElemFact
			{
				miNumClient = miNumClient,
				miNumElemFact = (long)Utils.ZeroIfNull(row["NELFNUM"]),
				mstrStatutElemFact = "M"
			}.ShowDialog();

			//rafraichissement du recordset
			apiTgridElem.Requery(dtFact, MozartDatabase.cnxMozart);
			InitialiserDonnees();
		}

		private void cmdSupp_Click(object sender, EventArgs e)
		{
			DataRow row = apiTgridElem.GetFocusedDataRow();
			if (row == null) return;

			//pas le droit de supprimer si l'élément est facturé
			if (Utils.BlankIfNull(row["VELFSTA"]) != "Chiffré")
			{
				MessageBox.Show(Resources.msg_Suppression_Impossible_Element_Facture, Program.AppTitle, MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
				return;
			}

			if (MessageBox.Show(Resources.msg_Suppression_Chiffrage, Program.AppTitle, MessageBoxButtons.YesNo, MessageBoxIcon.Question, MessageBoxDefaultButton.Button2) != DialogResult.Yes)
				return;
			SupprimerChiffrage();

			//rafraichissement de l'affichage
			apiTGridAct.Requery(dtAct, MozartDatabase.cnxMozart);
			apiTgridElem.Requery(dtFact, MozartDatabase.cnxMozart);
		}

		private void cmdFact_Click(object sender, EventArgs e)
		{
			DataRow row = apiTgridElem.GetFocusedDataRow();
			if (row == null) return;

			if (Utils.ZeroIfNull(row["NELFTHT"]) < 0)
			{
				MessageBox.Show(Resources.msg_Chifrage_Negatif_Etre_Facture_Existe, Program.AppTitle, MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
				return;
			}

			if (IsLoad("frmNewFacture"))
			{
				MessageBox.Show(Resources.msg_Affichage_Fenetre_Creation_Facture_Impossible, Program.AppTitle, MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
				return;
			}

			new frmNewFacture
			{
				miNumDi = Convert.ToInt32(Strings.Mid(Utils.BlankIfNull(row["ndinnum"]), 3, 7)),
				strStatutOuverture = "S"
			}.ShowDialog();

			apiTgridElem.Requery(dtFact, MozartDatabase.cnxMozart);
		}

		private bool IsLoad(string frmName)
		{
			foreach (Form frm in Application.OpenForms)
			{
				if (frmName == frm.Name)
					return true;
			}
			return false;
		}

		private void cmdDetails_Click(object sender, EventArgs e)
		{
			DataRow row = apiTgridElem.GetFocusedDataRow();
			if (row == null) return;

			//passage du NumElemFact sélectionné
			new frmFactDetFour
			{
				miNumElemFact = (int)Utils.ZeroIfNull(row["NELFNUM"]),
			}.ShowDialog();
		}

		private void apiTgridElem_SelectionChanged(object sender, DevExpress.Data.SelectionChangedEventArgs e)
		{
			DataRow row = apiTgridElem.GetFocusedDataRow();
			if (row == null) return;

			InitialiserDonnees();
		}

		private void SupprimerChiffrage()
		{
			//suppression de l'element de facturation
			DataRow row = apiTgridElem.GetFocusedDataRow();
			if (row == null) return;

			//creation d'une commande
			using (SqlCommand cmd = new SqlCommand("api_sp_SupprimerChiffrage", MozartDatabase.cnxMozart))
			{
				//passage du nom de la procédure stockée
				cmd.CommandType = CommandType.StoredProcedure;
				SqlCommandBuilder.DeriveParameters(cmd);

				//liste des paramètres
				cmd.Parameters["@iNumElemFact"].Value = Utils.BlankIfNull(row["NELFNUM"]);

				//exécuter la commande
				cmd.ExecuteNonQuery();
			}
		}

		private void CmdVisu_Click(object sender, EventArgs e)
		{
			DataRow row = apiTgridElem.GetFocusedDataRow();
			if (null == row) return;

			string[,] TdbGlobal = { { "COPIE", "ORIGINAL" } };

			if (Utils.BlankIfNull(row["CELFTYP"]) == "AV")
			{

				CreationFicher(MozartParams.CheminModeles + ModuleMain.CodePays(Utils.BlankIfNull(row["VCLIPAYS"])) + "TChiffrageClientPrestationAvancement.rtf",
											"/TFactureClientOut_TEMP.rtf", TdbGlobal, $"exec api_sp_ImpChiffragePrestationAvancement {(int)Utils.ZeroIfNull(row["NELFNUM"])}",
											" (Visualisation facture)");

				new frmBrowser
				{
					miPlanningAn = 0
				}.Preview_Print(
					$"{MozartParams.CheminUtilisateurMozart}TFactureClientOut_TEMP.rtf",
					"TFactureClientOut.rtf",
					TdbGlobal,
					$"exec api_sp_impChiffragePrestationAvancementSynt {(int)Utils.ZeroIfNull(row["NELFNUM"])}",
					" (Visualisation facture)",
					"PREVIEW"
				);
			}
		}

		private void InitialiserFeuille()
		{
			//recherche des éléments de facturation de la di sélectionnée
			apiTgridElem.LoadData(dtFact, MozartDatabase.cnxMozart, $"exec api_sp_listeElemFactDi {MozartParams.NumDi}");

			//liaison du recordset et du datagrid
			apiTgridElem.GridControl.DataSource = dtFact;

			//mise en page du datagrid
			FormatGrid();

			DataRow row = apiTgridElem.GetFocusedDataRow();
			if (row == null) return;

			//recherche des actions de cette facture
			//ouverture du recordset des actions
			apiTGridAct.LoadData(dtAct, MozartDatabase.cnxMozart, $"exec api_sp_listeActionElemFactDi {MozartParams.NumDi}, {(int)Utils.ZeroIfNull(row["NELFNUM"])}");

			//liaison du recordset et du datagrid
			apiTGridAct.GridControl.DataSource = dtAct;

			//mise en forme la liste des actionsdtF
			FormatGridAction();

			//si on a des enregistrements
			InitialiserDonnees();
			if (Utils.BlankIfNull(row["CELFTYP"]) == "AV")
			{
				cmdVisu.Visible = true;
			}
		}

		private void InitialiserDonnees()
		{
			DataRow rowF = apiTgridElem.GetFocusedDataRow();
			if (rowF == null) return;

			//mise à jour des contrôles
			txtFact0.Text = Utils.BlankIfNull(rowF["NELFDEP"]);
			txtFact1.Text = $"{Utils.BlankIfNull(rowF["NELFFOR"])} €";
			txtFact2.Text = String.Format(System.Globalization.CultureInfo.InvariantCulture, "{0:0.##}", Utils.ZeroIfBlank(rowF["NELFHEU"])); //Gestion de l'affichage du nombre décimal
			txtFact3.Text = Utils.BlankIfNull(rowF["TELFOBS"]);
			txtFact4.Text = $"{Utils.BlankIfNull(rowF["NELFFOU"])} €";
			txtFact5.Text = $"{Utils.BlankIfNull(rowF["NELFTDE"])} €";
			txtFact6.Text = $"{Utils.BlankIfNull(rowF["NELFTHO"])} €";

			//type de facture
			if (Utils.BlankIfNull(rowF["CELFTYP"]) == "DC")
			{
				txtFact0.Visible = true;
				txtFact2.Visible = true;
				txtFact5.Visible = true;
				txtFact6.Visible = true;
				txtFact1.Visible = false;
				lblLabels0.Visible = true;
				lblLabels6.Visible = true;
				lblLabels7.Visible = true;
				lblLabels1.Visible = true;
				lblLabels5.Visible = false;

				//MPM
				if (MozartParams.NomSociete == "EMALECMPM")
				{
					FrameMPM.Visible = true;
					txtNbrNuit.Text = Utils.BlankIfNull(rowF["NELFNUIT"]);
					txtNbrRepas.Text = Utils.BlankIfNull(rowF["NELFREPAS"]);
					txtNbrKm.Text = Utils.BlankIfNull(rowF["NELFKM"]);
					txtTNuit.Text = Utils.BlankIfNull(rowF["NELFTNUIT"]);
					txtTRepas.Text = Utils.BlankIfNull(rowF["NELFTREPAS"]);
					txtTKm.Text = Utils.BlankIfNull(rowF["NELFTKM"]);
				}
			}
			else
			{
				txtFact0.Visible = false;
				txtFact2.Visible = false;
				txtFact5.Visible = false;
				txtFact6.Visible = false;
				txtFact1.Visible = true;
				lblLabels0.Visible = false;
				lblLabels6.Visible = false;
				lblLabels7.Visible = false;
				lblLabels1.Visible = false;
				lblLabels5.Visible = true;
			}

			//type de fourniture
			if (Utils.BlankIfNull(rowF["CELFTFO"]) == "D")
			{
				optFour0.Checked = true;
				cmdDetails.Visible = true;
			}
			else
			{
				optFour1.Checked = true;
				cmdDetails.Visible = false;
			}

			//mise en page du datagrid
			apiTGridAct.LoadData(dtAct, MozartDatabase.cnxMozart, $"exec api_sp_listeActionElemFactDi {MozartParams.NumDi}, {(int)Utils.ZeroIfNull(rowF["NELFNUM"])}");
		}

		private void cmdFermer_Click(object sender, System.EventArgs e)
		{
			Dispose();
		}

		private void FormatGrid()
		{
			apiTgridElem.AddColumn("Num", "NELFNUM", 900);
			apiTgridElem.AddColumn("DI", "NDINNUM", 1300);
			apiTgridElem.AddColumn(Resources.col_Date, "DELFDPR", 1000, "dd/mm/yy");
			apiTgridElem.AddColumn(MZCtrlResources.col_Client, "VCLINOM", 2500);
			apiTgridElem.AddColumn(Resources.col_Site, "VSITNOM", 2500);
			apiTgridElem.AddColumn(Resources.col_etat, "VELFSTA", 1000);
			apiTgridElem.AddColumn(Resources.col_dateEd, "DELFDED", 1000, "dd/mm/yy");
			apiTgridElem.AddColumn(Resources.txt_Tot_HT, "NELFTHT", 1300, "Currency", 2);
			apiTgridElem.AddColumn("TVA", "NELFTVA", 600, "0.#", 2);
			apiTgridElem.AddColumn(Resources.col_Observ, "TELFOBS", 0);
			apiTgridElem.AddColumn(Resources.col_Forfait, "NELFOR", 0);
			apiTgridElem.AddColumn(Resources.col_Depl, "NELFDEP", 0);
			apiTgridElem.AddColumn(Resources.col_TauxDep, "NELFTDE", 0);
			apiTgridElem.AddColumn(Resources.col_TauxHeur, "NELFTHO", 0);
			apiTgridElem.AddColumn(Resources.col_Heur, "NELFHEU", 0);
			apiTgridElem.AddColumn(Resources.col_four, "NELFOU", 0);
			apiTgridElem.AddColumn(Resources.col_TypeFour, "CELFTFO", 0);
			apiTgridElem.AddColumn("NumCli", "NCLINUM", 0);
			apiTgridElem.AddColumn("NumSit", "NSITNUM", 0);
			apiTgridElem.AddColumn(Resources.col_TypeFact, "CDINTYF", 0);
			apiTgridElem.AddColumn(Resources.col_TypeFact, "CELFTYP", 0);
			apiTgridElem.AddColumn("pays", "VCLIPAYS", 0);

			apiTgridElem.InitColumnList();
		}

		private void FormatGridAction()
		{
			apiTGridAct.AddColumn("", "NACTNUM", 0);
			apiTGridAct.AddColumn(Resources.col_Action, "VACTDES", 5000);
			apiTGridAct.AddColumn(Resources.col_dateEx, "DACTDEX", 1000);
			apiTGridAct.AddColumn(Resources.col_Site, "VSITNOM", 1700);
			apiTGridAct.AddColumn(Resources.col_Inter, "VACTINT", 1700);
			apiTGridAct.AddColumn(Resources.col_etat, "CETACOD", 500);
			apiTGridAct.AddColumn(Resources.col_Observation, "VACTOBS", 4000);

			apiTGridAct.FilterBar = false;

			apiTGridAct.InitColumnList();
		}

		private bool ContratExistOnClient()
		{
			try
			{
				using (SqlDataReader dr = ModuleData.ExecuteReader($"exec api_sp_ContratExistOnClient {MozartParams.NumDi}"))
				{
					if (dr.Read())
					{
						if (Utils.ZeroIfNull(dr["NB"]) > 0)
							return true;
						else
						{
							MessageBox.Show("Le contrat de la DI n'est plus affecté au client !", "Erreur creation chiffrage", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
							return false;
						}
					}
					else
					{
						MessageBox.Show("Le contrat de la DI n'est plus affecté au client !", "Erreur creation chiffrage", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
						return false;
					}
				}
			}
			catch (Exception ex)
			{
				Utils.ShowException(ex, MethodBase.GetCurrentMethod().Name, ex.StackTrace);
			}
			return true;
		}

		private void CmdAddFoVeh_Click(object sender, EventArgs e)
		{
			new frmChiffrageEntreeStockVehTech(MozartParams.NumDi).ShowDialog();
		}

		private void CreationFicher(string strFileIn, string strFileOut, string[,] tGlobal, string strSQL, string strErreur)
		{
			try
			{
				//   ' instanciation de l'objet
				ADODB.Connection cnxVisu;

				//' affichage curseur
				Cursor.Current = Cursors.WaitCursor;
				//  ' affectation de la connexion
				cnxVisu = new ADODB.Connection
				{
					ConnectionString = $"Provider=SQLOLEDB.1;Data Source={MozartParams.NomServeur};Initial Catalog=MULTI;trusted_connection=yes;APP={MozartParams.NomSociete}",
					CursorLocation = ADODB.CursorLocationEnum.adUseClientBatch
				};
				cnxVisu.Open();

				GenEtat objGenEtat = new GenEtat();

				//' génération du fichier
				string strFileOutLong = MozartParams.CheminUtilisateurMozart + strFileOut;
				long ret = objGenEtat.MkRTF(strFileIn, strFileOutLong, strSQL, ref cnxVisu, tGlobal);

				cnxVisu.Close();

				//    ' si erreur, on kill le processus word et on relance genetat
				if (ret > 0)
					MessageBox.Show(strErreur + "\r\n\r\n\t" + objGenEtat.ReturnError(ret), "Error GenEtat");
			}
			catch (Exception ex)
			{
				MZUtils.displayError(MethodBase.GetCurrentMethod().Name, ex);
			}
			finally { Cursor.Current = Cursors.Default; }
		}

		private void cmdAvoir_Click(object sender, EventArgs e)
		{
			DataRow row = apiTgridElem.GetFocusedDataRow();
			if (row == null) return;

			try
			{
				if (IsLoad("frmNewFacture"))
				{
					MessageBox.Show(Resources.msg_Affichage_Fenetre_Creation_Facture_Impossible, Program.AppTitle, MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
					return;
				}

				if (Utils.BlankIfNull(row["VELFSTA"]) != "Chiffré")
				{
					MessageBox.Show("Ce chiffrage ne peut pas être utilisé pour faire un Avoir", Program.AppTitle, MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
					return;
				}

				if (MessageBox.Show("Voulez-vous créer l'Avoir sur ce chiffrage ?", Program.AppTitle, MessageBoxButtons.YesNo, MessageBoxIcon.Question, MessageBoxDefaultButton.Button2) != DialogResult.Yes)
					return;

				// proc de création de l'Avoir
				using (SqlCommand cmd = new SqlCommand("api_sp_CreationAvoirAlone", MozartDatabase.cnxMozart))
				{
					cmd.CommandType = CommandType.StoredProcedure;
					SqlCommandBuilder.DeriveParameters(cmd);

					cmd.Parameters["@iNumAvoir"].Value = 0;
					cmd.Parameters["@iNumELF"].Value = row["NELFNUM"];
					cmd.Parameters["@tObj"].Value = "";
					cmd.Parameters["@tLib"].Value = "";
					cmd.Parameters["@nTHT"].Value = row["NELFTHT"];

					cmd.ExecuteNonQuery();
				}

				// mise à jour page
				apiTgridElem.Requery(dtFact, MozartDatabase.cnxMozart);

			}

			catch (Exception ex)
			{
				MZUtils.displayError(MethodBase.GetCurrentMethod().Name, ex);
			}
			finally { Cursor.Current = Cursors.Default; }

		}
	}
}

