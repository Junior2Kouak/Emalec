using MozartLib;
using MozartNet;
using System;
using System.Data;
using System.Data.SqlClient;
using System.Reflection;
using System.Windows.Forms;
using MZUtils = MozartControls.Utils;


namespace MozartCS
{
  public partial class frmSaisieOGS : Form
  {
    //feuille ouverte en création ou modification
    public string mstrStatut;
    public int miNumOG, miAction;
    int miNumClient;

    public frmSaisieOGS()
    {
      InitializeComponent();
    }

    private void frmSaisieOGS_Load(object sender, System.EventArgs e)
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

    private void InitialiserFeuille()
    {
      try
      {
        //recherche des info du contrat
        using (SqlDataReader dr = ModuleData.ExecuteReader($"api_sp_RetourInfoOGS {miNumOG}, {miAction}"))
        {
          if (dr.Read())
          {
            //les infos de la feuille
            txtNomCli.Text = Utils.BlankIfNull(dr["VCLINOM"]);
            txtNomSite.Text = Utils.BlankIfNull(dr["VSITNOM"]);
            txtNumSite.Text = Utils.BlankIfNull(dr["NSITNUE"]);
            txtNomCT.Text = Utils.BlankIfNull(dr["VSTFNOM"]);
            txtContact.Text = Utils.BlankIfNull(dr["VINTNOM"]);
            txtPort.Text = Utils.BlankIfNull(dr["VINTPOR"]);
            txtReal.Text = Utils.DateBlankIfNull(dr["DOGDEX"]);
            txtMail.Text = Utils.BlankIfNull(dr["VINTMAIL"]);
            txtTelCli.Text = Utils.BlankIfNull(dr["VSITTEL"]);
            txtTelCT.Text = Utils.BlankIfNull(dr["VINTTEL"]);
            txtFax.Text = Utils.BlankIfNull(dr["VINTFAX"]);
            txtResp.Text = Utils.BlankIfNull(dr["VSITRES"]);

            //numero du contact et du stt
            txtNomCT.Tag = (int)Utils.ZeroIfNull(dr["NSTFNUM"]);
            txtContact.Tag = (int)Utils.ZeroIfNull(dr["NINTNUM"]);

            //si on est en modification ou en création
            if (Utils.ZeroIfNull(dr["NOGNUM"]) == 0)
            {
              mstrStatut = "C";
              miNumOG = 0;
              txtLettre.Text = Utils.BlankIfNull(dr["VACTDES"]);
            }
            else
            {
              mstrStatut = "M";
              miNumOG = (int)Utils.ZeroIfNull(dr["NOGNUM"]);
              txtLettre.Text = ModuleMain.ReplaceCharFromBD(Utils.BlankIfNull(dr["VOGCORPS"]), "RTF");
            }
            miNumClient = (int)Utils.ZeroIfNull(dr["NCLINUM"]);
          }
        }
      }
      catch (Exception ex)
      {
        Utils.ShowException(ex, MethodBase.GetCurrentMethod().Name, ex.StackTrace);
      }
    }

