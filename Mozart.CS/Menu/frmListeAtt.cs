using MozartCS.Properties;
using MozartLib;
using MozartNet;
using ReportEmalec.Net;
using System;
using System.Data;
using System.Reflection;
using System.Windows.Forms;
using MZUtils = MozartControls.Utils;


namespace MozartCS
{
  public partial class frmListeAtt : Form
  {
    public int miNumClient;
    public string msNomClient;

    DataTable dt = new DataTable();


    public frmListeAtt() { InitializeComponent(); }


    private void frmListeAtt_Load(object sender, System.EventArgs e)
    {
      try
      {
        Cursor.Current = Cursors.WaitCursor;
        ModuleMain.Initboutons(this);

        LblTitre.Text += " " + msNomClient;

        // Init de la comboBox
        // chargement des types d'attestation
        cmbTypeAtt.Items.Clear();
        cmbTypeAtt.Items.Add(Resources.txt_controleElectrique);
        cmbTypeAtt.Items.Add(Resources.txt_controleEtancheiteGaz);
        cmbTypeAtt.Items.Add(Resources.txt_controleExtincteurs);
        cmbTypeAtt.Items.Add(Resources.txt_maintenanceClim);
        cmbTypeAtt.Items.Add(Resources.txt_maintenanceDesenfumage);
        cmbTypeAtt.Items.Add(Resources.txt_maintennaceDetectionIncendie);
        cmbTypeAtt.Items.Add(Resources.txt_prevChauffage);
        cmbTypeAtt.Items.Add(Resources.txt_preventiveRamonage);
        cmbTypeAtt.Items.Add(Resources.txt_installationExtincteur);
        cmbTypeAtt.Items.Add(Resources.txt_maintenanceMultitech);
        cmbTypeAtt.Items.Add(Resources.txt_verifRideauxMet);
        cmbTypeAtt.Items.Add("Maintenance porte automatique");

        InitApigrid();
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


    private void InitApigrid()
    {
      apiTGrid1.AddColumn(Resources.col_Number, "NUM", 1500);
      apiTGrid1.AddColumn(Resources.col_Site, "VSITNOM", 3500);
      apiTGrid1.AddColumn(Resources.col_Num_site, "NSITNUE", 1500);
      apiTGrid1.AddColumn(Resources.col_Region, "VSITREG", 3500);
      apiTGrid1.AddColumn(Resources.col_Date, "DDATE", 800);

      apiTGrid1.InitColumnList();
      apiTGrid1.GridControl.DataSource = dt;
    }

    private void cmdEnregistrer_Click(object sender, EventArgs e)
    {
      DataRow currentRow = apiTGrid1.GetFocusedDataRow();
      if (currentRow == null) return;

      string sSelectProdStock = "";

      switch (cmbTypeAtt.SelectedIndex)
      {
        case 0:
          //sSelectProdStock = $"exec api_sp_EditionCTREL {currentRow["NSITNUM"]},{miNumClient},{currentRow["NACTNUM"]}";
          sSelectProdStock = "CTRLE";
          break;
        case 1:
          //sSelectProdStock = $"exec api_sp_EditionATETANCHGAZ {currentRow["NSITNUM"]},{miNumClient},{currentRow["NACTNUM"]},'{MozartParams.Langue}'";
          sSelectProdStock = "CTRLE";
          break;
        case 2:
          //sSelectProdStock = $"exec api_sp_EditionATEXTPREV {currentRow["NSITNUM"]},{miNumClient},{currentRow["NACTNUM"]},'{MozartParams.Langue}'";
          sSelectProdStock = "CTRLE";
          break;
        case 3:
          //sSelectProdStock = $"exec api_sp_EditionATCLIM {currentRow["NSITNUM"]},{miNumClient},{currentRow["NACTNUM"]}";
          sSelectProdStock = "CLIM";
          break;
        case 4:
          //sSelectProdStock = $"exec api_sp_EditionATDesEnf {currentRow["NSITNUM"]},{miNumClient},{currentRow["NACTNUM"]}";
          sSelectProdStock = "DESENF";
          break;
        case 5:
          //sSelectProdStock = $"exec api_sp_EditionATDetInc {currentRow["NSITNUM"]},{miNumClient},{currentRow["NACTNUM"]}";
          sSelectProdStock = "DETINC";
          break;
        case 6:
          //sSelectProdStock = $"exec api_sp_EditionATCHAUF {currentRow["NSITNUM"]},{miNumClient},{currentRow["NACTNUM"]}";
          sSelectProdStock = "CHAUF";
          break;
        case 7:
          //sSelectProdStock = $"exec api_sp_EditionATRamon {currentRow["NSITNUM"]},{miNumClient},{currentRow["NACTNUM"]}";
          sSelectProdStock = "RAMON";
          break;
        case 8:
          //sSelectProdStock = $"exec api_sp_EditionATEXTTRAV {currentRow["NSITNUM"]},{miNumClient},{currentRow["NACTNUM"]},'{MozartParams.Langue}'";
          sSelectProdStock = "EXTTRAV";
          break;
        case 9:
          //sSelectProdStock = $"exec api_sp_EditionATMULTI {currentRow["NSITNUM"]},{miNumClient},{currentRow["NACTNUM"]},'{MozartParams.Langue}'";
          sSelectProdStock = "MULTI";
          break;
        case 10:
          //sSelectProdStock = $"exec api_sp_EditionATRIDMET {currentRow["NSITNUM"]},{miNumClient},{currentRow["NACTNUM"]},'{MozartParams.Langue}'";
          sSelectProdStock = "RIDMET";
          break;
        case 11:
          //sSelectProdStock = $"exec api_sp_EditionPORTEAUTO {currentRow["NSITNUM"]},{miNumClient},{currentRow["NACTNUM"]}";
          sSelectProdStock = "PORTEAUTO";
          break;
        default:
          break;
      }

      new frmMainReport
      {
        bLaunchByProcessStart = false,
        sTypeReport = "TATTESTATION_GENERIQUE",
        sIdentifiant = $"{sSelectProdStock}|{currentRow["NACTNUM"]}",
        InfosMail = $"TSIT|NSITNUM|{currentRow["NSITNUM"]}",
        sNomSociete = MozartParams.NomSociete,
        sLangue = "FR",
        sOption = "PREVIEW",
        strType = "ATG",
        numAction = (int)currentRow["NACTNUM"]
      }.ShowDialog();


      //string[,] TdbGlobal = { { "", "" } };

      //frmBrowser f = new frmBrowser();
      //f.msInfosMail = $"TCCL|NCLINUM|{miNumClient}";
      //f.Preview_Print($@"{MozartParams.CheminModeles}{MozartParams.Langue}\TAttestationEdition.rtf",
      //                  @"TAttestationEditionOut.rtf",
      //                  TdbGlobal,
      //                  sSelectProdStock,
      //                  " (Visualisation Attestation)",
      //                  "PREVIEW");

    }

    private void cmbTypeAtt_SelectedIndexChanged(object sender, EventArgs e)
    {
      Cursor.Current = Cursors.WaitCursor;

      switch (cmbTypeAtt.SelectedIndex)
      {
        case 0:
          apiTGrid1.LoadData(dt, MozartDatabase.cnxMozart, $"exec api_sp_ListeAtctrEl {miNumClient}");
          break;
        case 1:
          apiTGrid1.LoadData(dt, MozartDatabase.cnxMozart, $"exec api_sp_ListeAtEtanchGaz {miNumClient}");
          break;
        case 2:
          apiTGrid1.LoadData(dt, MozartDatabase.cnxMozart, $"exec api_sp_ListeAtExtPrev {miNumClient}");
          break;
        case 3:
          apiTGrid1.LoadData(dt, MozartDatabase.cnxMozart, $"exec api_sp_ListeAtClim {miNumClient}");
          break;
        case 4:
          apiTGrid1.LoadData(dt, MozartDatabase.cnxMozart, $"exec api_sp_ListeAtDesenf {miNumClient}");
          break;
        case 5:
          apiTGrid1.LoadData(dt, MozartDatabase.cnxMozart, $"exec api_sp_ListeAtDecInc {miNumClient}");
          break;
        case 6:
          apiTGrid1.LoadData(dt, MozartDatabase.cnxMozart, $"exec api_sp_ListeAtChauff {miNumClient}");
          break;
        case 7:
          apiTGrid1.LoadData(dt, MozartDatabase.cnxMozart, $"exec api_sp_ListeAtRamon {miNumClient}");
          break;
        case 8:
          apiTGrid1.LoadData(dt, MozartDatabase.cnxMozart, $"exec api_sp_ListeAtExtTrav {miNumClient}");
          break;
        case 9:
          apiTGrid1.LoadData(dt, MozartDatabase.cnxMozart, $"exec api_sp_ListeAtMulti {miNumClient}");
          break;
        case 10:
          apiTGrid1.LoadData(dt, MozartDatabase.cnxMozart, $"exec api_sp_ListeAtRidMet {miNumClient}");
          break;
        case 11:
          apiTGrid1.LoadData(dt, MozartDatabase.cnxMozart, $"exec api_sp_ListeAtPorteAuto {miNumClient}");
          break;
        default:
          break;
      }

      Cursor.Current = Cursors.Default;
    }

    
  }
}

