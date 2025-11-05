using MZCtrlResources = MozartControls.Properties.Resources;
using MozartCS.Properties;
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
  public partial class frmListeOM : Form
  {
    public bool mbFacture;
    public string mstrStatut;

    DataTable dt = new DataTable();

    public frmListeOM()
    {
      InitializeComponent();
    }

    private void frmListeOM_Load(object sender, System.EventArgs e)
    {
      try
      {
        ModuleMain.Initboutons(this);

        if (mstrStatut == "A")
        {
          cmdNouvelle.Visible = true;
          apiGrid.LoadData(dt, MozartDatabase.cnxMozart, $"select * from api_v_ListeOM where NACTNUM = {MozartParams.NumAction}");
        }
        else
        {
          cmdNouvelle.Visible = false;
          apiGrid.LoadData(dt, MozartDatabase.cnxMozart, $"select * from api_v_ListeOM WHERE VSOCIETE = '{MozartParams.NomSociete}'");
        }

        apiGrid.GridControl.DataSource = dt;
        InitApigrid();

        Cursor = Cursors.Default;
      }
      catch (Exception ex)
      {
        Cursor = Cursors.Default;
        MZUtils.displayError(MethodBase.GetCurrentMethod().Name, ex);
      }
    }


    private void InitApigrid()
    {

      try
      {
        apiGrid.AddColumn("Num", "NOMNUM", 700);
        apiGrid.AddColumn(Resources.col_Date, "DDATECRE", 900, "dd/mm/yy");
        apiGrid.AddColumn(Resources.col_Auteur, "Expr1", 1700);
        apiGrid.AddColumn(MZCtrlResources.col_Client, "VCLINOM", 1300);
        apiGrid.AddColumn(Resources.col_cotraitant, "VSTFNOM", 1500);
        apiGrid.AddColumn(Resources.col_Contact, "VINTNOM", 1500);
        apiGrid.AddColumn(Resources.col_realisation, "DOMDEX", 1100);
        apiGrid.AddColumn(Resources.col_Action, "VOMCORPS", 3600);
        apiGrid.AddColumn(Resources.col_Actif, "COMACTIF", 580);
        apiGrid.AddColumn("ST", "nActnum", 0);
        apiGrid.AddColumn("ST", "NINTNUM", 0);
        apiGrid.AddColumn("NCLINUM", "nClinum", 0);
        apiGrid.AddColumn(Resources.col_Pays, "VSTFPAYS", 700);
        apiGrid.AddColumn("NSTFNUM", "NSTFNUM", 0);

        apiGrid.InitColumnList();
      }
      catch (Exception ex)
      {
        MZUtils.displayError(MethodBase.GetCurrentMethod().Name, ex);
      }
    }

    private void cmdNouvelle_Click(object sender, EventArgs e)
    {
      // si la DI n'est pas planifiée ou à planifier on ne peut pas créer d'OM
      if (mbFacture)
      {
        MessageBox.Show(Resources.msg_engagerDepenseActPlanifier, Program.AppTitle, MessageBoxButtons.OK, MessageBoxIcon.Information);
        return;
      }

      // écran de création de la demande
      new frmSaisieOM
      {
        miNumOM = 0,
        mstrStatut = "C",
        mbFacture = mbFacture,
        miST = Convert.ToInt64(apiGrid.GetFocusedDataRow()["NSTFNUM"]),
        miAction = MozartParams.NumAction
      }.ShowDialog();

      Cursor = Cursors.WaitCursor;
      apiGrid.Requery(dt, MozartDatabase.cnxMozart);
      Cursor = Cursors.Default;
    }

    private void cmdModifier_Click(object sender, EventArgs e)
    {
      if (dt.Rows.Count == 0) return;

      DataRow currentRow = apiGrid.GetFocusedDataRow();
      if (currentRow == null) return;

      // passage des infos
      frmSaisieOM f = new frmSaisieOM();
      f.miST = Convert.ToInt64(currentRow["NSTFNUM"]);
      f.miNumOM = Convert.ToInt64(currentRow["NOMNUM"]);
      f.miAction = Convert.ToInt64(currentRow["NACTNUM"]);
      f.mstrStatut = "M";

      f.ShowDialog();
      apiGrid.Requery(dt, MozartDatabase.cnxMozart);
      Cursor = Cursors.Default;

    }

    private void cmdImprimer_Click(object sender, EventArgs e)
    {
      try
      {
        DataRow currentRow = apiGrid.GetFocusedDataRow();
        if (currentRow == null) return;

        string[,] TdbGlobal = { { "copie", "Original" } };

        string sModele = "TOM.rtf";

        if (MozartParams.NomGroupe == "EMALEC")
        {
          if (Convert.ToInt32(currentRow["NCLINUM"]) == 251)
            sModele = "TOMnocibe.rtf";
          if (Convert.ToInt32(currentRow["NCLINUM"]) == 664)
            sModele = "TOMsephora.rtf";
          if (Convert.ToInt32(currentRow["NCLINUM"]) == 12087)
            sModele = "TOMZeeman.rtf";
        }

        new frmBrowser().ImprimerFichier(MozartParams.CheminModeles + ModuleMain.CodePays(currentRow["VSTFPAYS"].ToString()) + sModele,
                      @"TCourrierOut.rtf",
                      TdbGlobal,
                      $"exec api_sp_impOM {currentRow["NOMNUM"]}");
      }
      catch (Exception ex)
      {
        MZUtils.displayError(MethodBase.GetCurrentMethod().Name, ex);
      }
    }

    private void cmdSupprimer_Click(object sender, EventArgs e)
    {
      try
      {
        // suppression
        DataRow currentRow = apiGrid.GetFocusedDataRow();
        if (currentRow == null) return;

        if (MessageBox.Show(Resources.msgConfirm_archOrdreMission, Program.AppTitle, MessageBoxButtons.YesNo, MessageBoxIcon.Question,
              MessageBoxDefaultButton.Button2) == DialogResult.Yes)
        {

          switch (TestIfArchiveOMIsOK())
          {
            case 0:
              MessageBox.Show("Archivage impossible car l'action est chiffrée ou facturée", Program.AppTitle, MessageBoxButtons.OK, MessageBoxIcon.Information);
              break;

            case 1:
              MessageBox.Show("L'état de facturation de l'action sera automatiquement basculé en attente de facturation", Program.AppTitle, MessageBoxButtons.OK, MessageBoxIcon.Information);
              ModuleData.CnxExecute($"update TACT set CACTSTA='A' WHERE NACTNUM = {currentRow["NACTNUM"]}");
              break;
            default:
              break;
          }
          ModuleData.CnxExecute($"update TOM set COMACTIF = 'NON' WHERE NOMNUM = {currentRow["NOMNUM"]}");
        }
        else
          return;

        apiGrid.Requery(dt, MozartDatabase.cnxMozart);

      }
      catch (Exception ex)
      {
        MZUtils.displayError(MethodBase.GetCurrentMethod().Name, ex);
      }
    }

    private void frmListeOM_FormClosing(object sender, FormClosingEventArgs e)
    {
      mbFacture = false;
      Cursor = Cursors.Default;
    }

    private void apiGrid_DoubleClickE(object sender, EventArgs e)
    {
      cmdModifier_Click(null, null);
    }


    public int TestIfArchiveOMIsOK()
    {

      int iArchivageOM = 0;

      using (SqlDataReader sdr = ModuleData.ExecuteReader($"EXEC api_sp_VerifArchivesOMIsOK {MozartParams.NumAction}"))
      {
        if (sdr.HasRows)
        {

          while (sdr.Read())
          {
            if (sdr["CACTSTA"].ToString() == "N")
            {

              if (Convert.ToInt32(sdr["NBOMACTIF"]) > 1)
                iArchivageOM = 2;

              else
                iArchivageOM = 1;
            }
            else
              iArchivageOM = 0;
          }
        }
      }

      return iArchivageOM;
    }

    private void cmdQuitter_Click(object sender, System.EventArgs e)
    {
      Dispose();
    }

  }
}

