using DevExpress.XtraEditors.Controls;
using DevExpress.XtraGrid;
using DevExpress.XtraGrid.Columns;
using DevExpress.XtraGrid.Views.Grid;
using DevExpress.XtraPrinting;
using MozartLib;
using MozartNet;
using System;
using System.Data;
using System.Data.SqlClient;
using System.Windows.Forms;

namespace MozartCS
{
    public partial class frmMethodes_Admin_Equipement_Fiche_Chap : Form
    {
        DataTable dtListeFichesChap;

        public int _NID_EQUIPEMENT_FICHE;
        public string _VEQUIPEMENT_FICHE_LIB;

        bool bArchives;

        public frmMethodes_Admin_Equipement_Fiche_Chap(int C_NID_EQUIPEMENT_FICHE, string C_VEQUIPEMENT_FICHE_LIB)
        {
            InitializeComponent();
            _NID_EQUIPEMENT_FICHE = C_NID_EQUIPEMENT_FICHE;
            _VEQUIPEMENT_FICHE_LIB = C_VEQUIPEMENT_FICHE_LIB;
        }

        private void BtnClose_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void frmMethodes_Admin_Equipement_Fiche_Load(object sender, EventArgs e)
        {

            //INIT  
            ModuleMain.Initboutons(this);
            bArchives = false;

            LoadData(bArchives);
        }

        private void LoadData(bool p_Archives)
        {

            dtListeFichesChap = new DataTable();

            SqlCommand cmdLoader = new SqlCommand("[api_sp_Equipement_Admin_Fiche_Chap_Liste]", MozartDatabase.cnxMozart);
            cmdLoader.CommandType = CommandType.StoredProcedure;
            cmdLoader.Parameters.AddWithValue("@P_NID_EQUIPEMENT_FICHE", _NID_EQUIPEMENT_FICHE);
            cmdLoader.Parameters.AddWithValue("@P_BEQUIPEMENT_FICHE_CHAP_ACTIF", (p_Archives ? false : true));
                        

            // Execute the command and read the results
            dtListeFichesChap.Load(cmdLoader.ExecuteReader());

            dtListeFichesChap.Columns["NID_EQUIPEMENT_FICHE_CHAP"].ReadOnly = false;

            GCAdmin_Equipement_Fiches_Chap.DataSource = dtListeFichesChap;

        }

