using MozartCS.Properties;
using MozartLib;
using MozartNet;
using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Reflection;
using System.Windows.Forms;
using MZUtils = MozartControls.Utils;

namespace MozartCS
{
  public partial class frmDetailVisite : Form
  {
    private const int BMODE_CREER = 1;
    private const int BMODE_MODIFIER = 2;
    private const int BMODE_TERMINER = 3;

    private int mNumVisite;
    private bool mBModeTerminer;

    public frmDetailVisite() : this(0, false)
    {
    }

    public frmDetailVisite(int pNumVisite) : this(pNumVisite, false)
    {
    }

    public frmDetailVisite(int pNumVisite, bool pBModeTerminer)
    {
      InitializeComponent();

      mNumVisite = pNumVisite;
      mBModeTerminer = pBModeTerminer;
    }

    private void frmDetailVisite_Load(object sender, EventArgs e)
    {
      ModuleMain.Initboutons(this);

      string lStr = $"SELECT NMOTIFVISITE, VMOTIFNOM FROM TREF_MOTIFVISITE WHERE LANGUE='{MozartParams.Langue}'";
      cboMotif.Init(MozartDatabase.cnxMozart, lStr, "NMOTIFVISITE", "VMOTIFNOM",
                    new List<string>() { Resources.col_Num, Resources.col_Nom }, 250, 550, true);

      InitialiserFeuille();
    }

    private void InitialiserFeuille()
    {
      try
      {
        if (mNumVisite == 0)
        {
          // Création d'une visite
          cmdAjouterVisite.Text = "Créer";

          setDepartVisible(false);

          using (SqlDataReader dr = ModuleData.ExecuteReader("SELECT GETDATE() AS DNOW"))
          {
            if (dr.Read())
            {
              dDateArrivee.DateTime = (DateTime)dr["DNOW"];
              dHeureArrivee.EditValue = (DateTime)dr["DNOW"];
            }
          }
        }
        else
        {
          // Modifier ou terminer une visite
          using (SqlDataReader sdr = ModuleData.ExecuteReader($"exec api_sp_detailVisite {mNumVisite}"))
          {
            if (sdr.Read())
            {
              dDateArrivee.DateTime = (DateTime)sdr["DVISITEDATARR"];
              dHeureArrivee.EditValue = (DateTime)sdr["DVISITEDATARR"];
              cboCiv.SelectedItem = Utils.BlankIfNull(sdr["CVISITECIV"]).Trim();
              txtNomV.Text = Utils.BlankIfNull(sdr["VVISITENOMV"]);
              txtPrenomV.Text = Utils.BlankIfNull(sdr["VVISITEPREV"]);
              txtMailV.Text = Utils.BlankIfNull(sdr["VVISITEMAIL"]);
              txtTelV.Text = Utils.BlankIfNull(sdr["VVISITETEL"]);
              txtRSV.Text = Utils.BlankIfNull(sdr["VVISITERS"]);
              txtServiceV.Text = Utils.BlankIfNull(sdr["VVISITESERV"]);
              txtNomC.Text = Utils.BlankIfNull(sdr["VVISITENOMC"]);
              txtPrenomC.Text = Utils.BlankIfNull(sdr["VVISITEPREC"]);
              cboMotif.SetItemData(Convert.ToInt32(sdr["NVISITEMOTIF"]));
              txtComment.Text = Utils.BlankIfNull(sdr["VVISITECOM"]);

              if (sdr["DVISITEDATDEP"] != DBNull.Value)
              {
                // Modification des infos d'une visite
                cmdAjouterVisite.Text = "Modifier";
                setDepartVisible(true);

                dHeureDepart.EditValue = dDateDepart.DateTime = (DateTime)sdr["DVISITEDATDEP"];
              }
              else
              {
                if (mBModeTerminer)
                {
                  // Ouverture pour terminer la visite
                  cmdAjouterVisite.Text = "Terminer";
                  setDepartVisible(true);
                  lblSortie.BackColor = Color.OrangeRed;

                  using (SqlDataReader dr = ModuleData.ExecuteReader("SELECT GETDATE() AS DNOW"))
                  {
                    if (dr.Read())
                    {
                      dDateDepart.DateTime = (DateTime)dr["DNOW"];
                      dHeureDepart.EditValue = (DateTime)dr["DNOW"];
                    }
                  }
                }
                else
                {
                  // Modification des infos d'une visite
                  cmdAjouterVisite.Text = "Modifier";
                  setDepartVisible(false);
                }
              }
            }
          }
        }
      }
      catch (Exception ex)
      {
        MZUtils.displayError(MethodBase.GetCurrentMethod().Name, ex);
      }
    }

    private void setDepartVisible(bool pBVisible)
    {
      lblSortie.Visible = pBVisible;
      dDateDepart.Visible = pBVisible;
      dHeureDepart.Visible = pBVisible;
    }

