using MozartLib;
using MozartNet;
using System;
using System.Data.Entity.Migrations;
using System.Linq;
using System.Windows.Forms;
using MZCtrlResources = MozartControls.Properties.Resources;

namespace MozartCS
{
  public partial class frmProspDetailOffre : Form
  {
    private int miNumOffre;
    private int miNumProspect;

    private MULTIEntities mMULTIEntities;
    private COMMUNEntities mCOMMUNEntities;

    public frmProspDetailOffre() : this(0, 0)
    {
      InitializeComponent();
    }

    public frmProspDetailOffre(int pINumProspect, int pINumOffre)
    {
      InitializeComponent();

      miNumProspect = pINumProspect;
      miNumOffre = pINumOffre;

      mMULTIEntities = new MULTIEntities();
      mCOMMUNEntities = new COMMUNEntities();
    }

    private void frmProspDetailOffre_Load(object sender, EventArgs e)
    {
      ModuleMain.Initboutons(this);

      TPROSP lProsp = mMULTIEntities.TPROSP.FirstOrDefault(x => x.NPROSNUM == miNumProspect);
      if (lProsp != null)
      {
        lblTitre.Text += lProsp.VPROSNOM;
        Text = lblTitre.Text;
      }

      fillCombos();

      OuvertureEnModification();
    }

    private void fillCombos()
    {
      // Filiale concernée
      cboFiliale.DataSource = mCOMMUNEntities.TSOCIETE.Where(x => x.VSOCIETEACTIF == CEntiteConstants.STR_CHAMP_O && x.BISFILIALEEMALEC == CEntiteConstants.STR_CHAMP_O)
                                            .OrderBy(x => x.VSOCIETE_NOM_USUEL)
                                            .ToList();
      cboFiliale.ValueMember = "NSOCIETEID";
      cboFiliale.DisplayMember = "VSOCIETE_NOM_USUEL";
      // Sélectionne par défaut la société avec laquelle est lancé le Mozart
      cboFiliale.SelectedValue = mCOMMUNEntities.TSOCIETE.Where(x => x.VSOCIETENOM == MozartParams.NomSociete).First().NSOCIETEID;

      // Origine de contact
      cboOriContact.DataSource = TOFFRE_ORICONTACT_Liste.TOFFRE_ORICONTACTs;
      cboOriContact.DisplayMember = "VOFFRE_ORICONTACT_NOM";
      cboOriContact.ValueMember = "NOFFRE_ORICONTACT_ID";
      cboOriContact.SelectedIndex = 0;

      // Type d'offre
      cboTypeOffre.DataSource = TOFFRE_TYPEOFFRE_Liste.TOFFRE_TYPEOFFREs;
      cboTypeOffre.DisplayMember = "VOFFRE_TYPEOFFRE_NOM";
      cboTypeOffre.ValueMember = "NOFFRE_TYPEOFFRE_ID";
      cboTypeOffre.SelectedIndex = 0;

      // Défensif
      rdDefOui.Checked = true;

      // DAS EMALEC
      cboDASEmalec.DataSource = TOFFRE_DASEMALEC_Liste.TOFFRE_DASEMALECs;
      cboDASEmalec.DisplayMember = "VOFFRE_DASEMALEC_NOM";
      cboDASEmalec.ValueMember = "NOFFRE_DASEMALEC_ID";
      cboDASEmalec.SelectedIndex = 0;

      // Statut
      cboStatut.DataSource = TOFFRE_STATUT_Liste.TOFFRE_STATUTs;
      cboStatut.DisplayMember = "VOFFRE_STATUT_NOM";
      cboStatut.ValueMember = "NOFFRE_STATUT_ID";
      cboStatut.SelectedIndex = 0;

      // Chance de gain
      cboChanceGain.DataSource = TOFFRE_CHANCEGAIN_Liste.TOFFRE_CHANCEGAINs;
      cboChanceGain.DisplayMember = "VOFFRE_CHANCEGAIN_NOM";
      cboChanceGain.ValueMember = "NOFFRE_CHANCEGAIN_ID";
      cboChanceGain.SelectedIndex = 0;
    }

