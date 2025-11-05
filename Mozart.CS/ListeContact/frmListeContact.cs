using MZCtrlResources = MozartControls.Properties.Resources;
using MozartCS.Properties;
using MozartLib;
using MozartNet;
using MozartUC;
using System;
using System.Data;
using System.Reflection;
using System.Windows.Forms;
using MZUtils = MozartControls.Utils;


namespace MozartCS
{
  public partial class frmListeContact : Form
  {
    DataTable dt = new DataTable();
    public frmListeContact()
    {
      InitializeComponent();
    }

    private void frmListeContact_Load(object sender, System.EventArgs e)
    {
      try
      {
        ModuleMain.Initboutons(this);
        apiTGrid.LoadData(dt, MozartDatabase.cnxMozart, $"select * from tcli inner join tccl on tcli.nclinum=tccl.nclinum and CCCLACTIF='O'" +
          $" and vsociete = '{MozartParams.NomSociete}' order by vclinom");
        apiTGrid.GridControl.DataSource = dt;
        InitApigrid();
        Cursor.Current = Cursors.Default;
      }
      catch (Exception ex)
      {
        MZUtils.displayError(MethodBase.GetCurrentMethod().Name, ex);
      }
    }

    private void cmdModifier_Click(object sender, EventArgs e)
    {
      DataRow row = apiTGrid.GetFocusedDataRow();
      if (row == null)
        return;
      frmGestContactsClient f = new frmGestContactsClient();
      f.miNumClient = Convert.ToInt64(row["NCLINUM"]);
      f.mstrClient = row["VCLINOM"].ToString();
      f.ShowDialog();

      apiTGrid.Requery(dt, MozartDatabase.cnxMozart);
    }

    private void cmdSupprimer_Click(object sender, EventArgs e)
    {
      DataRow row = apiTGrid.GetFocusedDataRow();

      try
      {
        if (row == null)
          return;
        if (MessageBox.Show(Resources.msg_ConfirmArchContact, Program.AppTitle, MessageBoxButtons.YesNo,
                          MessageBoxIcon.Question, MessageBoxDefaultButton.Button2) == DialogResult.Yes)
        {
          ModuleData.ExecuteNonQuery($"update TCCL set CCCLACTIF = 'N' where NCCLNUM = {row["NCCLNUM"]}");
          // Envoi d'un mail informant de l'archivage d'un contact à l'informatique
          // FGB : Requête ne fait que des select ... : ModuleData.ExecuteNonQuery($"EXEC api_sp_EnvoiMsgContactArchi {row["NCCLNUM"]}");
        }
        else
          return;

        //  rafraichissement du recordset
        apiTGrid.Requery(dt, MozartDatabase.cnxMozart);
      }
      catch (Exception ex)
      {
        MZUtils.displayError(MethodBase.GetCurrentMethod().Name, ex);
      }
    }

    private void frmListeContact_Resize(object sender, EventArgs e)
    {
      apiTGrid.Width = Width - apiTGrid.Left - 15;
      apiTGrid.Height = Height - apiTGrid.Top - 80;
      cmdQuitter.Top = Height - 135;
    }

    private void InitApigrid()
    {
      apiTGrid.AddColumn(MZCtrlResources.col_Client, "VCLINOM", 2000);
      apiTGrid.AddColumn(Resources.col_Nom, "VCCLNOM", 2000, "", 0, true);
      apiTGrid.AddColumn(Resources.col_Prenom, "VCCLPRE", 1500);
      apiTGrid.AddColumn(Resources.col_Civ, "CCCLCIV", 600);
      apiTGrid.AddColumn(Resources.col_Fonction, "VCCLFONC", 3000, "", 0, true);
      apiTGrid.AddColumn(Resources.col_Tel, "VCCLTEL", 1400);
      apiTGrid.AddColumn(Resources.col_Fax, "VCCLFAX", 1400);
      apiTGrid.AddColumn(Resources.col_GSM, "VINTPOR", 1400);
      apiTGrid.AddColumn(Resources.col_Email, "VCCLMAIL", 2000, "", 0, true);
      apiTGrid.AddColumn(Resources.col_Devis, "VCCLDEVIS", 800);
      apiTGrid.AddColumn(Resources.col_Attest, "VCCLATT", 800);
      apiTGrid.AddColumn(Resources.col_Stat, "VCCLSTAT", 800);
      apiTGrid.AddColumn(Resources.col_Fact, "VCCLMAILFAC", 800);
      apiTGrid.AddColumn(Resources.col_NumContact, "NCCLNUM", 0);
      apiTGrid.AddColumn(Resources.col_NumClient, "NCLINUM", 0);
      apiTGrid.AddColumn(Resources.col_Actif, "CCLIACTIF", 0);

      apiTGrid.InitColumnList();
    }

    private void frmListeContact_FormClosed(object sender, FormClosedEventArgs e)
    {
      Cursor.Current = Cursors.Default;
    }

    private void cmdQuitter_Click(object sender, System.EventArgs e)
    {
      Dispose();
    }

  }
}

