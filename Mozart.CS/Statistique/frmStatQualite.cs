using MozartNet;
using System;
using System.Reflection;
using System.Windows.Forms;
using MZUtils = MozartControls.Utils;


namespace MozartCS
{
  public partial class frmStatQualite : Form
  {
    public frmStatQualite() { InitializeComponent(); }

    private void frmStatQualite_Load(object sender, System.EventArgs e)
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


    private void Command1_Click(object sender, EventArgs e)
    {
      new frmListeEnquetesQualites().ShowDialog();
    }

    private void cmdTel_Click(object sender, EventArgs e)
    {
      Cursor = Cursors.WaitCursor;
      new frmPointageTel().ShowDialog();
      Cursor = Cursors.Default;
    }

    private void cmdWeb_Click(object sender, EventArgs e)
    {
      Cursor = Cursors.WaitCursor;
      new frmStatAppreciation().ShowDialog();
      Cursor = Cursors.Default;
    }

    private void cmdDep_Click(object sender, EventArgs e)
    {
      Cursor = Cursors.WaitCursor;
      new frmStatQualTauxConf() { mstrStat = "NewDevis" }.Show();
      Cursor = Cursors.Default;
    }

    private void cmdMaitre_Click(object sender, EventArgs e)
    {
      Cursor = Cursors.WaitCursor;
      new frmStatQualTauxConf() { mstrStat = "Depannages" }.ShowDialog();
      Cursor = Cursors.Default;
    }


    private void cmdStatEmalec_Click(object sender, EventArgs e)
    {
      Cursor = Cursors.WaitCursor;
      new frmListeReclamation().ShowDialog();
      Cursor = Cursors.Default;
    }

    private void CmdStatPR_Click(object sender, EventArgs e)
    {
      Cursor = Cursors.WaitCursor;
      new frmStatDelaiPR().ShowDialog();
      Cursor = Cursors.Default;
    }

    private void cmdStatsCompta_Click(object sender, EventArgs e)
    {
      Cursor = Cursors.WaitCursor;
      new frmStatsCompta().ShowDialog();
      Cursor = Cursors.Default;
    }

    private void cmdStatTech_Click(object sender, EventArgs e)
    {
      Cursor = Cursors.WaitCursor;
      new frmStatSynthese().ShowDialog();
      Cursor = Cursors.Default;
    }


    private void cmdDelai_Click(object sender, EventArgs e)
    {
      Cursor = Cursors.WaitCursor;
      new frmStatDelais().ShowDialog();
      Cursor = Cursors.Default;
    }


    private void CmdStatASTR_Click(object sender, EventArgs e)
    {
      Cursor = Cursors.WaitCursor;
      new frmStatAstr().ShowDialog();
      Cursor = Cursors.Default;
    }

    private void cmdStatActNonConforme_Click(object sender, EventArgs e)
    {
      Cursor = Cursors.WaitCursor;
      new frmStatQualActNonConf().ShowDialog();
      Cursor = Cursors.Default;
    }

    private void cmdChaff_Click(object sender, EventArgs e)
    {
      new frmStatNonConformite() { msTypeStat = "Chaff" }.ShowDialog();
    }

    private void cmdCli_Click(object sender, EventArgs e)
    {
      new frmStatNonConformite() { msTypeStat = "Client" }.ShowDialog();
    }

    private void CmdFicheSituDang_Click(object sender, EventArgs e)
    {
      new frmFicheSituDanger_Liste().ShowDialog();
    }

    private void cmdMsg_Click(object sender, EventArgs e)
    {
      new frmSuiviLectureMessages().ShowDialog();
    }

    private void cmdGESC_Click(object sender, EventArgs e)
    {
      new frmGESClient().ShowDialog();
    }

    private void cmdGESE_Click(object sender, EventArgs e)
    {
      new frmGESemalec().ShowDialog();
    }

    private void cmdQuitter_Click(object sender, System.EventArgs e)
    {
      Dispose();
    }

    private void apiButton1_Click(object sender, EventArgs e)
    {
      new frmGESClients().ShowDialog();
    }

    private void apiButton2_Click(object sender, EventArgs e)
    {
      new frmGESGraph().ShowDialog();
    }
  }
}

