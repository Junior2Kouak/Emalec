using MozartLib;
using MozartUC;
using System;
using System.Data;
using System.Windows.Forms;

namespace MozartControls
{
  public partial class frmKPIEvolution : Form
  {
    private DataTable mDT;

    public frmKPIEvolution()
    {
      InitializeComponent();

      mDT = new DataTable();
    }

    private void frmKPIEvolution_Load(object sender, EventArgs e)
    {
      Cursor.Current = Cursors.WaitCursor;
      
      // Pas accessible depuis cette DLL : A faire une fois basculé dans le projet Mozart.CS
      //ModuleMain.Initboutons(this);

      initGrid();

      string lSql;

      lSql = $"SELECT NCPTE_ANA, CPTE_ANA, FORMAT(DDATE_HISTO,'MM/yyyy') AS DDATE_HISTO, CALCTXDEPAST, TXDEPAST, CALCTXDEPRAP, TXDEPRAP, CALCTXDEPMOY, TXDEPMOY,";
      lSql += $" CALCTXDEPLEN, TXDEPLEN, CALCPREV, CALCDEVIS, CALCTXTRVX, CALCDELAICMDEEMALEC, CALCENQQUAL";
      lSql += $" FROM TKPI_HISTO";
      lSql += $" WHERE DDATE_HISTO >= DATEADD(YEAR, -1, DATEFROMPARTS(YEAR(GETDATE()), MONTH(GETDATE()), 1))";
      lSql += $" ORDER BY NCPTE_ANA, DDATE_HISTO DESC";
      apiGrid.LoadData(mDT, MozartDatabase.cnxMozart, lSql);

      Cursor.Current = Cursors.Default;
    }

    private void initGrid()
    {
      int lTmp;

      apiGrid.dgv.Appearance.HeaderPanel.TextOptions.WordWrap = DevExpress.Utils.WordWrap.Wrap;
      apiGrid.dgv.ColumnPanelRowHeight = 40;
      apiGrid.dgv.OptionsView.ColumnAutoWidth = false;

      lTmp = apiGrid.AddBand("");
      apiGrid.AddColumn(lTmp, "N° Cpt Ana", "NCPTE_ANA", 500, "", MozartUCConstants.GRID_COL_ALIGN_RIGHT);
      apiGrid.AddColumn(lTmp, "Intitulé", "CPTE_ANA", 2500, "", MozartUCConstants.GRID_COL_ALIGN_RIGHT);
      apiGrid.AddColumn(lTmp, "Date", "DDATE_HISTO", 1000, "", MozartUCConstants.GRID_COL_ALIGN_RIGHT);

      lTmp = apiGrid.AddBand("Déplacements");
      apiGrid.AddColumn(lTmp, "Taux réel Astreinte (%)", "CALCTXDEPAST", 1000, "N0", MozartUCConstants.GRID_COL_ALIGN_RIGHT);
      apiGrid.AddColumn(lTmp, "Objectif Astreinte (%)", "TXDEPAST", 1000, "N0", MozartUCConstants.GRID_COL_ALIGN_RIGHT);
      apiGrid.AddColumn(lTmp, "Taux réel Rapides (%)", "CALCTXDEPRAP", 1000, "N0", MozartUCConstants.GRID_COL_ALIGN_RIGHT);
      apiGrid.AddColumn(lTmp, "Objectif Rapides (%)", "TXDEPRAP", 1000, "N0", MozartUCConstants.GRID_COL_ALIGN_RIGHT);
      apiGrid.AddColumn(lTmp, "Taux réel Moyens (%)", "CALCTXDEPMOY", 1000, "N0", MozartUCConstants.GRID_COL_ALIGN_RIGHT);
      apiGrid.AddColumn(lTmp, "Objectif Moyens (%)", "TXDEPMOY", 1000, "N0", MozartUCConstants.GRID_COL_ALIGN_RIGHT);
      apiGrid.AddColumn(lTmp, "Taux réel Lents (%)", "CALCTXDEPLEN", 1000, "N0", MozartUCConstants.GRID_COL_ALIGN_RIGHT);
      apiGrid.AddColumn(lTmp, "Objectif Lents (%)", "TXDEPLEN", 1000, "N0", MozartUCConstants.GRID_COL_ALIGN_RIGHT);

      lTmp = apiGrid.AddBand("");
      apiGrid.AddColumn(lTmp, "Préventif (%)", "CALCPREV", 1000, "N0", MozartUCConstants.GRID_COL_ALIGN_RIGHT);

      lTmp = apiGrid.AddBand("");
      apiGrid.AddColumn(lTmp, "Devis (J)", "CALCDEVIS", 1000, "N0", MozartUCConstants.GRID_COL_ALIGN_RIGHT);

      lTmp = apiGrid.AddBand("");
      apiGrid.AddColumn(lTmp, "Résolution (J)", "CALCTXTRVX", 1000, "", MozartUCConstants.GRID_COL_ALIGN_RIGHT);

      lTmp = apiGrid.AddBand("");
      apiGrid.AddColumn(lTmp, "PDP (J)", "CALCDELAICMDEEMALEC", 1000, "", MozartUCConstants.GRID_COL_ALIGN_RIGHT);

      lTmp = apiGrid.AddBand("");
      apiGrid.AddColumn(lTmp, "Enquête Qualité (%)", "CALCENQQUAL", 1000, "N0", MozartUCConstants.GRID_COL_ALIGN_RIGHT);

      apiGrid.InitColumnList();

      apiGrid.SetFirstBandFixed();

      apiGrid.GridControl.DataSource = mDT;
    }
  }
}
