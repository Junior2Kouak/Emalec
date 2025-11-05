using Microsoft.VisualBasic;
using MozartCS.Properties;
using MozartNet;
using MozartLib;
using ReportEmalec.Net;
using System;
using System.Data;
using System.Data.SqlClient;
using System.Diagnostics;
using System.IO;
using System.Reflection;
using System.Windows.Forms;
using MZUtils = MozartControls.Utils;

namespace MozartCS
{
  public partial class frmGestPers : Form
  {
    DataTable dtPer = new DataTable();
    bool bTrombi;

    public frmGestPers() { InitializeComponent(); }

    private void frmGestPers_Load(object sender, System.EventArgs e)
    {
      try
      {
        Cursor.Current = Cursors.WaitCursor;
        ModuleMain.Initboutons(this);

        MozartParams.NomSocieteTemp = MozartParams.NomSociete;
        apiSocieteAuto1.Init(MozartDatabase.cnxMozart, MozartParams.NomSocieteTemp);

        string lStrReq = $"exec api_sp_ListePersonnel2 '{MozartParams.NomSociete}','O',0,{apiSocieteAuto1.IdMenuParent}";
        apiGrid.LoadData(dtPer, MozartDatabase.cnxMozart, lStrReq);
        apiGrid.GridControl.DataSource = dtPer;
        InitApigrid();

        Cursor = Cursors.Default;
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

    private void apiGrid_SelectionChanged(object sender, DevExpress.Data.SelectionChangedEventArgs e)
    {
      DataRow currentRow = apiGrid.GetFocusedDataRow();

      if (currentRow != null)
      {

        //couleur des boutons
        using (SqlDataReader sdr = ModuleData.ExecuteReader($"exec api_sp_InfoDocPerso {currentRow["NPERNUM"]}"))
        {
          if (sdr.Read())
          {
            cmdDocPerso.BackColor = Utils.ZeroIfNull(sdr["PERSO"]) == 0 ? MozartColors.ColorH8000000F : MozartColors.ColorH80FFFF;
            CmdDocPersoSecu.BackColor = Utils.ZeroIfNull(sdr["PERSOSECU"]) == 0 ? MozartColors.ColorH8000000F : MozartColors.ColorH80FFFF;
          }
        }
      }
    }

    private void CmdDocPersoSecu_Click(object sender, EventArgs e)
    {
      openFicPerso("PERSOSECU");
    }

    private void cmdDocPerso_Click(object sender, EventArgs e)
    {
      openFicPerso("PERSO");
    }

    private void openFicPerso(string pTypeDoc)
    {
      DataRow currentRow = apiGrid.GetFocusedDataRow();
      if (currentRow == null) return;

      if (Utils.ZeroIfNull(currentRow["NPERNUM"]) == 0) return;

      // gestion des documents non sensibles
      new frmListeFicPerso
      {
        msLibNomSoc = Utils.BlankIfNull(currentRow["VSOCIETE"]),
        mstrNomPerso = Utils.BlankIfNull(currentRow["VPERNOM"]),
        mstrPrenomPerso = Utils.BlankIfNull(currentRow["VPERPRE"]),
        mlIdPerso = Convert.ToInt64(Utils.ZeroIfNull(currentRow["NPERNUM"])),
        mstrTypePerso = pTypeDoc
      }.ShowDialog();
    }

    private void apiSocieteAuto1_Change(object sender, EventArgs e)
    {
      if (apiGrid.dgv.Columns.Count < 4) return;
      if (apiSocieteAuto1.ListIndex != -1) MozartParams.NomSocieteTemp = apiSocieteAuto1.Text;

      //condition permettant d'afficher la colonne VSOCIETE si sélection GROUPE
      if (MozartParams.NomSocieteTemp.ToUpper() == "GROUPE") apiGrid.dgv.Columns[2].Visible = true;
      else apiGrid.dgv.Columns[2].Visible = false;

      apiGrid.LoadData(dtPer, MozartDatabase.cnxMozart, $"exec api_sp_ListePersonnel2 '{MozartParams.NomSocieteTemp}','O',0,{apiSocieteAuto1.IdMenuParent}");
      apiGrid.GridControl.DataSource = dtPer;
    }

    private void cmdAbsences_Click(object sender, EventArgs e)
    {
      Cursor = Cursors.WaitCursor;
      new frmGestPerAbsences
      {
        mLibNomSoc = MozartParams.NomSocieteTemp,
        mnIdMenuParent = apiSocieteAuto1.IdMenuParent
      }.ShowDialog();

      Cursor = Cursors.Default;
    }

    private void CmdLangue_Click(object sender, EventArgs e)
    {
      if (dtPer.Rows.Count == 0) return;
      DataRow currentRow = apiGrid.GetFocusedDataRow();
      if (currentRow == null) return;

      new frmLanguePers
      {
        msLibNomSoc = Utils.BlankIfNull(currentRow["VSOCIETE"].ToString())
      }.ShowDialog();
    }

    private void cmdInfo_Click(object sender, EventArgs e)
    {

      try
      {
        // ons ort si pas de personne
        DataRow currentRow = apiGrid.GetFocusedDataRow();
        if (currentRow == null || dtPer.Rows.Count == 0) return;

        Cursor = Cursors.WaitCursor;

        new frmSaisieInfos
        {
          mstrTypeNote = "INFO_TECH",
          miCleTable = Convert.ToInt64(Utils.ZeroIfNull(currentRow["npernum"]))
        }.ShowDialog();

        Cursor = Cursors.Default;
      }
      catch (Exception ex)
      {
        Cursor = Cursors.Default;
        MZUtils.displayError(MethodBase.GetCurrentMethod().Name, ex);
      }
    }

    private void cmdModifier_Click(object sender, EventArgs e)
    {
      if (dtPer.Rows.Count == 0) return;

      DataRow currentRow = apiGrid.GetFocusedDataRow();
      if (currentRow == null) return;

      new frmDetailPersonnel
      {
        mFormParent = this.Name,
        mstrLibNomSoc = Utils.BlankIfNull(currentRow["VSOCIETE"].ToString()),
        mstrStatut = "M",
        miNumPer = Convert.ToInt32(Utils.ZeroIfNull(currentRow["npernum"]))
      }.ShowDialog();
    }

    private void cmdNouvelle_Click(object sender, EventArgs e)
    {
      if (MozartParams.NomSocieteTemp == "GROUPE")
      {
        MessageBox.Show(Resources.msg_selectionnerSociete, Program.AppTitle, MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
        return;
      }
      new frmDetailPersonnel
      {
        mFormParent = this.Name,
        mstrStatut = "C",
        miNumPer = 0
      }.ShowDialog();
    }

    private void CmdTrombino_Click(object sender, EventArgs e)
    {
      int i = 0;

      if (MozartParams.NomSocieteTemp == "GROUPE")
      {
        MessageBox.Show(Resources.msg_selectionnerSociete, Program.AppTitle, MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
        return;
      }

      if (dtPer.Rows.Count == 0) return;

      lstPerso.Items.Clear();
      //on charge la liste
      foreach (DataRow row in dtPer.Rows)
      {
        lstPerso.Items.Add(row["VPERNOM"].ToString() + " " + row["VPERPRE"].ToString());
        i++;
      }
      lstPerso.SelectedIndex = -1;
      bTrombi = true;
      FrmLstPerTrombi.Visible = true;
    }

    string TrombiText = "";
    private void Command2_Click(object sender, EventArgs e)
    {
      if (MozartParams.NomSocieteTemp == "GROUPE")
      {
        MessageBox.Show(Resources.msg_selectionnerSociete, Program.AppTitle, MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
        return;
      }
      if (dtPer.Rows.Count == 0) return;

      lstPerso.Items.Clear();
      TrombiText = CmdVisuTrombi.Text;
      CmdVisuTrombi.Text = "Génération fichier";
      //on charge la liste
      int i = 0;
      foreach (DataRow row in dtPer.Rows)
      {
        lstPerso.Items.Add(row["VPERNOM"].ToString() + " " + row["VPERPRE"].ToString());
        i++;
      }
      lstPerso.SelectedIndex = -1;
      bTrombi = false;
      FrmLstPerTrombi.Visible = true;
    }
    
    private void CmdVisuTrombi_Click(object sender, EventArgs e)
    {
      try
      {
        //gestion des cas de visu du trombi ou bien du cas de l'édition des cartes d'habilitation
        if (bTrombi)
        {
          string nQUI = "";
          for (int i = 0; i <= lstPerso.Items.Count - 1; i++)
          {
            if (lstPerso.GetItemChecked(i) == true)
            {
              string[] ttemp = lstPerso.Items[i].ToString().Split(' ');
              int itemp = Convert.ToInt32(ModuleData.ExecuteScalarInt($"select NPERNUM from TPER where VPERNOM = '{ttemp[0]}' AND VPERPRE = '{ttemp[1]}' AND VSOCIETE = '{MozartParams.NomSocieteTemp}'"));
              nQUI += itemp + ",";
            }
          }
          if (nQUI == "")
          {
            MessageBox.Show(Resources.msg_selectAuMin1Perso, Program.AppTitle, MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
            return;
          }
          else
            nQUI = Strings.Left(nQUI, nQUI.Length - 1);

          new frmBrowser
          {
            msStartingAddress = GenerateTrombi(MozartParams.NomSocieteTemp, nQUI)
          }.ShowDialog();
        }
        else
        {
          Cursor = Cursors.WaitCursor;

          //supprimer tous les pdf
          SuppressionFichiersPdfRepertoire(MozartParams.CheminUtilisateurMozart + @"PDF\");

          //génération des pdf
          foreach (var item in lstPerso.CheckedItems)
          {
            string[] ttemp = item.ToString().Split(' ');
            int itemp = Convert.ToInt32(ModuleData.ExecuteScalarInt($"select NPERNUM from TPER where VPERNOM = '{ttemp[0]}' AND VPERPRE = '{ttemp[1]}' AND VSOCIETE = '{MozartParams.NomSocieteTemp}'"));
            new frmMainReport
            {
              bLaunchByProcessStart = false,
              sTypeReport = "TCARTE",
              sIdentifiant = itemp.ToString(),
              sNomSociete = MozartParams.NomSociete,
              sLangue = "FR",
              sOption = "PDF"
            }.ShowDialog();

            //vérification de la présence du fichier pdf

            //renomage du fichier
            File.Move($@"{MozartParams.CheminUtilisateurMozart}PDF\{itemp}.pdf", $@"{MozartParams.CheminUtilisateurMozart}PDF\Carte habilitation-{item}.pdf");
          }

          //assembler les pdf
          AssemblagePDF_V3($@"{MozartParams.CheminUtilisateurMozart}PDF\", $"PJ{DateTime.Now.ToShortDateString().Replace("/", "")}");

          //Pause 1
          Cursor = Cursors.Default;
          MessageBox.Show($@"le fichier PJ{DateTime.Now.ToShortDateString().Replace("/", "")} a été généré dans 'Mes documents\Mozart\pdf\'", Program.AppTitle, MessageBoxButtons.OK, MessageBoxIcon.Information);
        }
      }
      catch (Exception ex)
      {
        Cursor = Cursors.Default;
        MZUtils.displayError(MethodBase.GetCurrentMethod().Name, ex);
      }
    }

    private void CmdFermerFrame_Click(object sender, EventArgs e)
    {
      FrmLstPerTrombi.Visible = false;
      if (TrombiText != "") CmdVisuTrombi.Text = TrombiText;
    }

    private void cmdComptecli_Click(object sender, EventArgs e)
    {
      try
      {
        if (dtPer.Rows.Count == 0) return;
        //si ce n'est pas un CA on sort
        DataRow currentRow = apiGrid.GetFocusedDataRow();
        if (currentRow == null) return;
        if (currentRow["CPERTYP"].ToString() != "CA")
          MessageBox.Show(Resources.msg_pasChargeAffaires, Program.AppTitle, MessageBoxButtons.OK, MessageBoxIcon.Information);
        else
        {
          new frmGestComptePer
          {
            msLibNomSoc = Utils.BlankIfNull(currentRow["VSOCIETE"].ToString()),
            mstrPersonne = Utils.BlankIfNull(currentRow["VPERNOM"].ToString()),
            miNumPersonne = Convert.ToInt32(Utils.ZeroIfNull(currentRow["NPERNUM"]))
          }.ShowDialog();
        }

      }
      catch (Exception ex)
      {
        MZUtils.displayError(MethodBase.GetCurrentMethod().Name, ex);
      }
    }

    private void cmdDroits_Click(object sender, EventArgs e)
    {
      if (dtPer.Rows.Count == 0) return;
      DataRow currentRow = apiGrid.GetFocusedDataRow();
      if (currentRow == null) return;
      new frmGestDroitAnalytiqueByPer(currentRow["VSOCIETE"].ToString()).ShowDialog();
    }

    private void Command1_Click(object sender, EventArgs e)
    {
      DataRow currentRow = apiGrid.GetFocusedDataRow();
      if (dtPer.Rows.Count == 0 || currentRow == null) return;
      new FrmGestionDroitFournitures(currentRow["NPERNUM"].ToString()).ShowDialog();
    }

    private void cmdWeb_Click(object sender, EventArgs e)
    {
      try
      {
        DataRow currentRow = apiGrid.GetFocusedDataRow();
        if (dtPer.Rows.Count == 0 || currentRow == null) return;

        new frmGestWebPer
        {
          msLibNomSoc = Utils.BlankIfNull(currentRow["VSOCIETE"].ToString()),
          miNumPersonne = Convert.ToInt32(Utils.ZeroIfNull(currentRow["NPERNUM"])),
          msTypePer = "T"
        }.ShowDialog();

      }
      catch (Exception ex)
      {
        MZUtils.displayError(MethodBase.GetCurrentMethod().Name, ex);
      }
    }

    private void cmdSupprimer_Click(object sender, EventArgs e)
    {
      try
      {
        DataRow currentRow = apiGrid.GetFocusedDataRow();
        if (dtPer.Rows.Count == 0 || currentRow == null) return;

        // on ne peut archiver qui si date de sortie
        if (Utils.DateBlankIfNull(currentRow["DPERSOR"]) == "")
        {
          MessageBox.Show(Resources.msg_pasArchiverEmployeSansDatSor, Program.AppTitle, MessageBoxButtons.OK, MessageBoxIcon.Information);
          return;
        }

        //test sur le technicien pour savoir si on peut archiver ou pas
        // si il reste des planifications ou des actions non soldées on ne peut pas l'archiver
        int temp = Convert.ToInt32(ModuleData.ExecuteScalarInt($"api_sp_OKArchivage {currentRow["NPERNUM"]}"));

        if (temp == 0)
        {
          if (MessageBox.Show(Resources.msg_ask_to_archive_this_person, Program.AppTitle, MessageBoxButtons.YesNo, MessageBoxIcon.Question,
                              MessageBoxDefaultButton.Button2) == DialogResult.Yes)
            ModuleData.SupprimerEnreg(Convert.ToInt64(currentRow["NPERNUM"]), "api_sp_ArchiverPersonne", "@iNumPer");
          apiGrid.Requery(dtPer, MozartDatabase.cnxMozart);
        }
        else
          MessageBox.Show(Resources.msg_ArchPersonneActionNonSoldee + "\n\n\t" + Resources.msg_chargeAffaire, Program.AppTitle, MessageBoxButtons.OK, MessageBoxIcon.Information);
      }
      catch (Exception ex)
      {
        MZUtils.displayError(MethodBase.GetCurrentMethod().Name, ex);
      }
    }

    private void cmdArchive_Click(object sender, EventArgs e)
    {
      new frmGestPersArch
      {
        mIdMenuParentPerArch = apiSocieteAuto1.IdMenuParent
      }.ShowDialog();
      apiGrid.Requery(dtPer, MozartDatabase.cnxMozart);
    }
    
    private void cmdConges_Click(object sender, EventArgs e)
    {
      new frmChoixTriPlaConges
      {
        msLibNomSoc = MozartParams.NomSocieteTemp,
        miIdMenuParent = apiSocieteAuto1.IdMenuParent
      }.ShowDialog();
    }
    
    private void cmdImplantation_Click(object sender, EventArgs e)
    {
      DataRow currentRow = apiGrid.GetFocusedDataRow();
      if (currentRow == null) return;

      frmBrowser f = new frmBrowser();
      f.mbcmdFicheTech = true;
      f.mstrType = "";

      string temp = "";
      if (MozartParams.NomSocieteTemp == "GROUPE")
        temp = currentRow["VSOCIETE"].ToString();
      else
        temp = MozartParams.NomSocieteTemp;
      f.msStartingAddress = $"https://maps.emalec.com/Techniciens.asp?BASE=MULTI&APP={temp}";

      f.ShowDialog();
      f.mbcmdFicheTech = false;
    }

    private void InitApigrid()
    {
      try
      {
        apiGrid.AddColumn(Resources.col_Nom, "VPERNOM", 1300);
        apiGrid.AddColumn(Resources.col_Prenom, "VPERPRE", 1100);
        apiGrid.AddColumn(Resources.col_Societe, "VSOCIETE", 1000);
        apiGrid.AddColumn(Resources.col_Civ, "CPERCIV", 700);
        apiGrid.AddColumn(Resources.col_Type, "VTYPEDETAILLIB", 1200);
        apiGrid.AddColumn("Catégorie", "VPERCATEGORIE", 1200);
        apiGrid.AddColumn(Resources.col_NumPersonne, "NPERNUM", 500);
        apiGrid.AddColumn(Resources.col_Service, "VSERLIB", 1500);
        apiGrid.AddColumn(Resources.col_Dep, "VDEPLIB", 1500);
        apiGrid.AddColumn(Resources.col_Age, "Age", 500);
        apiGrid.AddColumn(Resources.col_Contrat, "VTYPECONTRATSAL", 600);
        apiGrid.AddColumn(Resources.col_Anc, "Anc", 500);
        apiGrid.AddColumn(Resources.col_D_entree, "DPERENT", 1000, "dd/mm/yy");
        apiGrid.AddColumn(Resources.col_D_entree_int, "DPERENTINT", 1000, "dd/mm/yy");
        apiGrid.AddColumn(Resources.col_Adresse1, "VPERAD1", 1700);
        apiGrid.AddColumn(Resources.col_Adresse2, "VPERAD2", 900);
        apiGrid.AddColumn(Resources.col_CP, "VPERCP", 700);
        apiGrid.AddColumn(Resources.col_Ville, "VPERVIL", 1200);
        apiGrid.AddColumn(Resources.col_clients, "VCLINOMPOSTE", 1200);
        apiGrid.AddColumn(Resources.col_Site, "VSITNOMPOSTE", 1200);
        apiGrid.AddColumn(Resources.col_Telephone, "VPERTEL", 1400);
        apiGrid.AddColumn(Resources.col_Portable, "VPERPOR", 1400);
        apiGrid.AddColumn(Resources.col_Adresse_mail, "VPERMAI", 1800);
        apiGrid.AddColumn("Mailing", "CAUTORISATION", 1100, "", 2);
        apiGrid.AddColumn(Resources.col_D_naiss, "DPERNAI", 1000, "dd/mm/yy");
        apiGrid.AddColumn(Resources.col_D_sortie, "DPERSOR", 1000, "dd/mm/yy");
        apiGrid.AddColumn(Resources.col_College, "VPERCOL", 800);
        apiGrid.AddColumn(Resources.col_Niv, "VPERNIV", 500, "", 2);
        apiGrid.AddColumn(Resources.col_echel, "VPERECH", 500, "", 2);
        apiGrid.AddColumn(Resources.col_Cat, "VPERCAT", 500, "", 2);
        apiGrid.AddColumn(Resources.col_Coeff, "VPERCOE", 600);
        apiGrid.AddColumn(Resources.col_H_mois, "NPERHEU", 600);
        apiGrid.AddColumn(Resources.col_Salaire_brut, "NPERSAL", 1200, "Currency", 1);
        apiGrid.AddColumn("Nb mois", "NPERNBMOIS", 800, "", 1);
        apiGrid.AddColumn("Prime contrat", "PRIMECC", 1200, "Currency", 1);
        apiGrid.AddColumn("Prime hors contrat", "PRIMENONCC", 1200, "Currency", 1);
        apiGrid.AddColumn("Sal. Annuel", "NPERSALANNUEL", 1200, "Currency", 1);
        apiGrid.AddColumn(Resources.col_Cout_Hor, "NPERCOU", 800, "Currency", 1);
        apiGrid.AddColumn(Resources.col_vehicule, "VLIBTYPEVEH", 1200);
        apiGrid.AddColumn(Resources.col_Visite_medicale, "DPERVIS", 1000, "dd/mm/yy");
        apiGrid.AddColumn("Proch. Vis. Médic.", "DPERINF", 1000, "dd/mm/yy");
        apiGrid.AddColumn("RQTH", "DPERHAB", 1000, "dd/mm/yy");
        apiGrid.AddColumn("Restrictions", "DPERRAPPEL", 1000, "dd/mm/yy");
        apiGrid.AddColumn("Titre de séjour", "DPEREXPCARDSEJ", 1000, "dd/mm/yy");
        apiGrid.AddColumn(Resources.col_D_avance, "DPERAVF", 1000, "dd/mm/yy");
        apiGrid.AddColumn(Resources.col_E_avance, "NPERMAV", 1100, "Currency", 1);
        apiGrid.AddColumn("Fin validité prêt", "DPERPERMIS", 1000, "dd/mm/yy");
        apiGrid.AddColumn(Resources.col_Code_std, "NPERSTD", 700, "", 2);
        apiGrid.AddColumn(Resources.col_Permis, "VPERPERMI", 700, "", 2);
        apiGrid.AddColumn(Resources.col_manicuplationFluideFrigo, "BPERMANIPFLUIDE", 700);
        apiGrid.AddColumn(Resources.col_Actif, "CPERACTIF", 0);
        apiGrid.AddColumn(Resources.col_numSecu, "VPERNUMSECU", 1200);
        apiGrid.AddColumn("RRET", "RRET", 700);
        apiGrid.AddColumn("Contremaitre", "CTRMTR", 700);
        apiGrid.AddColumn("Tuteur", "VTUTEUR", 700);
        apiGrid.AddColumn("Planificateur", "VPLANIFICATEUR", 700);
        apiGrid.AddColumn(Resources.col_groupe, "LIBGROUPE", 700);
        apiGrid.AddColumn(Resources.col_paysNaiss, "VPERCOMNAISS", 700);
        apiGrid.AddColumn(Resources.col_Poste, "BPOSTE", 600);
        apiGrid.AddColumn("Ticket Restaurant", "BPER_TICK_REST", 700);
        apiGrid.AddColumn("Email Pro.", "VPERMAILPRO", 1200);
        apiGrid.AddColumn("Entretien annuel", "DPERENTRETANNUELLAST", 1000, "dd/mm/yy");
        apiGrid.AddColumn("Entretien pro.", "DPERENTRETANNUELPRO", 1000, "dd/mm/yy");
        apiGrid.AddColumn("Bilan entretien pro.", "DPERBILANENTRETANNUELPRO", 1000, "dd/mm/yy");

                apiGrid.dgv.Columns[2].Visible = false;
        apiGrid.dgv.OptionsView.ColumnAutoWidth = false;
        apiGrid.InitColumnList();
      }
      catch (Exception ex)
      {
        MZUtils.displayError(MethodBase.GetCurrentMethod().Name, ex);
      }
    }
  
    private string GenerateTrombi(string sNomSocieteParam, string sCritere)
    {
      try
      {
        // Init
        int iIndex = 1;
        string SHTMLBody = "<HTML><HEAD><meta http-equiv=\"Content-Type\" content=\"text/html; charset=UTF-8\" /></HEAD><style type='text/css'><!--.dkgd { background: white; color: #000000; font-family: arial; font-weight: normal; " +
                           "font-size: 10px; }//--></style><BODY><TABLE border='0'><TR>";

        DataTable dt = new DataTable();
        var dataReader = ModuleData.ExecuteReader($"EXEC api_sp_LstPerTrombino '{sNomSocieteParam}','{sCritere }'");
        dt.Load(dataReader);
        dataReader.Close();

        if (dt.Rows.Count > 0)
        {
          SHTMLBody += $"<CENTER><H3>Edition d'un trombinoscope ({dt.Rows.Count} employés sélectionnés)<H3></CENTER>";

          foreach (DataRow row in dt.Rows)
          {
            SHTMLBody += "<TD>";
            SHTMLBody += @"<TABLE border='1' style='font-family:""Centhury Gothic"", CenturyGothic, sans-serif; font-size:12px'>";
            SHTMLBody += "<TR>";
            SHTMLBody += $"<TD><CENTER><IMG SRC='{row["IMAGERTF"]}' WIDTH='90' HEIGHT='120' BORDER='0' ALT=''></CENTER></TD>";
            SHTMLBody += "</TR>";
            SHTMLBody += "<TR>";
            SHTMLBody += $"<TD WIDTH='160px'><CENTER>{row["VPERNOM"]}</CENTER></TD>";
            SHTMLBody += "</TR>";
            SHTMLBody += "<TR>";
            SHTMLBody += $"<TD WIDTH='160px'><CENTER>{row["VPERPRE"]}</CENTER></TD>";
            SHTMLBody += "</TR>";
            SHTMLBody += "<TR>";
            SHTMLBody += $"<TD WIDTH='160px'><CENTER>{row["VTYPELIB"]}</CENTER></TD>";
            SHTMLBody += "</TR>";
            SHTMLBody += "<TR>";
            SHTMLBody += $"<TD WIDTH='160px'><CENTER>{row["VPERSER"]}</CENTER></TD>";
            SHTMLBody += "</TR>";
            SHTMLBody += "<TR>";
            SHTMLBody += $"<TD WIDTH='160px'><CENTER>{row["VPERDEP"]}</CENTER></TD>";
            SHTMLBody += "</TR>";
            SHTMLBody += "<TR>";
            SHTMLBody += $"<TD WIDTH='160px'><CENTER>{row["DPERENT"]}</CENTER></TD>";
            SHTMLBody += "</TR>";
            SHTMLBody += "</TABLE>";
            SHTMLBody += "</TD>";

            if (iIndex % 6 == 0)
            {
              SHTMLBody += "</TR>";
              SHTMLBody += "<TR>";
            }
            iIndex++;
          }
          SHTMLBody += " </TABLE></BODY></HTML>";
        }

        //sauvegarde dans un fichier
        File.WriteAllText(MozartParams.CheminUtilisateurMozart + @"lsttrombi.html", SHTMLBody);
      }
      catch (Exception ex)
      {
        MZUtils.displayError(MethodBase.GetCurrentMethod().Name, ex);
      }

      return MozartParams.CheminUtilisateurMozart + @"lsttrombi.html";
    }

    private void CmdGestQCM_Click(object sender, EventArgs e)
    {
      new frmQCMAffectPers().ShowDialog();
    }
    
    private void CmdClients_Click(object sender, EventArgs e)
    {
      DataRow currentRow = apiGrid.GetFocusedDataRow();
      if (dtPer.Rows.Count == 0 || currentRow == null) return;

      //seulement les contres maitres et chef de site
      if (currentRow["CPERTYPDETAIL"].ToString() == "CM" || currentRow["CPERTYPDETAIL"].ToString() == "CE")
        new FrmGestTechClient("T", currentRow["NPERNUM"]).ShowDialog();
      else
        MessageBox.Show(Resources.msg_selectContremaitreOUChefSit + " !", Program.AppTitle, MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
    }
    
    public void SuppressionFichiersPdfRepertoire(string rep)
    {
      string[] tFiles = Directory.GetFiles(rep);

      //suppression des fichiers PDF
      foreach (string sfile in tFiles)
      {
        if (Path.GetExtension(sfile).ToUpper() == ".PDF")
          File.Delete(sfile);
      }
    }
    
    public void AssemblagePDF_V3(string rep, string sOutFile)
    {
      if (!File.Exists(rep + "pdftk.exe"))
      {
        MessageBox.Show(Resources.msg_utilitaireAssemblageNonDispo, Program.AppTitle, MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
        return;
      }

      Process p = new Process();
      p.StartInfo.FileName = "pdftk.exe";
      p.StartInfo.WorkingDirectory = rep;
      p.StartInfo.Arguments = $"*.pdf cat output {sOutFile}.pdf";
      p.Start();
      p.WaitForExit();
    }
  }
}