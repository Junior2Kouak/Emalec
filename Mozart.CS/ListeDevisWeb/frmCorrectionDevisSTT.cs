using MozartLib;
using MozartNet;
using ReportEmalec.Net;
using System;
using System.Data.SqlClient;
using System.Reflection;
using System.Windows.Forms;
using MZUtils = MozartControls.Utils;

namespace MozartCS
{
  public partial class frmCorrectionDevisSTT : Form
  {
    public int NumDevis;

    bool bEtat = false;

    public frmCorrectionDevisSTT() { InitializeComponent(); }

    private void frmCorrectionDevisSTT_Load(object sender, System.EventArgs e)
    {
      try
      {
        Cursor.Current = Cursors.WaitCursor;
        ModuleMain.Initboutons(this);

        // traitement du cas de modification ou de création
        OuvertureEnModification();
      }
      catch (Exception ex)
      {
        MZUtils.displayError(MethodBase.GetCurrentMethod().Name, ex);
      }
      finally { Cursor.Current = Cursors.Default; }
    }

    private void cmdFermer_Click(object sender, System.EventArgs e)
    {
      Dispose();
    }

    private void cmdValider_Click(object sender, EventArgs e)
    {
      try
      {
        // enregistrement des données
        string sSql = $"{NumDevis},'{txtCli.Text.Replace("'", "''")}','{txtSite.Text.Replace("'", "''")}','{txtPer.Text.Replace("'", "''")}'," +
                      $"'{txt1.Text.Replace("'", "''")}','{txt2.Text.Replace("'", "''")}','{txt3.Text.Replace("'", "''")}','{txt4.Text.Replace("'", "''")}'," +
                      $"'{txt5.Text.Replace("'", "''")}',{(txt6.Text != "" ? txt6.Text : "Null")},{(txt7.Text != "" ? txt7.Text : "Null")}," +
                      $"{(txt8.Text != "" ? txt8.Text : "Null")},{(txt9.Text != "" ? txt9.Text : "Null")},'{txtDate.Text}',{MozartParams.UID}, Getdate() " +
                      $",'{txt10.Text.Replace("'", "''")}','{txt11.Text.Replace("'", "''")}','{txt12.Text.Replace("'", "''")}','{txt13.Text.Replace("'", "''")}'," +
                      $"'{txt14.Text.Replace("'", "''")}','{txt15.Text.Replace("'", "''")}',0,'{txt16.Text.Replace("'", "''")}', '{txtCorSecu.Text.Replace("'", "''")}', '{txtOCorSecu.Text.Replace("'", "''")}'";

        ModuleData.CnxExecute($"delete from TWCORDEVIS where NWDEVNUM = {NumDevis}");
        ModuleData.CnxExecute($"insert into TWCORDEVIS (NWDEVNUM, VCLINOM, VSITNOM, TECH, TITRE, SUJET, CONSTAT, PREST, FOUR, HJ, HOP, " +
                                  $"HN, NBTECH, DATEDEVIS, CREATEUR, DATECOR, OTITRE, OSUJET, OCONSTAT, OPREST, OFOUR, OH, BCORLU, OBSGENERALE, " +
                                          $"VWDEV_SECU, OVWDEV_SECU) select {sSql}");

        //if (!bEtat)
        //{
        //  // c'est la premiere validation de la correction donc on envoie un mail a Michel
        //  string msg = $"Le chargé d'affaire {MozartParams.strUID} a validé une correction de devis pour le technicien {txtPer.Text}{Environment.NewLine}{Environment.NewLine}" +
        //              $" Client : {txtCli.Text}{Environment.NewLine}{Environment.NewLine}" +
        //              $" Site : {txtSite.Text}{Environment.NewLine}{Environment.NewLine}" +
        //              $@" Vous pouvez le visualiser dans Mozart : Reporting\Réalisation MTP\Correction devis tech {Environment.NewLine}{Environment.NewLine}";

        //  // gestion du mail du destinataire en fonction de la société
        //  //string dest = "";

        bEtat = true;

        MessageBox.Show("la correction a été enregistrée.", Program.AppTitle, MessageBoxButtons.OK, MessageBoxIcon.Information);
      }
      catch (Exception ex)
      {
        MZUtils.displayError(MethodBase.GetCurrentMethod().Name, ex);
      }
    }

