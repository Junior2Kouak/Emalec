using MozartCS.Properties;
using MozartLib;
using MozartNet;
using System;
using System.Data;
using System.Reflection;
using System.Windows.Forms;
using MZUtils = MozartControls.Utils;
using MZCtrlResources = MozartControls.Properties.Resources;


namespace MozartCS
{
  public partial class frmStatComptaChargeChaff : Form
  {
    public string mstrType;
    public string mstrDate;
    public string mstrsCpt;
    public string mstrsChaff;


    DataTable dtH = new DataTable();

    public frmStatComptaChargeChaff() { InitializeComponent(); }

    private void frmStatComptaChargeChaff_Load(object sender, System.EventArgs e)
    {
      try
      {
        Cursor.Current = Cursors.WaitCursor;
        ModuleMain.Initboutons(this);

        lblDate.Text += $" {mstrDate}";
        lblCpt.Text += $" {mstrsCpt}";

        if (mstrType == "ST")
        {
          //ENCOURS SOUS-TRAITANTS à la date de référence, en RETARD
          Label3.Text = Resources.txt_encoursSousTraitantsDatRefRetard;
          Frame1.Text = Resources.txt_lstActionsExecDatRefSansFactureSousTraitant;
        }
        else
        {
          //ENCOURS FOURNISSEURS à la date de référence, en RETARD
          Label3.Text = Resources.txt_encoursFournDatRefRetard;
          Frame1.Text = Resources.txt_lstActionExecDateRefFactFour;
        }

        LoadApiGridH();
        InitapiGridH();
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

    private void CmdDI_Click(object sender, EventArgs e)
    {
      DataRow currentRow = apiTGridH.GetFocusedDataRow();
      if (currentRow == null) return;

      // écran de modificiation de la demande
      MozartParams.NumDi = Convert.ToInt32(Utils.BlankIfNull(currentRow["NDINNUM"]));
      MozartParams.NumAction = Convert.ToInt32(Utils.BlankIfNull(currentRow["NACTNUM"]));

      new frmAddAction()
      {
        mstrStatutDI = "M"
      }.ShowDialog();

      //on revient donc on réinitialise les variables globales
      MozartParams.NumDi = 0;
      MozartParams.NumAction = 0;
    }


    private void cmdVisuH_Click(object sender, EventArgs e)
    {
      try
      {
        string sTableau1 = $"ENCOURS SOUS-TRAITANT au {mstrDate}, en RETARD.({mstrsCpt})";
        if (mstrType == "ST") sTableau1 = $"ENCOURS FOURNISSEURS au {mstrDate}, en RETARD.({mstrsCpt})";

        string sTableau2 = "FR-facture ravel ;CST-contrat sous traitant ;DST-devis sous traitant ;FFC-fonction de facture client ;E-estimation";
        if (mstrType == "ST") sTableau2 = "FR-facture ravel ;COM-commande fournisseur";

        string[,] TdbGlobal = { {"Copie","ORIGINAL" },{"Num","2"},{"Titre",sTableau1},{"Date",DateTime.Now.ToShortDateString()},{"NB",dtH.Rows.Count.ToString()},
                {"DateR", mstrDate},{"LIB", sTableau2}};

        frmBrowser f = new frmBrowser();
        f.miPlanningAn = 0;
        if (mstrType == "EMALEC")
        {
          f.Preview_Print($@"{MozartParams.CheminModeles}{MozartParams.Langue}\TEtatComptable.rtf",
                  @"TEtatComptableOut.rtf",
                  TdbGlobal,
                  $"exec api_sp_ListeEtatComptaChargeSTTChaff '{mstrDate} 22:00:00', {mstrsCpt}, {mstrsChaff}",
                  " (Impression consultation)",
                  "PREVIEW");
        }
        else
        {
          f.Preview_Print($@"{MozartParams.CheminModeles}{MozartParams.Langue}\TEtatComptable.rtf",
                  @"TEtatComptableOut.rtf",
                  TdbGlobal,
                  $"exec api_sp_ListeEtatComptaChargeFOUChaff '{mstrDate} 22:00:00', {mstrsCpt}, {mstrsChaff}",
                  " (Impression consultation)",
                  "PREVIEW");
        }
      }
      catch (Exception ex)
      {
        MZUtils.displayError(MethodBase.GetCurrentMethod().Name, ex);
      }
    }

    private void LoadApiGridH()
    {
      Cursor = Cursors.WaitCursor;
      if (mstrType == "ST")
        apiTGridH.LoadData(dtH, MozartDatabase.cnxMozart, $"api_sp_ListeEtatComptaChargeSTTChaff '{mstrDate} 22:00:00',{mstrsCpt},{mstrsChaff}");
      else
        apiTGridH.LoadData(dtH, MozartDatabase.cnxMozart, $"api_sp_ListeEtatComptaChargeFOUChaff '{mstrDate} 22:00:00',{mstrsCpt},{mstrsChaff}");

      apiTGridH.GridControl.DataSource = dtH;

      int total = 0;
      //liste des recettes
      foreach (DataRow row in dtH.Rows)
      {
        total = Convert.ToInt32(Utils.ZeroIfNull(row["TOTAL"]));
      }
      lblTHTh.Text = total + " €";

      Cursor = Cursors.Default;
    }

    private void InitapiGridH()
    {
      try
      {
        if (mstrType == "ST")
        {
          apiTGridH.AddColumn(Resources.col_DI, "NDINNUM", 1000);
          apiTGridH.AddColumn(Resources.col_Action, "NACTID", 600);
          apiTGridH.AddColumn(MZCtrlResources.col_Client, "VCLINOM", 2500);
          apiTGridH.AddColumn(Resources.col_cte, "NDINCTE", 800);
          apiTGridH.AddColumn(Resources.col_Chaff, "VPERNOM", 1200);
          apiTGridH.AddColumn(MZCtrlResources.col_libelle, "VACTDES", 5000, "", 0, true);
          apiTGridH.AddColumn(Resources.col_stt, "VSTFNOM", 2500);
          apiTGridH.AddColumn(Resources.col_ctr, "NCSTNUM", 1500, "", 2);
          apiTGridH.AddColumn(Resources.col_exec, "DACTDEX", 1200);
          apiTGridH.AddColumn("Facturé client", "NELFVAL", 2000, "Currency", 1);
          apiTGridH.AddColumn(Resources.col_Fact, "DFACDAT", 1500);
          //if(mstrsCpt == "0")apiTGridH.AddColumn(Resources.col_cte, "NDINCTE", 800);
        }
        else
        {
          apiTGridH.AddColumn(Resources.col_DI, "NDINNUM", 1000);
          apiTGridH.AddColumn(Resources.col_Action, "NACTID", 600);
          apiTGridH.AddColumn(MZCtrlResources.col_Client, "VCLINOM", 5000, "", 0, true);
          apiTGridH.AddColumn(Resources.col_Chaff, "VPERNOM", 1200);
          apiTGridH.AddColumn(Resources.col_cmde, "NCDENUM", 1000);
          apiTGridH.AddColumn(Resources.col_cte, "NDINCTE", 800);
          apiTGridH.AddColumn(Resources.col_Fournisseur, "VSTFNOM", 3500, "", 0, true);
          apiTGridH.AddColumn(Resources.col_exec, "DACTDEX", 1200);
        }
        apiTGridH.AddColumn("Encours (FNP)", "NACTVAL", 1800, "0.00", 1);
        apiTGridH.AddColumn(Resources.col_Code, "SCODE", 700, "", 2);

        apiTGridH.FilterBar = true;
        apiTGridH.InitColumnList();
      }
      catch (Exception ex)
      {
        MZUtils.displayError(MethodBase.GetCurrentMethod().Name, ex);
      }
    }

    private void cmdLegende_Click(object sender, EventArgs e)
    {
      Frame4.Visible = true;
    }

    private void Command1_Click(object sender, EventArgs e)
    {
      Frame4.Visible = false;
    }

  }
}

