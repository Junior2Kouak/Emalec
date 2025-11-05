using Microsoft.VisualBasic;
using MozartCS.Properties;
using MozartLib;
using MozartNet;
using ReportEmalec.Net;
using System;
using System.Data;
using System.Data.SqlClient;
using System.Reflection;
using System.Windows.Forms;
using MZUtils = MozartControls.Utils;

namespace MozartCS
{
	public partial class frmModifLettre : Form
	{
		//' feuille ouverte en création ou modification
		public string mstrTypeCour;
		public string mstrTypeDest;
		public string mstrTypeAR;
		public long iNumCourrier;
		public long iNumDest;

		bool bModif;

		public frmModifLettre() { InitializeComponent(); }

		private void frmModifLettre_Load(object sender, System.EventArgs e)
		{
			try
			{
				ModuleMain.Initboutons(this);
				InitialiserFeuille();

				// combo des langues pour affichage du courrier
				RemplirComboLangues();

				if (mstrTypeCour == "C")
					Label1.Text = Resources.txt_AttestationControleElect;

				if (mstrTypeAR == "R")
				{
					lblNumAR.Visible = txtNumAR.Visible = true;
				}
			}
			catch (Exception ex)
			{
				MZUtils.displayError(MethodBase.GetCurrentMethod().Name, ex);
			}
		}

		private void cmdFermer_Click(object sender, System.EventArgs e)
		{
			try
			{
				// si il y a des modification
				if (bModif)
					switch (MessageBox.Show(Resources.msgConfirm_enregistrerModif, Program.AppTitle, MessageBoxButtons.YesNo, MessageBoxIcon.Question, MessageBoxDefaultButton.Button2))
					{
						case DialogResult.Yes:
							EnregistrerCourrier();
							Dispose();
							break;
						case DialogResult.No:
							Dispose();
							break;
						case DialogResult.Cancel:
							return;
					}
				else
					Dispose();
			}
			catch (Exception ex)
			{
				MZUtils.displayError(MethodBase.GetCurrentMethod().Name, ex);
			}
		}

		private void cmdValider_Click(object sender, EventArgs e)
		{
			try
			{
				if (!TestValidation())
					return;

				EnregistrerCourrier();
				//mise a jour de l'affichage
				InitialiserFeuille();
				bModif = false;
			}
			catch (Exception ex)
			{
				MZUtils.displayError(MethodBase.GetCurrentMethod().Name, ex);
			}
		}

