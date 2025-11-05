using MozartCS.Properties;
using MozartLib;
using MozartNet;
using MozartUC;
using System;
using System.Data;
using System.Reflection;
using System.Windows.Forms;
using MZUtils = MozartControls.Utils;


namespace MozartCS
{
  public partial class frmGestProcedure : Form
  {
    public int miNumSite;
    public int miNumClient;
    public string mstrType = "";
    public string msTitre = "";

    DataTable dt = new DataTable();
    private byte bActif;
    private string sClauseSql = "";

    public string RepertoireDoc { get; private set; }

    public frmGestProcedure()
    {
      InitializeComponent();
    }

    private void frmGestProcedure_Load(object sender, System.EventArgs e)
    {
      mstrType = mstrType.ToUpper();
      try
      {
        switch (mstrType)
        {
          case "ADMINISTRATIF":
            cmdAjouter.HelpContextID = 365;
            cmdModifier.HelpContextID = 366;
            cmdArchiver.HelpContextID = 367;
            break;
          default:
            cmdAjouter.HelpContextID = 362;
            cmdModifier.HelpContextID = 363;
            cmdArchiver.HelpContextID = 364;
            break;
        }

        ModuleMain.Initboutons(this);

        bActif = 1;
        InitData();
        InitGrid();

        apiTGrid1.LoadData(dt, MozartDatabase.cnxMozart, sClauseSql);
        apiTGrid1.GridControl.DataSource = dt;

        if (miNumClient == 0) cmdWebCont.Visible = false;
      }
      catch (Exception ex)
      {
        MZUtils.displayError(MethodBase.GetCurrentMethod().Name, ex);
      }
    }

    private void InitData()
    {
      switch (mstrType)
      {
        case "PROCEDURE":
          lblTitre.Text = Resources.txt_procedures + msTitre;
          Text = Resources.txt_gest_proc_client;
          sClauseSql = "[api_sp_listeProcedure] " + miNumClient + ", " + miNumSite + ", 6, '" + MozartParams.Langue + "', " + bActif;
          cmdWebCont.Visible = false;
          RepertoireDoc = Utils.RechercheParam("REP_INFO");
          break;

        case "PROCEDURESITE":
          lblTitre.Text = Resources.txt_procedures + msTitre;
          Text = "Gestion des procédures site";
          sClauseSql = "[api_sp_listeProcedure] " + miNumClient + ", " + miNumSite + ", 1, '" + MozartParams.Langue + "', " + bActif;
          cmdWebCont.Visible = false;
          RepertoireDoc = Utils.RechercheParam("REP_INFO");
          break;

        case "PLANPREVCLIENT":
          lblTitre.Text = Resources.Plans_de_prévention + msTitre;
          Text = Resources.Plans_de_prévention + msTitre;
          sClauseSql = "[api_sp_listeProcedure] " + miNumClient + ", " + miNumSite + ", 7, '" + MozartParams.Langue + "', " + bActif;
          cmdWebCont.Visible = false;
          RepertoireDoc = Utils.RechercheParam("REP_INFO");
          break;

        case "PLANPREVSITE":
          lblTitre.Text = msTitre;
          Text = msTitre;
          sClauseSql = "[api_sp_listeProcedure] " + miNumClient + ", " + miNumSite + ", 8, '" + MozartParams.Langue + "', " + bActif;
          cmdWebCont.Visible = false;
          RepertoireDoc = Utils.RechercheParam("REP_INFO");
          break;

        case "ADMINISTRATIF":
          lblTitre.Text = Resources.txt_doc_admin + MozartParams.NomSociete;
          Text = Resources.txt_gestion_doc_admin + MozartParams.NomSociete;
          sClauseSql = "[api_sp_listeProcedure] " + miNumClient + ", " + miNumSite + ", 3, '" + MozartParams.Langue + "', " + bActif;
          cmdWebCont.Visible = false;
          RepertoireDoc = Utils.RechercheParam("REP_FICHE_ADMIN");
          break;

        case "PREVENTIONCONTRAT":
          lblTitre.Text = Resources.Plans_de_prévention + msTitre;
          Text = Resources.txt_gestion_doc_admin_web;
          sClauseSql = "[api_sp_listeProcedure] " + miNumClient + ", " + miNumSite + ", 2, '" + MozartParams.Langue + "', " + bActif;
          RepertoireDoc = Utils.RechercheParam("REP_INFO");
          cmdWebCont.Visible = true;
          break;

        case "PLANPREVDI":
          lblTitre.Text = "Plan de prévention " + msTitre;
          Text = "Gestion des plans de prévention";
          sClauseSql = "[api_sp_listeProcedureDI] " + MozartParams.NumDi + ", '" + MozartParams.Langue + "', " + bActif;
          RepertoireDoc = Utils.RechercheParam("REP_INFO");
          break;

        default:
          break;
      }

      MozartUcUtils.SpyLog(MozartDatabase.cnxMozart, Text, CmdListeArch.Text, "SELECT", "NCLINUM:" + miNumClient, "NNUMSIT:" + miNumSite, "TYPE:" + lblTitre.Text);
    }

