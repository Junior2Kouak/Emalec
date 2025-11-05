using MZCtrlResources = MozartControls.Properties.Resources;
using MozartCS.Properties;
using MozartLib;
using MozartNet;
using System;
using System.Data;
using System.Reflection;
using System.Windows.Forms;
using MZUtils = MozartControls.Utils;

namespace MozartCS
{
  public partial class frmListeFourNF : Form
  {

    DataTable dt = new DataTable();


    public frmListeFourNF() { InitializeComponent(); }

    private void frmListeFourNF_Load(object sender, System.EventArgs e)
    {
      try
      {
        ModuleMain.Initboutons(this);
        txtDateA0.Text = "01/01/" + DateTime.Now.Year.ToString();
        txtDateA1.Text = DateTime.Now.ToShortDateString();

        InitApigrid();

        apiTGridFouNF.dgv.ColumnFilterChanged += new EventHandler(apiTGridFouNF_ColumnFilterChanged);

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

    private void CmdValid_Click(object sender, System.EventArgs e)
    {
      string sSQL = $"api_sp_StatNF '{txtDateA0.Text}' , '{txtDateA1.Text}'";

      apiTGridFouNF.LoadData(dt, MozartDatabase.cnxMozart, sSQL);
      apiTGridFouNF.GridControl.DataSource = dt;

      CalcTotHT();
    }

    /* OK ---------------------------------------------------------------------------------------------- */
    private void InitApigrid()
    {
      apiTGridFouNF.AddColumn(MZCtrlResources.col_Client, "VCLINOM", 1200);
      apiTGridFouNF.AddColumn(Resources.col_Chaff, "VCHAFF", 1200);
      apiTGridFouNF.AddColumn(Resources.col_ChefGroupe, "VCHEFGRP", 1200);
      apiTGridFouNF.AddColumn(Resources.col_DI, "NDINNUM", 1000);
      apiTGridFouNF.AddColumn(Resources.col_Site, "VSITNOM", 1400);
      apiTGridFouNF.AddColumn(Resources.col_Contrat, "VTYPECONTRAT", 1700);
      apiTGridFouNF.AddColumn(Resources.col_Action, "VACTDES", 3000);
      apiTGridFouNF.AddColumn(Resources.col_Prestation, "VPRELIB", 1000);
      apiTGridFouNF.AddColumn(Resources.col_Intervenant, "VTYPEINTER", 1000);
      apiTGridFouNF.AddColumn(Resources.col_DateExec, "DACTDEX", 1000, "dd/mm/yyy", 2);
      apiTGridFouNF.AddColumn(Resources.col_euro_heure, "NNFTOTH", 1100, "currency", 1);
      apiTGridFouNF.AddColumn(Resources.col_euro_depl, "NNFTOTDEP", 1100, "currency", 1);
      apiTGridFouNF.AddColumn(Resources.col_four, "NNFFOU", 1100, "currency", 1);
      apiTGridFouNF.AddColumn(Resources.col_stt, "NNFSTT", 1100, "currency", 1);
      apiTGridFouNF.AddColumn(Resources.col_Total, "NNFTHT", 1100, "currency", 1);
      apiTGridFouNF.AddColumn("DI", "NUMDI", 0);

      apiTGridFouNF.InitColumnList();
    }

    /* ----------Proc valable pour tous les boutons de type cmdDateSet ----------------------- */
    DateTime _curDate = DateTime.MinValue;
    private void CmdDate_Click(object sender, EventArgs e)
    {
      Button btn = sender as Button;
      Calendar1.Tag = btn.Tag;

      string txtDate = "";
      if ((sender as Button).Name == "cmdDate1")
      {
        txtDate = txtDateA0.Text;
        Calendar1.Tag = 0;
      }
      else
      {
        txtDate = txtDateA1.Text;
        Calendar1.Tag = 1;
      }
      DateTime d;
      if (DateTime.TryParse(txtDate, out d))
        _curDate = Calendar1.Value = d;
      else { _curDate = DateTime.MinValue; Calendar1.Value = DateTime.Now; }

      Calendar1.Visible = true;
      Calendar1.ShowCalendar(new MouseEventArgs(MouseButtons.Left, 1, MousePosition.X - this.Location.X, MousePosition.Y - this.Location.Y, 0));
    }
    private void Calendar1_CloseUp(object sender, EventArgs e)
    {
      Calendar1.Visible = false;
      if (_curDate == DateTime.MinValue) return;
      if ((int)Calendar1.Tag == 0) txtDateA0.Text = Calendar1.Value.ToShortDateString();
      else if ((int)Calendar1.Tag == 1) txtDateA1.Text = Calendar1.Value.ToShortDateString();
    }
    private void Calendar1_ValueChanged(object sender, EventArgs e)
    {
      if (Calendar1.Visible) _curDate = Calendar1.Value;
    }


    private void cmdModifier_Click(object sender, EventArgs e)
    {
      DataRow row = apiTGridFouNF.GetFocusedDataRow();
      if (row == null) return;

      new frmDetailNF
      {
        mstrStatutElemFact = "V",
        miNumAction = Convert.ToInt32(row["NACTNUM"]),
        miNumDI = Convert.ToInt32(row["NUMDI"])
      }.ShowDialog();
    }

    private void apiTGridFouNF_ColumnFilterChanged(object sender, EventArgs e)
    {
      CalcTotHT();
    }

    /* OK ---------------------------------------------------------------------------------------------- */
    private void CalcTotHT()
    {
      double dTot = 0;

      for (int i = 0; i < apiTGridFouNF.dgv.RowCount; i++)
      {
        DataRow row = apiTGridFouNF.dgv.GetDataRow(i);
        dTot += Convert.ToDouble(row["NNFTHT"]);
      }

      txtHT.Text = dTot.ToString("C2");
    }

    private void cmdFermer_Click(object sender, System.EventArgs e)
    {
      Dispose();
    }

  }
}