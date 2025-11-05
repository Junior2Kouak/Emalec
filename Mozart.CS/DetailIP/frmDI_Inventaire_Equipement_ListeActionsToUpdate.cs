using DevExpress.CodeParser;
using DevExpress.Data;
using DevExpress.Utils;
using DevExpress.XtraEditors;
using DevExpress.XtraGrid;
using DevExpress.XtraGrid.Views.Grid;
using DevExpress.XtraGrid.Views.Grid.ViewInfo;
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

namespace MozartCS.DetailIP
{
    public partial class frmDI_Inventaire_Equipement_ListeActionsToUpdate : Form
    {
        public int ndinnum;

        int totnbselected = 0;

        DataTable dtInventaire;

        private Rectangle footerCocheBounds;
        private SimpleButton btnFooterCocheButton;
        private Rectangle footerDeCocheBounds;
        private SimpleButton btnFooterDeCocheButton;
        public frmDI_Inventaire_Equipement_ListeActionsToUpdate()
        {
            InitializeComponent();
        }

        private void frmDI_Inventaire_Equipement_ListeActionsToUpdate_Load(object sender, EventArgs e)
        {
            try
            {
                // Create a button Coche
                btnFooterCocheButton = new SimpleButton();
                btnFooterCocheButton.Text = "Cocher tous";
                btnFooterCocheButton.Size = new System.Drawing.Size(140, 25);

                // Create a button Decoche
                btnFooterDeCocheButton = new SimpleButton();
                btnFooterDeCocheButton.Text = "Décocher tous";
                btnFooterDeCocheButton.Size = new System.Drawing.Size(140, 25);

                Cursor.Current = Cursors.WaitCursor;
                ModuleMain.Initboutons(this);

                LoadData();

            } 
            catch (Exception ex) { Utils.ShowError(ex, $"{MethodBase.GetCurrentMethod().Name} dans {this.Name}"); }
            finally { Cursor.Current = Cursors.Default; }
        }

        private void LoadData()
        {

            DataTable dtInventaire = new DataTable();
            dtInventaire.Load(ModuleData.ExecuteReader($"EXEC [api_sp_Action_Inventaire_Equipement_UpdateTrameByDI] {ndinnum}"));
            dtInventaire.Columns["BSELECTED"].ReadOnly = false;
            GC_ACT_INV.DataSource = dtInventaire;
            GV_ACT_INV.ExpandAllGroups();

        }

