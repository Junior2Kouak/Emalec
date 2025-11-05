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

  public partial class frmListeDIDelais : Form
  {

    public int miDelais;
    public int mClient;
    public string mDateDebut;
    public string mDateFin;

    private DataTable dtStatDi = new DataTable();

    public frmListeDIDelais()
    {
      InitializeComponent();
    }

    private void frmListeDIDelais_Load(object sender, System.EventArgs e)
    {
      try
      {
        Cursor.Current = Cursors.WaitCursor;

        ModuleMain.Initboutons(this);

        InitApigrid();

        apigrid.LoadData(dtStatDi, MozartDatabase.cnxMozart, $"exec api_sp_listeDIdelais {mClient}, '{mDateDebut}', '{mDateFin}', {miDelais}");
        apigrid.GridControl.DataSource = dtStatDi;

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

    private void cmdQuitter_Click(object sender, System.EventArgs e)
    {
      Dispose();
    }



    private void InitApigrid()
    {
      apigrid.AddColumn(Resources.col_DI, "NDINNUM", 600);
      apigrid.AddColumn(Resources.col_date_c, "DDINDATHEUR", 780, "dd/MM/yy", 2);
      apigrid.AddColumn(MZCtrlResources.col_Client, "VCLINOM", 970);
      apigrid.AddColumn(Resources.col_Site, "VSITNOM", 1350);
      apigrid.AddColumn(Resources.col_Num, "NSITNUE", 480);
      apigrid.AddColumn(Resources.col_Action, "VACTDES", 4900);
      apigrid.AddColumn(Resources.col_Date, "DACTDEX", 770, "dd/MM/yy", 2);
      apigrid.AddColumn(Resources.col_Urgence, "CURGCOD", 200);
      apigrid.AddColumn(Resources.col_Technique, "CTECCOD", 200);
      apigrid.AddColumn(Resources.col_Prestation, "CPRECOD", 200);
      apigrid.AddColumn(Resources.col_etat, "CETACOD", 200);
      apigrid.AddColumn(Resources.col_Administration, "CACTSTA", 200);
      apigrid.AddColumn(Resources.col_Observations, "VACTOBS", 1400);
      apigrid.AddColumn(Resources.col_NumAction, "NACTNUM", 0);

      apigrid.chkColumnsList.Visible = false;
    }


    private void cmdModifier_Click(object sender, EventArgs e)
    {
      AppelFrmAddAction();
    }

    private void AppelFrmAddAction()
    {
      DataRow row = apigrid.GetFocusedDataRow();
      if (null == row)
      {
        return;
      }

      MozartParams.NumDi = int.Parse(row["NDINNUM"].ToString());

      frmAddAction frm = new frmAddAction()
      {
        mstrStatutDI = "M",

      };

      frm.ShowDialog();

      MozartParams.NumDi = 0;
      MozartParams.NumAction = 0;
    }

    private void apigrid_DoubleClickE(object sender, EventArgs e)
    {
      AppelFrmAddAction();
    }

  }
}

