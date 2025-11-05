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
	public partial class frmFormulaireRevision : Form
	{

		public int _NVEHNUM;
		public int _NREVUM;

		public frmFormulaireRevision(int nvehnum, int nrevnum)
		{
			InitializeComponent();

			_NVEHNUM = nvehnum;
			_NREVUM = nrevnum;

		}

		private void frmDetailFormulaires_Load(object sender, EventArgs e)
		{

			try
			{
				ModuleMain.Initboutons(this);

				// modification ou création
				if (_NREVUM > 0)
					OuvertureEnModification();
				else
				{
					cboTypeRev.Text = "Révision";
					txtDateRev.Text = string.Empty;
					txtKmRev.Text = string.Empty;
					txtDiversRev.Text = string.Empty;
				}
			}
			catch (Exception ex)
			{
				MZUtils.displayError(MethodBase.GetCurrentMethod().Name, ex);
			}
		}

		private void OuvertureEnModification()
		{
			using (SqlDataReader dr = ModuleData.ExecuteReader($"SELECT * FROM TAUTOREV WHERE NREVNUM = {_NREVUM}"))
			{
				if (dr.Read())
				{
					cboTypeRev.Text = dr["VREVLIBELLE"].ToString();
					if (dr["DREVIDATE"] != DBNull.Value) txtDateRev.Text = Convert.ToDateTime(dr["DREVIDATE"]).ToString("dd/MM/yyyy");
					txtKmRev.Text = dr["NREVIKM"].ToString();
					txtDiversRev.Text = dr["VREVDIVERS"].ToString();
				}
				dr.Close();
			}
		}

		private void cmdValiderRev_Click(object sender, EventArgs e)
		{

			try
			{
				SqlCommand cmd = new SqlCommand("api_sp_CreationEntretienVehicule", MozartDatabase.cnxMozart);
				cmd.CommandType = CommandType.StoredProcedure;
				SqlCommandBuilder.DeriveParameters(cmd);

				cmd.Parameters["@nRev"].Value = _NREVUM;
				cmd.Parameters["@nVeh"].Value = _NVEHNUM;
				cmd.Parameters["@vType"].Value = cboTypeRev.Text;
				if (txtDateRev.Text != "") cmd.Parameters["@drevidate"].Value = txtDateRev.Text;
				cmd.Parameters["@nrevikm"].Value = txtKmRev.EditValue;
				cmd.Parameters["@vDivers"].Value = txtDiversRev.Text;
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