        private void BtnSave_Click(object sender, EventArgs e)
        {
            
            //test si actions sélectionnées
            //test si rows oblgatoire sans réponse            
            DataRow DrTest;
            int bActionSelected = 0;
            for (int i = 0; i < this.GV_ACT_INV.RowCount; i++)
            {
                int currentRowHandle = GV_ACT_INV.GetRowHandle(i);
                DrTest = this.GV_ACT_INV.GetDataRow(currentRowHandle);
                if (DrTest != null && ((bool)DrTest["BSELECTED"] == true)) bActionSelected = bActionSelected + 1;
               
            }

            if(bActionSelected == 0)
            {
                MessageBox.Show("Enregistrement impossible car aucune action n'a été sélectionnée", "Erreur", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }


            if (MessageBox.Show("Voulez - vous mettre à jour les inventaires des actions sélectionnées ?", "Confirmation", MessageBoxButtons.YesNoCancel, MessageBoxIcon.Question) == DialogResult.Yes)
            {
                Cursor.Current = Cursors.WaitCursor;

                string obsadd = "";

                List<int> list_actions_to_calculTimeMontant = new List<int>();
              
                try
                {
                    for (int i = 0; i < this.GV_ACT_INV.RowCount; i++)
                    {
                        int currentRowHandle = GV_ACT_INV.GetRowHandle(i);
                        DrTest = this.GV_ACT_INV.GetDataRow(currentRowHandle);
                        if (DrTest != null && ((bool)DrTest["BSELECTED"] == true))
                        {

                            obsadd = "";

                            //on n'ajout aps l action si deja présente et on n ajoute pas l action si elle est planifié car on ne peut pas modifier le temps d'une action déjà planifiée
                            if(!list_actions_to_calculTimeMontant.Contains((int)DrTest["NACTNUM"]) & !DrTest["CETACOD"].ToString().Contains("P")) list_actions_to_calculTimeMontant.Add((int)DrTest["NACTNUM"]);

                            //on  met à jour l'équipements
                            //pour chaque action, on charge chaque type d'equipement
                            //MozartDatabase.ExecuteNonQuery($"EXEC [api_sp_Action_Inventaire_Equipement_UpdateByNACT_IV_ID] {DrTest["NACT_INV_ID"]}");
                            switch (DrTest["ETAT_EQUIPEMENT"].ToString())
                            {
                                case "UPDATE":
                                    MozartDatabase.ExecuteNonQuery($"EXEC [api_sp_Action_Inventaire_Equipement_Element_Save] {DrTest["NCLINUM"]}, {DrTest["NSITNUM"]}, {DrTest["NIDEQUIPEMENT"]}, {DrTest["NACT_INV_ID"]}, {DrTest["BSELECTED"]}");
                                    obsadd = $"{MozartParams.strUID} Le {DateTime.Now.ToShortDateString()} {DateTime.Now.ToShortTimeString()} : Mise à jour de la trame inventaire équipement {DrTest["VLIBEQUIPEMENT"]}.";
                                    break;
                                case "ADD":
                                    MozartDatabase.ExecuteNonQuery($"EXEC [api_sp_Action_Inventaire_Equipement_Element_Save] {DrTest["NCLINUM"]}, {DrTest["NSITNUM"]}, {DrTest["NIDEQUIPEMENT"]}, {DrTest["NACT_INV_ID"]}, {DrTest["BSELECTED"]}");
                                    obsadd = $"{MozartParams.strUID} Le {DateTime.Now.ToShortDateString()} {DateTime.Now.ToShortTimeString()} : Ajout de la trame inventaire équipement {DrTest["VLIBEQUIPEMENT"]}.";
                                    break;
                                //on supprime les équipements qui ne sont plus gérés sur le site ou le client
                                case "DEL":
                                    MozartDatabase.ExecuteNonQuery($"EXEC [api_sp_Action_Inventaire_Equipement_Get_Type_Equipement_To_Delete] {DrTest["NACT_INV_ID"]}, {DrTest["NIDEQUIPEMENT"]}");
                                    obsadd = $"{MozartParams.strUID} Le {DateTime.Now.ToShortDateString()} {DateTime.Now.ToShortTimeString()} : Suppression de la trame inventaire équipement {DrTest["VLIBEQUIPEMENT"]}.";
                                    break;

                            }

                            obsadd = obsadd.Replace("'", "''");

                            if(obsadd != "") MozartDatabase.ExecuteNonQuery($"EXEC [api_sp_UpdateActionObs] {DrTest["NACTNUM"]}, '{obsadd}'");

                        }                        
                    }

                    //on mets à jour le temps des actions qui ne sont pas planifiés
                    if(list_actions_to_calculTimeMontant !=null)
                    {
                        foreach(int NACTNUM in list_actions_to_calculTimeMontant)
                        {
                            MozartDatabase.ExecuteNonQuery($"EXEC [api_sp_Action_Inventaire_Equipement_UpdateDureeAndMontant] {NACTNUM}");
                        }
                    }


                    MessageBox.Show("La mise à jour des inventaires a été effectuée avec succès", "Confirmation", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
                catch (Exception ex) { Utils.ShowError(ex, $"{MethodBase.GetCurrentMethod().Name} dans {this.Name}"); }
                finally { Cursor.Current = Cursors.Default; }

            }

        }

        private void GV_ACT_INV_CustomSummaryCalculate(object sender, DevExpress.Data.CustomSummaryEventArgs e)
        {
            GridView view = sender as GridView;
            List<string> list = new List<string>() { "BSELECTED" };

            if (e.IsTotalSummary && list.Contains((e.Item as GridSummaryItem).FieldName))
            {
                GridSummaryItem item = e.Item as GridSummaryItem;

                if (item.FieldName == "BSELECTED" && (int)item.Index == 0)
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
                            e.TotalValue = $"{totnbselected} / {view.DataRowCount}";
                            break;
                    }
                }
            }
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

                return;
            }
        }

