using MozartCS.Properties;
using MozartLib;
using MozartNet;
using System;
using System.Data;
using System.IO;
using System.Reflection;
using System.Windows.Forms;
using MZUtils = MozartControls.Utils;
using MZCtrlResources = MozartControls.Properties.Resources;

namespace MozartCS
{
  public partial class frmGestDocComSTF : Form
  {
    public long miStfGrpNnum;
    public string mstrNom;


    DataTable dtLstDocSTF = new DataTable();

    public frmGestDocComSTF() { InitializeComponent(); }

    private void frmGestDocAdminSTF_Load(object sender, System.EventArgs e)
    {
      try
      {
        ModuleMain.Initboutons(this);

        Label2.Text = mstrNom;

        apiTGrid1.LoadData(dtLstDocSTF, MozartDatabase.cnxMozart, $"EXEC api_sp_ListeDocSTFConditionsCommerciales {miStfGrpNnum} ");
        apiTGrid1.GridControl.DataSource = dtLstDocSTF;
        InitApigrid();

      }
      catch (Exception ex)
      {
        MZUtils.displayError(MethodBase.GetCurrentMethod().Name, ex);
      }
    }


    private void CmdAjout_Click(object sender, EventArgs e)
    {
      frmDetailDocComSTF f = new frmDetailDocComSTF();
      f.miNumDoc = 0;
      f.miSTFGRPNUM = miStfGrpNnum;
      f.mstrNom = mstrNom;
      f.ShowDialog();

      apiTGrid1.Requery(dtLstDocSTF, MozartDatabase.cnxMozart);
    }

    private void CmdDetail_Click(object sender, EventArgs e)
    {
      DataRow currentRow = apiTGrid1.GetFocusedDataRow();
      if (currentRow == null) return;

      frmDetailDocComSTF f = new frmDetailDocComSTF();
      f.miNumDoc = Convert.ToInt64(currentRow["NIDDOCSTFCONDCOM"]);
      f.miSTFGRPNUM = miStfGrpNnum;
      f.mstrNom = mstrNom;
      f.ShowDialog();

      apiTGrid1.Requery(dtLstDocSTF, MozartDatabase.cnxMozart);
    }

    private void CmdVisu_Click(object sender, EventArgs e)
    {
      DataRow currentRow = apiTGrid1.GetFocusedDataRow();
      if (currentRow == null) return;

      frmBrowser f = new frmBrowser();
      f.msStartingAddress = Utils.RechercheParam("REP_DOC_COND_COM_STF") + currentRow["VFILE"].ToString();
      f.ShowDialog();
    }


    private void InitApigrid()
    {
      try
      {
        apiTGrid1.AddColumn(Resources.col_Nom_du_doc, "VTITLE", 6000);
        apiTGrid1.AddColumn("Type document", "VLIBELLE", 2000);
        apiTGrid1.AddColumn(MZCtrlResources.date_creation, "DATECRE", 2500, "", 2);
        apiTGrid1.AddColumn("Date signature", "DDATEDOC", 2500, "dd/mm/yyyy", 2);
        apiTGrid1.AddColumn("VFILE", "VFILE", 0);
        //apiTGrid1.AddColumn("Saisi par", "VPERNOM", 2000);
        //apiTGrid1.AddColumn("Date de saisie", "DDOCSTFCRE", 2000, "", 2);
        //apiTGrid1.AddColumn("NQUICRE", "NQUICRE", 0);
        apiTGrid1.AddColumn("NIDDOCSTFCONDCOM", "NIDDOCSTFCONDCOM", 0);
        apiTGrid1.AddColumn("NSTFGRPNUM", "NSTFGRPNUM", 0);

        apiTGrid1.InitColumnList();
      }
      catch (Exception ex)
      {
        MZUtils.displayError(MethodBase.GetCurrentMethod().Name, ex);
      }
    }


    private void cmdSupp_Click(object sender, EventArgs e)
    {
      DataRow row = apiTGrid1.GetFocusedDataRow();
      if (row == null) return;

      if (MessageBox.Show("Voulez-vous vraiment supprimer ce document ?", Program.AppTitle, MessageBoxButtons.YesNo, MessageBoxIcon.Question, MessageBoxDefaultButton.Button2) == DialogResult.Yes)
      {
        // supression en base
        ModuleData.ExecuteNonQuery($"DELETE FROM TDOCSTFCONDCOM WHERE NIDDOCSTFCONDCOM = {row["NIDDOCSTFCONDCOM"]}");
        // supression du fichier physique
        File.Delete(Utils.RechercheParam("REP_DOC_COND_COM_STF") + row["VFILE"].ToString());
        // refresh de la liste
        apiTGrid1.Requery(dtLstDocSTF, MozartDatabase.cnxMozart);
      }

    }

    private void cmdFermer_Click(object sender, System.EventArgs e)
    {
      Dispose();
    }

  }
}