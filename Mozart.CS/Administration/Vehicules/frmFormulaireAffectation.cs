using DevExpress.CodeParser;
using DevExpress.DataAccess.Native.EntityFramework;
using Microsoft.VisualBasic;
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
	public partial class frmFormulaireAffectation : Form
	{

		public int _NVEHNUM;
		public int _NAFFUM;

		public frmFormulaireAffectation(int nvehnum, int nrevnum)
		{
			InitializeComponent();

			_NVEHNUM = nvehnum;
			_NAFFUM = nrevnum;

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

				ModuleData.RemplirCombo(cboStatut, "select ID, VETALIB from TREF_VEHETA");
				cboStatut.ValueMember = "ID";
				cboStatut.DisplayMember = "VETALIB";

				// modification ou création
				if (_NAFFUM > 0)
					OuvertureEnModification();
				else
				{
					txtDateDebut.Text = string.Empty;
					txtDateFin.Text = string.Empty;
					cboSociete.Text = "";
					cboSociete_SelectionChangeCommitted(cboSociete, EventArgs.Empty);
					//cboStatut.Text = "Actif";
				}
			}
			catch (Exception ex)
			{
				MZUtils.displayError(MethodBase.GetCurrentMethod().Name, ex);
			}
		}

		private void cboSociete_SelectionChangeCommitted(object sender, EventArgs e)
		{
			cboEmploye.DataSource = null;
			cboEmploye.Items.Clear();
			string sSQL = $"select NPERNUM, VPERNOM + ' ' + VPERPRE AS VPERNOMPRENOM from TPER WHERE VSOCIETE = '{cboSociete.Text}' " +
			//$"AND (NPERNUM not in (select NPERNUM from TVEHICULES where NPERNUM is not null)) " +
			$"AND CPERACTIF='O' AND BUTILISATEUR=0 UNION select 0, ' ' ORDER BY VPERNOMPRENOM";

			ModuleData.RemplirCombo(cboEmploye, sSQL);
			cboEmploye.ValueMember = "NPERNUM";
			cboEmploye.DisplayMember = "VPERNOMPRENOM";
		}

		private void OuvertureEnModification()
		{
			using (SqlDataReader dr = ModuleData.ExecuteReader($"SELECT * FROM TAUTOAFF WHERE NAFFNUM = {_NAFFUM}"))
			{
				if (dr.Read())
				{
					if (dr["DAFFDDEB"] != DBNull.Value) txtDateDebut.Text = Convert.ToDateTime(dr["DAFFDDEB"]).ToString("dd/MM/yyyy");
					if (dr["DAFFDFIN"] != DBNull.Value) txtDateFin.Text = Convert.ToDateTime(dr["DAFFDFIN"]).ToString("dd/MM/yyyy");
					cboSociete.SelectedValue = dr["VAFFSOCIETE"].ToString();

					cboSociete_SelectionChangeCommitted(cboSociete, EventArgs.Empty);
					cboEmploye.SelectedValue = dr["NPERNUM"].ToString(); 
					cboStatut.Text = dr["VAFFSTATUT"].ToString();
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
				if (null == cboSociete.SelectedItem || cboSociete.Text == "")
				{
					MessageBox.Show("Choisissez l'entité", Program.AppTitle, MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
					cboSociete.Focus();
					return;
				}
				if (null == cboStatut.SelectedItem || cboStatut.Text == "")
				{
					MessageBox.Show("Choisissez le statut", Program.AppTitle, MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
					cboStatut.Focus();
					return;
				}


				SqlCommand cmd = new SqlCommand("api_sp_CreationAffectationVehicule", MozartDatabase.cnxMozart);
				cmd.CommandType = CommandType.StoredProcedure;
				SqlCommandBuilder.DeriveParameters(cmd);

				cmd.Parameters["@nAff"].Value = _NAFFUM;
				cmd.Parameters["@nVeh"].Value = _NVEHNUM;
				if (txtDateDebut.Text != "") cmd.Parameters["@dAffDdeb"].Value = txtDateDebut.Text;
				if (txtDateFin.Text != "") cmd.Parameters["@dAffDfin"].Value = txtDateFin.Text;
				cmd.Parameters["@vSociete"].Value = cboSociete.Text;
				cmd.Parameters["@npernum"].Value = cboEmploye.GetItemData();
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