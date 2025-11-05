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
  public partial class frmListeFormuleRev : Form
  {

    DataTable dt = new DataTable();
    bool bArchives;

    public frmListeFormuleRev()
    {
      InitializeComponent();
    }

    private void frmListeFormuleRev_Load(object sender, System.EventArgs e)
    {
      try
      {

        //init
        bArchives = false;

        ModuleMain.Initboutons(this);

        apiTGrid1.LoadData(dt, MozartDatabase.cnxMozart, "EXEC [api_sp_FormuleRev_Liste]");
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
      frmDetailFormuleRev f = new frmDetailFormuleRev(0);
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
      frmDetailFormuleRev f = new frmDetailFormuleRev((int)row["NIDFORMULE_REV"]);
      f.ShowDialog();
      Cursor.Current = Cursors.Default;

      apiTGrid1.Requery(dt, MozartDatabase.cnxMozart);

      apiTGrid1.dgv.FocusedRowHandle = bookmark;
    }


    private void cmdSupprimer_Click(object sender, EventArgs e)
    {
      try
      {
        DataRow currentRow = apiTGrid1.GetFocusedDataRow();
        if (currentRow == null) return;

        if (MessageBox.Show(Resources.msg_ConfirmArchMateriel, Program.AppTitle, MessageBoxButtons.YesNo, MessageBoxIcon.Question, MessageBoxDefaultButton.Button2) == DialogResult.Yes)
        {
          ModuleData.ExecuteNonQuery($"Update TREF_FORMULE_REV set BACTIF = 0 WHERE NIDFORMULE_REV = { Convert.ToInt32(currentRow["NIDFORMULE_REV"])} ");
          apiTGrid1.Requery(dt, MozartDatabase.cnxMozart);
        }
      }
      catch (Exception ex)
      {
        MZUtils.displayError(MethodBase.GetCurrentMethod().Name, ex);
      }
    }


    private void InitApigrid()
    {
      try
      {

        apiTGrid1.AddColumn("N°", "NIDFORMULE_REV", 1500);
        apiTGrid1.AddColumn("Formule", "VFORMULE_REV", 1500);
        apiTGrid1.AddColumn("Date dernière modification", "DLASTMOD", 2000, "dd/mm/yyyy");
        apiTGrid1.AddColumn("NQUIMOD", "NQUIMOD", 0);

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

        if (MessageBox.Show(Resources.msg_Confirm_restaurer_materiel, Program.AppTitle, MessageBoxButtons.YesNo, MessageBoxIcon.Question, MessageBoxDefaultButton.Button2) == DialogResult.Yes)
        {
          ModuleData.ExecuteNonQuery($"Update TREF_FORMULE_REV set BACTIF = 1 WHERE NIDFORMULE_REV = { Convert.ToInt32(currentRow["NIDFORMULE_REV"])} ");
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
        this.Text = "Formules de révision archivées";
        cmdArchive.Text = "Liste des actives";
        BtnArchiver.Visible = false;
        bArchives = true;
      }
      else
      {
        apiTGrid1.dgv.ActiveFilterString = "BACTIF = true";
        BtnArchiver.Visible = true;
        cmdArchive.Text = "Liste des archives";
        this.Text = "Formules de révision";
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

        if (MessageBox.Show(Resources.msg_Confirm_restaurer_materiel, Program.AppTitle, MessageBoxButtons.YesNo, MessageBoxIcon.Question, MessageBoxDefaultButton.Button2) == DialogResult.Yes)
        {
          ModuleData.ExecuteNonQuery($"Update TREF_FORMULE_REV set BACTIF = 0 WHERE NIDFORMULE_REV = { Convert.ToInt32(currentRow["NIDFORMULE_REV"])} ");
          apiTGrid1.Requery(dt, MozartDatabase.cnxMozart);
        }
      }
      catch (Exception ex)
      {
        MZUtils.displayError(MethodBase.GetCurrentMethod().Name, ex);
      }
    }
  }
}