using MZCtrlResources = MozartControls.Properties.Resources;
using MozartCS.Properties;
using MozartLib;
using MozartNet;
using System;
using System.Data;
using System.Reflection;
using System.Text;
using System.Windows.Forms;
using MZUtils = MozartControls.Utils;

namespace MozartCS
{
  public partial class frmListeActRetQualite : Form
  {
    DataTable dt = new DataTable();

    TooltipGridTPE _tpe;

    public frmListeActRetQualite() { InitializeComponent(); }

    private void frmListeActRetQualite_Load(object sender, System.EventArgs e)
    {
      try
      {
        Cursor.Current = Cursors.WaitCursor;
        ModuleMain.Initboutons(this);

        //ouverture du recordset
        string sSql = CreateReqSQL("N");

        apigrid.LoadData(dt, MozartDatabase.cnxMozart, sSql);
        apigrid.GridControl.DataSource = dt;

        InitApigrid();

        _tpe = new TooltipGridTPE(apigrid, toolTipController1);
      }
      catch (Exception ex)
      {
        MZUtils.displayError(MethodBase.GetCurrentMethod().Name, ex);
      }
      finally { Cursor.Current = Cursors.Default; }
    }

    public void InitApigrid()
    {
      apigrid.AddColumn("Origine", "ORIGINE", 900);
      apigrid.AddColumn(Resources.col_DI, "NDINNUM", 700);
      apigrid.AddColumn(Resources.col_date_c, "DDINDATHEUR", 850, "dd/mm/yy");
      apigrid.AddColumn(MZCtrlResources.col_Client, "VCLINOM", 1200);
      apigrid.AddColumn(Resources.col_Site, "VSITNOM", 1400);
      apigrid.AddColumn(Resources.col_sitenum, "NSITNUE", 480);
      apigrid.AddColumn(Resources.col_Enseigne, "VSITENSEIGNE", 1000);
      apigrid.AddColumn(Resources.col_Chaff, "VDINCHAFF", 1200);
      apigrid.AddColumn(Resources.col_Action, "VACTDES", 2500);
      //      apigrid.AddColumn(Resources.col_Date, "DACTDATE", 850, "dd/mm/yy");
      //      apigrid.AddColumn(Resources.col_Technicien, "VACTINT", 800);
      apigrid.AddColumn(Resources.col_T_echnique, "CTECCOD", 800);
      //      apigrid.AddColumn(Resources.col_P_restation, "CPRECOD", 280, "", 2);
      //      apigrid.AddColumn(Resources.col_E_tat, "CETACOD", 280, "", 2);
      //      apigrid.AddColumn(Resources.col_A_dministration, "CACTSTA", 280, "", 2);
      //      apigrid.AddColumn(Resources.col_OBS, "VACTOBS", 2100, "", 0, true);
      apigrid.AddColumn(Resources.col_Contrat, "VTYPECONTRAT", 1000, "", 0, true);
      apigrid.AddColumn(Resources.col_RM, "VCCLNOM", 1000, "", 0, true);
      apigrid.AddColumn(Resources.col_NumAction, "NACTNUM", 0);
      //      apigrid.AddColumn(Resources.col_type_intervenant, "CACTTYT", 0);
      apigrid.AddColumn(Resources.col_Site, "NSITNUM", 0);
      //      apigrid.AddColumn(Resources.col_Qui, "QUI", 0);
      apigrid.AddColumn(Resources.col_HorsWeb, "CACTVUEWEB", 0);
      apigrid.AddColumn(Resources.col_CP, "VSITCP", 800);
      apigrid.AddColumn(Resources.col_Dep, "DEP", 700);
      apigrid.AddColumn(Resources.col_Pays, "VSITPAYS", 1000);
      apigrid.AddColumn(Resources.col_Region, "REGION", 1800);
      apigrid.AddColumn(Resources.col_Urgence, "NACTNUM_INTER", 0);
      apigrid.AddColumn(Resources.col_Urgence, "CENQUETEWEB", 0);


      apigrid.InitColumnList();

    }


