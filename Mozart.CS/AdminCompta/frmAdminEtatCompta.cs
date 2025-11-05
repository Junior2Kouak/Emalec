using MozartCS.AdminCompta;
using MozartCS.Properties;
using MozartNet;
using MozartLib;
using System;
using System.Reflection;
using System.Windows.Forms;
using MZUtils = MozartControls.Utils;

namespace MozartCS
{
  public partial class frmAdminEtatCompta : Form
  {
    public frmAdminEtatCompta()
    {
      InitializeComponent();
    }

    private void frmAdminEtatCompta_Load(object sender, System.EventArgs e)
    {
      try
      {
        ModuleMain.Initboutons(this);
        cmdTech.Text = cmdTech.Text.Replace("$ste", MozartParams.NomSociete);

      }
      catch (Exception ex)
      {
        MZUtils.displayError(MethodBase.GetCurrentMethod().Name, ex);
      }
    }

    private void CmdGestODBilan_Click(object sender, EventArgs e)
    {
      Cursor = Cursors.WaitCursor;
      new frmModifODBilanAnnuel().ShowDialog();
      Cursor = Cursors.Default;
    }

    private void CmdODBilan_Click(object sender, EventArgs e)
    {
      Cursor = Cursors.WaitCursor;
      new frmTransfertODBilan().ShowDialog();
      Cursor = Cursors.Default;
    }

    private void cmd1_Click(object sender, EventArgs e)
    {
      Cursor = Cursors.WaitCursor;
      frmStatComptaCharge f = new frmStatComptaCharge
      {
        mstype = "ST"
      };
      f.ShowDialog();
      Cursor = Cursors.Default;
    }

    private void cmd2_Click(object sender, EventArgs e)
    {
      Cursor = Cursors.WaitCursor;
      frmStatComptaCharge f = new frmStatComptaCharge
      {
        mstype = "FO"
      };
      f.ShowDialog();
      Cursor = Cursors.Default;
    }

    private void cmdEncoursCSP_Click(object sender, EventArgs e)
    {
      Cursor = Cursors.WaitCursor;
      frmStatComptaCSPChaff f = new frmStatComptaCSPChaff
      {
        msType = "STT"
      };
      f.ShowDialog();
      Cursor = Cursors.Default;
    }

    private void Command1_Click(object sender, EventArgs e)
    {
      Cursor = Cursors.WaitCursor;
      new frmStatComptaNonExec().ShowDialog();
      Cursor = Cursors.Default;
    }

    private void CmdCSP_Click(object sender, EventArgs e)
    {
      Cursor = Cursors.WaitCursor;
      frmStatComptaCSPChaff f = new frmStatComptaCSPChaff
      {
        msType = "CSP"
      };
      f.ShowDialog();
      Cursor = Cursors.Default;
    }

    private void cmdAssist_Click(object sender, EventArgs e)
    {
      Cursor = Cursors.WaitCursor;
      new frmStatCompta("STT").ShowDialog();
      Cursor = Cursors.Default;
    }

    private void cmdStock_Click(object sender, EventArgs e)
    {
      Cursor = Cursors.WaitCursor;
      new frmValorisationStock().ShowDialog();
      Cursor = Cursors.Default;
    }

    private void cmdTech_Click(object sender, EventArgs e)
    {
      Cursor = Cursors.WaitCursor;
      new frmStatCompta("EMALEC").ShowDialog();
      Cursor = Cursors.Default;
    }

    private void cmdSynt_Click(object sender, EventArgs e)
    {
      Cursor = Cursors.WaitCursor;
      new frmStatComptaSynt().ShowDialog();
      Cursor = Cursors.Default;
    }

    private void CmdFacEtablir_Click(object sender, EventArgs e)
    {
      Cursor = Cursors.WaitCursor;
      new frmModifAnaFactureEtabli().ShowDialog();
      Cursor = Cursors.Default;
    }

    private void CmdSaisieEncours_Click(object sender, EventArgs e)
    {
      Cursor = Cursors.WaitCursor;
      new frmSaisieEncoursManuel().ShowDialog();
      Cursor = Cursors.Default;
    }

    private void CmdTableauAnalytique_Click(object sender, EventArgs e)
    {
      Cursor = Cursors.WaitCursor;
      new FrmTransTabAnalytique().ShowDialog();
      Cursor = Cursors.Default;
    }

    private void BtnEnCoursSTTDesact_Click(object sender, EventArgs e)
    {
      Cursor = Cursors.WaitCursor;
      new frmStatEncoursDesactive(1).ShowDialog();
      Cursor = Cursors.Default;
    }

    private void BtnEnCoursFODesact_Click(object sender, EventArgs e)
    {
      Cursor = Cursors.WaitCursor;
      new frmStatEncoursDesactive(2).ShowDialog();
      Cursor = Cursors.Default;
    }

    private void cmdFAEPCA_Click(object sender, EventArgs e)
    {
      Cursor = Cursors.WaitCursor;
      new frmStatComptaFAEPCA(DateTime.Now.ToString("dd/MM/yyyy")).ShowDialog();
      Cursor = Cursors.Default;
    }

    private void BtnFactSTTConstatAV_Click(object sender, EventArgs e)
    {
      Cursor = Cursors.WaitCursor;
      frmStatComptaFactConstatAv ofrmStatComptaFactConstatAv = new frmStatComptaFactConstatAv(0);
      ofrmStatComptaFactConstatAv.ShowDialog();
      Cursor = Cursors.Default;
    }

    private void BtnFactFOConstatAV_Click(object sender, EventArgs e)
    {
      Cursor = Cursors.WaitCursor;
      frmStatComptaFactConstatAv ofrmStatComptaFactConstatAv = new frmStatComptaFactConstatAv(1);
      ofrmStatComptaFactConstatAv.ShowDialog();
      Cursor = Cursors.Default;
    }

    private void BtnBudgetGestion_Click(object sender, EventArgs e)
    {
      Cursor = Cursors.WaitCursor;
      new frmBudget_Gestion().ShowDialog();
      Cursor = Cursors.Default;
    }

		private void apiButton1_Click(object sender, EventArgs e)
		{
      Cursor = Cursors.WaitCursor;
      new FrmSynthComptaV2().ShowDialog();
      Cursor = Cursors.Default;
    }
  }
}

