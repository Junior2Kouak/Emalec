using DevExpress.XtraGrid.Views.BandedGrid;
using DevExpress.XtraGrid.Views.Grid;
using MozartCS.Properties;
using MozartLib;
using MozartNet;
using MozartUC;
using System;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Reflection;
using System.Windows.Forms;
using MZCtrlResources = MozartControls.Properties.Resources;
using MZUtils = MozartControls.Utils;

namespace MozartCS
{
  public partial class frmKPI : Form
  {
    private const string VCLINOM = "VCLINOM";

    private const string NNOTE_DEPAST = "NNOTE_DEPAST";
    private const string NNOTE_DEPRAP = "NNOTE_DEPRAP"; 
    private const string NNOTE_DEPMOY = "NNOTE_DEPMOY";
    private const string NNOTE_DEPLEN = "NNOTE_DEPLEN";
    private const string NNOTE_DEVIS = "NNOTE_DEVIS";
    private const string NNOTE_RESOLUTION = "NNOTE_RESOLUTION";
    private const string NNOTE_PDP = "NNOTE_PDP";
    private const string NNOTE_PREV = "NNOTE_PREV";
    private const string NNOTE_ENQUETEQUAL = "NNOTE_ENQUETEQUAL";
    private const string NNOTE_GLOBALE = "NNOTE_GLOBALE";

    private DataTable dt = new DataTable();

    public frmKPI()
    {
      InitializeComponent();
    }

    private void frmKPI_Load(object sender, EventArgs e)
    {
      ModuleMain.Initboutons(this);

      DateEdit_Debut.EditValue = DateTime.Now.AddMonths(-1);
      DateEdit_Fin.EditValue = DateTime.Now;

      // TODO - FGB : Temporaire
      //DateEdit_Debut.EditValue = DateTime.Parse("01/04/2024");
      //DateEdit_Fin.EditValue = DateTime.Parse("30/04/2024");

      toolTip1.SetToolTip(cmdValider, "Les dates correspondent aux dates de création des interventions");

      initGrid();
    }

