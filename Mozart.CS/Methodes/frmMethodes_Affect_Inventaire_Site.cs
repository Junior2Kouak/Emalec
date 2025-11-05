using DevExpress.CodeParser;
using DevExpress.Data;
using DevExpress.DataAccess.Native.EntityFramework;
using DevExpress.Utils.Drawing;
using DevExpress.XtraCharts.Native;
using DevExpress.XtraEditors;
using DevExpress.XtraEditors.Controls;
using DevExpress.XtraEditors.Drawing;
using DevExpress.XtraEditors.Repository;
using DevExpress.XtraGrid;
using DevExpress.XtraGrid.Columns;
using DevExpress.XtraGrid.Drawing;
using DevExpress.XtraGrid.Helpers;
using DevExpress.XtraGrid.Views.Base;
using DevExpress.XtraGrid.Views.Grid;
using DevExpress.XtraGrid.Views.Grid.ViewInfo;
using DevExpress.XtraPrinting;
using MozartCS.Properties;
using MozartNet;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.OleDb;
using System.Diagnostics;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Windows.Media.Media3D;

namespace MozartCS
{
    public partial class frmMethodes_Affect_Inventaire_Site : Form
    {        
        public string sNomClient;
        public Int32 iNCLINUM;
        int iNbSitesProgGestion;
        int iNbSitesAffectGestion;

        RefreshHelper SaverViewInvSite;
        RefreshHelper SaverViewInvProgSiteContrat;
        CEQUIPEMENT_PREPA_INV_SIT oEQUIPEMENT_AFFECT_INV_SIT;
        CEQUIPEMENT_PROG_CONTRAT_SIT oEQUIPEMENT_PROG_CONTRAT_SIT;

        DataSet DS_Grid = new DataSet();

        DataTable _DTGestion;

        private Rectangle footerCocheBounds;
        private SimpleButton btnFooterCocheButton;
        private Rectangle footerDeCocheBounds;
        private SimpleButton btnFooterDeCocheButton;


        private Rectangle footerHeuresBounds;
        private SimpleButton btnFooterHeuresButton;

        private Rectangle footerMontantBounds;
        private SimpleButton btnFooterMontantButton;

        private Rectangle footerAffectgestHrAndMontantCocheBounds;
        private SimpleButton btnfooterAffectgestHrAndMontantCocheButton;
        private Rectangle footerAffectgestHrAndMontantDeCocheBounds;
        private SimpleButton btnfooterAffectgestHrAndMontantDeCocheButton;

        public frmMethodes_Affect_Inventaire_Site()
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
            //LoadCboGestion();
            LblTitre.Text = $"Affectation des inventaires / site pour le client : {sNomClient}";

            SaverViewInvSite = new RefreshHelper(GVEquipement_Affect_Inv_Site, "NTYPECONTRAT");
            SaverViewInvProgSiteContrat = new RefreshHelper(GVEquip_Site_Contrat_Prog, "NID_EQUIPEMENT_SIT_CONTRAT");

            oEQUIPEMENT_AFFECT_INV_SIT = new CEQUIPEMENT_PREPA_INV_SIT(iNCLINUM);
            oEQUIPEMENT_AFFECT_INV_SIT.LoadListe();
            GCEquipement_Affect_Inv_Site.DataSource = oEQUIPEMENT_AFFECT_INV_SIT._dt_Liste_Niv0;

            oEQUIPEMENT_PROG_CONTRAT_SIT = new CEQUIPEMENT_PROG_CONTRAT_SIT(iNCLINUM);
            oEQUIPEMENT_PROG_CONTRAT_SIT.LoadListe();


            //DataSet
            DS_Grid.Tables.Add(oEQUIPEMENT_AFFECT_INV_SIT._dt_Liste_Niv0);
            DS_Grid.Tables.Add(oEQUIPEMENT_AFFECT_INV_SIT._dt_Liste_Niv1);

            //LEVEL 1
            DataColumn parentColumn_Lvl_1 = DS_Grid.Tables[0].Columns["NTYPECONTRAT"];
            DataColumn childColumn_Lvl_1 = DS_Grid.Tables[1].Columns["NTYPECONTRAT"];
            DataRelation relation_Lvl_1 = new System.Data.DataRelation("NTYPECONTRAT_LVL_1", parentColumn_Lvl_1, childColumn_Lvl_1);
            DS_Grid.Relations.Add(relation_Lvl_1);

            GCEquipement_Affect_Inv_Site.LevelTree.Nodes[0].RelationName = "NTYPECONTRAT_LVL_1";

            GVEquipement_Affect_Inv_Site.ChildGridLevelName = "NTYPECONTRAT_LVL_1";

