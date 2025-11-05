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
	public partial class frmFormulaireEquipement : Form
	{

		public int _NVEHNUM;
		public int _NEQUIPUM;

		public frmFormulaireEquipement(int nvehnum, int nrevnum)
		{
			InitializeComponent();

			_NVEHNUM = nvehnum;
			_NEQUIPUM = nrevnum;

		}

		private void frmDetailFormulaires_Load(object sender, EventArgs e)
		{

			try
			{
				ModuleMain.Initboutons(this);

				// modification ou création
				if (_NEQUIPUM > 0)
					OuvertureEnModification();
				else
				{
					txtDateDebut.Text = string.Empty;
					txtDateFin.Text = string.Empty;
					cboFour.Text = "";
					cboType.Text = "";
					txtNumEquipement.Text = string.Empty;
					txtCode.Text = string.Empty;
					cboStatut.Text = "Actif";
				}
			}
			catch (Exception ex)
			{
				MZUtils.displayError(MethodBase.GetCurrentMethod().Name, ex);
			}
		}

		private void OuvertureEnModification()
		{
			using (SqlDataReader dr = ModuleData.ExecuteReader($"SELECT * FROM TAUTOEQUIP WHERE NEQUIPNUM = {_NEQUIPUM}"))
			{
				if (dr.Read())
				{
					if (dr["DEQUIPDDEB"] != DBNull.Value) txtDateDebut.Text = Convert.ToDateTime(dr["DEQUIPDDEB"]).ToString("dd/MM/yyyy");
					if (dr["DEQUIPDFIN"] != DBNull.Value) txtDateFin.Text = Convert.ToDateTime(dr["DEQUIPDFIN"]).ToString("dd/MM/yyyy");
					cboFour.Text = dr["VEQUIPFOUR"].ToString(); ;
					cboType.Text = dr["VEQUIPTYPE"].ToString(); ;
					txtNumEquipement.Text = dr["VEQUIPREF"].ToString();
					txtCode.Text = dr["VEQUIPCODE"].ToString();
					cboStatut.Text = dr["VEQUIPSTATUT"].ToString();
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
				if (null == cboFour.SelectedItem || cboFour.SelectedItem.ToString() == "")
				{
					MessageBox.Show("Choisissez le fournisseur", Program.AppTitle, MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
					cboFour.Focus();
					return;
				}
				if (null == cboType.SelectedItem || cboType.SelectedItem.ToString() == "")
				{
					MessageBox.Show("Choisissez le type d'équipement", Program.AppTitle, MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
					cboType.Focus();
					return;
				}
				if (txtNumEquipement.Text == "")
				{
					MessageBox.Show("Saisissez un numéro d'équipement", Program.AppTitle, MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
					return;
				}
				if (null == cboStatut.SelectedItem || cboStatut.SelectedItem.ToString() == "")
				{
					MessageBox.Show("Choisissez le statut", Program.AppTitle, MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
					cboStatut.Focus();
					return;
				}


				SqlCommand cmd = new SqlCommand("api_sp_CreationEquipementVehicule", MozartDatabase.cnxMozart);
				cmd.CommandType = CommandType.StoredProcedure;
				SqlCommandBuilder.DeriveParameters(cmd);

				cmd.Parameters["@nEquip"].Value = _NEQUIPUM;
				cmd.Parameters["@nVeh"].Value = _NVEHNUM;
				if (txtDateDebut.Text != "") cmd.Parameters["@dEquipDdeb"].Value = txtDateDebut.Text;
				if (txtDateFin.Text != "") cmd.Parameters["@dEquipDfin"].Value = txtDateFin.Text;
				cmd.Parameters["@vFour"].Value = cboFour.Text;
				cmd.Parameters["@vType"].Value = cboType.Text;
				cmd.Parameters["@vNumEquip"].Value = txtNumEquipement.Text;
				cmd.Parameters["@vCode"].Value = txtCode.Text;
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