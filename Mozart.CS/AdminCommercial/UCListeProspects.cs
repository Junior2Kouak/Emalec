using DevExpress.XtraGrid;
using DevExpress.XtraGrid.Columns;
using DevExpress.XtraGrid.Views.Grid;
using MozartCS.Properties;
using MozartLib;
using MozartUC;
using System;
using System.Windows.Forms;
using MZCtrlResources = MozartControls.Properties.Resources;

namespace MozartCS
{
  public partial class UCListeProspects : UserControl
  {
    private const string COL_SELECT = "IsSelected";

    public GridControl GridControl => apiTGrid1.GridControl;
    public GridView GridView => apiTGrid1.dgv;

    public UCListeProspects()
    {
      InitializeComponent();
    }

    private void UCListeProspects_Load(object sender, EventArgs e)
    {
      if (DesignMode) return;

      Cursor.Current = Cursors.WaitCursor;

      InitApigrid();

      apiTGrid1.dgv.OptionsView.AllowCellMerge = true;
    }

    private void mergeCells(object sender, CellMergeEventArgs e)
    {
      GridView view = sender as GridView;

      string[] colonnesExclues = { TCLI.TCLI_NOMCOL_VCLINOM, TSOCIETE.TSOCIETE_NOMCOL_VSOCIETE };

      if (Array.Exists(colonnesExclues, c => c == e.Column.FieldName))
      {
        e.Merge = false;
        e.Handled = true;
        return; // Ces colonnes restent toujours séparées
      }

      // Fusionner si toutes les autres colonnes (hors celles non fusionnées et la colonne actuelle) sont identiques
      bool fusionPossible = true;

      foreach (GridColumn col in view.Columns)
      {
        if (col.FieldName == e.Column.FieldName) continue; // ignorer la colonne actuelle
        if (Array.Exists(colonnesExclues, c => c == col.FieldName)) continue; // ignorer les colonnes non fusionnées

        object val1 = view.GetRowCellValue(e.RowHandle1, col);
        object val2 = view.GetRowCellValue(e.RowHandle2, col);

        if (val1 == null && val2 == null) continue;

        if (val1 == null || val2 == null || !val1.Equals(val2))
        {
          fusionPossible = false;
          break;
        }
      }

      e.Merge = fusionPossible;
      e.Handled = true;
    }

