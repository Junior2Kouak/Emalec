using MZCtrlResources = MozartControls.Properties.Resources;
using MozartCS.Properties;
using MozartLib;
using MozartNet;
using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.IO;
using System.Reflection;
using System.Windows.Forms;
using MZUtils = MozartControls.Utils;

namespace MozartCS
{


	public partial class frmDetailsFourniture : Form
	{
		public string mstrStatut;
		public int miNumFour;
		public bool mbStatutValidation;

		CFOU_ETAL_TECH oFOU_ETAL_TECH;

		List<string> mFichiersImages;
		string strRepFour;
		string strImage;
		string strImageMini;
		bool mbPrem = true;
		bool mbPremHistoPrix = true;

		string strStatut;
		string sPrixMem = "";

		DataTable mDtPri, mDtRs, mDtHp;

		private bool bOldStateChkContratCadre;

		public frmDetailsFourniture()
		{
			InitializeComponent();
			mDtPri = new DataTable();
			mFichiersImages = new List<string>();
		}

		private void frmDetailsFourniture_Load(object sender, System.EventArgs e)
		{
			try
			{
				Cursor.Current = Cursors.WaitCursor;
				ModuleMain.Initboutons(this);

				//'traitement spécifique pour Jean Jullien
				if (ModuleMain.RechercheDroitMenu(536))
				{
					lblLabels33.Visible = true;
					txtRecycleVente.Visible = true;
				}
				else
				{
					lblLabels33.Visible = false;
					txtRecycleVente.Visible = false;
				}

				cboMarqueExt.Top = txtMarque.Top;
				cboMarqueExt.Left = txtMarque.Left;
				cboMarqueExt.Width = txtMarque.Width;

				// Recherche du répertoire de sauvegarde des images sur le serveur
				strRepFour = Utils.RechercheParam("REP_FOURNITURES");

				cboFour.Init(MozartDatabase.cnxMozart, "select NSTFGRPNUM, VSTFGRPNOM + ' - ' + coalesce(VSTFGRPVIL, '') [VSTFGRPNOM]" +
										 "from TSTFGRP WHERE  CSTFGRPACTIF = 'O' AND (CSTFTYP = 'FO' or CSTFTYP = 'FT') order by VSTFGRPNOM  + ' - ' + coalesce(VSTFGRPVIL, '') ",
										 "NSTFGRPNUM", "VSTFGRPNOM", new List<string>() { Resources.col_Num, Resources.col_Nom }, 150, 550, true);

				cboConcept.Init(MozartDatabase.cnxMozart, "select ID, LIBELLE from TREF_CONCEPT",
											 "ID", "LIBELLE", new List<string>() { Resources.col_Num, Resources.col_Nom }, 150, 550);

				ModuleData.RemplirCombo(cboMarqueExt, "SELECT NFOUEXTMARQID, VFOUEXTMARQLIB FROM TFOUEXTMARQ ORDER BY VFOUEXTMARQLIB");
				cboMarqueExt.ValueMember = "NFOUEXTMARQID";
				cboMarqueExt.DisplayMember = "VFOUEXTMARQLIB";

				CboPaysFou.Init(MozartDatabase.cnxMozart, "select NPAYSNUM, VPAYSNOM from TPAYS order by VPAYSNOM",
												"NPAYSNUM", "VPAYSNOM", new List<string>() { Resources.col_Num, Resources.col_Nom }, 150, 550);

				// VL Spécifique MPM
				for (int i = 0; i < 26; i++)
					cboIndicePlan.Items.Add((char)(65 + i));

				InitApigrid();

				// traitement du cas de modification ou de création
				if (mstrStatut == "C")
				{
					miNumFour = 0;
					OuvertureEnCreation();
					txtDateA0.Text = DateTime.Now.ToShortDateString();
				}
				else
				{
					OuvertureEnModification();
					// gestion des droits sur la combo série
					// traitement des série location mat et vehicule, voyage, energie...
					int pos = cboSerie.GetItemData();
					if (pos == 34 || pos == 35 || pos == 36 || pos == 37)
						cboSerie.Enabled = ModuleMain.RechercheDroitMenu(540);
					// traitement des séries Extincteur
					else if (pos == 31 || pos == 32 || pos == 33)
						cboSerie.Enabled = ModuleMain.RechercheDroitMenu(541);
					// traitement série MITSU HYGENA
					else if (pos == 39)
					{
						if (ModuleMain.RechercheDroitMenu(542))
						{
							MessageBox.Show("Vous ne pouvez pas créer ou modifier les articles de cette série, merci de contacter la direction", "",
															MessageBoxButtons.OK, MessageBoxIcon.Information);
							cboSerie.Enabled = true;
						}
						else
							cboSerie.Enabled = false;
					}
					// traitement des séries industrie
					else if (pos == 53)
						cboSerie.Enabled = ModuleMain.RechercheDroitMenu(622);
					else if (pos == 56)
					{
						bool b = ModuleMain.RechercheDroitMenu(654);
						cboSerie.Enabled = b;
						cmdValider.Visible = b;
						cmdSupp.Visible = b;
						cmdAjouter.Visible = b;
					}
				}
			}
			catch (Exception ex)
			{
				MZUtils.displayError(MethodBase.GetCurrentMethod().Name, ex);
			}
			finally
			{
				Cursor.Current = Cursors.Default;
			}
		}

		private void cmdAjouter_Click(object sender, EventArgs e)
		{
			if (miNumFour == 0)
			{
				MessageBox.Show(Resources.msg_enreg_fourniture_choix_fournisseur, "",
												MessageBoxButtons.OK, MessageBoxIcon.Information);
				return;
			}
			strStatut = "C";
			cboFour.SetItemData(-1);
			cboFour.Enabled = true;
			txtPrix.Text = "";
			txtRefCli.Text = "";
			txtUprix.Text = "1";
			txtDateA0.Text = DateTime.Now.ToShortDateString();
		}

		private void cmdSupp_Click(object sender, EventArgs e)
		{
			DataRow row = ApiGrid.GetFocusedDataRow();
			if (null == row)
				return;
			// on ne peut pas supprimer le prix si c'est le seul (car la fourniture ne serait plus visible et utilisable) fg le 10/10/19
			if (mDtPri.Rows.Count == 1)
			{
				MessageBox.Show("Vous ne pouvez pas supprimer ce prix car il faut au minimum un prix sur une fourniture", "",
												MessageBoxButtons.OK, MessageBoxIcon.Information);
				return;
			}
			if (MessageBox.Show(Resources.msg_sup_liaison_article_fournisseur, Program.AppTitle, MessageBoxButtons.YesNo,
													MessageBoxIcon.Question, MessageBoxDefaultButton.Button2) == DialogResult.Yes)
			{
				try
				{
					Cursor.Current = Cursors.WaitCursor;

					ModuleData.ExecuteNonQuery($"delete from TSTFFOU WHERE NFOUNUM = {miNumFour} AND NSTFGRPNUM = {row["NSTFGRPNUM"]}");
					// Modification du prix des fournitures de toutes les prestations liees a cette fourniture
					ModuleData.ExecuteNonQuery($"exec api_sp_CalculFouPrest {miNumFour}");

					ApiGrid.Requery(mDtPri, MozartDatabase.cnxMozart);

					framListe.Enabled = true;
				}
				catch (Exception ex)
				{
					MZUtils.displayError(MethodBase.GetCurrentMethod().Name, ex);
				}
				finally
				{
					Cursor.Current = Cursors.Default;
				}
			}
		}

