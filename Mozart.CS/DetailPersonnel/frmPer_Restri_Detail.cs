using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using MozartNet;
using System.Data.SqlClient;
using MozartLib;

namespace MozartCS.DetailPersonnel
{
  public partial class frmPer_Restri_Detail : Form
  {

    Int32 _NPERNUM;
    Int32 _NIDPER_RESTRI = 0;
    public frmPer_Restri_Detail(Int32 C_NPERNUM)
    {
      InitializeComponent();
      _NPERNUM = C_NPERNUM;
    }    
      
    private void frmPer_Restri_Detail_Load(object sender, EventArgs e)
    {
      ModuleMain.Initboutons(this);

      LoadData();     
    }

    private void Btn_Tooltip_Click(object sender, EventArgs e)
    {
      MessageBox.Show($"Nous entendons par restrictions les contraintes que nous devons respecter sur avis médical. Aucune donnée de santé ne doit être inscrite ici mais plutôt les conséquences : Pas de travail en hauteur, 100km max, pas d’environnement poussiéreux, etc…", "Informations", MessageBoxButtons.OK, MessageBoxIcon.Information);
    }


    private void LoadData()
    {
      SqlDataReader Dr = ModuleData.ExecuteReader($"EXEC [api_sp_Restrictions_Load] {_NPERNUM}");
      if (Dr.HasRows)
      {
        while (Dr.Read())
        {
          _NIDPER_RESTRI = (Int32)Dr["NIDPER_RESTRI"];
          Txt_VPER_RESTRICTIONS.Text = Dr["VPER_RESTRICTIONS"].ToString();

        }

      }
      Dr.Close();
    }

    private void cmdValider_Click(object sender, EventArgs e)
    {

      SqlCommand sql_Save = new SqlCommand("[api_sp_Restrictions_Save]", MozartDatabase.cnxMozart);
      sql_Save.CommandType = CommandType.StoredProcedure;

      SqlCommandBuilder.DeriveParameters(sql_Save);
      sql_Save.Parameters["@P_NIDPER_RESTRI"].Value = _NIDPER_RESTRI;
      sql_Save.Parameters["@P_NPERNUM"].Value = _NPERNUM;
      sql_Save.Parameters["@P_VPER_RESTRICTIONS"].Value = Txt_VPER_RESTRICTIONS.Text;

      sql_Save.ExecuteNonQuery();

      LoadData();

    }

    private void cmdFermer_Click(object sender, EventArgs e)
    {
      Close();
    }
    private void Txt_VPER_RESTRICTIONS_Click(object sender, EventArgs e)
    {
      Txt_VPER_RESTRICTIONS.Text = $"{MozartParams.strUID} le {DateTime.Now.ToShortDateString()} : " + Environment.NewLine + Txt_VPER_RESTRICTIONS.Text;
      Txt_VPER_RESTRICTIONS.SelectionStart = ($"{MozartParams.strUID} le {DateTime.Now.ToShortDateString()} : ").Length;
    }
       
  }
}
