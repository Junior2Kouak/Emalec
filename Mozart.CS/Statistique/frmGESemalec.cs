using MZCtrlResources = MozartControls.Properties.Resources;
using DevExpress.XtraCharts;
using Microsoft.VisualBasic;
using MozartCS.Properties;
using MozartNet;
using MozartLib;
using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Reflection;
using System.Windows.Forms;
using MZUtils = MozartControls.Utils;


namespace MozartCS
{
  public partial class frmGESemalec : Form
  {

    private DataTable dt = new DataTable();
    private int iTotalCO2 = 0;

    public frmGESemalec()
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
        DateEdit_Debut.EditValue = DateTime.Now.AddMonths(-6);

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

        apiGrid.AddColumn("Période", "MOIS", 1400, "dd/mm/yyyy");
        apiGrid.AddColumn("CO2 (Kg)", "THT", 1400, "# ###", 1);

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

      // gestion du graphique
      List<donneesGraph> listDataSource = new List<donneesGraph>();
      Series serie1 = Chart.Series[0];

      iTotalCO2 = 0;

      using (SqlCommand cmd = new SqlCommand($"api_sp_StatEmalecCO2ParMois", MozartDatabase.cnxMozart))
      {
        cmd.CommandType = CommandType.StoredProcedure;
        SqlCommandBuilder.DeriveParameters(cmd);

        cmd.Parameters["@DateDebut"].Value = DateEdit_Debut.Text;
        cmd.Parameters["@DateFin"].Value = DateEdit_Fin.Text;
        cmd.Parameters["@vSociete"].Value = apiSocieteAuto1.Text;
        cmd.Parameters["@Client"].Value = cboclient.GetItemData();

        // chargement de la datatable
        dt.Load(cmd.ExecuteReader());

        // parcours de la datatable inversé pour remplir la liste des données dans l'autre sens
        for (int i = dt.Rows.Count - 1; i >= 0; i--)
        {
          DataRow row = dt.Rows[i];

          listDataSource.Add(new donneesGraph() { jourheure = Utils.BlankIfNull(Strings.Left(row[0].ToString(), 10)), NB = (int)Utils.ZeroIfNull(row[1]) });
          iTotalCO2 = iTotalCO2 + (int)Utils.ZeroIfNull(row[1]);
        }
      }

      serie1.DataSource = listDataSource;

      // mise aà jour du total de la période
      lblTotal.Text = $"Total de la période : {Strings.FormatNumber(iTotalCO2, 0)} Kg de CO2";

      // gestion de la liste
      apiGrid.GridControl.DataSource = dt;


      //XYDiagram diagram = Chart.Diagram as XYDiagram;
      //diagram.AxisX.Title.Text = "Mois";
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
      cboclient.Init(MozartDatabase.cnxMozart, $"SELECT NCLINUM, VCLINOM FROM TCLI WHERE CCLIACTIF='O' AND VSOCIETE='{apiSocieteAuto1.Text}' order by VCLINOM", "NCLINUM", "VCLINOM", new List<string>() { Resources.col_Nom, MZCtrlResources.col_Client }, 500, 500);
    }

    private void cmdImprimer_Click(object sender, EventArgs e)
    {
      this.ImprimerDansWord();
    }

    private void cmdQuitter_Click(object sender, System.EventArgs e)
    {
      Dispose();
    }

  }
}

