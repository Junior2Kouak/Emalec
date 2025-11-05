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
  public static class UtilsDevis
  {
    public static double RechercheTauxDeTVA(int numAction)
    {
      double dRet = 0;
      using (SqlDataReader dr = ModuleData.ExecuteReader($"exec api_sp_RechercheTauxTVA {numAction}"))
      {
        //  gestion des cas
        //  si lieu execution et facturation identiques et en france alors 19.6 (ou 7.0 si site de particulier) '20 et 10 en 2014
        //  si lieu execution et facturation identiques et à l'etranger alors 0
        //  si lieu execution et facturation différents alors tva du pays d'exécution si N°TVA intra Emalec existe sur ce pays, sinon 0
        if (dr.Read())
        {
          if (dr["VSITPAYS"].ToString() == Utils.BlankIfNull(dr["VRSFPAYS"]) && dr["VSITPAYS"].ToString() == "FRANCE" && dr["CSITPART"].ToString() == "O")
            dRet = 10;
          if (dr["VSITPAYS"].ToString() == Utils.BlankIfNull(dr["VRSFPAYS"]) && dr["VSITPAYS"].ToString() == "FRANCE" && dr["CSITPART"].ToString() == "N")
            dRet = 20;
          if (dr["VSITPAYS"].ToString() == dr["VRSFPAYS"].ToString() && dr["VSITPAYS"].ToString() != "FRANCE" && dr["VSITPAYS"].ToString() != "ESPAGNE")
            dRet = 0;
          if (dr["VSITPAYS"].ToString() == dr["VRSFPAYS"].ToString() && dr["VSITPAYS"].ToString() == "ESPAGNE")
            dRet = 21;
          if (dr["VSITPAYS"].ToString() != Utils.BlankIfNull(dr["VRSFPAYS"]) && dr["VPAYSNUMTVA"].ToString() != "")
            dRet = Convert.ToDouble(dr["NPAYSTVA"]);
        }
      }
      return dRet;
    }

    public static double GetTauxRFA(int p_NACTNUM)
    {
      double dRet = -2;
      try
      {
        using (SqlDataReader dr = ModuleData.ExecuteReader($"EXEC [api_sp_GetRFA_POURC] {p_NACTNUM}"))
        {
          while (dr.Read())
          {
            if (dr["NRFAPOURC"] == DBNull.Value)
              dRet = -2;
            else
              dRet = Convert.ToDouble(dr["NRFAPOURC"]);
          }
        }
      }
      catch (Exception ex)
      {
        MZUtils.displayError(MethodBase.GetCurrentMethod().Name, ex);
      }
      return dRet;
    }

    public static void RemplirCboContact(ComboBox combo, int iclient, int iNumAction)
    {
      try
      {
        DataTable dt = new DataTable();

        SqlDataAdapter da = new SqlDataAdapter($"api_sp_comboContactDevis_client {iclient}, {iNumAction}", MozartDatabase.cnxMozart);
        da.Fill(dt);


        DataRow row = dt.NewRow();
        row[0] = 0;
        row[1] = Resources.col_Site;
        dt.Rows.InsertAt(row, 0);

        combo.DataSource = dt;

        combo.ValueMember = "NCCLNUM";
        combo.DisplayMember = "VCCLNOM";
        combo.SelectedIndex = 0;
      }
      catch (Exception ex)
      {
        MZUtils.displayError(MethodBase.GetCurrentMethod().Name, ex);
      }
    }
  }
}
