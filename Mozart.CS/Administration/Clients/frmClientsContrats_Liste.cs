using MozartCS.Properties;
using MozartLib;
using MozartNet;
using System;
using System.Data;
using System.Reflection;
using System.Windows.Forms;
using MZUtils = MozartControls.Utils;

namespace MozartCS
{
  public partial class frmClientsContrats_Liste : Form
  {

    DataTable dt = new DataTable();
    bool bArchives;
    int _NCLINUM;
    public string sNomClient = "";

    public frmClientsContrats_Liste(int C_NCLINUM)
    {
      InitializeComponent();
      _NCLINUM = C_NCLINUM;
    }

    private void frmClientsContrats_Liste_Load(object sender, System.EventArgs e)
    {
      try
      {

        //init
        bArchives = false;

        ModuleMain.Initboutons(this);

        if (sNomClient != "") this.Text = Label14.Text = $"{Label14.Text} {sNomClient}";

        apiTGrid1.LoadData(dt, MozartDatabase.cnxMozart, $"EXEC [api_sp_ContratClient_Detail_Liste] {_NCLINUM}");
        apiTGrid1.GridControl.DataSource = dt;

        InitApigrid();

        apiTGrid1.dgv.ActiveFilterString = "BACTIF = true";

      }
      catch (Exception ex)
      {
        MZUtils.displayError(MethodBase.GetCurrentMethod().Name, ex);
      }
    }

    private void cmdNouvelle_Click(object sender, EventArgs e)
    {
      Cursor.Current = Cursors.WaitCursor;
      frmClientsContrats_Detail f = new frmClientsContrats_Detail(0, _NCLINUM);
      f.ShowDialog();
      Cursor.Current = Cursors.Default;
      apiTGrid1.Requery(dt, MozartDatabase.cnxMozart);
    }

    private void cmdDetail_Click(object sender, EventArgs e)
    {
      DataRow row = apiTGrid1.GetFocusedDataRow();
      if (row == null) return;

      int bookmark = apiTGrid1.dgv.FocusedRowHandle;

      Cursor.Current = Cursors.WaitCursor;
      frmClientsContrats_Detail f = new frmClientsContrats_Detail((int)row["NIDCONTRATCLI_DETAIL"], _NCLINUM, bArchives);
      f.ShowDialog();
      Cursor.Current = Cursors.Default;

      apiTGrid1.Requery(dt, MozartDatabase.cnxMozart);

      apiTGrid1.dgv.FocusedRowHandle = bookmark;
    }


    private void cmdSupprimer_Click(object sender, EventArgs e)
    {
      //try
      //{
      //  DataRow currentRow = apiTGrid1.GetFocusedDataRow();
      //  if (currentRow == null) return;

      //  if (MessageBox.Show(Resources.msg_ConfirmArchMateriel, Program.AppTitle, MessageBoxButtons.YesNo, MessageBoxIcon.Question, MessageBoxDefaultButton.Button2) == DialogResult.Yes)
      //  {
      //    ModuleData.ExecuteNonQuery($"Update TREF_FORMULE_REV set BACTIF = 0 WHERE NIDFORMULE_REV = { Convert.ToInt32(currentRow["NIDFORMULE_REV"])} ");
      //    apiTGrid1.Requery(dt, MozartDatabase.cnxMozart);
      //  }
      //}
      //catch (Exception ex)
      //{
      //  MessageBox.Show($"{ex.Message}\r\n\r\n{Resources.Global_dans}{MethodBase.GetCurrentMethod().Name}",
      //                  Resources.Global_Erreur, MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
      //}
    }


    private void InitApigrid()
    {
      try
      {

        apiTGrid1.AddColumn(Resources.col_Comptes_concernes, "STR_LST_CAN", 1500); //"Comptes concernés"
        apiTGrid1.AddColumn(Resources.col_Pays, "STR_LST_PAYS", 1500); //"Pays"
        apiTGrid1.AddColumn(Resources.col_Sites, "STR_LST_SITES", 2000); //Sites
                apiTGrid1.AddColumn(Resources.col_Nom_du_doc, "VNOMDOCUMENT", 1500);  //Nom du document
                apiTGrid1.AddColumn(Resources.col_date_debut_libelle, "DDATE_DEBUT", 1500, "dd/mm/yyyy"); //Date de début
                apiTGrid1.AddColumn(Resources.col_date_fin_libelle, "DDATE_FIN", 1500, "dd/mm/yyyy"); //Date de fin
                apiTGrid1.AddColumn(Resources.col_Formule_de_revision, "VFORMULE_REV", 1500); //Formule de révision
                apiTGrid1.AddColumn(Resources.col_Tacite, "VCONTRATCLI_TACITE", 1500); //Tacite
                apiTGrid1.AddColumn("NIDCONTRATCLI_DETAIL", "NIDCONTRATCLI_DETAIL", 0); //NIDCONTRATCLI_DETAIL
                apiTGrid1.AddColumn("BACTIF", "BACTIF", 0); //BACTIF

                apiTGrid1.InitColumnList();
      }
      catch (Exception ex)
      {
        MZUtils.displayError(MethodBase.GetCurrentMethod().Name, ex);
      }
    }


