using MozartCS.Properties;
using MozartLib;
using MozartNet;
using MozartUC;
using System;
using System.Data;
using System.Data.SqlClient;
using System.Reflection;
using System.Windows.Forms;
using MZUtils = MozartControls.Utils;


namespace MozartCS
{
  public partial class frmDetailsContact : Form
  {
    public string mstrStatut;
    public long miNumContact;
    public long miNumClient;

    public frmDetailsContact()
    {
      InitializeComponent();
    }

    private void frmDetailsContact_Load(object sender, System.EventArgs e)
    {
      try
      {
        ModuleMain.Initboutons(this);

        ModuleData.RemplirCombo(cboPays, "select NPAYSNUM, VPAYSNOM from TPAYS order by VPAYSNOM");
        cboPays.ValueMember = "NPAYSNUM";
        cboPays.DisplayMember = "VPAYSNOM";
        ModuleData.RemplirCombo(CboRapportFM, $"SELECT  NIDRAPPORT_FM, VTYPE_RAPPORT_FM FROM TREF_RAPPORT_FM WHERE BTYPE_RAPPORT_FM_ACTIF = 1 ORDER BY VTYPE_RAPPORT_FM");
        CboRapportFM.ValueMember = "NIDRAPPORT_FM";
        CboRapportFM.DisplayMember = "VTYPE_RAPPORT_FM";

        //traitement du cas de modification ou de création
        if (mstrStatut == "C")
          OuvertureEnCreation();
        else
          OuvertureEnModification();

        if (ModuleMain.RechercheDroitMenu(533))
        {
          cboStat.Visible = true;
          lblStat.Visible = true;
          lblMailing.Visible = true;
          cboMail.Visible = true;
        }
      }
      catch (Exception ex)
      {
        MZUtils.displayError(MethodBase.GetCurrentMethod().Name, ex);
      }
    }

    private void cmdEnregistrer_Click(object sender, EventArgs e)
    {
      //test du nom
      if (txtNom.Text == "")
      {
        MessageBox.Show(Resources.msg_SaisirNomContact);
        txtNom.Focus();
      }
      //test du pays
      if (cboPays.Text == "")
      {
        MessageBox.Show(Resources.msg_SaisirPaysContact);
        cboPays.Focus();
      }
      //a la creation on verifie que le contact n'existe pas
      if (miNumContact == 0)
      {
        if (0 < (int)ModuleData.ExecuteScalarInt($"SELECT COUNT(*) FROM TCCL WHERE UPPER(VCCLNOM) = UPPER('{txtNom.Text.Replace("'", "''")}') AND UPPER(VCCLPRE) = UPPER('{txtprenom.Text.Replace("'", "''")}') AND NCLINUM = " + miNumClient))
        {
          if (MessageBox.Show(Resources.msg_ConfirmContactAlreadyExist, Program.AppTitle, MessageBoxButtons.YesNo,
                          MessageBoxIcon.Question, MessageBoxDefaultButton.Button2) == DialogResult.No)
          {
            return;
          }
        }
      }
      MozartUcUtils.SpyLog(MozartDatabase.cnxMozart, "", cmdEnregistrer.Tag.ToString(), "Modification", "NCCLNUM:" + miNumContact);
      Enregistrer();

      //on passe la feuille en statut modifier
      mstrStatut = "M";
      OuvertureEnModification();
    }

    private void cmdRecherche_Click(object sender, EventArgs e)
    {
      new frmRechCodePostal
      {
        ControlCible1 = txtCP,
        ControlCible2 = cboVille
      }.ShowDialog();
    }

