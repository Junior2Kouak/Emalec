using DevExpress.XtraGrid.Views.Grid;
using MozartCS.Properties;
using MozartLib;
using MozartNet;
using System;
using System.Data;
using System.Drawing;
using System.Reflection;
using System.Windows.Forms;
using MZUtils = MozartControls.Utils;

namespace MozartCS
{
  public partial class frmGestDocAdminSTF : Form
  {
    public long miStfGrpNnum;
    public string mstrNom;

    int mModeAffiche; //0: archives, 1: actif

    DataTable dtLstDocSTF = new DataTable();
    DataTable dtLstDocSTFArch = new DataTable();
    DataTable dt = new DataTable();

    public frmGestDocAdminSTF() { InitializeComponent(); }

    private void frmGestDocAdminSTF_Load(object sender, System.EventArgs e)
    {
      try
      {
        ModuleMain.Initboutons(this);
        ToolTip tt = new ToolTip();
        //Init
        mModeAffiche = 1;
        cmdSuppRestaure.Text = Resources.txt_Archiver;
        tt.SetToolTip(cmdSuppRestaure, cmdSuppRestaure.Text);

        Label2.Text = mstrNom;

        apiTGrid1.LoadData(dtLstDocSTF, MozartDatabase.cnxMozart, $"EXEC api_sp_ListeDocAdminSTF {miStfGrpNnum} , {mModeAffiche}");
        apiTGrid1.GridControl.DataSource = dtLstDocSTF;
        InitApigrid();

        apiTGrid2.LoadData(dt, MozartDatabase.cnxMozart, $"EXEC api_sp_StatutDocSTF {miStfGrpNnum}");
        apiTGrid2.GridControl.DataSource = dt;
        InitApigridStat();


      }
      catch (Exception ex)
      {
        MZUtils.displayError(MethodBase.GetCurrentMethod().Name, ex);
      }
    }

    private void CmdAjout_Click(object sender, EventArgs e)
    {
      frmDetailDocAdminSTF f = new frmDetailDocAdminSTF();
      f.miDocAdminSTFNum = 0;
      f.miSTFGRPNUM = miStfGrpNnum;
      f.mstrNom = mstrNom;
      f.ShowDialog();

      apiTGrid1.Requery(dtLstDocSTF, MozartDatabase.cnxMozart);
      apiTGrid2.Requery(dt, MozartDatabase.cnxMozart);
    }

    private void CmdDetail_Click(object sender, EventArgs e)
    {
      DataRow currentRow = apiTGrid1.GetFocusedDataRow();
      if (currentRow == null) return;

      frmDetailDocAdminSTF f = new frmDetailDocAdminSTF();
      f.miDocAdminSTFNum = Convert.ToInt64(currentRow["NDOCSTFNUM"]);
      f.miSTFGRPNUM = miStfGrpNnum;
      f.mstrNom = mstrNom;
      f.ShowDialog();

      apiTGrid1.Requery(dtLstDocSTF, MozartDatabase.cnxMozart);
      apiTGrid2.Requery(dt, MozartDatabase.cnxMozart);
    }

    private void CmdVisu_Click(object sender, EventArgs e)
    {
      DataRow currentRow = apiTGrid1.GetFocusedDataRow();
      if (currentRow == null) return;

      frmBrowser f = new frmBrowser();
      f.msStartingAddress = Utils.RechercheParam("REP_DOC_STF") + currentRow["VDOCSTFNOM"].ToString();
      f.ShowDialog();
    }

    private void cmdCourRelance_Click(object sender, EventArgs e)
    {
      frmListeCourrierSTT f = new frmListeCourrierSTT();
      f.miStfGrpNnum = miStfGrpNnum;
      f.mvStfGrpNom = mstrNom;
      f.ShowDialog();
    }

