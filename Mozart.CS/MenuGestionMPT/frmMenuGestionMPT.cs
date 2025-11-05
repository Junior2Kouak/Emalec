using MozartCS.MenuGestionMPT;
using MozartNet;
using System;
using System.Reflection;
using System.Windows.Forms;
using MZUtils = MozartControls.Utils;

namespace MozartCS
{
  public partial class frmMenuGestionMPT : Form
  {
    public frmMenuGestionMPT()
    {
      InitializeComponent();
    }

    private void frmMenuGestionMPT_Load(object sender, System.EventArgs e)
    {
      try
      {
        ModuleMain.Initboutons(this);
      }
      catch (Exception ex)
      {
        MZUtils.displayError(MethodBase.GetCurrentMethod().Name, ex);
      }
    }

    private void cmdQuitter_Click(object sender, System.EventArgs e)
    {
      Close();
    }

    private void cmdRavel_Click(object sender, EventArgs e)
    {
      Cursor = Cursors.WaitCursor;
      new frmStatRavel
      {
        sType = "CHAFF"
      }.ShowDialog();
      Cursor = Cursors.Default;
    }

    private void cmdSTT_Click(object sender, EventArgs e)
    {
      Cursor = Cursors.WaitCursor;
      new frmStatRavel
      {
        sType = "STT"
      }.ShowDialog();
      Cursor = Cursors.Default;
    }

    private void cmdAvoir_Click(object sender, EventArgs e)
    {
      Cursor = Cursors.WaitCursor;
      new frmStatRavel
      {
        sType = "AVOIR"
      }.ShowDialog();
      Cursor = Cursors.Default;
    }

    private void cmdDepPer_Click(object sender, EventArgs e)
    {
      new frmChoixdateDep().ShowDialog();
    }

    private void cmdDepJour_Click(object sender, EventArgs e)
    {
      Cursor = Cursors.WaitCursor;
      new frmStatDepHeureJour
      {
        mstrTypeStat = "Jour"
      }.ShowDialog();
      Cursor = Cursors.Default;
    }

    private void cmdDepHeure_Click(object sender, EventArgs e)
    {
      Cursor = Cursors.WaitCursor;
      new frmStatDepHeureJour
      {
        mstrTypeStat = "Heure"
      }.ShowDialog();
      Cursor = Cursors.Default;
    }

    private void cmdDiHeure_Click(object sender, EventArgs e)
    {
      Cursor = Cursors.WaitCursor;
      new frmStatActHeure().ShowDialog();
      Cursor = Cursors.Default;
    }

    private void CmdStatSruvTxST_Click(object sender, EventArgs e)
    {
      Cursor = Cursors.WaitCursor;
      new frmStatSurvTxST().ShowDialog();
      Cursor = Cursors.Default;
    }

    private void cmdStatNbAction_Click(object sender, EventArgs e)
    {
      Cursor = Cursors.WaitCursor;
      new frmStatDi
      {
        sTypeStat = "NbAction"
      }.ShowDialog();
      Cursor = Cursors.Default;
    }

    private void cmdStatNbDep_Click(object sender, EventArgs e)
    {
      Cursor = Cursors.WaitCursor;
      new frmStatDi
      {
        sTypeStat = "NbDep"
      }.ShowDialog();
      Cursor = Cursors.Default;
    }

    private void cmdStatNbDevis_Click(object sender, EventArgs e)
    {
      Cursor = Cursors.WaitCursor;
      new frmStatDi
      {
        sTypeStat = "NbDevis"
      }.ShowDialog();
      Cursor = Cursors.Default;
    }

    private void cmdListeDI_Click(object sender, EventArgs e)
    {
      Cursor = Cursors.WaitCursor;
      new frmListeMargeDi().ShowDialog();
      Cursor = Cursors.Default;
    }

    private void cmdDev_Click(object sender, EventArgs e)
    {
      new frmTauxConformite("D").ShowDialog();
    }

    private void cmdDevDelaiPrepa_Click(object sender, EventArgs e)
    {
      new frmTauxConformite("P").ShowDialog();
    }

    private void Command1_Click(object sender, EventArgs e)
    {
      new frmTauxConformite("G").ShowDialog();
    }

    private void cmdMargeCan_Click(object sender, EventArgs e)
    {
      new frmStatMargeChaff("CAN").ShowDialog();
    }

