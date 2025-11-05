using DevExpress.XtraCharts;
using MozartCS.Properties;
using MozartLib;
using MozartNet;
using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Reflection;
using System.Windows.Forms;
using MZUtils = MozartControls.Utils;
using MZCtrlResources = MozartControls.Properties.Resources;


namespace MozartCS
{
  public partial class frmStatFournCA : Form
  {
    private DataTable dt1 = new DataTable();
    private DataTable dt2 = new DataTable();
    private DataTable dt3 = new DataTable();

    public frmStatFournCA()
    {
      InitializeComponent();
    }

    private void frmStatFournCA_Load(object sender, System.EventArgs e)
    {
      try
      {
        Cursor.Current = Cursors.WaitCursor;

        ModuleMain.Initboutons(this);

        MozartParams.NomSocieteTemp = MozartParams.NomSociete;
        apiSocieteAuto1.Init(MozartDatabase.cnxMozart, MozartParams.NomSocieteTemp);

        txtDateA0.Text = DateTime.Now.AddYears(-1).ToShortDateString();
        txtDateA1.Text = DateTime.Now.ToShortDateString();

        LabelDate.Text = $"{Resources.lbl_Le} {DateTime.Now.ToShortDateString()}";

        apiSocieteAuto1.Init(MozartDatabase.cnxMozart, MozartParams.NomSocieteTemp);

        InitApigrid();

        InitApigrid1();

        InitApigrid2();


        UpdateDataGrids();

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

    private void UpdateDataGrids()
    {
      // test des dates
      if (txtDateA0.Text == "")
      {
        MessageBox.Show(Resources.msg_must_select_start_date);
        return;
      }
      if (txtDateA1.Text == "")
      {
        MessageBox.Show(Resources.msg_must_select_end_date);
        return;
      }

      LabelPeriode();

      // 1er tableau
      string sql = $"exec api_sp_StatistiqueFournCA -1, '{txtDateA0.Text}', '{txtDateA1.Text}', 0, '{MozartParams.NomSocieteTemp}', 415, {MozartParams.UID}";
      apiGrid.LoadData(dt1, MozartDatabase.cnxMozart, sql);
      apiGrid.GridControl.DataSource = dt1;

      apiGrid.dgv.SelectRow(0);

      // 2eme tableau
      sql = $"exec api_sp_StatistiqueFournCA -1, '{txtDateA0.Text}', '{txtDateA1.Text}', 1, '{MozartParams.NomSocieteTemp}', 415, {MozartParams.UID}";
      apiTGrid2.LoadData(dt2, MozartDatabase.cnxMozart, sql);
      apiTGrid2.GridControl.DataSource = dt2;

      // 3eme tableau
      sql = $"exec api_sp_StatistiqueFournCA -1, '{txtDateA0.Text}', '{txtDateA1.Text}', 2, '{MozartParams.NomSocieteTemp}', 415, {MozartParams.UID}";
      apiTGrid3.LoadData(dt3, MozartDatabase.cnxMozart, sql);
      apiTGrid3.GridControl.DataSource = dt3;
    }

    private void cmdValider_Click(object sender, EventArgs e)
    {
      try
      {
        Cursor.Current = Cursors.WaitCursor;

        UpdateDataGrids();
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

    private void LabelPeriode()
    {
      Label64.Text = Label63.Text = Label62.Text = Label60.Text =
        $"{Resources.lbl_periodedu} {txtDateA0.Text} {Resources.lbl_au} {txtDateA1.Text}";
    }

    private void CmdFacFourAn_Click(object sender, EventArgs e)
    {
      DataRow row = apiGrid.GetFocusedDataRow();
      if (null == row)
      {
        return;
      }

      frmStatFournCAByAn frm = new frmStatFournCAByAn();

      frm.iNumFour = int.Parse(row["NSTFGRPNUM"].ToString());
      frm.sNomFour = row["VSTFGRPNOM"].ToString();
      frm.sNomSocieteSelected = MozartParams.NomSocieteTemp;

      frm.ShowDialog();
    }

    private void InitApigrid()
    {
      apiGrid.AddColumn(Resources.col_Fournisseur, "VSTFGRPNOM", 2100);
      apiGrid.AddColumn(Resources.txt_Tot_HT, "TotalHT", 1000, "### ### ##0", 1);
      apiGrid.AddColumn(Resources.txt_Nb_Fact, "NbFact", 700, "", 2);
      apiGrid.AddColumn(Resources.col_Moyenne, "FactMoy", 800, "### ##0", 1);
      apiGrid.AddColumn(Resources.col_Fournisseur, "NSTFGRPNUM", 0);

      apiGrid.chkColumnsList.Visible = false;
      apiGrid.btnExcel.Visible = false;
    }

    private void InitApigrid1()
    {
      apiTGrid2.AddColumn(MZCtrlResources.col_libelle, "LIB", 3500);
      apiTGrid2.AddColumn(Resources.col_Valeur, "CA", 900, "", 2);

      apiTGrid2.chkColumnsList.Visible = false;
      apiTGrid2.btnExcel.Visible = false;
    }

    private void InitApigrid2()
    {
      apiTGrid3.AddColumn(Resources.col_Fournisseur, "NUMCLASS", 800, "", 2);
      apiTGrid3.AddColumn(Resources.col_Facturation_HT, "THT", 1400, "# ### ###", 2);
      apiTGrid3.AddColumn(Resources.col_pc_fact_totale, "%CA", 2500, "N2", 2);

      apiTGrid3.chkColumnsList.Visible = false;
      apiTGrid3.btnExcel.Visible = false;
    }

    private void cmdImprimer_Click(object sender, EventArgs e)
    {
      this.ImprimerDansWord();
    }

    private class donneesGraph
    {
      public string moisannee { get; set; }
      public int TotalHT { get; set; }
      public donneesGraph() { }
    }

    private void apiGrid_SelectionChanged(object sender, DevExpress.Data.SelectionChangedEventArgs e)
    {
      try
      {
        DataRow row = apiGrid.GetFocusedDataRow();
        if (null == row)
        {
          return;
        }

        Cursor.Current = Cursors.WaitCursor;

        Label65.Text = $"FO/ST sélectionnée : {row["VSTFGRPNOM"]}";

        // graphique 
        List<donneesGraph> listDataSource = new List<donneesGraph>();
        int total = 0;
        using (SqlDataReader reader = ModuleData.ExecuteReader($"exec api_sp_StatistiqueFournCA {row["NSTFGRPNUM"]}, '{txtDateA0.Text}', '{txtDateA1.Text}', 0, '{MozartParams.NomSocieteTemp}'"))
        {
          while (reader.Read())
          {
            int n = (int)Utils.ZeroIfNull(reader["TotalHT"]);
            total = total + n;
            listDataSource.Add(new donneesGraph()
            {
              moisannee = $"{Utils.ZeroIfNull(reader["Mois"]).ToString().PadLeft(2, '0')}/" +
                                                                $"{Utils.ZeroIfNull(reader["Annee"]).ToString().Substring(2)}",
              TotalHT = n
            });
          }
          reader.Close();
        }


        Label1.Text = $"CA des 24 derniers mois clos :   {total:### ### ###}  €HT";

        Series serie1 = Chart.Series["Serie1"];
        serie1.DataSource = listDataSource;

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
      MozartParams.NomSocieteTemp = apiSocieteAuto1.Text;
    }
  }
}

