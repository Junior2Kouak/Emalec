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
  public partial class frmListeDoc : Form
  {
    private string mRepertoireDoc = "";
    private DataTable dt = new DataTable();

    public frmListeDoc()
    {
      InitializeComponent();
    }

    private void frmListeDoc_Load(object sender, EventArgs e)
    {
      try
      {
        mRepertoireDoc = Utils.RechercheParam("REP_NOTICES_INFO");

        ModuleMain.Initboutons(this);

        InitGrid();
      }
      catch (Exception ex)
      {
        MZUtils.displayError(MethodBase.GetCurrentMethod().Name, ex);
      }
    }

    private void cmdAjouter_Click(object sender, EventArgs e)
    {
      new frmDetailDoc(mRepertoireDoc, 0).ShowDialog();

      apiTGrid1.Requery(dt, MozartDatabase.cnxMozart);
    }

    private void CmdModifier_Click(object sender, EventArgs e)
    {
      if (apiTGrid1.GetFocusedDataRow() == null) return;

      new frmDetailDoc(mRepertoireDoc, (int)apiTGrid1.GetFocusedDataRow()["NIDDOC"]).ShowDialog();

      apiTGrid1.Requery(dt, MozartDatabase.cnxMozart);
    }

    private void CmdVisu_Click(object sender, EventArgs e)
    {
      try
      {
        if (apiTGrid1.GetFocusedDataRow() == null) return;

        new frmBrowser
        {
          msStartingAddress = CImpersonation.OpenFileImpersonated(mRepertoireDoc + apiTGrid1.GetFocusedDataRow()["VFICHIER"].ToString())
        }.ShowDialog();
      }
      catch (Exception ex)
      {
        MZUtils.displayError(MethodBase.GetCurrentMethod().Name, ex);
      }
    }

    private void cmdArch_Click(object sender, EventArgs e)
    {
      if (apiTGrid1.GetFocusedDataRow() == null) return;

      if (MessageBox.Show(Resources.msg_confirm_document_archive, Program.AppTitle, MessageBoxButtons.YesNo,
                          MessageBoxIcon.Question, MessageBoxDefaultButton.Button2) == DialogResult.Yes)
      {
        ModuleData.ExecuteNonQuery("UPDATE TDOCEMALEC SET CACTIF='N' WHERE NIDDOC = " + apiTGrid1.GetFocusedDataRow()["NIDDOC"].ToString());
      }

      apiTGrid1.Requery(dt, MozartDatabase.cnxMozart);
    }

    private void cmdArchive_Click(object sender, EventArgs e)
    {
      new frmListeDocArch(mRepertoireDoc).ShowDialog();
    }

    private void InitGrid()
    {
      apiTGrid1.AddColumn(Resources.col_Num, "NIDDOC", 800);
      apiTGrid1.AddColumn(Resources.col_Date, "DATECRE", 1000, "dd/mm/yy", 2);
      apiTGrid1.AddColumn(Resources.col_Type, "VTYPE", 1200);
      apiTGrid1.AddColumn(Resources.col_Titre, "VTITRE", 9000);

      apiTGrid1.LoadData(dt, MozartDatabase.cnxMozart, "SELECT * FROM TDOCEMALEC WHERE VTYPE='NOTICES' and cactif = 'O'");
      apiTGrid1.GridControl.DataSource = dt;
    }
  }
}