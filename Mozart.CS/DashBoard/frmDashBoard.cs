using MozartCS.Properties;
using MozartLib;
using MozartNet;
using MozartUC;
using System;
using System.Collections.Generic;
using System.Data;
using System.Drawing;
using System.Drawing.Printing;
using System.Windows.Forms;

namespace MozartCS
{
	public partial class frmDashBoard : Form
	{
		DataTable _DTOpe = new DataTable();
		DataTable _DTFact = new DataTable();
		DataTable _DTRAVEL = new DataTable();
		DataTable _DTQSE = new DataTable();


		public frmDashBoard()
		{
			InitializeComponent();

			txtObjOpe.Text = $"Ne pas dépasser les 100 devis en attente par CHAFF.\r\n" +
													"Ne pas dépasser les 50 devis à faire et aucun devis supérieur à 1 mois.\r\n" +
													"Traiter les clôtures d’intervention à J + 1.\r\n" +
													"Une action avec commande client ne doit pas rester dans les statuts M ou W plus d’1 mois.\r\n" +
													"Ne pas dépasser 5 relances traitement par personne.";

			txtObjFact.Text = $"Des clôtures de facturation périodiques sont prévues en :\r\n" +
													"- Avril / Juin / Septembre / Décembre\r\n\r\n" +
													"Plus vite les actions sont traitées, plus vite on peut facturer les clients.\r\n" +
													"Objectif 0 impayé échu.";

			txtObjRAVEL.Text = $"Aucune facture à échéance dépassée non bloquée via un courrier au fournisseur/sous-traitant";

			txtObjQSE.Text = $"22 enquêtes qualités par mois par Chargé(e) de clientèle.";

		}

		private void frmDashBoard_Load(object sender, EventArgs e)
		{
			ModuleMain.Initboutons(this);

			// initialisation des combos
			cbCritClient.Init(MozartDatabase.cnxMozart, "api_sp_comboClientDash", "NCLINUM", "VCLINOM", new List<string>() { Resources.col_Num, Resources.col_Nom }, 250, 550, true);
			cbCritClient.NewValues = true;
			cbCritChaff.Init(MozartDatabase.cnxMozart, "api_sp_comboChaffDash", "NPERNUM", "VPERNOM", new List<string>() { Resources.col_Num, Resources.col_Nom }, 150, 550, true);

			// chargement des données
			LoadData();

		}

		private void BtnAide_Click(object sender, EventArgs e)
		{

			MessageBox.Show($"Les données affichées sont calculées par défaut sur l'ensemble de votre périmètre.\r\n\r\n Les données sont actualisées et enregistrées toutes les 24 heures durant la nuit.\r\n\r\n" +
					$"Les enregistrements permettent de générer l'indicateur de tendance sur les 15 derniers jours glissants.", "Information", MessageBoxButtons.OK, MessageBoxIcon.Information);

		}

		private void LoadData()
		{

			int client = (cbCritClient.GetText() == "") ? 0 : (int)Utils.ZeroIfNull(cbCritClient.GetValue());
			int chaff = (cbCritChaff.GetText() == "") ? 0 : (int)Utils.ZeroIfNull(cbCritChaff.GetValue());

			_DTOpe.Clear();
			_DTOpe.Load(ModuleData.ExecuteReader($"exec api_sp_StatDashBoard  {client}, {chaff}, {Utils.ZeroIfNull(txtCritcompte.Text)}, 'OPE'"));
			GCOpe.DataSource = _DTOpe;

			_DTFact.Clear();
			_DTFact.Load(ModuleData.ExecuteReader($"exec api_sp_StatDashBoard  {client}, {chaff}, {Utils.ZeroIfNull(txtCritcompte.Text)}, 'FAC'"));
			GCFact.DataSource = _DTFact;

			_DTRAVEL.Clear();
			_DTRAVEL.Load(ModuleData.ExecuteReader($"exec api_sp_StatDashBoard  {client}, {chaff}, {Utils.ZeroIfNull(txtCritcompte.Text)}, 'RAV'"));
			GCRAVEL.DataSource = _DTRAVEL;

			_DTQSE.Clear();
			_DTQSE.Load(ModuleData.ExecuteReader($"exec api_sp_StatDashBoard  {client}, {chaff}, {Utils.ZeroIfNull(txtCritcompte.Text)}, 'QSE'"));
			GCQSE.DataSource = _DTQSE;
		}

		private void cmdFind_Click(object sender, EventArgs e)
		{
			LoadData();
		}

		private void GV_CustomDrawCell(object sender, DevExpress.XtraGrid.Views.Base.RowCellCustomDrawEventArgs e)
		{

			if (e.Column.FieldName == "TENDANCE")
			{
				if (e.DisplayText == "") return;
				if (Convert.ToInt32(e.DisplayText) > 0)
				{
					Image temp = Resources.down_arrow;
					e.Cache.Paint.DrawImage(e.Graphics, temp, new Rectangle(e.Bounds.X + 25, e.Bounds.Y - 13, temp.Width, temp.Height));
					e.Handled = true;
				}
				else if (Convert.ToInt32(e.DisplayText) < 0)
				{
					Image temp = Resources.up_arrow;
					e.Cache.Paint.DrawImage(e.Graphics, temp, new Rectangle(e.Bounds.X + 25, e.Bounds.Y + 0, temp.Width, temp.Height));
					e.Handled = true;
				}
				else if (Convert.ToInt32(e.DisplayText) == 0)
				{
					Image temp = Resources.right_arrows;
					e.Cache.Paint.DrawImage(e.Graphics, temp, new Rectangle(e.Bounds.X + 20, e.Bounds.Y - 7, temp.Width, temp.Height));
					e.Handled = true;
				}
			}
		}

