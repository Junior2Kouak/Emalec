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
    public partial class frmMethodes_Admin_Equipement_Fiche_ListParent : Form
    {
        DataTable dtListeFichesListParent;

        bool bArchives;

        public frmMethodes_Admin_Equipement_Fiche_ListParent()
        {
            InitializeComponent();
        }

        private void BtnClose_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void frmMethodes_Admin_Equipement_Fiche_ListParent_Load(object sender, EventArgs e)
        {

            //INIT  
            ModuleMain.Initboutons(this);
            bArchives = false;

            LoadData(bArchives);
        }

        private void LoadData(bool p_Archives)
        {

            dtListeFichesListParent = new DataTable();

            SqlCommand cmdLoader = new SqlCommand("[api_sp_Equipement_Admin_Fiche_ListParent_Liste]", MozartDatabase.cnxMozart);
            cmdLoader.CommandType = CommandType.StoredProcedure;           
            cmdLoader.Parameters.AddWithValue("@P_BEQUIPEMENT_FICHE_LIST_PARENT_ACTIF", (p_Archives ? false : true));

            // Execute the command and read the results
            dtListeFichesListParent.Load(cmdLoader.ExecuteReader());

            GCAdmin_Equipement_Fiches_ListParent.DataSource = dtListeFichesListParent;

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

            grid.DataSource = dtListeFichesListParent;

            grid.ForceInitialize();
            gridview.PopulateColumns();

            string filename = "Export_Liste_Equipement_Fiche_ListParent" + DateTime.Now.Day.ToString() + DateTime.Now.Month.ToString() + DateTime.Now.Year.ToString();

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
                LblTitre.Text = $"Listes des listes parents archivées";
                BtnEquipFicheChapNew.Visible = false;
                BtnEquipFicheChapArch.Text = "Restaurer";
            }
            else
            {
                LblTitre.Text = $"Listes des listes parents actives";
                BtnEquipFicheChapNew.Visible = true;
                BtnEquipFicheChapArch.Text = "Archiver";
            }

            this.Text = LblTitre.Text;
            LoadData(bArchives);

        }

        private void BtnEquipFicheArch_Click(object sender, EventArgs e)
        {

            DataRow currentRow = GVAdmin_Equipement_Fiches_ListParent.GetFocusedDataRow();
            if (null == currentRow)
            {
                MessageBox.Show("Il faut sélectionner une liste", "Erreur", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                return;
            }

            if (MessageBox.Show("Voulez-vous archiver cette liste ?", "Confirmation", MessageBoxButtons.YesNoCancel) == DialogResult.Yes)
            {
                string sql = $"EXEC [api_sp_Equipement_Admin_Fiche_ListParent_Archive_Restaure] {currentRow["NID_EQUIPEMENT_FICHE_LIST_PARENT"]}, {bArchives}";
                ModuleData.ExecuteNonQuery(sql);
                LoadData(bArchives);
            }
            
        }

        private void BtnEquipFicheNew_Click(object sender, EventArgs e)
        {

            frmMethodes_Admin_Equipement_ListParent_Item_Detail ofrmMethodes_Admin_Equipement_ListParent_Item_Detail = new frmMethodes_Admin_Equipement_ListParent_Item_Detail(0);
            ofrmMethodes_Admin_Equipement_ListParent_Item_Detail.ShowDialog();

            LoadData(bArchives);

        }

        private void BtnDetail_Click(object sender, EventArgs e)
        {

            DataRow currentRow = GVAdmin_Equipement_Fiches_ListParent.GetFocusedDataRow();
            if (null == currentRow)
            {
                MessageBox.Show("Il faut sélectionner une liste", "Erreur", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                return;
            }

            frmMethodes_Admin_Equipement_ListParent_Item_Detail ofrmMethodes_Admin_Equipement_ListParent_Item_Detail = new frmMethodes_Admin_Equipement_ListParent_Item_Detail((Int32)currentRow["NID_EQUIPEMENT_FICHE_LIST_PARENT"]);
            ofrmMethodes_Admin_Equipement_ListParent_Item_Detail.ShowDialog();

            LoadData(bArchives);

        }
       
    }
}
