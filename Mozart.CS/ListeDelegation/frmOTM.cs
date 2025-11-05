using DevExpress.XtraGrid.Views.Grid;
using Microsoft.VisualBasic;
using MozartCS.Properties;
using MozartLib;
using MozartNet;
using MozartUC;
using ReportEmalec.Net;
using System;
using System.Data;
using System.Data.SqlClient;
using System.Reflection;
using System.Windows.Forms;
using MZUtils = MozartControls.Utils;

namespace MozartCS
{
  public partial class frmOTM : Form
  {
    // feuille ouverte en création ou modification
    public int mNumContratOMT;
    public string msDatePlanif;
    public string msTypeContrat;

    public bool mbFacture = false;

    bool bModif;
    
    DataTable dtSth = new DataTable();
    DataTable dtstb = new DataTable();
    DataTable dtDoc = new DataTable();


    public frmOTM() { InitializeComponent(); }

    private void frmContratAutoST_Load(object sender, System.EventArgs e)
    {
      try
      {
        Cursor.Current = Cursors.WaitCursor;
        ModuleMain.Initboutons(this);

        cmdDate1.Visible = cmdSupp1.Visible =  false;
        
        InitialiserFeuille();

        // on affiche les informations d'historique du stt
        apiTGridH.LoadData(dtSth, MozartDatabase.cnxMozart, $"api_sp_ContratEnCoursSTT {Utils.ZeroIfNull(txtFields12.Tag)},'{MozartParams.NomSociete}', 'E'");
        apiTGridH.GridControl.DataSource = dtSth;

        apiTGridB.LoadData(dtstb, MozartDatabase.cnxMozart, $"api_sp_ContratEnCoursSTT '{Utils.ZeroIfNull(txtFields12.Tag)}','{MozartParams.NomSociete}', 'H'");
        apiTGridB.GridControl.DataSource = dtstb;
        InitGrid();

        apiTGrid2.LoadData(dtDoc, MozartDatabase.cnxMozart, $"EXEC api_sp_StatutDocSTF 0,{Utils.ZeroIfNull(txtFields12.Tag)}");
        apiTGrid2.GridControl.DataSource = dtDoc;
        InitApiGridDoc();

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
        //si il y a des modifications
        if (bModif)
        {
          DialogResult res = MessageBox.Show(Resources.msgConfirm_enregistrerModif, Program.AppTitle, MessageBoxButtons.YesNoCancel, MessageBoxIcon.Question,
                                             MessageBoxDefaultButton.Button2);
          if (DialogResult.Cancel == res) return;
          if (DialogResult.Yes == res) EnregistrerContratOTM();
        }
        Dispose();
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
        // on teste si le stt est interdit
        if (STFGRPInterdit(Convert.ToInt32(txtFields2.Tag)))
        {
          MessageBox.Show(Resources.msg_sousTraitInterdit, Program.AppTitle, MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
          return;
        }
        // si la DI est facturée on ne peut pas créer de contrat
        //  If frmListeContratsST.bFacture Then
        if (mbFacture)
        {
          MessageBox.Show(Resources.msg_engagerDepenseActPlanifier, Program.AppTitle, MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
          return;
        }
        if (txtRem.Text == "")
        {
          MessageBox.Show(Resources.msg_Entrez_action_dans_zone_presta, Program.AppTitle, MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
          return;
        }
        if (txtDelais.Text == "")
        {
          MessageBox.Show(Resources.msg_saisieDateExeObligatoire, Program.AppTitle, MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
          return;
        }

        //  modification impossible sauf par droit spécifique si facture ravel existe sur le contrat
        if (mNumContratOMT != 0)
        {
          string sSQL = $"SELECT count(NFOUFACNUM) FROM TFOUFACCDE WHERE TFOUFACCDE.NCDENUM = {mNumContratOMT} AND TFOUFACCDE.VTYPECDE = 'CS'";
          int i = (int)MozartDatabase.ExecuteScalarInt(sSQL);
          if (i > 0)
          {
            if (ModuleMain.RechercheDroitMenu(674))
            {
              if (MessageBox.Show("La facture de ce contrat a été saisie dans Ravel.Voulez-vous quand même le modifier", Program.AppTitle, MessageBoxButtons.YesNo, MessageBoxIcon.Question,
                                   MessageBoxDefaultButton.Button2) != DialogResult.Yes) return;
            }
            else
            {
              MessageBox.Show("La facture de ce contrat a été saisie dans Ravel.Vous ne pouvez plus le modifier", Program.AppTitle, MessageBoxButtons.OK, MessageBoxIcon.Information);
              return;
            }
          }
        }

        EnregistrerContratOTM();

        bModif = false;
      }
      catch (Exception ex)
      {
        MZUtils.displayError(MethodBase.GetCurrentMethod().Name, ex);
      }
    }

    private void cmdImprimer_Click(object sender, EventArgs e)
    {
      if (mNumContratOMT == 0)
      {
        MessageBox.Show(Resources.msg_Impression_impossible_enregistrer_contrat, Program.AppTitle, MessageBoxButtons.OK, MessageBoxIcon.Information);
        return;
      }

      launchReport(true);

    }

    // pForPrinting = TRUE pour PRINT, FALSE pour PREVIEW
    private void launchReport(bool pForPrinting)
    {
  
      string lOption = pForPrinting ? "PRINT" : "PREVIEW";

      new frmMainReport
      {
        bLaunchByProcessStart = false,
        sTypeReport = "TORDREDETRAVAILMUTUALISE",
        sIdentifiant = $"{MozartParams.NumAction}|{mNumContratOMT}",
        InfosMail = $"TINT|NINTNUM|{txtFields13.Tag}",
        sNomSociete = MozartParams.NomSociete,
        sLangue = txtLangue.Text,
        sOption = lOption,
        strType = "OTM",
        numAction = MozartParams.NumAction
      }.ShowDialog();
    }

    private void cmdVisu_Click(object sender, EventArgs e)
    {
      if (mNumContratOMT == 0)
      {
        MessageBox.Show(Resources.msg_Impression_impossible_enregistrer_contrat, Program.AppTitle, MessageBoxButtons.OK, MessageBoxIcon.Information);
        return;
      }

      Cursor = Cursors.WaitCursor;
      launchReport(false);
      Cursor = Cursors.Default;
    }

    private void cmdAttach_Click(object sender, EventArgs e)
    {
      if (mNumContratOMT == 0)
      {
        MessageBox.Show(Resources.msg_Impression_impossible_enregistrer_contrat, Program.AppTitle, MessageBoxButtons.OK, MessageBoxIcon.Information);
        return;
      }

      new frmMainReport
      {
        bLaunchByProcessStart = false,
        sTypeReport = "AttachementSTT_OTM",
        sIdentifiant = $"{MozartParams.NumAction}|{mNumContratOMT}",
        InfosMail = $"TINT|NINTNUM|{txtFields13.Tag}",
        sNomSociete = MozartParams.NomSociete,
        sLangue = txtLangue.Text,
        sOption = "PREVIEW",
        strType = "OTM",
        numAction = MozartParams.NumAction
      }.ShowDialog();
    }

      private void cmdGamme_Click(object sender, EventArgs e)
    {
      if (mNumContratOMT == 0)
      {
        MessageBox.Show(Resources.msg_Impression_impossible_enregistrer_contrat, Program.AppTitle, MessageBoxButtons.OK, MessageBoxIcon.Information);
        return;
      }
      // s'il existe un planification préventif, rechercher la gamme
      if ((int)MozartDatabase.ExecuteScalarInt($"SELECT COUNT(NIPLSTNUM) FROM TIPLST WHERE NACTNUM = {MozartParams.NumAction}") > 0)
      {
        //recherche de la gamme sur l'action
        using (SqlDataReader sdrA = MozartDatabase.ExecuteReader($"SELECT NGAMNUM FROM TACT WITH (NOLOCK) WHERE NGAMNUM <> 0 AND NACTNUM = {MozartParams.NumAction}"))
        {
          if (sdrA.Read())
          {
            new frmMainReport
            {
              bLaunchByProcessStart = false,
              sTypeReport = "TGAMMECLIENTST",
              sIdentifiant = $"{sdrA["NGAMNUM"]}|{MozartParams.NumAction}",
              InfosMail = $"TINT|NINTNUM|{txtFields13.Tag}",
              sNomSociete = MozartParams.NomSociete,
              sLangue = MozartParams.Langue,
              sOption = "PREVIEW"
            }.ShowDialog();

          }
        }
      }
    }

    private void cmdAlert_Click(object sender, EventArgs e)
    {
			if (mNumContratOMT == 0)
			{
				MessageBox.Show("Enregistrer le contrat", Program.AppTitle, MessageBoxButtons.OK, MessageBoxIcon.Information);
				return;
			}

			new frmSaisieAlertRavel()
      {
        mstrType = "SOUS-TRAITANT",
        miNumObjet = mNumContratOMT
      }.ShowDialog();
    }
 
    private void cmdSupp1_Click(object sender, EventArgs e)
    {
      txtDelais.Text = "";
      bModif = true;
    }

    private void frmContratAutoST_KeyPress(object sender, KeyPressEventArgs e)
    {
      bModif = true;
    }

    DateTime _curDate = DateTime.MinValue;
    private void CmdDate_Click(object sender, EventArgs e)
    {
      Button btn = sender as Button;
      Calendar1.Tag = btn.Tag;

      string txtDate = "";
      if ((sender as Button).Name == "cmdDate1")
      {
        txtDate = txtDelais.Text;
        Calendar1.Tag = 0;
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
      if ((int)Calendar1.Tag == 0) txtDelais.Text = Calendar1.Value.ToShortDateString();

    }

    private void Calendar1_ValueChanged(object sender, EventArgs e)
    {
      if (Calendar1.Visible) _curDate = Calendar1.Value;
    }

    private void EnregistrerContratOTM()
    {
      try
      {
        
        // pour la création ou la modification, c'est la proc stock qui gère
        using (SqlCommand cmd = new SqlCommand("api_sp_creationOTM", MozartDatabase.cnxMozart))
        {
          cmd.CommandType = CommandType.StoredProcedure;
          SqlCommandBuilder.DeriveParameters(cmd);    // liste des paramètres

          //  liste des paramètres
          cmd.Parameters["@iContrat"].Value = mNumContratOMT;
          cmd.Parameters["@iAction"].Value = MozartParams.NumAction;
          cmd.Parameters["@tRem"].Value = ModuleMain.ReplaceCharToBD(txtRem.Text, "RTF");
					cmd.Parameters["@iContact"].Value = txtFields13.Tag;
					cmd.Parameters["@cType"].Value = msTypeContrat;
					if (txtDelais.Text == "")
            cmd.Parameters["@dDelai"].Value = DBNull.Value;
          else
            cmd.Parameters["@dDelai"].Value = Convert.ToDateTime(txtDelais.Text);
					cmd.Parameters["@vnumCStinitial"].Value = txtNumCSinitial.Text;

					cmd.ExecuteNonQuery();

          mNumContratOMT = (int)cmd.Parameters[0].Value;
        }

				// coche sur l'action de non relance facture STT
				MozartDatabase.ExecuteNonQuery($"UPDATE TACT SET NACTVALDEVISST = 1 WHERE NACTNUM = {MozartParams.NumAction}");
			

				//  mise a jour de l'affichage
				InitialiserFeuille();
      }
      catch (Exception ex)
      {
        MZUtils.displayError(MethodBase.GetCurrentMethod().Name, ex);
      }
    }

    private void InitialiserFeuille()
    {
      try
      {
        // recherche des infos du contrat
        using (SqlDataReader sdr = MozartDatabase.ExecuteReader($"api_sp_RetourInfoOTM {mNumContratOMT},{MozartParams.NumAction},'{MozartParams.NomSociete}'"))
        {
          if (sdr.Read())
          {
            txtFields4.Text = Utils.BlankIfNull(sdr["NOTMNUM"]);
            txtFields3.Text = Utils.DateBlankIfNull(sdr["DCSTDAT"]);
            txtFields0.Text = Utils.BlankIfNull(sdr["VCLINOM"]);
            txtFields2.Text = Utils.BlankIfNull(sdr["NSITNUE"]);
            txtFields1.Text = Utils.BlankIfNull(sdr["VSITNOM"]);
            txtFields6.Text = Utils.BlankIfNull(sdr["VSITAD1"]);
            txtFields7.Text = Utils.BlankIfNull(sdr["VSITAD2"]);
            txtFields9.Text = Utils.BlankIfNull(sdr["VSITVIL"]);
            txtFields8.Text = Utils.BlankIfNull(sdr["VSITCP"]);
            txtFields10.Text = Utils.BlankIfNull(sdr["VSITTEL"]);
            txtFields11.Text = Utils.BlankIfNull(sdr["VSITFAX"]);
            txtFields12.Text = Utils.BlankIfNull(sdr["VSTFNOM"]);
            txtFields13.Text = Utils.BlankIfNull(sdr["VINTNOM"]);
            txtFields14.Text = Utils.BlankIfNull(sdr["VINTTEL"]);
            txtFields15.Text = Utils.BlankIfNull(sdr["VINTFAX"]);
            txtFields17.Text = Utils.BlankIfNull(sdr["VSTFPAYS"]);
            txtFields5.Text = Utils.BlankIfNull(sdr["VINTPOR"]);
            txtNumCSinitial.Text = Utils.BlankIfNull(sdr["VCSINITIAL"]); 
						// id sous-traitant et contact
						txtFields12.Tag = Utils.ZeroIfNull(sdr["NSTFNUM"]);
            txtFields13.Tag = Utils.ZeroIfNull(sdr["NINTNUM"]);

            txtLangue.Text = Utils.BlankIfNull(sdr["VLANGUEABR"]);


            // si on est en modification ou en création
            if (sdr["NOTMNUM"].ToString() == "0")
            {
              mNumContratOMT = 0;
              txtRem.Text = Utils.BlankIfNull(sdr["VACTDES"]);
              txtDelais.Text = msDatePlanif;

            }
            else
            {
              mNumContratOMT = Convert.ToInt32(Strings.Mid(Utils.BlankIfNull(sdr["NOTMNUM"]), 4));
              txtRem.Text = ModuleMain.ReplaceCharFromBD(Utils.BlankIfNull(sdr["TCSTPRE"]), "RTF");
              txtDelais.Text = Utils.DateBlankIfNull(sdr["DCSTDEL"], "dd/MM/yyyy");
 
            }

            // COULEUR DU BOUTON ALERT : jaune si une alerte a ete saisie
            if (sdr["VCSTALERT"].ToString() != "N" && sdr["VCSTALERT"].ToString() != "") cmdAlert.BackColor = MozartColors.ColorH80FFFF;

            // pas encore de modification
            bModif = false;

          }
        }
      }
      catch (Exception ex)
      {
        MZUtils.displayError(MethodBase.GetCurrentMethod().Name, ex);
      }
    }

    private bool STFGRPInterdit(int nstfnum)
    {
      try
      {
        using (SqlDataReader sdrSTTInter = MozartDatabase.ExecuteReader($"exec api_sp_RetourInfoSttInterdit {nstfnum}"))
        {
          if (sdrSTTInter.Read())
            return Utils.BlankIfNull(sdrSTTInter["CNOTINTERDIT"]) == "O";
        }
      }
      catch (Exception ex)
      {
        MZUtils.displayError(MethodBase.GetCurrentMethod().Name, ex);
      }
      return false;
    }

    private void InitGrid()
    {
      try
      {
        // liste contrat en cours
        apiTGridH.AddColumn("Filiale", "VSOCIETE", 1000);
        apiTGridH.AddColumn("Client", "VCLINOM", 1900, "", 0, true);
        apiTGridH.AddColumn("Site", "VSITNOM", 1900, "", 0, true);
        apiTGridH.AddColumn("Chaff", "VDINCHAFF", 1200);
        apiTGridH.AddColumn("N° Ctr", "NCSTNUM", 1000);
        apiTGridH.AddColumn("Date contrat", "DCSTDAT", 900, "dd/mm/yy");
        apiTGridH.AddColumn("Contrat HT", "NCSTFOR", 1200, "Currency", 2);
        apiTGridH.AddColumn("Facture HT", "FHT", 1200, "Currency", 2);

        apiTGridH.InitColumnList();

        // liste historique contrat sur 12 mois
        apiTGridB.AddColumn("Filiale", "VSOCIETE", 1000);
        apiTGridB.AddColumn("Client", "VCLINOM", 1900, "", 0, true);
        apiTGridB.AddColumn("Site", "VSITNOM", 1900, "", 0, true);
        apiTGridB.AddColumn("Chaff", "VDINCHAFF", 1200);
        apiTGridB.AddColumn("N° Ctr", "NCSTNUM", 1000);
        apiTGridB.AddColumn("Date contrat", "DCSTDAT", 900, "dd/mm/yy");
        apiTGridB.AddColumn("Contrat HT", "NCSTFOR", 1200, "Currency", 2);
        apiTGridB.AddColumn("Facture HT", "FHT", 1200, "Currency", 2);

        apiTGridB.InitColumnList();
      }
      catch (Exception ex)
      {
        MZUtils.displayError(MethodBase.GetCurrentMethod().Name, ex);
      }
    }
    private void InitApiGridDoc()
    {
      try
      {
        apiTGrid2.AddColumn("NSTFGRPNUM", "NSTFGRPNUM", 0);
        apiTGrid2.AddColumn("Statut", "VLIBSTATUT", 1100);
        apiTGrid2.AddColumn("Nb ctrts", "NBCST", 1000);
        apiTGrid2.AddColumn("CA STT", "NSTFGRPCA", 1300, "# ### ##0 €", 1);
        apiTGrid2.AddColumn("CA emalec 12 mois", "NSTFGRPFA", 1300, "# ### ##0 €", 1);
        apiTGrid2.AddColumn("Dépendance %", "TAUX", 800, "##0.##", 1);
        apiTGrid2.AddColumn("Kbis", "DOC1", 1100);
        apiTGrid2.AddColumn("RC", "DOC2", 1100);
        apiTGrid2.AddColumn("Décennale", "DOC3", 1100);
        apiTGrid2.AddColumn("Sociale", "DOC4", 1100);
        apiTGrid2.AddColumn("Fiscale", "DOC5", 1100);
        apiTGrid2.AddColumn("Fluides", "DOC9", 1250);
        apiTGrid2.AddColumn("Conf & NC", "DOC10", 1200);
        apiTGrid2.AddColumn("CSTFGRPSANSDOC", "CSTFGRPSANSDOC", 0);  // pas de gestion des docs adm du STT

        apiTGrid2.InitColumnList();
      }
      catch (Exception ex)
      {
        MZUtils.displayError(MethodBase.GetCurrentMethod().Name, ex);
      }
    }

    private void apiTGrid2_RowCellStyle(object sender, DevExpress.XtraGrid.Views.Grid.RowCellStyleEventArgs e)
    {
      // pas de gestion des couleurs si STT sans gestion des docs Admin
      if (e.RowHandle >= 0 && (sender as GridView).GetDataRow(e.RowHandle)["CSTFGRPSANSDOC"].ToString() == "O")
        return;

      // gestion spécifique des couleurs
      if (e.RowHandle >= 0 && (e.Column.Name == "DOC1" || e.Column.Name == "DOC2" || e.Column.Name == "DOC3" ||
          e.Column.Name == "DOC4" || e.Column.Name == "DOC5")) //|| e.Column.Name == "DOC10"))
      {
        if (e.CellValue != DBNull.Value)
        {
          if (Convert.ToDateTime(e.CellValue) < DateTime.Now)
            e.Appearance.BackColor = MozartColors.ColorH80FFFF; //'Périmé
          if (Convert.ToDateTime(e.CellValue) >= DateTime.Now)
            e.Appearance.BackColor = MozartColors.ColorH80FF80; //OK
        }
        else
          e.Appearance.BackColor = MozartColors.colorHFFC0FF; // Non conforme
      }
      // gestion spécifique pour l'attestation fluide frigo
      if (e.RowHandle >= 0 && (e.Column.Name == "DOC9"))
      {  // si stt clim, alors doc obligatoire et gestion de la couleur
        if ((sender as GridView).GetDataRow(e.RowHandle)["FF"].ToString() != "0")
        {
          if (e.CellValue != DBNull.Value)
          {
            if (Convert.ToDateTime(e.CellValue) < DateTime.Now)
              e.Appearance.BackColor = MozartColors.ColorH80FFFF; //'Périmé
            if (Convert.ToDateTime(e.CellValue) >= DateTime.Now)
              e.Appearance.BackColor = MozartColors.ColorH80FF80; //OK
          }
          else
            e.Appearance.BackColor = MozartColors.colorHFFC0FF; // Non conforme
        }
      }
    }
	}
}