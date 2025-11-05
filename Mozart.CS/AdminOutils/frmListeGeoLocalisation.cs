using DevExpress.Data;
using DevExpress.XtraGrid;
using DevExpress.XtraGrid.Views.Grid;
using Microsoft.VisualBasic;
using MozartCS.Properties;
using MozartLib;
using MozartNet;
using System;
using System.Collections.Generic;
using System.Data;
using System.Reflection;
using System.Windows.Forms;
using MZUtils = MozartControls.Utils;

namespace MozartCS
{
  public partial class frmListeGeoLocalisation : Form
  {
    //Option Explicit
    //Dim adoRS As ADODB.Recordset
    //ADODB.Recordset adoRS = new ADODB.Recordset();
    DataTable dt = new DataTable();

    // ID  du responsable régional
    public int miNumRRET;

    Int32 sum;

    public frmListeGeoLocalisation()
    {
      InitializeComponent();
    }

    /* OK --------------------------------------------------------------------------*/
    private void frmListeGeoLocalisation_Load(object sender, System.EventArgs e)
    {
      try
      {
        ModuleMain.Initboutons(this);
        cmdValider.Visible = false;

        // Dde FG : ne plus afficher la liste au chargement
        //apiTGrid1.LoadData(dt, MozartDatabase.cnxMozart, "select * from api_v_ListeGeoLocalisation ORDER BY DTM8HORO desc, NTM8 desc ");
        //apiTGrid1.GridControl.DataSource = dt;
        InitGrid();
        RemplirCboTech();
        Cursor.Current = Cursors.Default;
      }
      catch (Exception ex)
      {
        MZUtils.displayError(MethodBase.GetCurrentMethod().Name, ex);
      }
    }


    private void cmdCarte_Click(object sender, EventArgs e)
    {
      DataRow row = apiTGrid1.GetFocusedDataRow();
      if (row == null) return;

      // pas d'affichage si pas de conducteur
      // if ((int)row["NPERNUM"]==0) { return; }

      Cursor.Current = Cursors.WaitCursor;
      DateTime d = Convert.ToDateTime(row["DTM8HORO"].ToString());

      //string Adresse =  "https://maps.emalec.com/TrajetTechnicienJour.asp?BASE=MULTI&APP=" + MozartParams.NomSociete
      //                                   + "&TYPE=" + (row["VTM8TYPE"].ToString() == "Arrivée" ? "GEOLOCA" : "GEOLOCD")
      //                                   + "&INDEX=" + row["NTM8"]
      //                                   + "&NOM=" + Strings.Replace(Utils.BlankIfNull(row["VTM8COND"].ToString()), "'", "''")
      //                                   + "&JOUR=" + d.ToShortDateString();
      frmBrowser f = new frmBrowser();
      f.mddate = d;
      f.mstrType = "GEOLOC";
      f.minpernum = (int)row["NPERNUM"];


      f.msStartingAddress = "http://maps.emalec.com/TrajetTechnicienJour.asp?BASE=MULTI&APP=" + MozartParams.NomSociete
                        + "&TYPE=" + (row["VTM8TYPE"].ToString() == "Arrivée" ? "GEOLOCA" : "GEOLOCD")
                        + "&INDEX=" + row["NTM8"]
                        + "&NOM=" + Strings.Replace(Utils.BlankIfNull(row["VTM8COND"].ToString()), "'", "''")
                        + "&JOUR=" + d.ToShortDateString();
      f.ShowDialog();




      // FGA le 29/12 : il faut ouvrir le navigateur avant de passer l'url sinon cela ne fonctionne pas
      // il faut également gérer le blanc qui pose problème
      //Process.Start("msedge.exe", Adresse.Replace(" ", "%20"));

      Cursor.Current = Cursors.Default;
    }

