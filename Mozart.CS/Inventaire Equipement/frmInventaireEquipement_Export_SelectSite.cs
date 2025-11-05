using MozartLib;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Web.UI.WebControls;
using System.Windows.Forms;
using ZXing;
using DevExpress.XtraGrid.Views.Base;
using DevExpress.XtraGrid.Views.Grid;
using DevExpress.XtraGrid.Views.Grid.ViewInfo;
using GridView = DevExpress.XtraGrid.Views.Grid.GridView;

namespace MozartCS.Inventaire_Equipement
{
    public partial class frmInventaireEquipement_Export_SelectSite: Form
    {

        public List<int> LstInvSitesSelected;
        DataTable dtListeinvSites;

        int NCLINUM;

        public bool Cancel { get; set; } = false;

        public frmInventaireEquipement_Export_SelectSite(List<int> c_LstInvSitesSelected, int C_NCLINUM)
        {
            InitializeComponent();
            LstInvSitesSelected = c_LstInvSitesSelected;
            NCLINUM = C_NCLINUM;
        }
        private void frmInventaireEquipement_Export_SelectSite_Load(object sender, EventArgs e)
        {
            dtListeinvSites = new DataTable();
            dtListeinvSites.Load(MozartDatabase.ExecuteReader($"EXEC api_sp_InvEquip_Export_listeSites {NCLINUM}", 0));
            
            foreach(int NSIT_INV_ID in LstInvSitesSelected)
            {
                DataRow[] rows = dtListeinvSites.Select($"NSIT_INV_ID = {NSIT_INV_ID}");
                if (rows.Length > 0)
                {
                    rows[0]["CHECK"] = true;
                }
            }

            dtListeinvSites.Columns["CHECK"].ReadOnly = false;

            GCInvSites.DataSource = dtListeinvSites;
        }

        private void BtnCancel_Click(object sender, EventArgs e)
        {
            Cancel = true;
            Close();
        }

        private void BtnNext_Click(object sender, EventArgs e)
        {

            if(dtListeinvSites.Select("CHECK = true").Length == 0)
            {
                MessageBox.Show("Veuillez sélectionner au moins un site d'inventaire.", "Avertissement", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            // Fix: Extract the NSIT_INV_ID values from the selected rows and convert them to a List<int>
            LstInvSitesSelected = dtListeinvSites
                .Select("CHECK = true")
                .Select(row => Convert.ToInt32(row["NSIT_INV_ID"]))
                .ToList();

            Close();
        }

        private void BtnSelectAll_Click(object sender, EventArgs e)
        {
            DevExpress.XtraGrid.Views.Grid.GridView view = GVInvSites;

            if (view.ActiveFilter != null) { }

            this.BeginInvoke(new MethodInvoker(() =>
            {

                if (MessageBox.Show($"Voulez-vous cocher toutes les lignes {(view.ActiveFilter != null ? "filtrées" : "")} ?", "Confirmation", MessageBoxButtons.YesNoCancel, MessageBoxIcon.Question) == DialogResult.Yes)
                {
                    for (int i = 0; i < view.DataRowCount; i++)
                    {                       
                        view.SetRowCellValue(i, GCol_CHECK, true);
                        view.PostEditor();
                        view.UpdateCurrentRow();
                    }
                }
            }));
            return;
        }

        private void BtnDecocheAll_Click(object sender, EventArgs e)
        {
            DevExpress.XtraGrid.Views.Grid.GridView view = GVInvSites;

            if (view.ActiveFilter != null) { }

            this.BeginInvoke(new MethodInvoker(() =>
            {

                if (MessageBox.Show($"Voulez-vous décocher toutes les lignes {(view.ActiveFilter != null ? "filtrées" : "")} ?", "Confirmation", MessageBoxButtons.YesNoCancel, MessageBoxIcon.Question) == DialogResult.Yes)
                {
                    for (int i = 0; i < view.DataRowCount; i++)                    {
                        
                        view.SetRowCellValue(i, GCol_CHECK, false);
                        view.PostEditor();
                        view.UpdateCurrentRow();
                    }
                }
            }));
            return;
        }

        private void GVInvSites_CustomDrawFooter(object sender, RowObjectCustomDrawEventArgs e)
        {          

            Rectangle oPos = e.Bounds;
            StringFormat oFormat = new StringFormat();
            oPos.Location = new Point(oPos.Left + 1, oPos.Top + 1);
            oPos.Size = new Size(oPos.Width - 2, oPos.Height - 2);
            oFormat.Alignment = StringAlignment.Center;
            DataTable DtTmp = GCInvSites.DataSource as DataTable;

            if (DtTmp != null)
            {
                e.Appearance.DrawString(e.Cache, $"Nb site(s) coché(s): {DtTmp.Select("[CHECK] = 1").Length}  / {DtTmp.Rows.Count}", oPos, oFormat);
            }

            e.Handled = true;

        }

        private void repositoryItemCheckEdit1_CheckStateChanged(object sender, EventArgs e)
        {
            GridView oView = (GridView)GCInvSites.FocusedView;
            if (oView.FocusedRowHandle > -1)
            {

                DataRow DrReading = ((GridView)GCInvSites.FocusedView).GetDataRow(oView.FocusedRowHandle);

                if (DrReading == null) return;

                DrReading["CHECK"] = (bool)DrReading["CHECK"] == false ? true : false;
              
                oView.UpdateCurrentRow();
                oView.UpdateTotalSummary();

                GCInvSites.Refresh();
                GCInvSites.RefreshDataSource();                

                return;
            }
        }
    }
}
