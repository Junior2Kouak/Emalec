using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.SqlClient;
using System.Data;
using MozartNet;
using MozartLib;

namespace MozartCS
{
  class CACT_LOG_ETAT
  {

    public static DataTable dtAct_Log_Etat;

    public CACT_LOG_ETAT(Int32 p_NACTNUM)
    {

      dtAct_Log_Etat = new DataTable();

      SqlCommand sqlcmd = new SqlCommand("[api_sp_ListeActLogEtat]", MozartDatabase.cnxMozart);
      sqlcmd.CommandType = CommandType.StoredProcedure;
      SqlCommandBuilder.DeriveParameters(sqlcmd);    // liste des paramètres
      sqlcmd.Parameters["@P_NACTNUM"].Value = p_NACTNUM;
      dtAct_Log_Etat.Load(sqlcmd.ExecuteReader());

    }

    public static void AddLog(CACT_LOG_ETAT_DETAIL p_newlog)
    {

      if (dtAct_Log_Etat == null) return;

      DataRow dr_new = dtAct_Log_Etat.NewRow();

      dr_new["NID_ACT_LOG_ETAT"] = p_newlog.NID_ACT_LOG_ETAT;
      dr_new["NACTNUM"] = p_newlog.NACTNUM;
      dr_new["NQUICREE"] = p_newlog.NQUICREE;
      dr_new["DQUICREE"] = p_newlog.DQUICREE;
      dr_new["CETACOD"] = p_newlog.CETACOD;

      dtAct_Log_Etat.Rows.Add(dr_new);
    }

    public static void Save()
    {

      foreach(DataRow drsave in dtAct_Log_Etat.Rows)
      {
        SqlCommand sqlcmd = new SqlCommand("", MozartDatabase.cnxMozart);
        sqlcmd.CommandType = CommandType.StoredProcedure;
        SqlCommandBuilder.DeriveParameters(sqlcmd);    // liste des paramètres
        sqlcmd.Parameters[""].Value = 0;
        sqlcmd.Parameters[""].Value = 0;
        sqlcmd.Parameters[""].Value = 0;
        sqlcmd.Parameters[""].Value = 0;
        sqlcmd.Parameters[""].Value = 0;
        sqlcmd.ExecuteReader();
      }

    }

    public static void Get1StDate()
    {

    }

    public static void GetLastDate()
    {

    }


    //  public static int GetItemData(this ComboBox cbo)
    //{
    //  if (cbo.SelectedItem.GetType() == typeof(ModuleData.ListItem))
    //    return Convert.ToInt32(((ModuleData.ListItem)cbo.SelectedItem).ItemData);
    //  else
    //    return Convert.ToInt32(((DataRowView)cbo.SelectedItem).Row.ItemArray[0]);
    //}


  }
  class CACT_LOG_ETAT_DETAIL
  {
    public Int32 NID_ACT_LOG_ETAT;
    public Int32 NACTNUM;   
    public Int32 NQUICREE;
    public DateTime DQUICREE;
    public string VQUICREE;
    public string CETACOD;

  }
}
