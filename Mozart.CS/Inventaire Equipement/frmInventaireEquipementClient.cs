using DevExpress.CodeParser;
using DevExpress.Data.ChartDataSources;
using DevExpress.DataAccess.Native.EntityFramework;
using DevExpress.PivotGrid.DataBinding;
using DevExpress.Utils;
using DevExpress.Xpo.Helpers;
using DevExpress.XtraEditors;
using DevExpress.XtraEditors.Controls;
using DevExpress.XtraEditors.Repository;
using DevExpress.XtraGrid.Views.Printing;
using DevExpress.XtraPivotGrid;
using DevExpress.XtraScheduler;
using MozartCS.Inventaire_Equipement;
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
using static System.Windows.Forms.VisualStyles.VisualStyleElement;
using MZUtils = MozartControls.Utils;

namespace MozartCS
{
    public partial class frmInventaireEquipementClient : Form
    {

        public int nclinum;
        public string vclinom;

        private List<Int32> lstTextEdit = new List<Int32>() { 1, 2, 3, 4, 9 };
        private List<Int32> lstCboEdit = new List<Int32>() { 5, 10, 11 };

        DataTable dt = new DataTable();
        DataTable dtDetails = new DataTable();

        private bool bArchives;

        private Int32 colmunIndexSelected = -1;
        private Int32 rowIndexSelected = -1;

        public frmInventaireEquipementClient()
        {
            InitializeComponent();
        }

        private void frmInventaireEquipementClient_Load(object sender, EventArgs e)
        {
            try
            {
                Cursor.Current = Cursors.WaitCursor;
                ModuleMain.Initboutons(this);
                bArchives = false;                

                if (nclinum == 0) { return; }

                GestAffichage();

                LoadDataContratAndTypeEquipement();

            }
            catch (Exception ex)
            {
                MZUtils.displayError(MethodBase.GetCurrentMethod().Name, ex);
            }
            finally { Cursor.Current = Cursors.Default; }
        }

        private void GVContratEquipement_RowCellClick(object sender, DevExpress.XtraGrid.Views.Grid.RowCellClickEventArgs e)
        {
            LoadDataDetails();
        }

        private void LoadDataContratAndTypeEquipement()
        {
            ModuleData.LoadData(dt, $"EXEC [api_sp_InvEquip_DetailsListeContratEquipement_By_Client] {nclinum}, {!bArchives}");

            GCContratEquipement.DataSource = dt;
        }

        private void LoadDataDetails()
        {
            DataRow row = GVContratEquipement.GetFocusedDataRow();
            if (row == null) return;

            //dtDetails = new DataTable();

            ModuleData.LoadData(dtDetails, $"EXEC [api_sp_InvEquip_DetailsByClient] {nclinum},{row["NTYPECONTRAT"]}, {row["NIDEQUIPEMENT"]}, {row["NID_EQUIPEMENT_FICHE"]}, {!bArchives}");

            for (int i = 0; i < dtDetails.Columns.Count;)
            {
                dtDetails.Columns[i].ReadOnly = true;
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
                             
                //photo
                if (NID_EQUIPEMENT_FICHE_TYPE_CHAMP == 7 | NID_EQUIPEMENT_FICHE_TYPE_CHAMP == 8)
                {
                    e.RepositoryItem = repositoryItemHyperLinkEdit1;
                    return;
                }
                              
                //checkbox
                if (NID_EQUIPEMENT_FICHE_TYPE_CHAMP == 6)
                {
                    e.RepositoryItem = repositoryItemCheckEdit1;
                    return;
                }
                //texte mutli-lignes
                if (NID_EQUIPEMENT_FICHE_TYPE_CHAMP == 4)
                {
                    e.RepositoryItem = repositoryItemRichTextEdit1;
                    return;
                }


                //checkbox
                if (NID_EQUIPEMENT_FICHE_TYPE_CHAMP == -1)
                {
                    e.RepositoryItem = repositoryItemCheckEdit2;
                    return;
                }

            }

        }

        private void PVTG_Details_ShownEditor(object sender, PivotCellEditEventArgs e)
        {
            PVTG_Details.ActiveEditor.Properties.ReadOnly = true;
        }

        private void PVTG_Details_EditValueChanged(object sender, EditValueChangedEventArgs e)
        {

        }

