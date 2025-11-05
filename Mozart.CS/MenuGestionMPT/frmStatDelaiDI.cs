using MozartCS.Properties;
using MozartLib;
using MozartNet;
using MozartUC;
using System;
using System.Collections.Generic;
using System.Data;
using System.Reflection;
using System.Windows.Forms;
using MZUtils = MozartControls.Utils;

namespace MozartCS
{
  public partial class frmStatDelaiDI : Form
  {
    DataTable dt = new DataTable();

    public frmStatDelaiDI()
    {
      InitializeComponent();
    }


    private void frmStatDelaiDI_Load(object sender, System.EventArgs e)
    {
      Cursor = Cursors.WaitCursor;

      try
      {
        ModuleMain.Initboutons(this);

        string sSQL = $"SELECT  tcli.nclinum, vclinom FROM dbo.TDIN INNER JOIN dbo.TACT ON dbo.TDIN.NDINNUM = dbo.TACT.NDINNUM INNER JOIN " +
                      $"dbo.TCLI ON dbo.TDIN.NCLINUM = dbo.TCLI.NCLINUM WHERE   dbo.TACT.CETACOD in ('A','B','O','W','D','P') " +
                      $"AND VSOCIETE = App_Name() AND CCLIACTIF = 'O' group by tcli.nclinum, vclinom Having count(nActnum) > 25 " +
                      $"UNION SELECT 0 AS NCLINUM,'  ' AS VCLINOM  ORDER BY VCLINOM";

        cboCli.Init(MozartDatabase.cnxMozart, sSQL, "nclinum", "vclinom", new List<string>() { Resources.col_Num, Resources.col_Nom }, 150, 550, true);

        listBox1.Items.Add("Les écarts sont pris entre la date de création de l'action et le délai choisi (urgence lent, moyen, rapide).");
        listBox1.Items.Add("On ne prend pas les préventives ni les demandes en attente.");
        listBox1.Items.Add("On ne prend que les clients qui ont plus de 25 actions en cours (non exécutées)");
        listBox1.Items.Add("Les données sont calculées à 21H15 et à 12h15.");
        listBox1.Items.Add("On distingue les actions de dépannages (D) et les autres (A).");
        listBox1.Items.Add("Dépannages : urgence 1 --> 2H   urgence 2 --> 2J   urgence 3 --> 8J");
        listBox1.Items.Add("Autres prestations  : urgence 1 --> 8J   urgence 2 --> 15J   urgence 3 --> 30Jr");
        listBox1.Items.Add("Certains clients ont des codages particuliers");

        InitTGrid();

        Cursor = Cursors.Default;
      }
      catch (Exception ex)
      {
        Cursor = Cursors.Default;
        MZUtils.displayError(MethodBase.GetCurrentMethod().Name, ex);
      }
    }

    private void cmdQuitter_Click(object sender, System.EventArgs e)
    {
      Dispose();
    }

    private void cmdModifier_Click(object sender, EventArgs e)
    {
      DataRow currentRow = apiTGrid.GetFocusedDataRow();
      if (currentRow == null) return;

      Cursor = Cursors.WaitCursor;

      //écran de modification de la demande
      frmAddAction f = new frmAddAction();
      f.mstrStatutDI = "M";
      MozartParams.NumDi = Convert.ToInt32(currentRow["NDINNUM"]);
      MozartParams.NumAction = Convert.ToInt32(currentRow["NACTNUM"]);
      f.ShowDialog();

      Cursor = Cursors.WaitCursor;

      //on revient donc on réinitialise les variables globales
      MozartParams.NumDi = 0;
      MozartParams.NumAction = 0;

      Cursor = Cursors.Default;
    }

    private void cmdValider_Click(object sender, EventArgs e)
    {
      InitFeuille();
    }

    private void cmdCalc_Click(object sender, EventArgs e)
    {
      try
      {
        DataRow currentRow = apiTGrid.GetFocusedDataRow();
        if (currentRow == null) return;

        Cursor = Cursors.WaitCursor;

        apiTGrid.LoadData(dt, MozartDatabase.cnxMozart, "exec api_sp_RecalculStatClientDelaiDI " + Convert.ToInt64(currentRow["NACTNUM"]) + "," + cboCli.GetItemData());
        apiTGrid.GridControl.DataSource = dt;

        Cursor = Cursors.Default;
      }
      catch (Exception ex)
      {
        Cursor = Cursors.Default;
        MZUtils.displayError(MethodBase.GetCurrentMethod().Name, ex);
      }
    }