    private void OuvertureEnCreation()
    {
      try
      {
        //renseignement de la partie client
        cboDevis.Text = "NON";
        cboAttest.Text = "NON";
        cboAdmin.Text = "NON";
        cboStat.Text = "NON";
        cboMail.Text = "NON";
        cboFact.Text = "NON";
        cboRel.Text = "NON";
        cboCiv.Text = "M.";

        //reprise de l'adresse sur le client
        using (SqlDataReader pRS = ModuleData.ExecuteReader($"select * from TCLI where NCLINUM={miNumClient}"))
        {
          if (pRS.Read())
          {
            txtAD1.Text = Utils.BlankIfNull(pRS["VCLIAD1"]);
            txtAD2.Text = Utils.BlankIfNull(pRS["VCLIAD2"]);

            txtCP.Text = Utils.BlankIfNull(pRS["VCLICPCEDEX"]) == "" ? Utils.BlankIfNull(pRS["VCLICP"]) : Utils.BlankIfNull(pRS["VCLICPCEDEX"]);
            txtVille.Text = Utils.BlankIfNull(pRS["VCLIVIL"]);
            txtCedex.Text = Utils.BlankIfNull(pRS["VCLICEDEX"]);

            //combo de la ville
            string ville = Utils.BlankIfNull(pRS["VCLIVIL"]);
            cboVille.Text = ville;
            if (cboVille.SelectedIndex == -1)
            {
              cboVille.Items.Add(ville);
              cboVille.Text = ville;
            }

            //combo du pays
            string pays = Utils.BlankIfNull(pRS["VCLIPAYS"]);
            cboPays.Text = pays;
            if (cboPays.SelectedIndex == -1)
            {
              cboPays.Items.Add(pays);
              cboPays.Text = pays;
            }

            cboPays_SelectedIndexChanged(null, null);
          }
        }
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
        using (SqlDataReader pRS = ModuleData.ExecuteReader($"select * from api_v_InfoContact where NCCLNUM={miNumContact}"))
        {
          if (pRS.Read())
          {
            txtNom.Text = Utils.BlankIfNull(pRS["VCCLNOM"]);
            txtprenom.Text = Utils.BlankIfNull(pRS["VCCLPRE"]);
            txtFonction.Text = Utils.BlankIfNull(pRS["VCCLFONC"]);

            txtAD1.Text = Utils.BlankIfNull(pRS["VCCLAD1"]);
            txtAD2.Text = Utils.BlankIfNull(pRS["VCCLAD2"]);
            txtCP.Text = Utils.BlankIfNull(pRS["VCCLCP"]);
            txtVille.Text = Utils.BlankIfNull(pRS["VCCLVIL"]);
            txtCedex.Text = Utils.BlankIfNull(pRS["VCCLCEDEX"]);

            txtTel.Text = Utils.BlankIfNull(pRS["VCCLTEL"]);
            txtFax.Text = Utils.BlankIfNull(pRS["VCCLFAX"]);
            txtMail.Text = Utils.BlankIfNull(pRS["VCCLMAIL"]);
            txtPort.Text = Utils.BlankIfNull(pRS["VINTPOR"]);

            cboCiv.Text = Utils.BlankIfNull(pRS["CCCLCIV"]);
            if (cboCiv.SelectedIndex == -1) cboCiv.Text = "M.";

            cboDevis.Text = Utils.BlankIfNull(pRS["VCCLDEVIS"]);
            if (cboDevis.SelectedIndex == -1) cboDevis.Text = "NON";

            cboAttest.Text = Utils.BlankIfNull(pRS["VCCLATT"]);
            if (cboAttest.SelectedIndex == -1) cboAttest.Text = "NON";

            cboAdmin.Text = Utils.BlankIfNull(pRS["VCCLDEVISDEF"]);
            if (cboAdmin.SelectedIndex == -1) cboAdmin.Text = "NON";

            cboStat.Text = Utils.BlankIfNull(pRS["VCCLSTAT"]);
            if (cboStat.SelectedIndex == -1) cboStat.Text = "NON";

            cboMail.Text = Utils.BlankIfNull(pRS["VCCLMAILING"]);
            if (cboMail.SelectedIndex == -1) cboMail.Text = "NON";

            //combo de la facturation
            cboFact.Text = Utils.BlankIfNull(pRS["VCCLMAILFAC"]);
            if (cboFact.SelectedIndex == -1) cboFact.Text = "NON";

            cboRel.Text = Utils.BlankIfNull(pRS["VCCLMAILREL"]);
            if (cboRel.SelectedIndex == -1) cboRel.Text = "NON";

            // combo de la rapport fm
            CboRapportFM.Text = Utils.BlankIfNull(pRS["NIDRAPPORT_FM"]);

            //combo de la ville
            string ville = Utils.BlankIfNull(pRS["VCCLVIL"]);
            cboVille.Text = ville;
            if (cboVille.SelectedIndex == -1)
            {
              cboVille.Items.Add(ville);
              cboVille.Text = ville;
            }

            //combo du pays
            string pays = Utils.BlankIfNull(pRS["VCCLPAYS"]);
            cboPays.Text = pays;
            if (cboPays.SelectedIndex == -1)
            {
              cboPays.Items.Add(pays);
              cboPays.Text = pays;
            }

            cboPays_SelectedIndexChanged(null, null);
          }
        }
      }
      catch (Exception ex)
      {
        MZUtils.displayError(MethodBase.GetCurrentMethod().Name, ex);
      }
    }

