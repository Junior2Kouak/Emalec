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
    class CADMIN_EQUIPEMENT
    {

        public DataTable _dt_Liste_Niv0;
        public DataTable _dt_Liste_Niv1;
       
        public void LoadListe()
        {

            _dt_Liste_Niv0 = new DataTable();
            _dt_Liste_Niv1 = new DataTable();

            //_dt_Equip_To_Delete = new DataTable();

            //_dt_Equip_To_Delete.Columns.Add("NIDEQUIPEMENT", typeof(Int32));
            //_dt_Liste_Niv0.Columns.Add("VTYPECONTRAT", typeof(string));
            //_dt_Liste_Niv0.Columns.Add("NB_EQUIP", typeof(Int32));

            ModuleData.LoadData(_dt_Liste_Niv0, $"EXEC [api_sp_Equipement_Admin_Liste_Contrats]");

            _dt_Liste_Niv0.Columns["NB_EQUIP"].ReadOnly = false;


            DataColumn Col_ID_Unique = new DataColumn();
            Col_ID_Unique.DataType = System.Type.GetType("System.Int32");
            Col_ID_Unique.AutoIncrement = true;
            Col_ID_Unique.AutoIncrementSeed = 1;
            Col_ID_Unique.AutoIncrementStep = 1;
            Col_ID_Unique.AllowDBNull = false;
            Col_ID_Unique.ColumnName = "ID_UNIQUE";

            _dt_Liste_Niv1.Columns.Add(Col_ID_Unique);

            ModuleData.LoadData(_dt_Liste_Niv1, $"EXEC [api_sp_Equipement_Admin_in_Liste]");

           

            //_dt_Liste_Niv1.ColumnChanged

            ////var dt = _dt_Liste_Niv1.AsEnumerable().GroupBy(r => r["NTYPECONTRAT"]).Select(group => new { key = group.Key, cpt = group.Count() });

            //var query = from row in _dt_Liste_Niv1.AsEnumerable()
            //            //where row.Field<Int32?>("NIDEQUIPEMENT") != null
            //            group row by row.Field<Int32>("NTYPECONTRAT") into Equip
            //            orderby Equip.Key
            //            select new
            //            {
            //                NTYPECONTRAT = Equip.Key,
            //                VTYPECONTRAT = Equip.First().Field<string>("VTYPECONTRAT")                            
            //            };

            //// print result
            //foreach (var dr_lvl0 in query)
            //{
            //    DataRow Dr_New = _dt_Liste_Niv0.NewRow();

            //    Dr_New["NTYPECONTRAT"] = dr_lvl0.NTYPECONTRAT;
            //    Dr_New["VTYPECONTRAT"] = dr_lvl0.VTYPECONTRAT;
            //    Dr_New["NB_EQUIP"] = (_dt_Liste_Niv1.Select($"NTYPECONTRAT = {dr_lvl0.NTYPECONTRAT} AND NIDEQUIPEMENT IS NOT NULL").Count());

            //    _dt_Liste_Niv0.Rows.Add(Dr_New);

            //}

            //_dt_Liste_Niv1 = _dt_Liste_Niv1.Select("[NIDEQUIPEMENT] IS NOT NULL").Count() == 0 ? null : _dt_Liste_Niv1.Select("[NIDEQUIPEMENT] IS NOT NULL").CopyToDataTable();

        }

        public void Refresh()
        {

            //on met à jour le nb d equipement par contrat
            foreach (DataRow DrUPdate in _dt_Liste_Niv0.Rows)
            {

                DataRow DrLv0 = _dt_Liste_Niv0.Select($"NTYPECONTRAT = {DrUPdate["NTYPECONTRAT"]}").FirstOrDefault();
                if (DrLv0 == null) break;

                if (_dt_Liste_Niv1.Select($"NTYPECONTRAT = {DrUPdate["NTYPECONTRAT"]}").Count() == 0)
                {
                    DrLv0["NB_EQUIP"] = 0;
                }
                else
                {
                    DrLv0["NB_EQUIP"] = _dt_Liste_Niv1.GetChanges(DataRowState.Added | DataRowState.Modified | DataRowState.Unchanged).Select($"NTYPECONTRAT = {DrUPdate["NTYPECONTRAT"]}").Count();

                }


            }

        }

        public void Save()
        {

            //gestion des rows deleted
            //if(_dt_Equip_To_Delete != null)
            //{
            //    foreach (DataRow DrDel in _dt_Equip_To_Delete.Rows)
            //    {

            //        if ((int)DrDel["NIDEQUIPEMENT"] > 0)
            //        {
            //            ModuleData.ExecuteNonQuery($"EXEC [api_sp_Equipement_Delete] {DrDel["NIDEQUIPEMENT", DataRowVersion.Original]}");
            //        }

            //    }
            //}

            //gestion des rows modified ou ajouter
            if (_dt_Liste_Niv1.GetChanges(DataRowState.Deleted) != null)
            {
                foreach (DataRow DrDel in _dt_Liste_Niv1.GetChanges(DataRowState.Deleted).Rows)
                {
                    ModuleData.ExecuteNonQuery($"EXEC [api_sp_Equipement_Delete] {DrDel["NIDEQUIPEMENT", DataRowVersion.Original]}");
                }
            }


            //gestion des rows modified ou ajouter
            if (_dt_Liste_Niv1.GetChanges(DataRowState.Added | DataRowState.Modified) != null)
            {
                foreach (DataRow DrUPdate in _dt_Liste_Niv1.GetChanges(DataRowState.Added | DataRowState.Modified).Rows)
                {
                    ModuleData.ExecuteNonQuery($"EXEC [api_sp_Equipement_Save] {DrUPdate["NIDEQUIPEMENT"]}, '{DrUPdate["VLIBEQUIPEMENT"].ToString().Replace("'", "''")}', {DrUPdate["BEQUIPEMENTACTIF"]}, {DrUPdate["NTYPECONTRAT"]}, {(DrUPdate["NID_EQUIPEMENT_FICHE"] == DBNull.Value ? 0 : DrUPdate["NID_EQUIPEMENT_FICHE"])}");
                }
            }           

            _dt_Liste_Niv1.AcceptChanges();

        }
    }
}