		private void cmdImprimer_Click(object sender, EventArgs e)
		{
			string sModele;
			try
			{
				sModele = ModuleMain.RechercheModele(mstrTypeCour);
				switch (mstrTypeCour)
				{
					case "F":
					case "L":
					case "N":
					case "M":
						new frmMainReport
						{
							bLaunchByProcessStart = false,
							sTypeReport = PrepareReport.TLETTREV3,
							sIdentifiant = $"{iNumCourrier}|0|{iNumDest}",
							InfosMail = "",
							sNomSociete = MozartParams.NomSociete,
							sLangue = Strings.Left(ModuleMain.CodePays(ModuleMain.GetPaysDest(mstrTypeDest, iNumDest)), 2),
							sOption = "PRINT",
							strType = "CO",
							numAction = MozartParams.NumAction
						}.ShowDialog();
						break;
					case "C":
						MessageBox.Show($"Ce courrier n'est plus géré, contactez le service informatique.",
												Resources.Global_Erreur, MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
						break;
				}
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
				if (iNumCourrier == 0)
				{
					MessageBox.Show(Resources.msg_must_save_letter, Program.AppTitle, MessageBoxButtons.OK, MessageBoxIcon.Information);
					return;
				}

				// Courrier Attestation élec plus géré
				if (mstrTypeCour == "C")
				{
					MessageBox.Show($"Ce courrier n'est plus géré, contactez le service informatique.",
											Resources.Global_Erreur, MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
					return;
				}

				string InfosMail;
				string CodeLangue;
				string[,] TdbGlobal = { { "copie", "1/2   Original" } };
	
				switch (mstrTypeDest)
				{
					case "Service Technique":  // Modif du 06/06/2016 pour les PC Sécurité
						InfosMail = "TSERVTECH|NSERVTECHNUM|" + iNumDest;
						break;
					case "Client":
						InfosMail = "TCCL|NCCLNUM|" + iNumDest;
						break;
					case "Sous-traitant":
					case "Fournisseur":
					case "ravel":
					case "RelanceDocAdmin":
						InfosMail = "TINT|NINTNUM|" + iNumDest;
						break;
					case "Site":             //TSIT / TCCL
						InfosMail = "TSIT|NSITNUM|" + iNumDest;
						break;
					case "Personnel":
						InfosMail = "TPER|NPERNUM|" + iNumDest;
						break;
					default:
						InfosMail = "TPER|NPERNUM|" + 0;
						break;
				}
				if (cboLangue.Text != "")
					CodeLangue = Strings.Right(cboLangue.Text, 2) + "\\";
				else
					CodeLangue = ModuleMain.CodePays(ModuleMain.GetPaysDest(mstrTypeDest, iNumDest));

        new frmMainReport
        {
          bLaunchByProcessStart = false,
          sTypeReport = PrepareReport.TLETTREV3,
          sIdentifiant = $"{iNumCourrier}|0|{iNumDest}",
          InfosMail = InfosMail,
          sNomSociete = MozartParams.NomSociete,
          sLangue = Strings.Left(CodeLangue, 2),
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

		private bool TestValidation()
		{
			try
			{
				if (txtRef.Text == "")
				{
					MessageBox.Show(Resources.msg_EntrezRefDansZoneRef);
					txtRef.Focus();
					return false;
				}

				if (txtObjet.Text == "")
				{
					MessageBox.Show(Resources.msg_EntrezObjetDansZoneObjet);
					txtObjet.Focus();
					return false;
				}

				if (txtLettre.Text == "")
				{
					MessageBox.Show(Resources.msg_SaisissezTextDansZoneText);
					txtLettre.Focus();
					return false;
				}

				if (txtNumAR.Text == "" && txtNumAR.Visible)
				{
					MessageBox.Show(Resources.msg_SaisissezNumAR);
					txtLettre.Focus();
					return false;
				}

				return true;
			}
			catch (Exception ex)
			{
				MZUtils.displayError(MethodBase.GetCurrentMethod().Name, ex);
				return false;
			}

		}

		private void frmModifLettre_KeyPress(object sender, KeyPressEventArgs e)
		{
			bModif = true;
		}

		private void EnregistrerCourrier()
		{
			try
			{
				using (SqlCommand cmd = new SqlCommand("api_sp_creationCourrier", MozartDatabase.cnxMozart))
				{
					cmd.CommandType = CommandType.StoredProcedure;

					// liste des paramètres
					SqlCommandBuilder.DeriveParameters(cmd);

					cmd.Parameters["@iNumCour"].Value = iNumCourrier;
					cmd.Parameters["@sAction"].Value = "Modification";
					cmd.Parameters["@iCourrier"].Value = 0;
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
					cmd.Parameters["@iAction"].Value = 0;
					cmd.Parameters["@NumAR"].Value = txtNumAR.Text;
					cmd.Parameters["@cSAS"].Value = "";    // IIf(bSas, "S", "");
					cmd.Parameters["@vsociete"].Value = MozartParams.NomSociete;
					cmd.Parameters["@p_idout"].Value = 0;

					// Exécuter la commande.
					cmd.ExecuteNonQuery();
					// Récupération du numéro crée
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
				//recherche des info du contrat
				using (SqlDataReader sdr = ModuleData.ExecuteReader($"api_sp_RetourInfoCourrier 0, {iNumCourrier},'{MozartParams.NomSociete}'"))
				{
					if (sdr.Read())
					{
						//les infos de la feuille
						txtObjet.Text = ModuleMain.ReplaceCharFromBD(Utils.BlankIfNull(sdr["VCOUROBJET"]), "RTF");
						txtRef.Text = ModuleMain.ReplaceCharFromBD(Utils.BlankIfNull(sdr["VCOURREF"]), "RTF");
						txtLettre.Text = ModuleMain.ReplaceCharFromBD(Utils.BlankIfNull(sdr["VCOURCORPS"]), "RTF");
						txtPied.Text = ModuleMain.ReplaceCharFromBD(Utils.BlankIfNull(sdr["VCOURPIED"]).ToString(), "RTF");
						txtCompte.Text = Utils.BlankIfNull(sdr["NCOURCTE"]);
						txtNom.Text = Utils.BlankIfNull(sdr["NOM"]);
						txtCont.Text = Utils.BlankIfNull(sdr["CONTACT"]);
						txtTypCour.Text = TypeCour();
						txtTypDest.Text = mstrTypeDest;
						txtNum.Text = sdr["NCOURNUM"].ToString();
						txtNumAR.Text = sdr["VCOURNUMAR"].ToString() + "";
					}
				}
				Cursor.Current = Cursors.Default;
				// pas encore de modification
				bModif = false;
			}
			catch (Exception ex)
			{
				Cursor.Current = Cursors.Default;
				MZUtils.displayError(MethodBase.GetCurrentMethod().Name, ex);
			}
		}

		private string TypeCour()
		{
			try
			{
				string TypeCour = "";
				switch (mstrTypeCour)
				{
					case "A":
						TypeCour = Resources.txt_Attestation_LR;
						break;
					case "C":
						TypeCour = Resources.txt_AttestationContElect;
						break;
					case "L":
						if (mstrTypeAR == "S")
							TypeCour = Resources.txt_LettreSimple;
						else
							TypeCour = Resources.txt_LettreRecom;
						break;
					case "B":
						TypeCour = Resources.txt_BordereauLivraison;
						break;
					case "N":
						TypeCour = Resources.txt_NoteService;
						break;
					case "F":
						TypeCour = Resources.txt_Telecopie;
						break;
					case "M":
						TypeCour = Resources.txt_Mail;
						break;
				}
				return TypeCour;
			}
			catch (Exception ex)
			{
				MZUtils.displayError(MethodBase.GetCurrentMethod().Name, ex);

				return "";
			}
		}

		private void txtCompte_KeyPress(object sender, KeyPressEventArgs e)
		{
			KeyValidator.KeyPress_SaisieNombre(e);
		}

		private void cmdSpell_Click(object sender, EventArgs e)
		{
			Utils.SpellCheck(txtLettre);
		}

		private void cmdTraduction_Click(object sender, EventArgs e)
		{
			txtLettre.Text = Utils.Traduction(txtLettre.Text);
		}

		private void RemplirComboLangues()
		{
			using (SqlDataReader dr = ModuleData.ExecuteReader("select distinct VLANGUEDEFAUT, VLANGUEABR from TPAYS order by VLANGUEDEFAUT"))
			{
				while (dr.Read())
					cboLangue.Items.Add(dr[0].ToString() + " - " + dr[1].ToString());

				dr.Close();
			}
		}
	
	}
}