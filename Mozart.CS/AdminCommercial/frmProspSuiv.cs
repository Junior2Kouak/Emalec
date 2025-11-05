using MozartCS.Properties;
using MozartLib;
using MozartNet;
using MozartUC;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.Entity.Migrations;
using System.Linq;
using System.Reflection;
using System.Windows.Forms;
using MZCtrlResources = MozartControls.Properties.Resources;
using MZUtils = MozartControls.Utils;

namespace MozartCS
{
  public partial class frmProspSuiv : Form
  {
    private int miNumProspect;

    private BindingList<CSuiviListe_DTO> mListeSuivis;

    public frmProspSuiv(int piNumProspect)
    {
      InitializeComponent();

      miNumProspect = piNumProspect;
    }

    private void frmProspSuiv_Load(object sender, EventArgs e)
    {
      try
      {
        Cursor.Current = Cursors.WaitCursor;

        ModuleMain.Initboutons(this);

        MULTIEntities lMULTIEntities = new MULTIEntities();

        InitApigridAction();

        ucListeOffres1.initColumnsGrid(false);

        // Pour le nom du prospect
        TPROSP lProsp = lMULTIEntities.TPROSP.FirstOrDefault(x => x.NPROSNUM == miNumProspect);
        if (lProsp != null)
        {
          Text = lblTitre.Text += $" {lProsp.VPROSNOM}";
        }

        OuvertureEnModification();
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

    private void cmdAjouter_Click(object sender, EventArgs e)
    {
      try
      {
        new frmProspDetailSuiv(miNumProspect).ShowDialog();

        OuvertureEnModification();
      }
      catch (Exception ex)
      {
        MZUtils.displayError(MethodBase.GetCurrentMethod().Name, ex);
      }
    }

    private void cmdModifier_Click(object sender, EventArgs e)
    {
      try
      {
        if (!(ApiTGridAction.dgv.GetFocusedRow() is CSuiviListe_DTO currentRow)) return;

        //  ' écran de modification de l' action
        new frmProspDetailSuiv(currentRow.NPROSNUM, currentRow.NSUIVNUM).ShowDialog();

        OuvertureEnModification();
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

    private void cmdSupprimer_Click(object sender, EventArgs e)
    {
      try
      {
        //  'suppression de l' action selectionnée
        if (!(ApiTGridAction.dgv.GetFocusedRow() is TPROSPSUIV currentRow)) return;

        if (MessageBox.Show(Resources.msg_ConfirmDelAction, Program.AppTitle, MessageBoxButtons.YesNo, MessageBoxIcon.Question, MessageBoxDefaultButton.Button2) == DialogResult.No)
          return;

        MULTIEntities lMULTIEntities = new MULTIEntities();

        TPROSPSUIV ltmp = lMULTIEntities.TPROSPSUIV.Where(x => x.NSUIVNUM == currentRow.NSUIVNUM).FirstOrDefault();
        if (ltmp != null)
        {
          lMULTIEntities.TPROSPSUIV.Remove(ltmp);
          lMULTIEntities.SaveChanges();
        }

        OuvertureEnModification();
      }
      catch (Exception ex)
      {
        MZUtils.displayError(MethodBase.GetCurrentMethod().Name, ex);
      }
    }

    private void InitApigridAction()
    {
      try
      {
        ApiTGridAction.AddColumn(Resources.col_D_action, "DSUIVDATE", 900, "dd/mm/yy");
        ApiTGridAction.AddColumn(MZCtrlResources.activite, "VLIBDOMCOM", 1100);
        ApiTGridAction.AddColumn(Resources.col_Auteur, "VSUIVQUI", 1100);
        ApiTGridAction.AddColumn(MZCtrlResources.col_Action, "VSUIVACTION", 2000);
        ApiTGridAction.AddColumn(MZCtrlResources.D_RDV, "DSUIVRDV", 900, "dd/mm/yy");
        ApiTGridAction.AddColumn(MZCtrlResources.D_Relance, "DSUIVDATERAP", 1100, "dd/mm/yy", MozartUCConstants.GRID_COL_ALIGN_CENTER);
        ApiTGridAction.AddColumn(MZCtrlResources.RDV_Realise, "CSUIVRDVREALISE", 900, "", MozartUCConstants.GRID_COL_ALIGN_CENTER);

        ApiTGridAction.AddColumn("NSUIVNUM", "NSUIVNUM", 0);
        ApiTGridAction.AddColumn("NPROSNUM", "NPROSNUM", 0);
        ApiTGridAction.AddColumn("NDOMCOMID", "NDOMCOMID", 0);

        ApiTGridAction.InitColumnList();
      }
      catch (Exception ex)
      {
        MZUtils.displayError(MethodBase.GetCurrentMethod().Name, ex);
      }
    }

    private void OuvertureEnModification()
    {
      try
      {
        Cursor.Current = Cursors.WaitCursor;
       
        MULTIEntities lMULTIEntities = new MULTIEntities();
        COMMUNEntities lCOMMUNEntities = new COMMUNEntities();

        List<TREF_DOMCOM> lRetDomCom = lCOMMUNEntities.TREF_DOMCOM.Where(x => x.VLANGUE == MozartParams.Langue).ToList();
        var lListPROSPSUIV = lMULTIEntities.TPROSPSUIV.Where(x => x.NPROSNUM == miNumProspect).OrderByDescending(x => x.DSUIVDATE).ToList();

        mListeSuivis = new BindingList<CSuiviListe_DTO>(lListPROSPSUIV.Select(x => new CSuiviListe_DTO(x)
        {
          VLIBDOMCOM = lRetDomCom.Where(y => y.NDOMCOMID == x.NDOMCOMID).FirstOrDefault().VLIBDOMCOM
        }).ToList());

        ApiTGridAction.GridControl.DataSource = mListeSuivis;

        // Les offres
        ucListeOffres1.fillGrid(miNumProspect);
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

    private void cmdAddOffre_Click(object sender, EventArgs e)
    {
      Cursor.Current = Cursors.WaitCursor;
      new frmProspDetailOffre(miNumProspect, 0).ShowDialog();

      OuvertureEnModification();

      Cursor.Current = Cursors.Default;
    }

    private void cmdDetailOffre_Click(object sender, EventArgs e)
    {
      if (!(ucListeOffres1.GridView.GetFocusedRow() is COffreListe_DTO currentRow)) return;

      Cursor.Current = Cursors.WaitCursor;

      //  ' écran de modification de l'offre
      new frmProspDetailOffre(currentRow.NPROSNUM, currentRow.NOFFREID).ShowDialog();

      OuvertureEnModification();

      Cursor.Current = Cursors.Default;
    }

    private void cmdDelOffre_Click(object sender, EventArgs e)
    {
      if (!(ucListeOffres1.GridView.GetFocusedRow() is COffreListe_DTO currentRow)) return;

      Cursor.Current = Cursors.WaitCursor;

      MULTIEntities lMULTIEntities = new MULTIEntities();

      TPROSPOFFRE lPROSPOFFRE = lMULTIEntities.TPROSPOFFRE.FirstOrDefault(x => x.NOFFREID == currentRow.NOFFREID);
      if (lPROSPOFFRE != null)
      {
        lPROSPOFFRE.COFFREARCHIVEE = CEntiteConstants.STR_CHAMP_O;
        lMULTIEntities.TPROSPOFFRE.AddOrUpdate(lPROSPOFFRE);

        lMULTIEntities.SaveChanges();
      }
    }
  }
}
