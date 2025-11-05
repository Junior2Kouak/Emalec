using MozartNet;
using System;
using System.Reflection;
using System.Windows.Forms;
using MZUtils = MozartControls.Utils;


namespace MozartCS
{
  public partial class frmMenuRH : Form
  {
    public frmMenuRH() { InitializeComponent(); }

    private void frmMenuRH_Load(object sender, System.EventArgs e)
    {
      try
      {
        Cursor.Current = Cursors.WaitCursor;
        ModuleMain.Initboutons(this);

      }
      catch (Exception ex)
      {
        MZUtils.displayError(MethodBase.GetCurrentMethod().Name, ex);
      }
      finally { Cursor.Current = Cursors.Default; }
    }


    private void cmdStatTel_Click(object sender, EventArgs e)
    {
      Cursor = Cursors.WaitCursor;
      new frmStatQualTauxConf()
      {
        mstrStat = "CoutFor"
      }.ShowDialog();
      Cursor = Cursors.Default;
    }

    private void cmdComSecu_Click(object sender, EventArgs e)
    {
      Cursor = Cursors.WaitCursor;
      new frmPyramideAges().ShowDialog();
      Cursor = Cursors.Default;
    }

    private void cmdStatFourn_Click(object sender, EventArgs e)
    {
      Cursor = Cursors.WaitCursor;
      new frmStatTurnOver().ShowDialog();
      Cursor = Cursors.Default;
    }

    private void cmdTpsTravail_Click(object sender, EventArgs e)
    {
      new frmStatRHTempsTravail().ShowDialog();
    }

    private void cmdVersement_Click(object sender, EventArgs e)
    {
      new frmCalculVersementTransport().ShowDialog();
    }

    private void CmdStatChargeStruct_Click(object sender, EventArgs e)
    {
      new frmStatChargeStructure().ShowDialog();
    }

    private void cmdAnciennetePersonnel_Click(object sender, EventArgs e)
    {
      Cursor = Cursors.WaitCursor;
      new frmStatAnciennetePersonnel().ShowDialog();
      Cursor = Cursors.Default;
    }

    private void BtnSuiviTpsTrav_Click(object sender, EventArgs e)
    {
      new frmSuiviTempsTravailTechDetail().ShowDialog();
    }

    private void BtnTpsRecupTech_Click(object sender, EventArgs e)
    {

      new frmSuiviTempsRecupTech_Gest().ShowDialog();
    }

    private void cmdQuitter_Click(object sender, System.EventArgs e)
    {
      Dispose();
    }

  }
}

