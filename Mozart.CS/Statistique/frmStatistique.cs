using System;
using System.IO;
using System.Data;
using System.Reflection;
using System.Windows.Forms;
using System.Data.SqlClient;
using MozartNet;
using MozartCS.Properties;
using MozartLib;
using MozartUC;
using MZUtils = MozartControls.Utils;

namespace MozartCS
{
  public partial class frmStatistique : Form
  {
    public frmStatistique() {InitializeComponent();}

    private void frmStatistique_Load(object sender, System.EventArgs e)
    {
      try
      {
        Cursor.Current = Cursors.WaitCursor;
        ModuleMain.Initboutons(this);

        CmdIndicPoste.Visible = false;
      }
      catch (Exception ex) {
        MZUtils.displayError(MethodBase.GetCurrentMethod().Name, ex);
	  }
      finally { Cursor.Current = Cursors.Default; }
    }


    private void CmdIndicGroupe_Click(object sender, EventArgs e)
    {
      new frmMenuReporting_Indic_Grp().ShowDialog();
    }

    private void cmdEI_Click(object sender, EventArgs e)
    {
      new frmMenuStatEI().ShowDialog();
    }

    private void Command1_Click(object sender, EventArgs e)
    {
      new frmStatEnergie().ShowDialog();
    }

    private void cmdMagasin_Click(object sender, EventArgs e)
    {
      new frmMenuMagasin().ShowDialog();
    }

    private void cmdQualite_Click(object sender, EventArgs e)
    {
      new frmStatQualite().ShowDialog();
    }

    private void cmdCommercial_Click(object sender, EventArgs e)
    {
      new frmMenuCommercial().ShowDialog();
    }

    private void cmdRH_Click(object sender, EventArgs e)
    {
      new frmMenuRH().ShowDialog();
    }

    private void cmdreaMPT_Click(object sender, EventArgs e)
    {
      new frmMenuRealisationMPT().ShowDialog();
    }

    private void cmdFacturation_Click(object sender, EventArgs e)
    {
      new frmMenuFacturation().ShowDialog();
    }

    private void cmdGestionMPT_Click(object sender, EventArgs e)
    {
      new frmMenuGestionMPT().ShowDialog();
    }

    private void cmdStatEmalec_Click(object sender, EventArgs e)
    {
      new frmStatEMALEC().ShowDialog();
    }

    private void cmdStatFourn_Click(object sender, EventArgs e)
    {
      new frmMenuAchat().ShowDialog();
    }

    private void CmdComptaStructure_Click(object sender, EventArgs e)
    {
      new FrmStatComptaStructure().ShowDialog();
    }

    private void CmdGestTrav_Click(object sender, EventArgs e)
    {
      Cursor.Current = Cursors.WaitCursor;
      new frmMenuReportingGestTrav().ShowDialog();
      Cursor.Current = Cursors.Default;
    }

    private void BtnPlanning_Click(object sender, EventArgs e)
    {
      new frmMenuStatPlanning().ShowDialog();
    }

    private void cmdQuitter_Click(object sender, System.EventArgs e)
    {
      Dispose();
    }

  }
}

