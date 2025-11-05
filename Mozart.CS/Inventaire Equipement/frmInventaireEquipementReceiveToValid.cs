using DevExpress.CodeParser;
using DevExpress.PivotGrid.DataBinding;
using DevExpress.Utils;
using DevExpress.Xpo.Exceptions;
using DevExpress.XtraEditors;
using DevExpress.XtraEditors.Controls;
using DevExpress.XtraEditors.Repository;
using DevExpress.XtraPivotGrid;
using DevExpress.XtraScheduler;
using MozartLib;
using MozartNet;
using MozartUC;
using System;
using System.Collections;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Diagnostics;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Reflection;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static DevExpress.Skins.SolidColorHelper;
using MZUtils = MozartControls.Utils;

namespace MozartCS.Inventaire_Equipement
{
	public partial class frmInventaireEquipementReceiveToValid : Form
	{

		public int nactinvid = 0;

		private bool IsReadOnly;
		private List<Int32> lstTextEdit = new List<Int32>() { 1, 2, 3, 4, 9 };
		private List<Int32> lstCboEdit = new List<Int32>() { 5, 10, 11 };

		DataTable dt = new DataTable();
		DataTable dtDetails = new DataTable();
		public frmInventaireEquipementReceiveToValid()
		{
			InitializeComponent();
		}

		private void frmInventaireEquipementReceiveToValid_Load(object sender, EventArgs e)
		{
			try
			{
				Cursor.Current = Cursors.WaitCursor;
				ModuleMain.Initboutons(this);

				if (nactinvid == 0) { return; }
				GestionReadOnly();

				//ModuleData.LoadData(dt, $"EXEC [api_sp_InvEquip_DetailsListeContratEquipement] {nactinvid}");
				dt = MozartDatabase.GetDataTable($"EXEC [api_sp_InvEquip_DetailsListeContratEquipement] {nactinvid}");

				GCContratEquipement.DataSource = dt;

			}
			catch (Exception ex)
			{
				MZUtils.displayError(MethodBase.GetCurrentMethod().Name, ex);
			}
			finally { Cursor.Current = Cursors.Default; }
		}

		private void GVContratEquipement_RowCellClick(object sender, DevExpress.XtraGrid.Views.Grid.RowCellClickEventArgs e)
		{
			LoadDataPVT();
		}

		private void GestionReadOnly()
		{
			if (IsInventaireTraite(nactinvid))
			{
				BtnValiderInventaire.Visible = false;
				IsReadOnly = true;
				LblTitre.Text = "Inventaire - Etat : validé";
			}
			else
			{
				BtnValiderInventaire.Visible = true;
				IsReadOnly = false;
				LblTitre.Text = "Inventaire - Etat : en attente de validation";
			}
		}

		private bool IsInventaireTraite(int nact_inv_id)
		{
			int ret = MozartDatabase.ExecuteScalarInt($"EXEC [api_sp_InvEquip_IsInventaireTraite] {nact_inv_id}");
			if (ret > 0) return true;
			return false;
		}

		private void LoadDataPVT()
		{
			//test s il y a eu des équipements coché précédemment
			//si oui, on demande par message s'il faut save

			// FGA cela ne fonctionne pas, je passe en commentaire
			//if (dtDetails != null && dtDetails.GetChanges(DataRowState.Modified)!= null && dtDetails.GetChanges(DataRowState.Modified).Rows.Count > 0)
			//{
			//    switch (MessageBox.Show("Vous avez validé des équipements sans les enregistrer, voulez-vous les enregistrer ?", "Confirmation", MessageBoxButtons.YesNoCancel, MessageBoxIcon.Question))                    
			//    {
			//        case DialogResult.Yes:
			//            saveEquipements();
			//            break;

			//        case DialogResult.No:
			//            break;

			//        case DialogResult.Cancel:
			//            return;
			//            break;
			//    }
			//}


			DataRow row = GVContratEquipement.GetFocusedDataRow();
			if (row == null) return;

			GestionReadOnly();

			ModuleData.LoadData(dtDetails, $"EXEC [api_sp_InvEquip_DetailsAValider] {nactinvid},{row["NTYPECONTRAT"]}, {row["NIDEQUIPEMENT"]}, {row["NID_EQUIPEMENT_FICHE"]}");

			for (int i = 0; i < dtDetails.Columns.Count;)
			{
				dtDetails.Columns[i].ReadOnly = IsReadOnly;
				i = i + 1;
			}

			PVTG_Details.DataSource = dtDetails;

			PVTG_Details.BestFit();
		}

