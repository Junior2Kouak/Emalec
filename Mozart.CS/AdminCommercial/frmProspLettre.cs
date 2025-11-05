using System;
using System.Windows.Forms;
using System.Data;
using System.Reflection;
using MozartCS.Properties;
using MozartUC;
using MozartNet;
using System.Collections.Generic;
using System.Data.SqlClient;
using MozartLib;

namespace MozartCS
{
  public partial class frmProspLettre : Form
  {
    public string mstrStatut = "";
    public string msLibNomSoc = "";
    public long miNumCourrier = 0;
    public long miNumProsp = 0;
    bool bModif;

    public frmProspLettre()
    {
      InitializeComponent();
    }

    private void frmProspLettre_Load(object sender, System.EventArgs e)
    {
      try
      {
        ModuleMain.Initboutons(this);
        //libellé titre
        Label2.Text += " " + MozartParams.NomSociete;
        string sSQL = $"select NPROSNUM, VPROSNOM from TPROSP WHERE VSOCIETE = '{MozartParams.NomSociete}' order by VPROSNOM";
        apicboClient.Init(MozartDatabase.cnxMozart, sSQL, "NPROSNUM", "VPROSNOM", new List<string>() { Resources.col_Num, Resources.col_Nom }, 400, 300);

        if (mstrStatut == "C")
          InitialiserFeuilleVide();
        else
          InitialiserFeuille();

        Cursor.Current = Cursors.Default;
      }
      catch (Exception ex)
      {
        Utils.ShowException(ex, MethodBase.GetCurrentMethod().Name, ex.StackTrace);
      }
    }

    private void cmdValider_Click(object sender, EventArgs e)
    {
      try
      {
        if (!TestValidation())
          return;

        EnregistrerCourrier();

        //passage en modification
        mstrStatut = "M";

        bModif = false;
      }
      catch (Exception ex)
      {
        Utils.ShowException(ex, MethodBase.GetCurrentMethod().Name, ex.StackTrace);
      }
    }

    private void cmdVisu_Click(object sender, EventArgs e)
    {
      string sSQL;
      string[,] TdbGlobal = { { "copie", "1/2   Original" } };

      try
      {
        if (miNumCourrier == 0)
        {
          MessageBox.Show(Resources.msg_must_save_letter, Program.AppTitle, MessageBoxButtons.OK, MessageBoxIcon.Information);
          return;
        }
        else
        {
          sSQL = "select VPROSPAYS from TPROSP WHERE NPROSNUM = " + apicboClient.GetItemData();

          frmBrowser F = new frmBrowser();
          F.msInfosMail = "TPROSP|NPROSNUM|" + miNumProsp;
          F.Preview_Print(MozartParams.CheminModeles + ModuleMain.CodePays(ModuleData.ExecuteScalarString(sSQL)) +
                                                    "TCourrierProsp.rtf",
                                                    @"TCourrierProspOut.rtf",
                                                    TdbGlobal,
                                                    $"exec api_sp_impCourrierProsp {miNumCourrier}",
                                                    " (Visualisation lettre)",
                                                    "PREVIEW");
        }
      }
      catch (Exception ex)
      {
        Utils.ShowException(ex, MethodBase.GetCurrentMethod().Name, ex.StackTrace);
      }
    }

    private void cmdImprimer_Click(object sender, EventArgs e)
    {
      // une copie original
      string[,] TdbGlobal = { { "copie", "copie" } };
      string sSQL;
      try
      {
        if (miNumCourrier == 0)
        {
          MessageBox.Show(Resources.msg_must_save_letter, Program.AppTitle, MessageBoxButtons.OK, MessageBoxIcon.Information);
          return;
        }
        sSQL = "select VPROSPAYS from TPROSP WHERE NPROSNUM = " + apicboClient.GetItemData();
        Cursor.Current = Cursors.WaitCursor;

        new frmBrowser().ImprimerFichier(MozartParams.CheminModeles + ModuleMain.CodePays(ModuleData.ExecuteScalarString(sSQL)) + "TCourrierProsp.rtf",
                      @"TCourrierProspOut.rtf",
                      TdbGlobal,
                      @"exec api_sp_impCourrierProsp {miNumCourrier}");
        Cursor.Current = Cursors.Default;
      }

      catch (Exception ex)
      {
        Utils.ShowException(ex, MethodBase.GetCurrentMethod().Name, ex.StackTrace);
      }
    }

    private void cmdMail_Click(object sender, EventArgs e)
    {
      try
      {
        if (miNumCourrier == 0)
        {
          MessageBox.Show(Resources.msg_must_save_letter, Program.AppTitle, MessageBoxButtons.OK, MessageBoxIcon.Information);
          return;
        }
        //envoi du mail
        ModuleData.ExecuteNonQuery($"api_sp_EnvoieMail 0, {miNumCourrier}");
      }
      catch (Exception ex)
      {
        Utils.ShowException(ex, MethodBase.GetCurrentMethod().Name, ex.StackTrace);
      }
    }

