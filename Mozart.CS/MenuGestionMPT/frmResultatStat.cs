using DevExpress.XtraCharts;
using Microsoft.VisualBasic;
using MozartCS.Properties;
using MozartLib;
using MozartNet;
using System;
using System.Data;
using System.IO;
using System.Reflection;
using System.Windows.Forms;
using MZUtils = MozartControls.Utils;

namespace MozartCS
{
  public partial class frmResultatStat : Form
  {
    public string mstrTypeStat;
    public string mstrInfoRetour;
    public int miNumClient;
    public string mstrCboClient;
    public string mstrTxtDate0;
    public string mstrTextDate1;

    DataTable dt = new DataTable();

    public frmResultatStat()
    {
      InitializeComponent();
    }


    private void frmResultatStat_Load(object sender, System.EventArgs e)
    {
      try
      {
        ModuleMain.Initboutons(this);

        Label2.Text = mstrCboClient;
        Label4.Text = mstrTxtDate0;
        Label6.Text = mstrTextDate1;

        string sSQL = $"api_sp_StatistiqueClient {miNumClient},{mstrInfoRetour},{mstrTypeStat},'{mstrTxtDate0}','{mstrTextDate1}', {MozartParams.UID}";

        //création d'une commande 
        grdDataGrid2.LoadData(dt, MozartDatabase.cnxMozart, sSQL);
        grdDataGrid2.GridControl.DataSource = dt;

        // mise en page du datagrid
        FormatGrid();

        //graphique

        Series series1 = new Series("Pie Serie 1", ViewType.Pie);

        foreach (DataRow dr in dt.Rows)
        {
          if (dr[0].ToString() != "Total")
            series1.Points.Add(new SeriesPoint(dr[0].ToString(), dr[2].ToString()));
        }

        series1.LegendTextPattern = "{A}";
        MSChart1.Series.Add(series1);

        ChartTitle title = new ChartTitle();

        switch (mstrTypeStat)
        {
          case "U":
            title.Text = Resources.title_repParUrgence;
            break;
          case "P":
            title.Text = Resources.title_repParPresta;
            break;
          case "T":
            title.Text = Resources.title_repParTech;
            break;
          default:
            break;
        }
		title.TextColor = System.Drawing.Color.Black;
        MSChart1.Titles.Add(title);

        Cursor = Cursors.Default;
      }
      catch (Exception ex)
      {
        Cursor = Cursors.Default;
        MZUtils.displayError(MethodBase.GetCurrentMethod().Name, ex);
      }
    }


    private void Command1_Click(object sender, EventArgs e)
    {
      //fonction d'impression écran
      Cursor = Cursors.WaitCursor;
      this.ImprimerDansWord();
      Cursor = Cursors.Default;
    }


    private void FormatGrid()
    {
      try
      {
        switch (mstrTypeStat)
        {
          case "U":
            grdDataGrid2.AddColumn(Resources.col_Urgence, "Champ", 1800);
            break;
          case "P":
            grdDataGrid2.AddColumn(Resources.col_Prestation, "Champ", 1800);
            break;
          case "T":
            grdDataGrid2.AddColumn(Resources.col_Technique, "Champ", 1800);
            break;
          default:
            break;
        }

        grdDataGrid2.AddColumn(Resources.col_NbSites, "NBsite", 1000);

        switch (mstrInfoRetour)
        {
          case "N":
            grdDataGrid2.AddColumn(Resources.col_Nombre, "nombre", 1800, "", 1);
            break;
          case "F":
            grdDataGrid2.AddColumn(Resources.col_MontantFacture, "nombre", 1800, "currency", 1);
            break;
          default:
            break;
        }

        grdDataGrid2.AddColumn(Resources.col_Ratio, "ratio", 1500);

        grdDataGrid2.InitColumnList();
      }
      catch (Exception ex)
      {
        MZUtils.displayError(MethodBase.GetCurrentMethod().Name, ex);
      }
    }

    private void cmdImprimer_Click(object sender, EventArgs e)
    {
      try
      {
        //affichage curseur
        Cursor = Cursors.WaitCursor;
        GenerateStat();

        frmBrowser f = new frmBrowser();
        f.msStartingAddress = MozartParams.CheminUtilisateurMozart + @"s.html";
        f.ShowDialog();
        Cursor = Cursors.Default;
      }
      catch (Exception ex)
      {
        MZUtils.displayError(MethodBase.GetCurrentMethod().Name, ex);
        Cursor = Cursors.Default;
      }

    }

