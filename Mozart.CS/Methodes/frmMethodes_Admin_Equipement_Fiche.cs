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
    public partial class frmMethodes_Admin_Equipement_Fiche : Form
    {
        DataTable dtListeFiches;

        bool bArchives;

        public frmMethodes_Admin_Equipement_Fiche()
        {
            InitializeComponent();
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

            dtListeFiches = new DataTable();

            SqlCommand cmdLoader = new SqlCommand("[api_sp_Equipement_Admin_Fiche_Liste]", MozartDatabase.cnxMozart);
            cmdLoader.CommandType = CommandType.StoredProcedure;

            cmdLoader.Parameters.AddWithValue("@P_BEQUIPEMENT_FICHE_ACTIF", (p_Archives ? false : true));

            // Execute the command and read the results
            dtListeFiches.Load(cmdLoader.ExecuteReader());

            GCAdmin_Equipement_Fiches.DataSource = dtListeFiches;

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

            grid.DataSource = dtListeFiches;

            grid.ForceInitialize();
            gridview.PopulateColumns();

            string filename = "Export_Liste_Equipement_Fiche_" + DateTime.Now.Day.ToString() + DateTime.Now.Month.ToString() + DateTime.Now.Year.ToString();

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
                LblTitre.Text = "Listes des fiches archivées pour équipement";
                BtnEquipFicheNew.Visible = false;
                BtnEquipFicheArch.Text = "Restaurer";
            }
            else
            {
                LblTitre.Text = "Listes des fiches actives pour équipement";
                BtnEquipFicheNew.Visible = true;
                BtnEquipFicheArch.Text = "Archiver";
            }

            this.Text = LblTitre.Text;
            LoadData(bArchives);

        }

        private void BtnEquipFicheArch_Click(object sender, EventArgs e)
        {

            DataRow currentRow = GVAdmin_Equipement_Fiches.GetFocusedDataRow();
            if (null == currentRow)
            {
                MessageBox.Show("Il faut sélectionner une fiche", "Erreur", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                return;
            }

            if (MessageBox.Show("Voulez-vous archiver cette fiche ?", "Confirmation", MessageBoxButtons.YesNoCancel) == DialogResult.Yes)
            {
                string sql = $"EXEC [api_sp_Equipement_Admin_Fiche_Archive_Restaure] {currentRow["NID_EQUIPEMENT_FICHE"]}, {bArchives}";
                ModuleData.ExecuteNonQuery(sql);
                LoadData(bArchives);
            }
            
        }

        private void BtnEquipFicheNew_Click(object sender, EventArgs e)
        {

            frmMethodes_Admin_Equipement_Fiche_Detail ofrmMethodes_Admin_Equipement_Fiche_Detail = new frmMethodes_Admin_Equipement_Fiche_Detail(0);
            ofrmMethodes_Admin_Equipement_Fiche_Detail.ShowDialog();

            LoadData(bArchives);

        }

        private void BtnDetail_Click(object sender, EventArgs e)
        {

            DataRow currentRow = GVAdmin_Equipement_Fiches.GetFocusedDataRow();
            if (null == currentRow)
            {
                MessageBox.Show("Il faut sélectionner une fiche", "Erreur", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                return;
            }

            frmMethodes_Admin_Equipement_Fiche_Detail ofrmMethodes_Admin_Equipement_Fiche_Detail = new frmMethodes_Admin_Equipement_Fiche_Detail((Int32)currentRow["NID_EQUIPEMENT_FICHE"]);
            ofrmMethodes_Admin_Equipement_Fiche_Detail.ShowDialog();

            LoadData(bArchives);

        }

        private void BtnCopy_Click(object sender, EventArgs e)
        {
            DataRow currentRow = GVAdmin_Equipement_Fiches.GetFocusedDataRow();
            if (null == currentRow)
            {
                MessageBox.Show("Il faut sélectionner une fiche", "Erreur", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                return;
            }

            if (MessageBox.Show("Voulez-vous copier cette fiche ?", "Confirmation", MessageBoxButtons.YesNoCancel) == DialogResult.Yes)
            {
                string NewNameFiche = Microsoft.VisualBasic.Interaction.InputBox("Entrez le nom de la fiche", "Copie d'une fiche", $"{currentRow["VEQUIPEMENT_FICHE_LIB"].ToString()}", 0, 0);

                if (NewNameFiche == "") { MessageBox.Show("Il faut saisir le nom d'une fiche", "Information", MessageBoxButtons.OK, MessageBoxIcon.Exclamation); return; }

                ModuleData.ExecuteNonQuery($"EXEC [api_sp_Equipement_Admin_Copy_Fiche] {currentRow["NID_EQUIPEMENT_FICHE"]}, '{NewNameFiche.Replace("'", "''")}'");

                MessageBox.Show("Duplication effectuée avec succès", "Information", MessageBoxButtons.OK, MessageBoxIcon.Information);    
            }

            LoadData(bArchives);

        }
    }
}
