using MozartLib;
using MozartNet;
using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Windows.Forms;

namespace MozartCS
{
  public partial class frmSuiviTempsRecupTech_Gest : Form
  {

    DataSet DS_Tps_Suivi_Recup;
    DataTable dtListeSuiviTpsRecup_TotRecup;
    DataTable dtListeSuiviTpsRecup_DET;
    DataTable dtListeSuiviTpsRecup_Solde_DET;
    private string GetPolarite(int value) => value < 0 ? "-" : "";

    public frmSuiviTempsRecupTech_Gest()
    {
      InitializeComponent();
    }

    private void BtnClose_Click(object sender, EventArgs e)
    {
      Close();
    }

    private void frmSuiviTempsRecupTech_Gest_Load(object sender, EventArgs e)
    {

      loaddata();

    }


    private void loaddata()
    {

      DS_Tps_Suivi_Recup = new DataSet();

      dtListeSuiviTpsRecup_DET = new DataTable();

      SqlCommand CmdSql = new SqlCommand("[api_sp_Suivi_Temps_Recup_Liste]", MozartDatabase.cnxMozart);
      CmdSql.CommandType = CommandType.StoredProcedure;
      SqlCommandBuilder.DeriveParameters(CmdSql);    // liste des paramètres

      //  liste des paramètres
      CmdSql.Parameters["@P_VSOCIETE"].Value = MozartLib.MozartParams.NomSociete;

      using (SqlDataReader reader = CmdSql.ExecuteReader())
      {
        dtListeSuiviTpsRecup_DET.Load(reader);
      }

      //creation table des techniciens
      dtListeSuiviTpsRecup_TotRecup = new DataTable();
      dtListeSuiviTpsRecup_TotRecup.Columns.AddRange(new DataColumn[] {new DataColumn("NPERNUM",typeof(int)),
                    new DataColumn("VNOM",typeof(string)),
                    new DataColumn("TOT_NSOLDE_SEC_BASE",typeof(int))});

      var qTotalRecupListe = from TotRecup in dtListeSuiviTpsRecup_DET.AsEnumerable()
                             group TotRecup by new { NPERNUM = TotRecup["NPERNUM"], VNOM = TotRecup["VNOM"] } into grp
                             select new
                             {
                               NPERNUM = grp.Key.NPERNUM,
                               VNOM = grp.Key.VNOM,
                               TOT_NSOLDE_SEC_BASE = grp.Sum(s => s == null ? 0 : s.Field<int?>("NSOLDE_SEC_BASE"))
                             };


      foreach (var item in qTotalRecupListe.OrderBy(ord => ord.VNOM))
      {

        DataRow drnew = dtListeSuiviTpsRecup_TotRecup.NewRow();
        drnew["NPERNUM"] = item.NPERNUM;
        drnew["VNOM"] = item.VNOM;
        drnew["TOT_NSOLDE_SEC_BASE"] = item.TOT_NSOLDE_SEC_BASE;
        dtListeSuiviTpsRecup_TotRecup.Rows.Add(drnew);
      }

      //load es soldes
      dtListeSuiviTpsRecup_Solde_DET = new DataTable();

      CmdSql = new SqlCommand("[api_sp_Suivi_Temps_Recup_Solde_Liste]", MozartDatabase.cnxMozart);
      CmdSql.CommandType = CommandType.StoredProcedure;
      SqlCommandBuilder.DeriveParameters(CmdSql);    // liste des paramètres

      //  liste des paramètres
      CmdSql.Parameters["@P_VSOCIETE"].Value = MozartLib.MozartParams.NomSociete;

      using (SqlDataReader reader = CmdSql.ExecuteReader())
      {
        dtListeSuiviTpsRecup_Solde_DET.Load(reader);
      }

      DS_Tps_Suivi_Recup.Tables.Add(dtListeSuiviTpsRecup_TotRecup);
      DS_Tps_Suivi_Recup.Tables.Add(dtListeSuiviTpsRecup_DET);
      DS_Tps_Suivi_Recup.Tables.Add(dtListeSuiviTpsRecup_Solde_DET);

      //LEVEL 1
      DataColumn parentColumn_Lvl_1 = DS_Tps_Suivi_Recup.Tables[0].Columns["NPERNUM"];
      DataColumn childColumn_Lvl_1 = DS_Tps_Suivi_Recup.Tables[1].Columns["NPERNUM"];
      DataRelation relation_Lvl_1 = new System.Data.DataRelation("NPERNUM_RELATION_LVL_1", parentColumn_Lvl_1, childColumn_Lvl_1);
      DS_Tps_Suivi_Recup.Relations.Add(relation_Lvl_1);

      //LEVEL 2
      DataRelation relation_Lvl_2 = new System.Data.DataRelation("NTPS_RECUP_ID_RELATION_LVL_2",
                                                            new DataColumn[] { DS_Tps_Suivi_Recup.Tables[1].Columns["NTPS_RECUP_ID"] },
                                                            new DataColumn[] { DS_Tps_Suivi_Recup.Tables[2].Columns["NTPS_RECUP_ID"] });
      DS_Tps_Suivi_Recup.Relations.Add(relation_Lvl_2);

      GCSuiviTpsRecup.LevelTree.Nodes[0].RelationName = "NPERNUM_RELATION_LVL_1";
      GCSuiviTpsRecup.LevelTree.Nodes[0].Nodes[0].RelationName = "NTPS_RECUP_ID_RELATION_LVL_2";
      GV_Recup_Detail.ChildGridLevelName = "NPERNUM_RELATION_LVL_1";
      GV_Recup_Solde.ChildGridLevelName = "NTPS_RECUP_ID_RELATION_LVL_2";

      GCSuiviTpsRecup.DataSource = DS_Tps_Suivi_Recup.Tables[0];
    }

