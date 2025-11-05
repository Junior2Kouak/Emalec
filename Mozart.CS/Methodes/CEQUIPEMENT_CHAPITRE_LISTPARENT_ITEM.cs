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
    class CEQUIPEMENT_LISTPARENT_ITEM
    {
        //public int NIDEQUIPEMENT_FICHE_LIST_ITEM;
        //public int NID_EQUIPEMENT_LIST_PARENT;       
        //public string VEQUIPEMENT_FICHE_LIST_ITEM_LIB;
        //public bool BEQUIPEMENT_FICHE_LIST_ITEM_ACTIF;
        //public Int32? NQUIMOD;
        //public DateTime? DQUIMOD;
        //public Int32? NQUICREE;
        //public DateTime? DQUICREE;         

        public static void Save(int NIDEQUIPEMENT_FICHE_LIST_PARENT_ITEM, int NID_EQUIPEMENT_LIST_PARENT, string VEQUIPEMENT_FICHE_LIST_PARENT_ITEM_LIB, bool BEQUIPEMENT_FICHE_LIST_PARENT_ITEM_ACTIF)
        {


            using( SqlCommand sqlSave = new SqlCommand("[api_sp_Equipement_Admin_Fiche_ListParent_Item_Save]", MozartDatabase.cnxMozart))
            {
                sqlSave.CommandType = CommandType.StoredProcedure;
                sqlSave.Parameters.AddWithValue("@P_NIDEQUIPEMENT_FICHE_LIST_PARENT_ITEM", NIDEQUIPEMENT_FICHE_LIST_PARENT_ITEM);
                sqlSave.Parameters.AddWithValue("@P_NID_EQUIPEMENT_LIST_PARENT", NID_EQUIPEMENT_LIST_PARENT);                
                sqlSave.Parameters.AddWithValue("@P_VEQUIPEMENT_FICHE_LIST_PARENT_ITEM_LIB", VEQUIPEMENT_FICHE_LIST_PARENT_ITEM_LIB);
                sqlSave.Parameters.AddWithValue("@P_BEQUIPEMENT_FICHE_LIST_PARENT_ITEM_ACTIF", BEQUIPEMENT_FICHE_LIST_PARENT_ITEM_ACTIF);
                                
                sqlSave.ExecuteNonQuery();                

            }           

        }

        public static void Delete(int NIDEQUIPEMENT_FICHE_LIST_PARENT_ITEM)
        {


            using (SqlCommand sqlDel = new SqlCommand("[api_sp_Equipement_Admin_Fiche_ListParent_Item_Delete]", MozartDatabase.cnxMozart))
            {
                sqlDel.CommandType = CommandType.StoredProcedure;
                sqlDel.Parameters.AddWithValue("@P_NIDEQUIPEMENT_FICHE_LIST_PARENT_ITEM", NIDEQUIPEMENT_FICHE_LIST_PARENT_ITEM);

                sqlDel.ExecuteNonQuery();

            }

        }
    }
}
