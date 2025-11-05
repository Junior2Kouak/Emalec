using MZCtrlResources = MozartControls.Properties.Resources;
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
  public partial class frmAidePlanif : Form
  {
    public long miSite;
    public string msClient;
    public string msSite;
    public string msStatut;
    public DateTime mdDate;
    public string msAction;
    public string msTypeAction;
    public string msCP;
    public string msVille;
    public string msNomTech;

    DataTable dtAct = new DataTable();
    DataTable dtSite = new DataTable();
    DataTable dtCP = new DataTable();
    DataTable dtVille = new DataTable();
    DataTable dtKM = new DataTable();
    DataTable dtDest = new DataTable();
    DataTable dtSTF = new DataTable();
    DataTable dtInter50km = new DataTable();
    DataTable dtTech = new DataTable();
    string sRsActif;

    //variables pour frmDetailsTravaux
    public int miLocTech;
    public bool mbOptInter0;
    public bool mbOptInter1;
    public bool mbOptInter2;
    public string msTxtDate1;

    bool bInit = false;


    public frmAidePlanif() { InitializeComponent(); }

    private void frmAidePlanif_Load(object sender, System.EventArgs e)
    {
      try
      {
        Cursor.Current = Cursors.WaitCursor;
        ModuleMain.Initboutons(this);

        Label5.Text = $"{msClient}-{msSite}";
        txtAction.Text = msAction;
        Frame1.Text = $"{Frame1.Text} ({msCP})";

        //Partie Tech Proches
        sRsActif = "rsTech";

        using (SqlDataReader sdrTech = ModuleData.ExecuteReader($"exec api_sp_Map_DiffLatLon {miSite}"))
        {
          if (!sdrTech.Read())
          {
            grdTechProch.Visible = false;
            Label1.Text = "§Localisation du site impossible§";
            Label1.Top = 1000;
          }
          else
          {
            grdTechProch.LoadData(dtTech, MozartDatabase.cnxMozart, $"exec api_sp_Map_DiffLatLon {miSite}");
            grdTechProch.GridControl.DataSource = dtTech;
            InitapiGridTech();
          }

          // gestion de visu ou modification
          if (msStatut == "Visu")
            cmdChoixTech.Visible = cmdChoixCP.Visible = cmdChoixVille.Visible = cmdChoixSite.Visible = cmdChoixST.Visible = cmdChoixDept.Visible = cmdChoixKm.Visible = false;
          else
            cmdChoixTech.Visible = cmdChoixCP.Visible = cmdChoixVille.Visible = cmdChoixSite.Visible = cmdChoixST.Visible = cmdChoixDept.Visible = cmdChoixKm.Visible = true;

          // gestion de préventif ou autre
          if (msTypeAction == "Préventif" && Utils.IsDate(mdDate.ToShortDateString()))
          {
            lblDate.Text = mdDate.ToShortDateString();
            mdDate = Convert.ToDateTime(mdDate.AddDays(-15).ToShortDateString());
          }
          else
          {
            mdDate = Convert.ToDateTime(DateTime.Now.ToShortDateString());
            lblDate.Text = DateTime.Now.ToShortDateString();
          }

          cmdRechSite_Click(null, null);
          cmdRechCP_Click(null, null);
          cmdRechVille_Click(null, null);
          cmdRechKM_Click(null, null);
          cmdRechDep_Click(null, null);
          cmdRechST_Click(null, null);
          Command1_Click(null, null);
        }
      }
      catch (Exception ex)
      {
        MZUtils.displayError(MethodBase.GetCurrentMethod().Name, ex);
      }
      finally { Cursor.Current = Cursors.Default; }
    }

    private void cmdQuitter_Click(object sender, System.EventArgs e)
    {
      Dispose();
      miLocTech = 0;
    }


    /* OK --------------------------------------------------------------------------------------- */
    private void cmdCircuit_Click(object sender, EventArgs e)
    {
      new frmBrowser()
      {
        mddate = Convert.ToDateTime(mdDate.ToShortDateString()),
        mstrType = "",
        minpernum = 0,
        msStartingAddress = $@"https://maps.emalec.com/RechercheTechnicienProcheSite.asp?BASE=MULTI&APP={MozartParams.NomSociete}&Jour={mdDate.ToShortDateString()}&NSITNUM={miSite}&NACTNUM={MozartParams.NumAction}"
      }.ShowDialog();

      //string msStartingAddress = $@"https://maps.emalec.com/RechercheTechnicienProcheSite.asp?BASE=MULTI&APP={MozartParams.NomSociete}&Jour={mdDate.ToShortDateString()}&NSITNUM={miSite}&NACTNUM={MozartParams.NumAction}";

      //Process.Start("msedge.exe", msStartingAddress.Replace(" ", "%20"));

    }

    private void cmdRechSite_Click(object sender, EventArgs e)
    {
      apigridSite.LoadData(dtSite, MozartDatabase.cnxMozart, $"api_sp_RecherchePassageTechSite {miSite},'{mdDate}'");
      apigridSite.GridControl.DataSource = dtSite;
      InitApigridSite();
    }


    /* OK  --------------------------------------------------------------------------------------- */
    private void cmdRechCP_Click(object sender, EventArgs e)
    {
      apigridCP.LoadData(dtCP, MozartDatabase.cnxMozart, $"api_sp_RecherchePassageTechCP {miSite},'{mdDate}'");
      apigridCP.GridControl.DataSource = dtCP;
      InitapiGridCP();
    }


    /* OK  --------------------------------------------------------------------------------------- */
    private void cmdRechVille_Click(object sender, EventArgs e)
    {
      // Partie Recherche par ville
      apigridVille.LoadData(dtVille, MozartDatabase.cnxMozart, $"api_sp_RecherchePassageTechVille {miSite},'{mdDate}'");
      apigridVille.GridControl.DataSource = dtVille;
      InitapiGridVille();
    }


    /* OK --------------------------------------------------------------------------------------- */
    private void cmdRechKM_Click(object sender, EventArgs e)
    {
      // Partie Recherche à 10 km
      apigridKm.LoadData(dtKM, MozartDatabase.cnxMozart, $"api_sp_RecherchePassageTech10Km {miSite},'{mdDate}'");
      apigridKm.GridControl.DataSource = dtKM;
      InitapiGridKm();
    }


    /* OK --------------------------------------------------------------------------------------- */
    private void cmdRechDep_Click(object sender, EventArgs e)
    {
      //Partie Recherche par Département
      apigridDept.LoadData(dtDest, MozartDatabase.cnxMozart, $"api_sp_RecherchePassageTechDept {miSite},'{mdDate}'");
      apigridDept.GridControl.DataSource = dtDest;
      InitapiGridDept();
    }


    /* OK --------------------------------------------------------------------------------------- */
    private void cmdRechST_Click(object sender, EventArgs e)
    {
      // Partie Recherche par sous traitant
      apigridST.LoadData(dtSTF, MozartDatabase.cnxMozart, $"api_sp_RecherchePassageSTSite {miSite}");
      apigridST.GridControl.DataSource = dtSTF;
      InitapiGridSTF();
    }


    /* OK --------------------------------------------------------------------------------------- */
    private void Command1_Click(object sender, EventArgs e)
    {
      // Partie Recherche par sous traitant
      ApiGrid1.LoadData(dtInter50km, MozartDatabase.cnxMozart, $"[api_sp_RechercheInterAttentePlanifSite50kms] {miSite}");
      ApiGrid1.GridControl.DataSource = dtInter50km;
      InitapiGridrsInter50kms();
      bInit = true;
    }


    /* OK --------------------------------------------------------------------------------------- */
    private void InitapiGridrsInter50kms()
    {
      try
      {
        if (bInit == false)
        {
          ApiGrid1.AddColumn(MZCtrlResources.col_Client, "VCLINOM", 1500);
          ApiGrid1.AddColumn(Resources.col_Site, "VSITNOM", 1500);
          ApiGrid1.AddColumn(Resources.col_nDI, "NDINNUM", 900);
          ApiGrid1.AddColumn(Resources.col_NAction, "NACTID", 400);
          ApiGrid1.AddColumn(Resources.col_Date_S, "DACTDAT", 900, "dd/MM/yy");
          ApiGrid1.AddColumn(Resources.col_distanceKM, "NBKMS", 500, "", 2);
          ApiGrid1.AddColumn(Resources.col_Action, "VACTDES", 5700);

          ApiGrid1.InitColumnList();
        }
      }
      catch (Exception ex)
      {
        MZUtils.displayError(MethodBase.GetCurrentMethod().Name, ex);
      }
    }


    /* OK  --------------------------------------------------------------------------------------- */
    private void cmdChoixTech_Click(object sender, EventArgs e)
    {
      if (sRsActif == "rsTech")
      {
        DataRow currentRow = grdTechProch.GetFocusedDataRow();
        if (currentRow == null) return;
        mbOptInter0 = true;
        //passage de l'id du tech
        msNomTech = Utils.BlankIfNull(currentRow["tech"]);
        miLocTech = (int)Utils.ZeroIfNull(currentRow["NPERNUM"]);
      }
      //dtAct jamais utilisé + sRsActif toujours = à "rsTech"
      Dispose();
    }

    private void cmdChoixSite_Click(object sender, EventArgs e)
    {
      DataRow currentRow = apigridSite.GetFocusedDataRow();
      if (currentRow == null) return;

      mbOptInter0 = true;
      msNomTech = Utils.BlankIfNull(currentRow["VPERNOM"]);
      miLocTech = (int)Utils.ZeroIfNull(currentRow["NPERNUM"]);
      msTxtDate1 = Utils.BlankIfNull(currentRow["DACTPLA"]);

      Dispose();
    }


    /* OK --------------------------------------------------------------------------------------- */
    private void cmdChoixCP_Click(object sender, EventArgs e)
    {
      DataRow currentRow = apigridCP.GetFocusedDataRow();
      if (currentRow == null) return;

      mbOptInter0 = true;
      msNomTech = Utils.BlankIfNull(currentRow["VPERNOM"]);
      miLocTech = (int)Utils.ZeroIfNull(currentRow["NPERNUM"]);
      msTxtDate1 = Utils.BlankIfNull(currentRow["DACTPLA"]);
      Dispose();
    }


    /* OK --------------------------------------------------------------------------------------- */
    private void cmdChoixVille_Click(object sender, EventArgs e)
    {
      DataRow currentRow = apigridVille.GetFocusedDataRow();
      if (currentRow == null) return;

      mbOptInter0 = true;
      msNomTech = Utils.BlankIfNull(currentRow["VPERNOM"]);
      miLocTech = (int)Utils.ZeroIfNull(currentRow["NPERNUM"]);
      msTxtDate1 = Utils.BlankIfNull(currentRow["DACTPLA"]);

      Dispose();
    }


    /* OK --------------------------------------------------------------------------------------- */
    private void cmdChoixDept_Click(object sender, EventArgs e)
    {
      DataRow currentRow = apigridDept.GetFocusedDataRow();
      if (currentRow == null) return;

      mbOptInter0 = true;
      msNomTech = Utils.BlankIfNull(currentRow["VPERNOM"]);
      miLocTech = (int)Utils.ZeroIfNull(currentRow["NPERNUM"]);
      msTxtDate1 = Utils.BlankIfNull(currentRow["DACTPLA"]);
      Dispose();
    }


    /* OK --------------------------------------------------------------------------------------- */
    private void cmdChoixST_Click(object sender, EventArgs e)
    {
      DataRow currentRow = apigridST.GetFocusedDataRow();
      if (currentRow == null) return;

      if (Convert.ToInt32(Utils.BlankIfNull(currentRow["NSTFGRPTYPMNT"])) == 1) //Sous traitant maintenance prioritaire sur sous traitant instalation si STF est les 2 à la fois.
      {
        mbOptInter1 = true;
      }
      else
      {
        mbOptInter2 = true;
      }
      msNomTech = Utils.BlankIfNull(currentRow["VSTFNOM"]);
      miLocTech = (int)Utils.ZeroIfNull(currentRow["NSTFNUM"]);
      msTxtDate1 = Utils.BlankIfNull(currentRow["DACTPLA"]);
      Dispose();
    }

    /* OK --------------------------------------------------------------------------------------- */
    private void InitapiGridTech()
    {
      try
      {
        grdTechProch.AddColumn(Resources.col_Tech, "Tech", 2000);
        grdTechProch.AddColumn("CP", "VPERCP", 0);
        grdTechProch.AddColumn(Resources.col_Ville, "VPERVIL", 0);
        grdTechProch.AddColumn(Resources.col_paysPer, "VPERPAYS", 0);
        grdTechProch.AddColumn(Resources.col_cpSit, "VSITCP", 0);
        grdTechProch.AddColumn(Resources.col_villeSit, "VSITVIL", 0);
        grdTechProch.AddColumn(Resources.col_paysSit, "VSITPAYS", 0);
        grdTechProch.AddColumn("NPERNUM", "NPERNUM", 0);
        grdTechProch.AddColumn(Resources.col_latlon, "DiffLatLon", 0);
        grdTechProch.AddColumn(Resources.col_DistApprox, "RacineDiffLatLon", 1300, "", 2);

        grdTechProch.btnExcel.Visible = grdTechProch.btnPrint.Visible = grdTechProch.chkColumnsList.Visible = false;
        grdTechProch.FilterBar = grdTechProch.FooterBar = false;
      }
      catch (Exception ex)
      {
        MZUtils.displayError(MethodBase.GetCurrentMethod().Name, ex);
      }
    }

    private void InitapiGridCP()
    {
      try
      {
        apigridCP.AddColumn(Resources.col_Technicien, "VPERNOM", 1500);
        apigridCP.AddColumn(Resources.col_Date_P, "DACTPLA", 900, "dd/mm/yy");
        apigridCP.AddColumn(Resources.col_Nbj, "NBJOURS", 500, "", 2);
        apigridCP.AddColumn(MZCtrlResources.col_Client, "VCLINOM", 1200);
        apigridCP.AddColumn(Resources.col_Site, "VSITNOM", 1200);
        apigridCP.AddColumn(Resources.col_Action, "VACTDES", 5700);
        apigridCP.AddColumn("numper", "NPERNUM", 0);

        apigridCP.InitColumnList();
      }
      catch (Exception ex)
      {
        MZUtils.displayError(MethodBase.GetCurrentMethod().Name, ex);
      }
    }

    private void InitapiGridVille()
    {
      try
      {
        apigridVille.AddColumn(Resources.col_Technicien, "VPERNOM", 1500);
        apigridVille.AddColumn(Resources.col_Date_P, "DACTPLA", 900, "dd/mm/yy");
        apigridVille.AddColumn(Resources.col_Nbj, "NBJOURS", 500, "", 2);
        apigridVille.AddColumn(MZCtrlResources.col_Client, "VCLINOM", 1200);
        apigridVille.AddColumn(Resources.col_Site, "VSITNOM", 1200);
        apigridVille.AddColumn(Resources.col_Action, "VACTDES", 5100);
        apigridVille.AddColumn("NumPer", "NPERNUM", 0);

        apigridVille.InitColumnList();
      }
      catch (Exception ex)
      {
        MZUtils.displayError(MethodBase.GetCurrentMethod().Name, ex);
      }
    }

    /* OK --------------------------------------------------------------------------------------- */
    private void InitapiGridDept()
    {
      try
      {
        apigridDept.AddColumn(Resources.col_Technicien, "VPERNOM", 1500);
        apigridDept.AddColumn(Resources.col_Date_P, "DACTPLA", 900, "dd/mm/yy");
        apigridDept.AddColumn(Resources.col_Nbj, "NBJOURS", 500, "", 2);
        apigridDept.AddColumn(MZCtrlResources.col_Client, "VCLINOM", 1200);
        apigridDept.AddColumn(Resources.col_Site, "VSITNOM", 1200);
        apigridDept.AddColumn(Resources.col_Action, "VACTDES", 5900);
        apigridDept.AddColumn("NumPer", "NPERNUM", 0);

        apigridDept.InitColumnList();
      }
      catch (Exception ex)
      {
        MZUtils.displayError(MethodBase.GetCurrentMethod().Name, ex);
      }
    }

    private void InitApigridSite()
    {
      try
      {
        apigridSite.AddColumn(Resources.col_Technicien, "VPERNOM", 1900);
        apigridSite.AddColumn(Resources.col_Date_P, "DACTPLA", 900, "dd/mm/yy");
        apigridSite.AddColumn(Resources.col_Nbj, "NBJOURS", 600, "", 2);
        apigridSite.AddColumn(Resources.col_Action, "VACTDES", 8100);
        apigridSite.AddColumn(Resources.col_NumTech, "NPERNUM", 0);

        apigridSite.InitColumnList();
      }
      catch (Exception ex)
      {
        MZUtils.displayError(MethodBase.GetCurrentMethod().Name, ex);
      }
    }


    /* OK  --------------------------------------------------------------------------------------- */
    private void InitapiGridSTF()
    {
      try
      {
        apigridST.AddColumn(Resources.col_SousTraitant, "VSTFNOM", 1900);
        apigridST.AddColumn(Resources.col_Date_P, "DACTPLA", 900, "dd/mm/yy");
        apigridST.AddColumn(Resources.col_Nbj, "", 500, "", 2);
        apigridST.AddColumn(Resources.col_Action, "VACTDES", 6800);
        apigridST.AddColumn("NumSTF", "NSTFNUM", 0);

        apigridST.InitColumnList();
      }
      catch (Exception ex)
      {
        MZUtils.displayError(MethodBase.GetCurrentMethod().Name, ex);
      }
    }

    private void InitapiGridKm()
    {
      try
      {
        apigridKm.AddColumn(Resources.col_Technicien, "VPERNOM", 1500);
        apigridKm.AddColumn(Resources.col_Date_P, "DACTPLA", 900, "dd/mm/yy");
        apigridKm.AddColumn(Resources.col_Nbj, "NBJOURS", 500, "", 2);
        apigridKm.AddColumn(MZCtrlResources.col_Client, "VCLINOM", 1200);
        apigridKm.AddColumn(Resources.col_Site, "VSITNOM", 1200);
        apigridKm.AddColumn(Resources.col_distance, "Distance", 900);
        apigridKm.AddColumn(Resources.col_Action, "VACTDES", 4900);
        apigridKm.AddColumn("NumPer", "NPERNUM", 0);

        apigridKm.InitColumnList();
      }
      catch (Exception ex)
      {
        MZUtils.displayError(MethodBase.GetCurrentMethod().Name, ex);
      }
    }

    private void cmdChoixKm_Click(object sender, EventArgs e)
    {
      DataRow currentRow = apigridKm.GetFocusedDataRow();
      if (currentRow == null) return;

      mbOptInter0 = true;
      msNomTech = Utils.BlankIfNull(currentRow["VPERNOM"]);
      miLocTech = (int)Utils.ZeroIfNull(currentRow["NPERNUM"]);
      msTxtDate1 = Utils.BlankIfNull(currentRow["DACTPLA"]);

      Dispose();
    }

  }
}