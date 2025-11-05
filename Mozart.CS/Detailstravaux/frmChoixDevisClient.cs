using MozartLib;
using MozartNet;
using System;
using System.Reflection;
using System.Windows.Forms;
using MZUtils = MozartControls.Utils;


namespace MozartCS
{
  public partial class frmChoixDevisClient : Form
  {

    bool bMsgNumCdeDIUnique;

    public frmChoixDevisClient()
    {
      InitializeComponent();
    }

    private void frmChoixDevisClient_Load(object sender, System.EventArgs e)
    {
      try
      {
        Cursor.Current = Cursors.WaitCursor;
        ModuleMain.Initboutons(this);

        //charge le droit
        bMsgNumCdeDIUnique = ModuleData.ExecuteScalarInt($"select count(*) AS NB_BCLI_NUMCDE_DI from tdin with (nolock)  inner join tcli with (nolock) on tcli.nclinum = tdin.nclinum where TCLI.BCLI_NUMCDE_DI = 1 and tdin.ndinnum = { MozartParams.NumDi}") > 0 ? true : false;

        // Redim la fenêtre si pas de droits sur Devis V2
        if (ModuleMain.bAccesBouton("705") == 0)
        {
          this.Width = cmdDevisFOV2.Left;
        }

        if (MozartParams.NomSociete != "EMALECFACILITEAM")
        {
          cmdDevisFO.Visible = false;
        }
      }
      catch (Exception ex)
      {
        MZUtils.displayError(MethodBase.GetCurrentMethod().Name, ex);
      }
      finally { Cursor.Current = Cursors.Default; }
    }

    private void cmdDevisFo_Click(object sender, EventArgs e)
    {
      if (bMsgNumCdeDIUnique) MessageBox.Show($"Attention: Ce client nous transmet un n° de GMAO / commande unique pour un même dossier \nPensez bien à inclure dans ce devis les éventuelles interventions et dépannages précédents.", Program.AppTitle, MessageBoxButtons.OK, MessageBoxIcon.Information); ;

      new frmDevisClient()
      {
        miNumDevis = 0,
        miNumDI = MozartParams.NumDi,
        miNumAction = MozartParams.NumAction
      }.ShowDialog();

      Dispose();
    }

    private void cmdDevisPrest_Click(object sender, EventArgs e)
    {
      if (bMsgNumCdeDIUnique) MessageBox.Show($"Attention: Ce client nous transmet un n° de GMAO / commande unique pour un même dossier \nPensez bien à inclure dans ce devis les éventuelles interventions et dépannages précédents.", Program.AppTitle, MessageBoxButtons.OK, MessageBoxIcon.Information); ;

      new frmDevisClientPrestation()
      {
        miNumAction = MozartParams.NumAction
      }.ShowDialog();

      Dispose();
    }

    private void apiButton1_Click(object sender, EventArgs e)
    {
      if (bMsgNumCdeDIUnique) MessageBox.Show($"Attention: Ce client nous transmet un n° de GMAO / commande unique pour un même dossier \nPensez bien à inclure dans ce devis les éventuelles interventions et dépannages précédents.", Program.AppTitle, MessageBoxButtons.OK, MessageBoxIcon.Information); ;


      new frmDevisClient2()
      {
        miNumDevisCL = 0,
        miNumDI = MozartParams.NumDi,
        miNumAction = MozartParams.NumAction
      }.ShowDialog();

      Dispose();
    }
  }
}

