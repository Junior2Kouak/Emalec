using DevExpress.XtraGrid;
using DevExpress.XtraGrid.Views.Base;
using DevExpress.XtraGrid.Views.Grid;
using DevExpress.XtraPrinting;
using Microsoft.VisualBasic;
using MozartLib;
using MozartNet;
using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Web;
using System.Windows.Forms;

namespace MozartCS
{
  public partial class frmSuiviTempsTravailTechDetail : Form
  {

    DataTable dtListeTechs;
    DataTable dt_SYN_SEMAINE;
    DataTable dtListeSuiviTpsTrav_DET;
    DataTable dt_SYN_SEMAINE_DeltaForce;
    DataTable dt_SYN_SEMAINE_VISA;
    DataSet DS_Tps_Suivi;

    DataTable dtCboMois;
    DataTable dtCboAnnee;

    int Tot_NB_SEC_HR_TRAVAILLE_TOTAL;
    int Tot_NB_SEC_TEMPS_JOUR_GPS_TOTAL;
    int Tot_NB_SEC_TEMPS_JOUR_GOOGLE_TOTAL;

    int Sum_TOT_NB_SEC_REF;
    int Sum_DELTA_REF_THEO;

    int Sum_TOT_SEC_RTE_GPS_1ST_SITE;
    int Sum_NB_SEC_HR_GOOGLE_DEPART;
    int Sum_TOT_SEC_RTE_LAST_GPS;
    int Sum_NB_HR_GOOGLE_ARRIVEE;
    int Sum_TOT_SEC_GPS_RTE_JOUR;
    int Sum_TOT_SEC_GOOGLE_RTE_JOUR;

    Color oColorFocusedCell_Default;

    frmSuiviTempsTravailTech_Histo oFrmSuiviTempsTravailTech_Histo;
    private string GetPolarite(int value) => value < 0 ? "-" : "";
    public frmSuiviTempsTravailTechDetail()
    {
      InitializeComponent();
    }
    private void BtnClose_Click(object sender, EventArgs e)
    {
      Close();
    }

    private void frmSuiviTempsTravailTechDetail_Load(object sender, EventArgs e)
    {

      //init
      ModuleMain.Initboutons(this);

      oColorFocusedCell_Default = GV_SYN_SEMAINE.PaintAppearance.FocusedCell.BackColor;

      Tot_NB_SEC_HR_TRAVAILLE_TOTAL = 0;
      Tot_NB_SEC_TEMPS_JOUR_GPS_TOTAL = 0;
      Tot_NB_SEC_TEMPS_JOUR_GOOGLE_TOTAL = 0;

      Sum_TOT_NB_SEC_REF = 0;
      Sum_DELTA_REF_THEO = 0;

      LoadDataCbo();

    }

    private void RefreshData()
    {

      if (dtListeSuiviTpsTrav_DET != null)
      {

        //on charge les tables permettant de recuperer les visa et les delta force
        dt_SYN_SEMAINE_DeltaForce = new DataTable();
        SqlCommand CmdSql = new SqlCommand("[api_sp_SuiviTemps_LoadDeltaFORCE]", MozartDatabase.cnxMozart);
        CmdSql.CommandType = CommandType.StoredProcedure;
        SqlCommandBuilder.DeriveParameters(CmdSql);    // liste des paramètres

        //  liste des paramètres
        CmdSql.Parameters["@VFIELDNAME"].Value = "TOT_SEM_SEC_DELTA_REF_THEO_FORCE";
        CmdSql.Parameters["@P_MOIS"].Value = (int)CboMois.SelectedValue;
        CmdSql.Parameters["@P_ANNEE"].Value = (int)CboAnnee.SelectedValue;

        dt_SYN_SEMAINE_DeltaForce.Load(CmdSql.ExecuteReader());

        //table VISA
        dt_SYN_SEMAINE_VISA = new DataTable();
        CmdSql = new SqlCommand("[api_sp_SuiviTemps_LoadVISA]", MozartDatabase.cnxMozart);
        CmdSql.CommandType = CommandType.StoredProcedure;
        SqlCommandBuilder.DeriveParameters(CmdSql);    // liste des paramètres

        //  liste des paramètres
        CmdSql.Parameters["@P_MOIS"].Value = (int)CboMois.SelectedValue;
        CmdSql.Parameters["@P_ANNEE"].Value = (int)CboAnnee.SelectedValue;

        dt_SYN_SEMAINE_VISA.Load(CmdSql.ExecuteReader());

        //***********************************************************************************************************


        //gestion du calculs des totaux de la table principale
        foreach (DataRow DrTot in dtListeSuiviTpsTrav_DET.Rows)
        {


          if ((bool)DrTot["PRESENCE_ABSCENCE"] == true)
          {
            DrTot["TOT_SEC_RTE_GPS_1ST_SITE_MOZARIS"] = 0;
            DrTot["TOT_SEC_RTE_GPS_1ST_SITE"] = 0;
            DrTot["TOT_SEC_RTE_LAST_GPS_MOZARIS"] = 0;
            DrTot["TOT_SEC_RTE_LAST_GPS"] = 0;
            DrTot["TOT_SEC_GPS_RTE_JOUR_MOZARIS"] = 0;
            DrTot["TOT_SEC_GPS_RTE_JOUR"] = 0;
            DrTot["TOT_SEC_GOOGLE_RTE_JOUR"] = 0;
            DrTot["TOT_SEC_TEMPS_JOUR_GPS_MOZARIS"] = 0;
            DrTot["TOT_SEC_TEMPS_JOUR_GPS"] = 0;
            DrTot["TOT_SEC_TEMPS_JOUR_GOOGLE_MOZARIS"] = 0;
            DrTot["TOT_SEC_TEMPS_JOUR_GOOGLE"] = 0;
            DrTot["DELTA_REF_THEO"] = 0;

          }
          else
          {
            //si saisie manuelle
            DrTot["TOT_SEC_RTE_GPS_1ST_SITE_MOZARIS"] = (int)ZeroIfNull(DrTot["NB_SEC_HEURE_1ST_SITE_MOZARIS"]) - (int)ZeroIfNull(DrTot["NB_SEC_HEURE_1ST_DEPART_MOZARIS"]);
            DrTot["TOT_SEC_RTE_GPS_1ST_SITE"] = (int)ZeroIfNull(DrTot["NB_SEC_HEURE_1ST_SITE"]) - (int)ZeroIfNull(DrTot["NB_SEC_HEURE_1ST_DEPART"]);

            DrTot["TOT_SEC_RTE_LAST_GPS_MOZARIS"] = (int)ZeroIfNull(DrTot["NB_SEC_HEURE_LAST_ARRIVEE_MOZARIS"]) - (int)ZeroIfNull(DrTot["NB_SEC_HEURE_LAST_SITE_MOZARIS"]);
            DrTot["TOT_SEC_RTE_LAST_GPS"] = (int)ZeroIfNull(DrTot["NB_SEC_HEURE_LAST_ARRIVEE"]) - (int)ZeroIfNull(DrTot["NB_SEC_HEURE_LAST_SITE"]);

            DrTot["TOT_SEC_TPS_TRAV_MOZARIS"] = (int)ZeroIfNull(DrTot["NB_SEC_HEURE_LAST_SITE_MOZARIS"]) - (int)ZeroIfNull(DrTot["NB_SEC_HEURE_1ST_DEPART_MOZARIS"]);
            DrTot["TOT_SEC_TPS_TRAV"] = (int)ZeroIfNull(DrTot["NB_SEC_HEURE_LAST_SITE"]) - (int)ZeroIfNull(DrTot["NB_SEC_HEURE_1ST_DEPART"]);

            DrTot["TOT_SEC_GPS_RTE_JOUR_MOZARIS"] = (int)DrTot["TOT_SEC_RTE_GPS_1ST_SITE_MOZARIS"]
                                                    +
                                                    ((DrTot["NB_SEC_HEURE_LAST_ARRIVEE_MOZARIS"] == null || DrTot["NB_SEC_HEURE_LAST_ARRIVEE"].ToString() == "") ? 0 :
                                                                                                                                                         (int)ZeroIfNull(DrTot["NB_SEC_HEURE_LAST_ARRIVEE_MOZARIS"]) - (int)ZeroIfNull(DrTot["NB_SEC_HEURE_LAST_SITE_MOZARIS"]))
                                                    ;
            DrTot["TOT_SEC_GPS_RTE_JOUR"] = (int)DrTot["TOT_SEC_RTE_GPS_1ST_SITE"]
                                            +
                                            ((DrTot["NB_SEC_HEURE_LAST_ARRIVEE"] == null || DrTot["NB_SEC_HEURE_LAST_ARRIVEE"].ToString() == "") ? 0 :
                                                                                                                                                         (int)ZeroIfNull(DrTot["NB_SEC_HEURE_LAST_ARRIVEE"]) - (int)ZeroIfNull(DrTot["NB_SEC_HEURE_LAST_SITE"]))
                                            ;

            DrTot["TOT_SEC_GOOGLE_RTE_JOUR_MOZARIS"] = ((DrTot["BCOMPTE_381"] != null && DrTot["BCOMPTE_381"].ToString() != "" && (bool)DrTot["BCOMPTE_381"] == true) ? 7200 :
                                                          ((int)ZeroIfNull(DrTot["NB_SEC_HR_GOOGLE_DEPART_MOZARIS"]) + (int)ZeroIfNull(DrTot["NB_HR_GOOGLE_ARRIVEE_MOZARIS"])) * (decimal)ZeroIfNull(DrTot["NTAUX_TPS_THEO_RATIO"])
                                                                );                      

            DrTot["TOT_SEC_GOOGLE_RTE_JOUR"] = ((DrTot["BCOMPTE_381"] != null && DrTot["BCOMPTE_381"].ToString() != "" && (bool)DrTot["BCOMPTE_381"] == true) ? 7200 :
                                                          ((int)ZeroIfNull(DrTot["NB_SEC_HR_GOOGLE_DEPART"]) + (int)ZeroIfNull(DrTot["NB_HR_GOOGLE_ARRIVEE"])) * (decimal)ZeroIfNull(DrTot["NTAUX_TPS_THEO_RATIO"])
                                                                );
                      


              DrTot["TOT_SEC_TEMPS_JOUR_GPS_MOZARIS"] = ((DrTot["BCOMPTE_381"] != null && DrTot["BCOMPTE_381"].ToString() != "" && (bool)DrTot["BCOMPTE_381"] == true) ? 32400 :

                                                                 (int)DrTot["TOT_SEC_TPS_TRAV_MOZARIS"] + (int)DrTot["TOT_SEC_RTE_GPS_1ST_SITE_MOZARIS"] +
                                                                     ((DrTot["NB_SEC_HEURE_LAST_ARRIVEE_MOZARIS"] == null || DrTot["NB_SEC_HEURE_LAST_ARRIVEE_MOZARIS"].ToString() == "") ? 0 :
                                                                                                                                                         (int)ZeroIfNull(DrTot["NB_SEC_HEURE_LAST_ARRIVEE_MOZARIS"]) - (int)ZeroIfNull(DrTot["NB_SEC_HEURE_LAST_SITE_MOZARIS"]))

                                                                );

            //Total jour réel
            DrTot["TOT_SEC_TEMPS_JOUR_GPS"] = ((DrTot["BCOMPTE_381"] != null && DrTot["BCOMPTE_381"].ToString() != "" && (bool)DrTot["BCOMPTE_381"] == true) ? 32400 :

                                                                 (int)DrTot["TOT_SEC_TPS_TRAV"] + (int)DrTot["TOT_SEC_RTE_GPS_1ST_SITE"] +
                                                                     ((DrTot["NB_SEC_HEURE_LAST_ARRIVEE"] == null || DrTot["NB_SEC_HEURE_LAST_ARRIVEE"].ToString() == "") ? 0 :
                                                                                                                                                         (int)ZeroIfNull(DrTot["NB_SEC_HEURE_LAST_ARRIVEE"]) - (int)ZeroIfNull(DrTot["NB_SEC_HEURE_LAST_SITE"]))

                                                                );

            DrTot["TOT_SEC_TEMPS_JOUR_GOOGLE_MOZARIS"] = ((DrTot["BCOMPTE_381"] != null && DrTot["BCOMPTE_381"].ToString() != "" && (bool)DrTot["BCOMPTE_381"] == true) ? 32400 : 0)
                                                            + (int)DrTot["TOT_SEC_TPS_TRAV_MOZARIS"] + (int)DrTot["TOT_SEC_GOOGLE_RTE_JOUR_MOZARIS"];

           



            DrTot["TOT_SEC_TEMPS_JOUR_GOOGLE"] = ((DrTot["BCOMPTE_381"] != null && DrTot["BCOMPTE_381"].ToString() != "" && (bool)DrTot["BCOMPTE_381"] == true) ? 32400 : 0)
                                                            + (int)DrTot["TOT_SEC_TPS_TRAV"] + (int)DrTot["TOT_SEC_GOOGLE_RTE_JOUR"];



            //Delta référence / Théorique
            DrTot["DELTA_REF_THEO"] = (int)ZeroIfNull(DrTot["TOT_SEC_TEMPS_JOUR_GOOGLE"]) - (int)ZeroIfNull(DrTot["TOT_NB_SEC_REF"]);

            dtListeSuiviTpsTrav_DET.AcceptChanges();           

            //on ne comodife pas si visa saisie
            if(DrTot["DCOMPENSATION_VISA"] == null || DrTot["DCOMPENSATION_VISA"].ToString() == "")
            {
                //si compensation force
                if((int)DrTot["NCOMPENSATION_INDEM_MAN"] == 0)
                {
                    //si gd, alors compensation à 0
                    if ((bool)DrTot["PRESENCE_GD"] == true)
                    {
                        DrTot["NCOMPENSATION_INDEM"] = 0;
                    }
                    else
                    {
                        //si saisie manuelle
                        if ((int)DrTot["TOT_SEC_GOOGLE_RTE_JOUR_MAN"] == 1)  //TOT_SEC_GOOGLE_RTE_JOUR_MAN
                        {
                            if ((int)DrTot["TOT_SEC_GOOGLE_RTE_JOUR"] > 5400)  //TOT_SEC_GOOGLE_RTE_JOUR_MAN
                            {
                                DrTot["NCOMPENSATION_INDEM"] = 3;
                            }
                        }
                        else
                        {
                            if ((bool)DrTot["BCOMPTE_381"] == true)  //TOT_SEC_GOOGLE_RTE_JOUR_MAN
                            {
                                DrTot["NCOMPENSATION_INDEM"] = 0;
                            }
                            else
                            {
                                if ((int)DrTot["TOT_SEC_GOOGLE_RTE_JOUR"] > 5400)
                                {
                                    DrTot["NCOMPENSATION_INDEM"] = 3;
                                }
                                else
                                {
                                    DrTot["NCOMPENSATION_INDEM"] = 0;
                                }
                            }
                        }
                    }
                }


             }            

          }

        }

        dtListeSuiviTpsTrav_DET.AcceptChanges();

        //refresh table techs 
        var qTechsListe = from Tech in dtListeSuiviTpsTrav_DET.AsEnumerable()
                          group Tech by new { NPERNUM = Tech["NPERNUM"], VPERNOM = Tech["VPERNOM"] + " " + Tech["VPERPRE"] } into grp
                          select new
                          {
                            NPERNUM = grp.Key.NPERNUM,
                            VPERNOM = grp.Key.VPERNOM
                          };

        foreach (var item in qTechsListe.OrderBy(ord => ord.VPERNOM))
        {

          DataRow[] result = dtListeTechs.Select($"NPERNUM = {item.NPERNUM}");

          foreach (DataRow row in result)
          {
            row["V_SEM_V_SEM_TOT"] = $"{ (dtListeSuiviTpsTrav_DET.AsEnumerable().Where(x => (int)x["NTPS_RECUP_ID"] > 0 && (int)x["NPERNUM"] == (int)item.NPERNUM).GroupBy(x => x["NUM_SEMAINE_ISO"]).Select(x => x.FirstOrDefault()).Count())} / {(dtListeSuiviTpsTrav_DET.AsEnumerable().GroupBy(x => x["NUM_SEMAINE_ISO"]).Select(x => x.FirstOrDefault()).Count())}";
            row.AcceptChanges();
          }

        }


        //update tables synthese semainel
        var qSYN_SEMAINE = from SYN_SEMAINE in dtListeSuiviTpsTrav_DET.AsEnumerable()
                           group SYN_SEMAINE by new
                           {
                             NPERNUM = SYN_SEMAINE["NPERNUM"],
                             NUM_ANNEE = SYN_SEMAINE["NUM_ANNEE"],
                             NUM_SEMAINE_ISO = SYN_SEMAINE["NUM_SEMAINE_ISO"],
                             NUM_SEMAINE = SYN_SEMAINE["NUM_SEMAINE"],
                             NTPS_RECUP_ID = SYN_SEMAINE["NTPS_RECUP_ID"]
                           } into grp
                           select new
                           {
                             NPERNUM = grp.Key.NPERNUM,
                             NUM_ANNEE = grp.Key.NUM_ANNEE,
                             NUM_SEMAINE_ISO = grp.Key.NUM_SEMAINE_ISO,
                             NUM_SEMAINE = grp.Key.NUM_SEMAINE,
                             NTPS_RECUP_ID = grp.Key.NTPS_RECUP_ID,
                             TOT_SEM_NB_SEC_TRAV_REF = grp.Sum(s => s == null ? 0 : s.Field<int?>("NB_SEC_TRAV_REF")),
                             TOT_SEM_NB_SEC_RTE_REF = grp.Sum(s => s == null ? 0 : s.Field<int?>("NB_SEC_RTE_REF")),
                             TOT_SEM_TOT_SEC_TPS_TRAV = grp.Sum(s => s == null ? 0 : s.Field<int?>("TOT_SEC_TPS_TRAV")),
                             TOT_SEM_TOT_SEC_TEMPS_JOUR_GPS = grp.Sum(s => s == null ? 0 : s.Field<int?>("TOT_SEC_TEMPS_JOUR_GPS")),
                             TOT_SEM_TOT_SEC_TEMPS_JOUR_GOOGLE_MOZARIS = grp.Sum(s => s == null ? 0 : s.Field<int?>("TOT_SEC_TEMPS_JOUR_GOOGLE_MOZARIS")),
                             TOT_SEM_TOT_SEC_TEMPS_JOUR_GOOGLE_MAN = grp.Sum(s => s == null ? 0 : s.Field<int?>("TOT_SEC_TEMPS_JOUR_GOOGLE_MAN")),
                             TOT_SEM_TOT_SEC_TEMPS_JOUR_GOOGLE_FORCE = grp.Sum(s => s == null ? 0 : s.Field<int?>("TOT_SEC_TEMPS_JOUR_GOOGLE")),
                             TOT_SEM_TOT_SEC_TEMPS_JOUR_GOOGLE = grp.Sum(s => s == null ? 0 : s.Field<int?>("TOT_SEC_TEMPS_JOUR_GOOGLE"))
                           };
        int test = -1;

        foreach (var item in qSYN_SEMAINE.OrderBy(ord => ord.NUM_ANNEE).OrderBy(ord => ord.NUM_SEMAINE))
        {

          DataRow[] result = dt_SYN_SEMAINE.Select($"NPERNUM = {item.NPERNUM} AND NUM_SEMAINE_ISO = {item.NUM_SEMAINE_ISO}");

          foreach (DataRow row in result)
          {

            //on charge la class
            //CTPS_RECUP_TECH oCTPS_RECUP_TECH = null;
            //if ((int)item.NTPS_RECUP_ID > 0) 
            //{
            //  oCTPS_RECUP_TECH = new CTPS_RECUP_TECH((int)item.NTPS_RECUP_ID);

            //}
            test = -1;
            DataRow[] result_deltaforce = dt_SYN_SEMAINE_DeltaForce.Select($"NPERNUM = {item.NPERNUM} AND NUM_SEMAINE_ISO = {item.NUM_SEMAINE_ISO} AND NUM_YEAR = {(int)item.NUM_ANNEE}");

            if (result_deltaforce.Count() > 0)
            {
              test = (int)result_deltaforce[0]["N_TOT_SEC_MAN"];
            }

            DataRow[] result_VISA = dt_SYN_SEMAINE_VISA.Select($"NPERNUM = {item.NPERNUM} AND NTPS_RECUP_ID = {item.NTPS_RECUP_ID}");
            if (result_VISA.Count() == 0)
            {
              result_VISA = null;
            }

            row["TOT_SEM_NB_SEC_REF"] = item.TOT_SEM_NB_SEC_TRAV_REF + item.TOT_SEM_NB_SEC_RTE_REF;
            row["TOT_SEM_SEC_TEMPS_JOUR_TRAV_AND_GOOGLE"] = item.TOT_SEM_TOT_SEC_TEMPS_JOUR_GOOGLE;
            row["TOT_SEM_SEC_TEMPS_JOUR_TRAV_AND_GPS"] = item.TOT_SEM_TOT_SEC_TEMPS_JOUR_GPS;
            row["TOT_SEM_SEC_DELTA_REF_THEO_MOZARIS"] = (item.TOT_SEM_TOT_SEC_TEMPS_JOUR_GOOGLE_MOZARIS) - (item.TOT_SEM_NB_SEC_TRAV_REF + item.TOT_SEM_NB_SEC_RTE_REF);
            row["TOT_SEM_SEC_DELTA_REF_THEO_MANU"] = (item.TOT_SEM_TOT_SEC_TEMPS_JOUR_GOOGLE) - (item.TOT_SEM_NB_SEC_TRAV_REF + item.TOT_SEM_NB_SEC_RTE_REF);
            row["TOT_SEM_SEC_DELTA_REF_THEO_FORCE"] = test; //GetDeltaForceManuel("TOT_SEM_SEC_DELTA_REF_THEO_FORCE", (int)item.NUM_SEMAINE_ISO, (int)item.NUM_ANNEE, (int)item.NPERNUM);
            row["TOT_SEM_SEC_DELTA_REF_THEO_FORCE_EXIST"] = (int)row["TOT_SEM_SEC_DELTA_REF_THEO_FORCE"] == -1 ? false : true;
            row["TOT_SEM_SEC_DELTA_REF_THEO"] = (int)row["TOT_SEM_SEC_DELTA_REF_THEO_FORCE"] == -1 ? (item.TOT_SEM_TOT_SEC_TEMPS_JOUR_GOOGLE) - (item.TOT_SEM_NB_SEC_TRAV_REF + item.TOT_SEM_NB_SEC_RTE_REF) : (int)row["TOT_SEM_SEC_DELTA_REF_THEO_FORCE"];
            //row["NQUIVISA"] = oCTPS_RECUP_TECH == null ? 0 : (int)oCTPS_RECUP_TECH.NQUI_AJOUT_VISA; 
            row["NQUIVISA"] = result_VISA == null ? 0 : (int)result_VISA[0]["NQUI_AJOUT_VISA"];
            row["NTPS_RECUP_ID"] = item.NTPS_RECUP_ID;

            //if (oCTPS_RECUP_TECH == null)
            //{
            //  row["DQUIVISA"] = DBNull.Value;
            //}
            //else
            //{
            //  row["DQUIVISA"] = oCTPS_RECUP_TECH.DATE_AJOUT_VISA;
            //}

            if (result_VISA == null)
            {
              row["DQUIVISA"] = DBNull.Value;
            }
            else
            {
              row["DQUIVISA"] = (DateTime)result_VISA[0]["DATE_AJOUT_VISA"];
            }


            //row["VQUIVISA"] = oCTPS_RECUP_TECH == null ? "" : oCTPS_RECUP_TECH.VQUI_AJOUT_VISA;
            row["VQUIVISA"] = result_VISA == null ? "" : (string)result_VISA[0]["VQUI_AJOUT_VISA"];


            row.AcceptChanges();
          }
        }

        //GVSuiviTpsTravDetail.RefreshEditor(true);
        // GCSuiviTpsTravDetail.RefreshDataSource();
        //GVSuiviTpsTravDetail.RefreshData();

      }


    }

