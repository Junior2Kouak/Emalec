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
    class CEQUIPEMENT_FICHE
    {
        public Int32 NID_EQUIPEMENT_FICHE;       
        public string VEQUIPEMENT_FICHE_LIB;
        public bool BEQUIPEMENT_FICHE_ACTIF;
        public Int32? NQUIMOD;
        public DateTime? DQUIMOD;
        public Int32? NQUICREE;
        public DateTime? DQUICREE;
        public string VSOCIETE;
        public string VINFOCOMPLEMENT;

        public DataTable dtListeItems = new DataTable(); 

        public CEQUIPEMENT_FICHE(Int32 C_NID_EQUIPEMENT_FICHE)
        {

            NID_EQUIPEMENT_FICHE = C_NID_EQUIPEMENT_FICHE;
            LoadData();
        }


        public void LoadData()
        {

            using (SqlDataReader sqldr = ModuleData.ExecuteReader($"EXEC [api_sp_Equipement_Admin_Fiche_Detail] {NID_EQUIPEMENT_FICHE}"))
            {
                sqldr.Read();
                NID_EQUIPEMENT_FICHE = (Int32)sqldr["NID_EQUIPEMENT_FICHE"];			  
			    VEQUIPEMENT_FICHE_LIB= (string)sqldr["VEQUIPEMENT_FICHE_LIB"];
			    BEQUIPEMENT_FICHE_ACTIF= (bool)sqldr["BEQUIPEMENT_FICHE_ACTIF"];    
			    NQUIMOD= sqldr["NQUIMOD"] == DBNull.Value ? null : (Int32?)sqldr["NQUIMOD"];
                DQUIMOD = sqldr["DQUIMOD"] == DBNull.Value ? null : (DateTime?)sqldr["DQUIMOD"];
                NQUICREE = sqldr["NQUICREE"] == DBNull.Value ? null : (Int32?)sqldr["NQUICREE"];
                DQUICREE = sqldr["DQUICREE"] == DBNull.Value ? null : (DateTime?)sqldr["DQUICREE"];

                VSOCIETE = (string)sqldr["VSOCIETE"];
                VINFOCOMPLEMENT = (string)sqldr["VINFOCOMPLEMENT"];
            }
                       
            dtListeItems.Load(ModuleData.ExecuteReader($"EXEC [api_sp_Equipement_Admin_Fiche_Item_Liste] {NID_EQUIPEMENT_FICHE}"));
                      

            foreach (DataColumn Col in dtListeItems.Columns)
            {
                Col.ReadOnly = false;
            }

        }              

        public void Save()
        {


            using( SqlCommand sqlSave = new SqlCommand("[api_sp_Equipement_Admin_Fiche_Save]", MozartDatabase.cnxMozart))
            {
                sqlSave.CommandType = CommandType.StoredProcedure;
                sqlSave.Parameters.AddWithValue("@P_NID_EQUIPEMENT_FICHE", NID_EQUIPEMENT_FICHE);
                sqlSave.Parameters.AddWithValue("@P_VEQUIPEMENT_FICHE_LIB", VEQUIPEMENT_FICHE_LIB);
                sqlSave.Parameters.AddWithValue("@P_BEQUIPEMENT_FICHE_ACTIF", BEQUIPEMENT_FICHE_ACTIF);
                sqlSave.Parameters.AddWithValue("@P_VSOCIETE", VSOCIETE);
                sqlSave.Parameters.AddWithValue("@P_VINFOCOMPLEMENT", VINFOCOMPLEMENT);

                sqlSave.Parameters["@P_NID_EQUIPEMENT_FICHE"].Direction = ParameterDirection.InputOutput;

                sqlSave.ExecuteNonQuery();

                NID_EQUIPEMENT_FICHE = (Int32)sqlSave.Parameters["@P_NID_EQUIPEMENT_FICHE"].Value;

            }

            if (NID_EQUIPEMENT_FICHE == 0) { return; };

            if(dtListeItems.GetChanges(DataRowState.Added | DataRowState.Modified | DataRowState.Unchanged) != null)

            {
                foreach (DataRow oDrSave in dtListeItems.GetChanges(DataRowState.Added | DataRowState.Modified | DataRowState.Unchanged).Rows)
                {
                    using (SqlCommand sqlSave = new SqlCommand("[api_sp_Equipement_Admin_Fiche_Item_Save]", MozartDatabase.cnxMozart))
                    {

                        Console.WriteLine($"{oDrSave["VEQUIPEMENT_FICHE_ITEM_LIB"]} - {oDrSave["NEQUIPEMENT_FICHE_ITEM_ORDER"]}");

                        sqlSave.CommandType = CommandType.StoredProcedure;
                        sqlSave.Parameters.AddWithValue("@P_NID_EQUIPEMENT_FICHE_ITEM", oDrSave["NID_EQUIPEMENT_FICHE_ITEM"]);
                        sqlSave.Parameters.AddWithValue("@P_NID_EQUIPEMENT_FICHE_CHAP", oDrSave["NID_EQUIPEMENT_FICHE_CHAP"]);
                        sqlSave.Parameters.AddWithValue("@P_NID_EQUIPEMENT_FICHE_TYPE_CHAMP", oDrSave["NID_EQUIPEMENT_FICHE_TYPE_CHAMP"]);
                        sqlSave.Parameters.AddWithValue("@P_NID_EQUIPEMENT_FICHE_LIST_PARENT", oDrSave["NID_EQUIPEMENT_FICHE_LIST_PARENT"]);
                        sqlSave.Parameters.AddWithValue("@P_VEQUIPEMENT_FICHE_ITEM_LIB", oDrSave["VEQUIPEMENT_FICHE_ITEM_LIB"]);
                        sqlSave.Parameters.AddWithValue("@P_NEQUIPEMENT_FICHE_ITEM_ORDER", oDrSave["NEQUIPEMENT_FICHE_ITEM_ORDER"]);
                        sqlSave.Parameters.AddWithValue("@P_BEQUIPEMENT_FICHE_ITEM_ACTIF", oDrSave["BEQUIPEMENT_FICHE_ITEM_ACTIF"]);
                        sqlSave.Parameters.AddWithValue("@P_BEQUIPEMENT_FICHE_ITEM_OBLIG", oDrSave["BEQUIPEMENT_FICHE_ITEM_OBLIG"]);
                        
                        sqlSave.Parameters.AddWithValue("@P_NID_EQUIPEMENT_FICHE", NID_EQUIPEMENT_FICHE);

                        sqlSave.ExecuteNonQuery();
                    }
                }
            }

            //delete des items
            if (dtListeItems.GetChanges(DataRowState.Deleted) != null)
            {
                foreach (DataRow oDrSave in dtListeItems.GetChanges(DataRowState.Deleted).Rows)
                {
                    using (SqlCommand sqlSave = new SqlCommand("[api_sp_Equipement_Admin_Fiche_Item_Delete]", MozartDatabase.cnxMozart))
                    {
                        sqlSave.CommandType = CommandType.StoredProcedure;
                        sqlSave.Parameters.AddWithValue("@P_NID_EQUIPEMENT_FICHE_ITEM", oDrSave["NID_EQUIPEMENT_FICHE_ITEM", DataRowVersion.Original]);

                        sqlSave.ExecuteNonQuery();

                    }
                }
            }
            dtListeItems.AcceptChanges();

            MozartDatabase.ExecuteNonQuery($"EXEC [api_sp_Equipement_Admin_Fiche_Item_Refresh_Order_Affichage] {NID_EQUIPEMENT_FICHE}");


        }
    }
}
