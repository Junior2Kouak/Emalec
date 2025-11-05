using MozartLib;
using MozartNet;
using MozartUC;
using System;
using System.Data;
using System.Data.SqlClient;
using System.Reflection;
using System.Windows.Forms;
using MZUtils = MozartControls.Utils;

namespace MozartCS
{
	public partial class frmFormulaireSinistre : Form
	{

		public int _NSINUM;
		public int _NVEHNUM;
		public string _VSOCIETE;



		public frmFormulaireSinistre(int nvehnum, int nid, string societe)
		{
			InitializeComponent();

			_NVEHNUM = nvehnum;
			_NSINUM = nid;
			_VSOCIETE = societe;

		}

		private void frmDetailFormulaires_Load(object sender, EventArgs e)
		{

			try
			{
				ModuleMain.Initboutons(this);

				ModuleData.RemplirCombo(cboSociete, $"SELECT DISTINCT VSOCIETE FROM TDROIT D INNER JOIN TSOCIETE S ON S.VSOCIETENOM = D.VSOCIETE " +
																						$"WHERE NPERNUM={MozartParams.UID} AND NMENUNUM={cboSociete.Tag} " +
																						$"AND CDROITVAL = 'O' AND VSOCIETEACTIF='O' ORDER BY VSOCIETE", true);
				cboSociete.ValueMember = "VSOCIETE";
				cboSociete.DisplayMember = "VSOCIETE";


				// modification ou création
				if (_NSINUM > 0)
					OuvertureEnModification();
				else
				{
					txtDateSinistre.Text = string.Empty;
					txtDateExpertise.Text = string.Empty;
					cboSociete.Text = _VSOCIETE;
					cboSociete_SelectionChangeCommitted(cboSociete, EventArgs.Empty);
					cboStatut.Text = "Ouvert";
				}
			}
			catch (Exception ex)
			{
				MZUtils.displayError(MethodBase.GetCurrentMethod().Name, ex);
			}
		}

		private void cboSociete_SelectionChangeCommitted(object sender, EventArgs e)
		{
			// liste des employés de la filiale
			cboEmploye.DataSource = null;
			cboEmploye.Items.Clear();
			string sSQL = $"select NPERNUM, VPERNOM + ' ' + VPERPRE AS VPERNOMPRENOM from TPER WHERE VSOCIETE = '{cboSociete.Text}' " +
			$"AND (NPERNUM not in (select NPERNUM from TVEHICULES where NPERNUM is not null)) " +
			$"AND CPERACTIF='O' AND BUTILISATEUR=0 UNION select 0, ' ' ORDER BY VPERNOMPRENOM";

			ModuleData.RemplirCombo(cboEmploye, sSQL);
			cboEmploye.ValueMember = "NPERNUM";
			cboEmploye.DisplayMember = "VPERNOMPRENOM";

			//// liste des véhicules de la filiale
			//cboVehicule.DataSource = null;
			//cboVehicule.Items.Clear();

			//ModuleData.RemplirCombo(cboVehicule, $"select NVEHNUM, VVEHIMAT from TVEHICULES WHERE CVEHACTIF='O' AND VSOCIETE = '{cboSociete.Text}'");
			//cboVehicule.ValueMember = "NVEHNUM";
			//cboVehicule.DisplayMember = "VVEHIMAT";
		}

		private void OuvertureEnModification()
		{
			using (SqlDataReader dr = ModuleData.ExecuteReader($"SELECT * FROM TAUTOSIN WHERE NSINNUM = {_NSINUM}"))
			{
				if (dr.Read())
				{
					if (dr["DSINDATE"] != DBNull.Value) txtDateSinistre.Text = Convert.ToDateTime(dr["DSINDATE"]).ToString("dd/MM/yyyy");
					cboSociete.SelectedValue = dr["VSOCIETE"].ToString();
					cboSociete_SelectionChangeCommitted(cboSociete, EventArgs.Empty);
					cboEmploye.SelectedValue = dr["NPERNUM"].ToString();
					cboStatut.Text = dr["VSINSTATUT"].ToString();

					if (dr["DSINEXPERTISE"] != DBNull.Value) txtDateExpertise.Text = Convert.ToDateTime(dr["DSINEXPERTISE"]).ToString("dd/MM/yyyy");
					txtGarage.Text = dr["VSINGARAGE"].ToString();
					cboAgree.Text = dr["CSINGARAGEAGREE"].ToString(); 
					txtObservations.Text = dr["VSINOBS"].ToString();

					txtNumDossier.Text = dr["VSINDOSSIER"].ToString();
					cboResponsabilite.Text = dr["VSINRESPONSABLE"].ToString();
					cboFranchise.Text = dr["CSINFRANCHISE"].ToString();
					cboDoc.Text = dr["VSINDOC"].ToString();
					cboTiers.Text = dr["CSINTIERS"].ToString();

					txtMontantAssurance.Text = Utils.ZeroIfBlank(dr["NSINMONTANTASSURANCE"]).ToString();
					txtMontantEmalec.Text = Utils.ZeroIfBlank(dr["NSINMONTANTFILIALE"]).ToString();
					txtTotal.EditValue = Convert.ToDecimal(txtMontantAssurance.EditValue) + Convert.ToDecimal(txtMontantEmalec.EditValue);

				}
				dr.Close();
			}
		}