    private void CmdSuppRestaure_Click(object sender, EventArgs e)
    {
      DataRow row = apiTGrid1.GetFocusedDataRow();
      if (row == null) return;

      if (mModeAffiche == 1)
      {
        if (MessageBox.Show("Voulez-vous vraiment archiver ce document ?", Program.AppTitle, MessageBoxButtons.YesNo, MessageBoxIcon.Question, MessageBoxDefaultButton.Button2) == DialogResult.Yes)
        {
          ModuleData.ExecuteNonQuery($"UPDATE TDOCSTF SET BDOCSTFACTIF = 0 WHERE NDOCSTFNUM = {row["NDOCSTFNUM"]}");
          apiTGrid1.Requery(dtLstDocSTF, MozartDatabase.cnxMozart);
        }
      }
      else
      {
        if (MessageBox.Show("Voulez-vous vraiment restaurer ce document ?", Program.AppTitle, MessageBoxButtons.YesNo, MessageBoxIcon.Question, MessageBoxDefaultButton.Button2) == DialogResult.Yes)
        {
          ModuleData.ExecuteNonQuery($"UPDATE TDOCSTF SET BDOCSTFACTIF = 1 WHERE NDOCSTFNUM = {row["NDOCSTFNUM"]}");
          apiTGrid1.Requery(dtLstDocSTFArch, MozartDatabase.cnxMozart);
        }
      }
    }

    private void CmdArchives_Click(object sender, EventArgs e)
    {
      ToolTip tt = new ToolTip();
      if (mModeAffiche == 1)
      {
        mModeAffiche = 0;
        Label1.Text = Resources.txt_Gestion_docs_admin_arch_sous_traitant + " :";
        cmdAjout.Visible = false;
        cmdDetail.Visible = false;
        cmdSuppRestaure.Text = Resources.txt_Restaurer;
        cmdArchives.Text = Resources.txt_Retour;
        tt.SetToolTip(cmdSuppRestaure, cmdSuppRestaure.Text);
      }
      else
      {
        mModeAffiche = 1;
        Label1.Text = Resources.txt_Gestion_docs_admin_sous_traitant + " :"; ;
        cmdAjout.Visible = true;
        cmdDetail.Visible = true;
        cmdSuppRestaure.Text = Resources.txt_Archiver;
        cmdArchives.Text = Resources.txt_Archives;
        tt.SetToolTip(cmdSuppRestaure, cmdSuppRestaure.Text);
      }

      apiTGrid1.LoadData(dtLstDocSTFArch, MozartDatabase.cnxMozart, $"EXEC api_sp_ListeDocAdminSTF {miStfGrpNnum}, {mModeAffiche}");
      apiTGrid1.GridControl.DataSource = dtLstDocSTFArch;

      apiTGrid1.InitColumnList();
    }

    private void InitApigrid()
    {
      try
      {
        apiTGrid1.AddColumn("NDOCSTFNUM", "NDOCSTFNUM", 0);
        apiTGrid1.AddColumn("NSTFGRPNUM", "NSTFGRPNUM", 0);
        apiTGrid1.AddColumn(Resources.col_Nom_du_doc, "VTYPEDOCSTFLIB", 7000);
        apiTGrid1.AddColumn(Resources.col_date_fin_validite, "DDOCSTFEDI", 2500, "", 2);
        apiTGrid1.AddColumn("Saisi par", "VPERNOM", 2000);
        apiTGrid1.AddColumn("Date de saisie", "DDOCSTFCRE", 2000, "", 2);
        apiTGrid1.AddColumn("NTYPEDOCSTFNUM", "NTYPEDOCSTFNUM", 0);
        apiTGrid1.AddColumn("NQUICREE", "NQUICREE", 0);
        apiTGrid1.AddColumn("VDOCSTFCOM", "VDOCSTFCOM", 0);
        apiTGrid1.AddColumn("VDOCSTFNOM", "VDOCSTFNOM", 0);



        apiTGrid1.InitColumnList();
      }
      catch (Exception ex)
      {
        MZUtils.displayError(MethodBase.GetCurrentMethod().Name, ex);
      }
    }