        private void BtnSave_Click(object sender, EventArgs e)
        {

            //if (MessageBox.Show("Voulez - vous enregistrer ses modifications ?", "Confirmation", MessageBoxButtons.YesNoCancel, MessageBoxIcon.Question) == DialogResult.Yes)
            //{

            //    PivotDrillDownDataSource ds = PVTG_Details.CreateDrillDownDataSource();

            //    for (int i = 0; i < ds.RowCount; i++)
            //    {
            //        //MessageBox.Show($"{ds.GetValue(i, "NACT_INV_ELEMENT_RECEIVE_ID")} - {ds.GetValue(i, "VEQUIPEMENT_FICHE_ITEM_LIB")} : {ds.GetValue(i, "OVALUE")}");
            //        //[api_sp_InvEquip_Element_Receive_Save]

            //        List<SqlParameter> parameters = new List<SqlParameter>()
            //        {
            //            new SqlParameter() { ParameterName = "@P_NACT_INV_ELEMENT_RECEIVE_ID", SqlDbType = SqlDbType.Int, Value = ds.GetValue(i, "NACT_INV_ELEMENT_RECEIVE_ID")},
            //            new SqlParameter() { ParameterName = "@P_NACT_INV_EQUIPEMENT_RECEIVE_ID", SqlDbType = SqlDbType.Int, Value =  ds.GetValue(i, "NACT_INV_EQUIPEMENT_RECEIVE_ID")},
            //            new SqlParameter() { ParameterName = "@P_OVALUE", SqlDbType = SqlDbType.VarChar, Value = ds.GetValue(i, "OVALUE")}
            //        };

            //        MozartDatabase.ExecuteNonQuery("[api_sp_InvEquip_Element_Receive_Save]", parameters.ToArray());

            //    }

            //    MessageBox.Show("Enregistrement effectué avec succès", "Confirmation", MessageBoxButtons.OK, MessageBoxIcon.Information);

            //}

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
                    int NSIT_INV_PHOTO_RECEIVE_ID = 0;
                    string filename_out = "";
                    //on va recherche le nom du fichier
                    NSIT_INV_PHOTO_RECEIVE_ID = (int)ds[0]["NSIT_INV_ELEMENT_RECEIVE_ID"]; //correspond au champ NACT_INV_PHOTO_RECEIVE_ID                                  

                    using (SqlDataReader sqldr = MozartDatabase.ExecuteReader($"EXEC [api_sp_InvEquipement_Site_Photo_GetFileName] {NSIT_INV_PHOTO_RECEIVE_ID}"))
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
                    int NSIT_INV_ELEMENT_RECEIVE_ID = 0;
                    int NSIT_INV_EQUIPEMENT_RECEIVE_ID = 0;
                    string filename_out = "";
                    //on va recherche le nom du fichier
                    NSIT_INV_ELEMENT_RECEIVE_ID = (int)ds[0]["NSIT_INV_ELEMENT_RECEIVE_ID"];
                    NSIT_INV_EQUIPEMENT_RECEIVE_ID = (int)ds[0]["NSIT_INV_EQUIPEMENT_RECEIVE_ID"];

                    using (SqlDataReader sqldr = MozartDatabase.ExecuteReader($"EXEC [api_sp_InvEquipement_Site_PhotoCodeBarre_GetFileName] {NSIT_INV_ELEMENT_RECEIVE_ID}, {NSIT_INV_EQUIPEMENT_RECEIVE_ID}"))
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

        private void BtnArchiverEquipement_Click(object sender, EventArgs e)
        {
            if (colmunIndexSelected == -1 | rowIndexSelected == -1)
            {
                MessageBox.Show("Il faut sélectionner un équipement", Program.AppTitle, MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                return;
            }

            if (MessageBox.Show("Vous allez-archiver cet équipement, êtes-vous sûre?", Program.AppTitle, MessageBoxButtons.YesNo, MessageBoxIcon.Question, MessageBoxDefaultButton.Button2) != DialogResult.Yes) return;

            

            PivotDrillDownDataSource ds = PVTG_Details.CreateDrillDownDataSource(colmunIndexSelected, rowIndexSelected);
            if (ds == null) return;
            if (ds[0] == null) return;

            for (int i = 0; i < ds.RowCount; i++)
            {

                if ((int)ds.GetValue(i, "NSIT_INV_EQUIPEMENT_RECEIVE_ID") > 0)
                {
                    List<SqlParameter> parameters = new List<SqlParameter>()
                            {
                                new SqlParameter() { ParameterName = "@P_NSIT_INV_EQUIPEMENT_RECEIVE_ID", SqlDbType = SqlDbType.Int, Value = ds.GetValue(i, "NSIT_INV_EQUIPEMENT_RECEIVE_ID")},
                                new SqlParameter() { ParameterName = "@P_BACTIF", SqlDbType = SqlDbType.Bit, Value = false}
                            };

                    MozartDatabase.ExecuteNonQuery("[api_sp_InvEquip_Site_Equipement_Actif]", parameters.ToArray());
                    LoadDataDetails();
                }

            }


        }

        private void BtnArchivesEquipement_Click(object sender, EventArgs e)
        {
            bArchives = !bArchives;
            GestAffichage();
        }


        private void GestAffichage()
        {            

            if (bArchives)
            {
                this.Text = LblTitre.Text = $"Inventaire des équipements inactifs du client {vclinom}";
                BtnArchivesEquipement.Text = "Voir les actifs";

            }
            else
            {
                this.Text = LblTitre.Text = $"Inventaire des équipements actifs du client {vclinom}";
                BtnArchivesEquipement.Text = "Voir les inactifs";
            }                       

            BtnAddEquipement.Visible = !bArchives & (ModuleMain.bAccesBouton(BtnAddEquipement.HelpContextID.ToString()) > 0);
            BtnArchiverEquipement.Visible = !bArchives & (ModuleMain.bAccesBouton(BtnArchiverEquipement.HelpContextID.ToString()) > 0);

            //BtnArchiverEquipement.Visible = BtnAddEquipement.Visible = !bArchives;
            LoadDataContratAndTypeEquipement();
            LoadDataDetails();
        }

        private void PVTG_Details_MouseDown(object sender, MouseEventArgs e)
        {
            PivotGridControl pivotGrid = sender as PivotGridControl;
            if (pivotGrid == null) return;

            PivotGridHitInfo hitInfo = pivotGrid.CalcHitInfo(e.Location);

            if (hitInfo.HitTest == PivotGridHitTest.Cell)
            {
                PivotGridHitInfo cellInfo = hitInfo;
                
                if (cellInfo != null)
                {                    
                    colmunIndexSelected = cellInfo.CellInfo.ColumnIndex;
                    rowIndexSelected = cellInfo.CellInfo.RowIndex;

                }
            }
        }

        private void BtnAddEquipement_Click(object sender, EventArgs e)
        {
            new frmInventaireEquipementNew_SelectTypeEquipement_Client()
            {
                NCLINUM= nclinum,
                vclinom = vclinom

            }.ShowDialog();

            //si pas contrat a la base, alors on rafraichit la liste des contrats
            if (dt == null || dt.Rows.Count == 0) LoadDataContratAndTypeEquipement();

            LoadDataDetails();

        }

        private void BtnModifEquipement_Click(object sender, EventArgs e)
        {
            if (colmunIndexSelected == -1 | rowIndexSelected == -1)
            {
                MessageBox.Show("Il faut sélectionner un équipement", Program.AppTitle, MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                return;
            }

            DataRow DrUp = GVContratEquipement.GetDataRow(GVContratEquipement.FocusedRowHandle);

            //on récupère l'id 
            int NSITNUM = 0;
            int NSIT_INV_EQUIPEMENT_RECEIVE_ID = 0;
            string vsitnom = "";
            bool BEQUIPEMENT_A_CORRIGER = false;


            PivotDrillDownDataSource ds = PVTG_Details.CreateDrillDownDataSource(colmunIndexSelected, rowIndexSelected);
            if (ds == null) return;
            if (ds[0] == null) return;

            for (int i = 0; i < ds.RowCount; i++)
            {
                
                if ((int)ds.GetValue(i, "NSIT_INV_EQUIPEMENT_RECEIVE_ID") > 0) NSIT_INV_EQUIPEMENT_RECEIVE_ID = (int)ds.GetValue(i, "NSIT_INV_EQUIPEMENT_RECEIVE_ID");

                NSITNUM = (int)ds.GetValue(i, "NSITNUM");
                vsitnom = ds.GetValue(i, "VSITNOM").ToString();
                BEQUIPEMENT_A_CORRIGER = (bool)ds.GetValue(i, "BEQUIPEMENT_A_CORRIGER");

            }

            new frmInventaireEquipementDetails()
            {
                NSIT_INV_EQUIPEMENT_RECEIVE_ID = NSIT_INV_EQUIPEMENT_RECEIVE_ID,
                NSITNUM = NSITNUM,
                vsitnom = vsitnom,
                vclinom= vclinom,
                VTYPECONTRAT = DrUp == null ? "" : DrUp["VTYPECONTRAT"].ToString(),
                VLIBEQUIPEMENT = DrUp == null ? "" : DrUp["VLIBEQUIPEMENT"].ToString(),
                BEQUIPEMENT_A_CORRIGER = BEQUIPEMENT_A_CORRIGER
            }.ShowDialog();

            LoadDataDetails();
        }

        private void PVTG_Details_CustomAppearance(object sender, PivotCustomAppearanceEventArgs e)
        {
            PivotDrillDownDataSource ds = PVTG_Details.CreateDrillDownDataSource(colmunIndexSelected, rowIndexSelected);
            if (ds == null) return;
            if (ds[0] == null) return;

            bool BEQUIPEMENT_A_CORRIGER = false;

            for (int i = 0; i < ds.RowCount; i++)
            {
                BEQUIPEMENT_A_CORRIGER = (bool)ds.GetValue(i, "BEQUIPEMENT_A_CORRIGER");
            }
            e.Appearance.BackColor = BEQUIPEMENT_A_CORRIGER ? Color.Yellow : default(Color);
        }

        private void BtnExportXLS_Click(object sender, EventArgs e)
        {
            //on affiche la liste des sites a exporter
            List<int> LstInvSitesSelected = new List<int>();
            frmInventaireEquipement_Export_SelectSite ofrmInvSites = new frmInventaireEquipement_Export_SelectSite(LstInvSitesSelected, nclinum);                  
            ofrmInvSites.ShowDialog();
            if(ofrmInvSites.Cancel)
            {
                return;
            }

            if(ofrmInvSites.LstInvSitesSelected.Count == 0)
            {
                MessageBox.Show("Aucun site sélectionné pour l'export", Program.AppTitle, MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                return;
            }

            LstInvSitesSelected = ofrmInvSites.LstInvSitesSelected;

            //on affiche la liste des fiches a exporter
            List<int> LstFichesSelected = new List<int>();
            frmInventaireEquipement_Export_SelectFiche ofrmInvFiches = new frmInventaireEquipement_Export_SelectFiche(LstFichesSelected, LstInvSitesSelected);
            ofrmInvFiches.ShowDialog();
            if (ofrmInvFiches.Cancel)
            {
                return;
            }

            if (ofrmInvFiches.LstInvFicheSelected.Count == 0)
            {
                MessageBox.Show("Aucune fiche sélectionnée pour l'export", Program.AppTitle, MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                return;
            }


            LstFichesSelected = ofrmInvFiches.LstInvFicheSelected;

            if (MessageBox.Show("Voulez-vous exporter les données vers Excel ?", Program.AppTitle, MessageBoxButtons.YesNoCancel, MessageBoxIcon.Question) == DialogResult.Yes)
            {

                string sFileOut = "";
                SFD.FileName = "";
                SFD.Filter = "Fichiers EXCEL (*.xlsx)|*.xlsx";
                SFD.ShowDialog();
                sFileOut = SFD.FileName;
                if (sFileOut != "")
                {

                    Cursor.Current = Cursors.WaitCursor;
                    CInvEquipExportExcel FileExportXlsxInventaire = new CInvEquipExportExcel($@"{sFileOut}", LstFichesSelected, LstInvSitesSelected);
                    Cursor.Current = Cursors.Default;                    

                    if(MessageBox.Show("Export effectué avec succès. \r\nVoulez-vous ouvrir le fichier Excel ?", Program.AppTitle, MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
                    {
                        if (File.Exists(sFileOut))
                        {
                            Process.Start(sFileOut);
                        }
                        else
                        {
                            MessageBox.Show("Le fichier n'existe pas.", Program.AppTitle, MessageBoxButtons.OK, MessageBoxIcon.Error);
                        }
                    }                   

                }

                return;
            }            

        }
    }
}

