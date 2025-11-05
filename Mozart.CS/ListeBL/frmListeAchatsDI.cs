using Microsoft.VisualBasic;
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
  public partial class frmListeAchatsDI : Form
  {
    DataTable dt = new DataTable();
    
    public frmListeAchatsDI()
    {
      InitializeComponent();
    }

    private void frmListeBL_Load(object sender, System.EventArgs e)
    {
      try
      {
        Cursor.Current = Cursors.WaitCursor;
        ModuleMain.Initboutons(this);

        apiTGrid1.LoadData(dt, MozartDatabase.cnxMozart, $"Exec api_sp_ListeAchatsDI { MozartParams.NumDi}");
        apiTGrid1.GridControl.DataSource = dt;
        InitTGrid();

        Cursor = Cursors.Default;
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
  
    private void InitTGrid()
    {
      apiTGrid1.AddColumn("Commande", "NCOMNUM", 1000);
      apiTGrid1.AddColumn(Resources.col_Date, "DCOMDAT", 1200, "dd/mm/yy");
      apiTGrid1.AddColumn(Resources.col_Auteur, "VPERNOM", 1800, "", 0, true);
      apiTGrid1.AddColumn(Resources.col_Site, "VSITNOM", 1900);
      apiTGrid1.AddColumn(Resources.col_Action, "NACTID", 900);
      apiTGrid1.AddColumn(Resources.col_Fournisseur, "VSTFNOM", 1500);
      apiTGrid1.AddColumn(Resources.col_Serie, "CCFOCOD", 1000);
      apiTGrid1.AddColumn(Resources.col_materiel, "VFOUMAT", 4000, "", 0, true);// celltype
      apiTGrid1.AddColumn(Resources.col_marque, "VFOUMAR", 1000, "", 0, true);// celltype
      apiTGrid1.AddColumn(Resources.col_Type, "VFOUTYP", 1000, "", 0, true);// celltype
      apiTGrid1.AddColumn(Resources.col_Ref, "VFOUREF", 1000, "", 0, true);// celltype
      apiTGrid1.AddColumn(Resources.col_unite, "NFOUNBLOT", 500, "", 2);
      apiTGrid1.AddColumn(Resources.col_Prix, "NLCOPU", 700, "0.00", 2);
      apiTGrid1.AddColumn("Quantité", "NlCOQTE", 600, "", 2);
      apiTGrid1.AddColumn("Prix client", "PRIXCLIENT", 1000, "", 2);
      apiTGrid1.AddColumn("Date livraison/expédition/planification", "DLIVRDAT", 1200, "dd/mm/yy");
      apiTGrid1.AddColumn(Resources.col_recept, "NCOMETAT", 1100);
      apiTGrid1.AddColumn(Resources.col_annulee, "CCOMACTIF", 1100);
      apiTGrid1.AddColumn(Resources.col_ficheFour, "VLIB", 1300);
      apiTGrid1.AddColumn(Resources.col_Remarque_Interne, "VCOMREM_INTERNE", 1300);

      apiTGrid1.InitColumnList();
    }

    private void cmdQuitter_Click(object sender, System.EventArgs e)
    {
      Dispose();
    }

  }
}