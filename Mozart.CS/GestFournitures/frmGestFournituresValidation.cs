using DevExpress.XtraGrid.Views.Grid;
using MozartCS.Properties;
using MozartLib;
using MozartNet;
using MozartUC;
using System;
using System.Data;
using System.Drawing;
using System.Reflection;
using System.Windows.Forms;
using MZUtils = MozartControls.Utils;


namespace MozartCS
{
  public partial class frmGestFournituresValidation : Form
  {
    private DataTable dt0 = new DataTable();
    private DataTable dt1 = new DataTable();

    public frmGestFournituresValidation()
    {
      InitializeComponent();
    }

    private void frmGestFournituresValidation_Load(object sender, System.EventArgs e)
    {
      try
      {
        Cursor.Current = Cursors.WaitCursor;

        ModuleMain.Initboutons(this);

        InitApiTgrid(apiTGrid10);
        InitApiTgrid(apiTGrid11);

        apiTGrid10.LoadData(dt0, MozartDatabase.cnxMozart, $"exec api_sp_ListeDesFournitures {MozartParams.UID}");
        apiTGrid10.GridControl.DataSource = dt0;

        apiTGrid11.LoadData(dt1, MozartDatabase.cnxMozart, "exec api_sp_ListeDesFournitures");
        apiTGrid11.GridControl.DataSource = dt1;

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

    private void cmdSupprimer0_Click(object sender, EventArgs e)
    {
      cmdSupprimer_Click(0);
    }

    private void cmdDetails0_Click(object sender, EventArgs e)
    {
      cmdDetails_Click(0);
    }

    private void cmdSupprimer1_Click(object sender, EventArgs e)
    {
      cmdSupprimer_Click(1);
    }

    private void cmdDetails1_Click(object sender, EventArgs e)
    {
      cmdDetails_Click(1);
    }



    private void cmdDetails_Click(int index)
    {
      DataRow row = null;
      if (0 == index)
        row = apiTGrid10.GetFocusedDataRow();
      else
        row = apiTGrid11.GetFocusedDataRow();

      if (null == row) return;

      new frmDetailsFourniture()
      {
        mbStatutValidation = (0 == index) ? false : true,
        miNumFour = (int)Utils.ZeroIfNull(row["NFOUNUM"])
      }.ShowDialog();

      try
      {
        Cursor.Current = Cursors.WaitCursor;

        if (0 == index)
          apiTGrid10.Requery(dt0, MozartDatabase.cnxMozart);
        else
          apiTGrid11.Requery(dt1, MozartDatabase.cnxMozart);
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

    private void cmdSupprimer_Click(int index)
    {
      DataRow row = null;
      if (0 == index)
        row = apiTGrid10.GetFocusedDataRow();
      else
        row = apiTGrid11.GetFocusedDataRow();

      if (null == row) return;

      int nfounom = (int)Utils.ZeroIfNull(row["NFOUNUM"]);

      if (Utils.bSuppOK(nfounom) == 1)
      {
        if (MessageBox.Show(Resources.msg_desactiver_article, Program.AppTitle, MessageBoxButtons.YesNo,
                          MessageBoxIcon.Question, MessageBoxDefaultButton.Button2) == DialogResult.Yes)
        {
          try
          {
            Cursor.Current = Cursors.WaitCursor;
            ModuleData.ExecuteNonQuery($"exec api_sp_DeactiverArt {nfounom}");

            apiTGrid10.Requery(dt0, MozartDatabase.cnxMozart);
            apiTGrid11.Requery(dt1, MozartDatabase.cnxMozart);
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

    private void cmdFermer_Click(object sender, System.EventArgs e)
    {
      Dispose();
    }

    private void InitApiTgrid(apiTGrid grid)
    {
      grid.AddColumn(Resources.col_Date, "DFOUDCRE", 900, "dd/MM/yy", 2);
      grid.AddColumn(Resources.col_Serie, "VFOUSER", 700);
      grid.AddColumn(Resources.col_materiel, "VFOUMAT", 3700, "", 0, true);
      grid.AddColumn(Resources.col_marque, "VFOUMAR", 1000, "", 0, true);
      grid.AddColumn(Resources.col_Type, "VFOUTYP", 1100, "", 0, true);
      grid.AddColumn(Resources.col_Ref, "VFOUREF", 1000, "", 0, true);
      grid.AddColumn(Resources.col_Condit, "VFOUCON", 700, "", 0, true);
      grid.AddColumn(Resources.col_pcb, "NFOUNBLOT", 600);
      grid.AddColumn(Resources.col_Prix, "FPUHT", 800, "", 2);
      grid.AddColumn(Resources.col_unite, "FPUNITE", 700, "", 2);
      grid.AddColumn(Resources.col_Fournisseur, "VSTFGRPNOM", 1700, "", 0, true);
      grid.AddColumn("Réf four", "VSTFFOUREFCLI", 1400);
      //'  Grid.AddColumn "§Clients§", "VFOUCLI", 900
      grid.AddColumn(Resources.col_Num_Art, "NFOUNUM", 0);// non affichee en vb6
      grid.AddColumn(Resources.col_NumFourn, "NSTFGRPNUM", 0);// non affichee en vb6
      grid.AddColumn(Resources.col_valid, "BFOUVALID", 0);// non affichee en vb6
      grid.AddColumn(Resources.col_img, "VFOUIMAGE", 400);
      grid.AddColumn(Resources.col_fds, "VFOUFDSFILE", 400);
      grid.AddColumn(Resources.col_Code, "CODE", 0);// non affichee en vb6

      grid.InitColumnList();
    }

    private void apiTGrid_RowStyle(object sender, RowStyleEventArgs e)
    {
      GridView View = sender as GridView;
      if (e.RowHandle >= 0)
      {
        if (View.GetDataRow(e.RowHandle)["CODE"].ToString() == "R")
        {
          e.Appearance.ForeColor = Color.Black;
          e.Appearance.BackColor = MozartColors.colorHDBE6FD;
          e.HighPriority = true;
        }
        else if (View.GetDataRow(e.RowHandle)["CODE"].ToString() == "V")
        {
          e.Appearance.ForeColor = Color.Black;
          e.Appearance.BackColor = MozartColors.colorHEEFFE3;
          e.HighPriority = true;
        }
      }
    }
  }
}

