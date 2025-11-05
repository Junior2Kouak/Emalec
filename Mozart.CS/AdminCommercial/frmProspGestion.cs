using MozartCS.Properties;
using MozartLib;
using MozartNet;
using MozartUC;
using System;
using System.Data;
using System.Data.SqlClient;
using System.Reflection;
using System.Windows.Forms;
using MZCtrlResources = MozartControls.Properties.Resources;

namespace MozartCS
{
  public partial class frmProspGestion : Form
  {
    private bool bpremierefois = false;
    private DataTable dt = new DataTable();
    private DataSet ds = new DataSet();

    public frmProspGestion()
    {
      InitializeComponent();
    }

    private void frmProspGestion_Load(object sender, System.EventArgs e)
    {
      try
      {
        ModuleMain.Initboutons(this);

        txtDateA0.Text = DateTime.Now.AddMonths(-1).ToShortDateString();
        txtDateA1.Text = DateTime.Now.ToShortDateString();
        bpremierefois = true;

        apiTGrid.LoadData(dt, MozartDatabase.cnxMozart, $"api_sp_StatistiqueCommercial '{txtDateA0.Text}','{txtDateA1.Text}'");
        apiTGrid.GridControl.DataSource = dt;

        if (dt.Rows.Count == 0)
        {
          Cursor.Current = Cursors.Default;
          MessageBox.Show(Resources.msg_no_data, Program.AppTitle, MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
          return;
        }

        InitGrid();
        initThisGrid(apiTGrid1);
        initThisGrid(apiTGrid2);
        initThisGrid(apiTGrid3);
        initThisGrid(apiTGrid4);
        initThisGrid(apiTGrid5);
      }
      catch (Exception ex)
      {
        Utils.ShowException(ex, MethodBase.GetCurrentMethod().Name, ex.StackTrace);
      }
      finally
      {
        Cursor.Current = Cursors.Default;
      }
    }
  
    private void cmdValider_Click(object sender, EventArgs e)
    {
      try
      {
        // test des dates
        if (txtDateA0.Text == "")
        {
          MessageBox.Show(Resources.msg_must_select_start_date, Program.AppTitle, MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
          return;
        }

        if (txtDateA1.Text == "")
        {
          MessageBox.Show(Resources.msg_must_select_end_date, Program.AppTitle, MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
          return;
        }

        Cursor.Current = Cursors.WaitCursor;

        apiTGrid.GridControl.DataSource = null;
        apiTGrid.Refresh();

        apiTGrid.LoadData(dt, MozartDatabase.cnxMozart, $"api_sp_StatistiqueCommercial '{txtDateA0.Text}','{txtDateA1.Text}'");
        apiTGrid.GridControl.DataSource = dt;
      }
      catch (Exception ex)
      {
        Utils.ShowException(ex, MethodBase.GetCurrentMethod().Name, ex.StackTrace);
      }
      finally
      {
        Cursor.Current = Cursors.Default;
      }
    }

    private void InitGrid()
    {
      apiTGrid.AddColumn(MZCtrlResources.Commercial, "VPERNOM", 2200);
      apiTGrid.AddColumn(Resources.col_Nouveaux_contacts, "C", 2000, "", 2);
      apiTGrid.AddColumn(Resources.col_Relances, "R", 1400, "", 2);
      apiTGrid.AddColumn(Resources.col_RDV_realises, "D", 1600, "", 2);
      apiTGrid.AddColumn(Resources.col_RDV_pris, "RDVPRIS", 1400, "", 2);
      apiTGrid.AddColumn(Resources.col_Offre, "O", 1400, "", 2);
      apiTGrid.AddColumn("NPERNUM", "NPERNUM", 0);

      apiTGrid.InitColumnList();
    }

    private void initThisGrid(apiTGrid pGrid)
    {
      pGrid.AddColumn(MZCtrlResources.col_Client, "VPROSNOM", 2200);
      pGrid.AddColumn(Resources.col_Date, "D", 1000, "dd/mm/yy");
      pGrid.InitColumnList();
    }

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

    private void apiTGrid_SelectionChanged(object sender, DevExpress.Data.SelectionChangedEventArgs e)
    {
      if (bpremierefois)
      {
        bpremierefois = false;
        return;
      }

      Cursor.Current = Cursors.WaitCursor;
      FillDataSet();

      apiTGrid1.GridControl.DataSource = ds.Tables[0];
      apiTGrid2.GridControl.DataSource = ds.Tables[1];
      apiTGrid3.GridControl.DataSource = ds.Tables[2];
      apiTGrid4.GridControl.DataSource = ds.Tables[3];
      apiTGrid5.GridControl.DataSource = ds.Tables[4];

      Cursor.Current = Cursors.Default;
    }

    private void FillDataSet()
    {
      DataRow row = apiTGrid.GetFocusedDataRow();
      if (null == row)
        return;
      using (SqlCommand cmd = new SqlCommand($"api_sp_StatistiqueCommercialCont {row["NPERNUM"]}, '{txtDateA0.Text}','{txtDateA1.Text}'", MozartDatabase.cnxMozart))
      {
        using (SqlDataAdapter da = new SqlDataAdapter(cmd))
        {
          ds.Clear();
          da.Fill(ds);
        }
      }
    }
  }
}