    private void InitApigridStat()
    {
      apiTGrid2.AddColumn("NSTFGRPNUM", "NSTFGRPNUM", 0);
      apiTGrid2.AddColumn("Statut", "VLIBSTATUT", 1200);
      apiTGrid2.AddColumn("Nb ctrts", "NBCST", 1200, "", 1);
      apiTGrid2.AddColumn("CA STT", "NSTFGRPCA", 1300, "# ### ##0 €", 1);
      apiTGrid2.AddColumn("CA " + MozartParams.NomGroupe + " 12 mois", "NSTFGRPFA", 1300, "# ### ##0 €", 1);
      apiTGrid2.AddColumn("Dépendance %", "TAUX", 1500, "00%", 1);
      apiTGrid2.AddColumn("Fac Bloc", "FB", 1000, "", 1);
      apiTGrid2.AddColumn("Kbis", "DOC1", 1100, "", 0, true);
      apiTGrid2.AddColumn("RC", "DOC2", 1100, "", 0, true);
      apiTGrid2.AddColumn("Décennale", "DOC3", 1200, "", 0, true);
      apiTGrid2.AddColumn("Sociale", "DOC4", 1200, "", 0, true);
      apiTGrid2.AddColumn("Fiscale", "DOC5", 1200, "", 0, true);
      apiTGrid2.AddColumn("CGASTT", "DOC9", 1250);
      apiTGrid2.AddColumn("Attestation de formation", "DOC10", 1200, "", 0, true);
      apiTGrid2.AddColumn("Fluides", "DOC11", 1150, "", 0, true);
      apiTGrid2.AddColumn("Décennale", "DECENNALE", 0);
      apiTGrid2.AddColumn("CSTFGRPSANSDOC", "CSTFGRPSANSDOC", 0);  // pas de gestion des docs adm du STT

      apiTGrid2.InitColumnList();
    }

    private void apiTGrid2_RowCellStyle(object sender, DevExpress.XtraGrid.Views.Grid.RowCellStyleEventArgs e)
    {
      // pas de gestion des couleurs si STT sans gestion des docs Admin
      if (e.RowHandle >= 0 && (sender as GridView).GetDataRow(e.RowHandle)["CSTFGRPSANSDOC"].ToString() == "O")
        return;

      // Gestion spécifique des couleurs
      if (e.Column.Name == "DOC1" || e.Column.Name == "DOC2" || e.Column.Name == "DOC4" || e.Column.Name == "DOC5")
      {
        if (e.CellValue != null && e.CellValue != DBNull.Value)
        {
          if (Convert.ToDateTime(e.CellValue) < DateTime.Now)
            e.Appearance.BackColor = Color.FromArgb(128, 255, 255); //'Périmé
          if (Convert.ToDateTime(e.CellValue) >= DateTime.Now)
            e.Appearance.BackColor = Color.FromArgb(128, 255, 128); //OK
        }
        else
          e.Appearance.BackColor = Color.FromArgb(255, 192, 255);   //non conforme
      }

      // si pas de décennale obligatoire, cellule en gris sinon gestion couleur selon date
      if (e.Column.Name == "DOC3")
      {
        if (e.RowHandle >= 0 && (sender as GridView).GetDataRow(e.RowHandle)["DECENNALE"].ToString() == "N")
        {
          e.Appearance.BackColor = Color.FromArgb(204, 204, 204);
        }
        else
        {
          if (e.CellValue != null && e.CellValue != DBNull.Value)
          {
            if (Convert.ToDateTime(e.CellValue) < DateTime.Now)
              e.Appearance.BackColor = Color.FromArgb(128, 255, 255);  //'Périmé
            if (Convert.ToDateTime(e.CellValue) >= DateTime.Now)
              e.Appearance.BackColor = Color.FromArgb(128, 255, 128);   //OK
          }
          else
            e.Appearance.BackColor = Color.FromArgb(255, 192, 255);   //non conforme
        }
      }
      if (e.Column.Name == "DOC11")
      {
        // nouvelle gestion de l'attestation fluide FGA le 15/11/23
        // si STT en clim froid on test comme un doc obligatoire, sinon on fait le test simple de présence du doc
        if (e.RowHandle >= 0 && (sender as GridView).GetDataRow(e.RowHandle)["FF"].ToString() != "0")
        {
          if (e.CellValue != null && e.CellValue != DBNull.Value)
          {
            if (Convert.ToDateTime(e.CellValue) < DateTime.Now)
              e.Appearance.BackColor = Color.FromArgb(128, 255, 255); //'Périmé
            if (Convert.ToDateTime(e.CellValue) >= DateTime.Now)
              e.Appearance.BackColor = Color.FromArgb(128, 255, 128); //OK
          }
          else
            e.Appearance.BackColor = Color.FromArgb(255, 192, 255);   //non conforme
        }
      }
    }


    private void cmdFermer_Click(object sender, System.EventArgs e)
    {
      Dispose();
    }
  }
}