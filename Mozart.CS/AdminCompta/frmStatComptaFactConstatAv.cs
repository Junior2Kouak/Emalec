using Microsoft.VisualBasic;
using MozartLib;
using MozartNet;
using System;
using System.Data;
using System.Reflection;
using System.Windows.Forms;
using MZCtrlResources = MozartControls.Properties.Resources;
using MZUtils = MozartControls.Utils;

namespace MozartCS.AdminCompta
{
  public partial class frmStatComptaFactConstatAv : Form
  {

    private int _mode;

    private DataTable dt;

    private double total = 0;

    private DateTime _curDate = DateTime.MinValue;

    public frmStatComptaFactConstatAv(int p_mode)
    {
      InitializeComponent();

      _mode = p_mode;
    }

    private void frmStatComptaFactConstatAv_Load(object sender, EventArgs e)
    {
      try
      {
        ModuleMain.Initboutons(this);

        txtDateA0.Text = DateTime.Now.ToShortDateString();
        lblTHTh.Text = "";

        //  titre selon
        if (_mode == 0)
        {
          Label3.Text = $"Facture STT constatée d'avance";
        }
        else
        {
          Label3.Text = $"Facture fournisseur constatée d'avance";
        }
        this.Text = Label3.Text;

        Frame1.Text = $"Date de référence";

        InitapiGridH();

        Cursor = Cursors.Default;
      }
      catch (Exception ex)
      {
        MZUtils.displayError(MethodBase.GetCurrentMethod().Name, ex);
      }

    }
    private void LoadApiGrid()
    {
      dt = new DataTable();
      if (_mode == 0)
        apiTGridH.LoadData(dt, MozartDatabase.cnxMozart, $"[api_sp_AdminCompta_FactST_Constat_Av] '{MozartParams.NomSociete}', '{txtDateA0.Text}'");
      else
        apiTGridH.LoadData(dt, MozartDatabase.cnxMozart, $"[api_sp_AdminCompta_FactFO_Constat_Av] '{MozartParams.NomSociete}', '{txtDateA0.Text}'");

      apiTGridH.GridControl.DataSource = dt;

      total = 0;
      foreach (DataRow rowbis in dt.Rows)
      {
        total += Utils.ZeroIfNull(rowbis.Field<decimal>("FFACHT"));
      }
      lblTHTh.Text = Strings.FormatNumber(total, 0) + " €";

      Cursor = Cursors.Default;
    }

    private void InitapiGridH()
    {
      try
      {
        switch (_mode)
        {
          case 0:
            apiTGridH.AddColumn("ANA", "NDINCTE", 200);
            apiTGridH.AddColumn(MZCtrlResources.col_Client, "VCLINOM", 1200, "", 0, true);
            apiTGridH.AddColumn(MZCtrlResources.col_DI, "NDINNUM", 400);
            apiTGridH.AddColumn(MZCtrlResources.col_Action, "NACTID", 100);
            apiTGridH.AddColumn(MZCtrlResources.col_Etat, "CACTSTA", 100);
            apiTGridH.AddColumn("Détail action", "VACTDES", 1200);
            apiTGridH.AddColumn("Sous-traitant", "VSTFNOM", 1000);
            apiTGridH.AddColumn("N° CS", "NCSTNUM", 300);
            apiTGridH.AddColumn("GROUPE", "LIBGROUPE", 900);
            apiTGridH.AddColumn("CHAFF", "CHAFF", 700);
            apiTGridH.AddColumn("Montant CS", "NACTVAL", 400, "", 1);
            apiTGridH.AddColumn("Code", "SCODE", 100);
            apiTGridH.AddColumn("Montant facture", "FFACHT", 500, "", 1);
            apiTGridH.AddColumn("Réf facture reçue", "VFACREF", 700);
            apiTGridH.AddColumn("Date souhaitée", "DACTDAT", 350);
            apiTGridH.AddColumn("Date planification", "DACTPLA", 350);
            apiTGridH.AddColumn("Date d'exécution", "DACTDEX", 350);
            apiTGridH.AddColumn("Date comptable", "DFACDATE", 350);
            break;

          case 1:
            apiTGridH.AddColumn("ANA", "NDINCTE", 200);
            apiTGridH.AddColumn(MZCtrlResources.col_Client, "VCLINOM", 1200, "", 0, true);
            apiTGridH.AddColumn(MZCtrlResources.col_DI, "NDINNUM", 400);
            apiTGridH.AddColumn(MZCtrlResources.col_Action, "NACTID", 100);
            apiTGridH.AddColumn(MZCtrlResources.col_Etat, "CACTSTA", 100);
            apiTGridH.AddColumn("Détail action", "VACTDES", 1200);
            apiTGridH.AddColumn("Fournisseur", "VSTFNOM", 1000);
            apiTGridH.AddColumn("N° CF", "NCDENUM", 300);
            apiTGridH.AddColumn("GROUPE", "LIBGROUPE", 900);
            apiTGridH.AddColumn("CHAFF", "CHAFF", 700);
            apiTGridH.AddColumn("Montant CF", "NACTVAL", 400, "", 1);
            apiTGridH.AddColumn("Code", "SCODE", 100);
            apiTGridH.AddColumn("Montant facture", "FFACHT", 500, "", 1);
            apiTGridH.AddColumn("Réf facture reçue", "VFACREF", 700);
            apiTGridH.AddColumn("Date souhaitée", "DACTDAT", 350);
            apiTGridH.AddColumn("Date planification", "DACTPLA", 350);
            apiTGridH.AddColumn("Date d'exécution", "DACTDEX", 350);
            apiTGridH.AddColumn("Date comptable", "DFACDATE", 350);
            break;

        }
        apiTGridH.FilterBar = true;
        apiTGridH.InitColumnList();
      }
      catch (Exception ex)
      {
        MZUtils.displayError(MethodBase.GetCurrentMethod().Name, ex);
      }
    }

