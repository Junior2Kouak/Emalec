using DevExpress.XtraGrid.Views.Grid;
using MozartControls.Properties;
using MozartLib;
using System;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Reflection;
using System.Windows.Forms;
using MZUtils = MozartControls.Utils;

// NOTE AUX DEV : Cette forme est mise ici car sinon pour l'appeler depuis le projet VB.NET, il faudrait migrer toutes les forms en C# appelantes

namespace MozartControls
{
  public partial class frmDetailsPlanDeCharge : Form
  {
    private const string MOIS = "VMOIS";
    private const string ENGAGE = "NENGAGE";
    private const string RESTE_A_ENGAGE = "NRESTE";

    private DataTable dt = new DataTable();
    private DateTime mCurrentMonth;

    private int mNIDCHANTIER;
    private int mNIDFICHE;
    private string mSType;
    private int mChiffrage;

    public frmDetailsPlanDeCharge(int pNIDCHANTIER, int pNIDFICHE, string pSType, int pChiffrage)
    {
      InitializeComponent();

      mNIDCHANTIER = pNIDCHANTIER;
      mNIDFICHE = pNIDFICHE;
      mSType = pSType;
      mChiffrage = pChiffrage;
    }

    private void frmDetailsPlanDeCharge_Load(object sender, EventArgs e)
    {
      try
      {
        Cursor.Current = Cursors.WaitCursor;

        initGrid();
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

    private void initGrid()
    {
      apiTGrid1.AddColumn(Resources.col_Mois, MOIS, 1000);
      apiTGrid1.AddColumn("Engagé (h)", ENGAGE, 1000, "N0", 1);
      apiTGrid1.AddColumn("Reste à engager (h)", RESTE_A_ENGAGE, 1000, "N0", 1);

      apiTGrid1.CacherCompteur();
      apiTGrid1.CacherBoutonsPrintExcel();

      apiTGrid1.DelockColumn(RESTE_A_ENGAGE);

      mCurrentMonth = new DateTime(DateTime.Now.Year, DateTime.Now.Month, 1).AddMonths(-2);
      LoadDatas();
    }

    private void LoadDatas()
    {
      Cursor.Current = Cursors.WaitCursor;

      DateTime lDateDebut = mCurrentMonth;
      DateTime lDateFin = mCurrentMonth.AddMonths(23);

      string sql = $"exec api_sp_ChantierInfoMOSaisie_DetailDI_PlanCharge2 {mNIDCHANTIER}, {mNIDFICHE}, 'H', '{mSType}', '{lDateDebut:d}', '{lDateFin:d}'";
      apiTGrid1.LoadData(dt, MozartDatabase.cnxMozart, sql);

      // Il faut filtrer sur le mois sélectionné sur 2 mois avant au départ et un total de 24 mois
      DataTable dt_1 = dt.Clone();
      dt_1 = dt.AsEnumerable().Where(row => (row.Field<DateTime>(MOIS) >= lDateDebut && row.Field<DateTime>(MOIS) <= lDateFin)).CopyToDataTable();

      apiTGrid1.GridControl.DataSource = dt_1;

      updateTotaux();

      Cursor.Current = Cursors.Default;
    }

    private bool existInvalidRows()
    {
      DateTime dStartOfMonth = new DateTime(DateTime.Now.Year, DateTime.Now.Month, 1);

      return (dt.AsEnumerable().Where(row => (row.Field<DateTime>(MOIS) < dStartOfMonth) && (row.Field<int>(RESTE_A_ENGAGE) != 0)).Count() > 0);
    }

    private void updateTotaux()
    {
      int dEngage;
      int dResteAEngage = dt.AsEnumerable().Sum(row => row.Field<int>(RESTE_A_ENGAGE));
      int lTotal;

      try { dEngage = dt.AsEnumerable().Sum(row => row.Field<int>(ENGAGE)); } catch (Exception) { dEngage = 0; }
      try { dResteAEngage = dt.AsEnumerable().Sum(row => row.Field<int>(RESTE_A_ENGAGE)); } catch (Exception) { dResteAEngage = 0; }

      lTotal = dEngage + dResteAEngage;

      txtTotEngage.Text = dEngage.ToString();
      txtTotResteAEngager.Text = dResteAEngage.ToString();
      txtTot.Text = lTotal.ToString();

      txtTot.BackColor = (lTotal > mChiffrage) ? Color.Red : Color.LimeGreen;
    }

    private void btnDown_Click(object sender, EventArgs e)
    {
      mCurrentMonth = mCurrentMonth.AddMonths(1);
      LoadDatas();
    }

    private void btnUp_Click(object sender, EventArgs e)
    {
      mCurrentMonth = mCurrentMonth.AddMonths(-1);
      LoadDatas();
    }

    private void apiTGrid1_RowCellStyle(object sender, RowCellStyleEventArgs e)
    {
      if (e.RowHandle < 0)
        return;

      DateTime lCurMonth = Convert.ToDateTime((sender as GridView).GetDataRow(e.RowHandle)[MOIS]).AddMonths(1);

      switch (e.Column.Name)
      {
        case ENGAGE:
          if (lCurMonth < DateTime.Now)
          {
            e.Appearance.BackColor = Color.LightGray;
          }
          break;

        case RESTE_A_ENGAGE:
          // Période échue
          if (lCurMonth < DateTime.Now)
          {
            e.Appearance.BackColor = Color.LightGray;

            string sCurResteAEngager = (sender as GridView).GetDataRow(e.RowHandle)[RESTE_A_ENGAGE].ToString();
            if (sCurResteAEngager != String.Empty)
            {
              int lCurResteAEngager = Convert.ToInt32(sCurResteAEngager);
              if (lCurResteAEngager != 0)
              {
                e.Appearance.ForeColor = Color.Red;
              }
            }
          }
          else
          {
            e.Appearance.BackColor = Color.Yellow;
          }
          break;

        default:
          break;
      }
    }

    private void apiTGrid1_RowCellClick(object sender, RowCellClickEventArgs e)
    {
      if (e.Column.Name == ENGAGE)
      {
        // Evite les plantages si aucune donnée
        GridView view = (sender as GridView);
        DataRow row = view.GetDataRow(view.FocusedRowHandle);
        if (row == null) return;

        string sValEngage = row[ENGAGE].ToString();
        if (sValEngage == "0") return;

        switch (mSType)
        {
          case AnalytiqueChantierCst.TYPE_MO:
            new frmDetailsCaseWithDetailH("RQTEOUV", mNIDCHANTIER).ShowDialog();
            break;
          case AnalytiqueChantierCst.TYPE_MO_MECA:
            new frmDetailsCaseWithDetailH("RQTEOUV_MECA", mNIDCHANTIER).ShowDialog();
            break;
          case AnalytiqueChantierCst.TYPE_MO_CABL:
            new frmDetailsCaseWithDetailH("RQTEOUV_CABL", mNIDCHANTIER).ShowDialog();
            break;
          case AnalytiqueChantierCst.TYPE_MO_AIDETEC:
            new frmDetailsCaseWithDetailH("RQTEOUV_AIDETEC", mNIDCHANTIER).ShowDialog();
            break;
          case AnalytiqueChantierCst.TYPE_MO_CHAFF:
            new frmDetailsCaseWithDetailH("RMOACHAF", mNIDCHANTIER).ShowDialog();
            break;
          case AnalytiqueChantierCst.TYPE_MO_BE:
            new frmDetailsCaseWithDetailH("RMOA_BE", mNIDCHANTIER).ShowDialog();
            break;
          case AnalytiqueChantierCst.TYPE_MO_BE_AUTO:
            new frmDetailsCaseWithDetailH("RMOABE_AUTO", mNIDCHANTIER).ShowDialog();
            break;
          case AnalytiqueChantierCst.TYPE_MO_BE_ELEC:
            new frmDetailsCaseWithDetailH("RMOABE_ELEC", mNIDCHANTIER).ShowDialog();
            break;
          case AnalytiqueChantierCst.TYPE_MO_BE_MECA:
            new frmDetailsCaseWithDetailH("RMOABE_MECA", mNIDCHANTIER).ShowDialog();
            break;
        }
      }
    }

    private void apiTGrid1_CellValueChanged(object sender, DevExpress.XtraGrid.Views.Base.CellValueChangedEventArgs e)
    {
      string sCurResteAEngager = e.Value.ToString();
      int iCurResteAEngager = 0;
      try { iCurResteAEngager = Convert.ToInt32(sCurResteAEngager); } catch (Exception) { };

      string sMois = (sender as GridView).GetDataRow(e.RowHandle)[MOIS].ToString();
      DateTime dDateToUpdate = Convert.ToDateTime(sMois);

      // Il faut updater ici, pas le choix
      using (SqlCommand lCmd = new SqlCommand("api_sp_ChantierUpdateResteAEngager", MozartDatabase.cnxMozart))
      {
        lCmd.CommandType = CommandType.StoredProcedure;

        lCmd.Parameters.Add("@p_nIdFiche", SqlDbType.Int);
        lCmd.Parameters["@p_nIdFiche"].Value = mNIDFICHE;
        lCmd.Parameters.Add("@p_date", SqlDbType.Date);
        lCmd.Parameters["@p_date"].Value = dDateToUpdate;
        lCmd.Parameters.Add("@p_nVal", SqlDbType.Int);
        lCmd.Parameters["@p_nVal"].Value = iCurResteAEngager;
        lCmd.ExecuteNonQuery();
      }

      // MàJ du DataTable pour pouvoir refaire le calcul du total
      dt.Select($"{MOIS} = '{sMois}'")
        .ToList<DataRow>()
        .ForEach(r =>
        {
          r[RESTE_A_ENGAGE] = iCurResteAEngager;
        });

      updateTotaux();

      DataTable dtt = (DataTable)apiTGrid1.GridControl.DataSource;
    }

    private void cmdFermer_Click(object sender, EventArgs e)
    {
      Close();
    }

    private void frmDetailsPlanDeCharge_FormClosing(object sender, FormClosingEventArgs e)
    {
      if (existInvalidRows())
      {
        MessageBox.Show("Des heures prévues sur des mois passés doivent être supprimées ou planifiées.", Resources.Global_erreur, MessageBoxButtons.OK, MessageBoxIcon.Error);

        e.Cancel = true;

        return;
      }
    }
  }
}