    private void cmdVisu_Click(object sender, EventArgs e)
    {
      try
      {
        string[,] TdbGlobal = { { "COPIE", "COPIE" } };

        if (!bEtat)
        {
          MessageBox.Show("Enregistrez la correction pour pouvoir la visualiser", Program.AppTitle, MessageBoxButtons.OK, MessageBoxIcon.Information);
          return;
        }

        //new frmBrowser
        //{
        //  msInfosMail = "TWDEVIS|NPERNUM|0",
        //  mstrType = $"TEC${txtPer.Tag}${txtCli.Text}${txtSite.Text}"
        //}.Preview_Print(MozartParams.CheminModeles + MozartParams.Langue + @"\TCORDEVISTECH.RTF",
        //                 @"TCorDevisOut.rtf",
        //                 TdbGlobal,
        //                 $"exec api_sp_EditionCorDevis {NumDevis}",
        //                 " (Visualisation correction devis)",
        //                 "PREVIEW");

        new frmMainReport
        {
          bLaunchByProcessStart = false,
          sTypeReport = "TCORRDEVISTECH",
          sIdentifiant = NumDevis.ToString(),
          InfosMail = $"0|0|0",
          sNomSociete = MozartParams.NomSociete,
          sLangue = MozartParams.Langue,
          sOption = "PREVIEW",
        }.ShowDialog();

      }
      catch (Exception ex)
      {
        MZUtils.displayError(MethodBase.GetCurrentMethod().Name, ex);
      }
    }

