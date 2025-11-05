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
  public partial class frmPlan_Info_Utiles : Form
  {

    Int32 _NPERNUM;
    Int32 _NIDPER_RESTRI;

    public frmPlan_Info_Utiles(Int32 C_NPERNUM)
    {
      InitializeComponent();
      _NPERNUM = C_NPERNUM;
    }

    private void frmPlan_Info_Utiles_Load(object sender, EventArgs e)
    {
      ModuleMain.Initboutons(this);     
      LoadData();
      Txt_Info_Utiles.Focus();
    }

    private void LoadData()
    {
      SqlDataReader Dr = ModuleData.ExecuteReader($"EXEC [api_sp_Restrictions_Load] {_NPERNUM}, 1");
      if (Dr.HasRows)
      {
        while (Dr.Read())
        {
          _NIDPER_RESTRI = (Int32)Dr["NIDPER_RESTRI"];
          Txt_VPER_RESTRICTIONS.Text = Dr["VPER_RESTRICTIONS"].ToString();
          Txt_Info_Utiles.Text = Dr["VINFO_UTILE"].ToString();          
        }

      }
      Dr.Close();
    }

    private void cmdFermer_Click(object sender, EventArgs e)
    {
      Close();
    }

    private void cmdValider_Click(object sender, EventArgs e)
    {
      SqlCommand sql_Save = new SqlCommand("[api_sp_Restrictions_Info_Util_Save]", MozartDatabase.cnxMozart);
      sql_Save.CommandType = CommandType.StoredProcedure;

      SqlCommandBuilder.DeriveParameters(sql_Save);
      sql_Save.Parameters["@P_NIDPER_RESTRI"].Value = _NIDPER_RESTRI;
      sql_Save.Parameters["@P_NPERNUM"].Value = _NPERNUM;
      sql_Save.Parameters["@P_VPER_VINFO_UTILE"].Value = Txt_Info_Utiles.Text;

      sql_Save.ExecuteNonQuery();

      LoadData();
    }

    private void Txt_Info_Utiles_Click(object sender, EventArgs e)
    {
      Txt_Info_Utiles.Text = $"{MozartParams.strUID} le {DateTime.Now.ToShortDateString()} : " + Environment.NewLine + Txt_Info_Utiles.Text;
      Txt_Info_Utiles.SelectionStart = ($"{MozartParams.strUID} le {DateTime.Now.ToShortDateString()} : ").Length;
    }
  }
}
