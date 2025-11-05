using MozartCS.Properties;
using MozartLib;
using MozartNet;
using System;
using System.Data;
using System.Reflection;
using System.Windows.Forms;
using MZUtils = MozartControls.Utils;

namespace MozartCS
{
	public partial class frmDiGeronimmo : Form
	{
		DataTable dtNew = new DataTable();
		DataTable dtEnCours = new DataTable();

		public frmDiGeronimmo() { InitializeComponent(); }

		private void frmDiKimoce_Load(object sender, System.EventArgs e)
		{
			try
			{
				Cursor.Current = Cursors.WaitCursor;
				ModuleMain.Initboutons(this);

				// gestion des couleurs boutons
				int nbPJ = (int)MozartDatabase.ExecuteScalarInt($"SELECT COUNT(ID) FROM TGERONIMMO_PJ WHERE VFILESTATUT = 'Attente'");
				cmdDocuments.BackColor = nbPJ > 0 ? MozartColors.ColorFF00000 : MozartColors.ColorH8000000F;

				int nbNotes = (int)MozartDatabase.ExecuteScalarInt($"SELECT COUNT(ID) FROM TGERONIMMO_NOTE WHERE VSTATUT = 'A'");
				cmdNotes.BackColor = nbNotes > 0 ? MozartColors.ColorFF00000 : MozartColors.ColorH8000000F;

				apiTGridHaut.LoadData(dtNew, MozartDatabase.cnxMozart, "exec api_sp_listeDIGeronimmoNew");
				apiTGridHaut.GridControl.DataSource = dtNew;
				InitApiTgridHaut();

				apiTGridBas.LoadData(dtEnCours, MozartDatabase.cnxMozart, "exec api_sp_listeDIGeronimmoEnCours");
				apiTGridBas.GridControl.DataSource = dtEnCours;
				InitApiTgridBas();
				Cursor.Current = Cursors.Default;
			}
			catch (Exception ex)
			{
				MZUtils.displayError(MethodBase.GetCurrentMethod().Name, ex);
			}
			finally { Cursor.Current = Cursors.Default; }
		}

