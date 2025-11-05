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
    class CEQUIPEMENT_LISTPARENT
    {
        public int NID_EQUIPEMENT_FICHE_LIST_PARENT;
        public int NID_EQUIPEMENT_FICHE_TYPE_CHAMP;       
        public string VEQUIPEMENT_FICHE_LIST_PARENT_LIB;
        public bool BEQUIPEMENT_FICHE_LIST_PARENT_ACTIF;
        public Int32? NQUIMOD;
        public DateTime? DQUIMOD;
        public Int32? NQUICREE;
        public DateTime? DQUICREE;
        public string VSOCIETE;                
        public DataTable dtListeItems { get; set; }

        public CEQUIPEMENT_LISTPARENT(Int32 C_NID_EQUIPEMENT_FICHE_LIST_PARENT, Int32 C_NID_EQUIPEMENT_FICHE_TYPE_CHAMP)
        {

            NID_EQUIPEMENT_FICHE_LIST_PARENT = C_NID_EQUIPEMENT_FICHE_LIST_PARENT;
            NID_EQUIPEMENT_FICHE_TYPE_CHAMP = C_NID_EQUIPEMENT_FICHE_TYPE_CHAMP;
            LoadData();
        }


        public void LoadData()
        {

            using (SqlDataReader sqldr = ModuleData.ExecuteReader($"EXEC [api_sp_Equipement_Admin_Fiche_ListParent_Detail] {NID_EQUIPEMENT_FICHE_LIST_PARENT}, {NID_EQUIPEMENT_FICHE_TYPE_CHAMP}"))
            {
                sqldr.Read();
                NID_EQUIPEMENT_FICHE_LIST_PARENT = (Int32)sqldr["NID_EQUIPEMENT_FICHE_LIST_PARENT"];
                NID_EQUIPEMENT_FICHE_TYPE_CHAMP = (Int32)sqldr["NID_EQUIPEMENT_FICHE_TYPE_CHAMP"];               
                VEQUIPEMENT_FICHE_LIST_PARENT_LIB = (string)sqldr["VEQUIPEMENT_FICHE_LIST_PARENT_LIB"];
                BEQUIPEMENT_FICHE_LIST_PARENT_ACTIF = (bool)sqldr["BEQUIPEMENT_FICHE_LIST_PARENT_ACTIF"];
                NQUIMOD = sqldr["NQUIMOD"] == DBNull.Value ? null : (Int32?)sqldr["NQUIMOD"];
                DQUIMOD = sqldr["DQUIMOD"] == DBNull.Value ? null : (DateTime?)sqldr["DQUIMOD"];
                NQUICREE = sqldr["NQUICREE"] == DBNull.Value ? null : (Int32?)sqldr["NQUICREE"];
                DQUICREE = sqldr["DQUICREE"] == DBNull.Value ? null : (DateTime?)sqldr["DQUICREE"];
                VSOCIETE = (string)sqldr["VSOCIETE"];

            }

            dtListeItems = new DataTable();

            SqlCommand cmdLoader = new SqlCommand("[api_sp_Equipement_Admin_Fiche_ListParent_Item_Liste]", MozartDatabase.cnxMozart);
            cmdLoader.CommandType = CommandType.StoredProcedure;
            cmdLoader.Parameters.AddWithValue("@P_NID_EQUIPEMENT_LIST_PARENT", NID_EQUIPEMENT_FICHE_LIST_PARENT);

            // Execute the command and read the results
            dtListeItems.Load(cmdLoader.ExecuteReader());

        }      
        public void Save()
        {


            using( SqlCommand sqlSave = new SqlCommand("[api_sp_Equipement_Admin_Fiche_ListParent_Save]", MozartDatabase.cnxMozart))
            {
                sqlSave.CommandType = CommandType.StoredProcedure;
                sqlSave.Parameters.AddWithValue("@P_NID_EQUIPEMENT_FICHE_LIST_PARENT", NID_EQUIPEMENT_FICHE_LIST_PARENT);
                sqlSave.Parameters.AddWithValue("@P_NID_EQUIPEMENT_FICHE_TYPE_CHAMP", NID_EQUIPEMENT_FICHE_TYPE_CHAMP);                
                sqlSave.Parameters.AddWithValue("@P_VEQUIPEMENT_FICHE_LIST_PARENT_LIB", VEQUIPEMENT_FICHE_LIST_PARENT_LIB);
                sqlSave.Parameters.AddWithValue("@P_BEQUIPEMENT_FICHE_LIST_PARENT_ACTIF", BEQUIPEMENT_FICHE_LIST_PARENT_ACTIF);

                sqlSave.Parameters["@P_NID_EQUIPEMENT_FICHE_LIST_PARENT"].Direction = ParameterDirection.InputOutput;

                sqlSave.ExecuteNonQuery();

                NID_EQUIPEMENT_FICHE_LIST_PARENT = (Int32)sqlSave.Parameters["@P_NID_EQUIPEMENT_FICHE_LIST_PARENT"].Value;

                if(dtListeItems == null) return;                                

                if (dtListeItems.GetChanges(DataRowState.Added | DataRowState.Modified) != null)
                { 
                    foreach (DataRow drSave in dtListeItems.GetChanges(DataRowState.Added | DataRowState.Modified).Rows)
                    {
                        CEQUIPEMENT_LISTPARENT_ITEM.Save((int)drSave["NIDEQUIPEMENT_FICHE_LIST_PARENT_ITEM"], NID_EQUIPEMENT_FICHE_LIST_PARENT, (string)drSave["VEQUIPEMENT_FICHE_LIST_PARENT_ITEM_LIB"], (bool)drSave["BEQUIPEMENT_FICHE_LIST_PARENT_ITEM_ACTIF"]);
                      
                    }
                }               
              
                if (dtListeItems.GetChanges(DataRowState.Deleted) != null)
                {
                    foreach (DataRow drDel in dtListeItems.GetChanges(DataRowState.Deleted).Rows)
                    {
                        CEQUIPEMENT_LISTPARENT_ITEM.Delete((int)drDel["NIDEQUIPEMENT_FICHE_LIST_PARENT_ITEM", DataRowVersion.Original]);

                    }
                }
                
                dtListeItems.AcceptChanges();

            }           

        }
    }
}
