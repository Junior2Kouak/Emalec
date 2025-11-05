using MozartLib;
using MozartNet;
using System;
using System.Collections.Generic;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Reflection;
using System.Windows.Forms;
using MZCtrlResources = MozartControls.Properties.Resources;
using MZUtils = MozartControls.Utils;

namespace MozartCS
{
  partial class UCInfoClient : UCWizardBase
  {
    private bool? _bCreationSite;
    public bool bCreationSite {
      get {
        return (_bCreationSite == true);
      }
    }

    public List<api_sp_PrixClientContrat_ListePays_Result> ListePaysContrat { get; private set; }

    public UCInfoClient() : this(null, null, null)
    {
    }

    public UCInfoClient(TCLI pTCliEnreg, MULTIEntities pMULTIEntities, COMMUNEntities pCOMMUNEntities) : base(pTCliEnreg, pMULTIEntities, pCOMMUNEntities)
    {
      InitializeComponent();

      // Combo APE
      GLUpCODEAPE.Enabled = false;

      GridCliVille.Properties.DataSource = mCOMMUNEntities.TCOMMUNE.OrderBy(x => x.VILLE).ToList();

      _bCreationSite = null;

      // Init du textBox ville
      txtVille.Font = GridCliVille.Font;
      txtVille.Size = GridCliVille.Size;
      txtVille.Location = GridCliVille.Location;
      txtVille.Visible = false;
      txtVille.Text = "";
      txtVille.TabIndex = GridCliVille.TabIndex;

      ListePaysContrat = new List<api_sp_PrixClientContrat_ListePays_Result>();

      List<TPAYS> lListePays = mCOMMUNEntities.TPAYS.OrderBy(x => x.VPAYSNOM).ToList();

      //System.IO.File.AppendAllText(@"c:\temp\erreurs.log", DateTime.Now + " - " + lListePays.Count + Environment.NewLine);

      GridCliPays.Properties.DataSource = lListePays;
      // Par défaut sélection pays france
      if (lListePays.Count > 0)
      {
        GridCliPays.EditValue = TPAYS.IDPAYS_FRANCE;
      }

      GLUpCODEAPE.Properties.DataSource = mCOMMUNEntities.TREF_SECTEUR.Where(x => x.VCODEAPE != "").OrderBy(x => x.VSECTEUR).ThenBy(x => x.VSOUSACTIVITE).ToList();

      ModuleData.RemplirCombo(cboFiliale, "SELECT NSOCIETEID, VSOCIETE_NOM_USUEL FROM TSOCIETE WHERE VSOCIETEACTIF='O' ORDER BY VSOCIETE_NOM_USUEL", true);
      cboFiliale.ValueMember = "NSOCIETEID";
      cboFiliale.DisplayMember = "VSOCIETE_NOM_USUEL";
      // Sélectionne par défaut la société avec laquelle est lancé le Mozart
      cboFiliale.SelectedValue = mCOMMUNEntities.TSOCIETE.Where(x => x.VSOCIETENOM == MozartParams.NomSociete).First().NSOCIETEID;

      SetInitialFcous();
    }

    public override void SetInitialFcous()
    {
      ActiveControl = TxtCliNom;
    }

