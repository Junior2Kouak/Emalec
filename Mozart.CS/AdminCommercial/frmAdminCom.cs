using MozartCS.Properties;
using MozartLib;
using MozartNet;
using System;
using System.Collections.Generic;
using System.Data;
using System.Reflection;
using System.Windows.Forms;
using MZUtils = MozartControls.Utils;

namespace MozartCS
{
  public partial class frmAdminCom : Form
  {
    private DataTable dt = new DataTable();

    public frmAdminCom()
    {
      InitializeComponent();
    }

    private void frmAdminCom_Load(object sender, System.EventArgs e)
    {
      try
      {
        ModuleMain.Initboutons(this);

        // Verrouillage 
        List<int> lNpernumDroitRefonte = new List<int>()
        {
          // PCh, LLa, FGi, Marechet
          253, 3057, 4058, 1646
        };
        cmdRefonteProspe.Visible = (lNpernumDroitRefonte.Contains(MozartParams.UID));
        // 05/06/2025 : Désactivation de la fusion Prospect pour archivage des modifs
        //cmdRefonteProspe.Visible = false;

        cmdGestGroupe.Visible = cmdGestSecteurs.Visible = (MozartParams.UID == 4058);
      }
      catch (Exception ex)
      {
        MZUtils.displayError(MethodBase.GetCurrentMethod().Name, ex);
      }
    }

    private void CmdChoixStat_Click(object sender, EventArgs e)
    {
      Frame1.Visible = true;
    }

    private void CmdChoixStatClose_Click(object sender, EventArgs e)
    {
      Frame1.Visible = false;
    }

    private void CmdStatCliCom_Click(object sender, EventArgs e)
    {
      Cursor.Current = Cursors.WaitCursor;
      Frame1.Visible = false;
      new frmStatComCACliByCom().ShowDialog();
      Cursor.Current = Cursors.Default;
    }

    private void cmdProsp_Click(object sender, EventArgs e)
    {
      Cursor.Current = Cursors.WaitCursor;
      Frame1.Visible = false;
      new frmProspGestion().ShowDialog();
      Cursor.Current = Cursors.Default;
    }

    private void cmdSuivi_Click(object sender, EventArgs e)
    {
      Cursor.Current = Cursors.WaitCursor;
      new frmProspListe().ShowDialog();
      Cursor.Current = Cursors.Default;
    }

    private void cmdCourrier_Click(object sender, EventArgs e)
    {
      Cursor.Current = Cursors.WaitCursor;
      frmProspListeCourrier f = new frmProspListeCourrier
      {
        msLibNomSoc = MozartParams.NomSociete,
        miNumProspect = 0,
        mstrStatut = "C"
      };
      f.ShowDialog();
      Cursor.Current = Cursors.Default;
    }

    private void CmdQui_Click(object sender, EventArgs e)
    {
      Cursor.Current = Cursors.WaitCursor;
      FrameCliProsp.Visible = true;

      apiTGridCliProsp.LoadData(dt, MozartDatabase.cnxMozart, "EXEC api_sp_GetQuiSoccupeDeQui");
      apiTGridCliProsp.GridControl.DataSource = dt;

      if (apiTGridCliProsp.dgv.Columns.Count == 0)
        InitApiTgrid();
      Label2.Visible = false;
      CmdAnnule.Visible = true;
      cmdValide.Visible = true;

      Cursor.Current = Cursors.Default;
    }

    private void apiTGridCliProsp_DoubleClickE(object sender, EventArgs e)
    {
      cmdValide_Click(null, null);
    }

    private void cmdAnnule_Click(object sender, EventArgs e)
    {
      FrameCliProsp.Visible = false;
    }

    private void cmdValide_Click(object sender, EventArgs e)
    {
      if (apiTGridCliProsp.GetFocusedDataRow() == null) return;

      new frmDetailQui(Convert.ToInt32(apiTGridCliProsp.GetFocusedDataRow()["NPROSNUM"])).ShowDialog();
    }

    private void InitApiTgrid()
    {
      apiTGridCliProsp.AddColumn("NUM", "NPROSNUM", 0);
      apiTGridCliProsp.AddColumn(Resources.col_nom_client_prospect, "VPROSNOM", 4000);
      apiTGridCliProsp.AddColumn(Resources.col_Filiale, "VSOCIETE", 1200, "", 2);
      apiTGridCliProsp.AddColumn(Resources.col_Maintenance, "MAINTENANCE", 2000, "", 2);
      apiTGridCliProsp.AddColumn(Resources.col_Extinction_incendie, "EI", 2200, "", 2);
      apiTGridCliProsp.AddColumn("MAGESTIME", "MAGESTIME", 2200, "", 2);
      apiTGridCliProsp.AddColumn(Resources.col_Particulier, "PARTICULIER", 2200, "", 2);
      apiTGridCliProsp.AddColumn(Resources.col_Web_Marchand, "WEB", 2200, "", 2);
      apiTGridCliProsp.AddColumn(Resources.col_Chaff, "VCHAFF", 2200, "", 2);

      apiTGridCliProsp.btnExcel.Visible = apiTGridCliProsp.btnPrint.Visible = false;

      apiTGridCliProsp.InitColumnList();
    }

    private void cmdClients_Click(object sender, EventArgs e)
    {
      Cursor.Current = Cursors.WaitCursor;
      new frmListeClients().ShowDialog();
      Cursor.Current = Cursors.Default;
    }

    private void BtnSuiviContratCli_Click(object sender, EventArgs e)
    {
      Cursor.Current = Cursors.WaitCursor;
      new frmSuiviContratsClients().ShowDialog();
      Cursor.Current = Cursors.Default;
    }

    private void cmdRefonteProspe_Click(object sender, EventArgs e)
    {
      Cursor.Current = Cursors.WaitCursor;
      new frmProspFusionProspCli().ShowDialog();
      Cursor.Current = Cursors.Default;
    }

    private void cmdGestGroupe_Click(object sender, EventArgs e)
    {
      Cursor.Current = Cursors.WaitCursor;
      new frmGestGroupeProsp().ShowDialog();
      Cursor.Current = Cursors.Default;
    }

    private void cmdGestSecteurs_Click(object sender, EventArgs e)
    {
      Cursor.Current = Cursors.WaitCursor;
      new frmGestSecteurClient().ShowDialog();
      Cursor.Current = Cursors.Default;
    }

    private void cmdGestOffreCom_Click(object sender, EventArgs e)
    {
      Cursor.Current = Cursors.WaitCursor;
      new frmGestOffreCom().ShowDialog();
      Cursor.Current = Cursors.Default;
    }
  }
}

