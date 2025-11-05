using MozartLib;
using MozartNet;
using System;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Reflection;
using System.Windows.Forms;
using MZUtils = MozartControls.Utils;

namespace MozartCS
{
  public partial class frmEnqueteQual : Form
  {
    public int NACTNUM;
    public string TYPE_ENQUETE;
    public string DROIT_REPONSE;

    private int ID_ENQUETE;

    public frmEnqueteQual()
    {
      InitializeComponent();
    }

    private void frmEnqueteQual_Load(object sender, System.EventArgs e)
    {
      try
      {
        Cursor.Current = Cursors.WaitCursor;
        ModuleMain.Initboutons(this);
        panel1.BackColor = panel2.BackColor = panel3.BackColor = Color.FromArgb(25, 255, 224, 192);

        InitFeuille();
      }
      catch (Exception ex)
      {
        MZUtils.displayError(MethodBase.GetCurrentMethod().Name, ex);
      }
      finally
      {
        Cursor.Current = Cursors.Default;
      }
    }

    private void InitFeuille()
    {
      try
      {
        Cursor.Current = Cursors.WaitCursor;

        using (SqlDataReader sdr = MozartDatabase.ExecuteReader($"exec api_sp_InfoEnqueteQual {NACTNUM}, '{TYPE_ENQUETE}'"))
        {
          if (sdr.Read())
          {
            lblTitre.Text = $"Equête qualité {sdr["ORIGINE"]} réalisée le : {sdr["DATESAISIE"]}";
            txtContact.Text = Utils.BlankIfNull(sdr["VUTILOG"]);
            txtFonction.Text = Utils.BlankIfNull(sdr["VFONCTION"]);
            txtRem.Text = Utils.BlankIfNull(sdr["VREM"]);
            ID_ENQUETE = (int)Utils.ZeroIfBlank(sdr["ID"]);
            switch (Convert.ToChar(sdr["CQUESTION1"]))
            {
              case 'A':
                optQ10.Checked = true;
                break;
              case 'B':
                optQ11.Checked = true;
                break;
              case 'C':
                optQ12.Checked = true;
                break;
              default:
                break;
            }
            switch (Convert.ToChar(sdr["CQUESTION2"]))
            {
              case 'A':
                optQ20.Checked = true;
                break;
              case 'B':
                optQ21.Checked = true;
                break;
              case 'C':
                optQ22.Checked = true;
                break;
              default:
                break;
            }
            switch (Convert.ToChar(sdr["CQUESTION3"]))
            {
              case 'A':
                optQ30.Checked = true;
                break;
              case 'B':
                optQ31.Checked = true;
                break;
              case 'C':
                optQ32.Checked = true;
                break;
              default:
                break;
            }

            cmdValider.Visible = false;
            txtRem.Enabled = false;
            optQ10.Enabled = optQ11.Enabled = optQ12.Enabled = false;
            optQ20.Enabled = optQ21.Enabled = optQ22.Enabled = false;
            optQ30.Enabled = optQ31.Enabled = optQ32.Enabled = false;

            // si on vient de la liste des Action Qualité, on peut répondre
            cmdRepondre.Visible = (DROIT_REPONSE == "OUI");
          }
          else
            // on est en création d'une enqête, donc on ne peut pas répondre
            cmdRepondre.Visible = false;
        }
      }
      catch (Exception ex)
      {
        MZUtils.displayError(MethodBase.GetCurrentMethod().Name, ex);
      }
      finally
      {
        Cursor.Current = Cursors.Default;
      }
    }

    private void cmdValider_Click(object sender, EventArgs e)
    {
      // obligation de saisir une remarque si insatisfaction du client
      if ((optQ12.Checked || optQ22.Checked || optQ32.Checked) && txtRem.Text == "")
      {
        MessageBox.Show("Saisir la raison du/des mécontentement(s) dans les remarques.", Program.AppTitle, MessageBoxButtons.OK, MessageBoxIcon.Warning,
        MessageBoxDefaultButton.Button2);
        return;
      }

      if (MessageBox.Show("Attention, vous ne pourrez pas modifier cette enquête ultérieurement, vous confirmez l'enregistrement ?", Program.AppTitle, MessageBoxButtons.YesNo, MessageBoxIcon.Question,
      MessageBoxDefaultButton.Button2) != DialogResult.Yes) return;

      if (txtContact.Text == "")
      {
        MessageBox.Show("Saisir le nom du contact.", Program.AppTitle, MessageBoxButtons.OK, MessageBoxIcon.Warning, MessageBoxDefaultButton.Button2);
        return;
      }

      if (txtFonction.Text == "")
      {
        MessageBox.Show("Saisir la fonction.", Program.AppTitle, MessageBoxButtons.OK, MessageBoxIcon.Warning, MessageBoxDefaultButton.Button2);
        return;
      }

      using (SqlCommand cmd = new SqlCommand("api_sp_CreationEnqueteQual", MozartDatabase.cnxMozart))
      {
        cmd.CommandType = CommandType.StoredProcedure;
        SqlCommandBuilder.DeriveParameters(cmd);    // liste des paramètres

        //  liste des paramètres
        cmd.Parameters["@p_NACTNUM"].Value = NACTNUM;
        cmd.Parameters["@p_VUTILOG"].Value = txtContact.Text;

        char cTemp = 'A';
        if (optQ11.Checked) cTemp = 'B';
        else if (optQ12.Checked) cTemp = 'C';
        cmd.Parameters["@p_Q1"].Value = cTemp;

        char cTemp2 = 'A';
        if (optQ21.Checked) cTemp2 = 'B';
        else if (optQ22.Checked) cTemp2 = 'C';
        cmd.Parameters["@p_Q2"].Value = cTemp2;

        char cTemp3 = 'A';
        if (optQ31.Checked) cTemp3 = 'B';
        else if (optQ32.Checked) cTemp3 = 'C';
        cmd.Parameters["@p_Q3"].Value = cTemp3;

        cmd.Parameters["@p_VREM"].Value = txtRem.Text;
        cmd.Parameters["@p_Fonc"].Value = txtFonction.Text;

        cmd.ExecuteNonQuery();
      }

      Close();
    }

    private void cmdRepondre_Click(object sender, EventArgs e)
    {
      framRep.Visible = true;
    }

    private void cmdAnObs_Click(object sender, EventArgs e)
    {
      TxtReponse.Text = "";
      framRep.Visible = false;
    }

    private void cmdValObs_Click(object sender, EventArgs e)
    {
      MozartDatabase.ExecuteNonQuery($"update EnqueteClientWeb set VREPONSE = '{TxtReponse.Text}' WHERE ID = {ID_ENQUETE}");

      TxtReponse.Text = "";
      framRep.Visible = false;
    }
  }
}

