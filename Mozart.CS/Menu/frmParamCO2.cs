using MozartCS.Properties;
using MozartLib;
using MozartNet;
using System;
using System.Data;
using System.Reflection;
using System.Windows.Forms;
using MZUtils = MozartControls.Utils;
using MZCtrlResources = MozartControls.Properties.Resources;

namespace MozartCS
{
  public partial class frmParamCO2 : Form
  {
    public int miNumClient;
    public string msNomClient;

    DataTable dt = new DataTable();


    public frmParamCO2() { InitializeComponent(); }

    private void frmListeAtt_Load(object sender, System.EventArgs e)
    {
      try
      {
        Cursor.Current = Cursors.WaitCursor;
        ModuleMain.Initboutons(this);

        InitApigrid();
        apiTGrid1.LoadData(dt, MozartDatabase.cnxMozart, $"select LIBELLE, DDATE, VALEUR FROM TREF_CO2");

      }
      catch (Exception ex)
      {
        MZUtils.displayError(MethodBase.GetCurrentMethod().Name, ex);
      }
      finally { Cursor.Current = Cursors.Default; }
    }


    private void InitApigrid()
    {
      apiTGrid1.AddColumn(MZCtrlResources.col_libelle, "LIBELLE", 3000);
      apiTGrid1.AddColumn(Resources.col_Date_saisi, "DDATE", 1000, "", 2);
      apiTGrid1.AddColumn(Resources.col_Valeur, "VALEUR", 1000, "", 2);

      apiTGrid1.InitColumnList();
      apiTGrid1.GridControl.DataSource = dt;
    }

    private void cmdFermer_Click(object sender, System.EventArgs e)
    {
      Dispose();
    }

  }
}