    private void cmdMargeChaff_Click(object sender, EventArgs e)
    {
      new frmStatMargeChaffMensuel().ShowDialog();
    }

    private void cmdMargeCli_Click(object sender, EventArgs e)
    {
      new frmStatMargeChaff("CLI").ShowDialog();
    }

    private void cmdStatPrest_Click(object sender, EventArgs e)
    {
      new frmStatPrestation
      {
        sType = "P"
      };
    }

    private void CmdDevis_Click(object sender, EventArgs e)
    {
      Cursor = Cursors.WaitCursor;
      new frmTransRetourDevis().ShowDialog();
      Cursor = Cursors.Default;
    }

    private void cmdStatTec_Click(object sender, EventArgs e)
    {
      new frmStatPrestation
      {
        sType = "T"
      }.ShowDialog();
    }

    private void cmdStatProd_Click(object sender, EventArgs e)
    {
      new frmStatProductionAssistants().ShowDialog();
    }

    private void cmdCmd_Click(object sender, EventArgs e)
    {
      Cursor = Cursors.WaitCursor;
      new frmStatDelais
      {
        mstrStatut = "ParClient"
      }.ShowDialog();
      Cursor = Cursors.Default;
    }

    private void cmdStatClient_Click(object sender, EventArgs e)
    {
      new frmChoixDate().ShowDialog();
    }

    private void cmdFouCli_Click(object sender, EventArgs e)
    {
      new frmStatFourniture
      {
        sTypeStat = "Client"
      }.ShowDialog();
    }

    private void cmdFouChaff_Click(object sender, EventArgs e)
    {
      new frmStatFourniture
      {
        sTypeStat = "Chaff"
      }.ShowDialog();
    }

    private void cmdd_Click(object sender, EventArgs e)
    {
      Cursor = Cursors.WaitCursor;
      new frmStatDelaiDI().ShowDialog();
      Cursor = Cursors.Default;
    }

    private void cmdDep_Click(object sender, EventArgs e)
    {
      Cursor = Cursors.WaitCursor;
      new frmStatDepNonReso().ShowDialog();
      Cursor = Cursors.Default;
    }

    private void cmdDevNbTransf_Click(object sender, EventArgs e)
    {
      new frmNbTransfDevis().ShowDialog();
    }

    private void CmdStatNbrObs_Click(object sender, EventArgs e)
    {
      new frmStatNbObsChaff().ShowDialog();
    }

    private void cmdDevAttChaff_Click(object sender, EventArgs e)
    {
      new frmDevisAttenteChaff().ShowDialog();
    }

    private void cmdDevisAFaire_Click(object sender, EventArgs e)
    {
      new frmDevisAFaire().ShowDialog();
    }

    private void cmdDevisParCreateur_Click(object sender, EventArgs e)
    {
      new frmDevisNombreParCreateur().ShowDialog();
    }

    private void cmdDelaiFactSTT_Click(object sender, EventArgs e)
    {
      new frmRavel_DelaiDeFacturationSTT().ShowDialog();
    }

    private void cmdRepartCAInter_Click(object sender, EventArgs e)
    {
      new frmRepartition_FR_ETR().ShowDialog();
    }

    private void cmdMargeAnalyse_Click(object sender, EventArgs e)
    {
      new frmStatMargeAnalyse().ShowDialog();
    }
    private void cmdNotationFO_Click(object sender, EventArgs e)
    {
      new frmNotationFO().ShowDialog();
    }

    private void CmdTauxdevTransf_Click(object sender, EventArgs e)
    {
      new frmNbTransDevisParChaff().ShowDialog();
    }

    private void CmdAndR_AND_D_Click(object sender, EventArgs e)
    {
      new frmListeActionsR_AND_D().ShowDialog();
    }
    private void CmdRevPrixClient_Click(object sender, EventArgs e)
    {
      new frmGestionRevisionPrixCFoClients().ShowDialog();
    }
    private void BtnStatDepDelaiResol_Click(object sender, EventArgs e)
    {
      new frmStatDepDelaiResolution().ShowDialog();
    }

    private void cmdKPI_Click(object sender, EventArgs e)
    {
      Cursor = Cursors.WaitCursor;
      new frmKPI().ShowDialog();
      Cursor = Cursors.Default;
    }
  }
}