using Microsoft.VisualBasic;
using MozartLib;
using MozartNet;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Resources;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace MozartCS
{
  public partial class frmAdminTypePrestaTVAIntra : Form
  {
    private DataTable dtCate = new DataTable();
    private DataTable dtPresta = new DataTable();

    public frmAdminTypePrestaTVAIntra()
    {
      InitializeComponent();
    }

    private void frmAdminTypePrestaTVAIntra_Load(object sender, EventArgs e)
    {
      ModuleMain.Initboutons(this);

      InitApiTGridCate();
      InitApiTGridPresta();

      apiTGrid1_SelectionChanged(null, null);
    }

    private void InitApiTGridCate()
    {
      apiTGridCate.LoadData(dtCate, MozartDatabase.cnxMozart, $"SELECT * FROM TTVACATEGORIE");
      apiTGridCate.GridControl.DataSource = dtCate;

      apiTGridCate.AddColumn("Id", "NTVACATEGORIENUM", 0);
      apiTGridCate.AddColumn("Type de transaction", "VTVACATEGORIENOM", 3000);

      apiTGridCate.InitColumnList();
    }

    private void InitApiTGridPresta()
    {
      //apiTGridPresta.LoadData(dtPresta, MozartDatabase.cnxMozart, $"SELECT * FROM TTVAPRESTATION");
      //apiTGridPresta.GridControl.DataSource = dtPresta;

      apiTGridPresta.AddColumn("Id", "NTVAPRESTATIONNUM", 0);
      apiTGridPresta.AddColumn("Type de prestation", "VTVAPRESTATIONNOM", 3000);

      apiTGridCate.InitColumnList();
    }

    private void cmdAjouterTypePresta_Click(object sender, EventArgs e)
    {
      DataRow currentRow = apiTGridCate.GetFocusedDataRow();
      if (null == currentRow) return;

      string lNewPresta = Interaction.InputBox("Veuillez saisir l'intitulé d'un type de prestation", "", "");
      lNewPresta = lNewPresta.Trim().Replace("'", "''");

      if (lNewPresta == "")
      {
        MessageBox.Show("Veuillez saisir un libellé de prestation", Program.AppTitle, MessageBoxButtons.OK, MessageBoxIcon.Error);
        return;
      }

      ModuleData.ExecuteScalarInt($"INSERT INTO TTVAPRESTATION(NTVACATEGORIENUM, VTVAPRESTATIONNOM) VALUES ({currentRow["NTVACATEGORIENUM"]},'{lNewPresta}')");

      apiTGridPresta.Requery(dtPresta, MozartDatabase.cnxMozart);
    }

    private void apiTGrid1_SelectionChanged(object sender, DevExpress.Data.SelectionChangedEventArgs e)
    {
      DataRow currentRow = apiTGridCate.GetFocusedDataRow();
      if (null == currentRow) return;

      apiTGridPresta.LoadData(dtPresta, MozartDatabase.cnxMozart, $"SELECT * FROM TTVAPRESTATION WHERE NTVACATEGORIENUM={currentRow["NTVACATEGORIENUM"]}");
      apiTGridPresta.GridControl.DataSource = dtPresta;
    }

    private void cmdSupprCate_Click(object sender, EventArgs e)
    {
      DataRow currentRow = apiTGridCate.GetFocusedDataRow();
      if (null == currentRow) return;

      int lCount = (int)ModuleData.ExecuteScalarInt($"SELECT TOP 1 NTVAPRESTATIONNUM FROM TTVAPRESTATION WHERE NTVACATEGORIENUM={currentRow["NTVACATEGORIENUM"]}");
      if (lCount != 0)
      {
        MessageBox.Show("Vous ne pouvez pas supprimer cette catégorie : Des prestations existent pour cette catégorie.", Program.AppTitle, MessageBoxButtons.OK, MessageBoxIcon.Error);
        return;
      }

      // TODO : Tester si cette catégorie n'est pas déjà utilisée quelquepart
      ModuleData.ExecuteScalarInt($"DELETE TTVACATEGORIE WHERE NTVACATEGORIENUM={currentRow["NTVACATEGORIENUM"]}");

      apiTGridCate.Requery(dtCate, MozartDatabase.cnxMozart);
      apiTGridPresta.Requery(dtPresta, MozartDatabase.cnxMozart);
    }

    private void cmdSupprTypePresta_Click(object sender, EventArgs e)
    {
      DataRow currentRow = apiTGridPresta.GetFocusedDataRow();
      if (null == currentRow) return;

      // TODO : Tester si ce type de prestation n'est pas déjà utilisé quelquepart
      ModuleData.ExecuteScalarInt($"DELETE TTVAPRESTATION WHERE NTVACATEGORIENUM={currentRow["NTVACATEGORIENUM"]}");

      apiTGridPresta.Requery(dtPresta, MozartDatabase.cnxMozart);
    }
  }
}
