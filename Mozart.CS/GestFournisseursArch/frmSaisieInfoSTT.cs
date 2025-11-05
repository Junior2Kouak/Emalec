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
  public partial class frmSaisieInfoSTT : Form
  {
    public long miCleTable;
    public string mstrTypeNote;
    public bool mbNoteVisible;   // plus utile, à supprimer quand les form seront libre

    long miNumNote;

    //pour gerer le curseur dans observation
    bool mbObs;

    public frmSaisieInfoSTT()
    {
      InitializeComponent();
    }

    private void frmSaisieInfoSTT_Load(object sender, System.EventArgs e)
    {
      try
      {
        mbObs = false;
        ModuleMain.Initboutons(this);
        chkDroit.BackColor = ModuleMain.Couleur(MozartParams.NomSociete);
        InitFeuille();

        Cursor.Current = Cursors.Default;
      }
      catch (Exception ex)
      {
        MZUtils.displayError(MethodBase.GetCurrentMethod().Name, ex);
      }
    }


    private void cmdValObs_Click(object sender, EventArgs e)
    {
      string Msg;
      string temp;

      Msg = TxtObs.Text;
      if (Msg == "")
      {
        return;
      }

      //position en début de text quand focus et avec saut de ligne
      temp = MozartParams.strUID + " le " + DateTime.Now.ToString("dd/MM/yy") + " : ";
      if (txtInfo.Text == "")
      {
        txtInfo.Text = temp + Msg.Replace("'", "''");
      }
      else
      {
        txtInfo.Text = temp + Msg.Replace("'", "''") + "\r\n" + txtInfo.Text;
      }


      framObs.Visible = false;
      mbObs = false;
    }

    private void cmdAnObs_Click(object sender, EventArgs e)
    {
      TxtObs.Text = "";
      framObs.Visible = false;
      mbObs = false;
    }


    private void cmdMod_Click(object sender, EventArgs e)
    {
      TxtObs.Text = txtInfo.Text;
      txtInfo.Text = "";
      framObs.Visible = true;
    }

    private void cmdEnreg_Click(object sender, EventArgs e)
    {
      try
      {

        using (SqlCommand cmd = new SqlCommand("api_sp_CreationNote", MozartDatabase.cnxMozart))
        {
          cmd.CommandType = CommandType.StoredProcedure;
          SqlCommandBuilder.DeriveParameters(cmd);

          cmd.Parameters["@nNotNum"].Value = miNumNote;
          cmd.Parameters["@vNotType"].Value = mstrTypeNote;
          cmd.Parameters["@vMessage"].Value = txtInfo.Text;

          if (txtDateDeb.Text == "")
            cmd.Parameters["@dDateDeb"].Value = DBNull.Value;
          else
            cmd.Parameters["@dDateDeb"].Value = Convert.ToDateTime(txtDateDeb.Text);

          if (txtDateFin.Text == "")
            cmd.Parameters["@dDateFin"].Value = DBNull.Value;
          else
            cmd.Parameters["@dDateFin"].Value = Convert.ToDateTime(txtDateFin.Text);

          cmd.Parameters["@nNumCle"].Value = miCleTable;
          cmd.Parameters["@cInterdit"].Value = chkDroit.Checked == false ? "N" : "O";

          cmd.ExecuteNonQuery();

          // récupération du numéro crée

        }
        Close();
      }
      catch (Exception ex)
      {
        MZUtils.displayError(MethodBase.GetCurrentMethod().Name, ex);
      }
    }

    private void InitFeuille()
    {
      miNumNote = 0;
      txtInfo.Text = "";
      txtDateDeb.Text = "";
      txtDateFin.Text = "";

      using (SqlDataReader dr = ModuleData.ExecuteReader($"SELECT * FROM TNOTES WHERE VNOTTYPE = '{mstrTypeNote}' AND NNOTCLE = {miCleTable}"))
      {
        if (dr.Read())
        {
          miNumNote = Convert.ToInt64(dr["NNOTNUM"]);
          txtInfo.Text = Utils.BlankIfNull(dr["VNOTMESS"]);
          txtDateDeb.Text = Utils.DateBlankIfNull(dr["DNOTVALSTART"]);
          txtDateFin.Text = Utils.DateBlankIfNull(dr["DNOTVALSTOP"]);
          chkDroit.Checked = dr["CNOTINTERDIT"].ToString() == "O" ? true : false;
        }
      }
      chkDroit.Visible = true;

    }

    private void chkDroit_Click(object sender, EventArgs e)
    {
      //droit pour réactiver et desactiver
      if (chkDroit.Checked == false)
      {
        if (!ModuleMain.RechercheDroitMenu(294))
        {
          MessageBox.Show("Vous n'avez pas les droits pour réactiver ce sous-traitant." + "\r\n", Program.AppTitle, MessageBoxButtons.OK, MessageBoxIcon.Information);
          chkDroit.Checked = chkDroit.Checked == false ? true : false;
          return;
        }

        // si on décoche le STT d'interdit, on recalcul sa note moyenne
        ModuleData.ExecuteNonQuery($"update tstfgrp set nstfgrpnote = isnull((select sum(NNOTE)/count(ID) FROM TSTFGRPNOTE N WHERE N.NSTFGRPNUM = tstfgrp.NSTFGRPNUM),1) WHERE NSTFGRPNUM = {miCleTable}");

        txtInfo.Text = $"{MozartParams.strUID} le {DateTime.Now.ToString("dd/MM/yy HH:MM")}: Sous-traitant AUTORISE.\r\n{txtInfo.Text}";
      }

      // si on passe le sous traitant a interdit, on passe sa note à zéro
      if (chkDroit.Checked == true)
      {
        if (!ModuleMain.RechercheDroitMenu(294))
        {
          MessageBox.Show(Resources.msg_No_autorisation_to_forbid_sous_traitant + "\r\n" + Resources.msg_Demande_transmise_par_mail_to_chef_groupe_ou_filiale, Program.AppTitle, MessageBoxButtons.OK, MessageBoxIcon.Information);
          // envoi d'un mail au chef de groupe pour demander l'interdiction du STT
          ModuleData.ExecuteNonQuery($"api_sp_SendMailDemandeInterdictionSTT {miCleTable}");
          chkDroit.Checked = chkDroit.Checked == false ? true : false;
          return;
        }

        // si STT interdit, on passe sa note à 0
        ModuleData.ExecuteNonQuery($"update tstfgrp set nstfgrpnote = 0 WHERE NSTFGRPNUM = {miCleTable}");

        txtInfo.Text = $"{MozartParams.strUID} le {DateTime.Now.ToString("dd/MM/yy HH:MM")}: Sous-traitant INTERDIT.\r\n{txtInfo.Text}";
      }
    }


    private void txtInfo_Enter(object sender, EventArgs e)
    {
      framObs.Visible = true;
      if (!mbObs)
      {
        TxtObs.Focus();
        mbObs = true;
      }
    }

    private void chkDroit_CheckedChanged(object sender, EventArgs e)
    {

    }
    private void cmdFermer_Click(object sender, System.EventArgs e)
    {
      Close();
    }

  }
}

