using MozartCS.Administration;
using MozartCS.Properties;
using MozartLib;
using MozartNet;
using MozartUC;
using System;
using System.Data.SqlClient;
using System.Reflection;
using System.Windows.Forms;
using MZUtils = MozartControls.Utils;

namespace MozartCS
{
  public partial class frmAdmin : Form
  {
    public frmAdmin() { InitializeComponent(); }

    private void frmAdmin_Load(object sender, System.EventArgs e)
    {
      try
      {
        Cursor.Current = Cursors.WaitCursor;
        ModuleMain.Initboutons(this);
        cmdInfoOTEmalec.Text += "  société";

        cmdLog.Visible = MozartParams.UID == 2095;
      }
      catch (Exception ex)
      {
        MZUtils.displayError(MethodBase.GetCurrentMethod().Name, ex);
      }
      finally { Cursor.Current = Cursors.Default; }
    }

    private void cmdLog_Click(object sender, EventArgs e)
    {
      MozartUcUtils.SpyLog(MozartDatabase.cnxMozart, "", cmdLog.Tag.ToString(), "Entrée");
      new frmListeSpyLog().ShowDialog();
    }

    private void cmdVEH_Click(object sender, EventArgs e)
    {
      new frmSaisieKMvehPret().ShowDialog();
    }

    private void CmdGestGrpManage_Click(object sender, EventArgs e)
    {
      Cursor.Current = Cursors.WaitCursor;
      new frmGestGrpManage().ShowDialog();
      Cursor.Current = Cursors.Default;
    }

    private void CmdTxChange_Click(object sender, EventArgs e)
    {
      Cursor.Current = Cursors.WaitCursor;
      new frmListeTxChange().ShowDialog();
      Cursor.Current = Cursors.Default;
    }

    private void cmdInfoOTsecurite_Click(object sender, EventArgs e)
    {
      // Nouvelle version générique
      new frmSaisieInfos
      {
        mstrTypeNote = "INFO_OT_SECURITE",
        miCleTable = MozartParams.SOCIETE // Numéro de client EMALEC ou FITELEC
      }.ShowDialog();
    }

    private void cmdPrestation_Click(object sender, EventArgs e)
    {
      new frmGestPrestationAdmin().ShowDialog();
    }

    private void cmdRegroupReg_Click(object sender, EventArgs e)
    {
      new frmRegoupRegPlan().ShowDialog();
    }

    private void cmdServTech_Click(object sender, EventArgs e)
    {
      new frmGestionServicesTechniques().ShowDialog();
    }

    private void cmdSoldes_Click(object sender, EventArgs e)
    {
      new frmGestPersComm().ShowDialog();
    }

    private void cmdTechAstr_Click(object sender, EventArgs e)
    {
      new frmChoixCadre().ShowDialog();
    }

    private void cmdAstr_Click(object sender, EventArgs e)
    {
      Cursor.Current = Cursors.WaitCursor;
      new frmGestAstr().ShowDialog();
      Cursor.Current = Cursors.Default;
    }

    private void cmdGestion_Click(object sender, EventArgs e)
    {
      new frmListeMailsAuto().ShowDialog();
    }

    private void cmdHeuresCaff_Click(object sender, EventArgs e)
    {
      // on récupère l'ID du vehicule du chaff
      using (SqlDataReader reader = ModuleData.ExecuteReader($"SELECT NVEHNUM FROM TVEHICULES WHERE NPERNUM = {MozartParams.UID}"))
      {
        if (reader.Read())
        {
          new frmSaisieKMMensuelChaff
          {
            miNumVeh = (int)Utils.ZeroIfNull(reader["NVEHNUM"]),
            miPerNumChaff = MozartParams.UID
          }.ShowDialog();
        }
        else
          MessageBox.Show(Resources.msg_aucun_vehicule_associe, Program.AppTitle, MessageBoxButtons.OK, MessageBoxIcon.Information);
      }
    }

    private void cmdInfo_Click(object sender, EventArgs e)
    {
      new FrmListeMessageMozart().ShowDialog();
    }

    private void cmdFermer_Click(object sender, System.EventArgs e)
    {
      Dispose();
    }

    private void cmdArchive_Click(object sender, EventArgs e)
    {
      new frmAdminDI().ShowDialog();
    }

    private void cmdClients_Click(object sender, EventArgs e)
    {
      Cursor.Current = Cursors.WaitCursor;
      MozartUcUtils.SpyLog(MozartDatabase.cnxMozart, "", cmdClients.Tag.ToString(), "Entrée");
      new frmGestClients().ShowDialog();
      Cursor.Current = Cursors.Default;
    }

    private void cmdDI_Click(object sender, EventArgs e)
    {
      new frmAdminMat().ShowDialog();
    }

