using DevExpress.Utils.Drawing;
using DevExpress.XtraEditors.Controls;
using DevExpress.XtraEditors.Drawing;
using DevExpress.XtraGrid;
using DevExpress.XtraGrid.Columns;
using DevExpress.XtraGrid.Views.Base;
using DevExpress.XtraGrid.Views.Grid;
using DevExpress.XtraPrinting;
using MozartCS.Properties;
using MozartLib;
using MozartNet;
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

namespace MozartCS
{
    public partial class frmMethodes_Prepa_Inventaire : Form
    {

        DataTable dt = new DataTable();

        public frmMethodes_Prepa_Inventaire()
        {
            InitializeComponent();
        }

        private void BtnClose_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void frmMethodes_Admin_Equipement_Load(object sender, EventArgs e)
        {

            //INIT  
            ModuleMain.Initboutons(this);

            LoadData();
            FormatApiTGrid();

        }

        public void LoadData()
        {
            ModuleData.LoadData(dt, $"EXEC [api_sp_Equipement_Liste_Clients_Inventaire]", MozartDatabase.cnxMozart);
        }

        public void FormatApiTGrid()
        {
            try
            {
                apiTGrid1.AddColumn(Resources.col_Nom, "VCLINOM", 2800);
                apiTGrid1.AddColumn(Resources.col_Adresse1, "VCLIAD1", 2100);
                apiTGrid1.AddColumn(Resources.col_Adresse2, "VCLIAD2", 1200);
                apiTGrid1.AddColumn(Resources.col_CP, "VCLICP", 700);
                apiTGrid1.AddColumn(Resources.col_Ville, "VCLIVIL", 1700);
                apiTGrid1.AddColumn(Resources.col_Pays, "VCLIPAYS", 800);
                apiTGrid1.AddColumn("Equipements affectés", "EQUIP_AFFECT", 700);
                apiTGrid1.AddColumn("NumCli", "NCLINUM", 0);

                apiTGrid1.GridControl.DataSource = dt;
            }
            catch (Exception ex)
            {
                MZUtils.displayError(MethodBase.GetCurrentMethod().Name, ex);
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {

            DataRow currentRow = apiTGrid1.GetFocusedDataRow();
            if (null == currentRow) return;

            frmMethodes_Prepa_Inventaire_Client ofrmMethodes_Prepa_Inventaire_Client = new frmMethodes_Prepa_Inventaire_Client();
            ofrmMethodes_Prepa_Inventaire_Client.sNomClient = currentRow["VCLINOM"].ToString();
            ofrmMethodes_Prepa_Inventaire_Client.iNCLINUM = (Int32)currentRow["NCLINUM"];
            ofrmMethodes_Prepa_Inventaire_Client.ShowDialog();
            ofrmMethodes_Prepa_Inventaire_Client.Dispose();

            LoadData();

        }

        private void BtnAffectInvSite_Click(object sender, EventArgs e)
        {
            DataRow currentRow = apiTGrid1.GetFocusedDataRow();
            if (null == currentRow) return;

            frmMethodes_Affect_Inventaire_Site ofrmMethodes_Affect_Inventaire_Site = new frmMethodes_Affect_Inventaire_Site();
            ofrmMethodes_Affect_Inventaire_Site.sNomClient = currentRow["VCLINOM"].ToString();
            ofrmMethodes_Affect_Inventaire_Site.iNCLINUM = (Int32)currentRow["NCLINUM"];
            ofrmMethodes_Affect_Inventaire_Site.ShowDialog();
            ofrmMethodes_Affect_Inventaire_Site.Dispose();

            LoadData();
        }
    }
}
