using Microsoft.VisualBasic;
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
  public partial class frmDevisSTprestation : Form
  {
    public int miNumDevisST;

    private bool bModif;
    private DataTable dtArticle = new DataTable();

    public frmDevisSTprestation() : this(0)
    {
    }

    public frmDevisSTprestation(int piNumDevisST)
    {
      InitializeComponent();

      miNumDevisST = piNumDevisST;
    }

    private void frmDevisSTprestation_Load(object sender, System.EventArgs e)
    {
      try
      {
        Cursor.Current = Cursors.WaitCursor;
        ModuleMain.Initboutons(this);

        initDtArticle();
        InitaliserFeuille();
      }
      catch (Exception ex)
      {
        MZUtils.displayError(MethodBase.GetCurrentMethod().Name, ex);
      }
      finally { Cursor.Current = Cursors.Default; }
    }

    private void cmdFermer_Click(object sender, System.EventArgs e)
    {
      try
      {
        if (!bModif) { Dispose(); return; }

        // si il y a des modifications
        DialogResult res = MessageBox.Show("Voulez-vous enregistrer les modifications ?", Program.AppTitle, MessageBoxButtons.YesNoCancel,
                                            MessageBoxIcon.Question, MessageBoxDefaultButton.Button2);
        if (res == DialogResult.Yes)
        {
          EnregistrerDevisST();
          Dispose();
        }
        else if (res == DialogResult.No)
          Dispose();
        else
          return;
      }
      catch (Exception ex)
      {
        MZUtils.displayError(MethodBase.GetCurrentMethod().Name, ex);
      }
    }

    private void cmdValider_Click(object sender, EventArgs e)
    {
      try
      {
        if (txtAction.Text == "")
        {
          MessageBox.Show(" Entrez une action dans la zone prestation", Program.AppTitle, MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
          txtAction.Focus();
          return;
        }
        if (txtDateRetour.Text == "")
        {
          MessageBox.Show(" Saisie de la date de réception obligatoire", Program.AppTitle, MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
          return;
        }

        //test si il y a des prestations
        if (dtArticle.Rows.Count == 0)
        {
          MessageBox.Show("Il faut sélectionner des prestations pour ce devis", Program.AppTitle, MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
          return;
        }

        EnregistrerDevisST();
        bModif = false;
      }
      catch (Exception ex)
      {
        MZUtils.displayError(MethodBase.GetCurrentMethod().Name, ex);
      }
    }

    private void cmdImprimer_Click(object sender, EventArgs e)
    {
      if (miNumDevisST == 0)
      {
        MessageBox.Show("Impression impossible, il faut enregistrer le devis", Program.AppTitle, MessageBoxButtons.OK, MessageBoxIcon.Information);
        return;
      }

      new frmMainReport
      {
        bLaunchByProcessStart = false,
        sTypeReport = "TDEMANDEDEVISSTPREST",
        sIdentifiant = $"{miNumDevisST}",
        InfosMail = $"TINT|NINTNUM|{txtContact.Tag}",
        sNomSociete = MozartParams.NomSociete,
        sLangue = MozartParams.Langue,
        sOption = "PRINT",
        strType = "DD"
      }.ShowDialog();
    }

    private void cmdVisu_Click(object sender, EventArgs e)
    {
      if (miNumDevisST == 0)
      {
        MessageBox.Show("Visualisation impossible, il faut enregistrer le devis", Program.AppTitle, MessageBoxButtons.OK, MessageBoxIcon.Information);
        return;
      }

      new frmMainReport
      {
        bLaunchByProcessStart = false,
        sTypeReport = "TDEMANDEDEVISSTPREST",
        sIdentifiant = $"{miNumDevisST}",
        InfosMail = $"TINT|NINTNUM|{txtContact.Tag}",
        sNomSociete = MozartParams.NomSociete,
        sLangue = MozartParams.Langue,
        sOption = "PREVIEW",
        strType = "DD"
      }.ShowDialog();
    }

    private void cmdPPS_Click(object sender, EventArgs e)
    {
      if (miNumDevisST == 0)
      {
        MessageBox.Show("Visualisation impossible, il faut enregistrer le devis", Program.AppTitle, MessageBoxButtons.OK, MessageBoxIcon.Information);
        return;
      }

      new frmMainReport
      {
        bLaunchByProcessStart = false,
        sTypeReport = "TPPS_NUMACT",
        sIdentifiant = $"{MozartParams.NumAction}",
        InfosMail = $"TINT|NINTNUM|{txtContact.Tag}",
        sNomSociete = MozartParams.NomSociete,
        sLangue = MozartParams.Langue,
        sOption = "PREVIEW"
      }.ShowDialog();
    }

    private void cmdNBDLCP_Click(object sender, EventArgs e)
    {
      new frmPrestationsDevisST
      {
        miNumDevisST = miNumDevisST,
        dtArticle = dtArticle
      }.ShowDialog();
    }

    private void InitgridPrest()
    {
      apiTGridPrestSaisie.AddColumn("ID", "NLDCLPRESTID", 0);
      apiTGridPrestSaisie.AddColumn("Cat", "CAT", 500);
      apiTGridPrestSaisie.AddColumn("Prestation", "VPRESTLIB", 9000);
      apiTGridPrestSaisie.AddColumn("Uté", "VPRESTUNITE", 700, "", 2);
      apiTGridPrestSaisie.AddColumn("Qté", "NQTE", 700, "", 2);
      apiTGridPrestSaisie.AddColumn("Déboursé HT", "DEBOURSE", 1400, "Currency", 2);

      apiTGridPrestSaisie.InitColumnList();
    }

    private async void ApiTelAuto2_Click(object sender, EventArgs e)
    {
      //ApiTelAuto2.TelDial(txtTel.Text);
            if (txtTel.Text != "")
            { 
                string reponse = await CNumerotationAuto.MakeCallByAvaya(MozartParams.UserTelInt, txtTel.Text, Environment.MachineName);
                if (reponse != "OK")
                {
                    MessageBox.Show(reponse, Program.AppTitle, MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
        }

    private async void ApiTelAuto3_Click(object sender, EventArgs e)
    {
      //ApiTelAuto3.TelDial(txtPort.Text);
            if (txtPort.Text != "")
            {
                string reponse = await CNumerotationAuto.MakeCallByAvaya(MozartParams.UserTelInt, txtPort.Text, Environment.MachineName);
                if (reponse != "OK")
                {
                    MessageBox.Show(reponse, Program.AppTitle, MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
        }

    private void frmDevisSTprestation_KeyPress(object sender, KeyPressEventArgs e)
    {
      bModif = true;
    }

    DateTime _curDate = DateTime.MinValue;
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
    private void cmdDate1_Click(object sender, EventArgs e)
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
      bModif = true;
    }

    private void cmdDate_Click(object sender, EventArgs e)
    {
      Calendar1.Visible = true;
      Calendar1.ShowCalendar(new MouseEventArgs(MouseButtons.Left, 1, MousePosition.X, MousePosition.Y, 0));
    }

    private void EnregistrerDevisST()
    {
      try
      {
        // pour la création ou la modification, c'est la proc stocl qui gère
        // création d'une commande
        using (SqlCommand cmd = new SqlCommand("api_sp_creationDevisST", MozartDatabase.cnxMozart))
        {
          cmd.CommandType = CommandType.StoredProcedure;
          SqlCommandBuilder.DeriveParameters(cmd);    // liste des paramètres

          //  liste des paramètres
          cmd.Parameters["@iDevis"].Value = miNumDevisST;
          cmd.Parameters["@iAction"].Value = MozartParams.NumAction;
          cmd.Parameters["@LibAction"].Value = ModuleMain.ReplaceCharToBD(txtAction.Text, "RTF");

          if (txtDateRetour.Text == "")
            cmd.Parameters["@dDateR"].Value = DBNull.Value;
          else cmd.Parameters["@dDateR"].Value = Convert.ToDateTime(txtDateRetour.Text);

          cmd.Parameters["@iNbrPage"].Value = 0;
          cmd.Parameters["@iContact"].Value = Utils.ZeroIfNull(txtContact.Tag);
          cmd.Parameters["@cType"].Value = "P";

          cmd.ExecuteNonQuery();

          // récupération du numéro créé
          miNumDevisST = Convert.ToInt32(cmd.Parameters[0].Value);
        }

        //  traitement des prestations du devis
        EnregPrest();
      }
      catch (Exception ex)
      {
        MZUtils.displayError(MethodBase.GetCurrentMethod().Name, ex);
      }
    }

    private void initDtArticle()
    {
      dtArticle.Columns.Add("NLDCLPRESTID", typeof(int));
      dtArticle.Columns.Add("CAT", typeof(string));
      dtArticle.Columns.Add("VPRESTLIB", typeof(string));
      dtArticle.Columns.Add("VPRESTUNITE", typeof(string));
      dtArticle.Columns.Add("NQTE", typeof(double));
      dtArticle.Columns.Add("DEBOURSE", typeof(double));
      dtArticle.Columns.Add("DEBOURSUNIT", typeof(double));
      dtArticle.Columns.Add("NPACHAT", typeof(double));
      dtArticle.Columns.Add("NPUNITAIRE", typeof(double));
      dtArticle.Columns.Add("CMATFOURNI", typeof(string));
    }

    private void InitaliserFeuille()
    {
      try
      {
        // recherche des infos du devis (que le devis existe ou pas)
        //les infos de la feuille 
        using (SqlDataReader sdrD = MozartDatabase.ExecuteReader($"api_sp_RetourInfoDevisST {miNumDevisST},{MozartParams.NumAction}"))
        {
          if (sdrD.Read())
          {
            txtNomCli.Text = Utils.BlankIfNull(sdrD["VCLINOM"]);
            txtNumSite.Text = Utils.BlankIfNull(sdrD["NSITNUE"]);
            txtNomSite.Text = Utils.BlankIfNull(sdrD["VSITNOM"]);

            txtAdresse1.Text = Utils.BlankIfNull(sdrD["VSITAD1"]);
            txtVille.Text = Utils.BlankIfNull(sdrD["VSITVIL"]);
            txtCP.Text = Utils.BlankIfNull(sdrD["VSITCP"]);
            txtAdresse2.Text = Utils.BlankIfNull(sdrD["VSITAD2"]);
            txtDateCrea.Text = Utils.DateBlankIfNull(sdrD["DDSTDAT"]).ToString();

            txtNomCT.Text = Utils.BlankIfNull(sdrD["VSTFNOM"]);
            txtContact.Text = Utils.BlankIfNull(sdrD["VINTNOM"]);
            txtTel.Text = Utils.BlankIfNull(sdrD["VINTTEL"]);
            txtPort.Text = Utils.BlankIfNull(sdrD["VINTPOR"]);
            txtPays.Text = Utils.BlankIfNull(sdrD["VSTFPAYS"]);

            txtNumDevis.Text = Utils.BlankIfNull(sdrD["NDSTNUM"]);

            //  numero du contact
            txtContact.Tag = Utils.ZeroIfNull(sdrD["NINTNUM"]);
            txtNomCT.Tag = Utils.ZeroIfNull(sdrD["NSTFNUM"]);

            // si on est en modification ou en création
            if (Utils.BlankIfNull(sdrD["NDSTNUM"]) == "0")
            {
              miNumDevisST = 0;
              txtAction.Text = Utils.BlankIfNull(sdrD["VACTDES"]);
            }
            else
            {
              miNumDevisST = Convert.ToInt32(Strings.Mid(Utils.BlankIfNull(sdrD["NDSTNUM"]), 3));
              txtAction.Text = ModuleMain.ReplaceCharFromBD(Utils.BlankIfNull(sdrD["TDSTPRE"]), "RTF");
              cmdDate.Enabled = false; // fred le 11/09/2013 on ne peut plus modifier cette date 
            }

            // recherche liste des prestations du contrat
            // Ensuite, dans le form_load() par exemple
            apiTGridPrestSaisie.LoadData(dtArticle, MozartDatabase.cnxMozart, $"exec api_sp_listePrestDevisST {miNumDevisST}");
            apiTGridPrestSaisie.GridControl.DataSource = dtArticle;

            InitgridPrest();

            // les champs modifiables
            txtDateRetour.Text = Utils.DateBlankIfNull(sdrD["DDSTDRE"]).ToString();
          }
        }

        //  pas encore de modification
        bModif = false;
      }
      catch (Exception ex)
      {
        MZUtils.displayError(MethodBase.GetCurrentMethod().Name, ex);
      }
    }

    private void EnregPrest()
    {
      try
      {
        // delete et insert des prestations
        MozartDatabase.ExecuteNonQuery($"delete from TDSTPREST WHERE NDSTNUM= {miNumDevisST}");

        foreach (DataRow row in dtArticle.Rows)
        {
          MozartDatabase.ExecuteNonQuery($"insert into TDSTPREST select {miNumDevisST} ,{row["NLDCLPRESTID"]},{row["NQTE"].ToString().Replace(",", ".")}, '{row["CMATFOURNI"]}'");
        }
      }
      catch (Exception ex)
      {
        MZUtils.displayError(MethodBase.GetCurrentMethod().Name, ex);
      }
    }
  }
}