		private void PVTG_Details_CustomCellEdit(object sender, PivotCustomCellEditEventArgs e)
		{

			// Determine the cell type or conditions
			if (e.DataField.ToString() == "OVALUE" && e.RowValueType == PivotGridValueType.Value)
			{
				int NID_EQUIPEMENT_FICHE_TYPE_CHAMP = 0;
				int NID_EQUIPEMENT_FICHE_LIST_PARENT = 0;

				PivotDrillDownDataSource ds = e.CreateDrillDownDataSource();

				if (ds[0] == null) return;

				NID_EQUIPEMENT_FICHE_TYPE_CHAMP = (int)ds[0]["NID_EQUIPEMENT_FICHE_TYPE_CHAMP"];
				NID_EQUIPEMENT_FICHE_LIST_PARENT = ds[0]["NID_EQUIPEMENT_FICHE_LIST_PARENT"] == null ? 0 : (int)ds[0]["NID_EQUIPEMENT_FICHE_LIST_PARENT"];

				//Console.WriteLine($"{ds[0]["VEQUIPEMENT_FICHE_ITEM_LIB"]} - {NID_EQUIPEMENT_FICHE_TYPE_CHAMP.ToString()}");

				//photo
				if (NID_EQUIPEMENT_FICHE_TYPE_CHAMP == 7 | NID_EQUIPEMENT_FICHE_TYPE_CHAMP == 8)
				{
					e.RepositoryItem = repositoryItemHyperLinkEdit1;
					return;
				}
				//champ texte
				//if (lstTextEdit.Contains(NID_EQUIPEMENT_FICHE_TYPE_CHAMP))
				//{

				//    switch (NID_EQUIPEMENT_FICHE_TYPE_CHAMP)
				//    {
				//        case 1:
				//            repositoryItemTextEdit1.EditFormat.FormatType = FormatType.None;
				//            e.RepositoryItem = repositoryItemTextEdit1;
				//            break;
				//        case 2:
				//            repositoryItemTextEdit1.EditFormat.FormatType = FormatType.Numeric;
				//            e.RepositoryItem = repositoryItemTextEdit1;
				//            break;
				//        case 3:
				//            repositoryItemDateEdit1.EditFormat.FormatType = FormatType.DateTime;
				//            e.RepositoryItem = repositoryItemDateEdit1;
				//            break;
				//        case 4:
				//            e.RepositoryItem = repositoryItemRichTextEdit1;
				//            break;
				//        default:
				//            break;
				//    }
				//    return;
				//}
				//combo
				if (lstCboEdit.Contains(NID_EQUIPEMENT_FICHE_TYPE_CHAMP))
				{
					//e.RepositoryItem = repositoryItemComboBox1;
					return;
				}
                //texte mutli-lignes
                if (NID_EQUIPEMENT_FICHE_TYPE_CHAMP == 4)
                {
                    e.RepositoryItem = repositoryItemRichTextEdit1;
                    return;
                }


                //checkbox
                if (NID_EQUIPEMENT_FICHE_TYPE_CHAMP == 6)
				{
					e.RepositoryItem = repositoryItemCheckEdit1;
					return;
				}
				//checkbox
				if (NID_EQUIPEMENT_FICHE_TYPE_CHAMP == -1)
				{
					e.RepositoryItem = repositoryItemCheckEdit2;
					return;
				}
				//checkbox
				if (NID_EQUIPEMENT_FICHE_TYPE_CHAMP == -2)
				{
					e.RepositoryItem = repositoryItemCheckEdit2;
					return;
				}

			}


		}

		private void PVTG_Details_ShownEditor(object sender, PivotCellEditEventArgs e)
		{
			PVTG_Details.ActiveEditor.Properties.ReadOnly = IsReadOnly;
		}

