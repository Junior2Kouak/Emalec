using Microsoft.VisualBasic;
using MozartCS.Properties;
using MozartLib;
using MozartNet;
using System;
using System.Data.SqlClient;
using System.Reflection;
using System.Windows.Forms;
using MZUtils = MozartControls.Utils;

namespace MozartCS
{
  public partial class frmStatComptaSyntChaff : Form
  {
    public string mstrDate;
    public string mstrCpt;
    public string mstrCptLib;
    public string mstrsChaff;
    public string mstrChaffLib;

    public frmStatComptaSyntChaff() { InitializeComponent(); }

    private void frmStatComptaSyntChaff_Load(object sender, System.EventArgs e)
    {
      try
      {
        UseWaitCursor = true;
        ModuleMain.Initboutons(this);

        lblDate.Text += " " + mstrDate;
        //Retirer l'affichage des "0" en trop devant le numéro de compte ex : 012 -> 12
        lblCpt.Text += " " + mstrCptLib.TrimStart('0');
        lblChaff.Text += " " + mstrChaffLib;

        //titre selon
        //Actions exécutées à la date de référence, réalisées par
        lbl1.Text = $"{Resources.txt_actionExecDatRef}{MozartParams.NomSociete} (FAE)";
        //Actions exécutées à la date de référence, réalisées par un sous traitant
        lbl3.Text = $"{Resources.txt_actionsExeDatRefSTT} (FAE)";
        //Actions non exécutées à la date de référence, mais facturées au client
        lbl4.Text = $"{Resources.txt_actionNExeDatRefFactCli} (PCA)";
        lbl8.Text = Resources.txt_actionAjustContratPrev;

        //Actions exécutées à la date de référence, sans la facture du sous traitant 
        lbl5.Text = $"{Resources.txt_actionExeDatRefSTTsansFact} (FNP)";
        //§Actions exécutées à la date de référence, sans la facture fournisseur
        lbl7.Text = $"{Resources.txt_actionExeDatRefFourn} (FNP)";
        lbl2.Text = "Actions avec un CSP non soldé à la date de référence, ";
        lbl6.Text = "présentant une charge constatée d'avance (CCA)";

        // initialisation des valeurs
        lblHT1.Text = "";
        lblHT2.Text = "";
        lblHT3.Text = "";
        lblHT4.Text = "";
        lblHT5.Text = "";
        lblHT7.Text = "";
        lblHT8.Text = "";

        lblTHTb.Text = "";
        lblTHTh.Text = "";
        lblTT.Text = "";
        lblStock.Text = "";

        Rechercher();
      }
      catch (Exception ex)
      {
        MZUtils.displayError(MethodBase.GetCurrentMethod().Name, ex);
      }
      finally
      {
        UseWaitCursor = false;
      }
    }