            GCEquipement_Affect_Inv_Site.DataSource = DS_Grid.Tables[0];

            GCEquipement_Affect_Inv_Site.Refresh();

            //prog            
            GCEquip_Site_Contrat_Prog.DataSource = oEQUIPEMENT_PROG_CONTRAT_SIT._dt_Liste_Niv0;

            GCEquip_Site_Contrat_Prog.Refresh();

            // Create a button Coche
            btnFooterCocheButton = new SimpleButton();
            btnFooterCocheButton.Text = "Cocher tous";
            btnFooterCocheButton.Size = new System.Drawing.Size(140, 25);

            // Create a button Decoche
            btnFooterDeCocheButton = new SimpleButton();
            btnFooterDeCocheButton.Text = "Décocher tous";
            btnFooterDeCocheButton.Size = new System.Drawing.Size(140, 25);

            // Create a button Decoche
            btnFooterHeuresButton = new SimpleButton();
            btnFooterHeuresButton.Text = "Appliquer des heures à la sélection";
            btnFooterHeuresButton.Size = new System.Drawing.Size(140, 25);

            // Create a button Decoche
            btnFooterMontantButton = new SimpleButton();
            btnFooterMontantButton.Text = "Appliquer un montant à la sélection";
            btnFooterMontantButton.Size = new System.Drawing.Size(140, 25);

            // Create a button Coche pour affect site
            btnfooterAffectgestHrAndMontantCocheButton = new SimpleButton();
            btnfooterAffectgestHrAndMontantCocheButton.Text = "Cocher tous";
            btnfooterAffectgestHrAndMontantCocheButton.Size = new System.Drawing.Size(140, 25);

            // Create a button DeCoche pour affect site
            btnfooterAffectgestHrAndMontantDeCocheButton = new SimpleButton();
            btnfooterAffectgestHrAndMontantDeCocheButton.Text = "Décocher tous";
            btnfooterAffectgestHrAndMontantDeCocheButton.Size = new System.Drawing.Size(140, 25);

        }

        //private void LoadCboGestion()
        //{
        //    //RepItemCboEquipSiteGestion.Items.AddRange(new string[] { "", "NON", "OUI" });

        //    _DTGestion = new DataTable();
        //    _DTGestion.Columns.Add("VGESTIONVALUE", typeof(String));
        //    _DTGestion.Columns.Add("NGESTIONVALUE", typeof(Int32));

        //    DataRow drGestionAdd = _DTGestion.NewRow();
        //    drGestionAdd["VGESTIONVALUE"] = "";
        //    drGestionAdd["NGESTIONVALUE"] = DBNull.Value;
        //    _DTGestion.Rows.Add(drGestionAdd);
        //    drGestionAdd = _DTGestion.NewRow();
        //    drGestionAdd["VGESTIONVALUE"] = "OUI";
        //    drGestionAdd["NGESTIONVALUE"] = 1;
        //    _DTGestion.Rows.Add(drGestionAdd);
        //    drGestionAdd = _DTGestion.NewRow();
        //    drGestionAdd["VGESTIONVALUE"] = "NON";
        //    drGestionAdd["NGESTIONVALUE"] = 2;
        //    _DTGestion.Rows.Add(drGestionAdd);

        //    RepItemgestion.DataSource = _DTGestion;


        //}


        private void GVAdmin_Equipement_MasterRowGetRelationDisplayCaption(object sender, MasterRowGetRelationNameEventArgs e)
        {
            if (e.RowHandle > -1)
            {
                DataRow DrReading = ((GridView)GCEquipement_Affect_Inv_Site.FocusedView).GetDataRow(e.RowHandle);

                e.RelationName = $"CONTRAT : {DrReading.Field<string>("VTYPECONTRAT").ToString()}";

            }
        }

