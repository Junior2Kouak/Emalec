using MZCtrlResources = MozartControls.Properties.Resources;
using MozartCS.Properties;
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
  public partial class frmListeDevisPourCopie : Form
  {
    public long mNumSite;

    DataTable dt = new DataTable();

    //variables pour frmDetailsTravaux
    public string msStatutAction;

    public frmListeDevisPourCopie() { InitializeComponent(); }

    private void frmListeDevisPourCopie_Load(object sender, System.EventArgs e)
    {
      try
      {
        Cursor.Current = Cursors.WaitCursor;
        ModuleMain.Initboutons(this);

        apiTGrid1.LoadData(dt, MozartDatabase.cnxMozart, "select * from api_v_listeActionDevis order by  VCLINOM, NACTNUM desc");
        apiTGrid1.GridControl.DataSource = dt;

        InitTGrid();
        Cursor.Current = Cursors.Default;

      }
      catch (Exception ex)
      {
        MZUtils.displayError(MethodBase.GetCurrentMethod().Name, ex);
      }
      finally { Cursor.Current = Cursors.Default; }
    }

    private void cmdChoix_Click(object sender, EventArgs e)
    {
      DataRow currentRow = apiTGrid1.GetFocusedDataRow();
      if (currentRow == null) return;

      EnrigistrerActionCopie();

      ModuleData.CnxExecute($"api_sp_creationDevisCLcopie {currentRow["NDCLNUM"]},{MozartParams.NumAction}");

      //on passe la feuille en statut modifier
      msStatutAction = "M";

      Dispose();
    }

    private void cmdVisu_Click(object sender, EventArgs e)
    {
      string sModele;

      DataRow currentRow = apiTGrid1.GetFocusedDataRow();
      if (currentRow == null) return;

      switch (currentRow["CDEVISTYPE"])
      {
        case "F":
        case "P":
          sModele = DetailstravauxUtils.RechercheModeleDevis("F", currentRow["TYPE"].ToString());
          break;

        case "B":
        case "G":
          sModele = "DEVIS_V2";
          break;

        default:
          return;
      }

      new frmMainReport
      {
        bLaunchByProcessStart = false,
        sTypeReport = sModele,
        sIdentifiant = currentRow["NDCLNUM"].ToString(),
        InfosMail = "",
        sNomSociete = MozartParams.NomSociete,
        sLangue = MozartParams.Langue,
        sOption = "PREVIEW",
        strType = "DC", // A Voir, c'est pour les infos mails
        numAction = Convert.ToInt32(currentRow["NACTNUM"])
      }.ShowDialog();
    }

    private void InitTGrid()
    {
      apiTGrid1.AddColumn(Resources.col_motclef, "CLE", 1200);
      apiTGrid1.AddColumn(Resources.col_Action, "VACTDES", 2500, "", 0, true);
      apiTGrid1.AddColumn(Resources.col_Prestation, "TDCLPRE", 1700, "", 0, true);
      apiTGrid1.AddColumn(MZCtrlResources.col_Client, "VCLINOM", 1400, "", 0, true);
      apiTGrid1.AddColumn(Resources.col_Site, "VSITNOM", 1400, "", 0, true);
      apiTGrid1.AddColumn(Resources.col_Date, "DDCLDAT", 1000, "dd/mm/yy", 2);
      apiTGrid1.AddColumn(Resources.col_Montant_THT, "NDCLHT", 1000, "Currency", 1);
      apiTGrid1.AddColumn(Resources.col_NumAction, "NACTNUM", 0);
      apiTGrid1.AddColumn(Resources.col_numdevis, "NDCLNUM", 0);
      apiTGrid1.AddColumn(Resources.col_Type, "TYPE", 0);
      apiTGrid1.AddColumn(Resources.col_sitenum, "NSITNUM", 0);
      apiTGrid1.AddColumn("CDEVISTYPE", "CDEVISTYPE", 0);
      apiTGrid1.AddColumn("VSITEPAYS", "VSITEPAYS", 0);

      apiTGrid1.InitColumnList();
    }

    public void EnrigistrerActionCopie()
    {
      DataRow currentRow = apiTGrid1.GetFocusedDataRow();

      try
      {
        using (SqlDataReader sdrDev = ModuleData.ExecuteReader($"select * from TACT WITH (NOLOCK) WHERE NACTNUM= {currentRow["NACTNUM"]}"))
        {
          if (sdrDev.Read())
          {
            using (SqlCommand cmd = new SqlCommand("api_sp_creationAction", MozartDatabase.cnxMozart))
            {
              cmd.CommandType = CommandType.StoredProcedure;
              SqlCommandBuilder.DeriveParameters(cmd);

              cmd.Parameters["@iDI"].Value = MozartParams.NumDi;
              cmd.Parameters["@iAction"].Value = 0;
              cmd.Parameters["@LibAction"].Value = Utils.BlankIfNull(sdrDev["VACTDES"]);
              cmd.Parameters["@dDateS"].Value = DateTime.Now.AddDays(10).ToShortDateString();
              cmd.Parameters["@iSite"].Value = mNumSite;
              cmd.Parameters["@cUrg"].Value = Utils.BlankIfNull(sdrDev["CURGCOD"]);
              cmd.Parameters["@cprest"].Value = Utils.BlankIfNull(sdrDev["CPRECOD"]);
              cmd.Parameters["@cTech"].Value = Utils.BlankIfNull(sdrDev["CTECCOD"]);
              cmd.Parameters["@cTypeAct"].Value = "A";
              cmd.Parameters["@iDuree"].Value = Utils.ZeroIfNull(sdrDev["NACTDUR"]);
              cmd.Parameters["@iValeur"].Value = Utils.ZeroIfNull(sdrDev["NACTVAL"]);
              cmd.Parameters["@dDateEx"].Value = DBNull.Value;
              cmd.Parameters["@iTech"].Value = DBNull.Value;
              cmd.Parameters["@cTypeInter"].Value = "T";
              cmd.Parameters["@iST"].Value = DBNull.Value;
              cmd.Parameters["@cAttach"].Value = "";
              cmd.Parameters["@vObserv"].Value = "";
              cmd.Parameters["@vOutil"].Value = "";
              cmd.Parameters["@vFour"].Value = "";
              cmd.Parameters["@dDatePla"].Value = DBNull.Value;
              cmd.Parameters["@cEtat"].Value = "A";
              cmd.Parameters["@cNuit"].Value = Utils.BlankIfNull(sdrDev["CACTNUIT"]);
              cmd.Parameters["@cCMD"].Value = "N";
              cmd.Parameters["@vDevis"].Value = "";
              cmd.Parameters["@mDevis"].Value = DBNull.Value;
              cmd.Parameters["@vFactBudg"].Value = DBNull.Value;
              cmd.Parameters["@vRDV"].Value = "";
              cmd.Parameters["@cVueWeb"].Value = "O";
              cmd.Parameters["@nNbHPart"].Value = Utils.ZeroIfNull(sdrDev["NACTNBHPART"]);

              cmd.ExecuteNonQuery();

              //récupération du numéro créé
              MozartParams.NumAction = Convert.ToInt32(Utils.ZeroIfNull(cmd.Parameters[0].Value));
            }
          }
        }
      }
      catch (Exception ex)
      {
        MZUtils.displayError(MethodBase.GetCurrentMethod().Name, ex);
      }
    }
  }
}

