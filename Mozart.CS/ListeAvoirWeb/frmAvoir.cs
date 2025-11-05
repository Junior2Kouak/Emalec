using MZCtrlResources = MozartControls.Properties.Resources;
using Microsoft.VisualBasic;
using MozartCS.Properties;
using MozartLib;
using MozartNet;
using ReportEmalec.Net;
using System;
using System.Data;
using System.Data.SqlClient;
using System.Globalization;
using System.Reflection;
using System.Text.RegularExpressions;
using System.Windows.Forms;
using MZUtils = MozartControls.Utils;

namespace MozartCS
{
	public partial class frmAvoir : Form
	{
		public frmAvoir() { InitializeComponent(); }

		public string mstrStatutAvoir;
		public string mstrStatutTransfert;
		public long miNumAvoir;
		public long miNumFacture;
		public long miNumRaisSoc;
		public long miNumClient;

		private string strTypeAvoir = "Standard";

		double mdecTva;
		DataTable dtFact = new DataTable();

		private void frmAvoir_Load(object sender, System.EventArgs e)
		{
			try
			{
				Cursor.Current = Cursors.WaitCursor;
				ModuleMain.Initboutons(this);

				InitRecordsetArticle();

				if (mstrStatutAvoir == "C")
					OuvertureEnCreation();
				else
					OuvertureEnModification();

				// pas de modification possible si déjà transféré en compta
				if (mstrStatutTransfert == "OUI") cmdValider.Enabled = false;

				InitialiserFeuille();

				Cursor.Current = Cursors.Default;
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


		private void cmdValider_Click(object sender, EventArgs e)
		{
			try
			{
				DataRow currentRow = grdDataGrid.GetFocusedDataRow();
				if (currentRow == null)
				{
					MessageBox.Show(Resources.msg_Must_select_line);
					return;
				}

				// cas de la modification ou de la création
				// si modification, il faut au préalable supprimer les actions, les elfs et l'avoir
				// pouvant exister sur cet avoir
				if (mstrStatutAvoir == "M" && strTypeAvoir == "Standard")
				{
					// suppression des actions et du reste
					ModuleData.ExecuteNonQuery("api_sp_SuppActionsDeAvoir " + miNumAvoir);
				}

				//  parcours du datagrid et recherche des lignes non vides
				foreach (DataRow row in dtFact.Rows)
				{
					if (Utils.ZeroIfNull(row["AVOIRHT"]) != 0 && row["AVOIRHT"] != null)
						EnregistrerAvoir(Convert.ToInt64(row["NELFNUM"]), row["VDES"].ToString(), Convert.ToDouble(row["AVOIRHT"]));
				}
				//  ' on passe la feuille en statut modifier
				mstrStatutAvoir = "M";

				//  ' rafraichissement de l'affichage
				OuvertureEnModification();

				optFact0_Click(null, null);
			}
			catch (Exception ex)
			{
				MZUtils.displayError(MethodBase.GetCurrentMethod().Name, ex);
			}
		}

		private void cmdVisualiser_Click(object sender, EventArgs e)
		{
			try
			{
				if (miNumAvoir == 0)
				{
					MessageBox.Show(Resources.msg_Impr_Impossible_save_avoir, Program.AppTitle, MessageBoxButtons.OK, MessageBoxIcon.Information);
					return;
				}
				else
				{

					new frmMainReport
					{
						bLaunchByProcessStart = false,
						sTypeReport = PrepareReport.TAVOIRCLIENT,
						sIdentifiant = miNumAvoir.ToString(),
						InfosMail = "TCLI|NCLINUM|" + miNumClient,
						sNomSociete = MozartParams.NomSociete,
						sLangue = Strings.Left(ModuleMain.CodePays(ModuleMain.GetPays("TRSF", "VRSFPAYS", "NRSFNUM", miNumRaisSoc.ToString())), 2),
						sOption = "PREVIEW"
					}.ShowDialog();
				}
			}
			catch (Exception ex)
			{
				MZUtils.displayError(MethodBase.GetCurrentMethod().Name, ex);
			}
		}

		private void OuvertureEnCreation()
		{
			try
			{
				//  recherche des info de l'avoir
				string sSQL = "api_sp_RetourInfoFacture " + miNumFacture;

				//  les infos de la feuille
				using (SqlDataReader dr = ModuleData.ExecuteReader(sSQL))
				{
					// lier les textbox avec le recordset
					if (dr.Read())
					{
						txtFields0.Text = Utils.BlankIfNull(dr["VCLINOM"]);
						txtFields1.Text = Utils.BlankIfNull(dr["NFACNUM"]);
						txtFields2.Text = Strings.Format(Utils.ZeroIfNull(dr["NTHT"]).ToString(), "currency");
						txtFields3.Text = Utils.DateBlankIfNull(dr["DFACDAT"].ToString());
						txtFields4.Text = Utils.ZeroIfNull(dr["NDINCTE"]).ToString();
						txtFields5.Text = Utils.ZeroIfNull(dr["NAVNUM"]).ToString();
						txtFields6.Text = Utils.DateBlankIfNull(dr["DFACDATAV"]);
						txtFields7.Text = Utils.BlankIfNull(dr["VRSFRSF"]).ToString();

						//  taux de tva du client (pris sur la di)
						mdecTva = Utils.ZeroIfNull(dr["NELFTVA"]);

						//  raison sociale
						miNumRaisSoc = (long)Utils.ZeroIfNull(dr["NRSFNUM"]);

						txtObjet.Text = $"{Resources.txt_Avoir_sur_facture_num}{dr["NFACNUM"]}{Resources.txt_du}{Convert.ToDateTime(dr["DFACDAT"]).ToShortDateString()}";
						txtPrest.Text = "";
					}
				}
			}
			catch (Exception ex)
			{
				MZUtils.displayError(MethodBase.GetCurrentMethod().Name, ex);
			}
		}

		private void OuvertureEnModification()
		{
			try
			{
				// recherche des info de l'avoir
				string sSQL = "api_sp_RetourInfoAvoir " + miNumAvoir;
				using (SqlDataReader dr = ModuleData.ExecuteReader(sSQL))
				{
					// lier les textbox avec le recordset
					if (dr.Read())
					{
						txtFields0.Text = Utils.BlankIfNull(dr["VCLINOM"]);
						txtFields1.Text = Utils.BlankIfNull(dr["NFACNUM"]);
						txtFields2.Text = Strings.Format(Utils.ZeroIfNull(dr["NTHT"]).ToString(), "currency");
						txtFields3.Text = Utils.DateBlankIfNull(dr["DFACDAT"].ToString());
						txtFields4.Text = Utils.ZeroIfNull(dr["NDINCTE"]).ToString();
						txtFields5.Text = Utils.BlankIfNull(dr["NAVNUM"]).ToString();
						txtFields6.Text = Utils.DateBlankIfNull(dr["DFACDATAV"]);
						txtFields7.Text = Utils.BlankIfNull(dr["VRSFRSF"]);

						//  ' taux de tva du client (pris sur la facture)
						mdecTva = Utils.ZeroIfNull(dr["NELFTVA"].ToString());

						//  ' NumFact, raison sociale, NumElf
						miNumRaisSoc = (long)Utils.ZeroIfNull(dr["NRSFNUM"]);
						miNumFacture = (long)Utils.ZeroIfNull(dr["NFACNUMFACAV"]);

						// recherche si Avoir Standard ou Alone
						if ((Int32)dr["NFACNUMFACAV"] == miNumAvoir)
						{
							strTypeAvoir = "Alone"; 
							optFact0.Visible = optFact1.Visible = lblLabels4.Visible = false;
						}
							

						if (dr["VFACLIBAV"] == null)
							txtObjet.Text = "";
						else
							txtObjet.Text = dr["VFACOBJAV"].ToString();
//						txtObjet.Text = ModuleMain.ReplaceCharFromBD(dr["VFACOBJAV"].ToString(), "RTF");

						if (dr["VFACLIBAV"] == null)
							txtPrest.Text = "";
						else
							txtPrest.Text = dr["VFACLIBAV"].ToString();
//						txtPrest.Text = ModuleMain.ReplaceCharFromBD(dr["VFACLIBAV"].ToString(), "RTF");
					}
				}

			}
			catch (Exception ex)
			{
				MZUtils.displayError(MethodBase.GetCurrentMethod().Name, ex);
			}
		}

		private void EnregistrerAvoir(long iNumELF, string sAction, double vValeur)
		{
			try
			{
				// avoir standard (en lien avec une facture existante)
				if (strTypeAvoir == "Standard")

					using (SqlCommand cmd = new SqlCommand("api_sp_CreationAvoir", MozartDatabase.cnxMozart))
					{
						cmd.CommandType = CommandType.StoredProcedure;
						SqlCommandBuilder.DeriveParameters(cmd);

						cmd.Parameters["@iNumAvoir"].Value = miNumAvoir;
						cmd.Parameters["@iNumFacture"].Value = miNumFacture;
						cmd.Parameters["@iNumELF"].Value = iNumELF;
						cmd.Parameters["@iNumRaisSoc"].Value = miNumRaisSoc;
						cmd.Parameters["@dDate"].Value = DateTime.Now.ToShortDateString();
						cmd.Parameters["@tObj"].Value = txtObjet.Text;
						cmd.Parameters["@tLib"].Value = txtPrest.Text;
//						cmd.Parameters["@tObj"].Value = ModuleMain.ReplaceCharFromBD(txtObjet.Text, "RTF");
//						cmd.Parameters["@tLib"].Value = ModuleMain.ReplaceCharFromBD(txtPrest.Text, "RTF");
						cmd.Parameters["@nTHT"].Value = vValeur;
						cmd.Parameters["@action"].Value = Strings.Left(sAction, 7985);
						cmd.Parameters["@nTFACHT"].Value = Double.Parse(Regex.Match(txtHT.Text, @"\d+").Value);

						cmd.ExecuteNonQuery();
						miNumAvoir = Convert.ToInt64(cmd.Parameters[0].Value);
					}

				else
					// avoir autonome (sans aucun lien avec une facture existante)
					using (SqlCommand cmd = new SqlCommand("api_sp_CreationAvoirAlone", MozartDatabase.cnxMozart))
					{
						cmd.CommandType = CommandType.StoredProcedure;
						SqlCommandBuilder.DeriveParameters(cmd);

						cmd.Parameters["@iNumAvoir"].Value = miNumAvoir;
						cmd.Parameters["@iNumELF"].Value = iNumELF;
						cmd.Parameters["@tObj"].Value = txtObjet.Text;
						cmd.Parameters["@tLib"].Value = txtPrest.Text;
						cmd.Parameters["@nTHT"].Value = vValeur;

						cmd.ExecuteNonQuery();
					}

			}
			catch (Exception ex)
			{
				MZUtils.displayError(MethodBase.GetCurrentMethod().Name, ex);
			}
		}

		private void InitialiserFeuille()
		{
			try
			{
				string sSQL;
				if (mstrStatutAvoir == "M")
					//  recherche des éléments de facturation de l' avoir
					sSQL = "exec api_sp_listeElemFact 0, " + miNumAvoir;
				else
					//  recherche des éléments de facturation de la facture selectionnée
					sSQL = "exec api_sp_listeElemFact " + miNumFacture + ", 0";

				//grdDataGrid.LoadData(dtFact, MozartDatabase.cnxMozart, sSQL);

				using (SqlDataReader dr = ModuleData.ExecuteReader(sSQL))
				{
					while (dr.Read())
						AjouterEnreg(dr);
				}
				grdDataGrid.GridControl.DataSource = dtFact;

				FormatGrid();
				RemplirTxtTotaux();
				Cursor.Current = Cursors.Default;


			}
			catch (Exception ex)
			{
				MZUtils.displayError(MethodBase.GetCurrentMethod().Name, ex);
			}
		}

		private void optFact0_Click(object sender, EventArgs e)
		{
			//    ' mise en page du tableau
			grdDataGrid.dgv.ActiveFilterString = "";
		}

		private void optFact1_Click(object sender, EventArgs e)
		{
			grdDataGrid.dgv.ActiveFilterString = "AVOIRHT <> 0";
		}

		private void InitRecordsetArticle()
		{
			dtFact.Columns.Add("NDINNUM", typeof(string));
			dtFact.Columns.Add("DELFDPR", typeof(DateTime));
			dtFact.Columns.Add("VCLINOM", typeof(string));
			dtFact.Columns.Add("VSITNOM", typeof(string));
			dtFact.Columns.Add("VDES", typeof(string));
			dtFact.Columns.Add("VDINREFCLI", typeof(string));
			dtFact.Columns.Add("MO", typeof(string));
			dtFact.Columns.Add("NELFFOU", typeof(string));
			dtFact.Columns.Add("DEP", typeof(string));
			dtFact.Columns.Add("Total", typeof(double));
			dtFact.Columns.Add("AVOIRHT", typeof(double));
			dtFact.Columns.Add("NELFNUM", typeof(int));
			dtFact.Columns.Add("NCLINUM", typeof(int));
			dtFact.Columns.Add("NSITNUM", typeof(int));
		}

		private void FormatGrid()
		{
			grdDataGrid.AddColumn("DI", "NDINNUM", 600);
			grdDataGrid.AddColumn(Resources.col_Date, "DELFDPR", 800);
			grdDataGrid.AddColumn(MZCtrlResources.col_Client, "VCLINOM", 1200);
			grdDataGrid.AddColumn(Resources.col_Site, "VSITNOM", 1400);
			grdDataGrid.AddColumn(Resources.col_Action, "VDES", 4000);
			grdDataGrid.AddColumn("Ref", "VDINREFCLI", 1500);
			grdDataGrid.AddColumn("MO", "MO", 600);
			grdDataGrid.AddColumn("Fou", "NELFFOU", 600);
			grdDataGrid.AddColumn("Dep", "DEP", 600);
			grdDataGrid.AddColumn("Tot", "Total", 600, "0.00");
			grdDataGrid.AddColumn(Resources.col_Avoir, "AVOIRHT", 700, "0.00");
			grdDataGrid.AddColumn("NumElf", "NELFNUM", 0);
			grdDataGrid.AddColumn("NumCli", "NCLINUM", 0);
			grdDataGrid.AddColumn("NumSite", "NSITNUM", 0);

			grdDataGrid.DelockColumn("AVOIRHT");

			grdDataGrid.InitColumnList();
		}

		private void AjouterEnreg(SqlDataReader dr)
		{
			DataRow newrow = dtFact.NewRow();
			newrow["NDINNUM"] = dr["NDINNUM"];
			newrow["DELFDPR"] = dr["DELFDPR"];
			newrow["VCLINOM"] = Utils.BlankIfNull(dr["VCLINOM"]);
			newrow["VSITNOM"] = Utils.BlankIfNull(dr["VSITNOM"]);
			newrow["VDES"] = Utils.BlankIfNull(dr["VDES"]);
			newrow["VDINREFCLI"] = Utils.BlankIfNull(dr["VDINREFCLI"]);
			newrow["MO"] = Utils.ZeroIfNull(dr["MO"]);
			newrow["NELFFOU"] = Utils.ZeroIfNull(dr["NELFFOU"]);
			newrow["DEP"] = Utils.ZeroIfNull(dr["DEP"]);
			newrow["Total"] = Utils.ZeroIfNull(dr["Total"]);
			newrow["AVOIRHT"] = Utils.ZeroIfBlank(dr["AVOIRHT"]);
			newrow["NELFNUM"] = dr["NELFNUM"];
			newrow["NCLINUM"] = dr["NCLINUM"];
			newrow["NSITNUM"] = dr["NSITNUM"];
			dtFact.Rows.Add(newrow);
		}


		private void grdDataGrid_CellValueChanged(object sender, DevExpress.XtraGrid.Views.Base.CellValueChangedEventArgs e)
		{
			//int ColIndex = e.Column.ColumnHandle;
			DataRow currentRow = grdDataGrid.GetFocusedDataRow();
			if (currentRow["AVOIRHT"] == DBNull.Value)
				return;

			if (Convert.ToDouble(currentRow["AVOIRHT"]) > 0)
				currentRow["AVOIRHT"] = Convert.ToDouble(currentRow["AVOIRHT"]) * -1;

			RemplirTxtTotaux();
		}

		private void grdDataGrid_EditorKeyPressE(object sender, KeyPressEventArgs e)
		{
			try
			{
				DataRow currentRow = grdDataGrid.GetFocusedDataRow();
				if (currentRow["AVOIRHT"] == DBNull.Value)
					return;

				if (strTypeAvoir == "Alone") return;

				if (e.KeyChar == 84 || e.KeyChar == 116) //touche 'T' ou 't' égal total
				{
					e.Handled = true;

					currentRow["AVOIRHT"] = Convert.ToDouble(currentRow["TOTAL"]) * -1;

					RemplirTxtTotaux();
				}
			}
			catch (Exception ex)
			{
				MZUtils.displayError(MethodBase.GetCurrentMethod().Name, ex);
			}
		}

		private double CalculerMontantHT(DataTable dt)
		{
			try
			{
				if (dt == null) return 0;

				//  initialisation
				double res = 0;
				//  parcours du recordset
				foreach (DataRow row in dt.Rows)
				{
					res += Utils.ZeroIfNull(row["AVOIRHT"]);
				}
				return res;
			}
			catch (Exception ex)
			{
				MZUtils.displayError(MethodBase.GetCurrentMethod().Name, ex);
				return 0;
			}
		}

		private void RemplirTxtTotaux()
		{
			try
			{
				txtHT.Text = CalculerMontantHT(dtFact).ToString();
				txtHT.TextAlign = HorizontalAlignment.Left;

				txtTVA.Text = Convert.ToString(double.Parse(txtHT.Text, NumberStyles.Currency) * mdecTva / 100);
				txtTVA.TextAlign = HorizontalAlignment.Left;

				txtTTC.Text = Convert.ToString(double.Parse(txtHT.Text, NumberStyles.Currency) + (double.Parse(txtHT.Text, NumberStyles.Currency) * mdecTva / 100));
				txtTTC.TextAlign = HorizontalAlignment.Left;
			}
			catch (Exception ex)
			{
				MZUtils.displayError(MethodBase.GetCurrentMethod().Name, ex);
			}
		}

		private void frmAvoir_FormClosed(object sender, FormClosedEventArgs e)
		{
			Cursor.Current = Cursors.Default;
		}

		private void cmdFermer_Click(object sender, System.EventArgs e)
		{
			Dispose();
		}

	}
}