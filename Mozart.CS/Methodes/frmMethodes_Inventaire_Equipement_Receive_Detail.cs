using ADODB;
using DevExpress.CodeParser;
using DevExpress.Utils;
using DevExpress.XtraEditors;
using DevExpress.XtraEditors.Controls;
using DevExpress.XtraExport.Helpers;
using DevExpress.XtraGrid;
using DevExpress.XtraGrid.Columns;
using DevExpress.XtraGrid.Views.Grid;
using DevExpress.XtraPrinting;

using MozartNet;
using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Web.UI.WebControls;
using System.Windows.Forms;
using GridView = DevExpress.XtraGrid.Views.Grid.GridView;

namespace MozartCS
{
    public partial class frmMethodes_Inventaire_Equipement_Receive_Detail : Form
    {

        Int32 _NID_EQUIPEMENT_FICHE;              

        CEQUIPEMENT_FICHE oCEQUIPEMENT_FICHE;

        public frmMethodes_Inventaire_Equipement_Receive_Detail(Int32 c_NID_EQUIPEMENT_FICHE)
        {
            InitializeComponent();
            _NID_EQUIPEMENT_FICHE = c_NID_EQUIPEMENT_FICHE;
        }     

        private void BtnClose_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void frmMethodes_Inventaire_Equipement_Receive_Detail_Load(object sender, EventArgs e)
        {

            //INIT  
            ModuleMain.Initboutons(this);
            
            LoadData();
            LoadCbo();
        }

        private void LoadData()
        {
            oCEQUIPEMENT_FICHE = new CEQUIPEMENT_FICHE(_NID_EQUIPEMENT_FICHE);
            txtNID_EQUIPEMENT_FICHE_ITEM.Text = oCEQUIPEMENT_FICHE.NID_EQUIPEMENT_FICHE.ToString();
            txtNomFiche.Text = oCEQUIPEMENT_FICHE.VEQUIPEMENT_FICHE_LIB;
            ChkActif.Checked = oCEQUIPEMENT_FICHE.BEQUIPEMENT_FICHE_ACTIF;
            TxtInfoComplement.Text = oCEQUIPEMENT_FICHE.VINFOCOMPLEMENT;

            GCAdmin_Equipement_Fiche_Items.DataSource = oCEQUIPEMENT_FICHE.dtListeItems;

            GVAdmin_Equipement_Fiche_Items.ExpandAllGroups();

        }               

        private void LoadCbo()
        {

            //chargement des combo 
            //chapitre
            DataTable dtCboChapitres = new DataTable();
            dtCboChapitres.Load(ModuleData.ExecuteReader($"EXEC [api_sp_Equipement_Admin_Fiche_Chap_Liste] {_NID_EQUIPEMENT_FICHE}"));

            RepItemChapitre.DataSource = dtCboChapitres;
            RepItemChapitreView.SetAutoFilterValue(RepItemChapV_Col_BEQUIPEMENT_FICHE_CHAP_ACTIF, true, DevExpress.XtraGrid.Columns.AutoFilterCondition.Equals);

            //type de champ
            DataTable dtCboTypeChamp = new DataTable();
            dtCboTypeChamp.Load(ModuleData.ExecuteReader($"EXEC [api_sp_Equipement_Admin_Fiche_TypeChamp_Liste]"));

            RepItemTypeChamp.DataSource = dtCboTypeChamp;

            //liste parent
            DataTable dtCboListParent = new DataTable();
            dtCboListParent.Load(ModuleData.ExecuteReader($"EXEC api_sp_Equipement_Admin_Fiche_ListParent_Liste"));
            RepItemGLU_ListeParent.DataSource = dtCboListParent;

        }

        private void BtnExportXLSX_Click(object sender, EventArgs e)
        {

           // //onc créer un gridcontrol
           // GridControl grid = new GridControl();
           // grid.BindingContext = new System.Windows.Forms.BindingContext();
           // GridView gridview = new GridView();
           // grid.MainView = gridview;
           // gridview.GridControl = grid;
           // grid.ViewCollection.AddRange(new DevExpress.XtraGrid.Views.Base.BaseView[] {
           //gridview});

           // grid.DataSource = dtListeFiches;

           // grid.ForceInitialize();
           // gridview.PopulateColumns();

           // string filename = "Export_Liste_Equipement_Fiche_" + DateTime.Now.Day.ToString() + DateTime.Now.Month.ToString() + DateTime.Now.Year.ToString();

           // SFD.FileName = filename;

           // if (SFD.ShowDialog() == DialogResult.OK)
           // {
           //     if (SFD.FileName != "")
           //     {
           //         XlsxExportOptionsEx exportOptions = new XlsxExportOptionsEx();
           //         exportOptions.ExportType = DevExpress.Export.ExportType.WYSIWYG;                    
                  
           //         grid.ExportToXlsx(SFD.FileName, exportOptions);
           //     }
           // }

           // MessageBox.Show("Export EXCEL créé avec succès", "Information", MessageBoxButtons.OK, MessageBoxIcon.Information);

        }