    private void cmdFournitures_Click(object sender, EventArgs e)
    {
      Cursor.Current = Cursors.WaitCursor;
      new frmGestFourniture { iMode = 0 }.ShowDialog();
      Cursor.Current = Cursors.Default;
    }

    private void cmdIntervenant_Click(object sender, EventArgs e)
    {
      new frmGestFournisseurs
      {
        miNumSTF = 0,
        mstrNomSTF = ""
      }.ShowDialog();
    }

    private void cmdPersonnel_Click(object sender, EventArgs e)
    {
      // gestion de sécurité accès
      if (MozartParams.Droit == "OUI")
      {
        Cursor.Current = Cursors.WaitCursor;
        new frmGestPers().ShowDialog();
        Cursor.Current = Cursors.Default;
      }
      else
        MessageBox.Show(Resources.msg_DroitsAccesMenu, Program.AppTitle, MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
    }

    private void cmdTransfererFactures_Click(object sender, EventArgs e)
    {
      Cursor.Current = Cursors.WaitCursor;
      new frmAdminCompt().ShowDialog();
      Cursor.Current = Cursors.Default;
    }

    private void cmdDroit_Click(object sender, EventArgs e)
    {
      if (MozartParams.Droit == "OUI")
      {
        Cursor.Current = Cursors.WaitCursor;
        new frmGestionMenus().ShowDialog();
        Cursor.Current = Cursors.Default;
      }
      else
        MessageBox.Show(Resources.msg_DroitsAccesMenu, Program.AppTitle, MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
    }

    private void cmdweb_Click(object sender, EventArgs e)
    {
      Cursor.Current = Cursors.WaitCursor;
      new frmAdminWeb().ShowDialog();
      Cursor.Current = Cursors.Default;
    }

    private void cmdInfoOTEmalec_Click(object sender, EventArgs e)
    {
      // Nouvelle version générique
      new frmSaisieInfos
      {
        mstrTypeNote = "INFO_OT_EMALEC",
        miCleTable = MozartParams.SOCIETE  // Numéro de client EMALEC ou FITELEC
      }.ShowDialog();
    }

    private void Command1_Click(object sender, EventArgs e)
    {
      Cursor.Current = Cursors.WaitCursor;
      new frmListeAvoirWeb().ShowDialog();
      Cursor.Current = Cursors.Default;
    }

    private void CmdModelText_Click(object sender, EventArgs e)
    {
      Cursor.Current = Cursors.WaitCursor;
      new frmAdminModeleTexte().ShowDialog();
      Cursor.Current = Cursors.Default;
    }

    private void CmdGestContrat_Click(object sender, EventArgs e)
    {
      Cursor.Current = Cursors.WaitCursor;
      new frmAdminContrat().ShowDialog();
      Cursor.Current = Cursors.Default;
    }

    private void cmdSitesActifsTsClients_Click(object sender, EventArgs e)
    {
      Cursor.Current = Cursors.WaitCursor;
      new frmSitesActifsTousClients().ShowDialog();
      Cursor.Current = Cursors.Default;
    }

    private void frmAdmin_FormClosed(object sender, FormClosedEventArgs e)
    {
      MozartUcUtils.SpyLog(MozartDatabase.cnxMozart, "", "", "Sortie");
    }

    private void CmdCertEtanchBSD_Click(object sender, EventArgs e)
    {
      Cursor.Current = Cursors.WaitCursor;
      new frmAdminCertFluidBottle().ShowDialog();
      Cursor.Current = Cursors.Default;
    }

    private void CmdAccident_Click(object sender, EventArgs e)
    {
      Cursor.Current = Cursors.WaitCursor;
      new frmGestAccidentTrav().ShowDialog();
      Cursor.Current = Cursors.Default;
    }

    private void BtnAdminFormuleRev_Click(object sender, EventArgs e)
    {
      Cursor.Current = Cursors.WaitCursor;
      new frmListeFormuleRev().ShowDialog();
      Cursor.Current = Cursors.Default;
    }

    private void apiButton1_Click(object sender, EventArgs e)
    {
      Cursor.Current = Cursors.WaitCursor;
      new frmParamCO2().ShowDialog();
      Cursor.Current = Cursors.Default;
    }

    private void btnMethodes_Click(object sender, EventArgs e)
    {
      Cursor.Current = Cursors.WaitCursor;
      new frmMenu_Methodes().ShowDialog();
      Cursor.Current = Cursors.Default;
    }

    private void cmdAdminGMAO_Click(object sender, EventArgs e)
    {
      Cursor.Current = Cursors.WaitCursor;
      new frmListeGMAOClient().ShowDialog();
      Cursor.Current = Cursors.Default;
    }
  }
}

