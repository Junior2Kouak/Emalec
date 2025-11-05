using DevExpress.Utils.Filtering;
using DevExpress.Xpo.Logger.Transport;
using DevExpress.XtraEditors;
using DevExpress.XtraEditors.Controls;
using DevExpress.XtraEditors.Repository;
using DevExpress.XtraGrid;
using DevExpress.XtraGrid.Columns;
using DevExpress.XtraGrid.Views.Grid;
using DevExpress.XtraPrinting;
using MozartLib;
using MozartNet;
using System;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Windows.Forms;

namespace MozartCS
{
    public partial class frmMethodes_Admin_Equipement_GestionChampByClient : Form
    {
        DataTable dtListeFichesListClients;
        DataTable dtCbo;

        public frmMethodes_Admin_Equipement_GestionChampByClient()
        {
            InitializeComponent();
        }

        private void BtnClose_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void frmMethodes_Admin_Equipement_GestionChampByClient_Load(object sender, EventArgs e)
        {

            //INIT  
            ModuleMain.Initboutons(this);           

            LoadData();
            LoadDataCbo();
        }

        private void LoadData()
        {

            dtListeFichesListClients = new DataTable();

            SqlCommand cmdLoader = new SqlCommand("[api_sp_Equipement_Inventaire_Liste_Clients_BarCode]", MozartDatabase.cnxMozart);
            cmdLoader.CommandType = CommandType.StoredProcedure;

            // Execute the command and read the results
            dtListeFichesListClients.Load(cmdLoader.ExecuteReader());

            dtListeFichesListClients.Columns["NCLINUM"].ReadOnly = false;

            DataColumn Col_ID_Unique = new DataColumn();
            Col_ID_Unique.DataType = System.Type.GetType("System.Int32");
            Col_ID_Unique.AutoIncrement = true;
            Col_ID_Unique.AutoIncrementSeed = 1;
            Col_ID_Unique.AutoIncrementStep = 1;
            Col_ID_Unique.AllowDBNull = false;
            Col_ID_Unique.ColumnName = "ID_UNIQUE";

            dtListeFichesListClients.Columns.Add(Col_ID_Unique);

            GCAdmin_Equipement_List_Client.DataSource = dtListeFichesListClients;

        }

        private void LoadDataCbo()
        {

            dtCbo = new DataTable();

            SqlCommand cmdLoader = new SqlCommand("[api_sp_Equipement_Liste_Clients_Inventaire]", MozartDatabase.cnxMozart);
            cmdLoader.CommandType = CommandType.StoredProcedure;

            // Execute the command and read the results
            dtCbo.Load(cmdLoader.ExecuteReader());


            repositoryItemGridLookUpEdit1.DataSource = dtCbo;

        }

