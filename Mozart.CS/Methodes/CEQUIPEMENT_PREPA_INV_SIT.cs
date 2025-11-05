using MozartLib;
using MozartNet;
using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Diagnostics;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MozartCS
{
    class CEQUIPEMENT_PREPA_INV_SIT
    {

        public DataTable _dt_Liste_Niv0;
        public DataTable _dt_Liste_Niv1;

        public Int32 NCLINUM;

        public CEQUIPEMENT_PREPA_INV_SIT(Int32 p_NCLINUM)
        {
            NCLINUM = p_NCLINUM;
        }

        public void LoadListe()
        {

            _dt_Liste_Niv0 = new DataTable();
            _dt_Liste_Niv1 = new DataTable();

            ModuleData.LoadData(_dt_Liste_Niv0, $"EXEC [api_sp_Equipement_Inventaire_Site_Detail_Lv0] {NCLINUM}");

            //_dt_Liste_Niv0.Columns["BCONTRAT_EXISTS"].ReadOnly = false;
            //_dt_Liste_Niv0.Columns["NB_EQUIP_CLI"].ReadOnly = false;


            ModuleData.LoadData(_dt_Liste_Niv1, $"EXEC [api_sp_Equipement_Inventaire_Site_Detail_Lv1] {NCLINUM}");

            _dt_Liste_Niv1.Columns["BEQUIPEMENT_SIT_GESTION"].ReadOnly = false;                     


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
              
            if(_dt_Liste_Niv1 != null  &&  _dt_Liste_Niv1.GetChanges(DataRowState.Modified | DataRowState.Added | DataRowState.Deleted) != null)
            {
                foreach (DataRow DrUPdate in _dt_Liste_Niv1.GetChanges(DataRowState.Modified | DataRowState.Added | DataRowState.Deleted).Rows)
                {

                    Debug.WriteLine(DrUPdate["VSITNOM"] + " " + DrUPdate["BEQUIPEMENT_SIT_GESTION"].ToString());

                    MozartDatabase.ExecuteNonQuery($"EXEC [api_sp_Equipement_Inventaire_Site_Save] {DrUPdate["NID_EQUIPEMENT_SIT"]}, " +
                                                 $"  {DrUPdate["NID_EQUIPEMENT_CLI"]}, {DrUPdate["NSITNUM"]}, " +
                                                 $" {(DrUPdate["BEQUIPEMENT_SIT_GESTION"] == null || DrUPdate["BEQUIPEMENT_SIT_GESTION"].ToString() == "" ? "null" : DrUPdate["BEQUIPEMENT_SIT_GESTION"])}");

                    MozartDatabase.ExecuteNonQuery($"EXEC [api_sp_Equipement_Inventaire_Site_Contrat_DeleteWoEquipement] {DrUPdate["NSITNUM"]}");

                }
                _dt_Liste_Niv1.AcceptChanges();
            }       
        }
        
    }
}
