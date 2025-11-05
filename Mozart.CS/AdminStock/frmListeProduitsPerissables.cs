using DevExpress.XtraGrid.Views.Grid;
using MozartCS.Properties;
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
  public partial class frmListeProduitsPerissables : Form
  {
    DataTable dt = new DataTable();
    //Dim adoRS As Recordset

    public frmListeProduitsPerissables() { InitializeComponent(); }

    private void frmListeProduitsDangereux_Load(object sender, System.EventArgs e)
    {
      try
      {
        Cursor.Current = Cursors.WaitCursor;
        ModuleMain.Initboutons(this);
        apiTGrid1.LoadData(dt, MozartDatabase.cnxMozart, $"exec [api_sp_ListeDesFournituresPerissables]");
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

    private void cmdValider_Click(object sender, EventArgs e)
    {
      DataRow row = apiTGrid1.GetFocusedDataRow();
      if (null == row) return;

      new frmDetailsFourniture
      {
        mstrStatut = "M",
        mbStatutValidation = true, //true si pas de validation necessaire
        miNumFour = (int)Utils.ZeroIfNull(row["NFOUNUM"])
      }.ShowDialog();

      apiTGrid1.Requery(dt, MozartDatabase.cnxMozart);
    }

    private void InitApiTgrid()
    {
      apiTGrid1.AddColumn(Resources.col_série, "VFOUSER", 1300);
      apiTGrid1.AddColumn(Resources.col_materiel, "VFOUMAT", 7000);
      apiTGrid1.AddColumn(Resources.col_marque, "VFOUMAR", 1100);
      apiTGrid1.AddColumn(Resources.col_Type, "VFOUTYP", 1100); //equivaut a 3cm
      apiTGrid1.AddColumn(Resources.col_Ref, "VFOUREF", 1100);
      apiTGrid1.AddColumn("Cond", "VFOUCON", 700);
      apiTGrid1.AddColumn("UA", "NFOUNBLOT", 600, "", 2);
      apiTGrid1.AddColumn("UV", "NFOUUV", 600, "", 2);
      apiTGrid1.AddColumn("12M", "NFOUNBUTIL", 600, "", 2);
      apiTGrid1.AddColumn("Gest Stock", "CCODEG", 600);
      apiTGrid1.AddColumn(Resources.col_stock, "NFOUQTESTOCK", 700, "", 2);
      apiTGrid1.AddColumn("Recyclage", "NFOUTAR", 600, "0.##", 2);
      apiTGrid1.AddColumn("Crea", "VFOUQUICRE", 1000);
      apiTGrid1.AddColumn("Dernière Modif", "VFOUQUIMOD", 1000);
      apiTGrid1.AddColumn("Dernière Util", "DFOULASTUSE", 1000, "dd/mm/yyyy");
      apiTGrid1.AddColumn("ID", "NFOUNUM", 700);
      apiTGrid1.AddColumn("Emplacement", "VFOUEMPLACEMENT", 1000);

      apiTGrid1.InitColumnList();
    }

    //Style sur la ligne entière
    private void apiTGrid1_RowStyle(object sender, RowStyleEventArgs e)
    {
      GridView View = sender as GridView;
      if (e.RowHandle >= 0)
      {
        if (View.GetDataRow(e.RowHandle)["CCODEG"].ToString().ToUpper() == "O")
        {
          e.Appearance.Font = new Font(e.Appearance.Font, FontStyle.Bold);
        }
      }
    }

    /*--------------------------------------------------------------*/
    private void cmdFermer_Click(object sender, System.EventArgs e)
    {
      Dispose();
    }

  }

}

