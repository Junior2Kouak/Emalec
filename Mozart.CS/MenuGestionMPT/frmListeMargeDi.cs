using MZCtrlResources = MozartControls.Properties.Resources;
using Microsoft.VisualBasic;
using MozartCS.Properties;
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
  public partial class frmListeMargeDi : Form
  {
    DataTable dt = new DataTable();

    public frmListeMargeDi()
    {
      InitializeComponent();
    }

    private void frmListeMargeDi_Load(object sender, System.EventArgs e)
    {
      try
      {
        ModuleMain.Initboutons(this);

        apigrid.LoadData(dt, MozartDatabase.cnxMozart, "select * from api_v_listeDiMarge ORDER BY DI DESC");
        apigrid.GridControl.DataSource = dt;

        InitApigrid();
        apiToolTip1.Visible = apiToolTipInfos.Visible = true;
        Cursor = Cursors.Default;
      }
      catch (Exception ex)
      {
        Cursor = Cursors.Default;
        MZUtils.displayError(MethodBase.GetCurrentMethod().Name, ex);
      }
    }

    private void cmdQuitter_Click(object sender, System.EventArgs e)
    {
      Dispose();
    }

    private void InitApigrid()
    {
      try
      {
        apigrid.AddColumn(Resources.col_DI, "DI", 800, "", 2);
        apigrid.AddColumn(Resources.col_Date, "DDINDAT", 1000, "", 2);
        apigrid.AddColumn(MZCtrlResources.col_Client, "VCLINOM", 2800);
        apigrid.AddColumn(Resources.col_Depenses, "Depenses", 1000, "", 1);
        apigrid.AddColumn(Resources.col_Recettes, "Recettes", 1000, "", 1);
        apigrid.AddColumn(Resources.col_Coeff, "Coef", 600, "", 1);
        //apigrid.AddColumn("Cpte", "", 700, "", 2);
        //apigrid.AddColumn(Resources.col_Chaff, "",1200);

        apigrid.InitColumnList();
        apigrid.DesactiveListe();
      }
      catch (Exception ex)
      {
        MZUtils.displayError(MethodBase.GetCurrentMethod().Name, ex);
      }
    }

    private void cmdMAJ_Click(object sender, EventArgs e)
    {
      DataRow row = apigrid.GetFocusedDataRow();
      if (row == null) return;

      Cursor.Current = Cursors.WaitCursor;
      ModuleData.ExecuteNonQuery("DELETE FROM TDINMARGE WHERE NDINNUM =" + Strings.Mid(row["DI"].ToString(), 3));
      CalculCoefMarge();
      apigrid.Requery(dt, MozartDatabase.cnxMozart);
      Cursor.Current = Cursors.Default;
    }

    /* OK -------------------------------------------------------------------------------------*/
    private void cmdModifier_Click(object sender, EventArgs e)
    {
      DataRow row = apigrid.GetFocusedDataRow();
      if (row == null) return;

      Cursor.Current = Cursors.WaitCursor;

      MozartParams.NumDi = Convert.ToInt32(Strings.Mid(row["DI"].ToString(), 3));
      MozartParams.NumAction = 0;

      //  ' écran de modification de la demande
      frmAddAction f = new frmAddAction();
      f.mstrStatutDI = "M";
      f.ShowDialog();

      MozartParams.NumDi = 0;
      MozartParams.NumAction = 0;

      Cursor.Current = Cursors.Default;
    }

    private void apigrid_DoubleClickE(object sender, EventArgs e)
    {
      cmdModifier_Click(null, null);
    }

    private void apigrid_SelectionChanged(object sender, DevExpress.Data.SelectionChangedEventArgs e)
    {
      DataRow currentRow = apigrid.GetFocusedDataRow();
      if (currentRow == null) return;
      CalculCoefMarge();
    }

    private void CalculCoefMarge()
    {
      DataRow current = apigrid.GetFocusedDataRow();
      if (current == null) return;

      using (DataSet ds = new DataSet())
      {
        SqlDataAdapter da = new SqlDataAdapter();
        SqlCommand cmd = new SqlCommand("EXEC api_sp_CalculCoefMarge2 " + Strings.Mid(current["DI"].ToString(), 3) + ", 'Batch'", MozartDatabase.cnxMozart);
        da = new SqlDataAdapter(cmd);
        da.Fill(ds);

        //Calcul coef de marge
        DataRow sdr = ds.Tables[0].Rows[0];

        apiToolTip1.AddColumn(Resources.txt_Marge + sdr["Coef"].ToString(), 2000);
        apiToolTip1.AddColumn("", 2000);

        apiToolTip1.Texte = $"Heures Techniciens||{Strings.Format(sdr["HeuresTech"], "######,#0")}\r\n" +
                            $"Dépl. techniciens||{Strings.Format(sdr["DepTech"], "######,#0")}\r\n" +
                            $"Sortie stock||{Strings.Format(sdr["TotStockHT"], "######,#0")}\r\n" +
                            $"Factures Ravel||{Strings.Format(sdr["TotFacHT"], "######,#0")}\r\n" +
                            $"Commandes FO||{Strings.Format(sdr["TotFouHT"], "######,#0")}\r\n" +
                            $"Devis ST||{Strings.Format(sdr["TotDevisHT"], "######,#0")}\r\n" +
                            $"Montants estimés||{Strings.Format(sdr["TotMtEst"], "######,#0")}\r\n" +
                            $"Total dépenses||{Strings.Format(sdr["Depenses"], "######,#0")}\r\n" +
                            $"Total recettes||{Strings.Format(sdr["Recettes"], "######,#0")}\r\n";
        apiToolTip1.PrintTexte("{0,-25} {1,6}");
        apiToolTip1.ProcInfo = "Image_Click";

        sdr = ds.Tables[1].Rows[0];

        lblInfos.Text = sdr[0].ToString();
        apiToolTipInfos.Texte = lblInfos.Text;
        apiToolTip1.Visible = true;
        apiToolTipInfos.PrintTexte("");
      }

      //apiToolTip1_HelpRequested(null, null);
      //apiToolTip1.Visible = true;
    }

    public void Image_Click()
    {
      apiToolTipInfos.Visible = true;
    }

  }
}