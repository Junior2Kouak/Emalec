using DevExpress.XtraPrinting;
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
  public partial class frmStatPlanning_Delai_Pla_Reg : Form
  {
    public int mTypeStat;

    DataTable dtStat = new DataTable();
    DataTable dtStat_Delai_D = new DataTable();
    DataTable dtStat_Delai_Hors_D = new DataTable();
    DataTable dtStat_Delai_Planif = new DataTable();
    DataTable dtStat_NB_NOK = new DataTable();
    DataTable dtStat_NB_ACT_NOK1 = new DataTable();

    public frmStatPlanning_Delai_Pla_Reg(int c_mTypeStat)
    {
      InitializeComponent();

      mTypeStat = c_mTypeStat;
    }

    private void frmStatHeureDevisTech_Load(object sender, EventArgs e)
    {
      try
      {
        Cursor.Current = Cursors.WaitCursor;
        ModuleMain.Initboutons(this);

        DateEdit_Debut.EditValue = DateTime.Now.AddMonths(-3);
        DateEdit_Fin.EditValue = DateTime.Now;

        switch (mTypeStat)
        {
          case 0:  //par département
            lblTitre.Text = "Délai par région";
            //affichage colonne
            GColDEPARTEMENT.Visible = true;

            LblObjectif.Text = "Délai (D) : 10 H\r\n" +
                     "Délai (Hors D) : 30 H";

            break;

          case 1: //par planificatrice
            lblTitre.Text = "Délai par chargé(e) de planification";
            //affichage colonne
            GColDEPARTEMENT.Visible = false;

            LblObjectif.Text = "Délai (D) : 10 H\r\n" +
                     "Délai (Hors D) : 30 H";
            break;

          case 2: //delai prevention
            lblTitre.Text = "Délai de prévention";
            //affichage colonne
            GColDEPARTEMENT.Visible = false;
            GColMOY_DELAI_D.Visible = true;
            GColMOY_DELAI_D.FieldName = "MOY_DELAI_PREVENTION";

            GColMOY_DELAI_D.Caption = "Moyenne de délai de prévention (en heures) entre la date de prévention du site et la date de planification (8H)";

            GCol_MOY_DELAI_HORS_D.Visible = false;
            GColMOY_DELAI_PLANIF.Visible = false;
            GCol_TOT_NB_NOK.Visible = false;
            GCol_TOT_NB_NOK_SUP_1.Visible = false;

            LblObjectif.Text = "Délai (en heures) : 48 H";
            break;
        }

        Text = lblTitre.Text;

        // FGA le 121/05/25 demande de Lediot
        //                        " - Prestation hors préventif, travaux préventif, fournitures\r\n" +
        LblMemo.Text = "Critère de cette statistique : \r\n" +
                        " - Action avec un technicien itinérant\r\n" +
                        " - Comptes analytiques interne (9xx) exclus\r\n" +
                        " - Délai calculé sur une base de jours ouvré hors jours fériés et WE (8H - 18H)\r\n";
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

    private void cmdExportXLSX_Click(object sender, EventArgs e)
    {
      string filename = "Export_Stat_Delai_Pla_" + DateTime.Now.Day.ToString() + DateTime.Now.Month.ToString() + DateTime.Now.Year.ToString();

      sFD.FileName = filename;

      if (sFD.ShowDialog() != DialogResult.OK) return;
      if (sFD.FileName == "") return;

      XlsxExportOptionsEx opt = new XlsxExportOptionsEx();
      opt.ExportMode = XlsxExportMode.SingleFile;
      opt.ExportType = DevExpress.Export.ExportType.WYSIWYG;

      GCMain.ExportToXlsx(sFD.FileName, opt);
    }

    private void cmdValider_Click(object sender, EventArgs e)
    {
      Cursor = Cursors.WaitCursor;

      dtStat.Clear();
      dtStat_Delai_D.Clear();
      dtStat_Delai_Hors_D.Clear();
      dtStat_Delai_Planif.Clear();
      dtStat_NB_NOK.Clear();
      dtStat_NB_ACT_NOK1.Clear();

      SqlCommand sqlcmd = new SqlCommand("[api_sp_Stat_Planning_Delai_By]", MozartDatabase.cnxMozart)
      {
        CommandType = CommandType.StoredProcedure,
        CommandTimeout = 90
      };
      SqlCommandBuilder.DeriveParameters(sqlcmd);    // liste des paramètres
      sqlcmd.Parameters["@P_DATE_DEBUT"].Value = DateEdit_Debut.Text;
      sqlcmd.Parameters["@P_DATE_FIN"].Value = DateEdit_Fin.Text;
      sqlcmd.Parameters["@P_NTYPESTAT"].Value = mTypeStat;

      SqlDataReader sqlReader = sqlcmd.ExecuteReader();

      //1 ER SELECT GENERAL
      dtStat.Load(sqlReader);
      dtStat_Delai_D.Load(sqlReader);

      if (mTypeStat != 2)
      {
        dtStat_Delai_Hors_D.Load(sqlReader);
        dtStat_Delai_Planif.Load(sqlReader);
        dtStat_NB_NOK.Load(sqlReader);
        dtStat_NB_ACT_NOK1.Load(sqlReader);
      }

      sqlReader.Close();

      GCMain.DataSource = dtStat;
      Cursor = Cursors.Default;
    }

    private void Repo_HL_Delai_D_OpenLink(object sender, DevExpress.XtraEditors.Controls.OpenLinkEventArgs e)
    {
      DataRow drSelected = GVMain.GetDataRow(GVMain.FocusedRowHandle);
      if (drSelected == null) return;
      DataTable Dt = new DataTable();
      string sTitre = "";
      switch (mTypeStat)
      {
        case 0:
          Dt = dtStat_Delai_D.Select($"[NREGCOD] = {drSelected["NDEPNUM"]}").CopyToDataTable();
          sTitre = $"Liste des actions - Département {drSelected["DEPARTEMENT"]} - Délai de traitement D";
          break;
        case 1:
          Dt = dtStat_Delai_D.Select($"[NPERNUM_PLA] = {drSelected["NPERNUM"]}").CopyToDataTable();
          sTitre = $"Liste des actions -  {drSelected["VPERNOM"]} - Délai de traitement D";
          break;
        case 2:
          Dt = dtStat_Delai_D.Select($"[NPERNUM_PLA] = {drSelected["NPERNUM_PLA"]}").CopyToDataTable();
          sTitre = $"Liste des actions - {drSelected["VPERNOM"]} - Délai de prévention";
          break;
      }
      new frmStatPlanning_Delai_Pla_Detail(Dt, mTypeStat == 2 ? 6 : 1, sTitre).ShowDialog();
    }

    private void Repo_HL_Delai_Hors_D_OpenLink(object sender, DevExpress.XtraEditors.Controls.OpenLinkEventArgs e)
    {
      DataRow drSelected = GVMain.GetDataRow(GVMain.FocusedRowHandle);
      if (drSelected == null) return;
      DataTable Dt = mTypeStat == 1 ? dtStat_Delai_Hors_D.Select($"[NPERNUM_PLA] = {drSelected["NPERNUM"]}").CopyToDataTable() : dtStat_Delai_Hors_D.Select($"[NREGCOD] = {drSelected["NDEPNUM"]}").CopyToDataTable();
      string sTitre = mTypeStat == 1 ? $"Liste des actions -  {drSelected["VPERNOM"]} - Délai de traitement (Hors D)" : $"Liste des actions - Département {drSelected["DEPARTEMENT"]} - Délai de traitement (Hors D)";

      new frmStatPlanning_Delai_Pla_Detail(Dt, 2, sTitre).ShowDialog();
    }

    private void Repo_HL_Delai_Planif_OpenLink(object sender, DevExpress.XtraEditors.Controls.OpenLinkEventArgs e)
    {
      DataRow drSelected = GVMain.GetDataRow(GVMain.FocusedRowHandle);
      if (drSelected == null) return;
      DataTable Dt = mTypeStat == 1 ? dtStat_Delai_Planif.Select($"[NPERNUM_PLA] = {drSelected["NPERNUM"]}").CopyToDataTable() : dtStat_Delai_Planif.Select($"[NREGCOD] = {drSelected["NDEPNUM"]}").CopyToDataTable();
      string sTitre = mTypeStat == 1 ? $"Liste des actions -  {drSelected["VPERNOM"]} - Délai de planification" : $"Liste des actions - Département {drSelected["DEPARTEMENT"]} - Délai de planification";

      new frmStatPlanning_Delai_Pla_Detail(Dt, 3, sTitre).ShowDialog();
    }

    private void Repo_HL_NB_NOK_OpenLink(object sender, DevExpress.XtraEditors.Controls.OpenLinkEventArgs e)
    {
      DataRow drSelected = GVMain.GetDataRow(GVMain.FocusedRowHandle);
      if (drSelected == null) return;
      DataTable Dt = mTypeStat == 1 ? dtStat_NB_NOK.Select($"[NPERNUM_PLA] = {drSelected["NPERNUM"]}").CopyToDataTable() : dtStat_NB_NOK.Select($"[NREGCOD] = {drSelected["NDEPNUM"]}").CopyToDataTable();
      string sTitre = mTypeStat == 1 ? $"Liste des actions -  {drSelected["VPERNOM"]} - Nombre de NOK Planning" : $"Liste des actions - Département {drSelected["DEPARTEMENT"]} - Nombre de NOK Planning";

      new frmStatPlanning_Delai_Pla_Detail(Dt, 4, sTitre).ShowDialog();
    }

    private void Repo_HL_NB_ACT_NOK_SUP1_OpenLink(object sender, DevExpress.XtraEditors.Controls.OpenLinkEventArgs e)
    {
      DataRow drSelected = GVMain.GetDataRow(GVMain.FocusedRowHandle);
      if (drSelected == null) return;
      DataTable Dt = mTypeStat == 1 ? dtStat_NB_ACT_NOK1.Select($"[NPERNUM_PLA] = {drSelected["NPERNUM"]}").CopyToDataTable() : dtStat_NB_ACT_NOK1.Select($"[NREGCOD] = {drSelected["NDEPNUM"]}").CopyToDataTable();
      string sTitre = mTypeStat == 1 ? $"Liste des actions -  {drSelected["VPERNOM"]} - Nombre d'actions avec plus d'un nok Planning" : $"Liste des actions - Département {drSelected["DEPARTEMENT"]} - Nombre d'actions avec plus d'un nok Planning";

      new frmStatPlanning_Delai_Pla_Detail(Dt, 5, sTitre).ShowDialog();
    }
  }
}