    private void cmdModifier_Click(object sender, EventArgs e)
    {
      DataRow row = apigrid.GetFocusedDataRow();
      if (row == null) return;

      //écran de modification de la demande
      MozartParams.NumDi = (int)row["NDINNUM"];
      MozartParams.NumAction = (int)row["NACTNUM"];

      Cursor.Current = Cursors.WaitCursor;
      new frmDetailstravaux
      {
        sModeReadOnly = "0",
        mstrStatutAction = "M",
      }.ShowDialog();

      //on revient donc on réinitialise les variables globales
      MozartParams.NumDi = 0;
      MozartParams.NumAction = 0;

      Cursor.Current = Cursors.WaitCursor;
      apigrid.Requery(dt, MozartDatabase.cnxMozart);
      Cursor.Current = Cursors.Default;
    }

    private void apigrid_DblClickE(object sender, EventArgs e)
    {
      cmdModifier_Click(null, null);
    }
    private string CreateReqSQL(string iArchi)
    {
      StringBuilder sSql = new StringBuilder();

      sSql.Append("  SELECT TDIN.NDINNUM, CAST(CONVERT(VARCHAR(10),TACT.DACTDATCRE,103) as DATETIME) as DDINDATHEUR,");
      sSql.Append("  TCLI.VCLINOM, TSIT.VSITNOM, TSIT.NSITNUE, TSIT.VSITENSEIGNE, VDINCHAFF,");
      // sSql.Append("  CAST(CONVERT(VARCHAR(8), COALESCE (TACT.DACTPLA, TACT.DACTDEX), 3) AS DATETIME) AS DACTDATE,");
      //      sSql.Append("  CASE TACT.CACTTYT WHEN 'T' THEN (select VPERNOM + ' ' + COALESCE (VPERPRE, '') from TPER WITH (NOLOCK) WHERE NPERNUM=TACT.NPERNUM)");
      //     sSql.Append("  ELSE (select VSTFNOM from TSTF WITH (NOLOCK) INNER JOIN TINT WITH (NOLOCK) ON TSTF.NSTFNUM = TINT.NSTFNUM WHERE NINTNUM=TACT.NINTNUM ) END AS VACTINT,");
      sSql.Append("  TACT.CTECCOD, TACT.CPRECOD, TACT.CETACOD, TACT.CACTSTA, TACT.VACTOBS, TACT.NACTNUM, TACT.CACTTYT, TACT.NSITNUM,");
      //      sSql.Append("  CASE WHEN CPRECOD = 'D' AND CETACOD = 'O' THEN 1 WHEN CPRECOD = 'D' AND CETACOD = 'P' THEN 2 WHEN CPRECOD = 'D' AND CETACOD = 'A' THEN 3");
      //      sSql.Append("  WHEN CPRECOD <> 'D' AND CETACOD = 'O' THEN 4 WHEN CPRECOD <> 'D' AND CETACOD = 'D' THEN 5 WHEN CPRECOD <> 'D' AND CETACOD = 'A' THEN 6 ELSE 100 END AS TRI,");
      sSql.Append("  VSITCP, LEFT(TSIT.VSITCP,2) AS DEP, '' as VSITTYPE,");
      sSql.Append("  (select TCCL.VCCLNOM from TCCL WITH (NOLOCK) where TCCL.NCCLNUM=TSIT.NSITRESPMAINT AND TCCL.NCLINUM=TSIT.NCLINUM ) 'VCCLNOM',");
      sSql.Append("  TDIN.CDINTS, TACT.CACTVUEWEB, TACT.VACTNUMCDE,'' as ST, TACT.NACTVAL, TSIT.VSITPAYS,");
      //     sSql.Append("  CASE WHEN ISNULL(TACT.NPERNUM,0) = 0 THEN CASE WHEN ISNULL(TACT.NINTNUM,0) = 0 THEN '' Else 'STT' End Else 'TECH' END AS INTERVENANT,");
      sSql.Append("  TSIT.VSITREG AS REGION,");
      sSql.Append("  TACT.VACTDES, TREF_TYPECONTRAT.VTYPECONTRAT, TACTRETQUAL.NACTNUM_INTER, w.CENQUETEWEB,");
      sSql.Append("  case when w.CENQUETEWEB='O' then 'Mail' Else 'Mozart' End as ORIGINE");

      sSql.Append("  FROM TAUT WITH (NOLOCK) INNER JOIN TPER WITH (NOLOCK) ON TAUT.NPERNUM = TPER.NPERNUM INNER JOIN TACT WITH (NOLOCK) INNER JOIN");
      sSql.Append("  TACTCOMP WITH (NOLOCK) ON TACTCOMP.NACTNUM = TACT.NACTNUM INNER JOIN");
      sSql.Append("  TSIT WITH (NOLOCK) ON TACT.NSITNUM = TSIT.NSITNUM INNER JOIN");
      sSql.Append("  TDIN WITH (NOLOCK) ON TACT.NDINNUM = TDIN.NDINNUM INNER JOIN");
      sSql.Append("  TACTRETQUAL WITH (NOLOCK) ON TACT.NACTNUM = TACTRETQUAL.NACTNUM_RETQUAL INNER JOIN");
      sSql.Append("  EnqueteClientWeb w WITH (NOLOCK) ON w.ID = TACTRETQUAL.IDENQUETE INNER JOIN");
      sSql.Append("  TCLI WITH (NOLOCK) ON TDIN.NCLINUM = TCLI.NCLINUM ON TAUT.NCANNUM = TDIN.NDINCTE INNER JOIN");
      sSql.Append("  TREF_TYPECONTRAT WITH (NOLOCK) ON TDIN.NTYPECONTRAT = TREF_TYPECONTRAT.NTYPECONTRAT ");

      sSql.Append("  WHERE TACT.CETACOD <> 'S' AND TCLI.VSOCIETE = App_Name() ");
      sSql.Append($"  AND TAUT.NPERNUM = {MozartParams.UID} AND LANGUE = '{MozartParams.Langue}'");
      sSql.Append("  AND TACT.CPRECOD = 'K'");

      if (iArchi == "O")
        sSql.Append("  AND TACT.CETACOD = 'E' ");
      else
        sSql.Append("  AND TACT.CETACOD <> 'E' ");

      sSql.Append(" ORDER BY TACT.DACTDATCRE DESC");

      return sSql.ToString();
    }
    private void cmdArchive_Click(object sender, EventArgs e)
    {
      cmdArchive.Visible = false;
      Label1.Text = Resources.txt_Liste_Actions_Retours_Qualite_Traitee;

      //ouverture du recordset
      string sSql = CreateReqSQL("O");

      Cursor.Current = Cursors.WaitCursor;
      apigrid.LoadData(dt, MozartDatabase.cnxMozart, sSql);
      apigrid.GridControl.DataSource = dt;
      Cursor.Current = Cursors.Default;

      CmdEnCours.Visible = true;
    }

    private void CmdEnCours_Click(object sender, EventArgs e)
    {
      CmdEnCours.Visible = false;
      Label1.Text = Resources.txt_Liste_Actions_Retours_Qualite_Attente_Traitement;

      //ouverture du recordset
      Cursor.Current = Cursors.WaitCursor;
      string sSql = CreateReqSQL("N");

      apigrid.LoadData(dt, MozartDatabase.cnxMozart, sSql);
      Cursor.Current = Cursors.Default;

      cmdArchive.Visible = true;
    }

    private void cmdQuitter_Click(object sender, System.EventArgs e)
    {
      Dispose();
    }

    private void cmdEnquete_Click(object sender, EventArgs e)
    {
      DataRow row = apigrid.GetFocusedDataRow();
      if (row == null) return;

      new frmEnqueteQual()
      {
        NACTNUM = (int)row["NACTNUM_INTER"],
        TYPE_ENQUETE = (string)row["CENQUETEWEB"],
        DROIT_REPONSE = "OUI"

      }.ShowDialog();

    }
  }
}

