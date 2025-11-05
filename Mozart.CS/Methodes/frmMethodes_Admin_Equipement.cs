using DevExpress.Data;
using DevExpress.XtraEditors;
using DevExpress.XtraEditors.Controls;
using DevExpress.XtraEditors.Repository;
using DevExpress.XtraGrid;
using DevExpress.XtraGrid.Columns;
using DevExpress.XtraGrid.Views.Grid;
using DevExpress.XtraPrinting;
using MozartNet;
using System;
using System.Data;
using System.Windows.Forms;
using static DevExpress.Utils.Svg.CommonSvgImages;

namespace MozartCS
{
  public partial class frmMethodes_Admin_Equipement : Form
    {        
        CADMIN_EQUIPEMENT oADMIN_EQUIPEMENT;

        DataSet DS_Grid = new DataSet();

        int iNbContratWithEquip;

        public frmMethodes_Admin_Equipement()
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
            
            oADMIN_EQUIPEMENT = new CADMIN_EQUIPEMENT();

            oADMIN_EQUIPEMENT.LoadListe();

            LoadCbo();

            //DataSet
            DS_Grid.Tables.Add(oADMIN_EQUIPEMENT._dt_Liste_Niv0);
            DS_Grid.Tables.Add(oADMIN_EQUIPEMENT._dt_Liste_Niv1);

            //LEVEL 1
            DataColumn parentColumn_Lvl_1 = DS_Grid.Tables[0].Columns["NTYPECONTRAT"];
            DataColumn childColumn_Lvl_1 = DS_Grid.Tables[1].Columns["NTYPECONTRAT"];
            DataRelation relation_Lvl_1 = new System.Data.DataRelation("NTYPECONTRAT_LVL_1", parentColumn_Lvl_1, childColumn_Lvl_1);
            DS_Grid.Relations.Add(relation_Lvl_1);

            GCAdmin_Equipement.LevelTree.Nodes[0].RelationName = "NTYPECONTRAT_LVL_1";

            GVAdmin_Equipement.ChildGridLevelName = "NTYPECONTRAT_LVL_1";            

            GCAdmin_Equipement.DataSource = DS_Grid.Tables[0];            

        }

        public void LoadCbo()
        {
            //liste parent
            DataTable dtCboFiches = new DataTable();
            dtCboFiches.Load(ModuleData.ExecuteReader($"EXEC [api_sp_Equipement_Admin_Fiche_Liste]"));
            RepItemGLU_NID_EQUIPEMENT_FICHE.DataSource = dtCboFiches;

        }