    private object ZeroIfNull(object oValue)
    {
      return (oValue == null || oValue.ToString() == "") ? 0 : oValue;
    }

    private void LoadData(int P_NUM_MOIS, int P_ANNEE)
    {

      this.Cursor = Cursors.WaitCursor;

      DS_Tps_Suivi = new DataSet();

      dtListeSuiviTpsTrav_DET = new DataTable();

      SqlCommand CmdSql = new SqlCommand("[api_sp_SuiviTempsTrajet_Liste]", MozartDatabase.cnxMozart);
      CmdSql.CommandType = CommandType.StoredProcedure;
      SqlCommandBuilder.DeriveParameters(CmdSql);    // liste des paramètres

      //  liste des paramètres
      CmdSql.Parameters["@P_MOIS"].Value = P_NUM_MOIS;
      CmdSql.Parameters["@P_ANNEE"].Value = P_ANNEE;


      using (SqlDataReader reader = CmdSql.ExecuteReader())
      {
        //dtListeSuiviTpsTrav_SYN.Load(reader);       
        //reader.NextResult();
        dtListeSuiviTpsTrav_DET.Load(reader);
      }

      dtListeSuiviTpsTrav_DET.Columns["NB_SEC_TRAV_REF"].ReadOnly = false; //NB_SEC_TRAV_REF"];
      dtListeSuiviTpsTrav_DET.Columns["NB_SEC_RTE_REF"].ReadOnly = false; //NB_SEC_RTE_REF"];
      dtListeSuiviTpsTrav_DET.Columns["TOT_NB_SEC_REF"].ReadOnly = false; //TOT_NB_SEC_REF"];
      dtListeSuiviTpsTrav_DET.Columns["NB_SEC_HEURE_1ST_DEPART_MOZARIS"].ReadOnly = false; //NB_SEC_HEURE_1ST_DEPART_MOZARIS"];
      dtListeSuiviTpsTrav_DET.Columns["NB_SEC_HEURE_1ST_DEPART"].ReadOnly = false; //NB_SEC_HEURE_1ST_DEPART"];
      dtListeSuiviTpsTrav_DET.Columns["NB_SEC_HEURE_1ST_DEPART_MAN"].ReadOnly = false; //NB_SEC_HEURE_1ST_DEPART_MAN"];
      dtListeSuiviTpsTrav_DET.Columns["NB_SEC_HEURE_1ST_SITE_MOZARIS"].ReadOnly = false; //NB_SEC_HEURE_1ST_SITE_MOZARIS"];
      dtListeSuiviTpsTrav_DET.Columns["NB_SEC_HEURE_1ST_SITE"].ReadOnly = false; //NB_SEC_HEURE_1ST_SITE"];
      dtListeSuiviTpsTrav_DET.Columns["NB_SEC_HEURE_1ST_SITE_MAN"].ReadOnly = false; //NB_SEC_HEURE_1ST_SITE_MAN"];
      dtListeSuiviTpsTrav_DET.Columns["TOT_SEC_RTE_GPS_1ST_SITE_MOZARIS"].ReadOnly = false; //TOT_SEC_RTE_GPS_1ST_SITE_MOZARIS"];
      dtListeSuiviTpsTrav_DET.Columns["TOT_SEC_RTE_GPS_1ST_SITE"].ReadOnly = false; //TOT_SEC_RTE_GPS_1ST_SITE"];
      dtListeSuiviTpsTrav_DET.Columns["TOT_SEC_RTE_GPS_1ST_SITE_MAN"].ReadOnly = false; //TOT_SEC_RTE_GPS_1ST_SITE_MAN"];
      dtListeSuiviTpsTrav_DET.Columns["NSITNUM_1ST_ARRIVEE_SITE"].ReadOnly = false; //NSITNUM_1ST_ARRIVEE_SITE"];
      dtListeSuiviTpsTrav_DET.Columns["NB_SEC_HR_GOOGLE_DEPART_MOZARIS"].ReadOnly = false; //NB_SEC_HR_GOOGLE_DEPART_MOZARIS"];
      dtListeSuiviTpsTrav_DET.Columns["NB_SEC_HR_GOOGLE_DEPART"].ReadOnly = false; //NB_SEC_HR_GOOGLE_DEPART"];
      dtListeSuiviTpsTrav_DET.Columns["NB_SEC_HR_GOOGLE_DEPART_MAN"].ReadOnly = false; //NB_SEC_HR_GOOGLE_DEPART_MAN"];
      dtListeSuiviTpsTrav_DET.Columns["NB_SEC_HEURE_LAST_SITE_MOZARIS"].ReadOnly = false; //NB_SEC_HEURE_LAST_SITE_MOZARIS"];
      dtListeSuiviTpsTrav_DET.Columns["NB_SEC_HEURE_LAST_SITE"].ReadOnly = false; //NB_SEC_HEURE_LAST_SITE"];
      dtListeSuiviTpsTrav_DET.Columns["NB_SEC_HEURE_LAST_SITE_MAN"].ReadOnly = false; //NB_SEC_HEURE_LAST_SITE_MAN"];
      dtListeSuiviTpsTrav_DET.Columns["NB_SEC_HEURE_LAST_ARRIVEE_MOZARIS"].ReadOnly = false; //NB_SEC_HEURE_LAST_ARRIVEE_MOZARIS"];
      dtListeSuiviTpsTrav_DET.Columns["NB_SEC_HEURE_LAST_ARRIVEE"].ReadOnly = false; //NB_SEC_HEURE_LAST_ARRIVEE"];
      dtListeSuiviTpsTrav_DET.Columns["NB_SEC_HEURE_LAST_ARRIVEE_MAN"].ReadOnly = false; //NB_SEC_HEURE_LAST_ARRIVEE_MAN"];
      dtListeSuiviTpsTrav_DET.Columns["TOT_SEC_RTE_LAST_GPS_MOZARIS"].ReadOnly = false; //TOT_SEC_RTE_LAST_GPS_MOZARIS"];
      dtListeSuiviTpsTrav_DET.Columns["TOT_SEC_RTE_LAST_GPS"].ReadOnly = false; //TOT_SEC_RTE_LAST_GPS"];
      dtListeSuiviTpsTrav_DET.Columns["TOT_SEC_RTE_LAST_GPS_MAN"].ReadOnly = false; //TOT_SEC_RTE_LAST_GPS_MAN"];
      dtListeSuiviTpsTrav_DET.Columns["TOT_SEC_TPS_TRAV_MOZARIS"].ReadOnly = false; //TOT_SEC_TPS_TRAV_MOZARIS"];
      dtListeSuiviTpsTrav_DET.Columns["TOT_SEC_TPS_TRAV"].ReadOnly = false; //TOT_SEC_TPS_TRAV"];
      dtListeSuiviTpsTrav_DET.Columns["TOT_SEC_TPS_TRAV_MAN"].ReadOnly = false; //TOT_SEC_TPS_TRAV_MAN"];
      dtListeSuiviTpsTrav_DET.Columns["TOT_SEC_GPS_RTE_JOUR_MOZARIS"].ReadOnly = false; //TOT_SEC_GPS_RTE_JOUR_MOZARIS"];
      dtListeSuiviTpsTrav_DET.Columns["TOT_SEC_GPS_RTE_JOUR"].ReadOnly = false; //TOT_SEC_GPS_RTE_JOUR"];
      dtListeSuiviTpsTrav_DET.Columns["TOT_SEC_GPS_RTE_JOUR_MAN"].ReadOnly = false; //TOT_SEC_GPS_RTE_JOUR_MAN"];
      dtListeSuiviTpsTrav_DET.Columns["TOT_SEC_GOOGLE_RTE_JOUR_MOZARIS"].ReadOnly = false; //TOT_SEC_GOOGLE_RTE_JOUR_MOZARIS"];
      dtListeSuiviTpsTrav_DET.Columns["TOT_SEC_GOOGLE_RTE_JOUR"].ReadOnly = false; //TOT_SEC_GOOGLE_RTE_JOUR"];
      dtListeSuiviTpsTrav_DET.Columns["TOT_SEC_GOOGLE_RTE_JOUR_MAN"].ReadOnly = false; //TOT_SEC_GOOGLE_RTE_JOUR_MAN"];
      dtListeSuiviTpsTrav_DET.Columns["TOT_SEC_TEMPS_JOUR_GPS_MOZARIS"].ReadOnly = false; //TOT_SEC_TEMPS_JOUR_GPS_MOZARIS"];
      dtListeSuiviTpsTrav_DET.Columns["TOT_SEC_TEMPS_JOUR_GPS"].ReadOnly = false; //TOT_SEC_TEMPS_JOUR_GPS"];
      dtListeSuiviTpsTrav_DET.Columns["TOT_SEC_TEMPS_JOUR_GPS_MAN"].ReadOnly = false; //TOT_SEC_TEMPS_JOUR_GPS_MAN"];
      dtListeSuiviTpsTrav_DET.Columns["TOT_SEC_TEMPS_JOUR_GOOGLE_MOZARIS"].ReadOnly = false; //TOT_SEC_TEMPS_JOUR_GOOGLE_MOZARIS"];
      dtListeSuiviTpsTrav_DET.Columns["TOT_SEC_TEMPS_JOUR_GOOGLE"].ReadOnly = false; //TOT_SEC_TEMPS_JOUR_GOOGLE"];
      dtListeSuiviTpsTrav_DET.Columns["TOT_SEC_TEMPS_JOUR_GOOGLE_MAN"].ReadOnly = false; //TOT_SEC_TEMPS_JOUR_GOOGLE_MAN"];
      dtListeSuiviTpsTrav_DET.Columns["NB_HR_GOOGLE_ARRIVEE_MOZARIS"].ReadOnly = false; //NB_HR_GOOGLE_ARRIVEE_MOZARIS"];
      dtListeSuiviTpsTrav_DET.Columns["NB_HR_GOOGLE_ARRIVEE"].ReadOnly = false; //NB_HR_GOOGLE_ARRIVEE"];
      dtListeSuiviTpsTrav_DET.Columns["NB_HR_GOOGLE_ARRIVEE_MAN"].ReadOnly = false; //NB_HR_GOOGLE_ARRIVEE_MAN"];
      dtListeSuiviTpsTrav_DET.Columns["NSITNUM_LAST_DEPART_SITE"].ReadOnly = false; //NSITNUM_LAST_DEPART_SITE"];
      dtListeSuiviTpsTrav_DET.Columns["PRESENCE_ABSCENCE"].ReadOnly = false; //PRESENCE_ABSCENCE"];
      dtListeSuiviTpsTrav_DET.Columns["PRESENCE_GD"].ReadOnly = false; //PRESENCE_GD"];
      dtListeSuiviTpsTrav_DET.Columns["J_FERIE"].ReadOnly = false; //J_FERIE"];
      dtListeSuiviTpsTrav_DET.Columns["BNUIT"].ReadOnly = false; //BNUIT"];
      dtListeSuiviTpsTrav_DET.Columns["BCOMPTE_381"].ReadOnly = false; //BCOMPTE_381"];
      dtListeSuiviTpsTrav_DET.Columns["DELTA_REF_THEO"].ReadOnly = false; //DELTA_REF_THEO"];
      dtListeSuiviTpsTrav_DET.Columns["NTAUX_TPS_THEO_RATIO"].ReadOnly = false;
      dtListeSuiviTpsTrav_DET.Columns["NTPS_RECUP_ID"].ReadOnly = false;
      dtListeSuiviTpsTrav_DET.Columns["NUM_SEMAINE_ISO"].ReadOnly = false;
      dtListeSuiviTpsTrav_DET.Columns["NCOMPENSATION_INDEM"].ReadOnly = false;
      dtListeSuiviTpsTrav_DET.Columns["DCOMPENSATION_VISA"].ReadOnly = false;
      dtListeSuiviTpsTrav_DET.Columns["NCOMPENSATION_QUI_VISA"].ReadOnly = false;
      dtListeSuiviTpsTrav_DET.Columns["VCOMPENSATION_VISA"].ReadOnly = false;

      //creation table des techniciens
      dtListeTechs = new DataTable();
      dtListeTechs.Columns.AddRange(new DataColumn[] {new DataColumn("NPERNUM",typeof(int)),
                    new DataColumn("VTECHNOM",typeof(string)),
                  new DataColumn("V_SEM_V_SEM_TOT",typeof(string)),});

      dtListeTechs.Columns["V_SEM_V_SEM_TOT"].ReadOnly = false;


      var qTechsListe = from Tech in dtListeSuiviTpsTrav_DET.AsEnumerable()
                        group Tech by new { NPERNUM = Tech["NPERNUM"], VPERNOM = Tech["VPERNOM"] + " " + Tech["VPERPRE"] } into grp
                        select new
                        {
                          NPERNUM = grp.Key.NPERNUM,
                          VPERNOM = grp.Key.VPERNOM
                        };

      foreach (var item in qTechsListe.OrderBy(ord => ord.VPERNOM))
      {
        DataRow drnew = dtListeTechs.NewRow();
        drnew["NPERNUM"] = item.NPERNUM;
        drnew["VTECHNOM"] = item.VPERNOM;
        drnew["V_SEM_V_SEM_TOT"] = $"{ (dtListeSuiviTpsTrav_DET.AsEnumerable().Where(x => (int)x["NTPS_RECUP_ID"] > 0 && (int)x["NPERNUM"] == (int)item.NPERNUM).GroupBy(x => x["NUM_SEMAINE_ISO"]).Select(x => x.FirstOrDefault()).Count())} / {(dtListeSuiviTpsTrav_DET.AsEnumerable().GroupBy(x => x["NUM_SEMAINE_ISO"]).Select(x => x.FirstOrDefault()).Count())}";
        dtListeTechs.Rows.Add(drnew);
      }

      //creation tables synthese semaine
      dt_SYN_SEMAINE = new DataTable();
      dt_SYN_SEMAINE.Columns.AddRange(new DataColumn[] {new DataColumn("NPERNUM",typeof(int)),
                                                        new DataColumn("NUM_ANNEE",typeof(int)),
                                                        new DataColumn("NUM_SEMAINE_ISO",typeof(int)),
                                                        new DataColumn("NUM_SEMAINE",typeof(int)),
                                                        new DataColumn("VSEMAINE",typeof(string)),
                                                        new DataColumn("TOT_SEM_NB_SEC_REF",typeof(int)),
                                                        new DataColumn("TOT_SEM_SEC_TEMPS_JOUR_TRAV_AND_GOOGLE",typeof(int)),
                                                          new DataColumn("TOT_SEM_SEC_TEMPS_JOUR_TRAV_AND_GPS",typeof(int)),
                                                        new DataColumn("TOT_SEM_SEC_DELTA_REF_THEO_MOZARIS",typeof(int)),
                                                        new DataColumn("TOT_SEM_SEC_DELTA_REF_THEO_MANU",typeof(int)),
                                                        new DataColumn("TOT_SEM_SEC_DELTA_REF_THEO_FORCE",typeof(int)),
                                                        new DataColumn("TOT_SEM_SEC_DELTA_REF_THEO_FORCE_EXIST",typeof(bool)),
                                                        new DataColumn("TOT_SEM_SEC_DELTA_REF_THEO",typeof(int)),
                                                        new DataColumn("NTPS_RECUP_ID",typeof(int)),
                                                        new DataColumn("NQUIVISA",typeof(int)),
                                                        new DataColumn("DQUIVISA",typeof(DateTime)),
                                                        new DataColumn("VQUIVISA",typeof(string))
                                                        });

      dt_SYN_SEMAINE.Columns["TOT_SEM_SEC_DELTA_REF_THEO"].ReadOnly = false;
      dt_SYN_SEMAINE.Columns["TOT_SEM_SEC_DELTA_REF_THEO_FORCE"].ReadOnly = false;
      dt_SYN_SEMAINE.Columns["TOT_SEM_SEC_DELTA_REF_THEO_FORCE_EXIST"].ReadOnly = false;
      dt_SYN_SEMAINE.Columns["NQUIVISA"].ReadOnly = false;
      dt_SYN_SEMAINE.Columns["DQUIVISA"].ReadOnly = false;
      dt_SYN_SEMAINE.Columns["DQUIVISA"].AllowDBNull = true;
      dt_SYN_SEMAINE.Columns["VQUIVISA"].ReadOnly = false;
      dt_SYN_SEMAINE.Columns["NTPS_RECUP_ID"].ReadOnly = false;



      var qSYN_SEMAINE = from SYN_SEMAINE in dtListeSuiviTpsTrav_DET.AsEnumerable()
                         where SYN_SEMAINE.Field<int>("NID_SUIVI_TPS_TRAJET") != 0
                         group SYN_SEMAINE by new
                         {
                           NPERNUM = SYN_SEMAINE["NPERNUM"],
                           NUM_ANNEE = SYN_SEMAINE["NUM_ANNEE"],
                           NUM_SEMAINE_ISO = SYN_SEMAINE["NUM_SEMAINE_ISO"],
                           NUM_SEMAINE = SYN_SEMAINE["NUM_SEMAINE"],
                           NTPS_RECUP_ID = SYN_SEMAINE["NTPS_RECUP_ID"]
                         } into grp
                         select new
                         {
                           NPERNUM = grp.Key.NPERNUM,
                           NUM_ANNEE = grp.Key.NUM_ANNEE,
                           NUM_SEMAINE_ISO = grp.Key.NUM_SEMAINE_ISO,
                           NUM_SEMAINE = grp.Key.NUM_SEMAINE,
                           NTPS_RECUP_ID = grp.Key.NTPS_RECUP_ID,
                           TOT_SEM_NB_SEC_TRAV_REF = grp.Sum(s => s == null ? 0 : s.Field<int?>("NB_SEC_TRAV_REF")),
                           TOT_SEM_NB_SEC_RTE_REF = grp.Sum(s => s == null ? 0 : s.Field<int?>("NB_SEC_RTE_REF")),
                           TOT_SEM_TOT_SEC_TPS_TRAV = grp.Sum(s => s == null ? 0 : s.Field<int?>("TOT_SEC_TPS_TRAV")),
                           TOT_SEM_TOT_SEC_TEMPS_JOUR_GPS = grp.Sum(s => s == null ? 0 : s.Field<int?>("TOT_SEC_TEMPS_JOUR_GPS")),
                           TOT_SEM_TOT_SEC_TEMPS_JOUR_GOOGLE_MOZARIS = grp.Sum(s => s == null ? 0 : s.Field<int?>("TOT_SEC_TEMPS_JOUR_GOOGLE_MOZARIS")),
                           TOT_SEM_TOT_SEC_TEMPS_JOUR_GOOGLE_MAN = grp.Sum(s => s == null ? 0 : s.Field<int?>("TOT_SEC_TEMPS_JOUR_GOOGLE_MAN")),
                           TOT_SEM_TOT_SEC_TEMPS_JOUR_GOOGLE = grp.Sum(s => s == null ? 0 : s.Field<int?>("TOT_SEC_TEMPS_JOUR_GOOGLE"))
                         };

      foreach (var item in qSYN_SEMAINE.OrderBy(ord => ord.NUM_ANNEE).OrderBy(ord => ord.NUM_SEMAINE))
      {

        //on charge la class
        //CTPS_RECUP_TECH oCTPS_RECUP_TECH = null;
        //if ((int)item.NTPS_RECUP_ID > 0)
        //{
        //  oCTPS_RECUP_TECH = new CTPS_RECUP_TECH((int)item.NTPS_RECUP_ID);

        //}

        DataRow drnew = dt_SYN_SEMAINE.NewRow();
        drnew["NPERNUM"] = item.NPERNUM;
        drnew["NUM_ANNEE"] = item.NUM_ANNEE;
        drnew["NUM_SEMAINE_ISO"] = item.NUM_SEMAINE_ISO;
        drnew["NUM_SEMAINE"] = item.NUM_SEMAINE;
        drnew["NTPS_RECUP_ID"] = item.NTPS_RECUP_ID;
        drnew["VSEMAINE"] = $"{GetPeriodeSemaine((int)item.NUM_SEMAINE, (int)item.NUM_ANNEE)} - (S{item.NUM_SEMAINE})";
        drnew["TOT_SEM_NB_SEC_REF"] = item.TOT_SEM_NB_SEC_TRAV_REF + item.TOT_SEM_NB_SEC_RTE_REF;
        drnew["TOT_SEM_SEC_TEMPS_JOUR_TRAV_AND_GOOGLE"] = item.TOT_SEM_TOT_SEC_TEMPS_JOUR_GOOGLE;
        drnew["TOT_SEM_SEC_TEMPS_JOUR_TRAV_AND_GPS"] = item.TOT_SEM_TOT_SEC_TEMPS_JOUR_GPS;
        drnew["TOT_SEM_SEC_DELTA_REF_THEO_MOZARIS"] = (item.TOT_SEM_TOT_SEC_TEMPS_JOUR_GOOGLE_MOZARIS) - (item.TOT_SEM_NB_SEC_TRAV_REF + item.TOT_SEM_NB_SEC_RTE_REF);
        drnew["TOT_SEM_SEC_DELTA_REF_THEO_MANU"] = (item.TOT_SEM_TOT_SEC_TEMPS_JOUR_GOOGLE) - (item.TOT_SEM_NB_SEC_TRAV_REF + item.TOT_SEM_NB_SEC_RTE_REF);
        drnew["TOT_SEM_SEC_DELTA_REF_THEO_FORCE"] = -1; // GetDeltaForceManuel("TOT_SEM_SEC_DELTA_REF_THEO_FORCE", (int)item.NUM_SEMAINE_ISO, (int)item.NUM_ANNEE, (int)item.NPERNUM);
        drnew["TOT_SEM_SEC_DELTA_REF_THEO_FORCE_EXIST"] = (int)drnew["TOT_SEM_SEC_DELTA_REF_THEO_FORCE"] == -1 ? false : true;
        drnew["TOT_SEM_SEC_DELTA_REF_THEO"] = (int)drnew["TOT_SEM_SEC_DELTA_REF_THEO_FORCE"] == -1 ? (item.TOT_SEM_TOT_SEC_TEMPS_JOUR_GOOGLE) - (item.TOT_SEM_NB_SEC_TRAV_REF + item.TOT_SEM_NB_SEC_RTE_REF) : (int)drnew["TOT_SEM_SEC_DELTA_REF_THEO_FORCE"];

        //drnew["NQUIVISA"] = oCTPS_RECUP_TECH == null ? 0 : (int)oCTPS_RECUP_TECH.NQUI_AJOUT_VISA; 

        //if (oCTPS_RECUP_TECH == null)
        //{
        //  drnew["DQUIVISA"] = DBNull.Value;
        //}
        //else
        //{
        //  drnew["DQUIVISA"] = oCTPS_RECUP_TECH.DATE_AJOUT_VISA;
        //}

        //drnew["VQUIVISA"] = oCTPS_RECUP_TECH == null ? "" : oCTPS_RECUP_TECH.VQUI_AJOUT_VISA; 
        dt_SYN_SEMAINE.Rows.Add(drnew);
      }

      RefreshData();

      DS_Tps_Suivi.Tables.Add(dtListeTechs);
      DS_Tps_Suivi.Tables.Add(dt_SYN_SEMAINE);
      DS_Tps_Suivi.Tables.Add(dtListeSuiviTpsTrav_DET);

      //LEVEL 1
      DataColumn parentColumn_Lvl_1 = DS_Tps_Suivi.Tables[0].Columns["NPERNUM"];
      DataColumn childColumn_Lvl_1 = DS_Tps_Suivi.Tables[1].Columns["NPERNUM"];
      DataRelation relation_Lvl_1 = new System.Data.DataRelation("NPERNUM_RELATION_LVL_1", parentColumn_Lvl_1, childColumn_Lvl_1);
      DS_Tps_Suivi.Relations.Add(relation_Lvl_1);

      //LEVEL 2
      DataRelation relation_Lvl_2 = new System.Data.DataRelation("NPERNUM_RELATION_LVL_2",
                                                            new DataColumn[] { DS_Tps_Suivi.Tables[1].Columns["NPERNUM"], DS_Tps_Suivi.Tables[1].Columns["NUM_SEMAINE_ISO"] },
                                                            new DataColumn[] { DS_Tps_Suivi.Tables[2].Columns["NPERNUM"], DS_Tps_Suivi.Tables[2].Columns["NUM_SEMAINE_ISO"] });

      DS_Tps_Suivi.Relations.Add(relation_Lvl_2);

      GCSuiviTpsTravDetail.LevelTree.Nodes[0].RelationName = "NPERNUM_RELATION_LVL_1";
      GCSuiviTpsTravDetail.LevelTree.Nodes[0].Nodes[0].RelationName = "NPERNUM_RELATION_LVL_2";
      GV_SYN_SEMAINE.ChildGridLevelName = "NPERNUM_RELATION_LVL_1";
      GVSuiviTpsTravDetail.ChildGridLevelName = "NPERNUM_RELATION_LVL_2";

      GCSuiviTpsTravDetail.DataSource = DS_Tps_Suivi.Tables[0];

      this.Cursor = Cursors.Default;

    }