    private void initGrid()
    {
      int lTmp;

      apiTGrid1.dgv.Appearance.HeaderPanel.TextOptions.WordWrap = DevExpress.Utils.WordWrap.Wrap;
      apiTGrid1.dgv.ColumnPanelRowHeight = 60;
      apiTGrid1.dgv.OptionsView.ColumnAutoWidth = false;

      lTmp = apiTGrid1.AddBand("");
      apiTGrid1.AddColumn(lTmp, MZCtrlResources.col_Client, VCLINOM, 1500, "");
      apiTGrid1.AddColumn(lTmp, Resources.col_Cpt, "CPTE_ANA", 2000, "");
      apiTGrid1.AddColumn(lTmp, Resources.col_Chaff, "CHAFF", 1000, "");
      apiTGrid1.AddColumn(lTmp, "Note Globale", NNOTE_GLOBALE, 500, "", MozartUCConstants.GRID_COL_ALIGN_CENTER);

      lTmp = apiTGrid1.AddBand("Dépannages Astreinte");
      apiTGrid1.AddColumn(lTmp, "Nb", "NTOTNBDEPAST", 500, "");
      apiTGrid1.AddColumn(lTmp, "Taux (%)", "CALCTXDEPAST", 500, "N2");
      apiTGrid1.AddColumn(lTmp, "Objectif (%)", "TXDEPAST", 500, "");
      apiTGrid1.AddColumn(lTmp, "Délai (h)", "CALCMOYDEPAST", 500, "N2");
      apiTGrid1.AddColumn(lTmp, "Objectif (h)", "NDEPAST_OBJ", 500, "");

      lTmp = apiTGrid1.AddBand("Dépannages Rapides");
      apiTGrid1.AddColumn(lTmp, "Nb", "NTOTNBDEPRAP", 500, "");
      apiTGrid1.AddColumn(lTmp, "Taux (%)", "CALCTXDEPRAP", 500, "N2");
      apiTGrid1.AddColumn(lTmp, "Objectif (%)", "TXDEPRAP", 500, "");
      apiTGrid1.AddColumn(lTmp, "Délai (h)", "CALCMOYDEPRAP", 500, "N2");
      apiTGrid1.AddColumn(lTmp, "Objectif (h)", "NDEPRAP_OBJ", 500, "");

      lTmp = apiTGrid1.AddBand("Dépannages Moyens");
      apiTGrid1.AddColumn(lTmp, "Nb", "NTOTNBDEPMOY", 500, "");
      apiTGrid1.AddColumn(lTmp, "Taux (%)", "CALCTXDEPMOY", 500, "N2");
      apiTGrid1.AddColumn(lTmp, "Objectif (%)", "TXDEPMOY", 500, "");
      apiTGrid1.AddColumn(lTmp, "Délai (h)", "CALCMOYDEPMOY", 500, "N2");
      apiTGrid1.AddColumn(lTmp, "Objectif (h)", "NDEPMOY_OBJ", 500, "");

      lTmp = apiTGrid1.AddBand("Dépannages Lents");
      apiTGrid1.AddColumn(lTmp, "Nb", "NTOTNBDEPLEN", 500, "");
      apiTGrid1.AddColumn(lTmp, "Taux (%)", "CALCTXDEPLEN", 500, "N2");
      apiTGrid1.AddColumn(lTmp, "Objectif (%)", "TXDEPLEN", 500, "");
      apiTGrid1.AddColumn(lTmp, "Délai (h)", "CALCMOYDEPLEN", 500, "N2");
      apiTGrid1.AddColumn(lTmp, "Objectif (h)", "NDEPLEN_OBJ", 500, "");

      lTmp = apiTGrid1.AddBand("Devis");
      apiTGrid1.AddColumn(lTmp, "Nb", "NTOTNBDEVIS", 500, "");
      apiTGrid1.AddColumn(lTmp, "Délai (J)", "CALCDEVIS", 500, "N2");
      apiTGrid1.AddColumn(lTmp, "Objectif (J)", "NTRANSDEVIS_OBJ", 500, "");

      lTmp = apiTGrid1.AddBand("Travaux");
      apiTGrid1.AddColumn(lTmp, "Nb", "NTOTNBTRVX", 500, "");
      apiTGrid1.AddColumn(lTmp, "Taux (%)", "CALCTXTRVX", 500, "N2");
      apiTGrid1.AddColumn(lTmp, "Objectif (%)", "TXREALTRVX", 500, "");
      apiTGrid1.AddColumn(lTmp, "Délai (J)", "CALCTRVX", 500, "N2");
      apiTGrid1.AddColumn(lTmp, "Objectif (J)", "NREALTRVX_OBJ", 500, "");

      lTmp = apiTGrid1.AddBand("Commandes");
      apiTGrid1.AddColumn(lTmp, "Délai Cmde Client (J)", "CALCDELAICMDECLIENT", 500, "N2");
      apiTGrid1.AddColumn(lTmp, "Délai EMALEC (J)", "CALCDELAICMDEEMALEC", 500, "N2");
      apiTGrid1.AddColumn(lTmp, "Objectif EMALEC (J)", "NDELAICMDE_OBJ", 500, "");
      apiTGrid1.AddColumn(lTmp, "Total (J)", "CALCDELAICMDETOT", 500, "N2");

      lTmp = apiTGrid1.AddBand("Préventif");
      apiTGrid1.AddColumn(lTmp, "Nb", "NTOTNBPREV", 500, "");
      apiTGrid1.AddColumn(lTmp, "Taux (%)", "CALCPREV", 500, "N2");
      apiTGrid1.AddColumn(lTmp, "Objectif (%)", "NRESPPLANMAINT_OBJ", 500, "");

      lTmp = apiTGrid1.AddBand("Enquêtes Qualité");
      apiTGrid1.AddColumn(lTmp, "Nb", "NTOTNBENQ", 500, "");
      apiTGrid1.AddColumn(lTmp, "Taux (%)", "CALCENQQUAL", 500, "N2");
      apiTGrid1.AddColumn(lTmp, "Objectif (%)", "NENQQUAL_OBJ", 500, "");

      // Ici, peu importe la band, ces colonnes ne sont pas visibles
      apiTGrid1.AddHiddenColumn(lTmp, "NCLINUM");
      apiTGrid1.AddHiddenColumn(lTmp, NNOTE_DEPAST);
      apiTGrid1.AddHiddenColumn(lTmp, NNOTE_DEPRAP);
      apiTGrid1.AddHiddenColumn(lTmp, NNOTE_DEPMOY);
      apiTGrid1.AddHiddenColumn(lTmp, NNOTE_DEPLEN);
      apiTGrid1.AddHiddenColumn(lTmp, NNOTE_DEVIS);
      apiTGrid1.AddHiddenColumn(lTmp, NNOTE_RESOLUTION);
      apiTGrid1.AddHiddenColumn(lTmp, NNOTE_PDP);
      apiTGrid1.AddHiddenColumn(lTmp, NNOTE_PREV);
      apiTGrid1.AddHiddenColumn(lTmp, NNOTE_ENQUETEQUAL);

      apiTGrid1.SetFirstBandFixed();

      apiTGrid1.InitColumnList();
    }

