using MozartCS.Properties;
using MozartLib;
using MozartNet;
using System;
using System.Data;
using System.Drawing;
using System.Reflection;
using System.Windows.Forms;
using MZUtils = MozartControls.Utils;

namespace MozartCS.AdminCompta
{
  public partial class frmValorisationStock : Form
  {
    DataTable dt = new DataTable();

    public frmValorisationStock()
    {
      InitializeComponent();
    }

    private void frmValorisationStock_Load(object sender, EventArgs e)
    {
      try
      {
        Cursor.Current = Cursors.WaitCursor;
        ModuleMain.Initboutons(this);

        apiTGrid1.LoadData(dt, MozartDatabase.cnxMozart, $"SELECT * FROM api_v_Montantstock ORDER BY VFOUMAT");
        apiTGrid1.GridControl.DataSource = dt;

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

    private void InitApiTgrid()
    {
      try
      {
        apiTGrid1.AddColumn(Resources.col_ID, "NFOUNUM", 400); 
        apiTGrid1.AddColumn(Resources.col_série, "VFOUSER", 500);
        apiTGrid1.AddColumn(Resources.col_materiel, "VFOUMAT", 1500);
        apiTGrid1.AddColumn(Resources.col_marque, "VFOUMAR", 500);
        apiTGrid1.AddColumn(Resources.col_Type, "VFOUTYP", 1500);
        apiTGrid1.AddColumn(Resources.col_reference, "VFOUREF", 500);
        apiTGrid1.AddColumn(Resources.col_Emplacement, "VFOUEMPLACEMENT", 500);
        apiTGrid1.AddColumn(Resources.col_NbJoursSansMouv, "NBJOURDERMOUV", 500, "", 1);
        apiTGrid1.AddColumn(Resources.col_qte2, "QTE", 300, "", 1);
        apiTGrid1.AddColumn(Resources.col_prixU, "PRIX", 400, "Currency", 1);
        apiTGrid1.AddColumn(Resources.col_Total, "TOTAL", 500, "Currency", 1);

        apiTGrid1.InitColumnList();
      }
      catch (Exception ex)
      {
        Cursor.Current = Cursors.Default;
        MZUtils.displayError(MethodBase.GetCurrentMethod().Name, ex);
      }
    }

    private void BtnFermer_Click(object sender, EventArgs e)
    {
      Dispose();
    }

    private void apiTGrid1_RowCellStyle(object sender, DevExpress.XtraGrid.Views.Grid.RowCellStyleEventArgs e)
    {
      if (e.Column.Name == "TOTAL")
      {
        e.Appearance.Font = new Font(e.Appearance.Font, FontStyle.Bold);
      }
    }
  }
}
