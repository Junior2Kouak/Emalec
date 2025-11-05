using DevExpress.XtraEditors;
using MozartLib;
using MozartNet;
using System;
using System.Collections.Generic;
using System.Data;
using System.Data.Entity;
using System.Drawing;
using System.Linq;
using System.Windows.Forms;
using MZCtrlResources = MozartControls.Properties.Resources;
using MZUtils = MozartControls.Utils;

namespace MozartCS
{
  partial class UCRSFFactuClient : UCWizardBase
  {
    private List<TCOMMUNE> mListeCommunes;

    public TRSF RSF { get; set; }

    public UCRSFFactuClient() : this(null, null, null)
    {
    }

    public UCRSFFactuClient(TCLI pTCliEnreg, MULTIEntities pMULTIEntities, COMMUNEntities pCOMMUNEntities) : base(pTCliEnreg, pMULTIEntities, pCOMMUNEntities)
    {
      InitializeComponent();

      // Init du textBox ville
      txtVille.Font = GridRSFVille.Font;
      txtVille.Size = GridRSFVille.Size;
      txtVille.Location = GridRSFVille.Location;
      txtVille.Visible = false;
      txtVille.Text = "";
      txtVille.TabIndex = GridRSFVille.TabIndex;

      TxtRSFServ.Text = "Comptabilité fournisseurs";

      LoadDataCbo();
    }

    public override void SetInitialFcous()
    {
      ActiveControl = TxtRSFNom;
    }

