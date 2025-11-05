using Microsoft.VisualBasic;
using MozartCS.Properties;
using MozartLib;
using MozartNet;
using System;
using System.Data;
using System.Data.SqlClient;
using System.Reflection;
using System.Windows.Forms;
using MZUtils = MozartControls.Utils;

namespace MozartCS
{
  public partial class frmStatComptaSynt : Form
  {

    DataTable dt = new DataTable();

    public frmStatComptaSynt()
    {
      InitializeComponent();
    }

    private void frmStatComptaSynt_Load(object sender, System.EventArgs e)
    {
      try
      {
        ModuleMain.Initboutons(this);

        dateEdit1.DateTime = DateTime.Now;

        //  titre selon
        lbl1.Text = Resources.txt_encoursCliRetardPrestations + MozartParams.NomSociete + " :";
        lbl3.Text = Resources.txt_encoursCliRetardPrestationsSousTraitants;
        lbl4.Text = Resources.txt_encoursCliAvance;
        lbl6.Text = Resources.txt_encoursAjustContratsPrev;
        lbl5.Text = Resources.txt_encoursSousTraitantRetard;
        lbl7.Text = Resources.txt_encoursFournissRetard;
        lbl2.Text = "ENCOURS SOUS-TRAITANT en AVANCE :";

        videLblHT();
      }
      catch (Exception ex)
      {
        MZUtils.displayError(MethodBase.GetCurrentMethod().Name, ex);
      }
    }

    private void cmdVisuB_Click(object sender, EventArgs e)
    {
      try
      {
        string lDate = dateEdit1.DateTime.ToShortDateString();

        string[,] TdbGlobal = new string[,] { { "DateR", lDate},
                                              { "Num", "8"},
                                              { "Titre", $"Synthèse des états comptables à la date du  {lDate}" },
                                              { "Date",  DateTime.Now.ToShortDateString() },
                                              { "REMALEC", lblHT1.Text},
                                              { "RSTT", lblHT3.Text},
                                              { "RNE", lblHT4.Text}, // non executé mais facturé
                                              { "DCSTT",lblHT5.Text},
                                              { "DCFOU", lblHT7.Text},
                                              { "TR", lblHT0.Text},
                                              { "TD", lblTHTb.Text},
                                              { "SOLDE", lblTT.Text},
                                              { "NCANNUM", ""},
                                              { "VCANLIB", ""}
        };
        frmBrowser f = new frmBrowser();
        f.Preview_Print(MozartParams.CheminModeles + MozartParams.Langue + @"\TEtatComptableSynt.rtf",
                        @"TEtatComptableSyntOut.rtf",
                        TdbGlobal,
                        "select 0",
                        " (Impression consultation)",
                        "PREVIEW");
      }
      catch (Exception ex)
      {
        MZUtils.displayError(MethodBase.GetCurrentMethod().Name, ex);
      }
    }

    private void videLblHT()
    {
      lblHT0.Text = "";
      lblHT1.Text = "";
      lblHT2.Text = "";
      lblHT3.Text = "";
      lblHT4.Text = "";
      lblHT5.Text = "";
      lblHT6.Text = "";
      lblHT7.Text = "";

      lblTT.Text = "";
      lblTHTh.Text = "";
      lblTHTb.Text = "";
      lblStock.Text = "";
    }

