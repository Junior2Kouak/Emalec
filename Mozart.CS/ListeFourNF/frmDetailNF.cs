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
  public partial class frmDetailNF : Form
  {


    public string mstrStatutElemFact;
    public long miNumAction;
    public long miNumDI;
    public int miNumClient;



    private DataTable dtActions = new DataTable();
    private DataTable dtArticle = new DataTable();

    public frmDetailNF()
    {
      InitializeComponent();
    }

    private void frmDetailNF_Load(object sender, EventArgs e)
    {

      try
      {
        ModuleMain.Initboutons(this);

        // initialisation du tableau des actions
        FormatGridAction();

        if (mstrStatutElemFact == "C")
        {
          OuvertureEnCreation();
        }
        else
        {
          OuvertureEnModification();
        }

        apiTGridB.LoadData(dtArticle, MozartDatabase.cnxMozart, $"api_sp_ListeFournituresNF {miNumAction}");
        apiTGridB.GridControl.DataSource = dtArticle;
        FormatapiTGrid();


        // dans le cas on on vient du reporting, on est juste en visu sans pouvoir faire de modifications
        if (mstrStatutElemFact == "V") cmdEnregistrer.Visible = false;
      }
      catch (Exception ex)
      {
        MZUtils.displayError(MethodBase.GetCurrentMethod().Name, ex);
      }
    }

    public void FormatGridAction()
    {
      apiTGridActions.AddColumn(Resources.col_NAction, "NACTID", 500);
      apiTGridActions.AddColumn(Resources.col_Site, "VSITNOM", 1200);
      apiTGridActions.AddColumn(Resources.col_Action, "VACTDES", 3000);
      apiTGridActions.AddColumn(Resources.col_Prestation, "CPRECOD", 500, "", 2);
      apiTGridActions.AddColumn(Resources.col_Pays, "VSITPAYS", 700, "", 2);
      apiTGridActions.AddColumn("NACTNUM", "NACTNUM", 0);

      apiTGridActions.FilterBar = true;
      apiTGridActions.InitColumnList();
    }


    /* OK ----------------------------------------------------------------------------------------------*/
    private void OuvertureEnCreation()
    {
      try
      {
        //  affectation du recordset à la listbox
        //  recherche de toutes les actions non chiffrées NF sur la DI
        ModuleData.LoadData(dtActions, $"api_sp_ListeActionsApasserEnNF {miNumDI}", MozartDatabase.cnxMozart);
        apiTGridActions.GridControl.DataSource = dtActions;

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
        ModuleData.LoadData(dtActions, $"api_sp_InfoActionNF {miNumAction}", MozartDatabase.cnxMozart);
        apiTGridActions.GridControl.DataSource = dtActions;

        // en modification, il n'y a qu'une ligne (pourquoi foreach ?
        foreach (DataRow item in dtActions.Rows)
        {
          // mise à jour des contrôles
          chkFOU.Checked = Utils.ZeroIfNull(item["BNFFOU"]) == 1;
          chkMO.Checked = Utils.ZeroIfNull(item["BNFMO"]) == 1;
          chkSTT.Checked = Utils.ZeroIfNull(item["BNFSTT"]) == 1;
          chkSortieVeh.Checked = Utils.ZeroIfNull(item["BNFFOUV"]) == 1;
        }

        if (chkSortieVeh.Checked == true)
        { frameFournitures.Visible = true; }
        else
        { frameFournitures.Visible = false; }


      }
      catch (Exception ex)
      {
        MZUtils.displayError(MethodBase.GetCurrentMethod().Name, ex);
      }
    }

    private void cmdEnregistrer_Click(object sender, EventArgs e)
    {
      DataRow row = apiTGridActions.GetFocusedDataRow();
      if (row == null)
      {
        MessageBox.Show(Resources.msg_Must_select_line, Program.AppTitle, MessageBoxButtons.OK, MessageBoxIcon.Information);
        return;
      }

      // test si on a au moins une coche
      if (chkFOU.Checked == false && chkMO.Checked == false && chkSTT.Checked == false && chkSortieVeh.Checked == false)
      {
        MessageBox.Show("Il faut cocher au moins une option", Program.AppTitle, MessageBoxButtons.OK, MessageBoxIcon.Information);
        return;
      }

      EnregistrerElemFact(Convert.ToInt32(row["NACTNUM"]));

      Dispose();
    }

    private void EnregistrerElemFact(int NACTNUM)
    {

      // enregistrement des fournitures si besoin
      //on supprime tous les articles de la table
      ModuleData.CnxExecute($"DELETE FROM TFNF WHERE NACTNUM = {NACTNUM}");

      miNumAction = NACTNUM;

      if (chkSortieVeh.Checked == true)
      {
        foreach (DataRow dr in dtArticle.Rows)
          EnregistrerArticle(dr);
      }

      using (SqlCommand cmd = new SqlCommand("api_sp_creationActionNF", MozartDatabase.cnxMozart))
      {
        cmd.CommandType = CommandType.StoredProcedure;
        SqlCommandBuilder.DeriveParameters(cmd);    // liste des paramètres

        cmd.Parameters["@iNACTNUM"].Value = NACTNUM;
        cmd.Parameters["@bFOU"].Value = chkFOU.Checked ? 1 : 0;
        cmd.Parameters["@bMO"].Value = chkMO.Checked ? 1 : 0;
        cmd.Parameters["@bSTT"].Value = chkSTT.Checked ? 1 : 0;
        cmd.Parameters["@bFOUV"].Value = chkSortieVeh.Checked ? 1 : 0;

        cmd.ExecuteNonQuery();

        mstrStatutElemFact = "M";
      }
    }

    public void FormatapiTGrid()
    {
      try
      {
        apiTGridB.AddColumn(Resources.col_stock, "BSTOCK", 900, "", 2, false, false, true);
        apiTGridB.AddColumn(Resources.col_Serie, "CCFOCOD", 1200);
        apiTGridB.AddColumn(Resources.col_materiel, "VFOUMAT", 5000);
        apiTGridB.AddColumn(Resources.col_marque, "VFOUMAR", 1200);
        apiTGridB.AddColumn(Resources.col_Ref, "VFOUREF", 800);
        apiTGridB.AddColumn(Resources.col_PrixAchatU, "NFNFPRIXACHAT", 2400, "currency", 2);
        apiTGridB.AddColumn(Resources.col_Qte, "NFNFQTE", 1000, "", 2);
        apiTGridB.AddColumn("NACTNUM", "NACTNUM", 0);
        apiTGridB.AddColumn("NFOUNUM", "NFOUNUM", 0);
        apiTGridB.AddColumn(Resources.col_date_modif, "DFNFMODIF", 1200);

        apiTGridB.DelockColumn("NFNFQTE");
        apiTGridB.DelockColumn("BSTOCK");

        apiTGridB.FilterBar = false;

        apiTGridB.InitColumnList();
      }
      catch (Exception ex)
      {
        MZUtils.displayError(MethodBase.GetCurrentMethod().Name, ex);
      }
    }

    private void EnregistrerArticle(DataRow row)
    {

      using (SqlCommand cmd = new SqlCommand("api_sp_creationLigneFouNF", MozartDatabase.cnxMozart))
      {
        cmd.CommandType = CommandType.StoredProcedure;
        SqlCommandBuilder.DeriveParameters(cmd);    // liste des paramètres

        //  liste des paramètres
        cmd.Parameters["@iNACTNUM"].Value = miNumAction;
        cmd.Parameters["@iNFouNum"].Value = Utils.ZeroIfNull(Convert.ToInt32(row["NFOUNUM"]));
        cmd.Parameters["@nFouPrixBase"].Value = 0;
        cmd.Parameters["@nFouPrixClient"].Value = 0;
        cmd.Parameters["@nValQTE"].Value = Utils.BlankIfNull(row["NFNFQTE"].ToString());
        cmd.Parameters["@nFouPrixAchat"].Value = Utils.BlankIfNull(row["NFNFPRIXACHAT"].ToString());
        cmd.Parameters["@bstock"].Value = Utils.BlankIfNull(row["BSTOCK"].ToString());

        cmd.ExecuteNonQuery();
      }
    }


    private void cmdSuppFNF_Click_1(object sender, EventArgs e)
    {
      DataRow currentRow = apiTGridB.GetFocusedDataRow();

      if (dtArticle.Rows.Count == 0 || currentRow == null) return;

      if (MessageBox.Show("Voulez-vous vraiment supprimer cette fourniture ?", Program.AppTitle, MessageBoxButtons.YesNo, MessageBoxIcon.Question,
          MessageBoxDefaultButton.Button2) == DialogResult.Yes)
      {
        ModuleData.CnxExecute($"DELETE FROM TFNF WHERE NFOUNUM = {currentRow["NFOUNUM"]} AND NACTNUM = {currentRow["NACTNUM"]}");

        //réglage du bug en VB6 qui supprimait toute la gridview si avant d'avoir ajouter des fourniture il n'y avait rien
        for (int i = 0; i < dtArticle.Rows.Count; i++)
          if (currentRow == dtArticle.Rows[i])
            dtArticle.Rows.Remove(dtArticle.Rows[i]);

        currentRow.Delete();
      }
    }

    private void cmdRechercher_Click(object sender, EventArgs e)
    {
      Cursor = Cursors.WaitCursor;

      //affichage de la feuille de recherche des fournitures non facturées
      frmRechercheFournituresNF f = new frmRechercheFournituresNF { miNumClient = miNumClient, mdtArticle = dtArticle };
      f.ShowDialog();

      apiTGridB.FilterBar = false;

      //récupère la datatable de frmRechercheFournitureNF pour pouvoir l'afficher et la garder en mémoire si on ouvre une nouvelle fois le second formulaire
      dtArticle = f.mdtArticle;
      apiTGridB.GridControl.DataSource = dtArticle;

      Cursor = Cursors.Default;
    }

    private void chkSortieVeh_CheckedChanged(object sender, EventArgs e)
    {
      if (chkSortieVeh.Checked == true)
      {
        frameFournitures.Visible = true;
      }
      else
      {
        frameFournitures.Visible = false;
      }
    }

    private void cmdFermer_Click(object sender, EventArgs e)
    {
      Dispose();
    }
  }
}
