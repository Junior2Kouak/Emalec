using MozartCS.Properties;
using MozartLib;
using MozartNet;
using System;
using System.Data;
using System.Reflection;
using System.Windows.Forms;

namespace MozartCS
{
  public partial class frmStatAnaCSTByCte : Form
  {
    public int miNPERNUM;
    public string msVPERNOM = "";

    DataTable dt = new DataTable();

    public frmStatAnaCSTByCte()
    {
      InitializeComponent();
    }

    private void frmStatAnaCSTByCte_Load(object sender, System.EventArgs e)
    {
      string sSQL;
      try
      {
        Cursor.Current = Cursors.WaitCursor;
        ModuleMain.Initboutons(this);
        Label1.Text += " " + msVPERNOM;
        sSQL = $"exec api_sp_StatDetailCoutSalarie {miNPERNUM}";
        apiGridListe.LoadData(dt, MozartDatabase.cnxMozart, sSQL);
        apiGridListe.GridControl.DataSource = dt;
        InitApigridListe();
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

    private void InitApigridListe()
    {
      try
      {
        apiGridListe.AddColumn(Resources.col_Lbl, "vlib", 300);
        apiGridListe.AddColumn(Resources.col_Montant, "cout", 110, "", 1);

        apiGridListe.InitColumnList();
      }
      catch (Exception ex)
      {
        Utils.ShowException(ex, MethodBase.GetCurrentMethod().Name, ex.StackTrace);
      }
    }

    private void cmdQuitter_Click(object sender, EventArgs e)
    {
      Dispose();
    }
  }
}