    private void InitApigrid()
    {
      apiTGrid1.AddColumn(MZCtrlResources.nom, "VPROSNOM", 1800, "", MozartUCConstants.GRID_COL_ALIGN_LEFT);
      apiTGrid1.AddColumn(MZCtrlResources.Groupe, "VPROSGROUPE", 800, "", MozartUCConstants.GRID_COL_ALIGN_LEFT);
      apiTGrid1.AddColumn(Resources.col_Creation, "DPROSDATECRE", 1000, "dd/mm/yy", MozartUCConstants.GRID_COL_ALIGN_CENTER);
      apiTGrid1.AddColumn(MZCtrlResources.priorite, "NPROSURGENCE", 1200, "", MozartUCConstants.GRID_COL_ALIGN_LEFT);
      apiTGrid1.AddColumn(MZCtrlResources.act_emalec, "VPROSSERVICE", 1200, "", MozartUCConstants.GRID_COL_ALIGN_LEFT);
      apiTGrid1.AddColumn(MZCtrlResources.clientsRattaches, TCLI.TCLI_NOMCOL_VCLINOM, 1000);
      apiTGrid1.AddColumn(MZCtrlResources.societe, TSOCIETE.TSOCIETE_NOMCOL_VSOCIETE, 900, "", MozartUCConstants.GRID_COL_ALIGN_LEFT);
      apiTGrid1.AddColumn(MZCtrlResources.Commercial, "VPROSCOMSUIVI", 1200, "", MozartUCConstants.GRID_COL_ALIGN_LEFT);
      apiTGrid1.AddColumn(MZCtrlResources.secteur_client, "VPROSACT", 1200, "", MozartUCConstants.GRID_COL_ALIGN_LEFT);
      apiTGrid1.AddColumn(MZCtrlResources.departement, "VPRODEP", 700, "", MozartUCConstants.GRID_COL_ALIGN_LEFT);
      apiTGrid1.AddColumn(MZCtrlResources.col_Ville, "VPROSVIL", 1100, "", MozartUCConstants.GRID_COL_ALIGN_LEFT);
      apiTGrid1.AddColumn(MZCtrlResources.col_Pays, "VPROSPAYS", 1100, "", MozartUCConstants.GRID_COL_ALIGN_LEFT);
      apiTGrid1.AddColumn(MZCtrlResources.nb_sites, "NPROSNBSUC", 500, "", MozartUCConstants.GRID_COL_ALIGN_RIGHT);
      apiTGrid1.AddColumn(MZCtrlResources.d_action, "DSUIVDATE", 800, "dd/mm/yy", MozartUCConstants.GRID_COL_ALIGN_CENTER);
      apiTGrid1.AddColumn(MZCtrlResources.Prospecteur, "VSUIVQUI", 1100, "", MozartUCConstants.GRID_COL_ALIGN_LEFT);
      apiTGrid1.AddColumn(MZCtrlResources.col_Action, "VSUIVACTION", 5300, "", MozartUCConstants.GRID_COL_ALIGN_LEFT);
      apiTGrid1.AddColumn(Resources.col_D_suivante, "DSUIVDATERAP", 800, "dd/mm/yy", MozartUCConstants.GRID_COL_ALIGN_CENTER);
      apiTGrid1.AddColumn(MZCtrlResources.pays_inter, "VLISTEPAYS", 1000, "", MozartUCConstants.GRID_COL_ALIGN_LEFT);

      apiTGrid1.AddHiddenColumn("NSUIVNUM");
      apiTGrid1.AddHiddenColumn(TPROSP.TPROSP_NOMCOL_NPROSNUM);
      apiTGrid1.AddHiddenColumn(TPROSP.TPROSP_NOMCOL_CPROSRDV);
      apiTGrid1.AddHiddenColumn("CPROSPOFFRE");
      apiTGrid1.AddHiddenColumn("VPROSCP");

      apiTGrid1.CounterColumn = TPROSP.TPROSP_NOMCOL_NPROSNUM;

      apiTGrid1.InitColumnList();
    }

    // Permet de rendre visible la colonne de sélection et activer le mode multi sélection
    public void EnableCheckboxSelection()
    {
      // Enlève les colonnes
      GridView.Columns.Remove(GridView.Columns.ColumnByFieldName("VPROSACT"));
      GridView.Columns.Remove(GridView.Columns.ColumnByFieldName(TCLI.TCLI_NOMCOL_VCLINOM));
      GridView.Columns.Remove(GridView.Columns.ColumnByFieldName(TSOCIETE.TSOCIETE_NOMCOL_VSOCIETE));
      GridView.Columns.Remove(GridView.Columns.ColumnByFieldName("NPROSNBSUC"));
      GridView.Columns.Remove(GridView.Columns.ColumnByFieldName("DSUIVDATE"));
      GridView.Columns.Remove(GridView.Columns.ColumnByFieldName("VSUIVACTION"));
      GridView.Columns.Remove(GridView.Columns.ColumnByFieldName("DSUIVDATERAP"));
      GridView.Columns.Remove(GridView.Columns.ColumnByFieldName("VLISTEPAYS"));

      apiTGrid1.AddColumn(" ", COL_SELECT, 80, "", MozartUCConstants.GRID_COL_ALIGN_CENTER);
      GridColumn gridColumn = GridView.Columns[COL_SELECT];
      gridColumn.Width = 80;
      gridColumn.VisibleIndex = 0;
      gridColumn.OptionsColumn.ReadOnly = false;

      GridView.OptionsBehavior.EditorShowMode = DevExpress.Utils.EditorShowMode.MouseDown;

      GridView.RowClick += (s, e) =>
      {
        var view = s as GridView;
        int rowHandle = e.RowHandle;

        if (rowHandle >= 0)
        {
          // Inverser la valeur de la checkbox
          bool currentValue = (bool)view.GetRowCellValue(rowHandle, COL_SELECT);
          view.SetRowCellValue(rowHandle, COL_SELECT, !currentValue);
        }
      };
    }
  }
}