		private void updateValiditeContratCadre()
		{
			bool bExistContratCadre;
			bool bRightToModify;
			DateTime? lDateValidCC;

			try
			{
				// Droits pour la coche prix contrat cadre
				bRightToModify = ModuleMain.RechercheDroitMenu(719);

				// CheckBox contrat cadre
				bExistContratCadre = chkContratCadre.Checked;

				if (txtDateValidContratCadre.EditValue == null)
				{
					lDateValidCC = null;
				}
				else
				{
					lDateValidCC = txtDateValidContratCadre.DateTime;
				}

				if (bExistContratCadre)
				{
					txtDateValidContratCadre.Enabled = bRightToModify;
					apiLabel1.Enabled = bRightToModify;

					setPrixState(bRightToModify || (DateTime.Now.Date > lDateValidCC));
				}
				else
				{
					setPrixState(true);
				}

				chkContratCadre.Enabled = bRightToModify;
				setDateContratCadreVisible(bExistContratCadre);
			}
			catch (Exception ex)
			{
				MZUtils.displayError(MethodBase.GetCurrentMethod().Name, ex);
			}
		}

		private void setPrixState(bool bEnabled)
		{
			txtPrix.Enabled = bEnabled;
			txtUprix.Enabled = bEnabled;
			txtPrix.BackColor = txtUprix.BackColor = bEnabled ? Color.White : Color.LightGray;
		}

		private void cmdSupprimer_Click(object sender, EventArgs e)
		{
			if (MessageBox.Show(Resources.msg_sup_article_article_stocks_clients, Program.AppTitle, MessageBoxButtons.YesNo,
													MessageBoxIcon.Question, MessageBoxDefaultButton.Button2) == DialogResult.Yes)
			{
				try
				{
					Cursor.Current = Cursors.WaitCursor;
					if (0 != miNumFour)
					{
						// suppression dans la table des stock sites
						ModuleData.ExecuteNonQuery($"delete from TSTOCKARTCLISIT WHERE NFOUNUM = {miNumFour}");
						// suppression dans la table des stock client
						ModuleData.ExecuteNonQuery($"delete from TSTOCKARTCLI WHERE NFOUNUM = {miNumFour}");
					}
					txtClients.Text = "";
				}
				catch (Exception ex)
				{
					MZUtils.displayError(MethodBase.GetCurrentMethod().Name, ex);
				}
				finally
				{
					Cursor.Current = Cursors.Default;
				}
			}
		}

		private void cmdValider_Click(object sender, EventArgs e)
		{
			if (miNumFour == 0)
				return;
			if (cboFour.GetText() == "")
			{
				MessageBox.Show(Resources.msg_sel_fournisseur, Program.AppTitle, MessageBoxButtons.OK, MessageBoxIcon.Information);
				return;
			}
			if (txtPrix.Text == "")
			{
				MessageBox.Show(Resources.msg_sel_prix, Program.AppTitle, MessageBoxButtons.OK, MessageBoxIcon.Information);
				return;
			}
			if (!double.TryParse(txtUprix.Text, out double Uprix) || Uprix < 1)
			{
				MessageBox.Show(Resources.msg_saisie_quantite_sup0_prix, Program.AppTitle, MessageBoxButtons.OK, MessageBoxIcon.Information);
				return;
			}

			if (chkContratCadre.Checked && (txtDateValidContratCadre.EditValue == null))
			{
				MessageBox.Show("Il faut renseigner une date de validité prix contrat cadre.", Program.AppTitle, MessageBoxButtons.OK, MessageBoxIcon.Error);
				return;
			}

			//  ' ******************************************************************************
			//  ' Gestion des droits sur la modification des fournitures
			//  ' FG le 12/11/2019
			//  ' JJ : tout le monde peut modifier un prix à la baisse
			//  '*******************************************************************************
			//  
			//  ' pas de test si prix inférieur
			double.TryParse(txtPrix.Text, out double Prix);
			double.TryParse(sPrixMem, out double PrixMem);
			if (Prix > PrixMem)
			{
				// traitement des série location mat et vehicule, voyage, energie
				int pos = cboSerie.GetItemData();
				if ((pos == 34 || pos == 35 || pos == 36 || pos == 37) && !ModuleMain.RechercheDroitMenu(540))
				{
					MessageBox.Show("Vous ne pouvez pas créer ou modifier les prix de cette série, merci de contacter le service achats", Program.AppTitle,
													MessageBoxButtons.OK, MessageBoxIcon.Information);
					return;
				}
				// traitement série MITSU HYGENA
				else if (pos == 39 && !ModuleMain.RechercheDroitMenu(542))
				{
					MessageBox.Show("Vous ne pouvez pas créer ou modifier les prix de cette série, merci de contacter le service achats", Program.AppTitle,
														MessageBoxButtons.OK, MessageBoxIcon.Information);
					return;
				}
				// traitement série Industrie
				else if (pos == 53 && !ModuleMain.RechercheDroitMenu(622))
				{
					MessageBox.Show("Vous ne pouvez pas créer ou modifier les prix de cette série, merci de contacter le service achats", Program.AppTitle,
														MessageBoxButtons.OK, MessageBoxIcon.Information);
					return;
				}
			}

			try
			{
				Cursor.Current = Cursors.WaitCursor;

				if (strStatut == "C")
				{
					// ' pas de test lors de la création d'un prix
					try
					{
						string lDateContratCadre;
						if (txtDateValidContratCadre.EditValue == null)
						{
							lDateContratCadre = "NULL";
						}
						else
						{
							lDateContratCadre = $"'{txtDateValidContratCadre.DateTime.ToShortDateString()}'";
						}
						string lTest = $"Insert into TSTFFOU(NSTFGRPNUM, NFOUNUM, FPUHT, FPUNITE, DFOUDPR, VSTFFOUREFCLI, NQUICREE, DQUIMOD,BSTFFOUCONTRATCADRE, DSTFFOUDATECONTRATCADRE) Values(" +
																										$"{cboFour.GetItemData()}, {miNumFour}, {txtPrix.Text.Replace(",", ".")}, {txtUprix.Text}, '{txtDateA0.Text}'," +
																										$"'{txtRefCli.Text.Replace(",", ".")}',{MozartParams.UID}, '{DateTime.Now}'," +
																										$"{(chkContratCadre.Checked ? 1 : 0)}, {lDateContratCadre})";
						ModuleData.ExecuteNonQuery(lTest);
					}
					catch (Exception)
					{
						MessageBox.Show(Resources.msg_ImpFaireModifEnrgExistant, Program.AppTitle, MessageBoxButtons.OK, MessageBoxIcon.Information);
					}
				}
				else
				{
					// en  modification test uniquement si prix à la hausse
					//    ' Test si cette fourniture est utilisée dans une gamme Stock client
					//    ' Si oui pas de modif possible sauf admin
					DataRow row = ApiGrid.GetFocusedDataRow();
					if (null == row)
						return;

					if (Prix > PrixMem && !Utils.bModOKprix(miNumFour))
						return;

					string sql = $"UPDATE TSTFFOU set FPUHT = {txtPrix.Text.Replace(",", ".")}, FPUNITE = {txtUprix.Text}," +
											 $" VSTFFOUREFCLI = '{txtRefCli.Text.Replace("'", "''")}',  DFOUDPR = '{txtDateA0.Text}', BSTFFOUCONTRATCADRE = {(chkContratCadre.Checked ? 1 : 0)}";
					if (chkContratCadre.Checked)
					{
						sql += $", DSTFFOUDATECONTRATCADRE = '{txtDateValidContratCadre.DateTime.ToShortDateString()}'";
					}
					if ((sPrixMem != txtPrix.Text) || (bOldStateChkContratCadre != chkContratCadre.Checked))
					{
						sql += $", NQUICREE = {MozartParams.UID}, DQUIMOD = '{DateTime.Now}'";
					}
					sql += $" WHERE NFOUNUM = {miNumFour} AND NSTFGRPNUM = {row["NSTFGRPNUM"]}";
					try
					{
						ModuleData.ExecuteNonQuery(sql);
					}
					catch (Exception ex)
					{
						MZUtils.displayError(MethodBase.GetCurrentMethod().Name, ex);
					}
				}

				// Modification du prix des fournitures de toutes les prestations liees a cette fourniture
				ModuleData.ExecuteNonQuery($"exec api_sp_CalculFouPrest {miNumFour}");

				ApiGrid.Requery(mDtPri, MozartDatabase.cnxMozart);
			}
			catch (Exception ex)
			{
				MZUtils.displayError(MethodBase.GetCurrentMethod().Name, ex);
			}
			finally
			{
				Cursor.Current = Cursors.Default;
			}
		}