    public override bool VerifSaisieChamp()
    {
      int iCliPaysValue;

      if (!ChkBoxParticulier.Checked && !ChkBoxProfessionel.Checked)
      {
        MessageBox.Show("Il faut sélectionner une typologie.", MZCtrlResources.Global_erreur, MessageBoxButtons.OK, MessageBoxIcon.Error);
        return false;
      }

      if (TxtCliNom.Text == "")
      {
        MessageBox.Show("Le nom du client est obligatoire.", MZCtrlResources.Global_erreur, MessageBoxButtons.OK, MessageBoxIcon.Error);

        TxtCliNom.BackColor = Color.Yellow;
        ActiveControl = TxtCliNom;

        return false;
      }

      if (existClient(TxtCliNom.Text, cboFiliale.Text))
      {
        MessageBox.Show($"Un client avec le même nom existe déjà dans la base.{Environment.NewLine}Vérifier que ce n'est pas un doublon.", MZCtrlResources.Global_erreur,
                      MessageBoxButtons.OK, MessageBoxIcon.Error);
        return false;
      }

      if (TxtVCLICP.Text == "")
      {
        MessageBox.Show("Le code postal est obligatoire.", MZCtrlResources.Global_erreur, MessageBoxButtons.OK, MessageBoxIcon.Error);
        return false;
      }

      int.TryParse(GridCliPays.EditValue.ToString(), out iCliPaysValue);

      if ((iCliPaysValue == TPAYS.IDPAYS_FRANCE) && (TxtVCLICP.Text.Length != 5))
      {
        MessageBox.Show("Le code postal est obligatoire.", MZCtrlResources.Global_erreur, MessageBoxButtons.OK, MessageBoxIcon.Error);

        TxtVCLICP.BackColor = Color.Yellow;
        ActiveControl = TxtVCLICP;

        return false;
      }

      if (((GridCliVille.Text == "") && (iCliPaysValue == TPAYS.IDPAYS_FRANCE)) || ((txtVille.Text == "") && (iCliPaysValue != TPAYS.IDPAYS_FRANCE)))
      {
        MessageBox.Show("La ville est obligatoire.", MZCtrlResources.Global_erreur, MessageBoxButtons.OK, MessageBoxIcon.Error);

        if (iCliPaysValue == TPAYS.IDPAYS_FRANCE)
        {
          GridCliVille.BackColor = Color.Yellow;
          ActiveControl = GridCliVille;
        } else
        {
          txtVille.BackColor = Color.Yellow;
          ActiveControl = txtVille;
        }

        return false;
      }

      if (TxtCliActivite.Text == "")
      {
        MessageBox.Show("Le champ activités du client est obligatoire.", MZCtrlResources.Global_erreur, MessageBoxButtons.OK, MessageBoxIcon.Error);

        TxtCliActivite.BackColor = Color.Yellow;
        ActiveControl = TxtCliActivite;

        return false;
      }

      if (_bCreationSite == null)
      {
        MessageBox.Show("Il faut répondre à la demande de création du site client.", MZCtrlResources.Global_erreur, MessageBoxButtons.OK, MessageBoxIcon.Error);

        return false;
      }

      if (ListePaysContrat.Count() == 0)
      {
        MessageBox.Show("Il faut sélectionner au moins un ou des pays pour les contrats.", MZCtrlResources.Global_erreur, MessageBoxButtons.OK, MessageBoxIcon.Error);

        return false;
      }

      // Remplissage de l'objet TCLI
      mTCLIEnreg.VCLINOM = TxtCliNom.Text;
      mTCLIEnreg.VCLIAD1 = TxtVCLIAD1.Text;
      mTCLIEnreg.VCLIAD2 = TxtVCLIAD2.Text;
      mTCLIEnreg.VCLICP = TxtVCLICP.Text;
      if (iCliPaysValue == TPAYS.IDPAYS_FRANCE)
      {
        mTCLIEnreg.VCLIVIL = GridCliVille.Text;
      } else
      {
        mTCLIEnreg.VCLIVIL = txtVille.Text;
      }
      mTCLIEnreg.VCLIPAYS = GridCliPays.Text;
      mTCLIEnreg.VCLICEDEX = TxtVCLICPCEDEX.Text;
      mTCLIEnreg.VCLIACTIVITE = TxtCliActivite.Text;
      mTCLIEnreg.VSOCIETE = mCOMMUNEntities.TSOCIETE.Where(x => x.VSOCIETE_NOM_USUEL == cboFiliale.Text).First().VSOCIETENOM;
      mTCLIEnreg.VCLICODEAPE = GLUpCODEAPE.Text;
      if (ChkBoxProfessionel.Checked)
      {
        mTCLIEnreg.NCLITYPOLOGIE = TCLI.TCLI_TYPOLOGIE_PROFESSIONNEL;
      } else
      {
        mTCLIEnreg.NCLITYPOLOGIE = TCLI.TCLI_TYPOLOGIE_PARTICULIER;
      }

      return true;
    }

    private bool existClient(string pNomCli, string pFiliale)
    {
      try
      {
        // TODO FGB : Voir si il faut pas relire la base pour récupérer cette info
        //int lNb = MozartDatabase.ExecuteScalarInt($"SELECT COUNT(VCLINOM) AS NBCLI FROM TCLI WITH (NOLOCK) WHERE VCLINOM = '{pNomCli}' AND VSOCIETE = '{MozartParams.NomSociete}'");
        TCLI lFirstCliWithSameName = mMULTIEntities.TCLI.Where(x => (x.VCLINOM == pNomCli) && (x.VSOCIETE == pFiliale)).First();

        return (lFirstCliWithSameName != null);
      }
      catch (Exception)
      {
        return false;
      }
    }