        private void BtnExportXLSX_Click(object sender, EventArgs e)
        {

            //onc créer un gridcontrol
            GridControl grid = new GridControl();
            grid.BindingContext = new System.Windows.Forms.BindingContext();
            GridView gridview = new GridView();
            grid.MainView = gridview;
            gridview.GridControl = grid;
            grid.ViewCollection.AddRange(new DevExpress.XtraGrid.Views.Base.BaseView[] {
           gridview});

            grid.DataSource = dtListeFichesChap;

            grid.ForceInitialize();
            gridview.PopulateColumns();

            string filename = "Export_Liste_Equipement_Fiche_Chap" + DateTime.Now.Day.ToString() + DateTime.Now.Month.ToString() + DateTime.Now.Year.ToString();

            SFD.FileName = filename;

            if (SFD.ShowDialog() == DialogResult.OK)
            {
                if (SFD.FileName != "")
                {
                    XlsxExportOptionsEx exportOptions = new XlsxExportOptionsEx();
                    exportOptions.ExportType = DevExpress.Export.ExportType.WYSIWYG;                    
                  
                    grid.ExportToXlsx(SFD.FileName, exportOptions);
                    MessageBox.Show("Export EXCEL créé avec succès", "Information", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }               
            }            

        }

        private void ChkArchives_CheckedChanged(object sender, EventArgs e)
        {

            bArchives = ChkArchives.Checked;

            if(bArchives == true)
            {
                LblTitre.Text = $"Listes des chapitres archivés de la fiche {_VEQUIPEMENT_FICHE_LIB}";
                BtnEquipFicheChapNew.Visible = BtnRowUp.Visible = BtnRowDown.Visible = false;
                BtnEquipFicheChapArch.Text = "Restaurer";
            }
            else
            {
                LblTitre.Text = $"Listes des chapitres actifs de la fiche {_VEQUIPEMENT_FICHE_LIB}";
                BtnEquipFicheChapNew.Visible = BtnRowUp.Visible = BtnRowDown.Visible =  true;
                BtnEquipFicheChapArch.Text = "Archiver";
            }

            this.Text = LblTitre.Text;
            LoadData(bArchives);

        }

        private void BtnEquipFicheArch_Click(object sender, EventArgs e)
        {

            DataRow currentRow = GVAdmin_Equipement_Fiches_Chap.GetFocusedDataRow();
            if (null == currentRow)
            {
                MessageBox.Show("Il faut sélectionner un chapitre", "Erreur", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                return;
            }

            if (MessageBox.Show("Voulez-vous archiver ce chapitre ?", "Confirmation", MessageBoxButtons.YesNoCancel) == DialogResult.Yes)
            {
                string sql = $"EXEC [api_sp_Equipement_Admin_Fiche_Chap_Archive_Restaure] {currentRow["NID_EQUIPEMENT_FICHE_CHAP"]}, {bArchives}";
                ModuleData.ExecuteNonQuery(sql);
                LoadData(bArchives);
            }
            
        }

        private void BtnEquipFicheNew_Click(object sender, EventArgs e)
        {

            frmMethodes_Admin_Equipement_Fiche_Chap_Detail ofrmMethodes_Admin_Equipement_Fiche_Chap_Detail = new frmMethodes_Admin_Equipement_Fiche_Chap_Detail(0, _NID_EQUIPEMENT_FICHE);
            ofrmMethodes_Admin_Equipement_Fiche_Chap_Detail.ShowDialog();

            LoadData(bArchives);

        }

        private void BtnDetail_Click(object sender, EventArgs e)
        {

            DataRow currentRow = GVAdmin_Equipement_Fiches_Chap.GetFocusedDataRow();
            if (null == currentRow)
            {
                MessageBox.Show("Il faut sélectionner un chapitre", "Erreur", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                return;
            }

            frmMethodes_Admin_Equipement_Fiche_Chap_Detail ofrmMethodes_Admin_Equipement_Fiche_Chap_Detail = new frmMethodes_Admin_Equipement_Fiche_Chap_Detail((Int32)currentRow["NID_EQUIPEMENT_FICHE_CHAP"], (Int32)currentRow["NID_EQUIPEMENT_FICHE"]);
            ofrmMethodes_Admin_Equipement_Fiche_Chap_Detail.ShowDialog();

            LoadData(bArchives);

        }        

        private void BtnRowUp_Click(object sender, EventArgs e)
        {
            DevExpress.XtraGrid.Views.Grid.GridView view = GVAdmin_Equipement_Fiches_Chap;

            int index = view.FocusedRowHandle;
            if (index <= 0) return;

            DataRow row_selected_to_up = view.GetDataRow(index);
            DataRow row_to_down_by_up = view.GetDataRow(index - 1);
            DataRow row_Save_inter = SaveDrToUpandDown(row_to_down_by_up);             


            //DataRow row_inter = row1;
            object idx_row_selected_to_up = row_selected_to_up["NEQUIPEMENT_FICHE_CHAP_ORDER_AFFICH"];
            object idx_row_idx_to_down_by_up = row_to_down_by_up["NEQUIPEMENT_FICHE_CHAP_ORDER_AFFICH"];

            row_to_down_by_up["NID_EQUIPEMENT_FICHE_CHAP"] = row_selected_to_up["NID_EQUIPEMENT_FICHE_CHAP"];
            row_to_down_by_up["VEQUIPEMENT_FICHE_CHAP_LIB"] = row_selected_to_up["VEQUIPEMENT_FICHE_CHAP_LIB"];
            row_to_down_by_up["NEQUIPEMENT_FICHE_CHAP_ORDER_AFFICH"] = idx_row_idx_to_down_by_up;

            row_selected_to_up["NID_EQUIPEMENT_FICHE_CHAP"] = row_Save_inter["NID_EQUIPEMENT_FICHE_CHAP"];
            row_selected_to_up["VEQUIPEMENT_FICHE_CHAP_LIB"] = row_Save_inter["VEQUIPEMENT_FICHE_CHAP_LIB"];
            row_selected_to_up["NEQUIPEMENT_FICHE_CHAP_ORDER_AFFICH"] = idx_row_selected_to_up;
                                    
            view.FocusedRowHandle = index - 1;                        
            
            view.SetRowCellValue(index, G_L0_Col_NID_EQUIPEMENT_FICHE_CHAP, row_selected_to_up["NID_EQUIPEMENT_FICHE_CHAP"]);
            view.SetRowCellValue(index - 1, G_L0_Col_NID_EQUIPEMENT_FICHE_CHAP, row_to_down_by_up["NID_EQUIPEMENT_FICHE_CHAP"]);

            view.SetRowCellValue(index, G_L0_Col_VEQUIPEMENT_FICHE_CHAP_LIB, row_selected_to_up["VEQUIPEMENT_FICHE_CHAP_LIB"]);
            view.SetRowCellValue(index - 1, G_L0_Col_VEQUIPEMENT_FICHE_CHAP_LIB, row_to_down_by_up["VEQUIPEMENT_FICHE_CHAP_LIB"]);

            view.SetRowCellValue(index, G_L0_Col_NEQUIPEMENT_FICHE_CHAP_ORDER_AFFICH, idx_row_selected_to_up );
            view.SetRowCellValue(index - 1, G_L0_Col_NEQUIPEMENT_FICHE_CHAP_ORDER_AFFICH, idx_row_idx_to_down_by_up);


            view.UpdateCurrentRow();

            view.RefreshData();
            view.PostEditor();

        }

        private DataRow SaveDrToUpandDown(DataRow Dr_toSave)
        {

            if(Dr_toSave == null)  return null;


            DataTable Dt_tmp = new DataTable();
            Dt_tmp.Columns.Add("NID_EQUIPEMENT_FICHE_CHAP", typeof(int));
            Dt_tmp.Columns.Add("NID_EQUIPEMENT_FICHE", typeof(int));
            Dt_tmp.Columns.Add("VEQUIPEMENT_FICHE_CHAP_LIB", typeof(string));
            Dt_tmp.Columns.Add("NEQUIPEMENT_FICHE_CHAP_ORDER_AFFICH", typeof(int));            

            DataRow dr = Dt_tmp.NewRow();
            dr["NID_EQUIPEMENT_FICHE_CHAP"] = Dr_toSave["NID_EQUIPEMENT_FICHE_CHAP"];
            dr["NID_EQUIPEMENT_FICHE"] = Dr_toSave["NID_EQUIPEMENT_FICHE"];
            dr["VEQUIPEMENT_FICHE_CHAP_LIB"] = Dr_toSave["VEQUIPEMENT_FICHE_CHAP_LIB"];
            dr["NEQUIPEMENT_FICHE_CHAP_ORDER_AFFICH"] = Dr_toSave["NEQUIPEMENT_FICHE_CHAP_ORDER_AFFICH"];

            return dr;
        }

        private void BtnRowDown_Click(object sender, EventArgs e)
        {
            DevExpress.XtraGrid.Views.Grid.GridView view = GVAdmin_Equipement_Fiches_Chap;

            int index = view.FocusedRowHandle;
            if (index + 1 >= view.RowCount) return;

            DataRow row_selected_to_down = view.GetDataRow(index);
            DataRow row_to_up_by_down = view.GetDataRow(index + 1);
            DataRow row_Save_inter = SaveDrToUpandDown(row_to_up_by_down);


            //DataRow row_inter = row1;
            object idx_row_selected_to_down = row_selected_to_down["NEQUIPEMENT_FICHE_CHAP_ORDER_AFFICH"];
            object idx_row_idx_to_up_by_down = row_to_up_by_down["NEQUIPEMENT_FICHE_CHAP_ORDER_AFFICH"];

            row_to_up_by_down["NID_EQUIPEMENT_FICHE_CHAP"] = row_selected_to_down["NID_EQUIPEMENT_FICHE_CHAP"];
            row_to_up_by_down["VEQUIPEMENT_FICHE_CHAP_LIB"] = row_selected_to_down["VEQUIPEMENT_FICHE_CHAP_LIB"];
            row_to_up_by_down["NEQUIPEMENT_FICHE_CHAP_ORDER_AFFICH"] = idx_row_selected_to_down;

            row_selected_to_down["NID_EQUIPEMENT_FICHE_CHAP"] = row_Save_inter["NID_EQUIPEMENT_FICHE_CHAP"];
            row_selected_to_down["VEQUIPEMENT_FICHE_CHAP_LIB"] = row_Save_inter["VEQUIPEMENT_FICHE_CHAP_LIB"];
            row_selected_to_down["NEQUIPEMENT_FICHE_CHAP_ORDER_AFFICH"] = idx_row_idx_to_up_by_down;

            view.FocusedRowHandle = index + 1;

            view.SetRowCellValue(index, G_L0_Col_NID_EQUIPEMENT_FICHE_CHAP, row_selected_to_down["NID_EQUIPEMENT_FICHE_CHAP"]);
            view.SetRowCellValue(index + 1, G_L0_Col_NID_EQUIPEMENT_FICHE_CHAP, row_to_up_by_down["NID_EQUIPEMENT_FICHE_CHAP"]);

            view.SetRowCellValue(index, G_L0_Col_VEQUIPEMENT_FICHE_CHAP_LIB, row_selected_to_down["VEQUIPEMENT_FICHE_CHAP_LIB"]);
            view.SetRowCellValue(index + 1, G_L0_Col_VEQUIPEMENT_FICHE_CHAP_LIB, row_to_up_by_down["VEQUIPEMENT_FICHE_CHAP_LIB"]);

            view.SetRowCellValue(index, G_L0_Col_NEQUIPEMENT_FICHE_CHAP_ORDER_AFFICH, idx_row_selected_to_down);
            view.SetRowCellValue(index + 1, G_L0_Col_NEQUIPEMENT_FICHE_CHAP_ORDER_AFFICH, idx_row_idx_to_up_by_down);


            view.UpdateCurrentRow();

            view.RefreshData();
            view.PostEditor();
        }

        private void BtnSave_Click(object sender, EventArgs e)
        {

            foreach(DataRow drSave in dtListeFichesChap.Rows)
            {

                CEQUIPEMENT_CHAPITRE.Save((int)drSave["NID_EQUIPEMENT_FICHE_CHAP"], (int)drSave["NID_EQUIPEMENT_FICHE"], (int)drSave["NEQUIPEMENT_FICHE_CHAP_ORDER_AFFICH"], (string)drSave["VEQUIPEMENT_FICHE_CHAP_LIB"], (bool)drSave["BEQUIPEMENT_FICHE_CHAP_ACTIF"]);

            }
            dtListeFichesChap.AcceptChanges();

            //permet de redefinir l'order d 'affichage des items
            CEQUIPEMENT_CHAPITRE.RefreshOrderAffichage(_NID_EQUIPEMENT_FICHE);

            LoadData(bArchives);

        }
    }
}