        private void BtnSave_Click(object sender, EventArgs e)
        {
            if (oCEQUIPEMENT_FICHE == null) return;

            if (txtNomFiche.Text == "")
            {
                MessageBox.Show("Il faut saisir un libellé", "Erreur", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                return;
            }
           
            oCEQUIPEMENT_FICHE.VEQUIPEMENT_FICHE_LIB = txtNomFiche.Text;
            oCEQUIPEMENT_FICHE.BEQUIPEMENT_FICHE_ACTIF = ChkActif.Checked;    
            oCEQUIPEMENT_FICHE.VINFOCOMPLEMENT = TxtInfoComplement.Text;

            //vérification si champ avec type liste où le list parent n'est pas défini
            for (int i = 0; i < GVAdmin_Equipement_Fiche_Items.DataRowCount; i++)
            {

                //tets si chapitre saisie
                if (GVAdmin_Equipement_Fiche_Items.GetRowCellValue(i, "NID_EQUIPEMENT_FICHE_CHAP") != null 
                        && (int)GVAdmin_Equipement_Fiche_Items.GetRowCellValue(i, "NID_EQUIPEMENT_FICHE_CHAP") ==0)
                {
                    MessageBox.Show("Il faut sélectionner un chapitre pour chaque élément", "Erreur", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                    return;
                }

                if (GVAdmin_Equipement_Fiche_Items.GetRowCellValue(i, "VEQUIPEMENT_FICHE_ITEM_LIB") != null 
                    && GVAdmin_Equipement_Fiche_Items.GetRowCellValue(i, "VEQUIPEMENT_FICHE_ITEM_LIB").ToString() == "")
                {
                    MessageBox.Show("Il faut saisir un libellé pour chaque élément", "Erreur", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                    return;
                }

                if (GVAdmin_Equipement_Fiche_Items.GetRowCellValue(i, "NID_EQUIPEMENT_FICHE_TYPE_CHAMP") != null
                    && (int)GVAdmin_Equipement_Fiche_Items.GetRowCellValue(i, "NID_EQUIPEMENT_FICHE_TYPE_CHAMP") == 0)
                {
                    MessageBox.Show("Il faut sélectionner un type de champ pour chaque élément", "Erreur", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);

                    if (CEQUIPEMENT_FICHE_TYPE_CHAMP.LoadListeTypeChampInListe().Contains((int)GVAdmin_Equipement_Fiche_Items.GetRowCellValue(i, "NID_EQUIPEMENT_FICHE_TYPE_CHAMP")))                            
                    {

                        if(GVAdmin_Equipement_Fiche_Items.GetRowCellValue(i, "NID_EQUIPEMENT_FICHE_LIST_PARENT") != null
                                && (int)GVAdmin_Equipement_Fiche_Items.GetRowCellValue(i, "NID_EQUIPEMENT_FICHE_LIST_PARENT") == 0)
                        {
                            MessageBox.Show("Une liste de choix doit être sélectionnée pour les éléments avec un type de choix contenant une liste", "Erreur", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                            return;
                        }    
                    }
                    return;

                }


            }

            ////refresh
            //GVAdmin_Equipement_Fiche_Items.BeginUpdate();
            //int rowHandle = 0;
            //while (rowHandle < GVAdmin_Equipement_Fiche_Items.DataRowCount)
            //{
            //    DataRow Dr = GVAdmin_Equipement_Fiche_Items.GetDataRow(GVAdmin_Equipement_Fiche_Items.GetDataSourceRowIndex(rowHandle));

            //    Dr["NEQUIPEMENT_FICHE_ITEM_ORDER"] = rowHandle + 1;

            //    //oCEQUIPEMENT_FICHE.dtListeItems.Select($"[NID_EQUIPEMENT_FICHE_ITEM] = {Dr["NID_EQUIPEMENT_FICHE_ITEM"]}").FirstOrDefault()["NEQUIPEMENT_FICHE_ITEM_ORDER"] = rowHandle + 1;

            //    rowHandle++;
            //}
            //GVAdmin_Equipement_Fiche_Items.EndUpdate();
            //GVAdmin_Equipement_Fiche_Items.RefreshData();

            oCEQUIPEMENT_FICHE.Save();

            _NID_EQUIPEMENT_FICHE = oCEQUIPEMENT_FICHE.NID_EQUIPEMENT_FICHE;
            txtNID_EQUIPEMENT_FICHE_ITEM.Text = oCEQUIPEMENT_FICHE.NID_EQUIPEMENT_FICHE.ToString();

            LoadData();

        }

        private void SortRefresh()
        {

            //GVAdmin_Equipement_Fiche_Items.SortInfo.ClearAndAddRange(new[] {
            //                                                                new GridColumnSortInfo(G_Col_NEQUIPEMENT_FICHE_CHAP_ORDER_AFFICH, DevExpress.Data.ColumnSortOrder.Ascending),
            //                                                                new GridColumnSortInfo(G_Col_NEQUIPEMENT_FICHE_ITEM_ORDER, DevExpress.Data.ColumnSortOrder.Ascending)
            //                                                                });

            //oCEQUIPEMENT_FICHE.dtListeItems.DefaultView.Sort = "NEQUIPEMENT_FICHE_CHAP_ORDER_AFFICH, NEQUIPEMENT_FICHE_ITEM_ORDER";
            // GVAdmin_Equipement_Fiche_Items.SortInfo.ClearSorting();
            //GVAdmin_Equipement_Fiche_Items.SortInfo.ClearAndAddRange(new DevExpress.XtraGrid.Columns.GridColumnSortInfo[] {
            //new DevExpress.XtraGrid.Columns.GridColumnSortInfo(G_Col_NEQUIPEMENT_FICHE_CHAP_ORDER_AFFICH, DevExpress.Data.ColumnSortOrder.Ascending),
            //new DevExpress.XtraGrid.Columns.GridColumnSortInfo(G_Col_NEQUIPEMENT_FICHE_ITEM_ORDER, DevExpress.Data.ColumnSortOrder.Ascending)});

            //G_Col_NID_EQUIPEMENT_FICHE_CHAP_GrpRow.GroupIndex = 0;  

            //    G_Col_NEQUIPEMENT_FICHE_CHAP_ORDER_AFFICH.SortOrder = DevExpress.Data.ColumnSortOrder.Ascending;
            //G_Col_NEQUIPEMENT_FICHE_ITEM_ORDER.SortOrder = DevExpress.Data.ColumnSortOrder.Ascending;
            //GVAdmin_Equipement_Fiche_Items.RefreshData();
            GVAdmin_Equipement_Fiche_Items.PostEditor();

        }

        private void BtnGestionChapitreByFiche_Click(object sender, EventArgs e)
        {
            
            if (oCEQUIPEMENT_FICHE.NID_EQUIPEMENT_FICHE == 0)
            {
                MessageBox.Show("Il faut sélectionner créer la fiche", "Erreur", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                return;
            }

            //test s'il y a des modificarions encours, si oui, il faudra les enregistrer
            if(oCEQUIPEMENT_FICHE.dtListeItems != null && oCEQUIPEMENT_FICHE.dtListeItems.GetChanges() != null && oCEQUIPEMENT_FICHE.dtListeItems.GetChanges().Rows.Count > 0)
            {
                if(MessageBox.Show("Il faut enregistrer les modifications", "Confirmation", MessageBoxButtons.YesNoCancel, MessageBoxIcon.Exclamation) == DialogResult.Yes)
                {
                    BtnSave.PerformClick();
                }
                else
                { return; }
            }

            frmMethodes_Admin_Equipement_Fiche_Chap ofrmMethodes_Admin_Equipement_Fiche_Chap = new frmMethodes_Admin_Equipement_Fiche_Chap(oCEQUIPEMENT_FICHE.NID_EQUIPEMENT_FICHE, txtNomFiche.Text);
            ofrmMethodes_Admin_Equipement_Fiche_Chap.ShowDialog();

            LoadCbo();

            LoadData();


        }

        private void BtnEquipFicheItemNew_Click(object sender, EventArgs e)
        {

            DataRow oNR = oCEQUIPEMENT_FICHE.dtListeItems.NewRow();
            oNR["NID_EQUIPEMENT_FICHE_ITEM"] = 0;
            oNR["NID_EQUIPEMENT_FICHE_CHAP"] = 0; 
            oNR["NID_EQUIPEMENT_FICHE_TYPE_CHAMP"] = 0;
            oNR["NID_EQUIPEMENT_FICHE_LIST_PARENT"] = 0;
            oNR["VEQUIPEMENT_FICHE_ITEM_LIB"] = "";
            oNR["NEQUIPEMENT_FICHE_ITEM_ORDER"] = GVAdmin_Equipement_Fiche_Items.DataRowCount + 1;
            oNR["BEQUIPEMENT_FICHE_ITEM_ACTIF"] = true;
            oNR["NID_EQUIPEMENT_FICHE"] = oCEQUIPEMENT_FICHE.NID_EQUIPEMENT_FICHE;
            oNR["BEQUIPEMENT_FICHE_ITEM_OBLIG"] = false;

            oCEQUIPEMENT_FICHE.dtListeItems.Rows.Add(oNR);

            GVAdmin_Equipement_Fiche_Items.ExpandMasterRow(GVAdmin_Equipement_Fiche_Items.FocusedRowHandle, 0);
            GVAdmin_Equipement_Fiche_Items.PostEditor();

        }

        private void BtnGestListeParent_Click(object sender, EventArgs e)
        {

            frmMethodes_Admin_Equipement_Fiche_ListParent ofrmMethodes_Admin_Equipement_Fiche_ListParent = new frmMethodes_Admin_Equipement_Fiche_ListParent();
            ofrmMethodes_Admin_Equipement_Fiche_ListParent.ShowDialog();

            LoadCbo();

        }

        private void BtnSupprimer_Click(object sender, EventArgs e)
        {
            DataRow currentRow = GVAdmin_Equipement_Fiche_Items.GetFocusedDataRow();
            if (null == currentRow)
            {
                MessageBox.Show("Il faut sélectionner un élément", "Erreur", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                return;
            }
            //on teste si l item de la liste est utilisé
            //on test car on ne peux pas supprimer le type 10 et 11
            if (CEQUIPEMENT_FICHE_TYPE_CHAMP.ListTypeChampObligatoire().Contains((int)currentRow["NTYPE_CHAMP"]))
            {
                MessageBox.Show("Suppression interdite car ce type de champ est obligatoire", "Erreur", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                return;
            }

            if (MessageBox.Show("Voulez-vous supprimer cet élément ?", "Confirmation", MessageBoxButtons.YesNoCancel, MessageBoxIcon.Question) == DialogResult.Yes)
            {
                currentRow.Delete();

            }
        }

        private void GVAdmin_Equipement_Fiche_Items_CustomRowCellEdit(object sender, CustomRowCellEditEventArgs e)
        {
            DevExpress.XtraGrid.Views.Grid.GridView view = sender as DevExpress.XtraGrid.Views.Grid.GridView;
            if (null == view) return;
            if (e.RowHandle < 0) return;
            if (e.Column.Name == "G_Col_CboListParent")            {

                //Console.WriteLine((string)view.GetRowCellValue(e.RowHandle, "VEQUIPEMENT_FICHE_ITEM_LIB") + " - " + view.GetRowCellValue(e.RowHandle, "NID_EQUIPEMENT_FICHE_TYPE_CHAMP").ToString());
                                
                if (CEQUIPEMENT_FICHE_TYPE_CHAMP.LoadListeTypeChampInListe().Contains((int)view.GetRowCellValue(e.RowHandle, "NID_EQUIPEMENT_FICHE_TYPE_CHAMP")))
                {                   
                    e.RepositoryItem = RepItemGLU_ListeParent;                    
                }
                return;            
            }
            if (e.Column.Name == "G_Col_NID_EQUIPEMENT_FICHE_TYPE_CHAMP")
            {

                //Console.WriteLine((string)view.GetRowCellValue(e.RowHandle, "VEQUIPEMENT_FICHE_ITEM_LIB") + " - " + view.GetRowCellValue(e.RowHandle, "NID_EQUIPEMENT_FICHE_TYPE_CHAMP").ToString());

                if (CEQUIPEMENT_FICHE_TYPE_CHAMP.ListTypeChampObligatoire().Contains((int)view.GetRowCellValue(e.RowHandle, "NID_EQUIPEMENT_FICHE_TYPE_CHAMP")))
                {
                    e.RepositoryItem = repositoryItemTextEdit_TypeChamp;
                }
                else
                {
                    e.RepositoryItem = RepItemTypeChamp;
                }
                return;

            }

        }

        private void txtNID_EQUIPEMENT_FICHE_ITEM_TextChanged(object sender, EventArgs e)
        {
            if (txtNID_EQUIPEMENT_FICHE_ITEM.Text == "0") txtNID_EQUIPEMENT_FICHE_ITEM.Text = "";
        }

        private void BtnRowUp_Click(object sender, EventArgs e)
        {
            DevExpress.XtraGrid.Views.Grid.GridView view = GVAdmin_Equipement_Fiche_Items;

            int index = view.FocusedRowHandle;
            if (index <= 0) return;

            DataRow row_selected_to_up = view.GetDataRow(index);
            DataRow row_to_down_by_up = view.GetDataRow(index - 1);
            DataRow row_Save_inter = SaveDrToUpandDown(row_to_down_by_up);

            //on récupère l id du chapitre pour récuperer son plus petit order
            if((int)row_to_down_by_up["NID_EQUIPEMENT_FICHE_CHAP"] != (int)row_selected_to_up["NID_EQUIPEMENT_FICHE_CHAP"])
            {
                //Console.Write(oCEQUIPEMENT_FICHE.dtListeItems.Select($"[NID_EQUIPEMENT_FICHE_CHAP] = {row_selected_to_up["NID_EQUIPEMENT_FICHE_CHAP"]}").Min(Id_chap => Id_chap.Field<int>("NEQUIPEMENT_FICHE_ITEM_ORDER")));
                MessageBox.Show("Vous ne pouvez pas remonter ce champ car vous avez atteint le début du chapitre", "Erreur", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                return;
            }

            //DataRow row_inter = row1;
            object idx_row_selected_to_up = row_selected_to_up["NEQUIPEMENT_FICHE_ITEM_ORDER"];
            object idx_row_idx_to_down_by_up = row_to_down_by_up["NEQUIPEMENT_FICHE_ITEM_ORDER"];

            row_to_down_by_up["NID_EQUIPEMENT_FICHE_ITEM"] = row_selected_to_up["NID_EQUIPEMENT_FICHE_ITEM"];
            row_to_down_by_up["NID_EQUIPEMENT_FICHE_CHAP"] = row_selected_to_up["NID_EQUIPEMENT_FICHE_CHAP"];
            row_to_down_by_up["NID_EQUIPEMENT_FICHE_TYPE_CHAMP"] = row_selected_to_up["NID_EQUIPEMENT_FICHE_TYPE_CHAMP"];
            row_to_down_by_up["NID_EQUIPEMENT_FICHE_LIST_PARENT"] = row_selected_to_up["NID_EQUIPEMENT_FICHE_LIST_PARENT"];
            row_to_down_by_up["VEQUIPEMENT_FICHE_ITEM_LIB"] = row_selected_to_up["VEQUIPEMENT_FICHE_ITEM_LIB"];
            row_to_down_by_up["BEQUIPEMENT_FICHE_ITEM_ACTIF"] = row_selected_to_up["BEQUIPEMENT_FICHE_ITEM_ACTIF"];
            row_to_down_by_up["NID_EQUIPEMENT_FICHE"] = row_selected_to_up["NID_EQUIPEMENT_FICHE"];
            row_to_down_by_up["BEQUIPEMENT_FICHE_ITEM_OBLIG"] = row_selected_to_up["BEQUIPEMENT_FICHE_ITEM_OBLIG"];          
            row_to_down_by_up["NEQUIPEMENT_FICHE_CHAP_ORDER_AFFICH"] = row_selected_to_up["NEQUIPEMENT_FICHE_CHAP_ORDER_AFFICH"];
            row_to_down_by_up["NEQUIPEMENT_FICHE_ITEM_ORDER"] = idx_row_idx_to_down_by_up;

            row_selected_to_up["NID_EQUIPEMENT_FICHE_ITEM"] = row_Save_inter["NID_EQUIPEMENT_FICHE_ITEM"];
            row_selected_to_up["NID_EQUIPEMENT_FICHE_CHAP"] = row_Save_inter["NID_EQUIPEMENT_FICHE_CHAP"];
            row_selected_to_up["NID_EQUIPEMENT_FICHE_TYPE_CHAMP"] = row_Save_inter["NID_EQUIPEMENT_FICHE_TYPE_CHAMP"];
            row_selected_to_up["NID_EQUIPEMENT_FICHE_LIST_PARENT"] = row_Save_inter["NID_EQUIPEMENT_FICHE_LIST_PARENT"];
            row_selected_to_up["VEQUIPEMENT_FICHE_ITEM_LIB"] = row_Save_inter["VEQUIPEMENT_FICHE_ITEM_LIB"];
            row_selected_to_up["BEQUIPEMENT_FICHE_ITEM_ACTIF"] = row_Save_inter["BEQUIPEMENT_FICHE_ITEM_ACTIF"];
            row_selected_to_up["NID_EQUIPEMENT_FICHE"] = row_Save_inter["NID_EQUIPEMENT_FICHE"];
            row_selected_to_up["BEQUIPEMENT_FICHE_ITEM_OBLIG"] = row_Save_inter["BEQUIPEMENT_FICHE_ITEM_OBLIG"];
            row_selected_to_up["NEQUIPEMENT_FICHE_CHAP_ORDER_AFFICH"] = row_selected_to_up["NEQUIPEMENT_FICHE_CHAP_ORDER_AFFICH"];
            row_selected_to_up["NEQUIPEMENT_FICHE_ITEM_ORDER"] = idx_row_selected_to_up;

            view.FocusedRowHandle = index - 1;

            view.SetRowCellValue(index, G_L0_Col_NID_EQUIPEMENT_FICHE_ITEM, row_selected_to_up["NID_EQUIPEMENT_FICHE_ITEM"]);
            view.SetRowCellValue(index - 1, G_L0_Col_NID_EQUIPEMENT_FICHE_ITEM, row_to_down_by_up["NID_EQUIPEMENT_FICHE_ITEM"]);

            view.SetRowCellValue(index, G_Col_NID_EQUIPEMENT_FICHE_CHAP, row_selected_to_up["NID_EQUIPEMENT_FICHE_CHAP"]);
            view.SetRowCellValue(index - 1, G_Col_NID_EQUIPEMENT_FICHE_CHAP, row_to_down_by_up["NID_EQUIPEMENT_FICHE_CHAP"]);

            view.SetRowCellValue(index, G_Col_NID_EQUIPEMENT_FICHE_TYPE_CHAMP, row_selected_to_up["NID_EQUIPEMENT_FICHE_TYPE_CHAMP"]);
            view.SetRowCellValue(index - 1, G_Col_NID_EQUIPEMENT_FICHE_TYPE_CHAMP, row_to_down_by_up["NID_EQUIPEMENT_FICHE_TYPE_CHAMP"]);

            view.SetRowCellValue(index, G_Col_RepItem_V_NID_EQUIPEMENT_FICHE_LIST_PARENT, row_selected_to_up["NID_EQUIPEMENT_FICHE_LIST_PARENT"]);
            view.SetRowCellValue(index - 1, G_Col_RepItem_V_NID_EQUIPEMENT_FICHE_LIST_PARENT, row_to_down_by_up["NID_EQUIPEMENT_FICHE_LIST_PARENT"]);

            view.SetRowCellValue(index, G_L0_Col_VEQUIPEMENT_FICHE_ITEM_LIB, row_selected_to_up["VEQUIPEMENT_FICHE_ITEM_LIB"]);
            view.SetRowCellValue(index - 1, G_L0_Col_VEQUIPEMENT_FICHE_ITEM_LIB, row_to_down_by_up["VEQUIPEMENT_FICHE_ITEM_LIB"]);

            view.SetRowCellValue(index, G_Col_BEQUIPEMENT_FICHE_ITEM_ACTIF, row_selected_to_up["BEQUIPEMENT_FICHE_ITEM_ACTIF"]);
            view.SetRowCellValue(index - 1, G_Col_BEQUIPEMENT_FICHE_ITEM_ACTIF, row_to_down_by_up["BEQUIPEMENT_FICHE_ITEM_ACTIF"]);

            view.SetRowCellValue(index, G_Col_NID_EQUIPEMENT_FICHE, row_selected_to_up["NID_EQUIPEMENT_FICHE"]);
            view.SetRowCellValue(index - 1, G_Col_NID_EQUIPEMENT_FICHE, row_to_down_by_up["NID_EQUIPEMENT_FICHE"]);

            view.SetRowCellValue(index, G_COl_BEQUIPEMENT_FICHE_ITEM_OBLIG, row_selected_to_up["BEQUIPEMENT_FICHE_ITEM_OBLIG"]);
            view.SetRowCellValue(index - 1, G_COl_BEQUIPEMENT_FICHE_ITEM_OBLIG, row_to_down_by_up["BEQUIPEMENT_FICHE_ITEM_OBLIG"]);

            view.SetRowCellValue(index, G_Col_NEQUIPEMENT_FICHE_CHAP_ORDER_AFFICH, row_selected_to_up["NEQUIPEMENT_FICHE_CHAP_ORDER_AFFICH"]);
            view.SetRowCellValue(index - 1, G_Col_NEQUIPEMENT_FICHE_CHAP_ORDER_AFFICH, row_to_down_by_up["NEQUIPEMENT_FICHE_CHAP_ORDER_AFFICH"]);

            view.SetRowCellValue(index, G_Col_NEQUIPEMENT_FICHE_ITEM_ORDER, idx_row_selected_to_up);
            view.SetRowCellValue(index - 1, G_Col_NEQUIPEMENT_FICHE_ITEM_ORDER, idx_row_idx_to_down_by_up);

            //GVAdmin_Equipement_Fiche_Items.RefreshData();
            //GVAdmin_Equipement_Fiche_Items.PostEditor();
            //view.UpdateCurrentRow();
            //view.RefreshData();
            //view.PostEditor();
        }

        private void BtnRowDown_Click(object sender, EventArgs e)
        {            
            DevExpress.XtraGrid.Views.Grid.GridView view = GVAdmin_Equipement_Fiche_Items;

            int index = view.FocusedRowHandle;
            
            DataRow row_selected_to_down = view.GetDataRow(index);
            DataRow row_to_up_by_down = view.GetDataRow(index + 1);
            DataRow row_Save_inter = SaveDrToUpandDown(row_to_up_by_down);

            //on récupère l id du chapitre 
            if (row_to_up_by_down == null || (int)row_to_up_by_down["NID_EQUIPEMENT_FICHE_CHAP"] != (int)row_selected_to_down["NID_EQUIPEMENT_FICHE_CHAP"])
            {
                //Console.Write(oCEQUIPEMENT_FICHE.dtListeItems.Select($"[NID_EQUIPEMENT_FICHE_CHAP] = {row_selected_to_up["NID_EQUIPEMENT_FICHE_CHAP"]}").Min(Id_chap => Id_chap.Field<int>("NEQUIPEMENT_FICHE_ITEM_ORDER")));
                MessageBox.Show("Vous ne pouvez pas remonter ce champ car vous avez atteint la fin du chapitre", "Erreur", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                return;
            }

            //DataRow row_inter = row1;
            object idx_row_selected_to_down = row_selected_to_down["NEQUIPEMENT_FICHE_ITEM_ORDER"];
            object idx_row_idx_to_up_by_down = row_to_up_by_down["NEQUIPEMENT_FICHE_ITEM_ORDER"];

            row_to_up_by_down["NID_EQUIPEMENT_FICHE_ITEM"] = row_selected_to_down["NID_EQUIPEMENT_FICHE_ITEM"];
            row_to_up_by_down["NID_EQUIPEMENT_FICHE_CHAP"] = row_selected_to_down["NID_EQUIPEMENT_FICHE_CHAP"];
            row_to_up_by_down["NID_EQUIPEMENT_FICHE_TYPE_CHAMP"] = row_selected_to_down["NID_EQUIPEMENT_FICHE_TYPE_CHAMP"];
            row_to_up_by_down["NID_EQUIPEMENT_FICHE_LIST_PARENT"] = row_selected_to_down["NID_EQUIPEMENT_FICHE_LIST_PARENT"];
            row_to_up_by_down["VEQUIPEMENT_FICHE_ITEM_LIB"] = row_selected_to_down["VEQUIPEMENT_FICHE_ITEM_LIB"];
            row_to_up_by_down["BEQUIPEMENT_FICHE_ITEM_ACTIF"] = row_selected_to_down["BEQUIPEMENT_FICHE_ITEM_ACTIF"];
            row_to_up_by_down["NID_EQUIPEMENT_FICHE"] = row_selected_to_down["NID_EQUIPEMENT_FICHE"];
            row_to_up_by_down["BEQUIPEMENT_FICHE_ITEM_OBLIG"] = row_selected_to_down["BEQUIPEMENT_FICHE_ITEM_OBLIG"];
            row_to_up_by_down["NEQUIPEMENT_FICHE_CHAP_ORDER_AFFICH"] = row_selected_to_down["NEQUIPEMENT_FICHE_CHAP_ORDER_AFFICH"];
            row_to_up_by_down["NEQUIPEMENT_FICHE_ITEM_ORDER"] = idx_row_idx_to_up_by_down;

            row_selected_to_down["NID_EQUIPEMENT_FICHE_ITEM"] = row_Save_inter["NID_EQUIPEMENT_FICHE_ITEM"];
            row_selected_to_down["NID_EQUIPEMENT_FICHE_CHAP"] = row_Save_inter["NID_EQUIPEMENT_FICHE_CHAP"];
            row_selected_to_down["NID_EQUIPEMENT_FICHE_TYPE_CHAMP"] = row_Save_inter["NID_EQUIPEMENT_FICHE_TYPE_CHAMP"];
            row_selected_to_down["NID_EQUIPEMENT_FICHE_LIST_PARENT"] = row_Save_inter["NID_EQUIPEMENT_FICHE_LIST_PARENT"];
            row_selected_to_down["VEQUIPEMENT_FICHE_ITEM_LIB"] = row_Save_inter["VEQUIPEMENT_FICHE_ITEM_LIB"];
            row_selected_to_down["BEQUIPEMENT_FICHE_ITEM_ACTIF"] = row_Save_inter["BEQUIPEMENT_FICHE_ITEM_ACTIF"];
            row_selected_to_down["NID_EQUIPEMENT_FICHE"] = row_Save_inter["NID_EQUIPEMENT_FICHE"];
            row_selected_to_down["BEQUIPEMENT_FICHE_ITEM_OBLIG"] = row_Save_inter["BEQUIPEMENT_FICHE_ITEM_OBLIG"];
            row_selected_to_down["NEQUIPEMENT_FICHE_CHAP_ORDER_AFFICH"] = row_Save_inter["NEQUIPEMENT_FICHE_CHAP_ORDER_AFFICH"];
            row_selected_to_down["NEQUIPEMENT_FICHE_ITEM_ORDER"] = idx_row_selected_to_down;

            view.FocusedRowHandle = index + 1;

            view.SetRowCellValue(index, G_L0_Col_NID_EQUIPEMENT_FICHE_ITEM, row_selected_to_down["NID_EQUIPEMENT_FICHE_ITEM"]);
            view.SetRowCellValue(index + 1, G_L0_Col_NID_EQUIPEMENT_FICHE_ITEM, row_to_up_by_down["NID_EQUIPEMENT_FICHE_ITEM"]);

            view.SetRowCellValue(index, G_Col_NID_EQUIPEMENT_FICHE_CHAP, row_selected_to_down["NID_EQUIPEMENT_FICHE_CHAP"]);
            view.SetRowCellValue(index + 1, G_Col_NID_EQUIPEMENT_FICHE_CHAP, row_to_up_by_down["NID_EQUIPEMENT_FICHE_CHAP"]);          

            view.SetRowCellValue(index, G_Col_NID_EQUIPEMENT_FICHE_TYPE_CHAMP, row_selected_to_down["NID_EQUIPEMENT_FICHE_TYPE_CHAMP"]);
            view.SetRowCellValue(index + 1, G_Col_NID_EQUIPEMENT_FICHE_TYPE_CHAMP, row_to_up_by_down["NID_EQUIPEMENT_FICHE_TYPE_CHAMP"]);

            view.SetRowCellValue(index, G_Col_RepItem_V_NID_EQUIPEMENT_FICHE_LIST_PARENT, row_selected_to_down["NID_EQUIPEMENT_FICHE_LIST_PARENT"]);
            view.SetRowCellValue(index + 1, G_Col_RepItem_V_NID_EQUIPEMENT_FICHE_LIST_PARENT, row_to_up_by_down["NID_EQUIPEMENT_FICHE_LIST_PARENT"]);

            view.SetRowCellValue(index, G_L0_Col_VEQUIPEMENT_FICHE_ITEM_LIB, row_selected_to_down["VEQUIPEMENT_FICHE_ITEM_LIB"]);
            view.SetRowCellValue(index + 1, G_L0_Col_VEQUIPEMENT_FICHE_ITEM_LIB, row_to_up_by_down["VEQUIPEMENT_FICHE_ITEM_LIB"]);

            view.SetRowCellValue(index, G_Col_BEQUIPEMENT_FICHE_ITEM_ACTIF, row_selected_to_down["BEQUIPEMENT_FICHE_ITEM_ACTIF"]);
            view.SetRowCellValue(index + 1, G_Col_BEQUIPEMENT_FICHE_ITEM_ACTIF, row_to_up_by_down["BEQUIPEMENT_FICHE_ITEM_ACTIF"]);

            view.SetRowCellValue(index, G_Col_NID_EQUIPEMENT_FICHE, row_selected_to_down["NID_EQUIPEMENT_FICHE"]);
            view.SetRowCellValue(index + 1, G_Col_NID_EQUIPEMENT_FICHE, row_to_up_by_down["NID_EQUIPEMENT_FICHE"]);

            view.SetRowCellValue(index, G_COl_BEQUIPEMENT_FICHE_ITEM_OBLIG, row_selected_to_down["BEQUIPEMENT_FICHE_ITEM_OBLIG"]);
            view.SetRowCellValue(index + 1, G_COl_BEQUIPEMENT_FICHE_ITEM_OBLIG, row_to_up_by_down["BEQUIPEMENT_FICHE_ITEM_OBLIG"]);

            view.SetRowCellValue(index, G_Col_NEQUIPEMENT_FICHE_CHAP_ORDER_AFFICH, row_selected_to_down["NEQUIPEMENT_FICHE_CHAP_ORDER_AFFICH"]);
            view.SetRowCellValue(index + 1, G_Col_NEQUIPEMENT_FICHE_CHAP_ORDER_AFFICH, row_to_up_by_down["NEQUIPEMENT_FICHE_CHAP_ORDER_AFFICH"]);

            view.SetRowCellValue(index, G_Col_NEQUIPEMENT_FICHE_ITEM_ORDER, idx_row_selected_to_down);
            view.SetRowCellValue(index + 1, G_Col_NEQUIPEMENT_FICHE_ITEM_ORDER, idx_row_idx_to_up_by_down);

            //GVAdmin_Equipement_Fiche_Items.RefreshData();

            //view.UpdateCurrentRow();

            //view.PostEditor();

            //SortRefresh();
        }
        private DataRow SaveDrToUpandDown(DataRow Dr_toSave)
        {

            if (Dr_toSave == null) return null;


            DataTable Dt_tmp = new DataTable();
            Dt_tmp.Columns.Add("NID_EQUIPEMENT_FICHE_ITEM", typeof(int));
            Dt_tmp.Columns.Add("NID_EQUIPEMENT_FICHE_CHAP", typeof(int));
            Dt_tmp.Columns.Add("NID_EQUIPEMENT_FICHE_TYPE_CHAMP", typeof(int));
            Dt_tmp.Columns.Add("NID_EQUIPEMENT_FICHE_LIST_PARENT", typeof(int));
            Dt_tmp.Columns.Add("VEQUIPEMENT_FICHE_ITEM_LIB", typeof(string));
            Dt_tmp.Columns.Add("BEQUIPEMENT_FICHE_ITEM_ACTIF", typeof(bool));
            Dt_tmp.Columns.Add("NID_EQUIPEMENT_FICHE", typeof(int));
            Dt_tmp.Columns.Add("BEQUIPEMENT_FICHE_ITEM_OBLIG", typeof(bool));
            Dt_tmp.Columns.Add("NEQUIPEMENT_FICHE_ITEM_ORDER", typeof(int));
            Dt_tmp.Columns.Add("NEQUIPEMENT_FICHE_CHAP_ORDER_AFFICH", typeof(int));

            DataRow dr = Dt_tmp.NewRow();
            dr["NID_EQUIPEMENT_FICHE_ITEM"] = Dr_toSave["NID_EQUIPEMENT_FICHE_ITEM"];
            dr["NID_EQUIPEMENT_FICHE_CHAP"] = Dr_toSave["NID_EQUIPEMENT_FICHE_CHAP"];
            dr["NID_EQUIPEMENT_FICHE_TYPE_CHAMP"] = Dr_toSave["NID_EQUIPEMENT_FICHE_TYPE_CHAMP"];
            dr["NID_EQUIPEMENT_FICHE_LIST_PARENT"] = Dr_toSave["NID_EQUIPEMENT_FICHE_LIST_PARENT"];
            dr["VEQUIPEMENT_FICHE_ITEM_LIB"] = Dr_toSave["VEQUIPEMENT_FICHE_ITEM_LIB"];
            dr["BEQUIPEMENT_FICHE_ITEM_ACTIF"] = Dr_toSave["BEQUIPEMENT_FICHE_ITEM_ACTIF"];
            dr["NID_EQUIPEMENT_FICHE"] = Dr_toSave["NID_EQUIPEMENT_FICHE"];
            dr["BEQUIPEMENT_FICHE_ITEM_OBLIG"] = Dr_toSave["BEQUIPEMENT_FICHE_ITEM_OBLIG"];
            dr["NEQUIPEMENT_FICHE_ITEM_ORDER"] = Dr_toSave["NEQUIPEMENT_FICHE_ITEM_ORDER"];
            dr["NEQUIPEMENT_FICHE_CHAP_ORDER_AFFICH"] = Dr_toSave["NEQUIPEMENT_FICHE_CHAP_ORDER_AFFICH"];
            return dr;
        }

        private void GVAdmin_Equipement_Fiche_Items_CustomColumnDisplayText(object sender, DevExpress.XtraGrid.Views.Base.CustomColumnDisplayTextEventArgs e)
        {
            GridView view = sender as GridView;
            if (view == null) return;
            if (e.Column.FieldName == "NID_EQUIPEMENT_FICHE_LIST_PARENT" && e.Value != DBNull.Value && (int?)e.Value == 0)
            {
                e.DisplayText = "";
                return;
            }
            if (e.Column.FieldName == "NEQUIPEMENT_FICHE_CHAP_ORDER_AFFICH" && e.IsForGroupRow)
            {

                if (view.GetGroupRowValue(e.GroupRowHandle, e.Column) != DBNull.Value)
                {

                    int rowValue = Convert.ToInt32(view.GetGroupRowValue(e.GroupRowHandle, e.Column));
                    int NID_EQUIPEMENT_FICHE_CHAP = (int)view.GetListSourceRowCellValue(e.ListSourceRowIndex, "NID_EQUIPEMENT_FICHE_CHAP");

                    string chapterName = CEQUIPEMENT_CHAPITRE.GetChapterName(NID_EQUIPEMENT_FICHE_CHAP);

                    if (chapterName == "")
                    {
                        e.DisplayText = $"(Pas de chapitre sélectionné)";
                    }
                    else
                    {
                        e.DisplayText = $"N° {rowValue} : {chapterName}";
                    }

                }
                return;
            }
            if (e.Column.FieldName == "NID_EQUIPEMENT_FICHE_TYPE_CHAMP" && e.Value != DBNull.Value
                    && CEQUIPEMENT_FICHE_TYPE_CHAMP.ListTypeChampObligatoire().Contains((int)e.Value))
            {
                e.DisplayText = $"{CEQUIPEMENT_FICHE_TYPE_CHAMP.GetLibelle((int)e.Value)} (Obligatoire)";
                return;
            }
        }

        private void GVAdmin_Equipement_Fiche_Items_ShowingEditor(object sender, System.ComponentModel.CancelEventArgs e)
        {
            GridView view = sender as GridView;
            if (view == null) return;

            //si editor n'est pas une liste gridlookupedit alors on rend la cell not editable
            if(GVAdmin_Equipement_Fiche_Items.FocusedColumn.FieldName == "NID_EQUIPEMENT_FICHE_LIST_PARENT" &&
                !CEQUIPEMENT_FICHE_TYPE_CHAMP.LoadListeTypeChampInListe().Contains((int)view.GetRowCellValue(GVAdmin_Equipement_Fiche_Items.FocusedRowHandle, "NID_EQUIPEMENT_FICHE_TYPE_CHAMP")
                )
            )
            {
                e.Cancel= true;
                return;
            }
            //si editor n'est pas une liste gridlookupedit alors on rend la cell not editable
            if (GVAdmin_Equipement_Fiche_Items.FocusedColumn.FieldName == "NID_EQUIPEMENT_FICHE_TYPE_CHAMP" &&
                CEQUIPEMENT_FICHE_TYPE_CHAMP.ListTypeChampObligatoire().Contains((int)view.GetRowCellValue(GVAdmin_Equipement_Fiche_Items.FocusedRowHandle, "NID_EQUIPEMENT_FICHE_TYPE_CHAMP")
                )
            )
            {
                e.Cancel = true;
                return;
            }
        }

        private void GVAdmin_Equipement_Fiche_Items_CellValueChanged(object sender, DevExpress.XtraGrid.Views.Base.CellValueChangedEventArgs e)
        {
            GridView view = sender as GridView;
            if (view == null) return;
            //si changement dans le type de champ, alors on initialise le champ listparent
            if (e.Column.FieldName == "NID_EQUIPEMENT_FICHE_TYPE_CHAMP" && e.Value != DBNull.Value &&
                        !CEQUIPEMENT_FICHE_TYPE_CHAMP.LoadListeTypeChampInListe().Contains((int)e.Value))
            {
                view.SetRowCellValue(e.RowHandle, "NID_EQUIPEMENT_FICHE_LIST_PARENT", 0);
                GVAdmin_Equipement_Fiche_Items.PostEditor();
                GVAdmin_Equipement_Fiche_Items.UpdateCurrentRow();
                return;
            }

            //if (e.Column.FieldName == "NEQUIPEMENT_FICHE_ITEM_ORDER" && e.Value != DBNull.Value)
            //{
            //    view.SetRowCellValue(e.RowHandle, "NEQUIPEMENT_FICHE_ITEM_ORDER", e.Value);
            //}

        }

        private void RepItemTypeChamp_EditValueChanged(object sender, EventArgs e)
        {
            if (GVAdmin_Equipement_Fiche_Items.PostEditor())
                GVAdmin_Equipement_Fiche_Items.UpdateCurrentRow();
        }

        private void GVAdmin_Equipement_Fiche_Items_CustomDrawCell(object sender, DevExpress.XtraGrid.Views.Base.RowCellCustomDrawEventArgs e)
        {
            GridView view = sender as GridView;
            //int dataSourceRowIndex = view.GetDataSourceRowIndex(e.RowHandle);
            if (e.Column.FieldName == "NID_EQUIPEMENT_FICHE_TYPE_CHAMP")
            {   
                if(CEQUIPEMENT_FICHE_TYPE_CHAMP.ListTypeChampObligatoire().Contains((int)e.CellValue))
                { e.DisplayText = $"{CEQUIPEMENT_FICHE_TYPE_CHAMP.GetLibelle((int)e.CellValue)} (Obligatoire)"; }
                else
                { e.DisplayText = $"{CEQUIPEMENT_FICHE_TYPE_CHAMP.GetLibelle((int)e.CellValue)}"; }

            }

        }

        private void GVAdmin_Equipement_Fiche_Items_CustomColumnGroup(object sender, DevExpress.XtraGrid.Views.Base.CustomColumnSortEventArgs e)
        {
            if (e.Column.FieldName == "NEQUIPEMENT_FICHE_CHAP_ORDER_AFFICH")
            {

                if (e.Value1 == DBNull.Value || e.Value2 == DBNull.Value)
                {
                    e.Result = 0;
                    return;
                }

                int val1 = Convert.ToInt32(e.Value1);
                int val2 = Convert.ToInt32(e.Value2);
                int res = e.Result = System.Collections.Comparer.Default.Compare(val1, val2);
                if (val1.ToString() == "" | val2.ToString() == "")
                {
                    e.Result = 0;
                    
                }
                else e.Result = System.Collections.Comparer.Default.Compare(val1, val2);               
                e.Handled = true;
            }
        }

        private void GVAdmin_Equipement_Fiche_Items_ValidateRow(object sender, DevExpress.XtraGrid.Views.Base.ValidateRowEventArgs e)
        {
            //test si tous les champs sont bien saisie    

            GridView view = sender as GridView;
            GridColumn colLibelle = view.Columns["VEQUIPEMENT_FICHE_ITEM_LIB"];
            GridColumn colChapter = view.Columns["NID_EQUIPEMENT_FICHE_CHAP"];
            GridColumn colTypeChamp = view.Columns["NID_EQUIPEMENT_FICHE_TYPE_CHAMP"];
            GridColumn colListeParent = view.Columns["NID_EQUIPEMENT_FICHE_LIST_PARENT"];

            //libellé obligatoire        
            string strLibelle =  view.GetRowCellValue(e.RowHandle, colLibelle) == DBNull.Value ? "" : view.GetRowCellValue(e.RowHandle, colLibelle).ToString();

            if (strLibelle == "")
            {
                e.Valid = false;
                //Set errors with specific descriptions for the columns
                view.SetColumnError(colLibelle, "le libellé est obligatoire");
            }

            //chapitre obligatoire         
            int idChapter = view.GetRowCellValue(e.RowHandle, colChapter) == DBNull.Value ? 0 : (int)view.GetRowCellValue(e.RowHandle, colChapter);
            if (idChapter == 0)
            {
                e.Valid = false;
                //Set errors with specific descriptions for the columns
                view.SetColumnError(colChapter, "le chapitre est obligatoire");
            }

            //type obligatoire
            int idTypeChamp = view.GetRowCellValue(e.RowHandle, colTypeChamp) == DBNull.Value ? 0 : (int)view.GetRowCellValue(e.RowHandle, colTypeChamp);
            if (idTypeChamp == 0)
            {
                e.Valid = false;
                //Set errors with specific descriptions for the columns
                view.SetColumnError(colTypeChamp, "le type de champ est obligatoire");
            }

            //si type liste alors, il faut définir une liste
            int idListParent = view.GetRowCellValue(e.RowHandle, colListeParent) == DBNull.Value ? 0 : (int)view.GetRowCellValue(e.RowHandle, colListeParent);
            if(CEQUIPEMENT_FICHE_TYPE_CHAMP.LoadListeTypeChampInListe().Contains(idTypeChamp) && (idListParent == 0))
            {
                e.Valid = false;
                //Set errors with specific descriptions for the columns
                view.SetColumnError(colListeParent, "le type de liste est obligatoire pour un champ de type 'Liste'");
            }

        }

        private void GVAdmin_Equipement_Fiche_Items_InvalidRowException(object sender, DevExpress.XtraGrid.Views.Base.InvalidRowExceptionEventArgs e)
        {
            //Suppress displaying the error message box
            e.ExceptionMode = ExceptionMode.NoAction;
        }

        private void repositoryItemTextEdit_TypeChamp_CustomDisplayText(object sender, CustomDisplayTextEventArgs e)
        {
            if (e.Value == null) return;
            e.DisplayText = $"{CEQUIPEMENT_FICHE_TYPE_CHAMP.GetLibelle((int)e.Value)} (Obligatoire)";

        }
    }
}
