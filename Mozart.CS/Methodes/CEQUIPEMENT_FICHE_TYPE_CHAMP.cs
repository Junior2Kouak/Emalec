using MozartNet;
using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MozartCS
{
    class CEQUIPEMENT_FICHE_TYPE_CHAMP
    {              

        public int NID_EQUIPEMENT_FICHE_TYPE_CHAMP {  get; set; }
        public string VEQUIPEMENT_FICHE_TYPE_CHAMP_LIB { get; set; }
        public bool BEQUIPEMENT_FICHE_TYPE_CHAMP_REF_LIST_EXIST { get; set; }

        public static List<int> LoadListeTypeChampInListe()
        {
            DataTable dt = new DataTable();

            ModuleData.LoadData(dt, $"EXEC [api_sp_Equipement_Admin_Liste_TypeChamp]");

            List<CEQUIPEMENT_FICHE_TYPE_CHAMP> listTypeChamp = new List<CEQUIPEMENT_FICHE_TYPE_CHAMP>();
            listTypeChamp = (from DataRow dr in dt.Rows
                             where Convert.ToBoolean(dr["BEQUIPEMENT_FICHE_TYPE_CHAMP_REF_LIST_EXIST"]) == true
                             select new CEQUIPEMENT_FICHE_TYPE_CHAMP()
                           {
                               NID_EQUIPEMENT_FICHE_TYPE_CHAMP = Convert.ToInt32(dr["NID_EQUIPEMENT_FICHE_TYPE_CHAMP"]),
                               VEQUIPEMENT_FICHE_TYPE_CHAMP_LIB = dr["VEQUIPEMENT_FICHE_TYPE_CHAMP_LIB"].ToString(),
                               BEQUIPEMENT_FICHE_TYPE_CHAMP_REF_LIST_EXIST = Convert.ToBoolean(dr["BEQUIPEMENT_FICHE_TYPE_CHAMP_REF_LIST_EXIST"])
                           }).ToList();

            return listTypeChamp.Select(x => x.NID_EQUIPEMENT_FICHE_TYPE_CHAMP).ToList();

        }

        public static List<int> ListTypeChampObligatoire()
        {

            List<Int32> List_TypeChamp = new List<Int32>() { 10, 11 };   //type champ = type et localisation : champ utilisé pour etre affiche la tree list d EM ASSET
            return List_TypeChamp;

        }

        public static string GetLibelle(int p_ntypeChamp)
        {

            string outResult = "";

            SqlDataReader sqldr = ModuleData.ExecuteReader($"EXEC [api_sp_Equipement_Admin_TypeChamp_GetLibelle] {p_ntypeChamp}");

            if(sqldr.HasRows == true)
            {
                sqldr.Read();
                outResult = sqldr["VEQUIPEMENT_FICHE_TYPE_CHAMP_LIB"].ToString();
            }
            sqldr.Close();


            return outResult;

        }

    }
}
