using DevExpress.XtraGrid.Views.Grid;
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
  public partial class frmListeDiRelance : Form
  {
    //adors As ADODB.Recordset;
    DataTable dt = new DataTable();

    public frmListeDiRelance() { InitializeComponent(); }
    /* OK--------------------------------------------------------------*/
    private void frmListeDiRelance_Load(object sender, System.EventArgs e)
    {
      try
      {
        Cursor.Current = Cursors.WaitCursor;
        ModuleMain.Initboutons(this);

        // ouverture du recordset
        apigrid.LoadData(dt, MozartDatabase.cnxMozart, "exec api_sp_ListeRelanceTraitement 0");
        apigrid.GridControl.DataSource = dt;
        InitApigrid();

        //fenetre du nombre de relance
        DataRow row = apigrid.GetFocusedDataRow();
        if (null != row)
        {
          int nb = (int)Utils.ZeroIfNull(row["NB"]);
          if (nb > 0)
          {
            lblNbRelance.Text = nb.ToString();
            Frame1.Visible = true;
          }
        }
      }
      catch (Exception ex)
      {
        MZUtils.displayError(MethodBase.GetCurrentMethod().Name, ex);
      }
      finally { Cursor.Current = Cursors.Default; }
    }


    /* OK--------------------------------------------------------------------------------------- */
    private void frmListeDiRelance_Activated(object sender, EventArgs e)
    {
      //dimmension de la fenetre selon la resolution (vb6 10000 => /15 en cs)
      if (this.Height < 667)
        this.WindowState = FormWindowState.Maximized;
    }

    /* OK--------------------------------------------------------------------------------------- */
    private void ChkTous_Click(object sender, EventArgs e)
    {
      apigrid.LoadData(dt, MozartDatabase.cnxMozart, $"exec api_sp_ListeRelanceTraitement {(ChkTous.Checked ? "1" : "0")}");
    }

    /* OK--------------------------------------------------------------------------------------- */
    private void InitApigrid()
    {
      apigrid.AddColumn("Relanceur", "VQUIRELANCE", 1500);
      apigrid.AddColumn("Relancé", "VQUIESTRELANCE", 1500);
      apigrid.AddColumn("Relance", "DACTDRELANCE", 1000, "dd/MM/yy");
      apigrid.AddColumn("DI", "NDINNUM", 700);
      apigrid.AddColumn("Date C", "DDINDATHEUR", 850, "dd/MM/yy");
      apigrid.AddColumn("Diff en jours", "DIFF", 1400, "", 2);
      apigrid.AddColumn("Client", "VCLINOM", 1300, "", 0, true);
      apigrid.AddColumn("Site", "VSITNOM", 1400, "", 0, true);
      apigrid.AddColumn("N°", "NSITNUE", 480);
      apigrid.AddColumn("Enseigne", "VSITENSEIGNE", 600, "", 0, true);
      apigrid.AddColumn("Chaff", "VDINCHAFF", 1000, "", 0, true);
      apigrid.AddColumn("Action", "VACTDES", 4500, "", 0, true);
      apigrid.AddColumn("Date ", "DACTDATE", 850, "dd/MM/yy");
      apigrid.AddColumn("Technicien", "VACTINT", 800, "", 0, true);
      apigrid.AddColumn("T echnique", "CTECCOD", 400, "", 2);
      apigrid.AddColumn("P restation", "CPRECOD", 400, "", 2, true);
      apigrid.AddColumn("E tat", "CETACOD", 400, "", 2, true);
      apigrid.AddColumn("A dministration", "CACTSTA", 400, "", 2);
      apigrid.AddColumn("Obs M", "VACTOBSM", 2100, "", 0, true);
      apigrid.AddColumn("Obs", "VACTOBS", 2100, "", 0, true);

      apigrid.InitColumnList();
    }
    private void Apigrid_Rowstyle(object sender, RowStyleEventArgs e)
    {
      if (e.RowHandle >= 0)
      {
        GridView View = sender as GridView;
        if (View.GetDataRow(e.RowHandle)["NRELANCEURGENTE"].ToString() == "1")
        {
          e.Appearance.Font = new Font(e.Appearance.Font, FontStyle.Bold);
          e.HighPriority = true;
        }
      }
    }

    /* OK--------------------------------------------------------------------------------------- */
    private void cmdModifier_Click(object sender, EventArgs e)
    {
      DataRow currRow = apigrid.GetFocusedDataRow();
      if (currRow == null) return;

      //écran de modification de la demande
      MozartParams.NumDi = (int)Utils.ZeroIfNull(currRow["NDINNUM"]);
      MozartParams.NumAction = (int)Utils.ZeroIfNull(currRow["NACTNUM"]);

      Cursor.Current = Cursors.WaitCursor;
      new frmAddAction()
      {
        mstrStatutDI = "M",
      }.ShowDialog();

      //on revient donc on réinitialise les variables globales
      MozartParams.NumDi = 0;
      MozartParams.NumAction = 0;

      Cursor.Current = Cursors.WaitCursor;
      apigrid.Requery(dt, MozartDatabase.cnxMozart);
      Cursor.Current = Cursors.Default;
    }

    /* OK--------------------------------------------------------------------------------------- */
    private void cmdQuitter_Click(object sender, System.EventArgs e)
    {
      // fermeture de la fenêtre
      Dispose();
    }

    /* OK--------------------------------------------------------------------------------------- */
    private void apigrid_DoubleClick(object sender, EventArgs e)
    {
      cmdModifier_Click(sender, e);
    }
    /* OK--------------------------------------------------------------------------------------- */
    private void Frame1_DoubleClick(object sender, EventArgs e)
    {
      Frame1.Visible = false;
    }
    /* OK--------------------------------------------------------------------------------------- */
    private void Frame1_MouseDown(object sender, EventArgs e)
    {
      Frame1.Visible = false;
    }
  }
}

