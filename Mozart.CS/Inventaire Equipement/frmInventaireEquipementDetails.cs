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

namespace MozartCS.Inventaire_Equipement
{
    public partial class frmInventaireEquipementDetails : Form
    {

        private List<Int32> lstCboEdit = new List<Int32>() { 5, 10, 11 };
        private List<Int32> lstImageTypeChamp = new List<Int32>() { 7, 8 };
        
        public int NSIT_INV_EQUIPEMENT_RECEIVE_ID;
        public int NSITNUM = 0;
        public int NIDEQUIPEMENT = 0;

        public string vclinom;
        public string vsitnom;
        
        public string VTYPECONTRAT;
        public string VLIBEQUIPEMENT;
        public string VLIBFICHE;
        public bool BEQUIPEMENT_A_CORRIGER = false;

        private bool bEtatIsNewEquip = false;

        DataTable DtDetails;

        public frmInventaireEquipementDetails()
        {
            InitializeComponent();
        }

        private void frmInventaireEquipementDetails_Load(object sender, EventArgs e)
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
            this.Text = LblTitre.Text = $"Détails d'un équipement : {vclinom}/{vsitnom}/{VTYPECONTRAT}/{VLIBEQUIPEMENT}/{VLIBFICHE}";
        }

        private void LoadData()
        {
            DtDetails = new DataTable();

            if(NSIT_INV_EQUIPEMENT_RECEIVE_ID > 0)
            {
                ModuleData.LoadData(DtDetails, $"EXEC [api_sp_InvEquip_Site_Details] {NSIT_INV_EQUIPEMENT_RECEIVE_ID}");
                bEtatIsNewEquip = false;
            }
            else
            {
                ModuleData.LoadData(DtDetails, $"EXEC [api_sp_InvEquip_Site_Details_To_Add] {NSITNUM}, {NIDEQUIPEMENT}");
                bEtatIsNewEquip = true;
            }     

            DtDetails.Columns["OVALUE"].ReadOnly = false;
            DtDetails.Columns["VFILENAME"].ReadOnly = false;

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
                        Rep = Rep_HLink;
                        break;
                    //Code Barre
                    case 8:
                        Rep = Rep_HLink;
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
            if (e.Column.Name == "Col_Actions") // Replace with your column's field name
            {
                // Get the data value for the current cell (optional, for conditional logic)
                int TypeChamp = (int)GVInvEquipDetails.GetRowCellValue(e.RowHandle, Col_NID_EQUIPEMENT_FICHE_TYPE_CHAMP);

                RepositoryItem RepAction = null;

                switch (TypeChamp)
                {
                    //Texte (Alpha Numeric)
                    case 1:                        
                    //Texte (Numeric)
                    case 2:                       
                    //Texte (Date)
                    case 3:
                    //Texte (Multi Ligne)                    
                    case 4:                    
                    case 5:
                        RepAction = RepItemButtonDel;
                        break;
                    //Case à cocher
                    case 6:
                        RepAction = null;
                        break;
                    //Photo
                    case 7:

                        object reponseval = GVInvEquipDetails.GetRowCellValue(e.RowHandle, Col_OVALUE);
                        if(reponseval == null | reponseval.ToString() == "")
                        {
                            RepAction = RepItemButtonAdd;
                        }
                        else
                        {
                            RepAction = RepItemButtonDel;
                        }
                        
                        break;
                    //Code Barre
                    case 8:
                        object reponsevalcodebarre = GVInvEquipDetails.GetRowCellValue(e.RowHandle, Col_OVALUE);
                        if (reponsevalcodebarre == null | reponsevalcodebarre.ToString() == "")
                        {
                            RepAction = RepItemButtonAdd;
                        }
                        else
                        {
                            RepAction = null;
                        }
                        break;
                    case 9:
                    case 10:
                    case 11:
                        RepAction = RepItemButtonDel;
                        break;

                }
                // Assign the RepositoryItem to the cell
                if (RepAction != null) e.RepositoryItem = RepAction;
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
            ////gestion des images
            //if (view.FocusedColumn.FieldName == "OVALUE" & lstImageTypeChamp.Contains((int)view.GetFocusedRowCellValue(Col_NID_EQUIPEMENT_FICHE_TYPE_CHAMP))) // Replace with your field name
            //{

            //    PictureEdit ImageEquip = view.ActiveEditor as PictureEdit;
            //    if (ImageEquip != null)
            //    {

            //        if (File.Exists($@"{MozartParams.RechercheParam("REP_PHOTOS_EMASSET", MozartParams.NomSociete)}{view.FocusedValue.ToString()}")) return;//ImageEquip.Image = Image.FromFile($"{}");

            //    }
            //    return;
            //}


        }

        private void Rep_HLink_Click(object sender, EventArgs e)
        {
            DataRow dr = GVInvEquipDetails.GetDataRow(GVInvEquipDetails.FocusedRowHandle);
            if (dr == null) return;
            

            string sfileOut = "";

            if ((int)dr["NSIT_INV_ELEMENT_RECEIVE_ID"] > 0 && File.Exists($@"{MozartParams.RechercheParam("REP_PHOTOS_EMASSET", MozartParams.NomSociete)}{dr["VFILENAME"].ToString()}"))
            {
                sfileOut = $@"{MozartParams.RechercheParam("REP_PHOTOS_EMASSET", MozartParams.NomSociete)}{dr["VFILENAME"].ToString()}";
            }
            else
            { 
                if (dr["VFILENAME"].ToString() != "" && File.Exists($@"{dr["VFILENAME"].ToString()}"))
                {
                    sfileOut = $@"{dr["VFILENAME"].ToString()}";
                    //System.Diagnostics.Process.Start($@"{dr["VFILENAME"].ToString()}");
                }
            }


            if ((int)dr["NID_EQUIPEMENT_FICHE_TYPE_CHAMP"] == 8)
            {
                //si code barre
                frmInventaireEquipementDetailCodeBarre form = new frmInventaireEquipementDetailCodeBarre();
                form.sCodeBarre = dr["OVALUE"].ToString();
                form.sFileCodeBarre = sfileOut;
                form.ShowDialog();
                if (form.bSave)
                {
                    GVInvEquipDetails.SetRowCellValue(GVInvEquipDetails.FocusedRowHandle, Col_OVALUE, form.sCodeBarre);
                    GVInvEquipDetails.SetRowCellValue(GVInvEquipDetails.FocusedRowHandle, Col_VFILENAME, form.sFileCodeBarre);
                    GVInvEquipDetails.PostEditor();
                }
                return;
            }
            else
            {
                if (dr["VFILENAME"].ToString() == "") return;
                System.Diagnostics.Process.Start(sfileOut);
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
            GVInvEquipDetails.SetRowCellValue(GVInvEquipDetails.FocusedRowHandle, Col_OVALUE, ((DateTime)Date_Edit.EditValue).ToShortDateString());
            //GVInvEquipDetails.SetRowCellValue(GVInvEquipDetails.FocusedRowHandle, Col_OVALUE, Date_Edit.EditValue);
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

        private void GVInvEquipDetails_ValidateRow(object sender, DevExpress.XtraGrid.Views.Base.ValidateRowEventArgs e)
        {
            //GridView view = sender as GridView;
            //GridColumn Col_Champ_Oblig = view.Columns["BEQUIPEMENT_FICHE_ITEM_OBLIG"];
            //GridColumn Col_Value = view.Columns["OVALUE"];
            ////Get the value of the first column
            //bool bOblig = (bool)view.GetRowCellValue(e.RowHandle, Col_Champ_Oblig);
            ////Get the value of the second column
            //Object oReponse = view.GetRowCellValue(e.RowHandle, Col_Value);
            ////Validity criterion
            //if (bOblig & (oReponse == null | oReponse.ToString() == ""))
            //{
            //    e.Valid = false;
            //    //Set errors with specific descriptions for the columns
            //    view.SetColumnError(Col_Value, "Ce champ est obligatoire");
            //    return;
            //}
            //if (e.Valid) view.ClearColumnErrors();
        }

        private void GVInvEquipDetails_InvalidRowException(object sender, DevExpress.XtraGrid.Views.Base.InvalidRowExceptionEventArgs e)
        {
            
            //e.ExceptionMode = ExceptionMode.Ignore;
        }

        private void RepItemButtonDel_ButtonClick(object sender, ButtonPressedEventArgs e)
        {

            if(XtraMessageBox.Show($"Voulez-vous vraiment supprimer cette donnée '{GVInvEquipDetails.GetFocusedRowCellDisplayText(Col_OVALUE)}' ?", "Message", MessageBoxButtons.YesNoCancel, MessageBoxIcon.Question) == DialogResult.Yes)
            {
                GVInvEquipDetails.SetRowCellValue(GVInvEquipDetails.FocusedRowHandle, Col_OVALUE, "");
                GVInvEquipDetails.PostEditor();
            }

        }

        private void RepItemButtonAdd_ButtonClick(object sender, ButtonPressedEventArgs e)
        {

            DataRow dr = GVInvEquipDetails.GetDataRow(GVInvEquipDetails.FocusedRowHandle);
            if (dr == null) return;

            if (dr["NID_EQUIPEMENT_FICHE_TYPE_CHAMP"] != null)
            {

                //si photo
                if((int)dr["NID_EQUIPEMENT_FICHE_TYPE_CHAMP"] == 7)
                {
                    if (OFD.ShowDialog() != DialogResult.Cancel)
                    {
                        if (OFD.FileName != "")
                        {
                            string vfilename = Path.GetFileName(OFD.FileName);
                            string vpathandfilename = OFD.FileName;

                            GVInvEquipDetails.SetRowCellValue(GVInvEquipDetails.FocusedRowHandle, Col_OVALUE, vfilename);
                            GVInvEquipDetails.SetRowCellValue(GVInvEquipDetails.FocusedRowHandle, Col_VFILENAME, vpathandfilename);

                        }
                        else
                        {
                            GVInvEquipDetails.SetRowCellValue(GVInvEquipDetails.FocusedRowHandle, Col_OVALUE, "");
                            GVInvEquipDetails.SetRowCellValue(GVInvEquipDetails.FocusedRowHandle, Col_VFILENAME, "");
                        }                        
                                      
                        GVInvEquipDetails.PostEditor();
                        
                        return;
                    }
                }

                //si code barre
                if ((int)dr["NID_EQUIPEMENT_FICHE_TYPE_CHAMP"] == 8)
                {

                    //si code barre
                    frmInventaireEquipementDetailCodeBarre form = new frmInventaireEquipementDetailCodeBarre();
                    form.sCodeBarre = "";
                    form.sFileCodeBarre = "";
                    form.ShowDialog();
                    if (form.bSave)
                    {
                        GVInvEquipDetails.SetRowCellValue(GVInvEquipDetails.FocusedRowHandle, Col_OVALUE, form.sCodeBarre);
                        GVInvEquipDetails.SetRowCellValue(GVInvEquipDetails.FocusedRowHandle, Col_VFILENAME, form.sFileCodeBarre);
                        GVInvEquipDetails.PostEditor();
                    }
                    return;


                    //if (OFD.ShowDialog() != DialogResult.Cancel)
                    //{
                    //    if (OFD.FileName != "")
                    //    {
                    //        string vfilename = Path.GetFileName(OFD.FileName);
                    //        string vpathandfilename = OFD.FileName;

                    //        try
                    //        {
                    //            Bitmap bitmap = new Bitmap(OFD.FileName);
                    //            BarcodeReader reader = new BarcodeReader();
                    //            Result result = reader.Decode(bitmap);

                    //            if (result != null)
                    //            {
                    //                MessageBox.Show("Code-barres détecté : " + result.Text);
                    //                GVInvEquipDetails.SetRowCellValue(GVInvEquipDetails.FocusedRowHandle, Col_OVALUE, result.Text);
                    //                GVInvEquipDetails.SetRowCellValue(GVInvEquipDetails.FocusedRowHandle, Col_VFILENAME, vpathandfilename);
                    //            }
                    //            else
                    //            {
                    //                MessageBox.Show("Aucun code-barres détecté.");
                    //                GVInvEquipDetails.SetRowCellValue(GVInvEquipDetails.FocusedRowHandle, Col_OVALUE, "");
                    //                GVInvEquipDetails.SetRowCellValue(GVInvEquipDetails.FocusedRowHandle, Col_VFILENAME, "");
                    //            }

                    //        }
                    //        catch (Exception ex)
                    //        {
                    //            MessageBox.Show("Erreur : " + ex.Message);
                    //            return;
                    //        }

                           

                    //    }
                    //    else
                    //    {
                    //        GVInvEquipDetails.SetRowCellValue(GVInvEquipDetails.FocusedRowHandle, Col_OVALUE, "");
                    //        GVInvEquipDetails.SetRowCellValue(GVInvEquipDetails.FocusedRowHandle, Col_VFILENAME, "");
                    //    }

                    //    GVInvEquipDetails.PostEditor();
                    //    return;
                    //}
                    return;
                }
                

             }

            

        }

        private void BtnSave_Click(object sender, EventArgs e)
        {

            bool bCorrectionTermine = false;

            if (MessageBox.Show("Voulez - vous enregistrer cet équipement ?", "Confirmation", MessageBoxButtons.YesNoCancel, MessageBoxIcon.Question) != DialogResult.Yes)
            {
                return;
            }

                this.Cursor = Cursors.WaitCursor;

            if (GVInvEquipDetails.HasColumnErrors)
            {
                this.Cursor = Cursors.Default;
                MessageBox.Show("Enregistrement impossible car il y a des erreurs de saisie", "Erreur", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;

            }

            //test si rows oblgatoire sans réponse            
            DataRow DrTest;
            for (int i = 0; i < this.GVInvEquipDetails.RowCount; i++)
            {
                int currentRowHandle = GVInvEquipDetails.GetRowHandle(i);
                DrTest = this.GVInvEquipDetails.GetDataRow(currentRowHandle);
                if(DrTest != null && ((bool)DrTest["BEQUIPEMENT_FICHE_ITEM_OBLIG"] == true & DrTest["OVALUE"].ToString() == ""))
                {
                    this.Cursor = Cursors.Default;
                    MessageBox.Show("Enregistrement impossible car il y a des champs obligatoires sans réponse", "Erreur", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    return;
                }
            }

            //on sélectionne les lignes ajouter
            //si nouvel equipement alors on prend tout
            DataRowState rowState = bEtatIsNewEquip ? DataRowState.Added | DataRowState.Deleted | DataRowState.Unchanged | DataRowState.Modified : DataRowState.Added | DataRowState.Deleted | DataRowState.Modified;

            if (DtDetails.GetChanges(rowState) == null)
            { 
                this.Cursor = Cursors.Default;
                MessageBox.Show("Aucune modification n' a été effectuée", "Avertissement", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                return; 
            }

            if(BEQUIPEMENT_A_CORRIGER)
            {
                if (MessageBox.Show("La correction de cet équipement est-elle terminée ?", "Question", MessageBoxButtons.YesNoCancel, MessageBoxIcon.Question) == DialogResult.Yes)
                {
                    bCorrectionTermine = true;
                }
            }


            int NSIT_INV_ID = 0;

            //on récupère l id de NSIT_INV_ID
            NSIT_INV_ID = MozartDatabase.ExecuteScalarInt($"EXEC [api_sp_InvEquip_Site_Get_InventaireSite_Id] {NSITNUM}");

            if (NSIT_INV_ID == 0)
            {
                this.Cursor = Cursors.Default;
                MessageBox.Show("Le site n'a pas d'inventaire", "Erreur", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            //creation de l'equipement si besoin            
            if (NSIT_INV_EQUIPEMENT_RECEIVE_ID == 0)
            {
                NSIT_INV_EQUIPEMENT_RECEIVE_ID = MozartDatabase.ExecuteScalarInt($"EXEC [api_sp_InvEquip_Site_CreateEquipement] {NSIT_INV_ID}");
            }
            if (NSIT_INV_EQUIPEMENT_RECEIVE_ID == 0)
            {
                this.Cursor = Cursors.Default;
                MessageBox.Show("L'équipement n' a pas été créé", "Erreur", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            int NSIT_INV_ELEMENT_ID = 0;

            
           
            foreach (DataRow Dr in DtDetails.GetChanges(rowState).Rows)
            {
                //pour chaque champ, on teste si sa trame dans TSIT_INV_ELEMENT existe, 
                //si non, alors on l'a créé

                /*NIDEQUIPEMENT
                    NID_EQUIPEMENT_CLI
                    NID_EQUIPEMENT_SIT
                    NID_EQUIPEMENT_FICHE
                    NID_EQUIPEMENT_CLI_CONTRAT
                    NTYPECONTRAT
                    NID_EQUIPEMENT_SIT_CONTRAT*/

                NSIT_INV_ELEMENT_ID = (int)Dr["NSIT_INV_ELEMENT_ID"];
                if (NSIT_INV_ELEMENT_ID  == 0)
                {
                    //on save dans la table TSIT_INV_ELEMENT
                    //en récupérant son id
                    List<SqlParameter> parameters_element_sit = new List<SqlParameter>()
                        {
                            new SqlParameter() { ParameterName = "@P_NSIT_INV_ID", SqlDbType = SqlDbType.Int, Value = NSIT_INV_ID},
                            new SqlParameter() { ParameterName = "@P_NIDEQUIPEMENT", SqlDbType = SqlDbType.Int, Value = Dr["NIDEQUIPEMENT"]},
                            new SqlParameter() { ParameterName = "@P_NID_EQUIPEMENT_CLI", SqlDbType = SqlDbType.Int, Value = Dr["NID_EQUIPEMENT_CLI"]},
                            new SqlParameter() { ParameterName = "@P_NID_EQUIPEMENT_SIT", SqlDbType = SqlDbType.Int, Value = Dr["NID_EQUIPEMENT_SIT"]},
                            new SqlParameter() { ParameterName = "@P_NID_EQUIPEMENT_FICHE_CHAP", SqlDbType = SqlDbType.Int, Value = Dr["NID_EQUIPEMENT_FICHE_CHAP"]},
                            new SqlParameter() { ParameterName = "@P_NID_EQUIPEMENT_FICHE_ITEM", SqlDbType = SqlDbType.Int, Value = Dr["NID_EQUIPEMENT_FICHE_ITEM"]},
                            new SqlParameter() { ParameterName = "@P_NID_EQUIPEMENT_FICHE", SqlDbType = SqlDbType.Int, Value = Dr["NID_EQUIPEMENT_FICHE"]},
                            new SqlParameter() { ParameterName = "@P_VEQUIPEMENT_FICHE_CHAP_LIB", SqlDbType = SqlDbType.VarChar, Value = Dr["VEQUIPEMENT_FICHE_CHAP_LIB"]},
                            new SqlParameter() { ParameterName = "@P_NEQUIPEMENT_FICHE_CHAP_ORDER_AFFICH", SqlDbType = SqlDbType.Int, Value = Dr["NEQUIPEMENT_FICHE_CHAP_ORDER_AFFICH"]},
                            new SqlParameter() { ParameterName = "@P_NID_EQUIPEMENT_FICHE_TYPE_CHAMP", SqlDbType = SqlDbType.Int, Value = Dr["NID_EQUIPEMENT_FICHE_TYPE_CHAMP"]},
                            new SqlParameter() { ParameterName = "@P_NID_EQUIPEMENT_FICHE_LIST_PARENT", SqlDbType = SqlDbType.Int, Value = Dr["NID_EQUIPEMENT_FICHE_LIST_PARENT"]},
                            new SqlParameter() { ParameterName = "@P_VEQUIPEMENT_FICHE_ITEM_LIB", SqlDbType = SqlDbType.VarChar, Value = Dr["VEQUIPEMENT_FICHE_ITEM_LIB"]},
                            new SqlParameter() { ParameterName = "@P_NEQUIPEMENT_FICHE_ITEM_ORDER", SqlDbType = SqlDbType.Int, Value = Dr["NEQUIPEMENT_FICHE_ITEM_ORDER"]},
                            new SqlParameter() { ParameterName = "@P_BEQUIPEMENT_FICHE_ITEM_OBLIG", SqlDbType = SqlDbType.Bit, Value = Dr["BEQUIPEMENT_FICHE_ITEM_OBLIG"]},
                            new SqlParameter() { ParameterName = "@P_VLIBEQUIPEMENT", SqlDbType = SqlDbType.VarChar, Value = Dr["VLIBEQUIPEMENT"]},
                            new SqlParameter() { ParameterName = "@P_NID_EQUIPEMENT_CLI_CONTRAT", SqlDbType = SqlDbType.Int, Value = Dr["NID_EQUIPEMENT_CLI_CONTRAT"]},
                            new SqlParameter() { ParameterName = "@P_NTYPECONTRAT", SqlDbType = SqlDbType.Int, Value = Dr["NTYPECONTRAT"]},
                            new SqlParameter() { ParameterName = "@P_VTYPECONTRAT", SqlDbType = SqlDbType.VarChar, Value = Dr["VTYPECONTRAT"]},
                            new SqlParameter() { ParameterName = "@P_NID_EQUIPEMENT_SIT_CONTRAT", SqlDbType = SqlDbType.Int, Value = Dr["NID_EQUIPEMENT_SIT_CONTRAT"]}
                        };


                    NSIT_INV_ELEMENT_ID = MozartDatabase.ExecuteScalarInt($"[api_sp_InvEquip_Site_ElementTrame_Exists]", parameters_element_sit.ToArray());
                }

                if(NSIT_INV_ELEMENT_ID == -1)
                {
                    this.Cursor = Cursors.Default;
                    MessageBox.Show("La trame de l'équipement n'a été créé correctement", "Erreur", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    return;
                }

                //save par champ
                //gestion spéciale pour les photos
                switch ((int)Dr["NID_EQUIPEMENT_FICHE_TYPE_CHAMP"])
                {
                    case 1:
                    case 2:
                    case 3:
                    case 4:
                    case 5:
                    case 6:

                        List<SqlParameter> parameters = new List<SqlParameter>()
                        {
                            new SqlParameter() { ParameterName = "@P_NSIT_INV_ELEMENT_RECEIVE_ID", SqlDbType = SqlDbType.Int, Value = Dr["NSIT_INV_ELEMENT_RECEIVE_ID"]},
                            new SqlParameter() { ParameterName = "@P_NSIT_INV_EQUIPEMENT_RECEIVE_ID", SqlDbType = SqlDbType.Int, Value = NSIT_INV_EQUIPEMENT_RECEIVE_ID},
                            new SqlParameter() { ParameterName = "@P_NSIT_INV_ELEMENT_ID", SqlDbType = SqlDbType.Int, Value = NSIT_INV_ELEMENT_ID},
                            new SqlParameter() { ParameterName = "@P_OVALUE", SqlDbType = SqlDbType.VarChar, Value = Dr["OVALUE"]}
                        };

                        MozartDatabase.ExecuteNonQuery("[api_sp_InvEquip_Site_Details_Save]", parameters.ToArray());

                        break;
                    case 7:
                    case 8:

                        string vfilenamedest_base;
                        string vfilenamedest_final = "";

                        //gestion du fichier photo

                        //on compare le nom du fichier
                        //on recupère l'ancien fihcier
                        string file_base = "";
                        using (SqlDataReader dr = MozartDatabase.ExecuteReader($"EXEC [api_sp_InvEquip_Site_Details_GetFileNamePhoto] {Dr["NSIT_INV_PHOTO_RECEIVE_ID"]}"))
                        {
                            while (dr.Read())
                            {
                                file_base = $@"{MozartParams.RechercheParam("REP_PHOTOS_EMASSET", MozartParams.NomSociete)}{dr["VFILENAME"].ToString()}";

                                //if (File.Exists($@"{MozartParams.RechercheParam("REP_PHOTOS_EMASSET", MozartParams.NomSociete)}{dr["VFILENAME"].ToString()}"))
                                //{
                                //    File.Delete($@"{MozartParams.RechercheParam("REP_PHOTOS_EMASSET", MozartParams.NomSociete)}{dr["VFILENAME"].ToString()}");
                                //}
                            }
                        }

                        //si différent, alors on copie
                       
                        

                        //si fichier a vide alors on supprimer le fichier
                        if (Dr["OVALUE"] == null || Dr["OVALUE"].ToString() == "")
                        {
                            //on recupère l'ancien fihcier
                            using (SqlDataReader dr = MozartDatabase.ExecuteReader($"EXEC [api_sp_InvEquip_Site_Details_GetFileNamePhoto] {Dr["NSIT_INV_PHOTO_RECEIVE_ID"]}"))
                            {
                                while (dr.Read())
                                {
                                    if (File.Exists($@"{MozartParams.RechercheParam("REP_PHOTOS_EMASSET", MozartParams.NomSociete)}{dr["VFILENAME"].ToString()}"))
                                    {
                                        File.Delete($@"{MozartParams.RechercheParam("REP_PHOTOS_EMASSET", MozartParams.NomSociete)}{dr["VFILENAME"].ToString()}");
                                    }
                                }
                            }                            

                        }
                        //si nouvelle données
                        if (Dr["OVALUE"] != null & Dr["OVALUE"].ToString() != "")
                        {

                            vfilenamedest_base = Path.GetFileName(Dr["VFILENAME"].ToString());
                            vfilenamedest_final = vfilenamedest_base;

                            //on compare les nom des fichiers
                            //si identique, alors ne touche pas à la photo
                            if (file_base != Dr["VFILENAME"].ToString())
                            {
                                //on vérifie le nouveau nom du fichier s'il existe
                                if (!File.Exists(Dr["VFILENAME"].ToString()) & Dr["VFILENAME"].ToString() != "")
                                {
                                    this.Cursor = Cursors.Default;
                                    MessageBox.Show($@"Le fichier {Dr["VFILENAME"]} n'existe pas", "Erreur", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                                    return;
                                }                                                                

                                //on teste si le fichier a copier existe dans le repertoire des photos
                                //si oui, alors on change son nom
                                while (File.Exists($@"{MozartParams.RechercheParam("REP_PHOTOS_EMASSET", MozartParams.NomSociete)}{vfilenamedest_final}"))
                                {
                                    vfilenamedest_final = $"{DateTime.Now.ToString("ddMMyyyyHHmmss")}_{vfilenamedest_base}";
                                }

                                //on copie le nouveau

                                //si fichier nouveau est vide, alors on supprime l'ancien fichier
                                if(Dr["VFILENAME"].ToString() == "" & file_base != "")
                                {
                                    if (File.Exists(file_base))
                                    {
                                        File.Delete(file_base);
                                    }
                                }
                                else
                                { 
                                    File.Copy(Dr["VFILENAME"].ToString(),
                                            $@"{MozartParams.RechercheParam("REP_PHOTOS_EMASSET", MozartParams.NomSociete)}{vfilenamedest_final}", false);
                                }
                                //on delete l'ancien fihcier stocké dans le repertoire REP_PHOTOS_EMASSET
                                using (SqlDataReader dr = MozartDatabase.ExecuteReader($"EXEC [api_sp_InvEquip_Site_Details_GetFileNamePhoto] {Dr["NSIT_INV_PHOTO_RECEIVE_ID"]}"))
                                {
                                    while (dr.Read())
                                    {
                                        if (File.Exists($@"{MozartParams.RechercheParam("REP_PHOTOS_EMASSET", MozartParams.NomSociete)}{dr["VFILENAME"].ToString()}"))
                                        {
                                            File.Delete($@"{MozartParams.RechercheParam("REP_PHOTOS_EMASSET", MozartParams.NomSociete)}{dr["VFILENAME"].ToString()}");
                                        }
                                    }

                                }
                            }

                           
                        }

                        //on save en base de données
                        List<SqlParameter> parametersphoto = new List<SqlParameter>()
                        {
                            new SqlParameter() { ParameterName = "@P_NSIT_INV_PHOTO_RECEIVE_ID", SqlDbType = SqlDbType.Int, Value = Dr["NSIT_INV_PHOTO_RECEIVE_ID"]},
                            new SqlParameter() { ParameterName = "@P_NSIT_INV_EQUIPEMENT_RECEIVE_ID", SqlDbType = SqlDbType.Int, Value = NSIT_INV_EQUIPEMENT_RECEIVE_ID},
                            new SqlParameter() { ParameterName = "@P_NSIT_INV_ELEMENT_ID", SqlDbType = SqlDbType.Int, Value = NSIT_INV_ELEMENT_ID},
                            new SqlParameter() { ParameterName = "@P_VFILENAME", SqlDbType = SqlDbType.VarChar, Value = vfilenamedest_final},
                            new SqlParameter() { ParameterName = "@P_VPHOTO_NAME", SqlDbType = SqlDbType.VarChar, Value = vfilenamedest_final}
                        };
                        MozartDatabase.ExecuteNonQuery("[api_sp_InvEquip_Site_Details_Photo_Save]", parametersphoto.ToArray());

                        List<SqlParameter> parametersPhotoElement = new List<SqlParameter>()
                        {
                            new SqlParameter() { ParameterName = "@P_NSIT_INV_ELEMENT_RECEIVE_ID", SqlDbType = SqlDbType.Int, Value = Dr["NSIT_INV_ELEMENT_RECEIVE_ID"]},
                            new SqlParameter() { ParameterName = "@P_NSIT_INV_EQUIPEMENT_RECEIVE_ID", SqlDbType = SqlDbType.Int, Value = NSIT_INV_EQUIPEMENT_RECEIVE_ID},
                            new SqlParameter() { ParameterName = "@P_NSIT_INV_ELEMENT_ID", SqlDbType = SqlDbType.Int, Value = NSIT_INV_ELEMENT_ID},
                            new SqlParameter() { ParameterName = "@P_OVALUE", SqlDbType = SqlDbType.NVarChar, Value = Dr["OVALUE"]}
                        };

                        MozartDatabase.ExecuteNonQuery("[api_sp_InvEquip_Site_Details_Save]", parametersPhotoElement.ToArray());

                        break;
                    case 9:
                    case 10:
                    case 11:
                        List<SqlParameter> parameters2 = new List<SqlParameter>()
                        {
                            new SqlParameter() { ParameterName = "@P_NSIT_INV_ELEMENT_RECEIVE_ID", SqlDbType = SqlDbType.Int, Value = Dr["NSIT_INV_ELEMENT_RECEIVE_ID"]},
                            new SqlParameter() { ParameterName = "@P_NSIT_INV_EQUIPEMENT_RECEIVE_ID", SqlDbType = SqlDbType.Int, Value = NSIT_INV_EQUIPEMENT_RECEIVE_ID},
                            new SqlParameter() { ParameterName = "@P_NSIT_INV_ELEMENT_ID", SqlDbType = SqlDbType.Int, Value = NSIT_INV_ELEMENT_ID},
                            new SqlParameter() { ParameterName = "@P_OVALUE", SqlDbType = SqlDbType.NVarChar, Value = Dr["OVALUE"]}
                        };

                        MozartDatabase.ExecuteNonQuery("[api_sp_InvEquip_Site_Details_Save]", parameters2.ToArray());
                        break;

                }               

            }
            DtDetails.AcceptChanges();

            //on change le statut de la correction de l'équipement si besoin
            //BEQUIPEMENT_A_CORRIGER, bCorrectionTermine

            if (BEQUIPEMENT_A_CORRIGER)
            {
                MozartDatabase.ExecuteNonQuery($"EXEC [api_sp_InvEquip_Site_Equipement_Save_EtatCorrection] {NSIT_INV_EQUIPEMENT_RECEIVE_ID}, {!bCorrectionTermine}");
                if (bCorrectionTermine) BEQUIPEMENT_A_CORRIGER = false;
            }

            GestAffichage();

            this.Cursor = Cursors.Default;
            MessageBox.Show("Enregistrement effectué avec succés", "Confirmation", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }

        private void GVInvEquipDetails_CustomUnboundColumnData(object sender, DevExpress.XtraGrid.Views.Base.CustomColumnDataEventArgs e)
        {
            //GridView view = sender as GridView;
            //if (view != null)
            //{
            //    if (e.Column.FieldName == "OVALUE" && e.IsGetData)
            //    {
            //        int NTYPE_CHAMP = Convert.ToInt32(view.GetRowCellValue(e.ListSourceRowIndex, Col_NID_EQUIPEMENT_FICHE_TYPE_CHAMP));
            //        if (NTYPE_CHAMP == 7)
            //        {
            //            string opreonsefile = "BLABLABALBAL";
            //            e.Value = opreonsefile;
            //        }

            //    }
            //}
        }

        private void GVInvEquipDetails_ValidatingEditor(object sender, BaseContainerValidateEditorEventArgs e)
        {

        }
    }
}