    private void cmdValider_Click(object sender, EventArgs e)
    {
      Cursor = Cursors.WaitCursor;
      LoadApiGrid();
      Cursor = Cursors.Default;
    }

    private void apiTGridH_ColumnFilterChanged(object sender, EventArgs e)
    {
      double total_filtered = 0;
      //calcul des montant filtred
      DataRow[] dt_filtered;

      DevExpress.Data.Filtering.CriteriaOperator oFilterCrit = apiTGridH.dgv.ActiveFilterCriteria;
      dt_filtered = dt.Select(DevExpress.Data.Filtering.CriteriaToWhereClauseHelper.GetDataSetWhere(oFilterCrit));

      total_filtered = 0;
      foreach (DataRow rowbis in dt_filtered)
      {
        total_filtered += Utils.ZeroIfNull(rowbis.Field<decimal>("FFACHT"));
      }
      lblTHTh.Text = Strings.FormatNumber(total_filtered, 0) + " € / " + Strings.FormatNumber(total, 0) + " €";

    }

    private void cmdDate1_Click(object sender, EventArgs e)
    {
      DateTime d;
      if (DateTime.TryParse(txtDateA0.Text, out d))
        _curDate = Calendar1.Value = d;
      else { _curDate = DateTime.MinValue; Calendar1.Value = DateTime.Now; }
      Calendar1.Visible = true;
      Calendar1.ShowCalendar(new MouseEventArgs(MouseButtons.Left, 1, MousePosition.X - this.Location.X, MousePosition.Y - this.Location.Y, 0));
    }

    private void Calendar1_ValueChanged(object sender, EventArgs e)
    {
      if (Calendar1.Visible) { _curDate = Calendar1.Value; txtDateA0.Text = _curDate.ToShortDateString(); }
    }

    private void cmdDI_Click(object sender, EventArgs e)
    {
      try
      {
        DataRow currentRow = apiTGridH.GetFocusedDataRow();
        if (currentRow == null) return;

        //écran de modification de la demande
        MozartParams.NumDi = Convert.ToInt32(currentRow["NDINNUM"]);
        MozartParams.NumAction = 0;
        new frmAddAction
        {
          mstrStatutDI = "M"
        }.ShowDialog();

        //on revient donc on réinitialise les variables globales
        MozartParams.NumDi = 0;
        MozartParams.NumAction = 0;
      }
      catch (Exception ex)
      {
        MZUtils.displayError(MethodBase.GetCurrentMethod().Name, ex);
      }
    }
  }
}