		private void cmdImgDel_Click(object sender, EventArgs e)
		{
			if (0 == listImages1.SelectedItems.Count) return;
			if (MessageBox.Show(Resources.msg_ConfirmDelImg, Program.AppTitle, MessageBoxButtons.YesNo,
													MessageBoxIcon.Question, MessageBoxDefaultButton.Button2) == DialogResult.No) return;
			try
			{
				Cursor.Current = Cursors.WaitCursor;
				// suppression en base
				int iNFOUIMG = (int)listImages1.SelectedItems[0].Tag;
				ModuleData.ExecuteNonQuery($"DELETE FROM TFOUIMG WHERE NFOUIMGNUM={iNFOUIMG}");
				//'suppression physique du fichier
				if (strImage != "")
				{
					File.Delete(strImage);
					File.Delete(strImageMini);
				}
				//    'init des var
				strImage = "";
				strImageMini = "";
				txtImgFichier.Text = "";
				iNFOUIMG = 0;

				LoadImgFou();
			}
			catch (Exception ex)
			{
				MZUtils.displayError(MethodBase.GetCurrentMethod().Name, ex);
			}
			finally
			{
				Cursor.Current = Cursors.Default;
			}
		}

		private void cmdStatTel_Click(object sender, EventArgs e)
		{
			int index = cboFour.GetItemData();
			if (index <= 0)
				return;
			try
			{
				Cursor.Current = Cursors.WaitCursor;
				using (SqlDataReader reader = ModuleData.ExecuteReader($"SELECT NSTFNUM from TSTF WHERE NSTFGRPNUM = {index}"))
				{
					reader.Read();
					int iNumFourn = (int)Utils.ZeroIfNull(reader["NSTFNUM"]);
					if (reader.Read())
					{
						new frmChoixSiteFour() { miNumFourn = index }.ShowDialog();
					}
					else new frmListeContactsFour() { miNumFourn = iNumFourn }.ShowDialog();
				}
			}
			catch (Exception ex)
			{
				MZUtils.displayError(MethodBase.GetCurrentMethod().Name, ex);
			}
			finally
			{
				Cursor.Current = Cursors.Default;
			}
		}

