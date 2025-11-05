using MozartCS.Properties;
using MozartLib;
using MozartNet;
using MozartUC;
using System;
using System.Data;
using System.Reflection;
using System.Windows.Forms;
using MZUtils = MozartControls.Utils;


namespace MozartCS
{
  public partial class frmListeData : Form
  {

    public string mstrSite;
    public int miNumSite;

    DataTable dt = new DataTable();

    public frmListeData() { InitializeComponent(); }

    private void frmListeData_Load(object sender, System.EventArgs e)
    {
      try
      {
        Cursor.Current = Cursors.WaitCursor;
        ModuleMain.Initboutons(this);

        Label1.Text = "Liste des compteurs";
        Label2.Text = "";  // mstrSite;

        //ouverture du recordset
        apiTGrid.LoadData(dt, MozartDatabase.cnxMozart, $"Select NCOMPTID, VINFOLIB, VCOMPTNUM, VCOMPTNOM, VCOMPTLIEU " +
                          $"from TREF_INFOTECH R,  TCOMPTEURSITE S where R.NINFONUM=S.NINFONUM AND NSITNUM= {miNumSite} " +
                          $"AND LANGUE  = '{MozartParams.Langue}' order by VINFOLIB");
        apiTGrid.GridControl.DataSource = dt;

        InitApigrid();
      }
      catch (Exception ex)
      {
        MZUtils.displayError(MethodBase.GetCurrentMethod().Name, ex);
      }
      finally { Cursor.Current = Cursors.Default; }
    }

    private void cmdModifier_Click(object sender, EventArgs e)
    {
      DataRow row = apiTGrid.GetFocusedDataRow();
      if (row == null)
      {
        MessageBox.Show("Il faut créer les compteurs pour ce site avant de pouvoir les saisir", Program.AppTitle, MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
        return;
      }

      new frmDetailsDataTechnique()
      {
        miNumCompteur = (int)row["NCOMPTID"],
        mstrLibCompteur = $"{Utils.BlankIfNull(row["VCOMPTNOM"])} - {Utils.BlankIfNull(row["VCOMPTNUM"])}",
        miNumSite = miNumSite,
      }.ShowDialog();
    }

    private void cmdMod_Click(object sender, EventArgs e)
    {
      DataRow row = apiTGrid.GetFocusedDataRow();
      if (row == null) return;

      new frmListeReleveCompteur()
      {
        iNumCompteur = (int)row["NCOMPTID"]
      }.ShowDialog();
    }

    private void cmdAjouter_Click(object sender, EventArgs e)
    {
      new frmListeCompteursSite(miNumSite).ShowDialog();
    }

    private void InitApigrid()
    {
      apiTGrid.AddColumn("Num", "NCOMPTID", 700);
      apiTGrid.AddColumn("Nom", "VCOMPTNOM", 1500);
      apiTGrid.AddColumn(Resources.col_Type, "VINFOLIB", 2500, "", 0, true);
      apiTGrid.AddColumn(Resources.col_reference, "VCOMPTNUM", 1500, "", 0, true);
      apiTGrid.AddColumn(Resources.col_Localisation, "VCOMPTLIEU", 2000, "", 0, true);

      apiTGrid.InitColumnList();
    }

    private void cmdQuitter_Click(object sender, System.EventArgs e)
    {
      Dispose();
    }

  }
}

