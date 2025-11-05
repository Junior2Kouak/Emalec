using MZCtrlResources = MozartControls.Properties.Resources;
using Microsoft.VisualBasic;
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
  public partial class frmRelanceST : Form
  {
    DataTable dtDevis = new DataTable();
    DataTable dtTravaux = new DataTable();
    DataTable dtOrdres = new DataTable();

    public frmRelanceST() { InitializeComponent(); }

    private void frmRelanceST_Load(object sender, System.EventArgs e)
    {
      try
      {
        Cursor.Current = Cursors.WaitCursor;
        ModuleMain.Initboutons(this);
      }
      catch (Exception ex)
      {
        MZUtils.displayError(MethodBase.GetCurrentMethod().Name, ex);
      }
      finally { Cursor.Current = Cursors.Default; }
    }

    private void cmdDevis_Click(object sender, EventArgs e)
    {
      //ouverture du recordset
      Cursor.Current = Cursors.WaitCursor;

      GridDevis.LoadData(dtDevis, MozartDatabase.cnxMozart, "exec api_sp_RelanceDemandeST");
      GridDevis.GridControl.DataSource = dtDevis;

      InitApiGrid();
      cmdDevis.Enabled = false;

      Cursor.Current = Cursors.Default;
    }

    private void cmdOM_Click(object sender, EventArgs e)
    {
      Cursor.Current = Cursors.WaitCursor;

      GridOrdres.LoadData(dtOrdres, MozartDatabase.cnxMozart, "exec api_sp_RelanceOM");
      GridOrdres.GridControl.DataSource = dtOrdres;

      InitApiGrid2();
      cmdOM.Enabled = false;

      Cursor.Current = Cursors.Default;
    }

    private void cmdTrav_Click(object sender, EventArgs e)
    {
      //ouverture du recordset
      Cursor.Current = Cursors.WaitCursor;

      GridTravaux.LoadData(dtTravaux, MozartDatabase.cnxMozart, "exec api_sp_RelanceContratST");
      GridTravaux.GridControl.DataSource = dtTravaux;

      InitApiGrid1();
      cmdTrav.Enabled = false;

      Cursor.Current = Cursors.Default;
    }

    private void cmdImprimer_Click(object sender, EventArgs e)
    {
      Cursor.Current = Cursors.WaitCursor;

      //impression du datagrid
      GridDevis.btnPrint_Click(null, null);

      Cursor.Current = Cursors.Default;
    }

    private void Command1_Click(object sender, EventArgs e)
    {
      Cursor.Current = Cursors.WaitCursor;

      //impression du datagrid
      GridTravaux.btnPrint_Click(null, null);

      Cursor.Current = Cursors.Default;
    }

    private void cmdQuitter_Click(object sender, EventArgs e)
    {
      //fermeture de la fenetre
      Dispose();
    }

    private void InitApiGrid()
    {
      GridDevis.AddColumn(Resources.col_Devis, "NDSTNUM", 700);
      GridDevis.AddColumn(Resources.col_Date, "DDSTDAT", 700, "dd/MM/yy");
      GridDevis.AddColumn(Resources.col_DI, "NDINNUM", 700);
      GridDevis.AddColumn(Resources.col_ST, "VSTFNOM", 1000);
      GridDevis.AddColumn(Resources.col_Contact, "VINTNOM", 1000);
      GridDevis.AddColumn(Resources.col_Creator, "VPERNOM", 1500);
      GridDevis.AddColumn("Chaff", "VDINCHAFF", 1500);
      GridDevis.AddColumn("Chef GRP", "CHEF", 1500);
      GridDevis.AddColumn(MZCtrlResources.col_Client, "VCLINOM", 1500);
      GridDevis.AddColumn(Resources.col_Site, "VSITNOM", 1500);
      GridDevis.AddColumn(Resources.col_Action, "VACTDES", 4800);
      GridDevis.AddColumn(Resources.col_Urg, "CURGCOD", 290);
      GridDevis.AddColumn(Resources.col_etat, "CETACOD", 300);
      GridDevis.AddColumn(Resources.col_Date_R, "DDSTDRE", 820, "dd/MM/yy");
      GridDevis.AddColumn(Resources.col_Observations, "VACTOBS", 0);
      GridDevis.AddColumn(Resources.col_NumAction, "NACTNUM", 0);

      GridDevis.InitColumnList();
    }

    private void apiTGrid_DblClickE(object sender, EventArgs e)
    {
      //si le recordset est vide
      DataRow row = GridDevis.GetFocusedDataRow();
      if (row == null) return;

      MozartParams.NumAction = (int)Utils.ZeroIfNull(row["NACTNUM"]);
      MozartParams.NumDi = Convert.ToInt32(Strings.Mid(Utils.BlankIfNull(row["NDINNUM"]), 3));

      //écran de modification de l'action
      Cursor.Current = Cursors.WaitCursor;
      new frmDetailstravaux()
      {
        mstrStatutAction = "M",
      }.ShowDialog();

      //rafraichissement du recordset
      Cursor.Current = Cursors.WaitCursor;
      GridDevis.Requery(dtDevis, MozartDatabase.cnxMozart);
      Cursor.Current = Cursors.Default;
    }

    private void apiTGrid1_DblClickE(object sender, EventArgs e)
    {
      //si le recordset est vide
      DataRow row = GridTravaux.GetFocusedDataRow();
      if (row == null) return;

      MozartParams.NumAction = (int)Utils.ZeroIfNull(row["NACTNUM"]);
      MozartParams.NumDi = Convert.ToInt32(Strings.Mid(Utils.BlankIfNull(row["NDINNUM"]), 3));

      //écran de modification de l'action
      Cursor.Current = Cursors.WaitCursor;
      new frmDetailstravaux()
      {
        mstrStatutAction = "M",
      }.ShowDialog();

      //rafraichissement du recordset
      Cursor.Current = Cursors.WaitCursor;
      GridTravaux.Requery(dtTravaux, MozartDatabase.cnxMozart);
      Cursor.Current = Cursors.Default;
    }

    private void apiTGrid2_DblClickE(object sender, EventArgs e)
    {
      //si le recordset est vide
      DataRow row = GridOrdres.GetFocusedDataRow();
      if (row == null) return;


      MozartParams.NumAction = (int)Utils.ZeroIfNull(row["NACTNUM"]);
      MozartParams.NumDi = Convert.ToInt32(Strings.Mid(Utils.BlankIfNull(row["NDINNUM"]), 3));

      //écran de modification de l'action
      Cursor.Current = Cursors.WaitCursor;
      new frmDetailstravaux()
      {
        mstrStatutAction = "M",
      }.ShowDialog();

      //rafraichissement du recordset
      Cursor.Current = Cursors.WaitCursor;
      GridOrdres.Requery(dtOrdres, MozartDatabase.cnxMozart);
      Cursor.Current = Cursors.Default;
    }

    private void InitApiGrid1()
    {
      GridTravaux.AddColumn(Resources.col_Contrat, "NCSTNUM", 700);
      GridTravaux.AddColumn(Resources.col_Date, "DCSTDAT", 780, "dd/MM/yy");
      GridTravaux.AddColumn(Resources.col_DI, "NDINNUM", 700);
      GridTravaux.AddColumn(Resources.col_ST, "VSTFNOM", 1000);
      GridTravaux.AddColumn(Resources.col_Contact, "VINTNOM", 1000);
      GridTravaux.AddColumn(Resources.col_Creator, "VPERNOM", 1500);
      GridTravaux.AddColumn("Chaff", "VDINCHAFF", 1500);
      GridTravaux.AddColumn("Chef GRP", "CHEF", 1500);
      GridTravaux.AddColumn(MZCtrlResources.col_Client, "VCLINOM", 1500);
      GridTravaux.AddColumn(Resources.col_Site, "VSITNOM", 1500);
      GridTravaux.AddColumn(Resources.col_Action, "VACTDES", 4800);
      GridTravaux.AddColumn(Resources.col_Urg, "CURGCOD", 290);
      GridTravaux.AddColumn(Resources.col_etat, "CETACOD", 300);
      GridTravaux.AddColumn(Resources.col_dateEx, "DCSTDEL", 820, "dd/MM/yy");
      GridTravaux.AddColumn(Resources.col_Observations, "VACTOBS", 0);
      GridTravaux.AddColumn(Resources.col_NumAction, "NACTNUM", 0);

      GridTravaux.InitColumnList();
    }

    private void InitApiGrid2()
    {
      GridOrdres.AddColumn(Resources.col_Contrat, "NOMNUM", 700);
      GridOrdres.AddColumn(Resources.col_Date, "DDATECRE", 780, "dd/MM/yy");
      GridOrdres.AddColumn(Resources.col_DI, "NDINNUM", 700);
      GridOrdres.AddColumn(Resources.col_ST, "VSTFNOM", 1000);
      GridOrdres.AddColumn(Resources.col_Contact, "VINTNOM", 1000);
      GridOrdres.AddColumn(Resources.col_Creator, "VQUICRE", 1500);
      GridOrdres.AddColumn("Chaff", "VDINCHAFF", 1500);
      GridOrdres.AddColumn("Chef GRP", "CHEF", 1500);
      GridOrdres.AddColumn(MZCtrlResources.col_Client, "VCLINOM", 1500);
      GridOrdres.AddColumn(Resources.col_Site, "VSITNOM", 1500);
      GridOrdres.AddColumn(Resources.col_Action, "VACTDES", 4800);
      GridOrdres.AddColumn(Resources.col_Urg, "CURGCOD", 290);
      GridOrdres.AddColumn(Resources.col_etat, "CETACOD", 300);
      GridOrdres.AddColumn(Resources.col_dateEx, "DOMDEX", 820, "dd/MM/yy");
      GridOrdres.AddColumn(Resources.col_Observations, "VACTOBS", 0);
      GridOrdres.AddColumn(Resources.col_NumAction, "NACTNUM", 0);

      GridOrdres.InitColumnList();
    }

  }
}

