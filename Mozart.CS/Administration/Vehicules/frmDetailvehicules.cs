using MozartCS.Properties;
using MozartLib;
using MozartNet;
using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Reflection;
using System.Windows.Forms;
using MZUtils = MozartControls.Utils;
using MZCtrlResources = MozartControls.Properties.Resources;

namespace MozartCS
{
	public partial class frmDetailvehicules : Form
	{
		public int miNumVehicule;
		public string mstrSociete;
		public string mstrStatut;


		DataTable dtdepense = new DataTable();
		DataTable dtEntretien = new DataTable();

		DataTable dtAffectation = new DataTable();
		DataTable dtEquipement = new DataTable();
		DataTable dtSinistre = new DataTable();

		bool bGridOk = false;


		public frmDetailvehicules() { InitializeComponent(); }

		private void frmDetailPersonnel_Load(object sender, System.EventArgs e)
		{
			try
			{
				ModuleMain.Initboutons(this);

				// chargement de toutes les combos
				ModuleData.RemplirCombo(cboSociete, $"SELECT DISTINCT VSOCIETE FROM TDROIT D INNER JOIN TSOCIETE S ON S.VSOCIETENOM = D.VSOCIETE " +
																						$"WHERE NPERNUM={MozartParams.UID} AND NMENUNUM={cboSociete.Tag} " +
																						$"AND CDROITVAL = 'O' AND VSOCIETEACTIF='O' ORDER BY VSOCIETE", true);
				cboSociete.ValueMember = "VSOCIETE";
				cboSociete.DisplayMember = "VSOCIETE";


				ModuleData.RemplirCombo(cboEtat, "select ID, VETALIB from TREF_VEHETA");
				cboEtat.ValueMember = "ID";
				cboEtat.DisplayMember = "VETALIB";

				ModuleData.RemplirCombo(cboMarque, "select distinct VVEHMARQUE from TREF_VEHICULES Order By VVEHMARQUE");
				cboMarque.ValueMember = "VVEHMARQUE";
				cboMarque.DisplayMember = "VVEHMARQUE";

				ModuleData.RemplirCombo(cboModele, "select distinct VVEHMODELE from TREF_VEHICULES Order By VVEHMODELE");
				cboModele.ValueMember = "VVEHMODELE";
				cboModele.DisplayMember = "VVEHMODELE";

				ModuleData.RemplirCombo(cboAmenagement, "exec [api_sp_comboAmenagementVehicule]");
				cboAmenagement.ValueMember = "LIBELLE";
				cboAmenagement.DisplayMember = "LIBELLE";

				// GPS
				//If((New List(Of Integer) From { 30, 2762, 5026}).Contains(MozartParams.UID)) Then

				if (MozartParams.UID == 30)
				{

					cboGPS.Visible = true;
					cmdGPS.Visible = true;

					//chargement liste des gps disponibles
					cboGPS.Init(MozartDatabase.cnxMozart, "select ntelnum, vtelmat from ttel where vtelprofil = 'Geolocalisation' and vtelmat<>'' and vtelmat not in (select vvehngps from TVEHICULES where VVEHNGPS<> '') order by vtelmat",
										 "ntelnum", "vtelmat", new List<string>() { Resources.col_ID, Resources.col_Num }, 300, 300, bHideFirstColumn: true);
				}


				//// traitement du cas de modification ou de création
				if (mstrStatut == "C")
					OuvertureEnCreation();
				else
					OuvertureEnModification();

				Cursor = Cursors.Default;
			}
			catch (Exception ex)
			{
				MZUtils.displayError(MethodBase.GetCurrentMethod().Name, ex);
			}
		}

