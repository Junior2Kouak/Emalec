using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.SqlClient;
using MozartNet;
using System.Data;
using MozartLib;


namespace MozartCS
{
  class CTPS_RECUP_TECH
  {

    int _NTPS_RECUP_ID;
    int _NPERNUM;
    DateTime? _DATE_AJOUT_VISA;
    int _NQUI_AJOUT_VISA;
    int? _NSOLDE_SEC_BASE;

    string _VQUI_AJOUT_VISA;
    string _VTECHNOM;

    public int NTPS_RECUP_ID
    {
      get => _NTPS_RECUP_ID;
      set
      {
        _NTPS_RECUP_ID = value;
      }
    }
    public int NPERNUM
    {
      get => _NPERNUM;
      set
      {
        _NPERNUM = value;
      }
    }
    public DateTime? DATE_AJOUT_VISA
    {
      get => _DATE_AJOUT_VISA;
      set
      {
        _DATE_AJOUT_VISA = value;
      }
    }
    public int NQUI_AJOUT_VISA
    {
      get => _NQUI_AJOUT_VISA;
      set
      {
        _NQUI_AJOUT_VISA = value;
      }
    }
    public int? NSOLDE_SEC_BASE
    {
      get => _NSOLDE_SEC_BASE;
      set
      {
        _NSOLDE_SEC_BASE = value;
      }
    }
    public string VQUI_AJOUT_VISA
    {
      get => _VQUI_AJOUT_VISA;
      set
      {
        _VQUI_AJOUT_VISA = value;
      }
    }
    public string VTECHNOM
    {
      get => _VTECHNOM;
      set
      {
        _VTECHNOM = value;
      }
    }

    public CTPS_RECUP_TECH(int P_NTPS_RECUP_ID)
    {
      _NTPS_RECUP_ID = P_NTPS_RECUP_ID;   
      LoadData();
    }

    public void LoadData()
    {

      if(_NTPS_RECUP_ID != 0)
      {
        using (SqlDataReader sdr = ModuleData.ExecuteReader($"exec [api_sp_Temps_Recup_LoadInfo] {_NTPS_RECUP_ID}"))
        {
          if (sdr.Read())
          {
            _NTPS_RECUP_ID = (int)Utils.ZeroIfBlank(sdr["NTPS_RECUP_ID"]);
            _NPERNUM = (int)Utils.ZeroIfBlank(sdr["NPERNUM"]);
            _DATE_AJOUT_VISA = (DateTime?)sdr["DATE_AJOUT_VISA"];
            _NQUI_AJOUT_VISA = (int)Utils.ZeroIfBlank(sdr["NQUI_AJOUT_VISA"]);
            _NSOLDE_SEC_BASE = (int?)Utils.ZeroIfBlank(sdr["NSOLDE_SEC_BASE"]);
            _VQUI_AJOUT_VISA = (string)Utils.BlankIfNull(sdr["VQUI_AJOUT_VISA"]);
            _VTECHNOM = (string)Utils.BlankIfNull(sdr["VTECHNOM"]);

          }
        }
      }     
      else
      {

        _NTPS_RECUP_ID = 0;
        _NPERNUM = 0;
        _DATE_AJOUT_VISA = null;
        _NQUI_AJOUT_VISA = 0;
        _NSOLDE_SEC_BASE = null;
        _VQUI_AJOUT_VISA = "";
        _VTECHNOM = "";

      }

    }
    public void Save()
    {

      using (SqlCommand cmd = new SqlCommand("[api_sp_Temps_Recup_Save]", MozartDatabase.cnxMozart))
      {
        cmd.CommandType = CommandType.StoredProcedure;
        SqlCommandBuilder.DeriveParameters(cmd);    // liste des paramètres

        //  liste des paramètres
        cmd.Parameters["@P_NTPS_RECUP_ID"].Value = _NTPS_RECUP_ID;
        cmd.Parameters["@P_NPERNUM"].Value = _NPERNUM;
        cmd.Parameters["@P_NSOLDE_SEC_BASE"].Value = _NSOLDE_SEC_BASE;
       
        cmd.ExecuteNonQuery();
        _NTPS_RECUP_ID = (int)cmd.Parameters["@P_NTPS_RECUP_ID"].Value;
      }

    }

    public void Delete()
    {

      using (SqlCommand cmd = new SqlCommand("[api_sp_Temps_Recup_Delete]", MozartDatabase.cnxMozart))
      {
        cmd.CommandType = CommandType.StoredProcedure;
        SqlCommandBuilder.DeriveParameters(cmd);    // liste des paramètres

        //  liste des paramètres
        cmd.Parameters["@P_NTPS_RECUP_ID"].Value = _NTPS_RECUP_ID;

        cmd.ExecuteNonQuery();
        //_NTPS_RECUP_ID = (int)cmd.Parameters["@P_NTPS_RECUP_ID"].Value;
      }

    }

  }
}