    //cette fonciton permet de récupérer la valuer manuelle
    private int GetDeltaForceManuel(string P_VFIELDNAME, int P_NUM_SEMAINE_ISO, int P_NUM_ANNEE, int P_NPERNUM)
    {

      int ValReturn = -1;

      SqlCommand CmdSql = new SqlCommand("[api_sp_SuiviTemps_DeltaForceManuel]", MozartDatabase.cnxMozart);
      CmdSql.CommandType = CommandType.StoredProcedure;
      SqlCommandBuilder.DeriveParameters(CmdSql);    // liste des paramètres

      //  liste des paramètres
      CmdSql.Parameters["@P_VFIELDNAME"].Value = P_VFIELDNAME;
      CmdSql.Parameters["@P_NUM_SEMAINE_ISO"].Value = P_NUM_SEMAINE_ISO;
      CmdSql.Parameters["@P_NUM_ANNEE"].Value = P_NUM_ANNEE;
      CmdSql.Parameters["@P_NPERNUM"].Value = P_NPERNUM;

      using (SqlDataReader reader = CmdSql.ExecuteReader())
      {
        while (reader.Read())
        {

          ValReturn = (int)reader["N_TOT_SEC_MAN"];


        }
      }

      return ValReturn;

    }

    private void LoadDataCbo()
    {
      dtCboMois = new DataTable();
      dtCboAnnee = new DataTable();

      SqlCommand CmdSql = new SqlCommand("[api_sp_SuiviTempsTrajet_Liste_Cbo]", MozartDatabase.cnxMozart);
      CmdSql.CommandType = CommandType.StoredProcedure;

      using (SqlDataReader reader = CmdSql.ExecuteReader())
      {
        dtCboMois.Load(reader);
        //reader.NextResult();
        dtCboAnnee.Load(reader);
      }

      CboMois.DataSource = dtCboMois;
      CboAnnee.DataSource = dtCboAnnee;


    }

