using MozartCS.Properties;
using MozartLib;
using MozartNet;
using MozartUC;
using System;
using System.Data;
using System.Data.SqlClient;
using System.Reflection;
using System.Windows.Forms;
using MZUtils = MozartControls.Utils;

namespace MozartCS
{
  public partial class frmChoixPeriodeDuplicateAct : Form
  {
    private string sDateDebut = "";
    private int iNACTNUM;

    DateTime _curDate = DateTime.MinValue;

    public frmChoixPeriodeDuplicateAct(string pDateDebut, int pNACTNUM)
    {
      InitializeComponent();

      sDateDebut = pDateDebut;
      iNACTNUM = pNACTNUM;
    }

    private void frmChoixPeriodeDuplicateAct_Load(object sender, EventArgs e)
    {
      try
      {
        Cursor.Current = Cursors.WaitCursor;
        ModuleMain.Initboutons(this);

        txtDateA0.Text = sDateDebut;
        txtDateA1.Text = "";
      }
      catch (Exception ex)
      {
        MZUtils.displayError(MethodBase.GetCurrentMethod().Name, ex);
      }
      finally { Cursor.Current = Cursors.Default; }
    }

    private void cmdDatesAll_Click(object sender, EventArgs e)
    {
      Button btn = sender as Button;
      Calendar1.Tag = btn.Tag;

      DateTime d;

      if (DateTime.TryParse(txtDateA0.Text, out d) && Convert.ToInt32(btn.Tag) == 0) _curDate = Calendar1.Value = d;
      else if (DateTime.TryParse(txtDateA1.Text, out d) && Convert.ToInt32(btn.Tag) == 1) _curDate = Calendar1.Value = d;
      else { _curDate = DateTime.MinValue; Calendar1.Value = DateTime.Now; }
      Calendar1.Visible = true;
      Calendar1.ShowCalendar(new MouseEventArgs(MouseButtons.Left, 1, MousePosition.X - this.Location.X, MousePosition.Y - this.Location.Y, 0));
    }

    private void Calendar1_CloseUp(object sender, EventArgs e)
    {
      if (_curDate == DateTime.MinValue) { Calendar1.Visible = false; return; }

      if (Convert.ToInt32(Calendar1.Tag) == 0) txtDateA0.Text = Calendar1.Value.ToShortDateString();
      else if (Convert.ToInt32(Calendar1.Tag) == 1) txtDateA1.Text = Calendar1.Value.ToShortDateString();

      Calendar1.Visible = false;
    }

    private void Calendar1_ValueChanged(object sender, EventArgs e)
    {
      if (Calendar1.Visible) _curDate = Calendar1.Value;
    }

    private void cmdDateSuppAll_Click(object sender, EventArgs e)
    {
      Button btn = sender as Button;
      if (Convert.ToInt32(btn.Tag) == 0)
        txtDateA0.Text = "";
      else
        txtDateA1.Text = "";
    }