		private void cmdValiderRev_Click(object sender, EventArgs e)
		{
			try
			{
				if (txtDateSinistre.Text == "")
				{
					MessageBox.Show("Saisissez une date de sinistre", Program.AppTitle, MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
					return;
				}
				if (null == cboSociete.SelectedItem || cboSociete.Text == "")
				{
					MessageBox.Show("Choisissez l'entité", Program.AppTitle, MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
					cboSociete.Focus();
					return;
				}
				if (null == cboEmploye.SelectedItem || cboEmploye.Text == "")
				{
					MessageBox.Show("Choisissez le collaborateur", Program.AppTitle, MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
					cboEmploye.Focus();
					return;
				}

				SqlCommand cmd = new SqlCommand("api_sp_CreationSinistreVehicule", MozartDatabase.cnxMozart);
				cmd.CommandType = CommandType.StoredProcedure;
				SqlCommandBuilder.DeriveParameters(cmd);

				cmd.Parameters["@nSin"].Value = _NSINUM;
				cmd.Parameters["@nVeh"].Value = _NVEHNUM;
				if (txtDateSinistre.Text != "") cmd.Parameters["@dSinistre"].Value = txtDateSinistre.Text;
				if (txtDateExpertise.Text != "") cmd.Parameters["@dExpertise"].Value = txtDateExpertise.Text;
				cmd.Parameters["@vSociete"].Value = cboSociete.Text;
				cmd.Parameters["@npernum"].Value = cboEmploye.GetItemData();
				cmd.Parameters["@cFranchise"].Value = cboFranchise.Text;
				cmd.Parameters["@vResponsable"].Value = cboResponsabilite.Text;
				cmd.Parameters["@cAgree"].Value = cboAgree.Text;
				cmd.Parameters["@cTiers"].Value = cboTiers.Text;
				cmd.Parameters["@vNumDossier"].Value = txtNumDossier.Text;
				cmd.Parameters["@vGarage"].Value = txtGarage.Text;
				cmd.Parameters["@vObs"].Value = txtObservations.Text;
				cmd.Parameters["@MontantAss"].Value = txtMontantAssurance.EditValue;
				cmd.Parameters["@MontantEmalec"].Value = txtMontantEmalec.EditValue;
				cmd.Parameters["@vStatut"].Value = cboStatut.Text;
				cmd.Parameters["@vDoc"].Value = cboDoc.Text;

				cmd.ExecuteNonQuery();

				Dispose();
			}
			catch (Exception ex)
			{
				MZUtils.displayError(MethodBase.GetCurrentMethod().Name, ex);
			}
		}

		private void cmdAnnulerRev_Click(object sender, EventArgs e)
		{
			Dispose();
		}

		private void cmdFichier_Click(object sender, EventArgs e)
		{
			new frmDetailDocVehicule(0, _NVEHNUM , Utils.RechercheParam("REP_DOCS_VEHICULES")).ShowDialog();
		}

		private void cboFranchise_TextChanged(object sender, EventArgs e)
		{

		}

		private void txtMontantAssurance_TextChanged(object sender, EventArgs e)
		{
			txtTotal.EditValue = Convert.ToDecimal(txtMontantAssurance.EditValue) + Convert.ToDecimal(txtMontantEmalec.EditValue);
		}

		private void cboFranchise_SelectionChangeCommitted(object sender, EventArgs e)
		{
			if (cboFranchise.Text == "OUI")
				txtMontantEmalec.EditValue = 315.00;
			else
				txtMontantEmalec.EditValue = 0.00;

			txtTotal.EditValue = Convert.ToDecimal(txtMontantAssurance.EditValue) + Convert.ToDecimal(txtMontantEmalec.EditValue);
		}
	}
}