    private void cmdRestaurer_Click(object sender, EventArgs e)
    {
      try
      {
        DataRow currentRow = apiTGrid1.GetFocusedDataRow();
        if (currentRow == null) return;

                //Voulez-vous restaurer ce contrat ?
                if (MessageBox.Show(Resources.msg_Voulez_vous_restaurer_ce_contrat, Program.AppTitle, MessageBoxButtons.YesNo, MessageBoxIcon.Question, MessageBoxDefaultButton.Button2) == DialogResult.Yes)
        {
          ModuleData.ExecuteNonQuery($"EXEC [api_sp_ContratClient_Detail_ArchiveOrRestore] {Convert.ToInt32(currentRow["NIDCONTRATCLI_DETAIL"])}, 1 ");
          apiTGrid1.Requery(dt, MozartDatabase.cnxMozart);
        }
      }
      catch (Exception ex)
      {
        MZUtils.displayError(MethodBase.GetCurrentMethod().Name, ex);
      }

    }

    private void frmListeFournituresInd_FormClosed(object sender, FormClosedEventArgs e)
    {
      Cursor.Current = Cursors.Default;
    }

    private void cmdFermer_Click(object sender, System.EventArgs e)
    {
      Dispose();
    }

    private void cmdArchive_Click(object sender, EventArgs e)
    {
      if (bArchives == false)
      {
        apiTGrid1.dgv.ActiveFilterString = "BACTIF = false";
                this.Text = $"{Resources.txt_Contrats_archivees_du_client} :";// "Contrats archivées du client : ";
                cmdArchive.Text = Resources.txt_Liste_des_actives; //"Liste des actives";
        BtnArchiver.Visible = cmdNouvelle.Visible = BtnFormuleRev.Visible = false;
        bArchives = true;
      }
      else
      {
        apiTGrid1.dgv.ActiveFilterString = "BACTIF = true";
        BtnArchiver.Visible = cmdNouvelle.Visible = BtnFormuleRev.Visible = true;
                cmdArchive.Text = Resources.txt_Liste_des_archives; // "Liste des archives";
                this.Text = $"{Resources.txt_Contrats_du_client} :"; // "Contrats du client : ";
        bArchives = false;
      }
      Label14.Text = this.Text;

    }

    private void BtnArchiver_Click(object sender, EventArgs e)
    {
      try
      {
        DataRow currentRow = apiTGrid1.GetFocusedDataRow();
        if (currentRow == null) return;

                //Voulez-vous archiver ce contrat ?
                if (MessageBox.Show(Resources.msg_Voulez_vous_archiver_ce_contrat, Program.AppTitle, MessageBoxButtons.YesNo, MessageBoxIcon.Question, MessageBoxDefaultButton.Button2) == DialogResult.Yes)
        {
          ModuleData.ExecuteNonQuery($"EXEC [api_sp_ContratClient_Detail_ArchiveOrRestore] {Convert.ToInt32(currentRow["NIDCONTRATCLI_DETAIL"])}, 0 ");
          apiTGrid1.Requery(dt, MozartDatabase.cnxMozart);
        }
      }
      catch (Exception ex)
      {
        MZUtils.displayError(MethodBase.GetCurrentMethod().Name, ex);
      }
    }

    private void BtnFormuleRev_Click(object sender, EventArgs e)
    {
      new frmListeFormuleRev().ShowDialog();
    }

    private void BtnVisu_Click(object sender, EventArgs e)
    {
      DataRow currentRow = apiTGrid1.GetFocusedDataRow();
      if (currentRow == null) return;

      CCONTRATCLI_DETAIL oContratCliDetail = new CCONTRATCLI_DETAIL((int)currentRow["NIDCONTRATCLI_DETAIL"], (int)currentRow["NCLINUM"]);

      if (oContratCliDetail == null) return;

      if (oContratCliDetail.VFILE_DOCUMENT == "")
      {
              //  "Il n'y a aucun document"
        MessageBox.Show(Resources.msg_Il_n_y_a_aucun_document, Resources.msg_information, MessageBoxButtons.OK, MessageBoxIcon.Information);
        return;
      }


            if (CImpersonation.FileExistImpersonated(oContratCliDetail.RepertoireDoc + oContratCliDetail.VFILE_DOCUMENT))
            {
                //new FrmBrowser(){.Navigate(CImpersonation.OpenFileImpersonated(oCCONTRATCLI_DETAIL.RepertoireDoc + oCCONTRATCLI_DETAIL.VFILE_DOCUMENT));

                MozartCS.frmBrowser o = new MozartCS.frmBrowser();
                o.msStartingAddress = CImpersonation.OpenFileImpersonated(oContratCliDetail.RepertoireDoc + oContratCliDetail.VFILE_DOCUMENT);
                o.ShowDialog();
            }
            return;
            //      if (File.Exists(oContratCliDetail.RepertoireDoc + oContratCliDetail.VFILE_DOCUMENT))
            //{
            //  MozartCS.Modules.CGest_FileTemp_MOZARIS oCFileTMP = new MozartCS.Modules.CGest_FileTemp_MOZARIS();
            //  Process.Start(oCFileTMP.PathFilePrevisuTemp(oContratCliDetail.RepertoireDoc + oContratCliDetail.VFILE_DOCUMENT));

        //}
    }
  }
}