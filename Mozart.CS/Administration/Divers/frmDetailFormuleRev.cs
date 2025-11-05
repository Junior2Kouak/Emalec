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
  public partial class frmDetailFormuleRev : Form
  {

    public int _NIDFORMULE_REV;

    public frmDetailFormuleRev(int C_NIDFORMULE_REV)
    {
      InitializeComponent();

      _NIDFORMULE_REV = C_NIDFORMULE_REV;
    }

    private void frmDetailFormuleRev_Load(object sender, EventArgs e)
    {
      try
      {
        ModuleMain.Initboutons(this);
        if (_NIDFORMULE_REV > 0)
          OuvertureEnModification();
      }
      catch (Exception ex)
      {
        MZUtils.displayError(MethodBase.GetCurrentMethod().Name, ex);
      }
    }

    private void cmdFermer_Click(object sender, EventArgs e)
    {
      Dispose();
    }

    private void cmdValider_Click(object sender, EventArgs e)
    {
      if (Utils.BlankIfNull(txtFormule.Text) == "")
      {
        MessageBox.Show("Il faut saisir une formule de révision", Program.AppTitle, MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
        return;
      }

      SqlCommand cmd = new SqlCommand("[api_sp_FormuleRev_Save]", MozartDatabase.cnxMozart);
      cmd.CommandType = CommandType.StoredProcedure;
      SqlCommandBuilder.DeriveParameters(cmd);

      cmd.Parameters["@P_NIDFORMULE_REV"].Value = _NIDFORMULE_REV;
      cmd.Parameters["@P_VFORMULE_REV"].Value = txtFormule.Text;
      cmd.ExecuteNonQuery();
      _NIDFORMULE_REV = Convert.ToInt32(cmd.Parameters[0].Value);

      Dispose();
    }

    private void OuvertureEnModification()
    {
      using (SqlDataReader dr = ModuleData.ExecuteReader($"EXEC [api_sp_FormuleRev_Load] {_NIDFORMULE_REV}"))
      {
        if (dr.Read())
        {
          txtFormule.Text = dr["VFORMULE_REV"].ToString();
        }
        dr.Close();
      }
    }
  }
}