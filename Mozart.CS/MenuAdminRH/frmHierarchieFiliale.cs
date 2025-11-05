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
  public partial class frmHierarchieFiliale : Form
  {
    private DataTable dt = new DataTable();

    public frmHierarchieFiliale() { InitializeComponent(); }

    private void frmSaisieInfoPaie_Load(object sender, System.EventArgs e)
    {
      try
      {
        Cursor.Current = Cursors.WaitCursor;
        ModuleMain.Initboutons(this);
        LoadData();
        InitApiTgrid();
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

    private void LoadData()
    {

      apiTGrid.LoadData(dt, MozartDatabase.cnxMozart, "exec api_sp_HierarchieDuPersonnel");
      apiTGrid.GridControl.DataSource = dt;

    }


    private void InitApiTgrid()
    {
      apiTGrid.AddColumn("Directeur", "VPERNOMDIR", 1800);
      apiTGrid.AddColumn(Resources.col_Service, "LIBSERVICE", 1800);
      apiTGrid.AddColumn("Resp service", "VPERNOMSER", 1800);
      apiTGrid.AddColumn(Resources.col_groupe, "LIBGROUPE", 1800);
      apiTGrid.AddColumn("Resp groupe", "VPERNOMGRP", 1800);
      apiTGrid.AddColumn(Resources.col_utilisateur, "VPERNOM", 1800);
      apiTGrid.AddColumn(Resources.col_Fonction, "VPERLIBEMPLOI", 1500);
      apiTGrid.AddColumn(Resources.col_ID, "NPERNUM", 1000, "", 2);

    }

    private void cmdQuitter_Click(object sender, System.EventArgs e)
    {
      Dispose();
    }

  }
}