    // Création ou modification d'une visite
    private void cmdAjouterVisite_Click(object sender, EventArgs e)
    {
      enregistrer();
    }

    // bModeTerminer : Indique si l'enregistrement est effectué pour terminer la visite
    private void enregistrer()
    {
      try
      {
        if (!verifChamps()) return;

        // on ferme le formulaire si création de visite ou terminer une visite
        bool bCloseWindow = ((mNumVisite == 0) || mBModeTerminer);

        // Création ou la modification, c'est la proc stock qui gère
        using (SqlCommand cmd = new SqlCommand("api_sp_CreationVisite", MozartDatabase.cnxMozart))
        {
          cmd.CommandType = CommandType.StoredProcedure;

          // liste des paramètres
          SqlCommandBuilder.DeriveParameters(cmd);

          cmd.Parameters["@nVisite"].Value = mNumVisite; // 0 si création
          cmd.Parameters["@dDateArr"].Value = dDateArrivee.DateTime;
          if (lblSortie.Visible)
          {
            // Si le label date sortie est visible, il faut updater la date de sortie aussi
            cmd.Parameters["@dDateDep"].Value = dDateDepart.DateTime;
          }
          cmd.Parameters["@vCiv"].Value = Utils.BlankIfNull(cboCiv.SelectedItem).Trim();
          cmd.Parameters["@vNomVis"].Value = txtNomV.Text.Trim();
          cmd.Parameters["@vPreVis"].Value = txtPrenomV.Text.Trim();
          cmd.Parameters["@vMail"].Value = txtMailV.Text.Trim();
          cmd.Parameters["@vTel"].Value = txtTelV.Text.Trim();
          cmd.Parameters["@vRS"].Value = txtRSV.Text.Trim();
          cmd.Parameters["@vServ"].Value = txtServiceV.Text.Trim();
          cmd.Parameters["@vNomCollab"].Value = txtNomC.Text.Trim();
          cmd.Parameters["@vPreCollab"].Value = txtPrenomC.Text.Trim();
          cmd.Parameters["@nMotif"].Value = cboMotif.GetItemData();
          cmd.Parameters["@vCom"].Value = txtComment.Text.Trim();
          cmd.Parameters["@vSociete"].Value = MozartParams.NomSociete;

          cmd.ExecuteNonQuery();
          mNumVisite = (int)cmd.Parameters[0].Value;

          if (bCloseWindow)
          {
            Close();
          }
        }
      }
      catch (Exception ex)
      {
        MZUtils.displayError(MethodBase.GetCurrentMethod().Name, ex);
      }
    }

    private bool verifChamps()
    {
      //if (null == cboCiv.SelectedItem || cboCiv.SelectedItem.ToString() == "")
      //{
      //  MessageBox.Show("Saisissez la civilité du visiteur", Program.AppTitle, MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
      //  cboCiv.Focus();
      //  return false;
      //}

      //if (txtNomV.Text.Trim() == "")
      //{
      //  MessageBox.Show("Saisissez le nom du visiteur", Program.AppTitle, MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
      //  txtNomV.Focus();
      //  return false;
      //}

      //if (txtPrenomV.Text.Trim() == "")
      //{
      //  MessageBox.Show("Saisissez le prénom du visiteur", Program.AppTitle, MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
      //  txtPrenomV.Focus();
      //  return false;
      //}

      //if ((txtMailV.Text.Trim() == "") && (txtTelV.Text.Trim() == ""))
      //{
      //  MessageBox.Show("Saisissez l'adresse mail ou le téléphone du visiteur", Program.AppTitle, MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
      //  txtMailV.Focus();
      //  return false;
      //}

      //if (txtNomC.Text.Trim() == "")
      //{
      //  MessageBox.Show("Saisissez le nom du collaborateur", Program.AppTitle, MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
      //  txtNomC.Focus();
      //  return false;
      //}

      //if (txtPrenomC.Text.Trim() == "")
      //{
      //  MessageBox.Show("Saisissez le prénom du collaborateur", Program.AppTitle, MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
      //  txtPrenomC.Focus();
      //  return false;
      //}

      if (cboMotif.GetText() == "")
      {
        MessageBox.Show("Sélectionnez un motif de visite", Program.AppTitle, MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
        cboMotif.Focus();
        return false;
      }

      return true;
    }

    private void dHeureDepart_EditValueChanged(object sender, EventArgs e)
    {
      dDateDepart.DateTime = updateHour(dDateDepart.DateTime, dHeureDepart.Time);
    }

    private void dHeureArrivee_EditValueChanged(object sender, EventArgs e)
    {
      dDateArrivee.DateTime = updateHour(dDateArrivee.DateTime, dHeureArrivee.Time);
    }

    // Prend l'heure dans pHeure et la met dans la date pDate, retourne la valeur
    private DateTime updateHour(DateTime pDate, DateTime pHeure)
    {
      return Convert.ToDateTime($"{pDate.ToShortDateString()} {pHeure.ToLongTimeString()}");
    }
  }
}