    private void cmdAjouter_Click(object sender, EventArgs e)
    {
      if (mstrType == "PROCEDURE" || mstrType == "PROCEDURESITE" || mstrType == "ADMINISTRATIF" || mstrType == "PREVENTIONCONTRAT" || mstrType == "PLANPREVDI")
      {
        new frmDetailsProcedure(0, mstrType, miNumClient, miNumSite, RepertoireDoc).ShowDialog();

        apiTGrid1.Requery(dt, MozartDatabase.cnxMozart);
      }
      else
      {
        if (mstrType == "PLANPREVSITE" || mstrType == "PLANPREVCLIENT")
        {
          new frmDetailPlanPrevClient(0, mstrType, miNumClient, miNumSite, RepertoireDoc)
          {
            msTitre = this.Text
          }.ShowDialog();

          apiTGrid1.Requery(dt, MozartDatabase.cnxMozart);
        }
      }
    }
    private void CmdModifier_Click(object sender, EventArgs e)
    {
      if (apiTGrid1.GetFocusedDataRow() == null) return;

      if (mstrType == "PROCEDURE" || mstrType == "PROCEDURESITE" || mstrType == "PREVENTIONCONTRAT" || mstrType == "ADMINISTRATIF" || mstrType == "PLANPREVDI")
      {
        new frmDetailsProcedure
        {
          mlProc = Convert.ToInt64(apiTGrid1.GetFocusedDataRow()["NIDPROC"]),
          miNumClient = miNumClient,
          miNumSite = miNumSite,
          msTitre = msTitre,
          mstrType = mstrType,
          mstrRepFichier = RepertoireDoc
        }.ShowDialog();

        apiTGrid1.Requery(dt, MozartDatabase.cnxMozart);
      }
      else
      {
        if (mstrType == "PLANPREVSITE" || mstrType == "PLANPREVCLIENT")
        {
          new frmDetailPlanPrevClient
          {
            mlProc = Convert.ToInt64(apiTGrid1.GetFocusedDataRow()["NIDPROC"]),
            miNumClient = miNumClient,
            miNumSite = miNumSite,
            msTitre = msTitre,
            mstrType = mstrType,
            mstrRepFichier = RepertoireDoc
          }.ShowDialog();

          apiTGrid1.Requery(dt, MozartDatabase.cnxMozart);
        }
      }
    }

    private void CmdVisu_Click(object sender, EventArgs e)
    {
      try
      {
        if (apiTGrid1.GetFocusedDataRow() == null) return;

        new frmBrowser
        {
          msStartingAddress = CImpersonation.OpenFileImpersonated(RepertoireDoc + apiTGrid1.GetFocusedDataRow()["VFICHIER"].ToString())
        }.ShowDialog();
      }
      catch (Exception ex)
      {
        MZUtils.displayError(MethodBase.GetCurrentMethod().Name, ex);
      }
    }

    private void cmdWebCont_Click(object sender, EventArgs e)
    {
      if (apiTGrid1.GetFocusedDataRow() == null) return;

      new frmSaisieWebContrat
      {
        miNCLINUM = miNumClient
      }.ShowDialog();
    }

