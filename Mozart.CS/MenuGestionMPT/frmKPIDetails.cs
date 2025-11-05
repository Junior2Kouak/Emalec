using DevExpress.Data;
using DevExpress.XtraGrid.Views.Grid;
using MozartCS.Properties;
using MozartLib;
using MozartNet;
using System;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Reflection;
using System.Windows.Forms;
using MZCtrlResources = MozartControls.Properties.Resources;
using MZUtils = MozartControls.Utils;

namespace MozartCS
{
  public partial class frmKPIDetails : Form
  {
    private const string COL_RESPMAINT = "NRESPPLANMAINT";
    private const string COL_ENQQUAL = "NENQQUAL";

    private DataTable dt = new DataTable();

    private string mTitle;

    private int mNCliNum;
    private int mNCpteAna;
    private string mFilterField;

    private string mUnite;
    private int mCoefDiviseur;

    public frmKPIDetails(string pTitle, int pCliNum, int pCpteAna, DataTable pDataTable, string pFilterField, string pUnite)
    {
      InitializeComponent();

      mTitle = pTitle;
      mNCliNum = pCliNum;
      mNCpteAna = pCpteAna;
      mFilterField = pFilterField;
      mUnite = pUnite;

      switch (mUnite)
      {
        case "H":
          // Pour passer les minutes en heures
          mCoefDiviseur = 60;
          break;

        case "J":
          // Pour passer les minutes en jours
          mCoefDiviseur = 24 * 60;
          break;

        case "%":
          // Pas de division
          mCoefDiviseur = 1;
          break;
      }

      dt = pDataTable.AsEnumerable()
              .Where(r => (r.Field<int>("NCLINUM") == mNCliNum) && (r.Field<int>("NCPTE_ANA") == mNCpteAna) && (r.Field<int>(mFilterField) != -1))
              .CopyToDataTable();
    }

    private void initGrid()
    {
      apiTGrid1.AddColumn(MZCtrlResources.col_DI, "NDINNUM", 1200, "");
      apiTGrid1.AddColumn(Resources.col_dateEx, "DACTDEX", 1200, "");
      apiTGrid1.AddColumn(MZCtrlResources.col_Site, "VSITNOM", 2500, "");
      apiTGrid1.AddColumn(MZCtrlResources.col_Action, "VACTDES", 7000, "");

      switch (mFilterField)
      {
        case COL_RESPMAINT:
          // Préventif
          apiTGrid1.AddColumn($"Délai respecté", mFilterField, 1200, "");
          break;

        case COL_ENQQUAL:
          // Enquêtes qualité
          apiTGrid1.AddColumn($"Satisfaction", mFilterField, 1200, "");
          break;

        default:
          // Dépannages, devis, travaux, résolution
          apiTGrid1.AddCalculatedColumn($"Délai ({mUnite})", $"{mFilterField}_CALC", $"ToDecimal([{mFilterField}]) / ToDecimal({mCoefDiviseur})",
                              UnboundColumnType.Decimal, 1200, "N2");
          apiTGrid1.AddColumn($"Objectif ({mUnite})", $"{mFilterField}_OBJ", 1200, "");
          break;
      }

      apiTGrid1.InitColumnList();
      apiTGrid1.dgv.OptionsView.ColumnAutoWidth = false;

      apiTGrid1.GridControl.DataSource = dt;
    }

    private void frmKPIDetails_Load(object sender, EventArgs e)
    {
      ModuleMain.Initboutons(this);

      lblTitre.Text = Text = mTitle;

      initGrid();
    }

    private void apiTGrid1_RowCellStyle(object sender, RowCellStyleEventArgs e)
    {
      if (e.RowHandle < 0) return;

      switch (e.Column.Name)
      {
        case COL_RESPMAINT:
          int valRespMaint = Convert.ToInt32((sender as GridView).GetRowCellValue(e.RowHandle, mFilterField));
          if (valRespMaint == 1)
          {
            e.Appearance.ForeColor = Color.Green;
            e.Appearance.BackColor = Color.Green;
          }
          else
          {
            e.Appearance.ForeColor = Color.OrangeRed;
            e.Appearance.BackColor = Color.OrangeRed;
          }
          break;

        case COL_ENQQUAL:
          int valEnqQual = Convert.ToInt32((sender as GridView).GetRowCellValue(e.RowHandle, mFilterField));
          if (valEnqQual > 2)
          {
            e.Appearance.ForeColor = Color.Green;
            e.Appearance.BackColor = Color.Green;
          }
          else
          {
            e.Appearance.ForeColor = Color.OrangeRed;
            e.Appearance.BackColor = Color.OrangeRed;
          }
          break;

        default:  // (e.Column.Name == $"{mFilterField}_CALC")
          double val = Convert.ToDouble((sender as GridView).GetRowCellValue(e.RowHandle, $"{mFilterField}_CALC"));
          double valObj = Convert.ToDouble((sender as GridView).GetRowCellValue(e.RowHandle, $"{mFilterField}_OBJ"));

          if (val > valObj)
          {
            e.Appearance.BackColor = Color.OrangeRed;
          }
          break;
      }
    }

    private void cmdDI_Click(object sender, EventArgs e)
    {
      try
      {
        DataRow row = apiTGrid1.GetFocusedDataRow();
        if (row == null) return;

        MozartParams.NumDi = Convert.ToInt32(row["NDINNUM"]);
        MozartParams.NumAction = Convert.ToInt32(row["NACTNUM"]);

        new frmAddAction
        {
          mstrStatutDI = "M"
        }.ShowDialog();

        MozartParams.NumDi = 0;
        MozartParams.NumAction = 0;
      }
      catch (Exception ex)
      {
        MZUtils.displayError(MethodBase.GetCurrentMethod().Name, ex);
      }
    }
  }
}
