using MozartCS.Properties;
using MozartLib;
using MozartNet;
using System;
using System.Collections.Generic;
using System.Data;
using System.Data.Entity.Migrations;
using System.Linq;
using System.Reflection;
using System.Windows.Forms;
using System.Windows.Media.Media3D;
using MZUtils = MozartControls.Utils;

namespace MozartCS
{
  public partial class frmProspDetailSuiv : Form
  {
    private int miNumSuivi;
    private int miNumProspect;

    private MULTIEntities mMULTIEntities;
    private COMMUNEntities mCOMMUNEntities;

    private List<TREF_DOMCOM> mListeDomCom;

    private TPER mComDernierSuivi;
    private TPER mTPERRdvPris;

    private TPER mTPERRdvRealise;

    private bool bFormLoading;

    public frmProspDetailSuiv() : this(0, 0)
    {
    }

    public frmProspDetailSuiv(int pINumProspect) : this(pINumProspect, 0)
    {
    }

    public frmProspDetailSuiv(int pINumProspect, int pINumSuivi)
    {
      InitializeComponent();

      miNumProspect = pINumProspect;
      miNumSuivi = pINumSuivi;

      mMULTIEntities = new MULTIEntities();
      mCOMMUNEntities = new COMMUNEntities();
    }

    private void frmProspDetailSuiv_Load(object sender, System.EventArgs e)
    {
      try
      {
        ModuleMain.Initboutons(this);

        bFormLoading = true;

        TPROSP lProsp = mMULTIEntities.TPROSP.FirstOrDefault(x => x.NPROSNUM == miNumProspect);
        if (lProsp != null)
        {
          lblTitre.Text += lProsp.VPROSNOM;
          Text = lblTitre.Text;
        }

        //apicboDomCom.SetText("Maintenance");
        mListeDomCom = mCOMMUNEntities.TREF_DOMCOM.Where(x => x.VLANGUE == MozartParams.Langue).OrderBy(x => x.VLIBDOMCOM).ToList();

        cboDomCom.DataSource = mListeDomCom;
        cboDomCom.ValueMember = "NDOMCOMID";
        cboDomCom.DisplayMember = "VLIBDOMCOM";

        //txtDateRDV.DateTime = ;
        txtDateRDV.Text = "";

        // Maintenance par défaut
        cboDomCom.SelectedValue = TREF_DOMCOM.TREF_DOMCOM_ID_MAINTENANCE;

        OuvertureEnModification();

        bFormLoading = false;
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

    private void OuvertureEnModification()
    {
      try
      {
        // Dernier commercial de suivi
        TPROSPSUIV lPROSPSUIV = mMULTIEntities.TPROSPSUIV.Where(x => x.NSUIVNUM == miNumSuivi).FirstOrDefault();
        if (lPROSPSUIV != null)
        {
          mComDernierSuivi = mMULTIEntities.TPER.Where(x => x.VPERADSI == lPROSPSUIV.VSUIVQUI).FirstOrDefault();
          //if (mComDernierSuivi != null)
          //{
          //  lblAuteur.Text = mComDernierSuivi.getNomPrenom();
          //}
          lblAuteur.Text = mComDernierSuivi?.getNomPrenom() ?? string.Empty;

          if (lPROSPSUIV.DSUIVRDV != null)
          {
            txtDateRDV.DateTime = (DateTime) lPROSPSUIV.DSUIVRDV;
          }
            
          txtAction.Text = lPROSPSUIV.VSUIVACTION;
          txtDateA0.EditValue = lPROSPSUIV.DSUIVDATERAP;
          cboDomCom.SelectedValue = lPROSPSUIV.NDOMCOMID;

          // Attention : Init du TPER AVANT le chkbox correspondant
          mTPERRdvPris = mMULTIEntities.TPER.Where(x => x.NPERNUM == lPROSPSUIV.NSUIVQUIRDV).FirstOrDefault();
          chkRDVpris.Checked = (lPROSPSUIV.CSUIVRDV ?? CEntiteConstants.STR_CHAMP_N) == CEntiteConstants.STR_CHAMP_O;

          // Attention : Init du TPER AVANT le chkbox correspondant
          mTPERRdvRealise = mMULTIEntities.TPER.Where(x => x.NPERNUM == lPROSPSUIV.NSUIVRDVREALISE).FirstOrDefault();
          chkRDVReal.Checked = (lPROSPSUIV.CSUIVRDVREALISE ?? CEntiteConstants.STR_CHAMP_N) == CEntiteConstants.STR_CHAMP_O;
        }
      }
      catch (Exception ex)
      {
        MZUtils.displayError(MethodBase.GetCurrentMethod().Name, ex);
      }
    }

    private void cmdValider_Click(object sender, EventArgs e)
    {
      try
      {
        if (txtDateA0 == null)
        {
          MessageBox.Show(Resources.msg_DateProchContactOblig);
          return;
        }

        if (txtDateA0.DateTime.Date < DateTime.Today.Date)
        {
          MessageBox.Show(Resources.msg_DateInfToToDay);
          return;
        }

        TREF_DOMCOM selectedDomCom = cboDomCom.SelectedItem as TREF_DOMCOM;

        TPROSPSUIV lTPROSPSUIV = mMULTIEntities.TPROSPSUIV.FirstOrDefault(x => x.NSUIVNUM == miNumSuivi) ?? new TPROSPSUIV();

        if (lTPROSPSUIV.DSUIVDATE == null)
        {
          lTPROSPSUIV.DSUIVDATE = DateTime.Now;
        }

        lTPROSPSUIV.NPROSNUM = miNumProspect;
        lTPROSPSUIV.DSUIVDATERAP = txtDateA0.DateTime;
        lTPROSPSUIV.VSUIVACTION = txtAction.Text;
        lTPROSPSUIV.NDOMCOMID = selectedDomCom.NDOMCOMID;

        lTPROSPSUIV.CSUIVRDV = chkRDVpris.Checked ? CEntiteConstants.STR_CHAMP_O : CEntiteConstants.STR_CHAMP_N;

        if (mComDernierSuivi == null)
        {
          mComDernierSuivi = mMULTIEntities.TPER.FirstOrDefault(x => x.NPERNUM == MozartParams.UID);
        }

        lTPROSPSUIV.VSUIVQUI = mComDernierSuivi.VPERADSI;

        lTPROSPSUIV.CSUIVRDVREALISE = chkRDVReal.Checked ? CEntiteConstants.STR_CHAMP_O : CEntiteConstants.STR_CHAMP_N;
        lTPROSPSUIV.NSUIVRDVREALISE = mTPERRdvRealise?.NPERNUM;

        lTPROSPSUIV.NSUIVQUIRDV = mTPERRdvPris?.NPERNUM;

        lTPROSPSUIV.DSUIVRDV = !string.IsNullOrEmpty(txtDateRDV.Text) ? (DateTime?)txtDateRDV.DateTime : null;

        mMULTIEntities.TPROSPSUIV.AddOrUpdate(lTPROSPSUIV);
        mMULTIEntities.SaveChanges();

        miNumSuivi = lTPROSPSUIV.NSUIVNUM;
      }
      catch (Exception ex)
      {
        MZUtils.displayError(MethodBase.GetCurrentMethod().Name, ex);
      }
    }

    private void cmdSpell_Click(object sender, EventArgs e)
    {
      Utils.SpellCheck(txtAction);
    }

    private void cmdTraduction_Click(object sender, EventArgs e)
    {
      txtAction.Text = Utils.Traduction(txtAction.Text);
    }

    private void txtDateRDV_EditValueChanged(object sender, EventArgs e)
    {
      if ((txtDateRDV.Text != "") && !bFormLoading)
      {
        chkRDVpris.Checked = true;
      }
    }

    private void chkRDVpris_CheckedChanged(object sender, EventArgs e)
    {
      if (chkRDVpris.Checked)
      {
        if (mTPERRdvPris == null)
        {
          mTPERRdvPris = mMULTIEntities.TPER.Where(x => x.NPERNUM == MozartParams.UID).FirstOrDefault();
        }

        lblPropCom.Text = mTPERRdvPris?.getNomPrenom() ?? string.Empty;
      }
      else
      {
        lblPropCom.Text = "";
        mTPERRdvPris = null;
      }
    }

    private void chkRDVReal_CheckedChanged(object sender, EventArgs e)
    {
      if (chkRDVReal.Checked)
      {
        if (mTPERRdvRealise == null)
        {
          mTPERRdvRealise = mMULTIEntities.TPER.Where(x => x.NPERNUM == MozartParams.UID).FirstOrDefault();
        }

        lblQuiEtQuandRDVRealise.Text = mTPERRdvRealise?.getNomPrenom() ?? string.Empty;
      }
      else
      {
        lblQuiEtQuandRDVRealise.Text = "";
        mTPERRdvRealise = null;
      }
    }
  }
}
