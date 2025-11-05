using DevExpress.XtraGrid;
using DevExpress.XtraGrid.Views.Base;
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

namespace MozartCS
{
  public partial class frmAdminBudget : Form
  {
    public int miNumClient;

    private SqlDataAdapter daAC = new SqlDataAdapter();
    private SqlDataAdapter daCR = new SqlDataAdapter();
    private readonly SqlCommandBuilder cbAC = new SqlCommandBuilder();
    private readonly SqlCommandBuilder cbCR = new SqlCommandBuilder();

    DataTable dtAC = new DataTable();
    DataTable dtCR = new DataTable();


    public frmAdminBudget()
    {
      InitializeComponent();
    }

    /* OK --------------------------------------------------------------------------------------- */
    private void frmAnaGidtCli_Load(object sender, System.EventArgs e)
    {
      ModuleMain.Initboutons(this);

      InitRS();
      InitGrids();

      grdAffectCompt.btnExcel.Visible = grdAffectCompt.btnPrint.Visible = grdAffectCompt.chkColumnsList.Visible = false;
    }

    /* OK --------------------------------------------------------------------------------------- */
    private void InitGrids()
    {
      grdAffectCompt.AddColumn("Libellé", "LIBELLE", 1200);
      grdAffectCompt.AddColumn(Resources.col_Montant, "NBUDGET", 600, "", 2);
      grdAffectCompt.AddColumn(Resources.col_annee, "NANNEE", 300, "", 2);
      grdAffectCompt.AddColumn("NCLINUM", "NCLINUM", 0);   // Utile pour la mise à jour
      grdAffectCompt.AddColumn("CTYPEBUDGET", "CTYPEBUDGET", 0);   // Utile pour la mise à jour

      grdAffectCompt.DelockColumn("NBUDGET");
      grdAffectCompt.DelockColumn("NANNEE");
      grdAffectCompt.FilterBar = false;

      //grdAffectCompt.dgv.OptionsView.NewItemRowPosition = NewItemRowPosition.Bottom;
      //grdAffectCompt.dgv.OptionsBehavior.AllowAddRows = DevExpress.Utils.DefaultBoolean.True;
      //grdAffectCompt.dgv.OptionsBehavior.AllowDeleteRows = DevExpress.Utils.DefaultBoolean.True;

      grdAffectCompt.InitColumnList();

    }

    /* OK --------------------------------------------------------------------------------------- */
    private void InitRS()
    {
      // les budgets de prestations
      //Afin d'initialiser les valeurs, on ajoute les 4 lignes par défaut si il n'y  arien dans la table des budgets'
      //
      int iNb = (int)ModuleData.ExecuteScalarInt($"SELECT count(*) from TCLIBUDGET WHERE NCLINUM = {miNumClient}");
      if (iNb == 0)
      {
        ModuleData.ExecuteNonQuery($"INSERT INTO TCLIBUDGET (LIBELLE, NCLINUM, CTYPEBUDGET, NANNEE, NBUDGET) " +
                                  $"select LIBELLE, {miNumClient}, CTYPEBUDGET, NANNEE, NBUDGET FROM TCLIBUDGET WHERE NCLINUM=292");
      }


      daAC = new SqlDataAdapter($"SELECT * FROM TCLIBUDGET WHERE NCLINUM = {miNumClient} ORDER BY NANNEE", MozartDatabase.cnxMozart);
      dtAC.Clear();
      daAC.Fill(dtAC);
      grdAffectCompt.GridControl.DataSource = dtAC;
      cbAC.DataAdapter = daAC;
    }

    /* OK --------------------------------------------------------------------------------------- */
    private void cmdFermer_Click(object sender, System.EventArgs e)
    {
      try
      {
        ColumnView viewAC = grdAffectCompt.GridControl.FocusedView as ColumnView;
        viewAC.CloseEditor();
        if (viewAC.UpdateCurrentRow())
          daAC.Update(dtAC);

      }
      catch (Exception ex)
      {
        MZUtils.displayError(MethodBase.GetCurrentMethod().Name, ex);
      }
      Dispose();
    }

    /* OK --------------------------------------------------------------------------------------- */
    private void grids_InitNewRowE(object sender, InitNewRowEventArgs e)
    {
      GridView currentView = (sender as GridView);

      // insertion de l'identifiant du client
      currentView.SetRowCellValue(e.RowHandle, "NCLINUM", miNumClient);

      // insertion du type d'enregistrement (fourniture ou prestation) en fonction de la liste cliquée
      if (currentView.GridControl.Parent.Name == "grdCentreRes")
        currentView.SetRowCellValue(e.RowHandle, "CTYPEBUDGET", "F");
      else
        currentView.SetRowCellValue(e.RowHandle, "CTYPEBUDGET", "P");
    }

    /* OK --------------------------------------------------------------------------------------- */
    private void grids_PreviewKeyDownE(object sender, PreviewKeyDownEventArgs e)
    {
      GridView currentView = (sender as GridControl).FocusedView as GridView;
      if (e.KeyCode == Keys.Delete)
        currentView.DeleteRow(currentView.FocusedRowHandle);
    }

    private void btnCopier_Click(object sender, EventArgs e)
    {
      DataRow row = grdAffectCompt.GetFocusedDataRow();
      if (null == row) return;

      ModuleData.ExecuteNonQuery($"INSERT INTO TCLIBUDGET (LIBELLE, NCLINUM, CTYPEBUDGET) values (" +
                           $"'{row["LIBELLE"]}',{Convert.ToInt32(row["NCLINUM"])},'{row["CTYPEBUDGET"]}')");

      InitRS();


    }
  }
}

