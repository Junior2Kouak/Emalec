using MozartCS.Properties;
using MozartLib;
using MozartNet;
using System;
using System.Data;
using System.IO;
using System.Reflection;
using System.Windows.Forms;
using MZUtils = MozartControls.Utils;

namespace MozartCS
{
  public partial class frmListeDocArch : Form
  {
    private string mRepertoireDoc;
    DataTable dt = new DataTable();

    public frmListeDocArch(string pRepertoireDoc)
    {
      InitializeComponent();

      mRepertoireDoc = pRepertoireDoc;
    }

    private void frmListeDocArch_Load(object sender, EventArgs e)
    {
      try
      {
        // Gestion de droits différents sur les boutons selon le type de page
        cmdSupprimer.HelpContextID = 360;
        cmdRestaurer.HelpContextID = 358;

        ModuleMain.Initboutons(this);

        InitGrid();
      }
      catch (Exception ex)
      {
        MZUtils.displayError(MethodBase.GetCurrentMethod().Name, ex);
      }
    }

    private void cmdFermer_Click(object sender, EventArgs e)
    {
      Dispose();
    }

    private void CmdVisu_Click(object sender, EventArgs e)
    {
      if (apiTGrid1.GetFocusedDataRow() == null) return;

      frmBrowser f = new frmBrowser
      {
        msStartingAddress = mRepertoireDoc + apiTGrid1.GetFocusedDataRow()["VFICHIER"].ToString()
      };
      f.ShowDialog();
    }

    private void cmdSupprimer_Click(object sender, EventArgs e)
    {
      if (apiTGrid1.GetFocusedDataRow() == null) return;

      if (MessageBox.Show(Resources.msg_confirm_document_deletion, Program.AppTitle, MessageBoxButtons.YesNo, MessageBoxIcon.Question, MessageBoxDefaultButton.Button2) == DialogResult.Yes)
      {
        File.Delete(mRepertoireDoc + "NOTICES" + apiTGrid1.GetFocusedDataRow()["NIDDOC"].ToString() + ".pdf");
        ModuleData.ExecuteNonQuery("DELETE TDOCEMALEC WHERE NIDDOC = " + apiTGrid1.GetFocusedDataRow()["NIDDOC"].ToString());
        apiTGrid1.Requery(dt, MozartDatabase.cnxMozart);
      }
    }

    private void cmdRestaurer_Click(object sender, EventArgs e)
    {
      if (apiTGrid1.GetFocusedDataRow() == null) return;

      if (MessageBox.Show(Resources.msg_confirm_document_restore, Program.AppTitle, MessageBoxButtons.YesNo, MessageBoxIcon.Question, MessageBoxDefaultButton.Button2) == DialogResult.Yes)
      {
        ModuleData.ExecuteNonQuery("UPDATE TDOCEMALEC SET CACTIF='O' WHERE NIDDOC = " + apiTGrid1.GetFocusedDataRow()["NIDDOC"].ToString());
        apiTGrid1.Requery(dt, MozartDatabase.cnxMozart);
      }
    }

    private void InitGrid()
    {
      apiTGrid1.AddColumn(Resources.col_Num, "NIDDOC", 800);
      apiTGrid1.AddColumn(Resources.col_Date, "DATECRE", 1000, "dd/mm/yy", 2);
      apiTGrid1.AddColumn(Resources.col_Type, "VTYPE", 1200);
      apiTGrid1.AddColumn(Resources.col_Titre, "VTITRE", 9000);

      apiTGrid1.LoadData(dt, MozartDatabase.cnxMozart, "SELECT * FROM TDOCEMALEC WHERE VTYPE='NOTICES' and cactif <> 'O'");
      apiTGrid1.GridControl.DataSource = dt;
    }
  }
}