		private void apiButton1_Click(object sender, EventArgs e)
		{

			if (((apiButton)sender).Tag.ToString() == "1")
			{
				string filename = "Export_Dashboard_Opérationel_" + DateTime.Now.Day.ToString() + DateTime.Now.Month.ToString() + DateTime.Now.Year.ToString();
				sFD.FileName = filename;

				if (sFD.ShowDialog() == DialogResult.OK)
				{
					if (sFD.FileName != "")
					{
						GCOpe.ExportToXlsx(sFD.FileName);
					}
				}
			}
			if (((apiButton)sender).Tag.ToString() == "2")
			{
				string filename = "Export_Dashboard_Facturation_" + DateTime.Now.Day.ToString() + DateTime.Now.Month.ToString() + DateTime.Now.Year.ToString();
				sFD.FileName = filename;

				if (sFD.ShowDialog() == DialogResult.OK)
				{
					if (sFD.FileName != "")
					{
						GCFact.ExportToXlsx(sFD.FileName);
					}
				}
			}
			if (((apiButton)sender).Tag.ToString() == "3")
			{
				string filename = "Export_Dashboard_Ravel_" + DateTime.Now.Day.ToString() + DateTime.Now.Month.ToString() + DateTime.Now.Year.ToString();
				sFD.FileName = filename;

				if (sFD.ShowDialog() == DialogResult.OK)
				{
					if (sFD.FileName != "")
					{
						GCRAVEL.ExportToXlsx(sFD.FileName);
					}
				}
			}
			if (((apiButton)sender).Tag.ToString() == "4")
			{
				string filename = "Export_Dashboard_QSE_" + DateTime.Now.Day.ToString() + DateTime.Now.Month.ToString() + DateTime.Now.Year.ToString();
				sFD.FileName = filename;

				if (sFD.ShowDialog() == DialogResult.OK)
				{
					if (sFD.FileName != "")
					{
						GCQSE.ExportToXlsx(sFD.FileName);
					}
				}
			}
		}

		private void printDocument1_PrintPage(object sender, PrintPageEventArgs e)
		{
			Bitmap memoryImage;
			Graphics myGraphics = this.CreateGraphics();
			Size s = this.Size;

			memoryImage = new Bitmap(s.Width, s.Height, myGraphics);
			Graphics memoryGraphics = Graphics.FromImage(memoryImage);

			memoryGraphics.CopyFromScreen(this.Location.X, this.Location.Y, 0, 0, s);

			e.Graphics.DrawImage(memoryImage, 0, 0);
		}

		private void cmdPrint_Click(object sender, EventArgs e)
		{
			PrintDialog1.AllowSomePages = true;

			PrintDialog1.ShowHelp = true;

			PrintDialog1.Document = docToPrint;

			DialogResult result = PrintDialog1.ShowDialog();

			if (result == DialogResult.OK)
			{
				docToPrint.Print();
			}
		}

		private void GV_RowCellClick(object sender, DevExpress.XtraGrid.Views.Grid.RowCellClickEventArgs e)
		{
			// On teste la colonne double-cliquée
			DevExpress.XtraGrid.Views.Grid.GridView GV = ((DevExpress.XtraGrid.Views.Grid.GridView)sender);

			DataRow currentRow = GV.GetFocusedDataRow();
			if (currentRow == null) return;

			int client = (cbCritClient.GetText() == "") ? 0 : (int)Utils.ZeroIfNull(cbCritClient.GetValue());
			int chaff = (cbCritChaff.GetText() == "") ? 0 : (int)Utils.ZeroIfNull(cbCritChaff.GetValue());

			double idstat = Utils.ZeroIfNull(currentRow["NSTATNUM"]);
			double compte = Utils.ZeroIfNull(txtCritcompte.Text);

			if (GV.Name == "GVQSE" || GV.Name == "GVRAVEL")
			{
				if (e.Column.AbsoluteIndex == 1)
				{
					new frmListeDemandesDash()
					{
						Client = client,
						Chaff = chaff,
						Compte = (int)compte,
						IdStat = (int)idstat
					}.ShowDialog();
				}
			}

			if (GV.Name == "GVOPE" || GV.Name == "GVFAC")
			{
				if (e.Column.AbsoluteIndex == 2)
				{
					new frmListeDemandesDash()
					{
						Client = client,
						Chaff = chaff,
						Compte = (int)compte,
						IdStat = (int)idstat
					}.ShowDialog();
				}
			}
		}

		private void Grid_MouseMove(object sender, MouseEventArgs e)
		{

			DevExpress.XtraGrid.Views.Grid.GridView GV = ((DevExpress.XtraGrid.Views.Grid.GridView)sender);
			DevExpress.XtraGrid.GridControl GC = GV.GridControl;

			var hitInfo = GV.CalcHitInfo(e.Location);
			if (hitInfo.InRowCell && hitInfo.Column.FieldName == "NB")
				GC.Cursor = Cursors.Hand; // Change le curseur en "main"
			else
				GC.Cursor = Cursors.Default; // Réinitialise le curseur
		}

		private void cmdQuitter_Click(object sender, EventArgs e)
		{
			Dispose();
		}

	}
}
