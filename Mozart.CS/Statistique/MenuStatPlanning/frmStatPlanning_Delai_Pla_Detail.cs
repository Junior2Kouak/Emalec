using DevExpress.XtraGrid;
using DevExpress.XtraPrinting;
using MozartLib;
using MozartNet;
using System;
using System.Data;
using System.Windows.Forms;

namespace MozartCS
{
  public partial class frmStatPlanning_Delai_Pla_Detail : Form
  {
    private DataTable dtDetail;
    private int iTypeDetail;

    public frmStatPlanning_Delai_Pla_Detail(DataTable c_dtDetail, int c_iTypeDetail, string c_Titre)
    {
      InitializeComponent();

      dtDetail = c_dtDetail;
      iTypeDetail = c_iTypeDetail;
      Text = c_Titre;
      lblTitre.Text = c_Titre;
    }

    private void frmStatPlanning_Delai_Pla_Detail_Load(object sender, EventArgs e)
    {
      //Cursor.Current = Cursors.WaitCursor;
      ModuleMain.Initboutons(this);

      switch (iTypeDetail)
      {
        case 1:   // Délai de traitement(D) (en heure)
          GColdmise_en_planif.Visible = true;
          GColdmise_en_planif.Caption = "Date mise en planification";
          GColdmise_en_planif.FieldName = "dmise_en_planif";
          GCol_date_planif.Visible = true;
          GCol_date_planif.Caption = "Date de planification";
          GCol_date_planif.FieldName = "date_planif";
          GCol_DELAI_D.Visible = true;
          GCol_DELAI_D.Caption = "Délai de traitement (D) (en heure)";
          GCol_DELAI_D.FieldName = "DELAI_D";

          GCol_DELAI_D.Summary.Add(new GridColumnSummaryItem(DevExpress.Data.SummaryItemType.Average, "DELAI_D", "MOY={0:n2}"));
          break;

        case 2: // Délai de traitement (Hors D)
          GColdmise_en_planif.Visible = true;
          GColdmise_en_planif.Caption = "Date mise en planification";
          GColdmise_en_planif.FieldName = "dmise_en_planif";
          GCol_date_planif.Visible = true;
          GCol_date_planif.Caption = "Date de planification";
          GCol_date_planif.FieldName = "date_planif";
          GCol_DELAI_D.Visible = true;
          GCol_DELAI_D.Caption = "Délai de traitement (Hors D) (en heure)";
          GCol_DELAI_D.FieldName = "DELAI_HORS_D";
          GCol_DELAI_D.Summary.Add(new GridColumnSummaryItem(DevExpress.Data.SummaryItemType.Average, "DELAI_HORS_D", "MOY={0:n2}"));
          break;

        case 3: // Délai de planification 
          GColdmise_en_planif.Visible = true;
          GColdmise_en_planif.Caption = "Date mise en planification";
          GColdmise_en_planif.FieldName = "dmise_en_planif";
          GCol_date_planif.Visible = true;
          GCol_date_planif.Caption = "Date planifiée (le jour de l’intervention)";
          GCol_date_planif.FieldName = "dactpla";
          GCol_DELAI_D.Visible = true;
          GCol_DELAI_D.Caption = "Délai de planification (en jour)";
          GCol_DELAI_D.FieldName = "DELAI_PLANIF";
          GCol_DELAI_D.Summary.Add(new GridColumnSummaryItem(DevExpress.Data.SummaryItemType.Average, "DELAI_PLANIF", "MOY={0:n2}"));
          break;

        case 4: // Nombre de NOK Planning
          GColdmise_en_planif.Visible = false;
          GCol_date_planif.Visible = false;
          GCol_DELAI_D.Visible = true;
          GCol_DELAI_D.Caption = "Nombre de NOK Planning";
          GCol_DELAI_D.FieldName = "NB_NOK";
          GCol_DELAI_D.Summary.Add(new GridColumnSummaryItem(DevExpress.Data.SummaryItemType.Sum, "NB_NOK", "TOTAL={0:n2}"));
          break;

        case 5: // Nombre d'actions avec plus d'un nok Planning
          GColdmise_en_planif.Visible = false;
          GCol_date_planif.Visible = false;
          GCol_DELAI_D.Visible = true;
          GCol_DELAI_D.Caption = "Nombre de NOK Planning";
          GCol_DELAI_D.FieldName = "NB_NOK_SUP_1";
          GCol_DELAI_D.Summary.Add(new GridColumnSummaryItem(DevExpress.Data.SummaryItemType.Sum, "NB_NOK_SUP_1", "TOTAL={0:n2}"));
          break;

        case 6: // délai prévention
          GColdmise_en_planif.Visible = true;
          GColdmise_en_planif.Caption = "Date de planification";
          GColdmise_en_planif.FieldName = "dmise_en_planif";
          GColdmise_en_planif.DisplayFormat.FormatType = DevExpress.Utils.FormatType.DateTime;
          GColdmise_en_planif.DisplayFormat.FormatString = @"dd\/MM\/yyyy";
          GCol_date_planif.Visible = true;
          GCol_date_planif.Caption = "Date et heure de la prévention site";
          GCol_date_planif.FieldName = "dactpla";
          GCol_DELAI_D.Visible = true;
          GCol_DELAI_D.Caption = "Délai de prévention (en heure) entre la date de prévention du site et la date de planification (8H)";
          GCol_DELAI_D.FieldName = "DELAI_PREVENTION";
          GCol_DELAI_D.Summary.Add(new GridColumnSummaryItem(DevExpress.Data.SummaryItemType.Average, "DELAI_PREVENTION", "MOY={0:n2}"));
          break;
      }

      GCDetail.DataSource = dtDetail;
    }

    private void Repo_Item_DI_OpenLink(object sender, DevExpress.XtraEditors.Controls.OpenLinkEventArgs e)
    {
      DataRow drSelected = GVDetail.GetDataRow(GVDetail.FocusedRowHandle);
      if (drSelected == null) return;

      MozartParams.NumDi = (int)Utils.ZeroIfNull(drSelected["NDINNUM"]);
      new frmAddAction()
      {
        mstrStatutDI = "M"
      }.ShowDialog();

      MozartParams.NumDi = 0;
      MozartParams.NumAction = 0;
    }

    private void cmdExcel_Click(object sender, EventArgs e)
    {
      string filename = "Export_Stat_Delai_Pla_Delai" + DateTime.Now.ToString("ddMMyyyy");

      sFD.FileName = filename;

      if (sFD.ShowDialog() != DialogResult.OK) return;
      if (sFD.FileName == "") return;

      XlsxExportOptionsEx opt = new XlsxExportOptionsEx();
      opt.ExportMode = XlsxExportMode.SingleFile;
      opt.ExportType = DevExpress.Export.ExportType.WYSIWYG;

      GCDetail.ExportToXlsx(sFD.FileName, opt);
    }
  }
}