    public override bool VerifSaisieChamp()
    {
      // Nom
      if (TxtRSFNom.Text == "")
      {
        MessageBox.Show("Il faut saisir un nom de raison sociale.", MZCtrlResources.Global_erreur, MessageBoxButtons.OK, MessageBoxIcon.Error);

        TxtRSFNom.BackColor = Color.Yellow;
        ActiveControl = TxtRSFNom;

        return false;
      }

      // Service
      if (TxtRSFServ.Text == "")
      {
        MessageBox.Show("Il faut saisir un nom de service.", MZCtrlResources.Global_erreur, MessageBoxButtons.OK, MessageBoxIcon.Error);

        TxtRSFServ.BackColor = Color.Yellow;
        ActiveControl = TxtRSFServ;

        return false;
      }

      // CP
      if (TxtRSFCP.Text == "")
      {
        MessageBox.Show("Le code postal est obligatoire.", MZCtrlResources.Global_erreur, MessageBoxButtons.OK, MessageBoxIcon.Error);

        TxtRSFCP.BackColor = Color.Yellow;
        ActiveControl = TxtRSFCP;

        return false;
      }

      int iIdPays = (int)GridRSFPays.EditValue;
      if ((iIdPays == TPAYS.IDPAYS_FRANCE) && (TxtRSFCP.Text.Length != 5))
      {
        MessageBox.Show("Le code postal n'est conforme !", MZCtrlResources.Global_erreur, MessageBoxButtons.OK, MessageBoxIcon.Error);

        TxtRSFCP.BackColor = Color.Yellow;
        ActiveControl = TxtRSFCP;

        return false;
      }

      if (mTCLIEnreg.NCLITYPOLOGIE == TCLI.TCLI_TYPOLOGIE_PROFESSIONNEL)
      {
        // Vérif Code TVA
        if (TxtRSFTVAIntra.Text == "")
        {
          MessageBox.Show(MZCtrlResources.msg_enter_TVA, MZCtrlResources.Global_erreur, MessageBoxButtons.OK, MessageBoxIcon.Error);

          TxtRSFTVAIntra.BackColor = Color.Yellow;
          ActiveControl = TxtRSFTVAIntra;

          return false;
        }
        if (!MZUtils.VerifTVAIntra(TxtRSFTVAIntra.Text, mTCLIEnreg.VCLIPAYS))
        {
          new frmWizardClientMessageTVAIntra().ShowDialog();

          TxtRSFTVAIntra.BackColor = Color.Yellow;
          ActiveControl = TxtRSFTVAIntra;

          // TODO FGB : Voir si il faut sortir ou pas: Non dans code origine ??!!
          return false;
        }

        // Vérif code SIRET
        if (TxtSIRET.Text == "")
        {
          MessageBox.Show("Il faut saisir une N° SIRET.", MZCtrlResources.Global_erreur, MessageBoxButtons.OK, MessageBoxIcon.Error);

          TxtSIRET.BackColor = Color.Yellow;
          ActiveControl = TxtSIRET;

          return false;
        }

        if ((mTCLIEnreg.VCLIPAYS == TPAYS.STR_PAYS_FRANCE) && !ModuleMain.VerifSIRET(TxtSIRET.Text))
        {
          MessageBox.Show("Le format du N° SIRET n'est pas conforme.", MZCtrlResources.Global_erreur, MessageBoxButtons.OK, MessageBoxIcon.Error);

          TxtSIRET.BackColor = Color.Yellow;
          ActiveControl = TxtSIRET;

          return false;
        }
      }

      // Règlement
      // Par
      if (CboRSFTyp.Text == "")
      {
        MessageBox.Show("Il faut sélectionner un mode de réglement.", MZCtrlResources.Global_erreur, MessageBoxButtons.OK, MessageBoxIcon.Error);

        CboRSFTyp.BackColor = Color.Yellow;
        ActiveControl = CboRSFTyp;

        return false;
      }
      // Echéance
      if (cboRSFNBJ.Text == "")
      {
        MessageBox.Show("Il faut sélectionner une échéance.", MZCtrlResources.Global_erreur, MessageBoxButtons.OK, MessageBoxIcon.Error);

        cboRSFNBJ.BackColor = Color.Yellow;
        ActiveControl = cboRSFNBJ;

        return false;
      }
      // Fin de mois
      if (cboRSFFin.Text == "")
      {
        MessageBox.Show("Il faut sélectionner un réglement en fin de mois.", MZCtrlResources.Global_erreur, MessageBoxButtons.OK, MessageBoxIcon.Error);

        cboRSFFin.BackColor = Color.Yellow;
        ActiveControl = cboRSFFin;

        return false;
      }

      // Remplissage de l'objet TRSF
      RSF = new TRSF
      {
        VRSFRSF = TxtRSFNom.Text,
        VRSFSER = TxtRSFServ.Text,
        VRSFAD1 = TxtRSFAD1.Text,
        VRSFAD2 = TxtRSFAD2.Text,
        VRSFCP = TxtRSFCP.Text,
        CRSFACTIF = "O",
        VRSFTYP = CboRSFTyp.Text,
        VRSFECH = cboRSFNBJ.Text,
        NRSFNBJ = (int)cboRSFNBJ.EditValue,
        NRSFFIN = cboRSFFin.Text,
        VRSFSIRET = TxtSIRET.Text,
        VRSFPAYS = GridRSFPays.Text,
        VRSFVIL = (iIdPays == TPAYS.IDPAYS_FRANCE) ? GridRSFVille.Text : txtVille.Text,
        VRSFREGION = "",
        VRSFMAI = "",
        VRSFTVAINTRA = TxtRSFTVAIntra.Text,
        VRSFLANGUE = "FR",
        VRSFCPT8 = "",
        NIDBANQUE = mCOMMUNEntities.TREF_BANQUE.First<TREF_BANQUE>(x => (x.VSOCIETE == mTCLIEnreg.VSOCIETE) && (x.BBANQUEDEFAULT == true)).NIDBANQUE,
        BFILIALEEMALEC = false,
        TCLI = mTCLIEnreg
      };
      if (txtRSFSup.Text == "")
      {
        RSF.NRSFSUP = null;
      }
      else
      {
        RSF.NRSFSUP = Convert.ToInt32(txtRSFSup.Text);
      }

      return true;
    }

