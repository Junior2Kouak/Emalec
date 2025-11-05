using DevExpress.XtraGrid.Views.Grid;
using MozartCS.Properties;
using MozartLib;
using MozartNet;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Reflection;
using System.Windows.Forms;
using MZUtils = MozartControls.Utils;

namespace MozartCS.MenuGestionMPT
{
  public partial class frmStatDepDelaiResolution : Form
  {

    DataTable dt = new DataTable();

    public frmStatDepDelaiResolution()
    {
      InitializeComponent();
    }

    private void frmStatDepDelaiResolution_Load(object sender, EventArgs e)
    {
      Cursor = Cursors.WaitCursor;

      try
      {
        ModuleMain.Initboutons(this);

        string sSQL = $"SELECT  tcli.nclinum, vclinom FROM dbo.TCLI WHERE VSOCIETE = App_Name() AND CCLIACTIF = 'O' " +
                      $"UNION SELECT 0 AS NCLINUM,'  ' AS VCLINOM  ORDER BY VCLINOM";

        cboCli.Init(MozartDatabase.cnxMozart, sSQL, "nclinum", "vclinom", new List<string>() { Resources.col_Num, Resources.col_Nom }, 150, 550, true);

        //INIT
        DateEdit_Fin.EditValue = DateTime.Now;
        DateEdit_Debut.EditValue = DateTime.Now.AddMonths(-12);

        LblLegende.Text = "Les délais calculés s’expriment en jours ouvrés\rLes actions prises en compte dans le tableau sont uniquement celles en statut dépannage et cloturées";


        Cursor = Cursors.Default;
      }
      catch (Exception ex)
      {
        Cursor = Cursors.Default;
        MZUtils.displayError(MethodBase.GetCurrentMethod().Name, ex);
      }
    }

    private void InitFeuille()
    {
      try
      {
        Cursor = Cursors.WaitCursor;

        string sSQL = $"[api_sp_Reporting_Depannage_DelaiResolution] {cboCli.GetItemData()},'{DateEdit_Debut.Text}','{DateEdit_Fin.Text}'";

        //création d'une commande 
        ModuleData.LoadData(dt, sSQL);

        gridControl1.DataSource = dt;

        List<ChartDataSrc> LstdtChart = new List<ChartDataSrc>();

        LstdtChart.Add(new ChartDataSrc("TDELAI_DEP_1", "NDELAIDEP", dt));
        LstdtChart.Add(new ChartDataSrc("TDELAI_DEP_2", "NDELAIDEVISCREE", dt));
        LstdtChart.Add(new ChartDataSrc("TDELAI_DEP_3", "NDELAIVALIDCLI", dt));
        LstdtChart.Add(new ChartDataSrc("TDELAI_DEP_4", "NDELAIEXETRAVAUX", dt));
        LstdtChart.Add(new ChartDataSrc("TDELAI_DEP_5", "NDELAITOTAL", dt));

        chartControl1.DataSource = LstdtChart[0].DtOut;
        chartControl2.DataSource = LstdtChart[1].DtOut;
        chartControl3.DataSource = LstdtChart[2].DtOut;
        chartControl4.DataSource = LstdtChart[3].DtOut;
        chartControl5.DataSource = LstdtChart[4].DtOut;

        Cursor = Cursors.Default;
      }
      catch (Exception ex)
      {
        Cursor = Cursors.Default;
        MZUtils.displayError(MethodBase.GetCurrentMethod().Name, ex);
      }
    }

    private void cmdValider_Click(object sender, EventArgs e)
    {

      //test
      if (cboCli.GetText() == "")
      {
        MessageBox.Show("Il faut sélectionner un client", Resources.Global_Erreur, MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
        return;
      }

      InitFeuille();
    }

    private void BtnExportXLS_Click(object sender, EventArgs e)
    {
      string filename = "Export_Stat_Delai_Dep_" + DateTime.Now.Day.ToString() + DateTime.Now.Month.ToString() + DateTime.Now.Year.ToString();

      sFD.FileName = filename;

      if (sFD.ShowDialog() == DialogResult.OK)
      {
        if (sFD.FileName != "")
        {
          gridControl1.ExportToXlsx(sFD.FileName);
        }
      }

    }

    private void repositoryItemHyperLinkEdit1_OpenLink(object sender, DevExpress.XtraEditors.Controls.OpenLinkEventArgs e)
    {

      GridView oView = (GridView)gridControl1.FocusedView;
      if (oView.FocusedRowHandle > -1)
      {
        DataRow DrReading = ((GridView)gridControl1.FocusedView).GetDataRow(oView.FocusedRowHandle);

        string[] tabDI = DrReading["VDINNUM"].ToString().Split('/');
        Int32 NACTNUM_SELECTED = (int)ModuleData.ExecuteScalarInt($"SELECT NACTNUM FROM TACT WITH (NOLOCK) WHERE NDINNUM = {tabDI[0]} AND NACTID = {tabDI[1]}");

        //  écran de modification de la demande
        frmAddAction f = new frmAddAction()
        {
          mstrStatutDI = "M"
        };

        MozartParams.NumDi = Convert.ToInt32(tabDI[0]);
        MozartParams.NumAction = NACTNUM_SELECTED;

        f.ShowDialog();

        //  on revient donc on réinitialise les variables globales
        MozartParams.NumDi = 0;
        MozartParams.NumAction = 0;


      }

    }
  }
}

public class ChartDataSrc
{
  public DataTable DtOut { get; set; }
  public ChartDataSrc(string Nomtable, string sNomColonneDelai, DataTable dt_src)
  {

    DtOut = new DataTable(Nomtable);
    DtOut.Columns.Add("PERIODE", typeof(String));
    DtOut.Columns.Add("NB", typeof(int));

    int NBDELAI_0_1 = 0;
    int NBDELAI_1_5 = 0;
    int NBDELAI_5 = 0;

    var result = from num in dt_src.AsEnumerable()
                 where num.Field<dynamic>(sNomColonneDelai) != null
                 group num by num.Field<dynamic>(sNomColonneDelai) into g
                 // orderby g.Key
                 select new
                 {
                   NDELAIDEP = g.Key,
                   NB_ACT = g.Count()
                 };

    foreach (var o in result)
    {

      switch (Convert.ToInt32(o.NDELAIDEP))
      {
        //0 à 1
        case int n when (n >= 0 && n <= 1):

          NBDELAI_0_1 = NBDELAI_0_1 + o.NB_ACT;

          break;

        case int n when (n > 1 && n <= 5):

          NBDELAI_1_5 = NBDELAI_1_5 + o.NB_ACT;

          break;

        case int n when (n > 5):

          NBDELAI_5 = NBDELAI_5 + o.NB_ACT;

          break;

        default:
          break;


      }
    }
    DataRow oDrNew = DtOut.NewRow();
    oDrNew["PERIODE"] = "Moins d'1 jour";
    oDrNew["NB"] = NBDELAI_0_1;
    DtOut.Rows.Add(oDrNew);

    oDrNew = DtOut.NewRow();
    oDrNew["PERIODE"] = "Entre 1 et 5 jours";
    oDrNew["NB"] = NBDELAI_1_5;
    DtOut.Rows.Add(oDrNew);

    oDrNew = DtOut.NewRow();
    oDrNew["PERIODE"] = "Plus de 5 jours";
    oDrNew["NB"] = NBDELAI_5;
    DtOut.Rows.Add(oDrNew);

  }
}