    private void cmdJournee_Click(object sender, EventArgs e)
    {
      if (apicboTech.GetText() == "" || txtDate.Text == "") return;

      DataRow row = apiTGrid1.GetFocusedDataRow();
      if (row == null) return;

      Cursor.Current = Cursors.WaitCursor;
      DateTime d = Convert.ToDateTime(row["DTM8HORO"].ToString());

      frmBrowser f = new frmBrowser();
      f.mddate = d;
      f.mstrType = "GEOLOC";
      f.minpernum = (int)row["NPERNUM"];

      f.msStartingAddress = "https://maps.emalec.com/TrajetTechnicienJourDepArr.asp?BASE=MULTI&APP=&TYPE=GEOLOC&INDEX=0&NOM="
                          + Strings.Replace(apicboTech.GetText(), "'", "''") + "&JOUR=" + txtDate.Text + "&NPERNUM=" + apicboTech.GetItemData().ToString();
      f.ShowDialog();


      //string Adresse = "https://maps.emalec.com/TrajetTechnicienJourDepArr.asp?BASE=MULTI&APP=&TYPE=GEOLOC&INDEX=0&NOM="
      //                    + HttpUtility.UrlEncode(Strings.Replace(apicboTech.GetText(), "'", "''"), System.Text.UnicodeEncoding.UTF8) + "&JOUR=" + txtDate.Text + "&NPERNUM=" + apicboTech.GetItemData().ToString();


      //// FGA le 29/12 : il faut ouvrir le navigateur avant de passer l'url sinon cela ne fonctionne pas
      //Process.Start("msedge.exe", Adresse.Replace(" ", "%20"));


      Cursor.Current = Cursors.Default;
    }


    private void cbotech_TxtChanged(object sender, EventArgs e)
    {
      if (txtDate.Text != "")
        cmdValider_Click(null, null);
    }

    //private void txtDate_TextChanged(object sender, EventArgs e)
    //{
    //  if (txtDate.Text != "")
    //    cmdValider_Click(null, null);
    //}

    private void cmdValider_Click(object sender, EventArgs e)
    {
      string sSql = "";

      Cursor.Current = Cursors.WaitCursor;
      if (txtDateFin.Text == "")
      {
        if (apicboTech.GetItemData() > 0)
          sSql = $"select * from api_v_ListeGeoLocalisation WHERE NPERNUM={apicboTech.GetItemData()} And DTM8HORO BETWEEN " +
                 $"'{txtDate.Text}' AND DATEADD (d, 1, '{txtDate.Text}') ORDER BY DTM8HORO desc, NTM8 desc";
        else
          sSql = $"select * from api_v_ListeGeoLocalisation WHERE NPERNUM=0 And DTM8HORO BETWEEN '{txtDate.Text}' AND DATEADD (d, 1, '{txtDate.Text}') " +
                 $"ORDER BY DTM8HORO desc, NTM8 desc";
      }
      else
      {
        if (apicboTech.GetItemData() > 0)
          sSql = $"select * from api_v_ListeGeoLocalisation WHERE NPERNUM={apicboTech.GetItemData()} And DTM8HORO BETWEEN " +
                 $"'{txtDate.Text}' AND  '{txtDateFin.Text}' ORDER BY DTM8HORO desc, NTM8 desc";
        else
          sSql = $"select * from api_v_ListeGeoLocalisation WHERE NPERNUM=0 And DTM8HORO BETWEEN '{txtDate.Text}' AND  '{txtDateFin.Text}' " +
                 $"ORDER BY DTM8HORO desc, NTM8 desc";
      }

      apiTGrid1.LoadData(dt, MozartDatabase.cnxMozart, sSql);
      apiTGrid1.GridControl.DataSource = dt;
      Cursor.Current = Cursors.Default;
    }

    private void InitGrid()
    {
      apiTGrid1.AddColumn(Resources.col_Num, "NTM8", 0);
      apiTGrid1.AddColumn(Resources.col_Type, "VTM8TYPE", 1100, "", 2);
      apiTGrid1.AddColumn("Immat", "VVEHIMAT", 1200);
      apiTGrid1.AddColumn(Resources.col_date_heure, "DTM8HORO", 2200, "", 2);
      apiTGrid1.AddColumn("Cpt", "FTM8CPT", 800, "", 2);
      apiTGrid1.AddColumn(Resources.col_conducteur, "VTM8COND", 2400);
      apiTGrid1.AddColumn(Resources.col_Ville, "VILLE", 2800);
      apiTGrid1.AddColumn(Resources.col_horaires, "HORAIRE", 900, "", 2);
      apiTGrid1.AddColumn(Resources.col_dist_km, "KMS", 900);
      apiTGrid1.AddColumn("IKMS", "IKMS", 0);

      apiTGrid1.dgv.Columns["VILLE"].Summary.Add(new GridColumnSummaryItem(SummaryItemType.Custom, "VILLE", "TOTAL KMS : {0:n0}"));
      apiTGrid1.dgv.CustomSummaryCalculate += new CustomSummaryEventHandler(gridView_CustomSummaryCalculate);

      apiTGrid1.InitColumnList();
    }

