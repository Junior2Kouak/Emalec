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
  public partial class frmTransfertODBilan : Form
  {
    public frmTransfertODBilan()
    {
      InitializeComponent();
    }

    private void frmTransfertODBilan_Load(object sender, System.EventArgs e)
    {
      try
      {
        ModuleMain.Initboutons(this);
        txtDateA.Text = DateTime.Now.ToString("dd/MM/yyyy");
          //DateTime.Now.Month > 6 ? DateTime.Now.ToString("30/06/yyyy") : DateTime.Now.AddYears(-1).ToString("31/12/yyyy");
        lstInfos.Items.Add(Resources.txt_compteRenduAvancement);
        lstInfos.Items.Add("");
      }
      catch (Exception ex)
      {
        MZUtils.displayError(MethodBase.GetCurrentMethod().Name, ex);
      }
    }

    DateTime _curDate = DateTime.MinValue;
    private void Calendar1_CloseUp(object sender, EventArgs e)
    {
      Calendar1.Visible = false;
      if (_curDate == DateTime.MinValue) return;
      txtDateA.Text = Calendar1.Value.ToShortDateString();
    }
    private void Calendar1_ValueChanged(object sender, EventArgs e)
    {
      if (Calendar1.Visible) _curDate = Calendar1.Value;
    }

    private void cmdDate1_Click(object sender, EventArgs e)
    {
      DateTime d;
      if (DateTime.TryParse(txtDateA.Text, out d))
        _curDate = Calendar1.Value = d;
      else { _curDate = DateTime.MinValue; Calendar1.Value = DateTime.Now; }
      Calendar1.Visible = true;
      Calendar1.ShowCalendar(new MouseEventArgs(MouseButtons.Left, 1, MousePosition.X - this.Location.X, MousePosition.Y - this.Location.Y, 0));
    }

    private void cmdValider_Click(object sender, EventArgs e)
    {
      // Préparation du fichier de transfert des écritures de bilan
      try
      {
        bool codeAux;
        int iSousTotal, iTotal = 0;
        string strDirCompta1, strDirCompta2 = "";
        StringBuilder sb1 = new StringBuilder();
        StringBuilder sb2 = new StringBuilder();
        StringBuilder sb3 = new StringBuilder();

        if (DateTime.Parse(txtDateA.Text).AddDays(1).Day != 1)
        {
          MessageBox.Show(Resources.msg_dateRefInvalideDernierJour, Program.AppTitle, MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
          return;
        }

        Cursor = Cursors.WaitCursor;

        lstInfos.Items.Clear();

        string sDate1 = DateTime.Parse(txtDateA.Text).ToString("dd/MM/yy");
        string sDate2 = DateTime.Parse(txtDateA.Text).AddDays(1).ToString("dd/MM/yy");

        bool lSameFile = (DateTime.Parse(txtDateA.Text).AddDays(1).Year == DateTime.Parse(txtDateA.Text).Year);

        if (!lSameFile)
        {
          strDirCompta1 = $@"{Utils.RechercheParam("REP_COMPTA")}{MozartParams.NomSociete}\ECRODBilan{DateTime.Parse(txtDateA.Text).Year}.txt";
          strDirCompta2 = $@"{Utils.RechercheParam("REP_COMPTA")}{MozartParams.NomSociete}\ECRODBilan{DateTime.Parse(txtDateA.Text).AddDays(1).Year}.txt";
        }
        else
        {
          strDirCompta1 = $@"{Utils.RechercheParam("REP_COMPTA")}{MozartParams.NomSociete}\ECRODBilan.txt";
          strDirCompta2 = strDirCompta1;
        }

        File.Delete(strDirCompta1);
        File.Delete(strDirCompta2);

        //-----------------------------------------------------------------------------------------------------------------------------------
        // Encours clients à la date de référence en retard réalisé par Emalec
        // ProcStock : api_sp_ListeEtatCompta
        //-----------------------------------------------------------------------------------------------------------------------------------

        lstInfos.Items.Add(string.Format(Resources.txt_rechercheEncoursCliRetard, MozartParams.NomSociete));
        lstInfos.Refresh();

        StringBuilder lSbGlo1 = new StringBuilder();
        StringBuilder lSbGlo2 = new StringBuilder();

        using (SqlDataReader sdr = ModuleData.ExecuteReader($"api_sp_ListeEtatCompta2 '{txtDateA.Text} 22:00:00'"))
        {
          lstInfos.Items.Add("\tEcriture des OD de bilan...");
          lstInfos.Refresh();

          iSousTotal = 0;

          while (sdr.Read()) //pour chaque écriture on génère les lignes d'intégration
          {
            if (Convert.ToDouble(sdr["NACTVAL"]) != 0.0)
            {
              CreerLigneType1(sdr, sb1, sDate1, "418100000", 1, "EE"); //TTC

              switch (sdr["vsitpays"].ToString())
              {
                case "FRANCE":
                  switch (Convert.ToDouble(sdr["tva"]))
                  {
                    case 20:
                      CreerLigneType2(sdr, sb2, sDate1, "704000000", 1, "EE", "8");
                      break;
                    case 10:
                      CreerLigneType2(sdr, sb2, sDate1, "704310000", 1, "EE", "9");
                      break;
                    case 19.6:
                      CreerLigneType2(sdr, sb2, sDate1, "704200000", 1, "EE", "3");
                      break;
                    case 70:
                      CreerLigneType2(sdr, sb2, sDate1, "704300000", 1, "EE", "7");
                      break;
                    case 5.5:
                      CreerLigneType2(sdr, sb2, sDate1, "704100000", 1, "EE", "2");
                      break;
                    case 0:
                      CreerLigneType2(sdr, sb2, sDate1, "704400000", 1, "EE", "1");
                      break;
                    default:
                      CreerLigneType2(sdr, sb2, sDate1, "704000000", 1, "EE", "8");
                      break;
                  }
                  break;

                case "BELGIQUE":
                  if (Convert.ToDouble(sdr["tva"]) == 0)
                    CreerLigneType2(sdr, sb2, sDate1, "704450000", 1, "EE", "1"); //HT
                  else
                    CreerLigneType2(sdr, sb2, sDate1, "704500000", 1, "EE", "1"); //HT
                  break;

                case "ESPAGNE":
                  if (Convert.ToDouble(sdr["tva"]) == 0)
                    CreerLigneType2(sdr, sb2, sDate1, "704470000", 1, "EE", "1"); //HT
                  else
                    CreerLigneType2(sdr, sb2, sDate1, "704700000", 1, "EE", "1"); //HT
                  break;

                case "PAYS-BAS":
                  if (Convert.ToDouble(sdr["tva"]) == 0)
                    CreerLigneType2(sdr, sb2, sDate1, "704460000", 1, "EE", "1"); //HT
                  else
                    CreerLigneType2(sdr, sb2, sDate1, "704600000", 1, "EE", "1"); //HT
                  break;

                case "SUISSE":
                  CreerLigneType2(sdr, sb2, sDate1, "704950000", 1, "EE", "1"); //HT
                  break;

                default:
                  CreerLigneType2(sdr, sb2, sDate1, "704400000", 1, "EE", "1"); //HT
                  break;
              }

              // Ligne TVA
              if (Convert.ToInt32(sdr["tva"]) > 0) CreerLigneType3(sdr, sb3, sDate1, "445870000", 1, "EE");

              lSbGlo1.Append(sb1);
              lSbGlo1.Append(sb2);
              if (sb3.Length != 0) lSbGlo1.Append(sb3);

              sb1.Clear();
              sb2.Clear();
              sb3.Clear();

              CreerLigneType1(sdr, sb1, sDate2, "418100000", -1, "EE"); //TTC

              switch (sdr["vsitpays"].ToString())
              {
                case "FRANCE":
                  switch (Convert.ToDouble(sdr["tva"]))
                  {
                    case 20:
                      CreerLigneType2(sdr, sb2, sDate2, "704000000", -1, "EE", "8");
                      break;
                    case 10:
                      CreerLigneType2(sdr, sb2, sDate2, "704310000", -1, "EE", "9");
                      break;
                    case 19.6:
                      CreerLigneType2(sdr, sb2, sDate2, "704200000", -1, "EE", "3");
                      break;
                    case 70:
                      CreerLigneType2(sdr, sb2, sDate2, "704300000", -1, "EE", "7");
                      break;
                    case 5.5:
                      CreerLigneType2(sdr, sb2, sDate2, "704100000", -1, "EE", "2");
                      break;
                    case 0:
                      CreerLigneType2(sdr, sb2, sDate2, "704400000", -1, "EE", "1");
                      break;
                    default:
                      CreerLigneType2(sdr, sb2, sDate2, "704400000", -1, "EE", "8");
                      break;
                  }
                  break;

                case "BELGIQUE":
                  if (Convert.ToDouble(sdr["tva"]) == 0)
                    CreerLigneType2(sdr, sb2, sDate2, "704450000", -1, "EE", "1"); //HT
                  else
                    CreerLigneType2(sdr, sb2, sDate2, "704500000", -1, "EE", "1"); //HT
                  break;

                case "ESPAGNE":
                  if (Convert.ToDouble(sdr["tva"]) == 0)
                    CreerLigneType2(sdr, sb2, sDate2, "704470000", -1, "EE", "1"); //HT
                  else
                    CreerLigneType2(sdr, sb2, sDate2, "704700000", -1, "EE", "1"); //HT
                  break;

                case "PAYS-BAS":
                  if (Convert.ToDouble(sdr["tva"]) == 0)
                    CreerLigneType2(sdr, sb2, sDate2, "704460000", -1, "EE", "1"); //HT
                  else
                    CreerLigneType2(sdr, sb2, sDate2, "704600000", -1, "EE", "1"); //HT
                  break;

                case "SUISSE":
                  CreerLigneType2(sdr, sb2, sDate2, "704950000", -1, "EE", "1"); //HT
                  break;

                default:
                  CreerLigneType2(sdr, sb2, sDate2, "704400000", -1, "EE", "1"); //HT
                  break;
              }

              // Ligne TVA
              if (Convert.ToInt32(sdr["tva"]) > 0) CreerLigneType3(sdr, sb3, sDate2, "445870000", -1, "EE");

              if (lSameFile)
              {
                lSbGlo1.Append(sb1);
                lSbGlo1.Append(sb2);
                if (sb3.Length != 0) lSbGlo1.Append(sb3);
              }
              else
              {
                lSbGlo2.Append(sb1);
                lSbGlo2.Append(sb2);
                if (sb3.Length != 0) lSbGlo2.Append(sb3);
              }

              sb1.Clear();
              sb2.Clear();
              sb3.Clear();

              iSousTotal++;
            }
          }
          sdr.Close();

          File.AppendAllText(strDirCompta1, lSbGlo1.ToString());
          if (!lSameFile) File.AppendAllText(strDirCompta2, lSbGlo2.ToString());
        }

        lstInfos.Items[lstInfos.Items.Count - 1] += $" OK ({iSousTotal} lignes)";
        lstInfos.Items.Add("\tEcriture des annulations des OD de bilan...");
        lstInfos.Items[lstInfos.Items.Count - 1] += $" OK ({iSousTotal} lignes)";
        lstInfos.Items.Add("");
        lstInfos.Refresh();

        iTotal += iSousTotal;


        //-----------------------------------------------------------------------------------------------------------------------------------
        // Encours clients fait par STT en retard
        // ProcStock : api_sp_ListeEtatComptaNC
        //-----------------------------------------------------------------------------------------------------------------------------------

        lstInfos.Items.Add(Resources.txt_rechercheEncoursCliSTTRetard);
        lstInfos.Refresh();

        lSbGlo1.Clear();
        lSbGlo2.Clear();

        using (SqlDataReader sdr = ModuleData.ExecuteReader($"api_sp_ListeEtatComptaNC2 '{txtDateA.Text} 22:00:00'"))
        {
          lstInfos.Items.Add("\r\n\tEcriture des OD de bilan...");
          lstInfos.Refresh();
          iSousTotal = 0;

          while (sdr.Read())
          {
            if (Convert.ToDouble(sdr["NACTVAL"]) != 0.0)
            {
              CreerLigneType1(sdr, sb1, sDate1, "418100000", 1, "CS"); //TTC

              switch (sdr["vsitpays"].ToString())
              {
                case "FRANCE":
                  switch (Convert.ToDouble(sdr["tva"]))
                  {
                    case 20:
                      CreerLigneType2(sdr, sb2, sDate1, "704000000", 1, "CS", "8");
                      break;
                    case 10:
                      CreerLigneType2(sdr, sb2, sDate1, "704310000", 1, "CS", "9");
                      break;
                    case 19.6:
                      CreerLigneType2(sdr, sb2, sDate1, "704200000", 1, "CS", "3");
                      break;
                    case 7:
                      CreerLigneType2(sdr, sb2, sDate1, "704300000", 1, "CS", "7");
                      break;
                    case 5.5:
                      CreerLigneType2(sdr, sb2, sDate1, "704100000", 1, "CS", "2");
                      break;
                    case 0:
                      CreerLigneType2(sdr, sb2, sDate1, "704400000", 1, "CS", "1");
                      break;
                    default:
                      CreerLigneType2(sdr, sb2, sDate1, "704000000", 1, "CS", "8");
                      break;
                  }
                  break;

                case "BELGIQUE":
                  if (Convert.ToDouble(sdr["tva"]) == 0)
                    CreerLigneType2(sdr, sb2, sDate1, "704450000", 1, "CS", "1"); //HT
                  else
                    CreerLigneType2(sdr, sb2, sDate1, "704500000", 1, "CS", "1"); //HT
                  break;

                case "ESPAGNE":
                  if (Convert.ToDouble(sdr["tva"]) == 0)
                    CreerLigneType2(sdr, sb2, sDate1, "704470000", 1, "CS", "1"); //HT
                  else
                    CreerLigneType2(sdr, sb2, sDate1, "704700000", 1, "CS", "1"); //HT
                  break;

                case "PAYS-BAS":
                  if (Convert.ToDouble(sdr["tva"]) == 0)
                    CreerLigneType2(sdr, sb2, sDate1, "704460000", 1, "CS", "1"); //HT
                  else
                    CreerLigneType2(sdr, sb2, sDate1, "704600000", 1, "CS", "1"); //HT
                  break;

                case "SUISSE":
                  CreerLigneType2(sdr, sb2, sDate1, "704950000", 1, "CS", "1"); //HT
                  break;

                default:
                  CreerLigneType2(sdr, sb2, sDate1, "704400000", 1, "CS", "1"); //HT
                  break;
              }

              // Ligne TVA
              if (Convert.ToInt32(sdr["tva"]) > 0) CreerLigneType3(sdr, sb3, sDate1, "445870000", 1, "CS");

              lSbGlo1.Append(sb1.ToString());
              lSbGlo1.Append(sb2.ToString());
              if (sb3.Length != 0) lSbGlo1.Append(sb3.ToString());

              sb1.Clear();
              sb2.Clear();
              sb3.Clear();

              CreerLigneType1(sdr, sb2, sDate2, "418100000", -1, "CS"); //TTC

              switch (sdr["vsitpays"].ToString())
              {
                case "FRANCE":
                  switch (Convert.ToDouble(sdr["tva"]))
                  {
                    case 20:
                      CreerLigneType2(sdr, sb2, sDate2, "704000000", -1, "CS", "8");
                      break;
                    case 10:
                      CreerLigneType2(sdr, sb2, sDate2, "704310000", -1, "CS", "9");
                      break;
                    case 19.6:
                      CreerLigneType2(sdr, sb2, sDate2, "704200000", -1, "CS", "3");
                      break;
                    case 7:
                      CreerLigneType2(sdr, sb2, sDate2, "704300000", -1, "CS", "7");
                      break;
                    case 5.5:
                      CreerLigneType2(sdr, sb2, sDate2, "704100000", -1, "CS", "2");
                      break;
                    case 0:
                      CreerLigneType2(sdr, sb2, sDate2, "704400000", -1, "CS", "1");
                      break;
                    default:
                      CreerLigneType2(sdr, sb2, sDate2, "704000000", -1, "CS", "8");
                      break;
                  }
                  break;

                case "BELGIQUE":
                  if (Convert.ToDouble(sdr["tva"]) == 0)
                    CreerLigneType2(sdr, sb2, sDate2, "704450000", -1, "CS", "1"); //HT
                  else
                    CreerLigneType2(sdr, sb2, sDate2, "704500000", -1, "CS", "1"); //HT
                  break;

                case "ESPAGNE":
                  if (Convert.ToDouble(sdr["tva"]) == 0)
                    CreerLigneType2(sdr, sb2, sDate2, "704470000", -1, "CS", "1"); //HT
                  else
                    CreerLigneType2(sdr, sb2, sDate2, "704700000", -1, "CS", "1"); //HT
                  break;

                case "PAYS-BAS":
                  if (Convert.ToDouble(sdr["tva"]) == 0)
                    CreerLigneType2(sdr, sb2, sDate2, "704460000", -1, "CS", "1"); //HT
                  else
                    CreerLigneType2(sdr, sb2, sDate2, "704600000", -1, "CS", "1"); //HT
                  break;

                case "SUISSE":
                  CreerLigneType2(sdr, sb2, sDate2, "704950000", -1, "CS", "1"); //HT
                  break;
                default:
                  CreerLigneType2(sdr, sb2, sDate2, "704400000", -1, "CS", "1"); //HT
                  break;
              }

              // Ligne TVA
              if (Convert.ToInt32(sdr["tva"]) > 0) CreerLigneType3(sdr, sb3, sDate2, "445870000", -1, "CS"); //TVA

              if (lSameFile)
              {
                lSbGlo1.Append(sb1);
                lSbGlo1.Append(sb2);
                if (sb3.Length != 0) lSbGlo1.Append(sb3);
              }
              else
              {
                lSbGlo2.Append(sb1);
                lSbGlo2.Append(sb2);
                if (sb3.Length != 0) lSbGlo2.Append(sb3);
              }

              sb1.Clear();
              sb2.Clear();
              sb3.Clear();

              iSousTotal++;
            }
          }
          sdr.Close();

          File.AppendAllText(strDirCompta1, lSbGlo1.ToString());
          if (!lSameFile) File.AppendAllText(strDirCompta2, lSbGlo2.ToString());
        }

        lstInfos.Items[lstInfos.Items.Count - 1] += $" OK ({iSousTotal} lignes)";
        lstInfos.Items.Add("\r\n\tEcriture des annulations des OD de bilan...");
        lstInfos.Items[lstInfos.Items.Count - 1] += $" OK ({iSousTotal} lignes)";
        lstInfos.Items.Add("");
        lstInfos.Refresh();

        iTotal += iSousTotal;

        //-----------------------------------------------------------------------------------------------------------------------------------
        // Encours clients à la date de référence en avance
        // ProcStock : api_sp_ListeEtatComptaNonExec
        //-----------------------------------------------------------------------------------------------------------------------------------

        lstInfos.Items.Add(Resources.txt_rechercheEncoursCliAvance);
        lstInfos.Refresh();

        lSbGlo1.Clear();
        lSbGlo2.Clear();

        using (SqlDataReader sdr = ModuleData.ExecuteReader($"api_sp_ListeEtatComptaNonExec '{txtDateA.Text} 22:00:00'"))
        {
          lstInfos.Items.Add("\r\n\tEcriture des OD de bilan...");
          lstInfos.Refresh();
          iSousTotal = 0;

          while (sdr.Read())
          {
            if (Convert.ToDouble(sdr["NACTVAL"]) != 0.0)
            {
              CreerLigneType4(sdr, sb1, sDate1, "487000000", -1, "EC"); //TTC

              switch (Convert.ToDouble(sdr["tva"]))
              {
                case 20:
                  CreerLigneType5(sdr, sb2, sDate1, "704000000", -1, "EC");
                  break;
                case 10:
                  CreerLigneType5(sdr, sb2, sDate1, "704310000", -1, "EC");
                  break;
                case 19.6:
                  CreerLigneType5(sdr, sb2, sDate1, "704200000", -1, "EC"); //HT
                  break;
                case 5.5:
                  CreerLigneType5(sdr, sb2, sDate1, "704100000", -1, "EC"); //HT
                  break;
                case 7:
                  CreerLigneType5(sdr, sb2, sDate1, "704300000", -1, "EC"); //HT
                  break;
                case 0:
                  CreerLigneType5(sdr, sb2, sDate1, "704400000", -1, "EC"); //HT
                  break;
                default:
                  CreerLigneType5(sdr, sb2, sDate1, "704000000", -1, "EC");
                  break;
              }

              // Pas de ligne de TVA

              lSbGlo1.Append(sb1.ToString());
              lSbGlo1.Append(sb2.ToString());

              sb1.Clear();
              sb2.Clear();

              CreerLigneType4(sdr, sb1, sDate2, "487000000", 1, "EC"); //TTC

              switch (Convert.ToDouble(sdr["tva"]))
              {
                case 20:
                  CreerLigneType5(sdr, sb2, sDate2, "704000000", 1, "EC"); //HT
                  break;
                case 10:
                  CreerLigneType5(sdr, sb2, sDate2, "704310000", 1, "EC"); //HT
                  break;
                case 19.6:
                  CreerLigneType5(sdr, sb2, sDate2, "704200000", 1, "EC"); //HT
                  break;
                case 7:
                  CreerLigneType5(sdr, sb2, sDate2, "704300000", 1, "EC"); //HT
                  break;
                case 5.5:
                  CreerLigneType5(sdr, sb2, sDate2, "704100000", 1, "EC"); //HT
                  break;
                case 0:
                  CreerLigneType5(sdr, sb2, sDate2, "704400000", 1, "EC"); //HT
                  break;
                default:
                  CreerLigneType5(sdr, sb2, sDate2, "704000000", 1, "EC"); //HT
                  break;
              }

              if (lSameFile)
              {
                lSbGlo1.Append(sb1.ToString());
                lSbGlo1.Append(sb2.ToString());
              }
              else
              {
                lSbGlo2.Append(sb1.ToString());
                lSbGlo2.Append(sb2.ToString());
              }

              sb1.Clear();
              sb2.Clear();

              iSousTotal++;
            }
          }
          sdr.Close();

          File.AppendAllText(strDirCompta1, lSbGlo1.ToString());
          if (!lSameFile) File.AppendAllText(strDirCompta2, lSbGlo2.ToString());
        }


        lstInfos.Items[lstInfos.Items.Count - 1] += $" OK ({iSousTotal} lignes)";
        lstInfos.Items.Add("\tEcriture des annulations des OD de bilan...");
        lstInfos.Items[lstInfos.Items.Count - 1] += $" OK ({iSousTotal} lignes)";
        lstInfos.Items.Add("");
        lstInfos.Refresh();

        iTotal += iSousTotal;

        //-----------------------------------------------------------------------------------------------------------------------------------
        // Encours sous traitants à la date de référence en retard
        // ProcStock : api_sp_ListeEtatComptaChargeSTT
        //-----------------------------------------------------------------------------------------------------------------------------------

        lstInfos.Items.Add(Resources.txt_rechercheEncoursSousTraitantsRetard);
        lstInfos.Refresh();

        lSbGlo1.Clear();
        lSbGlo2.Clear();

        using (SqlDataReader sdr = ModuleData.ExecuteReader($"api_sp_ListeEtatComptaChargeSTT '{txtDateA.Text} 22:00:00'"))
        {
          lstInfos.Items.Add("\r\n\tEcriture des OD de bilan...");
          lstInfos.Refresh();
          iSousTotal = 0;

          while (sdr.Read())
          {
            codeAux = true;

            if (Convert.ToDouble(sdr["NACTVAL"]) != 0.0)
            {

              switch (sdr["vsitpays"].ToString())
              {
                case "FRANCE":
                  // traitement cas autoliquidation avec ou sans tva
                  // si bureau veritas alors TVA
                  // si code = "FR" avec regarder facture Ravel
                  // sinon pas de TVA
                  //if (sdr["VSTFNOM"].ToString() == "BUREAU VERITAS" || sdr["VSTFNOM"].ToString() == "BUREAU VERITAS AGENCE CONTRATS NATIONAUX")
                  //{
                  //  CreerLigneType6(sdr, sb1, sDate1, "408100000", 1, "ST"); //TTC
                  //  CreerLigneType7(sdr, sb2, sDate1, "604200000", 1, "ST"); //HT
                  //  CreerLigneType8(sdr, sb3, sDate1, "445860000", 1, "ST"); //TVA
                  //}
                  //else
                  //{
                  if (sdr["sCode"].ToString() == "FR") //si fr on regarde la tva
                  {
                    if (Convert.ToDouble(sdr["tvafr"]) == 0)
                    {
                      // pas de tva
                      CreerLigneType6(sdr, sb1, sDate1, "408100000", 1, "ST", 0); //TTC
                      CreerLigneType7(sdr, sb2, sDate1, "604205000", 1, "ST", 0); //HT
                      codeAux = false;
                    }
                    else
                    {
                      CreerLigneType6(sdr, sb1, sDate1, "408100000", 1, "ST"); //TTC
                      CreerLigneType7(sdr, sb2, sDate1, "604200000", 1, "ST"); //HT
                      CreerLigneType8(sdr, sb3, sDate1, "445860000", 1, "ST"); //TVA
                    }
                  }
                  else
                  {
                    // pas de tva
                    CreerLigneType6(sdr, sb1, sDate1, "408100000", 1, "ST", 0); //TTC
                    CreerLigneType7(sdr, sb2, sDate1, "604205000", 1, "ST", 0); //HT
                    codeAux = false;
                  }
                  //}
                  break;

                case "AUTRICHE":
                  CreerLigneType6(sdr, sb1, sDate1, "408100000", 1, "ST"); //TTC
                  CreerLigneType7(sdr, sb2, sDate1, "604213000", 1, "ST"); //HT
                  CreerLigneType8(sdr, sb3, sDate1, "445860000", 1, "ST"); //TVA
                  break;

                case "ESPAGNE":
                  CreerLigneType6(sdr, sb1, sDate1, "408100000", 1, "ST"); //TTC
                  CreerLigneType7(sdr, sb2, sDate1, "604220000", 1, "ST"); //HT
                  CreerLigneType8(sdr, sb3, sDate1, "445860000", 1, "ST"); //TVA
                  break;

                case "SUISSE":
                  CreerLigneType6(sdr, sb1, sDate1, "408100000", 1, "ST"); //TTC
                  CreerLigneType7(sdr, sb2, sDate1, "604221000", 1, "ST"); //HT
                  CreerLigneType8(sdr, sb3, sDate1, "445860000", 1, "ST"); //TVA
                  break;

                case "BELGIQUE":
                  CreerLigneType6(sdr, sb1, sDate1, "408100000", 1, "ST"); //TTC
                  CreerLigneType7(sdr, sb2, sDate1, "604230000", 1, "ST"); //HT
                  CreerLigneType8(sdr, sb3, sDate1, "445860000", 1, "ST"); //TVA
                  break;

                case "LUXEMBOURG":
                  CreerLigneType6(sdr, sb1, sDate1, "408100000", 1, "ST"); //TTC
                  CreerLigneType7(sdr, sb2, sDate1, "604240000", 1, "ST"); //HT
                  CreerLigneType8(sdr, sb3, sDate1, "445860000", 1, "ST"); //TVA
                  break;

                case "ITALIE":
                  CreerLigneType6(sdr, sb1, sDate1, "408100000", 1, "ST"); //TTC
                  CreerLigneType7(sdr, sb2, sDate1, "604250000", 1, "ST"); //HT
                  CreerLigneType8(sdr, sb3, sDate1, "445860000", 1, "ST"); //TVA
                  break;

                case "ALLEMAGNE":
                  CreerLigneType6(sdr, sb1, sDate1, "408100000", 1, "ST"); //TTC
                  CreerLigneType7(sdr, sb2, sDate1, "604260000", 1, "ST"); //HT
                  CreerLigneType8(sdr, sb3, sDate1, "445860000", 1, "ST"); //TVA
                  break;

                case "PORTUGAL":
                  CreerLigneType6(sdr, sb1, sDate1, "408100000", 1, "ST"); //TTC
                  CreerLigneType7(sdr, sb2, sDate1, "604270000", 1, "ST"); //HT
                  CreerLigneType8(sdr, sb3, sDate1, "445860000", 1, "ST"); //TVA
                  break;

                case "PAYS-BAS":
                  CreerLigneType6(sdr, sb1, sDate1, "408100000", 1, "ST"); //TTC
                  CreerLigneType7(sdr, sb2, sDate1, "604280000", 1, "ST"); //HT
                  CreerLigneType8(sdr, sb3, sDate1, "445860000", 1, "ST"); //TVA
                  break;

                case "GRANDE BRETAGNE":
                  CreerLigneType6(sdr, sb1, sDate1, "408100000", 1, "ST"); //TTC
                  CreerLigneType7(sdr, sb2, sDate1, "604290000", 1, "ST"); //HT
                  CreerLigneType8(sdr, sb3, sDate1, "445860000", 1, "ST"); //TVA
                  break;

                case "REPUBLIQUE TCHEQUE":
                  CreerLigneType6(sdr, sb1, sDate1, "408100000", 1, "ST"); //TTC
                  CreerLigneType7(sdr, sb2, sDate1, "604300000", 1, "ST"); //HT
                  CreerLigneType8(sdr, sb3, sDate1, "445860000", 1, "ST"); //TVA
                  break;

                case "SLOVAQUIE":
                  CreerLigneType6(sdr, sb1, sDate1, "408100000", 1, "ST"); //TTC
                  CreerLigneType7(sdr, sb2, sDate1, "604310000", 1, "ST"); //HT
                  CreerLigneType8(sdr, sb3, sDate1, "445860000", 1, "ST"); //TVA
                  break;

                default:
                  CreerLigneType6(sdr, sb1, sDate1, "408100000", 1, "ST"); //TTC
                  CreerLigneType7(sdr, sb2, sDate1, "604200000", 1, "ST"); //HT
                  CreerLigneType8(sdr, sb3, sDate1, "445860000", 1, "ST"); //TVA
                  break;
              }

              lSbGlo1.Append(sb1.ToString());
              lSbGlo1.Append(sb2.ToString());
              if (codeAux) lSbGlo1.Append(sb3.ToString());

              sb1.Clear();
              sb2.Clear();
              sb3.Clear();

              // ligne de suppression au jour suivant
              codeAux = true;

              switch (sdr["vsitpays"].ToString())
              {
                case "FRANCE":
                  // traitement cas autoliquidation avec ou sans tva
                  // si bureau veritas alors TVA
                  // si code = "FR" avec regarder facture Ravel
                  // sinon pas de TVA
                  //if (sdr["VSTFNOM"].ToString() == "BUREAU VERITAS" || sdr["VSTFNOM"].ToString() == "BUREAU VERITAS AGENCE CONTRATS NATIONAUX")
                  //{
                  //  CreerLigneType6(sdr, sb1, sDate2, "408100000", -1, "ST"); //TTC
                  //  CreerLigneType7(sdr, sb2, sDate2, "604200000", -1, "ST"); //HT
                  //  CreerLigneType8(sdr, sb3, sDate2, "445860000", -1, "ST"); //TVA
                  //}
                  //else
                  //{
                  if (sdr["sCode"].ToString() == "FR") // si fr on regarde la tva
                  {
                    if (Convert.ToDouble(sdr["tvafr"]) == 0)
                    {
                      // pas de tva
                      CreerLigneType6(sdr, sb1, sDate2, "408100000", -1, "ST", 0); //TTC
                      CreerLigneType7(sdr, sb2, sDate2, "604205000", -1, "ST", 0); //HT
                      codeAux = false;
                    }
                    else
                    {
                      CreerLigneType6(sdr, sb1, sDate2, "408100000", -1, "ST"); //TTC
                      CreerLigneType7(sdr, sb2, sDate2, "604200000", -1, "ST"); //HT
                      CreerLigneType8(sdr, sb3, sDate2, "445860000", -1, "ST"); //TVA
                    }
                  }
                  else
                  {
                    // pas de tva
                    CreerLigneType6(sdr, sb1, sDate2, "408100000", -1, "ST", 0); //TTC
                    CreerLigneType7(sdr, sb2, sDate2, "604205000", -1, "ST", 0); //HT
                    codeAux = false;
                  }
                  //}
                  break;

                case "AUTRICHE":
                  CreerLigneType6(sdr, sb1, sDate2, "408100000", -1, "ST"); //TTC
                  CreerLigneType7(sdr, sb2, sDate2, "604213000", -1, "ST"); //HT
                  CreerLigneType8(sdr, sb3, sDate2, "445860000", -1, "ST"); //TVA
                  break;

                case "ESPAGNE":
                  CreerLigneType6(sdr, sb1, sDate2, "408100000", -1, "ST"); //TTC
                  CreerLigneType7(sdr, sb2, sDate2, "604220000", -1, "ST"); //ST
                  CreerLigneType8(sdr, sb3, sDate2, "445860000", -1, "ST"); //TVA
                  break;

                case "SUISSE":
                  CreerLigneType6(sdr, sb1, sDate2, "408100000", -1, "ST"); //TTC
                  CreerLigneType7(sdr, sb2, sDate2, "604221000", -1, "ST"); //HT
                  CreerLigneType8(sdr, sb3, sDate2, "445860000", -1, "ST"); //TVA
                  break;

                case "BELGIQUE":
                  CreerLigneType6(sdr, sb1, sDate2, "408100000", -1, "ST"); //TTC
                  CreerLigneType7(sdr, sb2, sDate2, "604230000", -1, "ST"); //HT
                  CreerLigneType8(sdr, sb3, sDate2, "445860000", -1, "ST"); //TVA
                  break;

                case "LUXEMBOURG":
                  CreerLigneType6(sdr, sb1, sDate2, "408100000", -1, "ST"); //TTC
                  CreerLigneType7(sdr, sb2, sDate2, "604240000", -1, "ST"); //HT
                  CreerLigneType8(sdr, sb3, sDate2, "445860000", -1, "ST"); //TVA
                  break;

                case "ITALIE":
                  CreerLigneType6(sdr, sb1, sDate2, "408100000", -1, "ST"); //TTC
                  CreerLigneType7(sdr, sb2, sDate2, "604250000", -1, "ST"); //HT
                  CreerLigneType8(sdr, sb3, sDate2, "445860000", -1, "ST"); //TVA
                  break;

                case "ALLEMAGNE":
                  CreerLigneType6(sdr, sb1, sDate2, "408100000", -1, "ST"); //TTC
                  CreerLigneType7(sdr, sb2, sDate2, "604260000", -1, "ST"); //HT
                  CreerLigneType8(sdr, sb3, sDate2, "445860000", -1, "ST"); //TVA
                  break;

                case "PORTUGAL":
                  CreerLigneType6(sdr, sb1, sDate2, "408100000", -1, "ST"); //TTC
                  CreerLigneType7(sdr, sb2, sDate2, "604270000", -1, "ST"); //HT
                  CreerLigneType8(sdr, sb3, sDate2, "445860000", -1, "ST"); //TVA
                  break;

                case "PAYS-BAS":
                  CreerLigneType6(sdr, sb1, sDate2, "408100000", -1, "ST"); //TTC
                  CreerLigneType7(sdr, sb2, sDate2, "604280000", -1, "ST"); //HT
                  CreerLigneType8(sdr, sb3, sDate2, "445860000", -1, "ST"); //TVA
                  break;

                case "GRANDE BRETAGNE":
                  CreerLigneType6(sdr, sb1, sDate2, "408100000", -1, "ST"); //TTC
                  CreerLigneType7(sdr, sb2, sDate2, "604290000", -1, "ST"); //HT
                  CreerLigneType8(sdr, sb3, sDate2, "445860000", -1, "ST"); //TVA
                  break;

                case "REPUBLIQUE TCHEQUE":
                  CreerLigneType6(sdr, sb1, sDate2, "408100000", -1, "ST"); //TTC
                  CreerLigneType7(sdr, sb2, sDate2, "604300000", -1, "ST"); //HT
                  CreerLigneType8(sdr, sb3, sDate2, "445860000", -1, "ST"); //TVA
                  break;

                case "SLOVAQUIE":
                  CreerLigneType6(sdr, sb1, sDate2, "408100000", -1, "ST"); //TTC
                  CreerLigneType7(sdr, sb2, sDate2, "604310000", -1, "ST"); //HT
                  CreerLigneType8(sdr, sb3, sDate2, "445860000", -1, "ST"); //TVA
                  break;

                default:
                  CreerLigneType6(sdr, sb1, sDate2, "408100000", -1, "ST"); //TTC
                  CreerLigneType7(sdr, sb2, sDate2, "604200000", -1, "ST"); //HT
                  CreerLigneType8(sdr, sb3, sDate2, "445860000", -1, "ST"); //TVA
                  break;
              }

              if (lSameFile)
              {
                lSbGlo1.Append(sb1.ToString());
                lSbGlo1.Append(sb2.ToString());
                if (codeAux) lSbGlo1.Append(sb3.ToString());
              }
              else
              {
                lSbGlo2.Append(sb1.ToString());
                lSbGlo2.Append(sb2.ToString());
                if (codeAux) lSbGlo2.Append(sb3.ToString());
              }

              sb1.Clear();
              sb2.Clear();
              sb3.Clear();

              iSousTotal++;
            }
          }
          sdr.Close();

          File.AppendAllText(strDirCompta1, lSbGlo1.ToString());
          if (!lSameFile) File.AppendAllText(strDirCompta2, lSbGlo2.ToString());
        }

        lstInfos.Items[lstInfos.Items.Count - 1] += $" OK ({iSousTotal} lignes)";
        lstInfos.Items.Add("\tEcriture des annulations des OD de bilan...");
        lstInfos.Items[lstInfos.Items.Count - 1] += $" OK ({iSousTotal} lignes)";
        lstInfos.Items.Add("");
        lstInfos.Refresh();

        iTotal += iSousTotal;

        //-----------------------------------------------------------------------------------------------------------------------------------
        // Encours fournisseurs à la date de référence en retard
        // ProcStock : api_sp_ListeEtatComptaChargeFOU
        //-----------------------------------------------------------------------------------------------------------------------------------

        lstInfos.Items.Add(Resources.txt_rechercheEncoursFournRetard);
        lstInfos.Refresh();

        lSbGlo1.Clear();
        lSbGlo2.Clear();

        using (SqlDataReader sdr = ModuleData.ExecuteReader($"api_sp_ListeEtatComptaChargeFou '{txtDateA.Text} 22:00:00'"))
        {
          lstInfos.Items.Add("\r\n\tEcritures des OD de bilan...");
          lstInfos.Refresh();
          iSousTotal = 0;

          while (sdr.Read())
          {
            if (Convert.ToDouble(sdr["NACTVAL"]) != 0.0)
            {
              CreerLigneType6(sdr, sb1, sDate1, "408100000", 1, "FO"); //TTC

              switch (sdr["vsitpays"].ToString())
              {
                case "FRANCE":

                  if (Strings.Left(sdr["VSTFNOM"].ToString(), 8) == "KILOUTOU")
                    CreerLigneType7(sdr, sb2, sDate1, "604100000", 1, "FO"); //HT
                  else if (sdr["VSTFNOM"].ToString() == "TAXI FOURNEL")
                    CreerLigneType7(sdr, sb2, sDate1, "625100000", 1, "FO"); //HT
                  else
                    CreerLigneType7(sdr, sb2, sDate1, "605000000", 1, "FO"); //HT

                  CreerLigneType8(sdr, sb3, sDate1, "445860000", 1, "FO"); //TVA
                  break;

                case "AUTRICHE":
                  CreerLigneType7(sdr, sb2, sDate1, "605071300", 1, "FO"); //HT
                  CreerLigneType8(sdr, sb3, sDate1, "445860000", 1, "FO"); //TVA
                  break;

                case "ESPAGNE":
                  CreerLigneType7(sdr, sb2, sDate1, "605020000", 1, "FO"); //HT
                  CreerLigneType8(sdr, sb3, sDate1, "445860000", 1, "FO"); //TVA
                  break;

                case "SUISSE":
                  CreerLigneType7(sdr, sb2, sDate1, "605021000", 1, "FO"); //HT
                  CreerLigneType8(sdr, sb3, sDate1, "445860000", 1, "FO"); //TVA
                  break;

                case "BELGIQUE":
                  CreerLigneType7(sdr, sb2, sDate1, "605030000", 1, "FO"); //HT
                  CreerLigneType8(sdr, sb3, sDate1, "445860000", 1, "FO"); //TVA
                  break;

                case "LUXEMBOURG":
                  CreerLigneType7(sdr, sb2, sDate1, "605040000", 1, "FO"); //HT
                  CreerLigneType8(sdr, sb3, sDate1, "445860000", 1, "FO"); //TVA
                  break;

                case "ITALIE":
                  CreerLigneType7(sdr, sb2, sDate1, "605050000", 1, "FO"); //HT
                  CreerLigneType8(sdr, sb3, sDate1, "445860000", 1, "FO"); //TVA
                  break;

                case "ALLEMAGNE":
                  CreerLigneType7(sdr, sb2, sDate1, "605060000", 1, "FO"); //HT
                  CreerLigneType8(sdr, sb3, sDate1, "445860000", 1, "FO"); //TVA
                  break;

                case "PORTUGAL":
                  CreerLigneType7(sdr, sb2, sDate1, "605070000", 1, "FO"); //HT
                  CreerLigneType8(sdr, sb3, sDate1, "445860000", 1, "FO"); //TVA
                  break;

                case "PAYS-BAS":
                  CreerLigneType7(sdr, sb2, sDate1, "605080000", 1, "FO"); //HT
                  CreerLigneType8(sdr, sb3, sDate1, "445860000", 1, "FO"); //TVA
                  break;

                case "GRANDE BRETAGNE":
                  CreerLigneType7(sdr, sb2, sDate1, "605090000", 1, "FO"); //HT
                  CreerLigneType8(sdr, sb3, sDate1, "445860000", 1, "FO"); //TVA
                  break;

                case "REPUBLIQUE TCHEQUE":
                  CreerLigneType7(sdr, sb2, sDate1, "605140000", 1, "FO"); //HT
                  CreerLigneType8(sdr, sb3, sDate1, "445860000", 1, "FO"); //TVA
                  break;

                default:
                  CreerLigneType7(sdr, sb2, sDate1, "605000000", 1, "FO"); //HT
                  CreerLigneType8(sdr, sb3, sDate1, "445860000", 1, "FO"); //TVA
                  break;
              }

              lSbGlo1.Append(sb1.ToString());
              lSbGlo1.Append(sb2.ToString());
              if (sb3.Length != 0) lSbGlo1.Append(sb3.ToString());

              sb1.Clear();
              sb2.Clear();
              sb3.Clear();

              // ligne de suppression au jour suivant
              CreerLigneType6(sdr, sb1, sDate2, "408100000", -1, "FO"); //TTC

              switch (sdr["vsitpays"].ToString())
              {
                case "FRANCE":
                  if (Strings.Left(sdr["VSTFNOM"].ToString(), 8) == "KILOUTOU")
                    CreerLigneType7(sdr, sb2, sDate2, "604100000", -1, "FO"); //HT
                  else if (Strings.Left(sdr["VSTFNOM"].ToString(), 9) == "SELECTOUR")
                    CreerLigneType7(sdr, sb2, sDate2, "625100000", -1, "FO"); //HT
                  else if (sdr["VSTFNOM"].ToString() == "TAXI FOURNEL")
                    CreerLigneType7(sdr, sb2, sDate2, "625100000", -1, "FO"); //HT
                  else
                    CreerLigneType7(sdr, sb2, sDate2, "605000000", -1, "FO"); //HT

                  CreerLigneType8(sdr, sb3, sDate2, "445860000", -1, "FO"); //TVA
                  break;

                case "AUTRICHE":
                  CreerLigneType7(sdr, sb2, sDate2, "605071300", -1, "FO"); //HT
                  CreerLigneType8(sdr, sb3, sDate2, "445860000", -1, "FO"); //TVA
                  break;

                case "ESPAGNE":
                  CreerLigneType7(sdr, sb2, sDate2, "605020000", -1, "FO"); //HT
                  CreerLigneType8(sdr, sb3, sDate2, "445860000", -1, "FO"); //TVA
                  break;

                case "SUISSE":
                  CreerLigneType7(sdr, sb2, sDate2, "605021000", -1, "FO"); //HT
                  CreerLigneType8(sdr, sb3, sDate2, "445860000", -1, "FO"); //TVA
                  break;

                case "BELGIQUE":
                  CreerLigneType7(sdr, sb2, sDate2, "605030000", -1, "FO"); //HT
                  CreerLigneType8(sdr, sb3, sDate2, "445860000", -1, "FO"); //TVA
                  break;

                case "LUXEMBOURG":
                  CreerLigneType7(sdr, sb2, sDate2, "605040000", -1, "FO"); //HT
                  CreerLigneType8(sdr, sb3, sDate2, "445860000", -1, "FO"); //TVA
                  break;

                case "ITALIE":
                  CreerLigneType7(sdr, sb2, sDate2, "605050000", -1, "FO"); //HT
                  CreerLigneType8(sdr, sb3, sDate2, "445860000", -1, "FO"); //TVA
                  break;

                case "ALLEMAGNE":
                  CreerLigneType7(sdr, sb2, sDate2, "605060000", -1, "FO"); //HT
                  CreerLigneType8(sdr, sb3, sDate2, "445860000", -1, "FO"); //TVA
                  break;

                case "PORTUGAL":
                  CreerLigneType7(sdr, sb2, sDate2, "605070000", -1, "FO"); //HT
                  CreerLigneType8(sdr, sb3, sDate2, "445860000", -1, "FO"); //TVA
                  break;

                case "PAYS-BAS":
                  CreerLigneType7(sdr, sb2, sDate2, "605080000", -1, "FO"); //HT
                  CreerLigneType8(sdr, sb3, sDate2, "445860000", -1, "FO"); //TVA
                  break;

                case "REPUBLIQUE TCHEQUE":
                  CreerLigneType7(sdr, sb2, sDate2, "605140000", -1, "FO"); //HT
                  CreerLigneType8(sdr, sb3, sDate2, "445860000", -1, "FO"); //TVA
                  break;

                default:
                  CreerLigneType7(sdr, sb2, sDate2, "605000000", -1, "FO"); //HT
                  CreerLigneType8(sdr, sb3, sDate2, "445860000", -1, "FO"); //TVA
                  break;
              }

              if (lSameFile)
              {
                lSbGlo1.Append(sb1.ToString());
                lSbGlo1.Append(sb2.ToString());
                if (sb3.Length != 0) lSbGlo1.Append(sb3.ToString());
              }
              else
              {
                lSbGlo2.Append(sb1.ToString());
                lSbGlo2.Append(sb2.ToString());
                if (sb3.Length != 0) lSbGlo2.Append(sb3.ToString());
              }

              sb1.Clear();
              sb2.Clear();
              sb3.Clear();

              iSousTotal++;
            }
          }
          sdr.Close();

          File.AppendAllText(strDirCompta1, lSbGlo1.ToString());
          if (!lSameFile) File.AppendAllText(strDirCompta2, lSbGlo2.ToString());
        }

        lstInfos.Items[lstInfos.Items.Count - 1] += $" OK ({iSousTotal} lignes)";
        lstInfos.Items.Add("\tEcriture des annulations des OD de bilan...");
        lstInfos.Items[lstInfos.Items.Count - 1] += $" OK ({iSousTotal} lignes)";
        lstInfos.Items.Add("");
        lstInfos.Refresh();

        iTotal += iSousTotal;


        //-----------------------------------------------------------------------------------------------------------------------------------
        // Encours CSP à la date de référence en avance
        // ProcStock : api_sp_ListeEtatComptaCSP
        //-----------------------------------------------------------------------------------------------------------------------------------

        lstInfos.Items.Add("Recherche des Encours CPS sous traitants en avance...");
        lstInfos.Refresh();

        lSbGlo1.Clear();
        lSbGlo2.Clear();

        using (SqlDataReader sdr = ModuleData.ExecuteReader($"api_sp_ListeEtatComptaCSP '{txtDateA.Text} 22:00:00'"))
        {
          lstInfos.Items.Add("\r\n\tEcriture des OD de bilan...");
          lstInfos.Refresh();
          iSousTotal = 0;

          while (sdr.Read())
          {
            if (Convert.ToDouble(sdr["ENCOURS"]) != 0.0)
            {
              // pas de tva
              CreerLigneType4(sdr, sb1, sDate1, "486000000", 1, "AV"); //TTC

              switch (sdr["vsitpays"].ToString())
              {
                case "FRANCE":
                  CreerLigneType5(sdr, sb2, sDate1, "604205000", 1, "AV"); //HT
                  break;
                case "AUTRICHE":
                  CreerLigneType5(sdr, sb2, sDate1, "604213000", 1, "AV"); //HT
                  break;
                case "ESPAGNE":
                  CreerLigneType5(sdr, sb2, sDate1, "604220000", 1, "AV"); //HT
                  break;
                case "SUISSE":
                  CreerLigneType5(sdr, sb2, sDate1, "604221000", 1, "AV"); //HT
                  break;
                case "BELGIQUE":
                  CreerLigneType5(sdr, sb2, sDate1, "604230000", 1, "AV"); //HT
                  break;
                case "LUXEMBOURG":
                  CreerLigneType5(sdr, sb2, sDate1, "604240000", 1, "AV"); //HT
                  break;
                case "ITALIE":
                  CreerLigneType5(sdr, sb2, sDate1, "604250000", 1, "AV"); //HT
                  break;
                case "ALLEMAGNE":
                  CreerLigneType5(sdr, sb2, sDate1, "604260000", 1, "AV"); //HT
                  break;
                case "PORTUGAL":
                  CreerLigneType5(sdr, sb2, sDate1, "604270000", 1, "AV"); //HT
                  break;
                case "PAYS-BAS":
                  CreerLigneType5(sdr, sb2, sDate1, "604280000", 1, "AV"); //HT
                  break;
                case "GRANDE BRETAGNE":
                  CreerLigneType5(sdr, sb2, sDate1, "604290000", 1, "AV"); //HT
                  break;
                case "REPUBLIQUE TCHEQUE":
                  CreerLigneType5(sdr, sb2, sDate1, "604300000", 1, "AV"); //HT
                  break;
                case "SLOVAQUIE":
                  CreerLigneType5(sdr, sb2, sDate1, "604310000", 1, "AV"); //HT
                  break;
                default:
                  CreerLigneType5(sdr, sb2, sDate1, "604200000", 1, "AV"); //HT
                  break;
              }

              lSbGlo1.Append(sb1.ToString());
              lSbGlo1.Append(sb2.ToString());

              sb1.Clear();
              sb2.Clear();

              // pas de tva
              CreerLigneType4(sdr, sb1, sDate2, "486000000", -1, "AV"); //TTC

              switch (sdr["vsitpays"].ToString())
              {
                case "FRANCE":
                  CreerLigneType5(sdr, sb2, sDate2, "604205000", -1, "AV"); //HT
                  break;
                case "AUTRICHE":
                  CreerLigneType5(sdr, sb2, sDate2, "604213000", -1, "AV"); //HT
                  break;
                case "ESPAGNE":
                  CreerLigneType5(sdr, sb2, sDate2, "604220000", -1, "AV"); //ST
                  break;
                case "SUISSE":
                  CreerLigneType5(sdr, sb2, sDate2, "604221000", -1, "AV"); //HT
                  break;
                case "BELGIQUE":
                  CreerLigneType5(sdr, sb2, sDate2, "604230000", -1, "AV"); //HT
                  break;
                case "LUXEMBOURG":
                  CreerLigneType5(sdr, sb2, sDate2, "604240000", -1, "AV"); //HT
                  break;
                case "ITALIE":
                  CreerLigneType5(sdr, sb2, sDate2, "604250000", -1, "AV"); //HT
                  break;
                case "ALLEMAGNE":
                  CreerLigneType5(sdr, sb2, sDate2, "604260000", -1, "AV"); //HT
                  break;
                case "PORTUGAL":
                  CreerLigneType5(sdr, sb2, sDate2, "604270000", -1, "AV"); //HT
                  break;
                case "PAYS-BAS":
                  CreerLigneType5(sdr, sb2, sDate2, "604280000", -1, "AV"); //HT
                  break;
                case "GRANDE BRETAGNE":
                  CreerLigneType5(sdr, sb2, sDate2, "604290000", -1, "AV"); //HT
                  break;
                case "REPUBLIQUE TCHEQUE":
                  CreerLigneType5(sdr, sb2, sDate2, "604300000", -1, "AV"); //HT
                  break;
                case "SLOVAQUIE":
                  CreerLigneType5(sdr, sb2, sDate2, "604310000", -1, "AV"); //HT
                  break;
                default:
                  CreerLigneType5(sdr, sb2, sDate2, "604200000", -1, "AV"); //HT
                  break;
              }

              if (lSameFile)
              {
                lSbGlo1.Append(sb1.ToString());
                lSbGlo1.Append(sb2.ToString());
              }
              else
              {
                lSbGlo2.Append(sb1.ToString());
                lSbGlo2.Append(sb2.ToString());
              }

              sb1.Clear();
              sb2.Clear();

              iSousTotal++;
            }
          }
          sdr.Close();

          File.AppendAllText(strDirCompta1, lSbGlo1.ToString());
          if (!lSameFile) File.AppendAllText(strDirCompta2, lSbGlo2.ToString());
        }

        lstInfos.Items[lstInfos.Items.Count - 1] += $" OK ({iSousTotal} lignes)";
        lstInfos.Items.Add("\tEcriture des annulations des OD de bilan...");
        lstInfos.Items[lstInfos.Items.Count - 1] += $" OK ({iSousTotal} lignes)";
        lstInfos.Items.Add("");
        lstInfos.Refresh();

        iTotal += iSousTotal;

        //  copie de sauvegarde du fichier
        File.Copy(strDirCompta1, Utils.RechercheParam("REP_COMPTA") + MozartParams.NomSociete + @"\archives\ECR-ODBilan" + DateTime.Now.ToString("ddmmyyyyhhmmss") + ".dat");

        iTotal *= 2;

        lstInfos.Items.Add("");
        lstInfos.Items.Add("\tGénération du fichier terminée.");
        lstInfos.Items.Add($"\t{iTotal} écritures à transférer.");
        lstInfos.Refresh();

        Cursor = Cursors.Default;

        MessageBox.Show(Resources.msg_GeneFichTermine + "\r\n\r\n" + iTotal + Resources.msg_EcrituresATransferer, Program.AppTitle, MessageBoxButtons.OK, MessageBoxIcon.Exclamation);

        // si transfert des en cours pour l ' an prochain est coché
        if (ChkSaveODBilan.Checked)
        {
          MessageBox.Show("Le traitement des encours pour le tableau analytique va être lancé. L'opération peut durer plusieurs minutes !", Program.AppTitle, MessageBoxButtons.OK, MessageBoxIcon.Exclamation);

          // test si deja des données sur cette année d'après

          int nbExist = (int)ModuleData.ExecuteScalarInt($"exec api_sp_VerifODBilanAnalytique '{txtDateA.Text} 22:00:00'");

          if (nbExist > 0)
            MessageBox.Show($"Il existe déjà des données sur l'année : {DateTime.Parse(txtDateA.Text).AddYears(1).Year}.\r\n Contactez votre service informatique", Program.AppTitle, MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
          else
          {
            Cursor = Cursors.WaitCursor;
            ModuleData.CnxExecute($"api_sp_JobCalculEncoursODBILAN '{txtDateA.Text} 22:00:00', '{MozartParams.NomSociete}'");
            Cursor = Cursors.Default;
            MessageBox.Show("Traitement terminé !", Program.AppTitle, MessageBoxButtons.OK, MessageBoxIcon.Information);
          }
        }
      }
      catch (Exception ex)
      {
        Cursor = Cursors.Default;
        MZUtils.displayError(MethodBase.GetCurrentMethod().Name, ex);
      }
    }

    private void cmdAAR_Click(object sender, EventArgs e)
    {
      // Préparation du fichier de transfert des écritures de bilan
      try
      {
        int rc = 0; //compteur d'éléments 
        string strDirCompta, strDirCompta2 = "";
        StringBuilder sb = new StringBuilder();
        StringBuilder sb2 = new StringBuilder();

        if (DateTime.Parse(txtDateA.Text).AddDays(1).Day != 1)
        {
          MessageBox.Show(Resources.msg_dateRefInvalideDernierJour, Program.AppTitle, MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
          return;
        }
        Cursor = Cursors.WaitCursor;

        lstInfos.Items.Clear();

        string sDate1 = DateTime.Parse(txtDateA.Text).ToString("dd/MM/yy");
        string sDate2 = DateTime.Parse(txtDateA.Text).AddDays(1).ToString("dd/MM/yy");

        if (DateTime.Parse(txtDateA.Text).AddDays(1).Year != DateTime.Parse(txtDateA.Text).Year)
        {
          strDirCompta = Utils.RechercheParam("REP_COMPTA") + MozartParams.NomSociete + @"\ECRODavoir" + DateTime.Parse(txtDateA.Text).Year.ToString() + ".txt";
          strDirCompta2 = Utils.RechercheParam("REP_COMPTA") + MozartParams.NomSociete + @"\ECRODavoir" + DateTime.Parse(txtDateA.Text).AddDays(1).Year.ToString() + ".txt";
          File.Delete(strDirCompta2);
        }
        else
        {
          strDirCompta = Utils.RechercheParam("REP_COMPTA") + MozartParams.NomSociete + @"\ECRODavoir.txt";
          strDirCompta2 = strDirCompta;
        }

        File.Delete(strDirCompta);

        lstInfos.Items.Add("Génération fichier Avoir " + MozartParams.NomSociete);
        lstInfos.Refresh();

        using (SqlDataReader sdr = ModuleData.ExecuteReader($"select * from TAAR_BILAN order by nom"))
        {
          lstInfos.Items.Add("\tEcriture des OD...");
          lstInfos.Refresh();

          while (sdr.Read()) //pour chaque écriture on génère les lignes d'intégration
          {
            rc++;

            //  ligne au 31 dec
            //  Ligne de TTC
            File.AppendAllText(strDirCompta, $"ODB;ODAAR{Strings.Left(sDate1, 5)};409800000;5;{sDate1};{sdr["nom"]};{sdr["ttc"]};;;;;\r\n");

            //  Ligne de HT
            File.AppendAllText(strDirCompta, $"ODB;ODAAR{Strings.Left(sDate1, 5)};{sdr["cte"]};5;{sDate1};{sdr["nom"]};-{sdr["ht"]};;;;{sdr["ana"]};\r\n");

            //  Ligne de TVA
            File.AppendAllText(strDirCompta, $"ODB;ODAAR{Strings.Left(sDate1, 5)};445865000;5;{sDate1};{sdr["nom"]};-{sdr["tva"]};;;;;\r\n");

            //  ligne au 01 jan
            //  Ligne de TTC
            File.AppendAllText(strDirCompta2, $"ODB;ODAAR{Strings.Left(sDate2, 5)};409800000;5;{sDate2};{sdr["nom"]};-{sdr["ttc"]};;;;;\r\n");

            //  Ligne de HT
            File.AppendAllText(strDirCompta2, $"ODB;ODAAR{Strings.Left(sDate2, 5)};{sdr["cte"]};5;{sDate2};{sdr["nom"]};{sdr["ht"]};;;;{sdr["ana"]};\r\n");

            //   Ligne de TVA
            File.AppendAllText(strDirCompta2, $"ODB;ODAAR{Strings.Left(sDate2, 5)};445865000;5;{sDate2};{sdr["nom"]};{sdr["tva"]};;;;;\r\n");
          }

          lstInfos.Items[lstInfos.Items.Count - 1] += $" OK ({rc} lignes)";
          lstInfos.Items.Add("");
          lstInfos.Refresh();

          sdr.Close();
        }

        // copie de sauvegarde du fichier

        File.Copy(strDirCompta, Utils.RechercheParam("REP_COMPTA") + MozartParams.NomSociete + @"\archives\ECR-ODBilan" + DateTime.Now.ToString("ddMMyyyyHHmmss") + ".dat");

        lstInfos.Items.Add("");
        lstInfos.Items.Add("\tGénération du fichier terminée.");
        lstInfos.Refresh();

        Cursor = Cursors.Default;

        MessageBox.Show(Resources.msg_GeneFichTermine, Program.AppTitle, MessageBoxButtons.OK, MessageBoxIcon.Information);
      }
      catch (Exception ex)
      {
        Cursor = Cursors.Default;
        MZUtils.displayError(MethodBase.GetCurrentMethod().Name, ex);
      }
    }

    //Private Sub cmdAAR_Click()
    //
    //' Préparation du fichier de transfert des écritures de bilan
    //
    //Dim fs As New Scripting.FileSystemObject
    //Dim ts As TextStream
    //Dim ts2 As TextStream
    //Dim aRs As New ADODB.Recordset
    //Dim c As New ADODB.Command
    //Dim strDirCompta As String
    //Dim strDirCompta2 As String
    //Dim sDate1 As String
    //Dim sDate2 As String
    //Dim strD As String
    //
    //
    //  On Error GoTo handler
    //  If Day(DateAdd("d", 1, CDate(txtDateA.Text))) <> 1 Then
    //    MsgBox "§Date de référence invalide. Ce doit être le dernier jour du mois !§", vbOKOnly, Program.AppTitle
    //    Exit Sub
    //  End If
    //  
    //  MousePointer = vbHourglass
    //  
    //  lstInfos.Clear
    //  
    //  sDate1 = Format(txtDateA.Text, "dd/mm/yy")
    //  sDate2 = Format(DateAdd("d", 1, CDate(txtDateA.Text)), "dd/mm/yy")
    //
    //
    //  If Year(DateAdd("d", 1, CDate(txtDateA.Text))) <> Year(CDate(txtDateA.Text)) Then
    //    strDirCompta = RechercheParam("REP_COMPTA") & gstrNomSociete & "\ECRODavoir" & CStr(Year(CDate(txtDateA.Text))) & ".txt"
    //    strDirCompta2 = RechercheParam("REP_COMPTA") & gstrNomSociete & "\ECRODavoir" & CStr(Year(DateAdd("d", 1, CDate(txtDateA.Text)))) & ".txt"
    //
    //    Set ts = fs.OpenTextFile(strDirCompta, ForWriting, True)
    //    Set ts2 = fs.OpenTextFile(strDirCompta2, ForWriting, True)
    //  Else
    //    ' Ouverture du fichier
    //    strDirCompta = RechercheParam("REP_COMPTA") & gstrNomSociete & "\ECRODavoir.txt"
    //
    //    Set ts = fs.OpenTextFile(strDirCompta, ForWriting, True)
    //    Set ts2 = ts
    //  End If
    //
    //
    //  ' Recordset, commande et paramètres
    //  Set c.ActiveConnection = cnx
    //  cnx.CommandTimeout = 700
    //  
    // 
    //  lstInfos.AddItem "Génération fichier Avoir " & gstrNomSociete
    //  lstInfos.Refresh
    //
    //  c.CommandText = "select * from TAAR_BILAN order by nom"
    //  c.CommandType = adCmdText
    //  c.CommandTimeout = 700
    //  c.Parameters.Refresh
    //  Set aRs = c.Execute()
    // 
    //  lstInfos.AddItem vbTab & "Ecritures des OD..."
    //  lstInfos.Refresh
    //  
    //
    //  While Not aRs.EOF     'pour chaque écriture on génère les lignes d'intégration
    //   
    //  ' ligne au 31 dec
    //    ' Ligne de TTC
    //    strD = "ODB;ODAAR" & Left(sDate1, 5) & ";409800000;5;" & sDate1 & ";" & aRs("nom") & ";" & aRs("ttc") & ";;;;;"
    //    ts.WriteLine strD
    //    
    //    ' Ligne de HT
    //    strD = "ODB;ODAAR" & Left(sDate1, 5) & ";" & aRs("cte") & ";5;" & sDate1 & ";" & aRs("nom") & ";-" & aRs("ht") & ";;;;" & aRs("ana") & ";"
    //    ts.WriteLine strD
    //    
    //    ' Ligne de TVA
    //    strD = "ODB;ODAAR" & Left(sDate1, 5) & ";445865000;5;" & sDate1 & ";" & aRs("nom") & ";-" & aRs("tva") & ";;;;;"
    //    ts.WriteLine strD
    //  
    //  ' ligne au 01 jan
    //    ' Ligne de TTC
    //    strD = "ODB;ODAAR" & Left(sDate2, 5) & ";409800000;5;" & sDate2 & ";" & aRs("nom") & ";-" & aRs("ttc") & ";;;;;"
    //    ts2.WriteLine strD
    //    
    //    ' Ligne de HT
    //    strD = "ODB;ODAAR" & Left(sDate2, 5) & ";" & aRs("cte") & ";5;" & sDate2 & ";" & aRs("nom") & ";" & aRs("ht") & ";;;;" & aRs("ana") & ";"
    //    ts2.WriteLine strD
    //    
    //    ' Ligne de TVA
    //    strD = "ODB;ODAAR" & Left(sDate2, 5) & ";445865000;5;" & sDate2 & ";" & aRs("nom") & ";" & aRs("tva") & ";;;;;"
    //    ts2.WriteLine strD
    //  
    //    
    //    aRs.MoveNext
    //  Wend
    //  
    //  lstInfos.List(lstInfos.NewIndex) = lstInfos.List(lstInfos.NewIndex) & " OK (" & aRs.RecordCount & " lignes)"
    //  lstInfos.AddItem ""
    //  lstInfos.Refresh
    //  
    //    
    //  ' Fermeture et copie de sauvegarde du fichier
    //  ts.Close
    //  fs.CopyFile strDirCompta, RechercheParam("REP_COMPTA") & gstrNomSociete & "\archives\ECR-ODBilan" & Format(Now, "ddmmyyyyhhmmss") & ".dat"
    //  
    //  aRs.Close  ' fermeture du recordset
    //  
    //  lstInfos.AddItem ""
    //  lstInfos.AddItem vbTab & "Génération du fichier terminée."
    //  lstInfos.Refresh
    //  
    //  MousePointer = vbDefault
    //  
    //  MsgBox "§Génération du fichier terminée.§", vbInformation, Program.AppTitle
    //    
    //Exit Sub
    //Resume
    //handler:
    //  MousePointer = vbDefault
    //  ShowError "cmdAvoir dans " & Me.Name
    //End Sub
    //

    /* OK ---------------------------------------------------------------------*/
    public void CreerLigneType1(SqlDataReader sdr, StringBuilder strD, string sDate, string sCompte, int iSigne, string sType)
    {
      // CODE JOURNAL
      strD.Append("ODB;");

      // REFERENCE PIECE
      strD.Append($"OD{sType}{Strings.Left(sDate, 5)};"); // Pièce

      // COMPTE FOURNISSEUR (COMPTE D'ACHAT) (COMPTE DE TVA) - 9
      strD.Append(sCompte + ";");

      // CODE TVA
      switch (Convert.ToDouble(sdr["tva"]))
      {
        case 19.6:
          strD.Append("3;");
          break;
        case 5.5:
          strD.Append("2;");
          break;
        case 7:
          strD.Append("7;");
          break;
        case 10:
          strD.Append("9;");
          break;
        case 20:
          strD.Append("8;");
          break;
        default:
          strD.Append("1;");
          break;
      }

      // DATE ECRITURE - 8
      strD.Append(sDate + ";");

      // LIBELLE - 60
      strD.Append($"{sdr["NDINNUM"]}-{sdr["vClinom"]};");

      // DEBIT - 20
      if (MozartParams.NomSociete == "EMALECLUXEMBOURG")
        strD.Append(((double)iSigne * Convert.ToDouble(sdr["NACTVAL"])).ToString("0.00") + ";"); //HT
      else
        strD.Append((iSigne * Convert.ToDouble(sdr["NACTVAL"]) * (100.0 + Convert.ToDouble(sdr["tva"])) / 100.0).ToString("0.00") + ";"); //TTC

      // CREDIT - 20 & REPARTITION ECHEANCE - 260 & TYPE REGLEMENT & REPARTITION ANALYTIQUE - 400
      strD.AppendLine(";;;;");       //TTC
    }

    public void CreerLigneType2(SqlDataReader sdr, StringBuilder strD, string sDate, string sCompte, int iSigne, string sType, string tva)
    {
      // CODE JOURNAL
      strD.Append("ODB;");

      // REFERENCE PIECE
      strD.Append($"OD{sType}{Strings.Left(sDate, 5)};");  // Pièce

      // (COMPTE FOURNISSEUR) COMPTE D'ACHAT (COMPTE DE TVA) - 9
      strD.Append(sCompte + ";");

      // CODE TVA
      strD.Append(tva + ";");

      // DATE ECRITURE - 8
      strD.Append(sDate + ";");

      // LIBELLE - 60
      strD.Append($"{sdr["vClinom"]}-DI{sdr["NDINNUM"]};");

      // DEBIT - 20
      strD.Append(";");      // HT

      // CREDIT - 20
      strD.Append(((double)iSigne * Convert.ToDouble(sdr["NACTVAL"])).ToString("0.00") + ";"); //HT

      // REPARTITION ECHEANCE - 260 & TYPE REGLEMENT
      strD.Append(";;");


      // REPARTITION ANALYTIQUE - 400
      strD.AppendLine(sdr["ndincte"].ToString() + ";");
    }


    public void CreerLigneType3(SqlDataReader sdr, StringBuilder strD, string sDate, string sCompte, int iSigne, string sType)
    {

      // FGA le 6/12/23
      // emalec luxembourg ne souhaite pas les lignes de TVA pour les OD dans sa nouvelle compta
      if (MozartParams.NomSociete == "EMALECLUXEMBOURG") return;

      // CODE JOURNAL
      strD.Append("ODB;");

      // REFERENCE PIECE
      strD.Append($"OD{sType}{Strings.Left(sDate, 5)};");  // Pièce

      // (COMPTE FOURNISSEUR) COMPTE D'ACHAT (COMPTE DE TVA) - 9
      strD.Append(sCompte + ";");

      // CODE TVA
      strD.Append(";");

      // DATE ECRITURE - 8
      strD.Append(sDate + ";");

      // LIBELLE - 60
      strD.Append($"{sdr["vClinom"]}-DI{sdr["NDINNUM"]};");

      // DEBIT - 20
      strD.Append(";");       //HT

      // CREDIT - 20
      strD.Append(((double)iSigne * Convert.ToDouble(sdr["NACTVAL"]) * Convert.ToDouble(sdr["tva"]) / 100.0).ToString("0.00") + ";"); // HT

      // REPARTITION ECHEANCE - 260 & TYPE REGLEMENT & REPARTITION ANALYTIQUE - 400
      strD.AppendLine(";;;");
    }

    public void CreerLigneType4(SqlDataReader sdr, StringBuilder strD, string sDate, string sCompte, int iSigne, string sType)
    {
      // CODE JOURNAL
      strD.Append("ODB;");

      // REFERENCE PIECE
      strD.Append($"OD{sType}{Strings.Left(sDate, 5)};"); //Pièce

      // (COMPTE FOURNISSEUR) COMPTE D'ACHAT (COMPTE DE TVA) - 9
      strD.Append(sCompte + ";");

      // CODE TVA
      strD.Append("6;");

      // DATE ECRITURE - 8
      strD.Append(sDate + ";");

      // LIBELLE - 60
      strD.Append($"{ sdr["vClinom"]}-DI{sdr["NDINNUM"]};");

      // DEBIT - 20
      if (sType == "AV")
        strD.Append(((double)iSigne * Convert.ToDouble(sdr["ENCOURS"])).ToString("0.00") + ";"); //HT
      else
        strD.Append(((double)iSigne * Convert.ToDouble(sdr["NACTVAL"])).ToString("0.00") + ";"); //HT

      // CREDIT - 20 & REPARTITION ECHEANCE - 260 & TYPE REGLEMENT & REPARTITION ANALYTIQUE - 400
      strD.AppendLine(";;;;"); //HT
    }

    public void CreerLigneType5(SqlDataReader sdr, StringBuilder strD, string sDate, string sCompte, int iSigne, string sType)
    {
      // CODE JOURNAL
      strD.Append("ODB;");

      // REFERENCE PIECE
      strD.Append($"OD{sType}{Strings.Left(sDate, 5)};"); //PIèce

      // (COMPTE FOURNISSEUR) COMPTE D'ACHAT (COMPTE DE TVA) - 9
      strD.Append(sCompte + ";");

      // CODE TVA
      // code 6 pour indiquer que c'est non taxé
      strD.Append("6;");

      // DATE ECRITURE - 8
      strD.Append(sDate + ";");

      // LIBELLE - 60
      strD.Append($"{sdr["vClinom"]}-DI{sdr["NDINNUM"]};");

      // DEBIT - 20
      strD.Append(";"); //HT

      // CREDIT - 20
      if (sType == "AV")
        strD.Append(((double)iSigne * Convert.ToDouble(sdr["ENCOURS"])).ToString("0.00") + ";"); //HT
      else
        strD.Append(((double)iSigne * Convert.ToDouble(sdr["NACTVAL"])).ToString("0.00") + ";"); //HT

      // REPARTITION ECHEANCE - 260 & TYPE REGLEMENT
      strD.Append(";;");

      // REPARTITION ANALYTIQUE - 400
      strD.AppendLine(sdr["ndincte"].ToString() + ";");
    }

    public void CreerLigneType6(SqlDataReader sdr, StringBuilder strD, string sDate, string sCompte, int iSigne, string sType, int tva = 1)
    {
      // CODE JOURNAL
      strD.Append("ODB;");

      // REFERENCE PIECE
      strD.Append($"OD{sType}{Strings.Left(sDate, 5)};");

      // COMPTE FOURNISSEUR (COMPTE D'ACHAT) (COMPTE DE TVA) - 9
      strD.Append(sCompte + ";");

      // CODE TVA
      if (tva == 0)
      {
        strD.Append("6;");
      }
      else
      {
        switch (Convert.ToDouble(sdr["tva"]))
        {
          case 19.6:
            strD.Append("3;");
            break;
          case 5.5:
            strD.Append("2;");
            break;
          case 7:
            strD.Append("7;");
            break;
          case 10:
            strD.Append("9;");
            break;
          case 20:
            strD.Append("8;");
            break;
          default:
            strD.Append("1;");
            break;
        }
      }

      // DATE ECRITURE - 8
      strD.Append(sDate + ";");

      // LIBELLE - 60
      strD.Append(Strings.Right($"{sdr["VSTFNOM"]}-{sdr["REFFAC"]}-DI{sdr["NDINNUM"]};", 99));

      // DEBIT - 20
      strD.Append(";"); //TTC

      // CREDIT - 20
      switch (sdr["vsitpays"].ToString())
      {
        case "FRANCE":
          if (tva == 0)
            strD.Append(((double)iSigne * Convert.ToDouble(sdr["NACTVAL"])).ToString("0.00") + ";"); //HT
          else
          {
            // emalec luxembourg (HT)
            if (MozartParams.NomSociete == "EMALECLUXEMBOURG")
              strD.Append(((double)iSigne * Convert.ToDouble(sdr["NACTVAL"])).ToString("0.00") + ";"); //HT
            else
              strD.Append(((double)iSigne * Convert.ToDouble(sdr["NACTVAL"]) * (100.0 + Convert.ToDouble(sdr["tva"])) / 100.0).ToString("0.00") + ";"); //TTC
          }
          break;
        case "AUTRICHE":
        case "PAYS-BAS":
        case "GRANDE BRETAGNE":
        case "SLOVAQUIE":
          if (MozartParams.NomSociete == "EMALECLUXEMBOURG")
            strD.Append(((double)iSigne * Convert.ToDouble(sdr["NACTVAL"])).ToString("0.00") + ";"); //HT
          else
            strD.Append(((double)iSigne * Convert.ToDouble(sdr["NACTVAL"]) * (120.0) / 100.0).ToString("0.00") + ";"); //TTC
          break;
        case "SUISSE":
          if (MozartParams.NomSociete == "EMALECLUXEMBOURG")
            strD.Append(((double)iSigne * Convert.ToDouble(sdr["NACTVAL"])).ToString("0.00") + ";"); //HT
          else
            strD.Append(((double)iSigne * Convert.ToDouble(sdr["NACTVAL"]) * (107.6) / 100.0).ToString("0.00") + ";"); //TTC
          break;
        case "BELGIQUE":
        case "ESPAGNE":
        case "REPUBLIQUE TCHEQUE":
          if (MozartParams.NomSociete == "EMALECLUXEMBOURG")
            strD.Append(((double)iSigne * Convert.ToDouble(sdr["NACTVAL"])).ToString("0.00") + ";"); //HT
          else
            strD.Append(((double)iSigne * Convert.ToDouble(sdr["NACTVAL"]) * (121.0) / 100.0).ToString("0.00") + ";"); //TTC
          break;
        case "LUXEMBOURG":
          if (MozartParams.NomSociete == "EMALECLUXEMBOURG")
            strD.Append(((double)iSigne * Convert.ToDouble(sdr["NACTVAL"])).ToString("0.00") + ";"); //HT
          else
            strD.Append(((double)iSigne * Convert.ToDouble(sdr["NACTVAL"]) * (115.0) / 100.0).ToString("0.00") + ";"); //TTC
          break;
        case "ITALIE":
          if (MozartParams.NomSociete == "EMALECLUXEMBOURG")
            strD.Append(((double)iSigne * Convert.ToDouble(sdr["NACTVAL"])).ToString("0.00") + ";"); //HT
          else
            strD.Append(((double)iSigne * Convert.ToDouble(sdr["NACTVAL"]) * (122.0) / 100.0).ToString("0.00") + ";"); //TTC
          break;
        case "ALLEMAGNE":
          if (MozartParams.NomSociete == "EMALECLUXEMBOURG")
            strD.Append(((double)iSigne * Convert.ToDouble(sdr["NACTVAL"])).ToString("0.00") + ";"); //HT
          else
            strD.Append(((double)iSigne * Convert.ToDouble(sdr["NACTVAL"]) * (119.0) / 100.0).ToString("0.00") + ";"); //TTC
          break;
        case "PORTUGAL":
          strD.Append(((double)iSigne * Convert.ToDouble(sdr["NACTVAL"]) * (123.0) / 100.0).ToString("0.00") + ";"); //TTC
          break;
        default:
          if (MozartParams.NomSociete == "EMALECLUXEMBOURG")
            strD.Append(((double)iSigne * Convert.ToDouble(sdr["NACTVAL"])).ToString("0.00") + ";"); //HT
          else
            strD.Append(((double)iSigne * Convert.ToDouble(sdr["NACTVAL"]) * (100.0 + Convert.ToDouble(sdr["tva"])) / 100.0).ToString("0.00") + ";"); //TTC
          break;
      }

      // REPARTITION ECHEANCE - 260 & TYPE REGLEMENT & REPARTITION ANALYTIQUE - 400
      strD.AppendLine(";;;");
    }

    public void CreerLigneType7(SqlDataReader srd, StringBuilder strD, string sDate, string sCompte, int iSigne, string sType, int tva = 1)
    {
      // CODE JOURNAL
      strD.Append("ODB;");

      // REFERENCE PIECE
      strD.Append($"OD{sType}{Strings.Left(sDate, 5)};"); //Pièce

      // (COMPTE FOURNISSEUR) COMPTE D'ACHAT (COMPTE DE TVA) - 9
      // si 605000000 et compte 995 alors mettre 605100000
      if (sCompte == "605000000" && srd["ndincte"].ToString() == "995")
        strD.Append("605100000;");
      else
        strD.Append(sCompte + ";");

      // CODE TVA
      if (tva == 0)
        strD.Append("6;");
      else
      {
        switch (Convert.ToDouble(srd["tva"]))
        {
          case 19.6:
            strD.Append("3;");
            break;
          case 5.5:
            strD.Append("2;");
            break;
          case 7:
            strD.Append("7;");
            break;
          case 10:
            strD.Append("9;");
            break;
          case 20:
            strD.Append("8;");
            break;
          default:
            strD.Append("1;");
            break;
        }
      }

      // DATE ECRITURE - 8
      strD.Append(sDate + ";");

      // LIBELLE - 60
      strD.Append(Strings.Right($"{srd["VSTFNOM"]}-{srd["REFFAC"]}-DI{srd["NDINNUM"]};", 99));

      // DEBIT - 20
      strD.Append(((double)iSigne * Convert.ToDouble(srd["NACTVAL"])).ToString("0.00") + ";"); //HT

      // CREDIT - 20 & REPARTITION ECHEANCE - 260 & TYPE REGLEMENT
      strD.Append(";;;"); //HT

      // REPARTITION ANALYTIQUE - 400
      strD.AppendLine(srd["ndincte"].ToString() + ";");
    }

    public void CreerLigneType8(SqlDataReader srd, StringBuilder strD, string sDate, string sCompte, int iSigne, string sType)
    {

      // FGA le 6/12/23
      // emalec luxembourg ne souhaite pas les lignes de TVA pour les OD dans sa nouvelle compta
      if (MozartParams.NomSociete == "EMALECLUXEMBOURG") return;

      // CODE JOURNAL
      strD.Append("ODB;");

      // REFERENCE PIECE
      strD.Append($"OD{sType}{Strings.Left(sDate, 5)};"); //Pièce

      // (COMPTE FOURNISSEUR) COMPTE D'ACHAT (COMPTE DE TVA) - 9
      strD.Append(sCompte + ";");

      // CODE TVA
      strD.Append(";");

      // DATE ECRITURE - 8
      strD.Append(sDate + ";");

      // LIBELLE - 60
      strD.Append(Strings.Right($"{srd["VSTFNOM"]}-{srd["REFFAC"]}-DI{srd["NDINNUM"]};", 99));

      // DEBIT - 20
      switch (srd["vsitpays"].ToString())
      {
        case "FRANCE":
          strD.Append(((double)iSigne * Convert.ToDouble(srd["NACTVAL"]) * Convert.ToInt32(srd["tva"]) / 100.0).ToString("0.00") + ";"); //HT
          break;
        case "AUTRICHE":
        case "PAYS-BAS":
        case "GRANDE BRETAGNE":
        case "SLOVAQUIE":
          strD.Append(((double)iSigne * Convert.ToDouble(srd["NACTVAL"]) * 20.0 / 100.0).ToString("0.00") + ";"); //HT
          break;
        case "SUISSE":
          strD.Append(((double)iSigne * Convert.ToDouble(srd["NACTVAL"]) * 7.6 / 100.0).ToString("0.00") + ";"); //HT
          break;
        case "BELGIQUE":
        case "ESPAGNE":
        case "REPUBLIQUE TCHEQUE":
          strD.Append(((double)iSigne * Convert.ToDouble(srd["NACTVAL"]) * 21.0 / 100.0).ToString("0.00") + ";"); //HT
          break;
        case "LUXEMBOURG":
          strD.Append(((double)iSigne * Convert.ToDouble(srd["NACTVAL"]) * 15.0 / 100.0).ToString("0.00") + ";"); //HT
          break;
        case "ITALIE":
          strD.Append(((double)iSigne * Convert.ToDouble(srd["NACTVAL"]) * 22.0 / 100.0).ToString("0.00") + ";"); //HT
          break;
        case "ALLEMAGNE":
          strD.Append(((double)iSigne * Convert.ToDouble(srd["NACTVAL"]) * 19.0 / 100.0).ToString("0.00") + ";"); //HT
          break;
        case "PORTUGAL":
          strD.Append(((double)iSigne * Convert.ToDouble(srd["NACTVAL"]) * 23.0 / 100.0).ToString("0.00") + ";"); //HT
          break;
        default:
          strD.Append(((double)iSigne * Convert.ToDouble(srd["NACTVAL"]) * Convert.ToDouble(srd["tva"]) / 100.0).ToString("0.00") + ";"); //HT
          break;
      }

      // CREDIT - 20 & REPARTITION ECHEANCE - 260 & TYPE REGLEMENT & REPARTITION ANALYTIQUE - 400
      strD.AppendLine(";;;;"); //HT
    }
  }
}
