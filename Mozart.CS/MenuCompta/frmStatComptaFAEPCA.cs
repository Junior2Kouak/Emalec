using MZCtrlResources = MozartControls.Properties.Resources;
using DevExpress.Utils;
using DevExpress.XtraEditors.Controls;
using DevExpress.XtraEditors.Repository;
using DevExpress.XtraGrid.Columns;
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
  public partial class frmStatComptaFAEPCA : Form
  {
    public string mstrDate;

    DataTable dtH = new DataTable();

    public frmStatComptaFAEPCA(string pDate)
    {
      InitializeComponent();

      mstrDate = pDate;
    }

    private void frmStatComptaFAEPCA_Load(object sender, System.EventArgs e)
    {
      try
      {
        Cursor.Current = Cursors.WaitCursor;
        ModuleMain.Initboutons(this);

        dtDateRef.DateTime = DateTime.Parse(mstrDate);

        LoadApiGridH();
        InitapiGridH();

        Cursor = Cursors.Default;
      }
      catch (Exception ex)
      {
        MZUtils.displayError(MethodBase.GetCurrentMethod().Name, ex);
      }
      finally { Cursor.Current = Cursors.Default; }
    }

    private void LoadApiGridH()
    {
      apiTGridH.LoadData(dtH, MozartDatabase.cnxMozart, $"api_sp_ListeEtatComptaFAEPCA '{mstrDate}'");
      apiTGridH.GridControl.DataSource = dtH;
    }

    private RepositoryItemComboBox buildRepositoryItemComboBoxOuiNon()
    {
      RepositoryItemComboBox riComboBox = new RepositoryItemComboBox();
      riComboBox.Items.Add("NON");
      riComboBox.Items.Add("OUI");
      riComboBox.TextEditStyle = TextEditStyles.DisableTextEditor;

      return riComboBox;
    }

    private void InitapiGridH()
    {
      try
      {
        apiTGridH.AddColumn(MZCtrlResources.col_Client, "VCLINOM", 1500, "", 0, true);
        apiTGridH.AddColumn(Resources.col_cte, "NDINCTE", 700);
        apiTGridH.AddColumn(Resources.col_Chaff, "VPERCHAFF", 1200, "", 0, true);
        apiTGridH.AddColumn(Resources.col_groupe, "LIBGROUPE", 1500);
        apiTGridH.AddColumn("Facturation", "VTYPEFACT", 1000);
        apiTGridH.AddColumn("Début période", "DDATEDEBUT", 1000);
        apiTGridH.AddColumn("Fin période", "DDATEFIN", 1000);
        apiTGridH.AddColumn("Total action 'P' (€)", "NTOTPREV", 1000, "Currency", 1);
        apiTGridH.AddColumn("Actions 'P' archivées (€)", "NTOTACTPARCH", 1000, "Currency", 1);
        apiTGridH.AddColumn("Actions 'P' exécutées (€)", "NTOTACTPEXE", 1000, "Currency", 1);
        apiTGridH.AddColumn("Facturé", "NTOTACTPFACT", 1000, "Currency", 1);
        apiTGridH.AddColumn(Resources.col_NumCLI, "NCLINUM", 0);
        apiTGridH.AddColumn("MONTANTPREV", "NMONTANTPREV", 0);
        apiTGridH.AddColumn("MONTANTCONTRAT", "NMONTANTCONTRAT", 0);

        // Encours
        // Colonne non rattachée au datatable : Contient la diff entre Total préventif seul (Saisie manuelle) et Total contrat "Facturation"
        GridColumn ColonneResultats = new GridColumn
        {
          Caption = "Encours",
          FieldName = "ENCOURS",
          UnboundType = DevExpress.Data.UnboundColumnType.Decimal,
          Visible = true,
          Width = 100
        };
        apiTGridH.dgv.Columns.Add(ColonneResultats);
        apiTGridH.dgv.Columns["ENCOURS"].OptionsColumn.AllowEdit = false;
        apiTGridH.dgv.Columns["ENCOURS"].DisplayFormat.FormatType = FormatType.Numeric;
        apiTGridH.dgv.Columns["ENCOURS"].DisplayFormat.FormatString = "c2";
        apiTGridH.dgv.CustomUnboundColumnData += (sender, e) =>
        {
          if (e.Column.FieldName != "ENCOURS") return;

          GridView view = sender as GridView;
          if (view == null) return;

          if (e.IsGetData)
          {
            int rowIndex = e.ListSourceRowIndex;

            Decimal lValTotPrev = 0;
            Decimal lValTotContFact = 0;
            Decimal lValMontantPrev = 0;
            Decimal lValMontantContrat = 0;
            Decimal lDiff;

            try { lValTotPrev = Convert.ToDecimal(view.GetListSourceRowCellValue(rowIndex, "NTOTACTPEXE")); } catch (Exception) { };
            try { lValTotContFact = Convert.ToDecimal(view.GetListSourceRowCellValue(rowIndex, "NTOTACTPFACT")); } catch (Exception) { };
            try { lValMontantPrev = Convert.ToDecimal(view.GetListSourceRowCellValue(rowIndex, "NMONTANTPREV")); } catch (Exception) { };
            try { lValMontantContrat = Convert.ToDecimal(view.GetListSourceRowCellValue(rowIndex, "NMONTANTCONTRAT")); } catch (Exception) { };

            if (lValMontantContrat == 0)
            {
              lDiff = lValTotPrev;
            }
            else
            {
              lDiff = lValTotPrev - (lValTotContFact * lValMontantPrev / lValMontantContrat);
            }
            e.Value = lDiff;
          }
        };

        // Type encours
        // Colonne non rattachée au datatable : Contient la diff entre Total préventif seul (Saisie manuelle) et Total contrat "Facturation"
        GridColumn ColonneTypeEncours = new GridColumn
        {
          Caption = "Type encours",
          FieldName = "TYPEENCOURS",
          UnboundType = DevExpress.Data.UnboundColumnType.String,
          Visible = true,
          Width = 200
        };
        apiTGridH.dgv.Columns.Add(ColonneTypeEncours);
        apiTGridH.dgv.Columns["TYPEENCOURS"].OptionsColumn.AllowEdit = false;
        apiTGridH.dgv.CustomColumnDisplayText += (sender, e) =>
        {
          if (e.Column.FieldName != "TYPEENCOURS") return;

          GridView view = sender as GridView;
          if (view == null) return;

          int rowIndex = e.ListSourceRowIndex;
          if (rowIndex < 0) return;

          Decimal lEncours = 0;
          try { lEncours = Convert.ToDecimal(view.GetListSourceRowCellValue(rowIndex, "ENCOURS")); } catch (Exception) { };

          e.DisplayText = (lEncours < 0) ? "PCA" : "FAE";
        };

        // Colonne Actif
        apiTGridH.AddColumn("Actif ?", "CCONTRATPERACTIF", 500);
        RepositoryItemComboBox riComboBox2 = buildRepositoryItemComboBoxOuiNon();
        apiTGridH.dgv.Columns["CCONTRATPERACTIF"].ColumnEdit = riComboBox2;
        apiTGridH.GridControl.RepositoryItems.Add(riComboBox2);
        apiTGridH.DelockColumn("CCONTRATPERACTIF");

        apiTGridH.dgv.ActiveFilterString = "CCONTRATPERACTIF = 'OUI'";

        apiTGridH.InitColumnList();
      }
      catch (Exception ex)
      {
        MZUtils.displayError(MethodBase.GetCurrentMethod().Name, ex);
      }
    }

    private void apiTGridH_RowCellStyle(object sender, RowCellStyleEventArgs e)
    {
      DataRow row = apiTGridH.GetFocusedDataRow();
      if (null == row) return;

      if ((e.Column.Name == "CCONTRATPERACTIF") && (e.CellValue.ToString() == "NON"))
      {
        e.Appearance.BackColor = Color.OrangeRed;
      }
    }

    private void chkAfficherInactif_CheckedChanged(object sender, EventArgs e)
    {
      if (chkAfficherInactif.Checked)
      {
        apiTGridH.dgv.ActiveFilterString = "";
      }
      else
      {
        apiTGridH.dgv.ActiveFilterString = "CCONTRATPERACTIF = 'OUI'";
      }
    }

    private void apiTGridH_CellValueChanged(object sender, DevExpress.XtraGrid.Views.Base.CellValueChangedEventArgs e)
    {
      DataRow row = apiTGridH.GetFocusedDataRow();
      if (null == row) return;

      if (e.Column.Name == "CCONTRATPERACTIF")
      {
        string lNewVal = (e.Value.ToString() == "OUI") ? "O" : "N";

        string sSQL = $"UPDATE TCONTRATPER SET CCONTRATPERACTIF = '{lNewVal}' WHERE NCONTRATPERNUM = {row["NCONTRATPERNUM"]}";
        ModuleData.CnxExecute(sSQL);
      }
    }

    private void btnValid_Click(object sender, EventArgs e)
    {
      Cursor.Current = Cursors.WaitCursor;
      apiTGridH.LoadData(dtH, MozartDatabase.cnxMozart, $"api_sp_ListeEtatComptaFAEPCA '{dtDateRef.Text}'");
      apiTGridH.GridControl.DataSource = dtH;
      Cursor = Cursors.Default;
    }
  }
}