    private void cmdArchiver_Click(object sender, EventArgs e)
    {
      if (apiTGrid1.GetFocusedDataRow() == null) return;

      if (MessageBox.Show(Resources.msg_confirm_document_archive, Program.AppTitle, MessageBoxButtons.YesNo, MessageBoxIcon.Question,
       MessageBoxDefaultButton.Button2) == DialogResult.Yes)
      {
        if (mstrType == "PROCEDURE" || mstrType == "PROCEDURESITE" || mstrType == "ADMINISTRATIF" || mstrType == "PREVENTIONCONTRAT" ||
            mstrType == "PLANPREVDI" || mstrType == "PLANPREVSITE" || mstrType == "PLANPREVCLIENT")
        {
          ModuleData.ExecuteNonQuery("EXEC api_sp_ProcedureArchiver " + apiTGrid1.GetFocusedDataRow()["NIDPROC"].ToString());
          MozartUcUtils.SpyLog(MozartDatabase.cnxMozart, Text, cmdArchiver.Text, "ARCHIVE", "NIDPROC:" + apiTGrid1.GetFocusedDataRow()["NIDPROC"].ToString());
        }

        apiTGrid1.Requery(dt, MozartDatabase.cnxMozart);
      }
    }

    private void CmdListeArch_Click(object sender, EventArgs e)
    {
      if (bActif == 1)
        bActif = 0;
      else
        bActif = 1;

      //afficage des boutons
      if (bActif == 0)
      {
        cmdAjouter.Visible = false;
        cmdArchiver.Visible = false;
        cmdWebCont.Visible = false;
        CmdListeArch.Text = "Liste actifs";
      }
      else
      {
        cmdAjouter.Visible = ModuleMain.RechercheDroitMenu(cmdAjouter.HelpContextID);
        cmdModifier.Visible = ModuleMain.RechercheDroitMenu(cmdModifier.HelpContextID);
        cmdArchiver.Visible = ModuleMain.RechercheDroitMenu(cmdArchiver.HelpContextID);
        CmdListeArch.Text = "Liste archives";
      }

      InitData();
      apiTGrid1.LoadData(dt, MozartDatabase.cnxMozart, sClauseSql);
    }

    private void InitGrid()
    {
      switch (mstrType)
      {
        case "PROCEDURE":
        case "PROCEDURESITE":
          apiTGrid1.AddColumn(Resources.col_Num, "NIDPROC", 800);
          apiTGrid1.AddColumn(Resources.col_Date, "DATECRE", 1000, "dd / mm / yy", 2);
          apiTGrid1.AddColumn(Resources.col_Type_procedure, "VTYPPROCLIB", 1200);
          apiTGrid1.AddColumn(Resources.col_Titre, "VTITRE", 3000);
          break;

        case "PLANPREVSITE":
        case "PLANPREVCLIENT":
        case "PREVENTIONCONTRAT":
          apiTGrid1.AddColumn(Resources.col_Num, "NIDPROC", 800);
          apiTGrid1.AddColumn(Resources.col_Titre, "VTITRE", 3000);
          apiTGrid1.AddColumn(Resources.col_Date_Document, "DATECRE", 1000, "dd / mm / yy", 2);
          apiTGrid1.AddColumn(Resources.col_date_debut_libelle, "DPROCDEBUT", 1000, "dd / mm / yy", 2);
          apiTGrid1.AddColumn(Resources.col_date_fin_libelle, "DPROCECHEANCE", 1000, "dd / mm / yy", 2);
          break;

        case "ADMINISTRATIF":
          apiTGrid1.AddColumn(Resources.col_Num, "NIDPROC", 800);
          apiTGrid1.AddColumn(Resources.col_Date, "DATECRE", 1000, "dd / mm / yy", 2);
          apiTGrid1.AddColumn(Resources.col_Type_document, "VTYPPROCLIB", 1200);
          apiTGrid1.AddColumn(Resources.col_Titre, "VTITRE", 3000);
          apiTGrid1.AddColumn("Langue", "VLANGUE", 1000);
          break;

        case "PLANPREVDI":
          apiTGrid1.AddColumn(Resources.col_Num, "NIDPROC", 800);
          apiTGrid1.AddColumn(Resources.col_Date, "DATECRE", 1000, "dd / mm / yy", 2);
          apiTGrid1.AddColumn(Resources.col_Type_document, "VTYPPROCLIB", 1200);
          apiTGrid1.AddColumn(Resources.col_Titre, "VTITRE", 3000);
          break;

        default:
          break;
      }
    }
  }
}