    private void BtnValider_Click(object sender, EventArgs e)
    {

      if (CboMois.SelectedValue == null) MessageBox.Show("Il faut sélectionner un mois !", "Erreur", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
      if (CboAnnee.SelectedValue == null) MessageBox.Show("Il faut sélectionner une année !", "Erreur", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);

      LoadData((int)CboMois.SelectedValue, (int)CboAnnee.SelectedValue);
    }

    private static string GetPeriodeSemaine(int P_NUM_SEMAINE, int P_NUM_ANNEE)
    {

      System.Globalization.Calendar calendar = new System.Globalization.GregorianCalendar();
      int searchedWeek = P_NUM_SEMAINE; // N° de semaien à rechercher
      DateTime dtFirstDayFirstWeek = DateTime.MinValue; // pour éviter erreur de compil
      for (int iWeek = 0, iDay = 1; iWeek != 1; iDay++)
      {
        dtFirstDayFirstWeek = new DateTime(P_NUM_ANNEE, 1, iDay);
        iWeek = calendar.GetWeekOfYear(dtFirstDayFirstWeek, System.Globalization.CalendarWeekRule.FirstFullWeek, DayOfWeek.Monday);
      }
      DateTime EndOfWeek = calendar.AddWeeks(dtFirstDayFirstWeek, searchedWeek - 1).AddDays(-1);
      DateTime StartOfWeek = EndOfWeek.AddDays(-6);

      return $"{StartOfWeek.ToString("dd/MM/yyyy")} au {EndOfWeek.ToString("dd/MM/yyyy")}";

    }

    private void GVSuiviTpsTravDetail_CustomSummaryCalculate(object sender, DevExpress.Data.CustomSummaryEventArgs e)
    {
      if (e.IsTotalSummary)
      {

        switch (((GridSummaryItem)e.Item).FieldName)
        {

          case "TOT_NB_SEC_REF":

            if (e.SummaryProcess == DevExpress.Data.CustomSummaryProcess.Start)
            {
              Sum_TOT_NB_SEC_REF = 0;
            }
            if (e.SummaryProcess == DevExpress.Data.CustomSummaryProcess.Calculate)
            {

              if (e.GetValue("TOT_NB_SEC_REF") != DBNull.Value)
              {
                if ((bool)e.GetValue("PRESENCE_ABSCENCE") == false) Sum_TOT_NB_SEC_REF += (int)e.GetValue("TOT_NB_SEC_REF");
              }

            }
            if (e.SummaryProcess == DevExpress.Data.CustomSummaryProcess.Finalize)
            {
              if (Math.Abs(Sum_TOT_NB_SEC_REF) < 3600)
              {
                e.TotalValue = $"00:{Math.Floor((decimal)TimeSpan.FromSeconds(Sum_TOT_NB_SEC_REF).Minutes).ToString("00")}"; //:{Math.Abs(Math.Floor((decimal)TimeSpan.FromSeconds(Sum_TOT_NB_SEC_REF).Seconds)).ToString("00")}";
              }
              else
              {
                e.TotalValue = $"{((int)TimeSpan.FromSeconds(Sum_TOT_NB_SEC_REF).TotalHours).ToString("00")}:{Math.Abs(Math.Floor((decimal)TimeSpan.FromSeconds(Sum_TOT_NB_SEC_REF).Minutes)).ToString("00")}"; //:{Math.Abs(Math.Floor((decimal)TimeSpan.FromSeconds(Sum_TOT_NB_SEC_REF).Seconds)).ToString("00")}";
              }

            }
            break;

          case "DELTA_REF_THEO":

            if (e.SummaryProcess == DevExpress.Data.CustomSummaryProcess.Start)
            {
              Sum_DELTA_REF_THEO = 0;
            }
            if (e.SummaryProcess == DevExpress.Data.CustomSummaryProcess.Calculate)
            {

              if (e.GetValue("DELTA_REF_THEO") != DBNull.Value)
              {
                if ((bool)e.GetValue("PRESENCE_ABSCENCE") == false) Sum_DELTA_REF_THEO += (int)e.GetValue("DELTA_REF_THEO");
              }

            }
            if (e.SummaryProcess == DevExpress.Data.CustomSummaryProcess.Finalize)
            {
              if (Math.Abs(Sum_DELTA_REF_THEO) < 3600)
              {
                e.TotalValue = $"00:{Math.Floor((decimal)TimeSpan.FromSeconds(Sum_DELTA_REF_THEO).Minutes).ToString("00")}"; //:{Math.Abs(Math.Floor((decimal)TimeSpan.FromSeconds(Sum_DELTA_REF_THEO).Seconds)).ToString("00")}";
              }
              else
              {
                e.TotalValue = $"{((int)TimeSpan.FromSeconds(Sum_DELTA_REF_THEO).TotalHours).ToString("00")}:{Math.Abs(Math.Floor((decimal)TimeSpan.FromSeconds(Sum_DELTA_REF_THEO).Minutes)).ToString("00")}"; //:{Math.Abs(Math.Floor((decimal)TimeSpan.FromSeconds(Sum_DELTA_REF_THEO).Seconds)).ToString("00")}";
              }

            }
            break;

          case "TOT_SEC_TPS_TRAV":

            if (e.SummaryProcess == DevExpress.Data.CustomSummaryProcess.Start)
            {
              Tot_NB_SEC_HR_TRAVAILLE_TOTAL = 0;
            }
            if (e.SummaryProcess == DevExpress.Data.CustomSummaryProcess.Calculate)
            {

              if (e.GetValue("TOT_SEC_TPS_TRAV") != DBNull.Value)
              {
                if ((bool)e.GetValue("PRESENCE_ABSCENCE") == false) Tot_NB_SEC_HR_TRAVAILLE_TOTAL += (int)e.GetValue("TOT_SEC_TPS_TRAV");
              }

            }
            if (e.SummaryProcess == DevExpress.Data.CustomSummaryProcess.Finalize)
            {
              if (Math.Abs(Tot_NB_SEC_HR_TRAVAILLE_TOTAL) < 3600)
              {
                e.TotalValue = $"00:{Math.Floor((decimal)TimeSpan.FromSeconds(Tot_NB_SEC_HR_TRAVAILLE_TOTAL).Minutes).ToString("00")}"; //:{Math.Abs(Math.Floor((decimal)TimeSpan.FromSeconds(Tot_NB_SEC_HR_TRAVAILLE_TOTAL).Seconds)).ToString("00")}";
              }
              else
              {
                e.TotalValue = $"{((int)TimeSpan.FromSeconds(Tot_NB_SEC_HR_TRAVAILLE_TOTAL).TotalHours).ToString("00")}:{Math.Abs(Math.Floor((decimal)TimeSpan.FromSeconds(Tot_NB_SEC_HR_TRAVAILLE_TOTAL).Minutes)).ToString("00")}"; //:{Math.Abs(Math.Floor((decimal)TimeSpan.FromSeconds(Tot_NB_SEC_HR_TRAVAILLE_TOTAL).Seconds)).ToString("00")}";
              }


            }
            break;

          case "TOT_SEC_TEMPS_JOUR_GPS":

            if (e.SummaryProcess == DevExpress.Data.CustomSummaryProcess.Start)
            {
              Tot_NB_SEC_TEMPS_JOUR_GPS_TOTAL = 0;
            }
            if (e.SummaryProcess == DevExpress.Data.CustomSummaryProcess.Calculate)
            {

              if (e.GetValue("TOT_SEC_TEMPS_JOUR_GPS") != DBNull.Value)
              {
                if ((bool)e.GetValue("PRESENCE_ABSCENCE") == false) Tot_NB_SEC_TEMPS_JOUR_GPS_TOTAL += (int)e.GetValue("TOT_SEC_TEMPS_JOUR_GPS");
              }

            }
            if (e.SummaryProcess == DevExpress.Data.CustomSummaryProcess.Finalize)
            {
              if (Math.Abs(Tot_NB_SEC_TEMPS_JOUR_GPS_TOTAL) < 3600)
              {
                e.TotalValue = $"00:{Math.Floor((decimal)TimeSpan.FromSeconds(Tot_NB_SEC_TEMPS_JOUR_GPS_TOTAL).Minutes).ToString("00")}"; //:{Math.Abs(Math.Floor((decimal)TimeSpan.FromSeconds(Tot_NB_SEC_TEMPS_JOUR_GPS_TOTAL).Seconds)).ToString("00")}";
              }
              else
              {
                e.TotalValue = $"{((int)TimeSpan.FromSeconds(Tot_NB_SEC_TEMPS_JOUR_GPS_TOTAL).TotalHours).ToString("00")}:{Math.Abs(Math.Floor((decimal)TimeSpan.FromSeconds(Tot_NB_SEC_TEMPS_JOUR_GPS_TOTAL).Minutes)).ToString("00")}"; //:{Math.Abs(Math.Floor((decimal)TimeSpan.FromSeconds(Tot_NB_SEC_TEMPS_JOUR_GPS_TOTAL).Seconds)).ToString("00")}";
              }

            }
            break;

          case "TOT_SEC_TEMPS_JOUR_GOOGLE":

            if (e.SummaryProcess == DevExpress.Data.CustomSummaryProcess.Start)
            {
              Tot_NB_SEC_TEMPS_JOUR_GOOGLE_TOTAL = 0;
            }
            if (e.SummaryProcess == DevExpress.Data.CustomSummaryProcess.Calculate)
            {

              if (e.GetValue("TOT_SEC_TEMPS_JOUR_GOOGLE") != DBNull.Value)
              {
                if ((bool)e.GetValue("PRESENCE_ABSCENCE") == false) Tot_NB_SEC_TEMPS_JOUR_GOOGLE_TOTAL += (int)e.GetValue("TOT_SEC_TEMPS_JOUR_GOOGLE");
              }

            }
            if (e.SummaryProcess == DevExpress.Data.CustomSummaryProcess.Finalize)
            {
              //e.TotalValue = Tot_Secondes_V_HR_TEMPS_TRAVAIL_JOUR;
              //e.TotalValue = $"{ Math.Floor((decimal)TimeSpan.FromSeconds(Tot_NB_SEC_TEMPS_JOUR_GOOGLE_TOTAL).TotalHours).ToString("00")}:{Math.Floor((decimal)TimeSpan.FromSeconds(Tot_NB_SEC_TEMPS_JOUR_GOOGLE_TOTAL).Minutes).ToString("00")}:{Math.Floor((decimal)TimeSpan.FromSeconds(Tot_NB_SEC_TEMPS_JOUR_GOOGLE_TOTAL).Seconds).ToString("00")}";

              if (Math.Abs(Tot_NB_SEC_TEMPS_JOUR_GOOGLE_TOTAL) < 3600)
              {
                e.TotalValue = $"00:{Math.Floor((decimal)TimeSpan.FromSeconds(Tot_NB_SEC_TEMPS_JOUR_GOOGLE_TOTAL).Minutes).ToString("00")}"; //:{Math.Abs(Math.Floor((decimal)TimeSpan.FromSeconds(Tot_NB_SEC_TEMPS_JOUR_GOOGLE_TOTAL).Seconds)).ToString("00")}";
              }
              else
              {
                e.TotalValue = $"{((int)TimeSpan.FromSeconds(Tot_NB_SEC_TEMPS_JOUR_GOOGLE_TOTAL).TotalHours).ToString("00")}:{Math.Abs(Math.Floor((decimal)TimeSpan.FromSeconds(Tot_NB_SEC_TEMPS_JOUR_GOOGLE_TOTAL).Minutes)).ToString("00")}"; //:{Math.Abs(Math.Floor((decimal)TimeSpan.FromSeconds(Tot_NB_SEC_TEMPS_JOUR_GOOGLE_TOTAL).Seconds)).ToString("00")}";
              }

            }
            break;

          case "TOT_SEC_RTE_GPS_1ST_SITE":

            if (e.SummaryProcess == DevExpress.Data.CustomSummaryProcess.Start)
            {
              Sum_TOT_SEC_RTE_GPS_1ST_SITE = 0;
            }
            if (e.SummaryProcess == DevExpress.Data.CustomSummaryProcess.Calculate)
            {

              if (e.GetValue("TOT_SEC_RTE_GPS_1ST_SITE") != DBNull.Value)
              {
                if ((bool)e.GetValue("PRESENCE_ABSCENCE") == false) Sum_TOT_SEC_RTE_GPS_1ST_SITE += (int)e.GetValue("TOT_SEC_RTE_GPS_1ST_SITE");
              }

            }
            if (e.SummaryProcess == DevExpress.Data.CustomSummaryProcess.Finalize)
            {
              if (Math.Abs(Sum_TOT_SEC_RTE_GPS_1ST_SITE) < 3600)
              {
                e.TotalValue = $"00:{Math.Floor((decimal)TimeSpan.FromSeconds(Sum_TOT_SEC_RTE_GPS_1ST_SITE).Minutes).ToString("00")}"; //:{Math.Abs(Math.Floor((decimal)TimeSpan.FromSeconds(Sum_TOT_SEC_RTE_GPS_1ST_SITE).Seconds)).ToString("00")}";
              }
              else
              {
                e.TotalValue = $"{((int)TimeSpan.FromSeconds(Sum_TOT_SEC_RTE_GPS_1ST_SITE).TotalHours).ToString("00")}:{Math.Abs(Math.Floor((decimal)TimeSpan.FromSeconds(Sum_TOT_SEC_RTE_GPS_1ST_SITE).Minutes)).ToString("00")}"; //:{Math.Abs(Math.Floor((decimal)TimeSpan.FromSeconds(Sum_TOT_SEC_RTE_GPS_1ST_SITE).Seconds)).ToString("00")}";
              }

            }
            break;

          case "NB_SEC_HR_GOOGLE_DEPART":

            if (e.SummaryProcess == DevExpress.Data.CustomSummaryProcess.Start)
            {
              Sum_NB_SEC_HR_GOOGLE_DEPART = 0;
            }
            if (e.SummaryProcess == DevExpress.Data.CustomSummaryProcess.Calculate)
            {

              if (e.GetValue("NB_SEC_HR_GOOGLE_DEPART") != DBNull.Value)
              {
                if ((bool)e.GetValue("PRESENCE_ABSCENCE") == false) Sum_NB_SEC_HR_GOOGLE_DEPART += (int)e.GetValue("NB_SEC_HR_GOOGLE_DEPART");
              }

            }
            if (e.SummaryProcess == DevExpress.Data.CustomSummaryProcess.Finalize)
            {
              if (Math.Abs(Sum_NB_SEC_HR_GOOGLE_DEPART) < 3600)
              {
                e.TotalValue = $"00:{Math.Floor((decimal)TimeSpan.FromSeconds(Sum_NB_SEC_HR_GOOGLE_DEPART).Minutes).ToString("00")}"; //:{Math.Abs(Math.Floor((decimal)TimeSpan.FromSeconds(Sum_NB_SEC_HR_GOOGLE_DEPART).Seconds)).ToString("00")}";
              }
              else
              {
                e.TotalValue = $"{((int)TimeSpan.FromSeconds(Sum_NB_SEC_HR_GOOGLE_DEPART).TotalHours).ToString("00")}:{Math.Abs(Math.Floor((decimal)TimeSpan.FromSeconds(Sum_NB_SEC_HR_GOOGLE_DEPART).Minutes)).ToString("00")}"; //:{Math.Abs(Math.Floor((decimal)TimeSpan.FromSeconds(Sum_NB_SEC_HR_GOOGLE_DEPART).Seconds)).ToString("00")}";
              }

            }
            break;


          case "TOT_SEC_RTE_LAST_GPS":

            if (e.SummaryProcess == DevExpress.Data.CustomSummaryProcess.Start)
            {
              Sum_TOT_SEC_RTE_LAST_GPS = 0;
            }
            if (e.SummaryProcess == DevExpress.Data.CustomSummaryProcess.Calculate)
            {

              if (e.GetValue("TOT_SEC_RTE_LAST_GPS") != DBNull.Value)
              {
                if ((bool)e.GetValue("PRESENCE_ABSCENCE") == false) Sum_TOT_SEC_RTE_LAST_GPS += (int)e.GetValue("TOT_SEC_RTE_LAST_GPS");
              }

            }
            if (e.SummaryProcess == DevExpress.Data.CustomSummaryProcess.Finalize)
            {
              if (Math.Abs(Sum_TOT_SEC_RTE_LAST_GPS) < 3600)
              {
                e.TotalValue = $"00:{Math.Floor((decimal)TimeSpan.FromSeconds(Sum_TOT_SEC_RTE_LAST_GPS).Minutes).ToString("00")}"; //:{Math.Abs(Math.Floor((decimal)TimeSpan.FromSeconds(Sum_TOT_SEC_RTE_LAST_GPS).Seconds)).ToString("00")}";
              }
              else
              {
                e.TotalValue = $"{((int)TimeSpan.FromSeconds(Sum_TOT_SEC_RTE_LAST_GPS).TotalHours).ToString("00")}:{Math.Abs(Math.Floor((decimal)TimeSpan.FromSeconds(Sum_TOT_SEC_RTE_LAST_GPS).Minutes)).ToString("00")}"; //:{Math.Abs(Math.Floor((decimal)TimeSpan.FromSeconds(Sum_TOT_SEC_RTE_LAST_GPS).Seconds)).ToString("00")}";
              }

            }
            break;

          case "NB_HR_GOOGLE_ARRIVEE":

            if (e.SummaryProcess == DevExpress.Data.CustomSummaryProcess.Start)
            {
              Sum_NB_HR_GOOGLE_ARRIVEE = 0;
            }
            if (e.SummaryProcess == DevExpress.Data.CustomSummaryProcess.Calculate)
            {

              if (e.GetValue("NB_HR_GOOGLE_ARRIVEE") != DBNull.Value)
              {
                if ((bool)e.GetValue("PRESENCE_ABSCENCE") == false) Sum_NB_HR_GOOGLE_ARRIVEE += (int)e.GetValue("NB_HR_GOOGLE_ARRIVEE");
              }

            }
            if (e.SummaryProcess == DevExpress.Data.CustomSummaryProcess.Finalize)
            {
              if (Math.Abs(Sum_NB_HR_GOOGLE_ARRIVEE) < 3600)
              {
                e.TotalValue = $"00:{Math.Floor((decimal)TimeSpan.FromSeconds(Sum_NB_HR_GOOGLE_ARRIVEE).Minutes).ToString("00")}"; //:{Math.Abs(Math.Floor((decimal)TimeSpan.FromSeconds(Sum_NB_HR_GOOGLE_ARRIVEE).Seconds)).ToString("00")}";
              }
              else
              {
                e.TotalValue = $"{((int)TimeSpan.FromSeconds(Sum_NB_HR_GOOGLE_ARRIVEE).TotalHours).ToString("00")}:{Math.Abs(Math.Floor((decimal)TimeSpan.FromSeconds(Sum_NB_HR_GOOGLE_ARRIVEE).Minutes)).ToString("00")}"; //:{Math.Abs(Math.Floor((decimal)TimeSpan.FromSeconds(Sum_NB_HR_GOOGLE_ARRIVEE).Seconds)).ToString("00")}";
              }

            }
            break;

          case "TOT_SEC_GPS_RTE_JOUR":

            if (e.SummaryProcess == DevExpress.Data.CustomSummaryProcess.Start)
            {
              Sum_TOT_SEC_GPS_RTE_JOUR = 0;
            }
            if (e.SummaryProcess == DevExpress.Data.CustomSummaryProcess.Calculate)
            {

              if (e.GetValue("TOT_SEC_GPS_RTE_JOUR") != DBNull.Value)
              {
                if ((bool)e.GetValue("PRESENCE_ABSCENCE") == false) Sum_TOT_SEC_GPS_RTE_JOUR += (int)e.GetValue("TOT_SEC_GPS_RTE_JOUR");
              }

            }
            if (e.SummaryProcess == DevExpress.Data.CustomSummaryProcess.Finalize)
            {
              if (Math.Abs(Sum_TOT_SEC_GPS_RTE_JOUR) < 3600)
              {
                e.TotalValue = $"00:{Math.Floor((decimal)TimeSpan.FromSeconds(Sum_TOT_SEC_GPS_RTE_JOUR).Minutes).ToString("00")}"; //:{Math.Abs(Math.Floor((decimal)TimeSpan.FromSeconds(Sum_TOT_SEC_GPS_RTE_JOUR).Seconds)).ToString("00")}";
              }
              else
              {
                e.TotalValue = $"{((int)TimeSpan.FromSeconds(Sum_TOT_SEC_GPS_RTE_JOUR).TotalHours).ToString("00")}:{Math.Abs(Math.Floor((decimal)TimeSpan.FromSeconds(Sum_TOT_SEC_GPS_RTE_JOUR).Minutes)).ToString("00")}"; //:{Math.Abs(Math.Floor((decimal)TimeSpan.FromSeconds(Sum_TOT_SEC_GPS_RTE_JOUR).Seconds)).ToString("00")}";
              }

            }
            break;
          case "TOT_SEC_GOOGLE_RTE_JOUR":

            if (e.SummaryProcess == DevExpress.Data.CustomSummaryProcess.Start)
            {
              Sum_TOT_SEC_GOOGLE_RTE_JOUR = 0;
            }
            if (e.SummaryProcess == DevExpress.Data.CustomSummaryProcess.Calculate)
            {

              if (e.GetValue("TOT_SEC_GOOGLE_RTE_JOUR") != DBNull.Value)
              {
                if ((bool)e.GetValue("PRESENCE_ABSCENCE") == false) Sum_TOT_SEC_GOOGLE_RTE_JOUR += (int)e.GetValue("TOT_SEC_GOOGLE_RTE_JOUR");
              }

            }
            if (e.SummaryProcess == DevExpress.Data.CustomSummaryProcess.Finalize)
            {
              if (Math.Abs(Sum_TOT_SEC_GOOGLE_RTE_JOUR) < 3600)
              {
                e.TotalValue = $"00:{Math.Floor((decimal)TimeSpan.FromSeconds(Sum_TOT_SEC_GOOGLE_RTE_JOUR).Minutes).ToString("00")}"; //:{Math.Abs(Math.Floor((decimal)TimeSpan.FromSeconds(Sum_TOT_SEC_GOOGLE_RTE_JOUR).Seconds)).ToString("00")}";
              }
              else
              {
                e.TotalValue = $"{((int)TimeSpan.FromSeconds(Sum_TOT_SEC_GOOGLE_RTE_JOUR).TotalHours).ToString("00")}:{Math.Abs(Math.Floor((decimal)TimeSpan.FromSeconds(Sum_TOT_SEC_GOOGLE_RTE_JOUR).Minutes)).ToString("00")}"; //:{Math.Abs(Math.Floor((decimal)TimeSpan.FromSeconds(Sum_TOT_SEC_GOOGLE_RTE_JOUR).Seconds)).ToString("00")}";
              }

            }
            break;
        }


      }

    }

    private void GVSuiviTpsTravDetail_RowCellClick(object sender, DevExpress.XtraGrid.Views.Grid.RowCellClickEventArgs e)
    {

      List<CSUIV_TPS_TRAV_COL_GEST> FieldNamesCol = new List<CSUIV_TPS_TRAV_COL_GEST>();

      FieldNamesCol.Add(new CSUIV_TPS_TRAV_COL_GEST("NB_SEC_HEURE_1ST_DEPART", "NB_SEC_HEURE_1ST_DEPART_MAN", "NB_SEC_HEURE_1ST_DEPART_MOZARIS"));
      FieldNamesCol.Add(new CSUIV_TPS_TRAV_COL_GEST("NB_SEC_HEURE_1ST_SITE", "NB_SEC_HEURE_1ST_SITE_MAN", "NB_SEC_HEURE_1ST_SITE_MOZARIS"));
      //FieldNamesCol.Add(new CSUIV_TPS_TRAV_COL_GEST("TOT_SEC_RTE_GPS_1ST_SITE", "TOT_SEC_RTE_GPS_1ST_SITE_MAN", "TOT_SEC_RTE_GPS_1ST_SITE_MOZARIS"));
      FieldNamesCol.Add(new CSUIV_TPS_TRAV_COL_GEST("NB_SEC_HR_GOOGLE_DEPART", "NB_SEC_HR_GOOGLE_DEPART_MAN", "NB_SEC_HR_GOOGLE_DEPART_MOZARIS"));  //temps théorique matin
      FieldNamesCol.Add(new CSUIV_TPS_TRAV_COL_GEST("NB_SEC_HEURE_LAST_SITE", "NB_SEC_HEURE_LAST_SITE_MAN", "NB_SEC_HEURE_LAST_SITE_MOZARIS"));
      FieldNamesCol.Add(new CSUIV_TPS_TRAV_COL_GEST("NB_SEC_HEURE_LAST_ARRIVEE", "NB_SEC_HEURE_LAST_ARRIVEE_MAN", "NB_SEC_HEURE_LAST_ARRIVEE_MOZARIS"));
      //FieldNamesCol.Add(new CSUIV_TPS_TRAV_COL_GEST("TOT_SEC_RTE_LAST_GPS", "TOT_SEC_RTE_LAST_GPS_MAN", "TOT_SEC_RTE_LAST_GPS_MOZARIS"));
      FieldNamesCol.Add(new CSUIV_TPS_TRAV_COL_GEST("NB_HR_GOOGLE_ARRIVEE", "NB_HR_GOOGLE_ARRIVEE_MAN", "NB_HR_GOOGLE_ARRIVEE_MOZARIS")); //temps théorique soir

            FieldNamesCol.Add(new CSUIV_TPS_TRAV_COL_GEST("NCOMPENSATION_INDEM", "NCOMPENSATION_INDEM_MAN", "NCOMPENSATION_INDEM_MOZARIS")); //
                                                                                                                                                //FieldNamesCol.Add(new CSUIV_TPS_TRAV_COL_GEST("TOT_SEC_TPS_TRAV", "TOT_SEC_TPS_TRAV_MAN", "TOT_SEC_TPS_TRAV_MOZARIS"));
                                                                                                                                                //FieldNamesCol.Add(new CSUIV_TPS_TRAV_COL_GEST("TOT_SEC_GPS_RTE_JOUR", "TOT_SEC_GPS_RTE_JOUR_MAN", "TOT_SEC_GPS_RTE_JOUR_MOZARIS"));
                                                                                                                                                //FieldNamesCol.Add(new CSUIV_TPS_TRAV_COL_GEST("TOT_SEC_GOOGLE_RTE_JOUR", "TOT_SEC_GOOGLE_RTE_JOUR_MAN", "TOT_SEC_GOOGLE_RTE_JOUR_MOZARIS"));
                                                                                                                                                //FieldNamesCol.Add(new CSUIV_TPS_TRAV_COL_GEST("TOT_SEC_TEMPS_JOUR_GPS", "TOT_SEC_TEMPS_JOUR_GPS_MAN", "TOT_SEC_TEMPS_JOUR_GPS_MOZARIS"));
                                                                                                                                                //FieldNamesCol.Add(new CSUIV_TPS_TRAV_COL_GEST("TOT_SEC_TEMPS_JOUR_GOOGLE", "TOT_SEC_TEMPS_JOUR_GOOGLE_MAN", "TOT_SEC_TEMPS_JOUR_GOOGLE_MOZARIS"));

            List<CSUIV_TPS_TRAV_COL_GEST> oLstContains = FieldNamesCol.FindAll(x => x.VFIELDNAME == e.Column.FieldName);

      if (oLstContains.Count > 0)
      {
        //on affiche 
        if (e.Button == MouseButtons.Right)
        {

          if (e.RowHandle > -1)
          {

            DataRow DrSelected = (DataRow)(GCSuiviTpsTravDetail.FocusedView as GridView).GetDataRow(e.RowHandle);

            if (DrSelected == null) return;

            //recherche si visa semaine
            if (dt_SYN_SEMAINE.Select($"NPERNUM = {DrSelected["NPERNUM"]} AND NUM_SEMAINE_ISO = {DrSelected["NUM_SEMAINE_ISO"]} AND NUM_ANNEE = {DrSelected["NUM_ANNEE"]} AND DQUIVISA IS NOT NULL").ToList().Count() > 0)
            {
              MessageBox.Show("La modification est impossible car cette semaine a été validée", "Erreur", MessageBoxButtons.OK, MessageBoxIcon.Warning);
              return;
            }

                        if (oLstContains.First().VFIELDNAME == "NCOMPENSATION_INDEM")
                        {

                            //test s'il y un visa
                            if (DrSelected["DCOMPENSATION_VISA"] != null && DrSelected["DCOMPENSATION_VISA"].ToString() != "")
                            {
                                MessageBox.Show($"Vous ne pouvez pas modifier la compensation car il y a un visa !", "Information", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                                return;
                            }

                            using (frmSuiviTempsTravailTechSaisieManuelleIndemnite f = new frmSuiviTempsTravailTechSaisieManuelleIndemnite())
                            {
                                f.sColText = e.Column.Caption;
                                f.Text = DrSelected.Field<string>("VPERNOM") + " " + DrSelected.Field<string>("VPERPRE") + " - Date - " + Convert.ToDateTime(DrSelected.Field<DateTime>("DATE_JOUR")).ToShortDateString() + " - " + e.Column.Caption;
                                f.fieldname = e.Column.FieldName;
                                f.indemnite_compensation_MOZART = DrSelected.Field<decimal>(oLstContains.First().VFIELDNAME_MOZARIS);
                                f.NID_SUIVI_TPS_TRAJET = DrSelected.Field<int>("NID_SUIVI_TPS_TRAJET");
                                f.ShowDialog();
                                if (f.bChangeValid == true)
                                {
                                    DrSelected[oLstContains.First().VFIELDNAME] = f.MONTANT_COMPENSATION;
                                    DrSelected[oLstContains.First().VFIELDNAME_MAN] = 1;

                                    dtListeSuiviTpsTrav_DET.AcceptChanges();
                                    RefreshData();
                                }
                            }                           

                        }
                        else
                        {
                            using (frmSuiviTempsTravailTechSaisieManuelle f = new frmSuiviTempsTravailTechSaisieManuelle())
                            {
                                f.sColText = e.Column.Caption;
                                f.Text = DrSelected.Field<string>("VPERNOM") + " " + DrSelected.Field<string>("VPERPRE") + " - Date - " + Convert.ToDateTime(DrSelected.Field<DateTime>("DATE_JOUR")).ToShortDateString() + " - " + e.Column.Caption;
                                f.fieldname = e.Column.FieldName;
                                f.duree_seconde_MOZART = DrSelected.Field<int>(oLstContains.First().VFIELDNAME_MOZARIS);
                                f.NID_SUIVI_TPS_TRAJET = DrSelected.Field<int>("NID_SUIVI_TPS_TRAJET");
                                f.ShowDialog();
                                if (f.bChangeValid == true)
                                {

                                    //avant de mettre à jour le temps de jour téhorique, on teste s'il ce temps a été modifié, si oui, on teste si visa compensation saisie. si oui, alors on averti par message que la compensation à été validée, controler à nouveau
                                    if (e.Column.FieldName == "NB_SEC_HR_GOOGLE_DEPART" || e.Column.FieldName == "NB_HR_GOOGLE_ARRIVEE")
                                    {

                                        if ((int)DrSelected[e.Column.FieldName] != f.N_TOT_SEC_MAN)
                                        {
                                            //teste si visa
                                            if (DrSelected["DCOMPENSATION_VISA"] != null && DrSelected["DCOMPENSATION_VISA"].ToString() != "")
                                            {
                                                MessageBox.Show($"Vous avez modifié le temps de route théorique alors qu'une validation de compensation a déjà été validée.\r\nPar conséquent, la validation de cette compensation a été supprimée", "Information", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                                                DrSelected["DCOMPENSATION_VISA"] = DBNull.Value;
                                                DrSelected["NCOMPENSATION_QUI_VISA"] = DBNull.Value;
                                                DrSelected["VCOMPENSATION_VISA"] = "";

                                                //execution de la requete de maj des data
                                                SqlCommand sqldelete = new SqlCommand("[api_sp_SuiviTempsTrajet_Del_Compensa_Idem]", MozartDatabase.cnxMozart);
                                                sqldelete.CommandType = CommandType.StoredProcedure;
                                                SqlCommandBuilder.DeriveParameters(sqldelete);    // liste des paramètres
                                                sqldelete.Parameters["@P_NID_SUIVI_TPS_TRAJET"].Value = DrSelected["NID_SUIVI_TPS_TRAJET"];

                                                sqldelete.ExecuteNonQuery();

                                            }
                                            else
                                            {
                                                MessageBox.Show($"Vous avez modifié le temps de route théorique pouvant avoir un impact sur l'attribution d'une compensation", "Information", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                                            }

                                        }

                                    }

                                    //f.duree_seconde_MOZART
                                    DrSelected[oLstContains.First().VFIELDNAME] = f.N_TOT_SEC_MAN;
                                    DrSelected[oLstContains.First().VFIELDNAME_MAN] = 1;

                                    dtListeSuiviTpsTrav_DET.AcceptChanges();
                                    RefreshData();

                                }
                            }
                        }
          }

        }
      }
    }

    private void GV_SYN_SEMAINE_RowCellClick(object sender, RowCellClickEventArgs e)
    {

      if (e.Column.FieldName == "TOT_SEM_SEC_DELTA_REF_THEO")
      {
        //on affiche 
        if (e.Button == MouseButtons.Right)
        {

          if (e.RowHandle > -1)
          {

            DataRow DrSelected = (DataRow)(GCSuiviTpsTravDetail.FocusedView as GridView).GetDataRow(e.RowHandle);

            if (DrSelected == null) return;

            if (DrSelected["DQUIVISA"] != null)
            {
              MessageBox.Show("La modification est impossible car cette semaine a été validée", "Erreur", MessageBoxButtons.OK, MessageBoxIcon.Warning);
              return;
            }

            string NomTech = "";


            //on recherche le nom du tech
            List<DataRow> foundTech = dtListeTechs.Select($"NPERNUM ={DrSelected["NPERNUM"]}").ToList();

            foreach (DataRow Dr in foundTech)
            {

              NomTech = Dr["VTECHNOM"].ToString();

            }


            using (frmSuiviTempsTravailTechSaisieManuelle f = new frmSuiviTempsTravailTechSaisieManuelle())
            {
              f.sColText = e.Column.Caption;
              f.Text = $"{NomTech} - Semaine - {DrSelected.Field<int>("NUM_SEMAINE").ToString()} -  ({GetPeriodeSemaine((int)DrSelected.Field<int>("NUM_SEMAINE"), (int)DrSelected.Field<int>("NUM_ANNEE")).ToString()}) - {e.Column.Caption}";
              f.fieldname = "TOT_SEM_SEC_DELTA_REF_THEO_FORCE";
              f.duree_seconde_MOZART = DrSelected.Field<int>("TOT_SEM_SEC_DELTA_REF_THEO_MOZARIS");
              f.NID_SUIVI_TPS_TRAJET = 0;
              f.num_semaine_iso = DrSelected.Field<int>("NUM_SEMAINE_ISO");
              f.num_annee = DrSelected.Field<int>("NUM_ANNEE");
              f.NPERNUM = (int)DrSelected["NPERNUM"];
              f.ShowDialog();
              if (f.bChangeValid == true)
              {
                //f.duree_seconde_MOZART
                //DrSelected["TOT_SEM_SEC_DELTA_REF_THEO_FORCE"] = f.N_TOT_SEC_MAN;
                //DrSelected["TOT_SEM_SEC_DELTA_REF_THEO_FORCE_EXIST"] = true;

                //on met à jour la table source
                /*List<DataRow> LstRowSrc = dtListeSuiviTpsTrav_DET.Select($"NID_SUIVI_TPS_TRAJET={NID_SUIVI_TRAJET_SEMAINE_LUNDI}").ToList();

                foreach(DataRow DrUpdate in LstRowSrc)                
                {
                  DrUpdate["TOT_SEM_SEC_DELTA_REF_THEO_FORCE"] = f.N_TOT_SEC_MAN;
                }         */
                dt_SYN_SEMAINE.AcceptChanges();
                RefreshData();

              }
            }
          }

        }
      }

    }

    private void GVSuiviTpsTravDetail_CustomColumnDisplayText(object sender, DevExpress.XtraGrid.Views.Base.CustomColumnDisplayTextEventArgs e)
    {

      //liste des colonnes dans lesquelles les secondes sont affichées en time
      List<string> FieldNames = new List<string>();

      FieldNames.Add("NB_SEC_HEURE_1ST_DEPART");
      FieldNames.Add("NB_SEC_HEURE_1ST_SITE");
      FieldNames.Add("NB_SEC_HR_GOOGLE_DEPART");
      FieldNames.Add("TOT_SEC_RTE_GPS_1ST_SITE");
      FieldNames.Add("NB_SEC_HR_GOOGLE_DEPART");
      FieldNames.Add("NB_SEC_HEURE_LAST_SITE");
      FieldNames.Add("NB_SEC_HEURE_LAST_ARRIVEE");
      FieldNames.Add("TOT_SEC_RTE_LAST_GPS");
      FieldNames.Add("NB_HR_GOOGLE_ARRIVEE");
      FieldNames.Add("TOT_SEC_TPS_TRAV");
      FieldNames.Add("TOT_SEC_GPS_RTE_JOUR");
      FieldNames.Add("TOT_SEC_GOOGLE_RTE_JOUR");
      FieldNames.Add("TOT_SEC_TEMPS_JOUR_GPS");
      FieldNames.Add("TOT_SEC_TEMPS_JOUR_GOOGLE");
      FieldNames.Add("TOT_NB_SEC_REF");
      FieldNames.Add("NB_SEC_RTE_REF");
      FieldNames.Add("DELTA_REF_THEO");

      if (FieldNames.Contains(e.Column.FieldName))
      {
        if (e.Value != null && e.Value.ToString() != "")
        {

          if (Math.Abs((int)e.Value) < 3600)
          {
            e.DisplayText = $"{GetPolarite((int)e.Value)}00:{Math.Abs(Math.Floor((decimal)TimeSpan.FromSeconds((int)e.Value).Minutes)).ToString("00")}"; //:{Math.Abs(Math.Floor((decimal)TimeSpan.FromSeconds((int)e.Value).Seconds)).ToString("00")}";
          }
          else
          {
            e.DisplayText = $"{GetPolarite((int)e.Value)}{((int)TimeSpan.FromSeconds(Math.Abs((int)e.Value)).TotalHours).ToString("00")}:{Math.Abs(Math.Floor((decimal)TimeSpan.FromSeconds((int)e.Value).Minutes)).ToString("00")}"; //:{Math.Abs(Math.Floor((decimal)TimeSpan.FromSeconds((int)e.Value).Seconds)).ToString("00")}";
          }

        }
      }

    }



    private void GV_SYN_SEMAINE_MasterRowGetRelationDisplayCaption(object sender, MasterRowGetRelationNameEventArgs e)
    {
      if (e.RowHandle > -1)
      {
        DataRow DrReading = ((GridView)GCSuiviTpsTravDetail.FocusedView).GetDataRow(e.RowHandle);

        e.RelationName = $"SEMAINE N° {DrReading.Field<int>("NUM_SEMAINE").ToString()} ({GetPeriodeSemaine(DrReading.Field<int>("NUM_SEMAINE"), DrReading.Field<int>("NUM_ANNEE"))})";

      }
    }
    private void GVListeTechs_MasterRowGetRelationDisplayCaption(object sender, MasterRowGetRelationNameEventArgs e)
    {
      if (e.RowHandle > -1)
      {
        DataRow DrReading = GVListeTechs.GetDataRow(e.RowHandle);

        e.RelationName = DrReading.Field<string>("VTECHNOM"); ;

      }
    }

    private void BtnHisto_Click(object sender, EventArgs e)
    {
      GridView oView = (GridView)GCSuiviTpsTravDetail.FocusedView;
      if (oView.FocusedRowHandle > -1)
      {
        DataRow DrReading = ((GridView)GCSuiviTpsTravDetail.FocusedView).GetDataRow(oView.FocusedRowHandle);

        if (DrReading == null) return;

        oFrmSuiviTempsTravailTech_Histo = new frmSuiviTempsTravailTech_Histo($"{DrReading.Field<string>("VPERNOM")} {DrReading.Field<string>("VPERPRE")}", DrReading.Field<int>("NPERNUM"), DrReading.Field<int>("NUM_SEMAINE"));
        oFrmSuiviTempsTravailTech_Histo.Show();

      }
    }

    private void frmSuiviTempsTravailTechDetail_FormClosing(object sender, FormClosingEventArgs e)
    {
      if (oFrmSuiviTempsTravailTech_Histo != null) oFrmSuiviTempsTravailTech_Histo.Close();
    }

    private void GV_SYN_SEMAINE_CustomColumnDisplayText(object sender, CustomColumnDisplayTextEventArgs e)
    {
      //liste des colonnes dans lesquelles les secondes sont affichées en time
      List<string> FieldNames = new List<string>();

      FieldNames.Add("TOT_SEM_NB_SEC_REF");
      FieldNames.Add("TOT_SEM_SEC_TEMPS_JOUR_TRAV_AND_GOOGLE");
      FieldNames.Add("TOT_SEM_SEC_TEMPS_JOUR_TRAV_AND_GPS");
      FieldNames.Add("TOT_SEM_SEC_DELTA_REF_THEO");
      FieldNames.Add("TOT_SEM_SEC_DELTA_REF_THEO_MOZARIS");
      FieldNames.Add("TOT_SEM_SEC_DELTA_REF_THEO_MANU");
      FieldNames.Add("TOT_SEM_SEC_DELTA_REF_THEO_FORCE");

      if (FieldNames.Contains(e.Column.FieldName))
      {
        if (e.Value != null && e.Value.ToString() != "")
        {

          if (Math.Abs((int)e.Value) < 3600)
          {
            e.DisplayText = $"{GetPolarite((int)e.Value)}00:{Math.Abs(Math.Floor((decimal)TimeSpan.FromSeconds((int)e.Value).Minutes)).ToString("00")}"; //:{Math.Abs(Math.Floor((decimal)TimeSpan.FromSeconds((int)e.Value).Seconds)).ToString("00")}";
          }
          else
          {
            e.DisplayText = $"{GetPolarite((int)e.Value)}{((int)TimeSpan.FromSeconds(Math.Abs((int)e.Value)).TotalHours).ToString("00")}:{Math.Abs(Math.Floor((decimal)TimeSpan.FromSeconds((int)e.Value).Minutes)).ToString("00")}"; //:{Math.Abs(Math.Floor((decimal)TimeSpan.FromSeconds((int)e.Value).Seconds)).ToString("00")}";
          }
        }
      }
    }

    private void RItem_Btn_Refresh_ButtonClick(object sender, DevExpress.XtraEditors.Controls.ButtonPressedEventArgs e)
    {
      GridView oView = (GridView)GCSuiviTpsTravDetail.FocusedView;
      if (oView.FocusedRowHandle > -1)
      {
        DataRow DrReading = ((GridView)GCSuiviTpsTravDetail.FocusedView).GetDataRow(oView.FocusedRowHandle);

        if (DrReading == null) return;

        //recherche si visa semaine
        if (dt_SYN_SEMAINE.Select($"NPERNUM = {DrReading["NPERNUM"]} AND NUM_SEMAINE_ISO = {DrReading["NUM_SEMAINE_ISO"]} AND NUM_ANNEE = {DrReading["NUM_ANNEE"]} AND DQUIVISA IS NOT NULL").ToList().Count() > 0)
        {
          MessageBox.Show("La modification est impossible car cette semaine a été validée", "Erreur", MessageBoxButtons.OK, MessageBoxIcon.Warning);
          return;
        }

        //MessageBox.Show($"NID_SUIVI_TPS_TRAJET = {DrReading.Field<int>("NID_SUIVI_TPS_TRAJET").ToString()}");
        if (MessageBox.Show($"Voulez-vous recharger les données de cette journée {DrReading["DATE_JOUR"]} ?\nA noter : Cette opération va supprimer la validation de compensation.", "Confirmation", MessageBoxButtons.YesNoCancel, MessageBoxIcon.Question) != DialogResult.Yes) return;

        //execution de la requete de maj des data
        SqlCommand sqlupdate = new SqlCommand("api_sp_Job_Suivi_Tps_Travail_Mois", MozartDatabase.cnxMozart);
        sqlupdate.CommandType = CommandType.StoredProcedure;
        SqlCommandBuilder.DeriveParameters(sqlupdate);    // liste des paramètres

        //  liste des paramètres
        sqlupdate.Parameters["@VSOCIETE"].Value = MozartLib.MozartParams.NomSociete;
        sqlupdate.Parameters["@P_MODE_UPDATE_ROW"].Value = 1;
        sqlupdate.Parameters["@P_DATE_P_DEBUT"].Value = DrReading.Field<DateTime>("DATE_JOUR");
        sqlupdate.Parameters["@P_DATE_P_FIN"].Value = DrReading.Field<DateTime>("DATE_JOUR");
        sqlupdate.Parameters["@P_NPERNUM"].Value = DrReading.Field<int>("NPERNUM");

        sqlupdate.ExecuteNonQuery();

        SqlCommand sqlcmd = new SqlCommand("[api_sp_SuiviTempsTrajet_Liste]", MozartDatabase.cnxMozart);
        sqlcmd.CommandType = CommandType.StoredProcedure;
        SqlCommandBuilder.DeriveParameters(sqlcmd);    // liste des paramètres

        //  liste des paramètres
        sqlcmd.Parameters["@P_MOIS"].Value = (int)CboMois.SelectedValue;
        sqlcmd.Parameters["@P_ANNEE"].Value = (int)CboAnnee.SelectedValue;
        sqlcmd.Parameters["@P_MODE_UPDATE_ROW"].Value = 1;
        sqlcmd.Parameters["@P_NID_SUIVI_TPS_TRAJET"].Value = DrReading.Field<int>("NID_SUIVI_TPS_TRAJET");

        using (SqlDataReader reader = sqlcmd.ExecuteReader())
        {
          reader.Read();
          DataRow[] result = dtListeSuiviTpsTrav_DET.Select($"NID_SUIVI_TPS_TRAJET = {reader["NID_SUIVI_TPS_TRAJET"]}");

          foreach (DataRow row in result)
          {
            row["NB_SEC_TRAV_REF"] = reader["NB_SEC_TRAV_REF"];
            row["NB_SEC_RTE_REF"] = reader["NB_SEC_RTE_REF"];
            row["TOT_NB_SEC_REF"] = reader["TOT_NB_SEC_REF"];
            row["NB_SEC_HEURE_1ST_DEPART_MOZARIS"] = reader["NB_SEC_HEURE_1ST_DEPART_MOZARIS"];
            row["NB_SEC_HEURE_1ST_DEPART"] = reader["NB_SEC_HEURE_1ST_DEPART"];
            row["NB_SEC_HEURE_1ST_DEPART_MAN"] = reader["NB_SEC_HEURE_1ST_DEPART_MAN"];
            row["NB_SEC_HEURE_1ST_SITE_MOZARIS"] = reader["NB_SEC_HEURE_1ST_SITE_MOZARIS"];
            row["NB_SEC_HEURE_1ST_SITE"] = reader["NB_SEC_HEURE_1ST_SITE"];
            row["NB_SEC_HEURE_1ST_SITE_MAN"] = reader["NB_SEC_HEURE_1ST_SITE_MAN"];
            row["TOT_SEC_RTE_GPS_1ST_SITE_MOZARIS"] = reader["TOT_SEC_RTE_GPS_1ST_SITE_MOZARIS"];
            row["TOT_SEC_RTE_GPS_1ST_SITE"] = reader["TOT_SEC_RTE_GPS_1ST_SITE"];
            row["TOT_SEC_RTE_GPS_1ST_SITE_MAN"] = reader["TOT_SEC_RTE_GPS_1ST_SITE_MAN"];
            row["NSITNUM_1ST_ARRIVEE_SITE"] = reader["NSITNUM_1ST_ARRIVEE_SITE"];
            row["NB_SEC_HR_GOOGLE_DEPART_MOZARIS"] = reader["NB_SEC_HR_GOOGLE_DEPART_MOZARIS"];
            row["NB_SEC_HR_GOOGLE_DEPART"] = reader["NB_SEC_HR_GOOGLE_DEPART"];
            row["NB_SEC_HR_GOOGLE_DEPART_MAN"] = reader["NB_SEC_HR_GOOGLE_DEPART_MAN"];
            row["NB_SEC_HEURE_LAST_SITE_MOZARIS"] = reader["NB_SEC_HEURE_LAST_SITE_MOZARIS"];
            row["NB_SEC_HEURE_LAST_SITE"] = reader["NB_SEC_HEURE_LAST_SITE"];
            row["NB_SEC_HEURE_LAST_SITE_MAN"] = reader["NB_SEC_HEURE_LAST_SITE_MAN"];
            row["NB_SEC_HEURE_LAST_ARRIVEE_MOZARIS"] = reader["NB_SEC_HEURE_LAST_ARRIVEE_MOZARIS"];
            row["NB_SEC_HEURE_LAST_ARRIVEE"] = reader["NB_SEC_HEURE_LAST_ARRIVEE"];
            row["NB_SEC_HEURE_LAST_ARRIVEE_MAN"] = reader["NB_SEC_HEURE_LAST_ARRIVEE_MAN"];
            row["TOT_SEC_RTE_LAST_GPS_MOZARIS"] = reader["TOT_SEC_RTE_LAST_GPS_MOZARIS"];
            row["TOT_SEC_RTE_LAST_GPS"] = reader["TOT_SEC_RTE_LAST_GPS"];
            row["TOT_SEC_RTE_LAST_GPS_MAN"] = reader["TOT_SEC_RTE_LAST_GPS_MAN"];
            row["TOT_SEC_TPS_TRAV_MOZARIS"] = reader["TOT_SEC_TPS_TRAV_MOZARIS"];
            row["TOT_SEC_TPS_TRAV"] = reader["TOT_SEC_TPS_TRAV"];
            row["TOT_SEC_TPS_TRAV_MAN"] = reader["TOT_SEC_TPS_TRAV_MAN"];
            row["TOT_SEC_GPS_RTE_JOUR_MOZARIS"] = reader["TOT_SEC_GPS_RTE_JOUR_MOZARIS"];
            row["TOT_SEC_GPS_RTE_JOUR"] = reader["TOT_SEC_GPS_RTE_JOUR"];
            row["TOT_SEC_GPS_RTE_JOUR_MAN"] = reader["TOT_SEC_GPS_RTE_JOUR_MAN"];
            row["TOT_SEC_GOOGLE_RTE_JOUR_MOZARIS"] = reader["TOT_SEC_GOOGLE_RTE_JOUR_MOZARIS"];
            row["TOT_SEC_GOOGLE_RTE_JOUR"] = reader["TOT_SEC_GOOGLE_RTE_JOUR"];
            row["TOT_SEC_GOOGLE_RTE_JOUR_MAN"] = reader["TOT_SEC_GOOGLE_RTE_JOUR_MAN"];
            row["TOT_SEC_TEMPS_JOUR_GPS_MOZARIS"] = reader["TOT_SEC_TEMPS_JOUR_GPS_MOZARIS"];
            row["TOT_SEC_TEMPS_JOUR_GPS"] = reader["TOT_SEC_TEMPS_JOUR_GPS"];
            row["TOT_SEC_TEMPS_JOUR_GPS_MAN"] = reader["TOT_SEC_TEMPS_JOUR_GPS_MAN"];
            row["TOT_SEC_TEMPS_JOUR_GOOGLE_MOZARIS"] = reader["TOT_SEC_TEMPS_JOUR_GOOGLE_MOZARIS"];
            row["TOT_SEC_TEMPS_JOUR_GOOGLE"] = reader["TOT_SEC_TEMPS_JOUR_GOOGLE"];
            row["TOT_SEC_TEMPS_JOUR_GOOGLE_MAN"] = reader["TOT_SEC_TEMPS_JOUR_GOOGLE_MAN"];
            row["NB_HR_GOOGLE_ARRIVEE_MOZARIS"] = reader["NB_HR_GOOGLE_ARRIVEE_MOZARIS"];
            row["NB_HR_GOOGLE_ARRIVEE"] = reader["NB_HR_GOOGLE_ARRIVEE"];
            row["NB_HR_GOOGLE_ARRIVEE_MAN"] = reader["NB_HR_GOOGLE_ARRIVEE_MAN"];
            row["NSITNUM_LAST_DEPART_SITE"] = reader["NSITNUM_LAST_DEPART_SITE"];
            row["PRESENCE_ABSCENCE"] = reader["PRESENCE_ABSCENCE"];
            row["PRESENCE_GD"] = reader["PRESENCE_GD"];
            row["J_FERIE"] = reader["J_FERIE"];
            row["BNUIT"] = reader["BNUIT"];
            row["BCOMPTE_381"] = reader["BCOMPTE_381"];
            row["DELTA_REF_THEO"] = reader["DELTA_REF_THEO"];
            row["NTAUX_TPS_THEO_RATIO"] = reader["NTAUX_TPS_THEO_RATIO"];
            row["NTPS_RECUP_ID"] = reader["NTPS_RECUP_ID"];

            row.AcceptChanges();
          }

        }
        RefreshData();

        MessageBox.Show($"Mise à jour de la journée {DrReading.Field<DateTime>("DATE_JOUR").ToString("dd/MM/yyyy")} effectuée avec succès", "Message", MessageBoxButtons.OK, MessageBoxIcon.Information);

      }

    }

    private void RItem_VISA_ButtonClick(object sender, DevExpress.XtraEditors.Controls.ButtonPressedEventArgs e)
    {

      GridView oView = (GridView)GCSuiviTpsTravDetail.FocusedView;
      if (oView.FocusedRowHandle > -1)
      {
        DataRow DrReading = oView.GetDataRow(oView.FocusedRowHandle);

        //on recherche le nom du tech
        List<DataRow> foundTech = dtListeTechs.Select($"NPERNUM ={DrReading["NPERNUM"]}").ToList();


        string NomTech = "";
        foreach (DataRow Dr in foundTech)
        {

          NomTech = Dr["VTECHNOM"].ToString();

        }

        CTPS_RECUP_TECH oTpsRecupDetail = new CTPS_RECUP_TECH(DrReading.Field<int>("NTPS_RECUP_ID"));
        if (DrReading.Field<int>("NTPS_RECUP_ID") == 0)
        {
          oTpsRecupDetail.VTECHNOM = NomTech;
          oTpsRecupDetail.NPERNUM = (int)DrReading["NPERNUM"];
        }

        //on mets à jour le temps de recup que s'il n'y a pas de VISA
        if (oTpsRecupDetail.DATE_AJOUT_VISA == null) oTpsRecupDetail.NSOLDE_SEC_BASE = DrReading.Field<int>("TOT_SEM_SEC_DELTA_REF_THEO") < 0 ? 0 : DrReading.Field<int>("TOT_SEM_SEC_DELTA_REF_THEO");

        using (frmSuiviTempsTravailTech_VISA f = new frmSuiviTempsTravailTech_VISA(oTpsRecupDetail))
        {
          f.Text = $"Validation VISA - {NomTech} - S{DrReading.Field<int>("NUM_SEMAINE")}-({GetPeriodeSemaine((int)DrReading.Field<int>("NUM_SEMAINE"), (int)DrReading.Field<int>("NUM_ANNEE")).ToString()})";
          f.ShowDialog();
          switch (f.ValidVisa)
          {

            case "ADD_VISA":

              //on mets jour à jour la table TSUIVI_TPS_TRAJET
              DataRow[] foundTechSem = dtListeSuiviTpsTrav_DET.Select($"NPERNUM ={DrReading["NPERNUM"]} AND NUM_SEMAINE_ISO = {DrReading["NUM_SEMAINE_ISO"]} AND NUM_ANNEE = {DrReading["NUM_ANNEE"]}");

              foreach (DataRow Dr in foundTechSem)
              {
                Dr["NTPS_RECUP_ID"] = (int)oTpsRecupDetail.NTPS_RECUP_ID;
                UpdateRowDetail_NTPS_RECUP_ID((int)Dr["NID_SUIVI_TPS_TRAJET"], (int)oTpsRecupDetail.NTPS_RECUP_ID);
                Dr.AcceptChanges();
              }

              RefreshData();
              break;

            case "DEL_VISA":

              //on mets jour à jour la table TSUIVI_TPS_TRAJET
              DataRow[] foundTechSem_delete = dtListeSuiviTpsTrav_DET.Select($"NTPS_RECUP_ID ={oTpsRecupDetail.NTPS_RECUP_ID}");

              foreach (DataRow Dr in foundTechSem_delete)
              {
                Dr["NTPS_RECUP_ID"] = 0;
                UpdateRowDetail_NTPS_RECUP_ID((int)Dr["NID_SUIVI_TPS_TRAJET"], 0);
                Dr.AcceptChanges();
              }

              RefreshData();
              break;

            default:
              break;
          }
        }

        //CTPS_RECUP_TECH oCTPS_RECUP_TECH = new CTPS_RECUP_TECH();

      }
    }

    private void UpdateRowDetail_NTPS_RECUP_ID(int P_NID_SUIVI_TPS_TRAJET, int P_NTPS_RECUP_ID)
    {

      using (SqlCommand cmd = new SqlCommand("[api_sp_Temps_Recup_Update_NTPS_RECUP_ID]", MozartDatabase.cnxMozart))
      {
        cmd.CommandType = CommandType.StoredProcedure;
        SqlCommandBuilder.DeriveParameters(cmd);    // liste des paramètres

        //  liste des paramètres
        cmd.Parameters["@P_NID_SUIVI_TPS_TRAJET"].Value = P_NID_SUIVI_TPS_TRAJET;
        cmd.Parameters["@P_NTPS_RECUP_ID"].Value = P_NTPS_RECUP_ID;
        cmd.ExecuteNonQuery();
      }


    }

    private void RItem_HL_JOUR_GPS_OpenLink(object sender, DevExpress.XtraEditors.Controls.OpenLinkEventArgs e)
    {

      GridView oView = (GridView)GCSuiviTpsTravDetail.FocusedView;
      if (oView.FocusedRowHandle > -1)
      {
        DataRow DrReading = ((GridView)GCSuiviTpsTravDetail.FocusedView).GetDataRow(oView.FocusedRowHandle);

        string Adresse = "https://maps.emalec.com/TrajetTechnicienJourDepArrSuiviTpsTrav.asp?BASE=MULTI&APP=" + MozartParams.NomSociete + "&TYPE=GEOLOC&INDEX=0&NOM="
                            + HttpUtility.UrlEncode(Strings.Replace(DrReading.Field<string>("VPERNOM") + " " + DrReading.Field<string>("VPERPRE"), "'", "''"), System.Text.UnicodeEncoding.UTF8) + "&JOUR=" + DrReading.Field<DateTime>("DATE_JOUR").ToShortDateString() + "&NPERNUM=" + DrReading.Field<int>("NPERNUM").ToString();

        //Process.Start("msedge.exe", Adresse);
        new frmBrowser
        {
          msStartingAddress = Adresse,
          mstrType = "GEOLOC",
          minpernum = DrReading.Field<int>("NPERNUM"),
          mddate = (DateTime)DrReading["DATE_JOUR"]
        }.ShowDialog();

      }

    }

    private void GVSuiviTpsTravDetail_RowCellStyle(object sender, RowCellStyleEventArgs e)
    {

      GridView view = sender as GridView;

      if (e.Column.FieldName == "DATE_JOUR")
      {
        DataRow DrReading = view.GetDataRow(e.RowHandle);

        if ((int)DrReading["J_FERIE"] == 1)
        {
          e.Appearance.BackColor = view.PaintAppearance.FocusedCell.BackColor = Color.Red;
        }

      }

    }

    private void GV_SYN_SEMAINE_RowCellStyle(object sender, RowCellStyleEventArgs e)
    {
      GridView view = sender as GridView;

      if (e.Column.FieldName == "TOT_SEM_SEC_DELTA_REF_THEO")
      {
        DataRow DrReading = view.GetDataRow(e.RowHandle);

        if ((bool)DrReading["TOT_SEM_SEC_DELTA_REF_THEO_FORCE_EXIST"] == true)
        {
          e.Appearance.BackColor = view.PaintAppearance.FocusedCell.BackColor = Color.Orange;
        }
        else
        {
          e.Appearance.BackColor = oColorFocusedCell_Default;
          view.PaintAppearance.FocusedCell.BackColor = oColorFocusedCell_Default;
        }

      }
      else
      {
        e.Appearance.BackColor = oColorFocusedCell_Default;
        view.PaintAppearance.FocusedCell.BackColor = oColorFocusedCell_Default;
      }
    }

    private void RItem_VISA_Compensation_ButtonClick(object sender, DevExpress.XtraEditors.Controls.ButtonPressedEventArgs e)
    {
      GridView oView = (GridView)GCSuiviTpsTravDetail.FocusedView;
      if (oView.FocusedRowHandle > -1)
      {
        DataRow DrReading = ((GridView)GCSuiviTpsTravDetail.FocusedView).GetDataRow(oView.FocusedRowHandle);

        if (DrReading == null) return;

        //MessageBox.Show($"NID_SUIVI_TPS_TRAJET = {DrReading.Field<int>("NID_SUIVI_TPS_TRAJET").ToString()}");
        if (MessageBox.Show($"Voulez-vous valider ce montant de compensation {DrReading["NCOMPENSATION_INDEM"]:C0} pour la journée du {DrReading["DATE_JOUR"]:dd/MM/yyyy}", "Confirmation", MessageBoxButtons.YesNoCancel, MessageBoxIcon.Question) != DialogResult.Yes) return;

        DateTime d_VISA_COMPENSATION = DateTime.Now;

        //execution de la requete de maj des data
        SqlCommand sqlupdate = new SqlCommand("[api_sp_SuiviTempsTrajet_Save_Compensa_Idem]", MozartDatabase.cnxMozart);
        sqlupdate.CommandType = CommandType.StoredProcedure;
        SqlCommandBuilder.DeriveParameters(sqlupdate);    // liste des paramètres
        sqlupdate.Parameters["@P_NID_SUIVI_TPS_TRAJET"].Value = DrReading["NID_SUIVI_TPS_TRAJET"];
        sqlupdate.Parameters["@P_NCOMPENSATION_INDEM"].Value = DrReading["NCOMPENSATION_INDEM"];
        sqlupdate.Parameters["@P_DCOMPENSATION_VISA"].Value = d_VISA_COMPENSATION;

        sqlupdate.ExecuteNonQuery();

        DataRow[] result = dtListeSuiviTpsTrav_DET.Select($"NID_SUIVI_TPS_TRAJET = {DrReading["NID_SUIVI_TPS_TRAJET"]}");

        foreach (DataRow row in result)
        {
          row["NCOMPENSATION_INDEM"] = DrReading["NCOMPENSATION_INDEM"];
          row["DCOMPENSATION_VISA"] = d_VISA_COMPENSATION;
          row["VCOMPENSATION_VISA"] = MozartLib.MozartParams.strUID;

          row.AcceptChanges();
        }
        RefreshData();
        MessageBox.Show($"Validation de la compensation {DrReading["NCOMPENSATION_INDEM"]:C0} pour la journée du {DrReading["DATE_JOUR"]:dd/MM/yyyy} effectuée avec succès", "Message", MessageBoxButtons.OK, MessageBoxIcon.Information);
      }
    }

    private void BtnExportXLSX_Click(object sender, EventArgs e)
    {   

      if(GCSuiviTpsTravDetail.FocusedView.Name != "GVSuiviTpsTravDetail")
      {
        MessageBox.Show("Il faut sélectionner une journée d'un technicien !", "Erreur", MessageBoxButtons.OK, MessageBoxIcon.Error);
        return;
      }

      string filename = "Export_Stat_RH_SuiviTps_Trajet_" + DateTime.Now.Day.ToString() + DateTime.Now.Month.ToString() + DateTime.Now.Year.ToString();

      SFD.FileName = filename;

      if (SFD.ShowDialog() == DialogResult.OK)
      {
        if (SFD.FileName != "")
        {
          XlsxExportOptionsEx exportOptions = new XlsxExportOptionsEx();
          exportOptions.ExportType = DevExpress.Export.ExportType.WYSIWYG;
          exportOptions.TextExportMode = TextExportMode.Text;
          GCSuiviTpsTravDetail.ExportToXlsx(SFD.FileName, exportOptions);
        }
      }
    }

    private void GVSuiviTpsTravDetail_CustomRowCellEdit(object sender, CustomRowCellEditEventArgs e)
    {
      GridView view = sender as GridView;
      if (e.Column.Name == "BCol_BTN_VISA")
      {
       // DateTime? dVISA_COMPENSATION = (DateTime?)(view.GetDataRow(e.RowHandle)["DCOMPENSATION_VISA"] == DBNull.Value ? DBNull.Value : view.GetDataRow(e.RowHandle)["DCOMPENSATION_VISA"]);
        
        if (view.GetDataRow(e.RowHandle)["DCOMPENSATION_VISA"] == DBNull.Value)
        {
          e.RepositoryItem = RItem_VISA_Compensation;
        }
        else
        {
          e.RepositoryItem = RItem_VISA_Compensation_Del;
        }

      }
     
    }

    private void RItem_VISA_Compensation_Del_ButtonClick(object sender, DevExpress.XtraEditors.Controls.ButtonPressedEventArgs e)
    {

      GridView oView = (GridView)GCSuiviTpsTravDetail.FocusedView;
      if (oView.FocusedRowHandle > -1)
      {
        DataRow DrReading = ((GridView)GCSuiviTpsTravDetail.FocusedView).GetDataRow(oView.FocusedRowHandle);

        if (DrReading == null) return;

        //recherche si visa deja déposé
        if (dtListeSuiviTpsTrav_DET.Select($"NID_SUIVI_TPS_TRAJET = {DrReading["NID_SUIVI_TPS_TRAJET"]} AND DCOMPENSATION_VISA IS NOT NULL").ToList().Count() > 0)
        {
          switch (MessageBox.Show($"Voulez-vous supprimer la validation de compensation?", "Confirmation", MessageBoxButtons.YesNoCancel, MessageBoxIcon.Question))
          {
            case DialogResult.Yes:

              //execution de la requete de maj des data
              SqlCommand sqldelete = new SqlCommand("[api_sp_SuiviTempsTrajet_Del_Compensa_Idem]", MozartDatabase.cnxMozart);
              sqldelete.CommandType = CommandType.StoredProcedure;
              SqlCommandBuilder.DeriveParameters(sqldelete);    // liste des paramètres
              sqldelete.Parameters["@P_NID_SUIVI_TPS_TRAJET"].Value = DrReading["NID_SUIVI_TPS_TRAJET"];

              sqldelete.ExecuteNonQuery();

              DataRow[] result_del = dtListeSuiviTpsTrav_DET.Select($"NID_SUIVI_TPS_TRAJET = {DrReading["NID_SUIVI_TPS_TRAJET"]}");

              foreach (DataRow row in result_del)
              {
                row["DCOMPENSATION_VISA"] = DBNull.Value;
                row["VCOMPENSATION_VISA"] = "";

                row.AcceptChanges();
              }
              RefreshData();
              MessageBox.Show($"Suppression de la validation pour la compensation {DrReading["NCOMPENSATION_INDEM"]:C0} de la journée du {DrReading["DATE_JOUR"]:dd/MM/yyyy} effectuée avec succès", "Message", MessageBoxButtons.OK, MessageBoxIcon.Information);
              break;
            default:
              break;

          }
          return;
        }
      }
    }
  }
}

public class CSUIV_TPS_TRAV_COL_GEST
{

  string _VFIELDNAME;
  string _VFIELDNAME_MAN;
  string _VFIELDNAME_MOZARIS;  

    public string VFIELDNAME
  {
    get => _VFIELDNAME;
  }
  public string VFIELDNAME_MAN
  {
    get => _VFIELDNAME_MAN;
  }
  public string VFIELDNAME_MOZARIS
  {
    get => _VFIELDNAME_MOZARIS;
  }

    public CSUIV_TPS_TRAV_COL_GEST(string P_VFIELDNAME, string P_VFIELDNAME_MAN, string P_VFIELDNAME_MOZARIS)
  {
    _VFIELDNAME = P_VFIELDNAME;
    _VFIELDNAME_MAN = P_VFIELDNAME_MAN;
    _VFIELDNAME_MOZARIS = P_VFIELDNAME_MOZARIS;
  }

}