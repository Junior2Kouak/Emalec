using MozartCS.Properties;
using MozartLib;
using MozartNet;
using ReportEmalec.Net;
using System;
using System.Data;
using System.Data.SqlClient;
using System.Reflection;
using System.Windows.Forms;
using MZUtils = MozartControls.Utils;


namespace MozartCS
{
  public partial class frmDetailPPS : Form
  {
    public int NINTNUM;
    public int NACTNUM;
    public int NIDPPS;

    DateTime _curDate;


    public frmDetailPPS() { InitializeComponent(); }


    private void frmDetailPPS_Load(object sender, System.EventArgs e)
    {
      try
      {
        Cursor.Current = Cursors.WaitCursor;
        ModuleMain.Initboutons(this);

        LoadData();
      }
      catch (Exception ex)
      {
        MZUtils.displayError(MethodBase.GetCurrentMethod().Name, ex);
      }
      finally { Cursor.Current = Cursors.Default; }
    }

    private void cmdFermer_Click(object sender, System.EventArgs e)
    {
      Dispose();
    }

    private void LoadData()
    {

      try
      {
        //recherche des infos du devis (que le devis existe ou pas)
        using (SqlDataReader sdrD = ModuleData.ExecuteReader($"exec [api_sp_PPS_Detail] {NIDPPS}, {NINTNUM}, {NACTNUM}"))
        {
          if (sdrD.Read())
          {
            txtFields0.Text = Utils.BlankIfNull(sdrD["VCLINOM"]);
            txtFields1.Text = Utils.BlankIfNull(sdrD["VSITNOM"]);
            txtFields2.Text = Utils.BlankIfNull(sdrD["NSITNUE"]);
            txtFields4.Text = Utils.BlankIfNull(sdrD["VSITAD1"]);
            txtFields5.Text = Utils.BlankIfNull(sdrD["VSITAD2"]);
            txtFields6.Text = Utils.BlankIfNull(sdrD["VSITCP"]);
            txtFields7.Text = Utils.BlankIfNull(sdrD["VSITVIL"]);
            txtFields8.Text = Utils.BlankIfNull(sdrD["VSITTEL"]);
            txtFields9.Text = Utils.BlankIfNull(sdrD["VSITFAX"]);
            txtFields10.Text = Utils.BlankIfNull(sdrD["VSTFNOM"]);
            txtFields11.Text = Utils.BlankIfNull(sdrD["VINTNOM"]);
            txtFields12.Text = Utils.BlankIfNull(sdrD["VINTTEL"]);
            txtFields13.Text = Utils.BlankIfNull(sdrD["VINTFAX"]);
            txtFields15.Text = Utils.BlankIfNull(sdrD["VINTPOR"]);
            txtFields16.Text = Utils.BlankIfNull(sdrD["VSITRES"]);
            txtFields17.Text = Utils.BlankIfNull(sdrD["VSTFPAYS"]);
            txtAction.Text = Utils.BlankIfNull(sdrD["VACTDES"]);
            txtDateRetour.Text = Utils.BlankIfNull(sdrD["DPPSRETOUR"]) == "" ? "" : Utils.DateBlankIfNull(sdrD["DPPSRETOUR"]);
          }
        }
      }
      catch (Exception ex)
      {
        MZUtils.displayError(MethodBase.GetCurrentMethod().Name, ex);
      }
    }


    private void cmdDate_Click(object sender, EventArgs e)
    {
      DateTime d;
      if (DateTime.TryParse(txtDateRetour.Text, out d))
        _curDate = Calendar1.Value = d;
      else { _curDate = DateTime.MinValue; Calendar1.Value = DateTime.Now; }
      Calendar1.Visible = true;
      Calendar1.ShowCalendar(new MouseEventArgs(MouseButtons.Left, 1, MousePosition.X - this.Location.X, MousePosition.Y - this.Location.Y, 0));
    }


    private void cmdSupp_Click(object sender, EventArgs e)
    {
      txtDateRetour.Text = "";
    }

