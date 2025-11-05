using DevExpress.Data;
using DevExpress.XtraEditors;
using DevExpress.XtraEditors.Repository;
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
    public partial class frmListeSitesAndEquipementInventaireSelectedByAction : Form
    {
                
        private int NACT_INV_ID;
        private int NACTNUM;
        private int NSITNUM;
        private int NCLINUM;
        private bool readOnly = false;

        decimal totnbselected;

        DataSet DS_Affect_Equip = new DataSet();

        private Rectangle footerCocheBounds;
        private SimpleButton btnFooterCocheButton;
        private Rectangle footerDeCocheBounds;
        private SimpleButton btnFooterDeCocheButton;

        public frmListeSitesAndEquipementInventaireSelectedByAction()
        {
            InitializeComponent();
        }

        public frmListeSitesAndEquipementInventaireSelectedByAction(int C_NACT_INV_ID, int C_NACTNUM, int C_NSITNUM, int C_NCLINUM, ref bool C_readOnly)
        {
            InitializeComponent();
            NACT_INV_ID = C_NACT_INV_ID;
            NACTNUM = C_NACTNUM;
            NSITNUM = C_NSITNUM;
            NCLINUM = C_NCLINUM;
            readOnly = C_readOnly;

        }

        private void frmListeSitesAndEquipementInventaireSelectedByAction_Load(object sender, EventArgs e)
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

                //init
                if (NSITNUM == 0) { this.Text = Label1.Text = $""; }

                LoadData();

                BtnSave.Visible = !readOnly;
                GV_ACT_INV_LIST_PARENT.OptionsBehavior.ReadOnly = readOnly;

               

            }
            catch (Exception ex)
            {
                MZUtils.displayError(MethodBase.GetCurrentMethod().Name, ex);
            }
            finally { Cursor.Current = Cursors.Default; }
        }       


        private void LoadData()
        {

            DataTable dt = new DataTable();
            dt.Load(ModuleData.ExecuteReader($"EXEC [api_sp_Action_Inventaire_Equipement_Liste_Parent] {NSITNUM}, {NACTNUM}, {NCLINUM}"));
            dt.Columns["BSELECTED"].ReadOnly = false;
            DS_Affect_Equip.Tables.Add(dt);
           
            //DataTable dt_element = new DataTable();
            //dt_element.Load(ModuleData.ExecuteReader($"EXEC [api_sp_Action_Inventaire_Equipement_Liste_Element] {NACT_INV_ID}, {NSITNUM}, {NACTNUM}"));           
            //DS_Affect_Equip.Tables.Add(dt_element);

            ////LEVEL 1
            //DataColumn parentColumn_Lvl_1 = DS_Affect_Equip.Tables[0].Columns["NACT_INV_ID"];
            //DataColumn childColumn_Lvl_1 = DS_Affect_Equip.Tables[1].Columns["NACT_INV_ID"];
            //DataRelation relation_Lvl_1 = new System.Data.DataRelation("NACT_INV_ID_LVL_1", parentColumn_Lvl_1, childColumn_Lvl_1);
            //DS_Affect_Equip.Relations.Add(relation_Lvl_1);

            //GC_ACT_INV.LevelTree.Nodes[0].RelationName = "NACT_INV_ID_LVL_1";

            //GV_ACT_INV_LIST_PARENT.ChildGridLevelName = "NACT_INV_ID_LVL_1";

            GC_ACT_INV.DataSource = DS_Affect_Equip.Tables[0];
            RefreshTotal();
        }       

        private void BtnSave_Click(object sender, EventArgs e)
        {
            //on test si un id d inventaire exists, si non on en crée un et on recupère son id
            using (SqlCommand sqlSave_Ing = new SqlCommand("[api_sp_Action_Inventaire_Equipement_Save]", MozartDatabase.cnxMozart))
            {
                sqlSave_Ing.CommandType = CommandType.StoredProcedure;
                SqlCommandBuilder.DeriveParameters(sqlSave_Ing);    // liste des paramètres

                // liste des paramètres
                sqlSave_Ing.Parameters["@P_NACT_INV_ID"].Value = this.NACT_INV_ID;
                sqlSave_Ing.Parameters["@P_NACTNUM"].Value = this.NACTNUM;

                // exécuter la commande.
                sqlSave_Ing.ExecuteNonQuery();

                // récupération du numéro crée
                NACT_INV_ID = Convert.ToInt32(sqlSave_Ing.Parameters[0].Value);

            }

            //on delete les equipements qui ne sont plus affectés au site


            //save equipement par equipement

            //string sqltest = "";

            if (DS_Affect_Equip.Tables[0] != null)
            {
                foreach (DataRow DrElementSave in DS_Affect_Equip.Tables[0].Rows)
                {

                    //si suppression
                    if (DrElementSave["EQUIPEMENT_TO_DELETE"] != null && (int)DrElementSave["EQUIPEMENT_TO_DELETE"] == 1)
                    {
                        ModuleData.ExecuteNonQuery($"EXEC [api_sp_Action_Inventaire_Equipement_Get_Type_Equipement_To_Delete] {NACT_INV_ID}, {DrElementSave["NIDEQUIPEMENT"]}");
                    }
                    else
                    {
                        //sinon
                        ModuleData.ExecuteNonQuery($"EXEC [api_sp_Action_Inventaire_Equipement_Element_Save] {this.NCLINUM}, {this.NSITNUM}, {DrElementSave["NIDEQUIPEMENT"]}, {NACT_INV_ID}, {DrElementSave["BSELECTED"]}");
                    }

                }
            }

            LoadData();

            MessageBox.Show("Enregistrement effectué", "Confirmation", MessageBoxButtons.OK, MessageBoxIcon.Information);           

        }        

       

        private void GV_ACT_INV_LIST_PARENT_CustomSummaryCalculate(object sender, DevExpress.Data.CustomSummaryEventArgs e)
        {
            GridView view = sender as GridView;
            List<string> list = new List<string>() {  "BSELECTED" };

            if (e.IsTotalSummary && list.Contains((e.Item as GridSummaryItem).FieldName))
            {
                //GridSummaryItem item = e.Item as GridSummaryItem;

                GridColumnSummaryItem item = e.Item as GridColumnSummaryItem;
                
                if (item.FieldName == "BSELECTED" && (int)item.Index == 0)
                {

                    switch (e.SummaryProcess)
                    {
                        case CustomSummaryProcess.Start:
                            totnbselected = 0;
                            break;
                        case CustomSummaryProcess.Calculate:
                            if (view.GetRowCellValue(e.RowHandle, "BSELECTED") != null && view.GetRowCellValue(e.RowHandle, "BSELECTED").ToString() != "" && (bool)view.GetRowCellValue(e.RowHandle, "BSELECTED") == true)
                            {
                                totnbselected = totnbselected + 1;
                            }
                            break;
                        case CustomSummaryProcess.Finalize:
                            e.TotalValue = $"{totnbselected} / {view.DataRowCount}";
                            break;
                    }
                }
            }
        }

        private void GV_ACT_INV_LIST_PARENT_CellValueChanged(object sender, DevExpress.XtraGrid.Views.Base.CellValueChangedEventArgs e)
        {
           
        }

        private void repositoryItemCheckEdit1_CheckStateChanged(object sender, EventArgs e)
        {
            GridView oView = (GridView)GC_ACT_INV.FocusedView;
            if (oView.FocusedRowHandle > -1)
            {

                DataRow DrReading = ((GridView)GC_ACT_INV.FocusedView).GetDataRow(oView.FocusedRowHandle);

                if (DrReading == null) return;                

                DrReading["BSELECTED"] = (bool)DrReading["BSELECTED"] == false ? true : false;

                // Console.WriteLine(oEQUIPEMENT_PREPA_INV_CLI._dt_Liste_Niv1.GetChanges().Rows.Count);

                //oEQUIPEMENT_PREPA_INV_CLI._dt_Liste_Niv1.AcceptChanges();
                oView.UpdateCurrentRow();
                oView.UpdateTotalSummary();

                GC_ACT_INV.Refresh();
                GC_ACT_INV.RefreshDataSource();

                RefreshTotal();

                return;
            }
        }

        private void RefreshTotal()
        {
            LblTotalHeures.Text = $"{GetTotalHeures()}";
            LblTotalMontant.Text = $"{GetTotalMontant()}";
        }

        private decimal GetTotalHeures()
        {
            List<int> List_Contrat_Distinct = new List<int>();

            decimal TotalHeures = 0;

            int rc = GV_ACT_INV_LIST_PARENT.DataRowCount;
            for (int i = 0; i < rc; i++)
            {
                int handle = GV_ACT_INV_LIST_PARENT.GetRowHandle(i);
                if (GV_ACT_INV_LIST_PARENT.IsValidRowHandle(handle))
                { 
                    DataRow drtot = GV_ACT_INV_LIST_PARENT.GetDataRow(handle);
                    if(drtot["BSELECTED"] != null && drtot["BSELECTED"].ToString() != ""  && (bool)drtot["BSELECTED"] == true)
                    {
                        //test si contrat exists deja pour ne pas compter plusieurs fois les heures
                        if(!List_Contrat_Distinct.Contains<int>((int)drtot["NTYPECONTRAT"]))
                        {
                            TotalHeures = TotalHeures + (decimal)drtot["NEQUIPEMENT_SIT_CONTRAT_DUREE"];
                            List_Contrat_Distinct.Add((int)drtot["NTYPECONTRAT"]);
                        }
                    }
                }

            }
            return TotalHeures;
        }

        private decimal GetTotalMontant()
        {
            List<int> List_Contrat_Distinct = new List<int>();

            decimal TotalMontant = 0;

            int rc = GV_ACT_INV_LIST_PARENT.DataRowCount;
            for (int i = 0; i < rc +2; i++)
            {
                int handle = GV_ACT_INV_LIST_PARENT.GetRowHandle(i);
                if (GV_ACT_INV_LIST_PARENT.IsValidRowHandle(handle))
                {
                    DataRow drtot = GV_ACT_INV_LIST_PARENT.GetDataRow(handle);
                    if (drtot["BSELECTED"] != null && drtot["BSELECTED"].ToString() != "" && (bool)drtot["BSELECTED"] == true)
                    {
                        //test si contrat exists deja pour ne pas compter plusieurs fois les heures
                        if (!List_Contrat_Distinct.Contains<int>((int)drtot["NTYPECONTRAT"]))
                        {
                            TotalMontant = TotalMontant + (decimal)drtot["NEQUIPEMENT_SIT_CONTRAT_MONTANT"];
                            List_Contrat_Distinct.Add((int)drtot["NTYPECONTRAT"]);
                        }
                    }
                }

            }
            return TotalMontant;
        }

        private void BtnVisuTrameEquipement_Click(object sender, EventArgs e)
        {
            if (NACT_INV_ID == 0) return;

            DataRow DrUp = GV_ACT_INV_LIST_PARENT.GetDataRow(GV_ACT_INV_LIST_PARENT.FocusedRowHandle);

            if (DrUp == null) return;   

            new frmActionInventaireEquipementDetails()
            {
                NACT_INV_ID = this.NACT_INV_ID,    
                NIDEQUIPEMENT = (int)DrUp["NIDEQUIPEMENT"],
                VTYPECONTRAT = DrUp["VTYPECONTRAT"].ToString(),
                VLIBEQUIPEMENT = DrUp["VLIBEQUIPEMENT"].ToString(),
                VFICHELIB = DrUp["VEQUIPEMENT_FICHE_LIB"].ToString(),

            }.ShowDialog();
        }

        private void GV_ACT_INV_LIST_PARENT_CustomDrawFooterCell(object sender, FooterCellCustomDrawEventArgs e)
        {
            if (e.Column.FieldName == "BSELECTED" )
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

                if (e.Info.SummaryItem.Index == 1 & !readOnly)
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
                if (e.Info.SummaryItem.Index == 2 & !readOnly)
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

        private void GV_ACT_INV_LIST_PARENT_MouseDown(object sender, MouseEventArgs e)
        {

            if (readOnly) return;

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
                            RefreshTotal();
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
                            RefreshTotal();
                        }
                    }));
                }

                return;
            }


        }

        private void GV_ACT_INV_LIST_PARENT_RowCellStyle(object sender, RowCellStyleEventArgs e)
        {
            GridView view = sender as GridView;
            if (view != null) return;
            if (e.Column.FieldName == "EQUIPEMENT_TO_DELETE")
            {
                if (e.CellValue != null && (int)e.CellValue == 1)
                {
                    e.Appearance.BackColor = Color.Red;
                }

            }
        }

        private void GV_ACT_INV_LIST_PARENT_CustomDrawCell(object sender, DevExpress.XtraGrid.Views.Base.RowCellCustomDrawEventArgs e)
        {
            GridView view = sender as GridView;
            if (view.GetRowCellValue(e.RowHandle, "EQUIPEMENT_TO_DELETE") == null) return;
            int _etat = (int)view.GetRowCellValue(e.RowHandle, "EQUIPEMENT_TO_DELETE");           
            if (e.Column.FieldName == "BSELECTED")
            {

               if(_etat == 1)
               {
                    e.DisplayText = "Equipement à supprimer car il n' est plus géré";                       
               }
              
            }
        }

        private void GV_ACT_INV_LIST_PARENT_CustomRowCellEdit(object sender, CustomRowCellEditEventArgs e)
        {
            if (e.RowHandle < 0) return;

            //on affiche la combo client si NEQUIPEMENT_FICHE_ITEM_CLI = 0
            if (e.Column.FieldName == "BSELECTED") // Replace with your column's field name
            {
                // Get the data value for the current cell (optional, for conditional logic)
                int etat = (int)GV_ACT_INV_LIST_PARENT.GetRowCellValue(e.RowHandle, G_Col_L0_EQUIPEMENT_TO_DELETE);

                if (etat == 0) { e.RepositoryItem = repositoryItemCheckEdit1; return; }
                if (etat == 1) { e.RepositoryItem = repositoryItemTextEdit1; return; }

            }
        }

        private void GV_ACT_INV_LIST_PARENT_CustomRowCellEditForEditing(object sender, CustomRowCellEditEventArgs e)
        {
            //if (e.RowHandle < 0) return;

            ////on affiche la combo client si NEQUIPEMENT_FICHE_ITEM_CLI = 0
            //if (e.Column.FieldName == "BSELECTED") // Replace with your column's field name
            //{
            //    // Get the data value for the current cell (optional, for conditional logic)
            //    int etat = (int)GV_ACT_INV_LIST_PARENT.GetRowCellValue(e.RowHandle, G_Col_L0_EQUIPEMENT_TO_DELETE);

            //    if (etat == 0) { e.RepositoryItem = null; return; }
            //    if (etat == 1) { e.RepositoryItem = repositoryItemCheckEdit1; return; }

            //}
        }

        private void GV_ACT_INV_LIST_PARENT_ShowingEditor(object sender, CancelEventArgs e)
        {
            GridView view = sender as GridView;
            int cellValue = (int)view.GetRowCellValue(view.FocusedRowHandle, G_Col_L0_EQUIPEMENT_TO_DELETE);
            e.Cancel = cellValue == 1;
        }

        private void GV_ACT_INV_LIST_PARENT_RowStyle(object sender, RowStyleEventArgs e)
        {
            GridView view = sender as GridView;
            if (view == null) return;
            DataRow dr = view.GetDataRow(e.RowHandle);
            if (dr == null) return;

            if (dr["EQUIPEMENT_TO_DELETE"] != null && (int)dr["EQUIPEMENT_TO_DELETE"] == 1)
            {               
                e.Appearance.BackColor = Color.Red;               

            }
        }
    }
}


//public class CTotalHeuresAndMontantInventaireEquipement
//{
//    public decimal TotalHeures;
//    public decimal TotalMontant;
//}