    private bool TestValidation()
    {
      bool bValid = true;
      try
      {
        if (apicboClient.GetText() == "") { MessageBox.Show(Resources.msg_ChooseProspect); bValid = false; apicboClient.Focus(); }

        if (txtRef.Text == "") { MessageBox.Show(Resources.msg_EntrerRefDansZone); bValid = false; txtRef.Focus(); }

        if (txtObjet.Text == "") { MessageBox.Show(Resources.msg_EntrerObjDansZone); bValid = false; txtObjet.Focus(); }

        if (txtLettre.Text == "") { MessageBox.Show(Resources.msg_EntrerTxtDansZone); bValid = false; txtObjet.Focus(); }

        return bValid;
      }
      catch (Exception ex)
      {
        Utils.ShowException(ex, MethodBase.GetCurrentMethod().Name, ex.StackTrace);
        return false;
      }
    }

    private void frmProspLettre_KeyPress(object sender, KeyPressEventArgs e)
    {
      bModif = true;
    }

    private void cmdFermer_Click(object sender, System.EventArgs e)
    {
      try
      {
        //si il y a des modifications
        if (bModif)
        {
          switch (MessageBox.Show(Resources.msgConfirm_enregistrerModif, Program.AppTitle, MessageBoxButtons.YesNoCancel, MessageBoxIcon.Question, MessageBoxDefaultButton.Button2))
          {
            case DialogResult.Yes:
              EnregistrerCourrier();
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
        {
          Dispose();
        }
      }
      catch (Exception ex)
      {
        Utils.ShowException(ex, MethodBase.GetCurrentMethod().Name, ex.StackTrace);
      }
    }

    private void EnregistrerCourrier()
    {
      try
      {
        //création d'une commande
        using (SqlCommand cmd = new SqlCommand("api_sp_creationCourrierProsp", MozartDatabase.cnxMozart))
        {
          cmd.CommandType = CommandType.StoredProcedure;
          SqlCommandBuilder.DeriveParameters(cmd);    // liste des paramètres

          // Liste des paramètres
          cmd.Parameters["@iNumCour"].Value = miNumCourrier;
          cmd.Parameters["@iCourrier"].Value = 0;
          cmd.Parameters["@iDest"].Value = apicboClient.GetItemData();
          cmd.Parameters["@Ref"].Value = ModuleMain.ReplaceCharToBD(txtRef.Text, "RTF");
          cmd.Parameters["@obj"].Value = ModuleMain.ReplaceCharToBD(txtObjet.Text, "RTF");
          cmd.Parameters["@corps"].Value = ModuleMain.ReplaceCharToBD(txtLettre.Text, "RTF");
          cmd.Parameters["@pied"].Value = ModuleMain.ReplaceCharToBD(txtPied.Text, "RTF");
          cmd.ExecuteNonQuery();
          miNumCourrier = (int)cmd.Parameters[0].Value;
        }
      }
      catch (Exception ex)
      {
        Utils.ShowException(ex, MethodBase.GetCurrentMethod().Name, ex.StackTrace);
      }
    }

    private void InitialiserFeuille()
    {
      try
      {
        //recherche des infos du contrat
        using (SqlDataReader dr = ModuleData.ExecuteReader("select * from TCOURPROSP WHERE NCOURNUM = " + miNumCourrier))
        {
          if (dr.Read())
          {
            //les infos de la feuille
            txtObjet.Text = ModuleMain.ReplaceCharFromBD(Utils.BlankIfNull(dr["VCOUROBJET"]), "RTF");
            txtRef.Text = ModuleMain.ReplaceCharFromBD(Utils.BlankIfNull(dr["VCOURREF"]), "RTF");
            txtLettre.Text = ModuleMain.ReplaceCharFromBD(Utils.BlankIfNull(dr["VCOURCORPS"]), "RTF");
            txtPied.Text = dr["VCOURPIED"] == null ? "" : ModuleMain.ReplaceCharFromBD(dr["VCOURPIED"].ToString(), "RTF");

            apicboClient.SetItemData(Convert.ToInt32(dr["NCOURIDPROSP"]));
            apicboClient.Enabled = false;
          }
          dr.Close();
        }
      }
      catch (Exception ex)
      {
        Utils.ShowException(ex, MethodBase.GetCurrentMethod().Name, ex.StackTrace);
      }
    }

    private void InitialiserFeuilleVide()
    {
      try
      {
        txtObjet.Text = "";
        txtRef.Text = "";
        txtLettre.Text = "";

        apicboClient.SetItemData(Convert.ToInt32(miNumProsp));

        //pas encore de modification
        bModif = false;
      }
      catch (Exception ex)
      {
        Utils.ShowException(ex, MethodBase.GetCurrentMethod().Name, ex.StackTrace);
      }
    }
  }
}
