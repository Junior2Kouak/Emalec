using DevExpress.XtraEditors;
using MozartCS.Properties;
using MozartLib;
using MozartNet;
using MozartUC;
using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Reflection;
using System.Windows.Forms;
using MZUtils = MozartControls.Utils;

namespace MozartCS
{
  public partial class frmDuplicateActMens : Form
  {
    private int iNACTNUM;

    public frmDuplicateActMens(int pNACTNUM)
    {
      InitializeComponent();

      iNACTNUM = pNACTNUM;
    }

    private void frmDuplicateActMens_Load(object sender, EventArgs e)
    {
      try
      {
        Cursor.Current = Cursors.WaitCursor;
        ModuleMain.Initboutons(this);
      }
      catch (Exception ex)
      {
        MZUtils.displayError(MethodBase.GetCurrentMethod().Name, ex);
      }
      finally { Cursor.Current = Cursors.Default; }
    }

    private void cmdValider_Click(object sender, EventArgs e)
    {
      int lCount = Frame1.Controls.OfType<CheckBox>().Where(x => x.Checked).Count();
      if (lCount == 0)
      {
        MessageBox.Show(Resources.selectAtLeastAMonth, Program.AppTitle, MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
        return;
      }

      lCount = 0;
      List<string> lDates = new List<string>();
      apiCheckBox[] lCheckBoxes = { ChkMois0, ChkMois1, ChkMois2, ChkMois3, ChkMois4, ChkMois5, ChkMois6, ChkMois7, ChkMois8, ChkMois9, ChkMois10, ChkMois11 };
      DateEdit[] lDateEdits = { dateEdit0, dateEdit1, dateEdit2, dateEdit3, dateEdit4, dateEdit5, dateEdit6, dateEdit7, dateEdit8, dateEdit9, dateEdit10, dateEdit11 };
      for (int i = 0; i < 12; i++)
      {
        if (lCheckBoxes[i].Checked)
        {
          if (lDateEdits[i].EditValue == null)
          {
            MessageBox.Show(String.Format(Resources.selectDateForMonth, lCheckBoxes[i].Text),
                          Program.AppTitle, MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
            return;
          }

          lDates.Add(((DateTime)lDateEdits[i].EditValue).ToShortDateString());
          lCount++;
        }
      }

      if (MessageBox.Show($"{Resources.msg_nbActionJoursOuvre} : {lCount}{Environment.NewLine}{Resources.msg_vraimentCreer}{Environment.NewLine}{Resources.msg_verifInfoAction}",
                            Program.AppTitle, MessageBoxButtons.YesNo, MessageBoxIcon.Question, MessageBoxDefaultButton.Button2) != DialogResult.Yes)
      {
        return;
      }

      // si tout est ok, on lance la proc qui va dupliquer les actions
      using (SqlCommand cmd = new SqlCommand("[api_sp_CreationActionByMonth]", MozartDatabase.cnxMozart))
      {
        cmd.CommandType = CommandType.StoredProcedure;
        SqlCommandBuilder.DeriveParameters(cmd);    // liste des paramètres

        //  liste des paramètres
        cmd.Parameters["@P_NACTNUM"].Value = iNACTNUM;
        cmd.Parameters["@P_DATES"].Value = string.Join("|", lDates);

        cmd.ExecuteNonQuery();

        MessageBox.Show("Les actions ont été créées avec succès", Program.AppTitle, MessageBoxButtons.OK, MessageBoxIcon.Information);
      }
    }

    private void ChkMois_CheckedChanged(object sender, EventArgs e)
    {
      CheckBox checkBox = sender as CheckBox;

      (Frame1.Controls.OfType<DateEdit>().Where(x => x.Name == "dateEdit" + checkBox.Tag).FirstOrDefault() as DateEdit).Visible = checkBox.Checked;
    }
  }
}