    private void LoadDataCbo()
    {
      mListeCommunes = mCOMMUNEntities.TCOMMUNE.OrderBy(x => x.VILLE).ToList();
      GridRSFVille.Properties.DataSource = mListeCommunes;

      List<TPAYS> lListePays = mCOMMUNEntities.TPAYS.OrderBy(x => x.VPAYSNOM).ToList();
      GridRSFPays.Properties.DataSource = lListePays;
      // Par défaut sélection pays france
      if (lListePays.Count > 0)
      {
        GridRSFPays.EditValue = TPAYS.IDPAYS_FRANCE;
      }

      // RSF Type
      CboRSFTyp.Properties.DataSource = mMULTIEntities.api_sp_ComboRSFListeType().ToList();
      // RSF Nb Jours
      cboRSFNBJ.Properties.DataSource = mMULTIEntities.api_sp_ComboRSFListeNBJ().ToList();
      // RSF Fin de mois
      cboRSFFin.Properties.DataSource = mMULTIEntities.api_sp_ComboRSFListeFinMois().ToList();
    }

    private void TxtRSFTVAIntra_Leave(object sender, EventArgs e)
    {
      TxtRSFTVAIntra.Text = TxtRSFTVAIntra.Text.ToUpper();
    }

    private void Event_EditValueChanged(object sender, EventArgs e)
    {
      GridLookUpEdit lSender = (GridLookUpEdit)sender;

      if (lSender.Text != "")
      {
        lSender.BackColor = SystemColors.Window;
      }
    }

    private void TextBox_TextChanged(object sender, EventArgs e)
    {
      TextBox lSender = (TextBox)sender;

      if (lSender.Text != "")
      {
        lSender.BackColor = SystemColors.Window;
      }
    }

    private void TxtRSFNom_EditValueChanged(object sender, EventArgs e)
    {
      TxtRSFNom.Text = TxtRSFNom.Text.ToUpper();
      if (TxtRSFNom.Text != "")
      {
        TxtRSFNom.BackColor = SystemColors.Window;
      }
    }

    private void txtVille_Leave(object sender, EventArgs e)
    {
      txtVille.Text = txtVille.Text.ToUpper();
    }

    private void GridRSFPays_EditValueChanged(object sender, EventArgs e)
    {
      GridRSFVille.Visible = ((int)GridRSFPays.EditValue) == TPAYS.IDPAYS_FRANCE;
      txtVille.Visible = !GridRSFVille.Visible;
    }

    private void txtVille_TextChanged(object sender, EventArgs e)
    {
      if (txtVille.Text != "")
      {
        txtVille.BackColor = SystemColors.Window;
      }
    }

    private void TxtRSFCP_TextChanged(object sender, EventArgs e)
    {
      if (TxtRSFCP.Text != "")
      {
        TxtRSFCP.BackColor = SystemColors.Window;
      }

      // PAYS = FRANCE
      if (((int)GridRSFPays.EditValue) == TPAYS.IDPAYS_FRANCE)
      {
        List<TCOMMUNE> lFoundVilles = mListeCommunes.Where(x => x.CODEPOSTAL.StartsWith(TxtRSFCP.Text.Replace("'", "''"))).ToList();
        if (lFoundVilles.Count == 0)
        {
          MessageBox.Show("Il n'existe pas de villes avec ce code postal.", "", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);

          return;
        }

        GridRSFVille.Properties.DataSource = lFoundVilles;

        if (TxtRSFCP.Text == "")
        {
          GridRSFVille.EditValue = null;
        }
        else
        {
          GridRSFVille.EditValue = lFoundVilles.First().VILLE;
        }
      }
    }

    private void GVVille_RowClick(object sender, DevExpress.XtraGrid.Views.Grid.RowClickEventArgs e)
    {
      if (e.Button == MouseButtons.Left)
      {
        TxtRSFCP.Text = ((TCOMMUNE)GVVille.FocusedRowObject).CODEPOSTAL;
      }
    }

    private void GridRSFVille_EditValueChanged(object sender, EventArgs e)
    {
      if (GridRSFVille.Text != "")
      {
        GridRSFVille.BackColor = SystemColors.Window;
      }
    }
  }
}
