using MozartCS.Properties;
using MozartLib;
using MozartNet;
using System;
using System.Reflection;
using System.Windows.Forms;
using MZUtils = MozartControls.Utils;

namespace MozartCS
{
  public partial class frmMenuAdminRH : Form
  {
    public frmMenuAdminRH() { InitializeComponent(); }

    /* OK --------------------------------------------------------------*/
    private void frmMenuAdminRH_Load(object sender, System.EventArgs e)
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

    private void CmdCompetPers_Click(object sender, EventArgs e)
    {
      new frmGestCompetenceByPers().ShowDialog();
    }

    private void cmdCompTech_Click(object sender, EventArgs e)
    {
      new frmGestContratCompetByTech().ShowDialog();
    }

    private void CmdContremaitre_Click(object sender, EventArgs e)
    {
      new frmContremaitre().ShowDialog();
    }

    private void cmdPersonnel_Click(object sender, EventArgs e)
    {
      // Gestion de sécurité accès
      if (MozartParams.Droit == "OUI")
      {
        Cursor.Current = Cursors.WaitCursor;
        new frmGestPers().ShowDialog();
        Cursor.Current = Cursors.Default;
      }
      else
      {
        MessageBox.Show(Resources.msg_DroitsAccesMenu, Program.AppTitle, MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
      }
    }


    private void cmdABS_Click(object sender, EventArgs e)
    {
      new frmStatJourAbscence { }.ShowDialog();
    }


    private void CmdElemPegase_Click(object sender, EventArgs e)
    {
      new frmSaisieInfoPaie().ShowDialog();
    }
    private void CmdRessHum_Click(object sender, EventArgs e)
    {
      new frmStatRessourHum().ShowDialog();
    }

    private void cmdFor_Click(object sender, EventArgs e)
    {
      // Il y a un parametre "T" à la fin pour ne pas filtrer la liste
      new frmListeFormation("T").ShowDialog();
    }


    private void CmdPEGASE_Click(object sender, EventArgs e)
    {

      new frmHierarchieFiliale().ShowDialog();

    }

    private void cmdQuitter_Click(object sender, System.EventArgs e)
    {
      Dispose();
    }

  }
}