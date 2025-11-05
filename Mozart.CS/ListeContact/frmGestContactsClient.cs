using MozartCS.Properties;
using MozartLib;
using MozartNet;
using MozartUC;
using System;
using System.Data;
using System.Diagnostics;
using System.Reflection;
using System.Windows.Forms;
using MZUtils = MozartControls.Utils;

namespace MozartCS
{
  public partial class frmGestContactsClient : Form
  {
    public long miNumClient;
    public string mstrClient;
    DataTable dt = new DataTable();

    public frmGestContactsClient()
    {
      InitializeComponent();
    }

    private void frmGestContactsClient_Load(object sender, System.EventArgs e)
    {
      try
      {
        ModuleMain.Initboutons(this);
        lbl.Text = mstrClient;

        string sSQL = $"select VPERNOM, TCCL.* from TCCL LEFT OUTER JOIN TPER on TCCL.NQUIMOD=TPER.NPERNUM " +
                      $"where CCCLACTIF = 'O' AND NCLINUM = {miNumClient} Order by VCCLNOM";
        apiTGrid1.LoadData(dt, MozartDatabase.cnxMozart, sSQL);
        apiTGrid1.GridControl.DataSource = dt;
        InitApigrid();
      }
      catch (Exception ex)
      {
        MZUtils.displayError(MethodBase.GetCurrentMethod().Name, ex);
      }
    }

    private void cmdFermer_Click(object sender, System.EventArgs e)
    {
      Dispose();
    }

    private void cmdAjouter_Click(object sender, EventArgs e)
    {
      MozartUcUtils.SpyLog(MozartDatabase.cnxMozart, "", cmdAjouter.Tag.ToString(), "Entrée");
      frmDetailsContact f = new frmDetailsContact();
      f.mstrStatut = "C";
      f.miNumContact = 0;
      f.miNumClient = miNumClient;
      f.ShowDialog();

      apiTGrid1.Requery(dt, MozartDatabase.cnxMozart);
    }

    private void cmdModifier_Click(object sender, EventArgs e)
    {
      DataRow currentRow = apiTGrid1.GetFocusedDataRow();
      if (currentRow == null) return;

      MozartUcUtils.SpyLog(MozartDatabase.cnxMozart, "", cmdModifier.Tag.ToString(), "Entrée", "NCCLNUM:" + currentRow["NCCLNUM"]);

      frmDetailsContact f = new frmDetailsContact();
      f.mstrStatut = "M";
      f.miNumContact = Convert.ToInt64(currentRow["NCCLNUM"]);
      f.miNumClient = miNumClient;
      f.ShowDialog();

      apiTGrid1.Requery(dt, MozartDatabase.cnxMozart);
    }

    private void cmdSupprimer_Click(object sender, EventArgs e)
    {
      DataRow row = apiTGrid1.GetFocusedDataRow();
      try
      {
        if (MessageBox.Show(Resources.msg_ConfirmArchContact, Program.AppTitle, MessageBoxButtons.YesNo,
                          MessageBoxIcon.Question, MessageBoxDefaultButton.Button2) == DialogResult.Yes)
        {
          MozartUcUtils.SpyLog(MozartDatabase.cnxMozart, "", cmdSupprimer.Tag.ToString(), "Entrée", "NCCLNUM:" + row["NCCLNUM"]);
          ModuleData.ExecuteNonQuery($"update TCCL set CCCLACTIF = 'N', VCCLDEVISDEF='NON' where NCCLNUM = {row["NCCLNUM"]}");
          //Envoi d'un mail informant de l'archivage d'un contact à l'informatique
          //TODO requete ne marchant pas en dev ?
          // FGB : Requête ne fait que des select ... : ModuleData.ExecuteNonQuery($"EXEC api_sp_EnvoiMsgContactArchi {row["NCCLNUM"]}");
        }
        else
          return;
        //rafraichissement du recordset
        apiTGrid1.Requery(dt, MozartDatabase.cnxMozart);
      }
      catch (Exception ex)
      {
        MZUtils.displayError(MethodBase.GetCurrentMethod().Name, ex);
      }
    }

    private void cmdArchive_Click(object sender, EventArgs e)
    {
      MozartUcUtils.SpyLog(MozartDatabase.cnxMozart, "", cmdArchive.Tag.ToString(), "Entrée");
      frmGestContactsClientArch f = new frmGestContactsClientArch();
      f.miNumClient = miNumClient;
      f.mstrClient = mstrClient;
      f.ShowDialog();

      //rafraichissement du recordset
      apiTGrid1.Requery(dt, MozartDatabase.cnxMozart);
    }

