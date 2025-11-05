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
  public partial class frmListeCle : Form
  {

    DataTable dt = new DataTable();

    public frmListeCle()
    {
      InitializeComponent();
    }

    private void frmListeFournituresInd_Load(object sender, System.EventArgs e)
    {
      try
      {
        ModuleMain.Initboutons(this);

        apiTGrid1.LoadData(dt, MozartDatabase.cnxMozart, "select * from api_v_listeCles");
        apiTGrid1.GridControl.DataSource = dt;

        InitApigrid();

        apiTGrid1.dgv.ActiveFilterString = "CCLEACTIF='O'";
      }
      catch (Exception ex)
      {
        MZUtils.displayError(MethodBase.GetCurrentMethod().Name, ex);
      }
    }


    private void cmdNouvelle_Click(object sender, EventArgs e)
    {
      Cursor.Current = Cursors.WaitCursor;
      frmDetailsCle f = new frmDetailsCle();
      f.miNumCle = 0;
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
      frmDetailsCle f = new frmDetailsCle();
      f.miNumCle = Convert.ToInt32(row["NCLENUM"]);
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
          ModuleData.ExecuteNonQuery($"Update TCLE set CCLEACTIF = 'N' WHERE NCLENUM = { Convert.ToInt32(currentRow["NCLENUM"])} ");
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

        apiTGrid1.AddColumn(Resources.col_reference, "VCLEREF", 1500);
        apiTGrid1.AddColumn("Clé sous orga", "CLEORGA", 1500, "", 2);
        apiTGrid1.AddColumn("N° clé sous orga", "VCLENUMORGA", 2000);
        apiTGrid1.AddColumn("Désignation", "VCLELIB", 3000);
        apiTGrid1.AddColumn("affectation", "VCLEAFFECTATION", 3000);
        apiTGrid1.AddColumn("Détenu par ", "VCLEDETENU", 3000);
        apiTGrid1.AddColumn(Resources.col_date_entree, "DCLEDATE", 2000, "dd/mm/yy", 2);
        apiTGrid1.AddColumn("Actif (O/N)", "CCLEACTIF", 1000, "", 2);
        apiTGrid1.AddColumn(Resources.col_Observations, "VCLEOBS", 4000);
        apiTGrid1.AddColumn("NCLENUM", "NCLENUM", 0);


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
          ModuleData.ExecuteNonQuery($"Update TCLE set CCLEACTIF = 'O' WHERE NCLENUM = { Convert.ToInt32(currentRow["NCLENUM"])} ");
          apiTGrid1.Requery(dt, MozartDatabase.cnxMozart);
        }
      }
      catch (Exception ex)
      {
        MZUtils.displayError(MethodBase.GetCurrentMethod().Name, ex);
      }
    }

    private void Check2_CheckedChanged(object sender, EventArgs e)
    {
      if (Check2.Checked)
        apiTGrid1.dgv.ActiveFilterString = "CCLEACTIF='N'";
      else
        apiTGrid1.dgv.ActiveFilterString = "CCLEACTIF='O'";
    }

    private void frmListeFournituresInd_FormClosed(object sender, FormClosedEventArgs e)
    {
      Cursor.Current = Cursors.Default;
    }

    private void cmdFermer_Click(object sender, System.EventArgs e)
    {
      Dispose();
    }
  }
}