    private void OuvertureEnModification()
    {
      string strImage = "";
      string sSql = "";
      try
      {
        // recherche des informations de l'action
        using (SqlDataReader sdr = ModuleData.ExecuteReader($"select * from api_v_ListeDevisWebTech where NWDEVNUM={NumDevis}"))
        {
          if (sdr.Read())
          {
            txtCli.Text = Utils.BlankIfNull(sdr["VCLINOM"]);
            txtSite.Text = Utils.BlankIfNull(sdr["VSITNOM"]);
            txtPer.Text = Utils.BlankIfNull(sdr["VPERNOM"]);
            txtPer.Tag = Utils.BlankIfNull(sdr["VPERMAI"]);
            txtDate.Text = Utils.DateLongBlankIfNull(sdr["DWDEVDSAISIE"]);
            txtTitre.Text = Utils.BlankIfNull(sdr["VWDEVTITRE"]);
            txtSujet.Text = Utils.BlankIfNull(sdr["VWDEVSUJET"]);
            txtConstat.Text = Utils.BlankIfNull(sdr["VWDEVCONSTAT"]);
            txtPrest.Text = Utils.BlankIfNull(sdr["VWDEVDESC"]);
            txtFour.Text = Utils.BlankIfNull(sdr["VWDEVFOU"]);
            TxtVWDEV_SECU.Text = Utils.BlankIfNull(sdr["VWDEV_SECU"]);

            txthj.Text = Utils.ZeroIfNull(sdr["NWDEVHJ"]).ToString();
            txthop.Text = Utils.ZeroIfNull(sdr["NWDEVHH"]).ToString();
            txthn.Text = Utils.ZeroIfNull(sdr["NWDEVHN"]).ToString();
            txttech.Text = Utils.ZeroIfNull(sdr["NWDEVTECH"]).ToString();
            txtDep.Text = Utils.BlankIfNull(sdr["VDEPLIB"]);
            txtContremaitre.Text = Utils.BlankIfNull(sdr["CONTREMAITRE"]);
            txtAnc.Text = Utils.BlankIfNull(sdr["ANC"]);
            txtChaff.Text = Utils.BlankIfNull(sdr["CHAFF"]);
            txtAss.Text = Utils.BlankIfNull(sdr["ASS"]);

            if (Utils.BlankIfNull(sdr["VPERIMAGE"]) != "" && sdr["VPERIMAGE"] != DBNull.Value)
              strImage = ModuleData.RechercheParam("REP_PHOTOS_PER", MozartParams.NomSociete) + Utils.BlankIfNull(sdr["VPERIMAGE"]);
            else
              strImage = "";

            Image1.Load(strImage);

            // recherche de l'action objet de la présence sur le site
            sSql = $"select top 1 vactdes, dactpla, tact.cprecod, vprelib from tact inner join tdin on tact.ndinnum=tdin.ndinnum inner" +
                   $" join tref_pre on tref_pre.cprecod = tact.cprecod Where nclinum = {sdr["NCLINUM"]} And tact.nSitNum = {sdr["NSITNUM"]}" +
                   $" and tref_pre.langue = '{MozartParams.Langue}' and tact.npernum={sdr["NPERNUM"]} and  dactpla < '{sdr["DWDEVDSAISIE"]}' order by dactpla desc ";
          }
        }
        using (SqlDataReader sdrAux = ModuleData.ExecuteReader(sSql))
        {
          while (sdrAux.Read())
          {
            txtAction.Text += Utils.BlankIfNull(sdrAux["vactdes"]);
            lblPla.Text += Utils.DateBlankIfNull(sdrAux["dactpla"]);
            txtTypePresta.Text = Utils.BlankIfNull(sdrAux["vprelib"]);
          }
        }

        //  recherche sui il y a deja une correction pour ce devis
        using (SqlDataReader sdr = ModuleData.ExecuteReader($"select * from TWCORDEVIS where NWDEVNUM={NumDevis}"))
        {
          if (sdr.Read())
          {
            txt1.Text = Utils.BlankIfNull(sdr["TITRE"]);
            txt2.Text = Utils.BlankIfNull(sdr["SUJET"]);
            txt3.Text = Utils.BlankIfNull(sdr["CONSTAT"]);
            txt4.Text = Utils.BlankIfNull(sdr["PREST"]);
            txt5.Text = Utils.BlankIfNull(sdr["FOUR"]);
            txt6.Text = Utils.BlankIfNull(sdr["HJ"]);
            txt7.Text = Utils.BlankIfNull(sdr["HOP"]);
            txt8.Text = Utils.BlankIfNull(sdr["HN"]);
            txt9.Text = Utils.ZeroIfNull(sdr["NBTECH"]).ToString();
            txt10.Text = Utils.BlankIfNull(sdr["OTITRE"]);
            txt11.Text = Utils.BlankIfNull(sdr["OSUJET"]);
            txt12.Text = Utils.BlankIfNull(sdr["OCONSTAT"]);
            txt13.Text = Utils.BlankIfNull(sdr["OPREST"]);
            txt14.Text = Utils.BlankIfNull(sdr["OFOUR"]);
            txt15.Text = Utils.BlankIfNull(sdr["OH"]);
            txt16.Text = Utils.BlankIfNull(sdr["OBSGENERALE"]);
            txtCorSecu.Text = Utils.BlankIfNull(sdr["VWDEV_SECU"]);
            txtOCorSecu.Text = Utils.BlankIfNull(sdr["OVWDEV_SECU"]);
            bEtat = true;
          }
          else
          {
            txt10.Text = "Mot clef générique pour le client";
            txt11.Text = "Phrase commençant par un verbe à l'infinitif";
            txt12.Text = "Toujours 3 paragraphes :\r\n- Constat\r\n- Prestation\r\n- Motivation du client\r\n";
            txt13.Text = "Toujours 3 paragraphes :\r\n- Avant\r\n- Pendant\r\n- Après\r\n";
            txt14.Text = "Etre précis : Désignation, Nombre, Référence";
          }
        }
      }
      catch (Exception ex)
      {
        MZUtils.displayError(MethodBase.GetCurrentMethod().Name, ex);
      }
    }

    private void txtALL_KeyPress(object sender, KeyPressEventArgs e)
    {
      KeyValidator.KeyPress_SaisieNombre(e);
    }
  }
}

