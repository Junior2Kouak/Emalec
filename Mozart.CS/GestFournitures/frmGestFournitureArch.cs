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
  public partial class frmGestFournitureArch : Form
  {
    private DataTable dt = new DataTable();

    public frmGestFournitureArch()
    {
      InitializeComponent();
    }

    private void frmGestFournitureArch_Load(object sender, System.EventArgs e)
    {
      try
      {
        Cursor.Current = Cursors.WaitCursor;

        ModuleMain.Initboutons(this);

        InitApigrid();

        apiGrid.LoadData(dt, MozartDatabase.cnxMozart, "select * from api_v_ListeFournitures WHERE CFOUACTIF = 'N' Order by  VFOUMAT, FPUHT");
        apiGrid.GridControl.DataSource = dt;
      }
      catch (Exception ex)
      {
        MZUtils.displayError(MethodBase.GetCurrentMethod().Name, ex);
      }
      finally
      {
        Cursor.Current = Cursors.Default;
      }
    }

    private void cmdFermer_Click(object sender, System.EventArgs e)
    {
      Dispose();
    }


    private void Command1_Click(object sender, EventArgs e)
    {
      DataRow row = apiGrid.GetFocusedDataRow();
      if (null == row)
        return;

      new frmDetailsFourniture()
      {
        mstrStatut = "M",
        miNumFour = (int)Utils.ZeroIfNull(row["NFOUNUM"])
      }.ShowDialog();

      apiGrid.Requery(dt, MozartDatabase.cnxMozart);
    }

    private void InitApigrid()
    {
      apiGrid.AddColumn(Resources.col_Serie, "VFOUSER", 700);
      apiGrid.AddColumn(Resources.col_materiel, "VFOUMAT", 3100);
      apiGrid.AddColumn(Resources.col_marque, "VFOUMAR", 1000);
      apiGrid.AddColumn(Resources.col_Type, "VFOUTYP", 1500);
      apiGrid.AddColumn(Resources.col_reference, "VFOUREF", 1000);
      apiGrid.AddColumn(Resources.col_Condit, "VFOUCON", 600);
      apiGrid.AddColumn(Resources.col_pcb, "NFOUNBLOT", 500);
      apiGrid.AddColumn(Resources.col_prixU, "FPUHT", 700, "", 2);
      apiGrid.AddColumn(Resources.col_Fournisseur, "VSTFGRPNOM", 1800);
      apiGrid.AddColumn(Resources.col_dateprix, "DFOUDPR", 800, "dd/MM/yy", 2);
      apiGrid.AddColumn(Resources.col_clients, "VFOUCLI", 900);
      apiGrid.AddColumn(Resources.col_Num_Art, "VSTFFOUREFCLI", 0);
      apiGrid.AddColumn(Resources.col_uniteprix, "FPUNITE", 0);
      apiGrid.AddColumn(Resources.col_Actif, "CFOUACTIF", 0);
      apiGrid.AddColumn(Resources.col_img, "VFOUIMAGE", 400);
      apiGrid.AddColumn(Resources.col_ID, "NFOUNUM", 700);

      apiGrid.InitColumnList();
    }

    private void cmdArchiver_Click(object sender, EventArgs e)
    {
      try
      {
        DataRow row = apiGrid.GetFocusedDataRow();
        if (null == row)
          return;

        if (MessageBox.Show(Resources.msg_question_reactiver_article, Program.AppTitle, MessageBoxButtons.YesNo,
                      MessageBoxIcon.Question, MessageBoxDefaultButton.Button2) == DialogResult.Yes)
        {
          Cursor.Current = Cursors.WaitCursor;

          ModuleData.ExecuteNonQuery($"exec api_sp_ReactiverArt {(int)Utils.ZeroIfNull(row["NFOUNUM"])}");

          apiGrid.Requery(dt, MozartDatabase.cnxMozart);
        }
      }
      catch (Exception ex)
      {
        MZUtils.displayError(MethodBase.GetCurrentMethod().Name, ex);
      }
      finally
      {
        Cursor.Current = Cursors.Default;
      }
    }
  }
}

