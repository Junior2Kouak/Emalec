using MozartLib;
using MozartNet;
using System;
using System.Data;
using System.Data.SqlClient;
using System.Windows.Forms;

namespace MozartCS
{
  public partial class frmKPIDefaultValues : Form
  {
    public frmKPIDefaultValues()
    {
      InitializeComponent();
    }

    private void frmKPIDefaultValues_Load(object sender, EventArgs e)
    {
      ModuleMain.Initboutons(this);

      initValues();
    }

    private void initValues()
    {
      using (SqlCommand cmd = new SqlCommand("SELECT * FROM TDELAICONT_DEFAULTVALUES", MozartDatabase.cnxMozart))
      {
        cmd.CommandType = CommandType.Text;

        SqlDataReader sdr = cmd.ExecuteReader();
        if (sdr.HasRows)
        {
          sdr.Read();

          txtDelaiDepAst.EditValue = Utils.ZeroIfNull(sdr["NDEPAST"]);
          txtObjDepAst.EditValue = Utils.ZeroIfNull(sdr["TXDEPAST"]);
          txtDelaiDepRap.EditValue = Utils.ZeroIfNull(sdr["NDEPRAP"]);
          txtObjDepRap.EditValue = Utils.ZeroIfNull(sdr["TXDEPRAP"]);
          txtDelaiDepMoy.EditValue = Utils.ZeroIfNull(sdr["NDEPMOY"]);
          txtObjDepMoy.EditValue = Utils.ZeroIfNull(sdr["TXDEPMOY"]);
          txtDelaiDepLen.EditValue = Utils.ZeroIfNull(sdr["NDEPLEN"]);
          txtObjDepLen.EditValue = Utils.ZeroIfNull(sdr["TXDEPLEN"]);
          txtDelaiDevis.EditValue = Utils.ZeroIfNull(sdr["NTRANSDEVIS"]);
          txtDelaiTrvx.EditValue = Utils.ZeroIfNull(sdr["NREALTRVX"]);
          txtObjTrvx.EditValue = Utils.ZeroIfNull(sdr["TXREALTRVX"]);
          txtDelaiReso.EditValue = Utils.ZeroIfNull(sdr["NRESOCMDE"]);
          txtObjPrev.EditValue = Utils.ZeroIfNull(sdr["NRESPPLANMAINT"]);
          txtObjEnqQual.EditValue = Utils.ZeroIfNull(sdr["TXENQQUAL"]);
        }

        sdr.Close();
      }
    }

    private void cmdEnreg_Click(object sender, EventArgs e)
    {
      string lSql = "UPDATE TDELAICONT_DEFAULTVALUES SET ";
      lSql += $"NDEPAST = @txtDelaiDepAst, TXDEPAST = @txtObjDepAst, NDEPRAP = @txtDelaiDepRap,";
      lSql += $"TXDEPRAP = @txtObjDepRap, NDEPMOY = @txtDelaiDepMoy, TXDEPMOY = @txtObjDepMoy,";
      lSql += $"NDEPLEN = @txtDelaiDepLen, TXDEPLEN = @txtObjDepLen, NTRANSDEVIS = @txtDelaiDevis,";
      lSql += $"NREALTRVX = @txtDelaiTrvx, NRESOCMDE = @txtDelaiReso, NRESPPLANMAINT = @txtObjPrev,";
      lSql += $"TXREALTRVX = @txtObjTrvx, TXENQQUAL = @txtObjEnqQual, ";
      lSql += $"NQUI = {MozartParams.UID},";
      lSql += $"DDATEMODIF = GETDATE()";

      using (SqlCommand cmd = new SqlCommand(lSql, MozartDatabase.cnxMozart))
      {
        cmd.Parameters.AddWithValue("@txtDelaiDepAst", txtDelaiDepAst.EditValue);
        cmd.Parameters.AddWithValue("@txtObjDepAst", txtObjDepAst.EditValue);
        cmd.Parameters.AddWithValue("@txtDelaiDepRap", txtDelaiDepRap.EditValue);
        cmd.Parameters.AddWithValue("@txtObjDepRap", txtObjDepRap.EditValue);
        cmd.Parameters.AddWithValue("@txtDelaiDepMoy", txtDelaiDepMoy.EditValue);
        cmd.Parameters.AddWithValue("@txtObjDepMoy", txtObjDepMoy.EditValue);
        cmd.Parameters.AddWithValue("@txtDelaiDepLen", txtDelaiDepLen.EditValue);
        cmd.Parameters.AddWithValue("@txtObjDepLen", txtObjDepLen.EditValue);
        cmd.Parameters.AddWithValue("@txtDelaiDevis", txtDelaiDevis.EditValue);
        cmd.Parameters.AddWithValue("@txtDelaiTrvx", txtDelaiTrvx.EditValue);
        cmd.Parameters.AddWithValue("@txtDelaiReso", txtDelaiReso.EditValue);
        cmd.Parameters.AddWithValue("@txtObjPrev", txtObjPrev.EditValue);
        cmd.Parameters.AddWithValue("@txtObjTrvx", txtObjTrvx.EditValue);
        cmd.Parameters.AddWithValue("@txtObjEnqQual", txtObjEnqQual.EditValue);

        cmd.ExecuteNonQuery();
      }
    }
  }
}
