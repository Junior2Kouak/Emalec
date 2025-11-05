using DevExpress.XtraGrid.Views.Grid;
using MozartCS.Properties;
using MozartLib;
using MozartNet;
using MozartUC;
using System;
using System.Data;
using System.Reflection;
using System.Windows.Forms;
using MZUtils = MozartControls.Utils;


namespace MozartCS
{
  public partial class frmGestClientsArch : Form
  {
    private DataTable dt = new DataTable();

    public frmGestClientsArch()
    {
      InitializeComponent();
    }

    private void frmGestClientsArch_Load(object sender, EventArgs e)
    {
      try
      {
        Cursor.Current = Cursors.WaitCursor;
        ModuleMain.Initboutons(this);

        string lQuery = "select VCLINOM, VCLIAD1, VCLIAD2, VCLICP, VCLIVIL, VCLIPAYS, VCLIMESS, NCLINUM,";
        lQuery += " (SELECT top 1 ISNULL(CNOTINTERDIT, 'N') FROM TNOTES WITH (NOLOCK) WHERE VNOTTYPE = 'INFO_CLIENT' AND TNOTES.NNOTCLE = NCLINUM) 'INTERDIT'";
        lQuery += " from TCLI";
        lQuery += " where VSOCIETE = App_Name() AND CCLIACTIF='N'";
        lQuery += " Order by VCLINOM";
        apiTGrid1.LoadData(dt, MozartDatabase.cnxMozart, lQuery);

        InitApigrid();
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

    private void cmdModifier_Click(object sender, EventArgs e)
    {
      DataRow row = apiTGrid1.GetFocusedDataRow();
      if (null == row) return;

      new frmDetailsClient
      {
        mstrStatut = "M",
        miNumClient = (int)row["NCLINUM"]
      }.ShowDialog();

      apiTGrid1.Requery(dt, MozartDatabase.cnxMozart);
    }

    private void InitApigrid()
    {
      apiTGrid1.AddColumn(Resources.col_Nom, "VCLINOM", 2800);
      apiTGrid1.AddColumn(Resources.col_Adresse1, "VCLIAD1", 2300);
      apiTGrid1.AddColumn(Resources.col_Adresse2, "VCLIAD2", 1200);
      apiTGrid1.AddColumn(Resources.col_CP, "VCLICP", 700);
      apiTGrid1.AddColumn(Resources.col_Ville, "VCLIVIL", 1700);
      apiTGrid1.AddColumn(Resources.col_Pays, "VCLIPAYS", 800);
      apiTGrid1.AddColumn(Resources.col_Observ, "VCLIMESS", 2500);
      apiTGrid1.AddColumn("NumCli", "NCLINUM", 0);
      apiTGrid1.AddColumn("INTERDIT", "INTERDIT", 0);

      apiTGrid1.InitColumnList();
      apiTGrid1.GridControl.DataSource = dt;
    }

    private void cmdCoef_Click(object sender, EventArgs e)
    {
      try
      {
        DataRow row = apiTGrid1.GetFocusedDataRow();
        if (null == row) return;

        new frmGestCoeffVente { miNumClient = (int)row["NCLINUM"] }.ShowDialog();
      }
      catch (Exception ex)
      {
        MZUtils.displayError(MethodBase.GetCurrentMethod().Name, ex);
      }
    }

    private void cmdComptecli_Click(object sender, EventArgs e)
    {
      try
      {
        DataRow row = apiTGrid1.GetFocusedDataRow();
        if (null == row) return;

        new frmGestCompteCli(row["NCLINUM"], row["VCLINOM"]).ShowDialog();
      }
      catch (Exception ex)
      {
        MZUtils.displayError(MethodBase.GetCurrentMethod().Name, ex);
      }
    }

    private void cmdContacts_Click(object sender, EventArgs e)
    {
      try
      {
        DataRow row = apiTGrid1.GetFocusedDataRow();
        if (null == row) return;

        new frmGestContactsClient { miNumClient = (int)row["NCLINUM"] }.ShowDialog();
      }
      catch (Exception ex)
      {
        MZUtils.displayError(MethodBase.GetCurrentMethod().Name, ex);
      }
    }

    private void cmdRSF_Click(object sender, EventArgs e)
    {
      try
      {
        DataRow row = apiTGrid1.GetFocusedDataRow();
        if (null == row) return;

        new frmGestRSF((int)row["NCLINUM"]).ShowDialog();
      }
      catch (Exception ex)
      {
        MZUtils.displayError(MethodBase.GetCurrentMethod().Name, ex);
      }
    }

    private void cmdsite_Click(object sender, EventArgs e)
    {
      try
      {
        DataRow row = apiTGrid1.GetFocusedDataRow();
        if (null == row) return;

        new frmGestSites { miNumClient = (int)row["NCLINUM"] }.ShowDialog();
      }
      catch (Exception ex)
      {
        MZUtils.displayError(MethodBase.GetCurrentMethod().Name, ex);
      }
    }

    private void cmdInfo_Click(object sender, EventArgs e)
    {
      try
      {
        DataRow row = apiTGrid1.GetFocusedDataRow();
        if (null == row) return;

        new frmSaisieInfos
        {
          miCleTable = (int)row["NCLINUM"],
          mstrTypeNote = "INFO_CLIENT"
        }.ShowDialog();
      }
      catch (Exception ex)
      {
        MZUtils.displayError(MethodBase.GetCurrentMethod().Name, ex);
      }
    }

    private void cmdSupprimer_Click(object sender, EventArgs e)
    {
      try
      {
        DataRow row = apiTGrid1.GetFocusedDataRow();
        if (null == row) return;

        if (MessageBox.Show(Resources.msg_restaurer_client, Program.AppTitle, MessageBoxButtons.YesNo,
                            MessageBoxIcon.Question, MessageBoxDefaultButton.Button2) != DialogResult.Yes) return;

        MozartDatabase.ExecuteNonQuery($"UPDATE TCLI SET CCLIACTIF = 'O' WHERE NCLINUM = {row["NCLINUM"]}");
        MozartUcUtils.SpyLog(MozartDatabase.cnxMozart, Text, toolTip1.GetToolTip(cmdSupprimer), "Modification", $"NCLINUM:{row["NCLINUM"]}");

        apiTGrid1.Requery(dt, MozartDatabase.cnxMozart);
      }
      catch (Exception ex)
      {
        MZUtils.displayError(MethodBase.GetCurrentMethod().Name, ex);
      }
    }

    private void frmGestClientsArch_FormClosed(object sender, FormClosedEventArgs e)
    {
      MozartUcUtils.SpyLog(MozartDatabase.cnxMozart, "", "", "Sortie");
    }

    private void cmdPVFO_Click(object sender, EventArgs e)
    {
      try
      {
        DataRow row = apiTGrid1.GetFocusedDataRow();
        if (null == row) return;

        new frmListeArticlesClient { miNumClient = (int)row["NCLINUM"] }.ShowDialog();
      }
      catch (Exception ex)
      {
        MZUtils.displayError(MethodBase.GetCurrentMethod().Name, ex);
      }
    }

    private void apiTGrid1_RowStyle(object sender, RowStyleEventArgs e)
    {
      if (e.RowHandle >= 0)
      {
        GridView View = sender as GridView;
        if (View.GetDataRow(e.RowHandle)["INTERDIT"].ToString().ToUpper() == "O")
        {
          e.Appearance.BackColor = MozartColors.ColorH8080FF;
          e.HighPriority = true;
        }
      }
    }
  }
}
