using Microsoft.VisualBasic;
using MozartCS.Properties;
using MozartLib;
using MozartNet;
using System;
using System.Data.SqlClient;
using System.IO;
using System.Reflection;
using System.Text;
using System.Windows.Forms;
using MZUtils = MozartControls.Utils;

namespace MozartCS
{
  public partial class frmChoixDateTransfert : Form
  {

    string mcteAne = "";

    public frmChoixDateTransfert()
    {
      InitializeComponent();
    }

    private void frmChoixDateTransfert_Load(object sender, System.EventArgs e)
    {
      try
      {
        ModuleMain.Initboutons(this);
        txtDateA0.Text = DateTime.Now.AddDays(-30).ToShortDateString();
        txtDateA1.Text = DateTime.Now.AddDays(-15).ToShortDateString();
        Cursor = Cursors.Default;
      }
      catch (Exception ex)
      {
        MZUtils.displayError(MethodBase.GetCurrentMethod().Name, ex);
      }
    }

    private void cmdDate1_2_Click(object sender, EventArgs e)
    {
      string txtDate = "";
      if ((sender as Button).Name == "cmdDate1")
      {
        txtDate = txtDateA0.Text;
        Calendar1.Tag = 0;
      }
      else
      {
        txtDate = txtDateA1.Text;
        Calendar1.Tag = 1;
      }
      DateTime d;
      if (DateTime.TryParse(txtDate, out d))
        _curDate = Calendar1.Value = d;
      else { _curDate = DateTime.MinValue; Calendar1.Value = DateTime.Now; }
      Calendar1.Visible = true;
      Calendar1.ShowCalendar(new MouseEventArgs(MouseButtons.Left, 1, MousePosition.X - this.Location.X, MousePosition.Y - this.Location.Y, 0));
    }

    DateTime _curDate = DateTime.MinValue;
    private void Calendar1_CloseUp(object sender, EventArgs e)
    {
      Calendar1.Visible = false;
      if (_curDate == DateTime.MinValue) return;
      if ((int)Calendar1.Tag == 0) txtDateA0.Text = Calendar1.Value.ToShortDateString();
      else if ((int)Calendar1.Tag == 1) txtDateA1.Text = Calendar1.Value.ToShortDateString();
    }
    private void Calendar1_ValueChanged(object sender, EventArgs e)
    {
      if (Calendar1.Visible) _curDate = Calendar1.Value;
    }

