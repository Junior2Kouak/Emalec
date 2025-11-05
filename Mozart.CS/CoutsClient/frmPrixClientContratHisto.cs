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
  public partial class frmPrixClientContratHisto : Form
  {
    DataTable dt = new DataTable();
    public long miNumClient;
    //Dim adors As Recordset
    //Public NCLINUM As Long

    public frmPrixClientContratHisto()
    {
      InitializeComponent();
    }

    /* OK --------------------------------------------------------------------------------------- */
    private void frmPrixClientContratHisto_Load(object sender, System.EventArgs e)
    {
      try
      {
        ModuleMain.Initboutons(this);
        apiGrid.Visible = true;
        apiTGridTypCont.Visible = false;

        apiGrid.LoadData(dt, MozartDatabase.cnxMozart, $"EXEC [api_sp_PrixClientContratPays_Histo] {miNumClient}");
        apiGrid.GridControl.DataSource = dt;

        InitApigrid();
        Cursor.Current = Cursors.Default;
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

    private void frmPrixClientContratHisto_FormClosed(object sender, FormClosedEventArgs e)
    {
      Cursor.Current = Cursors.Default;
    }

    private void InitApigrid()
    {
      try
      {
        apiGrid.AddColumn("Date", "DATEMODIF", 900, "dd/MM/yyyy");
        apiGrid.AddColumn("Nom", "VNOM", 1200);
        apiGrid.AddColumn("Action", "VACTION", 800);
        apiGrid.AddColumn("Contrat", "VTYPECONTRAT", 2200);
        apiGrid.AddColumn("Pays", "VPAYS", 1000);
        apiGrid.AddColumn("Cout horaire ancien", "NCLICONTHOR_OLD", 1500, "", 2);
        apiGrid.AddColumn("Cout horaire nouveau", "NCLICONTHOR_NEW", 1500, "", 2);
        apiGrid.AddColumn("Cout déplacement ancien", "NCLICONTDEP_OLD", 1500, "", 2);
        apiGrid.AddColumn("Cout déplacement nouveau", "NCLICONTDEP_NEW", 1500, "", 2);
        apiGrid.AddColumn("Coeff Samedi ancien", "NCLICONTHORSAM_OLD", 1500, "", 2);
        apiGrid.AddColumn("Coeff Samedi nouveau", "NCLICONTHORSAM_NEW", 1500, "", 2);
        apiGrid.AddColumn("Coeff Nuit & Dimanche ancien", "NCLICONTHORNUIDIM_OLD", 1500, "", 2);
        apiGrid.AddColumn("Coeff Nuit & Dimanche nouveau", "NCLICONTHORNUIDIM_NEW", 1500, "", 2);
        apiGrid.AddColumn("Cout astreinte ancien", "NMTTFORFAITASTR_OLD", 1500, "", 2);
        apiGrid.AddColumn("Cout astreinte nouveau", "NMTTFORFAITASTR_NEW", 1500, "", 2);
        apiGrid.AddColumn("Texte astreinte ancien", "VACTTEXTASTR_OLD", 1500, "", 2);
        apiGrid.AddColumn("Texte astreinte nouveau", "VACTTEXTASTR_NEW", 1500, "", 2);
        apiGrid.AddColumn("NCLINUM", "NCLINUM", 0);

        apiGrid.InitColumnList();
      }
      catch (Exception ex)
      {
        MZUtils.displayError(MethodBase.GetCurrentMethod().Name, ex);
      }
    }

    private void apiGrid_RowCellStyle(object sender, DevExpress.XtraGrid.Views.Grid.RowCellStyleEventArgs e)
    {
      if (e.RowHandle < 0) return;
      DataRow dr = (sender as GridView).GetDataRow(e.RowHandle);
      switch (e.Column.Name)
      {
        case "NCLICONTHOR_OLD":
        case "NCLICONTHOR_NEW":
          if (dr == null) return;

          if ((decimal?)Utils.ZeroIfBlank(Utils.BlankIfNull(dr["NCLICONTHOR_OLD"])) != (decimal?)Utils.ZeroIfBlank(Utils.BlankIfNull(dr["NCLICONTHOR_NEW"])))
          {
            e.Appearance.BackColor = Color.Yellow;
          }
          break;
        case "NCLICONTDEP_OLD":
        case "NCLICONTDEP_NEW":
          if (dr == null) return;
          if ((decimal?)Utils.ZeroIfBlank(Utils.BlankIfNull(dr["NCLICONTDEP_OLD"])) != (decimal?)Utils.ZeroIfBlank(Utils.BlankIfNull(dr["NCLICONTDEP_NEW"])))
          {
            e.Appearance.BackColor = Color.Yellow;
          }
          break;
        case "NCLICONTHORSAM_OLD":
        case "NCLICONTHORSAM_NEW":
          if (dr == null) return;
          if ((decimal?)Utils.ZeroIfBlank(Utils.BlankIfNull(dr["NCLICONTHORSAM_OLD"])) != (decimal?)Utils.ZeroIfBlank(Utils.BlankIfNull(dr["NCLICONTHORSAM_NEW"])))
          {
            e.Appearance.BackColor = Color.Yellow;
          }
          break;
        case "NCLICONTHORNUIDIM_OLD":
        case "NCLICONTHORNUIDIM_NEW":
          if (dr == null) return;
          if ((decimal?)Utils.ZeroIfBlank(Utils.BlankIfNull(dr["NCLICONTHORNUIDIM_OLD"])) != (decimal?)Utils.ZeroIfBlank(Utils.BlankIfNull(dr["NCLICONTHORNUIDIM_NEW"])))
          {
            e.Appearance.BackColor = Color.Yellow;
          }
          break;
        case "NMTTFORFAITASTR_OLD":
        case "NMTTFORFAITASTR_NEW":
          if (dr == null) return;
          if ((decimal?)Utils.ZeroIfBlank(Utils.BlankIfNull(dr["NMTTFORFAITASTR_OLD"])) != (decimal?)Utils.ZeroIfBlank(Utils.BlankIfNull(dr["NMTTFORFAITASTR_NEW"])))
          {
            e.Appearance.BackColor = Color.Yellow;
          }
          break;
        case "VACTTEXTASTR_OLD":
        case "VACTTEXTASTR_NEW":
          if (dr == null) return;
          if ((string)Utils.BlankIfNull(dr["VACTTEXTASTR_OLD"]) != (string)Utils.BlankIfNull(dr["VACTTEXTASTR_NEW"]))
          {
            e.Appearance.BackColor = Color.Yellow;
          }
          break;

      }
    }
  }
}