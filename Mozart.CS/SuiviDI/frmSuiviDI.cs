using MZCtrlResources = MozartControls.Properties.Resources;
using MozartCS.Properties;
using MozartLib;
using MozartNet;
using System;
using System.Data;
using System.Reflection;
using System.Windows.Forms;
using MZUtils = MozartControls.Utils;


namespace MozartCS
{
  public partial class frmSuiviDI : Form
  {
    public frmSuiviDI() { InitializeComponent(); }
    DataTable dt = new DataTable();
    DataTable dt1 = new DataTable();

    private void frmSuiviDI_Load(object sender, System.EventArgs e)
    {
      try
      {
        Cursor.Current = Cursors.WaitCursor;
        ModuleMain.Initboutons(this);

        // ouverture du recordset
        ApiGrid.LoadData(dt, MozartDatabase.cnxMozart, "exec api_sp_SuiviDInonPlanif");
        ApiGrid.GridControl.DataSource = dt;
        InitApigrid();

        ApiGrid1.LoadData(dt1, MozartDatabase.cnxMozart, "exec api_sp_SuiviDInonExec");
        ApiGrid1.GridControl.DataSource = dt1;
        InitApigrid1();
      }
      catch (Exception ex)
      {
        MZUtils.displayError(MethodBase.GetCurrentMethod().Name, ex);
      }
      finally { Cursor.Current = Cursors.Default; }
    }

    private void InitApigrid()
    {
      try
      {
        ApiGrid.AddColumn(Resources.col_DI, "NDINNUM", 600);
        ApiGrid.AddColumn(MZCtrlResources.col_Client, "VCLINOM", 1200);
        ApiGrid.AddColumn(Resources.col_Site, "VSITNOM", 1700);
        ApiGrid.AddColumn(Resources.col_Num, "NSITNUE", 600);
        ApiGrid.AddColumn(Resources.col_Date, "DACTDAT", 900, "dd/MM/yy");
        ApiGrid.AddColumn(Resources.col_Tech, "CPERINI", 550);
        ApiGrid.AddColumn(Resources.col_ST, "VSTFNOM", 900);
        ApiGrid.AddColumn(Resources.col_Ville, "VSITVIL", 1150);
        ApiGrid.AddColumn(Resources.col_Action, "VACTDES", 6400);
        ApiGrid.AddColumn(Resources.col_NumAction, "nActnum", 0);
        ApiGrid.InitColumnList();
      }
      catch (Exception ex)
      {
        MZUtils.displayError(MethodBase.GetCurrentMethod().Name, ex);
      }
    }

    private void ApiGrid_DoubleClickE(object sender, EventArgs e)
    {
      ApiGrid.Enabled = false;
      ouvreDetailNonPlanif();
      ApiGrid.Enabled = true;
    }

    private void cmdDetailNonPlanif_Click(object sender, EventArgs e)
    {
      ApiGrid.Enabled = false;
      ouvreDetailNonPlanif();
      ApiGrid.Enabled = true;
    }

    private void ouvreDetailNonPlanif()
    {
      DataRow currRow = ApiGrid.GetFocusedDataRow();
      if (currRow == null) return;
      Cursor.Current = Cursors.WaitCursor;
      // écran de modification de la demande
      frmAddAction f = new frmAddAction()
      {
        mstrStatutDI = "M",
      };
      MozartParams.NumDi = Convert.ToInt32(currRow["NDINNUM"]);
      MozartParams.NumAction = (int)Utils.ZeroIfNull(currRow["NACTNUM"]);
      f.ShowDialog();
      Cursor.Current = Cursors.WaitCursor;
      // on revient donc on réinitialise les variables globales
      MozartParams.NumDi = 0;
      MozartParams.NumAction = 0;

      // rafraichissement du recordset
      ApiGrid.Requery(dt, MozartDatabase.cnxMozart);
      Cursor.Current = Cursors.Default;
    }

    private void ApiGrid1_DoubleClickE(object sender, EventArgs e)
    {
      ApiGrid1.Enabled = false;
      ouvreDetailNonExec();
      ApiGrid1.Enabled = true;
    }

    private void cmdDetailsNonExec_Click(object sender, EventArgs e)
    {
      ApiGrid1.Enabled = false;
      ouvreDetailNonExec();
      ApiGrid1.Enabled = true;
    }

    private void ouvreDetailNonExec()
    {
      DataRow currRow = ApiGrid1.GetFocusedDataRow();
      if (currRow == null) return;
      Cursor.Current = Cursors.WaitCursor;
      // écran de modification de la demande
      frmAddAction f = new frmAddAction()
      {
        mstrStatutDI = "M",
      };
      MozartParams.NumDi = Convert.ToInt32(currRow["NDINNUM"]);
      MozartParams.NumAction = (int)Utils.ZeroIfNull(currRow["NACTNUM"]);
      f.ShowDialog();
      Cursor.Current = Cursors.WaitCursor;
      // on revient donc on réinitialise les variables globales
      MozartParams.NumDi = 0;
      MozartParams.NumAction = 0;

      // rafraichissement du recordset
      ApiGrid1.Requery(dt1, MozartDatabase.cnxMozart);
      Cursor.Current = Cursors.Default;
    }

    private void InitApigrid1()
    {
      try
      {
        ApiGrid1.AddColumn(Resources.col_DI, "NDINNUM", 600);
        ApiGrid1.AddColumn(MZCtrlResources.col_Client, "VCLINOM", 1200);
        ApiGrid1.AddColumn(Resources.col_Site, "VSITNOM", 1700);
        ApiGrid1.AddColumn(Resources.col_Num, "NSITNUE", 600);
        ApiGrid1.AddColumn(Resources.col_Date, "DACTPLA", 900, "dd/MM/yy");
        ApiGrid1.AddColumn(Resources.col_Tech, "CPERINI", 550);
        ApiGrid1.AddColumn(Resources.col_ST, "VSTFNOM", 900);
        ApiGrid1.AddColumn(Resources.col_Ville, "VSITVIL", 1150);
        ApiGrid1.AddColumn(Resources.col_Action, "VACTDES", 6400);
        ApiGrid1.AddColumn(Resources.col_NumAction, "nActnum", 0);
        ApiGrid1.InitColumnList();
      }
      catch (Exception ex)
      {
        MZUtils.displayError(MethodBase.GetCurrentMethod().Name, ex);
      }
    }

    private void cmdQuitter_Click(object sender, System.EventArgs e)
    {
      //fermeture de la fenêtre
      Dispose();
    }


  }
}

