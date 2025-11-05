using MozartCS.Properties;
using MozartLib;
using MozartNet;
using System;
using System.Collections.Generic;
using System.Reflection;
using System.Windows.Forms;
using MZUtils = MozartControls.Utils;

namespace MozartCS
{
  public partial class frmAdminEtatComptaChaff : Form
  {
    public frmAdminEtatComptaChaff() { InitializeComponent(); }

    private void frmAdminEtatComptaChaff_Load(object sender, System.EventArgs e)
    {
      try
      {
        Cursor.Current = Cursors.WaitCursor;
        ModuleMain.Initboutons(this);

        cmdTech.Text = cmdTech.Text.Replace("societe", MozartParams.NomSociete);
        txtDateA.Text = DateTime.Now.ToShortDateString();

        cboChoixCompte.Init(MozartDatabase.cnxMozart, "Exec api_sp_comboCpteAna", "NCANNUM", "Compte Analytique", new List<string>() { Resources.col_Num, Resources.col_Nom }, 150, 550, true);

        // soit compte du chaff, soit compte du chef de groupe, soit droit voir tous
        string SQL = "SELECT NPERNUM, VPERNOM FROM TPER WHERE CPERACTIF='O' AND CPERTYP='CA' AND VSOCIETE=APP_NAME() "
          + " AND IDGROUPE in  (select IDGROUPE from dbo.TREF_GROUPE where VSOCIETE = APP_NAME() AND NPERNUM = " + MozartParams.UID + ")";

        cbCritChaff.Init(MozartDatabase.cnxMozart, "Exec api_sp_comboChaff", "NPERNUM", "VPERNOM", new List<string>() { Resources.col_Num, Resources.col_Nom }, 150, 550, true);

      }
      catch (Exception ex)
      {
        MZUtils.displayError(MethodBase.GetCurrentMethod().Name, ex);
      }
      finally { Cursor.Current = Cursors.Default; }
    }

    private void cmd1_Click(object sender, EventArgs e)
    {
      if (VerifSaisie())
      {
        Cursor = Cursors.WaitCursor;
        new frmStatComptaChargeChaff()
        {
          mstrType = "ST",
          mstrDate = txtDateA.Text,
          mstrsCpt = cboChoixCompte.GetItemData().ToString() == "-1" ? "0" : cboChoixCompte.GetItemData().ToString(), //cboChoixCompte.GetItemData().ToString(), //   txtChoixCompte.GetItemData().ToString()
          mstrsChaff = cbCritChaff.GetItemData().ToString() == "-1" ? "0" : cbCritChaff.GetItemData().ToString()
        }.ShowDialog();
        Cursor = Cursors.Default;
      }
    }

    private void cmd2_Click(object sender, EventArgs e)
    {
      if (VerifSaisie())
      {
        Cursor = Cursors.WaitCursor;
        new frmStatComptaChargeChaff()
        {
          mstrType = "FO",
          mstrDate = txtDateA.Text,
          mstrsCpt = cboChoixCompte.GetItemData().ToString() == "-1" ? "0" : cboChoixCompte.GetItemData().ToString(), //cboChoixCompte.GetItemData().ToString(), //   txtChoixCompte.GetItemData().ToString()
          mstrsChaff = cbCritChaff.GetItemData().ToString() == "-1" ? "0" : cbCritChaff.GetItemData().ToString()
        }.ShowDialog();
        Cursor = Cursors.Default;
      }
    }

    private void Command1_Click(object sender, EventArgs e)
    {
      if (VerifSaisie())
      {
        Cursor = Cursors.WaitCursor;
        new frmStatComptaNonExecChaff()
        {
          sDate = txtDateA.Text,
          sCpt = cboChoixCompte.GetItemData().ToString() == "-1" ? "0" : cboChoixCompte.GetItemData().ToString(),
          mstrsChaff = cbCritChaff.GetItemData().ToString() == "-1" ? "0" : cbCritChaff.GetItemData().ToString()
        }.ShowDialog();
        Cursor = Cursors.Default;
      }
    }

    private void cmdAssist_Click(object sender, EventArgs e)
    {
      loadStatComptaChaff("STT");
    }

    private void cmdTech_Click(object sender, EventArgs e)
    {
      loadStatComptaChaff("EMALEC");
    }

    private void loadStatComptaChaff(string pStrType)
    {
      if (!VerifSaisie())
      {
        return;
      }

      Cursor = Cursors.WaitCursor;
      new frmStatComptaChaff()
      {
        mstrType = pStrType,
        mstrDate = txtDateA.Text,
        mstrCpt = cboChoixCompte.GetItemData().ToString() == "-1" ? "0" : cboChoixCompte.GetItemData().ToString(),
        mstrsChaff = cbCritChaff.GetItemData().ToString() == "-1" ? "0" : cbCritChaff.GetItemData().ToString()
      }.ShowDialog();
      Cursor = Cursors.Default;
    }