    private void cmdValider_Click(object sender, EventArgs e)
    {

      try
      {
        // test des dates
        if (txtDateA0.Text == "")
        {
          MessageBox.Show(Resources.msg_SaisirDateDeb, Program.AppTitle, MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
          return;
        }

        TransfertFacture();

        if (!chkPrepa.Checked)
          Dispose();

      }
      catch (Exception ex)
      {
        MZUtils.displayError(MethodBase.GetCurrentMethod().Name, ex);

        new frmListeFacturesErrorForTransfert().ShowDialog();
      }

    }

    private void TransfertFacture()
    {
      try
      {
        string lTmpLabelFiliale;

        bool bOK = true;

        string strDirCompta = Utils.RechercheParam("REP_COMPTA") + MozartParams.NomSociete + @"\ECRV.txt"; // VL Xfer

        if (!Directory.Exists(Utils.RechercheParam("REP_COMPTA") + MozartParams.NomSociete))
          Directory.CreateDirectory(Utils.RechercheParam("REP_COMPTA") + MozartParams.NomSociete);


        //  nombre de factures
        int nombre = 0;

        //  ouverture du recordset des données

        using (SqlDataReader sdr = ModuleData.ExecuteReader($"api_sp_TransfertFacture '{txtDateA0.Text}', '{txtDateA1.Text}'"))
        {
          if (!sdr.HasRows)
          {
            Cursor = Cursors.Default;
            MessageBox.Show(Resources.msg_pasFactSelect, Program.AppTitle, MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
          }

          StringBuilder sData1 = new StringBuilder();
          StringBuilder sData2 = new StringBuilder();
          StringBuilder sData3 = new StringBuilder();

          // creation ou vidage du fichier
          File.WriteAllText(strDirCompta, "");

          // pour chaque facture on génère 3 lignes d'intégration
          while (sdr.Read())
          {
            nombre++;

            // initialisation des variables
            sData1.Clear();
            sData2.Clear();
            sData3.Clear();

            if (sdr["VFACSTA"].ToString() != "NON")
            {
              lTmpLabelFiliale = Convert.ToBoolean(sdr["BFILIALEEMALEC"]) ? "VI" : "V";

              sData1.Append($"{lTmpLabelFiliale};" + sdr["NFACNUM"].ToString() + ";");  //pièce - 8
              sData2.Append($"{lTmpLabelFiliale};" + sdr["NFACNUM"].ToString() + ";");  //pièce - 8
              sData3.Append($"{lTmpLabelFiliale};" + sdr["NFACNUM"].ToString() + ";");  //pièce - 8

              //    compte compta8 avec montant TTC - 9
              if (sdr["VRSFCPT8"] != null || sdr["VRSFCPT8"].ToString() != "")
              {
                if (MozartParams.NomSociete == "EMALEC")
                  sData1.Append(sdr["VRSFCPT8"].ToString() + Strings.Right("000000000", 9 - sdr["VRSFCPT8"].ToString().Length)); //Compte comptable - 9
                else
                  sData1.Append(sdr["VRSFCPT8"]);

                mcteAne = "";

                // Gestion des cas pour aller dans les bons comptes de wavesoft
                string paysSite = "";

                switch (MozartParams.NomSociete)
                {
                  case "EMALECESPAGNE":
                    sData1.Append(";1;");
                    sData2.Append("704100000;1;");
                    sData3.Append("445770000;1;");
                    break;

                  case "EMALECSUISSE":
                    sData1.Append(";1;");
                    sData2.Append("704000000;1;");
                    sData3.Append("445715000;1;");
                    break;

                  case "EMALECLUXEMBOURG":
                    // FGA le 6/01/25 demande de Raybois
                    sData1.Append(";1;");
                    switch (Convert.ToDouble(sdr["NELFTVA"]))
                    {
                      case 21:
                        if (sdr["NDINCTE"].ToString() == "204" || sdr["NDINCTE"].ToString() == "213" || sdr["NDINCTE"].ToString() == "218")
                          {sData2.Append("703430000;1;");}
                        else
                          {sData2.Append("703330000;1;");}
                        sData3.Append("461512000;1;");
                        break;
                      case 17:
                        if (sdr["NDINCTE"].ToString() == "204" || sdr["NDINCTE"].ToString() == "213" || sdr["NDINCTE"].ToString() == "218")
                          {sData2.Append("703410000;1;");}
                        else
                          {sData2.Append("703310000;1;");}
                        sData3.Append("461411000;1;");
                        break;
                      case 16:
                        if (sdr["NDINCTE"].ToString() == "204" || sdr["NDINCTE"].ToString() == "213" || sdr["NDINCTE"].ToString() == "218")
                          {sData2.Append("703400000;1;");}
                        else
                          {sData2.Append("703300000;1;");}
                        sData3.Append("461411000;1;");
                        break;
                      case 14:
                        if (sdr["NDINCTE"].ToString() == "204" || sdr["NDINCTE"].ToString() == "213" || sdr["NDINCTE"].ToString() == "218")
                          {sData2.Append("703480000;1;");}
                        else
                          {sData2.Append("703380000;1;");}
                        sData3.Append("461411000;1;");
                        break;
                      case 8:
                        if (sdr["NDINCTE"].ToString() == "204" || sdr["NDINCTE"].ToString() == "213" || sdr["NDINCTE"].ToString() == "218")
                          {sData2.Append("703470000;1;");}
                        else
                          {sData2.Append("703370000;1;");}
                        sData3.Append("461411000;1;");
                        break;
                      case 3:
                        if (sdr["NDINCTE"].ToString() == "204" || sdr["NDINCTE"].ToString() == "213" || sdr["NDINCTE"].ToString() == "218")
                          {sData2.Append("703460000;1;");}
                        else
                          {sData2.Append("703360000;1;");}
                        sData3.Append("461411000;1;");
                        break;
                      case 0:
                        //o Intracom(facturation dans l’UE) => CA : 7033400000 TVA: Néant
                        //o Hors UE / 0 % de TVA => CA : 703390000 TVA: Néant
                        if (sdr["NDINCTE"].ToString() == "204" || sdr["NDINCTE"].ToString() == "213" || sdr["NDINCTE"].ToString() == "218")
                          {sData2.Append("703440000;1;");}
                        else
                          {sData2.Append("703340000;1;");}
                        break;
                        default:  //16
                        if (sdr["NDINCTE"].ToString() == "204" || sdr["NDINCTE"].ToString() == "213" || sdr["NDINCTE"].ToString() == "218")
                          {sData2.Append("703400000;1;");}
                        else
                          {sData2.Append("703300000;1;");}
                        sData3.Append("461411000;1;");
                        break;
                    }
                    break;

                  case "EMALECFACILITEAM":
                    if (Convert.ToDouble(sdr["NELFTVA"]) == 21)
                    {
                      sData1.Append(";1;");

                      paysSite = PaysDuSite(Convert.ToInt64(sdr["NFACNUM"].ToString()));
                      switch (paysSite)
                      {
                        case "BELGIË":
                        case "BELGIQUE":
                          sData2.Append("704500000;1;");
                          sData3.Append("445740000;1;");
                          break;
                        case "PAYS-BAS":
                          sData2.Append("704610000;1;");
                          sData3.Append("445761000;1;");
                          break;
                        default:
                          sData2.Append("704400000;1;");
                          sData3.Append("445740000;1;");
                          break;
                      }
                      break;
                    }
                    else
                    {
                      // compte export
                      sData1.Append(";1;");

                      switch (sdr["VRSFPAYS"].ToString())
                      {
                        case "BELGIË":
                        case "BELGIQUE":
                          sData2.Append("704952000;1;");
                          sData3.Append("445740000;1;");
                          break;
                        case "PAYS-BAS":
                          sData2.Append("704953000;1;");
                          sData3.Append("445740000;1;");
                          break;
                        case "ALLEMAGNE":
                          sData2.Append("704959000;1;");
                          sData3.Append("445740000;1;");
                          break;
                        default:
                          sData2.Append("704950000;1;");
                          sData3.Append("445740000;1;");
                          break;
                      }
                    }
                    break;

                  default: // emalec, magestime, mpm, emalecdev, equipage, scs, idf
                    // cas particulier pour les refacturations entre filiales (compta ana 96) (on commence par Emalec
                    if (((sdr["NDINCTE"].ToString() == "96" || sdr["NDINCTE"].ToString() == "999" || sdr["NDINCTE"].ToString() == "997" || sdr["NDINCTE"].ToString() == "970"
                      || sdr["NDINCTE"].ToString() == "994") && MozartParams.NomSociete == "EMALEC") || MozartParams.NomSociete == "EMALECDEV")
                    {
                      // recherche des infos sur le telf (ana, compte 7, tva) 
                      SqlDataReader sdr2 = ModuleData.ExecuteReader($"select * from TREF_COMPTEPRODUIT where ID = {Utils.ZeroIfNull(sdr["IDCOMPTEPRODUIT"])}");
                      if (sdr2.Read())
                      {
                        sData1.Append(";" + sdr2["VCODE"] + ";");
                        sData2.Append(sdr2["VCOMPTE"] + ";" + sdr2["VCODE"] + ";");
                        sData3.Append(sdr2["VTVA"] + ";" + sdr2["VCODE"] + ";");
                        mcteAne = sdr2["VANA"].ToString();
                      }
                      else
                      {
                        sData1.Append(";8;");
                        sData2.Append("708860000;8;");
                        sData3.Append("445715000;8;");
                        mcteAne = sdr["NDINCTE"].ToString();
                      }

                      sdr2.Close();
                    }
                    else
                    {
                      if (sdr["VRSFPAYS"].ToString() == "FRANCE")
                      {
                        if (Convert.ToDouble(sdr["NELFTVA"]) == 19.6)
                        {
                          // compte de vente avec HT
                          sData1.Append(";3;");
                          sData2.Append("704200000;3;");
                          sData3.Append("445713000;3;");
                        }
                        else if (Convert.ToDouble(sdr["NELFTVA"]) == 5.5)
                        {
                          // compte de vente avec HT
                          sData1.Append(";2;");
                          sData2.Append("704100000;2;");
                          sData3.Append("445712000;2;");
                        }
                        else if (Convert.ToDouble(sdr["NELFTVA"]) == 7)
                        {
                          // compte de vente avec HT
                          sData1.Append(";7;");
                          sData2.Append("704300000;7;");
                          sData3.Append("445714000;7;");
                        }
                        else if (Convert.ToDouble(sdr["NELFTVA"]) == 20)
                        {
                          // compte de vente avec HT
                          sData1.Append(";8;");
                          sData2.Append("704000000;8;");
                          sData3.Append("445715000;8;");
                        }
                        else if (Convert.ToDouble(sdr["NELFTVA"]) == 10)
                        {
                          // compte de vente avec HT
                          sData1.Append(";9;");
                          sData2.Append("704310000;9;");
                          sData3.Append("445711000;9;");
                        }
                        else
                        {
                          // tva 0 compte export
                          sData1.Append(";1;");
                          sData2.Append("704400000;1;");
                          sData3.Append("445740000;1;");
                        }
                      }
                      else // hors france (raison social)
                      {
                        if (Convert.ToDouble(sdr["NELFTVA"]) == 21)
                        {
                          sData1.Append(";1;");

                          // compte belgique ou espagne
                          paysSite = PaysDuSite(Convert.ToInt64(sdr["NFACNUM"].ToString()));

                          if (paysSite == "BELGIË" || paysSite == "BELGIQUE")
                          {
                            sData2.Append("704500000;1;");
                            sData3.Append("445740000;1;");
                          }
                          else if (paysSite == "ESPAGNE")
                          {
                            sData2.Append("704700000;1;");
                            sData3.Append("445770000;1;");
                          }
                          else if (paysSite == "PAYS-BAS")
                          {
                            sData2.Append("704610000;1;");
                            sData3.Append("445761000;1;");
                          }
                          else
                          {
                            sData2.Append("704400000;1;");
                            sData3.Append("445740000;1;");
                          }
                        }
                        else if (Convert.ToDouble(sdr["NELFTVA"]) == 19)
                        {
                          // compte pays-bas
                          sData1.Append(";1;");
                          sData2.Append("704600000;1;");
                          sData3.Append("445760000;1;");
                        }
                        else if (Convert.ToDouble(sdr["NELFTVA"]) == 20)
                        {
                          paysSite = PaysDuSite(Convert.ToInt64(sdr["NFACNUM"].ToString()));

                          if (paysSite == "FRANCE")
                          {
                            sData1.Append(";8;");
                            sData2.Append("704000000;8;");
                            sData3.Append("445715000;8;");
                          }
                          else if (paysSite == "MONACO")
                          {
                            sData1.Append(";8;");
                            sData2.Append("704000000;8;");
                            sData3.Append("445715000;8;");
                          }
                          else
                          {
                            sData1.Append(";1;");
                            sData2.Append("704400000;1;");
                            sData3.Append("445740000;1;");
                          }
                        }
                        else if (Convert.ToDouble(sdr["NELFTVA"]) == 17)
                        {
                          // luxembourg
                          sData1.Append(";1;");
                          sData2.Append("704961000;1;");
                          sData3.Append("445790000;1;");
                        }
                        else if (Convert.ToDouble(sdr["NELFTVA"]) == 16)
                        {
                          // luxembourg
                          sData1.Append(";1;");
                          sData2.Append("704961000;1;");
                          sData3.Append("445790000;1;");
                        }
                        else
                        {
                          //compte export
                          sData1.Append(";1;");
                          if (sdr["VRSFPAYS"].ToString() == "BELGIË" || sdr["VRSFPAYS"].ToString() == "BELGIQUE")
                          {
                            sData2.Append("704952000;1;");
                            sData3.Append("445740000;1;");
                          }
                          else if (sdr["VRSFPAYS"].ToString() == "PAYS-BAS")
                          {
                            sData2.Append("704953000;1;");
                            sData3.Append("445740000;1;");
                          }
                          else if (sdr["VRSFPAYS"].ToString() == "ESPAGNE")
                          {
                            sData2.Append("704954000;1;");
                            sData3.Append("445740000;1;");
                          }
                          else if (sdr["VRSFPAYS"].ToString() == "ALLEMAGNE")
                          {
                            sData2.Append("704959000;1;");
                            sData3.Append("445740000;1;");
                          }
                          else if (sdr["VRSFPAYS"].ToString() == "SUISSE" || sdr["VRSFPAYS"].ToString() == "SWITZERLAND")
                          {
                            sData2.Append("704957000;1;");
                            sData3.Append("445757000;1;");
                          }
                          else if (sdr["VRSFPAYS"].ToString() == "LUXEMBOURG")
                          {
                            sData2.Append("704961000;1;");
                            sData3.Append("445790000;1;");
                          }
                          else
                          {
                            sData2.Append("704950000;1;");
                            sData3.Append("445740000;1;");
                          }
                        }
                      }

                    }
                    break;
                }

                sData1.Append(sdr["DFACDAT"].ToString() + ";"); //Date ecriture - 6
                sData2.Append(sdr["DFACDAT"].ToString() + ";"); //Date ecriture - 6
                sData3.Append(sdr["DFACDAT"].ToString() + ";"); //Date ecriture - 6

                //    libelle - 
		
                sData1.Append(Strings.Left(MozartParams.SupprimerCaracteresSpeciaux(sdr["VRSFRSF"].ToString()), 99) + ";"); //Libellé
                sData2.Append(Strings.Left(MozartParams.SupprimerCaracteresSpeciaux(sdr["VRSFRSF"].ToString()), 99) + ";"); //Libellé
                sData3.Append(Strings.Left(MozartParams.SupprimerCaracteresSpeciaux(sdr["VRSFRSF"].ToString()), 99) + ";"); //Libellé

                //    débit - 20
                //    mettre les TTC
                sData1.Append(Strings.Format(sdr["TOTALTTC"], ".00") + ";");
                sData2.Append(";");
                sData3.Append(";");

                //    crédit - 20
                sData1.Append(";");
                sData2.Append(Strings.Format(sdr["TOTALHT"], ".00") + ";");
                sData3.Append(Strings.Format(sdr["TOTALTVA"], ".00") + ";");

                //    Répartition échéance - 260
                //    calcul de la date d'échéance (idem facture)
                if (Convert.ToDouble(sdr["TOTALTTC"]) > 0)
                {
                  sData1.Append(sdr["VRSFECH"] + ";");

                  string scType = "";

                  switch (Utils.BlankIfNull(sdr["VRSFTYP"].ToString()).ToUpper())
                  {
                    case "CHEQUE":
                      scType = "CHQ";
                      break;
                    case "TRAITE":
                      scType = "LCRA";
                      break;
                    case "LCR":
                    case "MANDAT":
                    case "VIREMENT":
                    case "BO":
                      scType = "VB";
                      break;
                    case "":
                      scType = "";
                      break;

                    default:
                      MessageBox.Show(Resources.msg_facture_pas_editee + sdr["nfacnum"].ToString() + Resources.msg_modeReglementIncorrect + sdr["VRSFTYP"].ToString() + "> !", Program.AppTitle, MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                      bOK = false;
                      break;
                  }
                  sData1.Append(scType);
                }

                else
                {
                  sData1.Append(";");
                }

                if (bOK != false)
                {
                  sData1.Append(";");
                  sData2.Append(";;");
                  sData3.Append(";;");

                  //    Répartition analytique - 400
                  if ((sdr["NDINCTE"].ToString() == "96" || sdr["NDINCTE"].ToString() == "999" || sdr["NDINCTE"].ToString() == "997" || sdr["NDINCTE"].ToString() == "994") && MozartParams.NomSociete == "EMALEC")
                  {
                    sData1.Append(";");
                    sData2.Append(mcteAne + ";");
                    sData3.Append(";");
                  }
                  else
                  {
                    sData1.Append(";");
                    sData2.Append(sdr["NDINCTE"].ToString() + ";");
                    sData3.Append(";");
                  }

                  //    code tier
                  sData1.AppendLine(";");
                  sData2.AppendLine(";");
                  if (MozartParams.NomSociete == "EMALEC")
                    sData3.AppendLine(sdr["VRSFCPT8"].ToString() + Strings.Right("000000000", 9 - sdr["VRSFCPT8"].ToString().Length) + ";");
                  else
                    sData3.AppendLine(sdr["VRSFCPT8"].ToString());

                  //    écriture de la ligne
                  if (!chkPrepa.Checked)
                  {
                    StringBuilder sb = new StringBuilder();
                    sb.Append(sData1.ToString());
                    sb.Append(sData2.ToString());

                    // écriture de la ligne de tva uniquement si tva <> 0
                    //if (sdr["NELFTVA"].ToString() != "0") sb.Append(sData3.ToString());
                    if (Convert.ToDouble(sdr["NELFTVA"]) != 0) sb.Append(sData3.ToString());


                    //File.WriteAllText(strDirCompta, sb.ToString());
                    File.AppendAllText(strDirCompta, sb.ToString());

                    //      update dans la table indiquant que la ligne est passée en compta
                    ModuleData.ExecuteNonQuery("api_sp_UpdateTransfertFacture " + Convert.ToInt64(sdr["NFACNUM"].ToString()));
                  }
                }
              }
              else
              {
                //      si pas de compte, on ne transfert pas la ligne
                //      on passe a la ligne suivante
                MessageBox.Show(Resources.msg_pasComptePourFac, Program.AppTitle, MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                bOK = false;
              }
            }
            else
            {
              //      si pas édité, on ne transfert pas la ligne
              //      on passe a la ligne suivante
              MessageBox.Show(string.Format(Resources.msg_facture_pas_editee, sdr["nfacnum"]), Program.AppTitle, MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
              bOK = false;
            }
          }

          sdr.Close();
        }

        //  Fermeture et copie de sauvegarde du fichier
        Cursor = Cursors.Default;

        if (!chkPrepa.Checked)
        {
          File.Copy(strDirCompta, Utils.RechercheParam("REP_COMPTA") + MozartParams.NomSociete + @"\Archives\ECRV" + DateTime.Now.ToString("ddmmyyyyhhmmss") + ".txt");
          MessageBox.Show(Resources.msg_finPrepaFichier + "\r\n" + nombre + " " + Resources.msg_factureTransferee, Program.AppTitle, MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
        }

        if (chkPrepa.Checked)
        {
          if (!bOK)
            MessageBox.Show(Resources.msg_corrigerAnoEtLancerPrepa, Program.AppTitle, MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
          else
            MessageBox.Show(Resources.msg_pasErreurPrepaLancerTransfert, Program.AppTitle, MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
        }
      }
      catch (Exception ex)
      {
        Cursor = Cursors.Default;
        MZUtils.displayError(MethodBase.GetCurrentMethod().Name, ex);
        new frmListeFacturesErrorForTransfert().ShowDialog();
      }
    }

    public string PaysDuSite(long nfacnum)
    {
      string pays = "";
      try
      {
        pays = ModuleData.ExecuteScalarString("SELECT top 1 UPPER(VSITPAYS) FROM TFAC INNER JOIN TACT ON TACT.NELFNUM = TFAC.NELFNUM INNER JOIN TSIT ON TSIT.NSITNUM = TACT.NSITNUM Where nFacNum = " + nfacnum);
      }
      catch (Exception ex)
      {
        MZUtils.displayError(MethodBase.GetCurrentMethod().Name, ex);
      }

      return pays;
    }

  }
}

