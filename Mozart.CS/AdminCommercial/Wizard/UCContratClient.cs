using MozartLib;
using System;
using System.Collections.Generic;
using System.Data;
using System.Data.Entity;
using System.Drawing;
using System.Linq;
using System.Windows.Forms;
using MZCtrlResources = MozartControls.Properties.Resources;

namespace MozartCS
{
  partial class UCContratClient : UCWizardBase
  {
    private List<api_sp_ListeContratsExistant_Result> DtListContrat;

    public UCContratClient() : this(null, null, null)
    {
    }

    public UCContratClient(TCLI pTCliEnreg, MULTIEntities pMULTIEntities, COMMUNEntities pCOMMUNEntities) : base(pTCliEnreg, pMULTIEntities, pCOMMUNEntities)
    {
      InitializeComponent();

      DtListContrat = mMULTIEntities.api_sp_ListeContratsExistant(MozartParams.Langue).ToList();

      GCContrat.DataSource = DtListContrat;
    }

    public override bool VerifSaisieChamp()
    {
      List<api_sp_ListeContratsExistant_Result> lSelectedContrats = DtListContrat.Where(x => x.BCONTRATAFFECTE == 1).ToList();

      if (lSelectedContrats.Count() == 0)
      {
        MessageBox.Show("Il faut sélectionner au moins un contrat.", MZCtrlResources.Global_erreur, MessageBoxButtons.OK, MessageBoxIcon.Error);

        return false;
      }

      foreach (var entry in mMULTIEntities.ChangeTracker.Entries<TCONTRATCLI>().Where(e => e.State == EntityState.Added).ToList())
      {
        entry.State = EntityState.Detached;
      }

      TCONTRATCLIs = new List<TCONTRATCLI>();
      foreach (api_sp_ListeContratsExistant_Result lTmpContrat in lSelectedContrats)
      {
        TCONTRATCLI lCurContratCli = new TCONTRATCLI
        {
          NTYPECONTRAT = lTmpContrat.NTYPECONTRAT,
          DDATCREE = DateTime.Now,
          TCLI = mTCLIEnreg
        };

        TCONTRATCLIs.Add(lCurContratCli);
      }

      return true;
    }

    private void GVContrat_CustomDrawFooter(object sender, DevExpress.XtraGrid.Views.Base.RowObjectCustomDrawEventArgs e)
    {
      Rectangle oPos = e.Bounds;
      oPos.Location = new Point(oPos.Left + 1, oPos.Top + 4);
      oPos.Size -= new Size(2, 2);

      StringFormat oFormat = new StringFormat
      {
        Alignment = StringAlignment.Center
      };

      int lNbContratSelected = DtListContrat.Where(x => x.BCONTRATAFFECTE == 1).Count();

      e.Appearance.DrawString(e.Cache, $"Nombre de contrat(s) sélectionné(s) : {lNbContratSelected} / {DtListContrat.Count()}", oPos, oFormat);
      e.Handled = true;
    }

    private void RepositoryItemCheckEditCHECK_CheckedChanged(object sender, EventArgs e)
    {
      GVContrat.PostEditor();
      GVContrat.RefreshData();
    }
  }
}
