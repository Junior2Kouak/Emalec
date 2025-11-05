using MozartLib;
using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Excel = Microsoft.Office.Interop.Excel;
using MZUtils = MozartControls.Utils;

namespace MozartCS.Inventaire_Equipement
{
    class CInvEquipExportExcelFiche
    {

        //DataTable dtOut = new DataTable();
        //DataTable dt_data = new DataTable();
        DataColumn column;

        public DataTable dtOut { get; set; }
        public DataTable dt_data { get; set; }

        public CInvEquipExportExcelFiche(int NID_EQUIPEMENT_FICHE, List<Int32> lstInvSites)
        {

            dtOut = new DataTable();
            dt_data = new DataTable();

            dtOut.Columns.Add("VTYPECONTRAT", typeof(string));
            dtOut.Columns.Add("VLIBEQUIPEMENT", typeof(string));
            dtOut.Columns.Add("NSITNUM", typeof(string));
            dtOut.Columns.Add("NSITNUE", typeof(string));
            dtOut.Columns.Add("NSIT_INV_EQUIPEMENT_RECEIVE_ID", typeof(string));
            dtOut.Columns.Add("NID_EQUIPEMENT_FICHE_CHAP", typeof(string));
                     

            SqlCommand cmd = new SqlCommand("[api_sp_InvEquip_Export_listeColumnsByNumFiche]", MozartDatabase.cnxMozart);
            cmd.CommandType = CommandType.StoredProcedure;
            cmd.Parameters.AddWithValue("@P_NID_EQUIPEMENT_FICHE", NID_EQUIPEMENT_FICHE); // Numéro de fiche pour l'équipement
            SqlDataReader reader = cmd.ExecuteReader();
            //dtOut.Load(reader);
            while (reader.Read())
            {
                column = new DataColumn();
                column.DataType = Type.GetType("System.String");
                column.ColumnName = reader["NID_EQUIPEMENT_FICHE_ITEM"].ToString();
                dtOut.Columns.Add(column);                
            }

           

            reader.Close();
            reader.Dispose();
            //on charge les données des sites
            cmd = new SqlCommand("[api_sp_InvEquip_Export_DataByNumFiche]", MozartDatabase.cnxMozart);
            cmd.CommandType = CommandType.StoredProcedure;
            cmd.Parameters.AddWithValue("@P_LST_NSIT_INV_ID", string.Join(",", lstInvSites));  // Liste des sites à filtrer 
            cmd.Parameters.AddWithValue("@P_NID_EQUIPEMENT_FICHE", NID_EQUIPEMENT_FICHE); // Numéro de fiche pour l'équipement
            dt_data.Load(cmd.ExecuteReader());

            //on charge par équipement          
            foreach (Int32 NSIT_INV_EQUIPEMENT_RECEIVE_ID in dt_data.AsEnumerable().Select(slt => slt["NSIT_INV_EQUIPEMENT_RECEIVE_ID"]).Distinct())
            {
                DataRow drNew = dtOut.NewRow();
                drNew["NSIT_INV_EQUIPEMENT_RECEIVE_ID"] = NSIT_INV_EQUIPEMENT_RECEIVE_ID;

                foreach (DataRow row in dt_data.Select($"NSIT_INV_EQUIPEMENT_RECEIVE_ID = {NSIT_INV_EQUIPEMENT_RECEIVE_ID}"))
                {
                    
                    if (row != null)
                    {                        
                        
                        foreach (DataColumn col in dtOut.Columns)
                        {

                            switch (col.ColumnName)
                            {
                                case "NSITNUM":
                                    drNew["NSITNUM"] = dt_data.Select($"NSIT_INV_EQUIPEMENT_RECEIVE_ID = {NSIT_INV_EQUIPEMENT_RECEIVE_ID}").FirstOrDefault()["NSITNUM"].ToString();
                                    break;

                                case "NSITNUE":
                                    drNew["NSITNUE"] = dt_data.Select($"NSIT_INV_EQUIPEMENT_RECEIVE_ID = {NSIT_INV_EQUIPEMENT_RECEIVE_ID}").FirstOrDefault()["NSITNUE"].ToString();
                                    break;

                                case "NID_EQUIPEMENT_FICHE_CHAP":
                                    drNew["NID_EQUIPEMENT_FICHE_CHAP"] = dt_data.Select($"NSIT_INV_EQUIPEMENT_RECEIVE_ID = {NSIT_INV_EQUIPEMENT_RECEIVE_ID}").FirstOrDefault()["NID_EQUIPEMENT_FICHE_CHAP"].ToString();
                                    break;

                                case "NSIT_INV_EQUIPEMENT_RECEIVE_ID":
                                    break;

                                case "VLIBEQUIPEMENT":
                                    drNew["VLIBEQUIPEMENT"] = dt_data.Select($"NSIT_INV_EQUIPEMENT_RECEIVE_ID = {NSIT_INV_EQUIPEMENT_RECEIVE_ID}").FirstOrDefault()["VLIBEQUIPEMENT"].ToString();
                                    break;
                                case "VTYPECONTRAT":
                                    drNew["VTYPECONTRAT"] = dt_data.Select($"NSIT_INV_EQUIPEMENT_RECEIVE_ID = {NSIT_INV_EQUIPEMENT_RECEIVE_ID}").FirstOrDefault()["VTYPECONTRAT"].ToString();
                                    break;

                                default:
                                    //on test si la colonne exists
                                    if (dtOut.Columns.Contains(col.ColumnName) && dt_data.Select($"NID_EQUIPEMENT_FICHE_ITEM = {col.ColumnName} AND NSIT_INV_EQUIPEMENT_RECEIVE_ID = {NSIT_INV_EQUIPEMENT_RECEIVE_ID}").Count() > 0)
                                    {
                                        drNew[col.ColumnName] = dt_data.Select($"NID_EQUIPEMENT_FICHE_ITEM = {col.ColumnName} AND NSIT_INV_EQUIPEMENT_RECEIVE_ID = {NSIT_INV_EQUIPEMENT_RECEIVE_ID}").FirstOrDefault()["OVALUE"].ToString();
                                    }

                                    break;
                            }                            
                        }
                        
                    }
                    
                }

                dtOut.Rows.Add(drNew);
            }

            return;

        }
       

    }
}

