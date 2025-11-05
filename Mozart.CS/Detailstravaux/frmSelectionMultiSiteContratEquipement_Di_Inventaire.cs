using DevExpress.Data;
using DevExpress.XtraEditors;
using DevExpress.XtraGrid;
using DevExpress.XtraGrid.Views.Grid;
using DevExpress.XtraGrid.Views.Grid.ViewInfo;
using MozartCS.Properties;
using MozartLib;
using MozartNet;
using MozartUC;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Reflection;
using System.Security.Cryptography.X509Certificates;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using MZUtils = MozartControls.Utils;

namespace MozartCS
{
    public partial class frmSelectionMultiSiteContratEquipement_Di_Inventaire : Form
    {
        public int nclinum;
        public bool mbAnnulerChoix = true;
        public DataTable Dt_Affect_Equip;
        int totnbselected = 0;

        private Rectangle footerCocheBounds;
        private SimpleButton btnFooterCocheButton;
        private Rectangle footerDeCocheBounds;
        private SimpleButton btnFooterDeCocheButton;
        public frmSelectionMultiSiteContratEquipement_Di_Inventaire()
        {
            InitializeComponent();
        }

        private void frmSelectionMultiSiteContratEquipement_Di_Inventaire_Load(object sender, EventArgs e)
        {
            try
            {
                Cursor.Current = Cursors.WaitCursor;

                // Create a button Coche
                btnFooterCocheButton = new SimpleButton();
                btnFooterCocheButton.Text = "Cocher tous";
                btnFooterCocheButton.Size = new System.Drawing.Size(140, 25);

                // Create a button Decoche
                btnFooterDeCocheButton = new SimpleButton();
                btnFooterDeCocheButton.Text = "Décocher tous";
                btnFooterDeCocheButton.Size = new System.Drawing.Size(140, 25);

                ModuleMain.Initboutons(this);             

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

            Dt_Affect_Equip = new DataTable();
            Dt_Affect_Equip.Load(ModuleData.ExecuteReader($"EXEC [api_sp_Action_Inventaire_SelectionEquipementMultiSiteBySiteAndContrat] {nclinum}"));
            Dt_Affect_Equip.Columns["BSELECTED"].ReadOnly = false;
          
            GC_SELECTED.DataSource = Dt_Affect_Equip;

        }

        private void cmdQuitter_Click(object sender, EventArgs e)
        {
            mbAnnulerChoix = true;
            Close();
        }

        private void BtnSave_Click(object sender, EventArgs e)
        {

            //test il faut sélectionner au moins un site et un équipement
            //test si rows oblgatoire sans réponse            

            GV_SELECTED.SetAutoFilterValue(G_Col_L0_BSELECTED, true, DevExpress.XtraGrid.Columns.AutoFilterCondition.Equals);

            if (GV_SELECTED.DataRowCount == 0)
            { 
                MessageBox.Show("La validation est impossible car aucun équipement n'a été sélectionné", "Erreur", MessageBoxButtons.OK, MessageBoxIcon.Error);
                GV_SELECTED.ResetAutoFilterCondition(G_Col_L0_BSELECTED);
                return;
            }


            //DataRow DrTest;

            //for (int i = 0; i < this.GV_SELECTED.RowCount; i++)
            //{




            //    int currentRowHandle = GV_SELECTED.GetRowHandle(i);
            //    DrTest = this.GV_SELECTED.GetDataRow(currentRowHandle);
            //    if (DrTest != null && DrTest["BSELECTED"] != null && ((bool)DrTest["BSELECTED"] == true))
            //    {                    
            //        MessageBox.Show("La validation est impossible car aucun site n'a été sélectionné", "Erreur", MessageBoxButtons.OK, MessageBoxIcon.Error);
            //        return;
            //    }
            //}

            mbAnnulerChoix = false;


            this.Close();

            ////on test si un id d inventaire exists, si non on en crée un et on recupère son id
            //using (SqlCommand sqlSave_Ing = new SqlCommand("[api_sp_Action_Inventaire_Equipement_Save]", MozartDatabase.cnxMozart))
            //{
            //    sqlSave_Ing.CommandType = CommandType.StoredProcedure;
            //    SqlCommandBuilder.DeriveParameters(sqlSave_Ing);    // liste des paramètres

            //    // liste des paramètres
            //    sqlSave_Ing.Parameters["@P_NACT_INV_ID"].Value = this.NACT_INV_ID;
            //    sqlSave_Ing.Parameters["@P_NACTNUM"].Value = this.NACTNUM;

            //    // exécuter la commande.
            //    sqlSave_Ing.ExecuteNonQuery();

            //    // récupération du numéro crée
            //    NACT_INV_ID = Convert.ToInt32(sqlSave_Ing.Parameters[0].Value);

            //}

            ////save equipement par equipement
            //if (DS_Affect_Equip.Tables[0] != null)
            //{
            //    foreach (DataRow DrElementSave in DS_Affect_Equip.Tables[0].Rows)
            //    {
            //        ModuleData.ExecuteNonQuery($"EXEC [api_sp_Action_Inventaire_Equipement_Element_Save] {this.NCLINUM}, {this.NSITNUM}, {DrElementSave["NIDEQUIPEMENT"]}, {NACT_INV_ID}, {DrElementSave["BSELECTED"]}");    
            //    }
            //}
        }
                       

        private void GV_ACT_INV_LIST_PARENT_CustomSummaryCalculate(object sender, DevExpress.Data.CustomSummaryEventArgs e)
        {
            GridView view = sender as GridView;
            List<string> list = new List<string>() {  "BSELECTED" };

            if (e.IsTotalSummary && list.Contains((e.Item as GridSummaryItem).FieldName))
            {
                GridSummaryItem item = e.Item as GridSummaryItem;
                
                if (item.FieldName == "BSELECTED")
                {
                    switch (e.SummaryProcess)
                    {
                        case CustomSummaryProcess.Start:
                            totnbselected = 0;
                            break;
                        case CustomSummaryProcess.Calculate:
                            if ((bool)view.GetRowCellValue(e.RowHandle, "BSELECTED") == true)
                            {
                                totnbselected = totnbselected + 1;
                            }
                            break;
                        case CustomSummaryProcess.Finalize:
                            e.TotalValue = totnbselected;
                            break;
                    }
                }
            }
        }             

        private void repositoryItemCheckEdit1_CheckStateChanged(object sender, EventArgs e)
        {
            GridView oView = (GridView)GC_SELECTED.FocusedView;
            if (oView.FocusedRowHandle > -1)
            {

                DataRow DrReading = ((GridView)GC_SELECTED.FocusedView).GetDataRow(oView.FocusedRowHandle);

                if (DrReading == null) return;                

                DrReading["BSELECTED"] = (bool)DrReading["BSELECTED"] == false ? true : false;

                // Console.WriteLine(oEQUIPEMENT_PREPA_INV_CLI._dt_Liste_Niv1.GetChanges().Rows.Count);

                //oEQUIPEMENT_PREPA_INV_CLI._dt_Liste_Niv1.AcceptChanges();
                oView.UpdateCurrentRow();
                oView.UpdateTotalSummary();

                GC_SELECTED.Refresh();
                GC_SELECTED.RefreshDataSource();
                              
                return;
            }
        }

        private void frmSelectionMultiSiteContratEquipement_Di_Inventaire_FormClosing(object sender, FormClosingEventArgs e)
        {
            //if (e.CloseReason == CloseReason.UserClosing | e.CloseReason == CloseReason.WindowsShutDown) mbAnnulerChoix = true; return;            
        }

        private void GV_SELECTED_CustomDrawFooter(object sender, DevExpress.XtraGrid.Views.Base.RowObjectCustomDrawEventArgs e)
        {
            
        }

        private void GV_SELECTED_CustomDrawFooterCell(object sender, FooterCellCustomDrawEventArgs e)
        {
            if (e.Column.FieldName == "BSELECTED")
            {
                e.Handled = true;

                if (e.Info.SummaryItem.Index == 0)
                {

                    string footerEquipSelected = $"Total sélectionné(s) : {e.Info.Value.ToString()}";
                    //Bouton Coche
                    // Calculate button dimensions and position
                    footerCocheBounds = new Rectangle(e.Bounds.X,
                                                e.Bounds.Y,
                                                e.Bounds.Width,
                                                e.Bounds.Height);

                    e.Graphics.DrawRectangle(Pens.Black, footerCocheBounds);
                    e.Graphics.FillRectangle(Brushes.White, footerCocheBounds.X + 1, footerCocheBounds.Y + 1,
                                            footerCocheBounds.Width - 2, footerCocheBounds.Height - 2);

                    Size textSizeBtnFooterCoche = TextRenderer.MeasureText(footerEquipSelected, e.Appearance.Font);

                    e.Graphics.DrawString(footerEquipSelected, e.Appearance.Font, Brushes.Black,
                                            footerCocheBounds.X + ((footerCocheBounds.Width - textSizeBtnFooterCoche.Width) / 2), footerCocheBounds.Y + ((footerCocheBounds.Height - textSizeBtnFooterCoche.Height) / 2));
                    return;

                }

                if (e.Info.SummaryItem.Index == 1)
                {
                    //Bouton Coche
                    // Calculate button dimensions and position
                    footerCocheBounds = new Rectangle(e.Bounds.X,
                                                e.Bounds.Y,
                                                e.Bounds.Width,
                                                e.Bounds.Height);

                    e.Graphics.DrawRectangle(Pens.Black, footerCocheBounds);
                    e.Graphics.FillRectangle(Brushes.LightGray, footerCocheBounds.X + 1, footerCocheBounds.Y + 1,
                                            footerCocheBounds.Width - 2, footerCocheBounds.Height - 2);

                    Size textSizeBtnFooterCoche = TextRenderer.MeasureText(btnFooterCocheButton.Text, e.Appearance.Font);

                    e.Graphics.DrawString(btnFooterCocheButton.Text, e.Appearance.Font, Brushes.Black,
                                            footerCocheBounds.X + ((footerCocheBounds.Width - textSizeBtnFooterCoche.Width) / 2), footerCocheBounds.Y + ((footerCocheBounds.Height - textSizeBtnFooterCoche.Height) / 2));
                    return;

                }
                if (e.Info.SummaryItem.Index == 2)
                {
                    //Bouton Coche
                    // Calculate button dimensions and position
                    footerDeCocheBounds = new Rectangle(e.Bounds.X,
                                                e.Bounds.Y,
                                                e.Bounds.Width,
                                                e.Bounds.Height);

                    e.Graphics.DrawRectangle(Pens.Black, footerDeCocheBounds);
                    e.Graphics.FillRectangle(Brushes.LightGray, footerDeCocheBounds.X + 1, footerDeCocheBounds.Y + 1,
                                            footerDeCocheBounds.Width - 2, footerDeCocheBounds.Height - 2);

                    Size textSizeBtnFooterDeCoche = TextRenderer.MeasureText(btnFooterDeCocheButton.Text, e.Appearance.Font);

                    e.Graphics.DrawString(btnFooterDeCocheButton.Text, e.Appearance.Font, Brushes.Black,
                                            footerDeCocheBounds.X + ((footerDeCocheBounds.Width - textSizeBtnFooterDeCoche.Width) / 2), footerDeCocheBounds.Y + ((footerDeCocheBounds.Height - textSizeBtnFooterDeCoche.Height) / 2));
                    return;

                }


            }
        }

        private void GV_SELECTED_MouseDown(object sender, MouseEventArgs e)
        {
            GridView view = (GridView)sender;

            GridHitInfo hitInfo = view.CalcHitInfo(e.Location);
            if (hitInfo.HitTest != GridHitTest.Footer) return;


            //bouton coche tous
            if (e.Location.X > footerCocheBounds.X & e.Location.X < footerCocheBounds.X + footerCocheBounds.Width & e.Location.Y > footerCocheBounds.Y & e.Location.Y < footerCocheBounds.Y + footerCocheBounds.Height)
            {
                if (e.Button == MouseButtons.Left)
                {
                    if (view.ActiveFilter != null) { }

                    this.BeginInvoke(new MethodInvoker(() =>
                    {

                        if (MessageBox.Show($"Voulez-vous cocher tous les équipements {(view.ActiveFilter != null ? "filtrées" : "")} ?", "Confirmation", MessageBoxButtons.YesNoCancel, MessageBoxIcon.Question) == DialogResult.Yes)
                        {

                            for (int i = 0; i < view.DataRowCount; i++)
                            {
                                view.SetRowCellValue(i, G_Col_L0_BSELECTED, true);
                                view.PostEditor();
                                view.UpdateCurrentRow();
                            }                           
                        }
                    }));
                }

                return;
            }

            //bouton decoche tous
            if (e.Location.X > footerDeCocheBounds.X & e.Location.X < footerDeCocheBounds.X + footerDeCocheBounds.Width & e.Location.Y > footerDeCocheBounds.Y & e.Location.Y < footerDeCocheBounds.Y + footerDeCocheBounds.Height)
            {
                if (e.Button == MouseButtons.Left)
                {
                    if (view.ActiveFilter != null) { }

                    this.BeginInvoke(new MethodInvoker(() =>
                    {

                        if (MessageBox.Show($"Voulez-vous décocher tous les équipements {(view.ActiveFilter != null ? "filtrées" : "")} ?", "Confirmation", MessageBoxButtons.YesNoCancel, MessageBoxIcon.Question) == DialogResult.Yes)
                        {

                            for (int i = 0; i < view.DataRowCount; i++)
                            {
                                view.SetRowCellValue(i, G_Col_L0_BSELECTED, false);
                                view.PostEditor();
                                view.UpdateCurrentRow();
                            }                            
                        }
                    }));
                }

                return;
            }
        }
    }
}
