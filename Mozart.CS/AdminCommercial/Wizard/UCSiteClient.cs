using MozartLib;
using System;
using System.Data;
using System.Drawing;
using System.Linq;

namespace MozartCS
{
  partial class UCSiteClient : UCWizardBase
  {
    private bool mBCreationSite;

    public UCSiteClient() : this(null, null, null)
    {
    }

    public UCSiteClient(TCLI pTCliEnreg, MULTIEntities pMULTIEntities, COMMUNEntities pCOMMUNEntities) : base(pTCliEnreg, pMULTIEntities, pCOMMUNEntities)
    {
      InitializeComponent();

      mBCreationSite = false;
    }

    public override bool VerifSaisieChamp()
    {
      // Pas de création site client : On sort direct sans rien faire
      if (!mBCreationSite)
      {
        return true;
      }

      TSIT lSite = new TSIT
      {
        TCLI = mTCLIEnreg,
        // C'est la 1ière du client sachant que c'est un nouveau client et qu'1 seule RSF peut être crééé
        //TRSF = mTCLIEnreg.TRSF.First(),
        VSITNOM = mTCLIEnreg.VCLINOM,
        VSITENSEIGNE = mTCLIEnreg.VCLINOM,
        NSITNUE = "",
        VSITAD1 = mTCLIEnreg.VCLIAD1,
        VSITAD2 = mTCLIEnreg.VCLIAD2,
        VSITCP = mTCLIEnreg.VCLICP,
        VSITVIL = mTCLIEnreg.VCLIVIL,
        VSITPAYS = mTCLIEnreg.VCLIPAYS
      };
      if (lSite.VSITPAYS == TPAYS.STR_PAYS_FRANCE)
      {
        lSite.NREGCOD = Convert.ToInt32(mTCLIEnreg.VCLICP.Substring(0, 2));
      }
      else
      {
        lSite.NREGCOD = 0;
      }
      //mTCLIEnreg.TSIT.Add(lSite);

      // Création du contact client du site
      TCSIT lContactSiteClient = new TCSIT
      {
        TSIT = lSite,
        //VCSITNOM = lContactClient.VCCLNOM,
        VCSITPRE = "",
        VCSITCIV = "",
        NTYPCSITNUM = 1, // TODO FGB : Une ch'tite constante heinn
        //VCSITTEL = lContactClient.VCCLTEL,
        VCSITPOR = "",
        //VCSITMAI = lContactClient.VCCLMAIL,
        CCSITACTIF = "O"
      };

      // Affectation contrat client du site
      foreach (TCONTRATCLI lTmpContratCli in mMULTIEntities.TCONTRATCLI.Where(x => x.TCLI == mTCLIEnreg))
      {
        TCONT lTCont = new TCONT
        {
          TSIT = lSite,
          //lTCont.TCONTRATCLI.Add(lTmpContratCli);
          VCONTETAT = "O"
        };
      }

      return true;
    }

    private void BtnCreateSiteTrue_Click(object sender, EventArgs e)
    {
      mBCreationSite = true;

      BtnCreateSiteTrue.BackColor = Color.Yellow;
      BtnCreateSiteFalse.BackColor = SystemColors.Window;
    }

    private void BtnCreateSiteFalse_Click(object sender, EventArgs e)
    {
      mBCreationSite = false;

      BtnCreateSiteFalse.BackColor = Color.Yellow;
      BtnCreateSiteTrue.BackColor = SystemColors.Window;
    }
  }
}
