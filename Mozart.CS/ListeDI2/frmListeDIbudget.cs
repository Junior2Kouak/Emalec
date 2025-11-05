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
  public partial class frmListeDIbudget : Form
  {
    DataTable dt = new DataTable();

    public frmListeDIbudget() { InitializeComponent(); }
    /*--------------------------------------------------------------*/
    private void frmListeDIbudget_Load(object sender, System.EventArgs e)
    {
      try
      {
        Cursor.Current = Cursors.WaitCursor;
        ModuleMain.Initboutons(this);

        apigrid.LoadData(dt, MozartDatabase.cnxMozart, "exec api_sp_listedi_Budget");
        apigrid.GridControl.DataSource = dt;

        InitApigrid();
      }
      catch (Exception ex)
      {
        MZUtils.displayError(MethodBase.GetCurrentMethod().Name, ex);
      }
      finally { Cursor.Current = Cursors.Default; }
    }

    /* --------------------------------------------------------------------------------------- */
    private void InitApigrid()
    {
      apigrid.AddColumn(Resources.col_DI, "NDINNUM", 600);
      apigrid.AddColumn(Resources.col_date_c, "DDINDATHEUR", 780, "dd/MM/yy");
      apigrid.AddColumn(MZCtrlResources.col_Client, "VCLINOM", 970);
      apigrid.AddColumn(Resources.col_Site, "VSITNOM", 1350);
      apigrid.AddColumn("N°", "NSITNUE", 600);
      apigrid.AddColumn(Resources.col_Action, "VACTDES", 4500);
      apigrid.AddColumn(Resources.col_Date, "DACTDATE", 770, "dd/MM/yy");
      apigrid.AddColumn(Resources.col_Technicien, "VACTINT", 400);
      apigrid.AddColumn(Resources.col_Urgence, "CURGCOD", 250);
      apigrid.AddColumn(Resources.col_Technique, "CTECCOD", 250);
      apigrid.AddColumn(Resources.col_Prestation, "CPRECOD", 250);
      apigrid.AddColumn(Resources.col_etat, "CETACOD", 250);
      apigrid.AddColumn(Resources.col_Administration, "CACTSTA", 250);
      apigrid.AddColumn(Resources.col_Observation, "VACTOBS", 1400);
      apigrid.AddColumn(Resources.col_NumAction, "NACTNUM", 0);
      apigrid.AddColumn(Resources.col_type_intervenant, "CACTTYT", 0);

      apigrid.InitColumnList();
    }

    /* --------------------------------------------------------------------------------------- */
    private void cmdNouvelle_Click(object sender, EventArgs e)
    {
      //écran de création de la demande
      MozartParams.NumDi = 0;
      MozartParams.NumAction = 0;

      Cursor.Current = Cursors.WaitCursor;
      new frmAddAction
      {
        mstrStatutDI = "C",
      }.ShowDialog();

      MozartParams.NumDi = 0;
      MozartParams.NumAction = 0;

      //rafraichissement du recordset
      Cursor.Current = Cursors.WaitCursor;
      apigrid.Requery(dt, MozartDatabase.cnxMozart);
      Cursor.Current = Cursors.Default;
    }

    /* --------------------------------------------------------------------------------------- */
    private void cmdModifier_Click(object sender, EventArgs e)
    {
      DataRow row = apigrid.GetFocusedDataRow();
      if (null == row) return;

      //écran de modification de la demande
      MozartParams.NumDi = Convert.ToInt32(row["NDINNUM"]);

      Cursor.Current = Cursors.WaitCursor;
      new frmAddAction
      {
        mstrStatutDI = "M",
      }.ShowDialog();

      //on revient donc on réinitialise les variables globales
      MozartParams.NumDi = 0;
      MozartParams.NumAction = 0;

      //rafraichissement du recordset
      Cursor.Current = Cursors.WaitCursor;
      apigrid.Requery(dt, MozartDatabase.cnxMozart);
      Cursor.Current = Cursors.Default;
    }

    /* --------------------------------------------------------------------------------------- */
    private void cmdQuitter_Click(object sender, System.EventArgs e)
    {
      Dispose();
    }
    /* --------------------------------------------------------------------------------------- */
    private void apigrid_DblClickE(object sender, EventArgs e)
    {
      cmdModifier_Click(null, null);
    }

  }
}

