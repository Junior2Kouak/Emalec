using MZCtrlResources = MozartControls.Properties.Resources;
using MozartCS.Properties;
using MozartLib;
using MozartNet;
using System;
using System.Collections.Generic;
using System.Data;
using System.Reflection;
using System.Windows.Forms;
using MZUtils = MozartControls.Utils;

namespace MozartCS
{
  public partial class frmListeClients : Form
  {
    DataTable dtCli = new DataTable();
    DataTable dtSites = new DataTable();

    public frmListeClients() { InitializeComponent(); }

    private void frmListeClients_Load(object sender, System.EventArgs e)
    {
      try
      {
        Cursor.Current = Cursors.WaitCursor;
        ModuleMain.Initboutons(this);

        InitApiGrid();
        InitApiGridSite();

        //  combo des clients
        cboclient.Init(MozartDatabase.cnxMozart, "select * from api_v_comboClient order by VCLINOM", "NCLINUM", "VCLINOM", new List<string>() { Resources.col_Nom, MZCtrlResources.col_Client }, 500, 500);
        cboclient.SetItemIndex(0);

        Cursor.Current = Cursors.Default;
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

    private void cboclient_TxtChanged(object sender, EventArgs e)
    {
      ApiGrid.LoadData(dtCli, MozartDatabase.cnxMozart, $"exec api_sp_listeCLI {cboclient.GetItemData()}");

      ApiGridSite.LoadData(dtSites, MozartDatabase.cnxMozart, $"select * from  api_v_listeSite WHERE NCLINUM= {cboclient.GetItemData()}");
    }

    private void cmdListeDevis_Click(object sender, EventArgs e)
    {
      DataRow row = ApiGrid.GetFocusedDataRow();
      if (row == null) return;

      new frmListeDevisCL
      {
        mstrFiltreCli = row["VCLINOM"].ToString(),
        miNumCL = Convert.ToInt32(row["NCLINUM"])
      }.ShowDialog();
    }

    private void cmdContact_Click(object sender, EventArgs e)
    {
      new frmListeContact().ShowDialog();
    }

    private void InitApiGrid()
    {
      ApiGrid.AddColumn(Resources.col_Num, "VCLINUM", 850);
      ApiGrid.AddColumn(Resources.col_Nom, "VCLINOM", 1500);
      ApiGrid.AddColumn(Resources.col_Contact, "VCCLNOM", 1350);
      ApiGrid.AddColumn(Resources.col_Tel, "VCCLTEL", 1150);
      ApiGrid.AddColumn(Resources.col_Portable, "VINTPOR", 1150);
      ApiGrid.AddColumn(Resources.col_Adresse1, "VCLIAD1", 1900);
      ApiGrid.AddColumn(Resources.col_Adresse2, "VCLIAD2", 900);
      ApiGrid.AddColumn(Resources.col_CP, "VCLICP", 650);
      ApiGrid.AddColumn(Resources.col_Ville, "VCLIVIL", 1300);
      ApiGrid.AddColumn(Resources.col_NbSites, "NCLINBS", 600, "", 2);
      ApiGrid.AddColumn(Resources.col_Observations, "VCLIMESS", 1200);
      ApiGrid.AddColumn("NumClient", "NCLINUM", 0);

      ApiGrid.InitColumnList();
      ApiGrid.GridControl.DataSource = dtCli;
    }

    private void InitApiGridSite()
    {
      ApiGridSite.AddColumn(Resources.col_Nom, "VSITNOM", 1900);
      ApiGridSite.AddColumn(Resources.col_Enseigne, "VSITENSEIGNE", 1400);
      ApiGridSite.AddColumn(Resources.col_Num, "NSITNUE", 800);
      ApiGridSite.AddColumn(Resources.col_Adresse1, "VSITAD1", 500);
      ApiGridSite.AddColumn(Resources.col_Adresse2, "VSITAD2", 500);
      ApiGridSite.AddColumn(Resources.col_CP, "VSITCP", 700);
      ApiGridSite.AddColumn(Resources.col_Ville, "VSITVIL", 1200);
      ApiGridSite.AddColumn(Resources.col_Pays, "VSITPAYS", 1000);
      ApiGridSite.AddColumn(Resources.col_Tel, "VSITTEL", 1400);
      ApiGridSite.AddColumn(Resources.col_Fax, "VSITFAX", 1400);
      ApiGridSite.AddColumn(Resources.col_Email, "VSITMAI", 500);
      ApiGridSite.AddColumn(Resources.txt_facturation, "VRSFRSF", 1500);
      ApiGridSite.AddColumn(Resources.col_region_client, "VSITREG", 1500);
      ApiGridSite.AddColumn(Resources.col_Region + MozartParams.NomSociete, "VREGLIB", 1600);
      ApiGridSite.AddColumn(Resources.col_resp_mag, "Expr1", 1300);
      ApiGridSite.AddColumn(Resources.col_resp_reg, "Expr2", 1400);
      ApiGridSite.AddColumn(Resources.col_resp_tech, "VCCLNOM", 1400);
      ApiGridSite.AddColumn("NumSite", "NSITNUM", 0);
      ApiGridSite.AddColumn("NumCli", "NCLINUM", 0);

      ApiGridSite.InitColumnList();
      ApiGridSite.GridControl.DataSource = dtSites;
    }
  }
}