    private void cmdSynt_Click(object sender, EventArgs e)
    {
      if (VerifSaisie())
      {
        Cursor = Cursors.WaitCursor;

        new frmStatComptaSyntChaff()
        {
          mstrCpt = cboChoixCompte.GetItemData().ToString() == "-1" ? "0" : cboChoixCompte.GetItemData().ToString(),
          mstrsChaff = cbCritChaff.GetItemData().ToString() == "-1" ? "0" : cbCritChaff.GetItemData().ToString(),
          mstrChaffLib = cbCritChaff.GetItemData().ToString() == "-1" ? "" : cbCritChaff.GetText(),
          mstrCptLib = cboChoixCompte.GetText(),
          mstrDate = txtDateA.Text
        }.ShowDialog();
        Cursor = Cursors.Default;
      }
    }

    private void Command2_Click(object sender, EventArgs e)
    {
      if (VerifSaisie())
      {
        Cursor = Cursors.WaitCursor;
        new frmStatComptaCSPChaff()
        {
          msType = "STTCHAFF",
          msDate = txtDateA.Text,
          msCpt = cboChoixCompte.GetItemData().ToString() == "-1" ? "0" : cboChoixCompte.GetItemData().ToString(),
          mstrsChaff = cbCritChaff.GetItemData().ToString() == "-1" ? "0" : cbCritChaff.GetItemData().ToString()
        }.ShowDialog();
        Cursor = Cursors.Default;
      }
    }

    private void CmdCSP_Click(object sender, EventArgs e)
    {
      Cursor = Cursors.WaitCursor;
      new frmStatComptaCSPChaff()
      {
        msType = "CSPCHAFF",
        msCpt = cboChoixCompte.GetItemData().ToString() == "-1" ? "0" : cboChoixCompte.GetItemData().ToString(),
        mstrsChaff = cbCritChaff.GetItemData().ToString() == "-1" ? "0" : cbCritChaff.GetItemData().ToString()
      }.ShowDialog();
      Cursor = Cursors.Default;
    }

    private bool VerifSaisie()
    {
      if (!checkDate())
      {
        return false;
      }

      if ((cboChoixCompte.GetText() == "") && (cbCritChaff.GetText() == ""))
      {
        MessageBox.Show("Il faut saisir un compte ou un chaff", "Mozart", MessageBoxButtons.OK, MessageBoxIcon.Information);
        return false;
      }

      return true;
    }

    // Vérifie si une date a été sélectionnée
    // Retourne false si aucune sélectionnée
    private bool checkDate()
    {
      bool bDateNotOk = (txtDateA.Text == "");

      if (bDateNotOk)
      {
        MessageBox.Show(Resources.msg_dateNonSaisie, "Mozart", MessageBoxButtons.OK, MessageBoxIcon.Information);
        cmdDate.Focus();
      }

      return (!bDateNotOk);
    }

    DateTime _curDate = DateTime.MinValue;
    private void cCalendar_CloseUp(object sender, EventArgs e)
    {
      cCalendar.Visible = false;
      if (_curDate == DateTime.MinValue) return;
      txtDateA.Text = cCalendar.Value.ToShortDateString();
    }
    private void cCalendar_ValueChanged(object sender, EventArgs e)
    {
      if (cCalendar.Visible) _curDate = cCalendar.Value;
    }
    private void cmdDate_Click(object sender, EventArgs e)
    {
      DateTime d;
      if (DateTime.TryParse(txtDateA.Text, out d))
        _curDate = cCalendar.Value = d;
      else { _curDate = DateTime.MinValue; cCalendar.Value = DateTime.Now; }
      cCalendar.Visible = true;
      cCalendar.ShowCalendar(new MouseEventArgs(MouseButtons.Left, 1, MousePosition.X - this.Location.X, MousePosition.Y - this.Location.Y, 0));
    }

    private void cmdFermer_Click(object sender, System.EventArgs e)
    {
      Dispose();
    }

    private void cbCritChaff_TxtChanged(object sender, EventArgs e)
    {
      if (cbCritChaff.GetText() != "")
      {
        cboChoixCompte.SetItemData(0);
      }
    }

    private void cboChoixCompte_TxtChanged(object sender, EventArgs e)
    {
      if (cboChoixCompte.GetText() != "")
      {
        cbCritChaff.SetItemData(0);
      }
    }

    private void cmdFAEPCA_Click(object sender, EventArgs e)
    {
      Cursor = Cursors.WaitCursor;
      if (checkDate())
      {
        new frmStatComptaFAEPCA(txtDateA.Text).ShowDialog();
      }
      Cursor = Cursors.Default;
    }
  }
}
