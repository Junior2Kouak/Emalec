using DevExpress.Data;
using DevExpress.Utils.Drawing;
using DevExpress.XtraEditors;
using DevExpress.XtraEditors.Controls;
using DevExpress.XtraEditors.Drawing;
using DevExpress.XtraEditors.Repository;
using DevExpress.XtraGrid;
using DevExpress.XtraGrid.Columns;
using DevExpress.XtraGrid.Helpers;
using DevExpress.XtraGrid.Views.Base;
using DevExpress.XtraGrid.Views.Grid;
using DevExpress.XtraGrid.Views.Grid.ViewInfo;
using DevExpress.XtraPrinting;
using MozartNet;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.OleDb;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace MozartCS
{
    public partial class frmMethodes_Prepa_Inventaire_Client : Form
    {        
        public string sNomClient;
        public Int32 iNCLINUM;

        RefreshHelper helper;
        CEQUIPEMENT_PREPA_INV_CLI oEQUIPEMENT_PREPA_INV_CLI;

        DataSet DS_Grid = new DataSet();

        int inbcontratselected;
        int inbequipementselected;

        public frmMethodes_Prepa_Inventaire_Client()
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
            this.Text = LblTitre.Text = $"Préparation inventaire client : {sNomClient}";            

            helper = new RefreshHelper(GVEquipement_Prepa_Inv_Client, "NTYPECONTRAT");

            oEQUIPEMENT_PREPA_INV_CLI = new CEQUIPEMENT_PREPA_INV_CLI(iNCLINUM);
            oEQUIPEMENT_PREPA_INV_CLI.LoadListe();
            GCEquipement_Prepa_Inv_Client.DataSource = oEQUIPEMENT_PREPA_INV_CLI._dt_Liste_Niv0;
                       
            //DataSet
            DS_Grid.Tables.Add(oEQUIPEMENT_PREPA_INV_CLI._dt_Liste_Niv0);
            DS_Grid.Tables.Add(oEQUIPEMENT_PREPA_INV_CLI._dt_Liste_Niv1);

            //LEVEL 1
            DataColumn parentColumn_Lvl_1 = DS_Grid.Tables[0].Columns["NTYPECONTRAT"];
            DataColumn childColumn_Lvl_1 = DS_Grid.Tables[1].Columns["NTYPECONTRAT"];
            DataRelation relation_Lvl_1 = new System.Data.DataRelation("NTYPECONTRAT_LVL_1", parentColumn_Lvl_1, childColumn_Lvl_1);
            DS_Grid.Relations.Add(relation_Lvl_1);

            GCEquipement_Prepa_Inv_Client.LevelTree.Nodes[0].RelationName = "NTYPECONTRAT_LVL_1";

            GVEquipement_Prepa_Inv_Client.ChildGridLevelName = "NTYPECONTRAT_LVL_1";

            GCEquipement_Prepa_Inv_Client.DataSource = DS_Grid.Tables[0];
        }
               
        private void GVAdmin_Equipement_MasterRowGetRelationDisplayCaption(object sender, MasterRowGetRelationNameEventArgs e)
        {
            if (e.RowHandle > -1)
            {
                DataRow DrReading = ((GridView)GCEquipement_Prepa_Inv_Client.FocusedView).GetDataRow(e.RowHandle);

                e.RelationName = $"CONTRAT : {DrReading.Field<string>("VTYPECONTRAT").ToString()}";

            }
        }

        private void BtnSave_Click(object sender, EventArgs e)
        {

            //controle des données
            //On ne peut pas cocher un contrat sans avoir d'equipements

            //DataRow DrContratCli;
            ////pour chaque contrat sélectionné
            //for (int i = 0; i < this.GVEquipement_Prepa_Inv_Client.RowCount; i++)
            //{
            //    int currentRowHandle = GVEquipement_Prepa_Inv_Client.GetVisibleRowHandle(i);
            //    DrContratCli = this.GVEquipement_Prepa_Inv_Client.GetDataRow(currentRowHandle);
            //    if (DrContratCli != null && DrContratCli["BCONTRAT_EXISTS"] != null &&((bool)DrContratCli["BCONTRAT_EXISTS"] == true))
            //    {
            //        //si contrat selected, on teste si des equipements ont été sélectionnés
            //        for (int i = 0; i < this.GVEquipement_Prepa_Inv_Client.RowCount; i++)
            //        {

            //            //this.Cursor = Cursors.Default;
            //            //MessageBox.Show("Enregistrement impossible car il y a des champs obligatoires sans réponse", "Erreur", MessageBoxButtons.OK, MessageBoxIcon.Error);
            //            //return;
            //        }
            //}            

            if(oEQUIPEMENT_PREPA_INV_CLI._dt_Liste_Niv0.Select("[BCONTRAT_EXISTS] = 1").Count() > 0)
            {

                foreach(DataRow DrDetails in oEQUIPEMENT_PREPA_INV_CLI._dt_Liste_Niv0.Select("[BCONTRAT_EXISTS] = 1"))
                {

                    if(oEQUIPEMENT_PREPA_INV_CLI._dt_Liste_Niv1.Select($"[BEQUIPEMENT_SELECTED] = 1 AND [NTYPECONTRAT] = {DrDetails["NTYPECONTRAT"]}").Count() == 0)
                    {
                        MessageBox.Show("Enregistrement impossible car il y a des contrats sélectionnés sans équipements sélectionnés", "Erreur", MessageBoxButtons.OK, MessageBoxIcon.Error);
                        return;
                    }

                }

            }

            //save view
            //DevExpress.XtraGrid.Helpers

            helper.SaveViewInfo();

            oEQUIPEMENT_PREPA_INV_CLI.Save();
            //oEQUIPEMENT_PREPA_INV_CLI.LoadListe();
            GCEquipement_Prepa_Inv_Client.Refresh();
            GCEquipement_Prepa_Inv_Client.RefreshDataSource();

            //restore view
            helper.LoadViewInfo();
        }

        private void RItem_BEQUIPEMENT_SELECTED_CheckStateChanged(object sender, EventArgs e)
        {
            GridView oView = (GridView)GCEquipement_Prepa_Inv_Client.FocusedView;
            if (oView.FocusedRowHandle > -1)
            {

                DataRow DrReading = ((GridView)GCEquipement_Prepa_Inv_Client.FocusedView).GetDataRow(oView.FocusedRowHandle);

                if (DrReading == null) return;

                DrReading["BEQUIPEMENT_SELECTED"] = (int)DrReading["BEQUIPEMENT_SELECTED"] == 0 ? 1 : 0;

                // Console.WriteLine(oEQUIPEMENT_PREPA_INV_CLI._dt_Liste_Niv1.GetChanges().Rows.Count);

                //oEQUIPEMENT_PREPA_INV_CLI._dt_Liste_Niv1.AcceptChanges();
                oView.UpdateCurrentRow();
                oView.UpdateTotalSummary();
                oEQUIPEMENT_PREPA_INV_CLI.Refresh();                
                GCEquipement_Prepa_Inv_Client.Refresh();
                GCEquipement_Prepa_Inv_Client.RefreshDataSource();

                return;
            }
        }

        private void RItem_BCONTRAT_EXISTS_CheckStateChanged(object sender, EventArgs e)
        {
            GridView oView = (GridView)GCEquipement_Prepa_Inv_Client.FocusedView;
            if (oView.FocusedRowHandle > -1)
            {
                DataRow DrReading = ((GridView)GCEquipement_Prepa_Inv_Client.FocusedView).GetDataRow(oView.FocusedRowHandle);

                if (DrReading == null) return;

                DrReading["BCONTRAT_EXISTS"] = (int)DrReading["BCONTRAT_EXISTS"] == 0 ? 1 : 0;


                //on décoche tous les equipements lié à ce contrat
                if (oEQUIPEMENT_PREPA_INV_CLI._dt_Liste_Niv1 != null & (int)DrReading["BCONTRAT_EXISTS"] == 0)
                {
                    foreach (DataRow Dr in oEQUIPEMENT_PREPA_INV_CLI._dt_Liste_Niv1.Select($"[NTYPECONTRAT] = {DrReading["NTYPECONTRAT"]}"))
                    {
                        Dr["BEQUIPEMENT_SELECTED"] = 0;
                    }
                }

                //oEQUIPEMENT_PREPA_INV_CLI._dt_Liste_Niv0.AcceptChanges();
                oView.UpdateCurrentRow();
                oView.UpdateTotalSummary();
                oEQUIPEMENT_PREPA_INV_CLI.Refresh();
                GCEquipement_Prepa_Inv_Client.Refresh();
                GCEquipement_Prepa_Inv_Client.RefreshDataSource();

                return;
            }
        }

        private void GVEquipement_Prepa_Inv_Client_CustomSummaryCalculate(object sender, DevExpress.Data.CustomSummaryEventArgs e)
        {

            GridView view = sender as GridView;
            if (e.IsTotalSummary && (e.Item as GridSummaryItem).FieldName == "VTYPECONTRAT")
            {
                GridSummaryItem item = e.Item as GridSummaryItem;
                if (item.FieldName == "VTYPECONTRAT")
                {
                    switch (e.SummaryProcess)
                    {
                        case CustomSummaryProcess.Start:
                            inbcontratselected = 0;
                            break;
                        case CustomSummaryProcess.Calculate:
                            if ((int)view.GetRowCellValue(e.RowHandle, "BCONTRAT_EXISTS") == 1)
                            {
                                inbcontratselected = inbcontratselected + 1;
                            }
                            break;
                        case CustomSummaryProcess.Finalize:
                            e.TotalValue = inbcontratselected;
                            break;
                    }
                }
            }
        }

        private void GVEquipement_Prepa_Inv_Client_Detail_CustomSummaryCalculate(object sender, CustomSummaryEventArgs e)
        {
            GridView view = sender as GridView;
            if (e.IsTotalSummary && (e.Item as GridSummaryItem).FieldName == "BEQUIPEMENT_SELECTED")
            {
                GridSummaryItem item = e.Item as GridSummaryItem;
                if (item.FieldName == "BEQUIPEMENT_SELECTED")
                {
                    switch (e.SummaryProcess)
                    {
                        case CustomSummaryProcess.Start:
                            inbequipementselected = 0;
                            break;
                        case CustomSummaryProcess.Calculate:
                            if ((int)view.GetRowCellValue(e.RowHandle, "BEQUIPEMENT_SELECTED") == 1)
                            {
                                inbequipementselected = inbequipementselected + 1;
                            }
                            break;
                        case CustomSummaryProcess.Finalize:
                            e.TotalValue = inbequipementselected;
                            break;
                    }
                }
            }
        }
    }
}
