using DevExpress.XtraGrid.Views.Grid;
using MozartCS.Properties;
using MozartLib;
using MozartNet;
using MozartUC;
using System;
using System.Data;
using System.Drawing;
using System.Reflection;
using System.Windows.Forms;
using MZCtrlResources = MozartControls.Properties.Resources;
using MZUtils = MozartControls.Utils;

namespace MozartCS
{
	public partial class frmListeSinistres : Form
	{


		private DataTable dtTable = new DataTable();

		public frmListeSinistres()
		{
			InitializeComponent();
		}

		private void frmListeSinistres_Load(object sender, EventArgs e)
		{
			try
			{
				Cursor.Current = Cursors.WaitCursor;

				ModuleMain.Initboutons(this);

				initGrid();

				apiSocieteAuto1.Init(MozartDatabase.cnxMozart, MozartParams.NomSociete);
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

		private void apiSocieteAuto1_Change(object sender, EventArgs e)
		{
			chargeListe();
		}

		private void initGrid()
		{
			grd.AddColumn("Créateur", "VPERCRE", 1600);
			grd.AddColumn(MZCtrlResources.societe, "VSOCIETE", 1200);
			grd.AddColumn("Collaborateur", "VPERNOM", 1600);
			grd.AddColumn("Véhicule", "VVEHIMAT", 1300);
			grd.AddColumn("Date sinistre", "DSINDATE", 1100, "dd/mm/yy", 2);
			grd.AddColumn("N° dossier", "VSINDOSSIER", 1300);
			grd.AddColumn("Responsabilité", "VSINRESPONSABLE", 1200,"",2);
			grd.AddColumn("Franchise", "CSINFRANCHISE", 1100,"",2);
			grd.AddColumn("Document", "VSINDOC", 1200);
			grd.AddColumn("Avec Tiers", "CSINTIERS", 1100, "", 2);
			grd.AddColumn("Date expert", "DSINEXPERTISE", 1100, "dd/mm/yy", 2);
			grd.AddColumn("Garage", "VSINGARAGE", 1500);
			grd.AddColumn(Resources.col_Statut, "VSINSTATUT", 1100,"",2);
			grd.AddColumn("Règlement Assurance", "NSINMONTANTASSURANCE", 1100,"",1);
			grd.AddColumn("Règlement EMALEC", "NSINMONTANTFILIALE", 1100,"",1);
			grd.AddColumn(Resources.col_Observation, "VSINOBS", 1800);

			grd.InitColumnList();
			grd.GridControl.DataSource = dtTable;
		}

		private void chargeListe()
		{
			try
			{
				Cursor.Current = Cursors.WaitCursor;

				dtTable = new DataTable();
				grd.LoadData(dtTable, MozartDatabase.cnxMozart, $"api_sp_ListeSinistres");
				grd.GridControl.DataSource = dtTable;
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

		private void grd_RowStyle(object sender, RowStyleEventArgs e)
		{
			if (e.RowHandle < 0) return;
			GridView view = sender as GridView;

			string lStatut = view.GetRowCellValue(e.RowHandle, "VSINSTATUT").ToString();

			if (lStatut == "Ouvert")
			{
				e.Appearance.BackColor = Color.Red;
				e.HighPriority = true;
			}
		}

		private void btnModifier_Click(object sender, EventArgs e)
		{
			try
			{
				DataRow row = grd.GetFocusedDataRow();
				if (row == null) return;

				frmDetailvehicules frm = new frmDetailvehicules();
				frm.miNumVehicule = Convert.ToInt32(row["NVEHNUM"].ToString());
				frm.mstrSociete = apiSocieteAuto1.Text;
				frm.mstrStatut = "M";
				frm.ShowDialog();

				chargeListe();
			}
			catch (Exception ex)
			{
				MZUtils.displayError(MethodBase.GetCurrentMethod().Name, ex);
			}

		}

		private void BtnFermer_Click(object sender, EventArgs e)
		{
			Close();
		}

	}
}