    private void cmdVisuB_Click(object sender, EventArgs e)
    {
      try
      {
        string[,] TdbGlobal = {
          { "DateR", mstrDate },
          { "Num", "8" },
          { "Titre", $"Synthèse des états comptables à la date du {mstrDate}" },
          { "Date", DateTime.Now.ToShortDateString() },
          { "REMALEC", lblHT1.Text },
          { "RSTT", lblHT3.Text },
          { "RNE", lblHT4.Text },
          { "DCSTT", lblHT5.Text },
          { "DCFOU", lblHT7.Text },
          { "TR", lblTHTh.Text },
          { "TD", lblTHTb.Text },
          { "SOLDE", lblTT.Text },
          { "NCANNUM", mstrCpt },
          { "VCANLIB", mstrCptLib }
        };

        frmBrowser f = new frmBrowser
        {
          miPlanningAn = 0
        };
        f.Preview_Print($@"{MozartParams.CheminModeles}{MozartParams.Langue}\TEtatComptableSynt.rtf",
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

    private void Rechercher()
    {
      int total;
      double somme;

      try
      {
        ProgressBar1.Value = 1;
        ProgressBar1.Visible = true;
        ProgressBar1.Maximum = 9;

        Application.DoEvents();

        //liste des recettes
        int somComptaChaff = (int)ModuleData.ExecuteScalarInt($"exec api_sp_ListeEtatComptaChaff2 '{mstrDate} 22:00:00',{mstrCpt},{mstrsChaff},1");
        lblHT1.Text = Strings.FormatNumber(Utils.ZeroIfNull(somComptaChaff), 0) + " €";

        ProgressBar1.Value++;
        Application.DoEvents();

        int somComptaNCChaff = (int)ModuleData.ExecuteScalarInt($"exec api_sp_ListeEtatComptaNCChaff2 '{mstrDate} 22:00:00',{mstrCpt},{mstrsChaff},1");
        lblHT3.Text = Strings.FormatNumber(Utils.ZeroIfNull(somComptaNCChaff), 0) + " €";

        ProgressBar1.Value++;
        Application.DoEvents();

        int somComptaNonExecChaff = (-1)*(int)ModuleData.ExecuteScalarInt($"exec api_sp_ListeEtatComptaNonExecChaff '{mstrDate} 22:00:00',{mstrCpt},{mstrsChaff},1");

        lblHT4.Text = Strings.FormatNumber(Utils.ZeroIfNull(somComptaNonExecChaff), 0) + " €";

        // Ajustement des contrats prév mensuelles
        int somAjustContratPrevMens = 0;
        // 27/02/2023 - LEFORT : Suppression temporaire demandée
        //using (SqlDataReader sdrB = ModuleData.ExecuteReader($"exec api_sp_ListeEtatComptaFAEPCA '{mstrDate}', {mstrCpt}"))
        //{
        //  while (sdrB.Read())
        //  {
        //    if (sdrB["CCONTRATPERACTIF"].ToString() == "OUI")
        //    {
        //      somAjustContratPrevMens += Convert.ToInt32(Utils.ZeroIfNull(sdrB["DIFF"]));
        //    }
        //  }
        //  sdrB.Close();
        //}

        lblHT8.Text = Strings.FormatNumber(somAjustContratPrevMens, 0) + " €";

        ProgressBar1.Value++;
        Application.DoEvents();

        // total recette
        somme = somComptaChaff + somComptaNCChaff + somComptaNonExecChaff + somAjustContratPrevMens;
        lblTHTh.Text = Strings.FormatNumber(somme, 0) + " €";
        total = Convert.ToInt32(somme);

        ProgressBar1.Value++;
        Application.DoEvents();

        // liste des dépenses

        int somComptaChargeSTTChaff = 0;
        using (SqlDataReader sdrB = ModuleData.ExecuteReader($"exec api_sp_ListeEtatComptaChargeSTTChaff '{mstrDate} 22:00:00',{mstrCpt},{mstrsChaff}"))
        {
          while (sdrB.Read())
          {
            somComptaChargeSTTChaff += Convert.ToInt32(Utils.ZeroIfNull(sdrB["NACTVAL"]));
          }
        }
        lblHT5.Text = Strings.FormatNumber(Utils.ZeroIfNull(somComptaChargeSTTChaff), 0) + " €";

        ProgressBar1.Value++;
        Application.DoEvents();

        int somComptaChargeFOUChaff = 0;
        using (SqlDataReader sdrB = ModuleData.ExecuteReader($"exec api_sp_ListeEtatComptaChargeFOUChaff '{mstrDate} 22:00:00',{mstrCpt},{mstrsChaff}"))
        {
          while (sdrB.Read())
          {
            somComptaChargeFOUChaff += Convert.ToInt32(Utils.ZeroIfNull(sdrB["NACTVAL"]));
          }
        }
        lblHT7.Text = Strings.FormatNumber(Utils.ZeroIfNull(somComptaChargeFOUChaff), 0) + " €";

        ProgressBar1.Value++;
        Application.DoEvents();

        int somComptaChargeCSP = 0;
        using (SqlDataReader sdrB = ModuleData.ExecuteReader($"exec api_sp_ListeEtatComptaCSPChaff '{mstrDate} 22:00:00',{mstrCpt},{mstrsChaff}"))
        {
          while (sdrB.Read())
          {
            somComptaChargeCSP += Convert.ToInt32(Utils.ZeroIfNull(sdrB["ENCOURS"]));
          }
        }
        lblHT2.Text = "-" + Strings.FormatNumber(Utils.ZeroIfNull(somComptaChargeCSP), 0) + " €";

        // total depense
        somme = somComptaChargeSTTChaff + somComptaChargeFOUChaff - somComptaChargeCSP;
        lblTHTb.Text = Strings.FormatNumber(somme, 0) + " €";
        ProgressBar1.Value++;
        Application.DoEvents();

        //  total
        total -= Convert.ToInt32(somme);
        lblTT.Text = Strings.FormatNumber(total, 0) + " €";

        ProgressBar1.Value++;
        Application.DoEvents();

        ProgressBar1.Visible = false;
      }
      catch (Exception ex)
      {
        MZUtils.displayError(MethodBase.GetCurrentMethod().Name, ex);
      }
    }

    private void btnGlossaire_Click(object sender, EventArgs e)
    {
      MessageBox.Show(@"Glossaire

FAE = Facture A Etablir
    => Prestation exécutée avant la date de référence du reporting mais qui n'est pas encore facturé au client

PCA = Produit Constatés d'Avance
    => Facture établie pour une prestation non exécutée avant la date de référence du reporting

AAE = Avoir A Etablir
   Avoir non établi avant la date de référence du reporting

FNP = Facture Non Parvenue
    => Facture fournisseur non reçue concernant une prestation exécutée avant la date de référence du reporting

CCA = Charges Constatés d'Avance

AAR = Avoir A Recevoir
    => Avoir fournisseur non reçu avant la date de référence du reporting");
    }
  }
}

