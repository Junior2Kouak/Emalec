using DevExpress.XtraCharts;
using MozartLib;
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
    class CEQUIPEMENT_CHAPITRE
    {
        public int NID_EQUIPEMENT_FICHE_CHAP;
        public int NID_EQUIPEMENT_FICHE;       
        public int NEQUIPEMENT_FICHE_CHAP_ORDER_AFFICH;
        public string VEQUIPEMENT_FICHE_CHAP_LIB;
        public bool BEQUIPEMENT_FICHE_CHAP_ACTIF;
        public Int32? NQUIMOD;
        public DateTime? DQUIMOD;
        public Int32? NQUICREE;
        public DateTime? DQUICREE;

        public CEQUIPEMENT_CHAPITRE(int C_NID_EQUIPEMENT_FICHE_CHAP, int C_NID_EQUIPEMENT_FICHE)
        {

            NID_EQUIPEMENT_FICHE_CHAP = C_NID_EQUIPEMENT_FICHE_CHAP;
            NID_EQUIPEMENT_FICHE = C_NID_EQUIPEMENT_FICHE;
            LoadData();
        }


        public void LoadData()
        {

            using (SqlDataReader sqldr = ModuleData.ExecuteReader($"EXEC [api_sp_Equipement_Admin_Fiche_Chap_Detail] {NID_EQUIPEMENT_FICHE_CHAP}, {NID_EQUIPEMENT_FICHE}"))
            {
                sqldr.Read();
                NID_EQUIPEMENT_FICHE_CHAP = (Int32)sqldr["NID_EQUIPEMENT_FICHE_CHAP"];			  
                NID_EQUIPEMENT_FICHE = (Int32)sqldr["NID_EQUIPEMENT_FICHE"];
                NEQUIPEMENT_FICHE_CHAP_ORDER_AFFICH = (int)sqldr["NEQUIPEMENT_FICHE_CHAP_ORDER_AFFICH"];
                VEQUIPEMENT_FICHE_CHAP_LIB = (string)sqldr["VEQUIPEMENT_FICHE_CHAP_LIB"];
                BEQUIPEMENT_FICHE_CHAP_ACTIF = (bool)sqldr["BEQUIPEMENT_FICHE_CHAP_ACTIF"];
                NQUIMOD = sqldr["NQUIMOD"] == DBNull.Value ? null : (Int32?)sqldr["NQUIMOD"];
                DQUIMOD = sqldr["DQUIMOD"] == DBNull.Value ? null : (DateTime?)sqldr["DQUIMOD"];
                NQUICREE = sqldr["NQUICREE"] == DBNull.Value ? null : (Int32?)sqldr["NQUICREE"];
                DQUICREE = sqldr["DQUICREE"] == DBNull.Value ? null : (DateTime?)sqldr["DQUICREE"];

            }
            

        }

        //public void Refresh()
        //{

        //    //on met à jour le nb d equipement par contrat
        //    foreach (DataRow DrUPdate in _dt_Liste_Niv0.Rows)
        //    {

        //        DataRow DrLv0 = _dt_Liste_Niv0.Select($"NTYPECONTRAT = {DrUPdate["NTYPECONTRAT"]}").FirstOrDefault();
        //        if (DrLv0 == null) break;

        //        if (_dt_Liste_Niv1.Select($"NTYPECONTRAT = {DrUPdate["NTYPECONTRAT"]}").Count() == 0)
        //        {
        //            DrLv0["NB_EQUIP"] = 0;
        //        }
        //        else
        //        {
        //            DrLv0["NB_EQUIP"] = _dt_Liste_Niv1.GetChanges(DataRowState.Added | DataRowState.Modified | DataRowState.Unchanged).Select($"NTYPECONTRAT = {DrUPdate["NTYPECONTRAT"]}").Count();

        //        }


        //    }

        //}

        public static Boolean ChapitreAffected(int P_NID_EQUIPEMENT_FICHE_CHAP)
        {

            int? iCpt = ModuleData.ExecuteScalarInt($"EXEC [api_sp_Equipement_Admin_Fiche_Chap_Exists] {P_NID_EQUIPEMENT_FICHE_CHAP}");
            
            if(iCpt == null) return false;
            if (iCpt > 0) return true;
            return false;

        }

        public static int Save(int P_NID_EQUIPEMENT_FICHE_CHAP, int P_NID_EQUIPEMENT_FICHE, int P_NEQUIPEMENT_FICHE_CHAP_ORDER_AFFICH, string P_VEQUIPEMENT_FICHE_CHAP_LIB, bool P_BEQUIPEMENT_FICHE_CHAP_ACTIF)
        {


            using( SqlCommand sqlSave = new SqlCommand("[api_sp_Equipement_Admin_Fiche_Chap_Save]", MozartDatabase.cnxMozart))
            {
                sqlSave.CommandType = CommandType.StoredProcedure;
                sqlSave.Parameters.AddWithValue("@P_NID_EQUIPEMENT_FICHE_CHAP", P_NID_EQUIPEMENT_FICHE_CHAP);
                sqlSave.Parameters.AddWithValue("@P_NID_EQUIPEMENT_FICHE", P_NID_EQUIPEMENT_FICHE);
                sqlSave.Parameters.AddWithValue("@P_NEQUIPEMENT_FICHE_CHAP_ORDER_AFFICH", P_NEQUIPEMENT_FICHE_CHAP_ORDER_AFFICH);
                sqlSave.Parameters.AddWithValue("@P_VEQUIPEMENT_FICHE_CHAP_LIB", P_VEQUIPEMENT_FICHE_CHAP_LIB);
                sqlSave.Parameters.AddWithValue("@P_BEQUIPEMENT_FICHE_CHAP_ACTIF", P_BEQUIPEMENT_FICHE_CHAP_ACTIF);

                sqlSave.Parameters["@P_NID_EQUIPEMENT_FICHE_CHAP"].Direction = ParameterDirection.InputOutput;

                sqlSave.ExecuteNonQuery();

                return (int)sqlSave.Parameters["@P_NID_EQUIPEMENT_FICHE_CHAP"].Value;

            }           

        }

        public static void RefreshOrderAffichage(int P_NID_EQUIPEMENT_FICHE)
        {
            using (SqlCommand sqlSave = new SqlCommand("[api_sp_Equipement_Admin_Fiche_Item_Refresh_Order_Affichage]", MozartDatabase.cnxMozart))
            {
                sqlSave.CommandType = CommandType.StoredProcedure;                
                sqlSave.Parameters.AddWithValue("@P_NID_EQUIPEMENT_FICHE", P_NID_EQUIPEMENT_FICHE);              

                sqlSave.ExecuteNonQuery();                

            }

        }

        public static string GetChapterName(int NID_EQUIPEMENT_FICHE_CHAP)
        {

            string ReturnResult = "";

            using (SqlDataReader sqldr = ModuleData.ExecuteReader($"EXEC [api_sp_Equipement_Admin_Fiche_Chap_Detail] {NID_EQUIPEMENT_FICHE_CHAP}, 0"))
            {
                sqldr.Read();              
                ReturnResult = (string)sqldr["VEQUIPEMENT_FICHE_CHAP_LIB"];   
            }

            return ReturnResult;
        }

    }
}