    private void cmdValider_Click(object sender, EventArgs e)
    {
      try
      {
        Cursor = Cursors.WaitCursor;

        //test des dates
        if (DateEdit_Debut.Text == "")
        {
          MessageBox.Show(Resources.msg_SaisirDateDeb, Program.AppTitle, MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
          return;
        }

        if (DateEdit_Fin.Text == "")
        {
          MessageBox.Show(Resources.msg_SaisirDateFin, Program.AppTitle, MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
          return;
        }

        DataSet lDS = new DataSet();
        SqlCommand lSqlCommand = new SqlCommand("api_sp_CalculKPIV2", MozartDatabase.cnxMozart)
        {
          CommandType = CommandType.StoredProcedure,
          CommandTimeout = 90
        };
        lSqlCommand.Parameters.AddWithValue("@dDateDebut", DateEdit_Debut.DateTime);
        lSqlCommand.Parameters.AddWithValue("@dDateFin", DateEdit_Fin.DateTime);
        SqlDataAdapter lSqlDA = new SqlDataAdapter(lSqlCommand);
        lSqlDA.Fill(lDS);
        dt = lDS.Tables[0];

        // Pas de résultats
        if (dt.Rows.Count == 0) return;

        apiTGrid1.GridControl.DataSource = lDS.Tables[1];
      }
      catch (Exception ex)
      {
        MZUtils.displayError(MethodBase.GetCurrentMethod().Name, ex);
      }
      finally
      {
        Cursor = Cursors.Default;
      }
    }

    private void apiTGrid1_RowCellClick(object sender, RowCellClickEventArgs e)
    {
      string lTitle;
      string sFilterField;
      string sUnit;
      string sTmp;

      try
      {
        DataRow row = apiTGrid1.GetFocusedDataRow();
        if (null == row) return;

        Cursor = Cursors.WaitCursor;

        int nCliNum = Convert.ToInt32(row["NCLINUM"]);
        int nCpteAna = Convert.ToInt32(row["NCPTE_ANA"]);

        switch (e.Column.Name)
        {
          case NNOTE_GLOBALE:
            sTmp = $" - Dépannage Astreinte : {row["NNOTE_DEPAST"]} / 5{Environment.NewLine}";
            sTmp += $" - Dépannage Rapide : {row["NNOTE_DEPRAP"]} / 10{Environment.NewLine}";
            sTmp += $" - Dépannage Moyen : {row["NNOTE_DEPMOY"]} / 10{Environment.NewLine}";
            sTmp += $" - Dépannage Lent : {row["NNOTE_DEPLEN"]} / 5{Environment.NewLine}";
            sTmp += $" - Préventif : {row["NNOTE_PREV"]} / 20{Environment.NewLine}";
            sTmp += $" - Devis : {row["NNOTE_DEVIS"]} / 10{Environment.NewLine}";
            sTmp += $" - Résolution : {row["NNOTE_RESOLUTION"]} / 10{Environment.NewLine}";
            sTmp += $" - Enquête Qualité : {row["NNOTE_ENQUETEQUAL"]} / 10{Environment.NewLine}";
            sTmp += $" - PDP : {row["NNOTE_PDP"]} / 10";

            MessageBox.Show(sTmp, "Détails", MessageBoxButtons.OK, MessageBoxIcon.Information);
            return;

          case "NTOTNBDEPAST":
            lTitle = $"Détail des dépannages en astreinte pour le client : {row[VCLINOM]}";
            sFilterField = "NDEPAST";
            sUnit = "H";
            break;
          case "NTOTNBDEPRAP":
            lTitle = $"Détail des dépannages rapides pour le client : {row[VCLINOM]}";
            sFilterField = "NDEPRAP";
            sUnit = "H";
            break;
          case "NTOTNBDEPMOY":
            lTitle = $"Détail des dépannages moyens pour le client : {row[VCLINOM]}";
            sFilterField = "NDEPMOY";
            sUnit = "H";
            break;
          case "NTOTNBDEPLEN":
            lTitle = $"Détail des dépannages lents pour le client : {row[VCLINOM]}";
            sFilterField = "NDEPLEN";
            sUnit = "H";
            break;
          case "NTOTNBDEVIS":
            lTitle = $"Détail des devis pour le client : {row[VCLINOM]}";
            sFilterField = "NTRANSDEVIS";
            sUnit = "J";
            break;
          case "NTOTNBTRVX":
            lTitle = $"Détail des travaux pour le client : {row[VCLINOM]}";
            sFilterField = "NREALTRVX";
            sUnit = "J";
            break;
          case "NTOTNBPREV":
            lTitle = $"Détail des maintenances pour le client : {row[VCLINOM]}";
            sFilterField = "NRESPPLANMAINT";
            sUnit = "";
            break;
          case "NTOTNBENQ":
            lTitle = $"Détail des enquêtes qualité pour le client : {row[VCLINOM]}";
            sFilterField = "NENQQUAL";
            sUnit = "";
            break;
          default:
            return;
        }

        if (Convert.ToInt32(row[e.Column.Name]) == 0) return;

        new frmKPIDetails(lTitle, nCliNum, nCpteAna, dt, sFilterField, sUnit).ShowDialog();
      }
      catch (Exception ex)
      {
        MZUtils.displayError(MethodBase.GetCurrentMethod().Name, ex);
      }
      finally
      {
        Cursor = Cursors.Default;
      }
    }

    private void apiTGrid1_RowCellStyle(object sender, RowCellStyleEventArgs e)
    {
      if (e.RowHandle < 0) return;

      string lNomColNb;
      string lNomColNote;

      switch (e.Column.Name)
      {
        case "CALCTXDEPAST":
          lNomColNb = "NTOTNBDEPAST";
          lNomColNote = NNOTE_DEPAST;
          break;

        case "CALCTXDEPRAP":
          lNomColNb = "NTOTNBDEPRAP";
          lNomColNote = NNOTE_DEPRAP;
          break;

        case "CALCTXDEPMOY":
          lNomColNb = "NTOTNBDEPMOY";
          lNomColNote = NNOTE_DEPMOY;
          break;

        case "CALCTXDEPLEN":
          lNomColNb = "NTOTNBDEPLEN";
          lNomColNote = NNOTE_DEPLEN;
          break;

        case "CALCDEVIS":
          lNomColNb = "NTOTNBDEVIS";
          lNomColNote = NNOTE_DEVIS;
          break;

        case "CALCTRVX":
          lNomColNb = "NTOTNBTRVX";
          lNomColNote = NNOTE_RESOLUTION;
          break;

        case "CALCDELAICMDEEMALEC":
          lNomColNb = "CALCDELAICMDEEMALEC";
          lNomColNote = NNOTE_PDP;
          break;

        case "CALCPREV":
          lNomColNb = "NTOTNBPREV";
          lNomColNote = NNOTE_PREV;
          break;

        case "CALCENQQUAL":
          lNomColNb = "NTOTNBENQ";
          lNomColNote = NNOTE_ENQUETEQUAL;
          break;

        default:
          return;
      }

      // Pas de données => pas de couleurs
      double nb = Convert.ToDouble(apiTGrid1.dgv.GetRowCellValue(e.RowHandle, apiTGrid1.dgv.Columns[lNomColNb]));
      if (nb <= 0) return;

      // Positionne la couleur selon la (non) conformité
      double lNote = Convert.ToDouble(apiTGrid1.dgv.GetRowCellValue(e.RowHandle, apiTGrid1.dgv.Columns[lNomColNote]));
      e.Appearance.BackColor = (lNote == 0) ? Color.Red : Color.LimeGreen;
    }
  }
}