    private void cmdVisu_Click(object sender, EventArgs e)
    {
      if (NIDPPS == 0)
      {
        MessageBox.Show(Resources.msg_enregistrerPPS, Program.AppTitle, MessageBoxButtons.OK, MessageBoxIcon.Information);
        return;
      }

      new frmMainReport
      {
        bLaunchByProcessStart = false,
        sTypeReport = "TPPSM",
        sIdentifiant = $"{NIDPPS}",
        InfosMail = $"TINT|NINTNUM|{Convert.ToInt64(Utils.ZeroIfNull(NINTNUM))}",
        sNomSociete = MozartParams.NomSociete,
        sLangue = $"{GetLangueByIntervenant(Convert.ToInt64(Utils.ZeroIfNull(NINTNUM)))}",
        sOption = "PREVIEW",
        strType = "PPS",
        numAction = MozartParams.NumAction
      }.ShowDialog();

    }

    private string GetLangueByIntervenant(long p_NINTNUM)
    {
      string returnLangueByInter = "FR";
      string sSQL = $"EXEC [api_sp_GetLangueByIntervenant] {p_NINTNUM}";
      using (SqlDataReader sdrAdo = ModuleData.ExecuteReader(sSQL))
      {
        if (!sdrAdo.Read()) returnLangueByInter = Utils.BlankIfNull(sdrAdo[0]);
      }
      return returnLangueByInter;
    }

    private void cmdValider_Click(object sender, EventArgs e)
    {

      try
      {
        // test si date retour existe
        if (txtDateRetour.Text == "")
        {
          MessageBox.Show(Resources.msg_dateretoursouhaitee, Program.AppTitle, MessageBoxButtons.OK, MessageBoxIcon.Information);
          return;
        }

        // création ou la modification c'est la proc stock qui gère
        using (SqlCommand cmd = new SqlCommand("api_sp_PPS_Create", MozartDatabase.cnxMozart))
        {
          cmd.CommandType = CommandType.StoredProcedure;
          SqlCommandBuilder.DeriveParameters(cmd);    // liste des paramètres

          //  liste des paramètres
          cmd.Parameters["@p_NIDPPS"].Value = NIDPPS; //  0 si création
          cmd.Parameters["@p_NACTNUM"].Value = NACTNUM;
          cmd.Parameters["@p_DPPSRETOUR"].Value = Utils.DateBlankIfNull(txtDateRetour.Text);
          cmd.Parameters["@p_NINTNUM"].Value = NINTNUM;

          cmd.ExecuteNonQuery();
          NIDPPS = (int)cmd.Parameters[0].Value;
        }

      }
      catch (Exception ex)
      {
        MZUtils.displayError(MethodBase.GetCurrentMethod().Name, ex);
      }
    }

    private void Calendar1_CloseUp(object sender, EventArgs e)
    {
      Calendar1.Visible = false;
      if (_curDate == DateTime.MinValue) return;
      txtDateRetour.Text = Calendar1.Value.ToShortDateString();
    }

    private void Calendar1_ValueChanged(object sender, EventArgs e)
    {
      if (Calendar1.Visible) _curDate = Calendar1.Value;
    }

    private void txtAction_KeyPress(object sender, KeyPressEventArgs e)
    {
      e.Handled = false;
    }

        private async void ApiTelAuto1_Click(object sender, EventArgs e)
        {
            if (txtFields8.Text != "")
            { 
                string reponse = await CNumerotationAuto.MakeCallByAvaya(MozartParams.UserTelInt, txtFields8.Text, Environment.MachineName);
                if (reponse != "OK")
                {
                    MessageBox.Show(reponse, Program.AppTitle, MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
        }

        private async void ApiTelAuto2_Click(object sender, EventArgs e)
        {
            if (txtFields12.Text != "")
            {
                string reponse = await CNumerotationAuto.MakeCallByAvaya(MozartParams.UserTelInt, txtFields12.Text, Environment.MachineName);
                if (reponse != "OK")
                {
                    MessageBox.Show(reponse, Program.AppTitle, MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
        }

        private async void ApiTelAuto3_Click(object sender, EventArgs e)
        {
            if (txtFields15.Text != "")
            {
                string reponse = await CNumerotationAuto.MakeCallByAvaya(MozartParams.UserTelInt, txtFields15.Text, Environment.MachineName);
                if (reponse != "OK")
                {
                    MessageBox.Show(reponse, Program.AppTitle, MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
        }
    }
}

