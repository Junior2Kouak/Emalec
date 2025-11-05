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
  public partial class frmListeDemandesDash : Form
  {
    DataTable dt = new DataTable();

    public int IdStat;
    public int Client;
    public int Chaff;
    public int Compte;

    public frmListeDemandesDash() 
    { InitializeComponent(); }

    private void frmListeDemandesDash_Load(object sender, EventArgs e)
    {
      try
      {
        Cursor.Current = Cursors.WaitCursor;
        ModuleMain.Initboutons(this);

        apiTGrid1.LoadData(dt, MozartDatabase.cnxMozart, $"exec [api_sp_ListeStatDashBoard] {Client}, {Chaff}, {Compte}, {IdStat}");
        apiTGrid1.GridControl.DataSource = dt;

        InitTGrid();
      }
      catch (Exception ex)
      {
        MZUtils.displayError(MethodBase.GetCurrentMethod().Name, ex);
      }
      finally { Cursor.Current = Cursors.Default; }
    }

    private void cmdModifier_Click(object sender, EventArgs e)
    {
      DataRow row = apiTGrid1.GetFocusedDataRow();
      if (row == null) return;


      if (IdStat == 5 || IdStat == 16 || IdStat == 17)
        return;

      //écran de modification de la demande
      MozartParams.NumDi = (int)row["NDINNUM"];
      MozartParams.NumAction = (int)row["NACTNUM"];

      Cursor.Current = Cursors.WaitCursor;

      new frmAddAction()
      {
        mstrStatutDI = "M",
      }.ShowDialog();

      //on revient donc on réinitialise les variables globales
      MozartParams.NumDi = 0;
      MozartParams.NumAction = 0;

      Cursor.Current = Cursors.WaitCursor;
      apiTGrid1.Requery(dt, MozartDatabase.cnxMozart);
      Cursor.Current = Cursors.Default;
    }

    private void apiTGrid1_DblClickE(object sender, EventArgs e)
    {
     // cmdModifier_Click(null, null);
    }

    private void InitTGrid()
    {
      switch (IdStat)
      {
        case 1:
        case 2:
        case 3:
        case 4:
        case 6:
        case 7:
        case 8:
        case 9:
        case 10:
        case 11:
        case 12:
        case 13:
        case 14:
        case 15:
        case 18:
        case 19:
        case 20:
        case 21:
        case 22:
          apiTGrid1.AddColumn(Resources.col_DI, "NDINNUM", 700);
          apiTGrid1.AddColumn(Resources.col_date_c, "DDINDATHEUR", 750, "dd/MM/yy");
          apiTGrid1.AddColumn(MZCtrlResources.col_Client, "VCLINOM", 1200);
          apiTGrid1.AddColumn(Resources.col_Site, "VSITNOM", 1200);
          apiTGrid1.AddColumn(Resources.col_Compte, "NDINCTE", 1000, "", 2);
          apiTGrid1.AddColumn(Resources.col_Action, "VACTDES", 4500, "", 0, true);
          break;

        case 5:
          apiTGrid1.AddColumn(Resources.col_Num, "NWDEVNUM", 700);
          apiTGrid1.AddColumn(Resources.col_date_c, "DDINDATHEUR", 750, "dd/MM/yy");
          apiTGrid1.AddColumn(MZCtrlResources.col_Client, "VCLINOM", 1200);
          apiTGrid1.AddColumn(Resources.col_Site, "VSITNOM", 1200);
          apiTGrid1.AddColumn("Titre", "VWDEVTITRE", 1000, "");
          apiTGrid1.AddColumn("Description", "VWDEVDESC", 3500, "", 0, true);
          break;

        case 16:
        case 17:
          apiTGrid1.AddColumn(Resources.col_Facture, "NFACNUM", 700);
          apiTGrid1.AddColumn(Resources.col_DateFacture, "DFACDAT", 750);
          apiTGrid1.AddColumn(MZCtrlResources.col_Client, "VCLINOM", 1200);
          apiTGrid1.AddColumn(Resources.col_Compte, "NDINCTE", 1000, "", 2);
          apiTGrid1.AddColumn(Resources.col_totalHT, "NELFTTC", 1500, "", 0, true);
          break;
      }

//      apiTGrid1.AddColumn(Resources.col_Enseigne, "VSITENSEIGNE", 600);
//      apiTGrid1.AddColumn(Resources.col_Chaff, "VPERNOM", 1000);
//      apiTGrid1.AddColumn(Resources.col_Date, "DACTDATE", 850, "dd/MM/yy");
//      apiTGrid1.AddColumn("Intervenant", "VACTINT", 800);
//      apiTGrid1.AddColumn(Resources.col_Technique, "CTECCOD", 350);
//      apiTGrid1.AddColumn(Resources.col_Prestation, "CPRECOD", 350, "", 2);
//      apiTGrid1.AddColumn(Resources.col_etat, "CETACOD", 350, "", 2);
//      apiTGrid1.AddColumn(Resources.col_Administration, "CACTSTA", 350, "", 2);
//      apiTGrid1.AddColumn("Observations manuelles", "VACTOBSM", 2100, "", 0, true);
//      apiTGrid1.AddColumn(Resources.col_OBS, "VACTOBS", 2100, "", 0, true);
//      apiTGrid1.AddColumn(Resources.col_Type, "VSITTYPE", 1000, "", 0, true);
//      apiTGrid1.AddColumn(Resources.col_RM, "VCCLNOM", 1000, "", 0, true);      // Resp Maintenance
//      apiTGrid1.AddColumn(Resources.col_NumAction, "NACTNUM", 0);
//      apiTGrid1.AddColumn("Type", "CACTTYT", 600);
//      apiTGrid1.AddColumn(Resources.col_Site, "NSITNUM", 0);
//      apiTGrid1.AddColumn(Resources.col_HorsWeb, "CACTVUEWEB", 0);
//      apiTGrid1.AddColumn(Resources.col_Num_CDE, "VACTNUMCDE", 800);
//      apiTGrid1.AddColumn(Resources.col_CP, "VSITCP", 800);

      apiTGrid1.InitColumnList();
    }

		private void cmdQuitter_Click(object sender, EventArgs e)
		{
      Dispose();
		}
	}
}
