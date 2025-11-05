using MozartLib;
using System;
using System.Data.SqlClient;
using System.Globalization;
using System.Reflection;
using System.Windows.Forms;
using MZUtils = MozartControls.Utils;

namespace MozartCS
{
  public partial class frmDetailQui : Form
  {
    private int mNPRONUM;

    public frmDetailQui(int pNProNum)
    {
      InitializeComponent();

      mNPRONUM = pNProNum;
    }

    private void frmDetailQui_Load(object sender, EventArgs e)
    {
      try
      {
        int val = 0;
        using (SqlDataReader dr = MozartDatabase.ExecuteReader($"EXEC api_sp_DetailQui2 {mNPRONUM}"))
        {
          if (dr.Read())
          {
            Label1.Text += $" {dr["VPROSNOM"]}";
            txtConnu.Text = dr["CONNU"]?.ToString() ?? "";
            txtDCreCli.Text = dr["DDATCLICRE"]?.ToString() ?? "";
            txtNomChaff.Text = dr["VNOMCHAFF"]?.ToString() ?? "";
            txtFirstDI.Text = dr["DDATFIRSTDI"]?.ToString() ?? "";
            val = dr["ICHIFFAFF"] == DBNull.Value ? 0 : Convert.ToInt32(dr["ICHIFFAFF"]);
            txtChiffreAff.Text = val.ToString("C", CultureInfo.CurrentCulture);
            txtDProsCree.Text = dr["DDATPROSCRE"]?.ToString() ?? "";
            txtNomCommer.Text = dr["NOMCOMMER"]?.ToString() ?? "";
            txtDFirstCont.Text = dr["DDATFIRSTCONT"]?.ToString() ?? "";
            txtDDerCont.Text = dr["DDATLASTCONT"]?.ToString() ?? "";
          }
          dr.Close();
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
  }
}
