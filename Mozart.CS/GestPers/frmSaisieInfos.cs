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
  public partial class frmSaisieInfos : Form
  {
    public long miCleTable;
    public string mstrTypeNote;

    long lNumNote;
    bool bPrem;


    public frmSaisieInfos() { InitializeComponent(); }

    private void frmSaisieInfos_Load(object sender, System.EventArgs e)
    {
      try
      {
        Cursor.Current = Cursors.WaitCursor;
        ModuleMain.Initboutons(this);

        bPrem = true;

        //chkDroit.BackColor = ModuleMain.Couleur(MozartParams.NomSociete);

        InitFeuille();

        bPrem = false;
      }
      catch (Exception ex)
      {
        MZUtils.displayError(MethodBase.GetCurrentMethod().Name, ex);
      }
      finally { Cursor.Current = Cursors.Default; }
    }

    private void cmdEnreg_Click(object sender, System.EventArgs e)
    {
      using (SqlCommand cmd = new SqlCommand("api_sp_CreationNote", MozartDatabase.cnxMozart))
      {
        cmd.CommandType = CommandType.StoredProcedure;
        SqlCommandBuilder.DeriveParameters(cmd);

        cmd.Parameters["@nNotNum"].Value = lNumNote;
        cmd.Parameters["@vNotType"].Value = mstrTypeNote;
        cmd.Parameters["@vMessage"].Value = txtInfo.Text;

        if (txtDateDebut.Text == "")
          cmd.Parameters["@dDateDeb"].Value = DBNull.Value;
        else
          cmd.Parameters["@dDateDeb"].Value = Convert.ToDateTime(txtDateDebut.Text);

        if (txtDateRetour.Text == "")
          cmd.Parameters["@dDateFin"].Value = DBNull.Value;
        else
          cmd.Parameters["@dDateFin"].Value = Convert.ToDateTime(txtDateRetour.Text);

        cmd.Parameters["@nNumCle"].Value = miCleTable;
        if (chkDroit.Checked == false)
          cmd.Parameters["@cInterdit"].Value = "N";
        else
          cmd.Parameters["@cInterdit"].Value = "O";

        cmd.ExecuteNonQuery();
      }

      MozartUcUtils.SpyLog(MozartDatabase.cnxMozart, this.Text, cmdEnreg.Text, "INSERT", $"VNOTTYPE:{mstrTypeNote}", $"NNOTCLE:{miCleTable}");

      Dispose();
    }

    private void InitFeuille()
    {
      lNumNote = 0;
      txtInfo.Text = "";
      txtDateDebut.Text = "";
      txtDateRetour.Text = "";

      using (SqlDataReader sdr = ModuleData.ExecuteReader($"SELECT * FROM TNOTES WHERE VNOTTYPE = '{mstrTypeNote}' AND NNOTCLE = {miCleTable}"))
      {
        if (sdr.Read())
        {
          lNumNote = (long)Utils.ZeroIfNull(sdr["NNOTNUM"]);
          txtInfo.Text = Utils.BlankIfNull(sdr["VNOTMESS"]);
          txtDateDebut.Text = Utils.DateBlankIfNull(sdr["DNOTVALSTART"]);
          txtDateRetour.Text = Utils.DateBlankIfNull(sdr["DNOTVALSTOP"]);
          chkDroit.Checked = sdr["CNOTINTERDIT"].ToString() == "O" ? true : false;
        }
      }

      switch (mstrTypeNote.ToUpper())
      {
        case "INFO_OT_EMALEC":
          lblInfo.Text = Resources.txt_saisieInfoOT + MozartParams.NomSociete;
          cmdInfoOT.Visible = false;
          cmdInfoInterne.Visible = false;
          break;
        case "INFO_OT_SECURITE":
          lblInfo.Text = Resources.txt_saisieInfoSecuOT + MozartParams.NomSociete;
          cmdInfoOT.Visible = false;
          cmdInfoInterne.Visible = false;
          break;
        case "INFO_CLIENT":
          lblInfo.Text = Resources.txt_saisieInfoCliInterne;
          chkDroit.Visible = true;
          chkDroit.Text = Resources.txt_interdirUtilisationClient;
          break;
        case "INFO_CLIENT_OT":
          lblInfo.Text = Resources.txt_saisieInfoClientOT;
          chkDroit.Visible = false;
          break;
        case "INFO_SITE":
          lblInfo.Text = Resources.txt_saisieInfoSiteInterne;
          chkDroit.Visible = true;
          break;
        case "INFO_SITE_OT":
          lblInfo.Text = Resources.txt_saisieInfoSiteOT;
          break;
        case "INFO_TECH":
          lblInfo.Text = Resources.txt_saisieInfoTech + " (Visible sur OT)";
          cmdInfoOT.Visible = false;
          cmdInfoInterne.Visible = false;
          break;
        default:
          break;
      }
    }

    private void chkDroit_CheckedChanged(object sender, EventArgs e)
    {

      if (chkDroit.Checked = true && mstrTypeNote == "INFO_SITE" && !bPrem)
      {
        string strAux = $"{MozartParams.strUID} le {DateTime.Now.ToShortDateString()} :{Environment.NewLine}Nous avons un litige de règlement avec la raison sociale de ce site.{Environment.NewLine}" +
        $"Vous ne pouvez pas prendre de demande d’intervention sur ce site.{Environment.NewLine}" +
        $"Informer votre chargé d’affaire.{Environment.NewLine}{Environment.NewLine} {txtInfo.Text}";
        txtInfo.Text = strAux;
      }
      bPrem = false;
    }

    private void chkDroit_Click(object sender, EventArgs e)
    {

      string StrAux;
      //droit pour réactiver et desactiver
      if (chkDroit.Checked == false && !bPrem)
      {
        if (mstrTypeNote == "INFO_SITE")
        {
          if (txtInfo.Text == "")
            txtInfo.Text = StrAux = MozartParams.strUID + " le " + DateTime.Now.ToString("dd/MM/yy HH:MM") + " : Site AUTORISE.";
          else
            txtInfo.Text = StrAux = MozartParams.strUID + " le " + DateTime.Now.ToString("dd/MM/yy HH:MM") + " : Site AUTORISE." + "\r\n" + txtInfo.Text;
        }
        else if (mstrTypeNote == "INFO_CLIENT")
        {
          if (txtInfo.Text == "")
            txtInfo.Text = StrAux = MozartParams.strUID + " le " + DateTime.Now.ToString("dd/MM/yy HH:MM") + " : Client AUTORISE.";
          else
            txtInfo.Text = StrAux = MozartParams.strUID + " le " + DateTime.Now.ToString("dd/MM/yy HH:MM") + " : Client AUTORISE." + "\r\n" + txtInfo.Text;
        }
      }

      //droit pour réactiver et desactiver
      if (chkDroit.Checked == true && !bPrem)
      {
        if (mstrTypeNote == "INFO_SITE")
        {
          if (txtInfo.Text == "")
            txtInfo.Text = StrAux = MozartParams.strUID + " le " + DateTime.Now.ToString("dd/MM/yy HH:MM") + " : Site INTERDIT.";
          else
            txtInfo.Text = StrAux = MozartParams.strUID + " le " + DateTime.Now.ToString("dd/MM/yy HH:MM") + " : Site INTERDIT." + "\r\n" + txtInfo.Text;
        }
        else if (mstrTypeNote == "INFO_CLIENT")
        {
          if (txtInfo.Text == "")
            txtInfo.Text = StrAux = MozartParams.strUID + " le " + DateTime.Now.ToString("dd/MM/yy HH:MM") + " : Client INTERDIT.";
          else
            txtInfo.Text = StrAux = MozartParams.strUID + " le " + DateTime.Now.ToString("dd/MM/yy HH:MM") + " : Client INTERDIT." + "\r\n" + txtInfo.Text;

          string msg = $"Vous venez d’interdire un client, merci de vérifier si les accès web client correspondants doivent être supprimés." +
                        $"\r\nSi c’est le cas, vous devez aller supprimer les accès web client.";

          MessageBox.Show($"{msg}{Environment.NewLine}{Environment.NewLine}", "MOZART", MessageBoxButtons.OK, MessageBoxIcon.Information);

        }
      }

      // pour que le prochain clic soit géré
      bPrem = false;

    }


    private void cmdInfoInterne_Click(object sender, EventArgs e)
    {
      if (mstrTypeNote == "INFO_CLIENT_OT")
        mstrTypeNote = "INFO_CLIENT";
      else if (mstrTypeNote == "INFO_SITE_OT")
        mstrTypeNote = "INFO_SITE";

      InitFeuille();
    }

    private void cmdInfoOT_Click(object sender, EventArgs e)
    {
      if (mstrTypeNote == "INFO_CLIENT")
        mstrTypeNote = "INFO_CLIENT_OT";
      else if (mstrTypeNote == "INFO_SITE")
        mstrTypeNote = "INFO_SITE_OT";

      InitFeuille();
    }

    private void cmdFermer_Click(object sender, EventArgs e)
    {
      MozartUcUtils.SpyLog(MozartDatabase.cnxMozart, "", "", "SPYEXIT");
      Dispose();
    }

    DateTime _curDate = DateTime.MinValue;
    private void CmdDate_Click(object sender, EventArgs e)
    {
      Button btn = sender as Button;
      Calendar1.Tag = btn.Tag;

      string txtDate = "";
      if ((sender as Button).Name == "cmdDateDebut")
      {
        txtDate = txtDateDebut.Text;
        Calendar1.Tag = 0;
      }
      else
      {
        txtDate = txtDateRetour.Text;
        Calendar1.Tag = 1;
      }
      DateTime d;
      if (DateTime.TryParse(txtDate, out d))
        _curDate = Calendar1.Value = d;
      else { _curDate = DateTime.MinValue; Calendar1.Value = DateTime.Now; }

      Calendar1.Visible = true;
      Calendar1.ShowCalendar(new MouseEventArgs(MouseButtons.Left, 1, MousePosition.X - this.Location.X, MousePosition.Y - this.Location.Y, 0));
    }
    private void Calendar1_CloseUp(object sender, EventArgs e)
    {
      Calendar1.Visible = false;
      if (_curDate == DateTime.MinValue) return;
      if ((int)Calendar1.Tag == 0) txtDateDebut.Text = Calendar1.Value.ToShortDateString();
      else if ((int)Calendar1.Tag == 1) txtDateRetour.Text = Calendar1.Value.ToShortDateString();
    }
    private void Calendar1_ValueChanged(object sender, EventArgs e)
    {
      if (Calendar1.Visible) _curDate = Calendar1.Value;
    }

    private void cmdSupp1_Click(object sender, EventArgs e)
    {
      txtDateDebut.Text = "";
    }
    private void cmdSupp0_Click(object sender, EventArgs e)
    {
      txtDateRetour.Text = "";
    }

    private void txtInfo_Enter(object sender, EventArgs e)
    {
      string aux = $"{MozartParams.strUID} le {DateTime.Now.ToShortDateString()} : ";
      txtInfo.Text = aux + "\r\n" + txtInfo.Text;
      txtInfo.SelectionStart = aux.Length;
      txtInfo.SelectionLength = 0;
    }
  }
}