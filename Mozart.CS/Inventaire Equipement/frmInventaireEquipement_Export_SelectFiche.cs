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
using DevExpress.XtraGrid.Views.Base;
using DevExpress.XtraGrid.Views.Grid;
using DevExpress.XtraGrid.Views.Grid.ViewInfo;
using GridView = DevExpress.XtraGrid.Views.Grid.GridView;

namespace MozartCS.Inventaire_Equipement
{
    public partial class frmInventaireEquipement_Export_SelectFiche : Form
    {

        public List<int> LstInvFicheSelected;
        List<int> LstInvSitesSelected;
        DataTable dtListeFicheInvEquip;

        public bool Cancel { get; set; } = false;

        public frmInventaireEquipement_Export_SelectFiche(List<int> c_LstInvFichesSelected, List<int> c_LstInvSitesSelected)
        {
            InitializeComponent();
            LstInvFicheSelected = c_LstInvFichesSelected;
            LstInvSitesSelected = c_LstInvSitesSelected;
        }

        private void frmInventaireEquipement_Export_SelectFiche_Load(object sender, EventArgs e)
        {
            dtListeFicheInvEquip = new DataTable();
            dtListeFicheInvEquip.Load(MozartDatabase.ExecuteReader($"EXEC [api_sp_InvEquip_Export_listeFiches] '{string.Join(",", LstInvSitesSelected)}'", 0));

            dtListeFicheInvEquip.Columns["CHECK"].ReadOnly = false;

            GCFiches.DataSource = dtListeFicheInvEquip;
        }

        private void BtnCancel_Click(object sender, EventArgs e)
        {
            Cancel = true;
            Close();
        }

        private void BtnNext_Click(object sender, EventArgs e)
        {
            if(dtListeFicheInvEquip.Select("CHECK = true").Length == 0)
            {
                MessageBox.Show("Veuillez sélectionner au moins une fiche d'inventaire.", "Avertissement", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            // Fix: Extract the NSIT_INV_ID values from the selected rows and convert them to a List<int>
            LstInvFicheSelected = dtListeFicheInvEquip
                .Select("CHECK = true")
                .Select(row => Convert.ToInt32(row["NID_EQUIPEMENT_FICHE"]))
                .ToList();

            Close();
        }

        private void BtnSelectAll_Click(object sender, EventArgs e)
        {
            DevExpress.XtraGrid.Views.Grid.GridView view = GVFiches;

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
            DevExpress.XtraGrid.Views.Grid.GridView view = GVFiches;

            if (view.ActiveFilter != null) { }

            this.BeginInvoke(new MethodInvoker(() =>
            {

                if (MessageBox.Show($"Voulez-vous décocher toutes les lignes {(view.ActiveFilter != null ? "filtrées" : "")} ?", "Confirmation", MessageBoxButtons.YesNoCancel, MessageBoxIcon.Question) == DialogResult.Yes)
                {
                    for (int i = 0; i < view.DataRowCount; i++)
                    {

                        view.SetRowCellValue(i, GCol_CHECK, false);
                        view.PostEditor();
                        view.UpdateCurrentRow();
                    }
                }
            }));
            return;
        }

        private void GVFiches_CustomDrawFooter(object sender, DevExpress.XtraGrid.Views.Base.RowObjectCustomDrawEventArgs e)
        {
            Rectangle oPos = e.Bounds;
            StringFormat oFormat = new StringFormat();
            oPos.Location = new Point(oPos.Left + 1, oPos.Top + 1);
            oPos.Size = new Size(oPos.Width - 2, oPos.Height - 2);
            oFormat.Alignment = StringAlignment.Center;
            DataTable DtTmp = GCFiches.DataSource as DataTable;

            if (DtTmp != null)
            {
                e.Appearance.DrawString(e.Cache, $"Nb fiche(s) cochée(s): {DtTmp.Select("[CHECK] = 1").Length}  / {DtTmp.Rows.Count}", oPos, oFormat);
            }

            e.Handled = true;
        }

        private void repositoryItemCheckEdit1_CheckStateChanged(object sender, EventArgs e)
        {
            GridView oView = (GridView)GCFiches.FocusedView;
            if (oView.FocusedRowHandle > -1)
            {

                DataRow DrReading = ((GridView)GCFiches.FocusedView).GetDataRow(oView.FocusedRowHandle);

                if (DrReading == null) return;

                DrReading["CHECK"] = (bool)DrReading["CHECK"] == false ? true : false;

                oView.UpdateCurrentRow();
                oView.UpdateTotalSummary();

                GCFiches.Refresh();
                GCFiches.RefreshDataSource();

                return;
            }
        }
    }
}
