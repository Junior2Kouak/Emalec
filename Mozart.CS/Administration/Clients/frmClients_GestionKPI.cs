using MozartLib;
using MozartNet;
using System;
using System.Data;
using System.Data.SqlClient;
using System.Reflection;
using System.Windows.Forms;
using MZUtils = MozartControls.Utils;

namespace MozartCS
{
  public partial class frmClients_GestionKPI : Form
  {
    private int _NCLINUM;

    public frmClients_GestionKPI(int pNCLINUM)
    {
      InitializeComponent();

      _NCLINUM = pNCLINUM;
    }

    private void frmClients_GestionKPI_Load(object sender, EventArgs e)
    {
      try
      {
        Cursor.Current = Cursors.WaitCursor;
        ModuleMain.Initboutons(this);

        LoadData();
        checkBox1_CheckedChanged(null, null);

        ucGestionKPI1.initComponent(_NCLINUM);
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

    private void LoadData()
    {
      int lVal;

      using (SqlCommand cmd = new SqlCommand("api_sp_Client_GetGestionKPI", MozartDatabase.cnxMozart))
      {
        cmd.CommandType = CommandType.StoredProcedure;
        SqlCommandBuilder.DeriveParameters(cmd);

        cmd.Parameters["@P_NCLINUM"].Value = _NCLINUM;

        SqlDataReader sdr = cmd.ExecuteReader();
        if (sdr.HasRows)
        {
          sdr.Read();
          lVal = (int)Utils.ZeroIfNull(sdr["NCLI_KPI_PLA_PREV"]);
          ChkKPI.Checked = (lVal != 0);

          lVal = (int)Utils.ZeroIfNull(sdr["NCLI_KPI_DELAI_CONT"]);
          chkDelaiParContrat.Checked = (lVal != 0);
        }

        sdr.Close();
      }
    }

    private void cmdEnregistrer_Click(object sender, EventArgs e)
    {
      try
      {
        Cursor.Current = Cursors.WaitCursor;

        if (chkDelaiParContrat.Checked)
        {
          ucGestionKPI1.commitChanges();
        }

        using (SqlCommand cmd = new SqlCommand("api_sp_Client_SaveGestionKPI", MozartDatabase.cnxMozart))
        {
          cmd.CommandType = CommandType.StoredProcedure;
          SqlCommandBuilder.DeriveParameters(cmd);

          cmd.Parameters["@P_NCLINUM"].Value = _NCLINUM;
          cmd.Parameters["@P_NCLI_KPI_PLA_PREV"].Value = ChkKPI.Checked ? 1 : 0;
          cmd.Parameters["@P_NCLI_KPI_DELAI_CONT"].Value = chkDelaiParContrat.Checked ? 1 : 0;

          cmd.ExecuteNonQuery();
        }
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

    private void BtnHelpKPI_DateContractuel_Click(object sender, EventArgs e)
    {
      MessageBox.Show($"Lorsque vous cochez cette case, les dates souhaitées des maintenances préventives vont devenir contractuelles.{Environment.NewLine}" +
            $"Ces dates devront donc être les derniers jours contractuels où vous pourrez planifier les préventives.{Environment.NewLine}" +
            $"Le but étant de pouvoir transmettre un rapport FM intégrant les plannings préventifs afin d’en juger la part de préventives planifiées avant les dates souhaitées.{Environment.NewLine}" +
            $"Le Message « Date contractuelle à respecter » va apparaitre en dessous de la date souhaitée.{Environment.NewLine}" +
            $"Dans ce cas, seuls les chargés d’affaires adjoints et leurs supérieurs hiérarchiques pourront modifier la date souhaitée.{Environment.NewLine}" +
            $"Lorsqu’une personne voudra planifier une action au-delà de la date souhaitée, un message d’information « Attention, la planification dépasse la date contractuelle à respecter » sera affiché.",
        "Informations", MessageBoxButtons.OK, MessageBoxIcon.Information);
    }

    private void checkBox1_CheckedChanged(object sender, EventArgs e)
    {
      ucGestionKPI1.Visible = chkDelaiParContrat.Checked;
    }

    private void cmdViewDefaultValues_Click(object sender, EventArgs e)
    {
      Cursor.Current = Cursors.WaitCursor;
      new frmKPIDefaultValues().ShowDialog();
      Cursor.Current = Cursors.Default;
    }

    private void cmdTous_Click(object sender, EventArgs e)
    {
      ucGestionKPI1.copySelectedOnOthers();
    }
  }
}
