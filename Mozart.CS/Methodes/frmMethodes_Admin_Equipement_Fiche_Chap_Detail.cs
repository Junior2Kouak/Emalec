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
    public partial class frmMethodes_Admin_Equipement_Fiche_Chap_Detail : Form
    {

        int _NID_EQUIPEMENT_FICHE_CHAP;
        int _NID_EQUIPEMENT_FICHE;

        CEQUIPEMENT_CHAPITRE oCEQUIPEMENT_FICHE_CHAP;

        public frmMethodes_Admin_Equipement_Fiche_Chap_Detail(int c_NID_EQUIPEMENT_FICHE_CHAP, int C_NID_EQUIPEMENT_FICHE)
        {
            InitializeComponent();
            _NID_EQUIPEMENT_FICHE_CHAP = c_NID_EQUIPEMENT_FICHE_CHAP;
            _NID_EQUIPEMENT_FICHE = C_NID_EQUIPEMENT_FICHE;
        }     

        private void BtnClose_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void frmMethodes_Admin_Equipement_Fiche_Load(object sender, EventArgs e)
        {

            //INIT  
            ModuleMain.Initboutons(this);
            
            LoadData();
        }

        private void LoadData()
        {
            oCEQUIPEMENT_FICHE_CHAP = new CEQUIPEMENT_CHAPITRE(_NID_EQUIPEMENT_FICHE_CHAP, _NID_EQUIPEMENT_FICHE);
            txtNomChapitre.Text = oCEQUIPEMENT_FICHE_CHAP.VEQUIPEMENT_FICHE_CHAP_LIB;
            ChkActif.Checked = oCEQUIPEMENT_FICHE_CHAP.BEQUIPEMENT_FICHE_CHAP_ACTIF;
            TxtNumOrdreAffichage.Text = oCEQUIPEMENT_FICHE_CHAP.NEQUIPEMENT_FICHE_CHAP_ORDER_AFFICH.ToString();

        }        

        private void BtnSave_Click(object sender, EventArgs e)
        {
            if (oCEQUIPEMENT_FICHE_CHAP == null) return;

            if (txtNomChapitre.Text == "")
            {
                MessageBox.Show("Il faut saisir un libellé", "Erreur", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                return;
            }

            oCEQUIPEMENT_FICHE_CHAP.VEQUIPEMENT_FICHE_CHAP_LIB = txtNomChapitre.Text;
            oCEQUIPEMENT_FICHE_CHAP.NEQUIPEMENT_FICHE_CHAP_ORDER_AFFICH = Convert.ToInt32(TxtNumOrdreAffichage.Text);
            oCEQUIPEMENT_FICHE_CHAP.BEQUIPEMENT_FICHE_CHAP_ACTIF = ChkActif.Checked;

            _NID_EQUIPEMENT_FICHE_CHAP = CEQUIPEMENT_CHAPITRE.Save(_NID_EQUIPEMENT_FICHE_CHAP, _NID_EQUIPEMENT_FICHE, Convert.ToInt32(TxtNumOrdreAffichage.Text), txtNomChapitre.Text, ChkActif.Checked);

        }

        private void ChkActif_CheckedChanged(object sender, EventArgs e)
        {            
            if(!ChkActif.Checked)
            {
                if(CEQUIPEMENT_CHAPITRE.ChapitreAffected(_NID_EQUIPEMENT_FICHE_CHAP) && MessageBox.Show($"Ce chapitre est affecté à un ou plusieurs items de la fiche.\r\nSi vous archivez ce chapitre, il faudra réaffecter les éléments de la fiche équipement sur un chapitre actif.\r\nVoulez-vous continuer ?", "Confirmation", MessageBoxButtons.YesNoCancel, MessageBoxIcon.Exclamation) != DialogResult.Yes)
                {
                    ChkActif.Checked = true;
                }                
            }

        }
    }
}
