using DevExpress.XtraCharts;
using MozartCS.Properties;
using MozartNet;
using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Reflection;
using System.Windows.Forms;
using MZUtils = MozartControls.Utils;


namespace MozartCS
{
  public partial class frmStatQualTauxConf : Form
  {
    public string mstrStat;

    public frmStatQualTauxConf()
    {
      InitializeComponent();
    }

    private class donneesGraph
    {
      public string periode { get; set; }
      public decimal nb { get; set; }
      public donneesGraph(string per, Decimal n) { periode = per; nb = n; reformatPeriode(); }
      private void reformatPeriode()
      {
        string[] compos = periode.Split(' ');
        if (2 == compos.Length)
          periode = $"{compos[1]}/{compos[0].Substring(2)}";
      }
    }

    // on ne traite que lss 4 cas recensés
    /*
    ./MOZART/frmChoixStatLogistique.frm:204:  frmStatQualTauxConf.mstrStat = "CoutFor"
    ./MOZART/frmListeAnomalieCommande.frm:491:  frmStatQualTauxConf.mstrStat = "AnoCmd"
    ./MOZART/frmStatQualite.frm:458:  frmStatQualTauxConf.mstrStat = "NewDevis"
    ./MOZART/frmStatQualite.frm:465:  frmStatQualTauxConf.mstrStat = "Depannages"
    */
    private void frmStatQualTauxConf_Load(object sender, System.EventArgs e)
    {
      try
      {
        Cursor.Current = Cursors.WaitCursor;

        ModuleMain.Initboutons(this);

        // on ne traite que les cas effectivement appelés depuis les autres forms
        switch (mstrStat)
        {
          case "CoutFor":
            Label7.Text = Resources.txt_CoutFor;
            //Frame2.Visible = false;
            //Frame5.Visible = true;
            lblDefStat.Text = $"{Resources.lbl_objectif_qualite} 0.9% \r\n";
            break;
          case "AnoCmd":
            Label7.Text = Resources.txt_AnoCmd;
            //Frame2.Visible = false;
            //Frame5.Visible = true;
            lblDefStat.Text = $"{Resources.lbl_objectif_qualite} 80 \r\n";
            break;
          case "NewDevis":
            Label7.Text = Resources.txt_NewDevis;
            //Frame2.Visible = false;
            //Frame5.Visible = true;
            lblDefStat.Text = $"{Resources.lbl_objectif_qualite} 150\r\n";
            break;
          case "Depannages":
            Label7.Text = Resources.txt_Depannages;
            //Frame2.Visible = false;
            //Frame5.Visible = true;
            lblDefStat.Text = $"{Resources.lbl_objectif_qualite} 600 \r\n";
            break;
          default:
            return;
        }


        List<donneesGraph> listDataSource = new List<donneesGraph>();

        Series serie1 = ChartSpace1.Series["Serie1"];

        using (SqlDataReader dr = ModuleData.ExecuteReader($"exec api_sp_StatQual{mstrStat}"))
        {
          while (dr.Read())
          {
            listDataSource.Add(new donneesGraph(Utils.BlankIfNull(dr[1]), (decimal)Utils.ZeroIfNull(dr[0])));
          }
          dr.Close();
        }

        listDataSource.Reverse();

        serie1.DataSource = listDataSource;

        XYDiagram diagram = ChartSpace1.Diagram as XYDiagram;
        diagram.AxisX.QualitativeScaleOptions.AutoGrid = false;

      }
      catch (Exception ex)
      {
        MZUtils.displayError(MethodBase.GetCurrentMethod().Name, ex);
      }
      finally
      {
        Cursor.Current = Cursors.Default;
      }
    }

    private void cmdImprimer_Click(object sender, System.EventArgs e)
    {
			this.ImprimerDansWord(); 
    }

  }
}

