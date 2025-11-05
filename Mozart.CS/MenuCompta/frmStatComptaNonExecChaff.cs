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
  public partial class frmStatComptaNonExecChaff : Form
  {
    public string sDate;
    public string sCpt;
    public string mstrsChaff;

    DataTable dtH = new DataTable();
    public frmStatComptaNonExecChaff() { InitializeComponent(); }
    /*--------------------------------------------------------------*/
    private void frmStatComptaNonExecChaff_Load(object sender, System.EventArgs e)
    {
      try
      {
        Cursor.Current = Cursors.WaitCursor;
        ModuleMain.Initboutons(this);

        lblDate.Text += " " + sDate;
        lblCpt.Text += " " + sCpt;

        LoadApiGrid();
        InitapiGridH();
      }
      catch (Exception ex)
      {
        MZUtils.displayError(MethodBase.GetCurrentMethod().Name, ex);
      }
      finally { Cursor.Current = Cursors.Default; }
    }

    private void cmdDI_Click(object sender, EventArgs e)
    {
      DataRow row = apiTGridH.GetFocusedDataRow();
      if (row == null) return;

      //écran de modification de la demande
      MozartParams.NumDi = (int)Utils.ZeroIfBlank(row["NDINNUM"]);
      MozartParams.NumAction = (int)Utils.ZeroIfBlank(row["NACTNUM"]);

      new frmAddAction()
      {
        mstrStatutDI = "M",
      }.ShowDialog();

      //On revient donc on réinitialise les variables globales
      MozartParams.NumDi = 0;
      MozartParams.NumAction = 0;
    }

    private void cmdVisuH_Click(object sender, EventArgs e)
    {
      try
      {
        DataRow row = apiTGridH.GetFocusedDataRow();
        if (row == null) return;

        string[,] TdbGlobal = { { "Copie", "ORIGINAL" },
                              { "Num", "2"},
                              { "Titre", $"ENCOURS CLIENTS au {sDate}, en AVANCE. ({sCpt})"},
                              { "Date", DateTime.Now.ToShortDateString()},
                              { "NB", dtH.Rows.Count.ToString()},
                              { "DateR", sDate},
                              { "LIB", "FC-facture client"} };

        new frmBrowser()
        {
          miPlanningAn = 0,
        }.Preview_Print(MozartParams.CheminModeles + MozartParams.Langue + @"\TEtatComptable.rtf",
                        @"TEtatComptableOut.rtf",
                        TdbGlobal,
                        $"exec api_sp_ListeEtatComptaNonExecChaff '{sDate} 22:00:00', {sCpt}, {mstrsChaff}",
                        " (Impression consultation)",
                        "PREVIEW");
      }
      catch (Exception ex)
      {
        MZUtils.displayError(MethodBase.GetCurrentMethod().Name, ex);
      }
    }

    private void LoadApiGrid()
    {
      //création d'une commande
      apiTGridH.LoadData(dtH, MozartDatabase.cnxMozart, $"api_sp_ListeEtatComptaNonExecChaff '{sDate} 22:00:00', {sCpt}, {mstrsChaff}");
      apiTGridH.GridControl.DataSource = dtH;

      int total = 0;
      //liste des recettes
      foreach (DataRow row in dtH.Rows)
      {
        total += Convert.ToInt32(Utils.ZeroIfNull(row["NACTVAL"]));
      }
      lblTHTh.Text = total + " €";

      //DataRow row = apiTGridH.GetFocusedDataRow();
      //if (row != null)
      //  lblTHTh.Text = Strings.FormatNumber(-1 * Utils.ZeroIfNull(row["total"]), 0) + " €";
    }


    private void InitapiGridH()
    {
      apiTGridH.AddColumn(Resources.col_DI, "NDINNUM", 650);
      apiTGridH.AddColumn(Resources.col_Nact, "NACTNUM", 0);
      apiTGridH.AddColumn("Act", "NACTID", 500);
      apiTGridH.AddColumn(MZCtrlResources.col_Client, "VCLINOM", 1500);
      apiTGridH.AddColumn(Resources.col_Chaff, "VPERNOM", 1300);
      apiTGridH.AddColumn(Resources.col_cte, "NDINCTE", 700);
      apiTGridH.AddColumn(MZCtrlResources.col_libelle, "VACTDES", 6000);
      apiTGridH.AddColumn(Resources.col_etat, "CACTSTA", 700, "", 2); //attention c'est le cetacod
      apiTGridH.AddColumn(Resources.col_Date, "DACTDEX", 1100);
      apiTGridH.AddColumn(Resources.col_Fact, "DFACDAT", 1000, "dd/mm/yy");
      apiTGridH.AddColumn(Resources.col_euroHT, "NACTVAL", 1000, "0.00", 1);

      apiTGridH.FilterBar = true;
      apiTGridH.InitColumnList();
    }

    private void cmdLegende_Click(object sender, EventArgs e)
    {
      Frame4.Visible = true;
    }

    private void Command1_Click(object sender, EventArgs e)
    {
      Frame4.Visible = false;
    }
    private void cmdFermer_Click(object sender, System.EventArgs e)
    {
      Dispose();
    }

  }
}