		private void cmdEnregistrer_Click(object sender, EventArgs e)
		{
			if (cboSerie.GetText() == "")
			{
				MessageBox.Show(Resources.msg_saisie_serie_fourniture, Program.AppTitle, MessageBoxButtons.OK, MessageBoxIcon.Information);
				return;
			}

			if (txtMat.Text == "")
			{
				MessageBox.Show(Resources.msg_SaisirLibelleMat, Program.AppTitle, MessageBoxButtons.OK, MessageBoxIcon.Information);
				return;
			}

			if (txtNBlot.Text == "")
			{
				MessageBox.Show(Resources.msg_saisie_unit_achat, Program.AppTitle, MessageBoxButtons.OK, MessageBoxIcon.Information);
				return;
			}

			//'traitement des sous series obligatoire sauf pour les fluides frigos
			int indexSerie = cboSerie.GetItemData();
			int indexSSSerie = cboSSSerie.GetItemData();
			if (null != cboSSSerie.DataSource() && (cboSSSerie.DataSource() as DataTable).Rows.Count > 1
					&& indexSerie != 56 && indexSerie != 10 && cboSSSerie.GetText() == "")
			{
				MessageBox.Show(Resources.msg_sel_sous_serie, Program.AppTitle, MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
				cboSSSerie.Focus();
				return;
			}

			if (indexSerie == 31)
			{
				// obligation d'un matériel corespondant a la verification
				if (indexSSSerie == 1 && cboVerif.GetValue() == "-1")
				{
					MessageBox.Show("Il faut obligatoirement saisir un type de vérification!", Program.AppTitle, MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
					cboVerif.Focus();
					return;
				}
			}
			// traitement des séries location mat et veh
			else if (indexSerie == 34 || indexSerie == 35 || indexSerie == 36 || indexSerie == 37)
			{
				if (ModuleMain.RechercheDroitMenu(540))
				{
					if (MessageBox.Show("Attention, cette série est suivie par le service achat. Voulez-vous continuer ?", Program.AppTitle, MessageBoxButtons.YesNo,
															MessageBoxIcon.Question, MessageBoxDefaultButton.Button2) == DialogResult.No)
						return;

				}
				else
				{
					MessageBox.Show("Vous ne pouvez pas créer ou modifier les articles de cette série, merci de contacter le service Achats.", "",
													MessageBoxButtons.OK, MessageBoxIcon.Information);
					return;
				}
			}
			// traitement des séries Extinction
			else if (indexSerie == 31 || indexSerie == 32 || indexSerie == 33)
			{
				if (!ModuleMain.RechercheDroitMenu(541))
				{
					MessageBox.Show("Vous ne pouvez pas créer ou modifier les articles de cette série, merci de contacter la direction.", "",
													MessageBoxButtons.OK, MessageBoxIcon.Information);
					return;
				}
			}
			// traitement série MITSU HYGENA
			else if (indexSerie == 39)
			{
				if (!ModuleMain.RechercheDroitMenu(542))
				{
					MessageBox.Show("Vous ne pouvez pas créer ou modifier les articles de cette série, merci de contacter la direction.", "",
													MessageBoxButtons.OK, MessageBoxIcon.Information);
					return;
				}
			}
			// traitement série Fluide Frigo
			else if (indexSerie == 56)
			{
				if (!ModuleMain.RechercheDroitMenu(654))
				{
					MessageBox.Show("Vous ne pouvez pas créer ou modifier les articles de cette série, merci de contacter la direction.", "",
													MessageBoxButtons.OK, MessageBoxIcon.Information);
					return;
				}
			}
			// traitement série INDUSTRIE
			else if (indexSerie == 53)
			{
				if (!ModuleMain.RechercheDroitMenu(622))
				{
					MessageBox.Show("Vous ne pouvez pas créer ou modifier les articles de cette série, merci de contacter la direction.", "",
													MessageBoxButtons.OK, MessageBoxIcon.Information);
					return;
				}
				if (cboTypeId.Text == "")
				{
					MessageBox.Show("Il faut obligatoirement saisir un type d'id pour une fourniture Industrie !", "",
													MessageBoxButtons.OK, MessageBoxIcon.Information);
					cboTypeId.Focus();
					return;
				}
			}

			//'test si reférence existe
			if (txtRef.Text != "" || txtRefCli.Text != "")
			{
				if (TestIfRefFabExiste(txtRef.Text, txtRefCli.Text, miNumFour))
				{
					if (MessageBox.Show("Voulez-vous tout de même enregistrer cet article ?", "Doublon fourniture", MessageBoxButtons.YesNo,
															MessageBoxIcon.Question, MessageBoxDefaultButton.Button2) == DialogResult.No)
						return;
				}
			}

			//test si etalonnage
			if (Chk_Fo_Etal_Tolerance.Checked & ((Txt_Etal_Min.EditValue == null | Txt_Etal_Max.EditValue == null)))
			{
				MessageBox.Show("Il faut obligatoirement saisir une valeur de tolérance minimale et maximale !", "Erreur",
									MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
				return;
			}

			// Test si cette fourniture est utilisée dans une gamme Stock client
			// si oui pas de modif possible a par admin
			// si copie alors pas de test
			if (mstrStatut != "COPIE")
			{
				switch (Utils.bModOK(miNumFour))
				{
					case 0:
						return;
					case 1:
						//'on ne fait rien
						break;
					case 2:
						//'on sauvegarde quand meme l'emplacement sur ceux qui ont le droit
						if (ModuleMain.RechercheDroitMenu(513))
							SaveEmplacementFou();
						OuvertureEnModification();
						return;
				}
			}

			Enregistrer();

		}

		private void SaveEmplacementFou()
		{
			try
			{
				Cursor.Current = Cursors.WaitCursor;
				using (SqlCommand cmd = new SqlCommand("api_sp_FournitureUpdateEmplacement", MozartDatabase.cnxMozart))
				{
					cmd.CommandType = CommandType.StoredProcedure;
					SqlCommandBuilder.DeriveParameters(cmd);
					cmd.Parameters["@iNum"].Value = miNumFour;
					cmd.Parameters["@emplace"].Value = txtEmplace.Text;
					cmd.ExecuteNonQuery();
				}
			}
			catch (Exception ex)
			{
				MZUtils.displayError(MethodBase.GetCurrentMethod().Name, ex);
			}
			finally
			{
				Cursor.Current = Cursors.Default;
			}
		}

		private void cmdSupp1_Click(object sender, System.EventArgs e)
		{
			txtDateA0.Text = "";
		}

		private void cmdFermer_Click(object sender, System.EventArgs e)
		{
			Close();
		}

		DateTime _curDate = DateTime.MinValue;
		private void Calendar1_CloseUp(object sender, EventArgs e)
		{
			Calendar1.Visible = false;
			if (_curDate == DateTime.MinValue) return;
			txtDateA0.Text = Calendar1.Value.ToShortDateString();
		}
		private void Calendar1_ValueChanged(object sender, EventArgs e)
		{
			if (Calendar1.Visible) _curDate = Calendar1.Value;
		}
		private void cmdDate1_Click(object sender, EventArgs e)
		{
			DateTime d;
			if (DateTime.TryParse(txtDateA0.Text, out d))
				_curDate = Calendar1.Value = d;
			else { _curDate = DateTime.MinValue; Calendar1.Value = DateTime.Now; }
			Calendar1.Visible = true;
			Calendar1.ShowCalendar(new MouseEventArgs(MouseButtons.Left, 1, MousePosition.X - this.Location.X, MousePosition.Y - this.Location.Y, 0));
		}

		private void OuvertureEnCreation()
		{
			// droit sur les série de fournitures
			cboSerie.Init(MozartDatabase.cnxMozart, $"select O.NCFOCOD,CCFOCOD from TREF_CFO O inner join TDROITSERIEARTICLE D ON O.NCFOCOD=D.NCFOCOD where O.BCFOACTIF = 1 " +
																		$"AND  DROIT='O' AND NPERNUM={MozartParams.UID} AND langue= '{MozartParams.Langue}' order by CCFOCOD",
																		"NCFOCOD", "CCFOCOD", new List<string>() { Resources.col_Num, Resources.col_Nom }, 150, 550, true);

			// VL spécifique MPM
			cboIndicePlan.SelectedIndex = 0;
			cboCriticite.SelectedIndex = 1;
			cboPieceRechange.SelectedIndex = 1;

			//'sélection auto du pays selon la societe
			switch (MozartParams.NomSociete)
			{
				case "EMALECESPAGNE":
					CboPaysFou.SetItemData(3);
					break;
				case "EMALECBELGIQUE":
					CboPaysFou.SetItemData(2);
					break;
				case "EMALECFACILITEAM":
					CboPaysFou.SetItemData(2);
					break;
				case "EMALECLUXEMBOURG":
					CboPaysFou.SetItemData(5);
					break;
				default:
					//'SelectLB CboPaysFou, 1
					//?
					break;
			}

			lblCreateur.Text = "";
			lblModif.Text = "";
			strImage = "";
			strImageMini = "";
			cboMarqueExt.Visible = false;
			txtMarque.Visible = true;

			//'Qte en stock
			lbQteStock.Text = "0";
		}

		private void OuvertureEnModification()
		{
			string lSql;

			//'activation bouton gestion des images
			cmdImgOpen.Enabled = true;
			cmdImgDel.Enabled = true;

			if (mstrStatut == "COPIE")
			{
				Label1.Text = Resources.msg_copie_fourniture;
				//    ' NL le 03/10/2016 : on cache la partie fournisseur jusqu'à ce que l'on ait enregistré la nouvelle fourniture
				//    '                    Sinon, toute modification impacte la fourniture déjà existante!
				Frame3.Visible = false;
			}
			else
			{
				Label1.Text = $"{Resources.msg_details_fourniture} {miNumFour}";
			}

			//'recherche des informations de l'action
			using (SqlDataReader reader = ModuleData.ExecuteReader($"SELECT * FROM api_v_InfoFourniture WHERE NFOUNUM = {miNumFour}"))
			{
				reader.Read();
				txtMat.Text = Utils.BlankIfNull(reader["VFOUMAT"]);
				//'si c'est un série EI extincteur, alors on affiche la combo marque
				if ((int)Utils.ZeroIfNull(reader["NCFOCOD"]) == 31)
				{
					cboMarqueExt.Visible = true;
					cboMarqueExt.Text = Utils.BlankIfNull(reader["VFOUMAR"]);
					txtMarque.Visible = false;
				}
				else
				{
					cboMarqueExt.Visible = false; ;
					txtMarque.Visible = true;
					txtMarque.Text = Utils.BlankIfNull(reader["VFOUMAR"]);
				}
				txtType.Text = Utils.BlankIfNull(reader["VFOUTYP"]);
				txtRef.Text = Utils.BlankIfNull(reader["VFOUREF"]);
				txtCond.Text = Utils.BlankIfNull(reader["VFOUCON"]);
				txtNBlot.Text = Utils.BlankIfNull(reader["nFOUnblot"]);
				txtUnite.Text = Utils.BlankIfNull(reader["VFOUunite"]);
				txtPoids.Text = Utils.BlankIfNull(reader["NFOUPOIDS"]);
				txtUniteVente.Text = Utils.ZeroIfNull(reader["NFOUUV"]).ToString();
				txtRecycle.Text = Utils.ZeroIfNull(reader["NFOUTAR"]).ToString();
				txtFouPrixMini.Text = Utils.ZeroIfNull(reader["NFOUPRIXMINI"]).ToString();
				cbEcoLabel.Checked = (bool)reader["BFOUECOLABEL"];
				ChkBoxPeremption.Checked = (bool)reader["BFOU_PEREMPTION"];

				//'Qte en stock
				lbQteStock.Text = Utils.ZeroIfNull(reader["NFOUQTESTOCK"]).ToString();

				// si copie fourniture, ne pas reprendre l'emplacement et les clients
				if (mstrStatut == "COPIE")
				{
					txtEmplace.Text = "";
					txtClients.Text = "";
				}
				else
				{
					txtEmplace.Text = Utils.BlankIfNull(reader["VFOUEMPLACEMENT"]);
					txtClients.Text = Utils.BlankIfNull(reader["VFOUCLI"]);
				}
				txtPrixVente.Text = Utils.BlankIfNull(reader["NFOUPVCONS"]);
				txtObs.Text = Utils.BlankIfNull(reader["VFOUOBS"]);
				txtRecycleVente.Text = Utils.ZeroIfNull(reader["NFOURECYCVEN"]).ToString();
				cboConcept.SetText(Utils.BlankIfNull(reader["VFOUCONCEPT"]));

				CboPaysFou.SetItemData((int)Utils.ZeroIfNull(reader["NFOUPAYSNUM"]));

				lblCreateur.Text = $"{Utils.BlankIfNull(reader["VFOUQUICRE"])} le {Utils.DateLongBlankIfNull(reader["DFOUDCRE"])}";
				lblModif.Text = $"{Utils.BlankIfNull(reader["VFOUQUIMOD"])} le {Utils.DateLongBlankIfNull(reader["DFOUDMOD"])}";
				lblDerUti.Text = "le " + Utils.DateLongBlankIfNull(reader["DFOULASTUSE"]);

				cboSerie.Init(MozartDatabase.cnxMozart, $"select NCFOCOD,CCFOCOD from TREF_CFO where langue= '{MozartParams.Langue}' order by CCFOCOD",
																			"NCFOCOD", "CCFOCOD", new List<string>() { Resources.col_Num, Resources.col_Nom }, 150, 550, true);

				cboSerie.SetItemData((int)Utils.ZeroIfNull(reader["NCFOCOD"]));
				int NSSCFONUM = (int)Utils.ZeroIfNull(reader["NSSCFONUM"]);
				if (NSSCFONUM > 0)
					cboSSSerie.SetItemData(NSSCFONUM);

				if (NSSCFONUM == 1 && (int)Utils.ZeroIfNull(reader["NFOUNUMVERIF"]) > 0)
				{
					if (MozartParams.NomSociete == "EMALECESPAGNE")
						cboVerif.Init(MozartDatabase.cnxMozart, "SELECT NFOUNUM, VFOUMATES as VFOUMAT FROM TFOU WITH (NOLOCK) WHERE NSSCFONUM = 11 AND VFOUMATES <> '' ORDER BY VFOUMAT",
													"NFOUNUM", "VFOUMAT", new List<string>() { Resources.col_Num, Resources.col_Nom }, 150, 550);
					else
						cboVerif.Init(MozartDatabase.cnxMozart, "SELECT NFOUNUM, VFOUMAT FROM TFOU WITH (NOLOCK) WHERE NSSCFONUM = 11 ORDER BY VFOUMAT",
							"NFOUNUM", "VFOUMAT", new List<string>() { Resources.col_Num, Resources.col_Nom }, 150, 550);

					cboVerif.SetItemData((int)Utils.ZeroIfNull(reader["NFOUNUMVERIF"]));
					lblVerif.Visible = cboVerif.Visible = true;
				}

				if ((int)Utils.ZeroIfNull(reader["NBFICDANGER"]) > 0)
					cmdFicheProdDang.BackColor = MozartColors.ColorH80FFFF;
				else
					cmdFicheProdDang.BackColor = MozartColors.ColorH8000000F;

				if ((int)Utils.ZeroIfNull(reader["NBFICHDP"]) > 0)
					CmdFicheTech.BackColor = MozartColors.ColorH80FFFF;
				else
					CmdFicheTech.BackColor = MozartColors.ColorH8000000F;

				LoadImgFou();

				// VL spécifique MPM
				cboTypeId.Text = Utils.BlankIfNull(reader["VFOUTYPEID"]);
				txtNumPlan.Text = Utils.BlankIfNull(reader["VFOUNUMPLAN"]);
				cboIndicePlan.Text = Utils.BlankIfNull(reader["VFOUINDICE"]);
				cboCriticite.Text = Utils.BlankIfNull(reader["VFOUCRITICITE"]);
				cboPieceRechange.Text = Utils.BlankIfNull(reader["VFOUPIECERECHANGE"]);

				//'recherche des informations des fournisseurs
				lSql = $"SELECT VSTFGRPNOM, FPUHT, FPUNITE, DFOUDPR, VSTFFOUREFCLI, NSTFGRPNUM, VNOMCREE, DQUIMOD, BSTFFOUCONTRATCADRE, DSTFFOUDATECONTRATCADRE";
				lSql += $" FROM api_v_ListeFournitures WHERE NFOUNUM = {miNumFour}";
				ApiGrid.LoadData(mDtPri, MozartDatabase.cnxMozart, lSql);
				ApiGrid.GridControl.DataSource = mDtPri;

				ApiGrid_SelectionChanged(null, null);

				// grille des prix client
				ListePrixClient();

				//etalonnage
				oFOU_ETAL_TECH = new CFOU_ETAL_TECH(miNumFour);
				if (oFOU_ETAL_TECH != null)
				{
					Chk_Fo_Etal_Tolerance.Checked = oFOU_ETAL_TECH.NID_FOU_ETAL_TECH > 0 ? true : false;
					Txt_Etal_Min.EditValue = oFOU_ETAL_TECH.NMINVALUE;
					Txt_Etal_Max.EditValue = oFOU_ETAL_TECH.NMAXVALUE;
				}
				else
				{
					Chk_Fo_Etal_Tolerance.Checked = false;
				}
			}
		}

		private void InitApigrid()
		{
			ApiGrid.AddColumn(Resources.col_Fournisseur, "VSTFGRPNOM", 1700);
			ApiGrid.AddColumn(Resources.col_Prix, "FPUHT", 800, "### ###.##", 2);
			ApiGrid.AddColumn(Resources.col_unite, "FPUNITE", 500, "", 2);
			ApiGrid.AddColumn(Resources.col_Date, "DFOUDPR", 1000, "dd/MM/yy", 2);
			ApiGrid.AddColumn(Resources.col_ref_cli, "VSTFFOUREFCLI", 800);
			ApiGrid.AddColumn(Resources.col_Num_Fournisseur, "NSTFGRPNUM", 0);
			ApiGrid.AddColumn(Resources.col_Qui, "VNOMCREE", 1000);
			ApiGrid.AddColumn(Resources.col_date_modif, "DQUIMOD", 0);
			ApiGrid.AddColumn("BSTFFOUCONTRATCADRE", "BSTFFOUCONTRATCADRE", 0);
			ApiGrid.AddColumn("DSTFFOUDATECONTRATCADRE", "DSTFFOUDATECONTRATCADRE", 0);

			ApiGrid.InitColumnList();
		}

		private void Enregistrer()
		{
			// pour la création ou la modification, c'est la proc stock qui gère
			if (mstrStatut == "COPIE")
			{
				miNumFour = 0;
			}

			using (SqlCommand cmd = new SqlCommand("api_sp_CreationFourniture", MozartDatabase.cnxMozart))
			{
				cmd.CommandType = CommandType.StoredProcedure;
				SqlCommandBuilder.DeriveParameters(cmd);

				cmd.Parameters["@iNum"].Value = miNumFour;
				cmd.Parameters["@serie"].Value = cboSerie.GetText();
				cmd.Parameters["@iserie"].Value = cboSerie.GetItemData();
				cmd.Parameters["@mat"].Value = txtMat.Text;
				//  'gestion différentes si serie EI extincteur
				if (cboSerie.GetItemData() == 31)
					cmd.Parameters["@Marque"].Value = cboMarqueExt.SelectedText;
				else
					cmd.Parameters["@Marque"].Value = txtMarque.Text;

				cmd.Parameters["@Type"].Value = txtType.Text;
				cmd.Parameters["@ref"].Value = txtRef.Text;
				cmd.Parameters["@unite"].Value = txtUnite.Text;
				cmd.Parameters["@poids"].Value = Utils.ZeroIfNull(txtPoids.Text);
				cmd.Parameters["@cond"].Value = txtCond.Text;
				cmd.Parameters["@nblot"].Value = txtNBlot.Text;
				cmd.Parameters["@unitevente"].Value = (Utils.ZeroIfNull(txtUniteVente.Text) == 0) ? 1 : Utils.ZeroIfNull(txtUniteVente.Text);
				cmd.Parameters["@recyclage"].Value = Utils.ZeroIfNull(txtRecycle.Text);
				cmd.Parameters["@emplace"].Value = txtEmplace.Text;
				cmd.Parameters["@iprixventeconseil"].Value = Utils.ZeroIfNull(txtPrixVente.Text);
				cmd.Parameters["@Obs"].Value = txtObs.Text;
				cmd.Parameters["@irecyclagevente"].Value = Utils.ZeroIfNull(txtRecycleVente.Text);
				cmd.Parameters["@concept"].Value = cboConcept.GetText();
				cmd.Parameters["@nsscfonum"].Value = cboSSSerie.GetItemData();
				cmd.Parameters["@nfounumVerif"].Value = cboVerif.GetItemData();
				cmd.Parameters["@bfouecolabel"].Value = cbEcoLabel.Checked; // NL Ajout du 12/02/2016       
				cmd.Parameters["@nfoupaysnum"].Value = CboPaysFou.GetItemData(); // MC Ajout du 20/09/2017

				//  ' VL Spécifique MPM
				cmd.Parameters["@vfoutypeid"].Value = cboTypeId.Text;
				cmd.Parameters["@vfounumplan"].Value = txtNumPlan.Text;
				cmd.Parameters["@vfouindice"].Value = cboIndicePlan.Text;
				cmd.Parameters["@vfoucriticite"].Value = cboCriticite.Text;
				cmd.Parameters["@vfoupiecerechange"].Value = cboPieceRechange.Text;

				if (txtFouPrixMini.Text != "")
					cmd.Parameters["@nfouprixmini"].Value = txtFouPrixMini.Text;

				cmd.Parameters["@FDS"].Value = "";

				cmd.Parameters["@BFOU_PEREMPTION"].Value = ChkBoxPeremption.Checked;

				cmd.ExecuteScalar();
				miNumFour = Convert.ToInt32(cmd.Parameters[0].Value);
			}

			if (oFOU_ETAL_TECH != null)
			{
				if (Chk_Fo_Etal_Tolerance.Checked)
				{
					oFOU_ETAL_TECH.NFOUNUM = miNumFour;
					oFOU_ETAL_TECH.NMINVALUE = Convert.ToDecimal(Txt_Etal_Min.EditValue);
					oFOU_ETAL_TECH.NMAXVALUE = Convert.ToDecimal(Txt_Etal_Max.EditValue);
					oFOU_ETAL_TECH.Save();
				}
				else
				{
					if (oFOU_ETAL_TECH.NID_FOU_ETAL_TECH > 0) oFOU_ETAL_TECH.Delete();
				}
			}

			if (mstrStatut == "COPIE")
			{
				//    ' NL, le 03/10/2016, en cas de copie, maintenant, on peut modifier le fournisseur
				Frame3.Visible = true;
			}

			if (!mbStatutValidation)
			{
				ModuleData.ExecuteNonQuery($"UPDATE TFOU SET BFOUVALID = 1 WHERE NFOUNUM = {miNumFour}");
			}
			//  ' on passe la feuille en statut modifier
			mstrStatut = "M";

			OuvertureEnModification();
		}

		private void frmDetailsFourniture_FormClosing(object sender, FormClosingEventArgs e)
		{
			if (miNumFour == 0)
				return;
			//  ' test si la fourniture possede bien un fournisseur
			int nb = (int)ModuleData.ExecuteScalarInt($"select count(*) from TSTFFOU where NFOUNUM={miNumFour}");
			if (nb == 0)
			{
				MessageBox.Show(Resources.msg_sel_fournisseur_article, Program.AppTitle, MessageBoxButtons.OK, MessageBoxIcon.Information);
				e.Cancel = true;
			}
		}

		private void listImages1_MouseClick(object sender, MouseEventArgs e)
		{
			for (int i = 0; i < listImages1.Items.Count; i++)
			{
				var rectangle = listImages1.GetItemRect(i);
				if (rectangle.Contains(e.Location))
				{
					txtImgFichier.Text = mFichiersImages[i];
					using (Image img = Image.FromFile($"{strRepFour}TN\\tn_{mFichiersImages[i]}"))
					{
						Image1.Image = new Bitmap(img);
					}
					Image1.Visible = true;
					Image1.BringToFront();
					strImage = $"{strRepFour}{mFichiersImages[i]}";
					strImageMini = $"{strRepFour}TN\\tn_{mFichiersImages[i]}";
					return;
				}
			}
		}

		private void txtMat_Leave(object sender, EventArgs e)
		{
			txtMat.Text = txtMat.Text.ToUpper();
		}

		private void txtPrix_TextChanged(object sender, EventArgs e)
		{
			txtDateA0.Text = DateTime.Now.ToShortDateString();
		}

		private void txtPrix_KeyPress(object sender, KeyPressEventArgs e)
		{
			if (e.KeyChar == (char)45)
			{
				if (ModuleMain.RechercheDroitMenu(382))
					return;
			}
			KeyValidator.KeyPress_SaisieMontant(e);
		}

		private void txtUnite_Leave(object sender, EventArgs e)
		{
			txtUnite.Text = txtUnite.Text.ToUpper();
		}

		private void txtUprix_KeyPress(object sender, KeyPressEventArgs e)
		{
			KeyValidator.KeyPress_SaisieMontant(e);
		}

		private void EnregistrerImage()
		{
			if (CommonDialog1.FileName == "" || txtImgFichier.Text == "")
				return;
			try
			{
				Cursor.Current = Cursors.WaitCursor;
				// Récupération compteur et mise à jour dans la table
				using (SqlCommand cmd = new SqlCommand("api_sp_GetCpt", MozartDatabase.cnxMozart))
				{
					cmd.CommandType = CommandType.StoredProcedure;
					SqlCommandBuilder.DeriveParameters(cmd);
					cmd.Parameters["@cElt"].Value = "IMGFOU";
					cmd.Parameters["@iCpt"].Value = 0;
					cmd.ExecuteNonQuery();
					long lcount = (long)Utils.ZeroIfNull(cmd.Parameters["@iCpt"].Value);
					txtImgFichier.Text = $"FOU_{ miNumFour}_{ lcount}{Path.GetExtension(CommonDialog1.FileName)}";
					// Recopier le fichier sélectionné sur le serveur
					strImage = $"{strRepFour}{txtImgFichier.Text}";
					strImageMini = $"{strRepFour}TN\\TN_{txtImgFichier.Text}";
					File.Copy(CommonDialog1.FileName, strImage, true);
				}
			}
			catch (Exception ex)
			{
				MZUtils.displayError(MethodBase.GetCurrentMethod().Name, ex);
			}
			finally
			{
				Cursor.Current = Cursors.Default;
			}
		}

		private void cmdImgOpen_Click(object sender, EventArgs e)
		{
			//  'gestion des vignettes
			//  ' 9 vignettes maximum on met a 10 car le count contabilise le (0) qui n'est pas gérer dans l'affichage
			if (imageList1.Images.Count == 9)
			{
				MessageBox.Show(Resources.msg_nombre_images_maxi_fourniture, Program.AppTitle, MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
				return;
			}

			CommonDialog1.ReadOnlyChecked = true;
			CommonDialog1.Title = Resources.msg_select_image_file;
			CommonDialog1.Filter = "Images (*.gif;*.jpg;*.jpeg)|*.gif;*.jpg;*.jpeg";
			CommonDialog1.FilterIndex = 1;
			if (CommonDialog1.ShowDialog() != DialogResult.OK)
				return;

			txtImgFichier.Text = Path.GetFileName(CommonDialog1.FileName);

			EnregistrerImage();

			ModuleData.ExecuteNonQuery($"INSERT INTO TFOUIMG(NFOUNUM,VFOUIMG) VALUES({miNumFour},'{txtImgFichier.Text}')");

			LoadImgFou();
		}

		private void ApiGrid_SelectionChanged(object sender, DevExpress.Data.SelectionChangedEventArgs e)
		{
			if (miNumFour == 0) return;

			DataRow row = ApiGrid.GetFocusedDataRow();
			if (null != row)
			{
				cboFour.SetItemData((int)Utils.ZeroIfNull(row["NSTFGRPNUM"]));
				if (cboFour.GetItemData() != (int)Utils.ZeroIfNull(row["NSTFGRPNUM"]) &&
						null != cboFour.DataSource())
				{
					DataRow r = (cboFour.DataSource() as DataTable).NewRow();
					r["VSTFGRPNOM"] = Utils.BlankIfNull(row["VSTFGRPNOM"]);
					r["NSTFGRPNUM"] = (int)Utils.ZeroIfNull(row["NSTFGRPNUM"]);
					(cboFour.DataSource() as DataTable).Rows.Add(r);
				}

				txtPrix.Text = Utils.ZeroIfNull(row["FPUHT"]).ToString();
				sPrixMem = txtPrix.Text;
				txtRefCli.Text = Utils.BlankIfNull(row["VSTFFOUREFCLI"]);
				txtUprix.Text = Utils.ZeroIfNull(row["FPUNITE"]).ToString();
				txtDateA0.Text = Utils.DateBlankIfNull(row["DFOUDPR"]);

				cboFour.Enabled = false;

				chkContratCadre.Checked = (Convert.ToInt32(row["BSTFFOUCONTRATCADRE"]) == 1);
				bOldStateChkContratCadre = chkContratCadre.Checked;
				if (row["DSTFFOUDATECONTRATCADRE"] != DBNull.Value)
				{
					txtDateValidContratCadre.DateTime = ((DateTime)row["DSTFFOUDATECONTRATCADRE"]).Date;
				}
				else
				{
					txtDateValidContratCadre.EditValue = null;
				}

				LblModSTFFOU.Text = "";
				if (chkContratCadre.Checked)
				{
					LblModSTFFOU.Text = $"Prix unitaire lié à un contrat cadre géré par le sevice Achat.{Environment.NewLine}" +
														$"Modifié par {Utils.BlankIfNull(row["VNOMCREE"])} {Resources.lbl_Le} {Utils.DateLongBlankIfNull(row["DQUIMOD"])}";
				}
				else
				{
					if (Utils.BlankIfNull(row["VNOMCREE"]) != "" && Utils.DateBlankIfNull(row["DQUIMOD"]) != "")
					{
						LblModSTFFOU.Text = $"{Resources.lbl_prix_unit_modif_par} {Utils.BlankIfNull(row["VNOMCREE"])}{Environment.NewLine}{Resources.lbl_Le} " +
																Utils.DateLongBlankIfNull(row["DQUIMOD"]);
					}
				}
				updateValiditeContratCadre();

				strStatut = "M";
			}
			else
			{
				chkContratCadre.Checked = false;
				txtDateValidContratCadre.EditValue = null;

				cboFour.SetItemData(-1);
				cboFour.Enabled = true;
				txtPrix.Text = "";
				txtRefCli.Text = "";
				txtUprix.Text = "";
				LblModSTFFOU.Text = "";
				txtDateA0.Text = DateTime.Now.ToShortDateString();

				strStatut = "C";
			}
		}

		private void LoadImgFou()
		{
			Image1.Visible = false;
			imageList1.Images.Clear();
			listImages1.Clear();
			mFichiersImages.Clear();
			int i = 0;
			using (SqlDataReader reader = ModuleData.ExecuteReader($"SELECT * FROM TFOUIMG WITH(NOLOCK) WHERE NFOUNUM={miNumFour} ORDER BY NFOUIMGNUM"))
			{
				while (reader.Read() && imageList1.Images.Count < 10)
				{
					string chemin = $"{strRepFour}TN\\tn_{reader["VFOUIMG"]}";
					if (!File.Exists(chemin)) continue;
					System.Drawing.Image img = Image.FromFile(chemin);
					imageList1.Images.Add(img);
					img.Dispose();
					listImages1.Items.Add(new ListViewItem());
					listImages1.Items[i].ImageIndex = i;
					listImages1.Items[i].Tag = reader["NFOUIMGNUM"];
					mFichiersImages.Add(Utils.BlankIfNull(reader["VFOUIMG"]));
					i++;
				}
			}
		}

		private void cmdBricoFou_Click(object sender, EventArgs e)
		{
			new frmDetailsFournitureWebMarchand().ShowDialog();
		}

		private void cmdHistoCF_Click(object sender, EventArgs e)
		{
			new frmListeHistoCF() { miNumFour = miNumFour }.ShowDialog();
		}

		private void cboSerie_TxtChanged(object sender, EventArgs e)
		{
			if (cboSerie.GetText() != "")
			{
				cboSSSerie.Init(MozartDatabase.cnxMozart, $"SELECT NSSCFONUM, VSSCFOLIB FROM API_V_LISTESOUSSERIEFOU WHERE NCFOCOD = {cboSerie.GetItemData()} " +
																				$"AND LANGUE = '{MozartParams.Langue}' ORDER BY VSSCFOLIB", "NSSCFONUM", "VSSCFOLIB",
																				new List<string>() { Resources.col_Num, Resources.col_Nom }, 150, 550);
				lblSSSerie.Visible = cboSSSerie.Visible = true;

				// VL Spécifique MPM
				fraIndustrie.Visible = (cboSerie.GetItemData() == 53);

				if (cboSerie.GetItemData() == 31)
				{
					txtMarque.Visible = false;
					cboMarqueExt.Visible = true;
					lblLabels34.Visible = txtFouPrixMini.Visible = ModuleMain.RechercheDroitMenu(401);
				}
				else
				{
					txtMarque.Visible = true;
					cboMarqueExt.Visible = false;
					lblLabels34.Visible = txtFouPrixMini.Visible = false;
				}
			}
			else
			{
				if (null != cboSSSerie.DataSource())
					(cboSSSerie.DataSource() as DataTable).Rows.Clear();
				lblSSSerie.Visible = cboSSSerie.Visible = false;

				cboMarqueExt.Visible = false;
				txtMarque.Visible = true;

				lblLabels34.Visible = txtFouPrixMini.Visible = false;
			}
		}

		private void cboSSSerie_Leave(object sender, EventArgs e)
		{
			if (cboSSSerie.GetItemData() == 1)
			{
				// affichage différent pour iberica (barbosa)
				if (MozartParams.NomSociete == "EMALECESPAGNE")
					cboVerif.Init(MozartDatabase.cnxMozart, "SELECT NFOUNUM, VFOUMATES as VFOUMAT FROM TFOU WITH (NOLOCK) WHERE NSSCFONUM = 11 AND VFOUMATES <> '' ORDER BY VFOUMAT",
												"NFOUNUM", "VFOUMAT", new List<string>() { Resources.col_Num, Resources.col_Nom }, 150, 550);
				else
					cboVerif.Init(MozartDatabase.cnxMozart, "SELECT NFOUNUM, VFOUMAT FROM TFOU WITH (NOLOCK) WHERE NSSCFONUM = 11 ORDER BY VFOUMAT",
												"NFOUNUM", "VFOUMAT", new List<string>() { Resources.col_Num, Resources.col_Nom }, 150, 550);

				lblVerif.Visible = cboVerif.Visible = true;
			}
			else
			{
				if (null != cboVerif.DataSource())
					(cboVerif.DataSource() as DataTable).Rows.Clear();
				lblVerif.Visible = cboVerif.Visible = false;

			}
		}

		private void cmdFicheProdDang_Click(object sender, EventArgs e)
		{
			new frmFicheFourniture(miNumFour, 1).ShowDialog();
		}

		private void CmdFicheTech_Click(object sender, EventArgs e)
		{
			new frmFicheFourniture(miNumFour, 0).ShowDialog();
		}

		private void Image1_Click(object sender, EventArgs e)
		{
			Image1.Visible = false;
		}

		private void ListePrixClient()
		{
			if (mbPrem)
			{
				apiTGridW.AddColumn(MZCtrlResources.col_Client, "VCLINOM", 2000);
				apiTGridW.AddColumn("Prix vente", "NPUHTCLI", 1200, "###.00", 1);
				apiTGridW.AddColumn("Vendu sur 12 mois", "NFOUNBUTIL", 1000, "", 2);
				apiTGridW.AddColumn("Client/Partenaire", "TypeClient", 1200, "", 2);
				apiTGridW.AddColumn("Coef prix mini/vente", "Coef", 1500, "###.00", 1);

				apiTGridW.InitColumnList();

				mDtRs = new DataTable();
				apiTGridW.LoadData(mDtRs, MozartDatabase.cnxMozart, $"exec api_sp_RecherchePrixClientFouV2 {miNumFour}");
				apiTGridW.GridControl.DataSource = mDtRs;
				mbPrem = false;
			}
			else
			{
				apiTGridW.Requery(mDtRs, MozartDatabase.cnxMozart);
			}
		}

		private void apiTGridW_DoubleClickE(object sender, EventArgs e)
		{
			DataRow row = apiTGridW.GetFocusedDataRow();
			if (null == row) return;

			if ((int)Utils.ZeroIfNull(row["NCFOCOD"]) == 31)
			{
				new frmStockArticleClientExtincteurs((int)Utils.ZeroIfNull(row["NCLINUM"]), "M").ShowDialog();
			}
			else
			{
				new frmStockArticleClient()
				{
					mstrStatut = "M",
					miNumClient = (int)Utils.ZeroIfNull(row["NCLINUM"]),
					mstrActif = Utils.BlankIfNull(row["CACTIF"])
				}.ShowDialog();
			}

			apiTGridW.Requery(mDtRs, MozartDatabase.cnxMozart);
		}

		private bool TestIfRefFabExiste(string sRef, string sRefCli, int iFounum)
		{
			//    ' NL le 03/10/2016, suite PB doublons Bertrand
			//    ' Dans le cas d'une copie, on interdit la même référence interne et la même référence fournisseur, sans se soucier du NFOUNUM
			string sql;
			if (mstrStatut == "COPIE")
				sql = $"exec [api_sp_ListeFournituresExistsByRef_SansNFOUNUM] '{sRef.Replace("'", "''")}'";
			else
				sql = $"exec [api_sp_ListeFournituresExistsByRef] '{sRef.Replace("'", "''")}', '{sRefCli.Replace("'", "''")}', {iFounum}";

			using (SqlDataReader reader = ModuleData.ExecuteReader(sql))
			{
				if (reader.Read())
				{
					new frmListeFournituresExists()
					{
						msRefSearch = sRef,
						msRefCliSearch = sRefCli,
						miNFOUNUM = iFounum,
						mstrStatut = mstrStatut
					}.ShowDialog();

					return true;
				}
				else
				{
					return false;
				}
			}
		}

		private void apiButton1_Click(object sender, EventArgs e)
		{
			HistoriqueClient();
			apiGrpPrix.Visible = true;
		}

		private void cboFour_TxtChanged(object sender, EventArgs e)
		{
			updateValiditeContratCadre();
		}

		private void chkContratCadre_CheckStateChanged(object sender, EventArgs e)
		{
			setDateContratCadreVisible(chkContratCadre.Checked);
		}

		private void setDateContratCadreVisible(bool pVisible)
		{
			txtDateValidContratCadre.Visible = pVisible;
			apiLabel1.Visible = pVisible;
		}

		private void Chk_Fo_Etal_Tolerance_CheckedChanged(object sender, EventArgs e)
		{
			LblEtal_Entre.Visible = Txt_Etal_Min.Visible = LblEtal_Et.Visible = Txt_Etal_Max.Visible = LblEtal_fin.Visible = Chk_Fo_Etal_Tolerance.Checked;
		}

		private void HistoriqueClient()
		{
			if (mbPremHistoPrix)
			{
				apiTGridHistoPrix.AddColumn(Resources.col_Date, "DATEMOD", 1100, "dd/mm/yyyy");
				apiTGridHistoPrix.AddColumn("Prix ", "PHT", 1000, "###.00", 1);
				apiTGridHistoPrix.AddColumn("Modificateur", "VPERNOM", 1200, "", 2);
				apiTGridHistoPrix.AddColumn("Fournisseur", "VSTFGRPNOM", 1400, "", 2);
				apiTGridHistoPrix.AddColumn("Filiale", "SOCIETE", 1200, "", 2);
				apiTGridHistoPrix.AddColumn("% Evolution prix", "COEF", 1400, "##0.00", 1);

				apiTGridHistoPrix.InitColumnList();

				mDtHp = new DataTable();
				apiTGridHistoPrix.LoadData(mDtHp, MozartDatabase.cnxMozart, $"exec api_sp_RechercheHistoriquePrixFou {miNumFour}");
				apiTGridHistoPrix.GridControl.DataSource = mDtHp;
				mbPremHistoPrix = false;
			}
			else
			{
				apiTGridHistoPrix.Requery(mDtHp, MozartDatabase.cnxMozart);
			}
		}

		private void TestMontant_KeyPress(object sender, KeyPressEventArgs e)
		{
			KeyValidator.KeyPress_SaisieMontant(e);
		}
	}
}