    private void gridView_CustomSummaryCalculate(object sender, CustomSummaryEventArgs e)
    {
      GridView view = sender as GridView;
      if (e.IsTotalSummary && (e.Item as GridSummaryItem).FieldName == "VILLE")
      {
        GridSummaryItem item = e.Item as GridSummaryItem;
        if (item.FieldName == "VILLE")
        {
          switch (e.SummaryProcess)
          {
            case CustomSummaryProcess.Start:
              sum = 0;
              break;
            case CustomSummaryProcess.Calculate:
              if (view.GetRowCellValue(e.RowHandle, "IKMS").ToString() != "")
              {
                sum += (Int32)view.GetRowCellValue(e.RowHandle, "IKMS");
              }
              break;
            case CustomSummaryProcess.Finalize:
              e.TotalValue = sum;
              break;
          }
        }
      }

    }
    void RemplirCboTech()
    {

      // si on affiche cette écran pour les responsables region, il faut restreindre la liste des techs
      string sSql = "";

      if (miNumRRET > 0)
      {
        sSql = "SELECT TPER.NPERNUM, ISNULL(VPERNOM + ' ' + VPERPRE, '') AS VTM8COND FROM TPER LEFT OUTER JOIN TM8 ON TPER.NPERNUM = TM8.NPERNUM " +
              "WHERE NPERRRET = " + miNumRRET + " AND BUTILISATEUR=0 AND (TPER.DPERSOR IS NULL OR TPER.DPERSOR >= CONVERT(VARCHAR(15), GETDATE(), 103)) " +
              "GROUP BY TPER.NPERNUM, VPERNOM + ' ' + VPERPRE ORDER BY VPERNOM + ' ' + VPERPRE";

      }
      else
      {
        sSql = "SELECT TPER.NPERNUM, ISNULL(VPERNOM + ' ' + VPERPRE, '') AS VTM8COND FROM TPER LEFT OUTER JOIN TM8 ON TPER.NPERNUM = TM8.NPERNUM " +
                "WHERE TPER.VSOCIETE = APP_NAME() AND BUTILISATEUR=0 AND (TPER.DPERSOR IS NULL OR TPER.DPERSOR >= CONVERT(VARCHAR(15), GETDATE(), 103)) " +
                "GROUP BY TPER.NPERNUM, VPERNOM + ' ' + VPERPRE ORDER BY VPERNOM + ' ' + VPERPRE";
      }

      apicboTech.Init(MozartDatabase.cnxMozart, sSql, "", "VTM8COND", new List<string>() { "", Resources.col_Nom }, 150, 400);

    }

    private void cmdSuivi_Click(object sender, EventArgs e)
    {
      if (apicboTech.GetText() == "" || txtDate.Text == "")
      {
        MessageBox.Show(Resources.msg_select_tech_et_journee, Program.AppTitle, MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
        return;
      }
      if (apiTGrid1.GetFocusedDataRow() == null) return;

      Cursor.Current = Cursors.WaitCursor;
      frmStatGeolocalisation f = new frmStatGeolocalisation();
      f.miPernum = (int)apiTGrid1.GetFocusedDataRow()["NPERNUM"];
      f.mdDateJour = Convert.ToDateTime(txtDate.Text);
      f.mstrPernom = apiTGrid1.GetFocusedDataRow()["VTM8COND"].ToString();
      f.ShowDialog();
      Cursor.Current = Cursors.Default;
    }

    private void cmdFermer_Click(object sender, System.EventArgs e)
    {
      Dispose();
    }

    private void txtDate_EditValueChanged(object sender, EventArgs e)
    {
      if (txtDate.Text != "")
        cmdValider_Click(null, null);
    }

    private void txtDateFin_EditValueChanged(object sender, EventArgs e)
    {
      if (txtDate.Text != "")
        cmdValider_Click(null, null);
    }
  }
}