    private void OuvertureEnModification()
    {
      TPROSPOFFRE lPROSPOFFRE = mMULTIEntities.TPROSPOFFRE.FirstOrDefault(x => x.NOFFREID == miNumOffre);
      if (lPROSPOFFRE != null)
      {
        cboFiliale.SelectedValue = lPROSPOFFRE.NSOCIETE;
        cboOriContact.SelectedValue = lPROSPOFFRE.NOFFREORICONTACT;
        txtOffre.Text = lPROSPOFFRE.VOFFRETEXT;
        cboTypeOffre.SelectedValue = lPROSPOFFRE.NOFFRETYPEOFFRE;
        rdDefOui.Checked = "O".Equals(lPROSPOFFRE.COFFREDEFENSIF);
        rdDefNon.Checked = !rdDefOui.Checked;
        cboDASEmalec.SelectedValue = lPROSPOFFRE.NOFFREDASEMALEC;
        chkPerimetre.Checked = "O".Equals(lPROSPOFFRE.COFFREPERIMETREPAYS);
        DateReponse.EditValue = lPROSPOFFRE.DOFFREREPONSE;
        DateDemarrageContrat.EditValue = lPROSPOFFRE.DOFFREDEMARRRAGECONTRAT;
        txtCAForfPrev.EditValue = lPROSPOFFRE.NOFFRECAFORFAITPREV;
        txtCAEstimGlob.EditValue = lPROSPOFFRE.NOFFRECAESTIMATIFGLOBAL;
        txtCADefensif.EditValue = lPROSPOFFRE.NOFFRECADEFENSIF;
        cboStatut.SelectedValue = lPROSPOFFRE.NOFFRESTATUT;
        cboChanceGain.SelectedValue = lPROSPOFFRE.NOFFRECHANCEGAIN;
        txtCom.Text = lPROSPOFFRE.VOFFRECOMMENTAIRE;
      }
    }

    private void cmdValider_Click(object sender, EventArgs e)
    {
      if (txtOffre.Text == "")
      {
        MessageBox.Show(MZCtrlResources.msg_enter_libelle_offre, Program.AppTitle, MessageBoxButtons.OK, MessageBoxIcon.Information);
        return;
      }

      TPROSPOFFRE lPROSPOFFRE = mMULTIEntities.TPROSPOFFRE.FirstOrDefault(x => x.NOFFREID == miNumOffre);
      if (lPROSPOFFRE == null)
      {
        lPROSPOFFRE = new TPROSPOFFRE
        {
          DOFFREDATECRE = DateTime.Now,
          NPROSNUM = miNumProspect,
          NPERNUMCRE = MozartParams.UID,
          COFFREARCHIVEE = "N"
        };
      }

      lPROSPOFFRE.NSOCIETE = (int)cboFiliale.SelectedValue;
      lPROSPOFFRE.NOFFREORICONTACT = (int)cboOriContact.SelectedValue;
      lPROSPOFFRE.VOFFRETEXT = txtOffre.Text;
      lPROSPOFFRE.NOFFRETYPEOFFRE = (int)cboTypeOffre.SelectedValue;
      lPROSPOFFRE.COFFREDEFENSIF = rdDefOui.Checked ? CEntiteConstants.STR_CHAMP_O : CEntiteConstants.STR_CHAMP_N;
      lPROSPOFFRE.NOFFREDASEMALEC = (int)cboDASEmalec.SelectedValue;
      lPROSPOFFRE.COFFREPERIMETREPAYS = chkPerimetre.Checked ? CEntiteConstants.STR_CHAMP_O : CEntiteConstants.STR_CHAMP_N;
      lPROSPOFFRE.DOFFREREPONSE = !string.IsNullOrEmpty(DateReponse.Text) ? (DateTime?)DateReponse.DateTime : null;
      lPROSPOFFRE.DOFFREDEMARRRAGECONTRAT = !string.IsNullOrEmpty(DateDemarrageContrat.Text) ? (DateTime?)DateDemarrageContrat.DateTime : null;
      lPROSPOFFRE.NOFFRECAFORFAITPREV = double.TryParse(txtCAForfPrev.EditValue?.ToString(), out double val) ? val : 0.0;
      lPROSPOFFRE.NOFFRECAESTIMATIFGLOBAL = double.TryParse(txtCAEstimGlob.EditValue?.ToString(), out double val2) ? val2 : 0.0;
      lPROSPOFFRE.NOFFRECADEFENSIF = double.TryParse(txtCADefensif.EditValue?.ToString(), out double val3) ? val3 : 0.0;
      lPROSPOFFRE.NOFFRESTATUT = (int)cboStatut.SelectedValue;
      lPROSPOFFRE.NOFFRECHANCEGAIN = (int)cboChanceGain.SelectedValue;
      lPROSPOFFRE.VOFFRECOMMENTAIRE = txtCom.Text;

      mMULTIEntities.TPROSPOFFRE.AddOrUpdate(lPROSPOFFRE);
      mMULTIEntities.SaveChanges();

      MessageBox.Show(MZCtrlResources.saved, Program.AppTitle, MessageBoxButtons.OK, MessageBoxIcon.Information);

      Close();
    }

    private void EditValueChanged(object sender, EventArgs e)
    {
      double.TryParse(txtCAEstimGlob.EditValue?.ToString(), out double val1);
      double.TryParse(txtCADefensif.EditValue?.ToString(), out double val2);

      txtCADev.EditValue = val1 - val2;
    }
  }
}
