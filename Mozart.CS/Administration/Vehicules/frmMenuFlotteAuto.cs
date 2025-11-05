using MozartCS.Properties;
using MozartLib;
using MozartNet;
using MozartUC;
using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Reflection;
using System.Windows.Forms;
using MZCtrlResources = MozartControls.Properties.Resources;
using MZUtils = MozartControls.Utils;

namespace MozartCS
{
	public partial class frmMenuFlotteAuto : Form
	{

		private DataTable dtTable = new DataTable();

		public frmMenuFlotteAuto()
		{
			InitializeComponent();
		}

		private void frmMenuFlotteAuto_Load(object sender, EventArgs e)
		{
			try
			{
				Cursor.Current = Cursors.WaitCursor;

				ModuleMain.Initboutons(this);
				apiSocieteAuto1.Init(MozartDatabase.cnxMozart, MozartParams.NomSociete, true, true);

				// load stat
				LoadData();

				initGrid();

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

		private void cmdVehicules_Click(object sender, EventArgs e)
		{
			new frmListeVehicules().ShowDialog();
		}

		private void LoadData()
		{

			using (SqlDataReader reader = MozartDatabase.ExecuteReader($"api_sp_StatFlotteAutomobile '{apiSocieteAuto1.Text}', {apiSocieteAuto1.IdMenuParent}"))
			{
				if (reader.Read())
				{
					cmdB0.Text = $"{Utils.ZeroIfNull(reader["B0"]).ToString()}\n{cmdB0.Tag}";
					cmdB1.Text = $"{Utils.ZeroIfNull(reader["B1"]).ToString()}\n{cmdB1.Tag}";
					cmdB2.Text = $"{Utils.ZeroIfNull(reader["B2"]).ToString()}\n{cmdB2.Tag}";
					cmdB3.Text = $"{Utils.ZeroIfNull(reader["B3"]).ToString()}\n\n{cmdB3.Tag}";
					cmdB4.Text = $"{Utils.ZeroIfNull(reader["B4"]).ToString()}\n\n{cmdB4.Tag}";
					cmdB5.Text = $"{Utils.ZeroIfNull(reader["B5"]).ToString()}\n{cmdB5.Tag}";
					cmdB6.Text = $"{Utils.BlankIfNull(reader["B6"]).ToString()}\n{cmdB6.Tag}";
					cmdB7.Text = $"Moyenne\nPRK VU\n{Utils.BlankIfNull(reader["B7"]).ToString()}";
					cmdB8.Text = $"Moyenne\nPRK VP\n{Utils.BlankIfNull(reader["B8"]).ToString()}";

				}
				else
				{
					List<Button> boutonsPanel = PanelStat.Controls.OfType<Button>().ToList();
					foreach (Button btn in boutonsPanel)
					{
						btn.Text = btn.Tag.ToString();
					}
				}
			}
		}


		private void apiSocieteAuto1_Change(object sender, EventArgs e)
		{
			// load stat
			LoadData();
		}

		private void ButtonDetails_Click(object sender, EventArgs e)
		{
			panelListe.Visible = false;
		}

		private void initGrid()
		{
			apiTGrid1.AddColumn(MZCtrlResources.societe, "VSOCIETE", 1200);
			apiTGrid1.AddColumn(Resources.col_Immatriculation, "VVEHIMAT", 1400);
			apiTGrid1.AddColumn(Resources.col_marque, "VVEHMARQUE", 1200);
			apiTGrid1.AddColumn("Modèle", "VVEHTYPE", 1200);
			apiTGrid1.AddColumn("Genre fiscal", "VVEHFISCAL", 1200);
			apiTGrid1.AddColumn(Resources.col_conducteur, "VVEHCOND", 1500);
			apiTGrid1.AddColumn("Pool", "CVEHPOOL", 1100);
			apiTGrid1.AddColumn(Resources.col_Statut, "VETATLIB", 1300);
			apiTGrid1.AddColumn("Date échéance", "DVEHECH", 1400, "dd/mm/yy");
			apiTGrid1.AddColumn("num", "NVEHNUM", 0);

			apiTGrid1.InitColumnList();
			apiTGrid1.GridControl.DataSource = dtTable;
		}

		private void chargeListe(int NumStat)
		{
			try
			{
				Cursor.Current = Cursors.WaitCursor;

				dtTable = new DataTable();
				apiTGrid1.LoadData(dtTable, MozartDatabase.cnxMozart, $"api_sp_ListeVehiculesStat '{apiSocieteAuto1.Text}', {apiSocieteAuto1.IdMenuParent}, {NumStat} ");
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


		private void cmdB_Click(object sender, EventArgs e)
		{
			panelListe.Visible = true;
			panelListe.Location = new Point(465, panelListe.Location.X);
			panelListe.Location = new Point(165, panelListe.Location.Y);

			Button boutonClique = (Button)sender; 

			switch (boutonClique.Name)
			{
				case "cmdB0":
					lblTitre.Text = "Véhicules arrivants à échéance";
					chargeListe(0); break;
				case "cmdB1":
					lblTitre.Text = "Véhicules disponibles";
					chargeListe(1); break;
				case "cmdB2":
					lblTitre.Text = "Véhicules en réparation";
					chargeListe(2); break;
				case "cmdB3":
					lblTitre.Text = "Véhicules VU";
					chargeListe(3); break;
				case "cmdB4":
					lblTitre.Text = "Véhicules VP";
					chargeListe(4); break;
				case "cmdB5":
					lblTitre.Text = "Véhicules avec révisions en retard";
					chargeListe(5); break;
			}
		}

		private void cmdLocations_Click(object sender, EventArgs e)
		{
			MessageBox.Show("En cours de développement...", Program.AppTitle, MessageBoxButtons.OK, MessageBoxIcon.Information);
			//Cursor = Cursors.WaitCursor; 
			//new frmListeLocations().ShowDialog();
			//Cursor = Cursors.Default;	
		}

		private void cmdSinistres_Click(object sender, EventArgs e)
		{
			MessageBox.Show("En cours de développement...", Program.AppTitle, MessageBoxButtons.OK, MessageBoxIcon.Information);
			//Cursor = Cursors.WaitCursor;
			//new frmListeSinistres().ShowDialog();
			//Cursor = Cursors.Default;
		}

		private void cmdEquipements_Click(object sender, EventArgs e)
		{
			Cursor = Cursors.WaitCursor;
			new frmListeEquipements().ShowDialog();
			Cursor = Cursors.Default;
		}

		private void cmdPool_Click(object sender, EventArgs e)
		{
			MessageBox.Show("En cours de développement...", Program.AppTitle, MessageBoxButtons.OK, MessageBoxIcon.Information);
			//Cursor = Cursors.WaitCursor;
			//new frmListeReservations().ShowDialog();
			//Cursor = Cursors.Default;
		}

		private void cmdDepenses_Click(object sender, EventArgs e)
		{
			new frmListeDepenses().ShowDialog();
		}

		private void cmdQuitter_Click(object sender, System.EventArgs e)
		{
			Dispose();
		}

	}
}

