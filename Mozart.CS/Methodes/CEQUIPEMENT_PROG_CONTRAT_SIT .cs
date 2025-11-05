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
    class CEQUIPEMENT_PROG_CONTRAT_SIT
    {

        public DataTable _dt_Liste_Niv0;
       
        public Int32 NCLINUM;

        public CEQUIPEMENT_PROG_CONTRAT_SIT(Int32 p_NCLINUM)
        {
            NCLINUM = p_NCLINUM;
        }

        public void LoadListe()
        {

            _dt_Liste_Niv0 = new DataTable();
          

            ModuleData.LoadData(_dt_Liste_Niv0, $"EXEC [api_sp_Equipement_Inventaire_Site_Contrat_Lv0] {NCLINUM}");

            _dt_Liste_Niv0.Columns["BEQUIPEMENT_SIT_CONTRAT_GESTION"].ReadOnly = false;
            _dt_Liste_Niv0.Columns["NEQUIPEMENT_SIT_CONTRAT_DUREE"].ReadOnly = false;
            _dt_Liste_Niv0.Columns["NEQUIPEMENT_SIT_CONTRAT_MONTANT"].ReadOnly = false;            

        }

        //public void Refresh()
        //{

        //    //on met à jour le nb d equipement par contrat
        //    foreach (DataRow DrUPdate in _dt_Liste_Niv0.Rows)
        //    {

        //        DataRow DrLv0 = _dt_Liste_Niv0.Select($"NTYPECONTRAT = {DrUPdate["NTYPECONTRAT"]}").FirstOrDefault();
        //        if (DrLv0 == null) break;

        //        if (_dt_Liste_Niv1.Select($"NTYPECONTRAT = {DrUPdate["NTYPECONTRAT"]} AND BEQUIPEMENT_SELECTED = 1").Count() == 0)
        //        {
        //            DrLv0["NB_EQUIP_CLI"] = 0;
        //        }
        //        else
        //        {
        //            DrLv0["NB_EQUIP_CLI"] = _dt_Liste_Niv1.GetChanges(DataRowState.Added | DataRowState.Modified | DataRowState.Unchanged).Select($"NTYPECONTRAT = {DrUPdate["NTYPECONTRAT"]} AND BEQUIPEMENT_SELECTED = 1").Count();
        //        }

        //    }

        //}

        public void Save()
        {            
            if (_dt_Liste_Niv0 != null && _dt_Liste_Niv0.GetChanges(DataRowState.Modified | DataRowState.Added | DataRowState.Deleted) != null)
            {
                foreach (DataRow DrUPdate in _dt_Liste_Niv0.GetChanges(DataRowState.Modified | DataRowState.Added | DataRowState.Deleted).Rows)
                {

                    //ModuleData.ExecuteNonQuery($"EXEC [api_sp_Equipement_Inventaire_Site_Contrat_Save] {DrUPdate["NID_EQUIPEMENT_SIT_CONTRAT"]}, " +
                    //                             $"  {DrUPdate["NSITNUM"]}, {DrUPdate["NTYPECONTRAT"]}, " +
                    //                             $" {(DrUPdate["BEQUIPEMENT_SIT_CONTRAT_GESTION"] == null || DrUPdate["BEQUIPEMENT_SIT_CONTRAT_GESTION"].ToString() == "" ? "null" : DrUPdate["BEQUIPEMENT_SIT_CONTRAT_GESTION"])}," +
                    //                             $" {(DrUPdate["NEQUIPEMENT_SIT_CONTRAT_DUREE"] == null || DrUPdate["NEQUIPEMENT_SIT_CONTRAT_DUREE"].ToString() == "" ? "null" : DrUPdate["NEQUIPEMENT_SIT_CONTRAT_DUREE"])}," +
                    //                             $" {(DrUPdate["NEQUIPEMENT_SIT_CONTRAT_MONTANT"] == null || DrUPdate["NEQUIPEMENT_SIT_CONTRAT_MONTANT"].ToString() == "" ? "null" : DrUPdate["NEQUIPEMENT_SIT_CONTRAT_MONTANT"])}");

                    using (SqlCommand sqlCmdSave = new SqlCommand("api_sp_Equipement_Inventaire_Site_Contrat_Save", MozartDatabase.cnxMozart))
                    {
                        sqlCmdSave.CommandType = CommandType.StoredProcedure;
                        sqlCmdSave.Parameters.Add("@P_NID_EQUIPEMENT_SIT_CONTRAT", SqlDbType.Int).Value = DrUPdate["NID_EQUIPEMENT_SIT_CONTRAT"];
                        sqlCmdSave.Parameters.Add("@P_NSITNUM", SqlDbType.Int).Value = DrUPdate["NSITNUM"];
                        sqlCmdSave.Parameters.Add("@P_NTYPECONTRAT", SqlDbType.Int).Value = DrUPdate["NTYPECONTRAT"];
                        sqlCmdSave.Parameters.Add("@P_BEQUIPEMENT_SIT_CONTRAT_GESTION", SqlDbType.Bit).Value = (DrUPdate["BEQUIPEMENT_SIT_CONTRAT_GESTION"] == null || DrUPdate["BEQUIPEMENT_SIT_CONTRAT_GESTION"].ToString() == "" ? DBNull.Value : DrUPdate["BEQUIPEMENT_SIT_CONTRAT_GESTION"]);
                        sqlCmdSave.Parameters.Add("@P_NEQUIPEMENT_SIT_CONTRAT_DUREE", SqlDbType.Decimal).Value = (DrUPdate["NEQUIPEMENT_SIT_CONTRAT_DUREE"] == null || DrUPdate["NEQUIPEMENT_SIT_CONTRAT_DUREE"].ToString() == "" ? DBNull.Value : DrUPdate["NEQUIPEMENT_SIT_CONTRAT_DUREE"]);
                        sqlCmdSave.Parameters.Add("@P_NEQUIPEMENT_SIT_CONTRAT_MONTANT", SqlDbType.Decimal).Value = (DrUPdate["NEQUIPEMENT_SIT_CONTRAT_MONTANT"] == null || DrUPdate["NEQUIPEMENT_SIT_CONTRAT_MONTANT"].ToString() == "" ? DBNull.Value : DrUPdate["NEQUIPEMENT_SIT_CONTRAT_MONTANT"]);
                        sqlCmdSave.ExecuteNonQuery();
                    }

                }
                _dt_Liste_Niv0.AcceptChanges();
            }
        }

    }
}
