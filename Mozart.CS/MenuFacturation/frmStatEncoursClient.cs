using Microsoft.VisualBasic;
using MozartCS.Properties;
using MozartLib;
using MozartNet;
using MozartUC;
using ReportEmalec.Net;
using System;
using System.Data;
using System.Reflection;
using System.Windows.Forms;
using MZUtils = MozartControls.Utils;

namespace MozartCS
{
  public partial class frmStatEncoursClient : Form
  {
    private string msNomClient;
    private int miNumClient;

    private DataTable dt = new DataTable();

    public frmStatEncoursClient(string sNomClient, int iNumClient)
    {
      InitializeComponent();

      msNomClient = sNomClient;
      miNumClient = iNumClient;
    }

    private void frmStatEncoursClient_Load(object sender, System.EventArgs e)
    {
      ModuleMain.Initboutons(this);

      apiTGrid.LoadData(dt, MozartDatabase.cnxMozart, $"SELECT * FROM api_v_ListeFactRetard where NCLINUM = {miNumClient} ORDER BY DFACNBJ DESC ");
      apiTGrid.GridControl.DataSource = dt;
      InitApigrid();

      lblTitre.Text += msNomClient;
    }

    private void InitApigrid()
    {
      try
      {
        apiTGrid.AddColumn(Resources.col_Facture, "NFACNUM", 900);
        apiTGrid.AddColumn(Resources.col_DateFact, "DFACDAT", 1000, "dd/MM/yy", 2);
        apiTGrid.AddColumn(Resources.col_Echeance, "DDATEECH", 1000, "dd/MM/yy", 2);
        apiTGrid.AddColumn(Resources.col_JDeRetard, "DFACNBJ", 1100, "", 2);
        apiTGrid.AddColumn(Resources.col_TotalTTC, "NELFTTC", 1000, "# ##0.00 ", 1);
        apiTGrid.AddColumn(Resources.col_ResteDu, "NRESTEDU", 1000, "# ##0.00 ", 1);

        apiTGrid.InitColumnList();
      }
      catch (Exception ex)
      {
        MZUtils.displayError(MethodBase.GetCurrentMethod().Name, ex);
      }
    }

    private void cmdVisu_Click(object sender, EventArgs e)
    {
      DataRow currentRow = apiTGrid.GetFocusedDataRow();
      if (currentRow == null) return;

      new frmMainReport
      {
        bLaunchByProcessStart = false,
        sTypeReport = PrepareReport.TFACTURECLIENT,
        sIdentifiant = Strings.Mid(currentRow["NFACNUM"].ToString(), 2),
        InfosMail = $"TCLI|NCLINUM|{miNumClient}",
        sNomSociete = MozartParams.NomSociete,
        sLangue = MozartParams.Langue,
        sOption = "PREVIEW"
      }.ShowDialog();
    }

    private void apiTGrid_DoubleClickE(object sender, EventArgs e)
    {
      cmdVisu_Click(null, null);
    }
  }
}

