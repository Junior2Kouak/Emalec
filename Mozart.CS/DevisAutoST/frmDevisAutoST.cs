using Microsoft.VisualBasic;
using MozartCS.Properties;
using MozartLib;
using MozartNet;
using ReportEmalec.Net;
using System;
using System.Data;
using System.Data.SqlClient;
using System.Reflection;
using System.Windows.Forms;
using MZUtils = MozartControls.Utils;

namespace MozartCS
{
  public partial class frmDevisAutoST : Form
  {
    public string mstrStatutDevis;
    public long miNumDevisST;
    public int mstrPPS;
    public bool bDesactive;

    private bool mbModif;

    public frmDevisAutoST() { InitializeComponent(); }

    private void frmDevisAutoST_Load(object sender, System.EventArgs e)
    {
      try
      {
        Cursor.Current = Cursors.WaitCursor;
        ModuleMain.Initboutons(this);

        InitialiserFeuille();
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

    private void cmdFermer_Click(object sender, System.EventArgs e)
    {
      try
      {
        //  ' si il y a des modification
        if (mbModif)
        {
          switch (MessageBox.Show(Resources.msgConfirm_enregistrerModif, Program.AppTitle, MessageBoxButtons.YesNoCancel, MessageBoxIcon.Question, MessageBoxDefaultButton.Button2))
          {
            case DialogResult.Yes:
              EnregistrerDevisST();
              Dispose();
              break;
            case DialogResult.No:
              Dispose();
              break;
            case DialogResult.Cancel:
              return;
          }
        }
        else
          Dispose();
      }
      catch (Exception ex)
      {
        MZUtils.displayError(MethodBase.GetCurrentMethod().Name, ex);
      }
      Dispose();
    }

    private void cmdValider_Click(object sender, EventArgs e)
    {
      try
      {
        if (txtAction.Text == "")
        {
          MessageBox.Show(Resources.msg_Entrez_action_dans_zone_presta);
          txtAction.Focus();
          return;
        }
        if (txtNbrPage.Text == "")
        {
          MessageBox.Show(Resources.msg_Entrez_nombre_page_valide);
          txtNbrPage.Focus();
          return;
        }
        if (txtDateRetour.Text == "")
        {
          MessageBox.Show(Resources.msg_Saisir_date_reception);
          return;
        }

        EnregistrerDevisST();

        // FGA le 23/11/21 affichage fenetre de notation
        new frmNotationSTT(MozartParams.NumAction).ShowDialog();

        mbModif = false;
      }
      catch (Exception ex)
      {
        MZUtils.displayError(MethodBase.GetCurrentMethod().Name, ex);
      }
    }

    private void cmdImprimer_Click(object sender, EventArgs e)
    {
      try
      {
        if (miNumDevisST == 0)
        {
          MessageBox.Show(Resources.msg_Impression_impossible_enregistrer_devis, Program.AppTitle, MessageBoxButtons.OK, MessageBoxIcon.Information);
          return;
        }
        else
        {
          // test si ST est un ST avzec Accès Web
          if (ModuleMain.TestIfSTWithAccessWEB("DS", miNumDevisST) == true)
          {
            if (MessageBox.Show(Resources.msg_Warning_impr_doc_non_obligatoire_ST_a_acces_web
              , Program.AppTitle, MessageBoxButtons.YesNo, MessageBoxIcon.Question, MessageBoxDefaultButton.Button2) == DialogResult.No)
              return;
          }

          Cursor.Current = Cursors.WaitCursor;

          new frmMainReport
          {
            bLaunchByProcessStart = false,
            sTypeReport = "TDemandeDevisST",
            sIdentifiant = $"{MozartParams.NumAction}|{miNumDevisST}",
            InfosMail = $"TINT|NINTNUM|{txtSTContact.Tag}",
            sNomSociete = MozartParams.NomSociete,
            sLangue = Strings.Left(Utils.GetLanguePays("TSTF", "VLANGUEABR", "NSTFNUM", txtSTNom.Tag.ToString()), 2),
            sOption = "PRINT",
            strType = "DS",
            numAction = MozartParams.NumAction
          }.ShowDialog();
        }
      }
      catch (Exception ex)
      {
        MZUtils.displayError(MethodBase.GetCurrentMethod().Name, ex);
      }
      finally { Cursor.Current = Cursors.Default; }
    }

    private void cmdVisu_Click(object sender, EventArgs e)
    {
      try
      {
        if (miNumDevisST == 0)
        {
          MessageBox.Show(Resources.msg_Impression_impossible_enregistrer_devis, Program.AppTitle, MessageBoxButtons.OK, MessageBoxIcon.Information);
          return;
        }
        else
        {
          Cursor.Current = Cursors.WaitCursor;

          new frmMainReport
          {
            bLaunchByProcessStart = false,
            sTypeReport = "TDemandeDevisST",
            sIdentifiant = $"{MozartParams.NumAction}|{miNumDevisST}",
            InfosMail = $"TINT|NINTNUM|{txtSTContact.Tag}",
            sNomSociete = MozartParams.NomSociete,
            sLangue = Strings.Left(Utils.GetLanguePays("TSTF", "VLANGUEABR", "NSTFNUM", txtSTNom.Tag.ToString()), 2),
            sOption = "PREVIEW",
            strType = "DS",
            numAction = MozartParams.NumAction
          }.ShowDialog();
        }
      }
      catch (Exception ex)
      {
        MZUtils.displayError(MethodBase.GetCurrentMethod().Name, ex);
      }
      finally { Cursor.Current = Cursors.Default; }
    }

    private void cmdPPS_Click(object sender, EventArgs e)
    {
      try
      {
        if (miNumDevisST == 0)
        {
          MessageBox.Show(Resources.msg_Impression_impossible_enregistrer_devis, Program.AppTitle, MessageBoxButtons.OK, MessageBoxIcon.Information);
          return;
        }

        Cursor.Current = Cursors.WaitCursor;

        new frmMainReport
        {
          bLaunchByProcessStart = false,
          sTypeReport = "TPPS_NUMACT",
          sIdentifiant = $"{MozartParams.NumAction}",
          InfosMail = $"TINT|NINTNUM|{txtSTContact.Tag}",
          sNomSociete = MozartParams.NomSociete,
          sLangue = $"{Strings.Left(Utils.GetLanguePays("TSTF", "VLANGUEABR", "NSTFNUM", txtSTNom.Tag.ToString()), 2)}",
          sOption = "PREVIEW",
          strType = "PPS",
          numAction = MozartParams.NumAction
        }.ShowDialog();
      }
      catch (Exception ex)
      {
        MZUtils.displayError(MethodBase.GetCurrentMethod().Name, ex);
      }
      finally { Cursor.Current = Cursors.Default; }
    }

    private void cmdDate_Click(object sender, EventArgs e)
    {
      if (Calendar1.Visible)
        Calendar1.Visible = false;
      else
      {
        Calendar1.Value = DateTime.Now;
        Calendar1.Visible = true;
      }
    }

    private async void ApiTelAuto1_Click(object sender, EventArgs e)
    {
      //ApiTelAuto1.TelDial(txtCliTel.Text);
            if (txtCliTel.Text != "") 
            {
                string reponse = await CNumerotationAuto.MakeCallByAvaya(MozartParams.UserTelInt, txtCliTel.Text, Environment.MachineName);
                if (reponse != "OK")
                {
                    MessageBox.Show(reponse, Program.AppTitle, MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
        }

    private async void ApiTelAuto2_Click(object sender, EventArgs e)
    {
      //ApiTelAuto1.TelDial(txtSTTel.Text);
            if (txtSTTel.Text != "")
            {
                string reponse = await CNumerotationAuto.MakeCallByAvaya(MozartParams.UserTelInt, txtSTTel.Text, Environment.MachineName);
                if (reponse != "OK")
                {
                    MessageBox.Show(reponse, Program.AppTitle, MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
        }

    private async void ApiTelAuto3_Click(object sender, EventArgs e)
    {
      //ApiTelAuto1.TelDial(txtSTPortable.Text);
            if (txtSTPortable.Text != "")
            {
                string reponse = await CNumerotationAuto.MakeCallByAvaya(MozartParams.UserTelInt, txtSTPortable.Text, Environment.MachineName);
                if (reponse != "OK")
                {
                    MessageBox.Show(reponse, Program.AppTitle, MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
        }

    private void Calendar1_ValueChanged(object sender, EventArgs e)
    {
      txtDateRetour.Text = Calendar1.Value.ToString();
    }

    private void frmDevisAutoST_KeyPress(object sender, KeyPressEventArgs e)
    {
      mbModif = true;
    }

    private void EnregistrerDevisST()
    {
      try
      {
        //  pour la création ou la modification, c'est la proc stock qui gère
        //  création d'une commande
        using (SqlCommand cmd = new SqlCommand("api_sp_creationDevisST", MozartDatabase.cnxMozart))
        {
          cmd.CommandType = CommandType.StoredProcedure;
          SqlCommandBuilder.DeriveParameters(cmd);    // liste des paramètres

          //  liste des paramètres
          cmd.Parameters["@iDevis"].Value = miNumDevisST;
          cmd.Parameters["@iAction"].Value = MozartParams.NumAction;
          cmd.Parameters["@LibAction"].Value = ModuleMain.ReplaceCharToBD(txtAction.Text, "RTF");
          cmd.Parameters["@dDateR"].Value = txtDateRetour.Text != "" ? txtDateRetour.Text : (object)DBNull.Value;
          cmd.Parameters["@iNbrPage"].Value = txtNbrPage.Text;
          cmd.Parameters["@iContact"].Value = txtSTContact.Tag;
          cmd.Parameters["@cType"].Value = "S";

          cmd.ExecuteNonQuery();

          // récupération du numéro créé
          miNumDevisST = (int)cmd.Parameters[0].Value;
        }

        // Désactivation des autres contrats de l'action si nécessaire
        if (bDesactive)
          DesactiverDemandeDevisAction();

        // passage en modification
        mstrStatutDevis = "M";

        // mise a jour de l'affichage
        InitialiserFeuille();
      }
      catch (Exception ex)
      {
        MZUtils.displayError(MethodBase.GetCurrentMethod().Name, ex);
      }
    }


    private void DesactiverDemandeDevisAction()
    {
      try
      {
        // recherche des demandes de devis STT de l'action sauf celui que l'on vient de créer
        using (SqlDataReader sdr = MozartDatabase.ExecuteReader($"select NDSTNUM FROM TDST WHERE NDSTNUM <> {miNumDevisST} AND NACTNUM={MozartParams.NumAction}"))
        {
          while (sdr.Read())
          {
            MozartDatabase.ExecuteNonQuery($"UPDATE TDST SET CDSTACTIF = 'N' WHERE NDSTNUM = {sdr["NDSTNUM"]}");
          }
        }
      }
      catch (Exception ex)
      {
        MZUtils.displayError(MethodBase.GetCurrentMethod().Name, ex);
      }
    }

    private void txtNbrPage_KeyPress(object sender, KeyPressEventArgs e)
    {
      // Contrôle de numéricité
      KeyValidator.KeyPress_SaisieNombre(e);
    }

    private void InitialiserFeuille()
    {
      try
      {
        using (SqlDataReader dr = MozartDatabase.ExecuteReader($"api_sp_RetourInfoDevisST {miNumDevisST}, {MozartParams.NumAction}"))
        {
          while (dr.Read())
          {
            //'les infos de la feuil
            txtCliNom.Text = Utils.BlankIfNull(dr["VCLINOM"]);
            txtCliSite2.Text = Utils.BlankIfNull(dr["VSITNOM"]);
            txtCliSite1.Text = Utils.BlankIfNull(dr["NSITNUE"]);
            txtCliDate.Text = Utils.DateBlankIfNull(dr["DDSTDAT"]);
            txtCliAddr1.Text = Utils.BlankIfNull(dr["VSITAD1"]);
            txtCliAddr2.Text = Utils.BlankIfNull(dr["VSITAD2"]);
            txtCliCP.Text = Utils.BlankIfNull(dr["VSITCP"]);
            txtCliVille.Text = Utils.BlankIfNull(dr["VSITVIL"]);
            txtCliTel.Text = Utils.BlankIfNull(dr["VSITTEL"]);
            txtCliFax.Text = Utils.BlankIfNull(dr["VSITFAX"]);
            txtSTNom.Text = Utils.BlankIfNull(dr["VSTFNOM"]);
            txtSTContact.Text = Utils.BlankIfNull(dr["VINTNOM"]);
            txtSTTel.Text = Utils.BlankIfNull(dr["VINTTEL"]);
            txtSTFax.Text = Utils.BlankIfNull(dr["VINTFAX"]);
            txtCliDevis.Text = Utils.BlankIfNull(dr["NDSTNUM"]);
            txtSTPortable.Text = Utils.BlankIfNull(dr["VINTPOR"]);
            txtCliResponsable.Text = Utils.BlankIfNull(dr["VSITRES"]);
            txtSTPays.Text = Utils.BlankIfNull(dr["VSTFPAYS"]);


            //  ' numero du contact
            txtSTContact.Tag = Utils.ZeroIfNull(dr["NINTNUM"]);
            txtSTNom.Tag = Utils.ZeroIfNull(dr["NSTFNUM"]);
            //  ' Ajout mail 25/04/2016
            txtAdrMail.Text = Utils.BlankIfNull(dr["VINTMAIL"]);

            //  ' si on est en modification ou en création
            if (Utils.BlankIfNull(dr["NDSTNUM"]) == "0")
            {
              mstrStatutDevis = "C";
              miNumDevisST = 0;
              txtAction.Text = Utils.BlankIfNull(dr["VACTDES"]);
            }
            else
            {
              mstrStatutDevis = "M";
              miNumDevisST = Convert.ToInt64(Strings.Mid(dr["NDSTNUM"].ToString(), 3));
              txtAction.Text = ModuleMain.ReplaceCharFromBD(Utils.BlankIfNull(dr["TDSTPRE"]), "RTF");
              cmdDate.Enabled = false; // fred le 11/09/2013 on ne peut plus modifier cette date
            }
            //  ' les champs modifiables
            txtNbrPage.Text = Utils.ZeroIfNull(dr["NDSTNBP"]).ToString();
            txtDateRetour.Text = Utils.DateBlankIfNull(dr["DDSTDRE"]);
          }
          //  ' pas encore de modification
          mbModif = false;
        }
      }
      catch (Exception ex)
      {
        MZUtils.displayError(MethodBase.GetCurrentMethod().Name, ex);
      }
    }
  }
}