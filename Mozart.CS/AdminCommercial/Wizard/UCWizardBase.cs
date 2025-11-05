using MozartLib;
using System.Collections.Generic;
using System.Windows.Forms;

namespace MozartCS
{
  partial class UCWizardBase : UserControl
  {
    protected TCLI mTCLIEnreg;

    public List<TCONTRATCLI> TCONTRATCLIs { get; set; }

    protected MULTIEntities mMULTIEntities;
    protected COMMUNEntities mCOMMUNEntities;

    public UCWizardBase() : this(null, null)
    {
    }

    public UCWizardBase(MULTIEntities pMULTIEntities, COMMUNEntities pCOMMUNEntities) : this(null, null, null)
    {
    }

    public UCWizardBase(TCLI pTCliEnreg, MULTIEntities pMULTIEntities, COMMUNEntities pCOMMUNEntities)
    {
      InitializeComponent();

      mMULTIEntities = pMULTIEntities;
      mCOMMUNEntities = pCOMMUNEntities;

      mTCLIEnreg = pTCliEnreg;
    }

    //public void setTRSF(TRSF pTRSFEnreg)
    //{
    //  mTRSFEnreg = pTRSFEnreg;
    //}

    //public void setTCCL(TCCL pTCCLEnreg)
    //{
    //  mTCCLEnreg = pTCCLEnreg;
    //}

    //public void setTCONTRATCLI(TCONTRATCLI pTCONTRATCLIEnreg)
    //{
    //  mTCONTRATCLIEnreg = pTCONTRATCLIEnreg;
    //}

    public virtual void SetInitialFcous()
    {
      // TODO : A implémenter si besoin dans les classes dérivées
    }

    public virtual bool VerifSaisieChamp()
    {
      // TODO : A implémenter si besoin dans les classes dérivées
      return true;
    }
  }
}