        private void BtnEquipFicheArch_Click(object sender, EventArgs e)
        {

            DataRow currentRow = GVAdmin_Equipement_List_Client.GetFocusedDataRow();
            if (currentRow == null)
            {
                MessageBox.Show("Il faut sélectionner un client", "Erreur", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                return;
            }

            if (MessageBox.Show("Voulez-vous supprimer ce client ?", "Confirmation", MessageBoxButtons.YesNoCancel) == DialogResult.Yes)
            {

                if ((int)currentRow["NEQUIPEMENT_FICHE_ITEM_CLI"] == 0)
                {
                    foreach(DataRow drDel in dtListeFichesListClients.Select($"[ID_UNIQUE] = {currentRow["ID_UNIQUE"]}").ToArray())
                    {
                        drDel.Delete();
                    }
                }
                else
                {
                    foreach (DataRow drDel in dtListeFichesListClients.Select($"[NEQUIPEMENT_FICHE_ITEM_CLI] = {currentRow["NEQUIPEMENT_FICHE_ITEM_CLI"]}").ToArray())
                    {
                        drDel.Delete();
                    }

                }

            }
            
        }

        private void BtnEquipFicheNew_Click(object sender, EventArgs e)
        {
            
            DataRow drAdd = dtListeFichesListClients.NewRow();
            drAdd["NEQUIPEMENT_FICHE_ITEM_CLI"] = 0;
            drAdd["NCLINUM"] = 0;
            drAdd["VCLINOM"] = "";
            dtListeFichesListClients.Rows.Add(drAdd);

        }

        private void GVAdmin_Equipement_List_Client_CustomRowCellEdit(object sender, CustomRowCellEditEventArgs e)
        {

            if (e.RowHandle < 0) return;

            //on affiche la combo client si NEQUIPEMENT_FICHE_ITEM_CLI = 0
            if (e.Column.FieldName == "VCLINOM") // Replace with your column's field name
            {
                // Get the data value for the current cell (optional, for conditional logic)
                int NCLINUM = (int)GVAdmin_Equipement_List_Client.GetRowCellValue(e.RowHandle, G_Col_NCLINUM);

                RepositoryItem Rep = null;
                if (NCLINUM == 0) e.RepositoryItem = repositoryItemGridLookUpEdit1;

            }          

        }

        private void BtnSave_Click(object sender, EventArgs e)
        {
            //test si client en doublons
            var groupedData2 = dtListeFichesListClients.AsEnumerable()
                           //.Where(w => w.Field<int>("NCLINUM") > 0)
                           .Where(w => w.RowState != DataRowState.Deleted && w.Field<int>("NCLINUM") > 0)
                           .GroupBy(p => p.Field<int>("NCLINUM"))
                           .Select(g => new
                           {
                               NCLINUM = g.Key,
                               nomclient = g.Where(w => w.Field<int>("NCLINUM") == g.Key).Select(p => p.Field<string>("VCLINOM")).First(),
                               nb = g.Count()
                           });

            foreach (var item in groupedData2)
            {
                
                if (item.nb > 1)
                {
                    MessageBox.Show($"Enregistrement impossible car le client {item.nomclient} existe plusieurs fois ({item.nb})", "Erreur", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    return;
                }
            }

            //test si client non sélectionné            
            if (dtListeFichesListClients.AsEnumerable().Where(s => s.RowState != DataRowState.Deleted &&  (int)s["NCLINUM"] == 0).Count() > 0)
            {
                MessageBox.Show($"Enregistrement impossible car il y a une ligne sans client de sélectionné)", "Erreur", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }
            
            if (MessageBox.Show("Voulez-vous enregistrer ?", "Confirmation", MessageBoxButtons.YesNoCancel) == DialogResult.Yes)
            {

                //gestion des rows modified ou ajouter
                if (dtListeFichesListClients.GetChanges(DataRowState.Deleted) != null)
                {
                    foreach (DataRow DrDel in dtListeFichesListClients.GetChanges(DataRowState.Deleted).Rows)
                    {
                        ModuleData.ExecuteNonQuery($"EXEC [api_sp_Equipement_Inventaire_Liste_Clients_BarCode_Delete] {DrDel["NEQUIPEMENT_FICHE_ITEM_CLI", DataRowVersion.Original]}");
                    }
                }


                //gestion des rows modified ou ajouter
                if (dtListeFichesListClients.GetChanges(DataRowState.Added | DataRowState.Modified) != null)
                {
                    foreach (DataRow DrUPdate in dtListeFichesListClients.GetChanges(DataRowState.Added | DataRowState.Modified).Rows)
                    {
                        ModuleData.ExecuteNonQuery($"EXEC [api_sp_Equipement_Inventaire_Liste_Clients_BarCode_Save] {DrUPdate["NEQUIPEMENT_FICHE_ITEM_CLI"]}, {DrUPdate["NCLINUM"]}");
                    }
                }

                dtListeFichesListClients.AcceptChanges();
                LoadData();
            }
        }

        private void repositoryItemGridLookUpEdit1_EditValueChanged(object sender, EventArgs e)
        {
            GridLookUpEdit item = sender as GridLookUpEdit;
            if (item == null) return;
            DataRow row =  item.Properties.View.GetFocusedDataRow();
            if (row == null) return;

            GVAdmin_Equipement_List_Client.SetFocusedRowCellValue(GVAdmin_Equipement_List_Client.Columns["NCLINUM"], row["NCLINUM"]);
        }
    }
}
