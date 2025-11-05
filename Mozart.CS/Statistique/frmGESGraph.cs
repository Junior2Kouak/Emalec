using Microsoft.VisualBasic;
using MozartCS.Properties;
using MozartLib;
using MozartNet;
using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Reflection;
using System.Windows.Forms;
using MZCtrlResources = MozartControls.Properties.Resources;
using MZUtils = MozartControls.Utils;


namespace MozartCS
{
  public partial class frmGESGraph : Form
  {

    private DataTable dt = new DataTable();

    public frmGESGraph()
    {
      InitializeComponent();
    }

    private class donneesGraph
    {
      public string jourheure { get; set; }
      public int NB { get; set; }
      public donneesGraph() { }
    }

    private void frmGESemalec_Load(object sender, EventArgs e)
    {
      try
      {
        Cursor.Current = Cursors.WaitCursor;

        ModuleMain.Initboutons(this);
        MozartParams.NomSocieteTemp = MozartParams.NomSociete;
        apiSocieteAuto1.Init(MozartDatabase.cnxMozart, MozartParams.NomSocieteTemp, false);

        DateEdit_Fin.EditValue = DateTime.Now;
        DateEdit_Debut.EditValue = DateTime.Now.AddMonths(-12);

        InitApigrid();

        UpdateData();
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

    private void InitApigrid()
    {
      try
      {
        apiGrid.AddColumn("Période", "PERIODE", 1400, "dd/mm/yyyy");
        apiGrid.AddColumn("CO2 (Kg)", "CO2TOT", 1400, "# ###", 1);

        apiGrid.InitColumnList();
      }
      catch (Exception ex)
      {
        MZUtils.displayError(MethodBase.GetCurrentMethod().Name, ex);
      }
    }

    private void UpdateData()
    {
      dt.Clear();

      using (SqlCommand cmd = new SqlCommand($"api_sp_StatCO2Graph", MozartDatabase.cnxMozart))
      {
        cmd.CommandType = CommandType.StoredProcedure;
        SqlCommandBuilder.DeriveParameters(cmd);

        cmd.Parameters["@DateDebut"].Value = DateEdit_Debut.Text;
        cmd.Parameters["@DateFin"].Value = DateEdit_Fin.Text;
        cmd.Parameters["@vSociete"].Value = apiSocieteAuto1.Text;
        cmd.Parameters["@Client"].Value = cboclient.GetItemData();


        // chargement de la datatable
        dt.Load(cmd.ExecuteReader());
      }

      // gestion de la liste et du graphique
      apiGrid.GridControl.DataSource = dt;
      ChartCtrlPers.DataSource = dt;

      // mise à jour du total de la période
      calculTHT();
    }

    private void cmdValider_Click(object sender, EventArgs e)
    {
      try
      {
        Cursor.Current = Cursors.WaitCursor;

        UpdateData();
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

    private void apiSocieteAuto1_Change(object sender, EventArgs e)
    {
      //  combo des clients en fonction de la société
      cboclient.Init(MozartDatabase.cnxMozart, $"SELECT distinct TCLI.NCLINUM, VCLINOM FROM  STATISTIQUE.DBO.TSTATCO2 CO2 INNER JOIN TCLI ON CO2.NCLINUM = TCLI.NCLINUM" +
        $" WHERE CCLIACTIF ='O' AND TCLI.VSOCIETE='{apiSocieteAuto1.Text}' " +
        $"order by VCLINOM", "NCLINUM", "VCLINOM", new List<string>() { Resources.col_Nom, MZCtrlResources.col_Client }, 500, 500);
    }

    private void cmdImprimer_Click(object sender, EventArgs e)
    {
      this.ImprimerDansWord();
    }

    private void calculTHT()
    {
      double dTot = 0;

      if (dt.Rows.Count == 0)
        return;

      foreach (DataRow row in dt.Rows)
        dTot += Utils.ZeroIfNull(row["CO2TOT"]);

      lblTotal.Text = $"Total de la période : {Strings.FormatNumber(dTot, 0)} Kg de CO2";

    }

    private void cmdQuitter_Click(object sender, System.EventArgs e)
    {
      Dispose();
    }

  }
}