    private void InitFeuille()
    {
      try
      {
        Cursor = Cursors.WaitCursor;

        apiTGrid.LoadData(dt, MozartDatabase.cnxMozart, "select * from statistique.dbo.TSTATDELAIDI where nclinum = " + cboCli.GetItemData() + " order by datedem desc");
        apiTGrid.GridControl.DataSource = dt;

        Cursor = Cursors.Default;
      }
      catch (Exception ex)
      {
        Cursor = Cursors.Default;
        MZUtils.displayError(MethodBase.GetCurrentMethod().Name, ex);
      }
    }

    private void InitTGrid()
    {

      apiTGrid.AddColumn("N°DI", "diact", 1200, "", 2);
      apiTGrid.AddColumn("Date", "datedem", 1600, "dd/mm/yyyy HH:mm", 2);
      apiTGrid.AddColumn("Site", "site", 2500);
      apiTGrid.AddColumn("Action", "libelle", 2000, "", 0, true);
      apiTGrid.AddColumn("Urgence", "urgence", 1100, "", 2);
      apiTGrid.AddColumn("Presta", "presta", 800, "", 2);
      apiTGrid.AddColumn("Etat", "etat", 800, "", 2);
      apiTGrid.AddColumn("2H", "H2", 600, "", 2);
      apiTGrid.AddColumn("4H", "H4", 600, "", 2);
      apiTGrid.AddColumn("8H", "H8", 600, "", 2);
      apiTGrid.AddColumn("2J", "J2", 600, "", 2);
      apiTGrid.AddColumn("8J", "J8", 600, "", 2);
      apiTGrid.AddColumn("15J", "J15", 600, "", 2);
      apiTGrid.AddColumn("30J", "J30", 600, "", 2);
      apiTGrid.AddColumn("60J", "J60", 600, "", 2);
      apiTGrid.AddColumn("90J", "J90", 600, "", 2);
      apiTGrid.AddColumn("120J", "J120", 600, "", 2);
      apiTGrid.AddColumn("240J", "J240", 600, "", 2);
      apiTGrid.AddColumn("+240J", "S240", 600, "", 2, true);
      apiTGrid.AddColumn("nactnum", "nactnum", 0);
      apiTGrid.AddColumn("ndinnum", "ndinnum", 0);

      apiTGrid.InitColumnList();
    }

    private void apiTGrid_RowCellStyle(object sender, DevExpress.XtraGrid.Views.Grid.RowCellStyleEventArgs e)
    {
      //gestion spécifique dans couleurs
      if (e.Column.Name == "H2" || e.Column.Name == "H4" || e.Column.Name == "H8" || e.Column.Name == "J2" || e.Column.Name == "J8"
       || e.Column.Name == "J15" || e.Column.Name == "J30" || e.Column.Name == "J60" || e.Column.Name == "J90"
       || e.Column.Name == "J120" || e.Column.Name == "J240" || e.Column.Name == "S240")
      {
        switch (e.CellValue)
        {
          case "O":
            e.Appearance.ForeColor = System.Drawing.Color.Yellow;
            e.Appearance.BackColor = System.Drawing.Color.Yellow;
            break;
          case "R":
            e.Appearance.ForeColor = System.Drawing.Color.Red;
            e.Appearance.BackColor = System.Drawing.Color.Red;
            break;
          case "V":
            e.Appearance.ForeColor = System.Drawing.Color.Green;
            e.Appearance.BackColor = System.Drawing.Color.Green;
            break;
          case "G":
            e.Appearance.ForeColor = System.Drawing.Color.Cyan;
            e.Appearance.BackColor = System.Drawing.Color.Cyan;
            break;
          case "B":
            e.Appearance.ForeColor = System.Drawing.Color.White;
            e.Appearance.BackColor = System.Drawing.Color.White;
            break;
          default:
            break;
        }
      }
    }
  }
}