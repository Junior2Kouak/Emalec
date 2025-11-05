using MozartLib;
using MozartNet;
using System;
using System.Data;
using System.Reflection;
using System.Windows.Forms;

namespace MozartCS
{
  public partial class frmSuiviContratsClients_ListePaysByContrat : Form
  {

    public int NIDCONTRATCLI_DETAIL;
    DataTable dtData;

    public frmSuiviContratsClients_ListePaysByContrat()
    {
      InitializeComponent();
    }

    private void BtnFermer_Click(object sender, EventArgs e)
    {
      this.Dispose();
    }

    private void frmSuiviContratsClients_ListePaysByContrat_Load(object sender, EventArgs e)
    {

      ModuleMain.Initboutons(this);

      InitApigrid();
      Loaddata();

    }

    private void Loaddata()
    {
      dtData = new DataTable();
      apiTGrid.LoadData(dtData, MozartDatabase.cnxMozart, $"EXEC [api_sp_SuiviClientele_ListePaysByContrat] {NIDCONTRATCLI_DETAIL}");
      apiTGrid.GridControl.DataSource = dtData;
    }
    private void InitApigrid()
    {
      try
      {
        apiTGrid.AddColumn("Pays", "VPAYSNOM", 1500);

      }
      catch (Exception ex)
      {
        Utils.ShowException(ex, MethodBase.GetCurrentMethod().Name, ex.StackTrace);
      }
    }

  }
}
