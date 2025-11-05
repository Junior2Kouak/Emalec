using MozartLib;
using MozartNet;
using MozartUC;
using System;
using System.Data;
using System.Linq;
using System.Reflection;
using System.Windows.Forms;
using MZUtils = MozartControls.Utils;

namespace MozartCS
{
  public partial class frmListeRappelDevisWebAttente : Form
  {
    DataTable dt = new DataTable();

    public frmListeRappelDevisWebAttente() { InitializeComponent(); }

    private void frmListeRappelDevisWebAttente_Load(object sender, System.EventArgs e)
    {
      try
      {
        Cursor.Current = Cursors.WaitCursor;
        ModuleMain.Initboutons(this);

        LoadData();

        InitApigrid();
      }
      catch (Exception ex)
      {
        MZUtils.displayError(MethodBase.GetCurrentMethod().Name, ex);
      }
      finally { Cursor.Current = Cursors.Default; }
    }


    private void LoadData()
    {
      try
      {
        Cursor.Current = Cursors.WaitCursor;

        apiTGrid.LoadData(dt, MozartDatabase.cnxMozart, $"EXEC [api_sp_Devis_Attente_Liste]");
        apiTGrid.GridControl.DataSource = dt;


        var dt_by_cli = dt.AsEnumerable()
                          .GroupBy(r => r.Field<string>("VCLINOM"))
                          .OrderByDescending(s => s.Count())
                          .Select(g => new
                          {
                            VCLINOM = g.Key,
                            TOT = g.Count()
                          }).ToList();

        apiTGrid1.GridControl.DataSource = dt_by_cli;

        var dt_by_chaff = dt.AsEnumerable()
                      .GroupBy(r => r.Field<string>("VCHAFFNOM"))
                      .OrderByDescending(s => s.Count())
                      .Select(g => new
                      {
                        VCHAFFNOM = g.Key,
                        TOT = g.Count()
                      }).ToList();

        apiTGridChaff.GridControl.DataSource = dt_by_chaff;

        var dt_by_rret = dt.AsEnumerable()
                      .GroupBy(r => r.Field<string>("VRRETNOM"))
                      .OrderByDescending(s => s.Count())
                      .Select(g => new
                      {
                        VRRETNOM = g.Key,
                        TOT = g.Count()
                      }).ToList();

        apiTGrid2.GridControl.DataSource = dt_by_rret;
      }
      catch (Exception ex)
      {
        MZUtils.displayError(MethodBase.GetCurrentMethod().Name, ex);
      }
      finally { Cursor.Current = Cursors.Default; }
    }

    private void cmdValider_Click(object sender, EventArgs e)
    {
      DataRow row = apiTGrid.GetFocusedDataRow();
      if (row == null) return;

      if (row["NACTNUM"] != null && (int)row["NACTNUM"] > 0)
      {
        MozartParams.NumDi = (int)row["NDINNUM"];
        MozartParams.NumAction = (int)row["NACTNUM"];
        new frmDetailstravaux { mstrStatutAction = "M" }.ShowDialog();
      }


    }

    private void InitApigrid()
    {
      apiTGrid.AddColumn("NSITNUM", "NSITNUM", 0);
      apiTGrid.AddColumn("NCLINUM", "NCLINUM", 0);
      apiTGrid.AddColumn("NDINNUM", "NDINNUM", 0);
      apiTGrid.AddColumn("VSITENSEIGNE", "VSITENSEIGNE", 0);
      apiTGrid.AddColumn("NDINCTE", "NDINCTE", 0);
      apiTGrid.AddColumn("NACTNUM", "NACTNUM", 0);
      apiTGrid.AddColumn("RRET", "VRRETNOM", 1400);
      apiTGrid.AddColumn("Date planif/date Relance", "DATECREE", 1400, "dd/MM/yyyy");
      apiTGrid.AddColumn("Contremaître", "VCONTNOM", 1400);
      apiTGrid.AddColumn("Technicien", "VTECHNOM", 1400);
      apiTGrid.AddColumn("Client", "VCLINOM", 1500);
      apiTGrid.AddColumn("Site", "VSITNOM", 1500);
      apiTGrid.AddColumn("Objet de l'action", "VACTDES", 1400);
      apiTGrid.AddColumn("Chaff", "VCHAFFNOM", 1400);

      apiTGrid.InitColumnList();
      apiTGrid.dgv.OptionsView.ColumnAutoWidth = false;

      apiTGrid1.AddColumn("Client", "VCLINOM", 1500);
      apiTGrid1.AddColumn("Nombre", "TOT", 1000);
      apiTGrid1.InitColumnList();
      apiTGrid1.dgv.OptionsView.ColumnAutoWidth = false;

      apiTGridChaff.AddColumn("Chaff", "VCHAFFNOM", 1500);
      apiTGridChaff.AddColumn("Nombre", "TOT", 1000);
      apiTGridChaff.InitColumnList();
      apiTGridChaff.dgv.OptionsView.ColumnAutoWidth = false;

      apiTGrid2.AddColumn("RRET", "VRRETNOM", 1500);
      apiTGrid2.AddColumn("Nombre", "TOT", 1000);
      apiTGrid2.InitColumnList();
      apiTGrid2.dgv.OptionsView.ColumnAutoWidth = false;
    }

    private void cmdQuitter_Click(object sender, System.EventArgs e)
    {
      Dispose();
    }

        private void BtnDetailDI_Click(object sender, EventArgs e)
        {
            Cursor = Cursors.WaitCursor;

            DataRow currentRow = apiTGrid.GetFocusedDataRow();
            if (currentRow == null) { Cursor = Cursors.Default; return; }

            //écran de modification de la demande
            MozartParams.NumDi = Convert.ToInt32(currentRow["NDINNUM"]);
            MozartParams.NumAction = Convert.ToInt32(currentRow["NACTNUM"]);

            new frmAddAction() { mstrStatutDI = "M" }.ShowDialog();

            Cursor = Cursors.Default;

            // on revient donc on réinitialise les variables globales
            MozartParams.NumDi = 0;
            MozartParams.NumAction = 0;

            //      if(mbRefresh)
            apiTGrid.Requery(dt, MozartDatabase.cnxMozart);

            //      mbRefresh = false;
            Cursor = Cursors.Default;
        }
    }
}

