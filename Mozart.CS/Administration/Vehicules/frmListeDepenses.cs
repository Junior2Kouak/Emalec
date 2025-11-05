using MozartLib;
using MozartNet;
using System;
using System.Data;
using System.Drawing;
using System.Reflection;
using System.Windows.Forms;
using MZUtils = MozartControls.Utils;
using MZCtrlResources = MozartControls.Properties.Resources;
using DevExpress.XtraGrid.Views.Grid;
using MozartCS.Properties;

namespace MozartCS
{
	public partial class frmListeDepenses : Form
	{


		private DataTable dtTable = new DataTable();

		public frmListeDepenses()
		{
			InitializeComponent();
		}

		private void frmListeDepenses_Load(object sender, EventArgs e)
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
			apiTGrid1.AddColumn(MZCtrlResources.societe, "VSOCIETE", 1000);
			apiTGrid1.AddColumn(Resources.col_Immatriculation, "VVEHIMAT", 1300);
			apiTGrid1.AddColumn(Resources.col_marque, "VVEHMARQUE", 1200);
			apiTGrid1.AddColumn("Modèle", "VVEHTYPE", 1200);
			apiTGrid1.AddColumn("Carburant", "VVEHCARBU2", 1000);
			apiTGrid1.AddColumn(Resources.col_conducteur, "VVEHCOND", 1700);
			apiTGrid1.AddColumn(Resources.col_Statut, "VETATLIB", 1200);
			apiTGrid1.AddColumn("Entrée", "DVEHDENTRE", 1100, "dd/mm/yy",2);
			apiTGrid1.AddColumn(Resources.col_Kms, "NVEHDERKM", 1100,"# ###",2);
			apiTGrid1.AddColumn("PRK", "PRK", 1150,"",2);
			apiTGrid1.AddColumn("Dépenses totales", "TOTAL", 1400,"# ###",1);
			apiTGrid1.AddColumn("Achat", "ACHAT", 1150,"# ###", 1);
			apiTGrid1.AddColumn("Entretien", "ENTRETIEN", 1150, "# ###", 1);
			apiTGrid1.AddColumn("Panne", "PANNE", 1150, "# ###", 1);
			apiTGrid1.AddColumn("Sinistre", "SINISTRE", 1150, "# ###", 1);
			apiTGrid1.AddColumn("Autre", "AUTRE", 1150, "# ###", 1);
			apiTGrid1.AddColumn("Carburant", "CARBURANT", 1150, "# ###", 1);
			apiTGrid1.AddColumn("Péage/Park", "PEAGE", 1150, "# ###", 1);


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
				apiTGrid1.LoadData(dtTable, MozartDatabase.cnxMozart, $"api_sp_ListeDepensesFlotte '{apiSocieteAuto1.Text}', {apiSocieteAuto1.IdMenuParent}");
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

	

		private void apiTGrid1_RowCellStyle(object sender, RowCellStyleEventArgs e)
		{
			if (e.RowHandle < 0) return;

			GridView view = (GridView)sender;

			

			switch (e.Column.FieldName)
			{
				case "PRK":
					double lCurrentRowFieldValue = Convert.ToDouble(view.GetRowCellDisplayText(e.RowHandle, e.Column.FieldName));

					e.Appearance.BackColor = Color.Orange;

					if (lCurrentRowFieldValue > 1)
						{
								e.Appearance.BackColor = Color.Red;
						}
					if (lCurrentRowFieldValue < 0.5)
					{
						e.Appearance.BackColor = Color.Green;
					}
					break;
				default:
					break;
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