    private void BtnCreateSite_Click(object sender, EventArgs e)
    {
      _bCreationSite = sender == BtnCreateSiteTrue;

      if ((bool)_bCreationSite)
      {
        // sender = BtnCreateSiteTrue
        BtnCreateSiteTrue.BackColor = Color.Yellow;
        BtnCreateSiteFalse.BackColor = SystemColors.Window;
      }
      else
      {
        // sender = BtnCreateSiteFalse
        BtnCreateSiteFalse.BackColor = Color.Yellow;
        BtnCreateSiteTrue.BackColor = SystemColors.Window;
      }

      // TODO FGB : Voir si nécessaire de le garder //  frmMasterWizardClient.BtnNext.PerformClick()
    }

    private void GridCliPays_EditValueChanged(object sender, EventArgs e)
    {
      GridCliVille.Visible = ((int) GridCliPays.EditValue) == TPAYS.IDPAYS_FRANCE;
      txtVille.Visible = !GridCliVille.Visible;
    }

    private void txtVille_TextChanged(object sender, EventArgs e)
    {
      if (txtVille.Text != "")
      {
        txtVille.BackColor = SystemColors.Window;
      }
    }

    private void txtVille_Leave(object sender, EventArgs e)
    {
      txtVille.Text = txtVille.Text.ToUpper();
    }

    private void TxtVCLICP_TextChanged(object sender, EventArgs e)
    {
      if (TxtVCLICP.Text != "")
      {
        TxtVCLICP.BackColor = SystemColors.Window;
      }

      // PAYS = FRANCE
      if (GridCliPays.EditValue != null)
      {
        int iCliPaysValue = 0;

        int.TryParse(GridCliPays.EditValue.ToString(), out iCliPaysValue);
        if (iCliPaysValue == TPAYS.IDPAYS_FRANCE)
        {
          List<TCOMMUNE> lFoundVilles = mCOMMUNEntities.TCOMMUNE.Where(x => x.CODEPOSTAL.StartsWith(TxtVCLICP.Text.Replace("'", "''"))).ToList();
          if (lFoundVilles.Count == 0)
          {
            MessageBox.Show("Il n'existe pas de villes avec ce code postal.", "", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);

            return;
          }

          GridCliVille.Properties.DataSource = lFoundVilles;

          if (TxtVCLICP.Text == "")
          {
            GridCliVille.EditValue = null;
          }
          else
          {
            GridCliVille.EditValue = lFoundVilles.First().VILLE;
          }
        }
      }
    }

    private void GVVille_RowClick(object sender, DevExpress.XtraGrid.Views.Grid.RowClickEventArgs e)
    {
      if (e.Button == MouseButtons.Left)
      {
        TxtVCLICP.Text = ((TCOMMUNE)GVVille.FocusedRowObject).CODEPOSTAL;
      }
    }

    private void TxtCliNom_EditValueChanged(object sender, EventArgs e)
    {
      if (TxtCliNom.Text != "")
      {
        TxtCliNom.Text = TxtCliNom.Text.ToUpper();
        TxtCliNom.BackColor = SystemColors.Window;
      }
    }

    private void TxtCliActivite_TextChanged(object sender, EventArgs e)
    {
      if (TxtCliActivite.Text != "")
      {
        TxtCliActivite.BackColor = SystemColors.Window;
      }
    }

    private void GridCliVille_EditValueChanged(object sender, EventArgs e)
    {
      if (GridCliVille.Text != "")
      {
        GridCliVille.BackColor = SystemColors.Window;
      }
    }

    private void BtnPaysIntervention_Click(object sender, EventArgs e)
    {
      try
      {
        Cursor.Current = Cursors.WaitCursor;

        frmPrixClientContratPays_ListePays lFrm = new frmPrixClientContratPays_ListePays(0)
        {
          DtPays = ListePaysContrat
        };

        if (lFrm.ShowDialog() != DialogResult.Cancel)
        {
          ListePaysContrat = lFrm.DtPays.Where(x => x.BPAYSSELECT == 1).ToList();

          if (ListePaysContrat.Count() > 0)
          {
            lblPaysContratSelected.Text = $"{ListePaysContrat.Count()} pays sélectionné(s)";
          }
        }
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

    private void ChkBoxTypologie_CheckedChanged(object sender, EventArgs e)
    {
      GLUpCODEAPE.Enabled = ChkBoxProfessionel.Checked;
    }
  }
}