        private void BtnSave_Click(object sender, EventArgs e)
        {

            this.Cursor = Cursors.WaitCursor;

            //save view    
            SaverViewInvSite.SaveViewInfo();
            SaverViewInvProgSiteContrat.SaveViewInfo();

            oEQUIPEMENT_AFFECT_INV_SIT.Save();
            //oEQUIPEMENT_AFFECT_INV_SIT.CleanContratHeuresMontantBySite();
            //oEQUIPEMENT_PREPA_INV_CLI.LoadListe();
            GCEquipement_Affect_Inv_Site.Refresh();
            GCEquipement_Affect_Inv_Site.RefreshDataSource();


            //test si site coché en gestion, il faut avoir saisie des heures et un montant
            //vérification si champ avec type liste où le list parent n'est pas défini
            for (int i = 0; i < GVEquip_Site_Contrat_Prog.DataRowCount; i++)
            {

                if (GVEquip_Site_Contrat_Prog.GetRowCellValue(i, "BEQUIPEMENT_SIT_CONTRAT_GESTION") != null
                        && (bool)GVEquip_Site_Contrat_Prog.GetRowCellValue(i, "BEQUIPEMENT_SIT_CONTRAT_GESTION") == true )
                                   
                {
                    //heures
                    if(GVEquip_Site_Contrat_Prog.GetRowCellValue(i, "NEQUIPEMENT_SIT_CONTRAT_DUREE") == null | GVEquip_Site_Contrat_Prog.GetRowCellValue(i, "NEQUIPEMENT_SIT_CONTRAT_DUREE").ToString() == "")
                    {
                        MessageBox.Show("Il y a un ou des contrat(s) de site(s) coché(s) en gestion sans nombre d'heures", "Erreur", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                        this.Cursor = Cursors.Default;
                        return;

                    }
                    //montant
                    if (GVEquip_Site_Contrat_Prog.GetRowCellValue(i, "NEQUIPEMENT_SIT_CONTRAT_MONTANT") == null | GVEquip_Site_Contrat_Prog.GetRowCellValue(i, "NEQUIPEMENT_SIT_CONTRAT_MONTANT").ToString() == "")
                    {                        
                        MessageBox.Show("Il y a un ou des contrat(s) de site(s) coché(s) en gestion sans montant", "Erreur", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                        this.Cursor = Cursors.Default;
                        return;
                    }
                    
                }
            }

            oEQUIPEMENT_PROG_CONTRAT_SIT.Save();
            GCEquip_Site_Contrat_Prog.Refresh();
            GCEquip_Site_Contrat_Prog.RefreshDataSource();

            //restore view
            SaverViewInvSite.LoadViewInfo();
            SaverViewInvProgSiteContrat.LoadViewInfo();

            //on reload
            DS_Grid = new DataSet();
            oEQUIPEMENT_PROG_CONTRAT_SIT.LoadListe();          

            GCEquip_Site_Contrat_Prog.DataSource = oEQUIPEMENT_PROG_CONTRAT_SIT._dt_Liste_Niv0;

            this.Cursor = Cursors.Default;
            MessageBox.Show("Enregistrement terminée avec succès", "Confirmation", MessageBoxButtons.OK, MessageBoxIcon.Information);


        }

        //private void RItem_BEQUIPEMENT_SELECTED_CheckStateChanged(object sender, EventArgs e)
        //{
        //    GridView oView = (GridView)GCEquipement_Affect_Inv_Site.FocusedView;
        //    if (oView.FocusedRowHandle > -1)
        //    {

        //        DataRow DrReading = ((GridView)GCEquipement_Affect_Inv_Site.FocusedView).GetDataRow(oView.FocusedRowHandle);

        //        if (DrReading == null) return;

        //        DrReading["BEQUIPEMENT_SELECTED"] = (int)DrReading["BEQUIPEMENT_SELECTED"] == 0 ? 1 : 0;

        //        // Console.WriteLine(oEQUIPEMENT_PREPA_INV_CLI._dt_Liste_Niv1.GetChanges().Rows.Count);

        //        //oEQUIPEMENT_PREPA_INV_CLI._dt_Liste_Niv1.AcceptChanges();

        //        oEQUIPEMENT_AFFECT_INV_SIT.Refresh();                
        //        GCEquipement_Affect_Inv_Site.Refresh();
        //        GCEquipement_Affect_Inv_Site.RefreshDataSource();

        //        return;
        //    }
        //}

        //private void RItem_BCONTRAT_EXISTS_CheckStateChanged(object sender, EventArgs e)
        //{
        //    GridView oView = (GridView)GCEquipement_Affect_Inv_Site.FocusedView;
        //    if (oView.FocusedRowHandle > -1)
        //    {
        //        DataRow DrReading = ((GridView)GCEquipement_Affect_Inv_Site.FocusedView).GetDataRow(oView.FocusedRowHandle);

        //        if (DrReading == null) return;

        //        DrReading["BCONTRAT_EXISTS"] = (int)DrReading["BCONTRAT_EXISTS"] == 0 ? 1 : 0;


        //        //on décoche tous les equipements lié à ce contrat
        //        if (oEQUIPEMENT_AFFECT_INV_SIT._dt_Liste_Niv1 != null & (int)DrReading["BCONTRAT_EXISTS"] == 0)
        //        {
        //            foreach (DataRow Dr in oEQUIPEMENT_AFFECT_INV_SIT._dt_Liste_Niv1.Select($"[NTYPECONTRAT] = {DrReading["NTYPECONTRAT"]}"))
        //            {
        //                Dr["BEQUIPEMENT_SELECTED"] = 0;
        //            }
        //        }

        //        //oEQUIPEMENT_PREPA_INV_CLI._dt_Liste_Niv0.AcceptChanges();

        //        oEQUIPEMENT_AFFECT_INV_SIT.Refresh();
        //        GCEquipement_Affect_Inv_Site.Refresh();
        //        GCEquipement_Affect_Inv_Site.RefreshDataSource();

        //        return;
        //    }
        //}

        private void GVEquipement_Affect_Inv_Site_CustomUnboundColumnData(object sender, CustomColumnDataEventArgs e)
        {
            GridView view = sender as GridView;
            if (e.Column.FieldName == "NEQUIP_AFFECT" && e.IsGetData) e.Value = GetValue(view, e.ListSourceRowIndex);
        }

        // Return the total amount for a specific row.
        string GetValue(GridView view, int listSourceRowIndex)
        {
            if ((int)view.GetListSourceRowCellValue(listSourceRowIndex, "NB_EQUIP_CLI") > 0)
            {
                return "OUI";
            }
            else
            {
                return "NON";
            }            
        }

        private void GVEquip_Site_Contrat_Prog_CustomSummaryCalculate(object sender, DevExpress.Data.CustomSummaryEventArgs e)
        {
            GridView view = sender as GridView;
            if (e.IsTotalSummary && (e.Item as GridSummaryItem).FieldName == "VSITNOM")
            {
                GridSummaryItem item = e.Item as GridSummaryItem;
                if (item.FieldName == "VSITNOM")
                {
                    switch (e.SummaryProcess)
                    {
                        case CustomSummaryProcess.Start:
                            iNbSitesProgGestion = 0;
                            break;
                        case CustomSummaryProcess.Calculate:
                            if (view.GetRowCellValue(e.RowHandle, "BEQUIPEMENT_SIT_CONTRAT_GESTION") != DBNull.Value &&  (bool)view.GetRowCellValue(e.RowHandle, "BEQUIPEMENT_SIT_CONTRAT_GESTION") == true)
                            {
                                iNbSitesProgGestion = iNbSitesProgGestion + 1;
                            }
                            break;
                        case CustomSummaryProcess.Finalize:
                            e.TotalValue = $"{iNbSitesProgGestion} / {view.RowCount}";
                            break;
                    }
                }
            }
        }

        private void GVEquipement_Prepa_Inv_Site_Detail_CustomSummaryCalculate(object sender, CustomSummaryEventArgs e)
        {
            GridView view = sender as GridView;
            if (e.IsTotalSummary && (e.Item as GridSummaryItem).FieldName == "VSITNOM")
            {
                GridSummaryItem item = e.Item as GridSummaryItem;
                if (item.FieldName == "VSITNOM")
                {
                    switch (e.SummaryProcess)
                    {
                        case CustomSummaryProcess.Start:
                            iNbSitesAffectGestion = 0;
                            break;
                        case CustomSummaryProcess.Calculate:
                            if (view.GetRowCellValue(e.RowHandle, "BEQUIPEMENT_SIT_GESTION") != DBNull.Value && (int)view.GetRowCellValue(e.RowHandle, "BEQUIPEMENT_SIT_GESTION") == 1)
                            {
                                iNbSitesAffectGestion = iNbSitesAffectGestion + 1;
                            }
                            break;
                        case CustomSummaryProcess.Finalize:
                            e.TotalValue = $"{iNbSitesAffectGestion} / {view.RowCount}";
                            break;
                    }
                }
            }
        }        

        private void GVEquipement_Prepa_Inv_Site_Detail_CustomDrawFooter(object sender, RowObjectCustomDrawEventArgs e)
        {
            e.Handled = true;

            //Bouton Coche
            // Calculate button dimensions and position
            footerCocheBounds = new Rectangle(e.Bounds.Width - btnFooterCocheButton.Width - 10 - btnFooterCocheButton.Width - 10,
                                        e.Bounds.Y + ((e.Bounds.Height - btnFooterCocheButton.Height) / 2),
                                        btnFooterCocheButton.Width,
                                        btnFooterCocheButton.Height);

            // Draw the button using Graphics.DrawRectangle 
            e.Graphics.DrawRectangle(Pens.Black, footerCocheBounds);
            e.Graphics.FillRectangle(Brushes.LightGray, footerCocheBounds.X + 1, footerCocheBounds.Y + 1,
                                    footerCocheBounds.Width - 2, footerCocheBounds.Height - 2);                      

            Size textSizeBtnFooterCoche = TextRenderer.MeasureText(btnFooterCocheButton.Text, e.Appearance.Font);

            e.Graphics.DrawString(btnFooterCocheButton.Text, e.Appearance.Font, Brushes.Black,
                                    footerCocheBounds.X + ((footerCocheBounds.Width - textSizeBtnFooterCoche.Width) / 2), footerCocheBounds.Y + ((footerCocheBounds.Height - textSizeBtnFooterCoche.Height) / 2));


            //Bouton DeCoche
            // Calculate button dimensions and position
            footerDeCocheBounds = new Rectangle(e.Bounds.Width - btnFooterDeCocheButton.Width - 10,
                                        e.Bounds.Y + ((e.Bounds.Height - btnFooterDeCocheButton.Height) / 2),
                                        btnFooterDeCocheButton.Width,
                                        btnFooterDeCocheButton.Height);

            // Draw the button using Graphics.DrawRectangle 
            e.Graphics.DrawRectangle(Pens.Black, footerDeCocheBounds);
            e.Graphics.FillRectangle(Brushes.LightGray, footerDeCocheBounds.X + 1, footerDeCocheBounds.Y + 1,
                                    footerDeCocheBounds.Width - 2, footerDeCocheBounds.Height - 2);

            Size textSizeBtnFooterDeCoche = TextRenderer.MeasureText(btnFooterDeCocheButton.Text, e.Appearance.Font);

            e.Graphics.DrawString(btnFooterDeCocheButton.Text, e.Appearance.Font, Brushes.Black,
                                    footerDeCocheBounds.X + ((footerDeCocheBounds.Width - textSizeBtnFooterDeCoche.Width) / 2), footerDeCocheBounds.Y + ((footerDeCocheBounds.Height - textSizeBtnFooterDeCoche.Height) / 2));

        }              

        private void GVEquipement_Prepa_Inv_Site_Detail_MouseDown(object sender, MouseEventArgs e)
        {
            GridView view = (GridView)sender;

            GridHitInfo hitInfo = view.CalcHitInfo(e.Location);
            if (hitInfo.HitTest != GridHitTest.Footer) return;

            if (e.Location.X > footerCocheBounds.X & e.Location.X < footerCocheBounds.X + footerCocheBounds.Width & e.Location.Y > footerCocheBounds.Y & e.Location.Y < footerCocheBounds.Y + footerCocheBounds.Height)
            {
                if (e.Button == MouseButtons.Left)
                {
                    if (view.ActiveFilter != null) { }

                    //if(MessageBox.Show($"Voulez-vous cocher toutes les lignes {(view.ActiveFilter != null ? "filtrées": "")} ?", "Confirmation", MessageBoxButtons.YesNoCancel, MessageBoxIcon.Question) == DialogResult.Yes)
                    //{

                    this.BeginInvoke(new MethodInvoker(() => 
                                        {
                                            if (MessageBox.Show($"Voulez-vous cocher toutes les lignes {(view.ActiveFilter != null ? "filtrées" : "")} ?", "Confirmation", MessageBoxButtons.YesNoCancel, MessageBoxIcon.Question) == DialogResult.Yes)
                                            {
                                                for (int i = 0; i < view.DataRowCount; i++)
                                                {
                                                    //Console.WriteLine(view.GetDataRow(i)["VLIBEQUIPEMENT"].ToString());

                                                    view.SetRowCellValue(i, G_L1_Col_BEQUIPEMENT_SIT_GESTION, true);
                                                    view.PostEditor();
                                                    view.UpdateCurrentRow();
                                                }

                                            }
                                        }));
                    
                }               
                return;
            }
            if (e.Location.X > footerDeCocheBounds.X & e.Location.X < footerDeCocheBounds.X + footerDeCocheBounds.Width & e.Location.Y > footerDeCocheBounds.Y & e.Location.Y < footerDeCocheBounds.Y + footerDeCocheBounds.Height)
            {
                if (e.Button == MouseButtons.Left)
                {
                    if (view.ActiveFilter != null) { }

                    this.BeginInvoke(new MethodInvoker(() =>
                                    {
                                        if (MessageBox.Show($"Voulez-vous décocher toutes les lignes {(view.ActiveFilter != null ? "filtrées" : "")} ?", "Confirmation", MessageBoxButtons.YesNoCancel, MessageBoxIcon.Question) == DialogResult.Yes)
                                        {

                                            for (int i = 0; i < view.DataRowCount; i++)
                                            {
                                                //Console.WriteLine(view.GetDataRow(i)["VLIBEQUIPEMENT"].ToString());

                                                view.SetRowCellValue(i, G_L1_Col_BEQUIPEMENT_SIT_GESTION, 0);
                                                view.PostEditor();
                                                view.UpdateCurrentRow();
                                            }

                                        }
                                    }));
                }                
                return;
            }
        }

        private void GVEquip_Site_Contrat_Prog_CustomDrawFooterCell(object sender, FooterCellCustomDrawEventArgs e)
        {
            if (e.Column.FieldName == "NEQUIPEMENT_SIT_CONTRAT_DUREE" && e.Info.SummaryItem.Index == 1)
            {
                e.Handled = true;

                //Bouton Coche
                // Calculate button dimensions and position
                footerHeuresBounds = new Rectangle(e.Bounds.X,
                                            e.Bounds.Y,
                                            e.Bounds.Width,
                                            e.Bounds.Height);

                e.Graphics.DrawRectangle(Pens.Black, footerHeuresBounds);
                e.Graphics.FillRectangle(Brushes.LightGray, footerHeuresBounds.X + 1, footerHeuresBounds.Y + 1,
                                        footerHeuresBounds.Width - 2, footerHeuresBounds.Height - 2);

                Size textSizeBtnFooterHeures = TextRenderer.MeasureText(btnFooterHeuresButton.Text, e.Appearance.Font);

                e.Graphics.DrawString(btnFooterHeuresButton.Text, e.Appearance.Font, Brushes.Black,
                                        footerHeuresBounds.X + ((footerHeuresBounds.Width - textSizeBtnFooterHeures.Width) / 2), footerHeuresBounds.Y + ((footerHeuresBounds.Height - textSizeBtnFooterHeures.Height) / 2));
                
                return;
            }
            if (e.Column.FieldName == "NEQUIPEMENT_SIT_CONTRAT_MONTANT" && e.Info.SummaryItem.Index == 1)
            {
                e.Handled = true;

                //Bouton Coche
                // Calculate button dimensions and position
                footerMontantBounds = new Rectangle(e.Bounds.X,
                                            e.Bounds.Y,
                                            e.Bounds.Width,
                                            e.Bounds.Height);

                e.Graphics.DrawRectangle(Pens.Black, footerMontantBounds);
                e.Graphics.FillRectangle(Brushes.LightGray, footerMontantBounds.X + 1, footerMontantBounds.Y + 1,
                                        footerMontantBounds.Width - 2, footerMontantBounds.Height - 2);

                Size textSizeBtnFooterMontant = TextRenderer.MeasureText(btnFooterMontantButton.Text, e.Appearance.Font);

                e.Graphics.DrawString(btnFooterMontantButton.Text, e.Appearance.Font, Brushes.Black,
                                        footerMontantBounds.X + ((footerMontantBounds.Width - textSizeBtnFooterMontant.Width) / 2), footerMontantBounds.Y + ((footerMontantBounds.Height - textSizeBtnFooterMontant.Height) / 2));
                return;
            }

            if (e.Column.FieldName == "BEQUIPEMENT_SIT_CONTRAT_GESTION")
            {
                e.Handled = true;

                switch(e.Info.SummaryItem.Index)
                {
                    case 0:
                        //Bouton Coche
                        // Calculate button dimensions and position
                        footerAffectgestHrAndMontantCocheBounds = new Rectangle(e.Bounds.X,
                                            e.Bounds.Y,
                                            e.Bounds.Width,
                                            e.Bounds.Height);

                        // Draw the button using Graphics.DrawRectangle 
                        e.Graphics.DrawRectangle(Pens.Black, footerAffectgestHrAndMontantCocheBounds);
                        e.Graphics.FillRectangle(Brushes.LightGray, footerAffectgestHrAndMontantCocheBounds.X + 1, footerAffectgestHrAndMontantCocheBounds.Y + 1,
                                                footerAffectgestHrAndMontantCocheBounds.Width - 2, footerAffectgestHrAndMontantCocheBounds.Height - 2);

                        Size textSizeBtnFooterCoche = TextRenderer.MeasureText(btnfooterAffectgestHrAndMontantCocheButton.Text, e.Appearance.Font);

                        e.Graphics.DrawString(btnfooterAffectgestHrAndMontantCocheButton.Text, e.Appearance.Font, Brushes.Black,
                                                footerAffectgestHrAndMontantCocheBounds.X + ((footerAffectgestHrAndMontantCocheBounds.Width - textSizeBtnFooterCoche.Width) / 2), footerAffectgestHrAndMontantCocheBounds.Y + ((footerAffectgestHrAndMontantCocheBounds.Height - textSizeBtnFooterCoche.Height) / 2));

                        break;


                    case 1:
                        //Bouton DeCoche
                        // Calculate button dimensions and position
                        footerAffectgestHrAndMontantDeCocheBounds = new Rectangle(e.Bounds.X,
                                            e.Bounds.Y,
                                            e.Bounds.Width,
                                            e.Bounds.Height);

                        // Draw the button using Graphics.DrawRectangle 
                        e.Graphics.DrawRectangle(Pens.Black, footerAffectgestHrAndMontantDeCocheBounds);
                        e.Graphics.FillRectangle(Brushes.LightGray, footerAffectgestHrAndMontantDeCocheBounds.X + 1, footerAffectgestHrAndMontantDeCocheBounds.Y + 1,
                                                footerAffectgestHrAndMontantDeCocheBounds.Width - 2, footerAffectgestHrAndMontantDeCocheBounds.Height - 2);

                        Size textSizeBtnFooterDeCoche = TextRenderer.MeasureText(btnfooterAffectgestHrAndMontantDeCocheButton.Text, e.Appearance.Font);

                        e.Graphics.DrawString(btnfooterAffectgestHrAndMontantDeCocheButton.Text, e.Appearance.Font, Brushes.Black,
                                                footerAffectgestHrAndMontantDeCocheBounds.X + ((footerAffectgestHrAndMontantDeCocheBounds.Width - textSizeBtnFooterDeCoche.Width) / 2), footerAffectgestHrAndMontantDeCocheBounds.Y + ((footerAffectgestHrAndMontantDeCocheBounds.Height - textSizeBtnFooterDeCoche.Height) / 2));

                        break;

                }

               

                
                return;
            }


        }

        private void GVEquip_Site_Contrat_Prog_MouseDown(object sender, MouseEventArgs e)
        {
            GridView view = (GridView)sender;

            GridHitInfo hitInfo = view.CalcHitInfo(e.Location);
            if (hitInfo.HitTest != GridHitTest.Footer) return;

            if (e.Location.X > footerHeuresBounds.X & e.Location.X < footerHeuresBounds.X + footerHeuresBounds.Width & e.Location.Y > footerHeuresBounds.Y & e.Location.Y < footerHeuresBounds.Y + footerHeuresBounds.Height)
            {
                if (e.Button == MouseButtons.Left)
                {
                    if (view.ActiveFilter != null) { }

                    this.BeginInvoke(new MethodInvoker(() =>
                    {

                        if (MessageBox.Show($"Voulez-vous appliquer des heures à toutes les lignes {(view.ActiveFilter != null ? "filtrées" : "")} ?", "Confirmation", MessageBoxButtons.YesNoCancel, MessageBoxIcon.Question) == DialogResult.Yes)
                        {

                            string sHeures = Microsoft.VisualBasic.Interaction.InputBox("Saisir les heures :", "Duplication heures");
                            if (sHeures == null || sHeures.ToString() == "") { }
                            decimal iNbHeures = 0;
                            bool isNumber = decimal.TryParse(sHeures, out iNbHeures);
                            if (!isNumber)
                            {
                                MessageBox.Show($"Il faut saisir un nombre d'heures", "Erreur", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                                return;
                            }

                            for (int i = 0; i < view.DataRowCount; i++)
                            {
                                //Console.WriteLine(view.GetDataRow(i)["VLIBEQUIPEMENT"].ToString());

                                view.SetRowCellValue(i, G_Prog_Col_NEQUIPEMENT_SIT_CONTRAT_DUREE, iNbHeures);
                                view.PostEditor();
                                view.UpdateCurrentRow();
                            }
                        }
                    }));
                }
                
                return;
            }
            if (e.Location.X > footerMontantBounds.X & e.Location.X < footerMontantBounds.X + footerMontantBounds.Width & e.Location.Y > footerMontantBounds.Y & e.Location.Y < footerMontantBounds.Y + footerMontantBounds.Height)
            {
                if (e.Button == MouseButtons.Left)
                {
                    if (view.ActiveFilter != null) { }

                    this.BeginInvoke(new MethodInvoker(() =>
                    {

                        if (MessageBox.Show($"Voulez-vous appliquer un montant à toutes les lignes {(view.ActiveFilter != null ? "filtrées" : "")} ?", "Confirmation", MessageBoxButtons.YesNoCancel, MessageBoxIcon.Question) == DialogResult.Yes)
                        {

                            string sMontant = Microsoft.VisualBasic.Interaction.InputBox("Saisir un montant :", "Duplication montant");
                            if (sMontant == null || sMontant.ToString() == "") { }
                            decimal iMontant = 0;
                            bool isNumber = decimal.TryParse(sMontant, out iMontant);
                            if (!isNumber)
                            {
                                MessageBox.Show($"Il faut saisir un montant", "Erreur", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                                return;
                            }

                            for (int i = 0; i < view.DataRowCount; i++)
                            {
                                //Console.WriteLine(view.GetDataRow(i)["VLIBEQUIPEMENT"].ToString());

                                view.SetRowCellValue(i, G_Prog_Col_NEQUIPEMENT_SIT_CONTRAT_MONTANT, iMontant);
                                view.PostEditor();
                                view.UpdateCurrentRow();
                            }

                        }
                    }));
                }                
               
                return;
            }
            //bouton cocher tous
            if (e.Location.X > footerAffectgestHrAndMontantCocheBounds.X & e.Location.X < footerAffectgestHrAndMontantCocheBounds.X + footerAffectgestHrAndMontantCocheBounds.Width & e.Location.Y > footerAffectgestHrAndMontantCocheBounds.Y & e.Location.Y < footerAffectgestHrAndMontantCocheBounds.Y + footerAffectgestHrAndMontantCocheBounds.Height)
            {
                if (e.Button == MouseButtons.Left)
                {
                    if (view.ActiveFilter != null) { }

                    this.BeginInvoke(new MethodInvoker(() =>
                    {

                        if (MessageBox.Show($"Voulez-vous cocher toutes les lignes {(view.ActiveFilter != null ? "filtrées" : "")} ?", "Confirmation", MessageBoxButtons.YesNoCancel, MessageBoxIcon.Question) == DialogResult.Yes)
                        {
                            for (int i = 0; i < view.DataRowCount; i++)
                            {
                                //Console.WriteLine(view.GetDataRow(i)["VLIBEQUIPEMENT"].ToString());

                                view.SetRowCellValue(i, G_Prog_Col_BEQUIPEMENT_SIT_CONTRAT_GESTION, true);
                                view.PostEditor();
                                view.UpdateCurrentRow();
                            }
                        }
                    }));
                    return;
                }
            }

            //bouton Decocher tous
            if (e.Location.X > footerAffectgestHrAndMontantDeCocheBounds.X & e.Location.X < footerAffectgestHrAndMontantDeCocheBounds.X + footerAffectgestHrAndMontantDeCocheBounds.Width & e.Location.Y > footerAffectgestHrAndMontantDeCocheBounds.Y & e.Location.Y < footerAffectgestHrAndMontantDeCocheBounds.Y + footerAffectgestHrAndMontantDeCocheBounds.Height)
            {
                if (e.Button == MouseButtons.Left)
                {
                    if (view.ActiveFilter != null) { }

                    this.BeginInvoke(new MethodInvoker(() =>
                    {

                        if (MessageBox.Show($"Voulez-vous décocher toutes les lignes {(view.ActiveFilter != null ? "filtrées" : "")} ?", "Confirmation", MessageBoxButtons.YesNoCancel, MessageBoxIcon.Question) == DialogResult.Yes)
                        {
                            for (int i = 0; i < view.DataRowCount; i++)
                            {
                                //Console.WriteLine(view.GetDataRow(i)["VLIBEQUIPEMENT"].ToString());

                                view.SetRowCellValue(i, G_Prog_Col_BEQUIPEMENT_SIT_CONTRAT_GESTION, false);
                                view.PostEditor();
                                view.UpdateCurrentRow();
                            }
                        }
                    }));
                    return;
                }
            }
        }

        private void GVEquipement_Prepa_Inv_Site_Detail_RowCellStyle(object sender, RowCellStyleEventArgs e)
        {
            if (e.RowHandle == GridControl.AutoFilterRowHandle)
                e.Appearance.BackColor = Color.Yellow;
        }

        private void GVEquip_Site_Contrat_Prog_RowCellStyle(object sender, RowCellStyleEventArgs e)
        {
            GridView currentView = sender as GridView;
            if (e.Column.FieldName == "NEQUIPEMENT_SIT_CONTRAT_DUREE")
            {
                bool value = Convert.ToBoolean(currentView.GetRowCellValue(e.RowHandle, "BEQUIPEMENT_SIT_CONTRAT_GESTION"));
                if (value && (e.CellValue.ToString() == ""))
                    e.Appearance.BackColor = Color.Yellow;
                return;
            }
            if (e.Column.FieldName == "NEQUIPEMENT_SIT_CONTRAT_MONTANT")
            {
                bool value = Convert.ToBoolean(currentView.GetRowCellValue(e.RowHandle, "BEQUIPEMENT_SIT_CONTRAT_GESTION"));
                if (value && (e.CellValue.ToString() == ""))
                    e.Appearance.BackColor = Color.Yellow;
                return;
            }
        }
    } 

}   