        private void GV_ACT_INV_RowCellStyle(object sender, RowCellStyleEventArgs e)
        {

            GridView view = sender as GridView;
            string _etat = (string)view.GetRowCellValue(e.RowHandle, "ETAT_EQUIPEMENT");
            if (e.Column.FieldName == "ETAT_EQUIPEMENT")
            {

                switch(_etat)
                {

                    case "DEL":
                        e.Appearance.BackColor = Color.Red;
                        break;

                    case "ADD":
                        e.Appearance.BackColor = Color.Yellow;
                        break;

                    case "":

                        e.Appearance.BackColor = Color.White;
                        break;
                }                
                
            }           

        }

        private void GV_ACT_INV_CustomDrawCell(object sender, DevExpress.XtraGrid.Views.Base.RowCellCustomDrawEventArgs e)
        {


            //GridView view = sender as GridView;
            //string _etat = (string)view.GetRowCellValue(e.RowHandle, "ETAT_EQUIPEMENT");
            //string sout = "";
            //if (e.Column.FieldName == "ETAT_EQUIPEMENT")
            //{

            //    switch (_etat)
            //    {

            //        case "DEL":
            //            sout = "A supprimer car cet équipement n'est plus géré";
            //            break;

            //        case "ADD":
            //            sout = "A ajouter";
            //            break;

            //        case "UPDATE":
            //            sout = "A mettre à jour";
            //            break;
            //    }
            //    e.DisplayText = sout;            
            //}


        }

        private void GV_ACT_INV_CustomColumnDisplayText(object sender, DevExpress.XtraGrid.Views.Base.CustomColumnDisplayTextEventArgs e)
        {
            if (e.Value == null) return;
            string sout = "";
            if (e.Column.FieldName == "ETAT_EQUIPEMENT")
            {

                switch (e.Value.ToString())
                {

                    case "DEL":
                        sout = "A supprimer car cet équipement n'est plus géré";
                        break;

                    case "ADD":
                        sout = "A ajouter";
                        break;

                    case "UPDATE":
                        sout = "A mettre à jour";
                        break;
                }
                e.DisplayText = sout;
            }
        }

        private void GV_ACT_INV_CustomDrawGroupRow(object sender, DevExpress.XtraGrid.Views.Base.RowObjectCustomDrawEventArgs e)
        {
            GridGroupRowInfo row = e.Info as GridGroupRowInfo;
            DataRow dr = GV_ACT_INV.GetDataRow(e.RowHandle);
            if (row == null) return;
            if (dr == null) return;

            row.GroupText = $"N° {row.EditValue} : {dr["VSITNOM"]} - Etat action : {dr["CETACOD"]}{(dr["DACTPLA"] == null || dr["DACTPLA"].ToString() == "" ? "" : $" - Date planification {dr["DACTPLA"]}")}";
        }

        private void GV_ACT_INV_CustomDrawFooterCell(object sender, FooterCellCustomDrawEventArgs e)
        {
            if (e.Column.FieldName == "BSELECTED")
            {
                e.Handled = true;

                if (e.Info.SummaryItem.Index == 0)
                {

                    string footerEquipSelected = $"Total sélectionné(s) / Total : {e.Info.Value.ToString()}";
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

        private void GV_ACT_INV_MouseDown(object sender, MouseEventArgs e)
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
