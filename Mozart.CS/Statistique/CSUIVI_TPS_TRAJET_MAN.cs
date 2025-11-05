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
  class CSUIVI_TPS_TRAJET_MAN
  {

    int _NID_SUIVI_TPS_TRAJET_MAN;
    int _NID_SUIVI_TPS_TRAJET;
    //int _NMINUTE_MAN;
    //int _NHEURE_MAN;
    string _VOBS_MAN;
    int _NQUIMODIF;
    DateTime _DQUIMODIF;
    int _N_TOT_SEC_MAN;
    string _VFIELDNAME;
    string _VHISTO;
    int _NSECONDES_MOZARIS;
    string _sColText;
    int _NUM_SEMAINE_ISO;
    int _NUM_YEAR;
    int _NPERNUM;

    public int NID_SUIVI_TPS_TRAJET_MAN
    {
      get => _NID_SUIVI_TPS_TRAJET_MAN;
      set
      {
        _NID_SUIVI_TPS_TRAJET_MAN = value;
      }
    }

    public int NID_SUIVI_TPS_TRAJET
    {
      get => _NID_SUIVI_TPS_TRAJET;
      set
      {
        _NID_SUIVI_TPS_TRAJET = value;
      }
    }
    public decimal NMINUTE_MAN
    {
      get => Math.Truncate((decimal)TimeSpan.FromSeconds(_N_TOT_SEC_MAN).Minutes);     
    }
    public decimal NHEURE_MAN
    {
      get => Math.Truncate((decimal)TimeSpan.FromSeconds(_N_TOT_SEC_MAN).TotalHours);     
    }
    public string VOBS_MAN
    {
      get => _VOBS_MAN;
      set
      {
        _VOBS_MAN = value;
      }
    }

    public int NQUIMODIF
    {
      get => _NQUIMODIF;
      set
      {
        _NQUIMODIF = value;
      }
    }

    public DateTime DQUIMODIF
    {
      get => _DQUIMODIF;
      set
      {
        _DQUIMODIF = value;
      }
    }

    public int N_TOT_SEC_MAN
    {
      get => _N_TOT_SEC_MAN;
      set
      {
        _N_TOT_SEC_MAN = value;
      }
    }
    public string VFIELDNAME
    {
      get => _VFIELDNAME;
      set
      {
        _VFIELDNAME = value;
      }
    }
    public string VHISTO
    {
      get => _VHISTO;
      set
      {
        _VHISTO = value;
      }
    }
    public decimal NMINUTE_MOZARIS
    {
      get => Math.Truncate((decimal)TimeSpan.FromSeconds(_NSECONDES_MOZARIS).Minutes);
    }
    public decimal NHEURE_MOZARIS
    {
      get => Math.Truncate((decimal)TimeSpan.FromSeconds(_NSECONDES_MOZARIS).TotalHours);
    }
    public string sColText
    {
      get => _sColText;
      set
      {
        _sColText = value;
      }
    }

    public int NUM_SEMAINE_ISO
    {
      get => _NUM_SEMAINE_ISO;
      set
      {
        _NUM_SEMAINE_ISO = value;
      }
    }

    public int NUM_YEAR
    {
      get => _NUM_YEAR;
      set
      {
        _NUM_YEAR = value;
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

    public CSUIVI_TPS_TRAJET_MAN(int P_NID_SUIVI_TPS_TRAJET, string P_VFIELDNAME, int P_NSECONDES_MOZARIS, string P_sColText, int p_NUM_SEMAINE_ISO, int p_NUM_YEAR, int p_NPERNUM)
    {

      _NID_SUIVI_TPS_TRAJET = P_NID_SUIVI_TPS_TRAJET;
      _VFIELDNAME = P_VFIELDNAME;
      _NSECONDES_MOZARIS = P_NSECONDES_MOZARIS;
      _sColText = P_sColText;
      _NUM_SEMAINE_ISO = p_NUM_SEMAINE_ISO;
      _NUM_YEAR = p_NUM_YEAR;
      _NPERNUM = p_NPERNUM;
      LoadData();
    }

    public void LoadData()
    {

      using (SqlDataReader sdr = ModuleData.ExecuteReader($"exec [api_sp_Suivi_Tps_Trajet_Man_Detail] '{_VFIELDNAME}', {NID_SUIVI_TPS_TRAJET}"))
      {
        if (sdr.Read())
        {
          _NID_SUIVI_TPS_TRAJET_MAN = (int)Utils.ZeroIfBlank(sdr["NID_SUIVI_TPS_TRAJET_MAN"]);
          _NID_SUIVI_TPS_TRAJET = (int)Utils.ZeroIfBlank(sdr["NID_SUIVI_TPS_TRAJET"]);
          _VOBS_MAN = (string)Utils.BlankIfNull(sdr["VOBS_MAN"]);
          _NQUIMODIF = (int)Utils.ZeroIfBlank(sdr["NQUIMODIF"]);
          _DQUIMODIF = (DateTime)sdr["DQUIMODIF"];
          _N_TOT_SEC_MAN = (int)Utils.ZeroIfBlank(sdr["N_TOT_SEC_MAN"]);
          _VFIELDNAME = (string)Utils.BlankIfNull(sdr["VFIELDNAME"]);
          _VHISTO = (string)Utils.BlankIfNull(sdr["VHISTO"]);
          //_NUM_SEMAINE = (int)Utils.ZeroIfNull(sdr["NUM_SEMAINE"]);
          //_NUM_YEAR = (int)Utils.ZeroIfNull(sdr["NUM_YEAR"]);
          //_NPERNUM = (int)Utils.ZeroIfNull(sdr["NPERNUM"]);

        }
      }

    }
    public void Save()
    {

      using (SqlCommand cmd = new SqlCommand("[api_sp_Suivi_Tps_Trajet_Man_Save]", MozartDatabase.cnxMozart))
      {
        cmd.CommandType = CommandType.StoredProcedure;
        SqlCommandBuilder.DeriveParameters(cmd);    // liste des paramètres

        //  liste des paramètres
        cmd.Parameters["@P_NID_SUIVI_TPS_TRAJET_MAN"].Value = _NID_SUIVI_TPS_TRAJET_MAN;
        cmd.Parameters["@P_VFIELDNAME"].Value = _VFIELDNAME;
        cmd.Parameters["@P_NID_SUIVI_TPS_TRAJET"].Value = _NID_SUIVI_TPS_TRAJET;
        cmd.Parameters["@P_VOBS_MAN"].Value = _VOBS_MAN;
        cmd.Parameters["@P_N_TOT_SEC_MAN"].Value = _N_TOT_SEC_MAN;
        cmd.Parameters["@P_N_TOT_SEC_MOZARIS"].Value = _NSECONDES_MOZARIS;
        cmd.Parameters["@P_NOMCOLONNE"].Value = sColText;
        cmd.Parameters["@P_NUM_SEMAINE_ISO"].Value = _NUM_SEMAINE_ISO;
        cmd.Parameters["@P_NANNEE"].Value = _NUM_YEAR;
        cmd.Parameters["@P_NPERNUM"].Value = _NPERNUM;


        cmd.ExecuteNonQuery();
        _NID_SUIVI_TPS_TRAJET_MAN = (int)cmd.Parameters["@P_NID_SUIVI_TPS_TRAJET_MAN"].Value;
      }

    }

  }

}
