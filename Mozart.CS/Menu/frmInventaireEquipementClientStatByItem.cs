using DevExpress.CodeParser;
using DevExpress.XtraPrinting;
using DevExpress.XtraPrintingLinks;
using DevExpress.XtraRichEdit.Import.Html;
using MozartCS.Properties;
using MozartLib;
using MozartNet;
using MozartUC;
using ReportEmalec.Net;
using System;
using System.Data;
using System.Reflection;
using System.Windows.Forms;
using MZUtils = MozartControls.Utils;
using DevExpress.XtraPrinting;
using DevExpress.XtraPrintingLinks;

namespace MozartCS
{
  public partial class frmInventaireEquipementClientStatByItem : Form
  {
    public int miNumClient;
    public string msNomClient;

    DataTable dt = new DataTable();
    DataTable dt_Tab = new DataTable();


        public frmInventaireEquipementClientStatByItem() { InitializeComponent(); }


    private void frmInventaireEquipementClientStatByItem_Load(object sender, System.EventArgs e)
    {
      try
      {
        Cursor.Current = Cursors.WaitCursor;
        ModuleMain.Initboutons(this);

        LblTitre.Text += " " + msNomClient;

                apiTGrid1.LoadData(dt, MozartDatabase.cnxMozart, $"exec [api_sp_InventaireEquipement_Client_Select_StatByValue] {miNumClient}");

                InitApigrid();
      }
      catch (Exception ex)
      {
        MZUtils.displayError(MethodBase.GetCurrentMethod().Name, ex);
      }
      finally { Cursor.Current = Cursors.Default; }
    }

    private void cmdFermer_Click(object sender, System.EventArgs e)
    {
      Dispose();
    }


    private void InitApigrid()
    {      
      apiTGrid1.AddColumn("N° Fiche", "NID_EQUIPEMENT_FICHE", 1000);
            apiTGrid1.AddColumn("Fiche", "VEQUIPEMENT_FICHE_LIB", 3500);
            apiTGrid1.AddColumn("Type equipement", "VLIBEQUIPEMENT", 3500);
      apiTGrid1.AddColumn("Champ", "VEQUIPEMENT_FICHE_ITEM_LIB", 3500);
      apiTGrid1.AddColumn("NID_EQUIPEMENT_FICHE_ITEM", "NID_EQUIPEMENT_FICHE_ITEM", 0);

      apiTGrid1.InitColumnList();
      apiTGrid1.GridControl.DataSource = dt;

            apiTGrid2.AddColumn("Valeur", "OVALUE", 1500);
            apiTGrid2.AddColumn("Nombre", "NB", 1000);

            apiTGrid2.InitColumnList();
            
        }

        private void apiTGrid1_SelectionChanged(object sender, DevExpress.Data.SelectionChangedEventArgs e)
        {
            DataRow row = apiTGrid1.GetFocusedDataRow();
            if (row == null || row["NID_EQUIPEMENT_FICHE_ITEM"] == null) return;

            dt_Tab =  new DataTable();

            apiTGrid2.LoadData(dt_Tab, MozartDatabase.cnxMozart, $"exec [api_sp_InventaireEquipement_Client_Select_StatByValue_Tab] {miNumClient}, {row["NID_EQUIPEMENT_FICHE_ITEM"]}");

            apiTGrid2.GridControl.DataSource = dt_Tab;

            chartControl1.DataSource = dt_Tab;
            chartControl1.Titles[0].Text = $"{row["VEQUIPEMENT_FICHE_ITEM_LIB"]}";

        }

        private void BtnExportXls_Click(object sender, EventArgs e)
        {
            SFD.Filter = "Fichiers XLSX |*.XLSX";
            SFD.ShowDialog();

            if(SFD.FileName != "") 
            {
                // Create objects and define event handlers.
                CompositeLink composLink = new CompositeLink(new PrintingSystem());

                PrintableComponentLink pcLink1 = new PrintableComponentLink();
                PrintableComponentLink pcLink2 = new PrintableComponentLink();
                Link linkMainReport = new Link();

                Link linkGrid1Report = new Link();

                Link linkGrid2Report = new Link();


                // Assign the controls to the printing links.
                pcLink1.Component = this.apiTGrid2.GridControl;
                pcLink2.Component = this.chartControl1;

                // Populate the collection of links in the composite link.
                // The order of operations corresponds to the document structure.
                composLink.Links.Add(linkGrid1Report);
                composLink.Links.Add(pcLink1);
                composLink.Links.Add(linkMainReport);
                composLink.Links.Add(linkGrid2Report);
                composLink.Links.Add(pcLink2);

                // Create the report and show the preview window.
                //composLink.ShowPreviewDialog();

                composLink.ExportToXlsx(SFD.FileName, new XlsxExportOptions() { ExportMode = XlsxExportMode.SingleFile });

                MessageBox.Show("Exportation terminée avec succès !", "Information", MessageBoxButtons.OK, MessageBoxIcon.Information);

            }
        }
    }
}

