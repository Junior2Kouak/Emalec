using DevExpress.XtraCharts;
using MozartCS.Properties;
using MozartLib;
using MozartNet;
using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Reflection;
using System.Windows.Forms;
using MZUtils = MozartControls.Utils;

namespace MozartCS
{
  public partial class frmDetailsDataTechnique : Form
  {

    public int miNumCompteur;
    public string mstrLibCompteur;
    public int miNumSite;

    private int iLastCompteur = 0;
    private int iLastLigneCompteur = 0;
    private DateTime dLastDate = DateTime.Now.AddYears(-1);

    private DataTable dt = new DataTable();

    public frmDetailsDataTechnique()
    {
      InitializeComponent();
    }

    private void frmDetailsDataTechnique_Load(object sender, System.EventArgs e)
    {
      try
      {
        Cursor.Current = Cursors.WaitCursor;

        ModuleMain.Initboutons(this);

        InitapiGrid();

        Label1.Text = $"{Label1.Text} {mstrLibCompteur}";

        Initialiser();
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

    private void cmdValide_Click(object sender, EventArgs e)
    {
      try
      {
        Cursor.Current = Cursors.WaitCursor;

        if (DateReleve.Text == "")
        {
          MessageBox.Show("Il faut saisir une date de relevé", Program.AppTitle, MessageBoxButtons.OK, MessageBoxIcon.Information);
          return;
        }

        if ((DateTime)DateReleve.EditValue <= dLastDate)
        {
          MessageBox.Show("Il faut saisir une date supérieur à la dernière date de relevé", Program.AppTitle, MessageBoxButtons.OK, MessageBoxIcon.Information);
          return;
        }


        if (txtIndice.Text == "" && txtConso.Text == "")
        {
          MessageBox.Show(Resources.txt_saisie_compteur, Program.AppTitle, MessageBoxButtons.OK, MessageBoxIcon.Information);
          return;
        }

        if ((int)txtIndice.EditValue < iLastCompteur)
        {
          MessageBox.Show("La saisie du compteur doit être supérieur à la dernière valeur saisie", Program.AppTitle, MessageBoxButtons.OK, MessageBoxIcon.Information);
          return;
        }

        if (AlerteConso())
        {
          if (DialogResult.Yes == MessageBox.Show(Resources.txt_alert_conso,
                          Resources.txt_voulez_valider,
                          MessageBoxButtons.YesNo, MessageBoxIcon.Question, MessageBoxDefaultButton.Button2))
          {
            return;
          }
        }


        // requete
        using (SqlCommand cmd = new SqlCommand("api_sp_SaisieCompteur", MozartDatabase.cnxMozart))
        {
          cmd.CommandType = CommandType.StoredProcedure;
          SqlCommandBuilder.DeriveParameters(cmd);

          cmd.Parameters["@iAction"].Value = MozartParams.NumAction;
          cmd.Parameters["@iSite"].Value = miNumSite;
          cmd.Parameters["@iCompteur"].Value = miNumCompteur;
          cmd.Parameters["@Valeur"].Value = (int)txtIndice.EditValue;
          cmd.Parameters["@DateReleve"].Value = DateReleve.Text;

          cmd.ExecuteNonQuery();
        }

        Initialiser();

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


    private class donneesGraph
    {
      public string per { get; set; }
      public int ninfoconso { get; set; }
      public donneesGraph() { }
    }

    private void HideGraph()
    {
      XYDiagram diagram = ChartSpace1.Diagram as XYDiagram;
      diagram.DefaultPane.Visibility = ChartElementVisibility.Hidden;
    }

    private void ShowGraph()
    {
      XYDiagram diagram = ChartSpace1.Diagram as XYDiagram;
      diagram.DefaultPane.Visibility = ChartElementVisibility.Visible;
    }

    private void Initialiser()
    {
      HideGraph();

      string sql = $"exec api_sp_StatistiqueDataTech {miNumCompteur}";
      apiGrid.LoadData(dt, MozartDatabase.cnxMozart, sql);
      apiGrid.GridControl.DataSource = dt;

      List<donneesGraph> listDataSource = new List<donneesGraph>();

      if (0 < dt.Rows.Count)
      {

        // récupération des dernières valeurs de relevé
        iLastCompteur = (int)Utils.ZeroIfNull(dt.Rows[0]["NINFODATA"]);
        iLastLigneCompteur = (int)Utils.ZeroIfNull(dt.Rows[0]["NID"]);
        dLastDate = (DateTime)dt.Rows[0]["DINFODATE"];

        // inverser la liste
        List<DataRow> Rows = dt.AsEnumerable().Reverse().ToList();

        foreach (DataRow row in Rows)
        {
          listDataSource.Add(new donneesGraph() { per = row["per"].ToString(), ninfoconso = (int)Utils.ZeroIfNull(row["ninfoconso"]) });
        }

        Series serie1 = ChartSpace1.Series[0];
        serie1.DataSource = listDataSource;

        ShowGraph();
      }
    }


    private void InitapiGrid()
    {
      apiGrid.AddColumn(Resources.col_Date, "DINFODATE", 1100, "dd/MM/yy");
      apiGrid.AddColumn("Index", "NINFODATA", 1000, "0.00", 2);
      apiGrid.AddColumn("Conso", "NINFOCONSO", 1000, "0.00", 2);
      apiGrid.AddColumn("ID", "NID", 0);

      apiGrid.btnExcel.Visible = false;
      apiGrid.btnPrint.Visible = false;
      apiGrid.chkColumnsList.Visible = false;
    }


    private bool AlerteConso()
    {
      // TODO : test de la cohérence des données
      return false;
    }


    private void TxtIndice_TextChanged(object sender, EventArgs e)
    {
      if (txtIndice.Text != "")
        txtConso.EditValue = (int)txtIndice.EditValue - iLastCompteur;
    }

    private void txtConso_TextChanged(object sender, EventArgs e)
    {
      if (txtConso.Text != "")
        txtIndice.EditValue = (int)txtConso.EditValue + iLastCompteur;
    }

    private void cmdSup_Click(object sender, EventArgs e)
    {
      try
      {
        DataRow currentRow = apiGrid.GetFocusedDataRow();
        if (currentRow == null) return;

        if (iLastLigneCompteur != (int)currentRow["NID"])
        {
          MessageBox.Show("Vous ne pouvez supprimer que la dernière saisie", Program.AppTitle, MessageBoxButtons.OK, MessageBoxIcon.Information);
          return;
        }

        if (MessageBox.Show(Resources.msg_confirm_del_ligne, Program.AppTitle, MessageBoxButtons.YesNo, MessageBoxIcon.Question,
                            MessageBoxDefaultButton.Button2) != DialogResult.Yes)
          return;

        ModuleData.ExecuteNonQuery($"DELETE FROM  TCOMPTEURDATA WHERE NID = {currentRow["NID"]}");

        //rafraichissement de la page
        Initialiser();

      }
      catch (Exception ex)
      {
        MZUtils.displayError(MethodBase.GetCurrentMethod().Name, ex);
      }
    }

    private void cmdFermer_Click(object sender, System.EventArgs e)
    {
      Dispose();
    }

  }
}