    private void cmdValider_Click(object sender, EventArgs e)
    {
      //Si la DI n'est pas planifiée ou à planifier on ne peut pas créer d'OM
      if (new frmListeOGS().mbFacture)
      {
        MessageBox.Show("Vous ne pouvez engager une dépense que sur une action 'A planifier' ou 'Planifiée'", Program.AppTitle, MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
        return;
      }

      if (!TestValidation()) return;

      EnregistrerOG();

      //passage en modification
      mstrStatut = "M";

      InitialiserFeuille();
    }

    private void CmdVisu_Click(object sender, EventArgs e)
    {
      if (miNumOG != 0)
      {
        string[,] TdbGlobal = { { "copie", "Original" } };
        string sModele = "TOGS.rtf";

        new frmBrowser()
        {
          mstrType = $"OGS{miNumOG}",
          msInfosMail = $"TINT|NINTNUM|{txtContact.Tag}",
        }.Preview_Print($"{MozartParams.CheminModeles}{Utils.GetLanguePays("TSTF", "VLANGUEABR", "NSTFNUM", txtNomCT.Tag.ToString())}{sModele}",
                         $"{miNumOG}TOGOut.rtf",
                         TdbGlobal,
                         $"exec api_sp_impOGS {miNumOG}",
                         " (Visualisation OG)",
                         "PREVIEW");
      }
      else
        MessageBox.Show("Impression impossible, il faut enregistrer l'ordre de garantie", Program.AppTitle, MessageBoxButtons.OK, MessageBoxIcon.Exclamation); return;
    }

    private void cmdImprimer_Click(object sender, EventArgs e)
    {
      if (miNumOG != 0)
      {
        Cursor.Current = Cursors.WaitCursor;

        string[,] TdbGlobal = { { "copie", "Original" } };
        string sModele = "TOGS.rtf";

        new frmBrowser().ImprimerFichier($"{MozartParams.CheminModeles}{Utils.GetLanguePays("TSTF", "VLANGUEABR", "NSTFNUM", txtNomCT.Tag.ToString())}{sModele}",
                                          "TOGOut.rtf",
                                          TdbGlobal,
                                          $"exec api_sp_impOGS {miNumOG}");

        Cursor.Current = Cursors.Default;
      }
      else
        MessageBox.Show("Impression impossible, il faut enregistrer l'ordre de garantie", Program.AppTitle, MessageBoxButtons.OK, MessageBoxIcon.Exclamation); return;
    }

    private void cmdMail_Click(object sender, EventArgs e)
    {
      if (miNumOG != 0)
      {
        //confirmation
        if (MessageBox.Show("Vous allez envoyer un mail au sous traitant. Confirmez-vous cette action ?", Program.AppTitle, MessageBoxButtons.YesNo, MessageBoxIcon.Question, MessageBoxDefaultButton.Button2) != DialogResult.Yes) return;

        //envoi du mail
        using (SqlDataReader dr = ModuleData.ExecuteReader($"api_sp_EnvoieMailOG {miNumOG}"))
        {
          if (dr.Read())
          {
            if ((int)dr[0] == 0)
              MessageBox.Show("Le contact n'a pas d'adresse mail!", Program.AppTitle, MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
            else
              MessageBox.Show("Le mail a été envoyé!", Program.AppTitle, MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
          }
        }
      }
      else
        MessageBox.Show("Impression impossible, il faut enregistrer l'ordre de garantie", Program.AppTitle, MessageBoxButtons.OK, MessageBoxIcon.Exclamation); return;
    }

    private bool TestValidation()
    {
      if (txtLettre.Text == "")
      {
        MessageBox.Show(" Saisissez du texte dans la zone texte", Program.AppTitle, MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
        txtLettre.Focus();
        return false;
      }
      return true;
    }

    private void cmdFermer_Click(object sender, System.EventArgs e)
    {
      Dispose();
    }

    private void EnregistrerOG()
    {
      try
      {
        //création d'une commande
        using (SqlCommand cmd = new SqlCommand("api_sp_creationOGS", MozartDatabase.cnxMozart))
        {
          //passage du nom de la procédure stockée
          cmd.CommandType = CommandType.StoredProcedure;
          SqlCommandBuilder.DeriveParameters(cmd);

          //liste des paramètres
          cmd.Parameters["@iNumOG"].Value = miNumOG;
          cmd.Parameters["@iST"].Value = txtContact.Tag;
          cmd.Parameters["@iAction"].Value = miAction;
          cmd.Parameters["@corps"].Value = txtLettre.Text; //ReplaceCharToBD(txtLettre, "RTF")
          cmd.Parameters["@ddateex"].Value = txtReal.Text;

          //exécuter la commande
          cmd.ExecuteNonQuery();
          miNumOG = (int)cmd.Parameters[0].Value;
        }
      }
      catch (Exception ex)
      {
        Utils.ShowException(ex, MethodBase.GetCurrentMethod().Name, ex.StackTrace);
      }
    }

    private async void ApiTelAuto1_Click_1(object sender, EventArgs e)
    {
      if (txtTelCli.Text != "")
      {
        string reponse = await CNumerotationAuto.MakeCallByAvaya(MozartParams.UserTelInt, txtTelCli.Text, Environment.MachineName);
        if (reponse != "OK")
        {
          MessageBox.Show(reponse, Program.AppTitle, MessageBoxButtons.OK, MessageBoxIcon.Error);
        }
      }
    }

    private async void ApiTelAuto2_Click_1(object sender, EventArgs e)
    {
      if (txtTelCT.Text != "")
      {
        string reponse = await CNumerotationAuto.MakeCallByAvaya(MozartParams.UserTelInt, txtTelCT.Text, Environment.MachineName);
        if (reponse != "OK")
        {
          MessageBox.Show(reponse, Program.AppTitle, MessageBoxButtons.OK, MessageBoxIcon.Error);
        }
      }
    }

    private async void ApiTelAuto3_Click_1(object sender, EventArgs e)
    {
      if (txtPort.Text != "")
      {
        string reponse = await CNumerotationAuto.MakeCallByAvaya(MozartParams.UserTelInt, txtPort.Text, Environment.MachineName);
        if (reponse != "OK")
        {
          MessageBox.Show(reponse, Program.AppTitle, MessageBoxButtons.OK, MessageBoxIcon.Error);
        }
      }
    }
  }
}
