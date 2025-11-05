using DevExpress.XtraGrid.Views.Base;
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
  public partial class frmlisteDIArchiv : Form
  {
    private TooltipGridTPE _tpe;

    private BaseView mModele = null;
    private string msFilter = "";

    public frmlisteDIArchiv()
    {
      InitializeComponent();
    }

    public frmlisteDIArchiv(BaseView pModele, string pFilter) : this()
    {
      mModele = pModele;
      msFilter = pFilter;
    }

    private void frmlisteDIArchiv_Load(object sender, EventArgs e)
    {
      try
      {
        Cursor.Current = Cursors.WaitCursor;

        ModuleMain.Initboutons(this);

        apiTGridListeInter1.dgv.Assign(mModele, false);
        apiTGridListeInter1.dgv.ClearColumnsFilter();

        _tpe = new TooltipGridTPE(apiTGridListeInter1, toolTipController1);

        string sSQL = $"SELECT * FROM api_v_ListeDI3 WHERE (((CETACOD = 'E') AND (CACTSTA = 'F' OR CACTSTA = 'N'))  OR (CETACOD='S')) {msFilter}";
        apiTGridListeInter1.LoadWithQuery(sSQL);
      }
      catch (Exception ex)
      {
        if (ex.Message.Contains("délai d'exécution"))
          MessageBox.Show($"La recherche est trop longue et ne peut pas aboutir.\r\n\r\nPréciser vos critères de recherche.",
                          Resources.Global_Erreur, MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
        else
          MZUtils.displayError(MethodBase.GetCurrentMethod().Name, ex);
      }
      finally
      {
        Cursor.Current = Cursors.Default;
      }
    }

    private void cmdDetail_Click(object sender, EventArgs e)
    {
      try
      {
        DataRow currentRow = apiTGridListeInter1.GetFocusedDataRow();
        if (currentRow == null) return;

        Cursor.Current = Cursors.WaitCursor;

        MozartParams.NumDi = Convert.ToInt32(currentRow["NDINNUM"]);
        MozartParams.NumAction = Convert.ToInt32(currentRow["NACTNUM"]);

        // écran de modification de la demande
        new frmAddAction
        {
          mstrStatutDI = "M",
          miNumClient = Convert.ToInt32(currentRow["NCLINUM"])
        }.ShowDialog();
      }
      catch (Exception ex)
      {
        MZUtils.displayError(MethodBase.GetCurrentMethod().Name, ex);
      }
      finally
      {
        // on revient donc on réinitialise les variables globales
        MozartParams.NumDi = 0;
        MozartParams.NumAction = 0;

        Cursor.Current = Cursors.Default;
      }
    }

    private void CmdCopyPrev_Click(object sender, EventArgs e)
    {
      DataRow currentRow = apiTGridListeInter1.GetFocusedDataRow();
      if (currentRow == null) return;

      new frmCopyPrevOnPeriod(Convert.ToInt32(currentRow["NDINNUM"])).ShowDialog();
    }

    private void apiTGrid1_DoubleClickE(object sender, EventArgs e)
    {
      cmdDetail_Click(null, null);
    }

    private void btnReinitFilter_Click(object sender, EventArgs e)
    {
      apiTGridListeInter1.dgv.ClearColumnsFilter();
    }
  }
}
