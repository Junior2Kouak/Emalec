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
  public partial class frmStatFacture : Form
  {
    private DataTable dt = new DataTable();
    private DataTable dt2 = new DataTable();
    private DataTable dt3 = new DataTable();

    public frmStatFacture()
    {
      InitializeComponent();
    }

    private void frmStatFacture_Load(object sender, System.EventArgs e)
    {
      try
      {
        Cursor = Cursors.WaitCursor;

        ModuleMain.Initboutons(this);

        txtDateDebut.Text = $"01/01/{DateTime.Now.Year}";
        txtDateFin.Text = DateTime.Now.ToShortDateString();

        MozartParams.NomSocieteTemp = MozartParams.NomSociete;

        apiSocieteAuto1.Init(MozartDatabase.cnxMozart, MozartParams.NomSocieteTemp);

        InitApigrid();
        InitApigrid2();
        InitApigrid3();
        LoadApiGrids();
      }
      catch (Exception ex)
      {
        MZUtils.displayError(MethodBase.GetCurrentMethod().Name, ex);
      }
      finally
      {
        Cursor = Cursors.Default;
      }
    }

    private void LoadApiGrids()
    {
      LabelTitreTableau();

      string lParams = $"'{txtDateDebut.Text}', '{txtDateFin.Text}', '{MozartParams.NomSocieteTemp}', {apiSocieteAuto1.IdMenuParent}, {MozartParams.UID}";

      apiTGrid1.LoadData(dt, MozartDatabase.cnxMozart, $"EXEC api_sp_StatistiqueFacturation {lParams}");
      apiTGrid1.GridControl.DataSource = dt;

      apiTGrid2.LoadData(dt2, MozartDatabase.cnxMozart, $"EXEC api_sp_StatFactCAClient {lParams}");
      apiTGrid2.GridControl.DataSource = dt2;

      apiTGrid3.LoadData(dt3, MozartDatabase.cnxMozart, $"EXEC api_sp_StatistiqueFacturation {lParams}, 1");
      apiTGrid3.GridControl.DataSource = dt3;
    }

    private void LabelTitreTableau()
    {
      Label2.Text = Label5.Text = Label6.Text = $"Période du {txtDateDebut.Text} au {txtDateFin.Text} le {DateTime.Now.ToShortDateString()}";
      Label1.Text = Label3.Text = Label4.Text = $"Clients Filiale {MozartParams.NomSocieteTemp}";
    }

    private void cmdValider_Click(object sender, EventArgs e)
    {
      try
      {
        Cursor = Cursors.WaitCursor;
        LoadApiGrids();
      }
      catch (Exception ex)
      {
        MZUtils.displayError(MethodBase.GetCurrentMethod().Name, ex);
      }
      finally
      {
        Cursor = Cursors.Default;
      }
    }

    private void cmdAn_Click(object sender, EventArgs e)
    {
      Cursor = Cursors.WaitCursor;
      new frmStatFactClientAn(apiSocieteAuto1.IdMenuParent).ShowDialog();
      Cursor = Cursors.Default;
    }

    private void Cmd24m_Click(object sender, EventArgs e)
    {
      DataRow currentRow = apiTGrid1.GetFocusedDataRow();
      if (currentRow == null)
      {
        return;
      }

      Cursor = Cursors.WaitCursor;

      new frmStatCAClient
      {
        strNomSociete = currentRow["VSOCIETE"].ToString(),
        msNomClient = currentRow["VCLINOM"].ToString(),
        miNumClient = currentRow["NCLINUM"].ToString() != "" ? (int)currentRow["NCLINUM"] : 0
      }.ShowDialog();

      Cursor = Cursors.Default;
    }

    private void apiSocieteAuto1_Change(object sender, EventArgs e)
    {
      MozartParams.NomSocieteTemp = apiSocieteAuto1.Text;
    }

    private void InitApigrid()
    {
      apiTGrid1.AddColumn(Resources.col_DateCreationClient, "DCLIDATECRE", 1500);
      apiTGrid1.AddColumn(MZCtrlResources.col_Client, "VCLINOM", 3800);
      apiTGrid1.AddColumn("Ancienneté", "ANCIENNETE", 1300, "", 2);
      apiTGrid1.AddColumn(Resources.col_nb_factures, "NBR", 1300, "", 2);
      apiTGrid1.AddColumn(Resources.col_montant_ht, "THT", 1400, "# ### ###", 2);
      apiTGrid1.AddColumn(Resources.col_PourcentCA, "%CA", 1000, "#0.00", 2);

      apiTGrid1.InitColumnList();
    }

    private void InitApigrid2()
    {
      apiTGrid2.AddColumn(MZCtrlResources.col_libelle, "LIB", 5300);
      apiTGrid2.AddColumn(Resources.col_Valeur, "CA", 800, "", 2);

      apiTGrid2.InitColumnList();
    }

    private void InitApigrid3()
    {
      apiTGrid3.AddColumn(MZCtrlResources.col_Client, "NUMCLASS", 1800, "", 2);
      apiTGrid3.AddColumn(Resources.col_Facturation_HT, "THT", 2800, "# ### ###", 2);
      apiTGrid3.AddColumn(Resources.col_pc_fact_totale, "%CA", 1900, "#0.00", 2);

      apiTGrid3.InitColumnList();
    }
  }
}
