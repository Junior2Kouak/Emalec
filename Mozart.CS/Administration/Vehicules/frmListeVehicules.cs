using MozartLib;
using MozartNet;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Reflection;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using MZUtils = MozartControls.Utils;
using MZCtrlResources = MozartControls.Properties.Resources;
using DevExpress.XtraGrid.Views.Grid;
using MozartCS.Properties;

namespace MozartCS
{
	public partial class frmListeVehicules : Form
	{
		private const string COL_NVEHNUM = "NVEHNUM";
		private const string COL_VVEHNUMCLE = "VVEHNUMCLE";
		private const string COL_VSOCIETE = "VSOCIETE";
		private const string COL_KM = "KM";
		private const string COL_KMREV = "KMREV";
		private const string COL_DVEHDCTRL = "DVEHDCTRL";
		private const string COL_DVEHDASS = "DVEHDASS";
		private const string COL_DVEHCTRLPOL = "DVEHCTRLPOL";
		private const string COL_DVEHMONTPNEU = "DVEHMONTPNEU";


		private bool mBIsFenetreArchive;
		private string mTitreForm;

		private DataTable dtTable = new DataTable();

		public frmListeVehicules()
		{
			InitializeComponent();
		}

		private void frmListeVehicules_Load(object sender, EventArgs e)
		{
			try
			{
				Cursor.Current = Cursors.WaitCursor;

				mBIsFenetreArchive = false;

				mTitreForm = LabelTitre.Text;

				ModuleMain.Initboutons(this);

				initGrid();

				apiSocieteAuto1.Init(MozartDatabase.cnxMozart, MozartParams.NomSociete);

				//if (MozartParams.UID == 30)
				//{
					button1.Visible = true;
				//}
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
			apiTGrid1.AddColumn(MZCtrlResources.col_No, COL_VVEHNUMCLE, 850);
			apiTGrid1.AddColumn(MZCtrlResources.societe, COL_VSOCIETE, 1150);
			apiTGrid1.AddColumn("Gestionnaire", "VVEHGESTIONNAIRE", 1150);
			apiTGrid1.AddColumn(Resources.col_Immatriculation, "VVEHIMAT", 1150);
			apiTGrid1.AddColumn(Resources.col_marque, "VVEHMARQUE", 1150);
			apiTGrid1.AddColumn("Modèle", "VVEHTYPE", 1150);
			apiTGrid1.AddColumn("Carburant", "VVEHCARBU2", 1150);
			apiTGrid1.AddColumn(Resources.col_conducteur, "VVEHCOND", 1150);
			apiTGrid1.AddColumn("Département", "VDEP", 900);
			apiTGrid1.AddColumn("Catégorie", "VPERCATEGORIE", 1150);
			apiTGrid1.AddColumn("Aménagement", "VVEHAMENAGEMENT", 1150);
			apiTGrid1.AddColumn(Resources.col_Type, "CPERTYP", 1150);
			apiTGrid1.AddColumn(Resources.col_Statut, "VETATLIB", 1150);
			apiTGrid1.AddColumn("Entrée", "E", 1150);
			apiTGrid1.AddColumn(Resources.col_Observations, "VVEHOBS", 1150);
			apiTGrid1.AddColumn(Resources.col_Contrat, "VVEHCONT", 1150);
			apiTGrid1.AddColumn(Resources.col_Kms, COL_KM, 1150);
			apiTGrid1.AddColumn("CO2", "NVEHGCO2", 1150);
			apiTGrid1.AddColumn("Crit'Air", "VVEHCRITAIR", 1150);
			apiTGrid1.AddColumn(Resources.col_Num_serie, "VVEHNSERIE", 1150);
			apiTGrid1.AddColumn("1ère MEC", "C", 1000, "dd/mm/yy");
			apiTGrid1.AddColumn("Rév", COL_KMREV, 1150);
			apiTGrid1.AddColumn("Date Ctrl", COL_DVEHDCTRL, 1000, "dd/mm/yy");
			apiTGrid1.AddColumn("Date Ctrl Pol", COL_DVEHCTRLPOL, 1000, "dd/mm/yy");
			apiTGrid1.AddColumn("N° GPS", "VVEHNGPS", 1150);
			apiTGrid1.AddColumn("Date Inst", "DVEHINSTGPS", 1000, "dd/mm/yy");
			apiTGrid1.AddColumn("Pneus", "VVEHTPNEU", 1150);
			apiTGrid1.AddColumn("Type de pneus", "VVEHTYPEPNEU", 1150);
			apiTGrid1.AddColumn("Nb Places", "VNBPLACES", 1150);
			apiTGrid1.AddColumn("Date Pneus", COL_DVEHMONTPNEU, 1000, "dd/mm/yy");
			apiTGrid1.AddColumn("N° Péage", "VVEHNUMPEAGE", 1150);

			apiTGrid1.AddColumn(COL_DVEHDASS, COL_DVEHDASS, 0);
			apiTGrid1.AddColumn(COL_NVEHNUM, COL_NVEHNUM, 0);

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

				string lStatutArchive;
				if (mBIsFenetreArchive)
				{
					lStatutArchive = "N";
					LabelTitre.Text = mTitreForm + " " + MZCtrlResources.archives;
				}
				else
				{
					lStatutArchive = "O";
					LabelTitre.Text = mTitreForm;
				}

				BtnAjouter.Visible = !mBIsFenetreArchive;
				ButtonArchiver.Visible = !mBIsFenetreArchive;
				ButtonLstArchives.Visible = !mBIsFenetreArchive;
				ButtonRestaurer.Visible = mBIsFenetreArchive;

				dtTable = new DataTable();
				apiTGrid1.LoadData(dtTable, MozartDatabase.cnxMozart, $"api_sp_ListeVehicules2 '{apiSocieteAuto1.Text}', {apiSocieteAuto1.IdMenuParent}, '{lStatutArchive}'");
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

		private void BtnFermer_Click(object sender, EventArgs e)
		{
			// si on ferme la liste d'archive, on veux revenir à la liste normale
			if (mBIsFenetreArchive)
			{
				mBIsFenetreArchive = false;

				chargeListe();
			}
			else
			{
				Close();
			}
		}

		private void ButtonDetails_Click(object sender, EventArgs e)
		{
			try
			{
				DataRow row = apiTGrid1.GetFocusedDataRow();
				if (row == null) return;

				new frmDetailVehicule(Convert.ToInt32(row[COL_NVEHNUM].ToString()), row[COL_VSOCIETE].ToString(), mBIsFenetreArchive).ShowDialog();

				chargeListe();
			}
			catch (Exception ex)
			{
				MZUtils.displayError(MethodBase.GetCurrentMethod().Name, ex);
			}
			finally
			{
			}
		}

		private void ButtonArchiver_Click(object sender, EventArgs e)
		{
			DataRow row = apiTGrid1.GetFocusedDataRow();
			if (row == null) return;

			int nVehNum = Convert.ToInt32(row[COL_NVEHNUM].ToString());

			if (row["VVEHNGPS"].ToString() != "")
			{
				MessageBox.Show("Archivage impossible car il y a un numéro de GPS. Il faut voir avec le responsable des véhicules.",
											Program.AppTitle, MessageBoxButtons.OK, MessageBoxIcon.Error);

				return;
			}

			if (MessageBox.Show("Voulez-vous vraiment archiver ce véhicule ?", Program.AppTitle, MessageBoxButtons.YesNoCancel, MessageBoxIcon.Question) == DialogResult.Yes)
			{
				MozartDatabase.ExecuteNonQuery($"UPDATE TVEHICULES SET CVEHACTIF = 'N' WHERE NVEHNUM = {nVehNum}");

				chargeListe();
			}
		}

		private void ButtonLstArchives_Click(object sender, EventArgs e)
		{
			mBIsFenetreArchive = true;

			BtnAjouter.Visible = !mBIsFenetreArchive;
			ButtonArchiver.Visible = !mBIsFenetreArchive;
			ButtonLstArchives.Visible = !mBIsFenetreArchive;

			chargeListe();

			ButtonRestaurer.Visible = mBIsFenetreArchive;
		}

		private void ButtonRestaurer_Click(object sender, EventArgs e)
		{
			DataRow row = apiTGrid1.GetFocusedDataRow();
			if (row == null) return;

			int nVehNum = Convert.ToInt32(row[COL_NVEHNUM].ToString());

			if (MessageBox.Show("Voulez-vous vraiment restaurer ce véhicule ?", Program.AppTitle, MessageBoxButtons.YesNoCancel, MessageBoxIcon.Question) == DialogResult.Yes)
			{
				MozartDatabase.ExecuteNonQuery($"UPDATE TVEHICULES SET CVEHACTIF = 'O' WHERE NVEHNUM = {nVehNum}");

				chargeListe();
			}
		}

		private void BtnAjouter_Click(object sender, EventArgs e)
		{
			if (apiSocieteAuto1.Text == "GROUPE")
			{
				MessageBox.Show("Un véhicule ne peut pas être ajouté sur le Groupe : Il faut sélectionner une société.", Program.AppTitle, MessageBoxButtons.OK, MessageBoxIcon.Error);

				return;
			}

			new frmDetailVehicule(0, apiSocieteAuto1.Text).ShowDialog();

			chargeListe();
		}

		private void apiTGrid1_RowStyle(object sender, DevExpress.XtraGrid.Views.Grid.RowStyleEventArgs e)
		{
			// Gérer les codes couleurs particuliers QUE pour les véhicules non-archivés
			if (mBIsFenetreArchive) return;
			if (e.RowHandle < 0) return;
			GridView view = sender as GridView;

			string lStatut = view.GetRowCellValue(e.RowHandle, "VETATLIB").ToString();

			switch (lStatut)
			{
				case "Disponible":
					e.Appearance.BackColor = Color.SpringGreen;
					e.HighPriority = true;
					break;

				case "En réparation":
					e.Appearance.BackColor = Color.Orange;
					e.HighPriority = true;
					break;
			}
		}

		private void apiTGrid1_DoubleClickE(object sender, EventArgs e)
		{
			ButtonDetails_Click(sender, e);
		}

		private void apiTGrid1_RowCellStyle(object sender, RowCellStyleEventArgs e)
		{
			// Gérer les codes couleurs particuliers QUE pour les véhicules non-archivés
			if (mBIsFenetreArchive) return;
			if (e.RowHandle < 0) return;

			GridView view = (GridView)sender;

			string lCurrentRowFieldValue = view.GetRowCellDisplayText(e.RowHandle, e.Column.FieldName);

			switch (e.Column.FieldName)
			{
				case COL_KM:
					int lKM;
					int lKMRev;

					if (Int32.TryParse(view.GetRowCellDisplayText(e.RowHandle, view.Columns[COL_KMREV]), out lKMRev))
					{
						if (Int32.TryParse(lCurrentRowFieldValue, out lKM))
						{
							if ((lKM + 3000) >= lKMRev)
							{
								e.Appearance.BackColor = Color.Orange;
							}
						}
					}
					break;

				case COL_DVEHDCTRL:
				case COL_DVEHDASS:
				case COL_DVEHCTRLPOL:
				case COL_DVEHMONTPNEU:
					DateTime lDate;

					if (DateTime.TryParse(lCurrentRowFieldValue, out lDate))
					{
						if (lDate < DateTime.Now.AddMonths(1))
						{
							e.Appearance.BackColor = Color.Orange;
						}
					}
					break;

				default:
					break;
			}
		}

		private void cmdLegende_Click(object sender, EventArgs e)
		{
			Frame1.Visible = true;
		}

		private void Command1_Click(object sender, EventArgs e)
		{
			Frame1.Visible = false;
		}

		private void button1_Click(object sender, EventArgs e)
		{
			try
			{
				DataRow row = apiTGrid1.GetFocusedDataRow();
				if (row == null) return;

				frmDetailvehicules frm = new frmDetailvehicules();
				frm.miNumVehicule = Convert.ToInt32(row[COL_NVEHNUM].ToString());
				frm.mstrSociete = row[COL_VSOCIETE].ToString();
				frm.mstrStatut = "M";
				frm.ShowDialog();

				chargeListe();
			}
			catch (Exception ex)
			{
				MZUtils.displayError(MethodBase.GetCurrentMethod().Name, ex);
			}
		}
	}
}