    private void GV_ListeTotRecup_CustomColumnDisplayText(object sender, DevExpress.XtraGrid.Views.Base.CustomColumnDisplayTextEventArgs e)
    {
      //liste des colonnes dans lesquelles les secondes sont affichées en time
      List<string> FieldNames = new List<string>();

      FieldNames.Add("TOT_NSOLDE_SEC_BASE");

      if (FieldNames.Contains(e.Column.FieldName))
      {
        if (e.Value != null && e.Value.ToString() != "")
        {

          if (Math.Abs((int)e.Value) < 3600)
          {
            e.DisplayText = $"{GetPolarite((int)e.Value)}00:{Math.Abs(Math.Floor((decimal)TimeSpan.FromSeconds((int)e.Value).Minutes)).ToString("00")}:{Math.Abs(Math.Floor((decimal)TimeSpan.FromSeconds((int)e.Value).Seconds)).ToString("00")}";
          }
          else
          {
            e.DisplayText = $"{GetPolarite((int)e.Value)}{((int)TimeSpan.FromSeconds(Math.Abs((int)e.Value)).TotalHours).ToString("00")}:{Math.Abs(Math.Floor((decimal)TimeSpan.FromSeconds((int)e.Value).Minutes)).ToString("00")}:{Math.Abs(Math.Floor((decimal)TimeSpan.FromSeconds((int)e.Value).Seconds)).ToString("00")}";
          }
        }
      }
    }

    private void GCSuiviTpsRecup_Click(object sender, EventArgs e)
    {

    }

    private void GV_Recup_Detail_CustomColumnDisplayText(object sender, DevExpress.XtraGrid.Views.Base.CustomColumnDisplayTextEventArgs e)
    {
      //liste des colonnes dans lesquelles les secondes sont affichées en time
      List<string> FieldNames = new List<string>();

      FieldNames.Add("NSOLDE_SEC_BASE");

      if (FieldNames.Contains(e.Column.FieldName))
      {
        if (e.Value != null && e.Value.ToString() != "")
        {

          if (Math.Abs((int)e.Value) < 3600)
          {
            e.DisplayText = $"{GetPolarite((int)e.Value)}00:{Math.Abs(Math.Floor((decimal)TimeSpan.FromSeconds((int)e.Value).Minutes)).ToString("00")}:{Math.Abs(Math.Floor((decimal)TimeSpan.FromSeconds((int)e.Value).Seconds)).ToString("00")}";
          }
          else
          {
            e.DisplayText = $"{GetPolarite((int)e.Value)}{((int)TimeSpan.FromSeconds(Math.Abs((int)e.Value)).TotalHours).ToString("00")}:{Math.Abs(Math.Floor((decimal)TimeSpan.FromSeconds((int)e.Value).Minutes)).ToString("00")}:{Math.Abs(Math.Floor((decimal)TimeSpan.FromSeconds((int)e.Value).Seconds)).ToString("00")}";
          }
        }
      }
    }

    private void GV_Recup_Solde_CustomColumnDisplayText(object sender, DevExpress.XtraGrid.Views.Base.CustomColumnDisplayTextEventArgs e)
    {
      //liste des colonnes dans lesquelles les secondes sont affichées en time
      List<string> FieldNames = new List<string>();

      FieldNames.Add("NTOT_SEC_SOLDE");

      if (FieldNames.Contains(e.Column.FieldName))
      {
        if (e.Value != null && e.Value.ToString() != "")
        {

          if (Math.Abs((int)e.Value) < 3600)
          {
            e.DisplayText = $"{GetPolarite((int)e.Value)}00:{Math.Abs(Math.Floor((decimal)TimeSpan.FromSeconds((int)e.Value).Minutes)).ToString("00")}:{Math.Abs(Math.Floor((decimal)TimeSpan.FromSeconds((int)e.Value).Seconds)).ToString("00")}";
          }
          else
          {
            e.DisplayText = $"{GetPolarite((int)e.Value)}{((int)TimeSpan.FromSeconds(Math.Abs((int)e.Value)).TotalHours).ToString("00")}:{Math.Abs(Math.Floor((decimal)TimeSpan.FromSeconds((int)e.Value).Minutes)).ToString("00")}:{Math.Abs(Math.Floor((decimal)TimeSpan.FromSeconds((int)e.Value).Seconds)).ToString("00")}";
          }
        }
      }
    }
  }
}
