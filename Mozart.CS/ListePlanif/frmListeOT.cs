using MozartCS.Properties;
using MozartLib;
using MozartNet;
using ReportEmalec.Net;
using System;
using System.Data;
using System.Reflection;
using System.Windows.Forms;
using MZCtrlResources = MozartControls.Properties.Resources;
using MZUtils = MozartControls.Utils;

namespace MozartCS
{
  public partial class frmListeOT : Form
  {
    private DataTable dtInterv = new DataTable();
    private DataTable dtAction = new DataTable();

    public frmListeOT()
    {
      InitializeComponent();
    }

    private void frmListeOT_Load(object sender, System.EventArgs e)
    {
      try
      {
        Cursor.Current = Cursors.WaitCursor;
        ModuleMain.Initboutons(this);

        grdDataGrid.LoadData(dtInterv, MozartDatabase.cnxMozart, "SELECT * FROM api_v_listeIP ORDER BY NIPLNUM");
        grdDataGrid.GridControl.DataSource = dtInterv;

        InitApiTGridI();

        DataRow row = grdDataGrid.GetFocusedDataRow();
        if (null == row) return;

        grdDataGridAction.LoadData(dtAction, MozartDatabase.cnxMozart, $"exec api_sp_listeActionIP {row["NIPLNUM"]}");
        grdDataGridAction.GridControl.DataSource = dtAction;

        InitApiTGridA();
      }
      catch (Exception ex)
      {
        MZUtils.displayError(MethodBase.GetCurrentMethod().Name, ex);
      }
      finally { Cursor.Current = Cursors.Default; }
    }

    private void cmdEditer_Click(object sender, EventArgs e)
    {
      try
      {
        DataRow row = grdDataGrid.GetFocusedDataRow();
        if (null == row) return;

        int iNumIP = (int)row[0];

        new frmMainReport
        {
          bLaunchByProcessStart = false,
          sTypeReport = ModuleMain.ChoixModelOTDevExpress(iNumIP),
          sIdentifiant = $"{iNumIP}",
          InfosMail = $"TPER|NPERNUM|0",
          sNomSociete = MozartParams.NomSociete,
          sLangue = ModuleMain.CodePays(ModuleMain.GetPays("TSIT", "VSITPAYS", "NSITNUM", row["NSITNUM"].ToString())).Substring(0, 2),
          sOption = "PRINT"
        }.ShowDialog();

        //string[,] TdbGlobal = { { "Now", DateTime.Now.ToLongDateString() } };

        //new frmBrowser().ImprimerFichier($"{MozartParams.CheminModeles}{ModuleMain.CodePays(ModuleMain.GetPays("TSIT", "VSITPAYS", "NSITNUM", $"{(int)row["NSITNUM"]}"))}" +
        //                                 $"{ModuleMain.ChoixModelOT(iNumIP)}",
        //                                 @"TOrdreTravailInfoOut.rtf",
        //                                 TdbGlobal,
        //                                 $"exec api_sp_OrdreDeTravail {iNumIP}");

        //impression de la gamme si nécessaire
        UtilsPlan.ImpressionDocuments((int)row["NPERNUM"], (int)row["NSITNUM"], iNumIP, Convert.ToDateTime(row["DIPLDAT"]).Day.ToString());

        //impression Attestation manipulation de fluide frigorigène
        //cas si clim et dépannage
        UtilsPlan.ImpressionAttestationClim(iNumIP);
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
        //suppression de la commande selectionnée
        DataRow row = grdDataGrid.GetFocusedDataRow();
        if (null == row) return;

        if (MessageBox.Show(Resources.msg_supprimerEnreg, Program.AppTitle, MessageBoxButtons.YesNo, MessageBoxIcon.Question, MessageBoxDefaultButton.Button2) != DialogResult.Yes) return;

        ModuleData.ExecuteNonQuery($"exec api_sp_SupprimerIP {(int)row["NIPLNUM"]}, '{DateTime.Today.ToShortDateString()}'");

        //rafraichissement
        Cursor.Current = Cursors.WaitCursor;
        grdDataGrid.Requery(dtInterv, MozartDatabase.cnxMozart);
        Cursor.Current = Cursors.Default;
      }
      catch (Exception ex)
      {
        MZUtils.displayError(MethodBase.GetCurrentMethod().Name, ex);
      }
    }

