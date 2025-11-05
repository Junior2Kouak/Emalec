using DevExpress.CodeParser;
using DevExpress.XtraEditors;
using DevExpress.XtraEditors.Controls;
using DevExpress.XtraEditors.Repository;
using DevExpress.XtraGrid.Columns;
using DevExpress.XtraGrid.Views.Grid;
using MozartLib;
using MozartNet;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Reflection;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static System.Windows.Forms.VisualStyles.VisualStyleElement;
using MZUtils = MozartControls.Utils;
using ZXing;
using DevExpress.XtraRichEdit.Layout;

namespace MozartCS
{
    public partial class frmActionInventaireEquipementDetails : Form
    {

        private List<Int32> lstCboEdit = new List<Int32>() { 5, 10, 11 };
        private List<Int32> lstImageTypeChamp = new List<Int32>() { 7, 8 };
        
        public int NACT_INV_ID;        
        public int NIDEQUIPEMENT = 0;
                
        public string VTYPECONTRAT;
        public string VLIBEQUIPEMENT;
        public string VFICHELIB;

        DataTable DtDetails;

        public frmActionInventaireEquipementDetails()
        {
            InitializeComponent();
        }

        private void frmActionInventaireEquipementDetails_Load(object sender, EventArgs e)
        {
            try
            {
                Cursor.Current = Cursors.WaitCursor;
                ModuleMain.Initboutons(this);

                GestAffichage();

                LoadData();

            }
            catch (Exception ex)
            {
                MZUtils.displayError(MethodBase.GetCurrentMethod().Name, ex);
            }
            finally { Cursor.Current = Cursors.Default; }

        }

        private void GestAffichage()
        {
            this.Text = LblTitre.Text = $"Détails d'un équipement : {VTYPECONTRAT}/{VLIBEQUIPEMENT}/{VFICHELIB}";
        }

        private void cmdQuitter_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void LoadData()
        {
            DtDetails = new DataTable();

            
            ModuleData.LoadData(DtDetails, $"EXEC [api_sp_Action_InvEquip_Trame_Details] {NACT_INV_ID}, {NIDEQUIPEMENT}");
             
            DtDetails.Columns["OVALUE"].ReadOnly = false;

            GCInvEquipDetails.DataSource = DtDetails;

            GVInvEquipDetails.ExpandAllGroups();

        }

        private void GVInvEquipDetails_CustomRowCellEditForEditing(object sender, CustomRowCellEditEventArgs e)
        {
            if (e.Column.FieldName == "OVALUE") // Replace with your column's field name
            {
                // Get the data value for the current cell (optional, for conditional logic)
                int TypeChamp = (int)GVInvEquipDetails.GetRowCellValue(e.RowHandle, Col_NID_EQUIPEMENT_FICHE_TYPE_CHAMP);

                RepositoryItem Rep = null;

                switch (TypeChamp)
                {
                    //Texte (Alpha Numeric)
                    //case 1:
                    //    Rep = RepText_AlphaNumeric;
                    //    break;
                    ////Texte (Numeric)
                    //case 2:
                    //    Rep = RepText_Numeric;
                    //    break;
                    ////Texte (Date)
                    //case 3:
                    //    Rep = Rep_DateEdit;
                    //    break;
                    ////Texte (Multi Ligne)
                    //case 4:
                    //    Rep = RepText_RichEdit;
                    //    break;
                    //Liste déroulante
                    case 5:
                        Rep = repositoryItemGridLookUpEdit1;
                        break;
                    ////Case à cocher
                    //case 6:
                    //    Rep = RepCheckEdit;
                    //    break;
                    ////Photo
                    //case 7:
                    //    Rep = Rep_HLink;
                    //    break;
                    ////Code Barre
                    //case 8:
                    //    Rep = Rep_HLink;
                    //    break;
                    ////Libellé
                    //case 9:
                    //    Rep = RepText_AlphaNumeric;
                    //    break;
                    //Type
                    case 10:
                        Rep = repositoryItemGridLookUpEdit1;
                        break;
                    //Localisation
                    case 11:
                        Rep = repositoryItemGridLookUpEdit1;
                        break;

                }


                // Assign the RepositoryItem to the cell
                if (Rep != null) e.RepositoryItem = Rep;
            }
        }

