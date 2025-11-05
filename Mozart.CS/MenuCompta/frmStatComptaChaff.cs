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
  public partial class frmStatComptaChaff : Form
  {
    public string mstrType;
    public string mstrDate;
    public string mstrCpt;
    public string mstrsChaff;

    private DataTable dtH = new DataTable();

    private const string PS_ETATCOMPTA_CHAFF = "api_sp_ListeEtatComptaChaff2";
    private const string PS_ETATCOMPTA_NC_CHAFF = "api_sp_ListeEtatComptaNCChaff2";

    public frmStatComptaChaff() { InitializeComponent(); }

    private void frmStatComptaChaff_Load(object sender, System.EventArgs e)
    {
      try
      {
        Cursor.Current = Cursors.WaitCursor;
        ModuleMain.Initboutons(this);

        // titre selon
        if (mstrType == "EMALEC")
        {
          Label3.Text = $"{Resources.txt_encoursClientsDateRefRetard}{MozartParams.NomSociete}.";
          Frame1.Text = Resources.txt_actionExecDatRef + MozartParams.NomSociete;
        }
        else
        {
          Label3.Text = Resources.txt_encoursClientsRetardSTT;
          Frame1.Text = Resources.txt_actionExecDatRefSousTrait;
        }

        lblDate.Text += $" {mstrDate}";
        lblcpt.Text += $" {mstrCpt}";

        LoadApiGridH();
        InitapiGridH();
      }
      catch (Exception ex)
      {
        MZUtils.displayError(MethodBase.GetCurrentMethod().Name, ex);
      }
      finally { Cursor.Current = Cursors.Default; }
    }

    private void CmdDI_Click(object sender, EventArgs e)
    {
      DataRow currentRow = apiTGridH.GetFocusedDataRow();
      if (currentRow == null) return;

      // écran de moficiation de la demande
      frmAddAction f = new frmAddAction
      {
        mstrStatutDI = "M"
      };
      MozartParams.NumDi = Convert.ToInt32(Utils.BlankIfNull(currentRow["NDINNUM"]));
      MozartParams.NumAction = Convert.ToInt32(Utils.BlankIfNull(currentRow["NACTNUM"]));
      f.ShowDialog();

      //on revient donc on réinitialise les variables globales
      MozartParams.NumDi = 0;
      MozartParams.NumAction = 0;
    }

    private void cmdVisuH_Click(object sender, EventArgs e)
    {
      try
      {
        string sTableau1 = $@"ENCOURS CLIENTS au {mstrDate}, en RETARD.({mstrCpt}) \par Prestations réalisées par des sous-traitants.";
        if (mstrType == "EMALEC") sTableau1 = $@"ENCOURS CLIENTS au {mstrDate}, en RETARD.({mstrCpt}) \par Prestations réalisées par des techniciens {MozartParams.NomSociete}.";

        string sTableau2 = "FC-facture client; CC-chiffrage client; DCL-devis client; CST-contrat ST; DST-devis ST; E-estimation";
        if (mstrType == "EMALEC") sTableau2 = "FC-facture client; CC-chiffrage client; DCL-devis client; HD-heure et déplacement(si attachement); E-estimation";

        string[,] TdbGlobal = { {"Copie","ORIGINAL" },{"Num","2"},{"Titre",sTableau1},{"Date",DateTime.Now.ToShortDateString()},{"NB",dtH.Rows.Count.ToString()},
                {"DateR", mstrDate},{"LIB", sTableau2}};

        frmBrowser f = new frmBrowser
        {
          miPlanningAn = 0
        };
        if (mstrType == "EMALEC")
        {
          f.Preview_Print($@"{MozartParams.CheminModeles}{MozartParams.Langue}\TEtatComptable.rtf",
                  @"TEtatComptableOut.rtf",
                  TdbGlobal,
                  $"exec {PS_ETATCOMPTA_CHAFF} '{mstrDate} 22:00:00', {mstrCpt}, {mstrsChaff}",
                  " (Impression consultation)",
                  "PREVIEW");
        }
        else
        {
          f.Preview_Print($@"{MozartParams.CheminModeles}{MozartParams.Langue}\TEtatComptable.rtf",
                  @"TEtatComptableOut.rtf",
                  TdbGlobal,
                  $"exec {PS_ETATCOMPTA_NC_CHAFF} '{mstrDate} 22:00:00', {mstrCpt}, {mstrsChaff}",
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
      if (mstrType == "EMALEC")
        apiTGridH.LoadData(dtH, MozartDatabase.cnxMozart, $"{PS_ETATCOMPTA_CHAFF} '{mstrDate} 22:00:00',{mstrCpt},{mstrsChaff}");
      else
        apiTGridH.LoadData(dtH, MozartDatabase.cnxMozart, $"{PS_ETATCOMPTA_NC_CHAFF} '{mstrDate} 22:00:00',{mstrCpt},{mstrsChaff}");

      apiTGridH.GridControl.DataSource = dtH;

      int total = 0;
      //liste des recettes
      foreach (DataRow row in dtH.Rows)
      {
        total += Convert.ToInt32(Utils.ZeroIfNull(row["NACTVAL"]));
      }
      lblTHTh.Text = total + " €";

      Cursor = Cursors.Default;
    }

    private void InitapiGridH()
    {
      try
      {
        apiTGridH.AddColumn(Resources.col_DI, "NDINNUM", 650);
        apiTGridH.AddColumn("Act", "NACTID", 400);
        apiTGridH.AddColumn(MZCtrlResources.col_Client, "VCLINOM", 1500, "", 0, true);
        apiTGridH.AddColumn(Resources.col_cte, "NDINCTE", 700);
        apiTGridH.AddColumn(Resources.col_Chaff, "CHAFF", 1200, "", 0, true);
        apiTGridH.AddColumn(MZCtrlResources.col_libelle, "VACTDES", 4100, "", 0, true);
        if (mstrType == "EMALEC") apiTGridH.AddColumn(Resources.col_Tech, "VPERNOM", 1500, "", 0, true);
        else apiTGridH.AddColumn(Resources.col_stt, "VSTFNOM", 1500, "", 0, true);
        apiTGridH.AddColumn(Resources.col_exec, "DACTDEX", 1100);
        apiTGridH.AddColumn(Resources.col_etat, "CACTSTA", 700, "", 2);
        apiTGridH.AddColumn("Complément admin", "CETATADMINCPL", 500, "", 2, true);
        apiTGridH.AddColumn(Resources.col_dateCode, "DFACDAT", 1000, "dd/mm/yy");
        apiTGridH.AddColumn(Resources.col_euroHT, "NACTVAL", 1000, "0.00", 1);
        apiTGridH.AddColumn(Resources.col_Code, "SCODE", 700, "", 2);

        apiTGridH.AddColumn(Resources.col_P_restation, "CPRECOD", 700, "", 2);
        apiTGridH.AddColumn("Type de contrat", "VTYPECONTRAT", 1000, "", 2);
        apiTGridH.AddColumn("Type de facturation", "VTREFLIB", 700, "", 2);
        apiTGridH.AddColumn("Période", "NNUMPER", 800, "", 2);

        apiTGridH.InitColumnList();
      }
      catch (Exception ex)
      {
        MZUtils.displayError(MethodBase.GetCurrentMethod().Name, ex);
      }
    }

    private void cmdLegende_Click(object sender, EventArgs e)
    {
      Frame4.Visible = !Frame4.Visible;
    }
  }
}

