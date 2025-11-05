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
	public partial class frmFormulaireLocation : Form
	{

		public int _NLOCUM;

		public frmFormulaireLocation(int id)
		{
			InitializeComponent();

			_NLOCUM = id;

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

				ModuleData.RemplirCombo(cboAgenceLoc, "SELECT VLOCAGENCE FROM api_v_comboAgenceLocation ORDER BY VLOCAGENCE");
				cboAgenceLoc.ValueMember = "VLOCAGENCE";


				// modification ou création
				if (_NLOCUM > 0)
					OuvertureEnModification();
				else
				{
					txtDateDebut.Text = string.Empty;
					txtDateFin.Text = string.Empty;
					cboSociete.Text = "";
					cboSociete_SelectionChangeCommitted(cboSociete, EventArgs.Empty);
					cboStatut.Text = "En cours";
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

			// liste des véhicules de la filiale
			cboVehicule.DataSource = null;
			cboVehicule.Items.Clear();

			ModuleData.RemplirCombo(cboVehicule, $"select NVEHNUM, VVEHIMAT from TVEHICULES WHERE CVEHACTIF='O' AND VSOCIETE = '{cboSociete.Text}'");
			cboVehicule.ValueMember = "NVEHNUM";
			cboVehicule.DisplayMember = "VVEHIMAT";
		}

		private void OuvertureEnModification()
		{
			using (SqlDataReader dr = ModuleData.ExecuteReader($"SELECT * FROM TAUTOLOC WHERE NLOCNUM = {_NLOCUM}"))
			{
				if (dr.Read())
				{
					if (dr["DLOCDEB"] != DBNull.Value) txtDateDebut.Text = Convert.ToDateTime(dr["DLOCDEB"]).ToString("dd/MM/yyyy HH:mm");
					if (dr["DLOCFIN"] != DBNull.Value) txtDateFin.Text = Convert.ToDateTime(dr["DLOCFIN"]).ToString("dd/MM/yyyy HH:mm");
					cboAgenceLoc.Text = dr["VLOCAGENCE"].ToString();
					cboCategorie.Text = dr["VLOCCATEGORIE"].ToString();
					txtVille.Text = dr["VLOCVILLE"].ToString();
					cboStatut.Text = dr["VLOCSTATUT"].ToString();

					cboSociete.SelectedValue = dr["VSOCIETE"].ToString();
					cboSociete_SelectionChangeCommitted(cboSociete, EventArgs.Empty);
					cboEmploye.SelectedValue = dr["NPERNUM"].ToString();
					cboVehicule.SelectedValue = dr["NVEHNUM"].ToString();
				}
				dr.Close();
			}
		}

		private void cmdValiderRev_Click(object sender, EventArgs e)
		{
			try
			{
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
				if (null == cboAgenceLoc.SelectedItem || cboAgenceLoc.Text == "")
				{
					MessageBox.Show("Choisissez une agence de location", Program.AppTitle, MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
					cboAgenceLoc.Focus();
					return;
				}
				if (txtDateDebut.Text == "")
				{
					MessageBox.Show("Saisissez une date de début", Program.AppTitle, MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
					return;
				}
				if (txtDateFin.Text == "")
				{
					MessageBox.Show("Saisissez une date de fin", Program.AppTitle, MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
					return;
				}
				if (null == cboStatut.SelectedItem || cboStatut.Text == "")
				{
					MessageBox.Show("Choisissez le statut", Program.AppTitle, MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
					cboStatut.Focus();
					return;
				}


				SqlCommand cmd = new SqlCommand("api_sp_CreationLocationVehicule", MozartDatabase.cnxMozart);
				cmd.CommandType = CommandType.StoredProcedure;
				SqlCommandBuilder.DeriveParameters(cmd);

				cmd.Parameters["@nLoc"].Value = _NLOCUM;
				cmd.Parameters["@nVeh"].Value = cboVehicule.GetItemData(); 
				if (txtDateDebut.Text != "") cmd.Parameters["@dDdeb"].Value = txtDateDebut.Text;
				if (txtDateFin.Text != "") cmd.Parameters["@dDfin"].Value = txtDateFin.Text;
				cmd.Parameters["@vSociete"].Value = cboSociete.Text;
				cmd.Parameters["@npernum"].Value = cboEmploye.GetItemData();
				cmd.Parameters["@vAgence"].Value = cboAgenceLoc.Text;
				cmd.Parameters["@vCategorie"].Value = cboCategorie.Text;
				cmd.Parameters["@vVille"].Value = txtVille.Text;
				cmd.Parameters["@vStatut"].Value = cboStatut.Text;

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

	}
}