		private void PVTG_Details_EditValueChanged(object sender, EditValueChangedEventArgs e)
		{
			PivotDrillDownDataSource ds = e.CreateDrillDownDataSource();
			if (ds.RowCount == 0)
				return;
			//ds.SetValue(e.RowIndex, e.DataField, e.Editor.EditValue);
			for (int i = 0; i < ds.RowCount; i++)
			{
				ds.SetValue(i, e.DataField, e.Editor.EditValue);
                if ((int)ds.GetValue(i, "NID_EQUIPEMENT_FICHE_TYPE_CHAMP") == -1 | (int)ds.GetValue(i, "NID_EQUIPEMENT_FICHE_TYPE_CHAMP") == -2)
                {
                    List<SqlParameter> parameters = new List<SqlParameter>()
                                        {
                                                new SqlParameter() { ParameterName = "@P_NACT_INV_ELEMENT_RECEIVE_ID", SqlDbType = SqlDbType.Int, Value = ds.GetValue(i, "NACT_INV_ELEMENT_RECEIVE_ID")},
                                                new SqlParameter() { ParameterName = "@P_NACT_INV_EQUIPEMENT_RECEIVE_ID", SqlDbType = SqlDbType.Int, Value =  ds.GetValue(i, "NACT_INV_EQUIPEMENT_RECEIVE_ID")},
                                                new SqlParameter() { ParameterName = "@P_OVALUE", SqlDbType = SqlDbType.VarChar, Value = ds.GetValue(i, "OVALUE")}
                                        };

                    MozartDatabase.ExecuteNonQuery("[api_sp_InvEquip_Element_Receive_Save]", parameters.ToArray());
                }

            }
		}

		private void saveEquipements()
		{

			PivotDrillDownDataSource ds = PVTG_Details.CreateDrillDownDataSource();

			for (int i = 0; i < ds.RowCount; i++)
			{
				//MessageBox.Show($"{ds.GetValue(i, "NACT_INV_ELEMENT_RECEIVE_ID")} - {ds.GetValue(i, "VEQUIPEMENT_FICHE_ITEM_LIB")} : {ds.GetValue(i, "OVALUE")}");
				//[api_sp_InvEquip_Element_Receive_Save]
				// si case à coché :
				if ((int)ds.GetValue(i, "NID_EQUIPEMENT_FICHE_TYPE_CHAMP") == -1 | (int)ds.GetValue(i, "NID_EQUIPEMENT_FICHE_TYPE_CHAMP") == -2)
				{
					List<SqlParameter> parameters = new List<SqlParameter>()
										{
												new SqlParameter() { ParameterName = "@P_NACT_INV_ELEMENT_RECEIVE_ID", SqlDbType = SqlDbType.Int, Value = ds.GetValue(i, "NACT_INV_ELEMENT_RECEIVE_ID")},
												new SqlParameter() { ParameterName = "@P_NACT_INV_EQUIPEMENT_RECEIVE_ID", SqlDbType = SqlDbType.Int, Value =  ds.GetValue(i, "NACT_INV_EQUIPEMENT_RECEIVE_ID")},
												new SqlParameter() { ParameterName = "@P_OVALUE", SqlDbType = SqlDbType.VarChar, Value = ds.GetValue(i, "OVALUE")}
										};

					MozartDatabase.ExecuteNonQuery("[api_sp_InvEquip_Element_Receive_Save]", parameters.ToArray());
				}

			}

			//MessageBox.Show("Enregistrement effectué avec succès", "Confirmation", MessageBoxButtons.OK, MessageBoxIcon.Information);

		}


		private void BtnSave_Click(object sender, EventArgs e)
		{

			if (MessageBox.Show("Voulez-vous sauvegarder les équipements validés ?", "Confirmation", MessageBoxButtons.YesNoCancel, MessageBoxIcon.Question) == DialogResult.Yes)
			{
				saveEquipements();
			}

		}

