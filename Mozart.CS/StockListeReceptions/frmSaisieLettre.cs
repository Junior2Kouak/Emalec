using Microsoft.VisualBasic;
using MozartCS.Properties;
using MozartNet;
using MozartLib;
using ReportEmalec.Net;
using System;
using System.Data;
using System.Data.SqlClient;
using System.Reflection;
using System.Windows.Forms;
using MZUtils = MozartControls.Utils;

namespace MozartCS
{
	public partial class frmSaisieLettre : Form
	{

		public bool bSas;
		public string msLibNomSoc = "";
		public string mstrTypeAR = "";
		public string mstrTypeDest = "";
		public string mstrTypeCour = "";
		public string mstrStatutCourrier = "";
		public long iNumCourrier, lNumAction;

		private long identifiantUniqueCourrier;
		private bool bModif = false;

		public DataTable dtLettre = new DataTable();

		public frmSaisieLettre()
		{
			InitializeComponent();
		}

		private void frmSaisieLettre_Load(object sender, System.EventArgs e)
		{
			try
			{
				ModuleMain.Initboutons(this);
				lblTitre.Text += " - " + msLibNomSoc;

				if (mstrStatutCourrier == "C")
					InitialiserFeuilleVide();
				else  // on est en modification
					InitialiserFeuille();

				if (mstrTypeCour == "C")
					lblTitre.Text = Resources.txt_AttestationControleElect;


				lblNumAR.Visible = txtNumAR.Visible = (mstrTypeAR == "R");

				// combo des langues pour affichage du courrier
				RemplirComboLangues();

				AfficheDestinataires();
			}
			catch (Exception ex)
			{
				MZUtils.displayError(MethodBase.GetCurrentMethod().Name, ex);
			}
		}

		private void cmdFermer_Click(object sender, System.EventArgs e)
		{
			if (bModif)
			{
				switch (MessageBox.Show(Resources.msgConfirm_enregistrerModif, Program.AppTitle, MessageBoxButtons.YesNoCancel, MessageBoxIcon.Question, MessageBoxDefaultButton.Button2))
				{
					case DialogResult.Yes:
						EnregistrerCourrier();
						break;
					case DialogResult.No:
						break;
					case DialogResult.Cancel:
						return;
				}
			}

			Close();
		}

		private void cmdValider_Click(object sender, EventArgs e)
		{
			try
			{
				if (!TestValidation())
					return;

				EnregistrerCourrier();

				mstrStatutCourrier = "M";

				InitialiserFeuille();

				bModif = false;
			}
			catch (Exception ex)
			{
				MZUtils.displayError(MethodBase.GetCurrentMethod().Name, ex);
			}
		}