		private void cmdEnregistrer_Click(object sender, EventArgs e)
		{
			try
			{
				//champs obligatoires
				//if (txtDateCommande.Text == "")
				//{
				//	MessageBox.Show("Date de commande obligatoire", Program.AppTitle, MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
				//	return;
				//}
				if (txtImmat.Text == "")
				{
					MessageBox.Show("Saisissez une immatriculation", Program.AppTitle, MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
					txtImmat.Focus();
					return;
				}
				if (null == cboSociete.SelectedItem || cboSociete.SelectedItem.ToString() == "")
				{
					MessageBox.Show("Saisissez la société", Program.AppTitle, MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
					cboSociete.Focus();
					return;
				}
				//if (apiComboRegion.GetText() == "")
				//{
				//  MessageBox.Show("Saisissez la région de la personne", Program.AppTitle, MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
				//  apiComboRegion.Focus();
				//  return;
				//}
				if (txtDateEntre.Text == "")
				{
					MessageBox.Show(Resources.msg_saisirDateEntree, Program.AppTitle, MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
					txtDateEntre.Focus();
					return;
				}

				Enregistrer();

				// on passe la feuille en statut modifier
				mstrStatut = "M";

				OuvertureEnModification();

			}
			catch (Exception ex)
			{
				MZUtils.displayError(MethodBase.GetCurrentMethod().Name, ex);
			}
		}


		private void OuvertureEnCreation()
		{
			try
			{
				cboSociete.SetItemData("1");
			}
			catch (Exception ex)
			{
				MZUtils.displayError(MethodBase.GetCurrentMethod().Name, ex);
			}
		}

		private void OuvertureEnModification()
		{
			try
			{
				using (SqlDataReader dr = ModuleData.ExecuteReader($"exec api_sp_InfoVehicule2 {miNumVehicule}"))
				{
					if (dr.Read())
					{
						// immatriculation
						txtImmat.Text = Utils.BlankIfNull(dr["VVEHIMAT"]);

						// panel1
						cboSociete.Text = (Utils.BlankIfNull(dr["VSOCIETE"]).ToString());
						cboEtat.Text = Utils.BlankIfNull(dr["VETATLIB"]);
						if (dr["DVEHDENTRE"] != DBNull.Value) txtDateEntre.DateTime = (DateTime)dr["DVEHDENTRE"];
						if (dr["DVEHDSORTI"] != DBNull.Value) txtDateSortie.DateTime = (DateTime)dr["DVEHDSORTI"];
						if (dr["DVEHCOMMANDE"] != DBNull.Value) txtDateCommande.DateTime = (DateTime)dr["DVEHCOMMANDE"];
						cboRoulage1.Text = Utils.BlankIfNull(dr["NVEHROULAGEMOIS"]);
						cboRoulage2.Text = Utils.BlankIfNull(dr["NVEHROULAGEKM"]);
						cboGestionnaire.Text = Utils.BlankIfNull(dr["VVEHGESTIONNAIRE"]);
						TxtNumVehicule.Text = Utils.BlankIfNull(dr["NVEHNUM"]);
						txtNumDI.Text = Utils.BlankIfNull(dr["NDINNUM"]);
						ChkPool.Checked = dr["CVEHPOOL"].ToString() == "O" ? true : false;

						//panel2
						cboCategorie.Text = Utils.BlankIfNull(dr["VVEHCATEGORIE"]);
						cboMarque.Text = Utils.BlankIfNull(dr["VVEHMARQUE"]);
						cboModele.Text = Utils.BlankIfNull(dr["VVEHTYPE"]);
						cboCarburant.Text = Utils.BlankIfNull(dr["VVEHCARBU2"]);
						cboPlaces.Text = Utils.BlankIfNull(dr["VNBPLACES"]);
						txtTaillePneu.Text = Utils.BlankIfNull(dr["VVEHTPNEU"]);
						txtPneu.Text = Utils.BlankIfNull(dr["VVEHTYPEPNEU"]);
						cboAmenagement.Text = Utils.BlankIfNull(dr["VVEHAMENAGEMENT"]);

						//pane3
						txtKMini.Text = Utils.BlankIfNull(dr["NVEHINITKM"]);
						txtKMcours.Text = Utils.BlankIfNull(dr["NVEHDERKM"]);
						if (dr["DVEHDCTRL"] != DBNull.Value) txtDateCtrl.DateTime = (DateTime)dr["DVEHDCTRL"];
						if (dr["DVEHCTRLPOL"] != DBNull.Value) txtDateCtrlPol.DateTime = (DateTime)dr["DVEHCTRLPOL"];
						if (dr["DVEHCIRCU"] != DBNull.Value) txtDateMEC.DateTime = (DateTime)dr["DVEHCIRCU"];
						txtNumSerie.Text = Utils.BlankIfNull(dr["VVEHNSERIE"]);
						txtCarteGrise.Text = Utils.BlankIfNull(dr["VVEHCERTIFIMMAT"]);
						cboFiscal.Text = Utils.BlankIfNull(dr["VVEHFISCAL"]);
						cboCRITAIR.Text = Utils.BlankIfNull(dr["VVEHCRITAIR"]);

						//pane4
						cboERmois.Text = Utils.BlankIfNull(dr["NVEHREVMOIS"]);
						cboERkms.Text = Utils.BlankIfNull(dr["NVEHREVKM"]);
						cboEKmois.Text = Utils.BlankIfNull(dr["NVEHKITMOIS"]);
						cboEKkms.Text = Utils.BlankIfNull(dr["NVEHKITKM"]);

						//panel GPS
						txtObservations.Text = Utils.BlankIfNull(dr["VVEHOBS"]);
						txtNumGPS.Text = Utils.BlankIfNull(dr["VVEHNGPS"]);
						if (dr["DVEHINSTGPS"] != DBNull.Value) txtDateGPS.DateTime = (DateTime)dr["DVEHINSTGPS"];
						txtCO2.EditValue = dr["NVEHGCO2"] != DBNull.Value ? dr["NVEHGCO2"].ToString() : "0";
						
						// panel Recap
						lblDate.Text = Utils.BlankIfNull(dr["DVEHSE"]);
						switch (Utils.BlankIfNull(dr["CODEDATE"]))
						{
							case "Red":
								lblDate.BackColor = Color.Red;
								break;
							case "Green":
								lblDate.BackColor = Color.Green;
								break;
							case "Orange":
								lblDate.BackColor = Color.Orange;
								break;
							default:
								break;
						}
						lblKM.Text = txtKMcours.Text + " Kms";
						switch (Utils.BlankIfNull(dr["CODEKM"]))
						{
							case "Red":
								lblKM.BackColor = Color.Red;
								break;
							case "Green":
								lblKM.BackColor = Color.Green;
								break;
							case "Orange":
								lblKM.BackColor = Color.Orange;
								break;
							default:
								break;
						}

						// Remplir les grilles
						ChargerListeDepenses();
						ChargerListeEntretiens();
						ChargerListeAffectations();
						ChargerListeEquipements();
						ChargerListeSinistres();

						if (bGridOk == false)
						{
							FormatGridDepenses();
							FormatGridEntretiens();
							FormatGridAffectations();
							FormatGridEquipements();
							FormatGridSinistres();
							bGridOk = true;
						}

					}
				}
			}
			catch (Exception ex)
			{
				MZUtils.displayError(MethodBase.GetCurrentMethod().Name, ex);
			}
		}

		public void ChargerListeDepenses()
		{
			// Remplir la grille Entretiens
			try
			{
				dtdepense.Clear();
				grdDepense.LoadData(dtdepense, MozartDatabase.cnxMozart, $"exec [api_sp_ListeDepenseVehicule] {miNumVehicule}");
				grdDepense.GridControl.DataSource = dtdepense;

				// affichage du PRK
				// test si quelquechose dans dt
				if (dtdepense == null || dtdepense.Rows.Count == 0 || dtdepense.Rows[0][2].ToString() == "")
				{
					// Le DataTable est vide
					lblPRK.Text = "";
				}
				else
				{

					double PRK = Convert.ToDouble(dtdepense.Rows[0][2]);

					lblPRK.Text = PRK.ToString() + " € HT / km";
					if (PRK >= 1)
					{
						lblPRK.BackColor = Color.Red;
					}
					else if (PRK < 0.5)
					{
						lblPRK.BackColor = Color.Green;
					}
					else
					{
						lblPRK.BackColor = Color.Orange;
					}
				}
			}
			catch (Exception ex)
			{
				MZUtils.displayError(MethodBase.GetCurrentMethod().Name, ex);
			}

		}

		public void ChargerListeEntretiens()
		{
			// Remplir la grille Entretiens
			try
			{
				string sSQL = $"SELECT * FROM TAUTOREV WHERE NVEHNUM = {miNumVehicule} ORDER BY DREVIDATE";
				dtEntretien.Clear();
				grdEntretien.LoadData(dtEntretien, MozartDatabase.cnxMozart, sSQL);
				grdEntretien.GridControl.DataSource = dtEntretien;
			}
			catch (Exception ex)
			{
				MZUtils.displayError(MethodBase.GetCurrentMethod().Name, ex);
			}

		}

		public void ChargerListeEquipements()
		{
			try
			{
				string sSQL = $"SELECT * FROM TAUTOEQUIP WHERE NVEHNUM = {miNumVehicule} ORDER BY DEQUIPDDEB";
				dtEquipement.Clear();
				grdEquipement.LoadData(dtEquipement, MozartDatabase.cnxMozart, sSQL);
				grdEquipement.GridControl.DataSource = dtEquipement;
			}
			catch (Exception ex)
			{
				MZUtils.displayError(MethodBase.GetCurrentMethod().Name, ex);
			}
		}

		public bool NewAffectationOk()
		{
			try
			{
				int Row = MozartDatabase.ExecuteScalarInt($"SELECT COUNT(NAFFNUM) FROM TAUTOAFF WHERE DAFFDFIN is null AND NVEHNUM = {miNumVehicule}");
				if ( Row > 0 ) {return false;}
				return true;
			}
			catch (Exception ex)
			{
				MZUtils.displayError(MethodBase.GetCurrentMethod().Name, ex);
				return false;
			}
		}

		public void ChargerListeAffectations()
		{
			try
			{
				string sSQL = $"SELECT A.*, VPERNOM + ' ' + VPERPRE AS VPERNOM FROM TAUTOAFF A LEFT OUTER JOIN TPER P ON A.NPERNUM=P.NPERNUM " +
											$"WHERE NVEHNUM = {miNumVehicule} ORDER BY DAFFDDEB";
				dtAffectation.Clear();
				grdAffectation.LoadData(dtAffectation, MozartDatabase.cnxMozart, sSQL);
				grdAffectation.GridControl.DataSource = dtAffectation;
			}
			catch (Exception ex)
			{
				MZUtils.displayError(MethodBase.GetCurrentMethod().Name, ex);
			}
		}

		public void ChargerListeSinistres()
		{
			try
			{
				string sSQL = $"SELECT A.*, VPERNOM + ' ' + VPERPRE AS VPERNOM FROM TAUTOSIN A LEFT OUTER JOIN TPER P ON A.NPERNUM=P.NPERNUM " +
											$"WHERE NVEHNUM = {miNumVehicule} ORDER BY DSINDATE";
				dtSinistre.Clear();
				grdSinistre.LoadData(dtSinistre, MozartDatabase.cnxMozart, sSQL);
				grdSinistre.GridControl.DataSource = dtSinistre;
			}
			catch (Exception ex)
			{
				MZUtils.displayError(MethodBase.GetCurrentMethod().Name, ex);
			}
		}

		public void Enregistrer()
		{
			try
			{
				// Création ou la modification, c'est la proc stock qui gère
				using (SqlCommand cmd = new SqlCommand("api_sp_CreationVehicule2", MozartDatabase.cnxMozart))
				{
					cmd.CommandType = CommandType.StoredProcedure;

					// liste des paramètres
					SqlCommandBuilder.DeriveParameters(cmd);
					// panel1
					cmd.Parameters["@iNum"].Value = miNumVehicule; //0 si création
					cmd.Parameters["@immat"].Value = txtImmat.Text;
					cmd.Parameters["@vsociete"].Value = (null == cboSociete.SelectedItem) ? "" : cboSociete.Text.ToString();
					cmd.Parameters["@etat"].Value = (null == cboEtat.SelectedItem) ? "" : cboEtat.Text.ToString();
					cmd.Parameters["@dDateE"].Value = txtDateEntre.Text == "" ? null : txtDateEntre.Text;
					cmd.Parameters["@dDateS"].Value = txtDateSortie.Text == "" ? null : txtDateSortie.Text;
					cmd.Parameters["@dDateCom"].Value = txtDateCommande.Text == "" ? null : txtDateCommande.Text;
					cmd.Parameters["@nRoulageMois"].Value = cboRoulage1.Text == "" ? null : cboRoulage1.Text;
					cmd.Parameters["@nRoulageKM"].Value = cboRoulage2.Text == "" ? null : cboRoulage2.Text;
					cmd.Parameters["@Gestionnaire"].Value = cboGestionnaire.Text;
					cmd.Parameters["@numDI"].Value = txtNumDI.Text;
					cmd.Parameters["@cPool"].Value = ChkPool.Checked == true ? "O" : "N";
					// panel 2
					cmd.Parameters["@categorie"].Value = cboCategorie.Text;
					cmd.Parameters["@Marque"].Value = cboMarque.Text;
					cmd.Parameters["@Modele"].Value = cboModele.Text;
					cmd.Parameters["@Carburant"].Value = cboCarburant.Text;
					cmd.Parameters["@NbPlaces"].Value = cboPlaces.Text;
					cmd.Parameters["@TaillePneus"].Value = txtTaillePneu.Text;
					cmd.Parameters["@typePneu"].Value = txtPneu.Text;
					cmd.Parameters["@Amenagement"].Value = cboAmenagement.Text;
					//panel3
					cmd.Parameters["@iInitKM"].Value = txtKMini.Text == "0" ? 0 : txtKMini.EditValue;
					cmd.Parameters["@iDerKM"].Value = txtKMcours.EditValue;
					cmd.Parameters["@dDateCTRL"].Value = txtDateCtrl.Text == "" ? null : txtDateCtrl.Text;
					cmd.Parameters["@dDateCtrlPol"].Value = txtDateCtrlPol.Text == "" ? null : txtDateCtrlPol.Text;
					cmd.Parameters["@dDateC"].Value = txtDateMEC.Text == "" ? null : txtDateMEC.Text;
					cmd.Parameters["@numSerie"].Value = txtNumSerie.Text;
					cmd.Parameters["@carteGrise"].Value = txtCarteGrise.Text;
					cmd.Parameters["@vFiscal"].Value = cboFiscal.Text;
					cmd.Parameters["@critAir"].Value = cboCRITAIR.Text;
					// panel 4
					cmd.Parameters["@nRevMois"].Value = cboERmois.Text == "" ? null : cboERmois.Text; 
					cmd.Parameters["@nRevKM"].Value = cboERkms.Text=="" ? null : cboERmois.Text;
					cmd.Parameters["@nKitMois"].Value = cboEKmois.Text == "" ? null : cboEKmois.Text;
					cmd.Parameters["@nKitKM"].Value = cboEKkms.Text == "" ? null : cboEKkms.Text;

					//gps et divers
					cmd.Parameters["@vObserv"].Value = txtObservations.Text;
					cmd.Parameters["@vGPS"].Value = txtNumGPS.Text;
					cmd.Parameters["@dGPS"].Value = txtDateGPS.Text == "" ? null : txtDateGPS.Text;
					cmd.Parameters["@nGCO2"].Value = txtCO2.EditValue;

					cmd.ExecuteNonQuery();

					miNumVehicule = (int)cmd.Parameters[0].Value;

				}
			}
			catch (Exception ex)
			{
				MZUtils.displayError(MethodBase.GetCurrentMethod().Name, ex);
			}
		}

		public void FormatGridDepenses()
		{
			try
			{
				grdDepense.AddColumn(MZCtrlResources.col_libelle, "LIBELLE", 1800);
				grdDepense.AddColumn(Resources.col_montantHT, "MONTANT", 1200, "# ###", 1);
				grdDepense.CacherBoutonsPrintExcel();
				grdDepense.InitColumnList();
			}
			catch (Exception ex)
			{
				MZUtils.displayError(MethodBase.GetCurrentMethod().Name, ex);
			}
		}


		public void FormatGridEntretiens()
		{
			try
			{
				grdEntretien.AddColumn("R", "NREVINUM", 0);
				grdEntretien.AddColumn("V", "NVEHNUM", 0);
				grdEntretien.AddColumn(Resources.col_Type, "VREVLIBELLE", 1700);
				grdEntretien.AddColumn(Resources.col_Date, "DREVIDATE", 1200, "dd/mm/yyyy", 2);
				grdEntretien.AddColumn(Resources.col_Kms, "NREVIKM", 900, "# ###", 1);
				grdEntretien.AddColumn("Freins/pneus", "VREVDIVERS", 1500);
				grdEntretien.CacherBoutonsPrintExcel();
				grdEntretien.InitColumnList();

			}
			catch (Exception ex)
			{
				MZUtils.displayError(MethodBase.GetCurrentMethod().Name, ex);
			}
		}

		public void FormatGridAffectations()
		{
			try
			{
				grdAffectation.AddColumn("R", "NAFFNUM", 0);
				grdAffectation.AddColumn("V", "NVEHNUM", 0);
				grdAffectation.AddColumn("Date début", "DAFFDDEB", 1200, "dd/mm/yyyy", 2);
				grdAffectation.AddColumn("Date fin", "DAFFDFIN", 1200, "dd/mm/yyyy", 2);
				grdAffectation.AddColumn("Entité", "VAFFSOCIETE", 1200);
				grdAffectation.AddColumn("Collaborateur", "VPERNOM", 1700);
				grdAffectation.AddColumn(Resources.col_Statut, "VAFFSTATUT", 1200,"",2);
				grdAffectation.CacherBoutonsPrintExcel();
				grdAffectation.InitColumnList();

			}
			catch (Exception ex)
			{
				MZUtils.displayError(MethodBase.GetCurrentMethod().Name, ex);
			}
		}

		public void FormatGridEquipements()
		{
			try
			{
				grdEquipement.AddColumn("R", "NEQUIPNUM", 0);
				grdEquipement.AddColumn("V", "NVEHNUM", 0);
				grdEquipement.AddColumn("Date début", "DEQUIPDDEB", 1200, "dd/mm/yyyy", 2);
				grdEquipement.AddColumn("Date fin", "DEQUIPDFIN", 1200, "dd/mm/yyyy", 2);
				grdEquipement.AddColumn(Resources.col_Fournisseur, "VEQUIPFOUR", 1500);
				grdEquipement.AddColumn(Resources.col_Type, "VEQUIPTYPE", 1300);
				grdEquipement.AddColumn("N° équipement", "VEQUIPREF", 1300);
				grdEquipement.AddColumn(Resources.col_Code, "VEQUIPCODE", 1100);
				grdEquipement.AddColumn(Resources.col_Statut, "VEQUIPSTATUT", 1100);
				grdEquipement.CacherBoutonsPrintExcel();
				grdEquipement.InitColumnList();

			}
			catch (Exception ex)
			{
				MZUtils.displayError(MethodBase.GetCurrentMethod().Name, ex);
			}
		}

		public void FormatGridSinistres()
		{
			try
			{
				grdSinistre.AddColumn("R", "NSINNUM", 0);
				grdSinistre.AddColumn("V", "NVEHNUM", 0);
				grdSinistre.AddColumn(Resources.col_Date, "DSINDATE", 1200, "dd/mm/yyyy", 2);
				grdSinistre.AddColumn("Entité", "VSOCIETE", 1200);
				grdSinistre.AddColumn("Collaborateur", "VPERNOM", 1400);
				grdSinistre.AddColumn("N° dossier", "VSINDOSSIER", 1400);
				grdSinistre.AddColumn("Responsabilité", "VSINRESPONSABLE", 1000, "# ###", 1);
				grdSinistre.AddColumn(Resources.col_Observations, "VSINOBS", 1500);
				grdSinistre.AddColumn(Resources.col_Statut, "VSINSTATUT", 1300,"",2);
				grdSinistre.CacherBoutonsPrintExcel();
				grdSinistre.InitColumnList();

			}
			catch (Exception ex)
			{
				MZUtils.displayError(MethodBase.GetCurrentMethod().Name, ex);
			}
		}

		private void cmdFormation_Click(object sender, EventArgs e)
		{
			//new frmListeFormation($"{txtNom.Text} {txtprenom.Text}").ShowDialog();
		}


		private void cboMarque_SelectionChangeCommitted(object sender, EventArgs e)
		{
			cboModele.DataSource = null;
			cboModele.Items.Clear();
			ModuleData.RemplirCombo(cboModele, $"select distinct VVEHMODELE from TREF_VEHICULES WHERE VVEHMARQUE='{cboMarque.Text}' Order By VVEHMODELE");
			cboModele.ValueMember = "VVEHMODELE";
			cboModele.DisplayMember = "VVEHMODELE";
		}

		private void txtObservations_Enter(object sender, EventArgs e)
		{
			string aux = String.Format("{0} le {1} : ", MozartParams.strUID, DateTime.Now.ToString("dd/MM/yy HH:mm"));

			txtObservations.Text = $"{aux}\r\n{txtObservations.Text}";
		}

		private void cmdDI_Click(object sender, EventArgs e)
		{

			if (txtNumDI.Text == "")
			{
				MessageBox.Show("Il n'y a pas de DI rattachée à ce véhicule", Program.AppTitle, MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
				return;
			}

			//  gestion de la société : ouvrir un Mozart filiale ?
			if (cboSociete.Text != MozartParams.NomSociete)
			{
				MessageBox.Show("Ce véhicule n'est pas dans l'entité en cours.\n On ne peut pas accéder à la DI dans ce Mozart", Program.AppTitle, MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
				return;
			}

			//écran de modification de la demande
			MozartParams.NumDi = Convert.ToInt32(txtNumDI.Text);
			MozartParams.NumAction = 0;

			Cursor.Current = Cursors.WaitCursor;

			new frmAddAction()
			{
				mstrStatutDI = "M",
			}.ShowDialog();

			//on revient donc on réinitialise les variables globales
			MozartParams.NumDi = 0;
			MozartParams.NumAction = 0;

		}

		private void cmdAjouterEntretien_Click(object sender, EventArgs e)
		{
			new frmFormulaireRevision(miNumVehicule, 0).ShowDialog();
			ChargerListeEntretiens();
		}

		private void cmdModifierEntretien_Click(object sender, EventArgs e)
		{
			DataRow row = grdEntretien.GetFocusedDataRow();
			if (row == null) return;

			int nEnt = Convert.ToInt32(row["NREVNUM"].ToString());

			new frmFormulaireRevision(miNumVehicule, nEnt).ShowDialog();
			ChargerListeEntretiens();
		}

		private void cmdSupprimerEntretien_Click(object sender, EventArgs e)
		{
			DataRow row = grdEntretien.GetFocusedDataRow();
			if (row == null) return;

			int nEnt = Convert.ToInt32(row["NREVNUM"].ToString());

			if (MessageBox.Show("Voulez-vous vraiment supprimer cette ligne ?", Program.AppTitle, MessageBoxButtons.YesNoCancel, MessageBoxIcon.Question) == DialogResult.Yes)
			{
				MozartDatabase.ExecuteNonQuery($"DELETE FROM TAUTOREV WHERE NREVNUM = {nEnt}");

				ChargerListeEntretiens();
			}
		}

		private void CmdAjouterAffectation_Click(object sender, EventArgs e)
		{
			// test si il y a une affectation sans date de fin
			// pour pouvoir ajouter une affectation, il faut finir la précédente
			if (!NewAffectationOk())
			{
				MessageBox.Show("Pour ajouter une affectation, il faut mettre une date de fin sur l'affectation en cours", Program.AppTitle, MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
				return;
			}

			new frmFormulaireAffectation(miNumVehicule, 0).ShowDialog();
			OuvertureEnModification();
		}

		private void cmdModifierAffectation_Click(object sender, EventArgs e)
		{
			DataRow row = grdAffectation.GetFocusedDataRow();
			if (row == null) return;

			int nEnt = Convert.ToInt32(row["NAFFNUM"].ToString());

			new frmFormulaireAffectation(miNumVehicule, nEnt).ShowDialog();
			OuvertureEnModification();
		}

		private void cmdSupprimerAffectation_Click(object sender, EventArgs e)
		{
			DataRow row = grdAffectation.GetFocusedDataRow();
			if (row == null) return;

			int nEnt = Convert.ToInt32(row["NAFFNUM"].ToString());

			if (MessageBox.Show("Voulez-vous vraiment supprimer cette ligne ?", Program.AppTitle, MessageBoxButtons.YesNoCancel, MessageBoxIcon.Question) == DialogResult.Yes)
			{
				MozartDatabase.ExecuteNonQuery($"DELETE FROM TAUTOAFF WHERE NAFFNUM = {nEnt}");

				ChargerListeAffectations();
			}
		}

		private void cmdAjouterEquipement_Click(object sender, EventArgs e)
		{
			new frmFormulaireEquipement(miNumVehicule, 0).ShowDialog();
			ChargerListeEquipements();
		}

		private void cmdModifierEquipement_Click(object sender, EventArgs e)
		{
			DataRow row = grdEquipement.GetFocusedDataRow();
			if (row == null) return;

			int nEnt = Convert.ToInt32(row["NEQUIPNUM"].ToString());

			new frmFormulaireEquipement(miNumVehicule, nEnt).ShowDialog();
			ChargerListeEquipements();
		}

		private void cmdSupprimerEquipement_Click(object sender, EventArgs e)
		{
			DataRow row = grdEquipement.GetFocusedDataRow();
			if (row == null) return;

			int nEnt = Convert.ToInt32(row["NEQUIPNUM"].ToString());

			if (MessageBox.Show("Voulez-vous vraiment supprimer cette ligne ?", Program.AppTitle, MessageBoxButtons.YesNoCancel, MessageBoxIcon.Question) == DialogResult.Yes)
			{
				MozartDatabase.ExecuteNonQuery($"DELETE FROM TAUTOEQUIP WHERE NEQUIPNUM = {nEnt}");

				ChargerListeEquipements();
			}
		}

		private void cmdAjouterSinistre_Click(object sender, EventArgs e)
		{
			new frmFormulaireSinistre(miNumVehicule, 0, cboSociete.Text).ShowDialog();
			ChargerListeSinistres();
		}

		private void cmdModifierSinistre_Click(object sender, EventArgs e)
		{
			DataRow row = grdSinistre.GetFocusedDataRow();
			if (row == null) return;

			int nEnt = Convert.ToInt32(row["NSINNUM"].ToString());

			new frmFormulaireSinistre(miNumVehicule, nEnt, cboSociete.Text).ShowDialog();
			ChargerListeSinistres();
		}


		private void cmdSupprimerSinistre_Click(object sender, EventArgs e)
		{
			DataRow row = grdSinistre.GetFocusedDataRow();
			if (row == null) return;

			int nEnt = Convert.ToInt32(row["NSINNUM"].ToString());

			if (MessageBox.Show("Voulez-vous vraiment supprimer cette ligne ?", Program.AppTitle, MessageBoxButtons.YesNoCancel, MessageBoxIcon.Question) == DialogResult.Yes)
			{
				MozartDatabase.ExecuteNonQuery($"DELETE FROM TAUTOSIN WHERE NSINNUM = {nEnt}");

				ChargerListeSinistres();
			}

		}

		private void cmdDocuments_Click(object sender, EventArgs e)
		{
			new frmListeDocVehicules(miNumVehicule, txtImmat.Text).ShowDialog();
		}

		private void cmdFermer_Click(object sender, System.EventArgs e)
		{
			Dispose();
		}

	}
}