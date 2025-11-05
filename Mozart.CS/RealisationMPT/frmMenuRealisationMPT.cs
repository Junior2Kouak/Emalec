using MozartCS.RealisationMPT;
using MozartNet;
using System;
using System.Reflection;
using System.Windows.Forms;
using MZUtils = MozartControls.Utils;


namespace MozartCS
{
  public partial class frmMenuRealisationMPT : Form
  {
    public frmMenuRealisationMPT() { InitializeComponent(); }

    private void frmMenuRealisationMPT_Load(object sender, System.EventArgs e)
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
      finally
      {
        Cursor.Current = Cursors.Default;
      }
    }

    private void cmdStatRRET_Click(object sender, EventArgs e)
    {
      new frmMenuStatRRET().ShowDialog();
    }

    private void cmdStatTech_Click(object sender, EventArgs e)
    {
      new frmChoixStatTech().ShowDialog();
    }

    private void Command1_Click(object sender, EventArgs e)
    {
      new frmTauxConformite("R").ShowDialog();
    }

    private void cmdMaitre_Click(object sender, EventArgs e)
    {
      new frmChoixDateStatTech("C").ShowDialog();
    }

    private void cmdStatVehicules_Click(object sender, EventArgs e)
    {
      new frmStatFrais("T", "KM3", DateTime.Now.AddYears(-1).ToShortDateString(), DateTime.Now.ToShortDateString()).ShowDialog();
    }

    private void cmdKM_Click(object sender, EventArgs e)
    {
      new frmStatKMTech().ShowDialog();
    }

    private void cmdTech_Click(object sender, EventArgs e)
    {
      new frmStatHeureDevisTech() { mTypeStat = "Client" }.ShowDialog();
    }

    private void cmdTechtech_Click(object sender, EventArgs e)
    {
      new frmStatHeureDevisTech() { mTypeStat = "Tech" }.ShowDialog();
    }

    private void cmdCor_Click(object sender, EventArgs e)
    {
      new frmListeCorDevisTech().ShowDialog();
    }

    private void CmdEntretienVeh_Click(object sender, EventArgs e)
    {
      new frmStatFraisEntretienVehicule().ShowDialog();
    }

    private void CmdPlanPrevSign_Click(object sender, EventArgs e)
    {
      new frmListePlanPrevTechApprob().ShowDialog();
    }

    private void cmdHeureDepTech_Click(object sender, EventArgs e)
    {
      new frmStatTechHeuresDepannage().ShowDialog();
    }

    private void cmdChargeCompTech_Click(object sender, EventArgs e)
    {
      new frmChargeTechsParCompetences().ShowDialog();
    }

    private void Command2_Click(object sender, EventArgs e)
    {
      new frmTauxActiviteRegion().ShowDialog();
    }

    private void CmdStatCertEtanch_Click(object sender, EventArgs e)
    {
      new frmMenuCertificatEtancheite().ShowDialog();
    }

    private void BtnMsgTabletTechs_Click(object sender, EventArgs e)
    {
      new frmListeMessagesTabletTechs().ShowDialog();
    }

    private void cmdQuitter_Click(object sender, System.EventArgs e)
    {
      Dispose();
    }

  }
}