		private void cmdVisu_Click(object sender, EventArgs e)
		{
			try
			{
				string sCodeLangue = "";

				if (iNumCourrier == 0)
				{
					MessageBox.Show(Resources.msg_ImpresImp, Program.AppTitle, MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
					return;
				}

				// Courrier attestation élec plus géré
				if (mstrTypeCour == "C")
				{
					MessageBox.Show($"Ce courrier n'est plus géré, contactez le service informatique.",
											Resources.Global_Erreur, MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
					return;
				}

				DataRow row = dtLettre.Rows[0];
				string InfosMail = "";
				switch (mstrTypeDest)
				{
					case "Service Technique": // Modif du 06/06/2016 pour les PC Sécurité
						InfosMail = $"TSERVTECH|NSERVTECHNUM|{row["IDdest"]}";
						break;
					case "Client":
						InfosMail = $"TCCL|NCCLNUM|{row["IDdest"]}";
						break;
					case "Sous-traitant":
					case "Fournisseur":
					case "RelanceDocAdmin":
						InfosMail = $"TINT|NINTNUM|{row["IDdest"]}";
						break;
					case "Site":  // TSIT
						InfosMail = $"TSIT|NSITNUM|{row["IDdest"]}";
						break;
					case "Personnel":
						InfosMail = $"TPER|NPERNUM|{row["IDdest"]}";
						break;
				}

				if (cboLangue.Text != "")
					sCodeLangue = Strings.Right(cboLangue.Text, 2) + @"\";
				else
					sCodeLangue = ModuleMain.CodePays(ModuleMain.GetPaysDest(mstrTypeDest, (long)Utils.ZeroIfNull(row["IDdest"])));

        new frmMainReport
        {
          bLaunchByProcessStart = false,
          sTypeReport = PrepareReport.TLETTREV3,
          sIdentifiant = $"{identifiantUniqueCourrier}|0|{row["IDdest"]}",
          InfosMail = InfosMail,
          sNomSociete = MozartParams.NomSociete,
          sLangue = Strings.Left(sCodeLangue, 2),
          sOption = "PREVIEW",
          strType = "CO",
          numAction = MozartParams.NumAction
        }.ShowDialog();
      }
      catch (Exception ex)
			{
				MZUtils.displayError(MethodBase.GetCurrentMethod().Name, ex);
			}
		}

		private void cmdImprimer_Click(object sender, EventArgs e)
		{
			try
			{
				if (iNumCourrier == 0)
				{
					MessageBox.Show(Resources.msg_ImpresImp, Program.AppTitle, MessageBoxButtons.OK, MessageBoxIcon.Information);
					return;
				}

				// confirmation
				if (MessageBox.Show(Resources.msg_ConfirmImpresChaqueDest, Program.AppTitle, MessageBoxButtons.YesNoCancel, MessageBoxIcon.Question,
							MessageBoxDefaultButton.Button2) != DialogResult.Yes)
					return;

				string modele = ModuleMain.RechercheModele(mstrTypeCour);

				Cursor = Cursors.WaitCursor;

				foreach (DataRow row in dtLettre.Rows)
				{
					switch (mstrTypeCour)
					{
						case "L":
						case "F":
						case "N":
							Imprimer(identifiantUniqueCourrier, Convert.ToInt64(row["IdDest"]), modele, "1/1  Original");
							break;
						case "C":
							MessageBox.Show($"Ce courrier n'est plus géré, contactez le service informatique.",
													Resources.Global_Erreur, MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
							break;
						default:
							break;
					}
				}

				MessageBox.Show(Resources.msg_ImpressionsLancees, Program.AppTitle, MessageBoxButtons.OK, MessageBoxIcon.Information);
			}
			catch (Exception ex)
			{
				MZUtils.displayError(MethodBase.GetCurrentMethod().Name, ex);
			}
			finally
			{
				Cursor = Cursors.Default;
			}
		}


		private bool TestValidation()
		{
			try
			{
				if (txtRef.Text == "")
				{
					MessageBox.Show(Resources.msg_EntrezRefDansZoneRef, Program.AppTitle, MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
					txtRef.Focus();

					return false;
				}

				if (txtObjet.Text == "")
				{
					MessageBox.Show(Resources.msg_EntrezObjetDansZoneObjet, Program.AppTitle, MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
					txtObjet.Focus();

					return false;
				}

				if (txtLettre.Text == "")
				{
					MessageBox.Show(Resources.msg_SaisissezTextDansZoneText, Program.AppTitle, MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
					txtLettre.Focus();

					return false;
				}

				if (txtNumAR.Text == "" && txtNumAR.Visible)
				{
					MessageBox.Show(Resources.msg_SaisissezNumAR, Program.AppTitle, MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
					txtNumAR.Focus();

					return false;
				}
			}
			catch (Exception ex)
			{
				MZUtils.displayError(MethodBase.GetCurrentMethod().Name, ex);
			}

			return true;
		}

		private void frmSaisieLettre_KeyPress(object sender, KeyPressEventArgs e)
		{
			bModif = true;
		}

		private void AfficheDestinataires()
		{
			string sSQL = "";
			try
			{
				cmdModeles.Visible = true;

				if (dtLettre.Rows.Count == 1)
				{
					lblDest.Visible = lstDest.Visible = false;
					lblNom.Visible = txtNom.Visible = txtCont.Visible = true;

					DataRow row = dtLettre.Rows[0];

					switch (mstrTypeDest)
					{
						case "Service Technique": //Modif du 04/02/2016 pour les PC Sécurité
							sSQL = $"select VSERVTECHNOM, coalesce(VSERVTECHCONTNOM,'') FROM TSERVTECH WITH (NOLOCK) INNER JOIN TSERVTECHCONT ON TSERVTECHCONT.NSERVTECHNUM " +
										 $"= TSERVTECH.NSERVTECHNUM WHERE VSERVTECHCONTTYPE = 'S' AND TSERVTECH.NSERVTECHNUM = {row["IDdest"]}";
							break;

						case "Client":
							sSQL = $"select VCLINOM, VCCLNOM from TCLI WITH (NOLOCK), TCCL WITH(NOLOCK) WHERE TCLI.NCLINUM = TCCL.NCLINUM AND NCCLNUM =  {row["IDdest"]}";
							break;

						case "Sous-traitant":
						case "Fournisseur":
							sSQL = $"select VSTFNOM , coalesce(VINTNOM,'') from TINT WITH (NOLOCK), TSTF WITH (NOLOCK) WHERE TSTF.NSTFNUM = TINT.NSTFNUM AND NINTNUM = {row["IDdest"]}";

							break;

						case "Site": //TSIT / TCCL
							sSQL = $"select coalesce(VSITENSEIGNE,'') + ' - ' +  VSITNOM , coalesce(TCSIT.VCSITNOM,'') FROM TSIT WITH (NOLOCK), TCSIT WITH (NOLOCK) " +
										 $"WHERE TCSIT.NSITNUM = TSIT.NSITNUM AND TCSIT.NTYPCSITNUM = 1 AND TSIT.NSITNUM = {row["IDdest"]}";
							break;

						case "Personnel":
							sSQL = $"select VPERNOM + ' - ' + VPERPRE, '' from TPER WITH (NOLOCK) WHERE NPERNUM = {row["IDdest"]}";
							break;

						case "RelanceDocAdmin":
							lblNom.Visible = txtNom.Visible = txtCont.Visible = cmdModeles.Visible = false;
							cboDest.Visible = lblContact.Visible = true;
							RemplirComboContactST(cboDest, $"SELECT NINTNUM, VINTNOM FROM TINT WITH (NOLOCK) INNER JOIN TSTF WITH (NOLOCK) ON TSTF.NSTFNUM = TINT.NSTFNUM " +
																						 $"WHERE CINTACTIF = 'O' AND TSTF.CSTFACTIF = 'O' AND TSTF.NSTFGRPNUM = {row["IDdest"]} ORDER BY VINTNOM");
							cboDest.ValueMember = "NINTNUM";
							cboDest.DisplayMember = "VINTNOM";
							break;
						default:
							break;
					}

					if (mstrTypeDest != "RelanceDocAdmin")
					{
						using (SqlDataReader sdr = ModuleData.ExecuteReader(sSQL))
						{
							if (sdr.Read())
							{
								txtNom.Text = Utils.BlankIfNull(sdr[0].ToString());
								txtCont.Text = Utils.BlankIfNull(sdr[1].ToString());
							}
							sdr.Close();
						}
					}
				}
				else
				{
					string tempDest = "";
					lblNom.Visible = lblContact.Visible = txtNom.Visible = txtCont.Visible = cboDest.Visible = false;

					// vider la listeBox
					lstDest.Items.Clear();

					foreach (DataRow row in dtLettre.Rows)
					{
						switch (mstrTypeDest)
						{
							case "Client":
								tempDest = MozartDatabase.ExecuteScalarString($"select VCLINOM + ' - ' + VCCLNOM from TCLI, TCCL WHERE TCLI.NCLINUM = TCCL.NCLINUM AND NCCLNUM = {row["IDdest"]}");
								break;
							case "Sous-traitant":
							case "Fournisseur":
								tempDest = MozartDatabase.ExecuteScalarString($"select VSTFNOM + ' - ' +  coalesce(VINTNOM,'') from TINT, TSTF WHERE TSTF.NSTFNUM = TINT.NSTFNUM AND NINTNUM = {row["IDdest"]}");
								break;
							case "Site": //TSIT / TCCL
								tempDest = MozartDatabase.ExecuteScalarString($"select coalesce(VSITENSEIGNE,'') + ' - ' +  VSITNOM + ' - ' + coalesce(TCSIT.VCSITNOM,'') FROM TSIT WITH (NOLOCK), TCSIT WITH (NOLOCK) " +
																													$"WHERE TCSIT.NSITNUM = TSIT.NSITNUM AND TCSIT.NTYPCSITNUM = 1 AND TSIT.NSITNUM = {row["IDdest"]}");
								break;
							case "Personnel":
								tempDest = MozartDatabase.ExecuteScalarString($"select VPERNOM + ' - ' + VPERPRE from TPER WHERE NPERNUM = {row["IDdest"]}");
								break;
							default:
								break;
						}

						// ajout dans la liste box
						lstDest.Items.Add(tempDest);
					}
				}
			}
			catch (Exception ex)
			{
				MZUtils.displayError(MethodBase.GetCurrentMethod().Name, ex);
			}
		}

		private void EnregistrerCourrier()
		{
			try
			{
				if (mstrStatutCourrier == "M")
				{
					if (iNumCourrier == 0) return; //on enregistre les modifications pour toutes les lignes

					if (mstrTypeDest == "RelanceDocAdmin")
						EnregistrerLigne(cboDest.GetItemData(), iNumCourrier, "Modification");
					else
						EnregistrerLigne(Convert.ToInt64(dtLettre.Rows[0]["IDdest"]), iNumCourrier, "Modification");
				}
				else
				{
					// pour le premier enregistrement ,iNumCourrier = 0 puis on récupère le numéro créé
					foreach (DataRow item in dtLettre.Rows)
					{
						if (mstrTypeDest == "RelanceDocAdmin")
							EnregistrerLigne(cboDest.GetItemData(), iNumCourrier, "Creation");
						else
							EnregistrerLigne(Convert.ToInt64(item["IDdest"]), iNumCourrier, "Creation");
					}
				}
			}
			catch (Exception ex)
			{
				MZUtils.displayError(MethodBase.GetCurrentMethod().Name, ex);
			}
		}

		private void EnregistrerLigne(long iNumDest, long Courrier, string sAction)
		{
			try
			{
				using (SqlCommand cmd = new SqlCommand("api_sp_creationCourrier", MozartDatabase.cnxMozart))
				{
					cmd.CommandType = CommandType.StoredProcedure;

					// liste des paramètres
					SqlCommandBuilder.DeriveParameters(cmd);

					cmd.Parameters["@iNumCour"].Value = iNumCourrier;
					cmd.Parameters["@sAction"].Value = sAction;
					cmd.Parameters["@iCourrier"].Value = Courrier;
					cmd.Parameters["@Ref"].Value = ModuleMain.ReplaceCharToBD(txtRef.Text, "RTF");
					cmd.Parameters["@obj"].Value = ModuleMain.ReplaceCharToBD(txtObjet.Text, "RTF");
					cmd.Parameters["@corps"].Value = ModuleMain.ReplaceCharToBD(txtLettre.Text, "RTF");
					cmd.Parameters["@pied"].Value = ModuleMain.ReplaceCharToBD(txtPied.Text, "RTF");
					cmd.Parameters["@TypeDest"].Value = mstrTypeDest;
					cmd.Parameters["@TypeCour"].Value = mstrTypeCour;
					cmd.Parameters["@TypeAR"].Value = mstrTypeAR;
					cmd.Parameters["@sCompte"].Value = txtCompte.Text;
					cmd.Parameters["@iDest"].Value = iNumDest;
					cmd.Parameters["@dDate"].Value = DateTime.Now;
					cmd.Parameters["@iAction"].Value = lNumAction;
					cmd.Parameters["@NumAR"].Value = txtNumAR.Text;
					cmd.Parameters["@cSAS"].Value = bSas ? "S" : "";
					// FGB : ?????????  cmd.Parameters["@vsociete"].Value = MozartParams.NomSociete == "GROUPE" ? msLibNomSoc : msLibNomSoc;
					cmd.Parameters["@vsociete"].Value = msLibNomSoc;
					cmd.Parameters["@p_idout"].Value = 0;

					cmd.ExecuteNonQuery();
					// Récupérer la valeur en retour
					iNumCourrier = Convert.ToInt64(cmd.Parameters[0].Value);
					cmd.Dispose();
				}
			}
			catch (Exception ex)
			{
				MZUtils.displayError(MethodBase.GetCurrentMethod().Name, ex);
			}
		}

		private void InitialiserFeuille()
		{
			try
			{
				Cursor = Cursors.WaitCursor;

				dtLettre.Rows.Clear();
				using (SqlDataReader sdr = MozartDatabase.ExecuteReader($"api_sp_RetourInfoCourrier {iNumCourrier} , 0, '{msLibNomSoc}'"))
				{
					bool bFirstTime = true;
					while (sdr.Read())
					{
						if (bFirstTime)
						{
							//les infos de la feuille
							txtObjet.Text = ModuleMain.ReplaceCharFromBD(Utils.BlankIfNull(sdr["VCOUROBJET"]), "RTF");
							txtRef.Text = ModuleMain.ReplaceCharFromBD(Utils.BlankIfNull(sdr["VCOURREF"]), "RTF");
							txtLettre.Text = ModuleMain.ReplaceCharFromBD(Utils.BlankIfNull(sdr["VCOURCORPS"]), "RTF");
							txtPied.Text = ModuleMain.ReplaceCharFromBD(Utils.BlankIfNull(sdr["VCOURPIED"]).ToString(), "RTF");
							txtCompte.Text = Utils.BlankIfNull(sdr["NCOURCTE"].ToString());
							txtTypCour.Text = TypeCour();
							txtTypDest.Text = mstrTypeDest;
							identifiantUniqueCourrier = (int)sdr["NUMCOUR"];
							bFirstTime = false;
						}

						// remplir le recordset des destinataires
						AjouterEnreg(Convert.ToInt64(sdr["NCOURIDDEST"]), mstrTypeDest);
					}

					sdr.Close();
				}

				// pas encore de modification
				bModif = false;
			}
			catch (Exception ex)
			{
				MZUtils.displayError(MethodBase.GetCurrentMethod().Name, ex);
			}
			finally
			{
				Cursor = Cursors.Default;
			}
		}

		private void InitialiserFeuilleVide()
		{
			try
			{
				txtTypCour.Text = TypeCour();
				txtTypDest.Text = mstrTypeDest;

				// si client , afficher le numéro de compte
				if (mstrTypeDest == "Client" || mstrTypeDest == "Site")
					txtCompte.Text = RechercheCompteClient();

				// pas encore de modification
				bModif = false;

			}
			catch (Exception ex)
			{
				MZUtils.displayError(MethodBase.GetCurrentMethod().Name, ex);
			}
		}

		private string RechercheCompteClient()
		{
			string sSql = "";
			string sRechercheCC = "";

			if (dtLettre.Rows.Count != 0)
			{
				DataRow row = dtLettre.Rows[0];

				// recherche du compte
				if (mstrTypeDest == "Client")
					sSql = $"select top 1 NCANNUM from TCAN, TCCL WHERE CCANACTIF='O' AND TCAN.NCLINUM = TCCL.NCLINUM AND NCCLNUM = {row["IDdest"]}";

				else if (mstrTypeDest == "Site")
					sSql = $"select top 1 NCANNUM from TCAN, TSIT WHERE CCANACTIF='O' AND TCAN.NCLINUM = TSIT.NCLINUM AND NSITNUM = {row["IDdest"]}";

				sRechercheCC = MozartDatabase.ExecuteScalarString(sSql);
			}

			return sRechercheCC;
		}

		private string TypeCour()
		{
			string sTypeCour = "";

			try
			{
				switch (mstrTypeCour)
				{
					case "A":
						sTypeCour = Resources.txt_AttestationLDR;
						break;
					case "C":
						sTypeCour = Resources.txt_AttestationContElect;
						break;
					case "L":
						if (mstrTypeAR == "S")
							sTypeCour = Resources.txt_LettreSimple;
						else
							sTypeCour = Resources.txt_LettreRecom;
						break;
					case "B":
						sTypeCour = Resources.txt_BordereauLivraison;
						break;
					case "N":
						sTypeCour = Resources.txt_NoteService;
						break;
					case "F":
						sTypeCour = Resources.txt_Telecopie;
						break;
					case "M":
						sTypeCour = Resources.txt_Mail;
						break;
					default:
						break;
				}
			}
			catch (Exception ex)
			{
				MZUtils.displayError(MethodBase.GetCurrentMethod().Name, ex);
			}
			return sTypeCour;
		}

		private void AjouterEnreg(long iNumDest, string sTypeDest)
		{
			try
			{
				if (dtLettre.Columns.Count == 0)
				{
					dtLettre.Columns.Add("TypeDest", typeof(string));
					dtLettre.Columns.Add("IDdest", typeof(int));
				}

				DataRow row = dtLettre.NewRow();
				row["TypeDest"] = sTypeDest;
				row["IDdest"] = iNumDest;
				dtLettre.Rows.Add(row);
			}
			catch (Exception ex)
			{
				MZUtils.displayError(MethodBase.GetCurrentMethod().Name, ex);
			}
		}

		private void txtCompte_KeyPress(object sender, KeyPressEventArgs e)
		{
			KeyValidator.KeyPress_SaisieNombre(e);
		}

		private void Imprimer(long NumCourrier, long iNumDest, string Modele, string copie)
		{
			try
			{
				new frmMainReport
				{
					bLaunchByProcessStart = false,
					sTypeReport = PrepareReport.TLETTREV3,
					sIdentifiant = $"{NumCourrier}|0|{iNumDest}",
					InfosMail = "",
					sNomSociete = MozartParams.NomSociete,
					sLangue = Strings.Left(ModuleMain.CodePays(ModuleMain.GetPaysDest(mstrTypeDest, iNumDest)), 2),
					sOption = "PRINT",
					strType = "CO",
					numAction = MozartParams.NumAction
				}.ShowDialog();

			}
			catch (Exception ex)
			{
				MZUtils.displayError(MethodBase.GetCurrentMethod().Name, ex);
			}
		}

		private void cmdModeles_Click(object sender, EventArgs e)
		{
			if (txtLettre.Text != "")
			{
				if (MessageBox.Show("Vous allez modifier le texte, êtes-vous sûr ?", Program.AppTitle, MessageBoxButtons.YesNo, MessageBoxIcon.Question, MessageBoxDefaultButton.Button2) == DialogResult.No)
					return;
			}

			frmSaisieLettreModeles f = new frmSaisieLettreModeles();
			f.ShowDialog();
			if (!String.IsNullOrEmpty(f.msTxtLettre))
			{
				txtLettre.Text = f.msTxtLettre;
			}
		}

		private void cmdTraduction_Click(object sender, EventArgs e)
		{
			txtLettre.Text = Utils.Traduction(txtLettre.Text);
		}

		private void RemplirComboLangues()
		{
			try
			{
				using (SqlDataReader dr = MozartDatabase.ExecuteReader("select distinct VLANGUEDEFAUT, VLANGUEABR from TPAYS order by VLANGUEDEFAUT"))
				{
					while (dr.Read())
						cboLangue.Items.Add(dr[0].ToString() + " - " + dr[1].ToString());

					dr.Close();
				}
			}
			catch (Exception ex)
			{
				MZUtils.displayError(MethodBase.GetCurrentMethod().Name, ex);
			}
		}

		private void RemplirComboContactST(ComboBox combo, string sVue)
		{
			try
			{
				ModuleData.RemplirCombo(combo, sVue, true);

				if (combo.Items.Count > 0)
					combo.SelectedIndex = 0;
			}
			catch (Exception ex)
			{
				MZUtils.displayError(MethodBase.GetCurrentMethod().Name, ex);
			}
		}

		private void cmdSpell_Click(object sender, EventArgs e)
		{
			Utils.SpellCheck(txtLettre);
		}
	}
}
