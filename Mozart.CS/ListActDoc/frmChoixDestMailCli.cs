using Microsoft.VisualBasic;
using MozartCS.Properties;
using MozartLib;
using MozartNet;
using System;
using System.Data.SqlClient;
using System.IO;
using System.Reflection;
using System.Windows.Forms;
using MZUtils = MozartControls.Utils;

namespace MozartCS
{
  public partial class frmChoixDestMailCli : Form
  {
    public string msNACTNUM;
    public string msPieceJointe;
    public string msNomFichier;

    public frmChoixDestMailCli() { InitializeComponent(); }

    private void frmChoixDestMailCli_Load(object sender, EventArgs e)
    {
      if (msNACTNUM != "")
      {
        using (SqlDataReader dr = ModuleData.ExecuteReader($"select distinct TCCL.VCCLMAIL From TCCL inner join TCLI on TCLI.NCLINUM = TCCL.NCLINUM " +
                                                           $"inner join TDIN on TDIN.NCLINUM = TCLI.NCLINUM inner join TACT on TACT.NDINNUM = TDIN.NDINNUM WHERE ccclactif = 'O' " +
                                                           $"AND VCCLMAIL like '%@%' AND TACT.NACTNUM = {msNACTNUM}"))
        {
          while (dr.Read())
            if (dr["VCCLMAIL"] != DBNull.Value && dr["VCCLMAIL"].ToString() != "")
              lstDest.Items.Add(dr["VCCLMAIL"].ToString() + " (Contact client)");

          dr.Close();
        }
      }
    }

    private void cmdValider_Click(object sender, EventArgs e)
    {
      bool bOK = false;
      string sListeDest = "";

      try
      {
        if (txtMessage.Text == "" || txtSujet.Text == "")
        {
          MessageBox.Show(Resources.msg_SubjectAndMessageRequired, Program.AppTitle, MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
          return;
        }

        foreach (string item in lstDest.CheckedItems)
        {
          bOK = true;
          sListeDest += item.Substring(0, item.IndexOf("(") - 1) + ";";
        }

        if (txtAdrMail.Text.IndexOf("@") > 0)
        {
          bOK = true;
          sListeDest += txtAdrMail.Text;
        }

        if (bOK == false)
          MessageBox.Show(Resources.msg_MustChooseDest, Program.AppTitle, MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
        else
        {
          string chemin_temp = "\\\\" + MozartParams.NomServeur + "\\PJMail\\" + msNomFichier;

          File.Copy(msPieceJointe, chemin_temp, overwrite: true);

          string sSQL = $"EXEC msdb..sp_send_dbmail @profile_name = 'Web{MozartParams.NomSociete}',";
          if ((MozartParams.NomSociete == "EMALEC" || MozartParams.NomSociete == "EMALECIDF"
            || MozartParams.NomSociete == "EMALECDEV") && MozartParams.UserMail != "")
          {
            //sSQL = sSQL & "@profile_name = '" & gintUID & "',"
            sSQL += $"@from_address = '{MozartParams.UserMail}',";
            //sSql = sSql & "@profile_name = '" & gintUID & "',"
          }
          //else
          //  sSql = sSql & "@profile_name = 'Web" & gstrNomSociete & "', "

          sSQL += $"@recipients = '{Strings.Trim(sListeDest)}'," +
                  $"@body = '{Strings.Replace(txtMessage.Text, "'", "''")}'," +
                  $"@subject = '{Strings.Replace(txtSujet.Text, "'", "''")}'," +
                  $"@file_attachments = '{Strings.Replace(chemin_temp, "'", "''")}'," +
                  $"@blind_copy_recipients ='info@emalec.com'";
          using (var cmd = new SqlCommand(sSQL, MozartDatabase.cnxMozart))
            cmd.ExecuteNonQuery();

          //update dans tactobs
          sSQL = $"UPDATE TACT SET VACTOBS = CONVERT(VARCHAR(5), GETDATE(),103) + ' : Mail avec {msNomFichier} envoyé à {Strings.Trim(sListeDest)} par {MozartParams.UserMail}' + CHAR(13) + CHAR(10) + ISNULL(VACTOBS, '') WHERE TACT.NACTNUM={msNACTNUM}";
          using (var cmd = new SqlCommand(sSQL, MozartDatabase.cnxMozart))
            cmd.ExecuteNonQuery();

          MessageBox.Show("Message envoyé avec succès", "Confirmation", MessageBoxButtons.OK, MessageBoxIcon.Information);

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

    private void cmdCocher_Click(object sender, EventArgs e)
    {
      // Cocher toutes les lignes
      for (int i = 0; i < lstDest.Items.Count; i++)
        lstDest.SetItemChecked(i, true);
    }

    private void cmdDecocher_Click(object sender, EventArgs e)
    {
      // Décocher toutes les lignes
      for (int i = 0; i < lstDest.Items.Count; i++)
        lstDest.SetItemChecked(i, false);
    }

    private void txtAdrMail_Enter(object sender, EventArgs e)
    {
      if (txtAdrMail.Text == Resources.txt_ClickHereForAddr)
        txtAdrMail.Text = "";
    }
  }
}