    private void cmdVisu_Click(object sender, EventArgs e)
    {
      DataRow row = grdDataGrid.GetFocusedDataRow();
      if (row == null) return;

      int iNumIP = (int)row[0];

      new frmMainReport
      {
        bLaunchByProcessStart = false,
        sTypeReport = ModuleMain.ChoixModelOTDevExpress(iNumIP),
        sIdentifiant = $"{iNumIP}",
        InfosMail = $"TPER|NPERNUM|0",
        sNomSociete = MozartParams.NomSociete,
        sLangue = ModuleMain.CodePays(ModuleMain.GetPays("TSIT", "VSITPAYS", "NSITNUM", row["NSITNUM"].ToString())).Substring(0, 2),
        sOption = "PREVIEW"
      }.ShowDialog();

      //string[,] TdbGlobal = { { "Now", DateTime.Now.ToLongDateString() } };

      //new frmBrowser()
      //{
      //  miPlanningAn = 0,
      //}.Preview_Print($"{MozartParams.CheminModeles}{ModuleMain.CodePays(ModuleMain.GetPays("TSIT", "VSITPAYS", "NSITNUM", $"{(int)row["NSITNUM"]}"))}" +
      //                $"{ModuleMain.ChoixModelOT((int)row[0])}",
      //                 @"TOrdreTravailInfoOut.rtf",
      //                 TdbGlobal,
      //                 $"exec api_sp_OrdreDeTravail {(int)row[0]}",
      //                 " (Visualisation OT dans frmListeOT)",
      //                 "PREVIEW");
    }

    private void cmdModifier_Click(object sender, EventArgs e)
    {
      DataRow row = grdDataGrid.GetFocusedDataRow();
      if (null == row) return;

      new frmPlan()
      {
        mdSemaine = Convert.ToDateTime(row["DIPLDAT"]),
        miNumTech = (int)Utils.ZeroIfNull(row["NPERNUM"]),
        mStrStatutIP = "M"
      }.ShowDialog();

      //rafraichissement
      Cursor.Current = Cursors.WaitCursor;
      grdDataGrid.Requery(dtInterv, MozartDatabase.cnxMozart);
      Cursor.Current = Cursors.Default;
    }

    private void InitApiTGridI()
    {
      grdDataGrid.AddColumn("NumIP", "NIPLNUM", 750);
      grdDataGrid.AddColumn(MZCtrlResources.col_Client, "VCLINOM", 1500);
      grdDataGrid.AddColumn(MZCtrlResources.col_Site, "VSITNOM", 1500);
      grdDataGrid.AddColumn(Resources.col_Technicien, "VPERNOM", 1500);
      grdDataGrid.AddColumn(Resources.col_Service, "VSERLIB", 1570);
      grdDataGrid.AddColumn(Resources.col_Date_P, "DIPLDAT", 1600, "date");
      grdDataGrid.AddColumn(Resources.col_DureeH, "NIPLDUR", 1600, "0.##");

      grdDataGrid.AddColumn("NCLINUM", "NCLINUM", 0);
      grdDataGrid.AddColumn("NSITNUM", "NSITNUM", 0);
      grdDataGrid.AddColumn("NPERNUM", "NPERNUM", 0);

      grdDataGrid.InitColumnList();
    }

    private void InitApiTGridA()
    {
      grdDataGridAction.AddColumn(Resources.col_NumDI, "NDINNUM", 750);
      grdDataGridAction.AddColumn(MZCtrlResources.col_Action, "VACTDES", 5400);
      grdDataGridAction.AddColumn(Resources.col_dateEx, "DACTDEX", 900);
      grdDataGridAction.AddColumn(MZCtrlResources.col_Etat, "CETACOD", 600);
      grdDataGridAction.AddColumn(Resources.col_duree, "NACTDUR", 650, "0.##");
      grdDataGridAction.AddColumn("Urg", "CURGCOD", 500);
      grdDataGridAction.AddColumn(Resources.col_Pres, "CPRECOD", 550);
      grdDataGridAction.AddColumn(Resources.col_Tech, "CTECCOD", 550);
      grdDataGridAction.AddColumn(Resources.col_Observation, "VACTOBS", 3000);
      grdDataGridAction.AddColumn("NACTNUM", "NACTNUM", 0);

      grdDataGridAction.InitColumnList();
    }

    private void grdDataGrid_SelectionChanged(object sender, DevExpress.Data.SelectionChangedEventArgs e)
    {
      DataRow row = grdDataGrid.GetFocusedDataRow();
      if (row == null) return;

      Cursor.Current = Cursors.WaitCursor;
      grdDataGridAction.sSqlDataSource = $"exec api_sp_listeActionIP {row["NIPLNUM"]}";
      grdDataGridAction.Requery(dtAction, MozartDatabase.cnxMozart);
      Cursor.Current = Cursors.Default;
    }
  }
}

