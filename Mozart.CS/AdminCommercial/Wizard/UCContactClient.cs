using MozartLib;
using MozartNet;
using System;
using System.Drawing;
using System.Windows.Forms;
using MZCtrlResources = MozartControls.Properties.Resources;

namespace MozartCS
{
  partial class UCContactClient : UCWizardBase
  {
    public TCCL ContactClient { get; set; }

    public UCContactClient() : this(null, null, null)
    {
    }

    public UCContactClient(TCLI pTCliEnreg, MULTIEntities pMULTIEntities, COMMUNEntities pCOMMUNEntities) : base(pTCliEnreg, pMULTIEntities, pCOMMUNEntities)
    {
      InitializeComponent();
    }

    public override void SetInitialFcous()
    {
      ActiveControl = CboCCLCiv;
    }

    public override bool VerifSaisieChamp()
    {
      if (TxtCCLNom.Text == "")
      {
        MessageBox.Show("Le nom du contact client est obligatoire.", MZCtrlResources.Global_erreur, MessageBoxButtons.OK, MessageBoxIcon.Error);

        TxtCCLNom.BackColor = Color.Yellow;
        ActiveControl = TxtCCLNom;

        return false;
      }

      RegexUtilities oRegEx = new RegexUtilities();
      if ((TxtCCLMail.Text != "") && (!oRegEx.IsValidEmail(TxtCCLMail.Text)))
      {
        MessageBox.Show("L'adresse mail n'est pas correcte.", MZCtrlResources.Global_erreur, MessageBoxButtons.OK, MessageBoxIcon.Error);

        TxtCCLMail.BackColor = Color.Yellow;
        ActiveControl = TxtCCLMail;

        return false;
      }

      // Remplissage de l'objet TCCL
      ContactClient = new TCCL()
      {
        CCCLCIV = CboCCLCiv.Text,
        VCCLNOM = TxtCCLNom.Text,
        VCCLPRE = TxtCCLPrenom.Text,
        VCCLTEL = TxtCCLTel.Text,
        VCCLMAIL = TxtCCLMail.Text,
        VINTPOR = TxtCCLPort.Text,
        VCCLFONC = TxtCCLFonction.Text,
        CCCLACTIF = "O",
        TCLI = mTCLIEnreg
      };

      return true;
    }

    private void TxtCCLNom_EditValueChanged(object sender, EventArgs e)
    {
      if (TxtCCLNom.Text != "")
      {
        TxtCCLNom.BackColor = SystemColors.Window;
      }
    }

    private void TxtCCLMail_TextChanged(object sender, EventArgs e)
    {
      if (TxtCCLMail.Text != "")
      {
        TxtCCLMail.BackColor = SystemColors.Window;
      }
    }

    private void TxtCCLTel_Leave(object sender, EventArgs e)
    {
      TextBox lSender = (TextBox)sender;
      
      if (lSender.Text.Length > 2)
      {
        int lTmpVal;

        if ((lSender.Text.Substring(0, 2) != "00") && int.TryParse(lSender.Text, out lTmpVal))
        {
          lSender.Text = ModuleMain.formatPhoneNumber(lSender.Text, "0# ## ## ## ##").Replace(" ", ".");
        }
      }
    }
  }
}
