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
  public partial class frmOutillageDocGest : Form
  {
    public long miID_OUT;
    public string msVTYPE_OUT = "";
    string sPathDocOutillage = "";
    DataTable dt = new DataTable();

    public frmOutillageDocGest()
    {
      InitializeComponent();
    }

    /* OK--------------------------------------------------------------------------*/
    private void frmOutillageDocGest_Load(object sender, System.EventArgs e)
    {
      try
      {
        ModuleMain.Initboutons(this);
        sPathDocOutillage = ModuleData.RechercheParam("REP_OUTILLAGE_DOC", MozartParams.NomSociete);

        apiTGrid1.LoadData(dt, MozartDatabase.cnxMozart, $"EXEC api_sp_OutillageDoc_Liste {miID_OUT}, '{msVTYPE_OUT}'");
        apiTGrid1.GridControl.DataSource = dt;

        InitApiTgrid();
      }
      catch (Exception ex)
      {
        MZUtils.displayError(MethodBase.GetCurrentMethod().Name, ex);
      }
    }

    private void cmdFermer_Click(object sender, System.EventArgs e)
    {
      Dispose();
    }

    private void cmdAjouter_Click(object sender, EventArgs e)
    {
      Cursor.Current = Cursors.WaitCursor;
      frmOutillageDocDetail f = new frmOutillageDocDetail();
      f.NOUT_DOC_ID = 0;
      f.NID_OUT = miID_OUT;
      f.VTYPE_OUT = msVTYPE_OUT;
      f.ShowDialog();
      apiTGrid1.Requery(dt, MozartDatabase.cnxMozart);
      Cursor.Current = Cursors.Default;
    }

    private void CmdModifier_Click(object sender, EventArgs e)
    {
      DataRow row = apiTGrid1.GetFocusedDataRow();
      if (row == null) return;

      Cursor.Current = Cursors.WaitCursor;

      frmOutillageDocDetail f = new frmOutillageDocDetail();
      f.NOUT_DOC_ID = Convert.ToInt64(row["NOUT_DOC_ID"]);
      f.NID_OUT = Convert.ToInt64(row["NID_OUT"]);
      f.VTYPE_OUT = row["VTYPE_OUT"].ToString();
      f.ShowDialog();
      apiTGrid1.Requery(dt, MozartDatabase.cnxMozart);
      Cursor.Current = Cursors.Default;
    }

    private void CmdVisu_Click(object sender, EventArgs e)
    {
      DataRow currentRow = apiTGrid1.GetFocusedDataRow();
      if (currentRow == null) return;

      frmBrowser f = new frmBrowser();
      f.msStartingAddress = sPathDocOutillage + currentRow["VFILENAME"];
      f.ShowDialog();
    }

    private void cmdArch_Click(object sender, EventArgs e)
    {
      try
      {
        DataRow row = apiTGrid1.GetFocusedDataRow();
        if (row == null) return;

        if (MessageBox.Show(Resources.msg_Confirm_sup_doc, Program.AppTitle, MessageBoxButtons.YesNo, MessageBoxIcon.Question, MessageBoxDefaultButton.Button2) == DialogResult.Yes)
        {
          //suppression du fichier
          if (File.Exists(sPathDocOutillage + row["VFILENAME"]) && row["VFILENAME"].ToString() != "")
            File.Delete(sPathDocOutillage + row["VFILENAME"]);

          ModuleData.ExecuteNonQuery($"DELETE FROM TOUT_DOC WHERE NOUT_DOC_ID = {row["NOUT_DOC_ID"]}");
        }
        apiTGrid1.Requery(dt, MozartDatabase.cnxMozart);
      }
      catch (Exception ex)
      {
        Cursor.Current = Cursors.Default;
        MZUtils.displayError(MethodBase.GetCurrentMethod().Name, ex);
      }
    }

    private void InitApiTgrid()
    {
      apiTGrid1.AddColumn("NOUT_DOC_ID", "NOUT_DOC_ID", 0);
      apiTGrid1.AddColumn("NID_OUT", "NID_OUT", 0);
      apiTGrid1.AddColumn("VTYPE_OUT", "VTYPE_OUT", 0);
      apiTGrid1.AddColumn(Resources.col_Nom_doc, "VOUT_DOC_NOM", 8000);
      apiTGrid1.AddColumn(Resources.col_Creator, "VNOMCREATEUR", 2500);
      apiTGrid1.AddColumn(Resources.col_Date_saisi, "DDATMODIF", 1200);
      apiTGrid1.AddColumn("VFILENAME", "VFILENAME", 0);
      apiTGrid1.AddColumn("NQUICREE", "NQUICREE", 0);

      apiTGrid1.InitColumnList();
    }
  }
}