		private void PVTG_Details_CellClick(object sender, PivotCellEventArgs e)
		{
			if (e.DataField.ToString() == "OVALUE" && e.RowValueType == PivotGridValueType.Value)
			{
				int NID_EQUIPEMENT_FICHE_TYPE_CHAMP = 0;

				PivotDrillDownDataSource ds = e.CreateDrillDownDataSource();

				if (ds[0] == null) return;

				//NID_EQUIPEMENT_FICHE_TYPE_CHAMP = (int)ds[0]["VEQUIPEMENT_FICHE_ITEM_LIB"];
				NID_EQUIPEMENT_FICHE_TYPE_CHAMP = (int)ds[0]["NID_EQUIPEMENT_FICHE_TYPE_CHAMP"];

				if (NID_EQUIPEMENT_FICHE_TYPE_CHAMP == 7)
				{
					//Console.WriteLine($"LINK : {e.Value.ToString()}");   
					int NACT_INV_PHOTO_RECEIVE_ID = 0;
					string filename_out = "";
					//on va recherche le nom du fichier
					NACT_INV_PHOTO_RECEIVE_ID = (int)ds[0]["NACT_INV_ELEMENT_RECEIVE_ID"]; //correspond au champ NACT_INV_PHOTO_RECEIVE_ID                                  

					using (SqlDataReader sqldr = MozartDatabase.ExecuteReader($"EXEC [api_sp_InvEquipement_Photo_GetFileName] {NACT_INV_PHOTO_RECEIVE_ID}"))
					{
						sqldr.Read();
						filename_out = sqldr["VFILENAME"].ToString();
					}

					//System.Diagnostics.Process.Start($@"{MozartParams.RechercheParam("REP_PHOTOS_EMASSET", MozartParams.NomSociete)}" + e.Value.ToString());
					if (filename_out != "" && File.Exists($@"{MozartParams.RechercheParam("REP_PHOTOS_EMASSET", MozartParams.NomSociete)}" + filename_out)) System.Diagnostics.Process.Start($@"{MozartParams.RechercheParam("REP_PHOTOS_EMASSET", MozartParams.NomSociete)}" + filename_out);
					return;
				}
				//CODE BARRE
				if (NID_EQUIPEMENT_FICHE_TYPE_CHAMP == 8)
				{
					//Console.WriteLine($"LINK : {e.Value.ToString()}");   
					int NACT_INV_ELEMENT_RECEIVE_ID = 0;
					int NACT_INV_EQUIPEMENT_RECEIVE_ID = 0;
					string filename_out = "";
					//on va recherche le nom du fichier
					NACT_INV_ELEMENT_RECEIVE_ID = (int)ds[0]["NACT_INV_ELEMENT_RECEIVE_ID"];
					NACT_INV_EQUIPEMENT_RECEIVE_ID = (int)ds[0]["NACT_INV_EQUIPEMENT_RECEIVE_ID"];

					using (SqlDataReader sqldr = MozartDatabase.ExecuteReader($"EXEC [api_sp_InvEquipement_PhotoCodeBarre_GetFileName] {NACT_INV_ELEMENT_RECEIVE_ID}, {NACT_INV_EQUIPEMENT_RECEIVE_ID}"))
					{
						if (sqldr.HasRows)
						{
							sqldr.Read();
							filename_out = sqldr["VFILENAME"].ToString();
						}
					}

					//System.Diagnostics.Process.Start($@"{MozartParams.RechercheParam("REP_PHOTOS_EMASSET", MozartParams.NomSociete)}" + e.Value.ToString());
					if (filename_out != "" && File.Exists($@"{MozartParams.RechercheParam("REP_PHOTOS_EMASSET", MozartParams.NomSociete)}" + filename_out)) System.Diagnostics.Process.Start($@"{MozartParams.RechercheParam("REP_PHOTOS_EMASSET", MozartParams.NomSociete)}" + filename_out);
					return;
				}

			}

		}

		private void BtnValiderInventaire_Click(object sender, EventArgs e)
		{

			// première confirmation
			if (MessageBox.Show("Voulez-vous valider cette inventaire ?", "Confirmation", MessageBoxButtons.YesNoCancel, MessageBoxIcon.Question) == DialogResult.Yes)
			{
				// deuxieme confirmation
				//if (MessageBox.Show("Etes-vous certain d’avoir valider l’ensemble des équipements avant de valider l’inventaire ?", "Confirmation", MessageBoxButtons.YesNoCancel, MessageBoxIcon.Question) == DialogResult.Yes)
				//{

					//on enregistre avant de lancer le traitement
					saveEquipements();

					//on traite l inventaire
					MozartDatabase.ExecuteNonQuery($"EXEC api_sp_InvEquip_TraiterInventaire {nactinvid}");

					MessageBox.Show("L'inventaire a été traité avec succès", "Confirmation", MessageBoxButtons.OK, MessageBoxIcon.Information);

					LoadDataPVT();

				//}
			}
		}

		private void ChkVisuEquipExists_CheckedChanged(object sender, EventArgs e)
		{
			if (ChkVisuEquipExists.Checked == true)
			{
				GVContratEquipement.SetAutoFilterValue(gridColumn7, 0, DevExpress.XtraGrid.Columns.AutoFilterCondition.Greater);
			}
			else
			{
				GVContratEquipement.SetAutoFilterValue(gridColumn7, null, DevExpress.XtraGrid.Columns.AutoFilterCondition.Equals);
			}
		}
	}
}
