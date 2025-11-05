using MozartCS.Properties;
using MozartLib;
using MozartNet;
using System;
using System.Data;
using System.Drawing;
using System.Reflection;
using System.Web;
using System.Windows.Forms;
using MZCtrlResources = MozartControls.Properties.Resources;
using MZUtils = MozartControls.Utils;

namespace MozartCS
{
	public partial class frmMessageTechnicien : Form
	{


		private DataTable dtTable = new DataTable();

		public frmMessageTechnicien()
		{
			InitializeComponent();
		}

		private void frmListeVehicules_Load(object sender, EventArgs e)
		{
			try
			{
				Cursor.Current = Cursors.WaitCursor;

				ModuleMain.Initboutons(this);

				initGrid();

				apiSocieteAuto1.Init(MozartDatabase.cnxMozart, MozartParams.NomSociete,false,false);

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
			apiTGrid1.AddColumn(Resources.col_Num, "NMESNUM", 1200);
			apiTGrid1.AddColumn(Resources.col_Date, "DMESDAT", 1200);
			apiTGrid1.AddColumn(Resources.col_Actif, "CMESACTIF", 1200);
			apiTGrid1.AddColumn(Resources.col_Titre, "VMESLIB", 6000);

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
				apiTGrid1.LoadData(dtTable, MozartDatabase.cnxMozart, $"api_sp_ListeMessageTechnicien '{apiSocieteAuto1.Text}'");
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

	
		private void BtnAjouter_Click(object sender, EventArgs e)
		{
			if (apiSocieteAuto1.Text == "GROUPE")
			{
				MessageBox.Show("Un message ne peut pas être ajouté sur le Groupe : Il faut sélectionner une société.", Program.AppTitle, MessageBoxButtons.OK, MessageBoxIcon.Error);

				return;
			}

			new FrmDetailMessageTechnicien("T", 0, apiSocieteAuto1.Text).ShowDialog();

			chargeListe();
		}

		private void ButtonDetails_Click(object sender, EventArgs e)
		{
			try
			{
				DataRow row = apiTGrid1.GetFocusedDataRow();
				if (row == null) return;

				new FrmDetailMessageTechnicien("T", Convert.ToInt32(row["NMESNUM"].ToString()), apiSocieteAuto1.Text).ShowDialog();

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

			int nMesNum = Convert.ToInt32(row["NMESNUM"].ToString());

			if (row["CMESACTIF"].ToString() == "O")
			{
				if (MessageBox.Show("Voulez-vous vraiment archiver ce message ?", Program.AppTitle, MessageBoxButtons.YesNoCancel, MessageBoxIcon.Question) == DialogResult.Yes)
				{
					MozartDatabase.ExecuteNonQuery($"UPDATE TMESSAGETECH SET CMESACTIF = 'N' WHERE NMESNUM = {nMesNum}");

					chargeListe();
				}
			}
			else
			{
				if (MessageBox.Show("Voulez-vous vraiment restaurer ce message ?", Program.AppTitle, MessageBoxButtons.YesNoCancel, MessageBoxIcon.Question) == DialogResult.Yes)
				{
					MozartDatabase.ExecuteNonQuery($"UPDATE TMESSAGETECH SET CMESACTIF = 'O' WHERE NMESNUM = {nMesNum}");

					chargeListe();
				}
			}
		}

		private void cmdSupprimer_Click(object sender, EventArgs e)
		{
			DataRow row = apiTGrid1.GetFocusedDataRow();
			if (row == null) return;

			int nMesNum = Convert.ToInt32(row["NMESNUM"].ToString());

				if (MessageBox.Show("Voulez-vous vraiment supprimer ce message ?", Program.AppTitle, MessageBoxButtons.YesNoCancel, MessageBoxIcon.Question) == DialogResult.Yes)
				{
					MozartDatabase.ExecuteNonQuery($"DELETE FROM TMESSAGETECH WHERE NMESNUM = {nMesNum}");

					chargeListe();
				}
		}

		private void cmdVisu_Click(object sender, EventArgs e)
		{
			try
			{
				C_CRYPTAGE oGenCrypt = new C_CRYPTAGE("password");

				frmBrowserSimple f = new frmBrowserSimple();
				f.StartingAddress = $"https://tablets.emalec.com/MessageTechnicien.aspx?NPERNUM={HttpUtility.UrlEncode(oGenCrypt.AES_Encrypt("0"))}&VSOCIETE={apiSocieteAuto1.Text}";
				f.ShowDialog();
				Cursor.Current = Cursors.Default;
			}
			catch (Exception)
			{
				Cursor.Current = Cursors.Default;
			}

		}

		private void BtnFermer_Click(object sender, EventArgs e)
		{
			Close();
		}
	}
}
