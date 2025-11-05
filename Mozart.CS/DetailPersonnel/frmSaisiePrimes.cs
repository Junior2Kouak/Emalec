using DevExpress.XtraGrid;
using DevExpress.XtraGrid.Views.Grid;
using MozartCS.Properties;
using MozartLib;
using MozartNet;
using System;
using System.Data;
using System.Data.SqlClient;
using System.Reflection;
using System.Windows.Forms;
using MZUtils = MozartControls.Utils;

namespace MozartCS.DetailPersonnel
{
  public partial class frmSaisiePrimes : Form
  {
    private bool bPrimeCC;

    private int miNumPer;
    private string sPrimeCC;

    private DataTable dtPrimes = new DataTable();
    private SqlDataAdapter daPrimes;
    private SqlCommandBuilder cbPrimes;

    public frmSaisiePrimes() : this(false, 0)
    {
    }

    // pPrimeCC
    // = true si prime CC/contrat
    // = false si prime non contractuelle
    public frmSaisiePrimes(Boolean pPrimeCC, int pNumPer)
    {
      InitializeComponent();

      bPrimeCC = pPrimeCC;
      miNumPer = pNumPer;
    }

    private void frmSaisiePrimes_Load(object sender, EventArgs e)
    {
      ModuleMain.Initboutons(this);

      grdPrimes.btnExcel.Visible = grdPrimes.btnPrint.Visible = false;

      FormatGrid();

      if (bPrimeCC)
      {
        sPrimeCC = "C";
        lblTitre.Text = this.Text = "Saisie des primes contrat";
      }
      else
      {
        sPrimeCC = "H";
        lblTitre.Text = this.Text = "Saisie des primes hors contrat";
      }
      daPrimes = new SqlDataAdapter($"SELECT NPRIMNUM, NPERNUM, VPRIMDESC, NPRIMMONTANT, BPRIMECC, VPRIMREFTPS FROM TPRIMES WHERE NPERNUM = {miNumPer} AND BPRIMECC = '{sPrimeCC}'", MozartDatabase.cnxMozart);
      dtPrimes.Clear();
      daPrimes.Fill(dtPrimes);
      grdPrimes.GridControl.DataSource = dtPrimes;
    }

    private void FormatGrid()
    {
      try
      {
        grdPrimes.AddColumn("nPrimeNum", "NPRIMNUM", 0);
        grdPrimes.AddColumn("nPerNum", "NPERNUM", 0);
        grdPrimes.AddColumn(Resources.col_Description, "VPRIMDESC", 700);
        grdPrimes.AddColumn(Resources.col_MontantBrutAnnuelEstimatif, "NPRIMMONTANT", 600, "Currency", 2);
        grdPrimes.AddColumn("bPrimeCC", "BPRIMECC", 0);
        grdPrimes.AddColumn("reftps", "VPRIMREFTPS", 0);
        grdPrimes.InitColumnList();

        grdPrimes.DelockColumn("NPERNUM");
        grdPrimes.DelockColumn("VPRIMDESC");
        grdPrimes.DelockColumn("NPRIMMONTANT");
        grdPrimes.DelockColumn("BPRIMECC");
        grdPrimes.DelockColumn("VPRIMREFTPS");
        grdPrimes.dgv.OptionsView.NewItemRowPosition = NewItemRowPosition.Bottom;
        grdPrimes.dgv.OptionsBehavior.AllowAddRows = DevExpress.Utils.DefaultBoolean.True;
        grdPrimes.dgv.OptionsBehavior.AllowDeleteRows = DevExpress.Utils.DefaultBoolean.True;
      }
      catch (Exception ex)
      {
        MZUtils.displayError(MethodBase.GetCurrentMethod().Name, ex);
      }
    }

    private void cmdEnregistrer_Click(object sender, EventArgs e)
    {
      // grille grdEnf
      if (null != daPrimes && null != daPrimes.SelectCommand)
      {
        cbPrimes = new SqlCommandBuilder(daPrimes);
        daPrimes.InsertCommand = cbPrimes.GetInsertCommand();
        daPrimes.UpdateCommand = cbPrimes.GetUpdateCommand();
        daPrimes.DeleteCommand = cbPrimes.GetDeleteCommand();
        foreach (DataRow row in dtPrimes.Rows)
        {
          if (row.RowState == DataRowState.Added)
          {
            row["NPERNUM"] = miNumPer;
            row["BPRIMECC"] = sPrimeCC;
          }
        }
        int res = daPrimes.Update(dtPrimes);
      }
    }

    private void cmdFermer_Click(object sender, EventArgs e)
    {
      Dispose();
    }

    private void grdPrimes_PreviewKeyDownE(object sender, PreviewKeyDownEventArgs e)
    {
      GridControl gridControl = (GridControl)sender;
      GridView currentView = (GridView)gridControl.FocusedView;
      if (e.KeyCode == Keys.Delete)
        currentView.DeleteRow(currentView.FocusedRowHandle);
    }
  }
}