        private void BtnAddEquipement_Click(object sender, EventArgs e)
        {

            //test si contrat sélectionner
            DataRow row = GVAdmin_Equipement.GetFocusedDataRow();
            if (row == null)
            {
                MessageBox.Show("il faut sélectionner un contrat", "Erreur", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                return;
            }                       

            DataRow drEquipAdd = oADMIN_EQUIPEMENT._dt_Liste_Niv1.NewRow();

                drEquipAdd["NTYPECONTRAT"] = row["NTYPECONTRAT"];
                drEquipAdd["VTYPECONTRAT"] = row["VTYPECONTRAT"];
                drEquipAdd["NIDEQUIPEMENT"] = 0;
                drEquipAdd["VLIBEQUIPEMENT"] = "";
                drEquipAdd["BEQUIPEMENTACTIF"] = true;


            oADMIN_EQUIPEMENT._dt_Liste_Niv1.Rows.Add(drEquipAdd);
            oADMIN_EQUIPEMENT.Refresh();
            //GCAdmin_Equipement.Refresh();
            //GCAdmin_Equipement.RefreshDataSource();
            GVAdmin_Equipement.ExpandMasterRow(GVAdmin_Equipement.FocusedRowHandle, 0);
        }

        private void RItem_Btn_Del_Equip_ButtonClick(object sender, ButtonPressedEventArgs e)
        {
            GridView oView = (GridView)GCAdmin_Equipement.FocusedView;
            if (oView.FocusedRowHandle > -1)
            {
                DataRow DrReading = ((GridView)GCAdmin_Equipement.FocusedView).GetDataRow(oView.FocusedRowHandle);

                if (DrReading == null) return;

                if (MessageBox.Show("Voulez-vous vraiment supprimer ce type d'equipement ?", "Confirmation", MessageBoxButtons.YesNoCancel) != DialogResult.Yes) return;               

                DataRow[] result_del = oADMIN_EQUIPEMENT._dt_Liste_Niv1.Select($"[ID_UNIQUE] = {DrReading["ID_UNIQUE"]}");
                
                foreach (DataRow row in result_del)
                {
                    //if ((int)row[""])
                    row.Delete();
                }
                
                oADMIN_EQUIPEMENT.Refresh();
                GCAdmin_Equipement.Refresh();
                GCAdmin_Equipement.RefreshDataSource();

            }
        }

        private void GVAdmin_Equipement_MasterRowGetRelationDisplayCaption(object sender, MasterRowGetRelationNameEventArgs e)
        {
            if (e.RowHandle > -1)
            {
                DataRow DrReading = ((GridView)GCAdmin_Equipement.FocusedView).GetDataRow(e.RowHandle);

                e.RelationName = $"CONTRAT : {DrReading.Field<string>("VTYPECONTRAT").ToString()}";

            }
        }

        private void BtnSave_Click(object sender, EventArgs e)
        {
            oADMIN_EQUIPEMENT.Save();
            //oADMIN_EQUIPEMENT.LoadListe();
            GCAdmin_Equipement.Refresh();
            GCAdmin_Equipement.RefreshDataSource();

        }

        private void BtnExportXLSX_Click(object sender, EventArgs e)
        {

            //onc créer un gridcontrol
            GridControl grid = new GridControl();
            grid.BindingContext = new System.Windows.Forms.BindingContext();
            GridView gridview = new GridView();
            grid.MainView = gridview;
            gridview.GridControl = grid;
            grid.ViewCollection.AddRange(new DevExpress.XtraGrid.Views.Base.BaseView[] {
           gridview});

            grid.DataSource = oADMIN_EQUIPEMENT._dt_Liste_Niv1;

            grid.ForceInitialize();
            gridview.PopulateColumns();

            //on cache les columns
            foreach(GridColumn Col_Export in gridview.Columns)
            {
                if(Col_Export.FieldName == "VTYPECONTRAT" | Col_Export.FieldName == "VLIBEQUIPEMENT")
                {
                    switch(Col_Export.FieldName.ToString())
                    {
                        case "VTYPECONTRAT":
                            Col_Export.Caption = "Contrat";
                            break;
                        case "VLIBEQUIPEMENT":
                            Col_Export.Caption = "Nom Equipement";
                            break;
                    }

                    Col_Export.Visible = true;
                }
                else
                {
                    Col_Export.Visible = false;
                }

            }          

            string filename = "Export_Liste_Equipement_Contrat_" + DateTime.Now.Day.ToString() + DateTime.Now.Month.ToString() + DateTime.Now.Year.ToString();

            SFD.FileName = filename;

            if (SFD.ShowDialog() == DialogResult.OK)
            {
                if (SFD.FileName != "")
                {
                    XlsxExportOptionsEx exportOptions = new XlsxExportOptionsEx();
                    exportOptions.ExportType = DevExpress.Export.ExportType.WYSIWYG;                    
                  
                    grid.ExportToXlsx(SFD.FileName, exportOptions);
                    MessageBox.Show("Export EXCEL créé avec succès", "Information", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }                

            }

        }

        private void btnVisu_Click(object sender, EventArgs e)
        {
            ExpandAllMasterRows(GVAdmin_Equipement);
        }

        public void ExpandAllMasterRows(GridView View)
        {
            View.BeginUpdate();
            try
            {
                int dataRowCount = View.DataRowCount;
                for (int rHandle = 0; rHandle < dataRowCount; rHandle++)
                    View.SetMasterRowExpanded(rHandle, true);
            }
            finally
            {
                View.EndUpdate();
            }
        }

        private void BtnGestFiches_Click(object sender, EventArgs e)
        {
            frmMethodes_Admin_Equipement_Fiche ofrmMethodes_Admin_Equipement_Fiche = new frmMethodes_Admin_Equipement_Fiche();
            ofrmMethodes_Admin_Equipement_Fiche.ShowDialog();

            LoadCbo();

        }

        private void RepItemGLU_NID_EQUIPEMENT_FICHE_CustomDisplayText(object sender, CustomDisplayTextEventArgs e)
        {
            RepositoryItemGridLookUpEdit props = null;
            if (sender is RepositoryItemGridLookUpEdit)
            { 
                props = sender as RepositoryItemGridLookUpEdit;
            }
            if (props != null && (e.Value is int))
            {
                DataRowView row = (props.GetRowByKeyValue(e.Value)) as DataRowView;
                if (row != null)
                {
                    e.DisplayText = $"{row.Row[0].ToString()} - {row.Row[1].ToString()}" ;
                }
            }
        }

        private void GVAdmin_Equipement_CustomSummaryCalculate(object sender, DevExpress.Data.CustomSummaryEventArgs e)
        {

            GridView view = sender as GridView;
            // Get the summary ID. 
            int summaryID = Convert.ToInt32((e.Item as GridSummaryItem).Tag);

            // Initialization. 
            if (e.SummaryProcess == CustomSummaryProcess.Start)
            {
                iNbContratWithEquip = 0;
            }

            // Calculation.
            if (e.SummaryProcess == CustomSummaryProcess.Calculate)
            {
                switch (summaryID)
                {
                    case 1: // The total summary calculated against the 'UnitPrice' column. 
                        int NB_EQUIP = Convert.ToInt32(view.GetRowCellValue(e.RowHandle, "NB_EQUIP"));
                        iNbContratWithEquip = NB_EQUIP > 0 ? iNbContratWithEquip+=1 : iNbContratWithEquip;
                        break;
                }
            }

            // Finalization. 
            if (e.SummaryProcess == CustomSummaryProcess.Finalize)
            {
                switch (summaryID)
                {
                    case 1:
                        e.TotalValue = iNbContratWithEquip;
                        break;                  
                }
            }

        }

        private void BtnGestListeParent_Click(object sender, EventArgs e)
        {
            frmMethodes_Admin_Equipement_Fiche_ListParent ofrmMethodes_Admin_Equipement_Fiche_ListParent = new frmMethodes_Admin_Equipement_Fiche_ListParent();
            ofrmMethodes_Admin_Equipement_Fiche_ListParent.ShowDialog();
        }

        private void ChkOnlyContratWEquip_CheckedChanged(object sender, EventArgs e)
        {
            if (ChkOnlyContratWEquip.Checked)
            {
                GVAdmin_Equipement.ActiveFilterString = "[NB_EQUIP] > 0";
            }
            else
            {
                GVAdmin_Equipement.ActiveFilterString = "";
            }
        }
    }
}
