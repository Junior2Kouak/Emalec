using MozartLib;
using MozartNet;
using System;
using System.Data.Entity.Migrations;
using System.Linq;
using System.Reflection;
using System.Windows.Forms;
using MZUtils = MozartControls.Utils;
using MZCtrlResources = MozartControls.Properties.Resources;

namespace MozartCS
{
  public partial class frmGestOffreCom : Form
  {
    private bool mBModeArchives;

    public frmGestOffreCom()
    {
      InitializeComponent();
    }

    private void frmGestOffreCom_Load(object sender, EventArgs e)
    {
      try
      {
        Cursor.Current = Cursors.WaitCursor;

        ModuleMain.Initboutons(this);

        mBModeArchives = false;

        ucListeOffres1.initColumnsGrid(true);

        ucListeOffres1.TypeFiltreOffre = UCListeOffres.OFFRE_ACTIVE;
        ucListeOffres1.fillGrid(0);
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

      ucListeOffres1.fillGrid(0);
    }

    private void cmdArchive_Click(object sender, EventArgs e)
    {
      updateIHM(true);
    }

    private void updateIHM(bool pIsModeArchives)
    {
      mBModeArchives = pIsModeArchives;

      string lTitle = MZCtrlResources.gest_com_prospect;

      if (mBModeArchives)
      {
        lTitle += $" {MZCtrlResources.archivees}";
      }
      lblTitre.Text = Text = lTitle;

      flpButtons.Visible = !mBModeArchives;
      
      ucListeOffres1.TypeFiltreOffre = mBModeArchives ? UCListeOffres.OFFRE_ARCHIVEE : UCListeOffres.OFFRE_ACTIVE;
      ucListeOffres1.fillGrid(0);
    }

    private void cmdFermer_Click(object sender, EventArgs e)
    {
      if (mBModeArchives)
      {
        updateIHM(!mBModeArchives);
      }
      else
      {
        Close();
      }
    }
  }
}