    private void cmdValider_Click(object sender, System.EventArgs e)
    {
      //test la date début existe
      if (txtDateA0.Text == "")
      {
        MessageBox.Show(Resources.msg_SaisirDateDeb, Program.AppTitle, MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
        return;
      }
      //test la date fin existe
      if (txtDateA1.Text == "")
      {
        MessageBox.Show(Resources.msg_SaisirDateFin, Program.AppTitle, MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
        return;
      }

      if (Convert.ToDateTime(txtDateA1.Text) < Convert.ToDateTime(txtDateA0.Text))
      {
        MessageBox.Show(Resources.msg_dateFinInfDateDeb, Program.AppTitle, MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
        return;
      }

      //test si la durée est indiquée sur le jour coché et le text est numérique
      CheckBox[] tCheckBox = { ChkJourSem0, ChkJourSem1, ChkJourSem2, ChkJourSem3, ChkJourSem4 };
      apiTextBox[] tApiTextBox = { TxtJourSemDuree0, TxtJourSemDuree1, TxtJourSemDuree2, TxtJourSemDuree3, TxtJourSemDuree4 };

      for (int iJour = 0; iJour <= 4; iJour++)
      {
        if (tCheckBox[iJour].Checked)
        {
          if (tApiTextBox[iJour].Text != "")
          {
            if (!Utils.IsNumeric(tApiTextBox[iJour].Text))
            {
              MessageBox.Show(Resources.msg_dureeSaisiePasNumerique, Program.AppTitle, MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
              return;
            }
          }
          else
          {
            MessageBox.Show(Resources.msg_dureePasSaisie, Program.AppTitle, MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
            return;
          }
        }
      }

      // on calcule le nb d'actions qui seront créer pour l'affiché dans un message a valider
      string sSQL = $"EXEC [api_sp_GetNbActionsCreateOnPeriod] '{txtDateA0.Text}', '{txtDateA1.Text}', " +
        $"{ChkJourSem0.Checked}, {ChkJourSem1.Checked}, {ChkJourSem2.Checked}, " +
        $"{ChkJourSem3.Checked}, {ChkJourSem4.Checked}";

      int jourOuvre = (int)ModuleData.ExecuteScalarInt(sSQL);

      if (jourOuvre > 0)
      {
        if (MessageBox.Show($"{Resources.msg_nbActionJoursOuvre} : {jourOuvre}\r\n{Resources.msg_vraimentCreer}\r\n{Resources.msg_verifInfoAction}", Program.AppTitle, MessageBoxButtons.YesNo, MessageBoxIcon.Question,
          MessageBoxDefaultButton.Button2) != DialogResult.Yes)
          return;
      }
      else
      {
        MessageBox.Show(Resources.msg_pasActionsurPeriode, Program.AppTitle, MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
        return;
      }

      // si tout est ok, on lance la proc qui va dupliquer les actions
      using (SqlCommand cmd = new SqlCommand("[api_sp_CreationActionByDay]", MozartDatabase.cnxMozart))
      {
        cmd.CommandType = CommandType.StoredProcedure;
        SqlCommandBuilder.DeriveParameters(cmd);    // liste des paramètres

        //  liste des paramètres
        cmd.Parameters["@P_NACTNUM"].Value = iNACTNUM;
        cmd.Parameters["@P_DATE_DEBUT"].Value = txtDateA0.Text;
        cmd.Parameters["@P_DATE_FIN"].Value = txtDateA1.Text;
        cmd.Parameters["@P_LUNDI"].Value = ChkJourSem0.Checked;
        cmd.Parameters["@P_LUNDI_DUREE"].Value = TxtJourSemDuree0.Text;
        cmd.Parameters["@P_MARDI"].Value = ChkJourSem1.Checked;
        cmd.Parameters["@P_MARDI_DUREE"].Value = TxtJourSemDuree1.Text;
        cmd.Parameters["@P_MERCREDI"].Value = ChkJourSem2.Checked;
        cmd.Parameters["@P_MERCREDI_DUREE"].Value = TxtJourSemDuree2.Text;
        cmd.Parameters["@P_JEUDI"].Value = ChkJourSem3.Checked;
        cmd.Parameters["@P_JEUDI_DUREE"].Value = TxtJourSemDuree3.Text;
        cmd.Parameters["@P_VENDREDI"].Value = ChkJourSem4.Checked;
        cmd.Parameters["@P_VENDREDI_DUREE"].Value = TxtJourSemDuree4.Text;

        cmd.ExecuteNonQuery();

        MessageBox.Show("Les actions ont été créées avec succès", Program.AppTitle, MessageBoxButtons.OK, MessageBoxIcon.Information);
      }
    }

    private void ChkJourSemALL_CheckedChanged(object sender, EventArgs e)
    {
      CheckBox checkBox = sender as CheckBox;

      switch (checkBox.Tag)
      {
        case "0":
          TxtJourSemDuree0.Visible = checkBox.Checked;
          break;
        case "1":
          TxtJourSemDuree1.Visible = checkBox.Checked;
          break;
        case "2":
          TxtJourSemDuree2.Visible = checkBox.Checked;
          break;
        case "3":
          TxtJourSemDuree3.Visible = checkBox.Checked;
          break;
        case "4":
          TxtJourSemDuree4.Visible = checkBox.Checked;
          break;
        default:
          break;
      }
    }
  }
}

