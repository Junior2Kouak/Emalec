using MozartCS.Properties;
using MozartLib;
using MozartNet;
using System;
using System.Data.Entity.Migrations;
using System.Diagnostics;
using System.Linq;
using System.Reflection;
using System.Threading.Tasks;
using System.Windows.Forms;
using MZUtils = MozartControls.Utils;

namespace MozartCS
{
  public partial class frmProspContactDetail : Form
  {
    private int miNumProspect;
    private int miNumProspectContact;

    public frmProspContactDetail() : this(0, 0)
    {
    }

    public frmProspContactDetail(int piNumProspectContact, int piNumProspect)
    {
      InitializeComponent();

      miNumProspect = piNumProspect;
      miNumProspectContact = piNumProspectContact;
    }

    private void frmProspContactDetail_Load(object sender, EventArgs e)
    {
      try
      {
        ModuleMain.Initboutons(this);

        OuvertureEnModification();
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
        MULTIEntities lMULTIEntities = new MULTIEntities();

        TPROSPCCL lPROSPCCL = lMULTIEntities.TPROSPCCL.FirstOrDefault(x => x.NIDPROSPCCLNUM == miNumProspectContact);
        if (lPROSPCCL != null)
        {
          txtNom.Text = lPROSPCCL.VPROSPCCLNOM;
          txtprenom.Text = lPROSPCCL.VPROSPCCLPRE;
          txtQual.Text = lPROSPCCL.VPROSPCCLQUAL;
          txttel.Text = lPROSPCCL.VPROSPCCLTEL;
          //txtfax.Text = lPROSPCCL.VPROSPCCLFAX;
          txtport.Text = lPROSPCCL.VPROSPCCLPORT;
          txtmail.Text = lPROSPCCL.VPROSPCCLMAIL;

          if (lPROSPCCL.VPROSPCCLCIV != "")
          {
            cboCiv.Text = lPROSPCCL.VPROSPCCLCIV;
          }
        }
      }
      catch (Exception ex)
      {
        MZUtils.displayError(MethodBase.GetCurrentMethod().Name, ex);
      }
    }

    private void cmdEnregistrer_Click(object sender, EventArgs e)
    {
      try
      {
        MULTIEntities lMULTIEntities = new MULTIEntities();

        TPROSPCCL lPROSPCCL = lMULTIEntities.TPROSPCCL.FirstOrDefault(x => x.NIDPROSPCCLNUM == miNumProspectContact);
        if (lPROSPCCL == null)
        {
          lPROSPCCL = new TPROSPCCL
          {
            CPROSPCCLACTIF = CEntiteConstants.STR_CHAMP_O,
            NQUICREE = MozartParams.UID,
            DDATCRE = DateTime.Now
          };
        } else
        {
          lPROSPCCL.NQUIMOD = MozartParams.UID;
          lPROSPCCL.DDATMODIF = DateTime.Now;
        }

        lPROSPCCL.NPROSNUM = miNumProspect;
        lPROSPCCL.VPROSPCCLCIV = cboCiv.Text;
        lPROSPCCL.VPROSPCCLNOM = txtNom.Text;
        lPROSPCCL.VPROSPCCLPRE = txtprenom.Text;
        lPROSPCCL.VPROSPCCLQUAL = txtQual.Text;
        lPROSPCCL.VPROSPCCLTEL = txttel.Text;
        lPROSPCCL.VPROSPCCLPORT = txtport.Text;
        lPROSPCCL.VPROSPCCLMAIL = txtmail.Text;

        lMULTIEntities.TPROSPCCL.AddOrUpdate(lPROSPCCL);
        lMULTIEntities.SaveChanges();

        miNumProspectContact = lPROSPCCL.NIDPROSPCCLNUM;

        Close();
      }
      catch (Exception ex)
      {
        MZUtils.displayError(MethodBase.GetCurrentMethod().Name, ex);
      }
    }

    private void ApiTelAuto3_Click(object sender, EventArgs e)
    {
      _ = makeAvayaCall(txttel.Text);
    }

    private void ApiTelAuto4_Click(object sender, EventArgs e)
    {
      _ = makeAvayaCall(txtport.Text);
    }

    private async Task makeAvayaCall(string pTelNoToCall)
    {
      if (pTelNoToCall != "")
      {
        string reponse = await CNumerotationAuto.MakeCallByAvaya(MozartParams.UserTelInt, pTelNoToCall, Environment.MachineName);
        if (reponse != "OK")
        {
          MessageBox.Show(reponse, Program.AppTitle, MessageBoxButtons.OK, MessageBoxIcon.Error);
        }
      }
    }

    private void frmProspContactDetail_FormClosing(object sender, FormClosingEventArgs e)
    {
      if (miNumProspectContact == 0
              && (txtNom.Text != "" || txtprenom.Text != "" || txtQual.Text != "" || txttel.Text != "" ||
                  txtport.Text != "" || txtmail.Text != ""))
      {
        if (MessageBox.Show(Resources.msg_confirm_save_contact, Program.AppTitle, MessageBoxButtons.YesNo, MessageBoxIcon.Question, MessageBoxDefaultButton.Button2) == DialogResult.Yes)
          cmdEnregistrer_Click(null, null);
        else
          Dispose();
      }
    }

    private void PicM_Click(object sender, EventArgs e)
    {
      if (txtmail.Text == "") return;

      try {
        var process = Process.Start(Uri.EscapeUriString($"mailto: {txtmail.Text}"));
      }
      catch (Exception ex)
      {
        MZUtils.displayError(MethodBase.GetCurrentMethod().Name, ex);
      }
    }
  }
}
