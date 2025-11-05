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
	public partial class frmGestPPS : Form
	{

		string sTypeAff;
		string sTitre;
		DataTable dt = new DataTable();


		public frmGestPPS() { InitializeComponent(); }

		private void frmGestPPS_Load(object sender, System.EventArgs e)
		{
			try
			{
				Cursor.Current = Cursors.WaitCursor;

				sTitre = Resources.txt_gestionPlansPrevSimp;
				sTypeAff = "";

				ModuleMain.Initboutons(this);

				GestionAffichage();

				LoadData();

				InitApiTgrid();
			}
			catch (Exception ex)
			{
				MZUtils.displayError(MethodBase.GetCurrentMethod().Name, ex);
			}
			finally { Cursor.Current = Cursors.Default; }
		}

		private void cmdFermer_Click(object sender, System.EventArgs e)
		{
			Dispose();
		}

		private void LoadData()
		{
			// la form peut etre utilisée pour 2 cas : liste des archives ou normal
			apiTGrid1.LoadData(dt, MozartDatabase.cnxMozart, $"exec [api_sp_PPS_Liste] " + MozartParams.NumAction + (sTypeAff == "ARCH" ? ", 0" : ", 1"));
			apiTGrid1.GridControl.DataSource = dt;
		}

		private void GestionAffichage()
		{
			if (sTypeAff == "ARCH")
			{
				lblTitre.Text = sTitre + " " + Resources.txt_archivee;
				cmdAjouter.Visible = false;
				CmdDetail.Visible = false;
				cmdArchiver.Visible = false;
				CmdListeArch.Text = Resources.txt_listeActifs;
			}
			else
			{
				lblTitre.Text = sTitre;
				CmdListeArch.Text = Resources.txt_listeArchives;
				cmdAjouter.Visible = true;
				CmdDetail.Visible = true;
				cmdArchiver.Visible = true;
			}
			this.Text = lblTitre.Text;
		}

		private void cmdArchiver_Click(object sender, EventArgs e)
		{
			DataRow currentRow = apiTGrid1.GetFocusedDataRow();
			if (currentRow == null) return;

			if (MessageBox.Show("Etes-vous sûre de vouloir archiver ce PPS?", Program.AppTitle, MessageBoxButtons.YesNo, MessageBoxIcon.Question,
				MessageBoxDefaultButton.Button2) == DialogResult.Yes)
			{
				ModuleData.CnxExecute("exec [api_sp_PPS_Archiver] " + Convert.ToInt32(currentRow["NIDPPS"]));
				apiTGrid1.Requery(dt, MozartDatabase.cnxMozart);
			}
		}

		private void CmdListeArch_Click(object sender, EventArgs e)
		{
			if (sTypeAff == "ARCH")
				sTypeAff = "";
			else
				sTypeAff = "ARCH";

			GestionAffichage();
			LoadData();
		}

		private void InitApiTgrid()
		{
			try
			{
				apiTGrid1.AddColumn("NIDPPS", "NIDPPS", 0);
				apiTGrid1.AddColumn("NACTNUM", "NACTNUM", 0);
				apiTGrid1.AddColumn("NINTNUM", "NINTNUM", 0);
				apiTGrid1.AddColumn(Resources.col_SousTraitant, "VSTFNOM", 3500);
				apiTGrid1.AddColumn(Resources.col_contactST, "VINTNOM", 3500);
				apiTGrid1.AddColumn(Resources.col_dateCreaPPS, "DPPSCRE", 2500, "dd/mm/yyyy", 2);
				apiTGrid1.AddColumn(Resources.col_dateRetourSouhaite, "DPPSRETOUR", 2500, "dd/mm/yyyy", 2);
				apiTGrid1.AddColumn(Resources.col_Prestation, "NQUICRE", 0);

				apiTGrid1.InitColumnList();
			}
			catch (Exception ex)
			{
				MZUtils.displayError(MethodBase.GetCurrentMethod().Name, ex);
			}
		}

		private void cmdAjouter_Click(object sender, EventArgs e)
		{
			new frmDetailPPS()
			{
				NIDPPS = 0,
				NACTNUM = MozartParams.NumAction,
				NINTNUM = GetNINTNUM_By_Action(MozartParams.NumAction)
			}.ShowDialog();

			apiTGrid1.Requery(dt, MozartDatabase.cnxMozart);
		}

		private void CmdDetail_Click(object sender, EventArgs e)
		{
			DataRow currentRow = apiTGrid1.GetFocusedDataRow();
			if (currentRow == null) return;

			new frmDetailPPS()
			{
				NIDPPS = (int)Utils.ZeroIfBlank(currentRow["NIDPPS"]),
				NACTNUM = (int)Utils.ZeroIfBlank(currentRow["NACTNUM"]),
				NINTNUM = (int)Utils.ZeroIfBlank(currentRow["NINTNUM"])
			}.ShowDialog();

			apiTGrid1.Requery(dt, MozartDatabase.cnxMozart);
		}

		private int GetNINTNUM_By_Action(int p_NACTNUM)
		{
			int returnNINTNUM = 0;

			using (SqlDataReader sqlGet = ModuleData.ExecuteReader($"exec [api_sp_GetNINTNUM_By_TACT] {p_NACTNUM}"))
			{
				while (sqlGet.Read())
				{
					returnNINTNUM = Convert.ToInt32(Utils.ZeroIfNull(sqlGet["NINTNUM"]));
				}
			}

			return returnNINTNUM;
		}

		private void CmdVisu_Click(object sender, EventArgs e)
		{
			DataRow currentRow = apiTGrid1.GetFocusedDataRow();
			if (currentRow == null) return;

			new frmMainReport
			{
				bLaunchByProcessStart = false,
				sTypeReport = "TPPSM",
				sIdentifiant = $"{currentRow["NIDPPS"]}",
				InfosMail = $"TINT|NINTNUM|{currentRow["NINTNUM"]}",
				sNomSociete = MozartParams.NomSociete,
				sLangue = $"{GetLangueByIntervenant(Convert.ToInt64(Utils.ZeroIfNull(currentRow["NINTNUM"])))}",
				sOption = "PREVIEW",
				strType = "PPS",
				numAction = MozartParams.NumAction
			}.ShowDialog();

		}


		private string GetLangueByIntervenant(long p_NINTNUM)
		{
			using (SqlDataReader sdrAdo = ModuleData.ExecuteReader($"EXEC [api_sp_GetLangueByIntervenant] {p_NINTNUM}"))
			{
				if (sdrAdo.Read()) return Utils.BlankIfNull(sdrAdo[0]);
			}
			return "FR";
		}

	}
}

