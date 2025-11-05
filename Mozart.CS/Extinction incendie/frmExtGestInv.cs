using MozartLib;
using MozartNet;
using MozartUC;
using System;
using System.Data;
using System.Linq;
using System.Reflection;
using System.Windows.Forms;
using MZUtils = MozartControls.Utils;
using MZCtrlResources = MozartControls.Properties.Resources;
using DevExpress.XtraScheduler;
using MozartCS.Properties;

namespace MozartCS
{
  public partial class frmExtGestInv : Form
  {
    private int iNEXTINVID;
    private int iNCliNum;

    private DataTable oDtInvSit;

    public frmExtGestInv(int p_iNEXTINVID, string p_VCLINOM, string p_VSITNOM)
    {
      InitializeComponent();

      iNEXTINVID = p_iNEXTINVID;
      iNCliNum = 0;

      Text = String.Format(Text, p_VCLINOM, p_VSITNOM);
    }

    public frmExtGestInv(int pNCliNum, string p_VCLINOM)
    {
      InitializeComponent();

      iNCliNum = pNCliNum;
      Text = String.Format(Text, p_VCLINOM, "");
    }

    private void frmExtGestInv_Load(object sender, EventArgs e)
    {
      try
      {
        Cursor.Current = Cursors.WaitCursor;
        ModuleMain.Initboutons(this);

        initApiTGridRes();
        initApiTGridCumul();

        LoadListInventaire();
      }
      catch (Exception ex)
      {
        MZUtils.displayError(MethodBase.GetCurrentMethod().Name, ex);
      }
      finally
      {
        Cursor.Current = Cursors.Default;
      }
    }

    private void initApiTGridCumul()
    {
      apiTGridCumul.AddColumn(MZCtrlResources.Fourniture, "VFOUMAT", 1550);
      apiTGridCumul.AddColumn("Somme", "Count", 100, "", MozartUCConstants.GRID_COL_ALIGN_RIGHT);

      apiTGridCumul.InitColumnList();
    }

    private void initApiTGridRes()
    {
      apiTGridRes.AddColumn(MZCtrlResources.col_Site, "VSITNOM", 1000);
      apiTGridRes.AddColumn(MZCtrlResources.Fourniture, "VFOUMAT", 2000);
      apiTGridRes.AddColumn(MZCtrlResources.Emplacement, "VEXTINVEMPL", 800);
      apiTGridRes.AddColumn(MZCtrlResources.Numero, "VEXTINVLNUMERO", 500, "", MozartUCConstants.GRID_COL_ALIGN_RIGHT);
      apiTGridRes.AddColumn(MZCtrlResources.Annee, "NEXTINVLANNEE", 500, "", MozartUCConstants.GRID_COL_ALIGN_RIGHT);
      apiTGridRes.AddColumn(Resources.col_Observation, "VEXTINVOBS", 900, "", MozartUCConstants.GRID_COL_ALIGN_RIGHT);

      apiTGridRes.InitColumnList();
    }

    private void LoadListInventaire()
    {
      if (iNCliNum != 0)
      {
        oDtInvSit = MozartDatabase.GetDataTable($"exec api_sp_ExtListeInvFouByCli {iNCliNum}");
      }
      else
      {
        oDtInvSit = MozartDatabase.GetDataTable($"exec api_sp_ExtListeInvFouBySit {iNEXTINVID}");
      }
      apiTGridRes.GridControl.DataSource = oDtInvSit;

      apiTGridRes_ColumnFilterChanged(null, null);
    }

    private void apiTGridRes_ColumnFilterChanged(object sender, EventArgs e)
    {
      try
      {
        var visibleRows = Enumerable.Range(0, apiTGridRes.dgv.RowCount)
              .Select(i => apiTGridRes.dgv.GetVisibleRowHandle(i))
              .Where(rowHandle => !apiTGridRes.dgv.IsGroupRow(rowHandle))
              .Select(rowHandle => apiTGridRes.dgv.GetRow(rowHandle) as DataRowView)
              .Where(drv => drv != null)
              .GroupBy(drv => drv["VFOUMAT"].ToString())
              .Select(g => new
              {
                VFOUMAT = g.Key,
                Count = g.Count()
              })
              .ToList();

        apiTGridCumul.GridControl.DataSource = visibleRows;
      }
      catch (Exception)
      {
      } 
    }
  }
}