		private void cmdCreerDi_Click(object sender, EventArgs e)
		{
			DataRow row = apiTGridHaut.GetFocusedDataRow();
			if (row == null) return;

			MozartParams.NumDi = 0;

			//  Recherche de correspondance du site
			int NumSite = GetNumSite(Convert.ToInt32(row["NCLINUM"]), row["VGERO_SITE_CODE"].ToString());
			if (NumSite == 0) return;

			//  Test si la DI est déjà prise
			if (DiBloquee(row))
			{
				MessageBox.Show("§Cette DI est en cours de traitement§", Program.AppTitle, MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
				return;
			}
			else // on la bloque
				MozartDatabase.ExecuteNonQuery($"UPDATE TDIGERONIMMO set CDILOCK = 'O' where VGERO_Number = '{row["VGERO_Number"]}'");


			Cursor.Current = Cursors.WaitCursor;
			frmAddAction f = new frmAddAction();
			f.mstrStatutDI = "GERONIMMO";
			f.miNumClient = Convert.ToInt32(row["NCLINUM"]);
			f.miNumSite = NumSite;
			f.mstrRefCli = " DI SUN IMMO : " + row["VGERO_Number"].ToString();
			f.miNumContrat = 0;
			f.msNumDIGeronimmo = row["VGERO_Number"].ToString();
			f.mTypeDemandeGDM = "Maintenance";
			MozartParams.Action = $"{Utils.BlankIfNull(row["VGERO_Equipement"])}\r\n{Utils.BlankIfNull(row["VGERO_SITE_DESCRIPTION_DEMANDE"])}";
			MozartParams.DateAction = "";

			f.ShowDialog();

			MozartParams.Action = "";
			MozartParams.DateAction = "";

			//  Test si la DI est créée, on la debloque
			if (!DiTraitee(row))
				MozartDatabase.ExecuteNonQuery($"UPDATE TDIGERONIMMO set CDILOCK = 'N' where VGERO_Number = '{row["VGERO_Number"]}'");

			//  Rafraichissement
			apiTGridHaut.Requery(dtNew, MozartDatabase.cnxMozart);
			apiTGridBas.Requery(dtEnCours, MozartDatabase.cnxMozart);
			Cursor.Current = Cursors.Default;
		}

		private void cmdDetailDi_Click(object sender, EventArgs e)
		{
			DataRow row = apiTGridBas.GetFocusedDataRow();
			if (row == null) return;
			Cursor.Current = Cursors.WaitCursor;

			Cursor.Current = Cursors.WaitCursor;
			frmAddAction f = new frmAddAction();
			f.mstrStatutDI = "SuiviGERONIMMO";
			MozartParams.NumAction = Convert.ToInt32(row["NACTNUM"]);
			MozartParams.NumDi = Convert.ToInt32(row["NDINNUM"]);
			f.ShowDialog();
			Cursor.Current = Cursors.Default;
		}

		private int GetNumSite(int NCLINUM, string CodeSiteClient)
		{// utilisation du code SAP sur le site
			//      int NSITNUM = (int)MozartDatabase.ExecuteScalarInt($"select NSITNUM from TSIT where CSITACTIF = 'O' AND NCLINUM = {NCLINUM} and NSITNUE = '{nsitnue}'");
			int NSITNUM = (int)MozartDatabase.ExecuteScalarInt($"select NSITNUM from TSIT where CSITACTIF = 'O' AND NCLINUM = {NCLINUM} and VCODIMPL = left('{CodeSiteClient}', 5)");

			if (NSITNUM == 0)
				MessageBox.Show($"Le site codifié '{CodeSiteClient}' n'a pas été trouvé.", Program.AppTitle, MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
			return NSITNUM;
		}

		private bool DiBloquee(DataRow row)
		{
			return MozartDatabase.ExecuteScalarString($"select CDILOCK from TDIGERONIMMO where VGERO_Number = '{row["VGERO_Number"]}'") == "N" ? false : true;
		}

		private bool DiTraitee(DataRow row)
		{
			return MozartDatabase.ExecuteScalarInt($"select IsNull(NACTNUM, 0) from TDIGERONIMMO where VGERO_Number = '{row["VGERO_Number"]}'") == 0 ? false : true;
		}

		private void InitApiTgridHaut()
		{
			apiTGridHaut.AddColumn("N° geronimmo", "VGERO_Number", 1200);
			apiTGridHaut.AddColumn("Date Demande", "DGERO_SysCreatedOn", 1200, "dd/MM/yyyy HH:mm");
			apiTGridHaut.AddColumn("Statut", "VGERO_STATE", 1200);
			apiTGridHaut.AddColumn("Équipement", "VGERO_Equipement", 1400);
			apiTGridHaut.AddColumn("Demandeur", "VGERO_SITE_CONTACT", 1400);
			apiTGridHaut.AddColumn("remarques", "VGERO_NOTES", 2500);
			apiTGridHaut.AddColumn("Site", "VGERO_SITE_NOM", 1500);
			apiTGridHaut.AddColumn("Site EMALEC", "VSITNOM", 1500);
			apiTGridHaut.AddColumn("Code Site", "VGERO_SITE_CODE", 1200);
			apiTGridHaut.AddColumn("Description", "VGERO_SITE_DESCRIPTION_DEMANDE", 5600);
			apiTGridHaut.AddColumn("NACTNUM", "NACTNUM", 0);

			apiTGridHaut.InitColumnList();
		}

		private void InitApiTgridBas()
		{
			apiTGridBas.AddColumn("N° geronimmo", "VGERO_Number", 1200);
			apiTGridBas.AddColumn("DI Emalec", "NDINNUM", 1400);
			apiTGridBas.AddColumn("Date Demande", "DGERO_SysCreatedOn", 1200, "dd/MM/yyyy HH:mm");
			apiTGridBas.AddColumn("Statut", "VGERO_STATE", 1200);
			apiTGridBas.AddColumn("Demandeur", "VGERO_SITE_CONTACT", 1400);
			apiTGridBas.AddColumn("remarques", "VGERO_NOTES", 2500);
			apiTGridBas.AddColumn("Équipement", "VGERO_Equipement", 0);
			apiTGridBas.AddColumn("Site", "VSITNOM", 2400);
			apiTGridBas.AddColumn("Description", "VGERO_SITE_DESCRIPTION_DEMANDE", 5600);
			apiTGridBas.AddColumn("NACTNUM", "NACTNUM", 0);

			apiTGridBas.InitColumnList();
		}

		private void btnArchiverNew_Click(object sender, EventArgs e)
		{
			DataRow row = apiTGridHaut.GetFocusedDataRow();
			if (null == row) return;

			if (MessageBox.Show(Resources.msg_confirm_archive_demande, Program.AppTitle, MessageBoxButtons.YesNo, MessageBoxIcon.Question, MessageBoxDefaultButton.Button2) != DialogResult.Yes) return;

			MozartDatabase.ExecuteNonQuery($"Update TDIGERONIMMO Set VSTATUT = 'S' where VGERO_Number = '{row["VGERO_Number"]}'");

			Cursor.Current = Cursors.WaitCursor;
			apiTGridHaut.Requery(dtNew, MozartDatabase.cnxMozart);
			Cursor.Current = Cursors.Default;

		}

		private void btnArchiverEnCours_Click(object sender, EventArgs e)
		{
			DataRow row = apiTGridBas.GetFocusedDataRow();
			if (null == row) return;

			if (MessageBox.Show(Resources.msg_confirm_archive_demande, Program.AppTitle, MessageBoxButtons.YesNo, MessageBoxIcon.Question, MessageBoxDefaultButton.Button2) != DialogResult.Yes) return;

			MozartDatabase.ExecuteNonQuery($"Update TDIGERONIMMO Set VSTATUT = 'S' where VGERO_Number = '{row["VGERO_Number"]}'");

			Cursor.Current = Cursors.WaitCursor;
			apiTGridBas.Requery(dtNew, MozartDatabase.cnxMozart);
			Cursor.Current = Cursors.Default;

		}


		private void cmdDocuments_Click(object sender, EventArgs e)
		{
			Cursor.Current = Cursors.WaitCursor;
			frmListDocGeronimmo f = new frmListDocGeronimmo();
			f.ShowDialog();
			Cursor.Current = Cursors.Default;
		}


		private void cmdNotes_Click(object sender, EventArgs e)
		{
			Cursor.Current = Cursors.WaitCursor;
			frmGestNotes f = new frmGestNotes();
			f.ShowDialog();
			Cursor.Current = Cursors.Default;
		}

		private void cmdQuitter_Click(object sender, System.EventArgs e)
		{
			Dispose();
		}
	}
}