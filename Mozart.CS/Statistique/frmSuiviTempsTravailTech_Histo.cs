using MozartLib;
using MozartNet;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace MozartCS
{
  public partial class frmSuiviTempsTravailTech_Histo : Form
  {

    string _VPERNOM;
    int _NPERNUM;
    int _NUM_SEM;

    public int NPERNUM
    {
      get => _NPERNUM;     
    }

    public frmSuiviTempsTravailTech_Histo(string P_VPERNOM, int P_NPERNUM, int P_NUM_SEM)
    {
      InitializeComponent();

      _VPERNOM = P_VPERNOM;
      _NPERNUM = P_NPERNUM;
      _NUM_SEM = P_NUM_SEM;

    }

    private void frmSuiviTempsTravailTech_Histo_Load(object sender, EventArgs e)
    {

      //maj label histo
      this.Text = $"Historique - {_VPERNOM} - Semaine N°{_NUM_SEM}";

      SqlCommand CmdSql = new SqlCommand("[api_sp_SuiviTempsTrajet_Get_All_Histo]", MozartDatabase.cnxMozart);
      CmdSql.CommandType = CommandType.StoredProcedure;
      SqlCommandBuilder.DeriveParameters(CmdSql);    // liste des paramètres

      //  liste des paramètres
      CmdSql.Parameters["@P_NPERNUM"].Value = _NPERNUM;
      CmdSql.Parameters["@P_NUM_SEM"].Value = _NUM_SEM;

      using (SqlDataReader reader = CmdSql.ExecuteReader())
      {
        if (reader.Read())
        {
          TxtHisto.Text = reader["VHISTO_ALL"].ToString();
        }
      }


    }

  }
}
