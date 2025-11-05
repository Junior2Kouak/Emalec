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
    class CEQUIPEMENT_PREPA_INV_CLI
    {

        public DataTable _dt_Liste_Niv0;
        public DataTable _dt_Liste_Niv1;

        public Int32 NCLINUM;

        public CEQUIPEMENT_PREPA_INV_CLI(Int32 p_NCLINUM)
        {
            NCLINUM = p_NCLINUM;
        }

        public void LoadListe()
        {

            _dt_Liste_Niv0 = new DataTable();
            _dt_Liste_Niv1 = new DataTable();

            ModuleData.LoadData(_dt_Liste_Niv0, $"EXEC [api_sp_Equipement_Inventaire_Client_Detail_Lv0] {NCLINUM}");

            _dt_Liste_Niv0.Columns["BCONTRAT_EXISTS"].ReadOnly = false;
            _dt_Liste_Niv0.Columns["NB_EQUIP_CLI"].ReadOnly = false;


            ModuleData.LoadData(_dt_Liste_Niv1, $"EXEC [api_sp_Equipement_Inventaire_Client_Detail_Lv1] {NCLINUM}");

            _dt_Liste_Niv1.Columns["BEQUIPEMENT_SELECTED"].ReadOnly = false;                     

        }

        public void Refresh()
        {

            //on met à jour le nb d equipement par contrat
            foreach (DataRow DrUPdate in _dt_Liste_Niv0.Rows)
            {

                DataRow DrLv0 = _dt_Liste_Niv0.Select($"NTYPECONTRAT = {DrUPdate["NTYPECONTRAT"]}").FirstOrDefault();
                if (DrLv0 == null) break;

                if (_dt_Liste_Niv1.Select($"NTYPECONTRAT = {DrUPdate["NTYPECONTRAT"]} AND BEQUIPEMENT_SELECTED = 1").Count() == 0)
                {
                    DrLv0["NB_EQUIP_CLI"] = 0;
                }
                else
                {
                    DrLv0["NB_EQUIP_CLI"] = _dt_Liste_Niv1.GetChanges(DataRowState.Added | DataRowState.Modified | DataRowState.Unchanged).Select($"NTYPECONTRAT = {DrUPdate["NTYPECONTRAT"]} AND BEQUIPEMENT_SELECTED = 1").Count();
                }

            }

        }

        public void Save()
        {

            //save les contrats coché sans equipements
            //_dt_Liste_Niv0.AcceptChanges();
            //DataRow[] DrContratWoEquip = _dt_Liste_Niv0.Select("ISNULL([NB_EQUIP_CLI], 0) = 0");

            if(_dt_Liste_Niv0 != null && _dt_Liste_Niv0.GetChanges(DataRowState.Modified | DataRowState.Added | DataRowState.Deleted) != null)
            {
                foreach (DataRow Dr in _dt_Liste_Niv0.GetChanges(DataRowState.Modified | DataRowState.Added | DataRowState.Deleted).Rows)
                {
                    ModuleData.ExecuteNonQuery($"EXEC [api_sp_Equipement_Inventaire_Cli_Contrat_Save] {Dr["NID_EQUIPEMENT_CLI_CONTRAT"]}, {Dr["BCONTRAT_EXISTS"]}, {NCLINUM}, {Dr["NTYPECONTRAT"]}");
                }
                _dt_Liste_Niv0.AcceptChanges();
            }                        

            ////gestion des rows modified ou ajouter

            //Console.WriteLine($"{_dt_Liste_Niv1.GetChanges(DataRowState.Modified).Rows.Count}");


            //_dt_Liste_Niv1.AcceptChanges();           
            if(_dt_Liste_Niv1 != null &&  _dt_Liste_Niv1.GetChanges(DataRowState.Modified | DataRowState.Added | DataRowState.Deleted) != null)
            {
                foreach (DataRow DrUPdate in _dt_Liste_Niv1.GetChanges(DataRowState.Modified | DataRowState.Added | DataRowState.Deleted).Rows)
                {

                    ModuleData.ExecuteNonQuery($"EXEC [api_sp_Equipement_Inventaire_Cli_Save] {DrUPdate["BEQUIPEMENT_SELECTED"]} , {DrUPdate["NID_EQUIPEMENT_CLI"]}, {DrUPdate["NIDEQUIPEMENT"]}, {DrUPdate["NCLINUM"]}, {DrUPdate["NTYPECONTRAT"]}");

                }
                _dt_Liste_Niv1.AcceptChanges();
            }
            
            

        }
    }
}
