using MozartCS.Properties;
using MozartLib;
using MozartNet;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using MZCtrlResources = MozartControls.Properties.Resources;

namespace MozartCS
{
  public partial class frmListeRSF : Form
  {
    private DataTable mDataTable;

    public frmListeRSF()
    {
      InitializeComponent();
    }

    private void frmListeRSF_Load(object sender, EventArgs e)
    {
      Cursor.Current = Cursors.WaitCursor;
      ModuleMain.Initboutons(this);

      InitApigrid();

      loadData();

      Cursor.Current = Cursors.Default;
    }

    private void loadData()
    {
      mDataTable = new DataTable();

      ApiGrid.LoadData(mDataTable, MozartDatabase.cnxMozart, $"EXEC [api_sp_ListeRaisonsSociales]");
      ApiGrid.GridControl.DataSource = mDataTable;
    }

    private void InitApigrid()
    {
      ApiGrid.AddColumn(MZCtrlResources.col_Client, "VCLINOM", 2200);
      ApiGrid.AddColumn(Resources.col_Nom, "VRSFRSF", 2200);
      ApiGrid.AddColumn(MZCtrlResources.col_TVAIntra, "VRSFTVAINTRANUM", 1000, "", 3);
      ApiGrid.AddColumn(Resources.col_Siret, "VRSFSIRET", 1000);
      ApiGrid.AddColumn($"{MZCtrlResources.col_Pays} ({MZCtrlResources.col_TVAIntra})", "VRSFTVAINTRAPAYS", 1500);
      ApiGrid.AddColumn("Compte comptable", "VRSFCPT8", 1000, "", 3);
      ApiGrid.AddColumn("Compte bancaire", "VBANQUENOM", 1500);
      ApiGrid.AddColumn(Resources.col_Type, "VRSFTYP", 600);
      ApiGrid.AddColumn(Resources.col_Fin, "NRSFFIN", 600, "", 2);
      ApiGrid.AddColumn(Resources.col_Nbj, "NRSFNBJ", 400, "", 1);
      ApiGrid.AddColumn("Jour", "NRSFSUP", 400, "", 1);
      ApiGrid.AddColumn(MZCtrlResources.col_Actif, "CRSFETATACTIF", 600, "", 2);
      ApiGrid.AddColumn("CliNum", "NCLINUM", 0);
      ApiGrid.AddColumn("NRSFNUM", "NRSFNUM", 0);

      ApiGrid.InitColumnList();
    }

    private void cmdModifier_Click(object sender, EventArgs e)
    {
      DataRow currentRow = ApiGrid.GetFocusedDataRow();
      if (null == currentRow) return;

      new frmGestRSF((int)currentRow["NCLINUM"], (int)currentRow["NRSFNUM"]).ShowDialog();
      ApiGrid.Requery(mDataTable, MozartDatabase.cnxMozart);
    }
  }
}
