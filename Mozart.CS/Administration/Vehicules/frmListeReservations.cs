using MozartLib;
using MozartNet;
using System;
using System.Data;
using System.Reflection;
using System.Windows.Forms;
using MZUtils = MozartControls.Utils;
using MZCtrlResources = MozartControls.Properties.Resources;
using MozartCS.Properties;

namespace MozartCS
{
	public partial class frmListeReservations : Form
	{


		private DataTable dtTable = new DataTable();

		public frmListeReservations()
		{
			InitializeComponent();
		}

		private void frmListeLocations_Load(object sender, EventArgs e)
		{

			try
			{
				Cursor.Current = Cursors.WaitCursor;

				ModuleMain.Initboutons(this);

				initGrid();
				chargerListe();

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
			grdLoc.AddColumn("Collaborateur", "VPERNOM", 1700);
			grdLoc.AddColumn(MZCtrlResources.societe, "VSOCIETE", 1200);
			grdLoc.AddColumn("Véhicule", "VVEHIMAT", 1500);
			grdLoc.AddColumn("Date début", "DRESADEB", 1200, "dd/mm/yy",2);
			grdLoc.AddColumn("Date fin", "DRESAFIN", 1200, "dd/mm/yy", 2);
			grdLoc.AddColumn(Resources.col_Statut, "VRESASTATUT", 1300);
			grdLoc.AddColumn("Type de réservation", "VRESATYPE", 1300);
			grdLoc.AddColumn("Observations", "VRESADETAIL", 1700);

			grdLoc.InitColumnList();
			grdLoc.GridControl.DataSource = dtTable;
		}

		private void chargerListe()
		{
			try
			{
				Cursor.Current = Cursors.WaitCursor;

				dtTable = new DataTable();
				grdLoc.LoadData(dtTable, MozartDatabase.cnxMozart, $"api_sp_ListeReservations");
				grdLoc.GridControl.DataSource = dtTable;
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


		private void btnAjouter_Click(object sender, EventArgs e)
		{

			new frmFormulaireReservation(0).ShowDialog();

			chargerListe();
		}

		private void btnModifier_Click(object sender, EventArgs e)
		{
			DataRow row = grdLoc.GetFocusedDataRow();
			if (row == null) return;

			int nLoc = Convert.ToInt32(row["NRESANUM"].ToString());

			new frmFormulaireReservation(nLoc).ShowDialog();

			chargerListe();
		}

		private void btnAnnuler_Click(object sender, EventArgs e)
		{
			DataRow row = grdLoc.GetFocusedDataRow();
			if (row == null) return;

			int nEnt = Convert.ToInt32(row["NRESANUM"].ToString());

			if (MessageBox.Show("Voulez-vous vraiment annuler cette réservation ?", Program.AppTitle, MessageBoxButtons.YesNoCancel, MessageBoxIcon.Question) == DialogResult.Yes)
			{
				MozartDatabase.ExecuteNonQuery($"UPDATE TAUTORESA SET VRESASTATUT='Annulée' WHERE NRESANUM = {nEnt}");

				chargerListe();
			}

		}

		private void btnSupprimer_Click(object sender, EventArgs e)
		{
			DataRow row = grdLoc.GetFocusedDataRow();
			if (row == null) return;

			int nEnt = Convert.ToInt32(row["NRESANUM"].ToString());

			if (MessageBox.Show("Voulez-vous vraiment supprimer cette ligne ?", Program.AppTitle, MessageBoxButtons.YesNoCancel, MessageBoxIcon.Question) == DialogResult.Yes)
			{
				MozartDatabase.ExecuteNonQuery($"DELETE FROM TAUTORESA WHERE NRESANUM = {nEnt}");

				chargerListe();
			}
		}

		private void BtnFermer_Click(object sender, EventArgs e)
		{
			Close();
		}

	}
}
