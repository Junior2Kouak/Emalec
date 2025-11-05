using MozartControls.Properties;
using MozartLib;
using MozartUC;
using System;
using System.Data;
using System.Reflection;
using System.Windows.Forms;
using MZUtils = MozartControls.Utils;

namespace MozartControls
{
  public partial class frmHistoModifAnaChantier : Form
  {
    private int mIdChantier;

    private DataTable mDataTable;

    public frmHistoModifAnaChantier(int pIdChantier)
    {
      InitializeComponent();

      mIdChantier = pIdChantier;
    }

    private void frmHistoModifAnaChantier_Load(object sender, EventArgs e)
    {
      try
      {
        Cursor.Current = Cursors.WaitCursor;

        initApiTGrid();

        LoadDatas();
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

    private void LoadDatas()
    {
      mDataTable = new DataTable();
      apiTGrid1.LoadData(mDataTable, MozartDatabase.cnxMozart, $"api_sp_ChantierListeHistoRea {mIdChantier}");
      apiTGrid1.GridControl.DataSource = mDataTable;
    }

    private void initApiTGrid()
    {
      apiTGrid1.AddColumn(Resources.col_Date, "DDATEHISTO", 1000, "Date", MozartUCConstants.GRID_COL_ALIGN_CENTER);
      apiTGrid1.AddColumn("Utilisateur", "VQUIMODIF", 1000, "", MozartUCConstants.GRID_COL_ALIGN_CENTER);
      apiTGrid1.AddColumn("Total Prix de vente", "NTOTPV", 1000, "Currency", MozartUCConstants.GRID_COL_ALIGN_RIGHT);
      apiTGrid1.AddColumn("Marge nette", "NTOTMARGE", 1000, "Currency", MozartUCConstants.GRID_COL_ALIGN_RIGHT);
      apiTGrid1.AddColumn("% de marge", "NPCMARGE", 1000, "N1", MozartUCConstants.GRID_COL_ALIGN_RIGHT);
      apiTGrid1.AddColumn("% avancement", "NPC_AVANCE", 1000, "N1", MozartUCConstants.GRID_COL_ALIGN_RIGHT);
      apiTGrid1.AddColumn("Total Nb Heures", "NTOTMOPRODNB", 1000, "", MozartUCConstants.GRID_COL_ALIGN_RIGHT);
      apiTGrid1.AddColumn("Total Montant Heures", "NTOTMOPRODMTT", 1000, "Currency", MozartUCConstants.GRID_COL_ALIGN_RIGHT);
      apiTGrid1.AddColumn("Total Montant MO administrative", "NTOTMOADMINMTT", 1000, "Currency", MozartUCConstants.GRID_COL_ALIGN_RIGHT);
      apiTGrid1.AddColumn("Total Montant Frais Annexes", "NTOTFRAISMTT", 1000, "Currency", MozartUCConstants.GRID_COL_ALIGN_RIGHT);
      apiTGrid1.AddColumn("Total Fournitures", "NTOTFOMTT", 1000, "Currency", MozartUCConstants.GRID_COL_ALIGN_RIGHT);
      apiTGrid1.AddColumn("Total Sous-traitance", "NTOTSTTMTT", 1000, "Currency", MozartUCConstants.GRID_COL_ALIGN_RIGHT);

      apiTGrid1.InitColumnList();

      apiTGrid1.dgv.OptionsView.ColumnHeaderAutoHeight = DevExpress.Utils.DefaultBoolean.True;
    }
  }
}