    private void GenerateStat()
    {
      string strHtml = "";

      try
      {
        DataRow currentRow = grdDataGrid2.GetFocusedDataRow();

        if (currentRow == null)
        {
          strHtml += $"<H3>Statistique de {mstrCboClient} </H3>" +
          $"aucune statistique";
        }
        else
        {
          strHtml += "<html><head><title> Statistique client</title></head><body>\r\n\r\n";

          //nom du client
          strHtml += $"<table border=0 widht=100%><tr>" +
          $"<TD width=10%><b><font face=tahoma size=4>{MozartParams.NomSociete} </font></TD>" +
          $"<TD width=10%>&nbsp;</TD>" +
          $"<TD width=80% align=right><b><font face=tahoma size=3>Statistique de : {mstrCboClient} </Font></TD>" +
          $"</TR></table>";

          //titre
          switch (mstrTypeStat + mstrInfoRetour)
          {
            case "UN":
              strHtml += "<H3>Nombre d'interventions par site et par urgence</H3>";
              break;
            case "PN":
              strHtml += "<H3>Nombre d'interventions par site et par prestation</H3>";
              break;
            case "TN":
              strHtml += "<H3>Nombre d'interventions par site et par technique</H3>";
              break;
            case "UF":
              strHtml += "<H3>Coût des interventions par site et par urgence</H3>";
              break;
            case "PF":
              strHtml += "<H3>Coût des interventions par site et par prestation</H3>";
              break;
            case "TF":
              strHtml += "<H3>Coût des interventions par site et par technique</H3>";
              break;
            default:
              break;
          }

          strHtml += $"<H3>Période du {mstrTxtDate0} au {mstrTextDate1} </H3><br>";

          //Tableau
          strHtml += "<table border=1 cellpadding=2 cellspacing =0 widht=100%><tr>\r\n\r\n";
          switch (mstrTypeStat)
          {
            case "U":
              strHtml += "<td width=16% bgcolor=#FCFECF><font face=tahoma size=3><b>Urgence</b></FONT></td>";
              break;
            case "P":
              strHtml += "<td width=16% bgcolor=#FCFECF><font face=tahoma size=3><b>Prestation</b></FONT></td>";
              break;
            case "T":
              strHtml += "<td width=16% bgcolor=#FCFECF><font face=tahoma size=3><b>Technique</b></FONT></td>";
              break;
            default:
              break;
          }

          //nb sites
          strHtml += "<td width=10% bgcolor=#FCFECF align=center><font face=Arial size=3><b>NB Sites</b></FONT></td>";

          switch (mstrInfoRetour)
          {
            case "N":
              strHtml += "<td width=20% bgcolor=#FCFECF align=center><font face=Arial size=3><b>Nombre</b></FONT></td>";
              break;
            case "F":
              strHtml += "<td width=24% bgcolor=#FCFECF align=center><font face=Arial size=3><b>Montant facturé</b></FONT></td>";
              break;
            default:
              break;
          }

          strHtml += "<td width=17% bgcolor=#FCFECF align=center><font face=Arial size=3><b>Ratio (%)</b></FONT></td>";
          strHtml += "</tr>\r\n\r\n";

          foreach (DataRow dr in dt.Rows)
          {
            //Site client et planning de ce site
            strHtml += $"<tr><td bgcolor=white><font face=Arial size=2>{dr[0].ToString()}</FONT></td> " +
            $"<td bgcolor=white align=center><font face=Arial size=2>&nbsp;{Strings.Format(dr[1], "### ###")}</FONT></td> " +
            $"<td bgcolor=white align=center><font face=Arial size=2>{Strings.Format(dr[2], "### ### ###")}</FONT></td> " +
            $"<td bgcolor=white align=center><font face=Arial size=2>{dr[3].ToString()}</FONT></td> " +
            $"</tr>";
          }

          strHtml += "</table>";
        }
        strHtml += "</body></html>";
        File.WriteAllText(MozartParams.CheminUtilisateurMozart + @"s.html", strHtml);
      }
      catch (Exception ex)
      {
        MZUtils.displayError(MethodBase.GetCurrentMethod().Name, ex);
      }
    }

    private void cmdQuitter_Click(object sender, System.EventArgs e)
    {
      Dispose();
    }

  }
}