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
  public partial class frmListeDiMailsArch : Form
  {

    DataTable dt = new DataTable();

    public frmListeDiMailsArch()
    {
      InitializeComponent();
    }


    private void frmListeDiMailsArch_Load(object sender, System.EventArgs e)
    {
      try
      {
        Cursor.Current = Cursors.WaitCursor;
        ModuleMain.Initboutons(this);
        string sSQL = "SELECT TDIMAIL.NDIMNUM, TDIMAIL.VDIMFROM,TDIMAIL.VDIMSUJET,TDIMAIL.VDIMTEXT,TDIMAIL.DDIMCRE,TDIMAIL.DDIMTRAITE, TDIMAIL.NDINNUM, TDIMAIL.VDIMPJ, TDIMAIL.BDIMLOCK, " +
                      " VPERNOM FROM TDIMAIL LEFT OUTER JOIN TPER WITH (NOLOCK) ON  NPERNUM = NQUITRAITE " +
                     " where DDIMCRE > (DATEADD(MONTH,-5,getdate())) AND DDIMTRAITE is not null AND TDIMAIL.VSOCIETE = App_Name() order by NDIMNUM desc";
        apiTGrid1.LoadData(dt, MozartDatabase.cnxMozart, sSQL);
        apiTGrid1.GridControl.DataSource = dt;
        InitApigrid();
      }
      catch (Exception ex)
      {
        MZUtils.displayError(MethodBase.GetCurrentMethod().Name, ex);

      }
      finally { Cursor.Current = Cursors.Default; }
    }

    private void InitApigrid()
    {
      apiTGrid1.AddColumn(Resources.col_Num, "NDIMNUM", 0);
      apiTGrid1.AddColumn(Resources.col_Emetteur, "VDIMFROM", 2000, "", 0, true);                         // <= AddCellTip
      apiTGrid1.AddColumn(Resources.col_Sujet, "VDIMSUJET", 2500, "", 0, true);                         // <= AddCellTip
      apiTGrid1.AddColumn(Resources.col_Texte, "VDIMTEXT", 4200, "", 0, true);                         // <= AddCellTip
      apiTGrid1.AddColumn(Resources.col_DateArrivee, "DDIMCRE", 1200, "Date");
      apiTGrid1.AddColumn(Resources.col_DateTrait, "DDIMTRAITE", 1200, "Date");
      apiTGrid1.AddColumn(Resources.col_TraiteePar, "VPERNOM", 1500);
      apiTGrid1.AddColumn(Resources.col_DI, "NDINNUM", 1000);
      apiTGrid1.AddColumn(Resources.col_Lock, "BDIMLOCK", 0);
      apiTGrid1.AddColumn(Resources.col_PJ, "VDIMPJ", 2000);

      apiTGrid1.InitColumnList();
    }

    private void cmdRestaurer_Click(object sender, EventArgs e)
    {
      DataRow row = apiTGrid1.GetFocusedDataRow();
      if (null == row) return;

      if (MessageBox.Show(Resources.msg_ConfirmRestaurerDemande, Program.AppTitle, MessageBoxButtons.YesNo) != DialogResult.Yes) return;

      ModuleData.ExecuteNonQuery($"UPDATE TDIMAIL set DDIMTRAITE = Null, BDIMLOCK = 0 where NDIMNUM = {Convert.ToInt32(row["NDIMNUM"])}");

      Cursor.Current = Cursors.WaitCursor;
      apiTGrid1.Requery(dt, MozartDatabase.cnxMozart);
      Cursor.Current = Cursors.Default;
    }


    private void cmdQuitter_Click(object sender, EventArgs e)
    {
      Dispose();
    }
  }
}

