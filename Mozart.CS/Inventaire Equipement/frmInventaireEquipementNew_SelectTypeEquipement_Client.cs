using MozartNet;
using MozartUC;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Reflection;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using MZUtils = MozartControls.Utils;

namespace MozartCS.Inventaire_Equipement
{
    public partial class frmInventaireEquipementNew_SelectTypeEquipement_Client : Form
    {

        public int NCLINUM;
        public string vclinom;

        DataTable DtDetails;

        public frmInventaireEquipementNew_SelectTypeEquipement_Client()
        {
            InitializeComponent();
        }

        private void frmInventaireEquipementNew_SelectTypeEquipement_Client_Load(object sender, EventArgs e)
        {
            try
            {
                Cursor.Current = Cursors.WaitCursor;
                ModuleMain.Initboutons(this);

                this.Text = LblTitre.Text = $"{LblTitre.Text}";

                LoadData();

            }
            catch (Exception ex)
            {
                MZUtils.displayError(MethodBase.GetCurrentMethod().Name, ex);
            }
            finally { Cursor.Current = Cursors.Default; }
        }

        private void LoadData()
        {
            DtDetails = new DataTable();

            ModuleData.LoadData(DtDetails, $"EXEC [api_sp_InvEquip_ListeEquipementByClientAndContrat] {NCLINUM}");

            GC_LIST_EQUIP_CLI.DataSource = DtDetails;

        }

        private void cmdQuitter_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void BtnSelected_Click(object sender, EventArgs e)
        {

            DataRow row = GV_LIST_EQUIP_CLI.GetFocusedDataRow();
            if (null == row) return;

            new frmInventaireEquipementDetails()
            {                
                NSIT_INV_EQUIPEMENT_RECEIVE_ID = 0,
                VTYPECONTRAT = row == null ? "" : row["VTYPECONTRAT"].ToString(),
                VLIBEQUIPEMENT = row == null ? "" : row["VLIBEQUIPEMENT"].ToString(),
                NSITNUM = row == null ? 0 : (int)row["NSITNUM"],
                NIDEQUIPEMENT = row == null ? 0 : (int)row["NIDEQUIPEMENT"],
                vclinom = vclinom,
                vsitnom = row == null ? "" : row["VSITNOM"].ToString()
            }.ShowDialog();

            Close();
        }

       
    }
}
