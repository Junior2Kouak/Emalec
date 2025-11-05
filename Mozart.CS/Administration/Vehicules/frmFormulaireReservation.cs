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
	public partial class frmFormulaireReservation : Form
	{

		public int _NRESANUM;

		public frmFormulaireReservation(int id)
		{
			InitializeComponent();

			_NRESANUM = id;

		}

		private void frmDetailFormulaires_Load(object sender, EventArgs e)
		{

			try
			{
				ModuleMain.Initboutons(this);

				ModuleData.RemplirCombo(cboSociete, $"SELECT DISTINCT VSOCIETE FROM TDROIT D INNER JOIN TSOCIETE S ON S.VSOCIETENOM = D.VSOCIETE " +
																						$"WHERE NPERNUM={MozartParams.UID} AND NMENUNUM={cboSociete.Tag} " +
																						$"AND CDROITVAL='O' AND VSOCIETEACTIF='O' ORDER BY VSOCIETE", true);
				cboSociete.ValueMember = "VSOCIETE";
				cboSociete.DisplayMember = "VSOCIETE";

				// modification ou création
				if (_NRESANUM > 0)
					OuvertureEnModification();
				else
				{
					txtDateDebut.Text = string.Empty;
					txtDateFin.Text = string.Empty;
					cboSociete.Text = "EMALEC";
					txtObservations.Text = string.Empty;
					cboSociete_SelectionChangeCommitted(cboSociete, EventArgs.Empty);
					cboStatut.Text = "A venir";
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

			ModuleData.RemplirCombo(cboVehicule, $"select NVEHNUM, VVEHIMAT from TVEHICULES WHERE CVEHACTIF='O' " +
																					$"AND CVEHPOOL='O' AND VSOCIETE='{cboSociete.Text}'");
			cboVehicule.ValueMember = "NVEHNUM";
			cboVehicule.DisplayMember = "VVEHIMAT";
		}

		private void OuvertureEnModification()
		{
			string sSQL = $"SELECT A.*, VVEHOBS FROM TAUTORESA A INNER JOIN TVEHICULES V ON A.NVEHNUM=V.NVEHNUM WHERE NRESANUM={_NRESANUM}";

			using (SqlDataReader dr = ModuleData.ExecuteReader(sSQL))
			{
				if (dr.Read())
				{
					if (dr["DRESADEB"] != DBNull.Value) txtDateDebut.Text = Convert.ToDateTime(dr["DRESADEB"]).ToString("dd/MM/yyyy HH:mm");
					if (dr["DRESAFIN"] != DBNull.Value) txtDateFin.Text = Convert.ToDateTime(dr["DRESAFIN"]).ToString("dd/MM/yyyy HH:mm");
					txtObservations.Text = dr["VVEHOBS"].ToString();
					cboType.Text = dr["VRESATYPE"].ToString();
					txtDetail.Text = dr["VRESADETAIL"].ToString();
					cboStatut.Text = dr["VRESASTATUT"].ToString();

					cboSociete.SelectedValue = dr["VSOCIETE"].ToString();
					cboSociete_SelectionChangeCommitted(cboSociete, EventArgs.Empty);
					cboEmploye.SelectedValue = dr["NPERNUM"].ToString();
					cboVehicule.SelectedValue = dr["NVEHNUM"].ToString();

					// cas ou le véhicule n'est plus dans le pool : il n'aparait plus dans la liste.
					// donc on l'ajoute à la main
					if (null == cboVehicule.SelectedItem || cboVehicule.Text == "")
					{
						cboVehicule.DataSource = null;
						cboVehicule.Items.Clear();

						ModuleData.RemplirCombo(cboVehicule, $"select NVEHNUM, VVEHIMAT from TVEHICULES WHERE NVEHNUM={dr["NVEHNUM"]}");
						cboVehicule.ValueMember = "NVEHNUM";
						cboVehicule.DisplayMember = "VVEHIMAT";
						cboVehicule.SelectedValue = dr["NVEHNUM"].ToString();
					}

					// cas ou la personne est archivée : elle n'aparait plus dans la liste.
					// donc on l'ajoute à la main
					if (null == cboEmploye.SelectedItem || cboEmploye.Text == "")
					{
						cboEmploye.DataSource = null;
						cboEmploye.Items.Clear();

						ModuleData.RemplirCombo(cboEmploye, $"select NPERNUM, VPERNOM FROM TPER WHERE NPERNUM={dr["NPERNUM"]}");
						cboEmploye.ValueMember = "NPERNUM";
						cboEmploye.DisplayMember = "VPERNOM";
						cboEmploye.SelectedValue = dr["NPERNUM"].ToString();
					}


				}
				dr.Close();
			}
		}

		private void cmdValiderRev_Click(object sender, EventArgs e)
		{
			try
			{
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
				if (null == cboVehicule.SelectedItem || cboVehicule.Text == "")
				{
					MessageBox.Show("Choisissez un véhicule", Program.AppTitle, MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
					cboVehicule.Focus();
					return;
				}
				if (null == cboType.SelectedItem || cboType.Text == "")
				{
					MessageBox.Show("Choisissez un type de réservation", Program.AppTitle, MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
					cboType.Focus();
					return;
				}
				if (null == cboStatut.SelectedItem || cboStatut.Text == "")
				{
					MessageBox.Show("Choisissez le statut", Program.AppTitle, MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
					cboStatut.Focus();
					return;
				}


				SqlCommand cmd = new SqlCommand("api_sp_CreationReservationVehicule", MozartDatabase.cnxMozart);
				cmd.CommandType = CommandType.StoredProcedure;
				SqlCommandBuilder.DeriveParameters(cmd);

				cmd.Parameters["@nResa"].Value = _NRESANUM;
				cmd.Parameters["@nVeh"].Value = cboVehicule.GetItemData(); 
				if (txtDateDebut.Text != "") cmd.Parameters["@dDdeb"].Value = txtDateDebut.Text;
				if (txtDateFin.Text != "") cmd.Parameters["@dDfin"].Value = txtDateFin.Text;
				cmd.Parameters["@vSociete"].Value = cboSociete.Text;
				cmd.Parameters["@npernum"].Value = cboEmploye.GetItemData();
				cmd.Parameters["@vType"].Value = cboType.Text;
				cmd.Parameters["@vDetail"].Value = txtDetail.Text;
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

		private void cboVehicule_SelectionChangeCommitted(object sender, EventArgs e)
		{
			txtObservations.Text = ModuleData.ExecuteScalarString($"SELECT VVEHOBS FROM TVEHICULES WHERE NVEHNUM={cboVehicule.GetItemData()}");
		}
	}
}