        private void GVInvEquipDetails_CustomRowCellEdit(object sender, DevExpress.XtraGrid.Views.Grid.CustomRowCellEditEventArgs e)
        {
            if (e.Column.FieldName == "OVALUE") // Replace with your column's field name
            {
                // Get the data value for the current cell (optional, for conditional logic)
                int TypeChamp = (int)GVInvEquipDetails.GetRowCellValue(e.RowHandle, Col_NID_EQUIPEMENT_FICHE_TYPE_CHAMP);

                RepositoryItem Rep = null;

                switch (TypeChamp)
                {
                    //Texte (Alpha Numeric)
                    case 1:
                        Rep = RepText_AlphaNumeric;
                        break;
                    //Texte (Numeric)
                    case 2:
                        Rep = RepText_Numeric;
                        break;
                    //Texte (Date)
                    case 3:
                        Rep = Rep_DateEdit;
                        break;
                    //Texte (Multi Ligne)
                    case 4:
                        Rep = RepText_RichEdit;
                        break;
                    //Case à cocher
                    case 6:
                        Rep = RepCheckEdit;
                        break;
                    //Photo
                    case 7:
                        Rep = RepText_AlphaNumeric;
                        break;
                    //Code Barre
                    case 8:
                        Rep = RepText_AlphaNumeric;
                        break;
                    //Libellé
                    case 9:
                        Rep = RepText_AlphaNumeric;
                        break;

                }


                // Assign the RepositoryItem to the cell
                if (Rep != null) e.RepositoryItem = Rep;
                return;
            }            

        }

        private void GVInvEquipDetails_ShownEditor(object sender, EventArgs e)
        {

            GridView view = sender as GridView;
            //gestion des combolist
            if (view.FocusedColumn.FieldName == "OVALUE" & lstCboEdit.Contains((int)view.GetFocusedRowCellValue(Col_NID_EQUIPEMENT_FICHE_TYPE_CHAMP)))
            {
                GridLookUpEdit GLU_Edit = view.ActiveEditor as GridLookUpEdit;
                if (GLU_Edit != null)
                {

                    //on charge l'id list parent
                    int NID_EQUIPEMENT_FICHE_LIST_PARENT = (int)view.GetFocusedRowCellValue(Col_NID_EQUIPEMENT_FICHE_LIST_PARENT);

                    // Create or get your data source (DataTable, List, etc.)
                    DataTable dataSource = new DataTable();
                    ModuleData.LoadData(dataSource, $"EXEC [api_sp_Equipement_Admin_Fiche_ListParent_Item_Liste] {NID_EQUIPEMENT_FICHE_LIST_PARENT}");

                    GLU_Edit.Properties.DataSource = dataSource;

                    GLU_Edit.Properties.ValueMember = "VEQUIPEMENT_FICHE_LIST_PARENT_ITEM_LIB";
                    GLU_Edit.Properties.DisplayMember = "VEQUIPEMENT_FICHE_LIST_PARENT_ITEM_LIB";

                    GLU_Edit.EditValue = view.GetFocusedRowCellValue(Col_OVALUE);


                }
                return;
            }
           
        }                      

        private void repositoryItemGridLookUpEdit1_EditValueChanged(object sender, EventArgs e)
        {
            GridLookUpEdit GLU_Edit = sender as GridLookUpEdit;
            if (GLU_Edit == null) return;
            if (GLU_Edit.EditValue == null) return;

            GVInvEquipDetails.SetRowCellValue(GVInvEquipDetails.FocusedRowHandle, Col_OVALUE, GLU_Edit.EditValue);
            //GVInvEquipDetails.UpdateCurrentRow();
            GVInvEquipDetails.PostEditor();
        }

        private void Rep_DateEdit_EditValueChanged(object sender, EventArgs e)
        {                      

            DateEdit Date_Edit = sender as DateEdit;
            if (Date_Edit == null) return;
            if (Date_Edit.EditValue == null) return;
            GVInvEquipDetails.SetRowCellValue(GVInvEquipDetails.FocusedRowHandle, Col_OVALUE, ((DateTime)Date_Edit.EditValue).ToString("MM/dd/yyyy"));
            GVInvEquipDetails.PostEditor();
        }

        private void GVInvEquipDetails_CustomColumnSort(object sender, DevExpress.XtraGrid.Views.Base.CustomColumnSortEventArgs e)
        {
            GridView view = sender as GridView;
            if (view == null) return;
            try
            {
                if (e.Column.FieldName == "VEQUIPEMENT_FICHE_CHAP_LIB")
                {
                    object val1 = view.GetListSourceRowCellValue(e.ListSourceRowIndex1, "NEQUIPEMENT_FICHE_CHAP_ORDER_AFFICH");
                    object val2 = view.GetListSourceRowCellValue(e.ListSourceRowIndex2, "NEQUIPEMENT_FICHE_CHAP_ORDER_AFFICH");
                    e.Handled = true;
                    e.Result = System.Collections.Comparer.Default.Compare(val1, val2);
                }
            }
            catch (Exception ex)
            {
                //...
            }
        }
    }
}
