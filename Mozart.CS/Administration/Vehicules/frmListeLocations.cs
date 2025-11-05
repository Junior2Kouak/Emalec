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
	public partial class frmListeLocations : Form
	{


		private DataTable dtTable = new DataTable();

		public frmListeLocations()
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
			grdLoc.AddColumn(MZCtrlResources.societe, "VSOCIETE", 1200);
			grdLoc.AddColumn("Collaborateur", "VPERNOM", 1700);
			grdLoc.AddColumn("Véhicule rattaché", "VVEHIMAT", 1500);
			grdLoc.AddColumn("Agence", "VLOCAGENCE", 1700);
			grdLoc.AddColumn(Resources.col_Ville, "VLOCVILLE", 1700);
			grdLoc.AddColumn("Date début", "DLOCDEB", 1200, "dd/mm/yy",2);
			grdLoc.AddColumn("Date retour", "DLOCFIN", 1200, "dd/mm/yy", 2);
			grdLoc.AddColumn(Resources.col_Statut, "VLOCSTATUT", 1300);

			grdLoc.InitColumnList();
			grdLoc.GridControl.DataSource = dtTable;
		}

		private void chargerListe()
		{
			try
			{
				Cursor.Current = Cursors.WaitCursor;

				dtTable = new DataTable();
				grdLoc.LoadData(dtTable, MozartDatabase.cnxMozart, $"api_sp_ListeLocations");
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

			new frmFormulaireLocation(0).ShowDialog();

			chargerListe();
		}

		private void btnModifier_Click(object sender, EventArgs e)
		{
			DataRow row = grdLoc.GetFocusedDataRow();
			if (row == null) return;

			int nLoc = Convert.ToInt32(row["NLOCNUM"].ToString());

			new frmFormulaireLocation(nLoc).ShowDialog();

			chargerListe();
		}


		private void btnSupprimer_Click(object sender, EventArgs e)
		{
			DataRow row = grdLoc.GetFocusedDataRow();
			if (row == null) return;

			int nEnt = Convert.ToInt32(row["NLOCNUM"].ToString());

			if (MessageBox.Show("Voulez-vous vraiment supprimer cette ligne ?", Program.AppTitle, MessageBoxButtons.YesNoCancel, MessageBoxIcon.Question) == DialogResult.Yes)
			{
				MozartDatabase.ExecuteNonQuery($"DELETE FROM TAUTOLOC WHERE NLOCNUM = {nEnt}");

				chargerListe();
			}
		}

		private void BtnFermer_Click(object sender, EventArgs e)
		{
			Close();
		}

	}
}
