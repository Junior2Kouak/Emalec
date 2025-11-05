using Microsoft.VisualBasic;
using MozartCS.Properties;
using MozartLib;
using MozartNet;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Net.Mail;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace MozartCS
{
  public partial class frmActionExecPlanif : Form
  {
    public DataRow mRow;

    public frmActionExecPlanif()
    {
      InitializeComponent();
    }

    private void frmActionExecPlanif_Load(object sender, EventArgs e)
    {
      // combo des clients
      cboClient.Init(MozartDatabase.cnxMozart, "select 0 as NCLINUM, '' as VCLINOM union select NCLINUM, VCLINOM from api_v_comboClient order by VCLINOM", "NCLINUM", "VCLINOM",
                    new List<string>() { Resources.col_Num, Resources.col_Nom }, 250, 550, true);

      if (mRow == null)
      {
        // Création
      } else
      {
        // Modification

        cboClient.Enabled = false;
        cboClient.SetItemData((int)Utils.ZeroIfNull(mRow["NCLINUM"]));

        string[] lLstMailsmRow = mRow["VGESTDEST"].ToString().Split(';');
        lstMails.Items.Clear();
        foreach (string lCur in lLstMailsmRow)
        {
          lstMails.Items.Add(lCur);
        }
      }
    }

    private void btnAddMail_Click(object sender, EventArgs e)
    {
      bool isValidEmail;

      string lNewMail = Interaction.InputBox("Adresse mail à ajouter", Program.AppTitle);
      if (lNewMail == null) { return; }
      lNewMail = lNewMail.Trim();
      try
      {
        var mail = new MailAddress(lNewMail);
        isValidEmail = mail.Host.Contains(".");
      }
      catch (Exception)
      {
        isValidEmail = false;
      }
      if (!isValidEmail)
      {
        MessageBox.Show("Adresse mail invalide !", Program.AppTitle, MessageBoxButtons.OK, MessageBoxIcon.Error);
        return;
      }

      // Vérifie que l'adresse n'existe pas déjà dans la liste
      foreach(string lCur in lstMails.Items)
      {
        if (lCur == lNewMail)
        {
          MessageBox.Show("Adresse mail déjà dans la liste !", Program.AppTitle, MessageBoxButtons.OK, MessageBoxIcon.Error);
          return;
        }
      }

      lstMails.Items.Add(lNewMail);

      //string lliste = String.Join(";", lstMails.Items.Cast<string>());
    }

    private void btnDeleteMail_Click(object sender, EventArgs e)
    {
      if (lstMails.SelectedIndex == -1) return;

      lstMails.Items.RemoveAt(lstMails.SelectedIndex);
    }
  }
}
