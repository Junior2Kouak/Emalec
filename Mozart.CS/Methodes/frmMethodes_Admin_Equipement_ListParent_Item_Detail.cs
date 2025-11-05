using DevExpress.XtraEditors.Controls;
using DevExpress.XtraGrid;
using DevExpress.XtraGrid.Columns;
using DevExpress.XtraGrid.Views.Grid;
using DevExpress.XtraPrinting;
using MozartNet;
using System;
using System.Data;
using System.Data.SqlClient;
using System.Windows.Forms;

namespace MozartCS
{
    public partial class frmMethodes_Admin_Equipement_ListParent_Item_Detail : Form
    {

        Int32 _NID_EQUIPEMENT_LIST_PARENT;
        bool bArchives;
        CEQUIPEMENT_LISTPARENT _EQUIPEMENT_LISTPARENT;

        public frmMethodes_Admin_Equipement_ListParent_Item_Detail(Int32 c_NID_EQUIPEMENT_LIST_PARENT)
        {
            InitializeComponent();
            _NID_EQUIPEMENT_LIST_PARENT = c_NID_EQUIPEMENT_LIST_PARENT;
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
            LoadData();            
        }

        private void LoadData()
        {

            _EQUIPEMENT_LISTPARENT = new CEQUIPEMENT_LISTPARENT(_NID_EQUIPEMENT_LIST_PARENT, 2);


            txtNomListParent.Text = _EQUIPEMENT_LISTPARENT.VEQUIPEMENT_FICHE_LIST_PARENT_LIB;
            ChkActif.Checked = _EQUIPEMENT_LISTPARENT.BEQUIPEMENT_FICHE_LIST_PARENT_ACTIF;

            GCAdmin_Equipement_ListParent_Items.DataSource = _EQUIPEMENT_LISTPARENT.dtListeItems;

        }               
               

        private void BtnSave_Click(object sender, EventArgs e)
        {
            if (_EQUIPEMENT_LISTPARENT == null) return;

            _EQUIPEMENT_LISTPARENT.VEQUIPEMENT_FICHE_LIST_PARENT_LIB = txtNomListParent.Text;
            _EQUIPEMENT_LISTPARENT.BEQUIPEMENT_FICHE_LIST_PARENT_ACTIF = ChkActif.Checked;

            _EQUIPEMENT_LISTPARENT.Save();

        }       

        private void BtnEquipFicheItemNew_Click(object sender, EventArgs e)
        {

            DataRow oNR = _EQUIPEMENT_LISTPARENT.dtListeItems.NewRow();
            oNR["NIDEQUIPEMENT_FICHE_LIST_PARENT_ITEM"] = 0;
            oNR["NID_EQUIPEMENT_LIST_PARENT"] = _NID_EQUIPEMENT_LIST_PARENT;
            oNR["VEQUIPEMENT_FICHE_LIST_PARENT_ITEM_LIB"] = "";
            oNR["BEQUIPEMENT_FICHE_LIST_PARENT_ITEM_ACTIF"] = true;

            _EQUIPEMENT_LISTPARENT.dtListeItems.Rows.Add(oNR);

        }

        private void BtnSupprimer_Click(object sender, EventArgs e)
        {

            DataRow currentRow = GVAdmin_Equipement_ListParent_Items.GetFocusedDataRow();
            if (null == currentRow)
            {
                MessageBox.Show("Il faut sélectionner un élément", "Erreur", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                return;
            }
            //on teste si l item de la liste est utilisé

            if (MessageBox.Show("Voulez-vous supprimer cet élément ?", "Confirmation", MessageBoxButtons.YesNoCancel, MessageBoxIcon.Question) == DialogResult.Yes)
            {
                currentRow.Delete();    
            }

        }

       
    }
}
