using Microsoft.VisualBasic;
using MozartCS.Properties;
using MozartLib;
using MozartNet;
using System;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.IO;
using System.Reflection;
using System.Windows.Forms;
using MZUtils = MozartControls.Utils;

namespace MozartCS
{
	public partial class frmListDocGeronimmo : Form
	{

		private DataTable dt = new DataTable();

		private Size wbSize;
		private Point wbLocation;

		private string CheminPJ;

		public frmListDocGeronimmo()
		{
			InitializeComponent();
		}

		private void frmListDocOTTech_Load(object sender, System.EventArgs e)
		{
			try
			{
				Cursor.Current = Cursors.WaitCursor;

				wbLocation = WebBrowser1.Location;
				wbSize = WebBrowser1.Size;

				ModuleMain.Initboutons(this);

				CheminPJ = Utils.RechercheParam("REP_PJ_ACT");

				//ouverture du recordset
				apigrid.LoadData(dt, MozartDatabase.cnxMozart, $"exec api_sp_ListeDocGeronimmo");
				apigrid.GridControl.DataSource = dt;

				Initapigrid();
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

		private void cmdSupprimer_Click(object sender, EventArgs e)
		{
			try
			{
				DataRow row = apigrid.GetFocusedDataRow();
				if (null == row) return;

				if (MessageBox.Show(Resources.msg_confirm_image_deletion, Program.AppTitle, MessageBoxButtons.YesNo,
													MessageBoxIcon.Question, MessageBoxDefaultButton.Button2) != DialogResult.Yes)
				{
					return;
				}

				ModuleData.ExecuteNonQuery($"UPDATE TGERONIMMO_PJ SET VFILESTATUT = 'SUPPRIMER' WHERE ID = {row["ID"]}");
				// Libérer le fichier PDF du webbrowser avant Delete
				WebBrowser wb = WebBrowser1.CloneControl();
				WebBrowser1.Dispose();
				WebBrowser1 = wb;
				WebBrowser1.Location = wbLocation;
				WebBrowser1.Size = wbSize;
				this.Controls.Add(WebBrowser1);
				WebBrowser1.BringToFront();

				File.Delete(CheminPJ + row["VNEWFILE"]);

				apigrid.Requery(dt, MozartDatabase.cnxMozart);

				Initapigrid();
			}
			catch (Exception ex)
			{
				MZUtils.displayError(MethodBase.GetCurrentMethod().Name, ex);
			}
		}

		private void CmdMax_Click(object sender, EventArgs e)
		{
			if (CmdMax.Text == Resources.txt_Maxi)
			{
				WebBrowser1.Width = this.Width - 120;
				WebBrowser1.Height = this.Height - 90;
				WebBrowser1.Top = apigrid.Top;
				WebBrowser1.Left = apigrid.Left;
				CmdMax.Text = Resources.txt_Mini;
			}
			else
			{
				WebBrowser1.Location = wbLocation;
				WebBrowser1.Size = wbSize;
				CmdMax.Text = Resources.txt_Maxi;
			}
		}

		private void cmdCopier_Click(object sender, EventArgs e)
		{
			DataRow row = apigrid.GetFocusedDataRow();
			if (null == row) return;

			if (Convert.ToInt32(row["NDINNUM"]) == 0)
				MessageBox.Show("Il faut créer la demande dans Mozart avant de pouvoir traiter le document", Program.AppTitle,
					MessageBoxButtons.OK, MessageBoxIcon.Information);


			if (MessageBox.Show("Vous confirmez le déplacement du fichier dans les documents client de l'action ?", Program.AppTitle, MessageBoxButtons.YesNo,
										MessageBoxIcon.Question, MessageBoxDefaultButton.Button2) != DialogResult.Yes)
			{
				return;
			}

			// enregistrement dans TIMAC et copie physique du fichier
			EnregDocument(row["VNEWFILE"].ToString(), row["VNOMFICHIERCLIENT"].ToString(), Convert.ToInt32(row["NACTNUM"]));

			// statut traité du document
			ModuleData.ExecuteNonQuery($"UPDATE TGERONIMMO_PJ SET VFILESTATUT = 'TRANSFERER' WHERE ID = {row["ID"]}");
		}

		private void Initapigrid()
		{
			try
			{
				if (apigrid.dgv.Columns.Count == 0)
				{
					apigrid.AddColumn("N° geronimmo", "VGERO_Number", 1200);
					apigrid.AddColumn("DI Emalec", "NDINNUM", 1400);
					apigrid.AddColumn(Resources.col_Fichier, "VNOMFICHIERCLIENT", 2000);
					apigrid.AddColumn("Date Fichier", "DDATECREA", 1500, "dd/MM/yyyy HH:mm");
					apigrid.AddColumn(Resources.col_Demandeur, "VGERO_SITE_CONTACT", 1400);
					apigrid.AddColumn("Remarques", "VGERO_NOTES", 2500);
					apigrid.AddColumn(Resources.col_Site, "VGERO_SITE_NOM", 2000);
					apigrid.AddColumn(Resources.col_Description, "VGERO_SITE_DESCRIPTION_DEMANDE", 5600);
					apigrid.AddColumn(Resources.col_Statut, "VGERO_STATE", 1200);
					apigrid.AddColumn("NACTNUM", "NACTNUM", 0);

					apigrid.DesactiveListe();
					apigrid.InitColumnList();
				}

				apigrid_ClickE(null, null);
			}
			catch (Exception ex)
			{
				MZUtils.displayError(MethodBase.GetCurrentMethod().Name, ex);
			}
		}

		private void apigrid_ClickE(object sender, EventArgs e)
		{
			WebBrowser1.Navigate("about:blank");
			DataRow row = apigrid.GetFocusedDataRow();
			if (null == row) return;

			WebBrowser1.Navigate(CheminPJ + row["VNEWFILE"].ToString());
		}

		private void EnregDocument(string strNomDoc, string strNomDocClient, int NACTNUM)
		{
			try
			{
				// Copie en doc interne de l'action
				// repertoire de destination
				string strRepDest = Utils.RechercheParam("REP_PHOTOS_ACT");

				int iCount = 0;
				// recherche du numéro d'image
				using (SqlCommand cmd = new SqlCommand("api_sp_GetCpt", MozartDatabase.cnxMozart))
				{
					cmd.CommandType = CommandType.StoredProcedure;
					SqlCommandBuilder.DeriveParameters(cmd);    // liste des paramètres

					//  liste des paramètres
					cmd.Parameters["@cElt"].Value = "IMGACT";
					cmd.Parameters["@iCpt"].Value = 0;
					cmd.ExecuteNonQuery();
					iCount = Convert.ToInt32(cmd.Parameters["@iCpt"].Value);
				}

				// nom et extension
				string textFic = $"{NACTNUM}_{iCount}_{strNomDoc}";
				string sExtension = Strings.Right(strNomDoc, 4);
				if (Strings.InStr(sExtension, ".") != 0) sExtension = Strings.Right(strNomDoc, 3);

				// enregistrement de l'image dans la table
				using (SqlCommand cmd = new SqlCommand("api_sp_EnregImgAct", MozartDatabase.cnxMozart))
				{
					cmd.CommandType = CommandType.StoredProcedure;
					SqlCommandBuilder.DeriveParameters(cmd);    // liste des paramètres

					//  liste des paramètres
					cmd.Parameters["@iNIMAGE"].Value = 0;
					cmd.Parameters["@iNACTNUM"].Value = NACTNUM;
					cmd.Parameters["@vVIMAGE"].Value = "Piece Jointe client";
					cmd.Parameters["@vVFICHIER"].Value = textFic.Trim();
					cmd.Parameters["@cCFORMAT"].Value = sExtension;
					cmd.Parameters["@vVCOMMENT"].Value = strNomDocClient;
					cmd.Parameters["@vVTYPE"].Value = "PJW";
					cmd.Parameters["@vWEB"].Value = "O";
					cmd.Parameters["@vTypeDest"].Value = "C";
					cmd.Parameters["@nTypeDoc"].Value = 21;
					cmd.ExecuteNonQuery();
				}

				// mouve du fichier 
				File.Move(CheminPJ + strNomDoc, strRepDest + textFic);

				apigrid.Requery(dt, MozartDatabase.cnxMozart);

				Initapigrid();

			}
			catch (Exception ex)
			{
				MZUtils.displayError(MethodBase.GetCurrentMethod().Name, ex);
			}
		}

		private void cmdQuitter_Click(object sender, EventArgs e)
		{
			Dispose();
		}


	}
}