    private void cmdValider_Click(object sender, EventArgs e)
    {
      int total;
      double somme = 0;

      Cursor = Cursors.WaitCursor;

      ProgressBar1.Value = 1;
      ProgressBar1.Visible = true;
      ProgressBar1.Maximum = 9;

      //  initialisation des valeurs
      videLblHT();

      string lDate = dateEdit1.DateTime.ToShortDateString();

      //  liste des recettes
      using (SqlDataReader dr = ModuleData.ExecuteReader($"exec api_sp_ListeEtatCompta2 '{lDate} 22:00:00' , 1"))
      {
        if (dr.Read())
        {
          lblHT1.Text = Strings.FormatNumber(Utils.ZeroIfNull(dr["total"]), 0) + " €";
          somme = (double)Utils.ZeroIfNull(dr["total"]);
        }
        dr.Close();
      }
      ProgressBar1.Value++;
      Application.DoEvents();

      using (SqlDataReader dr = ModuleData.ExecuteReader($"exec api_sp_ListeEtatComptaNC2 '{lDate} 22:00:00' , 1"))
      {
        if (dr.Read())
        {
          lblHT3.Text = Strings.FormatNumber(Utils.ZeroIfNull(dr["total"]), 0) + " €";
          somme += (double)Utils.ZeroIfNull(dr["total"]);
        }
        dr.Close();
      }
      ProgressBar1.Value++;
      Application.DoEvents();

      using (SqlDataReader dr = ModuleData.ExecuteReader($"exec api_sp_ListeEtatComptaNonExec '{lDate} 22:00:00'"))
      {
        if (dr.Read())
        {
          lblHT4.Text = Strings.FormatNumber(Utils.ZeroIfNull(dr["total"]), 0) + " €";
          somme += (double)Utils.ZeroIfNull(dr["total"]);
        }
        dr.Close();
      }

      //  total recette
      lblTHTh.Text = Strings.FormatNumber(somme, 0) + " €";
      ProgressBar1.Value++;
      Application.DoEvents();

      // ENCOURS CLIENTS. Ajustement des contrats préventifs mensualisés
      using (SqlDataReader dr = ModuleData.ExecuteReader($"exec api_sp_ListeEtatComptaFAEPCA '{lDate}'"))
      {
        double lTotalAjust = 0;

        while (dr.Read())
        {
          if (dr["CCONTRATPERACTIF"].ToString() == "OUI")
          {
            lTotalAjust += (double)Utils.ZeroIfNull(dr["DIFF"]);
          }
        }
        dr.Close();

        lblHT6.Text = Strings.FormatNumber(lTotalAjust, 0) + " €";
        somme += lTotalAjust;
      }

      //  total recette
      lblTHTh.Text = Strings.FormatNumber(somme, 0) + " €";
      total = (int)somme;
      ProgressBar1.Value++;
      Application.DoEvents();

      //  liste des dépenses
      somme = 0;

      using (SqlDataReader dr = ModuleData.ExecuteReader($"api_sp_ListeEtatComptaChargeSTT '{lDate} 22:00:00'"))
      {
        if (dr.Read())
        {
          lblHT5.Text = Strings.FormatNumber(Utils.ZeroIfNull(dr["total"]), 0) + " €";
          somme += (double)Utils.ZeroIfNull(dr["total"]);
        }
        dr.Close();
      }
      ProgressBar1.Value++;
      Application.DoEvents();

      using (SqlDataReader dr = ModuleData.ExecuteReader($"exec api_sp_ListeEtatComptaChargeFOU '{lDate} 22:00:00'"))
      {
        if (dr.Read())
        {
          lblHT7.Text = Strings.FormatNumber(Utils.ZeroIfNull(dr["total"]), 0) + " €";
          somme += (double)Utils.ZeroIfNull(dr["total"]);
        }
        dr.Close();
      }
      ProgressBar1.Value++;
      Application.DoEvents();

      using (SqlDataReader dr = ModuleData.ExecuteReader($"exec api_sp_ListeEtatComptaCSP '{lDate} 22:00:00'"))
      {
        if (dr.Read())
        {
          lblHT2.Text = "- " + Strings.FormatNumber(Utils.ZeroIfNull(dr["total"]), 0) + " €";
          somme -= (double)Utils.ZeroIfNull(dr["total"]);
        }
        dr.Close();
      }

      //  total depense
      lblTHTb.Text = Strings.FormatNumber(somme, 0) + " €";
      //  total
      total -= (int)somme;
      lblTT.Text = Strings.FormatNumber(total, 0) + " €";

      ProgressBar1.Value++;
      Application.DoEvents();

      using (SqlDataReader dr = ModuleData.ExecuteReader("select sum(total) as somme from api_v_Montantstock"))
      {
        if (dr.Read())
        {
          int temp = (int)Utils.ZeroIfNull(dr["somme"]) + 1;
          lblStock.Text = Strings.FormatNumber(temp, 0) + " €";
        }
        dr.Close();
      }
      ProgressBar1.Value++;
      Application.DoEvents();

      ProgressBar1.Visible = false;
      cmdVisuB.Enabled = true;

      Cursor = Cursors.Default;
    }
  }
}

