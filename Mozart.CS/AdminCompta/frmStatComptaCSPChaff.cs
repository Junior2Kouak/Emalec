using Microsoft.VisualBasic;
using MozartCS.Properties;
using MozartLib;
using MozartNet;
using System;
using System.Data;
using System.Reflection;
using System.Windows.Forms;
using MZUtils = MozartControls.Utils;
using MZCtrlResources = MozartControls.Properties.Resources;

namespace MozartCS
{
  public partial class frmStatComptaCSPChaff : Form
  {
    public string msType;
    public string msDate;
    public string msCpt;
    public string mstrsChaff;

    DataTable dt = new DataTable();

    double dTot = 0;

    //' ******************************************************************************************************
    //' Form est appelée à 3 endroits différents dans Mozart avec le stype : CSP, STT, STCHAFF
    //' ******************************************************************************************************

    public frmStatComptaCSPChaff()
    {
      InitializeComponent();
    }

    /* OK ---------------------------------------------------------------------*/

    private void frmStatComptaCSPChaff_Load(object sender, System.EventArgs e)
    {
      try
      {
        ModuleMain.Initboutons(this);
        txtDateA0.Text = msDate == null || msDate == "" ? DateTime.Now.ToShortDateString() : msDate;

        InitapiGrid();

        if (msType == "CSP" || msType == "CSPCHAFF")
        {
          Label3.Text = "Liste des contrats SOUS-TRAITANT périodiques";
          cmdDate1.Visible = false;
          cmdValider.Visible = false;
          cmdLegende.Visible = false;
        }

        loadApiGrid();

        Cursor = Cursors.Default;
      }
      catch (Exception ex)
      {
        MZUtils.displayError(MethodBase.GetCurrentMethod().Name, ex);
      }
    }

    private void cmdArchives_Click(object sender, EventArgs e)
    {
      Label3.Text = "Liste des contrats SOUS-TRAITANT périodiques archivés";
      msType = "CSP-ARCH";
      loadApiGrid();
    }

    private void CmdDI_Click(object sender, EventArgs e)
    {
      DataRow currentRow = apiTGridH.GetFocusedDataRow();
      if (currentRow == null) return;

      //  écran de modification de la demande
      frmAddAction f = new frmAddAction()
      {
        mstrStatutDI = "M"
      };

      MozartParams.NumDi = Convert.ToInt32(currentRow["NDINNUM"]);
      MozartParams.NumAction = Convert.ToInt32(currentRow["NACTNUM"]);

      f.ShowDialog();

      //  on revient donc on réinitialise les variables globales
      MozartParams.NumDi = 0;
      MozartParams.NumAction = 0;
    }



    DateTime _curDate = DateTime.MinValue;
    private void Calendar1_CloseUp(object sender, EventArgs e)
    {
      Calendar1.Visible = false;
      if (_curDate == DateTime.MinValue) return;
      txtDateA0.Text = Calendar1.Value.ToShortDateString();
    }
    private void Calendar1_ValueChanged(object sender, EventArgs e)
    {
      if (Calendar1.Visible) _curDate = Calendar1.Value;
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


    private void cmdValider_Click(object sender, EventArgs e)
    {
      Cursor = Cursors.WaitCursor;

      loadApiGrid();

      Cursor = Cursors.Default;
    }


    private void loadApiGrid()
    {

      switch (msType)
      {
        case "CSP":
          apiTGridH.LoadData(dt, MozartDatabase.cnxMozart, $"api_sp_ListeEtatCSP '{txtDateA0.Text} 22:00:00'");
          break;
        case "CSPCHAFF":
          apiTGridH.LoadData(dt, MozartDatabase.cnxMozart, $"api_sp_ListeEtatCSPChaff '{txtDateA0.Text} 22:00:00',{msCpt},{mstrsChaff}");
          break;
        case "CSP-ARCH":
          apiTGridH.LoadData(dt, MozartDatabase.cnxMozart, $"api_sp_ListeEtatCSP_ARCH '{txtDateA0.Text} 22:00:00',{msCpt}");
          break;
        case "STT":
          apiTGridH.LoadData(dt, MozartDatabase.cnxMozart, $"api_sp_ListeEtatComptaCSP '{txtDateA0.Text} 22:00:00'");
          break;
        case "STTCHAFF":
          apiTGridH.LoadData(dt, MozartDatabase.cnxMozart, $"api_sp_ListeEtatComptaCSPChaff '{txtDateA0.Text} 22:00:00',{msCpt},{mstrsChaff} ");
          break;
      }

      apiTGridH.GridControl.DataSource = dt;

      //  affichage du total en bas de liste
      calculTHT();

      Cursor = Cursors.Default;
    }


    private void InitapiGrid()
    {
      try
      {
        apiTGridH.AddColumn(MZCtrlResources.col_DI, "NDINNUM", 750);
        apiTGridH.AddColumn(MZCtrlResources.col_Action, "NACTID", 500);
        apiTGridH.AddColumn(MZCtrlResources.col_Client, "VCLINOM", 1200, "", 0, true);
        apiTGridH.AddColumn(Resources.col_Chaff, "CHAFF", 1500);
        apiTGridH.AddColumn(Resources.col_groupe, "LIBGROUPE", 1500);
        apiTGridH.AddColumn("Cte", "NDINCTE", 700);
        apiTGridH.AddColumn(MZCtrlResources.col_libelle, "VACTDES", 4100, "", 0, true);
        apiTGridH.AddColumn("SST", "VSTFNOM", 1400, "", 0, true);
        apiTGridH.AddColumn("CTR", "NCSTNUM", 800);
        apiTGridH.AddColumn("Date début", "DCSTDEL", 1400);
        apiTGridH.AddColumn("Date fin", "DCSTFIN", 1200);
        apiTGridH.AddColumn("Mt Contrat", "NCSTFOR", 1500, "Currency", 1);
        apiTGridH.AddColumn("Fact reçues", "NFACRECU", 1500, "Currency", 1);
        apiTGridH.AddColumn("Encours", "ENCOURS", 1400, "Currency", 1);
        //apiTGridH.AddColumn(Resources.col_Code, "SCODE", 700, "", 2);

        apiTGridH.FilterBar = true;
        apiTGridH.InitColumnList();
      }
      catch (Exception ex)
      {
        MZUtils.displayError(MethodBase.GetCurrentMethod().Name, ex);
      }
    }

    private void calculTHT()
    {
      dTot = 0;

      if (dt.Rows.Count == 0)
        return;

      foreach (DataRow row in dt.Rows)
        dTot += Utils.ZeroIfNull(row["ENCOURS"]);

      lblTHTh.Text = string.Format(dTot.ToString(), "### ### ### €");
    }


    private void cmdLegende_Click(object sender, EventArgs e)
    {
      Frame4.Visible = true;
    }


    private void Command1_Click(object sender, EventArgs e)
    {
      Frame4.Visible = false;
    }
    private void cmdFermer_Click(object sender, System.EventArgs e)
    {
      Dispose();
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
        total_filtered += Utils.ZeroIfNull(rowbis.Field<decimal>("ENCOURS"));
      }
      lblTHTh.Text = Strings.FormatNumber(total_filtered, 0) + " € / " + Strings.FormatNumber(dTot, 0) + " €";
    }
  }
}

