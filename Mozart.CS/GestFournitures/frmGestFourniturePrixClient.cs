using MozartCS.Properties;
using MozartLib;
using MozartNet;
using System;
using System.Data;
using System.Reflection;
using System.Windows.Forms;
using MZCtrlResources = MozartControls.Properties.Resources;
using MZUtils = MozartControls.Utils;

namespace MozartCS
{
  public partial class frmGestFourniturePrixClient : Form
  {
    public double miFouNum;
    DataTable dt = new DataTable();

    public frmGestFourniturePrixClient()
    {
      InitializeComponent();
    }

    private void frmGestFourniturePrixClient_Load(object sender, EventArgs e)
    {
      try
      {
        ModuleMain.Initboutons(this);

        //apiTGridPrix.LoadData(dt, MozartDatabase.cnxMozart, "EXEC api_sp_ListePrixClientFou " + miFouNum);
        apiTGridPrix.LoadData(dt, MozartDatabase.cnxMozart, "EXEC api_sp_RecherchePrixClientFouV2 " + miFouNum);
        apiTGridPrix.GridControl.DataSource = dt;
        InitApiGrid();
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

    private void InitApiGrid()
    {
      apiTGridPrix.AddColumn(MZCtrlResources.col_Client, "VCLINOM", 2000);
      apiTGridPrix.AddColumn(Resources.col_PrixDeVente, "NPUHTCLI", 1200, "###.00", 1);
      apiTGridPrix.AddColumn("Vendu sur 12 mois", "NFOUNBUTIL", 1000, "", 2);
      apiTGridPrix.AddColumn("Client/Partenaire", "TypeClient", 1200, "", 2);
      apiTGridPrix.AddColumn("Coef prix mini/vente", "Coef", 1500, "###.00", 1);

      apiTGridPrix.InitColumnList();
    }
  }
}