    private void Enregistrer()
    {
      try
      {
        //pour la création ou la modification, c'est la proc stock qui gère
        //test de la combo doc administratif
        if (!DocAdminOK() && cboAdmin.Text == "OUI")
        {
          MessageBox.Show(Resources.msg_Can_only_choose_one_dest_doc_adm_per_client + "\r\n" +
            Resources.msg_If_Contact_be_recepient_of_adm_doc_uncheck_contact, Program.AppTitle, MessageBoxButtons.OK, MessageBoxIcon.Information);
        }
        //création d'une commande
        using (SqlCommand cmd = new SqlCommand("api_sp_creationContact", MozartDatabase.cnxMozart))
        {
          cmd.CommandType = CommandType.StoredProcedure;
          SqlCommandBuilder.DeriveParameters(cmd);    // liste des paramètres

          cmd.Parameters["@iNum"].Value = miNumContact;   // 0 si création
          cmd.Parameters["@iClient"].Value = miNumClient;
          cmd.Parameters["@vNom"].Value = txtNom.Text.ToUpper();
          cmd.Parameters["@vPrenom"].Value = txtprenom.Text;
          cmd.Parameters["@vCiv"].Value = cboCiv.Text;
          cmd.Parameters["@vFonction"].Value = txtFonction.Text;

          cmd.Parameters["@vAd1"].Value = txtAD1.Text;
          cmd.Parameters["@vAd2"].Value = txtAD2.Text;
          cmd.Parameters["@vCp"].Value = txtCP.Text;
          cmd.Parameters["@vVille"].Value = cboPays.Text == "FRANCE" ? cboVille.Text : txtVille.Text;
          cmd.Parameters["@vPays"].Value = cboPays.Text;
          cmd.Parameters["@vCedex"].Value = txtCedex.Text;

          cmd.Parameters["@vTel"].Value = txtTel.Text;
          cmd.Parameters["@vFax"].Value = txtFax.Text;
          cmd.Parameters["@vPort"].Value = txtPort.Text;
          cmd.Parameters["@vMail"].Value = txtMail.Text;

          cmd.Parameters["@vDevis"].Value = cboDevis.Text;
          cmd.Parameters["@vAttest"].Value = cboAttest.Text;
          cmd.Parameters["@vdefaut"].Value = cboAdmin.Text;
          cmd.Parameters["@vStat"].Value = cboStat.Text;
          cmd.Parameters["@iFact"].Value = 0;
          cmd.Parameters["@vMailing"].Value = cboMail.Text;
          cmd.Parameters["@vMailFact"].Value = cboFact.Text;
          cmd.Parameters["@vMailRelance"].Value = cboRel.Text;

          cmd.ExecuteNonQuery();
          //récupération du numéro crée
          miNumContact = (int)cmd.Parameters[0].Value;

        }
        //  ********************************************************************************************************************************************************
        //  on enregitre le rapport fm
        //  passage du nom de la procédure stockée
        using (SqlCommand cmd = new SqlCommand("[api_sp_creationContactRapportFM]", MozartDatabase.cnxMozart))
        {
          cmd.CommandType = CommandType.StoredProcedure;
          SqlCommandBuilder.DeriveParameters(cmd);

          cmd.Parameters["@p_ncclnum"].Value = miNumContact;   // 0 si création
          cmd.Parameters["@p_nidrapport_fm"].Value = CboRapportFM.Text == "" ? 0 : CboRapportFM.GetItemData();
          cmd.ExecuteNonQuery();
        }
      }
      catch (Exception ex)
      {
        MZUtils.displayError(MethodBase.GetCurrentMethod().Name, ex);
      }
    }

    private void txtCP_TextChanged(object sender, EventArgs e)
    {
      if (txtCP.Text.Length > 1 && cboPays.Text == "FRANCE")
      {
        ModuleMain.RechercheCommune(txtCP.Text, cboVille);
      }
    }

    private bool DocAdminOK()
    {
      int rs;

      if (miNumContact == 0)
        rs = (int)ModuleData.ExecuteScalarInt($"select count(ncclnum) from TCCL where NCLINUM= {miNumClient} AND VCCLDEVISDEF = 'OUI'");
      else
        rs = (int)ModuleData.ExecuteScalarInt($"select count(ncclnum) from TCCL where NCLINUM= {miNumClient} AND VCCLDEVISDEF = 'OUI' AND NCCLNUM <> {miNumContact}");

      if (rs == 0)
        return true;

      return false;
    }


    private void cboPays_SelectedIndexChanged(object sender, EventArgs e)
    {
      if (cboPays.Text != "FRANCE")
      {
        cboVille.Visible = false;
        txtVille.Visible = true;
        cmdRecherche.Visible = false;
      }
      else
      {
        cboVille.Visible = true;
        txtVille.Visible = false;
        cmdRecherche.Visible = true;
      }
    }

    private void txtVille_Leave(object sender, EventArgs e)
    {
      txtVille.Text = txtVille.Text.ToUpper();
    }

    private void cmdFermer_Click(object sender, System.EventArgs e)
    {
      Dispose();
    }


  }
}

