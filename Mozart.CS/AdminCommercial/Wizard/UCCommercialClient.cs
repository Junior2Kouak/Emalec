using MozartLib;
using System.Data;
using System.Linq;
using System.Windows.Forms;
using MZCtrlResources = MozartControls.Properties.Resources;

namespace MozartCS
{
  partial class UCCommercialClient : UCWizardBase
  {
    public TCLIPER TCLIPER { get; set; }

    public UCCommercialClient() : this(null, null, null)
    {
    }

    public UCCommercialClient(TCLI pTCliEnreg, MULTIEntities pMULTIEntities, COMMUNEntities pCOMMUNEntities) : base(pTCliEnreg, pMULTIEntities, pCOMMUNEntities)
    {
      InitializeComponent();
    }

    public override void SetInitialFcous()
    {
      CboCommercial.Properties.DataSource = mMULTIEntities.TPER.Where(x => (x.CPERTYP != "TE") && (x.CPERACTIF == "O") && (x.VSOCIETE == mTCLIEnreg.VSOCIETE))
                                                                              .OrderBy(x => x.VPERNOM).ToList();
    }

    public override bool VerifSaisieChamp()
    {
      if (CboCommercial.Text == "")
      {
        MessageBox.Show("Il faut sélectionner un commercial pour ce client.", MZCtrlResources.Global_erreur, MessageBoxButtons.OK, MessageBoxIcon.Error);

        return false;
      }

      //foreach (var entry in mMULTIEntities.ChangeTracker.Entries<TCLIPER>().Where(e => e.State == EntityState.Added).ToList())
      //{
      //  entry.State = EntityState.Detached;
      //}

      TCLIPER = new TCLIPER
      {
        TPER = mMULTIEntities.TPER.Where(x => x.NPERNUM == (int)CboCommercial.EditValue).First(),
        TCLI = mTCLIEnreg
      };

      return true;
    }
  }
}
