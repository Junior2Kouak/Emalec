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
  public partial class frmStockSaisieInventaire : Form
  {
    //Public NFOUNUM As Long
    public long mlNFOUNUM;
    private double prix = 0;

    public frmStockSaisieInventaire()
    {
      InitializeComponent();
    }

    private void frmStockSasieInventaire_Load(object sender, EventArgs e)
    {
      try
      {
        ModuleMain.Initboutons(this);

        using (SqlDataReader dr = ModuleData.ExecuteReader("exec api_sp_InfoStockInv " + mlNFOUNUM.ToString()))
        {
          if (dr.Read())
          {
            lblFoumat.Text = Utils.BlankIfNull(dr["VFOUMAT"]);
            txtQteInv.Text = dr["INV"] != DBNull.Value ? dr["INV"].ToString() : "";
            txtDateInv.Text = dr["DINV"] != DBNull.Value ? Convert.ToDateTime(dr["DINV"]).ToShortDateString() : "";
            prix = Convert.ToDouble(dr["PRIX"]);
          }
          dr.Close();
        }
        Cursor.Current = Cursors.Default;
      }
      catch (Exception ex)
      {
        MZUtils.displayError(MethodBase.GetCurrentMethod().Name, ex);
      }
    }

    private void cmdValider_Click(object sender, EventArgs e)
    {
      try
      {
        if (MessageBox.Show(Resources.msg_confirm_saisie_inventaire, Program.AppTitle, MessageBoxButtons.YesNo, MessageBoxIcon.Question,
         MessageBoxDefaultButton.Button2) == DialogResult.Yes)
        {
          // Création d'une commande
          using (SqlCommand cmd = new SqlCommand("api_sp_MAJ_StockArticle", MozartDatabase.cnxMozart))
          {
            cmd.CommandType = CommandType.StoredProcedure;
            SqlCommandBuilder.DeriveParameters(cmd);

            cmd.Parameters["@FouNum"].Value = mlNFOUNUM;
            cmd.Parameters["@Qte"].Value = txtQte.Text != "" ? txtQte.Text : null;
            cmd.Parameters["@Prix"].Value = prix;
            cmd.Parameters["@DateEntree"].Value = DateTime.Now.ToShortDateString();
            cmd.ExecuteNonQuery();
          }
          Dispose();
        }
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

    private void txtQteInv_KeyPress(object sender, KeyPressEventArgs e)
    {
      if (e.KeyChar == 13)
        cmdValider_Click(sender, e);

      KeyValidator.KeyPress_SaisieNombre(e);
    }
  }
}
