using MozartLib;
using MozartNet;
using System;
using System.Data;
using System.Drawing;
using System.Reflection;
using System.Windows.Forms;
using MZUtils = MozartControls.Utils;
using DevExpress.XtraGrid.Views.Grid;
using MozartCS.Properties;

namespace MozartCS
{
	public partial class frmListeEquipements : Form
	{

		private DataTable dtTable = new DataTable();

		public frmListeEquipements()
		{
			InitializeComponent();
		}

		private void frmListeEquipements_Load(object sender, EventArgs e)
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

		private void initGrid()
		{
			apiTGrid1.AddColumn(Resources.col_Immatriculation, "VVEHIMAT", 1500);
			apiTGrid1.AddColumn("Date début", "DEQUIPDDEB", 1200, "dd/mm/yy", 2);
			apiTGrid1.AddColumn("Date fin", "DEQUIPDFIN", 1200, "dd/mm/yy", 2);
			apiTGrid1.AddColumn(Resources.col_Fournisseur, "VEQUIPFOUR", 1700);
			apiTGrid1.AddColumn(Resources.col_Type, "VEQUIPTYPE", 1300);
			apiTGrid1.AddColumn("N° équipement", "VEQUIPREF", 1300);
			apiTGrid1.AddColumn(Resources.col_Code, "VEQUIPCODE", 1200);
			apiTGrid1.AddColumn(Resources.col_Statut, "VEQUIPSTATUT", 1300);


			apiTGrid1.InitColumnList();
			apiTGrid1.GridControl.DataSource = dtTable;
		}

		private void apiSocieteAuto1_Change(object sender, EventArgs e)
		{
			chargeListe();
		}

		private void chargeListe()
		{
			try
			{
				Cursor.Current = Cursors.WaitCursor;

				dtTable = new DataTable();
				apiTGrid1.LoadData(dtTable, MozartDatabase.cnxMozart, $"api_sp_ListeEquipementsFlotte '{apiSocieteAuto1.Text}', {apiSocieteAuto1.IdMenuParent}");
				apiTGrid1.GridControl.DataSource = dtTable;
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

		private void apiTGrid1_RowStyle(object sender, RowStyleEventArgs e)
		{
			if (e.RowHandle < 0) return;
			GridView view = sender as GridView;

			string lStatut = view.GetRowCellValue(e.RowHandle, "VEQUIPSTATUT").ToString();
			DateTime  dDateStatut = Convert.ToDateTime(view.GetRowCellValue(e.RowHandle, "DEQUIPDFIN"));

			if (dDateStatut < DateTime.Now && lStatut=="Actif")
			{
					e.Appearance.BackColor = Color.Red;
					e.HighPriority = true;
			}
		}

		private void btnModifier_Click(object sender, EventArgs e)
		{
			try
			{
				DataRow row = apiTGrid1.GetFocusedDataRow();
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
