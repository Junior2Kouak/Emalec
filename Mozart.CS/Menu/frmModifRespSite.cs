using MozartNet;
using System;
using System.Collections;
using System.Reflection;
using System.Windows.Forms;
using MZUtils = MozartControls.Utils;

namespace MozartCS
{
  public partial class frmModifRespSite : Form
  {
    private int miNumClient;
    private int miNumRespMaint;
    private ArrayList mSiteIDs;

    public frmModifRespSite(int pNumClient, ArrayList pSiteIDs, int pNumRespMaint)
    {
      InitializeComponent();

      miNumClient = pNumClient;
      miNumRespMaint = pNumRespMaint;
      mSiteIDs = pSiteIDs;
    }

    private void frmModifRespSite_Load(object sender, EventArgs e)
    {
      try
      {
        Cursor.Current = Cursors.WaitCursor;
        ModuleMain.Initboutons(this);

        ModuleData.RemplirCombo(cboRespMaint, $"select NCCLNUM, VCCLNOM from TCCL where TCCL.NCLINUM = {miNumClient} order by VCCLNOM");
        cboRespMaint.ValueMember = "NCCLNUM";
        cboRespMaint.DisplayMember = "VCCLNOM";

        cboRespMaint.SetItemData(miNumRespMaint.ToString());
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

    private void cmdAppliquer_Click(object sender, EventArgs e)
    {
      string lTmpStr;

      Cursor.Current = Cursors.WaitCursor;

      int lNewIdRespMaint = cboRespMaint.GetItemData();
      if (lNewIdRespMaint == 0)
      {
        // Dans 1 1er temps, on ne peut pas enlever le resp maint
        return;
      }
      txtCRErreur.Text = "";

      foreach (int lId in mSiteIDs)
      {
        try
        {
          lTmpStr = $"UPDATE TSIT SET NSITRESPMAINT = {lNewIdRespMaint} WHERE NSITNUM = {lId}";
          ModuleData.CnxExecute(lTmpStr);
        }
        catch (Exception)
        {
          txtCRErreur.Text += Environment.NewLine + lId.ToString();
        }
      }

      Cursor.Current = Cursors.Default;
    }
  }
}