    private void cmdMail_Click(object sender, EventArgs e)
    {
      try
      {
        DataRow row = apiTGrid1.GetFocusedDataRow();
        MozartUcUtils.SpyLog(MozartDatabase.cnxMozart, "", cmdMail.Tag.ToString(), "Entrée", "NCCLNUM:" + row["NCCLNUM"], "VCCLMAIL:" + row["VCCLMAIL"]);
        var process = Process.Start(Uri.EscapeUriString($"mailto: {row["VCCLMAIL"]}"));
        MozartUcUtils.SpyLog(MozartDatabase.cnxMozart, "", "", "Sortie");

      }
      catch (Exception ex)
      {
        Utils.ShowException(ex, MethodBase.GetCurrentMethod().Name, ex.StackTrace);
      }
    }
    //Private Sub cmdMail_Click()
    //If rsPri.EOF Then Exit Sub
    //
    //  ' Ouverture de Outlook
    //  SpyLog "", cmdMail.Tag, "Entrée", "NCCLNUM:" & rsPri("NCCLNUM"), "VCCLMAIL:" & rsPri("VCCLMAIL")
    //  Call ShellExecute(GetDesktopWindow(), "open", "mailto:" & rsPri("VCCLMAIL"), 0&, 0&, SW_SHOWNORMAL)
    //  SpyLog "", "", "Sortie"
    //
    //End Sub

    private void cmdContact_Click(object sender, EventArgs e)
    {
      MozartUcUtils.SpyLog(MozartDatabase.cnxMozart, "", cmdContact.Tag.ToString(), "Entrée", "NCLINUM:" + miNumClient);
      frmLienContactSite f = new frmLienContactSite();
      f.miNumClient = Convert.ToInt32(miNumClient);
      f.ShowDialog();
    }

    private void InitApigrid()
    {
      apiTGrid1.AddColumn(Resources.col_Nom, "VCCLNOM", 1300, "", 0, true);
      apiTGrid1.AddColumn(Resources.col_Prenom, "VCCLPRE", 1000);
      apiTGrid1.AddColumn(Resources.col_Civ, "CCCLCIV", 600);
      apiTGrid1.AddColumn(Resources.col_Fonction, "VCCLFONC", 1500, "", 0, true);
      apiTGrid1.AddColumn(Resources.col_Devis, "VCCLDEVIS", 900);
      apiTGrid1.AddColumn(Resources.col_Attest, "VCCLATT", 900);
      apiTGrid1.AddColumn(Resources.col_Stat, "VCCLSTAT", 900);
      apiTGrid1.AddColumn(Resources.col_Fact, "VCCLMAILFAC", 900);
      apiTGrid1.AddColumn("Relance", "VCCLMAILREL", 900);
      apiTGrid1.AddColumn(Resources.col_Doc, "VCCLDEVISDEF", 900);
      apiTGrid1.AddColumn(Resources.col_Adresse1, "VCCLAD1", 1200, "", 0, true);
      apiTGrid1.AddColumn(Resources.col_Ad2, "VCCLAD2", 500);
      apiTGrid1.AddColumn(Resources.col_CP, "VCCLCP", 600);
      apiTGrid1.AddColumn(Resources.col_Ville, "VCCLVIL", 1400, "", 0, true);
      apiTGrid1.AddColumn(Resources.col_Tel, "VCCLTEL", 1200);
      apiTGrid1.AddColumn(Resources.col_Fax, "VCCLFAX", 1200);
      apiTGrid1.AddColumn(Resources.col_GSM, "VINTPOR", 1200);
      apiTGrid1.AddColumn(Resources.col_Email, "VCCLMAIL", 800, "", 0, true);
      apiTGrid1.AddColumn(Resources.col_Date_Mod, "DDATEMOD", 1200, "dd/mm/yyyy", 2);
      apiTGrid1.AddColumn(Resources.col_Qui_modif, "VPERNOM", 1200);
      apiTGrid1.AddColumn(Resources.col_NumContact, "NCCLNUM", 0);
      apiTGrid1.AddColumn(Resources.col_NumClient, "NCLINUM", 0);

      apiTGrid1.InitColumnList();
    }

    private void frmGestContactsClient_FormClosed(object sender, FormClosedEventArgs e)
    {
      MozartUcUtils.SpyLog(MozartDatabase.cnxMozart, "", "", "Sortie");
      Cursor.Current = Cursors.Default;
    }

  }
}

